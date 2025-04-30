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

    [CqlValueSetDefinition("Advanced Illness", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1082", valueSetVersion: null)]
    public CqlValueSet Advanced_Illness(CqlContext _) => _Advanced_Illness;
    private static readonly CqlValueSet _Advanced_Illness = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1082", null);

    [CqlValueSetDefinition("Dementia Medications", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1510", valueSetVersion: null)]
    public CqlValueSet Dementia_Medications(CqlContext _) => _Dementia_Medications;
    private static readonly CqlValueSet _Dementia_Medications = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1510", null);

    [CqlValueSetDefinition("Frailty Device", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.118.12.1300", valueSetVersion: null)]
    public CqlValueSet Frailty_Device(CqlContext _) => _Frailty_Device;
    private static readonly CqlValueSet _Frailty_Device = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.118.12.1300", null);

    [CqlValueSetDefinition("Frailty Diagnosis", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1074", valueSetVersion: null)]
    public CqlValueSet Frailty_Diagnosis(CqlContext _) => _Frailty_Diagnosis;
    private static readonly CqlValueSet _Frailty_Diagnosis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1074", null);

    [CqlValueSetDefinition("Frailty Encounter", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1088", valueSetVersion: null)]
    public CqlValueSet Frailty_Encounter(CqlContext _) => _Frailty_Encounter;
    private static readonly CqlValueSet _Frailty_Encounter = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1088", null);

    [CqlValueSetDefinition("Frailty Symptom", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1075", valueSetVersion: null)]
    public CqlValueSet Frailty_Symptom(CqlContext _) => _Frailty_Symptom;
    private static readonly CqlValueSet _Frailty_Symptom = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1075", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Housing status", codeId: "71802-3", codeSystem: "http://loinc.org")]
    public CqlCode Housing_status(CqlContext _) => _Housing_status;
    private static readonly CqlCode _Housing_status = new CqlCode("71802-3", "http://loinc.org", default, default);

    [CqlCodeDefinition("Lives in a nursing home (finding)", codeId: "160734000", codeSystem: "http://snomed.info/sct")]
    public CqlCode Lives_in_a_nursing_home__finding_(CqlContext _) => _Lives_in_a_nursing_home__finding_;
    private static readonly CqlCode _Lives_in_a_nursing_home__finding_ = new CqlCode("160734000", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("Medical equipment used", codeId: "98181-1", codeSystem: "http://loinc.org")]
    public CqlCode Medical_equipment_used(CqlContext _) => _Medical_equipment_used;
    private static readonly CqlCode _Medical_equipment_used = new CqlCode("98181-1", "http://loinc.org", default, default);

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC")]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC = new CqlCodeSystem();

    [CqlCodeSystemDefinition("SNOMEDCT")]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT = new CqlCodeSystem();

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object uzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.ResolveParameter("AdvancedIllnessandFrailty-1.16.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)uzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> uzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient uzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.SingletonFrom<Patient>(uzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

        return uzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Has Criteria Indicating Frailty")]
    public bool? Has_Criteria_Indicating_Frailty(CqlContext context)
    {
        CqlValueSet uzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Frailty_Device(context);
        IEnumerable<DeviceRequest> uzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<DeviceRequest>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-devicerequest"));
        IEnumerable<DeviceRequest> uzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<DeviceRequest>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-devicerequest"));
        IEnumerable<DeviceRequest> uzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<DeviceRequest>(uzzzzzzzzzzzzzzzzzzzzzzzzzzs_, uzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        IEnumerable<DeviceRequest> uzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = Status_1_8_000.Instance.isDeviceOrder(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzx_(DeviceRequest FrailtyDeviceOrder)
        {
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.doNotPerform(context, FrailtyDeviceOrder);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.IsTrue(wzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Not(wzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Measurement_Period(context);
            FhirDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FrailtyDeviceOrder?.AuthoredOnElement;
            CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Convert<CqlDateTime>(wzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.toInterval(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzh_ as object);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(wzzzzzzzzzzzzzzzzzzzzzzzzzzf_, wzzzzzzzzzzzzzzzzzzzzzzzzzzi_, "day");
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzzzzzze_, wzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

            return wzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<DeviceRequest> uzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<DeviceRequest>(uzzzzzzzzzzzzzzzzzzzzzzzzzzw_, uzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Exists<DeviceRequest>(uzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        CqlCode vzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Medical_equipment_used(context);
        IEnumerable<CqlCode> vzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.ToList<CqlCode>(vzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, vzzzzzzzzzzzzzzzzzzzzzzzzzzb_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = Status_1_8_000.Instance.isAssessmentPerformed(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzzze_(Observation EquipmentUsed)
        {
            DataType wzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = EquipmentUsed?.Value;
            object wzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlValueSet wzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Frailty_Device(context);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.ConceptInValueSet(wzzzzzzzzzzzzzzzzzzzzzzzzzzm_ as CqlConcept, wzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            DataType wzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = EquipmentUsed?.Effective;
            object wzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.End(wzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Measurement_Period(context);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(wzzzzzzzzzzzzzzzzzzzzzzzzzzs_, wzzzzzzzzzzzzzzzzzzzzzzzzzzt_, "day");
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzzzzzzo_, wzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

            return wzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Observation>(vzzzzzzzzzzzzzzzzzzzzzzzzzzd_, vzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Exists<Observation>(vzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Or(uzzzzzzzzzzzzzzzzzzzzzzzzzzz_, vzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Frailty_Diagnosis(context);
        IEnumerable<Condition> vzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Condition FrailtyDiagnosis)
        {
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, FrailtyDiagnosis);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Measurement_Period(context);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Overlaps(wzzzzzzzzzzzzzzzzzzzzzzzzzzw_, wzzzzzzzzzzzzzzzzzzzzzzzzzzx_, "day");

            return wzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Condition> vzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Condition>(vzzzzzzzzzzzzzzzzzzzzzzzzzzj_, vzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Exists<Condition>(vzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Or(vzzzzzzzzzzzzzzzzzzzzzzzzzzh_, vzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Frailty_Encounter(context);
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = Status_1_8_000.Instance.isEncounterPerformed(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzr_(Encounter FrailtyEncounter)
        {
            Period wzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FrailtyEncounter?.Period;
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzzzzzzzzzzzzzzzzzza_ as object);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Measurement_Period(context);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Overlaps(xzzzzzzzzzzzzzzzzzzzzzzzzzzb_, xzzzzzzzzzzzzzzzzzzzzzzzzzzc_, "day");

            return xzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Encounter> vzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Encounter>(vzzzzzzzzzzzzzzzzzzzzzzzzzzq_, vzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Exists<Encounter>(vzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Or(vzzzzzzzzzzzzzzzzzzzzzzzzzzn_, vzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        CqlValueSet vzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Frailty_Symptom(context);
        IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, vzzzzzzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = Status_1_8_000.Instance.isSymptom(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzy_(Observation FrailtySymptom)
        {
            DataType xzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FrailtySymptom?.Effective;
            object xzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Measurement_Period(context);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Overlaps(xzzzzzzzzzzzzzzzzzzzzzzzzzzg_, xzzzzzzzzzzzzzzzzzzzzzzzzzzh_, "day");

            return xzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Observation>(vzzzzzzzzzzzzzzzzzzzzzzzzzzx_, vzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Exists<Observation>(vzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Or(vzzzzzzzzzzzzzzzzzzzzzzzzzzu_, wzzzzzzzzzzzzzzzzzzzzzzzzzza_);

        return wzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Has Advanced Illness in Year Before or During Measurement Period")]
    public bool? Has_Advanced_Illness_in_Year_Before_or_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet xzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Advanced_Illness(context);
        IEnumerable<Condition> xzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzl_(Condition AdvancedIllnessDiagnosis)
        {
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, AdvancedIllnessDiagnosis);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Measurement_Period(context);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlQuantity xzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Quantity(1m, "year");
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Subtract(xzzzzzzzzzzzzzzzzzzzzzzzzzzr_, xzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.End(xzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Interval(xzzzzzzzzzzzzzzzzzzzzzzzzzzt_, xzzzzzzzzzzzzzzzzzzzzzzzzzzv_, true, true);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzzzzzzzzzzzzzzzzzzp_, xzzzzzzzzzzzzzzzzzzzzzzzzzzw_, "day");

            return xzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Condition> xzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Condition>(xzzzzzzzzzzzzzzzzzzzzzzzzzzk_, xzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Exists<Condition>(xzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

        return xzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Has Dementia Medications in Year Before or During Measurement Period")]
    public bool? Has_Dementia_Medications_in_Year_Before_or_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet xzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Dementia_Medications(context);
        IEnumerable<MedicationRequest> xzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> yzzzzzzzzzzzzzzzzzzzzzzzzzza_ = Status_1_8_000.Instance.isMedicationActive(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzb_(MedicationRequest DementiaMedication)
        {
            CqlInterval<CqlDate> yzzzzzzzzzzzzzzzzzzzzzzzzzze_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, DementiaMedication);
            CqlDate yzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = yzzzzzzzzzzzzzzzzzzzzzzzzzze_?.low;
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.ConvertDateToDateTime(yzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlDate yzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = yzzzzzzzzzzzzzzzzzzzzzzzzzze_?.high;
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.ConvertDateToDateTime(yzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = yzzzzzzzzzzzzzzzzzzzzzzzzzze_?.lowClosed;
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = yzzzzzzzzzzzzzzzzzzzzzzzzzze_?.highClosed;
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Interval(yzzzzzzzzzzzzzzzzzzzzzzzzzzg_, yzzzzzzzzzzzzzzzzzzzzzzzzzzj_, yzzzzzzzzzzzzzzzzzzzzzzzzzzl_, yzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Measurement_Period(context);
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlQuantity yzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Quantity(1m, "year");
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Subtract(yzzzzzzzzzzzzzzzzzzzzzzzzzzq_, yzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.End(yzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Interval(yzzzzzzzzzzzzzzzzzzzzzzzzzzs_, yzzzzzzzzzzzzzzzzzzzzzzzzzzu_, true, true);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Overlaps(yzzzzzzzzzzzzzzzzzzzzzzzzzzo_, yzzzzzzzzzzzzzzzzzzzzzzzzzzv_, "day");

            return yzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<MedicationRequest> yzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<MedicationRequest>(yzzzzzzzzzzzzzzzzzzzzzzzzzza_, yzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Exists<MedicationRequest>(yzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

        return yzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Is Age 66 or Older with Advanced Illness and Frailty")]
    public bool? Is_Age_66_or_Older_with_Advanced_Illness_and_Frailty(CqlContext context)
    {
        Patient yzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Patient(context);
        Date yzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = yzzzzzzzzzzzzzzzzzzzzzzzzzzx_?.BirthDateElement;
        string yzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = yzzzzzzzzzzzzzzzzzzzzzzzzzzy_?.Value;
        CqlDate zzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.ConvertStringToDate(yzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Measurement_Period(context);
        CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.End(zzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        CqlDate zzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.DateFrom(zzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        int? zzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.CalculateAgeAt(zzzzzzzzzzzzzzzzzzzzzzzzzzza_, zzzzzzzzzzzzzzzzzzzzzzzzzzzd_, "year");
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.GreaterOrEqual(zzzzzzzzzzzzzzzzzzzzzzzzzzze_, 66);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Has_Criteria_Indicating_Frailty(context);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzzzzzzf_, zzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Has_Advanced_Illness_in_Year_Before_or_During_Measurement_Period(context);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Has_Dementia_Medications_in_Year_Before_or_During_Measurement_Period(context);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Or(zzzzzzzzzzzzzzzzzzzzzzzzzzzi_, zzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzzzzzzh_, zzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Is Age 66 to 80 with Advanced Illness and Frailty or Is Age 81 or Older with Frailty")]
    public bool? Is_Age_66_to_80_with_Advanced_Illness_and_Frailty_or_Is_Age_81_or_Older_with_Frailty(CqlContext context)
    {
        Patient zzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Patient(context);
        Date zzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = zzzzzzzzzzzzzzzzzzzzzzzzzzzm_?.BirthDateElement;
        string zzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = zzzzzzzzzzzzzzzzzzzzzzzzzzzn_?.Value;
        CqlDate zzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.ConvertStringToDate(zzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Measurement_Period(context);
        CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.End(zzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        CqlDate zzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.DateFrom(zzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        int? zzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.CalculateAgeAt(zzzzzzzzzzzzzzzzzzzzzzzzzzzp_, zzzzzzzzzzzzzzzzzzzzzzzzzzzs_, "year");
        CqlInterval<int?> zzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Interval(66, 80, true, true);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.In<int?>(zzzzzzzzzzzzzzzzzzzzzzzzzzzt_, zzzzzzzzzzzzzzzzzzzzzzzzzzzu_, default);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Has_Criteria_Indicating_Frailty(context);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzzzzzzv_, zzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Has_Advanced_Illness_in_Year_Before_or_During_Measurement_Period(context);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Has_Dementia_Medications_in_Year_Before_or_During_Measurement_Period(context);
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Or(zzzzzzzzzzzzzzzzzzzzzzzzzzzy_, zzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzzzzzzx_, azzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        Date azzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = zzzzzzzzzzzzzzzzzzzzzzzzzzzm_?.BirthDateElement;
        string azzzzzzzzzzzzzzzzzzzzzzzzzzze_ = azzzzzzzzzzzzzzzzzzzzzzzzzzzd_?.Value;
        CqlDate azzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.ConvertStringToDate(azzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.End(zzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        CqlDate azzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.DateFrom(azzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        int? azzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.CalculateAgeAt(azzzzzzzzzzzzzzzzzzzzzzzzzzzf_, azzzzzzzzzzzzzzzzzzzzzzzzzzzi_, "year");
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.GreaterOrEqual(azzzzzzzzzzzzzzzzzzzzzzzzzzzj_, 81);
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzzzzzzzzzk_, zzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Or(azzzzzzzzzzzzzzzzzzzzzzzzzzzb_, azzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Is Age 66 or Older Living Long Term in a Nursing Home")]
    public bool? Is_Age_66_or_Older_Living_Long_Term_in_a_Nursing_Home(CqlContext context)
    {
        Patient azzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Patient(context);
        Date azzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = azzzzzzzzzzzzzzzzzzzzzzzzzzzo_?.BirthDateElement;
        string azzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = azzzzzzzzzzzzzzzzzzzzzzzzzzzp_?.Value;
        CqlDate azzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ConvertStringToDate(azzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Measurement_Period(context);
        CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.End(azzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        CqlDate azzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.DateFrom(azzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        int? azzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.CalculateAgeAt(azzzzzzzzzzzzzzzzzzzzzzzzzzzr_, azzzzzzzzzzzzzzzzzzzzzzzzzzzu_, "year");
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.GreaterOrEqual(azzzzzzzzzzzzzzzzzzzzzzzzzzzv_, 66);
        CqlCode azzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Housing_status(context);
        IEnumerable<CqlCode> azzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.ToList<CqlCode>(azzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, azzzzzzzzzzzzzzzzzzzzzzzzzzzy_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = Status_1_8_000.Instance.isAssessmentPerformed(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzb_(Observation HousingStatus)
        {
            DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = HousingStatus?.Effective;
            object bzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.End(bzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Measurement_Period(context);
            CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.End(bzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.SameOrBefore(bzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, "day");

            return bzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Observation>(bzzzzzzzzzzzzzzzzzzzzzzzzzzza_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        object bzzzzzzzzzzzzzzzzzzzzzzzzzzzd_(Observation @this)
        {
            DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = @this?.Effective;
            object bzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.End(bzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

            return bzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.SortBy<Observation>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, System.ComponentModel.ListSortDirection.Ascending);
        Observation bzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Last<Observation>(bzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        Observation[] bzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = [
            bzzzzzzzzzzzzzzzzzzzzzzzzzzzf_,
        ];
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(Observation LastHousingStatus)
        {
            DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = LastHousingStatus?.Value;
            object bzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlCode bzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Lives_in_a_nursing_home__finding_(context);
            CqlConcept czzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.ConvertCodeToConcept(bzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Equivalent(bzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ as CqlConcept, czzzzzzzzzzzzzzzzzzzzzzzzzzza_);

            return czzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Observation>((IEnumerable<Observation>)bzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        Observation bzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.SingletonFrom<Observation>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Not((bool?)(bzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ is null));
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzzzzzzzzzw_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return bzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    #endregion Expressions

}
