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
      new CqlCodeSystem("http://loinc.org", null, [
          _Hospice_care__Minimum_Data_Set_]);

    [CqlCodeSystemDefinition("SNOMEDCT")]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Discharge_to_healthcare_facility_for_hospice_care__procedure_,
          _Discharge_to_home_for_hospice_care__procedure_,
          _Yes__qualifier_value_]);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object yzzv_ = context.ResolveParameter("Hospice-6.12.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)yzzv_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> yzzw_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient yzzx_ = context.Operators.SingletonFrom<Patient>(yzzw_);

        return yzzx_;
    }


    [CqlExpressionDefinition("Has Hospice Services")]
    public bool? Has_Hospice_Services(CqlContext context)
    {
        CqlValueSet yzzy_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> yzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> zzza_ = Status_1_8_000.Instance.isEncounterPerformed(context, yzzz_);
        bool? zzzb_(Encounter InpatientEncounter)
        {
            Encounter.HospitalizationComponent azzzn_ = InpatientEncounter?.Hospitalization;
            CodeableConcept azzzo_ = azzzn_?.DischargeDisposition;
            CqlConcept azzzp_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, azzzo_);
            CqlCode azzzq_ = this.Discharge_to_home_for_hospice_care__procedure_(context);
            CqlConcept azzzr_ = context.Operators.ConvertCodeToConcept(azzzq_);
            bool? azzzs_ = context.Operators.Equivalent(azzzp_, azzzr_);
            CodeableConcept azzzu_ = azzzn_?.DischargeDisposition;
            CqlConcept azzzv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, azzzu_);
            CqlCode azzzw_ = this.Discharge_to_healthcare_facility_for_hospice_care__procedure_(context);
            CqlConcept azzzx_ = context.Operators.ConvertCodeToConcept(azzzw_);
            bool? azzzy_ = context.Operators.Equivalent(azzzv_, azzzx_);
            bool? azzzz_ = context.Operators.Or(azzzs_, azzzy_);
            Period bzzza_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> bzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzza_);
            CqlInterval<CqlDateTime> bzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzb_ as object);
            CqlDateTime bzzzd_ = context.Operators.End(bzzzc_);
            CqlInterval<CqlDateTime> bzzze_ = this.Measurement_Period(context);
            bool? bzzzf_ = context.Operators.In<CqlDateTime>(bzzzd_, bzzze_, "day");
            bool? bzzzg_ = context.Operators.And(azzzz_, bzzzf_);

            return bzzzg_;
        };
        IEnumerable<Encounter> zzzc_ = context.Operators.Where<Encounter>(zzza_, zzzb_);
        bool? zzzd_ = context.Operators.Exists<Encounter>(zzzc_);
        CqlValueSet zzze_ = this.Hospice_Encounter(context);
        IEnumerable<Encounter> zzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> zzzg_ = Status_1_8_000.Instance.isEncounterPerformed(context, zzzf_);
        bool? zzzh_(Encounter HospiceEncounter)
        {
            Period bzzzh_ = HospiceEncounter?.Period;
            CqlInterval<CqlDateTime> bzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzh_);
            CqlInterval<CqlDateTime> bzzzj_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzi_ as object);
            CqlInterval<CqlDateTime> bzzzk_ = this.Measurement_Period(context);
            bool? bzzzl_ = context.Operators.Overlaps(bzzzj_, bzzzk_, "day");

            return bzzzl_;
        };
        IEnumerable<Encounter> zzzi_ = context.Operators.Where<Encounter>(zzzg_, zzzh_);
        bool? zzzj_ = context.Operators.Exists<Encounter>(zzzi_);
        bool? zzzk_ = context.Operators.Or(zzzd_, zzzj_);
        CqlCode zzzl_ = this.Hospice_care__Minimum_Data_Set_(context);
        IEnumerable<CqlCode> zzzm_ = context.Operators.ToList<CqlCode>(zzzl_);
        IEnumerable<Observation> zzzn_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, zzzm_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> zzzo_ = Status_1_8_000.Instance.isAssessmentPerformed(context, zzzn_);
        bool? zzzp_(Observation HospiceAssessment)
        {
            DataType bzzzm_ = HospiceAssessment?.Value;
            object bzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzm_);
            CqlCode bzzzo_ = this.Yes__qualifier_value_(context);
            CqlConcept bzzzp_ = context.Operators.ConvertCodeToConcept(bzzzo_);
            bool? bzzzq_ = context.Operators.Equivalent(bzzzn_ as CqlConcept, bzzzp_);
            DataType bzzzr_ = HospiceAssessment?.Effective;
            object bzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzr_);
            CqlInterval<CqlDateTime> bzzzt_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzs_);
            CqlInterval<CqlDateTime> bzzzu_ = this.Measurement_Period(context);
            bool? bzzzv_ = context.Operators.Overlaps(bzzzt_, bzzzu_, "day");
            bool? bzzzw_ = context.Operators.And(bzzzq_, bzzzv_);

            return bzzzw_;
        };
        IEnumerable<Observation> zzzq_ = context.Operators.Where<Observation>(zzzo_, zzzp_);
        bool? zzzr_ = context.Operators.Exists<Observation>(zzzq_);
        bool? zzzs_ = context.Operators.Or(zzzk_, zzzr_);
        CqlValueSet zzzt_ = this.Hospice_Care_Ambulatory(context);
        IEnumerable<ServiceRequest> zzzu_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, zzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> zzzv_ = Status_1_8_000.Instance.isInterventionOrder(context, zzzu_);
        bool? zzzw_(ServiceRequest HospiceOrder)
        {
            CqlInterval<CqlDateTime> bzzzx_ = this.Measurement_Period(context);
            FhirDateTime bzzzy_ = HospiceOrder?.AuthoredOnElement;
            CqlDateTime bzzzz_ = context.Operators.Convert<CqlDateTime>(bzzzy_);
            CqlInterval<CqlDateTime> czzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzz_ as object);
            bool? czzzb_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(bzzzx_, czzza_, "day");

            return czzzb_;
        };
        IEnumerable<ServiceRequest> zzzx_ = context.Operators.Where<ServiceRequest>(zzzv_, zzzw_);
        bool? zzzy_ = context.Operators.Exists<ServiceRequest>(zzzx_);
        bool? zzzz_ = context.Operators.Or(zzzs_, zzzy_);
        IEnumerable<Procedure> azzzb_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, zzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> azzzc_ = Status_1_8_000.Instance.isInterventionPerformed(context, azzzb_);
        bool? azzzd_(Procedure HospicePerformed)
        {
            DataType czzzc_ = HospicePerformed?.Performed;
            object czzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzc_);
            CqlInterval<CqlDateTime> czzze_ = QICoreCommon_2_1_000.Instance.toInterval(context, czzzd_);
            CqlInterval<CqlDateTime> czzzf_ = this.Measurement_Period(context);
            bool? czzzg_ = context.Operators.Overlaps(czzze_, czzzf_, "day");

            return czzzg_;
        };
        IEnumerable<Procedure> azzze_ = context.Operators.Where<Procedure>(azzzc_, azzzd_);
        bool? azzzf_ = context.Operators.Exists<Procedure>(azzze_);
        bool? azzzg_ = context.Operators.Or(zzzz_, azzzf_);
        CqlValueSet azzzh_ = this.Hospice_Diagnosis(context);
        IEnumerable<Condition> azzzi_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, azzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? azzzj_(Condition HospiceCareDiagnosis)
        {
            CqlInterval<CqlDateTime> czzzh_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HospiceCareDiagnosis);
            CqlInterval<CqlDateTime> czzzi_ = this.Measurement_Period(context);
            bool? czzzj_ = context.Operators.Overlaps(czzzh_, czzzi_, "day");

            return czzzj_;
        };
        IEnumerable<Condition> azzzk_ = context.Operators.Where<Condition>(azzzi_, azzzj_);
        bool? azzzl_ = context.Operators.Exists<Condition>(azzzk_);
        bool? azzzm_ = context.Operators.Or(azzzg_, azzzl_);

        return azzzm_;
    }


    #endregion Expressions

}
