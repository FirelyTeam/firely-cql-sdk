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
        CqlDateTime tzzzzzzzzzzzzzzzzzzzr_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime tzzzzzzzzzzzzzzzzzzzs_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Interval(tzzzzzzzzzzzzzzzzzzzr_, tzzzzzzzzzzzzzzzzzzzs_, true, true);
        object tzzzzzzzzzzzzzzzzzzzu_ = context.ResolveParameter("HybridHospitalWideMortalityFHIR-0.0.001", "Measurement Period", tzzzzzzzzzzzzzzzzzzzt_);

        return (CqlInterval<CqlDateTime>)tzzzzzzzzzzzzzzzzzzzu_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> tzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient tzzzzzzzzzzzzzzzzzzzw_ = context.Operators.SingletonFrom<Patient>(tzzzzzzzzzzzzzzzzzzzv_);

        return tzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Inpatient Encounters")]
    public IEnumerable<Encounter> Inpatient_Encounters(CqlContext context)
    {
        CqlValueSet tzzzzzzzzzzzzzzzzzzzx_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzz_(Encounter InpatientEncounter)
        {
            CqlValueSet uzzzzzzzzzzzzzzzzzzzb_ = this.Medicare_FFS_payer(context);
            IEnumerable<Coverage> uzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Coverage>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-coverage"));
            CqlValueSet uzzzzzzzzzzzzzzzzzzzd_ = this.Medicare_Advantage_payer(context);
            IEnumerable<Coverage> uzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Coverage>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-coverage"));
            IEnumerable<Coverage> uzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Union<Coverage>(uzzzzzzzzzzzzzzzzzzzc_, uzzzzzzzzzzzzzzzzzzze_);
            bool? uzzzzzzzzzzzzzzzzzzzg_(Coverage MedicarePayer)
            {
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzk_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, InpatientEncounter);
                int? uzzzzzzzzzzzzzzzzzzzl_ = CQMCommon_2_2_000.Instance.lengthInDays(context, uzzzzzzzzzzzzzzzzzzzk_);
                bool? uzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Less(uzzzzzzzzzzzzzzzzzzzl_, 365);
                Code<Encounter.EncounterStatus> uzzzzzzzzzzzzzzzzzzzn_ = InpatientEncounter?.StatusElement;
                Encounter.EncounterStatus? uzzzzzzzzzzzzzzzzzzzo_ = uzzzzzzzzzzzzzzzzzzzn_?.Value;
                Code<Encounter.EncounterStatus> uzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(uzzzzzzzzzzzzzzzzzzzo_);
                bool? uzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Equal(uzzzzzzzzzzzzzzzzzzzp_, "finished");
                bool? uzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzm_, uzzzzzzzzzzzzzzzzzzzq_);
                Patient uzzzzzzzzzzzzzzzzzzzs_ = this.Patient(context);
                Date uzzzzzzzzzzzzzzzzzzzt_ = uzzzzzzzzzzzzzzzzzzzs_?.BirthDateElement;
                string uzzzzzzzzzzzzzzzzzzzu_ = uzzzzzzzzzzzzzzzzzzzt_?.Value;
                CqlDate uzzzzzzzzzzzzzzzzzzzv_ = context.Operators.ConvertStringToDate(uzzzzzzzzzzzzzzzzzzzu_);
                Period uzzzzzzzzzzzzzzzzzzzw_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzzzzzzzzzzw_);
                CqlDateTime uzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(uzzzzzzzzzzzzzzzzzzzx_);
                CqlDate uzzzzzzzzzzzzzzzzzzzz_ = context.Operators.DateFrom(uzzzzzzzzzzzzzzzzzzzy_);
                int? vzzzzzzzzzzzzzzzzzzza_ = context.Operators.CalculateAgeAt(uzzzzzzzzzzzzzzzzzzzv_, uzzzzzzzzzzzzzzzzzzzz_, "year");
                CqlInterval<int?> vzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Interval(65, 94, true, true);
                bool? vzzzzzzzzzzzzzzzzzzzc_ = context.Operators.In<int?>(vzzzzzzzzzzzzzzzzzzza_, vzzzzzzzzzzzzzzzzzzzb_, default);
                bool? vzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzr_, vzzzzzzzzzzzzzzzzzzzc_);
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzzzzzzzzzzw_);
                CqlDateTime vzzzzzzzzzzzzzzzzzzzg_ = context.Operators.End(vzzzzzzzzzzzzzzzzzzzf_);
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzh_ = this.Measurement_Period(context);
                bool? vzzzzzzzzzzzzzzzzzzzi_ = context.Operators.In<CqlDateTime>(vzzzzzzzzzzzzzzzzzzzg_, vzzzzzzzzzzzzzzzzzzzh_, "day");
                bool? vzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzd_, vzzzzzzzzzzzzzzzzzzzi_);

                return vzzzzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<Coverage> uzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Coverage>(uzzzzzzzzzzzzzzzzzzzf_, uzzzzzzzzzzzzzzzzzzzg_);
            Encounter uzzzzzzzzzzzzzzzzzzzi_(Coverage MedicarePayer) =>
                InpatientEncounter;
            IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<Coverage, Encounter>(uzzzzzzzzzzzzzzzzzzzh_, uzzzzzzzzzzzzzzzzzzzi_);

            return uzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzza_ = context.Operators.SelectMany<Encounter, Encounter>(tzzzzzzzzzzzzzzzzzzzy_, tzzzzzzzzzzzzzzzzzzzz_);

        return uzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzk_ = this.Inpatient_Encounters(context);

        return vzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Encounter with First Body Temperature")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)?> Encounter_with_First_Body_Temperature(CqlContext context)
    {
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzl_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)? vzzzzzzzzzzzzzzzzzzzm_(Encounter EncounterInpatient)
        {
            Id vzzzzzzzzzzzzzzzzzzzp_ = EncounterInpatient?.IdElement;
            string vzzzzzzzzzzzzzzzzzzzq_ = vzzzzzzzzzzzzzzzzzzzp_?.Value;
            IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bodytemp"));
            bool? vzzzzzzzzzzzzzzzzzzzs_(Observation temperature)
            {
                DataType wzzzzzzzzzzzzzzzzzzzj_ = temperature?.Effective;
                object wzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzj_);
                CqlDateTime wzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.earliest(context, wzzzzzzzzzzzzzzzzzzzk_);
                Period wzzzzzzzzzzzzzzzzzzzm_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzzzzzzzzzzzm_);
                CqlDateTime wzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Start(wzzzzzzzzzzzzzzzzzzzn_);
                CqlQuantity wzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime wzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Subtract(wzzzzzzzzzzzzzzzzzzzo_, wzzzzzzzzzzzzzzzzzzzp_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzzzzzzzzzzzm_);
                CqlDateTime wzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(wzzzzzzzzzzzzzzzzzzzs_);
                CqlQuantity wzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime wzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Add(wzzzzzzzzzzzzzzzzzzzt_, wzzzzzzzzzzzzzzzzzzzu_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Interval(wzzzzzzzzzzzzzzzzzzzq_, wzzzzzzzzzzzzzzzzzzzv_, true, true);
                bool? wzzzzzzzzzzzzzzzzzzzx_ = context.Operators.In<CqlDateTime>(wzzzzzzzzzzzzzzzzzzzl_, wzzzzzzzzzzzzzzzzzzzw_, default);
                Code<ObservationStatus> wzzzzzzzzzzzzzzzzzzzy_ = temperature?.StatusElement;
                ObservationStatus? wzzzzzzzzzzzzzzzzzzzz_ = wzzzzzzzzzzzzzzzzzzzy_?.Value;
                string xzzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<string>(wzzzzzzzzzzzzzzzzzzzz_);
                string[] xzzzzzzzzzzzzzzzzzzzb_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? xzzzzzzzzzzzzzzzzzzzc_ = context.Operators.In<string>(xzzzzzzzzzzzzzzzzzzza_, xzzzzzzzzzzzzzzzzzzzb_ as IEnumerable<string>);
                bool? xzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzx_, xzzzzzzzzzzzzzzzzzzzc_);
                DataType xzzzzzzzzzzzzzzzzzzze_ = temperature?.Value;
                CqlQuantity xzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, xzzzzzzzzzzzzzzzzzzze_ as Quantity);
                bool? xzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Not((bool?)(xzzzzzzzzzzzzzzzzzzzf_ is null));
                bool? xzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzd_, xzzzzzzzzzzzzzzzzzzzg_);

                return xzzzzzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Observation>(vzzzzzzzzzzzzzzzzzzzr_, vzzzzzzzzzzzzzzzzzzzs_);
            object vzzzzzzzzzzzzzzzzzzzu_(Observation @this)
            {
                DataType xzzzzzzzzzzzzzzzzzzzi_ = @this?.Effective;
                object xzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzi_);
                CqlDateTime xzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.earliest(context, xzzzzzzzzzzzzzzzzzzzj_);

                return xzzzzzzzzzzzzzzzzzzzk_;
            };
            IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzv_ = context.Operators.SortBy<Observation>(vzzzzzzzzzzzzzzzzzzzt_, vzzzzzzzzzzzzzzzzzzzu_, System.ComponentModel.ListSortDirection.Ascending);
            Observation vzzzzzzzzzzzzzzzzzzzw_ = context.Operators.First<Observation>(vzzzzzzzzzzzzzzzzzzzv_);
            DataType vzzzzzzzzzzzzzzzzzzzx_ = vzzzzzzzzzzzzzzzzzzzw_?.Value;
            CqlQuantity vzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, vzzzzzzzzzzzzzzzzzzzx_ as Quantity);
            bool? wzzzzzzzzzzzzzzzzzzza_(Observation temperature)
            {
                DataType xzzzzzzzzzzzzzzzzzzzl_ = temperature?.Effective;
                object xzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzl_);
                CqlDateTime xzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.earliest(context, xzzzzzzzzzzzzzzzzzzzm_);
                Period xzzzzzzzzzzzzzzzzzzzo_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzzzzo_);
                CqlDateTime xzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzp_);
                CqlQuantity xzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime xzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Subtract(xzzzzzzzzzzzzzzzzzzzq_, xzzzzzzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzzzzo_);
                CqlDateTime xzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzu_);
                CqlQuantity xzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime xzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Add(xzzzzzzzzzzzzzzzzzzzv_, xzzzzzzzzzzzzzzzzzzzw_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Interval(xzzzzzzzzzzzzzzzzzzzs_, xzzzzzzzzzzzzzzzzzzzx_, true, true);
                bool? xzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzzzzzzzzzzzn_, xzzzzzzzzzzzzzzzzzzzy_, default);
                Code<ObservationStatus> yzzzzzzzzzzzzzzzzzzza_ = temperature?.StatusElement;
                ObservationStatus? yzzzzzzzzzzzzzzzzzzzb_ = yzzzzzzzzzzzzzzzzzzza_?.Value;
                string yzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<string>(yzzzzzzzzzzzzzzzzzzzb_);
                string[] yzzzzzzzzzzzzzzzzzzzd_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? yzzzzzzzzzzzzzzzzzzze_ = context.Operators.In<string>(yzzzzzzzzzzzzzzzzzzzc_, yzzzzzzzzzzzzzzzzzzzd_ as IEnumerable<string>);
                bool? yzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzz_, yzzzzzzzzzzzzzzzzzzze_);
                DataType yzzzzzzzzzzzzzzzzzzzg_ = temperature?.Value;
                CqlQuantity yzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, yzzzzzzzzzzzzzzzzzzzg_ as Quantity);
                bool? yzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Not((bool?)(yzzzzzzzzzzzzzzzzzzzh_ is null));
                bool? yzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzf_, yzzzzzzzzzzzzzzzzzzzi_);

                return yzzzzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Observation>(vzzzzzzzzzzzzzzzzzzzr_, wzzzzzzzzzzzzzzzzzzza_);
            object wzzzzzzzzzzzzzzzzzzzc_(Observation @this)
            {
                DataType yzzzzzzzzzzzzzzzzzzzk_ = @this?.Effective;
                object yzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzk_);
                CqlDateTime yzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.earliest(context, yzzzzzzzzzzzzzzzzzzzl_);

                return yzzzzzzzzzzzzzzzzzzzm_;
            };
            IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzd_ = context.Operators.SortBy<Observation>(wzzzzzzzzzzzzzzzzzzzb_, wzzzzzzzzzzzzzzzzzzzc_, System.ComponentModel.ListSortDirection.Ascending);
            Observation wzzzzzzzzzzzzzzzzzzze_ = context.Operators.First<Observation>(wzzzzzzzzzzzzzzzzzzzd_);
            DataType wzzzzzzzzzzzzzzzzzzzf_ = wzzzzzzzzzzzzzzzzzzze_?.Effective;
            object wzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzf_);
            CqlDateTime wzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.earliest(context, wzzzzzzzzzzzzzzzzzzzg_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)? wzzzzzzzzzzzzzzzzzzzi_ = (CqlTupleMetadata_GIbILVAdXLLNYBgcQIEiUiKaK, vzzzzzzzzzzzzzzzzzzzq_, vzzzzzzzzzzzzzzzzzzzy_ as CqlQuantity, wzzzzzzzzzzzzzzzzzzzh_);

            return wzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)?> vzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)?>(vzzzzzzzzzzzzzzzzzzzl_, vzzzzzzzzzzzzzzzzzzzm_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)?> vzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)?>(vzzzzzzzzzzzzzzzzzzzn_);

        return vzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Encounter with First Heart Rate")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)?> Encounter_with_First_Heart_Rate(CqlContext context)
    {
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzn_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)? yzzzzzzzzzzzzzzzzzzzo_(Encounter EncounterInpatient)
        {
            Id yzzzzzzzzzzzzzzzzzzzr_ = EncounterInpatient?.IdElement;
            string yzzzzzzzzzzzzzzzzzzzs_ = yzzzzzzzzzzzzzzzzzzzr_?.Value;
            IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/heartrate"));
            bool? yzzzzzzzzzzzzzzzzzzzu_(Observation HeartRate)
            {
                DataType zzzzzzzzzzzzzzzzzzzzl_ = HeartRate?.Effective;
                object zzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzl_);
                CqlDateTime zzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.earliest(context, zzzzzzzzzzzzzzzzzzzzm_);
                Period zzzzzzzzzzzzzzzzzzzzo_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzzzzzzzzo_);
                CqlDateTime zzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(zzzzzzzzzzzzzzzzzzzzp_);
                CqlQuantity zzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime zzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Subtract(zzzzzzzzzzzzzzzzzzzzq_, zzzzzzzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzzzzzzzzo_);
                CqlDateTime zzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Start(zzzzzzzzzzzzzzzzzzzzu_);
                CqlQuantity zzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime zzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Add(zzzzzzzzzzzzzzzzzzzzv_, zzzzzzzzzzzzzzzzzzzzw_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Interval(zzzzzzzzzzzzzzzzzzzzs_, zzzzzzzzzzzzzzzzzzzzx_, true, true);
                bool? zzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<CqlDateTime>(zzzzzzzzzzzzzzzzzzzzn_, zzzzzzzzzzzzzzzzzzzzy_, default);
                Code<ObservationStatus> azzzzzzzzzzzzzzzzzzzza_ = HeartRate?.StatusElement;
                ObservationStatus? azzzzzzzzzzzzzzzzzzzzb_ = azzzzzzzzzzzzzzzzzzzza_?.Value;
                string azzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<string>(azzzzzzzzzzzzzzzzzzzzb_);
                string[] azzzzzzzzzzzzzzzzzzzzd_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? azzzzzzzzzzzzzzzzzzzze_ = context.Operators.In<string>(azzzzzzzzzzzzzzzzzzzzc_, azzzzzzzzzzzzzzzzzzzzd_ as IEnumerable<string>);
                bool? azzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzz_, azzzzzzzzzzzzzzzzzzzze_);
                DataType azzzzzzzzzzzzzzzzzzzzg_ = HeartRate?.Value;
                CqlQuantity azzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, azzzzzzzzzzzzzzzzzzzzg_ as Quantity);
                bool? azzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Not((bool?)(azzzzzzzzzzzzzzzzzzzzh_ is null));
                bool? azzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzzf_, azzzzzzzzzzzzzzzzzzzzi_);

                return azzzzzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Observation>(yzzzzzzzzzzzzzzzzzzzt_, yzzzzzzzzzzzzzzzzzzzu_);
            object yzzzzzzzzzzzzzzzzzzzw_(Observation @this)
            {
                DataType azzzzzzzzzzzzzzzzzzzzk_ = @this?.Effective;
                object azzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzk_);
                CqlDateTime azzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.earliest(context, azzzzzzzzzzzzzzzzzzzzl_);

                return azzzzzzzzzzzzzzzzzzzzm_;
            };
            IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzx_ = context.Operators.SortBy<Observation>(yzzzzzzzzzzzzzzzzzzzv_, yzzzzzzzzzzzzzzzzzzzw_, System.ComponentModel.ListSortDirection.Ascending);
            Observation yzzzzzzzzzzzzzzzzzzzy_ = context.Operators.First<Observation>(yzzzzzzzzzzzzzzzzzzzx_);
            DataType yzzzzzzzzzzzzzzzzzzzz_ = yzzzzzzzzzzzzzzzzzzzy_?.Value;
            CqlQuantity zzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, yzzzzzzzzzzzzzzzzzzzz_ as Quantity);
            bool? zzzzzzzzzzzzzzzzzzzzc_(Observation HeartRate)
            {
                DataType azzzzzzzzzzzzzzzzzzzzn_ = HeartRate?.Effective;
                object azzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzn_);
                CqlDateTime azzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.earliest(context, azzzzzzzzzzzzzzzzzzzzo_);
                Period azzzzzzzzzzzzzzzzzzzzq_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzzzzzzq_);
                CqlDateTime azzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(azzzzzzzzzzzzzzzzzzzzr_);
                CqlQuantity azzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime azzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Subtract(azzzzzzzzzzzzzzzzzzzzs_, azzzzzzzzzzzzzzzzzzzzt_);
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzzzzzzq_);
                CqlDateTime azzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(azzzzzzzzzzzzzzzzzzzzw_);
                CqlQuantity azzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime azzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Add(azzzzzzzzzzzzzzzzzzzzx_, azzzzzzzzzzzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Interval(azzzzzzzzzzzzzzzzzzzzu_, azzzzzzzzzzzzzzzzzzzzz_, true, true);
                bool? bzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDateTime>(azzzzzzzzzzzzzzzzzzzzp_, bzzzzzzzzzzzzzzzzzzzza_, default);
                Code<ObservationStatus> bzzzzzzzzzzzzzzzzzzzzc_ = HeartRate?.StatusElement;
                ObservationStatus? bzzzzzzzzzzzzzzzzzzzzd_ = bzzzzzzzzzzzzzzzzzzzzc_?.Value;
                string bzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Convert<string>(bzzzzzzzzzzzzzzzzzzzzd_);
                string[] bzzzzzzzzzzzzzzzzzzzzf_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? bzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.In<string>(bzzzzzzzzzzzzzzzzzzzze_, bzzzzzzzzzzzzzzzzzzzzf_ as IEnumerable<string>);
                bool? bzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzb_, bzzzzzzzzzzzzzzzzzzzzg_);
                DataType bzzzzzzzzzzzzzzzzzzzzi_ = HeartRate?.Value;
                CqlQuantity bzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, bzzzzzzzzzzzzzzzzzzzzi_ as Quantity);
                bool? bzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Not((bool?)(bzzzzzzzzzzzzzzzzzzzzj_ is null));
                bool? bzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzh_, bzzzzzzzzzzzzzzzzzzzzk_);

                return bzzzzzzzzzzzzzzzzzzzzl_;
            };
            IEnumerable<Observation> zzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Observation>(yzzzzzzzzzzzzzzzzzzzt_, zzzzzzzzzzzzzzzzzzzzc_);
            object zzzzzzzzzzzzzzzzzzzze_(Observation @this)
            {
                DataType bzzzzzzzzzzzzzzzzzzzzm_ = @this?.Effective;
                object bzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzm_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.earliest(context, bzzzzzzzzzzzzzzzzzzzzn_);

                return bzzzzzzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<Observation> zzzzzzzzzzzzzzzzzzzzf_ = context.Operators.SortBy<Observation>(zzzzzzzzzzzzzzzzzzzzd_, zzzzzzzzzzzzzzzzzzzze_, System.ComponentModel.ListSortDirection.Ascending);
            Observation zzzzzzzzzzzzzzzzzzzzg_ = context.Operators.First<Observation>(zzzzzzzzzzzzzzzzzzzzf_);
            DataType zzzzzzzzzzzzzzzzzzzzh_ = zzzzzzzzzzzzzzzzzzzzg_?.Effective;
            object zzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzh_);
            CqlDateTime zzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.earliest(context, zzzzzzzzzzzzzzzzzzzzi_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)? zzzzzzzzzzzzzzzzzzzzk_ = (CqlTupleMetadata_DhbJAfCiKIAGYKTjJXYGSKECQ, yzzzzzzzzzzzzzzzzzzzs_, zzzzzzzzzzzzzzzzzzzza_ as CqlQuantity, zzzzzzzzzzzzzzzzzzzzj_);

            return zzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)?> yzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)?>(yzzzzzzzzzzzzzzzzzzzn_, yzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)?> yzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)?>(yzzzzzzzzzzzzzzzzzzzp_);

        return yzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Encounter with First Oxygen Saturation")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)?> Encounter_with_First_Oxygen_Saturation(CqlContext context)
    {
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzp_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)? bzzzzzzzzzzzzzzzzzzzzq_(Encounter EncounterInpatient)
        {
            Id bzzzzzzzzzzzzzzzzzzzzt_ = EncounterInpatient?.IdElement;
            string bzzzzzzzzzzzzzzzzzzzzu_ = bzzzzzzzzzzzzzzzzzzzzt_?.Value;
            CqlValueSet bzzzzzzzzzzzzzzzzzzzzv_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
            IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            bool? bzzzzzzzzzzzzzzzzzzzzx_(Observation O2Saturation)
            {
                object czzzzzzzzzzzzzzzzzzzzh_()
                {
                    bool dzzzzzzzzzzzzzzzzzzzzg_()
                    {
                        DataType dzzzzzzzzzzzzzzzzzzzzj_ = O2Saturation?.Effective;
                        object dzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzj_);
                        bool dzzzzzzzzzzzzzzzzzzzzl_ = dzzzzzzzzzzzzzzzzzzzzk_ is CqlDateTime;

                        return dzzzzzzzzzzzzzzzzzzzzl_;
                    };
                    bool dzzzzzzzzzzzzzzzzzzzzh_()
                    {
                        DataType dzzzzzzzzzzzzzzzzzzzzm_ = O2Saturation?.Effective;
                        object dzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzm_);
                        bool dzzzzzzzzzzzzzzzzzzzzo_ = dzzzzzzzzzzzzzzzzzzzzn_ is CqlInterval<CqlDateTime>;

                        return dzzzzzzzzzzzzzzzzzzzzo_;
                    };
                    bool dzzzzzzzzzzzzzzzzzzzzi_()
                    {
                        DataType dzzzzzzzzzzzzzzzzzzzzp_ = O2Saturation?.Effective;
                        object dzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzp_);
                        bool dzzzzzzzzzzzzzzzzzzzzr_ = dzzzzzzzzzzzzzzzzzzzzq_ is CqlDateTime;

                        return dzzzzzzzzzzzzzzzzzzzzr_;
                    };
                    if (dzzzzzzzzzzzzzzzzzzzzg_())
                    {
                        DataType dzzzzzzzzzzzzzzzzzzzzs_ = O2Saturation?.Effective;
                        object dzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzs_);

                        return (dzzzzzzzzzzzzzzzzzzzzt_ as CqlDateTime) as object;
                    }
                    else if (dzzzzzzzzzzzzzzzzzzzzh_())
                    {
                        DataType dzzzzzzzzzzzzzzzzzzzzu_ = O2Saturation?.Effective;
                        object dzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzu_);

                        return (dzzzzzzzzzzzzzzzzzzzzv_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (dzzzzzzzzzzzzzzzzzzzzi_())
                    {
                        DataType dzzzzzzzzzzzzzzzzzzzzw_ = O2Saturation?.Effective;
                        object dzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzw_);

                        return (dzzzzzzzzzzzzzzzzzzzzx_ as CqlDateTime) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlDateTime czzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.earliest(context, czzzzzzzzzzzzzzzzzzzzh_());
                Period czzzzzzzzzzzzzzzzzzzzj_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzzzzzzzzzzzzzj_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzzzk_);
                CqlQuantity czzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime czzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Subtract(czzzzzzzzzzzzzzzzzzzzl_, czzzzzzzzzzzzzzzzzzzzm_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzzzzzzzzzzzzzj_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzzzp_);
                CqlQuantity czzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime czzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Add(czzzzzzzzzzzzzzzzzzzzq_, czzzzzzzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Interval(czzzzzzzzzzzzzzzzzzzzn_, czzzzzzzzzzzzzzzzzzzzs_, true, true);
                bool? czzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(czzzzzzzzzzzzzzzzzzzzi_, czzzzzzzzzzzzzzzzzzzzt_, default);
                Code<ObservationStatus> czzzzzzzzzzzzzzzzzzzzv_ = O2Saturation?.StatusElement;
                ObservationStatus? czzzzzzzzzzzzzzzzzzzzw_ = czzzzzzzzzzzzzzzzzzzzv_?.Value;
                Code<ObservationStatus> czzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<Code<ObservationStatus>>(czzzzzzzzzzzzzzzzzzzzw_);
                string czzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<string>(czzzzzzzzzzzzzzzzzzzzx_);
                string[] czzzzzzzzzzzzzzzzzzzzz_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? dzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<string>(czzzzzzzzzzzzzzzzzzzzy_, czzzzzzzzzzzzzzzzzzzzz_ as IEnumerable<string>);
                bool? dzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzu_, dzzzzzzzzzzzzzzzzzzzza_);
                DataType dzzzzzzzzzzzzzzzzzzzzc_ = O2Saturation?.Value;
                object dzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzc_);
                bool? dzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Not((bool?)(dzzzzzzzzzzzzzzzzzzzzd_ is null));
                bool? dzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzzzb_, dzzzzzzzzzzzzzzzzzzzze_);

                return dzzzzzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Observation>(bzzzzzzzzzzzzzzzzzzzzw_, bzzzzzzzzzzzzzzzzzzzzx_);
            object bzzzzzzzzzzzzzzzzzzzzz_(Observation @this)
            {
                object dzzzzzzzzzzzzzzzzzzzzy_()
                {
                    bool ezzzzzzzzzzzzzzzzzzzza_()
                    {
                        DataType ezzzzzzzzzzzzzzzzzzzzd_ = @this?.Effective;
                        object ezzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzd_);
                        bool ezzzzzzzzzzzzzzzzzzzzf_ = ezzzzzzzzzzzzzzzzzzzze_ is CqlDateTime;

                        return ezzzzzzzzzzzzzzzzzzzzf_;
                    };
                    bool ezzzzzzzzzzzzzzzzzzzzb_()
                    {
                        DataType ezzzzzzzzzzzzzzzzzzzzg_ = @this?.Effective;
                        object ezzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzg_);
                        bool ezzzzzzzzzzzzzzzzzzzzi_ = ezzzzzzzzzzzzzzzzzzzzh_ is CqlInterval<CqlDateTime>;

                        return ezzzzzzzzzzzzzzzzzzzzi_;
                    };
                    bool ezzzzzzzzzzzzzzzzzzzzc_()
                    {
                        DataType ezzzzzzzzzzzzzzzzzzzzj_ = @this?.Effective;
                        object ezzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzj_);
                        bool ezzzzzzzzzzzzzzzzzzzzl_ = ezzzzzzzzzzzzzzzzzzzzk_ is CqlDateTime;

                        return ezzzzzzzzzzzzzzzzzzzzl_;
                    };
                    if (ezzzzzzzzzzzzzzzzzzzza_())
                    {
                        DataType ezzzzzzzzzzzzzzzzzzzzm_ = @this?.Effective;
                        object ezzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzm_);

                        return (ezzzzzzzzzzzzzzzzzzzzn_ as CqlDateTime) as object;
                    }
                    else if (ezzzzzzzzzzzzzzzzzzzzb_())
                    {
                        DataType ezzzzzzzzzzzzzzzzzzzzo_ = @this?.Effective;
                        object ezzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzo_);

                        return (ezzzzzzzzzzzzzzzzzzzzp_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (ezzzzzzzzzzzzzzzzzzzzc_())
                    {
                        DataType ezzzzzzzzzzzzzzzzzzzzq_ = @this?.Effective;
                        object ezzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzq_);

                        return (ezzzzzzzzzzzzzzzzzzzzr_ as CqlDateTime) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.earliest(context, dzzzzzzzzzzzzzzzzzzzzy_());

                return dzzzzzzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzza_ = context.Operators.SortBy<Observation>(bzzzzzzzzzzzzzzzzzzzzy_, bzzzzzzzzzzzzzzzzzzzzz_, System.ComponentModel.ListSortDirection.Ascending);
            Observation czzzzzzzzzzzzzzzzzzzzb_ = context.Operators.First<Observation>(czzzzzzzzzzzzzzzzzzzza_);
            DataType czzzzzzzzzzzzzzzzzzzzc_ = czzzzzzzzzzzzzzzzzzzzb_?.Value;
            object czzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzc_);
            object czzzzzzzzzzzzzzzzzzzze_()
            {
                bool ezzzzzzzzzzzzzzzzzzzzs_()
                {
                    CqlValueSet ezzzzzzzzzzzzzzzzzzzzv_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
                    IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? ezzzzzzzzzzzzzzzzzzzzx_(Observation O2Saturation)
                    {
                        object fzzzzzzzzzzzzzzzzzzzzf_()
                        {
                            bool gzzzzzzzzzzzzzzzzzzzze_()
                            {
                                DataType gzzzzzzzzzzzzzzzzzzzzh_ = O2Saturation?.Effective;
                                object gzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzh_);
                                bool gzzzzzzzzzzzzzzzzzzzzj_ = gzzzzzzzzzzzzzzzzzzzzi_ is CqlDateTime;

                                return gzzzzzzzzzzzzzzzzzzzzj_;
                            };
                            bool gzzzzzzzzzzzzzzzzzzzzf_()
                            {
                                DataType gzzzzzzzzzzzzzzzzzzzzk_ = O2Saturation?.Effective;
                                object gzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzk_);
                                bool gzzzzzzzzzzzzzzzzzzzzm_ = gzzzzzzzzzzzzzzzzzzzzl_ is CqlInterval<CqlDateTime>;

                                return gzzzzzzzzzzzzzzzzzzzzm_;
                            };
                            bool gzzzzzzzzzzzzzzzzzzzzg_()
                            {
                                DataType gzzzzzzzzzzzzzzzzzzzzn_ = O2Saturation?.Effective;
                                object gzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzn_);
                                bool gzzzzzzzzzzzzzzzzzzzzp_ = gzzzzzzzzzzzzzzzzzzzzo_ is CqlDateTime;

                                return gzzzzzzzzzzzzzzzzzzzzp_;
                            };
                            if (gzzzzzzzzzzzzzzzzzzzze_())
                            {
                                DataType gzzzzzzzzzzzzzzzzzzzzq_ = O2Saturation?.Effective;
                                object gzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzq_);

                                return (gzzzzzzzzzzzzzzzzzzzzr_ as CqlDateTime) as object;
                            }
                            else if (gzzzzzzzzzzzzzzzzzzzzf_())
                            {
                                DataType gzzzzzzzzzzzzzzzzzzzzs_ = O2Saturation?.Effective;
                                object gzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzs_);

                                return (gzzzzzzzzzzzzzzzzzzzzt_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (gzzzzzzzzzzzzzzzzzzzzg_())
                            {
                                DataType gzzzzzzzzzzzzzzzzzzzzu_ = O2Saturation?.Effective;
                                object gzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzu_);

                                return (gzzzzzzzzzzzzzzzzzzzzv_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime fzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.earliest(context, fzzzzzzzzzzzzzzzzzzzzf_());
                        Period fzzzzzzzzzzzzzzzzzzzzh_ = EncounterInpatient?.Period;
                        CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzzzzzzzzzzzzh_);
                        CqlDateTime fzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Start(fzzzzzzzzzzzzzzzzzzzzi_);
                        CqlQuantity fzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Quantity(1440m, "minutes");
                        CqlDateTime fzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Subtract(fzzzzzzzzzzzzzzzzzzzzj_, fzzzzzzzzzzzzzzzzzzzzk_);
                        CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzzzzzzzzzzzzh_);
                        CqlDateTime fzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Start(fzzzzzzzzzzzzzzzzzzzzn_);
                        CqlQuantity fzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Quantity(120m, "minutes");
                        CqlDateTime fzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Add(fzzzzzzzzzzzzzzzzzzzzo_, fzzzzzzzzzzzzzzzzzzzzp_);
                        CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Interval(fzzzzzzzzzzzzzzzzzzzzl_, fzzzzzzzzzzzzzzzzzzzzq_, true, true);
                        bool? fzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.In<CqlDateTime>(fzzzzzzzzzzzzzzzzzzzzg_, fzzzzzzzzzzzzzzzzzzzzr_, default);
                        Code<ObservationStatus> fzzzzzzzzzzzzzzzzzzzzt_ = O2Saturation?.StatusElement;
                        ObservationStatus? fzzzzzzzzzzzzzzzzzzzzu_ = fzzzzzzzzzzzzzzzzzzzzt_?.Value;
                        Code<ObservationStatus> fzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Convert<Code<ObservationStatus>>(fzzzzzzzzzzzzzzzzzzzzu_);
                        string fzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<string>(fzzzzzzzzzzzzzzzzzzzzv_);
                        string[] fzzzzzzzzzzzzzzzzzzzzx_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? fzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<string>(fzzzzzzzzzzzzzzzzzzzzw_, fzzzzzzzzzzzzzzzzzzzzx_ as IEnumerable<string>);
                        bool? fzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzs_, fzzzzzzzzzzzzzzzzzzzzy_);
                        DataType gzzzzzzzzzzzzzzzzzzzza_ = O2Saturation?.Value;
                        object gzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzza_);
                        bool? gzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Not((bool?)(gzzzzzzzzzzzzzzzzzzzzb_ is null));
                        bool? gzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzz_, gzzzzzzzzzzzzzzzzzzzzc_);

                        return gzzzzzzzzzzzzzzzzzzzzd_;
                    };
                    IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Observation>(ezzzzzzzzzzzzzzzzzzzzw_, ezzzzzzzzzzzzzzzzzzzzx_);
                    object ezzzzzzzzzzzzzzzzzzzzz_(Observation @this)
                    {
                        object gzzzzzzzzzzzzzzzzzzzzw_()
                        {
                            bool gzzzzzzzzzzzzzzzzzzzzy_()
                            {
                                DataType hzzzzzzzzzzzzzzzzzzzzb_ = @this?.Effective;
                                object hzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzb_);
                                bool hzzzzzzzzzzzzzzzzzzzzd_ = hzzzzzzzzzzzzzzzzzzzzc_ is CqlDateTime;

                                return hzzzzzzzzzzzzzzzzzzzzd_;
                            };
                            bool gzzzzzzzzzzzzzzzzzzzzz_()
                            {
                                DataType hzzzzzzzzzzzzzzzzzzzze_ = @this?.Effective;
                                object hzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzze_);
                                bool hzzzzzzzzzzzzzzzzzzzzg_ = hzzzzzzzzzzzzzzzzzzzzf_ is CqlInterval<CqlDateTime>;

                                return hzzzzzzzzzzzzzzzzzzzzg_;
                            };
                            bool hzzzzzzzzzzzzzzzzzzzza_()
                            {
                                DataType hzzzzzzzzzzzzzzzzzzzzh_ = @this?.Effective;
                                object hzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzh_);
                                bool hzzzzzzzzzzzzzzzzzzzzj_ = hzzzzzzzzzzzzzzzzzzzzi_ is CqlDateTime;

                                return hzzzzzzzzzzzzzzzzzzzzj_;
                            };
                            if (gzzzzzzzzzzzzzzzzzzzzy_())
                            {
                                DataType hzzzzzzzzzzzzzzzzzzzzk_ = @this?.Effective;
                                object hzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzk_);

                                return (hzzzzzzzzzzzzzzzzzzzzl_ as CqlDateTime) as object;
                            }
                            else if (gzzzzzzzzzzzzzzzzzzzzz_())
                            {
                                DataType hzzzzzzzzzzzzzzzzzzzzm_ = @this?.Effective;
                                object hzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzm_);

                                return (hzzzzzzzzzzzzzzzzzzzzn_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (hzzzzzzzzzzzzzzzzzzzza_())
                            {
                                DataType hzzzzzzzzzzzzzzzzzzzzo_ = @this?.Effective;
                                object hzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzo_);

                                return (hzzzzzzzzzzzzzzzzzzzzp_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime gzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.earliest(context, gzzzzzzzzzzzzzzzzzzzzw_());

                        return gzzzzzzzzzzzzzzzzzzzzx_;
                    };
                    IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzza_ = context.Operators.SortBy<Observation>(ezzzzzzzzzzzzzzzzzzzzy_, ezzzzzzzzzzzzzzzzzzzzz_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation fzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.First<Observation>(fzzzzzzzzzzzzzzzzzzzza_);
                    DataType fzzzzzzzzzzzzzzzzzzzzc_ = fzzzzzzzzzzzzzzzzzzzzb_?.Effective;
                    object fzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzc_);
                    bool fzzzzzzzzzzzzzzzzzzzze_ = fzzzzzzzzzzzzzzzzzzzzd_ is CqlDateTime;

                    return fzzzzzzzzzzzzzzzzzzzze_;
                };
                bool ezzzzzzzzzzzzzzzzzzzzt_()
                {
                    CqlValueSet hzzzzzzzzzzzzzzzzzzzzq_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
                    IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? hzzzzzzzzzzzzzzzzzzzzs_(Observation O2Saturation)
                    {
                        object izzzzzzzzzzzzzzzzzzzza_()
                        {
                            bool izzzzzzzzzzzzzzzzzzzzz_()
                            {
                                DataType jzzzzzzzzzzzzzzzzzzzzc_ = O2Saturation?.Effective;
                                object jzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzc_);
                                bool jzzzzzzzzzzzzzzzzzzzze_ = jzzzzzzzzzzzzzzzzzzzzd_ is CqlDateTime;

                                return jzzzzzzzzzzzzzzzzzzzze_;
                            };
                            bool jzzzzzzzzzzzzzzzzzzzza_()
                            {
                                DataType jzzzzzzzzzzzzzzzzzzzzf_ = O2Saturation?.Effective;
                                object jzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzf_);
                                bool jzzzzzzzzzzzzzzzzzzzzh_ = jzzzzzzzzzzzzzzzzzzzzg_ is CqlInterval<CqlDateTime>;

                                return jzzzzzzzzzzzzzzzzzzzzh_;
                            };
                            bool jzzzzzzzzzzzzzzzzzzzzb_()
                            {
                                DataType jzzzzzzzzzzzzzzzzzzzzi_ = O2Saturation?.Effective;
                                object jzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzi_);
                                bool jzzzzzzzzzzzzzzzzzzzzk_ = jzzzzzzzzzzzzzzzzzzzzj_ is CqlDateTime;

                                return jzzzzzzzzzzzzzzzzzzzzk_;
                            };
                            if (izzzzzzzzzzzzzzzzzzzzz_())
                            {
                                DataType jzzzzzzzzzzzzzzzzzzzzl_ = O2Saturation?.Effective;
                                object jzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzl_);

                                return (jzzzzzzzzzzzzzzzzzzzzm_ as CqlDateTime) as object;
                            }
                            else if (jzzzzzzzzzzzzzzzzzzzza_())
                            {
                                DataType jzzzzzzzzzzzzzzzzzzzzn_ = O2Saturation?.Effective;
                                object jzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzn_);

                                return (jzzzzzzzzzzzzzzzzzzzzo_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (jzzzzzzzzzzzzzzzzzzzzb_())
                            {
                                DataType jzzzzzzzzzzzzzzzzzzzzp_ = O2Saturation?.Effective;
                                object jzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzp_);

                                return (jzzzzzzzzzzzzzzzzzzzzq_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime izzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.earliest(context, izzzzzzzzzzzzzzzzzzzza_());
                        Period izzzzzzzzzzzzzzzzzzzzc_ = EncounterInpatient?.Period;
                        CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzzzzzzzzzzzc_);
                        CqlDateTime izzzzzzzzzzzzzzzzzzzze_ = context.Operators.Start(izzzzzzzzzzzzzzzzzzzzd_);
                        CqlQuantity izzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Quantity(1440m, "minutes");
                        CqlDateTime izzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Subtract(izzzzzzzzzzzzzzzzzzzze_, izzzzzzzzzzzzzzzzzzzzf_);
                        CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzzzzzzzzzzzc_);
                        CqlDateTime izzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Start(izzzzzzzzzzzzzzzzzzzzi_);
                        CqlQuantity izzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Quantity(120m, "minutes");
                        CqlDateTime izzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Add(izzzzzzzzzzzzzzzzzzzzj_, izzzzzzzzzzzzzzzzzzzzk_);
                        CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Interval(izzzzzzzzzzzzzzzzzzzzg_, izzzzzzzzzzzzzzzzzzzzl_, true, true);
                        bool? izzzzzzzzzzzzzzzzzzzzn_ = context.Operators.In<CqlDateTime>(izzzzzzzzzzzzzzzzzzzzb_, izzzzzzzzzzzzzzzzzzzzm_, default);
                        Code<ObservationStatus> izzzzzzzzzzzzzzzzzzzzo_ = O2Saturation?.StatusElement;
                        ObservationStatus? izzzzzzzzzzzzzzzzzzzzp_ = izzzzzzzzzzzzzzzzzzzzo_?.Value;
                        Code<ObservationStatus> izzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<Code<ObservationStatus>>(izzzzzzzzzzzzzzzzzzzzp_);
                        string izzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Convert<string>(izzzzzzzzzzzzzzzzzzzzq_);
                        string[] izzzzzzzzzzzzzzzzzzzzs_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? izzzzzzzzzzzzzzzzzzzzt_ = context.Operators.In<string>(izzzzzzzzzzzzzzzzzzzzr_, izzzzzzzzzzzzzzzzzzzzs_ as IEnumerable<string>);
                        bool? izzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzn_, izzzzzzzzzzzzzzzzzzzzt_);
                        DataType izzzzzzzzzzzzzzzzzzzzv_ = O2Saturation?.Value;
                        object izzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzv_);
                        bool? izzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Not((bool?)(izzzzzzzzzzzzzzzzzzzzw_ is null));
                        bool? izzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzu_, izzzzzzzzzzzzzzzzzzzzx_);

                        return izzzzzzzzzzzzzzzzzzzzy_;
                    };
                    IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Observation>(hzzzzzzzzzzzzzzzzzzzzr_, hzzzzzzzzzzzzzzzzzzzzs_);
                    object hzzzzzzzzzzzzzzzzzzzzu_(Observation @this)
                    {
                        object jzzzzzzzzzzzzzzzzzzzzr_()
                        {
                            bool jzzzzzzzzzzzzzzzzzzzzt_()
                            {
                                DataType jzzzzzzzzzzzzzzzzzzzzw_ = @this?.Effective;
                                object jzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzw_);
                                bool jzzzzzzzzzzzzzzzzzzzzy_ = jzzzzzzzzzzzzzzzzzzzzx_ is CqlDateTime;

                                return jzzzzzzzzzzzzzzzzzzzzy_;
                            };
                            bool jzzzzzzzzzzzzzzzzzzzzu_()
                            {
                                DataType jzzzzzzzzzzzzzzzzzzzzz_ = @this?.Effective;
                                object kzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzz_);
                                bool kzzzzzzzzzzzzzzzzzzzzb_ = kzzzzzzzzzzzzzzzzzzzza_ is CqlInterval<CqlDateTime>;

                                return kzzzzzzzzzzzzzzzzzzzzb_;
                            };
                            bool jzzzzzzzzzzzzzzzzzzzzv_()
                            {
                                DataType kzzzzzzzzzzzzzzzzzzzzc_ = @this?.Effective;
                                object kzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzc_);
                                bool kzzzzzzzzzzzzzzzzzzzze_ = kzzzzzzzzzzzzzzzzzzzzd_ is CqlDateTime;

                                return kzzzzzzzzzzzzzzzzzzzze_;
                            };
                            if (jzzzzzzzzzzzzzzzzzzzzt_())
                            {
                                DataType kzzzzzzzzzzzzzzzzzzzzf_ = @this?.Effective;
                                object kzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzf_);

                                return (kzzzzzzzzzzzzzzzzzzzzg_ as CqlDateTime) as object;
                            }
                            else if (jzzzzzzzzzzzzzzzzzzzzu_())
                            {
                                DataType kzzzzzzzzzzzzzzzzzzzzh_ = @this?.Effective;
                                object kzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzh_);

                                return (kzzzzzzzzzzzzzzzzzzzzi_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (jzzzzzzzzzzzzzzzzzzzzv_())
                            {
                                DataType kzzzzzzzzzzzzzzzzzzzzj_ = @this?.Effective;
                                object kzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzj_);

                                return (kzzzzzzzzzzzzzzzzzzzzk_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime jzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.earliest(context, jzzzzzzzzzzzzzzzzzzzzr_());

                        return jzzzzzzzzzzzzzzzzzzzzs_;
                    };
                    IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.SortBy<Observation>(hzzzzzzzzzzzzzzzzzzzzt_, hzzzzzzzzzzzzzzzzzzzzu_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation hzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.First<Observation>(hzzzzzzzzzzzzzzzzzzzzv_);
                    DataType hzzzzzzzzzzzzzzzzzzzzx_ = hzzzzzzzzzzzzzzzzzzzzw_?.Effective;
                    object hzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzx_);
                    bool hzzzzzzzzzzzzzzzzzzzzz_ = hzzzzzzzzzzzzzzzzzzzzy_ is CqlInterval<CqlDateTime>;

                    return hzzzzzzzzzzzzzzzzzzzzz_;
                };
                bool ezzzzzzzzzzzzzzzzzzzzu_()
                {
                    CqlValueSet kzzzzzzzzzzzzzzzzzzzzl_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
                    IEnumerable<Observation> kzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? kzzzzzzzzzzzzzzzzzzzzn_(Observation O2Saturation)
                    {
                        object kzzzzzzzzzzzzzzzzzzzzv_()
                        {
                            bool lzzzzzzzzzzzzzzzzzzzzu_()
                            {
                                DataType lzzzzzzzzzzzzzzzzzzzzx_ = O2Saturation?.Effective;
                                object lzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzx_);
                                bool lzzzzzzzzzzzzzzzzzzzzz_ = lzzzzzzzzzzzzzzzzzzzzy_ is CqlDateTime;

                                return lzzzzzzzzzzzzzzzzzzzzz_;
                            };
                            bool lzzzzzzzzzzzzzzzzzzzzv_()
                            {
                                DataType mzzzzzzzzzzzzzzzzzzzza_ = O2Saturation?.Effective;
                                object mzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzza_);
                                bool mzzzzzzzzzzzzzzzzzzzzc_ = mzzzzzzzzzzzzzzzzzzzzb_ is CqlInterval<CqlDateTime>;

                                return mzzzzzzzzzzzzzzzzzzzzc_;
                            };
                            bool lzzzzzzzzzzzzzzzzzzzzw_()
                            {
                                DataType mzzzzzzzzzzzzzzzzzzzzd_ = O2Saturation?.Effective;
                                object mzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzd_);
                                bool mzzzzzzzzzzzzzzzzzzzzf_ = mzzzzzzzzzzzzzzzzzzzze_ is CqlDateTime;

                                return mzzzzzzzzzzzzzzzzzzzzf_;
                            };
                            if (lzzzzzzzzzzzzzzzzzzzzu_())
                            {
                                DataType mzzzzzzzzzzzzzzzzzzzzg_ = O2Saturation?.Effective;
                                object mzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzg_);

                                return (mzzzzzzzzzzzzzzzzzzzzh_ as CqlDateTime) as object;
                            }
                            else if (lzzzzzzzzzzzzzzzzzzzzv_())
                            {
                                DataType mzzzzzzzzzzzzzzzzzzzzi_ = O2Saturation?.Effective;
                                object mzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzi_);

                                return (mzzzzzzzzzzzzzzzzzzzzj_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (lzzzzzzzzzzzzzzzzzzzzw_())
                            {
                                DataType mzzzzzzzzzzzzzzzzzzzzk_ = O2Saturation?.Effective;
                                object mzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzk_);

                                return (mzzzzzzzzzzzzzzzzzzzzl_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime kzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.earliest(context, kzzzzzzzzzzzzzzzzzzzzv_());
                        Period kzzzzzzzzzzzzzzzzzzzzx_ = EncounterInpatient?.Period;
                        CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzzzzzzzzzzzzzx_);
                        CqlDateTime kzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzzy_);
                        CqlQuantity lzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Quantity(1440m, "minutes");
                        CqlDateTime lzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Subtract(kzzzzzzzzzzzzzzzzzzzzz_, lzzzzzzzzzzzzzzzzzzzza_);
                        CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzzzzzzzzzzzzzx_);
                        CqlDateTime lzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzzzzd_);
                        CqlQuantity lzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Quantity(120m, "minutes");
                        CqlDateTime lzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Add(lzzzzzzzzzzzzzzzzzzzze_, lzzzzzzzzzzzzzzzzzzzzf_);
                        CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Interval(lzzzzzzzzzzzzzzzzzzzzb_, lzzzzzzzzzzzzzzzzzzzzg_, true, true);
                        bool? lzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.In<CqlDateTime>(kzzzzzzzzzzzzzzzzzzzzw_, lzzzzzzzzzzzzzzzzzzzzh_, default);
                        Code<ObservationStatus> lzzzzzzzzzzzzzzzzzzzzj_ = O2Saturation?.StatusElement;
                        ObservationStatus? lzzzzzzzzzzzzzzzzzzzzk_ = lzzzzzzzzzzzzzzzzzzzzj_?.Value;
                        Code<ObservationStatus> lzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<Code<ObservationStatus>>(lzzzzzzzzzzzzzzzzzzzzk_);
                        string lzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Convert<string>(lzzzzzzzzzzzzzzzzzzzzl_);
                        string[] lzzzzzzzzzzzzzzzzzzzzn_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? lzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.In<string>(lzzzzzzzzzzzzzzzzzzzzm_, lzzzzzzzzzzzzzzzzzzzzn_ as IEnumerable<string>);
                        bool? lzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzi_, lzzzzzzzzzzzzzzzzzzzzo_);
                        DataType lzzzzzzzzzzzzzzzzzzzzq_ = O2Saturation?.Value;
                        object lzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzq_);
                        bool? lzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Not((bool?)(lzzzzzzzzzzzzzzzzzzzzr_ is null));
                        bool? lzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzp_, lzzzzzzzzzzzzzzzzzzzzs_);

                        return lzzzzzzzzzzzzzzzzzzzzt_;
                    };
                    IEnumerable<Observation> kzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Observation>(kzzzzzzzzzzzzzzzzzzzzm_, kzzzzzzzzzzzzzzzzzzzzn_);
                    object kzzzzzzzzzzzzzzzzzzzzp_(Observation @this)
                    {
                        object mzzzzzzzzzzzzzzzzzzzzm_()
                        {
                            bool mzzzzzzzzzzzzzzzzzzzzo_()
                            {
                                DataType mzzzzzzzzzzzzzzzzzzzzr_ = @this?.Effective;
                                object mzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzr_);
                                bool mzzzzzzzzzzzzzzzzzzzzt_ = mzzzzzzzzzzzzzzzzzzzzs_ is CqlDateTime;

                                return mzzzzzzzzzzzzzzzzzzzzt_;
                            };
                            bool mzzzzzzzzzzzzzzzzzzzzp_()
                            {
                                DataType mzzzzzzzzzzzzzzzzzzzzu_ = @this?.Effective;
                                object mzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzu_);
                                bool mzzzzzzzzzzzzzzzzzzzzw_ = mzzzzzzzzzzzzzzzzzzzzv_ is CqlInterval<CqlDateTime>;

                                return mzzzzzzzzzzzzzzzzzzzzw_;
                            };
                            bool mzzzzzzzzzzzzzzzzzzzzq_()
                            {
                                DataType mzzzzzzzzzzzzzzzzzzzzx_ = @this?.Effective;
                                object mzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzx_);
                                bool mzzzzzzzzzzzzzzzzzzzzz_ = mzzzzzzzzzzzzzzzzzzzzy_ is CqlDateTime;

                                return mzzzzzzzzzzzzzzzzzzzzz_;
                            };
                            if (mzzzzzzzzzzzzzzzzzzzzo_())
                            {
                                DataType nzzzzzzzzzzzzzzzzzzzza_ = @this?.Effective;
                                object nzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzza_);

                                return (nzzzzzzzzzzzzzzzzzzzzb_ as CqlDateTime) as object;
                            }
                            else if (mzzzzzzzzzzzzzzzzzzzzp_())
                            {
                                DataType nzzzzzzzzzzzzzzzzzzzzc_ = @this?.Effective;
                                object nzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzc_);

                                return (nzzzzzzzzzzzzzzzzzzzzd_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (mzzzzzzzzzzzzzzzzzzzzq_())
                            {
                                DataType nzzzzzzzzzzzzzzzzzzzze_ = @this?.Effective;
                                object nzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzze_);

                                return (nzzzzzzzzzzzzzzzzzzzzf_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime mzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.earliest(context, mzzzzzzzzzzzzzzzzzzzzm_());

                        return mzzzzzzzzzzzzzzzzzzzzn_;
                    };
                    IEnumerable<Observation> kzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.SortBy<Observation>(kzzzzzzzzzzzzzzzzzzzzo_, kzzzzzzzzzzzzzzzzzzzzp_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation kzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.First<Observation>(kzzzzzzzzzzzzzzzzzzzzq_);
                    DataType kzzzzzzzzzzzzzzzzzzzzs_ = kzzzzzzzzzzzzzzzzzzzzr_?.Effective;
                    object kzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzs_);
                    bool kzzzzzzzzzzzzzzzzzzzzu_ = kzzzzzzzzzzzzzzzzzzzzt_ is CqlDateTime;

                    return kzzzzzzzzzzzzzzzzzzzzu_;
                };
                if (ezzzzzzzzzzzzzzzzzzzzs_())
                {
                    CqlValueSet nzzzzzzzzzzzzzzzzzzzzg_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
                    IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? nzzzzzzzzzzzzzzzzzzzzi_(Observation O2Saturation)
                    {
                        object nzzzzzzzzzzzzzzzzzzzzp_()
                        {
                            bool ozzzzzzzzzzzzzzzzzzzzo_()
                            {
                                DataType ozzzzzzzzzzzzzzzzzzzzr_ = O2Saturation?.Effective;
                                object ozzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzr_);
                                bool ozzzzzzzzzzzzzzzzzzzzt_ = ozzzzzzzzzzzzzzzzzzzzs_ is CqlDateTime;

                                return ozzzzzzzzzzzzzzzzzzzzt_;
                            };
                            bool ozzzzzzzzzzzzzzzzzzzzp_()
                            {
                                DataType ozzzzzzzzzzzzzzzzzzzzu_ = O2Saturation?.Effective;
                                object ozzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzu_);
                                bool ozzzzzzzzzzzzzzzzzzzzw_ = ozzzzzzzzzzzzzzzzzzzzv_ is CqlInterval<CqlDateTime>;

                                return ozzzzzzzzzzzzzzzzzzzzw_;
                            };
                            bool ozzzzzzzzzzzzzzzzzzzzq_()
                            {
                                DataType ozzzzzzzzzzzzzzzzzzzzx_ = O2Saturation?.Effective;
                                object ozzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzx_);
                                bool ozzzzzzzzzzzzzzzzzzzzz_ = ozzzzzzzzzzzzzzzzzzzzy_ is CqlDateTime;

                                return ozzzzzzzzzzzzzzzzzzzzz_;
                            };
                            if (ozzzzzzzzzzzzzzzzzzzzo_())
                            {
                                DataType pzzzzzzzzzzzzzzzzzzzza_ = O2Saturation?.Effective;
                                object pzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzza_);

                                return (pzzzzzzzzzzzzzzzzzzzzb_ as CqlDateTime) as object;
                            }
                            else if (ozzzzzzzzzzzzzzzzzzzzp_())
                            {
                                DataType pzzzzzzzzzzzzzzzzzzzzc_ = O2Saturation?.Effective;
                                object pzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzc_);

                                return (pzzzzzzzzzzzzzzzzzzzzd_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (ozzzzzzzzzzzzzzzzzzzzq_())
                            {
                                DataType pzzzzzzzzzzzzzzzzzzzze_ = O2Saturation?.Effective;
                                object pzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzze_);

                                return (pzzzzzzzzzzzzzzzzzzzzf_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime nzzzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.earliest(context, nzzzzzzzzzzzzzzzzzzzzp_());
                        Period nzzzzzzzzzzzzzzzzzzzzr_ = EncounterInpatient?.Period;
                        CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzzzzzzzzzzzr_);
                        CqlDateTime nzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzzzs_);
                        CqlQuantity nzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Quantity(1440m, "minutes");
                        CqlDateTime nzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Subtract(nzzzzzzzzzzzzzzzzzzzzt_, nzzzzzzzzzzzzzzzzzzzzu_);
                        CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzzzzzzzzzzzr_);
                        CqlDateTime nzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzzzx_);
                        CqlQuantity nzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Quantity(120m, "minutes");
                        CqlDateTime ozzzzzzzzzzzzzzzzzzzza_ = context.Operators.Add(nzzzzzzzzzzzzzzzzzzzzy_, nzzzzzzzzzzzzzzzzzzzzz_);
                        CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Interval(nzzzzzzzzzzzzzzzzzzzzv_, ozzzzzzzzzzzzzzzzzzzza_, true, true);
                        bool? ozzzzzzzzzzzzzzzzzzzzc_ = context.Operators.In<CqlDateTime>(nzzzzzzzzzzzzzzzzzzzzq_, ozzzzzzzzzzzzzzzzzzzzb_, default);
                        Code<ObservationStatus> ozzzzzzzzzzzzzzzzzzzzd_ = O2Saturation?.StatusElement;
                        ObservationStatus? ozzzzzzzzzzzzzzzzzzzze_ = ozzzzzzzzzzzzzzzzzzzzd_?.Value;
                        Code<ObservationStatus> ozzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<Code<ObservationStatus>>(ozzzzzzzzzzzzzzzzzzzze_);
                        string ozzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<string>(ozzzzzzzzzzzzzzzzzzzzf_);
                        string[] ozzzzzzzzzzzzzzzzzzzzh_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? ozzzzzzzzzzzzzzzzzzzzi_ = context.Operators.In<string>(ozzzzzzzzzzzzzzzzzzzzg_, ozzzzzzzzzzzzzzzzzzzzh_ as IEnumerable<string>);
                        bool? ozzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzc_, ozzzzzzzzzzzzzzzzzzzzi_);
                        DataType ozzzzzzzzzzzzzzzzzzzzk_ = O2Saturation?.Value;
                        object ozzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzk_);
                        bool? ozzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Not((bool?)(ozzzzzzzzzzzzzzzzzzzzl_ is null));
                        bool? ozzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzj_, ozzzzzzzzzzzzzzzzzzzzm_);

                        return ozzzzzzzzzzzzzzzzzzzzn_;
                    };
                    IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Observation>(nzzzzzzzzzzzzzzzzzzzzh_, nzzzzzzzzzzzzzzzzzzzzi_);
                    object nzzzzzzzzzzzzzzzzzzzzk_(Observation @this)
                    {
                        object pzzzzzzzzzzzzzzzzzzzzg_()
                        {
                            bool pzzzzzzzzzzzzzzzzzzzzi_()
                            {
                                DataType pzzzzzzzzzzzzzzzzzzzzl_ = @this?.Effective;
                                object pzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzl_);
                                bool pzzzzzzzzzzzzzzzzzzzzn_ = pzzzzzzzzzzzzzzzzzzzzm_ is CqlDateTime;

                                return pzzzzzzzzzzzzzzzzzzzzn_;
                            };
                            bool pzzzzzzzzzzzzzzzzzzzzj_()
                            {
                                DataType pzzzzzzzzzzzzzzzzzzzzo_ = @this?.Effective;
                                object pzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzo_);
                                bool pzzzzzzzzzzzzzzzzzzzzq_ = pzzzzzzzzzzzzzzzzzzzzp_ is CqlInterval<CqlDateTime>;

                                return pzzzzzzzzzzzzzzzzzzzzq_;
                            };
                            bool pzzzzzzzzzzzzzzzzzzzzk_()
                            {
                                DataType pzzzzzzzzzzzzzzzzzzzzr_ = @this?.Effective;
                                object pzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzr_);
                                bool pzzzzzzzzzzzzzzzzzzzzt_ = pzzzzzzzzzzzzzzzzzzzzs_ is CqlDateTime;

                                return pzzzzzzzzzzzzzzzzzzzzt_;
                            };
                            if (pzzzzzzzzzzzzzzzzzzzzi_())
                            {
                                DataType pzzzzzzzzzzzzzzzzzzzzu_ = @this?.Effective;
                                object pzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzu_);

                                return (pzzzzzzzzzzzzzzzzzzzzv_ as CqlDateTime) as object;
                            }
                            else if (pzzzzzzzzzzzzzzzzzzzzj_())
                            {
                                DataType pzzzzzzzzzzzzzzzzzzzzw_ = @this?.Effective;
                                object pzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzw_);

                                return (pzzzzzzzzzzzzzzzzzzzzx_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (pzzzzzzzzzzzzzzzzzzzzk_())
                            {
                                DataType pzzzzzzzzzzzzzzzzzzzzy_ = @this?.Effective;
                                object pzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzy_);

                                return (pzzzzzzzzzzzzzzzzzzzzz_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime pzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.earliest(context, pzzzzzzzzzzzzzzzzzzzzg_());

                        return pzzzzzzzzzzzzzzzzzzzzh_;
                    };
                    IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.SortBy<Observation>(nzzzzzzzzzzzzzzzzzzzzj_, nzzzzzzzzzzzzzzzzzzzzk_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation nzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.First<Observation>(nzzzzzzzzzzzzzzzzzzzzl_);
                    DataType nzzzzzzzzzzzzzzzzzzzzn_ = nzzzzzzzzzzzzzzzzzzzzm_?.Effective;
                    object nzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzn_);

                    return (nzzzzzzzzzzzzzzzzzzzzo_ as CqlDateTime) as object;
                }
                else if (ezzzzzzzzzzzzzzzzzzzzt_())
                {
                    CqlValueSet qzzzzzzzzzzzzzzzzzzzza_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
                    IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? qzzzzzzzzzzzzzzzzzzzzc_(Observation O2Saturation)
                    {
                        object qzzzzzzzzzzzzzzzzzzzzj_()
                        {
                            bool rzzzzzzzzzzzzzzzzzzzzi_()
                            {
                                DataType rzzzzzzzzzzzzzzzzzzzzl_ = O2Saturation?.Effective;
                                object rzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzl_);
                                bool rzzzzzzzzzzzzzzzzzzzzn_ = rzzzzzzzzzzzzzzzzzzzzm_ is CqlDateTime;

                                return rzzzzzzzzzzzzzzzzzzzzn_;
                            };
                            bool rzzzzzzzzzzzzzzzzzzzzj_()
                            {
                                DataType rzzzzzzzzzzzzzzzzzzzzo_ = O2Saturation?.Effective;
                                object rzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzo_);
                                bool rzzzzzzzzzzzzzzzzzzzzq_ = rzzzzzzzzzzzzzzzzzzzzp_ is CqlInterval<CqlDateTime>;

                                return rzzzzzzzzzzzzzzzzzzzzq_;
                            };
                            bool rzzzzzzzzzzzzzzzzzzzzk_()
                            {
                                DataType rzzzzzzzzzzzzzzzzzzzzr_ = O2Saturation?.Effective;
                                object rzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzr_);
                                bool rzzzzzzzzzzzzzzzzzzzzt_ = rzzzzzzzzzzzzzzzzzzzzs_ is CqlDateTime;

                                return rzzzzzzzzzzzzzzzzzzzzt_;
                            };
                            if (rzzzzzzzzzzzzzzzzzzzzi_())
                            {
                                DataType rzzzzzzzzzzzzzzzzzzzzu_ = O2Saturation?.Effective;
                                object rzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzu_);

                                return (rzzzzzzzzzzzzzzzzzzzzv_ as CqlDateTime) as object;
                            }
                            else if (rzzzzzzzzzzzzzzzzzzzzj_())
                            {
                                DataType rzzzzzzzzzzzzzzzzzzzzw_ = O2Saturation?.Effective;
                                object rzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzw_);

                                return (rzzzzzzzzzzzzzzzzzzzzx_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (rzzzzzzzzzzzzzzzzzzzzk_())
                            {
                                DataType rzzzzzzzzzzzzzzzzzzzzy_ = O2Saturation?.Effective;
                                object rzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzy_);

                                return (rzzzzzzzzzzzzzzzzzzzzz_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime qzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.earliest(context, qzzzzzzzzzzzzzzzzzzzzj_());
                        Period qzzzzzzzzzzzzzzzzzzzzl_ = EncounterInpatient?.Period;
                        CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzzzzzzzzzl_);
                        CqlDateTime qzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(qzzzzzzzzzzzzzzzzzzzzm_);
                        CqlQuantity qzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Quantity(1440m, "minutes");
                        CqlDateTime qzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Subtract(qzzzzzzzzzzzzzzzzzzzzn_, qzzzzzzzzzzzzzzzzzzzzo_);
                        CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzzzzzzzzzl_);
                        CqlDateTime qzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(qzzzzzzzzzzzzzzzzzzzzr_);
                        CqlQuantity qzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Quantity(120m, "minutes");
                        CqlDateTime qzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Add(qzzzzzzzzzzzzzzzzzzzzs_, qzzzzzzzzzzzzzzzzzzzzt_);
                        CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Interval(qzzzzzzzzzzzzzzzzzzzzp_, qzzzzzzzzzzzzzzzzzzzzu_, true, true);
                        bool? qzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.In<CqlDateTime>(qzzzzzzzzzzzzzzzzzzzzk_, qzzzzzzzzzzzzzzzzzzzzv_, default);
                        Code<ObservationStatus> qzzzzzzzzzzzzzzzzzzzzx_ = O2Saturation?.StatusElement;
                        ObservationStatus? qzzzzzzzzzzzzzzzzzzzzy_ = qzzzzzzzzzzzzzzzzzzzzx_?.Value;
                        Code<ObservationStatus> qzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Convert<Code<ObservationStatus>>(qzzzzzzzzzzzzzzzzzzzzy_);
                        string rzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<string>(qzzzzzzzzzzzzzzzzzzzzz_);
                        string[] rzzzzzzzzzzzzzzzzzzzzb_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? rzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.In<string>(rzzzzzzzzzzzzzzzzzzzza_, rzzzzzzzzzzzzzzzzzzzzb_ as IEnumerable<string>);
                        bool? rzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzw_, rzzzzzzzzzzzzzzzzzzzzc_);
                        DataType rzzzzzzzzzzzzzzzzzzzze_ = O2Saturation?.Value;
                        object rzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzze_);
                        bool? rzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Not((bool?)(rzzzzzzzzzzzzzzzzzzzzf_ is null));
                        bool? rzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzd_, rzzzzzzzzzzzzzzzzzzzzg_);

                        return rzzzzzzzzzzzzzzzzzzzzh_;
                    };
                    IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Observation>(qzzzzzzzzzzzzzzzzzzzzb_, qzzzzzzzzzzzzzzzzzzzzc_);
                    object qzzzzzzzzzzzzzzzzzzzze_(Observation @this)
                    {
                        object szzzzzzzzzzzzzzzzzzzza_()
                        {
                            bool szzzzzzzzzzzzzzzzzzzzc_()
                            {
                                DataType szzzzzzzzzzzzzzzzzzzzf_ = @this?.Effective;
                                object szzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzf_);
                                bool szzzzzzzzzzzzzzzzzzzzh_ = szzzzzzzzzzzzzzzzzzzzg_ is CqlDateTime;

                                return szzzzzzzzzzzzzzzzzzzzh_;
                            };
                            bool szzzzzzzzzzzzzzzzzzzzd_()
                            {
                                DataType szzzzzzzzzzzzzzzzzzzzi_ = @this?.Effective;
                                object szzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzi_);
                                bool szzzzzzzzzzzzzzzzzzzzk_ = szzzzzzzzzzzzzzzzzzzzj_ is CqlInterval<CqlDateTime>;

                                return szzzzzzzzzzzzzzzzzzzzk_;
                            };
                            bool szzzzzzzzzzzzzzzzzzzze_()
                            {
                                DataType szzzzzzzzzzzzzzzzzzzzl_ = @this?.Effective;
                                object szzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzl_);
                                bool szzzzzzzzzzzzzzzzzzzzn_ = szzzzzzzzzzzzzzzzzzzzm_ is CqlDateTime;

                                return szzzzzzzzzzzzzzzzzzzzn_;
                            };
                            if (szzzzzzzzzzzzzzzzzzzzc_())
                            {
                                DataType szzzzzzzzzzzzzzzzzzzzo_ = @this?.Effective;
                                object szzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzo_);

                                return (szzzzzzzzzzzzzzzzzzzzp_ as CqlDateTime) as object;
                            }
                            else if (szzzzzzzzzzzzzzzzzzzzd_())
                            {
                                DataType szzzzzzzzzzzzzzzzzzzzq_ = @this?.Effective;
                                object szzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzq_);

                                return (szzzzzzzzzzzzzzzzzzzzr_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (szzzzzzzzzzzzzzzzzzzze_())
                            {
                                DataType szzzzzzzzzzzzzzzzzzzzs_ = @this?.Effective;
                                object szzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzs_);

                                return (szzzzzzzzzzzzzzzzzzzzt_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime szzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.earliest(context, szzzzzzzzzzzzzzzzzzzza_());

                        return szzzzzzzzzzzzzzzzzzzzb_;
                    };
                    IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.SortBy<Observation>(qzzzzzzzzzzzzzzzzzzzzd_, qzzzzzzzzzzzzzzzzzzzze_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation qzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.First<Observation>(qzzzzzzzzzzzzzzzzzzzzf_);
                    DataType qzzzzzzzzzzzzzzzzzzzzh_ = qzzzzzzzzzzzzzzzzzzzzg_?.Effective;
                    object qzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzh_);

                    return (qzzzzzzzzzzzzzzzzzzzzi_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (ezzzzzzzzzzzzzzzzzzzzu_())
                {
                    CqlValueSet szzzzzzzzzzzzzzzzzzzzu_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
                    IEnumerable<Observation> szzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? szzzzzzzzzzzzzzzzzzzzw_(Observation O2Saturation)
                    {
                        object tzzzzzzzzzzzzzzzzzzzzd_()
                        {
                            bool uzzzzzzzzzzzzzzzzzzzzc_()
                            {
                                DataType uzzzzzzzzzzzzzzzzzzzzf_ = O2Saturation?.Effective;
                                object uzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzf_);
                                bool uzzzzzzzzzzzzzzzzzzzzh_ = uzzzzzzzzzzzzzzzzzzzzg_ is CqlDateTime;

                                return uzzzzzzzzzzzzzzzzzzzzh_;
                            };
                            bool uzzzzzzzzzzzzzzzzzzzzd_()
                            {
                                DataType uzzzzzzzzzzzzzzzzzzzzi_ = O2Saturation?.Effective;
                                object uzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzi_);
                                bool uzzzzzzzzzzzzzzzzzzzzk_ = uzzzzzzzzzzzzzzzzzzzzj_ is CqlInterval<CqlDateTime>;

                                return uzzzzzzzzzzzzzzzzzzzzk_;
                            };
                            bool uzzzzzzzzzzzzzzzzzzzze_()
                            {
                                DataType uzzzzzzzzzzzzzzzzzzzzl_ = O2Saturation?.Effective;
                                object uzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzl_);
                                bool uzzzzzzzzzzzzzzzzzzzzn_ = uzzzzzzzzzzzzzzzzzzzzm_ is CqlDateTime;

                                return uzzzzzzzzzzzzzzzzzzzzn_;
                            };
                            if (uzzzzzzzzzzzzzzzzzzzzc_())
                            {
                                DataType uzzzzzzzzzzzzzzzzzzzzo_ = O2Saturation?.Effective;
                                object uzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzo_);

                                return (uzzzzzzzzzzzzzzzzzzzzp_ as CqlDateTime) as object;
                            }
                            else if (uzzzzzzzzzzzzzzzzzzzzd_())
                            {
                                DataType uzzzzzzzzzzzzzzzzzzzzq_ = O2Saturation?.Effective;
                                object uzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzq_);

                                return (uzzzzzzzzzzzzzzzzzzzzr_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (uzzzzzzzzzzzzzzzzzzzze_())
                            {
                                DataType uzzzzzzzzzzzzzzzzzzzzs_ = O2Saturation?.Effective;
                                object uzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzs_);

                                return (uzzzzzzzzzzzzzzzzzzzzt_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime tzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.earliest(context, tzzzzzzzzzzzzzzzzzzzzd_());
                        Period tzzzzzzzzzzzzzzzzzzzzf_ = EncounterInpatient?.Period;
                        CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzzzzzzzzzzzzzzf_);
                        CqlDateTime tzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzzzzg_);
                        CqlQuantity tzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Quantity(1440m, "minutes");
                        CqlDateTime tzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Subtract(tzzzzzzzzzzzzzzzzzzzzh_, tzzzzzzzzzzzzzzzzzzzzi_);
                        CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzzzzzzzzzzzzzzf_);
                        CqlDateTime tzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzzzzl_);
                        CqlQuantity tzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Quantity(120m, "minutes");
                        CqlDateTime tzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Add(tzzzzzzzzzzzzzzzzzzzzm_, tzzzzzzzzzzzzzzzzzzzzn_);
                        CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Interval(tzzzzzzzzzzzzzzzzzzzzj_, tzzzzzzzzzzzzzzzzzzzzo_, true, true);
                        bool? tzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.In<CqlDateTime>(tzzzzzzzzzzzzzzzzzzzze_, tzzzzzzzzzzzzzzzzzzzzp_, default);
                        Code<ObservationStatus> tzzzzzzzzzzzzzzzzzzzzr_ = O2Saturation?.StatusElement;
                        ObservationStatus? tzzzzzzzzzzzzzzzzzzzzs_ = tzzzzzzzzzzzzzzzzzzzzr_?.Value;
                        Code<ObservationStatus> tzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Convert<Code<ObservationStatus>>(tzzzzzzzzzzzzzzzzzzzzs_);
                        string tzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Convert<string>(tzzzzzzzzzzzzzzzzzzzzt_);
                        string[] tzzzzzzzzzzzzzzzzzzzzv_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? tzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.In<string>(tzzzzzzzzzzzzzzzzzzzzu_, tzzzzzzzzzzzzzzzzzzzzv_ as IEnumerable<string>);
                        bool? tzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzq_, tzzzzzzzzzzzzzzzzzzzzw_);
                        DataType tzzzzzzzzzzzzzzzzzzzzy_ = O2Saturation?.Value;
                        object tzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzy_);
                        bool? uzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Not((bool?)(tzzzzzzzzzzzzzzzzzzzzz_ is null));
                        bool? uzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzx_, uzzzzzzzzzzzzzzzzzzzza_);

                        return uzzzzzzzzzzzzzzzzzzzzb_;
                    };
                    IEnumerable<Observation> szzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Observation>(szzzzzzzzzzzzzzzzzzzzv_, szzzzzzzzzzzzzzzzzzzzw_);
                    object szzzzzzzzzzzzzzzzzzzzy_(Observation @this)
                    {
                        object uzzzzzzzzzzzzzzzzzzzzu_()
                        {
                            bool uzzzzzzzzzzzzzzzzzzzzw_()
                            {
                                DataType uzzzzzzzzzzzzzzzzzzzzz_ = @this?.Effective;
                                object vzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzz_);
                                bool vzzzzzzzzzzzzzzzzzzzzb_ = vzzzzzzzzzzzzzzzzzzzza_ is CqlDateTime;

                                return vzzzzzzzzzzzzzzzzzzzzb_;
                            };
                            bool uzzzzzzzzzzzzzzzzzzzzx_()
                            {
                                DataType vzzzzzzzzzzzzzzzzzzzzc_ = @this?.Effective;
                                object vzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzc_);
                                bool vzzzzzzzzzzzzzzzzzzzze_ = vzzzzzzzzzzzzzzzzzzzzd_ is CqlInterval<CqlDateTime>;

                                return vzzzzzzzzzzzzzzzzzzzze_;
                            };
                            bool uzzzzzzzzzzzzzzzzzzzzy_()
                            {
                                DataType vzzzzzzzzzzzzzzzzzzzzf_ = @this?.Effective;
                                object vzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzf_);
                                bool vzzzzzzzzzzzzzzzzzzzzh_ = vzzzzzzzzzzzzzzzzzzzzg_ is CqlDateTime;

                                return vzzzzzzzzzzzzzzzzzzzzh_;
                            };
                            if (uzzzzzzzzzzzzzzzzzzzzw_())
                            {
                                DataType vzzzzzzzzzzzzzzzzzzzzi_ = @this?.Effective;
                                object vzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzi_);

                                return (vzzzzzzzzzzzzzzzzzzzzj_ as CqlDateTime) as object;
                            }
                            else if (uzzzzzzzzzzzzzzzzzzzzx_())
                            {
                                DataType vzzzzzzzzzzzzzzzzzzzzk_ = @this?.Effective;
                                object vzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzk_);

                                return (vzzzzzzzzzzzzzzzzzzzzl_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (uzzzzzzzzzzzzzzzzzzzzy_())
                            {
                                DataType vzzzzzzzzzzzzzzzzzzzzm_ = @this?.Effective;
                                object vzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzm_);

                                return (vzzzzzzzzzzzzzzzzzzzzn_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime uzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.earliest(context, uzzzzzzzzzzzzzzzzzzzzu_());

                        return uzzzzzzzzzzzzzzzzzzzzv_;
                    };
                    IEnumerable<Observation> szzzzzzzzzzzzzzzzzzzzz_ = context.Operators.SortBy<Observation>(szzzzzzzzzzzzzzzzzzzzx_, szzzzzzzzzzzzzzzzzzzzy_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation tzzzzzzzzzzzzzzzzzzzza_ = context.Operators.First<Observation>(szzzzzzzzzzzzzzzzzzzzz_);
                    DataType tzzzzzzzzzzzzzzzzzzzzb_ = tzzzzzzzzzzzzzzzzzzzza_?.Effective;
                    object tzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzb_);

                    return (tzzzzzzzzzzzzzzzzzzzzc_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime czzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.earliest(context, czzzzzzzzzzzzzzzzzzzze_());
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)? czzzzzzzzzzzzzzzzzzzzg_ = (CqlTupleMetadata_FdREYEdHOZIcMCNYCRFJYJReA, bzzzzzzzzzzzzzzzzzzzzu_, czzzzzzzzzzzzzzzzzzzzd_ as CqlQuantity, czzzzzzzzzzzzzzzzzzzzf_);

            return czzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)?> bzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)?>(bzzzzzzzzzzzzzzzzzzzzp_, bzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)?> bzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)?>(bzzzzzzzzzzzzzzzzzzzzr_);

        return bzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Encounter with First Bicarbonate Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)?> Encounter_with_First_Bicarbonate_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzo_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)? vzzzzzzzzzzzzzzzzzzzzp_(Encounter EncounterInpatient)
        {
            Id vzzzzzzzzzzzzzzzzzzzzs_ = EncounterInpatient?.IdElement;
            string vzzzzzzzzzzzzzzzzzzzzt_ = vzzzzzzzzzzzzzzzzzzzzs_?.Value;
            CqlValueSet vzzzzzzzzzzzzzzzzzzzzu_ = this.Bicarbonate_lab_test(context);
            IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? vzzzzzzzzzzzzzzzzzzzzw_(Observation BicarbonateLab)
            {
                Instant wzzzzzzzzzzzzzzzzzzzzo_ = BicarbonateLab?.IssuedElement;
                DateTimeOffset? wzzzzzzzzzzzzzzzzzzzzp_ = wzzzzzzzzzzzzzzzzzzzzo_?.Value;
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<CqlDateTime>(wzzzzzzzzzzzzzzzzzzzzp_);
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.earliest(context, wzzzzzzzzzzzzzzzzzzzzq_ as object);
                Period wzzzzzzzzzzzzzzzzzzzzs_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzzzzzzzzzzzzs_);
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(wzzzzzzzzzzzzzzzzzzzzt_);
                CqlQuantity wzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Subtract(wzzzzzzzzzzzzzzzzzzzzu_, wzzzzzzzzzzzzzzzzzzzzv_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzzzzzzzzzzzzs_);
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Start(wzzzzzzzzzzzzzzzzzzzzy_);
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Add(wzzzzzzzzzzzzzzzzzzzzz_, wzzzzzzzzzzzzzzzzzzzzv_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Interval(wzzzzzzzzzzzzzzzzzzzzw_, xzzzzzzzzzzzzzzzzzzzzb_, true, true);
                bool? xzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(wzzzzzzzzzzzzzzzzzzzzr_, xzzzzzzzzzzzzzzzzzzzzc_, default);
                Code<ObservationStatus> xzzzzzzzzzzzzzzzzzzzze_ = BicarbonateLab?.StatusElement;
                ObservationStatus? xzzzzzzzzzzzzzzzzzzzzf_ = xzzzzzzzzzzzzzzzzzzzze_?.Value;
                string xzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<string>(xzzzzzzzzzzzzzzzzzzzzf_);
                string[] xzzzzzzzzzzzzzzzzzzzzh_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? xzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.In<string>(xzzzzzzzzzzzzzzzzzzzzg_, xzzzzzzzzzzzzzzzzzzzzh_ as IEnumerable<string>);
                bool? xzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzd_, xzzzzzzzzzzzzzzzzzzzzi_);
                DataType xzzzzzzzzzzzzzzzzzzzzk_ = BicarbonateLab?.Value;
                object xzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzk_);
                bool? xzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Not((bool?)(xzzzzzzzzzzzzzzzzzzzzl_ is null));
                bool? xzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzj_, xzzzzzzzzzzzzzzzzzzzzm_);

                return xzzzzzzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Observation>(vzzzzzzzzzzzzzzzzzzzzv_, vzzzzzzzzzzzzzzzzzzzzw_);
            object vzzzzzzzzzzzzzzzzzzzzy_(Observation @this)
            {
                Instant xzzzzzzzzzzzzzzzzzzzzo_ = @this?.IssuedElement;
                DateTimeOffset? xzzzzzzzzzzzzzzzzzzzzp_ = xzzzzzzzzzzzzzzzzzzzzo_?.Value;
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<CqlDateTime>(xzzzzzzzzzzzzzzzzzzzzp_);
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.earliest(context, xzzzzzzzzzzzzzzzzzzzzq_ as object);

                return xzzzzzzzzzzzzzzzzzzzzr_;
            };
            IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.SortBy<Observation>(vzzzzzzzzzzzzzzzzzzzzx_, vzzzzzzzzzzzzzzzzzzzzy_, System.ComponentModel.ListSortDirection.Ascending);
            Observation wzzzzzzzzzzzzzzzzzzzza_ = context.Operators.First<Observation>(vzzzzzzzzzzzzzzzzzzzzz_);
            DataType wzzzzzzzzzzzzzzzzzzzzb_ = wzzzzzzzzzzzzzzzzzzzza_?.Value;
            object wzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzb_);
            IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? wzzzzzzzzzzzzzzzzzzzzf_(Observation BicarbonateLab)
            {
                Instant xzzzzzzzzzzzzzzzzzzzzs_ = BicarbonateLab?.IssuedElement;
                DateTimeOffset? xzzzzzzzzzzzzzzzzzzzzt_ = xzzzzzzzzzzzzzzzzzzzzs_?.Value;
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Convert<CqlDateTime>(xzzzzzzzzzzzzzzzzzzzzt_);
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.earliest(context, xzzzzzzzzzzzzzzzzzzzzu_ as object);
                Period xzzzzzzzzzzzzzzzzzzzzw_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzzzzzw_);
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzzx_);
                CqlQuantity xzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime yzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Subtract(xzzzzzzzzzzzzzzzzzzzzy_, xzzzzzzzzzzzzzzzzzzzzz_);
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzzzzzw_);
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzzzzc_);
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Add(yzzzzzzzzzzzzzzzzzzzzd_, xzzzzzzzzzzzzzzzzzzzzz_);
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Interval(yzzzzzzzzzzzzzzzzzzzza_, yzzzzzzzzzzzzzzzzzzzzf_, true, true);
                bool? yzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzzzzzzzzzzzzv_, yzzzzzzzzzzzzzzzzzzzzg_, default);
                Code<ObservationStatus> yzzzzzzzzzzzzzzzzzzzzi_ = BicarbonateLab?.StatusElement;
                ObservationStatus? yzzzzzzzzzzzzzzzzzzzzj_ = yzzzzzzzzzzzzzzzzzzzzi_?.Value;
                string yzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<string>(yzzzzzzzzzzzzzzzzzzzzj_);
                string[] yzzzzzzzzzzzzzzzzzzzzl_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? yzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.In<string>(yzzzzzzzzzzzzzzzzzzzzk_, yzzzzzzzzzzzzzzzzzzzzl_ as IEnumerable<string>);
                bool? yzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzzh_, yzzzzzzzzzzzzzzzzzzzzm_);
                DataType yzzzzzzzzzzzzzzzzzzzzo_ = BicarbonateLab?.Value;
                object yzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzo_);
                bool? yzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Not((bool?)(yzzzzzzzzzzzzzzzzzzzzp_ is null));
                bool? yzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzzn_, yzzzzzzzzzzzzzzzzzzzzq_);

                return yzzzzzzzzzzzzzzzzzzzzr_;
            };
            IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Observation>(wzzzzzzzzzzzzzzzzzzzze_, wzzzzzzzzzzzzzzzzzzzzf_);
            object wzzzzzzzzzzzzzzzzzzzzh_(Observation @this)
            {
                Instant yzzzzzzzzzzzzzzzzzzzzs_ = @this?.IssuedElement;
                DateTimeOffset? yzzzzzzzzzzzzzzzzzzzzt_ = yzzzzzzzzzzzzzzzzzzzzs_?.Value;
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Convert<CqlDateTime>(yzzzzzzzzzzzzzzzzzzzzt_);
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.earliest(context, yzzzzzzzzzzzzzzzzzzzzu_ as object);

                return yzzzzzzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.SortBy<Observation>(wzzzzzzzzzzzzzzzzzzzzg_, wzzzzzzzzzzzzzzzzzzzzh_, System.ComponentModel.ListSortDirection.Ascending);
            Observation wzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.First<Observation>(wzzzzzzzzzzzzzzzzzzzzi_);
            Instant wzzzzzzzzzzzzzzzzzzzzk_ = wzzzzzzzzzzzzzzzzzzzzj_?.IssuedElement;
            DateTimeOffset? wzzzzzzzzzzzzzzzzzzzzl_ = wzzzzzzzzzzzzzzzzzzzzk_?.Value;
            CqlDateTime wzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Convert<CqlDateTime>(wzzzzzzzzzzzzzzzzzzzzl_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)? wzzzzzzzzzzzzzzzzzzzzn_ = (CqlTupleMetadata_GbUHPXXHScejjXWhcHJFQQifQ, vzzzzzzzzzzzzzzzzzzzzt_, wzzzzzzzzzzzzzzzzzzzzc_ as CqlQuantity, wzzzzzzzzzzzzzzzzzzzzm_);

            return wzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)?> vzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)?>(vzzzzzzzzzzzzzzzzzzzzo_, vzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)?> vzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)?>(vzzzzzzzzzzzzzzzzzzzzq_);

        return vzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Encounter with First Creatinine Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)?> Encounter_with_First_Creatinine_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzw_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)? yzzzzzzzzzzzzzzzzzzzzx_(Encounter EncounterInpatient)
        {
            Id zzzzzzzzzzzzzzzzzzzzza_ = EncounterInpatient?.IdElement;
            string zzzzzzzzzzzzzzzzzzzzzb_ = zzzzzzzzzzzzzzzzzzzzza_?.Value;
            CqlValueSet zzzzzzzzzzzzzzzzzzzzzc_ = this.Creatinine_lab_test(context);
            IEnumerable<Observation> zzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? zzzzzzzzzzzzzzzzzzzzze_(Observation CreatinineLab)
            {
                Instant zzzzzzzzzzzzzzzzzzzzzw_ = CreatinineLab?.IssuedElement;
                DateTimeOffset? zzzzzzzzzzzzzzzzzzzzzx_ = zzzzzzzzzzzzzzzzzzzzzw_?.Value;
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<CqlDateTime>(zzzzzzzzzzzzzzzzzzzzzx_);
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.earliest(context, zzzzzzzzzzzzzzzzzzzzzy_ as object);
                Period azzzzzzzzzzzzzzzzzzzzza_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzzzzzzza_);
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(azzzzzzzzzzzzzzzzzzzzzb_);
                CqlQuantity azzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime azzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Subtract(azzzzzzzzzzzzzzzzzzzzzc_, azzzzzzzzzzzzzzzzzzzzzd_);
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzzzzzzza_);
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Start(azzzzzzzzzzzzzzzzzzzzzg_);
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Add(azzzzzzzzzzzzzzzzzzzzzh_, azzzzzzzzzzzzzzzzzzzzzd_);
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Interval(azzzzzzzzzzzzzzzzzzzzze_, azzzzzzzzzzzzzzzzzzzzzj_, true, true);
                bool? azzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.In<CqlDateTime>(zzzzzzzzzzzzzzzzzzzzzz_, azzzzzzzzzzzzzzzzzzzzzk_, default);
                Code<ObservationStatus> azzzzzzzzzzzzzzzzzzzzzm_ = CreatinineLab?.StatusElement;
                ObservationStatus? azzzzzzzzzzzzzzzzzzzzzn_ = azzzzzzzzzzzzzzzzzzzzzm_?.Value;
                string azzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Convert<string>(azzzzzzzzzzzzzzzzzzzzzn_);
                string[] azzzzzzzzzzzzzzzzzzzzzp_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? azzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.In<string>(azzzzzzzzzzzzzzzzzzzzzo_, azzzzzzzzzzzzzzzzzzzzzp_ as IEnumerable<string>);
                bool? azzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzzzl_, azzzzzzzzzzzzzzzzzzzzzq_);
                DataType azzzzzzzzzzzzzzzzzzzzzs_ = CreatinineLab?.Value;
                object azzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzs_);
                bool? azzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Not((bool?)(azzzzzzzzzzzzzzzzzzzzzt_ is null));
                bool? azzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzzzr_, azzzzzzzzzzzzzzzzzzzzzu_);

                return azzzzzzzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<Observation> zzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Observation>(zzzzzzzzzzzzzzzzzzzzzd_, zzzzzzzzzzzzzzzzzzzzze_);
            object zzzzzzzzzzzzzzzzzzzzzg_(Observation @this)
            {
                Instant azzzzzzzzzzzzzzzzzzzzzw_ = @this?.IssuedElement;
                DateTimeOffset? azzzzzzzzzzzzzzzzzzzzzx_ = azzzzzzzzzzzzzzzzzzzzzw_?.Value;
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<CqlDateTime>(azzzzzzzzzzzzzzzzzzzzzx_);
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.earliest(context, azzzzzzzzzzzzzzzzzzzzzy_ as object);

                return azzzzzzzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<Observation> zzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.SortBy<Observation>(zzzzzzzzzzzzzzzzzzzzzf_, zzzzzzzzzzzzzzzzzzzzzg_, System.ComponentModel.ListSortDirection.Ascending);
            Observation zzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.First<Observation>(zzzzzzzzzzzzzzzzzzzzzh_);
            DataType zzzzzzzzzzzzzzzzzzzzzj_ = zzzzzzzzzzzzzzzzzzzzzi_?.Value;
            object zzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzj_);
            IEnumerable<Observation> zzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? zzzzzzzzzzzzzzzzzzzzzn_(Observation CreatinineLab)
            {
                Instant bzzzzzzzzzzzzzzzzzzzzza_ = CreatinineLab?.IssuedElement;
                DateTimeOffset? bzzzzzzzzzzzzzzzzzzzzzb_ = bzzzzzzzzzzzzzzzzzzzzza_?.Value;
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzzb_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.earliest(context, bzzzzzzzzzzzzzzzzzzzzzc_ as object);
                Period bzzzzzzzzzzzzzzzzzzzzze_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzzzzzze_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzzzf_);
                CqlQuantity bzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Subtract(bzzzzzzzzzzzzzzzzzzzzzg_, bzzzzzzzzzzzzzzzzzzzzzh_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzzzzzze_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzzzk_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Add(bzzzzzzzzzzzzzzzzzzzzzl_, bzzzzzzzzzzzzzzzzzzzzzh_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Interval(bzzzzzzzzzzzzzzzzzzzzzi_, bzzzzzzzzzzzzzzzzzzzzzn_, true, true);
                bool? bzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.In<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzzd_, bzzzzzzzzzzzzzzzzzzzzzo_, default);
                Code<ObservationStatus> bzzzzzzzzzzzzzzzzzzzzzq_ = CreatinineLab?.StatusElement;
                ObservationStatus? bzzzzzzzzzzzzzzzzzzzzzr_ = bzzzzzzzzzzzzzzzzzzzzzq_?.Value;
                string bzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Convert<string>(bzzzzzzzzzzzzzzzzzzzzzr_);
                string[] bzzzzzzzzzzzzzzzzzzzzzt_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? bzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<string>(bzzzzzzzzzzzzzzzzzzzzzs_, bzzzzzzzzzzzzzzzzzzzzzt_ as IEnumerable<string>);
                bool? bzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzp_, bzzzzzzzzzzzzzzzzzzzzzu_);
                DataType bzzzzzzzzzzzzzzzzzzzzzw_ = CreatinineLab?.Value;
                object bzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzw_);
                bool? bzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Not((bool?)(bzzzzzzzzzzzzzzzzzzzzzx_ is null));
                bool? bzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzv_, bzzzzzzzzzzzzzzzzzzzzzy_);

                return bzzzzzzzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<Observation> zzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Observation>(zzzzzzzzzzzzzzzzzzzzzm_, zzzzzzzzzzzzzzzzzzzzzn_);
            object zzzzzzzzzzzzzzzzzzzzzp_(Observation @this)
            {
                Instant czzzzzzzzzzzzzzzzzzzzza_ = @this?.IssuedElement;
                DateTimeOffset? czzzzzzzzzzzzzzzzzzzzzb_ = czzzzzzzzzzzzzzzzzzzzza_?.Value;
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<CqlDateTime>(czzzzzzzzzzzzzzzzzzzzzb_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.earliest(context, czzzzzzzzzzzzzzzzzzzzzc_ as object);

                return czzzzzzzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<Observation> zzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.SortBy<Observation>(zzzzzzzzzzzzzzzzzzzzzo_, zzzzzzzzzzzzzzzzzzzzzp_, System.ComponentModel.ListSortDirection.Ascending);
            Observation zzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.First<Observation>(zzzzzzzzzzzzzzzzzzzzzq_);
            Instant zzzzzzzzzzzzzzzzzzzzzs_ = zzzzzzzzzzzzzzzzzzzzzr_?.IssuedElement;
            DateTimeOffset? zzzzzzzzzzzzzzzzzzzzzt_ = zzzzzzzzzzzzzzzzzzzzzs_?.Value;
            CqlDateTime zzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Convert<CqlDateTime>(zzzzzzzzzzzzzzzzzzzzzt_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)? zzzzzzzzzzzzzzzzzzzzzv_ = (CqlTupleMetadata_FETECNQPQREfGRgPYWhOWgeWA, zzzzzzzzzzzzzzzzzzzzzb_, zzzzzzzzzzzzzzzzzzzzzk_ as CqlQuantity, zzzzzzzzzzzzzzzzzzzzzu_);

            return zzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)?> yzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)?>(yzzzzzzzzzzzzzzzzzzzzw_, yzzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)?> yzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)?>(yzzzzzzzzzzzzzzzzzzzzy_);

        return yzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Encounter with First Hematocrit Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?> Encounter_with_First_Hematocrit_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzze_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)? czzzzzzzzzzzzzzzzzzzzzf_(Encounter EncounterInpatient)
        {
            Id czzzzzzzzzzzzzzzzzzzzzi_ = EncounterInpatient?.IdElement;
            string czzzzzzzzzzzzzzzzzzzzzj_ = czzzzzzzzzzzzzzzzzzzzzi_?.Value;
            CqlValueSet czzzzzzzzzzzzzzzzzzzzzk_ = this.Hematocrit_lab_test(context);
            IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? czzzzzzzzzzzzzzzzzzzzzm_(Observation HematocritLab)
            {
                Instant dzzzzzzzzzzzzzzzzzzzzze_ = HematocritLab?.IssuedElement;
                DateTimeOffset? dzzzzzzzzzzzzzzzzzzzzzf_ = dzzzzzzzzzzzzzzzzzzzzze_?.Value;
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzzf_);
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.earliest(context, dzzzzzzzzzzzzzzzzzzzzzg_ as object);
                Period dzzzzzzzzzzzzzzzzzzzzzi_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzzzzzzzzzzzzzzi_);
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Start(dzzzzzzzzzzzzzzzzzzzzzj_);
                CqlQuantity dzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Subtract(dzzzzzzzzzzzzzzzzzzzzzk_, dzzzzzzzzzzzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzzzzzzzzzzzzzzi_);
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(dzzzzzzzzzzzzzzzzzzzzzo_);
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Add(dzzzzzzzzzzzzzzzzzzzzzp_, dzzzzzzzzzzzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Interval(dzzzzzzzzzzzzzzzzzzzzzm_, dzzzzzzzzzzzzzzzzzzzzzr_, true, true);
                bool? dzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.In<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzzh_, dzzzzzzzzzzzzzzzzzzzzzs_, default);
                Code<ObservationStatus> dzzzzzzzzzzzzzzzzzzzzzu_ = HematocritLab?.StatusElement;
                ObservationStatus? dzzzzzzzzzzzzzzzzzzzzzv_ = dzzzzzzzzzzzzzzzzzzzzzu_?.Value;
                string dzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<string>(dzzzzzzzzzzzzzzzzzzzzzv_);
                string[] dzzzzzzzzzzzzzzzzzzzzzx_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? dzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<string>(dzzzzzzzzzzzzzzzzzzzzzw_, dzzzzzzzzzzzzzzzzzzzzzx_ as IEnumerable<string>);
                bool? dzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzzzzt_, dzzzzzzzzzzzzzzzzzzzzzy_);
                DataType ezzzzzzzzzzzzzzzzzzzzza_ = HematocritLab?.Value;
                object ezzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzza_);
                bool? ezzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Not((bool?)(ezzzzzzzzzzzzzzzzzzzzzb_ is null));
                bool? ezzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzzzzz_, ezzzzzzzzzzzzzzzzzzzzzc_);

                return ezzzzzzzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Observation>(czzzzzzzzzzzzzzzzzzzzzl_, czzzzzzzzzzzzzzzzzzzzzm_);
            object czzzzzzzzzzzzzzzzzzzzzo_(Observation @this)
            {
                Instant ezzzzzzzzzzzzzzzzzzzzze_ = @this?.IssuedElement;
                DateTimeOffset? ezzzzzzzzzzzzzzzzzzzzzf_ = ezzzzzzzzzzzzzzzzzzzzze_?.Value;
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<CqlDateTime>(ezzzzzzzzzzzzzzzzzzzzzf_);
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.earliest(context, ezzzzzzzzzzzzzzzzzzzzzg_ as object);

                return ezzzzzzzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.SortBy<Observation>(czzzzzzzzzzzzzzzzzzzzzn_, czzzzzzzzzzzzzzzzzzzzzo_, System.ComponentModel.ListSortDirection.Ascending);
            Observation czzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.First<Observation>(czzzzzzzzzzzzzzzzzzzzzp_);
            DataType czzzzzzzzzzzzzzzzzzzzzr_ = czzzzzzzzzzzzzzzzzzzzzq_?.Value;
            object czzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzr_);
            IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? czzzzzzzzzzzzzzzzzzzzzv_(Observation HematocritLab)
            {
                Instant ezzzzzzzzzzzzzzzzzzzzzi_ = HematocritLab?.IssuedElement;
                DateTimeOffset? ezzzzzzzzzzzzzzzzzzzzzj_ = ezzzzzzzzzzzzzzzzzzzzzi_?.Value;
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<CqlDateTime>(ezzzzzzzzzzzzzzzzzzzzzj_);
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.earliest(context, ezzzzzzzzzzzzzzzzzzzzzk_ as object);
                Period ezzzzzzzzzzzzzzzzzzzzzm_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzzzzzzzzzzzzzzm_);
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzzzzzn_);
                CqlQuantity ezzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Subtract(ezzzzzzzzzzzzzzzzzzzzzo_, ezzzzzzzzzzzzzzzzzzzzzp_);
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzzzzzzzzzzzzzzm_);
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzzzzzs_);
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Add(ezzzzzzzzzzzzzzzzzzzzzt_, ezzzzzzzzzzzzzzzzzzzzzp_);
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Interval(ezzzzzzzzzzzzzzzzzzzzzq_, ezzzzzzzzzzzzzzzzzzzzzv_, true, true);
                bool? ezzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.In<CqlDateTime>(ezzzzzzzzzzzzzzzzzzzzzl_, ezzzzzzzzzzzzzzzzzzzzzw_, default);
                Code<ObservationStatus> ezzzzzzzzzzzzzzzzzzzzzy_ = HematocritLab?.StatusElement;
                ObservationStatus? ezzzzzzzzzzzzzzzzzzzzzz_ = ezzzzzzzzzzzzzzzzzzzzzy_?.Value;
                string fzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<string>(ezzzzzzzzzzzzzzzzzzzzzz_);
                string[] fzzzzzzzzzzzzzzzzzzzzzb_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? fzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.In<string>(fzzzzzzzzzzzzzzzzzzzzza_, fzzzzzzzzzzzzzzzzzzzzzb_ as IEnumerable<string>);
                bool? fzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(ezzzzzzzzzzzzzzzzzzzzzx_, fzzzzzzzzzzzzzzzzzzzzzc_);
                DataType fzzzzzzzzzzzzzzzzzzzzze_ = HematocritLab?.Value;
                object fzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzze_);
                bool? fzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Not((bool?)(fzzzzzzzzzzzzzzzzzzzzzf_ is null));
                bool? fzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzd_, fzzzzzzzzzzzzzzzzzzzzzg_);

                return fzzzzzzzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Observation>(czzzzzzzzzzzzzzzzzzzzzu_, czzzzzzzzzzzzzzzzzzzzzv_);
            object czzzzzzzzzzzzzzzzzzzzzx_(Observation @this)
            {
                Instant fzzzzzzzzzzzzzzzzzzzzzi_ = @this?.IssuedElement;
                DateTimeOffset? fzzzzzzzzzzzzzzzzzzzzzj_ = fzzzzzzzzzzzzzzzzzzzzzi_?.Value;
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<CqlDateTime>(fzzzzzzzzzzzzzzzzzzzzzj_);
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.earliest(context, fzzzzzzzzzzzzzzzzzzzzzk_ as object);

                return fzzzzzzzzzzzzzzzzzzzzzl_;
            };
            IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.SortBy<Observation>(czzzzzzzzzzzzzzzzzzzzzw_, czzzzzzzzzzzzzzzzzzzzzx_, System.ComponentModel.ListSortDirection.Ascending);
            Observation czzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.First<Observation>(czzzzzzzzzzzzzzzzzzzzzy_);
            Instant dzzzzzzzzzzzzzzzzzzzzza_ = czzzzzzzzzzzzzzzzzzzzzz_?.IssuedElement;
            DateTimeOffset? dzzzzzzzzzzzzzzzzzzzzzb_ = dzzzzzzzzzzzzzzzzzzzzza_?.Value;
            CqlDateTime dzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzzb_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)? dzzzzzzzzzzzzzzzzzzzzzd_ = (CqlTupleMetadata_DIHdhbAJeJTdiAVUAELUHRNdS, czzzzzzzzzzzzzzzzzzzzzj_, czzzzzzzzzzzzzzzzzzzzzs_ as CqlQuantity, dzzzzzzzzzzzzzzzzzzzzzc_);

            return dzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?> czzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?>(czzzzzzzzzzzzzzzzzzzzze_, czzzzzzzzzzzzzzzzzzzzzf_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?> czzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?>(czzzzzzzzzzzzzzzzzzzzzg_);

        return czzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Encounter with First Platelet Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)?> Encounter_with_First_Platelet_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzm_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)? fzzzzzzzzzzzzzzzzzzzzzn_(Encounter EncounterInpatient)
        {
            Id fzzzzzzzzzzzzzzzzzzzzzq_ = EncounterInpatient?.IdElement;
            string fzzzzzzzzzzzzzzzzzzzzzr_ = fzzzzzzzzzzzzzzzzzzzzzq_?.Value;
            CqlValueSet fzzzzzzzzzzzzzzzzzzzzzs_ = this.Platelet_count_lab_test(context);
            IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? fzzzzzzzzzzzzzzzzzzzzzu_(Observation PlateletLab)
            {
                Instant gzzzzzzzzzzzzzzzzzzzzzm_ = PlateletLab?.IssuedElement;
                DateTimeOffset? gzzzzzzzzzzzzzzzzzzzzzn_ = gzzzzzzzzzzzzzzzzzzzzzm_?.Value;
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Convert<CqlDateTime>(gzzzzzzzzzzzzzzzzzzzzzn_);
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.earliest(context, gzzzzzzzzzzzzzzzzzzzzzo_ as object);
                Period gzzzzzzzzzzzzzzzzzzzzzq_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzzzzzzzzzzzzzq_);
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzzzzr_);
                CqlQuantity gzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Subtract(gzzzzzzzzzzzzzzzzzzzzzs_, gzzzzzzzzzzzzzzzzzzzzzt_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzzzzzzzzzzzzzq_);
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzzzzw_);
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Add(gzzzzzzzzzzzzzzzzzzzzzx_, gzzzzzzzzzzzzzzzzzzzzzt_);
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Interval(gzzzzzzzzzzzzzzzzzzzzzu_, gzzzzzzzzzzzzzzzzzzzzzz_, true, true);
                bool? hzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDateTime>(gzzzzzzzzzzzzzzzzzzzzzp_, hzzzzzzzzzzzzzzzzzzzzza_, default);
                Code<ObservationStatus> hzzzzzzzzzzzzzzzzzzzzzc_ = PlateletLab?.StatusElement;
                ObservationStatus? hzzzzzzzzzzzzzzzzzzzzzd_ = hzzzzzzzzzzzzzzzzzzzzzc_?.Value;
                string hzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Convert<string>(hzzzzzzzzzzzzzzzzzzzzzd_);
                string[] hzzzzzzzzzzzzzzzzzzzzzf_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? hzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.In<string>(hzzzzzzzzzzzzzzzzzzzzze_, hzzzzzzzzzzzzzzzzzzzzzf_ as IEnumerable<string>);
                bool? hzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzb_, hzzzzzzzzzzzzzzzzzzzzzg_);
                DataType hzzzzzzzzzzzzzzzzzzzzzi_ = PlateletLab?.Value;
                object hzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzi_);
                bool? hzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Not((bool?)(hzzzzzzzzzzzzzzzzzzzzzj_ is null));
                bool? hzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzh_, hzzzzzzzzzzzzzzzzzzzzzk_);

                return hzzzzzzzzzzzzzzzzzzzzzl_;
            };
            IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Observation>(fzzzzzzzzzzzzzzzzzzzzzt_, fzzzzzzzzzzzzzzzzzzzzzu_);
            object fzzzzzzzzzzzzzzzzzzzzzw_(Observation @this)
            {
                Instant hzzzzzzzzzzzzzzzzzzzzzm_ = @this?.IssuedElement;
                DateTimeOffset? hzzzzzzzzzzzzzzzzzzzzzn_ = hzzzzzzzzzzzzzzzzzzzzzm_?.Value;
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Convert<CqlDateTime>(hzzzzzzzzzzzzzzzzzzzzzn_);
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.earliest(context, hzzzzzzzzzzzzzzzzzzzzzo_ as object);

                return hzzzzzzzzzzzzzzzzzzzzzp_;
            };
            IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.SortBy<Observation>(fzzzzzzzzzzzzzzzzzzzzzv_, fzzzzzzzzzzzzzzzzzzzzzw_, System.ComponentModel.ListSortDirection.Ascending);
            Observation fzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.First<Observation>(fzzzzzzzzzzzzzzzzzzzzzx_);
            DataType fzzzzzzzzzzzzzzzzzzzzzz_ = fzzzzzzzzzzzzzzzzzzzzzy_?.Value;
            object gzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzz_);
            IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? gzzzzzzzzzzzzzzzzzzzzzd_(Observation PlateletLab)
            {
                Instant hzzzzzzzzzzzzzzzzzzzzzq_ = PlateletLab?.IssuedElement;
                DateTimeOffset? hzzzzzzzzzzzzzzzzzzzzzr_ = hzzzzzzzzzzzzzzzzzzzzzq_?.Value;
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Convert<CqlDateTime>(hzzzzzzzzzzzzzzzzzzzzzr_);
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.earliest(context, hzzzzzzzzzzzzzzzzzzzzzs_ as object);
                Period hzzzzzzzzzzzzzzzzzzzzzu_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzzzzzzzzzzzzzu_);
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(hzzzzzzzzzzzzzzzzzzzzzv_);
                CqlQuantity hzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Subtract(hzzzzzzzzzzzzzzzzzzzzzw_, hzzzzzzzzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzzzzzzzzzzzzzu_);
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(izzzzzzzzzzzzzzzzzzzzza_);
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Add(izzzzzzzzzzzzzzzzzzzzzb_, hzzzzzzzzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Interval(hzzzzzzzzzzzzzzzzzzzzzy_, izzzzzzzzzzzzzzzzzzzzzd_, true, true);
                bool? izzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.In<CqlDateTime>(hzzzzzzzzzzzzzzzzzzzzzt_, izzzzzzzzzzzzzzzzzzzzze_, default);
                Code<ObservationStatus> izzzzzzzzzzzzzzzzzzzzzg_ = PlateletLab?.StatusElement;
                ObservationStatus? izzzzzzzzzzzzzzzzzzzzzh_ = izzzzzzzzzzzzzzzzzzzzzg_?.Value;
                string izzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Convert<string>(izzzzzzzzzzzzzzzzzzzzzh_);
                string[] izzzzzzzzzzzzzzzzzzzzzj_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? izzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.In<string>(izzzzzzzzzzzzzzzzzzzzzi_, izzzzzzzzzzzzzzzzzzzzzj_ as IEnumerable<string>);
                bool? izzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzf_, izzzzzzzzzzzzzzzzzzzzzk_);
                DataType izzzzzzzzzzzzzzzzzzzzzm_ = PlateletLab?.Value;
                object izzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzm_);
                bool? izzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Not((bool?)(izzzzzzzzzzzzzzzzzzzzzn_ is null));
                bool? izzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzl_, izzzzzzzzzzzzzzzzzzzzzo_);

                return izzzzzzzzzzzzzzzzzzzzzp_;
            };
            IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Observation>(gzzzzzzzzzzzzzzzzzzzzzc_, gzzzzzzzzzzzzzzzzzzzzzd_);
            object gzzzzzzzzzzzzzzzzzzzzzf_(Observation @this)
            {
                Instant izzzzzzzzzzzzzzzzzzzzzq_ = @this?.IssuedElement;
                DateTimeOffset? izzzzzzzzzzzzzzzzzzzzzr_ = izzzzzzzzzzzzzzzzzzzzzq_?.Value;
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Convert<CqlDateTime>(izzzzzzzzzzzzzzzzzzzzzr_);
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.earliest(context, izzzzzzzzzzzzzzzzzzzzzs_ as object);

                return izzzzzzzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.SortBy<Observation>(gzzzzzzzzzzzzzzzzzzzzze_, gzzzzzzzzzzzzzzzzzzzzzf_, System.ComponentModel.ListSortDirection.Ascending);
            Observation gzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.First<Observation>(gzzzzzzzzzzzzzzzzzzzzzg_);
            Instant gzzzzzzzzzzzzzzzzzzzzzi_ = gzzzzzzzzzzzzzzzzzzzzzh_?.IssuedElement;
            DateTimeOffset? gzzzzzzzzzzzzzzzzzzzzzj_ = gzzzzzzzzzzzzzzzzzzzzzi_?.Value;
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<CqlDateTime>(gzzzzzzzzzzzzzzzzzzzzzj_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)? gzzzzzzzzzzzzzzzzzzzzzl_ = (CqlTupleMetadata_DAUcYHQZcDKbIfORJOEZBDgIh, fzzzzzzzzzzzzzzzzzzzzzr_, gzzzzzzzzzzzzzzzzzzzzza_ as CqlQuantity, gzzzzzzzzzzzzzzzzzzzzzk_);

            return gzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)?> fzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)?>(fzzzzzzzzzzzzzzzzzzzzzm_, fzzzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)?> fzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)?>(fzzzzzzzzzzzzzzzzzzzzzo_);

        return fzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Encounter with First Sodium Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)?> Encounter_with_First_Sodium_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzu_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)? izzzzzzzzzzzzzzzzzzzzzv_(Encounter EncounterInpatient)
        {
            Id izzzzzzzzzzzzzzzzzzzzzy_ = EncounterInpatient?.IdElement;
            string izzzzzzzzzzzzzzzzzzzzzz_ = izzzzzzzzzzzzzzzzzzzzzy_?.Value;
            CqlValueSet jzzzzzzzzzzzzzzzzzzzzza_ = this.Sodium_lab_test(context);
            IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? jzzzzzzzzzzzzzzzzzzzzzc_(Observation SodiumLab)
            {
                Instant jzzzzzzzzzzzzzzzzzzzzzu_ = SodiumLab?.IssuedElement;
                DateTimeOffset? jzzzzzzzzzzzzzzzzzzzzzv_ = jzzzzzzzzzzzzzzzzzzzzzu_?.Value;
                CqlDateTime jzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<CqlDateTime>(jzzzzzzzzzzzzzzzzzzzzzv_);
                CqlDateTime jzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.earliest(context, jzzzzzzzzzzzzzzzzzzzzzw_ as object);
                Period jzzzzzzzzzzzzzzzzzzzzzy_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzzzzzzy_);
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Start(jzzzzzzzzzzzzzzzzzzzzzz_);
                CqlQuantity kzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Subtract(kzzzzzzzzzzzzzzzzzzzzza_, kzzzzzzzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzzzzzzy_);
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzzze_);
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Add(kzzzzzzzzzzzzzzzzzzzzzf_, kzzzzzzzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Interval(kzzzzzzzzzzzzzzzzzzzzzc_, kzzzzzzzzzzzzzzzzzzzzzh_, true, true);
                bool? kzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzzzzzzzzzzzzzx_, kzzzzzzzzzzzzzzzzzzzzzi_, default);
                Code<ObservationStatus> kzzzzzzzzzzzzzzzzzzzzzk_ = SodiumLab?.StatusElement;
                ObservationStatus? kzzzzzzzzzzzzzzzzzzzzzl_ = kzzzzzzzzzzzzzzzzzzzzzk_?.Value;
                string kzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Convert<string>(kzzzzzzzzzzzzzzzzzzzzzl_);
                string[] kzzzzzzzzzzzzzzzzzzzzzn_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? kzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.In<string>(kzzzzzzzzzzzzzzzzzzzzzm_, kzzzzzzzzzzzzzzzzzzzzzn_ as IEnumerable<string>);
                bool? kzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzj_, kzzzzzzzzzzzzzzzzzzzzzo_);
                DataType kzzzzzzzzzzzzzzzzzzzzzq_ = SodiumLab?.Value;
                object kzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzq_);
                bool? kzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Not((bool?)(kzzzzzzzzzzzzzzzzzzzzzr_ is null));
                bool? kzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzp_, kzzzzzzzzzzzzzzzzzzzzzs_);

                return kzzzzzzzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Observation>(jzzzzzzzzzzzzzzzzzzzzzb_, jzzzzzzzzzzzzzzzzzzzzzc_);
            object jzzzzzzzzzzzzzzzzzzzzze_(Observation @this)
            {
                Instant kzzzzzzzzzzzzzzzzzzzzzu_ = @this?.IssuedElement;
                DateTimeOffset? kzzzzzzzzzzzzzzzzzzzzzv_ = kzzzzzzzzzzzzzzzzzzzzzu_?.Value;
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<CqlDateTime>(kzzzzzzzzzzzzzzzzzzzzzv_);
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.earliest(context, kzzzzzzzzzzzzzzzzzzzzzw_ as object);

                return kzzzzzzzzzzzzzzzzzzzzzx_;
            };
            IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.SortBy<Observation>(jzzzzzzzzzzzzzzzzzzzzzd_, jzzzzzzzzzzzzzzzzzzzzze_, System.ComponentModel.ListSortDirection.Ascending);
            Observation jzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.First<Observation>(jzzzzzzzzzzzzzzzzzzzzzf_);
            DataType jzzzzzzzzzzzzzzzzzzzzzh_ = jzzzzzzzzzzzzzzzzzzzzzg_?.Value;
            object jzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzh_);
            IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? jzzzzzzzzzzzzzzzzzzzzzl_(Observation SodiumLab)
            {
                Instant kzzzzzzzzzzzzzzzzzzzzzy_ = SodiumLab?.IssuedElement;
                DateTimeOffset? kzzzzzzzzzzzzzzzzzzzzzz_ = kzzzzzzzzzzzzzzzzzzzzzy_?.Value;
                CqlDateTime lzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<CqlDateTime>(kzzzzzzzzzzzzzzzzzzzzzz_);
                CqlDateTime lzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.earliest(context, lzzzzzzzzzzzzzzzzzzzzza_ as object);
                Period lzzzzzzzzzzzzzzzzzzzzzc_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzzzzzzzzzzzzc_);
                CqlDateTime lzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzzzzzd_);
                CqlQuantity lzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime lzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Subtract(lzzzzzzzzzzzzzzzzzzzzze_, lzzzzzzzzzzzzzzzzzzzzzf_);
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzzzzzzzzzzzzc_);
                CqlDateTime lzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzzzzzi_);
                CqlDateTime lzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Add(lzzzzzzzzzzzzzzzzzzzzzj_, lzzzzzzzzzzzzzzzzzzzzzf_);
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Interval(lzzzzzzzzzzzzzzzzzzzzzg_, lzzzzzzzzzzzzzzzzzzzzzl_, true, true);
                bool? lzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.In<CqlDateTime>(lzzzzzzzzzzzzzzzzzzzzzb_, lzzzzzzzzzzzzzzzzzzzzzm_, default);
                Code<ObservationStatus> lzzzzzzzzzzzzzzzzzzzzzo_ = SodiumLab?.StatusElement;
                ObservationStatus? lzzzzzzzzzzzzzzzzzzzzzp_ = lzzzzzzzzzzzzzzzzzzzzzo_?.Value;
                string lzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<string>(lzzzzzzzzzzzzzzzzzzzzzp_);
                string[] lzzzzzzzzzzzzzzzzzzzzzr_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? lzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.In<string>(lzzzzzzzzzzzzzzzzzzzzzq_, lzzzzzzzzzzzzzzzzzzzzzr_ as IEnumerable<string>);
                bool? lzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzn_, lzzzzzzzzzzzzzzzzzzzzzs_);
                DataType lzzzzzzzzzzzzzzzzzzzzzu_ = SodiumLab?.Value;
                object lzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzu_);
                bool? lzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Not((bool?)(lzzzzzzzzzzzzzzzzzzzzzv_ is null));
                bool? lzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzt_, lzzzzzzzzzzzzzzzzzzzzzw_);

                return lzzzzzzzzzzzzzzzzzzzzzx_;
            };
            IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Observation>(jzzzzzzzzzzzzzzzzzzzzzk_, jzzzzzzzzzzzzzzzzzzzzzl_);
            object jzzzzzzzzzzzzzzzzzzzzzn_(Observation @this)
            {
                Instant lzzzzzzzzzzzzzzzzzzzzzy_ = @this?.IssuedElement;
                DateTimeOffset? lzzzzzzzzzzzzzzzzzzzzzz_ = lzzzzzzzzzzzzzzzzzzzzzy_?.Value;
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<CqlDateTime>(lzzzzzzzzzzzzzzzzzzzzzz_);
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.earliest(context, mzzzzzzzzzzzzzzzzzzzzza_ as object);

                return mzzzzzzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.SortBy<Observation>(jzzzzzzzzzzzzzzzzzzzzzm_, jzzzzzzzzzzzzzzzzzzzzzn_, System.ComponentModel.ListSortDirection.Ascending);
            Observation jzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.First<Observation>(jzzzzzzzzzzzzzzzzzzzzzo_);
            Instant jzzzzzzzzzzzzzzzzzzzzzq_ = jzzzzzzzzzzzzzzzzzzzzzp_?.IssuedElement;
            DateTimeOffset? jzzzzzzzzzzzzzzzzzzzzzr_ = jzzzzzzzzzzzzzzzzzzzzzq_?.Value;
            CqlDateTime jzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Convert<CqlDateTime>(jzzzzzzzzzzzzzzzzzzzzzr_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)? jzzzzzzzzzzzzzzzzzzzzzt_ = (CqlTupleMetadata_GKGeLARADLGJcNcZaDhdCREMa, izzzzzzzzzzzzzzzzzzzzzz_, jzzzzzzzzzzzzzzzzzzzzzi_ as CqlQuantity, jzzzzzzzzzzzzzzzzzzzzzs_);

            return jzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)?> izzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)?>(izzzzzzzzzzzzzzzzzzzzzu_, izzzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)?> izzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)?>(izzzzzzzzzzzzzzzzzzzzzw_);

        return izzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Qualifying Blood Pressure Reading")]
    public IEnumerable<Observation> Qualifying_Blood_Pressure_Reading(CqlContext context)
    {
        IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bp"));
        bool? mzzzzzzzzzzzzzzzzzzzzzd_(Observation BPReading)
        {
            DataType mzzzzzzzzzzzzzzzzzzzzzf_ = BPReading?.Effective;
            object mzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzf_);
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.earliest(context, mzzzzzzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzi_ = this.Measurement_Period(context);
            bool? mzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.In<CqlDateTime>(mzzzzzzzzzzzzzzzzzzzzzh_, mzzzzzzzzzzzzzzzzzzzzzi_, "day");
            Code<ObservationStatus> mzzzzzzzzzzzzzzzzzzzzzk_ = BPReading?.StatusElement;
            ObservationStatus? mzzzzzzzzzzzzzzzzzzzzzl_ = mzzzzzzzzzzzzzzzzzzzzzk_?.Value;
            string mzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Convert<string>(mzzzzzzzzzzzzzzzzzzzzzl_);
            string[] mzzzzzzzzzzzzzzzzzzzzzn_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? mzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.In<string>(mzzzzzzzzzzzzzzzzzzzzzm_, mzzzzzzzzzzzzzzzzzzzzzn_ as IEnumerable<string>);
            bool? mzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzzj_, mzzzzzzzzzzzzzzzzzzzzzo_);

            return mzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Observation>(mzzzzzzzzzzzzzzzzzzzzzc_, mzzzzzzzzzzzzzzzzzzzzzd_);

        return mzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Test2")]
    public CqlQuantity Test2(CqlContext context)
    {
        IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzzzzq_ = this.Qualifying_Blood_Pressure_Reading(context);
        IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzzzzr_(Observation SBPReading)
        {
            IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzy_ = this.Inpatient_Encounters(context);
            bool? mzzzzzzzzzzzzzzzzzzzzzz_(Encounter EncounterInpatient)
            {
                DataType nzzzzzzzzzzzzzzzzzzzzzd_ = SBPReading?.Effective;
                object nzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzd_);
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.earliest(context, nzzzzzzzzzzzzzzzzzzzzze_);
                Period nzzzzzzzzzzzzzzzzzzzzzg_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzzzzzzzzzzzzg_);
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzzzzh_);
                CqlQuantity nzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Subtract(nzzzzzzzzzzzzzzzzzzzzzi_, nzzzzzzzzzzzzzzzzzzzzzj_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzzzzzzzzzzzzg_);
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzzzzm_);
                CqlQuantity nzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Add(nzzzzzzzzzzzzzzzzzzzzzn_, nzzzzzzzzzzzzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Interval(nzzzzzzzzzzzzzzzzzzzzzk_, nzzzzzzzzzzzzzzzzzzzzzp_, true, true);
                bool? nzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(nzzzzzzzzzzzzzzzzzzzzzf_, nzzzzzzzzzzzzzzzzzzzzzq_, default);

                return nzzzzzzzzzzzzzzzzzzzzzr_;
            };
            IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Encounter>(mzzzzzzzzzzzzzzzzzzzzzy_, mzzzzzzzzzzzzzzzzzzzzzz_);
            Observation nzzzzzzzzzzzzzzzzzzzzzb_(Encounter EncounterInpatient) =>
                SBPReading;
            IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Select<Encounter, Observation>(nzzzzzzzzzzzzzzzzzzzzza_, nzzzzzzzzzzzzzzzzzzzzzb_);

            return nzzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.SelectMany<Observation, Observation>(mzzzzzzzzzzzzzzzzzzzzzq_, mzzzzzzzzzzzzzzzzzzzzzr_);
        CqlQuantity mzzzzzzzzzzzzzzzzzzzzzt_(Observation SBPReading)
        {
            List<Observation.ComponentComponent> nzzzzzzzzzzzzzzzzzzzzzs_ = SBPReading?.Component;
            bool? nzzzzzzzzzzzzzzzzzzzzzt_(Observation.ComponentComponent SBPComponent)
            {
                CodeableConcept nzzzzzzzzzzzzzzzzzzzzzz_ = SBPComponent?.Code;
                CqlConcept ozzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, nzzzzzzzzzzzzzzzzzzzzzz_);
                CqlCode ozzzzzzzzzzzzzzzzzzzzzb_ = this.Systolic_blood_pressure(context);
                CqlConcept ozzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.ConvertCodeToConcept(ozzzzzzzzzzzzzzzzzzzzzb_);
                bool? ozzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Equivalent(ozzzzzzzzzzzzzzzzzzzzza_, ozzzzzzzzzzzzzzzzzzzzzc_);

                return ozzzzzzzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<Observation.ComponentComponent> nzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)nzzzzzzzzzzzzzzzzzzzzzs_, nzzzzzzzzzzzzzzzzzzzzzt_);
            CqlQuantity nzzzzzzzzzzzzzzzzzzzzzv_(Observation.ComponentComponent SBPComponent)
            {
                DataType ozzzzzzzzzzzzzzzzzzzzze_ = SBPComponent?.Value;
                object ozzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzze_);

                return ozzzzzzzzzzzzzzzzzzzzzf_ as CqlQuantity;
            };
            IEnumerable<CqlQuantity> nzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Select<Observation.ComponentComponent, CqlQuantity>(nzzzzzzzzzzzzzzzzzzzzzu_, nzzzzzzzzzzzzzzzzzzzzzv_);
            IEnumerable<CqlQuantity> nzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Distinct<CqlQuantity>(nzzzzzzzzzzzzzzzzzzzzzw_);
            CqlQuantity nzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.SingletonFrom<CqlQuantity>(nzzzzzzzzzzzzzzzzzzzzzx_);

            return nzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<CqlQuantity> mzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Select<Observation, CqlQuantity>(mzzzzzzzzzzzzzzzzzzzzzs_, mzzzzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<CqlQuantity> mzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Distinct<CqlQuantity>(mzzzzzzzzzzzzzzzzzzzzzu_);
        IEnumerable<CqlQuantity> mzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.ListSort<CqlQuantity>(mzzzzzzzzzzzzzzzzzzzzzv_, System.ComponentModel.ListSortDirection.Ascending);
        CqlQuantity mzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.First<CqlQuantity>(mzzzzzzzzzzzzzzzzzzzzzw_);

        return mzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Encounter with First White Blood Cells Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)?> Encounter_with_First_White_Blood_Cells_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzg_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)? ozzzzzzzzzzzzzzzzzzzzzh_(Encounter EncounterInpatient)
        {
            Id ozzzzzzzzzzzzzzzzzzzzzk_ = EncounterInpatient?.IdElement;
            string ozzzzzzzzzzzzzzzzzzzzzl_ = ozzzzzzzzzzzzzzzzzzzzzk_?.Value;
            CqlValueSet ozzzzzzzzzzzzzzzzzzzzzm_ = this.White_blood_cells_count_lab_test(context);
            IEnumerable<Observation> ozzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? ozzzzzzzzzzzzzzzzzzzzzo_(Observation WhiteBloodCellLab)
            {
                Instant pzzzzzzzzzzzzzzzzzzzzzg_ = WhiteBloodCellLab?.IssuedElement;
                DateTimeOffset? pzzzzzzzzzzzzzzzzzzzzzh_ = pzzzzzzzzzzzzzzzzzzzzzg_?.Value;
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Convert<CqlDateTime>(pzzzzzzzzzzzzzzzzzzzzzh_);
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.earliest(context, pzzzzzzzzzzzzzzzzzzzzzi_ as object);
                Period pzzzzzzzzzzzzzzzzzzzzzk_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzzzzzzzzzzzzzzzk_);
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(pzzzzzzzzzzzzzzzzzzzzzl_);
                CqlQuantity pzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Subtract(pzzzzzzzzzzzzzzzzzzzzzm_, pzzzzzzzzzzzzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzzzzzzzzzzzzzzzk_);
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Start(pzzzzzzzzzzzzzzzzzzzzzq_);
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Add(pzzzzzzzzzzzzzzzzzzzzzr_, pzzzzzzzzzzzzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Interval(pzzzzzzzzzzzzzzzzzzzzzo_, pzzzzzzzzzzzzzzzzzzzzzt_, true, true);
                bool? pzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.In<CqlDateTime>(pzzzzzzzzzzzzzzzzzzzzzj_, pzzzzzzzzzzzzzzzzzzzzzu_, default);
                Code<ObservationStatus> pzzzzzzzzzzzzzzzzzzzzzw_ = WhiteBloodCellLab?.StatusElement;
                ObservationStatus? pzzzzzzzzzzzzzzzzzzzzzx_ = pzzzzzzzzzzzzzzzzzzzzzw_?.Value;
                string pzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<string>(pzzzzzzzzzzzzzzzzzzzzzx_);
                string[] pzzzzzzzzzzzzzzzzzzzzzz_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? qzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<string>(pzzzzzzzzzzzzzzzzzzzzzy_, pzzzzzzzzzzzzzzzzzzzzzz_ as IEnumerable<string>);
                bool? qzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzv_, qzzzzzzzzzzzzzzzzzzzzza_);
                DataType qzzzzzzzzzzzzzzzzzzzzzc_ = WhiteBloodCellLab?.Value;
                object qzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzc_);
                bool? qzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Not((bool?)(qzzzzzzzzzzzzzzzzzzzzzd_ is null));
                bool? qzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzb_, qzzzzzzzzzzzzzzzzzzzzze_);

                return qzzzzzzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<Observation> ozzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Observation>(ozzzzzzzzzzzzzzzzzzzzzn_, ozzzzzzzzzzzzzzzzzzzzzo_);
            object ozzzzzzzzzzzzzzzzzzzzzq_(Observation @this)
            {
                Instant qzzzzzzzzzzzzzzzzzzzzzg_ = @this?.IssuedElement;
                DateTimeOffset? qzzzzzzzzzzzzzzzzzzzzzh_ = qzzzzzzzzzzzzzzzzzzzzzg_?.Value;
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Convert<CqlDateTime>(qzzzzzzzzzzzzzzzzzzzzzh_);
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.earliest(context, qzzzzzzzzzzzzzzzzzzzzzi_ as object);

                return qzzzzzzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<Observation> ozzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.SortBy<Observation>(ozzzzzzzzzzzzzzzzzzzzzp_, ozzzzzzzzzzzzzzzzzzzzzq_, System.ComponentModel.ListSortDirection.Ascending);
            Observation ozzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.First<Observation>(ozzzzzzzzzzzzzzzzzzzzzr_);
            DataType ozzzzzzzzzzzzzzzzzzzzzt_ = ozzzzzzzzzzzzzzzzzzzzzs_?.Value;
            object ozzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzt_);
            IEnumerable<Observation> ozzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? ozzzzzzzzzzzzzzzzzzzzzx_(Observation WhiteBloodCellLab)
            {
                Instant qzzzzzzzzzzzzzzzzzzzzzk_ = WhiteBloodCellLab?.IssuedElement;
                DateTimeOffset? qzzzzzzzzzzzzzzzzzzzzzl_ = qzzzzzzzzzzzzzzzzzzzzzk_?.Value;
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Convert<CqlDateTime>(qzzzzzzzzzzzzzzzzzzzzzl_);
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.earliest(context, qzzzzzzzzzzzzzzzzzzzzzm_ as object);
                Period qzzzzzzzzzzzzzzzzzzzzzo_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzzzzzzzzzzo_);
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(qzzzzzzzzzzzzzzzzzzzzzp_);
                CqlQuantity qzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Subtract(qzzzzzzzzzzzzzzzzzzzzzq_, qzzzzzzzzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzzzzzzzzzzo_);
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Start(qzzzzzzzzzzzzzzzzzzzzzu_);
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Add(qzzzzzzzzzzzzzzzzzzzzzv_, qzzzzzzzzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Interval(qzzzzzzzzzzzzzzzzzzzzzs_, qzzzzzzzzzzzzzzzzzzzzzx_, true, true);
                bool? qzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<CqlDateTime>(qzzzzzzzzzzzzzzzzzzzzzn_, qzzzzzzzzzzzzzzzzzzzzzy_, default);
                Code<ObservationStatus> rzzzzzzzzzzzzzzzzzzzzza_ = WhiteBloodCellLab?.StatusElement;
                ObservationStatus? rzzzzzzzzzzzzzzzzzzzzzb_ = rzzzzzzzzzzzzzzzzzzzzza_?.Value;
                string rzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<string>(rzzzzzzzzzzzzzzzzzzzzzb_);
                string[] rzzzzzzzzzzzzzzzzzzzzzd_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? rzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.In<string>(rzzzzzzzzzzzzzzzzzzzzzc_, rzzzzzzzzzzzzzzzzzzzzzd_ as IEnumerable<string>);
                bool? rzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzz_, rzzzzzzzzzzzzzzzzzzzzze_);
                DataType rzzzzzzzzzzzzzzzzzzzzzg_ = WhiteBloodCellLab?.Value;
                object rzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzg_);
                bool? rzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Not((bool?)(rzzzzzzzzzzzzzzzzzzzzzh_ is null));
                bool? rzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzzf_, rzzzzzzzzzzzzzzzzzzzzzi_);

                return rzzzzzzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<Observation> ozzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Observation>(ozzzzzzzzzzzzzzzzzzzzzw_, ozzzzzzzzzzzzzzzzzzzzzx_);
            object ozzzzzzzzzzzzzzzzzzzzzz_(Observation @this)
            {
                Instant rzzzzzzzzzzzzzzzzzzzzzk_ = @this?.IssuedElement;
                DateTimeOffset? rzzzzzzzzzzzzzzzzzzzzzl_ = rzzzzzzzzzzzzzzzzzzzzzk_?.Value;
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Convert<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzzzl_);
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.earliest(context, rzzzzzzzzzzzzzzzzzzzzzm_ as object);

                return rzzzzzzzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.SortBy<Observation>(ozzzzzzzzzzzzzzzzzzzzzy_, ozzzzzzzzzzzzzzzzzzzzzz_, System.ComponentModel.ListSortDirection.Ascending);
            Observation pzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.First<Observation>(pzzzzzzzzzzzzzzzzzzzzza_);
            Instant pzzzzzzzzzzzzzzzzzzzzzc_ = pzzzzzzzzzzzzzzzzzzzzzb_?.IssuedElement;
            DateTimeOffset? pzzzzzzzzzzzzzzzzzzzzzd_ = pzzzzzzzzzzzzzzzzzzzzzc_?.Value;
            CqlDateTime pzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Convert<CqlDateTime>(pzzzzzzzzzzzzzzzzzzzzzd_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)? pzzzzzzzzzzzzzzzzzzzzzf_ = (CqlTupleMetadata_ChVYCdXDGgVcFTCCUefXMbCHX, ozzzzzzzzzzzzzzzzzzzzzl_, ozzzzzzzzzzzzzzzzzzzzzu_ as CqlQuantity, pzzzzzzzzzzzzzzzzzzzzze_);

            return pzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)?> ozzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)?>(ozzzzzzzzzzzzzzzzzzzzzg_, ozzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)?> ozzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)?>(ozzzzzzzzzzzzzzzzzzzzzi_);

        return ozzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? rzzzzzzzzzzzzzzzzzzzzzo_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return rzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> rzzzzzzzzzzzzzzzzzzzzzp_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return rzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? rzzzzzzzzzzzzzzzzzzzzzq_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return rzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode rzzzzzzzzzzzzzzzzzzzzzr_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return rzzzzzzzzzzzzzzzzzzzzzr_;
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
