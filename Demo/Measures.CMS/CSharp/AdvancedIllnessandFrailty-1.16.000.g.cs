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
    private static readonly CqlCode _Housing_status = new CqlCode("71802-3", "http://loinc.org");

    [CqlCodeDefinition("Lives in a nursing home (finding)", codeId: "160734000", codeSystem: "http://snomed.info/sct")]
    public CqlCode Lives_in_a_nursing_home__finding_(CqlContext _) => _Lives_in_a_nursing_home__finding_;
    private static readonly CqlCode _Lives_in_a_nursing_home__finding_ = new CqlCode("160734000", "http://snomed.info/sct");

    [CqlCodeDefinition("Medical equipment used", codeId: "98181-1", codeSystem: "http://loinc.org")]
    public CqlCode Medical_equipment_used(CqlContext _) => _Medical_equipment_used;
    private static readonly CqlCode _Medical_equipment_used = new CqlCode("98181-1", "http://loinc.org");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC")]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, [
          _Housing_status,
          _Medical_equipment_used]);

    [CqlCodeSystemDefinition("SNOMEDCT")]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Lives_in_a_nursing_home__finding_]);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object ozzzzzzzzzzzzzzzzv_ = context.ResolveParameter("AdvancedIllnessandFrailty-1.16.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)ozzzzzzzzzzzzzzzzv_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> ozzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient ozzzzzzzzzzzzzzzzx_ = context.Operators.SingletonFrom<Patient>(ozzzzzzzzzzzzzzzzw_);

        return ozzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Has Criteria Indicating Frailty")]
    public bool? Has_Criteria_Indicating_Frailty(CqlContext context)
    {
        CqlValueSet ozzzzzzzzzzzzzzzzy_ = this.Frailty_Device(context);
        IEnumerable<DeviceRequest> ozzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<DeviceRequest>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-devicerequest"));
        IEnumerable<DeviceRequest> pzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<DeviceRequest>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-devicerequest"));
        IEnumerable<DeviceRequest> pzzzzzzzzzzzzzzzzc_ = context.Operators.Union<DeviceRequest>(ozzzzzzzzzzzzzzzzz_, pzzzzzzzzzzzzzzzzb_);
        IEnumerable<DeviceRequest> pzzzzzzzzzzzzzzzzd_ = Status_1_8_000.Instance.isDeviceOrder(context, pzzzzzzzzzzzzzzzzc_);
        bool? pzzzzzzzzzzzzzzzze_(DeviceRequest FrailtyDeviceOrder)
        {
            bool? qzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.doNotPerform(context, FrailtyDeviceOrder);
            bool? qzzzzzzzzzzzzzzzzk_ = context.Operators.IsTrue(qzzzzzzzzzzzzzzzzj_);
            bool? qzzzzzzzzzzzzzzzzl_ = context.Operators.Not(qzzzzzzzzzzzzzzzzk_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzm_ = this.Measurement_Period(context);
            FhirDateTime qzzzzzzzzzzzzzzzzn_ = FrailtyDeviceOrder?.AuthoredOnElement;
            CqlDateTime qzzzzzzzzzzzzzzzzo_ = context.Operators.Convert<CqlDateTime>(qzzzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, qzzzzzzzzzzzzzzzzo_ as object);
            bool? qzzzzzzzzzzzzzzzzq_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(qzzzzzzzzzzzzzzzzm_, qzzzzzzzzzzzzzzzzp_, "day");
            bool? qzzzzzzzzzzzzzzzzr_ = context.Operators.And(qzzzzzzzzzzzzzzzzl_, qzzzzzzzzzzzzzzzzq_);

            return qzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<DeviceRequest> pzzzzzzzzzzzzzzzzf_ = context.Operators.Where<DeviceRequest>(pzzzzzzzzzzzzzzzzd_, pzzzzzzzzzzzzzzzze_);
        bool? pzzzzzzzzzzzzzzzzg_ = context.Operators.Exists<DeviceRequest>(pzzzzzzzzzzzzzzzzf_);
        CqlCode pzzzzzzzzzzzzzzzzh_ = this.Medical_equipment_used(context);
        IEnumerable<CqlCode> pzzzzzzzzzzzzzzzzi_ = context.Operators.ToList<CqlCode>(pzzzzzzzzzzzzzzzzh_);
        IEnumerable<Observation> pzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, pzzzzzzzzzzzzzzzzi_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> pzzzzzzzzzzzzzzzzk_ = Status_1_8_000.Instance.isAssessmentPerformed(context, pzzzzzzzzzzzzzzzzj_);
        bool? pzzzzzzzzzzzzzzzzl_(Observation EquipmentUsed)
        {
            DataType qzzzzzzzzzzzzzzzzs_ = EquipmentUsed?.Value;
            object qzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzs_);
            CqlValueSet qzzzzzzzzzzzzzzzzu_ = this.Frailty_Device(context);
            bool? qzzzzzzzzzzzzzzzzv_ = context.Operators.ConceptInValueSet(qzzzzzzzzzzzzzzzzt_ as CqlConcept, qzzzzzzzzzzzzzzzzu_);
            DataType qzzzzzzzzzzzzzzzzw_ = EquipmentUsed?.Effective;
            object qzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.toInterval(context, qzzzzzzzzzzzzzzzzx_);
            CqlDateTime qzzzzzzzzzzzzzzzzz_ = context.Operators.End(qzzzzzzzzzzzzzzzzy_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzza_ = this.Measurement_Period(context);
            bool? rzzzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDateTime>(qzzzzzzzzzzzzzzzzz_, rzzzzzzzzzzzzzzzza_, "day");
            bool? rzzzzzzzzzzzzzzzzc_ = context.Operators.And(qzzzzzzzzzzzzzzzzv_, rzzzzzzzzzzzzzzzzb_);

            return rzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Observation> pzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Observation>(pzzzzzzzzzzzzzzzzk_, pzzzzzzzzzzzzzzzzl_);
        bool? pzzzzzzzzzzzzzzzzn_ = context.Operators.Exists<Observation>(pzzzzzzzzzzzzzzzzm_);
        bool? pzzzzzzzzzzzzzzzzo_ = context.Operators.Or(pzzzzzzzzzzzzzzzzg_, pzzzzzzzzzzzzzzzzn_);
        CqlValueSet pzzzzzzzzzzzzzzzzp_ = this.Frailty_Diagnosis(context);
        IEnumerable<Condition> pzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? pzzzzzzzzzzzzzzzzr_(Condition FrailtyDiagnosis)
        {
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, FrailtyDiagnosis);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzze_ = this.Measurement_Period(context);
            bool? rzzzzzzzzzzzzzzzzf_ = context.Operators.Overlaps(rzzzzzzzzzzzzzzzzd_, rzzzzzzzzzzzzzzzze_, "day");

            return rzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Condition> pzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Condition>(pzzzzzzzzzzzzzzzzq_, pzzzzzzzzzzzzzzzzr_);
        bool? pzzzzzzzzzzzzzzzzt_ = context.Operators.Exists<Condition>(pzzzzzzzzzzzzzzzzs_);
        bool? pzzzzzzzzzzzzzzzzu_ = context.Operators.Or(pzzzzzzzzzzzzzzzzo_, pzzzzzzzzzzzzzzzzt_);
        CqlValueSet pzzzzzzzzzzzzzzzzv_ = this.Frailty_Encounter(context);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzx_ = Status_1_8_000.Instance.isEncounterPerformed(context, pzzzzzzzzzzzzzzzzw_);
        bool? pzzzzzzzzzzzzzzzzy_(Encounter FrailtyEncounter)
        {
            Period rzzzzzzzzzzzzzzzzg_ = FrailtyEncounter?.Period;
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.toInterval(context, rzzzzzzzzzzzzzzzzh_ as object);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzj_ = this.Measurement_Period(context);
            bool? rzzzzzzzzzzzzzzzzk_ = context.Operators.Overlaps(rzzzzzzzzzzzzzzzzi_, rzzzzzzzzzzzzzzzzj_, "day");

            return rzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Encounter>(pzzzzzzzzzzzzzzzzx_, pzzzzzzzzzzzzzzzzy_);
        bool? qzzzzzzzzzzzzzzzza_ = context.Operators.Exists<Encounter>(pzzzzzzzzzzzzzzzzz_);
        bool? qzzzzzzzzzzzzzzzzb_ = context.Operators.Or(pzzzzzzzzzzzzzzzzu_, qzzzzzzzzzzzzzzzza_);
        CqlValueSet qzzzzzzzzzzzzzzzzc_ = this.Frailty_Symptom(context);
        IEnumerable<Observation> qzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> qzzzzzzzzzzzzzzzze_ = Status_1_8_000.Instance.isSymptom(context, qzzzzzzzzzzzzzzzzd_);
        bool? qzzzzzzzzzzzzzzzzf_(Observation FrailtySymptom)
        {
            DataType rzzzzzzzzzzzzzzzzl_ = FrailtySymptom?.Effective;
            object rzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.toInterval(context, rzzzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzo_ = this.Measurement_Period(context);
            bool? rzzzzzzzzzzzzzzzzp_ = context.Operators.Overlaps(rzzzzzzzzzzzzzzzzn_, rzzzzzzzzzzzzzzzzo_, "day");

            return rzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Observation> qzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Observation>(qzzzzzzzzzzzzzzzze_, qzzzzzzzzzzzzzzzzf_);
        bool? qzzzzzzzzzzzzzzzzh_ = context.Operators.Exists<Observation>(qzzzzzzzzzzzzzzzzg_);
        bool? qzzzzzzzzzzzzzzzzi_ = context.Operators.Or(qzzzzzzzzzzzzzzzzb_, qzzzzzzzzzzzzzzzzh_);

        return qzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Has Advanced Illness in Year Before or During Measurement Period")]
    public bool? Has_Advanced_Illness_in_Year_Before_or_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet rzzzzzzzzzzzzzzzzq_ = this.Advanced_Illness(context);
        IEnumerable<Condition> rzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, rzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? rzzzzzzzzzzzzzzzzs_(Condition AdvancedIllnessDiagnosis)
        {
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, AdvancedIllnessDiagnosis);
            CqlDateTime rzzzzzzzzzzzzzzzzw_ = context.Operators.Start(rzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzx_ = this.Measurement_Period(context);
            CqlDateTime rzzzzzzzzzzzzzzzzy_ = context.Operators.Start(rzzzzzzzzzzzzzzzzx_);
            CqlQuantity rzzzzzzzzzzzzzzzzz_ = context.Operators.Quantity(1m, "year");
            CqlDateTime szzzzzzzzzzzzzzzza_ = context.Operators.Subtract(rzzzzzzzzzzzzzzzzy_, rzzzzzzzzzzzzzzzzz_);
            CqlDateTime szzzzzzzzzzzzzzzzc_ = context.Operators.End(rzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzd_ = context.Operators.Interval(szzzzzzzzzzzzzzzza_, szzzzzzzzzzzzzzzzc_, true, true);
            bool? szzzzzzzzzzzzzzzze_ = context.Operators.In<CqlDateTime>(rzzzzzzzzzzzzzzzzw_, szzzzzzzzzzzzzzzzd_, "day");

            return szzzzzzzzzzzzzzzze_;
        };
        IEnumerable<Condition> rzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Condition>(rzzzzzzzzzzzzzzzzr_, rzzzzzzzzzzzzzzzzs_);
        bool? rzzzzzzzzzzzzzzzzu_ = context.Operators.Exists<Condition>(rzzzzzzzzzzzzzzzzt_);

        return rzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Has Dementia Medications in Year Before or During Measurement Period")]
    public bool? Has_Dementia_Medications_in_Year_Before_or_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet szzzzzzzzzzzzzzzzf_ = this.Dementia_Medications(context);
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzzzzh_ = Status_1_8_000.Instance.isMedicationActive(context, szzzzzzzzzzzzzzzzg_);
        bool? szzzzzzzzzzzzzzzzi_(MedicationRequest DementiaMedication)
        {
            CqlInterval<CqlDate> szzzzzzzzzzzzzzzzl_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, DementiaMedication);
            CqlDate szzzzzzzzzzzzzzzzm_ = szzzzzzzzzzzzzzzzl_?.low;
            CqlDateTime szzzzzzzzzzzzzzzzn_ = context.Operators.ConvertDateToDateTime(szzzzzzzzzzzzzzzzm_);
            CqlDate szzzzzzzzzzzzzzzzp_ = szzzzzzzzzzzzzzzzl_?.high;
            CqlDateTime szzzzzzzzzzzzzzzzq_ = context.Operators.ConvertDateToDateTime(szzzzzzzzzzzzzzzzp_);
            bool? szzzzzzzzzzzzzzzzs_ = szzzzzzzzzzzzzzzzl_?.lowClosed;
            bool? szzzzzzzzzzzzzzzzu_ = szzzzzzzzzzzzzzzzl_?.highClosed;
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzv_ = context.Operators.Interval(szzzzzzzzzzzzzzzzn_, szzzzzzzzzzzzzzzzq_, szzzzzzzzzzzzzzzzs_, szzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzw_ = this.Measurement_Period(context);
            CqlDateTime szzzzzzzzzzzzzzzzx_ = context.Operators.Start(szzzzzzzzzzzzzzzzw_);
            CqlQuantity szzzzzzzzzzzzzzzzy_ = context.Operators.Quantity(1m, "year");
            CqlDateTime szzzzzzzzzzzzzzzzz_ = context.Operators.Subtract(szzzzzzzzzzzzzzzzx_, szzzzzzzzzzzzzzzzy_);
            CqlDateTime tzzzzzzzzzzzzzzzzb_ = context.Operators.End(szzzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzc_ = context.Operators.Interval(szzzzzzzzzzzzzzzzz_, tzzzzzzzzzzzzzzzzb_, true, true);
            bool? tzzzzzzzzzzzzzzzzd_ = context.Operators.Overlaps(szzzzzzzzzzzzzzzzv_, tzzzzzzzzzzzzzzzzc_, "day");

            return tzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<MedicationRequest> szzzzzzzzzzzzzzzzj_ = context.Operators.Where<MedicationRequest>(szzzzzzzzzzzzzzzzh_, szzzzzzzzzzzzzzzzi_);
        bool? szzzzzzzzzzzzzzzzk_ = context.Operators.Exists<MedicationRequest>(szzzzzzzzzzzzzzzzj_);

        return szzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Is Age 66 or Older with Advanced Illness and Frailty")]
    public bool? Is_Age_66_or_Older_with_Advanced_Illness_and_Frailty(CqlContext context)
    {
        Patient tzzzzzzzzzzzzzzzze_ = this.Patient(context);
        Date tzzzzzzzzzzzzzzzzf_ = tzzzzzzzzzzzzzzzze_?.BirthDateElement;
        string tzzzzzzzzzzzzzzzzg_ = tzzzzzzzzzzzzzzzzf_?.Value;
        CqlDate tzzzzzzzzzzzzzzzzh_ = context.Operators.ConvertStringToDate(tzzzzzzzzzzzzzzzzg_);
        CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzi_ = this.Measurement_Period(context);
        CqlDateTime tzzzzzzzzzzzzzzzzj_ = context.Operators.End(tzzzzzzzzzzzzzzzzi_);
        CqlDate tzzzzzzzzzzzzzzzzk_ = context.Operators.DateFrom(tzzzzzzzzzzzzzzzzj_);
        int? tzzzzzzzzzzzzzzzzl_ = context.Operators.CalculateAgeAt(tzzzzzzzzzzzzzzzzh_, tzzzzzzzzzzzzzzzzk_, "year");
        bool? tzzzzzzzzzzzzzzzzm_ = context.Operators.GreaterOrEqual(tzzzzzzzzzzzzzzzzl_, 66);
        bool? tzzzzzzzzzzzzzzzzn_ = this.Has_Criteria_Indicating_Frailty(context);
        bool? tzzzzzzzzzzzzzzzzo_ = context.Operators.And(tzzzzzzzzzzzzzzzzm_, tzzzzzzzzzzzzzzzzn_);
        bool? tzzzzzzzzzzzzzzzzp_ = this.Has_Advanced_Illness_in_Year_Before_or_During_Measurement_Period(context);
        bool? tzzzzzzzzzzzzzzzzq_ = this.Has_Dementia_Medications_in_Year_Before_or_During_Measurement_Period(context);
        bool? tzzzzzzzzzzzzzzzzr_ = context.Operators.Or(tzzzzzzzzzzzzzzzzp_, tzzzzzzzzzzzzzzzzq_);
        bool? tzzzzzzzzzzzzzzzzs_ = context.Operators.And(tzzzzzzzzzzzzzzzzo_, tzzzzzzzzzzzzzzzzr_);

        return tzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Is Age 66 to 80 with Advanced Illness and Frailty or Is Age 81 or Older with Frailty")]
    public bool? Is_Age_66_to_80_with_Advanced_Illness_and_Frailty_or_Is_Age_81_or_Older_with_Frailty(CqlContext context)
    {
        Patient tzzzzzzzzzzzzzzzzt_ = this.Patient(context);
        Date tzzzzzzzzzzzzzzzzu_ = tzzzzzzzzzzzzzzzzt_?.BirthDateElement;
        string tzzzzzzzzzzzzzzzzv_ = tzzzzzzzzzzzzzzzzu_?.Value;
        CqlDate tzzzzzzzzzzzzzzzzw_ = context.Operators.ConvertStringToDate(tzzzzzzzzzzzzzzzzv_);
        CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzx_ = this.Measurement_Period(context);
        CqlDateTime tzzzzzzzzzzzzzzzzy_ = context.Operators.End(tzzzzzzzzzzzzzzzzx_);
        CqlDate tzzzzzzzzzzzzzzzzz_ = context.Operators.DateFrom(tzzzzzzzzzzzzzzzzy_);
        int? uzzzzzzzzzzzzzzzza_ = context.Operators.CalculateAgeAt(tzzzzzzzzzzzzzzzzw_, tzzzzzzzzzzzzzzzzz_, "year");
        CqlInterval<int?> uzzzzzzzzzzzzzzzzb_ = context.Operators.Interval(66, 80, true, true);
        bool? uzzzzzzzzzzzzzzzzc_ = context.Operators.In<int?>(uzzzzzzzzzzzzzzzza_, uzzzzzzzzzzzzzzzzb_, default);
        bool? uzzzzzzzzzzzzzzzzd_ = this.Has_Criteria_Indicating_Frailty(context);
        bool? uzzzzzzzzzzzzzzzze_ = context.Operators.And(uzzzzzzzzzzzzzzzzc_, uzzzzzzzzzzzzzzzzd_);
        bool? uzzzzzzzzzzzzzzzzf_ = this.Has_Advanced_Illness_in_Year_Before_or_During_Measurement_Period(context);
        bool? uzzzzzzzzzzzzzzzzg_ = this.Has_Dementia_Medications_in_Year_Before_or_During_Measurement_Period(context);
        bool? uzzzzzzzzzzzzzzzzh_ = context.Operators.Or(uzzzzzzzzzzzzzzzzf_, uzzzzzzzzzzzzzzzzg_);
        bool? uzzzzzzzzzzzzzzzzi_ = context.Operators.And(uzzzzzzzzzzzzzzzze_, uzzzzzzzzzzzzzzzzh_);
        Date uzzzzzzzzzzzzzzzzk_ = tzzzzzzzzzzzzzzzzt_?.BirthDateElement;
        string uzzzzzzzzzzzzzzzzl_ = uzzzzzzzzzzzzzzzzk_?.Value;
        CqlDate uzzzzzzzzzzzzzzzzm_ = context.Operators.ConvertStringToDate(uzzzzzzzzzzzzzzzzl_);
        CqlDateTime uzzzzzzzzzzzzzzzzo_ = context.Operators.End(tzzzzzzzzzzzzzzzzx_);
        CqlDate uzzzzzzzzzzzzzzzzp_ = context.Operators.DateFrom(uzzzzzzzzzzzzzzzzo_);
        int? uzzzzzzzzzzzzzzzzq_ = context.Operators.CalculateAgeAt(uzzzzzzzzzzzzzzzzm_, uzzzzzzzzzzzzzzzzp_, "year");
        bool? uzzzzzzzzzzzzzzzzr_ = context.Operators.GreaterOrEqual(uzzzzzzzzzzzzzzzzq_, 81);
        bool? uzzzzzzzzzzzzzzzzt_ = context.Operators.And(uzzzzzzzzzzzzzzzzr_, uzzzzzzzzzzzzzzzzd_);
        bool? uzzzzzzzzzzzzzzzzu_ = context.Operators.Or(uzzzzzzzzzzzzzzzzi_, uzzzzzzzzzzzzzzzzt_);

        return uzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Is Age 66 or Older Living Long Term in a Nursing Home")]
    public bool? Is_Age_66_or_Older_Living_Long_Term_in_a_Nursing_Home(CqlContext context)
    {
        Patient uzzzzzzzzzzzzzzzzv_ = this.Patient(context);
        Date uzzzzzzzzzzzzzzzzw_ = uzzzzzzzzzzzzzzzzv_?.BirthDateElement;
        string uzzzzzzzzzzzzzzzzx_ = uzzzzzzzzzzzzzzzzw_?.Value;
        CqlDate uzzzzzzzzzzzzzzzzy_ = context.Operators.ConvertStringToDate(uzzzzzzzzzzzzzzzzx_);
        CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzz_ = this.Measurement_Period(context);
        CqlDateTime vzzzzzzzzzzzzzzzza_ = context.Operators.End(uzzzzzzzzzzzzzzzzz_);
        CqlDate vzzzzzzzzzzzzzzzzb_ = context.Operators.DateFrom(vzzzzzzzzzzzzzzzza_);
        int? vzzzzzzzzzzzzzzzzc_ = context.Operators.CalculateAgeAt(uzzzzzzzzzzzzzzzzy_, vzzzzzzzzzzzzzzzzb_, "year");
        bool? vzzzzzzzzzzzzzzzzd_ = context.Operators.GreaterOrEqual(vzzzzzzzzzzzzzzzzc_, 66);
        CqlCode vzzzzzzzzzzzzzzzze_ = this.Housing_status(context);
        IEnumerable<CqlCode> vzzzzzzzzzzzzzzzzf_ = context.Operators.ToList<CqlCode>(vzzzzzzzzzzzzzzzze_);
        IEnumerable<Observation> vzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, vzzzzzzzzzzzzzzzzf_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> vzzzzzzzzzzzzzzzzh_ = Status_1_8_000.Instance.isAssessmentPerformed(context, vzzzzzzzzzzzzzzzzg_);
        bool? vzzzzzzzzzzzzzzzzi_(Observation HousingStatus)
        {
            DataType vzzzzzzzzzzzzzzzzt_ = HousingStatus?.Effective;
            object vzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, vzzzzzzzzzzzzzzzzu_);
            CqlDateTime vzzzzzzzzzzzzzzzzw_ = context.Operators.End(vzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzx_ = this.Measurement_Period(context);
            CqlDateTime vzzzzzzzzzzzzzzzzy_ = context.Operators.End(vzzzzzzzzzzzzzzzzx_);
            bool? vzzzzzzzzzzzzzzzzz_ = context.Operators.SameOrBefore(vzzzzzzzzzzzzzzzzw_, vzzzzzzzzzzzzzzzzy_, "day");

            return vzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Observation> vzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Observation>(vzzzzzzzzzzzzzzzzh_, vzzzzzzzzzzzzzzzzi_);
        object vzzzzzzzzzzzzzzzzk_(Observation @this)
        {
            DataType wzzzzzzzzzzzzzzzza_ = @this?.Effective;
            object wzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, wzzzzzzzzzzzzzzzzb_);
            CqlDateTime wzzzzzzzzzzzzzzzzd_ = context.Operators.End(wzzzzzzzzzzzzzzzzc_);

            return wzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Observation> vzzzzzzzzzzzzzzzzl_ = context.Operators.SortBy<Observation>(vzzzzzzzzzzzzzzzzj_, vzzzzzzzzzzzzzzzzk_, System.ComponentModel.ListSortDirection.Ascending);
        Observation vzzzzzzzzzzzzzzzzm_ = context.Operators.Last<Observation>(vzzzzzzzzzzzzzzzzl_);
        Observation[] vzzzzzzzzzzzzzzzzn_ = [
            vzzzzzzzzzzzzzzzzm_,
        ];
        bool? vzzzzzzzzzzzzzzzzo_(Observation LastHousingStatus)
        {
            DataType wzzzzzzzzzzzzzzzze_ = LastHousingStatus?.Value;
            object wzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzze_);
            CqlCode wzzzzzzzzzzzzzzzzg_ = this.Lives_in_a_nursing_home__finding_(context);
            CqlConcept wzzzzzzzzzzzzzzzzh_ = context.Operators.ConvertCodeToConcept(wzzzzzzzzzzzzzzzzg_);
            bool? wzzzzzzzzzzzzzzzzi_ = context.Operators.Equivalent(wzzzzzzzzzzzzzzzzf_ as CqlConcept, wzzzzzzzzzzzzzzzzh_);

            return wzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Observation> vzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Observation>((IEnumerable<Observation>)vzzzzzzzzzzzzzzzzn_, vzzzzzzzzzzzzzzzzo_);
        Observation vzzzzzzzzzzzzzzzzq_ = context.Operators.SingletonFrom<Observation>(vzzzzzzzzzzzzzzzzp_);
        bool? vzzzzzzzzzzzzzzzzr_ = context.Operators.Not((bool?)(vzzzzzzzzzzzzzzzzq_ is null));
        bool? vzzzzzzzzzzzzzzzzs_ = context.Operators.And(vzzzzzzzzzzzzzzzzd_, vzzzzzzzzzzzzzzzzr_);

        return vzzzzzzzzzzzzzzzzs_;
    }


    #endregion Expressions

}
