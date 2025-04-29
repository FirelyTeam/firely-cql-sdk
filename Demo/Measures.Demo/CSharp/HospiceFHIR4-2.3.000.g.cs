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

    #region ValueSet: Encounter Inpatient
    [CqlValueSetDefinition(
        definitionName: "Encounter Inpatient",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307",
        valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext context) => _Encounter_Inpatient;

    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);
    #endregion

    #region ValueSet: Hospice care ambulatory
    [CqlValueSetDefinition(
        definitionName: "Hospice care ambulatory",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15",
        valueSetVersion: null)]
    public CqlValueSet Hospice_care_ambulatory(CqlContext context) => _Hospice_care_ambulatory;

    private static readonly CqlValueSet _Hospice_care_ambulatory = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15", null);
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

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition(
        definitionName: "SNOMEDCT:2017-09")]
    public CqlCode[] SNOMEDCT_2017_09(CqlContext context)
    {
        CqlCode[] yzw_ = [
            new CqlCode("428371000124100", "http://snomed.info/sct", default, default),
            new CqlCode("428361000124107", "http://snomed.info/sct", default, default),
        ];

        return yzw_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object yzx_ = context.ResolveParameter("HospiceFHIR4-2.3.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)yzx_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> yzy_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient yzz_ = context.Operators.SingletonFrom<Patient>(yzy_);

        return yzz_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Hospice")]
    public bool? Has_Hospice(CqlContext context)
    {
        CqlValueSet zza_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> zzb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zza_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        bool? zzc_(Encounter DischargeHospice)
        {
            Code<Encounter.EncounterStatus> zzr_ = DischargeHospice?.StatusElement;
            string zzs_ = FHIRHelpers_4_0_001.Instance.ToString(context, zzr_);
            bool? zzt_ = context.Operators.Equal(zzs_, "finished");
            Encounter.HospitalizationComponent zzu_ = DischargeHospice?.Hospitalization;
            CodeableConcept zzv_ = zzu_?.DischargeDisposition;
            CqlConcept zzw_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, zzv_);
            CqlCode zzx_ = this.Discharge_to_home_for_hospice_care__procedure_(context);
            CqlConcept zzy_ = context.Operators.ConvertCodeToConcept(zzx_);
            bool? zzz_ = context.Operators.Equivalent(zzw_, zzy_);
            CodeableConcept azzb_ = zzu_?.DischargeDisposition;
            CqlConcept azzc_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, azzb_);
            CqlCode azzd_ = this.Discharge_to_healthcare_facility_for_hospice_care__procedure_(context);
            CqlConcept azze_ = context.Operators.ConvertCodeToConcept(azzd_);
            bool? azzf_ = context.Operators.Equivalent(azzc_, azze_);
            bool? azzg_ = context.Operators.Or(zzz_, azzf_);
            bool? azzh_ = context.Operators.And(zzt_, azzg_);
            Period azzi_ = DischargeHospice?.Period;
            CqlInterval<CqlDateTime> azzj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, azzi_ as object);
            CqlDateTime azzk_ = context.Operators.End(azzj_);
            CqlInterval<CqlDateTime> azzl_ = this.Measurement_Period(context);
            bool? azzm_ = context.Operators.In<CqlDateTime>(azzk_, azzl_, default);
            bool? azzn_ = context.Operators.And(azzh_, azzm_);

            return azzn_;
        };
        IEnumerable<Encounter> zzd_ = context.Operators.Where<Encounter>(zzb_, zzc_);
        bool? zze_ = context.Operators.Exists<Encounter>(zzd_);
        CqlValueSet zzf_ = this.Hospice_care_ambulatory(context);
        IEnumerable<ServiceRequest> zzg_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, zzf_, default, "http://hl7.org/fhir/StructureDefinition/ServiceRequest"));
        bool? zzh_(ServiceRequest HospiceOrder)
        {
            Code<RequestStatus> azzo_ = HospiceOrder?.StatusElement;
            string azzp_ = FHIRHelpers_4_0_001.Instance.ToString(context, azzo_);
            string[] azzq_ = [
                "active",
                "completed",
            ];
            bool? azzr_ = context.Operators.In<string>(azzp_, azzq_ as IEnumerable<string>);
            Code<RequestIntent> azzs_ = HospiceOrder?.IntentElement;
            string azzt_ = FHIRHelpers_4_0_001.Instance.ToString(context, azzs_);
            bool? azzu_ = context.Operators.Equal(azzt_, "order");
            bool? azzv_ = context.Operators.And(azzr_, azzu_);
            CqlInterval<CqlDateTime> azzw_ = this.Measurement_Period(context);
            FhirDateTime azzx_ = HospiceOrder?.AuthoredOnElement;
            CqlInterval<CqlDateTime> azzy_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, azzx_ as object);
            bool? azzz_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(azzw_, azzy_, default);
            bool? bzza_ = context.Operators.And(azzv_, azzz_);

            return bzza_;
        };
        IEnumerable<ServiceRequest> zzi_ = context.Operators.Where<ServiceRequest>(zzg_, zzh_);
        bool? zzj_ = context.Operators.Exists<ServiceRequest>(zzi_);
        bool? zzk_ = context.Operators.Or(zze_, zzj_);
        IEnumerable<Procedure> zzm_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, zzf_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? zzn_(Procedure HospicePerformed)
        {
            Code<EventStatus> bzzb_ = HospicePerformed?.StatusElement;
            string bzzc_ = FHIRHelpers_4_0_001.Instance.ToString(context, bzzb_);
            bool? bzzd_ = context.Operators.Equal(bzzc_, "completed");
            DataType bzze_ = HospicePerformed?.Performed;
            CqlInterval<CqlDateTime> bzzf_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, bzze_);
            CqlInterval<CqlDateTime> bzzg_ = this.Measurement_Period(context);
            bool? bzzh_ = context.Operators.Overlaps(bzzf_, bzzg_, default);
            bool? bzzi_ = context.Operators.And(bzzd_, bzzh_);

            return bzzi_;
        };
        IEnumerable<Procedure> zzo_ = context.Operators.Where<Procedure>(zzm_, zzn_);
        bool? zzp_ = context.Operators.Exists<Procedure>(zzo_);
        bool? zzq_ = context.Operators.Or(zzk_, zzp_);

        return zzq_;
    }


    #endregion Expressions

}
