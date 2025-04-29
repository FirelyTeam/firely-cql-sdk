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
        CqlDateTime czzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime czzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Interval(czzzzzzzzzzzzzzzzzzzzzzd_, czzzzzzzzzzzzzzzzzzzzzze_, true, true);
        object czzzzzzzzzzzzzzzzzzzzzzg_ = context.ResolveParameter("HospitalHarmPressureInjuryFHIR-0.1.000", "Measurement Period", czzzzzzzzzzzzzzzzzzzzzzf_);

        return (CqlInterval<CqlDateTime>)czzzzzzzzzzzzzzzzzzzzzzg_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> czzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient czzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.SingletonFrom<Patient>(czzzzzzzzzzzzzzzzzzzzzzh_);

        return czzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Encounter with Age 18 and Older")]
    public IEnumerable<Encounter> Encounter_with_Age_18_and_Older(CqlContext context)
    {
        CqlValueSet czzzzzzzzzzzzzzzzzzzzzzj_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? czzzzzzzzzzzzzzzzzzzzzzl_(Encounter InpatientEncounter)
        {
            Patient czzzzzzzzzzzzzzzzzzzzzzn_ = this.Patient(context);
            Date czzzzzzzzzzzzzzzzzzzzzzo_ = czzzzzzzzzzzzzzzzzzzzzzn_?.BirthDateElement;
            string czzzzzzzzzzzzzzzzzzzzzzp_ = czzzzzzzzzzzzzzzzzzzzzzo_?.Value;
            CqlDate czzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.ConvertStringToDate(czzzzzzzzzzzzzzzzzzzzzzp_);
            Period czzzzzzzzzzzzzzzzzzzzzzr_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzzzzzzzzzzzzzzzr_);
            CqlDateTime czzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzzzzzs_);
            CqlDate czzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.DateFrom(czzzzzzzzzzzzzzzzzzzzzzt_);
            int? czzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.CalculateAgeAt(czzzzzzzzzzzzzzzzzzzzzzq_, czzzzzzzzzzzzzzzzzzzzzzu_, "year");
            bool? czzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.GreaterOrEqual(czzzzzzzzzzzzzzzzzzzzzzv_, 18);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzzzzzzzzzzzzzzzr_);
            CqlDateTime czzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.End(czzzzzzzzzzzzzzzzzzzzzzy_);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzza_ = this.Measurement_Period(context);
            bool? dzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDateTime>(czzzzzzzzzzzzzzzzzzzzzzz_, dzzzzzzzzzzzzzzzzzzzzzza_, "day");
            bool? dzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzzzw_, dzzzzzzzzzzzzzzzzzzzzzzb_);
            Code<Encounter.EncounterStatus> dzzzzzzzzzzzzzzzzzzzzzzd_ = InpatientEncounter?.StatusElement;
            Encounter.EncounterStatus? dzzzzzzzzzzzzzzzzzzzzzze_ = dzzzzzzzzzzzzzzzzzzzzzzd_?.Value;
            Code<Encounter.EncounterStatus> dzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(dzzzzzzzzzzzzzzzzzzzzzze_);
            bool? dzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Equal(dzzzzzzzzzzzzzzzzzzzzzzf_, "finished");
            bool? dzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzzzzzc_, dzzzzzzzzzzzzzzzzzzzzzzg_);

            return dzzzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Encounter>(czzzzzzzzzzzzzzzzzzzzzzk_, czzzzzzzzzzzzzzzzzzzzzzl_);

        return czzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzi_ = this.Encounter_with_Age_18_and_Older(context);

        return dzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzj_ = this.Initial_Population(context);

        return dzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Encounter with Deep Tissue Pressure Injury POA by Indicator")]
    public IEnumerable<Encounter> Encounter_with_Deep_Tissue_Pressure_Injury_POA_by_Indicator(CqlContext context)
    {
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzk_ = this.Encounter_with_Age_18_and_Older(context);
        bool? dzzzzzzzzzzzzzzzzzzzzzzl_(Encounter InpatientHospitalization)
        {
            List<Encounter.DiagnosisComponent> dzzzzzzzzzzzzzzzzzzzzzzn_ = InpatientHospitalization?.Diagnosis;
            bool? dzzzzzzzzzzzzzzzzzzzzzzo_(Encounter.DiagnosisComponent EncounterDiag)
            {
                ResourceReference dzzzzzzzzzzzzzzzzzzzzzzr_ = EncounterDiag?.Condition;
                Condition dzzzzzzzzzzzzzzzzzzzzzzs_ = CQMCommon_2_2_000.Instance.getCondition(context, dzzzzzzzzzzzzzzzzzzzzzzr_);
                CodeableConcept dzzzzzzzzzzzzzzzzzzzzzzt_ = dzzzzzzzzzzzzzzzzzzzzzzs_?.Code;
                CqlConcept dzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzv_ = this.Pressure_Injury_Deep_Tissue_Diagnoses(context);
                bool? dzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.ConceptInValueSet(dzzzzzzzzzzzzzzzzzzzzzzu_, dzzzzzzzzzzzzzzzzzzzzzzv_);
                bool? dzzzzzzzzzzzzzzzzzzzzzzx_(Extension @this)
                {
                    string ezzzzzzzzzzzzzzzzzzzzzzg_ = @this?.Url;
                    FhirString ezzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Convert<FhirString>(ezzzzzzzzzzzzzzzzzzzzzzg_);
                    string ezzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToString(context, ezzzzzzzzzzzzzzzzzzzzzzh_);
                    bool? ezzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Equal(ezzzzzzzzzzzzzzzzzzzzzzi_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return ezzzzzzzzzzzzzzzzzzzzzzj_;
                };
                IEnumerable<Extension> dzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(EncounterDiag is Element
                        ? (EncounterDiag as Element).Extension
                        : default), dzzzzzzzzzzzzzzzzzzzzzzx_);
                object dzzzzzzzzzzzzzzzzzzzzzzz_(Extension @this)
                {
                    DataType ezzzzzzzzzzzzzzzzzzzzzzk_ = @this?.Value;

                    return ezzzzzzzzzzzzzzzzzzzzzzk_;
                };
                IEnumerable<object> ezzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Select<Extension, object>(dzzzzzzzzzzzzzzzzzzzzzzy_, dzzzzzzzzzzzzzzzzzzzzzzz_);
                object ezzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.SingletonFrom<object>(ezzzzzzzzzzzzzzzzzzzzzza_);
                CqlConcept ezzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ezzzzzzzzzzzzzzzzzzzzzzb_ as CodeableConcept);
                CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzd_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? ezzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.ConceptInValueSet(ezzzzzzzzzzzzzzzzzzzzzzc_, ezzzzzzzzzzzzzzzzzzzzzzd_);
                bool? ezzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzzzzzw_, ezzzzzzzzzzzzzzzzzzzzzze_);

                return ezzzzzzzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<Encounter.DiagnosisComponent> dzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)dzzzzzzzzzzzzzzzzzzzzzzn_, dzzzzzzzzzzzzzzzzzzzzzzo_);
            bool? dzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Exists<Encounter.DiagnosisComponent>(dzzzzzzzzzzzzzzzzzzzzzzp_);

            return dzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Encounter>(dzzzzzzzzzzzzzzzzzzzzzzk_, dzzzzzzzzzzzzzzzzzzzzzzl_);

        return dzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Encounter with Deep Tissue Pressure Injury POA by Skin Exam within First 72 Hours")]
    public IEnumerable<Encounter> Encounter_with_Deep_Tissue_Pressure_Injury_POA_by_Skin_Exam_within_First_72_Hours(CqlContext context)
    {
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzl_ = this.Encounter_with_Age_18_and_Older(context);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzm_(Encounter InpatientHospitalization)
        {
            CqlCode ezzzzzzzzzzzzzzzzzzzzzzo_ = this.Physical_findings_of_Skin(context);
            IEnumerable<CqlCode> ezzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.ToList<CqlCode>(ezzzzzzzzzzzzzzzzzzzzzzo_);
            IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, ezzzzzzzzzzzzzzzzzzzzzzp_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            bool? ezzzzzzzzzzzzzzzzzzzzzzr_(Observation SkinExam)
            {
                DataType ezzzzzzzzzzzzzzzzzzzzzzv_ = SkinExam?.Effective;
                object ezzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzv_);
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.ToInterval(context, ezzzzzzzzzzzzzzzzzzzzzzw_);
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzz_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, InpatientHospitalization);
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzzzzzzz_);
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzzzzzzz_);
                CqlQuantity fzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Quantity(72m, "hours");
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Add(fzzzzzzzzzzzzzzzzzzzzzzc_, fzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Interval(fzzzzzzzzzzzzzzzzzzzzzza_, fzzzzzzzzzzzzzzzzzzzzzze_, true, true);
                bool? fzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.In<CqlDateTime>(ezzzzzzzzzzzzzzzzzzzzzzy_, fzzzzzzzzzzzzzzzzzzzzzzf_, default);
                Code<ObservationStatus> fzzzzzzzzzzzzzzzzzzzzzzh_ = SkinExam?.StatusElement;
                ObservationStatus? fzzzzzzzzzzzzzzzzzzzzzzi_ = fzzzzzzzzzzzzzzzzzzzzzzh_?.Value;
                Code<ObservationStatus> fzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Convert<Code<ObservationStatus>>(fzzzzzzzzzzzzzzzzzzzzzzi_);
                string fzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<string>(fzzzzzzzzzzzzzzzzzzzzzzj_);
                string[] fzzzzzzzzzzzzzzzzzzzzzzl_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? fzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.In<string>(fzzzzzzzzzzzzzzzzzzzzzzk_, fzzzzzzzzzzzzzzzzzzzzzzl_ as IEnumerable<string>);
                bool? fzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzg_, fzzzzzzzzzzzzzzzzzzzzzzm_);
                CodeableConcept fzzzzzzzzzzzzzzzzzzzzzzo_ = SkinExam?.Code;
                CqlConcept fzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzq_ = this.Pressure_Injury_Deep_Tissue(context);
                bool? fzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ConceptInValueSet(fzzzzzzzzzzzzzzzzzzzzzzp_, fzzzzzzzzzzzzzzzzzzzzzzq_);
                bool? fzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzn_, fzzzzzzzzzzzzzzzzzzzzzzr_);

                return fzzzzzzzzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Observation>(ezzzzzzzzzzzzzzzzzzzzzzq_, ezzzzzzzzzzzzzzzzzzzzzzr_);
            Encounter ezzzzzzzzzzzzzzzzzzzzzzt_(Observation SkinExam) =>
                InpatientHospitalization;
            IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Select<Observation, Encounter>(ezzzzzzzzzzzzzzzzzzzzzzs_, ezzzzzzzzzzzzzzzzzzzzzzt_);

            return ezzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.SelectMany<Encounter, Encounter>(ezzzzzzzzzzzzzzzzzzzzzzl_, ezzzzzzzzzzzzzzzzzzzzzzm_);

        return ezzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Encounter with Deep Tissue Pressure Injury POA")]
    public IEnumerable<Encounter> Encounter_with_Deep_Tissue_Pressure_Injury_POA(CqlContext context)
    {
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzt_ = this.Encounter_with_Deep_Tissue_Pressure_Injury_POA_by_Indicator(context);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzu_ = this.Encounter_with_Deep_Tissue_Pressure_Injury_POA_by_Skin_Exam_within_First_72_Hours(context);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<Encounter>(fzzzzzzzzzzzzzzzzzzzzzzt_, fzzzzzzzzzzzzzzzzzzzzzzu_);

        return fzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Encounter with Stage 2, 3, 4, or Unstageable Pressure Injury Present on Admission by POA Indicator")]
    public IEnumerable<Encounter> Encounter_with_Stage_2__3__4__or_Unstageable_Pressure_Injury_Present_on_Admission_by_POA_Indicator(CqlContext context)
    {
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzw_ = this.Encounter_with_Age_18_and_Older(context);
        bool? fzzzzzzzzzzzzzzzzzzzzzzx_(Encounter InpatientHospitalization)
        {
            List<Encounter.DiagnosisComponent> fzzzzzzzzzzzzzzzzzzzzzzz_ = InpatientHospitalization?.Diagnosis;
            bool? gzzzzzzzzzzzzzzzzzzzzzza_(Encounter.DiagnosisComponent Stage234UnstageablePressureInjury)
            {
                ResourceReference gzzzzzzzzzzzzzzzzzzzzzzd_ = Stage234UnstageablePressureInjury?.Condition;
                Condition gzzzzzzzzzzzzzzzzzzzzzze_ = CQMCommon_2_2_000.Instance.getCondition(context, gzzzzzzzzzzzzzzzzzzzzzzd_);
                CodeableConcept gzzzzzzzzzzzzzzzzzzzzzzf_ = gzzzzzzzzzzzzzzzzzzzzzze_?.Code;
                CqlConcept gzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, gzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlValueSet gzzzzzzzzzzzzzzzzzzzzzzh_ = this.Pressure_Injury_Stage_2__3__4__or_Unstageable_Diagnoses(context);
                bool? gzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.ConceptInValueSet(gzzzzzzzzzzzzzzzzzzzzzzg_, gzzzzzzzzzzzzzzzzzzzzzzh_);
                bool? gzzzzzzzzzzzzzzzzzzzzzzj_(Extension @this)
                {
                    string gzzzzzzzzzzzzzzzzzzzzzzs_ = @this?.Url;
                    FhirString gzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Convert<FhirString>(gzzzzzzzzzzzzzzzzzzzzzzs_);
                    string gzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToString(context, gzzzzzzzzzzzzzzzzzzzzzzt_);
                    bool? gzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Equal(gzzzzzzzzzzzzzzzzzzzzzzu_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return gzzzzzzzzzzzzzzzzzzzzzzv_;
                };
                IEnumerable<Extension> gzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Stage234UnstageablePressureInjury is Element
                        ? (Stage234UnstageablePressureInjury as Element).Extension
                        : default), gzzzzzzzzzzzzzzzzzzzzzzj_);
                object gzzzzzzzzzzzzzzzzzzzzzzl_(Extension @this)
                {
                    DataType gzzzzzzzzzzzzzzzzzzzzzzw_ = @this?.Value;

                    return gzzzzzzzzzzzzzzzzzzzzzzw_;
                };
                IEnumerable<object> gzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Select<Extension, object>(gzzzzzzzzzzzzzzzzzzzzzzk_, gzzzzzzzzzzzzzzzzzzzzzzl_);
                object gzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.SingletonFrom<object>(gzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlConcept gzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, gzzzzzzzzzzzzzzzzzzzzzzn_ as CodeableConcept);
                CqlValueSet gzzzzzzzzzzzzzzzzzzzzzzp_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? gzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.ConceptInValueSet(gzzzzzzzzzzzzzzzzzzzzzzo_, gzzzzzzzzzzzzzzzzzzzzzzp_);
                bool? gzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzzi_, gzzzzzzzzzzzzzzzzzzzzzzq_);

                return gzzzzzzzzzzzzzzzzzzzzzzr_;
            };
            IEnumerable<Encounter.DiagnosisComponent> gzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)fzzzzzzzzzzzzzzzzzzzzzzz_, gzzzzzzzzzzzzzzzzzzzzzza_);
            bool? gzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Exists<Encounter.DiagnosisComponent>(gzzzzzzzzzzzzzzzzzzzzzzb_);

            return gzzzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Encounter>(fzzzzzzzzzzzzzzzzzzzzzzw_, fzzzzzzzzzzzzzzzzzzzzzzx_);

        return fzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Encounter with Stage 2, 3, 4 or Unstageable Pressure Injury POA by Skin Exam within 24 Hours")]
    public IEnumerable<Encounter> Encounter_with_Stage_2__3__4_or_Unstageable_Pressure_Injury_POA_by_Skin_Exam_within_24_Hours(CqlContext context)
    {
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzzx_ = this.Encounter_with_Age_18_and_Older(context);
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzzy_(Encounter InpatientHospitalization)
        {
            CqlCode hzzzzzzzzzzzzzzzzzzzzzza_ = this.Physical_findings_of_Skin(context);
            IEnumerable<CqlCode> hzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.ToList<CqlCode>(hzzzzzzzzzzzzzzzzzzzzzza_);
            IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, hzzzzzzzzzzzzzzzzzzzzzzb_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            bool? hzzzzzzzzzzzzzzzzzzzzzzd_(Observation SkinExam)
            {
                DataType hzzzzzzzzzzzzzzzzzzzzzzh_ = SkinExam?.Effective;
                object hzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.ToInterval(context, hzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Start(hzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzl_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, InpatientHospitalization);
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(hzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Start(hzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlQuantity hzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Quantity(24m, "hours");
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Add(hzzzzzzzzzzzzzzzzzzzzzzo_, hzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Interval(hzzzzzzzzzzzzzzzzzzzzzzm_, hzzzzzzzzzzzzzzzzzzzzzzq_, true, true);
                bool? hzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.In<CqlDateTime>(hzzzzzzzzzzzzzzzzzzzzzzk_, hzzzzzzzzzzzzzzzzzzzzzzr_, default);
                Code<ObservationStatus> hzzzzzzzzzzzzzzzzzzzzzzt_ = SkinExam?.StatusElement;
                ObservationStatus? hzzzzzzzzzzzzzzzzzzzzzzu_ = hzzzzzzzzzzzzzzzzzzzzzzt_?.Value;
                Code<ObservationStatus> hzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Convert<Code<ObservationStatus>>(hzzzzzzzzzzzzzzzzzzzzzzu_);
                string hzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<string>(hzzzzzzzzzzzzzzzzzzzzzzv_);
                string[] hzzzzzzzzzzzzzzzzzzzzzzx_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? hzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<string>(hzzzzzzzzzzzzzzzzzzzzzzw_, hzzzzzzzzzzzzzzzzzzzzzzx_ as IEnumerable<string>);
                bool? hzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzzs_, hzzzzzzzzzzzzzzzzzzzzzzy_);
                CodeableConcept izzzzzzzzzzzzzzzzzzzzzza_ = SkinExam?.Code;
                CqlConcept izzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, izzzzzzzzzzzzzzzzzzzzzza_);
                CqlValueSet izzzzzzzzzzzzzzzzzzzzzzc_ = this.Pressure_Injury_Stage_2__3__4_or_Unstageable(context);
                bool? izzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ConceptInValueSet(izzzzzzzzzzzzzzzzzzzzzzb_, izzzzzzzzzzzzzzzzzzzzzzc_);
                bool? izzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzzz_, izzzzzzzzzzzzzzzzzzzzzzd_);

                return izzzzzzzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Observation>(hzzzzzzzzzzzzzzzzzzzzzzc_, hzzzzzzzzzzzzzzzzzzzzzzd_);
            Encounter hzzzzzzzzzzzzzzzzzzzzzzf_(Observation SkinExam) =>
                InpatientHospitalization;
            IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Select<Observation, Encounter>(hzzzzzzzzzzzzzzzzzzzzzze_, hzzzzzzzzzzzzzzzzzzzzzzf_);

            return hzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.SelectMany<Encounter, Encounter>(gzzzzzzzzzzzzzzzzzzzzzzx_, gzzzzzzzzzzzzzzzzzzzzzzy_);

        return gzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Encounter with Stage 2, 3, 4 or Unstageable Pressure Injury POA")]
    public IEnumerable<Encounter> Encounter_with_Stage_2__3__4_or_Unstageable_Pressure_Injury_POA(CqlContext context)
    {
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzf_ = this.Encounter_with_Stage_2__3__4__or_Unstageable_Pressure_Injury_Present_on_Admission_by_POA_Indicator(context);
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzg_ = this.Encounter_with_Stage_2__3__4_or_Unstageable_Pressure_Injury_POA_by_Skin_Exam_within_24_Hours(context);
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<Encounter>(izzzzzzzzzzzzzzzzzzzzzzf_, izzzzzzzzzzzzzzzzzzzzzzg_);

        return izzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Encounter with Diagnosis of COVID19 Infection")]
    public IEnumerable<Encounter> Encounter_with_Diagnosis_of_COVID19_Infection(CqlContext context)
    {
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzi_ = this.Encounter_with_Age_18_and_Older(context);
        bool? izzzzzzzzzzzzzzzzzzzzzzj_(Encounter InpatientHospitalization)
        {
            IEnumerable<Condition> izzzzzzzzzzzzzzzzzzzzzzl_ = CQMCommon_2_2_000.Instance.EncounterDiagnosis(context, InpatientHospitalization);
            bool? izzzzzzzzzzzzzzzzzzzzzzm_(Condition EncounterDiag)
            {
                CodeableConcept izzzzzzzzzzzzzzzzzzzzzzp_ = EncounterDiag?.Code;
                CqlConcept izzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, izzzzzzzzzzzzzzzzzzzzzzp_);
                CqlValueSet izzzzzzzzzzzzzzzzzzzzzzr_ = this.COVID_19(context);
                bool? izzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ConceptInValueSet(izzzzzzzzzzzzzzzzzzzzzzq_, izzzzzzzzzzzzzzzzzzzzzzr_);

                return izzzzzzzzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<Condition> izzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Condition>(izzzzzzzzzzzzzzzzzzzzzzl_, izzzzzzzzzzzzzzzzzzzzzzm_);
            bool? izzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Exists<Condition>(izzzzzzzzzzzzzzzzzzzzzzn_);

            return izzzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Encounter>(izzzzzzzzzzzzzzzzzzzzzzi_, izzzzzzzzzzzzzzzzzzzzzzj_);

        return izzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context)
    {
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzt_ = this.Encounter_with_Deep_Tissue_Pressure_Injury_POA(context);
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzu_ = this.Encounter_with_Stage_2__3__4_or_Unstageable_Pressure_Injury_POA(context);
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<Encounter>(izzzzzzzzzzzzzzzzzzzzzzt_, izzzzzzzzzzzzzzzzzzzzzzu_);
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzw_ = this.Encounter_with_Diagnosis_of_COVID19_Infection(context);
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Union<Encounter>(izzzzzzzzzzzzzzzzzzzzzzv_, izzzzzzzzzzzzzzzzzzzzzzw_);

        return izzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Encounter with New Deep Tissue Pressure Injury Not POA by Indicator")]
    public IEnumerable<Encounter> Encounter_with_New_Deep_Tissue_Pressure_Injury_Not_POA_by_Indicator(CqlContext context)
    {
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzy_ = this.Encounter_with_Age_18_and_Older(context);
        bool? izzzzzzzzzzzzzzzzzzzzzzz_(Encounter InpatientHospitalization)
        {
            List<Encounter.DiagnosisComponent> jzzzzzzzzzzzzzzzzzzzzzzb_ = InpatientHospitalization?.Diagnosis;
            bool? jzzzzzzzzzzzzzzzzzzzzzzc_(Encounter.DiagnosisComponent EncounterDiag)
            {
                ResourceReference jzzzzzzzzzzzzzzzzzzzzzzf_ = EncounterDiag?.Condition;
                Condition jzzzzzzzzzzzzzzzzzzzzzzg_ = CQMCommon_2_2_000.Instance.getCondition(context, jzzzzzzzzzzzzzzzzzzzzzzf_);
                CodeableConcept jzzzzzzzzzzzzzzzzzzzzzzh_ = jzzzzzzzzzzzzzzzzzzzzzzg_?.Code;
                CqlConcept jzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, jzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlValueSet jzzzzzzzzzzzzzzzzzzzzzzj_ = this.Pressure_Injury_Deep_Tissue_Diagnoses(context);
                bool? jzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.ConceptInValueSet(jzzzzzzzzzzzzzzzzzzzzzzi_, jzzzzzzzzzzzzzzzzzzzzzzj_);
                bool? jzzzzzzzzzzzzzzzzzzzzzzl_(Extension @this)
                {
                    string jzzzzzzzzzzzzzzzzzzzzzzu_ = @this?.Url;
                    FhirString jzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Convert<FhirString>(jzzzzzzzzzzzzzzzzzzzzzzu_);
                    string jzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToString(context, jzzzzzzzzzzzzzzzzzzzzzzv_);
                    bool? jzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Equal(jzzzzzzzzzzzzzzzzzzzzzzw_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return jzzzzzzzzzzzzzzzzzzzzzzx_;
                };
                IEnumerable<Extension> jzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(EncounterDiag is Element
                        ? (EncounterDiag as Element).Extension
                        : default), jzzzzzzzzzzzzzzzzzzzzzzl_);
                object jzzzzzzzzzzzzzzzzzzzzzzn_(Extension @this)
                {
                    DataType jzzzzzzzzzzzzzzzzzzzzzzy_ = @this?.Value;

                    return jzzzzzzzzzzzzzzzzzzzzzzy_;
                };
                IEnumerable<object> jzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Select<Extension, object>(jzzzzzzzzzzzzzzzzzzzzzzm_, jzzzzzzzzzzzzzzzzzzzzzzn_);
                object jzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.SingletonFrom<object>(jzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlConcept jzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, jzzzzzzzzzzzzzzzzzzzzzzp_ as CodeableConcept);
                CqlValueSet jzzzzzzzzzzzzzzzzzzzzzzr_ = this.Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine(context);
                bool? jzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ConceptInValueSet(jzzzzzzzzzzzzzzzzzzzzzzq_, jzzzzzzzzzzzzzzzzzzzzzzr_);
                bool? jzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzzzk_, jzzzzzzzzzzzzzzzzzzzzzzs_);

                return jzzzzzzzzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<Encounter.DiagnosisComponent> jzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)jzzzzzzzzzzzzzzzzzzzzzzb_, jzzzzzzzzzzzzzzzzzzzzzzc_);
            bool? jzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Exists<Encounter.DiagnosisComponent>(jzzzzzzzzzzzzzzzzzzzzzzd_);

            return jzzzzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Encounter>(izzzzzzzzzzzzzzzzzzzzzzy_, izzzzzzzzzzzzzzzzzzzzzzz_);

        return jzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Encounter with New Deep Tissue Pressure Injury by Skin Exam after First 72 Hours")]
    public IEnumerable<Encounter> Encounter_with_New_Deep_Tissue_Pressure_Injury_by_Skin_Exam_after_First_72_Hours(CqlContext context)
    {
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzz_ = this.Encounter_with_Age_18_and_Older(context);
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzza_(Encounter InpatientHospitalization)
        {
            CqlCode kzzzzzzzzzzzzzzzzzzzzzzc_ = this.Physical_findings_of_Skin(context);
            IEnumerable<CqlCode> kzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ToList<CqlCode>(kzzzzzzzzzzzzzzzzzzzzzzc_);
            IEnumerable<Observation> kzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, kzzzzzzzzzzzzzzzzzzzzzzd_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            bool? kzzzzzzzzzzzzzzzzzzzzzzf_(Observation SkinExam)
            {
                DataType kzzzzzzzzzzzzzzzzzzzzzzj_ = SkinExam?.Effective;
                object kzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.ToInterval(context, kzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzn_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, InpatientHospitalization);
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlQuantity kzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Quantity(72m, "hours");
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Add(kzzzzzzzzzzzzzzzzzzzzzzo_, kzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.End(kzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Interval(kzzzzzzzzzzzzzzzzzzzzzzq_, kzzzzzzzzzzzzzzzzzzzzzzs_, true, true);
                bool? kzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(kzzzzzzzzzzzzzzzzzzzzzzm_, kzzzzzzzzzzzzzzzzzzzzzzt_, default);
                Code<ObservationStatus> kzzzzzzzzzzzzzzzzzzzzzzv_ = SkinExam?.StatusElement;
                ObservationStatus? kzzzzzzzzzzzzzzzzzzzzzzw_ = kzzzzzzzzzzzzzzzzzzzzzzv_?.Value;
                Code<ObservationStatus> kzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<Code<ObservationStatus>>(kzzzzzzzzzzzzzzzzzzzzzzw_);
                string kzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<string>(kzzzzzzzzzzzzzzzzzzzzzzx_);
                string[] kzzzzzzzzzzzzzzzzzzzzzzz_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? lzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<string>(kzzzzzzzzzzzzzzzzzzzzzzy_, kzzzzzzzzzzzzzzzzzzzzzzz_ as IEnumerable<string>);
                bool? lzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzu_, lzzzzzzzzzzzzzzzzzzzzzza_);
                DataType lzzzzzzzzzzzzzzzzzzzzzzc_ = SkinExam?.Value;
                object lzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlValueSet lzzzzzzzzzzzzzzzzzzzzzze_ = this.Pressure_Injury_Deep_Tissue(context);
                bool? lzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.ConceptInValueSet(lzzzzzzzzzzzzzzzzzzzzzzd_ as CqlConcept, lzzzzzzzzzzzzzzzzzzzzzze_);
                List<Observation.ComponentComponent> lzzzzzzzzzzzzzzzzzzzzzzg_ = SkinExam?.Component;
                bool? lzzzzzzzzzzzzzzzzzzzzzzh_(Observation.ComponentComponent @this)
                {
                    CodeableConcept lzzzzzzzzzzzzzzzzzzzzzzp_ = @this?.Code;
                    CqlConcept lzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, lzzzzzzzzzzzzzzzzzzzzzzp_);
                    bool? lzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Not((bool?)(lzzzzzzzzzzzzzzzzzzzzzzq_ is null));

                    return lzzzzzzzzzzzzzzzzzzzzzzr_;
                };
                IEnumerable<Observation.ComponentComponent> lzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)lzzzzzzzzzzzzzzzzzzzzzzg_, lzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlConcept lzzzzzzzzzzzzzzzzzzzzzzj_(Observation.ComponentComponent @this)
                {
                    CodeableConcept lzzzzzzzzzzzzzzzzzzzzzzs_ = @this?.Code;
                    CqlConcept lzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, lzzzzzzzzzzzzzzzzzzzzzzs_);

                    return lzzzzzzzzzzzzzzzzzzzzzzt_;
                };
                IEnumerable<CqlConcept> lzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Select<Observation.ComponentComponent, CqlConcept>(lzzzzzzzzzzzzzzzzzzzzzzi_, lzzzzzzzzzzzzzzzzzzzzzzj_);
                bool? lzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.ConceptsInValueSet(lzzzzzzzzzzzzzzzzzzzzzzk_, lzzzzzzzzzzzzzzzzzzzzzze_);
                bool? lzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Or(lzzzzzzzzzzzzzzzzzzzzzzf_, lzzzzzzzzzzzzzzzzzzzzzzm_);
                bool? lzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzb_, lzzzzzzzzzzzzzzzzzzzzzzn_);

                return lzzzzzzzzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<Observation> kzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Observation>(kzzzzzzzzzzzzzzzzzzzzzze_, kzzzzzzzzzzzzzzzzzzzzzzf_);
            Encounter kzzzzzzzzzzzzzzzzzzzzzzh_(Observation SkinExam) =>
                InpatientHospitalization;
            IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Select<Observation, Encounter>(kzzzzzzzzzzzzzzzzzzzzzzg_, kzzzzzzzzzzzzzzzzzzzzzzh_);

            return kzzzzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.SelectMany<Encounter, Encounter>(jzzzzzzzzzzzzzzzzzzzzzzz_, kzzzzzzzzzzzzzzzzzzzzzza_);

        return kzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Encounter with New Deep Tissue Pressure Injury Not POA")]
    public IEnumerable<Encounter> Encounter_with_New_Deep_Tissue_Pressure_Injury_Not_POA(CqlContext context)
    {
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzu_ = this.Encounter_with_New_Deep_Tissue_Pressure_Injury_Not_POA_by_Indicator(context);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzv_ = this.Encounter_with_New_Deep_Tissue_Pressure_Injury_by_Skin_Exam_after_First_72_Hours(context);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Union<Encounter>(lzzzzzzzzzzzzzzzzzzzzzzu_, lzzzzzzzzzzzzzzzzzzzzzzv_);

        return lzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Encounter with New Stage 2, 3, 4 or Unstageable Pressure Injury Not POA by Indicator")]
    public IEnumerable<Encounter> Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_Not_POA_by_Indicator(CqlContext context)
    {
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzx_ = this.Encounter_with_Age_18_and_Older(context);
        bool? lzzzzzzzzzzzzzzzzzzzzzzy_(Encounter InpatientHospitalization)
        {
            List<Encounter.DiagnosisComponent> mzzzzzzzzzzzzzzzzzzzzzza_ = InpatientHospitalization?.Diagnosis;
            bool? mzzzzzzzzzzzzzzzzzzzzzzb_(Encounter.DiagnosisComponent Stage234UnstageablePressureInjury)
            {
                ResourceReference mzzzzzzzzzzzzzzzzzzzzzze_ = Stage234UnstageablePressureInjury?.Condition;
                Condition mzzzzzzzzzzzzzzzzzzzzzzf_ = CQMCommon_2_2_000.Instance.getCondition(context, mzzzzzzzzzzzzzzzzzzzzzze_);
                CodeableConcept mzzzzzzzzzzzzzzzzzzzzzzg_ = mzzzzzzzzzzzzzzzzzzzzzzf_?.Code;
                CqlConcept mzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, mzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzi_ = this.Pressure_Injury_Stage_2__3__4__or_Unstageable_Diagnoses(context);
                bool? mzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.ConceptInValueSet(mzzzzzzzzzzzzzzzzzzzzzzh_, mzzzzzzzzzzzzzzzzzzzzzzi_);
                bool? mzzzzzzzzzzzzzzzzzzzzzzk_(Extension @this)
                {
                    string mzzzzzzzzzzzzzzzzzzzzzzt_ = @this?.Url;
                    FhirString mzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Convert<FhirString>(mzzzzzzzzzzzzzzzzzzzzzzt_);
                    string mzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToString(context, mzzzzzzzzzzzzzzzzzzzzzzu_);
                    bool? mzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Equal(mzzzzzzzzzzzzzzzzzzzzzzv_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return mzzzzzzzzzzzzzzzzzzzzzzw_;
                };
                IEnumerable<Extension> mzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Stage234UnstageablePressureInjury is Element
                        ? (Stage234UnstageablePressureInjury as Element).Extension
                        : default), mzzzzzzzzzzzzzzzzzzzzzzk_);
                object mzzzzzzzzzzzzzzzzzzzzzzm_(Extension @this)
                {
                    DataType mzzzzzzzzzzzzzzzzzzzzzzx_ = @this?.Value;

                    return mzzzzzzzzzzzzzzzzzzzzzzx_;
                };
                IEnumerable<object> mzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Select<Extension, object>(mzzzzzzzzzzzzzzzzzzzzzzl_, mzzzzzzzzzzzzzzzzzzzzzzm_);
                object mzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.SingletonFrom<object>(mzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlConcept mzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, mzzzzzzzzzzzzzzzzzzzzzzo_ as CodeableConcept);
                CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzq_ = this.Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine(context);
                bool? mzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ConceptInValueSet(mzzzzzzzzzzzzzzzzzzzzzzp_, mzzzzzzzzzzzzzzzzzzzzzzq_);
                bool? mzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzzzj_, mzzzzzzzzzzzzzzzzzzzzzzr_);

                return mzzzzzzzzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<Encounter.DiagnosisComponent> mzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)mzzzzzzzzzzzzzzzzzzzzzza_, mzzzzzzzzzzzzzzzzzzzzzzb_);
            bool? mzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Exists<Encounter.DiagnosisComponent>(mzzzzzzzzzzzzzzzzzzzzzzc_);

            return mzzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Encounter>(lzzzzzzzzzzzzzzzzzzzzzzx_, lzzzzzzzzzzzzzzzzzzzzzzy_);

        return lzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Encounter with New Stage 2, 3, 4 or Unstageable Pressure Injury by Skin Exam after First 24 Hours")]
    public IEnumerable<Encounter> Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_by_Skin_Exam_after_First_24_Hours(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzy_ = this.Encounter_with_Age_18_and_Older(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzz_(Encounter InpatientHospitalization)
        {
            CqlCode nzzzzzzzzzzzzzzzzzzzzzzb_ = this.Physical_findings_of_Skin(context);
            IEnumerable<CqlCode> nzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.ToList<CqlCode>(nzzzzzzzzzzzzzzzzzzzzzzb_);
            IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, nzzzzzzzzzzzzzzzzzzzzzzc_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            bool? nzzzzzzzzzzzzzzzzzzzzzze_(Observation SkinExam)
            {
                DataType nzzzzzzzzzzzzzzzzzzzzzzi_ = SkinExam?.Effective;
                object nzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.ToInterval(context, nzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzm_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, InpatientHospitalization);
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlQuantity nzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Quantity(24m, "hours");
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Add(nzzzzzzzzzzzzzzzzzzzzzzn_, nzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.End(nzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Interval(nzzzzzzzzzzzzzzzzzzzzzzp_, nzzzzzzzzzzzzzzzzzzzzzzr_, true, true);
                bool? nzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.In<CqlDateTime>(nzzzzzzzzzzzzzzzzzzzzzzl_, nzzzzzzzzzzzzzzzzzzzzzzs_, default);
                Code<ObservationStatus> nzzzzzzzzzzzzzzzzzzzzzzu_ = SkinExam?.StatusElement;
                ObservationStatus? nzzzzzzzzzzzzzzzzzzzzzzv_ = nzzzzzzzzzzzzzzzzzzzzzzu_?.Value;
                Code<ObservationStatus> nzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<Code<ObservationStatus>>(nzzzzzzzzzzzzzzzzzzzzzzv_);
                string nzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<string>(nzzzzzzzzzzzzzzzzzzzzzzw_);
                string[] nzzzzzzzzzzzzzzzzzzzzzzy_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? nzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<string>(nzzzzzzzzzzzzzzzzzzzzzzx_, nzzzzzzzzzzzzzzzzzzzzzzy_ as IEnumerable<string>);
                bool? ozzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzt_, nzzzzzzzzzzzzzzzzzzzzzzz_);
                DataType ozzzzzzzzzzzzzzzzzzzzzzb_ = SkinExam?.Value;
                object ozzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzb_);
                CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzd_ = this.Pressure_Injury_Stage_2__3__4_or_Unstageable(context);
                bool? ozzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.ConceptInValueSet(ozzzzzzzzzzzzzzzzzzzzzzc_ as CqlConcept, ozzzzzzzzzzzzzzzzzzzzzzd_);
                List<Observation.ComponentComponent> ozzzzzzzzzzzzzzzzzzzzzzf_ = SkinExam?.Component;
                bool? ozzzzzzzzzzzzzzzzzzzzzzg_(Observation.ComponentComponent @this)
                {
                    CodeableConcept ozzzzzzzzzzzzzzzzzzzzzzo_ = @this?.Code;
                    CqlConcept ozzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ozzzzzzzzzzzzzzzzzzzzzzo_);
                    bool? ozzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Not((bool?)(ozzzzzzzzzzzzzzzzzzzzzzp_ is null));

                    return ozzzzzzzzzzzzzzzzzzzzzzq_;
                };
                IEnumerable<Observation.ComponentComponent> ozzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)ozzzzzzzzzzzzzzzzzzzzzzf_, ozzzzzzzzzzzzzzzzzzzzzzg_);
                CqlConcept ozzzzzzzzzzzzzzzzzzzzzzi_(Observation.ComponentComponent @this)
                {
                    CodeableConcept ozzzzzzzzzzzzzzzzzzzzzzr_ = @this?.Code;
                    CqlConcept ozzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ozzzzzzzzzzzzzzzzzzzzzzr_);

                    return ozzzzzzzzzzzzzzzzzzzzzzs_;
                };
                IEnumerable<CqlConcept> ozzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<Observation.ComponentComponent, CqlConcept>(ozzzzzzzzzzzzzzzzzzzzzzh_, ozzzzzzzzzzzzzzzzzzzzzzi_);
                bool? ozzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.ConceptsInValueSet(ozzzzzzzzzzzzzzzzzzzzzzj_, ozzzzzzzzzzzzzzzzzzzzzzd_);
                bool? ozzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Or(ozzzzzzzzzzzzzzzzzzzzzze_, ozzzzzzzzzzzzzzzzzzzzzzl_);
                bool? ozzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzza_, ozzzzzzzzzzzzzzzzzzzzzzm_);

                return ozzzzzzzzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Observation>(nzzzzzzzzzzzzzzzzzzzzzzd_, nzzzzzzzzzzzzzzzzzzzzzze_);
            Encounter nzzzzzzzzzzzzzzzzzzzzzzg_(Observation SkinExam) =>
                InpatientHospitalization;
            IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Select<Observation, Encounter>(nzzzzzzzzzzzzzzzzzzzzzzf_, nzzzzzzzzzzzzzzzzzzzzzzg_);

            return nzzzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.SelectMany<Encounter, Encounter>(mzzzzzzzzzzzzzzzzzzzzzzy_, mzzzzzzzzzzzzzzzzzzzzzzz_);

        return nzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Encounter with New Stage 2, 3, 4 or Unstageable Pressure Injury Not POA")]
    public IEnumerable<Encounter> Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_Not_POA(CqlContext context)
    {
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzt_ = this.Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_Not_POA_by_Indicator(context);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzu_ = this.Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_by_Skin_Exam_after_First_24_Hours(context);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<Encounter>(ozzzzzzzzzzzzzzzzzzzzzzt_, ozzzzzzzzzzzzzzzzzzzzzzu_);

        return ozzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzw_ = this.Encounter_with_New_Deep_Tissue_Pressure_Injury_Not_POA(context);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzx_ = this.Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_Not_POA(context);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<Encounter>(ozzzzzzzzzzzzzzzzzzzzzzw_, ozzzzzzzzzzzzzzzzzzzzzzx_);

        return ozzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? ozzzzzzzzzzzzzzzzzzzzzzz_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return ozzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> pzzzzzzzzzzzzzzzzzzzzzza_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return pzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? pzzzzzzzzzzzzzzzzzzzzzzb_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return pzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode pzzzzzzzzzzzzzzzzzzzzzzc_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return pzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    #endregion Expressions

}
