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
        object yzzy_ = context.ResolveParameter("Hospice-6.12.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)yzzy_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> yzzz_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient zzza_ = context.Operators.SingletonFrom<Patient>(yzzz_);

        return zzza_;
    }


    [CqlExpressionDefinition("Has Hospice Services")]
    public bool? Has_Hospice_Services(CqlContext context)
    {
        CqlValueSet zzzb_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> zzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> zzzd_ = Status_1_8_000.Instance.isEncounterPerformed(context, zzzc_);
        bool? zzze_(Encounter InpatientEncounter)
        {
            Encounter.HospitalizationComponent azzzq_ = InpatientEncounter?.Hospitalization;
            CodeableConcept azzzr_ = azzzq_?.DischargeDisposition;
            CqlConcept azzzs_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, azzzr_);
            CqlCode azzzt_ = this.Discharge_to_home_for_hospice_care__procedure_(context);
            CqlConcept azzzu_ = context.Operators.ConvertCodeToConcept(azzzt_);
            bool? azzzv_ = context.Operators.Equivalent(azzzs_, azzzu_);
            CodeableConcept azzzx_ = azzzq_?.DischargeDisposition;
            CqlConcept azzzy_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, azzzx_);
            CqlCode azzzz_ = this.Discharge_to_healthcare_facility_for_hospice_care__procedure_(context);
            CqlConcept bzzza_ = context.Operators.ConvertCodeToConcept(azzzz_);
            bool? bzzzb_ = context.Operators.Equivalent(azzzy_, bzzza_);
            bool? bzzzc_ = context.Operators.Or(azzzv_, bzzzb_);
            Period bzzzd_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> bzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzd_);
            CqlInterval<CqlDateTime> bzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzze_ as object);
            CqlDateTime bzzzg_ = context.Operators.End(bzzzf_);
            CqlInterval<CqlDateTime> bzzzh_ = this.Measurement_Period(context);
            bool? bzzzi_ = context.Operators.In<CqlDateTime>(bzzzg_, bzzzh_, "day");
            bool? bzzzj_ = context.Operators.And(bzzzc_, bzzzi_);

            return bzzzj_;
        };
        IEnumerable<Encounter> zzzf_ = context.Operators.Where<Encounter>(zzzd_, zzze_);
        bool? zzzg_ = context.Operators.Exists<Encounter>(zzzf_);
        CqlValueSet zzzh_ = this.Hospice_Encounter(context);
        IEnumerable<Encounter> zzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> zzzj_ = Status_1_8_000.Instance.isEncounterPerformed(context, zzzi_);
        bool? zzzk_(Encounter HospiceEncounter)
        {
            Period bzzzk_ = HospiceEncounter?.Period;
            CqlInterval<CqlDateTime> bzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzk_);
            CqlInterval<CqlDateTime> bzzzm_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzl_ as object);
            CqlInterval<CqlDateTime> bzzzn_ = this.Measurement_Period(context);
            bool? bzzzo_ = context.Operators.Overlaps(bzzzm_, bzzzn_, "day");

            return bzzzo_;
        };
        IEnumerable<Encounter> zzzl_ = context.Operators.Where<Encounter>(zzzj_, zzzk_);
        bool? zzzm_ = context.Operators.Exists<Encounter>(zzzl_);
        bool? zzzn_ = context.Operators.Or(zzzg_, zzzm_);
        CqlCode zzzo_ = this.Hospice_care__Minimum_Data_Set_(context);
        IEnumerable<CqlCode> zzzp_ = context.Operators.ToList<CqlCode>(zzzo_);
        IEnumerable<Observation> zzzq_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, zzzp_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> zzzr_ = Status_1_8_000.Instance.isAssessmentPerformed(context, zzzq_);
        bool? zzzs_(Observation HospiceAssessment)
        {
            DataType bzzzp_ = HospiceAssessment?.Value;
            object bzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzp_);
            CqlCode bzzzr_ = this.Yes__qualifier_value_(context);
            CqlConcept bzzzs_ = context.Operators.ConvertCodeToConcept(bzzzr_);
            bool? bzzzt_ = context.Operators.Equivalent(bzzzq_ as CqlConcept, bzzzs_);
            DataType bzzzu_ = HospiceAssessment?.Effective;
            object bzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzu_);
            CqlInterval<CqlDateTime> bzzzw_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzv_);
            CqlInterval<CqlDateTime> bzzzx_ = this.Measurement_Period(context);
            bool? bzzzy_ = context.Operators.Overlaps(bzzzw_, bzzzx_, "day");
            bool? bzzzz_ = context.Operators.And(bzzzt_, bzzzy_);

            return bzzzz_;
        };
        IEnumerable<Observation> zzzt_ = context.Operators.Where<Observation>(zzzr_, zzzs_);
        bool? zzzu_ = context.Operators.Exists<Observation>(zzzt_);
        bool? zzzv_ = context.Operators.Or(zzzn_, zzzu_);
        CqlValueSet zzzw_ = this.Hospice_Care_Ambulatory(context);
        IEnumerable<ServiceRequest> zzzx_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, zzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> zzzy_ = Status_1_8_000.Instance.isInterventionOrder(context, zzzx_);
        bool? zzzz_(ServiceRequest HospiceOrder)
        {
            CqlInterval<CqlDateTime> czzza_ = this.Measurement_Period(context);
            FhirDateTime czzzb_ = HospiceOrder?.AuthoredOnElement;
            CqlDateTime czzzc_ = context.Operators.Convert<CqlDateTime>(czzzb_);
            CqlInterval<CqlDateTime> czzzd_ = QICoreCommon_2_1_000.Instance.toInterval(context, czzzc_ as object);
            bool? czzze_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(czzza_, czzzd_, "day");

            return czzze_;
        };
        IEnumerable<ServiceRequest> azzza_ = context.Operators.Where<ServiceRequest>(zzzy_, zzzz_);
        bool? azzzb_ = context.Operators.Exists<ServiceRequest>(azzza_);
        bool? azzzc_ = context.Operators.Or(zzzv_, azzzb_);
        IEnumerable<Procedure> azzze_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, zzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> azzzf_ = Status_1_8_000.Instance.isInterventionPerformed(context, azzze_);
        bool? azzzg_(Procedure HospicePerformed)
        {
            DataType czzzf_ = HospicePerformed?.Performed;
            object czzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzf_);
            CqlInterval<CqlDateTime> czzzh_ = QICoreCommon_2_1_000.Instance.toInterval(context, czzzg_);
            CqlInterval<CqlDateTime> czzzi_ = this.Measurement_Period(context);
            bool? czzzj_ = context.Operators.Overlaps(czzzh_, czzzi_, "day");

            return czzzj_;
        };
        IEnumerable<Procedure> azzzh_ = context.Operators.Where<Procedure>(azzzf_, azzzg_);
        bool? azzzi_ = context.Operators.Exists<Procedure>(azzzh_);
        bool? azzzj_ = context.Operators.Or(azzzc_, azzzi_);
        CqlValueSet azzzk_ = this.Hospice_Diagnosis(context);
        IEnumerable<Condition> azzzl_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, azzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? azzzm_(Condition HospiceCareDiagnosis)
        {
            CqlInterval<CqlDateTime> czzzk_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HospiceCareDiagnosis);
            CqlInterval<CqlDateTime> czzzl_ = this.Measurement_Period(context);
            bool? czzzm_ = context.Operators.Overlaps(czzzk_, czzzl_, "day");

            return czzzm_;
        };
        IEnumerable<Condition> azzzn_ = context.Operators.Where<Condition>(azzzl_, azzzm_);
        bool? azzzo_ = context.Operators.Exists<Condition>(azzzn_);
        bool? azzzp_ = context.Operators.Or(azzzj_, azzzo_);

        return azzzp_;
    }


    #endregion Expressions

}
