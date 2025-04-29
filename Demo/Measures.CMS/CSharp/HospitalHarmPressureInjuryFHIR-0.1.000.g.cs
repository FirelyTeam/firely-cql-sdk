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
        CqlDateTime czzzzzzzzzzzy_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime czzzzzzzzzzzz_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> dzzzzzzzzzzza_ = context.Operators.Interval(czzzzzzzzzzzy_, czzzzzzzzzzzz_, true, true);
        object dzzzzzzzzzzzb_ = context.ResolveParameter("HospitalHarmPressureInjuryFHIR-0.1.000", "Measurement Period", dzzzzzzzzzzza_);

        return (CqlInterval<CqlDateTime>)dzzzzzzzzzzzb_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> dzzzzzzzzzzzc_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient dzzzzzzzzzzzd_ = context.Operators.SingletonFrom<Patient>(dzzzzzzzzzzzc_);

        return dzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Encounter with Age 18 and Older")]
    public IEnumerable<Encounter> Encounter_with_Age_18_and_Older(CqlContext context)
    {
        CqlValueSet dzzzzzzzzzzze_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> dzzzzzzzzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? dzzzzzzzzzzzg_(Encounter InpatientEncounter)
        {
            Patient dzzzzzzzzzzzi_ = this.Patient(context);
            Date dzzzzzzzzzzzj_ = dzzzzzzzzzzzi_?.BirthDateElement;
            string dzzzzzzzzzzzk_ = dzzzzzzzzzzzj_?.Value;
            CqlDate dzzzzzzzzzzzl_ = context.Operators.ConvertStringToDate(dzzzzzzzzzzzk_);
            Period dzzzzzzzzzzzm_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> dzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzzzzm_);
            CqlDateTime dzzzzzzzzzzzo_ = context.Operators.Start(dzzzzzzzzzzzn_);
            CqlDate dzzzzzzzzzzzp_ = context.Operators.DateFrom(dzzzzzzzzzzzo_);
            int? dzzzzzzzzzzzq_ = context.Operators.CalculateAgeAt(dzzzzzzzzzzzl_, dzzzzzzzzzzzp_, "year");
            bool? dzzzzzzzzzzzr_ = context.Operators.GreaterOrEqual(dzzzzzzzzzzzq_, 18);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzzzzm_);
            CqlDateTime dzzzzzzzzzzzu_ = context.Operators.End(dzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzv_ = this.Measurement_Period(context);
            bool? dzzzzzzzzzzzw_ = context.Operators.In<CqlDateTime>(dzzzzzzzzzzzu_, dzzzzzzzzzzzv_, "day");
            bool? dzzzzzzzzzzzx_ = context.Operators.And(dzzzzzzzzzzzr_, dzzzzzzzzzzzw_);
            Code<Encounter.EncounterStatus> dzzzzzzzzzzzy_ = InpatientEncounter?.StatusElement;
            Encounter.EncounterStatus? dzzzzzzzzzzzz_ = dzzzzzzzzzzzy_?.Value;
            Code<Encounter.EncounterStatus> ezzzzzzzzzzza_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(dzzzzzzzzzzzz_);
            bool? ezzzzzzzzzzzb_ = context.Operators.Equal(ezzzzzzzzzzza_, "finished");
            bool? ezzzzzzzzzzzc_ = context.Operators.And(dzzzzzzzzzzzx_, ezzzzzzzzzzzb_);

            return ezzzzzzzzzzzc_;
        };
        IEnumerable<Encounter> dzzzzzzzzzzzh_ = context.Operators.Where<Encounter>(dzzzzzzzzzzzf_, dzzzzzzzzzzzg_);

        return dzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> ezzzzzzzzzzzd_ = this.Encounter_with_Age_18_and_Older(context);

        return ezzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> ezzzzzzzzzzze_ = this.Initial_Population(context);

        return ezzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Encounter with Deep Tissue Pressure Injury POA by Indicator")]
    public IEnumerable<Encounter> Encounter_with_Deep_Tissue_Pressure_Injury_POA_by_Indicator(CqlContext context)
    {
        IEnumerable<Encounter> ezzzzzzzzzzzf_ = this.Encounter_with_Age_18_and_Older(context);
        bool? ezzzzzzzzzzzg_(Encounter InpatientHospitalization)
        {
            List<Encounter.DiagnosisComponent> ezzzzzzzzzzzi_ = InpatientHospitalization?.Diagnosis;
            bool? ezzzzzzzzzzzj_(Encounter.DiagnosisComponent EncounterDiag)
            {
                ResourceReference ezzzzzzzzzzzm_ = EncounterDiag?.Condition;
                Condition ezzzzzzzzzzzn_ = CQMCommon_2_2_000.Instance.getCondition(context, ezzzzzzzzzzzm_);
                CodeableConcept ezzzzzzzzzzzo_ = ezzzzzzzzzzzn_?.Code;
                CqlConcept ezzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ezzzzzzzzzzzo_);
                CqlValueSet ezzzzzzzzzzzq_ = this.Pressure_Injury_Deep_Tissue_Diagnoses(context);
                bool? ezzzzzzzzzzzr_ = context.Operators.ConceptInValueSet(ezzzzzzzzzzzp_, ezzzzzzzzzzzq_);
                bool? ezzzzzzzzzzzs_(Extension @this)
                {
                    string fzzzzzzzzzzzb_ = @this?.Url;
                    FhirString fzzzzzzzzzzzc_ = context.Operators.Convert<FhirString>(fzzzzzzzzzzzb_);
                    string fzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToString(context, fzzzzzzzzzzzc_);
                    bool? fzzzzzzzzzzze_ = context.Operators.Equal(fzzzzzzzzzzzd_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return fzzzzzzzzzzze_;
                };
                IEnumerable<Extension> ezzzzzzzzzzzt_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(EncounterDiag is Element
                        ? (EncounterDiag as Element).Extension
                        : default), ezzzzzzzzzzzs_);
                object ezzzzzzzzzzzu_(Extension @this)
                {
                    DataType fzzzzzzzzzzzf_ = @this?.Value;

                    return fzzzzzzzzzzzf_;
                };
                IEnumerable<object> ezzzzzzzzzzzv_ = context.Operators.Select<Extension, object>(ezzzzzzzzzzzt_, ezzzzzzzzzzzu_);
                object ezzzzzzzzzzzw_ = context.Operators.SingletonFrom<object>(ezzzzzzzzzzzv_);
                CqlConcept ezzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ezzzzzzzzzzzw_ as CodeableConcept);
                CqlValueSet ezzzzzzzzzzzy_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? ezzzzzzzzzzzz_ = context.Operators.ConceptInValueSet(ezzzzzzzzzzzx_, ezzzzzzzzzzzy_);
                bool? fzzzzzzzzzzza_ = context.Operators.And(ezzzzzzzzzzzr_, ezzzzzzzzzzzz_);

                return fzzzzzzzzzzza_;
            };
            IEnumerable<Encounter.DiagnosisComponent> ezzzzzzzzzzzk_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)ezzzzzzzzzzzi_, ezzzzzzzzzzzj_);
            bool? ezzzzzzzzzzzl_ = context.Operators.Exists<Encounter.DiagnosisComponent>(ezzzzzzzzzzzk_);

            return ezzzzzzzzzzzl_;
        };
        IEnumerable<Encounter> ezzzzzzzzzzzh_ = context.Operators.Where<Encounter>(ezzzzzzzzzzzf_, ezzzzzzzzzzzg_);

        return ezzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Encounter with Deep Tissue Pressure Injury POA by Skin Exam within First 72 Hours")]
    public IEnumerable<Encounter> Encounter_with_Deep_Tissue_Pressure_Injury_POA_by_Skin_Exam_within_First_72_Hours(CqlContext context)
    {
        IEnumerable<Encounter> fzzzzzzzzzzzg_ = this.Encounter_with_Age_18_and_Older(context);
        IEnumerable<Encounter> fzzzzzzzzzzzh_(Encounter InpatientHospitalization)
        {
            CqlCode fzzzzzzzzzzzj_ = this.Physical_findings_of_Skin(context);
            IEnumerable<CqlCode> fzzzzzzzzzzzk_ = context.Operators.ToList<CqlCode>(fzzzzzzzzzzzj_);
            IEnumerable<Observation> fzzzzzzzzzzzl_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, fzzzzzzzzzzzk_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            bool? fzzzzzzzzzzzm_(Observation SkinExam)
            {
                DataType fzzzzzzzzzzzq_ = SkinExam?.Effective;
                object fzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzq_);
                CqlInterval<CqlDateTime> fzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.ToInterval(context, fzzzzzzzzzzzr_);
                CqlDateTime fzzzzzzzzzzzt_ = context.Operators.Start(fzzzzzzzzzzzs_);
                CqlInterval<CqlDateTime> fzzzzzzzzzzzu_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, InpatientHospitalization);
                CqlDateTime fzzzzzzzzzzzv_ = context.Operators.Start(fzzzzzzzzzzzu_);
                CqlDateTime fzzzzzzzzzzzx_ = context.Operators.Start(fzzzzzzzzzzzu_);
                CqlQuantity fzzzzzzzzzzzy_ = context.Operators.Quantity(72m, "hours");
                CqlDateTime fzzzzzzzzzzzz_ = context.Operators.Add(fzzzzzzzzzzzx_, fzzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzza_ = context.Operators.Interval(fzzzzzzzzzzzv_, fzzzzzzzzzzzz_, true, true);
                bool? gzzzzzzzzzzzb_ = context.Operators.In<CqlDateTime>(fzzzzzzzzzzzt_, gzzzzzzzzzzza_, default);
                Code<ObservationStatus> gzzzzzzzzzzzc_ = SkinExam?.StatusElement;
                ObservationStatus? gzzzzzzzzzzzd_ = gzzzzzzzzzzzc_?.Value;
                Code<ObservationStatus> gzzzzzzzzzzze_ = context.Operators.Convert<Code<ObservationStatus>>(gzzzzzzzzzzzd_);
                string gzzzzzzzzzzzf_ = context.Operators.Convert<string>(gzzzzzzzzzzze_);
                string[] gzzzzzzzzzzzg_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? gzzzzzzzzzzzh_ = context.Operators.In<string>(gzzzzzzzzzzzf_, gzzzzzzzzzzzg_ as IEnumerable<string>);
                bool? gzzzzzzzzzzzi_ = context.Operators.And(gzzzzzzzzzzzb_, gzzzzzzzzzzzh_);
                CodeableConcept gzzzzzzzzzzzj_ = SkinExam?.Code;
                CqlConcept gzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, gzzzzzzzzzzzj_);
                CqlValueSet gzzzzzzzzzzzl_ = this.Pressure_Injury_Deep_Tissue(context);
                bool? gzzzzzzzzzzzm_ = context.Operators.ConceptInValueSet(gzzzzzzzzzzzk_, gzzzzzzzzzzzl_);
                bool? gzzzzzzzzzzzn_ = context.Operators.And(gzzzzzzzzzzzi_, gzzzzzzzzzzzm_);

                return gzzzzzzzzzzzn_;
            };
            IEnumerable<Observation> fzzzzzzzzzzzn_ = context.Operators.Where<Observation>(fzzzzzzzzzzzl_, fzzzzzzzzzzzm_);
            Encounter fzzzzzzzzzzzo_(Observation SkinExam) =>
                InpatientHospitalization;
            IEnumerable<Encounter> fzzzzzzzzzzzp_ = context.Operators.Select<Observation, Encounter>(fzzzzzzzzzzzn_, fzzzzzzzzzzzo_);

            return fzzzzzzzzzzzp_;
        };
        IEnumerable<Encounter> fzzzzzzzzzzzi_ = context.Operators.SelectMany<Encounter, Encounter>(fzzzzzzzzzzzg_, fzzzzzzzzzzzh_);

        return fzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Encounter with Deep Tissue Pressure Injury POA")]
    public IEnumerable<Encounter> Encounter_with_Deep_Tissue_Pressure_Injury_POA(CqlContext context)
    {
        IEnumerable<Encounter> gzzzzzzzzzzzo_ = this.Encounter_with_Deep_Tissue_Pressure_Injury_POA_by_Indicator(context);
        IEnumerable<Encounter> gzzzzzzzzzzzp_ = this.Encounter_with_Deep_Tissue_Pressure_Injury_POA_by_Skin_Exam_within_First_72_Hours(context);
        IEnumerable<Encounter> gzzzzzzzzzzzq_ = context.Operators.Union<Encounter>(gzzzzzzzzzzzo_, gzzzzzzzzzzzp_);

        return gzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Encounter with Stage 2, 3, 4, or Unstageable Pressure Injury Present on Admission by POA Indicator")]
    public IEnumerable<Encounter> Encounter_with_Stage_2__3__4__or_Unstageable_Pressure_Injury_Present_on_Admission_by_POA_Indicator(CqlContext context)
    {
        IEnumerable<Encounter> gzzzzzzzzzzzr_ = this.Encounter_with_Age_18_and_Older(context);
        bool? gzzzzzzzzzzzs_(Encounter InpatientHospitalization)
        {
            List<Encounter.DiagnosisComponent> gzzzzzzzzzzzu_ = InpatientHospitalization?.Diagnosis;
            bool? gzzzzzzzzzzzv_(Encounter.DiagnosisComponent Stage234UnstageablePressureInjury)
            {
                ResourceReference gzzzzzzzzzzzy_ = Stage234UnstageablePressureInjury?.Condition;
                Condition gzzzzzzzzzzzz_ = CQMCommon_2_2_000.Instance.getCondition(context, gzzzzzzzzzzzy_);
                CodeableConcept hzzzzzzzzzzza_ = gzzzzzzzzzzzz_?.Code;
                CqlConcept hzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, hzzzzzzzzzzza_);
                CqlValueSet hzzzzzzzzzzzc_ = this.Pressure_Injury_Stage_2__3__4__or_Unstageable_Diagnoses(context);
                bool? hzzzzzzzzzzzd_ = context.Operators.ConceptInValueSet(hzzzzzzzzzzzb_, hzzzzzzzzzzzc_);
                bool? hzzzzzzzzzzze_(Extension @this)
                {
                    string hzzzzzzzzzzzn_ = @this?.Url;
                    FhirString hzzzzzzzzzzzo_ = context.Operators.Convert<FhirString>(hzzzzzzzzzzzn_);
                    string hzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToString(context, hzzzzzzzzzzzo_);
                    bool? hzzzzzzzzzzzq_ = context.Operators.Equal(hzzzzzzzzzzzp_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return hzzzzzzzzzzzq_;
                };
                IEnumerable<Extension> hzzzzzzzzzzzf_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Stage234UnstageablePressureInjury is Element
                        ? (Stage234UnstageablePressureInjury as Element).Extension
                        : default), hzzzzzzzzzzze_);
                object hzzzzzzzzzzzg_(Extension @this)
                {
                    DataType hzzzzzzzzzzzr_ = @this?.Value;

                    return hzzzzzzzzzzzr_;
                };
                IEnumerable<object> hzzzzzzzzzzzh_ = context.Operators.Select<Extension, object>(hzzzzzzzzzzzf_, hzzzzzzzzzzzg_);
                object hzzzzzzzzzzzi_ = context.Operators.SingletonFrom<object>(hzzzzzzzzzzzh_);
                CqlConcept hzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, hzzzzzzzzzzzi_ as CodeableConcept);
                CqlValueSet hzzzzzzzzzzzk_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? hzzzzzzzzzzzl_ = context.Operators.ConceptInValueSet(hzzzzzzzzzzzj_, hzzzzzzzzzzzk_);
                bool? hzzzzzzzzzzzm_ = context.Operators.And(hzzzzzzzzzzzd_, hzzzzzzzzzzzl_);

                return hzzzzzzzzzzzm_;
            };
            IEnumerable<Encounter.DiagnosisComponent> gzzzzzzzzzzzw_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)gzzzzzzzzzzzu_, gzzzzzzzzzzzv_);
            bool? gzzzzzzzzzzzx_ = context.Operators.Exists<Encounter.DiagnosisComponent>(gzzzzzzzzzzzw_);

            return gzzzzzzzzzzzx_;
        };
        IEnumerable<Encounter> gzzzzzzzzzzzt_ = context.Operators.Where<Encounter>(gzzzzzzzzzzzr_, gzzzzzzzzzzzs_);

        return gzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Encounter with Stage 2, 3, 4 or Unstageable Pressure Injury POA by Skin Exam within 24 Hours")]
    public IEnumerable<Encounter> Encounter_with_Stage_2__3__4_or_Unstageable_Pressure_Injury_POA_by_Skin_Exam_within_24_Hours(CqlContext context)
    {
        IEnumerable<Encounter> hzzzzzzzzzzzs_ = this.Encounter_with_Age_18_and_Older(context);
        IEnumerable<Encounter> hzzzzzzzzzzzt_(Encounter InpatientHospitalization)
        {
            CqlCode hzzzzzzzzzzzv_ = this.Physical_findings_of_Skin(context);
            IEnumerable<CqlCode> hzzzzzzzzzzzw_ = context.Operators.ToList<CqlCode>(hzzzzzzzzzzzv_);
            IEnumerable<Observation> hzzzzzzzzzzzx_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, hzzzzzzzzzzzw_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            bool? hzzzzzzzzzzzy_(Observation SkinExam)
            {
                DataType izzzzzzzzzzzc_ = SkinExam?.Effective;
                object izzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzc_);
                CqlInterval<CqlDateTime> izzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.ToInterval(context, izzzzzzzzzzzd_);
                CqlDateTime izzzzzzzzzzzf_ = context.Operators.Start(izzzzzzzzzzze_);
                CqlInterval<CqlDateTime> izzzzzzzzzzzg_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, InpatientHospitalization);
                CqlDateTime izzzzzzzzzzzh_ = context.Operators.Start(izzzzzzzzzzzg_);
                CqlDateTime izzzzzzzzzzzj_ = context.Operators.Start(izzzzzzzzzzzg_);
                CqlQuantity izzzzzzzzzzzk_ = context.Operators.Quantity(24m, "hours");
                CqlDateTime izzzzzzzzzzzl_ = context.Operators.Add(izzzzzzzzzzzj_, izzzzzzzzzzzk_);
                CqlInterval<CqlDateTime> izzzzzzzzzzzm_ = context.Operators.Interval(izzzzzzzzzzzh_, izzzzzzzzzzzl_, true, true);
                bool? izzzzzzzzzzzn_ = context.Operators.In<CqlDateTime>(izzzzzzzzzzzf_, izzzzzzzzzzzm_, default);
                Code<ObservationStatus> izzzzzzzzzzzo_ = SkinExam?.StatusElement;
                ObservationStatus? izzzzzzzzzzzp_ = izzzzzzzzzzzo_?.Value;
                Code<ObservationStatus> izzzzzzzzzzzq_ = context.Operators.Convert<Code<ObservationStatus>>(izzzzzzzzzzzp_);
                string izzzzzzzzzzzr_ = context.Operators.Convert<string>(izzzzzzzzzzzq_);
                string[] izzzzzzzzzzzs_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? izzzzzzzzzzzt_ = context.Operators.In<string>(izzzzzzzzzzzr_, izzzzzzzzzzzs_ as IEnumerable<string>);
                bool? izzzzzzzzzzzu_ = context.Operators.And(izzzzzzzzzzzn_, izzzzzzzzzzzt_);
                CodeableConcept izzzzzzzzzzzv_ = SkinExam?.Code;
                CqlConcept izzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, izzzzzzzzzzzv_);
                CqlValueSet izzzzzzzzzzzx_ = this.Pressure_Injury_Stage_2__3__4_or_Unstageable(context);
                bool? izzzzzzzzzzzy_ = context.Operators.ConceptInValueSet(izzzzzzzzzzzw_, izzzzzzzzzzzx_);
                bool? izzzzzzzzzzzz_ = context.Operators.And(izzzzzzzzzzzu_, izzzzzzzzzzzy_);

                return izzzzzzzzzzzz_;
            };
            IEnumerable<Observation> hzzzzzzzzzzzz_ = context.Operators.Where<Observation>(hzzzzzzzzzzzx_, hzzzzzzzzzzzy_);
            Encounter izzzzzzzzzzza_(Observation SkinExam) =>
                InpatientHospitalization;
            IEnumerable<Encounter> izzzzzzzzzzzb_ = context.Operators.Select<Observation, Encounter>(hzzzzzzzzzzzz_, izzzzzzzzzzza_);

            return izzzzzzzzzzzb_;
        };
        IEnumerable<Encounter> hzzzzzzzzzzzu_ = context.Operators.SelectMany<Encounter, Encounter>(hzzzzzzzzzzzs_, hzzzzzzzzzzzt_);

        return hzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Encounter with Stage 2, 3, 4 or Unstageable Pressure Injury POA")]
    public IEnumerable<Encounter> Encounter_with_Stage_2__3__4_or_Unstageable_Pressure_Injury_POA(CqlContext context)
    {
        IEnumerable<Encounter> jzzzzzzzzzzza_ = this.Encounter_with_Stage_2__3__4__or_Unstageable_Pressure_Injury_Present_on_Admission_by_POA_Indicator(context);
        IEnumerable<Encounter> jzzzzzzzzzzzb_ = this.Encounter_with_Stage_2__3__4_or_Unstageable_Pressure_Injury_POA_by_Skin_Exam_within_24_Hours(context);
        IEnumerable<Encounter> jzzzzzzzzzzzc_ = context.Operators.Union<Encounter>(jzzzzzzzzzzza_, jzzzzzzzzzzzb_);

        return jzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Encounter with Diagnosis of COVID19 Infection")]
    public IEnumerable<Encounter> Encounter_with_Diagnosis_of_COVID19_Infection(CqlContext context)
    {
        IEnumerable<Encounter> jzzzzzzzzzzzd_ = this.Encounter_with_Age_18_and_Older(context);
        bool? jzzzzzzzzzzze_(Encounter InpatientHospitalization)
        {
            IEnumerable<Condition> jzzzzzzzzzzzg_ = CQMCommon_2_2_000.Instance.EncounterDiagnosis(context, InpatientHospitalization);
            bool? jzzzzzzzzzzzh_(Condition EncounterDiag)
            {
                CodeableConcept jzzzzzzzzzzzk_ = EncounterDiag?.Code;
                CqlConcept jzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, jzzzzzzzzzzzk_);
                CqlValueSet jzzzzzzzzzzzm_ = this.COVID_19(context);
                bool? jzzzzzzzzzzzn_ = context.Operators.ConceptInValueSet(jzzzzzzzzzzzl_, jzzzzzzzzzzzm_);

                return jzzzzzzzzzzzn_;
            };
            IEnumerable<Condition> jzzzzzzzzzzzi_ = context.Operators.Where<Condition>(jzzzzzzzzzzzg_, jzzzzzzzzzzzh_);
            bool? jzzzzzzzzzzzj_ = context.Operators.Exists<Condition>(jzzzzzzzzzzzi_);

            return jzzzzzzzzzzzj_;
        };
        IEnumerable<Encounter> jzzzzzzzzzzzf_ = context.Operators.Where<Encounter>(jzzzzzzzzzzzd_, jzzzzzzzzzzze_);

        return jzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context)
    {
        IEnumerable<Encounter> jzzzzzzzzzzzo_ = this.Encounter_with_Deep_Tissue_Pressure_Injury_POA(context);
        IEnumerable<Encounter> jzzzzzzzzzzzp_ = this.Encounter_with_Stage_2__3__4_or_Unstageable_Pressure_Injury_POA(context);
        IEnumerable<Encounter> jzzzzzzzzzzzq_ = context.Operators.Union<Encounter>(jzzzzzzzzzzzo_, jzzzzzzzzzzzp_);
        IEnumerable<Encounter> jzzzzzzzzzzzr_ = this.Encounter_with_Diagnosis_of_COVID19_Infection(context);
        IEnumerable<Encounter> jzzzzzzzzzzzs_ = context.Operators.Union<Encounter>(jzzzzzzzzzzzq_, jzzzzzzzzzzzr_);

        return jzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Encounter with New Deep Tissue Pressure Injury Not POA by Indicator")]
    public IEnumerable<Encounter> Encounter_with_New_Deep_Tissue_Pressure_Injury_Not_POA_by_Indicator(CqlContext context)
    {
        IEnumerable<Encounter> jzzzzzzzzzzzt_ = this.Encounter_with_Age_18_and_Older(context);
        bool? jzzzzzzzzzzzu_(Encounter InpatientHospitalization)
        {
            List<Encounter.DiagnosisComponent> jzzzzzzzzzzzw_ = InpatientHospitalization?.Diagnosis;
            bool? jzzzzzzzzzzzx_(Encounter.DiagnosisComponent EncounterDiag)
            {
                ResourceReference kzzzzzzzzzzza_ = EncounterDiag?.Condition;
                Condition kzzzzzzzzzzzb_ = CQMCommon_2_2_000.Instance.getCondition(context, kzzzzzzzzzzza_);
                CodeableConcept kzzzzzzzzzzzc_ = kzzzzzzzzzzzb_?.Code;
                CqlConcept kzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, kzzzzzzzzzzzc_);
                CqlValueSet kzzzzzzzzzzze_ = this.Pressure_Injury_Deep_Tissue_Diagnoses(context);
                bool? kzzzzzzzzzzzf_ = context.Operators.ConceptInValueSet(kzzzzzzzzzzzd_, kzzzzzzzzzzze_);
                bool? kzzzzzzzzzzzg_(Extension @this)
                {
                    string kzzzzzzzzzzzp_ = @this?.Url;
                    FhirString kzzzzzzzzzzzq_ = context.Operators.Convert<FhirString>(kzzzzzzzzzzzp_);
                    string kzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToString(context, kzzzzzzzzzzzq_);
                    bool? kzzzzzzzzzzzs_ = context.Operators.Equal(kzzzzzzzzzzzr_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return kzzzzzzzzzzzs_;
                };
                IEnumerable<Extension> kzzzzzzzzzzzh_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(EncounterDiag is Element
                        ? (EncounterDiag as Element).Extension
                        : default), kzzzzzzzzzzzg_);
                object kzzzzzzzzzzzi_(Extension @this)
                {
                    DataType kzzzzzzzzzzzt_ = @this?.Value;

                    return kzzzzzzzzzzzt_;
                };
                IEnumerable<object> kzzzzzzzzzzzj_ = context.Operators.Select<Extension, object>(kzzzzzzzzzzzh_, kzzzzzzzzzzzi_);
                object kzzzzzzzzzzzk_ = context.Operators.SingletonFrom<object>(kzzzzzzzzzzzj_);
                CqlConcept kzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, kzzzzzzzzzzzk_ as CodeableConcept);
                CqlValueSet kzzzzzzzzzzzm_ = this.Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine(context);
                bool? kzzzzzzzzzzzn_ = context.Operators.ConceptInValueSet(kzzzzzzzzzzzl_, kzzzzzzzzzzzm_);
                bool? kzzzzzzzzzzzo_ = context.Operators.And(kzzzzzzzzzzzf_, kzzzzzzzzzzzn_);

                return kzzzzzzzzzzzo_;
            };
            IEnumerable<Encounter.DiagnosisComponent> jzzzzzzzzzzzy_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)jzzzzzzzzzzzw_, jzzzzzzzzzzzx_);
            bool? jzzzzzzzzzzzz_ = context.Operators.Exists<Encounter.DiagnosisComponent>(jzzzzzzzzzzzy_);

            return jzzzzzzzzzzzz_;
        };
        IEnumerable<Encounter> jzzzzzzzzzzzv_ = context.Operators.Where<Encounter>(jzzzzzzzzzzzt_, jzzzzzzzzzzzu_);

        return jzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Encounter with New Deep Tissue Pressure Injury by Skin Exam after First 72 Hours")]
    public IEnumerable<Encounter> Encounter_with_New_Deep_Tissue_Pressure_Injury_by_Skin_Exam_after_First_72_Hours(CqlContext context)
    {
        IEnumerable<Encounter> kzzzzzzzzzzzu_ = this.Encounter_with_Age_18_and_Older(context);
        IEnumerable<Encounter> kzzzzzzzzzzzv_(Encounter InpatientHospitalization)
        {
            CqlCode kzzzzzzzzzzzx_ = this.Physical_findings_of_Skin(context);
            IEnumerable<CqlCode> kzzzzzzzzzzzy_ = context.Operators.ToList<CqlCode>(kzzzzzzzzzzzx_);
            IEnumerable<Observation> kzzzzzzzzzzzz_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, kzzzzzzzzzzzy_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            bool? lzzzzzzzzzzza_(Observation SkinExam)
            {
                DataType lzzzzzzzzzzze_ = SkinExam?.Effective;
                object lzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzze_);
                CqlInterval<CqlDateTime> lzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.ToInterval(context, lzzzzzzzzzzzf_);
                CqlDateTime lzzzzzzzzzzzh_ = context.Operators.Start(lzzzzzzzzzzzg_);
                CqlInterval<CqlDateTime> lzzzzzzzzzzzi_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, InpatientHospitalization);
                CqlDateTime lzzzzzzzzzzzj_ = context.Operators.Start(lzzzzzzzzzzzi_);
                CqlQuantity lzzzzzzzzzzzk_ = context.Operators.Quantity(72m, "hours");
                CqlDateTime lzzzzzzzzzzzl_ = context.Operators.Add(lzzzzzzzzzzzj_, lzzzzzzzzzzzk_);
                CqlDateTime lzzzzzzzzzzzn_ = context.Operators.End(lzzzzzzzzzzzi_);
                CqlInterval<CqlDateTime> lzzzzzzzzzzzo_ = context.Operators.Interval(lzzzzzzzzzzzl_, lzzzzzzzzzzzn_, true, true);
                bool? lzzzzzzzzzzzp_ = context.Operators.In<CqlDateTime>(lzzzzzzzzzzzh_, lzzzzzzzzzzzo_, default);
                Code<ObservationStatus> lzzzzzzzzzzzq_ = SkinExam?.StatusElement;
                ObservationStatus? lzzzzzzzzzzzr_ = lzzzzzzzzzzzq_?.Value;
                Code<ObservationStatus> lzzzzzzzzzzzs_ = context.Operators.Convert<Code<ObservationStatus>>(lzzzzzzzzzzzr_);
                string lzzzzzzzzzzzt_ = context.Operators.Convert<string>(lzzzzzzzzzzzs_);
                string[] lzzzzzzzzzzzu_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? lzzzzzzzzzzzv_ = context.Operators.In<string>(lzzzzzzzzzzzt_, lzzzzzzzzzzzu_ as IEnumerable<string>);
                bool? lzzzzzzzzzzzw_ = context.Operators.And(lzzzzzzzzzzzp_, lzzzzzzzzzzzv_);
                DataType lzzzzzzzzzzzx_ = SkinExam?.Value;
                object lzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzx_);
                CqlValueSet lzzzzzzzzzzzz_ = this.Pressure_Injury_Deep_Tissue(context);
                bool? mzzzzzzzzzzza_ = context.Operators.ConceptInValueSet(lzzzzzzzzzzzy_ as CqlConcept, lzzzzzzzzzzzz_);
                List<Observation.ComponentComponent> mzzzzzzzzzzzb_ = SkinExam?.Component;
                bool? mzzzzzzzzzzzc_(Observation.ComponentComponent @this)
                {
                    CodeableConcept mzzzzzzzzzzzk_ = @this?.Code;
                    CqlConcept mzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, mzzzzzzzzzzzk_);
                    bool? mzzzzzzzzzzzm_ = context.Operators.Not((bool?)(mzzzzzzzzzzzl_ is null));

                    return mzzzzzzzzzzzm_;
                };
                IEnumerable<Observation.ComponentComponent> mzzzzzzzzzzzd_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)mzzzzzzzzzzzb_, mzzzzzzzzzzzc_);
                CqlConcept mzzzzzzzzzzze_(Observation.ComponentComponent @this)
                {
                    CodeableConcept mzzzzzzzzzzzn_ = @this?.Code;
                    CqlConcept mzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, mzzzzzzzzzzzn_);

                    return mzzzzzzzzzzzo_;
                };
                IEnumerable<CqlConcept> mzzzzzzzzzzzf_ = context.Operators.Select<Observation.ComponentComponent, CqlConcept>(mzzzzzzzzzzzd_, mzzzzzzzzzzze_);
                bool? mzzzzzzzzzzzh_ = context.Operators.ConceptsInValueSet(mzzzzzzzzzzzf_, lzzzzzzzzzzzz_);
                bool? mzzzzzzzzzzzi_ = context.Operators.Or(mzzzzzzzzzzza_, mzzzzzzzzzzzh_);
                bool? mzzzzzzzzzzzj_ = context.Operators.And(lzzzzzzzzzzzw_, mzzzzzzzzzzzi_);

                return mzzzzzzzzzzzj_;
            };
            IEnumerable<Observation> lzzzzzzzzzzzb_ = context.Operators.Where<Observation>(kzzzzzzzzzzzz_, lzzzzzzzzzzza_);
            Encounter lzzzzzzzzzzzc_(Observation SkinExam) =>
                InpatientHospitalization;
            IEnumerable<Encounter> lzzzzzzzzzzzd_ = context.Operators.Select<Observation, Encounter>(lzzzzzzzzzzzb_, lzzzzzzzzzzzc_);

            return lzzzzzzzzzzzd_;
        };
        IEnumerable<Encounter> kzzzzzzzzzzzw_ = context.Operators.SelectMany<Encounter, Encounter>(kzzzzzzzzzzzu_, kzzzzzzzzzzzv_);

        return kzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Encounter with New Deep Tissue Pressure Injury Not POA")]
    public IEnumerable<Encounter> Encounter_with_New_Deep_Tissue_Pressure_Injury_Not_POA(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzzzzzzp_ = this.Encounter_with_New_Deep_Tissue_Pressure_Injury_Not_POA_by_Indicator(context);
        IEnumerable<Encounter> mzzzzzzzzzzzq_ = this.Encounter_with_New_Deep_Tissue_Pressure_Injury_by_Skin_Exam_after_First_72_Hours(context);
        IEnumerable<Encounter> mzzzzzzzzzzzr_ = context.Operators.Union<Encounter>(mzzzzzzzzzzzp_, mzzzzzzzzzzzq_);

        return mzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Encounter with New Stage 2, 3, 4 or Unstageable Pressure Injury Not POA by Indicator")]
    public IEnumerable<Encounter> Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_Not_POA_by_Indicator(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzzzzzzs_ = this.Encounter_with_Age_18_and_Older(context);
        bool? mzzzzzzzzzzzt_(Encounter InpatientHospitalization)
        {
            List<Encounter.DiagnosisComponent> mzzzzzzzzzzzv_ = InpatientHospitalization?.Diagnosis;
            bool? mzzzzzzzzzzzw_(Encounter.DiagnosisComponent Stage234UnstageablePressureInjury)
            {
                ResourceReference mzzzzzzzzzzzz_ = Stage234UnstageablePressureInjury?.Condition;
                Condition nzzzzzzzzzzza_ = CQMCommon_2_2_000.Instance.getCondition(context, mzzzzzzzzzzzz_);
                CodeableConcept nzzzzzzzzzzzb_ = nzzzzzzzzzzza_?.Code;
                CqlConcept nzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, nzzzzzzzzzzzb_);
                CqlValueSet nzzzzzzzzzzzd_ = this.Pressure_Injury_Stage_2__3__4__or_Unstageable_Diagnoses(context);
                bool? nzzzzzzzzzzze_ = context.Operators.ConceptInValueSet(nzzzzzzzzzzzc_, nzzzzzzzzzzzd_);
                bool? nzzzzzzzzzzzf_(Extension @this)
                {
                    string nzzzzzzzzzzzo_ = @this?.Url;
                    FhirString nzzzzzzzzzzzp_ = context.Operators.Convert<FhirString>(nzzzzzzzzzzzo_);
                    string nzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToString(context, nzzzzzzzzzzzp_);
                    bool? nzzzzzzzzzzzr_ = context.Operators.Equal(nzzzzzzzzzzzq_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return nzzzzzzzzzzzr_;
                };
                IEnumerable<Extension> nzzzzzzzzzzzg_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Stage234UnstageablePressureInjury is Element
                        ? (Stage234UnstageablePressureInjury as Element).Extension
                        : default), nzzzzzzzzzzzf_);
                object nzzzzzzzzzzzh_(Extension @this)
                {
                    DataType nzzzzzzzzzzzs_ = @this?.Value;

                    return nzzzzzzzzzzzs_;
                };
                IEnumerable<object> nzzzzzzzzzzzi_ = context.Operators.Select<Extension, object>(nzzzzzzzzzzzg_, nzzzzzzzzzzzh_);
                object nzzzzzzzzzzzj_ = context.Operators.SingletonFrom<object>(nzzzzzzzzzzzi_);
                CqlConcept nzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, nzzzzzzzzzzzj_ as CodeableConcept);
                CqlValueSet nzzzzzzzzzzzl_ = this.Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine(context);
                bool? nzzzzzzzzzzzm_ = context.Operators.ConceptInValueSet(nzzzzzzzzzzzk_, nzzzzzzzzzzzl_);
                bool? nzzzzzzzzzzzn_ = context.Operators.And(nzzzzzzzzzzze_, nzzzzzzzzzzzm_);

                return nzzzzzzzzzzzn_;
            };
            IEnumerable<Encounter.DiagnosisComponent> mzzzzzzzzzzzx_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)mzzzzzzzzzzzv_, mzzzzzzzzzzzw_);
            bool? mzzzzzzzzzzzy_ = context.Operators.Exists<Encounter.DiagnosisComponent>(mzzzzzzzzzzzx_);

            return mzzzzzzzzzzzy_;
        };
        IEnumerable<Encounter> mzzzzzzzzzzzu_ = context.Operators.Where<Encounter>(mzzzzzzzzzzzs_, mzzzzzzzzzzzt_);

        return mzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Encounter with New Stage 2, 3, 4 or Unstageable Pressure Injury by Skin Exam after First 24 Hours")]
    public IEnumerable<Encounter> Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_by_Skin_Exam_after_First_24_Hours(CqlContext context)
    {
        IEnumerable<Encounter> nzzzzzzzzzzzt_ = this.Encounter_with_Age_18_and_Older(context);
        IEnumerable<Encounter> nzzzzzzzzzzzu_(Encounter InpatientHospitalization)
        {
            CqlCode nzzzzzzzzzzzw_ = this.Physical_findings_of_Skin(context);
            IEnumerable<CqlCode> nzzzzzzzzzzzx_ = context.Operators.ToList<CqlCode>(nzzzzzzzzzzzw_);
            IEnumerable<Observation> nzzzzzzzzzzzy_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, nzzzzzzzzzzzx_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            bool? nzzzzzzzzzzzz_(Observation SkinExam)
            {
                DataType ozzzzzzzzzzzd_ = SkinExam?.Effective;
                object ozzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzd_);
                CqlInterval<CqlDateTime> ozzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.ToInterval(context, ozzzzzzzzzzze_);
                CqlDateTime ozzzzzzzzzzzg_ = context.Operators.Start(ozzzzzzzzzzzf_);
                CqlInterval<CqlDateTime> ozzzzzzzzzzzh_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, InpatientHospitalization);
                CqlDateTime ozzzzzzzzzzzi_ = context.Operators.Start(ozzzzzzzzzzzh_);
                CqlQuantity ozzzzzzzzzzzj_ = context.Operators.Quantity(24m, "hours");
                CqlDateTime ozzzzzzzzzzzk_ = context.Operators.Add(ozzzzzzzzzzzi_, ozzzzzzzzzzzj_);
                CqlDateTime ozzzzzzzzzzzm_ = context.Operators.End(ozzzzzzzzzzzh_);
                CqlInterval<CqlDateTime> ozzzzzzzzzzzn_ = context.Operators.Interval(ozzzzzzzzzzzk_, ozzzzzzzzzzzm_, true, true);
                bool? ozzzzzzzzzzzo_ = context.Operators.In<CqlDateTime>(ozzzzzzzzzzzg_, ozzzzzzzzzzzn_, default);
                Code<ObservationStatus> ozzzzzzzzzzzp_ = SkinExam?.StatusElement;
                ObservationStatus? ozzzzzzzzzzzq_ = ozzzzzzzzzzzp_?.Value;
                Code<ObservationStatus> ozzzzzzzzzzzr_ = context.Operators.Convert<Code<ObservationStatus>>(ozzzzzzzzzzzq_);
                string ozzzzzzzzzzzs_ = context.Operators.Convert<string>(ozzzzzzzzzzzr_);
                string[] ozzzzzzzzzzzt_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ozzzzzzzzzzzu_ = context.Operators.In<string>(ozzzzzzzzzzzs_, ozzzzzzzzzzzt_ as IEnumerable<string>);
                bool? ozzzzzzzzzzzv_ = context.Operators.And(ozzzzzzzzzzzo_, ozzzzzzzzzzzu_);
                DataType ozzzzzzzzzzzw_ = SkinExam?.Value;
                object ozzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzw_);
                CqlValueSet ozzzzzzzzzzzy_ = this.Pressure_Injury_Stage_2__3__4_or_Unstageable(context);
                bool? ozzzzzzzzzzzz_ = context.Operators.ConceptInValueSet(ozzzzzzzzzzzx_ as CqlConcept, ozzzzzzzzzzzy_);
                List<Observation.ComponentComponent> pzzzzzzzzzzza_ = SkinExam?.Component;
                bool? pzzzzzzzzzzzb_(Observation.ComponentComponent @this)
                {
                    CodeableConcept pzzzzzzzzzzzj_ = @this?.Code;
                    CqlConcept pzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, pzzzzzzzzzzzj_);
                    bool? pzzzzzzzzzzzl_ = context.Operators.Not((bool?)(pzzzzzzzzzzzk_ is null));

                    return pzzzzzzzzzzzl_;
                };
                IEnumerable<Observation.ComponentComponent> pzzzzzzzzzzzc_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)pzzzzzzzzzzza_, pzzzzzzzzzzzb_);
                CqlConcept pzzzzzzzzzzzd_(Observation.ComponentComponent @this)
                {
                    CodeableConcept pzzzzzzzzzzzm_ = @this?.Code;
                    CqlConcept pzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, pzzzzzzzzzzzm_);

                    return pzzzzzzzzzzzn_;
                };
                IEnumerable<CqlConcept> pzzzzzzzzzzze_ = context.Operators.Select<Observation.ComponentComponent, CqlConcept>(pzzzzzzzzzzzc_, pzzzzzzzzzzzd_);
                bool? pzzzzzzzzzzzg_ = context.Operators.ConceptsInValueSet(pzzzzzzzzzzze_, ozzzzzzzzzzzy_);
                bool? pzzzzzzzzzzzh_ = context.Operators.Or(ozzzzzzzzzzzz_, pzzzzzzzzzzzg_);
                bool? pzzzzzzzzzzzi_ = context.Operators.And(ozzzzzzzzzzzv_, pzzzzzzzzzzzh_);

                return pzzzzzzzzzzzi_;
            };
            IEnumerable<Observation> ozzzzzzzzzzza_ = context.Operators.Where<Observation>(nzzzzzzzzzzzy_, nzzzzzzzzzzzz_);
            Encounter ozzzzzzzzzzzb_(Observation SkinExam) =>
                InpatientHospitalization;
            IEnumerable<Encounter> ozzzzzzzzzzzc_ = context.Operators.Select<Observation, Encounter>(ozzzzzzzzzzza_, ozzzzzzzzzzzb_);

            return ozzzzzzzzzzzc_;
        };
        IEnumerable<Encounter> nzzzzzzzzzzzv_ = context.Operators.SelectMany<Encounter, Encounter>(nzzzzzzzzzzzt_, nzzzzzzzzzzzu_);

        return nzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Encounter with New Stage 2, 3, 4 or Unstageable Pressure Injury Not POA")]
    public IEnumerable<Encounter> Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_Not_POA(CqlContext context)
    {
        IEnumerable<Encounter> pzzzzzzzzzzzo_ = this.Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_Not_POA_by_Indicator(context);
        IEnumerable<Encounter> pzzzzzzzzzzzp_ = this.Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_by_Skin_Exam_after_First_24_Hours(context);
        IEnumerable<Encounter> pzzzzzzzzzzzq_ = context.Operators.Union<Encounter>(pzzzzzzzzzzzo_, pzzzzzzzzzzzp_);

        return pzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> pzzzzzzzzzzzr_ = this.Encounter_with_New_Deep_Tissue_Pressure_Injury_Not_POA(context);
        IEnumerable<Encounter> pzzzzzzzzzzzs_ = this.Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_Not_POA(context);
        IEnumerable<Encounter> pzzzzzzzzzzzt_ = context.Operators.Union<Encounter>(pzzzzzzzzzzzr_, pzzzzzzzzzzzs_);

        return pzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? pzzzzzzzzzzzu_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return pzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> pzzzzzzzzzzzv_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return pzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? pzzzzzzzzzzzw_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return pzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode pzzzzzzzzzzzx_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return pzzzzzzzzzzzx_;
    }


    #endregion Expressions

}
