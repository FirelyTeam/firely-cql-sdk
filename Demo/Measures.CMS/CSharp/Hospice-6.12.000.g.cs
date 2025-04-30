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
        object pzzzzzzzh_ = context.ResolveParameter("Hospice-6.12.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)pzzzzzzzh_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> pzzzzzzzi_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient pzzzzzzzj_ = context.Operators.SingletonFrom<Patient>(pzzzzzzzi_);

        return pzzzzzzzj_;
    }


    [CqlExpressionDefinition("Has Hospice Services")]
    public bool? Has_Hospice_Services(CqlContext context)
    {
        CqlValueSet pzzzzzzzk_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> pzzzzzzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> pzzzzzzzm_ = Status_1_8_000.Instance.isEncounterPerformed(context, pzzzzzzzl_);
        bool? pzzzzzzzn_(Encounter InpatientEncounter)
        {
            Encounter.HospitalizationComponent qzzzzzzzz_ = InpatientEncounter?.Hospitalization;
            CodeableConcept rzzzzzzza_ = qzzzzzzzz_?.DischargeDisposition;
            CqlConcept rzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, rzzzzzzza_);
            CqlCode rzzzzzzzc_ = this.Discharge_to_home_for_hospice_care__procedure_(context);
            CqlConcept rzzzzzzzd_ = context.Operators.ConvertCodeToConcept(rzzzzzzzc_);
            bool? rzzzzzzze_ = context.Operators.Equivalent(rzzzzzzzb_, rzzzzzzzd_);
            CodeableConcept rzzzzzzzg_ = qzzzzzzzz_?.DischargeDisposition;
            CqlConcept rzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, rzzzzzzzg_);
            CqlCode rzzzzzzzi_ = this.Discharge_to_healthcare_facility_for_hospice_care__procedure_(context);
            CqlConcept rzzzzzzzj_ = context.Operators.ConvertCodeToConcept(rzzzzzzzi_);
            bool? rzzzzzzzk_ = context.Operators.Equivalent(rzzzzzzzh_, rzzzzzzzj_);
            bool? rzzzzzzzl_ = context.Operators.Or(rzzzzzzze_, rzzzzzzzk_);
            Period rzzzzzzzm_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> rzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzm_);
            CqlInterval<CqlDateTime> rzzzzzzzo_ = QICoreCommon_2_1_000.Instance.toInterval(context, rzzzzzzzn_ as object);
            CqlDateTime rzzzzzzzp_ = context.Operators.End(rzzzzzzzo_);
            CqlInterval<CqlDateTime> rzzzzzzzq_ = this.Measurement_Period(context);
            bool? rzzzzzzzr_ = context.Operators.In<CqlDateTime>(rzzzzzzzp_, rzzzzzzzq_, "day");
            bool? rzzzzzzzs_ = context.Operators.And(rzzzzzzzl_, rzzzzzzzr_);

            return rzzzzzzzs_;
        };
        IEnumerable<Encounter> pzzzzzzzo_ = context.Operators.Where<Encounter>(pzzzzzzzm_, pzzzzzzzn_);
        bool? pzzzzzzzp_ = context.Operators.Exists<Encounter>(pzzzzzzzo_);
        CqlValueSet pzzzzzzzq_ = this.Hospice_Encounter(context);
        IEnumerable<Encounter> pzzzzzzzr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> pzzzzzzzs_ = Status_1_8_000.Instance.isEncounterPerformed(context, pzzzzzzzr_);
        bool? pzzzzzzzt_(Encounter HospiceEncounter)
        {
            Period rzzzzzzzt_ = HospiceEncounter?.Period;
            CqlInterval<CqlDateTime> rzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzt_);
            CqlInterval<CqlDateTime> rzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, rzzzzzzzu_ as object);
            CqlInterval<CqlDateTime> rzzzzzzzw_ = this.Measurement_Period(context);
            bool? rzzzzzzzx_ = context.Operators.Overlaps(rzzzzzzzv_, rzzzzzzzw_, "day");

            return rzzzzzzzx_;
        };
        IEnumerable<Encounter> pzzzzzzzu_ = context.Operators.Where<Encounter>(pzzzzzzzs_, pzzzzzzzt_);
        bool? pzzzzzzzv_ = context.Operators.Exists<Encounter>(pzzzzzzzu_);
        bool? pzzzzzzzw_ = context.Operators.Or(pzzzzzzzp_, pzzzzzzzv_);
        CqlCode pzzzzzzzx_ = this.Hospice_care__Minimum_Data_Set_(context);
        IEnumerable<CqlCode> pzzzzzzzy_ = context.Operators.ToList<CqlCode>(pzzzzzzzx_);
        IEnumerable<Observation> pzzzzzzzz_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, pzzzzzzzy_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> qzzzzzzza_ = Status_1_8_000.Instance.isAssessmentPerformed(context, pzzzzzzzz_);
        bool? qzzzzzzzb_(Observation HospiceAssessment)
        {
            DataType rzzzzzzzy_ = HospiceAssessment?.Value;
            object rzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzy_);
            CqlCode szzzzzzza_ = this.Yes__qualifier_value_(context);
            CqlConcept szzzzzzzb_ = context.Operators.ConvertCodeToConcept(szzzzzzza_);
            bool? szzzzzzzc_ = context.Operators.Equivalent(rzzzzzzzz_ as CqlConcept, szzzzzzzb_);
            DataType szzzzzzzd_ = HospiceAssessment?.Effective;
            object szzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzd_);
            CqlInterval<CqlDateTime> szzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, szzzzzzze_);
            CqlInterval<CqlDateTime> szzzzzzzg_ = this.Measurement_Period(context);
            bool? szzzzzzzh_ = context.Operators.Overlaps(szzzzzzzf_, szzzzzzzg_, "day");
            bool? szzzzzzzi_ = context.Operators.And(szzzzzzzc_, szzzzzzzh_);

            return szzzzzzzi_;
        };
        IEnumerable<Observation> qzzzzzzzc_ = context.Operators.Where<Observation>(qzzzzzzza_, qzzzzzzzb_);
        bool? qzzzzzzzd_ = context.Operators.Exists<Observation>(qzzzzzzzc_);
        bool? qzzzzzzze_ = context.Operators.Or(pzzzzzzzw_, qzzzzzzzd_);
        CqlValueSet qzzzzzzzf_ = this.Hospice_Care_Ambulatory(context);
        IEnumerable<ServiceRequest> qzzzzzzzg_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, qzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> qzzzzzzzh_ = Status_1_8_000.Instance.isInterventionOrder(context, qzzzzzzzg_);
        bool? qzzzzzzzi_(ServiceRequest HospiceOrder)
        {
            CqlInterval<CqlDateTime> szzzzzzzj_ = this.Measurement_Period(context);
            FhirDateTime szzzzzzzk_ = HospiceOrder?.AuthoredOnElement;
            CqlDateTime szzzzzzzl_ = context.Operators.Convert<CqlDateTime>(szzzzzzzk_);
            CqlInterval<CqlDateTime> szzzzzzzm_ = QICoreCommon_2_1_000.Instance.toInterval(context, szzzzzzzl_ as object);
            bool? szzzzzzzn_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(szzzzzzzj_, szzzzzzzm_, "day");

            return szzzzzzzn_;
        };
        IEnumerable<ServiceRequest> qzzzzzzzj_ = context.Operators.Where<ServiceRequest>(qzzzzzzzh_, qzzzzzzzi_);
        bool? qzzzzzzzk_ = context.Operators.Exists<ServiceRequest>(qzzzzzzzj_);
        bool? qzzzzzzzl_ = context.Operators.Or(qzzzzzzze_, qzzzzzzzk_);
        IEnumerable<Procedure> qzzzzzzzn_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, qzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> qzzzzzzzo_ = Status_1_8_000.Instance.isInterventionPerformed(context, qzzzzzzzn_);
        bool? qzzzzzzzp_(Procedure HospicePerformed)
        {
            DataType szzzzzzzo_ = HospicePerformed?.Performed;
            object szzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzo_);
            CqlInterval<CqlDateTime> szzzzzzzq_ = QICoreCommon_2_1_000.Instance.toInterval(context, szzzzzzzp_);
            CqlInterval<CqlDateTime> szzzzzzzr_ = this.Measurement_Period(context);
            bool? szzzzzzzs_ = context.Operators.Overlaps(szzzzzzzq_, szzzzzzzr_, "day");

            return szzzzzzzs_;
        };
        IEnumerable<Procedure> qzzzzzzzq_ = context.Operators.Where<Procedure>(qzzzzzzzo_, qzzzzzzzp_);
        bool? qzzzzzzzr_ = context.Operators.Exists<Procedure>(qzzzzzzzq_);
        bool? qzzzzzzzs_ = context.Operators.Or(qzzzzzzzl_, qzzzzzzzr_);
        CqlValueSet qzzzzzzzt_ = this.Hospice_Diagnosis(context);
        IEnumerable<Condition> qzzzzzzzu_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, qzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? qzzzzzzzv_(Condition HospiceCareDiagnosis)
        {
            CqlInterval<CqlDateTime> szzzzzzzt_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HospiceCareDiagnosis);
            CqlInterval<CqlDateTime> szzzzzzzu_ = this.Measurement_Period(context);
            bool? szzzzzzzv_ = context.Operators.Overlaps(szzzzzzzt_, szzzzzzzu_, "day");

            return szzzzzzzv_;
        };
        IEnumerable<Condition> qzzzzzzzw_ = context.Operators.Where<Condition>(qzzzzzzzu_, qzzzzzzzv_);
        bool? qzzzzzzzx_ = context.Operators.Exists<Condition>(qzzzzzzzw_);
        bool? qzzzzzzzy_ = context.Operators.Or(qzzzzzzzs_, qzzzzzzzx_);

        return qzzzzzzzy_;
    }


    #endregion Expressions

}
