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

    #region ValueSet: Bicarbonate lab test
    [CqlValueSetDefinition(
        definitionName: "Bicarbonate lab test",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.139",
        valueSetVersion: null)]
    public CqlValueSet Bicarbonate_lab_test(CqlContext context) => _Bicarbonate_lab_test;

    private static readonly CqlValueSet _Bicarbonate_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.139", null);
    #endregion

    #region ValueSet: Creatinine lab test
    [CqlValueSetDefinition(
        definitionName: "Creatinine lab test",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.2363",
        valueSetVersion: null)]
    public CqlValueSet Creatinine_lab_test(CqlContext context) => _Creatinine_lab_test;

    private static readonly CqlValueSet _Creatinine_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.2363", null);
    #endregion

    #region ValueSet: Encounter Inpatient
    [CqlValueSetDefinition(
        definitionName: "Encounter Inpatient",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307",
        valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext context) => _Encounter_Inpatient;

    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);
    #endregion

    #region ValueSet: Hematocrit lab test
    [CqlValueSetDefinition(
        definitionName: "Hematocrit lab test",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.114",
        valueSetVersion: null)]
    public CqlValueSet Hematocrit_lab_test(CqlContext context) => _Hematocrit_lab_test;

    private static readonly CqlValueSet _Hematocrit_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.114", null);
    #endregion

    #region ValueSet: Medicare Advantage payer
    [CqlValueSetDefinition(
        definitionName: "Medicare Advantage payer",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1104.12",
        valueSetVersion: null)]
    public CqlValueSet Medicare_Advantage_payer(CqlContext context) => _Medicare_Advantage_payer;

    private static readonly CqlValueSet _Medicare_Advantage_payer = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1104.12", null);
    #endregion

    #region ValueSet: Medicare FFS payer
    [CqlValueSetDefinition(
        definitionName: "Medicare FFS payer",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1104.10",
        valueSetVersion: null)]
    public CqlValueSet Medicare_FFS_payer(CqlContext context) => _Medicare_FFS_payer;

    private static readonly CqlValueSet _Medicare_FFS_payer = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1104.10", null);
    #endregion

    #region ValueSet: Oxygen Saturation by Pulse Oximetry
    [CqlValueSetDefinition(
        definitionName: "Oxygen Saturation by Pulse Oximetry",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.151",
        valueSetVersion: null)]
    public CqlValueSet Oxygen_Saturation_by_Pulse_Oximetry(CqlContext context) => _Oxygen_Saturation_by_Pulse_Oximetry;

    private static readonly CqlValueSet _Oxygen_Saturation_by_Pulse_Oximetry = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.151", null);
    #endregion

    #region ValueSet: Platelet count lab test
    [CqlValueSetDefinition(
        definitionName: "Platelet count lab test",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.127",
        valueSetVersion: null)]
    public CqlValueSet Platelet_count_lab_test(CqlContext context) => _Platelet_count_lab_test;

    private static readonly CqlValueSet _Platelet_count_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.127", null);
    #endregion

    #region ValueSet: Sodium lab test
    [CqlValueSetDefinition(
        definitionName: "Sodium lab test",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.119",
        valueSetVersion: null)]
    public CqlValueSet Sodium_lab_test(CqlContext context) => _Sodium_lab_test;

    private static readonly CqlValueSet _Sodium_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.119", null);
    #endregion

    #region ValueSet: White blood cells count lab test
    [CqlValueSetDefinition(
        definitionName: "White blood cells count lab test",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.129",
        valueSetVersion: null)]
    public CqlValueSet White_blood_cells_count_lab_test(CqlContext context) => _White_blood_cells_count_lab_test;

    private static readonly CqlValueSet _White_blood_cells_count_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.129", null);
    #endregion

    #endregion ValueSets

    #region Codes

    #region Code: Oxygen saturation in Arterial blood
    [CqlCodeDefinition(
        definitionName: "Oxygen saturation in Arterial blood",
        codeId: "2708-6",
        codeSystem: "http://loinc.org")]
    public CqlCode Oxygen_saturation_in_Arterial_blood(CqlContext context) => _Oxygen_saturation_in_Arterial_blood;

    private static readonly CqlCode _Oxygen_saturation_in_Arterial_blood = new CqlCode("2708-6", "http://loinc.org", default, default);
    #endregion

    #region Code: Oxygen saturation in Arterial blood by Pulse oximetry
    [CqlCodeDefinition(
        definitionName: "Oxygen saturation in Arterial blood by Pulse oximetry",
        codeId: "59408-5",
        codeSystem: "http://loinc.org")]
    public CqlCode Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry(CqlContext context) => _Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry;

    private static readonly CqlCode _Oxygen_saturation_in_Arterial_blood_by_Pulse_oximetry = new CqlCode("59408-5", "http://loinc.org", default, default);
    #endregion

    #region Code: Systolic blood pressure
    [CqlCodeDefinition(
        definitionName: "Systolic blood pressure",
        codeId: "8480-6",
        codeSystem: "http://loinc.org")]
    public CqlCode Systolic_blood_pressure(CqlContext context) => _Systolic_blood_pressure;

    private static readonly CqlCode _Systolic_blood_pressure = new CqlCode("8480-6", "http://loinc.org", default, default);
    #endregion

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition(
        definitionName: "LOINC")]
    public CqlCode[] LOINC(CqlContext context)
    {
        CqlCode[] ozzzzzzzzzzzzzzzzzzzzzj_ = [
            new CqlCode("2708-6", "http://loinc.org", default, default),
            new CqlCode("59408-5", "http://loinc.org", default, default),
            new CqlCode("8480-6", "http://loinc.org", default, default),
        ];

        return ozzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "ActCode")]
    public CqlCode[] ActCode(CqlContext context)
    {
        CqlCode[] ozzzzzzzzzzzzzzzzzzzzzk_ = []
;

        return ozzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "Source of Payment Typology")]
    public CqlCode[] Source_of_Payment_Typology(CqlContext context)
    {
        CqlCode[] ozzzzzzzzzzzzzzzzzzzzzl_ = []
;

        return ozzzzzzzzzzzzzzzzzzzzzl_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime ozzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime ozzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Interval(ozzzzzzzzzzzzzzzzzzzzzm_, ozzzzzzzzzzzzzzzzzzzzzn_, true, true);
        object ozzzzzzzzzzzzzzzzzzzzzp_ = context.ResolveParameter("HybridHospitalWideMortalityFHIR-0.0.001", "Measurement Period", ozzzzzzzzzzzzzzzzzzzzzo_);

        return (CqlInterval<CqlDateTime>)ozzzzzzzzzzzzzzzzzzzzzp_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> ozzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient ozzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.SingletonFrom<Patient>(ozzzzzzzzzzzzzzzzzzzzzq_);

        return ozzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition(
        definitionName: "Inpatient Encounters")]
    public IEnumerable<Encounter> Inpatient_Encounters(CqlContext context)
    {
        CqlValueSet ozzzzzzzzzzzzzzzzzzzzzs_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzu_(Encounter InpatientEncounter)
        {
            CqlValueSet ozzzzzzzzzzzzzzzzzzzzzw_ = this.Medicare_FFS_payer(context);
            IEnumerable<Coverage> ozzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Coverage>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-coverage"));
            CqlValueSet ozzzzzzzzzzzzzzzzzzzzzy_ = this.Medicare_Advantage_payer(context);
            IEnumerable<Coverage> ozzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Coverage>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-coverage"));
            IEnumerable<Coverage> pzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Union<Coverage>(ozzzzzzzzzzzzzzzzzzzzzx_, ozzzzzzzzzzzzzzzzzzzzzz_);
            bool? pzzzzzzzzzzzzzzzzzzzzzb_(Coverage MedicarePayer)
            {
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzf_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, InpatientEncounter);
                int? pzzzzzzzzzzzzzzzzzzzzzg_ = CQMCommon_2_2_000.Instance.lengthInDays(context, pzzzzzzzzzzzzzzzzzzzzzf_);
                bool? pzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Less(pzzzzzzzzzzzzzzzzzzzzzg_, 365);
                Code<Encounter.EncounterStatus> pzzzzzzzzzzzzzzzzzzzzzi_ = InpatientEncounter?.StatusElement;
                Encounter.EncounterStatus? pzzzzzzzzzzzzzzzzzzzzzj_ = pzzzzzzzzzzzzzzzzzzzzzi_?.Value;
                Code<Encounter.EncounterStatus> pzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(pzzzzzzzzzzzzzzzzzzzzzj_);
                bool? pzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Equal(pzzzzzzzzzzzzzzzzzzzzzk_, "finished");
                bool? pzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzh_, pzzzzzzzzzzzzzzzzzzzzzl_);
                Patient pzzzzzzzzzzzzzzzzzzzzzn_ = this.Patient(context);
                Date pzzzzzzzzzzzzzzzzzzzzzo_ = pzzzzzzzzzzzzzzzzzzzzzn_?.BirthDateElement;
                string pzzzzzzzzzzzzzzzzzzzzzp_ = pzzzzzzzzzzzzzzzzzzzzzo_?.Value;
                CqlDate pzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.ConvertStringToDate(pzzzzzzzzzzzzzzzzzzzzzp_);
                Period pzzzzzzzzzzzzzzzzzzzzzr_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzzzzzzzzzzzzzzzr_);
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(pzzzzzzzzzzzzzzzzzzzzzs_);
                CqlDate pzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.DateFrom(pzzzzzzzzzzzzzzzzzzzzzt_);
                int? pzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.CalculateAgeAt(pzzzzzzzzzzzzzzzzzzzzzq_, pzzzzzzzzzzzzzzzzzzzzzu_, "year");
                CqlInterval<int?> pzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Interval(65, 94, true, true);
                bool? pzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.In<int?>(pzzzzzzzzzzzzzzzzzzzzzv_, pzzzzzzzzzzzzzzzzzzzzzw_, default);
                bool? pzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzm_, pzzzzzzzzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzzzzzzzzzzzzzzzr_);
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.End(qzzzzzzzzzzzzzzzzzzzzza_);
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzc_ = this.Measurement_Period(context);
                bool? qzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(qzzzzzzzzzzzzzzzzzzzzzb_, qzzzzzzzzzzzzzzzzzzzzzc_, "day");
                bool? qzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzy_, qzzzzzzzzzzzzzzzzzzzzzd_);

                return qzzzzzzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<Coverage> pzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Coverage>(pzzzzzzzzzzzzzzzzzzzzza_, pzzzzzzzzzzzzzzzzzzzzzb_);
            Encounter pzzzzzzzzzzzzzzzzzzzzzd_(Coverage MedicarePayer) =>
                InpatientEncounter;
            IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Select<Coverage, Encounter>(pzzzzzzzzzzzzzzzzzzzzzc_, pzzzzzzzzzzzzzzzzzzzzzd_);

            return pzzzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.SelectMany<Encounter, Encounter>(ozzzzzzzzzzzzzzzzzzzzzt_, ozzzzzzzzzzzzzzzzzzzzzu_);

        return ozzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzf_ = this.Inpatient_Encounters(context);

        return qzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with First Body Temperature")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)?> Encounter_with_First_Body_Temperature(CqlContext context)
    {
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzg_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)? qzzzzzzzzzzzzzzzzzzzzzh_(Encounter EncounterInpatient)
        {
            Id qzzzzzzzzzzzzzzzzzzzzzk_ = EncounterInpatient?.IdElement;
            string qzzzzzzzzzzzzzzzzzzzzzl_ = qzzzzzzzzzzzzzzzzzzzzzk_?.Value;
            IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bodytemp"));
            bool? qzzzzzzzzzzzzzzzzzzzzzn_(Observation temperature)
            {
                DataType rzzzzzzzzzzzzzzzzzzzzze_ = temperature?.Effective;
                object rzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzze_);
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.earliest(context, rzzzzzzzzzzzzzzzzzzzzzf_);
                Period rzzzzzzzzzzzzzzzzzzzzzh_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzzzzzzzzzzzzzh_);
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Start(rzzzzzzzzzzzzzzzzzzzzzi_);
                CqlQuantity rzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Subtract(rzzzzzzzzzzzzzzzzzzzzzj_, rzzzzzzzzzzzzzzzzzzzzzk_);
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzzzzzzzzzzzzzh_);
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Start(rzzzzzzzzzzzzzzzzzzzzzn_);
                CqlQuantity rzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Add(rzzzzzzzzzzzzzzzzzzzzzo_, rzzzzzzzzzzzzzzzzzzzzzp_);
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Interval(rzzzzzzzzzzzzzzzzzzzzzl_, rzzzzzzzzzzzzzzzzzzzzzq_, true, true);
                bool? rzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.In<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzzzg_, rzzzzzzzzzzzzzzzzzzzzzr_, default);
                Code<ObservationStatus> rzzzzzzzzzzzzzzzzzzzzzt_ = temperature?.StatusElement;
                ObservationStatus? rzzzzzzzzzzzzzzzzzzzzzu_ = rzzzzzzzzzzzzzzzzzzzzzt_?.Value;
                string rzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Convert<string>(rzzzzzzzzzzzzzzzzzzzzzu_);
                string[] rzzzzzzzzzzzzzzzzzzzzzw_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? rzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.In<string>(rzzzzzzzzzzzzzzzzzzzzzv_, rzzzzzzzzzzzzzzzzzzzzzw_ as IEnumerable<string>);
                bool? rzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzzs_, rzzzzzzzzzzzzzzzzzzzzzx_);
                DataType rzzzzzzzzzzzzzzzzzzzzzz_ = temperature?.Value;
                CqlQuantity szzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, rzzzzzzzzzzzzzzzzzzzzzz_ as Quantity);
                bool? szzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Not((bool?)(szzzzzzzzzzzzzzzzzzzzza_ is null));
                bool? szzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzzy_, szzzzzzzzzzzzzzzzzzzzzb_);

                return szzzzzzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Observation>(qzzzzzzzzzzzzzzzzzzzzzm_, qzzzzzzzzzzzzzzzzzzzzzn_);
            object qzzzzzzzzzzzzzzzzzzzzzp_(Observation @this)
            {
                DataType szzzzzzzzzzzzzzzzzzzzzd_ = @this?.Effective;
                object szzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzd_);
                CqlDateTime szzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.earliest(context, szzzzzzzzzzzzzzzzzzzzze_);

                return szzzzzzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.SortBy<Observation>(qzzzzzzzzzzzzzzzzzzzzzo_, qzzzzzzzzzzzzzzzzzzzzzp_, System.ComponentModel.ListSortDirection.Ascending);
            Observation qzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.First<Observation>(qzzzzzzzzzzzzzzzzzzzzzq_);
            DataType qzzzzzzzzzzzzzzzzzzzzzs_ = qzzzzzzzzzzzzzzzzzzzzzr_?.Value;
            CqlQuantity qzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, qzzzzzzzzzzzzzzzzzzzzzs_ as Quantity);
            bool? qzzzzzzzzzzzzzzzzzzzzzv_(Observation temperature)
            {
                DataType szzzzzzzzzzzzzzzzzzzzzg_ = temperature?.Effective;
                object szzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzg_);
                CqlDateTime szzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.earliest(context, szzzzzzzzzzzzzzzzzzzzzh_);
                Period szzzzzzzzzzzzzzzzzzzzzj_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzzzzzzzzzzzzzzzj_);
                CqlDateTime szzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(szzzzzzzzzzzzzzzzzzzzzk_);
                CqlQuantity szzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime szzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Subtract(szzzzzzzzzzzzzzzzzzzzzl_, szzzzzzzzzzzzzzzzzzzzzm_);
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzzzzzzzzzzzzzzzj_);
                CqlDateTime szzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(szzzzzzzzzzzzzzzzzzzzzp_);
                CqlQuantity szzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime szzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Add(szzzzzzzzzzzzzzzzzzzzzq_, szzzzzzzzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Interval(szzzzzzzzzzzzzzzzzzzzzn_, szzzzzzzzzzzzzzzzzzzzzs_, true, true);
                bool? szzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(szzzzzzzzzzzzzzzzzzzzzi_, szzzzzzzzzzzzzzzzzzzzzt_, default);
                Code<ObservationStatus> szzzzzzzzzzzzzzzzzzzzzv_ = temperature?.StatusElement;
                ObservationStatus? szzzzzzzzzzzzzzzzzzzzzw_ = szzzzzzzzzzzzzzzzzzzzzv_?.Value;
                string szzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<string>(szzzzzzzzzzzzzzzzzzzzzw_);
                string[] szzzzzzzzzzzzzzzzzzzzzy_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? szzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<string>(szzzzzzzzzzzzzzzzzzzzzx_, szzzzzzzzzzzzzzzzzzzzzy_ as IEnumerable<string>);
                bool? tzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzu_, szzzzzzzzzzzzzzzzzzzzzz_);
                DataType tzzzzzzzzzzzzzzzzzzzzzb_ = temperature?.Value;
                CqlQuantity tzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, tzzzzzzzzzzzzzzzzzzzzzb_ as Quantity);
                bool? tzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Not((bool?)(tzzzzzzzzzzzzzzzzzzzzzc_ is null));
                bool? tzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzza_, tzzzzzzzzzzzzzzzzzzzzzd_);

                return tzzzzzzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Observation>(qzzzzzzzzzzzzzzzzzzzzzm_, qzzzzzzzzzzzzzzzzzzzzzv_);
            object qzzzzzzzzzzzzzzzzzzzzzx_(Observation @this)
            {
                DataType tzzzzzzzzzzzzzzzzzzzzzf_ = @this?.Effective;
                object tzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzf_);
                CqlDateTime tzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.earliest(context, tzzzzzzzzzzzzzzzzzzzzzg_);

                return tzzzzzzzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.SortBy<Observation>(qzzzzzzzzzzzzzzzzzzzzzw_, qzzzzzzzzzzzzzzzzzzzzzx_, System.ComponentModel.ListSortDirection.Ascending);
            Observation qzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.First<Observation>(qzzzzzzzzzzzzzzzzzzzzzy_);
            DataType rzzzzzzzzzzzzzzzzzzzzza_ = qzzzzzzzzzzzzzzzzzzzzzz_?.Effective;
            object rzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzza_);
            CqlDateTime rzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.earliest(context, rzzzzzzzzzzzzzzzzzzzzzb_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)? rzzzzzzzzzzzzzzzzzzzzzd_ = (CqlTupleMetadata_GIbILVAdXLLNYBgcQIEiUiKaK, qzzzzzzzzzzzzzzzzzzzzzl_, qzzzzzzzzzzzzzzzzzzzzzt_ as CqlQuantity, rzzzzzzzzzzzzzzzzzzzzzc_);

            return rzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)?> qzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)?>(qzzzzzzzzzzzzzzzzzzzzzg_, qzzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)?> qzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)?>(qzzzzzzzzzzzzzzzzzzzzzi_);

        return qzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with First Heart Rate")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)?> Encounter_with_First_Heart_Rate(CqlContext context)
    {
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzi_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)? tzzzzzzzzzzzzzzzzzzzzzj_(Encounter EncounterInpatient)
        {
            Id tzzzzzzzzzzzzzzzzzzzzzm_ = EncounterInpatient?.IdElement;
            string tzzzzzzzzzzzzzzzzzzzzzn_ = tzzzzzzzzzzzzzzzzzzzzzm_?.Value;
            IEnumerable<Observation> tzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/heartrate"));
            bool? tzzzzzzzzzzzzzzzzzzzzzp_(Observation HeartRate)
            {
                DataType uzzzzzzzzzzzzzzzzzzzzzg_ = HeartRate?.Effective;
                object uzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzg_);
                CqlDateTime uzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.earliest(context, uzzzzzzzzzzzzzzzzzzzzzh_);
                Period uzzzzzzzzzzzzzzzzzzzzzj_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzzzzzzzzzzzzj_);
                CqlDateTime uzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(uzzzzzzzzzzzzzzzzzzzzzk_);
                CqlQuantity uzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime uzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Subtract(uzzzzzzzzzzzzzzzzzzzzzl_, uzzzzzzzzzzzzzzzzzzzzzm_);
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzzzzzzzzzzzzj_);
                CqlDateTime uzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(uzzzzzzzzzzzzzzzzzzzzzp_);
                CqlQuantity uzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime uzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Add(uzzzzzzzzzzzzzzzzzzzzzq_, uzzzzzzzzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Interval(uzzzzzzzzzzzzzzzzzzzzzn_, uzzzzzzzzzzzzzzzzzzzzzs_, true, true);
                bool? uzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(uzzzzzzzzzzzzzzzzzzzzzi_, uzzzzzzzzzzzzzzzzzzzzzt_, default);
                Code<ObservationStatus> uzzzzzzzzzzzzzzzzzzzzzv_ = HeartRate?.StatusElement;
                ObservationStatus? uzzzzzzzzzzzzzzzzzzzzzw_ = uzzzzzzzzzzzzzzzzzzzzzv_?.Value;
                string uzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<string>(uzzzzzzzzzzzzzzzzzzzzzw_);
                string[] uzzzzzzzzzzzzzzzzzzzzzy_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? uzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<string>(uzzzzzzzzzzzzzzzzzzzzzx_, uzzzzzzzzzzzzzzzzzzzzzy_ as IEnumerable<string>);
                bool? vzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzzzu_, uzzzzzzzzzzzzzzzzzzzzzz_);
                DataType vzzzzzzzzzzzzzzzzzzzzzb_ = HeartRate?.Value;
                CqlQuantity vzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, vzzzzzzzzzzzzzzzzzzzzzb_ as Quantity);
                bool? vzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Not((bool?)(vzzzzzzzzzzzzzzzzzzzzzc_ is null));
                bool? vzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzza_, vzzzzzzzzzzzzzzzzzzzzzd_);

                return vzzzzzzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<Observation> tzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Observation>(tzzzzzzzzzzzzzzzzzzzzzo_, tzzzzzzzzzzzzzzzzzzzzzp_);
            object tzzzzzzzzzzzzzzzzzzzzzr_(Observation @this)
            {
                DataType vzzzzzzzzzzzzzzzzzzzzzf_ = @this?.Effective;
                object vzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzf_);
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.earliest(context, vzzzzzzzzzzzzzzzzzzzzzg_);

                return vzzzzzzzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<Observation> tzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.SortBy<Observation>(tzzzzzzzzzzzzzzzzzzzzzq_, tzzzzzzzzzzzzzzzzzzzzzr_, System.ComponentModel.ListSortDirection.Ascending);
            Observation tzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.First<Observation>(tzzzzzzzzzzzzzzzzzzzzzs_);
            DataType tzzzzzzzzzzzzzzzzzzzzzu_ = tzzzzzzzzzzzzzzzzzzzzzt_?.Value;
            CqlQuantity tzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, tzzzzzzzzzzzzzzzzzzzzzu_ as Quantity);
            bool? tzzzzzzzzzzzzzzzzzzzzzx_(Observation HeartRate)
            {
                DataType vzzzzzzzzzzzzzzzzzzzzzi_ = HeartRate?.Effective;
                object vzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzi_);
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.earliest(context, vzzzzzzzzzzzzzzzzzzzzzj_);
                Period vzzzzzzzzzzzzzzzzzzzzzl_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzzzzzzzzzzzzzzl_);
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(vzzzzzzzzzzzzzzzzzzzzzm_);
                CqlQuantity vzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Subtract(vzzzzzzzzzzzzzzzzzzzzzn_, vzzzzzzzzzzzzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzzzzzzzzzzzzzzl_);
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(vzzzzzzzzzzzzzzzzzzzzzr_);
                CqlQuantity vzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Add(vzzzzzzzzzzzzzzzzzzzzzs_, vzzzzzzzzzzzzzzzzzzzzzt_);
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Interval(vzzzzzzzzzzzzzzzzzzzzzp_, vzzzzzzzzzzzzzzzzzzzzzu_, true, true);
                bool? vzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.In<CqlDateTime>(vzzzzzzzzzzzzzzzzzzzzzk_, vzzzzzzzzzzzzzzzzzzzzzv_, default);
                Code<ObservationStatus> vzzzzzzzzzzzzzzzzzzzzzx_ = HeartRate?.StatusElement;
                ObservationStatus? vzzzzzzzzzzzzzzzzzzzzzy_ = vzzzzzzzzzzzzzzzzzzzzzx_?.Value;
                string vzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Convert<string>(vzzzzzzzzzzzzzzzzzzzzzy_);
                string[] wzzzzzzzzzzzzzzzzzzzzza_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? wzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.In<string>(vzzzzzzzzzzzzzzzzzzzzzz_, wzzzzzzzzzzzzzzzzzzzzza_ as IEnumerable<string>);
                bool? wzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzzw_, wzzzzzzzzzzzzzzzzzzzzzb_);
                DataType wzzzzzzzzzzzzzzzzzzzzzd_ = HeartRate?.Value;
                CqlQuantity wzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, wzzzzzzzzzzzzzzzzzzzzzd_ as Quantity);
                bool? wzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Not((bool?)(wzzzzzzzzzzzzzzzzzzzzze_ is null));
                bool? wzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzc_, wzzzzzzzzzzzzzzzzzzzzzf_);

                return wzzzzzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Observation> tzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Observation>(tzzzzzzzzzzzzzzzzzzzzzo_, tzzzzzzzzzzzzzzzzzzzzzx_);
            object tzzzzzzzzzzzzzzzzzzzzzz_(Observation @this)
            {
                DataType wzzzzzzzzzzzzzzzzzzzzzh_ = @this?.Effective;
                object wzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzh_);
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.earliest(context, wzzzzzzzzzzzzzzzzzzzzzi_);

                return wzzzzzzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<Observation> uzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.SortBy<Observation>(tzzzzzzzzzzzzzzzzzzzzzy_, tzzzzzzzzzzzzzzzzzzzzzz_, System.ComponentModel.ListSortDirection.Ascending);
            Observation uzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.First<Observation>(uzzzzzzzzzzzzzzzzzzzzza_);
            DataType uzzzzzzzzzzzzzzzzzzzzzc_ = uzzzzzzzzzzzzzzzzzzzzzb_?.Effective;
            object uzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzc_);
            CqlDateTime uzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.earliest(context, uzzzzzzzzzzzzzzzzzzzzzd_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)? uzzzzzzzzzzzzzzzzzzzzzf_ = (CqlTupleMetadata_DhbJAfCiKIAGYKTjJXYGSKECQ, tzzzzzzzzzzzzzzzzzzzzzn_, tzzzzzzzzzzzzzzzzzzzzzv_ as CqlQuantity, uzzzzzzzzzzzzzzzzzzzzze_);

            return uzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)?> tzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)?>(tzzzzzzzzzzzzzzzzzzzzzi_, tzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)?> tzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)?>(tzzzzzzzzzzzzzzzzzzzzzk_);

        return tzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with First Oxygen Saturation")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)?> Encounter_with_First_Oxygen_Saturation(CqlContext context)
    {
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzk_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)? wzzzzzzzzzzzzzzzzzzzzzl_(Encounter EncounterInpatient)
        {
            Id wzzzzzzzzzzzzzzzzzzzzzo_ = EncounterInpatient?.IdElement;
            string wzzzzzzzzzzzzzzzzzzzzzp_ = wzzzzzzzzzzzzzzzzzzzzzo_?.Value;
            CqlValueSet wzzzzzzzzzzzzzzzzzzzzzq_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
            IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, wzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            bool? wzzzzzzzzzzzzzzzzzzzzzs_(Observation O2Saturation)
            {
                object xzzzzzzzzzzzzzzzzzzzzzc_()
                {
                    bool yzzzzzzzzzzzzzzzzzzzzzb_()
                    {
                        DataType yzzzzzzzzzzzzzzzzzzzzze_ = O2Saturation?.Effective;
                        object yzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzze_);
                        bool yzzzzzzzzzzzzzzzzzzzzzg_ = yzzzzzzzzzzzzzzzzzzzzzf_ is CqlDateTime;

                        return yzzzzzzzzzzzzzzzzzzzzzg_;
                    };
                    bool yzzzzzzzzzzzzzzzzzzzzzc_()
                    {
                        DataType yzzzzzzzzzzzzzzzzzzzzzh_ = O2Saturation?.Effective;
                        object yzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzh_);
                        bool yzzzzzzzzzzzzzzzzzzzzzj_ = yzzzzzzzzzzzzzzzzzzzzzi_ is CqlInterval<CqlDateTime>;

                        return yzzzzzzzzzzzzzzzzzzzzzj_;
                    };
                    bool yzzzzzzzzzzzzzzzzzzzzzd_()
                    {
                        DataType yzzzzzzzzzzzzzzzzzzzzzk_ = O2Saturation?.Effective;
                        object yzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzk_);
                        bool yzzzzzzzzzzzzzzzzzzzzzm_ = yzzzzzzzzzzzzzzzzzzzzzl_ is CqlDateTime;

                        return yzzzzzzzzzzzzzzzzzzzzzm_;
                    };
                    if (yzzzzzzzzzzzzzzzzzzzzzb_())
                    {
                        DataType yzzzzzzzzzzzzzzzzzzzzzn_ = O2Saturation?.Effective;
                        object yzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzn_);

                        return (yzzzzzzzzzzzzzzzzzzzzzo_ as CqlDateTime) as object;
                    }
                    else if (yzzzzzzzzzzzzzzzzzzzzzc_())
                    {
                        DataType yzzzzzzzzzzzzzzzzzzzzzp_ = O2Saturation?.Effective;
                        object yzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzp_);

                        return (yzzzzzzzzzzzzzzzzzzzzzq_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (yzzzzzzzzzzzzzzzzzzzzzd_())
                    {
                        DataType yzzzzzzzzzzzzzzzzzzzzzr_ = O2Saturation?.Effective;
                        object yzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzr_);

                        return (yzzzzzzzzzzzzzzzzzzzzzs_ as CqlDateTime) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.earliest(context, xzzzzzzzzzzzzzzzzzzzzzc_());
                Period xzzzzzzzzzzzzzzzzzzzzze_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzzzzzze_);
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzzzf_);
                CqlQuantity xzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Subtract(xzzzzzzzzzzzzzzzzzzzzzg_, xzzzzzzzzzzzzzzzzzzzzzh_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzzzzzze_);
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzzzk_);
                CqlQuantity xzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Add(xzzzzzzzzzzzzzzzzzzzzzl_, xzzzzzzzzzzzzzzzzzzzzzm_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Interval(xzzzzzzzzzzzzzzzzzzzzzi_, xzzzzzzzzzzzzzzzzzzzzzn_, true, true);
                bool? xzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzzzzzzzzzzzzzd_, xzzzzzzzzzzzzzzzzzzzzzo_, default);
                Code<ObservationStatus> xzzzzzzzzzzzzzzzzzzzzzq_ = O2Saturation?.StatusElement;
                ObservationStatus? xzzzzzzzzzzzzzzzzzzzzzr_ = xzzzzzzzzzzzzzzzzzzzzzq_?.Value;
                Code<ObservationStatus> xzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Convert<Code<ObservationStatus>>(xzzzzzzzzzzzzzzzzzzzzzr_);
                string xzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Convert<string>(xzzzzzzzzzzzzzzzzzzzzzs_);
                string[] xzzzzzzzzzzzzzzzzzzzzzu_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? xzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.In<string>(xzzzzzzzzzzzzzzzzzzzzzt_, xzzzzzzzzzzzzzzzzzzzzzu_ as IEnumerable<string>);
                bool? xzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzp_, xzzzzzzzzzzzzzzzzzzzzzv_);
                DataType xzzzzzzzzzzzzzzzzzzzzzx_ = O2Saturation?.Value;
                object xzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzx_);
                bool? xzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Not((bool?)(xzzzzzzzzzzzzzzzzzzzzzy_ is null));
                bool? yzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzw_, xzzzzzzzzzzzzzzzzzzzzzz_);

                return yzzzzzzzzzzzzzzzzzzzzza_;
            };
            IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Observation>(wzzzzzzzzzzzzzzzzzzzzzr_, wzzzzzzzzzzzzzzzzzzzzzs_);
            object wzzzzzzzzzzzzzzzzzzzzzu_(Observation @this)
            {
                object yzzzzzzzzzzzzzzzzzzzzzt_()
                {
                    bool yzzzzzzzzzzzzzzzzzzzzzv_()
                    {
                        DataType yzzzzzzzzzzzzzzzzzzzzzy_ = @this?.Effective;
                        object yzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzy_);
                        bool zzzzzzzzzzzzzzzzzzzzzza_ = yzzzzzzzzzzzzzzzzzzzzzz_ is CqlDateTime;

                        return zzzzzzzzzzzzzzzzzzzzzza_;
                    };
                    bool yzzzzzzzzzzzzzzzzzzzzzw_()
                    {
                        DataType zzzzzzzzzzzzzzzzzzzzzzb_ = @this?.Effective;
                        object zzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzb_);
                        bool zzzzzzzzzzzzzzzzzzzzzzd_ = zzzzzzzzzzzzzzzzzzzzzzc_ is CqlInterval<CqlDateTime>;

                        return zzzzzzzzzzzzzzzzzzzzzzd_;
                    };
                    bool yzzzzzzzzzzzzzzzzzzzzzx_()
                    {
                        DataType zzzzzzzzzzzzzzzzzzzzzze_ = @this?.Effective;
                        object zzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzze_);
                        bool zzzzzzzzzzzzzzzzzzzzzzg_ = zzzzzzzzzzzzzzzzzzzzzzf_ is CqlDateTime;

                        return zzzzzzzzzzzzzzzzzzzzzzg_;
                    };
                    if (yzzzzzzzzzzzzzzzzzzzzzv_())
                    {
                        DataType zzzzzzzzzzzzzzzzzzzzzzh_ = @this?.Effective;
                        object zzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzh_);

                        return (zzzzzzzzzzzzzzzzzzzzzzi_ as CqlDateTime) as object;
                    }
                    else if (yzzzzzzzzzzzzzzzzzzzzzw_())
                    {
                        DataType zzzzzzzzzzzzzzzzzzzzzzj_ = @this?.Effective;
                        object zzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzj_);

                        return (zzzzzzzzzzzzzzzzzzzzzzk_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (yzzzzzzzzzzzzzzzzzzzzzx_())
                    {
                        DataType zzzzzzzzzzzzzzzzzzzzzzl_ = @this?.Effective;
                        object zzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzl_);

                        return (zzzzzzzzzzzzzzzzzzzzzzm_ as CqlDateTime) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.earliest(context, yzzzzzzzzzzzzzzzzzzzzzt_());

                return yzzzzzzzzzzzzzzzzzzzzzu_;
            };
            IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.SortBy<Observation>(wzzzzzzzzzzzzzzzzzzzzzt_, wzzzzzzzzzzzzzzzzzzzzzu_, System.ComponentModel.ListSortDirection.Ascending);
            Observation wzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.First<Observation>(wzzzzzzzzzzzzzzzzzzzzzv_);
            DataType wzzzzzzzzzzzzzzzzzzzzzx_ = wzzzzzzzzzzzzzzzzzzzzzw_?.Value;
            object wzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzx_);
            object wzzzzzzzzzzzzzzzzzzzzzz_()
            {
                bool zzzzzzzzzzzzzzzzzzzzzzn_()
                {
                    CqlValueSet zzzzzzzzzzzzzzzzzzzzzzq_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
                    IEnumerable<Observation> zzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? zzzzzzzzzzzzzzzzzzzzzzs_(Observation O2Saturation)
                    {
                        object azzzzzzzzzzzzzzzzzzzzzza_()
                        {
                            bool azzzzzzzzzzzzzzzzzzzzzzz_()
                            {
                                DataType bzzzzzzzzzzzzzzzzzzzzzzc_ = O2Saturation?.Effective;
                                object bzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzc_);
                                bool bzzzzzzzzzzzzzzzzzzzzzze_ = bzzzzzzzzzzzzzzzzzzzzzzd_ is CqlDateTime;

                                return bzzzzzzzzzzzzzzzzzzzzzze_;
                            };
                            bool bzzzzzzzzzzzzzzzzzzzzzza_()
                            {
                                DataType bzzzzzzzzzzzzzzzzzzzzzzf_ = O2Saturation?.Effective;
                                object bzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzf_);
                                bool bzzzzzzzzzzzzzzzzzzzzzzh_ = bzzzzzzzzzzzzzzzzzzzzzzg_ is CqlInterval<CqlDateTime>;

                                return bzzzzzzzzzzzzzzzzzzzzzzh_;
                            };
                            bool bzzzzzzzzzzzzzzzzzzzzzzb_()
                            {
                                DataType bzzzzzzzzzzzzzzzzzzzzzzi_ = O2Saturation?.Effective;
                                object bzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzi_);
                                bool bzzzzzzzzzzzzzzzzzzzzzzk_ = bzzzzzzzzzzzzzzzzzzzzzzj_ is CqlDateTime;

                                return bzzzzzzzzzzzzzzzzzzzzzzk_;
                            };
                            if (azzzzzzzzzzzzzzzzzzzzzzz_())
                            {
                                DataType bzzzzzzzzzzzzzzzzzzzzzzl_ = O2Saturation?.Effective;
                                object bzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzl_);

                                return (bzzzzzzzzzzzzzzzzzzzzzzm_ as CqlDateTime) as object;
                            }
                            else if (bzzzzzzzzzzzzzzzzzzzzzza_())
                            {
                                DataType bzzzzzzzzzzzzzzzzzzzzzzn_ = O2Saturation?.Effective;
                                object bzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzn_);

                                return (bzzzzzzzzzzzzzzzzzzzzzzo_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (bzzzzzzzzzzzzzzzzzzzzzzb_())
                            {
                                DataType bzzzzzzzzzzzzzzzzzzzzzzp_ = O2Saturation?.Effective;
                                object bzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzp_);

                                return (bzzzzzzzzzzzzzzzzzzzzzzq_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime azzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.earliest(context, azzzzzzzzzzzzzzzzzzzzzza_());
                        Period azzzzzzzzzzzzzzzzzzzzzzc_ = EncounterInpatient?.Period;
                        CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzzzzzzzzc_);
                        CqlDateTime azzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Start(azzzzzzzzzzzzzzzzzzzzzzd_);
                        CqlQuantity azzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Quantity(1440m, "minutes");
                        CqlDateTime azzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Subtract(azzzzzzzzzzzzzzzzzzzzzze_, azzzzzzzzzzzzzzzzzzzzzzf_);
                        CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzzzzzzzzc_);
                        CqlDateTime azzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Start(azzzzzzzzzzzzzzzzzzzzzzi_);
                        CqlQuantity azzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Quantity(120m, "minutes");
                        CqlDateTime azzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Add(azzzzzzzzzzzzzzzzzzzzzzj_, azzzzzzzzzzzzzzzzzzzzzzk_);
                        CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Interval(azzzzzzzzzzzzzzzzzzzzzzg_, azzzzzzzzzzzzzzzzzzzzzzl_, true, true);
                        bool? azzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.In<CqlDateTime>(azzzzzzzzzzzzzzzzzzzzzzb_, azzzzzzzzzzzzzzzzzzzzzzm_, default);
                        Code<ObservationStatus> azzzzzzzzzzzzzzzzzzzzzzo_ = O2Saturation?.StatusElement;
                        ObservationStatus? azzzzzzzzzzzzzzzzzzzzzzp_ = azzzzzzzzzzzzzzzzzzzzzzo_?.Value;
                        Code<ObservationStatus> azzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<Code<ObservationStatus>>(azzzzzzzzzzzzzzzzzzzzzzp_);
                        string azzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Convert<string>(azzzzzzzzzzzzzzzzzzzzzzq_);
                        string[] azzzzzzzzzzzzzzzzzzzzzzs_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? azzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.In<string>(azzzzzzzzzzzzzzzzzzzzzzr_, azzzzzzzzzzzzzzzzzzzzzzs_ as IEnumerable<string>);
                        bool? azzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzzzzn_, azzzzzzzzzzzzzzzzzzzzzzt_);
                        DataType azzzzzzzzzzzzzzzzzzzzzzv_ = O2Saturation?.Value;
                        object azzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzv_);
                        bool? azzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Not((bool?)(azzzzzzzzzzzzzzzzzzzzzzw_ is null));
                        bool? azzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzzzzu_, azzzzzzzzzzzzzzzzzzzzzzx_);

                        return azzzzzzzzzzzzzzzzzzzzzzy_;
                    };
                    IEnumerable<Observation> zzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Observation>(zzzzzzzzzzzzzzzzzzzzzzr_, zzzzzzzzzzzzzzzzzzzzzzs_);
                    object zzzzzzzzzzzzzzzzzzzzzzu_(Observation @this)
                    {
                        object bzzzzzzzzzzzzzzzzzzzzzzr_()
                        {
                            bool bzzzzzzzzzzzzzzzzzzzzzzt_()
                            {
                                DataType bzzzzzzzzzzzzzzzzzzzzzzw_ = @this?.Effective;
                                object bzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzw_);
                                bool bzzzzzzzzzzzzzzzzzzzzzzy_ = bzzzzzzzzzzzzzzzzzzzzzzx_ is CqlDateTime;

                                return bzzzzzzzzzzzzzzzzzzzzzzy_;
                            };
                            bool bzzzzzzzzzzzzzzzzzzzzzzu_()
                            {
                                DataType bzzzzzzzzzzzzzzzzzzzzzzz_ = @this?.Effective;
                                object czzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzz_);
                                bool czzzzzzzzzzzzzzzzzzzzzzb_ = czzzzzzzzzzzzzzzzzzzzzza_ is CqlInterval<CqlDateTime>;

                                return czzzzzzzzzzzzzzzzzzzzzzb_;
                            };
                            bool bzzzzzzzzzzzzzzzzzzzzzzv_()
                            {
                                DataType czzzzzzzzzzzzzzzzzzzzzzc_ = @this?.Effective;
                                object czzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzc_);
                                bool czzzzzzzzzzzzzzzzzzzzzze_ = czzzzzzzzzzzzzzzzzzzzzzd_ is CqlDateTime;

                                return czzzzzzzzzzzzzzzzzzzzzze_;
                            };
                            if (bzzzzzzzzzzzzzzzzzzzzzzt_())
                            {
                                DataType czzzzzzzzzzzzzzzzzzzzzzf_ = @this?.Effective;
                                object czzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzf_);

                                return (czzzzzzzzzzzzzzzzzzzzzzg_ as CqlDateTime) as object;
                            }
                            else if (bzzzzzzzzzzzzzzzzzzzzzzu_())
                            {
                                DataType czzzzzzzzzzzzzzzzzzzzzzh_ = @this?.Effective;
                                object czzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzh_);

                                return (czzzzzzzzzzzzzzzzzzzzzzi_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (bzzzzzzzzzzzzzzzzzzzzzzv_())
                            {
                                DataType czzzzzzzzzzzzzzzzzzzzzzj_ = @this?.Effective;
                                object czzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzj_);

                                return (czzzzzzzzzzzzzzzzzzzzzzk_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.earliest(context, bzzzzzzzzzzzzzzzzzzzzzzr_());

                        return bzzzzzzzzzzzzzzzzzzzzzzs_;
                    };
                    IEnumerable<Observation> zzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.SortBy<Observation>(zzzzzzzzzzzzzzzzzzzzzzt_, zzzzzzzzzzzzzzzzzzzzzzu_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation zzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.First<Observation>(zzzzzzzzzzzzzzzzzzzzzzv_);
                    DataType zzzzzzzzzzzzzzzzzzzzzzx_ = zzzzzzzzzzzzzzzzzzzzzzw_?.Effective;
                    object zzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzx_);
                    bool zzzzzzzzzzzzzzzzzzzzzzz_ = zzzzzzzzzzzzzzzzzzzzzzy_ is CqlDateTime;

                    return zzzzzzzzzzzzzzzzzzzzzzz_;
                };
                bool zzzzzzzzzzzzzzzzzzzzzzo_()
                {
                    CqlValueSet czzzzzzzzzzzzzzzzzzzzzzl_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
                    IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? czzzzzzzzzzzzzzzzzzzzzzn_(Observation O2Saturation)
                    {
                        object czzzzzzzzzzzzzzzzzzzzzzv_()
                        {
                            bool dzzzzzzzzzzzzzzzzzzzzzzu_()
                            {
                                DataType dzzzzzzzzzzzzzzzzzzzzzzx_ = O2Saturation?.Effective;
                                object dzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzx_);
                                bool dzzzzzzzzzzzzzzzzzzzzzzz_ = dzzzzzzzzzzzzzzzzzzzzzzy_ is CqlDateTime;

                                return dzzzzzzzzzzzzzzzzzzzzzzz_;
                            };
                            bool dzzzzzzzzzzzzzzzzzzzzzzv_()
                            {
                                DataType ezzzzzzzzzzzzzzzzzzzzzza_ = O2Saturation?.Effective;
                                object ezzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzza_);
                                bool ezzzzzzzzzzzzzzzzzzzzzzc_ = ezzzzzzzzzzzzzzzzzzzzzzb_ is CqlInterval<CqlDateTime>;

                                return ezzzzzzzzzzzzzzzzzzzzzzc_;
                            };
                            bool dzzzzzzzzzzzzzzzzzzzzzzw_()
                            {
                                DataType ezzzzzzzzzzzzzzzzzzzzzzd_ = O2Saturation?.Effective;
                                object ezzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzd_);
                                bool ezzzzzzzzzzzzzzzzzzzzzzf_ = ezzzzzzzzzzzzzzzzzzzzzze_ is CqlDateTime;

                                return ezzzzzzzzzzzzzzzzzzzzzzf_;
                            };
                            if (dzzzzzzzzzzzzzzzzzzzzzzu_())
                            {
                                DataType ezzzzzzzzzzzzzzzzzzzzzzg_ = O2Saturation?.Effective;
                                object ezzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzg_);

                                return (ezzzzzzzzzzzzzzzzzzzzzzh_ as CqlDateTime) as object;
                            }
                            else if (dzzzzzzzzzzzzzzzzzzzzzzv_())
                            {
                                DataType ezzzzzzzzzzzzzzzzzzzzzzi_ = O2Saturation?.Effective;
                                object ezzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzi_);

                                return (ezzzzzzzzzzzzzzzzzzzzzzj_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (dzzzzzzzzzzzzzzzzzzzzzzw_())
                            {
                                DataType ezzzzzzzzzzzzzzzzzzzzzzk_ = O2Saturation?.Effective;
                                object ezzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzk_);

                                return (ezzzzzzzzzzzzzzzzzzzzzzl_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime czzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.earliest(context, czzzzzzzzzzzzzzzzzzzzzzv_());
                        Period czzzzzzzzzzzzzzzzzzzzzzx_ = EncounterInpatient?.Period;
                        CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzzzzzzzzzzzzzzzx_);
                        CqlDateTime czzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzzzzzy_);
                        CqlQuantity dzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Quantity(1440m, "minutes");
                        CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Subtract(czzzzzzzzzzzzzzzzzzzzzzz_, dzzzzzzzzzzzzzzzzzzzzzza_);
                        CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzzzzzzzzzzzzzzzx_);
                        CqlDateTime dzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Start(dzzzzzzzzzzzzzzzzzzzzzzd_);
                        CqlQuantity dzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Quantity(120m, "minutes");
                        CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Add(dzzzzzzzzzzzzzzzzzzzzzze_, dzzzzzzzzzzzzzzzzzzzzzzf_);
                        CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Interval(dzzzzzzzzzzzzzzzzzzzzzzb_, dzzzzzzzzzzzzzzzzzzzzzzg_, true, true);
                        bool? dzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.In<CqlDateTime>(czzzzzzzzzzzzzzzzzzzzzzw_, dzzzzzzzzzzzzzzzzzzzzzzh_, default);
                        Code<ObservationStatus> dzzzzzzzzzzzzzzzzzzzzzzj_ = O2Saturation?.StatusElement;
                        ObservationStatus? dzzzzzzzzzzzzzzzzzzzzzzk_ = dzzzzzzzzzzzzzzzzzzzzzzj_?.Value;
                        Code<ObservationStatus> dzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<Code<ObservationStatus>>(dzzzzzzzzzzzzzzzzzzzzzzk_);
                        string dzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Convert<string>(dzzzzzzzzzzzzzzzzzzzzzzl_);
                        string[] dzzzzzzzzzzzzzzzzzzzzzzn_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? dzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.In<string>(dzzzzzzzzzzzzzzzzzzzzzzm_, dzzzzzzzzzzzzzzzzzzzzzzn_ as IEnumerable<string>);
                        bool? dzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzzzzzi_, dzzzzzzzzzzzzzzzzzzzzzzo_);
                        DataType dzzzzzzzzzzzzzzzzzzzzzzq_ = O2Saturation?.Value;
                        object dzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzq_);
                        bool? dzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Not((bool?)(dzzzzzzzzzzzzzzzzzzzzzzr_ is null));
                        bool? dzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzzzzzp_, dzzzzzzzzzzzzzzzzzzzzzzs_);

                        return dzzzzzzzzzzzzzzzzzzzzzzt_;
                    };
                    IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Observation>(czzzzzzzzzzzzzzzzzzzzzzm_, czzzzzzzzzzzzzzzzzzzzzzn_);
                    object czzzzzzzzzzzzzzzzzzzzzzp_(Observation @this)
                    {
                        object ezzzzzzzzzzzzzzzzzzzzzzm_()
                        {
                            bool ezzzzzzzzzzzzzzzzzzzzzzo_()
                            {
                                DataType ezzzzzzzzzzzzzzzzzzzzzzr_ = @this?.Effective;
                                object ezzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzr_);
                                bool ezzzzzzzzzzzzzzzzzzzzzzt_ = ezzzzzzzzzzzzzzzzzzzzzzs_ is CqlDateTime;

                                return ezzzzzzzzzzzzzzzzzzzzzzt_;
                            };
                            bool ezzzzzzzzzzzzzzzzzzzzzzp_()
                            {
                                DataType ezzzzzzzzzzzzzzzzzzzzzzu_ = @this?.Effective;
                                object ezzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzu_);
                                bool ezzzzzzzzzzzzzzzzzzzzzzw_ = ezzzzzzzzzzzzzzzzzzzzzzv_ is CqlInterval<CqlDateTime>;

                                return ezzzzzzzzzzzzzzzzzzzzzzw_;
                            };
                            bool ezzzzzzzzzzzzzzzzzzzzzzq_()
                            {
                                DataType ezzzzzzzzzzzzzzzzzzzzzzx_ = @this?.Effective;
                                object ezzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzx_);
                                bool ezzzzzzzzzzzzzzzzzzzzzzz_ = ezzzzzzzzzzzzzzzzzzzzzzy_ is CqlDateTime;

                                return ezzzzzzzzzzzzzzzzzzzzzzz_;
                            };
                            if (ezzzzzzzzzzzzzzzzzzzzzzo_())
                            {
                                DataType fzzzzzzzzzzzzzzzzzzzzzza_ = @this?.Effective;
                                object fzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzza_);

                                return (fzzzzzzzzzzzzzzzzzzzzzzb_ as CqlDateTime) as object;
                            }
                            else if (ezzzzzzzzzzzzzzzzzzzzzzp_())
                            {
                                DataType fzzzzzzzzzzzzzzzzzzzzzzc_ = @this?.Effective;
                                object fzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzc_);

                                return (fzzzzzzzzzzzzzzzzzzzzzzd_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (ezzzzzzzzzzzzzzzzzzzzzzq_())
                            {
                                DataType fzzzzzzzzzzzzzzzzzzzzzze_ = @this?.Effective;
                                object fzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzze_);

                                return (fzzzzzzzzzzzzzzzzzzzzzzf_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.earliest(context, ezzzzzzzzzzzzzzzzzzzzzzm_());

                        return ezzzzzzzzzzzzzzzzzzzzzzn_;
                    };
                    IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.SortBy<Observation>(czzzzzzzzzzzzzzzzzzzzzzo_, czzzzzzzzzzzzzzzzzzzzzzp_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation czzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.First<Observation>(czzzzzzzzzzzzzzzzzzzzzzq_);
                    DataType czzzzzzzzzzzzzzzzzzzzzzs_ = czzzzzzzzzzzzzzzzzzzzzzr_?.Effective;
                    object czzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzs_);
                    bool czzzzzzzzzzzzzzzzzzzzzzu_ = czzzzzzzzzzzzzzzzzzzzzzt_ is CqlInterval<CqlDateTime>;

                    return czzzzzzzzzzzzzzzzzzzzzzu_;
                };
                bool zzzzzzzzzzzzzzzzzzzzzzp_()
                {
                    CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzg_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
                    IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? fzzzzzzzzzzzzzzzzzzzzzzi_(Observation O2Saturation)
                    {
                        object fzzzzzzzzzzzzzzzzzzzzzzq_()
                        {
                            bool gzzzzzzzzzzzzzzzzzzzzzzp_()
                            {
                                DataType gzzzzzzzzzzzzzzzzzzzzzzs_ = O2Saturation?.Effective;
                                object gzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzs_);
                                bool gzzzzzzzzzzzzzzzzzzzzzzu_ = gzzzzzzzzzzzzzzzzzzzzzzt_ is CqlDateTime;

                                return gzzzzzzzzzzzzzzzzzzzzzzu_;
                            };
                            bool gzzzzzzzzzzzzzzzzzzzzzzq_()
                            {
                                DataType gzzzzzzzzzzzzzzzzzzzzzzv_ = O2Saturation?.Effective;
                                object gzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzv_);
                                bool gzzzzzzzzzzzzzzzzzzzzzzx_ = gzzzzzzzzzzzzzzzzzzzzzzw_ is CqlInterval<CqlDateTime>;

                                return gzzzzzzzzzzzzzzzzzzzzzzx_;
                            };
                            bool gzzzzzzzzzzzzzzzzzzzzzzr_()
                            {
                                DataType gzzzzzzzzzzzzzzzzzzzzzzy_ = O2Saturation?.Effective;
                                object gzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzy_);
                                bool hzzzzzzzzzzzzzzzzzzzzzza_ = gzzzzzzzzzzzzzzzzzzzzzzz_ is CqlDateTime;

                                return hzzzzzzzzzzzzzzzzzzzzzza_;
                            };
                            if (gzzzzzzzzzzzzzzzzzzzzzzp_())
                            {
                                DataType hzzzzzzzzzzzzzzzzzzzzzzb_ = O2Saturation?.Effective;
                                object hzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzb_);

                                return (hzzzzzzzzzzzzzzzzzzzzzzc_ as CqlDateTime) as object;
                            }
                            else if (gzzzzzzzzzzzzzzzzzzzzzzq_())
                            {
                                DataType hzzzzzzzzzzzzzzzzzzzzzzd_ = O2Saturation?.Effective;
                                object hzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzd_);

                                return (hzzzzzzzzzzzzzzzzzzzzzze_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (gzzzzzzzzzzzzzzzzzzzzzzr_())
                            {
                                DataType hzzzzzzzzzzzzzzzzzzzzzzf_ = O2Saturation?.Effective;
                                object hzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzf_);

                                return (hzzzzzzzzzzzzzzzzzzzzzzg_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.earliest(context, fzzzzzzzzzzzzzzzzzzzzzzq_());
                        Period fzzzzzzzzzzzzzzzzzzzzzzs_ = EncounterInpatient?.Period;
                        CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzzzzzzzzzzzzzzs_);
                        CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(fzzzzzzzzzzzzzzzzzzzzzzt_);
                        CqlQuantity fzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Quantity(1440m, "minutes");
                        CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Subtract(fzzzzzzzzzzzzzzzzzzzzzzu_, fzzzzzzzzzzzzzzzzzzzzzzv_);
                        CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzzzzzzzzzzzzzzs_);
                        CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Start(fzzzzzzzzzzzzzzzzzzzzzzy_);
                        CqlQuantity gzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Quantity(120m, "minutes");
                        CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Add(fzzzzzzzzzzzzzzzzzzzzzzz_, gzzzzzzzzzzzzzzzzzzzzzza_);
                        CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Interval(fzzzzzzzzzzzzzzzzzzzzzzw_, gzzzzzzzzzzzzzzzzzzzzzzb_, true, true);
                        bool? gzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(fzzzzzzzzzzzzzzzzzzzzzzr_, gzzzzzzzzzzzzzzzzzzzzzzc_, default);
                        Code<ObservationStatus> gzzzzzzzzzzzzzzzzzzzzzze_ = O2Saturation?.StatusElement;
                        ObservationStatus? gzzzzzzzzzzzzzzzzzzzzzzf_ = gzzzzzzzzzzzzzzzzzzzzzze_?.Value;
                        Code<ObservationStatus> gzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<Code<ObservationStatus>>(gzzzzzzzzzzzzzzzzzzzzzzf_);
                        string gzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Convert<string>(gzzzzzzzzzzzzzzzzzzzzzzg_);
                        string[] gzzzzzzzzzzzzzzzzzzzzzzi_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? gzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.In<string>(gzzzzzzzzzzzzzzzzzzzzzzh_, gzzzzzzzzzzzzzzzzzzzzzzi_ as IEnumerable<string>);
                        bool? gzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzzd_, gzzzzzzzzzzzzzzzzzzzzzzj_);
                        DataType gzzzzzzzzzzzzzzzzzzzzzzl_ = O2Saturation?.Value;
                        object gzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzl_);
                        bool? gzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Not((bool?)(gzzzzzzzzzzzzzzzzzzzzzzm_ is null));
                        bool? gzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzzk_, gzzzzzzzzzzzzzzzzzzzzzzn_);

                        return gzzzzzzzzzzzzzzzzzzzzzzo_;
                    };
                    IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Observation>(fzzzzzzzzzzzzzzzzzzzzzzh_, fzzzzzzzzzzzzzzzzzzzzzzi_);
                    object fzzzzzzzzzzzzzzzzzzzzzzk_(Observation @this)
                    {
                        object hzzzzzzzzzzzzzzzzzzzzzzh_()
                        {
                            bool hzzzzzzzzzzzzzzzzzzzzzzj_()
                            {
                                DataType hzzzzzzzzzzzzzzzzzzzzzzm_ = @this?.Effective;
                                object hzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzm_);
                                bool hzzzzzzzzzzzzzzzzzzzzzzo_ = hzzzzzzzzzzzzzzzzzzzzzzn_ is CqlDateTime;

                                return hzzzzzzzzzzzzzzzzzzzzzzo_;
                            };
                            bool hzzzzzzzzzzzzzzzzzzzzzzk_()
                            {
                                DataType hzzzzzzzzzzzzzzzzzzzzzzp_ = @this?.Effective;
                                object hzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzp_);
                                bool hzzzzzzzzzzzzzzzzzzzzzzr_ = hzzzzzzzzzzzzzzzzzzzzzzq_ is CqlInterval<CqlDateTime>;

                                return hzzzzzzzzzzzzzzzzzzzzzzr_;
                            };
                            bool hzzzzzzzzzzzzzzzzzzzzzzl_()
                            {
                                DataType hzzzzzzzzzzzzzzzzzzzzzzs_ = @this?.Effective;
                                object hzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzs_);
                                bool hzzzzzzzzzzzzzzzzzzzzzzu_ = hzzzzzzzzzzzzzzzzzzzzzzt_ is CqlDateTime;

                                return hzzzzzzzzzzzzzzzzzzzzzzu_;
                            };
                            if (hzzzzzzzzzzzzzzzzzzzzzzj_())
                            {
                                DataType hzzzzzzzzzzzzzzzzzzzzzzv_ = @this?.Effective;
                                object hzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzv_);

                                return (hzzzzzzzzzzzzzzzzzzzzzzw_ as CqlDateTime) as object;
                            }
                            else if (hzzzzzzzzzzzzzzzzzzzzzzk_())
                            {
                                DataType hzzzzzzzzzzzzzzzzzzzzzzx_ = @this?.Effective;
                                object hzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzx_);

                                return (hzzzzzzzzzzzzzzzzzzzzzzy_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (hzzzzzzzzzzzzzzzzzzzzzzl_())
                            {
                                DataType hzzzzzzzzzzzzzzzzzzzzzzz_ = @this?.Effective;
                                object izzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzz_);

                                return (izzzzzzzzzzzzzzzzzzzzzza_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.earliest(context, hzzzzzzzzzzzzzzzzzzzzzzh_());

                        return hzzzzzzzzzzzzzzzzzzzzzzi_;
                    };
                    IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.SortBy<Observation>(fzzzzzzzzzzzzzzzzzzzzzzj_, fzzzzzzzzzzzzzzzzzzzzzzk_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation fzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.First<Observation>(fzzzzzzzzzzzzzzzzzzzzzzl_);
                    DataType fzzzzzzzzzzzzzzzzzzzzzzn_ = fzzzzzzzzzzzzzzzzzzzzzzm_?.Effective;
                    object fzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzn_);
                    bool fzzzzzzzzzzzzzzzzzzzzzzp_ = fzzzzzzzzzzzzzzzzzzzzzzo_ is CqlDateTime;

                    return fzzzzzzzzzzzzzzzzzzzzzzp_;
                };
                if (zzzzzzzzzzzzzzzzzzzzzzn_())
                {
                    CqlValueSet izzzzzzzzzzzzzzzzzzzzzzb_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
                    IEnumerable<Observation> izzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, izzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? izzzzzzzzzzzzzzzzzzzzzzd_(Observation O2Saturation)
                    {
                        object izzzzzzzzzzzzzzzzzzzzzzk_()
                        {
                            bool jzzzzzzzzzzzzzzzzzzzzzzj_()
                            {
                                DataType jzzzzzzzzzzzzzzzzzzzzzzm_ = O2Saturation?.Effective;
                                object jzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzm_);
                                bool jzzzzzzzzzzzzzzzzzzzzzzo_ = jzzzzzzzzzzzzzzzzzzzzzzn_ is CqlDateTime;

                                return jzzzzzzzzzzzzzzzzzzzzzzo_;
                            };
                            bool jzzzzzzzzzzzzzzzzzzzzzzk_()
                            {
                                DataType jzzzzzzzzzzzzzzzzzzzzzzp_ = O2Saturation?.Effective;
                                object jzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzp_);
                                bool jzzzzzzzzzzzzzzzzzzzzzzr_ = jzzzzzzzzzzzzzzzzzzzzzzq_ is CqlInterval<CqlDateTime>;

                                return jzzzzzzzzzzzzzzzzzzzzzzr_;
                            };
                            bool jzzzzzzzzzzzzzzzzzzzzzzl_()
                            {
                                DataType jzzzzzzzzzzzzzzzzzzzzzzs_ = O2Saturation?.Effective;
                                object jzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzs_);
                                bool jzzzzzzzzzzzzzzzzzzzzzzu_ = jzzzzzzzzzzzzzzzzzzzzzzt_ is CqlDateTime;

                                return jzzzzzzzzzzzzzzzzzzzzzzu_;
                            };
                            if (jzzzzzzzzzzzzzzzzzzzzzzj_())
                            {
                                DataType jzzzzzzzzzzzzzzzzzzzzzzv_ = O2Saturation?.Effective;
                                object jzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzv_);

                                return (jzzzzzzzzzzzzzzzzzzzzzzw_ as CqlDateTime) as object;
                            }
                            else if (jzzzzzzzzzzzzzzzzzzzzzzk_())
                            {
                                DataType jzzzzzzzzzzzzzzzzzzzzzzx_ = O2Saturation?.Effective;
                                object jzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzx_);

                                return (jzzzzzzzzzzzzzzzzzzzzzzy_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (jzzzzzzzzzzzzzzzzzzzzzzl_())
                            {
                                DataType jzzzzzzzzzzzzzzzzzzzzzzz_ = O2Saturation?.Effective;
                                object kzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzz_);

                                return (kzzzzzzzzzzzzzzzzzzzzzza_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime izzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.earliest(context, izzzzzzzzzzzzzzzzzzzzzzk_());
                        Period izzzzzzzzzzzzzzzzzzzzzzm_ = EncounterInpatient?.Period;
                        CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzzzzzzzzzzzzzm_);
                        CqlDateTime izzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Start(izzzzzzzzzzzzzzzzzzzzzzn_);
                        CqlQuantity izzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Quantity(1440m, "minutes");
                        CqlDateTime izzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Subtract(izzzzzzzzzzzzzzzzzzzzzzo_, izzzzzzzzzzzzzzzzzzzzzzp_);
                        CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzzzzzzzzzzzzzm_);
                        CqlDateTime izzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(izzzzzzzzzzzzzzzzzzzzzzs_);
                        CqlQuantity izzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Quantity(120m, "minutes");
                        CqlDateTime izzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Add(izzzzzzzzzzzzzzzzzzzzzzt_, izzzzzzzzzzzzzzzzzzzzzzu_);
                        CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Interval(izzzzzzzzzzzzzzzzzzzzzzq_, izzzzzzzzzzzzzzzzzzzzzzv_, true, true);
                        bool? izzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.In<CqlDateTime>(izzzzzzzzzzzzzzzzzzzzzzl_, izzzzzzzzzzzzzzzzzzzzzzw_, default);
                        Code<ObservationStatus> izzzzzzzzzzzzzzzzzzzzzzy_ = O2Saturation?.StatusElement;
                        ObservationStatus? izzzzzzzzzzzzzzzzzzzzzzz_ = izzzzzzzzzzzzzzzzzzzzzzy_?.Value;
                        Code<ObservationStatus> jzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<Code<ObservationStatus>>(izzzzzzzzzzzzzzzzzzzzzzz_);
                        string jzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Convert<string>(jzzzzzzzzzzzzzzzzzzzzzza_);
                        string[] jzzzzzzzzzzzzzzzzzzzzzzc_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? jzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<string>(jzzzzzzzzzzzzzzzzzzzzzzb_, jzzzzzzzzzzzzzzzzzzzzzzc_ as IEnumerable<string>);
                        bool? jzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzx_, jzzzzzzzzzzzzzzzzzzzzzzd_);
                        DataType jzzzzzzzzzzzzzzzzzzzzzzf_ = O2Saturation?.Value;
                        object jzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzf_);
                        bool? jzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Not((bool?)(jzzzzzzzzzzzzzzzzzzzzzzg_ is null));
                        bool? jzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzzze_, jzzzzzzzzzzzzzzzzzzzzzzh_);

                        return jzzzzzzzzzzzzzzzzzzzzzzi_;
                    };
                    IEnumerable<Observation> izzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Observation>(izzzzzzzzzzzzzzzzzzzzzzc_, izzzzzzzzzzzzzzzzzzzzzzd_);
                    object izzzzzzzzzzzzzzzzzzzzzzf_(Observation @this)
                    {
                        object kzzzzzzzzzzzzzzzzzzzzzzb_()
                        {
                            bool kzzzzzzzzzzzzzzzzzzzzzzd_()
                            {
                                DataType kzzzzzzzzzzzzzzzzzzzzzzg_ = @this?.Effective;
                                object kzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzg_);
                                bool kzzzzzzzzzzzzzzzzzzzzzzi_ = kzzzzzzzzzzzzzzzzzzzzzzh_ is CqlDateTime;

                                return kzzzzzzzzzzzzzzzzzzzzzzi_;
                            };
                            bool kzzzzzzzzzzzzzzzzzzzzzze_()
                            {
                                DataType kzzzzzzzzzzzzzzzzzzzzzzj_ = @this?.Effective;
                                object kzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzj_);
                                bool kzzzzzzzzzzzzzzzzzzzzzzl_ = kzzzzzzzzzzzzzzzzzzzzzzk_ is CqlInterval<CqlDateTime>;

                                return kzzzzzzzzzzzzzzzzzzzzzzl_;
                            };
                            bool kzzzzzzzzzzzzzzzzzzzzzzf_()
                            {
                                DataType kzzzzzzzzzzzzzzzzzzzzzzm_ = @this?.Effective;
                                object kzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzm_);
                                bool kzzzzzzzzzzzzzzzzzzzzzzo_ = kzzzzzzzzzzzzzzzzzzzzzzn_ is CqlDateTime;

                                return kzzzzzzzzzzzzzzzzzzzzzzo_;
                            };
                            if (kzzzzzzzzzzzzzzzzzzzzzzd_())
                            {
                                DataType kzzzzzzzzzzzzzzzzzzzzzzp_ = @this?.Effective;
                                object kzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzp_);

                                return (kzzzzzzzzzzzzzzzzzzzzzzq_ as CqlDateTime) as object;
                            }
                            else if (kzzzzzzzzzzzzzzzzzzzzzze_())
                            {
                                DataType kzzzzzzzzzzzzzzzzzzzzzzr_ = @this?.Effective;
                                object kzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzr_);

                                return (kzzzzzzzzzzzzzzzzzzzzzzs_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (kzzzzzzzzzzzzzzzzzzzzzzf_())
                            {
                                DataType kzzzzzzzzzzzzzzzzzzzzzzt_ = @this?.Effective;
                                object kzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzt_);

                                return (kzzzzzzzzzzzzzzzzzzzzzzu_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.earliest(context, kzzzzzzzzzzzzzzzzzzzzzzb_());

                        return kzzzzzzzzzzzzzzzzzzzzzzc_;
                    };
                    IEnumerable<Observation> izzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.SortBy<Observation>(izzzzzzzzzzzzzzzzzzzzzze_, izzzzzzzzzzzzzzzzzzzzzzf_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation izzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.First<Observation>(izzzzzzzzzzzzzzzzzzzzzzg_);
                    DataType izzzzzzzzzzzzzzzzzzzzzzi_ = izzzzzzzzzzzzzzzzzzzzzzh_?.Effective;
                    object izzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzi_);

                    return (izzzzzzzzzzzzzzzzzzzzzzj_ as CqlDateTime) as object;
                }
                else if (zzzzzzzzzzzzzzzzzzzzzzo_())
                {
                    CqlValueSet kzzzzzzzzzzzzzzzzzzzzzzv_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
                    IEnumerable<Observation> kzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? kzzzzzzzzzzzzzzzzzzzzzzx_(Observation O2Saturation)
                    {
                        object lzzzzzzzzzzzzzzzzzzzzzze_()
                        {
                            bool mzzzzzzzzzzzzzzzzzzzzzzd_()
                            {
                                DataType mzzzzzzzzzzzzzzzzzzzzzzg_ = O2Saturation?.Effective;
                                object mzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzg_);
                                bool mzzzzzzzzzzzzzzzzzzzzzzi_ = mzzzzzzzzzzzzzzzzzzzzzzh_ is CqlDateTime;

                                return mzzzzzzzzzzzzzzzzzzzzzzi_;
                            };
                            bool mzzzzzzzzzzzzzzzzzzzzzze_()
                            {
                                DataType mzzzzzzzzzzzzzzzzzzzzzzj_ = O2Saturation?.Effective;
                                object mzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzj_);
                                bool mzzzzzzzzzzzzzzzzzzzzzzl_ = mzzzzzzzzzzzzzzzzzzzzzzk_ is CqlInterval<CqlDateTime>;

                                return mzzzzzzzzzzzzzzzzzzzzzzl_;
                            };
                            bool mzzzzzzzzzzzzzzzzzzzzzzf_()
                            {
                                DataType mzzzzzzzzzzzzzzzzzzzzzzm_ = O2Saturation?.Effective;
                                object mzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzm_);
                                bool mzzzzzzzzzzzzzzzzzzzzzzo_ = mzzzzzzzzzzzzzzzzzzzzzzn_ is CqlDateTime;

                                return mzzzzzzzzzzzzzzzzzzzzzzo_;
                            };
                            if (mzzzzzzzzzzzzzzzzzzzzzzd_())
                            {
                                DataType mzzzzzzzzzzzzzzzzzzzzzzp_ = O2Saturation?.Effective;
                                object mzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzp_);

                                return (mzzzzzzzzzzzzzzzzzzzzzzq_ as CqlDateTime) as object;
                            }
                            else if (mzzzzzzzzzzzzzzzzzzzzzze_())
                            {
                                DataType mzzzzzzzzzzzzzzzzzzzzzzr_ = O2Saturation?.Effective;
                                object mzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzr_);

                                return (mzzzzzzzzzzzzzzzzzzzzzzs_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (mzzzzzzzzzzzzzzzzzzzzzzf_())
                            {
                                DataType mzzzzzzzzzzzzzzzzzzzzzzt_ = O2Saturation?.Effective;
                                object mzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzt_);

                                return (mzzzzzzzzzzzzzzzzzzzzzzu_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.earliest(context, lzzzzzzzzzzzzzzzzzzzzzze_());
                        Period lzzzzzzzzzzzzzzzzzzzzzzg_ = EncounterInpatient?.Period;
                        CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzzzzzzzzzzzzzg_);
                        CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzzzzzzh_);
                        CqlQuantity lzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Quantity(1440m, "minutes");
                        CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Subtract(lzzzzzzzzzzzzzzzzzzzzzzi_, lzzzzzzzzzzzzzzzzzzzzzzj_);
                        CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzzzzzzzzzzzzzg_);
                        CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzzzzzzm_);
                        CqlQuantity lzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Quantity(120m, "minutes");
                        CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Add(lzzzzzzzzzzzzzzzzzzzzzzn_, lzzzzzzzzzzzzzzzzzzzzzzo_);
                        CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Interval(lzzzzzzzzzzzzzzzzzzzzzzk_, lzzzzzzzzzzzzzzzzzzzzzzp_, true, true);
                        bool? lzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(lzzzzzzzzzzzzzzzzzzzzzzf_, lzzzzzzzzzzzzzzzzzzzzzzq_, default);
                        Code<ObservationStatus> lzzzzzzzzzzzzzzzzzzzzzzs_ = O2Saturation?.StatusElement;
                        ObservationStatus? lzzzzzzzzzzzzzzzzzzzzzzt_ = lzzzzzzzzzzzzzzzzzzzzzzs_?.Value;
                        Code<ObservationStatus> lzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Convert<Code<ObservationStatus>>(lzzzzzzzzzzzzzzzzzzzzzzt_);
                        string lzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Convert<string>(lzzzzzzzzzzzzzzzzzzzzzzu_);
                        string[] lzzzzzzzzzzzzzzzzzzzzzzw_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? lzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.In<string>(lzzzzzzzzzzzzzzzzzzzzzzv_, lzzzzzzzzzzzzzzzzzzzzzzw_ as IEnumerable<string>);
                        bool? lzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzr_, lzzzzzzzzzzzzzzzzzzzzzzx_);
                        DataType lzzzzzzzzzzzzzzzzzzzzzzz_ = O2Saturation?.Value;
                        object mzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzz_);
                        bool? mzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Not((bool?)(mzzzzzzzzzzzzzzzzzzzzzza_ is null));
                        bool? mzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzy_, mzzzzzzzzzzzzzzzzzzzzzzb_);

                        return mzzzzzzzzzzzzzzzzzzzzzzc_;
                    };
                    IEnumerable<Observation> kzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Observation>(kzzzzzzzzzzzzzzzzzzzzzzw_, kzzzzzzzzzzzzzzzzzzzzzzx_);
                    object kzzzzzzzzzzzzzzzzzzzzzzz_(Observation @this)
                    {
                        object mzzzzzzzzzzzzzzzzzzzzzzv_()
                        {
                            bool mzzzzzzzzzzzzzzzzzzzzzzx_()
                            {
                                DataType nzzzzzzzzzzzzzzzzzzzzzza_ = @this?.Effective;
                                object nzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzza_);
                                bool nzzzzzzzzzzzzzzzzzzzzzzc_ = nzzzzzzzzzzzzzzzzzzzzzzb_ is CqlDateTime;

                                return nzzzzzzzzzzzzzzzzzzzzzzc_;
                            };
                            bool mzzzzzzzzzzzzzzzzzzzzzzy_()
                            {
                                DataType nzzzzzzzzzzzzzzzzzzzzzzd_ = @this?.Effective;
                                object nzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzd_);
                                bool nzzzzzzzzzzzzzzzzzzzzzzf_ = nzzzzzzzzzzzzzzzzzzzzzze_ is CqlInterval<CqlDateTime>;

                                return nzzzzzzzzzzzzzzzzzzzzzzf_;
                            };
                            bool mzzzzzzzzzzzzzzzzzzzzzzz_()
                            {
                                DataType nzzzzzzzzzzzzzzzzzzzzzzg_ = @this?.Effective;
                                object nzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzg_);
                                bool nzzzzzzzzzzzzzzzzzzzzzzi_ = nzzzzzzzzzzzzzzzzzzzzzzh_ is CqlDateTime;

                                return nzzzzzzzzzzzzzzzzzzzzzzi_;
                            };
                            if (mzzzzzzzzzzzzzzzzzzzzzzx_())
                            {
                                DataType nzzzzzzzzzzzzzzzzzzzzzzj_ = @this?.Effective;
                                object nzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzj_);

                                return (nzzzzzzzzzzzzzzzzzzzzzzk_ as CqlDateTime) as object;
                            }
                            else if (mzzzzzzzzzzzzzzzzzzzzzzy_())
                            {
                                DataType nzzzzzzzzzzzzzzzzzzzzzzl_ = @this?.Effective;
                                object nzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzl_);

                                return (nzzzzzzzzzzzzzzzzzzzzzzm_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (mzzzzzzzzzzzzzzzzzzzzzzz_())
                            {
                                DataType nzzzzzzzzzzzzzzzzzzzzzzn_ = @this?.Effective;
                                object nzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzn_);

                                return (nzzzzzzzzzzzzzzzzzzzzzzo_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.earliest(context, mzzzzzzzzzzzzzzzzzzzzzzv_());

                        return mzzzzzzzzzzzzzzzzzzzzzzw_;
                    };
                    IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.SortBy<Observation>(kzzzzzzzzzzzzzzzzzzzzzzy_, kzzzzzzzzzzzzzzzzzzzzzzz_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation lzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.First<Observation>(lzzzzzzzzzzzzzzzzzzzzzza_);
                    DataType lzzzzzzzzzzzzzzzzzzzzzzc_ = lzzzzzzzzzzzzzzzzzzzzzzb_?.Effective;
                    object lzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzc_);

                    return (lzzzzzzzzzzzzzzzzzzzzzzd_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (zzzzzzzzzzzzzzzzzzzzzzp_())
                {
                    CqlValueSet nzzzzzzzzzzzzzzzzzzzzzzp_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
                    IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? nzzzzzzzzzzzzzzzzzzzzzzr_(Observation O2Saturation)
                    {
                        object nzzzzzzzzzzzzzzzzzzzzzzy_()
                        {
                            bool ozzzzzzzzzzzzzzzzzzzzzzx_()
                            {
                                DataType pzzzzzzzzzzzzzzzzzzzzzza_ = O2Saturation?.Effective;
                                object pzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzza_);
                                bool pzzzzzzzzzzzzzzzzzzzzzzc_ = pzzzzzzzzzzzzzzzzzzzzzzb_ is CqlDateTime;

                                return pzzzzzzzzzzzzzzzzzzzzzzc_;
                            };
                            bool ozzzzzzzzzzzzzzzzzzzzzzy_()
                            {
                                DataType pzzzzzzzzzzzzzzzzzzzzzzd_ = O2Saturation?.Effective;
                                object pzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzd_);
                                bool pzzzzzzzzzzzzzzzzzzzzzzf_ = pzzzzzzzzzzzzzzzzzzzzzze_ is CqlInterval<CqlDateTime>;

                                return pzzzzzzzzzzzzzzzzzzzzzzf_;
                            };
                            bool ozzzzzzzzzzzzzzzzzzzzzzz_()
                            {
                                DataType pzzzzzzzzzzzzzzzzzzzzzzg_ = O2Saturation?.Effective;
                                object pzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzg_);
                                bool pzzzzzzzzzzzzzzzzzzzzzzi_ = pzzzzzzzzzzzzzzzzzzzzzzh_ is CqlDateTime;

                                return pzzzzzzzzzzzzzzzzzzzzzzi_;
                            };
                            if (ozzzzzzzzzzzzzzzzzzzzzzx_())
                            {
                                DataType pzzzzzzzzzzzzzzzzzzzzzzj_ = O2Saturation?.Effective;
                                object pzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzj_);

                                return (pzzzzzzzzzzzzzzzzzzzzzzk_ as CqlDateTime) as object;
                            }
                            else if (ozzzzzzzzzzzzzzzzzzzzzzy_())
                            {
                                DataType pzzzzzzzzzzzzzzzzzzzzzzl_ = O2Saturation?.Effective;
                                object pzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzl_);

                                return (pzzzzzzzzzzzzzzzzzzzzzzm_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (ozzzzzzzzzzzzzzzzzzzzzzz_())
                            {
                                DataType pzzzzzzzzzzzzzzzzzzzzzzn_ = O2Saturation?.Effective;
                                object pzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzn_);

                                return (pzzzzzzzzzzzzzzzzzzzzzzo_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.earliest(context, nzzzzzzzzzzzzzzzzzzzzzzy_());
                        Period ozzzzzzzzzzzzzzzzzzzzzza_ = EncounterInpatient?.Period;
                        CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzzzzzzzzzzzzzza_);
                        CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzzzzb_);
                        CqlQuantity ozzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Quantity(1440m, "minutes");
                        CqlDateTime ozzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Subtract(ozzzzzzzzzzzzzzzzzzzzzzc_, ozzzzzzzzzzzzzzzzzzzzzzd_);
                        CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzzzzzzzzzzzzzza_);
                        CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzzzzg_);
                        CqlQuantity ozzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Quantity(120m, "minutes");
                        CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Add(ozzzzzzzzzzzzzzzzzzzzzzh_, ozzzzzzzzzzzzzzzzzzzzzzi_);
                        CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Interval(ozzzzzzzzzzzzzzzzzzzzzze_, ozzzzzzzzzzzzzzzzzzzzzzj_, true, true);
                        bool? ozzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.In<CqlDateTime>(nzzzzzzzzzzzzzzzzzzzzzzz_, ozzzzzzzzzzzzzzzzzzzzzzk_, default);
                        Code<ObservationStatus> ozzzzzzzzzzzzzzzzzzzzzzm_ = O2Saturation?.StatusElement;
                        ObservationStatus? ozzzzzzzzzzzzzzzzzzzzzzn_ = ozzzzzzzzzzzzzzzzzzzzzzm_?.Value;
                        Code<ObservationStatus> ozzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Convert<Code<ObservationStatus>>(ozzzzzzzzzzzzzzzzzzzzzzn_);
                        string ozzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Convert<string>(ozzzzzzzzzzzzzzzzzzzzzzo_);
                        string[] ozzzzzzzzzzzzzzzzzzzzzzq_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? ozzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.In<string>(ozzzzzzzzzzzzzzzzzzzzzzp_, ozzzzzzzzzzzzzzzzzzzzzzq_ as IEnumerable<string>);
                        bool? ozzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzl_, ozzzzzzzzzzzzzzzzzzzzzzr_);
                        DataType ozzzzzzzzzzzzzzzzzzzzzzt_ = O2Saturation?.Value;
                        object ozzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzt_);
                        bool? ozzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Not((bool?)(ozzzzzzzzzzzzzzzzzzzzzzu_ is null));
                        bool? ozzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzs_, ozzzzzzzzzzzzzzzzzzzzzzv_);

                        return ozzzzzzzzzzzzzzzzzzzzzzw_;
                    };
                    IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Observation>(nzzzzzzzzzzzzzzzzzzzzzzq_, nzzzzzzzzzzzzzzzzzzzzzzr_);
                    object nzzzzzzzzzzzzzzzzzzzzzzt_(Observation @this)
                    {
                        object pzzzzzzzzzzzzzzzzzzzzzzp_()
                        {
                            bool pzzzzzzzzzzzzzzzzzzzzzzr_()
                            {
                                DataType pzzzzzzzzzzzzzzzzzzzzzzu_ = @this?.Effective;
                                object pzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzu_);
                                bool pzzzzzzzzzzzzzzzzzzzzzzw_ = pzzzzzzzzzzzzzzzzzzzzzzv_ is CqlDateTime;

                                return pzzzzzzzzzzzzzzzzzzzzzzw_;
                            };
                            bool pzzzzzzzzzzzzzzzzzzzzzzs_()
                            {
                                DataType pzzzzzzzzzzzzzzzzzzzzzzx_ = @this?.Effective;
                                object pzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzx_);
                                bool pzzzzzzzzzzzzzzzzzzzzzzz_ = pzzzzzzzzzzzzzzzzzzzzzzy_ is CqlInterval<CqlDateTime>;

                                return pzzzzzzzzzzzzzzzzzzzzzzz_;
                            };
                            bool pzzzzzzzzzzzzzzzzzzzzzzt_()
                            {
                                DataType qzzzzzzzzzzzzzzzzzzzzzza_ = @this?.Effective;
                                object qzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzza_);
                                bool qzzzzzzzzzzzzzzzzzzzzzzc_ = qzzzzzzzzzzzzzzzzzzzzzzb_ is CqlDateTime;

                                return qzzzzzzzzzzzzzzzzzzzzzzc_;
                            };
                            if (pzzzzzzzzzzzzzzzzzzzzzzr_())
                            {
                                DataType qzzzzzzzzzzzzzzzzzzzzzzd_ = @this?.Effective;
                                object qzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzd_);

                                return (qzzzzzzzzzzzzzzzzzzzzzze_ as CqlDateTime) as object;
                            }
                            else if (pzzzzzzzzzzzzzzzzzzzzzzs_())
                            {
                                DataType qzzzzzzzzzzzzzzzzzzzzzzf_ = @this?.Effective;
                                object qzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzf_);

                                return (qzzzzzzzzzzzzzzzzzzzzzzg_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (pzzzzzzzzzzzzzzzzzzzzzzt_())
                            {
                                DataType qzzzzzzzzzzzzzzzzzzzzzzh_ = @this?.Effective;
                                object qzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzh_);

                                return (qzzzzzzzzzzzzzzzzzzzzzzi_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.earliest(context, pzzzzzzzzzzzzzzzzzzzzzzp_());

                        return pzzzzzzzzzzzzzzzzzzzzzzq_;
                    };
                    IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.SortBy<Observation>(nzzzzzzzzzzzzzzzzzzzzzzs_, nzzzzzzzzzzzzzzzzzzzzzzt_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation nzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.First<Observation>(nzzzzzzzzzzzzzzzzzzzzzzu_);
                    DataType nzzzzzzzzzzzzzzzzzzzzzzw_ = nzzzzzzzzzzzzzzzzzzzzzzv_?.Effective;
                    object nzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzw_);

                    return (nzzzzzzzzzzzzzzzzzzzzzzx_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.earliest(context, wzzzzzzzzzzzzzzzzzzzzzz_());
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)? xzzzzzzzzzzzzzzzzzzzzzb_ = (CqlTupleMetadata_FdREYEdHOZIcMCNYCRFJYJReA, wzzzzzzzzzzzzzzzzzzzzzp_, wzzzzzzzzzzzzzzzzzzzzzy_ as CqlQuantity, xzzzzzzzzzzzzzzzzzzzzza_);

            return xzzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)?> wzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)?>(wzzzzzzzzzzzzzzzzzzzzzk_, wzzzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)?> wzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)?>(wzzzzzzzzzzzzzzzzzzzzzm_);

        return wzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with First Bicarbonate Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)?> Encounter_with_First_Bicarbonate_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzj_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)? qzzzzzzzzzzzzzzzzzzzzzzk_(Encounter EncounterInpatient)
        {
            Id qzzzzzzzzzzzzzzzzzzzzzzn_ = EncounterInpatient?.IdElement;
            string qzzzzzzzzzzzzzzzzzzzzzzo_ = qzzzzzzzzzzzzzzzzzzzzzzn_?.Value;
            CqlValueSet qzzzzzzzzzzzzzzzzzzzzzzp_ = this.Bicarbonate_lab_test(context);
            IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? qzzzzzzzzzzzzzzzzzzzzzzr_(Observation BicarbonateLab)
            {
                Instant rzzzzzzzzzzzzzzzzzzzzzzj_ = BicarbonateLab?.IssuedElement;
                DateTimeOffset? rzzzzzzzzzzzzzzzzzzzzzzk_ = rzzzzzzzzzzzzzzzzzzzzzzj_?.Value;
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.earliest(context, rzzzzzzzzzzzzzzzzzzzzzzl_ as object);
                Period rzzzzzzzzzzzzzzzzzzzzzzn_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(rzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlQuantity rzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Subtract(rzzzzzzzzzzzzzzzzzzzzzzp_, rzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(rzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Add(rzzzzzzzzzzzzzzzzzzzzzzu_, rzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Interval(rzzzzzzzzzzzzzzzzzzzzzzr_, rzzzzzzzzzzzzzzzzzzzzzzw_, true, true);
                bool? rzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzzzzm_, rzzzzzzzzzzzzzzzzzzzzzzx_, default);
                Code<ObservationStatus> rzzzzzzzzzzzzzzzzzzzzzzz_ = BicarbonateLab?.StatusElement;
                ObservationStatus? szzzzzzzzzzzzzzzzzzzzzza_ = rzzzzzzzzzzzzzzzzzzzzzzz_?.Value;
                string szzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Convert<string>(szzzzzzzzzzzzzzzzzzzzzza_);
                string[] szzzzzzzzzzzzzzzzzzzzzzc_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? szzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<string>(szzzzzzzzzzzzzzzzzzzzzzb_, szzzzzzzzzzzzzzzzzzzzzzc_ as IEnumerable<string>);
                bool? szzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzzzy_, szzzzzzzzzzzzzzzzzzzzzzd_);
                DataType szzzzzzzzzzzzzzzzzzzzzzf_ = BicarbonateLab?.Value;
                object szzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzf_);
                bool? szzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Not((bool?)(szzzzzzzzzzzzzzzzzzzzzzg_ is null));
                bool? szzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzze_, szzzzzzzzzzzzzzzzzzzzzzh_);

                return szzzzzzzzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Observation>(qzzzzzzzzzzzzzzzzzzzzzzq_, qzzzzzzzzzzzzzzzzzzzzzzr_);
            object qzzzzzzzzzzzzzzzzzzzzzzt_(Observation @this)
            {
                Instant szzzzzzzzzzzzzzzzzzzzzzj_ = @this?.IssuedElement;
                DateTimeOffset? szzzzzzzzzzzzzzzzzzzzzzk_ = szzzzzzzzzzzzzzzzzzzzzzj_?.Value;
                CqlDateTime szzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<CqlDateTime>(szzzzzzzzzzzzzzzzzzzzzzk_);
                CqlDateTime szzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.earliest(context, szzzzzzzzzzzzzzzzzzzzzzl_ as object);

                return szzzzzzzzzzzzzzzzzzzzzzm_;
            };
            IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.SortBy<Observation>(qzzzzzzzzzzzzzzzzzzzzzzs_, qzzzzzzzzzzzzzzzzzzzzzzt_, System.ComponentModel.ListSortDirection.Ascending);
            Observation qzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.First<Observation>(qzzzzzzzzzzzzzzzzzzzzzzu_);
            DataType qzzzzzzzzzzzzzzzzzzzzzzw_ = qzzzzzzzzzzzzzzzzzzzzzzv_?.Value;
            object qzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzw_);
            IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? rzzzzzzzzzzzzzzzzzzzzzza_(Observation BicarbonateLab)
            {
                Instant szzzzzzzzzzzzzzzzzzzzzzn_ = BicarbonateLab?.IssuedElement;
                DateTimeOffset? szzzzzzzzzzzzzzzzzzzzzzo_ = szzzzzzzzzzzzzzzzzzzzzzn_?.Value;
                CqlDateTime szzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Convert<CqlDateTime>(szzzzzzzzzzzzzzzzzzzzzzo_);
                CqlDateTime szzzzzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.earliest(context, szzzzzzzzzzzzzzzzzzzzzzp_ as object);
                Period szzzzzzzzzzzzzzzzzzzzzzr_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzzzzzzzzzzzzzzzzr_);
                CqlDateTime szzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(szzzzzzzzzzzzzzzzzzzzzzs_);
                CqlQuantity szzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime szzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Subtract(szzzzzzzzzzzzzzzzzzzzzzt_, szzzzzzzzzzzzzzzzzzzzzzu_);
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzzzzzzzzzzzzzzzzr_);
                CqlDateTime szzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(szzzzzzzzzzzzzzzzzzzzzzx_);
                CqlDateTime tzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Add(szzzzzzzzzzzzzzzzzzzzzzy_, szzzzzzzzzzzzzzzzzzzzzzu_);
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Interval(szzzzzzzzzzzzzzzzzzzzzzv_, tzzzzzzzzzzzzzzzzzzzzzza_, true, true);
                bool? tzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.In<CqlDateTime>(szzzzzzzzzzzzzzzzzzzzzzq_, tzzzzzzzzzzzzzzzzzzzzzzb_, default);
                Code<ObservationStatus> tzzzzzzzzzzzzzzzzzzzzzzd_ = BicarbonateLab?.StatusElement;
                ObservationStatus? tzzzzzzzzzzzzzzzzzzzzzze_ = tzzzzzzzzzzzzzzzzzzzzzzd_?.Value;
                string tzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<string>(tzzzzzzzzzzzzzzzzzzzzzze_);
                string[] tzzzzzzzzzzzzzzzzzzzzzzg_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? tzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.In<string>(tzzzzzzzzzzzzzzzzzzzzzzf_, tzzzzzzzzzzzzzzzzzzzzzzg_ as IEnumerable<string>);
                bool? tzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzc_, tzzzzzzzzzzzzzzzzzzzzzzh_);
                DataType tzzzzzzzzzzzzzzzzzzzzzzj_ = BicarbonateLab?.Value;
                object tzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzj_);
                bool? tzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Not((bool?)(tzzzzzzzzzzzzzzzzzzzzzzk_ is null));
                bool? tzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzi_, tzzzzzzzzzzzzzzzzzzzzzzl_);

                return tzzzzzzzzzzzzzzzzzzzzzzm_;
            };
            IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Observation>(qzzzzzzzzzzzzzzzzzzzzzzz_, rzzzzzzzzzzzzzzzzzzzzzza_);
            object rzzzzzzzzzzzzzzzzzzzzzzc_(Observation @this)
            {
                Instant tzzzzzzzzzzzzzzzzzzzzzzn_ = @this?.IssuedElement;
                DateTimeOffset? tzzzzzzzzzzzzzzzzzzzzzzo_ = tzzzzzzzzzzzzzzzzzzzzzzn_?.Value;
                CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Convert<CqlDateTime>(tzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.earliest(context, tzzzzzzzzzzzzzzzzzzzzzzp_ as object);

                return tzzzzzzzzzzzzzzzzzzzzzzq_;
            };
            IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.SortBy<Observation>(rzzzzzzzzzzzzzzzzzzzzzzb_, rzzzzzzzzzzzzzzzzzzzzzzc_, System.ComponentModel.ListSortDirection.Ascending);
            Observation rzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.First<Observation>(rzzzzzzzzzzzzzzzzzzzzzzd_);
            Instant rzzzzzzzzzzzzzzzzzzzzzzf_ = rzzzzzzzzzzzzzzzzzzzzzze_?.IssuedElement;
            DateTimeOffset? rzzzzzzzzzzzzzzzzzzzzzzg_ = rzzzzzzzzzzzzzzzzzzzzzzf_?.Value;
            CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Convert<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzzzzg_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)? rzzzzzzzzzzzzzzzzzzzzzzi_ = (CqlTupleMetadata_GbUHPXXHScejjXWhcHJFQQifQ, qzzzzzzzzzzzzzzzzzzzzzzo_, qzzzzzzzzzzzzzzzzzzzzzzx_ as CqlQuantity, rzzzzzzzzzzzzzzzzzzzzzzh_);

            return rzzzzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)?> qzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)?>(qzzzzzzzzzzzzzzzzzzzzzzj_, qzzzzzzzzzzzzzzzzzzzzzzk_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)?> qzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstBicarbonateResult, CqlDateTime Timing)?>(qzzzzzzzzzzzzzzzzzzzzzzl_);

        return qzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with First Creatinine Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)?> Encounter_with_First_Creatinine_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzr_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)? tzzzzzzzzzzzzzzzzzzzzzzs_(Encounter EncounterInpatient)
        {
            Id tzzzzzzzzzzzzzzzzzzzzzzv_ = EncounterInpatient?.IdElement;
            string tzzzzzzzzzzzzzzzzzzzzzzw_ = tzzzzzzzzzzzzzzzzzzzzzzv_?.Value;
            CqlValueSet tzzzzzzzzzzzzzzzzzzzzzzx_ = this.Creatinine_lab_test(context);
            IEnumerable<Observation> tzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? tzzzzzzzzzzzzzzzzzzzzzzz_(Observation CreatinineLab)
            {
                Instant uzzzzzzzzzzzzzzzzzzzzzzr_ = CreatinineLab?.IssuedElement;
                DateTimeOffset? uzzzzzzzzzzzzzzzzzzzzzzs_ = uzzzzzzzzzzzzzzzzzzzzzzr_?.Value;
                CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Convert<CqlDateTime>(uzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.earliest(context, uzzzzzzzzzzzzzzzzzzzzzzt_ as object);
                Period uzzzzzzzzzzzzzzzzzzzzzzv_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(uzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlQuantity uzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Subtract(uzzzzzzzzzzzzzzzzzzzzzzx_, uzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(vzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Add(vzzzzzzzzzzzzzzzzzzzzzzc_, uzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Interval(uzzzzzzzzzzzzzzzzzzzzzzz_, vzzzzzzzzzzzzzzzzzzzzzze_, true, true);
                bool? vzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.In<CqlDateTime>(uzzzzzzzzzzzzzzzzzzzzzzu_, vzzzzzzzzzzzzzzzzzzzzzzf_, default);
                Code<ObservationStatus> vzzzzzzzzzzzzzzzzzzzzzzh_ = CreatinineLab?.StatusElement;
                ObservationStatus? vzzzzzzzzzzzzzzzzzzzzzzi_ = vzzzzzzzzzzzzzzzzzzzzzzh_?.Value;
                string vzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Convert<string>(vzzzzzzzzzzzzzzzzzzzzzzi_);
                string[] vzzzzzzzzzzzzzzzzzzzzzzk_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? vzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.In<string>(vzzzzzzzzzzzzzzzzzzzzzzj_, vzzzzzzzzzzzzzzzzzzzzzzk_ as IEnumerable<string>);
                bool? vzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzzzg_, vzzzzzzzzzzzzzzzzzzzzzzl_);
                DataType vzzzzzzzzzzzzzzzzzzzzzzn_ = CreatinineLab?.Value;
                object vzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzn_);
                bool? vzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Not((bool?)(vzzzzzzzzzzzzzzzzzzzzzzo_ is null));
                bool? vzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzzzm_, vzzzzzzzzzzzzzzzzzzzzzzp_);

                return vzzzzzzzzzzzzzzzzzzzzzzq_;
            };
            IEnumerable<Observation> uzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Observation>(tzzzzzzzzzzzzzzzzzzzzzzy_, tzzzzzzzzzzzzzzzzzzzzzzz_);
            object uzzzzzzzzzzzzzzzzzzzzzzb_(Observation @this)
            {
                Instant vzzzzzzzzzzzzzzzzzzzzzzr_ = @this?.IssuedElement;
                DateTimeOffset? vzzzzzzzzzzzzzzzzzzzzzzs_ = vzzzzzzzzzzzzzzzzzzzzzzr_?.Value;
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Convert<CqlDateTime>(vzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.earliest(context, vzzzzzzzzzzzzzzzzzzzzzzt_ as object);

                return vzzzzzzzzzzzzzzzzzzzzzzu_;
            };
            IEnumerable<Observation> uzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.SortBy<Observation>(uzzzzzzzzzzzzzzzzzzzzzza_, uzzzzzzzzzzzzzzzzzzzzzzb_, System.ComponentModel.ListSortDirection.Ascending);
            Observation uzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.First<Observation>(uzzzzzzzzzzzzzzzzzzzzzzc_);
            DataType uzzzzzzzzzzzzzzzzzzzzzze_ = uzzzzzzzzzzzzzzzzzzzzzzd_?.Value;
            object uzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzze_);
            IEnumerable<Observation> uzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, tzzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? uzzzzzzzzzzzzzzzzzzzzzzi_(Observation CreatinineLab)
            {
                Instant vzzzzzzzzzzzzzzzzzzzzzzv_ = CreatinineLab?.IssuedElement;
                DateTimeOffset? vzzzzzzzzzzzzzzzzzzzzzzw_ = vzzzzzzzzzzzzzzzzzzzzzzv_?.Value;
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<CqlDateTime>(vzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.earliest(context, vzzzzzzzzzzzzzzzzzzzzzzx_ as object);
                Period vzzzzzzzzzzzzzzzzzzzzzzz_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(wzzzzzzzzzzzzzzzzzzzzzza_);
                CqlQuantity wzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Subtract(wzzzzzzzzzzzzzzzzzzzzzzb_, wzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(wzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Add(wzzzzzzzzzzzzzzzzzzzzzzg_, wzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Interval(wzzzzzzzzzzzzzzzzzzzzzzd_, wzzzzzzzzzzzzzzzzzzzzzzi_, true, true);
                bool? wzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.In<CqlDateTime>(vzzzzzzzzzzzzzzzzzzzzzzy_, wzzzzzzzzzzzzzzzzzzzzzzj_, default);
                Code<ObservationStatus> wzzzzzzzzzzzzzzzzzzzzzzl_ = CreatinineLab?.StatusElement;
                ObservationStatus? wzzzzzzzzzzzzzzzzzzzzzzm_ = wzzzzzzzzzzzzzzzzzzzzzzl_?.Value;
                string wzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Convert<string>(wzzzzzzzzzzzzzzzzzzzzzzm_);
                string[] wzzzzzzzzzzzzzzzzzzzzzzo_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? wzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.In<string>(wzzzzzzzzzzzzzzzzzzzzzzn_, wzzzzzzzzzzzzzzzzzzzzzzo_ as IEnumerable<string>);
                bool? wzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzzk_, wzzzzzzzzzzzzzzzzzzzzzzp_);
                DataType wzzzzzzzzzzzzzzzzzzzzzzr_ = CreatinineLab?.Value;
                object wzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzr_);
                bool? wzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Not((bool?)(wzzzzzzzzzzzzzzzzzzzzzzs_ is null));
                bool? wzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzzq_, wzzzzzzzzzzzzzzzzzzzzzzt_);

                return wzzzzzzzzzzzzzzzzzzzzzzu_;
            };
            IEnumerable<Observation> uzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Observation>(uzzzzzzzzzzzzzzzzzzzzzzh_, uzzzzzzzzzzzzzzzzzzzzzzi_);
            object uzzzzzzzzzzzzzzzzzzzzzzk_(Observation @this)
            {
                Instant wzzzzzzzzzzzzzzzzzzzzzzv_ = @this?.IssuedElement;
                DateTimeOffset? wzzzzzzzzzzzzzzzzzzzzzzw_ = wzzzzzzzzzzzzzzzzzzzzzzv_?.Value;
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<CqlDateTime>(wzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.earliest(context, wzzzzzzzzzzzzzzzzzzzzzzx_ as object);

                return wzzzzzzzzzzzzzzzzzzzzzzy_;
            };
            IEnumerable<Observation> uzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.SortBy<Observation>(uzzzzzzzzzzzzzzzzzzzzzzj_, uzzzzzzzzzzzzzzzzzzzzzzk_, System.ComponentModel.ListSortDirection.Ascending);
            Observation uzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.First<Observation>(uzzzzzzzzzzzzzzzzzzzzzzl_);
            Instant uzzzzzzzzzzzzzzzzzzzzzzn_ = uzzzzzzzzzzzzzzzzzzzzzzm_?.IssuedElement;
            DateTimeOffset? uzzzzzzzzzzzzzzzzzzzzzzo_ = uzzzzzzzzzzzzzzzzzzzzzzn_?.Value;
            CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Convert<CqlDateTime>(uzzzzzzzzzzzzzzzzzzzzzzo_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)? uzzzzzzzzzzzzzzzzzzzzzzq_ = (CqlTupleMetadata_FETECNQPQREfGRgPYWhOWgeWA, tzzzzzzzzzzzzzzzzzzzzzzw_, uzzzzzzzzzzzzzzzzzzzzzzf_ as CqlQuantity, uzzzzzzzzzzzzzzzzzzzzzzp_);

            return uzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)?> tzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)?>(tzzzzzzzzzzzzzzzzzzzzzzr_, tzzzzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)?> tzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstCreatinineResult, CqlDateTime Timing)?>(tzzzzzzzzzzzzzzzzzzzzzzt_);

        return tzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with First Hematocrit Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?> Encounter_with_First_Hematocrit_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzz_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)? xzzzzzzzzzzzzzzzzzzzzzza_(Encounter EncounterInpatient)
        {
            Id xzzzzzzzzzzzzzzzzzzzzzzd_ = EncounterInpatient?.IdElement;
            string xzzzzzzzzzzzzzzzzzzzzzze_ = xzzzzzzzzzzzzzzzzzzzzzzd_?.Value;
            CqlValueSet xzzzzzzzzzzzzzzzzzzzzzzf_ = this.Hematocrit_lab_test(context);
            IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? xzzzzzzzzzzzzzzzzzzzzzzh_(Observation HematocritLab)
            {
                Instant xzzzzzzzzzzzzzzzzzzzzzzz_ = HematocritLab?.IssuedElement;
                DateTimeOffset? yzzzzzzzzzzzzzzzzzzzzzza_ = xzzzzzzzzzzzzzzzzzzzzzzz_?.Value;
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Convert<CqlDateTime>(yzzzzzzzzzzzzzzzzzzzzzza_);
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.earliest(context, yzzzzzzzzzzzzzzzzzzzzzzb_ as object);
                Period yzzzzzzzzzzzzzzzzzzzzzzd_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzzzzzze_);
                CqlQuantity yzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Subtract(yzzzzzzzzzzzzzzzzzzzzzzf_, yzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Add(yzzzzzzzzzzzzzzzzzzzzzzk_, yzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Interval(yzzzzzzzzzzzzzzzzzzzzzzh_, yzzzzzzzzzzzzzzzzzzzzzzm_, true, true);
                bool? yzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.In<CqlDateTime>(yzzzzzzzzzzzzzzzzzzzzzzc_, yzzzzzzzzzzzzzzzzzzzzzzn_, default);
                Code<ObservationStatus> yzzzzzzzzzzzzzzzzzzzzzzp_ = HematocritLab?.StatusElement;
                ObservationStatus? yzzzzzzzzzzzzzzzzzzzzzzq_ = yzzzzzzzzzzzzzzzzzzzzzzp_?.Value;
                string yzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Convert<string>(yzzzzzzzzzzzzzzzzzzzzzzq_);
                string[] yzzzzzzzzzzzzzzzzzzzzzzs_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? yzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.In<string>(yzzzzzzzzzzzzzzzzzzzzzzr_, yzzzzzzzzzzzzzzzzzzzzzzs_ as IEnumerable<string>);
                bool? yzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzzzzo_, yzzzzzzzzzzzzzzzzzzzzzzt_);
                DataType yzzzzzzzzzzzzzzzzzzzzzzv_ = HematocritLab?.Value;
                object yzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzv_);
                bool? yzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Not((bool?)(yzzzzzzzzzzzzzzzzzzzzzzw_ is null));
                bool? yzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzzzzu_, yzzzzzzzzzzzzzzzzzzzzzzx_);

                return yzzzzzzzzzzzzzzzzzzzzzzy_;
            };
            IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Observation>(xzzzzzzzzzzzzzzzzzzzzzzg_, xzzzzzzzzzzzzzzzzzzzzzzh_);
            object xzzzzzzzzzzzzzzzzzzzzzzj_(Observation @this)
            {
                Instant yzzzzzzzzzzzzzzzzzzzzzzz_ = @this?.IssuedElement;
                DateTimeOffset? zzzzzzzzzzzzzzzzzzzzzzza_ = yzzzzzzzzzzzzzzzzzzzzzzz_?.Value;
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Convert<CqlDateTime>(zzzzzzzzzzzzzzzzzzzzzzza_);
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.earliest(context, zzzzzzzzzzzzzzzzzzzzzzzb_ as object);

                return zzzzzzzzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.SortBy<Observation>(xzzzzzzzzzzzzzzzzzzzzzzi_, xzzzzzzzzzzzzzzzzzzzzzzj_, System.ComponentModel.ListSortDirection.Ascending);
            Observation xzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.First<Observation>(xzzzzzzzzzzzzzzzzzzzzzzk_);
            DataType xzzzzzzzzzzzzzzzzzzzzzzm_ = xzzzzzzzzzzzzzzzzzzzzzzl_?.Value;
            object xzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzm_);
            IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? xzzzzzzzzzzzzzzzzzzzzzzq_(Observation HematocritLab)
            {
                Instant zzzzzzzzzzzzzzzzzzzzzzzd_ = HematocritLab?.IssuedElement;
                DateTimeOffset? zzzzzzzzzzzzzzzzzzzzzzze_ = zzzzzzzzzzzzzzzzzzzzzzzd_?.Value;
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<CqlDateTime>(zzzzzzzzzzzzzzzzzzzzzzze_);
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.earliest(context, zzzzzzzzzzzzzzzzzzzzzzzf_ as object);
                Period zzzzzzzzzzzzzzzzzzzzzzzh_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Start(zzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlQuantity zzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Subtract(zzzzzzzzzzzzzzzzzzzzzzzj_, zzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Start(zzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Add(zzzzzzzzzzzzzzzzzzzzzzzo_, zzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Interval(zzzzzzzzzzzzzzzzzzzzzzzl_, zzzzzzzzzzzzzzzzzzzzzzzq_, true, true);
                bool? zzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.In<CqlDateTime>(zzzzzzzzzzzzzzzzzzzzzzzg_, zzzzzzzzzzzzzzzzzzzzzzzr_, default);
                Code<ObservationStatus> zzzzzzzzzzzzzzzzzzzzzzzt_ = HematocritLab?.StatusElement;
                ObservationStatus? zzzzzzzzzzzzzzzzzzzzzzzu_ = zzzzzzzzzzzzzzzzzzzzzzzt_?.Value;
                string zzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Convert<string>(zzzzzzzzzzzzzzzzzzzzzzzu_);
                string[] zzzzzzzzzzzzzzzzzzzzzzzw_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? zzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.In<string>(zzzzzzzzzzzzzzzzzzzzzzzv_, zzzzzzzzzzzzzzzzzzzzzzzw_ as IEnumerable<string>);
                bool? zzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzzs_, zzzzzzzzzzzzzzzzzzzzzzzx_);
                DataType zzzzzzzzzzzzzzzzzzzzzzzz_ = HematocritLab?.Value;
                object azzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzz_);
                bool? azzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Not((bool?)(azzzzzzzzzzzzzzzzzzzzzzza_ is null));
                bool? azzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzzy_, azzzzzzzzzzzzzzzzzzzzzzzb_);

                return azzzzzzzzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Observation>(xzzzzzzzzzzzzzzzzzzzzzzp_, xzzzzzzzzzzzzzzzzzzzzzzq_);
            object xzzzzzzzzzzzzzzzzzzzzzzs_(Observation @this)
            {
                Instant azzzzzzzzzzzzzzzzzzzzzzzd_ = @this?.IssuedElement;
                DateTimeOffset? azzzzzzzzzzzzzzzzzzzzzzze_ = azzzzzzzzzzzzzzzzzzzzzzzd_?.Value;
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<CqlDateTime>(azzzzzzzzzzzzzzzzzzzzzzze_);
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.earliest(context, azzzzzzzzzzzzzzzzzzzzzzzf_ as object);

                return azzzzzzzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.SortBy<Observation>(xzzzzzzzzzzzzzzzzzzzzzzr_, xzzzzzzzzzzzzzzzzzzzzzzs_, System.ComponentModel.ListSortDirection.Ascending);
            Observation xzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.First<Observation>(xzzzzzzzzzzzzzzzzzzzzzzt_);
            Instant xzzzzzzzzzzzzzzzzzzzzzzv_ = xzzzzzzzzzzzzzzzzzzzzzzu_?.IssuedElement;
            DateTimeOffset? xzzzzzzzzzzzzzzzzzzzzzzw_ = xzzzzzzzzzzzzzzzzzzzzzzv_?.Value;
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<CqlDateTime>(xzzzzzzzzzzzzzzzzzzzzzzw_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)? xzzzzzzzzzzzzzzzzzzzzzzy_ = (CqlTupleMetadata_DIHdhbAJeJTdiAVUAELUHRNdS, xzzzzzzzzzzzzzzzzzzzzzze_, xzzzzzzzzzzzzzzzzzzzzzzn_ as CqlQuantity, xzzzzzzzzzzzzzzzzzzzzzzx_);

            return xzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?> xzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?>(wzzzzzzzzzzzzzzzzzzzzzzz_, xzzzzzzzzzzzzzzzzzzzzzza_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?> xzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?>(xzzzzzzzzzzzzzzzzzzzzzzb_);

        return xzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with First Platelet Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)?> Encounter_with_First_Platelet_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzh_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)? azzzzzzzzzzzzzzzzzzzzzzzi_(Encounter EncounterInpatient)
        {
            Id azzzzzzzzzzzzzzzzzzzzzzzl_ = EncounterInpatient?.IdElement;
            string azzzzzzzzzzzzzzzzzzzzzzzm_ = azzzzzzzzzzzzzzzzzzzzzzzl_?.Value;
            CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzn_ = this.Platelet_count_lab_test(context);
            IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? azzzzzzzzzzzzzzzzzzzzzzzp_(Observation PlateletLab)
            {
                Instant bzzzzzzzzzzzzzzzzzzzzzzzh_ = PlateletLab?.IssuedElement;
                DateTimeOffset? bzzzzzzzzzzzzzzzzzzzzzzzi_ = bzzzzzzzzzzzzzzzzzzzzzzzh_?.Value;
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Convert<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.earliest(context, bzzzzzzzzzzzzzzzzzzzzzzzj_ as object);
                Period bzzzzzzzzzzzzzzzzzzzzzzzl_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlQuantity bzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Subtract(bzzzzzzzzzzzzzzzzzzzzzzzn_, bzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Add(bzzzzzzzzzzzzzzzzzzzzzzzs_, bzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Interval(bzzzzzzzzzzzzzzzzzzzzzzzp_, bzzzzzzzzzzzzzzzzzzzzzzzu_, true, true);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.In<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzzzzk_, bzzzzzzzzzzzzzzzzzzzzzzzv_, default);
                Code<ObservationStatus> bzzzzzzzzzzzzzzzzzzzzzzzx_ = PlateletLab?.StatusElement;
                ObservationStatus? bzzzzzzzzzzzzzzzzzzzzzzzy_ = bzzzzzzzzzzzzzzzzzzzzzzzx_?.Value;
                string bzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Convert<string>(bzzzzzzzzzzzzzzzzzzzzzzzy_);
                string[] czzzzzzzzzzzzzzzzzzzzzzza_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? czzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.In<string>(bzzzzzzzzzzzzzzzzzzzzzzzz_, czzzzzzzzzzzzzzzzzzzzzzza_ as IEnumerable<string>);
                bool? czzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzzzw_, czzzzzzzzzzzzzzzzzzzzzzzb_);
                DataType czzzzzzzzzzzzzzzzzzzzzzzd_ = PlateletLab?.Value;
                object czzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzzd_);
                bool? czzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Not((bool?)(czzzzzzzzzzzzzzzzzzzzzzze_ is null));
                bool? czzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzzzzc_, czzzzzzzzzzzzzzzzzzzzzzzf_);

                return czzzzzzzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Observation>(azzzzzzzzzzzzzzzzzzzzzzzo_, azzzzzzzzzzzzzzzzzzzzzzzp_);
            object azzzzzzzzzzzzzzzzzzzzzzzr_(Observation @this)
            {
                Instant czzzzzzzzzzzzzzzzzzzzzzzh_ = @this?.IssuedElement;
                DateTimeOffset? czzzzzzzzzzzzzzzzzzzzzzzi_ = czzzzzzzzzzzzzzzzzzzzzzzh_?.Value;
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Convert<CqlDateTime>(czzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.earliest(context, czzzzzzzzzzzzzzzzzzzzzzzj_ as object);

                return czzzzzzzzzzzzzzzzzzzzzzzk_;
            };
            IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.SortBy<Observation>(azzzzzzzzzzzzzzzzzzzzzzzq_, azzzzzzzzzzzzzzzzzzzzzzzr_, System.ComponentModel.ListSortDirection.Ascending);
            Observation azzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.First<Observation>(azzzzzzzzzzzzzzzzzzzzzzzs_);
            DataType azzzzzzzzzzzzzzzzzzzzzzzu_ = azzzzzzzzzzzzzzzzzzzzzzzt_?.Value;
            object azzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzu_);
            IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? azzzzzzzzzzzzzzzzzzzzzzzy_(Observation PlateletLab)
            {
                Instant czzzzzzzzzzzzzzzzzzzzzzzl_ = PlateletLab?.IssuedElement;
                DateTimeOffset? czzzzzzzzzzzzzzzzzzzzzzzm_ = czzzzzzzzzzzzzzzzzzzzzzzl_?.Value;
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Convert<CqlDateTime>(czzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.earliest(context, czzzzzzzzzzzzzzzzzzzzzzzn_ as object);
                Period czzzzzzzzzzzzzzzzzzzzzzzp_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlQuantity czzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Subtract(czzzzzzzzzzzzzzzzzzzzzzzr_, czzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Add(czzzzzzzzzzzzzzzzzzzzzzzw_, czzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Interval(czzzzzzzzzzzzzzzzzzzzzzzt_, czzzzzzzzzzzzzzzzzzzzzzzy_, true, true);
                bool? dzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(czzzzzzzzzzzzzzzzzzzzzzzo_, czzzzzzzzzzzzzzzzzzzzzzzz_, default);
                Code<ObservationStatus> dzzzzzzzzzzzzzzzzzzzzzzzb_ = PlateletLab?.StatusElement;
                ObservationStatus? dzzzzzzzzzzzzzzzzzzzzzzzc_ = dzzzzzzzzzzzzzzzzzzzzzzzb_?.Value;
                string dzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Convert<string>(dzzzzzzzzzzzzzzzzzzzzzzzc_);
                string[] dzzzzzzzzzzzzzzzzzzzzzzze_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? dzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.In<string>(dzzzzzzzzzzzzzzzzzzzzzzzd_, dzzzzzzzzzzzzzzzzzzzzzzze_ as IEnumerable<string>);
                bool? dzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzzzzzza_, dzzzzzzzzzzzzzzzzzzzzzzzf_);
                DataType dzzzzzzzzzzzzzzzzzzzzzzzh_ = PlateletLab?.Value;
                object dzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzh_);
                bool? dzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Not((bool?)(dzzzzzzzzzzzzzzzzzzzzzzzi_ is null));
                bool? dzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzzzzzzg_, dzzzzzzzzzzzzzzzzzzzzzzzj_);

                return dzzzzzzzzzzzzzzzzzzzzzzzk_;
            };
            IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Observation>(azzzzzzzzzzzzzzzzzzzzzzzx_, azzzzzzzzzzzzzzzzzzzzzzzy_);
            object bzzzzzzzzzzzzzzzzzzzzzzza_(Observation @this)
            {
                Instant dzzzzzzzzzzzzzzzzzzzzzzzl_ = @this?.IssuedElement;
                DateTimeOffset? dzzzzzzzzzzzzzzzzzzzzzzzm_ = dzzzzzzzzzzzzzzzzzzzzzzzl_?.Value;
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Convert<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.earliest(context, dzzzzzzzzzzzzzzzzzzzzzzzn_ as object);

                return dzzzzzzzzzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.SortBy<Observation>(azzzzzzzzzzzzzzzzzzzzzzzz_, bzzzzzzzzzzzzzzzzzzzzzzza_, System.ComponentModel.ListSortDirection.Ascending);
            Observation bzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.First<Observation>(bzzzzzzzzzzzzzzzzzzzzzzzb_);
            Instant bzzzzzzzzzzzzzzzzzzzzzzzd_ = bzzzzzzzzzzzzzzzzzzzzzzzc_?.IssuedElement;
            DateTimeOffset? bzzzzzzzzzzzzzzzzzzzzzzze_ = bzzzzzzzzzzzzzzzzzzzzzzzd_?.Value;
            CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzzzze_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)? bzzzzzzzzzzzzzzzzzzzzzzzg_ = (CqlTupleMetadata_DAUcYHQZcDKbIfORJOEZBDgIh, azzzzzzzzzzzzzzzzzzzzzzzm_, azzzzzzzzzzzzzzzzzzzzzzzv_ as CqlQuantity, bzzzzzzzzzzzzzzzzzzzzzzzf_);

            return bzzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)?> azzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)?>(azzzzzzzzzzzzzzzzzzzzzzzh_, azzzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)?> azzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstPlateletResult, CqlDateTime Timing)?>(azzzzzzzzzzzzzzzzzzzzzzzj_);

        return azzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with First Sodium Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)?> Encounter_with_First_Sodium_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)? dzzzzzzzzzzzzzzzzzzzzzzzq_(Encounter EncounterInpatient)
        {
            Id dzzzzzzzzzzzzzzzzzzzzzzzt_ = EncounterInpatient?.IdElement;
            string dzzzzzzzzzzzzzzzzzzzzzzzu_ = dzzzzzzzzzzzzzzzzzzzzzzzt_?.Value;
            CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Sodium_lab_test(context);
            IEnumerable<Observation> dzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? dzzzzzzzzzzzzzzzzzzzzzzzx_(Observation SodiumLab)
            {
                Instant ezzzzzzzzzzzzzzzzzzzzzzzp_ = SodiumLab?.IssuedElement;
                DateTimeOffset? ezzzzzzzzzzzzzzzzzzzzzzzq_ = ezzzzzzzzzzzzzzzzzzzzzzzp_?.Value;
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Convert<CqlDateTime>(ezzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.earliest(context, ezzzzzzzzzzzzzzzzzzzzzzzr_ as object);
                Period ezzzzzzzzzzzzzzzzzzzzzzzt_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlQuantity ezzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Subtract(ezzzzzzzzzzzzzzzzzzzzzzzv_, ezzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Add(fzzzzzzzzzzzzzzzzzzzzzzza_, ezzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Interval(ezzzzzzzzzzzzzzzzzzzzzzzx_, fzzzzzzzzzzzzzzzzzzzzzzzc_, true, true);
                bool? fzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.In<CqlDateTime>(ezzzzzzzzzzzzzzzzzzzzzzzs_, fzzzzzzzzzzzzzzzzzzzzzzzd_, default);
                Code<ObservationStatus> fzzzzzzzzzzzzzzzzzzzzzzzf_ = SodiumLab?.StatusElement;
                ObservationStatus? fzzzzzzzzzzzzzzzzzzzzzzzg_ = fzzzzzzzzzzzzzzzzzzzzzzzf_?.Value;
                string fzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Convert<string>(fzzzzzzzzzzzzzzzzzzzzzzzg_);
                string[] fzzzzzzzzzzzzzzzzzzzzzzzi_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? fzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.In<string>(fzzzzzzzzzzzzzzzzzzzzzzzh_, fzzzzzzzzzzzzzzzzzzzzzzzi_ as IEnumerable<string>);
                bool? fzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzze_, fzzzzzzzzzzzzzzzzzzzzzzzj_);
                DataType fzzzzzzzzzzzzzzzzzzzzzzzl_ = SodiumLab?.Value;
                object fzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzl_);
                bool? fzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Not((bool?)(fzzzzzzzzzzzzzzzzzzzzzzzm_ is null));
                bool? fzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzzk_, fzzzzzzzzzzzzzzzzzzzzzzzn_);

                return fzzzzzzzzzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<Observation> dzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Observation>(dzzzzzzzzzzzzzzzzzzzzzzzw_, dzzzzzzzzzzzzzzzzzzzzzzzx_);
            object dzzzzzzzzzzzzzzzzzzzzzzzz_(Observation @this)
            {
                Instant fzzzzzzzzzzzzzzzzzzzzzzzp_ = @this?.IssuedElement;
                DateTimeOffset? fzzzzzzzzzzzzzzzzzzzzzzzq_ = fzzzzzzzzzzzzzzzzzzzzzzzp_?.Value;
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Convert<CqlDateTime>(fzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.earliest(context, fzzzzzzzzzzzzzzzzzzzzzzzr_ as object);

                return fzzzzzzzzzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.SortBy<Observation>(dzzzzzzzzzzzzzzzzzzzzzzzy_, dzzzzzzzzzzzzzzzzzzzzzzzz_, System.ComponentModel.ListSortDirection.Ascending);
            Observation ezzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.First<Observation>(ezzzzzzzzzzzzzzzzzzzzzzza_);
            DataType ezzzzzzzzzzzzzzzzzzzzzzzc_ = ezzzzzzzzzzzzzzzzzzzzzzzb_?.Value;
            object ezzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzc_);
            IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? ezzzzzzzzzzzzzzzzzzzzzzzg_(Observation SodiumLab)
            {
                Instant fzzzzzzzzzzzzzzzzzzzzzzzt_ = SodiumLab?.IssuedElement;
                DateTimeOffset? fzzzzzzzzzzzzzzzzzzzzzzzu_ = fzzzzzzzzzzzzzzzzzzzzzzzt_?.Value;
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Convert<CqlDateTime>(fzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.earliest(context, fzzzzzzzzzzzzzzzzzzzzzzzv_ as object);
                Period fzzzzzzzzzzzzzzzzzzzzzzzx_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Start(fzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlQuantity gzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Subtract(fzzzzzzzzzzzzzzzzzzzzzzzz_, gzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Add(gzzzzzzzzzzzzzzzzzzzzzzze_, gzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Interval(gzzzzzzzzzzzzzzzzzzzzzzzb_, gzzzzzzzzzzzzzzzzzzzzzzzg_, true, true);
                bool? gzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.In<CqlDateTime>(fzzzzzzzzzzzzzzzzzzzzzzzw_, gzzzzzzzzzzzzzzzzzzzzzzzh_, default);
                Code<ObservationStatus> gzzzzzzzzzzzzzzzzzzzzzzzj_ = SodiumLab?.StatusElement;
                ObservationStatus? gzzzzzzzzzzzzzzzzzzzzzzzk_ = gzzzzzzzzzzzzzzzzzzzzzzzj_?.Value;
                string gzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<string>(gzzzzzzzzzzzzzzzzzzzzzzzk_);
                string[] gzzzzzzzzzzzzzzzzzzzzzzzm_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? gzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.In<string>(gzzzzzzzzzzzzzzzzzzzzzzzl_, gzzzzzzzzzzzzzzzzzzzzzzzm_ as IEnumerable<string>);
                bool? gzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzzzi_, gzzzzzzzzzzzzzzzzzzzzzzzn_);
                DataType gzzzzzzzzzzzzzzzzzzzzzzzp_ = SodiumLab?.Value;
                object gzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzp_);
                bool? gzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Not((bool?)(gzzzzzzzzzzzzzzzzzzzzzzzq_ is null));
                bool? gzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzzzo_, gzzzzzzzzzzzzzzzzzzzzzzzr_);

                return gzzzzzzzzzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Observation>(ezzzzzzzzzzzzzzzzzzzzzzzf_, ezzzzzzzzzzzzzzzzzzzzzzzg_);
            object ezzzzzzzzzzzzzzzzzzzzzzzi_(Observation @this)
            {
                Instant gzzzzzzzzzzzzzzzzzzzzzzzt_ = @this?.IssuedElement;
                DateTimeOffset? gzzzzzzzzzzzzzzzzzzzzzzzu_ = gzzzzzzzzzzzzzzzzzzzzzzzt_?.Value;
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Convert<CqlDateTime>(gzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.earliest(context, gzzzzzzzzzzzzzzzzzzzzzzzv_ as object);

                return gzzzzzzzzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.SortBy<Observation>(ezzzzzzzzzzzzzzzzzzzzzzzh_, ezzzzzzzzzzzzzzzzzzzzzzzi_, System.ComponentModel.ListSortDirection.Ascending);
            Observation ezzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.First<Observation>(ezzzzzzzzzzzzzzzzzzzzzzzj_);
            Instant ezzzzzzzzzzzzzzzzzzzzzzzl_ = ezzzzzzzzzzzzzzzzzzzzzzzk_?.IssuedElement;
            DateTimeOffset? ezzzzzzzzzzzzzzzzzzzzzzzm_ = ezzzzzzzzzzzzzzzzzzzzzzzl_?.Value;
            CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Convert<CqlDateTime>(ezzzzzzzzzzzzzzzzzzzzzzzm_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)? ezzzzzzzzzzzzzzzzzzzzzzzo_ = (CqlTupleMetadata_GKGeLARADLGJcNcZaDhdCREMa, dzzzzzzzzzzzzzzzzzzzzzzzu_, ezzzzzzzzzzzzzzzzzzzzzzzd_ as CqlQuantity, ezzzzzzzzzzzzzzzzzzzzzzzn_);

            return ezzzzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)?> dzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)?>(dzzzzzzzzzzzzzzzzzzzzzzzp_, dzzzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)?> dzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstSodiumResult, CqlDateTime Timing)?>(dzzzzzzzzzzzzzzzzzzzzzzzr_);

        return dzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition(
        definitionName: "Qualifying Blood Pressure Reading")]
    public IEnumerable<Observation> Qualifying_Blood_Pressure_Reading(CqlContext context)
    {
        IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bp"));
        bool? gzzzzzzzzzzzzzzzzzzzzzzzy_(Observation BPReading)
        {
            DataType hzzzzzzzzzzzzzzzzzzzzzzza_ = BPReading?.Effective;
            object hzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.earliest(context, hzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Measurement_Period(context);
            bool? hzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.In<CqlDateTime>(hzzzzzzzzzzzzzzzzzzzzzzzc_, hzzzzzzzzzzzzzzzzzzzzzzzd_, "day");
            Code<ObservationStatus> hzzzzzzzzzzzzzzzzzzzzzzzf_ = BPReading?.StatusElement;
            ObservationStatus? hzzzzzzzzzzzzzzzzzzzzzzzg_ = hzzzzzzzzzzzzzzzzzzzzzzzf_?.Value;
            string hzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Convert<string>(hzzzzzzzzzzzzzzzzzzzzzzzg_);
            string[] hzzzzzzzzzzzzzzzzzzzzzzzi_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? hzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.In<string>(hzzzzzzzzzzzzzzzzzzzzzzzh_, hzzzzzzzzzzzzzzzzzzzzzzzi_ as IEnumerable<string>);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzzze_, hzzzzzzzzzzzzzzzzzzzzzzzj_);

            return hzzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Observation>(gzzzzzzzzzzzzzzzzzzzzzzzx_, gzzzzzzzzzzzzzzzzzzzzzzzy_);

        return gzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition(
        definitionName: "Test2")]
    public CqlQuantity Test2(CqlContext context)
    {
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Qualifying_Blood_Pressure_Reading(context);
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzm_(Observation SBPReading)
        {
            IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Inpatient_Encounters(context);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzu_(Encounter EncounterInpatient)
            {
                DataType hzzzzzzzzzzzzzzzzzzzzzzzy_ = SBPReading?.Effective;
                object hzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.earliest(context, hzzzzzzzzzzzzzzzzzzzzzzzz_);
                Period izzzzzzzzzzzzzzzzzzzzzzzb_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(izzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlQuantity izzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Subtract(izzzzzzzzzzzzzzzzzzzzzzzd_, izzzzzzzzzzzzzzzzzzzzzzze_);
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Start(izzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlQuantity izzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Add(izzzzzzzzzzzzzzzzzzzzzzzi_, izzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Interval(izzzzzzzzzzzzzzzzzzzzzzzf_, izzzzzzzzzzzzzzzzzzzzzzzk_, true, true);
                bool? izzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.In<CqlDateTime>(izzzzzzzzzzzzzzzzzzzzzzza_, izzzzzzzzzzzzzzzzzzzzzzzl_, default);

                return izzzzzzzzzzzzzzzzzzzzzzzm_;
            };
            IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Encounter>(hzzzzzzzzzzzzzzzzzzzzzzzt_, hzzzzzzzzzzzzzzzzzzzzzzzu_);
            Observation hzzzzzzzzzzzzzzzzzzzzzzzw_(Encounter EncounterInpatient) =>
                SBPReading;
            IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Select<Encounter, Observation>(hzzzzzzzzzzzzzzzzzzzzzzzv_, hzzzzzzzzzzzzzzzzzzzzzzzw_);

            return hzzzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.SelectMany<Observation, Observation>(hzzzzzzzzzzzzzzzzzzzzzzzl_, hzzzzzzzzzzzzzzzzzzzzzzzm_);
        CqlQuantity hzzzzzzzzzzzzzzzzzzzzzzzo_(Observation SBPReading)
        {
            List<Observation.ComponentComponent> izzzzzzzzzzzzzzzzzzzzzzzn_ = SBPReading?.Component;
            bool? izzzzzzzzzzzzzzzzzzzzzzzo_(Observation.ComponentComponent SBPComponent)
            {
                CodeableConcept izzzzzzzzzzzzzzzzzzzzzzzu_ = SBPComponent?.Code;
                CqlConcept izzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, izzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlCode izzzzzzzzzzzzzzzzzzzzzzzw_ = this.Systolic_blood_pressure(context);
                CqlConcept izzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.ConvertCodeToConcept(izzzzzzzzzzzzzzzzzzzzzzzw_);
                bool? izzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Equivalent(izzzzzzzzzzzzzzzzzzzzzzzv_, izzzzzzzzzzzzzzzzzzzzzzzx_);

                return izzzzzzzzzzzzzzzzzzzzzzzy_;
            };
            IEnumerable<Observation.ComponentComponent> izzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)izzzzzzzzzzzzzzzzzzzzzzzn_, izzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlQuantity izzzzzzzzzzzzzzzzzzzzzzzq_(Observation.ComponentComponent SBPComponent)
            {
                DataType izzzzzzzzzzzzzzzzzzzzzzzz_ = SBPComponent?.Value;
                object jzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzz_);

                return jzzzzzzzzzzzzzzzzzzzzzzza_ as CqlQuantity;
            };
            IEnumerable<CqlQuantity> izzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Select<Observation.ComponentComponent, CqlQuantity>(izzzzzzzzzzzzzzzzzzzzzzzp_, izzzzzzzzzzzzzzzzzzzzzzzq_);
            IEnumerable<CqlQuantity> izzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Distinct<CqlQuantity>(izzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlQuantity izzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.SingletonFrom<CqlQuantity>(izzzzzzzzzzzzzzzzzzzzzzzs_);

            return izzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<CqlQuantity> hzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Select<Observation, CqlQuantity>(hzzzzzzzzzzzzzzzzzzzzzzzn_, hzzzzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<CqlQuantity> hzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Distinct<CqlQuantity>(hzzzzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<CqlQuantity> hzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ListSort<CqlQuantity>(hzzzzzzzzzzzzzzzzzzzzzzzq_, System.ComponentModel.ListSortDirection.Ascending);
        CqlQuantity hzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.First<CqlQuantity>(hzzzzzzzzzzzzzzzzzzzzzzzr_);

        return hzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with First White Blood Cells Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)?> Encounter_with_First_White_Blood_Cells_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)? jzzzzzzzzzzzzzzzzzzzzzzzc_(Encounter EncounterInpatient)
        {
            Id jzzzzzzzzzzzzzzzzzzzzzzzf_ = EncounterInpatient?.IdElement;
            string jzzzzzzzzzzzzzzzzzzzzzzzg_ = jzzzzzzzzzzzzzzzzzzzzzzzf_?.Value;
            CqlValueSet jzzzzzzzzzzzzzzzzzzzzzzzh_ = this.White_blood_cells_count_lab_test(context);
            IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? jzzzzzzzzzzzzzzzzzzzzzzzj_(Observation WhiteBloodCellLab)
            {
                Instant kzzzzzzzzzzzzzzzzzzzzzzzb_ = WhiteBloodCellLab?.IssuedElement;
                DateTimeOffset? kzzzzzzzzzzzzzzzzzzzzzzzc_ = kzzzzzzzzzzzzzzzzzzzzzzzb_?.Value;
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Convert<CqlDateTime>(kzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.earliest(context, kzzzzzzzzzzzzzzzzzzzzzzzd_ as object);
                Period kzzzzzzzzzzzzzzzzzzzzzzzf_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlQuantity kzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Subtract(kzzzzzzzzzzzzzzzzzzzzzzzh_, kzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Add(kzzzzzzzzzzzzzzzzzzzzzzzm_, kzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Interval(kzzzzzzzzzzzzzzzzzzzzzzzj_, kzzzzzzzzzzzzzzzzzzzzzzzo_, true, true);
                bool? kzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.In<CqlDateTime>(kzzzzzzzzzzzzzzzzzzzzzzze_, kzzzzzzzzzzzzzzzzzzzzzzzp_, default);
                Code<ObservationStatus> kzzzzzzzzzzzzzzzzzzzzzzzr_ = WhiteBloodCellLab?.StatusElement;
                ObservationStatus? kzzzzzzzzzzzzzzzzzzzzzzzs_ = kzzzzzzzzzzzzzzzzzzzzzzzr_?.Value;
                string kzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Convert<string>(kzzzzzzzzzzzzzzzzzzzzzzzs_);
                string[] kzzzzzzzzzzzzzzzzzzzzzzzu_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? kzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.In<string>(kzzzzzzzzzzzzzzzzzzzzzzzt_, kzzzzzzzzzzzzzzzzzzzzzzzu_ as IEnumerable<string>);
                bool? kzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzzq_, kzzzzzzzzzzzzzzzzzzzzzzzv_);
                DataType kzzzzzzzzzzzzzzzzzzzzzzzx_ = WhiteBloodCellLab?.Value;
                object kzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzx_);
                bool? kzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Not((bool?)(kzzzzzzzzzzzzzzzzzzzzzzzy_ is null));
                bool? lzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzzw_, kzzzzzzzzzzzzzzzzzzzzzzzz_);

                return lzzzzzzzzzzzzzzzzzzzzzzza_;
            };
            IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Observation>(jzzzzzzzzzzzzzzzzzzzzzzzi_, jzzzzzzzzzzzzzzzzzzzzzzzj_);
            object jzzzzzzzzzzzzzzzzzzzzzzzl_(Observation @this)
            {
                Instant lzzzzzzzzzzzzzzzzzzzzzzzb_ = @this?.IssuedElement;
                DateTimeOffset? lzzzzzzzzzzzzzzzzzzzzzzzc_ = lzzzzzzzzzzzzzzzzzzzzzzzb_?.Value;
                CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Convert<CqlDateTime>(lzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.earliest(context, lzzzzzzzzzzzzzzzzzzzzzzzd_ as object);

                return lzzzzzzzzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.SortBy<Observation>(jzzzzzzzzzzzzzzzzzzzzzzzk_, jzzzzzzzzzzzzzzzzzzzzzzzl_, System.ComponentModel.ListSortDirection.Ascending);
            Observation jzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.First<Observation>(jzzzzzzzzzzzzzzzzzzzzzzzm_);
            DataType jzzzzzzzzzzzzzzzzzzzzzzzo_ = jzzzzzzzzzzzzzzzzzzzzzzzn_?.Value;
            object jzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzo_);
            IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? jzzzzzzzzzzzzzzzzzzzzzzzs_(Observation WhiteBloodCellLab)
            {
                Instant lzzzzzzzzzzzzzzzzzzzzzzzf_ = WhiteBloodCellLab?.IssuedElement;
                DateTimeOffset? lzzzzzzzzzzzzzzzzzzzzzzzg_ = lzzzzzzzzzzzzzzzzzzzzzzzf_?.Value;
                CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Convert<CqlDateTime>(lzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.earliest(context, lzzzzzzzzzzzzzzzzzzzzzzzh_ as object);
                Period lzzzzzzzzzzzzzzzzzzzzzzzj_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlQuantity lzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Subtract(lzzzzzzzzzzzzzzzzzzzzzzzl_, lzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Add(lzzzzzzzzzzzzzzzzzzzzzzzq_, lzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Interval(lzzzzzzzzzzzzzzzzzzzzzzzn_, lzzzzzzzzzzzzzzzzzzzzzzzs_, true, true);
                bool? lzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(lzzzzzzzzzzzzzzzzzzzzzzzi_, lzzzzzzzzzzzzzzzzzzzzzzzt_, default);
                Code<ObservationStatus> lzzzzzzzzzzzzzzzzzzzzzzzv_ = WhiteBloodCellLab?.StatusElement;
                ObservationStatus? lzzzzzzzzzzzzzzzzzzzzzzzw_ = lzzzzzzzzzzzzzzzzzzzzzzzv_?.Value;
                string lzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<string>(lzzzzzzzzzzzzzzzzzzzzzzzw_);
                string[] lzzzzzzzzzzzzzzzzzzzzzzzy_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? lzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<string>(lzzzzzzzzzzzzzzzzzzzzzzzx_, lzzzzzzzzzzzzzzzzzzzzzzzy_ as IEnumerable<string>);
                bool? mzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzzu_, lzzzzzzzzzzzzzzzzzzzzzzzz_);
                DataType mzzzzzzzzzzzzzzzzzzzzzzzb_ = WhiteBloodCellLab?.Value;
                object mzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzb_);
                bool? mzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Not((bool?)(mzzzzzzzzzzzzzzzzzzzzzzzc_ is null));
                bool? mzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzzzza_, mzzzzzzzzzzzzzzzzzzzzzzzd_);

                return mzzzzzzzzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Observation>(jzzzzzzzzzzzzzzzzzzzzzzzr_, jzzzzzzzzzzzzzzzzzzzzzzzs_);
            object jzzzzzzzzzzzzzzzzzzzzzzzu_(Observation @this)
            {
                Instant mzzzzzzzzzzzzzzzzzzzzzzzf_ = @this?.IssuedElement;
                DateTimeOffset? mzzzzzzzzzzzzzzzzzzzzzzzg_ = mzzzzzzzzzzzzzzzzzzzzzzzf_?.Value;
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Convert<CqlDateTime>(mzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.earliest(context, mzzzzzzzzzzzzzzzzzzzzzzzh_ as object);

                return mzzzzzzzzzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.SortBy<Observation>(jzzzzzzzzzzzzzzzzzzzzzzzt_, jzzzzzzzzzzzzzzzzzzzzzzzu_, System.ComponentModel.ListSortDirection.Ascending);
            Observation jzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.First<Observation>(jzzzzzzzzzzzzzzzzzzzzzzzv_);
            Instant jzzzzzzzzzzzzzzzzzzzzzzzx_ = jzzzzzzzzzzzzzzzzzzzzzzzw_?.IssuedElement;
            DateTimeOffset? jzzzzzzzzzzzzzzzzzzzzzzzy_ = jzzzzzzzzzzzzzzzzzzzzzzzx_?.Value;
            CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Convert<CqlDateTime>(jzzzzzzzzzzzzzzzzzzzzzzzy_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)? kzzzzzzzzzzzzzzzzzzzzzzza_ = (CqlTupleMetadata_ChVYCdXDGgVcFTCCUefXMbCHX, jzzzzzzzzzzzzzzzzzzzzzzzg_, jzzzzzzzzzzzzzzzzzzzzzzzp_ as CqlQuantity, jzzzzzzzzzzzzzzzzzzzzzzzz_);

            return kzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)?> jzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)?>(jzzzzzzzzzzzzzzzzzzzzzzzb_, jzzzzzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)?> jzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstWhiteBloodCellResult, CqlDateTime Timing)?>(jzzzzzzzzzzzzzzzzzzzzzzzd_);

        return jzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? mzzzzzzzzzzzzzzzzzzzzzzzj_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return mzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> mzzzzzzzzzzzzzzzzzzzzzzzk_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return mzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? mzzzzzzzzzzzzzzzzzzzzzzzl_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return mzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode mzzzzzzzzzzzzzzzzzzzzzzzm_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return mzzzzzzzzzzzzzzzzzzzzzzzm_;
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
