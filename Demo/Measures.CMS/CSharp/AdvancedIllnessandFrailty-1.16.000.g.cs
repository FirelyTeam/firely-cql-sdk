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
        object ozzzzzq_ = context.ResolveParameter("AdvancedIllnessandFrailty-1.16.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)ozzzzzq_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> ozzzzzr_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient ozzzzzs_ = context.Operators.SingletonFrom<Patient>(ozzzzzr_);

        return ozzzzzs_;
    }


    [CqlExpressionDefinition("Has Criteria Indicating Frailty")]
    public bool? Has_Criteria_Indicating_Frailty(CqlContext context)
    {
        CqlValueSet ozzzzzt_ = this.Frailty_Device(context);
        IEnumerable<DeviceRequest> ozzzzzu_ = context.Operators.Retrieve<DeviceRequest>(new RetrieveParameters(default, ozzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-devicerequest"));
        IEnumerable<DeviceRequest> ozzzzzw_ = context.Operators.Retrieve<DeviceRequest>(new RetrieveParameters(default, ozzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-devicerequest"));
        IEnumerable<DeviceRequest> ozzzzzx_ = context.Operators.Union<DeviceRequest>(ozzzzzu_, ozzzzzw_);
        IEnumerable<DeviceRequest> ozzzzzy_ = Status_1_8_000.Instance.isDeviceOrder(context, ozzzzzx_);
        bool? ozzzzzz_(DeviceRequest FrailtyDeviceOrder)
        {
            bool? qzzzzze_ = QICoreCommon_2_1_000.Instance.doNotPerform(context, FrailtyDeviceOrder);
            bool? qzzzzzf_ = context.Operators.IsTrue(qzzzzze_);
            bool? qzzzzzg_ = context.Operators.Not(qzzzzzf_);
            CqlInterval<CqlDateTime> qzzzzzh_ = this.Measurement_Period(context);
            FhirDateTime qzzzzzi_ = FrailtyDeviceOrder?.AuthoredOnElement;
            CqlDateTime qzzzzzj_ = context.Operators.Convert<CqlDateTime>(qzzzzzi_);
            CqlInterval<CqlDateTime> qzzzzzk_ = QICoreCommon_2_1_000.Instance.toInterval(context, qzzzzzj_ as object);
            bool? qzzzzzl_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(qzzzzzh_, qzzzzzk_, "day");
            bool? qzzzzzm_ = context.Operators.And(qzzzzzg_, qzzzzzl_);

            return qzzzzzm_;
        };
        IEnumerable<DeviceRequest> pzzzzza_ = context.Operators.Where<DeviceRequest>(ozzzzzy_, ozzzzzz_);
        bool? pzzzzzb_ = context.Operators.Exists<DeviceRequest>(pzzzzza_);
        CqlCode pzzzzzc_ = this.Medical_equipment_used(context);
        IEnumerable<CqlCode> pzzzzzd_ = context.Operators.ToList<CqlCode>(pzzzzzc_);
        IEnumerable<Observation> pzzzzze_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, pzzzzzd_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> pzzzzzf_ = Status_1_8_000.Instance.isAssessmentPerformed(context, pzzzzze_);
        bool? pzzzzzg_(Observation EquipmentUsed)
        {
            DataType qzzzzzn_ = EquipmentUsed?.Value;
            object qzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzn_);
            CqlValueSet qzzzzzp_ = this.Frailty_Device(context);
            bool? qzzzzzq_ = context.Operators.ConceptInValueSet(qzzzzzo_ as CqlConcept, qzzzzzp_);
            DataType qzzzzzr_ = EquipmentUsed?.Effective;
            object qzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzr_);
            CqlInterval<CqlDateTime> qzzzzzt_ = QICoreCommon_2_1_000.Instance.toInterval(context, qzzzzzs_);
            CqlDateTime qzzzzzu_ = context.Operators.End(qzzzzzt_);
            CqlInterval<CqlDateTime> qzzzzzv_ = this.Measurement_Period(context);
            bool? qzzzzzw_ = context.Operators.In<CqlDateTime>(qzzzzzu_, qzzzzzv_, "day");
            bool? qzzzzzx_ = context.Operators.And(qzzzzzq_, qzzzzzw_);

            return qzzzzzx_;
        };
        IEnumerable<Observation> pzzzzzh_ = context.Operators.Where<Observation>(pzzzzzf_, pzzzzzg_);
        bool? pzzzzzi_ = context.Operators.Exists<Observation>(pzzzzzh_);
        bool? pzzzzzj_ = context.Operators.Or(pzzzzzb_, pzzzzzi_);
        CqlValueSet pzzzzzk_ = this.Frailty_Diagnosis(context);
        IEnumerable<Condition> pzzzzzl_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, pzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? pzzzzzm_(Condition FrailtyDiagnosis)
        {
            CqlInterval<CqlDateTime> qzzzzzy_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, FrailtyDiagnosis);
            CqlInterval<CqlDateTime> qzzzzzz_ = this.Measurement_Period(context);
            bool? rzzzzza_ = context.Operators.Overlaps(qzzzzzy_, qzzzzzz_, "day");

            return rzzzzza_;
        };
        IEnumerable<Condition> pzzzzzn_ = context.Operators.Where<Condition>(pzzzzzl_, pzzzzzm_);
        bool? pzzzzzo_ = context.Operators.Exists<Condition>(pzzzzzn_);
        bool? pzzzzzp_ = context.Operators.Or(pzzzzzj_, pzzzzzo_);
        CqlValueSet pzzzzzq_ = this.Frailty_Encounter(context);
        IEnumerable<Encounter> pzzzzzr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> pzzzzzs_ = Status_1_8_000.Instance.isEncounterPerformed(context, pzzzzzr_);
        bool? pzzzzzt_(Encounter FrailtyEncounter)
        {
            Period rzzzzzb_ = FrailtyEncounter?.Period;
            CqlInterval<CqlDateTime> rzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzb_);
            CqlInterval<CqlDateTime> rzzzzzd_ = QICoreCommon_2_1_000.Instance.toInterval(context, rzzzzzc_ as object);
            CqlInterval<CqlDateTime> rzzzzze_ = this.Measurement_Period(context);
            bool? rzzzzzf_ = context.Operators.Overlaps(rzzzzzd_, rzzzzze_, "day");

            return rzzzzzf_;
        };
        IEnumerable<Encounter> pzzzzzu_ = context.Operators.Where<Encounter>(pzzzzzs_, pzzzzzt_);
        bool? pzzzzzv_ = context.Operators.Exists<Encounter>(pzzzzzu_);
        bool? pzzzzzw_ = context.Operators.Or(pzzzzzp_, pzzzzzv_);
        CqlValueSet pzzzzzx_ = this.Frailty_Symptom(context);
        IEnumerable<Observation> pzzzzzy_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, pzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> pzzzzzz_ = Status_1_8_000.Instance.isSymptom(context, pzzzzzy_);
        bool? qzzzzza_(Observation FrailtySymptom)
        {
            DataType rzzzzzg_ = FrailtySymptom?.Effective;
            object rzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzg_);
            CqlInterval<CqlDateTime> rzzzzzi_ = QICoreCommon_2_1_000.Instance.toInterval(context, rzzzzzh_);
            CqlInterval<CqlDateTime> rzzzzzj_ = this.Measurement_Period(context);
            bool? rzzzzzk_ = context.Operators.Overlaps(rzzzzzi_, rzzzzzj_, "day");

            return rzzzzzk_;
        };
        IEnumerable<Observation> qzzzzzb_ = context.Operators.Where<Observation>(pzzzzzz_, qzzzzza_);
        bool? qzzzzzc_ = context.Operators.Exists<Observation>(qzzzzzb_);
        bool? qzzzzzd_ = context.Operators.Or(pzzzzzw_, qzzzzzc_);

        return qzzzzzd_;
    }


    [CqlExpressionDefinition("Has Advanced Illness in Year Before or During Measurement Period")]
    public bool? Has_Advanced_Illness_in_Year_Before_or_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet rzzzzzl_ = this.Advanced_Illness(context);
        IEnumerable<Condition> rzzzzzm_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, rzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? rzzzzzn_(Condition AdvancedIllnessDiagnosis)
        {
            CqlInterval<CqlDateTime> rzzzzzq_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, AdvancedIllnessDiagnosis);
            CqlDateTime rzzzzzr_ = context.Operators.Start(rzzzzzq_);
            CqlInterval<CqlDateTime> rzzzzzs_ = this.Measurement_Period(context);
            CqlDateTime rzzzzzt_ = context.Operators.Start(rzzzzzs_);
            CqlQuantity rzzzzzu_ = context.Operators.Quantity(1m, "year");
            CqlDateTime rzzzzzv_ = context.Operators.Subtract(rzzzzzt_, rzzzzzu_);
            CqlDateTime rzzzzzx_ = context.Operators.End(rzzzzzs_);
            CqlInterval<CqlDateTime> rzzzzzy_ = context.Operators.Interval(rzzzzzv_, rzzzzzx_, true, true);
            bool? rzzzzzz_ = context.Operators.In<CqlDateTime>(rzzzzzr_, rzzzzzy_, "day");

            return rzzzzzz_;
        };
        IEnumerable<Condition> rzzzzzo_ = context.Operators.Where<Condition>(rzzzzzm_, rzzzzzn_);
        bool? rzzzzzp_ = context.Operators.Exists<Condition>(rzzzzzo_);

        return rzzzzzp_;
    }


    [CqlExpressionDefinition("Has Dementia Medications in Year Before or During Measurement Period")]
    public bool? Has_Dementia_Medications_in_Year_Before_or_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet szzzzza_ = this.Dementia_Medications(context);
        IEnumerable<MedicationRequest> szzzzzb_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, szzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> szzzzzc_ = Status_1_8_000.Instance.isMedicationActive(context, szzzzzb_);
        bool? szzzzzd_(MedicationRequest DementiaMedication)
        {
            CqlInterval<CqlDate> szzzzzg_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, DementiaMedication);
            CqlDate szzzzzh_ = szzzzzg_?.low;
            CqlDateTime szzzzzi_ = context.Operators.ConvertDateToDateTime(szzzzzh_);
            CqlDate szzzzzk_ = szzzzzg_?.high;
            CqlDateTime szzzzzl_ = context.Operators.ConvertDateToDateTime(szzzzzk_);
            bool? szzzzzn_ = szzzzzg_?.lowClosed;
            bool? szzzzzp_ = szzzzzg_?.highClosed;
            CqlInterval<CqlDateTime> szzzzzq_ = context.Operators.Interval(szzzzzi_, szzzzzl_, szzzzzn_, szzzzzp_);
            CqlInterval<CqlDateTime> szzzzzr_ = this.Measurement_Period(context);
            CqlDateTime szzzzzs_ = context.Operators.Start(szzzzzr_);
            CqlQuantity szzzzzt_ = context.Operators.Quantity(1m, "year");
            CqlDateTime szzzzzu_ = context.Operators.Subtract(szzzzzs_, szzzzzt_);
            CqlDateTime szzzzzw_ = context.Operators.End(szzzzzr_);
            CqlInterval<CqlDateTime> szzzzzx_ = context.Operators.Interval(szzzzzu_, szzzzzw_, true, true);
            bool? szzzzzy_ = context.Operators.Overlaps(szzzzzq_, szzzzzx_, "day");

            return szzzzzy_;
        };
        IEnumerable<MedicationRequest> szzzzze_ = context.Operators.Where<MedicationRequest>(szzzzzc_, szzzzzd_);
        bool? szzzzzf_ = context.Operators.Exists<MedicationRequest>(szzzzze_);

        return szzzzzf_;
    }


    [CqlExpressionDefinition("Is Age 66 or Older with Advanced Illness and Frailty")]
    public bool? Is_Age_66_or_Older_with_Advanced_Illness_and_Frailty(CqlContext context)
    {
        Patient szzzzzz_ = this.Patient(context);
        Date tzzzzza_ = szzzzzz_?.BirthDateElement;
        string tzzzzzb_ = tzzzzza_?.Value;
        CqlDate tzzzzzc_ = context.Operators.ConvertStringToDate(tzzzzzb_);
        CqlInterval<CqlDateTime> tzzzzzd_ = this.Measurement_Period(context);
        CqlDateTime tzzzzze_ = context.Operators.End(tzzzzzd_);
        CqlDate tzzzzzf_ = context.Operators.DateFrom(tzzzzze_);
        int? tzzzzzg_ = context.Operators.CalculateAgeAt(tzzzzzc_, tzzzzzf_, "year");
        bool? tzzzzzh_ = context.Operators.GreaterOrEqual(tzzzzzg_, 66);
        bool? tzzzzzi_ = this.Has_Criteria_Indicating_Frailty(context);
        bool? tzzzzzj_ = context.Operators.And(tzzzzzh_, tzzzzzi_);
        bool? tzzzzzk_ = this.Has_Advanced_Illness_in_Year_Before_or_During_Measurement_Period(context);
        bool? tzzzzzl_ = this.Has_Dementia_Medications_in_Year_Before_or_During_Measurement_Period(context);
        bool? tzzzzzm_ = context.Operators.Or(tzzzzzk_, tzzzzzl_);
        bool? tzzzzzn_ = context.Operators.And(tzzzzzj_, tzzzzzm_);

        return tzzzzzn_;
    }


    [CqlExpressionDefinition("Is Age 66 to 80 with Advanced Illness and Frailty or Is Age 81 or Older with Frailty")]
    public bool? Is_Age_66_to_80_with_Advanced_Illness_and_Frailty_or_Is_Age_81_or_Older_with_Frailty(CqlContext context)
    {
        Patient tzzzzzo_ = this.Patient(context);
        Date tzzzzzp_ = tzzzzzo_?.BirthDateElement;
        string tzzzzzq_ = tzzzzzp_?.Value;
        CqlDate tzzzzzr_ = context.Operators.ConvertStringToDate(tzzzzzq_);
        CqlInterval<CqlDateTime> tzzzzzs_ = this.Measurement_Period(context);
        CqlDateTime tzzzzzt_ = context.Operators.End(tzzzzzs_);
        CqlDate tzzzzzu_ = context.Operators.DateFrom(tzzzzzt_);
        int? tzzzzzv_ = context.Operators.CalculateAgeAt(tzzzzzr_, tzzzzzu_, "year");
        CqlInterval<int?> tzzzzzw_ = context.Operators.Interval(66, 80, true, true);
        bool? tzzzzzx_ = context.Operators.In<int?>(tzzzzzv_, tzzzzzw_, default);
        bool? tzzzzzy_ = this.Has_Criteria_Indicating_Frailty(context);
        bool? tzzzzzz_ = context.Operators.And(tzzzzzx_, tzzzzzy_);
        bool? uzzzzza_ = this.Has_Advanced_Illness_in_Year_Before_or_During_Measurement_Period(context);
        bool? uzzzzzb_ = this.Has_Dementia_Medications_in_Year_Before_or_During_Measurement_Period(context);
        bool? uzzzzzc_ = context.Operators.Or(uzzzzza_, uzzzzzb_);
        bool? uzzzzzd_ = context.Operators.And(tzzzzzz_, uzzzzzc_);
        Date uzzzzzf_ = tzzzzzo_?.BirthDateElement;
        string uzzzzzg_ = uzzzzzf_?.Value;
        CqlDate uzzzzzh_ = context.Operators.ConvertStringToDate(uzzzzzg_);
        CqlDateTime uzzzzzj_ = context.Operators.End(tzzzzzs_);
        CqlDate uzzzzzk_ = context.Operators.DateFrom(uzzzzzj_);
        int? uzzzzzl_ = context.Operators.CalculateAgeAt(uzzzzzh_, uzzzzzk_, "year");
        bool? uzzzzzm_ = context.Operators.GreaterOrEqual(uzzzzzl_, 81);
        bool? uzzzzzo_ = context.Operators.And(uzzzzzm_, tzzzzzy_);
        bool? uzzzzzp_ = context.Operators.Or(uzzzzzd_, uzzzzzo_);

        return uzzzzzp_;
    }


    [CqlExpressionDefinition("Is Age 66 or Older Living Long Term in a Nursing Home")]
    public bool? Is_Age_66_or_Older_Living_Long_Term_in_a_Nursing_Home(CqlContext context)
    {
        Patient uzzzzzq_ = this.Patient(context);
        Date uzzzzzr_ = uzzzzzq_?.BirthDateElement;
        string uzzzzzs_ = uzzzzzr_?.Value;
        CqlDate uzzzzzt_ = context.Operators.ConvertStringToDate(uzzzzzs_);
        CqlInterval<CqlDateTime> uzzzzzu_ = this.Measurement_Period(context);
        CqlDateTime uzzzzzv_ = context.Operators.End(uzzzzzu_);
        CqlDate uzzzzzw_ = context.Operators.DateFrom(uzzzzzv_);
        int? uzzzzzx_ = context.Operators.CalculateAgeAt(uzzzzzt_, uzzzzzw_, "year");
        bool? uzzzzzy_ = context.Operators.GreaterOrEqual(uzzzzzx_, 66);
        CqlCode uzzzzzz_ = this.Housing_status(context);
        IEnumerable<CqlCode> vzzzzza_ = context.Operators.ToList<CqlCode>(uzzzzzz_);
        IEnumerable<Observation> vzzzzzb_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, vzzzzza_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> vzzzzzc_ = Status_1_8_000.Instance.isAssessmentPerformed(context, vzzzzzb_);
        bool? vzzzzzd_(Observation HousingStatus)
        {
            DataType vzzzzzo_ = HousingStatus?.Effective;
            object vzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzo_);
            CqlInterval<CqlDateTime> vzzzzzq_ = QICoreCommon_2_1_000.Instance.toInterval(context, vzzzzzp_);
            CqlDateTime vzzzzzr_ = context.Operators.End(vzzzzzq_);
            CqlInterval<CqlDateTime> vzzzzzs_ = this.Measurement_Period(context);
            CqlDateTime vzzzzzt_ = context.Operators.End(vzzzzzs_);
            bool? vzzzzzu_ = context.Operators.SameOrBefore(vzzzzzr_, vzzzzzt_, "day");

            return vzzzzzu_;
        };
        IEnumerable<Observation> vzzzzze_ = context.Operators.Where<Observation>(vzzzzzc_, vzzzzzd_);
        object vzzzzzf_(Observation @this)
        {
            DataType vzzzzzv_ = @this?.Effective;
            object vzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzv_);
            CqlInterval<CqlDateTime> vzzzzzx_ = QICoreCommon_2_1_000.Instance.toInterval(context, vzzzzzw_);
            CqlDateTime vzzzzzy_ = context.Operators.End(vzzzzzx_);

            return vzzzzzy_;
        };
        IEnumerable<Observation> vzzzzzg_ = context.Operators.SortBy<Observation>(vzzzzze_, vzzzzzf_, System.ComponentModel.ListSortDirection.Ascending);
        Observation vzzzzzh_ = context.Operators.Last<Observation>(vzzzzzg_);
        Observation[] vzzzzzi_ = [
            vzzzzzh_,
        ];
        bool? vzzzzzj_(Observation LastHousingStatus)
        {
            DataType vzzzzzz_ = LastHousingStatus?.Value;
            object wzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzz_);
            CqlCode wzzzzzb_ = this.Lives_in_a_nursing_home__finding_(context);
            CqlConcept wzzzzzc_ = context.Operators.ConvertCodeToConcept(wzzzzzb_);
            bool? wzzzzzd_ = context.Operators.Equivalent(wzzzzza_ as CqlConcept, wzzzzzc_);

            return wzzzzzd_;
        };
        IEnumerable<Observation> vzzzzzk_ = context.Operators.Where<Observation>((IEnumerable<Observation>)vzzzzzi_, vzzzzzj_);
        Observation vzzzzzl_ = context.Operators.SingletonFrom<Observation>(vzzzzzk_);
        bool? vzzzzzm_ = context.Operators.Not((bool?)(vzzzzzl_ is null));
        bool? vzzzzzn_ = context.Operators.And(uzzzzzy_, vzzzzzm_);

        return vzzzzzn_;
    }


    #endregion Expressions

}
