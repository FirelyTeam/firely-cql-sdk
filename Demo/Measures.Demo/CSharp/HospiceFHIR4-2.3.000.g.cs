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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.6.0")]
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
            Code<Encounter.EncounterStatus> g_ = DischargeHospice?.StatusElement;
            string h_ = FHIRHelpers_4_0_001.Instance.ToString(context, g_);
            CqlBoolean i_ = context.Operators.Equal(h_, "finished");

            CqlBoolean j_() {
                Encounter.HospitalizationComponent l_ = DischargeHospice?.Hospitalization;
                CodeableConcept m_ = l_?.DischargeDisposition;
                CqlConcept n_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, m_);
                CqlCode o_ = this.Discharge_to_home_for_hospice_care__procedure_(context);
                CqlConcept p_ = context.Operators.ConvertCodeToConcept(o_);
                CqlBoolean q_ = context.Operators.Equivalent(n_, p_);

                CqlBoolean r_() {
                    Encounter.HospitalizationComponent s_ = DischargeHospice?.Hospitalization;
                    CodeableConcept t_ = s_?.DischargeDisposition;
                    CqlConcept u_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, t_);
                    CqlCode v_ = this.Discharge_to_healthcare_facility_for_hospice_care__procedure_(context);
                    CqlConcept w_ = context.Operators.ConvertCodeToConcept(v_);
                    CqlBoolean x_ = context.Operators.Equivalent(u_, w_);
                    return x_;
                }

                return q_
                    /* CQL 'or' (24:23-27:19) */ || r_();
            }


            CqlBoolean k_() {
                Period y_ = DischargeHospice?.Period;
                CqlInterval<CqlDateTime> z_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, y_);
                CqlDateTime aa_ = context.Operators.End(z_);
                CqlInterval<CqlDateTime> ab_ = this.Measurement_Period(context);
                CqlBoolean ac_ = context.Operators.In<CqlDateTime>(aa_, ab_, (string)default);
                return ac_;
            }

            return i_
                /* CQL 'and' (23:22-27:19) */ && j_()
                /* CQL 'and' (23:16-28:105) */ && k_();
        }

        CqlBoolean d_ = context.Operators.WhereAny<Encounter>(b_, c_);

        CqlBoolean e_() {
            CqlValueSet ad_ = this.Hospice_care_ambulatory(context);
            IEnumerable<ServiceRequest> ae_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, ad_, default, "http://hl7.org/fhir/StructureDefinition/ServiceRequest"));

            bool? af_(ServiceRequest HospiceOrder) {
                Code<RequestStatus> ah_ = HospiceOrder?.StatusElement;
                string ai_ = FHIRHelpers_4_0_001.Instance.ToString(context, ah_);
                string[] aj_ = [
                    "active",
                    "completed",
                ];
                CqlBoolean ak_ = context.Operators.In<string>(ai_, (IEnumerable<string>)aj_);

                CqlBoolean al_() {
                    Code<RequestIntent> an_ = HospiceOrder?.IntentElement;
                    string ao_ = FHIRHelpers_4_0_001.Instance.ToString(context, an_);
                    CqlBoolean ap_ = context.Operators.Equal(ao_, "order");
                    return ap_;
                }


                CqlBoolean am_() {
                    CqlInterval<CqlDateTime> aq_ = this.Measurement_Period(context);
                    FhirDateTime ar_ = HospiceOrder?.AuthoredOnElement;
                    CqlInterval<CqlDateTime> as_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ar_);
                    CqlBoolean at_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(aq_, as_, (string)default);
                    return at_;
                }

                return ak_
                    /* CQL 'and' (32:27-33:53) */ && al_()
                    /* CQL 'and' (32:21-34:108) */ && am_();
            }

            CqlBoolean ag_ = context.Operators.WhereAny<ServiceRequest>(ae_, af_);
            return ag_;
        }


        CqlBoolean f_() {
            CqlValueSet au_ = this.Hospice_care_ambulatory(context);
            IEnumerable<Procedure> av_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, au_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));

            bool? aw_(Procedure HospicePerformed) {
                Code<EventStatus> ay_ = HospicePerformed?.StatusElement;
                string az_ = FHIRHelpers_4_0_001.Instance.ToString(context, ay_);
                CqlBoolean ba_ = context.Operators.Equal(az_, "completed");

                CqlBoolean bb_() {
                    DataType bc_ = HospicePerformed?.Performed;
                    CqlInterval<CqlDateTime> bd_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, bc_);
                    CqlInterval<CqlDateTime> be_ = this.Measurement_Period(context);
                    CqlBoolean bf_ = context.Operators.Overlaps(bd_, be_, (string)default);
                    return bf_;
                }

                return ba_
                    /* CQL 'and' (38:21-39:111) */ && bb_();
            }

            CqlBoolean ax_ = context.Operators.WhereAny<Procedure>(av_, aw_);
            return ax_;
        }

        return d_
            /* CQL 'or' (21:3-35:17) */ || e_()
            /* CQL 'or' (21:3-40:17) */ || f_();
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
