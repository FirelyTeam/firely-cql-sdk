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
    private static readonly CqlCode _Physical_findings_of_Skin = new CqlCode("8709-8", "http://loinc.org");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC")]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null,
          _Physical_findings_of_Skin);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Interval(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, true, true);
        object vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.ResolveParameter("HospitalHarmPressureInjuryFHIR-0.1.000", "Measurement Period", vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

        return (CqlInterval<CqlDateTime>)vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.SingletonFrom<Patient>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

        return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Encounter with Age 18 and Older")]
    public IEnumerable<Encounter> Encounter_with_Age_18_and_Older(CqlContext context)
    {
        CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_(Encounter InpatientEncounter)
        {
            Patient vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Patient(context);
            Date vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_?.BirthDateElement;
            string vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_?.Value;
            CqlDate vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.ConvertStringToDate(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            Period wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlDate wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.DateFrom(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            int? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.CalculateAgeAt(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, "year");
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.GreaterOrEqual(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, 18);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.End(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Measurement_Period(context);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.In<CqlDateTime>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, "day");
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            Code<Encounter.EncounterStatus> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = InpatientEncounter?.StatusElement;
            Encounter.EncounterStatus? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_?.Value;
            Code<Encounter.EncounterStatus> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Equal(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, "finished");
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

            return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Encounter>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

        return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Encounter_with_Age_18_and_Older(context);

        return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Initial_Population(context);

        return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Encounter with Deep Tissue Pressure Injury POA by Indicator")]
    public IEnumerable<Encounter> Encounter_with_Deep_Tissue_Pressure_Injury_POA_by_Indicator(CqlContext context)
    {
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Encounter_with_Age_18_and_Older(context);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_(Encounter InpatientHospitalization)
        {
            List<Encounter.DiagnosisComponent> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = InpatientHospitalization?.Diagnosis;
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_(Encounter.DiagnosisComponent EncounterDiag)
            {
                ResourceReference xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = EncounterDiag?.Condition;
                Condition xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = CQMCommon_2_2_000.Instance.getCondition(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CodeableConcept xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_?.Code;
                CqlConcept xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlValueSet xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Pressure_Injury_Deep_Tissue_Diagnoses(context);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.ConceptInValueSet(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_(Extension @this)
                {
                    string xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = @this?.Url;
                    FhirString xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<FhirString>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                    string xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToString(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                    bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Equal(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
                };
                IEnumerable<Extension> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(EncounterDiag is Element
                        ? (EncounterDiag as Element).Extension
                        : default), xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                object xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Extension @this)
                {
                    DataType xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = @this?.Value;

                    return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
                };
                IEnumerable<object> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<Extension, object>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                object xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.SingletonFrom<object>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlConcept xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ as CodeableConcept);
                CqlValueSet xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.ConceptInValueSet(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

                return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<Encounter.DiagnosisComponent> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Exists<Encounter.DiagnosisComponent>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

            return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Encounter>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

        return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Encounter with Deep Tissue Pressure Injury POA by Skin Exam within First 72 Hours")]
    public IEnumerable<Encounter> Encounter_with_Deep_Tissue_Pressure_Injury_POA_by_Skin_Exam_within_First_72_Hours(CqlContext context)
    {
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Encounter_with_Age_18_and_Older(context);
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_(Encounter InpatientHospitalization)
        {
            CqlCode xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Physical_findings_of_Skin(context);
            IEnumerable<CqlCode> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.ToList<CqlCode>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_(Observation SkinExam)
            {
                DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = SkinExam?.Effective;
                object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.ToInterval(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, InpatientHospitalization);
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlQuantity yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Quantity(72m, "hours");
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Add(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Interval(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, true, true);
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.In<CqlDateTime>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, default);
                Code<ObservationStatus> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = SkinExam?.StatusElement;
                ObservationStatus? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_?.Value;
                Code<ObservationStatus> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Convert<Code<ObservationStatus>>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                string yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Convert<string>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                string[] yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.In<string>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ as IEnumerable<string>);
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CodeableConcept yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = SkinExam?.Code;
                CqlConcept yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Pressure_Injury_Deep_Tissue(context);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.ConceptInValueSet(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

                return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Observation>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            Encounter yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_(Observation SkinExam) =>
                InpatientHospitalization;
            IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Select<Observation, Encounter>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

            return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.SelectMany<Encounter, Encounter>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

        return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Encounter with Deep Tissue Pressure Injury POA")]
    public IEnumerable<Encounter> Encounter_with_Deep_Tissue_Pressure_Injury_POA(CqlContext context)
    {
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Encounter_with_Deep_Tissue_Pressure_Injury_POA_by_Indicator(context);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Encounter_with_Deep_Tissue_Pressure_Injury_POA_by_Skin_Exam_within_First_72_Hours(context);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<Encounter>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Encounter with Stage 2, 3, 4, or Unstageable Pressure Injury Present on Admission by POA Indicator")]
    public IEnumerable<Encounter> Encounter_with_Stage_2__3__4__or_Unstageable_Pressure_Injury_Present_on_Admission_by_POA_Indicator(CqlContext context)
    {
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Encounter_with_Age_18_and_Older(context);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_(Encounter InpatientHospitalization)
        {
            List<Encounter.DiagnosisComponent> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = InpatientHospitalization?.Diagnosis;
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_(Encounter.DiagnosisComponent Stage234UnstageablePressureInjury)
            {
                ResourceReference zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = Stage234UnstageablePressureInjury?.Condition;
                Condition zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = CQMCommon_2_2_000.Instance.getCondition(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CodeableConcept zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_?.Code;
                CqlConcept zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlValueSet zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Pressure_Injury_Stage_2__3__4__or_Unstageable_Diagnoses(context);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ConceptInValueSet(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(Extension @this)
                {
                    string azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = @this?.Url;
                    FhirString azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<FhirString>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                    string azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToString(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                    bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Equal(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
                };
                IEnumerable<Extension> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Stage234UnstageablePressureInjury is Element
                        ? (Stage234UnstageablePressureInjury as Element).Extension
                        : default), zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                object zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_(Extension @this)
                {
                    DataType azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = @this?.Value;

                    return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
                };
                IEnumerable<object> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Select<Extension, object>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                object zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.SingletonFrom<object>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlConcept zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ as CodeableConcept);
                CqlValueSet zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.ConceptInValueSet(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

                return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
            };
            IEnumerable<Encounter.DiagnosisComponent> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Exists<Encounter.DiagnosisComponent>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

            return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Encounter>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Encounter with Stage 2, 3, 4 or Unstageable Pressure Injury POA by Skin Exam within 24 Hours")]
    public IEnumerable<Encounter> Encounter_with_Stage_2__3__4_or_Unstageable_Pressure_Injury_POA_by_Skin_Exam_within_24_Hours(CqlContext context)
    {
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Encounter_with_Age_18_and_Older(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(Encounter InpatientHospitalization)
        {
            CqlCode azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Physical_findings_of_Skin(context);
            IEnumerable<CqlCode> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.ToList<CqlCode>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_(Observation SkinExam)
            {
                DataType azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = SkinExam?.Effective;
                object azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, InpatientHospitalization);
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Start(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlQuantity azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Quantity(24m, "hours");
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Add(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Interval(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, true, true);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDateTime>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, default);
                Code<ObservationStatus> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = SkinExam?.StatusElement;
                ObservationStatus? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_?.Value;
                Code<ObservationStatus> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Convert<Code<ObservationStatus>>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                string bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<string>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                string[] bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.In<string>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ as IEnumerable<string>);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CodeableConcept bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = SkinExam?.Code;
                CqlConcept bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Pressure_Injury_Stage_2__3__4_or_Unstageable(context);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.ConceptInValueSet(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

                return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Observation>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            Encounter azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Observation SkinExam) =>
                InpatientHospitalization;
            IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Select<Observation, Encounter>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

            return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.SelectMany<Encounter, Encounter>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Encounter with Stage 2, 3, 4 or Unstageable Pressure Injury POA")]
    public IEnumerable<Encounter> Encounter_with_Stage_2__3__4_or_Unstageable_Pressure_Injury_POA(CqlContext context)
    {
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Encounter_with_Stage_2__3__4__or_Unstageable_Pressure_Injury_Present_on_Admission_by_POA_Indicator(context);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Encounter_with_Stage_2__3__4_or_Unstageable_Pressure_Injury_POA_by_Skin_Exam_within_24_Hours(context);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<Encounter>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

        return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Encounter with Diagnosis of COVID19 Infection")]
    public IEnumerable<Encounter> Encounter_with_Diagnosis_of_COVID19_Infection(CqlContext context)
    {
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Encounter_with_Age_18_and_Older(context);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(Encounter InpatientHospitalization)
        {
            IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = CQMCommon_2_2_000.Instance.EncounterDiagnosis(context, InpatientHospitalization);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_(Condition EncounterDiag)
            {
                CodeableConcept bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = EncounterDiag?.Code;
                CqlConcept bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.COVID_19(context);
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.ConceptInValueSet(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

                return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<Condition> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Condition>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Exists<Condition>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

            return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Encounter>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

        return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context)
    {
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Encounter_with_Deep_Tissue_Pressure_Injury_POA(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Encounter_with_Stage_2__3__4_or_Unstageable_Pressure_Injury_POA(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<Encounter>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Encounter_with_Diagnosis_of_COVID19_Infection(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Union<Encounter>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

        return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Encounter with New Deep Tissue Pressure Injury Not POA by Indicator")]
    public IEnumerable<Encounter> Encounter_with_New_Deep_Tissue_Pressure_Injury_Not_POA_by_Indicator(CqlContext context)
    {
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Encounter_with_Age_18_and_Older(context);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Encounter InpatientHospitalization)
        {
            List<Encounter.DiagnosisComponent> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = InpatientHospitalization?.Diagnosis;
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_(Encounter.DiagnosisComponent EncounterDiag)
            {
                ResourceReference czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = EncounterDiag?.Condition;
                Condition czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = CQMCommon_2_2_000.Instance.getCondition(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                CodeableConcept czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_?.Code;
                CqlConcept czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Pressure_Injury_Deep_Tissue_Diagnoses(context);
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.ConceptInValueSet(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_(Extension @this)
                {
                    string dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = @this?.Url;
                    FhirString dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Convert<FhirString>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                    string dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToString(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                    bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Equal(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
                };
                IEnumerable<Extension> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(EncounterDiag is Element
                        ? (EncounterDiag as Element).Extension
                        : default), czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                object czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_(Extension @this)
                {
                    DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = @this?.Value;

                    return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
                };
                IEnumerable<object> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Select<Extension, object>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                object czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.SingletonFrom<object>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlConcept czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ as CodeableConcept);
                CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine(context);
                bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.ConceptInValueSet(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

                return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Encounter.DiagnosisComponent> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Exists<Encounter.DiagnosisComponent>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

            return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Encounter>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

        return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Encounter with New Deep Tissue Pressure Injury by Skin Exam after First 72 Hours")]
    public IEnumerable<Encounter> Encounter_with_New_Deep_Tissue_Pressure_Injury_by_Skin_Exam_after_First_72_Hours(CqlContext context)
    {
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Encounter_with_Age_18_and_Older(context);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_(Encounter InpatientHospitalization)
        {
            CqlCode dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Physical_findings_of_Skin(context);
            IEnumerable<CqlCode> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.ToList<CqlCode>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            IEnumerable<Observation> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Observation SkinExam)
            {
                DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = SkinExam?.Effective;
                object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.ToInterval(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Start(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, InpatientHospitalization);
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlQuantity dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Quantity(72m, "hours");
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Add(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.End(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Interval(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, true, true);
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, default);
                Code<ObservationStatus> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = SkinExam?.StatusElement;
                ObservationStatus? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_?.Value;
                Code<ObservationStatus> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<Code<ObservationStatus>>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                string ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Convert<string>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                string[] ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.In<string>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ as IEnumerable<string>);
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                DataType ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = SkinExam?.Value;
                object ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Pressure_Injury_Deep_Tissue(context);
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.ConceptInValueSet(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ as CqlConcept, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                List<Observation.ComponentComponent> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = SkinExam?.Component;
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_(Observation.ComponentComponent @this)
                {
                    CodeableConcept ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = @this?.Code;
                    CqlConcept ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                    bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Not((bool?)(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ is null));

                    return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
                };
                IEnumerable<Observation.ComponentComponent> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlConcept ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(Observation.ComponentComponent @this)
                {
                    CodeableConcept fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = @this?.Code;
                    CqlConcept fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

                    return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
                };
                IEnumerable<CqlConcept> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Select<Observation.ComponentComponent, CqlConcept>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.ConceptsInValueSet(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Or(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

                return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
            };
            IEnumerable<Observation> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Observation>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            Encounter dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_(Observation SkinExam) =>
                InpatientHospitalization;
            IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Select<Observation, Encounter>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

            return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.SelectMany<Encounter, Encounter>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

        return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Encounter with New Deep Tissue Pressure Injury Not POA")]
    public IEnumerable<Encounter> Encounter_with_New_Deep_Tissue_Pressure_Injury_Not_POA(CqlContext context)
    {
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Encounter_with_New_Deep_Tissue_Pressure_Injury_Not_POA_by_Indicator(context);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Encounter_with_New_Deep_Tissue_Pressure_Injury_by_Skin_Exam_after_First_72_Hours(context);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Union<Encounter>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

        return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Encounter with New Stage 2, 3, 4 or Unstageable Pressure Injury Not POA by Indicator")]
    public IEnumerable<Encounter> Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_Not_POA_by_Indicator(CqlContext context)
    {
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Encounter_with_Age_18_and_Older(context);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(Encounter InpatientHospitalization)
        {
            List<Encounter.DiagnosisComponent> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = InpatientHospitalization?.Diagnosis;
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Encounter.DiagnosisComponent Stage234UnstageablePressureInjury)
            {
                ResourceReference fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = Stage234UnstageablePressureInjury?.Condition;
                Condition fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = CQMCommon_2_2_000.Instance.getCondition(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                CodeableConcept fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_?.Code;
                CqlConcept fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Pressure_Injury_Stage_2__3__4__or_Unstageable_Diagnoses(context);
                bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ConceptInValueSet(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_(Extension @this)
                {
                    string gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = @this?.Url;
                    FhirString gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Convert<FhirString>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                    string gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToString(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                    bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Equal(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

                    return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
                };
                IEnumerable<Extension> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(Stage234UnstageablePressureInjury is Element
                        ? (Stage234UnstageablePressureInjury as Element).Extension
                        : default), fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                object fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_(Extension @this)
                {
                    DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = @this?.Value;

                    return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
                };
                IEnumerable<object> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Select<Extension, object>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                object fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.SingletonFrom<object>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlConcept fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ as CodeableConcept);
                CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine(context);
                bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.ConceptInValueSet(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

                return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<Encounter.DiagnosisComponent> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Exists<Encounter.DiagnosisComponent>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

            return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Encounter>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

        return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Encounter with New Stage 2, 3, 4 or Unstageable Pressure Injury by Skin Exam after First 24 Hours")]
    public IEnumerable<Encounter> Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_by_Skin_Exam_after_First_24_Hours(CqlContext context)
    {
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Encounter_with_Age_18_and_Older(context);
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Encounter InpatientHospitalization)
        {
            CqlCode gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Physical_findings_of_Skin(context);
            IEnumerable<CqlCode> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.ToList<CqlCode>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(Observation SkinExam)
            {
                DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = SkinExam?.Effective;
                object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.ToInterval(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = CQMCommon_2_2_000.Instance.HospitalizationWithObservation(context, InpatientHospitalization);
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlQuantity gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Quantity(24m, "hours");
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Add(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.End(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Interval(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, true, true);
                bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.In<CqlDateTime>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, default);
                Code<ObservationStatus> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = SkinExam?.StatusElement;
                ObservationStatus? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_?.Value;
                Code<ObservationStatus> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<Code<ObservationStatus>>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                string hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<string>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                string[] hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.In<string>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ as IEnumerable<string>);
                bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                DataType hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = SkinExam?.Value;
                object hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlValueSet hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Pressure_Injury_Stage_2__3__4_or_Unstageable(context);
                bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.ConceptInValueSet(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ as CqlConcept, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                List<Observation.ComponentComponent> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = SkinExam?.Component;
                bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(Observation.ComponentComponent @this)
                {
                    CodeableConcept hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = @this?.Code;
                    CqlConcept hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                    bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Not((bool?)(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ is null));

                    return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
                };
                IEnumerable<Observation.ComponentComponent> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlConcept hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(Observation.ComponentComponent @this)
                {
                    CodeableConcept izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = @this?.Code;
                    CqlConcept izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

                    return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
                };
                IEnumerable<CqlConcept> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Select<Observation.ComponentComponent, CqlConcept>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.ConceptsInValueSet(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Or(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

                return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Observation>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            Encounter gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(Observation SkinExam) =>
                InpatientHospitalization;
            IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Select<Observation, Encounter>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

            return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.SelectMany<Encounter, Encounter>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

        return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Encounter with New Stage 2, 3, 4 or Unstageable Pressure Injury Not POA")]
    public IEnumerable<Encounter> Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_Not_POA(CqlContext context)
    {
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_Not_POA_by_Indicator(context);
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_by_Skin_Exam_after_First_24_Hours(context);
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<Encounter>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

        return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Encounter_with_New_Deep_Tissue_Pressure_Injury_Not_POA(context);
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_Not_POA(context);
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<Encounter>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

        return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    #endregion Expressions

}
