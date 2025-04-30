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
      new CqlCodeSystem("http://loinc.org", null,
          _Oxygen_saturation_in_Arterial_blood,
          _Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry,
          _Systolic_blood_pressure);

    [CqlCodeSystemDefinition("ActCode")]
    public CqlCodeSystem ActCode(CqlContext _) => _ActCode;
    private static readonly CqlCodeSystem _ActCode =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/v3-ActCode", null);

    [CqlCodeSystemDefinition("Source of Payment Typology")]
    public CqlCodeSystem Source_of_Payment_Typology(CqlContext _) => _Source_of_Payment_Typology;
    private static readonly CqlCodeSystem _Source_of_Payment_Typology =
      new CqlCodeSystem("https://nahdo.org/sopt", null);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Interval(qzzzzzzzzzzzzzzzzzzzzzzzzzo_, qzzzzzzzzzzzzzzzzzzzzzzzzzp_, true, true);
        object qzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.ResolveParameter("HybridHospitalWideMortalityFHIR-0.0.001", "Measurement Period", qzzzzzzzzzzzzzzzzzzzzzzzzzq_);

        return (CqlInterval<CqlDateTime>)qzzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> qzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient qzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.SingletonFrom<Patient>(qzzzzzzzzzzzzzzzzzzzzzzzzzs_);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Inpatient Encounters")]
    public IEnumerable<Encounter> Inpatient_Encounters(CqlContext context)
    {
        CqlValueSet qzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzw_(Encounter InpatientEncounter)
        {
            CqlValueSet qzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Medicare_FFS_payer(context);
            IEnumerable<Coverage> qzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Coverage>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-coverage"));
            CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Medicare_Advantage_payer(context);
            IEnumerable<Coverage> rzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Coverage>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-coverage"));
            IEnumerable<Coverage> rzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Union<Coverage>(qzzzzzzzzzzzzzzzzzzzzzzzzzz_, rzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzd_(Coverage MedicarePayer)
            {
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzh_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, InpatientEncounter);
                int? rzzzzzzzzzzzzzzzzzzzzzzzzzi_ = CQMCommon_2_2_000.Instance.lengthInDays(context, rzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Less(rzzzzzzzzzzzzzzzzzzzzzzzzzi_, 365);
                Code<Encounter.EncounterStatus> rzzzzzzzzzzzzzzzzzzzzzzzzzk_ = InpatientEncounter?.StatusElement;
                Encounter.EncounterStatus? rzzzzzzzzzzzzzzzzzzzzzzzzzl_ = rzzzzzzzzzzzzzzzzzzzzzzzzzk_?.Value;
                Code<Encounter.EncounterStatus> rzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(rzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Equal(rzzzzzzzzzzzzzzzzzzzzzzzzzm_, "finished");
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzzzzzzj_, rzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                Patient rzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Patient(context);
                Date rzzzzzzzzzzzzzzzzzzzzzzzzzq_ = rzzzzzzzzzzzzzzzzzzzzzzzzzp_?.BirthDateElement;
                string rzzzzzzzzzzzzzzzzzzzzzzzzzr_ = rzzzzzzzzzzzzzzzzzzzzzzzzzq_?.Value;
                CqlDate rzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ConvertStringToDate(rzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                Period rzzzzzzzzzzzzzzzzzzzzzzzzzt_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Start(rzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlDate rzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.DateFrom(rzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                int? rzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.CalculateAgeAt(rzzzzzzzzzzzzzzzzzzzzzzzzzs_, rzzzzzzzzzzzzzzzzzzzzzzzzzw_, "year");
                CqlInterval<int?> rzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Interval(65, 94, true, true);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<int?>(rzzzzzzzzzzzzzzzzzzzzzzzzzx_, rzzzzzzzzzzzzzzzzzzzzzzzzzy_, default);
                bool? szzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzzzzzzo_, rzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.End(szzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Measurement_Period(context);
                bool? szzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.In<CqlDateTime>(szzzzzzzzzzzzzzzzzzzzzzzzzd_, szzzzzzzzzzzzzzzzzzzzzzzzze_, "day");
                bool? szzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzzzzza_, szzzzzzzzzzzzzzzzzzzzzzzzzf_);

                return szzzzzzzzzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Coverage> rzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Coverage>(rzzzzzzzzzzzzzzzzzzzzzzzzzc_, rzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            Encounter rzzzzzzzzzzzzzzzzzzzzzzzzzf_(Coverage MedicarePayer) =>
                InpatientEncounter;
            IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Select<Coverage, Encounter>(rzzzzzzzzzzzzzzzzzzzzzzzzze_, rzzzzzzzzzzzzzzzzzzzzzzzzzf_);

            return rzzzzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.SelectMany<Encounter, Encounter>(qzzzzzzzzzzzzzzzzzzzzzzzzzv_, qzzzzzzzzzzzzzzzzzzzzzzzzzw_);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Inpatient_Encounters(context);

        return szzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Encounter with First Body Temperature")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)?> Encounter_with_First_Body_Temperature(CqlContext context)
    {
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)? szzzzzzzzzzzzzzzzzzzzzzzzzj_(Encounter EncounterInpatient)
        {
            Id szzzzzzzzzzzzzzzzzzzzzzzzzm_ = EncounterInpatient?.IdElement;
            string szzzzzzzzzzzzzzzzzzzzzzzzzn_ = szzzzzzzzzzzzzzzzzzzzzzzzzm_?.Value;
            IEnumerable<Observation> szzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bodytemp"));
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzp_(Observation temperature)
            {
                DataType tzzzzzzzzzzzzzzzzzzzzzzzzzg_ = temperature?.Effective;
                object tzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.earliest(context, tzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                Period tzzzzzzzzzzzzzzzzzzzzzzzzzj_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlQuantity tzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Subtract(tzzzzzzzzzzzzzzzzzzzzzzzzzl_, tzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlQuantity tzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Add(tzzzzzzzzzzzzzzzzzzzzzzzzzq_, tzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Interval(tzzzzzzzzzzzzzzzzzzzzzzzzzn_, tzzzzzzzzzzzzzzzzzzzzzzzzzs_, true, true);
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(tzzzzzzzzzzzzzzzzzzzzzzzzzi_, tzzzzzzzzzzzzzzzzzzzzzzzzzt_, default);
                Code<ObservationStatus> tzzzzzzzzzzzzzzzzzzzzzzzzzv_ = temperature?.StatusElement;
                ObservationStatus? tzzzzzzzzzzzzzzzzzzzzzzzzzw_ = tzzzzzzzzzzzzzzzzzzzzzzzzzv_?.Value;
                string tzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<string>(tzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                string[] tzzzzzzzzzzzzzzzzzzzzzzzzzy_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<string>(tzzzzzzzzzzzzzzzzzzzzzzzzzx_, tzzzzzzzzzzzzzzzzzzzzzzzzzy_ as IEnumerable<string>);
                bool? uzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzzzzu_, tzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                DataType uzzzzzzzzzzzzzzzzzzzzzzzzzb_ = temperature?.Value;
                CqlQuantity uzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, uzzzzzzzzzzzzzzzzzzzzzzzzzb_ as Quantity);
                bool? uzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Not((bool?)(uzzzzzzzzzzzzzzzzzzzzzzzzzc_ is null));
                bool? uzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzzzzzzza_, uzzzzzzzzzzzzzzzzzzzzzzzzzd_);

                return uzzzzzzzzzzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<Observation> szzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Observation>(szzzzzzzzzzzzzzzzzzzzzzzzzo_, szzzzzzzzzzzzzzzzzzzzzzzzzp_);
            object szzzzzzzzzzzzzzzzzzzzzzzzzr_(Observation @this)
            {
                DataType uzzzzzzzzzzzzzzzzzzzzzzzzzf_ = @this?.Effective;
                object uzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.earliest(context, uzzzzzzzzzzzzzzzzzzzzzzzzzg_);

                return uzzzzzzzzzzzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<Observation> szzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.SortBy<Observation>(szzzzzzzzzzzzzzzzzzzzzzzzzq_, szzzzzzzzzzzzzzzzzzzzzzzzzr_, System.ComponentModel.ListSortDirection.Ascending);
            Observation szzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.First<Observation>(szzzzzzzzzzzzzzzzzzzzzzzzzs_);
            DataType szzzzzzzzzzzzzzzzzzzzzzzzzu_ = szzzzzzzzzzzzzzzzzzzzzzzzzt_?.Value;
            CqlQuantity szzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, szzzzzzzzzzzzzzzzzzzzzzzzzu_ as Quantity);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzx_(Observation temperature)
            {
                DataType uzzzzzzzzzzzzzzzzzzzzzzzzzi_ = temperature?.Effective;
                object uzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.earliest(context, uzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                Period uzzzzzzzzzzzzzzzzzzzzzzzzzl_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(uzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlQuantity uzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Subtract(uzzzzzzzzzzzzzzzzzzzzzzzzzn_, uzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(uzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlQuantity uzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Add(uzzzzzzzzzzzzzzzzzzzzzzzzzs_, uzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Interval(uzzzzzzzzzzzzzzzzzzzzzzzzzp_, uzzzzzzzzzzzzzzzzzzzzzzzzzu_, true, true);
                bool? uzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.In<CqlDateTime>(uzzzzzzzzzzzzzzzzzzzzzzzzzk_, uzzzzzzzzzzzzzzzzzzzzzzzzzv_, default);
                Code<ObservationStatus> uzzzzzzzzzzzzzzzzzzzzzzzzzx_ = temperature?.StatusElement;
                ObservationStatus? uzzzzzzzzzzzzzzzzzzzzzzzzzy_ = uzzzzzzzzzzzzzzzzzzzzzzzzzx_?.Value;
                string uzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Convert<string>(uzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                string[] vzzzzzzzzzzzzzzzzzzzzzzzzza_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.In<string>(uzzzzzzzzzzzzzzzzzzzzzzzzzz_, vzzzzzzzzzzzzzzzzzzzzzzzzza_ as IEnumerable<string>);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzzzzzzzw_, vzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                DataType vzzzzzzzzzzzzzzzzzzzzzzzzzd_ = temperature?.Value;
                CqlQuantity vzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, vzzzzzzzzzzzzzzzzzzzzzzzzzd_ as Quantity);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Not((bool?)(vzzzzzzzzzzzzzzzzzzzzzzzzze_ is null));
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzzzzzzc_, vzzzzzzzzzzzzzzzzzzzzzzzzzf_);

                return vzzzzzzzzzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Observation> szzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Observation>(szzzzzzzzzzzzzzzzzzzzzzzzzo_, szzzzzzzzzzzzzzzzzzzzzzzzzx_);
            object szzzzzzzzzzzzzzzzzzzzzzzzzz_(Observation @this)
            {
                DataType vzzzzzzzzzzzzzzzzzzzzzzzzzh_ = @this?.Effective;
                object vzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.earliest(context, vzzzzzzzzzzzzzzzzzzzzzzzzzi_);

                return vzzzzzzzzzzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<Observation> tzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.SortBy<Observation>(szzzzzzzzzzzzzzzzzzzzzzzzzy_, szzzzzzzzzzzzzzzzzzzzzzzzzz_, System.ComponentModel.ListSortDirection.Ascending);
            Observation tzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.First<Observation>(tzzzzzzzzzzzzzzzzzzzzzzzzza_);
            DataType tzzzzzzzzzzzzzzzzzzzzzzzzzc_ = tzzzzzzzzzzzzzzzzzzzzzzzzzb_?.Effective;
            object tzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.earliest(context, tzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)? tzzzzzzzzzzzzzzzzzzzzzzzzzf_ = (CqlTupleMetadata_GIbILVAdXLLNYBgcQIEiUiKaK, szzzzzzzzzzzzzzzzzzzzzzzzzn_, szzzzzzzzzzzzzzzzzzzzzzzzzv_ as CqlQuantity, tzzzzzzzzzzzzzzzzzzzzzzzzze_);

            return tzzzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)?> szzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)?>(szzzzzzzzzzzzzzzzzzzzzzzzzi_, szzzzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)?> szzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)?>(szzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return szzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Encounter with First Heart Rate")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)?> Encounter_with_First_Heart_Rate(CqlContext context)
    {
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)? vzzzzzzzzzzzzzzzzzzzzzzzzzl_(Encounter EncounterInpatient)
        {
            Id vzzzzzzzzzzzzzzzzzzzzzzzzzo_ = EncounterInpatient?.IdElement;
            string vzzzzzzzzzzzzzzzzzzzzzzzzzp_ = vzzzzzzzzzzzzzzzzzzzzzzzzzo_?.Value;
            IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/heartrate"));
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzr_(Observation HeartRate)
            {
                DataType wzzzzzzzzzzzzzzzzzzzzzzzzzi_ = HeartRate?.Effective;
                object wzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.earliest(context, wzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                Period wzzzzzzzzzzzzzzzzzzzzzzzzzl_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(wzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlQuantity wzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Subtract(wzzzzzzzzzzzzzzzzzzzzzzzzzn_, wzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(wzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlQuantity wzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Add(wzzzzzzzzzzzzzzzzzzzzzzzzzs_, wzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Interval(wzzzzzzzzzzzzzzzzzzzzzzzzzp_, wzzzzzzzzzzzzzzzzzzzzzzzzzu_, true, true);
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.In<CqlDateTime>(wzzzzzzzzzzzzzzzzzzzzzzzzzk_, wzzzzzzzzzzzzzzzzzzzzzzzzzv_, default);
                Code<ObservationStatus> wzzzzzzzzzzzzzzzzzzzzzzzzzx_ = HeartRate?.StatusElement;
                ObservationStatus? wzzzzzzzzzzzzzzzzzzzzzzzzzy_ = wzzzzzzzzzzzzzzzzzzzzzzzzzx_?.Value;
                string wzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Convert<string>(wzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                string[] xzzzzzzzzzzzzzzzzzzzzzzzzza_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.In<string>(wzzzzzzzzzzzzzzzzzzzzzzzzzz_, xzzzzzzzzzzzzzzzzzzzzzzzzza_ as IEnumerable<string>);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzzzzzw_, xzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                DataType xzzzzzzzzzzzzzzzzzzzzzzzzzd_ = HeartRate?.Value;
                CqlQuantity xzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, xzzzzzzzzzzzzzzzzzzzzzzzzzd_ as Quantity);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Not((bool?)(xzzzzzzzzzzzzzzzzzzzzzzzzze_ is null));
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzzzzzc_, xzzzzzzzzzzzzzzzzzzzzzzzzzf_);

                return xzzzzzzzzzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Observation>(vzzzzzzzzzzzzzzzzzzzzzzzzzq_, vzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            object vzzzzzzzzzzzzzzzzzzzzzzzzzt_(Observation @this)
            {
                DataType xzzzzzzzzzzzzzzzzzzzzzzzzzh_ = @this?.Effective;
                object xzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.earliest(context, xzzzzzzzzzzzzzzzzzzzzzzzzzi_);

                return xzzzzzzzzzzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.SortBy<Observation>(vzzzzzzzzzzzzzzzzzzzzzzzzzs_, vzzzzzzzzzzzzzzzzzzzzzzzzzt_, System.ComponentModel.ListSortDirection.Ascending);
            Observation vzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.First<Observation>(vzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            DataType vzzzzzzzzzzzzzzzzzzzzzzzzzw_ = vzzzzzzzzzzzzzzzzzzzzzzzzzv_?.Value;
            CqlQuantity vzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, vzzzzzzzzzzzzzzzzzzzzzzzzzw_ as Quantity);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzz_(Observation HeartRate)
            {
                DataType xzzzzzzzzzzzzzzzzzzzzzzzzzk_ = HeartRate?.Effective;
                object xzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.earliest(context, xzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                Period xzzzzzzzzzzzzzzzzzzzzzzzzzn_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlQuantity xzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Subtract(xzzzzzzzzzzzzzzzzzzzzzzzzzp_, xzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlQuantity xzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Add(xzzzzzzzzzzzzzzzzzzzzzzzzzu_, xzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Interval(xzzzzzzzzzzzzzzzzzzzzzzzzzr_, xzzzzzzzzzzzzzzzzzzzzzzzzzw_, true, true);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzzzzzzzzzzzzzzzzzm_, xzzzzzzzzzzzzzzzzzzzzzzzzzx_, default);
                Code<ObservationStatus> xzzzzzzzzzzzzzzzzzzzzzzzzzz_ = HeartRate?.StatusElement;
                ObservationStatus? yzzzzzzzzzzzzzzzzzzzzzzzzza_ = xzzzzzzzzzzzzzzzzzzzzzzzzzz_?.Value;
                string yzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Convert<string>(yzzzzzzzzzzzzzzzzzzzzzzzzza_);
                string[] yzzzzzzzzzzzzzzzzzzzzzzzzzc_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<string>(yzzzzzzzzzzzzzzzzzzzzzzzzzb_, yzzzzzzzzzzzzzzzzzzzzzzzzzc_ as IEnumerable<string>);
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzzzzzy_, yzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                DataType yzzzzzzzzzzzzzzzzzzzzzzzzzf_ = HeartRate?.Value;
                CqlQuantity yzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, yzzzzzzzzzzzzzzzzzzzzzzzzzf_ as Quantity);
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Not((bool?)(yzzzzzzzzzzzzzzzzzzzzzzzzzg_ is null));
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzzzzzzze_, yzzzzzzzzzzzzzzzzzzzzzzzzzh_);

                return yzzzzzzzzzzzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Observation>(vzzzzzzzzzzzzzzzzzzzzzzzzzq_, vzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            object wzzzzzzzzzzzzzzzzzzzzzzzzzb_(Observation @this)
            {
                DataType yzzzzzzzzzzzzzzzzzzzzzzzzzj_ = @this?.Effective;
                object yzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.earliest(context, yzzzzzzzzzzzzzzzzzzzzzzzzzk_);

                return yzzzzzzzzzzzzzzzzzzzzzzzzzl_;
            };
            IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.SortBy<Observation>(wzzzzzzzzzzzzzzzzzzzzzzzzza_, wzzzzzzzzzzzzzzzzzzzzzzzzzb_, System.ComponentModel.ListSortDirection.Ascending);
            Observation wzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.First<Observation>(wzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            DataType wzzzzzzzzzzzzzzzzzzzzzzzzze_ = wzzzzzzzzzzzzzzzzzzzzzzzzzd_?.Effective;
            object wzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.earliest(context, wzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)? wzzzzzzzzzzzzzzzzzzzzzzzzzh_ = (CqlTupleMetadata_DhbJAfCiKIAGYKTjJXYGSKECQ, vzzzzzzzzzzzzzzzzzzzzzzzzzp_, vzzzzzzzzzzzzzzzzzzzzzzzzzx_ as CqlQuantity, wzzzzzzzzzzzzzzzzzzzzzzzzzg_);

            return wzzzzzzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)?> vzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)?>(vzzzzzzzzzzzzzzzzzzzzzzzzzk_, vzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)?> vzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)?>(vzzzzzzzzzzzzzzzzzzzzzzzzzm_);

        return vzzzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Encounter with First Oxygen Saturation")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)?> Encounter_with_First_Oxygen_Saturation(CqlContext context)
    {
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)? yzzzzzzzzzzzzzzzzzzzzzzzzzn_(Encounter EncounterInpatient)
        {
            Id yzzzzzzzzzzzzzzzzzzzzzzzzzq_ = EncounterInpatient?.IdElement;
            string yzzzzzzzzzzzzzzzzzzzzzzzzzr_ = yzzzzzzzzzzzzzzzzzzzzzzzzzq_?.Value;
            CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
            IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzu_(Observation O2Saturation)
            {
                object zzzzzzzzzzzzzzzzzzzzzzzzzze_()
                {
                    bool azzzzzzzzzzzzzzzzzzzzzzzzzzd_()
                    {
                        DataType azzzzzzzzzzzzzzzzzzzzzzzzzzg_ = O2Saturation?.Effective;
                        object azzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                        bool azzzzzzzzzzzzzzzzzzzzzzzzzzi_ = azzzzzzzzzzzzzzzzzzzzzzzzzzh_ is CqlDateTime;

                        return azzzzzzzzzzzzzzzzzzzzzzzzzzi_;
                    };
                    bool azzzzzzzzzzzzzzzzzzzzzzzzzze_()
                    {
                        DataType azzzzzzzzzzzzzzzzzzzzzzzzzzj_ = O2Saturation?.Effective;
                        object azzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                        bool azzzzzzzzzzzzzzzzzzzzzzzzzzl_ = azzzzzzzzzzzzzzzzzzzzzzzzzzk_ is CqlInterval<CqlDateTime>;

                        return azzzzzzzzzzzzzzzzzzzzzzzzzzl_;
                    };
                    bool azzzzzzzzzzzzzzzzzzzzzzzzzzf_()
                    {
                        DataType azzzzzzzzzzzzzzzzzzzzzzzzzzm_ = O2Saturation?.Effective;
                        object azzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                        bool azzzzzzzzzzzzzzzzzzzzzzzzzzo_ = azzzzzzzzzzzzzzzzzzzzzzzzzzn_ is CqlDateTime;

                        return azzzzzzzzzzzzzzzzzzzzzzzzzzo_;
                    };
                    if (azzzzzzzzzzzzzzzzzzzzzzzzzzd_())
                    {
                        DataType azzzzzzzzzzzzzzzzzzzzzzzzzzp_ = O2Saturation?.Effective;
                        object azzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzzp_);

                        return (azzzzzzzzzzzzzzzzzzzzzzzzzzq_ as CqlDateTime) as object;
                    }
                    else if (azzzzzzzzzzzzzzzzzzzzzzzzzze_())
                    {
                        DataType azzzzzzzzzzzzzzzzzzzzzzzzzzr_ = O2Saturation?.Effective;
                        object azzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzzr_);

                        return (azzzzzzzzzzzzzzzzzzzzzzzzzzs_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (azzzzzzzzzzzzzzzzzzzzzzzzzzf_())
                    {
                        DataType azzzzzzzzzzzzzzzzzzzzzzzzzzt_ = O2Saturation?.Effective;
                        object azzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzzt_);

                        return (azzzzzzzzzzzzzzzzzzzzzzzzzzu_ as CqlDateTime) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.earliest(context, zzzzzzzzzzzzzzzzzzzzzzzzzze_());
                Period zzzzzzzzzzzzzzzzzzzzzzzzzzg_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Start(zzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlQuantity zzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Subtract(zzzzzzzzzzzzzzzzzzzzzzzzzzi_, zzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(zzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlQuantity zzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Add(zzzzzzzzzzzzzzzzzzzzzzzzzzn_, zzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Interval(zzzzzzzzzzzzzzzzzzzzzzzzzzk_, zzzzzzzzzzzzzzzzzzzzzzzzzzp_, true, true);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(zzzzzzzzzzzzzzzzzzzzzzzzzzf_, zzzzzzzzzzzzzzzzzzzzzzzzzzq_, default);
                Code<ObservationStatus> zzzzzzzzzzzzzzzzzzzzzzzzzzs_ = O2Saturation?.StatusElement;
                ObservationStatus? zzzzzzzzzzzzzzzzzzzzzzzzzzt_ = zzzzzzzzzzzzzzzzzzzzzzzzzzs_?.Value;
                Code<ObservationStatus> zzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Convert<Code<ObservationStatus>>(zzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                string zzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Convert<string>(zzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                string[] zzzzzzzzzzzzzzzzzzzzzzzzzzw_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.In<string>(zzzzzzzzzzzzzzzzzzzzzzzzzzv_, zzzzzzzzzzzzzzzzzzzzzzzzzzw_ as IEnumerable<string>);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzzzzzr_, zzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                DataType zzzzzzzzzzzzzzzzzzzzzzzzzzz_ = O2Saturation?.Value;
                object azzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Not((bool?)(azzzzzzzzzzzzzzzzzzzzzzzzzza_ is null));
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzzzzzy_, azzzzzzzzzzzzzzzzzzzzzzzzzzb_);

                return azzzzzzzzzzzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Observation>(yzzzzzzzzzzzzzzzzzzzzzzzzzt_, yzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            object yzzzzzzzzzzzzzzzzzzzzzzzzzw_(Observation @this)
            {
                object azzzzzzzzzzzzzzzzzzzzzzzzzzv_()
                {
                    bool azzzzzzzzzzzzzzzzzzzzzzzzzzx_()
                    {
                        DataType bzzzzzzzzzzzzzzzzzzzzzzzzzza_ = @this?.Effective;
                        object bzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                        bool bzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzb_ is CqlDateTime;

                        return bzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
                    };
                    bool azzzzzzzzzzzzzzzzzzzzzzzzzzy_()
                    {
                        DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = @this?.Effective;
                        object bzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                        bool bzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = bzzzzzzzzzzzzzzzzzzzzzzzzzze_ is CqlInterval<CqlDateTime>;

                        return bzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
                    };
                    bool azzzzzzzzzzzzzzzzzzzzzzzzzzz_()
                    {
                        DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = @this?.Effective;
                        object bzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                        bool bzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzh_ is CqlDateTime;

                        return bzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
                    };
                    if (azzzzzzzzzzzzzzzzzzzzzzzzzzx_())
                    {
                        DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = @this?.Effective;
                        object bzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

                        return (bzzzzzzzzzzzzzzzzzzzzzzzzzzk_ as CqlDateTime) as object;
                    }
                    else if (azzzzzzzzzzzzzzzzzzzzzzzzzzy_())
                    {
                        DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = @this?.Effective;
                        object bzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

                        return (bzzzzzzzzzzzzzzzzzzzzzzzzzzm_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (azzzzzzzzzzzzzzzzzzzzzzzzzzz_())
                    {
                        DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = @this?.Effective;
                        object bzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

                        return (bzzzzzzzzzzzzzzzzzzzzzzzzzzo_ as CqlDateTime) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.earliest(context, azzzzzzzzzzzzzzzzzzzzzzzzzzv_());

                return azzzzzzzzzzzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.SortBy<Observation>(yzzzzzzzzzzzzzzzzzzzzzzzzzv_, yzzzzzzzzzzzzzzzzzzzzzzzzzw_, System.ComponentModel.ListSortDirection.Ascending);
            Observation yzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.First<Observation>(yzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            DataType yzzzzzzzzzzzzzzzzzzzzzzzzzz_ = yzzzzzzzzzzzzzzzzzzzzzzzzzy_?.Value;
            object zzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            object zzzzzzzzzzzzzzzzzzzzzzzzzzb_()
            {
                bool bzzzzzzzzzzzzzzzzzzzzzzzzzzp_()
                {
                    CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
                    IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzu_(Observation O2Saturation)
                    {
                        object czzzzzzzzzzzzzzzzzzzzzzzzzzc_()
                        {
                            bool dzzzzzzzzzzzzzzzzzzzzzzzzzzb_()
                            {
                                DataType dzzzzzzzzzzzzzzzzzzzzzzzzzze_ = O2Saturation?.Effective;
                                object dzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                                bool dzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = dzzzzzzzzzzzzzzzzzzzzzzzzzzf_ is CqlDateTime;

                                return dzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
                            };
                            bool dzzzzzzzzzzzzzzzzzzzzzzzzzzc_()
                            {
                                DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = O2Saturation?.Effective;
                                object dzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                                bool dzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = dzzzzzzzzzzzzzzzzzzzzzzzzzzi_ is CqlInterval<CqlDateTime>;

                                return dzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
                            };
                            bool dzzzzzzzzzzzzzzzzzzzzzzzzzzd_()
                            {
                                DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = O2Saturation?.Effective;
                                object dzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                                bool dzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = dzzzzzzzzzzzzzzzzzzzzzzzzzzl_ is CqlDateTime;

                                return dzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
                            };
                            if (dzzzzzzzzzzzzzzzzzzzzzzzzzzb_())
                            {
                                DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = O2Saturation?.Effective;
                                object dzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

                                return (dzzzzzzzzzzzzzzzzzzzzzzzzzzo_ as CqlDateTime) as object;
                            }
                            else if (dzzzzzzzzzzzzzzzzzzzzzzzzzzc_())
                            {
                                DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = O2Saturation?.Effective;
                                object dzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

                                return (dzzzzzzzzzzzzzzzzzzzzzzzzzzq_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (dzzzzzzzzzzzzzzzzzzzzzzzzzzd_())
                            {
                                DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = O2Saturation?.Effective;
                                object dzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

                                return (dzzzzzzzzzzzzzzzzzzzzzzzzzzs_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.earliest(context, czzzzzzzzzzzzzzzzzzzzzzzzzzc_());
                        Period czzzzzzzzzzzzzzzzzzzzzzzzzze_ = EncounterInpatient?.Period;
                        CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzzzzzzzzzzzzzzzzzzze_);
                        CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                        CqlQuantity czzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Quantity(1440m, "minutes");
                        CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Subtract(czzzzzzzzzzzzzzzzzzzzzzzzzzg_, czzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                        CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzzzzzzzzzzzzzzzzzzze_);
                        CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                        CqlQuantity czzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Quantity(120m, "minutes");
                        CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Add(czzzzzzzzzzzzzzzzzzzzzzzzzzl_, czzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                        CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Interval(czzzzzzzzzzzzzzzzzzzzzzzzzzi_, czzzzzzzzzzzzzzzzzzzzzzzzzzn_, true, true);
                        bool? czzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.In<CqlDateTime>(czzzzzzzzzzzzzzzzzzzzzzzzzzd_, czzzzzzzzzzzzzzzzzzzzzzzzzzo_, default);
                        Code<ObservationStatus> czzzzzzzzzzzzzzzzzzzzzzzzzzq_ = O2Saturation?.StatusElement;
                        ObservationStatus? czzzzzzzzzzzzzzzzzzzzzzzzzzr_ = czzzzzzzzzzzzzzzzzzzzzzzzzzq_?.Value;
                        Code<ObservationStatus> czzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Convert<Code<ObservationStatus>>(czzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                        string czzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Convert<string>(czzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                        string[] czzzzzzzzzzzzzzzzzzzzzzzzzzu_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? czzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.In<string>(czzzzzzzzzzzzzzzzzzzzzzzzzzt_, czzzzzzzzzzzzzzzzzzzzzzzzzzu_ as IEnumerable<string>);
                        bool? czzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzzzzzzzp_, czzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                        DataType czzzzzzzzzzzzzzzzzzzzzzzzzzx_ = O2Saturation?.Value;
                        object czzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                        bool? czzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Not((bool?)(czzzzzzzzzzzzzzzzzzzzzzzzzzy_ is null));
                        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzzzzzzzw_, czzzzzzzzzzzzzzzzzzzzzzzzzzz_);

                        return dzzzzzzzzzzzzzzzzzzzzzzzzzza_;
                    };
                    IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Observation>(bzzzzzzzzzzzzzzzzzzzzzzzzzzt_, bzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                    object bzzzzzzzzzzzzzzzzzzzzzzzzzzw_(Observation @this)
                    {
                        object dzzzzzzzzzzzzzzzzzzzzzzzzzzt_()
                        {
                            bool dzzzzzzzzzzzzzzzzzzzzzzzzzzv_()
                            {
                                DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = @this?.Effective;
                                object dzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                                bool ezzzzzzzzzzzzzzzzzzzzzzzzzza_ = dzzzzzzzzzzzzzzzzzzzzzzzzzzz_ is CqlDateTime;

                                return ezzzzzzzzzzzzzzzzzzzzzzzzzza_;
                            };
                            bool dzzzzzzzzzzzzzzzzzzzzzzzzzzw_()
                            {
                                DataType ezzzzzzzzzzzzzzzzzzzzzzzzzzb_ = @this?.Effective;
                                object ezzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                                bool ezzzzzzzzzzzzzzzzzzzzzzzzzzd_ = ezzzzzzzzzzzzzzzzzzzzzzzzzzc_ is CqlInterval<CqlDateTime>;

                                return ezzzzzzzzzzzzzzzzzzzzzzzzzzd_;
                            };
                            bool dzzzzzzzzzzzzzzzzzzzzzzzzzzx_()
                            {
                                DataType ezzzzzzzzzzzzzzzzzzzzzzzzzze_ = @this?.Effective;
                                object ezzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzzzze_);
                                bool ezzzzzzzzzzzzzzzzzzzzzzzzzzg_ = ezzzzzzzzzzzzzzzzzzzzzzzzzzf_ is CqlDateTime;

                                return ezzzzzzzzzzzzzzzzzzzzzzzzzzg_;
                            };
                            if (dzzzzzzzzzzzzzzzzzzzzzzzzzzv_())
                            {
                                DataType ezzzzzzzzzzzzzzzzzzzzzzzzzzh_ = @this?.Effective;
                                object ezzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzh_);

                                return (ezzzzzzzzzzzzzzzzzzzzzzzzzzi_ as CqlDateTime) as object;
                            }
                            else if (dzzzzzzzzzzzzzzzzzzzzzzzzzzw_())
                            {
                                DataType ezzzzzzzzzzzzzzzzzzzzzzzzzzj_ = @this?.Effective;
                                object ezzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzj_);

                                return (ezzzzzzzzzzzzzzzzzzzzzzzzzzk_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (dzzzzzzzzzzzzzzzzzzzzzzzzzzx_())
                            {
                                DataType ezzzzzzzzzzzzzzzzzzzzzzzzzzl_ = @this?.Effective;
                                object ezzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzl_);

                                return (ezzzzzzzzzzzzzzzzzzzzzzzzzzm_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.earliest(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzt_());

                        return dzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
                    };
                    IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.SortBy<Observation>(bzzzzzzzzzzzzzzzzzzzzzzzzzzv_, bzzzzzzzzzzzzzzzzzzzzzzzzzzw_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation bzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.First<Observation>(bzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                    DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzy_?.Effective;
                    object czzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                    bool czzzzzzzzzzzzzzzzzzzzzzzzzzb_ = czzzzzzzzzzzzzzzzzzzzzzzzzza_ is CqlDateTime;

                    return czzzzzzzzzzzzzzzzzzzzzzzzzzb_;
                };
                bool bzzzzzzzzzzzzzzzzzzzzzzzzzzq_()
                {
                    CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
                    IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzp_(Observation O2Saturation)
                    {
                        object ezzzzzzzzzzzzzzzzzzzzzzzzzzx_()
                        {
                            bool fzzzzzzzzzzzzzzzzzzzzzzzzzzw_()
                            {
                                DataType fzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = O2Saturation?.Effective;
                                object gzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                                bool gzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = gzzzzzzzzzzzzzzzzzzzzzzzzzza_ is CqlDateTime;

                                return gzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
                            };
                            bool fzzzzzzzzzzzzzzzzzzzzzzzzzzx_()
                            {
                                DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = O2Saturation?.Effective;
                                object gzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                                bool gzzzzzzzzzzzzzzzzzzzzzzzzzze_ = gzzzzzzzzzzzzzzzzzzzzzzzzzzd_ is CqlInterval<CqlDateTime>;

                                return gzzzzzzzzzzzzzzzzzzzzzzzzzze_;
                            };
                            bool fzzzzzzzzzzzzzzzzzzzzzzzzzzy_()
                            {
                                DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = O2Saturation?.Effective;
                                object gzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                                bool gzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = gzzzzzzzzzzzzzzzzzzzzzzzzzzg_ is CqlDateTime;

                                return gzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
                            };
                            if (fzzzzzzzzzzzzzzzzzzzzzzzzzzw_())
                            {
                                DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = O2Saturation?.Effective;
                                object gzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

                                return (gzzzzzzzzzzzzzzzzzzzzzzzzzzj_ as CqlDateTime) as object;
                            }
                            else if (fzzzzzzzzzzzzzzzzzzzzzzzzzzx_())
                            {
                                DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = O2Saturation?.Effective;
                                object gzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

                                return (gzzzzzzzzzzzzzzzzzzzzzzzzzzl_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (fzzzzzzzzzzzzzzzzzzzzzzzzzzy_())
                            {
                                DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = O2Saturation?.Effective;
                                object gzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

                                return (gzzzzzzzzzzzzzzzzzzzzzzzzzzn_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.earliest(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzx_());
                        Period ezzzzzzzzzzzzzzzzzzzzzzzzzzz_ = EncounterInpatient?.Period;
                        CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                        CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(fzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                        CqlQuantity fzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Quantity(1440m, "minutes");
                        CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Subtract(fzzzzzzzzzzzzzzzzzzzzzzzzzzb_, fzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                        CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                        CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(fzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                        CqlQuantity fzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Quantity(120m, "minutes");
                        CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Add(fzzzzzzzzzzzzzzzzzzzzzzzzzzg_, fzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                        CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Interval(fzzzzzzzzzzzzzzzzzzzzzzzzzzd_, fzzzzzzzzzzzzzzzzzzzzzzzzzzi_, true, true);
                        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.In<CqlDateTime>(ezzzzzzzzzzzzzzzzzzzzzzzzzzy_, fzzzzzzzzzzzzzzzzzzzzzzzzzzj_, default);
                        Code<ObservationStatus> fzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = O2Saturation?.StatusElement;
                        ObservationStatus? fzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = fzzzzzzzzzzzzzzzzzzzzzzzzzzl_?.Value;
                        Code<ObservationStatus> fzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Convert<Code<ObservationStatus>>(fzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                        string fzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Convert<string>(fzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                        string[] fzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.In<string>(fzzzzzzzzzzzzzzzzzzzzzzzzzzo_, fzzzzzzzzzzzzzzzzzzzzzzzzzzp_ as IEnumerable<string>);
                        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzzzzzk_, fzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                        DataType fzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = O2Saturation?.Value;
                        object fzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Not((bool?)(fzzzzzzzzzzzzzzzzzzzzzzzzzzt_ is null));
                        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzzzzzr_, fzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

                        return fzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
                    };
                    IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Observation>(ezzzzzzzzzzzzzzzzzzzzzzzzzzo_, ezzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                    object ezzzzzzzzzzzzzzzzzzzzzzzzzzr_(Observation @this)
                    {
                        object gzzzzzzzzzzzzzzzzzzzzzzzzzzo_()
                        {
                            bool gzzzzzzzzzzzzzzzzzzzzzzzzzzq_()
                            {
                                DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = @this?.Effective;
                                object gzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                                bool gzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = gzzzzzzzzzzzzzzzzzzzzzzzzzzu_ is CqlDateTime;

                                return gzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
                            };
                            bool gzzzzzzzzzzzzzzzzzzzzzzzzzzr_()
                            {
                                DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = @this?.Effective;
                                object gzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                                bool gzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = gzzzzzzzzzzzzzzzzzzzzzzzzzzx_ is CqlInterval<CqlDateTime>;

                                return gzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
                            };
                            bool gzzzzzzzzzzzzzzzzzzzzzzzzzzs_()
                            {
                                DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = @this?.Effective;
                                object hzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                                bool hzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = hzzzzzzzzzzzzzzzzzzzzzzzzzza_ is CqlDateTime;

                                return hzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
                            };
                            if (gzzzzzzzzzzzzzzzzzzzzzzzzzzq_())
                            {
                                DataType hzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = @this?.Effective;
                                object hzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

                                return (hzzzzzzzzzzzzzzzzzzzzzzzzzzd_ as CqlDateTime) as object;
                            }
                            else if (gzzzzzzzzzzzzzzzzzzzzzzzzzzr_())
                            {
                                DataType hzzzzzzzzzzzzzzzzzzzzzzzzzze_ = @this?.Effective;
                                object hzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzzze_);

                                return (hzzzzzzzzzzzzzzzzzzzzzzzzzzf_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (gzzzzzzzzzzzzzzzzzzzzzzzzzzs_())
                            {
                                DataType hzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = @this?.Effective;
                                object hzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

                                return (hzzzzzzzzzzzzzzzzzzzzzzzzzzh_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.earliest(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzo_());

                        return gzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
                    };
                    IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.SortBy<Observation>(ezzzzzzzzzzzzzzzzzzzzzzzzzzq_, ezzzzzzzzzzzzzzzzzzzzzzzzzzr_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation ezzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.First<Observation>(ezzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                    DataType ezzzzzzzzzzzzzzzzzzzzzzzzzzu_ = ezzzzzzzzzzzzzzzzzzzzzzzzzzt_?.Effective;
                    object ezzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                    bool ezzzzzzzzzzzzzzzzzzzzzzzzzzw_ = ezzzzzzzzzzzzzzzzzzzzzzzzzzv_ is CqlInterval<CqlDateTime>;

                    return ezzzzzzzzzzzzzzzzzzzzzzzzzzw_;
                };
                bool bzzzzzzzzzzzzzzzzzzzzzzzzzzr_()
                {
                    CqlValueSet hzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
                    IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Observation O2Saturation)
                    {
                        object hzzzzzzzzzzzzzzzzzzzzzzzzzzs_()
                        {
                            bool izzzzzzzzzzzzzzzzzzzzzzzzzzr_()
                            {
                                DataType izzzzzzzzzzzzzzzzzzzzzzzzzzu_ = O2Saturation?.Effective;
                                object izzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                                bool izzzzzzzzzzzzzzzzzzzzzzzzzzw_ = izzzzzzzzzzzzzzzzzzzzzzzzzzv_ is CqlDateTime;

                                return izzzzzzzzzzzzzzzzzzzzzzzzzzw_;
                            };
                            bool izzzzzzzzzzzzzzzzzzzzzzzzzzs_()
                            {
                                DataType izzzzzzzzzzzzzzzzzzzzzzzzzzx_ = O2Saturation?.Effective;
                                object izzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                                bool izzzzzzzzzzzzzzzzzzzzzzzzzzz_ = izzzzzzzzzzzzzzzzzzzzzzzzzzy_ is CqlInterval<CqlDateTime>;

                                return izzzzzzzzzzzzzzzzzzzzzzzzzzz_;
                            };
                            bool izzzzzzzzzzzzzzzzzzzzzzzzzzt_()
                            {
                                DataType jzzzzzzzzzzzzzzzzzzzzzzzzzza_ = O2Saturation?.Effective;
                                object jzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                                bool jzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzb_ is CqlDateTime;

                                return jzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
                            };
                            if (izzzzzzzzzzzzzzzzzzzzzzzzzzr_())
                            {
                                DataType jzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = O2Saturation?.Effective;
                                object jzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

                                return (jzzzzzzzzzzzzzzzzzzzzzzzzzze_ as CqlDateTime) as object;
                            }
                            else if (izzzzzzzzzzzzzzzzzzzzzzzzzzs_())
                            {
                                DataType jzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = O2Saturation?.Effective;
                                object jzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

                                return (jzzzzzzzzzzzzzzzzzzzzzzzzzzg_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (izzzzzzzzzzzzzzzzzzzzzzzzzzt_())
                            {
                                DataType jzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = O2Saturation?.Effective;
                                object jzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

                                return (jzzzzzzzzzzzzzzzzzzzzzzzzzzi_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.earliest(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzs_());
                        Period hzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = EncounterInpatient?.Period;
                        CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                        CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(hzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                        CqlQuantity hzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Quantity(1440m, "minutes");
                        CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Subtract(hzzzzzzzzzzzzzzzzzzzzzzzzzzw_, hzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                        CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                        CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(izzzzzzzzzzzzzzzzzzzzzzzzzza_);
                        CqlQuantity izzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Quantity(120m, "minutes");
                        CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Add(izzzzzzzzzzzzzzzzzzzzzzzzzzb_, izzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                        CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Interval(hzzzzzzzzzzzzzzzzzzzzzzzzzzy_, izzzzzzzzzzzzzzzzzzzzzzzzzzd_, true, true);
                        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.In<CqlDateTime>(hzzzzzzzzzzzzzzzzzzzzzzzzzzt_, izzzzzzzzzzzzzzzzzzzzzzzzzze_, default);
                        Code<ObservationStatus> izzzzzzzzzzzzzzzzzzzzzzzzzzg_ = O2Saturation?.StatusElement;
                        ObservationStatus? izzzzzzzzzzzzzzzzzzzzzzzzzzh_ = izzzzzzzzzzzzzzzzzzzzzzzzzzg_?.Value;
                        Code<ObservationStatus> izzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Convert<Code<ObservationStatus>>(izzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                        string izzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Convert<string>(izzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                        string[] izzzzzzzzzzzzzzzzzzzzzzzzzzk_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.In<string>(izzzzzzzzzzzzzzzzzzzzzzzzzzj_, izzzzzzzzzzzzzzzzzzzzzzzzzzk_ as IEnumerable<string>);
                        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzzzzzf_, izzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                        DataType izzzzzzzzzzzzzzzzzzzzzzzzzzn_ = O2Saturation?.Value;
                        object izzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Not((bool?)(izzzzzzzzzzzzzzzzzzzzzzzzzzo_ is null));
                        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzzzzzm_, izzzzzzzzzzzzzzzzzzzzzzzzzzp_);

                        return izzzzzzzzzzzzzzzzzzzzzzzzzzq_;
                    };
                    IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Observation>(hzzzzzzzzzzzzzzzzzzzzzzzzzzj_, hzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                    object hzzzzzzzzzzzzzzzzzzzzzzzzzzm_(Observation @this)
                    {
                        object jzzzzzzzzzzzzzzzzzzzzzzzzzzj_()
                        {
                            bool jzzzzzzzzzzzzzzzzzzzzzzzzzzl_()
                            {
                                DataType jzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = @this?.Effective;
                                object jzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                                bool jzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzp_ is CqlDateTime;

                                return jzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
                            };
                            bool jzzzzzzzzzzzzzzzzzzzzzzzzzzm_()
                            {
                                DataType jzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = @this?.Effective;
                                object jzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                                bool jzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzs_ is CqlInterval<CqlDateTime>;

                                return jzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
                            };
                            bool jzzzzzzzzzzzzzzzzzzzzzzzzzzn_()
                            {
                                DataType jzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = @this?.Effective;
                                object jzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                                bool jzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzv_ is CqlDateTime;

                                return jzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
                            };
                            if (jzzzzzzzzzzzzzzzzzzzzzzzzzzl_())
                            {
                                DataType jzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = @this?.Effective;
                                object jzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

                                return (jzzzzzzzzzzzzzzzzzzzzzzzzzzy_ as CqlDateTime) as object;
                            }
                            else if (jzzzzzzzzzzzzzzzzzzzzzzzzzzm_())
                            {
                                DataType jzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = @this?.Effective;
                                object kzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

                                return (kzzzzzzzzzzzzzzzzzzzzzzzzzza_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (jzzzzzzzzzzzzzzzzzzzzzzzzzzn_())
                            {
                                DataType kzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = @this?.Effective;
                                object kzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

                                return (kzzzzzzzzzzzzzzzzzzzzzzzzzzc_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.earliest(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzj_());

                        return jzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
                    };
                    IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.SortBy<Observation>(hzzzzzzzzzzzzzzzzzzzzzzzzzzl_, hzzzzzzzzzzzzzzzzzzzzzzzzzzm_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation hzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.First<Observation>(hzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                    DataType hzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = hzzzzzzzzzzzzzzzzzzzzzzzzzzo_?.Effective;
                    object hzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                    bool hzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = hzzzzzzzzzzzzzzzzzzzzzzzzzzq_ is CqlDateTime;

                    return hzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
                };
                if (bzzzzzzzzzzzzzzzzzzzzzzzzzzp_())
                {
                    CqlValueSet kzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
                    IEnumerable<Observation> kzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzf_(Observation O2Saturation)
                    {
                        object kzzzzzzzzzzzzzzzzzzzzzzzzzzm_()
                        {
                            bool lzzzzzzzzzzzzzzzzzzzzzzzzzzl_()
                            {
                                DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = O2Saturation?.Effective;
                                object lzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                                bool lzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzp_ is CqlDateTime;

                                return lzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
                            };
                            bool lzzzzzzzzzzzzzzzzzzzzzzzzzzm_()
                            {
                                DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = O2Saturation?.Effective;
                                object lzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                                bool lzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzs_ is CqlInterval<CqlDateTime>;

                                return lzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
                            };
                            bool lzzzzzzzzzzzzzzzzzzzzzzzzzzn_()
                            {
                                DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = O2Saturation?.Effective;
                                object lzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                                bool lzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzv_ is CqlDateTime;

                                return lzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
                            };
                            if (lzzzzzzzzzzzzzzzzzzzzzzzzzzl_())
                            {
                                DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = O2Saturation?.Effective;
                                object lzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

                                return (lzzzzzzzzzzzzzzzzzzzzzzzzzzy_ as CqlDateTime) as object;
                            }
                            else if (lzzzzzzzzzzzzzzzzzzzzzzzzzzm_())
                            {
                                DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = O2Saturation?.Effective;
                                object mzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

                                return (mzzzzzzzzzzzzzzzzzzzzzzzzzza_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (lzzzzzzzzzzzzzzzzzzzzzzzzzzn_())
                            {
                                DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = O2Saturation?.Effective;
                                object mzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

                                return (mzzzzzzzzzzzzzzzzzzzzzzzzzzc_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.earliest(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzm_());
                        Period kzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = EncounterInpatient?.Period;
                        CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                        CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                        CqlQuantity kzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Quantity(1440m, "minutes");
                        CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Subtract(kzzzzzzzzzzzzzzzzzzzzzzzzzzq_, kzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                        CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                        CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                        CqlQuantity kzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Quantity(120m, "minutes");
                        CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Add(kzzzzzzzzzzzzzzzzzzzzzzzzzzv_, kzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                        CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Interval(kzzzzzzzzzzzzzzzzzzzzzzzzzzs_, kzzzzzzzzzzzzzzzzzzzzzzzzzzx_, true, true);
                        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<CqlDateTime>(kzzzzzzzzzzzzzzzzzzzzzzzzzzn_, kzzzzzzzzzzzzzzzzzzzzzzzzzzy_, default);
                        Code<ObservationStatus> lzzzzzzzzzzzzzzzzzzzzzzzzzza_ = O2Saturation?.StatusElement;
                        ObservationStatus? lzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = lzzzzzzzzzzzzzzzzzzzzzzzzzza_?.Value;
                        Code<ObservationStatus> lzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<Code<ObservationStatus>>(lzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                        string lzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Convert<string>(lzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                        string[] lzzzzzzzzzzzzzzzzzzzzzzzzzze_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.In<string>(lzzzzzzzzzzzzzzzzzzzzzzzzzzd_, lzzzzzzzzzzzzzzzzzzzzzzzzzze_ as IEnumerable<string>);
                        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzzzzzz_, lzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                        DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = O2Saturation?.Value;
                        object lzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Not((bool?)(lzzzzzzzzzzzzzzzzzzzzzzzzzzi_ is null));
                        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzzzzzg_, lzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

                        return lzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
                    };
                    IEnumerable<Observation> kzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Observation>(kzzzzzzzzzzzzzzzzzzzzzzzzzze_, kzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                    object kzzzzzzzzzzzzzzzzzzzzzzzzzzh_(Observation @this)
                    {
                        object mzzzzzzzzzzzzzzzzzzzzzzzzzzd_()
                        {
                            bool mzzzzzzzzzzzzzzzzzzzzzzzzzzf_()
                            {
                                DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = @this?.Effective;
                                object mzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                                bool mzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = mzzzzzzzzzzzzzzzzzzzzzzzzzzj_ is CqlDateTime;

                                return mzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
                            };
                            bool mzzzzzzzzzzzzzzzzzzzzzzzzzzg_()
                            {
                                DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = @this?.Effective;
                                object mzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                                bool mzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = mzzzzzzzzzzzzzzzzzzzzzzzzzzm_ is CqlInterval<CqlDateTime>;

                                return mzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
                            };
                            bool mzzzzzzzzzzzzzzzzzzzzzzzzzzh_()
                            {
                                DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = @this?.Effective;
                                object mzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                                bool mzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = mzzzzzzzzzzzzzzzzzzzzzzzzzzp_ is CqlDateTime;

                                return mzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
                            };
                            if (mzzzzzzzzzzzzzzzzzzzzzzzzzzf_())
                            {
                                DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = @this?.Effective;
                                object mzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

                                return (mzzzzzzzzzzzzzzzzzzzzzzzzzzs_ as CqlDateTime) as object;
                            }
                            else if (mzzzzzzzzzzzzzzzzzzzzzzzzzzg_())
                            {
                                DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = @this?.Effective;
                                object mzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

                                return (mzzzzzzzzzzzzzzzzzzzzzzzzzzu_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (mzzzzzzzzzzzzzzzzzzzzzzzzzzh_())
                            {
                                DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = @this?.Effective;
                                object mzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

                                return (mzzzzzzzzzzzzzzzzzzzzzzzzzzw_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.earliest(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzd_());

                        return mzzzzzzzzzzzzzzzzzzzzzzzzzze_;
                    };
                    IEnumerable<Observation> kzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.SortBy<Observation>(kzzzzzzzzzzzzzzzzzzzzzzzzzzg_, kzzzzzzzzzzzzzzzzzzzzzzzzzzh_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation kzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.First<Observation>(kzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                    DataType kzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzj_?.Effective;
                    object kzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

                    return (kzzzzzzzzzzzzzzzzzzzzzzzzzzl_ as CqlDateTime) as object;
                }
                else if (bzzzzzzzzzzzzzzzzzzzzzzzzzzq_())
                {
                    CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
                    IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzz_(Observation O2Saturation)
                    {
                        object nzzzzzzzzzzzzzzzzzzzzzzzzzzg_()
                        {
                            bool ozzzzzzzzzzzzzzzzzzzzzzzzzzf_()
                            {
                                DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzi_ = O2Saturation?.Effective;
                                object ozzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                                bool ozzzzzzzzzzzzzzzzzzzzzzzzzzk_ = ozzzzzzzzzzzzzzzzzzzzzzzzzzj_ is CqlDateTime;

                                return ozzzzzzzzzzzzzzzzzzzzzzzzzzk_;
                            };
                            bool ozzzzzzzzzzzzzzzzzzzzzzzzzzg_()
                            {
                                DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzl_ = O2Saturation?.Effective;
                                object ozzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                                bool ozzzzzzzzzzzzzzzzzzzzzzzzzzn_ = ozzzzzzzzzzzzzzzzzzzzzzzzzzm_ is CqlInterval<CqlDateTime>;

                                return ozzzzzzzzzzzzzzzzzzzzzzzzzzn_;
                            };
                            bool ozzzzzzzzzzzzzzzzzzzzzzzzzzh_()
                            {
                                DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzo_ = O2Saturation?.Effective;
                                object ozzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                                bool ozzzzzzzzzzzzzzzzzzzzzzzzzzq_ = ozzzzzzzzzzzzzzzzzzzzzzzzzzp_ is CqlDateTime;

                                return ozzzzzzzzzzzzzzzzzzzzzzzzzzq_;
                            };
                            if (ozzzzzzzzzzzzzzzzzzzzzzzzzzf_())
                            {
                                DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzr_ = O2Saturation?.Effective;
                                object ozzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzr_);

                                return (ozzzzzzzzzzzzzzzzzzzzzzzzzzs_ as CqlDateTime) as object;
                            }
                            else if (ozzzzzzzzzzzzzzzzzzzzzzzzzzg_())
                            {
                                DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzt_ = O2Saturation?.Effective;
                                object ozzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzt_);

                                return (ozzzzzzzzzzzzzzzzzzzzzzzzzzu_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (ozzzzzzzzzzzzzzzzzzzzzzzzzzh_())
                            {
                                DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzv_ = O2Saturation?.Effective;
                                object ozzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzv_);

                                return (ozzzzzzzzzzzzzzzzzzzzzzzzzzw_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.earliest(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzg_());
                        Period nzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = EncounterInpatient?.Period;
                        CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                        CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                        CqlQuantity nzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Quantity(1440m, "minutes");
                        CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Subtract(nzzzzzzzzzzzzzzzzzzzzzzzzzzk_, nzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                        CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                        CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                        CqlQuantity nzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Quantity(120m, "minutes");
                        CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Add(nzzzzzzzzzzzzzzzzzzzzzzzzzzp_, nzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                        CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Interval(nzzzzzzzzzzzzzzzzzzzzzzzzzzm_, nzzzzzzzzzzzzzzzzzzzzzzzzzzr_, true, true);
                        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.In<CqlDateTime>(nzzzzzzzzzzzzzzzzzzzzzzzzzzh_, nzzzzzzzzzzzzzzzzzzzzzzzzzzs_, default);
                        Code<ObservationStatus> nzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = O2Saturation?.StatusElement;
                        ObservationStatus? nzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzu_?.Value;
                        Code<ObservationStatus> nzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<Code<ObservationStatus>>(nzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                        string nzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<string>(nzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                        string[] nzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<string>(nzzzzzzzzzzzzzzzzzzzzzzzzzzx_, nzzzzzzzzzzzzzzzzzzzzzzzzzzy_ as IEnumerable<string>);
                        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzzzzt_, nzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                        DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzb_ = O2Saturation?.Value;
                        object ozzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Not((bool?)(ozzzzzzzzzzzzzzzzzzzzzzzzzzc_ is null));
                        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzzzza_, ozzzzzzzzzzzzzzzzzzzzzzzzzzd_);

                        return ozzzzzzzzzzzzzzzzzzzzzzzzzze_;
                    };
                    IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Observation>(mzzzzzzzzzzzzzzzzzzzzzzzzzzy_, mzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                    object nzzzzzzzzzzzzzzzzzzzzzzzzzzb_(Observation @this)
                    {
                        object ozzzzzzzzzzzzzzzzzzzzzzzzzzx_()
                        {
                            bool ozzzzzzzzzzzzzzzzzzzzzzzzzzz_()
                            {
                                DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = @this?.Effective;
                                object pzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                                bool pzzzzzzzzzzzzzzzzzzzzzzzzzze_ = pzzzzzzzzzzzzzzzzzzzzzzzzzzd_ is CqlDateTime;

                                return pzzzzzzzzzzzzzzzzzzzzzzzzzze_;
                            };
                            bool pzzzzzzzzzzzzzzzzzzzzzzzzzza_()
                            {
                                DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = @this?.Effective;
                                object pzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                                bool pzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = pzzzzzzzzzzzzzzzzzzzzzzzzzzg_ is CqlInterval<CqlDateTime>;

                                return pzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
                            };
                            bool pzzzzzzzzzzzzzzzzzzzzzzzzzzb_()
                            {
                                DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = @this?.Effective;
                                object pzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                                bool pzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = pzzzzzzzzzzzzzzzzzzzzzzzzzzj_ is CqlDateTime;

                                return pzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
                            };
                            if (ozzzzzzzzzzzzzzzzzzzzzzzzzzz_())
                            {
                                DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = @this?.Effective;
                                object pzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

                                return (pzzzzzzzzzzzzzzzzzzzzzzzzzzm_ as CqlDateTime) as object;
                            }
                            else if (pzzzzzzzzzzzzzzzzzzzzzzzzzza_())
                            {
                                DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = @this?.Effective;
                                object pzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

                                return (pzzzzzzzzzzzzzzzzzzzzzzzzzzo_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (pzzzzzzzzzzzzzzzzzzzzzzzzzzb_())
                            {
                                DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = @this?.Effective;
                                object pzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

                                return (pzzzzzzzzzzzzzzzzzzzzzzzzzzq_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.earliest(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzx_());

                        return ozzzzzzzzzzzzzzzzzzzzzzzzzzy_;
                    };
                    IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.SortBy<Observation>(nzzzzzzzzzzzzzzzzzzzzzzzzzza_, nzzzzzzzzzzzzzzzzzzzzzzzzzzb_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation nzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.First<Observation>(nzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                    DataType nzzzzzzzzzzzzzzzzzzzzzzzzzze_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzd_?.Effective;
                    object nzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzzzze_);

                    return (nzzzzzzzzzzzzzzzzzzzzzzzzzzf_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (bzzzzzzzzzzzzzzzzzzzzzzzzzzr_())
                {
                    CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
                    IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzt_(Observation O2Saturation)
                    {
                        object qzzzzzzzzzzzzzzzzzzzzzzzzzza_()
                        {
                            bool qzzzzzzzzzzzzzzzzzzzzzzzzzzz_()
                            {
                                DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = O2Saturation?.Effective;
                                object rzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                                bool rzzzzzzzzzzzzzzzzzzzzzzzzzze_ = rzzzzzzzzzzzzzzzzzzzzzzzzzzd_ is CqlDateTime;

                                return rzzzzzzzzzzzzzzzzzzzzzzzzzze_;
                            };
                            bool rzzzzzzzzzzzzzzzzzzzzzzzzzza_()
                            {
                                DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = O2Saturation?.Effective;
                                object rzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                                bool rzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = rzzzzzzzzzzzzzzzzzzzzzzzzzzg_ is CqlInterval<CqlDateTime>;

                                return rzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
                            };
                            bool rzzzzzzzzzzzzzzzzzzzzzzzzzzb_()
                            {
                                DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = O2Saturation?.Effective;
                                object rzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                                bool rzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = rzzzzzzzzzzzzzzzzzzzzzzzzzzj_ is CqlDateTime;

                                return rzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
                            };
                            if (qzzzzzzzzzzzzzzzzzzzzzzzzzzz_())
                            {
                                DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = O2Saturation?.Effective;
                                object rzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

                                return (rzzzzzzzzzzzzzzzzzzzzzzzzzzm_ as CqlDateTime) as object;
                            }
                            else if (rzzzzzzzzzzzzzzzzzzzzzzzzzza_())
                            {
                                DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = O2Saturation?.Effective;
                                object rzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

                                return (rzzzzzzzzzzzzzzzzzzzzzzzzzzo_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (rzzzzzzzzzzzzzzzzzzzzzzzzzzb_())
                            {
                                DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = O2Saturation?.Effective;
                                object rzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

                                return (rzzzzzzzzzzzzzzzzzzzzzzzzzzq_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.earliest(context, qzzzzzzzzzzzzzzzzzzzzzzzzzza_());
                        Period qzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = EncounterInpatient?.Period;
                        CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                        CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Start(qzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                        CqlQuantity qzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Quantity(1440m, "minutes");
                        CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Subtract(qzzzzzzzzzzzzzzzzzzzzzzzzzze_, qzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                        CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                        CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Start(qzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                        CqlQuantity qzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Quantity(120m, "minutes");
                        CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Add(qzzzzzzzzzzzzzzzzzzzzzzzzzzj_, qzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                        CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Interval(qzzzzzzzzzzzzzzzzzzzzzzzzzzg_, qzzzzzzzzzzzzzzzzzzzzzzzzzzl_, true, true);
                        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.In<CqlDateTime>(qzzzzzzzzzzzzzzzzzzzzzzzzzzb_, qzzzzzzzzzzzzzzzzzzzzzzzzzzm_, default);
                        Code<ObservationStatus> qzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = O2Saturation?.StatusElement;
                        ObservationStatus? qzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = qzzzzzzzzzzzzzzzzzzzzzzzzzzo_?.Value;
                        Code<ObservationStatus> qzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<Code<ObservationStatus>>(qzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                        string qzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Convert<string>(qzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                        string[] qzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.In<string>(qzzzzzzzzzzzzzzzzzzzzzzzzzzr_, qzzzzzzzzzzzzzzzzzzzzzzzzzzs_ as IEnumerable<string>);
                        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzzzzzn_, qzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                        DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = O2Saturation?.Value;
                        object qzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Not((bool?)(qzzzzzzzzzzzzzzzzzzzzzzzzzzw_ is null));
                        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzzzzzu_, qzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

                        return qzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
                    };
                    IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Observation>(pzzzzzzzzzzzzzzzzzzzzzzzzzzs_, pzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                    object pzzzzzzzzzzzzzzzzzzzzzzzzzzv_(Observation @this)
                    {
                        object rzzzzzzzzzzzzzzzzzzzzzzzzzzr_()
                        {
                            bool rzzzzzzzzzzzzzzzzzzzzzzzzzzt_()
                            {
                                DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = @this?.Effective;
                                object rzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                                bool rzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = rzzzzzzzzzzzzzzzzzzzzzzzzzzx_ is CqlDateTime;

                                return rzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
                            };
                            bool rzzzzzzzzzzzzzzzzzzzzzzzzzzu_()
                            {
                                DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = @this?.Effective;
                                object szzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                                bool szzzzzzzzzzzzzzzzzzzzzzzzzzb_ = szzzzzzzzzzzzzzzzzzzzzzzzzza_ is CqlInterval<CqlDateTime>;

                                return szzzzzzzzzzzzzzzzzzzzzzzzzzb_;
                            };
                            bool rzzzzzzzzzzzzzzzzzzzzzzzzzzv_()
                            {
                                DataType szzzzzzzzzzzzzzzzzzzzzzzzzzc_ = @this?.Effective;
                                object szzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                                bool szzzzzzzzzzzzzzzzzzzzzzzzzze_ = szzzzzzzzzzzzzzzzzzzzzzzzzzd_ is CqlDateTime;

                                return szzzzzzzzzzzzzzzzzzzzzzzzzze_;
                            };
                            if (rzzzzzzzzzzzzzzzzzzzzzzzzzzt_())
                            {
                                DataType szzzzzzzzzzzzzzzzzzzzzzzzzzf_ = @this?.Effective;
                                object szzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzzzzf_);

                                return (szzzzzzzzzzzzzzzzzzzzzzzzzzg_ as CqlDateTime) as object;
                            }
                            else if (rzzzzzzzzzzzzzzzzzzzzzzzzzzu_())
                            {
                                DataType szzzzzzzzzzzzzzzzzzzzzzzzzzh_ = @this?.Effective;
                                object szzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzzzzh_);

                                return (szzzzzzzzzzzzzzzzzzzzzzzzzzi_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (rzzzzzzzzzzzzzzzzzzzzzzzzzzv_())
                            {
                                DataType szzzzzzzzzzzzzzzzzzzzzzzzzzj_ = @this?.Effective;
                                object szzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzzzzj_);

                                return (szzzzzzzzzzzzzzzzzzzzzzzzzzk_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.earliest(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzr_());

                        return rzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
                    };
                    IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.SortBy<Observation>(pzzzzzzzzzzzzzzzzzzzzzzzzzzu_, pzzzzzzzzzzzzzzzzzzzzzzzzzzv_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation pzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.First<Observation>(pzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                    DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = pzzzzzzzzzzzzzzzzzzzzzzzzzzx_?.Effective;
                    object pzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

                    return (pzzzzzzzzzzzzzzzzzzzzzzzzzzz_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.earliest(context, zzzzzzzzzzzzzzzzzzzzzzzzzzb_());
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)? zzzzzzzzzzzzzzzzzzzzzzzzzzd_ = (CqlTupleMetadata_FdREYEdHOZIcMCNYCRFJYJReA, yzzzzzzzzzzzzzzzzzzzzzzzzzr_, zzzzzzzzzzzzzzzzzzzzzzzzzza_ as CqlQuantity, zzzzzzzzzzzzzzzzzzzzzzzzzzc_);

            return zzzzzzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)?> yzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)?>(yzzzzzzzzzzzzzzzzzzzzzzzzzm_, yzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)?> yzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)?>(yzzzzzzzzzzzzzzzzzzzzzzzzzo_);

        return yzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Encounter with First Bicarbonate Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)?> Encounter_with_First_Bicarbonate_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)? szzzzzzzzzzzzzzzzzzzzzzzzzzm_(Encounter EncounterInpatient)
        {
            Id szzzzzzzzzzzzzzzzzzzzzzzzzzp_ = EncounterInpatient?.IdElement;
            string szzzzzzzzzzzzzzzzzzzzzzzzzzq_ = szzzzzzzzzzzzzzzzzzzzzzzzzzp_?.Value;
            CqlValueSet szzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Bicarbonate_lab_test(context);
            IEnumerable<Observation> szzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzt_(Observation BicarbonateLab)
            {
                Instant tzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = BicarbonateLab?.IssuedElement;
                DateTimeOffset? tzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = tzzzzzzzzzzzzzzzzzzzzzzzzzzl_?.Value;
                CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Convert<CqlDateTime>(tzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.earliest(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzn_ as object);
                Period tzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlQuantity tzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Subtract(tzzzzzzzzzzzzzzzzzzzzzzzzzzr_, tzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Add(tzzzzzzzzzzzzzzzzzzzzzzzzzzw_, tzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Interval(tzzzzzzzzzzzzzzzzzzzzzzzzzzt_, tzzzzzzzzzzzzzzzzzzzzzzzzzzy_, true, true);
                bool? uzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(tzzzzzzzzzzzzzzzzzzzzzzzzzzo_, tzzzzzzzzzzzzzzzzzzzzzzzzzzz_, default);
                Code<ObservationStatus> uzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = BicarbonateLab?.StatusElement;
                ObservationStatus? uzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = uzzzzzzzzzzzzzzzzzzzzzzzzzzb_?.Value;
                string uzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Convert<string>(uzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                string[] uzzzzzzzzzzzzzzzzzzzzzzzzzze_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.In<string>(uzzzzzzzzzzzzzzzzzzzzzzzzzzd_, uzzzzzzzzzzzzzzzzzzzzzzzzzze_ as IEnumerable<string>);
                bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzzzzzzzza_, uzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                DataType uzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = BicarbonateLab?.Value;
                object uzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Not((bool?)(uzzzzzzzzzzzzzzzzzzzzzzzzzzi_ is null));
                bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzzzzzzzzg_, uzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

                return uzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
            };
            IEnumerable<Observation> szzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Observation>(szzzzzzzzzzzzzzzzzzzzzzzzzzs_, szzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            object szzzzzzzzzzzzzzzzzzzzzzzzzzv_(Observation @this)
            {
                Instant uzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = @this?.IssuedElement;
                DateTimeOffset? uzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = uzzzzzzzzzzzzzzzzzzzzzzzzzzl_?.Value;
                CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Convert<CqlDateTime>(uzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.earliest(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzn_ as object);

                return uzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<Observation> szzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.SortBy<Observation>(szzzzzzzzzzzzzzzzzzzzzzzzzzu_, szzzzzzzzzzzzzzzzzzzzzzzzzzv_, System.ComponentModel.ListSortDirection.Ascending);
            Observation szzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.First<Observation>(szzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            DataType szzzzzzzzzzzzzzzzzzzzzzzzzzy_ = szzzzzzzzzzzzzzzzzzzzzzzzzzx_?.Value;
            object szzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            IEnumerable<Observation> tzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzc_(Observation BicarbonateLab)
            {
                Instant uzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = BicarbonateLab?.IssuedElement;
                DateTimeOffset? uzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = uzzzzzzzzzzzzzzzzzzzzzzzzzzp_?.Value;
                CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Convert<CqlDateTime>(uzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.earliest(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzr_ as object);
                Period uzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Start(uzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlQuantity uzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Subtract(uzzzzzzzzzzzzzzzzzzzzzzzzzzv_, uzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Start(uzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Add(vzzzzzzzzzzzzzzzzzzzzzzzzzza_, uzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Interval(uzzzzzzzzzzzzzzzzzzzzzzzzzzx_, vzzzzzzzzzzzzzzzzzzzzzzzzzzc_, true, true);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.In<CqlDateTime>(uzzzzzzzzzzzzzzzzzzzzzzzzzzs_, vzzzzzzzzzzzzzzzzzzzzzzzzzzd_, default);
                Code<ObservationStatus> vzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = BicarbonateLab?.StatusElement;
                ObservationStatus? vzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = vzzzzzzzzzzzzzzzzzzzzzzzzzzf_?.Value;
                string vzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Convert<string>(vzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                string[] vzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.In<string>(vzzzzzzzzzzzzzzzzzzzzzzzzzzh_, vzzzzzzzzzzzzzzzzzzzzzzzzzzi_ as IEnumerable<string>);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzzzzzzze_, vzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                DataType vzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = BicarbonateLab?.Value;
                object vzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Not((bool?)(vzzzzzzzzzzzzzzzzzzzzzzzzzzm_ is null));
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzzzzzzzk_, vzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

                return vzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<Observation> tzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Observation>(tzzzzzzzzzzzzzzzzzzzzzzzzzzb_, tzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            object tzzzzzzzzzzzzzzzzzzzzzzzzzze_(Observation @this)
            {
                Instant vzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = @this?.IssuedElement;
                DateTimeOffset? vzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = vzzzzzzzzzzzzzzzzzzzzzzzzzzp_?.Value;
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Convert<CqlDateTime>(vzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.earliest(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzr_ as object);

                return vzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<Observation> tzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.SortBy<Observation>(tzzzzzzzzzzzzzzzzzzzzzzzzzzd_, tzzzzzzzzzzzzzzzzzzzzzzzzzze_, System.ComponentModel.ListSortDirection.Ascending);
            Observation tzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.First<Observation>(tzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            Instant tzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = tzzzzzzzzzzzzzzzzzzzzzzzzzzg_?.IssuedElement;
            DateTimeOffset? tzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = tzzzzzzzzzzzzzzzzzzzzzzzzzzh_?.Value;
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Convert<CqlDateTime>(tzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)? tzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = (CqlTupleMetadata_GbUHPXXHScejjXWhcHJFQQifQ, szzzzzzzzzzzzzzzzzzzzzzzzzzq_, szzzzzzzzzzzzzzzzzzzzzzzzzzz_ as CqlQuantity, tzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

            return tzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)?> szzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)?>(szzzzzzzzzzzzzzzzzzzzzzzzzzl_, szzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)?> szzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)?>(szzzzzzzzzzzzzzzzzzzzzzzzzzn_);

        return szzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Encounter with First Creatinine Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)?> Encounter_with_First_Creatinine_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)? vzzzzzzzzzzzzzzzzzzzzzzzzzzu_(Encounter EncounterInpatient)
        {
            Id vzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = EncounterInpatient?.IdElement;
            string vzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = vzzzzzzzzzzzzzzzzzzzzzzzzzzx_?.Value;
            CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Creatinine_lab_test(context);
            IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzb_(Observation CreatinineLab)
            {
                Instant wzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = CreatinineLab?.IssuedElement;
                DateTimeOffset? wzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = wzzzzzzzzzzzzzzzzzzzzzzzzzzt_?.Value;
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Convert<CqlDateTime>(wzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.earliest(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzv_ as object);
                Period wzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Start(wzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlQuantity xzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Subtract(wzzzzzzzzzzzzzzzzzzzzzzzzzzz_, xzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Add(xzzzzzzzzzzzzzzzzzzzzzzzzzze_, xzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Interval(xzzzzzzzzzzzzzzzzzzzzzzzzzzb_, xzzzzzzzzzzzzzzzzzzzzzzzzzzg_, true, true);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.In<CqlDateTime>(wzzzzzzzzzzzzzzzzzzzzzzzzzzw_, xzzzzzzzzzzzzzzzzzzzzzzzzzzh_, default);
                Code<ObservationStatus> xzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = CreatinineLab?.StatusElement;
                ObservationStatus? xzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = xzzzzzzzzzzzzzzzzzzzzzzzzzzj_?.Value;
                string xzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<string>(xzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                string[] xzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.In<string>(xzzzzzzzzzzzzzzzzzzzzzzzzzzl_, xzzzzzzzzzzzzzzzzzzzzzzzzzzm_ as IEnumerable<string>);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzzzzzzi_, xzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                DataType xzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = CreatinineLab?.Value;
                object xzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Not((bool?)(xzzzzzzzzzzzzzzzzzzzzzzzzzzq_ is null));
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzzzzzzo_, xzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

                return xzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Observation>(wzzzzzzzzzzzzzzzzzzzzzzzzzza_, wzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            object wzzzzzzzzzzzzzzzzzzzzzzzzzzd_(Observation @this)
            {
                Instant xzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = @this?.IssuedElement;
                DateTimeOffset? xzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = xzzzzzzzzzzzzzzzzzzzzzzzzzzt_?.Value;
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Convert<CqlDateTime>(xzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.earliest(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzv_ as object);

                return xzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.SortBy<Observation>(wzzzzzzzzzzzzzzzzzzzzzzzzzzc_, wzzzzzzzzzzzzzzzzzzzzzzzzzzd_, System.ComponentModel.ListSortDirection.Ascending);
            Observation wzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.First<Observation>(wzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            DataType wzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = wzzzzzzzzzzzzzzzzzzzzzzzzzzf_?.Value;
            object wzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Observation CreatinineLab)
            {
                Instant xzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = CreatinineLab?.IssuedElement;
                DateTimeOffset? xzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = xzzzzzzzzzzzzzzzzzzzzzzzzzzx_?.Value;
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Convert<CqlDateTime>(xzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.earliest(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzz_ as object);
                Period yzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlQuantity yzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Subtract(yzzzzzzzzzzzzzzzzzzzzzzzzzzd_, yzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Add(yzzzzzzzzzzzzzzzzzzzzzzzzzzi_, yzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Interval(yzzzzzzzzzzzzzzzzzzzzzzzzzzf_, yzzzzzzzzzzzzzzzzzzzzzzzzzzk_, true, true);
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.In<CqlDateTime>(yzzzzzzzzzzzzzzzzzzzzzzzzzza_, yzzzzzzzzzzzzzzzzzzzzzzzzzzl_, default);
                Code<ObservationStatus> yzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = CreatinineLab?.StatusElement;
                ObservationStatus? yzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = yzzzzzzzzzzzzzzzzzzzzzzzzzzn_?.Value;
                string yzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Convert<string>(yzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                string[] yzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.In<string>(yzzzzzzzzzzzzzzzzzzzzzzzzzzp_, yzzzzzzzzzzzzzzzzzzzzzzzzzzq_ as IEnumerable<string>);
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzzzzzzzzm_, yzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = CreatinineLab?.Value;
                object yzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Not((bool?)(yzzzzzzzzzzzzzzzzzzzzzzzzzzu_ is null));
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzzzzzzzzs_, yzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

                return yzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Observation>(wzzzzzzzzzzzzzzzzzzzzzzzzzzj_, wzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            object wzzzzzzzzzzzzzzzzzzzzzzzzzzm_(Observation @this)
            {
                Instant yzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = @this?.IssuedElement;
                DateTimeOffset? yzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = yzzzzzzzzzzzzzzzzzzzzzzzzzzx_?.Value;
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Convert<CqlDateTime>(yzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.earliest(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzz_ as object);

                return zzzzzzzzzzzzzzzzzzzzzzzzzzza_;
            };
            IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.SortBy<Observation>(wzzzzzzzzzzzzzzzzzzzzzzzzzzl_, wzzzzzzzzzzzzzzzzzzzzzzzzzzm_, System.ComponentModel.ListSortDirection.Ascending);
            Observation wzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.First<Observation>(wzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            Instant wzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = wzzzzzzzzzzzzzzzzzzzzzzzzzzo_?.IssuedElement;
            DateTimeOffset? wzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = wzzzzzzzzzzzzzzzzzzzzzzzzzzp_?.Value;
            CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Convert<CqlDateTime>(wzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)? wzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = (CqlTupleMetadata_FETECNQPQREfGRgPYWhOWgeWA, vzzzzzzzzzzzzzzzzzzzzzzzzzzy_, wzzzzzzzzzzzzzzzzzzzzzzzzzzh_ as CqlQuantity, wzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

            return wzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)?> vzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)?>(vzzzzzzzzzzzzzzzzzzzzzzzzzzt_, vzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)?> vzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)?>(vzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

        return vzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Encounter with First Hematocrit Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?> Encounter_with_First_Hematocrit_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)? zzzzzzzzzzzzzzzzzzzzzzzzzzzc_(Encounter EncounterInpatient)
        {
            Id zzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = EncounterInpatient?.IdElement;
            string zzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = zzzzzzzzzzzzzzzzzzzzzzzzzzzf_?.Value;
            CqlValueSet zzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Hematocrit_lab_test(context);
            IEnumerable<Observation> zzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzj_(Observation HematocritLab)
            {
                Instant azzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = HematocritLab?.IssuedElement;
                DateTimeOffset? azzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = azzzzzzzzzzzzzzzzzzzzzzzzzzzb_?.Value;
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Convert<CqlDateTime>(azzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.earliest(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzd_ as object);
                Period azzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Start(azzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlQuantity azzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Subtract(azzzzzzzzzzzzzzzzzzzzzzzzzzzh_, azzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(azzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Add(azzzzzzzzzzzzzzzzzzzzzzzzzzzm_, azzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Interval(azzzzzzzzzzzzzzzzzzzzzzzzzzzj_, azzzzzzzzzzzzzzzzzzzzzzzzzzzo_, true, true);
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.In<CqlDateTime>(azzzzzzzzzzzzzzzzzzzzzzzzzzze_, azzzzzzzzzzzzzzzzzzzzzzzzzzzp_, default);
                Code<ObservationStatus> azzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = HematocritLab?.StatusElement;
                ObservationStatus? azzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = azzzzzzzzzzzzzzzzzzzzzzzzzzzr_?.Value;
                string azzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Convert<string>(azzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                string[] azzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.In<string>(azzzzzzzzzzzzzzzzzzzzzzzzzzzt_, azzzzzzzzzzzzzzzzzzzzzzzzzzzu_ as IEnumerable<string>);
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzzzzzzzzzq_, azzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                DataType azzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = HematocritLab?.Value;
                object azzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Not((bool?)(azzzzzzzzzzzzzzzzzzzzzzzzzzzy_ is null));
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzzzzzzzzzw_, azzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

                return bzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
            };
            IEnumerable<Observation> zzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Observation>(zzzzzzzzzzzzzzzzzzzzzzzzzzzi_, zzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            object zzzzzzzzzzzzzzzzzzzzzzzzzzzl_(Observation @this)
            {
                Instant bzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = @this?.IssuedElement;
                DateTimeOffset? bzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzb_?.Value;
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Convert<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.earliest(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ as object);

                return bzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<Observation> zzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.SortBy<Observation>(zzzzzzzzzzzzzzzzzzzzzzzzzzzk_, zzzzzzzzzzzzzzzzzzzzzzzzzzzl_, System.ComponentModel.ListSortDirection.Ascending);
            Observation zzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.First<Observation>(zzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            DataType zzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = zzzzzzzzzzzzzzzzzzzzzzzzzzzn_?.Value;
            object zzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            IEnumerable<Observation> zzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzs_(Observation HematocritLab)
            {
                Instant bzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = HematocritLab?.IssuedElement;
                DateTimeOffset? bzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzf_?.Value;
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Convert<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.earliest(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ as object);
                Period bzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlQuantity bzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Subtract(bzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Add(bzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Interval(bzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, true, true);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, default);
                Code<ObservationStatus> bzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = HematocritLab?.StatusElement;
                ObservationStatus? bzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzv_?.Value;
                string bzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<string>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                string[] bzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<string>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ as IEnumerable<string>);
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                DataType czzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = HematocritLab?.Value;
                object czzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Not((bool?)(czzzzzzzzzzzzzzzzzzzzzzzzzzzc_ is null));
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzzzzzzzza_, czzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

                return czzzzzzzzzzzzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<Observation> zzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Observation>(zzzzzzzzzzzzzzzzzzzzzzzzzzzr_, zzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            object zzzzzzzzzzzzzzzzzzzzzzzzzzzu_(Observation @this)
            {
                Instant czzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = @this?.IssuedElement;
                DateTimeOffset? czzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = czzzzzzzzzzzzzzzzzzzzzzzzzzzf_?.Value;
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Convert<CqlDateTime>(czzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.earliest(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzh_ as object);

                return czzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<Observation> zzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.SortBy<Observation>(zzzzzzzzzzzzzzzzzzzzzzzzzzzt_, zzzzzzzzzzzzzzzzzzzzzzzzzzzu_, System.ComponentModel.ListSortDirection.Ascending);
            Observation zzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.First<Observation>(zzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            Instant zzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = zzzzzzzzzzzzzzzzzzzzzzzzzzzw_?.IssuedElement;
            DateTimeOffset? zzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = zzzzzzzzzzzzzzzzzzzzzzzzzzzx_?.Value;
            CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Convert<CqlDateTime>(zzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)? azzzzzzzzzzzzzzzzzzzzzzzzzzza_ = (CqlTupleMetadata_DIHdhbAJeJTdiAVUAELUHRNdS, zzzzzzzzzzzzzzzzzzzzzzzzzzzg_, zzzzzzzzzzzzzzzzzzzzzzzzzzzp_ as CqlQuantity, zzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

            return azzzzzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?> zzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?>(zzzzzzzzzzzzzzzzzzzzzzzzzzzb_, zzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?> zzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?>(zzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Encounter with First Platelet Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)?> Encounter_with_First_Platelet_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)? czzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Encounter EncounterInpatient)
        {
            Id czzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = EncounterInpatient?.IdElement;
            string czzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = czzzzzzzzzzzzzzzzzzzzzzzzzzzn_?.Value;
            CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Platelet_count_lab_test(context);
            IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzr_(Observation PlateletLab)
            {
                Instant dzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = PlateletLab?.IssuedElement;
                DateTimeOffset? dzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = dzzzzzzzzzzzzzzzzzzzzzzzzzzzj_?.Value;
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.earliest(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ as object);
                Period dzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(dzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlQuantity dzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Subtract(dzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(dzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Add(dzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Interval(dzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, true, true);
                bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, default);
                Code<ObservationStatus> dzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = PlateletLab?.StatusElement;
                ObservationStatus? ezzzzzzzzzzzzzzzzzzzzzzzzzzza_ = dzzzzzzzzzzzzzzzzzzzzzzzzzzzz_?.Value;
                string ezzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Convert<string>(ezzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                string[] ezzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<string>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzb_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzc_ as IEnumerable<string>);
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                DataType ezzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = PlateletLab?.Value;
                object ezzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Not((bool?)(ezzzzzzzzzzzzzzzzzzzzzzzzzzzg_ is null));
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(ezzzzzzzzzzzzzzzzzzzzzzzzzzze_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

                return ezzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Observation>(czzzzzzzzzzzzzzzzzzzzzzzzzzzq_, czzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            object czzzzzzzzzzzzzzzzzzzzzzzzzzzt_(Observation @this)
            {
                Instant ezzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = @this?.IssuedElement;
                DateTimeOffset? ezzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = ezzzzzzzzzzzzzzzzzzzzzzzzzzzj_?.Value;
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<CqlDateTime>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.earliest(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzl_ as object);

                return ezzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
            };
            IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.SortBy<Observation>(czzzzzzzzzzzzzzzzzzzzzzzzzzzs_, czzzzzzzzzzzzzzzzzzzzzzzzzzzt_, System.ComponentModel.ListSortDirection.Ascending);
            Observation czzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.First<Observation>(czzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            DataType czzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = czzzzzzzzzzzzzzzzzzzzzzzzzzzv_?.Value;
            object czzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzza_(Observation PlateletLab)
            {
                Instant ezzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = PlateletLab?.IssuedElement;
                DateTimeOffset? ezzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = ezzzzzzzzzzzzzzzzzzzzzzzzzzzn_?.Value;
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Convert<CqlDateTime>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.earliest(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzp_ as object);
                Period ezzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlQuantity ezzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Subtract(ezzzzzzzzzzzzzzzzzzzzzzzzzzzt_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Add(ezzzzzzzzzzzzzzzzzzzzzzzzzzzy_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Interval(ezzzzzzzzzzzzzzzzzzzzzzzzzzzv_, fzzzzzzzzzzzzzzzzzzzzzzzzzzza_, true, true);
                bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.In<CqlDateTime>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzq_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, default);
                Code<ObservationStatus> fzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = PlateletLab?.StatusElement;
                ObservationStatus? fzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = fzzzzzzzzzzzzzzzzzzzzzzzzzzzd_?.Value;
                string fzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<string>(fzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                string[] fzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.In<string>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ as IEnumerable<string>);
                bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                DataType fzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = PlateletLab?.Value;
                object fzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Not((bool?)(fzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ is null));
                bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

                return fzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
            };
            IEnumerable<Observation> dzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Observation>(czzzzzzzzzzzzzzzzzzzzzzzzzzzz_, dzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            object dzzzzzzzzzzzzzzzzzzzzzzzzzzzc_(Observation @this)
            {
                Instant fzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = @this?.IssuedElement;
                DateTimeOffset? fzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = fzzzzzzzzzzzzzzzzzzzzzzzzzzzn_?.Value;
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Convert<CqlDateTime>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.earliest(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ as object);

                return fzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
            };
            IEnumerable<Observation> dzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.SortBy<Observation>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, System.ComponentModel.ListSortDirection.Ascending);
            Observation dzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.First<Observation>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            Instant dzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = dzzzzzzzzzzzzzzzzzzzzzzzzzzze_?.IssuedElement;
            DateTimeOffset? dzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = dzzzzzzzzzzzzzzzzzzzzzzzzzzzf_?.Value;
            CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Convert<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)? dzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = (CqlTupleMetadata_DAUcYHQZcDKbIfORJOEZBDgIh, czzzzzzzzzzzzzzzzzzzzzzzzzzzo_, czzzzzzzzzzzzzzzzzzzzzzzzzzzx_ as CqlQuantity, dzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

            return dzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)?> czzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)?>(czzzzzzzzzzzzzzzzzzzzzzzzzzzj_, czzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)?> czzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)?>(czzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

        return czzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Encounter with First Sodium Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)?> Encounter_with_First_Sodium_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)? fzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(Encounter EncounterInpatient)
        {
            Id fzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = EncounterInpatient?.IdElement;
            string fzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = fzzzzzzzzzzzzzzzzzzzzzzzzzzzv_?.Value;
            CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Sodium_lab_test(context);
            IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzz_(Observation SodiumLab)
            {
                Instant gzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = SodiumLab?.IssuedElement;
                DateTimeOffset? gzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = gzzzzzzzzzzzzzzzzzzzzzzzzzzzr_?.Value;
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Convert<CqlDateTime>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.earliest(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ as object);
                Period gzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlQuantity gzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Subtract(gzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(hzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Add(hzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Interval(gzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, hzzzzzzzzzzzzzzzzzzzzzzzzzzze_, true, true);
                bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.In<CqlDateTime>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, default);
                Code<ObservationStatus> hzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = SodiumLab?.StatusElement;
                ObservationStatus? hzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = hzzzzzzzzzzzzzzzzzzzzzzzzzzzh_?.Value;
                string hzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Convert<string>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                string[] hzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.In<string>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ as IEnumerable<string>);
                bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                DataType hzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = SodiumLab?.Value;
                object hzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Not((bool?)(hzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ is null));
                bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

                return hzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
            };
            IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Observation>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            object gzzzzzzzzzzzzzzzzzzzzzzzzzzzb_(Observation @this)
            {
                Instant hzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = @this?.IssuedElement;
                DateTimeOffset? hzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = hzzzzzzzzzzzzzzzzzzzzzzzzzzzr_?.Value;
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Convert<CqlDateTime>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.earliest(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ as object);

                return hzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
            };
            IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.SortBy<Observation>(gzzzzzzzzzzzzzzzzzzzzzzzzzzza_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, System.ComponentModel.ListSortDirection.Ascending);
            Observation gzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.First<Observation>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = gzzzzzzzzzzzzzzzzzzzzzzzzzzzd_?.Value;
            object gzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Observation SodiumLab)
            {
                Instant hzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = SodiumLab?.IssuedElement;
                DateTimeOffset? hzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = hzzzzzzzzzzzzzzzzzzzzzzzzzzzv_?.Value;
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<CqlDateTime>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.earliest(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ as object);
                Period hzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(izzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlQuantity izzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Subtract(izzzzzzzzzzzzzzzzzzzzzzzzzzzb_, izzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(izzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Add(izzzzzzzzzzzzzzzzzzzzzzzzzzzg_, izzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Interval(izzzzzzzzzzzzzzzzzzzzzzzzzzzd_, izzzzzzzzzzzzzzzzzzzzzzzzzzzi_, true, true);
                bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.In<CqlDateTime>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, izzzzzzzzzzzzzzzzzzzzzzzzzzzj_, default);
                Code<ObservationStatus> izzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = SodiumLab?.StatusElement;
                ObservationStatus? izzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzl_?.Value;
                string izzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Convert<string>(izzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                string[] izzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.In<string>(izzzzzzzzzzzzzzzzzzzzzzzzzzzn_, izzzzzzzzzzzzzzzzzzzzzzzzzzzo_ as IEnumerable<string>);
                bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzzzzzzk_, izzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = SodiumLab?.Value;
                object izzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Not((bool?)(izzzzzzzzzzzzzzzzzzzzzzzzzzzs_ is null));
                bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzzzzzzq_, izzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

                return izzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
            };
            IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Observation>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            object gzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Observation @this)
            {
                Instant izzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = @this?.IssuedElement;
                DateTimeOffset? izzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzv_?.Value;
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<CqlDateTime>(izzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.earliest(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzx_ as object);

                return izzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
            };
            IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.SortBy<Observation>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, System.ComponentModel.ListSortDirection.Ascending);
            Observation gzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.First<Observation>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            Instant gzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = gzzzzzzzzzzzzzzzzzzzzzzzzzzzm_?.IssuedElement;
            DateTimeOffset? gzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = gzzzzzzzzzzzzzzzzzzzzzzzzzzzn_?.Value;
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Convert<CqlDateTime>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)? gzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = (CqlTupleMetadata_GKGeLARADLGJcNcZaDhdCREMa, fzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ as CqlQuantity, gzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

            return gzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)?> fzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)?>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)?> fzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)?>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

        return fzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Qualifying Blood Pressure Reading")]
    public IEnumerable<Observation> Qualifying_Blood_Pressure_Reading(CqlContext context)
    {
        IEnumerable<Observation> izzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bp"));
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzza_(Observation BPReading)
        {
            DataType jzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = BPReading?.Effective;
            object jzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.earliest(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Measurement_Period(context);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzzzzzzzzzzzzzzzzzzze_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, "day");
            Code<ObservationStatus> jzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = BPReading?.StatusElement;
            ObservationStatus? jzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzh_?.Value;
            string jzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Convert<string>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            string[] jzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.In<string>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ as IEnumerable<string>);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

            return jzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Observation>(izzzzzzzzzzzzzzzzzzzzzzzzzzzz_, jzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

        return jzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Test2")]
    public CqlQuantity Test2(CqlContext context)
    {
        IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Qualifying_Blood_Pressure_Reading(context);
        IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Observation SBPReading)
        {
            IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Inpatient_Encounters(context);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzw_(Encounter EncounterInpatient)
            {
                DataType kzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = SBPReading?.Effective;
                object kzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.earliest(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                Period kzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlQuantity kzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Subtract(kzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlQuantity kzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Add(kzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Interval(kzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, true, true);
                bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.In<CqlDateTime>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, default);

                return kzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Encounter>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            Observation jzzzzzzzzzzzzzzzzzzzzzzzzzzzy_(Encounter EncounterInpatient) =>
                SBPReading;
            IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Select<Encounter, Observation>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

            return jzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.SelectMany<Observation, Observation>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        CqlQuantity jzzzzzzzzzzzzzzzzzzzzzzzzzzzq_(Observation SBPReading)
        {
            List<Observation.ComponentComponent> kzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = SBPReading?.Component;
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzq_(Observation.ComponentComponent SBPComponent)
            {
                CodeableConcept kzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = SBPComponent?.Code;
                CqlConcept kzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlCode kzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Systolic_blood_pressure(context);
                CqlConcept kzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.ConvertCodeToConcept(kzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Equivalent(kzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

                return lzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
            };
            IEnumerable<Observation.ComponentComponent> kzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)kzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlQuantity kzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(Observation.ComponentComponent SBPComponent)
            {
                DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = SBPComponent?.Value;
                object lzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

                return lzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ as CqlQuantity;
            };
            IEnumerable<CqlQuantity> kzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Select<Observation.ComponentComponent, CqlQuantity>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            IEnumerable<CqlQuantity> kzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Distinct<CqlQuantity>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlQuantity kzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.SingletonFrom<CqlQuantity>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

            return kzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<CqlQuantity> jzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Select<Observation, CqlQuantity>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<CqlQuantity> jzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Distinct<CqlQuantity>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<CqlQuantity> jzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.ListSort<CqlQuantity>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, System.ComponentModel.ListSortDirection.Ascending);
        CqlQuantity jzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.First<CqlQuantity>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

        return jzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Encounter with First White Blood Cells Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)?> Encounter_with_First_White_Blood_Cells_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> lzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)? lzzzzzzzzzzzzzzzzzzzzzzzzzzze_(Encounter EncounterInpatient)
        {
            Id lzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = EncounterInpatient?.IdElement;
            string lzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzzh_?.Value;
            CqlValueSet lzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.White_blood_cells_count_lab_test(context);
            IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzl_(Observation WhiteBloodCellLab)
            {
                Instant mzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = WhiteBloodCellLab?.IssuedElement;
                DateTimeOffset? mzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = mzzzzzzzzzzzzzzzzzzzzzzzzzzzd_?.Value;
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<CqlDateTime>(mzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.earliest(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ as object);
                Period mzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlQuantity mzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Subtract(mzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Add(mzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Interval(mzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, true, true);
                bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.In<CqlDateTime>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, default);
                Code<ObservationStatus> mzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = WhiteBloodCellLab?.StatusElement;
                ObservationStatus? mzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = mzzzzzzzzzzzzzzzzzzzzzzzzzzzt_?.Value;
                string mzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Convert<string>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                string[] mzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.In<string>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ as IEnumerable<string>);
                bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = WhiteBloodCellLab?.Value;
                object nzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Not((bool?)(nzzzzzzzzzzzzzzzzzzzzzzzzzzza_ is null));
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

                return nzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Observation>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            object lzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(Observation @this)
            {
                Instant nzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = @this?.IssuedElement;
                DateTimeOffset? nzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzzd_?.Value;
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<CqlDateTime>(nzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.earliest(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ as object);

                return nzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.SortBy<Observation>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, System.ComponentModel.ListSortDirection.Ascending);
            Observation lzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.First<Observation>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzzp_?.Value;
            object lzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzu_(Observation WhiteBloodCellLab)
            {
                Instant nzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = WhiteBloodCellLab?.IssuedElement;
                DateTimeOffset? nzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzzh_?.Value;
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Convert<CqlDateTime>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.earliest(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ as object);
                Period nzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlQuantity nzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Subtract(nzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Add(nzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Interval(nzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, true, true);
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.In<CqlDateTime>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, default);
                Code<ObservationStatus> nzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = WhiteBloodCellLab?.StatusElement;
                ObservationStatus? nzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzzx_?.Value;
                string nzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Convert<string>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                string[] ozzzzzzzzzzzzzzzzzzzzzzzzzzza_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.In<string>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, ozzzzzzzzzzzzzzzzzzzzzzzzzzza_ as IEnumerable<string>);
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = WhiteBloodCellLab?.Value;
                object ozzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Not((bool?)(ozzzzzzzzzzzzzzzzzzzzzzzzzzze_ is null));
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzzzzzc_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

                return ozzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Observation>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            object lzzzzzzzzzzzzzzzzzzzzzzzzzzzw_(Observation @this)
            {
                Instant ozzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = @this?.IssuedElement;
                DateTimeOffset? ozzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = ozzzzzzzzzzzzzzzzzzzzzzzzzzzh_?.Value;
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Convert<CqlDateTime>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.earliest(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzj_ as object);

                return ozzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
            };
            IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.SortBy<Observation>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, System.ComponentModel.ListSortDirection.Ascending);
            Observation lzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.First<Observation>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            Instant lzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzzy_?.IssuedElement;
            DateTimeOffset? mzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzzz_?.Value;
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Convert<CqlDateTime>(mzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)? mzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = (CqlTupleMetadata_ChVYCdXDGgVcFTCCUefXMbCHX, lzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ as CqlQuantity, mzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

            return mzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)?> lzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)?>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, lzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)?> lzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)?>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

        return lzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? ozzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> ozzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? ozzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode ozzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
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
