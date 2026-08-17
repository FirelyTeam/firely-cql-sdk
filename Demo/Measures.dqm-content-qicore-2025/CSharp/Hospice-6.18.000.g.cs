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
                CqlCode q_ = this.Discharge_to_healthcare_facility_for_hospice_care__procedure_(context);
                CqlConcept r_ = context.Operators.ConvertCodeToConcept(q_);
                bool? s_ = context.Operators.Equivalent(l_, r_);
                p_ = o_ | s_;
            }
            // CQL 'and' (28:7-31:77): right operand skipped when left is false
            if (p_ is false)
            {
                return false;
            }
            else
            {
                Period t_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> u_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, t_);
                CqlDateTime v_ = context.Operators.End(u_);
                CqlInterval<CqlDateTime> w_ = this.Measurement_Period(context);
                bool? x_ = context.Operators.In<CqlDateTime>(v_, w_, "day");
                return p_ & x_;
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
            CqlValueSet y_ = this.Hospice_Encounter(context);
            IEnumerable<Encounter> z_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, y_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            IEnumerable<Encounter> aa_ = Status_1_15_000.Instance.isEncounterPerformed(context, z_);

            bool? ab_(Encounter HospiceEncounter) {
                Period ad_ = HospiceEncounter?.Period;
                CqlInterval<CqlDateTime> ae_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ad_);
                CqlInterval<CqlDateTime> af_ = this.Measurement_Period(context);
                bool? ag_ = context.Operators.Overlaps(ae_, af_, "day");
                return ag_;
            }

            bool? ac_ = context.Operators.WhereAny<Encounter>(aa_, ab_);
            f_ = e_ | ac_;
        }
        bool? g_;
        // CQL 'or' (27:3-39:5): right operand skipped when left is true
        if (f_ is true)
        {
            g_ = true;
        }
        else
        {
            CqlCode ah_ = this.Hospice_care__Minimum_Data_Set_(context);
            IEnumerable<CqlCode> ai_ = context.Operators.ToList<CqlCode>(ah_);
            IEnumerable<Observation> aj_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, ai_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
            IEnumerable<Observation> ak_ = Status_1_15_000.Instance.isAssessmentPerformed(context, aj_);

            bool? al_(Observation HospiceAssessment) {
                DataType an_ = HospiceAssessment?.Value;
                object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                CqlCode ap_ = this.Yes__qualifier_value_(context);
                CqlConcept aq_ = context.Operators.ConvertCodeToConcept(ap_);
                bool? ar_ = context.Operators.Equivalent(ao_ as CqlConcept, aq_);
                // CQL 'and' (37:9-38:91): right operand skipped when left is false
                if (ar_ is false)
                {
                    return false;
                }
                else
                {
                    DataType as_ = HospiceAssessment?.Effective;
                    object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                    CqlInterval<CqlDateTime> au_ = QICoreCommon_4_0_000.Instance.toInterval(context, at_);
                    CqlInterval<CqlDateTime> av_ = this.Measurement_Period(context);
                    bool? aw_ = context.Operators.Overlaps(au_, av_, "day");
                    return ar_ & aw_;
                }
            }

            bool? am_ = context.Operators.WhereAny<Observation>(ak_, al_);
            g_ = f_ | am_;
        }
        bool? h_;
        // CQL 'or' (27:3-42:5): right operand skipped when left is true
        if (g_ is true)
        {
            h_ = true;
        }
        else
        {
            CqlValueSet ax_ = this.Hospice_Care_Ambulatory(context);
            IEnumerable<ServiceRequest> ay_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, ax_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
            IEnumerable<ServiceRequest> az_ = Status_1_15_000.Instance.isInterventionOrder(context, ay_);

            bool? ba_(ServiceRequest HospiceOrder) {
                FhirDateTime bc_ = HospiceOrder?.AuthoredOnElement;
                CqlDateTime bd_ = context.Operators.Convert<CqlDateTime>(bc_);
                CqlInterval<CqlDateTime> be_ = this.Measurement_Period(context);
                bool? bf_ = context.Operators.In<CqlDateTime>(bd_, be_, "day");
                return bf_;
            }

            bool? bb_ = context.Operators.WhereAny<ServiceRequest>(az_, ba_);
            h_ = g_ | bb_;
        }
        bool? i_;
        // CQL 'or' (27:3-45:5): right operand skipped when left is true
        if (h_ is true)
        {
            i_ = true;
        }
        else
        {
            CqlValueSet bg_ = this.Hospice_Care_Ambulatory(context);
            IEnumerable<Procedure> bh_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, bg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            IEnumerable<Procedure> bi_ = Status_1_15_000.Instance.isInterventionPerformed(context, bh_);

            bool? bj_(Procedure HospicePerformed) {
                object bl_;
                DataType bp_ = HospicePerformed?.Performed;
                object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                bool br_ = bq_ is CqlDateTime;
                if (br_)
                {
                    bl_ = bq_ as CqlDateTime;
                }
                else
                {
                    bool bs_ = bq_ is CqlQuantity;
                    if (bs_)
                    {
                        bl_ = bq_ as CqlQuantity;
                    }
                    else
                    {
                        bool bt_ = bq_ is CqlInterval<CqlDateTime>;
                        if (bt_)
                        {
                            bl_ = bq_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool bu_ = bq_ is CqlInterval<CqlQuantity>;
                            if (bu_)
                            {
                                bl_ = bq_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                bl_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> bm_ = QICoreCommon_4_0_000.Instance.toInterval(context, bl_);
                CqlInterval<CqlDateTime> bn_ = this.Measurement_Period(context);
                bool? bo_ = context.Operators.Overlaps(bm_, bn_, "day");
                return bo_;
            }

            bool? bk_ = context.Operators.WhereAny<Procedure>(bi_, bj_);
            i_ = h_ | bk_;
        }
        // CQL 'or' (27:3-49:5): right operand skipped when left is true
        if (i_ is true)
        {
            return true;
        }
        else
        {
            CqlValueSet bv_ = this.Hospice_Diagnosis(context);
            IEnumerable<Condition> bw_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> bx_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> by_ = context.Operators.Union<Condition>(bw_ as IEnumerable<Condition>, bx_ as IEnumerable<Condition>);
            IEnumerable<Condition> bz_ = Status_1_15_000.Instance.verified(context, by_);

            bool? ca_(Condition HospiceCareDiagnosis) {
                CqlInterval<CqlDateTime> cc_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, HospiceCareDiagnosis);
                CqlInterval<CqlDateTime> cd_ = this.Measurement_Period(context);
                bool? ce_ = context.Operators.Overlaps(cc_, cd_, "day");
                return ce_;
            }

            bool? cb_ = context.Operators.WhereAny<Condition>(bz_, ca_);
            return i_ | cb_;
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
