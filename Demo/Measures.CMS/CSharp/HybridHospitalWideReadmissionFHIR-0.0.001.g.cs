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

    #region ValueSet: Glucose lab test
    [CqlValueSetDefinition(
        definitionName: "Glucose lab test",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.134",
        valueSetVersion: null)]
    public CqlValueSet Glucose_lab_test(CqlContext context) => _Glucose_lab_test;

    private static readonly CqlValueSet _Glucose_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.134", null);
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

    #region ValueSet: Potassium lab test
    [CqlValueSetDefinition(
        definitionName: "Potassium lab test",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.117",
        valueSetVersion: null)]
    public CqlValueSet Potassium_lab_test(CqlContext context) => _Potassium_lab_test;

    private static readonly CqlValueSet _Potassium_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.117", null);
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
        CqlCode[] vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = [
            new CqlCode("2708-6", "http://loinc.org", default, default),
            new CqlCode("59408-5", "http://loinc.org", default, default),
            new CqlCode("8480-6", "http://loinc.org", default, default),
        ];

        return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "ActCode")]
    public CqlCode[] ActCode(CqlContext context)
    {
        CqlCode[] vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = []
;

        return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "Source of Payment Typology")]
    public CqlCode[] Source_of_Payment_Typology(CqlContext context)
    {
        CqlCode[] vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = []
;

        return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Interval(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, true, true);
        object vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.ResolveParameter("HybridHospitalWideReadmissionFHIR-0.0.001", "Measurement Period", vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

        return (CqlInterval<CqlDateTime>)vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.SingletonFrom<Patient>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

        return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition(
        definitionName: "Inpatient Encounters")]
    public IEnumerable<Encounter> Inpatient_Encounters(CqlContext context)
    {
        CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(Encounter InpatientEncounter)
        {
            CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Medicare_FFS_payer(context);
            IEnumerable<Coverage> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Coverage>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-coverage"));
            CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Medicare_Advantage_payer(context);
            IEnumerable<Coverage> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Coverage>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-coverage"));
            IEnumerable<Coverage> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<Coverage>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_(Coverage MedicarePayer)
            {
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, InpatientEncounter);
                int? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = CQMCommon_2_2_000.Instance.lengthInDays(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Less(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, 365);
                Code<Encounter.EncounterStatus> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = InpatientEncounter?.StatusElement;
                Encounter.EncounterStatus? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_?.Value;
                Code<Encounter.EncounterStatus> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Equal(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, "finished");
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                Patient wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Patient(context);
                Date wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_?.BirthDateElement;
                string wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_?.Value;
                CqlDate wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.ConvertStringToDate(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                Period wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Start(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlDate wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.DateFrom(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                int? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.CalculateAgeAt(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, "year");
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.GreaterOrEqual(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, 65);
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.End(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Measurement_Period(context);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, "day");
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

                return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<Coverage> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Coverage>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            Encounter wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_(Coverage MedicarePayer) =>
                InpatientEncounter;
            IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Select<Coverage, Encounter>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

            return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.SelectMany<Encounter, Encounter>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

        return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Inpatient_Encounters(context);

        return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with First Body Temperature")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)?> Encounter_with_First_Body_Temperature(CqlContext context)
    {
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_(Encounter EncounterInpatient)
        {
            Id xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = EncounterInpatient?.IdElement;
            string xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_?.Value;
            IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bodytemp"));
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Observation temperature)
            {
                DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = temperature?.Effective;
                object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.earliest(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                Period yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlQuantity yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Subtract(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlQuantity yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Add(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Interval(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, true, true);
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.In<CqlDateTime>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, default);
                Code<ObservationStatus> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = temperature?.StatusElement;
                ObservationStatus? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_?.Value;
                string yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Convert<string>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                string[] yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<string>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ as IEnumerable<string>);
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = temperature?.Value;
                CqlQuantity yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ as Quantity);
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Not((bool?)(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ is null));
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

                return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Observation>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            object xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_(Observation @this)
            {
                DataType zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = @this?.Effective;
                object zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.earliest(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

                return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.SortBy<Observation>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, System.ComponentModel.ListSortDirection.Ascending);
            Observation xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.First<Observation>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            DataType xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_?.Value;
            CqlQuantity xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ as Quantity);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(Observation temperature)
            {
                DataType zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = temperature?.Effective;
                object zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.earliest(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                Period zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Start(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlQuantity zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Subtract(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlQuantity zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Add(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Interval(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, true, true);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, default);
                Code<ObservationStatus> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = temperature?.StatusElement;
                ObservationStatus? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_?.Value;
                string zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Convert<string>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                string[] zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.In<string>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ as IEnumerable<string>);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                DataType zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = temperature?.Value;
                CqlQuantity zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ as Quantity);
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Not((bool?)(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ is null));
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

                return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Observation>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            object xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_(Observation @this)
            {
                DataType azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = @this?.Effective;
                object azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.earliest(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

                return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.SortBy<Observation>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, System.ComponentModel.ListSortDirection.Ascending);
            Observation xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.First<Observation>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            DataType xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_?.Effective;
            object xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.earliest(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = (CqlTupleMetadata_GIbILVAdXLLNYBgcQIEiUiKaK, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ as CqlQuantity, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

            return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)?> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)?>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)?> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstTemperatureResult, CqlDateTime Timing)?>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

        return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with First Heart Rate")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)?> Encounter_with_First_Heart_Rate(CqlContext context)
    {
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_(Encounter EncounterInpatient)
        {
            Id azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = EncounterInpatient?.IdElement;
            string azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_?.Value;
            IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/heartrate"));
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_(Observation HeartRate)
            {
                DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = HeartRate?.Effective;
                object bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.earliest(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                Period bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlQuantity bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Subtract(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlQuantity bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Add(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Interval(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, true, true);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, default);
                Code<ObservationStatus> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = HeartRate?.StatusElement;
                ObservationStatus? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_?.Value;
                string bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Convert<string>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                string[] bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.In<string>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ as IEnumerable<string>);
                bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = HeartRate?.Value;
                CqlQuantity bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ as Quantity);
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Not((bool?)(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ is null));
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

                return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Observation>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            object azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Observation @this)
            {
                DataType czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = @this?.Effective;
                object czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.earliest(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

                return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.SortBy<Observation>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, System.ComponentModel.ListSortDirection.Ascending);
            Observation azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.First<Observation>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            DataType azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_?.Value;
            CqlQuantity azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ as Quantity);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_(Observation HeartRate)
            {
                DataType czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = HeartRate?.Effective;
                object czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.earliest(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                Period czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlQuantity czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Subtract(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlQuantity czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Add(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Interval(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, true, true);
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.In<CqlDateTime>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, default);
                Code<ObservationStatus> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = HeartRate?.StatusElement;
                ObservationStatus? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_?.Value;
                string czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<string>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                string[] czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<string>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ as IEnumerable<string>);
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = HeartRate?.Value;
                CqlQuantity dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ as Quantity);
                bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Not((bool?)(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ is null));
                bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

                return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Observation>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            object azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_(Observation @this)
            {
                DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = @this?.Effective;
                object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.earliest(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

                return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.SortBy<Observation>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, System.ComponentModel.ListSortDirection.Ascending);
            Observation azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.First<Observation>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            DataType azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_?.Effective;
            object bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.earliest(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = (CqlTupleMetadata_DhbJAfCiKIAGYKTjJXYGSKECQ, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ as CqlQuantity, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

            return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)?> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)?>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)?> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstHeartRateResult, CqlDateTime Timing)?>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with First Oxygen Saturation")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)?> Encounter_with_First_Oxygen_Saturation(CqlContext context)
    {
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Encounter EncounterInpatient)
        {
            Id dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = EncounterInpatient?.IdElement;
            string dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_?.Value;
            CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
            IEnumerable<Observation> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(Observation O2Saturation)
            {
                object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_()
                {
                    bool ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_()
                    {
                        DataType fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = O2Saturation?.Effective;
                        object fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                        bool fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ is CqlDateTime;

                        return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
                    };
                    bool ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_()
                    {
                        DataType fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = O2Saturation?.Effective;
                        object fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                        bool fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ is CqlInterval<CqlDateTime>;

                        return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
                    };
                    bool fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_()
                    {
                        DataType fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = O2Saturation?.Effective;
                        object fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                        bool fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ is CqlDateTime;

                        return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
                    };
                    if (ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_())
                    {
                        DataType fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = O2Saturation?.Effective;
                        object fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

                        return (fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ as CqlDateTime) as object;
                    }
                    else if (ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_())
                    {
                        DataType fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = O2Saturation?.Effective;
                        object fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

                        return (fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_())
                    {
                        DataType fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = O2Saturation?.Effective;
                        object fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

                        return (fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ as CqlDateTime) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.earliest(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_());
                Period ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlQuantity ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Subtract(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlQuantity ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Add(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Interval(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, true, true);
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.In<CqlDateTime>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, default);
                Code<ObservationStatus> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = O2Saturation?.StatusElement;
                ObservationStatus? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_?.Value;
                Code<ObservationStatus> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Convert<Code<ObservationStatus>>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                string ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<string>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                string[] ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.In<string>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ as IEnumerable<string>);
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                DataType ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = O2Saturation?.Value;
                object ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Not((bool?)(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ is null));
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

                return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
            };
            IEnumerable<Observation> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Observation>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(Observation @this)
            {
                object fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_()
                {
                    bool fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_()
                    {
                        DataType fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = @this?.Effective;
                        object fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                        bool fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ is CqlDateTime;

                        return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
                    };
                    bool fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_()
                    {
                        DataType fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = @this?.Effective;
                        object fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                        bool gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ is CqlInterval<CqlDateTime>;

                        return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
                    };
                    bool fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_()
                    {
                        DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = @this?.Effective;
                        object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                        bool gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ is CqlDateTime;

                        return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
                    };
                    if (fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_())
                    {
                        DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = @this?.Effective;
                        object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

                        return (gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ as CqlDateTime) as object;
                    }
                    else if (fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_())
                    {
                        DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = @this?.Effective;
                        object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

                        return (gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_())
                    {
                        DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = @this?.Effective;
                        object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

                        return (gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ as CqlDateTime) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.earliest(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_());

                return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
            };
            IEnumerable<Observation> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.SortBy<Observation>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, System.ComponentModel.ListSortDirection.Ascending);
            Observation dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.First<Observation>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_?.Value;
            object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_()
            {
                bool gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_()
                {
                    CqlValueSet gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
                    IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(Observation O2Saturation)
                    {
                        object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_()
                        {
                            bool hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_()
                            {
                                DataType hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = O2Saturation?.Effective;
                                object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                                bool izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ is CqlDateTime;

                                return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
                            };
                            bool hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_()
                            {
                                DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = O2Saturation?.Effective;
                                object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                                bool izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ is CqlInterval<CqlDateTime>;

                                return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
                            };
                            bool hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_()
                            {
                                DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = O2Saturation?.Effective;
                                object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                                bool izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ is CqlDateTime;

                                return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
                            };
                            if (hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_())
                            {
                                DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = O2Saturation?.Effective;
                                object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

                                return (izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ as CqlDateTime) as object;
                            }
                            else if (hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_())
                            {
                                DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = O2Saturation?.Effective;
                                object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

                                return (izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_())
                            {
                                DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = O2Saturation?.Effective;
                                object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

                                return (izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.earliest(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_());
                        Period gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = EncounterInpatient?.Period;
                        CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                        CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                        CqlQuantity hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Quantity(1440m, "minutes");
                        CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Subtract(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                        CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                        CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                        CqlQuantity hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Quantity(120m, "minutes");
                        CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Add(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                        CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Interval(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, true, true);
                        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.In<CqlDateTime>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, default);
                        Code<ObservationStatus> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = O2Saturation?.StatusElement;
                        ObservationStatus? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_?.Value;
                        Code<ObservationStatus> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Convert<Code<ObservationStatus>>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                        string hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Convert<string>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                        string[] hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.In<string>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ as IEnumerable<string>);
                        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                        DataType hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = O2Saturation?.Value;
                        object hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Not((bool?)(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ is null));
                        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

                        return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
                    };
                    IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Observation>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                    object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(Observation @this)
                    {
                        object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_()
                        {
                            bool izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_()
                            {
                                DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = @this?.Effective;
                                object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                                bool izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ is CqlDateTime;

                                return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
                            };
                            bool izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_()
                            {
                                DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = @this?.Effective;
                                object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                                bool izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ is CqlInterval<CqlDateTime>;

                                return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
                            };
                            bool izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_()
                            {
                                DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = @this?.Effective;
                                object jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                                bool jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ is CqlDateTime;

                                return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
                            };
                            if (izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_())
                            {
                                DataType jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = @this?.Effective;
                                object jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

                                return (jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ as CqlDateTime) as object;
                            }
                            else if (izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_())
                            {
                                DataType jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = @this?.Effective;
                                object jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

                                return (jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_())
                            {
                                DataType jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = @this?.Effective;
                                object jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

                                return (jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.earliest(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_());

                        return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
                    };
                    IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.SortBy<Observation>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.First<Observation>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                    DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_?.Effective;
                    object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                    bool gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ is CqlDateTime;

                    return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
                };
                bool gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_()
                {
                    CqlValueSet jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
                    IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Observation O2Saturation)
                    {
                        object jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_()
                        {
                            bool kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_()
                            {
                                DataType kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = O2Saturation?.Effective;
                                object kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                                bool kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ is CqlDateTime;

                                return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
                            };
                            bool kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_()
                            {
                                DataType kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = O2Saturation?.Effective;
                                object kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                                bool kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ is CqlInterval<CqlDateTime>;

                                return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
                            };
                            bool kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_()
                            {
                                DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = O2Saturation?.Effective;
                                object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                                bool lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ is CqlDateTime;

                                return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
                            };
                            if (kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_())
                            {
                                DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = O2Saturation?.Effective;
                                object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

                                return (lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ as CqlDateTime) as object;
                            }
                            else if (kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_())
                            {
                                DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = O2Saturation?.Effective;
                                object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

                                return (lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_())
                            {
                                DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = O2Saturation?.Effective;
                                object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

                                return (lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.earliest(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_());
                        Period jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = EncounterInpatient?.Period;
                        CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                        CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                        CqlQuantity jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Quantity(1440m, "minutes");
                        CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Subtract(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                        CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                        CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                        CqlQuantity kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Quantity(120m, "minutes");
                        CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Add(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                        CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Interval(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, true, true);
                        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, default);
                        Code<ObservationStatus> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = O2Saturation?.StatusElement;
                        ObservationStatus? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_?.Value;
                        Code<ObservationStatus> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Convert<Code<ObservationStatus>>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                        string kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Convert<string>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                        string[] kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.In<string>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ as IEnumerable<string>);
                        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                        DataType kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = O2Saturation?.Value;
                        object kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Not((bool?)(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ is null));
                        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

                        return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
                    };
                    IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Observation>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                    object jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_(Observation @this)
                    {
                        object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_()
                        {
                            bool lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_()
                            {
                                DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = @this?.Effective;
                                object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                                bool lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ is CqlDateTime;

                                return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
                            };
                            bool lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_()
                            {
                                DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = @this?.Effective;
                                object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                                bool lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ is CqlInterval<CqlDateTime>;

                                return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
                            };
                            bool lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_()
                            {
                                DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = @this?.Effective;
                                object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                                bool lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ is CqlDateTime;

                                return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
                            };
                            if (lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_())
                            {
                                DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = @this?.Effective;
                                object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

                                return (lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ as CqlDateTime) as object;
                            }
                            else if (lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_())
                            {
                                DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = @this?.Effective;
                                object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

                                return (mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_())
                            {
                                DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = @this?.Effective;
                                object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

                                return (mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.earliest(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_());

                        return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
                    };
                    IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.SortBy<Observation>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.First<Observation>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                    DataType jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_?.Effective;
                    object jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                    bool jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ is CqlInterval<CqlDateTime>;

                    return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
                };
                bool gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_()
                {
                    CqlValueSet mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
                    IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_(Observation O2Saturation)
                    {
                        object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_()
                        {
                            bool nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_()
                            {
                                DataType nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = O2Saturation?.Effective;
                                object nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                                bool nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ is CqlDateTime;

                                return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
                            };
                            bool nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_()
                            {
                                DataType nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = O2Saturation?.Effective;
                                object nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                                bool nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ is CqlInterval<CqlDateTime>;

                                return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
                            };
                            bool nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_()
                            {
                                DataType nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = O2Saturation?.Effective;
                                object nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                                bool nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ is CqlDateTime;

                                return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
                            };
                            if (nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_())
                            {
                                DataType nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = O2Saturation?.Effective;
                                object nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

                                return (nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ as CqlDateTime) as object;
                            }
                            else if (nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_())
                            {
                                DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = O2Saturation?.Effective;
                                object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

                                return (ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_())
                            {
                                DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = O2Saturation?.Effective;
                                object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

                                return (ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.earliest(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_());
                        Period mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = EncounterInpatient?.Period;
                        CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                        CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                        CqlQuantity mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Quantity(1440m, "minutes");
                        CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Subtract(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                        CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                        CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                        CqlQuantity mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Quantity(120m, "minutes");
                        CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Add(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                        CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Interval(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, true, true);
                        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, default);
                        Code<ObservationStatus> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = O2Saturation?.StatusElement;
                        ObservationStatus? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_?.Value;
                        Code<ObservationStatus> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Convert<Code<ObservationStatus>>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                        string nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Convert<string>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                        string[] nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.In<string>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ as IEnumerable<string>);
                        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                        DataType nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = O2Saturation?.Value;
                        object nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Not((bool?)(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ is null));
                        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

                        return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
                    };
                    IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Observation>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                    object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(Observation @this)
                    {
                        object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_()
                        {
                            bool ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_()
                            {
                                DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = @this?.Effective;
                                object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                                bool ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ is CqlDateTime;

                                return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
                            };
                            bool ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_()
                            {
                                DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = @this?.Effective;
                                object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                                bool ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ is CqlInterval<CqlDateTime>;

                                return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
                            };
                            bool ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_()
                            {
                                DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = @this?.Effective;
                                object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                                bool ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ is CqlDateTime;

                                return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
                            };
                            if (ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_())
                            {
                                DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = @this?.Effective;
                                object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

                                return (ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ as CqlDateTime) as object;
                            }
                            else if (ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_())
                            {
                                DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = @this?.Effective;
                                object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

                                return (ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_())
                            {
                                DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = @this?.Effective;
                                object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

                                return (ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.earliest(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_());

                        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
                    };
                    IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.SortBy<Observation>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.First<Observation>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                    DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_?.Effective;
                    object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                    bool mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ is CqlDateTime;

                    return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
                };
                if (gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_())
                {
                    CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
                    IEnumerable<Observation> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_(Observation O2Saturation)
                    {
                        object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_()
                        {
                            bool qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_()
                            {
                                DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = O2Saturation?.Effective;
                                object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                                bool qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ is CqlDateTime;

                                return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
                            };
                            bool qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_()
                            {
                                DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = O2Saturation?.Effective;
                                object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                                bool qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ is CqlInterval<CqlDateTime>;

                                return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
                            };
                            bool qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_()
                            {
                                DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = O2Saturation?.Effective;
                                object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                                bool qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ is CqlDateTime;

                                return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
                            };
                            if (qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_())
                            {
                                DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = O2Saturation?.Effective;
                                object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

                                return (qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ as CqlDateTime) as object;
                            }
                            else if (qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_())
                            {
                                DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = O2Saturation?.Effective;
                                object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

                                return (qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_())
                            {
                                DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = O2Saturation?.Effective;
                                object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

                                return (qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.earliest(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_());
                        Period pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = EncounterInpatient?.Period;
                        CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                        CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                        CqlQuantity pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Quantity(1440m, "minutes");
                        CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Subtract(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                        CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                        CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                        CqlQuantity pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Quantity(120m, "minutes");
                        CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Add(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                        CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Interval(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, true, true);
                        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, default);
                        Code<ObservationStatus> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = O2Saturation?.StatusElement;
                        ObservationStatus? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_?.Value;
                        Code<ObservationStatus> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<Code<ObservationStatus>>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                        string pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<string>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                        string[] pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<string>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ as IEnumerable<string>);
                        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                        DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = O2Saturation?.Value;
                        object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Not((bool?)(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ is null));
                        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

                        return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
                    };
                    IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Observation>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                    object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_(Observation @this)
                    {
                        object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_()
                        {
                            bool rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_()
                            {
                                DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = @this?.Effective;
                                object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                                bool rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ is CqlDateTime;

                                return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
                            };
                            bool rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_()
                            {
                                DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = @this?.Effective;
                                object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                                bool rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ is CqlInterval<CqlDateTime>;

                                return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
                            };
                            bool rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_()
                            {
                                DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = @this?.Effective;
                                object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                                bool rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ is CqlDateTime;

                                return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
                            };
                            if (rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_())
                            {
                                DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = @this?.Effective;
                                object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

                                return (rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ as CqlDateTime) as object;
                            }
                            else if (rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_())
                            {
                                DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = @this?.Effective;
                                object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

                                return (rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_())
                            {
                                DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = @this?.Effective;
                                object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

                                return (rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.earliest(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_());

                        return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
                    };
                    IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.SortBy<Observation>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.First<Observation>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                    DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_?.Effective;
                    object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

                    return (pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ as CqlDateTime) as object;
                }
                else if (gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_())
                {
                    CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
                    IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_(Observation O2Saturation)
                    {
                        object szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_()
                        {
                            bool tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_()
                            {
                                DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = O2Saturation?.Effective;
                                object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                                bool tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ is CqlDateTime;

                                return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
                            };
                            bool tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_()
                            {
                                DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = O2Saturation?.Effective;
                                object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                                bool tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ is CqlInterval<CqlDateTime>;

                                return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
                            };
                            bool tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_()
                            {
                                DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = O2Saturation?.Effective;
                                object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                                bool tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ is CqlDateTime;

                                return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
                            };
                            if (tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_())
                            {
                                DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = O2Saturation?.Effective;
                                object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

                                return (tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ as CqlDateTime) as object;
                            }
                            else if (tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_())
                            {
                                DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = O2Saturation?.Effective;
                                object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

                                return (tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_())
                            {
                                DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = O2Saturation?.Effective;
                                object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

                                return (tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.earliest(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_());
                        Period szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = EncounterInpatient?.Period;
                        CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                        CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                        CqlQuantity szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Quantity(1440m, "minutes");
                        CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Subtract(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                        CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                        CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Start(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                        CqlQuantity szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Quantity(120m, "minutes");
                        CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Add(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                        CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Interval(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, true, true);
                        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.In<CqlDateTime>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, default);
                        Code<ObservationStatus> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = O2Saturation?.StatusElement;
                        ObservationStatus? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_?.Value;
                        Code<ObservationStatus> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Convert<Code<ObservationStatus>>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                        string szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Convert<string>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                        string[] szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<string>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ as IEnumerable<string>);
                        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                        DataType szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = O2Saturation?.Value;
                        object szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Not((bool?)(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ is null));
                        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

                        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
                    };
                    IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Observation>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                    object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_(Observation @this)
                    {
                        object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_()
                        {
                            bool tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_()
                            {
                                DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = @this?.Effective;
                                object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                                bool tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ is CqlDateTime;

                                return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
                            };
                            bool tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_()
                            {
                                DataType uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = @this?.Effective;
                                object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                                bool uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ is CqlInterval<CqlDateTime>;

                                return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
                            };
                            bool tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_()
                            {
                                DataType uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = @this?.Effective;
                                object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                                bool uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ is CqlDateTime;

                                return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
                            };
                            if (tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_())
                            {
                                DataType uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = @this?.Effective;
                                object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

                                return (uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ as CqlDateTime) as object;
                            }
                            else if (tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_())
                            {
                                DataType uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = @this?.Effective;
                                object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

                                return (uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_())
                            {
                                DataType uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = @this?.Effective;
                                object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

                                return (uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.earliest(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_());

                        return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
                    };
                    IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.SortBy<Observation>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.First<Observation>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                    DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_?.Effective;
                    object szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

                    return (szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_())
                {
                    CqlValueSet uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Oxygen_Saturation_by_Pulse_Oximetry(context);
                    IEnumerable<Observation> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
                    bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Observation O2Saturation)
                    {
                        object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_()
                        {
                            bool vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_()
                            {
                                DataType vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = O2Saturation?.Effective;
                                object vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                                bool vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ is CqlDateTime;

                                return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
                            };
                            bool vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_()
                            {
                                DataType wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = O2Saturation?.Effective;
                                object wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                                bool wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ is CqlInterval<CqlDateTime>;

                                return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
                            };
                            bool vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_()
                            {
                                DataType wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = O2Saturation?.Effective;
                                object wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                                bool wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ is CqlDateTime;

                                return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
                            };
                            if (vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_())
                            {
                                DataType wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = O2Saturation?.Effective;
                                object wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

                                return (wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ as CqlDateTime) as object;
                            }
                            else if (vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_())
                            {
                                DataType wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = O2Saturation?.Effective;
                                object wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

                                return (wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_())
                            {
                                DataType wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = O2Saturation?.Effective;
                                object wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

                                return (wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.earliest(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_());
                        Period uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = EncounterInpatient?.Period;
                        CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                        CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Start(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                        CqlQuantity vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Quantity(1440m, "minutes");
                        CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Subtract(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                        CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                        CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Start(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                        CqlQuantity vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Quantity(120m, "minutes");
                        CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Add(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                        CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Interval(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, true, true);
                        bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.In<CqlDateTime>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, default);
                        Code<ObservationStatus> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = O2Saturation?.StatusElement;
                        ObservationStatus? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_?.Value;
                        Code<ObservationStatus> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<Code<ObservationStatus>>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                        string vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Convert<string>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                        string[] vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.In<string>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ as IEnumerable<string>);
                        bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                        DataType vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = O2Saturation?.Value;
                        object vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                        bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Not((bool?)(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ is null));
                        bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

                        return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
                    };
                    IEnumerable<Observation> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Observation>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                    object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_(Observation @this)
                    {
                        object wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_()
                        {
                            bool wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_()
                            {
                                DataType wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = @this?.Effective;
                                object wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                                bool wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ is CqlDateTime;

                                return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
                            };
                            bool wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_()
                            {
                                DataType wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = @this?.Effective;
                                object wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                                bool wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ is CqlInterval<CqlDateTime>;

                                return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
                            };
                            bool wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_()
                            {
                                DataType wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = @this?.Effective;
                                object wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                                bool wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ is CqlDateTime;

                                return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
                            };
                            if (wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_())
                            {
                                DataType xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = @this?.Effective;
                                object xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

                                return (xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ as CqlDateTime) as object;
                            }
                            else if (wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_())
                            {
                                DataType xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = @this?.Effective;
                                object xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

                                return (xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_())
                            {
                                DataType xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = @this?.Effective;
                                object xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

                                return (xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            }
                        };
                        CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.earliest(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_());

                        return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
                    };
                    IEnumerable<Observation> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.SortBy<Observation>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.First<Observation>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                    DataType uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_?.Effective;
                    object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

                    return (uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                }
            };
            CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.earliest(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_());
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = (CqlTupleMetadata_FdREYEdHOZIcMCNYCRFJYJReA, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ as CqlQuantity, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

            return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)?> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)?>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)?> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstOxygenSatResult, CqlDateTime Timing)?>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

        return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with First Respiratory Rate")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstRespRateResult, CqlDateTime Timing)?> Encounter_with_First_Respiratory_Rate(CqlContext context)
    {
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstRespRateResult, CqlDateTime Timing)? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(Encounter EncounterInpatient)
        {
            Id xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = EncounterInpatient?.IdElement;
            string xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_?.Value;
            IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/resprate"));
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(Observation RespRate)
            {
                DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = RespRate?.Effective;
                object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.earliest(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                Period yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlQuantity yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Subtract(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlQuantity yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Add(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Interval(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, true, true);
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.In<CqlDateTime>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, default);
                Code<ObservationStatus> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = RespRate?.StatusElement;
                ObservationStatus? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_?.Value;
                string yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Convert<string>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                string[] yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.In<string>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ as IEnumerable<string>);
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = RespRate?.Value;
                CqlQuantity zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ as Quantity);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Not((bool?)(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ is null));
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

                return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Observation>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            object xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(Observation @this)
            {
                DataType zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = @this?.Effective;
                object zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.earliest(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

                return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.SortBy<Observation>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, System.ComponentModel.ListSortDirection.Ascending);
            Observation xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.First<Observation>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            DataType xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_?.Value;
            CqlQuantity xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ as Quantity);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_(Observation RespRate)
            {
                DataType zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = RespRate?.Effective;
                object zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.earliest(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                Period zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlQuantity zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Subtract(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlQuantity zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Quantity(120m, "minutes");
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Add(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Interval(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, true, true);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, default);
                Code<ObservationStatus> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = RespRate?.StatusElement;
                ObservationStatus? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_?.Value;
                string zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<string>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                string[] zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<string>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ as IEnumerable<string>);
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                DataType azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = RespRate?.Value;
                CqlQuantity azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ as Quantity);
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Not((bool?)(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ is null));
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

                return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Observation>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            object xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_(Observation @this)
            {
                DataType azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = @this?.Effective;
                object azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.earliest(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

                return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.SortBy<Observation>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, System.ComponentModel.ListSortDirection.Ascending);
            Observation xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.First<Observation>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_?.Effective;
            object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.earliest(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstRespRateResult, CqlDateTime Timing)? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = (CqlTupleMetadata_CYbMQaXdPgTVSLXJSHHNTbhVM, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ as CqlQuantity, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

            return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstRespRateResult, CqlDateTime Timing)?> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstRespRateResult, CqlDateTime Timing)?>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstRespRateResult, CqlDateTime Timing)?> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstRespRateResult, CqlDateTime Timing)?>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

        return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition(
        definitionName: "Blood Pressure Reading")]
    public IEnumerable<Observation> Blood_Pressure_Reading(CqlContext context)
    {
        IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bp"));
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_(Observation BloodPressure)
        {
            Code<ObservationStatus> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = BloodPressure?.StatusElement;
            ObservationStatus? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_?.Value;
            string azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Convert<string>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            string[] azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.In<string>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ as IEnumerable<string>);

            return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Observation>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with First Systolic Blood Pressure")]
    public IEnumerable<string> Encounter_with_First_Systolic_Blood_Pressure(CqlContext context)
    {
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Inpatient_Encounters(context);
        string azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(Encounter EncounterInpatient)
        {
            Id azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = EncounterInpatient?.IdElement;
            string azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_?.Value;

            return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<string> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Select<Encounter, string>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<string> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Distinct<string>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with First Bicarbonate Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> Encounter_with_First_Bicarbonate_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_(Encounter EncounterInpatient)
        {
            Id bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = EncounterInpatient?.IdElement;
            string bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_?.Value;
            CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Bicarbonate_lab_test(context);
            IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_(Observation bicarbonatelab)
            {
                Instant bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = bicarbonatelab?.IssuedElement;
                DateTimeOffset? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_?.Value;
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.earliest(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ as object);
                Period czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlQuantity czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Subtract(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Add(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Interval(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, true, true);
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.In<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, default);
                Code<ObservationStatus> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = bicarbonatelab?.StatusElement;
                ObservationStatus? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_?.Value;
                string czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Convert<string>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                string[] czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.In<string>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ as IEnumerable<string>);
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                DataType czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = bicarbonatelab?.Value;
                object czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Not((bool?)(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ is null));
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

                return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Observation>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            object bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_(Observation @this)
            {
                Instant czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = @this?.IssuedElement;
                DateTimeOffset? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_?.Value;
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<CqlDateTime>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.earliest(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ as object);

                return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.SortBy<Observation>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, System.ComponentModel.ListSortDirection.Ascending);
            Observation bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.First<Observation>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_?.Value;
            object bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(Observation bicarbonatelab)
            {
                Instant dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = bicarbonatelab?.IssuedElement;
                DateTimeOffset? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_?.Value;
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.earliest(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ as object);
                Period dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlQuantity dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Subtract(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Add(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Interval(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, true, true);
                bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.In<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, default);
                Code<ObservationStatus> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = bicarbonatelab?.StatusElement;
                ObservationStatus? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_?.Value;
                string dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Convert<string>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                string[] dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<string>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ as IEnumerable<string>);
                bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = bicarbonatelab?.Value;
                object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Not((bool?)(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ is null));
                bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

                return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Observation>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            object bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(Observation @this)
            {
                Instant ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = @this?.IssuedElement;
                DateTimeOffset? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_?.Value;
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<CqlDateTime>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.earliest(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ as object);

                return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.SortBy<Observation>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, System.ComponentModel.ListSortDirection.Ascending);
            Observation bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.First<Observation>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            Instant bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_?.IssuedElement;
            DateTimeOffset? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_?.Value;
            CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Convert<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = (CqlTupleMetadata_HDVhZFAYAdGHPZJWcDFSNFGPd, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ as CqlQuantity, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

            return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with First Creatinine Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> Encounter_with_First_Creatinine_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_(Encounter EncounterInpatient)
        {
            Id ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = EncounterInpatient?.IdElement;
            string ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_?.Value;
            CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Creatinine_lab_test(context);
            IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_(Observation CreatinineLab)
            {
                Instant fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = CreatinineLab?.IssuedElement;
                DateTimeOffset? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_?.Value;
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<CqlDateTime>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.earliest(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ as object);
                Period fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Start(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlQuantity fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Subtract(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Add(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Interval(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, true, true);
                bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.In<CqlDateTime>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, default);
                Code<ObservationStatus> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = CreatinineLab?.StatusElement;
                ObservationStatus? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_?.Value;
                string fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<string>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                string[] fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<string>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ as IEnumerable<string>);
                bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = CreatinineLab?.Value;
                object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Not((bool?)(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ is null));
                bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

                return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Observation>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            object ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Observation @this)
            {
                Instant gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = @this?.IssuedElement;
                DateTimeOffset? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_?.Value;
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<CqlDateTime>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.earliest(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ as object);

                return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.SortBy<Observation>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, System.ComponentModel.ListSortDirection.Ascending);
            Observation ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.First<Observation>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            DataType ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_?.Value;
            object ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_(Observation CreatinineLab)
            {
                Instant gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = CreatinineLab?.IssuedElement;
                DateTimeOffset? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_?.Value;
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<CqlDateTime>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.earliest(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ as object);
                Period gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlQuantity gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Subtract(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Add(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Interval(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, true, true);
                bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.In<CqlDateTime>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default);
                Code<ObservationStatus> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = CreatinineLab?.StatusElement;
                ObservationStatus? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_?.Value;
                string hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<string>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                string[] hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.In<string>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ as IEnumerable<string>);
                bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                DataType hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = CreatinineLab?.Value;
                object hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Not((bool?)(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ is null));
                bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

                return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Observation>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            object ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_(Observation @this)
            {
                Instant hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = @this?.IssuedElement;
                DateTimeOffset? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_?.Value;
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<CqlDateTime>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.earliest(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ as object);

                return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
            };
            IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.SortBy<Observation>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, System.ComponentModel.ListSortDirection.Ascending);
            Observation ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.First<Observation>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            Instant fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_?.IssuedElement;
            DateTimeOffset? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_?.Value;
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<CqlDateTime>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = (CqlTupleMetadata_HDVhZFAYAdGHPZJWcDFSNFGPd, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ as CqlQuantity, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

            return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with First Glucose Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> Encounter_with_First_Glucose_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(Encounter EncounterInpatient)
        {
            Id hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = EncounterInpatient?.IdElement;
            string hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_?.Value;
            CqlValueSet hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Glucose_lab_test(context);
            IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_(Observation GlucoseLab)
            {
                Instant izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = GlucoseLab?.IssuedElement;
                DateTimeOffset? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_?.Value;
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Convert<CqlDateTime>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.earliest(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ as object);
                Period izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlQuantity izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Subtract(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Add(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Interval(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, true, true);
                bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDateTime>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, default);
                Code<ObservationStatus> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = GlucoseLab?.StatusElement;
                ObservationStatus? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_?.Value;
                string jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Convert<string>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                string[] jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.In<string>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ as IEnumerable<string>);
                bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                DataType jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = GlucoseLab?.Value;
                object jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Not((bool?)(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ is null));
                bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

                return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
            };
            IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Observation>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            object hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_(Observation @this)
            {
                Instant jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = @this?.IssuedElement;
                DateTimeOffset? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_?.Value;
                CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Convert<CqlDateTime>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.earliest(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ as object);

                return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
            };
            IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.SortBy<Observation>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, System.ComponentModel.ListSortDirection.Ascending);
            Observation hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.First<Observation>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            DataType hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_?.Value;
            object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            IEnumerable<Observation> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_(Observation GlucoseLab)
            {
                Instant jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = GlucoseLab?.IssuedElement;
                DateTimeOffset? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_?.Value;
                CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Convert<CqlDateTime>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.earliest(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ as object);
                Period jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlQuantity jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Subtract(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Add(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Interval(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, true, true);
                bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, default);
                Code<ObservationStatus> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = GlucoseLab?.StatusElement;
                ObservationStatus? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_?.Value;
                string kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Convert<string>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                string[] kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.In<string>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ as IEnumerable<string>);
                bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                DataType kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = GlucoseLab?.Value;
                object kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Not((bool?)(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ is null));
                bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

                return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
            };
            IEnumerable<Observation> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Observation>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_(Observation @this)
            {
                Instant kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = @this?.IssuedElement;
                DateTimeOffset? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_?.Value;
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Convert<CqlDateTime>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.earliest(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ as object);

                return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<Observation> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.SortBy<Observation>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, System.ComponentModel.ListSortDirection.Ascending);
            Observation izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.First<Observation>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            Instant izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_?.IssuedElement;
            DateTimeOffset? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_?.Value;
            CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<CqlDateTime>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = (CqlTupleMetadata_HDVhZFAYAdGHPZJWcDFSNFGPd, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ as CqlQuantity, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

            return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

        return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with First Hematocrit Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> Encounter_with_First_Hematocrit_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_(Encounter EncounterInpatient)
        {
            Id kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = EncounterInpatient?.IdElement;
            string kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_?.Value;
            CqlValueSet lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Hematocrit_lab_test(context);
            IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_(Observation HematocritLab)
            {
                Instant lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = HematocritLab?.IssuedElement;
                DateTimeOffset? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_?.Value;
                CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<CqlDateTime>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.earliest(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ as object);
                Period lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlQuantity mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Subtract(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Add(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Interval(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, true, true);
                bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.In<CqlDateTime>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default);
                Code<ObservationStatus> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = HematocritLab?.StatusElement;
                ObservationStatus? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_?.Value;
                string mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Convert<string>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                string[] mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.In<string>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ as IEnumerable<string>);
                bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = HematocritLab?.Value;
                object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Not((bool?)(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ is null));
                bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

                return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Observation>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_(Observation @this)
            {
                Instant mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = @this?.IssuedElement;
                DateTimeOffset? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_?.Value;
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<CqlDateTime>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.earliest(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ as object);

                return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
            };
            IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.SortBy<Observation>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, System.ComponentModel.ListSortDirection.Ascending);
            Observation lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.First<Observation>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_?.Value;
            object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_(Observation HematocritLab)
            {
                Instant mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = HematocritLab?.IssuedElement;
                DateTimeOffset? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_?.Value;
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<CqlDateTime>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.earliest(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ as object);
                Period nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlQuantity nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Subtract(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Add(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Interval(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, true, true);
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.In<CqlDateTime>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, default);
                Code<ObservationStatus> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = HematocritLab?.StatusElement;
                ObservationStatus? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_?.Value;
                string nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<string>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                string[] nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.In<string>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ as IEnumerable<string>);
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                DataType nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = HematocritLab?.Value;
                object nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Not((bool?)(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ is null));
                bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

                return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
            };
            IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Observation>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(Observation @this)
            {
                Instant nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = @this?.IssuedElement;
                DateTimeOffset? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_?.Value;
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<CqlDateTime>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.earliest(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ as object);

                return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.SortBy<Observation>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, System.ComponentModel.ListSortDirection.Ascending);
            Observation lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.First<Observation>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            Instant lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_?.IssuedElement;
            DateTimeOffset? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_?.Value;
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Convert<CqlDateTime>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = (CqlTupleMetadata_HDVhZFAYAdGHPZJWcDFSNFGPd, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ as CqlQuantity, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

            return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

        return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with First Potassium Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> Encounter_with_First_Potassium_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_(Encounter EncounterInpatient)
        {
            Id ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = EncounterInpatient?.IdElement;
            string ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_?.Value;
            CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Potassium_lab_test(context);
            IEnumerable<Observation> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Observation PotassiumLab)
            {
                Instant pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = PotassiumLab?.IssuedElement;
                DateTimeOffset? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_?.Value;
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Convert<CqlDateTime>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.earliest(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ as object);
                Period pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Start(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlQuantity pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Subtract(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Add(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Interval(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, true, true);
                bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, default);
                Code<ObservationStatus> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = PotassiumLab?.StatusElement;
                ObservationStatus? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_?.Value;
                string pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Convert<string>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                string[] pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.In<string>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ as IEnumerable<string>);
                bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = PotassiumLab?.Value;
                object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Not((bool?)(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ is null));
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

                return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<Observation> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Observation>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_(Observation @this)
            {
                Instant qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = @this?.IssuedElement;
                DateTimeOffset? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_?.Value;
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Convert<CqlDateTime>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.earliest(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ as object);

                return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<Observation> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.SortBy<Observation>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, System.ComponentModel.ListSortDirection.Ascending);
            Observation ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.First<Observation>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_?.Value;
            object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            IEnumerable<Observation> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_(Observation PotassiumLab)
            {
                Instant qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = PotassiumLab?.IssuedElement;
                DateTimeOffset? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_?.Value;
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Convert<CqlDateTime>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.earliest(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ as object);
                Period qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlQuantity qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Subtract(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Start(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Add(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Interval(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, true, true);
                bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.In<CqlDateTime>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, default);
                Code<ObservationStatus> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = PotassiumLab?.StatusElement;
                ObservationStatus? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_?.Value;
                string qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<string>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                string[] qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<string>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ as IEnumerable<string>);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = PotassiumLab?.Value;
                object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Not((bool?)(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ is null));
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

                return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<Observation> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Observation>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_(Observation @this)
            {
                Instant rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = @this?.IssuedElement;
                DateTimeOffset? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_?.Value;
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Convert<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.earliest(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ as object);

                return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<Observation> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.SortBy<Observation>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, System.ComponentModel.ListSortDirection.Ascending);
            Observation ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.First<Observation>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            Instant ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_?.IssuedElement;
            DateTimeOffset? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_?.Value;
            CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<CqlDateTime>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = (CqlTupleMetadata_HDVhZFAYAdGHPZJWcDFSNFGPd, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ as CqlQuantity, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

            return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with First Sodium Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> Encounter_with_First_Sodium_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_(Encounter EncounterInpatient)
        {
            Id rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = EncounterInpatient?.IdElement;
            string rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_?.Value;
            CqlValueSet rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Sodium_lab_test(context);
            IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(Observation SodiumLab)
            {
                Instant szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = SodiumLab?.IssuedElement;
                DateTimeOffset? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_?.Value;
                CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Convert<CqlDateTime>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.earliest(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ as object);
                Period szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlQuantity szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Subtract(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Start(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Add(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Interval(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, true, true);
                bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<CqlDateTime>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, default);
                Code<ObservationStatus> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = SodiumLab?.StatusElement;
                ObservationStatus? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_?.Value;
                string tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<string>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                string[] tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.In<string>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ as IEnumerable<string>);
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = SodiumLab?.Value;
                object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Not((bool?)(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ is null));
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

                return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Observation>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_(Observation @this)
            {
                Instant tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = @this?.IssuedElement;
                DateTimeOffset? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_?.Value;
                CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Convert<CqlDateTime>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.earliest(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ as object);

                return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.SortBy<Observation>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, System.ComponentModel.ListSortDirection.Ascending);
            Observation rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.First<Observation>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_?.Value;
            object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            IEnumerable<Observation> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_(Observation SodiumLab)
            {
                Instant tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = SodiumLab?.IssuedElement;
                DateTimeOffset? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_?.Value;
                CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<CqlDateTime>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.earliest(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ as object);
                Period tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlQuantity tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Subtract(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Add(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Interval(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, true, true);
                bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, default);
                Code<ObservationStatus> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = SodiumLab?.StatusElement;
                ObservationStatus? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_?.Value;
                string uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<string>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                string[] uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.In<string>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ as IEnumerable<string>);
                bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                DataType uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = SodiumLab?.Value;
                object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Not((bool?)(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ is null));
                bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

                return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<Observation> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Observation>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            object szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_(Observation @this)
            {
                Instant uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = @this?.IssuedElement;
                DateTimeOffset? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_?.Value;
                CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<CqlDateTime>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.earliest(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ as object);

                return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
            };
            IEnumerable<Observation> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.SortBy<Observation>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, System.ComponentModel.ListSortDirection.Ascending);
            Observation szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.First<Observation>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            Instant szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_?.IssuedElement;
            DateTimeOffset? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_?.Value;
            CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Convert<CqlDateTime>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = (CqlTupleMetadata_HDVhZFAYAdGHPZJWcDFSNFGPd, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ as CqlQuantity, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

            return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

        return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with First White Blood Cells Lab Test")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> Encounter_with_First_White_Blood_Cells_Lab_Test(CqlContext context)
    {
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_(Encounter EncounterInpatient)
        {
            Id uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = EncounterInpatient?.IdElement;
            string uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_?.Value;
            CqlValueSet uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.White_blood_cells_count_lab_test(context);
            IEnumerable<Observation> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_(Observation WhiteBloodCellLab)
            {
                Instant vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = WhiteBloodCellLab?.IssuedElement;
                DateTimeOffset? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_?.Value;
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Convert<CqlDateTime>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.earliest(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ as object);
                Period vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlQuantity vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Subtract(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Add(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Interval(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, true, true);
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.In<CqlDateTime>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, default);
                Code<ObservationStatus> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = WhiteBloodCellLab?.StatusElement;
                ObservationStatus? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_?.Value;
                string wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<string>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                string[] wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.In<string>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ as IEnumerable<string>);
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                DataType wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = WhiteBloodCellLab?.Value;
                object wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Not((bool?)(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ is null));
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

                return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
            };
            IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Observation>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            object vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_(Observation @this)
            {
                Instant wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = @this?.IssuedElement;
                DateTimeOffset? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_?.Value;
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Convert<CqlDateTime>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.earliest(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ as object);

                return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.SortBy<Observation>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, System.ComponentModel.ListSortDirection.Ascending);
            Observation vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.First<Observation>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            DataType vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_?.Value;
            object vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-observation-lab"));
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_(Observation WhiteBloodCellLab)
            {
                Instant wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = WhiteBloodCellLab?.IssuedElement;
                DateTimeOffset? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_?.Value;
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<CqlDateTime>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.earliest(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ as object);
                Period xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = EncounterInpatient?.Period;
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlQuantity xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Quantity(1440m, "minutes");
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Subtract(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Add(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Interval(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, true, true);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.In<CqlDateTime>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, default);
                Code<ObservationStatus> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = WhiteBloodCellLab?.StatusElement;
                ObservationStatus? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_?.Value;
                string xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Convert<string>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                string[] xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.In<string>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ as IEnumerable<string>);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                DataType xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = WhiteBloodCellLab?.Value;
                object xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Not((bool?)(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ is null));
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

                return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Observation>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            object vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_(Observation @this)
            {
                Instant xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = @this?.IssuedElement;
                DateTimeOffset? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_?.Value;
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<CqlDateTime>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.earliest(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ as object);

                return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.SortBy<Observation>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, System.ComponentModel.ListSortDirection.Ascending);
            Observation vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.First<Observation>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            Instant vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_?.IssuedElement;
            DateTimeOffset? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_?.Value;
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<CqlDateTime>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = (CqlTupleMetadata_HDVhZFAYAdGHPZJWcDFSNFGPd, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ as CqlQuantity, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

            return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

        return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition(
        definitionName: "Encounter with First Weight Recorded During Stay")]
    public IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> Encounter_with_First_Weight_Recorded_During_Stay(CqlContext context)
    {
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Inpatient_Encounters(context);
        (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_(Encounter EncounterInpatient)
        {
            Id yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = EncounterInpatient?.IdElement;
            string yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_?.Value;
            IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bodyweight"));
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(Observation WeightExam)
            {
                DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = WeightExam?.Effective;
                object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.earliest(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.In<CqlDateTime>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, default);
                Code<ObservationStatus> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = WeightExam?.StatusElement;
                ObservationStatus? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_?.Value;
                string zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<string>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                string[] zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.In<string>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ as IEnumerable<string>);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                DataType zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = WeightExam?.Value;
                CqlQuantity zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ as Quantity);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Not((bool?)(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ is null));
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

                return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
            };
            IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Observation>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_(Observation @this)
            {
                DataType zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = @this?.Effective;
                object zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.earliest(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

                return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
            };
            IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.SortBy<Observation>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, System.ComponentModel.ListSortDirection.Ascending);
            Observation yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.First<Observation>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_?.Value;
            CqlQuantity yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ as Quantity);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(Observation WeightExam)
            {
                DataType zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = WeightExam?.Effective;
                object zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.earliest(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = CQMCommon_2_2_000.Instance.hospitalizationWithObservationAndOutpatientSurgeryService(context, EncounterInpatient);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, default);
                Code<ObservationStatus> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = WeightExam?.StatusElement;
                ObservationStatus? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_?.Value;
                string zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<string>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                string[] zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<string>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ as IEnumerable<string>);
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                DataType azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = WeightExam?.Value;
                CqlQuantity azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ as Quantity);
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Not((bool?)(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ is null));
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

                return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Observation>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(Observation @this)
            {
                DataType azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = @this?.Effective;
                object azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.earliest(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

                return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<Observation> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.SortBy<Observation>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, System.ComponentModel.ListSortDirection.Ascending);
            Observation yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.First<Observation>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_?.Effective;
            object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.earliest(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = (CqlTupleMetadata_HDVhZFAYAdGHPZJWcDFSNFGPd, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ as CqlQuantity, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

            return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Distinct<(CqlTupleMetadata, string EncounterId, CqlQuantity FirstResult, CqlDateTime Timing)?>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

        return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
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
