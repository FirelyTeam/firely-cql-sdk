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
[CqlLibrary("AdvancedIllnessandFrailty", "1.16.000")]
public partial class AdvancedIllnessandFrailty_1_16_000 : ILibrary, ISingleton<AdvancedIllnessandFrailty_1_16_000>
{
    private AdvancedIllnessandFrailty_1_16_000() {}

    public static AdvancedIllnessandFrailty_1_16_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "AdvancedIllnessandFrailty";
    public string Version => "1.16.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, QICoreCommon_2_1_000.Instance, CumulativeMedicationDuration_4_1_000.Instance, Status_1_8_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    #region ValueSet: Advanced Illness
    [CqlValueSetDefinition(
        definitionName: "Advanced Illness",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1082",
        valueSetVersion: null)]
    public CqlValueSet Advanced_Illness(CqlContext context) => _Advanced_Illness;

    private static readonly CqlValueSet _Advanced_Illness = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1082", null);
    #endregion

    #region ValueSet: Dementia Medications
    [CqlValueSetDefinition(
        definitionName: "Dementia Medications",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1510",
        valueSetVersion: null)]
    public CqlValueSet Dementia_Medications(CqlContext context) => _Dementia_Medications;

    private static readonly CqlValueSet _Dementia_Medications = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1510", null);
    #endregion

    #region ValueSet: Frailty Device
    [CqlValueSetDefinition(
        definitionName: "Frailty Device",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.118.12.1300",
        valueSetVersion: null)]
    public CqlValueSet Frailty_Device(CqlContext context) => _Frailty_Device;

    private static readonly CqlValueSet _Frailty_Device = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.118.12.1300", null);
    #endregion

    #region ValueSet: Frailty Diagnosis
    [CqlValueSetDefinition(
        definitionName: "Frailty Diagnosis",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1074",
        valueSetVersion: null)]
    public CqlValueSet Frailty_Diagnosis(CqlContext context) => _Frailty_Diagnosis;

    private static readonly CqlValueSet _Frailty_Diagnosis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1074", null);
    #endregion

    #region ValueSet: Frailty Encounter
    [CqlValueSetDefinition(
        definitionName: "Frailty Encounter",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1088",
        valueSetVersion: null)]
    public CqlValueSet Frailty_Encounter(CqlContext context) => _Frailty_Encounter;

    private static readonly CqlValueSet _Frailty_Encounter = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1088", null);
    #endregion

    #region ValueSet: Frailty Symptom
    [CqlValueSetDefinition(
        definitionName: "Frailty Symptom",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1075",
        valueSetVersion: null)]
    public CqlValueSet Frailty_Symptom(CqlContext context) => _Frailty_Symptom;

    private static readonly CqlValueSet _Frailty_Symptom = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1075", null);
    #endregion

    #endregion ValueSets

    #region Codes

    #region Code: Housing status
    [CqlCodeDefinition(
        definitionName: "Housing status",
        codeId: "71802-3",
        codeSystem: "http://loinc.org")]
    public CqlCode Housing_status(CqlContext context) => _Housing_status;

    private static readonly CqlCode _Housing_status = new CqlCode("71802-3", "http://loinc.org", default, default);
    #endregion

    #region Code: Lives in a nursing home (finding)
    [CqlCodeDefinition(
        definitionName: "Lives in a nursing home (finding)",
        codeId: "160734000",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Lives_in_a_nursing_home__finding_(CqlContext context) => _Lives_in_a_nursing_home__finding_;

    private static readonly CqlCode _Lives_in_a_nursing_home__finding_ = new CqlCode("160734000", "http://snomed.info/sct", default, default);
    #endregion

    #region Code: Medical equipment used
    [CqlCodeDefinition(
        definitionName: "Medical equipment used",
        codeId: "98181-1",
        codeSystem: "http://loinc.org")]
    public CqlCode Medical_equipment_used(CqlContext context) => _Medical_equipment_used;

    private static readonly CqlCode _Medical_equipment_used = new CqlCode("98181-1", "http://loinc.org", default, default);
    #endregion

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition(
        definitionName: "LOINC")]
    public CqlCode[] LOINC(CqlContext context)
    {
        CqlCode[] jzzzzzzzzzs_ = [
            new CqlCode("71802-3", "http://loinc.org", default, default),
            new CqlCode("98181-1", "http://loinc.org", default, default),
        ];

        return jzzzzzzzzzs_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "SNOMEDCT")]
    public CqlCode[] SNOMEDCT(CqlContext context)
    {
        CqlCode[] jzzzzzzzzzt_ = [
            new CqlCode("160734000", "http://snomed.info/sct", default, default),
        ];

        return jzzzzzzzzzt_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object jzzzzzzzzzu_ = context.ResolveParameter("AdvancedIllnessandFrailty-1.16.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)jzzzzzzzzzu_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> jzzzzzzzzzv_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient jzzzzzzzzzw_ = context.Operators.SingletonFrom<Patient>(jzzzzzzzzzv_);

        return jzzzzzzzzzw_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Criteria Indicating Frailty")]
    public bool? Has_Criteria_Indicating_Frailty(CqlContext context)
    {
        CqlValueSet jzzzzzzzzzx_ = this.Frailty_Device(context);
        IEnumerable<DeviceRequest> jzzzzzzzzzy_ = context.Operators.Retrieve<DeviceRequest>(new RetrieveParameters(default, jzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-devicerequest"));
        IEnumerable<DeviceRequest> kzzzzzzzzza_ = context.Operators.Retrieve<DeviceRequest>(new RetrieveParameters(default, jzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-devicerequest"));
        IEnumerable<DeviceRequest> kzzzzzzzzzb_ = context.Operators.Union<DeviceRequest>(jzzzzzzzzzy_, kzzzzzzzzza_);
        IEnumerable<DeviceRequest> kzzzzzzzzzc_ = Status_1_8_000.Instance.isDeviceOrder(context, kzzzzzzzzzb_);
        bool? kzzzzzzzzzd_(DeviceRequest FrailtyDeviceOrder)
        {
            bool? lzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.doNotPerform(context, FrailtyDeviceOrder);
            bool? lzzzzzzzzzj_ = context.Operators.IsTrue(lzzzzzzzzzi_);
            bool? lzzzzzzzzzk_ = context.Operators.Not(lzzzzzzzzzj_);
            CqlInterval<CqlDateTime> lzzzzzzzzzl_ = this.Measurement_Period(context);
            FhirDateTime lzzzzzzzzzm_ = FrailtyDeviceOrder?.AuthoredOnElement;
            CqlDateTime lzzzzzzzzzn_ = context.Operators.Convert<CqlDateTime>(lzzzzzzzzzm_);
            CqlInterval<CqlDateTime> lzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.toInterval(context, lzzzzzzzzzn_ as object);
            bool? lzzzzzzzzzp_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(lzzzzzzzzzl_, lzzzzzzzzzo_, "day");
            bool? lzzzzzzzzzq_ = context.Operators.And(lzzzzzzzzzk_, lzzzzzzzzzp_);

            return lzzzzzzzzzq_;
        };
        IEnumerable<DeviceRequest> kzzzzzzzzze_ = context.Operators.Where<DeviceRequest>(kzzzzzzzzzc_, kzzzzzzzzzd_);
        bool? kzzzzzzzzzf_ = context.Operators.Exists<DeviceRequest>(kzzzzzzzzze_);
        CqlCode kzzzzzzzzzg_ = this.Medical_equipment_used(context);
        IEnumerable<CqlCode> kzzzzzzzzzh_ = context.Operators.ToList<CqlCode>(kzzzzzzzzzg_);
        IEnumerable<Observation> kzzzzzzzzzi_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, kzzzzzzzzzh_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> kzzzzzzzzzj_ = Status_1_8_000.Instance.isAssessmentPerformed(context, kzzzzzzzzzi_);
        bool? kzzzzzzzzzk_(Observation EquipmentUsed)
        {
            DataType lzzzzzzzzzr_ = EquipmentUsed?.Value;
            object lzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzr_);
            CqlValueSet lzzzzzzzzzt_ = this.Frailty_Device(context);
            bool? lzzzzzzzzzu_ = context.Operators.ConceptInValueSet(lzzzzzzzzzs_ as CqlConcept, lzzzzzzzzzt_);
            DataType lzzzzzzzzzv_ = EquipmentUsed?.Effective;
            object lzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzv_);
            CqlInterval<CqlDateTime> lzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.toInterval(context, lzzzzzzzzzw_);
            CqlDateTime lzzzzzzzzzy_ = context.Operators.End(lzzzzzzzzzx_);
            CqlInterval<CqlDateTime> lzzzzzzzzzz_ = this.Measurement_Period(context);
            bool? mzzzzzzzzza_ = context.Operators.In<CqlDateTime>(lzzzzzzzzzy_, lzzzzzzzzzz_, "day");
            bool? mzzzzzzzzzb_ = context.Operators.And(lzzzzzzzzzu_, mzzzzzzzzza_);

            return mzzzzzzzzzb_;
        };
        IEnumerable<Observation> kzzzzzzzzzl_ = context.Operators.Where<Observation>(kzzzzzzzzzj_, kzzzzzzzzzk_);
        bool? kzzzzzzzzzm_ = context.Operators.Exists<Observation>(kzzzzzzzzzl_);
        bool? kzzzzzzzzzn_ = context.Operators.Or(kzzzzzzzzzf_, kzzzzzzzzzm_);
        CqlValueSet kzzzzzzzzzo_ = this.Frailty_Diagnosis(context);
        IEnumerable<Condition> kzzzzzzzzzp_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, kzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? kzzzzzzzzzq_(Condition FrailtyDiagnosis)
        {
            CqlInterval<CqlDateTime> mzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, FrailtyDiagnosis);
            CqlInterval<CqlDateTime> mzzzzzzzzzd_ = this.Measurement_Period(context);
            bool? mzzzzzzzzze_ = context.Operators.Overlaps(mzzzzzzzzzc_, mzzzzzzzzzd_, "day");

            return mzzzzzzzzze_;
        };
        IEnumerable<Condition> kzzzzzzzzzr_ = context.Operators.Where<Condition>(kzzzzzzzzzp_, kzzzzzzzzzq_);
        bool? kzzzzzzzzzs_ = context.Operators.Exists<Condition>(kzzzzzzzzzr_);
        bool? kzzzzzzzzzt_ = context.Operators.Or(kzzzzzzzzzn_, kzzzzzzzzzs_);
        CqlValueSet kzzzzzzzzzu_ = this.Frailty_Encounter(context);
        IEnumerable<Encounter> kzzzzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, kzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> kzzzzzzzzzw_ = Status_1_8_000.Instance.isEncounterPerformed(context, kzzzzzzzzzv_);
        bool? kzzzzzzzzzx_(Encounter FrailtyEncounter)
        {
            Period mzzzzzzzzzf_ = FrailtyEncounter?.Period;
            CqlInterval<CqlDateTime> mzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzf_);
            CqlInterval<CqlDateTime> mzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.toInterval(context, mzzzzzzzzzg_ as object);
            CqlInterval<CqlDateTime> mzzzzzzzzzi_ = this.Measurement_Period(context);
            bool? mzzzzzzzzzj_ = context.Operators.Overlaps(mzzzzzzzzzh_, mzzzzzzzzzi_, "day");

            return mzzzzzzzzzj_;
        };
        IEnumerable<Encounter> kzzzzzzzzzy_ = context.Operators.Where<Encounter>(kzzzzzzzzzw_, kzzzzzzzzzx_);
        bool? kzzzzzzzzzz_ = context.Operators.Exists<Encounter>(kzzzzzzzzzy_);
        bool? lzzzzzzzzza_ = context.Operators.Or(kzzzzzzzzzt_, kzzzzzzzzzz_);
        CqlValueSet lzzzzzzzzzb_ = this.Frailty_Symptom(context);
        IEnumerable<Observation> lzzzzzzzzzc_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, lzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> lzzzzzzzzzd_ = Status_1_8_000.Instance.isSymptom(context, lzzzzzzzzzc_);
        bool? lzzzzzzzzze_(Observation FrailtySymptom)
        {
            DataType mzzzzzzzzzk_ = FrailtySymptom?.Effective;
            object mzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzk_);
            CqlInterval<CqlDateTime> mzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.toInterval(context, mzzzzzzzzzl_);
            CqlInterval<CqlDateTime> mzzzzzzzzzn_ = this.Measurement_Period(context);
            bool? mzzzzzzzzzo_ = context.Operators.Overlaps(mzzzzzzzzzm_, mzzzzzzzzzn_, "day");

            return mzzzzzzzzzo_;
        };
        IEnumerable<Observation> lzzzzzzzzzf_ = context.Operators.Where<Observation>(lzzzzzzzzzd_, lzzzzzzzzze_);
        bool? lzzzzzzzzzg_ = context.Operators.Exists<Observation>(lzzzzzzzzzf_);
        bool? lzzzzzzzzzh_ = context.Operators.Or(lzzzzzzzzza_, lzzzzzzzzzg_);

        return lzzzzzzzzzh_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Advanced Illness in Year Before or During Measurement Period")]
    public bool? Has_Advanced_Illness_in_Year_Before_or_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet mzzzzzzzzzp_ = this.Advanced_Illness(context);
        IEnumerable<Condition> mzzzzzzzzzq_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, mzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? mzzzzzzzzzr_(Condition AdvancedIllnessDiagnosis)
        {
            CqlInterval<CqlDateTime> mzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, AdvancedIllnessDiagnosis);
            CqlDateTime mzzzzzzzzzv_ = context.Operators.Start(mzzzzzzzzzu_);
            CqlInterval<CqlDateTime> mzzzzzzzzzw_ = this.Measurement_Period(context);
            CqlDateTime mzzzzzzzzzx_ = context.Operators.Start(mzzzzzzzzzw_);
            CqlQuantity mzzzzzzzzzy_ = context.Operators.Quantity(1m, "year");
            CqlDateTime mzzzzzzzzzz_ = context.Operators.Subtract(mzzzzzzzzzx_, mzzzzzzzzzy_);
            CqlDateTime nzzzzzzzzzb_ = context.Operators.End(mzzzzzzzzzw_);
            CqlInterval<CqlDateTime> nzzzzzzzzzc_ = context.Operators.Interval(mzzzzzzzzzz_, nzzzzzzzzzb_, true, true);
            bool? nzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(mzzzzzzzzzv_, nzzzzzzzzzc_, "day");

            return nzzzzzzzzzd_;
        };
        IEnumerable<Condition> mzzzzzzzzzs_ = context.Operators.Where<Condition>(mzzzzzzzzzq_, mzzzzzzzzzr_);
        bool? mzzzzzzzzzt_ = context.Operators.Exists<Condition>(mzzzzzzzzzs_);

        return mzzzzzzzzzt_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Dementia Medications in Year Before or During Measurement Period")]
    public bool? Has_Dementia_Medications_in_Year_Before_or_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet nzzzzzzzzze_ = this.Dementia_Medications(context);
        IEnumerable<MedicationRequest> nzzzzzzzzzf_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, nzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> nzzzzzzzzzg_ = Status_1_8_000.Instance.isMedicationActive(context, nzzzzzzzzzf_);
        bool? nzzzzzzzzzh_(MedicationRequest DementiaMedication)
        {
            CqlInterval<CqlDate> nzzzzzzzzzk_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, DementiaMedication);
            CqlDate nzzzzzzzzzl_ = nzzzzzzzzzk_?.low;
            CqlDateTime nzzzzzzzzzm_ = context.Operators.ConvertDateToDateTime(nzzzzzzzzzl_);
            CqlDate nzzzzzzzzzo_ = nzzzzzzzzzk_?.high;
            CqlDateTime nzzzzzzzzzp_ = context.Operators.ConvertDateToDateTime(nzzzzzzzzzo_);
            bool? nzzzzzzzzzr_ = nzzzzzzzzzk_?.lowClosed;
            bool? nzzzzzzzzzt_ = nzzzzzzzzzk_?.highClosed;
            CqlInterval<CqlDateTime> nzzzzzzzzzu_ = context.Operators.Interval(nzzzzzzzzzm_, nzzzzzzzzzp_, nzzzzzzzzzr_, nzzzzzzzzzt_);
            CqlInterval<CqlDateTime> nzzzzzzzzzv_ = this.Measurement_Period(context);
            CqlDateTime nzzzzzzzzzw_ = context.Operators.Start(nzzzzzzzzzv_);
            CqlQuantity nzzzzzzzzzx_ = context.Operators.Quantity(1m, "year");
            CqlDateTime nzzzzzzzzzy_ = context.Operators.Subtract(nzzzzzzzzzw_, nzzzzzzzzzx_);
            CqlDateTime ozzzzzzzzza_ = context.Operators.End(nzzzzzzzzzv_);
            CqlInterval<CqlDateTime> ozzzzzzzzzb_ = context.Operators.Interval(nzzzzzzzzzy_, ozzzzzzzzza_, true, true);
            bool? ozzzzzzzzzc_ = context.Operators.Overlaps(nzzzzzzzzzu_, ozzzzzzzzzb_, "day");

            return ozzzzzzzzzc_;
        };
        IEnumerable<MedicationRequest> nzzzzzzzzzi_ = context.Operators.Where<MedicationRequest>(nzzzzzzzzzg_, nzzzzzzzzzh_);
        bool? nzzzzzzzzzj_ = context.Operators.Exists<MedicationRequest>(nzzzzzzzzzi_);

        return nzzzzzzzzzj_;
    }


    [CqlExpressionDefinition(
        definitionName: "Is Age 66 or Older with Advanced Illness and Frailty")]
    public bool? Is_Age_66_or_Older_with_Advanced_Illness_and_Frailty(CqlContext context)
    {
        Patient ozzzzzzzzzd_ = this.Patient(context);
        Date ozzzzzzzzze_ = ozzzzzzzzzd_?.BirthDateElement;
        string ozzzzzzzzzf_ = ozzzzzzzzze_?.Value;
        CqlDate ozzzzzzzzzg_ = context.Operators.ConvertStringToDate(ozzzzzzzzzf_);
        CqlInterval<CqlDateTime> ozzzzzzzzzh_ = this.Measurement_Period(context);
        CqlDateTime ozzzzzzzzzi_ = context.Operators.End(ozzzzzzzzzh_);
        CqlDate ozzzzzzzzzj_ = context.Operators.DateFrom(ozzzzzzzzzi_);
        int? ozzzzzzzzzk_ = context.Operators.CalculateAgeAt(ozzzzzzzzzg_, ozzzzzzzzzj_, "year");
        bool? ozzzzzzzzzl_ = context.Operators.GreaterOrEqual(ozzzzzzzzzk_, 66);
        bool? ozzzzzzzzzm_ = this.Has_Criteria_Indicating_Frailty(context);
        bool? ozzzzzzzzzn_ = context.Operators.And(ozzzzzzzzzl_, ozzzzzzzzzm_);
        bool? ozzzzzzzzzo_ = this.Has_Advanced_Illness_in_Year_Before_or_During_Measurement_Period(context);
        bool? ozzzzzzzzzp_ = this.Has_Dementia_Medications_in_Year_Before_or_During_Measurement_Period(context);
        bool? ozzzzzzzzzq_ = context.Operators.Or(ozzzzzzzzzo_, ozzzzzzzzzp_);
        bool? ozzzzzzzzzr_ = context.Operators.And(ozzzzzzzzzn_, ozzzzzzzzzq_);

        return ozzzzzzzzzr_;
    }


    [CqlExpressionDefinition(
        definitionName: "Is Age 66 to 80 with Advanced Illness and Frailty or Is Age 81 or Older with Frailty")]
    public bool? Is_Age_66_to_80_with_Advanced_Illness_and_Frailty_or_Is_Age_81_or_Older_with_Frailty(CqlContext context)
    {
        Patient ozzzzzzzzzs_ = this.Patient(context);
        Date ozzzzzzzzzt_ = ozzzzzzzzzs_?.BirthDateElement;
        string ozzzzzzzzzu_ = ozzzzzzzzzt_?.Value;
        CqlDate ozzzzzzzzzv_ = context.Operators.ConvertStringToDate(ozzzzzzzzzu_);
        CqlInterval<CqlDateTime> ozzzzzzzzzw_ = this.Measurement_Period(context);
        CqlDateTime ozzzzzzzzzx_ = context.Operators.End(ozzzzzzzzzw_);
        CqlDate ozzzzzzzzzy_ = context.Operators.DateFrom(ozzzzzzzzzx_);
        int? ozzzzzzzzzz_ = context.Operators.CalculateAgeAt(ozzzzzzzzzv_, ozzzzzzzzzy_, "year");
        CqlInterval<int?> pzzzzzzzzza_ = context.Operators.Interval(66, 80, true, true);
        bool? pzzzzzzzzzb_ = context.Operators.In<int?>(ozzzzzzzzzz_, pzzzzzzzzza_, default);
        bool? pzzzzzzzzzc_ = this.Has_Criteria_Indicating_Frailty(context);
        bool? pzzzzzzzzzd_ = context.Operators.And(pzzzzzzzzzb_, pzzzzzzzzzc_);
        bool? pzzzzzzzzze_ = this.Has_Advanced_Illness_in_Year_Before_or_During_Measurement_Period(context);
        bool? pzzzzzzzzzf_ = this.Has_Dementia_Medications_in_Year_Before_or_During_Measurement_Period(context);
        bool? pzzzzzzzzzg_ = context.Operators.Or(pzzzzzzzzze_, pzzzzzzzzzf_);
        bool? pzzzzzzzzzh_ = context.Operators.And(pzzzzzzzzzd_, pzzzzzzzzzg_);
        Date pzzzzzzzzzj_ = ozzzzzzzzzs_?.BirthDateElement;
        string pzzzzzzzzzk_ = pzzzzzzzzzj_?.Value;
        CqlDate pzzzzzzzzzl_ = context.Operators.ConvertStringToDate(pzzzzzzzzzk_);
        CqlDateTime pzzzzzzzzzn_ = context.Operators.End(ozzzzzzzzzw_);
        CqlDate pzzzzzzzzzo_ = context.Operators.DateFrom(pzzzzzzzzzn_);
        int? pzzzzzzzzzp_ = context.Operators.CalculateAgeAt(pzzzzzzzzzl_, pzzzzzzzzzo_, "year");
        bool? pzzzzzzzzzq_ = context.Operators.GreaterOrEqual(pzzzzzzzzzp_, 81);
        bool? pzzzzzzzzzs_ = context.Operators.And(pzzzzzzzzzq_, pzzzzzzzzzc_);
        bool? pzzzzzzzzzt_ = context.Operators.Or(pzzzzzzzzzh_, pzzzzzzzzzs_);

        return pzzzzzzzzzt_;
    }


    [CqlExpressionDefinition(
        definitionName: "Is Age 66 or Older Living Long Term in a Nursing Home")]
    public bool? Is_Age_66_or_Older_Living_Long_Term_in_a_Nursing_Home(CqlContext context)
    {
        Patient pzzzzzzzzzu_ = this.Patient(context);
        Date pzzzzzzzzzv_ = pzzzzzzzzzu_?.BirthDateElement;
        string pzzzzzzzzzw_ = pzzzzzzzzzv_?.Value;
        CqlDate pzzzzzzzzzx_ = context.Operators.ConvertStringToDate(pzzzzzzzzzw_);
        CqlInterval<CqlDateTime> pzzzzzzzzzy_ = this.Measurement_Period(context);
        CqlDateTime pzzzzzzzzzz_ = context.Operators.End(pzzzzzzzzzy_);
        CqlDate qzzzzzzzzza_ = context.Operators.DateFrom(pzzzzzzzzzz_);
        int? qzzzzzzzzzb_ = context.Operators.CalculateAgeAt(pzzzzzzzzzx_, qzzzzzzzzza_, "year");
        bool? qzzzzzzzzzc_ = context.Operators.GreaterOrEqual(qzzzzzzzzzb_, 66);
        CqlCode qzzzzzzzzzd_ = this.Housing_status(context);
        IEnumerable<CqlCode> qzzzzzzzzze_ = context.Operators.ToList<CqlCode>(qzzzzzzzzzd_);
        IEnumerable<Observation> qzzzzzzzzzf_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, qzzzzzzzzze_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> qzzzzzzzzzg_ = Status_1_8_000.Instance.isAssessmentPerformed(context, qzzzzzzzzzf_);
        bool? qzzzzzzzzzh_(Observation HousingStatus)
        {
            DataType qzzzzzzzzzs_ = HousingStatus?.Effective;
            object qzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzs_);
            CqlInterval<CqlDateTime> qzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, qzzzzzzzzzt_);
            CqlDateTime qzzzzzzzzzv_ = context.Operators.End(qzzzzzzzzzu_);
            CqlInterval<CqlDateTime> qzzzzzzzzzw_ = this.Measurement_Period(context);
            CqlDateTime qzzzzzzzzzx_ = context.Operators.End(qzzzzzzzzzw_);
            bool? qzzzzzzzzzy_ = context.Operators.SameOrBefore(qzzzzzzzzzv_, qzzzzzzzzzx_, "day");

            return qzzzzzzzzzy_;
        };
        IEnumerable<Observation> qzzzzzzzzzi_ = context.Operators.Where<Observation>(qzzzzzzzzzg_, qzzzzzzzzzh_);
        object qzzzzzzzzzj_(Observation @this)
        {
            DataType qzzzzzzzzzz_ = @this?.Effective;
            object rzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzz_);
            CqlInterval<CqlDateTime> rzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, rzzzzzzzzza_);
            CqlDateTime rzzzzzzzzzc_ = context.Operators.End(rzzzzzzzzzb_);

            return rzzzzzzzzzc_;
        };
        IEnumerable<Observation> qzzzzzzzzzk_ = context.Operators.SortBy<Observation>(qzzzzzzzzzi_, qzzzzzzzzzj_, System.ComponentModel.ListSortDirection.Ascending);
        Observation qzzzzzzzzzl_ = context.Operators.Last<Observation>(qzzzzzzzzzk_);
        Observation[] qzzzzzzzzzm_ = [
            qzzzzzzzzzl_,
        ];
        bool? qzzzzzzzzzn_(Observation LastHousingStatus)
        {
            DataType rzzzzzzzzzd_ = LastHousingStatus?.Value;
            object rzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzd_);
            CqlCode rzzzzzzzzzf_ = this.Lives_in_a_nursing_home__finding_(context);
            CqlConcept rzzzzzzzzzg_ = context.Operators.ConvertCodeToConcept(rzzzzzzzzzf_);
            bool? rzzzzzzzzzh_ = context.Operators.Equivalent(rzzzzzzzzze_ as CqlConcept, rzzzzzzzzzg_);

            return rzzzzzzzzzh_;
        };
        IEnumerable<Observation> qzzzzzzzzzo_ = context.Operators.Where<Observation>((IEnumerable<Observation>)qzzzzzzzzzm_, qzzzzzzzzzn_);
        Observation qzzzzzzzzzp_ = context.Operators.SingletonFrom<Observation>(qzzzzzzzzzo_);
        bool? qzzzzzzzzzq_ = context.Operators.Not((bool?)(qzzzzzzzzzp_ is null));
        bool? qzzzzzzzzzr_ = context.Operators.And(qzzzzzzzzzc_, qzzzzzzzzzq_);

        return qzzzzzzzzzr_;
    }


    #endregion Expressions

}
