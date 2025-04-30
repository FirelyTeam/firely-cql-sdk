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
        CqlDateTime qzzzzzzzzzzw_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime qzzzzzzzzzzx_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> qzzzzzzzzzzy_ = context.Operators.Interval(qzzzzzzzzzzw_, qzzzzzzzzzzx_, true, true);
        object qzzzzzzzzzzz_ = context.ResolveParameter("HospitalHarmPressureInjuryFHIR-0.1.000", "Measurement Period", qzzzzzzzzzzy_);

        return (CqlInterval<CqlDateTime>)qzzzzzzzzzzz_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> rzzzzzzzzzza_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient rzzzzzzzzzzb_ = context.Operators.SingletonFrom<Patient>(rzzzzzzzzzza_);

        return rzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Encounter with Age 18 and Older")]
    public IEnumerable<Encounter> Encounter_with_Age_18_and_Older(CqlContext context)
    {
        CqlValueSet rzzzzzzzzzzc_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> rzzzzzzzzzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? rzzzzzzzzzze_(Encounter InpatientEncounter)
        {
            Patient rzzzzzzzzzzg_ = this.Patient(context);
            Date rzzzzzzzzzzh_ = rzzzzzzzzzzg_?.BirthDateElement;
            string rzzzzzzzzzzi_ = rzzzzzzzzzzh_?.Value;
            CqlDate rzzzzzzzzzzj_ = context.Operators.ConvertStringToDate(rzzzzzzzzzzi_);
            Period rzzzzzzzzzzk_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> rzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzzk_);
            CqlDateTime rzzzzzzzzzzm_ = context.Operators.Start(rzzzzzzzzzzl_);
            CqlDate rzzzzzzzzzzn_ = context.Operators.DateFrom(rzzzzzzzzzzm_);
            int? rzzzzzzzzzzo_ = context.Operators.CalculateAgeAt(rzzzzzzzzzzj_, rzzzzzzzzzzn_, "year");
            bool? rzzzzzzzzzzp_ = context.Operators.GreaterOrEqual(rzzzzzzzzzzo_, 18);
            CqlInterval<CqlDateTime> rzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzzk_);
            CqlDateTime rzzzzzzzzzzs_ = context.Operators.End(rzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzt_ = this.Measurement_Period(context);
            bool? rzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(rzzzzzzzzzzs_, rzzzzzzzzzzt_, "day");
            bool? rzzzzzzzzzzv_ = context.Operators.And(rzzzzzzzzzzp_, rzzzzzzzzzzu_);
            Code<Encounter.EncounterStatus> rzzzzzzzzzzw_ = InpatientEncounter?.StatusElement;
            Encounter.EncounterStatus? rzzzzzzzzzzx_ = rzzzzzzzzzzw_?.Value;
            Code<Encounter.EncounterStatus> rzzzzzzzzzzy_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(rzzzzzzzzzzx_);
            bool? rzzzzzzzzzzz_ = context.Operators.Equal(rzzzzzzzzzzy_, "finished");
            bool? szzzzzzzzzza_ = context.Operators.And(rzzzzzzzzzzv_, rzzzzzzzzzzz_);

            return szzzzzzzzzza_;
        };
        IEnumerable<Encounter> rzzzzzzzzzzf_ = context.Operators.Where<Encounter>(rzzzzzzzzzzd_, rzzzzzzzzzze_);

        return rzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> szzzzzzzzzzb_ = this.Encounter_with_Age_18_and_Older(context);

        return szzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> szzzzzzzzzzc_ = this.Initial_Population(context);

        return szzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Encounter with Deep Tissue Pressure Injury POA by Indicator")]
    public IEnumerable<Encounter> Encounter_with_Deep_Tissue_Pressure_Injury_POA_by_Indicator(CqlContext context)
    {
        IEnumerable<Encounter> szzzzzzzzzzd_ = this.Encounter_with_Age_18_and_Older(context);
        bool? szzzzzzzzzze_(Encounter InpatientHospitalization)
        {
            List<Encounter.DiagnosisComponent> szzzzzzzzzzg_ = InpatientHospitalization?.Diagnosis;
            bool? szzzzzzzzzzh_(Encounter.DiagnosisComponent EncounterDiag)
            {
                ResourceReference szzzzzzzzzzk_ = EncounterDiag?.Condition;
                Condition szzzzzzzzzzl_ = CQMCommon_2_2_000.Instance.getCondition(context, szzzzzzzzzzk_);
                CodeableConcept szzzzzzzzzzm_ = szzzzzzzzzzl_?.Code;
                CqlConcept szzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, szzzzzzzzzzm_);
                CqlValueSet szzzzzzzzzzo_ = this.Pressure_Injury_Deep_Tissue_Diagnoses(context);
                bool? szzzzzzzzzzp_ = context.Operators.ConceptInValueSet(szzzzzzzzzzn_, szzzzzzzzzzo_);
                bool? szzzzzzzzzzq_(Extension @this)
                {
                    string szzzzzzzzzzz_ = @this?.Url;
                    FhirString tzzzzzzzzzza_ = context.Operators.Convert<FhirString>(szzzzzzzzzzz_);
                    string tzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToString(context, tzzzzzzzzzza_);
                    bool? tzzzzzzzzzzc_ = context.Operators.Equal(tzzzzzzzzzzb_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return tzzzzzzzzzzc_;
                };
                IEnumerable<Extension> szzzzzzzzzzr_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(EncounterDiag is Element
                        ? (EncounterDiag as Element).Extension
                        : default), szzzzzzzzzzq_);
                object szzzzzzzzzzs_(Extension @this)
                {
                    DataType tzzzzzzzzzzd_ = @this?.Value;

                    return tzzzzzzzzzzd_;
                };
                IEnumerable<object> szzzzzzzzzzt_ = context.Operators.Select<Extension, object>(szzzzzzzzzzr_, szzzzzzzzzzs_);
                object szzzzzzzzzzu_ = context.Operators.SingletonFrom<object>(szzzzzzzzzzt_);
                CqlConcept szzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, szzzzzzzzzzu_ as CodeableConcept);
                CqlValueSet szzzzzzzzzzw_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? szzzzzzzzzzx_ = context.Operators.ConceptInValueSet(szzzzzzzzzzv_, szzzzzzzzzzw_);
                bool? szzzzzzzzzzy_ = context.Operators.And(szzzzzzzzzzp_, szzzzzzzzzzx_);

                return szzzzzzzzzzy_;
            };
            IEnumerable<Encounter.DiagnosisComponent> szzzzzzzzzzi_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)szzzzzzzzzzg_, szzzzzzzzzzh_);
            bool? szzzzzzzzzzj_ = context.Operators.Exists<Encounter.DiagnosisComponent>(szzzzzzzzzzi_);

            return szzzzzzzzzzj_;
        };
        IEnumerable<Encounter> szzzzzzzzzzf_ = context.Operators.Where<Encounter>(szzzzzzzzzzd_, szzzzzzzzzze_);

        return szzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Encounter with Deep Tissue Pressure Injury POA by Skin Exam within First 72 Hours")]
    public IEnumerable<Encounter> Encounter_with_Deep_Tissue_Pressure_Injury_POA_by_Skin_Exam_within_First_72_Hours(CqlContext context)
    {
        IEnumerable<Encounter> tzzzzzzzzzze_ = this.Encounter_with_Age_18_and_Older(context);
        IEnumerable<Encounter> tzzzzzzzzzzf_(Encounter InpatientHospitalization)
        {
            CqlCode tzzzzzzzzzzh_ = this.Physical_findings_of_Skin(context);
            IEnumerable<CqlCode> tzzzzzzzzzzi_ = context.Operators.ToList<CqlCode>(tzzzzzzzzzzh_);
            IEnumerable<Observation> tzzzzzzzzzzj_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, tzzzzzzzzzzi_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            bool? tzzzzzzzzzzk_(Observation SkinExam)
            {
                DataType tzzzzzzzzzzo_ = SkinExam?.Effective;
                object tzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> tzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.ToInterval(context, tzzzzzzzzzzp_);
                CqlDateTime tzzzzzzzzzzr_ = context.Operators.Start(tzzzzzzzzzzq_);
                CqlInterval<CqlDateTime> tzzzzzzzzzzs_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, InpatientHospitalization);
                CqlDateTime tzzzzzzzzzzt_ = context.Operators.Start(tzzzzzzzzzzs_);
                CqlDateTime tzzzzzzzzzzv_ = context.Operators.Start(tzzzzzzzzzzs_);
                CqlQuantity tzzzzzzzzzzw_ = context.Operators.Quantity(72m, "hours");
                CqlDateTime tzzzzzzzzzzx_ = context.Operators.Add(tzzzzzzzzzzv_, tzzzzzzzzzzw_);
                CqlInterval<CqlDateTime> tzzzzzzzzzzy_ = context.Operators.Interval(tzzzzzzzzzzt_, tzzzzzzzzzzx_, true, true);
                bool? tzzzzzzzzzzz_ = context.Operators.In<CqlDateTime>(tzzzzzzzzzzr_, tzzzzzzzzzzy_, default);
                Code<ObservationStatus> uzzzzzzzzzza_ = SkinExam?.StatusElement;
                ObservationStatus? uzzzzzzzzzzb_ = uzzzzzzzzzza_?.Value;
                Code<ObservationStatus> uzzzzzzzzzzc_ = context.Operators.Convert<Code<ObservationStatus>>(uzzzzzzzzzzb_);
                string uzzzzzzzzzzd_ = context.Operators.Convert<string>(uzzzzzzzzzzc_);
                string[] uzzzzzzzzzze_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? uzzzzzzzzzzf_ = context.Operators.In<string>(uzzzzzzzzzzd_, uzzzzzzzzzze_ as IEnumerable<string>);
                bool? uzzzzzzzzzzg_ = context.Operators.And(tzzzzzzzzzzz_, uzzzzzzzzzzf_);
                CodeableConcept uzzzzzzzzzzh_ = SkinExam?.Code;
                CqlConcept uzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, uzzzzzzzzzzh_);
                CqlValueSet uzzzzzzzzzzj_ = this.Pressure_Injury_Deep_Tissue(context);
                bool? uzzzzzzzzzzk_ = context.Operators.ConceptInValueSet(uzzzzzzzzzzi_, uzzzzzzzzzzj_);
                bool? uzzzzzzzzzzl_ = context.Operators.And(uzzzzzzzzzzg_, uzzzzzzzzzzk_);

                return uzzzzzzzzzzl_;
            };
            IEnumerable<Observation> tzzzzzzzzzzl_ = context.Operators.Where<Observation>(tzzzzzzzzzzj_, tzzzzzzzzzzk_);
            Encounter tzzzzzzzzzzm_(Observation SkinExam) =>
                InpatientHospitalization;
            IEnumerable<Encounter> tzzzzzzzzzzn_ = context.Operators.Select<Observation, Encounter>(tzzzzzzzzzzl_, tzzzzzzzzzzm_);

            return tzzzzzzzzzzn_;
        };
        IEnumerable<Encounter> tzzzzzzzzzzg_ = context.Operators.SelectMany<Encounter, Encounter>(tzzzzzzzzzze_, tzzzzzzzzzzf_);

        return tzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Encounter with Deep Tissue Pressure Injury POA")]
    public IEnumerable<Encounter> Encounter_with_Deep_Tissue_Pressure_Injury_POA(CqlContext context)
    {
        IEnumerable<Encounter> uzzzzzzzzzzm_ = this.Encounter_with_Deep_Tissue_Pressure_Injury_POA_by_Indicator(context);
        IEnumerable<Encounter> uzzzzzzzzzzn_ = this.Encounter_with_Deep_Tissue_Pressure_Injury_POA_by_Skin_Exam_within_First_72_Hours(context);
        IEnumerable<Encounter> uzzzzzzzzzzo_ = context.Operators.Union<Encounter>(uzzzzzzzzzzm_, uzzzzzzzzzzn_);

        return uzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Encounter with Stage 2, 3, 4, or Unstageable Pressure Injury Present on Admission by POA Indicator")]
    public IEnumerable<Encounter> Encounter_with_Stage_2__3__4__or_Unstageable_Pressure_Injury_Present_on_Admission_by_POA_Indicator(CqlContext context)
    {
        IEnumerable<Encounter> uzzzzzzzzzzp_ = this.Encounter_with_Age_18_and_Older(context);
        bool? uzzzzzzzzzzq_(Encounter InpatientHospitalization)
        {
            List<Encounter.DiagnosisComponent> uzzzzzzzzzzs_ = InpatientHospitalization?.Diagnosis;
            bool? uzzzzzzzzzzt_(Encounter.DiagnosisComponent Stage234UnstageablePressureInjury)
            {
                ResourceReference uzzzzzzzzzzw_ = Stage234UnstageablePressureInjury?.Condition;
                Condition uzzzzzzzzzzx_ = CQMCommon_2_2_000.Instance.getCondition(context, uzzzzzzzzzzw_);
                CodeableConcept uzzzzzzzzzzy_ = uzzzzzzzzzzx_?.Code;
                CqlConcept uzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, uzzzzzzzzzzy_);
                CqlValueSet vzzzzzzzzzza_ = this.Pressure_Injury_Stage_2__3__4__or_Unstageable_Diagnoses(context);
                bool? vzzzzzzzzzzb_ = context.Operators.ConceptInValueSet(uzzzzzzzzzzz_, vzzzzzzzzzza_);
                bool? vzzzzzzzzzzc_(Extension @this)
                {
                    string vzzzzzzzzzzl_ = @this?.Url;
                    FhirString vzzzzzzzzzzm_ = context.Operators.Convert<FhirString>(vzzzzzzzzzzl_);
                    string vzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToString(context, vzzzzzzzzzzm_);
                    bool? vzzzzzzzzzzo_ = context.Operators.Equal(vzzzzzzzzzzn_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return vzzzzzzzzzzo_;
                };
                IEnumerable<Extension> vzzzzzzzzzzd_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Stage234UnstageablePressureInjury is Element
                        ? (Stage234UnstageablePressureInjury as Element).Extension
                        : default), vzzzzzzzzzzc_);
                object vzzzzzzzzzze_(Extension @this)
                {
                    DataType vzzzzzzzzzzp_ = @this?.Value;

                    return vzzzzzzzzzzp_;
                };
                IEnumerable<object> vzzzzzzzzzzf_ = context.Operators.Select<Extension, object>(vzzzzzzzzzzd_, vzzzzzzzzzze_);
                object vzzzzzzzzzzg_ = context.Operators.SingletonFrom<object>(vzzzzzzzzzzf_);
                CqlConcept vzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, vzzzzzzzzzzg_ as CodeableConcept);
                CqlValueSet vzzzzzzzzzzi_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? vzzzzzzzzzzj_ = context.Operators.ConceptInValueSet(vzzzzzzzzzzh_, vzzzzzzzzzzi_);
                bool? vzzzzzzzzzzk_ = context.Operators.And(vzzzzzzzzzzb_, vzzzzzzzzzzj_);

                return vzzzzzzzzzzk_;
            };
            IEnumerable<Encounter.DiagnosisComponent> uzzzzzzzzzzu_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)uzzzzzzzzzzs_, uzzzzzzzzzzt_);
            bool? uzzzzzzzzzzv_ = context.Operators.Exists<Encounter.DiagnosisComponent>(uzzzzzzzzzzu_);

            return uzzzzzzzzzzv_;
        };
        IEnumerable<Encounter> uzzzzzzzzzzr_ = context.Operators.Where<Encounter>(uzzzzzzzzzzp_, uzzzzzzzzzzq_);

        return uzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Encounter with Stage 2, 3, 4 or Unstageable Pressure Injury POA by Skin Exam within 24 Hours")]
    public IEnumerable<Encounter> Encounter_with_Stage_2__3__4_or_Unstageable_Pressure_Injury_POA_by_Skin_Exam_within_24_Hours(CqlContext context)
    {
        IEnumerable<Encounter> vzzzzzzzzzzq_ = this.Encounter_with_Age_18_and_Older(context);
        IEnumerable<Encounter> vzzzzzzzzzzr_(Encounter InpatientHospitalization)
        {
            CqlCode vzzzzzzzzzzt_ = this.Physical_findings_of_Skin(context);
            IEnumerable<CqlCode> vzzzzzzzzzzu_ = context.Operators.ToList<CqlCode>(vzzzzzzzzzzt_);
            IEnumerable<Observation> vzzzzzzzzzzv_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, vzzzzzzzzzzu_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            bool? vzzzzzzzzzzw_(Observation SkinExam)
            {
                DataType wzzzzzzzzzza_ = SkinExam?.Effective;
                object wzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzza_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.ToInterval(context, wzzzzzzzzzzb_);
                CqlDateTime wzzzzzzzzzzd_ = context.Operators.Start(wzzzzzzzzzzc_);
                CqlInterval<CqlDateTime> wzzzzzzzzzze_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, InpatientHospitalization);
                CqlDateTime wzzzzzzzzzzf_ = context.Operators.Start(wzzzzzzzzzze_);
                CqlDateTime wzzzzzzzzzzh_ = context.Operators.Start(wzzzzzzzzzze_);
                CqlQuantity wzzzzzzzzzzi_ = context.Operators.Quantity(24m, "hours");
                CqlDateTime wzzzzzzzzzzj_ = context.Operators.Add(wzzzzzzzzzzh_, wzzzzzzzzzzi_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzk_ = context.Operators.Interval(wzzzzzzzzzzf_, wzzzzzzzzzzj_, true, true);
                bool? wzzzzzzzzzzl_ = context.Operators.In<CqlDateTime>(wzzzzzzzzzzd_, wzzzzzzzzzzk_, default);
                Code<ObservationStatus> wzzzzzzzzzzm_ = SkinExam?.StatusElement;
                ObservationStatus? wzzzzzzzzzzn_ = wzzzzzzzzzzm_?.Value;
                Code<ObservationStatus> wzzzzzzzzzzo_ = context.Operators.Convert<Code<ObservationStatus>>(wzzzzzzzzzzn_);
                string wzzzzzzzzzzp_ = context.Operators.Convert<string>(wzzzzzzzzzzo_);
                string[] wzzzzzzzzzzq_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? wzzzzzzzzzzr_ = context.Operators.In<string>(wzzzzzzzzzzp_, wzzzzzzzzzzq_ as IEnumerable<string>);
                bool? wzzzzzzzzzzs_ = context.Operators.And(wzzzzzzzzzzl_, wzzzzzzzzzzr_);
                CodeableConcept wzzzzzzzzzzt_ = SkinExam?.Code;
                CqlConcept wzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, wzzzzzzzzzzt_);
                CqlValueSet wzzzzzzzzzzv_ = this.Pressure_Injury_Stage_2__3__4_or_Unstageable(context);
                bool? wzzzzzzzzzzw_ = context.Operators.ConceptInValueSet(wzzzzzzzzzzu_, wzzzzzzzzzzv_);
                bool? wzzzzzzzzzzx_ = context.Operators.And(wzzzzzzzzzzs_, wzzzzzzzzzzw_);

                return wzzzzzzzzzzx_;
            };
            IEnumerable<Observation> vzzzzzzzzzzx_ = context.Operators.Where<Observation>(vzzzzzzzzzzv_, vzzzzzzzzzzw_);
            Encounter vzzzzzzzzzzy_(Observation SkinExam) =>
                InpatientHospitalization;
            IEnumerable<Encounter> vzzzzzzzzzzz_ = context.Operators.Select<Observation, Encounter>(vzzzzzzzzzzx_, vzzzzzzzzzzy_);

            return vzzzzzzzzzzz_;
        };
        IEnumerable<Encounter> vzzzzzzzzzzs_ = context.Operators.SelectMany<Encounter, Encounter>(vzzzzzzzzzzq_, vzzzzzzzzzzr_);

        return vzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Encounter with Stage 2, 3, 4 or Unstageable Pressure Injury POA")]
    public IEnumerable<Encounter> Encounter_with_Stage_2__3__4_or_Unstageable_Pressure_Injury_POA(CqlContext context)
    {
        IEnumerable<Encounter> wzzzzzzzzzzy_ = this.Encounter_with_Stage_2__3__4__or_Unstageable_Pressure_Injury_Present_on_Admission_by_POA_Indicator(context);
        IEnumerable<Encounter> wzzzzzzzzzzz_ = this.Encounter_with_Stage_2__3__4_or_Unstageable_Pressure_Injury_POA_by_Skin_Exam_within_24_Hours(context);
        IEnumerable<Encounter> xzzzzzzzzzza_ = context.Operators.Union<Encounter>(wzzzzzzzzzzy_, wzzzzzzzzzzz_);

        return xzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Encounter with Diagnosis of COVID19 Infection")]
    public IEnumerable<Encounter> Encounter_with_Diagnosis_of_COVID19_Infection(CqlContext context)
    {
        IEnumerable<Encounter> xzzzzzzzzzzb_ = this.Encounter_with_Age_18_and_Older(context);
        bool? xzzzzzzzzzzc_(Encounter InpatientHospitalization)
        {
            IEnumerable<Condition> xzzzzzzzzzze_ = CQMCommon_2_2_000.Instance.EncounterDiagnosis(context, InpatientHospitalization);
            bool? xzzzzzzzzzzf_(Condition EncounterDiag)
            {
                CodeableConcept xzzzzzzzzzzi_ = EncounterDiag?.Code;
                CqlConcept xzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, xzzzzzzzzzzi_);
                CqlValueSet xzzzzzzzzzzk_ = this.COVID_19(context);
                bool? xzzzzzzzzzzl_ = context.Operators.ConceptInValueSet(xzzzzzzzzzzj_, xzzzzzzzzzzk_);

                return xzzzzzzzzzzl_;
            };
            IEnumerable<Condition> xzzzzzzzzzzg_ = context.Operators.Where<Condition>(xzzzzzzzzzze_, xzzzzzzzzzzf_);
            bool? xzzzzzzzzzzh_ = context.Operators.Exists<Condition>(xzzzzzzzzzzg_);

            return xzzzzzzzzzzh_;
        };
        IEnumerable<Encounter> xzzzzzzzzzzd_ = context.Operators.Where<Encounter>(xzzzzzzzzzzb_, xzzzzzzzzzzc_);

        return xzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context)
    {
        IEnumerable<Encounter> xzzzzzzzzzzm_ = this.Encounter_with_Deep_Tissue_Pressure_Injury_POA(context);
        IEnumerable<Encounter> xzzzzzzzzzzn_ = this.Encounter_with_Stage_2__3__4_or_Unstageable_Pressure_Injury_POA(context);
        IEnumerable<Encounter> xzzzzzzzzzzo_ = context.Operators.Union<Encounter>(xzzzzzzzzzzm_, xzzzzzzzzzzn_);
        IEnumerable<Encounter> xzzzzzzzzzzp_ = this.Encounter_with_Diagnosis_of_COVID19_Infection(context);
        IEnumerable<Encounter> xzzzzzzzzzzq_ = context.Operators.Union<Encounter>(xzzzzzzzzzzo_, xzzzzzzzzzzp_);

        return xzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Encounter with New Deep Tissue Pressure Injury Not POA by Indicator")]
    public IEnumerable<Encounter> Encounter_with_New_Deep_Tissue_Pressure_Injury_Not_POA_by_Indicator(CqlContext context)
    {
        IEnumerable<Encounter> xzzzzzzzzzzr_ = this.Encounter_with_Age_18_and_Older(context);
        bool? xzzzzzzzzzzs_(Encounter InpatientHospitalization)
        {
            List<Encounter.DiagnosisComponent> xzzzzzzzzzzu_ = InpatientHospitalization?.Diagnosis;
            bool? xzzzzzzzzzzv_(Encounter.DiagnosisComponent EncounterDiag)
            {
                ResourceReference xzzzzzzzzzzy_ = EncounterDiag?.Condition;
                Condition xzzzzzzzzzzz_ = CQMCommon_2_2_000.Instance.getCondition(context, xzzzzzzzzzzy_);
                CodeableConcept yzzzzzzzzzza_ = xzzzzzzzzzzz_?.Code;
                CqlConcept yzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, yzzzzzzzzzza_);
                CqlValueSet yzzzzzzzzzzc_ = this.Pressure_Injury_Deep_Tissue_Diagnoses(context);
                bool? yzzzzzzzzzzd_ = context.Operators.ConceptInValueSet(yzzzzzzzzzzb_, yzzzzzzzzzzc_);
                bool? yzzzzzzzzzze_(Extension @this)
                {
                    string yzzzzzzzzzzn_ = @this?.Url;
                    FhirString yzzzzzzzzzzo_ = context.Operators.Convert<FhirString>(yzzzzzzzzzzn_);
                    string yzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToString(context, yzzzzzzzzzzo_);
                    bool? yzzzzzzzzzzq_ = context.Operators.Equal(yzzzzzzzzzzp_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return yzzzzzzzzzzq_;
                };
                IEnumerable<Extension> yzzzzzzzzzzf_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(EncounterDiag is Element
                        ? (EncounterDiag as Element).Extension
                        : default), yzzzzzzzzzze_);
                object yzzzzzzzzzzg_(Extension @this)
                {
                    DataType yzzzzzzzzzzr_ = @this?.Value;

                    return yzzzzzzzzzzr_;
                };
                IEnumerable<object> yzzzzzzzzzzh_ = context.Operators.Select<Extension, object>(yzzzzzzzzzzf_, yzzzzzzzzzzg_);
                object yzzzzzzzzzzi_ = context.Operators.SingletonFrom<object>(yzzzzzzzzzzh_);
                CqlConcept yzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, yzzzzzzzzzzi_ as CodeableConcept);
                CqlValueSet yzzzzzzzzzzk_ = this.Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine(context);
                bool? yzzzzzzzzzzl_ = context.Operators.ConceptInValueSet(yzzzzzzzzzzj_, yzzzzzzzzzzk_);
                bool? yzzzzzzzzzzm_ = context.Operators.And(yzzzzzzzzzzd_, yzzzzzzzzzzl_);

                return yzzzzzzzzzzm_;
            };
            IEnumerable<Encounter.DiagnosisComponent> xzzzzzzzzzzw_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)xzzzzzzzzzzu_, xzzzzzzzzzzv_);
            bool? xzzzzzzzzzzx_ = context.Operators.Exists<Encounter.DiagnosisComponent>(xzzzzzzzzzzw_);

            return xzzzzzzzzzzx_;
        };
        IEnumerable<Encounter> xzzzzzzzzzzt_ = context.Operators.Where<Encounter>(xzzzzzzzzzzr_, xzzzzzzzzzzs_);

        return xzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Encounter with New Deep Tissue Pressure Injury by Skin Exam after First 72 Hours")]
    public IEnumerable<Encounter> Encounter_with_New_Deep_Tissue_Pressure_Injury_by_Skin_Exam_after_First_72_Hours(CqlContext context)
    {
        IEnumerable<Encounter> yzzzzzzzzzzs_ = this.Encounter_with_Age_18_and_Older(context);
        IEnumerable<Encounter> yzzzzzzzzzzt_(Encounter InpatientHospitalization)
        {
            CqlCode yzzzzzzzzzzv_ = this.Physical_findings_of_Skin(context);
            IEnumerable<CqlCode> yzzzzzzzzzzw_ = context.Operators.ToList<CqlCode>(yzzzzzzzzzzv_);
            IEnumerable<Observation> yzzzzzzzzzzx_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, yzzzzzzzzzzw_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            bool? yzzzzzzzzzzy_(Observation SkinExam)
            {
                DataType zzzzzzzzzzzc_ = SkinExam?.Effective;
                object zzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzc_);
                CqlInterval<CqlDateTime> zzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.ToInterval(context, zzzzzzzzzzzd_);
                CqlDateTime zzzzzzzzzzzf_ = context.Operators.Start(zzzzzzzzzzze_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzg_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, InpatientHospitalization);
                CqlDateTime zzzzzzzzzzzh_ = context.Operators.Start(zzzzzzzzzzzg_);
                CqlQuantity zzzzzzzzzzzi_ = context.Operators.Quantity(72m, "hours");
                CqlDateTime zzzzzzzzzzzj_ = context.Operators.Add(zzzzzzzzzzzh_, zzzzzzzzzzzi_);
                CqlDateTime zzzzzzzzzzzl_ = context.Operators.End(zzzzzzzzzzzg_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzm_ = context.Operators.Interval(zzzzzzzzzzzj_, zzzzzzzzzzzl_, true, true);
                bool? zzzzzzzzzzzn_ = context.Operators.In<CqlDateTime>(zzzzzzzzzzzf_, zzzzzzzzzzzm_, default);
                Code<ObservationStatus> zzzzzzzzzzzo_ = SkinExam?.StatusElement;
                ObservationStatus? zzzzzzzzzzzp_ = zzzzzzzzzzzo_?.Value;
                Code<ObservationStatus> zzzzzzzzzzzq_ = context.Operators.Convert<Code<ObservationStatus>>(zzzzzzzzzzzp_);
                string zzzzzzzzzzzr_ = context.Operators.Convert<string>(zzzzzzzzzzzq_);
                string[] zzzzzzzzzzzs_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? zzzzzzzzzzzt_ = context.Operators.In<string>(zzzzzzzzzzzr_, zzzzzzzzzzzs_ as IEnumerable<string>);
                bool? zzzzzzzzzzzu_ = context.Operators.And(zzzzzzzzzzzn_, zzzzzzzzzzzt_);
                DataType zzzzzzzzzzzv_ = SkinExam?.Value;
                object zzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzv_);
                CqlValueSet zzzzzzzzzzzx_ = this.Pressure_Injury_Deep_Tissue(context);
                bool? zzzzzzzzzzzy_ = context.Operators.ConceptInValueSet(zzzzzzzzzzzw_ as CqlConcept, zzzzzzzzzzzx_);
                List<Observation.ComponentComponent> zzzzzzzzzzzz_ = SkinExam?.Component;
                bool? azzzzzzzzzzza_(Observation.ComponentComponent @this)
                {
                    CodeableConcept azzzzzzzzzzzi_ = @this?.Code;
                    CqlConcept azzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, azzzzzzzzzzzi_);
                    bool? azzzzzzzzzzzk_ = context.Operators.Not((bool?)(azzzzzzzzzzzj_ is null));

                    return azzzzzzzzzzzk_;
                };
                IEnumerable<Observation.ComponentComponent> azzzzzzzzzzzb_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)zzzzzzzzzzzz_, azzzzzzzzzzza_);
                CqlConcept azzzzzzzzzzzc_(Observation.ComponentComponent @this)
                {
                    CodeableConcept azzzzzzzzzzzl_ = @this?.Code;
                    CqlConcept azzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, azzzzzzzzzzzl_);

                    return azzzzzzzzzzzm_;
                };
                IEnumerable<CqlConcept> azzzzzzzzzzzd_ = context.Operators.Select<Observation.ComponentComponent, CqlConcept>(azzzzzzzzzzzb_, azzzzzzzzzzzc_);
                bool? azzzzzzzzzzzf_ = context.Operators.ConceptsInValueSet(azzzzzzzzzzzd_, zzzzzzzzzzzx_);
                bool? azzzzzzzzzzzg_ = context.Operators.Or(zzzzzzzzzzzy_, azzzzzzzzzzzf_);
                bool? azzzzzzzzzzzh_ = context.Operators.And(zzzzzzzzzzzu_, azzzzzzzzzzzg_);

                return azzzzzzzzzzzh_;
            };
            IEnumerable<Observation> yzzzzzzzzzzz_ = context.Operators.Where<Observation>(yzzzzzzzzzzx_, yzzzzzzzzzzy_);
            Encounter zzzzzzzzzzza_(Observation SkinExam) =>
                InpatientHospitalization;
            IEnumerable<Encounter> zzzzzzzzzzzb_ = context.Operators.Select<Observation, Encounter>(yzzzzzzzzzzz_, zzzzzzzzzzza_);

            return zzzzzzzzzzzb_;
        };
        IEnumerable<Encounter> yzzzzzzzzzzu_ = context.Operators.SelectMany<Encounter, Encounter>(yzzzzzzzzzzs_, yzzzzzzzzzzt_);

        return yzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Encounter with New Deep Tissue Pressure Injury Not POA")]
    public IEnumerable<Encounter> Encounter_with_New_Deep_Tissue_Pressure_Injury_Not_POA(CqlContext context)
    {
        IEnumerable<Encounter> azzzzzzzzzzzn_ = this.Encounter_with_New_Deep_Tissue_Pressure_Injury_Not_POA_by_Indicator(context);
        IEnumerable<Encounter> azzzzzzzzzzzo_ = this.Encounter_with_New_Deep_Tissue_Pressure_Injury_by_Skin_Exam_after_First_72_Hours(context);
        IEnumerable<Encounter> azzzzzzzzzzzp_ = context.Operators.Union<Encounter>(azzzzzzzzzzzn_, azzzzzzzzzzzo_);

        return azzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Encounter with New Stage 2, 3, 4 or Unstageable Pressure Injury Not POA by Indicator")]
    public IEnumerable<Encounter> Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_Not_POA_by_Indicator(CqlContext context)
    {
        IEnumerable<Encounter> azzzzzzzzzzzq_ = this.Encounter_with_Age_18_and_Older(context);
        bool? azzzzzzzzzzzr_(Encounter InpatientHospitalization)
        {
            List<Encounter.DiagnosisComponent> azzzzzzzzzzzt_ = InpatientHospitalization?.Diagnosis;
            bool? azzzzzzzzzzzu_(Encounter.DiagnosisComponent Stage234UnstageablePressureInjury)
            {
                ResourceReference azzzzzzzzzzzx_ = Stage234UnstageablePressureInjury?.Condition;
                Condition azzzzzzzzzzzy_ = CQMCommon_2_2_000.Instance.getCondition(context, azzzzzzzzzzzx_);
                CodeableConcept azzzzzzzzzzzz_ = azzzzzzzzzzzy_?.Code;
                CqlConcept bzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, azzzzzzzzzzzz_);
                CqlValueSet bzzzzzzzzzzzb_ = this.Pressure_Injury_Stage_2__3__4__or_Unstageable_Diagnoses(context);
                bool? bzzzzzzzzzzzc_ = context.Operators.ConceptInValueSet(bzzzzzzzzzzza_, bzzzzzzzzzzzb_);
                bool? bzzzzzzzzzzzd_(Extension @this)
                {
                    string bzzzzzzzzzzzm_ = @this?.Url;
                    FhirString bzzzzzzzzzzzn_ = context.Operators.Convert<FhirString>(bzzzzzzzzzzzm_);
                    string bzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToString(context, bzzzzzzzzzzzn_);
                    bool? bzzzzzzzzzzzp_ = context.Operators.Equal(bzzzzzzzzzzzo_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return bzzzzzzzzzzzp_;
                };
                IEnumerable<Extension> bzzzzzzzzzzze_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Stage234UnstageablePressureInjury is Element
                        ? (Stage234UnstageablePressureInjury as Element).Extension
                        : default), bzzzzzzzzzzzd_);
                object bzzzzzzzzzzzf_(Extension @this)
                {
                    DataType bzzzzzzzzzzzq_ = @this?.Value;

                    return bzzzzzzzzzzzq_;
                };
                IEnumerable<object> bzzzzzzzzzzzg_ = context.Operators.Select<Extension, object>(bzzzzzzzzzzze_, bzzzzzzzzzzzf_);
                object bzzzzzzzzzzzh_ = context.Operators.SingletonFrom<object>(bzzzzzzzzzzzg_);
                CqlConcept bzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bzzzzzzzzzzzh_ as CodeableConcept);
                CqlValueSet bzzzzzzzzzzzj_ = this.Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine(context);
                bool? bzzzzzzzzzzzk_ = context.Operators.ConceptInValueSet(bzzzzzzzzzzzi_, bzzzzzzzzzzzj_);
                bool? bzzzzzzzzzzzl_ = context.Operators.And(bzzzzzzzzzzzc_, bzzzzzzzzzzzk_);

                return bzzzzzzzzzzzl_;
            };
            IEnumerable<Encounter.DiagnosisComponent> azzzzzzzzzzzv_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)azzzzzzzzzzzt_, azzzzzzzzzzzu_);
            bool? azzzzzzzzzzzw_ = context.Operators.Exists<Encounter.DiagnosisComponent>(azzzzzzzzzzzv_);

            return azzzzzzzzzzzw_;
        };
        IEnumerable<Encounter> azzzzzzzzzzzs_ = context.Operators.Where<Encounter>(azzzzzzzzzzzq_, azzzzzzzzzzzr_);

        return azzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Encounter with New Stage 2, 3, 4 or Unstageable Pressure Injury by Skin Exam after First 24 Hours")]
    public IEnumerable<Encounter> Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_by_Skin_Exam_after_First_24_Hours(CqlContext context)
    {
        IEnumerable<Encounter> bzzzzzzzzzzzr_ = this.Encounter_with_Age_18_and_Older(context);
        IEnumerable<Encounter> bzzzzzzzzzzzs_(Encounter InpatientHospitalization)
        {
            CqlCode bzzzzzzzzzzzu_ = this.Physical_findings_of_Skin(context);
            IEnumerable<CqlCode> bzzzzzzzzzzzv_ = context.Operators.ToList<CqlCode>(bzzzzzzzzzzzu_);
            IEnumerable<Observation> bzzzzzzzzzzzw_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, bzzzzzzzzzzzv_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            bool? bzzzzzzzzzzzx_(Observation SkinExam)
            {
                DataType czzzzzzzzzzzb_ = SkinExam?.Effective;
                object czzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzb_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.ToInterval(context, czzzzzzzzzzzc_);
                CqlDateTime czzzzzzzzzzze_ = context.Operators.Start(czzzzzzzzzzzd_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzf_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, InpatientHospitalization);
                CqlDateTime czzzzzzzzzzzg_ = context.Operators.Start(czzzzzzzzzzzf_);
                CqlQuantity czzzzzzzzzzzh_ = context.Operators.Quantity(24m, "hours");
                CqlDateTime czzzzzzzzzzzi_ = context.Operators.Add(czzzzzzzzzzzg_, czzzzzzzzzzzh_);
                CqlDateTime czzzzzzzzzzzk_ = context.Operators.End(czzzzzzzzzzzf_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzl_ = context.Operators.Interval(czzzzzzzzzzzi_, czzzzzzzzzzzk_, true, true);
                bool? czzzzzzzzzzzm_ = context.Operators.In<CqlDateTime>(czzzzzzzzzzze_, czzzzzzzzzzzl_, default);
                Code<ObservationStatus> czzzzzzzzzzzn_ = SkinExam?.StatusElement;
                ObservationStatus? czzzzzzzzzzzo_ = czzzzzzzzzzzn_?.Value;
                Code<ObservationStatus> czzzzzzzzzzzp_ = context.Operators.Convert<Code<ObservationStatus>>(czzzzzzzzzzzo_);
                string czzzzzzzzzzzq_ = context.Operators.Convert<string>(czzzzzzzzzzzp_);
                string[] czzzzzzzzzzzr_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? czzzzzzzzzzzs_ = context.Operators.In<string>(czzzzzzzzzzzq_, czzzzzzzzzzzr_ as IEnumerable<string>);
                bool? czzzzzzzzzzzt_ = context.Operators.And(czzzzzzzzzzzm_, czzzzzzzzzzzs_);
                DataType czzzzzzzzzzzu_ = SkinExam?.Value;
                object czzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzu_);
                CqlValueSet czzzzzzzzzzzw_ = this.Pressure_Injury_Stage_2__3__4_or_Unstageable(context);
                bool? czzzzzzzzzzzx_ = context.Operators.ConceptInValueSet(czzzzzzzzzzzv_ as CqlConcept, czzzzzzzzzzzw_);
                List<Observation.ComponentComponent> czzzzzzzzzzzy_ = SkinExam?.Component;
                bool? czzzzzzzzzzzz_(Observation.ComponentComponent @this)
                {
                    CodeableConcept dzzzzzzzzzzzh_ = @this?.Code;
                    CqlConcept dzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dzzzzzzzzzzzh_);
                    bool? dzzzzzzzzzzzj_ = context.Operators.Not((bool?)(dzzzzzzzzzzzi_ is null));

                    return dzzzzzzzzzzzj_;
                };
                IEnumerable<Observation.ComponentComponent> dzzzzzzzzzzza_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)czzzzzzzzzzzy_, czzzzzzzzzzzz_);
                CqlConcept dzzzzzzzzzzzb_(Observation.ComponentComponent @this)
                {
                    CodeableConcept dzzzzzzzzzzzk_ = @this?.Code;
                    CqlConcept dzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dzzzzzzzzzzzk_);

                    return dzzzzzzzzzzzl_;
                };
                IEnumerable<CqlConcept> dzzzzzzzzzzzc_ = context.Operators.Select<Observation.ComponentComponent, CqlConcept>(dzzzzzzzzzzza_, dzzzzzzzzzzzb_);
                bool? dzzzzzzzzzzze_ = context.Operators.ConceptsInValueSet(dzzzzzzzzzzzc_, czzzzzzzzzzzw_);
                bool? dzzzzzzzzzzzf_ = context.Operators.Or(czzzzzzzzzzzx_, dzzzzzzzzzzze_);
                bool? dzzzzzzzzzzzg_ = context.Operators.And(czzzzzzzzzzzt_, dzzzzzzzzzzzf_);

                return dzzzzzzzzzzzg_;
            };
            IEnumerable<Observation> bzzzzzzzzzzzy_ = context.Operators.Where<Observation>(bzzzzzzzzzzzw_, bzzzzzzzzzzzx_);
            Encounter bzzzzzzzzzzzz_(Observation SkinExam) =>
                InpatientHospitalization;
            IEnumerable<Encounter> czzzzzzzzzzza_ = context.Operators.Select<Observation, Encounter>(bzzzzzzzzzzzy_, bzzzzzzzzzzzz_);

            return czzzzzzzzzzza_;
        };
        IEnumerable<Encounter> bzzzzzzzzzzzt_ = context.Operators.SelectMany<Encounter, Encounter>(bzzzzzzzzzzzr_, bzzzzzzzzzzzs_);

        return bzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Encounter with New Stage 2, 3, 4 or Unstageable Pressure Injury Not POA")]
    public IEnumerable<Encounter> Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_Not_POA(CqlContext context)
    {
        IEnumerable<Encounter> dzzzzzzzzzzzm_ = this.Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_Not_POA_by_Indicator(context);
        IEnumerable<Encounter> dzzzzzzzzzzzn_ = this.Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_by_Skin_Exam_after_First_24_Hours(context);
        IEnumerable<Encounter> dzzzzzzzzzzzo_ = context.Operators.Union<Encounter>(dzzzzzzzzzzzm_, dzzzzzzzzzzzn_);

        return dzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> dzzzzzzzzzzzp_ = this.Encounter_with_New_Deep_Tissue_Pressure_Injury_Not_POA(context);
        IEnumerable<Encounter> dzzzzzzzzzzzq_ = this.Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_Not_POA(context);
        IEnumerable<Encounter> dzzzzzzzzzzzr_ = context.Operators.Union<Encounter>(dzzzzzzzzzzzp_, dzzzzzzzzzzzq_);

        return dzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? dzzzzzzzzzzzs_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return dzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> dzzzzzzzzzzzt_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return dzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? dzzzzzzzzzzzu_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return dzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode dzzzzzzzzzzzv_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return dzzzzzzzzzzzv_;
    }


    #endregion Expressions

}
