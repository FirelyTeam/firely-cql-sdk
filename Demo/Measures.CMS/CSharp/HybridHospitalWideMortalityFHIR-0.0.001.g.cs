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
        CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Interval(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, true, true);
        object vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.ResolveParameter("HybridHospitalWideMortalityFHIR-0.0.001", "Measurement Period", vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

        return (CqlInterval<CqlDateTime>)vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.SingletonFrom<Patient>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

        return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Inpatient Encounters")]
    public IEnumerable<Encounter> Inpatient_Encounters(CqlContext context)
    {
        CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Encounter InpatientEncounter)
        {
            CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Medicare_FFS_payer(context);
            IEnumerable<Coverage> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Coverage>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-coverage"));
            CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Medicare_Advantage_payer(context);
            IEnumerable<Coverage> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Coverage>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-coverage"));
            IEnumerable<Coverage> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<Coverage>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(Coverage MedicarePayer)
            {
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, InpatientEncounter);
                int? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = CQMCommon_2_2_000.Instance.lengthInDays(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Less(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, 365);
                Code<Encounter.EncounterStatus> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = InpatientEncounter?.StatusElement;
                Encounter.EncounterStatus? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_?.Value;
                Code<Encounter.EncounterStatus> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Equal(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, "finished");
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                Patient wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Patient(context);
                Date wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_?.BirthDateElement;
                string wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_?.Value;
                CqlDate wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.ConvertStringToDate(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                Period wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Start(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlDate wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.DateFrom(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                int? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.CalculateAgeAt(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, "year");
                CqlInterval<int?> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Interval(65, 94, true, true);
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.In<int?>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, default);
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.End(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Measurement_Period(context);
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.In<CqlDateTime>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, "day");
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

                return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
            };
            IEnumerable<Coverage> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Coverage>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            Encounter vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_(Coverage MedicarePayer) =>
                InpatientEncounter;
            IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Select<Coverage, Encounter>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

            return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.SelectMany<Encounter, Encounter>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Inpatient_Encounters(context);

        return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Encounter with First Body Temperature")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)?> Encounter_with_First_Body_Temperature(CqlContext context)
    {
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_(Encounter EncounterInpatient)
        {
            Id xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = EncounterInpatient?.IdElement;
            string xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_?.Value;
            IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bodytemp"));
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_(Observation temperature)
            {
                DataType xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = temperature?.Effective;
                object xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.earliest(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                Period xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlQuantity yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Subtract(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlQuantity yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Add(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Interval(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, true, true);
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, default);
                Code<ObservationStatus> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = temperature?.StatusElement;
                ObservationStatus? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_?.Value;
                string yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<string>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                string[] yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.In<string>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ as IEnumerable<string>);
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = temperature?.Value;
                CqlQuantity yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ as Quantity);
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Not((bool?)(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ is null));
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

                return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Observation>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            object xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_(Observation @this)
            {
                DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = @this?.Effective;
                object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.earliest(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

                return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.SortBy<Observation>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, System.ComponentModel.ListSortDirection.Ascending);
            Observation xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.First<Observation>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            DataType xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_?.Value;
            CqlQuantity xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ as Quantity);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_(Observation temperature)
            {
                DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = temperature?.Effective;
                object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.earliest(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                Period yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlQuantity zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Subtract(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlQuantity zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Add(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Interval(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, true, true);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.In<CqlDateTime>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, default);
                Code<ObservationStatus> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = temperature?.StatusElement;
                ObservationStatus? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_?.Value;
                string zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Convert<string>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                string[] zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.In<string>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ as IEnumerable<string>);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                DataType zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = temperature?.Value;
                CqlQuantity zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ as Quantity);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Not((bool?)(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ is null));
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

                return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
            };
            IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Observation>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            object xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(Observation @this)
            {
                DataType zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = @this?.Effective;
                object zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.earliest(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

                return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
            };
            IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.SortBy<Observation>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, System.ComponentModel.ListSortDirection.Ascending);
            Observation xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.First<Observation>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            DataType xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_?.Effective;
            object xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.earliest(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = (CqlTupleMetadata_GIbILVAdXLLNYBgcQIEiUiKaK, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ as CqlQuantity, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

            return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)?> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)?>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)?> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)?>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

        return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Encounter with First Heart Rate")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)?> Encounter_with_First_Heart_Rate(CqlContext context)
    {
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_(Encounter EncounterInpatient)
        {
            Id azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = EncounterInpatient?.IdElement;
            string azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_?.Value;
            IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/heartrate"));
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_(Observation HeartRate)
            {
                DataType azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = HeartRate?.Effective;
                object azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.earliest(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                Period azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlQuantity bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Subtract(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlQuantity bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Add(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Interval(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, true, true);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.In<CqlDateTime>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, default);
                Code<ObservationStatus> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = HeartRate?.StatusElement;
                ObservationStatus? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_?.Value;
                string bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Convert<string>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                string[] bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.In<string>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ as IEnumerable<string>);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = HeartRate?.Value;
                CqlQuantity bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ as Quantity);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Not((bool?)(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ is null));
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

                return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
            };
            IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Observation>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            object azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(Observation @this)
            {
                DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = @this?.Effective;
                object bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.earliest(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

                return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
            };
            IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.SortBy<Observation>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, System.ComponentModel.ListSortDirection.Ascending);
            Observation azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.First<Observation>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            DataType azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_?.Value;
            CqlQuantity azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ as Quantity);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(Observation HeartRate)
            {
                DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = HeartRate?.Effective;
                object bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.earliest(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                Period czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlQuantity czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Subtract(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlQuantity czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Add(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Interval(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, true, true);
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.In<CqlDateTime>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, default);
                Code<ObservationStatus> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = HeartRate?.StatusElement;
                ObservationStatus? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_?.Value;
                string czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Convert<string>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                string[] czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.In<string>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ as IEnumerable<string>);
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                DataType czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = HeartRate?.Value;
                CqlQuantity czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ as Quantity);
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Not((bool?)(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ is null));
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

                return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Observation>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            object azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(Observation @this)
            {
                DataType czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = @this?.Effective;
                object czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.earliest(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

                return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.SortBy<Observation>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, System.ComponentModel.ListSortDirection.Ascending);
            Observation azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.First<Observation>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            DataType azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_?.Effective;
            object azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.earliest(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = (CqlTupleMetadata_DhbJAfCiKIAGYKTjJXYGSKECQ, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ as CqlQuantity, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

            return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)?> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)?>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)?> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)?>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Encounter with First Oxygen Saturation")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)?> Encounter_with_First_Oxygen_Saturation(CqlContext context)
    {
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_(Encounter EncounterInpatient)
        {
            Id dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = EncounterInpatient?.IdElement;
            string dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_?.Value;
            CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
            IEnumerable<Observation> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Observation O2Saturation)
            {
                object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_()
                {
                    bool ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_()
                    {
                        DataType ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = O2Saturation?.Effective;
                        object ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                        bool ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ is CqlDateTime;

                        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
                    };
                    bool ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_()
                    {
                        DataType ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = O2Saturation?.Effective;
                        object ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                        bool ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ is CqlInterval<CqlDateTime>;

                        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
                    };
                    bool ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_()
                    {
                        DataType fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = O2Saturation?.Effective;
                        object fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                        bool fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ is CqlDateTime;

                        return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
                    };
                    if (ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_())
                    {
                        DataType fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = O2Saturation?.Effective;
                        object fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

                        return (fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ as CqlDateTime) as object;
                    }
                    else if (ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_())
                    {
                        DataType fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = O2Saturation?.Effective;
                        object fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

                        return (fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_())
                    {
                        DataType fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = O2Saturation?.Effective;
                        object fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

                        return (fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ as CqlDateTime) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.earliest(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_());
                Period dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlQuantity dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Subtract(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlQuantity ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Add(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Interval(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, true, true);
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.In<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, default);
                Code<ObservationStatus> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = O2Saturation?.StatusElement;
                ObservationStatus? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_?.Value;
                Code<ObservationStatus> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Convert<Code<ObservationStatus>>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                string ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Convert<string>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                string[] ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.In<string>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ as IEnumerable<string>);
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                DataType ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = O2Saturation?.Value;
                object ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Not((bool?)(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ is null));
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

                return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
            };
            IEnumerable<Observation> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Observation>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Observation @this)
            {
                object fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_()
                {
                    bool fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_()
                    {
                        DataType fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = @this?.Effective;
                        object fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                        bool fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ is CqlDateTime;

                        return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
                    };
                    bool fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_()
                    {
                        DataType fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = @this?.Effective;
                        object fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                        bool fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ is CqlInterval<CqlDateTime>;

                        return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
                    };
                    bool fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_()
                    {
                        DataType fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = @this?.Effective;
                        object fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                        bool fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ is CqlDateTime;

                        return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
                    };
                    if (fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_())
                    {
                        DataType fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = @this?.Effective;
                        object fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

                        return (fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ as CqlDateTime) as object;
                    }
                    else if (fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_())
                    {
                        DataType fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = @this?.Effective;
                        object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

                        return (gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_())
                    {
                        DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = @this?.Effective;
                        object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

                        return (gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ as CqlDateTime) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.earliest(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_());

                return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
            };
            IEnumerable<Observation> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.SortBy<Observation>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, System.ComponentModel.ListSortDirection.Ascending);
            Observation dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.First<Observation>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_?.Value;
            object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_()
            {
                bool gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_()
                {
                    CqlValueSet gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
                    IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Observation O2Saturation)
                    {
                        object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_()
                        {
                            bool hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_()
                            {
                                DataType hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = O2Saturation?.Effective;
                                object hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                                bool hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ is CqlDateTime;

                                return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
                            };
                            bool hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_()
                            {
                                DataType hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = O2Saturation?.Effective;
                                object hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                                bool hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ is CqlInterval<CqlDateTime>;

                                return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
                            };
                            bool hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_()
                            {
                                DataType hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = O2Saturation?.Effective;
                                object hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                                bool izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ is CqlDateTime;

                                return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
                            };
                            if (hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_())
                            {
                                DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = O2Saturation?.Effective;
                                object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

                                return (izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ as CqlDateTime) as object;
                            }
                            else if (hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_())
                            {
                                DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = O2Saturation?.Effective;
                                object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

                                return (izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_())
                            {
                                DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = O2Saturation?.Effective;
                                object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

                                return (izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.earliest(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_());
                        Period gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = EncounterInpatient?.Period;
                        CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                        CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                        CqlQuantity gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Quantity(1440m, "minutes");
                        CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Subtract(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                        CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                        CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                        CqlQuantity hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Quantity(120m, "minutes");
                        CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Add(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                        CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Interval(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, true, true);
                        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, default);
                        Code<ObservationStatus> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = O2Saturation?.StatusElement;
                        ObservationStatus? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_?.Value;
                        Code<ObservationStatus> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<Code<ObservationStatus>>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                        string hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Convert<string>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                        string[] hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.In<string>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ as IEnumerable<string>);
                        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                        DataType hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = O2Saturation?.Value;
                        object hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Not((bool?)(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ is null));
                        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

                        return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
                    };
                    IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Observation>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                    object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Observation @this)
                    {
                        object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_()
                        {
                            bool izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_()
                            {
                                DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = @this?.Effective;
                                object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                                bool izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ is CqlDateTime;

                                return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
                            };
                            bool izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_()
                            {
                                DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = @this?.Effective;
                                object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                                bool izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ is CqlInterval<CqlDateTime>;

                                return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
                            };
                            bool izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_()
                            {
                                DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = @this?.Effective;
                                object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                                bool izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ is CqlDateTime;

                                return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
                            };
                            if (izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_())
                            {
                                DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = @this?.Effective;
                                object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

                                return (izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ as CqlDateTime) as object;
                            }
                            else if (izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_())
                            {
                                DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = @this?.Effective;
                                object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

                                return (izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_())
                            {
                                DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = @this?.Effective;
                                object jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

                                return (jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.earliest(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_());

                        return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
                    };
                    IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.SortBy<Observation>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.First<Observation>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                    DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_?.Effective;
                    object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                    bool gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ is CqlDateTime;

                    return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
                };
                bool gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_()
                {
                    CqlValueSet jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
                    IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_(Observation O2Saturation)
                    {
                        object jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_()
                        {
                            bool kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_()
                            {
                                DataType kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = O2Saturation?.Effective;
                                object kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                                bool kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ is CqlDateTime;

                                return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
                            };
                            bool kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_()
                            {
                                DataType kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = O2Saturation?.Effective;
                                object kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                                bool kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ is CqlInterval<CqlDateTime>;

                                return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
                            };
                            bool kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_()
                            {
                                DataType kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = O2Saturation?.Effective;
                                object kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                                bool kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ is CqlDateTime;

                                return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
                            };
                            if (kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_())
                            {
                                DataType kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = O2Saturation?.Effective;
                                object kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

                                return (kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ as CqlDateTime) as object;
                            }
                            else if (kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_())
                            {
                                DataType kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = O2Saturation?.Effective;
                                object kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

                                return (kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_())
                            {
                                DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = O2Saturation?.Effective;
                                object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

                                return (lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.earliest(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_());
                        Period jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = EncounterInpatient?.Period;
                        CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                        CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                        CqlQuantity jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Quantity(1440m, "minutes");
                        CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Subtract(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                        CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                        CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                        CqlQuantity jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Quantity(120m, "minutes");
                        CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Add(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                        CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Interval(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, true, true);
                        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, default);
                        Code<ObservationStatus> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = O2Saturation?.StatusElement;
                        ObservationStatus? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_?.Value;
                        Code<ObservationStatus> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Convert<Code<ObservationStatus>>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                        string kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<string>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                        string[] kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.In<string>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ as IEnumerable<string>);
                        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                        DataType kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = O2Saturation?.Value;
                        object kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Not((bool?)(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ is null));
                        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

                        return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
                    };
                    IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Observation>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                    object jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_(Observation @this)
                    {
                        object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_()
                        {
                            bool lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_()
                            {
                                DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = @this?.Effective;
                                object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                                bool lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ is CqlDateTime;

                                return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
                            };
                            bool lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_()
                            {
                                DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = @this?.Effective;
                                object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                                bool lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ is CqlInterval<CqlDateTime>;

                                return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
                            };
                            bool lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_()
                            {
                                DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = @this?.Effective;
                                object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                                bool lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ is CqlDateTime;

                                return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
                            };
                            if (lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_())
                            {
                                DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = @this?.Effective;
                                object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

                                return (lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ as CqlDateTime) as object;
                            }
                            else if (lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_())
                            {
                                DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = @this?.Effective;
                                object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

                                return (lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_())
                            {
                                DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = @this?.Effective;
                                object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

                                return (lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.earliest(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_());

                        return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
                    };
                    IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.SortBy<Observation>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.First<Observation>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                    DataType jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_?.Effective;
                    object jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                    bool jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ is CqlInterval<CqlDateTime>;

                    return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
                };
                bool gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_()
                {
                    CqlValueSet lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
                    IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_(Observation O2Saturation)
                    {
                        object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_()
                        {
                            bool nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_()
                            {
                                DataType nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = O2Saturation?.Effective;
                                object nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                                bool nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ is CqlDateTime;

                                return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
                            };
                            bool nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_()
                            {
                                DataType nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = O2Saturation?.Effective;
                                object nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                                bool nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ is CqlInterval<CqlDateTime>;

                                return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
                            };
                            bool nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_()
                            {
                                DataType nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = O2Saturation?.Effective;
                                object nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                                bool nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ is CqlDateTime;

                                return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
                            };
                            if (nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_())
                            {
                                DataType nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = O2Saturation?.Effective;
                                object nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

                                return (nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ as CqlDateTime) as object;
                            }
                            else if (nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_())
                            {
                                DataType nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = O2Saturation?.Effective;
                                object nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

                                return (nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_())
                            {
                                DataType nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = O2Saturation?.Effective;
                                object nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

                                return (nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.earliest(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_());
                        Period mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = EncounterInpatient?.Period;
                        CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                        CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                        CqlQuantity mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Quantity(1440m, "minutes");
                        CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Subtract(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                        CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                        CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                        CqlQuantity mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Quantity(120m, "minutes");
                        CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Add(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                        CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Interval(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, true, true);
                        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.In<CqlDateTime>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, default);
                        Code<ObservationStatus> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = O2Saturation?.StatusElement;
                        ObservationStatus? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_?.Value;
                        Code<ObservationStatus> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<Code<ObservationStatus>>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                        string mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<string>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                        string[] mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<string>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ as IEnumerable<string>);
                        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                        DataType nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = O2Saturation?.Value;
                        object nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Not((bool?)(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ is null));
                        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

                        return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
                    };
                    IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Observation>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                    object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_(Observation @this)
                    {
                        object nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_()
                        {
                            bool nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_()
                            {
                                DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = @this?.Effective;
                                object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                                bool ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ is CqlDateTime;

                                return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
                            };
                            bool ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_()
                            {
                                DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = @this?.Effective;
                                object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                                bool ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ is CqlInterval<CqlDateTime>;

                                return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
                            };
                            bool ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_()
                            {
                                DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = @this?.Effective;
                                object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                                bool ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ is CqlDateTime;

                                return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
                            };
                            if (nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_())
                            {
                                DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = @this?.Effective;
                                object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

                                return (ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ as CqlDateTime) as object;
                            }
                            else if (ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_())
                            {
                                DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = @this?.Effective;
                                object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

                                return (ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_())
                            {
                                DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = @this?.Effective;
                                object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

                                return (ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.earliest(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_());

                        return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
                    };
                    IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.SortBy<Observation>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.First<Observation>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                    DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_?.Effective;
                    object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                    bool mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ is CqlDateTime;

                    return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
                };
                if (gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_())
                {
                    CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
                    IEnumerable<Observation> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_(Observation O2Saturation)
                    {
                        object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_()
                        {
                            bool pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_()
                            {
                                DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = O2Saturation?.Effective;
                                object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                                bool qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ is CqlDateTime;

                                return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
                            };
                            bool qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_()
                            {
                                DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = O2Saturation?.Effective;
                                object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                                bool qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ is CqlInterval<CqlDateTime>;

                                return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
                            };
                            bool qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_()
                            {
                                DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = O2Saturation?.Effective;
                                object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                                bool qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ is CqlDateTime;

                                return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
                            };
                            if (pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_())
                            {
                                DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = O2Saturation?.Effective;
                                object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

                                return (qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ as CqlDateTime) as object;
                            }
                            else if (qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_())
                            {
                                DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = O2Saturation?.Effective;
                                object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

                                return (qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_())
                            {
                                DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = O2Saturation?.Effective;
                                object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

                                return (qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.earliest(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_());
                        Period pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = EncounterInpatient?.Period;
                        CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                        CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Start(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                        CqlQuantity pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Quantity(1440m, "minutes");
                        CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Subtract(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                        CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                        CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Start(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                        CqlQuantity pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Quantity(120m, "minutes");
                        CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Add(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                        CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Interval(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, true, true);
                        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.In<CqlDateTime>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, default);
                        Code<ObservationStatus> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = O2Saturation?.StatusElement;
                        ObservationStatus? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_?.Value;
                        Code<ObservationStatus> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<Code<ObservationStatus>>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                        string pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Convert<string>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                        string[] pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.In<string>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ as IEnumerable<string>);
                        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                        DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = O2Saturation?.Value;
                        object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Not((bool?)(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ is null));
                        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

                        return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
                    };
                    IEnumerable<Observation> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Observation>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                    object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_(Observation @this)
                    {
                        object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_()
                        {
                            bool qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_()
                            {
                                DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = @this?.Effective;
                                object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                                bool qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ is CqlDateTime;

                                return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
                            };
                            bool qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_()
                            {
                                DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = @this?.Effective;
                                object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                                bool rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ is CqlInterval<CqlDateTime>;

                                return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
                            };
                            bool qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_()
                            {
                                DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = @this?.Effective;
                                object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                                bool rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ is CqlDateTime;

                                return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
                            };
                            if (qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_())
                            {
                                DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = @this?.Effective;
                                object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

                                return (rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ as CqlDateTime) as object;
                            }
                            else if (qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_())
                            {
                                DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = @this?.Effective;
                                object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

                                return (rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_())
                            {
                                DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = @this?.Effective;
                                object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

                                return (rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.earliest(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_());

                        return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
                    };
                    IEnumerable<Observation> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.SortBy<Observation>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.First<Observation>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                    DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_?.Effective;
                    object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

                    return (ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ as CqlDateTime) as object;
                }
                else if (gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_())
                {
                    CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
                    IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(Observation O2Saturation)
                    {
                        object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_()
                        {
                            bool szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_()
                            {
                                DataType szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = O2Saturation?.Effective;
                                object szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                                bool szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ is CqlDateTime;

                                return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
                            };
                            bool szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_()
                            {
                                DataType szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = O2Saturation?.Effective;
                                object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                                bool tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ is CqlInterval<CqlDateTime>;

                                return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
                            };
                            bool szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_()
                            {
                                DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = O2Saturation?.Effective;
                                object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                                bool tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ is CqlDateTime;

                                return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
                            };
                            if (szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_())
                            {
                                DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = O2Saturation?.Effective;
                                object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

                                return (tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ as CqlDateTime) as object;
                            }
                            else if (szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_())
                            {
                                DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = O2Saturation?.Effective;
                                object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

                                return (tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_())
                            {
                                DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = O2Saturation?.Effective;
                                object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

                                return (tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.earliest(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_());
                        Period rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = EncounterInpatient?.Period;
                        CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                        CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                        CqlQuantity rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Quantity(1440m, "minutes");
                        CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Subtract(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                        CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                        CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                        CqlQuantity szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Quantity(120m, "minutes");
                        CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Add(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                        CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Interval(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, true, true);
                        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.In<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, default);
                        Code<ObservationStatus> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = O2Saturation?.StatusElement;
                        ObservationStatus? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_?.Value;
                        Code<ObservationStatus> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<Code<ObservationStatus>>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                        string szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<string>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                        string[] szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.In<string>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ as IEnumerable<string>);
                        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                        DataType szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = O2Saturation?.Value;
                        object szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Not((bool?)(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ is null));
                        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

                        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
                    };
                    IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Observation>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                    object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(Observation @this)
                    {
                        object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_()
                        {
                            bool tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_()
                            {
                                DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = @this?.Effective;
                                object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                                bool tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ is CqlDateTime;

                                return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
                            };
                            bool tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_()
                            {
                                DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = @this?.Effective;
                                object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                                bool tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ is CqlInterval<CqlDateTime>;

                                return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
                            };
                            bool tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_()
                            {
                                DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = @this?.Effective;
                                object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                                bool tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ is CqlDateTime;

                                return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
                            };
                            if (tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_())
                            {
                                DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = @this?.Effective;
                                object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

                                return (uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ as CqlDateTime) as object;
                            }
                            else if (tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_())
                            {
                                DataType uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = @this?.Effective;
                                object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

                                return (uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_())
                            {
                                DataType uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = @this?.Effective;
                                object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

                                return (uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.earliest(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_());

                        return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
                    };
                    IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.SortBy<Observation>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.First<Observation>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                    DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_?.Effective;
                    object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

                    return (rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_())
                {
                    CqlValueSet uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
                    IEnumerable<Observation> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(Observation O2Saturation)
                    {
                        object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_()
                        {
                            bool vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_()
                            {
                                DataType vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = O2Saturation?.Effective;
                                object vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                                bool vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ is CqlDateTime;

                                return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
                            };
                            bool vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_()
                            {
                                DataType vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = O2Saturation?.Effective;
                                object vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                                bool vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ is CqlInterval<CqlDateTime>;

                                return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
                            };
                            bool vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_()
                            {
                                DataType vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = O2Saturation?.Effective;
                                object vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                                bool vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ is CqlDateTime;

                                return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
                            };
                            if (vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_())
                            {
                                DataType vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = O2Saturation?.Effective;
                                object wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

                                return (wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ as CqlDateTime) as object;
                            }
                            else if (vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_())
                            {
                                DataType wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = O2Saturation?.Effective;
                                object wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

                                return (wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_())
                            {
                                DataType wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = O2Saturation?.Effective;
                                object wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

                                return (wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.earliest(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_());
                        Period uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = EncounterInpatient?.Period;
                        CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                        CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                        CqlQuantity uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Quantity(1440m, "minutes");
                        CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Subtract(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                        CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                        CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                        CqlQuantity uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Quantity(120m, "minutes");
                        CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Add(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                        CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Interval(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, true, true);
                        bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDateTime>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, default);
                        Code<ObservationStatus> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = O2Saturation?.StatusElement;
                        ObservationStatus? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_?.Value;
                        Code<ObservationStatus> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Convert<Code<ObservationStatus>>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                        string vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<string>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                        string[] vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.In<string>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ as IEnumerable<string>);
                        bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                        DataType vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = O2Saturation?.Value;
                        object vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                        bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Not((bool?)(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ is null));
                        bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

                        return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
                    };
                    IEnumerable<Observation> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Observation>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                    object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_(Observation @this)
                    {
                        object wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_()
                        {
                            bool wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_()
                            {
                                DataType wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = @this?.Effective;
                                object wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                                bool wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ is CqlDateTime;

                                return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
                            };
                            bool wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_()
                            {
                                DataType wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = @this?.Effective;
                                object wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                                bool wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ is CqlInterval<CqlDateTime>;

                                return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
                            };
                            bool wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_()
                            {
                                DataType wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = @this?.Effective;
                                object wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                                bool wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ is CqlDateTime;

                                return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
                            };
                            if (wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_())
                            {
                                DataType wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = @this?.Effective;
                                object wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

                                return (wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ as CqlDateTime) as object;
                            }
                            else if (wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_())
                            {
                                DataType wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = @this?.Effective;
                                object wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

                                return (wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_())
                            {
                                DataType wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = @this?.Effective;
                                object wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

                                return (wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.earliest(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_());

                        return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
                    };
                    IEnumerable<Observation> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.SortBy<Observation>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.First<Observation>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                    DataType uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_?.Effective;
                    object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

                    return (uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.earliest(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_());
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = (CqlTupleMetadata_FdREYEdHOZIcMCNYCRFJYJReA, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ as CqlQuantity, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

            return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)?> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)?>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)?> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)?>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

        return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Encounter with First Bicarbonate Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)?> Encounter_with_First_Bicarbonate_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_(Encounter EncounterInpatient)
        {
            Id xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = EncounterInpatient?.IdElement;
            string xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_?.Value;
            CqlValueSet xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Bicarbonate_lab_test(context);
            IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(Observation BicarbonateLab)
            {
                Instant xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = BicarbonateLab?.IssuedElement;
                DateTimeOffset? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_?.Value;
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Convert<CqlDateTime>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.earliest(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ as object);
                Period yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlQuantity yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Subtract(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Add(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Interval(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, true, true);
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.In<CqlDateTime>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, default);
                Code<ObservationStatus> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = BicarbonateLab?.StatusElement;
                ObservationStatus? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_?.Value;
                string yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Convert<string>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                string[] yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.In<string>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ as IEnumerable<string>);
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = BicarbonateLab?.Value;
                object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Not((bool?)(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ is null));
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

                return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
            };
            IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Observation>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            object xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_(Observation @this)
            {
                Instant yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = @this?.IssuedElement;
                DateTimeOffset? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_?.Value;
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Convert<CqlDateTime>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.earliest(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ as object);

                return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.SortBy<Observation>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, System.ComponentModel.ListSortDirection.Ascending);
            Observation xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.First<Observation>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            DataType xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_?.Value;
            object xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_(Observation BicarbonateLab)
            {
                Instant zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = BicarbonateLab?.IssuedElement;
                DateTimeOffset? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_?.Value;
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<CqlDateTime>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.earliest(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ as object);
                Period zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Start(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlQuantity zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Subtract(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Start(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Add(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Interval(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, true, true);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.In<CqlDateTime>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, default);
                Code<ObservationStatus> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = BicarbonateLab?.StatusElement;
                ObservationStatus? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_?.Value;
                string zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Convert<string>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                string[] zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.In<string>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ as IEnumerable<string>);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                DataType zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = BicarbonateLab?.Value;
                object azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Not((bool?)(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ is null));
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

                return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Observation>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            object xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(Observation @this)
            {
                Instant azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = @this?.IssuedElement;
                DateTimeOffset? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_?.Value;
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<CqlDateTime>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.earliest(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ as object);

                return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.SortBy<Observation>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, System.ComponentModel.ListSortDirection.Ascending);
            Observation xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.First<Observation>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            Instant xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_?.IssuedElement;
            DateTimeOffset? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_?.Value;
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<CqlDateTime>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = (CqlTupleMetadata_GbUHPXXHScejjXWhcHJFQQifQ, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ as CqlQuantity, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

            return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)?> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)?>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)?> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)?>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

        return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Encounter with First Creatinine Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)?> Encounter_with_First_Creatinine_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Encounter EncounterInpatient)
        {
            Id azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = EncounterInpatient?.IdElement;
            string azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_?.Value;
            CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Creatinine_lab_test(context);
            IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(Observation CreatinineLab)
            {
                Instant bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = CreatinineLab?.IssuedElement;
                DateTimeOffset? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_?.Value;
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Convert<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.earliest(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ as object);
                Period bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlQuantity bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Subtract(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Add(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Interval(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, true, true);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.In<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, default);
                Code<ObservationStatus> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = CreatinineLab?.StatusElement;
                ObservationStatus? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_?.Value;
                string bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Convert<string>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                string[] czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.In<string>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ as IEnumerable<string>);
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                DataType czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = CreatinineLab?.Value;
                object czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Not((bool?)(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ is null));
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

                return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Observation>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            object azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(Observation @this)
            {
                Instant czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = @this?.IssuedElement;
                DateTimeOffset? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_?.Value;
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Convert<CqlDateTime>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.earliest(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ as object);

                return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
            };
            IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.SortBy<Observation>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, System.ComponentModel.ListSortDirection.Ascending);
            Observation azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.First<Observation>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            DataType azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_?.Value;
            object azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_(Observation CreatinineLab)
            {
                Instant czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = CreatinineLab?.IssuedElement;
                DateTimeOffset? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_?.Value;
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Convert<CqlDateTime>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.earliest(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ as object);
                Period czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlQuantity czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Subtract(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Add(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Interval(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, true, true);
                bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, default);
                Code<ObservationStatus> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = CreatinineLab?.StatusElement;
                ObservationStatus? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_?.Value;
                string dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Convert<string>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                string[] dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.In<string>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ as IEnumerable<string>);
                bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = CreatinineLab?.Value;
                object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Not((bool?)(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ is null));
                bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

                return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
            };
            IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Observation>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            object bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_(Observation @this)
            {
                Instant dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = @this?.IssuedElement;
                DateTimeOffset? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_?.Value;
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Convert<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.earliest(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ as object);

                return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.SortBy<Observation>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, System.ComponentModel.ListSortDirection.Ascending);
            Observation bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.First<Observation>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            Instant bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_?.IssuedElement;
            DateTimeOffset? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_?.Value;
            CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = (CqlTupleMetadata_FETECNQPQREfGRgPYWhOWgeWA, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ as CqlQuantity, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

            return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)?> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)?>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)?> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)?>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Encounter with First Hematocrit Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?> Encounter_with_First_Hematocrit_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_(Encounter EncounterInpatient)
        {
            Id dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = EncounterInpatient?.IdElement;
            string dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_?.Value;
            CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Hematocrit_lab_test(context);
            IEnumerable<Observation> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_(Observation HematocritLab)
            {
                Instant ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = HematocritLab?.IssuedElement;
                DateTimeOffset? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_?.Value;
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Convert<CqlDateTime>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.earliest(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ as object);
                Period ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlQuantity ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Subtract(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Add(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Interval(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, true, true);
                bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.In<CqlDateTime>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, default);
                Code<ObservationStatus> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = HematocritLab?.StatusElement;
                ObservationStatus? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_?.Value;
                string fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Convert<string>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                string[] fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.In<string>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ as IEnumerable<string>);
                bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                DataType fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = HematocritLab?.Value;
                object fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Not((bool?)(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ is null));
                bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

                return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<Observation> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Observation>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_(Observation @this)
            {
                Instant fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = @this?.IssuedElement;
                DateTimeOffset? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_?.Value;
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Convert<CqlDateTime>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.earliest(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ as object);

                return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.SortBy<Observation>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, System.ComponentModel.ListSortDirection.Ascending);
            Observation ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.First<Observation>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            DataType ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_?.Value;
            object ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_(Observation HematocritLab)
            {
                Instant fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = HematocritLab?.IssuedElement;
                DateTimeOffset? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_?.Value;
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Convert<CqlDateTime>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.earliest(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ as object);
                Period fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Start(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlQuantity gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Subtract(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Add(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Interval(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, true, true);
                bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.In<CqlDateTime>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, default);
                Code<ObservationStatus> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = HematocritLab?.StatusElement;
                ObservationStatus? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_?.Value;
                string gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<string>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                string[] gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.In<string>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ as IEnumerable<string>);
                bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = HematocritLab?.Value;
                object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Not((bool?)(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ is null));
                bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

                return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Observation>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            object ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Observation @this)
            {
                Instant gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = @this?.IssuedElement;
                DateTimeOffset? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_?.Value;
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Convert<CqlDateTime>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.earliest(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ as object);

                return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.SortBy<Observation>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, System.ComponentModel.ListSortDirection.Ascending);
            Observation ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.First<Observation>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            Instant ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_?.IssuedElement;
            DateTimeOffset? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_?.Value;
            CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Convert<CqlDateTime>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = (CqlTupleMetadata_DIHdhbAJeJTdiAVUAELUHRNdS, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ as CqlQuantity, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

            return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

        return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Encounter with First Platelet Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)?> Encounter_with_First_Platelet_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_(Encounter EncounterInpatient)
        {
            Id hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = EncounterInpatient?.IdElement;
            string hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_?.Value;
            CqlValueSet hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Platelet_count_lab_test(context);
            IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_(Observation PlateletLab)
            {
                Instant hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = PlateletLab?.IssuedElement;
                DateTimeOffset? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_?.Value;
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Convert<CqlDateTime>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.earliest(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ as object);
                Period izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlQuantity izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Subtract(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Start(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Add(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Interval(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, true, true);
                bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.In<CqlDateTime>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, default);
                Code<ObservationStatus> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = PlateletLab?.StatusElement;
                ObservationStatus? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_?.Value;
                string izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Convert<string>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                string[] izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.In<string>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ as IEnumerable<string>);
                bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = PlateletLab?.Value;
                object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Not((bool?)(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ is null));
                bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

                return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Observation>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            object hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(Observation @this)
            {
                Instant izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = @this?.IssuedElement;
                DateTimeOffset? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_?.Value;
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Convert<CqlDateTime>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.earliest(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ as object);

                return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
            };
            IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.SortBy<Observation>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, System.ComponentModel.ListSortDirection.Ascending);
            Observation hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.First<Observation>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            DataType hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_?.Value;
            object hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Observation PlateletLab)
            {
                Instant jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = PlateletLab?.IssuedElement;
                DateTimeOffset? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_?.Value;
                CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Convert<CqlDateTime>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.earliest(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ as object);
                Period jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Start(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlQuantity jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Subtract(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Add(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Interval(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, true, true);
                bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, default);
                Code<ObservationStatus> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = PlateletLab?.StatusElement;
                ObservationStatus? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_?.Value;
                string jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Convert<string>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                string[] jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.In<string>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ as IEnumerable<string>);
                bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                DataType jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = PlateletLab?.Value;
                object jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Not((bool?)(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ is null));
                bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

                return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
            };
            IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Observation>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            object hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_(Observation @this)
            {
                Instant kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = @this?.IssuedElement;
                DateTimeOffset? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_?.Value;
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Convert<CqlDateTime>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.earliest(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ as object);

                return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.SortBy<Observation>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, System.ComponentModel.ListSortDirection.Ascending);
            Observation hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.First<Observation>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            Instant hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_?.IssuedElement;
            DateTimeOffset? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_?.Value;
            CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Convert<CqlDateTime>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = (CqlTupleMetadata_DAUcYHQZcDKbIfORJOEZBDgIh, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ as CqlQuantity, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

            return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)?> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)?>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)?> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)?>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

        return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Encounter with First Sodium Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)?> Encounter_with_First_Sodium_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_(Encounter EncounterInpatient)
        {
            Id kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = EncounterInpatient?.IdElement;
            string kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_?.Value;
            CqlValueSet kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Sodium_lab_test(context);
            IEnumerable<Observation> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(Observation SodiumLab)
            {
                Instant lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = SodiumLab?.IssuedElement;
                DateTimeOffset? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_?.Value;
                CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Convert<CqlDateTime>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.earliest(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ as object);
                Period lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlQuantity lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Subtract(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Add(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Interval(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, true, true);
                bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, default);
                Code<ObservationStatus> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = SodiumLab?.StatusElement;
                ObservationStatus? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_?.Value;
                string lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<string>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                string[] lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<string>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ as IEnumerable<string>);
                bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = SodiumLab?.Value;
                object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Not((bool?)(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ is null));
                bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

                return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<Observation> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Observation>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            object kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(Observation @this)
            {
                Instant mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = @this?.IssuedElement;
                DateTimeOffset? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_?.Value;
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Convert<CqlDateTime>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.earliest(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ as object);

                return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<Observation> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.SortBy<Observation>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, System.ComponentModel.ListSortDirection.Ascending);
            Observation kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.First<Observation>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            DataType kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_?.Value;
            object kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            IEnumerable<Observation> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_(Observation SodiumLab)
            {
                Instant mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = SodiumLab?.IssuedElement;
                DateTimeOffset? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_?.Value;
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<CqlDateTime>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.earliest(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ as object);
                Period mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlQuantity mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Subtract(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Add(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Interval(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, true, true);
                bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, default);
                Code<ObservationStatus> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = SodiumLab?.StatusElement;
                ObservationStatus? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_?.Value;
                string nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Convert<string>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                string[] nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<string>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ as IEnumerable<string>);
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                DataType nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = SodiumLab?.Value;
                object nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Not((bool?)(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ is null));
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

                return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<Observation> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Observation>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            object kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_(Observation @this)
            {
                Instant nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = @this?.IssuedElement;
                DateTimeOffset? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_?.Value;
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<CqlDateTime>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.earliest(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ as object);

                return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
            };
            IEnumerable<Observation> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.SortBy<Observation>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, System.ComponentModel.ListSortDirection.Ascending);
            Observation lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.First<Observation>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            Instant lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_?.IssuedElement;
            DateTimeOffset? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_?.Value;
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Convert<CqlDateTime>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = (CqlTupleMetadata_GKGeLARADLGJcNcZaDhdCREMa, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ as CqlQuantity, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

            return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)?> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)?>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)?> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)?>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

        return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Qualifying Blood Pressure Reading")]
    public IEnumerable<Observation> Qualifying_Blood_Pressure_Reading(CqlContext context)
    {
        IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bp"));
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Observation BPReading)
        {
            DataType nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = BPReading?.Effective;
            object nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.earliest(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Measurement_Period(context);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, "day");
            Code<ObservationStatus> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = BPReading?.StatusElement;
            ObservationStatus? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_?.Value;
            string nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<string>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            string[] nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<string>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ as IEnumerable<string>);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

            return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Observation>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

        return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Test2")]
    public CqlQuantity Test2(CqlContext context)
    {
        IEnumerable<Observation> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Qualifying_Blood_Pressure_Reading(context);
        IEnumerable<Observation> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_(Observation SBPReading)
        {
            IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Inpatient_Encounters(context);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Encounter EncounterInpatient)
            {
                DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = SBPReading?.Effective;
                object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.earliest(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                Period ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlQuantity ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Subtract(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlQuantity ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Add(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Interval(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, true, true);
                bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.In<CqlDateTime>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, default);

                return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Encounter>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            Observation ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_(Encounter EncounterInpatient) =>
                SBPReading;
            IEnumerable<Observation> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Select<Encounter, Observation>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

            return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Observation> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.SelectMany<Observation, Observation>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        CqlQuantity ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_(Observation SBPReading)
        {
            List<Observation.ComponentComponent> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = SBPReading?.Component;
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_(Observation.ComponentComponent SBPComponent)
            {
                CodeableConcept pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = SBPComponent?.Code;
                CqlConcept pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlCode pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Systolic_blood_pressure(context);
                CqlConcept pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.ConvertCodeToConcept(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Equivalent(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

                return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<Observation.ComponentComponent> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlQuantity pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_(Observation.ComponentComponent SBPComponent)
            {
                DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = SBPComponent?.Value;
                object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

                return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ as CqlQuantity;
            };
            IEnumerable<CqlQuantity> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Select<Observation.ComponentComponent, CqlQuantity>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            IEnumerable<CqlQuantity> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Distinct<CqlQuantity>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlQuantity pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.SingletonFrom<CqlQuantity>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

            return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<CqlQuantity> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Select<Observation, CqlQuantity>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        IEnumerable<CqlQuantity> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Distinct<CqlQuantity>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        IEnumerable<CqlQuantity> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.ListSort<CqlQuantity>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, System.ComponentModel.ListSortDirection.Ascending);
        CqlQuantity ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.First<CqlQuantity>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Encounter with First White Blood Cells Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)?> Encounter_with_First_White_Blood_Cells_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(Encounter EncounterInpatient)
        {
            Id pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = EncounterInpatient?.IdElement;
            string pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_?.Value;
            CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.White_blood_cells_count_lab_test(context);
            IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_(Observation WhiteBloodCellLab)
            {
                Instant qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = WhiteBloodCellLab?.IssuedElement;
                DateTimeOffset? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_?.Value;
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Convert<CqlDateTime>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.earliest(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ as object);
                Period qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlQuantity qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Subtract(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Add(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Interval(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, true, true);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.In<CqlDateTime>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, default);
                Code<ObservationStatus> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = WhiteBloodCellLab?.StatusElement;
                ObservationStatus? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_?.Value;
                string rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Convert<string>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                string[] rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.In<string>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ as IEnumerable<string>);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = WhiteBloodCellLab?.Value;
                object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Not((bool?)(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ is null));
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

                return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
            };
            IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Observation>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_(Observation @this)
            {
                Instant rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = @this?.IssuedElement;
                DateTimeOffset? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_?.Value;
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Convert<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.earliest(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ as object);

                return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
            };
            IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.SortBy<Observation>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, System.ComponentModel.ListSortDirection.Ascending);
            Observation qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.First<Observation>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_?.Value;
            object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Observation WhiteBloodCellLab)
            {
                Instant rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = WhiteBloodCellLab?.IssuedElement;
                DateTimeOffset? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_?.Value;
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.earliest(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ as object);
                Period rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlQuantity szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Subtract(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Add(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Interval(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, true, true);
                bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.In<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, default);
                Code<ObservationStatus> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = WhiteBloodCellLab?.StatusElement;
                ObservationStatus? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_?.Value;
                string szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Convert<string>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                string[] szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.In<string>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ as IEnumerable<string>);
                bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                DataType szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = WhiteBloodCellLab?.Value;
                object szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Not((bool?)(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ is null));
                bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

                return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
            };
            IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Observation>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Observation @this)
            {
                Instant szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = @this?.IssuedElement;
                DateTimeOffset? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_?.Value;
                CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<CqlDateTime>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.earliest(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ as object);

                return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
            };
            IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.SortBy<Observation>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, System.ComponentModel.ListSortDirection.Ascending);
            Observation qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.First<Observation>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            Instant qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_?.IssuedElement;
            DateTimeOffset? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_?.Value;
            CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Convert<CqlDateTime>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = (CqlTupleMetadata_ChVYCdXDGgVcFTCCUefXMbCHX, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ as CqlQuantity, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

            return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)?> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)?>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)?> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)?>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

        return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
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
