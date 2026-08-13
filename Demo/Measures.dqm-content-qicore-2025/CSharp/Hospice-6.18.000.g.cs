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
            Encounter.HospitalizationComponent j_ = InpatientEncounter?.Hospitalization;
            CodeableConcept k_ = j_?.DischargeDisposition;
            CqlConcept l_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, k_);
            CqlCode m_ = this.Discharge_to_home_for_hospice_care__procedure_(context);
            CqlConcept n_ = context.Operators.ConvertCodeToConcept(m_);
            bool? o_ = context.Operators.Equivalent(l_, n_);
            bool? p_;
            // CQL 'or' (28:13-30:7): right operand skipped when left is true
            if (o_ is true)
            {
                p_ = true;
            }
            else
            {
                Encounter.HospitalizationComponent q_ = InpatientEncounter?.Hospitalization;
                CodeableConcept r_ = q_?.DischargeDisposition;
                CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, r_);
                CqlCode t_ = this.Discharge_to_healthcare_facility_for_hospice_care__procedure_(context);
                CqlConcept u_ = context.Operators.ConvertCodeToConcept(t_);
                bool? v_ = context.Operators.Equivalent(s_, u_);
                p_ = o_ | v_;
            }
            // CQL 'and' (28:7-31:77): right operand skipped when left is false
            if (p_ is false)
            {
                return false;
            }
            else
            {
                Period w_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, w_);
                CqlDateTime y_ = context.Operators.End(x_);
                CqlInterval<CqlDateTime> z_ = this.Measurement_Period(context);
                bool? aa_ = context.Operators.In<CqlDateTime>(y_, z_, "day");
                return p_ & aa_;
            }
        }

        bool? e_ = context.Operators.WhereAny<Encounter>(c_, d_);
        bool? f_;
        // CQL 'or' (27:3-35:5): right operand skipped when left is true
        if (e_ is true)
        {
            f_ = true;
        }
        else
        {
            CqlValueSet ab_ = this.Hospice_Encounter(context);
            IEnumerable<Encounter> ac_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ab_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            IEnumerable<Encounter> ad_ = Status_1_15_000.Instance.isEncounterPerformed(context, ac_);

            bool? ae_(Encounter HospiceEncounter) {
                Period ag_ = HospiceEncounter?.Period;
                CqlInterval<CqlDateTime> ah_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ag_);
                CqlInterval<CqlDateTime> ai_ = this.Measurement_Period(context);
                bool? aj_ = context.Operators.Overlaps(ah_, ai_, "day");
                return aj_;
            }

            bool? af_ = context.Operators.WhereAny<Encounter>(ad_, ae_);
            f_ = e_ | af_;
        }
        bool? g_;
        // CQL 'or' (27:3-39:5): right operand skipped when left is true
        if (f_ is true)
        {
            g_ = true;
        }
        else
        {
            CqlCode ak_ = this.Hospice_care__Minimum_Data_Set_(context);
            IEnumerable<CqlCode> al_ = context.Operators.ToList<CqlCode>(ak_);
            IEnumerable<Observation> am_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, al_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
            IEnumerable<Observation> an_ = Status_1_15_000.Instance.isAssessmentPerformed(context, am_);

            bool? ao_(Observation HospiceAssessment) {
                DataType aq_ = HospiceAssessment?.Value;
                object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                CqlCode as_ = this.Yes__qualifier_value_(context);
                CqlConcept at_ = context.Operators.ConvertCodeToConcept(as_);
                bool? au_ = context.Operators.Equivalent(ar_ as CqlConcept, at_);
                // CQL 'and' (37:9-38:91): right operand skipped when left is false
                if (au_ is false)
                {
                    return false;
                }
                else
                {
                    DataType av_ = HospiceAssessment?.Effective;
                    object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                    CqlInterval<CqlDateTime> ax_ = QICoreCommon_4_0_000.Instance.toInterval(context, aw_);
                    CqlInterval<CqlDateTime> ay_ = this.Measurement_Period(context);
                    bool? az_ = context.Operators.Overlaps(ax_, ay_, "day");
                    return au_ & az_;
                }
            }

            bool? ap_ = context.Operators.WhereAny<Observation>(an_, ao_);
            g_ = f_ | ap_;
        }
        bool? h_;
        // CQL 'or' (27:3-42:5): right operand skipped when left is true
        if (g_ is true)
        {
            h_ = true;
        }
        else
        {
            CqlValueSet ba_ = this.Hospice_Care_Ambulatory(context);
            IEnumerable<ServiceRequest> bb_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, ba_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
            IEnumerable<ServiceRequest> bc_ = Status_1_15_000.Instance.isInterventionOrder(context, bb_);

            bool? bd_(ServiceRequest HospiceOrder) {
                FhirDateTime bf_ = HospiceOrder?.AuthoredOnElement;
                CqlDateTime bg_ = context.Operators.Convert<CqlDateTime>(bf_);
                CqlInterval<CqlDateTime> bh_ = this.Measurement_Period(context);
                bool? bi_ = context.Operators.In<CqlDateTime>(bg_, bh_, "day");
                return bi_;
            }

            bool? be_ = context.Operators.WhereAny<ServiceRequest>(bc_, bd_);
            h_ = g_ | be_;
        }
        bool? i_;
        // CQL 'or' (27:3-45:5): right operand skipped when left is true
        if (h_ is true)
        {
            i_ = true;
        }
        else
        {
            CqlValueSet bj_ = this.Hospice_Care_Ambulatory(context);
            IEnumerable<Procedure> bk_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, bj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            IEnumerable<Procedure> bl_ = Status_1_15_000.Instance.isInterventionPerformed(context, bk_);

            bool? bm_(Procedure HospicePerformed) {
                object bo_;
                DataType bs_ = HospicePerformed?.Performed;
                object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                bool bu_ = bt_ is CqlDateTime;
                if (bu_)
                {
                    DataType bv_ = HospicePerformed?.Performed;
                    object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                    bo_ = bw_ as CqlDateTime;
                }
                else
                {
                    DataType bx_ = HospicePerformed?.Performed;
                    object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                    bool bz_ = by_ is CqlQuantity;
                    if (bz_)
                    {
                        DataType ca_ = HospicePerformed?.Performed;
                        object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                        bo_ = cb_ as CqlQuantity;
                    }
                    else
                    {
                        DataType cc_ = HospicePerformed?.Performed;
                        object cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                        bool ce_ = cd_ is CqlInterval<CqlDateTime>;
                        if (ce_)
                        {
                            DataType cf_ = HospicePerformed?.Performed;
                            object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                            bo_ = cg_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            DataType ch_ = HospicePerformed?.Performed;
                            object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                            bool cj_ = ci_ is CqlInterval<CqlQuantity>;
                            if (cj_)
                            {
                                DataType ck_ = HospicePerformed?.Performed;
                                object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                                bo_ = cl_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                bo_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> bp_ = QICoreCommon_4_0_000.Instance.toInterval(context, bo_);
                CqlInterval<CqlDateTime> bq_ = this.Measurement_Period(context);
                bool? br_ = context.Operators.Overlaps(bp_, bq_, "day");
                return br_;
            }

            bool? bn_ = context.Operators.WhereAny<Procedure>(bl_, bm_);
            i_ = h_ | bn_;
        }
        // CQL 'or' (27:3-49:5): right operand skipped when left is true
        if (i_ is true)
        {
            return true;
        }
        else
        {
            CqlValueSet cm_ = this.Hospice_Diagnosis(context);
            IEnumerable<Condition> cn_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, cm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> co_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, cm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> cp_ = context.Operators.Union<Condition>(cn_ as IEnumerable<Condition>, co_ as IEnumerable<Condition>);
            IEnumerable<Condition> cq_ = Status_1_15_000.Instance.verified(context, cp_);

            bool? cr_(Condition HospiceCareDiagnosis) {
                CqlInterval<CqlDateTime> ct_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, HospiceCareDiagnosis);
                CqlInterval<CqlDateTime> cu_ = this.Measurement_Period(context);
                bool? cv_ = context.Operators.Overlaps(ct_, cu_, "day");
                return cv_;
            }

            bool? cs_ = context.Operators.WhereAny<Condition>(cq_, cr_);
            return i_ | cs_;
        }
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
