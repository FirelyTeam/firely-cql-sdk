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
[CqlLibrary("HospiceFHIR4", "2.3.000")]
public partial class HospiceFHIR4_2_3_000 : ILibrary, ISingleton<HospiceFHIR4_2_3_000>
{
    private HospiceFHIR4_2_3_000() {}

    public static HospiceFHIR4_2_3_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "HospiceFHIR4";
    public string Version => "2.3.000";
    public ILibrary[] Dependencies => [MATGlobalCommonFunctionsFHIR4_6_1_000.Instance, FHIRHelpers_4_0_001.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Encounter Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext _) => _Encounter_Inpatient;
    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlValueSetDefinition("Hospice care ambulatory", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15", valueSetVersion: null)]
    public CqlValueSet Hospice_care_ambulatory(CqlContext _) => _Hospice_care_ambulatory;
    private static readonly CqlValueSet _Hospice_care_ambulatory = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Discharge to healthcare facility for hospice care (procedure)", codeId: "428371000124100", codeSystem: "http://snomed.info/sct")]
    public CqlCode Discharge_to_healthcare_facility_for_hospice_care__procedure_(CqlContext _) => _Discharge_to_healthcare_facility_for_hospice_care__procedure_;
    private static readonly CqlCode _Discharge_to_healthcare_facility_for_hospice_care__procedure_ = new CqlCode("428371000124100", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("Discharge to home for hospice care (procedure)", codeId: "428361000124107", codeSystem: "http://snomed.info/sct")]
    public CqlCode Discharge_to_home_for_hospice_care__procedure_(CqlContext _) => _Discharge_to_home_for_hospice_care__procedure_;
    private static readonly CqlCode _Discharge_to_home_for_hospice_care__procedure_ = new CqlCode("428361000124107", "http://snomed.info/sct", default, default);

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("SNOMEDCT:2017-09")]
    public CqlCodeSystem SNOMEDCT_2017_09(CqlContext _) => _SNOMEDCT_2017_09;
    private static readonly CqlCodeSystem _SNOMEDCT_2017_09 = new CqlCodeSystem();

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object zzo_ = context.ResolveParameter("HospiceFHIR4-2.3.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)zzo_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> zzp_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient zzq_ = context.Operators.SingletonFrom<Patient>(zzp_);

        return zzq_;
    }


    [CqlExpressionDefinition("Has Hospice")]
    public bool? Has_Hospice(CqlContext context)
    {
        CqlValueSet zzr_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> zzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzr_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        bool? zzt_(Encounter DischargeHospice)
        {
            Code<Encounter.EncounterStatus> azzi_ = DischargeHospice?.StatusElement;
            string azzj_ = FHIRHelpers_4_0_001.Instance.ToString(context, azzi_);
            bool? azzk_ = context.Operators.Equal(azzj_, "finished");
            Encounter.HospitalizationComponent azzl_ = DischargeHospice?.Hospitalization;
            CodeableConcept azzm_ = azzl_?.DischargeDisposition;
            CqlConcept azzn_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, azzm_);
            CqlCode azzo_ = this.Discharge_to_home_for_hospice_care__procedure_(context);
            CqlConcept azzp_ = context.Operators.ConvertCodeToConcept(azzo_);
            bool? azzq_ = context.Operators.Equivalent(azzn_, azzp_);
            CodeableConcept azzs_ = azzl_?.DischargeDisposition;
            CqlConcept azzt_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, azzs_);
            CqlCode azzu_ = this.Discharge_to_healthcare_facility_for_hospice_care__procedure_(context);
            CqlConcept azzv_ = context.Operators.ConvertCodeToConcept(azzu_);
            bool? azzw_ = context.Operators.Equivalent(azzt_, azzv_);
            bool? azzx_ = context.Operators.Or(azzq_, azzw_);
            bool? azzy_ = context.Operators.And(azzk_, azzx_);
            Period azzz_ = DischargeHospice?.Period;
            CqlInterval<CqlDateTime> bzza_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, azzz_ as object);
            CqlDateTime bzzb_ = context.Operators.End(bzza_);
            CqlInterval<CqlDateTime> bzzc_ = this.Measurement_Period(context);
            bool? bzzd_ = context.Operators.In<CqlDateTime>(bzzb_, bzzc_, default);
            bool? bzze_ = context.Operators.And(azzy_, bzzd_);

            return bzze_;
        };
        IEnumerable<Encounter> zzu_ = context.Operators.Where<Encounter>(zzs_, zzt_);
        bool? zzv_ = context.Operators.Exists<Encounter>(zzu_);
        CqlValueSet zzw_ = this.Hospice_care_ambulatory(context);
        IEnumerable<ServiceRequest> zzx_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, zzw_, default, "http://hl7.org/fhir/StructureDefinition/ServiceRequest"));
        bool? zzy_(ServiceRequest HospiceOrder)
        {
            Code<RequestStatus> bzzf_ = HospiceOrder?.StatusElement;
            string bzzg_ = FHIRHelpers_4_0_001.Instance.ToString(context, bzzf_);
            string[] bzzh_ = [
                "active",
                "completed",
            ];
            bool? bzzi_ = context.Operators.In<string>(bzzg_, bzzh_ as IEnumerable<string>);
            Code<RequestIntent> bzzj_ = HospiceOrder?.IntentElement;
            string bzzk_ = FHIRHelpers_4_0_001.Instance.ToString(context, bzzj_);
            bool? bzzl_ = context.Operators.Equal(bzzk_, "order");
            bool? bzzm_ = context.Operators.And(bzzi_, bzzl_);
            CqlInterval<CqlDateTime> bzzn_ = this.Measurement_Period(context);
            FhirDateTime bzzo_ = HospiceOrder?.AuthoredOnElement;
            CqlInterval<CqlDateTime> bzzp_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, bzzo_ as object);
            bool? bzzq_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(bzzn_, bzzp_, default);
            bool? bzzr_ = context.Operators.And(bzzm_, bzzq_);

            return bzzr_;
        };
        IEnumerable<ServiceRequest> zzz_ = context.Operators.Where<ServiceRequest>(zzx_, zzy_);
        bool? azza_ = context.Operators.Exists<ServiceRequest>(zzz_);
        bool? azzb_ = context.Operators.Or(zzv_, azza_);
        IEnumerable<Procedure> azzd_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, zzw_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? azze_(Procedure HospicePerformed)
        {
            Code<EventStatus> bzzs_ = HospicePerformed?.StatusElement;
            string bzzt_ = FHIRHelpers_4_0_001.Instance.ToString(context, bzzs_);
            bool? bzzu_ = context.Operators.Equal(bzzt_, "completed");
            DataType bzzv_ = HospicePerformed?.Performed;
            CqlInterval<CqlDateTime> bzzw_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, bzzv_);
            CqlInterval<CqlDateTime> bzzx_ = this.Measurement_Period(context);
            bool? bzzy_ = context.Operators.Overlaps(bzzw_, bzzx_, default);
            bool? bzzz_ = context.Operators.And(bzzu_, bzzy_);

            return bzzz_;
        };
        IEnumerable<Procedure> azzf_ = context.Operators.Where<Procedure>(azzd_, azze_);
        bool? azzg_ = context.Operators.Exists<Procedure>(azzf_);
        bool? azzh_ = context.Operators.Or(azzb_, azzg_);

        return azzh_;
    }


    #endregion Expressions

}
