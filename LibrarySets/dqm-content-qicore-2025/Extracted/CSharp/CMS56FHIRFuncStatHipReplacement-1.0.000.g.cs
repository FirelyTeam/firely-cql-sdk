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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.5.0")]
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
                DataType p_ = THAProcedure?.Performed;
                object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
                f_ = q_ as CqlDateTime;
            }
            else
            {
                DataType r_ = THAProcedure?.Performed;
                object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                bool t_ = s_ is CqlInterval<CqlDateTime>;
                if (t_)
                {
                    DataType u_ = THAProcedure?.Performed;
                    object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                    f_ = v_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType w_ = THAProcedure?.Performed;
                    object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                    bool y_ = x_ is CqlQuantity;
                    if (y_)
                    {
                        DataType z_ = THAProcedure?.Performed;
                        object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                        f_ = aa_ as CqlQuantity;
                    }
                    else
                    {
                        DataType ab_ = THAProcedure?.Performed;
                        object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                        bool ad_ = ac_ is CqlInterval<CqlQuantity>;
                        if (ad_)
                        {
                            DataType ae_ = THAProcedure?.Performed;
                            object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                            f_ = af_ as CqlInterval<CqlQuantity>;
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
            CqlInterval<CqlDateTime> i_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, Dementia);
            CqlInterval<CqlDateTime> j_ = this.Measurement_Period(context);
            bool? k_ = context.Operators.Overlaps(i_, j_, "day");
            return k_;
        }

        IEnumerable<Condition> g_ = context.Operators.Where<Condition>(e_, f_);
        bool? h_ = context.Operators.Exists<Condition>(g_);
        return h_;
    }


    [CqlFunctionDefinition("isVerified")]
    [CqlTag("note", "When possible, this function should be migrated to QICoreCommon.")]
    [CqlTag("description", "\"confirmed\", \"unconfirmed\", \"provisional\", or \"differential\"")]
    public bool? isVerified(CqlContext context, Condition condition)
    {
        CodeableConcept a_ = condition?.VerificationStatus;
        CqlConcept b_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_);
        bool? c_ = context.Operators.Not((bool?)(b_ is null));
        CqlCode d_ = QICoreCommon_4_0_000.Instance.confirmed(context);
        CqlConcept e_ = context.Operators.ConvertCodeToConcept(d_);
        bool? f_ = context.Operators.Equivalent(b_, e_);
        CqlCode g_ = QICoreCommon_4_0_000.Instance.unconfirmed(context);
        CqlConcept h_ = context.Operators.ConvertCodeToConcept(g_);
        bool? i_ = context.Operators.Equivalent(b_, h_);
        bool? j_ = context.Operators.Or(f_, i_);
        CqlCode k_ = QICoreCommon_4_0_000.Instance.provisional(context);
        CqlConcept l_ = context.Operators.ConvertCodeToConcept(k_);
        bool? m_ = context.Operators.Equivalent(b_, l_);
        bool? n_ = context.Operators.Or(j_, m_);
        CqlCode o_ = QICoreCommon_4_0_000.Instance.differential(context);
        CqlConcept p_ = context.Operators.ConvertCodeToConcept(o_);
        bool? q_ = context.Operators.Equivalent(b_, p_);
        bool? r_ = context.Operators.Or(n_, q_);
        bool? s_ = context.Operators.Implies(c_, r_);
        return s_;
    }


    [CqlExpressionDefinition("Has Total Hip Arthroplasty with 1 or More Lower Body Fractures")]
    public bool? Has_Total_Hip_Arthroplasty_with_1_or_More_Lower_Body_Fractures(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Total_Hip_Arthroplasty_with_1_or_More_Lower_Body_Fractures, Has_Total_Hip_Arthroplasty_with_1_or_More_Lower_Body_Fractures_Compute);

    private const long _cacheIndex_Has_Total_Hip_Arthroplasty_with_1_or_More_Lower_Body_Fractures = 99885326323127770L;

    private bool? Has_Total_Hip_Arthroplasty_with_1_or_More_Lower_Body_Fractures_Compute(CqlContext context)
    {
        IEnumerable<Procedure> a_ = this.Total_Hip_Arthroplasty_Procedure(context);

        bool? b_(Procedure THAProcedure) {
            CqlValueSet e_ = this.Lower_Body_Fractures_Excluding_Ankle_and_Foot(context);
            IEnumerable<Condition> f_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> h_ = context.Operators.Union<Condition>(f_ as IEnumerable<Condition>, g_ as IEnumerable<Condition>);

            bool? i_(Condition LowerBodyFracture) {
                CqlInterval<CqlDateTime> l_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, LowerBodyFracture);
                CqlDateTime m_ = context.Operators.Start(l_);
                object n_;
                DataType ae_ = THAProcedure?.Performed;
                object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                bool ag_ = af_ is CqlDateTime;
                if (ag_)
                {
                    DataType ah_ = THAProcedure?.Performed;
                    object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                    n_ = ai_ as CqlDateTime;
                }
                else
                {
                    DataType aj_ = THAProcedure?.Performed;
                    object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                    bool al_ = ak_ is CqlInterval<CqlDateTime>;
                    if (al_)
                    {
                        DataType am_ = THAProcedure?.Performed;
                        object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                        n_ = an_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType ao_ = THAProcedure?.Performed;
                        object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                        bool aq_ = ap_ is CqlQuantity;
                        if (aq_)
                        {
                            DataType ar_ = THAProcedure?.Performed;
                            object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                            n_ = as_ as CqlQuantity;
                        }
                        else
                        {
                            DataType at_ = THAProcedure?.Performed;
                            object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                            bool av_ = au_ is CqlInterval<CqlQuantity>;
                            if (av_)
                            {
                                DataType aw_ = THAProcedure?.Performed;
                                object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                                n_ = ax_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                n_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> o_ = QICoreCommon_4_0_000.Instance.toInterval(context, n_);
                CqlDateTime p_ = context.Operators.Start(o_);
                CqlQuantity q_ = context.Operators.Quantity(48m, "hours");
                CqlDateTime r_ = context.Operators.Subtract(p_, q_);
                object s_;
                DataType ay_ = THAProcedure?.Performed;
                object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                bool ba_ = az_ is CqlDateTime;
                if (ba_)
                {
                    DataType bb_ = THAProcedure?.Performed;
                    object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                    s_ = bc_ as CqlDateTime;
                }
                else
                {
                    DataType bd_ = THAProcedure?.Performed;
                    object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                    bool bf_ = be_ is CqlInterval<CqlDateTime>;
                    if (bf_)
                    {
                        DataType bg_ = THAProcedure?.Performed;
                        object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                        s_ = bh_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType bi_ = THAProcedure?.Performed;
                        object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                        bool bk_ = bj_ is CqlQuantity;
                        if (bk_)
                        {
                            DataType bl_ = THAProcedure?.Performed;
                            object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                            s_ = bm_ as CqlQuantity;
                        }
                        else
                        {
                            DataType bn_ = THAProcedure?.Performed;
                            object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                            bool bp_ = bo_ is CqlInterval<CqlQuantity>;
                            if (bp_)
                            {
                                DataType bq_ = THAProcedure?.Performed;
                                object br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
                                s_ = br_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                s_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> t_ = QICoreCommon_4_0_000.Instance.toInterval(context, s_);
                CqlDateTime u_ = context.Operators.Start(t_);
                CqlInterval<CqlDateTime> v_ = context.Operators.Interval(r_, u_, true, true);
                bool? w_ = context.Operators.In<CqlDateTime>(m_, v_, (string)default);
                object x_;
                DataType bs_ = THAProcedure?.Performed;
                object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                bool bu_ = bt_ is CqlDateTime;
                if (bu_)
                {
                    DataType bv_ = THAProcedure?.Performed;
                    object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                    x_ = bw_ as CqlDateTime;
                }
                else
                {
                    DataType bx_ = THAProcedure?.Performed;
                    object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                    bool bz_ = by_ is CqlInterval<CqlDateTime>;
                    if (bz_)
                    {
                        DataType ca_ = THAProcedure?.Performed;
                        object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                        x_ = cb_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType cc_ = THAProcedure?.Performed;
                        object cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                        bool ce_ = cd_ is CqlQuantity;
                        if (ce_)
                        {
                            DataType cf_ = THAProcedure?.Performed;
                            object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                            x_ = cg_ as CqlQuantity;
                        }
                        else
                        {
                            DataType ch_ = THAProcedure?.Performed;
                            object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                            bool cj_ = ci_ is CqlInterval<CqlQuantity>;
                            if (cj_)
                            {
                                DataType ck_ = THAProcedure?.Performed;
                                object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                                x_ = cl_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                x_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> y_ = QICoreCommon_4_0_000.Instance.toInterval(context, x_);
                CqlDateTime z_ = context.Operators.Start(y_);
                bool? aa_ = context.Operators.Not((bool?)(z_ is null));
                bool? ab_ = context.Operators.And(w_, aa_);
                bool? ac_ = this.isVerified(context, LowerBodyFracture);
                bool? ad_ = context.Operators.And(ab_, ac_);
                return ad_;
            }

            IEnumerable<Condition> j_ = context.Operators.Where<Condition>(h_, i_);
            bool? k_ = context.Operators.Exists<Condition>(j_);
            return k_;
        }

        IEnumerable<Procedure> c_ = context.Operators.Where<Procedure>(a_, b_);
        bool? d_ = context.Operators.Exists<Procedure>(c_);
        return d_;
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
            IEnumerable<Procedure> g_ = this.Total_Hip_Arthroplasty_Procedure(context);

            bool? h_(Procedure THAProcedure) {
                object k_;
                DataType p_ = THAProcedure?.Performed;
                object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
                bool r_ = q_ is CqlDateTime;
                if (r_)
                {
                    DataType s_ = THAProcedure?.Performed;
                    object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                    k_ = t_ as CqlDateTime;
                }
                else
                {
                    DataType u_ = THAProcedure?.Performed;
                    object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                    bool w_ = v_ is CqlInterval<CqlDateTime>;
                    if (w_)
                    {
                        DataType x_ = THAProcedure?.Performed;
                        object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                        k_ = y_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType z_ = THAProcedure?.Performed;
                        object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                        bool ab_ = aa_ is CqlQuantity;
                        if (ab_)
                        {
                            DataType ac_ = THAProcedure?.Performed;
                            object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                            k_ = ad_ as CqlQuantity;
                        }
                        else
                        {
                            DataType ae_ = THAProcedure?.Performed;
                            object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                            bool ag_ = af_ is CqlInterval<CqlQuantity>;
                            if (ag_)
                            {
                                DataType ah_ = THAProcedure?.Performed;
                                object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                                k_ = ai_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                k_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> l_ = QICoreCommon_4_0_000.Instance.toInterval(context, k_);
                object m_;
                DataType aj_ = PartialTHAProcedure?.Performed;
                object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                bool al_ = ak_ is CqlDateTime;
                if (al_)
                {
                    DataType am_ = PartialTHAProcedure?.Performed;
                    object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                    m_ = an_ as CqlDateTime;
                }
                else
                {
                    DataType ao_ = PartialTHAProcedure?.Performed;
                    object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                    bool aq_ = ap_ is CqlInterval<CqlDateTime>;
                    if (aq_)
                    {
                        DataType ar_ = PartialTHAProcedure?.Performed;
                        object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                        m_ = as_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType at_ = PartialTHAProcedure?.Performed;
                        object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                        bool av_ = au_ is CqlQuantity;
                        if (av_)
                        {
                            DataType aw_ = PartialTHAProcedure?.Performed;
                            object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                            m_ = ax_ as CqlQuantity;
                        }
                        else
                        {
                            DataType ay_ = PartialTHAProcedure?.Performed;
                            object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                            bool ba_ = az_ is CqlInterval<CqlQuantity>;
                            if (ba_)
                            {
                                DataType bb_ = PartialTHAProcedure?.Performed;
                                object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                                m_ = bc_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                m_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> n_ = QICoreCommon_4_0_000.Instance.toInterval(context, m_);
                bool? o_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(l_, n_, "day");
                return o_;
            }

            IEnumerable<Procedure> i_ = context.Operators.Where<Procedure>(g_, h_);
            bool? j_ = context.Operators.Exists<Procedure>(i_);
            return j_;
        }

        IEnumerable<Procedure> e_ = context.Operators.Where<Procedure>(c_, d_);
        bool? f_ = context.Operators.Exists<Procedure>(e_);
        return f_;
    }


    [CqlExpressionDefinition("Has Revision Hip Arthroplasty Procedure or Implanted Device or Prosthesis Removal Procedure")]
    public bool? Has_Revision_Hip_Arthroplasty_Procedure_or_Implanted_Device_or_Prosthesis_Removal_Procedure(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Revision_Hip_Arthroplasty_Procedure_or_Implanted_Device_or_Prosthesis_Removal_Procedure, Has_Revision_Hip_Arthroplasty_Procedure_or_Implanted_Device_or_Prosthesis_Removal_Procedure_Compute);

    private const long _cacheIndex_Has_Revision_Hip_Arthroplasty_Procedure_or_Implanted_Device_or_Prosthesis_Removal_Procedure = 5889930654885795887L;

    private bool? Has_Revision_Hip_Arthroplasty_Procedure_or_Implanted_Device_or_Prosthesis_Removal_Procedure_Compute(CqlContext context)
    {
        IEnumerable<Procedure> a_ = this.Total_Hip_Arthroplasty_Procedure(context);

        bool? b_(Procedure THAProcedure) {
            CqlValueSet e_ = this.Removal__Revision_and_Supplement_Procedures_of_the_Lower_Body_and_Spine(context);
            IEnumerable<Procedure> f_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            IEnumerable<Procedure> g_ = Status_1_15_000.Instance.isProcedurePerformed(context, f_);

            bool? h_(Procedure RevisionTHAProcedure) {
                object k_;
                DataType p_ = THAProcedure?.Performed;
                object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
                bool r_ = q_ is CqlDateTime;
                if (r_)
                {
                    DataType s_ = THAProcedure?.Performed;
                    object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                    k_ = t_ as CqlDateTime;
                }
                else
                {
                    DataType u_ = THAProcedure?.Performed;
                    object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                    bool w_ = v_ is CqlInterval<CqlDateTime>;
                    if (w_)
                    {
                        DataType x_ = THAProcedure?.Performed;
                        object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                        k_ = y_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType z_ = THAProcedure?.Performed;
                        object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                        bool ab_ = aa_ is CqlQuantity;
                        if (ab_)
                        {
                            DataType ac_ = THAProcedure?.Performed;
                            object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                            k_ = ad_ as CqlQuantity;
                        }
                        else
                        {
                            DataType ae_ = THAProcedure?.Performed;
                            object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                            bool ag_ = af_ is CqlInterval<CqlQuantity>;
                            if (ag_)
                            {
                                DataType ah_ = THAProcedure?.Performed;
                                object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                                k_ = ai_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                k_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> l_ = QICoreCommon_4_0_000.Instance.toInterval(context, k_);
                object m_;
                DataType aj_ = RevisionTHAProcedure?.Performed;
                object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                bool al_ = ak_ is CqlDateTime;
                if (al_)
                {
                    DataType am_ = RevisionTHAProcedure?.Performed;
                    object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                    m_ = an_ as CqlDateTime;
                }
                else
                {
                    DataType ao_ = RevisionTHAProcedure?.Performed;
                    object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                    bool aq_ = ap_ is CqlInterval<CqlDateTime>;
                    if (aq_)
                    {
                        DataType ar_ = RevisionTHAProcedure?.Performed;
                        object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                        m_ = as_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType at_ = RevisionTHAProcedure?.Performed;
                        object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                        bool av_ = au_ is CqlQuantity;
                        if (av_)
                        {
                            DataType aw_ = RevisionTHAProcedure?.Performed;
                            object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                            m_ = ax_ as CqlQuantity;
                        }
                        else
                        {
                            DataType ay_ = RevisionTHAProcedure?.Performed;
                            object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                            bool ba_ = az_ is CqlInterval<CqlQuantity>;
                            if (ba_)
                            {
                                DataType bb_ = RevisionTHAProcedure?.Performed;
                                object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                                m_ = bc_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                m_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> n_ = QICoreCommon_4_0_000.Instance.toInterval(context, m_);
                bool? o_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(l_, n_, "day");
                return o_;
            }

            IEnumerable<Procedure> i_ = context.Operators.Where<Procedure>(g_, h_);
            bool? j_ = context.Operators.Exists<Procedure>(i_);
            return j_;
        }

        IEnumerable<Procedure> c_ = context.Operators.Where<Procedure>(a_, b_);
        bool? d_ = context.Operators.Exists<Procedure>(c_);
        return d_;
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
            IEnumerable<Procedure> h_ = this.Total_Hip_Arthroplasty_Procedure(context);

            bool? i_(Procedure THAProcedure) {
                CqlInterval<CqlDateTime> l_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, MalignantNeoplasm);
                object m_;
                DataType r_ = THAProcedure?.Performed;
                object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                bool t_ = s_ is CqlDateTime;
                if (t_)
                {
                    DataType u_ = THAProcedure?.Performed;
                    object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                    m_ = v_ as CqlDateTime;
                }
                else
                {
                    DataType w_ = THAProcedure?.Performed;
                    object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                    bool y_ = x_ is CqlInterval<CqlDateTime>;
                    if (y_)
                    {
                        DataType z_ = THAProcedure?.Performed;
                        object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                        m_ = aa_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType ab_ = THAProcedure?.Performed;
                        object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                        bool ad_ = ac_ is CqlQuantity;
                        if (ad_)
                        {
                            DataType ae_ = THAProcedure?.Performed;
                            object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                            m_ = af_ as CqlQuantity;
                        }
                        else
                        {
                            DataType ag_ = THAProcedure?.Performed;
                            object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                            bool ai_ = ah_ is CqlInterval<CqlQuantity>;
                            if (ai_)
                            {
                                DataType aj_ = THAProcedure?.Performed;
                                object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                                m_ = ak_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                m_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> n_ = QICoreCommon_4_0_000.Instance.toInterval(context, m_);
                bool? o_ = context.Operators.Overlaps(l_, n_, "day");
                bool? p_ = this.isVerified(context, MalignantNeoplasm);
                bool? q_ = context.Operators.And(o_, p_);
                return q_;
            }

            IEnumerable<Procedure> j_ = context.Operators.Where<Procedure>(h_, i_);
            bool? k_ = context.Operators.Exists<Procedure>(j_);
            return k_;
        }

        IEnumerable<Condition> f_ = context.Operators.Where<Condition>(d_, e_);
        bool? g_ = context.Operators.Exists<Condition>(f_);
        return g_;
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
            IEnumerable<Procedure> h_ = this.Total_Hip_Arthroplasty_Procedure(context);

            bool? i_(Procedure THAProcedure) {
                CqlInterval<CqlDateTime> l_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, MechanicalComplications);
                object m_;
                DataType r_ = THAProcedure?.Performed;
                object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                bool t_ = s_ is CqlDateTime;
                if (t_)
                {
                    DataType u_ = THAProcedure?.Performed;
                    object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                    m_ = v_ as CqlDateTime;
                }
                else
                {
                    DataType w_ = THAProcedure?.Performed;
                    object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                    bool y_ = x_ is CqlInterval<CqlDateTime>;
                    if (y_)
                    {
                        DataType z_ = THAProcedure?.Performed;
                        object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                        m_ = aa_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType ab_ = THAProcedure?.Performed;
                        object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                        bool ad_ = ac_ is CqlQuantity;
                        if (ad_)
                        {
                            DataType ae_ = THAProcedure?.Performed;
                            object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                            m_ = af_ as CqlQuantity;
                        }
                        else
                        {
                            DataType ag_ = THAProcedure?.Performed;
                            object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                            bool ai_ = ah_ is CqlInterval<CqlQuantity>;
                            if (ai_)
                            {
                                DataType aj_ = THAProcedure?.Performed;
                                object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                                m_ = ak_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                m_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> n_ = QICoreCommon_4_0_000.Instance.toInterval(context, m_);
                bool? o_ = context.Operators.Overlaps(l_, n_, "day");
                bool? p_ = this.isVerified(context, MechanicalComplications);
                bool? q_ = context.Operators.And(o_, p_);
                return q_;
            }

            IEnumerable<Procedure> j_ = context.Operators.Where<Procedure>(h_, i_);
            bool? k_ = context.Operators.Exists<Procedure>(j_);
            return k_;
        }

        IEnumerable<Condition> f_ = context.Operators.Where<Condition>(d_, e_);
        bool? g_ = context.Operators.Exists<Condition>(f_);
        return g_;
    }


    [CqlExpressionDefinition("Has More Than One Elective Primary Total Hip Arthroplasty Performed")]
    public bool? Has_More_Than_One_Elective_Primary_Total_Hip_Arthroplasty_Performed(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_More_Than_One_Elective_Primary_Total_Hip_Arthroplasty_Performed, Has_More_Than_One_Elective_Primary_Total_Hip_Arthroplasty_Performed_Compute);

    private const long _cacheIndex_Has_More_Than_One_Elective_Primary_Total_Hip_Arthroplasty_Performed = -923175309866963357L;

    private bool? Has_More_Than_One_Elective_Primary_Total_Hip_Arthroplasty_Performed_Compute(CqlContext context)
    {
        IEnumerable<Procedure> a_ = this.Total_Hip_Arthroplasty_Procedure(context);

        bool? b_(Procedure THAProcedure) {
            CqlValueSet e_ = this.Primary_THA_Procedure(context);
            IEnumerable<Procedure> f_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            IEnumerable<Procedure> g_ = Status_1_15_000.Instance.isProcedurePerformed(context, f_);

            bool? h_(Procedure ElectiveTHAProcedure) {
                Id k_ = THAProcedure?.IdElement;
                string l_ = k_?.Value;
                Id m_ = ElectiveTHAProcedure?.IdElement;
                string n_ = m_?.Value;
                bool? o_ = context.Operators.Equivalent(l_, n_);
                bool? p_ = context.Operators.Not(o_);
                object q_;
                DataType af_ = ElectiveTHAProcedure?.Performed;
                object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                bool ah_ = ag_ is CqlDateTime;
                if (ah_)
                {
                    DataType ai_ = ElectiveTHAProcedure?.Performed;
                    object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                    q_ = aj_ as CqlDateTime;
                }
                else
                {
                    DataType ak_ = ElectiveTHAProcedure?.Performed;
                    object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                    bool am_ = al_ is CqlInterval<CqlDateTime>;
                    if (am_)
                    {
                        DataType an_ = ElectiveTHAProcedure?.Performed;
                        object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                        q_ = ao_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType ap_ = ElectiveTHAProcedure?.Performed;
                        object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                        bool ar_ = aq_ is CqlQuantity;
                        if (ar_)
                        {
                            DataType as_ = ElectiveTHAProcedure?.Performed;
                            object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                            q_ = at_ as CqlQuantity;
                        }
                        else
                        {
                            DataType au_ = ElectiveTHAProcedure?.Performed;
                            object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                            bool aw_ = av_ is CqlInterval<CqlQuantity>;
                            if (aw_)
                            {
                                DataType ax_ = ElectiveTHAProcedure?.Performed;
                                object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                                q_ = ay_ as CqlInterval<CqlQuantity>;
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
                object t_;
                DataType az_ = THAProcedure?.Performed;
                object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                bool bb_ = ba_ is CqlDateTime;
                if (bb_)
                {
                    DataType bc_ = THAProcedure?.Performed;
                    object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                    t_ = bd_ as CqlDateTime;
                }
                else
                {
                    DataType be_ = THAProcedure?.Performed;
                    object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                    bool bg_ = bf_ is CqlInterval<CqlDateTime>;
                    if (bg_)
                    {
                        DataType bh_ = THAProcedure?.Performed;
                        object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                        t_ = bi_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType bj_ = THAProcedure?.Performed;
                        object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                        bool bl_ = bk_ is CqlQuantity;
                        if (bl_)
                        {
                            DataType bm_ = THAProcedure?.Performed;
                            object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                            t_ = bn_ as CqlQuantity;
                        }
                        else
                        {
                            DataType bo_ = THAProcedure?.Performed;
                            object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                            bool bq_ = bp_ is CqlInterval<CqlQuantity>;
                            if (bq_)
                            {
                                DataType br_ = THAProcedure?.Performed;
                                object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
                                t_ = bs_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                t_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> u_ = QICoreCommon_4_0_000.Instance.toInterval(context, t_);
                CqlDateTime v_ = context.Operators.Start(u_);
                CqlQuantity w_ = context.Operators.Quantity(1m, "year");
                CqlDateTime x_ = context.Operators.Subtract(v_, w_);
                object y_;
                DataType bt_ = THAProcedure?.Performed;
                object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                bool bv_ = bu_ is CqlDateTime;
                if (bv_)
                {
                    DataType bw_ = THAProcedure?.Performed;
                    object bx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bw_);
                    y_ = bx_ as CqlDateTime;
                }
                else
                {
                    DataType by_ = THAProcedure?.Performed;
                    object bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);
                    bool ca_ = bz_ is CqlInterval<CqlDateTime>;
                    if (ca_)
                    {
                        DataType cb_ = THAProcedure?.Performed;
                        object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                        y_ = cc_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType cd_ = THAProcedure?.Performed;
                        object ce_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cd_);
                        bool cf_ = ce_ is CqlQuantity;
                        if (cf_)
                        {
                            DataType cg_ = THAProcedure?.Performed;
                            object ch_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cg_);
                            y_ = ch_ as CqlQuantity;
                        }
                        else
                        {
                            DataType ci_ = THAProcedure?.Performed;
                            object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                            bool ck_ = cj_ is CqlInterval<CqlQuantity>;
                            if (ck_)
                            {
                                DataType cl_ = THAProcedure?.Performed;
                                object cm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cl_);
                                y_ = cm_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                y_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> z_ = QICoreCommon_4_0_000.Instance.toInterval(context, y_);
                CqlDateTime aa_ = context.Operators.Start(z_);
                CqlDateTime ab_ = context.Operators.Add(aa_, w_);
                CqlInterval<CqlDateTime> ac_ = context.Operators.Interval(x_, ab_, true, true);
                bool? ad_ = context.Operators.In<CqlDateTime>(s_, ac_, "day");
                bool? ae_ = context.Operators.And(p_, ad_);
                return ae_;
            }

            IEnumerable<Procedure> i_ = context.Operators.Where<Procedure>(g_, h_);
            bool? j_ = context.Operators.Exists<Procedure>(i_);
            return j_;
        }

        IEnumerable<Procedure> c_ = context.Operators.Where<Procedure>(a_, b_);
        bool? d_ = context.Operators.Exists<Procedure>(c_);
        return d_;
    }


    [CqlExpressionDefinition("Death Within 300 Days of the THA Procedure")]
    public bool? Death_Within_300_Days_of_the_THA_Procedure(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Death_Within_300_Days_of_the_THA_Procedure, Death_Within_300_Days_of_the_THA_Procedure_Compute);

    private const long _cacheIndex_Death_Within_300_Days_of_the_THA_Procedure = -1448111265350174851L;

    private bool? Death_Within_300_Days_of_the_THA_Procedure_Compute(CqlContext context)
    {
        IEnumerable<Procedure> a_ = this.Total_Hip_Arthroplasty_Procedure(context);

        bool? b_(Procedure THAProcedure) {
            Patient e_ = this.Patient(context);
            DataType f_ = e_?.Deceased;
            object g_ = FHIRHelpers_4_4_000.Instance.ToValue(context, f_);
            CqlDate h_ = context.Operators.DateFrom(g_ as CqlDateTime);
            object i_;
            DataType u_ = THAProcedure?.Performed;
            object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
            bool w_ = v_ is CqlDateTime;
            if (w_)
            {
                DataType x_ = THAProcedure?.Performed;
                object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                i_ = y_ as CqlDateTime;
            }
            else
            {
                DataType z_ = THAProcedure?.Performed;
                object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                bool ab_ = aa_ is CqlInterval<CqlDateTime>;
                if (ab_)
                {
                    DataType ac_ = THAProcedure?.Performed;
                    object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                    i_ = ad_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType ae_ = THAProcedure?.Performed;
                    object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                    bool ag_ = af_ is CqlQuantity;
                    if (ag_)
                    {
                        DataType ah_ = THAProcedure?.Performed;
                        object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                        i_ = ai_ as CqlQuantity;
                    }
                    else
                    {
                        DataType aj_ = THAProcedure?.Performed;
                        object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                        bool al_ = ak_ is CqlInterval<CqlQuantity>;
                        if (al_)
                        {
                            DataType am_ = THAProcedure?.Performed;
                            object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                            i_ = an_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            i_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> j_ = QICoreCommon_4_0_000.Instance.toInterval(context, i_);
            CqlDateTime k_ = context.Operators.Start(j_);
            CqlDate l_ = context.Operators.DateFrom(k_);
            object m_;
            DataType ao_ = THAProcedure?.Performed;
            object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
            bool aq_ = ap_ is CqlDateTime;
            if (aq_)
            {
                DataType ar_ = THAProcedure?.Performed;
                object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                m_ = as_ as CqlDateTime;
            }
            else
            {
                DataType at_ = THAProcedure?.Performed;
                object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                bool av_ = au_ is CqlInterval<CqlDateTime>;
                if (av_)
                {
                    DataType aw_ = THAProcedure?.Performed;
                    object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                    m_ = ax_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType ay_ = THAProcedure?.Performed;
                    object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                    bool ba_ = az_ is CqlQuantity;
                    if (ba_)
                    {
                        DataType bb_ = THAProcedure?.Performed;
                        object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                        m_ = bc_ as CqlQuantity;
                    }
                    else
                    {
                        DataType bd_ = THAProcedure?.Performed;
                        object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                        bool bf_ = be_ is CqlInterval<CqlQuantity>;
                        if (bf_)
                        {
                            DataType bg_ = THAProcedure?.Performed;
                            object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                            m_ = bh_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            m_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> n_ = QICoreCommon_4_0_000.Instance.toInterval(context, m_);
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
        context.GetOrCompute(_cacheIndex_Denominator_Exclusions, Denominator_Exclusions_Compute);

    private const long _cacheIndex_Denominator_Exclusions = -7348517150261171558L;

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
            DataType as_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSActivityScore?.Effective;
            object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
            CqlInterval<CqlDateTime> au_ = QICoreCommon_4_0_000.Instance.toInterval(context, at_);
            CqlDateTime av_ = context.Operators.Start(au_);
            CqlDate aw_ = context.Operators.DateFrom(av_);
            bool? ax_ = context.Operators.SameAs(ah_, aw_, "day");
            bool? ay_ = context.Operators.And(ar_, ax_);
            DataType az_ = (tuple_eipfmazvhfscjijaofhicpvmb?.HOOSActivityScore as Observation)?.Value;
            object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
            bool? bb_ = context.Operators.Not((bool?)(ba_ is null));
            bool? bc_ = context.Operators.And(ay_, bb_);
            DataType bd_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSSymptoms?.Effective;
            object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
            CqlInterval<CqlDateTime> bf_ = QICoreCommon_4_0_000.Instance.toInterval(context, be_);
            CqlDateTime bg_ = context.Operators.Start(bf_);
            CqlDate bh_ = context.Operators.DateFrom(bg_);
            bool? bi_ = context.Operators.SameAs(ah_, bh_, "day");
            bool? bj_ = context.Operators.And(bc_, bi_);
            DataType bk_ = (tuple_eipfmazvhfscjijaofhicpvmb?.HOOSSymptoms as Observation)?.Value;
            object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
            bool? bm_ = context.Operators.Not((bool?)(bl_ is null));
            bool? bn_ = context.Operators.And(bj_, bm_);
            DataType bo_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSPain?.Effective;
            object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
            CqlInterval<CqlDateTime> bq_ = QICoreCommon_4_0_000.Instance.toInterval(context, bp_);
            CqlDateTime br_ = context.Operators.Start(bq_);
            CqlDate bs_ = context.Operators.DateFrom(br_);
            bool? bt_ = context.Operators.SameAs(ah_, bs_, "day");
            bool? bu_ = context.Operators.And(bn_, bt_);
            DataType bv_ = (tuple_eipfmazvhfscjijaofhicpvmb?.HOOSPain as Observation)?.Value;
            object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
            bool? bx_ = context.Operators.Not((bool?)(bw_ is null));
            bool? by_ = context.Operators.And(bu_, bx_);
            DataType bz_ = (tuple_eipfmazvhfscjijaofhicpvmb?.HOOSLifeQuality as Observation)?.Value;
            object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
            bool? cb_ = context.Operators.Not((bool?)(ca_ is null));
            bool? cc_ = context.Operators.And(by_, cb_);
            return cc_;
        }

        IEnumerable<(CqlTupleMetadata, Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)?> y_ = context.Operators.Where<(CqlTupleMetadata, Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)?>(w_, x_);

        CqlDate z_((CqlTupleMetadata, Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)? tuple_eipfmazvhfscjijaofhicpvmb) {
            DataType cd_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSLifeQuality?.Effective;
            object ce_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cd_);
            CqlInterval<CqlDateTime> cf_ = QICoreCommon_4_0_000.Instance.toInterval(context, ce_);
            CqlDateTime cg_ = context.Operators.Start(cf_);
            CqlDate ch_ = context.Operators.DateFrom(cg_);
            DataType ci_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSSport?.Effective;
            object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
            CqlInterval<CqlDateTime> ck_ = QICoreCommon_4_0_000.Instance.toInterval(context, cj_);
            CqlDateTime cl_ = context.Operators.Start(ck_);
            CqlDate cm_ = context.Operators.DateFrom(cl_);
            DataType cn_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSActivityScore?.Effective;
            object co_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cn_);
            CqlInterval<CqlDateTime> cp_ = QICoreCommon_4_0_000.Instance.toInterval(context, co_);
            CqlDateTime cq_ = context.Operators.Start(cp_);
            CqlDate cr_ = context.Operators.DateFrom(cq_);
            DataType cs_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSSymptoms?.Effective;
            object ct_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cs_);
            CqlInterval<CqlDateTime> cu_ = QICoreCommon_4_0_000.Instance.toInterval(context, ct_);
            CqlDateTime cv_ = context.Operators.Start(cu_);
            CqlDate cw_ = context.Operators.DateFrom(cv_);
            DataType cx_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSPain?.Effective;
            object cy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
            CqlInterval<CqlDateTime> cz_ = QICoreCommon_4_0_000.Instance.toInterval(context, cy_);
            CqlDateTime da_ = context.Operators.Start(cz_);
            CqlDate db_ = context.Operators.DateFrom(da_);
            CqlDate[] dc_ = [
                ch_,
                cm_,
                cr_,
                cw_,
                db_,
            ];
            CqlDate dd_ = context.Operators.Max<CqlDate>((IEnumerable<CqlDate>)dc_);
            return dd_;
        }

        IEnumerable<CqlDate> aa_ = context.Operators.Select<(CqlTupleMetadata, Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)?, CqlDate>(y_, z_);
        IEnumerable<CqlDate> ab_ = context.Operators.Distinct<CqlDate>(aa_);
        return ab_;
    }


    [CqlExpressionDefinition("Has THA with Initial and Follow Up HOOS Assessments")]
    public bool? Has_THA_with_Initial_and_Follow_Up_HOOS_Assessments(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_THA_with_Initial_and_Follow_Up_HOOS_Assessments, Has_THA_with_Initial_and_Follow_Up_HOOS_Assessments_Compute);

    private const long _cacheIndex_Has_THA_with_Initial_and_Follow_Up_HOOS_Assessments = -3170780632634006629L;

    private bool? Has_THA_with_Initial_and_Follow_Up_HOOS_Assessments_Compute(CqlContext context)
    {
        IEnumerable<Procedure> a_ = this.Total_Hip_Arthroplasty_Procedure(context);

        CqlInterval<CqlDateTime> b_(Procedure THAProcedure) {
            object j_;
            DataType l_ = THAProcedure?.Performed;
            object m_ = FHIRHelpers_4_4_000.Instance.ToValue(context, l_);
            bool n_ = m_ is CqlDateTime;
            if (n_)
            {
                DataType o_ = THAProcedure?.Performed;
                object p_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
                j_ = p_ as CqlDateTime;
            }
            else
            {
                DataType q_ = THAProcedure?.Performed;
                object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                bool s_ = r_ is CqlInterval<CqlDateTime>;
                if (s_)
                {
                    DataType t_ = THAProcedure?.Performed;
                    object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                    j_ = u_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType v_ = THAProcedure?.Performed;
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    bool x_ = w_ is CqlQuantity;
                    if (x_)
                    {
                        DataType y_ = THAProcedure?.Performed;
                        object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                        j_ = z_ as CqlQuantity;
                    }
                    else
                    {
                        DataType aa_ = THAProcedure?.Performed;
                        object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                        bool ac_ = ab_ is CqlInterval<CqlQuantity>;
                        if (ac_)
                        {
                            DataType ad_ = THAProcedure?.Performed;
                            object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                            j_ = ae_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            j_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> k_ = QICoreCommon_4_0_000.Instance.toInterval(context, j_);
            return k_;
        }

        IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.Select<Procedure, CqlInterval<CqlDateTime>>(a_, b_);
        IEnumerable<CqlInterval<CqlDateTime>> d_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(c_);

        bool? e_(CqlInterval<CqlDateTime> TotalHip) {
            IEnumerable<CqlDate> af_ = this.Date_HOOS_Total_Assessment_Completed(context);

            bool? ag_(CqlDate InitialHipAssessmentHOOS) {
                CqlDateTime aj_ = context.Operators.Start(TotalHip);
                CqlQuantity ak_ = context.Operators.Quantity(90m, "days");
                CqlDate al_ = context.Operators.Add(InitialHipAssessmentHOOS, ak_);
                CqlInterval<CqlDate> am_ = context.Operators.Interval(InitialHipAssessmentHOOS, al_, true, true);
                CqlDate an_ = am_?.low;
                CqlDateTime ao_ = context.Operators.ConvertDateToDateTime(an_);
                CqlDate ap_ = am_?.high;
                CqlDateTime aq_ = context.Operators.ConvertDateToDateTime(ap_);
                bool? ar_ = am_?.lowClosed;
                bool? as_ = am_?.highClosed;
                CqlInterval<CqlDateTime> at_ = context.Operators.Interval(ao_, aq_, ar_, as_);
                bool? au_ = context.Operators.In<CqlDateTime>(aj_, at_, "day");
                bool? av_ = context.Operators.Not((bool?)(InitialHipAssessmentHOOS is null));
                bool? aw_ = context.Operators.And(au_, av_);
                return aw_;
            }

            IEnumerable<CqlDate> ah_ = context.Operators.Where<CqlDate>(af_, ag_);
            bool? ai_ = context.Operators.Exists<CqlDate>(ah_);
            return ai_;
        }

        IEnumerable<CqlInterval<CqlDateTime>> f_ = context.Operators.Where<CqlInterval<CqlDateTime>>(d_, e_);

        bool? g_(CqlInterval<CqlDateTime> TotalHip) {
            IEnumerable<CqlDate> ax_ = this.Date_HOOS_Total_Assessment_Completed(context);

            bool? ay_(CqlDate FollowUpHipAssessmentHOOS) {
                CqlDateTime bb_ = context.Operators.ConvertDateToDateTime(FollowUpHipAssessmentHOOS);
                CqlDate bc_ = context.Operators.DateFrom(bb_);
                CqlDateTime bd_ = context.Operators.End(TotalHip);
                CqlDate be_ = context.Operators.DateFrom(bd_);
                CqlQuantity bf_ = context.Operators.Quantity(300m, "days");
                CqlDate bg_ = context.Operators.Add(be_, bf_);
                CqlQuantity bh_ = context.Operators.Quantity(425m, "days");
                CqlDate bi_ = context.Operators.Add(be_, bh_);
                CqlInterval<CqlDate> bj_ = context.Operators.Interval(bg_, bi_, true, true);
                bool? bk_ = context.Operators.In<CqlDate>(bc_, bj_, "day");
                return bk_;
            }

            IEnumerable<CqlDate> az_ = context.Operators.Where<CqlDate>(ax_, ay_);
            bool? ba_ = context.Operators.Exists<CqlDate>(az_);
            return ba_;
        }

        IEnumerable<CqlInterval<CqlDateTime>> h_ = context.Operators.Where<CqlInterval<CqlDateTime>>(f_, g_);
        bool? i_ = context.Operators.Exists<CqlInterval<CqlDateTime>>(h_);
        return i_;
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
        context.GetOrCompute(_cacheIndex_Has_THA_with_Initial_and_Follow_Up_HOOSJr_Assessments, Has_THA_with_Initial_and_Follow_Up_HOOSJr_Assessments_Compute);

    private const long _cacheIndex_Has_THA_with_Initial_and_Follow_Up_HOOSJr_Assessments = -3393965754895205370L;

    private bool? Has_THA_with_Initial_and_Follow_Up_HOOSJr_Assessments_Compute(CqlContext context)
    {
        IEnumerable<Procedure> a_ = this.Total_Hip_Arthroplasty_Procedure(context);

        CqlInterval<CqlDateTime> b_(Procedure THAProcedure) {
            object j_;
            DataType l_ = THAProcedure?.Performed;
            object m_ = FHIRHelpers_4_4_000.Instance.ToValue(context, l_);
            bool n_ = m_ is CqlDateTime;
            if (n_)
            {
                DataType o_ = THAProcedure?.Performed;
                object p_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
                j_ = p_ as CqlDateTime;
            }
            else
            {
                DataType q_ = THAProcedure?.Performed;
                object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                bool s_ = r_ is CqlInterval<CqlDateTime>;
                if (s_)
                {
                    DataType t_ = THAProcedure?.Performed;
                    object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                    j_ = u_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType v_ = THAProcedure?.Performed;
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    bool x_ = w_ is CqlQuantity;
                    if (x_)
                    {
                        DataType y_ = THAProcedure?.Performed;
                        object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                        j_ = z_ as CqlQuantity;
                    }
                    else
                    {
                        DataType aa_ = THAProcedure?.Performed;
                        object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                        bool ac_ = ab_ is CqlInterval<CqlQuantity>;
                        if (ac_)
                        {
                            DataType ad_ = THAProcedure?.Performed;
                            object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                            j_ = ae_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            j_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> k_ = QICoreCommon_4_0_000.Instance.toInterval(context, j_);
            return k_;
        }

        IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.Select<Procedure, CqlInterval<CqlDateTime>>(a_, b_);
        IEnumerable<CqlInterval<CqlDateTime>> d_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(c_);

        bool? e_(CqlInterval<CqlDateTime> TotalHip) {
            IEnumerable<CqlDate> af_ = this.Date_HOOSJr_Total_Assessment_Completed(context);

            bool? ag_(CqlDate InitialHipAssessment) {
                CqlDateTime aj_ = context.Operators.Start(TotalHip);
                CqlQuantity ak_ = context.Operators.Quantity(90m, "days");
                CqlDate al_ = context.Operators.Add(InitialHipAssessment, ak_);
                CqlInterval<CqlDate> am_ = context.Operators.Interval(InitialHipAssessment, al_, true, true);
                CqlDate an_ = am_?.low;
                CqlDateTime ao_ = context.Operators.ConvertDateToDateTime(an_);
                CqlDate ap_ = am_?.high;
                CqlDateTime aq_ = context.Operators.ConvertDateToDateTime(ap_);
                bool? ar_ = am_?.lowClosed;
                bool? as_ = am_?.highClosed;
                CqlInterval<CqlDateTime> at_ = context.Operators.Interval(ao_, aq_, ar_, as_);
                bool? au_ = context.Operators.In<CqlDateTime>(aj_, at_, "day");
                bool? av_ = context.Operators.Not((bool?)(InitialHipAssessment is null));
                bool? aw_ = context.Operators.And(au_, av_);
                return aw_;
            }

            IEnumerable<CqlDate> ah_ = context.Operators.Where<CqlDate>(af_, ag_);
            bool? ai_ = context.Operators.Exists<CqlDate>(ah_);
            return ai_;
        }

        IEnumerable<CqlInterval<CqlDateTime>> f_ = context.Operators.Where<CqlInterval<CqlDateTime>>(d_, e_);

        bool? g_(CqlInterval<CqlDateTime> TotalHip) {
            IEnumerable<CqlDate> ax_ = this.Date_HOOSJr_Total_Assessment_Completed(context);

            bool? ay_(CqlDate FollowUpHipAssessment) {
                CqlDateTime bb_ = context.Operators.ConvertDateToDateTime(FollowUpHipAssessment);
                CqlDate bc_ = context.Operators.DateFrom(bb_);
                CqlDateTime bd_ = context.Operators.End(TotalHip);
                CqlDate be_ = context.Operators.DateFrom(bd_);
                CqlQuantity bf_ = context.Operators.Quantity(300m, "days");
                CqlDate bg_ = context.Operators.Add(be_, bf_);
                CqlQuantity bh_ = context.Operators.Quantity(425m, "days");
                CqlDate bi_ = context.Operators.Add(be_, bh_);
                CqlInterval<CqlDate> bj_ = context.Operators.Interval(bg_, bi_, true, true);
                bool? bk_ = context.Operators.In<CqlDate>(bc_, bj_, "day");
                return bk_;
            }

            IEnumerable<CqlDate> az_ = context.Operators.Where<CqlDate>(ax_, ay_);
            bool? ba_ = context.Operators.Exists<CqlDate>(az_);
            return ba_;
        }

        IEnumerable<CqlInterval<CqlDateTime>> h_ = context.Operators.Where<CqlInterval<CqlDateTime>>(f_, g_);
        bool? i_ = context.Operators.Exists<CqlInterval<CqlDateTime>>(h_);
        return i_;
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
        context.GetOrCompute(_cacheIndex_Has_THA_with_Initial_and_Follow_Up_PROMIS10_Assessments, Has_THA_with_Initial_and_Follow_Up_PROMIS10_Assessments_Compute);

    private const long _cacheIndex_Has_THA_with_Initial_and_Follow_Up_PROMIS10_Assessments = -4717330265822200184L;

    private bool? Has_THA_with_Initial_and_Follow_Up_PROMIS10_Assessments_Compute(CqlContext context)
    {
        IEnumerable<Procedure> a_ = this.Total_Hip_Arthroplasty_Procedure(context);

        CqlInterval<CqlDateTime> b_(Procedure THAProcedure) {
            object j_;
            DataType l_ = THAProcedure?.Performed;
            object m_ = FHIRHelpers_4_4_000.Instance.ToValue(context, l_);
            bool n_ = m_ is CqlDateTime;
            if (n_)
            {
                DataType o_ = THAProcedure?.Performed;
                object p_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
                j_ = p_ as CqlDateTime;
            }
            else
            {
                DataType q_ = THAProcedure?.Performed;
                object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                bool s_ = r_ is CqlInterval<CqlDateTime>;
                if (s_)
                {
                    DataType t_ = THAProcedure?.Performed;
                    object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                    j_ = u_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType v_ = THAProcedure?.Performed;
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    bool x_ = w_ is CqlQuantity;
                    if (x_)
                    {
                        DataType y_ = THAProcedure?.Performed;
                        object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                        j_ = z_ as CqlQuantity;
                    }
                    else
                    {
                        DataType aa_ = THAProcedure?.Performed;
                        object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                        bool ac_ = ab_ is CqlInterval<CqlQuantity>;
                        if (ac_)
                        {
                            DataType ad_ = THAProcedure?.Performed;
                            object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                            j_ = ae_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            j_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> k_ = QICoreCommon_4_0_000.Instance.toInterval(context, j_);
            return k_;
        }

        IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.Select<Procedure, CqlInterval<CqlDateTime>>(a_, b_);
        IEnumerable<CqlInterval<CqlDateTime>> d_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(c_);

        bool? e_(CqlInterval<CqlDateTime> TotalHip) {
            IEnumerable<CqlDate> af_ = this.Date_PROMIS10_Total_Assessment_Completed(context);

            bool? ag_(CqlDate InitialHipAssessmentPROMIS10) {
                CqlDateTime aj_ = context.Operators.Start(TotalHip);
                CqlQuantity ak_ = context.Operators.Quantity(90m, "days");
                CqlDate al_ = context.Operators.Add(InitialHipAssessmentPROMIS10, ak_);
                CqlInterval<CqlDate> am_ = context.Operators.Interval(InitialHipAssessmentPROMIS10, al_, true, true);
                CqlDate an_ = am_?.low;
                CqlDateTime ao_ = context.Operators.ConvertDateToDateTime(an_);
                CqlDate ap_ = am_?.high;
                CqlDateTime aq_ = context.Operators.ConvertDateToDateTime(ap_);
                bool? ar_ = am_?.lowClosed;
                bool? as_ = am_?.highClosed;
                CqlInterval<CqlDateTime> at_ = context.Operators.Interval(ao_, aq_, ar_, as_);
                bool? au_ = context.Operators.In<CqlDateTime>(aj_, at_, "day");
                bool? av_ = context.Operators.Not((bool?)(InitialHipAssessmentPROMIS10 is null));
                bool? aw_ = context.Operators.And(au_, av_);
                return aw_;
            }

            IEnumerable<CqlDate> ah_ = context.Operators.Where<CqlDate>(af_, ag_);
            bool? ai_ = context.Operators.Exists<CqlDate>(ah_);
            return ai_;
        }

        IEnumerable<CqlInterval<CqlDateTime>> f_ = context.Operators.Where<CqlInterval<CqlDateTime>>(d_, e_);

        bool? g_(CqlInterval<CqlDateTime> TotalHip) {
            IEnumerable<CqlDate> ax_ = this.Date_PROMIS10_Total_Assessment_Completed(context);

            bool? ay_(CqlDate FollowUpHipAssessmentPROMIS10) {
                CqlDateTime bb_ = context.Operators.ConvertDateToDateTime(FollowUpHipAssessmentPROMIS10);
                CqlDate bc_ = context.Operators.DateFrom(bb_);
                CqlDateTime bd_ = context.Operators.End(TotalHip);
                CqlDate be_ = context.Operators.DateFrom(bd_);
                CqlQuantity bf_ = context.Operators.Quantity(300m, "days");
                CqlDate bg_ = context.Operators.Add(be_, bf_);
                CqlQuantity bh_ = context.Operators.Quantity(425m, "days");
                CqlDate bi_ = context.Operators.Add(be_, bh_);
                CqlInterval<CqlDate> bj_ = context.Operators.Interval(bg_, bi_, true, true);
                bool? bk_ = context.Operators.In<CqlDate>(bc_, bj_, "day");
                return bk_;
            }

            IEnumerable<CqlDate> az_ = context.Operators.Where<CqlDate>(ax_, ay_);
            bool? ba_ = context.Operators.Exists<CqlDate>(az_);
            return ba_;
        }

        IEnumerable<CqlInterval<CqlDateTime>> h_ = context.Operators.Where<CqlInterval<CqlDateTime>>(f_, g_);
        bool? i_ = context.Operators.Exists<CqlInterval<CqlDateTime>>(h_);
        return i_;
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
        context.GetOrCompute(_cacheIndex_Has_THA_with_Initial_and_Follow_Up_VR12_Oblique_Assessments, Has_THA_with_Initial_and_Follow_Up_VR12_Oblique_Assessments_Compute);

    private const long _cacheIndex_Has_THA_with_Initial_and_Follow_Up_VR12_Oblique_Assessments = -8857932199387856860L;

    private bool? Has_THA_with_Initial_and_Follow_Up_VR12_Oblique_Assessments_Compute(CqlContext context)
    {
        IEnumerable<Procedure> a_ = this.Total_Hip_Arthroplasty_Procedure(context);

        CqlInterval<CqlDateTime> b_(Procedure THAProcedure) {
            object j_;
            DataType l_ = THAProcedure?.Performed;
            object m_ = FHIRHelpers_4_4_000.Instance.ToValue(context, l_);
            bool n_ = m_ is CqlDateTime;
            if (n_)
            {
                DataType o_ = THAProcedure?.Performed;
                object p_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
                j_ = p_ as CqlDateTime;
            }
            else
            {
                DataType q_ = THAProcedure?.Performed;
                object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                bool s_ = r_ is CqlInterval<CqlDateTime>;
                if (s_)
                {
                    DataType t_ = THAProcedure?.Performed;
                    object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                    j_ = u_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType v_ = THAProcedure?.Performed;
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    bool x_ = w_ is CqlQuantity;
                    if (x_)
                    {
                        DataType y_ = THAProcedure?.Performed;
                        object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                        j_ = z_ as CqlQuantity;
                    }
                    else
                    {
                        DataType aa_ = THAProcedure?.Performed;
                        object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                        bool ac_ = ab_ is CqlInterval<CqlQuantity>;
                        if (ac_)
                        {
                            DataType ad_ = THAProcedure?.Performed;
                            object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                            j_ = ae_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            j_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> k_ = QICoreCommon_4_0_000.Instance.toInterval(context, j_);
            return k_;
        }

        IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.Select<Procedure, CqlInterval<CqlDateTime>>(a_, b_);
        IEnumerable<CqlInterval<CqlDateTime>> d_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(c_);

        bool? e_(CqlInterval<CqlDateTime> TotalHip) {
            IEnumerable<CqlDate> af_ = this.Date_VR12_Oblique_Total_Assessment_Completed(context);

            bool? ag_(CqlDate InitialHipAssessmentOblique) {
                CqlDateTime aj_ = context.Operators.Start(TotalHip);
                CqlQuantity ak_ = context.Operators.Quantity(90m, "days");
                CqlDate al_ = context.Operators.Add(InitialHipAssessmentOblique, ak_);
                CqlInterval<CqlDate> am_ = context.Operators.Interval(InitialHipAssessmentOblique, al_, true, true);
                CqlDate an_ = am_?.low;
                CqlDateTime ao_ = context.Operators.ConvertDateToDateTime(an_);
                CqlDate ap_ = am_?.high;
                CqlDateTime aq_ = context.Operators.ConvertDateToDateTime(ap_);
                bool? ar_ = am_?.lowClosed;
                bool? as_ = am_?.highClosed;
                CqlInterval<CqlDateTime> at_ = context.Operators.Interval(ao_, aq_, ar_, as_);
                bool? au_ = context.Operators.In<CqlDateTime>(aj_, at_, "day");
                bool? av_ = context.Operators.Not((bool?)(InitialHipAssessmentOblique is null));
                bool? aw_ = context.Operators.And(au_, av_);
                return aw_;
            }

            IEnumerable<CqlDate> ah_ = context.Operators.Where<CqlDate>(af_, ag_);
            bool? ai_ = context.Operators.Exists<CqlDate>(ah_);
            return ai_;
        }

        IEnumerable<CqlInterval<CqlDateTime>> f_ = context.Operators.Where<CqlInterval<CqlDateTime>>(d_, e_);

        bool? g_(CqlInterval<CqlDateTime> TotalHip) {
            IEnumerable<CqlDate> ax_ = this.Date_VR12_Oblique_Total_Assessment_Completed(context);

            bool? ay_(CqlDate FollowUpHipAssessmentOblique) {
                CqlDateTime bb_ = context.Operators.ConvertDateToDateTime(FollowUpHipAssessmentOblique);
                CqlDate bc_ = context.Operators.DateFrom(bb_);
                CqlDateTime bd_ = context.Operators.End(TotalHip);
                CqlDate be_ = context.Operators.DateFrom(bd_);
                CqlQuantity bf_ = context.Operators.Quantity(300m, "days");
                CqlDate bg_ = context.Operators.Add(be_, bf_);
                CqlQuantity bh_ = context.Operators.Quantity(425m, "days");
                CqlDate bi_ = context.Operators.Add(be_, bh_);
                CqlInterval<CqlDate> bj_ = context.Operators.Interval(bg_, bi_, true, true);
                bool? bk_ = context.Operators.In<CqlDate>(bc_, bj_, "day");
                return bk_;
            }

            IEnumerable<CqlDate> az_ = context.Operators.Where<CqlDate>(ax_, ay_);
            bool? ba_ = context.Operators.Exists<CqlDate>(az_);
            return ba_;
        }

        IEnumerable<CqlInterval<CqlDateTime>> h_ = context.Operators.Where<CqlInterval<CqlDateTime>>(f_, g_);
        bool? i_ = context.Operators.Exists<CqlInterval<CqlDateTime>>(h_);
        return i_;
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
        context.GetOrCompute(_cacheIndex_Has_THA_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments, Has_THA_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments_Compute);

    private const long _cacheIndex_Has_THA_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments = -9051604538390399750L;

    private bool? Has_THA_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments_Compute(CqlContext context)
    {
        IEnumerable<Procedure> a_ = this.Total_Hip_Arthroplasty_Procedure(context);

        CqlInterval<CqlDateTime> b_(Procedure THAProcedure) {
            object j_;
            DataType l_ = THAProcedure?.Performed;
            object m_ = FHIRHelpers_4_4_000.Instance.ToValue(context, l_);
            bool n_ = m_ is CqlDateTime;
            if (n_)
            {
                DataType o_ = THAProcedure?.Performed;
                object p_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
                j_ = p_ as CqlDateTime;
            }
            else
            {
                DataType q_ = THAProcedure?.Performed;
                object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                bool s_ = r_ is CqlInterval<CqlDateTime>;
                if (s_)
                {
                    DataType t_ = THAProcedure?.Performed;
                    object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                    j_ = u_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType v_ = THAProcedure?.Performed;
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    bool x_ = w_ is CqlQuantity;
                    if (x_)
                    {
                        DataType y_ = THAProcedure?.Performed;
                        object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                        j_ = z_ as CqlQuantity;
                    }
                    else
                    {
                        DataType aa_ = THAProcedure?.Performed;
                        object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                        bool ac_ = ab_ is CqlInterval<CqlQuantity>;
                        if (ac_)
                        {
                            DataType ad_ = THAProcedure?.Performed;
                            object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                            j_ = ae_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            j_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> k_ = QICoreCommon_4_0_000.Instance.toInterval(context, j_);
            return k_;
        }

        IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.Select<Procedure, CqlInterval<CqlDateTime>>(a_, b_);
        IEnumerable<CqlInterval<CqlDateTime>> d_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(c_);

        bool? e_(CqlInterval<CqlDateTime> TotalHip) {
            IEnumerable<CqlDate> af_ = this.Date_VR12_Orthogonal_Total_Assessment_Completed(context);

            bool? ag_(CqlDate InitialHipAssessmentOrthogonal) {
                CqlDateTime aj_ = context.Operators.Start(TotalHip);
                CqlQuantity ak_ = context.Operators.Quantity(90m, "days");
                CqlDate al_ = context.Operators.Add(InitialHipAssessmentOrthogonal, ak_);
                CqlInterval<CqlDate> am_ = context.Operators.Interval(InitialHipAssessmentOrthogonal, al_, true, true);
                CqlDate an_ = am_?.low;
                CqlDateTime ao_ = context.Operators.ConvertDateToDateTime(an_);
                CqlDate ap_ = am_?.high;
                CqlDateTime aq_ = context.Operators.ConvertDateToDateTime(ap_);
                bool? ar_ = am_?.lowClosed;
                bool? as_ = am_?.highClosed;
                CqlInterval<CqlDateTime> at_ = context.Operators.Interval(ao_, aq_, ar_, as_);
                bool? au_ = context.Operators.In<CqlDateTime>(aj_, at_, "day");
                bool? av_ = context.Operators.Not((bool?)(InitialHipAssessmentOrthogonal is null));
                bool? aw_ = context.Operators.And(au_, av_);
                return aw_;
            }

            IEnumerable<CqlDate> ah_ = context.Operators.Where<CqlDate>(af_, ag_);
            bool? ai_ = context.Operators.Exists<CqlDate>(ah_);
            return ai_;
        }

        IEnumerable<CqlInterval<CqlDateTime>> f_ = context.Operators.Where<CqlInterval<CqlDateTime>>(d_, e_);

        bool? g_(CqlInterval<CqlDateTime> TotalHip) {
            IEnumerable<CqlDate> ax_ = this.Date_VR12_Orthogonal_Total_Assessment_Completed(context);

            bool? ay_(CqlDate FollowUpHipAssessmentOrthogonal) {
                CqlDateTime bb_ = context.Operators.ConvertDateToDateTime(FollowUpHipAssessmentOrthogonal);
                CqlDate bc_ = context.Operators.DateFrom(bb_);
                CqlDateTime bd_ = context.Operators.End(TotalHip);
                CqlDate be_ = context.Operators.DateFrom(bd_);
                CqlQuantity bf_ = context.Operators.Quantity(300m, "days");
                CqlDate bg_ = context.Operators.Add(be_, bf_);
                CqlQuantity bh_ = context.Operators.Quantity(425m, "days");
                CqlDate bi_ = context.Operators.Add(be_, bh_);
                CqlInterval<CqlDate> bj_ = context.Operators.Interval(bg_, bi_, true, true);
                bool? bk_ = context.Operators.In<CqlDate>(bc_, bj_, "day");
                return bk_;
            }

            IEnumerable<CqlDate> az_ = context.Operators.Where<CqlDate>(ax_, ay_);
            bool? ba_ = context.Operators.Exists<CqlDate>(az_);
            return ba_;
        }

        IEnumerable<CqlInterval<CqlDateTime>> h_ = context.Operators.Where<CqlInterval<CqlDateTime>>(f_, g_);
        bool? i_ = context.Operators.Exists<CqlInterval<CqlDateTime>>(h_);
        return i_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = 2421359684672176818L;

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
