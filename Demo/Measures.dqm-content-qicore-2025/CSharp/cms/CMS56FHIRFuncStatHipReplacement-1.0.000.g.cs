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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.1.0")]
[CqlLibrary("CMS56FHIRFuncStatHipReplacement", "1.0.000")]
public partial class CMS56FHIRFuncStatHipReplacement_1_0_000 : ILibrary, ISingleton<CMS56FHIRFuncStatHipReplacement_1_0_000>
{
    #region ValueSets (10)

    [CqlValueSetDefinition("Lower Body Fractures Excluding Ankle and Foot", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1178", valueSetVersion: null)]
    public CqlValueSet Lower_Body_Fractures_Excluding_Ankle_and_Foot(CqlContext _) => _Lower_Body_Fractures_Excluding_Ankle_and_Foot;
    private static readonly CqlValueSet _Lower_Body_Fractures_Excluding_Ankle_and_Foot = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1178", null);

    [CqlValueSetDefinition("Malignant Neoplasms of Lower and Unspecified Limbs", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1180", valueSetVersion: null)]
    public CqlValueSet Malignant_Neoplasms_of_Lower_and_Unspecified_Limbs(CqlContext _) => _Malignant_Neoplasms_of_Lower_and_Unspecified_Limbs;
    private static readonly CqlValueSet _Malignant_Neoplasms_of_Lower_and_Unspecified_Limbs = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1180", null);

    [CqlValueSetDefinition("Mechanical Complications Excluding Upper Body", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1182", valueSetVersion: null)]
    public CqlValueSet Mechanical_Complications_Excluding_Upper_Body(CqlContext _) => _Mechanical_Complications_Excluding_Upper_Body;
    private static readonly CqlValueSet _Mechanical_Complications_Excluding_Upper_Body = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1182", null);

    [CqlValueSetDefinition("Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext _) => _Office_Visit;
    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlValueSetDefinition("Virtual Encounter", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", valueSetVersion: null)]
    public CqlValueSet Virtual_Encounter(CqlContext _) => _Virtual_Encounter;
    private static readonly CqlValueSet _Virtual_Encounter = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", null);

    [CqlValueSetDefinition("Outpatient Consultation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", valueSetVersion: null)]
    public CqlValueSet Outpatient_Consultation(CqlContext _) => _Outpatient_Consultation;
    private static readonly CqlValueSet _Outpatient_Consultation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", null);

    [CqlValueSetDefinition("Partial Arthroplasty of Hip", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1184", valueSetVersion: null)]
    public CqlValueSet Partial_Arthroplasty_of_Hip(CqlContext _) => _Partial_Arthroplasty_of_Hip;
    private static readonly CqlValueSet _Partial_Arthroplasty_of_Hip = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1184", null);

    [CqlValueSetDefinition("Primary THA Procedure", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1006", valueSetVersion: null)]
    public CqlValueSet Primary_THA_Procedure(CqlContext _) => _Primary_THA_Procedure;
    private static readonly CqlValueSet _Primary_THA_Procedure = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1006", null);

    [CqlValueSetDefinition("Removal, Revision and Supplement Procedures of the Lower Body and Spine", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1189", valueSetVersion: null)]
    public CqlValueSet Removal__Revision_and_Supplement_Procedures_of_the_Lower_Body_and_Spine(CqlContext _) => _Removal__Revision_and_Supplement_Procedures_of_the_Lower_Body_and_Spine;
    private static readonly CqlValueSet _Removal__Revision_and_Supplement_Procedures_of_the_Lower_Body_and_Spine = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1189", null);

    [CqlValueSetDefinition("Telephone Visits", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", valueSetVersion: null)]
    public CqlValueSet Telephone_Visits(CqlContext _) => _Telephone_Visits;
    private static readonly CqlValueSet _Telephone_Visits = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    #endregion ValueSets

    #region Codes (15)

    [CqlCodeDefinition("Activities of daily living score [HOOS]", codeId: "72095-3", codeSystem: "http://loinc.org")]
    public CqlCode Activities_of_daily_living_score__HOOS_(CqlContext _) => _Activities_of_daily_living_score__HOOS_;
    private static readonly CqlCode _Activities_of_daily_living_score__HOOS_ = new CqlCode("72095-3", "http://loinc.org");

    [CqlCodeDefinition("Dead (finding)", codeId: "419099009", codeSystem: "http://snomed.info/sct")]
    public CqlCode Dead__finding_(CqlContext _) => _Dead__finding_;
    private static readonly CqlCode _Dead__finding_ = new CqlCode("419099009", "http://snomed.info/sct");

    [CqlCodeDefinition("Pain score [HOOS]", codeId: "72097-9", codeSystem: "http://loinc.org")]
    public CqlCode Pain_score__HOOS_(CqlContext _) => _Pain_score__HOOS_;
    private static readonly CqlCode _Pain_score__HOOS_ = new CqlCode("72097-9", "http://loinc.org");

    [CqlCodeDefinition("Postoperative follow-up visit, normally included in the surgical package, to indicate that an evaluation and management service was performed during a postoperative period for a reason(s) related to the original procedure", codeId: "99024", codeSystem: "http://www.ama-assn.org/go/cpt")]
    public CqlCode Postoperative_follow_up_visit__normally_included_in_the_surgical_package__to_indicate_that_an_evaluation_and_management_service_was_performed_during_a_postoperative_period_for_a_reason_s__related_to_the_original_procedure(CqlContext _) => _Postoperative_follow_up_visit__normally_included_in_the_surgical_package__to_indicate_that_an_evaluation_and_management_service_was_performed_during_a_postoperative_period_for_a_reason_s__related_to_the_original_procedure;
    private static readonly CqlCode _Postoperative_follow_up_visit__normally_included_in_the_surgical_package__to_indicate_that_an_evaluation_and_management_service_was_performed_during_a_postoperative_period_for_a_reason_s__related_to_the_original_procedure = new CqlCode("99024", "http://www.ama-assn.org/go/cpt");

    [CqlCodeDefinition("PROMIS-10 Global Mental Health (GMH) score T-score", codeId: "71969-0", codeSystem: "http://loinc.org")]
    public CqlCode PROMIS_10_Global_Mental_Health__GMH__score_T_score(CqlContext _) => _PROMIS_10_Global_Mental_Health__GMH__score_T_score;
    private static readonly CqlCode _PROMIS_10_Global_Mental_Health__GMH__score_T_score = new CqlCode("71969-0", "http://loinc.org");

    [CqlCodeDefinition("PROMIS-10 Global Physical Health (GPH) score T-score", codeId: "71971-6", codeSystem: "http://loinc.org")]
    public CqlCode PROMIS_10_Global_Physical_Health__GPH__score_T_score(CqlContext _) => _PROMIS_10_Global_Physical_Health__GPH__score_T_score;
    private static readonly CqlCode _PROMIS_10_Global_Physical_Health__GPH__score_T_score = new CqlCode("71971-6", "http://loinc.org");

    [CqlCodeDefinition("Quality of life score [HOOS]", codeId: "72093-8", codeSystem: "http://loinc.org")]
    public CqlCode Quality_of_life_score__HOOS_(CqlContext _) => _Quality_of_life_score__HOOS_;
    private static readonly CqlCode _Quality_of_life_score__HOOS_ = new CqlCode("72093-8", "http://loinc.org");

    [CqlCodeDefinition("Severe cognitive impairment (finding)", codeId: "702956004", codeSystem: "http://snomed.info/sct")]
    public CqlCode Severe_cognitive_impairment__finding_(CqlContext _) => _Severe_cognitive_impairment__finding_;
    private static readonly CqlCode _Severe_cognitive_impairment__finding_ = new CqlCode("702956004", "http://snomed.info/sct");

    [CqlCodeDefinition("Sport-recreation score [HOOS]", codeId: "72094-6", codeSystem: "http://loinc.org")]
    public CqlCode Sport_recreation_score__HOOS_(CqlContext _) => _Sport_recreation_score__HOOS_;
    private static readonly CqlCode _Sport_recreation_score__HOOS_ = new CqlCode("72094-6", "http://loinc.org");

    [CqlCodeDefinition("Symptoms score [HOOS]", codeId: "72096-1", codeSystem: "http://loinc.org")]
    public CqlCode Symptoms_score__HOOS_(CqlContext _) => _Symptoms_score__HOOS_;
    private static readonly CqlCode _Symptoms_score__HOOS_ = new CqlCode("72096-1", "http://loinc.org");

    [CqlCodeDefinition("Total interval score [HOOSJR]", codeId: "82323-7", codeSystem: "http://loinc.org")]
    public CqlCode Total_interval_score__HOOSJR_(CqlContext _) => _Total_interval_score__HOOSJR_;
    private static readonly CqlCode _Total_interval_score__HOOSJR_ = new CqlCode("82323-7", "http://loinc.org");

    [CqlCodeDefinition("VR-12 Mental component summary (MCS) score - oblique method T-score", codeId: "72026-8", codeSystem: "http://loinc.org")]
    public CqlCode VR_12_Mental_component_summary__MCS__score___oblique_method_T_score(CqlContext _) => _VR_12_Mental_component_summary__MCS__score___oblique_method_T_score;
    private static readonly CqlCode _VR_12_Mental_component_summary__MCS__score___oblique_method_T_score = new CqlCode("72026-8", "http://loinc.org");

    [CqlCodeDefinition("VR-12 Mental component summary (MCS) score - orthogonal method T-score", codeId: "72028-4", codeSystem: "http://loinc.org")]
    public CqlCode VR_12_Mental_component_summary__MCS__score___orthogonal_method_T_score(CqlContext _) => _VR_12_Mental_component_summary__MCS__score___orthogonal_method_T_score;
    private static readonly CqlCode _VR_12_Mental_component_summary__MCS__score___orthogonal_method_T_score = new CqlCode("72028-4", "http://loinc.org");

    [CqlCodeDefinition("VR-12 Physical component summary (PCS) score - oblique method T-score", codeId: "72025-0", codeSystem: "http://loinc.org")]
    public CqlCode VR_12_Physical_component_summary__PCS__score___oblique_method_T_score(CqlContext _) => _VR_12_Physical_component_summary__PCS__score___oblique_method_T_score;
    private static readonly CqlCode _VR_12_Physical_component_summary__PCS__score___oblique_method_T_score = new CqlCode("72025-0", "http://loinc.org");

    [CqlCodeDefinition("VR-12 Physical component summary (PCS) score - orthogonal method T-score", codeId: "72027-6", codeSystem: "http://loinc.org")]
    public CqlCode VR_12_Physical_component_summary__PCS__score___orthogonal_method_T_score(CqlContext _) => _VR_12_Physical_component_summary__PCS__score___orthogonal_method_T_score;
    private static readonly CqlCode _VR_12_Physical_component_summary__PCS__score___orthogonal_method_T_score = new CqlCode("72027-6", "http://loinc.org");

    #endregion Codes

    #region CodeSystems (3)

    [CqlCodeSystemDefinition("LOINC", codeSystemId: "http://loinc.org", codeSystemVersion: null)]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, [
          _Activities_of_daily_living_score__HOOS_,
          _Pain_score__HOOS_,
          _PROMIS_10_Global_Mental_Health__GMH__score_T_score,
          _PROMIS_10_Global_Physical_Health__GPH__score_T_score,
          _Quality_of_life_score__HOOS_,
          _Sport_recreation_score__HOOS_,
          _Symptoms_score__HOOS_,
          _Total_interval_score__HOOSJR_,
          _VR_12_Mental_component_summary__MCS__score___oblique_method_T_score,
          _VR_12_Mental_component_summary__MCS__score___orthogonal_method_T_score,
          _VR_12_Physical_component_summary__PCS__score___oblique_method_T_score,
          _VR_12_Physical_component_summary__PCS__score___orthogonal_method_T_score]);

    [CqlCodeSystemDefinition("CPT", codeSystemId: "http://www.ama-assn.org/go/cpt", codeSystemVersion: null)]
    public CqlCodeSystem CPT(CqlContext _) => _CPT;
    private static readonly CqlCodeSystem _CPT =
      new CqlCodeSystem("http://www.ama-assn.org/go/cpt", null, [
          _Postoperative_follow_up_visit__normally_included_in_the_surgical_package__to_indicate_that_an_evaluation_and_management_service_was_performed_during_a_postoperative_period_for_a_reason_s__related_to_the_original_procedure]);

    [CqlCodeSystemDefinition("SNOMEDCT", codeSystemId: "http://snomed.info/sct", codeSystemVersion: null)]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Dead__finding_,
          _Severe_cognitive_impairment__finding_]);

    #endregion CodeSystems

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = -4989734324354607034L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("CMS56FHIRFuncStatHipReplacement-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (33)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = 3751859452182210846L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = 8062698479944212271L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = -214646562098729455L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = -9082188876428973750L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = 3982610526901767990L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    [CqlExpressionDefinition("August 1 Year Prior to the Measurement Period")]
    public CqlDateTime August_1_Year_Prior_to_the_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_August_1_Year_Prior_to_the_Measurement_Period, August_1_Year_Prior_to_the_Measurement_Period_Compute);

    private const long _cacheIndex_August_1_Year_Prior_to_the_Measurement_Period = 4699660934411692274L;

    private CqlDateTime August_1_Year_Prior_to_the_Measurement_Period_Compute(CqlContext context)
    {
        CqlInterval<CqlDateTime> a_ = this.Measurement_Period(context);
        CqlDateTime b_ = context.Operators.Start(a_);
        int? c_ = context.Operators.DateTimeComponentFrom(b_, "year");
        int? d_ = context.Operators.Subtract(c_, 1);
        decimal? e_ = context.Operators.ConvertIntegerToDecimal(0);
        CqlDateTime f_ = context.Operators.DateTime(d_, 8, 1, 0, 0, 0, 0, e_);
        return f_;
    }


    [CqlExpressionDefinition("Has Qualifying Encounter")]
    public bool? Has_Qualifying_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Qualifying_Encounter, Has_Qualifying_Encounter_Compute);

    private const long _cacheIndex_Has_Qualifying_Encounter = 5978222765231191090L;

    private bool? Has_Qualifying_Encounter_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet c_ = this.Office_Visit(context);
        IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
        IEnumerable<Encounter> f_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

        bool? g_(Encounter E) {
            List<CodeableConcept> s_ = E?.Type;

            CqlConcept t_(CodeableConcept @this) {
                CqlConcept x_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return x_;
            }


            bool? u_(CqlConcept T) {
                CqlCode y_ = this.Postoperative_follow_up_visit__normally_included_in_the_surgical_package__to_indicate_that_an_evaluation_and_management_service_was_performed_during_a_postoperative_period_for_a_reason_s__related_to_the_original_procedure(context);
                CqlConcept z_ = context.Operators.ConvertCodeToConcept(y_);
                bool? aa_ = context.Operators.Equivalent(T, z_);
                return aa_;
            }

            IEnumerable<CqlConcept> v_ = context.Operators.SelectWhere<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)s_, t_, u_);
            bool? w_ = context.Operators.Exists<CqlConcept>(v_);
            return w_;
        }

        IEnumerable<Encounter> h_ = context.Operators.Where<Encounter>(f_, g_);
        CqlValueSet i_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> j_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(h_, j_);
        IEnumerable<Encounter> l_ = context.Operators.Union<Encounter>(e_, k_);
        CqlValueSet m_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> n_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, m_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> o_ = context.Operators.Union<Encounter>(l_, n_);
        IEnumerable<Encounter> p_ = Status_1_15_000.Instance.isEncounterPerformed(context, o_);

        bool? q_(Encounter ValidEncounters) {
            CqlDateTime ab_ = this.August_1_Year_Prior_to_the_Measurement_Period(context);
            CqlInterval<CqlDateTime> ac_ = this.Measurement_Period(context);
            CqlDateTime ad_ = context.Operators.End(ac_);
            CqlInterval<CqlDateTime> ae_ = context.Operators.Interval(ab_, ad_, true, true);
            Period af_ = ValidEncounters?.Period;
            CqlInterval<CqlDateTime> ag_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, af_);
            bool? ah_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ae_, ag_, "day");
            return ah_;
        }

        bool? r_ = context.Operators.WhereAny<Encounter>(p_, q_);
        return r_;
    }


    [CqlExpressionDefinition("November 1 Two Years Prior to the Measurement Period")]
    public CqlDateTime November_1_Two_Years_Prior_to_the_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_November_1_Two_Years_Prior_to_the_Measurement_Period, November_1_Two_Years_Prior_to_the_Measurement_Period_Compute);

    private const long _cacheIndex_November_1_Two_Years_Prior_to_the_Measurement_Period = 1110942649126641928L;

    private CqlDateTime November_1_Two_Years_Prior_to_the_Measurement_Period_Compute(CqlContext context)
    {
        CqlInterval<CqlDateTime> a_ = this.Measurement_Period(context);
        CqlDateTime b_ = context.Operators.Start(a_);
        int? c_ = context.Operators.DateTimeComponentFrom(b_, "year");
        int? d_ = context.Operators.Subtract(c_, 2);
        decimal? e_ = context.Operators.ConvertIntegerToDecimal(0);
        CqlDateTime f_ = context.Operators.DateTime(d_, 11, 1, 0, 0, 0, 0, e_);
        return f_;
    }


    [CqlExpressionDefinition("October 31 Year Prior to the Measurement Period")]
    public CqlDateTime October_31_Year_Prior_to_the_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_October_31_Year_Prior_to_the_Measurement_Period, October_31_Year_Prior_to_the_Measurement_Period_Compute);

    private const long _cacheIndex_October_31_Year_Prior_to_the_Measurement_Period = 1821886895965482433L;

    private CqlDateTime October_31_Year_Prior_to_the_Measurement_Period_Compute(CqlContext context)
    {
        CqlInterval<CqlDateTime> a_ = this.Measurement_Period(context);
        CqlDateTime b_ = context.Operators.Start(a_);
        int? c_ = context.Operators.DateTimeComponentFrom(b_, "year");
        int? d_ = context.Operators.Subtract(c_, 1);
        decimal? e_ = context.Operators.ConvertIntegerToDecimal(0);
        CqlDateTime f_ = context.Operators.DateTime(d_, 10, 31, 23, 59, 59, 999, e_);
        return f_;
    }


    [CqlExpressionDefinition("Total Hip Arthroplasty Procedure")]
    public IEnumerable<Procedure> Total_Hip_Arthroplasty_Procedure(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Total_Hip_Arthroplasty_Procedure, Total_Hip_Arthroplasty_Procedure_Compute);

    private const long _cacheIndex_Total_Hip_Arthroplasty_Procedure = -5768173162818717571L;

    private IEnumerable<Procedure> Total_Hip_Arthroplasty_Procedure_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Primary_THA_Procedure(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> c_ = Status_1_15_000.Instance.isProcedurePerformed(context, b_);

        bool? d_(Procedure THAProcedure) {
            object f_;
            DataType m_ = THAProcedure?.Performed;
            object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
            bool o_ = n_ is CqlDateTime;
            if (o_)
            {
                f_ = n_ as CqlDateTime;
            }
            else
            {
                bool p_ = n_ is CqlQuantity;
                if (p_)
                {
                    f_ = n_ as CqlQuantity;
                }
                else
                {
                    bool q_ = n_ is CqlInterval<CqlDateTime>;
                    if (q_)
                    {
                        f_ = n_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool r_ = n_ is CqlInterval<CqlQuantity>;
                        if (r_)
                        {
                            f_ = n_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            f_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> g_ = QICoreCommon_4_0_000.Instance.toInterval(context, f_);
            CqlDateTime h_ = context.Operators.Start(g_);
            CqlDateTime i_ = this.November_1_Two_Years_Prior_to_the_Measurement_Period(context);
            CqlDateTime j_ = this.October_31_Year_Prior_to_the_Measurement_Period(context);
            CqlInterval<CqlDateTime> k_ = context.Operators.Interval(i_, j_, true, true);
            bool? l_ = context.Operators.In<CqlDateTime>(h_, k_, "day");
            return l_;
        }

        IEnumerable<Procedure> e_ = context.Operators.Where<Procedure>(c_, d_);
        return e_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = -1816184053542122591L;

    private bool? Initial_Population_Compute(CqlContext context)
    {
        bool? a_ = this.Has_Qualifying_Encounter(context);

        CqlBoolean b_() {
            IEnumerable<Procedure> d_ = this.Total_Hip_Arthroplasty_Procedure(context);
            bool? e_ = context.Operators.Exists<Procedure>(d_);
            return e_;
        }


        CqlBoolean c_() {
            Patient f_ = this.Patient(context);
            Date g_ = f_?.BirthDateElement;
            string h_ = g_?.Value;
            CqlDate i_ = context.Operators.ConvertStringToDate(h_);
            CqlInterval<CqlDateTime> j_ = this.Measurement_Period(context);
            CqlDateTime k_ = context.Operators.Start(j_);
            CqlDate l_ = context.Operators.DateFrom(k_);
            int? m_ = context.Operators.CalculateAgeAt(i_, l_, "year");
            bool? n_ = context.Operators.GreaterOrEqual(m_, 19);
            return n_;
        }

        return /* CQL 'and' (60:3-62:67) */ (/* CQL 'and' (60:3-61:53) */ ((CqlBoolean)a_
            && b_())
            && c_());
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = 446238705440183221L;

    private bool? Denominator_Compute(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlExpressionDefinition("Has Severe Cognitive Impairment")]
    public bool? Has_Severe_Cognitive_Impairment(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Severe_Cognitive_Impairment, Has_Severe_Cognitive_Impairment_Compute);

    private const long _cacheIndex_Has_Severe_Cognitive_Impairment = 8603254795503781889L;

    private bool? Has_Severe_Cognitive_Impairment_Compute(CqlContext context)
    {
        CqlCode a_ = this.Severe_cognitive_impairment__finding_(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> e_ = context.Operators.Union<Condition>(c_ as IEnumerable<Condition>, d_ as IEnumerable<Condition>);

        bool? f_(Condition Dementia) {
            CqlInterval<CqlDateTime> h_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, Dementia);
            CqlInterval<CqlDateTime> i_ = this.Measurement_Period(context);
            bool? j_ = context.Operators.Overlaps(h_, i_, "day");
            return j_;
        }

        bool? g_ = context.Operators.WhereAny<Condition>(e_, f_);
        return g_;
    }


    [CqlFunctionDefinition("isVerified")]
    [CqlTag("note", "When possible, this function should be migrated to QICoreCommon.")]
    [CqlTag("description", "\"confirmed\", \"unconfirmed\", \"provisional\", or \"differential\"")]
    public bool? isVerified(CqlContext context, Condition condition)
    {
        CodeableConcept a_ = condition?.VerificationStatus;
        CqlConcept b_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_);

        CqlBoolean c_() {
            CodeableConcept d_ = condition?.VerificationStatus;
            CqlConcept e_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, d_);
            CqlCode f_ = QICoreCommon_4_0_000.Instance.confirmed(context);
            CqlConcept g_ = context.Operators.ConvertCodeToConcept(f_);
            bool? h_ = context.Operators.Equivalent(e_, g_);

            CqlBoolean i_() {
                CodeableConcept l_ = condition?.VerificationStatus;
                CqlConcept m_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, l_);
                CqlCode n_ = QICoreCommon_4_0_000.Instance.unconfirmed(context);
                CqlConcept o_ = context.Operators.ConvertCodeToConcept(n_);
                bool? p_ = context.Operators.Equivalent(m_, o_);
                return p_;
            }


            CqlBoolean j_() {
                CodeableConcept q_ = condition?.VerificationStatus;
                CqlConcept r_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, q_);
                CqlCode s_ = QICoreCommon_4_0_000.Instance.provisional(context);
                CqlConcept t_ = context.Operators.ConvertCodeToConcept(s_);
                bool? u_ = context.Operators.Equivalent(r_, t_);
                return u_;
            }


            CqlBoolean k_() {
                CodeableConcept v_ = condition?.VerificationStatus;
                CqlConcept w_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, v_);
                CqlCode x_ = QICoreCommon_4_0_000.Instance.differential(context);
                CqlConcept y_ = context.Operators.ConvertCodeToConcept(x_);
                bool? z_ = context.Operators.Equivalent(w_, y_);
                return z_;
            }

            return /* CQL 'or' (277:52-281:3) */ (/* CQL 'or' (277:54-279:66) */ (/* CQL 'or' (277:54-278:66) */ ((CqlBoolean)h_
                || i_())
                || j_())
                || k_());
        }

        return /* CQL 'implies' (277:3-281:3) */ ((CqlBoolean)(!(!((bool?)(b_ is null))))
            || c_());
    }


    [CqlExpressionDefinition("Has Total Hip Arthroplasty with 1 or More Lower Body Fractures")]
    public bool? Has_Total_Hip_Arthroplasty_with_1_or_More_Lower_Body_Fractures(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Total_Hip_Arthroplasty_with_1_or_More_Lower_Body_Fractures, Has_Total_Hip_Arthroplasty_with_1_or_More_Lower_Body_Fractures_Compute);

    private const long _cacheIndex_Has_Total_Hip_Arthroplasty_with_1_or_More_Lower_Body_Fractures = 99885326323127770L;

    private bool? Has_Total_Hip_Arthroplasty_with_1_or_More_Lower_Body_Fractures_Compute(CqlContext context)
    {
        IEnumerable<Procedure> a_ = this.Total_Hip_Arthroplasty_Procedure(context);

        bool? b_(Procedure THAProcedure) {
            CqlValueSet d_ = this.Lower_Body_Fractures_Excluding_Ankle_and_Foot(context);
            IEnumerable<Condition> e_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> f_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> g_ = context.Operators.Union<Condition>(e_ as IEnumerable<Condition>, f_ as IEnumerable<Condition>);

            bool? h_(Condition LowerBodyFracture) {
                CqlInterval<CqlDateTime> j_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, LowerBodyFracture);
                CqlDateTime k_ = context.Operators.Start(j_);
                object l_;
                DataType w_ = THAProcedure?.Performed;
                object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                bool y_ = x_ is CqlDateTime;
                if (y_)
                {
                    l_ = x_ as CqlDateTime;
                }
                else
                {
                    bool z_ = x_ is CqlQuantity;
                    if (z_)
                    {
                        l_ = x_ as CqlQuantity;
                    }
                    else
                    {
                        bool aa_ = x_ is CqlInterval<CqlDateTime>;
                        if (aa_)
                        {
                            l_ = x_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool ab_ = x_ is CqlInterval<CqlQuantity>;
                            if (ab_)
                            {
                                l_ = x_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                l_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> m_ = QICoreCommon_4_0_000.Instance.toInterval(context, l_);
                CqlDateTime n_ = context.Operators.Start(m_);
                CqlQuantity o_ = context.Operators.Quantity(48m, "hours");
                CqlDateTime p_ = context.Operators.Subtract(n_, o_);
                object q_;
                DataType ac_ = THAProcedure?.Performed;
                object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                bool ae_ = ad_ is CqlDateTime;
                if (ae_)
                {
                    q_ = ad_ as CqlDateTime;
                }
                else
                {
                    bool af_ = ad_ is CqlQuantity;
                    if (af_)
                    {
                        q_ = ad_ as CqlQuantity;
                    }
                    else
                    {
                        bool ag_ = ad_ is CqlInterval<CqlDateTime>;
                        if (ag_)
                        {
                            q_ = ad_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool ah_ = ad_ is CqlInterval<CqlQuantity>;
                            if (ah_)
                            {
                                q_ = ad_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                q_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> r_ = QICoreCommon_4_0_000.Instance.toInterval(context, q_);
                CqlDateTime s_ = context.Operators.Start(r_);
                CqlInterval<CqlDateTime> t_ = context.Operators.Interval(p_, s_, true, true);
                bool? u_ = context.Operators.In<CqlDateTime>(k_, t_, (string)default);

                CqlBoolean v_() {
                    object ai_;
                    DataType al_ = THAProcedure?.Performed;
                    object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                    bool an_ = am_ is CqlDateTime;
                    if (an_)
                    {
                        ai_ = am_ as CqlDateTime;
                    }
                    else
                    {
                        bool ao_ = am_ is CqlQuantity;
                        if (ao_)
                        {
                            ai_ = am_ as CqlQuantity;
                        }
                        else
                        {
                            bool ap_ = am_ is CqlInterval<CqlDateTime>;
                            if (ap_)
                            {
                                ai_ = am_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                bool aq_ = am_ is CqlInterval<CqlQuantity>;
                                if (aq_)
                                {
                                    ai_ = am_ as CqlInterval<CqlQuantity>;
                                }
                                else
                                {
                                    ai_ = null;
                                }
                            }
                        }
                    }
                    CqlInterval<CqlDateTime> aj_ = QICoreCommon_4_0_000.Instance.toInterval(context, ai_);
                    CqlDateTime ak_ = context.Operators.Start(aj_);
                    return !((bool?)(ak_ is null));
                }

                return /* CQL 'and' (114:19-115:46) */ (/* CQL 'and' (114:19-114:142) */ ((CqlBoolean)u_
                    && v_())
                    && (CqlBoolean)(this.isVerified(context, LowerBodyFracture)));
            }

            bool? i_ = context.Operators.WhereAny<Condition>(g_, h_);
            return i_;
        }

        bool? c_ = context.Operators.WhereAny<Procedure>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Has Partial Hip Arthroplasty Procedure")]
    public bool? Has_Partial_Hip_Arthroplasty_Procedure(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Partial_Hip_Arthroplasty_Procedure, Has_Partial_Hip_Arthroplasty_Procedure_Compute);

    private const long _cacheIndex_Has_Partial_Hip_Arthroplasty_Procedure = 5573278062808731434L;

    private bool? Has_Partial_Hip_Arthroplasty_Procedure_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Partial_Arthroplasty_of_Hip(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> c_ = Status_1_15_000.Instance.isProcedurePerformed(context, b_);

        bool? d_(Procedure PartialTHAProcedure) {
            IEnumerable<Procedure> f_ = this.Total_Hip_Arthroplasty_Procedure(context);

            bool? g_(Procedure THAProcedure) {
                object i_;
                DataType n_ = THAProcedure?.Performed;
                object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
                bool p_ = o_ is CqlDateTime;
                if (p_)
                {
                    i_ = o_ as CqlDateTime;
                }
                else
                {
                    bool q_ = o_ is CqlQuantity;
                    if (q_)
                    {
                        i_ = o_ as CqlQuantity;
                    }
                    else
                    {
                        bool r_ = o_ is CqlInterval<CqlDateTime>;
                        if (r_)
                        {
                            i_ = o_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool s_ = o_ is CqlInterval<CqlQuantity>;
                            if (s_)
                            {
                                i_ = o_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                i_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> j_ = QICoreCommon_4_0_000.Instance.toInterval(context, i_);
                object k_;
                DataType t_ = PartialTHAProcedure?.Performed;
                object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                bool v_ = u_ is CqlDateTime;
                if (v_)
                {
                    k_ = u_ as CqlDateTime;
                }
                else
                {
                    bool w_ = u_ is CqlQuantity;
                    if (w_)
                    {
                        k_ = u_ as CqlQuantity;
                    }
                    else
                    {
                        bool x_ = u_ is CqlInterval<CqlDateTime>;
                        if (x_)
                        {
                            k_ = u_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool y_ = u_ is CqlInterval<CqlQuantity>;
                            if (y_)
                            {
                                k_ = u_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                k_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> l_ = QICoreCommon_4_0_000.Instance.toInterval(context, k_);
                bool? m_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(j_, l_, "day");
                return m_;
            }

            bool? h_ = context.Operators.WhereAny<Procedure>(f_, g_);
            return h_;
        }

        bool? e_ = context.Operators.WhereAny<Procedure>(c_, d_);
        return e_;
    }


    [CqlExpressionDefinition("Has Revision Hip Arthroplasty Procedure or Implanted Device or Prosthesis Removal Procedure")]
    public bool? Has_Revision_Hip_Arthroplasty_Procedure_or_Implanted_Device_or_Prosthesis_Removal_Procedure(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Revision_Hip_Arthroplasty_Procedure_or_Implanted_Device_or_Prosthesis_Removal_Procedure, Has_Revision_Hip_Arthroplasty_Procedure_or_Implanted_Device_or_Prosthesis_Removal_Procedure_Compute);

    private const long _cacheIndex_Has_Revision_Hip_Arthroplasty_Procedure_or_Implanted_Device_or_Prosthesis_Removal_Procedure = 5889930654885795887L;

    private bool? Has_Revision_Hip_Arthroplasty_Procedure_or_Implanted_Device_or_Prosthesis_Removal_Procedure_Compute(CqlContext context)
    {
        IEnumerable<Procedure> a_ = this.Total_Hip_Arthroplasty_Procedure(context);

        bool? b_(Procedure THAProcedure) {
            CqlValueSet d_ = this.Removal__Revision_and_Supplement_Procedures_of_the_Lower_Body_and_Spine(context);
            IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            IEnumerable<Procedure> f_ = Status_1_15_000.Instance.isProcedurePerformed(context, e_);

            bool? g_(Procedure RevisionTHAProcedure) {
                object i_;
                DataType n_ = THAProcedure?.Performed;
                object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
                bool p_ = o_ is CqlDateTime;
                if (p_)
                {
                    i_ = o_ as CqlDateTime;
                }
                else
                {
                    bool q_ = o_ is CqlQuantity;
                    if (q_)
                    {
                        i_ = o_ as CqlQuantity;
                    }
                    else
                    {
                        bool r_ = o_ is CqlInterval<CqlDateTime>;
                        if (r_)
                        {
                            i_ = o_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool s_ = o_ is CqlInterval<CqlQuantity>;
                            if (s_)
                            {
                                i_ = o_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                i_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> j_ = QICoreCommon_4_0_000.Instance.toInterval(context, i_);
                object k_;
                DataType t_ = RevisionTHAProcedure?.Performed;
                object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                bool v_ = u_ is CqlDateTime;
                if (v_)
                {
                    k_ = u_ as CqlDateTime;
                }
                else
                {
                    bool w_ = u_ is CqlQuantity;
                    if (w_)
                    {
                        k_ = u_ as CqlQuantity;
                    }
                    else
                    {
                        bool x_ = u_ is CqlInterval<CqlDateTime>;
                        if (x_)
                        {
                            k_ = u_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool y_ = u_ is CqlInterval<CqlQuantity>;
                            if (y_)
                            {
                                k_ = u_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                k_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> l_ = QICoreCommon_4_0_000.Instance.toInterval(context, k_);
                bool? m_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(j_, l_, "day");
                return m_;
            }

            bool? h_ = context.Operators.WhereAny<Procedure>(f_, g_);
            return h_;
        }

        bool? c_ = context.Operators.WhereAny<Procedure>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Has Malignant Neoplasm of Lower and Unspecified Limbs")]
    public bool? Has_Malignant_Neoplasm_of_Lower_and_Unspecified_Limbs(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Malignant_Neoplasm_of_Lower_and_Unspecified_Limbs, Has_Malignant_Neoplasm_of_Lower_and_Unspecified_Limbs_Compute);

    private const long _cacheIndex_Has_Malignant_Neoplasm_of_Lower_and_Unspecified_Limbs = -2389632056529416502L;

    private bool? Has_Malignant_Neoplasm_of_Lower_and_Unspecified_Limbs_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Malignant_Neoplasms_of_Lower_and_Unspecified_Limbs(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> d_ = context.Operators.Union<Condition>(b_ as IEnumerable<Condition>, c_ as IEnumerable<Condition>);

        bool? e_(Condition MalignantNeoplasm) {
            IEnumerable<Procedure> g_ = this.Total_Hip_Arthroplasty_Procedure(context);

            bool? h_(Procedure THAProcedure) {
                CqlInterval<CqlDateTime> j_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, MalignantNeoplasm);
                object k_;
                DataType n_ = THAProcedure?.Performed;
                object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
                bool p_ = o_ is CqlDateTime;
                if (p_)
                {
                    k_ = o_ as CqlDateTime;
                }
                else
                {
                    bool q_ = o_ is CqlQuantity;
                    if (q_)
                    {
                        k_ = o_ as CqlQuantity;
                    }
                    else
                    {
                        bool r_ = o_ is CqlInterval<CqlDateTime>;
                        if (r_)
                        {
                            k_ = o_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool s_ = o_ is CqlInterval<CqlQuantity>;
                            if (s_)
                            {
                                k_ = o_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                k_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> l_ = QICoreCommon_4_0_000.Instance.toInterval(context, k_);
                bool? m_ = context.Operators.Overlaps(j_, l_, "day");
                return /* CQL 'and' (134:19-135:46) */ ((CqlBoolean)m_
                    && (CqlBoolean)(this.isVerified(context, MalignantNeoplasm)));
            }

            bool? i_ = context.Operators.WhereAny<Procedure>(g_, h_);
            return i_;
        }

        bool? f_ = context.Operators.WhereAny<Condition>(d_, e_);
        return f_;
    }


    [CqlExpressionDefinition("Has Mechanical Complication")]
    public bool? Has_Mechanical_Complication(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Mechanical_Complication, Has_Mechanical_Complication_Compute);

    private const long _cacheIndex_Has_Mechanical_Complication = 7139202238750288841L;

    private bool? Has_Mechanical_Complication_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Mechanical_Complications_Excluding_Upper_Body(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> d_ = context.Operators.Union<Condition>(b_ as IEnumerable<Condition>, c_ as IEnumerable<Condition>);

        bool? e_(Condition MechanicalComplications) {
            IEnumerable<Procedure> g_ = this.Total_Hip_Arthroplasty_Procedure(context);

            bool? h_(Procedure THAProcedure) {
                CqlInterval<CqlDateTime> j_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, MechanicalComplications);
                object k_;
                DataType n_ = THAProcedure?.Performed;
                object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
                bool p_ = o_ is CqlDateTime;
                if (p_)
                {
                    k_ = o_ as CqlDateTime;
                }
                else
                {
                    bool q_ = o_ is CqlQuantity;
                    if (q_)
                    {
                        k_ = o_ as CqlQuantity;
                    }
                    else
                    {
                        bool r_ = o_ is CqlInterval<CqlDateTime>;
                        if (r_)
                        {
                            k_ = o_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool s_ = o_ is CqlInterval<CqlQuantity>;
                            if (s_)
                            {
                                k_ = o_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                k_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> l_ = QICoreCommon_4_0_000.Instance.toInterval(context, k_);
                bool? m_ = context.Operators.Overlaps(j_, l_, "day");
                return /* CQL 'and' (142:19-143:52) */ ((CqlBoolean)m_
                    && (CqlBoolean)(this.isVerified(context, MechanicalComplications)));
            }

            bool? i_ = context.Operators.WhereAny<Procedure>(g_, h_);
            return i_;
        }

        bool? f_ = context.Operators.WhereAny<Condition>(d_, e_);
        return f_;
    }


    [CqlExpressionDefinition("Has More Than One Elective Primary Total Hip Arthroplasty Performed")]
    public bool? Has_More_Than_One_Elective_Primary_Total_Hip_Arthroplasty_Performed(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_More_Than_One_Elective_Primary_Total_Hip_Arthroplasty_Performed, Has_More_Than_One_Elective_Primary_Total_Hip_Arthroplasty_Performed_Compute);

    private const long _cacheIndex_Has_More_Than_One_Elective_Primary_Total_Hip_Arthroplasty_Performed = -923175309866963357L;

    private bool? Has_More_Than_One_Elective_Primary_Total_Hip_Arthroplasty_Performed_Compute(CqlContext context)
    {
        IEnumerable<Procedure> a_ = this.Total_Hip_Arthroplasty_Procedure(context);

        bool? b_(Procedure THAProcedure) {
            CqlValueSet d_ = this.Primary_THA_Procedure(context);
            IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            IEnumerable<Procedure> f_ = Status_1_15_000.Instance.isProcedurePerformed(context, e_);

            bool? g_(Procedure ElectiveTHAProcedure) {
                Id i_ = THAProcedure?.IdElement;
                string j_ = i_?.Value;
                Id k_ = ElectiveTHAProcedure?.IdElement;
                string l_ = k_?.Value;
                bool? m_ = context.Operators.Equivalent(j_, l_);

                CqlBoolean n_() {
                    object o_;
                    DataType ac_ = ElectiveTHAProcedure?.Performed;
                    object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                    bool ae_ = ad_ is CqlDateTime;
                    if (ae_)
                    {
                        o_ = ad_ as CqlDateTime;
                    }
                    else
                    {
                        bool af_ = ad_ is CqlQuantity;
                        if (af_)
                        {
                            o_ = ad_ as CqlQuantity;
                        }
                        else
                        {
                            bool ag_ = ad_ is CqlInterval<CqlDateTime>;
                            if (ag_)
                            {
                                o_ = ad_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                bool ah_ = ad_ is CqlInterval<CqlQuantity>;
                                if (ah_)
                                {
                                    o_ = ad_ as CqlInterval<CqlQuantity>;
                                }
                                else
                                {
                                    o_ = null;
                                }
                            }
                        }
                    }
                    CqlInterval<CqlDateTime> p_ = QICoreCommon_4_0_000.Instance.toInterval(context, o_);
                    CqlDateTime q_ = context.Operators.Start(p_);
                    object r_;
                    DataType ai_ = THAProcedure?.Performed;
                    object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                    bool ak_ = aj_ is CqlDateTime;
                    if (ak_)
                    {
                        r_ = aj_ as CqlDateTime;
                    }
                    else
                    {
                        bool al_ = aj_ is CqlQuantity;
                        if (al_)
                        {
                            r_ = aj_ as CqlQuantity;
                        }
                        else
                        {
                            bool am_ = aj_ is CqlInterval<CqlDateTime>;
                            if (am_)
                            {
                                r_ = aj_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                bool an_ = aj_ is CqlInterval<CqlQuantity>;
                                if (an_)
                                {
                                    r_ = aj_ as CqlInterval<CqlQuantity>;
                                }
                                else
                                {
                                    r_ = null;
                                }
                            }
                        }
                    }
                    CqlInterval<CqlDateTime> s_ = QICoreCommon_4_0_000.Instance.toInterval(context, r_);
                    CqlDateTime t_ = context.Operators.Start(s_);
                    CqlQuantity u_ = context.Operators.Quantity(1m, "year");
                    CqlDateTime v_ = context.Operators.Subtract(t_, u_);
                    object w_;
                    DataType ao_ = THAProcedure?.Performed;
                    object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                    bool aq_ = ap_ is CqlDateTime;
                    if (aq_)
                    {
                        w_ = ap_ as CqlDateTime;
                    }
                    else
                    {
                        bool ar_ = ap_ is CqlQuantity;
                        if (ar_)
                        {
                            w_ = ap_ as CqlQuantity;
                        }
                        else
                        {
                            bool as_ = ap_ is CqlInterval<CqlDateTime>;
                            if (as_)
                            {
                                w_ = ap_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                bool at_ = ap_ is CqlInterval<CqlQuantity>;
                                if (at_)
                                {
                                    w_ = ap_ as CqlInterval<CqlQuantity>;
                                }
                                else
                                {
                                    w_ = null;
                                }
                            }
                        }
                    }
                    CqlInterval<CqlDateTime> x_ = QICoreCommon_4_0_000.Instance.toInterval(context, w_);
                    CqlDateTime y_ = context.Operators.Start(x_);
                    CqlDateTime z_ = context.Operators.Add(y_, u_);
                    CqlInterval<CqlDateTime> aa_ = context.Operators.Interval(v_, z_, true, true);
                    bool? ab_ = context.Operators.In<CqlDateTime>(q_, aa_, "day");
                    return ab_;
                }

                return /* CQL 'and' (149:19-150:213) */ ((CqlBoolean)!m_
                    && n_());
            }

            bool? h_ = context.Operators.WhereAny<Procedure>(f_, g_);
            return h_;
        }

        bool? c_ = context.Operators.WhereAny<Procedure>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Death Within 300 Days of the THA Procedure")]
    public bool? Death_Within_300_Days_of_the_THA_Procedure(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Death_Within_300_Days_of_the_THA_Procedure, Death_Within_300_Days_of_the_THA_Procedure_Compute);

    private const long _cacheIndex_Death_Within_300_Days_of_the_THA_Procedure = -1448111265350174851L;

    private bool? Death_Within_300_Days_of_the_THA_Procedure_Compute(CqlContext context)
    {
        IEnumerable<Procedure> a_ = this.Total_Hip_Arthroplasty_Procedure(context);

        bool? b_(Procedure THAProcedure) {
            Patient d_ = this.Patient(context);
            DataType e_ = d_?.Deceased;
            object f_ = FHIRHelpers_4_4_000.Instance.ToValue(context, e_);
            CqlDate g_ = context.Operators.DateFrom(f_ as CqlDateTime);
            object h_;
            DataType t_ = THAProcedure?.Performed;
            object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
            bool v_ = u_ is CqlDateTime;
            if (v_)
            {
                h_ = u_ as CqlDateTime;
            }
            else
            {
                bool w_ = u_ is CqlQuantity;
                if (w_)
                {
                    h_ = u_ as CqlQuantity;
                }
                else
                {
                    bool x_ = u_ is CqlInterval<CqlDateTime>;
                    if (x_)
                    {
                        h_ = u_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool y_ = u_ is CqlInterval<CqlQuantity>;
                        if (y_)
                        {
                            h_ = u_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            h_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> i_ = QICoreCommon_4_0_000.Instance.toInterval(context, h_);
            CqlDateTime j_ = context.Operators.Start(i_);
            CqlDate k_ = context.Operators.DateFrom(j_);
            object l_;
            DataType z_ = THAProcedure?.Performed;
            object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
            bool ab_ = aa_ is CqlDateTime;
            if (ab_)
            {
                l_ = aa_ as CqlDateTime;
            }
            else
            {
                bool ac_ = aa_ is CqlQuantity;
                if (ac_)
                {
                    l_ = aa_ as CqlQuantity;
                }
                else
                {
                    bool ad_ = aa_ is CqlInterval<CqlDateTime>;
                    if (ad_)
                    {
                        l_ = aa_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool ae_ = aa_ is CqlInterval<CqlQuantity>;
                        if (ae_)
                        {
                            l_ = aa_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            l_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> m_ = QICoreCommon_4_0_000.Instance.toInterval(context, l_);
            CqlDateTime n_ = context.Operators.Start(m_);
            CqlDate o_ = context.Operators.DateFrom(n_);
            CqlQuantity p_ = context.Operators.Quantity(300m, "days");
            CqlDate q_ = context.Operators.Add(o_, p_);
            CqlInterval<CqlDate> r_ = context.Operators.Interval(k_, q_, true, true);
            bool? s_ = context.Operators.In<CqlDate>(g_, r_, "day");
            return s_;
        }

        bool? c_ = context.Operators.WhereAny<Procedure>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exclusions, Denominator_Exclusions_Compute);

    private const long _cacheIndex_Denominator_Exclusions = -7348517150261171558L;

    private bool? Denominator_Exclusions_Compute(CqlContext context)
    {
        bool? a_ = Hospice_6_18_000.Instance.Has_Hospice_Services(context);
        return /* CQL 'or' (95:3-103:51) */ (/* CQL 'or' (95:3-102:76) */ (/* CQL 'or' (95:3-101:36) */ (/* CQL 'or' (95:3-100:62) */ (/* CQL 'or' (95:3-99:100) */ (/* CQL 'or' (95:3-98:47) */ (/* CQL 'or' (95:3-97:71) */ (/* CQL 'or' (95:3-96:40) */ ((CqlBoolean)a_
            || (CqlBoolean)(this.Has_Severe_Cognitive_Impairment(context)))
            || (CqlBoolean)(this.Has_Total_Hip_Arthroplasty_with_1_or_More_Lower_Body_Fractures(context)))
            || (CqlBoolean)(this.Has_Partial_Hip_Arthroplasty_Procedure(context)))
            || (CqlBoolean)(this.Has_Revision_Hip_Arthroplasty_Procedure_or_Implanted_Device_or_Prosthesis_Removal_Procedure(context)))
            || (CqlBoolean)(this.Has_Malignant_Neoplasm_of_Lower_and_Unspecified_Limbs(context)))
            || (CqlBoolean)(this.Has_Mechanical_Complication(context)))
            || (CqlBoolean)(this.Has_More_Than_One_Elective_Primary_Total_Hip_Arthroplasty_Performed(context)))
            || (CqlBoolean)(this.Death_Within_300_Days_of_the_THA_Procedure(context)));
    }


    [CqlExpressionDefinition("Date HOOS Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_HOOS_Total_Assessment_Completed(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Date_HOOS_Total_Assessment_Completed, Date_HOOS_Total_Assessment_Completed_Compute);

    private const long _cacheIndex_Date_HOOS_Total_Assessment_Completed = 7130200900377271899L;

    private IEnumerable<CqlDate> Date_HOOS_Total_Assessment_Completed_Compute(CqlContext context)
    {
        CqlCode a_ = this.Quality_of_life_score__HOOS_(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
        IEnumerable<Observation> d_ = Status_1_15_000.Instance.isAssessmentPerformed(context, c_);
        CqlCode e_ = this.Sport_recreation_score__HOOS_(context);
        IEnumerable<CqlCode> f_ = context.Operators.ToList<CqlCode>(e_);
        IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, f_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
        IEnumerable<Observation> h_ = Status_1_15_000.Instance.isAssessmentPerformed(context, g_);
        CqlCode i_ = this.Activities_of_daily_living_score__HOOS_(context);
        IEnumerable<CqlCode> j_ = context.Operators.ToList<CqlCode>(i_);
        IEnumerable<Observation> k_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, j_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
        IEnumerable<Observation> l_ = Status_1_15_000.Instance.isAssessmentPerformed(context, k_);
        CqlCode m_ = this.Symptoms_score__HOOS_(context);
        IEnumerable<CqlCode> n_ = context.Operators.ToList<CqlCode>(m_);
        IEnumerable<Observation> o_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, n_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
        IEnumerable<Observation> p_ = Status_1_15_000.Instance.isAssessmentPerformed(context, o_);
        CqlCode q_ = this.Pain_score__HOOS_(context);
        IEnumerable<CqlCode> r_ = context.Operators.ToList<CqlCode>(q_);
        IEnumerable<Observation> s_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, r_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
        IEnumerable<Observation> t_ = Status_1_15_000.Instance.isAssessmentPerformed(context, s_);
        IEnumerable<ValueTuple<Observation, Observation, Observation, Observation, Observation>> u_ = context.Operators.CrossJoin<Observation, Observation, Observation, Observation, Observation>(d_, h_, l_, p_, t_);

        (CqlTupleMetadata, Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)? v_(ValueTuple<Observation, Observation, Observation, Observation, Observation> _valueTuple) {
            (CqlTupleMetadata, Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)? aa_ = (CqlTupleMetadata_GVNUVHGXYWXVGgfjdTEahUfhP, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3, _valueTuple.Item4, _valueTuple.Item5);
            return aa_;
        }


        bool? w_((CqlTupleMetadata, Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)? tuple_eipfmazvhfscjijaofhicpvmb) {
            DataType ab_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSLifeQuality?.Effective;
            object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
            CqlInterval<CqlDateTime> ad_ = QICoreCommon_4_0_000.Instance.toInterval(context, ac_);
            CqlDateTime ae_ = context.Operators.Start(ad_);
            CqlDate af_ = context.Operators.DateFrom(ae_);
            DataType ag_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSSport?.Effective;
            object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
            CqlInterval<CqlDateTime> ai_ = QICoreCommon_4_0_000.Instance.toInterval(context, ah_);
            CqlDateTime aj_ = context.Operators.Start(ai_);
            CqlDate ak_ = context.Operators.DateFrom(aj_);
            bool? al_ = context.Operators.SameAs(af_, ak_, "day");

            CqlBoolean am_() {
                DataType au_ = (tuple_eipfmazvhfscjijaofhicpvmb?.HOOSSport as Observation)?.Value;
                object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                return !((bool?)(av_ is null));
            }


            CqlBoolean an_() {
                DataType aw_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSLifeQuality?.Effective;
                object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                CqlInterval<CqlDateTime> ay_ = QICoreCommon_4_0_000.Instance.toInterval(context, ax_);
                CqlDateTime az_ = context.Operators.Start(ay_);
                CqlDate ba_ = context.Operators.DateFrom(az_);
                DataType bb_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSActivityScore?.Effective;
                object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                CqlInterval<CqlDateTime> bd_ = QICoreCommon_4_0_000.Instance.toInterval(context, bc_);
                CqlDateTime be_ = context.Operators.Start(bd_);
                CqlDate bf_ = context.Operators.DateFrom(be_);
                bool? bg_ = context.Operators.SameAs(ba_, bf_, "day");
                return bg_;
            }


            CqlBoolean ao_() {
                DataType bh_ = (tuple_eipfmazvhfscjijaofhicpvmb?.HOOSActivityScore as Observation)?.Value;
                object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                return !((bool?)(bi_ is null));
            }


            CqlBoolean ap_() {
                DataType bj_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSLifeQuality?.Effective;
                object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                CqlInterval<CqlDateTime> bl_ = QICoreCommon_4_0_000.Instance.toInterval(context, bk_);
                CqlDateTime bm_ = context.Operators.Start(bl_);
                CqlDate bn_ = context.Operators.DateFrom(bm_);
                DataType bo_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSSymptoms?.Effective;
                object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                CqlInterval<CqlDateTime> bq_ = QICoreCommon_4_0_000.Instance.toInterval(context, bp_);
                CqlDateTime br_ = context.Operators.Start(bq_);
                CqlDate bs_ = context.Operators.DateFrom(br_);
                bool? bt_ = context.Operators.SameAs(bn_, bs_, "day");
                return bt_;
            }


            CqlBoolean aq_() {
                DataType bu_ = (tuple_eipfmazvhfscjijaofhicpvmb?.HOOSSymptoms as Observation)?.Value;
                object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                return !((bool?)(bv_ is null));
            }


            CqlBoolean ar_() {
                DataType bw_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSLifeQuality?.Effective;
                object bx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bw_);
                CqlInterval<CqlDateTime> by_ = QICoreCommon_4_0_000.Instance.toInterval(context, bx_);
                CqlDateTime bz_ = context.Operators.Start(by_);
                CqlDate ca_ = context.Operators.DateFrom(bz_);
                DataType cb_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSPain?.Effective;
                object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                CqlInterval<CqlDateTime> cd_ = QICoreCommon_4_0_000.Instance.toInterval(context, cc_);
                CqlDateTime ce_ = context.Operators.Start(cd_);
                CqlDate cf_ = context.Operators.DateFrom(ce_);
                bool? cg_ = context.Operators.SameAs(ca_, cf_, "day");
                return cg_;
            }


            CqlBoolean as_() {
                DataType ch_ = (tuple_eipfmazvhfscjijaofhicpvmb?.HOOSPain as Observation)?.Value;
                object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                return !((bool?)(ci_ is null));
            }


            CqlBoolean at_() {
                DataType cj_ = (tuple_eipfmazvhfscjijaofhicpvmb?.HOOSLifeQuality as Observation)?.Value;
                object ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
                return !((bool?)(ck_ is null));
            }

            return /* CQL 'and' (185:5-193:81) */ (/* CQL 'and' (185:11-192:74) */ (/* CQL 'and' (185:11-191:54) */ (/* CQL 'and' (185:11-190:78) */ (/* CQL 'and' (185:11-189:58) */ (/* CQL 'and' (185:11-188:83) */ (/* CQL 'and' (185:11-187:63) */ (/* CQL 'and' (185:11-186:75) */ ((CqlBoolean)al_
                && am_())
                && an_())
                && ao_())
                && ap_())
                && aq_())
                && ar_())
                && as_())
                && at_());
        }

        IEnumerable<(CqlTupleMetadata, Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)?> x_ = context.Operators.SelectWhere<ValueTuple<Observation, Observation, Observation, Observation, Observation>, (CqlTupleMetadata, Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)?>(u_, v_, w_);

        CqlDate y_((CqlTupleMetadata, Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)? tuple_eipfmazvhfscjijaofhicpvmb) {
            DataType cl_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSLifeQuality?.Effective;
            object cm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cl_);
            CqlInterval<CqlDateTime> cn_ = QICoreCommon_4_0_000.Instance.toInterval(context, cm_);
            CqlDateTime co_ = context.Operators.Start(cn_);
            CqlDate cp_ = context.Operators.DateFrom(co_);
            DataType cq_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSSport?.Effective;
            object cr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cq_);
            CqlInterval<CqlDateTime> cs_ = QICoreCommon_4_0_000.Instance.toInterval(context, cr_);
            CqlDateTime ct_ = context.Operators.Start(cs_);
            CqlDate cu_ = context.Operators.DateFrom(ct_);
            DataType cv_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSActivityScore?.Effective;
            object cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);
            CqlInterval<CqlDateTime> cx_ = QICoreCommon_4_0_000.Instance.toInterval(context, cw_);
            CqlDateTime cy_ = context.Operators.Start(cx_);
            CqlDate cz_ = context.Operators.DateFrom(cy_);
            DataType da_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSSymptoms?.Effective;
            object db_ = FHIRHelpers_4_4_000.Instance.ToValue(context, da_);
            CqlInterval<CqlDateTime> dc_ = QICoreCommon_4_0_000.Instance.toInterval(context, db_);
            CqlDateTime dd_ = context.Operators.Start(dc_);
            CqlDate de_ = context.Operators.DateFrom(dd_);
            DataType df_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSPain?.Effective;
            object dg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, df_);
            CqlInterval<CqlDateTime> dh_ = QICoreCommon_4_0_000.Instance.toInterval(context, dg_);
            CqlDateTime di_ = context.Operators.Start(dh_);
            CqlDate dj_ = context.Operators.DateFrom(di_);
            CqlDate[] dk_ = [
                cp_,
                cu_,
                cz_,
                de_,
                dj_,
            ];
            CqlDate dl_ = context.Operators.Max<CqlDate>((IEnumerable<CqlDate>)dk_);
            return dl_;
        }

        IEnumerable<CqlDate> z_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)?, CqlDate>(x_, y_);
        return z_;
    }


    [CqlExpressionDefinition("Has THA with Initial and Follow Up HOOS Assessments")]
    public bool? Has_THA_with_Initial_and_Follow_Up_HOOS_Assessments(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_THA_with_Initial_and_Follow_Up_HOOS_Assessments, Has_THA_with_Initial_and_Follow_Up_HOOS_Assessments_Compute);

    private const long _cacheIndex_Has_THA_with_Initial_and_Follow_Up_HOOS_Assessments = -3170780632634006629L;

    private bool? Has_THA_with_Initial_and_Follow_Up_HOOS_Assessments_Compute(CqlContext context)
    {
        IEnumerable<Procedure> a_ = this.Total_Hip_Arthroplasty_Procedure(context);

        CqlInterval<CqlDateTime> b_(Procedure THAProcedure) {
            object h_;
            DataType j_ = THAProcedure?.Performed;
            object k_ = FHIRHelpers_4_4_000.Instance.ToValue(context, j_);
            bool l_ = k_ is CqlDateTime;
            if (l_)
            {
                h_ = k_ as CqlDateTime;
            }
            else
            {
                bool m_ = k_ is CqlQuantity;
                if (m_)
                {
                    h_ = k_ as CqlQuantity;
                }
                else
                {
                    bool n_ = k_ is CqlInterval<CqlDateTime>;
                    if (n_)
                    {
                        h_ = k_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool o_ = k_ is CqlInterval<CqlQuantity>;
                        if (o_)
                        {
                            h_ = k_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            h_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> i_ = QICoreCommon_4_0_000.Instance.toInterval(context, h_);
            return i_;
        }

        IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.SelectDistinct<Procedure, CqlInterval<CqlDateTime>>(a_, b_);

        bool? d_(CqlInterval<CqlDateTime> TotalHip) {
            IEnumerable<CqlDate> p_ = this.Date_HOOS_Total_Assessment_Completed(context);

            bool? q_(CqlDate InitialHipAssessmentHOOS) {
                CqlDateTime s_ = context.Operators.Start(TotalHip);
                CqlDateTime t_ = context.Operators.ConvertDateToDateTime(InitialHipAssessmentHOOS);
                CqlQuantity u_ = context.Operators.Quantity(90m, "days");
                CqlDate v_ = context.Operators.Add(InitialHipAssessmentHOOS, u_);
                CqlDateTime w_ = context.Operators.ConvertDateToDateTime(v_);
                CqlInterval<CqlDateTime> x_ = context.Operators.Interval(t_, w_, true, true);
                bool? y_ = context.Operators.In<CqlDateTime>(s_, x_, "day");
                return /* CQL 'and' (168:19-168:93) */ ((CqlBoolean)y_
                    && (CqlBoolean)(!((bool?)(InitialHipAssessmentHOOS is null))));
            }

            bool? r_ = context.Operators.WhereAny<CqlDate>(p_, q_);
            return r_;
        }

        IEnumerable<CqlInterval<CqlDateTime>> e_ = context.Operators.Where<CqlInterval<CqlDateTime>>(c_, d_);

        bool? f_(CqlInterval<CqlDateTime> TotalHip) {
            IEnumerable<CqlDate> z_ = this.Date_HOOS_Total_Assessment_Completed(context);

            bool? aa_(CqlDate FollowUpHipAssessmentHOOS) {
                CqlDateTime ac_ = context.Operators.ConvertDateToDateTime(FollowUpHipAssessmentHOOS);
                CqlDate ad_ = context.Operators.DateFrom(ac_);
                CqlDateTime ae_ = context.Operators.End(TotalHip);
                CqlDate af_ = context.Operators.DateFrom(ae_);
                CqlQuantity ag_ = context.Operators.Quantity(300m, "days");
                CqlDate ah_ = context.Operators.Add(af_, ag_);
                CqlQuantity ai_ = context.Operators.Quantity(425m, "days");
                CqlDate aj_ = context.Operators.Add(af_, ai_);
                CqlInterval<CqlDate> ak_ = context.Operators.Interval(ah_, aj_, true, true);
                bool? al_ = context.Operators.In<CqlDate>(ad_, ak_, "day");
                return al_;
            }

            bool? ab_ = context.Operators.WhereAny<CqlDate>(z_, aa_);
            return ab_;
        }

        bool? g_ = context.Operators.WhereAny<CqlInterval<CqlDateTime>>(e_, f_);
        return g_;
    }


    [CqlExpressionDefinition("Date HOOSJr Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_HOOSJr_Total_Assessment_Completed(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Date_HOOSJr_Total_Assessment_Completed, Date_HOOSJr_Total_Assessment_Completed_Compute);

    private const long _cacheIndex_Date_HOOSJr_Total_Assessment_Completed = -9128756688026624721L;

    private IEnumerable<CqlDate> Date_HOOSJr_Total_Assessment_Completed_Compute(CqlContext context)
    {
        CqlCode a_ = this.Total_interval_score__HOOSJR_(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
        IEnumerable<Observation> d_ = Status_1_15_000.Instance.isAssessmentPerformed(context, c_);

        bool? e_(Observation HOOSJr) {
            DataType i_ = (HOOSJr as Observation)?.Value;
            object j_ = FHIRHelpers_4_4_000.Instance.ToValue(context, i_);
            return !((bool?)(j_ is null));
        }


        CqlDate f_(Observation DocumentedHOOSJr) {
            DataType k_ = DocumentedHOOSJr?.Effective;
            object l_ = FHIRHelpers_4_4_000.Instance.ToValue(context, k_);
            CqlInterval<CqlDateTime> m_ = QICoreCommon_4_0_000.Instance.toInterval(context, l_);
            CqlDateTime n_ = context.Operators.Start(m_);
            CqlDate o_ = context.Operators.DateFrom(n_);
            return o_;
        }

        IEnumerable<CqlDate> g_ = context.Operators.WhereSelect<Observation, CqlDate>(d_, e_, f_);
        IEnumerable<CqlDate> h_ = context.Operators.Distinct<CqlDate>(g_);
        return h_;
    }


    [CqlExpressionDefinition("Has THA with Initial and Follow Up HOOSJr Assessments")]
    public bool? Has_THA_with_Initial_and_Follow_Up_HOOSJr_Assessments(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_THA_with_Initial_and_Follow_Up_HOOSJr_Assessments, Has_THA_with_Initial_and_Follow_Up_HOOSJr_Assessments_Compute);

    private const long _cacheIndex_Has_THA_with_Initial_and_Follow_Up_HOOSJr_Assessments = -3393965754895205370L;

    private bool? Has_THA_with_Initial_and_Follow_Up_HOOSJr_Assessments_Compute(CqlContext context)
    {
        IEnumerable<Procedure> a_ = this.Total_Hip_Arthroplasty_Procedure(context);

        CqlInterval<CqlDateTime> b_(Procedure THAProcedure) {
            object h_;
            DataType j_ = THAProcedure?.Performed;
            object k_ = FHIRHelpers_4_4_000.Instance.ToValue(context, j_);
            bool l_ = k_ is CqlDateTime;
            if (l_)
            {
                h_ = k_ as CqlDateTime;
            }
            else
            {
                bool m_ = k_ is CqlQuantity;
                if (m_)
                {
                    h_ = k_ as CqlQuantity;
                }
                else
                {
                    bool n_ = k_ is CqlInterval<CqlDateTime>;
                    if (n_)
                    {
                        h_ = k_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool o_ = k_ is CqlInterval<CqlQuantity>;
                        if (o_)
                        {
                            h_ = k_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            h_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> i_ = QICoreCommon_4_0_000.Instance.toInterval(context, h_);
            return i_;
        }

        IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.SelectDistinct<Procedure, CqlInterval<CqlDateTime>>(a_, b_);

        bool? d_(CqlInterval<CqlDateTime> TotalHip) {
            IEnumerable<CqlDate> p_ = this.Date_HOOSJr_Total_Assessment_Completed(context);

            bool? q_(CqlDate InitialHipAssessment) {
                CqlDateTime s_ = context.Operators.Start(TotalHip);
                CqlDateTime t_ = context.Operators.ConvertDateToDateTime(InitialHipAssessment);
                CqlQuantity u_ = context.Operators.Quantity(90m, "days");
                CqlDate v_ = context.Operators.Add(InitialHipAssessment, u_);
                CqlDateTime w_ = context.Operators.ConvertDateToDateTime(v_);
                CqlInterval<CqlDateTime> x_ = context.Operators.Interval(t_, w_, true, true);
                bool? y_ = context.Operators.In<CqlDateTime>(s_, x_, "day");
                return /* CQL 'and' (200:19-200:89) */ ((CqlBoolean)y_
                    && (CqlBoolean)(!((bool?)(InitialHipAssessment is null))));
            }

            bool? r_ = context.Operators.WhereAny<CqlDate>(p_, q_);
            return r_;
        }

        IEnumerable<CqlInterval<CqlDateTime>> e_ = context.Operators.Where<CqlInterval<CqlDateTime>>(c_, d_);

        bool? f_(CqlInterval<CqlDateTime> TotalHip) {
            IEnumerable<CqlDate> z_ = this.Date_HOOSJr_Total_Assessment_Completed(context);

            bool? aa_(CqlDate FollowUpHipAssessment) {
                CqlDateTime ac_ = context.Operators.ConvertDateToDateTime(FollowUpHipAssessment);
                CqlDate ad_ = context.Operators.DateFrom(ac_);
                CqlDateTime ae_ = context.Operators.End(TotalHip);
                CqlDate af_ = context.Operators.DateFrom(ae_);
                CqlQuantity ag_ = context.Operators.Quantity(300m, "days");
                CqlDate ah_ = context.Operators.Add(af_, ag_);
                CqlQuantity ai_ = context.Operators.Quantity(425m, "days");
                CqlDate aj_ = context.Operators.Add(af_, ai_);
                CqlInterval<CqlDate> ak_ = context.Operators.Interval(ah_, aj_, true, true);
                bool? al_ = context.Operators.In<CqlDate>(ad_, ak_, "day");
                return al_;
            }

            bool? ab_ = context.Operators.WhereAny<CqlDate>(z_, aa_);
            return ab_;
        }

        bool? g_ = context.Operators.WhereAny<CqlInterval<CqlDateTime>>(e_, f_);
        return g_;
    }


    [CqlExpressionDefinition("Date PROMIS10 Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_PROMIS10_Total_Assessment_Completed(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Date_PROMIS10_Total_Assessment_Completed, Date_PROMIS10_Total_Assessment_Completed_Compute);

    private const long _cacheIndex_Date_PROMIS10_Total_Assessment_Completed = -1003334648429625917L;

    private IEnumerable<CqlDate> Date_PROMIS10_Total_Assessment_Completed_Compute(CqlContext context)
    {
        CqlCode a_ = this.PROMIS_10_Global_Mental_Health__GMH__score_T_score(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
        IEnumerable<Observation> d_ = Status_1_15_000.Instance.isAssessmentPerformed(context, c_);
        CqlCode e_ = this.PROMIS_10_Global_Physical_Health__GPH__score_T_score(context);
        IEnumerable<CqlCode> f_ = context.Operators.ToList<CqlCode>(e_);
        IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, f_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
        IEnumerable<Observation> h_ = Status_1_15_000.Instance.isAssessmentPerformed(context, g_);
        IEnumerable<ValueTuple<Observation, Observation>> i_ = context.Operators.CrossJoin<Observation, Observation>(d_, h_);

        (CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)? j_(ValueTuple<Observation, Observation> _valueTuple) {
            (CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)? o_ = (CqlTupleMetadata_DDTAOdcFieSJbGgRLLZPYbGQb, _valueTuple.Item1, _valueTuple.Item2);
            return o_;
        }


        bool? k_((CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)? tuple_ddtaodcfiesjbggrllzpybgqb) {
            DataType p_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10MentalScore?.Effective;
            object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
            CqlInterval<CqlDateTime> r_ = QICoreCommon_4_0_000.Instance.toInterval(context, q_);
            CqlDateTime s_ = context.Operators.Start(r_);
            CqlDate t_ = context.Operators.DateFrom(s_);
            DataType u_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10PhysicalScore?.Effective;
            object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
            CqlInterval<CqlDateTime> w_ = QICoreCommon_4_0_000.Instance.toInterval(context, v_);
            CqlDateTime x_ = context.Operators.Start(w_);
            CqlDate y_ = context.Operators.DateFrom(x_);
            bool? z_ = context.Operators.SameAs(t_, y_, "day");

            CqlBoolean aa_() {
                DataType ac_ = (tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10PhysicalScore as Observation)?.Value;
                object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                return !((bool?)(ad_ is null));
            }


            CqlBoolean ab_() {
                DataType ae_ = (tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10MentalScore as Observation)?.Value;
                object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                return !((bool?)(af_ is null));
            }

            return /* CQL 'and' (225:5-227:85) */ (/* CQL 'and' (225:11-226:87) */ ((CqlBoolean)z_
                && aa_())
                && ab_());
        }

        IEnumerable<(CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?> l_ = context.Operators.SelectWhere<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?>(i_, j_, k_);

        CqlDate m_((CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)? tuple_ddtaodcfiesjbggrllzpybgqb) {
            DataType ag_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10MentalScore?.Effective;
            object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
            CqlInterval<CqlDateTime> ai_ = QICoreCommon_4_0_000.Instance.toInterval(context, ah_);
            CqlDateTime aj_ = context.Operators.Start(ai_);
            CqlDate ak_ = context.Operators.DateFrom(aj_);
            DataType al_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10PhysicalScore?.Effective;
            object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
            CqlInterval<CqlDateTime> an_ = QICoreCommon_4_0_000.Instance.toInterval(context, am_);
            CqlDateTime ao_ = context.Operators.Start(an_);
            CqlDate ap_ = context.Operators.DateFrom(ao_);
            CqlDate[] aq_ = [
                ak_,
                ap_,
            ];
            CqlDate ar_ = context.Operators.Max<CqlDate>((IEnumerable<CqlDate>)aq_);
            return ar_;
        }

        IEnumerable<CqlDate> n_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?, CqlDate>(l_, m_);
        return n_;
    }


    [CqlExpressionDefinition("Has THA with Initial and Follow Up PROMIS10 Assessments")]
    public bool? Has_THA_with_Initial_and_Follow_Up_PROMIS10_Assessments(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_THA_with_Initial_and_Follow_Up_PROMIS10_Assessments, Has_THA_with_Initial_and_Follow_Up_PROMIS10_Assessments_Compute);

    private const long _cacheIndex_Has_THA_with_Initial_and_Follow_Up_PROMIS10_Assessments = -4717330265822200184L;

    private bool? Has_THA_with_Initial_and_Follow_Up_PROMIS10_Assessments_Compute(CqlContext context)
    {
        IEnumerable<Procedure> a_ = this.Total_Hip_Arthroplasty_Procedure(context);

        CqlInterval<CqlDateTime> b_(Procedure THAProcedure) {
            object h_;
            DataType j_ = THAProcedure?.Performed;
            object k_ = FHIRHelpers_4_4_000.Instance.ToValue(context, j_);
            bool l_ = k_ is CqlDateTime;
            if (l_)
            {
                h_ = k_ as CqlDateTime;
            }
            else
            {
                bool m_ = k_ is CqlQuantity;
                if (m_)
                {
                    h_ = k_ as CqlQuantity;
                }
                else
                {
                    bool n_ = k_ is CqlInterval<CqlDateTime>;
                    if (n_)
                    {
                        h_ = k_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool o_ = k_ is CqlInterval<CqlQuantity>;
                        if (o_)
                        {
                            h_ = k_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            h_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> i_ = QICoreCommon_4_0_000.Instance.toInterval(context, h_);
            return i_;
        }

        IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.SelectDistinct<Procedure, CqlInterval<CqlDateTime>>(a_, b_);

        bool? d_(CqlInterval<CqlDateTime> TotalHip) {
            IEnumerable<CqlDate> p_ = this.Date_PROMIS10_Total_Assessment_Completed(context);

            bool? q_(CqlDate InitialHipAssessmentPROMIS10) {
                CqlDateTime s_ = context.Operators.Start(TotalHip);
                CqlDateTime t_ = context.Operators.ConvertDateToDateTime(InitialHipAssessmentPROMIS10);
                CqlQuantity u_ = context.Operators.Quantity(90m, "days");
                CqlDate v_ = context.Operators.Add(InitialHipAssessmentPROMIS10, u_);
                CqlDateTime w_ = context.Operators.ConvertDateToDateTime(v_);
                CqlInterval<CqlDateTime> x_ = context.Operators.Interval(t_, w_, true, true);
                bool? y_ = context.Operators.In<CqlDateTime>(s_, x_, "day");
                return /* CQL 'and' (214:19-214:97) */ ((CqlBoolean)y_
                    && (CqlBoolean)(!((bool?)(InitialHipAssessmentPROMIS10 is null))));
            }

            bool? r_ = context.Operators.WhereAny<CqlDate>(p_, q_);
            return r_;
        }

        IEnumerable<CqlInterval<CqlDateTime>> e_ = context.Operators.Where<CqlInterval<CqlDateTime>>(c_, d_);

        bool? f_(CqlInterval<CqlDateTime> TotalHip) {
            IEnumerable<CqlDate> z_ = this.Date_PROMIS10_Total_Assessment_Completed(context);

            bool? aa_(CqlDate FollowUpHipAssessmentPROMIS10) {
                CqlDateTime ac_ = context.Operators.ConvertDateToDateTime(FollowUpHipAssessmentPROMIS10);
                CqlDate ad_ = context.Operators.DateFrom(ac_);
                CqlDateTime ae_ = context.Operators.End(TotalHip);
                CqlDate af_ = context.Operators.DateFrom(ae_);
                CqlQuantity ag_ = context.Operators.Quantity(300m, "days");
                CqlDate ah_ = context.Operators.Add(af_, ag_);
                CqlQuantity ai_ = context.Operators.Quantity(425m, "days");
                CqlDate aj_ = context.Operators.Add(af_, ai_);
                CqlInterval<CqlDate> ak_ = context.Operators.Interval(ah_, aj_, true, true);
                bool? al_ = context.Operators.In<CqlDate>(ad_, ak_, "day");
                return al_;
            }

            bool? ab_ = context.Operators.WhereAny<CqlDate>(z_, aa_);
            return ab_;
        }

        bool? g_ = context.Operators.WhereAny<CqlInterval<CqlDateTime>>(e_, f_);
        return g_;
    }


    [CqlExpressionDefinition("Date VR12 Oblique Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_VR12_Oblique_Total_Assessment_Completed(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Date_VR12_Oblique_Total_Assessment_Completed, Date_VR12_Oblique_Total_Assessment_Completed_Compute);

    private const long _cacheIndex_Date_VR12_Oblique_Total_Assessment_Completed = 5787368887486105522L;

    private IEnumerable<CqlDate> Date_VR12_Oblique_Total_Assessment_Completed_Compute(CqlContext context)
    {
        CqlCode a_ = this.VR_12_Mental_component_summary__MCS__score___oblique_method_T_score(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
        IEnumerable<Observation> d_ = Status_1_15_000.Instance.isAssessmentPerformed(context, c_);
        CqlCode e_ = this.VR_12_Physical_component_summary__PCS__score___oblique_method_T_score(context);
        IEnumerable<CqlCode> f_ = context.Operators.ToList<CqlCode>(e_);
        IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, f_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
        IEnumerable<Observation> h_ = Status_1_15_000.Instance.isAssessmentPerformed(context, g_);
        IEnumerable<ValueTuple<Observation, Observation>> i_ = context.Operators.CrossJoin<Observation, Observation>(d_, h_);

        (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? j_(ValueTuple<Observation, Observation> _valueTuple) {
            (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? o_ = (CqlTupleMetadata_GAdRFKRaHUUGJcVHWQWRUjhRH, _valueTuple.Item1, _valueTuple.Item2);
            return o_;
        }


        bool? k_((CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? tuple_gadrfkrahuugjcvhwqwrujhrh) {
            DataType p_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Effective;
            object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
            CqlInterval<CqlDateTime> r_ = QICoreCommon_4_0_000.Instance.toInterval(context, q_);
            CqlDateTime s_ = context.Operators.Start(r_);
            CqlDate t_ = context.Operators.DateFrom(s_);
            DataType u_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Effective;
            object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
            CqlInterval<CqlDateTime> w_ = QICoreCommon_4_0_000.Instance.toInterval(context, v_);
            CqlDateTime x_ = context.Operators.Start(w_);
            CqlDate y_ = context.Operators.DateFrom(x_);
            bool? z_ = context.Operators.SameAs(t_, y_, "day");

            CqlBoolean aa_() {
                DataType ac_ = (tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment as Observation)?.Value;
                object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                return !((bool?)(ad_ is null));
            }


            CqlBoolean ab_() {
                DataType ae_ = (tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment as Observation)?.Value;
                object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                return !((bool?)(af_ is null));
            }

            return /* CQL 'and' (245:5-247:88) */ (/* CQL 'and' (245:11-246:86) */ ((CqlBoolean)z_
                && aa_())
                && ab_());
        }

        IEnumerable<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?> l_ = context.Operators.SelectWhere<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?>(i_, j_, k_);

        CqlDate m_((CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? tuple_gadrfkrahuugjcvhwqwrujhrh) {
            DataType ag_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Effective;
            object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
            CqlInterval<CqlDateTime> ai_ = QICoreCommon_4_0_000.Instance.toInterval(context, ah_);
            CqlDateTime aj_ = context.Operators.Start(ai_);
            CqlDate ak_ = context.Operators.DateFrom(aj_);
            DataType al_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Effective;
            object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
            CqlInterval<CqlDateTime> an_ = QICoreCommon_4_0_000.Instance.toInterval(context, am_);
            CqlDateTime ao_ = context.Operators.Start(an_);
            CqlDate ap_ = context.Operators.DateFrom(ao_);
            CqlDate[] aq_ = [
                ak_,
                ap_,
            ];
            CqlDate ar_ = context.Operators.Max<CqlDate>((IEnumerable<CqlDate>)aq_);
            return ar_;
        }

        IEnumerable<CqlDate> n_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?, CqlDate>(l_, m_);
        return n_;
    }


    [CqlExpressionDefinition("Has THA with Initial and Follow Up VR12 Oblique Assessments")]
    public bool? Has_THA_with_Initial_and_Follow_Up_VR12_Oblique_Assessments(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_THA_with_Initial_and_Follow_Up_VR12_Oblique_Assessments, Has_THA_with_Initial_and_Follow_Up_VR12_Oblique_Assessments_Compute);

    private const long _cacheIndex_Has_THA_with_Initial_and_Follow_Up_VR12_Oblique_Assessments = -8857932199387856860L;

    private bool? Has_THA_with_Initial_and_Follow_Up_VR12_Oblique_Assessments_Compute(CqlContext context)
    {
        IEnumerable<Procedure> a_ = this.Total_Hip_Arthroplasty_Procedure(context);

        CqlInterval<CqlDateTime> b_(Procedure THAProcedure) {
            object h_;
            DataType j_ = THAProcedure?.Performed;
            object k_ = FHIRHelpers_4_4_000.Instance.ToValue(context, j_);
            bool l_ = k_ is CqlDateTime;
            if (l_)
            {
                h_ = k_ as CqlDateTime;
            }
            else
            {
                bool m_ = k_ is CqlQuantity;
                if (m_)
                {
                    h_ = k_ as CqlQuantity;
                }
                else
                {
                    bool n_ = k_ is CqlInterval<CqlDateTime>;
                    if (n_)
                    {
                        h_ = k_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool o_ = k_ is CqlInterval<CqlQuantity>;
                        if (o_)
                        {
                            h_ = k_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            h_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> i_ = QICoreCommon_4_0_000.Instance.toInterval(context, h_);
            return i_;
        }

        IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.SelectDistinct<Procedure, CqlInterval<CqlDateTime>>(a_, b_);

        bool? d_(CqlInterval<CqlDateTime> TotalHip) {
            IEnumerable<CqlDate> p_ = this.Date_VR12_Oblique_Total_Assessment_Completed(context);

            bool? q_(CqlDate InitialHipAssessmentOblique) {
                CqlDateTime s_ = context.Operators.Start(TotalHip);
                CqlDateTime t_ = context.Operators.ConvertDateToDateTime(InitialHipAssessmentOblique);
                CqlQuantity u_ = context.Operators.Quantity(90m, "days");
                CqlDate v_ = context.Operators.Add(InitialHipAssessmentOblique, u_);
                CqlDateTime w_ = context.Operators.ConvertDateToDateTime(v_);
                CqlInterval<CqlDateTime> x_ = context.Operators.Interval(t_, w_, true, true);
                bool? y_ = context.Operators.In<CqlDateTime>(s_, x_, "day");
                return /* CQL 'and' (234:19-234:96) */ ((CqlBoolean)y_
                    && (CqlBoolean)(!((bool?)(InitialHipAssessmentOblique is null))));
            }

            bool? r_ = context.Operators.WhereAny<CqlDate>(p_, q_);
            return r_;
        }

        IEnumerable<CqlInterval<CqlDateTime>> e_ = context.Operators.Where<CqlInterval<CqlDateTime>>(c_, d_);

        bool? f_(CqlInterval<CqlDateTime> TotalHip) {
            IEnumerable<CqlDate> z_ = this.Date_VR12_Oblique_Total_Assessment_Completed(context);

            bool? aa_(CqlDate FollowUpHipAssessmentOblique) {
                CqlDateTime ac_ = context.Operators.ConvertDateToDateTime(FollowUpHipAssessmentOblique);
                CqlDate ad_ = context.Operators.DateFrom(ac_);
                CqlDateTime ae_ = context.Operators.End(TotalHip);
                CqlDate af_ = context.Operators.DateFrom(ae_);
                CqlQuantity ag_ = context.Operators.Quantity(300m, "days");
                CqlDate ah_ = context.Operators.Add(af_, ag_);
                CqlQuantity ai_ = context.Operators.Quantity(425m, "days");
                CqlDate aj_ = context.Operators.Add(af_, ai_);
                CqlInterval<CqlDate> ak_ = context.Operators.Interval(ah_, aj_, true, true);
                bool? al_ = context.Operators.In<CqlDate>(ad_, ak_, "day");
                return al_;
            }

            bool? ab_ = context.Operators.WhereAny<CqlDate>(z_, aa_);
            return ab_;
        }

        bool? g_ = context.Operators.WhereAny<CqlInterval<CqlDateTime>>(e_, f_);
        return g_;
    }


    [CqlExpressionDefinition("Date VR12 Orthogonal Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_VR12_Orthogonal_Total_Assessment_Completed(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Date_VR12_Orthogonal_Total_Assessment_Completed, Date_VR12_Orthogonal_Total_Assessment_Completed_Compute);

    private const long _cacheIndex_Date_VR12_Orthogonal_Total_Assessment_Completed = 4960693320813654296L;

    private IEnumerable<CqlDate> Date_VR12_Orthogonal_Total_Assessment_Completed_Compute(CqlContext context)
    {
        CqlCode a_ = this.VR_12_Mental_component_summary__MCS__score___orthogonal_method_T_score(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
        IEnumerable<Observation> d_ = Status_1_15_000.Instance.isAssessmentPerformed(context, c_);
        CqlCode e_ = this.VR_12_Physical_component_summary__PCS__score___orthogonal_method_T_score(context);
        IEnumerable<CqlCode> f_ = context.Operators.ToList<CqlCode>(e_);
        IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, f_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
        IEnumerable<Observation> h_ = Status_1_15_000.Instance.isAssessmentPerformed(context, g_);
        IEnumerable<ValueTuple<Observation, Observation>> i_ = context.Operators.CrossJoin<Observation, Observation>(d_, h_);

        (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? j_(ValueTuple<Observation, Observation> _valueTuple) {
            (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? o_ = (CqlTupleMetadata_GAdRFKRaHUUGJcVHWQWRUjhRH, _valueTuple.Item1, _valueTuple.Item2);
            return o_;
        }


        bool? k_((CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? tuple_gadrfkrahuugjcvhwqwrujhrh) {
            DataType p_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Effective;
            object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
            CqlInterval<CqlDateTime> r_ = QICoreCommon_4_0_000.Instance.toInterval(context, q_);
            CqlDateTime s_ = context.Operators.Start(r_);
            CqlDate t_ = context.Operators.DateFrom(s_);
            DataType u_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Effective;
            object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
            CqlInterval<CqlDateTime> w_ = QICoreCommon_4_0_000.Instance.toInterval(context, v_);
            CqlDateTime x_ = context.Operators.Start(w_);
            CqlDate y_ = context.Operators.DateFrom(x_);
            bool? z_ = context.Operators.SameAs(t_, y_, "day");

            CqlBoolean aa_() {
                DataType ac_ = (tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment as Observation)?.Value;
                object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                return !((bool?)(ad_ is null));
            }


            CqlBoolean ab_() {
                DataType ae_ = (tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment as Observation)?.Value;
                object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                return !((bool?)(af_ is null));
            }

            return /* CQL 'and' (265:5-267:88) */ (/* CQL 'and' (265:11-266:86) */ ((CqlBoolean)z_
                && aa_())
                && ab_());
        }

        IEnumerable<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?> l_ = context.Operators.SelectWhere<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?>(i_, j_, k_);

        CqlDate m_((CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? tuple_gadrfkrahuugjcvhwqwrujhrh) {
            DataType ag_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Effective;
            object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
            CqlInterval<CqlDateTime> ai_ = QICoreCommon_4_0_000.Instance.toInterval(context, ah_);
            CqlDateTime aj_ = context.Operators.Start(ai_);
            CqlDate ak_ = context.Operators.DateFrom(aj_);
            DataType al_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Effective;
            object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
            CqlInterval<CqlDateTime> an_ = QICoreCommon_4_0_000.Instance.toInterval(context, am_);
            CqlDateTime ao_ = context.Operators.Start(an_);
            CqlDate ap_ = context.Operators.DateFrom(ao_);
            CqlDate[] aq_ = [
                ak_,
                ap_,
            ];
            CqlDate ar_ = context.Operators.Max<CqlDate>((IEnumerable<CqlDate>)aq_);
            return ar_;
        }

        IEnumerable<CqlDate> n_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?, CqlDate>(l_, m_);
        return n_;
    }


    [CqlExpressionDefinition("Has THA with Initial and Follow Up VR12 Orthogonal Assessments")]
    public bool? Has_THA_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_THA_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments, Has_THA_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments_Compute);

    private const long _cacheIndex_Has_THA_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments = -9051604538390399750L;

    private bool? Has_THA_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments_Compute(CqlContext context)
    {
        IEnumerable<Procedure> a_ = this.Total_Hip_Arthroplasty_Procedure(context);

        CqlInterval<CqlDateTime> b_(Procedure THAProcedure) {
            object h_;
            DataType j_ = THAProcedure?.Performed;
            object k_ = FHIRHelpers_4_4_000.Instance.ToValue(context, j_);
            bool l_ = k_ is CqlDateTime;
            if (l_)
            {
                h_ = k_ as CqlDateTime;
            }
            else
            {
                bool m_ = k_ is CqlQuantity;
                if (m_)
                {
                    h_ = k_ as CqlQuantity;
                }
                else
                {
                    bool n_ = k_ is CqlInterval<CqlDateTime>;
                    if (n_)
                    {
                        h_ = k_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool o_ = k_ is CqlInterval<CqlQuantity>;
                        if (o_)
                        {
                            h_ = k_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            h_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> i_ = QICoreCommon_4_0_000.Instance.toInterval(context, h_);
            return i_;
        }

        IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.SelectDistinct<Procedure, CqlInterval<CqlDateTime>>(a_, b_);

        bool? d_(CqlInterval<CqlDateTime> TotalHip) {
            IEnumerable<CqlDate> p_ = this.Date_VR12_Orthogonal_Total_Assessment_Completed(context);

            bool? q_(CqlDate InitialHipAssessmentOrthogonal) {
                CqlDateTime s_ = context.Operators.Start(TotalHip);
                CqlDateTime t_ = context.Operators.ConvertDateToDateTime(InitialHipAssessmentOrthogonal);
                CqlQuantity u_ = context.Operators.Quantity(90m, "days");
                CqlDate v_ = context.Operators.Add(InitialHipAssessmentOrthogonal, u_);
                CqlDateTime w_ = context.Operators.ConvertDateToDateTime(v_);
                CqlInterval<CqlDateTime> x_ = context.Operators.Interval(t_, w_, true, true);
                bool? y_ = context.Operators.In<CqlDateTime>(s_, x_, "day");
                return /* CQL 'and' (254:19-254:99) */ ((CqlBoolean)y_
                    && (CqlBoolean)(!((bool?)(InitialHipAssessmentOrthogonal is null))));
            }

            bool? r_ = context.Operators.WhereAny<CqlDate>(p_, q_);
            return r_;
        }

        IEnumerable<CqlInterval<CqlDateTime>> e_ = context.Operators.Where<CqlInterval<CqlDateTime>>(c_, d_);

        bool? f_(CqlInterval<CqlDateTime> TotalHip) {
            IEnumerable<CqlDate> z_ = this.Date_VR12_Orthogonal_Total_Assessment_Completed(context);

            bool? aa_(CqlDate FollowUpHipAssessmentOrthogonal) {
                CqlDateTime ac_ = context.Operators.ConvertDateToDateTime(FollowUpHipAssessmentOrthogonal);
                CqlDate ad_ = context.Operators.DateFrom(ac_);
                CqlDateTime ae_ = context.Operators.End(TotalHip);
                CqlDate af_ = context.Operators.DateFrom(ae_);
                CqlQuantity ag_ = context.Operators.Quantity(300m, "days");
                CqlDate ah_ = context.Operators.Add(af_, ag_);
                CqlQuantity ai_ = context.Operators.Quantity(425m, "days");
                CqlDate aj_ = context.Operators.Add(af_, ai_);
                CqlInterval<CqlDate> ak_ = context.Operators.Interval(ah_, aj_, true, true);
                bool? al_ = context.Operators.In<CqlDate>(ad_, ak_, "day");
                return al_;
            }

            bool? ab_ = context.Operators.WhereAny<CqlDate>(z_, aa_);
            return ab_;
        }

        bool? g_ = context.Operators.WhereAny<CqlInterval<CqlDateTime>>(e_, f_);
        return g_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = 2421359684672176818L;

    private bool? Numerator_Compute(CqlContext context)
    {
        bool? a_ = this.Has_THA_with_Initial_and_Follow_Up_HOOS_Assessments(context);
        return /* CQL 'or' (158:3-162:75) */ (/* CQL 'or' (158:3-161:72) */ (/* CQL 'or' (158:3-160:68) */ (/* CQL 'or' (158:3-159:66) */ ((CqlBoolean)a_
            || (CqlBoolean)(this.Has_THA_with_Initial_and_Follow_Up_HOOSJr_Assessments(context)))
            || (CqlBoolean)(this.Has_THA_with_Initial_and_Follow_Up_PROMIS10_Assessments(context)))
            || (CqlBoolean)(this.Has_THA_with_Initial_and_Follow_Up_VR12_Oblique_Assessments(context)))
            || (CqlBoolean)(this.Has_THA_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments(context)));
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private CMS56FHIRFuncStatHipReplacement_1_0_000() {}

    public static CMS56FHIRFuncStatHipReplacement_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS56FHIRFuncStatHipReplacement";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, QICoreCommon_4_0_000.Instance, SupplementalDataElements_5_1_000.Instance, Hospice_6_18_000.Instance, Status_1_15_000.Instance];

    #endregion ILibrary Implementation

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_DDTAOdcFieSJbGgRLLZPYbGQb = new(
       [typeof(Observation), typeof(Observation)],
       ["PROMIS10MentalScore", "PROMIS10PhysicalScore"]);

    private static CqlTupleMetadata CqlTupleMetadata_GAdRFKRaHUUGJcVHWQWRUjhRH = new(
       [typeof(Observation), typeof(Observation)],
       ["VR12MentalAssessment", "VR12PhysicalAssessment"]);

    private static CqlTupleMetadata CqlTupleMetadata_GVNUVHGXYWXVGgfjdTEahUfhP = new(
       [typeof(Observation), typeof(Observation), typeof(Observation), typeof(Observation), typeof(Observation)],
       ["HOOSLifeQuality", "HOOSSport", "HOOSActivityScore", "HOOSSymptoms", "HOOSPain"]);

    #endregion CqlTupleMetadata Properties

}
