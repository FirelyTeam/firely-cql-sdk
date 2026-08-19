#nullable enable annotations

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
    public CqlInterval<CqlDateTime?>? Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = -4989734324354607034L;

    private CqlInterval<CqlDateTime?>? Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime? a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime? b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime?>? c_ = context.Operators.Interval(a_, b_, true, false);
        object? d_ = context.ResolveParameter("CMS56FHIRFuncStatHipReplacement-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime?>?)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (33)

    [CqlExpressionDefinition("Patient")]
    public Patient? Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = 3751859452182210846L;

    private Patient? Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient?>? a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient? b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = 8062698479944212271L;

    private (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept? code, CqlInterval<CqlDateTime?>? period)?>? SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = -214646562098729455L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept? code, CqlInterval<CqlDateTime?>? period)?>? SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept? code, CqlInterval<CqlDateTime?>? period)?>? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = -9082188876428973750L;

    private (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode? SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = 3982610526901767990L;

    private CqlCode? SDE_Sex_Compute(CqlContext context)
    {
        CqlCode? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    [CqlExpressionDefinition("August 1 Year Prior to the Measurement Period")]
    public CqlDateTime? August_1_Year_Prior_to_the_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_August_1_Year_Prior_to_the_Measurement_Period, August_1_Year_Prior_to_the_Measurement_Period_Compute);

    private const long _cacheIndex_August_1_Year_Prior_to_the_Measurement_Period = 4699660934411692274L;

    private CqlDateTime? August_1_Year_Prior_to_the_Measurement_Period_Compute(CqlContext context)
    {
        CqlInterval<CqlDateTime?>? a_ = this.Measurement_Period(context);
        CqlDateTime? b_ = context.Operators.Start(a_);
        int? c_ = context.Operators.DateTimeComponentFrom(b_, "year");
        int? d_ = context.Operators.Subtract(c_, 1);
        decimal? e_ = context.Operators.ConvertIntegerToDecimal(0);
        CqlDateTime? f_ = context.Operators.DateTime(d_, 8, 1, 0, 0, 0, 0, e_);
        return f_;
    }


    [CqlExpressionDefinition("Has Qualifying Encounter")]
    public bool? Has_Qualifying_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Qualifying_Encounter, Has_Qualifying_Encounter_Compute);

    private const long _cacheIndex_Has_Qualifying_Encounter = 5978222765231191090L;

    private bool? Has_Qualifying_Encounter_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter?>? b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet? c_ = this.Office_Visit(context);
        IEnumerable<Encounter?>? d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter?>? e_ = context.Operators.Union<Encounter>(b_, d_);
        IEnumerable<Encounter?>? f_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

        bool? g_(Encounter? E) {
            List<CodeableConcept?>? s_ = E?.Type;

            CqlConcept? t_(CodeableConcept? @this) {
                CqlConcept? x_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return x_;
            }


            bool? u_(CqlConcept? T) {
                CqlCode? y_ = this.Postoperative_follow_up_visit__normally_included_in_the_surgical_package__to_indicate_that_an_evaluation_and_management_service_was_performed_during_a_postoperative_period_for_a_reason_s__related_to_the_original_procedure(context);
                CqlConcept? z_ = context.Operators.ConvertCodeToConcept(y_);
                bool? aa_ = context.Operators.Equivalent(T, z_);
                return aa_;
            }

            IEnumerable<CqlConcept?>? v_ = context.Operators.SelectWhere<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept?>?)s_, t_, u_);
            bool? w_ = context.Operators.Exists<CqlConcept>(v_);
            return w_;
        }

        IEnumerable<Encounter?>? h_ = context.Operators.Where<Encounter>(f_, g_);
        CqlValueSet? i_ = this.Telephone_Visits(context);
        IEnumerable<Encounter?>? j_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter?>? k_ = context.Operators.Union<Encounter>(h_, j_);
        IEnumerable<Encounter?>? l_ = context.Operators.Union<Encounter>(e_, k_);
        CqlValueSet? m_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter?>? n_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, m_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter?>? o_ = context.Operators.Union<Encounter>(l_, n_);
        IEnumerable<Encounter?>? p_ = Status_1_15_000.Instance.isEncounterPerformed(context, o_);

        bool? q_(Encounter? ValidEncounters) {
            CqlDateTime? ab_ = this.August_1_Year_Prior_to_the_Measurement_Period(context);
            CqlInterval<CqlDateTime?>? ac_ = this.Measurement_Period(context);
            CqlDateTime? ad_ = context.Operators.End(ac_);
            CqlInterval<CqlDateTime?>? ae_ = context.Operators.Interval(ab_, ad_, true, true);
            Period? af_ = ValidEncounters?.Period;
            CqlInterval<CqlDateTime?>? ag_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, af_);
            bool? ah_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ae_, ag_, "day");
            return ah_;
        }

        bool? r_ = context.Operators.WhereAny<Encounter>(p_, q_);
        return r_;
    }


    [CqlExpressionDefinition("November 1 Two Years Prior to the Measurement Period")]
    public CqlDateTime? November_1_Two_Years_Prior_to_the_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_November_1_Two_Years_Prior_to_the_Measurement_Period, November_1_Two_Years_Prior_to_the_Measurement_Period_Compute);

    private const long _cacheIndex_November_1_Two_Years_Prior_to_the_Measurement_Period = 1110942649126641928L;

    private CqlDateTime? November_1_Two_Years_Prior_to_the_Measurement_Period_Compute(CqlContext context)
    {
        CqlInterval<CqlDateTime?>? a_ = this.Measurement_Period(context);
        CqlDateTime? b_ = context.Operators.Start(a_);
        int? c_ = context.Operators.DateTimeComponentFrom(b_, "year");
        int? d_ = context.Operators.Subtract(c_, 2);
        decimal? e_ = context.Operators.ConvertIntegerToDecimal(0);
        CqlDateTime? f_ = context.Operators.DateTime(d_, 11, 1, 0, 0, 0, 0, e_);
        return f_;
    }


    [CqlExpressionDefinition("October 31 Year Prior to the Measurement Period")]
    public CqlDateTime? October_31_Year_Prior_to_the_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_October_31_Year_Prior_to_the_Measurement_Period, October_31_Year_Prior_to_the_Measurement_Period_Compute);

    private const long _cacheIndex_October_31_Year_Prior_to_the_Measurement_Period = 1821886895965482433L;

    private CqlDateTime? October_31_Year_Prior_to_the_Measurement_Period_Compute(CqlContext context)
    {
        CqlInterval<CqlDateTime?>? a_ = this.Measurement_Period(context);
        CqlDateTime? b_ = context.Operators.Start(a_);
        int? c_ = context.Operators.DateTimeComponentFrom(b_, "year");
        int? d_ = context.Operators.Subtract(c_, 1);
        decimal? e_ = context.Operators.ConvertIntegerToDecimal(0);
        CqlDateTime? f_ = context.Operators.DateTime(d_, 10, 31, 23, 59, 59, 999, e_);
        return f_;
    }


    [CqlExpressionDefinition("Total Hip Arthroplasty Procedure")]
    public IEnumerable<Procedure?>? Total_Hip_Arthroplasty_Procedure(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Total_Hip_Arthroplasty_Procedure, Total_Hip_Arthroplasty_Procedure_Compute);

    private const long _cacheIndex_Total_Hip_Arthroplasty_Procedure = -5768173162818717571L;

    private IEnumerable<Procedure?>? Total_Hip_Arthroplasty_Procedure_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Primary_THA_Procedure(context);
        IEnumerable<Procedure?>? b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure?>? c_ = Status_1_15_000.Instance.isProcedurePerformed(context, b_);

        bool? d_(Procedure? THAProcedure) {
            object? f_;
            DataType? m_ = THAProcedure?.Performed;
            object? n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
            bool o_ = n_ is CqlDateTime;
            if (o_)
            {
                DataType? p_ = THAProcedure?.Performed;
                object? q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
                f_ = q_ as CqlDateTime?;
            }
            else
            {
                DataType? r_ = THAProcedure?.Performed;
                object? s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                bool t_ = s_ is CqlQuantity;
                if (t_)
                {
                    DataType? u_ = THAProcedure?.Performed;
                    object? v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                    f_ = v_ as CqlQuantity?;
                }
                else
                {
                    DataType? w_ = THAProcedure?.Performed;
                    object? x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                    bool y_ = x_ is CqlInterval<CqlDateTime>;
                    if (y_)
                    {
                        DataType? z_ = THAProcedure?.Performed;
                        object? aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                        f_ = aa_ as CqlInterval<CqlDateTime?>?;
                    }
                    else
                    {
                        DataType? ab_ = THAProcedure?.Performed;
                        object? ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                        bool ad_ = ac_ is CqlInterval<CqlQuantity>;
                        if (ad_)
                        {
                            DataType? ae_ = THAProcedure?.Performed;
                            object? af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                            f_ = af_ as CqlInterval<CqlQuantity?>?;
                        }
                        else
                        {
                            f_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime?>? g_ = QICoreCommon_4_0_000.Instance.toInterval(context, f_);
            CqlDateTime? h_ = context.Operators.Start(g_);
            CqlDateTime? i_ = this.November_1_Two_Years_Prior_to_the_Measurement_Period(context);
            CqlDateTime? j_ = this.October_31_Year_Prior_to_the_Measurement_Period(context);
            CqlInterval<CqlDateTime?>? k_ = context.Operators.Interval(i_, j_, true, true);
            bool? l_ = context.Operators.In<CqlDateTime>(h_, k_, "day");
            return l_;
        }

        IEnumerable<Procedure?>? e_ = context.Operators.Where<Procedure>(c_, d_);
        return e_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = -1816184053542122591L;

    private bool? Initial_Population_Compute(CqlContext context)
    {
        bool? a_ = this.Has_Qualifying_Encounter(context);
        IEnumerable<Procedure?>? b_ = this.Total_Hip_Arthroplasty_Procedure(context);
        bool? c_ = context.Operators.Exists<Procedure>(b_);
        bool? d_ = context.Operators.And(a_, c_);
        Patient? e_ = this.Patient(context);
        Date? f_ = e_?.BirthDateElement;
        string? g_ = f_?.Value;
        CqlDate? h_ = context.Operators.ConvertStringToDate(g_);
        CqlInterval<CqlDateTime?>? i_ = this.Measurement_Period(context);
        CqlDateTime? j_ = context.Operators.Start(i_);
        CqlDate? k_ = context.Operators.DateFrom(j_);
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
        CqlCode? a_ = this.Severe_cognitive_impairment__finding_(context);
        IEnumerable<CqlCode?>? b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Condition?>? c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition?>? d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition?>? e_ = context.Operators.Union<Condition>(c_ as IEnumerable<Condition?>?, d_ as IEnumerable<Condition?>?);

        bool? f_(Condition? Dementia) {
            CqlInterval<CqlDateTime?>? h_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, Dementia);
            CqlInterval<CqlDateTime?>? i_ = this.Measurement_Period(context);
            bool? j_ = context.Operators.Overlaps(h_, i_, "day");
            return j_;
        }

        bool? g_ = context.Operators.WhereAny<Condition>(e_, f_);
        return g_;
    }


    [CqlFunctionDefinition("isVerified")]
    [CqlTag("note", "When possible, this function should be migrated to QICoreCommon.")]
    [CqlTag("description", "\"confirmed\", \"unconfirmed\", \"provisional\", or \"differential\"")]
    public bool? isVerified(CqlContext context, Condition? condition)
    {
        CodeableConcept? a_ = condition?.VerificationStatus;
        CqlConcept? b_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_);
        bool? c_ = context.Operators.Not((bool?)(b_ is null));
        CqlCode? d_ = QICoreCommon_4_0_000.Instance.confirmed(context);
        CqlConcept? e_ = context.Operators.ConvertCodeToConcept(d_);
        bool? f_ = context.Operators.Equivalent(b_, e_);
        CqlCode? g_ = QICoreCommon_4_0_000.Instance.unconfirmed(context);
        CqlConcept? h_ = context.Operators.ConvertCodeToConcept(g_);
        bool? i_ = context.Operators.Equivalent(b_, h_);
        bool? j_ = context.Operators.Or(f_, i_);
        CqlCode? k_ = QICoreCommon_4_0_000.Instance.provisional(context);
        CqlConcept? l_ = context.Operators.ConvertCodeToConcept(k_);
        bool? m_ = context.Operators.Equivalent(b_, l_);
        bool? n_ = context.Operators.Or(j_, m_);
        CqlCode? o_ = QICoreCommon_4_0_000.Instance.differential(context);
        CqlConcept? p_ = context.Operators.ConvertCodeToConcept(o_);
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
        IEnumerable<Procedure?>? a_ = this.Total_Hip_Arthroplasty_Procedure(context);

        bool? b_(Procedure? THAProcedure) {
            CqlValueSet? d_ = this.Lower_Body_Fractures_Excluding_Ankle_and_Foot(context);
            IEnumerable<Condition?>? e_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition?>? f_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition?>? g_ = context.Operators.Union<Condition>(e_ as IEnumerable<Condition?>?, f_ as IEnumerable<Condition?>?);

            bool? h_(Condition? LowerBodyFracture) {
                CqlInterval<CqlDateTime?>? j_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, LowerBodyFracture);
                CqlDateTime? k_ = context.Operators.Start(j_);
                object? l_;
                DataType? ac_ = THAProcedure?.Performed;
                object? ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                bool ae_ = ad_ is CqlDateTime;
                if (ae_)
                {
                    DataType? af_ = THAProcedure?.Performed;
                    object? ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                    l_ = ag_ as CqlDateTime?;
                }
                else
                {
                    DataType? ah_ = THAProcedure?.Performed;
                    object? ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                    bool aj_ = ai_ is CqlQuantity;
                    if (aj_)
                    {
                        DataType? ak_ = THAProcedure?.Performed;
                        object? al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                        l_ = al_ as CqlQuantity?;
                    }
                    else
                    {
                        DataType? am_ = THAProcedure?.Performed;
                        object? an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                        bool ao_ = an_ is CqlInterval<CqlDateTime>;
                        if (ao_)
                        {
                            DataType? ap_ = THAProcedure?.Performed;
                            object? aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                            l_ = aq_ as CqlInterval<CqlDateTime?>?;
                        }
                        else
                        {
                            DataType? ar_ = THAProcedure?.Performed;
                            object? as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                            bool at_ = as_ is CqlInterval<CqlQuantity>;
                            if (at_)
                            {
                                DataType? au_ = THAProcedure?.Performed;
                                object? av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                                l_ = av_ as CqlInterval<CqlQuantity?>?;
                            }
                            else
                            {
                                l_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime?>? m_ = QICoreCommon_4_0_000.Instance.toInterval(context, l_);
                CqlDateTime? n_ = context.Operators.Start(m_);
                CqlQuantity? o_ = context.Operators.Quantity(48m, "hours");
                CqlDateTime? p_ = context.Operators.Subtract(n_, o_);
                object? q_;
                DataType? aw_ = THAProcedure?.Performed;
                object? ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                bool ay_ = ax_ is CqlDateTime;
                if (ay_)
                {
                    DataType? az_ = THAProcedure?.Performed;
                    object? ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                    q_ = ba_ as CqlDateTime?;
                }
                else
                {
                    DataType? bb_ = THAProcedure?.Performed;
                    object? bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                    bool bd_ = bc_ is CqlQuantity;
                    if (bd_)
                    {
                        DataType? be_ = THAProcedure?.Performed;
                        object? bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                        q_ = bf_ as CqlQuantity?;
                    }
                    else
                    {
                        DataType? bg_ = THAProcedure?.Performed;
                        object? bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                        bool bi_ = bh_ is CqlInterval<CqlDateTime>;
                        if (bi_)
                        {
                            DataType? bj_ = THAProcedure?.Performed;
                            object? bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                            q_ = bk_ as CqlInterval<CqlDateTime?>?;
                        }
                        else
                        {
                            DataType? bl_ = THAProcedure?.Performed;
                            object? bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                            bool bn_ = bm_ is CqlInterval<CqlQuantity>;
                            if (bn_)
                            {
                                DataType? bo_ = THAProcedure?.Performed;
                                object? bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                                q_ = bp_ as CqlInterval<CqlQuantity?>?;
                            }
                            else
                            {
                                q_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime?>? r_ = QICoreCommon_4_0_000.Instance.toInterval(context, q_);
                CqlDateTime? s_ = context.Operators.Start(r_);
                CqlInterval<CqlDateTime?>? t_ = context.Operators.Interval(p_, s_, true, true);
                bool? u_ = context.Operators.In<CqlDateTime>(k_, t_, (string)default);
                object? v_;
                DataType? bq_ = THAProcedure?.Performed;
                object? br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
                bool bs_ = br_ is CqlDateTime;
                if (bs_)
                {
                    DataType? bt_ = THAProcedure?.Performed;
                    object? bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                    v_ = bu_ as CqlDateTime?;
                }
                else
                {
                    DataType? bv_ = THAProcedure?.Performed;
                    object? bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                    bool bx_ = bw_ is CqlQuantity;
                    if (bx_)
                    {
                        DataType? by_ = THAProcedure?.Performed;
                        object? bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);
                        v_ = bz_ as CqlQuantity?;
                    }
                    else
                    {
                        DataType? ca_ = THAProcedure?.Performed;
                        object? cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                        bool cc_ = cb_ is CqlInterval<CqlDateTime>;
                        if (cc_)
                        {
                            DataType? cd_ = THAProcedure?.Performed;
                            object? ce_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cd_);
                            v_ = ce_ as CqlInterval<CqlDateTime?>?;
                        }
                        else
                        {
                            DataType? cf_ = THAProcedure?.Performed;
                            object? cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                            bool ch_ = cg_ is CqlInterval<CqlQuantity>;
                            if (ch_)
                            {
                                DataType? ci_ = THAProcedure?.Performed;
                                object? cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                                v_ = cj_ as CqlInterval<CqlQuantity?>?;
                            }
                            else
                            {
                                v_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime?>? w_ = QICoreCommon_4_0_000.Instance.toInterval(context, v_);
                CqlDateTime? x_ = context.Operators.Start(w_);
                bool? y_ = context.Operators.Not((bool?)(x_ is null));
                bool? z_ = context.Operators.And(u_, y_);
                bool? aa_ = this.isVerified(context, LowerBodyFracture);
                bool? ab_ = context.Operators.And(z_, aa_);
                return ab_;
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
        CqlValueSet? a_ = this.Partial_Arthroplasty_of_Hip(context);
        IEnumerable<Procedure?>? b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure?>? c_ = Status_1_15_000.Instance.isProcedurePerformed(context, b_);

        bool? d_(Procedure? PartialTHAProcedure) {
            IEnumerable<Procedure?>? f_ = this.Total_Hip_Arthroplasty_Procedure(context);

            bool? g_(Procedure? THAProcedure) {
                object? i_;
                DataType? n_ = THAProcedure?.Performed;
                object? o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
                bool p_ = o_ is CqlDateTime;
                if (p_)
                {
                    DataType? q_ = THAProcedure?.Performed;
                    object? r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                    i_ = r_ as CqlDateTime?;
                }
                else
                {
                    DataType? s_ = THAProcedure?.Performed;
                    object? t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                    bool u_ = t_ is CqlQuantity;
                    if (u_)
                    {
                        DataType? v_ = THAProcedure?.Performed;
                        object? w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                        i_ = w_ as CqlQuantity?;
                    }
                    else
                    {
                        DataType? x_ = THAProcedure?.Performed;
                        object? y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                        bool z_ = y_ is CqlInterval<CqlDateTime>;
                        if (z_)
                        {
                            DataType? aa_ = THAProcedure?.Performed;
                            object? ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                            i_ = ab_ as CqlInterval<CqlDateTime?>?;
                        }
                        else
                        {
                            DataType? ac_ = THAProcedure?.Performed;
                            object? ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                            bool ae_ = ad_ is CqlInterval<CqlQuantity>;
                            if (ae_)
                            {
                                DataType? af_ = THAProcedure?.Performed;
                                object? ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                                i_ = ag_ as CqlInterval<CqlQuantity?>?;
                            }
                            else
                            {
                                i_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime?>? j_ = QICoreCommon_4_0_000.Instance.toInterval(context, i_);
                object? k_;
                DataType? ah_ = PartialTHAProcedure?.Performed;
                object? ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                bool aj_ = ai_ is CqlDateTime;
                if (aj_)
                {
                    DataType? ak_ = PartialTHAProcedure?.Performed;
                    object? al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                    k_ = al_ as CqlDateTime?;
                }
                else
                {
                    DataType? am_ = PartialTHAProcedure?.Performed;
                    object? an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                    bool ao_ = an_ is CqlQuantity;
                    if (ao_)
                    {
                        DataType? ap_ = PartialTHAProcedure?.Performed;
                        object? aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                        k_ = aq_ as CqlQuantity?;
                    }
                    else
                    {
                        DataType? ar_ = PartialTHAProcedure?.Performed;
                        object? as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                        bool at_ = as_ is CqlInterval<CqlDateTime>;
                        if (at_)
                        {
                            DataType? au_ = PartialTHAProcedure?.Performed;
                            object? av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                            k_ = av_ as CqlInterval<CqlDateTime?>?;
                        }
                        else
                        {
                            DataType? aw_ = PartialTHAProcedure?.Performed;
                            object? ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                            bool ay_ = ax_ is CqlInterval<CqlQuantity>;
                            if (ay_)
                            {
                                DataType? az_ = PartialTHAProcedure?.Performed;
                                object? ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                                k_ = ba_ as CqlInterval<CqlQuantity?>?;
                            }
                            else
                            {
                                k_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime?>? l_ = QICoreCommon_4_0_000.Instance.toInterval(context, k_);
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
        IEnumerable<Procedure?>? a_ = this.Total_Hip_Arthroplasty_Procedure(context);

        bool? b_(Procedure? THAProcedure) {
            CqlValueSet? d_ = this.Removal__Revision_and_Supplement_Procedures_of_the_Lower_Body_and_Spine(context);
            IEnumerable<Procedure?>? e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            IEnumerable<Procedure?>? f_ = Status_1_15_000.Instance.isProcedurePerformed(context, e_);

            bool? g_(Procedure? RevisionTHAProcedure) {
                object? i_;
                DataType? n_ = THAProcedure?.Performed;
                object? o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
                bool p_ = o_ is CqlDateTime;
                if (p_)
                {
                    DataType? q_ = THAProcedure?.Performed;
                    object? r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                    i_ = r_ as CqlDateTime?;
                }
                else
                {
                    DataType? s_ = THAProcedure?.Performed;
                    object? t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                    bool u_ = t_ is CqlQuantity;
                    if (u_)
                    {
                        DataType? v_ = THAProcedure?.Performed;
                        object? w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                        i_ = w_ as CqlQuantity?;
                    }
                    else
                    {
                        DataType? x_ = THAProcedure?.Performed;
                        object? y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                        bool z_ = y_ is CqlInterval<CqlDateTime>;
                        if (z_)
                        {
                            DataType? aa_ = THAProcedure?.Performed;
                            object? ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                            i_ = ab_ as CqlInterval<CqlDateTime?>?;
                        }
                        else
                        {
                            DataType? ac_ = THAProcedure?.Performed;
                            object? ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                            bool ae_ = ad_ is CqlInterval<CqlQuantity>;
                            if (ae_)
                            {
                                DataType? af_ = THAProcedure?.Performed;
                                object? ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                                i_ = ag_ as CqlInterval<CqlQuantity?>?;
                            }
                            else
                            {
                                i_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime?>? j_ = QICoreCommon_4_0_000.Instance.toInterval(context, i_);
                object? k_;
                DataType? ah_ = RevisionTHAProcedure?.Performed;
                object? ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                bool aj_ = ai_ is CqlDateTime;
                if (aj_)
                {
                    DataType? ak_ = RevisionTHAProcedure?.Performed;
                    object? al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                    k_ = al_ as CqlDateTime?;
                }
                else
                {
                    DataType? am_ = RevisionTHAProcedure?.Performed;
                    object? an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                    bool ao_ = an_ is CqlQuantity;
                    if (ao_)
                    {
                        DataType? ap_ = RevisionTHAProcedure?.Performed;
                        object? aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                        k_ = aq_ as CqlQuantity?;
                    }
                    else
                    {
                        DataType? ar_ = RevisionTHAProcedure?.Performed;
                        object? as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                        bool at_ = as_ is CqlInterval<CqlDateTime>;
                        if (at_)
                        {
                            DataType? au_ = RevisionTHAProcedure?.Performed;
                            object? av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                            k_ = av_ as CqlInterval<CqlDateTime?>?;
                        }
                        else
                        {
                            DataType? aw_ = RevisionTHAProcedure?.Performed;
                            object? ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                            bool ay_ = ax_ is CqlInterval<CqlQuantity>;
                            if (ay_)
                            {
                                DataType? az_ = RevisionTHAProcedure?.Performed;
                                object? ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                                k_ = ba_ as CqlInterval<CqlQuantity?>?;
                            }
                            else
                            {
                                k_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime?>? l_ = QICoreCommon_4_0_000.Instance.toInterval(context, k_);
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
        CqlValueSet? a_ = this.Malignant_Neoplasms_of_Lower_and_Unspecified_Limbs(context);
        IEnumerable<Condition?>? b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition?>? c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition?>? d_ = context.Operators.Union<Condition>(b_ as IEnumerable<Condition?>?, c_ as IEnumerable<Condition?>?);

        bool? e_(Condition? MalignantNeoplasm) {
            IEnumerable<Procedure?>? g_ = this.Total_Hip_Arthroplasty_Procedure(context);

            bool? h_(Procedure? THAProcedure) {
                CqlInterval<CqlDateTime?>? j_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, MalignantNeoplasm);
                object? k_;
                DataType? p_ = THAProcedure?.Performed;
                object? q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
                bool r_ = q_ is CqlDateTime;
                if (r_)
                {
                    DataType? s_ = THAProcedure?.Performed;
                    object? t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                    k_ = t_ as CqlDateTime?;
                }
                else
                {
                    DataType? u_ = THAProcedure?.Performed;
                    object? v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                    bool w_ = v_ is CqlQuantity;
                    if (w_)
                    {
                        DataType? x_ = THAProcedure?.Performed;
                        object? y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                        k_ = y_ as CqlQuantity?;
                    }
                    else
                    {
                        DataType? z_ = THAProcedure?.Performed;
                        object? aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                        bool ab_ = aa_ is CqlInterval<CqlDateTime>;
                        if (ab_)
                        {
                            DataType? ac_ = THAProcedure?.Performed;
                            object? ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                            k_ = ad_ as CqlInterval<CqlDateTime?>?;
                        }
                        else
                        {
                            DataType? ae_ = THAProcedure?.Performed;
                            object? af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                            bool ag_ = af_ is CqlInterval<CqlQuantity>;
                            if (ag_)
                            {
                                DataType? ah_ = THAProcedure?.Performed;
                                object? ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                                k_ = ai_ as CqlInterval<CqlQuantity?>?;
                            }
                            else
                            {
                                k_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime?>? l_ = QICoreCommon_4_0_000.Instance.toInterval(context, k_);
                bool? m_ = context.Operators.Overlaps(j_, l_, "day");
                bool? n_ = this.isVerified(context, MalignantNeoplasm);
                bool? o_ = context.Operators.And(m_, n_);
                return o_;
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
        CqlValueSet? a_ = this.Mechanical_Complications_Excluding_Upper_Body(context);
        IEnumerable<Condition?>? b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition?>? c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition?>? d_ = context.Operators.Union<Condition>(b_ as IEnumerable<Condition?>?, c_ as IEnumerable<Condition?>?);

        bool? e_(Condition? MechanicalComplications) {
            IEnumerable<Procedure?>? g_ = this.Total_Hip_Arthroplasty_Procedure(context);

            bool? h_(Procedure? THAProcedure) {
                CqlInterval<CqlDateTime?>? j_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, MechanicalComplications);
                object? k_;
                DataType? p_ = THAProcedure?.Performed;
                object? q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
                bool r_ = q_ is CqlDateTime;
                if (r_)
                {
                    DataType? s_ = THAProcedure?.Performed;
                    object? t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                    k_ = t_ as CqlDateTime?;
                }
                else
                {
                    DataType? u_ = THAProcedure?.Performed;
                    object? v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                    bool w_ = v_ is CqlQuantity;
                    if (w_)
                    {
                        DataType? x_ = THAProcedure?.Performed;
                        object? y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                        k_ = y_ as CqlQuantity?;
                    }
                    else
                    {
                        DataType? z_ = THAProcedure?.Performed;
                        object? aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                        bool ab_ = aa_ is CqlInterval<CqlDateTime>;
                        if (ab_)
                        {
                            DataType? ac_ = THAProcedure?.Performed;
                            object? ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                            k_ = ad_ as CqlInterval<CqlDateTime?>?;
                        }
                        else
                        {
                            DataType? ae_ = THAProcedure?.Performed;
                            object? af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                            bool ag_ = af_ is CqlInterval<CqlQuantity>;
                            if (ag_)
                            {
                                DataType? ah_ = THAProcedure?.Performed;
                                object? ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                                k_ = ai_ as CqlInterval<CqlQuantity?>?;
                            }
                            else
                            {
                                k_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime?>? l_ = QICoreCommon_4_0_000.Instance.toInterval(context, k_);
                bool? m_ = context.Operators.Overlaps(j_, l_, "day");
                bool? n_ = this.isVerified(context, MechanicalComplications);
                bool? o_ = context.Operators.And(m_, n_);
                return o_;
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
        IEnumerable<Procedure?>? a_ = this.Total_Hip_Arthroplasty_Procedure(context);

        bool? b_(Procedure? THAProcedure) {
            CqlValueSet? d_ = this.Primary_THA_Procedure(context);
            IEnumerable<Procedure?>? e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            IEnumerable<Procedure?>? f_ = Status_1_15_000.Instance.isProcedurePerformed(context, e_);

            bool? g_(Procedure? ElectiveTHAProcedure) {
                Id? i_ = THAProcedure?.IdElement;
                string? j_ = i_?.Value;
                Id? k_ = ElectiveTHAProcedure?.IdElement;
                string? l_ = k_?.Value;
                bool? m_ = context.Operators.Equivalent(j_, l_);
                bool? n_ = context.Operators.Not(m_);
                object? o_;
                DataType? ad_ = ElectiveTHAProcedure?.Performed;
                object? ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                bool af_ = ae_ is CqlDateTime;
                if (af_)
                {
                    DataType? ag_ = ElectiveTHAProcedure?.Performed;
                    object? ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                    o_ = ah_ as CqlDateTime?;
                }
                else
                {
                    DataType? ai_ = ElectiveTHAProcedure?.Performed;
                    object? aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                    bool ak_ = aj_ is CqlQuantity;
                    if (ak_)
                    {
                        DataType? al_ = ElectiveTHAProcedure?.Performed;
                        object? am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                        o_ = am_ as CqlQuantity?;
                    }
                    else
                    {
                        DataType? an_ = ElectiveTHAProcedure?.Performed;
                        object? ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                        bool ap_ = ao_ is CqlInterval<CqlDateTime>;
                        if (ap_)
                        {
                            DataType? aq_ = ElectiveTHAProcedure?.Performed;
                            object? ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                            o_ = ar_ as CqlInterval<CqlDateTime?>?;
                        }
                        else
                        {
                            DataType? as_ = ElectiveTHAProcedure?.Performed;
                            object? at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                            bool au_ = at_ is CqlInterval<CqlQuantity>;
                            if (au_)
                            {
                                DataType? av_ = ElectiveTHAProcedure?.Performed;
                                object? aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                                o_ = aw_ as CqlInterval<CqlQuantity?>?;
                            }
                            else
                            {
                                o_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime?>? p_ = QICoreCommon_4_0_000.Instance.toInterval(context, o_);
                CqlDateTime? q_ = context.Operators.Start(p_);
                object? r_;
                DataType? ax_ = THAProcedure?.Performed;
                object? ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                bool az_ = ay_ is CqlDateTime;
                if (az_)
                {
                    DataType? ba_ = THAProcedure?.Performed;
                    object? bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                    r_ = bb_ as CqlDateTime?;
                }
                else
                {
                    DataType? bc_ = THAProcedure?.Performed;
                    object? bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                    bool be_ = bd_ is CqlQuantity;
                    if (be_)
                    {
                        DataType? bf_ = THAProcedure?.Performed;
                        object? bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                        r_ = bg_ as CqlQuantity?;
                    }
                    else
                    {
                        DataType? bh_ = THAProcedure?.Performed;
                        object? bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                        bool bj_ = bi_ is CqlInterval<CqlDateTime>;
                        if (bj_)
                        {
                            DataType? bk_ = THAProcedure?.Performed;
                            object? bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                            r_ = bl_ as CqlInterval<CqlDateTime?>?;
                        }
                        else
                        {
                            DataType? bm_ = THAProcedure?.Performed;
                            object? bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                            bool bo_ = bn_ is CqlInterval<CqlQuantity>;
                            if (bo_)
                            {
                                DataType? bp_ = THAProcedure?.Performed;
                                object? bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                                r_ = bq_ as CqlInterval<CqlQuantity?>?;
                            }
                            else
                            {
                                r_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime?>? s_ = QICoreCommon_4_0_000.Instance.toInterval(context, r_);
                CqlDateTime? t_ = context.Operators.Start(s_);
                CqlQuantity? u_ = context.Operators.Quantity(1m, "year");
                CqlDateTime? v_ = context.Operators.Subtract(t_, u_);
                object? w_;
                DataType? br_ = THAProcedure?.Performed;
                object? bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
                bool bt_ = bs_ is CqlDateTime;
                if (bt_)
                {
                    DataType? bu_ = THAProcedure?.Performed;
                    object? bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                    w_ = bv_ as CqlDateTime?;
                }
                else
                {
                    DataType? bw_ = THAProcedure?.Performed;
                    object? bx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bw_);
                    bool by_ = bx_ is CqlQuantity;
                    if (by_)
                    {
                        DataType? bz_ = THAProcedure?.Performed;
                        object? ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                        w_ = ca_ as CqlQuantity?;
                    }
                    else
                    {
                        DataType? cb_ = THAProcedure?.Performed;
                        object? cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                        bool cd_ = cc_ is CqlInterval<CqlDateTime>;
                        if (cd_)
                        {
                            DataType? ce_ = THAProcedure?.Performed;
                            object? cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);
                            w_ = cf_ as CqlInterval<CqlDateTime?>?;
                        }
                        else
                        {
                            DataType? cg_ = THAProcedure?.Performed;
                            object? ch_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cg_);
                            bool ci_ = ch_ is CqlInterval<CqlQuantity>;
                            if (ci_)
                            {
                                DataType? cj_ = THAProcedure?.Performed;
                                object? ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
                                w_ = ck_ as CqlInterval<CqlQuantity?>?;
                            }
                            else
                            {
                                w_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime?>? x_ = QICoreCommon_4_0_000.Instance.toInterval(context, w_);
                CqlDateTime? y_ = context.Operators.Start(x_);
                CqlDateTime? z_ = context.Operators.Add(y_, u_);
                CqlInterval<CqlDateTime?>? aa_ = context.Operators.Interval(v_, z_, true, true);
                bool? ab_ = context.Operators.In<CqlDateTime>(q_, aa_, "day");
                bool? ac_ = context.Operators.And(n_, ab_);
                return ac_;
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
        IEnumerable<Procedure?>? a_ = this.Total_Hip_Arthroplasty_Procedure(context);

        bool? b_(Procedure? THAProcedure) {
            Patient? d_ = this.Patient(context);
            DataType? e_ = d_?.Deceased;
            object? f_ = FHIRHelpers_4_4_000.Instance.ToValue(context, e_);
            CqlDate? g_ = context.Operators.DateFrom(f_ as CqlDateTime?);
            object? h_;
            DataType? t_ = THAProcedure?.Performed;
            object? u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
            bool v_ = u_ is CqlDateTime;
            if (v_)
            {
                DataType? w_ = THAProcedure?.Performed;
                object? x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                h_ = x_ as CqlDateTime?;
            }
            else
            {
                DataType? y_ = THAProcedure?.Performed;
                object? z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                bool aa_ = z_ is CqlQuantity;
                if (aa_)
                {
                    DataType? ab_ = THAProcedure?.Performed;
                    object? ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    h_ = ac_ as CqlQuantity?;
                }
                else
                {
                    DataType? ad_ = THAProcedure?.Performed;
                    object? ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                    bool af_ = ae_ is CqlInterval<CqlDateTime>;
                    if (af_)
                    {
                        DataType? ag_ = THAProcedure?.Performed;
                        object? ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                        h_ = ah_ as CqlInterval<CqlDateTime?>?;
                    }
                    else
                    {
                        DataType? ai_ = THAProcedure?.Performed;
                        object? aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                        bool ak_ = aj_ is CqlInterval<CqlQuantity>;
                        if (ak_)
                        {
                            DataType? al_ = THAProcedure?.Performed;
                            object? am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                            h_ = am_ as CqlInterval<CqlQuantity?>?;
                        }
                        else
                        {
                            h_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime?>? i_ = QICoreCommon_4_0_000.Instance.toInterval(context, h_);
            CqlDateTime? j_ = context.Operators.Start(i_);
            CqlDate? k_ = context.Operators.DateFrom(j_);
            object? l_;
            DataType? an_ = THAProcedure?.Performed;
            object? ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
            bool ap_ = ao_ is CqlDateTime;
            if (ap_)
            {
                DataType? aq_ = THAProcedure?.Performed;
                object? ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                l_ = ar_ as CqlDateTime?;
            }
            else
            {
                DataType? as_ = THAProcedure?.Performed;
                object? at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                bool au_ = at_ is CqlQuantity;
                if (au_)
                {
                    DataType? av_ = THAProcedure?.Performed;
                    object? aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                    l_ = aw_ as CqlQuantity?;
                }
                else
                {
                    DataType? ax_ = THAProcedure?.Performed;
                    object? ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                    bool az_ = ay_ is CqlInterval<CqlDateTime>;
                    if (az_)
                    {
                        DataType? ba_ = THAProcedure?.Performed;
                        object? bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                        l_ = bb_ as CqlInterval<CqlDateTime?>?;
                    }
                    else
                    {
                        DataType? bc_ = THAProcedure?.Performed;
                        object? bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                        bool be_ = bd_ is CqlInterval<CqlQuantity>;
                        if (be_)
                        {
                            DataType? bf_ = THAProcedure?.Performed;
                            object? bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                            l_ = bg_ as CqlInterval<CqlQuantity?>?;
                        }
                        else
                        {
                            l_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime?>? m_ = QICoreCommon_4_0_000.Instance.toInterval(context, l_);
            CqlDateTime? n_ = context.Operators.Start(m_);
            CqlDate? o_ = context.Operators.DateFrom(n_);
            CqlQuantity? p_ = context.Operators.Quantity(300m, "days");
            CqlDate? q_ = context.Operators.Add(o_, p_);
            CqlInterval<CqlDate?>? r_ = context.Operators.Interval(k_, q_, true, true);
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
    public IEnumerable<CqlDate?>? Date_HOOS_Total_Assessment_Completed(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Date_HOOS_Total_Assessment_Completed, Date_HOOS_Total_Assessment_Completed_Compute);

    private const long _cacheIndex_Date_HOOS_Total_Assessment_Completed = 7130200900377271899L;

    private IEnumerable<CqlDate?>? Date_HOOS_Total_Assessment_Completed_Compute(CqlContext context)
    {
        CqlCode? a_ = this.Quality_of_life_score__HOOS_(context);
        IEnumerable<CqlCode?>? b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation?>? c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
        IEnumerable<Observation?>? d_ = Status_1_15_000.Instance.isAssessmentPerformed(context, c_);
        CqlCode? e_ = this.Sport_recreation_score__HOOS_(context);
        IEnumerable<CqlCode?>? f_ = context.Operators.ToList<CqlCode>(e_);
        IEnumerable<Observation?>? g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, f_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
        IEnumerable<Observation?>? h_ = Status_1_15_000.Instance.isAssessmentPerformed(context, g_);
        CqlCode? i_ = this.Activities_of_daily_living_score__HOOS_(context);
        IEnumerable<CqlCode?>? j_ = context.Operators.ToList<CqlCode>(i_);
        IEnumerable<Observation?>? k_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, j_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
        IEnumerable<Observation?>? l_ = Status_1_15_000.Instance.isAssessmentPerformed(context, k_);
        CqlCode? m_ = this.Symptoms_score__HOOS_(context);
        IEnumerable<CqlCode?>? n_ = context.Operators.ToList<CqlCode>(m_);
        IEnumerable<Observation?>? o_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, n_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
        IEnumerable<Observation?>? p_ = Status_1_15_000.Instance.isAssessmentPerformed(context, o_);
        CqlCode? q_ = this.Pain_score__HOOS_(context);
        IEnumerable<CqlCode?>? r_ = context.Operators.ToList<CqlCode>(q_);
        IEnumerable<Observation?>? s_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, r_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
        IEnumerable<Observation?>? t_ = Status_1_15_000.Instance.isAssessmentPerformed(context, s_);
        IEnumerable<ValueTuple<Observation?, Observation?, Observation?, Observation?, Observation?>>? u_ = context.Operators.CrossJoin<Observation, Observation, Observation, Observation, Observation>(d_, h_, l_, p_, t_);

        (CqlTupleMetadata, Observation? HOOSLifeQuality, Observation? HOOSSport, Observation? HOOSActivityScore, Observation? HOOSSymptoms, Observation? HOOSPain)? v_(ValueTuple<Observation?, Observation?, Observation?, Observation?, Observation?> _valueTuple) {
            (CqlTupleMetadata, Observation? HOOSLifeQuality, Observation? HOOSSport, Observation? HOOSActivityScore, Observation? HOOSSymptoms, Observation? HOOSPain)? aa_ = (CqlTupleMetadata_GVNUVHGXYWXVGgfjdTEahUfhP, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3, _valueTuple.Item4, _valueTuple.Item5);
            return aa_;
        }


        bool? w_((CqlTupleMetadata, Observation? HOOSLifeQuality, Observation? HOOSSport, Observation? HOOSActivityScore, Observation? HOOSSymptoms, Observation? HOOSPain)? tuple_eipfmazvhfscjijaofhicpvmb) {
            DataType? ab_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSLifeQuality?.Effective;
            object? ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
            CqlInterval<CqlDateTime?>? ad_ = QICoreCommon_4_0_000.Instance.toInterval(context, ac_);
            CqlDateTime? ae_ = context.Operators.Start(ad_);
            CqlDate? af_ = context.Operators.DateFrom(ae_);
            DataType? ag_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSSport?.Effective;
            object? ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
            CqlInterval<CqlDateTime?>? ai_ = QICoreCommon_4_0_000.Instance.toInterval(context, ah_);
            CqlDateTime? aj_ = context.Operators.Start(ai_);
            CqlDate? ak_ = context.Operators.DateFrom(aj_);
            bool? al_ = context.Operators.SameAs(af_, ak_, "day");
            DataType? am_ = (tuple_eipfmazvhfscjijaofhicpvmb?.HOOSSport as Observation?)?.Value;
            object? an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
            bool? ao_ = context.Operators.Not((bool?)(an_ is null));
            bool? ap_ = context.Operators.And(al_, ao_);
            DataType? aq_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSActivityScore?.Effective;
            object? ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
            CqlInterval<CqlDateTime?>? as_ = QICoreCommon_4_0_000.Instance.toInterval(context, ar_);
            CqlDateTime? at_ = context.Operators.Start(as_);
            CqlDate? au_ = context.Operators.DateFrom(at_);
            bool? av_ = context.Operators.SameAs(af_, au_, "day");
            bool? aw_ = context.Operators.And(ap_, av_);
            DataType? ax_ = (tuple_eipfmazvhfscjijaofhicpvmb?.HOOSActivityScore as Observation?)?.Value;
            object? ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
            bool? az_ = context.Operators.Not((bool?)(ay_ is null));
            bool? ba_ = context.Operators.And(aw_, az_);
            DataType? bb_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSSymptoms?.Effective;
            object? bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
            CqlInterval<CqlDateTime?>? bd_ = QICoreCommon_4_0_000.Instance.toInterval(context, bc_);
            CqlDateTime? be_ = context.Operators.Start(bd_);
            CqlDate? bf_ = context.Operators.DateFrom(be_);
            bool? bg_ = context.Operators.SameAs(af_, bf_, "day");
            bool? bh_ = context.Operators.And(ba_, bg_);
            DataType? bi_ = (tuple_eipfmazvhfscjijaofhicpvmb?.HOOSSymptoms as Observation?)?.Value;
            object? bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
            bool? bk_ = context.Operators.Not((bool?)(bj_ is null));
            bool? bl_ = context.Operators.And(bh_, bk_);
            DataType? bm_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSPain?.Effective;
            object? bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
            CqlInterval<CqlDateTime?>? bo_ = QICoreCommon_4_0_000.Instance.toInterval(context, bn_);
            CqlDateTime? bp_ = context.Operators.Start(bo_);
            CqlDate? bq_ = context.Operators.DateFrom(bp_);
            bool? br_ = context.Operators.SameAs(af_, bq_, "day");
            bool? bs_ = context.Operators.And(bl_, br_);
            DataType? bt_ = (tuple_eipfmazvhfscjijaofhicpvmb?.HOOSPain as Observation?)?.Value;
            object? bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
            bool? bv_ = context.Operators.Not((bool?)(bu_ is null));
            bool? bw_ = context.Operators.And(bs_, bv_);
            DataType? bx_ = (tuple_eipfmazvhfscjijaofhicpvmb?.HOOSLifeQuality as Observation?)?.Value;
            object? by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
            bool? bz_ = context.Operators.Not((bool?)(by_ is null));
            bool? ca_ = context.Operators.And(bw_, bz_);
            return ca_;
        }

        IEnumerable<(CqlTupleMetadata, Observation? HOOSLifeQuality, Observation? HOOSSport, Observation? HOOSActivityScore, Observation? HOOSSymptoms, Observation? HOOSPain)?>? x_ = context.Operators.SelectWhere<ValueTuple<Observation, Observation, Observation, Observation, Observation>, (CqlTupleMetadata, Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)?>(u_, v_, w_);

        CqlDate? y_((CqlTupleMetadata, Observation? HOOSLifeQuality, Observation? HOOSSport, Observation? HOOSActivityScore, Observation? HOOSSymptoms, Observation? HOOSPain)? tuple_eipfmazvhfscjijaofhicpvmb) {
            DataType? cb_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSLifeQuality?.Effective;
            object? cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
            CqlInterval<CqlDateTime?>? cd_ = QICoreCommon_4_0_000.Instance.toInterval(context, cc_);
            CqlDateTime? ce_ = context.Operators.Start(cd_);
            CqlDate? cf_ = context.Operators.DateFrom(ce_);
            DataType? cg_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSSport?.Effective;
            object? ch_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cg_);
            CqlInterval<CqlDateTime?>? ci_ = QICoreCommon_4_0_000.Instance.toInterval(context, ch_);
            CqlDateTime? cj_ = context.Operators.Start(ci_);
            CqlDate? ck_ = context.Operators.DateFrom(cj_);
            DataType? cl_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSActivityScore?.Effective;
            object? cm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cl_);
            CqlInterval<CqlDateTime?>? cn_ = QICoreCommon_4_0_000.Instance.toInterval(context, cm_);
            CqlDateTime? co_ = context.Operators.Start(cn_);
            CqlDate? cp_ = context.Operators.DateFrom(co_);
            DataType? cq_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSSymptoms?.Effective;
            object? cr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cq_);
            CqlInterval<CqlDateTime?>? cs_ = QICoreCommon_4_0_000.Instance.toInterval(context, cr_);
            CqlDateTime? ct_ = context.Operators.Start(cs_);
            CqlDate? cu_ = context.Operators.DateFrom(ct_);
            DataType? cv_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSPain?.Effective;
            object? cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);
            CqlInterval<CqlDateTime?>? cx_ = QICoreCommon_4_0_000.Instance.toInterval(context, cw_);
            CqlDateTime? cy_ = context.Operators.Start(cx_);
            CqlDate? cz_ = context.Operators.DateFrom(cy_);
            CqlDate?[]? da_ = [
                cf_,
                ck_,
                cp_,
                cu_,
                cz_,
            ];
            CqlDate? db_ = context.Operators.Max<CqlDate>((IEnumerable<CqlDate?>?)da_);
            return db_;
        }

        IEnumerable<CqlDate?>? z_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)?, CqlDate>(x_, y_);
        return z_;
    }


    [CqlExpressionDefinition("Has THA with Initial and Follow Up HOOS Assessments")]
    public bool? Has_THA_with_Initial_and_Follow_Up_HOOS_Assessments(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_THA_with_Initial_and_Follow_Up_HOOS_Assessments, Has_THA_with_Initial_and_Follow_Up_HOOS_Assessments_Compute);

    private const long _cacheIndex_Has_THA_with_Initial_and_Follow_Up_HOOS_Assessments = -3170780632634006629L;

    private bool? Has_THA_with_Initial_and_Follow_Up_HOOS_Assessments_Compute(CqlContext context)
    {
        IEnumerable<Procedure?>? a_ = this.Total_Hip_Arthroplasty_Procedure(context);

        CqlInterval<CqlDateTime?>? b_(Procedure? THAProcedure) {
            object? h_;
            DataType? j_ = THAProcedure?.Performed;
            object? k_ = FHIRHelpers_4_4_000.Instance.ToValue(context, j_);
            bool l_ = k_ is CqlDateTime;
            if (l_)
            {
                DataType? m_ = THAProcedure?.Performed;
                object? n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
                h_ = n_ as CqlDateTime?;
            }
            else
            {
                DataType? o_ = THAProcedure?.Performed;
                object? p_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
                bool q_ = p_ is CqlQuantity;
                if (q_)
                {
                    DataType? r_ = THAProcedure?.Performed;
                    object? s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                    h_ = s_ as CqlQuantity?;
                }
                else
                {
                    DataType? t_ = THAProcedure?.Performed;
                    object? u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                    bool v_ = u_ is CqlInterval<CqlDateTime>;
                    if (v_)
                    {
                        DataType? w_ = THAProcedure?.Performed;
                        object? x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                        h_ = x_ as CqlInterval<CqlDateTime?>?;
                    }
                    else
                    {
                        DataType? y_ = THAProcedure?.Performed;
                        object? z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                        bool aa_ = z_ is CqlInterval<CqlQuantity>;
                        if (aa_)
                        {
                            DataType? ab_ = THAProcedure?.Performed;
                            object? ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                            h_ = ac_ as CqlInterval<CqlQuantity?>?;
                        }
                        else
                        {
                            h_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime?>? i_ = QICoreCommon_4_0_000.Instance.toInterval(context, h_);
            return i_;
        }

        IEnumerable<CqlInterval<CqlDateTime?>?>? c_ = context.Operators.SelectDistinct<Procedure, CqlInterval<CqlDateTime>>(a_, b_);

        bool? d_(CqlInterval<CqlDateTime?>? TotalHip) {
            IEnumerable<CqlDate?>? ad_ = this.Date_HOOS_Total_Assessment_Completed(context);

            bool? ae_(CqlDate? InitialHipAssessmentHOOS) {
                CqlDateTime? ag_ = context.Operators.Start(TotalHip);
                CqlDateTime? ah_ = context.Operators.ConvertDateToDateTime(InitialHipAssessmentHOOS);
                CqlQuantity? ai_ = context.Operators.Quantity(90m, "days");
                CqlDate? aj_ = context.Operators.Add(InitialHipAssessmentHOOS, ai_);
                CqlDateTime? ak_ = context.Operators.ConvertDateToDateTime(aj_);
                CqlInterval<CqlDateTime?>? al_ = context.Operators.Interval(ah_, ak_, true, true);
                bool? am_ = context.Operators.In<CqlDateTime>(ag_, al_, "day");
                bool? an_ = context.Operators.Not((bool?)(InitialHipAssessmentHOOS is null));
                bool? ao_ = context.Operators.And(am_, an_);
                return ao_;
            }

            bool? af_ = context.Operators.WhereAny<CqlDate>(ad_, ae_);
            return af_;
        }

        IEnumerable<CqlInterval<CqlDateTime?>?>? e_ = context.Operators.Where<CqlInterval<CqlDateTime>>(c_, d_);

        bool? f_(CqlInterval<CqlDateTime?>? TotalHip) {
            IEnumerable<CqlDate?>? ap_ = this.Date_HOOS_Total_Assessment_Completed(context);

            bool? aq_(CqlDate? FollowUpHipAssessmentHOOS) {
                CqlDateTime? as_ = context.Operators.ConvertDateToDateTime(FollowUpHipAssessmentHOOS);
                CqlDate? at_ = context.Operators.DateFrom(as_);
                CqlDateTime? au_ = context.Operators.End(TotalHip);
                CqlDate? av_ = context.Operators.DateFrom(au_);
                CqlQuantity? aw_ = context.Operators.Quantity(300m, "days");
                CqlDate? ax_ = context.Operators.Add(av_, aw_);
                CqlQuantity? ay_ = context.Operators.Quantity(425m, "days");
                CqlDate? az_ = context.Operators.Add(av_, ay_);
                CqlInterval<CqlDate?>? ba_ = context.Operators.Interval(ax_, az_, true, true);
                bool? bb_ = context.Operators.In<CqlDate>(at_, ba_, "day");
                return bb_;
            }

            bool? ar_ = context.Operators.WhereAny<CqlDate>(ap_, aq_);
            return ar_;
        }

        bool? g_ = context.Operators.WhereAny<CqlInterval<CqlDateTime>>(e_, f_);
        return g_;
    }


    [CqlExpressionDefinition("Date HOOSJr Total Assessment Completed")]
    public IEnumerable<CqlDate?>? Date_HOOSJr_Total_Assessment_Completed(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Date_HOOSJr_Total_Assessment_Completed, Date_HOOSJr_Total_Assessment_Completed_Compute);

    private const long _cacheIndex_Date_HOOSJr_Total_Assessment_Completed = -9128756688026624721L;

    private IEnumerable<CqlDate?>? Date_HOOSJr_Total_Assessment_Completed_Compute(CqlContext context)
    {
        CqlCode? a_ = this.Total_interval_score__HOOSJR_(context);
        IEnumerable<CqlCode?>? b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation?>? c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
        IEnumerable<Observation?>? d_ = Status_1_15_000.Instance.isAssessmentPerformed(context, c_);

        bool? e_(Observation? HOOSJr) {
            DataType? i_ = (HOOSJr as Observation?)?.Value;
            object? j_ = FHIRHelpers_4_4_000.Instance.ToValue(context, i_);
            bool? k_ = context.Operators.Not((bool?)(j_ is null));
            return k_;
        }


        CqlDate? f_(Observation? DocumentedHOOSJr) {
            DataType? l_ = DocumentedHOOSJr?.Effective;
            object? m_ = FHIRHelpers_4_4_000.Instance.ToValue(context, l_);
            CqlInterval<CqlDateTime?>? n_ = QICoreCommon_4_0_000.Instance.toInterval(context, m_);
            CqlDateTime? o_ = context.Operators.Start(n_);
            CqlDate? p_ = context.Operators.DateFrom(o_);
            return p_;
        }

        IEnumerable<CqlDate?>? g_ = context.Operators.WhereSelect<Observation, CqlDate>(d_, e_, f_);
        IEnumerable<CqlDate?>? h_ = context.Operators.Distinct<CqlDate>(g_);
        return h_;
    }


    [CqlExpressionDefinition("Has THA with Initial and Follow Up HOOSJr Assessments")]
    public bool? Has_THA_with_Initial_and_Follow_Up_HOOSJr_Assessments(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_THA_with_Initial_and_Follow_Up_HOOSJr_Assessments, Has_THA_with_Initial_and_Follow_Up_HOOSJr_Assessments_Compute);

    private const long _cacheIndex_Has_THA_with_Initial_and_Follow_Up_HOOSJr_Assessments = -3393965754895205370L;

    private bool? Has_THA_with_Initial_and_Follow_Up_HOOSJr_Assessments_Compute(CqlContext context)
    {
        IEnumerable<Procedure?>? a_ = this.Total_Hip_Arthroplasty_Procedure(context);

        CqlInterval<CqlDateTime?>? b_(Procedure? THAProcedure) {
            object? h_;
            DataType? j_ = THAProcedure?.Performed;
            object? k_ = FHIRHelpers_4_4_000.Instance.ToValue(context, j_);
            bool l_ = k_ is CqlDateTime;
            if (l_)
            {
                DataType? m_ = THAProcedure?.Performed;
                object? n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
                h_ = n_ as CqlDateTime?;
            }
            else
            {
                DataType? o_ = THAProcedure?.Performed;
                object? p_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
                bool q_ = p_ is CqlQuantity;
                if (q_)
                {
                    DataType? r_ = THAProcedure?.Performed;
                    object? s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                    h_ = s_ as CqlQuantity?;
                }
                else
                {
                    DataType? t_ = THAProcedure?.Performed;
                    object? u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                    bool v_ = u_ is CqlInterval<CqlDateTime>;
                    if (v_)
                    {
                        DataType? w_ = THAProcedure?.Performed;
                        object? x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                        h_ = x_ as CqlInterval<CqlDateTime?>?;
                    }
                    else
                    {
                        DataType? y_ = THAProcedure?.Performed;
                        object? z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                        bool aa_ = z_ is CqlInterval<CqlQuantity>;
                        if (aa_)
                        {
                            DataType? ab_ = THAProcedure?.Performed;
                            object? ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                            h_ = ac_ as CqlInterval<CqlQuantity?>?;
                        }
                        else
                        {
                            h_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime?>? i_ = QICoreCommon_4_0_000.Instance.toInterval(context, h_);
            return i_;
        }

        IEnumerable<CqlInterval<CqlDateTime?>?>? c_ = context.Operators.SelectDistinct<Procedure, CqlInterval<CqlDateTime>>(a_, b_);

        bool? d_(CqlInterval<CqlDateTime?>? TotalHip) {
            IEnumerable<CqlDate?>? ad_ = this.Date_HOOSJr_Total_Assessment_Completed(context);

            bool? ae_(CqlDate? InitialHipAssessment) {
                CqlDateTime? ag_ = context.Operators.Start(TotalHip);
                CqlDateTime? ah_ = context.Operators.ConvertDateToDateTime(InitialHipAssessment);
                CqlQuantity? ai_ = context.Operators.Quantity(90m, "days");
                CqlDate? aj_ = context.Operators.Add(InitialHipAssessment, ai_);
                CqlDateTime? ak_ = context.Operators.ConvertDateToDateTime(aj_);
                CqlInterval<CqlDateTime?>? al_ = context.Operators.Interval(ah_, ak_, true, true);
                bool? am_ = context.Operators.In<CqlDateTime>(ag_, al_, "day");
                bool? an_ = context.Operators.Not((bool?)(InitialHipAssessment is null));
                bool? ao_ = context.Operators.And(am_, an_);
                return ao_;
            }

            bool? af_ = context.Operators.WhereAny<CqlDate>(ad_, ae_);
            return af_;
        }

        IEnumerable<CqlInterval<CqlDateTime?>?>? e_ = context.Operators.Where<CqlInterval<CqlDateTime>>(c_, d_);

        bool? f_(CqlInterval<CqlDateTime?>? TotalHip) {
            IEnumerable<CqlDate?>? ap_ = this.Date_HOOSJr_Total_Assessment_Completed(context);

            bool? aq_(CqlDate? FollowUpHipAssessment) {
                CqlDateTime? as_ = context.Operators.ConvertDateToDateTime(FollowUpHipAssessment);
                CqlDate? at_ = context.Operators.DateFrom(as_);
                CqlDateTime? au_ = context.Operators.End(TotalHip);
                CqlDate? av_ = context.Operators.DateFrom(au_);
                CqlQuantity? aw_ = context.Operators.Quantity(300m, "days");
                CqlDate? ax_ = context.Operators.Add(av_, aw_);
                CqlQuantity? ay_ = context.Operators.Quantity(425m, "days");
                CqlDate? az_ = context.Operators.Add(av_, ay_);
                CqlInterval<CqlDate?>? ba_ = context.Operators.Interval(ax_, az_, true, true);
                bool? bb_ = context.Operators.In<CqlDate>(at_, ba_, "day");
                return bb_;
            }

            bool? ar_ = context.Operators.WhereAny<CqlDate>(ap_, aq_);
            return ar_;
        }

        bool? g_ = context.Operators.WhereAny<CqlInterval<CqlDateTime>>(e_, f_);
        return g_;
    }


    [CqlExpressionDefinition("Date PROMIS10 Total Assessment Completed")]
    public IEnumerable<CqlDate?>? Date_PROMIS10_Total_Assessment_Completed(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Date_PROMIS10_Total_Assessment_Completed, Date_PROMIS10_Total_Assessment_Completed_Compute);

    private const long _cacheIndex_Date_PROMIS10_Total_Assessment_Completed = -1003334648429625917L;

    private IEnumerable<CqlDate?>? Date_PROMIS10_Total_Assessment_Completed_Compute(CqlContext context)
    {
        CqlCode? a_ = this.PROMIS_10_Global_Mental_Health__GMH__score_T_score(context);
        IEnumerable<CqlCode?>? b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation?>? c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
        IEnumerable<Observation?>? d_ = Status_1_15_000.Instance.isAssessmentPerformed(context, c_);
        CqlCode? e_ = this.PROMIS_10_Global_Physical_Health__GPH__score_T_score(context);
        IEnumerable<CqlCode?>? f_ = context.Operators.ToList<CqlCode>(e_);
        IEnumerable<Observation?>? g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, f_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
        IEnumerable<Observation?>? h_ = Status_1_15_000.Instance.isAssessmentPerformed(context, g_);
        IEnumerable<ValueTuple<Observation?, Observation?>>? i_ = context.Operators.CrossJoin<Observation, Observation>(d_, h_);

        (CqlTupleMetadata, Observation? PROMIS10MentalScore, Observation? PROMIS10PhysicalScore)? j_(ValueTuple<Observation?, Observation?> _valueTuple) {
            (CqlTupleMetadata, Observation? PROMIS10MentalScore, Observation? PROMIS10PhysicalScore)? o_ = (CqlTupleMetadata_DDTAOdcFieSJbGgRLLZPYbGQb, _valueTuple.Item1, _valueTuple.Item2);
            return o_;
        }


        bool? k_((CqlTupleMetadata, Observation? PROMIS10MentalScore, Observation? PROMIS10PhysicalScore)? tuple_ddtaodcfiesjbggrllzpybgqb) {
            DataType? p_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10MentalScore?.Effective;
            object? q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
            CqlInterval<CqlDateTime?>? r_ = QICoreCommon_4_0_000.Instance.toInterval(context, q_);
            CqlDateTime? s_ = context.Operators.Start(r_);
            CqlDate? t_ = context.Operators.DateFrom(s_);
            DataType? u_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10PhysicalScore?.Effective;
            object? v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
            CqlInterval<CqlDateTime?>? w_ = QICoreCommon_4_0_000.Instance.toInterval(context, v_);
            CqlDateTime? x_ = context.Operators.Start(w_);
            CqlDate? y_ = context.Operators.DateFrom(x_);
            bool? z_ = context.Operators.SameAs(t_, y_, "day");
            DataType? aa_ = (tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10PhysicalScore as Observation?)?.Value;
            object? ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
            bool? ac_ = context.Operators.Not((bool?)(ab_ is null));
            bool? ad_ = context.Operators.And(z_, ac_);
            DataType? ae_ = (tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10MentalScore as Observation?)?.Value;
            object? af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
            bool? ag_ = context.Operators.Not((bool?)(af_ is null));
            bool? ah_ = context.Operators.And(ad_, ag_);
            return ah_;
        }

        IEnumerable<(CqlTupleMetadata, Observation? PROMIS10MentalScore, Observation? PROMIS10PhysicalScore)?>? l_ = context.Operators.SelectWhere<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?>(i_, j_, k_);

        CqlDate? m_((CqlTupleMetadata, Observation? PROMIS10MentalScore, Observation? PROMIS10PhysicalScore)? tuple_ddtaodcfiesjbggrllzpybgqb) {
            DataType? ai_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10MentalScore?.Effective;
            object? aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
            CqlInterval<CqlDateTime?>? ak_ = QICoreCommon_4_0_000.Instance.toInterval(context, aj_);
            CqlDateTime? al_ = context.Operators.Start(ak_);
            CqlDate? am_ = context.Operators.DateFrom(al_);
            DataType? an_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10PhysicalScore?.Effective;
            object? ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
            CqlInterval<CqlDateTime?>? ap_ = QICoreCommon_4_0_000.Instance.toInterval(context, ao_);
            CqlDateTime? aq_ = context.Operators.Start(ap_);
            CqlDate? ar_ = context.Operators.DateFrom(aq_);
            CqlDate?[]? as_ = [
                am_,
                ar_,
            ];
            CqlDate? at_ = context.Operators.Max<CqlDate>((IEnumerable<CqlDate?>?)as_);
            return at_;
        }

        IEnumerable<CqlDate?>? n_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?, CqlDate>(l_, m_);
        return n_;
    }


    [CqlExpressionDefinition("Has THA with Initial and Follow Up PROMIS10 Assessments")]
    public bool? Has_THA_with_Initial_and_Follow_Up_PROMIS10_Assessments(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_THA_with_Initial_and_Follow_Up_PROMIS10_Assessments, Has_THA_with_Initial_and_Follow_Up_PROMIS10_Assessments_Compute);

    private const long _cacheIndex_Has_THA_with_Initial_and_Follow_Up_PROMIS10_Assessments = -4717330265822200184L;

    private bool? Has_THA_with_Initial_and_Follow_Up_PROMIS10_Assessments_Compute(CqlContext context)
    {
        IEnumerable<Procedure?>? a_ = this.Total_Hip_Arthroplasty_Procedure(context);

        CqlInterval<CqlDateTime?>? b_(Procedure? THAProcedure) {
            object? h_;
            DataType? j_ = THAProcedure?.Performed;
            object? k_ = FHIRHelpers_4_4_000.Instance.ToValue(context, j_);
            bool l_ = k_ is CqlDateTime;
            if (l_)
            {
                DataType? m_ = THAProcedure?.Performed;
                object? n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
                h_ = n_ as CqlDateTime?;
            }
            else
            {
                DataType? o_ = THAProcedure?.Performed;
                object? p_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
                bool q_ = p_ is CqlQuantity;
                if (q_)
                {
                    DataType? r_ = THAProcedure?.Performed;
                    object? s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                    h_ = s_ as CqlQuantity?;
                }
                else
                {
                    DataType? t_ = THAProcedure?.Performed;
                    object? u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                    bool v_ = u_ is CqlInterval<CqlDateTime>;
                    if (v_)
                    {
                        DataType? w_ = THAProcedure?.Performed;
                        object? x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                        h_ = x_ as CqlInterval<CqlDateTime?>?;
                    }
                    else
                    {
                        DataType? y_ = THAProcedure?.Performed;
                        object? z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                        bool aa_ = z_ is CqlInterval<CqlQuantity>;
                        if (aa_)
                        {
                            DataType? ab_ = THAProcedure?.Performed;
                            object? ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                            h_ = ac_ as CqlInterval<CqlQuantity?>?;
                        }
                        else
                        {
                            h_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime?>? i_ = QICoreCommon_4_0_000.Instance.toInterval(context, h_);
            return i_;
        }

        IEnumerable<CqlInterval<CqlDateTime?>?>? c_ = context.Operators.SelectDistinct<Procedure, CqlInterval<CqlDateTime>>(a_, b_);

        bool? d_(CqlInterval<CqlDateTime?>? TotalHip) {
            IEnumerable<CqlDate?>? ad_ = this.Date_PROMIS10_Total_Assessment_Completed(context);

            bool? ae_(CqlDate? InitialHipAssessmentPROMIS10) {
                CqlDateTime? ag_ = context.Operators.Start(TotalHip);
                CqlDateTime? ah_ = context.Operators.ConvertDateToDateTime(InitialHipAssessmentPROMIS10);
                CqlQuantity? ai_ = context.Operators.Quantity(90m, "days");
                CqlDate? aj_ = context.Operators.Add(InitialHipAssessmentPROMIS10, ai_);
                CqlDateTime? ak_ = context.Operators.ConvertDateToDateTime(aj_);
                CqlInterval<CqlDateTime?>? al_ = context.Operators.Interval(ah_, ak_, true, true);
                bool? am_ = context.Operators.In<CqlDateTime>(ag_, al_, "day");
                bool? an_ = context.Operators.Not((bool?)(InitialHipAssessmentPROMIS10 is null));
                bool? ao_ = context.Operators.And(am_, an_);
                return ao_;
            }

            bool? af_ = context.Operators.WhereAny<CqlDate>(ad_, ae_);
            return af_;
        }

        IEnumerable<CqlInterval<CqlDateTime?>?>? e_ = context.Operators.Where<CqlInterval<CqlDateTime>>(c_, d_);

        bool? f_(CqlInterval<CqlDateTime?>? TotalHip) {
            IEnumerable<CqlDate?>? ap_ = this.Date_PROMIS10_Total_Assessment_Completed(context);

            bool? aq_(CqlDate? FollowUpHipAssessmentPROMIS10) {
                CqlDateTime? as_ = context.Operators.ConvertDateToDateTime(FollowUpHipAssessmentPROMIS10);
                CqlDate? at_ = context.Operators.DateFrom(as_);
                CqlDateTime? au_ = context.Operators.End(TotalHip);
                CqlDate? av_ = context.Operators.DateFrom(au_);
                CqlQuantity? aw_ = context.Operators.Quantity(300m, "days");
                CqlDate? ax_ = context.Operators.Add(av_, aw_);
                CqlQuantity? ay_ = context.Operators.Quantity(425m, "days");
                CqlDate? az_ = context.Operators.Add(av_, ay_);
                CqlInterval<CqlDate?>? ba_ = context.Operators.Interval(ax_, az_, true, true);
                bool? bb_ = context.Operators.In<CqlDate>(at_, ba_, "day");
                return bb_;
            }

            bool? ar_ = context.Operators.WhereAny<CqlDate>(ap_, aq_);
            return ar_;
        }

        bool? g_ = context.Operators.WhereAny<CqlInterval<CqlDateTime>>(e_, f_);
        return g_;
    }


    [CqlExpressionDefinition("Date VR12 Oblique Total Assessment Completed")]
    public IEnumerable<CqlDate?>? Date_VR12_Oblique_Total_Assessment_Completed(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Date_VR12_Oblique_Total_Assessment_Completed, Date_VR12_Oblique_Total_Assessment_Completed_Compute);

    private const long _cacheIndex_Date_VR12_Oblique_Total_Assessment_Completed = 5787368887486105522L;

    private IEnumerable<CqlDate?>? Date_VR12_Oblique_Total_Assessment_Completed_Compute(CqlContext context)
    {
        CqlCode? a_ = this.VR_12_Mental_component_summary__MCS__score___oblique_method_T_score(context);
        IEnumerable<CqlCode?>? b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation?>? c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
        IEnumerable<Observation?>? d_ = Status_1_15_000.Instance.isAssessmentPerformed(context, c_);
        CqlCode? e_ = this.VR_12_Physical_component_summary__PCS__score___oblique_method_T_score(context);
        IEnumerable<CqlCode?>? f_ = context.Operators.ToList<CqlCode>(e_);
        IEnumerable<Observation?>? g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, f_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
        IEnumerable<Observation?>? h_ = Status_1_15_000.Instance.isAssessmentPerformed(context, g_);
        IEnumerable<ValueTuple<Observation?, Observation?>>? i_ = context.Operators.CrossJoin<Observation, Observation>(d_, h_);

        (CqlTupleMetadata, Observation? VR12MentalAssessment, Observation? VR12PhysicalAssessment)? j_(ValueTuple<Observation?, Observation?> _valueTuple) {
            (CqlTupleMetadata, Observation? VR12MentalAssessment, Observation? VR12PhysicalAssessment)? o_ = (CqlTupleMetadata_GAdRFKRaHUUGJcVHWQWRUjhRH, _valueTuple.Item1, _valueTuple.Item2);
            return o_;
        }


        bool? k_((CqlTupleMetadata, Observation? VR12MentalAssessment, Observation? VR12PhysicalAssessment)? tuple_gadrfkrahuugjcvhwqwrujhrh) {
            DataType? p_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Effective;
            object? q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
            CqlInterval<CqlDateTime?>? r_ = QICoreCommon_4_0_000.Instance.toInterval(context, q_);
            CqlDateTime? s_ = context.Operators.Start(r_);
            CqlDate? t_ = context.Operators.DateFrom(s_);
            DataType? u_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Effective;
            object? v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
            CqlInterval<CqlDateTime?>? w_ = QICoreCommon_4_0_000.Instance.toInterval(context, v_);
            CqlDateTime? x_ = context.Operators.Start(w_);
            CqlDate? y_ = context.Operators.DateFrom(x_);
            bool? z_ = context.Operators.SameAs(t_, y_, "day");
            DataType? aa_ = (tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment as Observation?)?.Value;
            object? ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
            bool? ac_ = context.Operators.Not((bool?)(ab_ is null));
            bool? ad_ = context.Operators.And(z_, ac_);
            DataType? ae_ = (tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment as Observation?)?.Value;
            object? af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
            bool? ag_ = context.Operators.Not((bool?)(af_ is null));
            bool? ah_ = context.Operators.And(ad_, ag_);
            return ah_;
        }

        IEnumerable<(CqlTupleMetadata, Observation? VR12MentalAssessment, Observation? VR12PhysicalAssessment)?>? l_ = context.Operators.SelectWhere<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?>(i_, j_, k_);

        CqlDate? m_((CqlTupleMetadata, Observation? VR12MentalAssessment, Observation? VR12PhysicalAssessment)? tuple_gadrfkrahuugjcvhwqwrujhrh) {
            DataType? ai_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Effective;
            object? aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
            CqlInterval<CqlDateTime?>? ak_ = QICoreCommon_4_0_000.Instance.toInterval(context, aj_);
            CqlDateTime? al_ = context.Operators.Start(ak_);
            CqlDate? am_ = context.Operators.DateFrom(al_);
            DataType? an_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Effective;
            object? ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
            CqlInterval<CqlDateTime?>? ap_ = QICoreCommon_4_0_000.Instance.toInterval(context, ao_);
            CqlDateTime? aq_ = context.Operators.Start(ap_);
            CqlDate? ar_ = context.Operators.DateFrom(aq_);
            CqlDate?[]? as_ = [
                am_,
                ar_,
            ];
            CqlDate? at_ = context.Operators.Max<CqlDate>((IEnumerable<CqlDate?>?)as_);
            return at_;
        }

        IEnumerable<CqlDate?>? n_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?, CqlDate>(l_, m_);
        return n_;
    }


    [CqlExpressionDefinition("Has THA with Initial and Follow Up VR12 Oblique Assessments")]
    public bool? Has_THA_with_Initial_and_Follow_Up_VR12_Oblique_Assessments(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_THA_with_Initial_and_Follow_Up_VR12_Oblique_Assessments, Has_THA_with_Initial_and_Follow_Up_VR12_Oblique_Assessments_Compute);

    private const long _cacheIndex_Has_THA_with_Initial_and_Follow_Up_VR12_Oblique_Assessments = -8857932199387856860L;

    private bool? Has_THA_with_Initial_and_Follow_Up_VR12_Oblique_Assessments_Compute(CqlContext context)
    {
        IEnumerable<Procedure?>? a_ = this.Total_Hip_Arthroplasty_Procedure(context);

        CqlInterval<CqlDateTime?>? b_(Procedure? THAProcedure) {
            object? h_;
            DataType? j_ = THAProcedure?.Performed;
            object? k_ = FHIRHelpers_4_4_000.Instance.ToValue(context, j_);
            bool l_ = k_ is CqlDateTime;
            if (l_)
            {
                DataType? m_ = THAProcedure?.Performed;
                object? n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
                h_ = n_ as CqlDateTime?;
            }
            else
            {
                DataType? o_ = THAProcedure?.Performed;
                object? p_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
                bool q_ = p_ is CqlQuantity;
                if (q_)
                {
                    DataType? r_ = THAProcedure?.Performed;
                    object? s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                    h_ = s_ as CqlQuantity?;
                }
                else
                {
                    DataType? t_ = THAProcedure?.Performed;
                    object? u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                    bool v_ = u_ is CqlInterval<CqlDateTime>;
                    if (v_)
                    {
                        DataType? w_ = THAProcedure?.Performed;
                        object? x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                        h_ = x_ as CqlInterval<CqlDateTime?>?;
                    }
                    else
                    {
                        DataType? y_ = THAProcedure?.Performed;
                        object? z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                        bool aa_ = z_ is CqlInterval<CqlQuantity>;
                        if (aa_)
                        {
                            DataType? ab_ = THAProcedure?.Performed;
                            object? ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                            h_ = ac_ as CqlInterval<CqlQuantity?>?;
                        }
                        else
                        {
                            h_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime?>? i_ = QICoreCommon_4_0_000.Instance.toInterval(context, h_);
            return i_;
        }

        IEnumerable<CqlInterval<CqlDateTime?>?>? c_ = context.Operators.SelectDistinct<Procedure, CqlInterval<CqlDateTime>>(a_, b_);

        bool? d_(CqlInterval<CqlDateTime?>? TotalHip) {
            IEnumerable<CqlDate?>? ad_ = this.Date_VR12_Oblique_Total_Assessment_Completed(context);

            bool? ae_(CqlDate? InitialHipAssessmentOblique) {
                CqlDateTime? ag_ = context.Operators.Start(TotalHip);
                CqlDateTime? ah_ = context.Operators.ConvertDateToDateTime(InitialHipAssessmentOblique);
                CqlQuantity? ai_ = context.Operators.Quantity(90m, "days");
                CqlDate? aj_ = context.Operators.Add(InitialHipAssessmentOblique, ai_);
                CqlDateTime? ak_ = context.Operators.ConvertDateToDateTime(aj_);
                CqlInterval<CqlDateTime?>? al_ = context.Operators.Interval(ah_, ak_, true, true);
                bool? am_ = context.Operators.In<CqlDateTime>(ag_, al_, "day");
                bool? an_ = context.Operators.Not((bool?)(InitialHipAssessmentOblique is null));
                bool? ao_ = context.Operators.And(am_, an_);
                return ao_;
            }

            bool? af_ = context.Operators.WhereAny<CqlDate>(ad_, ae_);
            return af_;
        }

        IEnumerable<CqlInterval<CqlDateTime?>?>? e_ = context.Operators.Where<CqlInterval<CqlDateTime>>(c_, d_);

        bool? f_(CqlInterval<CqlDateTime?>? TotalHip) {
            IEnumerable<CqlDate?>? ap_ = this.Date_VR12_Oblique_Total_Assessment_Completed(context);

            bool? aq_(CqlDate? FollowUpHipAssessmentOblique) {
                CqlDateTime? as_ = context.Operators.ConvertDateToDateTime(FollowUpHipAssessmentOblique);
                CqlDate? at_ = context.Operators.DateFrom(as_);
                CqlDateTime? au_ = context.Operators.End(TotalHip);
                CqlDate? av_ = context.Operators.DateFrom(au_);
                CqlQuantity? aw_ = context.Operators.Quantity(300m, "days");
                CqlDate? ax_ = context.Operators.Add(av_, aw_);
                CqlQuantity? ay_ = context.Operators.Quantity(425m, "days");
                CqlDate? az_ = context.Operators.Add(av_, ay_);
                CqlInterval<CqlDate?>? ba_ = context.Operators.Interval(ax_, az_, true, true);
                bool? bb_ = context.Operators.In<CqlDate>(at_, ba_, "day");
                return bb_;
            }

            bool? ar_ = context.Operators.WhereAny<CqlDate>(ap_, aq_);
            return ar_;
        }

        bool? g_ = context.Operators.WhereAny<CqlInterval<CqlDateTime>>(e_, f_);
        return g_;
    }


    [CqlExpressionDefinition("Date VR12 Orthogonal Total Assessment Completed")]
    public IEnumerable<CqlDate?>? Date_VR12_Orthogonal_Total_Assessment_Completed(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Date_VR12_Orthogonal_Total_Assessment_Completed, Date_VR12_Orthogonal_Total_Assessment_Completed_Compute);

    private const long _cacheIndex_Date_VR12_Orthogonal_Total_Assessment_Completed = 4960693320813654296L;

    private IEnumerable<CqlDate?>? Date_VR12_Orthogonal_Total_Assessment_Completed_Compute(CqlContext context)
    {
        CqlCode? a_ = this.VR_12_Mental_component_summary__MCS__score___orthogonal_method_T_score(context);
        IEnumerable<CqlCode?>? b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation?>? c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
        IEnumerable<Observation?>? d_ = Status_1_15_000.Instance.isAssessmentPerformed(context, c_);
        CqlCode? e_ = this.VR_12_Physical_component_summary__PCS__score___orthogonal_method_T_score(context);
        IEnumerable<CqlCode?>? f_ = context.Operators.ToList<CqlCode>(e_);
        IEnumerable<Observation?>? g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, f_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
        IEnumerable<Observation?>? h_ = Status_1_15_000.Instance.isAssessmentPerformed(context, g_);
        IEnumerable<ValueTuple<Observation?, Observation?>>? i_ = context.Operators.CrossJoin<Observation, Observation>(d_, h_);

        (CqlTupleMetadata, Observation? VR12MentalAssessment, Observation? VR12PhysicalAssessment)? j_(ValueTuple<Observation?, Observation?> _valueTuple) {
            (CqlTupleMetadata, Observation? VR12MentalAssessment, Observation? VR12PhysicalAssessment)? o_ = (CqlTupleMetadata_GAdRFKRaHUUGJcVHWQWRUjhRH, _valueTuple.Item1, _valueTuple.Item2);
            return o_;
        }


        bool? k_((CqlTupleMetadata, Observation? VR12MentalAssessment, Observation? VR12PhysicalAssessment)? tuple_gadrfkrahuugjcvhwqwrujhrh) {
            DataType? p_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Effective;
            object? q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
            CqlInterval<CqlDateTime?>? r_ = QICoreCommon_4_0_000.Instance.toInterval(context, q_);
            CqlDateTime? s_ = context.Operators.Start(r_);
            CqlDate? t_ = context.Operators.DateFrom(s_);
            DataType? u_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Effective;
            object? v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
            CqlInterval<CqlDateTime?>? w_ = QICoreCommon_4_0_000.Instance.toInterval(context, v_);
            CqlDateTime? x_ = context.Operators.Start(w_);
            CqlDate? y_ = context.Operators.DateFrom(x_);
            bool? z_ = context.Operators.SameAs(t_, y_, "day");
            DataType? aa_ = (tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment as Observation?)?.Value;
            object? ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
            bool? ac_ = context.Operators.Not((bool?)(ab_ is null));
            bool? ad_ = context.Operators.And(z_, ac_);
            DataType? ae_ = (tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment as Observation?)?.Value;
            object? af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
            bool? ag_ = context.Operators.Not((bool?)(af_ is null));
            bool? ah_ = context.Operators.And(ad_, ag_);
            return ah_;
        }

        IEnumerable<(CqlTupleMetadata, Observation? VR12MentalAssessment, Observation? VR12PhysicalAssessment)?>? l_ = context.Operators.SelectWhere<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?>(i_, j_, k_);

        CqlDate? m_((CqlTupleMetadata, Observation? VR12MentalAssessment, Observation? VR12PhysicalAssessment)? tuple_gadrfkrahuugjcvhwqwrujhrh) {
            DataType? ai_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Effective;
            object? aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
            CqlInterval<CqlDateTime?>? ak_ = QICoreCommon_4_0_000.Instance.toInterval(context, aj_);
            CqlDateTime? al_ = context.Operators.Start(ak_);
            CqlDate? am_ = context.Operators.DateFrom(al_);
            DataType? an_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Effective;
            object? ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
            CqlInterval<CqlDateTime?>? ap_ = QICoreCommon_4_0_000.Instance.toInterval(context, ao_);
            CqlDateTime? aq_ = context.Operators.Start(ap_);
            CqlDate? ar_ = context.Operators.DateFrom(aq_);
            CqlDate?[]? as_ = [
                am_,
                ar_,
            ];
            CqlDate? at_ = context.Operators.Max<CqlDate>((IEnumerable<CqlDate?>?)as_);
            return at_;
        }

        IEnumerable<CqlDate?>? n_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?, CqlDate>(l_, m_);
        return n_;
    }


    [CqlExpressionDefinition("Has THA with Initial and Follow Up VR12 Orthogonal Assessments")]
    public bool? Has_THA_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_THA_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments, Has_THA_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments_Compute);

    private const long _cacheIndex_Has_THA_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments = -9051604538390399750L;

    private bool? Has_THA_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments_Compute(CqlContext context)
    {
        IEnumerable<Procedure?>? a_ = this.Total_Hip_Arthroplasty_Procedure(context);

        CqlInterval<CqlDateTime?>? b_(Procedure? THAProcedure) {
            object? h_;
            DataType? j_ = THAProcedure?.Performed;
            object? k_ = FHIRHelpers_4_4_000.Instance.ToValue(context, j_);
            bool l_ = k_ is CqlDateTime;
            if (l_)
            {
                DataType? m_ = THAProcedure?.Performed;
                object? n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
                h_ = n_ as CqlDateTime?;
            }
            else
            {
                DataType? o_ = THAProcedure?.Performed;
                object? p_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
                bool q_ = p_ is CqlQuantity;
                if (q_)
                {
                    DataType? r_ = THAProcedure?.Performed;
                    object? s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                    h_ = s_ as CqlQuantity?;
                }
                else
                {
                    DataType? t_ = THAProcedure?.Performed;
                    object? u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                    bool v_ = u_ is CqlInterval<CqlDateTime>;
                    if (v_)
                    {
                        DataType? w_ = THAProcedure?.Performed;
                        object? x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                        h_ = x_ as CqlInterval<CqlDateTime?>?;
                    }
                    else
                    {
                        DataType? y_ = THAProcedure?.Performed;
                        object? z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                        bool aa_ = z_ is CqlInterval<CqlQuantity>;
                        if (aa_)
                        {
                            DataType? ab_ = THAProcedure?.Performed;
                            object? ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                            h_ = ac_ as CqlInterval<CqlQuantity?>?;
                        }
                        else
                        {
                            h_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime?>? i_ = QICoreCommon_4_0_000.Instance.toInterval(context, h_);
            return i_;
        }

        IEnumerable<CqlInterval<CqlDateTime?>?>? c_ = context.Operators.SelectDistinct<Procedure, CqlInterval<CqlDateTime>>(a_, b_);

        bool? d_(CqlInterval<CqlDateTime?>? TotalHip) {
            IEnumerable<CqlDate?>? ad_ = this.Date_VR12_Orthogonal_Total_Assessment_Completed(context);

            bool? ae_(CqlDate? InitialHipAssessmentOrthogonal) {
                CqlDateTime? ag_ = context.Operators.Start(TotalHip);
                CqlDateTime? ah_ = context.Operators.ConvertDateToDateTime(InitialHipAssessmentOrthogonal);
                CqlQuantity? ai_ = context.Operators.Quantity(90m, "days");
                CqlDate? aj_ = context.Operators.Add(InitialHipAssessmentOrthogonal, ai_);
                CqlDateTime? ak_ = context.Operators.ConvertDateToDateTime(aj_);
                CqlInterval<CqlDateTime?>? al_ = context.Operators.Interval(ah_, ak_, true, true);
                bool? am_ = context.Operators.In<CqlDateTime>(ag_, al_, "day");
                bool? an_ = context.Operators.Not((bool?)(InitialHipAssessmentOrthogonal is null));
                bool? ao_ = context.Operators.And(am_, an_);
                return ao_;
            }

            bool? af_ = context.Operators.WhereAny<CqlDate>(ad_, ae_);
            return af_;
        }

        IEnumerable<CqlInterval<CqlDateTime?>?>? e_ = context.Operators.Where<CqlInterval<CqlDateTime>>(c_, d_);

        bool? f_(CqlInterval<CqlDateTime?>? TotalHip) {
            IEnumerable<CqlDate?>? ap_ = this.Date_VR12_Orthogonal_Total_Assessment_Completed(context);

            bool? aq_(CqlDate? FollowUpHipAssessmentOrthogonal) {
                CqlDateTime? as_ = context.Operators.ConvertDateToDateTime(FollowUpHipAssessmentOrthogonal);
                CqlDate? at_ = context.Operators.DateFrom(as_);
                CqlDateTime? au_ = context.Operators.End(TotalHip);
                CqlDate? av_ = context.Operators.DateFrom(au_);
                CqlQuantity? aw_ = context.Operators.Quantity(300m, "days");
                CqlDate? ax_ = context.Operators.Add(av_, aw_);
                CqlQuantity? ay_ = context.Operators.Quantity(425m, "days");
                CqlDate? az_ = context.Operators.Add(av_, ay_);
                CqlInterval<CqlDate?>? ba_ = context.Operators.Interval(ax_, az_, true, true);
                bool? bb_ = context.Operators.In<CqlDate>(at_, ba_, "day");
                return bb_;
            }

            bool? ar_ = context.Operators.WhereAny<CqlDate>(ap_, aq_);
            return ar_;
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
