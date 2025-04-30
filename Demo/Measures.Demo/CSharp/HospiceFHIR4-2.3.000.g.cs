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
      new CqlCodeSystem("http://snomed.info/sct", "http://snomed.info/sct/version/201709", [
          _Discharge_to_healthcare_facility_for_hospice_care__procedure_,
          _Discharge_to_home_for_hospice_care__procedure_]);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object vzi_ = context.ResolveParameter("HospiceFHIR4-2.3.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)vzi_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> vzj_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient vzk_ = context.Operators.SingletonFrom<Patient>(vzj_);

        return vzk_;
    }


    [CqlExpressionDefinition("Has Hospice")]
    public bool? Has_Hospice(CqlContext context)
    {
        CqlValueSet vzl_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> vzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, vzl_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        bool? vzn_(Encounter DischargeHospice)
        {
            Code<Encounter.EncounterStatus> wzc_ = DischargeHospice?.StatusElement;
            string wzd_ = FHIRHelpers_4_0_001.Instance.ToString(context, wzc_);
            bool? wze_ = context.Operators.Equal(wzd_, "finished");
            Encounter.HospitalizationComponent wzf_ = DischargeHospice?.Hospitalization;
            CodeableConcept wzg_ = wzf_?.DischargeDisposition;
            CqlConcept wzh_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, wzg_);
            CqlCode wzi_ = this.Discharge_to_home_for_hospice_care__procedure_(context);
            CqlConcept wzj_ = context.Operators.ConvertCodeToConcept(wzi_);
            bool? wzk_ = context.Operators.Equivalent(wzh_, wzj_);
            CodeableConcept wzm_ = wzf_?.DischargeDisposition;
            CqlConcept wzn_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, wzm_);
            CqlCode wzo_ = this.Discharge_to_healthcare_facility_for_hospice_care__procedure_(context);
            CqlConcept wzp_ = context.Operators.ConvertCodeToConcept(wzo_);
            bool? wzq_ = context.Operators.Equivalent(wzn_, wzp_);
            bool? wzr_ = context.Operators.Or(wzk_, wzq_);
            bool? wzs_ = context.Operators.And(wze_, wzr_);
            Period wzt_ = DischargeHospice?.Period;
            CqlInterval<CqlDateTime> wzu_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, wzt_ as object);
            CqlDateTime wzv_ = context.Operators.End(wzu_);
            CqlInterval<CqlDateTime> wzw_ = this.Measurement_Period(context);
            bool? wzx_ = context.Operators.In<CqlDateTime>(wzv_, wzw_, default);
            bool? wzy_ = context.Operators.And(wzs_, wzx_);

            return wzy_;
        };
        IEnumerable<Encounter> vzo_ = context.Operators.Where<Encounter>(vzm_, vzn_);
        bool? vzp_ = context.Operators.Exists<Encounter>(vzo_);
        CqlValueSet vzq_ = this.Hospice_care_ambulatory(context);
        IEnumerable<ServiceRequest> vzr_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, vzq_, default, "http://hl7.org/fhir/StructureDefinition/ServiceRequest"));
        bool? vzs_(ServiceRequest HospiceOrder)
        {
            Code<RequestStatus> wzz_ = HospiceOrder?.StatusElement;
            string xza_ = FHIRHelpers_4_0_001.Instance.ToString(context, wzz_);
            string[] xzb_ = [
                "active",
                "completed",
            ];
            bool? xzc_ = context.Operators.In<string>(xza_, xzb_ as IEnumerable<string>);
            Code<RequestIntent> xzd_ = HospiceOrder?.IntentElement;
            string xze_ = FHIRHelpers_4_0_001.Instance.ToString(context, xzd_);
            bool? xzf_ = context.Operators.Equal(xze_, "order");
            bool? xzg_ = context.Operators.And(xzc_, xzf_);
            CqlInterval<CqlDateTime> xzh_ = this.Measurement_Period(context);
            FhirDateTime xzi_ = HospiceOrder?.AuthoredOnElement;
            CqlInterval<CqlDateTime> xzj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, xzi_ as object);
            bool? xzk_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(xzh_, xzj_, default);
            bool? xzl_ = context.Operators.And(xzg_, xzk_);

            return xzl_;
        };
        IEnumerable<ServiceRequest> vzt_ = context.Operators.Where<ServiceRequest>(vzr_, vzs_);
        bool? vzu_ = context.Operators.Exists<ServiceRequest>(vzt_);
        bool? vzv_ = context.Operators.Or(vzp_, vzu_);
        IEnumerable<Procedure> vzx_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, vzq_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? vzy_(Procedure HospicePerformed)
        {
            Code<EventStatus> xzm_ = HospicePerformed?.StatusElement;
            string xzn_ = FHIRHelpers_4_0_001.Instance.ToString(context, xzm_);
            bool? xzo_ = context.Operators.Equal(xzn_, "completed");
            DataType xzp_ = HospicePerformed?.Performed;
            CqlInterval<CqlDateTime> xzq_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, xzp_);
            CqlInterval<CqlDateTime> xzr_ = this.Measurement_Period(context);
            bool? xzs_ = context.Operators.Overlaps(xzq_, xzr_, default);
            bool? xzt_ = context.Operators.And(xzo_, xzs_);

            return xzt_;
        };
        IEnumerable<Procedure> vzz_ = context.Operators.Where<Procedure>(vzx_, vzy_);
        bool? wza_ = context.Operators.Exists<Procedure>(vzz_);
        bool? wzb_ = context.Operators.Or(vzv_, wza_);

        return wzb_;
    }


    #endregion Expressions

}
