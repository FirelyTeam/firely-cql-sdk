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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.8.0")]
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
            Code<Encounter.EncounterStatus> n_ = DischargeHospice?.StatusElement;
            string o_ = FHIRHelpers_4_0_001.Instance.ToString(context, n_);
            bool? p_ = context.Operators.Equal(o_, "finished");
            Encounter.HospitalizationComponent q_ = DischargeHospice?.Hospitalization;
            CodeableConcept r_ = q_?.DischargeDisposition;
            CqlConcept s_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, r_);
            CqlCode t_ = this.Discharge_to_home_for_hospice_care__procedure_(context);
            CqlConcept u_ = context.Operators.ConvertCodeToConcept(t_);
            bool? v_ = context.Operators.Equivalent(s_, u_);
            CqlCode w_ = this.Discharge_to_healthcare_facility_for_hospice_care__procedure_(context);
            CqlConcept x_ = context.Operators.ConvertCodeToConcept(w_);
            bool? y_ = context.Operators.Equivalent(s_, x_);
            bool? z_ = context.Operators.Or(v_, y_);
            bool? aa_ = context.Operators.And(p_, z_);
            Period ab_ = DischargeHospice?.Period;
            CqlInterval<CqlDateTime> ac_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ab_);
            CqlDateTime ad_ = context.Operators.End(ac_);
            CqlInterval<CqlDateTime> ae_ = this.Measurement_Period(context);
            bool? af_ = context.Operators.In<CqlDateTime>(ad_, ae_, (string)default);
            bool? ag_ = context.Operators.And(aa_, af_);
            return ag_;
        }

        bool? d_ = context.Operators.WhereAny<Encounter>(b_, c_);
        CqlValueSet e_ = this.Hospice_care_ambulatory(context);
        IEnumerable<ServiceRequest> f_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/StructureDefinition/ServiceRequest"));

        bool? g_(ServiceRequest HospiceOrder) {
            Code<RequestStatus> ah_ = HospiceOrder?.StatusElement;
            string ai_ = FHIRHelpers_4_0_001.Instance.ToString(context, ah_);
            string[] aj_ = [
                "active",
                "completed",
            ];
            bool? ak_ = context.Operators.In<string>(ai_, (IEnumerable<string>)aj_);
            Code<RequestIntent> al_ = HospiceOrder?.IntentElement;
            string am_ = FHIRHelpers_4_0_001.Instance.ToString(context, al_);
            bool? an_ = context.Operators.Equal(am_, "order");
            bool? ao_ = context.Operators.And(ak_, an_);
            CqlInterval<CqlDateTime> ap_ = this.Measurement_Period(context);
            FhirDateTime aq_ = HospiceOrder?.AuthoredOnElement;
            CqlInterval<CqlDateTime> ar_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, aq_);
            bool? as_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ap_, ar_, (string)default);
            bool? at_ = context.Operators.And(ao_, as_);
            return at_;
        }

        bool? h_ = context.Operators.WhereAny<ServiceRequest>(f_, g_);
        bool? i_ = context.Operators.Or(d_, h_);
        IEnumerable<Procedure> j_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));

        bool? k_(Procedure HospicePerformed) {
            Code<EventStatus> au_ = HospicePerformed?.StatusElement;
            string av_ = FHIRHelpers_4_0_001.Instance.ToString(context, au_);
            bool? aw_ = context.Operators.Equal(av_, "completed");
            DataType ax_ = HospicePerformed?.Performed;
            CqlInterval<CqlDateTime> ay_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ax_);
            CqlInterval<CqlDateTime> az_ = this.Measurement_Period(context);
            bool? ba_ = context.Operators.Overlaps(ay_, az_, (string)default);
            bool? bb_ = context.Operators.And(aw_, ba_);
            return bb_;
        }

        bool? l_ = context.Operators.WhereAny<Procedure>(j_, k_);
        bool? m_ = context.Operators.Or(i_, l_);
        return m_;
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
