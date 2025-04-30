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
    private static readonly CqlCode _Oxygen_saturation_in_Arterial_blood = new CqlCode("2708-6", "http://loinc.org");

    [CqlCodeDefinition("Oxygen saturation in Arterial blood by Pulse oximetry", codeId: "59408-5", codeSystem: "http://loinc.org")]
    public CqlCode Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry(CqlContext _) => _Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry;
    private static readonly CqlCode _Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry = new CqlCode("59408-5", "http://loinc.org");

    [CqlCodeDefinition("Systolic blood pressure", codeId: "8480-6", codeSystem: "http://loinc.org")]
    public CqlCode Systolic_blood_pressure(CqlContext _) => _Systolic_blood_pressure;
    private static readonly CqlCode _Systolic_blood_pressure = new CqlCode("8480-6", "http://loinc.org");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC")]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, [
          _Oxygen_saturation_in_Arterial_blood,
          _Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry,
          _Systolic_blood_pressure]);

    [CqlCodeSystemDefinition("ActCode")]
    public CqlCodeSystem ActCode(CqlContext _) => _ActCode;
    private static readonly CqlCodeSystem _ActCode =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/v3-ActCode", null, []);

    [CqlCodeSystemDefinition("Source of Payment Typology")]
    public CqlCodeSystem Source_of_Payment_Typology(CqlContext _) => _Source_of_Payment_Typology;
    private static readonly CqlCodeSystem _Source_of_Payment_Typology =
      new CqlCodeSystem("https://nahdo.org/sopt", null, []);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Interval(kzzzzzzzzzzzzzzzzzzzzzzzzl_, kzzzzzzzzzzzzzzzzzzzzzzzzm_, true, true);
        object kzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.ResolveParameter("HybridHospitalWideMortalityFHIR-0.0.001", "Measurement Period", kzzzzzzzzzzzzzzzzzzzzzzzzn_);

        return (CqlInterval<CqlDateTime>)kzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> kzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient kzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.SingletonFrom<Patient>(kzzzzzzzzzzzzzzzzzzzzzzzzp_);

        return kzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Inpatient Encounters")]
    public IEnumerable<Encounter> Inpatient_Encounters(CqlContext context)
    {
        CqlValueSet kzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzt_(Encounter InpatientEncounter)
        {
            CqlValueSet kzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Medicare_FFS_payer(context);
            IEnumerable<Coverage> kzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Coverage>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-coverage"));
            CqlValueSet kzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Medicare_Advantage_payer(context);
            IEnumerable<Coverage> kzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Coverage>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-coverage"));
            IEnumerable<Coverage> kzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Union<Coverage>(kzzzzzzzzzzzzzzzzzzzzzzzzw_, kzzzzzzzzzzzzzzzzzzzzzzzzy_);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzza_(Coverage MedicarePayer)
            {
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzze_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, InpatientEncounter);
                int? lzzzzzzzzzzzzzzzzzzzzzzzzf_ = CQMCommon_2_2_000.Instance.lengthInDays(context, lzzzzzzzzzzzzzzzzzzzzzzzze_);
                bool? lzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Less(lzzzzzzzzzzzzzzzzzzzzzzzzf_, 365);
                Code<Encounter.EncounterStatus> lzzzzzzzzzzzzzzzzzzzzzzzzh_ = InpatientEncounter?.StatusElement;
                Encounter.EncounterStatus? lzzzzzzzzzzzzzzzzzzzzzzzzi_ = lzzzzzzzzzzzzzzzzzzzzzzzzh_?.Value;
                Code<Encounter.EncounterStatus> lzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(lzzzzzzzzzzzzzzzzzzzzzzzzi_);
                bool? lzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Equal(lzzzzzzzzzzzzzzzzzzzzzzzzj_, "finished");
                bool? lzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzzzg_, lzzzzzzzzzzzzzzzzzzzzzzzzk_);
                Patient lzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Patient(context);
                Date lzzzzzzzzzzzzzzzzzzzzzzzzn_ = lzzzzzzzzzzzzzzzzzzzzzzzzm_?.BirthDateElement;
                string lzzzzzzzzzzzzzzzzzzzzzzzzo_ = lzzzzzzzzzzzzzzzzzzzzzzzzn_?.Value;
                CqlDate lzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.ConvertStringToDate(lzzzzzzzzzzzzzzzzzzzzzzzzo_);
                Period lzzzzzzzzzzzzzzzzzzzzzzzzq_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlDate lzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.DateFrom(lzzzzzzzzzzzzzzzzzzzzzzzzs_);
                int? lzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.CalculateAgeAt(lzzzzzzzzzzzzzzzzzzzzzzzzp_, lzzzzzzzzzzzzzzzzzzzzzzzzt_, "year");
                CqlInterval<int?> lzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Interval(65, 94, true, true);
                bool? lzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.In<int?>(lzzzzzzzzzzzzzzzzzzzzzzzzu_, lzzzzzzzzzzzzzzzzzzzzzzzzv_, default);
                bool? lzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzzzl_, lzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.End(lzzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Measurement_Period(context);
                bool? mzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.In<CqlDateTime>(mzzzzzzzzzzzzzzzzzzzzzzzza_, mzzzzzzzzzzzzzzzzzzzzzzzzb_, "day");
                bool? mzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzzzx_, mzzzzzzzzzzzzzzzzzzzzzzzzc_);

                return mzzzzzzzzzzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<Coverage> lzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Coverage>(kzzzzzzzzzzzzzzzzzzzzzzzzz_, lzzzzzzzzzzzzzzzzzzzzzzzza_);
            Encounter lzzzzzzzzzzzzzzzzzzzzzzzzc_(Coverage MedicarePayer) =>
                InpatientEncounter;
            IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Select<Coverage, Encounter>(lzzzzzzzzzzzzzzzzzzzzzzzzb_, lzzzzzzzzzzzzzzzzzzzzzzzzc_);

            return lzzzzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.SelectMany<Encounter, Encounter>(kzzzzzzzzzzzzzzzzzzzzzzzzs_, kzzzzzzzzzzzzzzzzzzzzzzzzt_);

        return kzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Inpatient_Encounters(context);

        return mzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Encounter with First Body Temperature")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)?> Encounter_with_First_Body_Temperature(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)? mzzzzzzzzzzzzzzzzzzzzzzzzg_(Encounter EncounterInpatient)
        {
            Id mzzzzzzzzzzzzzzzzzzzzzzzzj_ = EncounterInpatient?.IdElement;
            string mzzzzzzzzzzzzzzzzzzzzzzzzk_ = mzzzzzzzzzzzzzzzzzzzzzzzzj_?.Value;
            IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bodytemp"));
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzm_(Observation temperature)
            {
                DataType nzzzzzzzzzzzzzzzzzzzzzzzzd_ = temperature?.Effective;
                object nzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.earliest(context, nzzzzzzzzzzzzzzzzzzzzzzzze_);
                Period nzzzzzzzzzzzzzzzzzzzzzzzzg_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlQuantity nzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Subtract(nzzzzzzzzzzzzzzzzzzzzzzzzi_, nzzzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlQuantity nzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Add(nzzzzzzzzzzzzzzzzzzzzzzzzn_, nzzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Interval(nzzzzzzzzzzzzzzzzzzzzzzzzk_, nzzzzzzzzzzzzzzzzzzzzzzzzp_, true, true);
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(nzzzzzzzzzzzzzzzzzzzzzzzzf_, nzzzzzzzzzzzzzzzzzzzzzzzzq_, default);
                Code<ObservationStatus> nzzzzzzzzzzzzzzzzzzzzzzzzs_ = temperature?.StatusElement;
                ObservationStatus? nzzzzzzzzzzzzzzzzzzzzzzzzt_ = nzzzzzzzzzzzzzzzzzzzzzzzzs_?.Value;
                string nzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Convert<string>(nzzzzzzzzzzzzzzzzzzzzzzzzt_);
                string[] nzzzzzzzzzzzzzzzzzzzzzzzzv_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.In<string>(nzzzzzzzzzzzzzzzzzzzzzzzzu_, nzzzzzzzzzzzzzzzzzzzzzzzzv_ as IEnumerable<string>);
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzzr_, nzzzzzzzzzzzzzzzzzzzzzzzzw_);
                DataType nzzzzzzzzzzzzzzzzzzzzzzzzy_ = temperature?.Value;
                CqlQuantity nzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, nzzzzzzzzzzzzzzzzzzzzzzzzy_ as Quantity);
                bool? ozzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Not((bool?)(nzzzzzzzzzzzzzzzzzzzzzzzzz_ is null));
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzzx_, ozzzzzzzzzzzzzzzzzzzzzzzza_);

                return ozzzzzzzzzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Observation>(mzzzzzzzzzzzzzzzzzzzzzzzzl_, mzzzzzzzzzzzzzzzzzzzzzzzzm_);
            object mzzzzzzzzzzzzzzzzzzzzzzzzo_(Observation @this)
            {
                DataType ozzzzzzzzzzzzzzzzzzzzzzzzc_ = @this?.Effective;
                object ozzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.earliest(context, ozzzzzzzzzzzzzzzzzzzzzzzzd_);

                return ozzzzzzzzzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.SortBy<Observation>(mzzzzzzzzzzzzzzzzzzzzzzzzn_, mzzzzzzzzzzzzzzzzzzzzzzzzo_, System.ComponentModel.ListSortDirection.Ascending);
            Observation mzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.First<Observation>(mzzzzzzzzzzzzzzzzzzzzzzzzp_);
            DataType mzzzzzzzzzzzzzzzzzzzzzzzzr_ = mzzzzzzzzzzzzzzzzzzzzzzzzq_?.Value;
            CqlQuantity mzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, mzzzzzzzzzzzzzzzzzzzzzzzzr_ as Quantity);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzu_(Observation temperature)
            {
                DataType ozzzzzzzzzzzzzzzzzzzzzzzzf_ = temperature?.Effective;
                object ozzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.earliest(context, ozzzzzzzzzzzzzzzzzzzzzzzzg_);
                Period ozzzzzzzzzzzzzzzzzzzzzzzzi_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlQuantity ozzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Subtract(ozzzzzzzzzzzzzzzzzzzzzzzzk_, ozzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlQuantity ozzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Add(ozzzzzzzzzzzzzzzzzzzzzzzzp_, ozzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Interval(ozzzzzzzzzzzzzzzzzzzzzzzzm_, ozzzzzzzzzzzzzzzzzzzzzzzzr_, true, true);
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.In<CqlDateTime>(ozzzzzzzzzzzzzzzzzzzzzzzzh_, ozzzzzzzzzzzzzzzzzzzzzzzzs_, default);
                Code<ObservationStatus> ozzzzzzzzzzzzzzzzzzzzzzzzu_ = temperature?.StatusElement;
                ObservationStatus? ozzzzzzzzzzzzzzzzzzzzzzzzv_ = ozzzzzzzzzzzzzzzzzzzzzzzzu_?.Value;
                string ozzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<string>(ozzzzzzzzzzzzzzzzzzzzzzzzv_);
                string[] ozzzzzzzzzzzzzzzzzzzzzzzzx_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<string>(ozzzzzzzzzzzzzzzzzzzzzzzzw_, ozzzzzzzzzzzzzzzzzzzzzzzzx_ as IEnumerable<string>);
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzzt_, ozzzzzzzzzzzzzzzzzzzzzzzzy_);
                DataType pzzzzzzzzzzzzzzzzzzzzzzzza_ = temperature?.Value;
                CqlQuantity pzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, pzzzzzzzzzzzzzzzzzzzzzzzza_ as Quantity);
                bool? pzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Not((bool?)(pzzzzzzzzzzzzzzzzzzzzzzzzb_ is null));
                bool? pzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzzz_, pzzzzzzzzzzzzzzzzzzzzzzzzc_);

                return pzzzzzzzzzzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Observation>(mzzzzzzzzzzzzzzzzzzzzzzzzl_, mzzzzzzzzzzzzzzzzzzzzzzzzu_);
            object mzzzzzzzzzzzzzzzzzzzzzzzzw_(Observation @this)
            {
                DataType pzzzzzzzzzzzzzzzzzzzzzzzze_ = @this?.Effective;
                object pzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.earliest(context, pzzzzzzzzzzzzzzzzzzzzzzzzf_);

                return pzzzzzzzzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.SortBy<Observation>(mzzzzzzzzzzzzzzzzzzzzzzzzv_, mzzzzzzzzzzzzzzzzzzzzzzzzw_, System.ComponentModel.ListSortDirection.Ascending);
            Observation mzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.First<Observation>(mzzzzzzzzzzzzzzzzzzzzzzzzx_);
            DataType mzzzzzzzzzzzzzzzzzzzzzzzzz_ = mzzzzzzzzzzzzzzzzzzzzzzzzy_?.Effective;
            object nzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.earliest(context, nzzzzzzzzzzzzzzzzzzzzzzzza_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)? nzzzzzzzzzzzzzzzzzzzzzzzzc_ = (CqlTupleMetadata_GIbILVAdXLLNYBgcQIEiUiKaK, mzzzzzzzzzzzzzzzzzzzzzzzzk_, mzzzzzzzzzzzzzzzzzzzzzzzzs_ as CqlQuantity, nzzzzzzzzzzzzzzzzzzzzzzzzb_);

            return nzzzzzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)?> mzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)?>(mzzzzzzzzzzzzzzzzzzzzzzzzf_, mzzzzzzzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)?> mzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)?>(mzzzzzzzzzzzzzzzzzzzzzzzzh_);

        return mzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Encounter with First Heart Rate")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)?> Encounter_with_First_Heart_Rate(CqlContext context)
    {
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)? pzzzzzzzzzzzzzzzzzzzzzzzzi_(Encounter EncounterInpatient)
        {
            Id pzzzzzzzzzzzzzzzzzzzzzzzzl_ = EncounterInpatient?.IdElement;
            string pzzzzzzzzzzzzzzzzzzzzzzzzm_ = pzzzzzzzzzzzzzzzzzzzzzzzzl_?.Value;
            IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/heartrate"));
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzo_(Observation HeartRate)
            {
                DataType qzzzzzzzzzzzzzzzzzzzzzzzzf_ = HeartRate?.Effective;
                object qzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.earliest(context, qzzzzzzzzzzzzzzzzzzzzzzzzg_);
                Period qzzzzzzzzzzzzzzzzzzzzzzzzi_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Start(qzzzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlQuantity qzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Subtract(qzzzzzzzzzzzzzzzzzzzzzzzzk_, qzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(qzzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlQuantity qzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Add(qzzzzzzzzzzzzzzzzzzzzzzzzp_, qzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Interval(qzzzzzzzzzzzzzzzzzzzzzzzzm_, qzzzzzzzzzzzzzzzzzzzzzzzzr_, true, true);
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.In<CqlDateTime>(qzzzzzzzzzzzzzzzzzzzzzzzzh_, qzzzzzzzzzzzzzzzzzzzzzzzzs_, default);
                Code<ObservationStatus> qzzzzzzzzzzzzzzzzzzzzzzzzu_ = HeartRate?.StatusElement;
                ObservationStatus? qzzzzzzzzzzzzzzzzzzzzzzzzv_ = qzzzzzzzzzzzzzzzzzzzzzzzzu_?.Value;
                string qzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<string>(qzzzzzzzzzzzzzzzzzzzzzzzzv_);
                string[] qzzzzzzzzzzzzzzzzzzzzzzzzx_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<string>(qzzzzzzzzzzzzzzzzzzzzzzzzw_, qzzzzzzzzzzzzzzzzzzzzzzzzx_ as IEnumerable<string>);
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzzzt_, qzzzzzzzzzzzzzzzzzzzzzzzzy_);
                DataType rzzzzzzzzzzzzzzzzzzzzzzzza_ = HeartRate?.Value;
                CqlQuantity rzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, rzzzzzzzzzzzzzzzzzzzzzzzza_ as Quantity);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Not((bool?)(rzzzzzzzzzzzzzzzzzzzzzzzzb_ is null));
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzzzz_, rzzzzzzzzzzzzzzzzzzzzzzzzc_);

                return rzzzzzzzzzzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Observation>(pzzzzzzzzzzzzzzzzzzzzzzzzn_, pzzzzzzzzzzzzzzzzzzzzzzzzo_);
            object pzzzzzzzzzzzzzzzzzzzzzzzzq_(Observation @this)
            {
                DataType rzzzzzzzzzzzzzzzzzzzzzzzze_ = @this?.Effective;
                object rzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.earliest(context, rzzzzzzzzzzzzzzzzzzzzzzzzf_);

                return rzzzzzzzzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.SortBy<Observation>(pzzzzzzzzzzzzzzzzzzzzzzzzp_, pzzzzzzzzzzzzzzzzzzzzzzzzq_, System.ComponentModel.ListSortDirection.Ascending);
            Observation pzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.First<Observation>(pzzzzzzzzzzzzzzzzzzzzzzzzr_);
            DataType pzzzzzzzzzzzzzzzzzzzzzzzzt_ = pzzzzzzzzzzzzzzzzzzzzzzzzs_?.Value;
            CqlQuantity pzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, pzzzzzzzzzzzzzzzzzzzzzzzzt_ as Quantity);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzw_(Observation HeartRate)
            {
                DataType rzzzzzzzzzzzzzzzzzzzzzzzzh_ = HeartRate?.Effective;
                object rzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.earliest(context, rzzzzzzzzzzzzzzzzzzzzzzzzi_);
                Period rzzzzzzzzzzzzzzzzzzzzzzzzk_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(rzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlQuantity rzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Subtract(rzzzzzzzzzzzzzzzzzzzzzzzzm_, rzzzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Start(rzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlQuantity rzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Add(rzzzzzzzzzzzzzzzzzzzzzzzzr_, rzzzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Interval(rzzzzzzzzzzzzzzzzzzzzzzzzo_, rzzzzzzzzzzzzzzzzzzzzzzzzt_, true, true);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.In<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzzzzzzj_, rzzzzzzzzzzzzzzzzzzzzzzzzu_, default);
                Code<ObservationStatus> rzzzzzzzzzzzzzzzzzzzzzzzzw_ = HeartRate?.StatusElement;
                ObservationStatus? rzzzzzzzzzzzzzzzzzzzzzzzzx_ = rzzzzzzzzzzzzzzzzzzzzzzzzw_?.Value;
                string rzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<string>(rzzzzzzzzzzzzzzzzzzzzzzzzx_);
                string[] rzzzzzzzzzzzzzzzzzzzzzzzzz_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? szzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<string>(rzzzzzzzzzzzzzzzzzzzzzzzzy_, rzzzzzzzzzzzzzzzzzzzzzzzzz_ as IEnumerable<string>);
                bool? szzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzzzzzv_, szzzzzzzzzzzzzzzzzzzzzzzza_);
                DataType szzzzzzzzzzzzzzzzzzzzzzzzc_ = HeartRate?.Value;
                CqlQuantity szzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, szzzzzzzzzzzzzzzzzzzzzzzzc_ as Quantity);
                bool? szzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Not((bool?)(szzzzzzzzzzzzzzzzzzzzzzzzd_ is null));
                bool? szzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzzzzb_, szzzzzzzzzzzzzzzzzzzzzzzze_);

                return szzzzzzzzzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Observation>(pzzzzzzzzzzzzzzzzzzzzzzzzn_, pzzzzzzzzzzzzzzzzzzzzzzzzw_);
            object pzzzzzzzzzzzzzzzzzzzzzzzzy_(Observation @this)
            {
                DataType szzzzzzzzzzzzzzzzzzzzzzzzg_ = @this?.Effective;
                object szzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.earliest(context, szzzzzzzzzzzzzzzzzzzzzzzzh_);

                return szzzzzzzzzzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.SortBy<Observation>(pzzzzzzzzzzzzzzzzzzzzzzzzx_, pzzzzzzzzzzzzzzzzzzzzzzzzy_, System.ComponentModel.ListSortDirection.Ascending);
            Observation qzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.First<Observation>(pzzzzzzzzzzzzzzzzzzzzzzzzz_);
            DataType qzzzzzzzzzzzzzzzzzzzzzzzzb_ = qzzzzzzzzzzzzzzzzzzzzzzzza_?.Effective;
            object qzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.earliest(context, qzzzzzzzzzzzzzzzzzzzzzzzzc_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)? qzzzzzzzzzzzzzzzzzzzzzzzze_ = (CqlTupleMetadata_DhbJAfCiKIAGYKTjJXYGSKECQ, pzzzzzzzzzzzzzzzzzzzzzzzzm_, pzzzzzzzzzzzzzzzzzzzzzzzzu_ as CqlQuantity, qzzzzzzzzzzzzzzzzzzzzzzzzd_);

            return qzzzzzzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)?> pzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)?>(pzzzzzzzzzzzzzzzzzzzzzzzzh_, pzzzzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)?> pzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)?>(pzzzzzzzzzzzzzzzzzzzzzzzzj_);

        return pzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Encounter with First Oxygen Saturation")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)?> Encounter_with_First_Oxygen_Saturation(CqlContext context)
    {
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)? szzzzzzzzzzzzzzzzzzzzzzzzk_(Encounter EncounterInpatient)
        {
            Id szzzzzzzzzzzzzzzzzzzzzzzzn_ = EncounterInpatient?.IdElement;
            string szzzzzzzzzzzzzzzzzzzzzzzzo_ = szzzzzzzzzzzzzzzzzzzzzzzzn_?.Value;
            CqlValueSet szzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
            IEnumerable<Observation> szzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            bool? szzzzzzzzzzzzzzzzzzzzzzzzr_(Observation O2Saturation)
            {
                object tzzzzzzzzzzzzzzzzzzzzzzzzb_()
                {
                    bool uzzzzzzzzzzzzzzzzzzzzzzzza_()
                    {
                        DataType uzzzzzzzzzzzzzzzzzzzzzzzzd_ = O2Saturation?.Effective;
                        object uzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzd_);
                        bool uzzzzzzzzzzzzzzzzzzzzzzzzf_ = uzzzzzzzzzzzzzzzzzzzzzzzze_ is CqlDateTime;

                        return uzzzzzzzzzzzzzzzzzzzzzzzzf_;
                    };
                    bool uzzzzzzzzzzzzzzzzzzzzzzzzb_()
                    {
                        DataType uzzzzzzzzzzzzzzzzzzzzzzzzg_ = O2Saturation?.Effective;
                        object uzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzg_);
                        bool uzzzzzzzzzzzzzzzzzzzzzzzzi_ = uzzzzzzzzzzzzzzzzzzzzzzzzh_ is CqlInterval<CqlDateTime>;

                        return uzzzzzzzzzzzzzzzzzzzzzzzzi_;
                    };
                    bool uzzzzzzzzzzzzzzzzzzzzzzzzc_()
                    {
                        DataType uzzzzzzzzzzzzzzzzzzzzzzzzj_ = O2Saturation?.Effective;
                        object uzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzj_);
                        bool uzzzzzzzzzzzzzzzzzzzzzzzzl_ = uzzzzzzzzzzzzzzzzzzzzzzzzk_ is CqlDateTime;

                        return uzzzzzzzzzzzzzzzzzzzzzzzzl_;
                    };
                    if (uzzzzzzzzzzzzzzzzzzzzzzzza_())
                    {
                        DataType uzzzzzzzzzzzzzzzzzzzzzzzzm_ = O2Saturation?.Effective;
                        object uzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzm_);

                        return (uzzzzzzzzzzzzzzzzzzzzzzzzn_ as CqlDateTime) as object;
                    }
                    else if (uzzzzzzzzzzzzzzzzzzzzzzzzb_())
                    {
                        DataType uzzzzzzzzzzzzzzzzzzzzzzzzo_ = O2Saturation?.Effective;
                        object uzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzo_);

                        return (uzzzzzzzzzzzzzzzzzzzzzzzzp_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (uzzzzzzzzzzzzzzzzzzzzzzzzc_())
                    {
                        DataType uzzzzzzzzzzzzzzzzzzzzzzzzq_ = O2Saturation?.Effective;
                        object uzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzq_);

                        return (uzzzzzzzzzzzzzzzzzzzzzzzzr_ as CqlDateTime) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.earliest(context, tzzzzzzzzzzzzzzzzzzzzzzzzb_());
                Period tzzzzzzzzzzzzzzzzzzzzzzzzd_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlQuantity tzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Subtract(tzzzzzzzzzzzzzzzzzzzzzzzzf_, tzzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlQuantity tzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Add(tzzzzzzzzzzzzzzzzzzzzzzzzk_, tzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Interval(tzzzzzzzzzzzzzzzzzzzzzzzzh_, tzzzzzzzzzzzzzzzzzzzzzzzzm_, true, true);
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.In<CqlDateTime>(tzzzzzzzzzzzzzzzzzzzzzzzzc_, tzzzzzzzzzzzzzzzzzzzzzzzzn_, default);
                Code<ObservationStatus> tzzzzzzzzzzzzzzzzzzzzzzzzp_ = O2Saturation?.StatusElement;
                ObservationStatus? tzzzzzzzzzzzzzzzzzzzzzzzzq_ = tzzzzzzzzzzzzzzzzzzzzzzzzp_?.Value;
                Code<ObservationStatus> tzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Convert<Code<ObservationStatus>>(tzzzzzzzzzzzzzzzzzzzzzzzzq_);
                string tzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Convert<string>(tzzzzzzzzzzzzzzzzzzzzzzzzr_);
                string[] tzzzzzzzzzzzzzzzzzzzzzzzzt_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<string>(tzzzzzzzzzzzzzzzzzzzzzzzzs_, tzzzzzzzzzzzzzzzzzzzzzzzzt_ as IEnumerable<string>);
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzzzo_, tzzzzzzzzzzzzzzzzzzzzzzzzu_);
                DataType tzzzzzzzzzzzzzzzzzzzzzzzzw_ = O2Saturation?.Value;
                object tzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzw_);
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Not((bool?)(tzzzzzzzzzzzzzzzzzzzzzzzzx_ is null));
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzzzv_, tzzzzzzzzzzzzzzzzzzzzzzzzy_);

                return tzzzzzzzzzzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<Observation> szzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Observation>(szzzzzzzzzzzzzzzzzzzzzzzzq_, szzzzzzzzzzzzzzzzzzzzzzzzr_);
            object szzzzzzzzzzzzzzzzzzzzzzzzt_(Observation @this)
            {
                object uzzzzzzzzzzzzzzzzzzzzzzzzs_()
                {
                    bool uzzzzzzzzzzzzzzzzzzzzzzzzu_()
                    {
                        DataType uzzzzzzzzzzzzzzzzzzzzzzzzx_ = @this?.Effective;
                        object uzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzx_);
                        bool uzzzzzzzzzzzzzzzzzzzzzzzzz_ = uzzzzzzzzzzzzzzzzzzzzzzzzy_ is CqlDateTime;

                        return uzzzzzzzzzzzzzzzzzzzzzzzzz_;
                    };
                    bool uzzzzzzzzzzzzzzzzzzzzzzzzv_()
                    {
                        DataType vzzzzzzzzzzzzzzzzzzzzzzzza_ = @this?.Effective;
                        object vzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzza_);
                        bool vzzzzzzzzzzzzzzzzzzzzzzzzc_ = vzzzzzzzzzzzzzzzzzzzzzzzzb_ is CqlInterval<CqlDateTime>;

                        return vzzzzzzzzzzzzzzzzzzzzzzzzc_;
                    };
                    bool uzzzzzzzzzzzzzzzzzzzzzzzzw_()
                    {
                        DataType vzzzzzzzzzzzzzzzzzzzzzzzzd_ = @this?.Effective;
                        object vzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzzd_);
                        bool vzzzzzzzzzzzzzzzzzzzzzzzzf_ = vzzzzzzzzzzzzzzzzzzzzzzzze_ is CqlDateTime;

                        return vzzzzzzzzzzzzzzzzzzzzzzzzf_;
                    };
                    if (uzzzzzzzzzzzzzzzzzzzzzzzzu_())
                    {
                        DataType vzzzzzzzzzzzzzzzzzzzzzzzzg_ = @this?.Effective;
                        object vzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzzg_);

                        return (vzzzzzzzzzzzzzzzzzzzzzzzzh_ as CqlDateTime) as object;
                    }
                    else if (uzzzzzzzzzzzzzzzzzzzzzzzzv_())
                    {
                        DataType vzzzzzzzzzzzzzzzzzzzzzzzzi_ = @this?.Effective;
                        object vzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzzi_);

                        return (vzzzzzzzzzzzzzzzzzzzzzzzzj_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (uzzzzzzzzzzzzzzzzzzzzzzzzw_())
                    {
                        DataType vzzzzzzzzzzzzzzzzzzzzzzzzk_ = @this?.Effective;
                        object vzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzzk_);

                        return (vzzzzzzzzzzzzzzzzzzzzzzzzl_ as CqlDateTime) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.earliest(context, uzzzzzzzzzzzzzzzzzzzzzzzzs_());

                return uzzzzzzzzzzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<Observation> szzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.SortBy<Observation>(szzzzzzzzzzzzzzzzzzzzzzzzs_, szzzzzzzzzzzzzzzzzzzzzzzzt_, System.ComponentModel.ListSortDirection.Ascending);
            Observation szzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.First<Observation>(szzzzzzzzzzzzzzzzzzzzzzzzu_);
            DataType szzzzzzzzzzzzzzzzzzzzzzzzw_ = szzzzzzzzzzzzzzzzzzzzzzzzv_?.Value;
            object szzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzzw_);
            object szzzzzzzzzzzzzzzzzzzzzzzzy_()
            {
                bool vzzzzzzzzzzzzzzzzzzzzzzzzm_()
                {
                    CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
                    IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? vzzzzzzzzzzzzzzzzzzzzzzzzr_(Observation O2Saturation)
                    {
                        object vzzzzzzzzzzzzzzzzzzzzzzzzz_()
                        {
                            bool wzzzzzzzzzzzzzzzzzzzzzzzzy_()
                            {
                                DataType xzzzzzzzzzzzzzzzzzzzzzzzzb_ = O2Saturation?.Effective;
                                object xzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzb_);
                                bool xzzzzzzzzzzzzzzzzzzzzzzzzd_ = xzzzzzzzzzzzzzzzzzzzzzzzzc_ is CqlDateTime;

                                return xzzzzzzzzzzzzzzzzzzzzzzzzd_;
                            };
                            bool wzzzzzzzzzzzzzzzzzzzzzzzzz_()
                            {
                                DataType xzzzzzzzzzzzzzzzzzzzzzzzze_ = O2Saturation?.Effective;
                                object xzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzze_);
                                bool xzzzzzzzzzzzzzzzzzzzzzzzzg_ = xzzzzzzzzzzzzzzzzzzzzzzzzf_ is CqlInterval<CqlDateTime>;

                                return xzzzzzzzzzzzzzzzzzzzzzzzzg_;
                            };
                            bool xzzzzzzzzzzzzzzzzzzzzzzzza_()
                            {
                                DataType xzzzzzzzzzzzzzzzzzzzzzzzzh_ = O2Saturation?.Effective;
                                object xzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzh_);
                                bool xzzzzzzzzzzzzzzzzzzzzzzzzj_ = xzzzzzzzzzzzzzzzzzzzzzzzzi_ is CqlDateTime;

                                return xzzzzzzzzzzzzzzzzzzzzzzzzj_;
                            };
                            if (wzzzzzzzzzzzzzzzzzzzzzzzzy_())
                            {
                                DataType xzzzzzzzzzzzzzzzzzzzzzzzzk_ = O2Saturation?.Effective;
                                object xzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzk_);

                                return (xzzzzzzzzzzzzzzzzzzzzzzzzl_ as CqlDateTime) as object;
                            }
                            else if (wzzzzzzzzzzzzzzzzzzzzzzzzz_())
                            {
                                DataType xzzzzzzzzzzzzzzzzzzzzzzzzm_ = O2Saturation?.Effective;
                                object xzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzm_);

                                return (xzzzzzzzzzzzzzzzzzzzzzzzzn_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (xzzzzzzzzzzzzzzzzzzzzzzzza_())
                            {
                                DataType xzzzzzzzzzzzzzzzzzzzzzzzzo_ = O2Saturation?.Effective;
                                object xzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzo_);

                                return (xzzzzzzzzzzzzzzzzzzzzzzzzp_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.earliest(context, vzzzzzzzzzzzzzzzzzzzzzzzzz_());
                        Period wzzzzzzzzzzzzzzzzzzzzzzzzb_ = EncounterInpatient?.Period;
                        CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzzzzzzzzzzzzzzzzb_);
                        CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(wzzzzzzzzzzzzzzzzzzzzzzzzc_);
                        CqlQuantity wzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Quantity(1440m, "minutes");
                        CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Subtract(wzzzzzzzzzzzzzzzzzzzzzzzzd_, wzzzzzzzzzzzzzzzzzzzzzzzze_);
                        CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzzzzzzzzzzzzzzzzb_);
                        CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Start(wzzzzzzzzzzzzzzzzzzzzzzzzh_);
                        CqlQuantity wzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Quantity(120m, "minutes");
                        CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Add(wzzzzzzzzzzzzzzzzzzzzzzzzi_, wzzzzzzzzzzzzzzzzzzzzzzzzj_);
                        CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Interval(wzzzzzzzzzzzzzzzzzzzzzzzzf_, wzzzzzzzzzzzzzzzzzzzzzzzzk_, true, true);
                        bool? wzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.In<CqlDateTime>(wzzzzzzzzzzzzzzzzzzzzzzzza_, wzzzzzzzzzzzzzzzzzzzzzzzzl_, default);
                        Code<ObservationStatus> wzzzzzzzzzzzzzzzzzzzzzzzzn_ = O2Saturation?.StatusElement;
                        ObservationStatus? wzzzzzzzzzzzzzzzzzzzzzzzzo_ = wzzzzzzzzzzzzzzzzzzzzzzzzn_?.Value;
                        Code<ObservationStatus> wzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Convert<Code<ObservationStatus>>(wzzzzzzzzzzzzzzzzzzzzzzzzo_);
                        string wzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<string>(wzzzzzzzzzzzzzzzzzzzzzzzzp_);
                        string[] wzzzzzzzzzzzzzzzzzzzzzzzzr_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? wzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.In<string>(wzzzzzzzzzzzzzzzzzzzzzzzzq_, wzzzzzzzzzzzzzzzzzzzzzzzzr_ as IEnumerable<string>);
                        bool? wzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzzzzm_, wzzzzzzzzzzzzzzzzzzzzzzzzs_);
                        DataType wzzzzzzzzzzzzzzzzzzzzzzzzu_ = O2Saturation?.Value;
                        object wzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzzu_);
                        bool? wzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Not((bool?)(wzzzzzzzzzzzzzzzzzzzzzzzzv_ is null));
                        bool? wzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzzzzt_, wzzzzzzzzzzzzzzzzzzzzzzzzw_);

                        return wzzzzzzzzzzzzzzzzzzzzzzzzx_;
                    };
                    IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Observation>(vzzzzzzzzzzzzzzzzzzzzzzzzq_, vzzzzzzzzzzzzzzzzzzzzzzzzr_);
                    object vzzzzzzzzzzzzzzzzzzzzzzzzt_(Observation @this)
                    {
                        object xzzzzzzzzzzzzzzzzzzzzzzzzq_()
                        {
                            bool xzzzzzzzzzzzzzzzzzzzzzzzzs_()
                            {
                                DataType xzzzzzzzzzzzzzzzzzzzzzzzzv_ = @this?.Effective;
                                object xzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzv_);
                                bool xzzzzzzzzzzzzzzzzzzzzzzzzx_ = xzzzzzzzzzzzzzzzzzzzzzzzzw_ is CqlDateTime;

                                return xzzzzzzzzzzzzzzzzzzzzzzzzx_;
                            };
                            bool xzzzzzzzzzzzzzzzzzzzzzzzzt_()
                            {
                                DataType xzzzzzzzzzzzzzzzzzzzzzzzzy_ = @this?.Effective;
                                object xzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzy_);
                                bool yzzzzzzzzzzzzzzzzzzzzzzzza_ = xzzzzzzzzzzzzzzzzzzzzzzzzz_ is CqlInterval<CqlDateTime>;

                                return yzzzzzzzzzzzzzzzzzzzzzzzza_;
                            };
                            bool xzzzzzzzzzzzzzzzzzzzzzzzzu_()
                            {
                                DataType yzzzzzzzzzzzzzzzzzzzzzzzzb_ = @this?.Effective;
                                object yzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzb_);
                                bool yzzzzzzzzzzzzzzzzzzzzzzzzd_ = yzzzzzzzzzzzzzzzzzzzzzzzzc_ is CqlDateTime;

                                return yzzzzzzzzzzzzzzzzzzzzzzzzd_;
                            };
                            if (xzzzzzzzzzzzzzzzzzzzzzzzzs_())
                            {
                                DataType yzzzzzzzzzzzzzzzzzzzzzzzze_ = @this?.Effective;
                                object yzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzze_);

                                return (yzzzzzzzzzzzzzzzzzzzzzzzzf_ as CqlDateTime) as object;
                            }
                            else if (xzzzzzzzzzzzzzzzzzzzzzzzzt_())
                            {
                                DataType yzzzzzzzzzzzzzzzzzzzzzzzzg_ = @this?.Effective;
                                object yzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzg_);

                                return (yzzzzzzzzzzzzzzzzzzzzzzzzh_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (xzzzzzzzzzzzzzzzzzzzzzzzzu_())
                            {
                                DataType yzzzzzzzzzzzzzzzzzzzzzzzzi_ = @this?.Effective;
                                object yzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzi_);

                                return (yzzzzzzzzzzzzzzzzzzzzzzzzj_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.earliest(context, xzzzzzzzzzzzzzzzzzzzzzzzzq_());

                        return xzzzzzzzzzzzzzzzzzzzzzzzzr_;
                    };
                    IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.SortBy<Observation>(vzzzzzzzzzzzzzzzzzzzzzzzzs_, vzzzzzzzzzzzzzzzzzzzzzzzzt_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation vzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.First<Observation>(vzzzzzzzzzzzzzzzzzzzzzzzzu_);
                    DataType vzzzzzzzzzzzzzzzzzzzzzzzzw_ = vzzzzzzzzzzzzzzzzzzzzzzzzv_?.Effective;
                    object vzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzzw_);
                    bool vzzzzzzzzzzzzzzzzzzzzzzzzy_ = vzzzzzzzzzzzzzzzzzzzzzzzzx_ is CqlDateTime;

                    return vzzzzzzzzzzzzzzzzzzzzzzzzy_;
                };
                bool vzzzzzzzzzzzzzzzzzzzzzzzzn_()
                {
                    CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
                    IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? yzzzzzzzzzzzzzzzzzzzzzzzzm_(Observation O2Saturation)
                    {
                        object yzzzzzzzzzzzzzzzzzzzzzzzzu_()
                        {
                            bool zzzzzzzzzzzzzzzzzzzzzzzzzt_()
                            {
                                DataType zzzzzzzzzzzzzzzzzzzzzzzzzw_ = O2Saturation?.Effective;
                                object zzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzzzw_);
                                bool zzzzzzzzzzzzzzzzzzzzzzzzzy_ = zzzzzzzzzzzzzzzzzzzzzzzzzx_ is CqlDateTime;

                                return zzzzzzzzzzzzzzzzzzzzzzzzzy_;
                            };
                            bool zzzzzzzzzzzzzzzzzzzzzzzzzu_()
                            {
                                DataType zzzzzzzzzzzzzzzzzzzzzzzzzz_ = O2Saturation?.Effective;
                                object azzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzzzz_);
                                bool azzzzzzzzzzzzzzzzzzzzzzzzzb_ = azzzzzzzzzzzzzzzzzzzzzzzzza_ is CqlInterval<CqlDateTime>;

                                return azzzzzzzzzzzzzzzzzzzzzzzzzb_;
                            };
                            bool zzzzzzzzzzzzzzzzzzzzzzzzzv_()
                            {
                                DataType azzzzzzzzzzzzzzzzzzzzzzzzzc_ = O2Saturation?.Effective;
                                object azzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzc_);
                                bool azzzzzzzzzzzzzzzzzzzzzzzzze_ = azzzzzzzzzzzzzzzzzzzzzzzzzd_ is CqlDateTime;

                                return azzzzzzzzzzzzzzzzzzzzzzzzze_;
                            };
                            if (zzzzzzzzzzzzzzzzzzzzzzzzzt_())
                            {
                                DataType azzzzzzzzzzzzzzzzzzzzzzzzzf_ = O2Saturation?.Effective;
                                object azzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzf_);

                                return (azzzzzzzzzzzzzzzzzzzzzzzzzg_ as CqlDateTime) as object;
                            }
                            else if (zzzzzzzzzzzzzzzzzzzzzzzzzu_())
                            {
                                DataType azzzzzzzzzzzzzzzzzzzzzzzzzh_ = O2Saturation?.Effective;
                                object azzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzh_);

                                return (azzzzzzzzzzzzzzzzzzzzzzzzzi_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (zzzzzzzzzzzzzzzzzzzzzzzzzv_())
                            {
                                DataType azzzzzzzzzzzzzzzzzzzzzzzzzj_ = O2Saturation?.Effective;
                                object azzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzj_);

                                return (azzzzzzzzzzzzzzzzzzzzzzzzzk_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.earliest(context, yzzzzzzzzzzzzzzzzzzzzzzzzu_());
                        Period yzzzzzzzzzzzzzzzzzzzzzzzzw_ = EncounterInpatient?.Period;
                        CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzzzzzzzzzzzzzzzzzzw_);
                        CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzzzzzzzzx_);
                        CqlQuantity yzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Quantity(1440m, "minutes");
                        CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Subtract(yzzzzzzzzzzzzzzzzzzzzzzzzy_, yzzzzzzzzzzzzzzzzzzzzzzzzz_);
                        CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzzzzzzzzzzzzzzzzzzw_);
                        CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(zzzzzzzzzzzzzzzzzzzzzzzzzc_);
                        CqlQuantity zzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Quantity(120m, "minutes");
                        CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Add(zzzzzzzzzzzzzzzzzzzzzzzzzd_, zzzzzzzzzzzzzzzzzzzzzzzzze_);
                        CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Interval(zzzzzzzzzzzzzzzzzzzzzzzzza_, zzzzzzzzzzzzzzzzzzzzzzzzzf_, true, true);
                        bool? zzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.In<CqlDateTime>(yzzzzzzzzzzzzzzzzzzzzzzzzv_, zzzzzzzzzzzzzzzzzzzzzzzzzg_, default);
                        Code<ObservationStatus> zzzzzzzzzzzzzzzzzzzzzzzzzi_ = O2Saturation?.StatusElement;
                        ObservationStatus? zzzzzzzzzzzzzzzzzzzzzzzzzj_ = zzzzzzzzzzzzzzzzzzzzzzzzzi_?.Value;
                        Code<ObservationStatus> zzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<Code<ObservationStatus>>(zzzzzzzzzzzzzzzzzzzzzzzzzj_);
                        string zzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<string>(zzzzzzzzzzzzzzzzzzzzzzzzzk_);
                        string[] zzzzzzzzzzzzzzzzzzzzzzzzzm_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? zzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.In<string>(zzzzzzzzzzzzzzzzzzzzzzzzzl_, zzzzzzzzzzzzzzzzzzzzzzzzzm_ as IEnumerable<string>);
                        bool? zzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzzzzh_, zzzzzzzzzzzzzzzzzzzzzzzzzn_);
                        DataType zzzzzzzzzzzzzzzzzzzzzzzzzp_ = O2Saturation?.Value;
                        object zzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzzzp_);
                        bool? zzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Not((bool?)(zzzzzzzzzzzzzzzzzzzzzzzzzq_ is null));
                        bool? zzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzzzzo_, zzzzzzzzzzzzzzzzzzzzzzzzzr_);

                        return zzzzzzzzzzzzzzzzzzzzzzzzzs_;
                    };
                    IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Observation>(yzzzzzzzzzzzzzzzzzzzzzzzzl_, yzzzzzzzzzzzzzzzzzzzzzzzzm_);
                    object yzzzzzzzzzzzzzzzzzzzzzzzzo_(Observation @this)
                    {
                        object azzzzzzzzzzzzzzzzzzzzzzzzzl_()
                        {
                            bool azzzzzzzzzzzzzzzzzzzzzzzzzn_()
                            {
                                DataType azzzzzzzzzzzzzzzzzzzzzzzzzq_ = @this?.Effective;
                                object azzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzq_);
                                bool azzzzzzzzzzzzzzzzzzzzzzzzzs_ = azzzzzzzzzzzzzzzzzzzzzzzzzr_ is CqlDateTime;

                                return azzzzzzzzzzzzzzzzzzzzzzzzzs_;
                            };
                            bool azzzzzzzzzzzzzzzzzzzzzzzzzo_()
                            {
                                DataType azzzzzzzzzzzzzzzzzzzzzzzzzt_ = @this?.Effective;
                                object azzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzt_);
                                bool azzzzzzzzzzzzzzzzzzzzzzzzzv_ = azzzzzzzzzzzzzzzzzzzzzzzzzu_ is CqlInterval<CqlDateTime>;

                                return azzzzzzzzzzzzzzzzzzzzzzzzzv_;
                            };
                            bool azzzzzzzzzzzzzzzzzzzzzzzzzp_()
                            {
                                DataType azzzzzzzzzzzzzzzzzzzzzzzzzw_ = @this?.Effective;
                                object azzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzw_);
                                bool azzzzzzzzzzzzzzzzzzzzzzzzzy_ = azzzzzzzzzzzzzzzzzzzzzzzzzx_ is CqlDateTime;

                                return azzzzzzzzzzzzzzzzzzzzzzzzzy_;
                            };
                            if (azzzzzzzzzzzzzzzzzzzzzzzzzn_())
                            {
                                DataType azzzzzzzzzzzzzzzzzzzzzzzzzz_ = @this?.Effective;
                                object bzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzz_);

                                return (bzzzzzzzzzzzzzzzzzzzzzzzzza_ as CqlDateTime) as object;
                            }
                            else if (azzzzzzzzzzzzzzzzzzzzzzzzzo_())
                            {
                                DataType bzzzzzzzzzzzzzzzzzzzzzzzzzb_ = @this?.Effective;
                                object bzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzb_);

                                return (bzzzzzzzzzzzzzzzzzzzzzzzzzc_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (azzzzzzzzzzzzzzzzzzzzzzzzzp_())
                            {
                                DataType bzzzzzzzzzzzzzzzzzzzzzzzzzd_ = @this?.Effective;
                                object bzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzd_);

                                return (bzzzzzzzzzzzzzzzzzzzzzzzzze_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.earliest(context, azzzzzzzzzzzzzzzzzzzzzzzzzl_());

                        return azzzzzzzzzzzzzzzzzzzzzzzzzm_;
                    };
                    IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.SortBy<Observation>(yzzzzzzzzzzzzzzzzzzzzzzzzn_, yzzzzzzzzzzzzzzzzzzzzzzzzo_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation yzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.First<Observation>(yzzzzzzzzzzzzzzzzzzzzzzzzp_);
                    DataType yzzzzzzzzzzzzzzzzzzzzzzzzr_ = yzzzzzzzzzzzzzzzzzzzzzzzzq_?.Effective;
                    object yzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzr_);
                    bool yzzzzzzzzzzzzzzzzzzzzzzzzt_ = yzzzzzzzzzzzzzzzzzzzzzzzzs_ is CqlInterval<CqlDateTime>;

                    return yzzzzzzzzzzzzzzzzzzzzzzzzt_;
                };
                bool vzzzzzzzzzzzzzzzzzzzzzzzzo_()
                {
                    CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
                    IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? bzzzzzzzzzzzzzzzzzzzzzzzzzh_(Observation O2Saturation)
                    {
                        object bzzzzzzzzzzzzzzzzzzzzzzzzzp_()
                        {
                            bool czzzzzzzzzzzzzzzzzzzzzzzzzo_()
                            {
                                DataType czzzzzzzzzzzzzzzzzzzzzzzzzr_ = O2Saturation?.Effective;
                                object czzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzzzzr_);
                                bool czzzzzzzzzzzzzzzzzzzzzzzzzt_ = czzzzzzzzzzzzzzzzzzzzzzzzzs_ is CqlDateTime;

                                return czzzzzzzzzzzzzzzzzzzzzzzzzt_;
                            };
                            bool czzzzzzzzzzzzzzzzzzzzzzzzzp_()
                            {
                                DataType czzzzzzzzzzzzzzzzzzzzzzzzzu_ = O2Saturation?.Effective;
                                object czzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzzzzu_);
                                bool czzzzzzzzzzzzzzzzzzzzzzzzzw_ = czzzzzzzzzzzzzzzzzzzzzzzzzv_ is CqlInterval<CqlDateTime>;

                                return czzzzzzzzzzzzzzzzzzzzzzzzzw_;
                            };
                            bool czzzzzzzzzzzzzzzzzzzzzzzzzq_()
                            {
                                DataType czzzzzzzzzzzzzzzzzzzzzzzzzx_ = O2Saturation?.Effective;
                                object czzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzzzzx_);
                                bool czzzzzzzzzzzzzzzzzzzzzzzzzz_ = czzzzzzzzzzzzzzzzzzzzzzzzzy_ is CqlDateTime;

                                return czzzzzzzzzzzzzzzzzzzzzzzzzz_;
                            };
                            if (czzzzzzzzzzzzzzzzzzzzzzzzzo_())
                            {
                                DataType dzzzzzzzzzzzzzzzzzzzzzzzzza_ = O2Saturation?.Effective;
                                object dzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzza_);

                                return (dzzzzzzzzzzzzzzzzzzzzzzzzzb_ as CqlDateTime) as object;
                            }
                            else if (czzzzzzzzzzzzzzzzzzzzzzzzzp_())
                            {
                                DataType dzzzzzzzzzzzzzzzzzzzzzzzzzc_ = O2Saturation?.Effective;
                                object dzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzc_);

                                return (dzzzzzzzzzzzzzzzzzzzzzzzzzd_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (czzzzzzzzzzzzzzzzzzzzzzzzzq_())
                            {
                                DataType dzzzzzzzzzzzzzzzzzzzzzzzzze_ = O2Saturation?.Effective;
                                object dzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzze_);

                                return (dzzzzzzzzzzzzzzzzzzzzzzzzzf_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.earliest(context, bzzzzzzzzzzzzzzzzzzzzzzzzzp_());
                        Period bzzzzzzzzzzzzzzzzzzzzzzzzzr_ = EncounterInpatient?.Period;
                        CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                        CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                        CqlQuantity bzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Quantity(1440m, "minutes");
                        CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Subtract(bzzzzzzzzzzzzzzzzzzzzzzzzzt_, bzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                        CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                        CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                        CqlQuantity bzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Quantity(120m, "minutes");
                        CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Add(bzzzzzzzzzzzzzzzzzzzzzzzzzy_, bzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                        CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Interval(bzzzzzzzzzzzzzzzzzzzzzzzzzv_, czzzzzzzzzzzzzzzzzzzzzzzzza_, true, true);
                        bool? czzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.In<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzzzzzzq_, czzzzzzzzzzzzzzzzzzzzzzzzzb_, default);
                        Code<ObservationStatus> czzzzzzzzzzzzzzzzzzzzzzzzzd_ = O2Saturation?.StatusElement;
                        ObservationStatus? czzzzzzzzzzzzzzzzzzzzzzzzze_ = czzzzzzzzzzzzzzzzzzzzzzzzzd_?.Value;
                        Code<ObservationStatus> czzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<Code<ObservationStatus>>(czzzzzzzzzzzzzzzzzzzzzzzzze_);
                        string czzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<string>(czzzzzzzzzzzzzzzzzzzzzzzzzf_);
                        string[] czzzzzzzzzzzzzzzzzzzzzzzzzh_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? czzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.In<string>(czzzzzzzzzzzzzzzzzzzzzzzzzg_, czzzzzzzzzzzzzzzzzzzzzzzzzh_ as IEnumerable<string>);
                        bool? czzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzzzzzzc_, czzzzzzzzzzzzzzzzzzzzzzzzzi_);
                        DataType czzzzzzzzzzzzzzzzzzzzzzzzzk_ = O2Saturation?.Value;
                        object czzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzzzzk_);
                        bool? czzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Not((bool?)(czzzzzzzzzzzzzzzzzzzzzzzzzl_ is null));
                        bool? czzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzzzzzzj_, czzzzzzzzzzzzzzzzzzzzzzzzzm_);

                        return czzzzzzzzzzzzzzzzzzzzzzzzzn_;
                    };
                    IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Observation>(bzzzzzzzzzzzzzzzzzzzzzzzzzg_, bzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                    object bzzzzzzzzzzzzzzzzzzzzzzzzzj_(Observation @this)
                    {
                        object dzzzzzzzzzzzzzzzzzzzzzzzzzg_()
                        {
                            bool dzzzzzzzzzzzzzzzzzzzzzzzzzi_()
                            {
                                DataType dzzzzzzzzzzzzzzzzzzzzzzzzzl_ = @this?.Effective;
                                object dzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                                bool dzzzzzzzzzzzzzzzzzzzzzzzzzn_ = dzzzzzzzzzzzzzzzzzzzzzzzzzm_ is CqlDateTime;

                                return dzzzzzzzzzzzzzzzzzzzzzzzzzn_;
                            };
                            bool dzzzzzzzzzzzzzzzzzzzzzzzzzj_()
                            {
                                DataType dzzzzzzzzzzzzzzzzzzzzzzzzzo_ = @this?.Effective;
                                object dzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                                bool dzzzzzzzzzzzzzzzzzzzzzzzzzq_ = dzzzzzzzzzzzzzzzzzzzzzzzzzp_ is CqlInterval<CqlDateTime>;

                                return dzzzzzzzzzzzzzzzzzzzzzzzzzq_;
                            };
                            bool dzzzzzzzzzzzzzzzzzzzzzzzzzk_()
                            {
                                DataType dzzzzzzzzzzzzzzzzzzzzzzzzzr_ = @this?.Effective;
                                object dzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                                bool dzzzzzzzzzzzzzzzzzzzzzzzzzt_ = dzzzzzzzzzzzzzzzzzzzzzzzzzs_ is CqlDateTime;

                                return dzzzzzzzzzzzzzzzzzzzzzzzzzt_;
                            };
                            if (dzzzzzzzzzzzzzzzzzzzzzzzzzi_())
                            {
                                DataType dzzzzzzzzzzzzzzzzzzzzzzzzzu_ = @this?.Effective;
                                object dzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzu_);

                                return (dzzzzzzzzzzzzzzzzzzzzzzzzzv_ as CqlDateTime) as object;
                            }
                            else if (dzzzzzzzzzzzzzzzzzzzzzzzzzj_())
                            {
                                DataType dzzzzzzzzzzzzzzzzzzzzzzzzzw_ = @this?.Effective;
                                object dzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzw_);

                                return (dzzzzzzzzzzzzzzzzzzzzzzzzzx_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (dzzzzzzzzzzzzzzzzzzzzzzzzzk_())
                            {
                                DataType dzzzzzzzzzzzzzzzzzzzzzzzzzy_ = @this?.Effective;
                                object dzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzy_);

                                return (dzzzzzzzzzzzzzzzzzzzzzzzzzz_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.earliest(context, dzzzzzzzzzzzzzzzzzzzzzzzzzg_());

                        return dzzzzzzzzzzzzzzzzzzzzzzzzzh_;
                    };
                    IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.SortBy<Observation>(bzzzzzzzzzzzzzzzzzzzzzzzzzi_, bzzzzzzzzzzzzzzzzzzzzzzzzzj_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation bzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.First<Observation>(bzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                    DataType bzzzzzzzzzzzzzzzzzzzzzzzzzm_ = bzzzzzzzzzzzzzzzzzzzzzzzzzl_?.Effective;
                    object bzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                    bool bzzzzzzzzzzzzzzzzzzzzzzzzzo_ = bzzzzzzzzzzzzzzzzzzzzzzzzzn_ is CqlDateTime;

                    return bzzzzzzzzzzzzzzzzzzzzzzzzzo_;
                };
                if (vzzzzzzzzzzzzzzzzzzzzzzzzm_())
                {
                    CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
                    IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? ezzzzzzzzzzzzzzzzzzzzzzzzzc_(Observation O2Saturation)
                    {
                        object ezzzzzzzzzzzzzzzzzzzzzzzzzj_()
                        {
                            bool fzzzzzzzzzzzzzzzzzzzzzzzzzi_()
                            {
                                DataType fzzzzzzzzzzzzzzzzzzzzzzzzzl_ = O2Saturation?.Effective;
                                object fzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                                bool fzzzzzzzzzzzzzzzzzzzzzzzzzn_ = fzzzzzzzzzzzzzzzzzzzzzzzzzm_ is CqlDateTime;

                                return fzzzzzzzzzzzzzzzzzzzzzzzzzn_;
                            };
                            bool fzzzzzzzzzzzzzzzzzzzzzzzzzj_()
                            {
                                DataType fzzzzzzzzzzzzzzzzzzzzzzzzzo_ = O2Saturation?.Effective;
                                object fzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                                bool fzzzzzzzzzzzzzzzzzzzzzzzzzq_ = fzzzzzzzzzzzzzzzzzzzzzzzzzp_ is CqlInterval<CqlDateTime>;

                                return fzzzzzzzzzzzzzzzzzzzzzzzzzq_;
                            };
                            bool fzzzzzzzzzzzzzzzzzzzzzzzzzk_()
                            {
                                DataType fzzzzzzzzzzzzzzzzzzzzzzzzzr_ = O2Saturation?.Effective;
                                object fzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                                bool fzzzzzzzzzzzzzzzzzzzzzzzzzt_ = fzzzzzzzzzzzzzzzzzzzzzzzzzs_ is CqlDateTime;

                                return fzzzzzzzzzzzzzzzzzzzzzzzzzt_;
                            };
                            if (fzzzzzzzzzzzzzzzzzzzzzzzzzi_())
                            {
                                DataType fzzzzzzzzzzzzzzzzzzzzzzzzzu_ = O2Saturation?.Effective;
                                object fzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzu_);

                                return (fzzzzzzzzzzzzzzzzzzzzzzzzzv_ as CqlDateTime) as object;
                            }
                            else if (fzzzzzzzzzzzzzzzzzzzzzzzzzj_())
                            {
                                DataType fzzzzzzzzzzzzzzzzzzzzzzzzzw_ = O2Saturation?.Effective;
                                object fzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzw_);

                                return (fzzzzzzzzzzzzzzzzzzzzzzzzzx_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (fzzzzzzzzzzzzzzzzzzzzzzzzzk_())
                            {
                                DataType fzzzzzzzzzzzzzzzzzzzzzzzzzy_ = O2Saturation?.Effective;
                                object fzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzy_);

                                return (fzzzzzzzzzzzzzzzzzzzzzzzzzz_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.earliest(context, ezzzzzzzzzzzzzzzzzzzzzzzzzj_());
                        Period ezzzzzzzzzzzzzzzzzzzzzzzzzl_ = EncounterInpatient?.Period;
                        CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzzzzzzzzzzzzzzzzzzl_);
                        CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzzzzzzzzzm_);
                        CqlQuantity ezzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Quantity(1440m, "minutes");
                        CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Subtract(ezzzzzzzzzzzzzzzzzzzzzzzzzn_, ezzzzzzzzzzzzzzzzzzzzzzzzzo_);
                        CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzzzzzzzzzzzzzzzzzzl_);
                        CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzzzzzzzzzr_);
                        CqlQuantity ezzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Quantity(120m, "minutes");
                        CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Add(ezzzzzzzzzzzzzzzzzzzzzzzzzs_, ezzzzzzzzzzzzzzzzzzzzzzzzzt_);
                        CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Interval(ezzzzzzzzzzzzzzzzzzzzzzzzzp_, ezzzzzzzzzzzzzzzzzzzzzzzzzu_, true, true);
                        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.In<CqlDateTime>(ezzzzzzzzzzzzzzzzzzzzzzzzzk_, ezzzzzzzzzzzzzzzzzzzzzzzzzv_, default);
                        Code<ObservationStatus> ezzzzzzzzzzzzzzzzzzzzzzzzzx_ = O2Saturation?.StatusElement;
                        ObservationStatus? ezzzzzzzzzzzzzzzzzzzzzzzzzy_ = ezzzzzzzzzzzzzzzzzzzzzzzzzx_?.Value;
                        Code<ObservationStatus> ezzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Convert<Code<ObservationStatus>>(ezzzzzzzzzzzzzzzzzzzzzzzzzy_);
                        string fzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<string>(ezzzzzzzzzzzzzzzzzzzzzzzzzz_);
                        string[] fzzzzzzzzzzzzzzzzzzzzzzzzzb_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.In<string>(fzzzzzzzzzzzzzzzzzzzzzzzzza_, fzzzzzzzzzzzzzzzzzzzzzzzzzb_ as IEnumerable<string>);
                        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(ezzzzzzzzzzzzzzzzzzzzzzzzzw_, fzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                        DataType fzzzzzzzzzzzzzzzzzzzzzzzzze_ = O2Saturation?.Value;
                        object fzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzze_);
                        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Not((bool?)(fzzzzzzzzzzzzzzzzzzzzzzzzzf_ is null));
                        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzzzzd_, fzzzzzzzzzzzzzzzzzzzzzzzzzg_);

                        return fzzzzzzzzzzzzzzzzzzzzzzzzzh_;
                    };
                    IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Observation>(ezzzzzzzzzzzzzzzzzzzzzzzzzb_, ezzzzzzzzzzzzzzzzzzzzzzzzzc_);
                    object ezzzzzzzzzzzzzzzzzzzzzzzzze_(Observation @this)
                    {
                        object gzzzzzzzzzzzzzzzzzzzzzzzzza_()
                        {
                            bool gzzzzzzzzzzzzzzzzzzzzzzzzzc_()
                            {
                                DataType gzzzzzzzzzzzzzzzzzzzzzzzzzf_ = @this?.Effective;
                                object gzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                                bool gzzzzzzzzzzzzzzzzzzzzzzzzzh_ = gzzzzzzzzzzzzzzzzzzzzzzzzzg_ is CqlDateTime;

                                return gzzzzzzzzzzzzzzzzzzzzzzzzzh_;
                            };
                            bool gzzzzzzzzzzzzzzzzzzzzzzzzzd_()
                            {
                                DataType gzzzzzzzzzzzzzzzzzzzzzzzzzi_ = @this?.Effective;
                                object gzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                                bool gzzzzzzzzzzzzzzzzzzzzzzzzzk_ = gzzzzzzzzzzzzzzzzzzzzzzzzzj_ is CqlInterval<CqlDateTime>;

                                return gzzzzzzzzzzzzzzzzzzzzzzzzzk_;
                            };
                            bool gzzzzzzzzzzzzzzzzzzzzzzzzze_()
                            {
                                DataType gzzzzzzzzzzzzzzzzzzzzzzzzzl_ = @this?.Effective;
                                object gzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                                bool gzzzzzzzzzzzzzzzzzzzzzzzzzn_ = gzzzzzzzzzzzzzzzzzzzzzzzzzm_ is CqlDateTime;

                                return gzzzzzzzzzzzzzzzzzzzzzzzzzn_;
                            };
                            if (gzzzzzzzzzzzzzzzzzzzzzzzzzc_())
                            {
                                DataType gzzzzzzzzzzzzzzzzzzzzzzzzzo_ = @this?.Effective;
                                object gzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzo_);

                                return (gzzzzzzzzzzzzzzzzzzzzzzzzzp_ as CqlDateTime) as object;
                            }
                            else if (gzzzzzzzzzzzzzzzzzzzzzzzzzd_())
                            {
                                DataType gzzzzzzzzzzzzzzzzzzzzzzzzzq_ = @this?.Effective;
                                object gzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzq_);

                                return (gzzzzzzzzzzzzzzzzzzzzzzzzzr_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (gzzzzzzzzzzzzzzzzzzzzzzzzze_())
                            {
                                DataType gzzzzzzzzzzzzzzzzzzzzzzzzzs_ = @this?.Effective;
                                object gzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzs_);

                                return (gzzzzzzzzzzzzzzzzzzzzzzzzzt_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.earliest(context, gzzzzzzzzzzzzzzzzzzzzzzzzza_());

                        return gzzzzzzzzzzzzzzzzzzzzzzzzzb_;
                    };
                    IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.SortBy<Observation>(ezzzzzzzzzzzzzzzzzzzzzzzzzd_, ezzzzzzzzzzzzzzzzzzzzzzzzze_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation ezzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.First<Observation>(ezzzzzzzzzzzzzzzzzzzzzzzzzf_);
                    DataType ezzzzzzzzzzzzzzzzzzzzzzzzzh_ = ezzzzzzzzzzzzzzzzzzzzzzzzzg_?.Effective;
                    object ezzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzzzh_);

                    return (ezzzzzzzzzzzzzzzzzzzzzzzzzi_ as CqlDateTime) as object;
                }
                else if (vzzzzzzzzzzzzzzzzzzzzzzzzn_())
                {
                    CqlValueSet gzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
                    IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? gzzzzzzzzzzzzzzzzzzzzzzzzzw_(Observation O2Saturation)
                    {
                        object hzzzzzzzzzzzzzzzzzzzzzzzzzd_()
                        {
                            bool izzzzzzzzzzzzzzzzzzzzzzzzzc_()
                            {
                                DataType izzzzzzzzzzzzzzzzzzzzzzzzzf_ = O2Saturation?.Effective;
                                object izzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzf_);
                                bool izzzzzzzzzzzzzzzzzzzzzzzzzh_ = izzzzzzzzzzzzzzzzzzzzzzzzzg_ is CqlDateTime;

                                return izzzzzzzzzzzzzzzzzzzzzzzzzh_;
                            };
                            bool izzzzzzzzzzzzzzzzzzzzzzzzzd_()
                            {
                                DataType izzzzzzzzzzzzzzzzzzzzzzzzzi_ = O2Saturation?.Effective;
                                object izzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzi_);
                                bool izzzzzzzzzzzzzzzzzzzzzzzzzk_ = izzzzzzzzzzzzzzzzzzzzzzzzzj_ is CqlInterval<CqlDateTime>;

                                return izzzzzzzzzzzzzzzzzzzzzzzzzk_;
                            };
                            bool izzzzzzzzzzzzzzzzzzzzzzzzze_()
                            {
                                DataType izzzzzzzzzzzzzzzzzzzzzzzzzl_ = O2Saturation?.Effective;
                                object izzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzl_);
                                bool izzzzzzzzzzzzzzzzzzzzzzzzzn_ = izzzzzzzzzzzzzzzzzzzzzzzzzm_ is CqlDateTime;

                                return izzzzzzzzzzzzzzzzzzzzzzzzzn_;
                            };
                            if (izzzzzzzzzzzzzzzzzzzzzzzzzc_())
                            {
                                DataType izzzzzzzzzzzzzzzzzzzzzzzzzo_ = O2Saturation?.Effective;
                                object izzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzo_);

                                return (izzzzzzzzzzzzzzzzzzzzzzzzzp_ as CqlDateTime) as object;
                            }
                            else if (izzzzzzzzzzzzzzzzzzzzzzzzzd_())
                            {
                                DataType izzzzzzzzzzzzzzzzzzzzzzzzzq_ = O2Saturation?.Effective;
                                object izzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzq_);

                                return (izzzzzzzzzzzzzzzzzzzzzzzzzr_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (izzzzzzzzzzzzzzzzzzzzzzzzze_())
                            {
                                DataType izzzzzzzzzzzzzzzzzzzzzzzzzs_ = O2Saturation?.Effective;
                                object izzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzs_);

                                return (izzzzzzzzzzzzzzzzzzzzzzzzzt_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.earliest(context, hzzzzzzzzzzzzzzzzzzzzzzzzzd_());
                        Period hzzzzzzzzzzzzzzzzzzzzzzzzzf_ = EncounterInpatient?.Period;
                        CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                        CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Start(hzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                        CqlQuantity hzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Quantity(1440m, "minutes");
                        CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Subtract(hzzzzzzzzzzzzzzzzzzzzzzzzzh_, hzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                        CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                        CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(hzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                        CqlQuantity hzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Quantity(120m, "minutes");
                        CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Add(hzzzzzzzzzzzzzzzzzzzzzzzzzm_, hzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                        CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Interval(hzzzzzzzzzzzzzzzzzzzzzzzzzj_, hzzzzzzzzzzzzzzzzzzzzzzzzzo_, true, true);
                        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.In<CqlDateTime>(hzzzzzzzzzzzzzzzzzzzzzzzzze_, hzzzzzzzzzzzzzzzzzzzzzzzzzp_, default);
                        Code<ObservationStatus> hzzzzzzzzzzzzzzzzzzzzzzzzzr_ = O2Saturation?.StatusElement;
                        ObservationStatus? hzzzzzzzzzzzzzzzzzzzzzzzzzs_ = hzzzzzzzzzzzzzzzzzzzzzzzzzr_?.Value;
                        Code<ObservationStatus> hzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Convert<Code<ObservationStatus>>(hzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                        string hzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Convert<string>(hzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                        string[] hzzzzzzzzzzzzzzzzzzzzzzzzzv_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.In<string>(hzzzzzzzzzzzzzzzzzzzzzzzzzu_, hzzzzzzzzzzzzzzzzzzzzzzzzzv_ as IEnumerable<string>);
                        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzzzzzq_, hzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                        DataType hzzzzzzzzzzzzzzzzzzzzzzzzzy_ = O2Saturation?.Value;
                        object hzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                        bool? izzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Not((bool?)(hzzzzzzzzzzzzzzzzzzzzzzzzzz_ is null));
                        bool? izzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzzzzzx_, izzzzzzzzzzzzzzzzzzzzzzzzza_);

                        return izzzzzzzzzzzzzzzzzzzzzzzzzb_;
                    };
                    IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Observation>(gzzzzzzzzzzzzzzzzzzzzzzzzzv_, gzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                    object gzzzzzzzzzzzzzzzzzzzzzzzzzy_(Observation @this)
                    {
                        object izzzzzzzzzzzzzzzzzzzzzzzzzu_()
                        {
                            bool izzzzzzzzzzzzzzzzzzzzzzzzzw_()
                            {
                                DataType izzzzzzzzzzzzzzzzzzzzzzzzzz_ = @this?.Effective;
                                object jzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzz_);
                                bool jzzzzzzzzzzzzzzzzzzzzzzzzzb_ = jzzzzzzzzzzzzzzzzzzzzzzzzza_ is CqlDateTime;

                                return jzzzzzzzzzzzzzzzzzzzzzzzzzb_;
                            };
                            bool izzzzzzzzzzzzzzzzzzzzzzzzzx_()
                            {
                                DataType jzzzzzzzzzzzzzzzzzzzzzzzzzc_ = @this?.Effective;
                                object jzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                                bool jzzzzzzzzzzzzzzzzzzzzzzzzze_ = jzzzzzzzzzzzzzzzzzzzzzzzzzd_ is CqlInterval<CqlDateTime>;

                                return jzzzzzzzzzzzzzzzzzzzzzzzzze_;
                            };
                            bool izzzzzzzzzzzzzzzzzzzzzzzzzy_()
                            {
                                DataType jzzzzzzzzzzzzzzzzzzzzzzzzzf_ = @this?.Effective;
                                object jzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                                bool jzzzzzzzzzzzzzzzzzzzzzzzzzh_ = jzzzzzzzzzzzzzzzzzzzzzzzzzg_ is CqlDateTime;

                                return jzzzzzzzzzzzzzzzzzzzzzzzzzh_;
                            };
                            if (izzzzzzzzzzzzzzzzzzzzzzzzzw_())
                            {
                                DataType jzzzzzzzzzzzzzzzzzzzzzzzzzi_ = @this?.Effective;
                                object jzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzi_);

                                return (jzzzzzzzzzzzzzzzzzzzzzzzzzj_ as CqlDateTime) as object;
                            }
                            else if (izzzzzzzzzzzzzzzzzzzzzzzzzx_())
                            {
                                DataType jzzzzzzzzzzzzzzzzzzzzzzzzzk_ = @this?.Effective;
                                object jzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzk_);

                                return (jzzzzzzzzzzzzzzzzzzzzzzzzzl_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (izzzzzzzzzzzzzzzzzzzzzzzzzy_())
                            {
                                DataType jzzzzzzzzzzzzzzzzzzzzzzzzzm_ = @this?.Effective;
                                object jzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzm_);

                                return (jzzzzzzzzzzzzzzzzzzzzzzzzzn_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.earliest(context, izzzzzzzzzzzzzzzzzzzzzzzzzu_());

                        return izzzzzzzzzzzzzzzzzzzzzzzzzv_;
                    };
                    IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.SortBy<Observation>(gzzzzzzzzzzzzzzzzzzzzzzzzzx_, gzzzzzzzzzzzzzzzzzzzzzzzzzy_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation hzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.First<Observation>(gzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                    DataType hzzzzzzzzzzzzzzzzzzzzzzzzzb_ = hzzzzzzzzzzzzzzzzzzzzzzzzza_?.Effective;
                    object hzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzzb_);

                    return (hzzzzzzzzzzzzzzzzzzzzzzzzzc_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (vzzzzzzzzzzzzzzzzzzzzzzzzo_())
                {
                    CqlValueSet jzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
                    IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? jzzzzzzzzzzzzzzzzzzzzzzzzzq_(Observation O2Saturation)
                    {
                        object jzzzzzzzzzzzzzzzzzzzzzzzzzx_()
                        {
                            bool kzzzzzzzzzzzzzzzzzzzzzzzzzw_()
                            {
                                DataType kzzzzzzzzzzzzzzzzzzzzzzzzzz_ = O2Saturation?.Effective;
                                object lzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                                bool lzzzzzzzzzzzzzzzzzzzzzzzzzb_ = lzzzzzzzzzzzzzzzzzzzzzzzzza_ is CqlDateTime;

                                return lzzzzzzzzzzzzzzzzzzzzzzzzzb_;
                            };
                            bool kzzzzzzzzzzzzzzzzzzzzzzzzzx_()
                            {
                                DataType lzzzzzzzzzzzzzzzzzzzzzzzzzc_ = O2Saturation?.Effective;
                                object lzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                                bool lzzzzzzzzzzzzzzzzzzzzzzzzze_ = lzzzzzzzzzzzzzzzzzzzzzzzzzd_ is CqlInterval<CqlDateTime>;

                                return lzzzzzzzzzzzzzzzzzzzzzzzzze_;
                            };
                            bool kzzzzzzzzzzzzzzzzzzzzzzzzzy_()
                            {
                                DataType lzzzzzzzzzzzzzzzzzzzzzzzzzf_ = O2Saturation?.Effective;
                                object lzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                                bool lzzzzzzzzzzzzzzzzzzzzzzzzzh_ = lzzzzzzzzzzzzzzzzzzzzzzzzzg_ is CqlDateTime;

                                return lzzzzzzzzzzzzzzzzzzzzzzzzzh_;
                            };
                            if (kzzzzzzzzzzzzzzzzzzzzzzzzzw_())
                            {
                                DataType lzzzzzzzzzzzzzzzzzzzzzzzzzi_ = O2Saturation?.Effective;
                                object lzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzi_);

                                return (lzzzzzzzzzzzzzzzzzzzzzzzzzj_ as CqlDateTime) as object;
                            }
                            else if (kzzzzzzzzzzzzzzzzzzzzzzzzzx_())
                            {
                                DataType lzzzzzzzzzzzzzzzzzzzzzzzzzk_ = O2Saturation?.Effective;
                                object lzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzk_);

                                return (lzzzzzzzzzzzzzzzzzzzzzzzzzl_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (kzzzzzzzzzzzzzzzzzzzzzzzzzy_())
                            {
                                DataType lzzzzzzzzzzzzzzzzzzzzzzzzzm_ = O2Saturation?.Effective;
                                object lzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzm_);

                                return (lzzzzzzzzzzzzzzzzzzzzzzzzzn_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.earliest(context, jzzzzzzzzzzzzzzzzzzzzzzzzzx_());
                        Period jzzzzzzzzzzzzzzzzzzzzzzzzzz_ = EncounterInpatient?.Period;
                        CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                        CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzzzzzzza_);
                        CqlQuantity kzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Quantity(1440m, "minutes");
                        CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Subtract(kzzzzzzzzzzzzzzzzzzzzzzzzzb_, kzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                        CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                        CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                        CqlQuantity kzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Quantity(120m, "minutes");
                        CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Add(kzzzzzzzzzzzzzzzzzzzzzzzzzg_, kzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                        CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Interval(kzzzzzzzzzzzzzzzzzzzzzzzzzd_, kzzzzzzzzzzzzzzzzzzzzzzzzzi_, true, true);
                        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzzzzzzzzzzzzzzzzzy_, kzzzzzzzzzzzzzzzzzzzzzzzzzj_, default);
                        Code<ObservationStatus> kzzzzzzzzzzzzzzzzzzzzzzzzzl_ = O2Saturation?.StatusElement;
                        ObservationStatus? kzzzzzzzzzzzzzzzzzzzzzzzzzm_ = kzzzzzzzzzzzzzzzzzzzzzzzzzl_?.Value;
                        Code<ObservationStatus> kzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Convert<Code<ObservationStatus>>(kzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                        string kzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Convert<string>(kzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                        string[] kzzzzzzzzzzzzzzzzzzzzzzzzzp_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.In<string>(kzzzzzzzzzzzzzzzzzzzzzzzzzo_, kzzzzzzzzzzzzzzzzzzzzzzzzzp_ as IEnumerable<string>);
                        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzzzzk_, kzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                        DataType kzzzzzzzzzzzzzzzzzzzzzzzzzs_ = O2Saturation?.Value;
                        object kzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Not((bool?)(kzzzzzzzzzzzzzzzzzzzzzzzzzt_ is null));
                        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzzzzr_, kzzzzzzzzzzzzzzzzzzzzzzzzzu_);

                        return kzzzzzzzzzzzzzzzzzzzzzzzzzv_;
                    };
                    IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Observation>(jzzzzzzzzzzzzzzzzzzzzzzzzzp_, jzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                    object jzzzzzzzzzzzzzzzzzzzzzzzzzs_(Observation @this)
                    {
                        object lzzzzzzzzzzzzzzzzzzzzzzzzzo_()
                        {
                            bool lzzzzzzzzzzzzzzzzzzzzzzzzzq_()
                            {
                                DataType lzzzzzzzzzzzzzzzzzzzzzzzzzt_ = @this?.Effective;
                                object lzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                                bool lzzzzzzzzzzzzzzzzzzzzzzzzzv_ = lzzzzzzzzzzzzzzzzzzzzzzzzzu_ is CqlDateTime;

                                return lzzzzzzzzzzzzzzzzzzzzzzzzzv_;
                            };
                            bool lzzzzzzzzzzzzzzzzzzzzzzzzzr_()
                            {
                                DataType lzzzzzzzzzzzzzzzzzzzzzzzzzw_ = @this?.Effective;
                                object lzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                                bool lzzzzzzzzzzzzzzzzzzzzzzzzzy_ = lzzzzzzzzzzzzzzzzzzzzzzzzzx_ is CqlInterval<CqlDateTime>;

                                return lzzzzzzzzzzzzzzzzzzzzzzzzzy_;
                            };
                            bool lzzzzzzzzzzzzzzzzzzzzzzzzzs_()
                            {
                                DataType lzzzzzzzzzzzzzzzzzzzzzzzzzz_ = @this?.Effective;
                                object mzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                                bool mzzzzzzzzzzzzzzzzzzzzzzzzzb_ = mzzzzzzzzzzzzzzzzzzzzzzzzza_ is CqlDateTime;

                                return mzzzzzzzzzzzzzzzzzzzzzzzzzb_;
                            };
                            if (lzzzzzzzzzzzzzzzzzzzzzzzzzq_())
                            {
                                DataType mzzzzzzzzzzzzzzzzzzzzzzzzzc_ = @this?.Effective;
                                object mzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzc_);

                                return (mzzzzzzzzzzzzzzzzzzzzzzzzzd_ as CqlDateTime) as object;
                            }
                            else if (lzzzzzzzzzzzzzzzzzzzzzzzzzr_())
                            {
                                DataType mzzzzzzzzzzzzzzzzzzzzzzzzze_ = @this?.Effective;
                                object mzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzze_);

                                return (mzzzzzzzzzzzzzzzzzzzzzzzzzf_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (lzzzzzzzzzzzzzzzzzzzzzzzzzs_())
                            {
                                DataType mzzzzzzzzzzzzzzzzzzzzzzzzzg_ = @this?.Effective;
                                object mzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzg_);

                                return (mzzzzzzzzzzzzzzzzzzzzzzzzzh_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.earliest(context, lzzzzzzzzzzzzzzzzzzzzzzzzzo_());

                        return lzzzzzzzzzzzzzzzzzzzzzzzzzp_;
                    };
                    IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.SortBy<Observation>(jzzzzzzzzzzzzzzzzzzzzzzzzzr_, jzzzzzzzzzzzzzzzzzzzzzzzzzs_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation jzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.First<Observation>(jzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                    DataType jzzzzzzzzzzzzzzzzzzzzzzzzzv_ = jzzzzzzzzzzzzzzzzzzzzzzzzzu_?.Effective;
                    object jzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzv_);

                    return (jzzzzzzzzzzzzzzzzzzzzzzzzzw_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.earliest(context, szzzzzzzzzzzzzzzzzzzzzzzzy_());
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)? tzzzzzzzzzzzzzzzzzzzzzzzza_ = (CqlTupleMetadata_FdREYEdHOZIcMCNYCRFJYJReA, szzzzzzzzzzzzzzzzzzzzzzzzo_, szzzzzzzzzzzzzzzzzzzzzzzzx_ as CqlQuantity, szzzzzzzzzzzzzzzzzzzzzzzzz_);

            return tzzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)?> szzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)?>(szzzzzzzzzzzzzzzzzzzzzzzzj_, szzzzzzzzzzzzzzzzzzzzzzzzk_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)?> szzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)?>(szzzzzzzzzzzzzzzzzzzzzzzzl_);

        return szzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Encounter with First Bicarbonate Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)?> Encounter_with_First_Bicarbonate_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)? mzzzzzzzzzzzzzzzzzzzzzzzzzj_(Encounter EncounterInpatient)
        {
            Id mzzzzzzzzzzzzzzzzzzzzzzzzzm_ = EncounterInpatient?.IdElement;
            string mzzzzzzzzzzzzzzzzzzzzzzzzzn_ = mzzzzzzzzzzzzzzzzzzzzzzzzzm_?.Value;
            CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Bicarbonate_lab_test(context);
            IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzq_(Observation BicarbonateLab)
            {
                Instant nzzzzzzzzzzzzzzzzzzzzzzzzzi_ = BicarbonateLab?.IssuedElement;
                DateTimeOffset? nzzzzzzzzzzzzzzzzzzzzzzzzzj_ = nzzzzzzzzzzzzzzzzzzzzzzzzzi_?.Value;
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<CqlDateTime>(nzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.earliest(context, nzzzzzzzzzzzzzzzzzzzzzzzzzk_ as object);
                Period nzzzzzzzzzzzzzzzzzzzzzzzzzm_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlQuantity nzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Subtract(nzzzzzzzzzzzzzzzzzzzzzzzzzo_, nzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Add(nzzzzzzzzzzzzzzzzzzzzzzzzzt_, nzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Interval(nzzzzzzzzzzzzzzzzzzzzzzzzzq_, nzzzzzzzzzzzzzzzzzzzzzzzzzv_, true, true);
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.In<CqlDateTime>(nzzzzzzzzzzzzzzzzzzzzzzzzzl_, nzzzzzzzzzzzzzzzzzzzzzzzzzw_, default);
                Code<ObservationStatus> nzzzzzzzzzzzzzzzzzzzzzzzzzy_ = BicarbonateLab?.StatusElement;
                ObservationStatus? nzzzzzzzzzzzzzzzzzzzzzzzzzz_ = nzzzzzzzzzzzzzzzzzzzzzzzzzy_?.Value;
                string ozzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<string>(nzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                string[] ozzzzzzzzzzzzzzzzzzzzzzzzzb_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.In<string>(ozzzzzzzzzzzzzzzzzzzzzzzzza_, ozzzzzzzzzzzzzzzzzzzzzzzzzb_ as IEnumerable<string>);
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzzzx_, ozzzzzzzzzzzzzzzzzzzzzzzzzc_);
                DataType ozzzzzzzzzzzzzzzzzzzzzzzzze_ = BicarbonateLab?.Value;
                object ozzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzze_);
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Not((bool?)(ozzzzzzzzzzzzzzzzzzzzzzzzzf_ is null));
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzzzd_, ozzzzzzzzzzzzzzzzzzzzzzzzzg_);

                return ozzzzzzzzzzzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Observation>(mzzzzzzzzzzzzzzzzzzzzzzzzzp_, mzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            object mzzzzzzzzzzzzzzzzzzzzzzzzzs_(Observation @this)
            {
                Instant ozzzzzzzzzzzzzzzzzzzzzzzzzi_ = @this?.IssuedElement;
                DateTimeOffset? ozzzzzzzzzzzzzzzzzzzzzzzzzj_ = ozzzzzzzzzzzzzzzzzzzzzzzzzi_?.Value;
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<CqlDateTime>(ozzzzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.earliest(context, ozzzzzzzzzzzzzzzzzzzzzzzzzk_ as object);

                return ozzzzzzzzzzzzzzzzzzzzzzzzzl_;
            };
            IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.SortBy<Observation>(mzzzzzzzzzzzzzzzzzzzzzzzzzr_, mzzzzzzzzzzzzzzzzzzzzzzzzzs_, System.ComponentModel.ListSortDirection.Ascending);
            Observation mzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.First<Observation>(mzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            DataType mzzzzzzzzzzzzzzzzzzzzzzzzzv_ = mzzzzzzzzzzzzzzzzzzzzzzzzzu_?.Value;
            object mzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzz_(Observation BicarbonateLab)
            {
                Instant ozzzzzzzzzzzzzzzzzzzzzzzzzm_ = BicarbonateLab?.IssuedElement;
                DateTimeOffset? ozzzzzzzzzzzzzzzzzzzzzzzzzn_ = ozzzzzzzzzzzzzzzzzzzzzzzzzm_?.Value;
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Convert<CqlDateTime>(ozzzzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.earliest(context, ozzzzzzzzzzzzzzzzzzzzzzzzzo_ as object);
                Period ozzzzzzzzzzzzzzzzzzzzzzzzzq_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlQuantity ozzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Subtract(ozzzzzzzzzzzzzzzzzzzzzzzzzs_, ozzzzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Add(ozzzzzzzzzzzzzzzzzzzzzzzzzx_, ozzzzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Interval(ozzzzzzzzzzzzzzzzzzzzzzzzzu_, ozzzzzzzzzzzzzzzzzzzzzzzzzz_, true, true);
                bool? pzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDateTime>(ozzzzzzzzzzzzzzzzzzzzzzzzzp_, pzzzzzzzzzzzzzzzzzzzzzzzzza_, default);
                Code<ObservationStatus> pzzzzzzzzzzzzzzzzzzzzzzzzzc_ = BicarbonateLab?.StatusElement;
                ObservationStatus? pzzzzzzzzzzzzzzzzzzzzzzzzzd_ = pzzzzzzzzzzzzzzzzzzzzzzzzzc_?.Value;
                string pzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Convert<string>(pzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                string[] pzzzzzzzzzzzzzzzzzzzzzzzzzf_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? pzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.In<string>(pzzzzzzzzzzzzzzzzzzzzzzzzze_, pzzzzzzzzzzzzzzzzzzzzzzzzzf_ as IEnumerable<string>);
                bool? pzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzzzzzb_, pzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                DataType pzzzzzzzzzzzzzzzzzzzzzzzzzi_ = BicarbonateLab?.Value;
                object pzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                bool? pzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Not((bool?)(pzzzzzzzzzzzzzzzzzzzzzzzzzj_ is null));
                bool? pzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzzzzzh_, pzzzzzzzzzzzzzzzzzzzzzzzzzk_);

                return pzzzzzzzzzzzzzzzzzzzzzzzzzl_;
            };
            IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Observation>(mzzzzzzzzzzzzzzzzzzzzzzzzzy_, mzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            object nzzzzzzzzzzzzzzzzzzzzzzzzzb_(Observation @this)
            {
                Instant pzzzzzzzzzzzzzzzzzzzzzzzzzm_ = @this?.IssuedElement;
                DateTimeOffset? pzzzzzzzzzzzzzzzzzzzzzzzzzn_ = pzzzzzzzzzzzzzzzzzzzzzzzzzm_?.Value;
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Convert<CqlDateTime>(pzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.earliest(context, pzzzzzzzzzzzzzzzzzzzzzzzzzo_ as object);

                return pzzzzzzzzzzzzzzzzzzzzzzzzzp_;
            };
            IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.SortBy<Observation>(nzzzzzzzzzzzzzzzzzzzzzzzzza_, nzzzzzzzzzzzzzzzzzzzzzzzzzb_, System.ComponentModel.ListSortDirection.Ascending);
            Observation nzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.First<Observation>(nzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            Instant nzzzzzzzzzzzzzzzzzzzzzzzzze_ = nzzzzzzzzzzzzzzzzzzzzzzzzzd_?.IssuedElement;
            DateTimeOffset? nzzzzzzzzzzzzzzzzzzzzzzzzzf_ = nzzzzzzzzzzzzzzzzzzzzzzzzze_?.Value;
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<CqlDateTime>(nzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)? nzzzzzzzzzzzzzzzzzzzzzzzzzh_ = (CqlTupleMetadata_GbUHPXXHScejjXWhcHJFQQifQ, mzzzzzzzzzzzzzzzzzzzzzzzzzn_, mzzzzzzzzzzzzzzzzzzzzzzzzzw_ as CqlQuantity, nzzzzzzzzzzzzzzzzzzzzzzzzzg_);

            return nzzzzzzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)?> mzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)?>(mzzzzzzzzzzzzzzzzzzzzzzzzzi_, mzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)?> mzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)?>(mzzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return mzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Encounter with First Creatinine Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)?> Encounter_with_First_Creatinine_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)? pzzzzzzzzzzzzzzzzzzzzzzzzzr_(Encounter EncounterInpatient)
        {
            Id pzzzzzzzzzzzzzzzzzzzzzzzzzu_ = EncounterInpatient?.IdElement;
            string pzzzzzzzzzzzzzzzzzzzzzzzzzv_ = pzzzzzzzzzzzzzzzzzzzzzzzzzu_?.Value;
            CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Creatinine_lab_test(context);
            IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzy_(Observation CreatinineLab)
            {
                Instant qzzzzzzzzzzzzzzzzzzzzzzzzzq_ = CreatinineLab?.IssuedElement;
                DateTimeOffset? qzzzzzzzzzzzzzzzzzzzzzzzzzr_ = qzzzzzzzzzzzzzzzzzzzzzzzzzq_?.Value;
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Convert<CqlDateTime>(qzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.earliest(context, qzzzzzzzzzzzzzzzzzzzzzzzzzs_ as object);
                Period qzzzzzzzzzzzzzzzzzzzzzzzzzu_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(qzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlQuantity qzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Subtract(qzzzzzzzzzzzzzzzzzzzzzzzzzw_, qzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(rzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Add(rzzzzzzzzzzzzzzzzzzzzzzzzzb_, qzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Interval(qzzzzzzzzzzzzzzzzzzzzzzzzzy_, rzzzzzzzzzzzzzzzzzzzzzzzzzd_, true, true);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.In<CqlDateTime>(qzzzzzzzzzzzzzzzzzzzzzzzzzt_, rzzzzzzzzzzzzzzzzzzzzzzzzze_, default);
                Code<ObservationStatus> rzzzzzzzzzzzzzzzzzzzzzzzzzg_ = CreatinineLab?.StatusElement;
                ObservationStatus? rzzzzzzzzzzzzzzzzzzzzzzzzzh_ = rzzzzzzzzzzzzzzzzzzzzzzzzzg_?.Value;
                string rzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Convert<string>(rzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                string[] rzzzzzzzzzzzzzzzzzzzzzzzzzj_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.In<string>(rzzzzzzzzzzzzzzzzzzzzzzzzzi_, rzzzzzzzzzzzzzzzzzzzzzzzzzj_ as IEnumerable<string>);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzzzzzzf_, rzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                DataType rzzzzzzzzzzzzzzzzzzzzzzzzzm_ = CreatinineLab?.Value;
                object rzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Not((bool?)(rzzzzzzzzzzzzzzzzzzzzzzzzzn_ is null));
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzzzzzzl_, rzzzzzzzzzzzzzzzzzzzzzzzzzo_);

                return rzzzzzzzzzzzzzzzzzzzzzzzzzp_;
            };
            IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Observation>(pzzzzzzzzzzzzzzzzzzzzzzzzzx_, pzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            object qzzzzzzzzzzzzzzzzzzzzzzzzza_(Observation @this)
            {
                Instant rzzzzzzzzzzzzzzzzzzzzzzzzzq_ = @this?.IssuedElement;
                DateTimeOffset? rzzzzzzzzzzzzzzzzzzzzzzzzzr_ = rzzzzzzzzzzzzzzzzzzzzzzzzzq_?.Value;
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Convert<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.earliest(context, rzzzzzzzzzzzzzzzzzzzzzzzzzs_ as object);

                return rzzzzzzzzzzzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.SortBy<Observation>(pzzzzzzzzzzzzzzzzzzzzzzzzzz_, qzzzzzzzzzzzzzzzzzzzzzzzzza_, System.ComponentModel.ListSortDirection.Ascending);
            Observation qzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.First<Observation>(qzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            DataType qzzzzzzzzzzzzzzzzzzzzzzzzzd_ = qzzzzzzzzzzzzzzzzzzzzzzzzzc_?.Value;
            object qzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzh_(Observation CreatinineLab)
            {
                Instant rzzzzzzzzzzzzzzzzzzzzzzzzzu_ = CreatinineLab?.IssuedElement;
                DateTimeOffset? rzzzzzzzzzzzzzzzzzzzzzzzzzv_ = rzzzzzzzzzzzzzzzzzzzzzzzzzu_?.Value;
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.earliest(context, rzzzzzzzzzzzzzzzzzzzzzzzzzw_ as object);
                Period rzzzzzzzzzzzzzzzzzzzzzzzzzy_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Start(rzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlQuantity szzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Subtract(szzzzzzzzzzzzzzzzzzzzzzzzza_, szzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(szzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Add(szzzzzzzzzzzzzzzzzzzzzzzzzf_, szzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Interval(szzzzzzzzzzzzzzzzzzzzzzzzzc_, szzzzzzzzzzzzzzzzzzzzzzzzzh_, true, true);
                bool? szzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.In<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzzzzzzzx_, szzzzzzzzzzzzzzzzzzzzzzzzzi_, default);
                Code<ObservationStatus> szzzzzzzzzzzzzzzzzzzzzzzzzk_ = CreatinineLab?.StatusElement;
                ObservationStatus? szzzzzzzzzzzzzzzzzzzzzzzzzl_ = szzzzzzzzzzzzzzzzzzzzzzzzzk_?.Value;
                string szzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Convert<string>(szzzzzzzzzzzzzzzzzzzzzzzzzl_);
                string[] szzzzzzzzzzzzzzzzzzzzzzzzzn_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? szzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.In<string>(szzzzzzzzzzzzzzzzzzzzzzzzzm_, szzzzzzzzzzzzzzzzzzzzzzzzzn_ as IEnumerable<string>);
                bool? szzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzzzzzj_, szzzzzzzzzzzzzzzzzzzzzzzzzo_);
                DataType szzzzzzzzzzzzzzzzzzzzzzzzzq_ = CreatinineLab?.Value;
                object szzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzzzq_);
                bool? szzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Not((bool?)(szzzzzzzzzzzzzzzzzzzzzzzzzr_ is null));
                bool? szzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzzzzzp_, szzzzzzzzzzzzzzzzzzzzzzzzzs_);

                return szzzzzzzzzzzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Observation>(qzzzzzzzzzzzzzzzzzzzzzzzzzg_, qzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            object qzzzzzzzzzzzzzzzzzzzzzzzzzj_(Observation @this)
            {
                Instant szzzzzzzzzzzzzzzzzzzzzzzzzu_ = @this?.IssuedElement;
                DateTimeOffset? szzzzzzzzzzzzzzzzzzzzzzzzzv_ = szzzzzzzzzzzzzzzzzzzzzzzzzu_?.Value;
                CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<CqlDateTime>(szzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.earliest(context, szzzzzzzzzzzzzzzzzzzzzzzzzw_ as object);

                return szzzzzzzzzzzzzzzzzzzzzzzzzx_;
            };
            IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.SortBy<Observation>(qzzzzzzzzzzzzzzzzzzzzzzzzzi_, qzzzzzzzzzzzzzzzzzzzzzzzzzj_, System.ComponentModel.ListSortDirection.Ascending);
            Observation qzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.First<Observation>(qzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            Instant qzzzzzzzzzzzzzzzzzzzzzzzzzm_ = qzzzzzzzzzzzzzzzzzzzzzzzzzl_?.IssuedElement;
            DateTimeOffset? qzzzzzzzzzzzzzzzzzzzzzzzzzn_ = qzzzzzzzzzzzzzzzzzzzzzzzzzm_?.Value;
            CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Convert<CqlDateTime>(qzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)? qzzzzzzzzzzzzzzzzzzzzzzzzzp_ = (CqlTupleMetadata_FETECNQPQREfGRgPYWhOWgeWA, pzzzzzzzzzzzzzzzzzzzzzzzzzv_, qzzzzzzzzzzzzzzzzzzzzzzzzze_ as CqlQuantity, qzzzzzzzzzzzzzzzzzzzzzzzzzo_);

            return qzzzzzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)?> pzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)?>(pzzzzzzzzzzzzzzzzzzzzzzzzzq_, pzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)?> pzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)?>(pzzzzzzzzzzzzzzzzzzzzzzzzzs_);

        return pzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Encounter with First Hematocrit Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?> Encounter_with_First_Hematocrit_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)? szzzzzzzzzzzzzzzzzzzzzzzzzz_(Encounter EncounterInpatient)
        {
            Id tzzzzzzzzzzzzzzzzzzzzzzzzzc_ = EncounterInpatient?.IdElement;
            string tzzzzzzzzzzzzzzzzzzzzzzzzzd_ = tzzzzzzzzzzzzzzzzzzzzzzzzzc_?.Value;
            CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Hematocrit_lab_test(context);
            IEnumerable<Observation> tzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzg_(Observation HematocritLab)
            {
                Instant tzzzzzzzzzzzzzzzzzzzzzzzzzy_ = HematocritLab?.IssuedElement;
                DateTimeOffset? tzzzzzzzzzzzzzzzzzzzzzzzzzz_ = tzzzzzzzzzzzzzzzzzzzzzzzzzy_?.Value;
                CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<CqlDateTime>(tzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.earliest(context, uzzzzzzzzzzzzzzzzzzzzzzzzza_ as object);
                Period uzzzzzzzzzzzzzzzzzzzzzzzzzc_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Start(uzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlQuantity uzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Subtract(uzzzzzzzzzzzzzzzzzzzzzzzzze_, uzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Start(uzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Add(uzzzzzzzzzzzzzzzzzzzzzzzzzj_, uzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Interval(uzzzzzzzzzzzzzzzzzzzzzzzzzg_, uzzzzzzzzzzzzzzzzzzzzzzzzzl_, true, true);
                bool? uzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.In<CqlDateTime>(uzzzzzzzzzzzzzzzzzzzzzzzzzb_, uzzzzzzzzzzzzzzzzzzzzzzzzzm_, default);
                Code<ObservationStatus> uzzzzzzzzzzzzzzzzzzzzzzzzzo_ = HematocritLab?.StatusElement;
                ObservationStatus? uzzzzzzzzzzzzzzzzzzzzzzzzzp_ = uzzzzzzzzzzzzzzzzzzzzzzzzzo_?.Value;
                string uzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<string>(uzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                string[] uzzzzzzzzzzzzzzzzzzzzzzzzzr_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? uzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.In<string>(uzzzzzzzzzzzzzzzzzzzzzzzzzq_, uzzzzzzzzzzzzzzzzzzzzzzzzzr_ as IEnumerable<string>);
                bool? uzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzzzzzzzn_, uzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                DataType uzzzzzzzzzzzzzzzzzzzzzzzzzu_ = HematocritLab?.Value;
                object uzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                bool? uzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Not((bool?)(uzzzzzzzzzzzzzzzzzzzzzzzzzv_ is null));
                bool? uzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzzzzzzzt_, uzzzzzzzzzzzzzzzzzzzzzzzzzw_);

                return uzzzzzzzzzzzzzzzzzzzzzzzzzx_;
            };
            IEnumerable<Observation> tzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Observation>(tzzzzzzzzzzzzzzzzzzzzzzzzzf_, tzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            object tzzzzzzzzzzzzzzzzzzzzzzzzzi_(Observation @this)
            {
                Instant uzzzzzzzzzzzzzzzzzzzzzzzzzy_ = @this?.IssuedElement;
                DateTimeOffset? uzzzzzzzzzzzzzzzzzzzzzzzzzz_ = uzzzzzzzzzzzzzzzzzzzzzzzzzy_?.Value;
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<CqlDateTime>(uzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.earliest(context, vzzzzzzzzzzzzzzzzzzzzzzzzza_ as object);

                return vzzzzzzzzzzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<Observation> tzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.SortBy<Observation>(tzzzzzzzzzzzzzzzzzzzzzzzzzh_, tzzzzzzzzzzzzzzzzzzzzzzzzzi_, System.ComponentModel.ListSortDirection.Ascending);
            Observation tzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.First<Observation>(tzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            DataType tzzzzzzzzzzzzzzzzzzzzzzzzzl_ = tzzzzzzzzzzzzzzzzzzzzzzzzzk_?.Value;
            object tzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            IEnumerable<Observation> tzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzp_(Observation HematocritLab)
            {
                Instant vzzzzzzzzzzzzzzzzzzzzzzzzzc_ = HematocritLab?.IssuedElement;
                DateTimeOffset? vzzzzzzzzzzzzzzzzzzzzzzzzzd_ = vzzzzzzzzzzzzzzzzzzzzzzzzzc_?.Value;
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Convert<CqlDateTime>(vzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.earliest(context, vzzzzzzzzzzzzzzzzzzzzzzzzze_ as object);
                Period vzzzzzzzzzzzzzzzzzzzzzzzzzg_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Start(vzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlQuantity vzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Subtract(vzzzzzzzzzzzzzzzzzzzzzzzzzi_, vzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(vzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Add(vzzzzzzzzzzzzzzzzzzzzzzzzzn_, vzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Interval(vzzzzzzzzzzzzzzzzzzzzzzzzzk_, vzzzzzzzzzzzzzzzzzzzzzzzzzp_, true, true);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(vzzzzzzzzzzzzzzzzzzzzzzzzzf_, vzzzzzzzzzzzzzzzzzzzzzzzzzq_, default);
                Code<ObservationStatus> vzzzzzzzzzzzzzzzzzzzzzzzzzs_ = HematocritLab?.StatusElement;
                ObservationStatus? vzzzzzzzzzzzzzzzzzzzzzzzzzt_ = vzzzzzzzzzzzzzzzzzzzzzzzzzs_?.Value;
                string vzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Convert<string>(vzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                string[] vzzzzzzzzzzzzzzzzzzzzzzzzzv_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.In<string>(vzzzzzzzzzzzzzzzzzzzzzzzzzu_, vzzzzzzzzzzzzzzzzzzzzzzzzzv_ as IEnumerable<string>);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzzzzzzr_, vzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                DataType vzzzzzzzzzzzzzzzzzzzzzzzzzy_ = HematocritLab?.Value;
                object vzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Not((bool?)(vzzzzzzzzzzzzzzzzzzzzzzzzzz_ is null));
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzzzzzzx_, wzzzzzzzzzzzzzzzzzzzzzzzzza_);

                return wzzzzzzzzzzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<Observation> tzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Observation>(tzzzzzzzzzzzzzzzzzzzzzzzzzo_, tzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            object tzzzzzzzzzzzzzzzzzzzzzzzzzr_(Observation @this)
            {
                Instant wzzzzzzzzzzzzzzzzzzzzzzzzzc_ = @this?.IssuedElement;
                DateTimeOffset? wzzzzzzzzzzzzzzzzzzzzzzzzzd_ = wzzzzzzzzzzzzzzzzzzzzzzzzzc_?.Value;
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Convert<CqlDateTime>(wzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.earliest(context, wzzzzzzzzzzzzzzzzzzzzzzzzze_ as object);

                return wzzzzzzzzzzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<Observation> tzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.SortBy<Observation>(tzzzzzzzzzzzzzzzzzzzzzzzzzq_, tzzzzzzzzzzzzzzzzzzzzzzzzzr_, System.ComponentModel.ListSortDirection.Ascending);
            Observation tzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.First<Observation>(tzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            Instant tzzzzzzzzzzzzzzzzzzzzzzzzzu_ = tzzzzzzzzzzzzzzzzzzzzzzzzzt_?.IssuedElement;
            DateTimeOffset? tzzzzzzzzzzzzzzzzzzzzzzzzzv_ = tzzzzzzzzzzzzzzzzzzzzzzzzzu_?.Value;
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<CqlDateTime>(tzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)? tzzzzzzzzzzzzzzzzzzzzzzzzzx_ = (CqlTupleMetadata_DIHdhbAJeJTdiAVUAELUHRNdS, tzzzzzzzzzzzzzzzzzzzzzzzzzd_, tzzzzzzzzzzzzzzzzzzzzzzzzzm_ as CqlQuantity, tzzzzzzzzzzzzzzzzzzzzzzzzzw_);

            return tzzzzzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?> tzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?>(szzzzzzzzzzzzzzzzzzzzzzzzzy_, szzzzzzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?> tzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?>(tzzzzzzzzzzzzzzzzzzzzzzzzza_);

        return tzzzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Encounter with First Platelet Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)?> Encounter_with_First_Platelet_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)? wzzzzzzzzzzzzzzzzzzzzzzzzzh_(Encounter EncounterInpatient)
        {
            Id wzzzzzzzzzzzzzzzzzzzzzzzzzk_ = EncounterInpatient?.IdElement;
            string wzzzzzzzzzzzzzzzzzzzzzzzzzl_ = wzzzzzzzzzzzzzzzzzzzzzzzzzk_?.Value;
            CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Platelet_count_lab_test(context);
            IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzo_(Observation PlateletLab)
            {
                Instant xzzzzzzzzzzzzzzzzzzzzzzzzzg_ = PlateletLab?.IssuedElement;
                DateTimeOffset? xzzzzzzzzzzzzzzzzzzzzzzzzzh_ = xzzzzzzzzzzzzzzzzzzzzzzzzzg_?.Value;
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Convert<CqlDateTime>(xzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.earliest(context, xzzzzzzzzzzzzzzzzzzzzzzzzzi_ as object);
                Period xzzzzzzzzzzzzzzzzzzzzzzzzzk_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlQuantity xzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Subtract(xzzzzzzzzzzzzzzzzzzzzzzzzzm_, xzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Add(xzzzzzzzzzzzzzzzzzzzzzzzzzr_, xzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Interval(xzzzzzzzzzzzzzzzzzzzzzzzzzo_, xzzzzzzzzzzzzzzzzzzzzzzzzzt_, true, true);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzzzzzzzzzzzzzzzzzj_, xzzzzzzzzzzzzzzzzzzzzzzzzzu_, default);
                Code<ObservationStatus> xzzzzzzzzzzzzzzzzzzzzzzzzzw_ = PlateletLab?.StatusElement;
                ObservationStatus? xzzzzzzzzzzzzzzzzzzzzzzzzzx_ = xzzzzzzzzzzzzzzzzzzzzzzzzzw_?.Value;
                string xzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<string>(xzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                string[] xzzzzzzzzzzzzzzzzzzzzzzzzzz_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<string>(xzzzzzzzzzzzzzzzzzzzzzzzzzy_, xzzzzzzzzzzzzzzzzzzzzzzzzzz_ as IEnumerable<string>);
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzzzzzv_, yzzzzzzzzzzzzzzzzzzzzzzzzza_);
                DataType yzzzzzzzzzzzzzzzzzzzzzzzzzc_ = PlateletLab?.Value;
                object yzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Not((bool?)(yzzzzzzzzzzzzzzzzzzzzzzzzzd_ is null));
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzzzzzzzb_, yzzzzzzzzzzzzzzzzzzzzzzzzze_);

                return yzzzzzzzzzzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Observation>(wzzzzzzzzzzzzzzzzzzzzzzzzzn_, wzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            object wzzzzzzzzzzzzzzzzzzzzzzzzzq_(Observation @this)
            {
                Instant yzzzzzzzzzzzzzzzzzzzzzzzzzg_ = @this?.IssuedElement;
                DateTimeOffset? yzzzzzzzzzzzzzzzzzzzzzzzzzh_ = yzzzzzzzzzzzzzzzzzzzzzzzzzg_?.Value;
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Convert<CqlDateTime>(yzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.earliest(context, yzzzzzzzzzzzzzzzzzzzzzzzzzi_ as object);

                return yzzzzzzzzzzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.SortBy<Observation>(wzzzzzzzzzzzzzzzzzzzzzzzzzp_, wzzzzzzzzzzzzzzzzzzzzzzzzzq_, System.ComponentModel.ListSortDirection.Ascending);
            Observation wzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.First<Observation>(wzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            DataType wzzzzzzzzzzzzzzzzzzzzzzzzzt_ = wzzzzzzzzzzzzzzzzzzzzzzzzzs_?.Value;
            object wzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzx_(Observation PlateletLab)
            {
                Instant yzzzzzzzzzzzzzzzzzzzzzzzzzk_ = PlateletLab?.IssuedElement;
                DateTimeOffset? yzzzzzzzzzzzzzzzzzzzzzzzzzl_ = yzzzzzzzzzzzzzzzzzzzzzzzzzk_?.Value;
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Convert<CqlDateTime>(yzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.earliest(context, yzzzzzzzzzzzzzzzzzzzzzzzzzm_ as object);
                Period yzzzzzzzzzzzzzzzzzzzzzzzzzo_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlQuantity yzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Subtract(yzzzzzzzzzzzzzzzzzzzzzzzzzq_, yzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Add(yzzzzzzzzzzzzzzzzzzzzzzzzzv_, yzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Interval(yzzzzzzzzzzzzzzzzzzzzzzzzzs_, yzzzzzzzzzzzzzzzzzzzzzzzzzx_, true, true);
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<CqlDateTime>(yzzzzzzzzzzzzzzzzzzzzzzzzzn_, yzzzzzzzzzzzzzzzzzzzzzzzzzy_, default);
                Code<ObservationStatus> zzzzzzzzzzzzzzzzzzzzzzzzzza_ = PlateletLab?.StatusElement;
                ObservationStatus? zzzzzzzzzzzzzzzzzzzzzzzzzzb_ = zzzzzzzzzzzzzzzzzzzzzzzzzza_?.Value;
                string zzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<string>(zzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                string[] zzzzzzzzzzzzzzzzzzzzzzzzzzd_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.In<string>(zzzzzzzzzzzzzzzzzzzzzzzzzzc_, zzzzzzzzzzzzzzzzzzzzzzzzzzd_ as IEnumerable<string>);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzzzzzzzz_, zzzzzzzzzzzzzzzzzzzzzzzzzze_);
                DataType zzzzzzzzzzzzzzzzzzzzzzzzzzg_ = PlateletLab?.Value;
                object zzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Not((bool?)(zzzzzzzzzzzzzzzzzzzzzzzzzzh_ is null));
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzzzzzf_, zzzzzzzzzzzzzzzzzzzzzzzzzzi_);

                return zzzzzzzzzzzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Observation>(wzzzzzzzzzzzzzzzzzzzzzzzzzw_, wzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            object wzzzzzzzzzzzzzzzzzzzzzzzzzz_(Observation @this)
            {
                Instant zzzzzzzzzzzzzzzzzzzzzzzzzzk_ = @this?.IssuedElement;
                DateTimeOffset? zzzzzzzzzzzzzzzzzzzzzzzzzzl_ = zzzzzzzzzzzzzzzzzzzzzzzzzzk_?.Value;
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Convert<CqlDateTime>(zzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.earliest(context, zzzzzzzzzzzzzzzzzzzzzzzzzzm_ as object);

                return zzzzzzzzzzzzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.SortBy<Observation>(wzzzzzzzzzzzzzzzzzzzzzzzzzy_, wzzzzzzzzzzzzzzzzzzzzzzzzzz_, System.ComponentModel.ListSortDirection.Ascending);
            Observation xzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.First<Observation>(xzzzzzzzzzzzzzzzzzzzzzzzzza_);
            Instant xzzzzzzzzzzzzzzzzzzzzzzzzzc_ = xzzzzzzzzzzzzzzzzzzzzzzzzzb_?.IssuedElement;
            DateTimeOffset? xzzzzzzzzzzzzzzzzzzzzzzzzzd_ = xzzzzzzzzzzzzzzzzzzzzzzzzzc_?.Value;
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Convert<CqlDateTime>(xzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)? xzzzzzzzzzzzzzzzzzzzzzzzzzf_ = (CqlTupleMetadata_DAUcYHQZcDKbIfORJOEZBDgIh, wzzzzzzzzzzzzzzzzzzzzzzzzzl_, wzzzzzzzzzzzzzzzzzzzzzzzzzu_ as CqlQuantity, xzzzzzzzzzzzzzzzzzzzzzzzzze_);

            return xzzzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)?> wzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)?>(wzzzzzzzzzzzzzzzzzzzzzzzzzg_, wzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)?> wzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)?>(wzzzzzzzzzzzzzzzzzzzzzzzzzi_);

        return wzzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Encounter with First Sodium Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)?> Encounter_with_First_Sodium_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)? zzzzzzzzzzzzzzzzzzzzzzzzzzp_(Encounter EncounterInpatient)
        {
            Id zzzzzzzzzzzzzzzzzzzzzzzzzzs_ = EncounterInpatient?.IdElement;
            string zzzzzzzzzzzzzzzzzzzzzzzzzzt_ = zzzzzzzzzzzzzzzzzzzzzzzzzzs_?.Value;
            CqlValueSet zzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Sodium_lab_test(context);
            IEnumerable<Observation> zzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzw_(Observation SodiumLab)
            {
                Instant azzzzzzzzzzzzzzzzzzzzzzzzzzo_ = SodiumLab?.IssuedElement;
                DateTimeOffset? azzzzzzzzzzzzzzzzzzzzzzzzzzp_ = azzzzzzzzzzzzzzzzzzzzzzzzzzo_?.Value;
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<CqlDateTime>(azzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.earliest(context, azzzzzzzzzzzzzzzzzzzzzzzzzzq_ as object);
                Period azzzzzzzzzzzzzzzzzzzzzzzzzzs_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(azzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlQuantity azzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Subtract(azzzzzzzzzzzzzzzzzzzzzzzzzzu_, azzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Start(azzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Add(azzzzzzzzzzzzzzzzzzzzzzzzzzz_, azzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Interval(azzzzzzzzzzzzzzzzzzzzzzzzzzw_, bzzzzzzzzzzzzzzzzzzzzzzzzzzb_, true, true);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(azzzzzzzzzzzzzzzzzzzzzzzzzzr_, bzzzzzzzzzzzzzzzzzzzzzzzzzzc_, default);
                Code<ObservationStatus> bzzzzzzzzzzzzzzzzzzzzzzzzzze_ = SodiumLab?.StatusElement;
                ObservationStatus? bzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = bzzzzzzzzzzzzzzzzzzzzzzzzzze_?.Value;
                string bzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<string>(bzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                string[] bzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.In<string>(bzzzzzzzzzzzzzzzzzzzzzzzzzzg_, bzzzzzzzzzzzzzzzzzzzzzzzzzzh_ as IEnumerable<string>);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzzzzzzd_, bzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = SodiumLab?.Value;
                object bzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Not((bool?)(bzzzzzzzzzzzzzzzzzzzzzzzzzzl_ is null));
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzzzzzzj_, bzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

                return bzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<Observation> zzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Observation>(zzzzzzzzzzzzzzzzzzzzzzzzzzv_, zzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            object zzzzzzzzzzzzzzzzzzzzzzzzzzy_(Observation @this)
            {
                Instant bzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = @this?.IssuedElement;
                DateTimeOffset? bzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzo_?.Value;
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.earliest(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzq_ as object);

                return bzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
            };
            IEnumerable<Observation> zzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.SortBy<Observation>(zzzzzzzzzzzzzzzzzzzzzzzzzzx_, zzzzzzzzzzzzzzzzzzzzzzzzzzy_, System.ComponentModel.ListSortDirection.Ascending);
            Observation azzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.First<Observation>(zzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            DataType azzzzzzzzzzzzzzzzzzzzzzzzzzb_ = azzzzzzzzzzzzzzzzzzzzzzzzzza_?.Value;
            object azzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzf_(Observation SodiumLab)
            {
                Instant bzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = SodiumLab?.IssuedElement;
                DateTimeOffset? bzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzs_?.Value;
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Convert<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.earliest(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzu_ as object);
                Period bzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlQuantity bzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Subtract(bzzzzzzzzzzzzzzzzzzzzzzzzzzy_, bzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Add(czzzzzzzzzzzzzzzzzzzzzzzzzzd_, bzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Interval(czzzzzzzzzzzzzzzzzzzzzzzzzza_, czzzzzzzzzzzzzzzzzzzzzzzzzzf_, true, true);
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.In<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzzzzzzzv_, czzzzzzzzzzzzzzzzzzzzzzzzzzg_, default);
                Code<ObservationStatus> czzzzzzzzzzzzzzzzzzzzzzzzzzi_ = SodiumLab?.StatusElement;
                ObservationStatus? czzzzzzzzzzzzzzzzzzzzzzzzzzj_ = czzzzzzzzzzzzzzzzzzzzzzzzzzi_?.Value;
                string czzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<string>(czzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                string[] czzzzzzzzzzzzzzzzzzzzzzzzzzl_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.In<string>(czzzzzzzzzzzzzzzzzzzzzzzzzzk_, czzzzzzzzzzzzzzzzzzzzzzzzzzl_ as IEnumerable<string>);
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzzzzzzzh_, czzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                DataType czzzzzzzzzzzzzzzzzzzzzzzzzzo_ = SodiumLab?.Value;
                object czzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Not((bool?)(czzzzzzzzzzzzzzzzzzzzzzzzzzp_ is null));
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzzzzzzzn_, czzzzzzzzzzzzzzzzzzzzzzzzzzq_);

                return czzzzzzzzzzzzzzzzzzzzzzzzzzr_;
            };
            IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Observation>(azzzzzzzzzzzzzzzzzzzzzzzzzze_, azzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            object azzzzzzzzzzzzzzzzzzzzzzzzzzh_(Observation @this)
            {
                Instant czzzzzzzzzzzzzzzzzzzzzzzzzzs_ = @this?.IssuedElement;
                DateTimeOffset? czzzzzzzzzzzzzzzzzzzzzzzzzzt_ = czzzzzzzzzzzzzzzzzzzzzzzzzzs_?.Value;
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Convert<CqlDateTime>(czzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.earliest(context, czzzzzzzzzzzzzzzzzzzzzzzzzzu_ as object);

                return czzzzzzzzzzzzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.SortBy<Observation>(azzzzzzzzzzzzzzzzzzzzzzzzzzg_, azzzzzzzzzzzzzzzzzzzzzzzzzzh_, System.ComponentModel.ListSortDirection.Ascending);
            Observation azzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.First<Observation>(azzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            Instant azzzzzzzzzzzzzzzzzzzzzzzzzzk_ = azzzzzzzzzzzzzzzzzzzzzzzzzzj_?.IssuedElement;
            DateTimeOffset? azzzzzzzzzzzzzzzzzzzzzzzzzzl_ = azzzzzzzzzzzzzzzzzzzzzzzzzzk_?.Value;
            CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Convert<CqlDateTime>(azzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)? azzzzzzzzzzzzzzzzzzzzzzzzzzn_ = (CqlTupleMetadata_GKGeLARADLGJcNcZaDhdCREMa, zzzzzzzzzzzzzzzzzzzzzzzzzzt_, azzzzzzzzzzzzzzzzzzzzzzzzzzc_ as CqlQuantity, azzzzzzzzzzzzzzzzzzzzzzzzzzm_);

            return azzzzzzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)?> zzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)?>(zzzzzzzzzzzzzzzzzzzzzzzzzzo_, zzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)?> zzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)?>(zzzzzzzzzzzzzzzzzzzzzzzzzzq_);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Qualifying Blood Pressure Reading")]
    public IEnumerable<Observation> Qualifying_Blood_Pressure_Reading(CqlContext context)
    {
        IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bp"));
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzzx_(Observation BPReading)
        {
            DataType czzzzzzzzzzzzzzzzzzzzzzzzzzz_ = BPReading?.Effective;
            object dzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.earliest(context, dzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Measurement_Period(context);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzzzzzzzb_, dzzzzzzzzzzzzzzzzzzzzzzzzzzc_, "day");
            Code<ObservationStatus> dzzzzzzzzzzzzzzzzzzzzzzzzzze_ = BPReading?.StatusElement;
            ObservationStatus? dzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = dzzzzzzzzzzzzzzzzzzzzzzzzzze_?.Value;
            string dzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<string>(dzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            string[] dzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.In<string>(dzzzzzzzzzzzzzzzzzzzzzzzzzzg_, dzzzzzzzzzzzzzzzzzzzzzzzzzzh_ as IEnumerable<string>);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzzzzzzzzzd_, dzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

            return dzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Observation>(czzzzzzzzzzzzzzzzzzzzzzzzzzw_, czzzzzzzzzzzzzzzzzzzzzzzzzzx_);

        return czzzzzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Test2")]
    public CqlQuantity Test2(CqlContext context)
    {
        IEnumerable<Observation> dzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Qualifying_Blood_Pressure_Reading(context);
        IEnumerable<Observation> dzzzzzzzzzzzzzzzzzzzzzzzzzzl_(Observation SBPReading)
        {
            IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Inpatient_Encounters(context);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzt_(Encounter EncounterInpatient)
            {
                DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = SBPReading?.Effective;
                object dzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.earliest(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                Period ezzzzzzzzzzzzzzzzzzzzzzzzzza_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlQuantity ezzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Subtract(ezzzzzzzzzzzzzzzzzzzzzzzzzzc_, ezzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlQuantity ezzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Add(ezzzzzzzzzzzzzzzzzzzzzzzzzzh_, ezzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Interval(ezzzzzzzzzzzzzzzzzzzzzzzzzze_, ezzzzzzzzzzzzzzzzzzzzzzzzzzj_, true, true);
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.In<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzzzzzzzz_, ezzzzzzzzzzzzzzzzzzzzzzzzzzk_, default);

                return ezzzzzzzzzzzzzzzzzzzzzzzzzzl_;
            };
            IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Encounter>(dzzzzzzzzzzzzzzzzzzzzzzzzzzs_, dzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            Observation dzzzzzzzzzzzzzzzzzzzzzzzzzzv_(Encounter EncounterInpatient) =>
                SBPReading;
            IEnumerable<Observation> dzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Select<Encounter, Observation>(dzzzzzzzzzzzzzzzzzzzzzzzzzzu_, dzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

            return dzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Observation> dzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.SelectMany<Observation, Observation>(dzzzzzzzzzzzzzzzzzzzzzzzzzzk_, dzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        CqlQuantity dzzzzzzzzzzzzzzzzzzzzzzzzzzn_(Observation SBPReading)
        {
            List<Observation.ComponentComponent> ezzzzzzzzzzzzzzzzzzzzzzzzzzm_ = SBPReading?.Component;
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzn_(Observation.ComponentComponent SBPComponent)
            {
                CodeableConcept ezzzzzzzzzzzzzzzzzzzzzzzzzzt_ = SBPComponent?.Code;
                CqlConcept ezzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlCode ezzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Systolic_blood_pressure(context);
                CqlConcept ezzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.ConvertCodeToConcept(ezzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Equivalent(ezzzzzzzzzzzzzzzzzzzzzzzzzzu_, ezzzzzzzzzzzzzzzzzzzzzzzzzzw_);

                return ezzzzzzzzzzzzzzzzzzzzzzzzzzx_;
            };
            IEnumerable<Observation.ComponentComponent> ezzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)ezzzzzzzzzzzzzzzzzzzzzzzzzzm_, ezzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlQuantity ezzzzzzzzzzzzzzzzzzzzzzzzzzp_(Observation.ComponentComponent SBPComponent)
            {
                DataType ezzzzzzzzzzzzzzzzzzzzzzzzzzy_ = SBPComponent?.Value;
                object ezzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzy_);

                return ezzzzzzzzzzzzzzzzzzzzzzzzzzz_ as CqlQuantity;
            };
            IEnumerable<CqlQuantity> ezzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Select<Observation.ComponentComponent, CqlQuantity>(ezzzzzzzzzzzzzzzzzzzzzzzzzzo_, ezzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            IEnumerable<CqlQuantity> ezzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Distinct<CqlQuantity>(ezzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlQuantity ezzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.SingletonFrom<CqlQuantity>(ezzzzzzzzzzzzzzzzzzzzzzzzzzr_);

            return ezzzzzzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<CqlQuantity> dzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Select<Observation, CqlQuantity>(dzzzzzzzzzzzzzzzzzzzzzzzzzzm_, dzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<CqlQuantity> dzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Distinct<CqlQuantity>(dzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<CqlQuantity> dzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.ListSort<CqlQuantity>(dzzzzzzzzzzzzzzzzzzzzzzzzzzp_, System.ComponentModel.ListSortDirection.Ascending);
        CqlQuantity dzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.First<CqlQuantity>(dzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

        return dzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Encounter with First White Blood Cells Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)?> Encounter_with_First_White_Blood_Cells_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)? fzzzzzzzzzzzzzzzzzzzzzzzzzzb_(Encounter EncounterInpatient)
        {
            Id fzzzzzzzzzzzzzzzzzzzzzzzzzze_ = EncounterInpatient?.IdElement;
            string fzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = fzzzzzzzzzzzzzzzzzzzzzzzzzze_?.Value;
            CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.White_blood_cells_count_lab_test(context);
            IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Observation WhiteBloodCellLab)
            {
                Instant gzzzzzzzzzzzzzzzzzzzzzzzzzza_ = WhiteBloodCellLab?.IssuedElement;
                DateTimeOffset? gzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = gzzzzzzzzzzzzzzzzzzzzzzzzzza_?.Value;
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<CqlDateTime>(gzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.earliest(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzc_ as object);
                Period gzzzzzzzzzzzzzzzzzzzzzzzzzze_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlQuantity gzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Subtract(gzzzzzzzzzzzzzzzzzzzzzzzzzzg_, gzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Add(gzzzzzzzzzzzzzzzzzzzzzzzzzzl_, gzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Interval(gzzzzzzzzzzzzzzzzzzzzzzzzzzi_, gzzzzzzzzzzzzzzzzzzzzzzzzzzn_, true, true);
                bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.In<CqlDateTime>(gzzzzzzzzzzzzzzzzzzzzzzzzzzd_, gzzzzzzzzzzzzzzzzzzzzzzzzzzo_, default);
                Code<ObservationStatus> gzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = WhiteBloodCellLab?.StatusElement;
                ObservationStatus? gzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = gzzzzzzzzzzzzzzzzzzzzzzzzzzq_?.Value;
                string gzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Convert<string>(gzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                string[] gzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<string>(gzzzzzzzzzzzzzzzzzzzzzzzzzzs_, gzzzzzzzzzzzzzzzzzzzzzzzzzzt_ as IEnumerable<string>);
                bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzzzzzzp_, gzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = WhiteBloodCellLab?.Value;
                object gzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Not((bool?)(gzzzzzzzzzzzzzzzzzzzzzzzzzzx_ is null));
                bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzzzzzzv_, gzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

                return gzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Observation>(fzzzzzzzzzzzzzzzzzzzzzzzzzzh_, fzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            object fzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Observation @this)
            {
                Instant hzzzzzzzzzzzzzzzzzzzzzzzzzza_ = @this?.IssuedElement;
                DateTimeOffset? hzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = hzzzzzzzzzzzzzzzzzzzzzzzzzza_?.Value;
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<CqlDateTime>(hzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.earliest(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzc_ as object);

                return hzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.SortBy<Observation>(fzzzzzzzzzzzzzzzzzzzzzzzzzzj_, fzzzzzzzzzzzzzzzzzzzzzzzzzzk_, System.ComponentModel.ListSortDirection.Ascending);
            Observation fzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.First<Observation>(fzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            DataType fzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = fzzzzzzzzzzzzzzzzzzzzzzzzzzm_?.Value;
            object fzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzr_(Observation WhiteBloodCellLab)
            {
                Instant hzzzzzzzzzzzzzzzzzzzzzzzzzze_ = WhiteBloodCellLab?.IssuedElement;
                DateTimeOffset? hzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = hzzzzzzzzzzzzzzzzzzzzzzzzzze_?.Value;
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<CqlDateTime>(hzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.earliest(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzg_ as object);
                Period hzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Start(hzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlQuantity hzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Subtract(hzzzzzzzzzzzzzzzzzzzzzzzzzzk_, hzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(hzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Add(hzzzzzzzzzzzzzzzzzzzzzzzzzzp_, hzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Interval(hzzzzzzzzzzzzzzzzzzzzzzzzzzm_, hzzzzzzzzzzzzzzzzzzzzzzzzzzr_, true, true);
                bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.In<CqlDateTime>(hzzzzzzzzzzzzzzzzzzzzzzzzzzh_, hzzzzzzzzzzzzzzzzzzzzzzzzzzs_, default);
                Code<ObservationStatus> hzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = WhiteBloodCellLab?.StatusElement;
                ObservationStatus? hzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = hzzzzzzzzzzzzzzzzzzzzzzzzzzu_?.Value;
                string hzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<string>(hzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                string[] hzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<string>(hzzzzzzzzzzzzzzzzzzzzzzzzzzw_, hzzzzzzzzzzzzzzzzzzzzzzzzzzx_ as IEnumerable<string>);
                bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzzzzzzt_, hzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                DataType izzzzzzzzzzzzzzzzzzzzzzzzzza_ = WhiteBloodCellLab?.Value;
                object izzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzza_);
                bool? izzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Not((bool?)(izzzzzzzzzzzzzzzzzzzzzzzzzzb_ is null));
                bool? izzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzzzzzzz_, izzzzzzzzzzzzzzzzzzzzzzzzzzc_);

                return izzzzzzzzzzzzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Observation>(fzzzzzzzzzzzzzzzzzzzzzzzzzzq_, fzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            object fzzzzzzzzzzzzzzzzzzzzzzzzzzt_(Observation @this)
            {
                Instant izzzzzzzzzzzzzzzzzzzzzzzzzze_ = @this?.IssuedElement;
                DateTimeOffset? izzzzzzzzzzzzzzzzzzzzzzzzzzf_ = izzzzzzzzzzzzzzzzzzzzzzzzzze_?.Value;
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<CqlDateTime>(izzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.earliest(context, izzzzzzzzzzzzzzzzzzzzzzzzzzg_ as object);

                return izzzzzzzzzzzzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.SortBy<Observation>(fzzzzzzzzzzzzzzzzzzzzzzzzzzs_, fzzzzzzzzzzzzzzzzzzzzzzzzzzt_, System.ComponentModel.ListSortDirection.Ascending);
            Observation fzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.First<Observation>(fzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            Instant fzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = fzzzzzzzzzzzzzzzzzzzzzzzzzzv_?.IssuedElement;
            DateTimeOffset? fzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = fzzzzzzzzzzzzzzzzzzzzzzzzzzw_?.Value;
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<CqlDateTime>(fzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)? fzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = (CqlTupleMetadata_ChVYCdXDGgVcFTCCUefXMbCHX, fzzzzzzzzzzzzzzzzzzzzzzzzzzf_, fzzzzzzzzzzzzzzzzzzzzzzzzzzo_ as CqlQuantity, fzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

            return fzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)?> fzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)?>(fzzzzzzzzzzzzzzzzzzzzzzzzzza_, fzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)?> fzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)?>(fzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

        return fzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? izzzzzzzzzzzzzzzzzzzzzzzzzzi_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return izzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> izzzzzzzzzzzzzzzzzzzzzzzzzzj_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return izzzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? izzzzzzzzzzzzzzzzzzzzzzzzzzk_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return izzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode izzzzzzzzzzzzzzzzzzzzzzzzzzl_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return izzzzzzzzzzzzzzzzzzzzzzzzzzl_;
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
