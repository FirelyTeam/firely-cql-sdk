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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "3.1.0.0")]
[CqlLibrary("FunctionalStatusAssessmentforTotalHipReplacementFHIR", "0.0.008")]
public partial class FunctionalStatusAssessmentforTotalHipReplacementFHIR_minus_0_0_008 : ILibrary, ISingleton<FunctionalStatusAssessmentforTotalHipReplacementFHIR_minus_0_0_008>
{
    private FunctionalStatusAssessmentforTotalHipReplacementFHIR_minus_0_0_008() {}

    public static FunctionalStatusAssessmentforTotalHipReplacementFHIR_minus_0_0_008 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "FunctionalStatusAssessmentforTotalHipReplacementFHIR";
    public string Version => "0.0.008";
    public ILibrary[] Dependencies => [FHIRHelpers_minus_4_4_000.Instance, QICoreCommon_minus_2_1_000.Instance, SupplementalDataElements_minus_3_5_000.Instance, Hospice_minus_6_12_000.Instance, Status_minus_1_8_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

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

    #region Codes

    [CqlCodeDefinition("Activities of daily living score [HOOS]", codeId: "72095-3", codeSystem: "http://loinc.org")]
    public CqlCode Activities_of_daily_living_score__HOOS_(CqlContext _) => _Activities_of_daily_living_score__HOOS_;
    private static readonly CqlCode _Activities_of_daily_living_score__HOOS_ = new CqlCode("72095-3", "http://loinc.org");

    [CqlCodeDefinition("Dead (finding)", codeId: "419099009", codeSystem: "http://snomed.info/sct")]
    public CqlCode Dead__finding_(CqlContext _) => _Dead__finding_;
    private static readonly CqlCode _Dead__finding_ = new CqlCode("419099009", "http://snomed.info/sct");

    [CqlCodeDefinition("Discharge to healthcare facility for hospice care (procedure)", codeId: "428371000124100", codeSystem: "http://snomed.info/sct")]
    public CqlCode Discharge_to_healthcare_facility_for_hospice_care__procedure_(CqlContext _) => _Discharge_to_healthcare_facility_for_hospice_care__procedure_;
    private static readonly CqlCode _Discharge_to_healthcare_facility_for_hospice_care__procedure_ = new CqlCode("428371000124100", "http://snomed.info/sct");

    [CqlCodeDefinition("Discharge to home for hospice care (procedure)", codeId: "428371000124100", codeSystem: "http://snomed.info/sct")]
    public CqlCode Discharge_to_home_for_hospice_care__procedure_(CqlContext _) => _Discharge_to_home_for_hospice_care__procedure_;
    private static readonly CqlCode _Discharge_to_home_for_hospice_care__procedure_ = new CqlCode("428371000124100", "http://snomed.info/sct");

    [CqlCodeDefinition("Hospice care [Minimum Data Set]", codeId: "45755-6", codeSystem: "http://loinc.org")]
    public CqlCode Hospice_care__Minimum_Data_Set_(CqlContext _) => _Hospice_care__Minimum_Data_Set_;
    private static readonly CqlCode _Hospice_care__Minimum_Data_Set_ = new CqlCode("45755-6", "http://loinc.org");

    [CqlCodeDefinition("Pain score [HOOS]", codeId: "72097-9", codeSystem: "http://loinc.org")]
    public CqlCode Pain_score__HOOS_(CqlContext _) => _Pain_score__HOOS_;
    private static readonly CqlCode _Pain_score__HOOS_ = new CqlCode("72097-9", "http://loinc.org");

    [CqlCodeDefinition("Postoperative follow-up visit, normally included in the surgical package, to indicate that an evaluation and management service was performed during a postoperative period for a reason(s) related to the original procedure", codeId: "99024", codeSystem: "http://www.ama-assn.org/go/cpt")]
    public CqlCode Postoperative_follow_minus_up_visit__normally_included_in_the_surgical_package__to_indicate_that_an_evaluation_and_management_service_was_performed_during_a_postoperative_period_for_a_reason_s__related_to_the_original_procedure(CqlContext _) => _Postoperative_follow_minus_up_visit__normally_included_in_the_surgical_package__to_indicate_that_an_evaluation_and_management_service_was_performed_during_a_postoperative_period_for_a_reason_s__related_to_the_original_procedure;
    private static readonly CqlCode _Postoperative_follow_minus_up_visit__normally_included_in_the_surgical_package__to_indicate_that_an_evaluation_and_management_service_was_performed_during_a_postoperative_period_for_a_reason_s__related_to_the_original_procedure = new CqlCode("99024", "http://www.ama-assn.org/go/cpt");

    [CqlCodeDefinition("PROMIS-10 Global Mental Health (GMH) score T-score", codeId: "71969-0", codeSystem: "http://loinc.org")]
    public CqlCode PROMIS_minus_10_Global_Mental_Health__GMH__score_T_minus_score(CqlContext _) => _PROMIS_minus_10_Global_Mental_Health__GMH__score_T_minus_score;
    private static readonly CqlCode _PROMIS_minus_10_Global_Mental_Health__GMH__score_T_minus_score = new CqlCode("71969-0", "http://loinc.org");

    [CqlCodeDefinition("PROMIS-10 Global Physical Health (GPH) score T-score", codeId: "71971-6", codeSystem: "http://loinc.org")]
    public CqlCode PROMIS_minus_10_Global_Physical_Health__GPH__score_T_minus_score(CqlContext _) => _PROMIS_minus_10_Global_Physical_Health__GPH__score_T_minus_score;
    private static readonly CqlCode _PROMIS_minus_10_Global_Physical_Health__GPH__score_T_minus_score = new CqlCode("71971-6", "http://loinc.org");

    [CqlCodeDefinition("Quality of life score [HOOS]", codeId: "72093-8", codeSystem: "http://loinc.org")]
    public CqlCode Quality_of_life_score__HOOS_(CqlContext _) => _Quality_of_life_score__HOOS_;
    private static readonly CqlCode _Quality_of_life_score__HOOS_ = new CqlCode("72093-8", "http://loinc.org");

    [CqlCodeDefinition("Severe cognitive impairment (finding)", codeId: "702956004", codeSystem: "http://snomed.info/sct")]
    public CqlCode Severe_cognitive_impairment__finding_(CqlContext _) => _Severe_cognitive_impairment__finding_;
    private static readonly CqlCode _Severe_cognitive_impairment__finding_ = new CqlCode("702956004", "http://snomed.info/sct");

    [CqlCodeDefinition("Sport-recreation score [HOOS]", codeId: "72094-6", codeSystem: "http://loinc.org")]
    public CqlCode Sport_minus_recreation_score__HOOS_(CqlContext _) => _Sport_minus_recreation_score__HOOS_;
    private static readonly CqlCode _Sport_minus_recreation_score__HOOS_ = new CqlCode("72094-6", "http://loinc.org");

    [CqlCodeDefinition("Symptoms score [HOOS]", codeId: "72096-1", codeSystem: "http://loinc.org")]
    public CqlCode Symptoms_score__HOOS_(CqlContext _) => _Symptoms_score__HOOS_;
    private static readonly CqlCode _Symptoms_score__HOOS_ = new CqlCode("72096-1", "http://loinc.org");

    [CqlCodeDefinition("Total interval score [HOOSJR]", codeId: "82323-7", codeSystem: "http://loinc.org")]
    public CqlCode Total_interval_score__HOOSJR_(CqlContext _) => _Total_interval_score__HOOSJR_;
    private static readonly CqlCode _Total_interval_score__HOOSJR_ = new CqlCode("82323-7", "http://loinc.org");

    [CqlCodeDefinition("VR-12 Mental component summary (MCS) score - oblique method T-score", codeId: "72026-8", codeSystem: "http://loinc.org")]
    public CqlCode VR_minus_12_Mental_component_summary__MCS__score__minus__oblique_method_T_minus_score(CqlContext _) => _VR_minus_12_Mental_component_summary__MCS__score__minus__oblique_method_T_minus_score;
    private static readonly CqlCode _VR_minus_12_Mental_component_summary__MCS__score__minus__oblique_method_T_minus_score = new CqlCode("72026-8", "http://loinc.org");

    [CqlCodeDefinition("VR-12 Mental component summary (MCS) score - orthogonal method T-score", codeId: "72028-4", codeSystem: "http://loinc.org")]
    public CqlCode VR_minus_12_Mental_component_summary__MCS__score__minus__orthogonal_method_T_minus_score(CqlContext _) => _VR_minus_12_Mental_component_summary__MCS__score__minus__orthogonal_method_T_minus_score;
    private static readonly CqlCode _VR_minus_12_Mental_component_summary__MCS__score__minus__orthogonal_method_T_minus_score = new CqlCode("72028-4", "http://loinc.org");

    [CqlCodeDefinition("VR-12 Physical component summary (PCS) score - oblique method T-score", codeId: "72025-0", codeSystem: "http://loinc.org")]
    public CqlCode VR_minus_12_Physical_component_summary__PCS__score__minus__oblique_method_T_minus_score(CqlContext _) => _VR_minus_12_Physical_component_summary__PCS__score__minus__oblique_method_T_minus_score;
    private static readonly CqlCode _VR_minus_12_Physical_component_summary__PCS__score__minus__oblique_method_T_minus_score = new CqlCode("72025-0", "http://loinc.org");

    [CqlCodeDefinition("VR-12 Physical component summary (PCS) score - orthogonal method T-score", codeId: "72027-6", codeSystem: "http://loinc.org")]
    public CqlCode VR_minus_12_Physical_component_summary__PCS__score__minus__orthogonal_method_T_minus_score(CqlContext _) => _VR_minus_12_Physical_component_summary__PCS__score__minus__orthogonal_method_T_minus_score;
    private static readonly CqlCode _VR_minus_12_Physical_component_summary__PCS__score__minus__orthogonal_method_T_minus_score = new CqlCode("72027-6", "http://loinc.org");

    [CqlCodeDefinition("Yes (qualifier value)", codeId: "373066001", codeSystem: "http://snomed.info/sct")]
    public CqlCode Yes__qualifier_value_(CqlContext _) => _Yes__qualifier_value_;
    private static readonly CqlCode _Yes__qualifier_value_ = new CqlCode("373066001", "http://snomed.info/sct");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC", codeSystemId: "http://loinc.org", codeSystemVersion: null)]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, [
          _Activities_of_daily_living_score__HOOS_,
          _Hospice_care__Minimum_Data_Set_,
          _Pain_score__HOOS_,
          _PROMIS_minus_10_Global_Mental_Health__GMH__score_T_minus_score,
          _PROMIS_minus_10_Global_Physical_Health__GPH__score_T_minus_score,
          _Quality_of_life_score__HOOS_,
          _Sport_minus_recreation_score__HOOS_,
          _Symptoms_score__HOOS_,
          _Total_interval_score__HOOSJR_,
          _VR_minus_12_Mental_component_summary__MCS__score__minus__oblique_method_T_minus_score,
          _VR_minus_12_Mental_component_summary__MCS__score__minus__orthogonal_method_T_minus_score,
          _VR_minus_12_Physical_component_summary__PCS__score__minus__oblique_method_T_minus_score,
          _VR_minus_12_Physical_component_summary__PCS__score__minus__orthogonal_method_T_minus_score]);

    [CqlCodeSystemDefinition("CPT", codeSystemId: "http://www.ama-assn.org/go/cpt", codeSystemVersion: null)]
    public CqlCodeSystem CPT(CqlContext _) => _CPT;
    private static readonly CqlCodeSystem _CPT =
      new CqlCodeSystem("http://www.ama-assn.org/go/cpt", null, [
          _Postoperative_follow_minus_up_visit__normally_included_in_the_surgical_package__to_indicate_that_an_evaluation_and_management_service_was_performed_during_a_postoperative_period_for_a_reason_s__related_to_the_original_procedure]);

    [CqlCodeSystemDefinition("SNOMEDCT", codeSystemId: "http://snomed.info/sct", codeSystemVersion: null)]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Dead__finding_,
          _Discharge_to_healthcare_facility_for_hospice_care__procedure_,
          _Discharge_to_healthcare_facility_for_hospice_care__procedure_,
          _Severe_cognitive_impairment__finding_,
          _Yes__qualifier_value_]);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, true);
        object d_ = context.ResolveParameter("FunctionalStatusAssessmentforTotalHipReplacementFHIR-0.0.008", "Measurement Period", c_);

        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

        return b_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_minus_3_5_000.Instance.SDE_Ethnicity(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Payer Type")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Type(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_minus_3_5_000.Instance.SDE_Payer(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_minus_3_5_000.Instance.SDE_Race(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_minus_3_5_000.Instance.SDE_Sex(context);

        return a_;
    }


    [CqlExpressionDefinition("August 1 Year Prior to the Measurement Period")]
    public CqlDateTime August_1_Year_Prior_to_the_Measurement_Period(CqlContext context)
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
    public bool? Has_Qualifying_Encounter(CqlContext context)
    {
        CqlValueSet a_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet c_ = this.Office_Visit(context);
        IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
        IEnumerable<Encounter> f_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? g_(Encounter E)
        {
            List<CodeableConcept> t_ = E?.Type;
            CqlConcept u_(CodeableConcept @this)
            {
                CqlConcept z_ = FHIRHelpers_minus_4_4_000.Instance.ToConcept(context, @this);

                return z_;
            };
            IEnumerable<CqlConcept> v_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)t_, u_);
            bool? w_(CqlConcept T)
            {
                CqlCode aa_ = this.Postoperative_follow_minus_up_visit__normally_included_in_the_surgical_package__to_indicate_that_an_evaluation_and_management_service_was_performed_during_a_postoperative_period_for_a_reason_s__related_to_the_original_procedure(context);
                CqlConcept ab_ = context.Operators.ConvertCodeToConcept(aa_);
                bool? ac_ = context.Operators.Equivalent(T, ab_);

                return ac_;
            };
            IEnumerable<CqlConcept> x_ = context.Operators.Where<CqlConcept>(v_, w_);
            bool? y_ = context.Operators.Exists<CqlConcept>(x_);

            return y_;
        };
        IEnumerable<Encounter> h_ = context.Operators.Where<Encounter>(f_, g_);
        CqlValueSet i_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> j_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(h_, j_);
        IEnumerable<Encounter> l_ = context.Operators.Union<Encounter>(e_, k_);
        CqlValueSet m_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> n_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, m_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> o_ = context.Operators.Union<Encounter>(l_, n_);
        IEnumerable<Encounter> p_ = Status_minus_1_8_000.Instance.isEncounterPerformed(context, o_);
        bool? q_(Encounter ValidEncounters)
        {
            CqlDateTime ad_ = this.August_1_Year_Prior_to_the_Measurement_Period(context);
            CqlInterval<CqlDateTime> ae_ = this.Measurement_Period(context);
            CqlDateTime af_ = context.Operators.End(ae_);
            CqlInterval<CqlDateTime> ag_ = context.Operators.Interval(ad_, af_, true, true);
            Period ah_ = ValidEncounters?.Period;
            CqlInterval<CqlDateTime> ai_ = FHIRHelpers_minus_4_4_000.Instance.ToInterval(context, ah_);
            CqlInterval<CqlDateTime> aj_ = QICoreCommon_minus_2_1_000.Instance.toInterval(context, ai_ as object);
            bool? ak_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ag_, aj_, "day");

            return ak_;
        };
        IEnumerable<Encounter> r_ = context.Operators.Where<Encounter>(p_, q_);
        bool? s_ = context.Operators.Exists<Encounter>(r_);

        return s_;
    }


    [CqlExpressionDefinition("November 1 Two Years Prior to the Measurement Period")]
    public CqlDateTime November_1_Two_Years_Prior_to_the_Measurement_Period(CqlContext context)
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
    public CqlDateTime October_31_Year_Prior_to_the_Measurement_Period(CqlContext context)
    {
        CqlInterval<CqlDateTime> a_ = this.Measurement_Period(context);
        CqlDateTime b_ = context.Operators.Start(a_);
        int? c_ = context.Operators.DateTimeComponentFrom(b_, "year");
        int? d_ = context.Operators.Subtract(c_, 1);
        decimal? e_ = context.Operators.ConvertIntegerToDecimal(0);
        CqlDateTime f_ = context.Operators.DateTime(d_, 10, 31, 23, 59, 59, 0, e_);

        return f_;
    }


    [CqlExpressionDefinition("Total Hip Arthroplasty Procedure")]
    public IEnumerable<Procedure> Total_Hip_Arthroplasty_Procedure(CqlContext context)
    {
        CqlValueSet a_ = this.Primary_THA_Procedure(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> c_ = Status_minus_1_8_000.Instance.isProcedurePerformed(context, b_);
        bool? d_(Procedure THAProcedure)
        {
            DataType f_ = THAProcedure?.Performed;
            object g_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, f_);
            CqlInterval<CqlDateTime> h_ = QICoreCommon_minus_2_1_000.Instance.toInterval(context, g_);
            CqlDateTime i_ = context.Operators.Start(h_);
            CqlDateTime j_ = this.November_1_Two_Years_Prior_to_the_Measurement_Period(context);
            CqlDateTime k_ = this.October_31_Year_Prior_to_the_Measurement_Period(context);
            CqlInterval<CqlDateTime> l_ = context.Operators.Interval(j_, k_, true, true);
            bool? m_ = context.Operators.In<CqlDateTime>(i_, l_, "day");

            return m_;
        };
        IEnumerable<Procedure> e_ = context.Operators.Where<Procedure>(c_, d_);

        return e_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
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
    public bool? Denominator(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);

        return a_;
    }


    [CqlExpressionDefinition("Has Severe Cognitive Impairment")]
    public bool? Has_Severe_Cognitive_Impairment(CqlContext context)
    {
        CqlCode a_ = this.Severe_cognitive_impairment__finding_(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? d_(Condition Dementia)
        {
            CqlInterval<CqlDateTime> g_ = QICoreCommon_minus_2_1_000.Instance.prevalenceInterval(context, Dementia);
            CqlInterval<CqlDateTime> h_ = this.Measurement_Period(context);
            bool? i_ = context.Operators.Overlaps(g_, h_, "day");

            return i_;
        };
        IEnumerable<Condition> e_ = context.Operators.Where<Condition>(c_, d_);
        bool? f_ = context.Operators.Exists<Condition>(e_);

        return f_;
    }


    [CqlExpressionDefinition("Has Total Hip Arthroplasty with 1 or More Lower Body Fractures")]
    public bool? Has_Total_Hip_Arthroplasty_with_1_or_More_Lower_Body_Fractures(CqlContext context)
    {
        IEnumerable<Procedure> a_ = this.Total_Hip_Arthroplasty_Procedure(context);
        IEnumerable<Procedure> b_(Procedure THAProcedure)
        {
            CqlValueSet e_ = this.Lower_Body_Fractures_Excluding_Ankle_and_Foot(context);
            IEnumerable<Condition> f_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? g_(Condition LowerBodyFracture)
            {
                CqlInterval<CqlDateTime> k_ = QICoreCommon_minus_2_1_000.Instance.prevalenceInterval(context, LowerBodyFracture);
                CqlDateTime l_ = context.Operators.Start(k_);
                DataType m_ = THAProcedure?.Performed;
                object n_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, m_);
                CqlInterval<CqlDateTime> o_ = QICoreCommon_minus_2_1_000.Instance.toInterval(context, n_);
                CqlDateTime p_ = context.Operators.Start(o_);
                CqlQuantity q_ = context.Operators.Quantity(24m, "hours");
                CqlDateTime r_ = context.Operators.Subtract(p_, q_);
                object t_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, m_);
                CqlInterval<CqlDateTime> u_ = QICoreCommon_minus_2_1_000.Instance.toInterval(context, t_);
                CqlDateTime v_ = context.Operators.Start(u_);
                CqlInterval<CqlDateTime> w_ = context.Operators.Interval(r_, v_, true, true);
                bool? x_ = context.Operators.In<CqlDateTime>(l_, w_, default);
                object z_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, m_);
                CqlInterval<CqlDateTime> aa_ = QICoreCommon_minus_2_1_000.Instance.toInterval(context, z_);
                CqlDateTime ab_ = context.Operators.Start(aa_);
                bool? ac_ = context.Operators.Not((bool?)(ab_ is null));
                bool? ad_ = context.Operators.And(x_, ac_);

                return ad_;
            };
            IEnumerable<Condition> h_ = context.Operators.Where<Condition>(f_, g_);
            Procedure i_(Condition LowerBodyFracture) =>
                THAProcedure;
            IEnumerable<Procedure> j_ = context.Operators.Select<Condition, Procedure>(h_, i_);

            return j_;
        };
        IEnumerable<Procedure> c_ = context.Operators.SelectMany<Procedure, Procedure>(a_, b_);
        bool? d_ = context.Operators.Exists<Procedure>(c_);

        return d_;
    }


    [CqlExpressionDefinition("Has Partial Hip Arthroplasty Procedure")]
    public bool? Has_Partial_Hip_Arthroplasty_Procedure(CqlContext context)
    {
        CqlValueSet a_ = this.Partial_Arthroplasty_of_Hip(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> c_ = Status_minus_1_8_000.Instance.isProcedurePerformed(context, b_);
        IEnumerable<Procedure> d_(Procedure PartialTHAProcedure)
        {
            IEnumerable<Procedure> g_ = this.Total_Hip_Arthroplasty_Procedure(context);
            bool? h_(Procedure THAProcedure)
            {
                DataType l_ = THAProcedure?.Performed;
                object m_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, l_);
                CqlInterval<CqlDateTime> n_ = QICoreCommon_minus_2_1_000.Instance.toInterval(context, m_);
                DataType o_ = PartialTHAProcedure?.Performed;
                object p_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, o_);
                CqlInterval<CqlDateTime> q_ = QICoreCommon_minus_2_1_000.Instance.toInterval(context, p_);
                bool? r_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(n_, q_, "day");

                return r_;
            };
            IEnumerable<Procedure> i_ = context.Operators.Where<Procedure>(g_, h_);
            Procedure j_(Procedure THAProcedure) =>
                PartialTHAProcedure;
            IEnumerable<Procedure> k_ = context.Operators.Select<Procedure, Procedure>(i_, j_);

            return k_;
        };
        IEnumerable<Procedure> e_ = context.Operators.SelectMany<Procedure, Procedure>(c_, d_);
        bool? f_ = context.Operators.Exists<Procedure>(e_);

        return f_;
    }


    [CqlExpressionDefinition("Has Revision Hip Arthroplasty Procedure or Implanted Device or Prosthesis Removal Procedure")]
    public bool? Has_Revision_Hip_Arthroplasty_Procedure_or_Implanted_Device_or_Prosthesis_Removal_Procedure(CqlContext context)
    {
        IEnumerable<Procedure> a_ = this.Total_Hip_Arthroplasty_Procedure(context);
        IEnumerable<Procedure> b_(Procedure THAProcedure)
        {
            CqlValueSet e_ = this.Removal__Revision_and_Supplement_Procedures_of_the_Lower_Body_and_Spine(context);
            IEnumerable<Procedure> f_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            IEnumerable<Procedure> g_ = Status_minus_1_8_000.Instance.isProcedurePerformed(context, f_);
            bool? h_(Procedure RevisionTHAProcedure)
            {
                DataType l_ = THAProcedure?.Performed;
                object m_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, l_);
                CqlInterval<CqlDateTime> n_ = QICoreCommon_minus_2_1_000.Instance.toInterval(context, m_);
                DataType o_ = RevisionTHAProcedure?.Performed;
                object p_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, o_);
                CqlInterval<CqlDateTime> q_ = QICoreCommon_minus_2_1_000.Instance.toInterval(context, p_);
                bool? r_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(n_, q_, "day");

                return r_;
            };
            IEnumerable<Procedure> i_ = context.Operators.Where<Procedure>(g_, h_);
            Procedure j_(Procedure RevisionTHAProcedure) =>
                THAProcedure;
            IEnumerable<Procedure> k_ = context.Operators.Select<Procedure, Procedure>(i_, j_);

            return k_;
        };
        IEnumerable<Procedure> c_ = context.Operators.SelectMany<Procedure, Procedure>(a_, b_);
        bool? d_ = context.Operators.Exists<Procedure>(c_);

        return d_;
    }


    [CqlExpressionDefinition("Has Malignant Neoplasm of Lower and Unspecified Limbs")]
    public bool? Has_Malignant_Neoplasm_of_Lower_and_Unspecified_Limbs(CqlContext context)
    {
        CqlValueSet a_ = this.Malignant_Neoplasms_of_Lower_and_Unspecified_Limbs(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> c_(Condition MalignantNeoplasm)
        {
            IEnumerable<Procedure> f_ = this.Total_Hip_Arthroplasty_Procedure(context);
            bool? g_(Procedure THAProcedure)
            {
                CqlInterval<CqlDateTime> k_ = QICoreCommon_minus_2_1_000.Instance.prevalenceInterval(context, MalignantNeoplasm);
                DataType l_ = THAProcedure?.Performed;
                object m_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, l_);
                CqlInterval<CqlDateTime> n_ = QICoreCommon_minus_2_1_000.Instance.toInterval(context, m_);
                bool? o_ = context.Operators.Overlaps(k_, n_, "day");

                return o_;
            };
            IEnumerable<Procedure> h_ = context.Operators.Where<Procedure>(f_, g_);
            Condition i_(Procedure THAProcedure) =>
                MalignantNeoplasm;
            IEnumerable<Condition> j_ = context.Operators.Select<Procedure, Condition>(h_, i_);

            return j_;
        };
        IEnumerable<Condition> d_ = context.Operators.SelectMany<Condition, Condition>(b_, c_);
        bool? e_ = context.Operators.Exists<Condition>(d_);

        return e_;
    }


    [CqlExpressionDefinition("Has Mechanical Complication")]
    public bool? Has_Mechanical_Complication(CqlContext context)
    {
        CqlValueSet a_ = this.Mechanical_Complications_Excluding_Upper_Body(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> c_(Condition MechanicalComplications)
        {
            IEnumerable<Procedure> f_ = this.Total_Hip_Arthroplasty_Procedure(context);
            bool? g_(Procedure THAProcedure)
            {
                CqlInterval<CqlDateTime> k_ = QICoreCommon_minus_2_1_000.Instance.prevalenceInterval(context, MechanicalComplications);
                DataType l_ = THAProcedure?.Performed;
                object m_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, l_);
                CqlInterval<CqlDateTime> n_ = QICoreCommon_minus_2_1_000.Instance.toInterval(context, m_);
                bool? o_ = context.Operators.Overlaps(k_, n_, "day");

                return o_;
            };
            IEnumerable<Procedure> h_ = context.Operators.Where<Procedure>(f_, g_);
            Condition i_(Procedure THAProcedure) =>
                MechanicalComplications;
            IEnumerable<Condition> j_ = context.Operators.Select<Procedure, Condition>(h_, i_);

            return j_;
        };
        IEnumerable<Condition> d_ = context.Operators.SelectMany<Condition, Condition>(b_, c_);
        bool? e_ = context.Operators.Exists<Condition>(d_);

        return e_;
    }


    [CqlExpressionDefinition("Has More Than One Elective Primary Total Hip Arthroplasty Performed")]
    public bool? Has_More_Than_One_Elective_Primary_Total_Hip_Arthroplasty_Performed(CqlContext context)
    {
        IEnumerable<Procedure> a_ = this.Total_Hip_Arthroplasty_Procedure(context);
        IEnumerable<Procedure> b_(Procedure THAProcedure)
        {
            CqlValueSet e_ = this.Primary_THA_Procedure(context);
            IEnumerable<Procedure> f_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            IEnumerable<Procedure> g_ = Status_minus_1_8_000.Instance.isProcedurePerformed(context, f_);
            bool? h_(Procedure ElectiveTHAProcedure)
            {
                Id l_ = THAProcedure?.IdElement;
                string m_ = l_?.Value;
                Id n_ = ElectiveTHAProcedure?.IdElement;
                string o_ = n_?.Value;
                bool? p_ = context.Operators.Equivalent(m_, o_);
                bool? q_ = context.Operators.Not(p_);
                DataType r_ = ElectiveTHAProcedure?.Performed;
                object s_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, r_);
                CqlInterval<CqlDateTime> t_ = QICoreCommon_minus_2_1_000.Instance.toInterval(context, s_);
                CqlDateTime u_ = context.Operators.Start(t_);
                DataType v_ = THAProcedure?.Performed;
                object w_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, v_);
                CqlInterval<CqlDateTime> x_ = QICoreCommon_minus_2_1_000.Instance.toInterval(context, w_);
                CqlDateTime y_ = context.Operators.Start(x_);
                CqlQuantity z_ = context.Operators.Quantity(1m, "year");
                CqlDateTime aa_ = context.Operators.Subtract(y_, z_);
                object ac_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, v_);
                CqlInterval<CqlDateTime> ad_ = QICoreCommon_minus_2_1_000.Instance.toInterval(context, ac_);
                CqlDateTime ae_ = context.Operators.Start(ad_);
                CqlDateTime ag_ = context.Operators.Add(ae_, z_);
                CqlInterval<CqlDateTime> ah_ = context.Operators.Interval(aa_, ag_, true, true);
                bool? ai_ = context.Operators.In<CqlDateTime>(u_, ah_, "day");
                bool? aj_ = context.Operators.And(q_, ai_);

                return aj_;
            };
            IEnumerable<Procedure> i_ = context.Operators.Where<Procedure>(g_, h_);
            Procedure j_(Procedure ElectiveTHAProcedure) =>
                THAProcedure;
            IEnumerable<Procedure> k_ = context.Operators.Select<Procedure, Procedure>(i_, j_);

            return k_;
        };
        IEnumerable<Procedure> c_ = context.Operators.SelectMany<Procedure, Procedure>(a_, b_);
        bool? d_ = context.Operators.Exists<Procedure>(c_);

        return d_;
    }


    [CqlExpressionDefinition("Death Within 300 Days of the THA Procedure")]
    public bool? Death_Within_300_Days_of_the_THA_Procedure(CqlContext context)
    {
        IEnumerable<Procedure> a_ = this.Total_Hip_Arthroplasty_Procedure(context);
        bool? b_(Procedure THAProcedure)
        {
            Patient e_ = this.Patient(context);
            DataType f_ = e_?.Deceased;
            object g_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, f_);
            CqlDate h_ = context.Operators.DateFrom(g_ as CqlDateTime);
            DataType i_ = THAProcedure?.Performed;
            object j_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, i_);
            CqlInterval<CqlDateTime> k_ = QICoreCommon_minus_2_1_000.Instance.toInterval(context, j_);
            CqlDateTime l_ = context.Operators.Start(k_);
            CqlDate m_ = context.Operators.DateFrom(l_);
            object o_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, i_);
            CqlInterval<CqlDateTime> p_ = QICoreCommon_minus_2_1_000.Instance.toInterval(context, o_);
            CqlDateTime q_ = context.Operators.Start(p_);
            CqlDate r_ = context.Operators.DateFrom(q_);
            CqlQuantity s_ = context.Operators.Quantity(300m, "days");
            CqlDate t_ = context.Operators.Add(r_, s_);
            CqlInterval<CqlDate> u_ = context.Operators.Interval(m_, t_, true, true);
            bool? v_ = context.Operators.In<CqlDate>(h_, u_, "day");

            return v_;
        };
        IEnumerable<Procedure> c_ = context.Operators.Where<Procedure>(a_, b_);
        bool? d_ = context.Operators.Exists<Procedure>(c_);

        return d_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? a_ = Hospice_minus_6_12_000.Instance.Has_Hospice_Services(context);
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
    public IEnumerable<CqlDate> Date_HOOS_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode a_ = this.Quality_of_life_score__HOOS_(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> d_ = Status_minus_1_8_000.Instance.isAssessmentPerformed(context, c_);
        CqlCode e_ = this.Sport_minus_recreation_score__HOOS_(context);
        IEnumerable<CqlCode> f_ = context.Operators.ToList<CqlCode>(e_);
        IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, f_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> h_ = Status_minus_1_8_000.Instance.isAssessmentPerformed(context, g_);
        CqlCode i_ = this.Activities_of_daily_living_score__HOOS_(context);
        IEnumerable<CqlCode> j_ = context.Operators.ToList<CqlCode>(i_);
        IEnumerable<Observation> k_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, j_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> l_ = Status_minus_1_8_000.Instance.isAssessmentPerformed(context, k_);
        CqlCode m_ = this.Symptoms_score__HOOS_(context);
        IEnumerable<CqlCode> n_ = context.Operators.ToList<CqlCode>(m_);
        IEnumerable<Observation> o_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, n_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> p_ = Status_minus_1_8_000.Instance.isAssessmentPerformed(context, o_);
        CqlCode q_ = this.Pain_score__HOOS_(context);
        IEnumerable<CqlCode> r_ = context.Operators.ToList<CqlCode>(q_);
        IEnumerable<Observation> s_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, r_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> t_ = Status_minus_1_8_000.Instance.isAssessmentPerformed(context, s_);
        IEnumerable<ValueTuple<Observation, Observation, Observation, Observation, Observation>> u_ = context.Operators.CrossJoin<Observation, Observation, Observation, Observation, Observation>(d_, h_, l_, p_, t_);
        (CqlTupleMetadata, Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)? v_(ValueTuple<Observation, Observation, Observation, Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)? ac_ = (CqlTupleMetadata_GVNUVHGXYWXVGgfjdTEahUfhP, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3, _valueTuple.Item4, _valueTuple.Item5);

            return ac_;
        };
        IEnumerable<(CqlTupleMetadata, Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)?> w_ = context.Operators.Select<ValueTuple<Observation, Observation, Observation, Observation, Observation>, (CqlTupleMetadata, Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)?>(u_, v_);
        bool? x_((CqlTupleMetadata, Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)? tuple_eipfmazvhfscjijaofhicpvmb)
        {
            DataType ad_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSLifeQuality?.Effective;
            object ae_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, ad_);
            CqlInterval<CqlDateTime> af_ = QICoreCommon_minus_2_1_000.Instance.toInterval(context, ae_);
            CqlDateTime ag_ = context.Operators.Start(af_);
            CqlDate ah_ = context.Operators.DateFrom(ag_);
            DataType ai_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSSport?.Effective;
            object aj_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, ai_);
            CqlInterval<CqlDateTime> ak_ = QICoreCommon_minus_2_1_000.Instance.toInterval(context, aj_);
            CqlDateTime al_ = context.Operators.Start(ak_);
            CqlDate am_ = context.Operators.DateFrom(al_);
            bool? an_ = context.Operators.SameAs(ah_, am_, "day");
            DataType ao_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSSport?.Value;
            object ap_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, ao_);
            bool? aq_ = context.Operators.Not((bool?)(ap_ is null));
            bool? ar_ = context.Operators.And(an_, aq_);
            object at_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, ad_);
            CqlInterval<CqlDateTime> au_ = QICoreCommon_minus_2_1_000.Instance.toInterval(context, at_);
            CqlDateTime av_ = context.Operators.Start(au_);
            CqlDate aw_ = context.Operators.DateFrom(av_);
            DataType ax_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSActivityScore?.Effective;
            object ay_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, ax_);
            CqlInterval<CqlDateTime> az_ = QICoreCommon_minus_2_1_000.Instance.toInterval(context, ay_);
            CqlDateTime ba_ = context.Operators.Start(az_);
            CqlDate bb_ = context.Operators.DateFrom(ba_);
            bool? bc_ = context.Operators.SameAs(aw_, bb_, "day");
            bool? bd_ = context.Operators.And(ar_, bc_);
            DataType be_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSActivityScore?.Value;
            object bf_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, be_);
            bool? bg_ = context.Operators.Not((bool?)(bf_ is null));
            bool? bh_ = context.Operators.And(bd_, bg_);
            object bj_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, ad_);
            CqlInterval<CqlDateTime> bk_ = QICoreCommon_minus_2_1_000.Instance.toInterval(context, bj_);
            CqlDateTime bl_ = context.Operators.Start(bk_);
            CqlDate bm_ = context.Operators.DateFrom(bl_);
            DataType bn_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSSymptoms?.Effective;
            object bo_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, bn_);
            CqlInterval<CqlDateTime> bp_ = QICoreCommon_minus_2_1_000.Instance.toInterval(context, bo_);
            CqlDateTime bq_ = context.Operators.Start(bp_);
            CqlDate br_ = context.Operators.DateFrom(bq_);
            bool? bs_ = context.Operators.SameAs(bm_, br_, "day");
            bool? bt_ = context.Operators.And(bh_, bs_);
            DataType bu_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSSymptoms?.Value;
            object bv_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, bu_);
            bool? bw_ = context.Operators.Not((bool?)(bv_ is null));
            bool? bx_ = context.Operators.And(bt_, bw_);
            object bz_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, ad_);
            CqlInterval<CqlDateTime> ca_ = QICoreCommon_minus_2_1_000.Instance.toInterval(context, bz_);
            CqlDateTime cb_ = context.Operators.Start(ca_);
            CqlDate cc_ = context.Operators.DateFrom(cb_);
            DataType cd_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSPain?.Effective;
            object ce_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, cd_);
            CqlInterval<CqlDateTime> cf_ = QICoreCommon_minus_2_1_000.Instance.toInterval(context, ce_);
            CqlDateTime cg_ = context.Operators.Start(cf_);
            CqlDate ch_ = context.Operators.DateFrom(cg_);
            bool? ci_ = context.Operators.SameAs(cc_, ch_, "day");
            bool? cj_ = context.Operators.And(bx_, ci_);
            DataType ck_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSPain?.Value;
            object cl_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, ck_);
            bool? cm_ = context.Operators.Not((bool?)(cl_ is null));
            bool? cn_ = context.Operators.And(cj_, cm_);
            DataType co_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSLifeQuality?.Value;
            object cp_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, co_);
            bool? cq_ = context.Operators.Not((bool?)(cp_ is null));
            bool? cr_ = context.Operators.And(cn_, cq_);

            return cr_;
        };
        IEnumerable<(CqlTupleMetadata, Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)?> y_ = context.Operators.Where<(CqlTupleMetadata, Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)?>(w_, x_);
        CqlDate z_((CqlTupleMetadata, Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)? tuple_eipfmazvhfscjijaofhicpvmb)
        {
            DataType cs_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSLifeQuality?.Effective;
            object ct_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, cs_);
            CqlInterval<CqlDateTime> cu_ = QICoreCommon_minus_2_1_000.Instance.toInterval(context, ct_);
            CqlDateTime cv_ = context.Operators.Start(cu_);
            CqlDate cw_ = context.Operators.DateFrom(cv_);
            DataType cx_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSSport?.Effective;
            object cy_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, cx_);
            CqlInterval<CqlDateTime> cz_ = QICoreCommon_minus_2_1_000.Instance.toInterval(context, cy_);
            CqlDateTime da_ = context.Operators.Start(cz_);
            CqlDate db_ = context.Operators.DateFrom(da_);
            DataType dc_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSActivityScore?.Effective;
            object dd_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, dc_);
            CqlInterval<CqlDateTime> de_ = QICoreCommon_minus_2_1_000.Instance.toInterval(context, dd_);
            CqlDateTime df_ = context.Operators.Start(de_);
            CqlDate dg_ = context.Operators.DateFrom(df_);
            DataType dh_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSSymptoms?.Effective;
            object di_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, dh_);
            CqlInterval<CqlDateTime> dj_ = QICoreCommon_minus_2_1_000.Instance.toInterval(context, di_);
            CqlDateTime dk_ = context.Operators.Start(dj_);
            CqlDate dl_ = context.Operators.DateFrom(dk_);
            DataType dm_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSPain?.Effective;
            object dn_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, dm_);
            CqlInterval<CqlDateTime> do_ = QICoreCommon_minus_2_1_000.Instance.toInterval(context, dn_);
            CqlDateTime dp_ = context.Operators.Start(do_);
            CqlDate dq_ = context.Operators.DateFrom(dp_);
            CqlDate[] dr_ = [
                cw_,
                db_,
                dg_,
                dl_,
                dq_,
            ];
            CqlDate ds_ = context.Operators.Max<CqlDate>(dr_ as IEnumerable<CqlDate>);

            return ds_;
        };
        IEnumerable<CqlDate> aa_ = context.Operators.Select<(CqlTupleMetadata, Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)?, CqlDate>(y_, z_);
        IEnumerable<CqlDate> ab_ = context.Operators.Distinct<CqlDate>(aa_);

        return ab_;
    }


    [CqlExpressionDefinition("Has THA with Initial and Follow Up HOOS Assessments")]
    public bool? Has_THA_with_Initial_and_Follow_Up_HOOS_Assessments(CqlContext context)
    {
        IEnumerable<Procedure> a_ = this.Total_Hip_Arthroplasty_Procedure(context);
        CqlInterval<CqlDateTime> b_(Procedure THAProcedure)
        {
            DataType j_ = THAProcedure?.Performed;
            object k_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, j_);
            CqlInterval<CqlDateTime> l_ = QICoreCommon_minus_2_1_000.Instance.toInterval(context, k_);

            return l_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.Select<Procedure, CqlInterval<CqlDateTime>>(a_, b_);
        IEnumerable<CqlInterval<CqlDateTime>> d_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(c_);
        IEnumerable<CqlInterval<CqlDateTime>> e_(CqlInterval<CqlDateTime> TotalHip)
        {
            IEnumerable<CqlDate> m_ = this.Date_HOOS_Total_Assessment_Completed(context);
            bool? n_(CqlDate InitialHipAssessmentHOOS)
            {
                CqlDateTime r_ = context.Operators.Start(TotalHip);
                CqlQuantity s_ = context.Operators.Quantity(90m, "days");
                CqlDate t_ = context.Operators.Add(InitialHipAssessmentHOOS, s_);
                CqlInterval<CqlDate> u_ = context.Operators.Interval(InitialHipAssessmentHOOS, t_, true, true);
                CqlDate v_ = u_?.low;
                CqlDateTime w_ = context.Operators.ConvertDateToDateTime(v_);
                CqlDate y_ = context.Operators.Add(InitialHipAssessmentHOOS, s_);
                CqlInterval<CqlDate> z_ = context.Operators.Interval(InitialHipAssessmentHOOS, y_, true, true);
                CqlDate aa_ = z_?.high;
                CqlDateTime ab_ = context.Operators.ConvertDateToDateTime(aa_);
                CqlDate ad_ = context.Operators.Add(InitialHipAssessmentHOOS, s_);
                CqlInterval<CqlDate> ae_ = context.Operators.Interval(InitialHipAssessmentHOOS, ad_, true, true);
                bool? af_ = ae_?.lowClosed;
                CqlDate ah_ = context.Operators.Add(InitialHipAssessmentHOOS, s_);
                CqlInterval<CqlDate> ai_ = context.Operators.Interval(InitialHipAssessmentHOOS, ah_, true, true);
                bool? aj_ = ai_?.highClosed;
                CqlInterval<CqlDateTime> ak_ = context.Operators.Interval(w_, ab_, af_, aj_);
                bool? al_ = context.Operators.In<CqlDateTime>(r_, ak_, "day");
                bool? am_ = context.Operators.Not((bool?)(InitialHipAssessmentHOOS is null));
                bool? an_ = context.Operators.And(al_, am_);

                return an_;
            };
            IEnumerable<CqlDate> o_ = context.Operators.Where<CqlDate>(m_, n_);
            CqlInterval<CqlDateTime> p_(CqlDate InitialHipAssessmentHOOS) =>
                TotalHip;
            IEnumerable<CqlInterval<CqlDateTime>> q_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(o_, p_);

            return q_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> f_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(d_, e_);
        IEnumerable<CqlInterval<CqlDateTime>> g_(CqlInterval<CqlDateTime> TotalHip)
        {
            IEnumerable<CqlDate> ao_ = this.Date_HOOS_Total_Assessment_Completed(context);
            bool? ap_(CqlDate FollowUpHipAssessmentHOOS)
            {
                CqlDateTime at_ = context.Operators.ConvertDateToDateTime(FollowUpHipAssessmentHOOS);
                CqlDate au_ = context.Operators.DateFrom(at_);
                CqlDateTime av_ = context.Operators.End(TotalHip);
                CqlDate aw_ = context.Operators.DateFrom(av_);
                CqlQuantity ax_ = context.Operators.Quantity(300m, "days");
                CqlDate ay_ = context.Operators.Add(aw_, ax_);
                CqlDate ba_ = context.Operators.DateFrom(av_);
                CqlQuantity bb_ = context.Operators.Quantity(425m, "days");
                CqlDate bc_ = context.Operators.Add(ba_, bb_);
                CqlInterval<CqlDate> bd_ = context.Operators.Interval(ay_, bc_, true, true);
                bool? be_ = context.Operators.In<CqlDate>(au_, bd_, "day");

                return be_;
            };
            IEnumerable<CqlDate> aq_ = context.Operators.Where<CqlDate>(ao_, ap_);
            CqlInterval<CqlDateTime> ar_(CqlDate FollowUpHipAssessmentHOOS) =>
                TotalHip;
            IEnumerable<CqlInterval<CqlDateTime>> as_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(aq_, ar_);

            return as_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> h_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(f_, g_);
        bool? i_ = context.Operators.Exists<CqlInterval<CqlDateTime>>(h_);

        return i_;
    }


    [CqlExpressionDefinition("Date HOOSJr Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_HOOSJr_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode a_ = this.Total_interval_score__HOOSJR_(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> d_ = Status_minus_1_8_000.Instance.isAssessmentPerformed(context, c_);
        bool? e_(Observation HOOSJr)
        {
            DataType j_ = HOOSJr?.Value;
            object k_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, j_);
            bool? l_ = context.Operators.Not((bool?)(k_ is null));

            return l_;
        };
        IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);
        CqlDate g_(Observation DocumentedHOOSJr)
        {
            DataType m_ = DocumentedHOOSJr?.Effective;
            object n_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, m_);
            CqlInterval<CqlDateTime> o_ = QICoreCommon_minus_2_1_000.Instance.toInterval(context, n_);
            CqlDateTime p_ = context.Operators.Start(o_);
            CqlDate q_ = context.Operators.DateFrom(p_);

            return q_;
        };
        IEnumerable<CqlDate> h_ = context.Operators.Select<Observation, CqlDate>(f_, g_);
        IEnumerable<CqlDate> i_ = context.Operators.Distinct<CqlDate>(h_);

        return i_;
    }


    [CqlExpressionDefinition("Has THA with Initial and Follow Up HOOSJr Assessments")]
    public bool? Has_THA_with_Initial_and_Follow_Up_HOOSJr_Assessments(CqlContext context)
    {
        IEnumerable<Procedure> a_ = this.Total_Hip_Arthroplasty_Procedure(context);
        CqlInterval<CqlDateTime> b_(Procedure THAProcedure)
        {
            DataType j_ = THAProcedure?.Performed;
            object k_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, j_);
            CqlInterval<CqlDateTime> l_ = QICoreCommon_minus_2_1_000.Instance.toInterval(context, k_);

            return l_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.Select<Procedure, CqlInterval<CqlDateTime>>(a_, b_);
        IEnumerable<CqlInterval<CqlDateTime>> d_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(c_);
        IEnumerable<CqlInterval<CqlDateTime>> e_(CqlInterval<CqlDateTime> TotalHip)
        {
            IEnumerable<CqlDate> m_ = this.Date_HOOSJr_Total_Assessment_Completed(context);
            bool? n_(CqlDate InitialHipAssessment)
            {
                CqlDateTime r_ = context.Operators.Start(TotalHip);
                CqlQuantity s_ = context.Operators.Quantity(90m, "days");
                CqlDate t_ = context.Operators.Add(InitialHipAssessment, s_);
                CqlInterval<CqlDate> u_ = context.Operators.Interval(InitialHipAssessment, t_, true, true);
                CqlDate v_ = u_?.low;
                CqlDateTime w_ = context.Operators.ConvertDateToDateTime(v_);
                CqlDate y_ = context.Operators.Add(InitialHipAssessment, s_);
                CqlInterval<CqlDate> z_ = context.Operators.Interval(InitialHipAssessment, y_, true, true);
                CqlDate aa_ = z_?.high;
                CqlDateTime ab_ = context.Operators.ConvertDateToDateTime(aa_);
                CqlDate ad_ = context.Operators.Add(InitialHipAssessment, s_);
                CqlInterval<CqlDate> ae_ = context.Operators.Interval(InitialHipAssessment, ad_, true, true);
                bool? af_ = ae_?.lowClosed;
                CqlDate ah_ = context.Operators.Add(InitialHipAssessment, s_);
                CqlInterval<CqlDate> ai_ = context.Operators.Interval(InitialHipAssessment, ah_, true, true);
                bool? aj_ = ai_?.highClosed;
                CqlInterval<CqlDateTime> ak_ = context.Operators.Interval(w_, ab_, af_, aj_);
                bool? al_ = context.Operators.In<CqlDateTime>(r_, ak_, "day");
                bool? am_ = context.Operators.Not((bool?)(InitialHipAssessment is null));
                bool? an_ = context.Operators.And(al_, am_);

                return an_;
            };
            IEnumerable<CqlDate> o_ = context.Operators.Where<CqlDate>(m_, n_);
            CqlInterval<CqlDateTime> p_(CqlDate InitialHipAssessment) =>
                TotalHip;
            IEnumerable<CqlInterval<CqlDateTime>> q_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(o_, p_);

            return q_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> f_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(d_, e_);
        IEnumerable<CqlInterval<CqlDateTime>> g_(CqlInterval<CqlDateTime> TotalHip)
        {
            IEnumerable<CqlDate> ao_ = this.Date_HOOSJr_Total_Assessment_Completed(context);
            bool? ap_(CqlDate FollowUpHipAssessment)
            {
                CqlDateTime at_ = context.Operators.ConvertDateToDateTime(FollowUpHipAssessment);
                CqlDate au_ = context.Operators.DateFrom(at_);
                CqlDateTime av_ = context.Operators.End(TotalHip);
                CqlDate aw_ = context.Operators.DateFrom(av_);
                CqlQuantity ax_ = context.Operators.Quantity(300m, "days");
                CqlDate ay_ = context.Operators.Add(aw_, ax_);
                CqlDate ba_ = context.Operators.DateFrom(av_);
                CqlQuantity bb_ = context.Operators.Quantity(425m, "days");
                CqlDate bc_ = context.Operators.Add(ba_, bb_);
                CqlInterval<CqlDate> bd_ = context.Operators.Interval(ay_, bc_, true, true);
                bool? be_ = context.Operators.In<CqlDate>(au_, bd_, "day");

                return be_;
            };
            IEnumerable<CqlDate> aq_ = context.Operators.Where<CqlDate>(ao_, ap_);
            CqlInterval<CqlDateTime> ar_(CqlDate FollowUpHipAssessment) =>
                TotalHip;
            IEnumerable<CqlInterval<CqlDateTime>> as_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(aq_, ar_);

            return as_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> h_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(f_, g_);
        bool? i_ = context.Operators.Exists<CqlInterval<CqlDateTime>>(h_);

        return i_;
    }


    [CqlExpressionDefinition("Date PROMIS10 Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_PROMIS10_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode a_ = this.PROMIS_minus_10_Global_Mental_Health__GMH__score_T_minus_score(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> d_ = Status_minus_1_8_000.Instance.isAssessmentPerformed(context, c_);
        CqlCode e_ = this.PROMIS_minus_10_Global_Physical_Health__GPH__score_T_minus_score(context);
        IEnumerable<CqlCode> f_ = context.Operators.ToList<CqlCode>(e_);
        IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, f_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> h_ = Status_minus_1_8_000.Instance.isAssessmentPerformed(context, g_);
        IEnumerable<ValueTuple<Observation, Observation>> i_ = context.Operators.CrossJoin<Observation, Observation>(d_, h_);
        (CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)? j_(ValueTuple<Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)? q_ = (CqlTupleMetadata_DDTAOdcFieSJbGgRLLZPYbGQb, _valueTuple.Item1, _valueTuple.Item2);

            return q_;
        };
        IEnumerable<(CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?> k_ = context.Operators.Select<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?>(i_, j_);
        bool? l_((CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)? tuple_ddtaodcfiesjbggrllzpybgqb)
        {
            DataType r_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10MentalScore?.Effective;
            object s_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, r_);
            CqlInterval<CqlDateTime> t_ = QICoreCommon_minus_2_1_000.Instance.toInterval(context, s_);
            CqlDateTime u_ = context.Operators.Start(t_);
            CqlDate v_ = context.Operators.DateFrom(u_);
            DataType w_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10PhysicalScore?.Effective;
            object x_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, w_);
            CqlInterval<CqlDateTime> y_ = QICoreCommon_minus_2_1_000.Instance.toInterval(context, x_);
            CqlDateTime z_ = context.Operators.Start(y_);
            CqlDate aa_ = context.Operators.DateFrom(z_);
            bool? ab_ = context.Operators.SameAs(v_, aa_, "day");
            DataType ac_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10PhysicalScore?.Value;
            object ad_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, ac_);
            bool? ae_ = context.Operators.Not((bool?)(ad_ is null));
            bool? af_ = context.Operators.And(ab_, ae_);
            DataType ag_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10MentalScore?.Value;
            object ah_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, ag_);
            bool? ai_ = context.Operators.Not((bool?)(ah_ is null));
            bool? aj_ = context.Operators.And(af_, ai_);

            return aj_;
        };
        IEnumerable<(CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?> m_ = context.Operators.Where<(CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?>(k_, l_);
        CqlDate n_((CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)? tuple_ddtaodcfiesjbggrllzpybgqb)
        {
            DataType ak_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10MentalScore?.Effective;
            object al_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, ak_);
            CqlInterval<CqlDateTime> am_ = QICoreCommon_minus_2_1_000.Instance.toInterval(context, al_);
            CqlDateTime an_ = context.Operators.Start(am_);
            CqlDate ao_ = context.Operators.DateFrom(an_);
            DataType ap_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10PhysicalScore?.Effective;
            object aq_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, ap_);
            CqlInterval<CqlDateTime> ar_ = QICoreCommon_minus_2_1_000.Instance.toInterval(context, aq_);
            CqlDateTime as_ = context.Operators.Start(ar_);
            CqlDate at_ = context.Operators.DateFrom(as_);
            CqlDate[] au_ = [
                ao_,
                at_,
            ];
            CqlDate av_ = context.Operators.Max<CqlDate>(au_ as IEnumerable<CqlDate>);

            return av_;
        };
        IEnumerable<CqlDate> o_ = context.Operators.Select<(CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?, CqlDate>(m_, n_);
        IEnumerable<CqlDate> p_ = context.Operators.Distinct<CqlDate>(o_);

        return p_;
    }


    [CqlExpressionDefinition("Has THA with Initial and Follow Up PROMIS10 Assessments")]
    public bool? Has_THA_with_Initial_and_Follow_Up_PROMIS10_Assessments(CqlContext context)
    {
        IEnumerable<Procedure> a_ = this.Total_Hip_Arthroplasty_Procedure(context);
        CqlInterval<CqlDateTime> b_(Procedure THAProcedure)
        {
            DataType j_ = THAProcedure?.Performed;
            object k_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, j_);
            CqlInterval<CqlDateTime> l_ = QICoreCommon_minus_2_1_000.Instance.toInterval(context, k_);

            return l_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.Select<Procedure, CqlInterval<CqlDateTime>>(a_, b_);
        IEnumerable<CqlInterval<CqlDateTime>> d_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(c_);
        IEnumerable<CqlInterval<CqlDateTime>> e_(CqlInterval<CqlDateTime> TotalHip)
        {
            IEnumerable<CqlDate> m_ = this.Date_PROMIS10_Total_Assessment_Completed(context);
            bool? n_(CqlDate InitialHipAssessmentPROMIS10)
            {
                CqlDateTime r_ = context.Operators.Start(TotalHip);
                CqlQuantity s_ = context.Operators.Quantity(90m, "days");
                CqlDate t_ = context.Operators.Add(InitialHipAssessmentPROMIS10, s_);
                CqlInterval<CqlDate> u_ = context.Operators.Interval(InitialHipAssessmentPROMIS10, t_, true, true);
                CqlDate v_ = u_?.low;
                CqlDateTime w_ = context.Operators.ConvertDateToDateTime(v_);
                CqlDate y_ = context.Operators.Add(InitialHipAssessmentPROMIS10, s_);
                CqlInterval<CqlDate> z_ = context.Operators.Interval(InitialHipAssessmentPROMIS10, y_, true, true);
                CqlDate aa_ = z_?.high;
                CqlDateTime ab_ = context.Operators.ConvertDateToDateTime(aa_);
                CqlDate ad_ = context.Operators.Add(InitialHipAssessmentPROMIS10, s_);
                CqlInterval<CqlDate> ae_ = context.Operators.Interval(InitialHipAssessmentPROMIS10, ad_, true, true);
                bool? af_ = ae_?.lowClosed;
                CqlDate ah_ = context.Operators.Add(InitialHipAssessmentPROMIS10, s_);
                CqlInterval<CqlDate> ai_ = context.Operators.Interval(InitialHipAssessmentPROMIS10, ah_, true, true);
                bool? aj_ = ai_?.highClosed;
                CqlInterval<CqlDateTime> ak_ = context.Operators.Interval(w_, ab_, af_, aj_);
                bool? al_ = context.Operators.In<CqlDateTime>(r_, ak_, "day");
                bool? am_ = context.Operators.Not((bool?)(InitialHipAssessmentPROMIS10 is null));
                bool? an_ = context.Operators.And(al_, am_);

                return an_;
            };
            IEnumerable<CqlDate> o_ = context.Operators.Where<CqlDate>(m_, n_);
            CqlInterval<CqlDateTime> p_(CqlDate InitialHipAssessmentPROMIS10) =>
                TotalHip;
            IEnumerable<CqlInterval<CqlDateTime>> q_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(o_, p_);

            return q_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> f_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(d_, e_);
        IEnumerable<CqlInterval<CqlDateTime>> g_(CqlInterval<CqlDateTime> TotalHip)
        {
            IEnumerable<CqlDate> ao_ = this.Date_PROMIS10_Total_Assessment_Completed(context);
            bool? ap_(CqlDate FollowUpHipAssessmentPROMIS10)
            {
                CqlDateTime at_ = context.Operators.ConvertDateToDateTime(FollowUpHipAssessmentPROMIS10);
                CqlDate au_ = context.Operators.DateFrom(at_);
                CqlDateTime av_ = context.Operators.End(TotalHip);
                CqlDate aw_ = context.Operators.DateFrom(av_);
                CqlQuantity ax_ = context.Operators.Quantity(300m, "days");
                CqlDate ay_ = context.Operators.Add(aw_, ax_);
                CqlDate ba_ = context.Operators.DateFrom(av_);
                CqlQuantity bb_ = context.Operators.Quantity(425m, "days");
                CqlDate bc_ = context.Operators.Add(ba_, bb_);
                CqlInterval<CqlDate> bd_ = context.Operators.Interval(ay_, bc_, true, true);
                bool? be_ = context.Operators.In<CqlDate>(au_, bd_, "day");

                return be_;
            };
            IEnumerable<CqlDate> aq_ = context.Operators.Where<CqlDate>(ao_, ap_);
            CqlInterval<CqlDateTime> ar_(CqlDate FollowUpHipAssessmentPROMIS10) =>
                TotalHip;
            IEnumerable<CqlInterval<CqlDateTime>> as_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(aq_, ar_);

            return as_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> h_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(f_, g_);
        bool? i_ = context.Operators.Exists<CqlInterval<CqlDateTime>>(h_);

        return i_;
    }


    [CqlExpressionDefinition("Date VR12 Oblique Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_VR12_Oblique_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode a_ = this.VR_minus_12_Mental_component_summary__MCS__score__minus__oblique_method_T_minus_score(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> d_ = Status_minus_1_8_000.Instance.isAssessmentPerformed(context, c_);
        CqlCode e_ = this.VR_minus_12_Physical_component_summary__PCS__score__minus__oblique_method_T_minus_score(context);
        IEnumerable<CqlCode> f_ = context.Operators.ToList<CqlCode>(e_);
        IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, f_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> h_ = Status_minus_1_8_000.Instance.isAssessmentPerformed(context, g_);
        IEnumerable<ValueTuple<Observation, Observation>> i_ = context.Operators.CrossJoin<Observation, Observation>(d_, h_);
        (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? j_(ValueTuple<Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? q_ = (CqlTupleMetadata_GAdRFKRaHUUGJcVHWQWRUjhRH, _valueTuple.Item1, _valueTuple.Item2);

            return q_;
        };
        IEnumerable<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?> k_ = context.Operators.Select<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?>(i_, j_);
        bool? l_((CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? tuple_gadrfkrahuugjcvhwqwrujhrh)
        {
            DataType r_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Effective;
            object s_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, r_);
            CqlInterval<CqlDateTime> t_ = QICoreCommon_minus_2_1_000.Instance.toInterval(context, s_);
            CqlDateTime u_ = context.Operators.Start(t_);
            CqlDate v_ = context.Operators.DateFrom(u_);
            DataType w_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Effective;
            object x_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, w_);
            CqlInterval<CqlDateTime> y_ = QICoreCommon_minus_2_1_000.Instance.toInterval(context, x_);
            CqlDateTime z_ = context.Operators.Start(y_);
            CqlDate aa_ = context.Operators.DateFrom(z_);
            bool? ab_ = context.Operators.SameAs(v_, aa_, "day");
            DataType ac_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Value;
            object ad_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, ac_);
            bool? ae_ = context.Operators.Not((bool?)(ad_ is null));
            bool? af_ = context.Operators.And(ab_, ae_);
            DataType ag_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Value;
            object ah_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, ag_);
            bool? ai_ = context.Operators.Not((bool?)(ah_ is null));
            bool? aj_ = context.Operators.And(af_, ai_);

            return aj_;
        };
        IEnumerable<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?> m_ = context.Operators.Where<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?>(k_, l_);
        CqlDate n_((CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? tuple_gadrfkrahuugjcvhwqwrujhrh)
        {
            DataType ak_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Effective;
            object al_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, ak_);
            CqlInterval<CqlDateTime> am_ = QICoreCommon_minus_2_1_000.Instance.toInterval(context, al_);
            CqlDateTime an_ = context.Operators.Start(am_);
            CqlDate ao_ = context.Operators.DateFrom(an_);
            DataType ap_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Effective;
            object aq_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, ap_);
            CqlInterval<CqlDateTime> ar_ = QICoreCommon_minus_2_1_000.Instance.toInterval(context, aq_);
            CqlDateTime as_ = context.Operators.Start(ar_);
            CqlDate at_ = context.Operators.DateFrom(as_);
            CqlDate[] au_ = [
                ao_,
                at_,
            ];
            CqlDate av_ = context.Operators.Max<CqlDate>(au_ as IEnumerable<CqlDate>);

            return av_;
        };
        IEnumerable<CqlDate> o_ = context.Operators.Select<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?, CqlDate>(m_, n_);
        IEnumerable<CqlDate> p_ = context.Operators.Distinct<CqlDate>(o_);

        return p_;
    }


    [CqlExpressionDefinition("Has THA with Initial and Follow Up VR12 Oblique Assessments")]
    public bool? Has_THA_with_Initial_and_Follow_Up_VR12_Oblique_Assessments(CqlContext context)
    {
        IEnumerable<Procedure> a_ = this.Total_Hip_Arthroplasty_Procedure(context);
        CqlInterval<CqlDateTime> b_(Procedure THAProcedure)
        {
            DataType j_ = THAProcedure?.Performed;
            object k_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, j_);
            CqlInterval<CqlDateTime> l_ = QICoreCommon_minus_2_1_000.Instance.toInterval(context, k_);

            return l_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.Select<Procedure, CqlInterval<CqlDateTime>>(a_, b_);
        IEnumerable<CqlInterval<CqlDateTime>> d_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(c_);
        IEnumerable<CqlInterval<CqlDateTime>> e_(CqlInterval<CqlDateTime> TotalHip)
        {
            IEnumerable<CqlDate> m_ = this.Date_VR12_Oblique_Total_Assessment_Completed(context);
            bool? n_(CqlDate InitialHipAssessmentOblique)
            {
                CqlDateTime r_ = context.Operators.Start(TotalHip);
                CqlQuantity s_ = context.Operators.Quantity(90m, "days");
                CqlDate t_ = context.Operators.Add(InitialHipAssessmentOblique, s_);
                CqlInterval<CqlDate> u_ = context.Operators.Interval(InitialHipAssessmentOblique, t_, true, true);
                CqlDate v_ = u_?.low;
                CqlDateTime w_ = context.Operators.ConvertDateToDateTime(v_);
                CqlDate y_ = context.Operators.Add(InitialHipAssessmentOblique, s_);
                CqlInterval<CqlDate> z_ = context.Operators.Interval(InitialHipAssessmentOblique, y_, true, true);
                CqlDate aa_ = z_?.high;
                CqlDateTime ab_ = context.Operators.ConvertDateToDateTime(aa_);
                CqlDate ad_ = context.Operators.Add(InitialHipAssessmentOblique, s_);
                CqlInterval<CqlDate> ae_ = context.Operators.Interval(InitialHipAssessmentOblique, ad_, true, true);
                bool? af_ = ae_?.lowClosed;
                CqlDate ah_ = context.Operators.Add(InitialHipAssessmentOblique, s_);
                CqlInterval<CqlDate> ai_ = context.Operators.Interval(InitialHipAssessmentOblique, ah_, true, true);
                bool? aj_ = ai_?.highClosed;
                CqlInterval<CqlDateTime> ak_ = context.Operators.Interval(w_, ab_, af_, aj_);
                bool? al_ = context.Operators.In<CqlDateTime>(r_, ak_, "day");
                bool? am_ = context.Operators.Not((bool?)(InitialHipAssessmentOblique is null));
                bool? an_ = context.Operators.And(al_, am_);

                return an_;
            };
            IEnumerable<CqlDate> o_ = context.Operators.Where<CqlDate>(m_, n_);
            CqlInterval<CqlDateTime> p_(CqlDate InitialHipAssessmentOblique) =>
                TotalHip;
            IEnumerable<CqlInterval<CqlDateTime>> q_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(o_, p_);

            return q_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> f_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(d_, e_);
        IEnumerable<CqlInterval<CqlDateTime>> g_(CqlInterval<CqlDateTime> TotalHip)
        {
            IEnumerable<CqlDate> ao_ = this.Date_VR12_Oblique_Total_Assessment_Completed(context);
            bool? ap_(CqlDate FollowUpHipAssessmentOblique)
            {
                CqlDateTime at_ = context.Operators.ConvertDateToDateTime(FollowUpHipAssessmentOblique);
                CqlDate au_ = context.Operators.DateFrom(at_);
                CqlDateTime av_ = context.Operators.End(TotalHip);
                CqlDate aw_ = context.Operators.DateFrom(av_);
                CqlQuantity ax_ = context.Operators.Quantity(300m, "days");
                CqlDate ay_ = context.Operators.Add(aw_, ax_);
                CqlDate ba_ = context.Operators.DateFrom(av_);
                CqlQuantity bb_ = context.Operators.Quantity(425m, "days");
                CqlDate bc_ = context.Operators.Add(ba_, bb_);
                CqlInterval<CqlDate> bd_ = context.Operators.Interval(ay_, bc_, true, true);
                bool? be_ = context.Operators.In<CqlDate>(au_, bd_, "day");

                return be_;
            };
            IEnumerable<CqlDate> aq_ = context.Operators.Where<CqlDate>(ao_, ap_);
            CqlInterval<CqlDateTime> ar_(CqlDate FollowUpHipAssessmentOblique) =>
                TotalHip;
            IEnumerable<CqlInterval<CqlDateTime>> as_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(aq_, ar_);

            return as_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> h_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(f_, g_);
        bool? i_ = context.Operators.Exists<CqlInterval<CqlDateTime>>(h_);

        return i_;
    }


    [CqlExpressionDefinition("Date VR12 Orthogonal Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_VR12_Orthogonal_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode a_ = this.VR_minus_12_Mental_component_summary__MCS__score__minus__orthogonal_method_T_minus_score(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> d_ = Status_minus_1_8_000.Instance.isAssessmentPerformed(context, c_);
        CqlCode e_ = this.VR_minus_12_Physical_component_summary__PCS__score__minus__orthogonal_method_T_minus_score(context);
        IEnumerable<CqlCode> f_ = context.Operators.ToList<CqlCode>(e_);
        IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, f_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> h_ = Status_minus_1_8_000.Instance.isAssessmentPerformed(context, g_);
        IEnumerable<ValueTuple<Observation, Observation>> i_ = context.Operators.CrossJoin<Observation, Observation>(d_, h_);
        (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? j_(ValueTuple<Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? q_ = (CqlTupleMetadata_GAdRFKRaHUUGJcVHWQWRUjhRH, _valueTuple.Item1, _valueTuple.Item2);

            return q_;
        };
        IEnumerable<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?> k_ = context.Operators.Select<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?>(i_, j_);
        bool? l_((CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? tuple_gadrfkrahuugjcvhwqwrujhrh)
        {
            DataType r_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Effective;
            object s_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, r_);
            CqlInterval<CqlDateTime> t_ = QICoreCommon_minus_2_1_000.Instance.toInterval(context, s_);
            CqlDateTime u_ = context.Operators.Start(t_);
            CqlDate v_ = context.Operators.DateFrom(u_);
            DataType w_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Effective;
            object x_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, w_);
            CqlInterval<CqlDateTime> y_ = QICoreCommon_minus_2_1_000.Instance.toInterval(context, x_);
            CqlDateTime z_ = context.Operators.Start(y_);
            CqlDate aa_ = context.Operators.DateFrom(z_);
            bool? ab_ = context.Operators.SameAs(v_, aa_, "day");
            DataType ac_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Value;
            object ad_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, ac_);
            bool? ae_ = context.Operators.Not((bool?)(ad_ is null));
            bool? af_ = context.Operators.And(ab_, ae_);
            DataType ag_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Value;
            object ah_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, ag_);
            bool? ai_ = context.Operators.Not((bool?)(ah_ is null));
            bool? aj_ = context.Operators.And(af_, ai_);

            return aj_;
        };
        IEnumerable<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?> m_ = context.Operators.Where<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?>(k_, l_);
        CqlDate n_((CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? tuple_gadrfkrahuugjcvhwqwrujhrh)
        {
            DataType ak_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Effective;
            object al_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, ak_);
            CqlInterval<CqlDateTime> am_ = QICoreCommon_minus_2_1_000.Instance.toInterval(context, al_);
            CqlDateTime an_ = context.Operators.Start(am_);
            CqlDate ao_ = context.Operators.DateFrom(an_);
            DataType ap_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Effective;
            object aq_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, ap_);
            CqlInterval<CqlDateTime> ar_ = QICoreCommon_minus_2_1_000.Instance.toInterval(context, aq_);
            CqlDateTime as_ = context.Operators.Start(ar_);
            CqlDate at_ = context.Operators.DateFrom(as_);
            CqlDate[] au_ = [
                ao_,
                at_,
            ];
            CqlDate av_ = context.Operators.Max<CqlDate>(au_ as IEnumerable<CqlDate>);

            return av_;
        };
        IEnumerable<CqlDate> o_ = context.Operators.Select<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?, CqlDate>(m_, n_);
        IEnumerable<CqlDate> p_ = context.Operators.Distinct<CqlDate>(o_);

        return p_;
    }


    [CqlExpressionDefinition("Has THA with Initial and Follow Up VR12 Orthogonal Assessments")]
    public bool? Has_THA_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments(CqlContext context)
    {
        IEnumerable<Procedure> a_ = this.Total_Hip_Arthroplasty_Procedure(context);
        CqlInterval<CqlDateTime> b_(Procedure THAProcedure)
        {
            DataType j_ = THAProcedure?.Performed;
            object k_ = FHIRHelpers_minus_4_4_000.Instance.ToValue(context, j_);
            CqlInterval<CqlDateTime> l_ = QICoreCommon_minus_2_1_000.Instance.toInterval(context, k_);

            return l_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.Select<Procedure, CqlInterval<CqlDateTime>>(a_, b_);
        IEnumerable<CqlInterval<CqlDateTime>> d_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(c_);
        IEnumerable<CqlInterval<CqlDateTime>> e_(CqlInterval<CqlDateTime> TotalHip)
        {
            IEnumerable<CqlDate> m_ = this.Date_VR12_Orthogonal_Total_Assessment_Completed(context);
            bool? n_(CqlDate InitialHipAssessmentOrthogonal)
            {
                CqlDateTime r_ = context.Operators.Start(TotalHip);
                CqlQuantity s_ = context.Operators.Quantity(90m, "days");
                CqlDate t_ = context.Operators.Add(InitialHipAssessmentOrthogonal, s_);
                CqlInterval<CqlDate> u_ = context.Operators.Interval(InitialHipAssessmentOrthogonal, t_, true, true);
                CqlDate v_ = u_?.low;
                CqlDateTime w_ = context.Operators.ConvertDateToDateTime(v_);
                CqlDate y_ = context.Operators.Add(InitialHipAssessmentOrthogonal, s_);
                CqlInterval<CqlDate> z_ = context.Operators.Interval(InitialHipAssessmentOrthogonal, y_, true, true);
                CqlDate aa_ = z_?.high;
                CqlDateTime ab_ = context.Operators.ConvertDateToDateTime(aa_);
                CqlDate ad_ = context.Operators.Add(InitialHipAssessmentOrthogonal, s_);
                CqlInterval<CqlDate> ae_ = context.Operators.Interval(InitialHipAssessmentOrthogonal, ad_, true, true);
                bool? af_ = ae_?.lowClosed;
                CqlDate ah_ = context.Operators.Add(InitialHipAssessmentOrthogonal, s_);
                CqlInterval<CqlDate> ai_ = context.Operators.Interval(InitialHipAssessmentOrthogonal, ah_, true, true);
                bool? aj_ = ai_?.highClosed;
                CqlInterval<CqlDateTime> ak_ = context.Operators.Interval(w_, ab_, af_, aj_);
                bool? al_ = context.Operators.In<CqlDateTime>(r_, ak_, "day");
                bool? am_ = context.Operators.Not((bool?)(InitialHipAssessmentOrthogonal is null));
                bool? an_ = context.Operators.And(al_, am_);

                return an_;
            };
            IEnumerable<CqlDate> o_ = context.Operators.Where<CqlDate>(m_, n_);
            CqlInterval<CqlDateTime> p_(CqlDate InitialHipAssessmentOrthogonal) =>
                TotalHip;
            IEnumerable<CqlInterval<CqlDateTime>> q_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(o_, p_);

            return q_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> f_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(d_, e_);
        IEnumerable<CqlInterval<CqlDateTime>> g_(CqlInterval<CqlDateTime> TotalHip)
        {
            IEnumerable<CqlDate> ao_ = this.Date_VR12_Orthogonal_Total_Assessment_Completed(context);
            bool? ap_(CqlDate FollowUpHipAssessmentOrthogonal)
            {
                CqlDateTime at_ = context.Operators.ConvertDateToDateTime(FollowUpHipAssessmentOrthogonal);
                CqlDate au_ = context.Operators.DateFrom(at_);
                CqlDateTime av_ = context.Operators.End(TotalHip);
                CqlDate aw_ = context.Operators.DateFrom(av_);
                CqlQuantity ax_ = context.Operators.Quantity(300m, "days");
                CqlDate ay_ = context.Operators.Add(aw_, ax_);
                CqlDate ba_ = context.Operators.DateFrom(av_);
                CqlQuantity bb_ = context.Operators.Quantity(425m, "days");
                CqlDate bc_ = context.Operators.Add(ba_, bb_);
                CqlInterval<CqlDate> bd_ = context.Operators.Interval(ay_, bc_, true, true);
                bool? be_ = context.Operators.In<CqlDate>(au_, bd_, "day");

                return be_;
            };
            IEnumerable<CqlDate> aq_ = context.Operators.Where<CqlDate>(ao_, ap_);
            CqlInterval<CqlDateTime> ar_(CqlDate FollowUpHipAssessmentOrthogonal) =>
                TotalHip;
            IEnumerable<CqlInterval<CqlDateTime>> as_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(aq_, ar_);

            return as_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> h_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(f_, g_);
        bool? i_ = context.Operators.Exists<CqlInterval<CqlDateTime>>(h_);

        return i_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
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
