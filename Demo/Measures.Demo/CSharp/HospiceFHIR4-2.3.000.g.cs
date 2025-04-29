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
        object fzzzze_ = context.ResolveParameter("HospiceFHIR4-2.3.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)fzzzze_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> fzzzzf_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient fzzzzg_ = context.Operators.SingletonFrom<Patient>(fzzzzf_);

        return fzzzzg_;
    }


    [CqlExpressionDefinition("Has Hospice")]
    public bool? Has_Hospice(CqlContext context)
    {
        CqlValueSet fzzzzh_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> fzzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzh_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        bool? fzzzzj_(Encounter DischargeHospice)
        {
            Code<Encounter.EncounterStatus> fzzzzy_ = DischargeHospice?.StatusElement;
            string fzzzzz_ = FHIRHelpers_4_0_001.Instance.ToString(context, fzzzzy_);
            bool? gzzzza_ = context.Operators.Equal(fzzzzz_, "finished");
            Encounter.HospitalizationComponent gzzzzb_ = DischargeHospice?.Hospitalization;
            CodeableConcept gzzzzc_ = gzzzzb_?.DischargeDisposition;
            CqlConcept gzzzzd_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, gzzzzc_);
            CqlCode gzzzze_ = this.Discharge_to_home_for_hospice_care__procedure_(context);
            CqlConcept gzzzzf_ = context.Operators.ConvertCodeToConcept(gzzzze_);
            bool? gzzzzg_ = context.Operators.Equivalent(gzzzzd_, gzzzzf_);
            CodeableConcept gzzzzi_ = gzzzzb_?.DischargeDisposition;
            CqlConcept gzzzzj_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, gzzzzi_);
            CqlCode gzzzzk_ = this.Discharge_to_healthcare_facility_for_hospice_care__procedure_(context);
            CqlConcept gzzzzl_ = context.Operators.ConvertCodeToConcept(gzzzzk_);
            bool? gzzzzm_ = context.Operators.Equivalent(gzzzzj_, gzzzzl_);
            bool? gzzzzn_ = context.Operators.Or(gzzzzg_, gzzzzm_);
            bool? gzzzzo_ = context.Operators.And(gzzzza_, gzzzzn_);
            Period gzzzzp_ = DischargeHospice?.Period;
            CqlInterval<CqlDateTime> gzzzzq_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, gzzzzp_ as object);
            CqlDateTime gzzzzr_ = context.Operators.End(gzzzzq_);
            CqlInterval<CqlDateTime> gzzzzs_ = this.Measurement_Period(context);
            bool? gzzzzt_ = context.Operators.In<CqlDateTime>(gzzzzr_, gzzzzs_, default);
            bool? gzzzzu_ = context.Operators.And(gzzzzo_, gzzzzt_);

            return gzzzzu_;
        };
        IEnumerable<Encounter> fzzzzk_ = context.Operators.Where<Encounter>(fzzzzi_, fzzzzj_);
        bool? fzzzzl_ = context.Operators.Exists<Encounter>(fzzzzk_);
        CqlValueSet fzzzzm_ = this.Hospice_care_ambulatory(context);
        IEnumerable<ServiceRequest> fzzzzn_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, fzzzzm_, default, "http://hl7.org/fhir/StructureDefinition/ServiceRequest"));
        bool? fzzzzo_(ServiceRequest HospiceOrder)
        {
            Code<RequestStatus> gzzzzv_ = HospiceOrder?.StatusElement;
            string gzzzzw_ = FHIRHelpers_4_0_001.Instance.ToString(context, gzzzzv_);
            string[] gzzzzx_ = [
                "active",
                "completed",
            ];
            bool? gzzzzy_ = context.Operators.In<string>(gzzzzw_, gzzzzx_ as IEnumerable<string>);
            Code<RequestIntent> gzzzzz_ = HospiceOrder?.IntentElement;
            string hzzzza_ = FHIRHelpers_4_0_001.Instance.ToString(context, gzzzzz_);
            bool? hzzzzb_ = context.Operators.Equal(hzzzza_, "order");
            bool? hzzzzc_ = context.Operators.And(gzzzzy_, hzzzzb_);
            CqlInterval<CqlDateTime> hzzzzd_ = this.Measurement_Period(context);
            FhirDateTime hzzzze_ = HospiceOrder?.AuthoredOnElement;
            CqlInterval<CqlDateTime> hzzzzf_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, hzzzze_ as object);
            bool? hzzzzg_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(hzzzzd_, hzzzzf_, default);
            bool? hzzzzh_ = context.Operators.And(hzzzzc_, hzzzzg_);

            return hzzzzh_;
        };
        IEnumerable<ServiceRequest> fzzzzp_ = context.Operators.Where<ServiceRequest>(fzzzzn_, fzzzzo_);
        bool? fzzzzq_ = context.Operators.Exists<ServiceRequest>(fzzzzp_);
        bool? fzzzzr_ = context.Operators.Or(fzzzzl_, fzzzzq_);
        IEnumerable<Procedure> fzzzzt_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, fzzzzm_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? fzzzzu_(Procedure HospicePerformed)
        {
            Code<EventStatus> hzzzzi_ = HospicePerformed?.StatusElement;
            string hzzzzj_ = FHIRHelpers_4_0_001.Instance.ToString(context, hzzzzi_);
            bool? hzzzzk_ = context.Operators.Equal(hzzzzj_, "completed");
            DataType hzzzzl_ = HospicePerformed?.Performed;
            CqlInterval<CqlDateTime> hzzzzm_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, hzzzzl_);
            CqlInterval<CqlDateTime> hzzzzn_ = this.Measurement_Period(context);
            bool? hzzzzo_ = context.Operators.Overlaps(hzzzzm_, hzzzzn_, default);
            bool? hzzzzp_ = context.Operators.And(hzzzzk_, hzzzzo_);

            return hzzzzp_;
        };
        IEnumerable<Procedure> fzzzzv_ = context.Operators.Where<Procedure>(fzzzzt_, fzzzzu_);
        bool? fzzzzw_ = context.Operators.Exists<Procedure>(fzzzzv_);
        bool? fzzzzx_ = context.Operators.Or(fzzzzr_, fzzzzw_);

        return fzzzzx_;
    }


    #endregion Expressions

}
