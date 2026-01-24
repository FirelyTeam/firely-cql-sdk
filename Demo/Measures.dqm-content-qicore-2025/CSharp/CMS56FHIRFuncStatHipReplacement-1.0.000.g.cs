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
[CqlLibrary("CMS56FHIRFuncStatHipReplacement", "1.0.000")]
public partial class CMS56FHIRFuncStatHipReplacement_1_0_000 : ILibrary, ILibraryInternals, ISingleton<CMS56FHIRFuncStatHipReplacement_1_0_000>
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
        _cache?.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute, context) ?? Measurement_Period_Compute(context);

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
        _cache?.GetOrCompute(_cacheIndex_Patient, Patient_Compute, context) ?? Patient_Compute(context);

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute, context) ?? SDE_Ethnicity_Compute(context);

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute, context) ?? SDE_Payer_Compute(context);

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute, context) ?? SDE_Race_Compute(context);

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute, context) ?? SDE_Sex_Compute(context);

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    [CqlExpressionDefinition("August 1 Year Prior to the Measurement Period")]
    public CqlDateTime August_1_Year_Prior_to_the_Measurement_Period(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_August_1_Year_Prior_to_the_Measurement_Period, August_1_Year_Prior_to_the_Measurement_Period_Compute, context) ?? August_1_Year_Prior_to_the_Measurement_Period_Compute(context);

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
        _cache?.GetOrCompute(_cacheIndex_Has_Qualifying_Encounter, Has_Qualifying_Encounter_Compute, context) ?? Has_Qualifying_Encounter_Compute(context);

    private bool? Has_Qualifying_Encounter_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet c_ = this.Office_Visit(context);
        IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
        IEnumerable<Encounter> f_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

        bool? g_(Encounter E) {
            List<CodeableConcept> t_ = E?.Type;

            CqlConcept u_(CodeableConcept @this) {
                CqlConcept z_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return z_;
            }

            IEnumerable<CqlConcept> v_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)t_, u_);

            bool? w_(CqlConcept T) {
                CqlCode aa_ = this.Postoperative_follow_up_visit__normally_included_in_the_surgical_package__to_indicate_that_an_evaluation_and_management_service_was_performed_during_a_postoperative_period_for_a_reason_s__related_to_the_original_procedure(context);
                CqlConcept ab_ = context.Operators.ConvertCodeToConcept(aa_);
                bool? ac_ = context.Operators.Equivalent(T, ab_);
                return ac_;
            }

            IEnumerable<CqlConcept> x_ = context.Operators.Where<CqlConcept>(v_, w_);
            bool? y_ = context.Operators.Exists<CqlConcept>(x_);
            return y_;
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
            CqlDateTime ad_ = this.August_1_Year_Prior_to_the_Measurement_Period(context);
            CqlInterval<CqlDateTime> ae_ = this.Measurement_Period(context);
            CqlDateTime af_ = context.Operators.End(ae_);
            CqlInterval<CqlDateTime> ag_ = context.Operators.Interval(ad_, af_, true, true);
            Period ah_ = ValidEncounters?.Period;
            CqlInterval<CqlDateTime> ai_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ah_);
            bool? aj_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ag_, ai_, "day");
            return aj_;
        }

        IEnumerable<Encounter> r_ = context.Operators.Where<Encounter>(p_, q_);
        bool? s_ = context.Operators.Exists<Encounter>(r_);
        return s_;
    }


    [CqlExpressionDefinition("November 1 Two Years Prior to the Measurement Period")]
    public CqlDateTime November_1_Two_Years_Prior_to_the_Measurement_Period(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_November_1_Two_Years_Prior_to_the_Measurement_Period, November_1_Two_Years_Prior_to_the_Measurement_Period_Compute, context) ?? November_1_Two_Years_Prior_to_the_Measurement_Period_Compute(context);

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
        _cache?.GetOrCompute(_cacheIndex_October_31_Year_Prior_to_the_Measurement_Period, October_31_Year_Prior_to_the_Measurement_Period_Compute, context) ?? October_31_Year_Prior_to_the_Measurement_Period_Compute(context);

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
        _cache?.GetOrCompute(_cacheIndex_Total_Hip_Arthroplasty_Procedure, Total_Hip_Arthroplasty_Procedure_Compute, context) ?? Total_Hip_Arthroplasty_Procedure_Compute(context);

    private IEnumerable<Procedure> Total_Hip_Arthroplasty_Procedure_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Primary_THA_Procedure(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> c_ = Status_1_15_000.Instance.isProcedurePerformed(context, b_);

        bool? d_(Procedure THAProcedure) {

            object f_() {

                bool m_() {
                    DataType q_ = THAProcedure?.Performed;
                    object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                    bool s_ = r_ is CqlDateTime;
                    return s_;
                }


                bool n_() {
                    DataType t_ = THAProcedure?.Performed;
                    object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                    bool v_ = u_ is CqlInterval<CqlDateTime>;
                    return v_;
                }


                bool o_() {
                    DataType w_ = THAProcedure?.Performed;
                    object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                    bool y_ = x_ is CqlQuantity;
                    return y_;
                }


                bool p_() {
                    DataType z_ = THAProcedure?.Performed;
                    object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                    bool ab_ = aa_ is CqlInterval<CqlQuantity>;
                    return ab_;
                }

                if (m_())
                {
                    DataType ac_ = THAProcedure?.Performed;
                    object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                    return (ad_ as CqlDateTime) as object;
                }
                else if (n_())
                {
                    DataType ae_ = THAProcedure?.Performed;
                    object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                    return (af_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (o_())
                {
                    DataType ag_ = THAProcedure?.Performed;
                    object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                    return (ah_ as CqlQuantity) as object;
                }
                else if (p_())
                {
                    DataType ai_ = THAProcedure?.Performed;
                    object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                    return (aj_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> g_ = QICoreCommon_4_0_000.Instance.toInterval(context, f_());
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
        _cache?.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute, context) ?? Initial_Population_Compute(context);

    private bool? Initial_Population_Compute(CqlContext context)
    {
        bool? a_ = this.Has_Qualifying_Encounter(context);
        IEnumerable<Procedure> b_ = this.Total_Hip_Arthroplasty_Procedure(context);
        bool? c_ = context.Operators.Exists<Procedure>(b_);
        bool? d_ = context.Operators.And(a_, c_);
        Patient e_ = this.Patient(context);
        Date f_ = e_?.BirthDateElement;
        string g_ = f_?.Value;
        CqlDate h_ = context.Operators.ConvertStringToDate(g_);
        CqlInterval<CqlDateTime> i_ = this.Measurement_Period(context);
        CqlDateTime j_ = context.Operators.Start(i_);
        CqlDate k_ = context.Operators.DateFrom(j_);
        int? l_ = context.Operators.CalculateAgeAt(h_, k_, "year");
        bool? m_ = context.Operators.GreaterOrEqual(l_, 19);
        bool? n_ = context.Operators.And(d_, m_);
        return n_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute, context) ?? Denominator_Compute(context);

    private bool? Denominator_Compute(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlExpressionDefinition("Has Severe Cognitive Impairment")]
    public bool? Has_Severe_Cognitive_Impairment(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Has_Severe_Cognitive_Impairment, Has_Severe_Cognitive_Impairment_Compute, context) ?? Has_Severe_Cognitive_Impairment_Compute(context);

    private bool? Has_Severe_Cognitive_Impairment_Compute(CqlContext context)
    {
        CqlCode a_ = this.Severe_cognitive_impairment__finding_(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<CqlCode> e_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Condition> f_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, e_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<object> g_ = context.Operators.Union<object>(c_ as IEnumerable<object>, f_ as IEnumerable<object>);

        bool? h_(object Dementia) {
            CqlInterval<CqlDateTime> k_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, Dementia);
            CqlInterval<CqlDateTime> l_ = this.Measurement_Period(context);
            bool? m_ = context.Operators.Overlaps(k_, l_, "day");
            return m_;
        }

        IEnumerable<object> i_ = context.Operators.Where<object>(g_, h_);
        bool? j_ = context.Operators.Exists<object>(i_);
        return j_;
    }


    [CqlFunctionDefinition("isVerified")]
    [CqlTag("note", "When possible, this function should be migrated to QICoreCommon.")]
    [CqlTag("description", "\"confirmed\", \"unconfirmed\", \"provisional\", or \"differential\"")]
    public bool? isVerified(CqlContext context, object condition)
    {
        object a_ = context.Operators.LateBoundProperty<object>(condition, "verificationStatus");
        CqlConcept b_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_ as CodeableConcept);
        bool? c_ = context.Operators.Not((bool?)(b_ is null));
        CqlConcept e_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_ as CodeableConcept);
        CqlCode f_ = QICoreCommon_4_0_000.Instance.confirmed(context);
        CqlConcept g_ = context.Operators.ConvertCodeToConcept(f_);
        bool? h_ = context.Operators.Equivalent(e_, g_);
        CqlConcept j_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_ as CodeableConcept);
        CqlCode k_ = QICoreCommon_4_0_000.Instance.unconfirmed(context);
        CqlConcept l_ = context.Operators.ConvertCodeToConcept(k_);
        bool? m_ = context.Operators.Equivalent(j_, l_);
        bool? n_ = context.Operators.Or(h_, m_);
        CqlConcept p_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_ as CodeableConcept);
        CqlCode q_ = QICoreCommon_4_0_000.Instance.provisional(context);
        CqlConcept r_ = context.Operators.ConvertCodeToConcept(q_);
        bool? s_ = context.Operators.Equivalent(p_, r_);
        bool? t_ = context.Operators.Or(n_, s_);
        CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_ as CodeableConcept);
        CqlCode w_ = QICoreCommon_4_0_000.Instance.differential(context);
        CqlConcept x_ = context.Operators.ConvertCodeToConcept(w_);
        bool? y_ = context.Operators.Equivalent(v_, x_);
        bool? z_ = context.Operators.Or(t_, y_);
        bool? aa_ = context.Operators.Implies(c_, z_);
        return aa_;
    }


    [CqlExpressionDefinition("Has Total Hip Arthroplasty with 1 or More Lower Body Fractures")]
    public bool? Has_Total_Hip_Arthroplasty_with_1_or_More_Lower_Body_Fractures(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Has_Total_Hip_Arthroplasty_with_1_or_More_Lower_Body_Fractures, Has_Total_Hip_Arthroplasty_with_1_or_More_Lower_Body_Fractures_Compute, context) ?? Has_Total_Hip_Arthroplasty_with_1_or_More_Lower_Body_Fractures_Compute(context);

    private bool? Has_Total_Hip_Arthroplasty_with_1_or_More_Lower_Body_Fractures_Compute(CqlContext context)
    {
        IEnumerable<Procedure> a_ = this.Total_Hip_Arthroplasty_Procedure(context);

        IEnumerable<Procedure> b_(Procedure THAProcedure) {
            CqlValueSet e_ = this.Lower_Body_Fractures_Excluding_Ankle_and_Foot(context);
            IEnumerable<Condition> f_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> h_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<object> i_ = context.Operators.Union<object>(f_ as IEnumerable<object>, h_ as IEnumerable<object>);

            bool? j_(object LowerBodyFracture) {
                CqlInterval<CqlDateTime> n_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, LowerBodyFracture);
                CqlDateTime o_ = context.Operators.Start(n_);

                object p_() {

                    bool ag_() {
                        DataType ak_ = THAProcedure?.Performed;
                        object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                        bool am_ = al_ is CqlDateTime;
                        return am_;
                    }


                    bool ah_() {
                        DataType an_ = THAProcedure?.Performed;
                        object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                        bool ap_ = ao_ is CqlInterval<CqlDateTime>;
                        return ap_;
                    }


                    bool ai_() {
                        DataType aq_ = THAProcedure?.Performed;
                        object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                        bool as_ = ar_ is CqlQuantity;
                        return as_;
                    }


                    bool aj_() {
                        DataType at_ = THAProcedure?.Performed;
                        object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                        bool av_ = au_ is CqlInterval<CqlQuantity>;
                        return av_;
                    }

                    if (ag_())
                    {
                        DataType aw_ = THAProcedure?.Performed;
                        object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                        return (ax_ as CqlDateTime) as object;
                    }
                    else if (ah_())
                    {
                        DataType ay_ = THAProcedure?.Performed;
                        object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                        return (az_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (ai_())
                    {
                        DataType ba_ = THAProcedure?.Performed;
                        object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                        return (bb_ as CqlQuantity) as object;
                    }
                    else if (aj_())
                    {
                        DataType bc_ = THAProcedure?.Performed;
                        object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                        return (bd_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> q_ = QICoreCommon_4_0_000.Instance.toInterval(context, p_());
                CqlDateTime r_ = context.Operators.Start(q_);
                CqlQuantity s_ = context.Operators.Quantity(48m, "hours");
                CqlDateTime t_ = context.Operators.Subtract(r_, s_);

                object u_() {

                    bool be_() {
                        DataType bi_ = THAProcedure?.Performed;
                        object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                        bool bk_ = bj_ is CqlDateTime;
                        return bk_;
                    }


                    bool bf_() {
                        DataType bl_ = THAProcedure?.Performed;
                        object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                        bool bn_ = bm_ is CqlInterval<CqlDateTime>;
                        return bn_;
                    }


                    bool bg_() {
                        DataType bo_ = THAProcedure?.Performed;
                        object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                        bool bq_ = bp_ is CqlQuantity;
                        return bq_;
                    }


                    bool bh_() {
                        DataType br_ = THAProcedure?.Performed;
                        object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
                        bool bt_ = bs_ is CqlInterval<CqlQuantity>;
                        return bt_;
                    }

                    if (be_())
                    {
                        DataType bu_ = THAProcedure?.Performed;
                        object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                        return (bv_ as CqlDateTime) as object;
                    }
                    else if (bf_())
                    {
                        DataType bw_ = THAProcedure?.Performed;
                        object bx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bw_);
                        return (bx_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (bg_())
                    {
                        DataType by_ = THAProcedure?.Performed;
                        object bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);
                        return (bz_ as CqlQuantity) as object;
                    }
                    else if (bh_())
                    {
                        DataType ca_ = THAProcedure?.Performed;
                        object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                        return (cb_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> v_ = QICoreCommon_4_0_000.Instance.toInterval(context, u_());
                CqlDateTime w_ = context.Operators.Start(v_);
                CqlInterval<CqlDateTime> x_ = context.Operators.Interval(t_, w_, true, true);
                bool? y_ = context.Operators.In<CqlDateTime>(o_, x_, default);

                object z_() {

                    bool cc_() {
                        DataType cg_ = THAProcedure?.Performed;
                        object ch_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cg_);
                        bool ci_ = ch_ is CqlDateTime;
                        return ci_;
                    }


                    bool cd_() {
                        DataType cj_ = THAProcedure?.Performed;
                        object ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
                        bool cl_ = ck_ is CqlInterval<CqlDateTime>;
                        return cl_;
                    }


                    bool ce_() {
                        DataType cm_ = THAProcedure?.Performed;
                        object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                        bool co_ = cn_ is CqlQuantity;
                        return co_;
                    }


                    bool cf_() {
                        DataType cp_ = THAProcedure?.Performed;
                        object cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
                        bool cr_ = cq_ is CqlInterval<CqlQuantity>;
                        return cr_;
                    }

                    if (cc_())
                    {
                        DataType cs_ = THAProcedure?.Performed;
                        object ct_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cs_);
                        return (ct_ as CqlDateTime) as object;
                    }
                    else if (cd_())
                    {
                        DataType cu_ = THAProcedure?.Performed;
                        object cv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cu_);
                        return (cv_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (ce_())
                    {
                        DataType cw_ = THAProcedure?.Performed;
                        object cx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cw_);
                        return (cx_ as CqlQuantity) as object;
                    }
                    else if (cf_())
                    {
                        DataType cy_ = THAProcedure?.Performed;
                        object cz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cy_);
                        return (cz_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> aa_ = QICoreCommon_4_0_000.Instance.toInterval(context, z_());
                CqlDateTime ab_ = context.Operators.Start(aa_);
                bool? ac_ = context.Operators.Not((bool?)(ab_ is null));
                bool? ad_ = context.Operators.And(y_, ac_);
                bool? ae_ = this.isVerified(context, LowerBodyFracture);
                bool? af_ = context.Operators.And(ad_, ae_);
                return af_;
            }

            IEnumerable<object> k_ = context.Operators.Where<object>(i_, j_);
            Procedure l_(object LowerBodyFracture) => THAProcedure;
            IEnumerable<Procedure> m_ = context.Operators.Select<object, Procedure>(k_, l_);
            return m_;
        }

        IEnumerable<Procedure> c_ = context.Operators.SelectMany<Procedure, Procedure>(a_, b_);
        bool? d_ = context.Operators.Exists<Procedure>(c_);
        return d_;
    }


    [CqlExpressionDefinition("Has Partial Hip Arthroplasty Procedure")]
    public bool? Has_Partial_Hip_Arthroplasty_Procedure(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Has_Partial_Hip_Arthroplasty_Procedure, Has_Partial_Hip_Arthroplasty_Procedure_Compute, context) ?? Has_Partial_Hip_Arthroplasty_Procedure_Compute(context);

    private bool? Has_Partial_Hip_Arthroplasty_Procedure_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Partial_Arthroplasty_of_Hip(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> c_ = Status_1_15_000.Instance.isProcedurePerformed(context, b_);

        IEnumerable<Procedure> d_(Procedure PartialTHAProcedure) {
            IEnumerable<Procedure> g_ = this.Total_Hip_Arthroplasty_Procedure(context);

            bool? h_(Procedure THAProcedure) {

                object l_() {

                    bool q_() {
                        DataType u_ = THAProcedure?.Performed;
                        object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                        bool w_ = v_ is CqlDateTime;
                        return w_;
                    }


                    bool r_() {
                        DataType x_ = THAProcedure?.Performed;
                        object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                        bool z_ = y_ is CqlInterval<CqlDateTime>;
                        return z_;
                    }


                    bool s_() {
                        DataType aa_ = THAProcedure?.Performed;
                        object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                        bool ac_ = ab_ is CqlQuantity;
                        return ac_;
                    }


                    bool t_() {
                        DataType ad_ = THAProcedure?.Performed;
                        object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                        bool af_ = ae_ is CqlInterval<CqlQuantity>;
                        return af_;
                    }

                    if (q_())
                    {
                        DataType ag_ = THAProcedure?.Performed;
                        object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                        return (ah_ as CqlDateTime) as object;
                    }
                    else if (r_())
                    {
                        DataType ai_ = THAProcedure?.Performed;
                        object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                        return (aj_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (s_())
                    {
                        DataType ak_ = THAProcedure?.Performed;
                        object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                        return (al_ as CqlQuantity) as object;
                    }
                    else if (t_())
                    {
                        DataType am_ = THAProcedure?.Performed;
                        object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                        return (an_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> m_ = QICoreCommon_4_0_000.Instance.toInterval(context, l_());

                object n_() {

                    bool ao_() {
                        DataType as_ = PartialTHAProcedure?.Performed;
                        object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                        bool au_ = at_ is CqlDateTime;
                        return au_;
                    }


                    bool ap_() {
                        DataType av_ = PartialTHAProcedure?.Performed;
                        object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                        bool ax_ = aw_ is CqlInterval<CqlDateTime>;
                        return ax_;
                    }


                    bool aq_() {
                        DataType ay_ = PartialTHAProcedure?.Performed;
                        object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                        bool ba_ = az_ is CqlQuantity;
                        return ba_;
                    }


                    bool ar_() {
                        DataType bb_ = PartialTHAProcedure?.Performed;
                        object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                        bool bd_ = bc_ is CqlInterval<CqlQuantity>;
                        return bd_;
                    }

                    if (ao_())
                    {
                        DataType be_ = PartialTHAProcedure?.Performed;
                        object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                        return (bf_ as CqlDateTime) as object;
                    }
                    else if (ap_())
                    {
                        DataType bg_ = PartialTHAProcedure?.Performed;
                        object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                        return (bh_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (aq_())
                    {
                        DataType bi_ = PartialTHAProcedure?.Performed;
                        object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                        return (bj_ as CqlQuantity) as object;
                    }
                    else if (ar_())
                    {
                        DataType bk_ = PartialTHAProcedure?.Performed;
                        object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                        return (bl_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> o_ = QICoreCommon_4_0_000.Instance.toInterval(context, n_());
                bool? p_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(m_, o_, "day");
                return p_;
            }

            IEnumerable<Procedure> i_ = context.Operators.Where<Procedure>(g_, h_);
            Procedure j_(Procedure THAProcedure) => PartialTHAProcedure;
            IEnumerable<Procedure> k_ = context.Operators.Select<Procedure, Procedure>(i_, j_);
            return k_;
        }

        IEnumerable<Procedure> e_ = context.Operators.SelectMany<Procedure, Procedure>(c_, d_);
        bool? f_ = context.Operators.Exists<Procedure>(e_);
        return f_;
    }


    [CqlExpressionDefinition("Has Revision Hip Arthroplasty Procedure or Implanted Device or Prosthesis Removal Procedure")]
    public bool? Has_Revision_Hip_Arthroplasty_Procedure_or_Implanted_Device_or_Prosthesis_Removal_Procedure(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Has_Revision_Hip_Arthroplasty_Procedure_or_Implanted_Device_or_Prosthesis_Removal_Procedure, Has_Revision_Hip_Arthroplasty_Procedure_or_Implanted_Device_or_Prosthesis_Removal_Procedure_Compute, context) ?? Has_Revision_Hip_Arthroplasty_Procedure_or_Implanted_Device_or_Prosthesis_Removal_Procedure_Compute(context);

    private bool? Has_Revision_Hip_Arthroplasty_Procedure_or_Implanted_Device_or_Prosthesis_Removal_Procedure_Compute(CqlContext context)
    {
        IEnumerable<Procedure> a_ = this.Total_Hip_Arthroplasty_Procedure(context);

        IEnumerable<Procedure> b_(Procedure THAProcedure) {
            CqlValueSet e_ = this.Removal__Revision_and_Supplement_Procedures_of_the_Lower_Body_and_Spine(context);
            IEnumerable<Procedure> f_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            IEnumerable<Procedure> g_ = Status_1_15_000.Instance.isProcedurePerformed(context, f_);

            bool? h_(Procedure RevisionTHAProcedure) {

                object l_() {

                    bool q_() {
                        DataType u_ = THAProcedure?.Performed;
                        object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                        bool w_ = v_ is CqlDateTime;
                        return w_;
                    }


                    bool r_() {
                        DataType x_ = THAProcedure?.Performed;
                        object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                        bool z_ = y_ is CqlInterval<CqlDateTime>;
                        return z_;
                    }


                    bool s_() {
                        DataType aa_ = THAProcedure?.Performed;
                        object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                        bool ac_ = ab_ is CqlQuantity;
                        return ac_;
                    }


                    bool t_() {
                        DataType ad_ = THAProcedure?.Performed;
                        object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                        bool af_ = ae_ is CqlInterval<CqlQuantity>;
                        return af_;
                    }

                    if (q_())
                    {
                        DataType ag_ = THAProcedure?.Performed;
                        object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                        return (ah_ as CqlDateTime) as object;
                    }
                    else if (r_())
                    {
                        DataType ai_ = THAProcedure?.Performed;
                        object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                        return (aj_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (s_())
                    {
                        DataType ak_ = THAProcedure?.Performed;
                        object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                        return (al_ as CqlQuantity) as object;
                    }
                    else if (t_())
                    {
                        DataType am_ = THAProcedure?.Performed;
                        object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                        return (an_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> m_ = QICoreCommon_4_0_000.Instance.toInterval(context, l_());

                object n_() {

                    bool ao_() {
                        DataType as_ = RevisionTHAProcedure?.Performed;
                        object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                        bool au_ = at_ is CqlDateTime;
                        return au_;
                    }


                    bool ap_() {
                        DataType av_ = RevisionTHAProcedure?.Performed;
                        object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                        bool ax_ = aw_ is CqlInterval<CqlDateTime>;
                        return ax_;
                    }


                    bool aq_() {
                        DataType ay_ = RevisionTHAProcedure?.Performed;
                        object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                        bool ba_ = az_ is CqlQuantity;
                        return ba_;
                    }


                    bool ar_() {
                        DataType bb_ = RevisionTHAProcedure?.Performed;
                        object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                        bool bd_ = bc_ is CqlInterval<CqlQuantity>;
                        return bd_;
                    }

                    if (ao_())
                    {
                        DataType be_ = RevisionTHAProcedure?.Performed;
                        object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                        return (bf_ as CqlDateTime) as object;
                    }
                    else if (ap_())
                    {
                        DataType bg_ = RevisionTHAProcedure?.Performed;
                        object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                        return (bh_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (aq_())
                    {
                        DataType bi_ = RevisionTHAProcedure?.Performed;
                        object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                        return (bj_ as CqlQuantity) as object;
                    }
                    else if (ar_())
                    {
                        DataType bk_ = RevisionTHAProcedure?.Performed;
                        object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                        return (bl_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> o_ = QICoreCommon_4_0_000.Instance.toInterval(context, n_());
                bool? p_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(m_, o_, "day");
                return p_;
            }

            IEnumerable<Procedure> i_ = context.Operators.Where<Procedure>(g_, h_);
            Procedure j_(Procedure RevisionTHAProcedure) => THAProcedure;
            IEnumerable<Procedure> k_ = context.Operators.Select<Procedure, Procedure>(i_, j_);
            return k_;
        }

        IEnumerable<Procedure> c_ = context.Operators.SelectMany<Procedure, Procedure>(a_, b_);
        bool? d_ = context.Operators.Exists<Procedure>(c_);
        return d_;
    }


    [CqlExpressionDefinition("Has Malignant Neoplasm of Lower and Unspecified Limbs")]
    public bool? Has_Malignant_Neoplasm_of_Lower_and_Unspecified_Limbs(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Has_Malignant_Neoplasm_of_Lower_and_Unspecified_Limbs, Has_Malignant_Neoplasm_of_Lower_and_Unspecified_Limbs_Compute, context) ?? Has_Malignant_Neoplasm_of_Lower_and_Unspecified_Limbs_Compute(context);

    private bool? Has_Malignant_Neoplasm_of_Lower_and_Unspecified_Limbs_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Malignant_Neoplasms_of_Lower_and_Unspecified_Limbs(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<object> e_ = context.Operators.Union<object>(b_ as IEnumerable<object>, d_ as IEnumerable<object>);

        IEnumerable<object> f_(object MalignantNeoplasm) {
            IEnumerable<Procedure> i_ = this.Total_Hip_Arthroplasty_Procedure(context);

            bool? j_(Procedure THAProcedure) {
                CqlInterval<CqlDateTime> n_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, MalignantNeoplasm);

                object o_() {

                    bool t_() {
                        DataType x_ = THAProcedure?.Performed;
                        object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                        bool z_ = y_ is CqlDateTime;
                        return z_;
                    }


                    bool u_() {
                        DataType aa_ = THAProcedure?.Performed;
                        object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                        bool ac_ = ab_ is CqlInterval<CqlDateTime>;
                        return ac_;
                    }


                    bool v_() {
                        DataType ad_ = THAProcedure?.Performed;
                        object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                        bool af_ = ae_ is CqlQuantity;
                        return af_;
                    }


                    bool w_() {
                        DataType ag_ = THAProcedure?.Performed;
                        object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                        bool ai_ = ah_ is CqlInterval<CqlQuantity>;
                        return ai_;
                    }

                    if (t_())
                    {
                        DataType aj_ = THAProcedure?.Performed;
                        object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                        return (ak_ as CqlDateTime) as object;
                    }
                    else if (u_())
                    {
                        DataType al_ = THAProcedure?.Performed;
                        object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                        return (am_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (v_())
                    {
                        DataType an_ = THAProcedure?.Performed;
                        object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                        return (ao_ as CqlQuantity) as object;
                    }
                    else if (w_())
                    {
                        DataType ap_ = THAProcedure?.Performed;
                        object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                        return (aq_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> p_ = QICoreCommon_4_0_000.Instance.toInterval(context, o_());
                bool? q_ = context.Operators.Overlaps(n_, p_, "day");
                bool? r_ = this.isVerified(context, MalignantNeoplasm);
                bool? s_ = context.Operators.And(q_, r_);
                return s_;
            }

            IEnumerable<Procedure> k_ = context.Operators.Where<Procedure>(i_, j_);
            object l_(Procedure THAProcedure) => MalignantNeoplasm;
            IEnumerable<object> m_ = context.Operators.Select<Procedure, object>(k_, l_);
            return m_;
        }

        IEnumerable<object> g_ = context.Operators.SelectMany<object, object>(e_, f_);
        bool? h_ = context.Operators.Exists<object>(g_);
        return h_;
    }


    [CqlExpressionDefinition("Has Mechanical Complication")]
    public bool? Has_Mechanical_Complication(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Has_Mechanical_Complication, Has_Mechanical_Complication_Compute, context) ?? Has_Mechanical_Complication_Compute(context);

    private bool? Has_Mechanical_Complication_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Mechanical_Complications_Excluding_Upper_Body(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<object> e_ = context.Operators.Union<object>(b_ as IEnumerable<object>, d_ as IEnumerable<object>);

        IEnumerable<object> f_(object MechanicalComplications) {
            IEnumerable<Procedure> i_ = this.Total_Hip_Arthroplasty_Procedure(context);

            bool? j_(Procedure THAProcedure) {
                CqlInterval<CqlDateTime> n_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, MechanicalComplications);

                object o_() {

                    bool t_() {
                        DataType x_ = THAProcedure?.Performed;
                        object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                        bool z_ = y_ is CqlDateTime;
                        return z_;
                    }


                    bool u_() {
                        DataType aa_ = THAProcedure?.Performed;
                        object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                        bool ac_ = ab_ is CqlInterval<CqlDateTime>;
                        return ac_;
                    }


                    bool v_() {
                        DataType ad_ = THAProcedure?.Performed;
                        object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                        bool af_ = ae_ is CqlQuantity;
                        return af_;
                    }


                    bool w_() {
                        DataType ag_ = THAProcedure?.Performed;
                        object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                        bool ai_ = ah_ is CqlInterval<CqlQuantity>;
                        return ai_;
                    }

                    if (t_())
                    {
                        DataType aj_ = THAProcedure?.Performed;
                        object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                        return (ak_ as CqlDateTime) as object;
                    }
                    else if (u_())
                    {
                        DataType al_ = THAProcedure?.Performed;
                        object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                        return (am_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (v_())
                    {
                        DataType an_ = THAProcedure?.Performed;
                        object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                        return (ao_ as CqlQuantity) as object;
                    }
                    else if (w_())
                    {
                        DataType ap_ = THAProcedure?.Performed;
                        object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                        return (aq_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> p_ = QICoreCommon_4_0_000.Instance.toInterval(context, o_());
                bool? q_ = context.Operators.Overlaps(n_, p_, "day");
                bool? r_ = this.isVerified(context, MechanicalComplications);
                bool? s_ = context.Operators.And(q_, r_);
                return s_;
            }

            IEnumerable<Procedure> k_ = context.Operators.Where<Procedure>(i_, j_);
            object l_(Procedure THAProcedure) => MechanicalComplications;
            IEnumerable<object> m_ = context.Operators.Select<Procedure, object>(k_, l_);
            return m_;
        }

        IEnumerable<object> g_ = context.Operators.SelectMany<object, object>(e_, f_);
        bool? h_ = context.Operators.Exists<object>(g_);
        return h_;
    }


    [CqlExpressionDefinition("Has More Than One Elective Primary Total Hip Arthroplasty Performed")]
    public bool? Has_More_Than_One_Elective_Primary_Total_Hip_Arthroplasty_Performed(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Has_More_Than_One_Elective_Primary_Total_Hip_Arthroplasty_Performed, Has_More_Than_One_Elective_Primary_Total_Hip_Arthroplasty_Performed_Compute, context) ?? Has_More_Than_One_Elective_Primary_Total_Hip_Arthroplasty_Performed_Compute(context);

    private bool? Has_More_Than_One_Elective_Primary_Total_Hip_Arthroplasty_Performed_Compute(CqlContext context)
    {
        IEnumerable<Procedure> a_ = this.Total_Hip_Arthroplasty_Procedure(context);

        IEnumerable<Procedure> b_(Procedure THAProcedure) {
            CqlValueSet e_ = this.Primary_THA_Procedure(context);
            IEnumerable<Procedure> f_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            IEnumerable<Procedure> g_ = Status_1_15_000.Instance.isProcedurePerformed(context, f_);

            bool? h_(Procedure ElectiveTHAProcedure) {
                Id l_ = THAProcedure?.IdElement;
                string m_ = l_?.Value;
                Id n_ = ElectiveTHAProcedure?.IdElement;
                string o_ = n_?.Value;
                bool? p_ = context.Operators.Equivalent(m_, o_);
                bool? q_ = context.Operators.Not(p_);

                object r_() {

                    bool ah_() {
                        DataType al_ = ElectiveTHAProcedure?.Performed;
                        object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                        bool an_ = am_ is CqlDateTime;
                        return an_;
                    }


                    bool ai_() {
                        DataType ao_ = ElectiveTHAProcedure?.Performed;
                        object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                        bool aq_ = ap_ is CqlInterval<CqlDateTime>;
                        return aq_;
                    }


                    bool aj_() {
                        DataType ar_ = ElectiveTHAProcedure?.Performed;
                        object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                        bool at_ = as_ is CqlQuantity;
                        return at_;
                    }


                    bool ak_() {
                        DataType au_ = ElectiveTHAProcedure?.Performed;
                        object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                        bool aw_ = av_ is CqlInterval<CqlQuantity>;
                        return aw_;
                    }

                    if (ah_())
                    {
                        DataType ax_ = ElectiveTHAProcedure?.Performed;
                        object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                        return (ay_ as CqlDateTime) as object;
                    }
                    else if (ai_())
                    {
                        DataType az_ = ElectiveTHAProcedure?.Performed;
                        object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                        return (ba_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (aj_())
                    {
                        DataType bb_ = ElectiveTHAProcedure?.Performed;
                        object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                        return (bc_ as CqlQuantity) as object;
                    }
                    else if (ak_())
                    {
                        DataType bd_ = ElectiveTHAProcedure?.Performed;
                        object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                        return (be_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> s_ = QICoreCommon_4_0_000.Instance.toInterval(context, r_());
                CqlDateTime t_ = context.Operators.Start(s_);

                object u_() {

                    bool bf_() {
                        DataType bj_ = THAProcedure?.Performed;
                        object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                        bool bl_ = bk_ is CqlDateTime;
                        return bl_;
                    }


                    bool bg_() {
                        DataType bm_ = THAProcedure?.Performed;
                        object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                        bool bo_ = bn_ is CqlInterval<CqlDateTime>;
                        return bo_;
                    }


                    bool bh_() {
                        DataType bp_ = THAProcedure?.Performed;
                        object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                        bool br_ = bq_ is CqlQuantity;
                        return br_;
                    }


                    bool bi_() {
                        DataType bs_ = THAProcedure?.Performed;
                        object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                        bool bu_ = bt_ is CqlInterval<CqlQuantity>;
                        return bu_;
                    }

                    if (bf_())
                    {
                        DataType bv_ = THAProcedure?.Performed;
                        object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                        return (bw_ as CqlDateTime) as object;
                    }
                    else if (bg_())
                    {
                        DataType bx_ = THAProcedure?.Performed;
                        object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                        return (by_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (bh_())
                    {
                        DataType bz_ = THAProcedure?.Performed;
                        object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                        return (ca_ as CqlQuantity) as object;
                    }
                    else if (bi_())
                    {
                        DataType cb_ = THAProcedure?.Performed;
                        object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                        return (cc_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> v_ = QICoreCommon_4_0_000.Instance.toInterval(context, u_());
                CqlDateTime w_ = context.Operators.Start(v_);
                CqlQuantity x_ = context.Operators.Quantity(1m, "year");
                CqlDateTime y_ = context.Operators.Subtract(w_, x_);

                object z_() {

                    bool cd_() {
                        DataType ch_ = THAProcedure?.Performed;
                        object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                        bool cj_ = ci_ is CqlDateTime;
                        return cj_;
                    }


                    bool ce_() {
                        DataType ck_ = THAProcedure?.Performed;
                        object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                        bool cm_ = cl_ is CqlInterval<CqlDateTime>;
                        return cm_;
                    }


                    bool cf_() {
                        DataType cn_ = THAProcedure?.Performed;
                        object co_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cn_);
                        bool cp_ = co_ is CqlQuantity;
                        return cp_;
                    }


                    bool cg_() {
                        DataType cq_ = THAProcedure?.Performed;
                        object cr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cq_);
                        bool cs_ = cr_ is CqlInterval<CqlQuantity>;
                        return cs_;
                    }

                    if (cd_())
                    {
                        DataType ct_ = THAProcedure?.Performed;
                        object cu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ct_);
                        return (cu_ as CqlDateTime) as object;
                    }
                    else if (ce_())
                    {
                        DataType cv_ = THAProcedure?.Performed;
                        object cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);
                        return (cw_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (cf_())
                    {
                        DataType cx_ = THAProcedure?.Performed;
                        object cy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                        return (cy_ as CqlQuantity) as object;
                    }
                    else if (cg_())
                    {
                        DataType cz_ = THAProcedure?.Performed;
                        object da_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cz_);
                        return (da_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> aa_ = QICoreCommon_4_0_000.Instance.toInterval(context, z_());
                CqlDateTime ab_ = context.Operators.Start(aa_);
                CqlDateTime ad_ = context.Operators.Add(ab_, x_);
                CqlInterval<CqlDateTime> ae_ = context.Operators.Interval(y_, ad_, true, true);
                bool? af_ = context.Operators.In<CqlDateTime>(t_, ae_, "day");
                bool? ag_ = context.Operators.And(q_, af_);
                return ag_;
            }

            IEnumerable<Procedure> i_ = context.Operators.Where<Procedure>(g_, h_);
            Procedure j_(Procedure ElectiveTHAProcedure) => THAProcedure;
            IEnumerable<Procedure> k_ = context.Operators.Select<Procedure, Procedure>(i_, j_);
            return k_;
        }

        IEnumerable<Procedure> c_ = context.Operators.SelectMany<Procedure, Procedure>(a_, b_);
        bool? d_ = context.Operators.Exists<Procedure>(c_);
        return d_;
    }


    [CqlExpressionDefinition("Death Within 300 Days of the THA Procedure")]
    public bool? Death_Within_300_Days_of_the_THA_Procedure(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Death_Within_300_Days_of_the_THA_Procedure, Death_Within_300_Days_of_the_THA_Procedure_Compute, context) ?? Death_Within_300_Days_of_the_THA_Procedure_Compute(context);

    private bool? Death_Within_300_Days_of_the_THA_Procedure_Compute(CqlContext context)
    {
        IEnumerable<Procedure> a_ = this.Total_Hip_Arthroplasty_Procedure(context);

        bool? b_(Procedure THAProcedure) {
            Patient e_ = this.Patient(context);
            DataType f_ = e_?.Deceased;
            object g_ = FHIRHelpers_4_4_000.Instance.ToValue(context, f_);
            CqlDate h_ = context.Operators.DateFrom(g_ as CqlDateTime);

            object i_() {

                bool u_() {
                    DataType y_ = THAProcedure?.Performed;
                    object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                    bool aa_ = z_ is CqlDateTime;
                    return aa_;
                }


                bool v_() {
                    DataType ab_ = THAProcedure?.Performed;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    bool ad_ = ac_ is CqlInterval<CqlDateTime>;
                    return ad_;
                }


                bool w_() {
                    DataType ae_ = THAProcedure?.Performed;
                    object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                    bool ag_ = af_ is CqlQuantity;
                    return ag_;
                }


                bool x_() {
                    DataType ah_ = THAProcedure?.Performed;
                    object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                    bool aj_ = ai_ is CqlInterval<CqlQuantity>;
                    return aj_;
                }

                if (u_())
                {
                    DataType ak_ = THAProcedure?.Performed;
                    object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                    return (al_ as CqlDateTime) as object;
                }
                else if (v_())
                {
                    DataType am_ = THAProcedure?.Performed;
                    object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                    return (an_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (w_())
                {
                    DataType ao_ = THAProcedure?.Performed;
                    object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                    return (ap_ as CqlQuantity) as object;
                }
                else if (x_())
                {
                    DataType aq_ = THAProcedure?.Performed;
                    object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                    return (ar_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> j_ = QICoreCommon_4_0_000.Instance.toInterval(context, i_());
            CqlDateTime k_ = context.Operators.Start(j_);
            CqlDate l_ = context.Operators.DateFrom(k_);

            object m_() {

                bool as_() {
                    DataType aw_ = THAProcedure?.Performed;
                    object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                    bool ay_ = ax_ is CqlDateTime;
                    return ay_;
                }


                bool at_() {
                    DataType az_ = THAProcedure?.Performed;
                    object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                    bool bb_ = ba_ is CqlInterval<CqlDateTime>;
                    return bb_;
                }


                bool au_() {
                    DataType bc_ = THAProcedure?.Performed;
                    object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                    bool be_ = bd_ is CqlQuantity;
                    return be_;
                }


                bool av_() {
                    DataType bf_ = THAProcedure?.Performed;
                    object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                    bool bh_ = bg_ is CqlInterval<CqlQuantity>;
                    return bh_;
                }

                if (as_())
                {
                    DataType bi_ = THAProcedure?.Performed;
                    object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                    return (bj_ as CqlDateTime) as object;
                }
                else if (at_())
                {
                    DataType bk_ = THAProcedure?.Performed;
                    object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                    return (bl_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (au_())
                {
                    DataType bm_ = THAProcedure?.Performed;
                    object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                    return (bn_ as CqlQuantity) as object;
                }
                else if (av_())
                {
                    DataType bo_ = THAProcedure?.Performed;
                    object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                    return (bp_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> n_ = QICoreCommon_4_0_000.Instance.toInterval(context, m_());
            CqlDateTime o_ = context.Operators.Start(n_);
            CqlDate p_ = context.Operators.DateFrom(o_);
            CqlQuantity q_ = context.Operators.Quantity(300m, "days");
            CqlDate r_ = context.Operators.Add(p_, q_);
            CqlInterval<CqlDate> s_ = context.Operators.Interval(l_, r_, true, true);
            bool? t_ = context.Operators.In<CqlDate>(h_, s_, "day");
            return t_;
        }

        IEnumerable<Procedure> c_ = context.Operators.Where<Procedure>(a_, b_);
        bool? d_ = context.Operators.Exists<Procedure>(c_);
        return d_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Denominator_Exclusions, Denominator_Exclusions_Compute, context) ?? Denominator_Exclusions_Compute(context);

    private bool? Denominator_Exclusions_Compute(CqlContext context)
    {
        bool? a_ = Hospice_6_18_000.Instance.Has_Hospice_Services(context);
        bool? b_ = this.Has_Severe_Cognitive_Impairment(context);
        bool? c_ = context.Operators.Or(a_, b_);
        bool? d_ = this.Has_Total_Hip_Arthroplasty_with_1_or_More_Lower_Body_Fractures(context);
        bool? e_ = context.Operators.Or(c_, d_);
        bool? f_ = this.Has_Partial_Hip_Arthroplasty_Procedure(context);
        bool? g_ = context.Operators.Or(e_, f_);
        bool? h_ = this.Has_Revision_Hip_Arthroplasty_Procedure_or_Implanted_Device_or_Prosthesis_Removal_Procedure(context);
        bool? i_ = context.Operators.Or(g_, h_);
        bool? j_ = this.Has_Malignant_Neoplasm_of_Lower_and_Unspecified_Limbs(context);
        bool? k_ = context.Operators.Or(i_, j_);
        bool? l_ = this.Has_Mechanical_Complication(context);
        bool? m_ = context.Operators.Or(k_, l_);
        bool? n_ = this.Has_More_Than_One_Elective_Primary_Total_Hip_Arthroplasty_Performed(context);
        bool? o_ = context.Operators.Or(m_, n_);
        bool? p_ = this.Death_Within_300_Days_of_the_THA_Procedure(context);
        bool? q_ = context.Operators.Or(o_, p_);
        return q_;
    }


    [CqlExpressionDefinition("Date HOOS Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_HOOS_Total_Assessment_Completed(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Date_HOOS_Total_Assessment_Completed, Date_HOOS_Total_Assessment_Completed_Compute, context) ?? Date_HOOS_Total_Assessment_Completed_Compute(context);

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
            (CqlTupleMetadata, Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)? ac_ = (CqlTupleMetadata_GVNUVHGXYWXVGgfjdTEahUfhP, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3, _valueTuple.Item4, _valueTuple.Item5);
            return ac_;
        }

        IEnumerable<(CqlTupleMetadata, Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)?> w_ = context.Operators.Select<ValueTuple<Observation, Observation, Observation, Observation, Observation>, (CqlTupleMetadata, Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)?>(u_, v_);

        bool? x_((CqlTupleMetadata, Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)? tuple_eipfmazvhfscjijaofhicpvmb) {
            DataType ad_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSLifeQuality?.Effective;
            object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
            CqlInterval<CqlDateTime> af_ = QICoreCommon_4_0_000.Instance.toInterval(context, ae_);
            CqlDateTime ag_ = context.Operators.Start(af_);
            CqlDate ah_ = context.Operators.DateFrom(ag_);
            DataType ai_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSSport?.Effective;
            object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
            CqlInterval<CqlDateTime> ak_ = QICoreCommon_4_0_000.Instance.toInterval(context, aj_);
            CqlDateTime al_ = context.Operators.Start(ak_);
            CqlDate am_ = context.Operators.DateFrom(al_);
            bool? an_ = context.Operators.SameAs(ah_, am_, "day");
            DataType ao_ = (tuple_eipfmazvhfscjijaofhicpvmb?.HOOSSport as Observation)?.Value;
            object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
            bool? aq_ = context.Operators.Not((bool?)(ap_ is null));
            bool? ar_ = context.Operators.And(an_, aq_);
            object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
            CqlInterval<CqlDateTime> au_ = QICoreCommon_4_0_000.Instance.toInterval(context, at_);
            CqlDateTime av_ = context.Operators.Start(au_);
            CqlDate aw_ = context.Operators.DateFrom(av_);
            DataType ax_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSActivityScore?.Effective;
            object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
            CqlInterval<CqlDateTime> az_ = QICoreCommon_4_0_000.Instance.toInterval(context, ay_);
            CqlDateTime ba_ = context.Operators.Start(az_);
            CqlDate bb_ = context.Operators.DateFrom(ba_);
            bool? bc_ = context.Operators.SameAs(aw_, bb_, "day");
            bool? bd_ = context.Operators.And(ar_, bc_);
            DataType be_ = (tuple_eipfmazvhfscjijaofhicpvmb?.HOOSActivityScore as Observation)?.Value;
            object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
            bool? bg_ = context.Operators.Not((bool?)(bf_ is null));
            bool? bh_ = context.Operators.And(bd_, bg_);
            object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
            CqlInterval<CqlDateTime> bk_ = QICoreCommon_4_0_000.Instance.toInterval(context, bj_);
            CqlDateTime bl_ = context.Operators.Start(bk_);
            CqlDate bm_ = context.Operators.DateFrom(bl_);
            DataType bn_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSSymptoms?.Effective;
            object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
            CqlInterval<CqlDateTime> bp_ = QICoreCommon_4_0_000.Instance.toInterval(context, bo_);
            CqlDateTime bq_ = context.Operators.Start(bp_);
            CqlDate br_ = context.Operators.DateFrom(bq_);
            bool? bs_ = context.Operators.SameAs(bm_, br_, "day");
            bool? bt_ = context.Operators.And(bh_, bs_);
            DataType bu_ = (tuple_eipfmazvhfscjijaofhicpvmb?.HOOSSymptoms as Observation)?.Value;
            object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
            bool? bw_ = context.Operators.Not((bool?)(bv_ is null));
            bool? bx_ = context.Operators.And(bt_, bw_);
            object bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
            CqlInterval<CqlDateTime> ca_ = QICoreCommon_4_0_000.Instance.toInterval(context, bz_);
            CqlDateTime cb_ = context.Operators.Start(ca_);
            CqlDate cc_ = context.Operators.DateFrom(cb_);
            DataType cd_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSPain?.Effective;
            object ce_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cd_);
            CqlInterval<CqlDateTime> cf_ = QICoreCommon_4_0_000.Instance.toInterval(context, ce_);
            CqlDateTime cg_ = context.Operators.Start(cf_);
            CqlDate ch_ = context.Operators.DateFrom(cg_);
            bool? ci_ = context.Operators.SameAs(cc_, ch_, "day");
            bool? cj_ = context.Operators.And(bx_, ci_);
            DataType ck_ = (tuple_eipfmazvhfscjijaofhicpvmb?.HOOSPain as Observation)?.Value;
            object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
            bool? cm_ = context.Operators.Not((bool?)(cl_ is null));
            bool? cn_ = context.Operators.And(cj_, cm_);
            DataType co_ = (tuple_eipfmazvhfscjijaofhicpvmb?.HOOSLifeQuality as Observation)?.Value;
            object cp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, co_);
            bool? cq_ = context.Operators.Not((bool?)(cp_ is null));
            bool? cr_ = context.Operators.And(cn_, cq_);
            return cr_;
        }

        IEnumerable<(CqlTupleMetadata, Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)?> y_ = context.Operators.Where<(CqlTupleMetadata, Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)?>(w_, x_);

        CqlDate z_((CqlTupleMetadata, Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)? tuple_eipfmazvhfscjijaofhicpvmb) {
            DataType cs_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSLifeQuality?.Effective;
            object ct_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cs_);
            CqlInterval<CqlDateTime> cu_ = QICoreCommon_4_0_000.Instance.toInterval(context, ct_);
            CqlDateTime cv_ = context.Operators.Start(cu_);
            CqlDate cw_ = context.Operators.DateFrom(cv_);
            DataType cx_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSSport?.Effective;
            object cy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
            CqlInterval<CqlDateTime> cz_ = QICoreCommon_4_0_000.Instance.toInterval(context, cy_);
            CqlDateTime da_ = context.Operators.Start(cz_);
            CqlDate db_ = context.Operators.DateFrom(da_);
            DataType dc_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSActivityScore?.Effective;
            object dd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dc_);
            CqlInterval<CqlDateTime> de_ = QICoreCommon_4_0_000.Instance.toInterval(context, dd_);
            CqlDateTime df_ = context.Operators.Start(de_);
            CqlDate dg_ = context.Operators.DateFrom(df_);
            DataType dh_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSSymptoms?.Effective;
            object di_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dh_);
            CqlInterval<CqlDateTime> dj_ = QICoreCommon_4_0_000.Instance.toInterval(context, di_);
            CqlDateTime dk_ = context.Operators.Start(dj_);
            CqlDate dl_ = context.Operators.DateFrom(dk_);
            DataType dm_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSPain?.Effective;
            object dn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dm_);
            CqlInterval<CqlDateTime> do_ = QICoreCommon_4_0_000.Instance.toInterval(context, dn_);
            CqlDateTime dp_ = context.Operators.Start(do_);
            CqlDate dq_ = context.Operators.DateFrom(dp_);
            CqlDate[] dr_ = [
                cw_,
                db_,
                dg_,
                dl_,
                dq_,
            ];
            CqlDate ds_ = context.Operators.Max<CqlDate>((IEnumerable<CqlDate>)dr_);
            return ds_;
        }

        IEnumerable<CqlDate> aa_ = context.Operators.Select<(CqlTupleMetadata, Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)?, CqlDate>(y_, z_);
        IEnumerable<CqlDate> ab_ = context.Operators.Distinct<CqlDate>(aa_);
        return ab_;
    }


    [CqlExpressionDefinition("Has THA with Initial and Follow Up HOOS Assessments")]
    public bool? Has_THA_with_Initial_and_Follow_Up_HOOS_Assessments(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Has_THA_with_Initial_and_Follow_Up_HOOS_Assessments, Has_THA_with_Initial_and_Follow_Up_HOOS_Assessments_Compute, context) ?? Has_THA_with_Initial_and_Follow_Up_HOOS_Assessments_Compute(context);

    private bool? Has_THA_with_Initial_and_Follow_Up_HOOS_Assessments_Compute(CqlContext context)
    {
        IEnumerable<Procedure> a_ = this.Total_Hip_Arthroplasty_Procedure(context);

        CqlInterval<CqlDateTime> b_(Procedure THAProcedure) {

            object j_() {

                bool l_() {
                    DataType p_ = THAProcedure?.Performed;
                    object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
                    bool r_ = q_ is CqlDateTime;
                    return r_;
                }


                bool m_() {
                    DataType s_ = THAProcedure?.Performed;
                    object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                    bool u_ = t_ is CqlInterval<CqlDateTime>;
                    return u_;
                }


                bool n_() {
                    DataType v_ = THAProcedure?.Performed;
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    bool x_ = w_ is CqlQuantity;
                    return x_;
                }


                bool o_() {
                    DataType y_ = THAProcedure?.Performed;
                    object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                    bool aa_ = z_ is CqlInterval<CqlQuantity>;
                    return aa_;
                }

                if (l_())
                {
                    DataType ab_ = THAProcedure?.Performed;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    return (ac_ as CqlDateTime) as object;
                }
                else if (m_())
                {
                    DataType ad_ = THAProcedure?.Performed;
                    object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                    return (ae_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (n_())
                {
                    DataType af_ = THAProcedure?.Performed;
                    object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                    return (ag_ as CqlQuantity) as object;
                }
                else if (o_())
                {
                    DataType ah_ = THAProcedure?.Performed;
                    object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                    return (ai_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> k_ = QICoreCommon_4_0_000.Instance.toInterval(context, j_());
            return k_;
        }

        IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.Select<Procedure, CqlInterval<CqlDateTime>>(a_, b_);
        IEnumerable<CqlInterval<CqlDateTime>> d_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(c_);

        IEnumerable<CqlInterval<CqlDateTime>> e_(CqlInterval<CqlDateTime> TotalHip) {
            IEnumerable<CqlDate> aj_ = this.Date_HOOS_Total_Assessment_Completed(context);

            bool? ak_(CqlDate InitialHipAssessmentHOOS) {
                CqlDateTime ao_ = context.Operators.Start(TotalHip);
                CqlQuantity ap_ = context.Operators.Quantity(90m, "days");
                CqlDate aq_ = context.Operators.Add(InitialHipAssessmentHOOS, ap_);
                CqlInterval<CqlDate> ar_ = context.Operators.Interval(InitialHipAssessmentHOOS, aq_, true, true);
                CqlDate as_ = ar_?.low;
                CqlDateTime at_ = context.Operators.ConvertDateToDateTime(as_);
                CqlDate av_ = context.Operators.Add(InitialHipAssessmentHOOS, ap_);
                CqlInterval<CqlDate> aw_ = context.Operators.Interval(InitialHipAssessmentHOOS, av_, true, true);
                CqlDate ax_ = aw_?.high;
                CqlDateTime ay_ = context.Operators.ConvertDateToDateTime(ax_);
                CqlDate ba_ = context.Operators.Add(InitialHipAssessmentHOOS, ap_);
                CqlInterval<CqlDate> bb_ = context.Operators.Interval(InitialHipAssessmentHOOS, ba_, true, true);
                bool? bc_ = bb_?.lowClosed;
                CqlDate be_ = context.Operators.Add(InitialHipAssessmentHOOS, ap_);
                CqlInterval<CqlDate> bf_ = context.Operators.Interval(InitialHipAssessmentHOOS, be_, true, true);
                bool? bg_ = bf_?.highClosed;
                CqlInterval<CqlDateTime> bh_ = context.Operators.Interval(at_, ay_, bc_, bg_);
                bool? bi_ = context.Operators.In<CqlDateTime>(ao_, bh_, "day");
                bool? bj_ = context.Operators.Not((bool?)(InitialHipAssessmentHOOS is null));
                bool? bk_ = context.Operators.And(bi_, bj_);
                return bk_;
            }

            IEnumerable<CqlDate> al_ = context.Operators.Where<CqlDate>(aj_, ak_);
            CqlInterval<CqlDateTime> am_(CqlDate InitialHipAssessmentHOOS) => TotalHip;
            IEnumerable<CqlInterval<CqlDateTime>> an_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(al_, am_);
            return an_;
        }

        IEnumerable<CqlInterval<CqlDateTime>> f_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(d_, e_);

        IEnumerable<CqlInterval<CqlDateTime>> g_(CqlInterval<CqlDateTime> TotalHip) {
            IEnumerable<CqlDate> bl_ = this.Date_HOOS_Total_Assessment_Completed(context);

            bool? bm_(CqlDate FollowUpHipAssessmentHOOS) {
                CqlDateTime bq_ = context.Operators.ConvertDateToDateTime(FollowUpHipAssessmentHOOS);
                CqlDate br_ = context.Operators.DateFrom(bq_);
                CqlDateTime bs_ = context.Operators.End(TotalHip);
                CqlDate bt_ = context.Operators.DateFrom(bs_);
                CqlQuantity bu_ = context.Operators.Quantity(300m, "days");
                CqlDate bv_ = context.Operators.Add(bt_, bu_);
                CqlDate bx_ = context.Operators.DateFrom(bs_);
                CqlQuantity by_ = context.Operators.Quantity(425m, "days");
                CqlDate bz_ = context.Operators.Add(bx_, by_);
                CqlInterval<CqlDate> ca_ = context.Operators.Interval(bv_, bz_, true, true);
                bool? cb_ = context.Operators.In<CqlDate>(br_, ca_, "day");
                return cb_;
            }

            IEnumerable<CqlDate> bn_ = context.Operators.Where<CqlDate>(bl_, bm_);
            CqlInterval<CqlDateTime> bo_(CqlDate FollowUpHipAssessmentHOOS) => TotalHip;
            IEnumerable<CqlInterval<CqlDateTime>> bp_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(bn_, bo_);
            return bp_;
        }

        IEnumerable<CqlInterval<CqlDateTime>> h_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(f_, g_);
        bool? i_ = context.Operators.Exists<CqlInterval<CqlDateTime>>(h_);
        return i_;
    }


    [CqlExpressionDefinition("Date HOOSJr Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_HOOSJr_Total_Assessment_Completed(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Date_HOOSJr_Total_Assessment_Completed, Date_HOOSJr_Total_Assessment_Completed_Compute, context) ?? Date_HOOSJr_Total_Assessment_Completed_Compute(context);

    private IEnumerable<CqlDate> Date_HOOSJr_Total_Assessment_Completed_Compute(CqlContext context)
    {
        CqlCode a_ = this.Total_interval_score__HOOSJR_(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
        IEnumerable<Observation> d_ = Status_1_15_000.Instance.isAssessmentPerformed(context, c_);

        bool? e_(Observation HOOSJr) {
            DataType j_ = (HOOSJr as Observation)?.Value;
            object k_ = FHIRHelpers_4_4_000.Instance.ToValue(context, j_);
            bool? l_ = context.Operators.Not((bool?)(k_ is null));
            return l_;
        }

        IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);

        CqlDate g_(Observation DocumentedHOOSJr) {
            DataType m_ = DocumentedHOOSJr?.Effective;
            object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
            CqlInterval<CqlDateTime> o_ = QICoreCommon_4_0_000.Instance.toInterval(context, n_);
            CqlDateTime p_ = context.Operators.Start(o_);
            CqlDate q_ = context.Operators.DateFrom(p_);
            return q_;
        }

        IEnumerable<CqlDate> h_ = context.Operators.Select<Observation, CqlDate>(f_, g_);
        IEnumerable<CqlDate> i_ = context.Operators.Distinct<CqlDate>(h_);
        return i_;
    }


    [CqlExpressionDefinition("Has THA with Initial and Follow Up HOOSJr Assessments")]
    public bool? Has_THA_with_Initial_and_Follow_Up_HOOSJr_Assessments(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Has_THA_with_Initial_and_Follow_Up_HOOSJr_Assessments, Has_THA_with_Initial_and_Follow_Up_HOOSJr_Assessments_Compute, context) ?? Has_THA_with_Initial_and_Follow_Up_HOOSJr_Assessments_Compute(context);

    private bool? Has_THA_with_Initial_and_Follow_Up_HOOSJr_Assessments_Compute(CqlContext context)
    {
        IEnumerable<Procedure> a_ = this.Total_Hip_Arthroplasty_Procedure(context);

        CqlInterval<CqlDateTime> b_(Procedure THAProcedure) {

            object j_() {

                bool l_() {
                    DataType p_ = THAProcedure?.Performed;
                    object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
                    bool r_ = q_ is CqlDateTime;
                    return r_;
                }


                bool m_() {
                    DataType s_ = THAProcedure?.Performed;
                    object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                    bool u_ = t_ is CqlInterval<CqlDateTime>;
                    return u_;
                }


                bool n_() {
                    DataType v_ = THAProcedure?.Performed;
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    bool x_ = w_ is CqlQuantity;
                    return x_;
                }


                bool o_() {
                    DataType y_ = THAProcedure?.Performed;
                    object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                    bool aa_ = z_ is CqlInterval<CqlQuantity>;
                    return aa_;
                }

                if (l_())
                {
                    DataType ab_ = THAProcedure?.Performed;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    return (ac_ as CqlDateTime) as object;
                }
                else if (m_())
                {
                    DataType ad_ = THAProcedure?.Performed;
                    object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                    return (ae_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (n_())
                {
                    DataType af_ = THAProcedure?.Performed;
                    object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                    return (ag_ as CqlQuantity) as object;
                }
                else if (o_())
                {
                    DataType ah_ = THAProcedure?.Performed;
                    object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                    return (ai_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> k_ = QICoreCommon_4_0_000.Instance.toInterval(context, j_());
            return k_;
        }

        IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.Select<Procedure, CqlInterval<CqlDateTime>>(a_, b_);
        IEnumerable<CqlInterval<CqlDateTime>> d_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(c_);

        IEnumerable<CqlInterval<CqlDateTime>> e_(CqlInterval<CqlDateTime> TotalHip) {
            IEnumerable<CqlDate> aj_ = this.Date_HOOSJr_Total_Assessment_Completed(context);

            bool? ak_(CqlDate InitialHipAssessment) {
                CqlDateTime ao_ = context.Operators.Start(TotalHip);
                CqlQuantity ap_ = context.Operators.Quantity(90m, "days");
                CqlDate aq_ = context.Operators.Add(InitialHipAssessment, ap_);
                CqlInterval<CqlDate> ar_ = context.Operators.Interval(InitialHipAssessment, aq_, true, true);
                CqlDate as_ = ar_?.low;
                CqlDateTime at_ = context.Operators.ConvertDateToDateTime(as_);
                CqlDate av_ = context.Operators.Add(InitialHipAssessment, ap_);
                CqlInterval<CqlDate> aw_ = context.Operators.Interval(InitialHipAssessment, av_, true, true);
                CqlDate ax_ = aw_?.high;
                CqlDateTime ay_ = context.Operators.ConvertDateToDateTime(ax_);
                CqlDate ba_ = context.Operators.Add(InitialHipAssessment, ap_);
                CqlInterval<CqlDate> bb_ = context.Operators.Interval(InitialHipAssessment, ba_, true, true);
                bool? bc_ = bb_?.lowClosed;
                CqlDate be_ = context.Operators.Add(InitialHipAssessment, ap_);
                CqlInterval<CqlDate> bf_ = context.Operators.Interval(InitialHipAssessment, be_, true, true);
                bool? bg_ = bf_?.highClosed;
                CqlInterval<CqlDateTime> bh_ = context.Operators.Interval(at_, ay_, bc_, bg_);
                bool? bi_ = context.Operators.In<CqlDateTime>(ao_, bh_, "day");
                bool? bj_ = context.Operators.Not((bool?)(InitialHipAssessment is null));
                bool? bk_ = context.Operators.And(bi_, bj_);
                return bk_;
            }

            IEnumerable<CqlDate> al_ = context.Operators.Where<CqlDate>(aj_, ak_);
            CqlInterval<CqlDateTime> am_(CqlDate InitialHipAssessment) => TotalHip;
            IEnumerable<CqlInterval<CqlDateTime>> an_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(al_, am_);
            return an_;
        }

        IEnumerable<CqlInterval<CqlDateTime>> f_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(d_, e_);

        IEnumerable<CqlInterval<CqlDateTime>> g_(CqlInterval<CqlDateTime> TotalHip) {
            IEnumerable<CqlDate> bl_ = this.Date_HOOSJr_Total_Assessment_Completed(context);

            bool? bm_(CqlDate FollowUpHipAssessment) {
                CqlDateTime bq_ = context.Operators.ConvertDateToDateTime(FollowUpHipAssessment);
                CqlDate br_ = context.Operators.DateFrom(bq_);
                CqlDateTime bs_ = context.Operators.End(TotalHip);
                CqlDate bt_ = context.Operators.DateFrom(bs_);
                CqlQuantity bu_ = context.Operators.Quantity(300m, "days");
                CqlDate bv_ = context.Operators.Add(bt_, bu_);
                CqlDate bx_ = context.Operators.DateFrom(bs_);
                CqlQuantity by_ = context.Operators.Quantity(425m, "days");
                CqlDate bz_ = context.Operators.Add(bx_, by_);
                CqlInterval<CqlDate> ca_ = context.Operators.Interval(bv_, bz_, true, true);
                bool? cb_ = context.Operators.In<CqlDate>(br_, ca_, "day");
                return cb_;
            }

            IEnumerable<CqlDate> bn_ = context.Operators.Where<CqlDate>(bl_, bm_);
            CqlInterval<CqlDateTime> bo_(CqlDate FollowUpHipAssessment) => TotalHip;
            IEnumerable<CqlInterval<CqlDateTime>> bp_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(bn_, bo_);
            return bp_;
        }

        IEnumerable<CqlInterval<CqlDateTime>> h_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(f_, g_);
        bool? i_ = context.Operators.Exists<CqlInterval<CqlDateTime>>(h_);
        return i_;
    }


    [CqlExpressionDefinition("Date PROMIS10 Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_PROMIS10_Total_Assessment_Completed(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Date_PROMIS10_Total_Assessment_Completed, Date_PROMIS10_Total_Assessment_Completed_Compute, context) ?? Date_PROMIS10_Total_Assessment_Completed_Compute(context);

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
            (CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)? q_ = (CqlTupleMetadata_DDTAOdcFieSJbGgRLLZPYbGQb, _valueTuple.Item1, _valueTuple.Item2);
            return q_;
        }

        IEnumerable<(CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?> k_ = context.Operators.Select<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?>(i_, j_);

        bool? l_((CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)? tuple_ddtaodcfiesjbggrllzpybgqb) {
            DataType r_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10MentalScore?.Effective;
            object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
            CqlInterval<CqlDateTime> t_ = QICoreCommon_4_0_000.Instance.toInterval(context, s_);
            CqlDateTime u_ = context.Operators.Start(t_);
            CqlDate v_ = context.Operators.DateFrom(u_);
            DataType w_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10PhysicalScore?.Effective;
            object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
            CqlInterval<CqlDateTime> y_ = QICoreCommon_4_0_000.Instance.toInterval(context, x_);
            CqlDateTime z_ = context.Operators.Start(y_);
            CqlDate aa_ = context.Operators.DateFrom(z_);
            bool? ab_ = context.Operators.SameAs(v_, aa_, "day");
            DataType ac_ = (tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10PhysicalScore as Observation)?.Value;
            object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
            bool? ae_ = context.Operators.Not((bool?)(ad_ is null));
            bool? af_ = context.Operators.And(ab_, ae_);
            DataType ag_ = (tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10MentalScore as Observation)?.Value;
            object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
            bool? ai_ = context.Operators.Not((bool?)(ah_ is null));
            bool? aj_ = context.Operators.And(af_, ai_);
            return aj_;
        }

        IEnumerable<(CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?> m_ = context.Operators.Where<(CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?>(k_, l_);

        CqlDate n_((CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)? tuple_ddtaodcfiesjbggrllzpybgqb) {
            DataType ak_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10MentalScore?.Effective;
            object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
            CqlInterval<CqlDateTime> am_ = QICoreCommon_4_0_000.Instance.toInterval(context, al_);
            CqlDateTime an_ = context.Operators.Start(am_);
            CqlDate ao_ = context.Operators.DateFrom(an_);
            DataType ap_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10PhysicalScore?.Effective;
            object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
            CqlInterval<CqlDateTime> ar_ = QICoreCommon_4_0_000.Instance.toInterval(context, aq_);
            CqlDateTime as_ = context.Operators.Start(ar_);
            CqlDate at_ = context.Operators.DateFrom(as_);
            CqlDate[] au_ = [
                ao_,
                at_,
            ];
            CqlDate av_ = context.Operators.Max<CqlDate>((IEnumerable<CqlDate>)au_);
            return av_;
        }

        IEnumerable<CqlDate> o_ = context.Operators.Select<(CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?, CqlDate>(m_, n_);
        IEnumerable<CqlDate> p_ = context.Operators.Distinct<CqlDate>(o_);
        return p_;
    }


    [CqlExpressionDefinition("Has THA with Initial and Follow Up PROMIS10 Assessments")]
    public bool? Has_THA_with_Initial_and_Follow_Up_PROMIS10_Assessments(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Has_THA_with_Initial_and_Follow_Up_PROMIS10_Assessments, Has_THA_with_Initial_and_Follow_Up_PROMIS10_Assessments_Compute, context) ?? Has_THA_with_Initial_and_Follow_Up_PROMIS10_Assessments_Compute(context);

    private bool? Has_THA_with_Initial_and_Follow_Up_PROMIS10_Assessments_Compute(CqlContext context)
    {
        IEnumerable<Procedure> a_ = this.Total_Hip_Arthroplasty_Procedure(context);

        CqlInterval<CqlDateTime> b_(Procedure THAProcedure) {

            object j_() {

                bool l_() {
                    DataType p_ = THAProcedure?.Performed;
                    object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
                    bool r_ = q_ is CqlDateTime;
                    return r_;
                }


                bool m_() {
                    DataType s_ = THAProcedure?.Performed;
                    object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                    bool u_ = t_ is CqlInterval<CqlDateTime>;
                    return u_;
                }


                bool n_() {
                    DataType v_ = THAProcedure?.Performed;
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    bool x_ = w_ is CqlQuantity;
                    return x_;
                }


                bool o_() {
                    DataType y_ = THAProcedure?.Performed;
                    object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                    bool aa_ = z_ is CqlInterval<CqlQuantity>;
                    return aa_;
                }

                if (l_())
                {
                    DataType ab_ = THAProcedure?.Performed;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    return (ac_ as CqlDateTime) as object;
                }
                else if (m_())
                {
                    DataType ad_ = THAProcedure?.Performed;
                    object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                    return (ae_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (n_())
                {
                    DataType af_ = THAProcedure?.Performed;
                    object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                    return (ag_ as CqlQuantity) as object;
                }
                else if (o_())
                {
                    DataType ah_ = THAProcedure?.Performed;
                    object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                    return (ai_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> k_ = QICoreCommon_4_0_000.Instance.toInterval(context, j_());
            return k_;
        }

        IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.Select<Procedure, CqlInterval<CqlDateTime>>(a_, b_);
        IEnumerable<CqlInterval<CqlDateTime>> d_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(c_);

        IEnumerable<CqlInterval<CqlDateTime>> e_(CqlInterval<CqlDateTime> TotalHip) {
            IEnumerable<CqlDate> aj_ = this.Date_PROMIS10_Total_Assessment_Completed(context);

            bool? ak_(CqlDate InitialHipAssessmentPROMIS10) {
                CqlDateTime ao_ = context.Operators.Start(TotalHip);
                CqlQuantity ap_ = context.Operators.Quantity(90m, "days");
                CqlDate aq_ = context.Operators.Add(InitialHipAssessmentPROMIS10, ap_);
                CqlInterval<CqlDate> ar_ = context.Operators.Interval(InitialHipAssessmentPROMIS10, aq_, true, true);
                CqlDate as_ = ar_?.low;
                CqlDateTime at_ = context.Operators.ConvertDateToDateTime(as_);
                CqlDate av_ = context.Operators.Add(InitialHipAssessmentPROMIS10, ap_);
                CqlInterval<CqlDate> aw_ = context.Operators.Interval(InitialHipAssessmentPROMIS10, av_, true, true);
                CqlDate ax_ = aw_?.high;
                CqlDateTime ay_ = context.Operators.ConvertDateToDateTime(ax_);
                CqlDate ba_ = context.Operators.Add(InitialHipAssessmentPROMIS10, ap_);
                CqlInterval<CqlDate> bb_ = context.Operators.Interval(InitialHipAssessmentPROMIS10, ba_, true, true);
                bool? bc_ = bb_?.lowClosed;
                CqlDate be_ = context.Operators.Add(InitialHipAssessmentPROMIS10, ap_);
                CqlInterval<CqlDate> bf_ = context.Operators.Interval(InitialHipAssessmentPROMIS10, be_, true, true);
                bool? bg_ = bf_?.highClosed;
                CqlInterval<CqlDateTime> bh_ = context.Operators.Interval(at_, ay_, bc_, bg_);
                bool? bi_ = context.Operators.In<CqlDateTime>(ao_, bh_, "day");
                bool? bj_ = context.Operators.Not((bool?)(InitialHipAssessmentPROMIS10 is null));
                bool? bk_ = context.Operators.And(bi_, bj_);
                return bk_;
            }

            IEnumerable<CqlDate> al_ = context.Operators.Where<CqlDate>(aj_, ak_);
            CqlInterval<CqlDateTime> am_(CqlDate InitialHipAssessmentPROMIS10) => TotalHip;
            IEnumerable<CqlInterval<CqlDateTime>> an_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(al_, am_);
            return an_;
        }

        IEnumerable<CqlInterval<CqlDateTime>> f_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(d_, e_);

        IEnumerable<CqlInterval<CqlDateTime>> g_(CqlInterval<CqlDateTime> TotalHip) {
            IEnumerable<CqlDate> bl_ = this.Date_PROMIS10_Total_Assessment_Completed(context);

            bool? bm_(CqlDate FollowUpHipAssessmentPROMIS10) {
                CqlDateTime bq_ = context.Operators.ConvertDateToDateTime(FollowUpHipAssessmentPROMIS10);
                CqlDate br_ = context.Operators.DateFrom(bq_);
                CqlDateTime bs_ = context.Operators.End(TotalHip);
                CqlDate bt_ = context.Operators.DateFrom(bs_);
                CqlQuantity bu_ = context.Operators.Quantity(300m, "days");
                CqlDate bv_ = context.Operators.Add(bt_, bu_);
                CqlDate bx_ = context.Operators.DateFrom(bs_);
                CqlQuantity by_ = context.Operators.Quantity(425m, "days");
                CqlDate bz_ = context.Operators.Add(bx_, by_);
                CqlInterval<CqlDate> ca_ = context.Operators.Interval(bv_, bz_, true, true);
                bool? cb_ = context.Operators.In<CqlDate>(br_, ca_, "day");
                return cb_;
            }

            IEnumerable<CqlDate> bn_ = context.Operators.Where<CqlDate>(bl_, bm_);
            CqlInterval<CqlDateTime> bo_(CqlDate FollowUpHipAssessmentPROMIS10) => TotalHip;
            IEnumerable<CqlInterval<CqlDateTime>> bp_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(bn_, bo_);
            return bp_;
        }

        IEnumerable<CqlInterval<CqlDateTime>> h_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(f_, g_);
        bool? i_ = context.Operators.Exists<CqlInterval<CqlDateTime>>(h_);
        return i_;
    }


    [CqlExpressionDefinition("Date VR12 Oblique Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_VR12_Oblique_Total_Assessment_Completed(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Date_VR12_Oblique_Total_Assessment_Completed, Date_VR12_Oblique_Total_Assessment_Completed_Compute, context) ?? Date_VR12_Oblique_Total_Assessment_Completed_Compute(context);

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
            (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? q_ = (CqlTupleMetadata_GAdRFKRaHUUGJcVHWQWRUjhRH, _valueTuple.Item1, _valueTuple.Item2);
            return q_;
        }

        IEnumerable<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?> k_ = context.Operators.Select<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?>(i_, j_);

        bool? l_((CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? tuple_gadrfkrahuugjcvhwqwrujhrh) {
            DataType r_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Effective;
            object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
            CqlInterval<CqlDateTime> t_ = QICoreCommon_4_0_000.Instance.toInterval(context, s_);
            CqlDateTime u_ = context.Operators.Start(t_);
            CqlDate v_ = context.Operators.DateFrom(u_);
            DataType w_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Effective;
            object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
            CqlInterval<CqlDateTime> y_ = QICoreCommon_4_0_000.Instance.toInterval(context, x_);
            CqlDateTime z_ = context.Operators.Start(y_);
            CqlDate aa_ = context.Operators.DateFrom(z_);
            bool? ab_ = context.Operators.SameAs(v_, aa_, "day");
            DataType ac_ = (tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment as Observation)?.Value;
            object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
            bool? ae_ = context.Operators.Not((bool?)(ad_ is null));
            bool? af_ = context.Operators.And(ab_, ae_);
            DataType ag_ = (tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment as Observation)?.Value;
            object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
            bool? ai_ = context.Operators.Not((bool?)(ah_ is null));
            bool? aj_ = context.Operators.And(af_, ai_);
            return aj_;
        }

        IEnumerable<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?> m_ = context.Operators.Where<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?>(k_, l_);

        CqlDate n_((CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? tuple_gadrfkrahuugjcvhwqwrujhrh) {
            DataType ak_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Effective;
            object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
            CqlInterval<CqlDateTime> am_ = QICoreCommon_4_0_000.Instance.toInterval(context, al_);
            CqlDateTime an_ = context.Operators.Start(am_);
            CqlDate ao_ = context.Operators.DateFrom(an_);
            DataType ap_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Effective;
            object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
            CqlInterval<CqlDateTime> ar_ = QICoreCommon_4_0_000.Instance.toInterval(context, aq_);
            CqlDateTime as_ = context.Operators.Start(ar_);
            CqlDate at_ = context.Operators.DateFrom(as_);
            CqlDate[] au_ = [
                ao_,
                at_,
            ];
            CqlDate av_ = context.Operators.Max<CqlDate>((IEnumerable<CqlDate>)au_);
            return av_;
        }

        IEnumerable<CqlDate> o_ = context.Operators.Select<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?, CqlDate>(m_, n_);
        IEnumerable<CqlDate> p_ = context.Operators.Distinct<CqlDate>(o_);
        return p_;
    }


    [CqlExpressionDefinition("Has THA with Initial and Follow Up VR12 Oblique Assessments")]
    public bool? Has_THA_with_Initial_and_Follow_Up_VR12_Oblique_Assessments(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Has_THA_with_Initial_and_Follow_Up_VR12_Oblique_Assessments, Has_THA_with_Initial_and_Follow_Up_VR12_Oblique_Assessments_Compute, context) ?? Has_THA_with_Initial_and_Follow_Up_VR12_Oblique_Assessments_Compute(context);

    private bool? Has_THA_with_Initial_and_Follow_Up_VR12_Oblique_Assessments_Compute(CqlContext context)
    {
        IEnumerable<Procedure> a_ = this.Total_Hip_Arthroplasty_Procedure(context);

        CqlInterval<CqlDateTime> b_(Procedure THAProcedure) {

            object j_() {

                bool l_() {
                    DataType p_ = THAProcedure?.Performed;
                    object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
                    bool r_ = q_ is CqlDateTime;
                    return r_;
                }


                bool m_() {
                    DataType s_ = THAProcedure?.Performed;
                    object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                    bool u_ = t_ is CqlInterval<CqlDateTime>;
                    return u_;
                }


                bool n_() {
                    DataType v_ = THAProcedure?.Performed;
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    bool x_ = w_ is CqlQuantity;
                    return x_;
                }


                bool o_() {
                    DataType y_ = THAProcedure?.Performed;
                    object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                    bool aa_ = z_ is CqlInterval<CqlQuantity>;
                    return aa_;
                }

                if (l_())
                {
                    DataType ab_ = THAProcedure?.Performed;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    return (ac_ as CqlDateTime) as object;
                }
                else if (m_())
                {
                    DataType ad_ = THAProcedure?.Performed;
                    object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                    return (ae_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (n_())
                {
                    DataType af_ = THAProcedure?.Performed;
                    object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                    return (ag_ as CqlQuantity) as object;
                }
                else if (o_())
                {
                    DataType ah_ = THAProcedure?.Performed;
                    object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                    return (ai_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> k_ = QICoreCommon_4_0_000.Instance.toInterval(context, j_());
            return k_;
        }

        IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.Select<Procedure, CqlInterval<CqlDateTime>>(a_, b_);
        IEnumerable<CqlInterval<CqlDateTime>> d_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(c_);

        IEnumerable<CqlInterval<CqlDateTime>> e_(CqlInterval<CqlDateTime> TotalHip) {
            IEnumerable<CqlDate> aj_ = this.Date_VR12_Oblique_Total_Assessment_Completed(context);

            bool? ak_(CqlDate InitialHipAssessmentOblique) {
                CqlDateTime ao_ = context.Operators.Start(TotalHip);
                CqlQuantity ap_ = context.Operators.Quantity(90m, "days");
                CqlDate aq_ = context.Operators.Add(InitialHipAssessmentOblique, ap_);
                CqlInterval<CqlDate> ar_ = context.Operators.Interval(InitialHipAssessmentOblique, aq_, true, true);
                CqlDate as_ = ar_?.low;
                CqlDateTime at_ = context.Operators.ConvertDateToDateTime(as_);
                CqlDate av_ = context.Operators.Add(InitialHipAssessmentOblique, ap_);
                CqlInterval<CqlDate> aw_ = context.Operators.Interval(InitialHipAssessmentOblique, av_, true, true);
                CqlDate ax_ = aw_?.high;
                CqlDateTime ay_ = context.Operators.ConvertDateToDateTime(ax_);
                CqlDate ba_ = context.Operators.Add(InitialHipAssessmentOblique, ap_);
                CqlInterval<CqlDate> bb_ = context.Operators.Interval(InitialHipAssessmentOblique, ba_, true, true);
                bool? bc_ = bb_?.lowClosed;
                CqlDate be_ = context.Operators.Add(InitialHipAssessmentOblique, ap_);
                CqlInterval<CqlDate> bf_ = context.Operators.Interval(InitialHipAssessmentOblique, be_, true, true);
                bool? bg_ = bf_?.highClosed;
                CqlInterval<CqlDateTime> bh_ = context.Operators.Interval(at_, ay_, bc_, bg_);
                bool? bi_ = context.Operators.In<CqlDateTime>(ao_, bh_, "day");
                bool? bj_ = context.Operators.Not((bool?)(InitialHipAssessmentOblique is null));
                bool? bk_ = context.Operators.And(bi_, bj_);
                return bk_;
            }

            IEnumerable<CqlDate> al_ = context.Operators.Where<CqlDate>(aj_, ak_);
            CqlInterval<CqlDateTime> am_(CqlDate InitialHipAssessmentOblique) => TotalHip;
            IEnumerable<CqlInterval<CqlDateTime>> an_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(al_, am_);
            return an_;
        }

        IEnumerable<CqlInterval<CqlDateTime>> f_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(d_, e_);

        IEnumerable<CqlInterval<CqlDateTime>> g_(CqlInterval<CqlDateTime> TotalHip) {
            IEnumerable<CqlDate> bl_ = this.Date_VR12_Oblique_Total_Assessment_Completed(context);

            bool? bm_(CqlDate FollowUpHipAssessmentOblique) {
                CqlDateTime bq_ = context.Operators.ConvertDateToDateTime(FollowUpHipAssessmentOblique);
                CqlDate br_ = context.Operators.DateFrom(bq_);
                CqlDateTime bs_ = context.Operators.End(TotalHip);
                CqlDate bt_ = context.Operators.DateFrom(bs_);
                CqlQuantity bu_ = context.Operators.Quantity(300m, "days");
                CqlDate bv_ = context.Operators.Add(bt_, bu_);
                CqlDate bx_ = context.Operators.DateFrom(bs_);
                CqlQuantity by_ = context.Operators.Quantity(425m, "days");
                CqlDate bz_ = context.Operators.Add(bx_, by_);
                CqlInterval<CqlDate> ca_ = context.Operators.Interval(bv_, bz_, true, true);
                bool? cb_ = context.Operators.In<CqlDate>(br_, ca_, "day");
                return cb_;
            }

            IEnumerable<CqlDate> bn_ = context.Operators.Where<CqlDate>(bl_, bm_);
            CqlInterval<CqlDateTime> bo_(CqlDate FollowUpHipAssessmentOblique) => TotalHip;
            IEnumerable<CqlInterval<CqlDateTime>> bp_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(bn_, bo_);
            return bp_;
        }

        IEnumerable<CqlInterval<CqlDateTime>> h_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(f_, g_);
        bool? i_ = context.Operators.Exists<CqlInterval<CqlDateTime>>(h_);
        return i_;
    }


    [CqlExpressionDefinition("Date VR12 Orthogonal Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_VR12_Orthogonal_Total_Assessment_Completed(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Date_VR12_Orthogonal_Total_Assessment_Completed, Date_VR12_Orthogonal_Total_Assessment_Completed_Compute, context) ?? Date_VR12_Orthogonal_Total_Assessment_Completed_Compute(context);

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
            (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? q_ = (CqlTupleMetadata_GAdRFKRaHUUGJcVHWQWRUjhRH, _valueTuple.Item1, _valueTuple.Item2);
            return q_;
        }

        IEnumerable<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?> k_ = context.Operators.Select<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?>(i_, j_);

        bool? l_((CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? tuple_gadrfkrahuugjcvhwqwrujhrh) {
            DataType r_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Effective;
            object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
            CqlInterval<CqlDateTime> t_ = QICoreCommon_4_0_000.Instance.toInterval(context, s_);
            CqlDateTime u_ = context.Operators.Start(t_);
            CqlDate v_ = context.Operators.DateFrom(u_);
            DataType w_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Effective;
            object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
            CqlInterval<CqlDateTime> y_ = QICoreCommon_4_0_000.Instance.toInterval(context, x_);
            CqlDateTime z_ = context.Operators.Start(y_);
            CqlDate aa_ = context.Operators.DateFrom(z_);
            bool? ab_ = context.Operators.SameAs(v_, aa_, "day");
            DataType ac_ = (tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment as Observation)?.Value;
            object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
            bool? ae_ = context.Operators.Not((bool?)(ad_ is null));
            bool? af_ = context.Operators.And(ab_, ae_);
            DataType ag_ = (tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment as Observation)?.Value;
            object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
            bool? ai_ = context.Operators.Not((bool?)(ah_ is null));
            bool? aj_ = context.Operators.And(af_, ai_);
            return aj_;
        }

        IEnumerable<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?> m_ = context.Operators.Where<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?>(k_, l_);

        CqlDate n_((CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? tuple_gadrfkrahuugjcvhwqwrujhrh) {
            DataType ak_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Effective;
            object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
            CqlInterval<CqlDateTime> am_ = QICoreCommon_4_0_000.Instance.toInterval(context, al_);
            CqlDateTime an_ = context.Operators.Start(am_);
            CqlDate ao_ = context.Operators.DateFrom(an_);
            DataType ap_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Effective;
            object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
            CqlInterval<CqlDateTime> ar_ = QICoreCommon_4_0_000.Instance.toInterval(context, aq_);
            CqlDateTime as_ = context.Operators.Start(ar_);
            CqlDate at_ = context.Operators.DateFrom(as_);
            CqlDate[] au_ = [
                ao_,
                at_,
            ];
            CqlDate av_ = context.Operators.Max<CqlDate>((IEnumerable<CqlDate>)au_);
            return av_;
        }

        IEnumerable<CqlDate> o_ = context.Operators.Select<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?, CqlDate>(m_, n_);
        IEnumerable<CqlDate> p_ = context.Operators.Distinct<CqlDate>(o_);
        return p_;
    }


    [CqlExpressionDefinition("Has THA with Initial and Follow Up VR12 Orthogonal Assessments")]
    public bool? Has_THA_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Has_THA_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments, Has_THA_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments_Compute, context) ?? Has_THA_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments_Compute(context);

    private bool? Has_THA_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments_Compute(CqlContext context)
    {
        IEnumerable<Procedure> a_ = this.Total_Hip_Arthroplasty_Procedure(context);

        CqlInterval<CqlDateTime> b_(Procedure THAProcedure) {

            object j_() {

                bool l_() {
                    DataType p_ = THAProcedure?.Performed;
                    object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
                    bool r_ = q_ is CqlDateTime;
                    return r_;
                }


                bool m_() {
                    DataType s_ = THAProcedure?.Performed;
                    object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                    bool u_ = t_ is CqlInterval<CqlDateTime>;
                    return u_;
                }


                bool n_() {
                    DataType v_ = THAProcedure?.Performed;
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    bool x_ = w_ is CqlQuantity;
                    return x_;
                }


                bool o_() {
                    DataType y_ = THAProcedure?.Performed;
                    object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                    bool aa_ = z_ is CqlInterval<CqlQuantity>;
                    return aa_;
                }

                if (l_())
                {
                    DataType ab_ = THAProcedure?.Performed;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    return (ac_ as CqlDateTime) as object;
                }
                else if (m_())
                {
                    DataType ad_ = THAProcedure?.Performed;
                    object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                    return (ae_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (n_())
                {
                    DataType af_ = THAProcedure?.Performed;
                    object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                    return (ag_ as CqlQuantity) as object;
                }
                else if (o_())
                {
                    DataType ah_ = THAProcedure?.Performed;
                    object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                    return (ai_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> k_ = QICoreCommon_4_0_000.Instance.toInterval(context, j_());
            return k_;
        }

        IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.Select<Procedure, CqlInterval<CqlDateTime>>(a_, b_);
        IEnumerable<CqlInterval<CqlDateTime>> d_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(c_);

        IEnumerable<CqlInterval<CqlDateTime>> e_(CqlInterval<CqlDateTime> TotalHip) {
            IEnumerable<CqlDate> aj_ = this.Date_VR12_Orthogonal_Total_Assessment_Completed(context);

            bool? ak_(CqlDate InitialHipAssessmentOrthogonal) {
                CqlDateTime ao_ = context.Operators.Start(TotalHip);
                CqlQuantity ap_ = context.Operators.Quantity(90m, "days");
                CqlDate aq_ = context.Operators.Add(InitialHipAssessmentOrthogonal, ap_);
                CqlInterval<CqlDate> ar_ = context.Operators.Interval(InitialHipAssessmentOrthogonal, aq_, true, true);
                CqlDate as_ = ar_?.low;
                CqlDateTime at_ = context.Operators.ConvertDateToDateTime(as_);
                CqlDate av_ = context.Operators.Add(InitialHipAssessmentOrthogonal, ap_);
                CqlInterval<CqlDate> aw_ = context.Operators.Interval(InitialHipAssessmentOrthogonal, av_, true, true);
                CqlDate ax_ = aw_?.high;
                CqlDateTime ay_ = context.Operators.ConvertDateToDateTime(ax_);
                CqlDate ba_ = context.Operators.Add(InitialHipAssessmentOrthogonal, ap_);
                CqlInterval<CqlDate> bb_ = context.Operators.Interval(InitialHipAssessmentOrthogonal, ba_, true, true);
                bool? bc_ = bb_?.lowClosed;
                CqlDate be_ = context.Operators.Add(InitialHipAssessmentOrthogonal, ap_);
                CqlInterval<CqlDate> bf_ = context.Operators.Interval(InitialHipAssessmentOrthogonal, be_, true, true);
                bool? bg_ = bf_?.highClosed;
                CqlInterval<CqlDateTime> bh_ = context.Operators.Interval(at_, ay_, bc_, bg_);
                bool? bi_ = context.Operators.In<CqlDateTime>(ao_, bh_, "day");
                bool? bj_ = context.Operators.Not((bool?)(InitialHipAssessmentOrthogonal is null));
                bool? bk_ = context.Operators.And(bi_, bj_);
                return bk_;
            }

            IEnumerable<CqlDate> al_ = context.Operators.Where<CqlDate>(aj_, ak_);
            CqlInterval<CqlDateTime> am_(CqlDate InitialHipAssessmentOrthogonal) => TotalHip;
            IEnumerable<CqlInterval<CqlDateTime>> an_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(al_, am_);
            return an_;
        }

        IEnumerable<CqlInterval<CqlDateTime>> f_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(d_, e_);

        IEnumerable<CqlInterval<CqlDateTime>> g_(CqlInterval<CqlDateTime> TotalHip) {
            IEnumerable<CqlDate> bl_ = this.Date_VR12_Orthogonal_Total_Assessment_Completed(context);

            bool? bm_(CqlDate FollowUpHipAssessmentOrthogonal) {
                CqlDateTime bq_ = context.Operators.ConvertDateToDateTime(FollowUpHipAssessmentOrthogonal);
                CqlDate br_ = context.Operators.DateFrom(bq_);
                CqlDateTime bs_ = context.Operators.End(TotalHip);
                CqlDate bt_ = context.Operators.DateFrom(bs_);
                CqlQuantity bu_ = context.Operators.Quantity(300m, "days");
                CqlDate bv_ = context.Operators.Add(bt_, bu_);
                CqlDate bx_ = context.Operators.DateFrom(bs_);
                CqlQuantity by_ = context.Operators.Quantity(425m, "days");
                CqlDate bz_ = context.Operators.Add(bx_, by_);
                CqlInterval<CqlDate> ca_ = context.Operators.Interval(bv_, bz_, true, true);
                bool? cb_ = context.Operators.In<CqlDate>(br_, ca_, "day");
                return cb_;
            }

            IEnumerable<CqlDate> bn_ = context.Operators.Where<CqlDate>(bl_, bm_);
            CqlInterval<CqlDateTime> bo_(CqlDate FollowUpHipAssessmentOrthogonal) => TotalHip;
            IEnumerable<CqlInterval<CqlDateTime>> bp_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(bn_, bo_);
            return bp_;
        }

        IEnumerable<CqlInterval<CqlDateTime>> h_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(f_, g_);
        bool? i_ = context.Operators.Exists<CqlInterval<CqlDateTime>>(h_);
        return i_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute, context) ?? Numerator_Compute(context);

    private bool? Numerator_Compute(CqlContext context)
    {
        bool? a_ = this.Has_THA_with_Initial_and_Follow_Up_HOOS_Assessments(context);
        bool? b_ = this.Has_THA_with_Initial_and_Follow_Up_HOOSJr_Assessments(context);
        bool? c_ = context.Operators.Or(a_, b_);
        bool? d_ = this.Has_THA_with_Initial_and_Follow_Up_PROMIS10_Assessments(context);
        bool? e_ = context.Operators.Or(c_, d_);
        bool? f_ = this.Has_THA_with_Initial_and_Follow_Up_VR12_Oblique_Assessments(context);
        bool? g_ = context.Operators.Or(e_, f_);
        bool? h_ = this.Has_THA_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments(context);
        bool? i_ = context.Operators.Or(g_, h_);
        return i_;
    }


    #endregion Functions and Expressions

    #region Cache Index Fields (33)

    private int _cacheIndex_Measurement_Period = -1;
    private int _cacheIndex_Patient = -1;
    private int _cacheIndex_SDE_Ethnicity = -1;
    private int _cacheIndex_SDE_Payer = -1;
    private int _cacheIndex_SDE_Race = -1;
    private int _cacheIndex_SDE_Sex = -1;
    private int _cacheIndex_August_1_Year_Prior_to_the_Measurement_Period = -1;
    private int _cacheIndex_Has_Qualifying_Encounter = -1;
    private int _cacheIndex_November_1_Two_Years_Prior_to_the_Measurement_Period = -1;
    private int _cacheIndex_October_31_Year_Prior_to_the_Measurement_Period = -1;
    private int _cacheIndex_Total_Hip_Arthroplasty_Procedure = -1;
    private int _cacheIndex_Initial_Population = -1;
    private int _cacheIndex_Denominator = -1;
    private int _cacheIndex_Has_Severe_Cognitive_Impairment = -1;
    private int _cacheIndex_Has_Total_Hip_Arthroplasty_with_1_or_More_Lower_Body_Fractures = -1;
    private int _cacheIndex_Has_Partial_Hip_Arthroplasty_Procedure = -1;
    private int _cacheIndex_Has_Revision_Hip_Arthroplasty_Procedure_or_Implanted_Device_or_Prosthesis_Removal_Procedure = -1;
    private int _cacheIndex_Has_Malignant_Neoplasm_of_Lower_and_Unspecified_Limbs = -1;
    private int _cacheIndex_Has_Mechanical_Complication = -1;
    private int _cacheIndex_Has_More_Than_One_Elective_Primary_Total_Hip_Arthroplasty_Performed = -1;
    private int _cacheIndex_Death_Within_300_Days_of_the_THA_Procedure = -1;
    private int _cacheIndex_Denominator_Exclusions = -1;
    private int _cacheIndex_Date_HOOS_Total_Assessment_Completed = -1;
    private int _cacheIndex_Has_THA_with_Initial_and_Follow_Up_HOOS_Assessments = -1;
    private int _cacheIndex_Date_HOOSJr_Total_Assessment_Completed = -1;
    private int _cacheIndex_Has_THA_with_Initial_and_Follow_Up_HOOSJr_Assessments = -1;
    private int _cacheIndex_Date_PROMIS10_Total_Assessment_Completed = -1;
    private int _cacheIndex_Has_THA_with_Initial_and_Follow_Up_PROMIS10_Assessments = -1;
    private int _cacheIndex_Date_VR12_Oblique_Total_Assessment_Completed = -1;
    private int _cacheIndex_Has_THA_with_Initial_and_Follow_Up_VR12_Oblique_Assessments = -1;
    private int _cacheIndex_Date_VR12_Orthogonal_Total_Assessment_Completed = -1;
    private int _cacheIndex_Has_THA_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments = -1;
    private int _cacheIndex_Numerator = -1;

    #endregion Cache Index Fields

    #region ILibraryInternals Implementation

    private CqlLibraryInvocationCache _cache = CqlLibraryInvocationCache.NeverCached;

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
        _cacheIndex_SDE_Ethnicity = index++;
        _cacheIndex_SDE_Payer = index++;
        _cacheIndex_SDE_Race = index++;
        _cacheIndex_SDE_Sex = index++;
        _cacheIndex_August_1_Year_Prior_to_the_Measurement_Period = index++;
        _cacheIndex_Has_Qualifying_Encounter = index++;
        _cacheIndex_November_1_Two_Years_Prior_to_the_Measurement_Period = index++;
        _cacheIndex_October_31_Year_Prior_to_the_Measurement_Period = index++;
        _cacheIndex_Total_Hip_Arthroplasty_Procedure = index++;
        _cacheIndex_Initial_Population = index++;
        _cacheIndex_Denominator = index++;
        _cacheIndex_Has_Severe_Cognitive_Impairment = index++;
        _cacheIndex_Has_Total_Hip_Arthroplasty_with_1_or_More_Lower_Body_Fractures = index++;
        _cacheIndex_Has_Partial_Hip_Arthroplasty_Procedure = index++;
        _cacheIndex_Has_Revision_Hip_Arthroplasty_Procedure_or_Implanted_Device_or_Prosthesis_Removal_Procedure = index++;
        _cacheIndex_Has_Malignant_Neoplasm_of_Lower_and_Unspecified_Limbs = index++;
        _cacheIndex_Has_Mechanical_Complication = index++;
        _cacheIndex_Has_More_Than_One_Elective_Primary_Total_Hip_Arthroplasty_Performed = index++;
        _cacheIndex_Death_Within_300_Days_of_the_THA_Procedure = index++;
        _cacheIndex_Denominator_Exclusions = index++;
        _cacheIndex_Date_HOOS_Total_Assessment_Completed = index++;
        _cacheIndex_Has_THA_with_Initial_and_Follow_Up_HOOS_Assessments = index++;
        _cacheIndex_Date_HOOSJr_Total_Assessment_Completed = index++;
        _cacheIndex_Has_THA_with_Initial_and_Follow_Up_HOOSJr_Assessments = index++;
        _cacheIndex_Date_PROMIS10_Total_Assessment_Completed = index++;
        _cacheIndex_Has_THA_with_Initial_and_Follow_Up_PROMIS10_Assessments = index++;
        _cacheIndex_Date_VR12_Oblique_Total_Assessment_Completed = index++;
        _cacheIndex_Has_THA_with_Initial_and_Follow_Up_VR12_Oblique_Assessments = index++;
        _cacheIndex_Date_VR12_Orthogonal_Total_Assessment_Completed = index++;
        _cacheIndex_Has_THA_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments = index++;
        _cacheIndex_Numerator = index++;
        return index - startIndex;
    }

    /// <summary>
    /// Sets the cache instance that this library will use for caching computed values.
    /// </summary>
    /// <param name="cache">The cache instance to use.</param>
    void ILibraryInternals.SetCacheInstance(CqlLibraryInvocationCache cache)
    {
        _cache = cache;
    }

    #endregion ILibraryInternals Implementation

    #region Singleton Lifetime Members

    private CMS56FHIRFuncStatHipReplacement_1_0_000() {}

    public static CMS56FHIRFuncStatHipReplacement_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS56FHIRFuncStatHipReplacement";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, QICoreCommon_4_0_000.Instance, SupplementalDataElements_5_1_000.Instance, Hospice_6_18_000.Instance, Status_1_15_000.Instance];

    #endregion ILibrary Implementation

    #region CqlTupleMetadata Properties (3)

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
