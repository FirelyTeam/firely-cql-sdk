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
[CqlLibrary("FunctionalStatusAssessmentforTotalHipReplacementFHIR", "0.0.008")]
public partial class FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008 : ILibrary, ISingleton<FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008>
{
    private FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008() {}

    public static FunctionalStatusAssessmentforTotalHipReplacementFHIR_0_0_008 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "FunctionalStatusAssessmentforTotalHipReplacementFHIR";
    public string Version => "0.0.008";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, QICoreCommon_2_1_000.Instance, SupplementalDataElements_3_5_000.Instance, Hospice_6_12_000.Instance, Status_1_8_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    #region ValueSet: Lower Body Fractures Excluding Ankle and Foot
    [CqlValueSetDefinition(
        definitionName: "Lower Body Fractures Excluding Ankle and Foot",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1178",
        valueSetVersion: null)]
    public CqlValueSet Lower_Body_Fractures_Excluding_Ankle_and_Foot(CqlContext context) => _Lower_Body_Fractures_Excluding_Ankle_and_Foot;

    private static readonly CqlValueSet _Lower_Body_Fractures_Excluding_Ankle_and_Foot = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1178", null);
    #endregion

    #region ValueSet: Malignant Neoplasms of Lower and Unspecified Limbs
    [CqlValueSetDefinition(
        definitionName: "Malignant Neoplasms of Lower and Unspecified Limbs",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1180",
        valueSetVersion: null)]
    public CqlValueSet Malignant_Neoplasms_of_Lower_and_Unspecified_Limbs(CqlContext context) => _Malignant_Neoplasms_of_Lower_and_Unspecified_Limbs;

    private static readonly CqlValueSet _Malignant_Neoplasms_of_Lower_and_Unspecified_Limbs = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1180", null);
    #endregion

    #region ValueSet: Mechanical Complications Excluding Upper Body
    [CqlValueSetDefinition(
        definitionName: "Mechanical Complications Excluding Upper Body",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1182",
        valueSetVersion: null)]
    public CqlValueSet Mechanical_Complications_Excluding_Upper_Body(CqlContext context) => _Mechanical_Complications_Excluding_Upper_Body;

    private static readonly CqlValueSet _Mechanical_Complications_Excluding_Upper_Body = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1182", null);
    #endregion

    #region ValueSet: Office Visit
    [CqlValueSetDefinition(
        definitionName: "Office Visit",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001",
        valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext context) => _Office_Visit;

    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);
    #endregion

    #region ValueSet: Virtual Encounter
    [CqlValueSetDefinition(
        definitionName: "Virtual Encounter",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089",
        valueSetVersion: null)]
    public CqlValueSet Virtual_Encounter(CqlContext context) => _Virtual_Encounter;

    private static readonly CqlValueSet _Virtual_Encounter = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", null);
    #endregion

    #region ValueSet: Outpatient Consultation
    [CqlValueSetDefinition(
        definitionName: "Outpatient Consultation",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008",
        valueSetVersion: null)]
    public CqlValueSet Outpatient_Consultation(CqlContext context) => _Outpatient_Consultation;

    private static readonly CqlValueSet _Outpatient_Consultation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", null);
    #endregion

    #region ValueSet: Partial Arthroplasty of Hip
    [CqlValueSetDefinition(
        definitionName: "Partial Arthroplasty of Hip",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1184",
        valueSetVersion: null)]
    public CqlValueSet Partial_Arthroplasty_of_Hip(CqlContext context) => _Partial_Arthroplasty_of_Hip;

    private static readonly CqlValueSet _Partial_Arthroplasty_of_Hip = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1184", null);
    #endregion

    #region ValueSet: Primary THA Procedure
    [CqlValueSetDefinition(
        definitionName: "Primary THA Procedure",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1006",
        valueSetVersion: null)]
    public CqlValueSet Primary_THA_Procedure(CqlContext context) => _Primary_THA_Procedure;

    private static readonly CqlValueSet _Primary_THA_Procedure = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1006", null);
    #endregion

    #region ValueSet: Removal, Revision and Supplement Procedures of the Lower Body and Spine
    [CqlValueSetDefinition(
        definitionName: "Removal, Revision and Supplement Procedures of the Lower Body and Spine",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1189",
        valueSetVersion: null)]
    public CqlValueSet Removal__Revision_and_Supplement_Procedures_of_the_Lower_Body_and_Spine(CqlContext context) => _Removal__Revision_and_Supplement_Procedures_of_the_Lower_Body_and_Spine;

    private static readonly CqlValueSet _Removal__Revision_and_Supplement_Procedures_of_the_Lower_Body_and_Spine = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1189", null);
    #endregion

    #region ValueSet: Telephone Visits
    [CqlValueSetDefinition(
        definitionName: "Telephone Visits",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080",
        valueSetVersion: null)]
    public CqlValueSet Telephone_Visits(CqlContext context) => _Telephone_Visits;

    private static readonly CqlValueSet _Telephone_Visits = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);
    #endregion

    #endregion ValueSets

    #region Codes

    #region Code: Activities of daily living score [HOOS]
    [CqlCodeDefinition(
        definitionName: "Activities of daily living score [HOOS]",
        codeId: "72095-3",
        codeSystem: "http://loinc.org")]
    public CqlCode Activities_of_daily_living_score__HOOS_(CqlContext context) => _Activities_of_daily_living_score__HOOS_;

    private static readonly CqlCode _Activities_of_daily_living_score__HOOS_ = new CqlCode("72095-3", "http://loinc.org", default, default);
    #endregion

    #region Code: Dead (finding)
    [CqlCodeDefinition(
        definitionName: "Dead (finding)",
        codeId: "419099009",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Dead__finding_(CqlContext context) => _Dead__finding_;

    private static readonly CqlCode _Dead__finding_ = new CqlCode("419099009", "http://snomed.info/sct", default, default);
    #endregion

    #region Code: Discharge to healthcare facility for hospice care (procedure)
    [CqlCodeDefinition(
        definitionName: "Discharge to healthcare facility for hospice care (procedure)",
        codeId: "428371000124100",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Discharge_to_healthcare_facility_for_hospice_care__procedure_(CqlContext context) => _Discharge_to_healthcare_facility_for_hospice_care__procedure_;

    private static readonly CqlCode _Discharge_to_healthcare_facility_for_hospice_care__procedure_ = new CqlCode("428371000124100", "http://snomed.info/sct", default, default);
    #endregion

    #region Code: Discharge to home for hospice care (procedure)
    [CqlCodeDefinition(
        definitionName: "Discharge to home for hospice care (procedure)",
        codeId: "428371000124100",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Discharge_to_home_for_hospice_care__procedure_(CqlContext context) => _Discharge_to_home_for_hospice_care__procedure_;

    private static readonly CqlCode _Discharge_to_home_for_hospice_care__procedure_ = new CqlCode("428371000124100", "http://snomed.info/sct", default, default);
    #endregion

    #region Code: Hospice care [Minimum Data Set]
    [CqlCodeDefinition(
        definitionName: "Hospice care [Minimum Data Set]",
        codeId: "45755-6",
        codeSystem: "http://loinc.org")]
    public CqlCode Hospice_care__Minimum_Data_Set_(CqlContext context) => _Hospice_care__Minimum_Data_Set_;

    private static readonly CqlCode _Hospice_care__Minimum_Data_Set_ = new CqlCode("45755-6", "http://loinc.org", default, default);
    #endregion

    #region Code: Pain score [HOOS]
    [CqlCodeDefinition(
        definitionName: "Pain score [HOOS]",
        codeId: "72097-9",
        codeSystem: "http://loinc.org")]
    public CqlCode Pain_score__HOOS_(CqlContext context) => _Pain_score__HOOS_;

    private static readonly CqlCode _Pain_score__HOOS_ = new CqlCode("72097-9", "http://loinc.org", default, default);
    #endregion

    #region Code: Postoperative follow-up visit, normally included in the surgical package, to indicate that an evaluation and management service was performed during a postoperative period for a reason(s) related to the original procedure
    [CqlCodeDefinition(
        definitionName: "Postoperative follow-up visit, normally included in the surgical package, to indicate that an evaluation and management service was performed during a postoperative period for a reason(s) related to the original procedure",
        codeId: "99024",
        codeSystem: "http://www.ama-assn.org/go/cpt")]
    public CqlCode Postoperative_follow_up_visit__normally_included_in_the_surgical_package__to_indicate_that_an_evaluation_and_management_service_was_performed_during_a_postoperative_period_for_a_reason_s__related_to_the_original_procedure(CqlContext context) => _Postoperative_follow_up_visit__normally_included_in_the_surgical_package__to_indicate_that_an_evaluation_and_management_service_was_performed_during_a_postoperative_period_for_a_reason_s__related_to_the_original_procedure;

    private static readonly CqlCode _Postoperative_follow_up_visit__normally_included_in_the_surgical_package__to_indicate_that_an_evaluation_and_management_service_was_performed_during_a_postoperative_period_for_a_reason_s__related_to_the_original_procedure = new CqlCode("99024", "http://www.ama-assn.org/go/cpt", default, default);
    #endregion

    #region Code: PROMIS-10 Global Mental Health (GMH) score T-score
    [CqlCodeDefinition(
        definitionName: "PROMIS-10 Global Mental Health (GMH) score T-score",
        codeId: "71969-0",
        codeSystem: "http://loinc.org")]
    public CqlCode PROMIS_10_Global_Mental_Health__GMH__score_T_score(CqlContext context) => _PROMIS_10_Global_Mental_Health__GMH__score_T_score;

    private static readonly CqlCode _PROMIS_10_Global_Mental_Health__GMH__score_T_score = new CqlCode("71969-0", "http://loinc.org", default, default);
    #endregion

    #region Code: PROMIS-10 Global Physical Health (GPH) score T-score
    [CqlCodeDefinition(
        definitionName: "PROMIS-10 Global Physical Health (GPH) score T-score",
        codeId: "71971-6",
        codeSystem: "http://loinc.org")]
    public CqlCode PROMIS_10_Global_Physical_Health__GPH__score_T_score(CqlContext context) => _PROMIS_10_Global_Physical_Health__GPH__score_T_score;

    private static readonly CqlCode _PROMIS_10_Global_Physical_Health__GPH__score_T_score = new CqlCode("71971-6", "http://loinc.org", default, default);
    #endregion

    #region Code: Quality of life score [HOOS]
    [CqlCodeDefinition(
        definitionName: "Quality of life score [HOOS]",
        codeId: "72093-8",
        codeSystem: "http://loinc.org")]
    public CqlCode Quality_of_life_score__HOOS_(CqlContext context) => _Quality_of_life_score__HOOS_;

    private static readonly CqlCode _Quality_of_life_score__HOOS_ = new CqlCode("72093-8", "http://loinc.org", default, default);
    #endregion

    #region Code: Severe cognitive impairment (finding)
    [CqlCodeDefinition(
        definitionName: "Severe cognitive impairment (finding)",
        codeId: "702956004",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Severe_cognitive_impairment__finding_(CqlContext context) => _Severe_cognitive_impairment__finding_;

    private static readonly CqlCode _Severe_cognitive_impairment__finding_ = new CqlCode("702956004", "http://snomed.info/sct", default, default);
    #endregion

    #region Code: Sport-recreation score [HOOS]
    [CqlCodeDefinition(
        definitionName: "Sport-recreation score [HOOS]",
        codeId: "72094-6",
        codeSystem: "http://loinc.org")]
    public CqlCode Sport_recreation_score__HOOS_(CqlContext context) => _Sport_recreation_score__HOOS_;

    private static readonly CqlCode _Sport_recreation_score__HOOS_ = new CqlCode("72094-6", "http://loinc.org", default, default);
    #endregion

    #region Code: Symptoms score [HOOS]
    [CqlCodeDefinition(
        definitionName: "Symptoms score [HOOS]",
        codeId: "72096-1",
        codeSystem: "http://loinc.org")]
    public CqlCode Symptoms_score__HOOS_(CqlContext context) => _Symptoms_score__HOOS_;

    private static readonly CqlCode _Symptoms_score__HOOS_ = new CqlCode("72096-1", "http://loinc.org", default, default);
    #endregion

    #region Code: Total interval score [HOOSJR]
    [CqlCodeDefinition(
        definitionName: "Total interval score [HOOSJR]",
        codeId: "82323-7",
        codeSystem: "http://loinc.org")]
    public CqlCode Total_interval_score__HOOSJR_(CqlContext context) => _Total_interval_score__HOOSJR_;

    private static readonly CqlCode _Total_interval_score__HOOSJR_ = new CqlCode("82323-7", "http://loinc.org", default, default);
    #endregion

    #region Code: VR-12 Mental component summary (MCS) score - oblique method T-score
    [CqlCodeDefinition(
        definitionName: "VR-12 Mental component summary (MCS) score - oblique method T-score",
        codeId: "72026-8",
        codeSystem: "http://loinc.org")]
    public CqlCode VR_12_Mental_component_summary__MCS__score___oblique_method_T_score(CqlContext context) => _VR_12_Mental_component_summary__MCS__score___oblique_method_T_score;

    private static readonly CqlCode _VR_12_Mental_component_summary__MCS__score___oblique_method_T_score = new CqlCode("72026-8", "http://loinc.org", default, default);
    #endregion

    #region Code: VR-12 Mental component summary (MCS) score - orthogonal method T-score
    [CqlCodeDefinition(
        definitionName: "VR-12 Mental component summary (MCS) score - orthogonal method T-score",
        codeId: "72028-4",
        codeSystem: "http://loinc.org")]
    public CqlCode VR_12_Mental_component_summary__MCS__score___orthogonal_method_T_score(CqlContext context) => _VR_12_Mental_component_summary__MCS__score___orthogonal_method_T_score;

    private static readonly CqlCode _VR_12_Mental_component_summary__MCS__score___orthogonal_method_T_score = new CqlCode("72028-4", "http://loinc.org", default, default);
    #endregion

    #region Code: VR-12 Physical component summary (PCS) score - oblique method T-score
    [CqlCodeDefinition(
        definitionName: "VR-12 Physical component summary (PCS) score - oblique method T-score",
        codeId: "72025-0",
        codeSystem: "http://loinc.org")]
    public CqlCode VR_12_Physical_component_summary__PCS__score___oblique_method_T_score(CqlContext context) => _VR_12_Physical_component_summary__PCS__score___oblique_method_T_score;

    private static readonly CqlCode _VR_12_Physical_component_summary__PCS__score___oblique_method_T_score = new CqlCode("72025-0", "http://loinc.org", default, default);
    #endregion

    #region Code: VR-12 Physical component summary (PCS) score - orthogonal method T-score
    [CqlCodeDefinition(
        definitionName: "VR-12 Physical component summary (PCS) score - orthogonal method T-score",
        codeId: "72027-6",
        codeSystem: "http://loinc.org")]
    public CqlCode VR_12_Physical_component_summary__PCS__score___orthogonal_method_T_score(CqlContext context) => _VR_12_Physical_component_summary__PCS__score___orthogonal_method_T_score;

    private static readonly CqlCode _VR_12_Physical_component_summary__PCS__score___orthogonal_method_T_score = new CqlCode("72027-6", "http://loinc.org", default, default);
    #endregion

    #region Code: Yes (qualifier value)
    [CqlCodeDefinition(
        definitionName: "Yes (qualifier value)",
        codeId: "373066001",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Yes__qualifier_value_(CqlContext context) => _Yes__qualifier_value_;

    private static readonly CqlCode _Yes__qualifier_value_ = new CqlCode("373066001", "http://snomed.info/sct", default, default);
    #endregion

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition(
        definitionName: "LOINC")]
    public CqlCode[] LOINC(CqlContext context)
    {
        CqlCode[] czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = [
            new CqlCode("72095-3", "http://loinc.org", default, default),
            new CqlCode("45755-6", "http://loinc.org", default, default),
            new CqlCode("72097-9", "http://loinc.org", default, default),
            new CqlCode("71969-0", "http://loinc.org", default, default),
            new CqlCode("71971-6", "http://loinc.org", default, default),
            new CqlCode("72093-8", "http://loinc.org", default, default),
            new CqlCode("72094-6", "http://loinc.org", default, default),
            new CqlCode("72096-1", "http://loinc.org", default, default),
            new CqlCode("82323-7", "http://loinc.org", default, default),
            new CqlCode("72026-8", "http://loinc.org", default, default),
            new CqlCode("72028-4", "http://loinc.org", default, default),
            new CqlCode("72025-0", "http://loinc.org", default, default),
            new CqlCode("72027-6", "http://loinc.org", default, default),
        ];

        return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "CPT")]
    public CqlCode[] CPT(CqlContext context)
    {
        CqlCode[] czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = [
            new CqlCode("99024", "http://www.ama-assn.org/go/cpt", default, default),
        ];

        return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "SNOMEDCT")]
    public CqlCode[] SNOMEDCT(CqlContext context)
    {
        CqlCode[] czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = [
            new CqlCode("419099009", "http://snomed.info/sct", default, default),
            new CqlCode("428371000124100", "http://snomed.info/sct", default, default),
            new CqlCode("428371000124100", "http://snomed.info/sct", default, default),
            new CqlCode("702956004", "http://snomed.info/sct", default, default),
            new CqlCode("373066001", "http://snomed.info/sct", default, default),
        ];

        return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Interval(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, true, true);
        object czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.ResolveParameter("FunctionalStatusAssessmentforTotalHipReplacementFHIR-0.0.008", "Measurement Period", czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

        return (CqlInterval<CqlDateTime>)czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.SingletonFrom<Patient>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

        return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Payer Type")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Type(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition(
        definitionName: "August 1 Year Prior to the Measurement Period")]
    public CqlDateTime August_1_Year_Prior_to_the_Measurement_Period(CqlContext context)
    {
        CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Measurement_Period(context);
        CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        int? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.DateTimeComponentFrom(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, "year");
        int? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Subtract(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, 1);
        decimal? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.ConvertIntegerToDecimal(0);
        CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.DateTime(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, 8, 1, 0, 0, 0, 0, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

        return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Qualifying Encounter")]
    public bool? Has_Qualifying_Encounter(CqlContext context)
    {
        CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Office_Visit(context);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<Encounter>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_(Encounter E)
        {
            List<CodeableConcept> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = E?.Type;
            CqlConcept dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_(CodeableConcept @this)
            {
                CqlConcept ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<CqlConcept> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_(CqlConcept T)
            {
                CqlCode ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Postoperative_follow_up_visit__normally_included_in_the_surgical_package__to_indicate_that_an_evaluation_and_management_service_was_performed_during_a_postoperative_period_for_a_reason_s__related_to_the_original_procedure(context);
                CqlConcept ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.ConvertCodeToConcept(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Equivalent(T, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

                return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<CqlConcept> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<CqlConcept>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Exists<CqlConcept>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

            return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Encounter>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Union<Encounter>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Union<Encounter>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Union<Encounter>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = Status_1_8_000.Instance.isEncounterPerformed(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_(Encounter ValidEncounters)
        {
            CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.August_1_Year_Prior_to_the_Measurement_Period(context);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Measurement_Period(context);
            CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.End(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Interval(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, true, true);
            Period ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = ValidEncounters?.Period;
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.toInterval(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ as object);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, "day");

            return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Encounter>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Exists<Encounter>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

        return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition(
        definitionName: "November 1 Two Years Prior to the Measurement Period")]
    public CqlDateTime November_1_Two_Years_Prior_to_the_Measurement_Period(CqlContext context)
    {
        CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Measurement_Period(context);
        CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        int? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.DateTimeComponentFrom(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, "year");
        int? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Subtract(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, 2);
        decimal? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ConvertIntegerToDecimal(0);
        CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.DateTime(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, 11, 1, 0, 0, 0, 0, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition(
        definitionName: "October 31 Year Prior to the Measurement Period")]
    public CqlDateTime October_31_Year_Prior_to_the_Measurement_Period(CqlContext context)
    {
        CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Measurement_Period(context);
        CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        int? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.DateTimeComponentFrom(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, "year");
        int? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Subtract(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, 1);
        decimal? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.ConvertIntegerToDecimal(0);
        CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.DateTime(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, 10, 31, 23, 59, 59, 0, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition(
        definitionName: "Total Hip Arthroplasty Procedure")]
    public IEnumerable<Procedure> Total_Hip_Arthroplasty_Procedure(CqlContext context)
    {
        CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Primary_THA_Procedure(context);
        IEnumerable<Procedure> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = Status_1_8_000.Instance.isProcedurePerformed(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_(Procedure THAProcedure)
        {
            DataType fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = THAProcedure?.Performed;
            object fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.toInterval(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Start(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.November_1_Two_Years_Prior_to_the_Measurement_Period(context);
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.October_31_Year_Prior_to_the_Measurement_Period(context);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Interval(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, true, true);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.In<CqlDateTime>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, "day");

            return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Procedure> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Procedure>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

        return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Has_Qualifying_Encounter(context);
        IEnumerable<Procedure> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Total_Hip_Arthroplasty_Procedure(context);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Exists<Procedure>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        Patient fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Patient(context);
        Date fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_?.BirthDateElement;
        string fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_?.Value;
        CqlDate fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.ConvertStringToDate(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Measurement_Period(context);
        CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        CqlDate fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.DateFrom(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        int? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.CalculateAgeAt(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, "year");
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.GreaterOrEqual(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, 19);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

        return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Initial_Population(context);

        return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Severe Cognitive Impairment")]
    public bool? Has_Severe_Cognitive_Impairment(CqlContext context)
    {
        CqlCode gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Severe_cognitive_impairment__finding_(context);
        IEnumerable<CqlCode> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ToList<CqlCode>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<Condition> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_(Condition Dementia)
        {
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Dementia);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Measurement_Period(context);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Overlaps(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, "day");

            return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Condition> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Condition>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Exists<Condition>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

        return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Total Hip Arthroplasty with 1 or More Lower Body Fractures")]
    public bool? Has_Total_Hip_Arthroplasty_with_1_or_More_Lower_Body_Fractures(CqlContext context)
    {
        IEnumerable<Procedure> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Total_Hip_Arthroplasty_Procedure(context);
        IEnumerable<Procedure> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_(Procedure THAProcedure)
        {
            CqlValueSet gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Lower_Body_Fractures_Excluding_Ankle_and_Foot(context);
            IEnumerable<Condition> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(Condition LowerBodyFracture)
            {
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, LowerBodyFracture);
                CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = THAProcedure?.Performed;
                object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlQuantity hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Quantity(24m, "hours");
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Subtract(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                object hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Interval(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, true, true);
                bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.In<CqlDateTime>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, default);
                object hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Not((bool?)(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ is null));
                bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

                return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<Condition> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<Condition>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            Procedure gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_(Condition LowerBodyFracture) =>
                THAProcedure;
            IEnumerable<Procedure> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Select<Condition, Procedure>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

            return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Procedure> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.SelectMany<Procedure, Procedure>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Exists<Procedure>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

        return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Partial Hip Arthroplasty Procedure")]
    public bool? Has_Partial_Hip_Arthroplasty_Procedure(CqlContext context)
    {
        CqlValueSet hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Partial_Arthroplasty_of_Hip(context);
        IEnumerable<Procedure> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = Status_1_8_000.Instance.isProcedurePerformed(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<Procedure> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(Procedure PartialTHAProcedure)
        {
            IEnumerable<Procedure> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Total_Hip_Arthroplasty_Procedure(context);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_(Procedure THAProcedure)
            {
                DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = THAProcedure?.Performed;
                object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = PartialTHAProcedure?.Performed;
                object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
                bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, "day");

                return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Procedure> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Procedure>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            Procedure hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_(Procedure THAProcedure) =>
                PartialTHAProcedure;
            IEnumerable<Procedure> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Select<Procedure, Procedure>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

            return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Procedure> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.SelectMany<Procedure, Procedure>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Exists<Procedure>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

        return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Revision Hip Arthroplasty Procedure or Implanted Device or Prosthesis Removal Procedure")]
    public bool? Has_Revision_Hip_Arthroplasty_Procedure_or_Implanted_Device_or_Prosthesis_Removal_Procedure(CqlContext context)
    {
        IEnumerable<Procedure> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Total_Hip_Arthroplasty_Procedure(context);
        IEnumerable<Procedure> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Procedure THAProcedure)
        {
            CqlValueSet izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Removal__Revision_and_Supplement_Procedures_of_the_Lower_Body_and_Spine(context);
            IEnumerable<Procedure> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            IEnumerable<Procedure> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = Status_1_8_000.Instance.isProcedurePerformed(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Procedure RevisionTHAProcedure)
            {
                DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = THAProcedure?.Performed;
                object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = RevisionTHAProcedure?.Performed;
                object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.toInterval(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, "day");

                return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
            };
            IEnumerable<Procedure> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Procedure>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            Procedure izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_(Procedure RevisionTHAProcedure) =>
                THAProcedure;
            IEnumerable<Procedure> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Select<Procedure, Procedure>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

            return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Procedure> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.SelectMany<Procedure, Procedure>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Exists<Procedure>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

        return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Malignant Neoplasm of Lower and Unspecified Limbs")]
    public bool? Has_Malignant_Neoplasm_of_Lower_and_Unspecified_Limbs(CqlContext context)
    {
        CqlValueSet izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Malignant_Neoplasms_of_Lower_and_Unspecified_Limbs(context);
        IEnumerable<Condition> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_(Condition MalignantNeoplasm)
        {
            IEnumerable<Procedure> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Total_Hip_Arthroplasty_Procedure(context);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_(Procedure THAProcedure)
            {
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, MalignantNeoplasm);
                DataType jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = THAProcedure?.Performed;
                object jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.toInterval(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Overlaps(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, "day");

                return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<Procedure> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Procedure>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            Condition jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(Procedure THAProcedure) =>
                MalignantNeoplasm;
            IEnumerable<Condition> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Select<Procedure, Condition>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

            return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Condition> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.SelectMany<Condition, Condition>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Exists<Condition>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

        return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Mechanical Complication")]
    public bool? Has_Mechanical_Complication(CqlContext context)
    {
        CqlValueSet jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Mechanical_Complications_Excluding_Upper_Body(context);
        IEnumerable<Condition> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        IEnumerable<Condition> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_(Condition MechanicalComplications)
        {
            IEnumerable<Procedure> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Total_Hip_Arthroplasty_Procedure(context);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_(Procedure THAProcedure)
            {
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, MechanicalComplications);
                DataType jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = THAProcedure?.Performed;
                object kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Overlaps(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, "day");

                return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Procedure> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Procedure>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            Condition jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_(Procedure THAProcedure) =>
                MechanicalComplications;
            IEnumerable<Condition> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Select<Procedure, Condition>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

            return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Condition> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.SelectMany<Condition, Condition>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Exists<Condition>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

        return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has More Than One Elective Primary Total Hip Arthroplasty Performed")]
    public bool? Has_More_Than_One_Elective_Primary_Total_Hip_Arthroplasty_Performed(CqlContext context)
    {
        IEnumerable<Procedure> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Total_Hip_Arthroplasty_Procedure(context);
        IEnumerable<Procedure> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_(Procedure THAProcedure)
        {
            CqlValueSet kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Primary_THA_Procedure(context);
            IEnumerable<Procedure> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
            IEnumerable<Procedure> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = Status_1_8_000.Instance.isProcedurePerformed(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Procedure ElectiveTHAProcedure)
            {
                Id kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = THAProcedure?.IdElement;
                string kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_?.Value;
                Id kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = ElectiveTHAProcedure?.IdElement;
                string kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_?.Value;
                bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Equivalent(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Not(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                DataType kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = ElectiveTHAProcedure?.Performed;
                object kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                DataType kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = THAProcedure?.Performed;
                object kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlQuantity lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Quantity(1m, "year");
                CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Subtract(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.toInterval(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Add(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Interval(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, true, true);
                bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.In<CqlDateTime>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, "day");
                bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

                return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
            };
            IEnumerable<Procedure> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Procedure>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            Procedure kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_(Procedure ElectiveTHAProcedure) =>
                THAProcedure;
            IEnumerable<Procedure> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Select<Procedure, Procedure>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

            return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Procedure> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.SelectMany<Procedure, Procedure>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Exists<Procedure>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

        return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition(
        definitionName: "Death Within 300 Days of the THA Procedure")]
    public bool? Death_Within_300_Days_of_the_THA_Procedure(CqlContext context)
    {
        IEnumerable<Procedure> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Total_Hip_Arthroplasty_Procedure(context);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Procedure THAProcedure)
        {
            Patient lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Patient(context);
            DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_?.Deceased;
            object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlDate lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.DateFrom(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ as CqlDateTime);
            DataType lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = THAProcedure?.Performed;
            object lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.toInterval(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlDate lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.DateFrom(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlDate mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.DateFrom(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlQuantity mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Quantity(300m, "days");
            CqlDate mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Add(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlInterval<CqlDate> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Interval(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, true, true);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.In<CqlDate>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, "day");

            return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Procedure> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Procedure>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Exists<Procedure>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

        return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Has_Severe_Cognitive_Impairment(context);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Or(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Has_Total_Hip_Arthroplasty_with_1_or_More_Lower_Body_Fractures(context);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Or(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Has_Partial_Hip_Arthroplasty_Procedure(context);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Or(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Has_Revision_Hip_Arthroplasty_Procedure_or_Implanted_Device_or_Prosthesis_Removal_Procedure(context);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Or(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Has_Malignant_Neoplasm_of_Lower_and_Unspecified_Limbs(context);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Or(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Has_Mechanical_Complication(context);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Or(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Has_More_Than_One_Elective_Primary_Total_Hip_Arthroplasty_Performed(context);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Or(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Death_Within_300_Days_of_the_THA_Procedure(context);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Or(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

        return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition(
        definitionName: "Date HOOS Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_HOOS_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Quality_of_life_score__HOOS_(context);
        IEnumerable<CqlCode> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.ToList<CqlCode>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = Status_1_8_000.Instance.isAssessmentPerformed(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        CqlCode nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Sport_recreation_score__HOOS_(context);
        IEnumerable<CqlCode> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.ToList<CqlCode>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = Status_1_8_000.Instance.isAssessmentPerformed(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        CqlCode nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Activities_of_daily_living_score__HOOS_(context);
        IEnumerable<CqlCode> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.ToList<CqlCode>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = Status_1_8_000.Instance.isAssessmentPerformed(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        CqlCode nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Symptoms_score__HOOS_(context);
        IEnumerable<CqlCode> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.ToList<CqlCode>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = Status_1_8_000.Instance.isAssessmentPerformed(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        CqlCode nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Pain_score__HOOS_(context);
        IEnumerable<CqlCode> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ToList<CqlCode>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = Status_1_8_000.Instance.isAssessmentPerformed(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<ValueTuple<Observation, Observation, Observation, Observation, Observation>> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.CrossJoin<Observation, Observation, Observation, Observation, Observation>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        (CqlTupleMetadata, Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_(ValueTuple<Observation, Observation, Observation, Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = (CqlTupleMetadata_GVNUVHGXYWXVGgfjdTEahUfhP, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3, _valueTuple.Item4, _valueTuple.Item5);

            return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<(CqlTupleMetadata, Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)?> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Select<ValueTuple<Observation, Observation, Observation, Observation, Observation>, (CqlTupleMetadata, Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)?>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_((CqlTupleMetadata, Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)? tuple_eipfmazvhfscjijaofhicpvmb)
        {
            DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSLifeQuality?.Effective;
            object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlDate ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.DateFrom(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSSport?.Effective;
            object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.toInterval(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlDate ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.DateFrom(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.SameAs(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, "day");
            DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSSport?.Value;
            object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Not((bool?)(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ is null));
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlDate ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.DateFrom(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSActivityScore?.Effective;
            object ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlDate pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.DateFrom(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.SameAs(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, "day");
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSActivityScore?.Value;
            object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Not((bool?)(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ is null));
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.toInterval(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlDate pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.DateFrom(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSSymptoms?.Effective;
            object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlDate pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.DateFrom(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.SameAs(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, "day");
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSSymptoms?.Value;
            object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Not((bool?)(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ is null));
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            object pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlDate qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.DateFrom(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSPain?.Effective;
            object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlDate qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.DateFrom(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.SameAs(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, "day");
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSPain?.Value;
            object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Not((bool?)(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ is null));
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSLifeQuality?.Value;
            object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Not((bool?)(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ is null));
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

            return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<(CqlTupleMetadata, Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)?> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<(CqlTupleMetadata, Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)?>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        CqlDate nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_((CqlTupleMetadata, Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)? tuple_eipfmazvhfscjijaofhicpvmb)
        {
            DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSLifeQuality?.Effective;
            object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Start(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlDate qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.DateFrom(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSSport?.Effective;
            object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Start(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlDate rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.DateFrom(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSActivityScore?.Effective;
            object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.toInterval(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlDate rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.DateFrom(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSSymptoms?.Effective;
            object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.toInterval(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Start(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlDate rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.DateFrom(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = tuple_eipfmazvhfscjijaofhicpvmb?.HOOSPain?.Effective;
            object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.toInterval(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlDate rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.DateFrom(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlDate[] rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = [
                qzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_,
                rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_,
                rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_,
                rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_,
                rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_,
            ];
            CqlDate rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Max<CqlDate>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ as IEnumerable<CqlDate>);

            return rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<CqlDate> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Select<(CqlTupleMetadata, Observation HOOSLifeQuality, Observation HOOSSport, Observation HOOSActivityScore, Observation HOOSSymptoms, Observation HOOSPain)?, CqlDate>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<CqlDate> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Distinct<CqlDate>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has THA with Initial and Follow Up HOOS Assessments")]
    public bool? Has_THA_with_Initial_and_Follow_Up_HOOS_Assessments(CqlContext context)
    {
        IEnumerable<Procedure> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Total_Hip_Arthroplasty_Procedure(context);
        CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_(Procedure THAProcedure)
        {
            DataType szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = THAProcedure?.Performed;
            object szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.toInterval(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

            return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Select<Procedure, CqlInterval<CqlDateTime>>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        IEnumerable<CqlInterval<CqlDateTime>> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<CqlInterval<CqlDateTime>> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_(CqlInterval<CqlDateTime> TotalHip)
        {
            IEnumerable<CqlDate> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Date_HOOS_Total_Assessment_Completed(context);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_(CqlDate InitialHipAssessmentHOOS)
            {
                CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Start(TotalHip);
                CqlQuantity szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Quantity(90m, "days");
                CqlDate szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Add(InitialHipAssessmentHOOS, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlInterval<CqlDate> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Interval(InitialHipAssessmentHOOS, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, true, true);
                CqlDate szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_?.low;
                CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.ConvertDateToDateTime(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlDate szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Add(InitialHipAssessmentHOOS, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlInterval<CqlDate> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Interval(InitialHipAssessmentHOOS, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, true, true);
                CqlDate szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_?.high;
                CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.ConvertDateToDateTime(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlDate szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Add(InitialHipAssessmentHOOS, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlInterval<CqlDate> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Interval(InitialHipAssessmentHOOS, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, true, true);
                bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_?.lowClosed;
                CqlDate tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Add(InitialHipAssessmentHOOS, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlInterval<CqlDate> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Interval(InitialHipAssessmentHOOS, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, true, true);
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_?.highClosed;
                CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Interval(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.In<CqlDateTime>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, "day");
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Not((bool?)(InitialHipAssessmentHOOS is null));
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

                return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<CqlDate> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<CqlDate>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(CqlDate InitialHipAssessmentHOOS) =>
                TotalHip;
            IEnumerable<CqlInterval<CqlDateTime>> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

            return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<CqlInterval<CqlDateTime>> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_(CqlInterval<CqlDateTime> TotalHip)
        {
            IEnumerable<CqlDate> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Date_HOOS_Total_Assessment_Completed(context);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(CqlDate FollowUpHipAssessmentHOOS)
            {
                CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.ConvertDateToDateTime(FollowUpHipAssessmentHOOS);
                CqlDate tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.DateFrom(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.End(TotalHip);
                CqlDate tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.DateFrom(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlQuantity tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Quantity(300m, "days");
                CqlDate tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Add(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlDate tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.DateFrom(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlQuantity tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Quantity(425m, "days");
                CqlDate tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Add(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlInterval<CqlDate> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Interval(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, true, true);
                bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.In<CqlDate>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, "day");

                return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
            };
            IEnumerable<CqlDate> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<CqlDate>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(CqlDate FollowUpHipAssessmentHOOS) =>
                TotalHip;
            IEnumerable<CqlInterval<CqlDateTime>> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

            return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Exists<CqlInterval<CqlDateTime>>(szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

        return szzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition(
        definitionName: "Date HOOSJr Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_HOOSJr_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Total_interval_score__HOOSJR_(context);
        IEnumerable<CqlCode> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.ToList<CqlCode>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        IEnumerable<Observation> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = Status_1_8_000.Instance.isAssessmentPerformed(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_(Observation HOOSJr)
        {
            DataType uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = HOOSJr?.Value;
            object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Not((bool?)(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ is null));

            return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Observation> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Observation>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        CqlDate uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_(Observation DocumentedHOOSJr)
        {
            DataType uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = DocumentedHOOSJr?.Effective;
            object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.toInterval(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlDate uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.DateFrom(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

            return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<CqlDate> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Select<Observation, CqlDate>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        IEnumerable<CqlDate> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Distinct<CqlDate>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

        return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has THA with Initial and Follow Up HOOSJr Assessments")]
    public bool? Has_THA_with_Initial_and_Follow_Up_HOOSJr_Assessments(CqlContext context)
    {
        IEnumerable<Procedure> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Total_Hip_Arthroplasty_Procedure(context);
        CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_(Procedure THAProcedure)
        {
            DataType uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = THAProcedure?.Performed;
            object uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

            return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Select<Procedure, CqlInterval<CqlDateTime>>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<CqlInterval<CqlDateTime>> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<CqlInterval<CqlDateTime>> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_(CqlInterval<CqlDateTime> TotalHip)
        {
            IEnumerable<CqlDate> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Date_HOOSJr_Total_Assessment_Completed(context);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_(CqlDate InitialHipAssessment)
            {
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(TotalHip);
                CqlQuantity vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Quantity(90m, "days");
                CqlDate vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Add(InitialHipAssessment, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlInterval<CqlDate> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Interval(InitialHipAssessment, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, true, true);
                CqlDate vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_?.low;
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.ConvertDateToDateTime(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlDate vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Add(InitialHipAssessment, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlInterval<CqlDate> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Interval(InitialHipAssessment, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, true, true);
                CqlDate vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_?.high;
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.ConvertDateToDateTime(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlDate vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Add(InitialHipAssessment, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlInterval<CqlDate> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Interval(InitialHipAssessment, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, true, true);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_?.lowClosed;
                CqlDate vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Add(InitialHipAssessment, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlInterval<CqlDate> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Interval(InitialHipAssessment, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, true, true);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_?.highClosed;
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Interval(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, "day");
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Not((bool?)(InitialHipAssessment is null));
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

                return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<CqlDate> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<CqlDate>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_(CqlDate InitialHipAssessment) =>
                TotalHip;
            IEnumerable<CqlInterval<CqlDateTime>> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

            return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<CqlInterval<CqlDateTime>> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_(CqlInterval<CqlDateTime> TotalHip)
        {
            IEnumerable<CqlDate> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Date_HOOSJr_Total_Assessment_Completed(context);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_(CqlDate FollowUpHipAssessment)
            {
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.ConvertDateToDateTime(FollowUpHipAssessment);
                CqlDate wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.DateFrom(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.End(TotalHip);
                CqlDate wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.DateFrom(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlQuantity wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Quantity(300m, "days");
                CqlDate wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Add(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlDate wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.DateFrom(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlQuantity wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Quantity(425m, "days");
                CqlDate wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Add(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlInterval<CqlDate> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Interval(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, true, true);
                bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.In<CqlDate>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, "day");

                return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<CqlDate> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<CqlDate>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_(CqlDate FollowUpHipAssessment) =>
                TotalHip;
            IEnumerable<CqlInterval<CqlDateTime>> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

            return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Exists<CqlInterval<CqlDateTime>>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

        return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition(
        definitionName: "Date PROMIS10 Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_PROMIS10_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.PROMIS_10_Global_Mental_Health__GMH__score_T_score(context);
        IEnumerable<CqlCode> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.ToList<CqlCode>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = Status_1_8_000.Instance.isAssessmentPerformed(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        CqlCode wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.PROMIS_10_Global_Physical_Health__GPH__score_T_score(context);
        IEnumerable<CqlCode> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.ToList<CqlCode>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = Status_1_8_000.Instance.isAssessmentPerformed(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        IEnumerable<ValueTuple<Observation, Observation>> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.CrossJoin<Observation, Observation>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        (CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_(ValueTuple<Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = (CqlTupleMetadata_DDTAOdcFieSJbGgRLLZPYbGQb, _valueTuple.Item1, _valueTuple.Item2);

            return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<(CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Select<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_((CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)? tuple_ddtaodcfiesjbggrllzpybgqb)
        {
            DataType xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10MentalScore?.Effective;
            object xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlDate xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.DateFrom(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            DataType xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10PhysicalScore?.Effective;
            object xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlDate xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.DateFrom(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.SameAs(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, "day");
            DataType xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10PhysicalScore?.Value;
            object xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Not((bool?)(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ is null));
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10MentalScore?.Value;
            object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Not((bool?)(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ is null));
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

            return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<(CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<(CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        CqlDate xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_((CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)? tuple_ddtaodcfiesjbggrllzpybgqb)
        {
            DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10MentalScore?.Effective;
            object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.toInterval(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlDate yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.DateFrom(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10PhysicalScore?.Effective;
            object yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlDate yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.DateFrom(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlDate[] yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = [
                yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_,
                yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_,
            ];
            CqlDate yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Max<CqlDate>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ as IEnumerable<CqlDate>);

            return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<CqlDate> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Select<(CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?, CqlDate>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<CqlDate> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Distinct<CqlDate>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

        return xzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has THA with Initial and Follow Up PROMIS10 Assessments")]
    public bool? Has_THA_with_Initial_and_Follow_Up_PROMIS10_Assessments(CqlContext context)
    {
        IEnumerable<Procedure> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Total_Hip_Arthroplasty_Procedure(context);
        CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(Procedure THAProcedure)
        {
            DataType yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = THAProcedure?.Performed;
            object zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

            return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Select<Procedure, CqlInterval<CqlDateTime>>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<CqlInterval<CqlDateTime>> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<CqlInterval<CqlDateTime>> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_(CqlInterval<CqlDateTime> TotalHip)
        {
            IEnumerable<CqlDate> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Date_PROMIS10_Total_Assessment_Completed(context);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_(CqlDate InitialHipAssessmentPROMIS10)
            {
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Start(TotalHip);
                CqlQuantity zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Quantity(90m, "days");
                CqlDate zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Add(InitialHipAssessmentPROMIS10, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlInterval<CqlDate> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Interval(InitialHipAssessmentPROMIS10, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, true, true);
                CqlDate zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_?.low;
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.ConvertDateToDateTime(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlDate zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Add(InitialHipAssessmentPROMIS10, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlInterval<CqlDate> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Interval(InitialHipAssessmentPROMIS10, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, true, true);
                CqlDate zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_?.high;
                CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ConvertDateToDateTime(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlDate zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Add(InitialHipAssessmentPROMIS10, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlInterval<CqlDate> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Interval(InitialHipAssessmentPROMIS10, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, true, true);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_?.lowClosed;
                CqlDate zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Add(InitialHipAssessmentPROMIS10, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlInterval<CqlDate> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Interval(InitialHipAssessmentPROMIS10, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, true, true);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_?.highClosed;
                CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Interval(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDateTime>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, "day");
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Not((bool?)(InitialHipAssessmentPROMIS10 is null));
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

                return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<CqlDate> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<CqlDate>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_(CqlDate InitialHipAssessmentPROMIS10) =>
                TotalHip;
            IEnumerable<CqlInterval<CqlDateTime>> zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

            return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        IEnumerable<CqlInterval<CqlDateTime>> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_(CqlInterval<CqlDateTime> TotalHip)
        {
            IEnumerable<CqlDate> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Date_PROMIS10_Total_Assessment_Completed(context);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_(CqlDate FollowUpHipAssessmentPROMIS10)
            {
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.ConvertDateToDateTime(FollowUpHipAssessmentPROMIS10);
                CqlDate azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.DateFrom(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.End(TotalHip);
                CqlDate azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.DateFrom(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlQuantity azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Quantity(300m, "days");
                CqlDate azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Add(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlDate azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.DateFrom(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlQuantity azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Quantity(425m, "days");
                CqlDate azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Add(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDate> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Interval(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, true, true);
                bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDate>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, "day");

                return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
            };
            IEnumerable<CqlDate> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<CqlDate>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(CqlDate FollowUpHipAssessmentPROMIS10) =>
                TotalHip;
            IEnumerable<CqlInterval<CqlDateTime>> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

            return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Exists<CqlInterval<CqlDateTime>>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

        return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition(
        definitionName: "Date VR12 Oblique Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_VR12_Oblique_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.VR_12_Mental_component_summary__MCS__score___oblique_method_T_score(context);
        IEnumerable<CqlCode> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.ToList<CqlCode>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = Status_1_8_000.Instance.isAssessmentPerformed(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        CqlCode azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.VR_12_Physical_component_summary__PCS__score___oblique_method_T_score(context);
        IEnumerable<CqlCode> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.ToList<CqlCode>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = Status_1_8_000.Instance.isAssessmentPerformed(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<ValueTuple<Observation, Observation>> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.CrossJoin<Observation, Observation>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_(ValueTuple<Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = (CqlTupleMetadata_GAdRFKRaHUUGJcVHWQWRUjhRH, _valueTuple.Item1, _valueTuple.Item2);

            return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Select<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_((CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? tuple_gadrfkrahuugjcvhwqwrujhrh)
        {
            DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Effective;
            object bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlDate bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.DateFrom(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Effective;
            object bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlDate bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.DateFrom(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.SameAs(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, "day");
            DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Value;
            object bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Not((bool?)(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ is null));
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            DataType czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Value;
            object czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Not((bool?)(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ is null));
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

            return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        CqlDate bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_((CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? tuple_gadrfkrahuugjcvhwqwrujhrh)
        {
            DataType czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Effective;
            object czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.toInterval(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlDate czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.DateFrom(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            DataType czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Effective;
            object czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.toInterval(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlDate czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.DateFrom(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlDate[] czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = [
                czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_,
                czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_,
            ];
            CqlDate czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Max<CqlDate>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ as IEnumerable<CqlDate>);

            return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<CqlDate> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?, CqlDate>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<CqlDate> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Distinct<CqlDate>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

        return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has THA with Initial and Follow Up VR12 Oblique Assessments")]
    public bool? Has_THA_with_Initial_and_Follow_Up_VR12_Oblique_Assessments(CqlContext context)
    {
        IEnumerable<Procedure> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Total_Hip_Arthroplasty_Procedure(context);
        CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(Procedure THAProcedure)
        {
            DataType dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = THAProcedure?.Performed;
            object dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);

            return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Select<Procedure, CqlInterval<CqlDateTime>>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<CqlInterval<CqlDateTime>> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<CqlInterval<CqlDateTime>> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_(CqlInterval<CqlDateTime> TotalHip)
        {
            IEnumerable<CqlDate> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Date_VR12_Oblique_Total_Assessment_Completed(context);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_(CqlDate InitialHipAssessmentOblique)
            {
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Start(TotalHip);
                CqlQuantity dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Quantity(90m, "days");
                CqlDate dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Add(InitialHipAssessmentOblique, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlInterval<CqlDate> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Interval(InitialHipAssessmentOblique, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, true, true);
                CqlDate dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_?.low;
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.ConvertDateToDateTime(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlDate dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Add(InitialHipAssessmentOblique, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlInterval<CqlDate> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Interval(InitialHipAssessmentOblique, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, true, true);
                CqlDate dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_?.high;
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ConvertDateToDateTime(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlDate dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Add(InitialHipAssessmentOblique, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlInterval<CqlDate> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Interval(InitialHipAssessmentOblique, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, true, true);
                bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_?.lowClosed;
                CqlDate dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Add(InitialHipAssessmentOblique, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                CqlInterval<CqlDate> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Interval(InitialHipAssessmentOblique, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, true, true);
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_?.highClosed;
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Interval(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.In<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, "day");
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Not((bool?)(InitialHipAssessmentOblique is null));
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

                return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<CqlDate> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<CqlDate>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_(CqlDate InitialHipAssessmentOblique) =>
                TotalHip;
            IEnumerable<CqlInterval<CqlDateTime>> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

            return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<CqlInterval<CqlDateTime>> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_(CqlInterval<CqlDateTime> TotalHip)
        {
            IEnumerable<CqlDate> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Date_VR12_Oblique_Total_Assessment_Completed(context);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_(CqlDate FollowUpHipAssessmentOblique)
            {
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.ConvertDateToDateTime(FollowUpHipAssessmentOblique);
                CqlDate ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.DateFrom(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.End(TotalHip);
                CqlDate ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.DateFrom(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlQuantity ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Quantity(300m, "days");
                CqlDate ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Add(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlDate ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.DateFrom(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlQuantity ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Quantity(425m, "days");
                CqlDate ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Add(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlInterval<CqlDate> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Interval(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, true, true);
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.In<CqlDate>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, "day");

                return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<CqlDate> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<CqlDate>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(CqlDate FollowUpHipAssessmentOblique) =>
                TotalHip;
            IEnumerable<CqlInterval<CqlDateTime>> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

            return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Exists<CqlInterval<CqlDateTime>>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

        return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition(
        definitionName: "Date VR12 Orthogonal Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_VR12_Orthogonal_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.VR_12_Mental_component_summary__MCS__score___orthogonal_method_T_score(context);
        IEnumerable<CqlCode> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.ToList<CqlCode>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = Status_1_8_000.Instance.isAssessmentPerformed(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        CqlCode fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.VR_12_Physical_component_summary__PCS__score___orthogonal_method_T_score(context);
        IEnumerable<CqlCode> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.ToList<CqlCode>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = Status_1_8_000.Instance.isAssessmentPerformed(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<ValueTuple<Observation, Observation>> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.CrossJoin<Observation, Observation>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_(ValueTuple<Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = (CqlTupleMetadata_GAdRFKRaHUUGJcVHWQWRUjhRH, _valueTuple.Item1, _valueTuple.Item2);

            return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Select<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_((CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? tuple_gadrfkrahuugjcvhwqwrujhrh)
        {
            DataType fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Effective;
            object fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlDate fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.DateFrom(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            DataType fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Effective;
            object fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Start(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlDate fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.DateFrom(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.SameAs(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, "day");
            DataType fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Value;
            object fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Not((bool?)(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ is null));
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Value;
            object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Not((bool?)(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ is null));
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

            return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        CqlDate fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_((CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? tuple_gadrfkrahuugjcvhwqwrujhrh)
        {
            DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Effective;
            object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlDate gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.DateFrom(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Effective;
            object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlDate gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.DateFrom(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlDate[] gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = [
                gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_,
                gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_,
            ];
            CqlDate gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Max<CqlDate>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ as IEnumerable<CqlDate>);

            return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<CqlDate> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Select<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?, CqlDate>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<CqlDate> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Distinct<CqlDate>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has THA with Initial and Follow Up VR12 Orthogonal Assessments")]
    public bool? Has_THA_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments(CqlContext context)
    {
        IEnumerable<Procedure> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Total_Hip_Arthroplasty_Procedure(context);
        CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_(Procedure THAProcedure)
        {
            DataType hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = THAProcedure?.Performed;
            object hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.toInterval(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

            return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Select<Procedure, CqlInterval<CqlDateTime>>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<CqlInterval<CqlDateTime>> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        IEnumerable<CqlInterval<CqlDateTime>> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_(CqlInterval<CqlDateTime> TotalHip)
        {
            IEnumerable<CqlDate> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Date_VR12_Orthogonal_Total_Assessment_Completed(context);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_(CqlDate InitialHipAssessmentOrthogonal)
            {
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Start(TotalHip);
                CqlQuantity hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Quantity(90m, "days");
                CqlDate hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Add(InitialHipAssessmentOrthogonal, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlInterval<CqlDate> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Interval(InitialHipAssessmentOrthogonal, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, true, true);
                CqlDate hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_?.low;
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.ConvertDateToDateTime(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlDate hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Add(InitialHipAssessmentOrthogonal, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlInterval<CqlDate> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Interval(InitialHipAssessmentOrthogonal, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, true, true);
                CqlDate hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_?.high;
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.ConvertDateToDateTime(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlDate hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Add(InitialHipAssessmentOrthogonal, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlInterval<CqlDate> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Interval(InitialHipAssessmentOrthogonal, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, true, true);
                bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_?.lowClosed;
                CqlDate hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Add(InitialHipAssessmentOrthogonal, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
                CqlInterval<CqlDate> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Interval(InitialHipAssessmentOrthogonal, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, true, true);
                bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_?.highClosed;
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Interval(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, "day");
                bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Not((bool?)(InitialHipAssessmentOrthogonal is null));
                bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

                return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<CqlDate> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<CqlDate>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(CqlDate InitialHipAssessmentOrthogonal) =>
                TotalHip;
            IEnumerable<CqlInterval<CqlDateTime>> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

            return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        IEnumerable<CqlInterval<CqlDateTime>> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_(CqlInterval<CqlDateTime> TotalHip)
        {
            IEnumerable<CqlDate> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Date_VR12_Orthogonal_Total_Assessment_Completed(context);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(CqlDate FollowUpHipAssessmentOrthogonal)
            {
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.ConvertDateToDateTime(FollowUpHipAssessmentOrthogonal);
                CqlDate izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.DateFrom(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.End(TotalHip);
                CqlDate izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.DateFrom(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlQuantity izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Quantity(300m, "days");
                CqlDate izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Add(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlDate izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.DateFrom(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                CqlQuantity izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Quantity(425m, "days");
                CqlDate izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Add(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlInterval<CqlDate> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Interval(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, true, true);
                bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.In<CqlDate>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, "day");

                return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<CqlDate> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<CqlDate>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_(CqlDate FollowUpHipAssessmentOrthogonal) =>
                TotalHip;
            IEnumerable<CqlInterval<CqlDateTime>> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Select<CqlDate, CqlInterval<CqlDateTime>>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

            return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.SelectMany<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Exists<CqlInterval<CqlDateTime>>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

        return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Has_THA_with_Initial_and_Follow_Up_HOOS_Assessments(context);
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Has_THA_with_Initial_and_Follow_Up_HOOSJr_Assessments(context);
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Or(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Has_THA_with_Initial_and_Follow_Up_PROMIS10_Assessments(context);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Or(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Has_THA_with_Initial_and_Follow_Up_VR12_Oblique_Assessments(context);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Or(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Has_THA_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments(context);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Or(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

        return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    #endregion Expressions

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
