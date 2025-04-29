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
        object ezzzzzk_ = context.ResolveParameter("AdvancedIllnessandFrailty-1.16.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)ezzzzzk_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> ezzzzzl_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient ezzzzzm_ = context.Operators.SingletonFrom<Patient>(ezzzzzl_);

        return ezzzzzm_;
    }


    [CqlExpressionDefinition("Has Criteria Indicating Frailty")]
    public bool? Has_Criteria_Indicating_Frailty(CqlContext context)
    {
        CqlValueSet ezzzzzn_ = this.Frailty_Device(context);
        IEnumerable<DeviceRequest> ezzzzzo_ = context.Operators.Retrieve<DeviceRequest>(new RetrieveParameters(default, ezzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-devicerequest"));
        IEnumerable<DeviceRequest> ezzzzzq_ = context.Operators.Retrieve<DeviceRequest>(new RetrieveParameters(default, ezzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-devicerequest"));
        IEnumerable<DeviceRequest> ezzzzzr_ = context.Operators.Union<DeviceRequest>(ezzzzzo_, ezzzzzq_);
        IEnumerable<DeviceRequest> ezzzzzs_ = Status_1_8_000.Instance.isDeviceOrder(context, ezzzzzr_);
        bool? ezzzzzt_(DeviceRequest FrailtyDeviceOrder)
        {
            bool? fzzzzzy_ = QICoreCommon_2_1_000.Instance.doNotPerform(context, FrailtyDeviceOrder);
            bool? fzzzzzz_ = context.Operators.IsTrue(fzzzzzy_);
            bool? gzzzzza_ = context.Operators.Not(fzzzzzz_);
            CqlInterval<CqlDateTime> gzzzzzb_ = this.Measurement_Period(context);
            FhirDateTime gzzzzzc_ = FrailtyDeviceOrder?.AuthoredOnElement;
            CqlDateTime gzzzzzd_ = context.Operators.Convert<CqlDateTime>(gzzzzzc_);
            CqlInterval<CqlDateTime> gzzzzze_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzd_ as object);
            bool? gzzzzzf_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(gzzzzzb_, gzzzzze_, "day");
            bool? gzzzzzg_ = context.Operators.And(gzzzzza_, gzzzzzf_);

            return gzzzzzg_;
        };
        IEnumerable<DeviceRequest> ezzzzzu_ = context.Operators.Where<DeviceRequest>(ezzzzzs_, ezzzzzt_);
        bool? ezzzzzv_ = context.Operators.Exists<DeviceRequest>(ezzzzzu_);
        CqlCode ezzzzzw_ = this.Medical_equipment_used(context);
        IEnumerable<CqlCode> ezzzzzx_ = context.Operators.ToList<CqlCode>(ezzzzzw_);
        IEnumerable<Observation> ezzzzzy_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, ezzzzzx_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> ezzzzzz_ = Status_1_8_000.Instance.isAssessmentPerformed(context, ezzzzzy_);
        bool? fzzzzza_(Observation EquipmentUsed)
        {
            DataType gzzzzzh_ = EquipmentUsed?.Value;
            object gzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzh_);
            CqlValueSet gzzzzzj_ = this.Frailty_Device(context);
            bool? gzzzzzk_ = context.Operators.ConceptInValueSet(gzzzzzi_ as CqlConcept, gzzzzzj_);
            DataType gzzzzzl_ = EquipmentUsed?.Effective;
            object gzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzl_);
            CqlInterval<CqlDateTime> gzzzzzn_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzm_);
            CqlDateTime gzzzzzo_ = context.Operators.End(gzzzzzn_);
            CqlInterval<CqlDateTime> gzzzzzp_ = this.Measurement_Period(context);
            bool? gzzzzzq_ = context.Operators.In<CqlDateTime>(gzzzzzo_, gzzzzzp_, "day");
            bool? gzzzzzr_ = context.Operators.And(gzzzzzk_, gzzzzzq_);

            return gzzzzzr_;
        };
        IEnumerable<Observation> fzzzzzb_ = context.Operators.Where<Observation>(ezzzzzz_, fzzzzza_);
        bool? fzzzzzc_ = context.Operators.Exists<Observation>(fzzzzzb_);
        bool? fzzzzzd_ = context.Operators.Or(ezzzzzv_, fzzzzzc_);
        CqlValueSet fzzzzze_ = this.Frailty_Diagnosis(context);
        IEnumerable<Condition> fzzzzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, fzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? fzzzzzg_(Condition FrailtyDiagnosis)
        {
            CqlInterval<CqlDateTime> gzzzzzs_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, FrailtyDiagnosis);
            CqlInterval<CqlDateTime> gzzzzzt_ = this.Measurement_Period(context);
            bool? gzzzzzu_ = context.Operators.Overlaps(gzzzzzs_, gzzzzzt_, "day");

            return gzzzzzu_;
        };
        IEnumerable<Condition> fzzzzzh_ = context.Operators.Where<Condition>(fzzzzzf_, fzzzzzg_);
        bool? fzzzzzi_ = context.Operators.Exists<Condition>(fzzzzzh_);
        bool? fzzzzzj_ = context.Operators.Or(fzzzzzd_, fzzzzzi_);
        CqlValueSet fzzzzzk_ = this.Frailty_Encounter(context);
        IEnumerable<Encounter> fzzzzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> fzzzzzm_ = Status_1_8_000.Instance.isEncounterPerformed(context, fzzzzzl_);
        bool? fzzzzzn_(Encounter FrailtyEncounter)
        {
            Period gzzzzzv_ = FrailtyEncounter?.Period;
            CqlInterval<CqlDateTime> gzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzv_);
            CqlInterval<CqlDateTime> gzzzzzx_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzw_ as object);
            CqlInterval<CqlDateTime> gzzzzzy_ = this.Measurement_Period(context);
            bool? gzzzzzz_ = context.Operators.Overlaps(gzzzzzx_, gzzzzzy_, "day");

            return gzzzzzz_;
        };
        IEnumerable<Encounter> fzzzzzo_ = context.Operators.Where<Encounter>(fzzzzzm_, fzzzzzn_);
        bool? fzzzzzp_ = context.Operators.Exists<Encounter>(fzzzzzo_);
        bool? fzzzzzq_ = context.Operators.Or(fzzzzzj_, fzzzzzp_);
        CqlValueSet fzzzzzr_ = this.Frailty_Symptom(context);
        IEnumerable<Observation> fzzzzzs_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, fzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> fzzzzzt_ = Status_1_8_000.Instance.isSymptom(context, fzzzzzs_);
        bool? fzzzzzu_(Observation FrailtySymptom)
        {
            DataType hzzzzza_ = FrailtySymptom?.Effective;
            object hzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzza_);
            CqlInterval<CqlDateTime> hzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, hzzzzzb_);
            CqlInterval<CqlDateTime> hzzzzzd_ = this.Measurement_Period(context);
            bool? hzzzzze_ = context.Operators.Overlaps(hzzzzzc_, hzzzzzd_, "day");

            return hzzzzze_;
        };
        IEnumerable<Observation> fzzzzzv_ = context.Operators.Where<Observation>(fzzzzzt_, fzzzzzu_);
        bool? fzzzzzw_ = context.Operators.Exists<Observation>(fzzzzzv_);
        bool? fzzzzzx_ = context.Operators.Or(fzzzzzq_, fzzzzzw_);

        return fzzzzzx_;
    }


    [CqlExpressionDefinition("Has Advanced Illness in Year Before or During Measurement Period")]
    public bool? Has_Advanced_Illness_in_Year_Before_or_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet hzzzzzf_ = this.Advanced_Illness(context);
        IEnumerable<Condition> hzzzzzg_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, hzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? hzzzzzh_(Condition AdvancedIllnessDiagnosis)
        {
            CqlInterval<CqlDateTime> hzzzzzk_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, AdvancedIllnessDiagnosis);
            CqlDateTime hzzzzzl_ = context.Operators.Start(hzzzzzk_);
            CqlInterval<CqlDateTime> hzzzzzm_ = this.Measurement_Period(context);
            CqlDateTime hzzzzzn_ = context.Operators.Start(hzzzzzm_);
            CqlQuantity hzzzzzo_ = context.Operators.Quantity(1m, "year");
            CqlDateTime hzzzzzp_ = context.Operators.Subtract(hzzzzzn_, hzzzzzo_);
            CqlDateTime hzzzzzr_ = context.Operators.End(hzzzzzm_);
            CqlInterval<CqlDateTime> hzzzzzs_ = context.Operators.Interval(hzzzzzp_, hzzzzzr_, true, true);
            bool? hzzzzzt_ = context.Operators.In<CqlDateTime>(hzzzzzl_, hzzzzzs_, "day");

            return hzzzzzt_;
        };
        IEnumerable<Condition> hzzzzzi_ = context.Operators.Where<Condition>(hzzzzzg_, hzzzzzh_);
        bool? hzzzzzj_ = context.Operators.Exists<Condition>(hzzzzzi_);

        return hzzzzzj_;
    }


    [CqlExpressionDefinition("Has Dementia Medications in Year Before or During Measurement Period")]
    public bool? Has_Dementia_Medications_in_Year_Before_or_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet hzzzzzu_ = this.Dementia_Medications(context);
        IEnumerable<MedicationRequest> hzzzzzv_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, hzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> hzzzzzw_ = Status_1_8_000.Instance.isMedicationActive(context, hzzzzzv_);
        bool? hzzzzzx_(MedicationRequest DementiaMedication)
        {
            CqlInterval<CqlDate> izzzzza_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, DementiaMedication);
            CqlDate izzzzzb_ = izzzzza_?.low;
            CqlDateTime izzzzzc_ = context.Operators.ConvertDateToDateTime(izzzzzb_);
            CqlDate izzzzze_ = izzzzza_?.high;
            CqlDateTime izzzzzf_ = context.Operators.ConvertDateToDateTime(izzzzze_);
            bool? izzzzzh_ = izzzzza_?.lowClosed;
            bool? izzzzzj_ = izzzzza_?.highClosed;
            CqlInterval<CqlDateTime> izzzzzk_ = context.Operators.Interval(izzzzzc_, izzzzzf_, izzzzzh_, izzzzzj_);
            CqlInterval<CqlDateTime> izzzzzl_ = this.Measurement_Period(context);
            CqlDateTime izzzzzm_ = context.Operators.Start(izzzzzl_);
            CqlQuantity izzzzzn_ = context.Operators.Quantity(1m, "year");
            CqlDateTime izzzzzo_ = context.Operators.Subtract(izzzzzm_, izzzzzn_);
            CqlDateTime izzzzzq_ = context.Operators.End(izzzzzl_);
            CqlInterval<CqlDateTime> izzzzzr_ = context.Operators.Interval(izzzzzo_, izzzzzq_, true, true);
            bool? izzzzzs_ = context.Operators.Overlaps(izzzzzk_, izzzzzr_, "day");

            return izzzzzs_;
        };
        IEnumerable<MedicationRequest> hzzzzzy_ = context.Operators.Where<MedicationRequest>(hzzzzzw_, hzzzzzx_);
        bool? hzzzzzz_ = context.Operators.Exists<MedicationRequest>(hzzzzzy_);

        return hzzzzzz_;
    }


    [CqlExpressionDefinition("Is Age 66 or Older with Advanced Illness and Frailty")]
    public bool? Is_Age_66_or_Older_with_Advanced_Illness_and_Frailty(CqlContext context)
    {
        Patient izzzzzt_ = this.Patient(context);
        Date izzzzzu_ = izzzzzt_?.BirthDateElement;
        string izzzzzv_ = izzzzzu_?.Value;
        CqlDate izzzzzw_ = context.Operators.ConvertStringToDate(izzzzzv_);
        CqlInterval<CqlDateTime> izzzzzx_ = this.Measurement_Period(context);
        CqlDateTime izzzzzy_ = context.Operators.End(izzzzzx_);
        CqlDate izzzzzz_ = context.Operators.DateFrom(izzzzzy_);
        int? jzzzzza_ = context.Operators.CalculateAgeAt(izzzzzw_, izzzzzz_, "year");
        bool? jzzzzzb_ = context.Operators.GreaterOrEqual(jzzzzza_, 66);
        bool? jzzzzzc_ = this.Has_Criteria_Indicating_Frailty(context);
        bool? jzzzzzd_ = context.Operators.And(jzzzzzb_, jzzzzzc_);
        bool? jzzzzze_ = this.Has_Advanced_Illness_in_Year_Before_or_During_Measurement_Period(context);
        bool? jzzzzzf_ = this.Has_Dementia_Medications_in_Year_Before_or_During_Measurement_Period(context);
        bool? jzzzzzg_ = context.Operators.Or(jzzzzze_, jzzzzzf_);
        bool? jzzzzzh_ = context.Operators.And(jzzzzzd_, jzzzzzg_);

        return jzzzzzh_;
    }


    [CqlExpressionDefinition("Is Age 66 to 80 with Advanced Illness and Frailty or Is Age 81 or Older with Frailty")]
    public bool? Is_Age_66_to_80_with_Advanced_Illness_and_Frailty_or_Is_Age_81_or_Older_with_Frailty(CqlContext context)
    {
        Patient jzzzzzi_ = this.Patient(context);
        Date jzzzzzj_ = jzzzzzi_?.BirthDateElement;
        string jzzzzzk_ = jzzzzzj_?.Value;
        CqlDate jzzzzzl_ = context.Operators.ConvertStringToDate(jzzzzzk_);
        CqlInterval<CqlDateTime> jzzzzzm_ = this.Measurement_Period(context);
        CqlDateTime jzzzzzn_ = context.Operators.End(jzzzzzm_);
        CqlDate jzzzzzo_ = context.Operators.DateFrom(jzzzzzn_);
        int? jzzzzzp_ = context.Operators.CalculateAgeAt(jzzzzzl_, jzzzzzo_, "year");
        CqlInterval<int?> jzzzzzq_ = context.Operators.Interval(66, 80, true, true);
        bool? jzzzzzr_ = context.Operators.In<int?>(jzzzzzp_, jzzzzzq_, default);
        bool? jzzzzzs_ = this.Has_Criteria_Indicating_Frailty(context);
        bool? jzzzzzt_ = context.Operators.And(jzzzzzr_, jzzzzzs_);
        bool? jzzzzzu_ = this.Has_Advanced_Illness_in_Year_Before_or_During_Measurement_Period(context);
        bool? jzzzzzv_ = this.Has_Dementia_Medications_in_Year_Before_or_During_Measurement_Period(context);
        bool? jzzzzzw_ = context.Operators.Or(jzzzzzu_, jzzzzzv_);
        bool? jzzzzzx_ = context.Operators.And(jzzzzzt_, jzzzzzw_);
        Date jzzzzzz_ = jzzzzzi_?.BirthDateElement;
        string kzzzzza_ = jzzzzzz_?.Value;
        CqlDate kzzzzzb_ = context.Operators.ConvertStringToDate(kzzzzza_);
        CqlDateTime kzzzzzd_ = context.Operators.End(jzzzzzm_);
        CqlDate kzzzzze_ = context.Operators.DateFrom(kzzzzzd_);
        int? kzzzzzf_ = context.Operators.CalculateAgeAt(kzzzzzb_, kzzzzze_, "year");
        bool? kzzzzzg_ = context.Operators.GreaterOrEqual(kzzzzzf_, 81);
        bool? kzzzzzi_ = context.Operators.And(kzzzzzg_, jzzzzzs_);
        bool? kzzzzzj_ = context.Operators.Or(jzzzzzx_, kzzzzzi_);

        return kzzzzzj_;
    }


    [CqlExpressionDefinition("Is Age 66 or Older Living Long Term in a Nursing Home")]
    public bool? Is_Age_66_or_Older_Living_Long_Term_in_a_Nursing_Home(CqlContext context)
    {
        Patient kzzzzzk_ = this.Patient(context);
        Date kzzzzzl_ = kzzzzzk_?.BirthDateElement;
        string kzzzzzm_ = kzzzzzl_?.Value;
        CqlDate kzzzzzn_ = context.Operators.ConvertStringToDate(kzzzzzm_);
        CqlInterval<CqlDateTime> kzzzzzo_ = this.Measurement_Period(context);
        CqlDateTime kzzzzzp_ = context.Operators.End(kzzzzzo_);
        CqlDate kzzzzzq_ = context.Operators.DateFrom(kzzzzzp_);
        int? kzzzzzr_ = context.Operators.CalculateAgeAt(kzzzzzn_, kzzzzzq_, "year");
        bool? kzzzzzs_ = context.Operators.GreaterOrEqual(kzzzzzr_, 66);
        CqlCode kzzzzzt_ = this.Housing_status(context);
        IEnumerable<CqlCode> kzzzzzu_ = context.Operators.ToList<CqlCode>(kzzzzzt_);
        IEnumerable<Observation> kzzzzzv_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, kzzzzzu_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> kzzzzzw_ = Status_1_8_000.Instance.isAssessmentPerformed(context, kzzzzzv_);
        bool? kzzzzzx_(Observation HousingStatus)
        {
            DataType lzzzzzi_ = HousingStatus?.Effective;
            object lzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzi_);
            CqlInterval<CqlDateTime> lzzzzzk_ = QICoreCommon_2_1_000.Instance.toInterval(context, lzzzzzj_);
            CqlDateTime lzzzzzl_ = context.Operators.End(lzzzzzk_);
            CqlInterval<CqlDateTime> lzzzzzm_ = this.Measurement_Period(context);
            CqlDateTime lzzzzzn_ = context.Operators.End(lzzzzzm_);
            bool? lzzzzzo_ = context.Operators.SameOrBefore(lzzzzzl_, lzzzzzn_, "day");

            return lzzzzzo_;
        };
        IEnumerable<Observation> kzzzzzy_ = context.Operators.Where<Observation>(kzzzzzw_, kzzzzzx_);
        object kzzzzzz_(Observation @this)
        {
            DataType lzzzzzp_ = @this?.Effective;
            object lzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzp_);
            CqlInterval<CqlDateTime> lzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, lzzzzzq_);
            CqlDateTime lzzzzzs_ = context.Operators.End(lzzzzzr_);

            return lzzzzzs_;
        };
        IEnumerable<Observation> lzzzzza_ = context.Operators.SortBy<Observation>(kzzzzzy_, kzzzzzz_, System.ComponentModel.ListSortDirection.Ascending);
        Observation lzzzzzb_ = context.Operators.Last<Observation>(lzzzzza_);
        Observation[] lzzzzzc_ = [
            lzzzzzb_,
        ];
        bool? lzzzzzd_(Observation LastHousingStatus)
        {
            DataType lzzzzzt_ = LastHousingStatus?.Value;
            object lzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzt_);
            CqlCode lzzzzzv_ = this.Lives_in_a_nursing_home__finding_(context);
            CqlConcept lzzzzzw_ = context.Operators.ConvertCodeToConcept(lzzzzzv_);
            bool? lzzzzzx_ = context.Operators.Equivalent(lzzzzzu_ as CqlConcept, lzzzzzw_);

            return lzzzzzx_;
        };
        IEnumerable<Observation> lzzzzze_ = context.Operators.Where<Observation>((IEnumerable<Observation>)lzzzzzc_, lzzzzzd_);
        Observation lzzzzzf_ = context.Operators.SingletonFrom<Observation>(lzzzzze_);
        bool? lzzzzzg_ = context.Operators.Not((bool?)(lzzzzzf_ is null));
        bool? lzzzzzh_ = context.Operators.And(kzzzzzs_, lzzzzzg_);

        return lzzzzzh_;
    }


    #endregion Expressions

}
