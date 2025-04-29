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

    #region ValueSet: COVID 19
    [CqlValueSetDefinition(
        definitionName: "COVID 19",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.140",
        valueSetVersion: null)]
    public CqlValueSet COVID_19(CqlContext context) => _COVID_19;

    private static readonly CqlValueSet _COVID_19 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.140", null);
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

    #region ValueSet: Not Present On Admission or Documentation Insufficient to Determine
    [CqlValueSetDefinition(
        definitionName: "Not Present On Admission or Documentation Insufficient to Determine",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.198",
        valueSetVersion: null)]
    public CqlValueSet Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine(CqlContext context) => _Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine;

    private static readonly CqlValueSet _Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.198", null);
    #endregion

    #region ValueSet: Observation Services
    [CqlValueSetDefinition(
        definitionName: "Observation Services",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143",
        valueSetVersion: null)]
    public CqlValueSet Observation_Services(CqlContext context) => _Observation_Services;

    private static readonly CqlValueSet _Observation_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", null);
    #endregion

    #region ValueSet: Present on Admission or Clinically Undetermined
    [CqlValueSetDefinition(
        definitionName: "Present on Admission or Clinically Undetermined",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.197",
        valueSetVersion: null)]
    public CqlValueSet Present_on_Admission_or_Clinically_Undetermined(CqlContext context) => _Present_on_Admission_or_Clinically_Undetermined;

    private static readonly CqlValueSet _Present_on_Admission_or_Clinically_Undetermined = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.197", null);
    #endregion

    #region ValueSet: Pressure Injury Deep Tissue
    [CqlValueSetDefinition(
        definitionName: "Pressure Injury Deep Tissue",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.112",
        valueSetVersion: null)]
    public CqlValueSet Pressure_Injury_Deep_Tissue(CqlContext context) => _Pressure_Injury_Deep_Tissue;

    private static readonly CqlValueSet _Pressure_Injury_Deep_Tissue = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.112", null);
    #endregion

    #region ValueSet: Pressure Injury Deep Tissue Diagnoses
    [CqlValueSetDefinition(
        definitionName: "Pressure Injury Deep Tissue Diagnoses",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.194",
        valueSetVersion: null)]
    public CqlValueSet Pressure_Injury_Deep_Tissue_Diagnoses(CqlContext context) => _Pressure_Injury_Deep_Tissue_Diagnoses;

    private static readonly CqlValueSet _Pressure_Injury_Deep_Tissue_Diagnoses = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.194", null);
    #endregion

    #region ValueSet: Pressure Injury Stage 2, 3, 4 or Unstageable
    [CqlValueSetDefinition(
        definitionName: "Pressure Injury Stage 2, 3, 4 or Unstageable",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.113",
        valueSetVersion: null)]
    public CqlValueSet Pressure_Injury_Stage_2__3__4_or_Unstageable(CqlContext context) => _Pressure_Injury_Stage_2__3__4_or_Unstageable;

    private static readonly CqlValueSet _Pressure_Injury_Stage_2__3__4_or_Unstageable = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.113", null);
    #endregion

    #region ValueSet: Pressure Injury Stage 2, 3, 4, or Unstageable Diagnoses
    [CqlValueSetDefinition(
        definitionName: "Pressure Injury Stage 2, 3, 4, or Unstageable Diagnoses",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.196",
        valueSetVersion: null)]
    public CqlValueSet Pressure_Injury_Stage_2__3__4__or_Unstageable_Diagnoses(CqlContext context) => _Pressure_Injury_Stage_2__3__4__or_Unstageable_Diagnoses;

    private static readonly CqlValueSet _Pressure_Injury_Stage_2__3__4__or_Unstageable_Diagnoses = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.196", null);
    #endregion

    #endregion ValueSets

    #region Codes

    #region Code: Physical findings of Skin
    [CqlCodeDefinition(
        definitionName: "Physical findings of Skin",
        codeId: "8709-8",
        codeSystem: "http://loinc.org")]
    public CqlCode Physical_findings_of_Skin(CqlContext context) => _Physical_findings_of_Skin;

    private static readonly CqlCode _Physical_findings_of_Skin = new CqlCode("8709-8", "http://loinc.org", default, default);
    #endregion

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition(
        definitionName: "LOINC")]
    public CqlCode[] LOINC(CqlContext context)
    {
        CqlCode[] gzzzzzzzzzzzzzzzzzl_ = [
            new CqlCode("8709-8", "http://loinc.org", default, default),
        ];

        return gzzzzzzzzzzzzzzzzzl_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime gzzzzzzzzzzzzzzzzzm_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime gzzzzzzzzzzzzzzzzzn_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzo_ = context.Operators.Interval(gzzzzzzzzzzzzzzzzzm_, gzzzzzzzzzzzzzzzzzn_, true, true);
        object gzzzzzzzzzzzzzzzzzp_ = context.ResolveParameter("HospitalHarmPressureInjuryFHIR-0.1.000", "Measurement Period", gzzzzzzzzzzzzzzzzzo_);

        return (CqlInterval<CqlDateTime>)gzzzzzzzzzzzzzzzzzp_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> gzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient gzzzzzzzzzzzzzzzzzr_ = context.Operators.SingletonFrom<Patient>(gzzzzzzzzzzzzzzzzzq_);

        return gzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with Age 18 and Older")]
    public IEnumerable<Encounter> Encounter_with_Age_18_and_Older(CqlContext context)
    {
        CqlValueSet gzzzzzzzzzzzzzzzzzs_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? gzzzzzzzzzzzzzzzzzu_(Encounter InpatientEncounter)
        {
            Patient gzzzzzzzzzzzzzzzzzw_ = this.Patient(context);
            Date gzzzzzzzzzzzzzzzzzx_ = gzzzzzzzzzzzzzzzzzw_?.BirthDateElement;
            string gzzzzzzzzzzzzzzzzzy_ = gzzzzzzzzzzzzzzzzzx_?.Value;
            CqlDate gzzzzzzzzzzzzzzzzzz_ = context.Operators.ConvertStringToDate(gzzzzzzzzzzzzzzzzzy_);
            Period hzzzzzzzzzzzzzzzzza_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzzzzzzzzza_);
            CqlDateTime hzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(hzzzzzzzzzzzzzzzzzb_);
            CqlDate hzzzzzzzzzzzzzzzzzd_ = context.Operators.DateFrom(hzzzzzzzzzzzzzzzzzc_);
            int? hzzzzzzzzzzzzzzzzze_ = context.Operators.CalculateAgeAt(gzzzzzzzzzzzzzzzzzz_, hzzzzzzzzzzzzzzzzzd_, "year");
            bool? hzzzzzzzzzzzzzzzzzf_ = context.Operators.GreaterOrEqual(hzzzzzzzzzzzzzzzzze_, 18);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzzzzzzzzza_);
            CqlDateTime hzzzzzzzzzzzzzzzzzi_ = context.Operators.End(hzzzzzzzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzj_ = this.Measurement_Period(context);
            bool? hzzzzzzzzzzzzzzzzzk_ = context.Operators.In<CqlDateTime>(hzzzzzzzzzzzzzzzzzi_, hzzzzzzzzzzzzzzzzzj_, "day");
            bool? hzzzzzzzzzzzzzzzzzl_ = context.Operators.And(hzzzzzzzzzzzzzzzzzf_, hzzzzzzzzzzzzzzzzzk_);
            Code<Encounter.EncounterStatus> hzzzzzzzzzzzzzzzzzm_ = InpatientEncounter?.StatusElement;
            Encounter.EncounterStatus? hzzzzzzzzzzzzzzzzzn_ = hzzzzzzzzzzzzzzzzzm_?.Value;
            Code<Encounter.EncounterStatus> hzzzzzzzzzzzzzzzzzo_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(hzzzzzzzzzzzzzzzzzn_);
            bool? hzzzzzzzzzzzzzzzzzp_ = context.Operators.Equal(hzzzzzzzzzzzzzzzzzo_, "finished");
            bool? hzzzzzzzzzzzzzzzzzq_ = context.Operators.And(hzzzzzzzzzzzzzzzzzl_, hzzzzzzzzzzzzzzzzzp_);

            return hzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Encounter>(gzzzzzzzzzzzzzzzzzt_, gzzzzzzzzzzzzzzzzzu_);

        return gzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzr_ = this.Encounter_with_Age_18_and_Older(context);

        return hzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzs_ = this.Initial_Population(context);

        return hzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with Deep Tissue Pressure Injury POA by Indicator")]
    public IEnumerable<Encounter> Encounter_with_Deep_Tissue_Pressure_Injury_POA_by_Indicator(CqlContext context)
    {
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzt_ = this.Encounter_with_Age_18_and_Older(context);
        bool? hzzzzzzzzzzzzzzzzzu_(Encounter InpatientHospitalization)
        {
            List<Encounter.DiagnosisComponent> hzzzzzzzzzzzzzzzzzw_ = InpatientHospitalization?.Diagnosis;
            bool? hzzzzzzzzzzzzzzzzzx_(Encounter.DiagnosisComponent EncounterDiag)
            {
                ResourceReference izzzzzzzzzzzzzzzzza_ = EncounterDiag?.Condition;
                Condition izzzzzzzzzzzzzzzzzb_ = CQMCommon_2_2_000.Instance.getCondition(context, izzzzzzzzzzzzzzzzza_);
                CodeableConcept izzzzzzzzzzzzzzzzzc_ = izzzzzzzzzzzzzzzzzb_?.Code;
                CqlConcept izzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, izzzzzzzzzzzzzzzzzc_);
                CqlValueSet izzzzzzzzzzzzzzzzze_ = this.Pressure_Injury_Deep_Tissue_Diagnoses(context);
                bool? izzzzzzzzzzzzzzzzzf_ = context.Operators.ConceptInValueSet(izzzzzzzzzzzzzzzzzd_, izzzzzzzzzzzzzzzzze_);
                bool? izzzzzzzzzzzzzzzzzg_(Extension @this)
                {
                    string izzzzzzzzzzzzzzzzzp_ = @this?.Url;
                    FhirString izzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<FhirString>(izzzzzzzzzzzzzzzzzp_);
                    string izzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToString(context, izzzzzzzzzzzzzzzzzq_);
                    bool? izzzzzzzzzzzzzzzzzs_ = context.Operators.Equal(izzzzzzzzzzzzzzzzzr_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return izzzzzzzzzzzzzzzzzs_;
                };
                IEnumerable<Extension> izzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(EncounterDiag is Element
                        ? (EncounterDiag as Element).Extension
                        : default), izzzzzzzzzzzzzzzzzg_);
                object izzzzzzzzzzzzzzzzzi_(Extension @this)
                {
                    DataType izzzzzzzzzzzzzzzzzt_ = @this?.Value;

                    return izzzzzzzzzzzzzzzzzt_;
                };
                IEnumerable<object> izzzzzzzzzzzzzzzzzj_ = context.Operators.Select<Extension, object>(izzzzzzzzzzzzzzzzzh_, izzzzzzzzzzzzzzzzzi_);
                object izzzzzzzzzzzzzzzzzk_ = context.Operators.SingletonFrom<object>(izzzzzzzzzzzzzzzzzj_);
                CqlConcept izzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, izzzzzzzzzzzzzzzzzk_ as CodeableConcept);
                CqlValueSet izzzzzzzzzzzzzzzzzm_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? izzzzzzzzzzzzzzzzzn_ = context.Operators.ConceptInValueSet(izzzzzzzzzzzzzzzzzl_, izzzzzzzzzzzzzzzzzm_);
                bool? izzzzzzzzzzzzzzzzzo_ = context.Operators.And(izzzzzzzzzzzzzzzzzf_, izzzzzzzzzzzzzzzzzn_);

                return izzzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<Encounter.DiagnosisComponent> hzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)hzzzzzzzzzzzzzzzzzw_, hzzzzzzzzzzzzzzzzzx_);
            bool? hzzzzzzzzzzzzzzzzzz_ = context.Operators.Exists<Encounter.DiagnosisComponent>(hzzzzzzzzzzzzzzzzzy_);

            return hzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Encounter>(hzzzzzzzzzzzzzzzzzt_, hzzzzzzzzzzzzzzzzzu_);

        return hzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with Deep Tissue Pressure Injury POA by Skin Exam within First 72 Hours")]
    public IEnumerable<Encounter> Encounter_with_Deep_Tissue_Pressure_Injury_POA_by_Skin_Exam_within_First_72_Hours(CqlContext context)
    {
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzu_ = this.Encounter_with_Age_18_and_Older(context);
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzv_(Encounter InpatientHospitalization)
        {
            CqlCode izzzzzzzzzzzzzzzzzx_ = this.Physical_findings_of_Skin(context);
            IEnumerable<CqlCode> izzzzzzzzzzzzzzzzzy_ = context.Operators.ToList<CqlCode>(izzzzzzzzzzzzzzzzzx_);
            IEnumerable<Observation> izzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, izzzzzzzzzzzzzzzzzy_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            bool? jzzzzzzzzzzzzzzzzza_(Observation SkinExam)
            {
                DataType jzzzzzzzzzzzzzzzzze_ = SkinExam?.Effective;
                object jzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzze_);
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzzf_);
                CqlDateTime jzzzzzzzzzzzzzzzzzh_ = context.Operators.Start(jzzzzzzzzzzzzzzzzzg_);
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzi_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, InpatientHospitalization);
                CqlDateTime jzzzzzzzzzzzzzzzzzj_ = context.Operators.Start(jzzzzzzzzzzzzzzzzzi_);
                CqlDateTime jzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(jzzzzzzzzzzzzzzzzzi_);
                CqlQuantity jzzzzzzzzzzzzzzzzzm_ = context.Operators.Quantity(72m, "hours");
                CqlDateTime jzzzzzzzzzzzzzzzzzn_ = context.Operators.Add(jzzzzzzzzzzzzzzzzzl_, jzzzzzzzzzzzzzzzzzm_);
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzo_ = context.Operators.Interval(jzzzzzzzzzzzzzzzzzj_, jzzzzzzzzzzzzzzzzzn_, true, true);
                bool? jzzzzzzzzzzzzzzzzzp_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzzzzzzzzzh_, jzzzzzzzzzzzzzzzzzo_, default);
                Code<ObservationStatus> jzzzzzzzzzzzzzzzzzq_ = SkinExam?.StatusElement;
                ObservationStatus? jzzzzzzzzzzzzzzzzzr_ = jzzzzzzzzzzzzzzzzzq_?.Value;
                Code<ObservationStatus> jzzzzzzzzzzzzzzzzzs_ = context.Operators.Convert<Code<ObservationStatus>>(jzzzzzzzzzzzzzzzzzr_);
                string jzzzzzzzzzzzzzzzzzt_ = context.Operators.Convert<string>(jzzzzzzzzzzzzzzzzzs_);
                string[] jzzzzzzzzzzzzzzzzzu_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? jzzzzzzzzzzzzzzzzzv_ = context.Operators.In<string>(jzzzzzzzzzzzzzzzzzt_, jzzzzzzzzzzzzzzzzzu_ as IEnumerable<string>);
                bool? jzzzzzzzzzzzzzzzzzw_ = context.Operators.And(jzzzzzzzzzzzzzzzzzp_, jzzzzzzzzzzzzzzzzzv_);
                CodeableConcept jzzzzzzzzzzzzzzzzzx_ = SkinExam?.Code;
                CqlConcept jzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, jzzzzzzzzzzzzzzzzzx_);
                CqlValueSet jzzzzzzzzzzzzzzzzzz_ = this.Pressure_Injury_Deep_Tissue(context);
                bool? kzzzzzzzzzzzzzzzzza_ = context.Operators.ConceptInValueSet(jzzzzzzzzzzzzzzzzzy_, jzzzzzzzzzzzzzzzzzz_);
                bool? kzzzzzzzzzzzzzzzzzb_ = context.Operators.And(jzzzzzzzzzzzzzzzzzw_, kzzzzzzzzzzzzzzzzza_);

                return kzzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<Observation> jzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Observation>(izzzzzzzzzzzzzzzzzz_, jzzzzzzzzzzzzzzzzza_);
            Encounter jzzzzzzzzzzzzzzzzzc_(Observation SkinExam) =>
                InpatientHospitalization;
            IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzd_ = context.Operators.Select<Observation, Encounter>(jzzzzzzzzzzzzzzzzzb_, jzzzzzzzzzzzzzzzzzc_);

            return jzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzw_ = context.Operators.SelectMany<Encounter, Encounter>(izzzzzzzzzzzzzzzzzu_, izzzzzzzzzzzzzzzzzv_);

        return izzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with Deep Tissue Pressure Injury POA")]
    public IEnumerable<Encounter> Encounter_with_Deep_Tissue_Pressure_Injury_POA(CqlContext context)
    {
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzc_ = this.Encounter_with_Deep_Tissue_Pressure_Injury_POA_by_Indicator(context);
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzd_ = this.Encounter_with_Deep_Tissue_Pressure_Injury_POA_by_Skin_Exam_within_First_72_Hours(context);
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzze_ = context.Operators.Union<Encounter>(kzzzzzzzzzzzzzzzzzc_, kzzzzzzzzzzzzzzzzzd_);

        return kzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with Stage 2, 3, 4, or Unstageable Pressure Injury Present on Admission by POA Indicator")]
    public IEnumerable<Encounter> Encounter_with_Stage_2__3__4__or_Unstageable_Pressure_Injury_Present_on_Admission_by_POA_Indicator(CqlContext context)
    {
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzf_ = this.Encounter_with_Age_18_and_Older(context);
        bool? kzzzzzzzzzzzzzzzzzg_(Encounter InpatientHospitalization)
        {
            List<Encounter.DiagnosisComponent> kzzzzzzzzzzzzzzzzzi_ = InpatientHospitalization?.Diagnosis;
            bool? kzzzzzzzzzzzzzzzzzj_(Encounter.DiagnosisComponent Stage234UnstageablePressureInjury)
            {
                ResourceReference kzzzzzzzzzzzzzzzzzm_ = Stage234UnstageablePressureInjury?.Condition;
                Condition kzzzzzzzzzzzzzzzzzn_ = CQMCommon_2_2_000.Instance.getCondition(context, kzzzzzzzzzzzzzzzzzm_);
                CodeableConcept kzzzzzzzzzzzzzzzzzo_ = kzzzzzzzzzzzzzzzzzn_?.Code;
                CqlConcept kzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, kzzzzzzzzzzzzzzzzzo_);
                CqlValueSet kzzzzzzzzzzzzzzzzzq_ = this.Pressure_Injury_Stage_2__3__4__or_Unstageable_Diagnoses(context);
                bool? kzzzzzzzzzzzzzzzzzr_ = context.Operators.ConceptInValueSet(kzzzzzzzzzzzzzzzzzp_, kzzzzzzzzzzzzzzzzzq_);
                bool? kzzzzzzzzzzzzzzzzzs_(Extension @this)
                {
                    string lzzzzzzzzzzzzzzzzzb_ = @this?.Url;
                    FhirString lzzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<FhirString>(lzzzzzzzzzzzzzzzzzb_);
                    string lzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToString(context, lzzzzzzzzzzzzzzzzzc_);
                    bool? lzzzzzzzzzzzzzzzzze_ = context.Operators.Equal(lzzzzzzzzzzzzzzzzzd_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return lzzzzzzzzzzzzzzzzze_;
                };
                IEnumerable<Extension> kzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Stage234UnstageablePressureInjury is Element
                        ? (Stage234UnstageablePressureInjury as Element).Extension
                        : default), kzzzzzzzzzzzzzzzzzs_);
                object kzzzzzzzzzzzzzzzzzu_(Extension @this)
                {
                    DataType lzzzzzzzzzzzzzzzzzf_ = @this?.Value;

                    return lzzzzzzzzzzzzzzzzzf_;
                };
                IEnumerable<object> kzzzzzzzzzzzzzzzzzv_ = context.Operators.Select<Extension, object>(kzzzzzzzzzzzzzzzzzt_, kzzzzzzzzzzzzzzzzzu_);
                object kzzzzzzzzzzzzzzzzzw_ = context.Operators.SingletonFrom<object>(kzzzzzzzzzzzzzzzzzv_);
                CqlConcept kzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, kzzzzzzzzzzzzzzzzzw_ as CodeableConcept);
                CqlValueSet kzzzzzzzzzzzzzzzzzy_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? kzzzzzzzzzzzzzzzzzz_ = context.Operators.ConceptInValueSet(kzzzzzzzzzzzzzzzzzx_, kzzzzzzzzzzzzzzzzzy_);
                bool? lzzzzzzzzzzzzzzzzza_ = context.Operators.And(kzzzzzzzzzzzzzzzzzr_, kzzzzzzzzzzzzzzzzzz_);

                return lzzzzzzzzzzzzzzzzza_;
            };
            IEnumerable<Encounter.DiagnosisComponent> kzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)kzzzzzzzzzzzzzzzzzi_, kzzzzzzzzzzzzzzzzzj_);
            bool? kzzzzzzzzzzzzzzzzzl_ = context.Operators.Exists<Encounter.DiagnosisComponent>(kzzzzzzzzzzzzzzzzzk_);

            return kzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Encounter>(kzzzzzzzzzzzzzzzzzf_, kzzzzzzzzzzzzzzzzzg_);

        return kzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with Stage 2, 3, 4 or Unstageable Pressure Injury POA by Skin Exam within 24 Hours")]
    public IEnumerable<Encounter> Encounter_with_Stage_2__3__4_or_Unstageable_Pressure_Injury_POA_by_Skin_Exam_within_24_Hours(CqlContext context)
    {
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzg_ = this.Encounter_with_Age_18_and_Older(context);
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzh_(Encounter InpatientHospitalization)
        {
            CqlCode lzzzzzzzzzzzzzzzzzj_ = this.Physical_findings_of_Skin(context);
            IEnumerable<CqlCode> lzzzzzzzzzzzzzzzzzk_ = context.Operators.ToList<CqlCode>(lzzzzzzzzzzzzzzzzzj_);
            IEnumerable<Observation> lzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, lzzzzzzzzzzzzzzzzzk_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            bool? lzzzzzzzzzzzzzzzzzm_(Observation SkinExam)
            {
                DataType lzzzzzzzzzzzzzzzzzq_ = SkinExam?.Effective;
                object lzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzq_);
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.ToInterval(context, lzzzzzzzzzzzzzzzzzr_);
                CqlDateTime lzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzs_);
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzu_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, InpatientHospitalization);
                CqlDateTime lzzzzzzzzzzzzzzzzzv_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzu_);
                CqlDateTime lzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzu_);
                CqlQuantity lzzzzzzzzzzzzzzzzzy_ = context.Operators.Quantity(24m, "hours");
                CqlDateTime lzzzzzzzzzzzzzzzzzz_ = context.Operators.Add(lzzzzzzzzzzzzzzzzzx_, lzzzzzzzzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzza_ = context.Operators.Interval(lzzzzzzzzzzzzzzzzzv_, lzzzzzzzzzzzzzzzzzz_, true, true);
                bool? mzzzzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDateTime>(lzzzzzzzzzzzzzzzzzt_, mzzzzzzzzzzzzzzzzza_, default);
                Code<ObservationStatus> mzzzzzzzzzzzzzzzzzc_ = SkinExam?.StatusElement;
                ObservationStatus? mzzzzzzzzzzzzzzzzzd_ = mzzzzzzzzzzzzzzzzzc_?.Value;
                Code<ObservationStatus> mzzzzzzzzzzzzzzzzze_ = context.Operators.Convert<Code<ObservationStatus>>(mzzzzzzzzzzzzzzzzzd_);
                string mzzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<string>(mzzzzzzzzzzzzzzzzze_);
                string[] mzzzzzzzzzzzzzzzzzg_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? mzzzzzzzzzzzzzzzzzh_ = context.Operators.In<string>(mzzzzzzzzzzzzzzzzzf_, mzzzzzzzzzzzzzzzzzg_ as IEnumerable<string>);
                bool? mzzzzzzzzzzzzzzzzzi_ = context.Operators.And(mzzzzzzzzzzzzzzzzzb_, mzzzzzzzzzzzzzzzzzh_);
                CodeableConcept mzzzzzzzzzzzzzzzzzj_ = SkinExam?.Code;
                CqlConcept mzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, mzzzzzzzzzzzzzzzzzj_);
                CqlValueSet mzzzzzzzzzzzzzzzzzl_ = this.Pressure_Injury_Stage_2__3__4_or_Unstageable(context);
                bool? mzzzzzzzzzzzzzzzzzm_ = context.Operators.ConceptInValueSet(mzzzzzzzzzzzzzzzzzk_, mzzzzzzzzzzzzzzzzzl_);
                bool? mzzzzzzzzzzzzzzzzzn_ = context.Operators.And(mzzzzzzzzzzzzzzzzzi_, mzzzzzzzzzzzzzzzzzm_);

                return mzzzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<Observation> lzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Observation>(lzzzzzzzzzzzzzzzzzl_, lzzzzzzzzzzzzzzzzzm_);
            Encounter lzzzzzzzzzzzzzzzzzo_(Observation SkinExam) =>
                InpatientHospitalization;
            IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzp_ = context.Operators.Select<Observation, Encounter>(lzzzzzzzzzzzzzzzzzn_, lzzzzzzzzzzzzzzzzzo_);

            return lzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzi_ = context.Operators.SelectMany<Encounter, Encounter>(lzzzzzzzzzzzzzzzzzg_, lzzzzzzzzzzzzzzzzzh_);

        return lzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with Stage 2, 3, 4 or Unstageable Pressure Injury POA")]
    public IEnumerable<Encounter> Encounter_with_Stage_2__3__4_or_Unstageable_Pressure_Injury_POA(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzo_ = this.Encounter_with_Stage_2__3__4__or_Unstageable_Pressure_Injury_Present_on_Admission_by_POA_Indicator(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzp_ = this.Encounter_with_Stage_2__3__4_or_Unstageable_Pressure_Injury_POA_by_Skin_Exam_within_24_Hours(context);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<Encounter>(mzzzzzzzzzzzzzzzzzo_, mzzzzzzzzzzzzzzzzzp_);

        return mzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with Diagnosis of COVID19 Infection")]
    public IEnumerable<Encounter> Encounter_with_Diagnosis_of_COVID19_Infection(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzr_ = this.Encounter_with_Age_18_and_Older(context);
        bool? mzzzzzzzzzzzzzzzzzs_(Encounter InpatientHospitalization)
        {
            IEnumerable<Condition> mzzzzzzzzzzzzzzzzzu_ = CQMCommon_2_2_000.Instance.EncounterDiagnosis(context, InpatientHospitalization);
            bool? mzzzzzzzzzzzzzzzzzv_(Condition EncounterDiag)
            {
                CodeableConcept mzzzzzzzzzzzzzzzzzy_ = EncounterDiag?.Code;
                CqlConcept mzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, mzzzzzzzzzzzzzzzzzy_);
                CqlValueSet nzzzzzzzzzzzzzzzzza_ = this.COVID_19(context);
                bool? nzzzzzzzzzzzzzzzzzb_ = context.Operators.ConceptInValueSet(mzzzzzzzzzzzzzzzzzz_, nzzzzzzzzzzzzzzzzza_);

                return nzzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<Condition> mzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Condition>(mzzzzzzzzzzzzzzzzzu_, mzzzzzzzzzzzzzzzzzv_);
            bool? mzzzzzzzzzzzzzzzzzx_ = context.Operators.Exists<Condition>(mzzzzzzzzzzzzzzzzzw_);

            return mzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Encounter>(mzzzzzzzzzzzzzzzzzr_, mzzzzzzzzzzzzzzzzzs_);

        return mzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context)
    {
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzc_ = this.Encounter_with_Deep_Tissue_Pressure_Injury_POA(context);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzd_ = this.Encounter_with_Stage_2__3__4_or_Unstageable_Pressure_Injury_POA(context);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzze_ = context.Operators.Union<Encounter>(nzzzzzzzzzzzzzzzzzc_, nzzzzzzzzzzzzzzzzzd_);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzf_ = this.Encounter_with_Diagnosis_of_COVID19_Infection(context);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzg_ = context.Operators.Union<Encounter>(nzzzzzzzzzzzzzzzzze_, nzzzzzzzzzzzzzzzzzf_);

        return nzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with New Deep Tissue Pressure Injury Not POA by Indicator")]
    public IEnumerable<Encounter> Encounter_with_New_Deep_Tissue_Pressure_Injury_Not_POA_by_Indicator(CqlContext context)
    {
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzh_ = this.Encounter_with_Age_18_and_Older(context);
        bool? nzzzzzzzzzzzzzzzzzi_(Encounter InpatientHospitalization)
        {
            List<Encounter.DiagnosisComponent> nzzzzzzzzzzzzzzzzzk_ = InpatientHospitalization?.Diagnosis;
            bool? nzzzzzzzzzzzzzzzzzl_(Encounter.DiagnosisComponent EncounterDiag)
            {
                ResourceReference nzzzzzzzzzzzzzzzzzo_ = EncounterDiag?.Condition;
                Condition nzzzzzzzzzzzzzzzzzp_ = CQMCommon_2_2_000.Instance.getCondition(context, nzzzzzzzzzzzzzzzzzo_);
                CodeableConcept nzzzzzzzzzzzzzzzzzq_ = nzzzzzzzzzzzzzzzzzp_?.Code;
                CqlConcept nzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, nzzzzzzzzzzzzzzzzzq_);
                CqlValueSet nzzzzzzzzzzzzzzzzzs_ = this.Pressure_Injury_Deep_Tissue_Diagnoses(context);
                bool? nzzzzzzzzzzzzzzzzzt_ = context.Operators.ConceptInValueSet(nzzzzzzzzzzzzzzzzzr_, nzzzzzzzzzzzzzzzzzs_);
                bool? nzzzzzzzzzzzzzzzzzu_(Extension @this)
                {
                    string ozzzzzzzzzzzzzzzzzd_ = @this?.Url;
                    FhirString ozzzzzzzzzzzzzzzzze_ = context.Operators.Convert<FhirString>(ozzzzzzzzzzzzzzzzzd_);
                    string ozzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToString(context, ozzzzzzzzzzzzzzzzze_);
                    bool? ozzzzzzzzzzzzzzzzzg_ = context.Operators.Equal(ozzzzzzzzzzzzzzzzzf_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return ozzzzzzzzzzzzzzzzzg_;
                };
                IEnumerable<Extension> nzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(EncounterDiag is Element
                        ? (EncounterDiag as Element).Extension
                        : default), nzzzzzzzzzzzzzzzzzu_);
                object nzzzzzzzzzzzzzzzzzw_(Extension @this)
                {
                    DataType ozzzzzzzzzzzzzzzzzh_ = @this?.Value;

                    return ozzzzzzzzzzzzzzzzzh_;
                };
                IEnumerable<object> nzzzzzzzzzzzzzzzzzx_ = context.Operators.Select<Extension, object>(nzzzzzzzzzzzzzzzzzv_, nzzzzzzzzzzzzzzzzzw_);
                object nzzzzzzzzzzzzzzzzzy_ = context.Operators.SingletonFrom<object>(nzzzzzzzzzzzzzzzzzx_);
                CqlConcept nzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, nzzzzzzzzzzzzzzzzzy_ as CodeableConcept);
                CqlValueSet ozzzzzzzzzzzzzzzzza_ = this.Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine(context);
                bool? ozzzzzzzzzzzzzzzzzb_ = context.Operators.ConceptInValueSet(nzzzzzzzzzzzzzzzzzz_, ozzzzzzzzzzzzzzzzza_);
                bool? ozzzzzzzzzzzzzzzzzc_ = context.Operators.And(nzzzzzzzzzzzzzzzzzt_, ozzzzzzzzzzzzzzzzzb_);

                return ozzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Encounter.DiagnosisComponent> nzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)nzzzzzzzzzzzzzzzzzk_, nzzzzzzzzzzzzzzzzzl_);
            bool? nzzzzzzzzzzzzzzzzzn_ = context.Operators.Exists<Encounter.DiagnosisComponent>(nzzzzzzzzzzzzzzzzzm_);

            return nzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Encounter>(nzzzzzzzzzzzzzzzzzh_, nzzzzzzzzzzzzzzzzzi_);

        return nzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with New Deep Tissue Pressure Injury by Skin Exam after First 72 Hours")]
    public IEnumerable<Encounter> Encounter_with_New_Deep_Tissue_Pressure_Injury_by_Skin_Exam_after_First_72_Hours(CqlContext context)
    {
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzi_ = this.Encounter_with_Age_18_and_Older(context);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzj_(Encounter InpatientHospitalization)
        {
            CqlCode ozzzzzzzzzzzzzzzzzl_ = this.Physical_findings_of_Skin(context);
            IEnumerable<CqlCode> ozzzzzzzzzzzzzzzzzm_ = context.Operators.ToList<CqlCode>(ozzzzzzzzzzzzzzzzzl_);
            IEnumerable<Observation> ozzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, ozzzzzzzzzzzzzzzzzm_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            bool? ozzzzzzzzzzzzzzzzzo_(Observation SkinExam)
            {
                DataType ozzzzzzzzzzzzzzzzzs_ = SkinExam?.Effective;
                object ozzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzs_);
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.ToInterval(context, ozzzzzzzzzzzzzzzzzt_);
                CqlDateTime ozzzzzzzzzzzzzzzzzv_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzu_);
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzw_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, InpatientHospitalization);
                CqlDateTime ozzzzzzzzzzzzzzzzzx_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzw_);
                CqlQuantity ozzzzzzzzzzzzzzzzzy_ = context.Operators.Quantity(72m, "hours");
                CqlDateTime ozzzzzzzzzzzzzzzzzz_ = context.Operators.Add(ozzzzzzzzzzzzzzzzzx_, ozzzzzzzzzzzzzzzzzy_);
                CqlDateTime pzzzzzzzzzzzzzzzzzb_ = context.Operators.End(ozzzzzzzzzzzzzzzzzw_);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzc_ = context.Operators.Interval(ozzzzzzzzzzzzzzzzzz_, pzzzzzzzzzzzzzzzzzb_, true, true);
                bool? pzzzzzzzzzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(ozzzzzzzzzzzzzzzzzv_, pzzzzzzzzzzzzzzzzzc_, default);
                Code<ObservationStatus> pzzzzzzzzzzzzzzzzze_ = SkinExam?.StatusElement;
                ObservationStatus? pzzzzzzzzzzzzzzzzzf_ = pzzzzzzzzzzzzzzzzze_?.Value;
                Code<ObservationStatus> pzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<Code<ObservationStatus>>(pzzzzzzzzzzzzzzzzzf_);
                string pzzzzzzzzzzzzzzzzzh_ = context.Operators.Convert<string>(pzzzzzzzzzzzzzzzzzg_);
                string[] pzzzzzzzzzzzzzzzzzi_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? pzzzzzzzzzzzzzzzzzj_ = context.Operators.In<string>(pzzzzzzzzzzzzzzzzzh_, pzzzzzzzzzzzzzzzzzi_ as IEnumerable<string>);
                bool? pzzzzzzzzzzzzzzzzzk_ = context.Operators.And(pzzzzzzzzzzzzzzzzzd_, pzzzzzzzzzzzzzzzzzj_);
                DataType pzzzzzzzzzzzzzzzzzl_ = SkinExam?.Value;
                object pzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzl_);
                CqlValueSet pzzzzzzzzzzzzzzzzzn_ = this.Pressure_Injury_Deep_Tissue(context);
                bool? pzzzzzzzzzzzzzzzzzo_ = context.Operators.ConceptInValueSet(pzzzzzzzzzzzzzzzzzm_ as CqlConcept, pzzzzzzzzzzzzzzzzzn_);
                List<Observation.ComponentComponent> pzzzzzzzzzzzzzzzzzp_ = SkinExam?.Component;
                bool? pzzzzzzzzzzzzzzzzzq_(Observation.ComponentComponent @this)
                {
                    CodeableConcept pzzzzzzzzzzzzzzzzzy_ = @this?.Code;
                    CqlConcept pzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, pzzzzzzzzzzzzzzzzzy_);
                    bool? qzzzzzzzzzzzzzzzzza_ = context.Operators.Not((bool?)(pzzzzzzzzzzzzzzzzzz_ is null));

                    return qzzzzzzzzzzzzzzzzza_;
                };
                IEnumerable<Observation.ComponentComponent> pzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)pzzzzzzzzzzzzzzzzzp_, pzzzzzzzzzzzzzzzzzq_);
                CqlConcept pzzzzzzzzzzzzzzzzzs_(Observation.ComponentComponent @this)
                {
                    CodeableConcept qzzzzzzzzzzzzzzzzzb_ = @this?.Code;
                    CqlConcept qzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, qzzzzzzzzzzzzzzzzzb_);

                    return qzzzzzzzzzzzzzzzzzc_;
                };
                IEnumerable<CqlConcept> pzzzzzzzzzzzzzzzzzt_ = context.Operators.Select<Observation.ComponentComponent, CqlConcept>(pzzzzzzzzzzzzzzzzzr_, pzzzzzzzzzzzzzzzzzs_);
                bool? pzzzzzzzzzzzzzzzzzv_ = context.Operators.ConceptsInValueSet(pzzzzzzzzzzzzzzzzzt_, pzzzzzzzzzzzzzzzzzn_);
                bool? pzzzzzzzzzzzzzzzzzw_ = context.Operators.Or(pzzzzzzzzzzzzzzzzzo_, pzzzzzzzzzzzzzzzzzv_);
                bool? pzzzzzzzzzzzzzzzzzx_ = context.Operators.And(pzzzzzzzzzzzzzzzzzk_, pzzzzzzzzzzzzzzzzzw_);

                return pzzzzzzzzzzzzzzzzzx_;
            };
            IEnumerable<Observation> ozzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Observation>(ozzzzzzzzzzzzzzzzzn_, ozzzzzzzzzzzzzzzzzo_);
            Encounter ozzzzzzzzzzzzzzzzzq_(Observation SkinExam) =>
                InpatientHospitalization;
            IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzr_ = context.Operators.Select<Observation, Encounter>(ozzzzzzzzzzzzzzzzzp_, ozzzzzzzzzzzzzzzzzq_);

            return ozzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzk_ = context.Operators.SelectMany<Encounter, Encounter>(ozzzzzzzzzzzzzzzzzi_, ozzzzzzzzzzzzzzzzzj_);

        return ozzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with New Deep Tissue Pressure Injury Not POA")]
    public IEnumerable<Encounter> Encounter_with_New_Deep_Tissue_Pressure_Injury_Not_POA(CqlContext context)
    {
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzd_ = this.Encounter_with_New_Deep_Tissue_Pressure_Injury_Not_POA_by_Indicator(context);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzze_ = this.Encounter_with_New_Deep_Tissue_Pressure_Injury_by_Skin_Exam_after_First_72_Hours(context);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzf_ = context.Operators.Union<Encounter>(qzzzzzzzzzzzzzzzzzd_, qzzzzzzzzzzzzzzzzze_);

        return qzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with New Stage 2, 3, 4 or Unstageable Pressure Injury Not POA by Indicator")]
    public IEnumerable<Encounter> Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_Not_POA_by_Indicator(CqlContext context)
    {
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzg_ = this.Encounter_with_Age_18_and_Older(context);
        bool? qzzzzzzzzzzzzzzzzzh_(Encounter InpatientHospitalization)
        {
            List<Encounter.DiagnosisComponent> qzzzzzzzzzzzzzzzzzj_ = InpatientHospitalization?.Diagnosis;
            bool? qzzzzzzzzzzzzzzzzzk_(Encounter.DiagnosisComponent Stage234UnstageablePressureInjury)
            {
                ResourceReference qzzzzzzzzzzzzzzzzzn_ = Stage234UnstageablePressureInjury?.Condition;
                Condition qzzzzzzzzzzzzzzzzzo_ = CQMCommon_2_2_000.Instance.getCondition(context, qzzzzzzzzzzzzzzzzzn_);
                CodeableConcept qzzzzzzzzzzzzzzzzzp_ = qzzzzzzzzzzzzzzzzzo_?.Code;
                CqlConcept qzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, qzzzzzzzzzzzzzzzzzp_);
                CqlValueSet qzzzzzzzzzzzzzzzzzr_ = this.Pressure_Injury_Stage_2__3__4__or_Unstageable_Diagnoses(context);
                bool? qzzzzzzzzzzzzzzzzzs_ = context.Operators.ConceptInValueSet(qzzzzzzzzzzzzzzzzzq_, qzzzzzzzzzzzzzzzzzr_);
                bool? qzzzzzzzzzzzzzzzzzt_(Extension @this)
                {
                    string rzzzzzzzzzzzzzzzzzc_ = @this?.Url;
                    FhirString rzzzzzzzzzzzzzzzzzd_ = context.Operators.Convert<FhirString>(rzzzzzzzzzzzzzzzzzc_);
                    string rzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToString(context, rzzzzzzzzzzzzzzzzzd_);
                    bool? rzzzzzzzzzzzzzzzzzf_ = context.Operators.Equal(rzzzzzzzzzzzzzzzzze_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return rzzzzzzzzzzzzzzzzzf_;
                };
                IEnumerable<Extension> qzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Stage234UnstageablePressureInjury is Element
                        ? (Stage234UnstageablePressureInjury as Element).Extension
                        : default), qzzzzzzzzzzzzzzzzzt_);
                object qzzzzzzzzzzzzzzzzzv_(Extension @this)
                {
                    DataType rzzzzzzzzzzzzzzzzzg_ = @this?.Value;

                    return rzzzzzzzzzzzzzzzzzg_;
                };
                IEnumerable<object> qzzzzzzzzzzzzzzzzzw_ = context.Operators.Select<Extension, object>(qzzzzzzzzzzzzzzzzzu_, qzzzzzzzzzzzzzzzzzv_);
                object qzzzzzzzzzzzzzzzzzx_ = context.Operators.SingletonFrom<object>(qzzzzzzzzzzzzzzzzzw_);
                CqlConcept qzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, qzzzzzzzzzzzzzzzzzx_ as CodeableConcept);
                CqlValueSet qzzzzzzzzzzzzzzzzzz_ = this.Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine(context);
                bool? rzzzzzzzzzzzzzzzzza_ = context.Operators.ConceptInValueSet(qzzzzzzzzzzzzzzzzzy_, qzzzzzzzzzzzzzzzzzz_);
                bool? rzzzzzzzzzzzzzzzzzb_ = context.Operators.And(qzzzzzzzzzzzzzzzzzs_, rzzzzzzzzzzzzzzzzza_);

                return rzzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<Encounter.DiagnosisComponent> qzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)qzzzzzzzzzzzzzzzzzj_, qzzzzzzzzzzzzzzzzzk_);
            bool? qzzzzzzzzzzzzzzzzzm_ = context.Operators.Exists<Encounter.DiagnosisComponent>(qzzzzzzzzzzzzzzzzzl_);

            return qzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Encounter>(qzzzzzzzzzzzzzzzzzg_, qzzzzzzzzzzzzzzzzzh_);

        return qzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with New Stage 2, 3, 4 or Unstageable Pressure Injury by Skin Exam after First 24 Hours")]
    public IEnumerable<Encounter> Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_by_Skin_Exam_after_First_24_Hours(CqlContext context)
    {
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzh_ = this.Encounter_with_Age_18_and_Older(context);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzi_(Encounter InpatientHospitalization)
        {
            CqlCode rzzzzzzzzzzzzzzzzzk_ = this.Physical_findings_of_Skin(context);
            IEnumerable<CqlCode> rzzzzzzzzzzzzzzzzzl_ = context.Operators.ToList<CqlCode>(rzzzzzzzzzzzzzzzzzk_);
            IEnumerable<Observation> rzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, rzzzzzzzzzzzzzzzzzl_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            bool? rzzzzzzzzzzzzzzzzzn_(Observation SkinExam)
            {
                DataType rzzzzzzzzzzzzzzzzzr_ = SkinExam?.Effective;
                object rzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.ToInterval(context, rzzzzzzzzzzzzzzzzzs_);
                CqlDateTime rzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(rzzzzzzzzzzzzzzzzzt_);
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzv_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, InpatientHospitalization);
                CqlDateTime rzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(rzzzzzzzzzzzzzzzzzv_);
                CqlQuantity rzzzzzzzzzzzzzzzzzx_ = context.Operators.Quantity(24m, "hours");
                CqlDateTime rzzzzzzzzzzzzzzzzzy_ = context.Operators.Add(rzzzzzzzzzzzzzzzzzw_, rzzzzzzzzzzzzzzzzzx_);
                CqlDateTime szzzzzzzzzzzzzzzzza_ = context.Operators.End(rzzzzzzzzzzzzzzzzzv_);
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzb_ = context.Operators.Interval(rzzzzzzzzzzzzzzzzzy_, szzzzzzzzzzzzzzzzza_, true, true);
                bool? szzzzzzzzzzzzzzzzzc_ = context.Operators.In<CqlDateTime>(rzzzzzzzzzzzzzzzzzu_, szzzzzzzzzzzzzzzzzb_, default);
                Code<ObservationStatus> szzzzzzzzzzzzzzzzzd_ = SkinExam?.StatusElement;
                ObservationStatus? szzzzzzzzzzzzzzzzze_ = szzzzzzzzzzzzzzzzzd_?.Value;
                Code<ObservationStatus> szzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<Code<ObservationStatus>>(szzzzzzzzzzzzzzzzze_);
                string szzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<string>(szzzzzzzzzzzzzzzzzf_);
                string[] szzzzzzzzzzzzzzzzzh_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? szzzzzzzzzzzzzzzzzi_ = context.Operators.In<string>(szzzzzzzzzzzzzzzzzg_, szzzzzzzzzzzzzzzzzh_ as IEnumerable<string>);
                bool? szzzzzzzzzzzzzzzzzj_ = context.Operators.And(szzzzzzzzzzzzzzzzzc_, szzzzzzzzzzzzzzzzzi_);
                DataType szzzzzzzzzzzzzzzzzk_ = SkinExam?.Value;
                object szzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzk_);
                CqlValueSet szzzzzzzzzzzzzzzzzm_ = this.Pressure_Injury_Stage_2__3__4_or_Unstageable(context);
                bool? szzzzzzzzzzzzzzzzzn_ = context.Operators.ConceptInValueSet(szzzzzzzzzzzzzzzzzl_ as CqlConcept, szzzzzzzzzzzzzzzzzm_);
                List<Observation.ComponentComponent> szzzzzzzzzzzzzzzzzo_ = SkinExam?.Component;
                bool? szzzzzzzzzzzzzzzzzp_(Observation.ComponentComponent @this)
                {
                    CodeableConcept szzzzzzzzzzzzzzzzzx_ = @this?.Code;
                    CqlConcept szzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, szzzzzzzzzzzzzzzzzx_);
                    bool? szzzzzzzzzzzzzzzzzz_ = context.Operators.Not((bool?)(szzzzzzzzzzzzzzzzzy_ is null));

                    return szzzzzzzzzzzzzzzzzz_;
                };
                IEnumerable<Observation.ComponentComponent> szzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)szzzzzzzzzzzzzzzzzo_, szzzzzzzzzzzzzzzzzp_);
                CqlConcept szzzzzzzzzzzzzzzzzr_(Observation.ComponentComponent @this)
                {
                    CodeableConcept tzzzzzzzzzzzzzzzzza_ = @this?.Code;
                    CqlConcept tzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, tzzzzzzzzzzzzzzzzza_);

                    return tzzzzzzzzzzzzzzzzzb_;
                };
                IEnumerable<CqlConcept> szzzzzzzzzzzzzzzzzs_ = context.Operators.Select<Observation.ComponentComponent, CqlConcept>(szzzzzzzzzzzzzzzzzq_, szzzzzzzzzzzzzzzzzr_);
                bool? szzzzzzzzzzzzzzzzzu_ = context.Operators.ConceptsInValueSet(szzzzzzzzzzzzzzzzzs_, szzzzzzzzzzzzzzzzzm_);
                bool? szzzzzzzzzzzzzzzzzv_ = context.Operators.Or(szzzzzzzzzzzzzzzzzn_, szzzzzzzzzzzzzzzzzu_);
                bool? szzzzzzzzzzzzzzzzzw_ = context.Operators.And(szzzzzzzzzzzzzzzzzj_, szzzzzzzzzzzzzzzzzv_);

                return szzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<Observation> rzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Observation>(rzzzzzzzzzzzzzzzzzm_, rzzzzzzzzzzzzzzzzzn_);
            Encounter rzzzzzzzzzzzzzzzzzp_(Observation SkinExam) =>
                InpatientHospitalization;
            IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzq_ = context.Operators.Select<Observation, Encounter>(rzzzzzzzzzzzzzzzzzo_, rzzzzzzzzzzzzzzzzzp_);

            return rzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzj_ = context.Operators.SelectMany<Encounter, Encounter>(rzzzzzzzzzzzzzzzzzh_, rzzzzzzzzzzzzzzzzzi_);

        return rzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with New Stage 2, 3, 4 or Unstageable Pressure Injury Not POA")]
    public IEnumerable<Encounter> Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_Not_POA(CqlContext context)
    {
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzc_ = this.Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_Not_POA_by_Indicator(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzd_ = this.Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_by_Skin_Exam_after_First_24_Hours(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzze_ = context.Operators.Union<Encounter>(tzzzzzzzzzzzzzzzzzc_, tzzzzzzzzzzzzzzzzzd_);

        return tzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzf_ = this.Encounter_with_New_Deep_Tissue_Pressure_Injury_Not_POA(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzg_ = this.Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_Not_POA(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<Encounter>(tzzzzzzzzzzzzzzzzzf_, tzzzzzzzzzzzzzzzzzg_);

        return tzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? tzzzzzzzzzzzzzzzzzi_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return tzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> tzzzzzzzzzzzzzzzzzj_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return tzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? tzzzzzzzzzzzzzzzzzk_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return tzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode tzzzzzzzzzzzzzzzzzl_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return tzzzzzzzzzzzzzzzzzl_;
    }


    #endregion Expressions

}
