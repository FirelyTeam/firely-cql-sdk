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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.5.0")]
[CqlLibrary("Hospice", "6.18.000")]
public partial class Hospice_6_18_000 : ILibrary, ISingleton<Hospice_6_18_000>
{
    #region ValueSets (4)

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

    #region Codes (4)

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

    #region CodeSystems (2)

    [CqlCodeSystemDefinition("LOINC", codeSystemId: "http://loinc.org", codeSystemVersion: null)]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, [
          _Hospice_care__Minimum_Data_Set_]);

    [CqlCodeSystemDefinition("SNOMEDCT", codeSystemId: "http://snomed.info/sct", codeSystemVersion: null)]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Discharge_to_healthcare_facility_for_hospice_care__procedure_,
          _Discharge_to_home_for_hospice_care__procedure_,
          _Yes__qualifier_value_]);

    #endregion CodeSystems

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = 2116253259980977327L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        object a_ = context.ResolveParameter("Hospice-6.18.000", "Measurement Period", (object)null);
        return (CqlInterval<CqlDateTime>)a_;
    }


    #endregion Parameters

    #region Functions and Expressions (2)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = -5253891409149354845L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Has Hospice Services")]
    public bool? Has_Hospice_Services(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Hospice_Services, Has_Hospice_Services_Compute);

    private const long _cacheIndex_Has_Hospice_Services = -926256737360152106L;

    private bool? Has_Hospice_Services_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> c_ = Status_1_15_000.Instance.isEncounterPerformed(context, b_);

        bool? d_(Encounter InpatientEncounter) {
            Encounter.HospitalizationComponent k_ = InpatientEncounter?.Hospitalization;
            CodeableConcept l_ = k_?.DischargeDisposition;
            CqlConcept m_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, l_);
            CqlCode n_ = this.Discharge_to_home_for_hospice_care__procedure_(context);
            CqlConcept o_ = context.Operators.ConvertCodeToConcept(n_);
            CqlBoolean p_ = context.Operators.Equivalent(m_, o_);

            CqlBoolean q_() {
                Encounter.HospitalizationComponent s_ = InpatientEncounter?.Hospitalization;
                CodeableConcept t_ = s_?.DischargeDisposition;
                CqlConcept u_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, t_);
                CqlCode v_ = this.Discharge_to_healthcare_facility_for_hospice_care__procedure_(context);
                CqlConcept w_ = context.Operators.ConvertCodeToConcept(v_);
                CqlBoolean x_ = context.Operators.Equivalent(u_, w_);
                return x_;
            }


            CqlBoolean r_() {
                Period y_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> z_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, y_);
                CqlDateTime aa_ = context.Operators.End(z_);
                CqlInterval<CqlDateTime> ab_ = this.Measurement_Period(context);
                CqlBoolean ac_ = context.Operators.In<CqlDateTime>(aa_, ab_, "day");
                return ac_;
            }

            return p_
                /* CQL 'or' (28:13-30:7) */ || q_()
                /* CQL 'and' (28:7-31:77) */ && r_();
        }

        CqlBoolean e_ = context.Operators.WhereAny<Encounter>(c_, d_);

        CqlBoolean f_() {
            CqlValueSet ad_ = this.Hospice_Encounter(context);
            IEnumerable<Encounter> ae_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ad_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            IEnumerable<Encounter> af_ = Status_1_15_000.Instance.isEncounterPerformed(context, ae_);

            bool? ag_(Encounter HospiceEncounter) {
                Period ai_ = HospiceEncounter?.Period;
                CqlInterval<CqlDateTime> aj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ai_);
                CqlInterval<CqlDateTime> ak_ = this.Measurement_Period(context);
                CqlBoolean al_ = context.Operators.Overlaps(aj_, ak_, "day");
                return al_;
            }

            CqlBoolean ah_ = context.Operators.WhereAny<Encounter>(af_, ag_);
            return ah_;
        }


        CqlBoolean g_() {
            CqlCode am_ = this.Hospice_care__Minimum_Data_Set_(context);
            IEnumerable<CqlCode> an_ = context.Operators.ToList<CqlCode>(am_);
            IEnumerable<Observation> ao_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, an_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
            IEnumerable<Observation> ap_ = Status_1_15_000.Instance.isAssessmentPerformed(context, ao_);

            bool? aq_(Observation HospiceAssessment) {
                DataType as_ = HospiceAssessment?.Value;
                object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                CqlCode au_ = this.Yes__qualifier_value_(context);
                CqlConcept av_ = context.Operators.ConvertCodeToConcept(au_);
                CqlBoolean aw_ = context.Operators.Equivalent(at_ as CqlConcept, av_);

                CqlBoolean ax_() {
                    DataType ay_ = HospiceAssessment?.Effective;
                    object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                    CqlInterval<CqlDateTime> ba_ = QICoreCommon_4_0_000.Instance.toInterval(context, az_);
                    CqlInterval<CqlDateTime> bb_ = this.Measurement_Period(context);
                    CqlBoolean bc_ = context.Operators.Overlaps(ba_, bb_, "day");
                    return bc_;
                }

                return aw_
                    /* CQL 'and' (37:9-38:91) */ && ax_();
            }

            CqlBoolean ar_ = context.Operators.WhereAny<Observation>(ap_, aq_);
            return ar_;
        }


        CqlBoolean h_() {
            CqlValueSet bd_ = this.Hospice_Care_Ambulatory(context);
            IEnumerable<ServiceRequest> be_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, bd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
            IEnumerable<ServiceRequest> bf_ = Status_1_15_000.Instance.isInterventionOrder(context, be_);

            bool? bg_(ServiceRequest HospiceOrder) {
                FhirDateTime bi_ = HospiceOrder?.AuthoredOnElement;
                CqlDateTime bj_ = context.Operators.Convert<CqlDateTime>(bi_);
                CqlInterval<CqlDateTime> bk_ = this.Measurement_Period(context);
                CqlBoolean bl_ = context.Operators.In<CqlDateTime>(bj_, bk_, "day");
                return bl_;
            }

            CqlBoolean bh_ = context.Operators.WhereAny<ServiceRequest>(bf_, bg_);
            return bh_;
        }


        CqlBoolean i_() {
            CqlValueSet bm_ = this.Hospice_Care_Ambulatory(context);
            IEnumerable<Procedure> bn_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, bm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            IEnumerable<Procedure> bo_ = Status_1_15_000.Instance.isInterventionPerformed(context, bn_);

            bool? bp_(Procedure HospicePerformed) {
                object br_;
                DataType bv_ = HospicePerformed?.Performed;
                object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                bool bx_ = bw_ is CqlDateTime;
                if (bx_)
                {
                    br_ = bw_ as CqlDateTime;
                }
                else
                {
                    bool by_ = bw_ is CqlQuantity;
                    if (by_)
                    {
                        br_ = bw_ as CqlQuantity;
                    }
                    else
                    {
                        bool bz_ = bw_ is CqlInterval<CqlDateTime>;
                        if (bz_)
                        {
                            br_ = bw_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool ca_ = bw_ is CqlInterval<CqlQuantity>;
                            if (ca_)
                            {
                                br_ = bw_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                br_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> bs_ = QICoreCommon_4_0_000.Instance.toInterval(context, br_);
                CqlInterval<CqlDateTime> bt_ = this.Measurement_Period(context);
                CqlBoolean bu_ = context.Operators.Overlaps(bs_, bt_, "day");
                return bu_;
            }

            CqlBoolean bq_ = context.Operators.WhereAny<Procedure>(bo_, bp_);
            return bq_;
        }


        CqlBoolean j_() {
            CqlValueSet cb_ = this.Hospice_Diagnosis(context);
            IEnumerable<Condition> cc_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, cb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> cd_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, cb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> ce_ = context.Operators.Union<Condition>(cc_ as IEnumerable<Condition>, cd_ as IEnumerable<Condition>);
            IEnumerable<Condition> cf_ = Status_1_15_000.Instance.verified(context, ce_);

            bool? cg_(Condition HospiceCareDiagnosis) {
                CqlInterval<CqlDateTime> ci_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, HospiceCareDiagnosis);
                CqlInterval<CqlDateTime> cj_ = this.Measurement_Period(context);
                CqlBoolean ck_ = context.Operators.Overlaps(ci_, cj_, "day");
                return ck_;
            }

            CqlBoolean ch_ = context.Operators.WhereAny<Condition>(cf_, cg_);
            return ch_;
        }

        return e_
            /* CQL 'or' (27:3-35:5) */ || f_()
            /* CQL 'or' (27:3-39:5) */ || g_()
            /* CQL 'or' (27:3-42:5) */ || h_()
            /* CQL 'or' (27:3-45:5) */ || i_()
            /* CQL 'or' (27:3-49:5) */ || j_();
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private Hospice_6_18_000() {}

    public static Hospice_6_18_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "Hospice";
    public string Version => "6.18.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, QICoreCommon_4_0_000.Instance, Status_1_15_000.Instance];

    #endregion ILibrary Implementation

}
