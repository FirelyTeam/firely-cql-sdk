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
        object yzzzzzzzzzzt_ = context.ResolveParameter("AdvancedIllnessandFrailty-1.16.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)yzzzzzzzzzzt_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> yzzzzzzzzzzu_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient yzzzzzzzzzzv_ = context.Operators.SingletonFrom<Patient>(yzzzzzzzzzzu_);

        return yzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Has Criteria Indicating Frailty")]
    public bool? Has_Criteria_Indicating_Frailty(CqlContext context)
    {
        CqlValueSet yzzzzzzzzzzw_ = this.Frailty_Device(context);
        IEnumerable<DeviceRequest> yzzzzzzzzzzx_ = context.Operators.Retrieve<DeviceRequest>(new RetrieveParameters(default, yzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-devicerequest"));
        IEnumerable<DeviceRequest> yzzzzzzzzzzz_ = context.Operators.Retrieve<DeviceRequest>(new RetrieveParameters(default, yzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-devicerequest"));
        IEnumerable<DeviceRequest> zzzzzzzzzzza_ = context.Operators.Union<DeviceRequest>(yzzzzzzzzzzx_, yzzzzzzzzzzz_);
        IEnumerable<DeviceRequest> zzzzzzzzzzzb_ = Status_1_8_000.Instance.isDeviceOrder(context, zzzzzzzzzzza_);
        bool? zzzzzzzzzzzc_(DeviceRequest FrailtyDeviceOrder)
        {
            bool? azzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.doNotPerform(context, FrailtyDeviceOrder);
            bool? azzzzzzzzzzzi_ = context.Operators.IsTrue(azzzzzzzzzzzh_);
            bool? azzzzzzzzzzzj_ = context.Operators.Not(azzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzk_ = this.Measurement_Period(context);
            FhirDateTime azzzzzzzzzzzl_ = FrailtyDeviceOrder?.AuthoredOnElement;
            CqlDateTime azzzzzzzzzzzm_ = context.Operators.Convert<CqlDateTime>(azzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.toInterval(context, azzzzzzzzzzzm_ as object);
            bool? azzzzzzzzzzzo_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(azzzzzzzzzzzk_, azzzzzzzzzzzn_, "day");
            bool? azzzzzzzzzzzp_ = context.Operators.And(azzzzzzzzzzzj_, azzzzzzzzzzzo_);

            return azzzzzzzzzzzp_;
        };
        IEnumerable<DeviceRequest> zzzzzzzzzzzd_ = context.Operators.Where<DeviceRequest>(zzzzzzzzzzzb_, zzzzzzzzzzzc_);
        bool? zzzzzzzzzzze_ = context.Operators.Exists<DeviceRequest>(zzzzzzzzzzzd_);
        CqlCode zzzzzzzzzzzf_ = this.Medical_equipment_used(context);
        IEnumerable<CqlCode> zzzzzzzzzzzg_ = context.Operators.ToList<CqlCode>(zzzzzzzzzzzf_);
        IEnumerable<Observation> zzzzzzzzzzzh_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, zzzzzzzzzzzg_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> zzzzzzzzzzzi_ = Status_1_8_000.Instance.isAssessmentPerformed(context, zzzzzzzzzzzh_);
        bool? zzzzzzzzzzzj_(Observation EquipmentUsed)
        {
            DataType azzzzzzzzzzzq_ = EquipmentUsed?.Value;
            object azzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzq_);
            CqlValueSet azzzzzzzzzzzs_ = this.Frailty_Device(context);
            bool? azzzzzzzzzzzt_ = context.Operators.ConceptInValueSet(azzzzzzzzzzzr_ as CqlConcept, azzzzzzzzzzzs_);
            DataType azzzzzzzzzzzu_ = EquipmentUsed?.Effective;
            object azzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.toInterval(context, azzzzzzzzzzzv_);
            CqlDateTime azzzzzzzzzzzx_ = context.Operators.End(azzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzy_ = this.Measurement_Period(context);
            bool? azzzzzzzzzzzz_ = context.Operators.In<CqlDateTime>(azzzzzzzzzzzx_, azzzzzzzzzzzy_, "day");
            bool? bzzzzzzzzzzza_ = context.Operators.And(azzzzzzzzzzzt_, azzzzzzzzzzzz_);

            return bzzzzzzzzzzza_;
        };
        IEnumerable<Observation> zzzzzzzzzzzk_ = context.Operators.Where<Observation>(zzzzzzzzzzzi_, zzzzzzzzzzzj_);
        bool? zzzzzzzzzzzl_ = context.Operators.Exists<Observation>(zzzzzzzzzzzk_);
        bool? zzzzzzzzzzzm_ = context.Operators.Or(zzzzzzzzzzze_, zzzzzzzzzzzl_);
        CqlValueSet zzzzzzzzzzzn_ = this.Frailty_Diagnosis(context);
        IEnumerable<Condition> zzzzzzzzzzzo_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, zzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? zzzzzzzzzzzp_(Condition FrailtyDiagnosis)
        {
            CqlInterval<CqlDateTime> bzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, FrailtyDiagnosis);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzc_ = this.Measurement_Period(context);
            bool? bzzzzzzzzzzzd_ = context.Operators.Overlaps(bzzzzzzzzzzzb_, bzzzzzzzzzzzc_, "day");

            return bzzzzzzzzzzzd_;
        };
        IEnumerable<Condition> zzzzzzzzzzzq_ = context.Operators.Where<Condition>(zzzzzzzzzzzo_, zzzzzzzzzzzp_);
        bool? zzzzzzzzzzzr_ = context.Operators.Exists<Condition>(zzzzzzzzzzzq_);
        bool? zzzzzzzzzzzs_ = context.Operators.Or(zzzzzzzzzzzm_, zzzzzzzzzzzr_);
        CqlValueSet zzzzzzzzzzzt_ = this.Frailty_Encounter(context);
        IEnumerable<Encounter> zzzzzzzzzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> zzzzzzzzzzzv_ = Status_1_8_000.Instance.isEncounterPerformed(context, zzzzzzzzzzzu_);
        bool? zzzzzzzzzzzw_(Encounter FrailtyEncounter)
        {
            Period bzzzzzzzzzzze_ = FrailtyEncounter?.Period;
            CqlInterval<CqlDateTime> bzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzf_ as object);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzh_ = this.Measurement_Period(context);
            bool? bzzzzzzzzzzzi_ = context.Operators.Overlaps(bzzzzzzzzzzzg_, bzzzzzzzzzzzh_, "day");

            return bzzzzzzzzzzzi_;
        };
        IEnumerable<Encounter> zzzzzzzzzzzx_ = context.Operators.Where<Encounter>(zzzzzzzzzzzv_, zzzzzzzzzzzw_);
        bool? zzzzzzzzzzzy_ = context.Operators.Exists<Encounter>(zzzzzzzzzzzx_);
        bool? zzzzzzzzzzzz_ = context.Operators.Or(zzzzzzzzzzzs_, zzzzzzzzzzzy_);
        CqlValueSet azzzzzzzzzzza_ = this.Frailty_Symptom(context);
        IEnumerable<Observation> azzzzzzzzzzzb_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, azzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> azzzzzzzzzzzc_ = Status_1_8_000.Instance.isSymptom(context, azzzzzzzzzzzb_);
        bool? azzzzzzzzzzzd_(Observation FrailtySymptom)
        {
            DataType bzzzzzzzzzzzj_ = FrailtySymptom?.Effective;
            object bzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzk_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzm_ = this.Measurement_Period(context);
            bool? bzzzzzzzzzzzn_ = context.Operators.Overlaps(bzzzzzzzzzzzl_, bzzzzzzzzzzzm_, "day");

            return bzzzzzzzzzzzn_;
        };
        IEnumerable<Observation> azzzzzzzzzzze_ = context.Operators.Where<Observation>(azzzzzzzzzzzc_, azzzzzzzzzzzd_);
        bool? azzzzzzzzzzzf_ = context.Operators.Exists<Observation>(azzzzzzzzzzze_);
        bool? azzzzzzzzzzzg_ = context.Operators.Or(zzzzzzzzzzzz_, azzzzzzzzzzzf_);

        return azzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Has Advanced Illness in Year Before or During Measurement Period")]
    public bool? Has_Advanced_Illness_in_Year_Before_or_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet bzzzzzzzzzzzo_ = this.Advanced_Illness(context);
        IEnumerable<Condition> bzzzzzzzzzzzp_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? bzzzzzzzzzzzq_(Condition AdvancedIllnessDiagnosis)
        {
            CqlInterval<CqlDateTime> bzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, AdvancedIllnessDiagnosis);
            CqlDateTime bzzzzzzzzzzzu_ = context.Operators.Start(bzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzv_ = this.Measurement_Period(context);
            CqlDateTime bzzzzzzzzzzzw_ = context.Operators.Start(bzzzzzzzzzzzv_);
            CqlQuantity bzzzzzzzzzzzx_ = context.Operators.Quantity(1m, "year");
            CqlDateTime bzzzzzzzzzzzy_ = context.Operators.Subtract(bzzzzzzzzzzzw_, bzzzzzzzzzzzx_);
            CqlDateTime czzzzzzzzzzza_ = context.Operators.End(bzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzb_ = context.Operators.Interval(bzzzzzzzzzzzy_, czzzzzzzzzzza_, true, true);
            bool? czzzzzzzzzzzc_ = context.Operators.In<CqlDateTime>(bzzzzzzzzzzzu_, czzzzzzzzzzzb_, "day");

            return czzzzzzzzzzzc_;
        };
        IEnumerable<Condition> bzzzzzzzzzzzr_ = context.Operators.Where<Condition>(bzzzzzzzzzzzp_, bzzzzzzzzzzzq_);
        bool? bzzzzzzzzzzzs_ = context.Operators.Exists<Condition>(bzzzzzzzzzzzr_);

        return bzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Has Dementia Medications in Year Before or During Measurement Period")]
    public bool? Has_Dementia_Medications_in_Year_Before_or_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet czzzzzzzzzzzd_ = this.Dementia_Medications(context);
        IEnumerable<MedicationRequest> czzzzzzzzzzze_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, czzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> czzzzzzzzzzzf_ = Status_1_8_000.Instance.isMedicationActive(context, czzzzzzzzzzze_);
        bool? czzzzzzzzzzzg_(MedicationRequest DementiaMedication)
        {
            CqlInterval<CqlDate> czzzzzzzzzzzj_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, DementiaMedication);
            CqlDate czzzzzzzzzzzk_ = czzzzzzzzzzzj_?.low;
            CqlDateTime czzzzzzzzzzzl_ = context.Operators.ConvertDateToDateTime(czzzzzzzzzzzk_);
            CqlDate czzzzzzzzzzzn_ = czzzzzzzzzzzj_?.high;
            CqlDateTime czzzzzzzzzzzo_ = context.Operators.ConvertDateToDateTime(czzzzzzzzzzzn_);
            bool? czzzzzzzzzzzq_ = czzzzzzzzzzzj_?.lowClosed;
            bool? czzzzzzzzzzzs_ = czzzzzzzzzzzj_?.highClosed;
            CqlInterval<CqlDateTime> czzzzzzzzzzzt_ = context.Operators.Interval(czzzzzzzzzzzl_, czzzzzzzzzzzo_, czzzzzzzzzzzq_, czzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzu_ = this.Measurement_Period(context);
            CqlDateTime czzzzzzzzzzzv_ = context.Operators.Start(czzzzzzzzzzzu_);
            CqlQuantity czzzzzzzzzzzw_ = context.Operators.Quantity(1m, "year");
            CqlDateTime czzzzzzzzzzzx_ = context.Operators.Subtract(czzzzzzzzzzzv_, czzzzzzzzzzzw_);
            CqlDateTime czzzzzzzzzzzz_ = context.Operators.End(czzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> dzzzzzzzzzzza_ = context.Operators.Interval(czzzzzzzzzzzx_, czzzzzzzzzzzz_, true, true);
            bool? dzzzzzzzzzzzb_ = context.Operators.Overlaps(czzzzzzzzzzzt_, dzzzzzzzzzzza_, "day");

            return dzzzzzzzzzzzb_;
        };
        IEnumerable<MedicationRequest> czzzzzzzzzzzh_ = context.Operators.Where<MedicationRequest>(czzzzzzzzzzzf_, czzzzzzzzzzzg_);
        bool? czzzzzzzzzzzi_ = context.Operators.Exists<MedicationRequest>(czzzzzzzzzzzh_);

        return czzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Is Age 66 or Older with Advanced Illness and Frailty")]
    public bool? Is_Age_66_or_Older_with_Advanced_Illness_and_Frailty(CqlContext context)
    {
        Patient dzzzzzzzzzzzc_ = this.Patient(context);
        Date dzzzzzzzzzzzd_ = dzzzzzzzzzzzc_?.BirthDateElement;
        string dzzzzzzzzzzze_ = dzzzzzzzzzzzd_?.Value;
        CqlDate dzzzzzzzzzzzf_ = context.Operators.ConvertStringToDate(dzzzzzzzzzzze_);
        CqlInterval<CqlDateTime> dzzzzzzzzzzzg_ = this.Measurement_Period(context);
        CqlDateTime dzzzzzzzzzzzh_ = context.Operators.End(dzzzzzzzzzzzg_);
        CqlDate dzzzzzzzzzzzi_ = context.Operators.DateFrom(dzzzzzzzzzzzh_);
        int? dzzzzzzzzzzzj_ = context.Operators.CalculateAgeAt(dzzzzzzzzzzzf_, dzzzzzzzzzzzi_, "year");
        bool? dzzzzzzzzzzzk_ = context.Operators.GreaterOrEqual(dzzzzzzzzzzzj_, 66);
        bool? dzzzzzzzzzzzl_ = this.Has_Criteria_Indicating_Frailty(context);
        bool? dzzzzzzzzzzzm_ = context.Operators.And(dzzzzzzzzzzzk_, dzzzzzzzzzzzl_);
        bool? dzzzzzzzzzzzn_ = this.Has_Advanced_Illness_in_Year_Before_or_During_Measurement_Period(context);
        bool? dzzzzzzzzzzzo_ = this.Has_Dementia_Medications_in_Year_Before_or_During_Measurement_Period(context);
        bool? dzzzzzzzzzzzp_ = context.Operators.Or(dzzzzzzzzzzzn_, dzzzzzzzzzzzo_);
        bool? dzzzzzzzzzzzq_ = context.Operators.And(dzzzzzzzzzzzm_, dzzzzzzzzzzzp_);

        return dzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Is Age 66 to 80 with Advanced Illness and Frailty or Is Age 81 or Older with Frailty")]
    public bool? Is_Age_66_to_80_with_Advanced_Illness_and_Frailty_or_Is_Age_81_or_Older_with_Frailty(CqlContext context)
    {
        Patient dzzzzzzzzzzzr_ = this.Patient(context);
        Date dzzzzzzzzzzzs_ = dzzzzzzzzzzzr_?.BirthDateElement;
        string dzzzzzzzzzzzt_ = dzzzzzzzzzzzs_?.Value;
        CqlDate dzzzzzzzzzzzu_ = context.Operators.ConvertStringToDate(dzzzzzzzzzzzt_);
        CqlInterval<CqlDateTime> dzzzzzzzzzzzv_ = this.Measurement_Period(context);
        CqlDateTime dzzzzzzzzzzzw_ = context.Operators.End(dzzzzzzzzzzzv_);
        CqlDate dzzzzzzzzzzzx_ = context.Operators.DateFrom(dzzzzzzzzzzzw_);
        int? dzzzzzzzzzzzy_ = context.Operators.CalculateAgeAt(dzzzzzzzzzzzu_, dzzzzzzzzzzzx_, "year");
        CqlInterval<int?> dzzzzzzzzzzzz_ = context.Operators.Interval(66, 80, true, true);
        bool? ezzzzzzzzzzza_ = context.Operators.In<int?>(dzzzzzzzzzzzy_, dzzzzzzzzzzzz_, default);
        bool? ezzzzzzzzzzzb_ = this.Has_Criteria_Indicating_Frailty(context);
        bool? ezzzzzzzzzzzc_ = context.Operators.And(ezzzzzzzzzzza_, ezzzzzzzzzzzb_);
        bool? ezzzzzzzzzzzd_ = this.Has_Advanced_Illness_in_Year_Before_or_During_Measurement_Period(context);
        bool? ezzzzzzzzzzze_ = this.Has_Dementia_Medications_in_Year_Before_or_During_Measurement_Period(context);
        bool? ezzzzzzzzzzzf_ = context.Operators.Or(ezzzzzzzzzzzd_, ezzzzzzzzzzze_);
        bool? ezzzzzzzzzzzg_ = context.Operators.And(ezzzzzzzzzzzc_, ezzzzzzzzzzzf_);
        Date ezzzzzzzzzzzi_ = dzzzzzzzzzzzr_?.BirthDateElement;
        string ezzzzzzzzzzzj_ = ezzzzzzzzzzzi_?.Value;
        CqlDate ezzzzzzzzzzzk_ = context.Operators.ConvertStringToDate(ezzzzzzzzzzzj_);
        CqlDateTime ezzzzzzzzzzzm_ = context.Operators.End(dzzzzzzzzzzzv_);
        CqlDate ezzzzzzzzzzzn_ = context.Operators.DateFrom(ezzzzzzzzzzzm_);
        int? ezzzzzzzzzzzo_ = context.Operators.CalculateAgeAt(ezzzzzzzzzzzk_, ezzzzzzzzzzzn_, "year");
        bool? ezzzzzzzzzzzp_ = context.Operators.GreaterOrEqual(ezzzzzzzzzzzo_, 81);
        bool? ezzzzzzzzzzzr_ = context.Operators.And(ezzzzzzzzzzzp_, ezzzzzzzzzzzb_);
        bool? ezzzzzzzzzzzs_ = context.Operators.Or(ezzzzzzzzzzzg_, ezzzzzzzzzzzr_);

        return ezzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Is Age 66 or Older Living Long Term in a Nursing Home")]
    public bool? Is_Age_66_or_Older_Living_Long_Term_in_a_Nursing_Home(CqlContext context)
    {
        Patient ezzzzzzzzzzzt_ = this.Patient(context);
        Date ezzzzzzzzzzzu_ = ezzzzzzzzzzzt_?.BirthDateElement;
        string ezzzzzzzzzzzv_ = ezzzzzzzzzzzu_?.Value;
        CqlDate ezzzzzzzzzzzw_ = context.Operators.ConvertStringToDate(ezzzzzzzzzzzv_);
        CqlInterval<CqlDateTime> ezzzzzzzzzzzx_ = this.Measurement_Period(context);
        CqlDateTime ezzzzzzzzzzzy_ = context.Operators.End(ezzzzzzzzzzzx_);
        CqlDate ezzzzzzzzzzzz_ = context.Operators.DateFrom(ezzzzzzzzzzzy_);
        int? fzzzzzzzzzzza_ = context.Operators.CalculateAgeAt(ezzzzzzzzzzzw_, ezzzzzzzzzzzz_, "year");
        bool? fzzzzzzzzzzzb_ = context.Operators.GreaterOrEqual(fzzzzzzzzzzza_, 66);
        CqlCode fzzzzzzzzzzzc_ = this.Housing_status(context);
        IEnumerable<CqlCode> fzzzzzzzzzzzd_ = context.Operators.ToList<CqlCode>(fzzzzzzzzzzzc_);
        IEnumerable<Observation> fzzzzzzzzzzze_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, fzzzzzzzzzzzd_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> fzzzzzzzzzzzf_ = Status_1_8_000.Instance.isAssessmentPerformed(context, fzzzzzzzzzzze_);
        bool? fzzzzzzzzzzzg_(Observation HousingStatus)
        {
            DataType fzzzzzzzzzzzr_ = HousingStatus?.Effective;
            object fzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.toInterval(context, fzzzzzzzzzzzs_);
            CqlDateTime fzzzzzzzzzzzu_ = context.Operators.End(fzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzv_ = this.Measurement_Period(context);
            CqlDateTime fzzzzzzzzzzzw_ = context.Operators.End(fzzzzzzzzzzzv_);
            bool? fzzzzzzzzzzzx_ = context.Operators.SameOrBefore(fzzzzzzzzzzzu_, fzzzzzzzzzzzw_, "day");

            return fzzzzzzzzzzzx_;
        };
        IEnumerable<Observation> fzzzzzzzzzzzh_ = context.Operators.Where<Observation>(fzzzzzzzzzzzf_, fzzzzzzzzzzzg_);
        object fzzzzzzzzzzzi_(Observation @this)
        {
            DataType fzzzzzzzzzzzy_ = @this?.Effective;
            object fzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzy_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, fzzzzzzzzzzzz_);
            CqlDateTime gzzzzzzzzzzzb_ = context.Operators.End(gzzzzzzzzzzza_);

            return gzzzzzzzzzzzb_;
        };
        IEnumerable<Observation> fzzzzzzzzzzzj_ = context.Operators.SortBy<Observation>(fzzzzzzzzzzzh_, fzzzzzzzzzzzi_, System.ComponentModel.ListSortDirection.Ascending);
        Observation fzzzzzzzzzzzk_ = context.Operators.Last<Observation>(fzzzzzzzzzzzj_);
        Observation[] fzzzzzzzzzzzl_ = [
            fzzzzzzzzzzzk_,
        ];
        bool? fzzzzzzzzzzzm_(Observation LastHousingStatus)
        {
            DataType gzzzzzzzzzzzc_ = LastHousingStatus?.Value;
            object gzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzc_);
            CqlCode gzzzzzzzzzzze_ = this.Lives_in_a_nursing_home__finding_(context);
            CqlConcept gzzzzzzzzzzzf_ = context.Operators.ConvertCodeToConcept(gzzzzzzzzzzze_);
            bool? gzzzzzzzzzzzg_ = context.Operators.Equivalent(gzzzzzzzzzzzd_ as CqlConcept, gzzzzzzzzzzzf_);

            return gzzzzzzzzzzzg_;
        };
        IEnumerable<Observation> fzzzzzzzzzzzn_ = context.Operators.Where<Observation>((IEnumerable<Observation>)fzzzzzzzzzzzl_, fzzzzzzzzzzzm_);
        Observation fzzzzzzzzzzzo_ = context.Operators.SingletonFrom<Observation>(fzzzzzzzzzzzn_);
        bool? fzzzzzzzzzzzp_ = context.Operators.Not((bool?)(fzzzzzzzzzzzo_ is null));
        bool? fzzzzzzzzzzzq_ = context.Operators.And(fzzzzzzzzzzzb_, fzzzzzzzzzzzp_);

        return fzzzzzzzzzzzq_;
    }


    #endregion Expressions

}
