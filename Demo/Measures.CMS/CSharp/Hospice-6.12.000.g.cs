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

    #region ValueSet: Encounter Inpatient
    [CqlValueSetDefinition(
        definitionName: "Encounter Inpatient",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307",
        valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext context) => _Encounter_Inpatient;

    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);
    #endregion

    #region ValueSet: Hospice Care Ambulatory
    [CqlValueSetDefinition(
        definitionName: "Hospice Care Ambulatory",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1584",
        valueSetVersion: null)]
    public CqlValueSet Hospice_Care_Ambulatory(CqlContext context) => _Hospice_Care_Ambulatory;

    private static readonly CqlValueSet _Hospice_Care_Ambulatory = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1584", null);
    #endregion

    #region ValueSet: Hospice Encounter
    [CqlValueSetDefinition(
        definitionName: "Hospice Encounter",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1003",
        valueSetVersion: null)]
    public CqlValueSet Hospice_Encounter(CqlContext context) => _Hospice_Encounter;

    private static readonly CqlValueSet _Hospice_Encounter = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1003", null);
    #endregion

    #region ValueSet: Hospice Diagnosis
    [CqlValueSetDefinition(
        definitionName: "Hospice Diagnosis",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1165",
        valueSetVersion: null)]
    public CqlValueSet Hospice_Diagnosis(CqlContext context) => _Hospice_Diagnosis;

    private static readonly CqlValueSet _Hospice_Diagnosis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1165", null);
    #endregion

    #endregion ValueSets

    #region Codes

    #region Code: Discharge to healthcare facility for hospice care (procedure)
    [CqlCodeDefinition(
        definitionName: "Discharge to healthcare facility for hospice care (procedure)",
        codeId: "428371000124100",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Discharge_to_healthcare_facility_for_hospice_care__procedure_(CqlContext context) => _Discharge_to_healthcare_facility_for_hospice_care__procedure_;

    private static readonly CqlCode _Discharge_to_healthcare_facility_for_hospice_care__procedure_ = new CqlCode("428371000124100", "http://snomed.info/sct", default, default);
    #endregion

    #region Code: Discharge to home for hospice care (procedure)
    [CqlCodeDefinition(
        definitionName: "Discharge to home for hospice care (procedure)",
        codeId: "428361000124107",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Discharge_to_home_for_hospice_care__procedure_(CqlContext context) => _Discharge_to_home_for_hospice_care__procedure_;

    private static readonly CqlCode _Discharge_to_home_for_hospice_care__procedure_ = new CqlCode("428361000124107", "http://snomed.info/sct", default, default);
    #endregion

    #region Code: Hospice care [Minimum Data Set]
    [CqlCodeDefinition(
        definitionName: "Hospice care [Minimum Data Set]",
        codeId: "45755-6",
        codeSystem: "http://loinc.org")]
    public CqlCode Hospice_care__Minimum_Data_Set_(CqlContext context) => _Hospice_care__Minimum_Data_Set_;

    private static readonly CqlCode _Hospice_care__Minimum_Data_Set_ = new CqlCode("45755-6", "http://loinc.org", default, default);
    #endregion

    #region Code: Yes (qualifier value)
    [CqlCodeDefinition(
        definitionName: "Yes (qualifier value)",
        codeId: "373066001",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Yes__qualifier_value_(CqlContext context) => _Yes__qualifier_value_;

    private static readonly CqlCode _Yes__qualifier_value_ = new CqlCode("373066001", "http://snomed.info/sct", default, default);
    #endregion

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition(
        definitionName: "LOINC")]
    public CqlCode[] LOINC(CqlContext context)
    {
        CqlCode[] czzzzzzzzzz_ = [
            new CqlCode("45755-6", "http://loinc.org", default, default),
        ];

        return czzzzzzzzzz_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "SNOMEDCT")]
    public CqlCode[] SNOMEDCT(CqlContext context)
    {
        CqlCode[] dzzzzzzzzza_ = [
            new CqlCode("428371000124100", "http://snomed.info/sct", default, default),
            new CqlCode("428361000124107", "http://snomed.info/sct", default, default),
            new CqlCode("373066001", "http://snomed.info/sct", default, default),
        ];

        return dzzzzzzzzza_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object dzzzzzzzzzb_ = context.ResolveParameter("Hospice-6.12.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)dzzzzzzzzzb_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> dzzzzzzzzzc_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient dzzzzzzzzzd_ = context.Operators.SingletonFrom<Patient>(dzzzzzzzzzc_);

        return dzzzzzzzzzd_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Hospice Services")]
    public bool? Has_Hospice_Services(CqlContext context)
    {
        CqlValueSet dzzzzzzzzze_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> dzzzzzzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> dzzzzzzzzzg_ = Status_1_8_000.Instance.isEncounterPerformed(context, dzzzzzzzzzf_);
        bool? dzzzzzzzzzh_(Encounter InpatientEncounter)
        {
            Encounter.HospitalizationComponent ezzzzzzzzzt_ = InpatientEncounter?.Hospitalization;
            CodeableConcept ezzzzzzzzzu_ = ezzzzzzzzzt_?.DischargeDisposition;
            CqlConcept ezzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ezzzzzzzzzu_);
            CqlCode ezzzzzzzzzw_ = this.Discharge_to_home_for_hospice_care__procedure_(context);
            CqlConcept ezzzzzzzzzx_ = context.Operators.ConvertCodeToConcept(ezzzzzzzzzw_);
            bool? ezzzzzzzzzy_ = context.Operators.Equivalent(ezzzzzzzzzv_, ezzzzzzzzzx_);
            CodeableConcept fzzzzzzzzza_ = ezzzzzzzzzt_?.DischargeDisposition;
            CqlConcept fzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, fzzzzzzzzza_);
            CqlCode fzzzzzzzzzc_ = this.Discharge_to_healthcare_facility_for_hospice_care__procedure_(context);
            CqlConcept fzzzzzzzzzd_ = context.Operators.ConvertCodeToConcept(fzzzzzzzzzc_);
            bool? fzzzzzzzzze_ = context.Operators.Equivalent(fzzzzzzzzzb_, fzzzzzzzzzd_);
            bool? fzzzzzzzzzf_ = context.Operators.Or(ezzzzzzzzzy_, fzzzzzzzzze_);
            Period fzzzzzzzzzg_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> fzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzg_);
            CqlInterval<CqlDateTime> fzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.toInterval(context, fzzzzzzzzzh_ as object);
            CqlDateTime fzzzzzzzzzj_ = context.Operators.End(fzzzzzzzzzi_);
            CqlInterval<CqlDateTime> fzzzzzzzzzk_ = this.Measurement_Period(context);
            bool? fzzzzzzzzzl_ = context.Operators.In<CqlDateTime>(fzzzzzzzzzj_, fzzzzzzzzzk_, "day");
            bool? fzzzzzzzzzm_ = context.Operators.And(fzzzzzzzzzf_, fzzzzzzzzzl_);

            return fzzzzzzzzzm_;
        };
        IEnumerable<Encounter> dzzzzzzzzzi_ = context.Operators.Where<Encounter>(dzzzzzzzzzg_, dzzzzzzzzzh_);
        bool? dzzzzzzzzzj_ = context.Operators.Exists<Encounter>(dzzzzzzzzzi_);
        CqlValueSet dzzzzzzzzzk_ = this.Hospice_Encounter(context);
        IEnumerable<Encounter> dzzzzzzzzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> dzzzzzzzzzm_ = Status_1_8_000.Instance.isEncounterPerformed(context, dzzzzzzzzzl_);
        bool? dzzzzzzzzzn_(Encounter HospiceEncounter)
        {
            Period fzzzzzzzzzn_ = HospiceEncounter?.Period;
            CqlInterval<CqlDateTime> fzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzn_);
            CqlInterval<CqlDateTime> fzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, fzzzzzzzzzo_ as object);
            CqlInterval<CqlDateTime> fzzzzzzzzzq_ = this.Measurement_Period(context);
            bool? fzzzzzzzzzr_ = context.Operators.Overlaps(fzzzzzzzzzp_, fzzzzzzzzzq_, "day");

            return fzzzzzzzzzr_;
        };
        IEnumerable<Encounter> dzzzzzzzzzo_ = context.Operators.Where<Encounter>(dzzzzzzzzzm_, dzzzzzzzzzn_);
        bool? dzzzzzzzzzp_ = context.Operators.Exists<Encounter>(dzzzzzzzzzo_);
        bool? dzzzzzzzzzq_ = context.Operators.Or(dzzzzzzzzzj_, dzzzzzzzzzp_);
        CqlCode dzzzzzzzzzr_ = this.Hospice_care__Minimum_Data_Set_(context);
        IEnumerable<CqlCode> dzzzzzzzzzs_ = context.Operators.ToList<CqlCode>(dzzzzzzzzzr_);
        IEnumerable<Observation> dzzzzzzzzzt_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, dzzzzzzzzzs_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> dzzzzzzzzzu_ = Status_1_8_000.Instance.isAssessmentPerformed(context, dzzzzzzzzzt_);
        bool? dzzzzzzzzzv_(Observation HospiceAssessment)
        {
            DataType fzzzzzzzzzs_ = HospiceAssessment?.Value;
            object fzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzs_);
            CqlCode fzzzzzzzzzu_ = this.Yes__qualifier_value_(context);
            CqlConcept fzzzzzzzzzv_ = context.Operators.ConvertCodeToConcept(fzzzzzzzzzu_);
            bool? fzzzzzzzzzw_ = context.Operators.Equivalent(fzzzzzzzzzt_ as CqlConcept, fzzzzzzzzzv_);
            DataType fzzzzzzzzzx_ = HospiceAssessment?.Effective;
            object fzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzx_);
            CqlInterval<CqlDateTime> fzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, fzzzzzzzzzy_);
            CqlInterval<CqlDateTime> gzzzzzzzzza_ = this.Measurement_Period(context);
            bool? gzzzzzzzzzb_ = context.Operators.Overlaps(fzzzzzzzzzz_, gzzzzzzzzza_, "day");
            bool? gzzzzzzzzzc_ = context.Operators.And(fzzzzzzzzzw_, gzzzzzzzzzb_);

            return gzzzzzzzzzc_;
        };
        IEnumerable<Observation> dzzzzzzzzzw_ = context.Operators.Where<Observation>(dzzzzzzzzzu_, dzzzzzzzzzv_);
        bool? dzzzzzzzzzx_ = context.Operators.Exists<Observation>(dzzzzzzzzzw_);
        bool? dzzzzzzzzzy_ = context.Operators.Or(dzzzzzzzzzq_, dzzzzzzzzzx_);
        CqlValueSet dzzzzzzzzzz_ = this.Hospice_Care_Ambulatory(context);
        IEnumerable<ServiceRequest> ezzzzzzzzza_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, dzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> ezzzzzzzzzb_ = Status_1_8_000.Instance.isInterventionOrder(context, ezzzzzzzzza_);
        bool? ezzzzzzzzzc_(ServiceRequest HospiceOrder)
        {
            CqlInterval<CqlDateTime> gzzzzzzzzzd_ = this.Measurement_Period(context);
            FhirDateTime gzzzzzzzzze_ = HospiceOrder?.AuthoredOnElement;
            CqlDateTime gzzzzzzzzzf_ = context.Operators.Convert<CqlDateTime>(gzzzzzzzzze_);
            CqlInterval<CqlDateTime> gzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzf_ as object);
            bool? gzzzzzzzzzh_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(gzzzzzzzzzd_, gzzzzzzzzzg_, "day");

            return gzzzzzzzzzh_;
        };
        IEnumerable<ServiceRequest> ezzzzzzzzzd_ = context.Operators.Where<ServiceRequest>(ezzzzzzzzzb_, ezzzzzzzzzc_);
        bool? ezzzzzzzzze_ = context.Operators.Exists<ServiceRequest>(ezzzzzzzzzd_);
        bool? ezzzzzzzzzf_ = context.Operators.Or(dzzzzzzzzzy_, ezzzzzzzzze_);
        IEnumerable<Procedure> ezzzzzzzzzh_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, dzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> ezzzzzzzzzi_ = Status_1_8_000.Instance.isInterventionPerformed(context, ezzzzzzzzzh_);
        bool? ezzzzzzzzzj_(Procedure HospicePerformed)
        {
            DataType gzzzzzzzzzi_ = HospicePerformed?.Performed;
            object gzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzi_);
            CqlInterval<CqlDateTime> gzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzj_);
            CqlInterval<CqlDateTime> gzzzzzzzzzl_ = this.Measurement_Period(context);
            bool? gzzzzzzzzzm_ = context.Operators.Overlaps(gzzzzzzzzzk_, gzzzzzzzzzl_, "day");

            return gzzzzzzzzzm_;
        };
        IEnumerable<Procedure> ezzzzzzzzzk_ = context.Operators.Where<Procedure>(ezzzzzzzzzi_, ezzzzzzzzzj_);
        bool? ezzzzzzzzzl_ = context.Operators.Exists<Procedure>(ezzzzzzzzzk_);
        bool? ezzzzzzzzzm_ = context.Operators.Or(ezzzzzzzzzf_, ezzzzzzzzzl_);
        CqlValueSet ezzzzzzzzzn_ = this.Hospice_Diagnosis(context);
        IEnumerable<Condition> ezzzzzzzzzo_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ezzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? ezzzzzzzzzp_(Condition HospiceCareDiagnosis)
        {
            CqlInterval<CqlDateTime> gzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HospiceCareDiagnosis);
            CqlInterval<CqlDateTime> gzzzzzzzzzo_ = this.Measurement_Period(context);
            bool? gzzzzzzzzzp_ = context.Operators.Overlaps(gzzzzzzzzzn_, gzzzzzzzzzo_, "day");

            return gzzzzzzzzzp_;
        };
        IEnumerable<Condition> ezzzzzzzzzq_ = context.Operators.Where<Condition>(ezzzzzzzzzo_, ezzzzzzzzzp_);
        bool? ezzzzzzzzzr_ = context.Operators.Exists<Condition>(ezzzzzzzzzq_);
        bool? ezzzzzzzzzs_ = context.Operators.Or(ezzzzzzzzzm_, ezzzzzzzzzr_);

        return ezzzzzzzzzs_;
    }


    #endregion Expressions

}
