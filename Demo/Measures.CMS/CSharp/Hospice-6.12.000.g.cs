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
    private static readonly CqlCode _Discharge_to_healthcare_facility_for_hospice_care__procedure_ = new CqlCode("428371000124100", "http://snomed.info/sct");

    [CqlCodeDefinition("Discharge to home for hospice care (procedure)", codeId: "428361000124107", codeSystem: "http://snomed.info/sct")]
    public CqlCode Discharge_to_home_for_hospice_care__procedure_(CqlContext _) => _Discharge_to_home_for_hospice_care__procedure_;
    private static readonly CqlCode _Discharge_to_home_for_hospice_care__procedure_ = new CqlCode("428361000124107", "http://snomed.info/sct");

    [CqlCodeDefinition("Hospice care [Minimum Data Set]", codeId: "45755-6", codeSystem: "http://loinc.org")]
    public CqlCode Hospice_care__Minimum_Data_Set_(CqlContext _) => _Hospice_care__Minimum_Data_Set_;
    private static readonly CqlCode _Hospice_care__Minimum_Data_Set_ = new CqlCode("45755-6", "http://loinc.org");

    [CqlCodeDefinition("Yes (qualifier value)", codeId: "373066001", codeSystem: "http://snomed.info/sct")]
    public CqlCode Yes__qualifier_value_(CqlContext _) => _Yes__qualifier_value_;
    private static readonly CqlCode _Yes__qualifier_value_ = new CqlCode("373066001", "http://snomed.info/sct");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC")]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null,
          _Hospice_care__Minimum_Data_Set_);

    [CqlCodeSystemDefinition("SNOMEDCT")]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null,
          _Discharge_to_healthcare_facility_for_hospice_care__procedure_,
          _Discharge_to_home_for_hospice_care__procedure_,
          _Yes__qualifier_value_);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object szzzzzzzzzj_ = context.ResolveParameter("Hospice-6.12.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)szzzzzzzzzj_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> szzzzzzzzzk_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient szzzzzzzzzl_ = context.Operators.SingletonFrom<Patient>(szzzzzzzzzk_);

        return szzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Has Hospice Services")]
    public bool? Has_Hospice_Services(CqlContext context)
    {
        CqlValueSet szzzzzzzzzm_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> szzzzzzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, szzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> szzzzzzzzzo_ = Status_1_8_000.Instance.isEncounterPerformed(context, szzzzzzzzzn_);
        bool? szzzzzzzzzp_(Encounter InpatientEncounter)
        {
            Encounter.HospitalizationComponent uzzzzzzzzzb_ = InpatientEncounter?.Hospitalization;
            CodeableConcept uzzzzzzzzzc_ = uzzzzzzzzzb_?.DischargeDisposition;
            CqlConcept uzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, uzzzzzzzzzc_);
            CqlCode uzzzzzzzzze_ = this.Discharge_to_home_for_hospice_care__procedure_(context);
            CqlConcept uzzzzzzzzzf_ = context.Operators.ConvertCodeToConcept(uzzzzzzzzze_);
            bool? uzzzzzzzzzg_ = context.Operators.Equivalent(uzzzzzzzzzd_, uzzzzzzzzzf_);
            CodeableConcept uzzzzzzzzzi_ = uzzzzzzzzzb_?.DischargeDisposition;
            CqlConcept uzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, uzzzzzzzzzi_);
            CqlCode uzzzzzzzzzk_ = this.Discharge_to_healthcare_facility_for_hospice_care__procedure_(context);
            CqlConcept uzzzzzzzzzl_ = context.Operators.ConvertCodeToConcept(uzzzzzzzzzk_);
            bool? uzzzzzzzzzm_ = context.Operators.Equivalent(uzzzzzzzzzj_, uzzzzzzzzzl_);
            bool? uzzzzzzzzzn_ = context.Operators.Or(uzzzzzzzzzg_, uzzzzzzzzzm_);
            Period uzzzzzzzzzo_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> uzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzo_);
            CqlInterval<CqlDateTime> uzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.toInterval(context, uzzzzzzzzzp_ as object);
            CqlDateTime uzzzzzzzzzr_ = context.Operators.End(uzzzzzzzzzq_);
            CqlInterval<CqlDateTime> uzzzzzzzzzs_ = this.Measurement_Period(context);
            bool? uzzzzzzzzzt_ = context.Operators.In<CqlDateTime>(uzzzzzzzzzr_, uzzzzzzzzzs_, "day");
            bool? uzzzzzzzzzu_ = context.Operators.And(uzzzzzzzzzn_, uzzzzzzzzzt_);

            return uzzzzzzzzzu_;
        };
        IEnumerable<Encounter> szzzzzzzzzq_ = context.Operators.Where<Encounter>(szzzzzzzzzo_, szzzzzzzzzp_);
        bool? szzzzzzzzzr_ = context.Operators.Exists<Encounter>(szzzzzzzzzq_);
        CqlValueSet szzzzzzzzzs_ = this.Hospice_Encounter(context);
        IEnumerable<Encounter> szzzzzzzzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, szzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> szzzzzzzzzu_ = Status_1_8_000.Instance.isEncounterPerformed(context, szzzzzzzzzt_);
        bool? szzzzzzzzzv_(Encounter HospiceEncounter)
        {
            Period uzzzzzzzzzv_ = HospiceEncounter?.Period;
            CqlInterval<CqlDateTime> uzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzv_);
            CqlInterval<CqlDateTime> uzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.toInterval(context, uzzzzzzzzzw_ as object);
            CqlInterval<CqlDateTime> uzzzzzzzzzy_ = this.Measurement_Period(context);
            bool? uzzzzzzzzzz_ = context.Operators.Overlaps(uzzzzzzzzzx_, uzzzzzzzzzy_, "day");

            return uzzzzzzzzzz_;
        };
        IEnumerable<Encounter> szzzzzzzzzw_ = context.Operators.Where<Encounter>(szzzzzzzzzu_, szzzzzzzzzv_);
        bool? szzzzzzzzzx_ = context.Operators.Exists<Encounter>(szzzzzzzzzw_);
        bool? szzzzzzzzzy_ = context.Operators.Or(szzzzzzzzzr_, szzzzzzzzzx_);
        CqlCode szzzzzzzzzz_ = this.Hospice_care__Minimum_Data_Set_(context);
        IEnumerable<CqlCode> tzzzzzzzzza_ = context.Operators.ToList<CqlCode>(szzzzzzzzzz_);
        IEnumerable<Observation> tzzzzzzzzzb_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, tzzzzzzzzza_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> tzzzzzzzzzc_ = Status_1_8_000.Instance.isAssessmentPerformed(context, tzzzzzzzzzb_);
        bool? tzzzzzzzzzd_(Observation HospiceAssessment)
        {
            DataType vzzzzzzzzza_ = HospiceAssessment?.Value;
            object vzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzza_);
            CqlCode vzzzzzzzzzc_ = this.Yes__qualifier_value_(context);
            CqlConcept vzzzzzzzzzd_ = context.Operators.ConvertCodeToConcept(vzzzzzzzzzc_);
            bool? vzzzzzzzzze_ = context.Operators.Equivalent(vzzzzzzzzzb_ as CqlConcept, vzzzzzzzzzd_);
            DataType vzzzzzzzzzf_ = HospiceAssessment?.Effective;
            object vzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzf_);
            CqlInterval<CqlDateTime> vzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.toInterval(context, vzzzzzzzzzg_);
            CqlInterval<CqlDateTime> vzzzzzzzzzi_ = this.Measurement_Period(context);
            bool? vzzzzzzzzzj_ = context.Operators.Overlaps(vzzzzzzzzzh_, vzzzzzzzzzi_, "day");
            bool? vzzzzzzzzzk_ = context.Operators.And(vzzzzzzzzze_, vzzzzzzzzzj_);

            return vzzzzzzzzzk_;
        };
        IEnumerable<Observation> tzzzzzzzzze_ = context.Operators.Where<Observation>(tzzzzzzzzzc_, tzzzzzzzzzd_);
        bool? tzzzzzzzzzf_ = context.Operators.Exists<Observation>(tzzzzzzzzze_);
        bool? tzzzzzzzzzg_ = context.Operators.Or(szzzzzzzzzy_, tzzzzzzzzzf_);
        CqlValueSet tzzzzzzzzzh_ = this.Hospice_Care_Ambulatory(context);
        IEnumerable<ServiceRequest> tzzzzzzzzzi_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, tzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> tzzzzzzzzzj_ = Status_1_8_000.Instance.isInterventionOrder(context, tzzzzzzzzzi_);
        bool? tzzzzzzzzzk_(ServiceRequest HospiceOrder)
        {
            CqlInterval<CqlDateTime> vzzzzzzzzzl_ = this.Measurement_Period(context);
            FhirDateTime vzzzzzzzzzm_ = HospiceOrder?.AuthoredOnElement;
            CqlDateTime vzzzzzzzzzn_ = context.Operators.Convert<CqlDateTime>(vzzzzzzzzzm_);
            CqlInterval<CqlDateTime> vzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.toInterval(context, vzzzzzzzzzn_ as object);
            bool? vzzzzzzzzzp_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(vzzzzzzzzzl_, vzzzzzzzzzo_, "day");

            return vzzzzzzzzzp_;
        };
        IEnumerable<ServiceRequest> tzzzzzzzzzl_ = context.Operators.Where<ServiceRequest>(tzzzzzzzzzj_, tzzzzzzzzzk_);
        bool? tzzzzzzzzzm_ = context.Operators.Exists<ServiceRequest>(tzzzzzzzzzl_);
        bool? tzzzzzzzzzn_ = context.Operators.Or(tzzzzzzzzzg_, tzzzzzzzzzm_);
        IEnumerable<Procedure> tzzzzzzzzzp_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, tzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> tzzzzzzzzzq_ = Status_1_8_000.Instance.isInterventionPerformed(context, tzzzzzzzzzp_);
        bool? tzzzzzzzzzr_(Procedure HospicePerformed)
        {
            DataType vzzzzzzzzzq_ = HospicePerformed?.Performed;
            object vzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzq_);
            CqlInterval<CqlDateTime> vzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.toInterval(context, vzzzzzzzzzr_);
            CqlInterval<CqlDateTime> vzzzzzzzzzt_ = this.Measurement_Period(context);
            bool? vzzzzzzzzzu_ = context.Operators.Overlaps(vzzzzzzzzzs_, vzzzzzzzzzt_, "day");

            return vzzzzzzzzzu_;
        };
        IEnumerable<Procedure> tzzzzzzzzzs_ = context.Operators.Where<Procedure>(tzzzzzzzzzq_, tzzzzzzzzzr_);
        bool? tzzzzzzzzzt_ = context.Operators.Exists<Procedure>(tzzzzzzzzzs_);
        bool? tzzzzzzzzzu_ = context.Operators.Or(tzzzzzzzzzn_, tzzzzzzzzzt_);
        CqlValueSet tzzzzzzzzzv_ = this.Hospice_Diagnosis(context);
        IEnumerable<Condition> tzzzzzzzzzw_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, tzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? tzzzzzzzzzx_(Condition HospiceCareDiagnosis)
        {
            CqlInterval<CqlDateTime> vzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HospiceCareDiagnosis);
            CqlInterval<CqlDateTime> vzzzzzzzzzw_ = this.Measurement_Period(context);
            bool? vzzzzzzzzzx_ = context.Operators.Overlaps(vzzzzzzzzzv_, vzzzzzzzzzw_, "day");

            return vzzzzzzzzzx_;
        };
        IEnumerable<Condition> tzzzzzzzzzy_ = context.Operators.Where<Condition>(tzzzzzzzzzw_, tzzzzzzzzzx_);
        bool? tzzzzzzzzzz_ = context.Operators.Exists<Condition>(tzzzzzzzzzy_);
        bool? uzzzzzzzzza_ = context.Operators.Or(tzzzzzzzzzu_, tzzzzzzzzzz_);

        return uzzzzzzzzza_;
    }


    #endregion Expressions

}
