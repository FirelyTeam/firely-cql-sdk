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
[CqlLibrary("Hospice", "6.12.000")]
public partial class Hospice_6_12_000 : ILibrary, ISingleton<Hospice_6_12_000>
{
    private Hospice_6_12_000() {}

    public static Hospice_6_12_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "Hospice";
    public string Version => "6.12.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, QICoreCommon_2_1_000.Instance, Status_1_8_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

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

    #region Codes

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

    #region CodeSystems

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

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object a_ = context.ResolveParameter("Hospice-6.12.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)a_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

        return b_;
    }


    [CqlExpressionDefinition("Has Hospice Services")]
    public bool? Has_Hospice_Services(CqlContext context)
    {
        CqlValueSet a_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> c_ = Status_1_8_000.Instance.isEncounterPerformed(context, b_);
        bool? d_(Encounter InpatientEncounter)
        {
            Encounter.HospitalizationComponent ap_ = InpatientEncounter?.Hospitalization;
            CodeableConcept aq_ = ap_?.DischargeDisposition;
            CqlConcept ar_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, aq_);
            CqlCode as_ = this.Discharge_to_home_for_hospice_care__procedure_(context);
            CqlConcept at_ = context.Operators.ConvertCodeToConcept(as_);
            bool? au_ = context.Operators.Equivalent(ar_, at_);
            CodeableConcept aw_ = ap_?.DischargeDisposition;
            CqlConcept ax_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, aw_);
            CqlCode ay_ = this.Discharge_to_healthcare_facility_for_hospice_care__procedure_(context);
            CqlConcept az_ = context.Operators.ConvertCodeToConcept(ay_);
            bool? ba_ = context.Operators.Equivalent(ax_, az_);
            bool? bb_ = context.Operators.Or(au_, ba_);
            Period bc_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> bd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bc_);
            CqlInterval<CqlDateTime> be_ = QICoreCommon_2_1_000.Instance.toInterval(context, bd_ as object);
            CqlDateTime bf_ = context.Operators.End(be_);
            CqlInterval<CqlDateTime> bg_ = this.Measurement_Period(context);
            bool? bh_ = context.Operators.In<CqlDateTime>(bf_, bg_, "day");
            bool? bi_ = context.Operators.And(bb_, bh_);

            return bi_;
        };
        IEnumerable<Encounter> e_ = context.Operators.Where<Encounter>(c_, d_);
        bool? f_ = context.Operators.Exists<Encounter>(e_);
        CqlValueSet g_ = this.Hospice_Encounter(context);
        IEnumerable<Encounter> h_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> i_ = Status_1_8_000.Instance.isEncounterPerformed(context, h_);
        bool? j_(Encounter HospiceEncounter)
        {
            Period bj_ = HospiceEncounter?.Period;
            CqlInterval<CqlDateTime> bk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bj_);
            CqlInterval<CqlDateTime> bl_ = QICoreCommon_2_1_000.Instance.toInterval(context, bk_ as object);
            CqlInterval<CqlDateTime> bm_ = this.Measurement_Period(context);
            bool? bn_ = context.Operators.Overlaps(bl_, bm_, "day");

            return bn_;
        };
        IEnumerable<Encounter> k_ = context.Operators.Where<Encounter>(i_, j_);
        bool? l_ = context.Operators.Exists<Encounter>(k_);
        bool? m_ = context.Operators.Or(f_, l_);
        CqlCode n_ = this.Hospice_care__Minimum_Data_Set_(context);
        IEnumerable<CqlCode> o_ = context.Operators.ToList<CqlCode>(n_);
        IEnumerable<Observation> p_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, o_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> q_ = Status_1_8_000.Instance.isAssessmentPerformed(context, p_);
        bool? r_(Observation HospiceAssessment)
        {
            DataType bo_ = HospiceAssessment?.Value;
            object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
            CqlCode bq_ = this.Yes__qualifier_value_(context);
            CqlConcept br_ = context.Operators.ConvertCodeToConcept(bq_);
            bool? bs_ = context.Operators.Equivalent(bp_ as CqlConcept, br_);
            DataType bt_ = HospiceAssessment?.Effective;
            object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
            CqlInterval<CqlDateTime> bv_ = QICoreCommon_2_1_000.Instance.toInterval(context, bu_);
            CqlInterval<CqlDateTime> bw_ = this.Measurement_Period(context);
            bool? bx_ = context.Operators.Overlaps(bv_, bw_, "day");
            bool? by_ = context.Operators.And(bs_, bx_);

            return by_;
        };
        IEnumerable<Observation> s_ = context.Operators.Where<Observation>(q_, r_);
        bool? t_ = context.Operators.Exists<Observation>(s_);
        bool? u_ = context.Operators.Or(m_, t_);
        CqlValueSet v_ = this.Hospice_Care_Ambulatory(context);
        IEnumerable<ServiceRequest> w_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, v_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> x_ = Status_1_8_000.Instance.isInterventionOrder(context, w_);
        bool? y_(ServiceRequest HospiceOrder)
        {
            CqlInterval<CqlDateTime> bz_ = this.Measurement_Period(context);
            FhirDateTime ca_ = HospiceOrder?.AuthoredOnElement;
            CqlDateTime cb_ = context.Operators.Convert<CqlDateTime>(ca_);
            CqlInterval<CqlDateTime> cc_ = QICoreCommon_2_1_000.Instance.toInterval(context, cb_ as object);
            bool? cd_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(bz_, cc_, "day");

            return cd_;
        };
        IEnumerable<ServiceRequest> z_ = context.Operators.Where<ServiceRequest>(x_, y_);
        bool? aa_ = context.Operators.Exists<ServiceRequest>(z_);
        bool? ab_ = context.Operators.Or(u_, aa_);
        IEnumerable<Procedure> ad_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, v_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> ae_ = Status_1_8_000.Instance.isInterventionPerformed(context, ad_);
        bool? af_(Procedure HospicePerformed)
        {
            DataType ce_ = HospicePerformed?.Performed;
            object cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);
            CqlInterval<CqlDateTime> cg_ = QICoreCommon_2_1_000.Instance.toInterval(context, cf_);
            CqlInterval<CqlDateTime> ch_ = this.Measurement_Period(context);
            bool? ci_ = context.Operators.Overlaps(cg_, ch_, "day");

            return ci_;
        };
        IEnumerable<Procedure> ag_ = context.Operators.Where<Procedure>(ae_, af_);
        bool? ah_ = context.Operators.Exists<Procedure>(ag_);
        bool? ai_ = context.Operators.Or(ab_, ah_);
        CqlValueSet aj_ = this.Hospice_Diagnosis(context);
        IEnumerable<Condition> ak_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, aj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? al_(Condition HospiceCareDiagnosis)
        {
            CqlInterval<CqlDateTime> cj_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HospiceCareDiagnosis);
            CqlInterval<CqlDateTime> ck_ = this.Measurement_Period(context);
            bool? cl_ = context.Operators.Overlaps(cj_, ck_, "day");

            return cl_;
        };
        IEnumerable<Condition> am_ = context.Operators.Where<Condition>(ak_, al_);
        bool? an_ = context.Operators.Exists<Condition>(am_);
        bool? ao_ = context.Operators.Or(ai_, an_);

        return ao_;
    }


    #endregion Expressions

}
