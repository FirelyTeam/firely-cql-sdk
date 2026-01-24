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
using Hl7.Cql.Runtime.Internal;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "6.0.0.0")]
[CqlLibrary("Hospice", "6.18.000")]
public partial class Hospice_6_18_000 : ILibrary, ILibraryInternals, ISingleton<Hospice_6_18_000>
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

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        object a_ = context.ResolveParameter("Hospice-6.18.000", "Measurement Period", null);
        return (CqlInterval<CqlDateTime>)a_;
    }


    #endregion Parameters

    #region Functions and Expressions (2)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Has Hospice Services")]
    public bool? Has_Hospice_Services(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Hospice_Services, Has_Hospice_Services_Compute);

    private bool? Has_Hospice_Services_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> c_ = Status_1_15_000.Instance.isEncounterPerformed(context, b_);

        bool? d_(Encounter InpatientEncounter) {
            Encounter.HospitalizationComponent at_ = InpatientEncounter?.Hospitalization;
            CodeableConcept au_ = at_?.DischargeDisposition;
            CqlConcept av_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, au_);
            CqlCode aw_ = this.Discharge_to_home_for_hospice_care__procedure_(context);
            CqlConcept ax_ = context.Operators.ConvertCodeToConcept(aw_);
            bool? ay_ = context.Operators.Equivalent(av_, ax_);
            CodeableConcept ba_ = at_?.DischargeDisposition;
            CqlConcept bb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ba_);
            CqlCode bc_ = this.Discharge_to_healthcare_facility_for_hospice_care__procedure_(context);
            CqlConcept bd_ = context.Operators.ConvertCodeToConcept(bc_);
            bool? be_ = context.Operators.Equivalent(bb_, bd_);
            bool? bf_ = context.Operators.Or(ay_, be_);
            Period bg_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> bh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bg_);
            CqlDateTime bi_ = context.Operators.End(bh_);
            CqlInterval<CqlDateTime> bj_ = this.Measurement_Period(context);
            bool? bk_ = context.Operators.In<CqlDateTime>(bi_, bj_, "day");
            bool? bl_ = context.Operators.And(bf_, bk_);
            return bl_;
        }

        IEnumerable<Encounter> e_ = context.Operators.Where<Encounter>(c_, d_);
        bool? f_ = context.Operators.Exists<Encounter>(e_);
        CqlValueSet g_ = this.Hospice_Encounter(context);
        IEnumerable<Encounter> h_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> i_ = Status_1_15_000.Instance.isEncounterPerformed(context, h_);

        bool? j_(Encounter HospiceEncounter) {
            Period bm_ = HospiceEncounter?.Period;
            CqlInterval<CqlDateTime> bn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bm_);
            CqlInterval<CqlDateTime> bo_ = this.Measurement_Period(context);
            bool? bp_ = context.Operators.Overlaps(bn_, bo_, "day");
            return bp_;
        }

        IEnumerable<Encounter> k_ = context.Operators.Where<Encounter>(i_, j_);
        bool? l_ = context.Operators.Exists<Encounter>(k_);
        bool? m_ = context.Operators.Or(f_, l_);
        CqlCode n_ = this.Hospice_care__Minimum_Data_Set_(context);
        IEnumerable<CqlCode> o_ = context.Operators.ToList<CqlCode>(n_);
        IEnumerable<Observation> p_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, o_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
        IEnumerable<Observation> q_ = Status_1_15_000.Instance.isAssessmentPerformed(context, p_);

        bool? r_(Observation HospiceAssessment) {
            DataType bq_ = HospiceAssessment?.Value;
            object br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
            CqlCode bs_ = this.Yes__qualifier_value_(context);
            CqlConcept bt_ = context.Operators.ConvertCodeToConcept(bs_);
            bool? bu_ = context.Operators.Equivalent(br_ as CqlConcept, bt_);
            DataType bv_ = HospiceAssessment?.Effective;
            object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
            CqlInterval<CqlDateTime> bx_ = QICoreCommon_4_0_000.Instance.toInterval(context, bw_);
            CqlInterval<CqlDateTime> by_ = this.Measurement_Period(context);
            bool? bz_ = context.Operators.Overlaps(bx_, by_, "day");
            bool? ca_ = context.Operators.And(bu_, bz_);
            return ca_;
        }

        IEnumerable<Observation> s_ = context.Operators.Where<Observation>(q_, r_);
        bool? t_ = context.Operators.Exists<Observation>(s_);
        bool? u_ = context.Operators.Or(m_, t_);
        CqlValueSet v_ = this.Hospice_Care_Ambulatory(context);
        IEnumerable<ServiceRequest> w_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, v_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> x_ = Status_1_15_000.Instance.isInterventionOrder(context, w_);

        bool? y_(ServiceRequest HospiceOrder) {
            FhirDateTime cb_ = HospiceOrder?.AuthoredOnElement;
            CqlDateTime cc_ = context.Operators.Convert<CqlDateTime>(cb_);
            CqlInterval<CqlDateTime> cd_ = this.Measurement_Period(context);
            bool? ce_ = context.Operators.In<CqlDateTime>(cc_, cd_, "day");
            return ce_;
        }

        IEnumerable<ServiceRequest> z_ = context.Operators.Where<ServiceRequest>(x_, y_);
        bool? aa_ = context.Operators.Exists<ServiceRequest>(z_);
        bool? ab_ = context.Operators.Or(u_, aa_);
        IEnumerable<Procedure> ad_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, v_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> ae_ = Status_1_15_000.Instance.isInterventionPerformed(context, ad_);

        bool? af_(Procedure HospicePerformed) {

            object cf_() {

                bool cj_() {
                    DataType cn_ = HospicePerformed?.Performed;
                    object co_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cn_);
                    bool cp_ = co_ is CqlDateTime;
                    return cp_;
                }


                bool ck_() {
                    DataType cq_ = HospicePerformed?.Performed;
                    object cr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cq_);
                    bool cs_ = cr_ is CqlInterval<CqlDateTime>;
                    return cs_;
                }


                bool cl_() {
                    DataType ct_ = HospicePerformed?.Performed;
                    object cu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ct_);
                    bool cv_ = cu_ is CqlQuantity;
                    return cv_;
                }


                bool cm_() {
                    DataType cw_ = HospicePerformed?.Performed;
                    object cx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cw_);
                    bool cy_ = cx_ is CqlInterval<CqlQuantity>;
                    return cy_;
                }

                if (cj_())
                {
                    DataType cz_ = HospicePerformed?.Performed;
                    object da_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cz_);
                    return (da_ as CqlDateTime) as object;
                }
                else if (ck_())
                {
                    DataType db_ = HospicePerformed?.Performed;
                    object dc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, db_);
                    return (dc_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (cl_())
                {
                    DataType dd_ = HospicePerformed?.Performed;
                    object de_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dd_);
                    return (de_ as CqlQuantity) as object;
                }
                else if (cm_())
                {
                    DataType df_ = HospicePerformed?.Performed;
                    object dg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, df_);
                    return (dg_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> cg_ = QICoreCommon_4_0_000.Instance.toInterval(context, cf_());
            CqlInterval<CqlDateTime> ch_ = this.Measurement_Period(context);
            bool? ci_ = context.Operators.Overlaps(cg_, ch_, "day");
            return ci_;
        }

        IEnumerable<Procedure> ag_ = context.Operators.Where<Procedure>(ae_, af_);
        bool? ah_ = context.Operators.Exists<Procedure>(ag_);
        bool? ai_ = context.Operators.Or(ab_, ah_);
        CqlValueSet aj_ = this.Hospice_Diagnosis(context);
        IEnumerable<Condition> ak_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, aj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> am_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, aj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<object> an_ = context.Operators.Union<object>(ak_ as IEnumerable<object>, am_ as IEnumerable<object>);
        IEnumerable<object> ao_ = Status_1_15_000.Instance.verified(context, an_);

        bool? ap_(object HospiceCareDiagnosis) {
            CqlInterval<CqlDateTime> dh_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, HospiceCareDiagnosis);
            CqlInterval<CqlDateTime> di_ = this.Measurement_Period(context);
            bool? dj_ = context.Operators.Overlaps(dh_, di_, "day");
            return dj_;
        }

        IEnumerable<object> aq_ = context.Operators.Where<object>(ao_, ap_);
        bool? ar_ = context.Operators.Exists<object>(aq_);
        bool? as_ = context.Operators.Or(ai_, ar_);
        return as_;
    }


    #endregion Functions and Expressions

    #region Cache Index Fields (3)

    private int _cacheIndex_Measurement_Period = -1;
    private int _cacheIndex_Patient = -1;
    private int _cacheIndex_Has_Hospice_Services = -1;

    #endregion Cache Index Fields

    #region ILibraryInternals Implementation

    /// <summary>
    /// Initializes cache indices for this library's cached expressions.
    /// </summary>
    /// <param name="libraryInvocationSet">The library invocation set performing initialization.</param>
    /// <param name="startIndex">The starting index for cache field assignment.</param>
    /// <returns>The number of cache indices initialized (number of cached expressions in this library).</returns>
    int ILibraryInternals.InitializeCacheIndices(
        CqlLibraryInvocationSet libraryInvocationSet,
        int startIndex)
    {
        var index = startIndex;
        _cacheIndex_Measurement_Period = index++;
        _cacheIndex_Patient = index++;
        _cacheIndex_Has_Hospice_Services = index++;
        return index - startIndex;
    }

    #endregion ILibraryInternals Implementation

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
