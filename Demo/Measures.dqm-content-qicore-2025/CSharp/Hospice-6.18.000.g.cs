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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.8.0")]
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
            Encounter.HospitalizationComponent al_ = InpatientEncounter?.Hospitalization;
            CodeableConcept am_ = al_?.DischargeDisposition;
            CqlConcept an_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, am_);
            CqlCode ao_ = this.Discharge_to_home_for_hospice_care__procedure_(context);
            CqlConcept ap_ = context.Operators.ConvertCodeToConcept(ao_);
            CqlBoolean aq_ = context.Operators.Equivalent(an_, ap_);
            CqlCode ar_ = this.Discharge_to_healthcare_facility_for_hospice_care__procedure_(context);
            CqlConcept as_ = context.Operators.ConvertCodeToConcept(ar_);
            CqlBoolean at_ = context.Operators.Equivalent(an_, as_);
            CqlBoolean au_ = at_;
            Period av_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> aw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, av_);
            CqlDateTime ax_ = context.Operators.End(aw_);
            CqlInterval<CqlDateTime> ay_ = this.Measurement_Period(context);
            CqlBoolean az_ = context.Operators.In<CqlDateTime>(ax_, ay_, "day");
            CqlBoolean ba_ = az_;
            return (aq_
                /* CQL 'or' (28:13-30:7) */ || au_)
                /* CQL 'and' (28:7-31:77) */ && ba_;
        }

        CqlBoolean e_ = context.Operators.WhereAny<Encounter>(c_, d_);
        CqlValueSet f_ = this.Hospice_Encounter(context);
        IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> h_ = Status_1_15_000.Instance.isEncounterPerformed(context, g_);

        bool? i_(Encounter HospiceEncounter) {
            Period bb_ = HospiceEncounter?.Period;
            CqlInterval<CqlDateTime> bc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bb_);
            CqlInterval<CqlDateTime> bd_ = this.Measurement_Period(context);
            CqlBoolean be_ = context.Operators.Overlaps(bc_, bd_, "day");
            return be_;
        }

        CqlBoolean j_ = context.Operators.WhereAny<Encounter>(h_, i_);
        CqlBoolean k_ = j_;
        CqlCode l_ = this.Hospice_care__Minimum_Data_Set_(context);
        IEnumerable<CqlCode> m_ = context.Operators.ToList<CqlCode>(l_);
        IEnumerable<Observation> n_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, m_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
        IEnumerable<Observation> o_ = Status_1_15_000.Instance.isAssessmentPerformed(context, n_);

        bool? p_(Observation HospiceAssessment) {
            DataType bf_ = HospiceAssessment?.Value;
            object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
            CqlCode bh_ = this.Yes__qualifier_value_(context);
            CqlConcept bi_ = context.Operators.ConvertCodeToConcept(bh_);
            CqlBoolean bj_ = context.Operators.Equivalent(bg_ as CqlConcept, bi_);
            DataType bk_ = HospiceAssessment?.Effective;
            object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
            CqlInterval<CqlDateTime> bm_ = QICoreCommon_4_0_000.Instance.toInterval(context, bl_);
            CqlInterval<CqlDateTime> bn_ = this.Measurement_Period(context);
            CqlBoolean bo_ = context.Operators.Overlaps(bm_, bn_, "day");
            CqlBoolean bp_ = bo_;
            return bj_
                /* CQL 'and' (37:9-38:91) */ && bp_;
        }

        CqlBoolean q_ = context.Operators.WhereAny<Observation>(o_, p_);
        CqlBoolean r_ = q_;
        CqlValueSet s_ = this.Hospice_Care_Ambulatory(context);
        IEnumerable<ServiceRequest> t_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, s_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> u_ = Status_1_15_000.Instance.isInterventionOrder(context, t_);

        bool? v_(ServiceRequest HospiceOrder) {
            FhirDateTime bq_ = HospiceOrder?.AuthoredOnElement;
            CqlDateTime br_ = context.Operators.Convert<CqlDateTime>(bq_);
            CqlInterval<CqlDateTime> bs_ = this.Measurement_Period(context);
            CqlBoolean bt_ = context.Operators.In<CqlDateTime>(br_, bs_, "day");
            return bt_;
        }

        CqlBoolean w_ = context.Operators.WhereAny<ServiceRequest>(u_, v_);
        CqlBoolean x_ = w_;
        IEnumerable<Procedure> y_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, s_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> z_ = Status_1_15_000.Instance.isInterventionPerformed(context, y_);

        bool? aa_(Procedure HospicePerformed) {
            object bu_;
            DataType by_ = HospicePerformed?.Performed;
            object bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);
            bool ca_ = bz_ is CqlDateTime;
            if (ca_)
            {
                bu_ = bz_ as CqlDateTime;
            }
            else
            {
                bool cb_ = bz_ is CqlQuantity;
                if (cb_)
                {
                    bu_ = bz_ as CqlQuantity;
                }
                else
                {
                    bool cc_ = bz_ is CqlInterval<CqlDateTime>;
                    if (cc_)
                    {
                        bu_ = bz_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool cd_ = bz_ is CqlInterval<CqlQuantity>;
                        if (cd_)
                        {
                            bu_ = bz_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            bu_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> bv_ = QICoreCommon_4_0_000.Instance.toInterval(context, bu_);
            CqlInterval<CqlDateTime> bw_ = this.Measurement_Period(context);
            CqlBoolean bx_ = context.Operators.Overlaps(bv_, bw_, "day");
            return bx_;
        }

        CqlBoolean ab_ = context.Operators.WhereAny<Procedure>(z_, aa_);
        CqlBoolean ac_ = ab_;
        CqlValueSet ad_ = this.Hospice_Diagnosis(context);
        IEnumerable<Condition> ae_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ad_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> af_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ad_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> ag_ = context.Operators.Union<Condition>(ae_ as IEnumerable<Condition>, af_ as IEnumerable<Condition>);
        IEnumerable<Condition> ah_ = Status_1_15_000.Instance.verified(context, ag_);

        bool? ai_(Condition HospiceCareDiagnosis) {
            CqlInterval<CqlDateTime> ce_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, HospiceCareDiagnosis);
            CqlInterval<CqlDateTime> cf_ = this.Measurement_Period(context);
            CqlBoolean cg_ = context.Operators.Overlaps(ce_, cf_, "day");
            return cg_;
        }

        CqlBoolean aj_ = context.Operators.WhereAny<Condition>(ah_, ai_);
        CqlBoolean ak_ = aj_;
        return e_
            /* CQL 'or' (27:3-35:5) */ || k_
            /* CQL 'or' (27:3-39:5) */ || r_
            /* CQL 'or' (27:3-42:5) */ || x_
            /* CQL 'or' (27:3-45:5) */ || ac_
            /* CQL 'or' (27:3-49:5) */ || ak_;
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
