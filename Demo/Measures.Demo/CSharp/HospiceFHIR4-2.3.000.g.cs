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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.0.0")]
[CqlLibrary("HospiceFHIR4", "2.3.000")]
public partial class HospiceFHIR4_2_3_000 : ILibrary, ISingleton<HospiceFHIR4_2_3_000>
{
    #region ValueSets (2)

    [CqlValueSetDefinition("Encounter Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext _) => _Encounter_Inpatient;
    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlValueSetDefinition("Hospice care ambulatory", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15", valueSetVersion: null)]
    public CqlValueSet Hospice_care_ambulatory(CqlContext _) => _Hospice_care_ambulatory;
    private static readonly CqlValueSet _Hospice_care_ambulatory = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15", null);

    #endregion ValueSets

    #region Codes (2)

    [CqlCodeDefinition("Discharge to healthcare facility for hospice care (procedure)", codeId: "428371000124100", codeSystem: "http://snomed.info/sct")]
    public CqlCode Discharge_to_healthcare_facility_for_hospice_care__procedure_(CqlContext _) => _Discharge_to_healthcare_facility_for_hospice_care__procedure_;
    private static readonly CqlCode _Discharge_to_healthcare_facility_for_hospice_care__procedure_ = new CqlCode("428371000124100", "http://snomed.info/sct");

    [CqlCodeDefinition("Discharge to home for hospice care (procedure)", codeId: "428361000124107", codeSystem: "http://snomed.info/sct")]
    public CqlCode Discharge_to_home_for_hospice_care__procedure_(CqlContext _) => _Discharge_to_home_for_hospice_care__procedure_;
    private static readonly CqlCode _Discharge_to_home_for_hospice_care__procedure_ = new CqlCode("428361000124107", "http://snomed.info/sct");

    #endregion Codes

    #region CodeSystems (1)

    [CqlCodeSystemDefinition("SNOMEDCT:2017-09", codeSystemId: "http://snomed.info/sct", codeSystemVersion: "http://snomed.info/sct/version/201709")]
    public CqlCodeSystem SNOMEDCT_2017_09(CqlContext _) => _SNOMEDCT_2017_09;
    private static readonly CqlCodeSystem _SNOMEDCT_2017_09 =
      new CqlCodeSystem("http://snomed.info/sct", "http://snomed.info/sct/version/201709", [
          _Discharge_to_healthcare_facility_for_hospice_care__procedure_,
          _Discharge_to_home_for_hospice_care__procedure_]);

    #endregion CodeSystems

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = 3162054828375168680L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        object a_ = context.ResolveParameter("HospiceFHIR4-2.3.000", "Measurement Period", (object)null);
        return (CqlInterval<CqlDateTime>)a_;
    }


    #endregion Parameters

    #region Functions and Expressions (2)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = 6420387729646046652L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Has Hospice")]
    public bool? Has_Hospice(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Hospice, Has_Hospice_Compute);

    private const long _cacheIndex_Has_Hospice = 2787990636943862063L;

    private bool? Has_Hospice_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));

        bool? c_(Encounter DischargeHospice) {
            Code<Encounter.EncounterStatus> f_ = DischargeHospice?.StatusElement;
            string g_ = FHIRHelpers_4_0_001.Instance.ToString(context, f_);
            bool? h_ = context.Operators.Equal(g_, "finished");
            bool? i_;
            // CQL 'and' (23:22-27:19): right operand skipped when left is false
            if (h_ is false)
            {
                i_ = false;
            }
            else
            {
                Encounter.HospitalizationComponent j_ = DischargeHospice?.Hospitalization;
                CodeableConcept k_ = j_?.DischargeDisposition;
                CqlConcept l_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, k_);
                CqlCode m_ = this.Discharge_to_home_for_hospice_care__procedure_(context);
                CqlConcept n_ = context.Operators.ConvertCodeToConcept(m_);
                bool? o_ = context.Operators.Equivalent(l_, n_);
                bool? p_;
                // CQL 'or' (24:23-27:19): right operand skipped when left is true
                if (o_ is true)
                {
                    p_ = true;
                }
                else
                {
                    Encounter.HospitalizationComponent q_ = DischargeHospice?.Hospitalization;
                    CodeableConcept r_ = q_?.DischargeDisposition;
                    CqlConcept s_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, r_);
                    CqlCode t_ = this.Discharge_to_healthcare_facility_for_hospice_care__procedure_(context);
                    CqlConcept u_ = context.Operators.ConvertCodeToConcept(t_);
                    bool? v_ = context.Operators.Equivalent(s_, u_);
                    p_ = o_ | v_;
                }
                i_ = h_ & p_;
            }
            // CQL 'and' (23:16-28:105): right operand skipped when left is false
            if (i_ is false)
            {
                return false;
            }
            else
            {
                Period w_ = DischargeHospice?.Period;
                CqlInterval<CqlDateTime> x_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, w_);
                CqlDateTime y_ = context.Operators.End(x_);
                CqlInterval<CqlDateTime> z_ = this.Measurement_Period(context);
                bool? aa_ = context.Operators.In<CqlDateTime>(y_, z_, (string)default);
                return i_ & aa_;
            }
        }

        bool? d_ = context.Operators.WhereAny<Encounter>(b_, c_);
        bool? e_;
        // CQL 'or' (21:3-35:17): right operand skipped when left is true
        if (d_ is true)
        {
            e_ = true;
        }
        else
        {
            CqlValueSet ab_ = this.Hospice_care_ambulatory(context);
            IEnumerable<ServiceRequest> ac_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, ab_, default, "http://hl7.org/fhir/StructureDefinition/ServiceRequest"));

            bool? ad_(ServiceRequest HospiceOrder) {
                Code<RequestStatus> af_ = HospiceOrder?.StatusElement;
                string ag_ = FHIRHelpers_4_0_001.Instance.ToString(context, af_);
                string[] ah_ = [
                    "active",
                    "completed",
                ];
                bool? ai_ = context.Operators.In<string>(ag_, (IEnumerable<string>)ah_);
                bool? aj_;
                // CQL 'and' (32:27-33:53): right operand skipped when left is false
                if (ai_ is false)
                {
                    aj_ = false;
                }
                else
                {
                    Code<RequestIntent> ak_ = HospiceOrder?.IntentElement;
                    string al_ = FHIRHelpers_4_0_001.Instance.ToString(context, ak_);
                    bool? am_ = context.Operators.Equal(al_, "order");
                    aj_ = ai_ & am_;
                }
                // CQL 'and' (32:21-34:108): right operand skipped when left is false
                if (aj_ is false)
                {
                    return false;
                }
                else
                {
                    CqlInterval<CqlDateTime> an_ = this.Measurement_Period(context);
                    FhirDateTime ao_ = HospiceOrder?.AuthoredOnElement;
                    CqlInterval<CqlDateTime> ap_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ao_);
                    bool? aq_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(an_, ap_, (string)default);
                    return aj_ & aq_;
                }
            }

            bool? ae_ = context.Operators.WhereAny<ServiceRequest>(ac_, ad_);
            e_ = d_ | ae_;
        }
        // CQL 'or' (21:3-40:17): right operand skipped when left is true
        if (e_ is true)
        {
            return true;
        }
        else
        {
            CqlValueSet ar_ = this.Hospice_care_ambulatory(context);
            IEnumerable<Procedure> as_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, ar_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));

            bool? at_(Procedure HospicePerformed) {
                Code<EventStatus> av_ = HospicePerformed?.StatusElement;
                string aw_ = FHIRHelpers_4_0_001.Instance.ToString(context, av_);
                bool? ax_ = context.Operators.Equal(aw_, "completed");
                // CQL 'and' (38:21-39:111): right operand skipped when left is false
                if (ax_ is false)
                {
                    return false;
                }
                else
                {
                    DataType ay_ = HospicePerformed?.Performed;
                    CqlInterval<CqlDateTime> az_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ay_);
                    CqlInterval<CqlDateTime> ba_ = this.Measurement_Period(context);
                    bool? bb_ = context.Operators.Overlaps(az_, ba_, (string)default);
                    return ax_ & bb_;
                }
            }

            bool? au_ = context.Operators.WhereAny<Procedure>(as_, at_);
            return e_ | au_;
        }
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private HospiceFHIR4_2_3_000() {}

    public static HospiceFHIR4_2_3_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "HospiceFHIR4";
    public string Version => "2.3.000";
    public ILibrary[] Dependencies => [MATGlobalCommonFunctionsFHIR4_6_1_000.Instance, FHIRHelpers_4_0_001.Instance];

    #endregion ILibrary Implementation

}
