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
        object tzzt_ = context.ResolveParameter("Hospice-6.12.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)tzzt_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> tzzu_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient tzzv_ = context.Operators.SingletonFrom<Patient>(tzzu_);

        return tzzv_;
    }


    [CqlExpressionDefinition("Has Hospice Services")]
    public bool? Has_Hospice_Services(CqlContext context)
    {
        CqlValueSet tzzw_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> tzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, tzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> tzzy_ = Status_1_8_000.Instance.isEncounterPerformed(context, tzzx_);
        bool? tzzz_(Encounter InpatientEncounter)
        {
            Encounter.HospitalizationComponent vzzl_ = InpatientEncounter?.Hospitalization;
            CodeableConcept vzzm_ = vzzl_?.DischargeDisposition;
            CqlConcept vzzn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, vzzm_);
            CqlCode vzzo_ = this.Discharge_to_home_for_hospice_care__procedure_(context);
            CqlConcept vzzp_ = context.Operators.ConvertCodeToConcept(vzzo_);
            bool? vzzq_ = context.Operators.Equivalent(vzzn_, vzzp_);
            CodeableConcept vzzs_ = vzzl_?.DischargeDisposition;
            CqlConcept vzzt_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, vzzs_);
            CqlCode vzzu_ = this.Discharge_to_healthcare_facility_for_hospice_care__procedure_(context);
            CqlConcept vzzv_ = context.Operators.ConvertCodeToConcept(vzzu_);
            bool? vzzw_ = context.Operators.Equivalent(vzzt_, vzzv_);
            bool? vzzx_ = context.Operators.Or(vzzq_, vzzw_);
            Period vzzy_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> vzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzy_);
            CqlInterval<CqlDateTime> wzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, vzzz_ as object);
            CqlDateTime wzzb_ = context.Operators.End(wzza_);
            CqlInterval<CqlDateTime> wzzc_ = this.Measurement_Period(context);
            bool? wzzd_ = context.Operators.In<CqlDateTime>(wzzb_, wzzc_, "day");
            bool? wzze_ = context.Operators.And(vzzx_, wzzd_);

            return wzze_;
        };
        IEnumerable<Encounter> uzza_ = context.Operators.Where<Encounter>(tzzy_, tzzz_);
        bool? uzzb_ = context.Operators.Exists<Encounter>(uzza_);
        CqlValueSet uzzc_ = this.Hospice_Encounter(context);
        IEnumerable<Encounter> uzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, uzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> uzze_ = Status_1_8_000.Instance.isEncounterPerformed(context, uzzd_);
        bool? uzzf_(Encounter HospiceEncounter)
        {
            Period wzzf_ = HospiceEncounter?.Period;
            CqlInterval<CqlDateTime> wzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzf_);
            CqlInterval<CqlDateTime> wzzh_ = QICoreCommon_2_1_000.Instance.toInterval(context, wzzg_ as object);
            CqlInterval<CqlDateTime> wzzi_ = this.Measurement_Period(context);
            bool? wzzj_ = context.Operators.Overlaps(wzzh_, wzzi_, "day");

            return wzzj_;
        };
        IEnumerable<Encounter> uzzg_ = context.Operators.Where<Encounter>(uzze_, uzzf_);
        bool? uzzh_ = context.Operators.Exists<Encounter>(uzzg_);
        bool? uzzi_ = context.Operators.Or(uzzb_, uzzh_);
        CqlCode uzzj_ = this.Hospice_care__Minimum_Data_Set_(context);
        IEnumerable<CqlCode> uzzk_ = context.Operators.ToList<CqlCode>(uzzj_);
        IEnumerable<Observation> uzzl_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, uzzk_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> uzzm_ = Status_1_8_000.Instance.isAssessmentPerformed(context, uzzl_);
        bool? uzzn_(Observation HospiceAssessment)
        {
            DataType wzzk_ = HospiceAssessment?.Value;
            object wzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzk_);
            CqlCode wzzm_ = this.Yes__qualifier_value_(context);
            CqlConcept wzzn_ = context.Operators.ConvertCodeToConcept(wzzm_);
            bool? wzzo_ = context.Operators.Equivalent(wzzl_ as CqlConcept, wzzn_);
            DataType wzzp_ = HospiceAssessment?.Effective;
            object wzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzp_);
            CqlInterval<CqlDateTime> wzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, wzzq_);
            CqlInterval<CqlDateTime> wzzs_ = this.Measurement_Period(context);
            bool? wzzt_ = context.Operators.Overlaps(wzzr_, wzzs_, "day");
            bool? wzzu_ = context.Operators.And(wzzo_, wzzt_);

            return wzzu_;
        };
        IEnumerable<Observation> uzzo_ = context.Operators.Where<Observation>(uzzm_, uzzn_);
        bool? uzzp_ = context.Operators.Exists<Observation>(uzzo_);
        bool? uzzq_ = context.Operators.Or(uzzi_, uzzp_);
        CqlValueSet uzzr_ = this.Hospice_Care_Ambulatory(context);
        IEnumerable<ServiceRequest> uzzs_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, uzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> uzzt_ = Status_1_8_000.Instance.isInterventionOrder(context, uzzs_);
        bool? uzzu_(ServiceRequest HospiceOrder)
        {
            CqlInterval<CqlDateTime> wzzv_ = this.Measurement_Period(context);
            FhirDateTime wzzw_ = HospiceOrder?.AuthoredOnElement;
            CqlDateTime wzzx_ = context.Operators.Convert<CqlDateTime>(wzzw_);
            CqlInterval<CqlDateTime> wzzy_ = QICoreCommon_2_1_000.Instance.toInterval(context, wzzx_ as object);
            bool? wzzz_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(wzzv_, wzzy_, "day");

            return wzzz_;
        };
        IEnumerable<ServiceRequest> uzzv_ = context.Operators.Where<ServiceRequest>(uzzt_, uzzu_);
        bool? uzzw_ = context.Operators.Exists<ServiceRequest>(uzzv_);
        bool? uzzx_ = context.Operators.Or(uzzq_, uzzw_);
        IEnumerable<Procedure> uzzz_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, uzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> vzza_ = Status_1_8_000.Instance.isInterventionPerformed(context, uzzz_);
        bool? vzzb_(Procedure HospicePerformed)
        {
            DataType xzza_ = HospicePerformed?.Performed;
            object xzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzza_);
            CqlInterval<CqlDateTime> xzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzb_);
            CqlInterval<CqlDateTime> xzzd_ = this.Measurement_Period(context);
            bool? xzze_ = context.Operators.Overlaps(xzzc_, xzzd_, "day");

            return xzze_;
        };
        IEnumerable<Procedure> vzzc_ = context.Operators.Where<Procedure>(vzza_, vzzb_);
        bool? vzzd_ = context.Operators.Exists<Procedure>(vzzc_);
        bool? vzze_ = context.Operators.Or(uzzx_, vzzd_);
        CqlValueSet vzzf_ = this.Hospice_Diagnosis(context);
        IEnumerable<Condition> vzzg_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, vzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? vzzh_(Condition HospiceCareDiagnosis)
        {
            CqlInterval<CqlDateTime> xzzf_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HospiceCareDiagnosis);
            CqlInterval<CqlDateTime> xzzg_ = this.Measurement_Period(context);
            bool? xzzh_ = context.Operators.Overlaps(xzzf_, xzzg_, "day");

            return xzzh_;
        };
        IEnumerable<Condition> vzzi_ = context.Operators.Where<Condition>(vzzg_, vzzh_);
        bool? vzzj_ = context.Operators.Exists<Condition>(vzzi_);
        bool? vzzk_ = context.Operators.Or(vzze_, vzzj_);

        return vzzk_;
    }


    #endregion Expressions

}
