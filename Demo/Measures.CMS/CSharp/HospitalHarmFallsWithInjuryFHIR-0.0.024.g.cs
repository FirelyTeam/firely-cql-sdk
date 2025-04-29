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
        CqlDateTime gzzzzzzzzzzzzzv_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime gzzzzzzzzzzzzzw_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> gzzzzzzzzzzzzzx_ = context.Operators.Interval(gzzzzzzzzzzzzzv_, gzzzzzzzzzzzzzw_, true, false);
        object gzzzzzzzzzzzzzy_ = context.ResolveParameter("HospitalHarmFallsWithInjuryFHIR-0.0.024", "Measurement Period", gzzzzzzzzzzzzzx_);

        return (CqlInterval<CqlDateTime>)gzzzzzzzzzzzzzy_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> gzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient hzzzzzzzzzzzzza_ = context.Operators.SingletonFrom<Patient>(gzzzzzzzzzzzzzz_);

        return hzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Qualifying Encounter")]
    public IEnumerable<Encounter> Qualifying_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> hzzzzzzzzzzzzzb_ = CQMCommon_2_2_000.Instance.Inpatient_Encounter(context);
        bool? hzzzzzzzzzzzzzc_(Encounter InpatientEncounter)
        {
            Patient hzzzzzzzzzzzzze_ = this.Patient(context);
            Date hzzzzzzzzzzzzzf_ = hzzzzzzzzzzzzze_?.BirthDateElement;
            string hzzzzzzzzzzzzzg_ = hzzzzzzzzzzzzzf_?.Value;
            CqlDate hzzzzzzzzzzzzzh_ = context.Operators.ConvertStringToDate(hzzzzzzzzzzzzzg_);
            Period hzzzzzzzzzzzzzi_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzzzzzi_);
            CqlDateTime hzzzzzzzzzzzzzk_ = context.Operators.Start(hzzzzzzzzzzzzzj_);
            CqlDate hzzzzzzzzzzzzzl_ = context.Operators.DateFrom(hzzzzzzzzzzzzzk_);
            int? hzzzzzzzzzzzzzm_ = context.Operators.CalculateAgeAt(hzzzzzzzzzzzzzh_, hzzzzzzzzzzzzzl_, "year");
            bool? hzzzzzzzzzzzzzn_ = context.Operators.GreaterOrEqual(hzzzzzzzzzzzzzm_, 18);

            return hzzzzzzzzzzzzzn_;
        };
        IEnumerable<Encounter> hzzzzzzzzzzzzzd_ = context.Operators.Where<Encounter>(hzzzzzzzzzzzzzb_, hzzzzzzzzzzzzzc_);

        return hzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> hzzzzzzzzzzzzzo_ = this.Qualifying_Encounter(context);

        return hzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> hzzzzzzzzzzzzzp_ = this.Initial_Population(context);

        return hzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Encounter with a Fall Not Present on Admission")]
    public IEnumerable<Encounter> Encounter_with_a_Fall_Not_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> hzzzzzzzzzzzzzq_ = this.Qualifying_Encounter(context);
        bool? hzzzzzzzzzzzzzr_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> hzzzzzzzzzzzzzt_ = InpatientEncounter?.Diagnosis;
            bool? hzzzzzzzzzzzzzu_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference hzzzzzzzzzzzzzx_ = Dx?.Condition;
                Condition hzzzzzzzzzzzzzy_ = CQMCommon_2_2_000.Instance.GetCondition(context, hzzzzzzzzzzzzzx_);
                CodeableConcept hzzzzzzzzzzzzzz_ = hzzzzzzzzzzzzzy_?.Code;
                CqlConcept izzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, hzzzzzzzzzzzzzz_);
                CqlValueSet izzzzzzzzzzzzzb_ = this.Inpatient_Falls(context);
                bool? izzzzzzzzzzzzzc_ = context.Operators.ConceptInValueSet(izzzzzzzzzzzzza_, izzzzzzzzzzzzzb_);
                bool? izzzzzzzzzzzzzd_(Extension @this)
                {
                    string izzzzzzzzzzzzzm_ = @this?.Url;
                    FhirString izzzzzzzzzzzzzn_ = context.Operators.Convert<FhirString>(izzzzzzzzzzzzzm_);
                    string izzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToString(context, izzzzzzzzzzzzzn_);
                    bool? izzzzzzzzzzzzzp_ = context.Operators.Equal(izzzzzzzzzzzzzo_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return izzzzzzzzzzzzzp_;
                };
                IEnumerable<Extension> izzzzzzzzzzzzze_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), izzzzzzzzzzzzzd_);
                object izzzzzzzzzzzzzf_(Extension @this)
                {
                    DataType izzzzzzzzzzzzzq_ = @this?.Value;

                    return izzzzzzzzzzzzzq_;
                };
                IEnumerable<object> izzzzzzzzzzzzzg_ = context.Operators.Select<Extension, object>(izzzzzzzzzzzzze_, izzzzzzzzzzzzzf_);
                object izzzzzzzzzzzzzh_ = context.Operators.SingletonFrom<object>(izzzzzzzzzzzzzg_);
                CqlConcept izzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, izzzzzzzzzzzzzh_ as CodeableConcept);
                CqlValueSet izzzzzzzzzzzzzj_ = this.Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine(context);
                bool? izzzzzzzzzzzzzk_ = context.Operators.ConceptInValueSet(izzzzzzzzzzzzzi_, izzzzzzzzzzzzzj_);
                bool? izzzzzzzzzzzzzl_ = context.Operators.And(izzzzzzzzzzzzzc_, izzzzzzzzzzzzzk_);

                return izzzzzzzzzzzzzl_;
            };
            IEnumerable<Encounter.DiagnosisComponent> hzzzzzzzzzzzzzv_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)hzzzzzzzzzzzzzt_, hzzzzzzzzzzzzzu_);
            bool? hzzzzzzzzzzzzzw_ = context.Operators.Exists<Encounter.DiagnosisComponent>(hzzzzzzzzzzzzzv_);

            return hzzzzzzzzzzzzzw_;
        };
        IEnumerable<Encounter> hzzzzzzzzzzzzzs_ = context.Operators.Where<Encounter>(hzzzzzzzzzzzzzq_, hzzzzzzzzzzzzzr_);

        return hzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Encounter with a Fall Event")]
    public IEnumerable<Encounter> Encounter_with_a_Fall_Event(CqlContext context)
    {
        IEnumerable<Encounter> izzzzzzzzzzzzzr_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> izzzzzzzzzzzzzs_(Encounter InpatientEncounter)
        {
            CqlValueSet izzzzzzzzzzzzzu_ = this.Inpatient_Falls(context);
            IEnumerable<AdverseEvent> izzzzzzzzzzzzzv_ = context.Operators.Retrieve<AdverseEvent>(new RetrieveParameters(default, izzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-adverseevent"));
            bool? izzzzzzzzzzzzzw_(AdverseEvent FallsDocumentation)
            {
                FhirDateTime jzzzzzzzzzzzzza_ = FallsDocumentation?.DateElement;
                CqlDateTime jzzzzzzzzzzzzzb_ = context.Operators.Convert<CqlDateTime>(jzzzzzzzzzzzzza_);
                FhirDateTime jzzzzzzzzzzzzzc_ = FallsDocumentation?.RecordedDateElement;
                CqlDateTime jzzzzzzzzzzzzzd_ = context.Operators.Convert<CqlDateTime>(jzzzzzzzzzzzzzc_);
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzze_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, InpatientEncounter);
                bool? jzzzzzzzzzzzzzf_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzzzzzb_ ?? jzzzzzzzzzzzzzd_, jzzzzzzzzzzzzze_, default);

                return jzzzzzzzzzzzzzf_;
            };
            IEnumerable<AdverseEvent> izzzzzzzzzzzzzx_ = context.Operators.Where<AdverseEvent>(izzzzzzzzzzzzzv_, izzzzzzzzzzzzzw_);
            Encounter izzzzzzzzzzzzzy_(AdverseEvent FallsDocumentation) =>
                InpatientEncounter;
            IEnumerable<Encounter> izzzzzzzzzzzzzz_ = context.Operators.Select<AdverseEvent, Encounter>(izzzzzzzzzzzzzx_, izzzzzzzzzzzzzy_);

            return izzzzzzzzzzzzzz_;
        };
        IEnumerable<Encounter> izzzzzzzzzzzzzt_ = context.Operators.SelectMany<Encounter, Encounter>(izzzzzzzzzzzzzr_, izzzzzzzzzzzzzs_);

        return izzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Encounter where a Fall Occurred")]
    public IEnumerable<Encounter> Encounter_where_a_Fall_Occurred(CqlContext context)
    {
        IEnumerable<Encounter> jzzzzzzzzzzzzzg_ = this.Encounter_with_a_Fall_Not_Present_on_Admission(context);
        IEnumerable<Encounter> jzzzzzzzzzzzzzh_ = this.Encounter_with_a_Fall_Event(context);
        IEnumerable<Encounter> jzzzzzzzzzzzzzi_ = context.Operators.Union<Encounter>(jzzzzzzzzzzzzzg_, jzzzzzzzzzzzzzh_);

        return jzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Encounter where a Fall and Major Injury Occurred")]
    public IEnumerable<Encounter> Encounter_where_a_Fall_and_Major_Injury_Occurred(CqlContext context)
    {
        IEnumerable<Encounter> jzzzzzzzzzzzzzj_ = this.Encounter_where_a_Fall_Occurred(context);
        bool? jzzzzzzzzzzzzzk_(Encounter FallOccurred)
        {
            List<Encounter.DiagnosisComponent> jzzzzzzzzzzzzzm_ = FallOccurred?.Diagnosis;
            bool? jzzzzzzzzzzzzzn_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference jzzzzzzzzzzzzzq_ = Dx?.Condition;
                Condition jzzzzzzzzzzzzzr_ = CQMCommon_2_2_000.Instance.GetCondition(context, jzzzzzzzzzzzzzq_);
                CodeableConcept jzzzzzzzzzzzzzs_ = jzzzzzzzzzzzzzr_?.Code;
                CqlConcept jzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, jzzzzzzzzzzzzzs_);
                CqlValueSet jzzzzzzzzzzzzzu_ = this.Major_Injuries(context);
                bool? jzzzzzzzzzzzzzv_ = context.Operators.ConceptInValueSet(jzzzzzzzzzzzzzt_, jzzzzzzzzzzzzzu_);
                bool? jzzzzzzzzzzzzzw_(Extension @this)
                {
                    string kzzzzzzzzzzzzzm_ = @this?.Url;
                    FhirString kzzzzzzzzzzzzzn_ = context.Operators.Convert<FhirString>(kzzzzzzzzzzzzzm_);
                    string kzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToString(context, kzzzzzzzzzzzzzn_);
                    bool? kzzzzzzzzzzzzzp_ = context.Operators.Equal(kzzzzzzzzzzzzzo_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return kzzzzzzzzzzzzzp_;
                };
                IEnumerable<Extension> jzzzzzzzzzzzzzx_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), jzzzzzzzzzzzzzw_);
                object jzzzzzzzzzzzzzy_(Extension @this)
                {
                    DataType kzzzzzzzzzzzzzq_ = @this?.Value;

                    return kzzzzzzzzzzzzzq_;
                };
                IEnumerable<object> jzzzzzzzzzzzzzz_ = context.Operators.Select<Extension, object>(jzzzzzzzzzzzzzx_, jzzzzzzzzzzzzzy_);
                object kzzzzzzzzzzzzza_ = context.Operators.SingletonFrom<object>(jzzzzzzzzzzzzzz_);
                CqlConcept kzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, kzzzzzzzzzzzzza_ as CodeableConcept);
                CqlValueSet kzzzzzzzzzzzzzc_ = this.Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine(context);
                bool? kzzzzzzzzzzzzzd_ = context.Operators.ConceptInValueSet(kzzzzzzzzzzzzzb_, kzzzzzzzzzzzzzc_);
                bool? kzzzzzzzzzzzzze_(Extension @this)
                {
                    string kzzzzzzzzzzzzzr_ = @this?.Url;
                    FhirString kzzzzzzzzzzzzzs_ = context.Operators.Convert<FhirString>(kzzzzzzzzzzzzzr_);
                    string kzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToString(context, kzzzzzzzzzzzzzs_);
                    bool? kzzzzzzzzzzzzzu_ = context.Operators.Equal(kzzzzzzzzzzzzzt_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return kzzzzzzzzzzzzzu_;
                };
                IEnumerable<Extension> kzzzzzzzzzzzzzf_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), kzzzzzzzzzzzzze_);
                object kzzzzzzzzzzzzzg_(Extension @this)
                {
                    DataType kzzzzzzzzzzzzzv_ = @this?.Value;

                    return kzzzzzzzzzzzzzv_;
                };
                IEnumerable<object> kzzzzzzzzzzzzzh_ = context.Operators.Select<Extension, object>(kzzzzzzzzzzzzzf_, kzzzzzzzzzzzzzg_);
                object kzzzzzzzzzzzzzi_ = context.Operators.SingletonFrom<object>(kzzzzzzzzzzzzzh_);
                CqlConcept kzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, kzzzzzzzzzzzzzi_ as CodeableConcept);
                bool? kzzzzzzzzzzzzzk_ = context.Operators.Or(kzzzzzzzzzzzzzd_, (bool?)(kzzzzzzzzzzzzzj_ is null));
                bool? kzzzzzzzzzzzzzl_ = context.Operators.And(jzzzzzzzzzzzzzv_, kzzzzzzzzzzzzzk_);

                return kzzzzzzzzzzzzzl_;
            };
            IEnumerable<Encounter.DiagnosisComponent> jzzzzzzzzzzzzzo_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)jzzzzzzzzzzzzzm_, jzzzzzzzzzzzzzn_);
            bool? jzzzzzzzzzzzzzp_ = context.Operators.Exists<Encounter.DiagnosisComponent>(jzzzzzzzzzzzzzo_);

            return jzzzzzzzzzzzzzp_;
        };
        IEnumerable<Encounter> jzzzzzzzzzzzzzl_ = context.Operators.Where<Encounter>(jzzzzzzzzzzzzzj_, jzzzzzzzzzzzzzk_);

        return jzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Encounter with a Fall Present on Admission")]
    public IEnumerable<Encounter> Encounter_with_a_Fall_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> kzzzzzzzzzzzzzw_ = this.Qualifying_Encounter(context);
        bool? kzzzzzzzzzzzzzx_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> kzzzzzzzzzzzzzz_ = InpatientEncounter?.Diagnosis;
            bool? lzzzzzzzzzzzzza_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference lzzzzzzzzzzzzzd_ = Dx?.Condition;
                Condition lzzzzzzzzzzzzze_ = CQMCommon_2_2_000.Instance.GetCondition(context, lzzzzzzzzzzzzzd_);
                CodeableConcept lzzzzzzzzzzzzzf_ = lzzzzzzzzzzzzze_?.Code;
                CqlConcept lzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, lzzzzzzzzzzzzzf_);
                CqlValueSet lzzzzzzzzzzzzzh_ = this.Inpatient_Falls(context);
                bool? lzzzzzzzzzzzzzi_ = context.Operators.ConceptInValueSet(lzzzzzzzzzzzzzg_, lzzzzzzzzzzzzzh_);
                bool? lzzzzzzzzzzzzzj_(Extension @this)
                {
                    string lzzzzzzzzzzzzzs_ = @this?.Url;
                    FhirString lzzzzzzzzzzzzzt_ = context.Operators.Convert<FhirString>(lzzzzzzzzzzzzzs_);
                    string lzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToString(context, lzzzzzzzzzzzzzt_);
                    bool? lzzzzzzzzzzzzzv_ = context.Operators.Equal(lzzzzzzzzzzzzzu_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return lzzzzzzzzzzzzzv_;
                };
                IEnumerable<Extension> lzzzzzzzzzzzzzk_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), lzzzzzzzzzzzzzj_);
                object lzzzzzzzzzzzzzl_(Extension @this)
                {
                    DataType lzzzzzzzzzzzzzw_ = @this?.Value;

                    return lzzzzzzzzzzzzzw_;
                };
                IEnumerable<object> lzzzzzzzzzzzzzm_ = context.Operators.Select<Extension, object>(lzzzzzzzzzzzzzk_, lzzzzzzzzzzzzzl_);
                object lzzzzzzzzzzzzzn_ = context.Operators.SingletonFrom<object>(lzzzzzzzzzzzzzm_);
                CqlConcept lzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, lzzzzzzzzzzzzzn_ as CodeableConcept);
                CqlValueSet lzzzzzzzzzzzzzp_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? lzzzzzzzzzzzzzq_ = context.Operators.ConceptInValueSet(lzzzzzzzzzzzzzo_, lzzzzzzzzzzzzzp_);
                bool? lzzzzzzzzzzzzzr_ = context.Operators.And(lzzzzzzzzzzzzzi_, lzzzzzzzzzzzzzq_);

                return lzzzzzzzzzzzzzr_;
            };
            IEnumerable<Encounter.DiagnosisComponent> lzzzzzzzzzzzzzb_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)kzzzzzzzzzzzzzz_, lzzzzzzzzzzzzza_);
            bool? lzzzzzzzzzzzzzc_ = context.Operators.Exists<Encounter.DiagnosisComponent>(lzzzzzzzzzzzzzb_);

            return lzzzzzzzzzzzzzc_;
        };
        IEnumerable<Encounter> kzzzzzzzzzzzzzy_ = context.Operators.Where<Encounter>(kzzzzzzzzzzzzzw_, kzzzzzzzzzzzzzx_);

        return kzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Risk Variable All Encounter Diagnoses with Rank and POA Indication")]
    public IEnumerable<(CqlTupleMetadata, string encounterId, IEnumerable<ResourceReference> condition, IEnumerable<int?> rank, IEnumerable<Encounter.DiagnosisComponent> POA)?> Risk_Variable_All_Encounter_Diagnoses_with_Rank_and_POA_Indication(CqlContext context)
    {
        IEnumerable<Encounter> lzzzzzzzzzzzzzx_ = this.Qualifying_Encounter(context);
        (CqlTupleMetadata, string encounterId, IEnumerable<ResourceReference> condition, IEnumerable<int?> rank, IEnumerable<Encounter.DiagnosisComponent> POA)? lzzzzzzzzzzzzzy_(Encounter InpatientEncounter)
        {
            Id mzzzzzzzzzzzzzb_ = InpatientEncounter?.IdElement;
            string mzzzzzzzzzzzzzc_ = mzzzzzzzzzzzzzb_?.Value;
            List<Encounter.DiagnosisComponent> mzzzzzzzzzzzzzd_ = InpatientEncounter?.Diagnosis;
            bool? mzzzzzzzzzzzzze_(Encounter.DiagnosisComponent @this)
            {
                ResourceReference mzzzzzzzzzzzzzr_ = @this?.Condition;
                bool? mzzzzzzzzzzzzzs_ = context.Operators.Not((bool?)(mzzzzzzzzzzzzzr_ is null));

                return mzzzzzzzzzzzzzs_;
            };
            IEnumerable<Encounter.DiagnosisComponent> mzzzzzzzzzzzzzf_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)mzzzzzzzzzzzzzd_, mzzzzzzzzzzzzze_);
            ResourceReference mzzzzzzzzzzzzzg_(Encounter.DiagnosisComponent @this)
            {
                ResourceReference mzzzzzzzzzzzzzt_ = @this?.Condition;

                return mzzzzzzzzzzzzzt_;
            };
            IEnumerable<ResourceReference> mzzzzzzzzzzzzzh_ = context.Operators.Select<Encounter.DiagnosisComponent, ResourceReference>(mzzzzzzzzzzzzzf_, mzzzzzzzzzzzzzg_);
            bool? mzzzzzzzzzzzzzj_(Encounter.DiagnosisComponent @this)
            {
                PositiveInt mzzzzzzzzzzzzzu_ = @this?.RankElement;
                int? mzzzzzzzzzzzzzv_ = mzzzzzzzzzzzzzu_?.Value;
                bool? mzzzzzzzzzzzzzw_ = context.Operators.Not((bool?)(mzzzzzzzzzzzzzv_ is null));

                return mzzzzzzzzzzzzzw_;
            };
            IEnumerable<Encounter.DiagnosisComponent> mzzzzzzzzzzzzzk_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)mzzzzzzzzzzzzzd_, mzzzzzzzzzzzzzj_);
            int? mzzzzzzzzzzzzzl_(Encounter.DiagnosisComponent @this)
            {
                PositiveInt mzzzzzzzzzzzzzx_ = @this?.RankElement;
                int? mzzzzzzzzzzzzzy_ = mzzzzzzzzzzzzzx_?.Value;

                return mzzzzzzzzzzzzzy_;
            };
            IEnumerable<int?> mzzzzzzzzzzzzzm_ = context.Operators.Select<Encounter.DiagnosisComponent, int?>(mzzzzzzzzzzzzzk_, mzzzzzzzzzzzzzl_);
            bool? mzzzzzzzzzzzzzo_(Encounter.DiagnosisComponent Dx)
            {
                bool? mzzzzzzzzzzzzzz_(Extension @this)
                {
                    string nzzzzzzzzzzzzzh_ = @this?.Url;
                    FhirString nzzzzzzzzzzzzzi_ = context.Operators.Convert<FhirString>(nzzzzzzzzzzzzzh_);
                    string nzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToString(context, nzzzzzzzzzzzzzi_);
                    bool? nzzzzzzzzzzzzzk_ = context.Operators.Equal(nzzzzzzzzzzzzzj_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return nzzzzzzzzzzzzzk_;
                };
                IEnumerable<Extension> nzzzzzzzzzzzzza_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), mzzzzzzzzzzzzzz_);
                object nzzzzzzzzzzzzzb_(Extension @this)
                {
                    DataType nzzzzzzzzzzzzzl_ = @this?.Value;

                    return nzzzzzzzzzzzzzl_;
                };
                IEnumerable<object> nzzzzzzzzzzzzzc_ = context.Operators.Select<Extension, object>(nzzzzzzzzzzzzza_, nzzzzzzzzzzzzzb_);
                object nzzzzzzzzzzzzzd_ = context.Operators.SingletonFrom<object>(nzzzzzzzzzzzzzc_);
                CqlConcept nzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, nzzzzzzzzzzzzzd_ as CodeableConcept);
                CqlValueSet nzzzzzzzzzzzzzf_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? nzzzzzzzzzzzzzg_ = context.Operators.ConceptInValueSet(nzzzzzzzzzzzzze_, nzzzzzzzzzzzzzf_);

                return nzzzzzzzzzzzzzg_;
            };
            IEnumerable<Encounter.DiagnosisComponent> mzzzzzzzzzzzzzp_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)mzzzzzzzzzzzzzd_, mzzzzzzzzzzzzzo_);
            (CqlTupleMetadata, string encounterId, IEnumerable<ResourceReference> condition, IEnumerable<int?> rank, IEnumerable<Encounter.DiagnosisComponent> POA)? mzzzzzzzzzzzzzq_ = (CqlTupleMetadata_CCJaUjRHWSXeUTcFAfVeVeNaD, mzzzzzzzzzzzzzc_, mzzzzzzzzzzzzzh_, mzzzzzzzzzzzzzm_, mzzzzzzzzzzzzzp_);

            return mzzzzzzzzzzzzzq_;
        };
        IEnumerable<(CqlTupleMetadata, string encounterId, IEnumerable<ResourceReference> condition, IEnumerable<int?> rank, IEnumerable<Encounter.DiagnosisComponent> POA)?> lzzzzzzzzzzzzzz_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string encounterId, IEnumerable<ResourceReference> condition, IEnumerable<int?> rank, IEnumerable<Encounter.DiagnosisComponent> POA)?>(lzzzzzzzzzzzzzx_, lzzzzzzzzzzzzzy_);
        IEnumerable<(CqlTupleMetadata, string encounterId, IEnumerable<ResourceReference> condition, IEnumerable<int?> rank, IEnumerable<Encounter.DiagnosisComponent> POA)?> mzzzzzzzzzzzzza_ = context.Operators.Distinct<(CqlTupleMetadata, string encounterId, IEnumerable<ResourceReference> condition, IEnumerable<int?> rank, IEnumerable<Encounter.DiagnosisComponent> POA)?>(lzzzzzzzzzzzzzz_);

        return mzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Risk Variable All Encounter Principal Diagnoses")]
    public IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlConcept condition)?> Risk_Variable_All_Encounter_Principal_Diagnoses(CqlContext context)
    {
        IEnumerable<Encounter> nzzzzzzzzzzzzzm_ = this.Qualifying_Encounter(context);
        (CqlTupleMetadata, Encounter encounter, CqlConcept condition)? nzzzzzzzzzzzzzn_(Encounter InpatientEncounter)
        {
            Condition nzzzzzzzzzzzzzq_ = CQMCommon_2_2_000.Instance.PrincipalDiagnosis(context, InpatientEncounter);
            CodeableConcept nzzzzzzzzzzzzzr_ = nzzzzzzzzzzzzzq_?.Code;
            CqlConcept nzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, nzzzzzzzzzzzzzr_);
            (CqlTupleMetadata, Encounter encounter, CqlConcept condition)? nzzzzzzzzzzzzzt_ = (CqlTupleMetadata_CajFQjTXAXITWGJPNIjCafPiF, InpatientEncounter, nzzzzzzzzzzzzzs_);

            return nzzzzzzzzzzzzzt_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlConcept condition)?> nzzzzzzzzzzzzzo_ = context.Operators.Select<Encounter, (CqlTupleMetadata, Encounter encounter, CqlConcept condition)?>(nzzzzzzzzzzzzzm_, nzzzzzzzzzzzzzn_);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlConcept condition)?> nzzzzzzzzzzzzzp_ = context.Operators.Distinct<(CqlTupleMetadata, Encounter encounter, CqlConcept condition)?>(nzzzzzzzzzzzzzo_);

        return nzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Risk Variable Body Mass Index (BMI)")]
    public IEnumerable<CqlQuantity> Risk_Variable_Body_Mass_Index__BMI_(CqlContext context)
    {
        CqlCode nzzzzzzzzzzzzzu_ = this.Body_mass_index__BMI___Ratio_(context);
        IEnumerable<CqlCode> nzzzzzzzzzzzzzv_ = context.Operators.ToList<CqlCode>(nzzzzzzzzzzzzzu_);
        IEnumerable<Observation> nzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, nzzzzzzzzzzzzzv_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> nzzzzzzzzzzzzzx_(Observation BMI)
        {
            IEnumerable<Encounter> ozzzzzzzzzzzzzc_ = this.Qualifying_Encounter(context);
            bool? ozzzzzzzzzzzzzd_(Encounter InpatientEncounter)
            {
                DataType ozzzzzzzzzzzzzh_ = BMI?.Effective;
                object ozzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzh_);
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.ToInterval(context, ozzzzzzzzzzzzzi_);
                CqlDateTime ozzzzzzzzzzzzzk_ = context.Operators.Start(ozzzzzzzzzzzzzj_);
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzl_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, InpatientEncounter);
                bool? ozzzzzzzzzzzzzm_ = context.Operators.In<CqlDateTime>(ozzzzzzzzzzzzzk_, ozzzzzzzzzzzzzl_, default);
                DataType ozzzzzzzzzzzzzn_ = BMI?.Value;
                object ozzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzn_);
                bool? ozzzzzzzzzzzzzp_ = context.Operators.Not((bool?)(ozzzzzzzzzzzzzo_ is null));
                bool? ozzzzzzzzzzzzzq_ = context.Operators.And(ozzzzzzzzzzzzzm_, ozzzzzzzzzzzzzp_);
                Code<ObservationStatus> ozzzzzzzzzzzzzr_ = BMI?.StatusElement;
                ObservationStatus? ozzzzzzzzzzzzzs_ = ozzzzzzzzzzzzzr_?.Value;
                Code<ObservationStatus> ozzzzzzzzzzzzzt_ = context.Operators.Convert<Code<ObservationStatus>>(ozzzzzzzzzzzzzs_);
                string ozzzzzzzzzzzzzu_ = context.Operators.Convert<string>(ozzzzzzzzzzzzzt_);
                string[] ozzzzzzzzzzzzzv_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ozzzzzzzzzzzzzw_ = context.Operators.In<string>(ozzzzzzzzzzzzzu_, ozzzzzzzzzzzzzv_ as IEnumerable<string>);
                bool? ozzzzzzzzzzzzzx_ = context.Operators.And(ozzzzzzzzzzzzzq_, ozzzzzzzzzzzzzw_);

                return ozzzzzzzzzzzzzx_;
            };
            IEnumerable<Encounter> ozzzzzzzzzzzzze_ = context.Operators.Where<Encounter>(ozzzzzzzzzzzzzc_, ozzzzzzzzzzzzzd_);
            Observation ozzzzzzzzzzzzzf_(Encounter InpatientEncounter) =>
                BMI;
            IEnumerable<Observation> ozzzzzzzzzzzzzg_ = context.Operators.Select<Encounter, Observation>(ozzzzzzzzzzzzze_, ozzzzzzzzzzzzzf_);

            return ozzzzzzzzzzzzzg_;
        };
        IEnumerable<Observation> nzzzzzzzzzzzzzy_ = context.Operators.SelectMany<Observation, Observation>(nzzzzzzzzzzzzzw_, nzzzzzzzzzzzzzx_);
        CqlQuantity nzzzzzzzzzzzzzz_(Observation BMI)
        {
            DataType ozzzzzzzzzzzzzy_ = BMI?.Value;
            object ozzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzy_);

            return ozzzzzzzzzzzzzz_ as CqlQuantity;
        };
        IEnumerable<CqlQuantity> ozzzzzzzzzzzzza_ = context.Operators.Select<Observation, CqlQuantity>(nzzzzzzzzzzzzzy_, nzzzzzzzzzzzzzz_);
        IEnumerable<CqlQuantity> ozzzzzzzzzzzzzb_ = context.Operators.Distinct<CqlQuantity>(ozzzzzzzzzzzzza_);

        return ozzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Abnormal Weight Loss or Malnutrition Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Abnormal_Weight_Loss_or_Malnutrition_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> pzzzzzzzzzzzzza_ = this.Qualifying_Encounter(context);
        bool? pzzzzzzzzzzzzzb_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> pzzzzzzzzzzzzzd_ = InpatientEncounter?.Diagnosis;
            bool? pzzzzzzzzzzzzze_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference pzzzzzzzzzzzzzh_ = Dx?.Condition;
                Condition pzzzzzzzzzzzzzi_ = CQMCommon_2_2_000.Instance.GetCondition(context, pzzzzzzzzzzzzzh_);
                CodeableConcept pzzzzzzzzzzzzzj_ = pzzzzzzzzzzzzzi_?.Code;
                CqlConcept pzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, pzzzzzzzzzzzzzj_);
                CqlValueSet pzzzzzzzzzzzzzl_ = this.Abnormal_Weight_Loss_and_Malnutrition(context);
                bool? pzzzzzzzzzzzzzm_ = context.Operators.ConceptInValueSet(pzzzzzzzzzzzzzk_, pzzzzzzzzzzzzzl_);
                bool? pzzzzzzzzzzzzzn_(Extension @this)
                {
                    string pzzzzzzzzzzzzzw_ = @this?.Url;
                    FhirString pzzzzzzzzzzzzzx_ = context.Operators.Convert<FhirString>(pzzzzzzzzzzzzzw_);
                    string pzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToString(context, pzzzzzzzzzzzzzx_);
                    bool? pzzzzzzzzzzzzzz_ = context.Operators.Equal(pzzzzzzzzzzzzzy_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return pzzzzzzzzzzzzzz_;
                };
                IEnumerable<Extension> pzzzzzzzzzzzzzo_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), pzzzzzzzzzzzzzn_);
                object pzzzzzzzzzzzzzp_(Extension @this)
                {
                    DataType qzzzzzzzzzzzzza_ = @this?.Value;

                    return qzzzzzzzzzzzzza_;
                };
                IEnumerable<object> pzzzzzzzzzzzzzq_ = context.Operators.Select<Extension, object>(pzzzzzzzzzzzzzo_, pzzzzzzzzzzzzzp_);
                object pzzzzzzzzzzzzzr_ = context.Operators.SingletonFrom<object>(pzzzzzzzzzzzzzq_);
                CqlConcept pzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, pzzzzzzzzzzzzzr_ as CodeableConcept);
                CqlValueSet pzzzzzzzzzzzzzt_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? pzzzzzzzzzzzzzu_ = context.Operators.ConceptInValueSet(pzzzzzzzzzzzzzs_, pzzzzzzzzzzzzzt_);
                bool? pzzzzzzzzzzzzzv_ = context.Operators.And(pzzzzzzzzzzzzzm_, pzzzzzzzzzzzzzu_);

                return pzzzzzzzzzzzzzv_;
            };
            IEnumerable<Encounter.DiagnosisComponent> pzzzzzzzzzzzzzf_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)pzzzzzzzzzzzzzd_, pzzzzzzzzzzzzze_);
            bool? pzzzzzzzzzzzzzg_ = context.Operators.Exists<Encounter.DiagnosisComponent>(pzzzzzzzzzzzzzf_);

            return pzzzzzzzzzzzzzg_;
        };
        IEnumerable<Encounter> pzzzzzzzzzzzzzc_ = context.Operators.Where<Encounter>(pzzzzzzzzzzzzza_, pzzzzzzzzzzzzzb_);

        return pzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Anticoagulant Active at Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Anticoagulant_Active_at_Admission(CqlContext context)
    {
        IEnumerable<Encounter> qzzzzzzzzzzzzzb_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> qzzzzzzzzzzzzzc_(Encounter InpatientEncounter)
        {
            CqlValueSet qzzzzzzzzzzzzze_ = this.Anticoagulants_for_All_Indications(context);
            IEnumerable<MedicationRequest> qzzzzzzzzzzzzzf_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, qzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> qzzzzzzzzzzzzzh_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, qzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> qzzzzzzzzzzzzzi_ = context.Operators.Union<MedicationRequest>(qzzzzzzzzzzzzzf_, qzzzzzzzzzzzzzh_);
            bool? qzzzzzzzzzzzzzj_(MedicationRequest Anticoagulants)
            {
                Code<MedicationRequest.MedicationrequestStatus> qzzzzzzzzzzzzzn_ = Anticoagulants?.StatusElement;
                MedicationRequest.MedicationrequestStatus? qzzzzzzzzzzzzzo_ = qzzzzzzzzzzzzzn_?.Value;
                string qzzzzzzzzzzzzzp_ = context.Operators.Convert<string>(qzzzzzzzzzzzzzo_);
                bool? qzzzzzzzzzzzzzq_ = context.Operators.Equal(qzzzzzzzzzzzzzp_, "active");
                Code<MedicationRequest.MedicationRequestIntent> qzzzzzzzzzzzzzr_ = Anticoagulants?.IntentElement;
                MedicationRequest.MedicationRequestIntent? qzzzzzzzzzzzzzs_ = qzzzzzzzzzzzzzr_?.Value;
                string qzzzzzzzzzzzzzt_ = context.Operators.Convert<string>(qzzzzzzzzzzzzzs_);
                bool? qzzzzzzzzzzzzzu_ = context.Operators.Equal(qzzzzzzzzzzzzzt_, "order");
                MedicationRequest.MedicationRequestIntent? qzzzzzzzzzzzzzw_ = qzzzzzzzzzzzzzr_?.Value;
                string qzzzzzzzzzzzzzx_ = context.Operators.Convert<string>(qzzzzzzzzzzzzzw_);
                bool? qzzzzzzzzzzzzzy_ = context.Operators.Equal(qzzzzzzzzzzzzzx_, "plan");
                DataType qzzzzzzzzzzzzzz_ = Anticoagulants?.Reported;
                object rzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzz_);
                object rzzzzzzzzzzzzzb_ = context.Operators.LateBoundProperty<object>(rzzzzzzzzzzzzza_, "reference");
                string rzzzzzzzzzzzzzc_ = context.Operators.LateBoundProperty<string>(rzzzzzzzzzzzzzb_, "value");
                string rzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.getId(context, rzzzzzzzzzzzzzc_);
                Id rzzzzzzzzzzzzze_()
                {
                    bool szzzzzzzzzzzzzb_()
                    {
                        Patient szzzzzzzzzzzzzc_ = this.Patient(context);
                        bool szzzzzzzzzzzzzd_ = szzzzzzzzzzzzzc_ is Resource;

                        return szzzzzzzzzzzzzd_;
                    };
                    if (szzzzzzzzzzzzzb_())
                    {
                        Patient szzzzzzzzzzzzze_ = this.Patient(context);

                        return (szzzzzzzzzzzzze_ as Resource).IdElement;
                    }
                    else
                    {
                        return default;
                    }
                };
                string rzzzzzzzzzzzzzf_ = (rzzzzzzzzzzzzze_())?.Value;
                bool? rzzzzzzzzzzzzzg_ = context.Operators.Equal(rzzzzzzzzzzzzzd_, rzzzzzzzzzzzzzf_);
                bool? rzzzzzzzzzzzzzh_ = context.Operators.And(qzzzzzzzzzzzzzy_, rzzzzzzzzzzzzzg_);
                bool? rzzzzzzzzzzzzzi_ = context.Operators.Or(qzzzzzzzzzzzzzu_, rzzzzzzzzzzzzzh_);
                bool? rzzzzzzzzzzzzzj_ = context.Operators.And(qzzzzzzzzzzzzzq_, rzzzzzzzzzzzzzi_);
                bool? rzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.isCommunity(context, Anticoagulants);
                bool? rzzzzzzzzzzzzzl_ = context.Operators.And(rzzzzzzzzzzzzzj_, rzzzzzzzzzzzzzk_);
                CqlInterval<CqlDate> rzzzzzzzzzzzzzm_ = CumulativeMedicationDuration_4_1_000.Instance.MedicationRequestPeriod(context, Anticoagulants);
                CqlDate rzzzzzzzzzzzzzn_ = rzzzzzzzzzzzzzm_?.low;
                CqlDateTime rzzzzzzzzzzzzzo_ = context.Operators.ConvertDateToDateTime(rzzzzzzzzzzzzzn_);
                CqlDate rzzzzzzzzzzzzzq_ = rzzzzzzzzzzzzzm_?.high;
                CqlDateTime rzzzzzzzzzzzzzr_ = context.Operators.ConvertDateToDateTime(rzzzzzzzzzzzzzq_);
                bool? rzzzzzzzzzzzzzt_ = rzzzzzzzzzzzzzm_?.lowClosed;
                bool? rzzzzzzzzzzzzzv_ = rzzzzzzzzzzzzzm_?.highClosed;
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzw_ = context.Operators.Interval(rzzzzzzzzzzzzzo_, rzzzzzzzzzzzzzr_, rzzzzzzzzzzzzzt_, rzzzzzzzzzzzzzv_);
                Period rzzzzzzzzzzzzzx_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzzzzzx_);
                bool? rzzzzzzzzzzzzzz_ = context.Operators.OverlapsBefore(rzzzzzzzzzzzzzw_, rzzzzzzzzzzzzzy_, default);
                bool? szzzzzzzzzzzzza_ = context.Operators.And(rzzzzzzzzzzzzzl_, rzzzzzzzzzzzzzz_);

                return szzzzzzzzzzzzza_;
            };
            IEnumerable<MedicationRequest> qzzzzzzzzzzzzzk_ = context.Operators.Where<MedicationRequest>(qzzzzzzzzzzzzzi_, qzzzzzzzzzzzzzj_);
            Encounter qzzzzzzzzzzzzzl_(MedicationRequest Anticoagulants) =>
                InpatientEncounter;
            IEnumerable<Encounter> qzzzzzzzzzzzzzm_ = context.Operators.Select<MedicationRequest, Encounter>(qzzzzzzzzzzzzzk_, qzzzzzzzzzzzzzl_);

            return qzzzzzzzzzzzzzm_;
        };
        IEnumerable<Encounter> qzzzzzzzzzzzzzd_ = context.Operators.SelectMany<Encounter, Encounter>(qzzzzzzzzzzzzzb_, qzzzzzzzzzzzzzc_);

        return qzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Anticoagulant Administration During Encounter")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Anticoagulant_Administration_During_Encounter(CqlContext context)
    {
        IEnumerable<Encounter> szzzzzzzzzzzzzf_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> szzzzzzzzzzzzzg_(Encounter InpatientEncounter)
        {
            CqlValueSet szzzzzzzzzzzzzi_ = this.Anticoagulants_for_All_Indications(context);
            IEnumerable<MedicationAdministration> szzzzzzzzzzzzzj_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, szzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
            IEnumerable<MedicationAdministration> szzzzzzzzzzzzzl_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, szzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
            IEnumerable<MedicationAdministration> szzzzzzzzzzzzzm_ = context.Operators.Union<MedicationAdministration>(szzzzzzzzzzzzzj_, szzzzzzzzzzzzzl_);
            bool? szzzzzzzzzzzzzn_(MedicationAdministration Anticoagulants)
            {
                DataType szzzzzzzzzzzzzr_ = Anticoagulants?.Effective;
                object szzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.ToInterval(context, szzzzzzzzzzzzzs_);
                CqlDateTime szzzzzzzzzzzzzu_ = context.Operators.Start(szzzzzzzzzzzzzt_);
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzv_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, InpatientEncounter);
                bool? szzzzzzzzzzzzzw_ = context.Operators.In<CqlDateTime>(szzzzzzzzzzzzzu_, szzzzzzzzzzzzzv_, default);
                Code<MedicationAdministration.MedicationAdministrationStatusCodes> szzzzzzzzzzzzzx_ = Anticoagulants?.StatusElement;
                MedicationAdministration.MedicationAdministrationStatusCodes? szzzzzzzzzzzzzy_ = szzzzzzzzzzzzzx_?.Value;
                Code<MedicationAdministration.MedicationAdministrationStatusCodes> szzzzzzzzzzzzzz_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(szzzzzzzzzzzzzy_);
                string tzzzzzzzzzzzzza_ = context.Operators.Convert<string>(szzzzzzzzzzzzzz_);
                string[] tzzzzzzzzzzzzzb_ = [
                    "in-progress",
                    "completed",
                ];
                bool? tzzzzzzzzzzzzzc_ = context.Operators.In<string>(tzzzzzzzzzzzzza_, tzzzzzzzzzzzzzb_ as IEnumerable<string>);
                bool? tzzzzzzzzzzzzzd_ = context.Operators.And(szzzzzzzzzzzzzw_, tzzzzzzzzzzzzzc_);

                return tzzzzzzzzzzzzzd_;
            };
            IEnumerable<MedicationAdministration> szzzzzzzzzzzzzo_ = context.Operators.Where<MedicationAdministration>(szzzzzzzzzzzzzm_, szzzzzzzzzzzzzn_);
            Encounter szzzzzzzzzzzzzp_(MedicationAdministration Anticoagulants) =>
                InpatientEncounter;
            IEnumerable<Encounter> szzzzzzzzzzzzzq_ = context.Operators.Select<MedicationAdministration, Encounter>(szzzzzzzzzzzzzo_, szzzzzzzzzzzzzp_);

            return szzzzzzzzzzzzzq_;
        };
        IEnumerable<Encounter> szzzzzzzzzzzzzh_ = context.Operators.SelectMany<Encounter, Encounter>(szzzzzzzzzzzzzf_, szzzzzzzzzzzzzg_);

        return szzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Antidepressant Active at Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Antidepressant_Active_at_Admission(CqlContext context)
    {
        IEnumerable<Encounter> tzzzzzzzzzzzzze_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzf_(Encounter InpatientEncounter)
        {
            CqlValueSet tzzzzzzzzzzzzzh_ = this.Antidepressants(context);
            IEnumerable<MedicationRequest> tzzzzzzzzzzzzzi_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, tzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> tzzzzzzzzzzzzzk_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, tzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> tzzzzzzzzzzzzzl_ = context.Operators.Union<MedicationRequest>(tzzzzzzzzzzzzzi_, tzzzzzzzzzzzzzk_);
            bool? tzzzzzzzzzzzzzm_(MedicationRequest AntidepressantMed)
            {
                Code<MedicationRequest.MedicationrequestStatus> tzzzzzzzzzzzzzq_ = AntidepressantMed?.StatusElement;
                MedicationRequest.MedicationrequestStatus? tzzzzzzzzzzzzzr_ = tzzzzzzzzzzzzzq_?.Value;
                string tzzzzzzzzzzzzzs_ = context.Operators.Convert<string>(tzzzzzzzzzzzzzr_);
                bool? tzzzzzzzzzzzzzt_ = context.Operators.Equal(tzzzzzzzzzzzzzs_, "active");
                Code<MedicationRequest.MedicationRequestIntent> tzzzzzzzzzzzzzu_ = AntidepressantMed?.IntentElement;
                MedicationRequest.MedicationRequestIntent? tzzzzzzzzzzzzzv_ = tzzzzzzzzzzzzzu_?.Value;
                string tzzzzzzzzzzzzzw_ = context.Operators.Convert<string>(tzzzzzzzzzzzzzv_);
                bool? tzzzzzzzzzzzzzx_ = context.Operators.Equal(tzzzzzzzzzzzzzw_, "order");
                MedicationRequest.MedicationRequestIntent? tzzzzzzzzzzzzzz_ = tzzzzzzzzzzzzzu_?.Value;
                string uzzzzzzzzzzzzza_ = context.Operators.Convert<string>(tzzzzzzzzzzzzzz_);
                bool? uzzzzzzzzzzzzzb_ = context.Operators.Equal(uzzzzzzzzzzzzza_, "plan");
                DataType uzzzzzzzzzzzzzc_ = AntidepressantMed?.Reported;
                object uzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzc_);
                object uzzzzzzzzzzzzze_ = context.Operators.LateBoundProperty<object>(uzzzzzzzzzzzzzd_, "reference");
                string uzzzzzzzzzzzzzf_ = context.Operators.LateBoundProperty<string>(uzzzzzzzzzzzzze_, "value");
                string uzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.getId(context, uzzzzzzzzzzzzzf_);
                Id uzzzzzzzzzzzzzh_()
                {
                    bool vzzzzzzzzzzzzze_()
                    {
                        Patient vzzzzzzzzzzzzzf_ = this.Patient(context);
                        bool vzzzzzzzzzzzzzg_ = vzzzzzzzzzzzzzf_ is Resource;

                        return vzzzzzzzzzzzzzg_;
                    };
                    if (vzzzzzzzzzzzzze_())
                    {
                        Patient vzzzzzzzzzzzzzh_ = this.Patient(context);

                        return (vzzzzzzzzzzzzzh_ as Resource).IdElement;
                    }
                    else
                    {
                        return default;
                    }
                };
                string uzzzzzzzzzzzzzi_ = (uzzzzzzzzzzzzzh_())?.Value;
                bool? uzzzzzzzzzzzzzj_ = context.Operators.Equal(uzzzzzzzzzzzzzg_, uzzzzzzzzzzzzzi_);
                bool? uzzzzzzzzzzzzzk_ = context.Operators.And(uzzzzzzzzzzzzzb_, uzzzzzzzzzzzzzj_);
                bool? uzzzzzzzzzzzzzl_ = context.Operators.Or(tzzzzzzzzzzzzzx_, uzzzzzzzzzzzzzk_);
                bool? uzzzzzzzzzzzzzm_ = context.Operators.And(tzzzzzzzzzzzzzt_, uzzzzzzzzzzzzzl_);
                bool? uzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.isCommunity(context, AntidepressantMed);
                bool? uzzzzzzzzzzzzzo_ = context.Operators.And(uzzzzzzzzzzzzzm_, uzzzzzzzzzzzzzn_);
                CqlInterval<CqlDate> uzzzzzzzzzzzzzp_ = CumulativeMedicationDuration_4_1_000.Instance.MedicationRequestPeriod(context, AntidepressantMed);
                CqlDate uzzzzzzzzzzzzzq_ = uzzzzzzzzzzzzzp_?.low;
                CqlDateTime uzzzzzzzzzzzzzr_ = context.Operators.ConvertDateToDateTime(uzzzzzzzzzzzzzq_);
                CqlDate uzzzzzzzzzzzzzt_ = uzzzzzzzzzzzzzp_?.high;
                CqlDateTime uzzzzzzzzzzzzzu_ = context.Operators.ConvertDateToDateTime(uzzzzzzzzzzzzzt_);
                bool? uzzzzzzzzzzzzzw_ = uzzzzzzzzzzzzzp_?.lowClosed;
                bool? uzzzzzzzzzzzzzy_ = uzzzzzzzzzzzzzp_?.highClosed;
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzz_ = context.Operators.Interval(uzzzzzzzzzzzzzr_, uzzzzzzzzzzzzzu_, uzzzzzzzzzzzzzw_, uzzzzzzzzzzzzzy_);
                Period vzzzzzzzzzzzzza_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzzzzzza_);
                bool? vzzzzzzzzzzzzzc_ = context.Operators.OverlapsBefore(uzzzzzzzzzzzzzz_, vzzzzzzzzzzzzzb_, default);
                bool? vzzzzzzzzzzzzzd_ = context.Operators.And(uzzzzzzzzzzzzzo_, vzzzzzzzzzzzzzc_);

                return vzzzzzzzzzzzzzd_;
            };
            IEnumerable<MedicationRequest> tzzzzzzzzzzzzzn_ = context.Operators.Where<MedicationRequest>(tzzzzzzzzzzzzzl_, tzzzzzzzzzzzzzm_);
            Encounter tzzzzzzzzzzzzzo_(MedicationRequest AntidepressantMed) =>
                InpatientEncounter;
            IEnumerable<Encounter> tzzzzzzzzzzzzzp_ = context.Operators.Select<MedicationRequest, Encounter>(tzzzzzzzzzzzzzn_, tzzzzzzzzzzzzzo_);

            return tzzzzzzzzzzzzzp_;
        };
        IEnumerable<Encounter> tzzzzzzzzzzzzzg_ = context.Operators.SelectMany<Encounter, Encounter>(tzzzzzzzzzzzzze_, tzzzzzzzzzzzzzf_);

        return tzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Antihypertensive Active at Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Antihypertensive_Active_at_Admission(CqlContext context)
    {
        IEnumerable<Encounter> vzzzzzzzzzzzzzi_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> vzzzzzzzzzzzzzj_(Encounter InpatientEncounter)
        {
            CqlValueSet vzzzzzzzzzzzzzl_ = this.Antihypertensives(context);
            IEnumerable<MedicationRequest> vzzzzzzzzzzzzzm_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, vzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> vzzzzzzzzzzzzzo_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, vzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> vzzzzzzzzzzzzzp_ = context.Operators.Union<MedicationRequest>(vzzzzzzzzzzzzzm_, vzzzzzzzzzzzzzo_);
            bool? vzzzzzzzzzzzzzq_(MedicationRequest BPMed)
            {
                Code<MedicationRequest.MedicationrequestStatus> vzzzzzzzzzzzzzu_ = BPMed?.StatusElement;
                MedicationRequest.MedicationrequestStatus? vzzzzzzzzzzzzzv_ = vzzzzzzzzzzzzzu_?.Value;
                string vzzzzzzzzzzzzzw_ = context.Operators.Convert<string>(vzzzzzzzzzzzzzv_);
                bool? vzzzzzzzzzzzzzx_ = context.Operators.Equal(vzzzzzzzzzzzzzw_, "active");
                Code<MedicationRequest.MedicationRequestIntent> vzzzzzzzzzzzzzy_ = BPMed?.IntentElement;
                MedicationRequest.MedicationRequestIntent? vzzzzzzzzzzzzzz_ = vzzzzzzzzzzzzzy_?.Value;
                string wzzzzzzzzzzzzza_ = context.Operators.Convert<string>(vzzzzzzzzzzzzzz_);
                bool? wzzzzzzzzzzzzzb_ = context.Operators.Equal(wzzzzzzzzzzzzza_, "order");
                MedicationRequest.MedicationRequestIntent? wzzzzzzzzzzzzzd_ = vzzzzzzzzzzzzzy_?.Value;
                string wzzzzzzzzzzzzze_ = context.Operators.Convert<string>(wzzzzzzzzzzzzzd_);
                bool? wzzzzzzzzzzzzzf_ = context.Operators.Equal(wzzzzzzzzzzzzze_, "plan");
                DataType wzzzzzzzzzzzzzg_ = BPMed?.Reported;
                object wzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzg_);
                object wzzzzzzzzzzzzzi_ = context.Operators.LateBoundProperty<object>(wzzzzzzzzzzzzzh_, "reference");
                string wzzzzzzzzzzzzzj_ = context.Operators.LateBoundProperty<string>(wzzzzzzzzzzzzzi_, "value");
                string wzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.getId(context, wzzzzzzzzzzzzzj_);
                Id wzzzzzzzzzzzzzl_()
                {
                    bool xzzzzzzzzzzzzzi_()
                    {
                        Patient xzzzzzzzzzzzzzj_ = this.Patient(context);
                        bool xzzzzzzzzzzzzzk_ = xzzzzzzzzzzzzzj_ is Resource;

                        return xzzzzzzzzzzzzzk_;
                    };
                    if (xzzzzzzzzzzzzzi_())
                    {
                        Patient xzzzzzzzzzzzzzl_ = this.Patient(context);

                        return (xzzzzzzzzzzzzzl_ as Resource).IdElement;
                    }
                    else
                    {
                        return default;
                    }
                };
                string wzzzzzzzzzzzzzm_ = (wzzzzzzzzzzzzzl_())?.Value;
                bool? wzzzzzzzzzzzzzn_ = context.Operators.Equal(wzzzzzzzzzzzzzk_, wzzzzzzzzzzzzzm_);
                bool? wzzzzzzzzzzzzzo_ = context.Operators.And(wzzzzzzzzzzzzzf_, wzzzzzzzzzzzzzn_);
                bool? wzzzzzzzzzzzzzp_ = context.Operators.Or(wzzzzzzzzzzzzzb_, wzzzzzzzzzzzzzo_);
                bool? wzzzzzzzzzzzzzq_ = context.Operators.And(vzzzzzzzzzzzzzx_, wzzzzzzzzzzzzzp_);
                bool? wzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.isCommunity(context, BPMed);
                bool? wzzzzzzzzzzzzzs_ = context.Operators.And(wzzzzzzzzzzzzzq_, wzzzzzzzzzzzzzr_);
                CqlInterval<CqlDate> wzzzzzzzzzzzzzt_ = CumulativeMedicationDuration_4_1_000.Instance.MedicationRequestPeriod(context, BPMed);
                CqlDate wzzzzzzzzzzzzzu_ = wzzzzzzzzzzzzzt_?.low;
                CqlDateTime wzzzzzzzzzzzzzv_ = context.Operators.ConvertDateToDateTime(wzzzzzzzzzzzzzu_);
                CqlDate wzzzzzzzzzzzzzx_ = wzzzzzzzzzzzzzt_?.high;
                CqlDateTime wzzzzzzzzzzzzzy_ = context.Operators.ConvertDateToDateTime(wzzzzzzzzzzzzzx_);
                bool? xzzzzzzzzzzzzza_ = wzzzzzzzzzzzzzt_?.lowClosed;
                bool? xzzzzzzzzzzzzzc_ = wzzzzzzzzzzzzzt_?.highClosed;
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzd_ = context.Operators.Interval(wzzzzzzzzzzzzzv_, wzzzzzzzzzzzzzy_, xzzzzzzzzzzzzza_, xzzzzzzzzzzzzzc_);
                Period xzzzzzzzzzzzzze_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzze_);
                bool? xzzzzzzzzzzzzzg_ = context.Operators.OverlapsBefore(xzzzzzzzzzzzzzd_, xzzzzzzzzzzzzzf_, default);
                bool? xzzzzzzzzzzzzzh_ = context.Operators.And(wzzzzzzzzzzzzzs_, xzzzzzzzzzzzzzg_);

                return xzzzzzzzzzzzzzh_;
            };
            IEnumerable<MedicationRequest> vzzzzzzzzzzzzzr_ = context.Operators.Where<MedicationRequest>(vzzzzzzzzzzzzzp_, vzzzzzzzzzzzzzq_);
            Encounter vzzzzzzzzzzzzzs_(MedicationRequest BPMed) =>
                InpatientEncounter;
            IEnumerable<Encounter> vzzzzzzzzzzzzzt_ = context.Operators.Select<MedicationRequest, Encounter>(vzzzzzzzzzzzzzr_, vzzzzzzzzzzzzzs_);

            return vzzzzzzzzzzzzzt_;
        };
        IEnumerable<Encounter> vzzzzzzzzzzzzzk_ = context.Operators.SelectMany<Encounter, Encounter>(vzzzzzzzzzzzzzi_, vzzzzzzzzzzzzzj_);

        return vzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with CNS Depressant Active at Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_CNS_Depressant_Active_at_Admission(CqlContext context)
    {
        IEnumerable<Encounter> xzzzzzzzzzzzzzm_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> xzzzzzzzzzzzzzn_(Encounter InpatientEncounter)
        {
            CqlValueSet xzzzzzzzzzzzzzp_ = this.Central_Nervous_System_Depressants(context);
            IEnumerable<MedicationRequest> xzzzzzzzzzzzzzq_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, xzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> xzzzzzzzzzzzzzs_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, xzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> xzzzzzzzzzzzzzt_ = context.Operators.Union<MedicationRequest>(xzzzzzzzzzzzzzq_, xzzzzzzzzzzzzzs_);
            bool? xzzzzzzzzzzzzzu_(MedicationRequest CNSMed)
            {
                Code<MedicationRequest.MedicationrequestStatus> xzzzzzzzzzzzzzy_ = CNSMed?.StatusElement;
                MedicationRequest.MedicationrequestStatus? xzzzzzzzzzzzzzz_ = xzzzzzzzzzzzzzy_?.Value;
                string yzzzzzzzzzzzzza_ = context.Operators.Convert<string>(xzzzzzzzzzzzzzz_);
                bool? yzzzzzzzzzzzzzb_ = context.Operators.Equal(yzzzzzzzzzzzzza_, "active");
                Code<MedicationRequest.MedicationRequestIntent> yzzzzzzzzzzzzzc_ = CNSMed?.IntentElement;
                MedicationRequest.MedicationRequestIntent? yzzzzzzzzzzzzzd_ = yzzzzzzzzzzzzzc_?.Value;
                string yzzzzzzzzzzzzze_ = context.Operators.Convert<string>(yzzzzzzzzzzzzzd_);
                bool? yzzzzzzzzzzzzzf_ = context.Operators.Equal(yzzzzzzzzzzzzze_, "order");
                MedicationRequest.MedicationRequestIntent? yzzzzzzzzzzzzzh_ = yzzzzzzzzzzzzzc_?.Value;
                string yzzzzzzzzzzzzzi_ = context.Operators.Convert<string>(yzzzzzzzzzzzzzh_);
                bool? yzzzzzzzzzzzzzj_ = context.Operators.Equal(yzzzzzzzzzzzzzi_, "plan");
                DataType yzzzzzzzzzzzzzk_ = CNSMed?.Reported;
                object yzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzk_);
                object yzzzzzzzzzzzzzm_ = context.Operators.LateBoundProperty<object>(yzzzzzzzzzzzzzl_, "reference");
                string yzzzzzzzzzzzzzn_ = context.Operators.LateBoundProperty<string>(yzzzzzzzzzzzzzm_, "value");
                string yzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.getId(context, yzzzzzzzzzzzzzn_);
                Id yzzzzzzzzzzzzzp_()
                {
                    bool zzzzzzzzzzzzzzm_()
                    {
                        Patient zzzzzzzzzzzzzzn_ = this.Patient(context);
                        bool zzzzzzzzzzzzzzo_ = zzzzzzzzzzzzzzn_ is Resource;

                        return zzzzzzzzzzzzzzo_;
                    };
                    if (zzzzzzzzzzzzzzm_())
                    {
                        Patient zzzzzzzzzzzzzzp_ = this.Patient(context);

                        return (zzzzzzzzzzzzzzp_ as Resource).IdElement;
                    }
                    else
                    {
                        return default;
                    }
                };
                string yzzzzzzzzzzzzzq_ = (yzzzzzzzzzzzzzp_())?.Value;
                bool? yzzzzzzzzzzzzzr_ = context.Operators.Equal(yzzzzzzzzzzzzzo_, yzzzzzzzzzzzzzq_);
                bool? yzzzzzzzzzzzzzs_ = context.Operators.And(yzzzzzzzzzzzzzj_, yzzzzzzzzzzzzzr_);
                bool? yzzzzzzzzzzzzzt_ = context.Operators.Or(yzzzzzzzzzzzzzf_, yzzzzzzzzzzzzzs_);
                bool? yzzzzzzzzzzzzzu_ = context.Operators.And(yzzzzzzzzzzzzzb_, yzzzzzzzzzzzzzt_);
                bool? yzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.isCommunity(context, CNSMed);
                bool? yzzzzzzzzzzzzzw_ = context.Operators.And(yzzzzzzzzzzzzzu_, yzzzzzzzzzzzzzv_);
                CqlInterval<CqlDate> yzzzzzzzzzzzzzx_ = CumulativeMedicationDuration_4_1_000.Instance.MedicationRequestPeriod(context, CNSMed);
                CqlDate yzzzzzzzzzzzzzy_ = yzzzzzzzzzzzzzx_?.low;
                CqlDateTime yzzzzzzzzzzzzzz_ = context.Operators.ConvertDateToDateTime(yzzzzzzzzzzzzzy_);
                CqlDate zzzzzzzzzzzzzzb_ = yzzzzzzzzzzzzzx_?.high;
                CqlDateTime zzzzzzzzzzzzzzc_ = context.Operators.ConvertDateToDateTime(zzzzzzzzzzzzzzb_);
                bool? zzzzzzzzzzzzzze_ = yzzzzzzzzzzzzzx_?.lowClosed;
                bool? zzzzzzzzzzzzzzg_ = yzzzzzzzzzzzzzx_?.highClosed;
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzh_ = context.Operators.Interval(yzzzzzzzzzzzzzz_, zzzzzzzzzzzzzzc_, zzzzzzzzzzzzzze_, zzzzzzzzzzzzzzg_);
                Period zzzzzzzzzzzzzzi_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzzi_);
                bool? zzzzzzzzzzzzzzk_ = context.Operators.OverlapsBefore(zzzzzzzzzzzzzzh_, zzzzzzzzzzzzzzj_, default);
                bool? zzzzzzzzzzzzzzl_ = context.Operators.And(yzzzzzzzzzzzzzw_, zzzzzzzzzzzzzzk_);

                return zzzzzzzzzzzzzzl_;
            };
            IEnumerable<MedicationRequest> xzzzzzzzzzzzzzv_ = context.Operators.Where<MedicationRequest>(xzzzzzzzzzzzzzt_, xzzzzzzzzzzzzzu_);
            Encounter xzzzzzzzzzzzzzw_(MedicationRequest CNSMed) =>
                InpatientEncounter;
            IEnumerable<Encounter> xzzzzzzzzzzzzzx_ = context.Operators.Select<MedicationRequest, Encounter>(xzzzzzzzzzzzzzv_, xzzzzzzzzzzzzzw_);

            return xzzzzzzzzzzzzzx_;
        };
        IEnumerable<Encounter> xzzzzzzzzzzzzzo_ = context.Operators.SelectMany<Encounter, Encounter>(xzzzzzzzzzzzzzm_, xzzzzzzzzzzzzzn_);

        return xzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Coagulation Disorder Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Coagulation_Disorder_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> zzzzzzzzzzzzzzq_ = this.Qualifying_Encounter(context);
        bool? zzzzzzzzzzzzzzr_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> zzzzzzzzzzzzzzt_ = InpatientEncounter?.Diagnosis;
            bool? zzzzzzzzzzzzzzu_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference zzzzzzzzzzzzzzx_ = Dx?.Condition;
                Condition zzzzzzzzzzzzzzy_ = CQMCommon_2_2_000.Instance.GetCondition(context, zzzzzzzzzzzzzzx_);
                CodeableConcept zzzzzzzzzzzzzzz_ = zzzzzzzzzzzzzzy_?.Code;
                CqlConcept azzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, zzzzzzzzzzzzzzz_);
                CqlValueSet azzzzzzzzzzzzzzb_ = this.Coagulation_Disorders(context);
                bool? azzzzzzzzzzzzzzc_ = context.Operators.ConceptInValueSet(azzzzzzzzzzzzzza_, azzzzzzzzzzzzzzb_);
                bool? azzzzzzzzzzzzzzd_(Extension @this)
                {
                    string azzzzzzzzzzzzzzm_ = @this?.Url;
                    FhirString azzzzzzzzzzzzzzn_ = context.Operators.Convert<FhirString>(azzzzzzzzzzzzzzm_);
                    string azzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToString(context, azzzzzzzzzzzzzzn_);
                    bool? azzzzzzzzzzzzzzp_ = context.Operators.Equal(azzzzzzzzzzzzzzo_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return azzzzzzzzzzzzzzp_;
                };
                IEnumerable<Extension> azzzzzzzzzzzzzze_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), azzzzzzzzzzzzzzd_);
                object azzzzzzzzzzzzzzf_(Extension @this)
                {
                    DataType azzzzzzzzzzzzzzq_ = @this?.Value;

                    return azzzzzzzzzzzzzzq_;
                };
                IEnumerable<object> azzzzzzzzzzzzzzg_ = context.Operators.Select<Extension, object>(azzzzzzzzzzzzzze_, azzzzzzzzzzzzzzf_);
                object azzzzzzzzzzzzzzh_ = context.Operators.SingletonFrom<object>(azzzzzzzzzzzzzzg_);
                CqlConcept azzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, azzzzzzzzzzzzzzh_ as CodeableConcept);
                CqlValueSet azzzzzzzzzzzzzzj_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? azzzzzzzzzzzzzzk_ = context.Operators.ConceptInValueSet(azzzzzzzzzzzzzzi_, azzzzzzzzzzzzzzj_);
                bool? azzzzzzzzzzzzzzl_ = context.Operators.And(azzzzzzzzzzzzzzc_, azzzzzzzzzzzzzzk_);

                return azzzzzzzzzzzzzzl_;
            };
            IEnumerable<Encounter.DiagnosisComponent> zzzzzzzzzzzzzzv_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)zzzzzzzzzzzzzzt_, zzzzzzzzzzzzzzu_);
            bool? zzzzzzzzzzzzzzw_ = context.Operators.Exists<Encounter.DiagnosisComponent>(zzzzzzzzzzzzzzv_);

            return zzzzzzzzzzzzzzw_;
        };
        IEnumerable<Encounter> zzzzzzzzzzzzzzs_ = context.Operators.Where<Encounter>(zzzzzzzzzzzzzzq_, zzzzzzzzzzzzzzr_);

        return zzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Delirium, Dementia or Other Psychosis Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Delirium__Dementia_or_Other_Psychosis_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> azzzzzzzzzzzzzzr_ = this.Qualifying_Encounter(context);
        bool? azzzzzzzzzzzzzzs_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> azzzzzzzzzzzzzzu_ = InpatientEncounter?.Diagnosis;
            bool? azzzzzzzzzzzzzzv_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference azzzzzzzzzzzzzzy_ = Dx?.Condition;
                Condition azzzzzzzzzzzzzzz_ = CQMCommon_2_2_000.Instance.GetCondition(context, azzzzzzzzzzzzzzy_);
                CodeableConcept bzzzzzzzzzzzzzza_ = azzzzzzzzzzzzzzz_?.Code;
                CqlConcept bzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bzzzzzzzzzzzzzza_);
                CqlValueSet bzzzzzzzzzzzzzzc_ = this.Delirium__Dementia__and_Other_Psychoses(context);
                bool? bzzzzzzzzzzzzzzd_ = context.Operators.ConceptInValueSet(bzzzzzzzzzzzzzzb_, bzzzzzzzzzzzzzzc_);
                bool? bzzzzzzzzzzzzzze_(Extension @this)
                {
                    string bzzzzzzzzzzzzzzn_ = @this?.Url;
                    FhirString bzzzzzzzzzzzzzzo_ = context.Operators.Convert<FhirString>(bzzzzzzzzzzzzzzn_);
                    string bzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToString(context, bzzzzzzzzzzzzzzo_);
                    bool? bzzzzzzzzzzzzzzq_ = context.Operators.Equal(bzzzzzzzzzzzzzzp_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return bzzzzzzzzzzzzzzq_;
                };
                IEnumerable<Extension> bzzzzzzzzzzzzzzf_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), bzzzzzzzzzzzzzze_);
                object bzzzzzzzzzzzzzzg_(Extension @this)
                {
                    DataType bzzzzzzzzzzzzzzr_ = @this?.Value;

                    return bzzzzzzzzzzzzzzr_;
                };
                IEnumerable<object> bzzzzzzzzzzzzzzh_ = context.Operators.Select<Extension, object>(bzzzzzzzzzzzzzzf_, bzzzzzzzzzzzzzzg_);
                object bzzzzzzzzzzzzzzi_ = context.Operators.SingletonFrom<object>(bzzzzzzzzzzzzzzh_);
                CqlConcept bzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bzzzzzzzzzzzzzzi_ as CodeableConcept);
                CqlValueSet bzzzzzzzzzzzzzzk_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? bzzzzzzzzzzzzzzl_ = context.Operators.ConceptInValueSet(bzzzzzzzzzzzzzzj_, bzzzzzzzzzzzzzzk_);
                bool? bzzzzzzzzzzzzzzm_ = context.Operators.And(bzzzzzzzzzzzzzzd_, bzzzzzzzzzzzzzzl_);

                return bzzzzzzzzzzzzzzm_;
            };
            IEnumerable<Encounter.DiagnosisComponent> azzzzzzzzzzzzzzw_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)azzzzzzzzzzzzzzu_, azzzzzzzzzzzzzzv_);
            bool? azzzzzzzzzzzzzzx_ = context.Operators.Exists<Encounter.DiagnosisComponent>(azzzzzzzzzzzzzzw_);

            return azzzzzzzzzzzzzzx_;
        };
        IEnumerable<Encounter> azzzzzzzzzzzzzzt_ = context.Operators.Where<Encounter>(azzzzzzzzzzzzzzr_, azzzzzzzzzzzzzzs_);

        return azzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Depression Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Depression_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> bzzzzzzzzzzzzzzs_ = this.Qualifying_Encounter(context);
        bool? bzzzzzzzzzzzzzzt_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> bzzzzzzzzzzzzzzv_ = InpatientEncounter?.Diagnosis;
            bool? bzzzzzzzzzzzzzzw_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference bzzzzzzzzzzzzzzz_ = Dx?.Condition;
                Condition czzzzzzzzzzzzzza_ = CQMCommon_2_2_000.Instance.GetCondition(context, bzzzzzzzzzzzzzzz_);
                CodeableConcept czzzzzzzzzzzzzzb_ = czzzzzzzzzzzzzza_?.Code;
                CqlConcept czzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, czzzzzzzzzzzzzzb_);
                CqlValueSet czzzzzzzzzzzzzzd_ = this.Depression(context);
                bool? czzzzzzzzzzzzzze_ = context.Operators.ConceptInValueSet(czzzzzzzzzzzzzzc_, czzzzzzzzzzzzzzd_);
                bool? czzzzzzzzzzzzzzf_(Extension @this)
                {
                    string czzzzzzzzzzzzzzo_ = @this?.Url;
                    FhirString czzzzzzzzzzzzzzp_ = context.Operators.Convert<FhirString>(czzzzzzzzzzzzzzo_);
                    string czzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToString(context, czzzzzzzzzzzzzzp_);
                    bool? czzzzzzzzzzzzzzr_ = context.Operators.Equal(czzzzzzzzzzzzzzq_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return czzzzzzzzzzzzzzr_;
                };
                IEnumerable<Extension> czzzzzzzzzzzzzzg_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), czzzzzzzzzzzzzzf_);
                object czzzzzzzzzzzzzzh_(Extension @this)
                {
                    DataType czzzzzzzzzzzzzzs_ = @this?.Value;

                    return czzzzzzzzzzzzzzs_;
                };
                IEnumerable<object> czzzzzzzzzzzzzzi_ = context.Operators.Select<Extension, object>(czzzzzzzzzzzzzzg_, czzzzzzzzzzzzzzh_);
                object czzzzzzzzzzzzzzj_ = context.Operators.SingletonFrom<object>(czzzzzzzzzzzzzzi_);
                CqlConcept czzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, czzzzzzzzzzzzzzj_ as CodeableConcept);
                CqlValueSet czzzzzzzzzzzzzzl_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? czzzzzzzzzzzzzzm_ = context.Operators.ConceptInValueSet(czzzzzzzzzzzzzzk_, czzzzzzzzzzzzzzl_);
                bool? czzzzzzzzzzzzzzn_ = context.Operators.And(czzzzzzzzzzzzzze_, czzzzzzzzzzzzzzm_);

                return czzzzzzzzzzzzzzn_;
            };
            IEnumerable<Encounter.DiagnosisComponent> bzzzzzzzzzzzzzzx_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)bzzzzzzzzzzzzzzv_, bzzzzzzzzzzzzzzw_);
            bool? bzzzzzzzzzzzzzzy_ = context.Operators.Exists<Encounter.DiagnosisComponent>(bzzzzzzzzzzzzzzx_);

            return bzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Encounter> bzzzzzzzzzzzzzzu_ = context.Operators.Where<Encounter>(bzzzzzzzzzzzzzzs_, bzzzzzzzzzzzzzzt_);

        return bzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Diuretic Active at Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Diuretic_Active_at_Admission(CqlContext context)
    {
        IEnumerable<Encounter> czzzzzzzzzzzzzzt_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzzu_(Encounter InpatientEncounter)
        {
            CqlValueSet czzzzzzzzzzzzzzw_ = this.Diuretics(context);
            IEnumerable<MedicationRequest> czzzzzzzzzzzzzzx_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, czzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> czzzzzzzzzzzzzzz_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, czzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> dzzzzzzzzzzzzzza_ = context.Operators.Union<MedicationRequest>(czzzzzzzzzzzzzzx_, czzzzzzzzzzzzzzz_);
            bool? dzzzzzzzzzzzzzzb_(MedicationRequest DiureticMed)
            {
                Code<MedicationRequest.MedicationrequestStatus> dzzzzzzzzzzzzzzf_ = DiureticMed?.StatusElement;
                MedicationRequest.MedicationrequestStatus? dzzzzzzzzzzzzzzg_ = dzzzzzzzzzzzzzzf_?.Value;
                string dzzzzzzzzzzzzzzh_ = context.Operators.Convert<string>(dzzzzzzzzzzzzzzg_);
                bool? dzzzzzzzzzzzzzzi_ = context.Operators.Equal(dzzzzzzzzzzzzzzh_, "active");
                Code<MedicationRequest.MedicationRequestIntent> dzzzzzzzzzzzzzzj_ = DiureticMed?.IntentElement;
                MedicationRequest.MedicationRequestIntent? dzzzzzzzzzzzzzzk_ = dzzzzzzzzzzzzzzj_?.Value;
                string dzzzzzzzzzzzzzzl_ = context.Operators.Convert<string>(dzzzzzzzzzzzzzzk_);
                bool? dzzzzzzzzzzzzzzm_ = context.Operators.Equal(dzzzzzzzzzzzzzzl_, "order");
                MedicationRequest.MedicationRequestIntent? dzzzzzzzzzzzzzzo_ = dzzzzzzzzzzzzzzj_?.Value;
                string dzzzzzzzzzzzzzzp_ = context.Operators.Convert<string>(dzzzzzzzzzzzzzzo_);
                bool? dzzzzzzzzzzzzzzq_ = context.Operators.Equal(dzzzzzzzzzzzzzzp_, "plan");
                DataType dzzzzzzzzzzzzzzr_ = DiureticMed?.Reported;
                object dzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzr_);
                object dzzzzzzzzzzzzzzt_ = context.Operators.LateBoundProperty<object>(dzzzzzzzzzzzzzzs_, "reference");
                string dzzzzzzzzzzzzzzu_ = context.Operators.LateBoundProperty<string>(dzzzzzzzzzzzzzzt_, "value");
                string dzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.getId(context, dzzzzzzzzzzzzzzu_);
                Id dzzzzzzzzzzzzzzw_()
                {
                    bool ezzzzzzzzzzzzzzt_()
                    {
                        Patient ezzzzzzzzzzzzzzu_ = this.Patient(context);
                        bool ezzzzzzzzzzzzzzv_ = ezzzzzzzzzzzzzzu_ is Resource;

                        return ezzzzzzzzzzzzzzv_;
                    };
                    if (ezzzzzzzzzzzzzzt_())
                    {
                        Patient ezzzzzzzzzzzzzzw_ = this.Patient(context);

                        return (ezzzzzzzzzzzzzzw_ as Resource).IdElement;
                    }
                    else
                    {
                        return default;
                    }
                };
                string dzzzzzzzzzzzzzzx_ = (dzzzzzzzzzzzzzzw_())?.Value;
                bool? dzzzzzzzzzzzzzzy_ = context.Operators.Equal(dzzzzzzzzzzzzzzv_, dzzzzzzzzzzzzzzx_);
                bool? dzzzzzzzzzzzzzzz_ = context.Operators.And(dzzzzzzzzzzzzzzq_, dzzzzzzzzzzzzzzy_);
                bool? ezzzzzzzzzzzzzza_ = context.Operators.Or(dzzzzzzzzzzzzzzm_, dzzzzzzzzzzzzzzz_);
                bool? ezzzzzzzzzzzzzzb_ = context.Operators.And(dzzzzzzzzzzzzzzi_, ezzzzzzzzzzzzzza_);
                bool? ezzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.isCommunity(context, DiureticMed);
                bool? ezzzzzzzzzzzzzzd_ = context.Operators.And(ezzzzzzzzzzzzzzb_, ezzzzzzzzzzzzzzc_);
                CqlInterval<CqlDate> ezzzzzzzzzzzzzze_ = CumulativeMedicationDuration_4_1_000.Instance.MedicationRequestPeriod(context, DiureticMed);
                CqlDate ezzzzzzzzzzzzzzf_ = ezzzzzzzzzzzzzze_?.low;
                CqlDateTime ezzzzzzzzzzzzzzg_ = context.Operators.ConvertDateToDateTime(ezzzzzzzzzzzzzzf_);
                CqlDate ezzzzzzzzzzzzzzi_ = ezzzzzzzzzzzzzze_?.high;
                CqlDateTime ezzzzzzzzzzzzzzj_ = context.Operators.ConvertDateToDateTime(ezzzzzzzzzzzzzzi_);
                bool? ezzzzzzzzzzzzzzl_ = ezzzzzzzzzzzzzze_?.lowClosed;
                bool? ezzzzzzzzzzzzzzn_ = ezzzzzzzzzzzzzze_?.highClosed;
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzo_ = context.Operators.Interval(ezzzzzzzzzzzzzzg_, ezzzzzzzzzzzzzzj_, ezzzzzzzzzzzzzzl_, ezzzzzzzzzzzzzzn_);
                Period ezzzzzzzzzzzzzzp_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzzzzzzzp_);
                bool? ezzzzzzzzzzzzzzr_ = context.Operators.OverlapsBefore(ezzzzzzzzzzzzzzo_, ezzzzzzzzzzzzzzq_, default);
                bool? ezzzzzzzzzzzzzzs_ = context.Operators.And(ezzzzzzzzzzzzzzd_, ezzzzzzzzzzzzzzr_);

                return ezzzzzzzzzzzzzzs_;
            };
            IEnumerable<MedicationRequest> dzzzzzzzzzzzzzzc_ = context.Operators.Where<MedicationRequest>(dzzzzzzzzzzzzzza_, dzzzzzzzzzzzzzzb_);
            Encounter dzzzzzzzzzzzzzzd_(MedicationRequest DiureticMed) =>
                InpatientEncounter;
            IEnumerable<Encounter> dzzzzzzzzzzzzzze_ = context.Operators.Select<MedicationRequest, Encounter>(dzzzzzzzzzzzzzzc_, dzzzzzzzzzzzzzzd_);

            return dzzzzzzzzzzzzzze_;
        };
        IEnumerable<Encounter> czzzzzzzzzzzzzzv_ = context.Operators.SelectMany<Encounter, Encounter>(czzzzzzzzzzzzzzt_, czzzzzzzzzzzzzzu_);

        return czzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Epilepsy Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Epilepsy_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> ezzzzzzzzzzzzzzx_ = this.Qualifying_Encounter(context);
        bool? ezzzzzzzzzzzzzzy_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> fzzzzzzzzzzzzzza_ = InpatientEncounter?.Diagnosis;
            bool? fzzzzzzzzzzzzzzb_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference fzzzzzzzzzzzzzze_ = Dx?.Condition;
                Condition fzzzzzzzzzzzzzzf_ = CQMCommon_2_2_000.Instance.GetCondition(context, fzzzzzzzzzzzzzze_);
                CodeableConcept fzzzzzzzzzzzzzzg_ = fzzzzzzzzzzzzzzf_?.Code;
                CqlConcept fzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fzzzzzzzzzzzzzzg_);
                CqlValueSet fzzzzzzzzzzzzzzi_ = this.Epilepsy(context);
                bool? fzzzzzzzzzzzzzzj_ = context.Operators.ConceptInValueSet(fzzzzzzzzzzzzzzh_, fzzzzzzzzzzzzzzi_);
                bool? fzzzzzzzzzzzzzzk_(Extension @this)
                {
                    string fzzzzzzzzzzzzzzt_ = @this?.Url;
                    FhirString fzzzzzzzzzzzzzzu_ = context.Operators.Convert<FhirString>(fzzzzzzzzzzzzzzt_);
                    string fzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToString(context, fzzzzzzzzzzzzzzu_);
                    bool? fzzzzzzzzzzzzzzw_ = context.Operators.Equal(fzzzzzzzzzzzzzzv_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return fzzzzzzzzzzzzzzw_;
                };
                IEnumerable<Extension> fzzzzzzzzzzzzzzl_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), fzzzzzzzzzzzzzzk_);
                object fzzzzzzzzzzzzzzm_(Extension @this)
                {
                    DataType fzzzzzzzzzzzzzzx_ = @this?.Value;

                    return fzzzzzzzzzzzzzzx_;
                };
                IEnumerable<object> fzzzzzzzzzzzzzzn_ = context.Operators.Select<Extension, object>(fzzzzzzzzzzzzzzl_, fzzzzzzzzzzzzzzm_);
                object fzzzzzzzzzzzzzzo_ = context.Operators.SingletonFrom<object>(fzzzzzzzzzzzzzzn_);
                CqlConcept fzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fzzzzzzzzzzzzzzo_ as CodeableConcept);
                CqlValueSet fzzzzzzzzzzzzzzq_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? fzzzzzzzzzzzzzzr_ = context.Operators.ConceptInValueSet(fzzzzzzzzzzzzzzp_, fzzzzzzzzzzzzzzq_);
                bool? fzzzzzzzzzzzzzzs_ = context.Operators.And(fzzzzzzzzzzzzzzj_, fzzzzzzzzzzzzzzr_);

                return fzzzzzzzzzzzzzzs_;
            };
            IEnumerable<Encounter.DiagnosisComponent> fzzzzzzzzzzzzzzc_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)fzzzzzzzzzzzzzza_, fzzzzzzzzzzzzzzb_);
            bool? fzzzzzzzzzzzzzzd_ = context.Operators.Exists<Encounter.DiagnosisComponent>(fzzzzzzzzzzzzzzc_);

            return fzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Encounter> ezzzzzzzzzzzzzzz_ = context.Operators.Where<Encounter>(ezzzzzzzzzzzzzzx_, ezzzzzzzzzzzzzzy_);

        return ezzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with High BMI by Exam")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_High_BMI_by_Exam(CqlContext context)
    {
        IEnumerable<Encounter> fzzzzzzzzzzzzzzy_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzz_(Encounter InpatientEncounter)
        {
            CqlCode gzzzzzzzzzzzzzzb_ = this.Body_mass_index__BMI___Ratio_(context);
            IEnumerable<CqlCode> gzzzzzzzzzzzzzzc_ = context.Operators.ToList<CqlCode>(gzzzzzzzzzzzzzzb_);
            IEnumerable<Observation> gzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, gzzzzzzzzzzzzzzc_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            bool? gzzzzzzzzzzzzzze_(Observation BMI)
            {
                DataType gzzzzzzzzzzzzzzi_ = BMI?.Effective;
                object gzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzi_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.ToInterval(context, gzzzzzzzzzzzzzzj_);
                CqlDateTime gzzzzzzzzzzzzzzl_ = context.Operators.Start(gzzzzzzzzzzzzzzk_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzm_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, InpatientEncounter);
                bool? gzzzzzzzzzzzzzzn_ = context.Operators.In<CqlDateTime>(gzzzzzzzzzzzzzzl_, gzzzzzzzzzzzzzzm_, default);
                DataType gzzzzzzzzzzzzzzo_ = BMI?.Value;
                object gzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzo_);
                CqlQuantity gzzzzzzzzzzzzzzq_ = context.Operators.Quantity(25m, "kg/m2");
                bool? gzzzzzzzzzzzzzzr_ = context.Operators.GreaterOrEqual(gzzzzzzzzzzzzzzp_ as CqlQuantity, gzzzzzzzzzzzzzzq_);
                bool? gzzzzzzzzzzzzzzs_ = context.Operators.And(gzzzzzzzzzzzzzzn_, gzzzzzzzzzzzzzzr_);

                return gzzzzzzzzzzzzzzs_;
            };
            IEnumerable<Observation> gzzzzzzzzzzzzzzf_ = context.Operators.Where<Observation>(gzzzzzzzzzzzzzzd_, gzzzzzzzzzzzzzze_);
            Encounter gzzzzzzzzzzzzzzg_(Observation BMI) =>
                InpatientEncounter;
            IEnumerable<Encounter> gzzzzzzzzzzzzzzh_ = context.Operators.Select<Observation, Encounter>(gzzzzzzzzzzzzzzf_, gzzzzzzzzzzzzzzg_);

            return gzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Encounter> gzzzzzzzzzzzzzza_ = context.Operators.SelectMany<Encounter, Encounter>(fzzzzzzzzzzzzzzy_, fzzzzzzzzzzzzzzz_);

        return gzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Leukemia or Lymphoma Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Leukemia_or_Lymphoma_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> gzzzzzzzzzzzzzzt_ = this.Qualifying_Encounter(context);
        bool? gzzzzzzzzzzzzzzu_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> gzzzzzzzzzzzzzzw_ = InpatientEncounter?.Diagnosis;
            bool? gzzzzzzzzzzzzzzx_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference hzzzzzzzzzzzzzza_ = Dx?.Condition;
                Condition hzzzzzzzzzzzzzzb_ = CQMCommon_2_2_000.Instance.GetCondition(context, hzzzzzzzzzzzzzza_);
                CodeableConcept hzzzzzzzzzzzzzzc_ = hzzzzzzzzzzzzzzb_?.Code;
                CqlConcept hzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, hzzzzzzzzzzzzzzc_);
                CqlValueSet hzzzzzzzzzzzzzze_ = this.Leukemia_or_Lymphoma(context);
                bool? hzzzzzzzzzzzzzzf_ = context.Operators.ConceptInValueSet(hzzzzzzzzzzzzzzd_, hzzzzzzzzzzzzzze_);
                bool? hzzzzzzzzzzzzzzg_(Extension @this)
                {
                    string hzzzzzzzzzzzzzzp_ = @this?.Url;
                    FhirString hzzzzzzzzzzzzzzq_ = context.Operators.Convert<FhirString>(hzzzzzzzzzzzzzzp_);
                    string hzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToString(context, hzzzzzzzzzzzzzzq_);
                    bool? hzzzzzzzzzzzzzzs_ = context.Operators.Equal(hzzzzzzzzzzzzzzr_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return hzzzzzzzzzzzzzzs_;
                };
                IEnumerable<Extension> hzzzzzzzzzzzzzzh_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), hzzzzzzzzzzzzzzg_);
                object hzzzzzzzzzzzzzzi_(Extension @this)
                {
                    DataType hzzzzzzzzzzzzzzt_ = @this?.Value;

                    return hzzzzzzzzzzzzzzt_;
                };
                IEnumerable<object> hzzzzzzzzzzzzzzj_ = context.Operators.Select<Extension, object>(hzzzzzzzzzzzzzzh_, hzzzzzzzzzzzzzzi_);
                object hzzzzzzzzzzzzzzk_ = context.Operators.SingletonFrom<object>(hzzzzzzzzzzzzzzj_);
                CqlConcept hzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, hzzzzzzzzzzzzzzk_ as CodeableConcept);
                CqlValueSet hzzzzzzzzzzzzzzm_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? hzzzzzzzzzzzzzzn_ = context.Operators.ConceptInValueSet(hzzzzzzzzzzzzzzl_, hzzzzzzzzzzzzzzm_);
                bool? hzzzzzzzzzzzzzzo_ = context.Operators.And(hzzzzzzzzzzzzzzf_, hzzzzzzzzzzzzzzn_);

                return hzzzzzzzzzzzzzzo_;
            };
            IEnumerable<Encounter.DiagnosisComponent> gzzzzzzzzzzzzzzy_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)gzzzzzzzzzzzzzzw_, gzzzzzzzzzzzzzzx_);
            bool? gzzzzzzzzzzzzzzz_ = context.Operators.Exists<Encounter.DiagnosisComponent>(gzzzzzzzzzzzzzzy_);

            return gzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Encounter> gzzzzzzzzzzzzzzv_ = context.Operators.Where<Encounter>(gzzzzzzzzzzzzzzt_, gzzzzzzzzzzzzzzu_);

        return gzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Liver Disease Moderate to Severe Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Liver_Disease_Moderate_to_Severe_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> hzzzzzzzzzzzzzzu_ = this.Qualifying_Encounter(context);
        bool? hzzzzzzzzzzzzzzv_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> hzzzzzzzzzzzzzzx_ = InpatientEncounter?.Diagnosis;
            bool? hzzzzzzzzzzzzzzy_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference izzzzzzzzzzzzzzb_ = Dx?.Condition;
                Condition izzzzzzzzzzzzzzc_ = CQMCommon_2_2_000.Instance.GetCondition(context, izzzzzzzzzzzzzzb_);
                CodeableConcept izzzzzzzzzzzzzzd_ = izzzzzzzzzzzzzzc_?.Code;
                CqlConcept izzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, izzzzzzzzzzzzzzd_);
                CqlValueSet izzzzzzzzzzzzzzf_ = this.Liver_Disease_Moderate_to_Severe(context);
                bool? izzzzzzzzzzzzzzg_ = context.Operators.ConceptInValueSet(izzzzzzzzzzzzzze_, izzzzzzzzzzzzzzf_);
                bool? izzzzzzzzzzzzzzh_(Extension @this)
                {
                    string izzzzzzzzzzzzzzq_ = @this?.Url;
                    FhirString izzzzzzzzzzzzzzr_ = context.Operators.Convert<FhirString>(izzzzzzzzzzzzzzq_);
                    string izzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToString(context, izzzzzzzzzzzzzzr_);
                    bool? izzzzzzzzzzzzzzt_ = context.Operators.Equal(izzzzzzzzzzzzzzs_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return izzzzzzzzzzzzzzt_;
                };
                IEnumerable<Extension> izzzzzzzzzzzzzzi_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), izzzzzzzzzzzzzzh_);
                object izzzzzzzzzzzzzzj_(Extension @this)
                {
                    DataType izzzzzzzzzzzzzzu_ = @this?.Value;

                    return izzzzzzzzzzzzzzu_;
                };
                IEnumerable<object> izzzzzzzzzzzzzzk_ = context.Operators.Select<Extension, object>(izzzzzzzzzzzzzzi_, izzzzzzzzzzzzzzj_);
                object izzzzzzzzzzzzzzl_ = context.Operators.SingletonFrom<object>(izzzzzzzzzzzzzzk_);
                CqlConcept izzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, izzzzzzzzzzzzzzl_ as CodeableConcept);
                CqlValueSet izzzzzzzzzzzzzzn_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? izzzzzzzzzzzzzzo_ = context.Operators.ConceptInValueSet(izzzzzzzzzzzzzzm_, izzzzzzzzzzzzzzn_);
                bool? izzzzzzzzzzzzzzp_ = context.Operators.And(izzzzzzzzzzzzzzg_, izzzzzzzzzzzzzzo_);

                return izzzzzzzzzzzzzzp_;
            };
            IEnumerable<Encounter.DiagnosisComponent> hzzzzzzzzzzzzzzz_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)hzzzzzzzzzzzzzzx_, hzzzzzzzzzzzzzzy_);
            bool? izzzzzzzzzzzzzza_ = context.Operators.Exists<Encounter.DiagnosisComponent>(hzzzzzzzzzzzzzzz_);

            return izzzzzzzzzzzzzza_;
        };
        IEnumerable<Encounter> hzzzzzzzzzzzzzzw_ = context.Operators.Where<Encounter>(hzzzzzzzzzzzzzzu_, hzzzzzzzzzzzzzzv_);

        return hzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Low BMI")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Low_BMI(CqlContext context)
    {
        IEnumerable<Encounter> izzzzzzzzzzzzzzv_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> izzzzzzzzzzzzzzw_(Encounter InpatientEncounter)
        {
            CqlCode izzzzzzzzzzzzzzy_ = this.Body_mass_index__BMI___Ratio_(context);
            IEnumerable<CqlCode> izzzzzzzzzzzzzzz_ = context.Operators.ToList<CqlCode>(izzzzzzzzzzzzzzy_);
            IEnumerable<Observation> jzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, izzzzzzzzzzzzzzz_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            bool? jzzzzzzzzzzzzzzb_(Observation BMI)
            {
                DataType jzzzzzzzzzzzzzzf_ = BMI?.Effective;
                object jzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzf_);
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.ToInterval(context, jzzzzzzzzzzzzzzg_);
                CqlDateTime jzzzzzzzzzzzzzzi_ = context.Operators.Start(jzzzzzzzzzzzzzzh_);
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzj_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, InpatientEncounter);
                bool? jzzzzzzzzzzzzzzk_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzzzzzzi_, jzzzzzzzzzzzzzzj_, default);
                DataType jzzzzzzzzzzzzzzl_ = BMI?.Value;
                object jzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzl_);
                CqlQuantity jzzzzzzzzzzzzzzn_ = context.Operators.Quantity(18.5m, "kg/m2");
                bool? jzzzzzzzzzzzzzzo_ = context.Operators.Less(jzzzzzzzzzzzzzzm_ as CqlQuantity, jzzzzzzzzzzzzzzn_);
                bool? jzzzzzzzzzzzzzzp_ = context.Operators.And(jzzzzzzzzzzzzzzk_, jzzzzzzzzzzzzzzo_);

                return jzzzzzzzzzzzzzzp_;
            };
            IEnumerable<Observation> jzzzzzzzzzzzzzzc_ = context.Operators.Where<Observation>(jzzzzzzzzzzzzzza_, jzzzzzzzzzzzzzzb_);
            Encounter jzzzzzzzzzzzzzzd_(Observation BMI) =>
                InpatientEncounter;
            IEnumerable<Encounter> jzzzzzzzzzzzzzze_ = context.Operators.Select<Observation, Encounter>(jzzzzzzzzzzzzzzc_, jzzzzzzzzzzzzzzd_);

            return jzzzzzzzzzzzzzze_;
        };
        IEnumerable<Encounter> izzzzzzzzzzzzzzx_ = context.Operators.SelectMany<Encounter, Encounter>(izzzzzzzzzzzzzzv_, izzzzzzzzzzzzzzw_);

        return izzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Malignant Bone Disease Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Malignant_Bone_Disease_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> jzzzzzzzzzzzzzzq_ = this.Qualifying_Encounter(context);
        bool? jzzzzzzzzzzzzzzr_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> jzzzzzzzzzzzzzzt_ = InpatientEncounter?.Diagnosis;
            bool? jzzzzzzzzzzzzzzu_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference jzzzzzzzzzzzzzzx_ = Dx?.Condition;
                Condition jzzzzzzzzzzzzzzy_ = CQMCommon_2_2_000.Instance.GetCondition(context, jzzzzzzzzzzzzzzx_);
                CodeableConcept jzzzzzzzzzzzzzzz_ = jzzzzzzzzzzzzzzy_?.Code;
                CqlConcept kzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, jzzzzzzzzzzzzzzz_);
                CqlValueSet kzzzzzzzzzzzzzzb_ = this.Malignant_Bone_Disease(context);
                bool? kzzzzzzzzzzzzzzc_ = context.Operators.ConceptInValueSet(kzzzzzzzzzzzzzza_, kzzzzzzzzzzzzzzb_);
                bool? kzzzzzzzzzzzzzzd_(Extension @this)
                {
                    string kzzzzzzzzzzzzzzm_ = @this?.Url;
                    FhirString kzzzzzzzzzzzzzzn_ = context.Operators.Convert<FhirString>(kzzzzzzzzzzzzzzm_);
                    string kzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToString(context, kzzzzzzzzzzzzzzn_);
                    bool? kzzzzzzzzzzzzzzp_ = context.Operators.Equal(kzzzzzzzzzzzzzzo_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return kzzzzzzzzzzzzzzp_;
                };
                IEnumerable<Extension> kzzzzzzzzzzzzzze_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), kzzzzzzzzzzzzzzd_);
                object kzzzzzzzzzzzzzzf_(Extension @this)
                {
                    DataType kzzzzzzzzzzzzzzq_ = @this?.Value;

                    return kzzzzzzzzzzzzzzq_;
                };
                IEnumerable<object> kzzzzzzzzzzzzzzg_ = context.Operators.Select<Extension, object>(kzzzzzzzzzzzzzze_, kzzzzzzzzzzzzzzf_);
                object kzzzzzzzzzzzzzzh_ = context.Operators.SingletonFrom<object>(kzzzzzzzzzzzzzzg_);
                CqlConcept kzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, kzzzzzzzzzzzzzzh_ as CodeableConcept);
                CqlValueSet kzzzzzzzzzzzzzzj_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? kzzzzzzzzzzzzzzk_ = context.Operators.ConceptInValueSet(kzzzzzzzzzzzzzzi_, kzzzzzzzzzzzzzzj_);
                bool? kzzzzzzzzzzzzzzl_ = context.Operators.And(kzzzzzzzzzzzzzzc_, kzzzzzzzzzzzzzzk_);

                return kzzzzzzzzzzzzzzl_;
            };
            IEnumerable<Encounter.DiagnosisComponent> jzzzzzzzzzzzzzzv_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)jzzzzzzzzzzzzzzt_, jzzzzzzzzzzzzzzu_);
            bool? jzzzzzzzzzzzzzzw_ = context.Operators.Exists<Encounter.DiagnosisComponent>(jzzzzzzzzzzzzzzv_);

            return jzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Encounter> jzzzzzzzzzzzzzzs_ = context.Operators.Where<Encounter>(jzzzzzzzzzzzzzzq_, jzzzzzzzzzzzzzzr_);

        return jzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Neurologic Disorder Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Neurologic_Disorder_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> kzzzzzzzzzzzzzzr_ = this.Qualifying_Encounter(context);
        bool? kzzzzzzzzzzzzzzs_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> kzzzzzzzzzzzzzzu_ = InpatientEncounter?.Diagnosis;
            bool? kzzzzzzzzzzzzzzv_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference kzzzzzzzzzzzzzzy_ = Dx?.Condition;
                Condition kzzzzzzzzzzzzzzz_ = CQMCommon_2_2_000.Instance.GetCondition(context, kzzzzzzzzzzzzzzy_);
                CodeableConcept lzzzzzzzzzzzzzza_ = kzzzzzzzzzzzzzzz_?.Code;
                CqlConcept lzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, lzzzzzzzzzzzzzza_);
                CqlValueSet lzzzzzzzzzzzzzzc_ = this.Neurologic_Movement_and_Related_Disorders(context);
                bool? lzzzzzzzzzzzzzzd_ = context.Operators.ConceptInValueSet(lzzzzzzzzzzzzzzb_, lzzzzzzzzzzzzzzc_);
                bool? lzzzzzzzzzzzzzze_(Extension @this)
                {
                    string lzzzzzzzzzzzzzzn_ = @this?.Url;
                    FhirString lzzzzzzzzzzzzzzo_ = context.Operators.Convert<FhirString>(lzzzzzzzzzzzzzzn_);
                    string lzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToString(context, lzzzzzzzzzzzzzzo_);
                    bool? lzzzzzzzzzzzzzzq_ = context.Operators.Equal(lzzzzzzzzzzzzzzp_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return lzzzzzzzzzzzzzzq_;
                };
                IEnumerable<Extension> lzzzzzzzzzzzzzzf_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), lzzzzzzzzzzzzzze_);
                object lzzzzzzzzzzzzzzg_(Extension @this)
                {
                    DataType lzzzzzzzzzzzzzzr_ = @this?.Value;

                    return lzzzzzzzzzzzzzzr_;
                };
                IEnumerable<object> lzzzzzzzzzzzzzzh_ = context.Operators.Select<Extension, object>(lzzzzzzzzzzzzzzf_, lzzzzzzzzzzzzzzg_);
                object lzzzzzzzzzzzzzzi_ = context.Operators.SingletonFrom<object>(lzzzzzzzzzzzzzzh_);
                CqlConcept lzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, lzzzzzzzzzzzzzzi_ as CodeableConcept);
                CqlValueSet lzzzzzzzzzzzzzzk_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? lzzzzzzzzzzzzzzl_ = context.Operators.ConceptInValueSet(lzzzzzzzzzzzzzzj_, lzzzzzzzzzzzzzzk_);
                bool? lzzzzzzzzzzzzzzm_ = context.Operators.And(lzzzzzzzzzzzzzzd_, lzzzzzzzzzzzzzzl_);

                return lzzzzzzzzzzzzzzm_;
            };
            IEnumerable<Encounter.DiagnosisComponent> kzzzzzzzzzzzzzzw_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)kzzzzzzzzzzzzzzu_, kzzzzzzzzzzzzzzv_);
            bool? kzzzzzzzzzzzzzzx_ = context.Operators.Exists<Encounter.DiagnosisComponent>(kzzzzzzzzzzzzzzw_);

            return kzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Encounter> kzzzzzzzzzzzzzzt_ = context.Operators.Where<Encounter>(kzzzzzzzzzzzzzzr_, kzzzzzzzzzzzzzzs_);

        return kzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Obesity Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Obesity_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> lzzzzzzzzzzzzzzs_ = this.Qualifying_Encounter(context);
        bool? lzzzzzzzzzzzzzzt_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> lzzzzzzzzzzzzzzv_ = InpatientEncounter?.Diagnosis;
            bool? lzzzzzzzzzzzzzzw_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference lzzzzzzzzzzzzzzz_ = Dx?.Condition;
                Condition mzzzzzzzzzzzzzza_ = CQMCommon_2_2_000.Instance.GetCondition(context, lzzzzzzzzzzzzzzz_);
                CodeableConcept mzzzzzzzzzzzzzzb_ = mzzzzzzzzzzzzzza_?.Code;
                CqlConcept mzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, mzzzzzzzzzzzzzzb_);
                CqlValueSet mzzzzzzzzzzzzzzd_ = this.Obesity(context);
                bool? mzzzzzzzzzzzzzze_ = context.Operators.ConceptInValueSet(mzzzzzzzzzzzzzzc_, mzzzzzzzzzzzzzzd_);
                bool? mzzzzzzzzzzzzzzf_(Extension @this)
                {
                    string mzzzzzzzzzzzzzzo_ = @this?.Url;
                    FhirString mzzzzzzzzzzzzzzp_ = context.Operators.Convert<FhirString>(mzzzzzzzzzzzzzzo_);
                    string mzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToString(context, mzzzzzzzzzzzzzzp_);
                    bool? mzzzzzzzzzzzzzzr_ = context.Operators.Equal(mzzzzzzzzzzzzzzq_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return mzzzzzzzzzzzzzzr_;
                };
                IEnumerable<Extension> mzzzzzzzzzzzzzzg_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), mzzzzzzzzzzzzzzf_);
                object mzzzzzzzzzzzzzzh_(Extension @this)
                {
                    DataType mzzzzzzzzzzzzzzs_ = @this?.Value;

                    return mzzzzzzzzzzzzzzs_;
                };
                IEnumerable<object> mzzzzzzzzzzzzzzi_ = context.Operators.Select<Extension, object>(mzzzzzzzzzzzzzzg_, mzzzzzzzzzzzzzzh_);
                object mzzzzzzzzzzzzzzj_ = context.Operators.SingletonFrom<object>(mzzzzzzzzzzzzzzi_);
                CqlConcept mzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, mzzzzzzzzzzzzzzj_ as CodeableConcept);
                CqlValueSet mzzzzzzzzzzzzzzl_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? mzzzzzzzzzzzzzzm_ = context.Operators.ConceptInValueSet(mzzzzzzzzzzzzzzk_, mzzzzzzzzzzzzzzl_);
                bool? mzzzzzzzzzzzzzzn_ = context.Operators.And(mzzzzzzzzzzzzzze_, mzzzzzzzzzzzzzzm_);

                return mzzzzzzzzzzzzzzn_;
            };
            IEnumerable<Encounter.DiagnosisComponent> lzzzzzzzzzzzzzzx_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)lzzzzzzzzzzzzzzv_, lzzzzzzzzzzzzzzw_);
            bool? lzzzzzzzzzzzzzzy_ = context.Operators.Exists<Encounter.DiagnosisComponent>(lzzzzzzzzzzzzzzx_);

            return lzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Encounter> lzzzzzzzzzzzzzzu_ = context.Operators.Where<Encounter>(lzzzzzzzzzzzzzzs_, lzzzzzzzzzzzzzzt_);

        return lzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Opioid Medication Active at Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Opioid_Medication_Active_at_Admission(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzzzzzzzzzt_ = this.Qualifying_Encounter(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzu_(Encounter InpatientEncounter)
        {
            CqlValueSet mzzzzzzzzzzzzzzw_ = this.Opioids(context);
            IEnumerable<MedicationRequest> mzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, mzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> mzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, mzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> nzzzzzzzzzzzzzza_ = context.Operators.Union<MedicationRequest>(mzzzzzzzzzzzzzzx_, mzzzzzzzzzzzzzzz_);
            bool? nzzzzzzzzzzzzzzb_(MedicationRequest OpioidMed)
            {
                Code<MedicationRequest.MedicationrequestStatus> nzzzzzzzzzzzzzzf_ = OpioidMed?.StatusElement;
                MedicationRequest.MedicationrequestStatus? nzzzzzzzzzzzzzzg_ = nzzzzzzzzzzzzzzf_?.Value;
                string nzzzzzzzzzzzzzzh_ = context.Operators.Convert<string>(nzzzzzzzzzzzzzzg_);
                bool? nzzzzzzzzzzzzzzi_ = context.Operators.Equal(nzzzzzzzzzzzzzzh_, "active");
                Code<MedicationRequest.MedicationRequestIntent> nzzzzzzzzzzzzzzj_ = OpioidMed?.IntentElement;
                MedicationRequest.MedicationRequestIntent? nzzzzzzzzzzzzzzk_ = nzzzzzzzzzzzzzzj_?.Value;
                string nzzzzzzzzzzzzzzl_ = context.Operators.Convert<string>(nzzzzzzzzzzzzzzk_);
                bool? nzzzzzzzzzzzzzzm_ = context.Operators.Equal(nzzzzzzzzzzzzzzl_, "order");
                MedicationRequest.MedicationRequestIntent? nzzzzzzzzzzzzzzo_ = nzzzzzzzzzzzzzzj_?.Value;
                string nzzzzzzzzzzzzzzp_ = context.Operators.Convert<string>(nzzzzzzzzzzzzzzo_);
                bool? nzzzzzzzzzzzzzzq_ = context.Operators.Equal(nzzzzzzzzzzzzzzp_, "plan");
                DataType nzzzzzzzzzzzzzzr_ = OpioidMed?.Reported;
                object nzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzr_);
                object nzzzzzzzzzzzzzzt_ = context.Operators.LateBoundProperty<object>(nzzzzzzzzzzzzzzs_, "reference");
                string nzzzzzzzzzzzzzzu_ = context.Operators.LateBoundProperty<string>(nzzzzzzzzzzzzzzt_, "value");
                string nzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.getId(context, nzzzzzzzzzzzzzzu_);
                Id nzzzzzzzzzzzzzzw_()
                {
                    bool ozzzzzzzzzzzzzzt_()
                    {
                        Patient ozzzzzzzzzzzzzzu_ = this.Patient(context);
                        bool ozzzzzzzzzzzzzzv_ = ozzzzzzzzzzzzzzu_ is Resource;

                        return ozzzzzzzzzzzzzzv_;
                    };
                    if (ozzzzzzzzzzzzzzt_())
                    {
                        Patient ozzzzzzzzzzzzzzw_ = this.Patient(context);

                        return (ozzzzzzzzzzzzzzw_ as Resource).IdElement;
                    }
                    else
                    {
                        return default;
                    }
                };
                string nzzzzzzzzzzzzzzx_ = (nzzzzzzzzzzzzzzw_())?.Value;
                bool? nzzzzzzzzzzzzzzy_ = context.Operators.Equal(nzzzzzzzzzzzzzzv_, nzzzzzzzzzzzzzzx_);
                bool? nzzzzzzzzzzzzzzz_ = context.Operators.And(nzzzzzzzzzzzzzzq_, nzzzzzzzzzzzzzzy_);
                bool? ozzzzzzzzzzzzzza_ = context.Operators.Or(nzzzzzzzzzzzzzzm_, nzzzzzzzzzzzzzzz_);
                bool? ozzzzzzzzzzzzzzb_ = context.Operators.And(nzzzzzzzzzzzzzzi_, ozzzzzzzzzzzzzza_);
                bool? ozzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.isCommunity(context, OpioidMed);
                bool? ozzzzzzzzzzzzzzd_ = context.Operators.And(ozzzzzzzzzzzzzzb_, ozzzzzzzzzzzzzzc_);
                CqlInterval<CqlDate> ozzzzzzzzzzzzzze_ = CumulativeMedicationDuration_4_1_000.Instance.MedicationRequestPeriod(context, OpioidMed);
                CqlDate ozzzzzzzzzzzzzzf_ = ozzzzzzzzzzzzzze_?.low;
                CqlDateTime ozzzzzzzzzzzzzzg_ = context.Operators.ConvertDateToDateTime(ozzzzzzzzzzzzzzf_);
                CqlDate ozzzzzzzzzzzzzzi_ = ozzzzzzzzzzzzzze_?.high;
                CqlDateTime ozzzzzzzzzzzzzzj_ = context.Operators.ConvertDateToDateTime(ozzzzzzzzzzzzzzi_);
                bool? ozzzzzzzzzzzzzzl_ = ozzzzzzzzzzzzzze_?.lowClosed;
                bool? ozzzzzzzzzzzzzzn_ = ozzzzzzzzzzzzzze_?.highClosed;
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzo_ = context.Operators.Interval(ozzzzzzzzzzzzzzg_, ozzzzzzzzzzzzzzj_, ozzzzzzzzzzzzzzl_, ozzzzzzzzzzzzzzn_);
                Period ozzzzzzzzzzzzzzp_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzzzzzzp_);
                bool? ozzzzzzzzzzzzzzr_ = context.Operators.OverlapsBefore(ozzzzzzzzzzzzzzo_, ozzzzzzzzzzzzzzq_, default);
                bool? ozzzzzzzzzzzzzzs_ = context.Operators.And(ozzzzzzzzzzzzzzd_, ozzzzzzzzzzzzzzr_);

                return ozzzzzzzzzzzzzzs_;
            };
            IEnumerable<MedicationRequest> nzzzzzzzzzzzzzzc_ = context.Operators.Where<MedicationRequest>(nzzzzzzzzzzzzzza_, nzzzzzzzzzzzzzzb_);
            Encounter nzzzzzzzzzzzzzzd_(MedicationRequest OpioidMed) =>
                InpatientEncounter;
            IEnumerable<Encounter> nzzzzzzzzzzzzzze_ = context.Operators.Select<MedicationRequest, Encounter>(nzzzzzzzzzzzzzzc_, nzzzzzzzzzzzzzzd_);

            return nzzzzzzzzzzzzzze_;
        };
        IEnumerable<Encounter> mzzzzzzzzzzzzzzv_ = context.Operators.SelectMany<Encounter, Encounter>(mzzzzzzzzzzzzzzt_, mzzzzzzzzzzzzzzu_);

        return mzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Osteoporosis Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Osteoporosis_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> ozzzzzzzzzzzzzzx_ = this.Qualifying_Encounter(context);
        bool? ozzzzzzzzzzzzzzy_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> pzzzzzzzzzzzzzza_ = InpatientEncounter?.Diagnosis;
            bool? pzzzzzzzzzzzzzzb_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference pzzzzzzzzzzzzzze_ = Dx?.Condition;
                Condition pzzzzzzzzzzzzzzf_ = CQMCommon_2_2_000.Instance.GetCondition(context, pzzzzzzzzzzzzzze_);
                CodeableConcept pzzzzzzzzzzzzzzg_ = pzzzzzzzzzzzzzzf_?.Code;
                CqlConcept pzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, pzzzzzzzzzzzzzzg_);
                CqlValueSet pzzzzzzzzzzzzzzi_ = this.Osteoporosis(context);
                bool? pzzzzzzzzzzzzzzj_ = context.Operators.ConceptInValueSet(pzzzzzzzzzzzzzzh_, pzzzzzzzzzzzzzzi_);
                bool? pzzzzzzzzzzzzzzk_(Extension @this)
                {
                    string pzzzzzzzzzzzzzzt_ = @this?.Url;
                    FhirString pzzzzzzzzzzzzzzu_ = context.Operators.Convert<FhirString>(pzzzzzzzzzzzzzzt_);
                    string pzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToString(context, pzzzzzzzzzzzzzzu_);
                    bool? pzzzzzzzzzzzzzzw_ = context.Operators.Equal(pzzzzzzzzzzzzzzv_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return pzzzzzzzzzzzzzzw_;
                };
                IEnumerable<Extension> pzzzzzzzzzzzzzzl_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), pzzzzzzzzzzzzzzk_);
                object pzzzzzzzzzzzzzzm_(Extension @this)
                {
                    DataType pzzzzzzzzzzzzzzx_ = @this?.Value;

                    return pzzzzzzzzzzzzzzx_;
                };
                IEnumerable<object> pzzzzzzzzzzzzzzn_ = context.Operators.Select<Extension, object>(pzzzzzzzzzzzzzzl_, pzzzzzzzzzzzzzzm_);
                object pzzzzzzzzzzzzzzo_ = context.Operators.SingletonFrom<object>(pzzzzzzzzzzzzzzn_);
                CqlConcept pzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, pzzzzzzzzzzzzzzo_ as CodeableConcept);
                CqlValueSet pzzzzzzzzzzzzzzq_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? pzzzzzzzzzzzzzzr_ = context.Operators.ConceptInValueSet(pzzzzzzzzzzzzzzp_, pzzzzzzzzzzzzzzq_);
                bool? pzzzzzzzzzzzzzzs_ = context.Operators.And(pzzzzzzzzzzzzzzj_, pzzzzzzzzzzzzzzr_);

                return pzzzzzzzzzzzzzzs_;
            };
            IEnumerable<Encounter.DiagnosisComponent> pzzzzzzzzzzzzzzc_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)pzzzzzzzzzzzzzza_, pzzzzzzzzzzzzzzb_);
            bool? pzzzzzzzzzzzzzzd_ = context.Operators.Exists<Encounter.DiagnosisComponent>(pzzzzzzzzzzzzzzc_);

            return pzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Encounter> ozzzzzzzzzzzzzzz_ = context.Operators.Where<Encounter>(ozzzzzzzzzzzzzzx_, ozzzzzzzzzzzzzzy_);

        return ozzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Peripheral Neuropathy Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Peripheral_Neuropathy_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> pzzzzzzzzzzzzzzy_ = this.Qualifying_Encounter(context);
        bool? pzzzzzzzzzzzzzzz_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> qzzzzzzzzzzzzzzb_ = InpatientEncounter?.Diagnosis;
            bool? qzzzzzzzzzzzzzzc_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference qzzzzzzzzzzzzzzf_ = Dx?.Condition;
                Condition qzzzzzzzzzzzzzzg_ = CQMCommon_2_2_000.Instance.GetCondition(context, qzzzzzzzzzzzzzzf_);
                CodeableConcept qzzzzzzzzzzzzzzh_ = qzzzzzzzzzzzzzzg_?.Code;
                CqlConcept qzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, qzzzzzzzzzzzzzzh_);
                CqlValueSet qzzzzzzzzzzzzzzj_ = this.Peripheral_Neuropathy(context);
                bool? qzzzzzzzzzzzzzzk_ = context.Operators.ConceptInValueSet(qzzzzzzzzzzzzzzi_, qzzzzzzzzzzzzzzj_);
                bool? qzzzzzzzzzzzzzzl_(Extension @this)
                {
                    string qzzzzzzzzzzzzzzu_ = @this?.Url;
                    FhirString qzzzzzzzzzzzzzzv_ = context.Operators.Convert<FhirString>(qzzzzzzzzzzzzzzu_);
                    string qzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToString(context, qzzzzzzzzzzzzzzv_);
                    bool? qzzzzzzzzzzzzzzx_ = context.Operators.Equal(qzzzzzzzzzzzzzzw_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return qzzzzzzzzzzzzzzx_;
                };
                IEnumerable<Extension> qzzzzzzzzzzzzzzm_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), qzzzzzzzzzzzzzzl_);
                object qzzzzzzzzzzzzzzn_(Extension @this)
                {
                    DataType qzzzzzzzzzzzzzzy_ = @this?.Value;

                    return qzzzzzzzzzzzzzzy_;
                };
                IEnumerable<object> qzzzzzzzzzzzzzzo_ = context.Operators.Select<Extension, object>(qzzzzzzzzzzzzzzm_, qzzzzzzzzzzzzzzn_);
                object qzzzzzzzzzzzzzzp_ = context.Operators.SingletonFrom<object>(qzzzzzzzzzzzzzzo_);
                CqlConcept qzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, qzzzzzzzzzzzzzzp_ as CodeableConcept);
                CqlValueSet qzzzzzzzzzzzzzzr_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? qzzzzzzzzzzzzzzs_ = context.Operators.ConceptInValueSet(qzzzzzzzzzzzzzzq_, qzzzzzzzzzzzzzzr_);
                bool? qzzzzzzzzzzzzzzt_ = context.Operators.And(qzzzzzzzzzzzzzzk_, qzzzzzzzzzzzzzzs_);

                return qzzzzzzzzzzzzzzt_;
            };
            IEnumerable<Encounter.DiagnosisComponent> qzzzzzzzzzzzzzzd_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)qzzzzzzzzzzzzzzb_, qzzzzzzzzzzzzzzc_);
            bool? qzzzzzzzzzzzzzze_ = context.Operators.Exists<Encounter.DiagnosisComponent>(qzzzzzzzzzzzzzzd_);

            return qzzzzzzzzzzzzzze_;
        };
        IEnumerable<Encounter> qzzzzzzzzzzzzzza_ = context.Operators.Where<Encounter>(pzzzzzzzzzzzzzzy_, pzzzzzzzzzzzzzzz_);

        return qzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Stroke Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Stroke_Present_on_Admission(CqlContext context)
    {
        IEnumerable<Encounter> qzzzzzzzzzzzzzzz_ = this.Qualifying_Encounter(context);
        bool? rzzzzzzzzzzzzzza_(Encounter InpatientEncounter)
        {
            List<Encounter.DiagnosisComponent> rzzzzzzzzzzzzzzc_ = InpatientEncounter?.Diagnosis;
            bool? rzzzzzzzzzzzzzzd_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference rzzzzzzzzzzzzzzg_ = Dx?.Condition;
                Condition rzzzzzzzzzzzzzzh_ = CQMCommon_2_2_000.Instance.GetCondition(context, rzzzzzzzzzzzzzzg_);
                CodeableConcept rzzzzzzzzzzzzzzi_ = rzzzzzzzzzzzzzzh_?.Code;
                CqlConcept rzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, rzzzzzzzzzzzzzzi_);
                CqlValueSet rzzzzzzzzzzzzzzk_ = this.Stroke(context);
                bool? rzzzzzzzzzzzzzzl_ = context.Operators.ConceptInValueSet(rzzzzzzzzzzzzzzj_, rzzzzzzzzzzzzzzk_);
                bool? rzzzzzzzzzzzzzzm_(Extension @this)
                {
                    string rzzzzzzzzzzzzzzv_ = @this?.Url;
                    FhirString rzzzzzzzzzzzzzzw_ = context.Operators.Convert<FhirString>(rzzzzzzzzzzzzzzv_);
                    string rzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToString(context, rzzzzzzzzzzzzzzw_);
                    bool? rzzzzzzzzzzzzzzy_ = context.Operators.Equal(rzzzzzzzzzzzzzzx_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return rzzzzzzzzzzzzzzy_;
                };
                IEnumerable<Extension> rzzzzzzzzzzzzzzn_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), rzzzzzzzzzzzzzzm_);
                object rzzzzzzzzzzzzzzo_(Extension @this)
                {
                    DataType rzzzzzzzzzzzzzzz_ = @this?.Value;

                    return rzzzzzzzzzzzzzzz_;
                };
                IEnumerable<object> rzzzzzzzzzzzzzzp_ = context.Operators.Select<Extension, object>(rzzzzzzzzzzzzzzn_, rzzzzzzzzzzzzzzo_);
                object rzzzzzzzzzzzzzzq_ = context.Operators.SingletonFrom<object>(rzzzzzzzzzzzzzzp_);
                CqlConcept rzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, rzzzzzzzzzzzzzzq_ as CodeableConcept);
                CqlValueSet rzzzzzzzzzzzzzzs_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? rzzzzzzzzzzzzzzt_ = context.Operators.ConceptInValueSet(rzzzzzzzzzzzzzzr_, rzzzzzzzzzzzzzzs_);
                bool? rzzzzzzzzzzzzzzu_ = context.Operators.And(rzzzzzzzzzzzzzzl_, rzzzzzzzzzzzzzzt_);

                return rzzzzzzzzzzzzzzu_;
            };
            IEnumerable<Encounter.DiagnosisComponent> rzzzzzzzzzzzzzze_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)rzzzzzzzzzzzzzzc_, rzzzzzzzzzzzzzzd_);
            bool? rzzzzzzzzzzzzzzf_ = context.Operators.Exists<Encounter.DiagnosisComponent>(rzzzzzzzzzzzzzze_);

            return rzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Encounter> rzzzzzzzzzzzzzzb_ = context.Operators.Where<Encounter>(qzzzzzzzzzzzzzzz_, rzzzzzzzzzzzzzza_);

        return rzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Suicide Attempt")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Suicide_Attempt(CqlContext context)
    {
        IEnumerable<Encounter> szzzzzzzzzzzzzza_ = this.Qualifying_Encounter(context);
        bool? szzzzzzzzzzzzzzb_(Encounter InpatientEncounter)
        {
            IEnumerable<Condition> szzzzzzzzzzzzzzd_ = CQMCommon_2_2_000.Instance.EncounterDiagnosis(context, InpatientEncounter);
            bool? szzzzzzzzzzzzzze_(Condition @this)
            {
                CodeableConcept szzzzzzzzzzzzzzk_ = @this?.Code;
                CqlConcept szzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, szzzzzzzzzzzzzzk_);
                bool? szzzzzzzzzzzzzzm_ = context.Operators.Not((bool?)(szzzzzzzzzzzzzzl_ is null));

                return szzzzzzzzzzzzzzm_;
            };
            IEnumerable<Condition> szzzzzzzzzzzzzzf_ = context.Operators.Where<Condition>(szzzzzzzzzzzzzzd_, szzzzzzzzzzzzzze_);
            CqlConcept szzzzzzzzzzzzzzg_(Condition @this)
            {
                CodeableConcept szzzzzzzzzzzzzzn_ = @this?.Code;
                CqlConcept szzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, szzzzzzzzzzzzzzn_);

                return szzzzzzzzzzzzzzo_;
            };
            IEnumerable<CqlConcept> szzzzzzzzzzzzzzh_ = context.Operators.Select<Condition, CqlConcept>(szzzzzzzzzzzzzzf_, szzzzzzzzzzzzzzg_);
            CqlValueSet szzzzzzzzzzzzzzi_ = this.Suicide_Attempt(context);
            bool? szzzzzzzzzzzzzzj_ = context.Operators.ConceptsInValueSet(szzzzzzzzzzzzzzh_, szzzzzzzzzzzzzzi_);

            return szzzzzzzzzzzzzzj_;
        };
        IEnumerable<Encounter> szzzzzzzzzzzzzzc_ = context.Operators.Where<Encounter>(szzzzzzzzzzzzzza_, szzzzzzzzzzzzzzb_);

        return szzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? szzzzzzzzzzzzzzp_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return szzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> szzzzzzzzzzzzzzq_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return szzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? szzzzzzzzzzzzzzr_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return szzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode szzzzzzzzzzzzzzs_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return szzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context)
    {
        IEnumerable<Encounter> szzzzzzzzzzzzzzt_ = this.Encounter_with_a_Fall_Present_on_Admission(context);

        return szzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Encounter where a Fall and Moderate Injury Occurred")]
    public IEnumerable<Encounter> Encounter_where_a_Fall_and_Moderate_Injury_Occurred(CqlContext context)
    {
        IEnumerable<Encounter> szzzzzzzzzzzzzzu_ = this.Encounter_where_a_Fall_Occurred(context);
        bool? szzzzzzzzzzzzzzv_(Encounter FallOccurred)
        {
            List<Encounter.DiagnosisComponent> szzzzzzzzzzzzzzx_ = FallOccurred?.Diagnosis;
            bool? szzzzzzzzzzzzzzy_(Encounter.DiagnosisComponent Dx)
            {
                ResourceReference tzzzzzzzzzzzzzzb_ = Dx?.Condition;
                Condition tzzzzzzzzzzzzzzc_ = CQMCommon_2_2_000.Instance.GetCondition(context, tzzzzzzzzzzzzzzb_);
                CodeableConcept tzzzzzzzzzzzzzzd_ = tzzzzzzzzzzzzzzc_?.Code;
                CqlConcept tzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, tzzzzzzzzzzzzzzd_);
                CqlValueSet tzzzzzzzzzzzzzzf_ = this.Moderate_Injuries(context);
                bool? tzzzzzzzzzzzzzzg_ = context.Operators.ConceptInValueSet(tzzzzzzzzzzzzzze_, tzzzzzzzzzzzzzzf_);
                bool? tzzzzzzzzzzzzzzh_(Extension @this)
                {
                    string tzzzzzzzzzzzzzzx_ = @this?.Url;
                    FhirString tzzzzzzzzzzzzzzy_ = context.Operators.Convert<FhirString>(tzzzzzzzzzzzzzzx_);
                    string tzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToString(context, tzzzzzzzzzzzzzzy_);
                    bool? uzzzzzzzzzzzzzza_ = context.Operators.Equal(tzzzzzzzzzzzzzzz_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return uzzzzzzzzzzzzzza_;
                };
                IEnumerable<Extension> tzzzzzzzzzzzzzzi_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), tzzzzzzzzzzzzzzh_);
                object tzzzzzzzzzzzzzzj_(Extension @this)
                {
                    DataType uzzzzzzzzzzzzzzb_ = @this?.Value;

                    return uzzzzzzzzzzzzzzb_;
                };
                IEnumerable<object> tzzzzzzzzzzzzzzk_ = context.Operators.Select<Extension, object>(tzzzzzzzzzzzzzzi_, tzzzzzzzzzzzzzzj_);
                object tzzzzzzzzzzzzzzl_ = context.Operators.SingletonFrom<object>(tzzzzzzzzzzzzzzk_);
                CqlConcept tzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, tzzzzzzzzzzzzzzl_ as CodeableConcept);
                CqlValueSet tzzzzzzzzzzzzzzn_ = this.Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine(context);
                bool? tzzzzzzzzzzzzzzo_ = context.Operators.ConceptInValueSet(tzzzzzzzzzzzzzzm_, tzzzzzzzzzzzzzzn_);
                bool? tzzzzzzzzzzzzzzp_(Extension @this)
                {
                    string uzzzzzzzzzzzzzzc_ = @this?.Url;
                    FhirString uzzzzzzzzzzzzzzd_ = context.Operators.Convert<FhirString>(uzzzzzzzzzzzzzzc_);
                    string uzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToString(context, uzzzzzzzzzzzzzzd_);
                    bool? uzzzzzzzzzzzzzzf_ = context.Operators.Equal(uzzzzzzzzzzzzzze_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return uzzzzzzzzzzzzzzf_;
                };
                IEnumerable<Extension> tzzzzzzzzzzzzzzq_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Dx is Element
                        ? (Dx as Element).Extension
                        : default), tzzzzzzzzzzzzzzp_);
                object tzzzzzzzzzzzzzzr_(Extension @this)
                {
                    DataType uzzzzzzzzzzzzzzg_ = @this?.Value;

                    return uzzzzzzzzzzzzzzg_;
                };
                IEnumerable<object> tzzzzzzzzzzzzzzs_ = context.Operators.Select<Extension, object>(tzzzzzzzzzzzzzzq_, tzzzzzzzzzzzzzzr_);
                object tzzzzzzzzzzzzzzt_ = context.Operators.SingletonFrom<object>(tzzzzzzzzzzzzzzs_);
                CqlConcept tzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, tzzzzzzzzzzzzzzt_ as CodeableConcept);
                bool? tzzzzzzzzzzzzzzv_ = context.Operators.Or(tzzzzzzzzzzzzzzo_, (bool?)(tzzzzzzzzzzzzzzu_ is null));
                bool? tzzzzzzzzzzzzzzw_ = context.Operators.And(tzzzzzzzzzzzzzzg_, tzzzzzzzzzzzzzzv_);

                return tzzzzzzzzzzzzzzw_;
            };
            IEnumerable<Encounter.DiagnosisComponent> szzzzzzzzzzzzzzz_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)szzzzzzzzzzzzzzx_, szzzzzzzzzzzzzzy_);
            bool? tzzzzzzzzzzzzzza_ = context.Operators.Exists<Encounter.DiagnosisComponent>(szzzzzzzzzzzzzzz_);

            return tzzzzzzzzzzzzzza_;
        };
        IEnumerable<Encounter> szzzzzzzzzzzzzzw_ = context.Operators.Where<Encounter>(szzzzzzzzzzzzzzu_, szzzzzzzzzzzzzzv_);

        return szzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> uzzzzzzzzzzzzzzh_ = this.Encounter_where_a_Fall_and_Major_Injury_Occurred(context);
        IEnumerable<Encounter> uzzzzzzzzzzzzzzi_ = this.Encounter_where_a_Fall_and_Moderate_Injury_Occurred(context);
        IEnumerable<Encounter> uzzzzzzzzzzzzzzj_ = context.Operators.Union<Encounter>(uzzzzzzzzzzzzzzh_, uzzzzzzzzzzzzzzi_);

        return uzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Denominator Observation")]
    public int? Denominator_Observation(CqlContext context, Encounter QualifyingEncounter)
    {
        CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzk_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, QualifyingEncounter);
        CqlDateTime uzzzzzzzzzzzzzzl_ = context.Operators.Start(uzzzzzzzzzzzzzzk_);
        CqlDateTime uzzzzzzzzzzzzzzn_ = context.Operators.End(uzzzzzzzzzzzzzzk_);
        int? uzzzzzzzzzzzzzzo_ = context.Operators.DurationBetween(uzzzzzzzzzzzzzzl_, uzzzzzzzzzzzzzzn_, "day");

        return uzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Numerator Observation")]
    public int? Numerator_Observation(CqlContext context, Encounter QualifyingEncounter)
    {
        IEnumerable<Encounter> uzzzzzzzzzzzzzzp_ = this.Encounter_where_a_Fall_and_Major_Injury_Occurred(context);
        bool? uzzzzzzzzzzzzzzq_(Encounter FallsEncounter)
        {
            Period uzzzzzzzzzzzzzzt_ = FallsEncounter?.Period;
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzzzzzt_);
            CqlDateTime uzzzzzzzzzzzzzzv_ = context.Operators.End(uzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzw_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, QualifyingEncounter);
            bool? uzzzzzzzzzzzzzzx_ = context.Operators.In<CqlDateTime>(uzzzzzzzzzzzzzzv_, uzzzzzzzzzzzzzzw_, default);

            return uzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Encounter> uzzzzzzzzzzzzzzr_ = context.Operators.Where<Encounter>(uzzzzzzzzzzzzzzp_, uzzzzzzzzzzzzzzq_);
        int? uzzzzzzzzzzzzzzs_ = context.Operators.Count<Encounter>(uzzzzzzzzzzzzzzr_);

        return uzzzzzzzzzzzzzzs_;
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
