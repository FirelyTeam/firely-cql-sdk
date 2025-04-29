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
[CqlLibrary("FunctionalStatusAssessmentsforHeartFailureFHIR", "0.1.000")]
public partial class FunctionalStatusAssessmentsforHeartFailureFHIR_0_1_000 : ILibrary, ISingleton<FunctionalStatusAssessmentsforHeartFailureFHIR_0_1_000>
{
    private FunctionalStatusAssessmentsforHeartFailureFHIR_0_1_000() {}

    public static FunctionalStatusAssessmentsforHeartFailureFHIR_0_1_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "FunctionalStatusAssessmentsforHeartFailureFHIR";
    public string Version => "0.1.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, QICoreCommon_2_1_000.Instance, SupplementalDataElements_3_5_000.Instance, Hospice_6_12_000.Instance, Status_1_8_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    #region ValueSet: Heart Failure
    [CqlValueSetDefinition(
        definitionName: "Heart Failure",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.376",
        valueSetVersion: null)]
    public CqlValueSet Heart_Failure(CqlContext context) => _Heart_Failure;

    private static readonly CqlValueSet _Heart_Failure = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.376", null);
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

    #region Code: Emotional score [MLHFQ]
    [CqlCodeDefinition(
        definitionName: "Emotional score [MLHFQ]",
        codeId: "85609-6",
        codeSystem: "http://loinc.org")]
    public CqlCode Emotional_score__MLHFQ_(CqlContext context) => _Emotional_score__MLHFQ_;

    private static readonly CqlCode _Emotional_score__MLHFQ_ = new CqlCode("85609-6", "http://loinc.org", default, default);
    #endregion

    #region Code: Kansas City Cardiomyopathy Questionnaire - 12 item [KCCQ-12]
    [CqlCodeDefinition(
        definitionName: "Kansas City Cardiomyopathy Questionnaire - 12 item [KCCQ-12]",
        codeId: "86923-0",
        codeSystem: "http://loinc.org")]
    public CqlCode Kansas_City_Cardiomyopathy_Questionnaire___12_item__KCCQ_12_(CqlContext context) => _Kansas_City_Cardiomyopathy_Questionnaire___12_item__KCCQ_12_;

    private static readonly CqlCode _Kansas_City_Cardiomyopathy_Questionnaire___12_item__KCCQ_12_ = new CqlCode("86923-0", "http://loinc.org", default, default);
    #endregion

    #region Code: Overall summary score [KCCQ-12]
    [CqlCodeDefinition(
        definitionName: "Overall summary score [KCCQ-12]",
        codeId: "86924-8",
        codeSystem: "http://loinc.org")]
    public CqlCode Overall_summary_score__KCCQ_12_(CqlContext context) => _Overall_summary_score__KCCQ_12_;

    private static readonly CqlCode _Overall_summary_score__KCCQ_12_ = new CqlCode("86924-8", "http://loinc.org", default, default);
    #endregion

    #region Code: Overall summary score [KCCQ]
    [CqlCodeDefinition(
        definitionName: "Overall summary score [KCCQ]",
        codeId: "71940-1",
        codeSystem: "http://loinc.org")]
    public CqlCode Overall_summary_score__KCCQ_(CqlContext context) => _Overall_summary_score__KCCQ_;

    private static readonly CqlCode _Overall_summary_score__KCCQ_ = new CqlCode("71940-1", "http://loinc.org", default, default);
    #endregion

    #region Code: Physical limitation score [KCCQ]
    [CqlCodeDefinition(
        definitionName: "Physical limitation score [KCCQ]",
        codeId: "72195-1",
        codeSystem: "http://loinc.org")]
    public CqlCode Physical_limitation_score__KCCQ_(CqlContext context) => _Physical_limitation_score__KCCQ_;

    private static readonly CqlCode _Physical_limitation_score__KCCQ_ = new CqlCode("72195-1", "http://loinc.org", default, default);
    #endregion

    #region Code: Physical score [MLHFQ]
    [CqlCodeDefinition(
        definitionName: "Physical score [MLHFQ]",
        codeId: "85618-7",
        codeSystem: "http://loinc.org")]
    public CqlCode Physical_score__MLHFQ_(CqlContext context) => _Physical_score__MLHFQ_;

    private static readonly CqlCode _Physical_score__MLHFQ_ = new CqlCode("85618-7", "http://loinc.org", default, default);
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

    #region Code: PROMIS-29 Anxiety score T-score
    [CqlCodeDefinition(
        definitionName: "PROMIS-29 Anxiety score T-score",
        codeId: "71967-4",
        codeSystem: "http://loinc.org")]
    public CqlCode PROMIS_29_Anxiety_score_T_score(CqlContext context) => _PROMIS_29_Anxiety_score_T_score;

    private static readonly CqlCode _PROMIS_29_Anxiety_score_T_score = new CqlCode("71967-4", "http://loinc.org", default, default);
    #endregion

    #region Code: PROMIS-29 Depression score T-score
    [CqlCodeDefinition(
        definitionName: "PROMIS-29 Depression score T-score",
        codeId: "71965-8",
        codeSystem: "http://loinc.org")]
    public CqlCode PROMIS_29_Depression_score_T_score(CqlContext context) => _PROMIS_29_Depression_score_T_score;

    private static readonly CqlCode _PROMIS_29_Depression_score_T_score = new CqlCode("71965-8", "http://loinc.org", default, default);
    #endregion

    #region Code: PROMIS-29 Fatigue score T-score
    [CqlCodeDefinition(
        definitionName: "PROMIS-29 Fatigue score T-score",
        codeId: "71963-3",
        codeSystem: "http://loinc.org")]
    public CqlCode PROMIS_29_Fatigue_score_T_score(CqlContext context) => _PROMIS_29_Fatigue_score_T_score;

    private static readonly CqlCode _PROMIS_29_Fatigue_score_T_score = new CqlCode("71963-3", "http://loinc.org", default, default);
    #endregion

    #region Code: PROMIS-29 Pain interference score T-score
    [CqlCodeDefinition(
        definitionName: "PROMIS-29 Pain interference score T-score",
        codeId: "71961-7",
        codeSystem: "http://loinc.org")]
    public CqlCode PROMIS_29_Pain_interference_score_T_score(CqlContext context) => _PROMIS_29_Pain_interference_score_T_score;

    private static readonly CqlCode _PROMIS_29_Pain_interference_score_T_score = new CqlCode("71961-7", "http://loinc.org", default, default);
    #endregion

    #region Code: PROMIS-29 Physical function score T-score
    [CqlCodeDefinition(
        definitionName: "PROMIS-29 Physical function score T-score",
        codeId: "71959-1",
        codeSystem: "http://loinc.org")]
    public CqlCode PROMIS_29_Physical_function_score_T_score(CqlContext context) => _PROMIS_29_Physical_function_score_T_score;

    private static readonly CqlCode _PROMIS_29_Physical_function_score_T_score = new CqlCode("71959-1", "http://loinc.org", default, default);
    #endregion

    #region Code: PROMIS-29 Satisfaction with participation in social roles score T-score
    [CqlCodeDefinition(
        definitionName: "PROMIS-29 Satisfaction with participation in social roles score T-score",
        codeId: "71957-5",
        codeSystem: "http://loinc.org")]
    public CqlCode PROMIS_29_Satisfaction_with_participation_in_social_roles_score_T_score(CqlContext context) => _PROMIS_29_Satisfaction_with_participation_in_social_roles_score_T_score;

    private static readonly CqlCode _PROMIS_29_Satisfaction_with_participation_in_social_roles_score_T_score = new CqlCode("71957-5", "http://loinc.org", default, default);
    #endregion

    #region Code: PROMIS-29 Sleep disturbance score T-score
    [CqlCodeDefinition(
        definitionName: "PROMIS-29 Sleep disturbance score T-score",
        codeId: "71955-9",
        codeSystem: "http://loinc.org")]
    public CqlCode PROMIS_29_Sleep_disturbance_score_T_score(CqlContext context) => _PROMIS_29_Sleep_disturbance_score_T_score;

    private static readonly CqlCode _PROMIS_29_Sleep_disturbance_score_T_score = new CqlCode("71955-9", "http://loinc.org", default, default);
    #endregion

    #region Code: Quality of life score [KCCQ]
    [CqlCodeDefinition(
        definitionName: "Quality of life score [KCCQ]",
        codeId: "72189-4",
        codeSystem: "http://loinc.org")]
    public CqlCode Quality_of_life_score__KCCQ_(CqlContext context) => _Quality_of_life_score__KCCQ_;

    private static readonly CqlCode _Quality_of_life_score__KCCQ_ = new CqlCode("72189-4", "http://loinc.org", default, default);
    #endregion

    #region Code: Self-efficacy score [KCCQ]
    [CqlCodeDefinition(
        definitionName: "Self-efficacy score [KCCQ]",
        codeId: "72190-2",
        codeSystem: "http://loinc.org")]
    public CqlCode Self_efficacy_score__KCCQ_(CqlContext context) => _Self_efficacy_score__KCCQ_;

    private static readonly CqlCode _Self_efficacy_score__KCCQ_ = new CqlCode("72190-2", "http://loinc.org", default, default);
    #endregion

    #region Code: Severe cognitive impairment (finding)
    [CqlCodeDefinition(
        definitionName: "Severe cognitive impairment (finding)",
        codeId: "702956004",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Severe_cognitive_impairment__finding_(CqlContext context) => _Severe_cognitive_impairment__finding_;

    private static readonly CqlCode _Severe_cognitive_impairment__finding_ = new CqlCode("702956004", "http://snomed.info/sct", default, default);
    #endregion

    #region Code: Social limitation score [KCCQ]
    [CqlCodeDefinition(
        definitionName: "Social limitation score [KCCQ]",
        codeId: "72196-9",
        codeSystem: "http://loinc.org")]
    public CqlCode Social_limitation_score__KCCQ_(CqlContext context) => _Social_limitation_score__KCCQ_;

    private static readonly CqlCode _Social_limitation_score__KCCQ_ = new CqlCode("72196-9", "http://loinc.org", default, default);
    #endregion

    #region Code: Symptom stability score [KCCQ]
    [CqlCodeDefinition(
        definitionName: "Symptom stability score [KCCQ]",
        codeId: "72194-4",
        codeSystem: "http://loinc.org")]
    public CqlCode Symptom_stability_score__KCCQ_(CqlContext context) => _Symptom_stability_score__KCCQ_;

    private static readonly CqlCode _Symptom_stability_score__KCCQ_ = new CqlCode("72194-4", "http://loinc.org", default, default);
    #endregion

    #region Code: Total score [MLHFQ]
    [CqlCodeDefinition(
        definitionName: "Total score [MLHFQ]",
        codeId: "71938-5",
        codeSystem: "http://loinc.org")]
    public CqlCode Total_score__MLHFQ_(CqlContext context) => _Total_score__MLHFQ_;

    private static readonly CqlCode _Total_score__MLHFQ_ = new CqlCode("71938-5", "http://loinc.org", default, default);
    #endregion

    #region Code: Total symptom score [KCCQ]
    [CqlCodeDefinition(
        definitionName: "Total symptom score [KCCQ]",
        codeId: "72191-0",
        codeSystem: "http://loinc.org")]
    public CqlCode Total_symptom_score__KCCQ_(CqlContext context) => _Total_symptom_score__KCCQ_;

    private static readonly CqlCode _Total_symptom_score__KCCQ_ = new CqlCode("72191-0", "http://loinc.org", default, default);
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

    #region Code: VR-36 Mental component summary (MCS) score - oblique method T-score
    [CqlCodeDefinition(
        definitionName: "VR-36 Mental component summary (MCS) score - oblique method T-score",
        codeId: "71990-6",
        codeSystem: "http://loinc.org")]
    public CqlCode VR_36_Mental_component_summary__MCS__score___oblique_method_T_score(CqlContext context) => _VR_36_Mental_component_summary__MCS__score___oblique_method_T_score;

    private static readonly CqlCode _VR_36_Mental_component_summary__MCS__score___oblique_method_T_score = new CqlCode("71990-6", "http://loinc.org", default, default);
    #endregion

    #region Code: VR-36 Mental component summary (MCS) score - orthogonal method T-score
    [CqlCodeDefinition(
        definitionName: "VR-36 Mental component summary (MCS) score - orthogonal method T-score",
        codeId: "72008-6",
        codeSystem: "http://loinc.org")]
    public CqlCode VR_36_Mental_component_summary__MCS__score___orthogonal_method_T_score(CqlContext context) => _VR_36_Mental_component_summary__MCS__score___orthogonal_method_T_score;

    private static readonly CqlCode _VR_36_Mental_component_summary__MCS__score___orthogonal_method_T_score = new CqlCode("72008-6", "http://loinc.org", default, default);
    #endregion

    #region Code: VR-36 Physical component summary (PCS) score - oblique method T-score
    [CqlCodeDefinition(
        definitionName: "VR-36 Physical component summary (PCS) score - oblique method T-score",
        codeId: "71989-8",
        codeSystem: "http://loinc.org")]
    public CqlCode VR_36_Physical_component_summary__PCS__score___oblique_method_T_score(CqlContext context) => _VR_36_Physical_component_summary__PCS__score___oblique_method_T_score;

    private static readonly CqlCode _VR_36_Physical_component_summary__PCS__score___oblique_method_T_score = new CqlCode("71989-8", "http://loinc.org", default, default);
    #endregion

    #region Code: VR-36 Physical component summary (PCS) score - orthogonal method T-score
    [CqlCodeDefinition(
        definitionName: "VR-36 Physical component summary (PCS) score - orthogonal method T-score",
        codeId: "72007-8",
        codeSystem: "http://loinc.org")]
    public CqlCode VR_36_Physical_component_summary__PCS__score___orthogonal_method_T_score(CqlContext context) => _VR_36_Physical_component_summary__PCS__score___orthogonal_method_T_score;

    private static readonly CqlCode _VR_36_Physical_component_summary__PCS__score___orthogonal_method_T_score = new CqlCode("72007-8", "http://loinc.org", default, default);
    #endregion

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition(
        definitionName: "LOINC")]
    public CqlCode[] LOINC(CqlContext context)
    {
        CqlCode[] ezzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = [
            new CqlCode("85609-6", "http://loinc.org", default, default),
            new CqlCode("86923-0", "http://loinc.org", default, default),
            new CqlCode("86924-8", "http://loinc.org", default, default),
            new CqlCode("71940-1", "http://loinc.org", default, default),
            new CqlCode("72195-1", "http://loinc.org", default, default),
            new CqlCode("85618-7", "http://loinc.org", default, default),
            new CqlCode("71969-0", "http://loinc.org", default, default),
            new CqlCode("71971-6", "http://loinc.org", default, default),
            new CqlCode("71967-4", "http://loinc.org", default, default),
            new CqlCode("71965-8", "http://loinc.org", default, default),
            new CqlCode("71963-3", "http://loinc.org", default, default),
            new CqlCode("71961-7", "http://loinc.org", default, default),
            new CqlCode("71959-1", "http://loinc.org", default, default),
            new CqlCode("71957-5", "http://loinc.org", default, default),
            new CqlCode("71955-9", "http://loinc.org", default, default),
            new CqlCode("72189-4", "http://loinc.org", default, default),
            new CqlCode("72190-2", "http://loinc.org", default, default),
            new CqlCode("72196-9", "http://loinc.org", default, default),
            new CqlCode("72194-4", "http://loinc.org", default, default),
            new CqlCode("71938-5", "http://loinc.org", default, default),
            new CqlCode("72191-0", "http://loinc.org", default, default),
            new CqlCode("72026-8", "http://loinc.org", default, default),
            new CqlCode("72028-4", "http://loinc.org", default, default),
            new CqlCode("72025-0", "http://loinc.org", default, default),
            new CqlCode("72027-6", "http://loinc.org", default, default),
            new CqlCode("71990-6", "http://loinc.org", default, default),
            new CqlCode("72008-6", "http://loinc.org", default, default),
            new CqlCode("71989-8", "http://loinc.org", default, default),
            new CqlCode("72007-8", "http://loinc.org", default, default),
        ];

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "SNOMEDCT")]
    public CqlCode[] SNOMEDCT(CqlContext context)
    {
        CqlCode[] ezzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = [
            new CqlCode("702956004", "http://snomed.info/sct", default, default),
        ];

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Interval(ezzzzzzzzzzzzzzzzzzzzzzzzzzzo_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzp_, true, true);
        object ezzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.ResolveParameter("FunctionalStatusAssessmentsforHeartFailureFHIR-0.1.000", "Measurement Period", ezzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

        return (CqlInterval<CqlDateTime>)ezzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> ezzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient ezzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.SingletonFrom<Patient>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? ezzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> ezzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? ezzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode ezzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition(
        definitionName: "Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Office_Visit(context);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Union<Encounter>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzz_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Union<Encounter>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, fzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = Status_1_8_000.Instance.isEncounterPerformed(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(Encounter ValidEncounter)
        {
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Measurement_Period(context);
            Period fzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.toInterval(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ as object);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, "day");

            return fzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Encounter>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

        return fzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition(
        definitionName: "Two Outpatient Encounters during Measurement Period")]
    public IEnumerable<Encounter> Two_Outpatient_Encounters_during_Measurement_Period(CqlContext context)
    {
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Qualifying_Encounters(context);
        IEnumerable<ValueTuple<Encounter, Encounter>> fzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.CrossJoin<Encounter, Encounter>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        (CqlTupleMetadata, Encounter OfficeVisit1, Encounter OfficeVisit2)? fzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(ValueTuple<Encounter, Encounter> _valueTuple)
        {
            (CqlTupleMetadata, Encounter OfficeVisit1, Encounter OfficeVisit2)? fzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = (CqlTupleMetadata_DbNMMZBTISSRTNdiShceSFVih, _valueTuple.Item1, _valueTuple.Item2);

            return fzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter OfficeVisit1, Encounter OfficeVisit2)?> fzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Select<ValueTuple<Encounter, Encounter>, (CqlTupleMetadata, Encounter OfficeVisit1, Encounter OfficeVisit2)?>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzt_((CqlTupleMetadata, Encounter OfficeVisit1, Encounter OfficeVisit2)? tuple_dbnmmzbtissrtndishcesfvih)
        {
            Period fzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = tuple_dbnmmzbtissrtndishcesfvih?.OfficeVisit2?.Period;
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzza_ as object);
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            Period gzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = tuple_dbnmmzbtissrtndishcesfvih?.OfficeVisit1?.Period;
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzze_ as object);
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.End(gzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlQuantity gzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Quantity(1m, "day");
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Add(gzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.SameOrAfter(gzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, "day");

            return gzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter OfficeVisit1, Encounter OfficeVisit2)?> fzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<(CqlTupleMetadata, Encounter OfficeVisit1, Encounter OfficeVisit2)?>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        Encounter fzzzzzzzzzzzzzzzzzzzzzzzzzzzv_((CqlTupleMetadata, Encounter OfficeVisit1, Encounter OfficeVisit2)? tuple_dbnmmzbtissrtndishcesfvih) =>
            tuple_dbnmmzbtissrtndishcesfvih?.OfficeVisit1;
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Select<(CqlTupleMetadata, Encounter OfficeVisit1, Encounter OfficeVisit2)?, Encounter>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Distinct<Encounter>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

        return fzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient gzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Patient(context);
        Date gzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = gzzzzzzzzzzzzzzzzzzzzzzzzzzzk_?.BirthDateElement;
        string gzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = gzzzzzzzzzzzzzzzzzzzzzzzzzzzl_?.Value;
        CqlDate gzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.ConvertStringToDate(gzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Measurement_Period(context);
        CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        CqlDate gzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.DateFrom(gzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        int? gzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.CalculateAgeAt(gzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, "year");
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.GreaterOrEqual(gzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, 18);
        CqlValueSet gzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Heart_Failure(context);
        IEnumerable<Condition> gzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzv_(Condition HeartFailure)
        {
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HeartFailure);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Measurement_Period(context);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.OverlapsBefore(hzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, default);

            return hzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<Condition> gzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Condition>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Exists<Condition>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Two_Outpatient_Encounters_during_Measurement_Period(context);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Exists<Encounter>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, hzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

        return hzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Initial_Population(context);

        return hzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        CqlCode hzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Severe_cognitive_impairment__finding_(context);
        IEnumerable<CqlCode> hzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.ToList<CqlCode>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<Condition> hzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, hzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(Condition SevereCognitiveImpairment)
        {
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, SevereCognitiveImpairment);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Measurement_Period(context);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Overlaps(hzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, default);

            return hzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Condition> hzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Condition>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Exists<Condition>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Or(hzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

        return hzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition(
        definitionName: "Date PROMIS10 Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_PROMIS10_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode hzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.PROMIS_10_Global_Mental_Health__GMH__score_T_score(context);
        IEnumerable<CqlCode> hzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ToList<CqlCode>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, hzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = Status_1_8_000.Instance.isAssessmentPerformed(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        CqlCode hzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.PROMIS_10_Global_Physical_Health__GPH__score_T_score(context);
        IEnumerable<CqlCode> hzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.ToList<CqlCode>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, hzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = Status_1_8_000.Instance.isAssessmentPerformed(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<ValueTuple<Observation, Observation>> hzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.CrossJoin<Observation, Observation>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        (CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)? izzzzzzzzzzzzzzzzzzzzzzzzzzza_(ValueTuple<Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)? izzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = (CqlTupleMetadata_DDTAOdcFieSJbGgRLLZPYbGQb, _valueTuple.Item1, _valueTuple.Item2);

            return izzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<(CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?> izzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Select<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, izzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzc_((CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)? tuple_ddtaodcfiesjbggrllzpybgqb)
        {
            DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10MentalScore?.Effective;
            object izzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.toInterval(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(izzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlDate izzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.DateFrom(izzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10PhysicalScore?.Effective;
            object izzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(izzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlDate izzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.DateFrom(izzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.SameAs(izzzzzzzzzzzzzzzzzzzzzzzzzzzm_, izzzzzzzzzzzzzzzzzzzzzzzzzzzr_, "day");
            DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10MentalScore?.Value;
            object izzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Not((bool?)(izzzzzzzzzzzzzzzzzzzzzzzzzzzu_ is null));
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzzzzzzs_, izzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10PhysicalScore?.Value;
            object izzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Not((bool?)(izzzzzzzzzzzzzzzzzzzzzzzzzzzy_ is null));
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzzzzzzw_, izzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

            return jzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<(CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?> izzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<(CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?>(izzzzzzzzzzzzzzzzzzzzzzzzzzzb_, izzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        CqlDate izzzzzzzzzzzzzzzzzzzzzzzzzzze_((CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)? tuple_ddtaodcfiesjbggrllzpybgqb)
        {
            DataType jzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10MentalScore?.Effective;
            object jzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.toInterval(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Start(jzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlDate jzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.DateFrom(jzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

            return jzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<CqlDate> izzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Select<(CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?, CqlDate>(izzzzzzzzzzzzzzzzzzzzzzzzzzzd_, izzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        IEnumerable<CqlDate> izzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Distinct<CqlDate>(izzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

        return izzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Encounter with Initial and Follow Up PROMIS10 Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_PROMIS10_Assessments(CqlContext context)
    {
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Qualifying_Encounters(context);
        IEnumerable<CqlDate> jzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Date_PROMIS10_Total_Assessment_Completed(context);
        IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> jzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS10Date, CqlDate FollowupPROMIS10Date)? jzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS10Date, CqlDate FollowupPROMIS10Date)? jzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = (CqlTupleMetadata_BGYjYGLNPKWAZTBCVAdLDDTMj, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return jzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS10Date, CqlDate FollowupPROMIS10Date)?> jzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS10Date, CqlDate FollowupPROMIS10Date)?>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzm_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS10Date, CqlDate FollowupPROMIS10Date)? tuple_dzhwgxhmbfavmzfaszbeksohj)
        {
            Period jzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = tuple_dzhwgxhmbfavmzfaszbeksohj?.ValidEncounters?.Period;
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ as object);
            CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.End(jzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Measurement_Period(context);
            CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.End(jzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlQuantity jzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Quantity(180m, "days");
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Subtract(jzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.SameOrBefore(jzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, kzzzzzzzzzzzzzzzzzzzzzzzzzzza_, "day");
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.ConvertDateToDateTime(tuple_dzhwgxhmbfavmzfaszbeksohj?.InitialPROMIS10Date);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzze_ as object);
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.End(kzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlQuantity kzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Quantity(14m, "days");
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Subtract(kzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ as object);
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.End(kzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Interval(kzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, true, true);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.In<CqlDateTime>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, "day");
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ as object);
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.End(kzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Not((bool?)(kzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ is null));
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.ConvertDateToDateTime(tuple_dzhwgxhmbfavmzfaszbeksohj?.FollowupPROMIS10Date);
            CqlDate kzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.DateFrom(kzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlDate kzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.DateFrom(kzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlQuantity lzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Quantity(30m, "days");
            CqlDate lzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Add(kzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, lzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlDate lzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.DateFrom(kzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlDate lzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Add(lzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDate> lzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Interval(lzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, true, true);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.In<CqlDate>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, "day");
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

            return lzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS10Date, CqlDate FollowupPROMIS10Date)?> jzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS10Date, CqlDate FollowupPROMIS10Date)?>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        Encounter jzzzzzzzzzzzzzzzzzzzzzzzzzzzo_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS10Date, CqlDate FollowupPROMIS10Date)? tuple_dzhwgxhmbfavmzfaszbeksohj) =>
            tuple_dzhwgxhmbfavmzfaszbeksohj?.ValidEncounters;
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Select<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS10Date, CqlDate FollowupPROMIS10Date)?, Encounter>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Distinct<Encounter>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Exists<Encounter>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

        return jzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition(
        definitionName: "Date PROMIS29 Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_PROMIS29_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode lzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.PROMIS_29_Sleep_disturbance_score_T_score(context);
        IEnumerable<CqlCode> lzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.ToList<CqlCode>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, lzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = Status_1_8_000.Instance.isAssessmentPerformed(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        CqlCode lzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.PROMIS_29_Satisfaction_with_participation_in_social_roles_score_T_score(context);
        IEnumerable<CqlCode> lzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.ToList<CqlCode>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, lzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = Status_1_8_000.Instance.isAssessmentPerformed(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        CqlCode lzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.PROMIS_29_Physical_function_score_T_score(context);
        IEnumerable<CqlCode> lzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ToList<CqlCode>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, lzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = Status_1_8_000.Instance.isAssessmentPerformed(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        CqlCode lzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.PROMIS_29_Pain_interference_score_T_score(context);
        IEnumerable<CqlCode> lzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.ToList<CqlCode>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, lzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = Status_1_8_000.Instance.isAssessmentPerformed(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        CqlCode lzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.PROMIS_29_Fatigue_score_T_score(context);
        IEnumerable<CqlCode> mzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.ToList<CqlCode>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, mzzzzzzzzzzzzzzzzzzzzzzzzzzza_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = Status_1_8_000.Instance.isAssessmentPerformed(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        CqlCode mzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.PROMIS_29_Depression_score_T_score(context);
        IEnumerable<CqlCode> mzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.ToList<CqlCode>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, mzzzzzzzzzzzzzzzzzzzzzzzzzzze_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = Status_1_8_000.Instance.isAssessmentPerformed(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        CqlCode mzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.PROMIS_29_Anxiety_score_T_score(context);
        IEnumerable<CqlCode> mzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.ToList<CqlCode>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, mzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> mzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = Status_1_8_000.Instance.isAssessmentPerformed(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<ValueTuple<Observation, Observation, Observation, Observation, Observation, Observation, Observation>> mzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.CrossJoin<Observation, Observation, Observation, Observation, Observation, Observation, Observation>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        (CqlTupleMetadata, Observation Promis29Sleep, Observation Promis29SocialRoles, Observation Promis29Physical, Observation Promis29Pain, Observation Promis29Fatigue, Observation Promis29Depression, Observation Promis29Anxiety)? mzzzzzzzzzzzzzzzzzzzzzzzzzzzm_(ValueTuple<Observation, Observation, Observation, Observation, Observation, Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation Promis29Sleep, Observation Promis29SocialRoles, Observation Promis29Physical, Observation Promis29Pain, Observation Promis29Fatigue, Observation Promis29Depression, Observation Promis29Anxiety)? mzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = (CqlTupleMetadata_DBUJFOVGBcbhIQPWARNQHKUaX, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3, _valueTuple.Item4, _valueTuple.Item5, _valueTuple.Item6, _valueTuple.Item7);

            return mzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<(CqlTupleMetadata, Observation Promis29Sleep, Observation Promis29SocialRoles, Observation Promis29Physical, Observation Promis29Pain, Observation Promis29Fatigue, Observation Promis29Depression, Observation Promis29Anxiety)?> mzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Select<ValueTuple<Observation, Observation, Observation, Observation, Observation, Observation, Observation>, (CqlTupleMetadata, Observation Promis29Sleep, Observation Promis29SocialRoles, Observation Promis29Physical, Observation Promis29Pain, Observation Promis29Fatigue, Observation Promis29Depression, Observation Promis29Anxiety)?>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzo_((CqlTupleMetadata, Observation Promis29Sleep, Observation Promis29SocialRoles, Observation Promis29Physical, Observation Promis29Pain, Observation Promis29Fatigue, Observation Promis29Depression, Observation Promis29Anxiety)? tuple_cbgpsarvwrsewlglehinjanim)
        {
            DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Sleep?.Effective;
            object mzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.toInterval(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlDate mzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.DateFrom(mzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29SocialRoles?.Effective;
            object nzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlDate nzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.DateFrom(nzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.SameAs(mzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, "day");
            DataType nzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29SocialRoles?.Value;
            object nzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Not((bool?)(nzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ is null));
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzzzzze_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            object nzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlDate nzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.DateFrom(nzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            DataType nzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Physical?.Effective;
            object nzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlDate nzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.DateFrom(nzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.SameAs(nzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, "day");
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            DataType nzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Physical?.Value;
            object nzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Not((bool?)(nzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ is null));
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            object ozzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlDate ozzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.DateFrom(ozzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzze_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Pain?.Effective;
            object ozzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.toInterval(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlDate ozzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.DateFrom(ozzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.SameAs(ozzzzzzzzzzzzzzzzzzzzzzzzzzzd_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzi_, "day");
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Pain?.Value;
            object ozzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Not((bool?)(ozzzzzzzzzzzzzzzzzzzzzzzzzzzm_ is null));
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzzzzzk_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            object ozzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlDate ozzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.DateFrom(ozzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            DataType ozzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Fatigue?.Effective;
            object ozzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.toInterval(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlDate ozzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.DateFrom(ozzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.SameAs(ozzzzzzzzzzzzzzzzzzzzzzzzzzzt_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzy_, "day");
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzzzzzo_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Fatigue?.Value;
            object pzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Not((bool?)(pzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ is null));
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzzzzzzza_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            object pzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.toInterval(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Start(pzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlDate pzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.DateFrom(pzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Depression?.Effective;
            object pzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.toInterval(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(pzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlDate pzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.DateFrom(pzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.SameAs(pzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, "day");
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzzzzzzze_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            DataType pzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Depression?.Value;
            object pzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Not((bool?)(pzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ is null));
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            object pzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.toInterval(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(pzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlDate pzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.DateFrom(pzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Anxiety?.Effective;
            object qzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(qzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlDate qzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.DateFrom(qzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.SameAs(pzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, qzzzzzzzzzzzzzzzzzzzzzzzzzzze_, "day");
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Anxiety?.Value;
            object qzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Not((bool?)(qzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ is null));
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Sleep?.Value;
            object qzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Not((bool?)(qzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ is null));
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

            return qzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<(CqlTupleMetadata, Observation Promis29Sleep, Observation Promis29SocialRoles, Observation Promis29Physical, Observation Promis29Pain, Observation Promis29Fatigue, Observation Promis29Depression, Observation Promis29Anxiety)?> mzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<(CqlTupleMetadata, Observation Promis29Sleep, Observation Promis29SocialRoles, Observation Promis29Physical, Observation Promis29Pain, Observation Promis29Fatigue, Observation Promis29Depression, Observation Promis29Anxiety)?>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        CqlDate mzzzzzzzzzzzzzzzzzzzzzzzzzzzq_((CqlTupleMetadata, Observation Promis29Sleep, Observation Promis29SocialRoles, Observation Promis29Physical, Observation Promis29Pain, Observation Promis29Fatigue, Observation Promis29Depression, Observation Promis29Anxiety)? tuple_cbgpsarvwrsewlglehinjanim)
        {
            DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Sleep?.Effective;
            object qzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(qzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlDate qzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.DateFrom(qzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

            return qzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<CqlDate> mzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Select<(CqlTupleMetadata, Observation Promis29Sleep, Observation Promis29SocialRoles, Observation Promis29Physical, Observation Promis29Pain, Observation Promis29Fatigue, Observation Promis29Depression, Observation Promis29Anxiety)?, CqlDate>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<CqlDate> mzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Distinct<CqlDate>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

        return mzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Encounter with Initial and Follow Up PROMIS29 Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_PROMIS29_Assessments(CqlContext context)
    {
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Qualifying_Encounters(context);
        IEnumerable<CqlDate> qzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Date_PROMIS29_Total_Assessment_Completed(context);
        IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> qzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS29Date, CqlDate FollowupPROMIS29Date)? qzzzzzzzzzzzzzzzzzzzzzzzzzzzy_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS29Date, CqlDate FollowupPROMIS29Date)? rzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = (CqlTupleMetadata_DSZKEYVbCINNIeAQiZdVaEJhG, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return rzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS29Date, CqlDate FollowupPROMIS29Date)?> qzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS29Date, CqlDate FollowupPROMIS29Date)?>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzza_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS29Date, CqlDate FollowupPROMIS29Date)? tuple_kmpntxjuhkpbcwgftqigieao)
        {
            Period rzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = tuple_kmpntxjuhkpbcwgftqigieao?.ValidEncounters?.Period;
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.toInterval(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ as object);
            CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.End(rzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Measurement_Period(context);
            CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.End(rzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlQuantity rzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Quantity(180m, "days");
            CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Subtract(rzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.SameOrBefore(rzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, "day");
            CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.ConvertDateToDateTime(tuple_kmpntxjuhkpbcwgftqigieao?.InitialPROMIS29Date);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.toInterval(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ as object);
            CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.End(rzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlQuantity rzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Quantity(14m, "days");
            CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Subtract(rzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ as object);
            CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.End(rzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Interval(rzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, szzzzzzzzzzzzzzzzzzzzzzzzzzza_, true, true);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.In<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, szzzzzzzzzzzzzzzzzzzzzzzzzzzb_, "day");
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, szzzzzzzzzzzzzzzzzzzzzzzzzzze_ as object);
            CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.End(szzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Not((bool?)(szzzzzzzzzzzzzzzzzzzzzzzzzzzg_ is null));
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzzzzzzzc_, szzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, szzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.ConvertDateToDateTime(tuple_kmpntxjuhkpbcwgftqigieao?.FollowupPROMIS29Date);
            CqlDate szzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.DateFrom(szzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlDate szzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.DateFrom(rzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlQuantity szzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Quantity(30m, "days");
            CqlDate szzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Add(szzzzzzzzzzzzzzzzzzzzzzzzzzzn_, szzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlDate szzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.DateFrom(rzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlDate szzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Add(szzzzzzzzzzzzzzzzzzzzzzzzzzzr_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDate> szzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Interval(szzzzzzzzzzzzzzzzzzzzzzzzzzzp_, szzzzzzzzzzzzzzzzzzzzzzzzzzzt_, true, true);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.In<CqlDate>(szzzzzzzzzzzzzzzzzzzzzzzzzzzl_, szzzzzzzzzzzzzzzzzzzzzzzzzzzu_, "day");
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzzzzzzzj_, szzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

            return szzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS29Date, CqlDate FollowupPROMIS29Date)?> rzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS29Date, CqlDate FollowupPROMIS29Date)?>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, rzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        Encounter rzzzzzzzzzzzzzzzzzzzzzzzzzzzc_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS29Date, CqlDate FollowupPROMIS29Date)? tuple_kmpntxjuhkpbcwgftqigieao) =>
            tuple_kmpntxjuhkpbcwgftqigieao?.ValidEncounters;
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Select<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS29Date, CqlDate FollowupPROMIS29Date)?, Encounter>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<Encounter> rzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Distinct<Encounter>(rzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Exists<Encounter>(rzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

        return rzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition(
        definitionName: "Date VR12 Oblique Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_VR12_Oblique_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode szzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.VR_12_Mental_component_summary__MCS__score___oblique_method_T_score(context);
        IEnumerable<CqlCode> szzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.ToList<CqlCode>(szzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<Observation> szzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, szzzzzzzzzzzzzzzzzzzzzzzzzzzy_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> tzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = Status_1_8_000.Instance.isAssessmentPerformed(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        CqlCode tzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.VR_12_Physical_component_summary__PCS__score___oblique_method_T_score(context);
        IEnumerable<CqlCode> tzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.ToList<CqlCode>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<Observation> tzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, tzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> tzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = Status_1_8_000.Instance.isAssessmentPerformed(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<ValueTuple<Observation, Observation>> tzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.CrossJoin<Observation, Observation>(tzzzzzzzzzzzzzzzzzzzzzzzzzzza_, tzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? tzzzzzzzzzzzzzzzzzzzzzzzzzzzg_(ValueTuple<Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? tzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = (CqlTupleMetadata_GAdRFKRaHUUGJcVHWQWRUjhRH, _valueTuple.Item1, _valueTuple.Item2);

            return tzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?> tzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Select<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzi_((CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? tuple_gadrfkrahuugjcvhwqwrujhrh)
        {
            DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Effective;
            object tzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.toInterval(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlDate tzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.DateFrom(tzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Effective;
            object tzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlDate tzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.DateFrom(tzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.SameAs(tzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, "day");
            DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Value;
            object uzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Not((bool?)(uzzzzzzzzzzzzzzzzzzzzzzzzzzza_ is null));
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            DataType uzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Value;
            object uzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Not((bool?)(uzzzzzzzzzzzzzzzzzzzzzzzzzzze_ is null));
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

            return uzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?> tzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        CqlDate tzzzzzzzzzzzzzzzzzzzzzzzzzzzk_((CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? tuple_gadrfkrahuugjcvhwqwrujhrh)
        {
            DataType uzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Effective;
            object uzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.toInterval(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Start(uzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlDate uzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.DateFrom(uzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

            return uzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<CqlDate> tzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Select<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?, CqlDate>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        IEnumerable<CqlDate> tzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Distinct<CqlDate>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

        return tzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Encounter with Initial and Follow Up VR12 Oblique Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_VR12_Oblique_Assessments(CqlContext context)
    {
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Qualifying_Encounters(context);
        IEnumerable<CqlDate> uzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Date_VR12_Oblique_Total_Assessment_Completed(context);
        IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> uzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12ObliqueDate, CqlDate FollowupVR12ObliqueDate)? uzzzzzzzzzzzzzzzzzzzzzzzzzzzq_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12ObliqueDate, CqlDate FollowupVR12ObliqueDate)? uzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = (CqlTupleMetadata_FQKGdEYLiDFGMNAUAMETIHUQT, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return uzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12ObliqueDate, CqlDate FollowupVR12ObliqueDate)?> uzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12ObliqueDate, CqlDate FollowupVR12ObliqueDate)?>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzs_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12ObliqueDate, CqlDate FollowupVR12ObliqueDate)? tuple_fppktdiagiekhptnsbacpswh)
        {
            Period uzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = tuple_fppktdiagiekhptnsbacpswh?.ValidEncounters?.Period;
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzza_ as object);
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.End(vzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Measurement_Period(context);
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.End(vzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlQuantity vzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Quantity(180m, "days");
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Subtract(vzzzzzzzzzzzzzzzzzzzzzzzzzzze_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.SameOrBefore(vzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, "day");
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.ConvertDateToDateTime(tuple_fppktdiagiekhptnsbacpswh?.InitialVR12ObliqueDate);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ as object);
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.End(vzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlQuantity vzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Quantity(14m, "days");
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Subtract(vzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ as object);
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.End(vzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Interval(vzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, true, true);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, "day");
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.toInterval(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ as object);
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.End(vzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Not((bool?)(vzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ is null));
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, wzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.ConvertDateToDateTime(tuple_fppktdiagiekhptnsbacpswh?.FollowupVR12ObliqueDate);
            CqlDate wzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.DateFrom(wzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlDate wzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.DateFrom(vzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlQuantity wzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Quantity(30m, "days");
            CqlDate wzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Add(wzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlDate wzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.DateFrom(vzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlDate wzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Add(wzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlInterval<CqlDate> wzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Interval(wzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, true, true);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.In<CqlDate>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, "day");
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(wzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

            return wzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12ObliqueDate, CqlDate FollowupVR12ObliqueDate)?> uzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12ObliqueDate, CqlDate FollowupVR12ObliqueDate)?>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        Encounter uzzzzzzzzzzzzzzzzzzzzzzzzzzzu_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12ObliqueDate, CqlDate FollowupVR12ObliqueDate)? tuple_fppktdiagiekhptnsbacpswh) =>
            tuple_fppktdiagiekhptnsbacpswh?.ValidEncounters;
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Select<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12ObliqueDate, CqlDate FollowupVR12ObliqueDate)?, Encounter>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Distinct<Encounter>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Exists<Encounter>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

        return uzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition(
        definitionName: "Date VR12 Orthogonal Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_VR12_Orthogonal_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode wzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.VR_12_Mental_component_summary__MCS__score___orthogonal_method_T_score(context);
        IEnumerable<CqlCode> wzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.ToList<CqlCode>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, wzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = Status_1_8_000.Instance.isAssessmentPerformed(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        CqlCode wzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.VR_12_Physical_component_summary__PCS__score___orthogonal_method_T_score(context);
        IEnumerable<CqlCode> wzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.ToList<CqlCode>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, wzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = Status_1_8_000.Instance.isAssessmentPerformed(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<ValueTuple<Observation, Observation>> wzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.CrossJoin<Observation, Observation>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? wzzzzzzzzzzzzzzzzzzzzzzzzzzzy_(ValueTuple<Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? xzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = (CqlTupleMetadata_GAdRFKRaHUUGJcVHWQWRUjhRH, _valueTuple.Item1, _valueTuple.Item2);

            return xzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?> wzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Select<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzza_((CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? tuple_gadrfkrahuugjcvhwqwrujhrh)
        {
            DataType xzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Effective;
            object xzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlDate xzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.DateFrom(xzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            DataType xzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Effective;
            object xzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlDate xzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.DateFrom(xzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.SameAs(xzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, "day");
            DataType xzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Value;
            object xzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Not((bool?)(xzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ is null));
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            DataType xzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Value;
            object xzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Not((bool?)(xzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ is null));
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

            return xzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?> xzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, xzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        CqlDate xzzzzzzzzzzzzzzzzzzzzzzzzzzzc_((CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? tuple_gadrfkrahuugjcvhwqwrujhrh)
        {
            DataType xzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Effective;
            object yzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlDate yzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.DateFrom(yzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

            return yzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<CqlDate> xzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Select<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?, CqlDate>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<CqlDate> xzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Distinct<CqlDate>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

        return xzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Encounter with Initial and Follow Up VR12 Orthogonal Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments(CqlContext context)
    {
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Qualifying_Encounters(context);
        IEnumerable<CqlDate> yzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Date_VR12_Orthogonal_Total_Assessment_Completed(context);
        IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> yzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(yzzzzzzzzzzzzzzzzzzzzzzzzzzze_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12OrthogonalDate, CqlDate FollowupVR12OrthogonalDate)? yzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12OrthogonalDate, CqlDate FollowupVR12OrthogonalDate)? yzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = (CqlTupleMetadata_HSSAQEFQAOXLjUcOKGgicELWB, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return yzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12OrthogonalDate, CqlDate FollowupVR12OrthogonalDate)?> yzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12OrthogonalDate, CqlDate FollowupVR12OrthogonalDate)?>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzk_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12OrthogonalDate, CqlDate FollowupVR12OrthogonalDate)? tuple_fansvmjaedmvsdoyrozxdlsai)
        {
            Period yzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = tuple_fansvmjaedmvsdoyrozxdlsai?.ValidEncounters?.Period;
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.toInterval(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ as object);
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.End(yzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Measurement_Period(context);
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.End(yzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlQuantity yzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Quantity(180m, "days");
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Subtract(yzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.SameOrBefore(yzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, "day");
            CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.ConvertDateToDateTime(tuple_fansvmjaedmvsdoyrozxdlsai?.InitialVR12OrthogonalDate);
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.toInterval(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ as object);
            CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.End(zzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlQuantity zzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Quantity(14m, "days");
            CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Subtract(zzzzzzzzzzzzzzzzzzzzzzzzzzzze_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.toInterval(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ as object);
            CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.End(zzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Interval(zzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, true, true);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.In<CqlDateTime>(zzzzzzzzzzzzzzzzzzzzzzzzzzzza_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, "day");
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, zzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ as object);
            CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.End(zzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Not((bool?)(zzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ is null));
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.ConvertDateToDateTime(tuple_fansvmjaedmvsdoyrozxdlsai?.FollowupVR12OrthogonalDate);
            CqlDate zzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.DateFrom(zzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlDate zzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.DateFrom(zzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlQuantity zzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Quantity(30m, "days");
            CqlDate zzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Add(zzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlDate azzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.DateFrom(zzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlDate azzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Add(azzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDate> azzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Interval(zzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, true, true);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.In<CqlDate>(zzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, azzzzzzzzzzzzzzzzzzzzzzzzzzzze_, "day");
            bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

            return azzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12OrthogonalDate, CqlDate FollowupVR12OrthogonalDate)?> yzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12OrthogonalDate, CqlDate FollowupVR12OrthogonalDate)?>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        Encounter yzzzzzzzzzzzzzzzzzzzzzzzzzzzm_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12OrthogonalDate, CqlDate FollowupVR12OrthogonalDate)? tuple_fansvmjaedmvsdoyrozxdlsai) =>
            tuple_fansvmjaedmvsdoyrozxdlsai?.ValidEncounters;
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Select<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12OrthogonalDate, CqlDate FollowupVR12OrthogonalDate)?, Encounter>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Distinct<Encounter>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Exists<Encounter>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

        return yzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition(
        definitionName: "Date VR36 Oblique Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_VR36_Oblique_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode azzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.VR_36_Mental_component_summary__MCS__score___oblique_method_T_score(context);
        IEnumerable<CqlCode> azzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.ToList<CqlCode>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, azzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = Status_1_8_000.Instance.isAssessmentPerformed(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        CqlCode azzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.VR_36_Physical_component_summary__PCS__score___oblique_method_T_score(context);
        IEnumerable<CqlCode> azzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.ToList<CqlCode>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, azzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = Status_1_8_000.Instance.isAssessmentPerformed(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<ValueTuple<Observation, Observation>> azzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.CrossJoin<Observation, Observation>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        (CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)? azzzzzzzzzzzzzzzzzzzzzzzzzzzzq_(ValueTuple<Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)? azzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = (CqlTupleMetadata_DUcFTCLcQEWDGGQdFCWTHFaUK, _valueTuple.Item1, _valueTuple.Item2);

            return azzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<(CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?> azzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Select<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzs_((CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)? tuple_ducftclcqewdggqdfcwthfauk)
        {
            DataType azzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36MentalAssessment?.Effective;
            object azzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, azzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlDate bzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.DateFrom(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36PhysicalAssessment?.Effective;
            object bzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlDate bzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.DateFrom(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.SameAs(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, "day");
            DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36MentalAssessment?.Value;
            object bzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Not((bool?)(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ is null));
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36PhysicalAssessment?.Value;
            object bzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Not((bool?)(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ is null));
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

            return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<(CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?> azzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<(CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        CqlDate azzzzzzzzzzzzzzzzzzzzzzzzzzzzu_((CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)? tuple_ducftclcqewdggqdfcwthfauk)
        {
            DataType bzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36MentalAssessment?.Effective;
            object bzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlDate bzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.DateFrom(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

            return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<CqlDate> azzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Select<(CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?, CqlDate>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        IEnumerable<CqlDate> azzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Distinct<CqlDate>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Encounter with Initial and Follow Up VR36 Oblique Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_VR36_Oblique_Assessments(CqlContext context)
    {
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Qualifying_Encounters(context);
        IEnumerable<CqlDate> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Date_VR36_Oblique_Total_Assessment_Completed(context);
        IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36ObliqueDate, CqlDate FollowupVR36ObliqueDate)? czzzzzzzzzzzzzzzzzzzzzzzzzzzza_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36ObliqueDate, CqlDate FollowupVR36ObliqueDate)? czzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = (CqlTupleMetadata_HQfcMfhQUSTNYMWSgJHiFeahQ, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return czzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36ObliqueDate, CqlDate FollowupVR36ObliqueDate)?> czzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36ObliqueDate, CqlDate FollowupVR36ObliqueDate)?>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, czzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzc_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36ObliqueDate, CqlDate FollowupVR36ObliqueDate)? tuple_elxicyhrdpyzpqyjphdifbiga)
        {
            Period czzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = tuple_elxicyhrdpyzpqyjphdifbiga?.ValidEncounters?.Period;
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ as object);
            CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.End(czzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Measurement_Period(context);
            CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.End(czzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlQuantity czzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Quantity(180m, "days");
            CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Subtract(czzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.SameOrBefore(czzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, "day");
            CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ConvertDateToDateTime(tuple_elxicyhrdpyzpqyjphdifbiga?.InitialVR36ObliqueDate);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ as object);
            CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.End(czzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlQuantity czzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Quantity(14m, "days");
            CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Subtract(czzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ as object);
            CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.End(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Interval(czzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, true, true);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.In<CqlDateTime>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, "day");
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.toInterval(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ as object);
            CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.End(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Not((bool?)(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ is null));
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.ConvertDateToDateTime(tuple_elxicyhrdpyzpqyjphdifbiga?.FollowupVR36ObliqueDate);
            CqlDate dzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.DateFrom(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlDate dzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.DateFrom(czzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlQuantity dzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Quantity(30m, "days");
            CqlDate dzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Add(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlDate dzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.DateFrom(czzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlDate dzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Add(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDate> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Interval(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, true, true);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.In<CqlDate>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, "day");
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

            return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36ObliqueDate, CqlDate FollowupVR36ObliqueDate)?> czzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36ObliqueDate, CqlDate FollowupVR36ObliqueDate)?>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        Encounter czzzzzzzzzzzzzzzzzzzzzzzzzzzze_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36ObliqueDate, CqlDate FollowupVR36ObliqueDate)? tuple_elxicyhrdpyzpqyjphdifbiga) =>
            tuple_elxicyhrdpyzpqyjphdifbiga?.ValidEncounters;
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Select<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36ObliqueDate, CqlDate FollowupVR36ObliqueDate)?, Encounter>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, czzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Distinct<Encounter>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Exists<Encounter>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

        return czzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition(
        definitionName: "Date VR36 Orthogonal Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_VR36_Orthogonal_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode dzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.VR_36_Mental_component_summary__MCS__score___orthogonal_method_T_score(context);
        IEnumerable<CqlCode> ezzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.ToList<CqlCode>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, ezzzzzzzzzzzzzzzzzzzzzzzzzzzza_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = Status_1_8_000.Instance.isAssessmentPerformed(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        CqlCode ezzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.VR_36_Physical_component_summary__PCS__score___orthogonal_method_T_score(context);
        IEnumerable<CqlCode> ezzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.ToList<CqlCode>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, ezzzzzzzzzzzzzzzzzzzzzzzzzzzze_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = Status_1_8_000.Instance.isAssessmentPerformed(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        IEnumerable<ValueTuple<Observation, Observation>> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.CrossJoin<Observation, Observation>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        (CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(ValueTuple<Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = (CqlTupleMetadata_DUcFTCLcQEWDGGQdFCWTHFaUK, _valueTuple.Item1, _valueTuple.Item2);

            return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<(CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzk_((CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)? tuple_ducftclcqewdggqdfcwthfauk)
        {
            DataType ezzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36MentalAssessment?.Effective;
            object ezzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.toInterval(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlDate ezzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.DateFrom(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            DataType ezzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36PhysicalAssessment?.Effective;
            object ezzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.toInterval(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlDate ezzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.DateFrom(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.SameAs(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, "day");
            DataType fzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36MentalAssessment?.Value;
            object fzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Not((bool?)(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ is null));
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            DataType fzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36PhysicalAssessment?.Value;
            object fzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Not((bool?)(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ is null));
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

            return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<(CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<(CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        CqlDate ezzzzzzzzzzzzzzzzzzzzzzzzzzzzm_((CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)? tuple_ducftclcqewdggqdfcwthfauk)
        {
            DataType fzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36MentalAssessment?.Effective;
            object fzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlDate fzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.DateFrom(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

            return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<CqlDate> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Select<(CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?, CqlDate>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        IEnumerable<CqlDate> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Distinct<CqlDate>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Encounter with Initial and Follow Up VR36 Orthogonal Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_VR36_Orthogonal_Assessments(CqlContext context)
    {
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Qualifying_Encounters(context);
        IEnumerable<CqlDate> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Date_VR36_Orthogonal_Total_Assessment_Completed(context);
        IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36OrthogonalDate, CqlDate FollowupVR36OrthogonalDate)? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36OrthogonalDate, CqlDate FollowupVR36OrthogonalDate)? gzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = (CqlTupleMetadata_BFZHWdOOROjSjFSECHcQiaZZZ, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return gzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36OrthogonalDate, CqlDate FollowupVR36OrthogonalDate)?> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36OrthogonalDate, CqlDate FollowupVR36OrthogonalDate)?>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36OrthogonalDate, CqlDate FollowupVR36OrthogonalDate)? tuple_fucqujadjizabihdffformht)
        {
            Period gzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = tuple_fucqujadjizabihdffformht?.ValidEncounters?.Period;
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ as object);
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.End(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Measurement_Period(context);
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.End(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlQuantity gzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Quantity(180m, "days");
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Subtract(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.SameOrBefore(gzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, "day");
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.ConvertDateToDateTime(tuple_fucqujadjizabihdffformht?.InitialVR36OrthogonalDate);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ as object);
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.End(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlQuantity gzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Quantity(14m, "days");
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Subtract(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ as object);
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.End(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Interval(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, true, true);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.In<CqlDateTime>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, "day");
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ as object);
            CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.End(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Not((bool?)(hzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ is null));
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.ConvertDateToDateTime(tuple_fucqujadjizabihdffformht?.FollowupVR36OrthogonalDate);
            CqlDate hzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.DateFrom(hzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlDate hzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.DateFrom(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlQuantity hzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Quantity(30m, "days");
            CqlDate hzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Add(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlDate hzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.DateFrom(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlDate hzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Add(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlInterval<CqlDate> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Interval(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, true, true);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.In<CqlDate>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, "day");
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

            return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36OrthogonalDate, CqlDate FollowupVR36OrthogonalDate)?> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36OrthogonalDate, CqlDate FollowupVR36OrthogonalDate)?>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        Encounter fzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36OrthogonalDate, CqlDate FollowupVR36OrthogonalDate)? tuple_fucqujadjizabihdffformht) =>
            tuple_fucqujadjizabihdffformht?.ValidEncounters;
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Select<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36OrthogonalDate, CqlDate FollowupVR36OrthogonalDate)?, Encounter>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Distinct<Encounter>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Exists<Encounter>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

        return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition(
        definitionName: "Date MLHFQ Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_MLHFQ_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode hzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Physical_score__MLHFQ_(context);
        IEnumerable<CqlCode> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ToList<CqlCode>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = Status_1_8_000.Instance.isAssessmentPerformed(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        CqlCode hzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Emotional_score__MLHFQ_(context);
        IEnumerable<CqlCode> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.ToList<CqlCode>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = Status_1_8_000.Instance.isAssessmentPerformed(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<ValueTuple<Observation, Observation>> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.CrossJoin<Observation, Observation>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        (CqlTupleMetadata, Observation MLHFQPhysical, Observation MLHFQEmotional)? izzzzzzzzzzzzzzzzzzzzzzzzzzzza_(ValueTuple<Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation MLHFQPhysical, Observation MLHFQEmotional)? izzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = (CqlTupleMetadata_EBLWeAeedHPAfOJXKPZJKSCUf, _valueTuple.Item1, _valueTuple.Item2);

            return izzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<(CqlTupleMetadata, Observation MLHFQPhysical, Observation MLHFQEmotional)?> izzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Select<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation MLHFQPhysical, Observation MLHFQEmotional)?>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, izzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzc_((CqlTupleMetadata, Observation MLHFQPhysical, Observation MLHFQEmotional)? tuple_fnofxckadaeusjerhbdqfoshe)
        {
            DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = tuple_fnofxckadaeusjerhbdqfoshe?.MLHFQPhysical?.Effective;
            object izzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.toInterval(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(izzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlDate izzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.DateFrom(izzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = tuple_fnofxckadaeusjerhbdqfoshe?.MLHFQEmotional?.Effective;
            object izzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(izzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlDate izzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.DateFrom(izzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.SameAs(izzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, "day");
            DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = tuple_fnofxckadaeusjerhbdqfoshe?.MLHFQPhysical?.Value;
            object izzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Not((bool?)(izzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ is null));
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = tuple_fnofxckadaeusjerhbdqfoshe?.MLHFQEmotional?.Value;
            object izzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Not((bool?)(izzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ is null));
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

            return jzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<(CqlTupleMetadata, Observation MLHFQPhysical, Observation MLHFQEmotional)?> izzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<(CqlTupleMetadata, Observation MLHFQPhysical, Observation MLHFQEmotional)?>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        CqlDate izzzzzzzzzzzzzzzzzzzzzzzzzzzze_((CqlTupleMetadata, Observation MLHFQPhysical, Observation MLHFQEmotional)? tuple_fnofxckadaeusjerhbdqfoshe)
        {
            DataType jzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = tuple_fnofxckadaeusjerhbdqfoshe?.MLHFQPhysical?.Effective;
            object jzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.toInterval(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Start(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlDate jzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.DateFrom(jzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

            return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<CqlDate> izzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Select<(CqlTupleMetadata, Observation MLHFQPhysical, Observation MLHFQEmotional)?, CqlDate>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, izzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        IEnumerable<CqlDate> izzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Distinct<CqlDate>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

        return izzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Encounter with Initial and Follow Up MLHFQ Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_MLHFQ_Assessments(CqlContext context)
    {
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Qualifying_Encounters(context);
        IEnumerable<CqlDate> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Date_MLHFQ_Total_Assessment_Completed(context);
        IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialMLHFQDate, CqlDate FollowupMLHFQDate)? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialMLHFQDate, CqlDate FollowupMLHFQDate)? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = (CqlTupleMetadata_CcaWSNDiVeaLebVKKWWWiBcEU, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialMLHFQDate, CqlDate FollowupMLHFQDate)?> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialMLHFQDate, CqlDate FollowupMLHFQDate)?>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialMLHFQDate, CqlDate FollowupMLHFQDate)? tuple_ncdawctnmbfmtibmihsfbaig)
        {
            Period jzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = tuple_ncdawctnmbfmtibmihsfbaig?.ValidEncounters?.Period;
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ as object);
            CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.End(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Measurement_Period(context);
            CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.End(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlQuantity jzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Quantity(180m, "days");
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Subtract(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.SameOrBefore(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, "day");
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.ConvertDateToDateTime(tuple_ncdawctnmbfmtibmihsfbaig?.InitialMLHFQDate);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ as object);
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.End(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlQuantity kzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Quantity(14m, "days");
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Subtract(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ as object);
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.End(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Interval(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, true, true);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.In<CqlDateTime>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, "day");
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ as object);
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.End(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Not((bool?)(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ is null));
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.ConvertDateToDateTime(tuple_ncdawctnmbfmtibmihsfbaig?.FollowupMLHFQDate);
            CqlDate kzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.DateFrom(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlDate kzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.DateFrom(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlQuantity lzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Quantity(30m, "days");
            CqlDate lzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Add(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlDate lzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.DateFrom(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlDate lzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Add(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDate> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Interval(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, true, true);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.In<CqlDate>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, "day");
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

            return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialMLHFQDate, CqlDate FollowupMLHFQDate)?> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialMLHFQDate, CqlDate FollowupMLHFQDate)?>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        Encounter jzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialMLHFQDate, CqlDate FollowupMLHFQDate)? tuple_ncdawctnmbfmtibmihsfbaig) =>
            tuple_ncdawctnmbfmtibmihsfbaig?.ValidEncounters;
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Select<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialMLHFQDate, CqlDate FollowupMLHFQDate)?, Encounter>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Distinct<Encounter>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Exists<Encounter>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

        return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition(
        definitionName: "Date KCCQ12 Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_KCCQ12_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode lzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Kansas_City_Cardiomyopathy_Questionnaire___12_item__KCCQ_12_(context);
        IEnumerable<CqlCode> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.ToList<CqlCode>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = Status_1_8_000.Instance.isAssessmentPerformed(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        CqlCode lzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Overall_summary_score__KCCQ_12_(context);
        IEnumerable<CqlCode> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.ToList<CqlCode>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = Status_1_8_000.Instance.isAssessmentPerformed(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<ValueTuple<Observation, Observation>> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.CrossJoin<Observation, Observation>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        (CqlTupleMetadata, Observation KCCQ12Item, Observation KCCQ12Summary)? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(ValueTuple<Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation KCCQ12Item, Observation KCCQ12Summary)? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = (CqlTupleMetadata_DFKXORghhYafccUSbQaMfNTDj, _valueTuple.Item1, _valueTuple.Item2);

            return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<(CqlTupleMetadata, Observation KCCQ12Item, Observation KCCQ12Summary)?> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Select<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation KCCQ12Item, Observation KCCQ12Summary)?>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_((CqlTupleMetadata, Observation KCCQ12Item, Observation KCCQ12Summary)? tuple_dfkxorghhyafccusbqamfntdj)
        {
            DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = tuple_dfkxorghhyafccusbqamfntdj?.KCCQ12Item?.Effective;
            object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlDate mzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.DateFrom(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = tuple_dfkxorghhyafccusbqamfntdj?.KCCQ12Summary?.Effective;
            object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.toInterval(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlDate mzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.DateFrom(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.SameAs(mzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, "day");
            DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = tuple_dfkxorghhyafccusbqamfntdj?.KCCQ12Item?.Value;
            object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Not((bool?)(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ is null));
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = tuple_dfkxorghhyafccusbqamfntdj?.KCCQ12Summary?.Value;
            object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Not((bool?)(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ is null));
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

            return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<(CqlTupleMetadata, Observation KCCQ12Item, Observation KCCQ12Summary)?> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<(CqlTupleMetadata, Observation KCCQ12Item, Observation KCCQ12Summary)?>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        CqlDate lzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_((CqlTupleMetadata, Observation KCCQ12Item, Observation KCCQ12Summary)? tuple_dfkxorghhyafccusbqamfntdj)
        {
            DataType mzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = tuple_dfkxorghhyafccusbqamfntdj?.KCCQ12Item?.Effective;
            object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlDate mzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.DateFrom(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

            return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<CqlDate> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Select<(CqlTupleMetadata, Observation KCCQ12Item, Observation KCCQ12Summary)?, CqlDate>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        IEnumerable<CqlDate> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Distinct<CqlDate>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);

        return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Encounter with Initial and Follow Up KCCQ12 Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_KCCQ12_Assessments(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Qualifying_Encounters(context);
        IEnumerable<CqlDate> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Date_KCCQ12_Total_Assessment_Completed(context);
        IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQ12Date, CqlDate FollowupKCCQ12Date)? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQ12Date, CqlDate FollowupKCCQ12Date)? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = (CqlTupleMetadata_EQQLFFBVIbLIQLiZDNfeYdMU, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQ12Date, CqlDate FollowupKCCQ12Date)?> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQ12Date, CqlDate FollowupKCCQ12Date)?>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzze_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQ12Date, CqlDate FollowupKCCQ12Date)? tuple_eoahgtwwdfqijhcjzqnvidvuo)
        {
            Period nzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = tuple_eoahgtwwdfqijhcjzqnvidvuo?.ValidEncounters?.Period;
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ as object);
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.End(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Measurement_Period(context);
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.End(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlQuantity nzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Quantity(180m, "days");
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Subtract(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.SameOrBefore(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, "day");
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.ConvertDateToDateTime(tuple_eoahgtwwdfqijhcjzqnvidvuo?.InitialKCCQ12Date);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ as object);
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.End(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlQuantity nzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Quantity(14m, "days");
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Subtract(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.toInterval(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ as object);
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.End(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Interval(ozzzzzzzzzzzzzzzzzzzzzzzzzzzza_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzze_, true, true);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.In<CqlDateTime>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, "day");
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.toInterval(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ as object);
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.End(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Not((bool?)(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ is null));
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.ConvertDateToDateTime(tuple_eoahgtwwdfqijhcjzqnvidvuo?.FollowupKCCQ12Date);
            CqlDate ozzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.DateFrom(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlDate ozzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.DateFrom(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlQuantity ozzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Quantity(30m, "days");
            CqlDate ozzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Add(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlDate ozzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.DateFrom(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlDate ozzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Add(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlInterval<CqlDate> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Interval(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, true, true);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<CqlDate>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, "day");
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

            return pzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQ12Date, CqlDate FollowupKCCQ12Date)?> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQ12Date, CqlDate FollowupKCCQ12Date)?>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        Encounter nzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQ12Date, CqlDate FollowupKCCQ12Date)? tuple_eoahgtwwdfqijhcjzqnvidvuo) =>
            tuple_eoahgtwwdfqijhcjzqnvidvuo?.ValidEncounters;
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Select<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQ12Date, CqlDate FollowupKCCQ12Date)?, Encounter>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<Encounter> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Distinct<Encounter>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Exists<Encounter>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

        return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition(
        definitionName: "Date KCCQ Domain Assessment Completed")]
    public IEnumerable<CqlDate> Date_KCCQ_Domain_Assessment_Completed(CqlContext context)
    {
        CqlCode pzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Quality_of_life_score__KCCQ_(context);
        IEnumerable<CqlCode> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.ToList<CqlCode>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = Status_1_8_000.Instance.isAssessmentPerformed(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        CqlCode pzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Symptom_stability_score__KCCQ_(context);
        IEnumerable<CqlCode> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.ToList<CqlCode>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = Status_1_8_000.Instance.isAssessmentPerformed(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        CqlCode pzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Self_efficacy_score__KCCQ_(context);
        IEnumerable<CqlCode> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.ToList<CqlCode>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = Status_1_8_000.Instance.isAssessmentPerformed(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        CqlCode pzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Total_symptom_score__KCCQ_(context);
        IEnumerable<CqlCode> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.ToList<CqlCode>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = Status_1_8_000.Instance.isAssessmentPerformed(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        CqlCode pzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Physical_limitation_score__KCCQ_(context);
        IEnumerable<CqlCode> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ToList<CqlCode>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = Status_1_8_000.Instance.isAssessmentPerformed(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        CqlCode pzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Social_limitation_score__KCCQ_(context);
        IEnumerable<CqlCode> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.ToList<CqlCode>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = Status_1_8_000.Instance.isAssessmentPerformed(context, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<ValueTuple<Observation, Observation, Observation, Observation, Observation, Observation>> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.CrossJoin<Observation, Observation, Observation, Observation, Observation, Observation>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        (CqlTupleMetadata, Observation KCCQLifeQuality, Observation KCCQSymptomStability, Observation KCCQSelfEfficacy, Observation KCCQSymptoms, Observation KCCQPhysicalLimits, Observation KCCQSocialLimits)? qzzzzzzzzzzzzzzzzzzzzzzzzzzzza_(ValueTuple<Observation, Observation, Observation, Observation, Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation KCCQLifeQuality, Observation KCCQSymptomStability, Observation KCCQSelfEfficacy, Observation KCCQSymptoms, Observation KCCQPhysicalLimits, Observation KCCQSocialLimits)? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = (CqlTupleMetadata_BbPMcXSJeOeGdRcaZWGYPhGBL, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3, _valueTuple.Item4, _valueTuple.Item5, _valueTuple.Item6);

            return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<(CqlTupleMetadata, Observation KCCQLifeQuality, Observation KCCQSymptomStability, Observation KCCQSelfEfficacy, Observation KCCQSymptoms, Observation KCCQPhysicalLimits, Observation KCCQSocialLimits)?> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Select<ValueTuple<Observation, Observation, Observation, Observation, Observation, Observation>, (CqlTupleMetadata, Observation KCCQLifeQuality, Observation KCCQSymptomStability, Observation KCCQSelfEfficacy, Observation KCCQSymptoms, Observation KCCQPhysicalLimits, Observation KCCQSocialLimits)?>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_((CqlTupleMetadata, Observation KCCQLifeQuality, Observation KCCQSymptomStability, Observation KCCQSelfEfficacy, Observation KCCQSymptoms, Observation KCCQPhysicalLimits, Observation KCCQSocialLimits)? tuple_etfcawdpmcqfbnayqdmdqqsdn)
        {
            DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQLifeQuality?.Effective;
            object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.toInterval(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlDate qzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.DateFrom(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQSymptomStability?.Effective;
            object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlDate qzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.DateFrom(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.SameAs(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, "day");
            DataType qzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQSymptomStability?.Value;
            object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Not((bool?)(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ is null));
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            object qzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Start(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlDate rzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.DateFrom(rzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQSelfEfficacy?.Effective;
            object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.toInterval(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(rzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlDate rzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.DateFrom(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.SameAs(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, "day");
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQSelfEfficacy?.Value;
            object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Not((bool?)(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ is null));
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlDate rzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.DateFrom(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQSymptoms?.Effective;
            object rzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Start(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlDate rzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.DateFrom(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.SameAs(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, "day");
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            DataType rzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQSymptoms?.Value;
            object szzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Not((bool?)(szzzzzzzzzzzzzzzzzzzzzzzzzzzza_ is null));
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            object szzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(szzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlDate szzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.DateFrom(szzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            DataType szzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQPhysicalLimits?.Effective;
            object szzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.toInterval(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(szzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlDate szzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.DateFrom(szzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.SameAs(szzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, "day");
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            DataType szzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQPhysicalLimits?.Value;
            object szzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Not((bool?)(szzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ is null));
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, szzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            object szzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(szzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlDate szzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.DateFrom(szzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            DataType szzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQSocialLimits?.Effective;
            object szzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, szzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlDate tzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.DateFrom(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.SameAs(szzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, "day");
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQSocialLimits?.Value;
            object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Not((bool?)(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ is null));
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQLifeQuality?.Value;
            object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Not((bool?)(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ is null));
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

            return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<(CqlTupleMetadata, Observation KCCQLifeQuality, Observation KCCQSymptomStability, Observation KCCQSelfEfficacy, Observation KCCQSymptoms, Observation KCCQPhysicalLimits, Observation KCCQSocialLimits)?> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<(CqlTupleMetadata, Observation KCCQLifeQuality, Observation KCCQSymptomStability, Observation KCCQSelfEfficacy, Observation KCCQSymptoms, Observation KCCQPhysicalLimits, Observation KCCQSocialLimits)?>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        CqlDate qzzzzzzzzzzzzzzzzzzzzzzzzzzzze_((CqlTupleMetadata, Observation KCCQLifeQuality, Observation KCCQSymptomStability, Observation KCCQSelfEfficacy, Observation KCCQSymptoms, Observation KCCQPhysicalLimits, Observation KCCQSocialLimits)? tuple_etfcawdpmcqfbnayqdmdqqsdn)
        {
            DataType tzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQLifeQuality?.Effective;
            object tzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlDate tzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.DateFrom(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

            return tzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<CqlDate> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Select<(CqlTupleMetadata, Observation KCCQLifeQuality, Observation KCCQSymptomStability, Observation KCCQSelfEfficacy, Observation KCCQSymptoms, Observation KCCQPhysicalLimits, Observation KCCQSocialLimits)?, CqlDate>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, qzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        IEnumerable<CqlDate> qzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Distinct<CqlDate>(qzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Encounter with Initial and Follow Up KCCQ Domain Score Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_KCCQ_Domain_Score_Assessments(CqlContext context)
    {
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Qualifying_Encounters(context);
        IEnumerable<CqlDate> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Date_KCCQ_Domain_Assessment_Completed(context);
        IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQAssessmentDate, CqlDate FollowupKCCQAssessmentDate)? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQAssessmentDate, CqlDate FollowupKCCQAssessmentDate)? uzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = (CqlTupleMetadata_HEFWLcHhCNCOQegEOfjWTXiGN, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return uzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQAssessmentDate, CqlDate FollowupKCCQAssessmentDate)?> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQAssessmentDate, CqlDate FollowupKCCQAssessmentDate)?>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        bool? tzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQAssessmentDate, CqlDate FollowupKCCQAssessmentDate)? tuple_hrluhbcfcsvnvrrnjajahdcea)
        {
            Period uzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = tuple_hrluhbcfcsvnvrrnjajahdcea?.ValidEncounters?.Period;
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.toInterval(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ as object);
            CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.End(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Measurement_Period(context);
            CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.End(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlQuantity uzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Quantity(180m, "days");
            CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Subtract(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.SameOrBefore(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, "day");
            CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.ConvertDateToDateTime(tuple_hrluhbcfcsvnvrrnjajahdcea?.InitialKCCQAssessmentDate);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ as object);
            CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.End(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlQuantity uzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Quantity(14m, "days");
            CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Subtract(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.toInterval(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ as object);
            CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.End(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Interval(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, true, true);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, "day");
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.toInterval(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ as object);
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.End(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Not((bool?)(vzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ is null));
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.ConvertDateToDateTime(tuple_hrluhbcfcsvnvrrnjajahdcea?.FollowupKCCQAssessmentDate);
            CqlDate vzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.DateFrom(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlDate vzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.DateFrom(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlQuantity vzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Quantity(30m, "days");
            CqlDate vzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Add(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlDate vzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.DateFrom(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlDate vzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Add(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDate> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Interval(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, true, true);
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.In<CqlDate>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, "day");
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

            return vzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQAssessmentDate, CqlDate FollowupKCCQAssessmentDate)?> tzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQAssessmentDate, CqlDate FollowupKCCQAssessmentDate)?>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, tzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        Encounter uzzzzzzzzzzzzzzzzzzzzzzzzzzzza_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQAssessmentDate, CqlDate FollowupKCCQAssessmentDate)? tuple_hrluhbcfcsvnvrrnjajahdcea) =>
            tuple_hrluhbcfcsvnvrrnjajahdcea?.ValidEncounters;
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Select<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQAssessmentDate, CqlDate FollowupKCCQAssessmentDate)?, Encounter>(tzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, uzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Distinct<Encounter>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Exists<Encounter>(uzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

        return uzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition(
        definitionName: "Date KCCQ Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_KCCQ_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode vzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Overall_summary_score__KCCQ_(context);
        IEnumerable<CqlCode> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.ToList<CqlCode>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> vzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = Status_1_8_000.Instance.isAssessmentPerformed(context, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_(Observation KCCQSummaryScore)
        {
            DataType wzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = KCCQSummaryScore?.Value;
            object wzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Not((bool?)(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ is null));

            return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Observation>(vzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, vzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        CqlDate wzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_(Observation KCCQSummaryScore)
        {
            DataType wzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = KCCQSummaryScore?.Effective;
            object wzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.toInterval(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Start(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlDate wzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.DateFrom(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

            return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<CqlDate> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Select<Observation, CqlDate>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<CqlDate> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Distinct<CqlDate>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

        return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Encounter with Initial and Follow Up KCCQ Total Score Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_KCCQ_Total_Score_Assessments(CqlContext context)
    {
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Qualifying_Encounters(context);
        IEnumerable<CqlDate> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Date_KCCQ_Total_Assessment_Completed(context);
        IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQTotalScore, CqlDate FollowupKCCQTotalScore)? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQTotalScore, CqlDate FollowupKCCQTotalScore)? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = (CqlTupleMetadata_DggZKjEbQUfLADMDMBeASLDR, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQTotalScore, CqlDate FollowupKCCQTotalScore)?> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQTotalScore, CqlDate FollowupKCCQTotalScore)?>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQTotalScore, CqlDate FollowupKCCQTotalScore)? tuple_dgrojeekdvizsvyisepdjhjgj)
        {
            Period wzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = tuple_dgrojeekdvizsvyisepdjhjgj?.ValidEncounters?.Period;
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ as object);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.End(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Measurement_Period(context);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.End(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlQuantity xzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Quantity(180m, "days");
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Subtract(xzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.SameOrBefore(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, "day");
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.ConvertDateToDateTime(tuple_dgrojeekdvizsvyisepdjhjgj?.InitialKCCQTotalScore);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ as object);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.End(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlQuantity xzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Quantity(14m, "days");
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Subtract(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ as object);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.End(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Interval(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, true, true);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, "day");
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ as object);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.End(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Not((bool?)(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ is null));
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.ConvertDateToDateTime(tuple_dgrojeekdvizsvyisepdjhjgj?.FollowupKCCQTotalScore);
            CqlDate yzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.DateFrom(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlDate yzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.DateFrom(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlQuantity yzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Quantity(30m, "days");
            CqlDate yzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Add(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlDate yzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.DateFrom(xzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlDate yzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Add(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, xzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlInterval<CqlDate> yzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Interval(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, true, true);
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.In<CqlDate>(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, "day");
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

            return yzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQTotalScore, CqlDate FollowupKCCQTotalScore)?> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQTotalScore, CqlDate FollowupKCCQTotalScore)?>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        Encounter wzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQTotalScore, CqlDate FollowupKCCQTotalScore)? tuple_dgrojeekdvizsvyisepdjhjgj) =>
            tuple_dgrojeekdvizsvyisepdjhjgj?.ValidEncounters;
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Select<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQTotalScore, CqlDate FollowupKCCQTotalScore)?, Encounter>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, wzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Distinct<Encounter>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        bool? wzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Exists<Encounter>(wzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

        return wzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Has_Encounter_with_Initial_and_Follow_Up_PROMIS10_Assessments(context);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Has_Encounter_with_Initial_and_Follow_Up_PROMIS29_Assessments(context);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Or(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Has_Encounter_with_Initial_and_Follow_Up_VR12_Oblique_Assessments(context);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Or(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Has_Encounter_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments(context);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Or(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Has_Encounter_with_Initial_and_Follow_Up_VR36_Oblique_Assessments(context);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Or(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Has_Encounter_with_Initial_and_Follow_Up_VR36_Orthogonal_Assessments(context);
        bool? yzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Or(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, yzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Has_Encounter_with_Initial_and_Follow_Up_MLHFQ_Assessments(context);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Or(yzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Has_Encounter_with_Initial_and_Follow_Up_KCCQ12_Assessments(context);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Or(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Has_Encounter_with_Initial_and_Follow_Up_KCCQ_Domain_Score_Assessments(context);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Or(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Has_Encounter_with_Initial_and_Follow_Up_KCCQ_Total_Score_Assessments(context);
        bool? zzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Or(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

        return zzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_BbPMcXSJeOeGdRcaZWGYPhGBL = new(
        [typeof(Observation), typeof(Observation), typeof(Observation), typeof(Observation), typeof(Observation), typeof(Observation)],
        ["KCCQLifeQuality", "KCCQSymptomStability", "KCCQSelfEfficacy", "KCCQSymptoms", "KCCQPhysicalLimits", "KCCQSocialLimits"]);

    private static CqlTupleMetadata CqlTupleMetadata_BFZHWdOOROjSjFSECHcQiaZZZ = new(
        [typeof(Encounter), typeof(CqlDate), typeof(CqlDate)],
        ["ValidEncounters", "InitialVR36OrthogonalDate", "FollowupVR36OrthogonalDate"]);

    private static CqlTupleMetadata CqlTupleMetadata_BGYjYGLNPKWAZTBCVAdLDDTMj = new(
        [typeof(Encounter), typeof(CqlDate), typeof(CqlDate)],
        ["ValidEncounters", "InitialPROMIS10Date", "FollowupPROMIS10Date"]);

    private static CqlTupleMetadata CqlTupleMetadata_CcaWSNDiVeaLebVKKWWWiBcEU = new(
        [typeof(Encounter), typeof(CqlDate), typeof(CqlDate)],
        ["ValidEncounters", "InitialMLHFQDate", "FollowupMLHFQDate"]);

    private static CqlTupleMetadata CqlTupleMetadata_DbNMMZBTISSRTNdiShceSFVih = new(
        [typeof(Encounter), typeof(Encounter)],
        ["OfficeVisit1", "OfficeVisit2"]);

    private static CqlTupleMetadata CqlTupleMetadata_DBUJFOVGBcbhIQPWARNQHKUaX = new(
        [typeof(Observation), typeof(Observation), typeof(Observation), typeof(Observation), typeof(Observation), typeof(Observation), typeof(Observation)],
        ["Promis29Sleep", "Promis29SocialRoles", "Promis29Physical", "Promis29Pain", "Promis29Fatigue", "Promis29Depression", "Promis29Anxiety"]);

    private static CqlTupleMetadata CqlTupleMetadata_DDTAOdcFieSJbGgRLLZPYbGQb = new(
        [typeof(Observation), typeof(Observation)],
        ["PROMIS10MentalScore", "PROMIS10PhysicalScore"]);

    private static CqlTupleMetadata CqlTupleMetadata_DFKXORghhYafccUSbQaMfNTDj = new(
        [typeof(Observation), typeof(Observation)],
        ["KCCQ12Item", "KCCQ12Summary"]);

    private static CqlTupleMetadata CqlTupleMetadata_DggZKjEbQUfLADMDMBeASLDR = new(
        [typeof(Encounter), typeof(CqlDate), typeof(CqlDate)],
        ["ValidEncounters", "InitialKCCQTotalScore", "FollowupKCCQTotalScore"]);

    private static CqlTupleMetadata CqlTupleMetadata_DSZKEYVbCINNIeAQiZdVaEJhG = new(
        [typeof(Encounter), typeof(CqlDate), typeof(CqlDate)],
        ["ValidEncounters", "InitialPROMIS29Date", "FollowupPROMIS29Date"]);

    private static CqlTupleMetadata CqlTupleMetadata_DUcFTCLcQEWDGGQdFCWTHFaUK = new(
        [typeof(Observation), typeof(Observation)],
        ["VR36MentalAssessment", "VR36PhysicalAssessment"]);

    private static CqlTupleMetadata CqlTupleMetadata_EBLWeAeedHPAfOJXKPZJKSCUf = new(
        [typeof(Observation), typeof(Observation)],
        ["MLHFQPhysical", "MLHFQEmotional"]);

    private static CqlTupleMetadata CqlTupleMetadata_EQQLFFBVIbLIQLiZDNfeYdMU = new(
        [typeof(Encounter), typeof(CqlDate), typeof(CqlDate)],
        ["ValidEncounters", "InitialKCCQ12Date", "FollowupKCCQ12Date"]);

    private static CqlTupleMetadata CqlTupleMetadata_FQKGdEYLiDFGMNAUAMETIHUQT = new(
        [typeof(Encounter), typeof(CqlDate), typeof(CqlDate)],
        ["ValidEncounters", "InitialVR12ObliqueDate", "FollowupVR12ObliqueDate"]);

    private static CqlTupleMetadata CqlTupleMetadata_GAdRFKRaHUUGJcVHWQWRUjhRH = new(
        [typeof(Observation), typeof(Observation)],
        ["VR12MentalAssessment", "VR12PhysicalAssessment"]);

    private static CqlTupleMetadata CqlTupleMetadata_HEFWLcHhCNCOQegEOfjWTXiGN = new(
        [typeof(Encounter), typeof(CqlDate), typeof(CqlDate)],
        ["ValidEncounters", "InitialKCCQAssessmentDate", "FollowupKCCQAssessmentDate"]);

    private static CqlTupleMetadata CqlTupleMetadata_HQfcMfhQUSTNYMWSgJHiFeahQ = new(
        [typeof(Encounter), typeof(CqlDate), typeof(CqlDate)],
        ["ValidEncounters", "InitialVR36ObliqueDate", "FollowupVR36ObliqueDate"]);

    private static CqlTupleMetadata CqlTupleMetadata_HSSAQEFQAOXLjUcOKGgicELWB = new(
        [typeof(Encounter), typeof(CqlDate), typeof(CqlDate)],
        ["ValidEncounters", "InitialVR12OrthogonalDate", "FollowupVR12OrthogonalDate"]);

    #endregion CqlTupleMetadata Properties

}
