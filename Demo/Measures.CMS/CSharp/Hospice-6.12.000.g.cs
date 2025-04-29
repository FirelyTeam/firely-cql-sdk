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
[CqlLibrary("Hospice", "6.12.000")]
public partial class Hospice_6_12_000 : ILibrary, ISingleton<Hospice_6_12_000>
{
    private Hospice_6_12_000() {}

    public static Hospice_6_12_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "Hospice";
    public string Version => "6.12.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, QICoreCommon_2_1_000.Instance, Status_1_8_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Encounter Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext _) => _Encounter_Inpatient;
    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlValueSetDefinition("Hospice Care Ambulatory", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1584", valueSetVersion: null)]
    public CqlValueSet Hospice_Care_Ambulatory(CqlContext _) => _Hospice_Care_Ambulatory;
    private static readonly CqlValueSet _Hospice_Care_Ambulatory = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1584", null);

    [CqlValueSetDefinition("Hospice Encounter", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1003", valueSetVersion: null)]
    public CqlValueSet Hospice_Encounter(CqlContext _) => _Hospice_Encounter;
    private static readonly CqlValueSet _Hospice_Encounter = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1003", null);

    [CqlValueSetDefinition("Hospice Diagnosis", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1165", valueSetVersion: null)]
    public CqlValueSet Hospice_Diagnosis(CqlContext _) => _Hospice_Diagnosis;
    private static readonly CqlValueSet _Hospice_Diagnosis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1165", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Discharge to healthcare facility for hospice care (procedure)", codeId: "428371000124100", codeSystem: "http://snomed.info/sct")]
    public CqlCode Discharge_to_healthcare_facility_for_hospice_care__procedure_(CqlContext _) => _Discharge_to_healthcare_facility_for_hospice_care__procedure_;
    private static readonly CqlCode _Discharge_to_healthcare_facility_for_hospice_care__procedure_ = new CqlCode("428371000124100", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("Discharge to home for hospice care (procedure)", codeId: "428361000124107", codeSystem: "http://snomed.info/sct")]
    public CqlCode Discharge_to_home_for_hospice_care__procedure_(CqlContext _) => _Discharge_to_home_for_hospice_care__procedure_;
    private static readonly CqlCode _Discharge_to_home_for_hospice_care__procedure_ = new CqlCode("428361000124107", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("Hospice care [Minimum Data Set]", codeId: "45755-6", codeSystem: "http://loinc.org")]
    public CqlCode Hospice_care__Minimum_Data_Set_(CqlContext _) => _Hospice_care__Minimum_Data_Set_;
    private static readonly CqlCode _Hospice_care__Minimum_Data_Set_ = new CqlCode("45755-6", "http://loinc.org", default, default);

    [CqlCodeDefinition("Yes (qualifier value)", codeId: "373066001", codeSystem: "http://snomed.info/sct")]
    public CqlCode Yes__qualifier_value_(CqlContext _) => _Yes__qualifier_value_;
    private static readonly CqlCode _Yes__qualifier_value_ = new CqlCode("373066001", "http://snomed.info/sct", default, default);

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
        object izzzzzzzzn_ = context.ResolveParameter("Hospice-6.12.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)izzzzzzzzn_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> izzzzzzzzo_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient izzzzzzzzp_ = context.Operators.SingletonFrom<Patient>(izzzzzzzzo_);

        return izzzzzzzzp_;
    }


    [CqlExpressionDefinition("Has Hospice Services")]
    public bool? Has_Hospice_Services(CqlContext context)
    {
        CqlValueSet izzzzzzzzq_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> izzzzzzzzr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> izzzzzzzzs_ = Status_1_8_000.Instance.isEncounterPerformed(context, izzzzzzzzr_);
        bool? izzzzzzzzt_(Encounter InpatientEncounter)
        {
            Encounter.HospitalizationComponent kzzzzzzzzf_ = InpatientEncounter?.Hospitalization;
            CodeableConcept kzzzzzzzzg_ = kzzzzzzzzf_?.DischargeDisposition;
            CqlConcept kzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, kzzzzzzzzg_);
            CqlCode kzzzzzzzzi_ = this.Discharge_to_home_for_hospice_care__procedure_(context);
            CqlConcept kzzzzzzzzj_ = context.Operators.ConvertCodeToConcept(kzzzzzzzzi_);
            bool? kzzzzzzzzk_ = context.Operators.Equivalent(kzzzzzzzzh_, kzzzzzzzzj_);
            CodeableConcept kzzzzzzzzm_ = kzzzzzzzzf_?.DischargeDisposition;
            CqlConcept kzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, kzzzzzzzzm_);
            CqlCode kzzzzzzzzo_ = this.Discharge_to_healthcare_facility_for_hospice_care__procedure_(context);
            CqlConcept kzzzzzzzzp_ = context.Operators.ConvertCodeToConcept(kzzzzzzzzo_);
            bool? kzzzzzzzzq_ = context.Operators.Equivalent(kzzzzzzzzn_, kzzzzzzzzp_);
            bool? kzzzzzzzzr_ = context.Operators.Or(kzzzzzzzzk_, kzzzzzzzzq_);
            Period kzzzzzzzzs_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> kzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzs_);
            CqlInterval<CqlDateTime> kzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzt_ as object);
            CqlDateTime kzzzzzzzzv_ = context.Operators.End(kzzzzzzzzu_);
            CqlInterval<CqlDateTime> kzzzzzzzzw_ = this.Measurement_Period(context);
            bool? kzzzzzzzzx_ = context.Operators.In<CqlDateTime>(kzzzzzzzzv_, kzzzzzzzzw_, "day");
            bool? kzzzzzzzzy_ = context.Operators.And(kzzzzzzzzr_, kzzzzzzzzx_);

            return kzzzzzzzzy_;
        };
        IEnumerable<Encounter> izzzzzzzzu_ = context.Operators.Where<Encounter>(izzzzzzzzs_, izzzzzzzzt_);
        bool? izzzzzzzzv_ = context.Operators.Exists<Encounter>(izzzzzzzzu_);
        CqlValueSet izzzzzzzzw_ = this.Hospice_Encounter(context);
        IEnumerable<Encounter> izzzzzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> izzzzzzzzy_ = Status_1_8_000.Instance.isEncounterPerformed(context, izzzzzzzzx_);
        bool? izzzzzzzzz_(Encounter HospiceEncounter)
        {
            Period kzzzzzzzzz_ = HospiceEncounter?.Period;
            CqlInterval<CqlDateTime> lzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kzzzzzzzzz_);
            CqlInterval<CqlDateTime> lzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, lzzzzzzzza_ as object);
            CqlInterval<CqlDateTime> lzzzzzzzzc_ = this.Measurement_Period(context);
            bool? lzzzzzzzzd_ = context.Operators.Overlaps(lzzzzzzzzb_, lzzzzzzzzc_, "day");

            return lzzzzzzzzd_;
        };
        IEnumerable<Encounter> jzzzzzzzza_ = context.Operators.Where<Encounter>(izzzzzzzzy_, izzzzzzzzz_);
        bool? jzzzzzzzzb_ = context.Operators.Exists<Encounter>(jzzzzzzzza_);
        bool? jzzzzzzzzc_ = context.Operators.Or(izzzzzzzzv_, jzzzzzzzzb_);
        CqlCode jzzzzzzzzd_ = this.Hospice_care__Minimum_Data_Set_(context);
        IEnumerable<CqlCode> jzzzzzzzze_ = context.Operators.ToList<CqlCode>(jzzzzzzzzd_);
        IEnumerable<Observation> jzzzzzzzzf_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, jzzzzzzzze_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> jzzzzzzzzg_ = Status_1_8_000.Instance.isAssessmentPerformed(context, jzzzzzzzzf_);
        bool? jzzzzzzzzh_(Observation HospiceAssessment)
        {
            DataType lzzzzzzzze_ = HospiceAssessment?.Value;
            object lzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzze_);
            CqlCode lzzzzzzzzg_ = this.Yes__qualifier_value_(context);
            CqlConcept lzzzzzzzzh_ = context.Operators.ConvertCodeToConcept(lzzzzzzzzg_);
            bool? lzzzzzzzzi_ = context.Operators.Equivalent(lzzzzzzzzf_ as CqlConcept, lzzzzzzzzh_);
            DataType lzzzzzzzzj_ = HospiceAssessment?.Effective;
            object lzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzj_);
            CqlInterval<CqlDateTime> lzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, lzzzzzzzzk_);
            CqlInterval<CqlDateTime> lzzzzzzzzm_ = this.Measurement_Period(context);
            bool? lzzzzzzzzn_ = context.Operators.Overlaps(lzzzzzzzzl_, lzzzzzzzzm_, "day");
            bool? lzzzzzzzzo_ = context.Operators.And(lzzzzzzzzi_, lzzzzzzzzn_);

            return lzzzzzzzzo_;
        };
        IEnumerable<Observation> jzzzzzzzzi_ = context.Operators.Where<Observation>(jzzzzzzzzg_, jzzzzzzzzh_);
        bool? jzzzzzzzzj_ = context.Operators.Exists<Observation>(jzzzzzzzzi_);
        bool? jzzzzzzzzk_ = context.Operators.Or(jzzzzzzzzc_, jzzzzzzzzj_);
        CqlValueSet jzzzzzzzzl_ = this.Hospice_Care_Ambulatory(context);
        IEnumerable<ServiceRequest> jzzzzzzzzm_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, jzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> jzzzzzzzzn_ = Status_1_8_000.Instance.isInterventionOrder(context, jzzzzzzzzm_);
        bool? jzzzzzzzzo_(ServiceRequest HospiceOrder)
        {
            CqlInterval<CqlDateTime> lzzzzzzzzp_ = this.Measurement_Period(context);
            FhirDateTime lzzzzzzzzq_ = HospiceOrder?.AuthoredOnElement;
            CqlDateTime lzzzzzzzzr_ = context.Operators.Convert<CqlDateTime>(lzzzzzzzzq_);
            CqlInterval<CqlDateTime> lzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.toInterval(context, lzzzzzzzzr_ as object);
            bool? lzzzzzzzzt_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(lzzzzzzzzp_, lzzzzzzzzs_, "day");

            return lzzzzzzzzt_;
        };
        IEnumerable<ServiceRequest> jzzzzzzzzp_ = context.Operators.Where<ServiceRequest>(jzzzzzzzzn_, jzzzzzzzzo_);
        bool? jzzzzzzzzq_ = context.Operators.Exists<ServiceRequest>(jzzzzzzzzp_);
        bool? jzzzzzzzzr_ = context.Operators.Or(jzzzzzzzzk_, jzzzzzzzzq_);
        IEnumerable<Procedure> jzzzzzzzzt_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, jzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> jzzzzzzzzu_ = Status_1_8_000.Instance.isInterventionPerformed(context, jzzzzzzzzt_);
        bool? jzzzzzzzzv_(Procedure HospicePerformed)
        {
            DataType lzzzzzzzzu_ = HospicePerformed?.Performed;
            object lzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzu_);
            CqlInterval<CqlDateTime> lzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.toInterval(context, lzzzzzzzzv_);
            CqlInterval<CqlDateTime> lzzzzzzzzx_ = this.Measurement_Period(context);
            bool? lzzzzzzzzy_ = context.Operators.Overlaps(lzzzzzzzzw_, lzzzzzzzzx_, "day");

            return lzzzzzzzzy_;
        };
        IEnumerable<Procedure> jzzzzzzzzw_ = context.Operators.Where<Procedure>(jzzzzzzzzu_, jzzzzzzzzv_);
        bool? jzzzzzzzzx_ = context.Operators.Exists<Procedure>(jzzzzzzzzw_);
        bool? jzzzzzzzzy_ = context.Operators.Or(jzzzzzzzzr_, jzzzzzzzzx_);
        CqlValueSet jzzzzzzzzz_ = this.Hospice_Diagnosis(context);
        IEnumerable<Condition> kzzzzzzzza_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, jzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? kzzzzzzzzb_(Condition HospiceCareDiagnosis)
        {
            CqlInterval<CqlDateTime> lzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HospiceCareDiagnosis);
            CqlInterval<CqlDateTime> mzzzzzzzza_ = this.Measurement_Period(context);
            bool? mzzzzzzzzb_ = context.Operators.Overlaps(lzzzzzzzzz_, mzzzzzzzza_, "day");

            return mzzzzzzzzb_;
        };
        IEnumerable<Condition> kzzzzzzzzc_ = context.Operators.Where<Condition>(kzzzzzzzza_, kzzzzzzzzb_);
        bool? kzzzzzzzzd_ = context.Operators.Exists<Condition>(kzzzzzzzzc_);
        bool? kzzzzzzzze_ = context.Operators.Or(jzzzzzzzzy_, kzzzzzzzzd_);

        return kzzzzzzzze_;
    }


    #endregion Expressions

}
