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
    private static readonly CqlCode _Discharge_to_healthcare_facility_for_hospice_care__procedure_ = new CqlCode("428371000124100", "http://snomed.info/sct");

    [CqlCodeDefinition("Discharge to home for hospice care (procedure)", codeId: "428361000124107", codeSystem: "http://snomed.info/sct")]
    public CqlCode Discharge_to_home_for_hospice_care__procedure_(CqlContext _) => _Discharge_to_home_for_hospice_care__procedure_;
    private static readonly CqlCode _Discharge_to_home_for_hospice_care__procedure_ = new CqlCode("428361000124107", "http://snomed.info/sct");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("SNOMEDCT:2017-09")]
    public CqlCodeSystem SNOMEDCT_2017_09(CqlContext _) => _SNOMEDCT_2017_09;
    private static readonly CqlCodeSystem _SNOMEDCT_2017_09 =
      new CqlCodeSystem("http://snomed.info/sct", "http://snomed.info/sct/version/201709",
          _Discharge_to_healthcare_facility_for_hospice_care__procedure_,
          _Discharge_to_home_for_hospice_care__procedure_);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object wzzzn_ = context.ResolveParameter("HospiceFHIR4-2.3.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)wzzzn_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> wzzzo_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient wzzzp_ = context.Operators.SingletonFrom<Patient>(wzzzo_);

        return wzzzp_;
    }


    [CqlExpressionDefinition("Has Hospice")]
    public bool? Has_Hospice(CqlContext context)
    {
        CqlValueSet wzzzq_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> wzzzr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wzzzq_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        bool? wzzzs_(Encounter DischargeHospice)
        {
            Code<Encounter.EncounterStatus> xzzzh_ = DischargeHospice?.StatusElement;
            string xzzzi_ = FHIRHelpers_4_0_001.Instance.ToString(context, xzzzh_);
            bool? xzzzj_ = context.Operators.Equal(xzzzi_, "finished");
            Encounter.HospitalizationComponent xzzzk_ = DischargeHospice?.Hospitalization;
            CodeableConcept xzzzl_ = xzzzk_?.DischargeDisposition;
            CqlConcept xzzzm_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, xzzzl_);
            CqlCode xzzzn_ = this.Discharge_to_home_for_hospice_care__procedure_(context);
            CqlConcept xzzzo_ = context.Operators.ConvertCodeToConcept(xzzzn_);
            bool? xzzzp_ = context.Operators.Equivalent(xzzzm_, xzzzo_);
            CodeableConcept xzzzr_ = xzzzk_?.DischargeDisposition;
            CqlConcept xzzzs_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, xzzzr_);
            CqlCode xzzzt_ = this.Discharge_to_healthcare_facility_for_hospice_care__procedure_(context);
            CqlConcept xzzzu_ = context.Operators.ConvertCodeToConcept(xzzzt_);
            bool? xzzzv_ = context.Operators.Equivalent(xzzzs_, xzzzu_);
            bool? xzzzw_ = context.Operators.Or(xzzzp_, xzzzv_);
            bool? xzzzx_ = context.Operators.And(xzzzj_, xzzzw_);
            Period xzzzy_ = DischargeHospice?.Period;
            CqlInterval<CqlDateTime> xzzzz_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, xzzzy_ as object);
            CqlDateTime yzzza_ = context.Operators.End(xzzzz_);
            CqlInterval<CqlDateTime> yzzzb_ = this.Measurement_Period(context);
            bool? yzzzc_ = context.Operators.In<CqlDateTime>(yzzza_, yzzzb_, default);
            bool? yzzzd_ = context.Operators.And(xzzzx_, yzzzc_);

            return yzzzd_;
        };
        IEnumerable<Encounter> wzzzt_ = context.Operators.Where<Encounter>(wzzzr_, wzzzs_);
        bool? wzzzu_ = context.Operators.Exists<Encounter>(wzzzt_);
        CqlValueSet wzzzv_ = this.Hospice_care_ambulatory(context);
        IEnumerable<ServiceRequest> wzzzw_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, wzzzv_, default, "http://hl7.org/fhir/StructureDefinition/ServiceRequest"));
        bool? wzzzx_(ServiceRequest HospiceOrder)
        {
            Code<RequestStatus> yzzze_ = HospiceOrder?.StatusElement;
            string yzzzf_ = FHIRHelpers_4_0_001.Instance.ToString(context, yzzze_);
            string[] yzzzg_ = [
                "active",
                "completed",
            ];
            bool? yzzzh_ = context.Operators.In<string>(yzzzf_, yzzzg_ as IEnumerable<string>);
            Code<RequestIntent> yzzzi_ = HospiceOrder?.IntentElement;
            string yzzzj_ = FHIRHelpers_4_0_001.Instance.ToString(context, yzzzi_);
            bool? yzzzk_ = context.Operators.Equal(yzzzj_, "order");
            bool? yzzzl_ = context.Operators.And(yzzzh_, yzzzk_);
            CqlInterval<CqlDateTime> yzzzm_ = this.Measurement_Period(context);
            FhirDateTime yzzzn_ = HospiceOrder?.AuthoredOnElement;
            CqlInterval<CqlDateTime> yzzzo_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, yzzzn_ as object);
            bool? yzzzp_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(yzzzm_, yzzzo_, default);
            bool? yzzzq_ = context.Operators.And(yzzzl_, yzzzp_);

            return yzzzq_;
        };
        IEnumerable<ServiceRequest> wzzzy_ = context.Operators.Where<ServiceRequest>(wzzzw_, wzzzx_);
        bool? wzzzz_ = context.Operators.Exists<ServiceRequest>(wzzzy_);
        bool? xzzza_ = context.Operators.Or(wzzzu_, wzzzz_);
        IEnumerable<Procedure> xzzzc_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, wzzzv_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? xzzzd_(Procedure HospicePerformed)
        {
            Code<EventStatus> yzzzr_ = HospicePerformed?.StatusElement;
            string yzzzs_ = FHIRHelpers_4_0_001.Instance.ToString(context, yzzzr_);
            bool? yzzzt_ = context.Operators.Equal(yzzzs_, "completed");
            DataType yzzzu_ = HospicePerformed?.Performed;
            CqlInterval<CqlDateTime> yzzzv_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, yzzzu_);
            CqlInterval<CqlDateTime> yzzzw_ = this.Measurement_Period(context);
            bool? yzzzx_ = context.Operators.Overlaps(yzzzv_, yzzzw_, default);
            bool? yzzzy_ = context.Operators.And(yzzzt_, yzzzx_);

            return yzzzy_;
        };
        IEnumerable<Procedure> xzzze_ = context.Operators.Where<Procedure>(xzzzc_, xzzzd_);
        bool? xzzzf_ = context.Operators.Exists<Procedure>(xzzze_);
        bool? xzzzg_ = context.Operators.Or(xzzza_, xzzzf_);

        return xzzzg_;
    }


    #endregion Expressions

}
