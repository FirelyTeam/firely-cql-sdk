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
      new CqlCodeSystem("http://loinc.org", null,
          _Housing_status,
          _Medical_equipment_used);

    [CqlCodeSystemDefinition("SNOMEDCT")]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null,
          _Lives_in_a_nursing_home__finding_);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object zzzzzzzzzzzzzzzzzzzzzzr_ = context.ResolveParameter("AdvancedIllnessandFrailty-1.16.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)zzzzzzzzzzzzzzzzzzzzzzr_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> zzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient zzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.SingletonFrom<Patient>(zzzzzzzzzzzzzzzzzzzzzzs_);

        return zzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Has Criteria Indicating Frailty")]
    public bool? Has_Criteria_Indicating_Frailty(CqlContext context)
    {
        CqlValueSet zzzzzzzzzzzzzzzzzzzzzzu_ = this.Frailty_Device(context);
        IEnumerable<DeviceRequest> zzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<DeviceRequest>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-devicerequest"));
        IEnumerable<DeviceRequest> zzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<DeviceRequest>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-devicerequest"));
        IEnumerable<DeviceRequest> zzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<DeviceRequest>(zzzzzzzzzzzzzzzzzzzzzzv_, zzzzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<DeviceRequest> zzzzzzzzzzzzzzzzzzzzzzz_ = Status_1_8_000.Instance.isDeviceOrder(context, zzzzzzzzzzzzzzzzzzzzzzy_);
        bool? azzzzzzzzzzzzzzzzzzzzzza_(DeviceRequest FrailtyDeviceOrder)
        {
            bool? bzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.doNotPerform(context, FrailtyDeviceOrder);
            bool? bzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.IsTrue(bzzzzzzzzzzzzzzzzzzzzzzf_);
            bool? bzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Not(bzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzi_ = this.Measurement_Period(context);
            FhirDateTime bzzzzzzzzzzzzzzzzzzzzzzj_ = FrailtyDeviceOrder?.AuthoredOnElement;
            CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzzzzzzzzzzzzk_ as object);
            bool? bzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzzzi_, bzzzzzzzzzzzzzzzzzzzzzzl_, "day");
            bool? bzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzzh_, bzzzzzzzzzzzzzzzzzzzzzzm_);

            return bzzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<DeviceRequest> azzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<DeviceRequest>(zzzzzzzzzzzzzzzzzzzzzzz_, azzzzzzzzzzzzzzzzzzzzzza_);
        bool? azzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Exists<DeviceRequest>(azzzzzzzzzzzzzzzzzzzzzzb_);
        CqlCode azzzzzzzzzzzzzzzzzzzzzzd_ = this.Medical_equipment_used(context);
        IEnumerable<CqlCode> azzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.ToList<CqlCode>(azzzzzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, azzzzzzzzzzzzzzzzzzzzzze_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzg_ = Status_1_8_000.Instance.isAssessmentPerformed(context, azzzzzzzzzzzzzzzzzzzzzzf_);
        bool? azzzzzzzzzzzzzzzzzzzzzzh_(Observation EquipmentUsed)
        {
            DataType bzzzzzzzzzzzzzzzzzzzzzzo_ = EquipmentUsed?.Value;
            object bzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzq_ = this.Frailty_Device(context);
            bool? bzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ConceptInValueSet(bzzzzzzzzzzzzzzzzzzzzzzp_ as CqlConcept, bzzzzzzzzzzzzzzzzzzzzzzq_);
            DataType bzzzzzzzzzzzzzzzzzzzzzzs_ = EquipmentUsed?.Effective;
            object bzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.End(bzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzw_ = this.Measurement_Period(context);
            bool? bzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.In<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzzzv_, bzzzzzzzzzzzzzzzzzzzzzzw_, "day");
            bool? bzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzzr_, bzzzzzzzzzzzzzzzzzzzzzzx_);

            return bzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Observation>(azzzzzzzzzzzzzzzzzzzzzzg_, azzzzzzzzzzzzzzzzzzzzzzh_);
        bool? azzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Exists<Observation>(azzzzzzzzzzzzzzzzzzzzzzi_);
        bool? azzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Or(azzzzzzzzzzzzzzzzzzzzzzc_, azzzzzzzzzzzzzzzzzzzzzzj_);
        CqlValueSet azzzzzzzzzzzzzzzzzzzzzzl_ = this.Frailty_Diagnosis(context);
        IEnumerable<Condition> azzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? azzzzzzzzzzzzzzzzzzzzzzn_(Condition FrailtyDiagnosis)
        {
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, FrailtyDiagnosis);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzza_ = this.Measurement_Period(context);
            bool? czzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Overlaps(bzzzzzzzzzzzzzzzzzzzzzzz_, czzzzzzzzzzzzzzzzzzzzzza_, "day");

            return czzzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<Condition> azzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Condition>(azzzzzzzzzzzzzzzzzzzzzzm_, azzzzzzzzzzzzzzzzzzzzzzn_);
        bool? azzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Exists<Condition>(azzzzzzzzzzzzzzzzzzzzzzo_);
        bool? azzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Or(azzzzzzzzzzzzzzzzzzzzzzk_, azzzzzzzzzzzzzzzzzzzzzzp_);
        CqlValueSet azzzzzzzzzzzzzzzzzzzzzzr_ = this.Frailty_Encounter(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzt_ = Status_1_8_000.Instance.isEncounterPerformed(context, azzzzzzzzzzzzzzzzzzzzzzs_);
        bool? azzzzzzzzzzzzzzzzzzzzzzu_(Encounter FrailtyEncounter)
        {
            Period czzzzzzzzzzzzzzzzzzzzzzc_ = FrailtyEncounter?.Period;
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzzzzzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.toInterval(context, czzzzzzzzzzzzzzzzzzzzzzd_ as object);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzf_ = this.Measurement_Period(context);
            bool? czzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Overlaps(czzzzzzzzzzzzzzzzzzzzzze_, czzzzzzzzzzzzzzzzzzzzzzf_, "day");

            return czzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Encounter>(azzzzzzzzzzzzzzzzzzzzzzt_, azzzzzzzzzzzzzzzzzzzzzzu_);
        bool? azzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Exists<Encounter>(azzzzzzzzzzzzzzzzzzzzzzv_);
        bool? azzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Or(azzzzzzzzzzzzzzzzzzzzzzq_, azzzzzzzzzzzzzzzzzzzzzzw_);
        CqlValueSet azzzzzzzzzzzzzzzzzzzzzzy_ = this.Frailty_Symptom(context);
        IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzzzza_ = Status_1_8_000.Instance.isSymptom(context, azzzzzzzzzzzzzzzzzzzzzzz_);
        bool? bzzzzzzzzzzzzzzzzzzzzzzb_(Observation FrailtySymptom)
        {
            DataType czzzzzzzzzzzzzzzzzzzzzzh_ = FrailtySymptom?.Effective;
            object czzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.toInterval(context, czzzzzzzzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzk_ = this.Measurement_Period(context);
            bool? czzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Overlaps(czzzzzzzzzzzzzzzzzzzzzzj_, czzzzzzzzzzzzzzzzzzzzzzk_, "day");

            return czzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Observation>(bzzzzzzzzzzzzzzzzzzzzzza_, bzzzzzzzzzzzzzzzzzzzzzzb_);
        bool? bzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Exists<Observation>(bzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? bzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Or(azzzzzzzzzzzzzzzzzzzzzzx_, bzzzzzzzzzzzzzzzzzzzzzzd_);

        return bzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Has Advanced Illness in Year Before or During Measurement Period")]
    public bool? Has_Advanced_Illness_in_Year_Before_or_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet czzzzzzzzzzzzzzzzzzzzzzm_ = this.Advanced_Illness(context);
        IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? czzzzzzzzzzzzzzzzzzzzzzo_(Condition AdvancedIllnessDiagnosis)
        {
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, AdvancedIllnessDiagnosis);
            CqlDateTime czzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzt_ = this.Measurement_Period(context);
            CqlDateTime czzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzzzzzt_);
            CqlQuantity czzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Quantity(1m, "year");
            CqlDateTime czzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Subtract(czzzzzzzzzzzzzzzzzzzzzzu_, czzzzzzzzzzzzzzzzzzzzzzv_);
            CqlDateTime czzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.End(czzzzzzzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Interval(czzzzzzzzzzzzzzzzzzzzzzw_, czzzzzzzzzzzzzzzzzzzzzzy_, true, true);
            bool? dzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(czzzzzzzzzzzzzzzzzzzzzzs_, czzzzzzzzzzzzzzzzzzzzzzz_, "day");

            return dzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Condition>(czzzzzzzzzzzzzzzzzzzzzzn_, czzzzzzzzzzzzzzzzzzzzzzo_);
        bool? czzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Exists<Condition>(czzzzzzzzzzzzzzzzzzzzzzp_);

        return czzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Has Dementia Medications in Year Before or During Measurement Period")]
    public bool? Has_Dementia_Medications_in_Year_Before_or_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzb_ = this.Dementia_Medications(context);
        IEnumerable<MedicationRequest> dzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> dzzzzzzzzzzzzzzzzzzzzzzd_ = Status_1_8_000.Instance.isMedicationActive(context, dzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? dzzzzzzzzzzzzzzzzzzzzzze_(MedicationRequest DementiaMedication)
        {
            CqlInterval<CqlDate> dzzzzzzzzzzzzzzzzzzzzzzh_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, DementiaMedication);
            CqlDate dzzzzzzzzzzzzzzzzzzzzzzi_ = dzzzzzzzzzzzzzzzzzzzzzzh_?.low;
            CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.ConvertDateToDateTime(dzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlDate dzzzzzzzzzzzzzzzzzzzzzzl_ = dzzzzzzzzzzzzzzzzzzzzzzh_?.high;
            CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.ConvertDateToDateTime(dzzzzzzzzzzzzzzzzzzzzzzl_);
            bool? dzzzzzzzzzzzzzzzzzzzzzzo_ = dzzzzzzzzzzzzzzzzzzzzzzh_?.lowClosed;
            bool? dzzzzzzzzzzzzzzzzzzzzzzq_ = dzzzzzzzzzzzzzzzzzzzzzzh_?.highClosed;
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Interval(dzzzzzzzzzzzzzzzzzzzzzzj_, dzzzzzzzzzzzzzzzzzzzzzzm_, dzzzzzzzzzzzzzzzzzzzzzzo_, dzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzs_ = this.Measurement_Period(context);
            CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(dzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlQuantity dzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Quantity(1m, "year");
            CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Subtract(dzzzzzzzzzzzzzzzzzzzzzzt_, dzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.End(dzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Interval(dzzzzzzzzzzzzzzzzzzzzzzv_, dzzzzzzzzzzzzzzzzzzzzzzx_, true, true);
            bool? dzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Overlaps(dzzzzzzzzzzzzzzzzzzzzzzr_, dzzzzzzzzzzzzzzzzzzzzzzy_, "day");

            return dzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<MedicationRequest> dzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<MedicationRequest>(dzzzzzzzzzzzzzzzzzzzzzzd_, dzzzzzzzzzzzzzzzzzzzzzze_);
        bool? dzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Exists<MedicationRequest>(dzzzzzzzzzzzzzzzzzzzzzzf_);

        return dzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Is Age 66 or Older with Advanced Illness and Frailty")]
    public bool? Is_Age_66_or_Older_with_Advanced_Illness_and_Frailty(CqlContext context)
    {
        Patient ezzzzzzzzzzzzzzzzzzzzzza_ = this.Patient(context);
        Date ezzzzzzzzzzzzzzzzzzzzzzb_ = ezzzzzzzzzzzzzzzzzzzzzza_?.BirthDateElement;
        string ezzzzzzzzzzzzzzzzzzzzzzc_ = ezzzzzzzzzzzzzzzzzzzzzzb_?.Value;
        CqlDate ezzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ConvertStringToDate(ezzzzzzzzzzzzzzzzzzzzzzc_);
        CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzze_ = this.Measurement_Period(context);
        CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.End(ezzzzzzzzzzzzzzzzzzzzzze_);
        CqlDate ezzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.DateFrom(ezzzzzzzzzzzzzzzzzzzzzzf_);
        int? ezzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.CalculateAgeAt(ezzzzzzzzzzzzzzzzzzzzzzd_, ezzzzzzzzzzzzzzzzzzzzzzg_, "year");
        bool? ezzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.GreaterOrEqual(ezzzzzzzzzzzzzzzzzzzzzzh_, 66);
        bool? ezzzzzzzzzzzzzzzzzzzzzzj_ = this.Has_Criteria_Indicating_Frailty(context);
        bool? ezzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(ezzzzzzzzzzzzzzzzzzzzzzi_, ezzzzzzzzzzzzzzzzzzzzzzj_);
        bool? ezzzzzzzzzzzzzzzzzzzzzzl_ = this.Has_Advanced_Illness_in_Year_Before_or_During_Measurement_Period(context);
        bool? ezzzzzzzzzzzzzzzzzzzzzzm_ = this.Has_Dementia_Medications_in_Year_Before_or_During_Measurement_Period(context);
        bool? ezzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Or(ezzzzzzzzzzzzzzzzzzzzzzl_, ezzzzzzzzzzzzzzzzzzzzzzm_);
        bool? ezzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(ezzzzzzzzzzzzzzzzzzzzzzk_, ezzzzzzzzzzzzzzzzzzzzzzn_);

        return ezzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Is Age 66 to 80 with Advanced Illness and Frailty or Is Age 81 or Older with Frailty")]
    public bool? Is_Age_66_to_80_with_Advanced_Illness_and_Frailty_or_Is_Age_81_or_Older_with_Frailty(CqlContext context)
    {
        Patient ezzzzzzzzzzzzzzzzzzzzzzp_ = this.Patient(context);
        Date ezzzzzzzzzzzzzzzzzzzzzzq_ = ezzzzzzzzzzzzzzzzzzzzzzp_?.BirthDateElement;
        string ezzzzzzzzzzzzzzzzzzzzzzr_ = ezzzzzzzzzzzzzzzzzzzzzzq_?.Value;
        CqlDate ezzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ConvertStringToDate(ezzzzzzzzzzzzzzzzzzzzzzr_);
        CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzt_ = this.Measurement_Period(context);
        CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.End(ezzzzzzzzzzzzzzzzzzzzzzt_);
        CqlDate ezzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.DateFrom(ezzzzzzzzzzzzzzzzzzzzzzu_);
        int? ezzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.CalculateAgeAt(ezzzzzzzzzzzzzzzzzzzzzzs_, ezzzzzzzzzzzzzzzzzzzzzzv_, "year");
        CqlInterval<int?> ezzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Interval(66, 80, true, true);
        bool? ezzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.In<int?>(ezzzzzzzzzzzzzzzzzzzzzzw_, ezzzzzzzzzzzzzzzzzzzzzzx_, default);
        bool? ezzzzzzzzzzzzzzzzzzzzzzz_ = this.Has_Criteria_Indicating_Frailty(context);
        bool? fzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(ezzzzzzzzzzzzzzzzzzzzzzy_, ezzzzzzzzzzzzzzzzzzzzzzz_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzb_ = this.Has_Advanced_Illness_in_Year_Before_or_During_Measurement_Period(context);
        bool? fzzzzzzzzzzzzzzzzzzzzzzc_ = this.Has_Dementia_Medications_in_Year_Before_or_During_Measurement_Period(context);
        bool? fzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Or(fzzzzzzzzzzzzzzzzzzzzzzb_, fzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? fzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzza_, fzzzzzzzzzzzzzzzzzzzzzzd_);
        Date fzzzzzzzzzzzzzzzzzzzzzzg_ = ezzzzzzzzzzzzzzzzzzzzzzp_?.BirthDateElement;
        string fzzzzzzzzzzzzzzzzzzzzzzh_ = fzzzzzzzzzzzzzzzzzzzzzzg_?.Value;
        CqlDate fzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.ConvertStringToDate(fzzzzzzzzzzzzzzzzzzzzzzh_);
        CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.End(ezzzzzzzzzzzzzzzzzzzzzzt_);
        CqlDate fzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.DateFrom(fzzzzzzzzzzzzzzzzzzzzzzk_);
        int? fzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.CalculateAgeAt(fzzzzzzzzzzzzzzzzzzzzzzi_, fzzzzzzzzzzzzzzzzzzzzzzl_, "year");
        bool? fzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.GreaterOrEqual(fzzzzzzzzzzzzzzzzzzzzzzm_, 81);
        bool? fzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzn_, ezzzzzzzzzzzzzzzzzzzzzzz_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Or(fzzzzzzzzzzzzzzzzzzzzzze_, fzzzzzzzzzzzzzzzzzzzzzzp_);

        return fzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Is Age 66 or Older Living Long Term in a Nursing Home")]
    public bool? Is_Age_66_or_Older_Living_Long_Term_in_a_Nursing_Home(CqlContext context)
    {
        Patient fzzzzzzzzzzzzzzzzzzzzzzr_ = this.Patient(context);
        Date fzzzzzzzzzzzzzzzzzzzzzzs_ = fzzzzzzzzzzzzzzzzzzzzzzr_?.BirthDateElement;
        string fzzzzzzzzzzzzzzzzzzzzzzt_ = fzzzzzzzzzzzzzzzzzzzzzzs_?.Value;
        CqlDate fzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.ConvertStringToDate(fzzzzzzzzzzzzzzzzzzzzzzt_);
        CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzv_ = this.Measurement_Period(context);
        CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.End(fzzzzzzzzzzzzzzzzzzzzzzv_);
        CqlDate fzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.DateFrom(fzzzzzzzzzzzzzzzzzzzzzzw_);
        int? fzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.CalculateAgeAt(fzzzzzzzzzzzzzzzzzzzzzzu_, fzzzzzzzzzzzzzzzzzzzzzzx_, "year");
        bool? fzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.GreaterOrEqual(fzzzzzzzzzzzzzzzzzzzzzzy_, 66);
        CqlCode gzzzzzzzzzzzzzzzzzzzzzza_ = this.Housing_status(context);
        IEnumerable<CqlCode> gzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.ToList<CqlCode>(gzzzzzzzzzzzzzzzzzzzzzza_);
        IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, gzzzzzzzzzzzzzzzzzzzzzzb_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzd_ = Status_1_8_000.Instance.isAssessmentPerformed(context, gzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? gzzzzzzzzzzzzzzzzzzzzzze_(Observation HousingStatus)
        {
            DataType gzzzzzzzzzzzzzzzzzzzzzzp_ = HousingStatus?.Effective;
            object gzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.End(gzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzt_ = this.Measurement_Period(context);
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.End(gzzzzzzzzzzzzzzzzzzzzzzt_);
            bool? gzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.SameOrBefore(gzzzzzzzzzzzzzzzzzzzzzzs_, gzzzzzzzzzzzzzzzzzzzzzzu_, "day");

            return gzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Observation>(gzzzzzzzzzzzzzzzzzzzzzzd_, gzzzzzzzzzzzzzzzzzzzzzze_);
        object gzzzzzzzzzzzzzzzzzzzzzzg_(Observation @this)
        {
            DataType gzzzzzzzzzzzzzzzzzzzzzzw_ = @this?.Effective;
            object gzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.End(gzzzzzzzzzzzzzzzzzzzzzzy_);

            return gzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.SortBy<Observation>(gzzzzzzzzzzzzzzzzzzzzzzf_, gzzzzzzzzzzzzzzzzzzzzzzg_, System.ComponentModel.ListSortDirection.Ascending);
        Observation gzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Last<Observation>(gzzzzzzzzzzzzzzzzzzzzzzh_);
        Observation[] gzzzzzzzzzzzzzzzzzzzzzzj_ = [
            gzzzzzzzzzzzzzzzzzzzzzzi_,
        ];
        bool? gzzzzzzzzzzzzzzzzzzzzzzk_(Observation LastHousingStatus)
        {
            DataType hzzzzzzzzzzzzzzzzzzzzzza_ = LastHousingStatus?.Value;
            object hzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzza_);
            CqlCode hzzzzzzzzzzzzzzzzzzzzzzc_ = this.Lives_in_a_nursing_home__finding_(context);
            CqlConcept hzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ConvertCodeToConcept(hzzzzzzzzzzzzzzzzzzzzzzc_);
            bool? hzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Equivalent(hzzzzzzzzzzzzzzzzzzzzzzb_ as CqlConcept, hzzzzzzzzzzzzzzzzzzzzzzd_);

            return hzzzzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Observation>((IEnumerable<Observation>)gzzzzzzzzzzzzzzzzzzzzzzj_, gzzzzzzzzzzzzzzzzzzzzzzk_);
        Observation gzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.SingletonFrom<Observation>(gzzzzzzzzzzzzzzzzzzzzzzl_);
        bool? gzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Not((bool?)(gzzzzzzzzzzzzzzzzzzzzzzm_ is null));
        bool? gzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzz_, gzzzzzzzzzzzzzzzzzzzzzzn_);

        return gzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    #endregion Expressions

}
