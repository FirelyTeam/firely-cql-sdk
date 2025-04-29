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
[CqlLibrary("HybridHospitalWideMortalityFHIR", "0.0.001")]
public partial class HybridHospitalWideMortalityFHIR_0_0_001 : ILibrary, ISingleton<HybridHospitalWideMortalityFHIR_0_0_001>
{
    private HybridHospitalWideMortalityFHIR_0_0_001() {}

    public static HybridHospitalWideMortalityFHIR_0_0_001 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "HybridHospitalWideMortalityFHIR";
    public string Version => "0.0.001";
    public ILibrary[] Dependencies => [CQMCommon_2_2_000.Instance, FHIRHelpers_4_4_000.Instance, SupplementalDataElements_3_5_000.Instance, QICoreCommon_2_1_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Bicarbonate lab test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.139", valueSetVersion: null)]
    public CqlValueSet Bicarbonate_lab_test(CqlContext _) => _Bicarbonate_lab_test;
    private static readonly CqlValueSet _Bicarbonate_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.139", null);

    [CqlValueSetDefinition("Creatinine lab test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.2363", valueSetVersion: null)]
    public CqlValueSet Creatinine_lab_test(CqlContext _) => _Creatinine_lab_test;
    private static readonly CqlValueSet _Creatinine_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.2363", null);

    [CqlValueSetDefinition("Encounter Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext _) => _Encounter_Inpatient;
    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlValueSetDefinition("Hematocrit lab test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.114", valueSetVersion: null)]
    public CqlValueSet Hematocrit_lab_test(CqlContext _) => _Hematocrit_lab_test;
    private static readonly CqlValueSet _Hematocrit_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.114", null);

    [CqlValueSetDefinition("Medicare Advantage payer", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1104.12", valueSetVersion: null)]
    public CqlValueSet Medicare_Advantage_payer(CqlContext _) => _Medicare_Advantage_payer;
    private static readonly CqlValueSet _Medicare_Advantage_payer = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1104.12", null);

    [CqlValueSetDefinition("Medicare FFS payer", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1104.10", valueSetVersion: null)]
    public CqlValueSet Medicare_FFS_payer(CqlContext _) => _Medicare_FFS_payer;
    private static readonly CqlValueSet _Medicare_FFS_payer = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1104.10", null);

    [CqlValueSetDefinition("Oxygen Saturation by Pulse Oximetry", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.151", valueSetVersion: null)]
    public CqlValueSet Oxygen_Saturation_by_Pulse_Oximetry(CqlContext _) => _Oxygen_Saturation_by_Pulse_Oximetry;
    private static readonly CqlValueSet _Oxygen_Saturation_by_Pulse_Oximetry = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.151", null);

    [CqlValueSetDefinition("Platelet count lab test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.127", valueSetVersion: null)]
    public CqlValueSet Platelet_count_lab_test(CqlContext _) => _Platelet_count_lab_test;
    private static readonly CqlValueSet _Platelet_count_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.127", null);

    [CqlValueSetDefinition("Sodium lab test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.119", valueSetVersion: null)]
    public CqlValueSet Sodium_lab_test(CqlContext _) => _Sodium_lab_test;
    private static readonly CqlValueSet _Sodium_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.119", null);

    [CqlValueSetDefinition("White blood cells count lab test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.129", valueSetVersion: null)]
    public CqlValueSet White_blood_cells_count_lab_test(CqlContext _) => _White_blood_cells_count_lab_test;
    private static readonly CqlValueSet _White_blood_cells_count_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.129", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Oxygen saturation in Arterial blood", codeId: "2708-6", codeSystem: "http://loinc.org")]
    public CqlCode Oxygen_saturation_in_Arterial_blood(CqlContext _) => _Oxygen_saturation_in_Arterial_blood;
    private static readonly CqlCode _Oxygen_saturation_in_Arterial_blood = new CqlCode("2708-6", "http://loinc.org", default, default);

    [CqlCodeDefinition("Oxygen saturation in Arterial blood by Pulse oximetry", codeId: "59408-5", codeSystem: "http://loinc.org")]
    public CqlCode Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry(CqlContext _) => _Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry;
    private static readonly CqlCode _Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry = new CqlCode("59408-5", "http://loinc.org", default, default);

    [CqlCodeDefinition("Systolic blood pressure", codeId: "8480-6", codeSystem: "http://loinc.org")]
    public CqlCode Systolic_blood_pressure(CqlContext _) => _Systolic_blood_pressure;
    private static readonly CqlCode _Systolic_blood_pressure = new CqlCode("8480-6", "http://loinc.org", default, default);

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC")]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC = new CqlCodeSystem();

    [CqlCodeSystemDefinition("ActCode")]
    public CqlCodeSystem ActCode(CqlContext _) => _ActCode;
    private static readonly CqlCodeSystem _ActCode = new CqlCodeSystem();

    [CqlCodeSystemDefinition("Source of Payment Typology")]
    public CqlCodeSystem Source_of_Payment_Typology(CqlContext _) => _Source_of_Payment_Typology;
    private static readonly CqlCodeSystem _Source_of_Payment_Typology = new CqlCodeSystem();

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Interval(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, true, true);
        object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.ResolveParameter("HybridHospitalWideMortalityFHIR-0.0.001", "Measurement Period", tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

        return (CqlInterval<CqlDateTime>)tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.SingletonFrom<Patient>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

        return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Inpatient Encounters")]
    public IEnumerable<Encounter> Inpatient_Encounters(CqlContext context)
    {
        CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Encounter InpatientEncounter)
        {
            CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Medicare_FFS_payer(context);
            IEnumerable<Coverage> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Coverage>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-coverage"));
            CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Medicare_Advantage_payer(context);
            IEnumerable<Coverage> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Coverage>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-coverage"));
            IEnumerable<Coverage> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<Coverage>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(Coverage MedicarePayer)
            {
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, InpatientEncounter);
                int? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = CQMCommon_2_2_000.Instance.lengthInDays(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Less(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, 365);
                Code<Encounter.EncounterStatus> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = InpatientEncounter?.StatusElement;
                Encounter.EncounterStatus? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_?.Value;
                Code<Encounter.EncounterStatus> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Equal(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, "finished");
                bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                Patient uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Patient(context);
                Date uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_?.BirthDateElement;
                string uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_?.Value;
                CqlDate uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.ConvertStringToDate(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                Period uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Start(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlDate uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.DateFrom(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                int? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.CalculateAgeAt(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, "year");
                CqlInterval<int?> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Interval(65, 94, true, true);
                bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.In<int?>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, default);
                bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.End(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Measurement_Period(context);
                bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.In<CqlDateTime>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, "day");
                bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

                return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
            };
            IEnumerable<Coverage> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Coverage>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            Encounter tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_(Coverage MedicarePayer) =>
                InpatientEncounter;
            IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Select<Coverage, Encounter>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

            return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.SelectMany<Encounter, Encounter>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Inpatient_Encounters(context);

        return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Encounter with First Body Temperature")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)?> Encounter_with_First_Body_Temperature(CqlContext context)
    {
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_(Encounter EncounterInpatient)
        {
            Id vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = EncounterInpatient?.IdElement;
            string vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_?.Value;
            IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bodytemp"));
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_(Observation temperature)
            {
                DataType vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = temperature?.Effective;
                object vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.earliest(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                Period vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Start(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlQuantity wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Subtract(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Start(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlQuantity wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Add(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Interval(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, true, true);
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.In<CqlDateTime>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, default);
                Code<ObservationStatus> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = temperature?.StatusElement;
                ObservationStatus? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_?.Value;
                string wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<string>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                string[] wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.In<string>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ as IEnumerable<string>);
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                DataType wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = temperature?.Value;
                CqlQuantity wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ as Quantity);
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Not((bool?)(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ is null));
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

                return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Observation>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            object vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_(Observation @this)
            {
                DataType wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = @this?.Effective;
                object wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.earliest(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

                return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.SortBy<Observation>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, System.ComponentModel.ListSortDirection.Ascending);
            Observation vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.First<Observation>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            DataType vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_?.Value;
            CqlQuantity vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ as Quantity);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_(Observation temperature)
            {
                DataType wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = temperature?.Effective;
                object wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.earliest(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                Period wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlQuantity xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Subtract(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlQuantity xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Add(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Interval(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, true, true);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.In<CqlDateTime>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, default);
                Code<ObservationStatus> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = temperature?.StatusElement;
                ObservationStatus? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_?.Value;
                string xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Convert<string>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                string[] xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.In<string>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ as IEnumerable<string>);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                DataType xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = temperature?.Value;
                CqlQuantity xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ as Quantity);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Not((bool?)(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ is null));
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

                return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
            };
            IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Observation>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            object vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(Observation @this)
            {
                DataType xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = @this?.Effective;
                object xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.earliest(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

                return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
            };
            IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.SortBy<Observation>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, System.ComponentModel.ListSortDirection.Ascending);
            Observation vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.First<Observation>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            DataType vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_?.Effective;
            object vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.earliest(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = (CqlTupleMetadata_GIbILVAdXLLNYBgcQIEiUiKaK, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ as CqlQuantity, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

            return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)?> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)?>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)?> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)?>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

        return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Encounter with First Heart Rate")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)?> Encounter_with_First_Heart_Rate(CqlContext context)
    {
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_(Encounter EncounterInpatient)
        {
            Id yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = EncounterInpatient?.IdElement;
            string yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_?.Value;
            IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/heartrate"));
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_(Observation HeartRate)
            {
                DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = HeartRate?.Effective;
                object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.earliest(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                Period yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlQuantity zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Subtract(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlQuantity zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Add(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Interval(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, true, true);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.In<CqlDateTime>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, default);
                Code<ObservationStatus> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = HeartRate?.StatusElement;
                ObservationStatus? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_?.Value;
                string zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Convert<string>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                string[] zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.In<string>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ as IEnumerable<string>);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                DataType zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = HeartRate?.Value;
                CqlQuantity zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ as Quantity);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Not((bool?)(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ is null));
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

                return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
            };
            IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Observation>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(Observation @this)
            {
                DataType zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = @this?.Effective;
                object zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.earliest(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

                return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
            };
            IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.SortBy<Observation>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, System.ComponentModel.ListSortDirection.Ascending);
            Observation yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.First<Observation>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_?.Value;
            CqlQuantity yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ as Quantity);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(Observation HeartRate)
            {
                DataType zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = HeartRate?.Effective;
                object zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.earliest(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                Period azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlQuantity azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Subtract(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Start(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlQuantity azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Add(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Interval(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, true, true);
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.In<CqlDateTime>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, default);
                Code<ObservationStatus> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = HeartRate?.StatusElement;
                ObservationStatus? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_?.Value;
                string azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Convert<string>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                string[] azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.In<string>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ as IEnumerable<string>);
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                DataType azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = HeartRate?.Value;
                CqlQuantity azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ as Quantity);
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Not((bool?)(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ is null));
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

                return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Observation>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(Observation @this)
            {
                DataType azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = @this?.Effective;
                object azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.earliest(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

                return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.SortBy<Observation>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, System.ComponentModel.ListSortDirection.Ascending);
            Observation yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.First<Observation>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_?.Effective;
            object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.earliest(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = (CqlTupleMetadata_DhbJAfCiKIAGYKTjJXYGSKECQ, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ as CqlQuantity, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

            return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)?> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)?>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)?> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)?>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

        return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Encounter with First Oxygen Saturation")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)?> Encounter_with_First_Oxygen_Saturation(CqlContext context)
    {
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_(Encounter EncounterInpatient)
        {
            Id bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = EncounterInpatient?.IdElement;
            string bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_?.Value;
            CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
            IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Observation O2Saturation)
            {
                object bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_()
                {
                    bool czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_()
                    {
                        DataType czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = O2Saturation?.Effective;
                        object czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                        bool czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ is CqlDateTime;

                        return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
                    };
                    bool czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_()
                    {
                        DataType czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = O2Saturation?.Effective;
                        object czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                        bool czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ is CqlInterval<CqlDateTime>;

                        return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
                    };
                    bool czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_()
                    {
                        DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = O2Saturation?.Effective;
                        object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                        bool dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ is CqlDateTime;

                        return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
                    };
                    if (czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_())
                    {
                        DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = O2Saturation?.Effective;
                        object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

                        return (dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ as CqlDateTime) as object;
                    }
                    else if (czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_())
                    {
                        DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = O2Saturation?.Effective;
                        object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

                        return (dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_())
                    {
                        DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = O2Saturation?.Effective;
                        object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

                        return (dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ as CqlDateTime) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.earliest(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_());
                Period bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlQuantity bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Subtract(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlQuantity czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Add(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Interval(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, true, true);
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.In<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, default);
                Code<ObservationStatus> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = O2Saturation?.StatusElement;
                ObservationStatus? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_?.Value;
                Code<ObservationStatus> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Convert<Code<ObservationStatus>>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                string czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Convert<string>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                string[] czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.In<string>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ as IEnumerable<string>);
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                DataType czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = O2Saturation?.Value;
                object czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Not((bool?)(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ is null));
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

                return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
            };
            IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Observation>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            object bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Observation @this)
            {
                object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_()
                {
                    bool dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_()
                    {
                        DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = @this?.Effective;
                        object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                        bool dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ is CqlDateTime;

                        return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
                    };
                    bool dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_()
                    {
                        DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = @this?.Effective;
                        object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                        bool dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ is CqlInterval<CqlDateTime>;

                        return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
                    };
                    bool dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_()
                    {
                        DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = @this?.Effective;
                        object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                        bool dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ is CqlDateTime;

                        return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
                    };
                    if (dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_())
                    {
                        DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = @this?.Effective;
                        object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

                        return (dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ as CqlDateTime) as object;
                    }
                    else if (dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_())
                    {
                        DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = @this?.Effective;
                        object ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

                        return (ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_())
                    {
                        DataType ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = @this?.Effective;
                        object ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

                        return (ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ as CqlDateTime) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.earliest(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_());

                return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
            };
            IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.SortBy<Observation>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, System.ComponentModel.ListSortDirection.Ascending);
            Observation bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.First<Observation>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_?.Value;
            object bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            object bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_()
            {
                bool ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_()
                {
                    CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
                    IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Observation O2Saturation)
                    {
                        object ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_()
                        {
                            bool fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_()
                            {
                                DataType fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = O2Saturation?.Effective;
                                object fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                                bool fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ is CqlDateTime;

                                return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
                            };
                            bool fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_()
                            {
                                DataType fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = O2Saturation?.Effective;
                                object fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                                bool fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ is CqlInterval<CqlDateTime>;

                                return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
                            };
                            bool fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_()
                            {
                                DataType fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = O2Saturation?.Effective;
                                object fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                                bool gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ is CqlDateTime;

                                return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
                            };
                            if (fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_())
                            {
                                DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = O2Saturation?.Effective;
                                object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

                                return (gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ as CqlDateTime) as object;
                            }
                            else if (fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_())
                            {
                                DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = O2Saturation?.Effective;
                                object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

                                return (gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_())
                            {
                                DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = O2Saturation?.Effective;
                                object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

                                return (gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.earliest(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_());
                        Period ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = EncounterInpatient?.Period;
                        CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                        CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                        CqlQuantity ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Quantity(1440m, "minutes");
                        CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Subtract(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                        CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                        CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                        CqlQuantity fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Quantity(120m, "minutes");
                        CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Add(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                        CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Interval(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, true, true);
                        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, default);
                        Code<ObservationStatus> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = O2Saturation?.StatusElement;
                        ObservationStatus? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_?.Value;
                        Code<ObservationStatus> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<Code<ObservationStatus>>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                        string fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Convert<string>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                        string[] fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.In<string>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ as IEnumerable<string>);
                        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                        DataType fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = O2Saturation?.Value;
                        object fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Not((bool?)(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ is null));
                        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

                        return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
                    };
                    IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Observation>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                    object ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Observation @this)
                    {
                        object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_()
                        {
                            bool gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_()
                            {
                                DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = @this?.Effective;
                                object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                                bool gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ is CqlDateTime;

                                return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
                            };
                            bool gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_()
                            {
                                DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = @this?.Effective;
                                object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                                bool gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ is CqlInterval<CqlDateTime>;

                                return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
                            };
                            bool gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_()
                            {
                                DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = @this?.Effective;
                                object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                                bool gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ is CqlDateTime;

                                return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
                            };
                            if (gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_())
                            {
                                DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = @this?.Effective;
                                object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

                                return (gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ as CqlDateTime) as object;
                            }
                            else if (gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_())
                            {
                                DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = @this?.Effective;
                                object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

                                return (gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_())
                            {
                                DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = @this?.Effective;
                                object hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

                                return (hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.earliest(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_());

                        return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
                    };
                    IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.SortBy<Observation>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.First<Observation>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                    DataType ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_?.Effective;
                    object ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                    bool ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ is CqlDateTime;

                    return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
                };
                bool ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_()
                {
                    CqlValueSet hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
                    IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_(Observation O2Saturation)
                    {
                        object hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_()
                        {
                            bool izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_()
                            {
                                DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = O2Saturation?.Effective;
                                object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                                bool izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ is CqlDateTime;

                                return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
                            };
                            bool izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_()
                            {
                                DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = O2Saturation?.Effective;
                                object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                                bool izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ is CqlInterval<CqlDateTime>;

                                return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
                            };
                            bool izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_()
                            {
                                DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = O2Saturation?.Effective;
                                object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                                bool izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ is CqlDateTime;

                                return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
                            };
                            if (izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_())
                            {
                                DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = O2Saturation?.Effective;
                                object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

                                return (izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ as CqlDateTime) as object;
                            }
                            else if (izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_())
                            {
                                DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = O2Saturation?.Effective;
                                object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

                                return (izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_())
                            {
                                DataType jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = O2Saturation?.Effective;
                                object jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

                                return (jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.earliest(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_());
                        Period hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = EncounterInpatient?.Period;
                        CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                        CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                        CqlQuantity hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Quantity(1440m, "minutes");
                        CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Subtract(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                        CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                        CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                        CqlQuantity hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Quantity(120m, "minutes");
                        CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Add(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                        CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Interval(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, true, true);
                        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, default);
                        Code<ObservationStatus> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = O2Saturation?.StatusElement;
                        ObservationStatus? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_?.Value;
                        Code<ObservationStatus> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Convert<Code<ObservationStatus>>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                        string izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<string>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                        string[] izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.In<string>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ as IEnumerable<string>);
                        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                        DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = O2Saturation?.Value;
                        object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Not((bool?)(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ is null));
                        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

                        return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
                    };
                    IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Observation>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                    object hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_(Observation @this)
                    {
                        object jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_()
                        {
                            bool jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_()
                            {
                                DataType jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = @this?.Effective;
                                object jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                                bool jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ is CqlDateTime;

                                return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
                            };
                            bool jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_()
                            {
                                DataType jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = @this?.Effective;
                                object jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                                bool jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ is CqlInterval<CqlDateTime>;

                                return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
                            };
                            bool jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_()
                            {
                                DataType jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = @this?.Effective;
                                object jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                                bool jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ is CqlDateTime;

                                return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
                            };
                            if (jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_())
                            {
                                DataType jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = @this?.Effective;
                                object jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

                                return (jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ as CqlDateTime) as object;
                            }
                            else if (jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_())
                            {
                                DataType jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = @this?.Effective;
                                object jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

                                return (jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_())
                            {
                                DataType jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = @this?.Effective;
                                object jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

                                return (jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.earliest(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_());

                        return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
                    };
                    IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.SortBy<Observation>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.First<Observation>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                    DataType hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_?.Effective;
                    object hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                    bool hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ is CqlInterval<CqlDateTime>;

                    return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
                };
                bool ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_()
                {
                    CqlValueSet jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
                    IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_(Observation O2Saturation)
                    {
                        object kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_()
                        {
                            bool lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_()
                            {
                                DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = O2Saturation?.Effective;
                                object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                                bool lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ is CqlDateTime;

                                return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
                            };
                            bool lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_()
                            {
                                DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = O2Saturation?.Effective;
                                object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                                bool lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ is CqlInterval<CqlDateTime>;

                                return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
                            };
                            bool lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_()
                            {
                                DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = O2Saturation?.Effective;
                                object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                                bool lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ is CqlDateTime;

                                return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
                            };
                            if (lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_())
                            {
                                DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = O2Saturation?.Effective;
                                object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

                                return (lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ as CqlDateTime) as object;
                            }
                            else if (lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_())
                            {
                                DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = O2Saturation?.Effective;
                                object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

                                return (lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_())
                            {
                                DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = O2Saturation?.Effective;
                                object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

                                return (lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.earliest(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_());
                        Period kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = EncounterInpatient?.Period;
                        CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                        CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                        CqlQuantity kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Quantity(1440m, "minutes");
                        CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Subtract(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                        CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                        CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                        CqlQuantity kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Quantity(120m, "minutes");
                        CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Add(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                        CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Interval(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, true, true);
                        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.In<CqlDateTime>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, default);
                        Code<ObservationStatus> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = O2Saturation?.StatusElement;
                        ObservationStatus? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_?.Value;
                        Code<ObservationStatus> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<Code<ObservationStatus>>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                        string kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<string>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                        string[] kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<string>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ as IEnumerable<string>);
                        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                        DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = O2Saturation?.Value;
                        object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Not((bool?)(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ is null));
                        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

                        return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
                    };
                    IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Observation>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                    object kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_(Observation @this)
                    {
                        object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_()
                        {
                            bool lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_()
                            {
                                DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = @this?.Effective;
                                object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                                bool mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ is CqlDateTime;

                                return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
                            };
                            bool mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_()
                            {
                                DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = @this?.Effective;
                                object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                                bool mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ is CqlInterval<CqlDateTime>;

                                return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
                            };
                            bool mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_()
                            {
                                DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = @this?.Effective;
                                object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                                bool mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ is CqlDateTime;

                                return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
                            };
                            if (lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_())
                            {
                                DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = @this?.Effective;
                                object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

                                return (mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ as CqlDateTime) as object;
                            }
                            else if (mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_())
                            {
                                DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = @this?.Effective;
                                object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

                                return (mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_())
                            {
                                DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = @this?.Effective;
                                object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

                                return (mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.earliest(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_());

                        return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
                    };
                    IEnumerable<Observation> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.SortBy<Observation>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.First<Observation>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                    DataType kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_?.Effective;
                    object kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                    bool kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ is CqlDateTime;

                    return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
                };
                if (ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_())
                {
                    CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
                    IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_(Observation O2Saturation)
                    {
                        object nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_()
                        {
                            bool nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_()
                            {
                                DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = O2Saturation?.Effective;
                                object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                                bool ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ is CqlDateTime;

                                return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
                            };
                            bool ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_()
                            {
                                DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = O2Saturation?.Effective;
                                object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                                bool ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ is CqlInterval<CqlDateTime>;

                                return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
                            };
                            bool ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_()
                            {
                                DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = O2Saturation?.Effective;
                                object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                                bool ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ is CqlDateTime;

                                return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
                            };
                            if (nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_())
                            {
                                DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = O2Saturation?.Effective;
                                object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

                                return (ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ as CqlDateTime) as object;
                            }
                            else if (ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_())
                            {
                                DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = O2Saturation?.Effective;
                                object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

                                return (ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_())
                            {
                                DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = O2Saturation?.Effective;
                                object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

                                return (ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.earliest(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_());
                        Period nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = EncounterInpatient?.Period;
                        CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                        CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                        CqlQuantity nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Quantity(1440m, "minutes");
                        CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Subtract(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                        CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                        CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                        CqlQuantity nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Quantity(120m, "minutes");
                        CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Add(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                        CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Interval(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, true, true);
                        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.In<CqlDateTime>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, default);
                        Code<ObservationStatus> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = O2Saturation?.StatusElement;
                        ObservationStatus? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_?.Value;
                        Code<ObservationStatus> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<Code<ObservationStatus>>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                        string nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Convert<string>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                        string[] nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.In<string>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ as IEnumerable<string>);
                        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                        DataType nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = O2Saturation?.Value;
                        object nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Not((bool?)(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ is null));
                        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

                        return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
                    };
                    IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Observation>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                    object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_(Observation @this)
                    {
                        object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_()
                        {
                            bool ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_()
                            {
                                DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = @this?.Effective;
                                object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                                bool ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ is CqlDateTime;

                                return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
                            };
                            bool ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_()
                            {
                                DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = @this?.Effective;
                                object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                                bool pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ is CqlInterval<CqlDateTime>;

                                return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
                            };
                            bool ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_()
                            {
                                DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = @this?.Effective;
                                object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                                bool pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ is CqlDateTime;

                                return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
                            };
                            if (ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_())
                            {
                                DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = @this?.Effective;
                                object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

                                return (pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ as CqlDateTime) as object;
                            }
                            else if (ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_())
                            {
                                DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = @this?.Effective;
                                object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

                                return (pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_())
                            {
                                DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = @this?.Effective;
                                object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

                                return (pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.earliest(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_());

                        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
                    };
                    IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.SortBy<Observation>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.First<Observation>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                    DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_?.Effective;
                    object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

                    return (mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ as CqlDateTime) as object;
                }
                else if (ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_())
                {
                    CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
                    IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(Observation O2Saturation)
                    {
                        object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_()
                        {
                            bool qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_()
                            {
                                DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = O2Saturation?.Effective;
                                object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                                bool qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ is CqlDateTime;

                                return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
                            };
                            bool qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_()
                            {
                                DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = O2Saturation?.Effective;
                                object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                                bool rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ is CqlInterval<CqlDateTime>;

                                return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
                            };
                            bool qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_()
                            {
                                DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = O2Saturation?.Effective;
                                object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                                bool rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ is CqlDateTime;

                                return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
                            };
                            if (qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_())
                            {
                                DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = O2Saturation?.Effective;
                                object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

                                return (rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ as CqlDateTime) as object;
                            }
                            else if (qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_())
                            {
                                DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = O2Saturation?.Effective;
                                object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

                                return (rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_())
                            {
                                DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = O2Saturation?.Effective;
                                object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

                                return (rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.earliest(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_());
                        Period pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = EncounterInpatient?.Period;
                        CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                        CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                        CqlQuantity pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Quantity(1440m, "minutes");
                        CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Subtract(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                        CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                        CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                        CqlQuantity qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Quantity(120m, "minutes");
                        CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Add(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                        CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Interval(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, true, true);
                        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.In<CqlDateTime>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, default);
                        Code<ObservationStatus> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = O2Saturation?.StatusElement;
                        ObservationStatus? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_?.Value;
                        Code<ObservationStatus> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<Code<ObservationStatus>>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                        string qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<string>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                        string[] qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.In<string>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ as IEnumerable<string>);
                        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                        DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = O2Saturation?.Value;
                        object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Not((bool?)(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ is null));
                        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

                        return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
                    };
                    IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Observation>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                    object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(Observation @this)
                    {
                        object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_()
                        {
                            bool rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_()
                            {
                                DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = @this?.Effective;
                                object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                                bool rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ is CqlDateTime;

                                return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
                            };
                            bool rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_()
                            {
                                DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = @this?.Effective;
                                object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                                bool rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ is CqlInterval<CqlDateTime>;

                                return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
                            };
                            bool rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_()
                            {
                                DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = @this?.Effective;
                                object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                                bool rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ is CqlDateTime;

                                return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
                            };
                            if (rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_())
                            {
                                DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = @this?.Effective;
                                object szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

                                return (szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ as CqlDateTime) as object;
                            }
                            else if (rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_())
                            {
                                DataType szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = @this?.Effective;
                                object szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

                                return (szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_())
                            {
                                DataType szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = @this?.Effective;
                                object szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

                                return (szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.earliest(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_());

                        return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
                    };
                    IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.SortBy<Observation>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.First<Observation>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                    DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_?.Effective;
                    object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

                    return (pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_())
                {
                    CqlValueSet szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
                    IEnumerable<Observation> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(Observation O2Saturation)
                    {
                        object szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_()
                        {
                            bool tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_()
                            {
                                DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = O2Saturation?.Effective;
                                object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                                bool tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ is CqlDateTime;

                                return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
                            };
                            bool tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_()
                            {
                                DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = O2Saturation?.Effective;
                                object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                                bool tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ is CqlInterval<CqlDateTime>;

                                return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
                            };
                            bool tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_()
                            {
                                DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = O2Saturation?.Effective;
                                object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                                bool tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ is CqlDateTime;

                                return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
                            };
                            if (tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_())
                            {
                                DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = O2Saturation?.Effective;
                                object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

                                return (uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ as CqlDateTime) as object;
                            }
                            else if (tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_())
                            {
                                DataType uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = O2Saturation?.Effective;
                                object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

                                return (uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_())
                            {
                                DataType uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = O2Saturation?.Effective;
                                object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

                                return (uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.earliest(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_());
                        Period szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = EncounterInpatient?.Period;
                        CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                        CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                        CqlQuantity szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Quantity(1440m, "minutes");
                        CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Subtract(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                        CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                        CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                        CqlQuantity szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Quantity(120m, "minutes");
                        CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Add(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                        CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Interval(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, true, true);
                        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDateTime>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, default);
                        Code<ObservationStatus> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = O2Saturation?.StatusElement;
                        ObservationStatus? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_?.Value;
                        Code<ObservationStatus> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Convert<Code<ObservationStatus>>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                        string tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<string>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                        string[] tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.In<string>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ as IEnumerable<string>);
                        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                        DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = O2Saturation?.Value;
                        object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Not((bool?)(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ is null));
                        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

                        return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
                    };
                    IEnumerable<Observation> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Observation>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                    object szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_(Observation @this)
                    {
                        object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_()
                        {
                            bool uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_()
                            {
                                DataType uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = @this?.Effective;
                                object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                                bool uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ is CqlDateTime;

                                return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
                            };
                            bool uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_()
                            {
                                DataType uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = @this?.Effective;
                                object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                                bool uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ is CqlInterval<CqlDateTime>;

                                return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
                            };
                            bool uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_()
                            {
                                DataType uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = @this?.Effective;
                                object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                                bool uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ is CqlDateTime;

                                return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
                            };
                            if (uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_())
                            {
                                DataType uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = @this?.Effective;
                                object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

                                return (uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ as CqlDateTime) as object;
                            }
                            else if (uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_())
                            {
                                DataType uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = @this?.Effective;
                                object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

                                return (uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_())
                            {
                                DataType uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = @this?.Effective;
                                object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

                                return (uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.earliest(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_());

                        return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
                    };
                    IEnumerable<Observation> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.SortBy<Observation>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.First<Observation>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                    DataType szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_?.Effective;
                    object szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

                    return (szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.earliest(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_());
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = (CqlTupleMetadata_FdREYEdHOZIcMCNYCRFJYJReA, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ as CqlQuantity, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

            return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)?> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)?>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)?> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)?>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

        return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Encounter with First Bicarbonate Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)?> Encounter_with_First_Bicarbonate_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_(Encounter EncounterInpatient)
        {
            Id vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = EncounterInpatient?.IdElement;
            string vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_?.Value;
            CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Bicarbonate_lab_test(context);
            IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(Observation BicarbonateLab)
            {
                Instant vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = BicarbonateLab?.IssuedElement;
                DateTimeOffset? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_?.Value;
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Convert<CqlDateTime>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.earliest(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ as object);
                Period wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlQuantity wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Subtract(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Start(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Add(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Interval(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, true, true);
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.In<CqlDateTime>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, default);
                Code<ObservationStatus> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = BicarbonateLab?.StatusElement;
                ObservationStatus? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_?.Value;
                string wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Convert<string>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                string[] wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.In<string>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ as IEnumerable<string>);
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                DataType wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = BicarbonateLab?.Value;
                object wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Not((bool?)(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ is null));
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

                return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
            };
            IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Observation>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            object vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_(Observation @this)
            {
                Instant wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = @this?.IssuedElement;
                DateTimeOffset? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_?.Value;
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Convert<CqlDateTime>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.earliest(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ as object);

                return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.SortBy<Observation>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, System.ComponentModel.ListSortDirection.Ascending);
            Observation vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.First<Observation>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            DataType vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_?.Value;
            object vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_(Observation BicarbonateLab)
            {
                Instant xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = BicarbonateLab?.IssuedElement;
                DateTimeOffset? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_?.Value;
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<CqlDateTime>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.earliest(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ as object);
                Period xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlQuantity xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Subtract(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Add(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Interval(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, true, true);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, default);
                Code<ObservationStatus> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = BicarbonateLab?.StatusElement;
                ObservationStatus? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_?.Value;
                string xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Convert<string>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                string[] xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.In<string>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ as IEnumerable<string>);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                DataType xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = BicarbonateLab?.Value;
                object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Not((bool?)(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ is null));
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

                return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Observation>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            object vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(Observation @this)
            {
                Instant yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = @this?.IssuedElement;
                DateTimeOffset? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_?.Value;
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<CqlDateTime>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.earliest(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ as object);

                return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.SortBy<Observation>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, System.ComponentModel.ListSortDirection.Ascending);
            Observation vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.First<Observation>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            Instant vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_?.IssuedElement;
            DateTimeOffset? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_?.Value;
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<CqlDateTime>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = (CqlTupleMetadata_GbUHPXXHScejjXWhcHJFQQifQ, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ as CqlQuantity, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

            return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)?> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)?>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)?> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)?>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

        return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Encounter with First Creatinine Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)?> Encounter_with_First_Creatinine_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Encounter EncounterInpatient)
        {
            Id yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = EncounterInpatient?.IdElement;
            string yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_?.Value;
            CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Creatinine_lab_test(context);
            IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(Observation CreatinineLab)
            {
                Instant zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = CreatinineLab?.IssuedElement;
                DateTimeOffset? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_?.Value;
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Convert<CqlDateTime>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.earliest(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ as object);
                Period zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlQuantity zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Subtract(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Add(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Interval(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, true, true);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.In<CqlDateTime>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, default);
                Code<ObservationStatus> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = CreatinineLab?.StatusElement;
                ObservationStatus? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_?.Value;
                string zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Convert<string>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                string[] azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.In<string>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ as IEnumerable<string>);
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                DataType azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = CreatinineLab?.Value;
                object azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Not((bool?)(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ is null));
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

                return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Observation>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(Observation @this)
            {
                Instant azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = @this?.IssuedElement;
                DateTimeOffset? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_?.Value;
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Convert<CqlDateTime>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.earliest(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ as object);

                return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
            };
            IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.SortBy<Observation>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, System.ComponentModel.ListSortDirection.Ascending);
            Observation yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.First<Observation>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_?.Value;
            object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_(Observation CreatinineLab)
            {
                Instant azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = CreatinineLab?.IssuedElement;
                DateTimeOffset? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_?.Value;
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Convert<CqlDateTime>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.earliest(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ as object);
                Period azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Start(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlQuantity azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Subtract(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Add(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Interval(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, true, true);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, default);
                Code<ObservationStatus> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = CreatinineLab?.StatusElement;
                ObservationStatus? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_?.Value;
                string bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Convert<string>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                string[] bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.In<string>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ as IEnumerable<string>);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = CreatinineLab?.Value;
                object bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Not((bool?)(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ is null));
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

                return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
            };
            IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Observation>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            object zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_(Observation @this)
            {
                Instant bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = @this?.IssuedElement;
                DateTimeOffset? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_?.Value;
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Convert<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.earliest(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ as object);

                return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<Observation> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.SortBy<Observation>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, System.ComponentModel.ListSortDirection.Ascending);
            Observation zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.First<Observation>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            Instant zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_?.IssuedElement;
            DateTimeOffset? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_?.Value;
            CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<CqlDateTime>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = (CqlTupleMetadata_FETECNQPQREfGRgPYWhOWgeWA, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ as CqlQuantity, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

            return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)?> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)?>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)?> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)?>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

        return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Encounter with First Hematocrit Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?> Encounter_with_First_Hematocrit_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_(Encounter EncounterInpatient)
        {
            Id bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = EncounterInpatient?.IdElement;
            string bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_?.Value;
            CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Hematocrit_lab_test(context);
            IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_(Observation HematocritLab)
            {
                Instant czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = HematocritLab?.IssuedElement;
                DateTimeOffset? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_?.Value;
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Convert<CqlDateTime>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.earliest(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ as object);
                Period czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlQuantity czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Subtract(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Add(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Interval(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, true, true);
                bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.In<CqlDateTime>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, default);
                Code<ObservationStatus> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = HematocritLab?.StatusElement;
                ObservationStatus? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_?.Value;
                string dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Convert<string>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                string[] dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.In<string>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ as IEnumerable<string>);
                bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = HematocritLab?.Value;
                object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Not((bool?)(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ is null));
                bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

                return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Observation>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            object bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_(Observation @this)
            {
                Instant dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = @this?.IssuedElement;
                DateTimeOffset? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_?.Value;
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Convert<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.earliest(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ as object);

                return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.SortBy<Observation>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, System.ComponentModel.ListSortDirection.Ascending);
            Observation czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.First<Observation>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            DataType czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_?.Value;
            object czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_(Observation HematocritLab)
            {
                Instant dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = HematocritLab?.IssuedElement;
                DateTimeOffset? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_?.Value;
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Convert<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.earliest(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ as object);
                Period dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Start(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlQuantity ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Subtract(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Add(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Interval(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, true, true);
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.In<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, default);
                Code<ObservationStatus> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = HematocritLab?.StatusElement;
                ObservationStatus? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_?.Value;
                string ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<string>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                string[] ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.In<string>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ as IEnumerable<string>);
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                DataType ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = HematocritLab?.Value;
                object ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Not((bool?)(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ is null));
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

                return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Observation>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            object czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Observation @this)
            {
                Instant ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = @this?.IssuedElement;
                DateTimeOffset? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_?.Value;
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Convert<CqlDateTime>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.earliest(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ as object);

                return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.SortBy<Observation>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, System.ComponentModel.ListSortDirection.Ascending);
            Observation czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.First<Observation>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            Instant czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_?.IssuedElement;
            DateTimeOffset? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_?.Value;
            CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Convert<CqlDateTime>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = (CqlTupleMetadata_DIHdhbAJeJTdiAVUAELUHRNdS, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ as CqlQuantity, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

            return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

        return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Encounter with First Platelet Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)?> Encounter_with_First_Platelet_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_(Encounter EncounterInpatient)
        {
            Id fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = EncounterInpatient?.IdElement;
            string fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_?.Value;
            CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Platelet_count_lab_test(context);
            IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_(Observation PlateletLab)
            {
                Instant fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = PlateletLab?.IssuedElement;
                DateTimeOffset? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_?.Value;
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Convert<CqlDateTime>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.earliest(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ as object);
                Period gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlQuantity gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Subtract(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Add(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Interval(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, true, true);
                bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.In<CqlDateTime>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, default);
                Code<ObservationStatus> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = PlateletLab?.StatusElement;
                ObservationStatus? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_?.Value;
                string gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Convert<string>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                string[] gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.In<string>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ as IEnumerable<string>);
                bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = PlateletLab?.Value;
                object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Not((bool?)(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ is null));
                bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

                return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Observation>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            object fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(Observation @this)
            {
                Instant gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = @this?.IssuedElement;
                DateTimeOffset? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_?.Value;
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Convert<CqlDateTime>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.earliest(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ as object);

                return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
            };
            IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.SortBy<Observation>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, System.ComponentModel.ListSortDirection.Ascending);
            Observation fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.First<Observation>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            DataType fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_?.Value;
            object fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Observation PlateletLab)
            {
                Instant hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = PlateletLab?.IssuedElement;
                DateTimeOffset? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_?.Value;
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Convert<CqlDateTime>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.earliest(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ as object);
                Period hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Start(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlQuantity hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Subtract(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Add(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Interval(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, true, true);
                bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.In<CqlDateTime>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, default);
                Code<ObservationStatus> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = PlateletLab?.StatusElement;
                ObservationStatus? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_?.Value;
                string hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Convert<string>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                string[] hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.In<string>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ as IEnumerable<string>);
                bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                DataType hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = PlateletLab?.Value;
                object hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Not((bool?)(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ is null));
                bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

                return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
            };
            IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Observation>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            object fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_(Observation @this)
            {
                Instant izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = @this?.IssuedElement;
                DateTimeOffset? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_?.Value;
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Convert<CqlDateTime>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.earliest(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ as object);

                return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.SortBy<Observation>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, System.ComponentModel.ListSortDirection.Ascending);
            Observation fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.First<Observation>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            Instant fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_?.IssuedElement;
            DateTimeOffset? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_?.Value;
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Convert<CqlDateTime>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = (CqlTupleMetadata_DAUcYHQZcDKbIfORJOEZBDgIh, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ as CqlQuantity, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

            return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)?> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)?>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)?> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)?>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

        return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Encounter with First Sodium Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)?> Encounter_with_First_Sodium_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_(Encounter EncounterInpatient)
        {
            Id izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = EncounterInpatient?.IdElement;
            string izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_?.Value;
            CqlValueSet izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Sodium_lab_test(context);
            IEnumerable<Observation> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(Observation SodiumLab)
            {
                Instant jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = SodiumLab?.IssuedElement;
                DateTimeOffset? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_?.Value;
                CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Convert<CqlDateTime>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.earliest(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ as object);
                Period jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlQuantity jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Subtract(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Add(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Interval(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, true, true);
                bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, default);
                Code<ObservationStatus> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = SodiumLab?.StatusElement;
                ObservationStatus? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_?.Value;
                string jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<string>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                string[] jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<string>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ as IEnumerable<string>);
                bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                DataType kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = SodiumLab?.Value;
                object kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Not((bool?)(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ is null));
                bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

                return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<Observation> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Observation>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(Observation @this)
            {
                Instant kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = @this?.IssuedElement;
                DateTimeOffset? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_?.Value;
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Convert<CqlDateTime>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.earliest(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ as object);

                return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<Observation> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.SortBy<Observation>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, System.ComponentModel.ListSortDirection.Ascending);
            Observation izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.First<Observation>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_?.Value;
            object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            IEnumerable<Observation> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_(Observation SodiumLab)
            {
                Instant kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = SodiumLab?.IssuedElement;
                DateTimeOffset? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_?.Value;
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<CqlDateTime>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.earliest(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ as object);
                Period kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlQuantity kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Subtract(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Add(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Interval(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, true, true);
                bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, default);
                Code<ObservationStatus> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = SodiumLab?.StatusElement;
                ObservationStatus? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_?.Value;
                string lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Convert<string>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                string[] lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<string>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ as IEnumerable<string>);
                bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = SodiumLab?.Value;
                object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Not((bool?)(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ is null));
                bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

                return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<Observation> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Observation>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_(Observation @this)
            {
                Instant lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = @this?.IssuedElement;
                DateTimeOffset? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_?.Value;
                CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<CqlDateTime>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.earliest(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ as object);

                return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
            };
            IEnumerable<Observation> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.SortBy<Observation>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, System.ComponentModel.ListSortDirection.Ascending);
            Observation jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.First<Observation>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            Instant jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_?.IssuedElement;
            DateTimeOffset? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_?.Value;
            CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Convert<CqlDateTime>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = (CqlTupleMetadata_GKGeLARADLGJcNcZaDhdCREMa, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ as CqlQuantity, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

            return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)?> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)?>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)?> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)?>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

        return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Qualifying Blood Pressure Reading")]
    public IEnumerable<Observation> Qualifying_Blood_Pressure_Reading(CqlContext context)
    {
        IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bp"));
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Observation BPReading)
        {
            DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = BPReading?.Effective;
            object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.earliest(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Measurement_Period(context);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, "day");
            Code<ObservationStatus> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = BPReading?.StatusElement;
            ObservationStatus? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_?.Value;
            string lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<string>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            string[] lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<string>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ as IEnumerable<string>);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

            return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Observation>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

        return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Test2")]
    public CqlQuantity Test2(CqlContext context)
    {
        IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Qualifying_Blood_Pressure_Reading(context);
        IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_(Observation SBPReading)
        {
            IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Inpatient_Encounters(context);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Encounter EncounterInpatient)
            {
                DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = SBPReading?.Effective;
                object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.earliest(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                Period mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlQuantity mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Subtract(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlQuantity mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Add(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Interval(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, true, true);
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.In<CqlDateTime>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, default);

                return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Encounter>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            Observation mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_(Encounter EncounterInpatient) =>
                SBPReading;
            IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Select<Encounter, Observation>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

            return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.SelectMany<Observation, Observation>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        CqlQuantity mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_(Observation SBPReading)
        {
            List<Observation.ComponentComponent> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = SBPReading?.Component;
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_(Observation.ComponentComponent SBPComponent)
            {
                CodeableConcept nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = SBPComponent?.Code;
                CqlConcept nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlCode nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Systolic_blood_pressure(context);
                CqlConcept nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.ConvertCodeToConcept(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Equivalent(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

                return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<Observation.ComponentComponent> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlQuantity nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_(Observation.ComponentComponent SBPComponent)
            {
                DataType nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = SBPComponent?.Value;
                object nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

                return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ as CqlQuantity;
            };
            IEnumerable<CqlQuantity> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Select<Observation.ComponentComponent, CqlQuantity>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            IEnumerable<CqlQuantity> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Distinct<CqlQuantity>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlQuantity nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.SingletonFrom<CqlQuantity>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

            return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<CqlQuantity> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Select<Observation, CqlQuantity>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        IEnumerable<CqlQuantity> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Distinct<CqlQuantity>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        IEnumerable<CqlQuantity> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.ListSort<CqlQuantity>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, System.ComponentModel.ListSortDirection.Ascending);
        CqlQuantity mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.First<CqlQuantity>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

        return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Encounter with First White Blood Cells Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)?> Encounter_with_First_White_Blood_Cells_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(Encounter EncounterInpatient)
        {
            Id nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = EncounterInpatient?.IdElement;
            string nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_?.Value;
            CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.White_blood_cells_count_lab_test(context);
            IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_(Observation WhiteBloodCellLab)
            {
                Instant ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = WhiteBloodCellLab?.IssuedElement;
                DateTimeOffset? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_?.Value;
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Convert<CqlDateTime>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.earliest(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ as object);
                Period ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlQuantity ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Subtract(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Add(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Interval(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, true, true);
                bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.In<CqlDateTime>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, default);
                Code<ObservationStatus> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = WhiteBloodCellLab?.StatusElement;
                ObservationStatus? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_?.Value;
                string pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Convert<string>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                string[] pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.In<string>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ as IEnumerable<string>);
                bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = WhiteBloodCellLab?.Value;
                object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Not((bool?)(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ is null));
                bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

                return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
            };
            IEnumerable<Observation> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Observation>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_(Observation @this)
            {
                Instant pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = @this?.IssuedElement;
                DateTimeOffset? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_?.Value;
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Convert<CqlDateTime>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.earliest(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ as object);

                return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
            };
            IEnumerable<Observation> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.SortBy<Observation>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, System.ComponentModel.ListSortDirection.Ascending);
            Observation ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.First<Observation>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_?.Value;
            object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            IEnumerable<Observation> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Observation WhiteBloodCellLab)
            {
                Instant pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = WhiteBloodCellLab?.IssuedElement;
                DateTimeOffset? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_?.Value;
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<CqlDateTime>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.earliest(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ as object);
                Period pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlQuantity qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Subtract(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Add(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Interval(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, true, true);
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.In<CqlDateTime>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, default);
                Code<ObservationStatus> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = WhiteBloodCellLab?.StatusElement;
                ObservationStatus? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_?.Value;
                string qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Convert<string>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                string[] qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.In<string>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ as IEnumerable<string>);
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = WhiteBloodCellLab?.Value;
                object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Not((bool?)(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ is null));
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

                return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
            };
            IEnumerable<Observation> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Observation>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Observation @this)
            {
                Instant qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = @this?.IssuedElement;
                DateTimeOffset? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_?.Value;
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<CqlDateTime>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.earliest(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ as object);

                return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
            };
            IEnumerable<Observation> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.SortBy<Observation>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, System.ComponentModel.ListSortDirection.Ascending);
            Observation ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.First<Observation>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            Instant ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_?.IssuedElement;
            DateTimeOffset? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_?.Value;
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Convert<CqlDateTime>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = (CqlTupleMetadata_ChVYCdXDGgVcFTCCUefXMbCHX, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ as CqlQuantity, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

            return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)?> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)?>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)?> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)?>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

        return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_ChVYCdXDGgVcFTCCUefXMbCHX = new(
        [typeof(string), typeof(CqlQuantity), typeof(CqlDateTime)],
        ["EncounterId", "FirstWhiteBloodCellResult", "Timing"]);

    private static CqlTupleMetadata CqlTupleMetadata_DAUcYHQZcDKbIfORJOEZBDgIh = new(
        [typeof(string), typeof(CqlQuantity), typeof(CqlDateTime)],
        ["EncounterId", "FirstPlateletResult", "Timing"]);

    private static CqlTupleMetadata CqlTupleMetadata_DhbJAfCiKIAGYKTjJXYGSKECQ = new(
        [typeof(string), typeof(CqlQuantity), typeof(CqlDateTime)],
        ["EncounterId", "FirstHeartRateResult", "Timing"]);

    private static CqlTupleMetadata CqlTupleMetadata_DIHdhbAJeJTdiAVUAELUHRNdS = new(
        [typeof(string), typeof(CqlQuantity), typeof(CqlDateTime)],
        ["EncounterId", "FirstHematocritResult", "Timing"]);

    private static CqlTupleMetadata CqlTupleMetadata_FdREYEdHOZIcMCNYCRFJYJReA = new(
        [typeof(string), typeof(CqlQuantity), typeof(CqlDateTime)],
        ["EncounterId", "FirstOxygenSatResult", "Timing"]);

    private static CqlTupleMetadata CqlTupleMetadata_FETECNQPQREfGRgPYWhOWgeWA = new(
        [typeof(string), typeof(CqlQuantity), typeof(CqlDateTime)],
        ["EncounterId", "FirstCreatinineResult", "Timing"]);

    private static CqlTupleMetadata CqlTupleMetadata_GbUHPXXHScejjXWhcHJFQQifQ = new(
        [typeof(string), typeof(CqlQuantity), typeof(CqlDateTime)],
        ["EncounterId", "FirstBicarbonateResult", "Timing"]);

    private static CqlTupleMetadata CqlTupleMetadata_GIbILVAdXLLNYBgcQIEiUiKaK = new(
        [typeof(string), typeof(CqlQuantity), typeof(CqlDateTime)],
        ["EncounterId", "FirstTemperatureResult", "Timing"]);

    private static CqlTupleMetadata CqlTupleMetadata_GKGeLARADLGJcNcZaDhdCREMa = new(
        [typeof(string), typeof(CqlQuantity), typeof(CqlDateTime)],
        ["EncounterId", "FirstSodiumResult", "Timing"]);

    #endregion CqlTupleMetadata Properties

}
