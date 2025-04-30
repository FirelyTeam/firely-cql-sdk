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
[CqlLibrary("HybridHospitalWideReadmissionFHIR", "0.0.001")]
public partial class HybridHospitalWideReadmissionFHIR_0_0_001 : ILibrary, ISingleton<HybridHospitalWideReadmissionFHIR_0_0_001>
{
    private HybridHospitalWideReadmissionFHIR_0_0_001() {}

    public static HybridHospitalWideReadmissionFHIR_0_0_001 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "HybridHospitalWideReadmissionFHIR";
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

    [CqlValueSetDefinition("Glucose lab test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.134", valueSetVersion: null)]
    public CqlValueSet Glucose_lab_test(CqlContext _) => _Glucose_lab_test;
    private static readonly CqlValueSet _Glucose_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.134", null);

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

    [CqlValueSetDefinition("Potassium lab test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.117", valueSetVersion: null)]
    public CqlValueSet Potassium_lab_test(CqlContext _) => _Potassium_lab_test;
    private static readonly CqlValueSet _Potassium_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.117", null);

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
        CqlDateTime yzzzzzzzzzzzzzzzzzc_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime yzzzzzzzzzzzzzzzzzd_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzze_ = context.Operators.Interval(yzzzzzzzzzzzzzzzzzc_, yzzzzzzzzzzzzzzzzzd_, true, true);
        object yzzzzzzzzzzzzzzzzzf_ = context.ResolveParameter("HybridHospitalWideReadmissionFHIR-0.0.001", "Measurement Period", yzzzzzzzzzzzzzzzzze_);

        return (CqlInterval<CqlDateTime>)yzzzzzzzzzzzzzzzzzf_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> yzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient yzzzzzzzzzzzzzzzzzh_ = context.Operators.SingletonFrom<Patient>(yzzzzzzzzzzzzzzzzzg_);

        return yzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Inpatient Encounters")]
    public IEnumerable<Encounter> Inpatient_Encounters(CqlContext context)
    {
        CqlValueSet yzzzzzzzzzzzzzzzzzi_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzk_(Encounter InpatientEncounter)
        {
            CqlValueSet yzzzzzzzzzzzzzzzzzm_ = this.Medicare_FFS_payer(context);
            IEnumerable<Coverage> yzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Coverage>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-coverage"));
            CqlValueSet yzzzzzzzzzzzzzzzzzo_ = this.Medicare_Advantage_payer(context);
            IEnumerable<Coverage> yzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Coverage>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-coverage"));
            IEnumerable<Coverage> yzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<Coverage>(yzzzzzzzzzzzzzzzzzn_, yzzzzzzzzzzzzzzzzzp_);
            bool? yzzzzzzzzzzzzzzzzzr_(Coverage MedicarePayer)
            {
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzv_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, InpatientEncounter);
                int? yzzzzzzzzzzzzzzzzzw_ = CQMCommon_2_2_000.Instance.lengthInDays(context, yzzzzzzzzzzzzzzzzzv_);
                bool? yzzzzzzzzzzzzzzzzzx_ = context.Operators.Less(yzzzzzzzzzzzzzzzzzw_, 365);
                Code<Encounter.EncounterStatus> yzzzzzzzzzzzzzzzzzy_ = InpatientEncounter?.StatusElement;
                Encounter.EncounterStatus? yzzzzzzzzzzzzzzzzzz_ = yzzzzzzzzzzzzzzzzzy_?.Value;
                Code<Encounter.EncounterStatus> zzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(yzzzzzzzzzzzzzzzzzz_);
                bool? zzzzzzzzzzzzzzzzzzb_ = context.Operators.Equal(zzzzzzzzzzzzzzzzzza_, "finished");
                bool? zzzzzzzzzzzzzzzzzzc_ = context.Operators.And(yzzzzzzzzzzzzzzzzzx_, zzzzzzzzzzzzzzzzzzb_);
                Patient zzzzzzzzzzzzzzzzzzd_ = this.Patient(context);
                Date zzzzzzzzzzzzzzzzzze_ = zzzzzzzzzzzzzzzzzzd_?.BirthDateElement;
                string zzzzzzzzzzzzzzzzzzf_ = zzzzzzzzzzzzzzzzzze_?.Value;
                CqlDate zzzzzzzzzzzzzzzzzzg_ = context.Operators.ConvertStringToDate(zzzzzzzzzzzzzzzzzzf_);
                Period zzzzzzzzzzzzzzzzzzh_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzzzzzzh_);
                CqlDateTime zzzzzzzzzzzzzzzzzzj_ = context.Operators.Start(zzzzzzzzzzzzzzzzzzi_);
                CqlDate zzzzzzzzzzzzzzzzzzk_ = context.Operators.DateFrom(zzzzzzzzzzzzzzzzzzj_);
                int? zzzzzzzzzzzzzzzzzzl_ = context.Operators.CalculateAgeAt(zzzzzzzzzzzzzzzzzzg_, zzzzzzzzzzzzzzzzzzk_, "year");
                bool? zzzzzzzzzzzzzzzzzzm_ = context.Operators.GreaterOrEqual(zzzzzzzzzzzzzzzzzzl_, 65);
                bool? zzzzzzzzzzzzzzzzzzn_ = context.Operators.And(zzzzzzzzzzzzzzzzzzc_, zzzzzzzzzzzzzzzzzzm_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzzzzzzh_);
                CqlDateTime zzzzzzzzzzzzzzzzzzq_ = context.Operators.End(zzzzzzzzzzzzzzzzzzp_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzr_ = this.Measurement_Period(context);
                bool? zzzzzzzzzzzzzzzzzzs_ = context.Operators.In<CqlDateTime>(zzzzzzzzzzzzzzzzzzq_, zzzzzzzzzzzzzzzzzzr_, "day");
                bool? zzzzzzzzzzzzzzzzzzt_ = context.Operators.And(zzzzzzzzzzzzzzzzzzn_, zzzzzzzzzzzzzzzzzzs_);

                return zzzzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<Coverage> yzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Coverage>(yzzzzzzzzzzzzzzzzzq_, yzzzzzzzzzzzzzzzzzr_);
            Encounter yzzzzzzzzzzzzzzzzzt_(Coverage MedicarePayer) =>
                InpatientEncounter;
            IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzu_ = context.Operators.Select<Coverage, Encounter>(yzzzzzzzzzzzzzzzzzs_, yzzzzzzzzzzzzzzzzzt_);

            return yzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzl_ = context.Operators.SelectMany<Encounter, Encounter>(yzzzzzzzzzzzzzzzzzj_, yzzzzzzzzzzzzzzzzzk_);

        return yzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzu_ = this.Inpatient_Encounters(context);

        return zzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Encounter with First Body Temperature")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)?> Encounter_with_First_Body_Temperature(CqlContext context)
    {
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzv_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)? zzzzzzzzzzzzzzzzzzw_(Encounter EncounterInpatient)
        {
            Id zzzzzzzzzzzzzzzzzzz_ = EncounterInpatient?.IdElement;
            string azzzzzzzzzzzzzzzzzza_ = zzzzzzzzzzzzzzzzzzz_?.Value;
            IEnumerable<Observation> azzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bodytemp"));
            bool? azzzzzzzzzzzzzzzzzzc_(Observation temperature)
            {
                DataType azzzzzzzzzzzzzzzzzzt_ = temperature?.Effective;
                object azzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzt_);
                CqlDateTime azzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.earliest(context, azzzzzzzzzzzzzzzzzzu_);
                Period azzzzzzzzzzzzzzzzzzw_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzzzzw_);
                CqlDateTime azzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(azzzzzzzzzzzzzzzzzzx_);
                CqlQuantity azzzzzzzzzzzzzzzzzzz_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime bzzzzzzzzzzzzzzzzzza_ = context.Operators.Subtract(azzzzzzzzzzzzzzzzzzy_, azzzzzzzzzzzzzzzzzzz_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzzzzw_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzc_);
                CqlQuantity bzzzzzzzzzzzzzzzzzze_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime bzzzzzzzzzzzzzzzzzzf_ = context.Operators.Add(bzzzzzzzzzzzzzzzzzzd_, bzzzzzzzzzzzzzzzzzze_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzg_ = context.Operators.Interval(bzzzzzzzzzzzzzzzzzza_, bzzzzzzzzzzzzzzzzzzf_, true, true);
                bool? bzzzzzzzzzzzzzzzzzzh_ = context.Operators.In<CqlDateTime>(azzzzzzzzzzzzzzzzzzv_, bzzzzzzzzzzzzzzzzzzg_, default);
                Code<ObservationStatus> bzzzzzzzzzzzzzzzzzzi_ = temperature?.StatusElement;
                ObservationStatus? bzzzzzzzzzzzzzzzzzzj_ = bzzzzzzzzzzzzzzzzzzi_?.Value;
                string bzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<string>(bzzzzzzzzzzzzzzzzzzj_);
                string[] bzzzzzzzzzzzzzzzzzzl_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? bzzzzzzzzzzzzzzzzzzm_ = context.Operators.In<string>(bzzzzzzzzzzzzzzzzzzk_, bzzzzzzzzzzzzzzzzzzl_ as IEnumerable<string>);
                bool? bzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzh_, bzzzzzzzzzzzzzzzzzzm_);
                DataType bzzzzzzzzzzzzzzzzzzo_ = temperature?.Value;
                CqlQuantity bzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, bzzzzzzzzzzzzzzzzzzo_ as Quantity);
                bool? bzzzzzzzzzzzzzzzzzzq_ = context.Operators.Not((bool?)(bzzzzzzzzzzzzzzzzzzp_ is null));
                bool? bzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzn_, bzzzzzzzzzzzzzzzzzzq_);

                return bzzzzzzzzzzzzzzzzzzr_;
            };
            IEnumerable<Observation> azzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Observation>(azzzzzzzzzzzzzzzzzzb_, azzzzzzzzzzzzzzzzzzc_);
            object azzzzzzzzzzzzzzzzzze_(Observation @this)
            {
                DataType bzzzzzzzzzzzzzzzzzzs_ = @this?.Effective;
                object bzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzs_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.earliest(context, bzzzzzzzzzzzzzzzzzzt_);

                return bzzzzzzzzzzzzzzzzzzu_;
            };
            IEnumerable<Observation> azzzzzzzzzzzzzzzzzzf_ = context.Operators.SortBy<Observation>(azzzzzzzzzzzzzzzzzzd_, azzzzzzzzzzzzzzzzzze_, System.ComponentModel.ListSortDirection.Ascending);
            Observation azzzzzzzzzzzzzzzzzzg_ = context.Operators.First<Observation>(azzzzzzzzzzzzzzzzzzf_);
            DataType azzzzzzzzzzzzzzzzzzh_ = azzzzzzzzzzzzzzzzzzg_?.Value;
            CqlQuantity azzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, azzzzzzzzzzzzzzzzzzh_ as Quantity);
            bool? azzzzzzzzzzzzzzzzzzk_(Observation temperature)
            {
                DataType bzzzzzzzzzzzzzzzzzzv_ = temperature?.Effective;
                object bzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzv_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.earliest(context, bzzzzzzzzzzzzzzzzzzw_);
                Period bzzzzzzzzzzzzzzzzzzy_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzzzy_);
                CqlDateTime czzzzzzzzzzzzzzzzzza_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzz_);
                CqlQuantity czzzzzzzzzzzzzzzzzzb_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime czzzzzzzzzzzzzzzzzzc_ = context.Operators.Subtract(czzzzzzzzzzzzzzzzzza_, czzzzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzzzy_);
                CqlDateTime czzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(czzzzzzzzzzzzzzzzzze_);
                CqlQuantity czzzzzzzzzzzzzzzzzzg_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime czzzzzzzzzzzzzzzzzzh_ = context.Operators.Add(czzzzzzzzzzzzzzzzzzf_, czzzzzzzzzzzzzzzzzzg_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzi_ = context.Operators.Interval(czzzzzzzzzzzzzzzzzzc_, czzzzzzzzzzzzzzzzzzh_, true, true);
                bool? czzzzzzzzzzzzzzzzzzj_ = context.Operators.In<CqlDateTime>(bzzzzzzzzzzzzzzzzzzx_, czzzzzzzzzzzzzzzzzzi_, default);
                Code<ObservationStatus> czzzzzzzzzzzzzzzzzzk_ = temperature?.StatusElement;
                ObservationStatus? czzzzzzzzzzzzzzzzzzl_ = czzzzzzzzzzzzzzzzzzk_?.Value;
                string czzzzzzzzzzzzzzzzzzm_ = context.Operators.Convert<string>(czzzzzzzzzzzzzzzzzzl_);
                string[] czzzzzzzzzzzzzzzzzzn_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? czzzzzzzzzzzzzzzzzzo_ = context.Operators.In<string>(czzzzzzzzzzzzzzzzzzm_, czzzzzzzzzzzzzzzzzzn_ as IEnumerable<string>);
                bool? czzzzzzzzzzzzzzzzzzp_ = context.Operators.And(czzzzzzzzzzzzzzzzzzj_, czzzzzzzzzzzzzzzzzzo_);
                DataType czzzzzzzzzzzzzzzzzzq_ = temperature?.Value;
                CqlQuantity czzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, czzzzzzzzzzzzzzzzzzq_ as Quantity);
                bool? czzzzzzzzzzzzzzzzzzs_ = context.Operators.Not((bool?)(czzzzzzzzzzzzzzzzzzr_ is null));
                bool? czzzzzzzzzzzzzzzzzzt_ = context.Operators.And(czzzzzzzzzzzzzzzzzzp_, czzzzzzzzzzzzzzzzzzs_);

                return czzzzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<Observation> azzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Observation>(azzzzzzzzzzzzzzzzzzb_, azzzzzzzzzzzzzzzzzzk_);
            object azzzzzzzzzzzzzzzzzzm_(Observation @this)
            {
                DataType czzzzzzzzzzzzzzzzzzu_ = @this?.Effective;
                object czzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzu_);
                CqlDateTime czzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.earliest(context, czzzzzzzzzzzzzzzzzzv_);

                return czzzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<Observation> azzzzzzzzzzzzzzzzzzn_ = context.Operators.SortBy<Observation>(azzzzzzzzzzzzzzzzzzl_, azzzzzzzzzzzzzzzzzzm_, System.ComponentModel.ListSortDirection.Ascending);
            Observation azzzzzzzzzzzzzzzzzzo_ = context.Operators.First<Observation>(azzzzzzzzzzzzzzzzzzn_);
            DataType azzzzzzzzzzzzzzzzzzp_ = azzzzzzzzzzzzzzzzzzo_?.Effective;
            object azzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzp_);
            CqlDateTime azzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.earliest(context, azzzzzzzzzzzzzzzzzzq_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)? azzzzzzzzzzzzzzzzzzs_ = (CqlTupleMetadata_GIbILVAdXLLNYBgcQIEiUiKaK, azzzzzzzzzzzzzzzzzza_, azzzzzzzzzzzzzzzzzzi_ as CqlQuantity, azzzzzzzzzzzzzzzzzzr_);

            return azzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)?> zzzzzzzzzzzzzzzzzzx_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)?>(zzzzzzzzzzzzzzzzzzv_, zzzzzzzzzzzzzzzzzzw_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)?> zzzzzzzzzzzzzzzzzzy_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)?>(zzzzzzzzzzzzzzzzzzx_);

        return zzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Encounter with First Heart Rate")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)?> Encounter_with_First_Heart_Rate(CqlContext context)
    {
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzx_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)? czzzzzzzzzzzzzzzzzzy_(Encounter EncounterInpatient)
        {
            Id dzzzzzzzzzzzzzzzzzzb_ = EncounterInpatient?.IdElement;
            string dzzzzzzzzzzzzzzzzzzc_ = dzzzzzzzzzzzzzzzzzzb_?.Value;
            IEnumerable<Observation> dzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/heartrate"));
            bool? dzzzzzzzzzzzzzzzzzze_(Observation HeartRate)
            {
                DataType dzzzzzzzzzzzzzzzzzzv_ = HeartRate?.Effective;
                object dzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzv_);
                CqlDateTime dzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.earliest(context, dzzzzzzzzzzzzzzzzzzw_);
                Period dzzzzzzzzzzzzzzzzzzy_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzzzzzzzzzzzy_);
                CqlDateTime ezzzzzzzzzzzzzzzzzza_ = context.Operators.Start(dzzzzzzzzzzzzzzzzzzz_);
                CqlQuantity ezzzzzzzzzzzzzzzzzzb_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime ezzzzzzzzzzzzzzzzzzc_ = context.Operators.Subtract(ezzzzzzzzzzzzzzzzzza_, ezzzzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzzzzzzzzzzzy_);
                CqlDateTime ezzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzze_);
                CqlQuantity ezzzzzzzzzzzzzzzzzzg_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime ezzzzzzzzzzzzzzzzzzh_ = context.Operators.Add(ezzzzzzzzzzzzzzzzzzf_, ezzzzzzzzzzzzzzzzzzg_);
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzi_ = context.Operators.Interval(ezzzzzzzzzzzzzzzzzzc_, ezzzzzzzzzzzzzzzzzzh_, true, true);
                bool? ezzzzzzzzzzzzzzzzzzj_ = context.Operators.In<CqlDateTime>(dzzzzzzzzzzzzzzzzzzx_, ezzzzzzzzzzzzzzzzzzi_, default);
                Code<ObservationStatus> ezzzzzzzzzzzzzzzzzzk_ = HeartRate?.StatusElement;
                ObservationStatus? ezzzzzzzzzzzzzzzzzzl_ = ezzzzzzzzzzzzzzzzzzk_?.Value;
                string ezzzzzzzzzzzzzzzzzzm_ = context.Operators.Convert<string>(ezzzzzzzzzzzzzzzzzzl_);
                string[] ezzzzzzzzzzzzzzzzzzn_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ezzzzzzzzzzzzzzzzzzo_ = context.Operators.In<string>(ezzzzzzzzzzzzzzzzzzm_, ezzzzzzzzzzzzzzzzzzn_ as IEnumerable<string>);
                bool? ezzzzzzzzzzzzzzzzzzp_ = context.Operators.And(ezzzzzzzzzzzzzzzzzzj_, ezzzzzzzzzzzzzzzzzzo_);
                DataType ezzzzzzzzzzzzzzzzzzq_ = HeartRate?.Value;
                CqlQuantity ezzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, ezzzzzzzzzzzzzzzzzzq_ as Quantity);
                bool? ezzzzzzzzzzzzzzzzzzs_ = context.Operators.Not((bool?)(ezzzzzzzzzzzzzzzzzzr_ is null));
                bool? ezzzzzzzzzzzzzzzzzzt_ = context.Operators.And(ezzzzzzzzzzzzzzzzzzp_, ezzzzzzzzzzzzzzzzzzs_);

                return ezzzzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<Observation> dzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Observation>(dzzzzzzzzzzzzzzzzzzd_, dzzzzzzzzzzzzzzzzzze_);
            object dzzzzzzzzzzzzzzzzzzg_(Observation @this)
            {
                DataType ezzzzzzzzzzzzzzzzzzu_ = @this?.Effective;
                object ezzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzu_);
                CqlDateTime ezzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.earliest(context, ezzzzzzzzzzzzzzzzzzv_);

                return ezzzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<Observation> dzzzzzzzzzzzzzzzzzzh_ = context.Operators.SortBy<Observation>(dzzzzzzzzzzzzzzzzzzf_, dzzzzzzzzzzzzzzzzzzg_, System.ComponentModel.ListSortDirection.Ascending);
            Observation dzzzzzzzzzzzzzzzzzzi_ = context.Operators.First<Observation>(dzzzzzzzzzzzzzzzzzzh_);
            DataType dzzzzzzzzzzzzzzzzzzj_ = dzzzzzzzzzzzzzzzzzzi_?.Value;
            CqlQuantity dzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, dzzzzzzzzzzzzzzzzzzj_ as Quantity);
            bool? dzzzzzzzzzzzzzzzzzzm_(Observation HeartRate)
            {
                DataType ezzzzzzzzzzzzzzzzzzx_ = HeartRate?.Effective;
                object ezzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzx_);
                CqlDateTime ezzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.earliest(context, ezzzzzzzzzzzzzzzzzzy_);
                Period fzzzzzzzzzzzzzzzzzza_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzzzzzzzzzza_);
                CqlDateTime fzzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(fzzzzzzzzzzzzzzzzzzb_);
                CqlQuantity fzzzzzzzzzzzzzzzzzzd_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime fzzzzzzzzzzzzzzzzzze_ = context.Operators.Subtract(fzzzzzzzzzzzzzzzzzzc_, fzzzzzzzzzzzzzzzzzzd_);
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzzzzzzzzzza_);
                CqlDateTime fzzzzzzzzzzzzzzzzzzh_ = context.Operators.Start(fzzzzzzzzzzzzzzzzzzg_);
                CqlQuantity fzzzzzzzzzzzzzzzzzzi_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime fzzzzzzzzzzzzzzzzzzj_ = context.Operators.Add(fzzzzzzzzzzzzzzzzzzh_, fzzzzzzzzzzzzzzzzzzi_);
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzk_ = context.Operators.Interval(fzzzzzzzzzzzzzzzzzze_, fzzzzzzzzzzzzzzzzzzj_, true, true);
                bool? fzzzzzzzzzzzzzzzzzzl_ = context.Operators.In<CqlDateTime>(ezzzzzzzzzzzzzzzzzzz_, fzzzzzzzzzzzzzzzzzzk_, default);
                Code<ObservationStatus> fzzzzzzzzzzzzzzzzzzm_ = HeartRate?.StatusElement;
                ObservationStatus? fzzzzzzzzzzzzzzzzzzn_ = fzzzzzzzzzzzzzzzzzzm_?.Value;
                string fzzzzzzzzzzzzzzzzzzo_ = context.Operators.Convert<string>(fzzzzzzzzzzzzzzzzzzn_);
                string[] fzzzzzzzzzzzzzzzzzzp_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? fzzzzzzzzzzzzzzzzzzq_ = context.Operators.In<string>(fzzzzzzzzzzzzzzzzzzo_, fzzzzzzzzzzzzzzzzzzp_ as IEnumerable<string>);
                bool? fzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzl_, fzzzzzzzzzzzzzzzzzzq_);
                DataType fzzzzzzzzzzzzzzzzzzs_ = HeartRate?.Value;
                CqlQuantity fzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, fzzzzzzzzzzzzzzzzzzs_ as Quantity);
                bool? fzzzzzzzzzzzzzzzzzzu_ = context.Operators.Not((bool?)(fzzzzzzzzzzzzzzzzzzt_ is null));
                bool? fzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzr_, fzzzzzzzzzzzzzzzzzzu_);

                return fzzzzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<Observation> dzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Observation>(dzzzzzzzzzzzzzzzzzzd_, dzzzzzzzzzzzzzzzzzzm_);
            object dzzzzzzzzzzzzzzzzzzo_(Observation @this)
            {
                DataType fzzzzzzzzzzzzzzzzzzw_ = @this?.Effective;
                object fzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzw_);
                CqlDateTime fzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.earliest(context, fzzzzzzzzzzzzzzzzzzx_);

                return fzzzzzzzzzzzzzzzzzzy_;
            };
            IEnumerable<Observation> dzzzzzzzzzzzzzzzzzzp_ = context.Operators.SortBy<Observation>(dzzzzzzzzzzzzzzzzzzn_, dzzzzzzzzzzzzzzzzzzo_, System.ComponentModel.ListSortDirection.Ascending);
            Observation dzzzzzzzzzzzzzzzzzzq_ = context.Operators.First<Observation>(dzzzzzzzzzzzzzzzzzzp_);
            DataType dzzzzzzzzzzzzzzzzzzr_ = dzzzzzzzzzzzzzzzzzzq_?.Effective;
            object dzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzr_);
            CqlDateTime dzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.earliest(context, dzzzzzzzzzzzzzzzzzzs_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)? dzzzzzzzzzzzzzzzzzzu_ = (CqlTupleMetadata_DhbJAfCiKIAGYKTjJXYGSKECQ, dzzzzzzzzzzzzzzzzzzc_, dzzzzzzzzzzzzzzzzzzk_ as CqlQuantity, dzzzzzzzzzzzzzzzzzzt_);

            return dzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)?> czzzzzzzzzzzzzzzzzzz_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)?>(czzzzzzzzzzzzzzzzzzx_, czzzzzzzzzzzzzzzzzzy_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)?> dzzzzzzzzzzzzzzzzzza_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)?>(czzzzzzzzzzzzzzzzzzz_);

        return dzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Encounter with First Oxygen Saturation")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)?> Encounter_with_First_Oxygen_Saturation(CqlContext context)
    {
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzz_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)? gzzzzzzzzzzzzzzzzzza_(Encounter EncounterInpatient)
        {
            Id gzzzzzzzzzzzzzzzzzzd_ = EncounterInpatient?.IdElement;
            string gzzzzzzzzzzzzzzzzzze_ = gzzzzzzzzzzzzzzzzzzd_?.Value;
            CqlValueSet gzzzzzzzzzzzzzzzzzzf_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
            IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            bool? gzzzzzzzzzzzzzzzzzzh_(Observation O2Saturation)
            {
                object gzzzzzzzzzzzzzzzzzzr_()
                {
                    bool hzzzzzzzzzzzzzzzzzzq_()
                    {
                        DataType hzzzzzzzzzzzzzzzzzzt_ = O2Saturation?.Effective;
                        object hzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzt_);
                        bool hzzzzzzzzzzzzzzzzzzv_ = hzzzzzzzzzzzzzzzzzzu_ is CqlDateTime;

                        return hzzzzzzzzzzzzzzzzzzv_;
                    };
                    bool hzzzzzzzzzzzzzzzzzzr_()
                    {
                        DataType hzzzzzzzzzzzzzzzzzzw_ = O2Saturation?.Effective;
                        object hzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzw_);
                        bool hzzzzzzzzzzzzzzzzzzy_ = hzzzzzzzzzzzzzzzzzzx_ is CqlInterval<CqlDateTime>;

                        return hzzzzzzzzzzzzzzzzzzy_;
                    };
                    bool hzzzzzzzzzzzzzzzzzzs_()
                    {
                        DataType hzzzzzzzzzzzzzzzzzzz_ = O2Saturation?.Effective;
                        object izzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzz_);
                        bool izzzzzzzzzzzzzzzzzzb_ = izzzzzzzzzzzzzzzzzza_ is CqlDateTime;

                        return izzzzzzzzzzzzzzzzzzb_;
                    };
                    if (hzzzzzzzzzzzzzzzzzzq_())
                    {
                        DataType izzzzzzzzzzzzzzzzzzc_ = O2Saturation?.Effective;
                        object izzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzc_);

                        return (izzzzzzzzzzzzzzzzzzd_ as CqlDateTime) as object;
                    }
                    else if (hzzzzzzzzzzzzzzzzzzr_())
                    {
                        DataType izzzzzzzzzzzzzzzzzze_ = O2Saturation?.Effective;
                        object izzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzze_);

                        return (izzzzzzzzzzzzzzzzzzf_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (hzzzzzzzzzzzzzzzzzzs_())
                    {
                        DataType izzzzzzzzzzzzzzzzzzg_ = O2Saturation?.Effective;
                        object izzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzg_);

                        return (izzzzzzzzzzzzzzzzzzh_ as CqlDateTime) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlDateTime gzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.earliest(context, gzzzzzzzzzzzzzzzzzzr_());
                Period gzzzzzzzzzzzzzzzzzzt_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzzzzzzzzzzt_);
                CqlDateTime gzzzzzzzzzzzzzzzzzzv_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzu_);
                CqlQuantity gzzzzzzzzzzzzzzzzzzw_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime gzzzzzzzzzzzzzzzzzzx_ = context.Operators.Subtract(gzzzzzzzzzzzzzzzzzzv_, gzzzzzzzzzzzzzzzzzzw_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzzzzzzzzzzt_);
                CqlDateTime hzzzzzzzzzzzzzzzzzza_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzz_);
                CqlQuantity hzzzzzzzzzzzzzzzzzzb_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime hzzzzzzzzzzzzzzzzzzc_ = context.Operators.Add(hzzzzzzzzzzzzzzzzzza_, hzzzzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzd_ = context.Operators.Interval(gzzzzzzzzzzzzzzzzzzx_, hzzzzzzzzzzzzzzzzzzc_, true, true);
                bool? hzzzzzzzzzzzzzzzzzze_ = context.Operators.In<CqlDateTime>(gzzzzzzzzzzzzzzzzzzs_, hzzzzzzzzzzzzzzzzzzd_, default);
                Code<ObservationStatus> hzzzzzzzzzzzzzzzzzzf_ = O2Saturation?.StatusElement;
                ObservationStatus? hzzzzzzzzzzzzzzzzzzg_ = hzzzzzzzzzzzzzzzzzzf_?.Value;
                Code<ObservationStatus> hzzzzzzzzzzzzzzzzzzh_ = context.Operators.Convert<Code<ObservationStatus>>(hzzzzzzzzzzzzzzzzzzg_);
                string hzzzzzzzzzzzzzzzzzzi_ = context.Operators.Convert<string>(hzzzzzzzzzzzzzzzzzzh_);
                string[] hzzzzzzzzzzzzzzzzzzj_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? hzzzzzzzzzzzzzzzzzzk_ = context.Operators.In<string>(hzzzzzzzzzzzzzzzzzzi_, hzzzzzzzzzzzzzzzzzzj_ as IEnumerable<string>);
                bool? hzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(hzzzzzzzzzzzzzzzzzze_, hzzzzzzzzzzzzzzzzzzk_);
                DataType hzzzzzzzzzzzzzzzzzzm_ = O2Saturation?.Value;
                object hzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzm_);
                bool? hzzzzzzzzzzzzzzzzzzo_ = context.Operators.Not((bool?)(hzzzzzzzzzzzzzzzzzzn_ is null));
                bool? hzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzl_, hzzzzzzzzzzzzzzzzzzo_);

                return hzzzzzzzzzzzzzzzzzzp_;
            };
            IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Observation>(gzzzzzzzzzzzzzzzzzzg_, gzzzzzzzzzzzzzzzzzzh_);
            object gzzzzzzzzzzzzzzzzzzj_(Observation @this)
            {
                object izzzzzzzzzzzzzzzzzzi_()
                {
                    bool izzzzzzzzzzzzzzzzzzk_()
                    {
                        DataType izzzzzzzzzzzzzzzzzzn_ = @this?.Effective;
                        object izzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzn_);
                        bool izzzzzzzzzzzzzzzzzzp_ = izzzzzzzzzzzzzzzzzzo_ is CqlDateTime;

                        return izzzzzzzzzzzzzzzzzzp_;
                    };
                    bool izzzzzzzzzzzzzzzzzzl_()
                    {
                        DataType izzzzzzzzzzzzzzzzzzq_ = @this?.Effective;
                        object izzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzq_);
                        bool izzzzzzzzzzzzzzzzzzs_ = izzzzzzzzzzzzzzzzzzr_ is CqlInterval<CqlDateTime>;

                        return izzzzzzzzzzzzzzzzzzs_;
                    };
                    bool izzzzzzzzzzzzzzzzzzm_()
                    {
                        DataType izzzzzzzzzzzzzzzzzzt_ = @this?.Effective;
                        object izzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzt_);
                        bool izzzzzzzzzzzzzzzzzzv_ = izzzzzzzzzzzzzzzzzzu_ is CqlDateTime;

                        return izzzzzzzzzzzzzzzzzzv_;
                    };
                    if (izzzzzzzzzzzzzzzzzzk_())
                    {
                        DataType izzzzzzzzzzzzzzzzzzw_ = @this?.Effective;
                        object izzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzw_);

                        return (izzzzzzzzzzzzzzzzzzx_ as CqlDateTime) as object;
                    }
                    else if (izzzzzzzzzzzzzzzzzzl_())
                    {
                        DataType izzzzzzzzzzzzzzzzzzy_ = @this?.Effective;
                        object izzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzy_);

                        return (izzzzzzzzzzzzzzzzzzz_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (izzzzzzzzzzzzzzzzzzm_())
                    {
                        DataType jzzzzzzzzzzzzzzzzzza_ = @this?.Effective;
                        object jzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzza_);

                        return (jzzzzzzzzzzzzzzzzzzb_ as CqlDateTime) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlDateTime izzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.earliest(context, izzzzzzzzzzzzzzzzzzi_());

                return izzzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzk_ = context.Operators.SortBy<Observation>(gzzzzzzzzzzzzzzzzzzi_, gzzzzzzzzzzzzzzzzzzj_, System.ComponentModel.ListSortDirection.Ascending);
            Observation gzzzzzzzzzzzzzzzzzzl_ = context.Operators.First<Observation>(gzzzzzzzzzzzzzzzzzzk_);
            DataType gzzzzzzzzzzzzzzzzzzm_ = gzzzzzzzzzzzzzzzzzzl_?.Value;
            object gzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzm_);
            object gzzzzzzzzzzzzzzzzzzo_()
            {
                bool jzzzzzzzzzzzzzzzzzzc_()
                {
                    CqlValueSet jzzzzzzzzzzzzzzzzzzf_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
                    IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? jzzzzzzzzzzzzzzzzzzh_(Observation O2Saturation)
                    {
                        object jzzzzzzzzzzzzzzzzzzp_()
                        {
                            bool kzzzzzzzzzzzzzzzzzzo_()
                            {
                                DataType kzzzzzzzzzzzzzzzzzzr_ = O2Saturation?.Effective;
                                object kzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzr_);
                                bool kzzzzzzzzzzzzzzzzzzt_ = kzzzzzzzzzzzzzzzzzzs_ is CqlDateTime;

                                return kzzzzzzzzzzzzzzzzzzt_;
                            };
                            bool kzzzzzzzzzzzzzzzzzzp_()
                            {
                                DataType kzzzzzzzzzzzzzzzzzzu_ = O2Saturation?.Effective;
                                object kzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzu_);
                                bool kzzzzzzzzzzzzzzzzzzw_ = kzzzzzzzzzzzzzzzzzzv_ is CqlInterval<CqlDateTime>;

                                return kzzzzzzzzzzzzzzzzzzw_;
                            };
                            bool kzzzzzzzzzzzzzzzzzzq_()
                            {
                                DataType kzzzzzzzzzzzzzzzzzzx_ = O2Saturation?.Effective;
                                object kzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzx_);
                                bool kzzzzzzzzzzzzzzzzzzz_ = kzzzzzzzzzzzzzzzzzzy_ is CqlDateTime;

                                return kzzzzzzzzzzzzzzzzzzz_;
                            };
                            if (kzzzzzzzzzzzzzzzzzzo_())
                            {
                                DataType lzzzzzzzzzzzzzzzzzza_ = O2Saturation?.Effective;
                                object lzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzza_);

                                return (lzzzzzzzzzzzzzzzzzzb_ as CqlDateTime) as object;
                            }
                            else if (kzzzzzzzzzzzzzzzzzzp_())
                            {
                                DataType lzzzzzzzzzzzzzzzzzzc_ = O2Saturation?.Effective;
                                object lzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzc_);

                                return (lzzzzzzzzzzzzzzzzzzd_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (kzzzzzzzzzzzzzzzzzzq_())
                            {
                                DataType lzzzzzzzzzzzzzzzzzze_ = O2Saturation?.Effective;
                                object lzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzze_);

                                return (lzzzzzzzzzzzzzzzzzzf_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime jzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.earliest(context, jzzzzzzzzzzzzzzzzzzp_());
                        Period jzzzzzzzzzzzzzzzzzzr_ = EncounterInpatient?.Period;
                        CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzzzr_);
                        CqlDateTime jzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(jzzzzzzzzzzzzzzzzzzs_);
                        CqlQuantity jzzzzzzzzzzzzzzzzzzu_ = context.Operators.Quantity(1440m, "minutes");
                        CqlDateTime jzzzzzzzzzzzzzzzzzzv_ = context.Operators.Subtract(jzzzzzzzzzzzzzzzzzzt_, jzzzzzzzzzzzzzzzzzzu_);
                        CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzzzr_);
                        CqlDateTime jzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(jzzzzzzzzzzzzzzzzzzx_);
                        CqlQuantity jzzzzzzzzzzzzzzzzzzz_ = context.Operators.Quantity(120m, "minutes");
                        CqlDateTime kzzzzzzzzzzzzzzzzzza_ = context.Operators.Add(jzzzzzzzzzzzzzzzzzzy_, jzzzzzzzzzzzzzzzzzzz_);
                        CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzb_ = context.Operators.Interval(jzzzzzzzzzzzzzzzzzzv_, kzzzzzzzzzzzzzzzzzza_, true, true);
                        bool? kzzzzzzzzzzzzzzzzzzc_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzzzzzzzzzzq_, kzzzzzzzzzzzzzzzzzzb_, default);
                        Code<ObservationStatus> kzzzzzzzzzzzzzzzzzzd_ = O2Saturation?.StatusElement;
                        ObservationStatus? kzzzzzzzzzzzzzzzzzze_ = kzzzzzzzzzzzzzzzzzzd_?.Value;
                        Code<ObservationStatus> kzzzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<Code<ObservationStatus>>(kzzzzzzzzzzzzzzzzzze_);
                        string kzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<string>(kzzzzzzzzzzzzzzzzzzf_);
                        string[] kzzzzzzzzzzzzzzzzzzh_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? kzzzzzzzzzzzzzzzzzzi_ = context.Operators.In<string>(kzzzzzzzzzzzzzzzzzzg_, kzzzzzzzzzzzzzzzzzzh_ as IEnumerable<string>);
                        bool? kzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzc_, kzzzzzzzzzzzzzzzzzzi_);
                        DataType kzzzzzzzzzzzzzzzzzzk_ = O2Saturation?.Value;
                        object kzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzk_);
                        bool? kzzzzzzzzzzzzzzzzzzm_ = context.Operators.Not((bool?)(kzzzzzzzzzzzzzzzzzzl_ is null));
                        bool? kzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzj_, kzzzzzzzzzzzzzzzzzzm_);

                        return kzzzzzzzzzzzzzzzzzzn_;
                    };
                    IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Observation>(jzzzzzzzzzzzzzzzzzzg_, jzzzzzzzzzzzzzzzzzzh_);
                    object jzzzzzzzzzzzzzzzzzzj_(Observation @this)
                    {
                        object lzzzzzzzzzzzzzzzzzzg_()
                        {
                            bool lzzzzzzzzzzzzzzzzzzi_()
                            {
                                DataType lzzzzzzzzzzzzzzzzzzl_ = @this?.Effective;
                                object lzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzl_);
                                bool lzzzzzzzzzzzzzzzzzzn_ = lzzzzzzzzzzzzzzzzzzm_ is CqlDateTime;

                                return lzzzzzzzzzzzzzzzzzzn_;
                            };
                            bool lzzzzzzzzzzzzzzzzzzj_()
                            {
                                DataType lzzzzzzzzzzzzzzzzzzo_ = @this?.Effective;
                                object lzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzo_);
                                bool lzzzzzzzzzzzzzzzzzzq_ = lzzzzzzzzzzzzzzzzzzp_ is CqlInterval<CqlDateTime>;

                                return lzzzzzzzzzzzzzzzzzzq_;
                            };
                            bool lzzzzzzzzzzzzzzzzzzk_()
                            {
                                DataType lzzzzzzzzzzzzzzzzzzr_ = @this?.Effective;
                                object lzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzr_);
                                bool lzzzzzzzzzzzzzzzzzzt_ = lzzzzzzzzzzzzzzzzzzs_ is CqlDateTime;

                                return lzzzzzzzzzzzzzzzzzzt_;
                            };
                            if (lzzzzzzzzzzzzzzzzzzi_())
                            {
                                DataType lzzzzzzzzzzzzzzzzzzu_ = @this?.Effective;
                                object lzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzu_);

                                return (lzzzzzzzzzzzzzzzzzzv_ as CqlDateTime) as object;
                            }
                            else if (lzzzzzzzzzzzzzzzzzzj_())
                            {
                                DataType lzzzzzzzzzzzzzzzzzzw_ = @this?.Effective;
                                object lzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzw_);

                                return (lzzzzzzzzzzzzzzzzzzx_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (lzzzzzzzzzzzzzzzzzzk_())
                            {
                                DataType lzzzzzzzzzzzzzzzzzzy_ = @this?.Effective;
                                object lzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzy_);

                                return (lzzzzzzzzzzzzzzzzzzz_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime lzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.earliest(context, lzzzzzzzzzzzzzzzzzzg_());

                        return lzzzzzzzzzzzzzzzzzzh_;
                    };
                    IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzk_ = context.Operators.SortBy<Observation>(jzzzzzzzzzzzzzzzzzzi_, jzzzzzzzzzzzzzzzzzzj_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation jzzzzzzzzzzzzzzzzzzl_ = context.Operators.First<Observation>(jzzzzzzzzzzzzzzzzzzk_);
                    DataType jzzzzzzzzzzzzzzzzzzm_ = jzzzzzzzzzzzzzzzzzzl_?.Effective;
                    object jzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzm_);
                    bool jzzzzzzzzzzzzzzzzzzo_ = jzzzzzzzzzzzzzzzzzzn_ is CqlDateTime;

                    return jzzzzzzzzzzzzzzzzzzo_;
                };
                bool jzzzzzzzzzzzzzzzzzzd_()
                {
                    CqlValueSet mzzzzzzzzzzzzzzzzzza_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
                    IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? mzzzzzzzzzzzzzzzzzzc_(Observation O2Saturation)
                    {
                        object mzzzzzzzzzzzzzzzzzzk_()
                        {
                            bool nzzzzzzzzzzzzzzzzzzj_()
                            {
                                DataType nzzzzzzzzzzzzzzzzzzm_ = O2Saturation?.Effective;
                                object nzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzm_);
                                bool nzzzzzzzzzzzzzzzzzzo_ = nzzzzzzzzzzzzzzzzzzn_ is CqlDateTime;

                                return nzzzzzzzzzzzzzzzzzzo_;
                            };
                            bool nzzzzzzzzzzzzzzzzzzk_()
                            {
                                DataType nzzzzzzzzzzzzzzzzzzp_ = O2Saturation?.Effective;
                                object nzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzp_);
                                bool nzzzzzzzzzzzzzzzzzzr_ = nzzzzzzzzzzzzzzzzzzq_ is CqlInterval<CqlDateTime>;

                                return nzzzzzzzzzzzzzzzzzzr_;
                            };
                            bool nzzzzzzzzzzzzzzzzzzl_()
                            {
                                DataType nzzzzzzzzzzzzzzzzzzs_ = O2Saturation?.Effective;
                                object nzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzs_);
                                bool nzzzzzzzzzzzzzzzzzzu_ = nzzzzzzzzzzzzzzzzzzt_ is CqlDateTime;

                                return nzzzzzzzzzzzzzzzzzzu_;
                            };
                            if (nzzzzzzzzzzzzzzzzzzj_())
                            {
                                DataType nzzzzzzzzzzzzzzzzzzv_ = O2Saturation?.Effective;
                                object nzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzv_);

                                return (nzzzzzzzzzzzzzzzzzzw_ as CqlDateTime) as object;
                            }
                            else if (nzzzzzzzzzzzzzzzzzzk_())
                            {
                                DataType nzzzzzzzzzzzzzzzzzzx_ = O2Saturation?.Effective;
                                object nzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzx_);

                                return (nzzzzzzzzzzzzzzzzzzy_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (nzzzzzzzzzzzzzzzzzzl_())
                            {
                                DataType nzzzzzzzzzzzzzzzzzzz_ = O2Saturation?.Effective;
                                object ozzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzz_);

                                return (ozzzzzzzzzzzzzzzzzza_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime mzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.earliest(context, mzzzzzzzzzzzzzzzzzzk_());
                        Period mzzzzzzzzzzzzzzzzzzm_ = EncounterInpatient?.Period;
                        CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzzzzzzzzzm_);
                        CqlDateTime mzzzzzzzzzzzzzzzzzzo_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzn_);
                        CqlQuantity mzzzzzzzzzzzzzzzzzzp_ = context.Operators.Quantity(1440m, "minutes");
                        CqlDateTime mzzzzzzzzzzzzzzzzzzq_ = context.Operators.Subtract(mzzzzzzzzzzzzzzzzzzo_, mzzzzzzzzzzzzzzzzzzp_);
                        CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzzzzzzzzzm_);
                        CqlDateTime mzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzs_);
                        CqlQuantity mzzzzzzzzzzzzzzzzzzu_ = context.Operators.Quantity(120m, "minutes");
                        CqlDateTime mzzzzzzzzzzzzzzzzzzv_ = context.Operators.Add(mzzzzzzzzzzzzzzzzzzt_, mzzzzzzzzzzzzzzzzzzu_);
                        CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzw_ = context.Operators.Interval(mzzzzzzzzzzzzzzzzzzq_, mzzzzzzzzzzzzzzzzzzv_, true, true);
                        bool? mzzzzzzzzzzzzzzzzzzx_ = context.Operators.In<CqlDateTime>(mzzzzzzzzzzzzzzzzzzl_, mzzzzzzzzzzzzzzzzzzw_, default);
                        Code<ObservationStatus> mzzzzzzzzzzzzzzzzzzy_ = O2Saturation?.StatusElement;
                        ObservationStatus? mzzzzzzzzzzzzzzzzzzz_ = mzzzzzzzzzzzzzzzzzzy_?.Value;
                        Code<ObservationStatus> nzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<Code<ObservationStatus>>(mzzzzzzzzzzzzzzzzzzz_);
                        string nzzzzzzzzzzzzzzzzzzb_ = context.Operators.Convert<string>(nzzzzzzzzzzzzzzzzzza_);
                        string[] nzzzzzzzzzzzzzzzzzzc_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? nzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<string>(nzzzzzzzzzzzzzzzzzzb_, nzzzzzzzzzzzzzzzzzzc_ as IEnumerable<string>);
                        bool? nzzzzzzzzzzzzzzzzzze_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzx_, nzzzzzzzzzzzzzzzzzzd_);
                        DataType nzzzzzzzzzzzzzzzzzzf_ = O2Saturation?.Value;
                        object nzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzf_);
                        bool? nzzzzzzzzzzzzzzzzzzh_ = context.Operators.Not((bool?)(nzzzzzzzzzzzzzzzzzzg_ is null));
                        bool? nzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(nzzzzzzzzzzzzzzzzzze_, nzzzzzzzzzzzzzzzzzzh_);

                        return nzzzzzzzzzzzzzzzzzzi_;
                    };
                    IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Observation>(mzzzzzzzzzzzzzzzzzzb_, mzzzzzzzzzzzzzzzzzzc_);
                    object mzzzzzzzzzzzzzzzzzze_(Observation @this)
                    {
                        object ozzzzzzzzzzzzzzzzzzb_()
                        {
                            bool ozzzzzzzzzzzzzzzzzzd_()
                            {
                                DataType ozzzzzzzzzzzzzzzzzzg_ = @this?.Effective;
                                object ozzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzg_);
                                bool ozzzzzzzzzzzzzzzzzzi_ = ozzzzzzzzzzzzzzzzzzh_ is CqlDateTime;

                                return ozzzzzzzzzzzzzzzzzzi_;
                            };
                            bool ozzzzzzzzzzzzzzzzzze_()
                            {
                                DataType ozzzzzzzzzzzzzzzzzzj_ = @this?.Effective;
                                object ozzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzj_);
                                bool ozzzzzzzzzzzzzzzzzzl_ = ozzzzzzzzzzzzzzzzzzk_ is CqlInterval<CqlDateTime>;

                                return ozzzzzzzzzzzzzzzzzzl_;
                            };
                            bool ozzzzzzzzzzzzzzzzzzf_()
                            {
                                DataType ozzzzzzzzzzzzzzzzzzm_ = @this?.Effective;
                                object ozzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzm_);
                                bool ozzzzzzzzzzzzzzzzzzo_ = ozzzzzzzzzzzzzzzzzzn_ is CqlDateTime;

                                return ozzzzzzzzzzzzzzzzzzo_;
                            };
                            if (ozzzzzzzzzzzzzzzzzzd_())
                            {
                                DataType ozzzzzzzzzzzzzzzzzzp_ = @this?.Effective;
                                object ozzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzp_);

                                return (ozzzzzzzzzzzzzzzzzzq_ as CqlDateTime) as object;
                            }
                            else if (ozzzzzzzzzzzzzzzzzze_())
                            {
                                DataType ozzzzzzzzzzzzzzzzzzr_ = @this?.Effective;
                                object ozzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzr_);

                                return (ozzzzzzzzzzzzzzzzzzs_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (ozzzzzzzzzzzzzzzzzzf_())
                            {
                                DataType ozzzzzzzzzzzzzzzzzzt_ = @this?.Effective;
                                object ozzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzt_);

                                return (ozzzzzzzzzzzzzzzzzzu_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime ozzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.earliest(context, ozzzzzzzzzzzzzzzzzzb_());

                        return ozzzzzzzzzzzzzzzzzzc_;
                    };
                    IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzf_ = context.Operators.SortBy<Observation>(mzzzzzzzzzzzzzzzzzzd_, mzzzzzzzzzzzzzzzzzze_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation mzzzzzzzzzzzzzzzzzzg_ = context.Operators.First<Observation>(mzzzzzzzzzzzzzzzzzzf_);
                    DataType mzzzzzzzzzzzzzzzzzzh_ = mzzzzzzzzzzzzzzzzzzg_?.Effective;
                    object mzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzh_);
                    bool mzzzzzzzzzzzzzzzzzzj_ = mzzzzzzzzzzzzzzzzzzi_ is CqlInterval<CqlDateTime>;

                    return mzzzzzzzzzzzzzzzzzzj_;
                };
                bool jzzzzzzzzzzzzzzzzzze_()
                {
                    CqlValueSet ozzzzzzzzzzzzzzzzzzv_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
                    IEnumerable<Observation> ozzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? ozzzzzzzzzzzzzzzzzzx_(Observation O2Saturation)
                    {
                        object pzzzzzzzzzzzzzzzzzzf_()
                        {
                            bool qzzzzzzzzzzzzzzzzzze_()
                            {
                                DataType qzzzzzzzzzzzzzzzzzzh_ = O2Saturation?.Effective;
                                object qzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzh_);
                                bool qzzzzzzzzzzzzzzzzzzj_ = qzzzzzzzzzzzzzzzzzzi_ is CqlDateTime;

                                return qzzzzzzzzzzzzzzzzzzj_;
                            };
                            bool qzzzzzzzzzzzzzzzzzzf_()
                            {
                                DataType qzzzzzzzzzzzzzzzzzzk_ = O2Saturation?.Effective;
                                object qzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzk_);
                                bool qzzzzzzzzzzzzzzzzzzm_ = qzzzzzzzzzzzzzzzzzzl_ is CqlInterval<CqlDateTime>;

                                return qzzzzzzzzzzzzzzzzzzm_;
                            };
                            bool qzzzzzzzzzzzzzzzzzzg_()
                            {
                                DataType qzzzzzzzzzzzzzzzzzzn_ = O2Saturation?.Effective;
                                object qzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzn_);
                                bool qzzzzzzzzzzzzzzzzzzp_ = qzzzzzzzzzzzzzzzzzzo_ is CqlDateTime;

                                return qzzzzzzzzzzzzzzzzzzp_;
                            };
                            if (qzzzzzzzzzzzzzzzzzze_())
                            {
                                DataType qzzzzzzzzzzzzzzzzzzq_ = O2Saturation?.Effective;
                                object qzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzq_);

                                return (qzzzzzzzzzzzzzzzzzzr_ as CqlDateTime) as object;
                            }
                            else if (qzzzzzzzzzzzzzzzzzzf_())
                            {
                                DataType qzzzzzzzzzzzzzzzzzzs_ = O2Saturation?.Effective;
                                object qzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzs_);

                                return (qzzzzzzzzzzzzzzzzzzt_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (qzzzzzzzzzzzzzzzzzzg_())
                            {
                                DataType qzzzzzzzzzzzzzzzzzzu_ = O2Saturation?.Effective;
                                object qzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzu_);

                                return (qzzzzzzzzzzzzzzzzzzv_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime pzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.earliest(context, pzzzzzzzzzzzzzzzzzzf_());
                        Period pzzzzzzzzzzzzzzzzzzh_ = EncounterInpatient?.Period;
                        CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzzzzzzzzzzzzh_);
                        CqlDateTime pzzzzzzzzzzzzzzzzzzj_ = context.Operators.Start(pzzzzzzzzzzzzzzzzzzi_);
                        CqlQuantity pzzzzzzzzzzzzzzzzzzk_ = context.Operators.Quantity(1440m, "minutes");
                        CqlDateTime pzzzzzzzzzzzzzzzzzzl_ = context.Operators.Subtract(pzzzzzzzzzzzzzzzzzzj_, pzzzzzzzzzzzzzzzzzzk_);
                        CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzzzzzzzzzzzzh_);
                        CqlDateTime pzzzzzzzzzzzzzzzzzzo_ = context.Operators.Start(pzzzzzzzzzzzzzzzzzzn_);
                        CqlQuantity pzzzzzzzzzzzzzzzzzzp_ = context.Operators.Quantity(120m, "minutes");
                        CqlDateTime pzzzzzzzzzzzzzzzzzzq_ = context.Operators.Add(pzzzzzzzzzzzzzzzzzzo_, pzzzzzzzzzzzzzzzzzzp_);
                        CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzr_ = context.Operators.Interval(pzzzzzzzzzzzzzzzzzzl_, pzzzzzzzzzzzzzzzzzzq_, true, true);
                        bool? pzzzzzzzzzzzzzzzzzzs_ = context.Operators.In<CqlDateTime>(pzzzzzzzzzzzzzzzzzzg_, pzzzzzzzzzzzzzzzzzzr_, default);
                        Code<ObservationStatus> pzzzzzzzzzzzzzzzzzzt_ = O2Saturation?.StatusElement;
                        ObservationStatus? pzzzzzzzzzzzzzzzzzzu_ = pzzzzzzzzzzzzzzzzzzt_?.Value;
                        Code<ObservationStatus> pzzzzzzzzzzzzzzzzzzv_ = context.Operators.Convert<Code<ObservationStatus>>(pzzzzzzzzzzzzzzzzzzu_);
                        string pzzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<string>(pzzzzzzzzzzzzzzzzzzv_);
                        string[] pzzzzzzzzzzzzzzzzzzx_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? pzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<string>(pzzzzzzzzzzzzzzzzzzw_, pzzzzzzzzzzzzzzzzzzx_ as IEnumerable<string>);
                        bool? pzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzs_, pzzzzzzzzzzzzzzzzzzy_);
                        DataType qzzzzzzzzzzzzzzzzzza_ = O2Saturation?.Value;
                        object qzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzza_);
                        bool? qzzzzzzzzzzzzzzzzzzc_ = context.Operators.Not((bool?)(qzzzzzzzzzzzzzzzzzzb_ is null));
                        bool? qzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzz_, qzzzzzzzzzzzzzzzzzzc_);

                        return qzzzzzzzzzzzzzzzzzzd_;
                    };
                    IEnumerable<Observation> ozzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Observation>(ozzzzzzzzzzzzzzzzzzw_, ozzzzzzzzzzzzzzzzzzx_);
                    object ozzzzzzzzzzzzzzzzzzz_(Observation @this)
                    {
                        object qzzzzzzzzzzzzzzzzzzw_()
                        {
                            bool qzzzzzzzzzzzzzzzzzzy_()
                            {
                                DataType rzzzzzzzzzzzzzzzzzzb_ = @this?.Effective;
                                object rzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzb_);
                                bool rzzzzzzzzzzzzzzzzzzd_ = rzzzzzzzzzzzzzzzzzzc_ is CqlDateTime;

                                return rzzzzzzzzzzzzzzzzzzd_;
                            };
                            bool qzzzzzzzzzzzzzzzzzzz_()
                            {
                                DataType rzzzzzzzzzzzzzzzzzze_ = @this?.Effective;
                                object rzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzze_);
                                bool rzzzzzzzzzzzzzzzzzzg_ = rzzzzzzzzzzzzzzzzzzf_ is CqlInterval<CqlDateTime>;

                                return rzzzzzzzzzzzzzzzzzzg_;
                            };
                            bool rzzzzzzzzzzzzzzzzzza_()
                            {
                                DataType rzzzzzzzzzzzzzzzzzzh_ = @this?.Effective;
                                object rzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzh_);
                                bool rzzzzzzzzzzzzzzzzzzj_ = rzzzzzzzzzzzzzzzzzzi_ is CqlDateTime;

                                return rzzzzzzzzzzzzzzzzzzj_;
                            };
                            if (qzzzzzzzzzzzzzzzzzzy_())
                            {
                                DataType rzzzzzzzzzzzzzzzzzzk_ = @this?.Effective;
                                object rzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzk_);

                                return (rzzzzzzzzzzzzzzzzzzl_ as CqlDateTime) as object;
                            }
                            else if (qzzzzzzzzzzzzzzzzzzz_())
                            {
                                DataType rzzzzzzzzzzzzzzzzzzm_ = @this?.Effective;
                                object rzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzm_);

                                return (rzzzzzzzzzzzzzzzzzzn_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (rzzzzzzzzzzzzzzzzzza_())
                            {
                                DataType rzzzzzzzzzzzzzzzzzzo_ = @this?.Effective;
                                object rzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzo_);

                                return (rzzzzzzzzzzzzzzzzzzp_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime qzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.earliest(context, qzzzzzzzzzzzzzzzzzzw_());

                        return qzzzzzzzzzzzzzzzzzzx_;
                    };
                    IEnumerable<Observation> pzzzzzzzzzzzzzzzzzza_ = context.Operators.SortBy<Observation>(ozzzzzzzzzzzzzzzzzzy_, ozzzzzzzzzzzzzzzzzzz_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation pzzzzzzzzzzzzzzzzzzb_ = context.Operators.First<Observation>(pzzzzzzzzzzzzzzzzzza_);
                    DataType pzzzzzzzzzzzzzzzzzzc_ = pzzzzzzzzzzzzzzzzzzb_?.Effective;
                    object pzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzc_);
                    bool pzzzzzzzzzzzzzzzzzze_ = pzzzzzzzzzzzzzzzzzzd_ is CqlDateTime;

                    return pzzzzzzzzzzzzzzzzzze_;
                };
                if (jzzzzzzzzzzzzzzzzzzc_())
                {
                    CqlValueSet rzzzzzzzzzzzzzzzzzzq_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
                    IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? rzzzzzzzzzzzzzzzzzzs_(Observation O2Saturation)
                    {
                        object rzzzzzzzzzzzzzzzzzzz_()
                        {
                            bool szzzzzzzzzzzzzzzzzzy_()
                            {
                                DataType tzzzzzzzzzzzzzzzzzzb_ = O2Saturation?.Effective;
                                object tzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzb_);
                                bool tzzzzzzzzzzzzzzzzzzd_ = tzzzzzzzzzzzzzzzzzzc_ is CqlDateTime;

                                return tzzzzzzzzzzzzzzzzzzd_;
                            };
                            bool szzzzzzzzzzzzzzzzzzz_()
                            {
                                DataType tzzzzzzzzzzzzzzzzzze_ = O2Saturation?.Effective;
                                object tzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzze_);
                                bool tzzzzzzzzzzzzzzzzzzg_ = tzzzzzzzzzzzzzzzzzzf_ is CqlInterval<CqlDateTime>;

                                return tzzzzzzzzzzzzzzzzzzg_;
                            };
                            bool tzzzzzzzzzzzzzzzzzza_()
                            {
                                DataType tzzzzzzzzzzzzzzzzzzh_ = O2Saturation?.Effective;
                                object tzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzh_);
                                bool tzzzzzzzzzzzzzzzzzzj_ = tzzzzzzzzzzzzzzzzzzi_ is CqlDateTime;

                                return tzzzzzzzzzzzzzzzzzzj_;
                            };
                            if (szzzzzzzzzzzzzzzzzzy_())
                            {
                                DataType tzzzzzzzzzzzzzzzzzzk_ = O2Saturation?.Effective;
                                object tzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzk_);

                                return (tzzzzzzzzzzzzzzzzzzl_ as CqlDateTime) as object;
                            }
                            else if (szzzzzzzzzzzzzzzzzzz_())
                            {
                                DataType tzzzzzzzzzzzzzzzzzzm_ = O2Saturation?.Effective;
                                object tzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzm_);

                                return (tzzzzzzzzzzzzzzzzzzn_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (tzzzzzzzzzzzzzzzzzza_())
                            {
                                DataType tzzzzzzzzzzzzzzzzzzo_ = O2Saturation?.Effective;
                                object tzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzo_);

                                return (tzzzzzzzzzzzzzzzzzzp_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime szzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.earliest(context, rzzzzzzzzzzzzzzzzzzz_());
                        Period szzzzzzzzzzzzzzzzzzb_ = EncounterInpatient?.Period;
                        CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzzzzzzzzzzzzb_);
                        CqlDateTime szzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(szzzzzzzzzzzzzzzzzzc_);
                        CqlQuantity szzzzzzzzzzzzzzzzzze_ = context.Operators.Quantity(1440m, "minutes");
                        CqlDateTime szzzzzzzzzzzzzzzzzzf_ = context.Operators.Subtract(szzzzzzzzzzzzzzzzzzd_, szzzzzzzzzzzzzzzzzze_);
                        CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzzzzzzzzzzzzb_);
                        CqlDateTime szzzzzzzzzzzzzzzzzzi_ = context.Operators.Start(szzzzzzzzzzzzzzzzzzh_);
                        CqlQuantity szzzzzzzzzzzzzzzzzzj_ = context.Operators.Quantity(120m, "minutes");
                        CqlDateTime szzzzzzzzzzzzzzzzzzk_ = context.Operators.Add(szzzzzzzzzzzzzzzzzzi_, szzzzzzzzzzzzzzzzzzj_);
                        CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzl_ = context.Operators.Interval(szzzzzzzzzzzzzzzzzzf_, szzzzzzzzzzzzzzzzzzk_, true, true);
                        bool? szzzzzzzzzzzzzzzzzzm_ = context.Operators.In<CqlDateTime>(szzzzzzzzzzzzzzzzzza_, szzzzzzzzzzzzzzzzzzl_, default);
                        Code<ObservationStatus> szzzzzzzzzzzzzzzzzzn_ = O2Saturation?.StatusElement;
                        ObservationStatus? szzzzzzzzzzzzzzzzzzo_ = szzzzzzzzzzzzzzzzzzn_?.Value;
                        Code<ObservationStatus> szzzzzzzzzzzzzzzzzzp_ = context.Operators.Convert<Code<ObservationStatus>>(szzzzzzzzzzzzzzzzzzo_);
                        string szzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<string>(szzzzzzzzzzzzzzzzzzp_);
                        string[] szzzzzzzzzzzzzzzzzzr_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? szzzzzzzzzzzzzzzzzzs_ = context.Operators.In<string>(szzzzzzzzzzzzzzzzzzq_, szzzzzzzzzzzzzzzzzzr_ as IEnumerable<string>);
                        bool? szzzzzzzzzzzzzzzzzzt_ = context.Operators.And(szzzzzzzzzzzzzzzzzzm_, szzzzzzzzzzzzzzzzzzs_);
                        DataType szzzzzzzzzzzzzzzzzzu_ = O2Saturation?.Value;
                        object szzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzu_);
                        bool? szzzzzzzzzzzzzzzzzzw_ = context.Operators.Not((bool?)(szzzzzzzzzzzzzzzzzzv_ is null));
                        bool? szzzzzzzzzzzzzzzzzzx_ = context.Operators.And(szzzzzzzzzzzzzzzzzzt_, szzzzzzzzzzzzzzzzzzw_);

                        return szzzzzzzzzzzzzzzzzzx_;
                    };
                    IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Observation>(rzzzzzzzzzzzzzzzzzzr_, rzzzzzzzzzzzzzzzzzzs_);
                    object rzzzzzzzzzzzzzzzzzzu_(Observation @this)
                    {
                        object tzzzzzzzzzzzzzzzzzzq_()
                        {
                            bool tzzzzzzzzzzzzzzzzzzs_()
                            {
                                DataType tzzzzzzzzzzzzzzzzzzv_ = @this?.Effective;
                                object tzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzv_);
                                bool tzzzzzzzzzzzzzzzzzzx_ = tzzzzzzzzzzzzzzzzzzw_ is CqlDateTime;

                                return tzzzzzzzzzzzzzzzzzzx_;
                            };
                            bool tzzzzzzzzzzzzzzzzzzt_()
                            {
                                DataType tzzzzzzzzzzzzzzzzzzy_ = @this?.Effective;
                                object tzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzy_);
                                bool uzzzzzzzzzzzzzzzzzza_ = tzzzzzzzzzzzzzzzzzzz_ is CqlInterval<CqlDateTime>;

                                return uzzzzzzzzzzzzzzzzzza_;
                            };
                            bool tzzzzzzzzzzzzzzzzzzu_()
                            {
                                DataType uzzzzzzzzzzzzzzzzzzb_ = @this?.Effective;
                                object uzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzb_);
                                bool uzzzzzzzzzzzzzzzzzzd_ = uzzzzzzzzzzzzzzzzzzc_ is CqlDateTime;

                                return uzzzzzzzzzzzzzzzzzzd_;
                            };
                            if (tzzzzzzzzzzzzzzzzzzs_())
                            {
                                DataType uzzzzzzzzzzzzzzzzzze_ = @this?.Effective;
                                object uzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzze_);

                                return (uzzzzzzzzzzzzzzzzzzf_ as CqlDateTime) as object;
                            }
                            else if (tzzzzzzzzzzzzzzzzzzt_())
                            {
                                DataType uzzzzzzzzzzzzzzzzzzg_ = @this?.Effective;
                                object uzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzg_);

                                return (uzzzzzzzzzzzzzzzzzzh_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (tzzzzzzzzzzzzzzzzzzu_())
                            {
                                DataType uzzzzzzzzzzzzzzzzzzi_ = @this?.Effective;
                                object uzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzi_);

                                return (uzzzzzzzzzzzzzzzzzzj_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime tzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.earliest(context, tzzzzzzzzzzzzzzzzzzq_());

                        return tzzzzzzzzzzzzzzzzzzr_;
                    };
                    IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzv_ = context.Operators.SortBy<Observation>(rzzzzzzzzzzzzzzzzzzt_, rzzzzzzzzzzzzzzzzzzu_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation rzzzzzzzzzzzzzzzzzzw_ = context.Operators.First<Observation>(rzzzzzzzzzzzzzzzzzzv_);
                    DataType rzzzzzzzzzzzzzzzzzzx_ = rzzzzzzzzzzzzzzzzzzw_?.Effective;
                    object rzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzx_);

                    return (rzzzzzzzzzzzzzzzzzzy_ as CqlDateTime) as object;
                }
                else if (jzzzzzzzzzzzzzzzzzzd_())
                {
                    CqlValueSet uzzzzzzzzzzzzzzzzzzk_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
                    IEnumerable<Observation> uzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? uzzzzzzzzzzzzzzzzzzm_(Observation O2Saturation)
                    {
                        object uzzzzzzzzzzzzzzzzzzt_()
                        {
                            bool vzzzzzzzzzzzzzzzzzzs_()
                            {
                                DataType vzzzzzzzzzzzzzzzzzzv_ = O2Saturation?.Effective;
                                object vzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzv_);
                                bool vzzzzzzzzzzzzzzzzzzx_ = vzzzzzzzzzzzzzzzzzzw_ is CqlDateTime;

                                return vzzzzzzzzzzzzzzzzzzx_;
                            };
                            bool vzzzzzzzzzzzzzzzzzzt_()
                            {
                                DataType vzzzzzzzzzzzzzzzzzzy_ = O2Saturation?.Effective;
                                object vzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzy_);
                                bool wzzzzzzzzzzzzzzzzzza_ = vzzzzzzzzzzzzzzzzzzz_ is CqlInterval<CqlDateTime>;

                                return wzzzzzzzzzzzzzzzzzza_;
                            };
                            bool vzzzzzzzzzzzzzzzzzzu_()
                            {
                                DataType wzzzzzzzzzzzzzzzzzzb_ = O2Saturation?.Effective;
                                object wzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzb_);
                                bool wzzzzzzzzzzzzzzzzzzd_ = wzzzzzzzzzzzzzzzzzzc_ is CqlDateTime;

                                return wzzzzzzzzzzzzzzzzzzd_;
                            };
                            if (vzzzzzzzzzzzzzzzzzzs_())
                            {
                                DataType wzzzzzzzzzzzzzzzzzze_ = O2Saturation?.Effective;
                                object wzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzze_);

                                return (wzzzzzzzzzzzzzzzzzzf_ as CqlDateTime) as object;
                            }
                            else if (vzzzzzzzzzzzzzzzzzzt_())
                            {
                                DataType wzzzzzzzzzzzzzzzzzzg_ = O2Saturation?.Effective;
                                object wzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzg_);

                                return (wzzzzzzzzzzzzzzzzzzh_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (vzzzzzzzzzzzzzzzzzzu_())
                            {
                                DataType wzzzzzzzzzzzzzzzzzzi_ = O2Saturation?.Effective;
                                object wzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzi_);

                                return (wzzzzzzzzzzzzzzzzzzj_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime uzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.earliest(context, uzzzzzzzzzzzzzzzzzzt_());
                        Period uzzzzzzzzzzzzzzzzzzv_ = EncounterInpatient?.Period;
                        CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzzzzzzzzzv_);
                        CqlDateTime uzzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(uzzzzzzzzzzzzzzzzzzw_);
                        CqlQuantity uzzzzzzzzzzzzzzzzzzy_ = context.Operators.Quantity(1440m, "minutes");
                        CqlDateTime uzzzzzzzzzzzzzzzzzzz_ = context.Operators.Subtract(uzzzzzzzzzzzzzzzzzzx_, uzzzzzzzzzzzzzzzzzzy_);
                        CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzzzzzzzzzv_);
                        CqlDateTime vzzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(vzzzzzzzzzzzzzzzzzzb_);
                        CqlQuantity vzzzzzzzzzzzzzzzzzzd_ = context.Operators.Quantity(120m, "minutes");
                        CqlDateTime vzzzzzzzzzzzzzzzzzze_ = context.Operators.Add(vzzzzzzzzzzzzzzzzzzc_, vzzzzzzzzzzzzzzzzzzd_);
                        CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzf_ = context.Operators.Interval(uzzzzzzzzzzzzzzzzzzz_, vzzzzzzzzzzzzzzzzzze_, true, true);
                        bool? vzzzzzzzzzzzzzzzzzzg_ = context.Operators.In<CqlDateTime>(uzzzzzzzzzzzzzzzzzzu_, vzzzzzzzzzzzzzzzzzzf_, default);
                        Code<ObservationStatus> vzzzzzzzzzzzzzzzzzzh_ = O2Saturation?.StatusElement;
                        ObservationStatus? vzzzzzzzzzzzzzzzzzzi_ = vzzzzzzzzzzzzzzzzzzh_?.Value;
                        Code<ObservationStatus> vzzzzzzzzzzzzzzzzzzj_ = context.Operators.Convert<Code<ObservationStatus>>(vzzzzzzzzzzzzzzzzzzi_);
                        string vzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<string>(vzzzzzzzzzzzzzzzzzzj_);
                        string[] vzzzzzzzzzzzzzzzzzzl_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? vzzzzzzzzzzzzzzzzzzm_ = context.Operators.In<string>(vzzzzzzzzzzzzzzzzzzk_, vzzzzzzzzzzzzzzzzzzl_ as IEnumerable<string>);
                        bool? vzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzg_, vzzzzzzzzzzzzzzzzzzm_);
                        DataType vzzzzzzzzzzzzzzzzzzo_ = O2Saturation?.Value;
                        object vzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzo_);
                        bool? vzzzzzzzzzzzzzzzzzzq_ = context.Operators.Not((bool?)(vzzzzzzzzzzzzzzzzzzp_ is null));
                        bool? vzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzn_, vzzzzzzzzzzzzzzzzzzq_);

                        return vzzzzzzzzzzzzzzzzzzr_;
                    };
                    IEnumerable<Observation> uzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Observation>(uzzzzzzzzzzzzzzzzzzl_, uzzzzzzzzzzzzzzzzzzm_);
                    object uzzzzzzzzzzzzzzzzzzo_(Observation @this)
                    {
                        object wzzzzzzzzzzzzzzzzzzk_()
                        {
                            bool wzzzzzzzzzzzzzzzzzzm_()
                            {
                                DataType wzzzzzzzzzzzzzzzzzzp_ = @this?.Effective;
                                object wzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzp_);
                                bool wzzzzzzzzzzzzzzzzzzr_ = wzzzzzzzzzzzzzzzzzzq_ is CqlDateTime;

                                return wzzzzzzzzzzzzzzzzzzr_;
                            };
                            bool wzzzzzzzzzzzzzzzzzzn_()
                            {
                                DataType wzzzzzzzzzzzzzzzzzzs_ = @this?.Effective;
                                object wzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzs_);
                                bool wzzzzzzzzzzzzzzzzzzu_ = wzzzzzzzzzzzzzzzzzzt_ is CqlInterval<CqlDateTime>;

                                return wzzzzzzzzzzzzzzzzzzu_;
                            };
                            bool wzzzzzzzzzzzzzzzzzzo_()
                            {
                                DataType wzzzzzzzzzzzzzzzzzzv_ = @this?.Effective;
                                object wzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzv_);
                                bool wzzzzzzzzzzzzzzzzzzx_ = wzzzzzzzzzzzzzzzzzzw_ is CqlDateTime;

                                return wzzzzzzzzzzzzzzzzzzx_;
                            };
                            if (wzzzzzzzzzzzzzzzzzzm_())
                            {
                                DataType wzzzzzzzzzzzzzzzzzzy_ = @this?.Effective;
                                object wzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzy_);

                                return (wzzzzzzzzzzzzzzzzzzz_ as CqlDateTime) as object;
                            }
                            else if (wzzzzzzzzzzzzzzzzzzn_())
                            {
                                DataType xzzzzzzzzzzzzzzzzzza_ = @this?.Effective;
                                object xzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzza_);

                                return (xzzzzzzzzzzzzzzzzzzb_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (wzzzzzzzzzzzzzzzzzzo_())
                            {
                                DataType xzzzzzzzzzzzzzzzzzzc_ = @this?.Effective;
                                object xzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzc_);

                                return (xzzzzzzzzzzzzzzzzzzd_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime wzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.earliest(context, wzzzzzzzzzzzzzzzzzzk_());

                        return wzzzzzzzzzzzzzzzzzzl_;
                    };
                    IEnumerable<Observation> uzzzzzzzzzzzzzzzzzzp_ = context.Operators.SortBy<Observation>(uzzzzzzzzzzzzzzzzzzn_, uzzzzzzzzzzzzzzzzzzo_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation uzzzzzzzzzzzzzzzzzzq_ = context.Operators.First<Observation>(uzzzzzzzzzzzzzzzzzzp_);
                    DataType uzzzzzzzzzzzzzzzzzzr_ = uzzzzzzzzzzzzzzzzzzq_?.Effective;
                    object uzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzr_);

                    return (uzzzzzzzzzzzzzzzzzzs_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (jzzzzzzzzzzzzzzzzzze_())
                {
                    CqlValueSet xzzzzzzzzzzzzzzzzzze_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
                    IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? xzzzzzzzzzzzzzzzzzzg_(Observation O2Saturation)
                    {
                        object xzzzzzzzzzzzzzzzzzzn_()
                        {
                            bool yzzzzzzzzzzzzzzzzzzm_()
                            {
                                DataType yzzzzzzzzzzzzzzzzzzp_ = O2Saturation?.Effective;
                                object yzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzp_);
                                bool yzzzzzzzzzzzzzzzzzzr_ = yzzzzzzzzzzzzzzzzzzq_ is CqlDateTime;

                                return yzzzzzzzzzzzzzzzzzzr_;
                            };
                            bool yzzzzzzzzzzzzzzzzzzn_()
                            {
                                DataType yzzzzzzzzzzzzzzzzzzs_ = O2Saturation?.Effective;
                                object yzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzs_);
                                bool yzzzzzzzzzzzzzzzzzzu_ = yzzzzzzzzzzzzzzzzzzt_ is CqlInterval<CqlDateTime>;

                                return yzzzzzzzzzzzzzzzzzzu_;
                            };
                            bool yzzzzzzzzzzzzzzzzzzo_()
                            {
                                DataType yzzzzzzzzzzzzzzzzzzv_ = O2Saturation?.Effective;
                                object yzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzv_);
                                bool yzzzzzzzzzzzzzzzzzzx_ = yzzzzzzzzzzzzzzzzzzw_ is CqlDateTime;

                                return yzzzzzzzzzzzzzzzzzzx_;
                            };
                            if (yzzzzzzzzzzzzzzzzzzm_())
                            {
                                DataType yzzzzzzzzzzzzzzzzzzy_ = O2Saturation?.Effective;
                                object yzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzy_);

                                return (yzzzzzzzzzzzzzzzzzzz_ as CqlDateTime) as object;
                            }
                            else if (yzzzzzzzzzzzzzzzzzzn_())
                            {
                                DataType zzzzzzzzzzzzzzzzzzza_ = O2Saturation?.Effective;
                                object zzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzza_);

                                return (zzzzzzzzzzzzzzzzzzzb_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (yzzzzzzzzzzzzzzzzzzo_())
                            {
                                DataType zzzzzzzzzzzzzzzzzzzc_ = O2Saturation?.Effective;
                                object zzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzc_);

                                return (zzzzzzzzzzzzzzzzzzzd_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime xzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.earliest(context, xzzzzzzzzzzzzzzzzzzn_());
                        Period xzzzzzzzzzzzzzzzzzzp_ = EncounterInpatient?.Period;
                        CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzzzp_);
                        CqlDateTime xzzzzzzzzzzzzzzzzzzr_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzq_);
                        CqlQuantity xzzzzzzzzzzzzzzzzzzs_ = context.Operators.Quantity(1440m, "minutes");
                        CqlDateTime xzzzzzzzzzzzzzzzzzzt_ = context.Operators.Subtract(xzzzzzzzzzzzzzzzzzzr_, xzzzzzzzzzzzzzzzzzzs_);
                        CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzzzp_);
                        CqlDateTime xzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzv_);
                        CqlQuantity xzzzzzzzzzzzzzzzzzzx_ = context.Operators.Quantity(120m, "minutes");
                        CqlDateTime xzzzzzzzzzzzzzzzzzzy_ = context.Operators.Add(xzzzzzzzzzzzzzzzzzzw_, xzzzzzzzzzzzzzzzzzzx_);
                        CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzz_ = context.Operators.Interval(xzzzzzzzzzzzzzzzzzzt_, xzzzzzzzzzzzzzzzzzzy_, true, true);
                        bool? yzzzzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzzzzzzzzzzo_, xzzzzzzzzzzzzzzzzzzz_, default);
                        Code<ObservationStatus> yzzzzzzzzzzzzzzzzzzb_ = O2Saturation?.StatusElement;
                        ObservationStatus? yzzzzzzzzzzzzzzzzzzc_ = yzzzzzzzzzzzzzzzzzzb_?.Value;
                        Code<ObservationStatus> yzzzzzzzzzzzzzzzzzzd_ = context.Operators.Convert<Code<ObservationStatus>>(yzzzzzzzzzzzzzzzzzzc_);
                        string yzzzzzzzzzzzzzzzzzze_ = context.Operators.Convert<string>(yzzzzzzzzzzzzzzzzzzd_);
                        string[] yzzzzzzzzzzzzzzzzzzf_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? yzzzzzzzzzzzzzzzzzzg_ = context.Operators.In<string>(yzzzzzzzzzzzzzzzzzze_, yzzzzzzzzzzzzzzzzzzf_ as IEnumerable<string>);
                        bool? yzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(yzzzzzzzzzzzzzzzzzza_, yzzzzzzzzzzzzzzzzzzg_);
                        DataType yzzzzzzzzzzzzzzzzzzi_ = O2Saturation?.Value;
                        object yzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzi_);
                        bool? yzzzzzzzzzzzzzzzzzzk_ = context.Operators.Not((bool?)(yzzzzzzzzzzzzzzzzzzj_ is null));
                        bool? yzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzh_, yzzzzzzzzzzzzzzzzzzk_);

                        return yzzzzzzzzzzzzzzzzzzl_;
                    };
                    IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Observation>(xzzzzzzzzzzzzzzzzzzf_, xzzzzzzzzzzzzzzzzzzg_);
                    object xzzzzzzzzzzzzzzzzzzi_(Observation @this)
                    {
                        object zzzzzzzzzzzzzzzzzzze_()
                        {
                            bool zzzzzzzzzzzzzzzzzzzg_()
                            {
                                DataType zzzzzzzzzzzzzzzzzzzj_ = @this?.Effective;
                                object zzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzj_);
                                bool zzzzzzzzzzzzzzzzzzzl_ = zzzzzzzzzzzzzzzzzzzk_ is CqlDateTime;

                                return zzzzzzzzzzzzzzzzzzzl_;
                            };
                            bool zzzzzzzzzzzzzzzzzzzh_()
                            {
                                DataType zzzzzzzzzzzzzzzzzzzm_ = @this?.Effective;
                                object zzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzm_);
                                bool zzzzzzzzzzzzzzzzzzzo_ = zzzzzzzzzzzzzzzzzzzn_ is CqlInterval<CqlDateTime>;

                                return zzzzzzzzzzzzzzzzzzzo_;
                            };
                            bool zzzzzzzzzzzzzzzzzzzi_()
                            {
                                DataType zzzzzzzzzzzzzzzzzzzp_ = @this?.Effective;
                                object zzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzp_);
                                bool zzzzzzzzzzzzzzzzzzzr_ = zzzzzzzzzzzzzzzzzzzq_ is CqlDateTime;

                                return zzzzzzzzzzzzzzzzzzzr_;
                            };
                            if (zzzzzzzzzzzzzzzzzzzg_())
                            {
                                DataType zzzzzzzzzzzzzzzzzzzs_ = @this?.Effective;
                                object zzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzs_);

                                return (zzzzzzzzzzzzzzzzzzzt_ as CqlDateTime) as object;
                            }
                            else if (zzzzzzzzzzzzzzzzzzzh_())
                            {
                                DataType zzzzzzzzzzzzzzzzzzzu_ = @this?.Effective;
                                object zzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzu_);

                                return (zzzzzzzzzzzzzzzzzzzv_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (zzzzzzzzzzzzzzzzzzzi_())
                            {
                                DataType zzzzzzzzzzzzzzzzzzzw_ = @this?.Effective;
                                object zzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzw_);

                                return (zzzzzzzzzzzzzzzzzzzx_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime zzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.earliest(context, zzzzzzzzzzzzzzzzzzze_());

                        return zzzzzzzzzzzzzzzzzzzf_;
                    };
                    IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzj_ = context.Operators.SortBy<Observation>(xzzzzzzzzzzzzzzzzzzh_, xzzzzzzzzzzzzzzzzzzi_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation xzzzzzzzzzzzzzzzzzzk_ = context.Operators.First<Observation>(xzzzzzzzzzzzzzzzzzzj_);
                    DataType xzzzzzzzzzzzzzzzzzzl_ = xzzzzzzzzzzzzzzzzzzk_?.Effective;
                    object xzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzl_);

                    return (xzzzzzzzzzzzzzzzzzzm_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime gzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.earliest(context, gzzzzzzzzzzzzzzzzzzo_());
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)? gzzzzzzzzzzzzzzzzzzq_ = (CqlTupleMetadata_FdREYEdHOZIcMCNYCRFJYJReA, gzzzzzzzzzzzzzzzzzze_, gzzzzzzzzzzzzzzzzzzn_ as CqlQuantity, gzzzzzzzzzzzzzzzzzzp_);

            return gzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)?> gzzzzzzzzzzzzzzzzzzb_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)?>(fzzzzzzzzzzzzzzzzzzz_, gzzzzzzzzzzzzzzzzzza_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)?> gzzzzzzzzzzzzzzzzzzc_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)?>(gzzzzzzzzzzzzzzzzzzb_);

        return gzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Encounter with First Respiratory Rate")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstRespRateResult, CqlDateTime Timing)?> Encounter_with_First_Respiratory_Rate(CqlContext context)
    {
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzy_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstRespRateResult, CqlDateTime Timing)? zzzzzzzzzzzzzzzzzzzz_(Encounter EncounterInpatient)
        {
            Id azzzzzzzzzzzzzzzzzzzc_ = EncounterInpatient?.IdElement;
            string azzzzzzzzzzzzzzzzzzzd_ = azzzzzzzzzzzzzzzzzzzc_?.Value;
            IEnumerable<Observation> azzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/resprate"));
            bool? azzzzzzzzzzzzzzzzzzzf_(Observation RespRate)
            {
                DataType azzzzzzzzzzzzzzzzzzzw_ = RespRate?.Effective;
                object azzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzw_);
                CqlDateTime azzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.earliest(context, azzzzzzzzzzzzzzzzzzzx_);
                Period azzzzzzzzzzzzzzzzzzzz_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzzzzzz_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzza_);
                CqlQuantity bzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime bzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Subtract(bzzzzzzzzzzzzzzzzzzzb_, bzzzzzzzzzzzzzzzzzzzc_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzzzzzz_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzf_);
                CqlQuantity bzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime bzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Add(bzzzzzzzzzzzzzzzzzzzg_, bzzzzzzzzzzzzzzzzzzzh_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Interval(bzzzzzzzzzzzzzzzzzzzd_, bzzzzzzzzzzzzzzzzzzzi_, true, true);
                bool? bzzzzzzzzzzzzzzzzzzzk_ = context.Operators.In<CqlDateTime>(azzzzzzzzzzzzzzzzzzzy_, bzzzzzzzzzzzzzzzzzzzj_, default);
                Code<ObservationStatus> bzzzzzzzzzzzzzzzzzzzl_ = RespRate?.StatusElement;
                ObservationStatus? bzzzzzzzzzzzzzzzzzzzm_ = bzzzzzzzzzzzzzzzzzzzl_?.Value;
                string bzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Convert<string>(bzzzzzzzzzzzzzzzzzzzm_);
                string[] bzzzzzzzzzzzzzzzzzzzo_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? bzzzzzzzzzzzzzzzzzzzp_ = context.Operators.In<string>(bzzzzzzzzzzzzzzzzzzzn_, bzzzzzzzzzzzzzzzzzzzo_ as IEnumerable<string>);
                bool? bzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzk_, bzzzzzzzzzzzzzzzzzzzp_);
                DataType bzzzzzzzzzzzzzzzzzzzr_ = RespRate?.Value;
                CqlQuantity bzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, bzzzzzzzzzzzzzzzzzzzr_ as Quantity);
                bool? bzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Not((bool?)(bzzzzzzzzzzzzzzzzzzzs_ is null));
                bool? bzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzq_, bzzzzzzzzzzzzzzzzzzzt_);

                return bzzzzzzzzzzzzzzzzzzzu_;
            };
            IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Observation>(azzzzzzzzzzzzzzzzzzze_, azzzzzzzzzzzzzzzzzzzf_);
            object azzzzzzzzzzzzzzzzzzzh_(Observation @this)
            {
                DataType bzzzzzzzzzzzzzzzzzzzv_ = @this?.Effective;
                object bzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzv_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.earliest(context, bzzzzzzzzzzzzzzzzzzzw_);

                return bzzzzzzzzzzzzzzzzzzzx_;
            };
            IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzi_ = context.Operators.SortBy<Observation>(azzzzzzzzzzzzzzzzzzzg_, azzzzzzzzzzzzzzzzzzzh_, System.ComponentModel.ListSortDirection.Ascending);
            Observation azzzzzzzzzzzzzzzzzzzj_ = context.Operators.First<Observation>(azzzzzzzzzzzzzzzzzzzi_);
            DataType azzzzzzzzzzzzzzzzzzzk_ = azzzzzzzzzzzzzzzzzzzj_?.Value;
            CqlQuantity azzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, azzzzzzzzzzzzzzzzzzzk_ as Quantity);
            bool? azzzzzzzzzzzzzzzzzzzn_(Observation RespRate)
            {
                DataType bzzzzzzzzzzzzzzzzzzzy_ = RespRate?.Effective;
                object bzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzy_);
                CqlDateTime czzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.earliest(context, bzzzzzzzzzzzzzzzzzzzz_);
                Period czzzzzzzzzzzzzzzzzzzb_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzzzzzzzzzzzzb_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzzc_);
                CqlQuantity czzzzzzzzzzzzzzzzzzze_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime czzzzzzzzzzzzzzzzzzzf_ = context.Operators.Subtract(czzzzzzzzzzzzzzzzzzzd_, czzzzzzzzzzzzzzzzzzze_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzzzzzzzzzzzzb_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzi_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzzh_);
                CqlQuantity czzzzzzzzzzzzzzzzzzzj_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime czzzzzzzzzzzzzzzzzzzk_ = context.Operators.Add(czzzzzzzzzzzzzzzzzzzi_, czzzzzzzzzzzzzzzzzzzj_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzl_ = context.Operators.Interval(czzzzzzzzzzzzzzzzzzzf_, czzzzzzzzzzzzzzzzzzzk_, true, true);
                bool? czzzzzzzzzzzzzzzzzzzm_ = context.Operators.In<CqlDateTime>(czzzzzzzzzzzzzzzzzzza_, czzzzzzzzzzzzzzzzzzzl_, default);
                Code<ObservationStatus> czzzzzzzzzzzzzzzzzzzn_ = RespRate?.StatusElement;
                ObservationStatus? czzzzzzzzzzzzzzzzzzzo_ = czzzzzzzzzzzzzzzzzzzn_?.Value;
                string czzzzzzzzzzzzzzzzzzzp_ = context.Operators.Convert<string>(czzzzzzzzzzzzzzzzzzzo_);
                string[] czzzzzzzzzzzzzzzzzzzq_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? czzzzzzzzzzzzzzzzzzzr_ = context.Operators.In<string>(czzzzzzzzzzzzzzzzzzzp_, czzzzzzzzzzzzzzzzzzzq_ as IEnumerable<string>);
                bool? czzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzm_, czzzzzzzzzzzzzzzzzzzr_);
                DataType czzzzzzzzzzzzzzzzzzzt_ = RespRate?.Value;
                CqlQuantity czzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, czzzzzzzzzzzzzzzzzzzt_ as Quantity);
                bool? czzzzzzzzzzzzzzzzzzzv_ = context.Operators.Not((bool?)(czzzzzzzzzzzzzzzzzzzu_ is null));
                bool? czzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzs_, czzzzzzzzzzzzzzzzzzzv_);

                return czzzzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Observation>(azzzzzzzzzzzzzzzzzzze_, azzzzzzzzzzzzzzzzzzzn_);
            object azzzzzzzzzzzzzzzzzzzp_(Observation @this)
            {
                DataType czzzzzzzzzzzzzzzzzzzx_ = @this?.Effective;
                object czzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzx_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.earliest(context, czzzzzzzzzzzzzzzzzzzy_);

                return czzzzzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzq_ = context.Operators.SortBy<Observation>(azzzzzzzzzzzzzzzzzzzo_, azzzzzzzzzzzzzzzzzzzp_, System.ComponentModel.ListSortDirection.Ascending);
            Observation azzzzzzzzzzzzzzzzzzzr_ = context.Operators.First<Observation>(azzzzzzzzzzzzzzzzzzzq_);
            DataType azzzzzzzzzzzzzzzzzzzs_ = azzzzzzzzzzzzzzzzzzzr_?.Effective;
            object azzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzs_);
            CqlDateTime azzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.earliest(context, azzzzzzzzzzzzzzzzzzzt_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstRespRateResult, CqlDateTime Timing)? azzzzzzzzzzzzzzzzzzzv_ = (CqlTupleMetadata_CYbMQaXdPgTVSLXJSHHNTbhVM, azzzzzzzzzzzzzzzzzzzd_, azzzzzzzzzzzzzzzzzzzl_ as CqlQuantity, azzzzzzzzzzzzzzzzzzzu_);

            return azzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstRespRateResult, CqlDateTime Timing)?> azzzzzzzzzzzzzzzzzzza_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstRespRateResult, CqlDateTime Timing)?>(zzzzzzzzzzzzzzzzzzzy_, zzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstRespRateResult, CqlDateTime Timing)?> azzzzzzzzzzzzzzzzzzzb_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstRespRateResult, CqlDateTime Timing)?>(azzzzzzzzzzzzzzzzzzza_);

        return azzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Blood Pressure Reading")]
    public IEnumerable<Observation> Blood_Pressure_Reading(CqlContext context)
    {
        IEnumerable<Observation> dzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bp"));
        bool? dzzzzzzzzzzzzzzzzzzzb_(Observation BloodPressure)
        {
            Code<ObservationStatus> dzzzzzzzzzzzzzzzzzzzd_ = BloodPressure?.StatusElement;
            ObservationStatus? dzzzzzzzzzzzzzzzzzzze_ = dzzzzzzzzzzzzzzzzzzzd_?.Value;
            string dzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<string>(dzzzzzzzzzzzzzzzzzzze_);
            string[] dzzzzzzzzzzzzzzzzzzzg_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? dzzzzzzzzzzzzzzzzzzzh_ = context.Operators.In<string>(dzzzzzzzzzzzzzzzzzzzf_, dzzzzzzzzzzzzzzzzzzzg_ as IEnumerable<string>);

            return dzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Observation> dzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Observation>(dzzzzzzzzzzzzzzzzzzza_, dzzzzzzzzzzzzzzzzzzzb_);

        return dzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Encounter with First Systolic Blood Pressure")]
    public IEnumerable<string> Encounter_with_First_Systolic_Blood_Pressure(CqlContext context)
    {
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzi_ = this.Inpatient_Encounters(context);
        string dzzzzzzzzzzzzzzzzzzzj_(Encounter EncounterInpatient)
        {
            Id dzzzzzzzzzzzzzzzzzzzm_ = EncounterInpatient?.IdElement;
            string dzzzzzzzzzzzzzzzzzzzn_ = dzzzzzzzzzzzzzzzzzzzm_?.Value;

            return dzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<string> dzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Select<Encounter, string>(dzzzzzzzzzzzzzzzzzzzi_, dzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<string> dzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Distinct<string>(dzzzzzzzzzzzzzzzzzzzk_);

        return dzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Encounter with First Bicarbonate Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> Encounter_with_First_Bicarbonate_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzo_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)? dzzzzzzzzzzzzzzzzzzzp_(Encounter EncounterInpatient)
        {
            Id dzzzzzzzzzzzzzzzzzzzs_ = EncounterInpatient?.IdElement;
            string dzzzzzzzzzzzzzzzzzzzt_ = dzzzzzzzzzzzzzzzzzzzs_?.Value;
            CqlValueSet dzzzzzzzzzzzzzzzzzzzu_ = this.Bicarbonate_lab_test(context);
            IEnumerable<Observation> dzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? dzzzzzzzzzzzzzzzzzzzw_(Observation bicarbonatelab)
            {
                Instant ezzzzzzzzzzzzzzzzzzzo_ = bicarbonatelab?.IssuedElement;
                DateTimeOffset? ezzzzzzzzzzzzzzzzzzzp_ = ezzzzzzzzzzzzzzzzzzzo_?.Value;
                CqlDateTime ezzzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<CqlDateTime>(ezzzzzzzzzzzzzzzzzzzp_);
                CqlDateTime ezzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.earliest(context, ezzzzzzzzzzzzzzzzzzzq_ as object);
                Period ezzzzzzzzzzzzzzzzzzzs_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzzzzzzzzzzzzs_);
                CqlDateTime ezzzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzzzt_);
                CqlQuantity ezzzzzzzzzzzzzzzzzzzv_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime ezzzzzzzzzzzzzzzzzzzw_ = context.Operators.Subtract(ezzzzzzzzzzzzzzzzzzzu_, ezzzzzzzzzzzzzzzzzzzv_);
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzzzzzzzzzzzzs_);
                CqlDateTime ezzzzzzzzzzzzzzzzzzzz_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzzzy_);
                CqlDateTime fzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Add(ezzzzzzzzzzzzzzzzzzzz_, ezzzzzzzzzzzzzzzzzzzv_);
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Interval(ezzzzzzzzzzzzzzzzzzzw_, fzzzzzzzzzzzzzzzzzzzb_, true, true);
                bool? fzzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(ezzzzzzzzzzzzzzzzzzzr_, fzzzzzzzzzzzzzzzzzzzc_, default);
                Code<ObservationStatus> fzzzzzzzzzzzzzzzzzzze_ = bicarbonatelab?.StatusElement;
                ObservationStatus? fzzzzzzzzzzzzzzzzzzzf_ = fzzzzzzzzzzzzzzzzzzze_?.Value;
                string fzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<string>(fzzzzzzzzzzzzzzzzzzzf_);
                string[] fzzzzzzzzzzzzzzzzzzzh_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? fzzzzzzzzzzzzzzzzzzzi_ = context.Operators.In<string>(fzzzzzzzzzzzzzzzzzzzg_, fzzzzzzzzzzzzzzzzzzzh_ as IEnumerable<string>);
                bool? fzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzd_, fzzzzzzzzzzzzzzzzzzzi_);
                DataType fzzzzzzzzzzzzzzzzzzzk_ = bicarbonatelab?.Value;
                object fzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzk_);
                bool? fzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Not((bool?)(fzzzzzzzzzzzzzzzzzzzl_ is null));
                bool? fzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzj_, fzzzzzzzzzzzzzzzzzzzm_);

                return fzzzzzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<Observation> dzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Observation>(dzzzzzzzzzzzzzzzzzzzv_, dzzzzzzzzzzzzzzzzzzzw_);
            object dzzzzzzzzzzzzzzzzzzzy_(Observation @this)
            {
                Instant fzzzzzzzzzzzzzzzzzzzo_ = @this?.IssuedElement;
                DateTimeOffset? fzzzzzzzzzzzzzzzzzzzp_ = fzzzzzzzzzzzzzzzzzzzo_?.Value;
                CqlDateTime fzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<CqlDateTime>(fzzzzzzzzzzzzzzzzzzzp_);
                CqlDateTime fzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.earliest(context, fzzzzzzzzzzzzzzzzzzzq_ as object);

                return fzzzzzzzzzzzzzzzzzzzr_;
            };
            IEnumerable<Observation> dzzzzzzzzzzzzzzzzzzzz_ = context.Operators.SortBy<Observation>(dzzzzzzzzzzzzzzzzzzzx_, dzzzzzzzzzzzzzzzzzzzy_, System.ComponentModel.ListSortDirection.Ascending);
            Observation ezzzzzzzzzzzzzzzzzzza_ = context.Operators.First<Observation>(dzzzzzzzzzzzzzzzzzzzz_);
            DataType ezzzzzzzzzzzzzzzzzzzb_ = ezzzzzzzzzzzzzzzzzzza_?.Value;
            object ezzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzb_);
            IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? ezzzzzzzzzzzzzzzzzzzf_(Observation bicarbonatelab)
            {
                Instant fzzzzzzzzzzzzzzzzzzzs_ = bicarbonatelab?.IssuedElement;
                DateTimeOffset? fzzzzzzzzzzzzzzzzzzzt_ = fzzzzzzzzzzzzzzzzzzzs_?.Value;
                CqlDateTime fzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Convert<CqlDateTime>(fzzzzzzzzzzzzzzzzzzzt_);
                CqlDateTime fzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.earliest(context, fzzzzzzzzzzzzzzzzzzzu_ as object);
                Period fzzzzzzzzzzzzzzzzzzzw_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzzzzzzzzzzzw_);
                CqlDateTime fzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(fzzzzzzzzzzzzzzzzzzzx_);
                CqlQuantity fzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime gzzzzzzzzzzzzzzzzzzza_ = context.Operators.Subtract(fzzzzzzzzzzzzzzzzzzzy_, fzzzzzzzzzzzzzzzzzzzz_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzzzzzzzzzzzw_);
                CqlDateTime gzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzzc_);
                CqlDateTime gzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Add(gzzzzzzzzzzzzzzzzzzzd_, fzzzzzzzzzzzzzzzzzzzz_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Interval(gzzzzzzzzzzzzzzzzzzza_, gzzzzzzzzzzzzzzzzzzzf_, true, true);
                bool? gzzzzzzzzzzzzzzzzzzzh_ = context.Operators.In<CqlDateTime>(fzzzzzzzzzzzzzzzzzzzv_, gzzzzzzzzzzzzzzzzzzzg_, default);
                Code<ObservationStatus> gzzzzzzzzzzzzzzzzzzzi_ = bicarbonatelab?.StatusElement;
                ObservationStatus? gzzzzzzzzzzzzzzzzzzzj_ = gzzzzzzzzzzzzzzzzzzzi_?.Value;
                string gzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<string>(gzzzzzzzzzzzzzzzzzzzj_);
                string[] gzzzzzzzzzzzzzzzzzzzl_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? gzzzzzzzzzzzzzzzzzzzm_ = context.Operators.In<string>(gzzzzzzzzzzzzzzzzzzzk_, gzzzzzzzzzzzzzzzzzzzl_ as IEnumerable<string>);
                bool? gzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzh_, gzzzzzzzzzzzzzzzzzzzm_);
                DataType gzzzzzzzzzzzzzzzzzzzo_ = bicarbonatelab?.Value;
                object gzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzo_);
                bool? gzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Not((bool?)(gzzzzzzzzzzzzzzzzzzzp_ is null));
                bool? gzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzn_, gzzzzzzzzzzzzzzzzzzzq_);

                return gzzzzzzzzzzzzzzzzzzzr_;
            };
            IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Observation>(ezzzzzzzzzzzzzzzzzzze_, ezzzzzzzzzzzzzzzzzzzf_);
            object ezzzzzzzzzzzzzzzzzzzh_(Observation @this)
            {
                Instant gzzzzzzzzzzzzzzzzzzzs_ = @this?.IssuedElement;
                DateTimeOffset? gzzzzzzzzzzzzzzzzzzzt_ = gzzzzzzzzzzzzzzzzzzzs_?.Value;
                CqlDateTime gzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Convert<CqlDateTime>(gzzzzzzzzzzzzzzzzzzzt_);
                CqlDateTime gzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.earliest(context, gzzzzzzzzzzzzzzzzzzzu_ as object);

                return gzzzzzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzi_ = context.Operators.SortBy<Observation>(ezzzzzzzzzzzzzzzzzzzg_, ezzzzzzzzzzzzzzzzzzzh_, System.ComponentModel.ListSortDirection.Ascending);
            Observation ezzzzzzzzzzzzzzzzzzzj_ = context.Operators.First<Observation>(ezzzzzzzzzzzzzzzzzzzi_);
            Instant ezzzzzzzzzzzzzzzzzzzk_ = ezzzzzzzzzzzzzzzzzzzj_?.IssuedElement;
            DateTimeOffset? ezzzzzzzzzzzzzzzzzzzl_ = ezzzzzzzzzzzzzzzzzzzk_?.Value;
            CqlDateTime ezzzzzzzzzzzzzzzzzzzm_ = context.Operators.Convert<CqlDateTime>(ezzzzzzzzzzzzzzzzzzzl_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)? ezzzzzzzzzzzzzzzzzzzn_ = (CqlTupleMetadata_HDVhZFAYAdGHPZJWcDFSNFGPd, dzzzzzzzzzzzzzzzzzzzt_, ezzzzzzzzzzzzzzzzzzzc_ as CqlQuantity, ezzzzzzzzzzzzzzzzzzzm_);

            return ezzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> dzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?>(dzzzzzzzzzzzzzzzzzzzo_, dzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> dzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?>(dzzzzzzzzzzzzzzzzzzzq_);

        return dzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Encounter with First Creatinine Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> Encounter_with_First_Creatinine_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzw_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)? gzzzzzzzzzzzzzzzzzzzx_(Encounter EncounterInpatient)
        {
            Id hzzzzzzzzzzzzzzzzzzza_ = EncounterInpatient?.IdElement;
            string hzzzzzzzzzzzzzzzzzzzb_ = hzzzzzzzzzzzzzzzzzzza_?.Value;
            CqlValueSet hzzzzzzzzzzzzzzzzzzzc_ = this.Creatinine_lab_test(context);
            IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? hzzzzzzzzzzzzzzzzzzze_(Observation CreatinineLab)
            {
                Instant hzzzzzzzzzzzzzzzzzzzw_ = CreatinineLab?.IssuedElement;
                DateTimeOffset? hzzzzzzzzzzzzzzzzzzzx_ = hzzzzzzzzzzzzzzzzzzzw_?.Value;
                CqlDateTime hzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<CqlDateTime>(hzzzzzzzzzzzzzzzzzzzx_);
                CqlDateTime hzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.earliest(context, hzzzzzzzzzzzzzzzzzzzy_ as object);
                Period izzzzzzzzzzzzzzzzzzza_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzzzzzzzzzza_);
                CqlDateTime izzzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(izzzzzzzzzzzzzzzzzzzb_);
                CqlQuantity izzzzzzzzzzzzzzzzzzzd_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime izzzzzzzzzzzzzzzzzzze_ = context.Operators.Subtract(izzzzzzzzzzzzzzzzzzzc_, izzzzzzzzzzzzzzzzzzzd_);
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzzzzzzzzzza_);
                CqlDateTime izzzzzzzzzzzzzzzzzzzh_ = context.Operators.Start(izzzzzzzzzzzzzzzzzzzg_);
                CqlDateTime izzzzzzzzzzzzzzzzzzzj_ = context.Operators.Add(izzzzzzzzzzzzzzzzzzzh_, izzzzzzzzzzzzzzzzzzzd_);
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzk_ = context.Operators.Interval(izzzzzzzzzzzzzzzzzzze_, izzzzzzzzzzzzzzzzzzzj_, true, true);
                bool? izzzzzzzzzzzzzzzzzzzl_ = context.Operators.In<CqlDateTime>(hzzzzzzzzzzzzzzzzzzzz_, izzzzzzzzzzzzzzzzzzzk_, default);
                Code<ObservationStatus> izzzzzzzzzzzzzzzzzzzm_ = CreatinineLab?.StatusElement;
                ObservationStatus? izzzzzzzzzzzzzzzzzzzn_ = izzzzzzzzzzzzzzzzzzzm_?.Value;
                string izzzzzzzzzzzzzzzzzzzo_ = context.Operators.Convert<string>(izzzzzzzzzzzzzzzzzzzn_);
                string[] izzzzzzzzzzzzzzzzzzzp_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? izzzzzzzzzzzzzzzzzzzq_ = context.Operators.In<string>(izzzzzzzzzzzzzzzzzzzo_, izzzzzzzzzzzzzzzzzzzp_ as IEnumerable<string>);
                bool? izzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzl_, izzzzzzzzzzzzzzzzzzzq_);
                DataType izzzzzzzzzzzzzzzzzzzs_ = CreatinineLab?.Value;
                object izzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzs_);
                bool? izzzzzzzzzzzzzzzzzzzu_ = context.Operators.Not((bool?)(izzzzzzzzzzzzzzzzzzzt_ is null));
                bool? izzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzr_, izzzzzzzzzzzzzzzzzzzu_);

                return izzzzzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Observation>(hzzzzzzzzzzzzzzzzzzzd_, hzzzzzzzzzzzzzzzzzzze_);
            object hzzzzzzzzzzzzzzzzzzzg_(Observation @this)
            {
                Instant izzzzzzzzzzzzzzzzzzzw_ = @this?.IssuedElement;
                DateTimeOffset? izzzzzzzzzzzzzzzzzzzx_ = izzzzzzzzzzzzzzzzzzzw_?.Value;
                CqlDateTime izzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<CqlDateTime>(izzzzzzzzzzzzzzzzzzzx_);
                CqlDateTime izzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.earliest(context, izzzzzzzzzzzzzzzzzzzy_ as object);

                return izzzzzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzh_ = context.Operators.SortBy<Observation>(hzzzzzzzzzzzzzzzzzzzf_, hzzzzzzzzzzzzzzzzzzzg_, System.ComponentModel.ListSortDirection.Ascending);
            Observation hzzzzzzzzzzzzzzzzzzzi_ = context.Operators.First<Observation>(hzzzzzzzzzzzzzzzzzzzh_);
            DataType hzzzzzzzzzzzzzzzzzzzj_ = hzzzzzzzzzzzzzzzzzzzi_?.Value;
            object hzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzj_);
            IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? hzzzzzzzzzzzzzzzzzzzn_(Observation CreatinineLab)
            {
                Instant jzzzzzzzzzzzzzzzzzzza_ = CreatinineLab?.IssuedElement;
                DateTimeOffset? jzzzzzzzzzzzzzzzzzzzb_ = jzzzzzzzzzzzzzzzzzzza_?.Value;
                CqlDateTime jzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<CqlDateTime>(jzzzzzzzzzzzzzzzzzzzb_);
                CqlDateTime jzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.earliest(context, jzzzzzzzzzzzzzzzzzzzc_ as object);
                Period jzzzzzzzzzzzzzzzzzzze_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzzzze_);
                CqlDateTime jzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(jzzzzzzzzzzzzzzzzzzzf_);
                CqlQuantity jzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime jzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Subtract(jzzzzzzzzzzzzzzzzzzzg_, jzzzzzzzzzzzzzzzzzzzh_);
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzzzze_);
                CqlDateTime jzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(jzzzzzzzzzzzzzzzzzzzk_);
                CqlDateTime jzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Add(jzzzzzzzzzzzzzzzzzzzl_, jzzzzzzzzzzzzzzzzzzzh_);
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Interval(jzzzzzzzzzzzzzzzzzzzi_, jzzzzzzzzzzzzzzzzzzzn_, true, true);
                bool? jzzzzzzzzzzzzzzzzzzzp_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzzzzzzzzzzzd_, jzzzzzzzzzzzzzzzzzzzo_, default);
                Code<ObservationStatus> jzzzzzzzzzzzzzzzzzzzq_ = CreatinineLab?.StatusElement;
                ObservationStatus? jzzzzzzzzzzzzzzzzzzzr_ = jzzzzzzzzzzzzzzzzzzzq_?.Value;
                string jzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Convert<string>(jzzzzzzzzzzzzzzzzzzzr_);
                string[] jzzzzzzzzzzzzzzzzzzzt_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? jzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<string>(jzzzzzzzzzzzzzzzzzzzs_, jzzzzzzzzzzzzzzzzzzzt_ as IEnumerable<string>);
                bool? jzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzp_, jzzzzzzzzzzzzzzzzzzzu_);
                DataType jzzzzzzzzzzzzzzzzzzzw_ = CreatinineLab?.Value;
                object jzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzw_);
                bool? jzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Not((bool?)(jzzzzzzzzzzzzzzzzzzzx_ is null));
                bool? jzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzv_, jzzzzzzzzzzzzzzzzzzzy_);

                return jzzzzzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Observation>(hzzzzzzzzzzzzzzzzzzzm_, hzzzzzzzzzzzzzzzzzzzn_);
            object hzzzzzzzzzzzzzzzzzzzp_(Observation @this)
            {
                Instant kzzzzzzzzzzzzzzzzzzza_ = @this?.IssuedElement;
                DateTimeOffset? kzzzzzzzzzzzzzzzzzzzb_ = kzzzzzzzzzzzzzzzzzzza_?.Value;
                CqlDateTime kzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<CqlDateTime>(kzzzzzzzzzzzzzzzzzzzb_);
                CqlDateTime kzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.earliest(context, kzzzzzzzzzzzzzzzzzzzc_ as object);

                return kzzzzzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzq_ = context.Operators.SortBy<Observation>(hzzzzzzzzzzzzzzzzzzzo_, hzzzzzzzzzzzzzzzzzzzp_, System.ComponentModel.ListSortDirection.Ascending);
            Observation hzzzzzzzzzzzzzzzzzzzr_ = context.Operators.First<Observation>(hzzzzzzzzzzzzzzzzzzzq_);
            Instant hzzzzzzzzzzzzzzzzzzzs_ = hzzzzzzzzzzzzzzzzzzzr_?.IssuedElement;
            DateTimeOffset? hzzzzzzzzzzzzzzzzzzzt_ = hzzzzzzzzzzzzzzzzzzzs_?.Value;
            CqlDateTime hzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Convert<CqlDateTime>(hzzzzzzzzzzzzzzzzzzzt_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)? hzzzzzzzzzzzzzzzzzzzv_ = (CqlTupleMetadata_HDVhZFAYAdGHPZJWcDFSNFGPd, hzzzzzzzzzzzzzzzzzzzb_, hzzzzzzzzzzzzzzzzzzzk_ as CqlQuantity, hzzzzzzzzzzzzzzzzzzzu_);

            return hzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> gzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?>(gzzzzzzzzzzzzzzzzzzzw_, gzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> gzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?>(gzzzzzzzzzzzzzzzzzzzy_);

        return gzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Encounter with First Glucose Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> Encounter_with_First_Glucose_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzze_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)? kzzzzzzzzzzzzzzzzzzzf_(Encounter EncounterInpatient)
        {
            Id kzzzzzzzzzzzzzzzzzzzi_ = EncounterInpatient?.IdElement;
            string kzzzzzzzzzzzzzzzzzzzj_ = kzzzzzzzzzzzzzzzzzzzi_?.Value;
            CqlValueSet kzzzzzzzzzzzzzzzzzzzk_ = this.Glucose_lab_test(context);
            IEnumerable<Observation> kzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? kzzzzzzzzzzzzzzzzzzzm_(Observation GlucoseLab)
            {
                Instant lzzzzzzzzzzzzzzzzzzze_ = GlucoseLab?.IssuedElement;
                DateTimeOffset? lzzzzzzzzzzzzzzzzzzzf_ = lzzzzzzzzzzzzzzzzzzze_?.Value;
                CqlDateTime lzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<CqlDateTime>(lzzzzzzzzzzzzzzzzzzzf_);
                CqlDateTime lzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.earliest(context, lzzzzzzzzzzzzzzzzzzzg_ as object);
                Period lzzzzzzzzzzzzzzzzzzzi_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzzzzzzzzzzi_);
                CqlDateTime lzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzzzj_);
                CqlQuantity lzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime lzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Subtract(lzzzzzzzzzzzzzzzzzzzk_, lzzzzzzzzzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzzzzzzzzzzi_);
                CqlDateTime lzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzzzo_);
                CqlDateTime lzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Add(lzzzzzzzzzzzzzzzzzzzp_, lzzzzzzzzzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Interval(lzzzzzzzzzzzzzzzzzzzm_, lzzzzzzzzzzzzzzzzzzzr_, true, true);
                bool? lzzzzzzzzzzzzzzzzzzzt_ = context.Operators.In<CqlDateTime>(lzzzzzzzzzzzzzzzzzzzh_, lzzzzzzzzzzzzzzzzzzzs_, default);
                Code<ObservationStatus> lzzzzzzzzzzzzzzzzzzzu_ = GlucoseLab?.StatusElement;
                ObservationStatus? lzzzzzzzzzzzzzzzzzzzv_ = lzzzzzzzzzzzzzzzzzzzu_?.Value;
                string lzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<string>(lzzzzzzzzzzzzzzzzzzzv_);
                string[] lzzzzzzzzzzzzzzzzzzzx_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? lzzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<string>(lzzzzzzzzzzzzzzzzzzzw_, lzzzzzzzzzzzzzzzzzzzx_ as IEnumerable<string>);
                bool? lzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzt_, lzzzzzzzzzzzzzzzzzzzy_);
                DataType mzzzzzzzzzzzzzzzzzzza_ = GlucoseLab?.Value;
                object mzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzza_);
                bool? mzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Not((bool?)(mzzzzzzzzzzzzzzzzzzzb_ is null));
                bool? mzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzz_, mzzzzzzzzzzzzzzzzzzzc_);

                return mzzzzzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<Observation> kzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Observation>(kzzzzzzzzzzzzzzzzzzzl_, kzzzzzzzzzzzzzzzzzzzm_);
            object kzzzzzzzzzzzzzzzzzzzo_(Observation @this)
            {
                Instant mzzzzzzzzzzzzzzzzzzze_ = @this?.IssuedElement;
                DateTimeOffset? mzzzzzzzzzzzzzzzzzzzf_ = mzzzzzzzzzzzzzzzzzzze_?.Value;
                CqlDateTime mzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<CqlDateTime>(mzzzzzzzzzzzzzzzzzzzf_);
                CqlDateTime mzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.earliest(context, mzzzzzzzzzzzzzzzzzzzg_ as object);

                return mzzzzzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<Observation> kzzzzzzzzzzzzzzzzzzzp_ = context.Operators.SortBy<Observation>(kzzzzzzzzzzzzzzzzzzzn_, kzzzzzzzzzzzzzzzzzzzo_, System.ComponentModel.ListSortDirection.Ascending);
            Observation kzzzzzzzzzzzzzzzzzzzq_ = context.Operators.First<Observation>(kzzzzzzzzzzzzzzzzzzzp_);
            DataType kzzzzzzzzzzzzzzzzzzzr_ = kzzzzzzzzzzzzzzzzzzzq_?.Value;
            object kzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzr_);
            IEnumerable<Observation> kzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? kzzzzzzzzzzzzzzzzzzzv_(Observation GlucoseLab)
            {
                Instant mzzzzzzzzzzzzzzzzzzzi_ = GlucoseLab?.IssuedElement;
                DateTimeOffset? mzzzzzzzzzzzzzzzzzzzj_ = mzzzzzzzzzzzzzzzzzzzi_?.Value;
                CqlDateTime mzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<CqlDateTime>(mzzzzzzzzzzzzzzzzzzzj_);
                CqlDateTime mzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.earliest(context, mzzzzzzzzzzzzzzzzzzzk_ as object);
                Period mzzzzzzzzzzzzzzzzzzzm_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzzzzzzzzzzm_);
                CqlDateTime mzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzn_);
                CqlQuantity mzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime mzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Subtract(mzzzzzzzzzzzzzzzzzzzo_, mzzzzzzzzzzzzzzzzzzzp_);
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzzzzzzzzzzm_);
                CqlDateTime mzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzs_);
                CqlDateTime mzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Add(mzzzzzzzzzzzzzzzzzzzt_, mzzzzzzzzzzzzzzzzzzzp_);
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Interval(mzzzzzzzzzzzzzzzzzzzq_, mzzzzzzzzzzzzzzzzzzzv_, true, true);
                bool? mzzzzzzzzzzzzzzzzzzzx_ = context.Operators.In<CqlDateTime>(mzzzzzzzzzzzzzzzzzzzl_, mzzzzzzzzzzzzzzzzzzzw_, default);
                Code<ObservationStatus> mzzzzzzzzzzzzzzzzzzzy_ = GlucoseLab?.StatusElement;
                ObservationStatus? mzzzzzzzzzzzzzzzzzzzz_ = mzzzzzzzzzzzzzzzzzzzy_?.Value;
                string nzzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<string>(mzzzzzzzzzzzzzzzzzzzz_);
                string[] nzzzzzzzzzzzzzzzzzzzb_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? nzzzzzzzzzzzzzzzzzzzc_ = context.Operators.In<string>(nzzzzzzzzzzzzzzzzzzza_, nzzzzzzzzzzzzzzzzzzzb_ as IEnumerable<string>);
                bool? nzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzx_, nzzzzzzzzzzzzzzzzzzzc_);
                DataType nzzzzzzzzzzzzzzzzzzze_ = GlucoseLab?.Value;
                object nzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzze_);
                bool? nzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Not((bool?)(nzzzzzzzzzzzzzzzzzzzf_ is null));
                bool? nzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzd_, nzzzzzzzzzzzzzzzzzzzg_);

                return nzzzzzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<Observation> kzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Observation>(kzzzzzzzzzzzzzzzzzzzu_, kzzzzzzzzzzzzzzzzzzzv_);
            object kzzzzzzzzzzzzzzzzzzzx_(Observation @this)
            {
                Instant nzzzzzzzzzzzzzzzzzzzi_ = @this?.IssuedElement;
                DateTimeOffset? nzzzzzzzzzzzzzzzzzzzj_ = nzzzzzzzzzzzzzzzzzzzi_?.Value;
                CqlDateTime nzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<CqlDateTime>(nzzzzzzzzzzzzzzzzzzzj_);
                CqlDateTime nzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.earliest(context, nzzzzzzzzzzzzzzzzzzzk_ as object);

                return nzzzzzzzzzzzzzzzzzzzl_;
            };
            IEnumerable<Observation> kzzzzzzzzzzzzzzzzzzzy_ = context.Operators.SortBy<Observation>(kzzzzzzzzzzzzzzzzzzzw_, kzzzzzzzzzzzzzzzzzzzx_, System.ComponentModel.ListSortDirection.Ascending);
            Observation kzzzzzzzzzzzzzzzzzzzz_ = context.Operators.First<Observation>(kzzzzzzzzzzzzzzzzzzzy_);
            Instant lzzzzzzzzzzzzzzzzzzza_ = kzzzzzzzzzzzzzzzzzzzz_?.IssuedElement;
            DateTimeOffset? lzzzzzzzzzzzzzzzzzzzb_ = lzzzzzzzzzzzzzzzzzzza_?.Value;
            CqlDateTime lzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<CqlDateTime>(lzzzzzzzzzzzzzzzzzzzb_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)? lzzzzzzzzzzzzzzzzzzzd_ = (CqlTupleMetadata_HDVhZFAYAdGHPZJWcDFSNFGPd, kzzzzzzzzzzzzzzzzzzzj_, kzzzzzzzzzzzzzzzzzzzs_ as CqlQuantity, lzzzzzzzzzzzzzzzzzzzc_);

            return lzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> kzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?>(kzzzzzzzzzzzzzzzzzzze_, kzzzzzzzzzzzzzzzzzzzf_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> kzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?>(kzzzzzzzzzzzzzzzzzzzg_);

        return kzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Encounter with First Hematocrit Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> Encounter_with_First_Hematocrit_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzm_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)? nzzzzzzzzzzzzzzzzzzzn_(Encounter EncounterInpatient)
        {
            Id nzzzzzzzzzzzzzzzzzzzq_ = EncounterInpatient?.IdElement;
            string nzzzzzzzzzzzzzzzzzzzr_ = nzzzzzzzzzzzzzzzzzzzq_?.Value;
            CqlValueSet nzzzzzzzzzzzzzzzzzzzs_ = this.Hematocrit_lab_test(context);
            IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? nzzzzzzzzzzzzzzzzzzzu_(Observation HematocritLab)
            {
                Instant ozzzzzzzzzzzzzzzzzzzm_ = HematocritLab?.IssuedElement;
                DateTimeOffset? ozzzzzzzzzzzzzzzzzzzn_ = ozzzzzzzzzzzzzzzzzzzm_?.Value;
                CqlDateTime ozzzzzzzzzzzzzzzzzzzo_ = context.Operators.Convert<CqlDateTime>(ozzzzzzzzzzzzzzzzzzzn_);
                CqlDateTime ozzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.earliest(context, ozzzzzzzzzzzzzzzzzzzo_ as object);
                Period ozzzzzzzzzzzzzzzzzzzq_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzzzzzzzzzzzq_);
                CqlDateTime ozzzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzr_);
                CqlQuantity ozzzzzzzzzzzzzzzzzzzt_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime ozzzzzzzzzzzzzzzzzzzu_ = context.Operators.Subtract(ozzzzzzzzzzzzzzzzzzzs_, ozzzzzzzzzzzzzzzzzzzt_);
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzzzzzzzzzzzq_);
                CqlDateTime ozzzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzw_);
                CqlDateTime ozzzzzzzzzzzzzzzzzzzz_ = context.Operators.Add(ozzzzzzzzzzzzzzzzzzzx_, ozzzzzzzzzzzzzzzzzzzt_);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzza_ = context.Operators.Interval(ozzzzzzzzzzzzzzzzzzzu_, ozzzzzzzzzzzzzzzzzzzz_, true, true);
                bool? pzzzzzzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDateTime>(ozzzzzzzzzzzzzzzzzzzp_, pzzzzzzzzzzzzzzzzzzza_, default);
                Code<ObservationStatus> pzzzzzzzzzzzzzzzzzzzc_ = HematocritLab?.StatusElement;
                ObservationStatus? pzzzzzzzzzzzzzzzzzzzd_ = pzzzzzzzzzzzzzzzzzzzc_?.Value;
                string pzzzzzzzzzzzzzzzzzzze_ = context.Operators.Convert<string>(pzzzzzzzzzzzzzzzzzzzd_);
                string[] pzzzzzzzzzzzzzzzzzzzf_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? pzzzzzzzzzzzzzzzzzzzg_ = context.Operators.In<string>(pzzzzzzzzzzzzzzzzzzze_, pzzzzzzzzzzzzzzzzzzzf_ as IEnumerable<string>);
                bool? pzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzb_, pzzzzzzzzzzzzzzzzzzzg_);
                DataType pzzzzzzzzzzzzzzzzzzzi_ = HematocritLab?.Value;
                object pzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzi_);
                bool? pzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Not((bool?)(pzzzzzzzzzzzzzzzzzzzj_ is null));
                bool? pzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzh_, pzzzzzzzzzzzzzzzzzzzk_);

                return pzzzzzzzzzzzzzzzzzzzl_;
            };
            IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Observation>(nzzzzzzzzzzzzzzzzzzzt_, nzzzzzzzzzzzzzzzzzzzu_);
            object nzzzzzzzzzzzzzzzzzzzw_(Observation @this)
            {
                Instant pzzzzzzzzzzzzzzzzzzzm_ = @this?.IssuedElement;
                DateTimeOffset? pzzzzzzzzzzzzzzzzzzzn_ = pzzzzzzzzzzzzzzzzzzzm_?.Value;
                CqlDateTime pzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Convert<CqlDateTime>(pzzzzzzzzzzzzzzzzzzzn_);
                CqlDateTime pzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.earliest(context, pzzzzzzzzzzzzzzzzzzzo_ as object);

                return pzzzzzzzzzzzzzzzzzzzp_;
            };
            IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzx_ = context.Operators.SortBy<Observation>(nzzzzzzzzzzzzzzzzzzzv_, nzzzzzzzzzzzzzzzzzzzw_, System.ComponentModel.ListSortDirection.Ascending);
            Observation nzzzzzzzzzzzzzzzzzzzy_ = context.Operators.First<Observation>(nzzzzzzzzzzzzzzzzzzzx_);
            DataType nzzzzzzzzzzzzzzzzzzzz_ = nzzzzzzzzzzzzzzzzzzzy_?.Value;
            object ozzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzz_);
            IEnumerable<Observation> ozzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? ozzzzzzzzzzzzzzzzzzzd_(Observation HematocritLab)
            {
                Instant pzzzzzzzzzzzzzzzzzzzq_ = HematocritLab?.IssuedElement;
                DateTimeOffset? pzzzzzzzzzzzzzzzzzzzr_ = pzzzzzzzzzzzzzzzzzzzq_?.Value;
                CqlDateTime pzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Convert<CqlDateTime>(pzzzzzzzzzzzzzzzzzzzr_);
                CqlDateTime pzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.earliest(context, pzzzzzzzzzzzzzzzzzzzs_ as object);
                Period pzzzzzzzzzzzzzzzzzzzu_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzzzzzzzzzzzzzu_);
                CqlDateTime pzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(pzzzzzzzzzzzzzzzzzzzv_);
                CqlQuantity pzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime pzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Subtract(pzzzzzzzzzzzzzzzzzzzw_, pzzzzzzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzzzzzzzzzzzzzu_);
                CqlDateTime qzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(qzzzzzzzzzzzzzzzzzzza_);
                CqlDateTime qzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Add(qzzzzzzzzzzzzzzzzzzzb_, pzzzzzzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzze_ = context.Operators.Interval(pzzzzzzzzzzzzzzzzzzzy_, qzzzzzzzzzzzzzzzzzzzd_, true, true);
                bool? qzzzzzzzzzzzzzzzzzzzf_ = context.Operators.In<CqlDateTime>(pzzzzzzzzzzzzzzzzzzzt_, qzzzzzzzzzzzzzzzzzzze_, default);
                Code<ObservationStatus> qzzzzzzzzzzzzzzzzzzzg_ = HematocritLab?.StatusElement;
                ObservationStatus? qzzzzzzzzzzzzzzzzzzzh_ = qzzzzzzzzzzzzzzzzzzzg_?.Value;
                string qzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Convert<string>(qzzzzzzzzzzzzzzzzzzzh_);
                string[] qzzzzzzzzzzzzzzzzzzzj_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? qzzzzzzzzzzzzzzzzzzzk_ = context.Operators.In<string>(qzzzzzzzzzzzzzzzzzzzi_, qzzzzzzzzzzzzzzzzzzzj_ as IEnumerable<string>);
                bool? qzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzf_, qzzzzzzzzzzzzzzzzzzzk_);
                DataType qzzzzzzzzzzzzzzzzzzzm_ = HematocritLab?.Value;
                object qzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzm_);
                bool? qzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Not((bool?)(qzzzzzzzzzzzzzzzzzzzn_ is null));
                bool? qzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzl_, qzzzzzzzzzzzzzzzzzzzo_);

                return qzzzzzzzzzzzzzzzzzzzp_;
            };
            IEnumerable<Observation> ozzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Observation>(ozzzzzzzzzzzzzzzzzzzc_, ozzzzzzzzzzzzzzzzzzzd_);
            object ozzzzzzzzzzzzzzzzzzzf_(Observation @this)
            {
                Instant qzzzzzzzzzzzzzzzzzzzq_ = @this?.IssuedElement;
                DateTimeOffset? qzzzzzzzzzzzzzzzzzzzr_ = qzzzzzzzzzzzzzzzzzzzq_?.Value;
                CqlDateTime qzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Convert<CqlDateTime>(qzzzzzzzzzzzzzzzzzzzr_);
                CqlDateTime qzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.earliest(context, qzzzzzzzzzzzzzzzzzzzs_ as object);

                return qzzzzzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<Observation> ozzzzzzzzzzzzzzzzzzzg_ = context.Operators.SortBy<Observation>(ozzzzzzzzzzzzzzzzzzze_, ozzzzzzzzzzzzzzzzzzzf_, System.ComponentModel.ListSortDirection.Ascending);
            Observation ozzzzzzzzzzzzzzzzzzzh_ = context.Operators.First<Observation>(ozzzzzzzzzzzzzzzzzzzg_);
            Instant ozzzzzzzzzzzzzzzzzzzi_ = ozzzzzzzzzzzzzzzzzzzh_?.IssuedElement;
            DateTimeOffset? ozzzzzzzzzzzzzzzzzzzj_ = ozzzzzzzzzzzzzzzzzzzi_?.Value;
            CqlDateTime ozzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<CqlDateTime>(ozzzzzzzzzzzzzzzzzzzj_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)? ozzzzzzzzzzzzzzzzzzzl_ = (CqlTupleMetadata_HDVhZFAYAdGHPZJWcDFSNFGPd, nzzzzzzzzzzzzzzzzzzzr_, ozzzzzzzzzzzzzzzzzzza_ as CqlQuantity, ozzzzzzzzzzzzzzzzzzzk_);

            return ozzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> nzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?>(nzzzzzzzzzzzzzzzzzzzm_, nzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> nzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?>(nzzzzzzzzzzzzzzzzzzzo_);

        return nzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Encounter with First Potassium Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> Encounter_with_First_Potassium_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzu_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)? qzzzzzzzzzzzzzzzzzzzv_(Encounter EncounterInpatient)
        {
            Id qzzzzzzzzzzzzzzzzzzzy_ = EncounterInpatient?.IdElement;
            string qzzzzzzzzzzzzzzzzzzzz_ = qzzzzzzzzzzzzzzzzzzzy_?.Value;
            CqlValueSet rzzzzzzzzzzzzzzzzzzza_ = this.Potassium_lab_test(context);
            IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? rzzzzzzzzzzzzzzzzzzzc_(Observation PotassiumLab)
            {
                Instant rzzzzzzzzzzzzzzzzzzzu_ = PotassiumLab?.IssuedElement;
                DateTimeOffset? rzzzzzzzzzzzzzzzzzzzv_ = rzzzzzzzzzzzzzzzzzzzu_?.Value;
                CqlDateTime rzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzv_);
                CqlDateTime rzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.earliest(context, rzzzzzzzzzzzzzzzzzzzw_ as object);
                Period rzzzzzzzzzzzzzzzzzzzy_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzzzzzzzzzzzy_);
                CqlDateTime szzzzzzzzzzzzzzzzzzza_ = context.Operators.Start(rzzzzzzzzzzzzzzzzzzzz_);
                CqlQuantity szzzzzzzzzzzzzzzzzzzb_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime szzzzzzzzzzzzzzzzzzzc_ = context.Operators.Subtract(szzzzzzzzzzzzzzzzzzza_, szzzzzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzzzzzzzzzzzy_);
                CqlDateTime szzzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(szzzzzzzzzzzzzzzzzzze_);
                CqlDateTime szzzzzzzzzzzzzzzzzzzh_ = context.Operators.Add(szzzzzzzzzzzzzzzzzzzf_, szzzzzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzi_ = context.Operators.Interval(szzzzzzzzzzzzzzzzzzzc_, szzzzzzzzzzzzzzzzzzzh_, true, true);
                bool? szzzzzzzzzzzzzzzzzzzj_ = context.Operators.In<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzx_, szzzzzzzzzzzzzzzzzzzi_, default);
                Code<ObservationStatus> szzzzzzzzzzzzzzzzzzzk_ = PotassiumLab?.StatusElement;
                ObservationStatus? szzzzzzzzzzzzzzzzzzzl_ = szzzzzzzzzzzzzzzzzzzk_?.Value;
                string szzzzzzzzzzzzzzzzzzzm_ = context.Operators.Convert<string>(szzzzzzzzzzzzzzzzzzzl_);
                string[] szzzzzzzzzzzzzzzzzzzn_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? szzzzzzzzzzzzzzzzzzzo_ = context.Operators.In<string>(szzzzzzzzzzzzzzzzzzzm_, szzzzzzzzzzzzzzzzzzzn_ as IEnumerable<string>);
                bool? szzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzj_, szzzzzzzzzzzzzzzzzzzo_);
                DataType szzzzzzzzzzzzzzzzzzzq_ = PotassiumLab?.Value;
                object szzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzq_);
                bool? szzzzzzzzzzzzzzzzzzzs_ = context.Operators.Not((bool?)(szzzzzzzzzzzzzzzzzzzr_ is null));
                bool? szzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzp_, szzzzzzzzzzzzzzzzzzzs_);

                return szzzzzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Observation>(rzzzzzzzzzzzzzzzzzzzb_, rzzzzzzzzzzzzzzzzzzzc_);
            object rzzzzzzzzzzzzzzzzzzze_(Observation @this)
            {
                Instant szzzzzzzzzzzzzzzzzzzu_ = @this?.IssuedElement;
                DateTimeOffset? szzzzzzzzzzzzzzzzzzzv_ = szzzzzzzzzzzzzzzzzzzu_?.Value;
                CqlDateTime szzzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<CqlDateTime>(szzzzzzzzzzzzzzzzzzzv_);
                CqlDateTime szzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.earliest(context, szzzzzzzzzzzzzzzzzzzw_ as object);

                return szzzzzzzzzzzzzzzzzzzx_;
            };
            IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzf_ = context.Operators.SortBy<Observation>(rzzzzzzzzzzzzzzzzzzzd_, rzzzzzzzzzzzzzzzzzzze_, System.ComponentModel.ListSortDirection.Ascending);
            Observation rzzzzzzzzzzzzzzzzzzzg_ = context.Operators.First<Observation>(rzzzzzzzzzzzzzzzzzzzf_);
            DataType rzzzzzzzzzzzzzzzzzzzh_ = rzzzzzzzzzzzzzzzzzzzg_?.Value;
            object rzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzh_);
            IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? rzzzzzzzzzzzzzzzzzzzl_(Observation PotassiumLab)
            {
                Instant szzzzzzzzzzzzzzzzzzzy_ = PotassiumLab?.IssuedElement;
                DateTimeOffset? szzzzzzzzzzzzzzzzzzzz_ = szzzzzzzzzzzzzzzzzzzy_?.Value;
                CqlDateTime tzzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<CqlDateTime>(szzzzzzzzzzzzzzzzzzzz_);
                CqlDateTime tzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.earliest(context, tzzzzzzzzzzzzzzzzzzza_ as object);
                Period tzzzzzzzzzzzzzzzzzzzc_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzzzzzzzzzzzzzc_);
                CqlDateTime tzzzzzzzzzzzzzzzzzzze_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzzzd_);
                CqlQuantity tzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime tzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Subtract(tzzzzzzzzzzzzzzzzzzze_, tzzzzzzzzzzzzzzzzzzzf_);
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzzzzzzzzzzzzzc_);
                CqlDateTime tzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzzzi_);
                CqlDateTime tzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Add(tzzzzzzzzzzzzzzzzzzzj_, tzzzzzzzzzzzzzzzzzzzf_);
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Interval(tzzzzzzzzzzzzzzzzzzzg_, tzzzzzzzzzzzzzzzzzzzl_, true, true);
                bool? tzzzzzzzzzzzzzzzzzzzn_ = context.Operators.In<CqlDateTime>(tzzzzzzzzzzzzzzzzzzzb_, tzzzzzzzzzzzzzzzzzzzm_, default);
                Code<ObservationStatus> tzzzzzzzzzzzzzzzzzzzo_ = PotassiumLab?.StatusElement;
                ObservationStatus? tzzzzzzzzzzzzzzzzzzzp_ = tzzzzzzzzzzzzzzzzzzzo_?.Value;
                string tzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<string>(tzzzzzzzzzzzzzzzzzzzp_);
                string[] tzzzzzzzzzzzzzzzzzzzr_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? tzzzzzzzzzzzzzzzzzzzs_ = context.Operators.In<string>(tzzzzzzzzzzzzzzzzzzzq_, tzzzzzzzzzzzzzzzzzzzr_ as IEnumerable<string>);
                bool? tzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzn_, tzzzzzzzzzzzzzzzzzzzs_);
                DataType tzzzzzzzzzzzzzzzzzzzu_ = PotassiumLab?.Value;
                object tzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzu_);
                bool? tzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Not((bool?)(tzzzzzzzzzzzzzzzzzzzv_ is null));
                bool? tzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzt_, tzzzzzzzzzzzzzzzzzzzw_);

                return tzzzzzzzzzzzzzzzzzzzx_;
            };
            IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Observation>(rzzzzzzzzzzzzzzzzzzzk_, rzzzzzzzzzzzzzzzzzzzl_);
            object rzzzzzzzzzzzzzzzzzzzn_(Observation @this)
            {
                Instant tzzzzzzzzzzzzzzzzzzzy_ = @this?.IssuedElement;
                DateTimeOffset? tzzzzzzzzzzzzzzzzzzzz_ = tzzzzzzzzzzzzzzzzzzzy_?.Value;
                CqlDateTime uzzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<CqlDateTime>(tzzzzzzzzzzzzzzzzzzzz_);
                CqlDateTime uzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.earliest(context, uzzzzzzzzzzzzzzzzzzza_ as object);

                return uzzzzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzo_ = context.Operators.SortBy<Observation>(rzzzzzzzzzzzzzzzzzzzm_, rzzzzzzzzzzzzzzzzzzzn_, System.ComponentModel.ListSortDirection.Ascending);
            Observation rzzzzzzzzzzzzzzzzzzzp_ = context.Operators.First<Observation>(rzzzzzzzzzzzzzzzzzzzo_);
            Instant rzzzzzzzzzzzzzzzzzzzq_ = rzzzzzzzzzzzzzzzzzzzp_?.IssuedElement;
            DateTimeOffset? rzzzzzzzzzzzzzzzzzzzr_ = rzzzzzzzzzzzzzzzzzzzq_?.Value;
            CqlDateTime rzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Convert<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzr_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)? rzzzzzzzzzzzzzzzzzzzt_ = (CqlTupleMetadata_HDVhZFAYAdGHPZJWcDFSNFGPd, qzzzzzzzzzzzzzzzzzzzz_, rzzzzzzzzzzzzzzzzzzzi_ as CqlQuantity, rzzzzzzzzzzzzzzzzzzzs_);

            return rzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> qzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?>(qzzzzzzzzzzzzzzzzzzzu_, qzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> qzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?>(qzzzzzzzzzzzzzzzzzzzw_);

        return qzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Encounter with First Sodium Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> Encounter_with_First_Sodium_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzc_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)? uzzzzzzzzzzzzzzzzzzzd_(Encounter EncounterInpatient)
        {
            Id uzzzzzzzzzzzzzzzzzzzg_ = EncounterInpatient?.IdElement;
            string uzzzzzzzzzzzzzzzzzzzh_ = uzzzzzzzzzzzzzzzzzzzg_?.Value;
            CqlValueSet uzzzzzzzzzzzzzzzzzzzi_ = this.Sodium_lab_test(context);
            IEnumerable<Observation> uzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? uzzzzzzzzzzzzzzzzzzzk_(Observation SodiumLab)
            {
                Instant vzzzzzzzzzzzzzzzzzzzc_ = SodiumLab?.IssuedElement;
                DateTimeOffset? vzzzzzzzzzzzzzzzzzzzd_ = vzzzzzzzzzzzzzzzzzzzc_?.Value;
                CqlDateTime vzzzzzzzzzzzzzzzzzzze_ = context.Operators.Convert<CqlDateTime>(vzzzzzzzzzzzzzzzzzzzd_);
                CqlDateTime vzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.earliest(context, vzzzzzzzzzzzzzzzzzzze_ as object);
                Period vzzzzzzzzzzzzzzzzzzzg_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzzzzzzzzzzzzg_);
                CqlDateTime vzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Start(vzzzzzzzzzzzzzzzzzzzh_);
                CqlQuantity vzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime vzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Subtract(vzzzzzzzzzzzzzzzzzzzi_, vzzzzzzzzzzzzzzzzzzzj_);
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzzzzzzzzzzzzg_);
                CqlDateTime vzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(vzzzzzzzzzzzzzzzzzzzm_);
                CqlDateTime vzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Add(vzzzzzzzzzzzzzzzzzzzn_, vzzzzzzzzzzzzzzzzzzzj_);
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Interval(vzzzzzzzzzzzzzzzzzzzk_, vzzzzzzzzzzzzzzzzzzzp_, true, true);
                bool? vzzzzzzzzzzzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(vzzzzzzzzzzzzzzzzzzzf_, vzzzzzzzzzzzzzzzzzzzq_, default);
                Code<ObservationStatus> vzzzzzzzzzzzzzzzzzzzs_ = SodiumLab?.StatusElement;
                ObservationStatus? vzzzzzzzzzzzzzzzzzzzt_ = vzzzzzzzzzzzzzzzzzzzs_?.Value;
                string vzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Convert<string>(vzzzzzzzzzzzzzzzzzzzt_);
                string[] vzzzzzzzzzzzzzzzzzzzv_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? vzzzzzzzzzzzzzzzzzzzw_ = context.Operators.In<string>(vzzzzzzzzzzzzzzzzzzzu_, vzzzzzzzzzzzzzzzzzzzv_ as IEnumerable<string>);
                bool? vzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzr_, vzzzzzzzzzzzzzzzzzzzw_);
                DataType vzzzzzzzzzzzzzzzzzzzy_ = SodiumLab?.Value;
                object vzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzy_);
                bool? wzzzzzzzzzzzzzzzzzzza_ = context.Operators.Not((bool?)(vzzzzzzzzzzzzzzzzzzzz_ is null));
                bool? wzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzx_, wzzzzzzzzzzzzzzzzzzza_);

                return wzzzzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<Observation> uzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Observation>(uzzzzzzzzzzzzzzzzzzzj_, uzzzzzzzzzzzzzzzzzzzk_);
            object uzzzzzzzzzzzzzzzzzzzm_(Observation @this)
            {
                Instant wzzzzzzzzzzzzzzzzzzzc_ = @this?.IssuedElement;
                DateTimeOffset? wzzzzzzzzzzzzzzzzzzzd_ = wzzzzzzzzzzzzzzzzzzzc_?.Value;
                CqlDateTime wzzzzzzzzzzzzzzzzzzze_ = context.Operators.Convert<CqlDateTime>(wzzzzzzzzzzzzzzzzzzzd_);
                CqlDateTime wzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.earliest(context, wzzzzzzzzzzzzzzzzzzze_ as object);

                return wzzzzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<Observation> uzzzzzzzzzzzzzzzzzzzn_ = context.Operators.SortBy<Observation>(uzzzzzzzzzzzzzzzzzzzl_, uzzzzzzzzzzzzzzzzzzzm_, System.ComponentModel.ListSortDirection.Ascending);
            Observation uzzzzzzzzzzzzzzzzzzzo_ = context.Operators.First<Observation>(uzzzzzzzzzzzzzzzzzzzn_);
            DataType uzzzzzzzzzzzzzzzzzzzp_ = uzzzzzzzzzzzzzzzzzzzo_?.Value;
            object uzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzp_);
            IEnumerable<Observation> uzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? uzzzzzzzzzzzzzzzzzzzt_(Observation SodiumLab)
            {
                Instant wzzzzzzzzzzzzzzzzzzzg_ = SodiumLab?.IssuedElement;
                DateTimeOffset? wzzzzzzzzzzzzzzzzzzzh_ = wzzzzzzzzzzzzzzzzzzzg_?.Value;
                CqlDateTime wzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Convert<CqlDateTime>(wzzzzzzzzzzzzzzzzzzzh_);
                CqlDateTime wzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.earliest(context, wzzzzzzzzzzzzzzzzzzzi_ as object);
                Period wzzzzzzzzzzzzzzzzzzzk_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzzzzzzzzzzzk_);
                CqlDateTime wzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(wzzzzzzzzzzzzzzzzzzzl_);
                CqlQuantity wzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime wzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Subtract(wzzzzzzzzzzzzzzzzzzzm_, wzzzzzzzzzzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzzzzzzzzzzzk_);
                CqlDateTime wzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Start(wzzzzzzzzzzzzzzzzzzzq_);
                CqlDateTime wzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Add(wzzzzzzzzzzzzzzzzzzzr_, wzzzzzzzzzzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Interval(wzzzzzzzzzzzzzzzzzzzo_, wzzzzzzzzzzzzzzzzzzzt_, true, true);
                bool? wzzzzzzzzzzzzzzzzzzzv_ = context.Operators.In<CqlDateTime>(wzzzzzzzzzzzzzzzzzzzj_, wzzzzzzzzzzzzzzzzzzzu_, default);
                Code<ObservationStatus> wzzzzzzzzzzzzzzzzzzzw_ = SodiumLab?.StatusElement;
                ObservationStatus? wzzzzzzzzzzzzzzzzzzzx_ = wzzzzzzzzzzzzzzzzzzzw_?.Value;
                string wzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<string>(wzzzzzzzzzzzzzzzzzzzx_);
                string[] wzzzzzzzzzzzzzzzzzzzz_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? xzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<string>(wzzzzzzzzzzzzzzzzzzzy_, wzzzzzzzzzzzzzzzzzzzz_ as IEnumerable<string>);
                bool? xzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzv_, xzzzzzzzzzzzzzzzzzzza_);
                DataType xzzzzzzzzzzzzzzzzzzzc_ = SodiumLab?.Value;
                object xzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzc_);
                bool? xzzzzzzzzzzzzzzzzzzze_ = context.Operators.Not((bool?)(xzzzzzzzzzzzzzzzzzzzd_ is null));
                bool? xzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzb_, xzzzzzzzzzzzzzzzzzzze_);

                return xzzzzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<Observation> uzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Observation>(uzzzzzzzzzzzzzzzzzzzs_, uzzzzzzzzzzzzzzzzzzzt_);
            object uzzzzzzzzzzzzzzzzzzzv_(Observation @this)
            {
                Instant xzzzzzzzzzzzzzzzzzzzg_ = @this?.IssuedElement;
                DateTimeOffset? xzzzzzzzzzzzzzzzzzzzh_ = xzzzzzzzzzzzzzzzzzzzg_?.Value;
                CqlDateTime xzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Convert<CqlDateTime>(xzzzzzzzzzzzzzzzzzzzh_);
                CqlDateTime xzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.earliest(context, xzzzzzzzzzzzzzzzzzzzi_ as object);

                return xzzzzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<Observation> uzzzzzzzzzzzzzzzzzzzw_ = context.Operators.SortBy<Observation>(uzzzzzzzzzzzzzzzzzzzu_, uzzzzzzzzzzzzzzzzzzzv_, System.ComponentModel.ListSortDirection.Ascending);
            Observation uzzzzzzzzzzzzzzzzzzzx_ = context.Operators.First<Observation>(uzzzzzzzzzzzzzzzzzzzw_);
            Instant uzzzzzzzzzzzzzzzzzzzy_ = uzzzzzzzzzzzzzzzzzzzx_?.IssuedElement;
            DateTimeOffset? uzzzzzzzzzzzzzzzzzzzz_ = uzzzzzzzzzzzzzzzzzzzy_?.Value;
            CqlDateTime vzzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<CqlDateTime>(uzzzzzzzzzzzzzzzzzzzz_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)? vzzzzzzzzzzzzzzzzzzzb_ = (CqlTupleMetadata_HDVhZFAYAdGHPZJWcDFSNFGPd, uzzzzzzzzzzzzzzzzzzzh_, uzzzzzzzzzzzzzzzzzzzq_ as CqlQuantity, vzzzzzzzzzzzzzzzzzzza_);

            return vzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> uzzzzzzzzzzzzzzzzzzze_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?>(uzzzzzzzzzzzzzzzzzzzc_, uzzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> uzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?>(uzzzzzzzzzzzzzzzzzzze_);

        return uzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Encounter with First White Blood Cells Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> Encounter_with_First_White_Blood_Cells_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzk_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)? xzzzzzzzzzzzzzzzzzzzl_(Encounter EncounterInpatient)
        {
            Id xzzzzzzzzzzzzzzzzzzzo_ = EncounterInpatient?.IdElement;
            string xzzzzzzzzzzzzzzzzzzzp_ = xzzzzzzzzzzzzzzzzzzzo_?.Value;
            CqlValueSet xzzzzzzzzzzzzzzzzzzzq_ = this.White_blood_cells_count_lab_test(context);
            IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? xzzzzzzzzzzzzzzzzzzzs_(Observation WhiteBloodCellLab)
            {
                Instant yzzzzzzzzzzzzzzzzzzzk_ = WhiteBloodCellLab?.IssuedElement;
                DateTimeOffset? yzzzzzzzzzzzzzzzzzzzl_ = yzzzzzzzzzzzzzzzzzzzk_?.Value;
                CqlDateTime yzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Convert<CqlDateTime>(yzzzzzzzzzzzzzzzzzzzl_);
                CqlDateTime yzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.earliest(context, yzzzzzzzzzzzzzzzzzzzm_ as object);
                Period yzzzzzzzzzzzzzzzzzzzo_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzzzzzzzzzzzzzo_);
                CqlDateTime yzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzzzp_);
                CqlQuantity yzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime yzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Subtract(yzzzzzzzzzzzzzzzzzzzq_, yzzzzzzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzzzzzzzzzzzzzo_);
                CqlDateTime yzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzzzu_);
                CqlDateTime yzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Add(yzzzzzzzzzzzzzzzzzzzv_, yzzzzzzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Interval(yzzzzzzzzzzzzzzzzzzzs_, yzzzzzzzzzzzzzzzzzzzx_, true, true);
                bool? yzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<CqlDateTime>(yzzzzzzzzzzzzzzzzzzzn_, yzzzzzzzzzzzzzzzzzzzy_, default);
                Code<ObservationStatus> zzzzzzzzzzzzzzzzzzzza_ = WhiteBloodCellLab?.StatusElement;
                ObservationStatus? zzzzzzzzzzzzzzzzzzzzb_ = zzzzzzzzzzzzzzzzzzzza_?.Value;
                string zzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<string>(zzzzzzzzzzzzzzzzzzzzb_);
                string[] zzzzzzzzzzzzzzzzzzzzd_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? zzzzzzzzzzzzzzzzzzzze_ = context.Operators.In<string>(zzzzzzzzzzzzzzzzzzzzc_, zzzzzzzzzzzzzzzzzzzzd_ as IEnumerable<string>);
                bool? zzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzz_, zzzzzzzzzzzzzzzzzzzze_);
                DataType zzzzzzzzzzzzzzzzzzzzg_ = WhiteBloodCellLab?.Value;
                object zzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzg_);
                bool? zzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Not((bool?)(zzzzzzzzzzzzzzzzzzzzh_ is null));
                bool? zzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzf_, zzzzzzzzzzzzzzzzzzzzi_);

                return zzzzzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Observation>(xzzzzzzzzzzzzzzzzzzzr_, xzzzzzzzzzzzzzzzzzzzs_);
            object xzzzzzzzzzzzzzzzzzzzu_(Observation @this)
            {
                Instant zzzzzzzzzzzzzzzzzzzzk_ = @this?.IssuedElement;
                DateTimeOffset? zzzzzzzzzzzzzzzzzzzzl_ = zzzzzzzzzzzzzzzzzzzzk_?.Value;
                CqlDateTime zzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Convert<CqlDateTime>(zzzzzzzzzzzzzzzzzzzzl_);
                CqlDateTime zzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.earliest(context, zzzzzzzzzzzzzzzzzzzzm_ as object);

                return zzzzzzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzv_ = context.Operators.SortBy<Observation>(xzzzzzzzzzzzzzzzzzzzt_, xzzzzzzzzzzzzzzzzzzzu_, System.ComponentModel.ListSortDirection.Ascending);
            Observation xzzzzzzzzzzzzzzzzzzzw_ = context.Operators.First<Observation>(xzzzzzzzzzzzzzzzzzzzv_);
            DataType xzzzzzzzzzzzzzzzzzzzx_ = xzzzzzzzzzzzzzzzzzzzw_?.Value;
            object xzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzx_);
            IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? yzzzzzzzzzzzzzzzzzzzb_(Observation WhiteBloodCellLab)
            {
                Instant zzzzzzzzzzzzzzzzzzzzo_ = WhiteBloodCellLab?.IssuedElement;
                DateTimeOffset? zzzzzzzzzzzzzzzzzzzzp_ = zzzzzzzzzzzzzzzzzzzzo_?.Value;
                CqlDateTime zzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<CqlDateTime>(zzzzzzzzzzzzzzzzzzzzp_);
                CqlDateTime zzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.earliest(context, zzzzzzzzzzzzzzzzzzzzq_ as object);
                Period zzzzzzzzzzzzzzzzzzzzs_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzzzzzzzzs_);
                CqlDateTime zzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(zzzzzzzzzzzzzzzzzzzzt_);
                CqlQuantity zzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime zzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Subtract(zzzzzzzzzzzzzzzzzzzzu_, zzzzzzzzzzzzzzzzzzzzv_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzzzzzzzzs_);
                CqlDateTime zzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Start(zzzzzzzzzzzzzzzzzzzzy_);
                CqlDateTime azzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Add(zzzzzzzzzzzzzzzzzzzzz_, zzzzzzzzzzzzzzzzzzzzv_);
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Interval(zzzzzzzzzzzzzzzzzzzzw_, azzzzzzzzzzzzzzzzzzzzb_, true, true);
                bool? azzzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(zzzzzzzzzzzzzzzzzzzzr_, azzzzzzzzzzzzzzzzzzzzc_, default);
                Code<ObservationStatus> azzzzzzzzzzzzzzzzzzzze_ = WhiteBloodCellLab?.StatusElement;
                ObservationStatus? azzzzzzzzzzzzzzzzzzzzf_ = azzzzzzzzzzzzzzzzzzzze_?.Value;
                string azzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<string>(azzzzzzzzzzzzzzzzzzzzf_);
                string[] azzzzzzzzzzzzzzzzzzzzh_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? azzzzzzzzzzzzzzzzzzzzi_ = context.Operators.In<string>(azzzzzzzzzzzzzzzzzzzzg_, azzzzzzzzzzzzzzzzzzzzh_ as IEnumerable<string>);
                bool? azzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzzd_, azzzzzzzzzzzzzzzzzzzzi_);
                DataType azzzzzzzzzzzzzzzzzzzzk_ = WhiteBloodCellLab?.Value;
                object azzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzk_);
                bool? azzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Not((bool?)(azzzzzzzzzzzzzzzzzzzzl_ is null));
                bool? azzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzzj_, azzzzzzzzzzzzzzzzzzzzm_);

                return azzzzzzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Observation>(yzzzzzzzzzzzzzzzzzzza_, yzzzzzzzzzzzzzzzzzzzb_);
            object yzzzzzzzzzzzzzzzzzzzd_(Observation @this)
            {
                Instant azzzzzzzzzzzzzzzzzzzzo_ = @this?.IssuedElement;
                DateTimeOffset? azzzzzzzzzzzzzzzzzzzzp_ = azzzzzzzzzzzzzzzzzzzzo_?.Value;
                CqlDateTime azzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<CqlDateTime>(azzzzzzzzzzzzzzzzzzzzp_);
                CqlDateTime azzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.earliest(context, azzzzzzzzzzzzzzzzzzzzq_ as object);

                return azzzzzzzzzzzzzzzzzzzzr_;
            };
            IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzze_ = context.Operators.SortBy<Observation>(yzzzzzzzzzzzzzzzzzzzc_, yzzzzzzzzzzzzzzzzzzzd_, System.ComponentModel.ListSortDirection.Ascending);
            Observation yzzzzzzzzzzzzzzzzzzzf_ = context.Operators.First<Observation>(yzzzzzzzzzzzzzzzzzzze_);
            Instant yzzzzzzzzzzzzzzzzzzzg_ = yzzzzzzzzzzzzzzzzzzzf_?.IssuedElement;
            DateTimeOffset? yzzzzzzzzzzzzzzzzzzzh_ = yzzzzzzzzzzzzzzzzzzzg_?.Value;
            CqlDateTime yzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Convert<CqlDateTime>(yzzzzzzzzzzzzzzzzzzzh_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)? yzzzzzzzzzzzzzzzzzzzj_ = (CqlTupleMetadata_HDVhZFAYAdGHPZJWcDFSNFGPd, xzzzzzzzzzzzzzzzzzzzp_, xzzzzzzzzzzzzzzzzzzzy_ as CqlQuantity, yzzzzzzzzzzzzzzzzzzzi_);

            return yzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> xzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?>(xzzzzzzzzzzzzzzzzzzzk_, xzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> xzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?>(xzzzzzzzzzzzzzzzzzzzm_);

        return xzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Encounter with First Weight Recorded During Stay")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> Encounter_with_First_Weight_Recorded_During_Stay(CqlContext context)
    {
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzs_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)? azzzzzzzzzzzzzzzzzzzzt_(Encounter EncounterInpatient)
        {
            Id azzzzzzzzzzzzzzzzzzzzw_ = EncounterInpatient?.IdElement;
            string azzzzzzzzzzzzzzzzzzzzx_ = azzzzzzzzzzzzzzzzzzzzw_?.Value;
            IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bodyweight"));
            bool? azzzzzzzzzzzzzzzzzzzzz_(Observation WeightExam)
            {
                DataType bzzzzzzzzzzzzzzzzzzzzq_ = WeightExam?.Effective;
                object bzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzq_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.earliest(context, bzzzzzzzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzt_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? bzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzs_, bzzzzzzzzzzzzzzzzzzzzt_, default);
                Code<ObservationStatus> bzzzzzzzzzzzzzzzzzzzzv_ = WeightExam?.StatusElement;
                ObservationStatus? bzzzzzzzzzzzzzzzzzzzzw_ = bzzzzzzzzzzzzzzzzzzzzv_?.Value;
                string bzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<string>(bzzzzzzzzzzzzzzzzzzzzw_);
                string[] bzzzzzzzzzzzzzzzzzzzzy_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? bzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<string>(bzzzzzzzzzzzzzzzzzzzzx_, bzzzzzzzzzzzzzzzzzzzzy_ as IEnumerable<string>);
                bool? czzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzu_, bzzzzzzzzzzzzzzzzzzzzz_);
                DataType czzzzzzzzzzzzzzzzzzzzb_ = WeightExam?.Value;
                CqlQuantity czzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, czzzzzzzzzzzzzzzzzzzzb_ as Quantity);
                bool? czzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Not((bool?)(czzzzzzzzzzzzzzzzzzzzc_ is null));
                bool? czzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzza_, czzzzzzzzzzzzzzzzzzzzd_);

                return czzzzzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Observation>(azzzzzzzzzzzzzzzzzzzzy_, azzzzzzzzzzzzzzzzzzzzz_);
            object bzzzzzzzzzzzzzzzzzzzzb_(Observation @this)
            {
                DataType czzzzzzzzzzzzzzzzzzzzf_ = @this?.Effective;
                object czzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzf_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.earliest(context, czzzzzzzzzzzzzzzzzzzzg_);

                return czzzzzzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.SortBy<Observation>(bzzzzzzzzzzzzzzzzzzzza_, bzzzzzzzzzzzzzzzzzzzzb_, System.ComponentModel.ListSortDirection.Ascending);
            Observation bzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.First<Observation>(bzzzzzzzzzzzzzzzzzzzzc_);
            DataType bzzzzzzzzzzzzzzzzzzzze_ = bzzzzzzzzzzzzzzzzzzzzd_?.Value;
            CqlQuantity bzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, bzzzzzzzzzzzzzzzzzzzze_ as Quantity);
            bool? bzzzzzzzzzzzzzzzzzzzzh_(Observation WeightExam)
            {
                DataType czzzzzzzzzzzzzzzzzzzzi_ = WeightExam?.Effective;
                object czzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzi_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.earliest(context, czzzzzzzzzzzzzzzzzzzzj_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzl_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? czzzzzzzzzzzzzzzzzzzzm_ = context.Operators.In<CqlDateTime>(czzzzzzzzzzzzzzzzzzzzk_, czzzzzzzzzzzzzzzzzzzzl_, default);
                Code<ObservationStatus> czzzzzzzzzzzzzzzzzzzzn_ = WeightExam?.StatusElement;
                ObservationStatus? czzzzzzzzzzzzzzzzzzzzo_ = czzzzzzzzzzzzzzzzzzzzn_?.Value;
                string czzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Convert<string>(czzzzzzzzzzzzzzzzzzzzo_);
                string[] czzzzzzzzzzzzzzzzzzzzq_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? czzzzzzzzzzzzzzzzzzzzr_ = context.Operators.In<string>(czzzzzzzzzzzzzzzzzzzzp_, czzzzzzzzzzzzzzzzzzzzq_ as IEnumerable<string>);
                bool? czzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzm_, czzzzzzzzzzzzzzzzzzzzr_);
                DataType czzzzzzzzzzzzzzzzzzzzt_ = WeightExam?.Value;
                CqlQuantity czzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, czzzzzzzzzzzzzzzzzzzzt_ as Quantity);
                bool? czzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Not((bool?)(czzzzzzzzzzzzzzzzzzzzu_ is null));
                bool? czzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzs_, czzzzzzzzzzzzzzzzzzzzv_);

                return czzzzzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Observation>(azzzzzzzzzzzzzzzzzzzzy_, bzzzzzzzzzzzzzzzzzzzzh_);
            object bzzzzzzzzzzzzzzzzzzzzj_(Observation @this)
            {
                DataType czzzzzzzzzzzzzzzzzzzzx_ = @this?.Effective;
                object czzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzx_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.earliest(context, czzzzzzzzzzzzzzzzzzzzy_);

                return czzzzzzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.SortBy<Observation>(bzzzzzzzzzzzzzzzzzzzzi_, bzzzzzzzzzzzzzzzzzzzzj_, System.ComponentModel.ListSortDirection.Ascending);
            Observation bzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.First<Observation>(bzzzzzzzzzzzzzzzzzzzzk_);
            DataType bzzzzzzzzzzzzzzzzzzzzm_ = bzzzzzzzzzzzzzzzzzzzzl_?.Effective;
            object bzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzm_);
            CqlDateTime bzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.earliest(context, bzzzzzzzzzzzzzzzzzzzzn_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)? bzzzzzzzzzzzzzzzzzzzzp_ = (CqlTupleMetadata_HDVhZFAYAdGHPZJWcDFSNFGPd, azzzzzzzzzzzzzzzzzzzzx_, bzzzzzzzzzzzzzzzzzzzzf_ as CqlQuantity, bzzzzzzzzzzzzzzzzzzzzo_);

            return bzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> azzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?>(azzzzzzzzzzzzzzzzzzzzs_, azzzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> azzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?>(azzzzzzzzzzzzzzzzzzzzu_);

        return azzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? dzzzzzzzzzzzzzzzzzzzza_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return dzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> dzzzzzzzzzzzzzzzzzzzzb_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return dzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? dzzzzzzzzzzzzzzzzzzzzc_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return dzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode dzzzzzzzzzzzzzzzzzzzzd_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return dzzzzzzzzzzzzzzzzzzzzd_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_CYbMQaXdPgTVSLXJSHHNTbhVM = new(
        [typeof(string), typeof(CqlQuantity), typeof(CqlDateTime)],
        ["EncounterId", "FirstRespRateResult", "Timing"]);

    private static CqlTupleMetadata CqlTupleMetadata_DhbJAfCiKIAGYKTjJXYGSKECQ = new(
        [typeof(string), typeof(CqlQuantity), typeof(CqlDateTime)],
        ["EncounterId", "FirstHeartRateResult", "Timing"]);

    private static CqlTupleMetadata CqlTupleMetadata_FdREYEdHOZIcMCNYCRFJYJReA = new(
        [typeof(string), typeof(CqlQuantity), typeof(CqlDateTime)],
        ["EncounterId", "FirstOxygenSatResult", "Timing"]);

    private static CqlTupleMetadata CqlTupleMetadata_GIbILVAdXLLNYBgcQIEiUiKaK = new(
        [typeof(string), typeof(CqlQuantity), typeof(CqlDateTime)],
        ["EncounterId", "FirstTemperatureResult", "Timing"]);

    private static CqlTupleMetadata CqlTupleMetadata_HDVhZFAYAdGHPZJWcDFSNFGPd = new(
        [typeof(string), typeof(CqlQuantity), typeof(CqlDateTime)],
        ["EncounterId", "FirstResult", "Timing"]);

    #endregion CqlTupleMetadata Properties

}
