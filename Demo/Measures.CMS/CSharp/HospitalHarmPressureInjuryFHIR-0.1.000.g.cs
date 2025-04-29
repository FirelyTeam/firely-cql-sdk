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
[CqlLibrary("HospitalHarmPressureInjuryFHIR", "0.1.000")]
public partial class HospitalHarmPressureInjuryFHIR_0_1_000 : ILibrary, ISingleton<HospitalHarmPressureInjuryFHIR_0_1_000>
{
    private HospitalHarmPressureInjuryFHIR_0_1_000() {}

    public static HospitalHarmPressureInjuryFHIR_0_1_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "HospitalHarmPressureInjuryFHIR";
    public string Version => "0.1.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_3_5_000.Instance, CQMCommon_2_2_000.Instance, QICoreCommon_2_1_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("COVID 19", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.140", valueSetVersion: null)]
    public CqlValueSet COVID_19(CqlContext _) => _COVID_19;
    private static readonly CqlValueSet _COVID_19 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.140", null);

    [CqlValueSetDefinition("Emergency Department Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", valueSetVersion: null)]
    public CqlValueSet Emergency_Department_Visit(CqlContext _) => _Emergency_Department_Visit;
    private static readonly CqlValueSet _Emergency_Department_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", null);

    [CqlValueSetDefinition("Encounter Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext _) => _Encounter_Inpatient;
    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlValueSetDefinition("Not Present On Admission or Documentation Insufficient to Determine", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.198", valueSetVersion: null)]
    public CqlValueSet Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine(CqlContext _) => _Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine;
    private static readonly CqlValueSet _Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.198", null);

    [CqlValueSetDefinition("Observation Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", valueSetVersion: null)]
    public CqlValueSet Observation_Services(CqlContext _) => _Observation_Services;
    private static readonly CqlValueSet _Observation_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", null);

    [CqlValueSetDefinition("Present on Admission or Clinically Undetermined", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.197", valueSetVersion: null)]
    public CqlValueSet Present_on_Admission_or_Clinically_Undetermined(CqlContext _) => _Present_on_Admission_or_Clinically_Undetermined;
    private static readonly CqlValueSet _Present_on_Admission_or_Clinically_Undetermined = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.197", null);

    [CqlValueSetDefinition("Pressure Injury Deep Tissue", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.112", valueSetVersion: null)]
    public CqlValueSet Pressure_Injury_Deep_Tissue(CqlContext _) => _Pressure_Injury_Deep_Tissue;
    private static readonly CqlValueSet _Pressure_Injury_Deep_Tissue = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.112", null);

    [CqlValueSetDefinition("Pressure Injury Deep Tissue Diagnoses", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.194", valueSetVersion: null)]
    public CqlValueSet Pressure_Injury_Deep_Tissue_Diagnoses(CqlContext _) => _Pressure_Injury_Deep_Tissue_Diagnoses;
    private static readonly CqlValueSet _Pressure_Injury_Deep_Tissue_Diagnoses = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.194", null);

    [CqlValueSetDefinition("Pressure Injury Stage 2, 3, 4 or Unstageable", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.113", valueSetVersion: null)]
    public CqlValueSet Pressure_Injury_Stage_2__3__4_or_Unstageable(CqlContext _) => _Pressure_Injury_Stage_2__3__4_or_Unstageable;
    private static readonly CqlValueSet _Pressure_Injury_Stage_2__3__4_or_Unstageable = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.113", null);

    [CqlValueSetDefinition("Pressure Injury Stage 2, 3, 4, or Unstageable Diagnoses", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.196", valueSetVersion: null)]
    public CqlValueSet Pressure_Injury_Stage_2__3__4__or_Unstageable_Diagnoses(CqlContext _) => _Pressure_Injury_Stage_2__3__4__or_Unstageable_Diagnoses;
    private static readonly CqlValueSet _Pressure_Injury_Stage_2__3__4__or_Unstageable_Diagnoses = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.196", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Physical findings of Skin", codeId: "8709-8", codeSystem: "http://loinc.org")]
    public CqlCode Physical_findings_of_Skin(CqlContext _) => _Physical_findings_of_Skin;
    private static readonly CqlCode _Physical_findings_of_Skin = new CqlCode("8709-8", "http://loinc.org", default, default);

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
        CqlDateTime rzzzzzzzzzzzzzzl_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime rzzzzzzzzzzzzzzm_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzn_ = context.Operators.Interval(rzzzzzzzzzzzzzzl_, rzzzzzzzzzzzzzzm_, true, true);
        object rzzzzzzzzzzzzzzo_ = context.ResolveParameter("HospitalHarmPressureInjuryFHIR-0.1.000", "Measurement Period", rzzzzzzzzzzzzzzn_);

        return (CqlInterval<CqlDateTime>)rzzzzzzzzzzzzzzo_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> rzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient rzzzzzzzzzzzzzzq_ = context.Operators.SingletonFrom<Patient>(rzzzzzzzzzzzzzzp_);

        return rzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Encounter with Age 18 and Older")]
    public IEnumerable<Encounter> Encounter_with_Age_18_and_Older(CqlContext context)
    {
        CqlValueSet rzzzzzzzzzzzzzzr_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? rzzzzzzzzzzzzzzt_(Encounter InpatientEncounter)
        {
            Patient rzzzzzzzzzzzzzzv_ = this.Patient(context);
            Date rzzzzzzzzzzzzzzw_ = rzzzzzzzzzzzzzzv_?.BirthDateElement;
            string rzzzzzzzzzzzzzzx_ = rzzzzzzzzzzzzzzw_?.Value;
            CqlDate rzzzzzzzzzzzzzzy_ = context.Operators.ConvertStringToDate(rzzzzzzzzzzzzzzx_);
            Period rzzzzzzzzzzzzzzz_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzzzzzzz_);
            CqlDateTime szzzzzzzzzzzzzzb_ = context.Operators.Start(szzzzzzzzzzzzzza_);
            CqlDate szzzzzzzzzzzzzzc_ = context.Operators.DateFrom(szzzzzzzzzzzzzzb_);
            int? szzzzzzzzzzzzzzd_ = context.Operators.CalculateAgeAt(rzzzzzzzzzzzzzzy_, szzzzzzzzzzzzzzc_, "year");
            bool? szzzzzzzzzzzzzze_ = context.Operators.GreaterOrEqual(szzzzzzzzzzzzzzd_, 18);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzzzzzzz_);
            CqlDateTime szzzzzzzzzzzzzzh_ = context.Operators.End(szzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzi_ = this.Measurement_Period(context);
            bool? szzzzzzzzzzzzzzj_ = context.Operators.In<CqlDateTime>(szzzzzzzzzzzzzzh_, szzzzzzzzzzzzzzi_, "day");
            bool? szzzzzzzzzzzzzzk_ = context.Operators.And(szzzzzzzzzzzzzze_, szzzzzzzzzzzzzzj_);
            Code<Encounter.EncounterStatus> szzzzzzzzzzzzzzl_ = InpatientEncounter?.StatusElement;
            Encounter.EncounterStatus? szzzzzzzzzzzzzzm_ = szzzzzzzzzzzzzzl_?.Value;
            Code<Encounter.EncounterStatus> szzzzzzzzzzzzzzn_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(szzzzzzzzzzzzzzm_);
            bool? szzzzzzzzzzzzzzo_ = context.Operators.Equal(szzzzzzzzzzzzzzn_, "finished");
            bool? szzzzzzzzzzzzzzp_ = context.Operators.And(szzzzzzzzzzzzzzk_, szzzzzzzzzzzzzzo_);

            return szzzzzzzzzzzzzzp_;
        };
        IEnumerable<Encounter> rzzzzzzzzzzzzzzu_ = context.Operators.Where<Encounter>(rzzzzzzzzzzzzzzs_, rzzzzzzzzzzzzzzt_);

        return rzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> szzzzzzzzzzzzzzq_ = this.Encounter_with_Age_18_and_Older(context);

        return szzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> szzzzzzzzzzzzzzr_ = this.Initial_Population(context);

        return szzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Encounter with Deep Tissue Pressure Injury POA by Indicator")]
    public IEnumerable<Encounter> Encounter_with_Deep_Tissue_Pressure_Injury_POA_by_Indicator(CqlContext context)
    {
        IEnumerable<Encounter> szzzzzzzzzzzzzzs_ = this.Encounter_with_Age_18_and_Older(context);
        bool? szzzzzzzzzzzzzzt_(Encounter InpatientHospitalization)
        {
            List<Encounter.DiagnosisComponent> szzzzzzzzzzzzzzv_ = InpatientHospitalization?.Diagnosis;
            bool? szzzzzzzzzzzzzzw_(Encounter.DiagnosisComponent EncounterDiag)
            {
                ResourceReference szzzzzzzzzzzzzzz_ = EncounterDiag?.Condition;
                Condition tzzzzzzzzzzzzzza_ = CQMCommon_2_2_000.Instance.getCondition(context, szzzzzzzzzzzzzzz_);
                CodeableConcept tzzzzzzzzzzzzzzb_ = tzzzzzzzzzzzzzza_?.Code;
                CqlConcept tzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, tzzzzzzzzzzzzzzb_);
                CqlValueSet tzzzzzzzzzzzzzzd_ = this.Pressure_Injury_Deep_Tissue_Diagnoses(context);
                bool? tzzzzzzzzzzzzzze_ = context.Operators.ConceptInValueSet(tzzzzzzzzzzzzzzc_, tzzzzzzzzzzzzzzd_);
                bool? tzzzzzzzzzzzzzzf_(Extension @this)
                {
                    string tzzzzzzzzzzzzzzo_ = @this?.Url;
                    FhirString tzzzzzzzzzzzzzzp_ = context.Operators.Convert<FhirString>(tzzzzzzzzzzzzzzo_);
                    string tzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToString(context, tzzzzzzzzzzzzzzp_);
                    bool? tzzzzzzzzzzzzzzr_ = context.Operators.Equal(tzzzzzzzzzzzzzzq_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return tzzzzzzzzzzzzzzr_;
                };
                IEnumerable<Extension> tzzzzzzzzzzzzzzg_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(EncounterDiag is Element
                        ? (EncounterDiag as Element).Extension
                        : default), tzzzzzzzzzzzzzzf_);
                object tzzzzzzzzzzzzzzh_(Extension @this)
                {
                    DataType tzzzzzzzzzzzzzzs_ = @this?.Value;

                    return tzzzzzzzzzzzzzzs_;
                };
                IEnumerable<object> tzzzzzzzzzzzzzzi_ = context.Operators.Select<Extension, object>(tzzzzzzzzzzzzzzg_, tzzzzzzzzzzzzzzh_);
                object tzzzzzzzzzzzzzzj_ = context.Operators.SingletonFrom<object>(tzzzzzzzzzzzzzzi_);
                CqlConcept tzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, tzzzzzzzzzzzzzzj_ as CodeableConcept);
                CqlValueSet tzzzzzzzzzzzzzzl_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? tzzzzzzzzzzzzzzm_ = context.Operators.ConceptInValueSet(tzzzzzzzzzzzzzzk_, tzzzzzzzzzzzzzzl_);
                bool? tzzzzzzzzzzzzzzn_ = context.Operators.And(tzzzzzzzzzzzzzze_, tzzzzzzzzzzzzzzm_);

                return tzzzzzzzzzzzzzzn_;
            };
            IEnumerable<Encounter.DiagnosisComponent> szzzzzzzzzzzzzzx_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)szzzzzzzzzzzzzzv_, szzzzzzzzzzzzzzw_);
            bool? szzzzzzzzzzzzzzy_ = context.Operators.Exists<Encounter.DiagnosisComponent>(szzzzzzzzzzzzzzx_);

            return szzzzzzzzzzzzzzy_;
        };
        IEnumerable<Encounter> szzzzzzzzzzzzzzu_ = context.Operators.Where<Encounter>(szzzzzzzzzzzzzzs_, szzzzzzzzzzzzzzt_);

        return szzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Encounter with Deep Tissue Pressure Injury POA by Skin Exam within First 72 Hours")]
    public IEnumerable<Encounter> Encounter_with_Deep_Tissue_Pressure_Injury_POA_by_Skin_Exam_within_First_72_Hours(CqlContext context)
    {
        IEnumerable<Encounter> tzzzzzzzzzzzzzzt_ = this.Encounter_with_Age_18_and_Older(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzu_(Encounter InpatientHospitalization)
        {
            CqlCode tzzzzzzzzzzzzzzw_ = this.Physical_findings_of_Skin(context);
            IEnumerable<CqlCode> tzzzzzzzzzzzzzzx_ = context.Operators.ToList<CqlCode>(tzzzzzzzzzzzzzzw_);
            IEnumerable<Observation> tzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, tzzzzzzzzzzzzzzx_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            bool? tzzzzzzzzzzzzzzz_(Observation SkinExam)
            {
                DataType uzzzzzzzzzzzzzzd_ = SkinExam?.Effective;
                object uzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzd_);
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.ToInterval(context, uzzzzzzzzzzzzzze_);
                CqlDateTime uzzzzzzzzzzzzzzg_ = context.Operators.Start(uzzzzzzzzzzzzzzf_);
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzh_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, InpatientHospitalization);
                CqlDateTime uzzzzzzzzzzzzzzi_ = context.Operators.Start(uzzzzzzzzzzzzzzh_);
                CqlDateTime uzzzzzzzzzzzzzzk_ = context.Operators.Start(uzzzzzzzzzzzzzzh_);
                CqlQuantity uzzzzzzzzzzzzzzl_ = context.Operators.Quantity(72m, "hours");
                CqlDateTime uzzzzzzzzzzzzzzm_ = context.Operators.Add(uzzzzzzzzzzzzzzk_, uzzzzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzn_ = context.Operators.Interval(uzzzzzzzzzzzzzzi_, uzzzzzzzzzzzzzzm_, true, true);
                bool? uzzzzzzzzzzzzzzo_ = context.Operators.In<CqlDateTime>(uzzzzzzzzzzzzzzg_, uzzzzzzzzzzzzzzn_, default);
                Code<ObservationStatus> uzzzzzzzzzzzzzzp_ = SkinExam?.StatusElement;
                ObservationStatus? uzzzzzzzzzzzzzzq_ = uzzzzzzzzzzzzzzp_?.Value;
                Code<ObservationStatus> uzzzzzzzzzzzzzzr_ = context.Operators.Convert<Code<ObservationStatus>>(uzzzzzzzzzzzzzzq_);
                string uzzzzzzzzzzzzzzs_ = context.Operators.Convert<string>(uzzzzzzzzzzzzzzr_);
                string[] uzzzzzzzzzzzzzzt_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? uzzzzzzzzzzzzzzu_ = context.Operators.In<string>(uzzzzzzzzzzzzzzs_, uzzzzzzzzzzzzzzt_ as IEnumerable<string>);
                bool? uzzzzzzzzzzzzzzv_ = context.Operators.And(uzzzzzzzzzzzzzzo_, uzzzzzzzzzzzzzzu_);
                CodeableConcept uzzzzzzzzzzzzzzw_ = SkinExam?.Code;
                CqlConcept uzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, uzzzzzzzzzzzzzzw_);
                CqlValueSet uzzzzzzzzzzzzzzy_ = this.Pressure_Injury_Deep_Tissue(context);
                bool? uzzzzzzzzzzzzzzz_ = context.Operators.ConceptInValueSet(uzzzzzzzzzzzzzzx_, uzzzzzzzzzzzzzzy_);
                bool? vzzzzzzzzzzzzzza_ = context.Operators.And(uzzzzzzzzzzzzzzv_, uzzzzzzzzzzzzzzz_);

                return vzzzzzzzzzzzzzza_;
            };
            IEnumerable<Observation> uzzzzzzzzzzzzzza_ = context.Operators.Where<Observation>(tzzzzzzzzzzzzzzy_, tzzzzzzzzzzzzzzz_);
            Encounter uzzzzzzzzzzzzzzb_(Observation SkinExam) =>
                InpatientHospitalization;
            IEnumerable<Encounter> uzzzzzzzzzzzzzzc_ = context.Operators.Select<Observation, Encounter>(uzzzzzzzzzzzzzza_, uzzzzzzzzzzzzzzb_);

            return uzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Encounter> tzzzzzzzzzzzzzzv_ = context.Operators.SelectMany<Encounter, Encounter>(tzzzzzzzzzzzzzzt_, tzzzzzzzzzzzzzzu_);

        return tzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Encounter with Deep Tissue Pressure Injury POA")]
    public IEnumerable<Encounter> Encounter_with_Deep_Tissue_Pressure_Injury_POA(CqlContext context)
    {
        IEnumerable<Encounter> vzzzzzzzzzzzzzzb_ = this.Encounter_with_Deep_Tissue_Pressure_Injury_POA_by_Indicator(context);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzc_ = this.Encounter_with_Deep_Tissue_Pressure_Injury_POA_by_Skin_Exam_within_First_72_Hours(context);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzd_ = context.Operators.Union<Encounter>(vzzzzzzzzzzzzzzb_, vzzzzzzzzzzzzzzc_);

        return vzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Encounter with Stage 2, 3, 4, or Unstageable Pressure Injury Present on Admission by POA Indicator")]
    public IEnumerable<Encounter> Encounter_with_Stage_2__3__4__or_Unstageable_Pressure_Injury_Present_on_Admission_by_POA_Indicator(CqlContext context)
    {
        IEnumerable<Encounter> vzzzzzzzzzzzzzze_ = this.Encounter_with_Age_18_and_Older(context);
        bool? vzzzzzzzzzzzzzzf_(Encounter InpatientHospitalization)
        {
            List<Encounter.DiagnosisComponent> vzzzzzzzzzzzzzzh_ = InpatientHospitalization?.Diagnosis;
            bool? vzzzzzzzzzzzzzzi_(Encounter.DiagnosisComponent Stage234UnstageablePressureInjury)
            {
                ResourceReference vzzzzzzzzzzzzzzl_ = Stage234UnstageablePressureInjury?.Condition;
                Condition vzzzzzzzzzzzzzzm_ = CQMCommon_2_2_000.Instance.getCondition(context, vzzzzzzzzzzzzzzl_);
                CodeableConcept vzzzzzzzzzzzzzzn_ = vzzzzzzzzzzzzzzm_?.Code;
                CqlConcept vzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, vzzzzzzzzzzzzzzn_);
                CqlValueSet vzzzzzzzzzzzzzzp_ = this.Pressure_Injury_Stage_2__3__4__or_Unstageable_Diagnoses(context);
                bool? vzzzzzzzzzzzzzzq_ = context.Operators.ConceptInValueSet(vzzzzzzzzzzzzzzo_, vzzzzzzzzzzzzzzp_);
                bool? vzzzzzzzzzzzzzzr_(Extension @this)
                {
                    string wzzzzzzzzzzzzzza_ = @this?.Url;
                    FhirString wzzzzzzzzzzzzzzb_ = context.Operators.Convert<FhirString>(wzzzzzzzzzzzzzza_);
                    string wzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToString(context, wzzzzzzzzzzzzzzb_);
                    bool? wzzzzzzzzzzzzzzd_ = context.Operators.Equal(wzzzzzzzzzzzzzzc_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return wzzzzzzzzzzzzzzd_;
                };
                IEnumerable<Extension> vzzzzzzzzzzzzzzs_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Stage234UnstageablePressureInjury is Element
                        ? (Stage234UnstageablePressureInjury as Element).Extension
                        : default), vzzzzzzzzzzzzzzr_);
                object vzzzzzzzzzzzzzzt_(Extension @this)
                {
                    DataType wzzzzzzzzzzzzzze_ = @this?.Value;

                    return wzzzzzzzzzzzzzze_;
                };
                IEnumerable<object> vzzzzzzzzzzzzzzu_ = context.Operators.Select<Extension, object>(vzzzzzzzzzzzzzzs_, vzzzzzzzzzzzzzzt_);
                object vzzzzzzzzzzzzzzv_ = context.Operators.SingletonFrom<object>(vzzzzzzzzzzzzzzu_);
                CqlConcept vzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, vzzzzzzzzzzzzzzv_ as CodeableConcept);
                CqlValueSet vzzzzzzzzzzzzzzx_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? vzzzzzzzzzzzzzzy_ = context.Operators.ConceptInValueSet(vzzzzzzzzzzzzzzw_, vzzzzzzzzzzzzzzx_);
                bool? vzzzzzzzzzzzzzzz_ = context.Operators.And(vzzzzzzzzzzzzzzq_, vzzzzzzzzzzzzzzy_);

                return vzzzzzzzzzzzzzzz_;
            };
            IEnumerable<Encounter.DiagnosisComponent> vzzzzzzzzzzzzzzj_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)vzzzzzzzzzzzzzzh_, vzzzzzzzzzzzzzzi_);
            bool? vzzzzzzzzzzzzzzk_ = context.Operators.Exists<Encounter.DiagnosisComponent>(vzzzzzzzzzzzzzzj_);

            return vzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Encounter> vzzzzzzzzzzzzzzg_ = context.Operators.Where<Encounter>(vzzzzzzzzzzzzzze_, vzzzzzzzzzzzzzzf_);

        return vzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Encounter with Stage 2, 3, 4 or Unstageable Pressure Injury POA by Skin Exam within 24 Hours")]
    public IEnumerable<Encounter> Encounter_with_Stage_2__3__4_or_Unstageable_Pressure_Injury_POA_by_Skin_Exam_within_24_Hours(CqlContext context)
    {
        IEnumerable<Encounter> wzzzzzzzzzzzzzzf_ = this.Encounter_with_Age_18_and_Older(context);
        IEnumerable<Encounter> wzzzzzzzzzzzzzzg_(Encounter InpatientHospitalization)
        {
            CqlCode wzzzzzzzzzzzzzzi_ = this.Physical_findings_of_Skin(context);
            IEnumerable<CqlCode> wzzzzzzzzzzzzzzj_ = context.Operators.ToList<CqlCode>(wzzzzzzzzzzzzzzi_);
            IEnumerable<Observation> wzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, wzzzzzzzzzzzzzzj_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            bool? wzzzzzzzzzzzzzzl_(Observation SkinExam)
            {
                DataType wzzzzzzzzzzzzzzp_ = SkinExam?.Effective;
                object wzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzp_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.ToInterval(context, wzzzzzzzzzzzzzzq_);
                CqlDateTime wzzzzzzzzzzzzzzs_ = context.Operators.Start(wzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzt_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, InpatientHospitalization);
                CqlDateTime wzzzzzzzzzzzzzzu_ = context.Operators.Start(wzzzzzzzzzzzzzzt_);
                CqlDateTime wzzzzzzzzzzzzzzw_ = context.Operators.Start(wzzzzzzzzzzzzzzt_);
                CqlQuantity wzzzzzzzzzzzzzzx_ = context.Operators.Quantity(24m, "hours");
                CqlDateTime wzzzzzzzzzzzzzzy_ = context.Operators.Add(wzzzzzzzzzzzzzzw_, wzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzz_ = context.Operators.Interval(wzzzzzzzzzzzzzzu_, wzzzzzzzzzzzzzzy_, true, true);
                bool? xzzzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(wzzzzzzzzzzzzzzs_, wzzzzzzzzzzzzzzz_, default);
                Code<ObservationStatus> xzzzzzzzzzzzzzzb_ = SkinExam?.StatusElement;
                ObservationStatus? xzzzzzzzzzzzzzzc_ = xzzzzzzzzzzzzzzb_?.Value;
                Code<ObservationStatus> xzzzzzzzzzzzzzzd_ = context.Operators.Convert<Code<ObservationStatus>>(xzzzzzzzzzzzzzzc_);
                string xzzzzzzzzzzzzzze_ = context.Operators.Convert<string>(xzzzzzzzzzzzzzzd_);
                string[] xzzzzzzzzzzzzzzf_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? xzzzzzzzzzzzzzzg_ = context.Operators.In<string>(xzzzzzzzzzzzzzze_, xzzzzzzzzzzzzzzf_ as IEnumerable<string>);
                bool? xzzzzzzzzzzzzzzh_ = context.Operators.And(xzzzzzzzzzzzzzza_, xzzzzzzzzzzzzzzg_);
                CodeableConcept xzzzzzzzzzzzzzzi_ = SkinExam?.Code;
                CqlConcept xzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, xzzzzzzzzzzzzzzi_);
                CqlValueSet xzzzzzzzzzzzzzzk_ = this.Pressure_Injury_Stage_2__3__4_or_Unstageable(context);
                bool? xzzzzzzzzzzzzzzl_ = context.Operators.ConceptInValueSet(xzzzzzzzzzzzzzzj_, xzzzzzzzzzzzzzzk_);
                bool? xzzzzzzzzzzzzzzm_ = context.Operators.And(xzzzzzzzzzzzzzzh_, xzzzzzzzzzzzzzzl_);

                return xzzzzzzzzzzzzzzm_;
            };
            IEnumerable<Observation> wzzzzzzzzzzzzzzm_ = context.Operators.Where<Observation>(wzzzzzzzzzzzzzzk_, wzzzzzzzzzzzzzzl_);
            Encounter wzzzzzzzzzzzzzzn_(Observation SkinExam) =>
                InpatientHospitalization;
            IEnumerable<Encounter> wzzzzzzzzzzzzzzo_ = context.Operators.Select<Observation, Encounter>(wzzzzzzzzzzzzzzm_, wzzzzzzzzzzzzzzn_);

            return wzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Encounter> wzzzzzzzzzzzzzzh_ = context.Operators.SelectMany<Encounter, Encounter>(wzzzzzzzzzzzzzzf_, wzzzzzzzzzzzzzzg_);

        return wzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Encounter with Stage 2, 3, 4 or Unstageable Pressure Injury POA")]
    public IEnumerable<Encounter> Encounter_with_Stage_2__3__4_or_Unstageable_Pressure_Injury_POA(CqlContext context)
    {
        IEnumerable<Encounter> xzzzzzzzzzzzzzzn_ = this.Encounter_with_Stage_2__3__4__or_Unstageable_Pressure_Injury_Present_on_Admission_by_POA_Indicator(context);
        IEnumerable<Encounter> xzzzzzzzzzzzzzzo_ = this.Encounter_with_Stage_2__3__4_or_Unstageable_Pressure_Injury_POA_by_Skin_Exam_within_24_Hours(context);
        IEnumerable<Encounter> xzzzzzzzzzzzzzzp_ = context.Operators.Union<Encounter>(xzzzzzzzzzzzzzzn_, xzzzzzzzzzzzzzzo_);

        return xzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Encounter with Diagnosis of COVID19 Infection")]
    public IEnumerable<Encounter> Encounter_with_Diagnosis_of_COVID19_Infection(CqlContext context)
    {
        IEnumerable<Encounter> xzzzzzzzzzzzzzzq_ = this.Encounter_with_Age_18_and_Older(context);
        bool? xzzzzzzzzzzzzzzr_(Encounter InpatientHospitalization)
        {
            IEnumerable<Condition> xzzzzzzzzzzzzzzt_ = CQMCommon_2_2_000.Instance.EncounterDiagnosis(context, InpatientHospitalization);
            bool? xzzzzzzzzzzzzzzu_(Condition EncounterDiag)
            {
                CodeableConcept xzzzzzzzzzzzzzzx_ = EncounterDiag?.Code;
                CqlConcept xzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, xzzzzzzzzzzzzzzx_);
                CqlValueSet xzzzzzzzzzzzzzzz_ = this.COVID_19(context);
                bool? yzzzzzzzzzzzzzza_ = context.Operators.ConceptInValueSet(xzzzzzzzzzzzzzzy_, xzzzzzzzzzzzzzzz_);

                return yzzzzzzzzzzzzzza_;
            };
            IEnumerable<Condition> xzzzzzzzzzzzzzzv_ = context.Operators.Where<Condition>(xzzzzzzzzzzzzzzt_, xzzzzzzzzzzzzzzu_);
            bool? xzzzzzzzzzzzzzzw_ = context.Operators.Exists<Condition>(xzzzzzzzzzzzzzzv_);

            return xzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Encounter> xzzzzzzzzzzzzzzs_ = context.Operators.Where<Encounter>(xzzzzzzzzzzzzzzq_, xzzzzzzzzzzzzzzr_);

        return xzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context)
    {
        IEnumerable<Encounter> yzzzzzzzzzzzzzzb_ = this.Encounter_with_Deep_Tissue_Pressure_Injury_POA(context);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzc_ = this.Encounter_with_Stage_2__3__4_or_Unstageable_Pressure_Injury_POA(context);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzd_ = context.Operators.Union<Encounter>(yzzzzzzzzzzzzzzb_, yzzzzzzzzzzzzzzc_);
        IEnumerable<Encounter> yzzzzzzzzzzzzzze_ = this.Encounter_with_Diagnosis_of_COVID19_Infection(context);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzf_ = context.Operators.Union<Encounter>(yzzzzzzzzzzzzzzd_, yzzzzzzzzzzzzzze_);

        return yzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Encounter with New Deep Tissue Pressure Injury Not POA by Indicator")]
    public IEnumerable<Encounter> Encounter_with_New_Deep_Tissue_Pressure_Injury_Not_POA_by_Indicator(CqlContext context)
    {
        IEnumerable<Encounter> yzzzzzzzzzzzzzzg_ = this.Encounter_with_Age_18_and_Older(context);
        bool? yzzzzzzzzzzzzzzh_(Encounter InpatientHospitalization)
        {
            List<Encounter.DiagnosisComponent> yzzzzzzzzzzzzzzj_ = InpatientHospitalization?.Diagnosis;
            bool? yzzzzzzzzzzzzzzk_(Encounter.DiagnosisComponent EncounterDiag)
            {
                ResourceReference yzzzzzzzzzzzzzzn_ = EncounterDiag?.Condition;
                Condition yzzzzzzzzzzzzzzo_ = CQMCommon_2_2_000.Instance.getCondition(context, yzzzzzzzzzzzzzzn_);
                CodeableConcept yzzzzzzzzzzzzzzp_ = yzzzzzzzzzzzzzzo_?.Code;
                CqlConcept yzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, yzzzzzzzzzzzzzzp_);
                CqlValueSet yzzzzzzzzzzzzzzr_ = this.Pressure_Injury_Deep_Tissue_Diagnoses(context);
                bool? yzzzzzzzzzzzzzzs_ = context.Operators.ConceptInValueSet(yzzzzzzzzzzzzzzq_, yzzzzzzzzzzzzzzr_);
                bool? yzzzzzzzzzzzzzzt_(Extension @this)
                {
                    string zzzzzzzzzzzzzzzc_ = @this?.Url;
                    FhirString zzzzzzzzzzzzzzzd_ = context.Operators.Convert<FhirString>(zzzzzzzzzzzzzzzc_);
                    string zzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToString(context, zzzzzzzzzzzzzzzd_);
                    bool? zzzzzzzzzzzzzzzf_ = context.Operators.Equal(zzzzzzzzzzzzzzze_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return zzzzzzzzzzzzzzzf_;
                };
                IEnumerable<Extension> yzzzzzzzzzzzzzzu_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(EncounterDiag is Element
                        ? (EncounterDiag as Element).Extension
                        : default), yzzzzzzzzzzzzzzt_);
                object yzzzzzzzzzzzzzzv_(Extension @this)
                {
                    DataType zzzzzzzzzzzzzzzg_ = @this?.Value;

                    return zzzzzzzzzzzzzzzg_;
                };
                IEnumerable<object> yzzzzzzzzzzzzzzw_ = context.Operators.Select<Extension, object>(yzzzzzzzzzzzzzzu_, yzzzzzzzzzzzzzzv_);
                object yzzzzzzzzzzzzzzx_ = context.Operators.SingletonFrom<object>(yzzzzzzzzzzzzzzw_);
                CqlConcept yzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, yzzzzzzzzzzzzzzx_ as CodeableConcept);
                CqlValueSet yzzzzzzzzzzzzzzz_ = this.Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine(context);
                bool? zzzzzzzzzzzzzzza_ = context.Operators.ConceptInValueSet(yzzzzzzzzzzzzzzy_, yzzzzzzzzzzzzzzz_);
                bool? zzzzzzzzzzzzzzzb_ = context.Operators.And(yzzzzzzzzzzzzzzs_, zzzzzzzzzzzzzzza_);

                return zzzzzzzzzzzzzzzb_;
            };
            IEnumerable<Encounter.DiagnosisComponent> yzzzzzzzzzzzzzzl_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)yzzzzzzzzzzzzzzj_, yzzzzzzzzzzzzzzk_);
            bool? yzzzzzzzzzzzzzzm_ = context.Operators.Exists<Encounter.DiagnosisComponent>(yzzzzzzzzzzzzzzl_);

            return yzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Encounter> yzzzzzzzzzzzzzzi_ = context.Operators.Where<Encounter>(yzzzzzzzzzzzzzzg_, yzzzzzzzzzzzzzzh_);

        return yzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Encounter with New Deep Tissue Pressure Injury by Skin Exam after First 72 Hours")]
    public IEnumerable<Encounter> Encounter_with_New_Deep_Tissue_Pressure_Injury_by_Skin_Exam_after_First_72_Hours(CqlContext context)
    {
        IEnumerable<Encounter> zzzzzzzzzzzzzzzh_ = this.Encounter_with_Age_18_and_Older(context);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzi_(Encounter InpatientHospitalization)
        {
            CqlCode zzzzzzzzzzzzzzzk_ = this.Physical_findings_of_Skin(context);
            IEnumerable<CqlCode> zzzzzzzzzzzzzzzl_ = context.Operators.ToList<CqlCode>(zzzzzzzzzzzzzzzk_);
            IEnumerable<Observation> zzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, zzzzzzzzzzzzzzzl_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            bool? zzzzzzzzzzzzzzzn_(Observation SkinExam)
            {
                DataType zzzzzzzzzzzzzzzr_ = SkinExam?.Effective;
                object zzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.ToInterval(context, zzzzzzzzzzzzzzzs_);
                CqlDateTime zzzzzzzzzzzzzzzu_ = context.Operators.Start(zzzzzzzzzzzzzzzt_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzv_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, InpatientHospitalization);
                CqlDateTime zzzzzzzzzzzzzzzw_ = context.Operators.Start(zzzzzzzzzzzzzzzv_);
                CqlQuantity zzzzzzzzzzzzzzzx_ = context.Operators.Quantity(72m, "hours");
                CqlDateTime zzzzzzzzzzzzzzzy_ = context.Operators.Add(zzzzzzzzzzzzzzzw_, zzzzzzzzzzzzzzzx_);
                CqlDateTime azzzzzzzzzzzzzzza_ = context.Operators.End(zzzzzzzzzzzzzzzv_);
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzb_ = context.Operators.Interval(zzzzzzzzzzzzzzzy_, azzzzzzzzzzzzzzza_, true, true);
                bool? azzzzzzzzzzzzzzzc_ = context.Operators.In<CqlDateTime>(zzzzzzzzzzzzzzzu_, azzzzzzzzzzzzzzzb_, default);
                Code<ObservationStatus> azzzzzzzzzzzzzzzd_ = SkinExam?.StatusElement;
                ObservationStatus? azzzzzzzzzzzzzzze_ = azzzzzzzzzzzzzzzd_?.Value;
                Code<ObservationStatus> azzzzzzzzzzzzzzzf_ = context.Operators.Convert<Code<ObservationStatus>>(azzzzzzzzzzzzzzze_);
                string azzzzzzzzzzzzzzzg_ = context.Operators.Convert<string>(azzzzzzzzzzzzzzzf_);
                string[] azzzzzzzzzzzzzzzh_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? azzzzzzzzzzzzzzzi_ = context.Operators.In<string>(azzzzzzzzzzzzzzzg_, azzzzzzzzzzzzzzzh_ as IEnumerable<string>);
                bool? azzzzzzzzzzzzzzzj_ = context.Operators.And(azzzzzzzzzzzzzzzc_, azzzzzzzzzzzzzzzi_);
                DataType azzzzzzzzzzzzzzzk_ = SkinExam?.Value;
                object azzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzk_);
                CqlValueSet azzzzzzzzzzzzzzzm_ = this.Pressure_Injury_Deep_Tissue(context);
                bool? azzzzzzzzzzzzzzzn_ = context.Operators.ConceptInValueSet(azzzzzzzzzzzzzzzl_ as CqlConcept, azzzzzzzzzzzzzzzm_);
                List<Observation.ComponentComponent> azzzzzzzzzzzzzzzo_ = SkinExam?.Component;
                bool? azzzzzzzzzzzzzzzp_(Observation.ComponentComponent @this)
                {
                    CodeableConcept azzzzzzzzzzzzzzzx_ = @this?.Code;
                    CqlConcept azzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, azzzzzzzzzzzzzzzx_);
                    bool? azzzzzzzzzzzzzzzz_ = context.Operators.Not((bool?)(azzzzzzzzzzzzzzzy_ is null));

                    return azzzzzzzzzzzzzzzz_;
                };
                IEnumerable<Observation.ComponentComponent> azzzzzzzzzzzzzzzq_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)azzzzzzzzzzzzzzzo_, azzzzzzzzzzzzzzzp_);
                CqlConcept azzzzzzzzzzzzzzzr_(Observation.ComponentComponent @this)
                {
                    CodeableConcept bzzzzzzzzzzzzzzza_ = @this?.Code;
                    CqlConcept bzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bzzzzzzzzzzzzzzza_);

                    return bzzzzzzzzzzzzzzzb_;
                };
                IEnumerable<CqlConcept> azzzzzzzzzzzzzzzs_ = context.Operators.Select<Observation.ComponentComponent, CqlConcept>(azzzzzzzzzzzzzzzq_, azzzzzzzzzzzzzzzr_);
                bool? azzzzzzzzzzzzzzzu_ = context.Operators.ConceptsInValueSet(azzzzzzzzzzzzzzzs_, azzzzzzzzzzzzzzzm_);
                bool? azzzzzzzzzzzzzzzv_ = context.Operators.Or(azzzzzzzzzzzzzzzn_, azzzzzzzzzzzzzzzu_);
                bool? azzzzzzzzzzzzzzzw_ = context.Operators.And(azzzzzzzzzzzzzzzj_, azzzzzzzzzzzzzzzv_);

                return azzzzzzzzzzzzzzzw_;
            };
            IEnumerable<Observation> zzzzzzzzzzzzzzzo_ = context.Operators.Where<Observation>(zzzzzzzzzzzzzzzm_, zzzzzzzzzzzzzzzn_);
            Encounter zzzzzzzzzzzzzzzp_(Observation SkinExam) =>
                InpatientHospitalization;
            IEnumerable<Encounter> zzzzzzzzzzzzzzzq_ = context.Operators.Select<Observation, Encounter>(zzzzzzzzzzzzzzzo_, zzzzzzzzzzzzzzzp_);

            return zzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Encounter> zzzzzzzzzzzzzzzj_ = context.Operators.SelectMany<Encounter, Encounter>(zzzzzzzzzzzzzzzh_, zzzzzzzzzzzzzzzi_);

        return zzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Encounter with New Deep Tissue Pressure Injury Not POA")]
    public IEnumerable<Encounter> Encounter_with_New_Deep_Tissue_Pressure_Injury_Not_POA(CqlContext context)
    {
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzc_ = this.Encounter_with_New_Deep_Tissue_Pressure_Injury_Not_POA_by_Indicator(context);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzd_ = this.Encounter_with_New_Deep_Tissue_Pressure_Injury_by_Skin_Exam_after_First_72_Hours(context);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzze_ = context.Operators.Union<Encounter>(bzzzzzzzzzzzzzzzc_, bzzzzzzzzzzzzzzzd_);

        return bzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Encounter with New Stage 2, 3, 4 or Unstageable Pressure Injury Not POA by Indicator")]
    public IEnumerable<Encounter> Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_Not_POA_by_Indicator(CqlContext context)
    {
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzf_ = this.Encounter_with_Age_18_and_Older(context);
        bool? bzzzzzzzzzzzzzzzg_(Encounter InpatientHospitalization)
        {
            List<Encounter.DiagnosisComponent> bzzzzzzzzzzzzzzzi_ = InpatientHospitalization?.Diagnosis;
            bool? bzzzzzzzzzzzzzzzj_(Encounter.DiagnosisComponent Stage234UnstageablePressureInjury)
            {
                ResourceReference bzzzzzzzzzzzzzzzm_ = Stage234UnstageablePressureInjury?.Condition;
                Condition bzzzzzzzzzzzzzzzn_ = CQMCommon_2_2_000.Instance.getCondition(context, bzzzzzzzzzzzzzzzm_);
                CodeableConcept bzzzzzzzzzzzzzzzo_ = bzzzzzzzzzzzzzzzn_?.Code;
                CqlConcept bzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bzzzzzzzzzzzzzzzo_);
                CqlValueSet bzzzzzzzzzzzzzzzq_ = this.Pressure_Injury_Stage_2__3__4__or_Unstageable_Diagnoses(context);
                bool? bzzzzzzzzzzzzzzzr_ = context.Operators.ConceptInValueSet(bzzzzzzzzzzzzzzzp_, bzzzzzzzzzzzzzzzq_);
                bool? bzzzzzzzzzzzzzzzs_(Extension @this)
                {
                    string czzzzzzzzzzzzzzzb_ = @this?.Url;
                    FhirString czzzzzzzzzzzzzzzc_ = context.Operators.Convert<FhirString>(czzzzzzzzzzzzzzzb_);
                    string czzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToString(context, czzzzzzzzzzzzzzzc_);
                    bool? czzzzzzzzzzzzzzze_ = context.Operators.Equal(czzzzzzzzzzzzzzzd_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return czzzzzzzzzzzzzzze_;
                };
                IEnumerable<Extension> bzzzzzzzzzzzzzzzt_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Stage234UnstageablePressureInjury is Element
                        ? (Stage234UnstageablePressureInjury as Element).Extension
                        : default), bzzzzzzzzzzzzzzzs_);
                object bzzzzzzzzzzzzzzzu_(Extension @this)
                {
                    DataType czzzzzzzzzzzzzzzf_ = @this?.Value;

                    return czzzzzzzzzzzzzzzf_;
                };
                IEnumerable<object> bzzzzzzzzzzzzzzzv_ = context.Operators.Select<Extension, object>(bzzzzzzzzzzzzzzzt_, bzzzzzzzzzzzzzzzu_);
                object bzzzzzzzzzzzzzzzw_ = context.Operators.SingletonFrom<object>(bzzzzzzzzzzzzzzzv_);
                CqlConcept bzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bzzzzzzzzzzzzzzzw_ as CodeableConcept);
                CqlValueSet bzzzzzzzzzzzzzzzy_ = this.Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine(context);
                bool? bzzzzzzzzzzzzzzzz_ = context.Operators.ConceptInValueSet(bzzzzzzzzzzzzzzzx_, bzzzzzzzzzzzzzzzy_);
                bool? czzzzzzzzzzzzzzza_ = context.Operators.And(bzzzzzzzzzzzzzzzr_, bzzzzzzzzzzzzzzzz_);

                return czzzzzzzzzzzzzzza_;
            };
            IEnumerable<Encounter.DiagnosisComponent> bzzzzzzzzzzzzzzzk_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)bzzzzzzzzzzzzzzzi_, bzzzzzzzzzzzzzzzj_);
            bool? bzzzzzzzzzzzzzzzl_ = context.Operators.Exists<Encounter.DiagnosisComponent>(bzzzzzzzzzzzzzzzk_);

            return bzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzh_ = context.Operators.Where<Encounter>(bzzzzzzzzzzzzzzzf_, bzzzzzzzzzzzzzzzg_);

        return bzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Encounter with New Stage 2, 3, 4 or Unstageable Pressure Injury by Skin Exam after First 24 Hours")]
    public IEnumerable<Encounter> Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_by_Skin_Exam_after_First_24_Hours(CqlContext context)
    {
        IEnumerable<Encounter> czzzzzzzzzzzzzzzg_ = this.Encounter_with_Age_18_and_Older(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzh_(Encounter InpatientHospitalization)
        {
            CqlCode czzzzzzzzzzzzzzzj_ = this.Physical_findings_of_Skin(context);
            IEnumerable<CqlCode> czzzzzzzzzzzzzzzk_ = context.Operators.ToList<CqlCode>(czzzzzzzzzzzzzzzj_);
            IEnumerable<Observation> czzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, czzzzzzzzzzzzzzzk_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            bool? czzzzzzzzzzzzzzzm_(Observation SkinExam)
            {
                DataType czzzzzzzzzzzzzzzq_ = SkinExam?.Effective;
                object czzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzq_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.ToInterval(context, czzzzzzzzzzzzzzzr_);
                CqlDateTime czzzzzzzzzzzzzzzt_ = context.Operators.Start(czzzzzzzzzzzzzzzs_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzu_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, InpatientHospitalization);
                CqlDateTime czzzzzzzzzzzzzzzv_ = context.Operators.Start(czzzzzzzzzzzzzzzu_);
                CqlQuantity czzzzzzzzzzzzzzzw_ = context.Operators.Quantity(24m, "hours");
                CqlDateTime czzzzzzzzzzzzzzzx_ = context.Operators.Add(czzzzzzzzzzzzzzzv_, czzzzzzzzzzzzzzzw_);
                CqlDateTime czzzzzzzzzzzzzzzz_ = context.Operators.End(czzzzzzzzzzzzzzzu_);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzza_ = context.Operators.Interval(czzzzzzzzzzzzzzzx_, czzzzzzzzzzzzzzzz_, true, true);
                bool? dzzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDateTime>(czzzzzzzzzzzzzzzt_, dzzzzzzzzzzzzzzza_, default);
                Code<ObservationStatus> dzzzzzzzzzzzzzzzc_ = SkinExam?.StatusElement;
                ObservationStatus? dzzzzzzzzzzzzzzzd_ = dzzzzzzzzzzzzzzzc_?.Value;
                Code<ObservationStatus> dzzzzzzzzzzzzzzze_ = context.Operators.Convert<Code<ObservationStatus>>(dzzzzzzzzzzzzzzzd_);
                string dzzzzzzzzzzzzzzzf_ = context.Operators.Convert<string>(dzzzzzzzzzzzzzzze_);
                string[] dzzzzzzzzzzzzzzzg_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? dzzzzzzzzzzzzzzzh_ = context.Operators.In<string>(dzzzzzzzzzzzzzzzf_, dzzzzzzzzzzzzzzzg_ as IEnumerable<string>);
                bool? dzzzzzzzzzzzzzzzi_ = context.Operators.And(dzzzzzzzzzzzzzzzb_, dzzzzzzzzzzzzzzzh_);
                DataType dzzzzzzzzzzzzzzzj_ = SkinExam?.Value;
                object dzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzj_);
                CqlValueSet dzzzzzzzzzzzzzzzl_ = this.Pressure_Injury_Stage_2__3__4_or_Unstageable(context);
                bool? dzzzzzzzzzzzzzzzm_ = context.Operators.ConceptInValueSet(dzzzzzzzzzzzzzzzk_ as CqlConcept, dzzzzzzzzzzzzzzzl_);
                List<Observation.ComponentComponent> dzzzzzzzzzzzzzzzn_ = SkinExam?.Component;
                bool? dzzzzzzzzzzzzzzzo_(Observation.ComponentComponent @this)
                {
                    CodeableConcept dzzzzzzzzzzzzzzzw_ = @this?.Code;
                    CqlConcept dzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dzzzzzzzzzzzzzzzw_);
                    bool? dzzzzzzzzzzzzzzzy_ = context.Operators.Not((bool?)(dzzzzzzzzzzzzzzzx_ is null));

                    return dzzzzzzzzzzzzzzzy_;
                };
                IEnumerable<Observation.ComponentComponent> dzzzzzzzzzzzzzzzp_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)dzzzzzzzzzzzzzzzn_, dzzzzzzzzzzzzzzzo_);
                CqlConcept dzzzzzzzzzzzzzzzq_(Observation.ComponentComponent @this)
                {
                    CodeableConcept dzzzzzzzzzzzzzzzz_ = @this?.Code;
                    CqlConcept ezzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dzzzzzzzzzzzzzzzz_);

                    return ezzzzzzzzzzzzzzza_;
                };
                IEnumerable<CqlConcept> dzzzzzzzzzzzzzzzr_ = context.Operators.Select<Observation.ComponentComponent, CqlConcept>(dzzzzzzzzzzzzzzzp_, dzzzzzzzzzzzzzzzq_);
                bool? dzzzzzzzzzzzzzzzt_ = context.Operators.ConceptsInValueSet(dzzzzzzzzzzzzzzzr_, dzzzzzzzzzzzzzzzl_);
                bool? dzzzzzzzzzzzzzzzu_ = context.Operators.Or(dzzzzzzzzzzzzzzzm_, dzzzzzzzzzzzzzzzt_);
                bool? dzzzzzzzzzzzzzzzv_ = context.Operators.And(dzzzzzzzzzzzzzzzi_, dzzzzzzzzzzzzzzzu_);

                return dzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<Observation> czzzzzzzzzzzzzzzn_ = context.Operators.Where<Observation>(czzzzzzzzzzzzzzzl_, czzzzzzzzzzzzzzzm_);
            Encounter czzzzzzzzzzzzzzzo_(Observation SkinExam) =>
                InpatientHospitalization;
            IEnumerable<Encounter> czzzzzzzzzzzzzzzp_ = context.Operators.Select<Observation, Encounter>(czzzzzzzzzzzzzzzn_, czzzzzzzzzzzzzzzo_);

            return czzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Encounter> czzzzzzzzzzzzzzzi_ = context.Operators.SelectMany<Encounter, Encounter>(czzzzzzzzzzzzzzzg_, czzzzzzzzzzzzzzzh_);

        return czzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Encounter with New Stage 2, 3, 4 or Unstageable Pressure Injury Not POA")]
    public IEnumerable<Encounter> Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_Not_POA(CqlContext context)
    {
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzb_ = this.Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_Not_POA_by_Indicator(context);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzc_ = this.Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_by_Skin_Exam_after_First_24_Hours(context);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzd_ = context.Operators.Union<Encounter>(ezzzzzzzzzzzzzzzb_, ezzzzzzzzzzzzzzzc_);

        return ezzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> ezzzzzzzzzzzzzzze_ = this.Encounter_with_New_Deep_Tissue_Pressure_Injury_Not_POA(context);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzf_ = this.Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_Not_POA(context);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzg_ = context.Operators.Union<Encounter>(ezzzzzzzzzzzzzzze_, ezzzzzzzzzzzzzzzf_);

        return ezzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? ezzzzzzzzzzzzzzzh_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return ezzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> ezzzzzzzzzzzzzzzi_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return ezzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? ezzzzzzzzzzzzzzzj_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return ezzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode ezzzzzzzzzzzzzzzk_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return ezzzzzzzzzzzzzzzk_;
    }


    #endregion Expressions

}
