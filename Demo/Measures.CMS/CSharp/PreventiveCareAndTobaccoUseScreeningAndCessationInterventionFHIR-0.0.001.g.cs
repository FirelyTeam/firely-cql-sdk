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
[CqlLibrary("PreventiveCareAndTobaccoUseScreeningAndCessationInterventionFHIR", "0.0.001")]
public partial class PreventiveCareAndTobaccoUseScreeningAndCessationInterventionFHIR_0_0_001 : ILibrary, ISingleton<PreventiveCareAndTobaccoUseScreeningAndCessationInterventionFHIR_0_0_001>
{
    private PreventiveCareAndTobaccoUseScreeningAndCessationInterventionFHIR_0_0_001() {}

    public static PreventiveCareAndTobaccoUseScreeningAndCessationInterventionFHIR_0_0_001 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "PreventiveCareAndTobaccoUseScreeningAndCessationInterventionFHIR";
    public string Version => "0.0.001";
    public ILibrary[] Dependencies => [Status_1_8_000.Instance, FHIRHelpers_4_4_000.Instance, SupplementalDataElements_3_5_000.Instance, QICoreCommon_2_1_000.Instance, Hospice_6_12_000.Instance, CumulativeMedicationDuration_4_1_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    #region ValueSet: Annual Wellness Visit
    [CqlValueSetDefinition(
        definitionName: "Annual Wellness Visit",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240",
        valueSetVersion: null)]
    public CqlValueSet Annual_Wellness_Visit(CqlContext context) => _Annual_Wellness_Visit;

    private static readonly CqlValueSet _Annual_Wellness_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", null);
    #endregion

    #region ValueSet: Home Healthcare Services
    [CqlValueSetDefinition(
        definitionName: "Home Healthcare Services",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016",
        valueSetVersion: null)]
    public CqlValueSet Home_Healthcare_Services(CqlContext context) => _Home_Healthcare_Services;

    private static readonly CqlValueSet _Home_Healthcare_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);
    #endregion

    #region ValueSet: Limited Life Expectancy
    [CqlValueSetDefinition(
        definitionName: "Limited Life Expectancy",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1259",
        valueSetVersion: null)]
    public CqlValueSet Limited_Life_Expectancy(CqlContext context) => _Limited_Life_Expectancy;

    private static readonly CqlValueSet _Limited_Life_Expectancy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1259", null);
    #endregion

    #region ValueSet: Medical Reason
    [CqlValueSetDefinition(
        definitionName: "Medical Reason",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007",
        valueSetVersion: null)]
    public CqlValueSet Medical_Reason(CqlContext context) => _Medical_Reason;

    private static readonly CqlValueSet _Medical_Reason = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007", null);
    #endregion

    #region ValueSet: Nutrition Services
    [CqlValueSetDefinition(
        definitionName: "Nutrition Services",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1006",
        valueSetVersion: null)]
    public CqlValueSet Nutrition_Services(CqlContext context) => _Nutrition_Services;

    private static readonly CqlValueSet _Nutrition_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1006", null);
    #endregion

    #region ValueSet: Occupational Therapy Evaluation
    [CqlValueSetDefinition(
        definitionName: "Occupational Therapy Evaluation",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1011",
        valueSetVersion: null)]
    public CqlValueSet Occupational_Therapy_Evaluation(CqlContext context) => _Occupational_Therapy_Evaluation;

    private static readonly CqlValueSet _Occupational_Therapy_Evaluation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1011", null);
    #endregion

    #region ValueSet: Office Visit
    [CqlValueSetDefinition(
        definitionName: "Office Visit",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001",
        valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext context) => _Office_Visit;

    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);
    #endregion

    #region ValueSet: Ophthalmological Services
    [CqlValueSetDefinition(
        definitionName: "Ophthalmological Services",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285",
        valueSetVersion: null)]
    public CqlValueSet Ophthalmological_Services(CqlContext context) => _Ophthalmological_Services;

    private static readonly CqlValueSet _Ophthalmological_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285", null);
    #endregion

    #region ValueSet: Physical Therapy Evaluation
    [CqlValueSetDefinition(
        definitionName: "Physical Therapy Evaluation",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1022",
        valueSetVersion: null)]
    public CqlValueSet Physical_Therapy_Evaluation(CqlContext context) => _Physical_Therapy_Evaluation;

    private static readonly CqlValueSet _Physical_Therapy_Evaluation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1022", null);
    #endregion

    #region ValueSet: Preventive Care Services Established Office Visit, 18 and Up
    [CqlValueSetDefinition(
        definitionName: "Preventive Care Services Established Office Visit, 18 and Up",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025",
        valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up(CqlContext context) => _Preventive_Care_Services_Established_Office_Visit__18_and_Up;

    private static readonly CqlValueSet _Preventive_Care_Services_Established_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);
    #endregion

    #region ValueSet: Preventive Care Services Group Counseling
    [CqlValueSetDefinition(
        definitionName: "Preventive Care Services Group Counseling",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1027",
        valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Group_Counseling(CqlContext context) => _Preventive_Care_Services_Group_Counseling;

    private static readonly CqlValueSet _Preventive_Care_Services_Group_Counseling = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1027", null);
    #endregion

    #region ValueSet: Preventive Care Services Individual Counseling
    [CqlValueSetDefinition(
        definitionName: "Preventive Care Services Individual Counseling",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026",
        valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Individual_Counseling(CqlContext context) => _Preventive_Care_Services_Individual_Counseling;

    private static readonly CqlValueSet _Preventive_Care_Services_Individual_Counseling = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026", null);
    #endregion

    #region ValueSet: Preventive Care Services Initial Office Visit, 18 and Up
    [CqlValueSetDefinition(
        definitionName: "Preventive Care Services Initial Office Visit, 18 and Up",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023",
        valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext context) => _Preventive_Care_Services_Initial_Office_Visit__18_and_Up;

    private static readonly CqlValueSet _Preventive_Care_Services_Initial_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);
    #endregion

    #region ValueSet: Preventive Care Services, Initial Office Visit, 0 to 17
    [CqlValueSetDefinition(
        definitionName: "Preventive Care Services, Initial Office Visit, 0 to 17",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022",
        valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services__Initial_Office_Visit__0_to_17(CqlContext context) => _Preventive_Care_Services__Initial_Office_Visit__0_to_17;

    private static readonly CqlValueSet _Preventive_Care_Services__Initial_Office_Visit__0_to_17 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", null);
    #endregion

    #region ValueSet: Preventive Care, Established Office Visit, 0 to 17
    [CqlValueSetDefinition(
        definitionName: "Preventive Care, Established Office Visit, 0 to 17",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024",
        valueSetVersion: null)]
    public CqlValueSet Preventive_Care__Established_Office_Visit__0_to_17(CqlContext context) => _Preventive_Care__Established_Office_Visit__0_to_17;

    private static readonly CqlValueSet _Preventive_Care__Established_Office_Visit__0_to_17 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", null);
    #endregion

    #region ValueSet: Psych Visit Diagnostic Evaluation
    [CqlValueSetDefinition(
        definitionName: "Psych Visit Diagnostic Evaluation",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1492",
        valueSetVersion: null)]
    public CqlValueSet Psych_Visit_Diagnostic_Evaluation(CqlContext context) => _Psych_Visit_Diagnostic_Evaluation;

    private static readonly CqlValueSet _Psych_Visit_Diagnostic_Evaluation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1492", null);
    #endregion

    #region ValueSet: Psych Visit Psychotherapy
    [CqlValueSetDefinition(
        definitionName: "Psych Visit Psychotherapy",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1496",
        valueSetVersion: null)]
    public CqlValueSet Psych_Visit_Psychotherapy(CqlContext context) => _Psych_Visit_Psychotherapy;

    private static readonly CqlValueSet _Psych_Visit_Psychotherapy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1496", null);
    #endregion

    #region ValueSet: Psychoanalysis
    [CqlValueSetDefinition(
        definitionName: "Psychoanalysis",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1141",
        valueSetVersion: null)]
    public CqlValueSet Psychoanalysis(CqlContext context) => _Psychoanalysis;

    private static readonly CqlValueSet _Psychoanalysis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1141", null);
    #endregion

    #region ValueSet: Speech and Hearing Evaluation
    [CqlValueSetDefinition(
        definitionName: "Speech and Hearing Evaluation",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1530",
        valueSetVersion: null)]
    public CqlValueSet Speech_and_Hearing_Evaluation(CqlContext context) => _Speech_and_Hearing_Evaluation;

    private static readonly CqlValueSet _Speech_and_Hearing_Evaluation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1530", null);
    #endregion

    #region ValueSet: Telephone Visits
    [CqlValueSetDefinition(
        definitionName: "Telephone Visits",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080",
        valueSetVersion: null)]
    public CqlValueSet Telephone_Visits(CqlContext context) => _Telephone_Visits;

    private static readonly CqlValueSet _Telephone_Visits = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);
    #endregion

    #region ValueSet: Tobacco Non User
    [CqlValueSetDefinition(
        definitionName: "Tobacco Non User",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1189",
        valueSetVersion: null)]
    public CqlValueSet Tobacco_Non_User(CqlContext context) => _Tobacco_Non_User;

    private static readonly CqlValueSet _Tobacco_Non_User = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1189", null);
    #endregion

    #region ValueSet: Tobacco Use Cessation Counseling
    [CqlValueSetDefinition(
        definitionName: "Tobacco Use Cessation Counseling",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.509",
        valueSetVersion: null)]
    public CqlValueSet Tobacco_Use_Cessation_Counseling(CqlContext context) => _Tobacco_Use_Cessation_Counseling;

    private static readonly CqlValueSet _Tobacco_Use_Cessation_Counseling = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.509", null);
    #endregion

    #region ValueSet: Tobacco Use Cessation Pharmacotherapy
    [CqlValueSetDefinition(
        definitionName: "Tobacco Use Cessation Pharmacotherapy",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1190",
        valueSetVersion: null)]
    public CqlValueSet Tobacco_Use_Cessation_Pharmacotherapy(CqlContext context) => _Tobacco_Use_Cessation_Pharmacotherapy;

    private static readonly CqlValueSet _Tobacco_Use_Cessation_Pharmacotherapy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1190", null);
    #endregion

    #region ValueSet: Tobacco Use Screening
    [CqlValueSetDefinition(
        definitionName: "Tobacco Use Screening",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1278",
        valueSetVersion: null)]
    public CqlValueSet Tobacco_Use_Screening(CqlContext context) => _Tobacco_Use_Screening;

    private static readonly CqlValueSet _Tobacco_Use_Screening = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1278", null);
    #endregion

    #region ValueSet: Tobacco User
    [CqlValueSetDefinition(
        definitionName: "Tobacco User",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1170",
        valueSetVersion: null)]
    public CqlValueSet Tobacco_User(CqlContext context) => _Tobacco_User;

    private static readonly CqlValueSet _Tobacco_User = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1170", null);
    #endregion

    #region ValueSet: Virtual Encounter
    [CqlValueSetDefinition(
        definitionName: "Virtual Encounter",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089",
        valueSetVersion: null)]
    public CqlValueSet Virtual_Encounter(CqlContext context) => _Virtual_Encounter;

    private static readonly CqlValueSet _Virtual_Encounter = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", null);
    #endregion

    #endregion ValueSets

    #region Codes

    #region Code: Health behavior assessment, or re-assessment (ie, health-focused clinical interview, behavioral observations, clinical decision making)
    [CqlCodeDefinition(
        definitionName: "Health behavior assessment, or re-assessment (ie, health-focused clinical interview, behavioral observations, clinical decision making)",
        codeId: "96156",
        codeSystem: "http://www.ama-assn.org/go/cpt")]
    public CqlCode Health_behavior_assessment__or_re_assessment__ie__health_focused_clinical_interview__behavioral_observations__clinical_decision_making_(CqlContext context) => _Health_behavior_assessment__or_re_assessment__ie__health_focused_clinical_interview__behavioral_observations__clinical_decision_making_;

    private static readonly CqlCode _Health_behavior_assessment__or_re_assessment__ie__health_focused_clinical_interview__behavioral_observations__clinical_decision_making_ = new CqlCode("96156", "http://www.ama-assn.org/go/cpt", default, default);
    #endregion

    #region Code: Health behavior intervention, individual, face-to-face; initial 30 minutes
    [CqlCodeDefinition(
        definitionName: "Health behavior intervention, individual, face-to-face; initial 30 minutes",
        codeId: "96158",
        codeSystem: "http://www.ama-assn.org/go/cpt")]
    public CqlCode Health_behavior_intervention__individual__face_to_face__initial_30_minutes(CqlContext context) => _Health_behavior_intervention__individual__face_to_face__initial_30_minutes;

    private static readonly CqlCode _Health_behavior_intervention__individual__face_to_face__initial_30_minutes = new CqlCode("96158", "http://www.ama-assn.org/go/cpt", default, default);
    #endregion

    #region Code: Postoperative follow-up visit, normally included in the surgical package, to indicate that an evaluation and management service was performed during a postoperative period for a reason(s) related to the original procedure
    [CqlCodeDefinition(
        definitionName: "Postoperative follow-up visit, normally included in the surgical package, to indicate that an evaluation and management service was performed during a postoperative period for a reason(s) related to the original procedure",
        codeId: "99024",
        codeSystem: "http://www.ama-assn.org/go/cpt")]
    public CqlCode Postoperative_follow_up_visit__normally_included_in_the_surgical_package__to_indicate_that_an_evaluation_and_management_service_was_performed_during_a_postoperative_period_for_a_reason_s__related_to_the_original_procedure(CqlContext context) => _Postoperative_follow_up_visit__normally_included_in_the_surgical_package__to_indicate_that_an_evaluation_and_management_service_was_performed_during_a_postoperative_period_for_a_reason_s__related_to_the_original_procedure;

    private static readonly CqlCode _Postoperative_follow_up_visit__normally_included_in_the_surgical_package__to_indicate_that_an_evaluation_and_management_service_was_performed_during_a_postoperative_period_for_a_reason_s__related_to_the_original_procedure = new CqlCode("99024", "http://www.ama-assn.org/go/cpt", default, default);
    #endregion

    #region Code: Tobacco abuse counseling
    [CqlCodeDefinition(
        definitionName: "Tobacco abuse counseling",
        codeId: "Z71.6",
        codeSystem: "http://hl7.org/fhir/sid/icd-10-cm")]
    public CqlCode Tobacco_abuse_counseling(CqlContext context) => _Tobacco_abuse_counseling;

    private static readonly CqlCode _Tobacco_abuse_counseling = new CqlCode("Z71.6", "http://hl7.org/fhir/sid/icd-10-cm", default, default);
    #endregion

    #region Code: Unlisted preventive medicine service
    [CqlCodeDefinition(
        definitionName: "Unlisted preventive medicine service",
        codeId: "99429",
        codeSystem: "http://www.ama-assn.org/go/cpt")]
    public CqlCode Unlisted_preventive_medicine_service(CqlContext context) => _Unlisted_preventive_medicine_service;

    private static readonly CqlCode _Unlisted_preventive_medicine_service = new CqlCode("99429", "http://www.ama-assn.org/go/cpt", default, default);
    #endregion

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition(
        definitionName: "CPT")]
    public CqlCode[] CPT(CqlContext context)
    {
        CqlCode[] wzzzzzzzzzzzzs_ = [
            new CqlCode("96156", "http://www.ama-assn.org/go/cpt", default, default),
            new CqlCode("96158", "http://www.ama-assn.org/go/cpt", default, default),
            new CqlCode("99024", "http://www.ama-assn.org/go/cpt", default, default),
            new CqlCode("99429", "http://www.ama-assn.org/go/cpt", default, default),
        ];

        return wzzzzzzzzzzzzs_;
    }


    [CqlCodeSystemDefinition(
        definitionName: "ICD10CM")]
    public CqlCode[] ICD10CM(CqlContext context)
    {
        CqlCode[] wzzzzzzzzzzzzt_ = [
            new CqlCode("Z71.6", "http://hl7.org/fhir/sid/icd-10-cm", default, default),
        ];

        return wzzzzzzzzzzzzt_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime wzzzzzzzzzzzzu_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime wzzzzzzzzzzzzv_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> wzzzzzzzzzzzzw_ = context.Operators.Interval(wzzzzzzzzzzzzu_, wzzzzzzzzzzzzv_, true, true);
        object wzzzzzzzzzzzzx_ = context.ResolveParameter("PreventiveCareAndTobaccoUseScreeningAndCessationInterventionFHIR-0.0.001", "Measurement Period", wzzzzzzzzzzzzw_);

        return (CqlInterval<CqlDateTime>)wzzzzzzzzzzzzx_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> wzzzzzzzzzzzzy_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient wzzzzzzzzzzzzz_ = context.Operators.SingletonFrom<Patient>(wzzzzzzzzzzzzy_);

        return wzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition(
        definitionName: "Qualifying Visit During Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Visit_During_Measurement_Period(CqlContext context)
    {
        IEnumerable<Encounter> xzzzzzzzzzzzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? xzzzzzzzzzzzzb_(Encounter E)
        {
            List<CodeableConcept> yzzzzzzzzzzzzr_ = E?.Type;
            CqlConcept yzzzzzzzzzzzzs_(CodeableConcept @this)
            {
                CqlConcept yzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return yzzzzzzzzzzzzx_;
            };
            IEnumerable<CqlConcept> yzzzzzzzzzzzzt_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)yzzzzzzzzzzzzr_, yzzzzzzzzzzzzs_);
            bool? yzzzzzzzzzzzzu_(CqlConcept T)
            {
                CqlCode yzzzzzzzzzzzzy_ = this.Health_behavior_intervention__individual__face_to_face__initial_30_minutes(context);
                CqlConcept yzzzzzzzzzzzzz_ = context.Operators.ConvertCodeToConcept(yzzzzzzzzzzzzy_);
                bool? zzzzzzzzzzzzza_ = context.Operators.Equivalent(T, yzzzzzzzzzzzzz_);

                return zzzzzzzzzzzzza_;
            };
            IEnumerable<CqlConcept> yzzzzzzzzzzzzv_ = context.Operators.Where<CqlConcept>(yzzzzzzzzzzzzt_, yzzzzzzzzzzzzu_);
            bool? yzzzzzzzzzzzzw_ = context.Operators.Exists<CqlConcept>(yzzzzzzzzzzzzv_);

            return yzzzzzzzzzzzzw_;
        };
        IEnumerable<Encounter> xzzzzzzzzzzzzc_ = context.Operators.Where<Encounter>(xzzzzzzzzzzzza_, xzzzzzzzzzzzzb_);
        bool? xzzzzzzzzzzzze_(Encounter E)
        {
            List<CodeableConcept> zzzzzzzzzzzzzb_ = E?.Type;
            CqlConcept zzzzzzzzzzzzzc_(CodeableConcept @this)
            {
                CqlConcept zzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return zzzzzzzzzzzzzh_;
            };
            IEnumerable<CqlConcept> zzzzzzzzzzzzzd_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)zzzzzzzzzzzzzb_, zzzzzzzzzzzzzc_);
            bool? zzzzzzzzzzzzze_(CqlConcept T)
            {
                CqlCode zzzzzzzzzzzzzi_ = this.Health_behavior_assessment__or_re_assessment__ie__health_focused_clinical_interview__behavioral_observations__clinical_decision_making_(context);
                CqlConcept zzzzzzzzzzzzzj_ = context.Operators.ConvertCodeToConcept(zzzzzzzzzzzzzi_);
                bool? zzzzzzzzzzzzzk_ = context.Operators.Equivalent(T, zzzzzzzzzzzzzj_);

                return zzzzzzzzzzzzzk_;
            };
            IEnumerable<CqlConcept> zzzzzzzzzzzzzf_ = context.Operators.Where<CqlConcept>(zzzzzzzzzzzzzd_, zzzzzzzzzzzzze_);
            bool? zzzzzzzzzzzzzg_ = context.Operators.Exists<CqlConcept>(zzzzzzzzzzzzzf_);

            return zzzzzzzzzzzzzg_;
        };
        IEnumerable<Encounter> xzzzzzzzzzzzzf_ = context.Operators.Where<Encounter>(xzzzzzzzzzzzza_, xzzzzzzzzzzzze_);
        IEnumerable<Encounter> xzzzzzzzzzzzzg_ = context.Operators.Union<Encounter>(xzzzzzzzzzzzzc_, xzzzzzzzzzzzzf_);
        CqlValueSet xzzzzzzzzzzzzh_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> xzzzzzzzzzzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet xzzzzzzzzzzzzj_ = this.Occupational_Therapy_Evaluation(context);
        IEnumerable<Encounter> xzzzzzzzzzzzzk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> xzzzzzzzzzzzzl_ = context.Operators.Union<Encounter>(xzzzzzzzzzzzzi_, xzzzzzzzzzzzzk_);
        IEnumerable<Encounter> xzzzzzzzzzzzzm_ = context.Operators.Union<Encounter>(xzzzzzzzzzzzzg_, xzzzzzzzzzzzzl_);
        CqlValueSet xzzzzzzzzzzzzn_ = this.Office_Visit(context);
        IEnumerable<Encounter> xzzzzzzzzzzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet xzzzzzzzzzzzzp_ = this.Ophthalmological_Services(context);
        IEnumerable<Encounter> xzzzzzzzzzzzzq_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> xzzzzzzzzzzzzr_ = context.Operators.Union<Encounter>(xzzzzzzzzzzzzo_, xzzzzzzzzzzzzq_);
        IEnumerable<Encounter> xzzzzzzzzzzzzs_ = context.Operators.Union<Encounter>(xzzzzzzzzzzzzm_, xzzzzzzzzzzzzr_);
        CqlValueSet xzzzzzzzzzzzzt_ = this.Physical_Therapy_Evaluation(context);
        IEnumerable<Encounter> xzzzzzzzzzzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet xzzzzzzzzzzzzv_ = this.Psych_Visit_Diagnostic_Evaluation(context);
        IEnumerable<Encounter> xzzzzzzzzzzzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> xzzzzzzzzzzzzx_ = context.Operators.Union<Encounter>(xzzzzzzzzzzzzu_, xzzzzzzzzzzzzw_);
        IEnumerable<Encounter> xzzzzzzzzzzzzy_ = context.Operators.Union<Encounter>(xzzzzzzzzzzzzs_, xzzzzzzzzzzzzx_);
        CqlValueSet xzzzzzzzzzzzzz_ = this.Psych_Visit_Psychotherapy(context);
        IEnumerable<Encounter> yzzzzzzzzzzzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet yzzzzzzzzzzzzb_ = this.Psychoanalysis(context);
        IEnumerable<Encounter> yzzzzzzzzzzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> yzzzzzzzzzzzzd_ = context.Operators.Union<Encounter>(yzzzzzzzzzzzza_, yzzzzzzzzzzzzc_);
        IEnumerable<Encounter> yzzzzzzzzzzzze_ = context.Operators.Union<Encounter>(xzzzzzzzzzzzzy_, yzzzzzzzzzzzzd_);
        CqlValueSet yzzzzzzzzzzzzf_ = this.Speech_and_Hearing_Evaluation(context);
        IEnumerable<Encounter> yzzzzzzzzzzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet yzzzzzzzzzzzzh_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> yzzzzzzzzzzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> yzzzzzzzzzzzzj_ = context.Operators.Union<Encounter>(yzzzzzzzzzzzzg_, yzzzzzzzzzzzzi_);
        IEnumerable<Encounter> yzzzzzzzzzzzzk_ = context.Operators.Union<Encounter>(yzzzzzzzzzzzze_, yzzzzzzzzzzzzj_);
        CqlValueSet yzzzzzzzzzzzzl_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> yzzzzzzzzzzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> yzzzzzzzzzzzzn_ = context.Operators.Union<Encounter>(yzzzzzzzzzzzzk_, yzzzzzzzzzzzzm_);
        IEnumerable<Encounter> yzzzzzzzzzzzzo_ = Status_1_8_000.Instance.isEncounterPerformed(context, yzzzzzzzzzzzzn_);
        bool? yzzzzzzzzzzzzp_(Encounter OfficeBasedEncounter)
        {
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzl_ = this.Measurement_Period(context);
            Period zzzzzzzzzzzzzm_ = OfficeBasedEncounter?.Period;
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.toInterval(context, zzzzzzzzzzzzzn_ as object);
            bool? zzzzzzzzzzzzzp_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(zzzzzzzzzzzzzl_, zzzzzzzzzzzzzo_, "day");

            return zzzzzzzzzzzzzp_;
        };
        IEnumerable<Encounter> yzzzzzzzzzzzzq_ = context.Operators.Where<Encounter>(yzzzzzzzzzzzzo_, yzzzzzzzzzzzzp_);

        return yzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition(
        definitionName: "Preventive Visit During Measurement Period")]
    public IEnumerable<Encounter> Preventive_Visit_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet zzzzzzzzzzzzzq_ = this.Annual_Wellness_Visit(context);
        IEnumerable<Encounter> zzzzzzzzzzzzzr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet zzzzzzzzzzzzzs_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> zzzzzzzzzzzzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> zzzzzzzzzzzzzu_ = context.Operators.Union<Encounter>(zzzzzzzzzzzzzr_, zzzzzzzzzzzzzt_);
        CqlValueSet zzzzzzzzzzzzzv_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> zzzzzzzzzzzzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet zzzzzzzzzzzzzx_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> zzzzzzzzzzzzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> zzzzzzzzzzzzzz_ = context.Operators.Union<Encounter>(zzzzzzzzzzzzzw_, zzzzzzzzzzzzzy_);
        IEnumerable<Encounter> azzzzzzzzzzzzza_ = context.Operators.Union<Encounter>(zzzzzzzzzzzzzu_, zzzzzzzzzzzzzz_);
        CqlValueSet azzzzzzzzzzzzzb_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet azzzzzzzzzzzzzd_ = this.Preventive_Care_Services_Group_Counseling(context);
        IEnumerable<Encounter> azzzzzzzzzzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> azzzzzzzzzzzzzf_ = context.Operators.Union<Encounter>(azzzzzzzzzzzzzc_, azzzzzzzzzzzzze_);
        IEnumerable<Encounter> azzzzzzzzzzzzzg_ = context.Operators.Union<Encounter>(azzzzzzzzzzzzza_, azzzzzzzzzzzzzf_);
        CqlValueSet azzzzzzzzzzzzzh_ = this.Preventive_Care_Services_Individual_Counseling(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> azzzzzzzzzzzzzj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? azzzzzzzzzzzzzk_(Encounter E)
        {
            List<CodeableConcept> azzzzzzzzzzzzzy_ = E?.Type;
            CqlConcept azzzzzzzzzzzzzz_(CodeableConcept @this)
            {
                CqlConcept bzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return bzzzzzzzzzzzzze_;
            };
            IEnumerable<CqlConcept> bzzzzzzzzzzzzza_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)azzzzzzzzzzzzzy_, azzzzzzzzzzzzzz_);
            bool? bzzzzzzzzzzzzzb_(CqlConcept T)
            {
                CqlCode bzzzzzzzzzzzzzf_ = this.Unlisted_preventive_medicine_service(context);
                CqlConcept bzzzzzzzzzzzzzg_ = context.Operators.ConvertCodeToConcept(bzzzzzzzzzzzzzf_);
                bool? bzzzzzzzzzzzzzh_ = context.Operators.Equivalent(T, bzzzzzzzzzzzzzg_);

                return bzzzzzzzzzzzzzh_;
            };
            IEnumerable<CqlConcept> bzzzzzzzzzzzzzc_ = context.Operators.Where<CqlConcept>(bzzzzzzzzzzzzza_, bzzzzzzzzzzzzzb_);
            bool? bzzzzzzzzzzzzzd_ = context.Operators.Exists<CqlConcept>(bzzzzzzzzzzzzzc_);

            return bzzzzzzzzzzzzzd_;
        };
        IEnumerable<Encounter> azzzzzzzzzzzzzl_ = context.Operators.Where<Encounter>(azzzzzzzzzzzzzj_, azzzzzzzzzzzzzk_);
        IEnumerable<Encounter> azzzzzzzzzzzzzm_ = context.Operators.Union<Encounter>(azzzzzzzzzzzzzi_, azzzzzzzzzzzzzl_);
        IEnumerable<Encounter> azzzzzzzzzzzzzn_ = context.Operators.Union<Encounter>(azzzzzzzzzzzzzg_, azzzzzzzzzzzzzm_);
        bool? azzzzzzzzzzzzzp_(Encounter E)
        {
            List<CodeableConcept> bzzzzzzzzzzzzzi_ = E?.Type;
            CqlConcept bzzzzzzzzzzzzzj_(CodeableConcept @this)
            {
                CqlConcept bzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return bzzzzzzzzzzzzzo_;
            };
            IEnumerable<CqlConcept> bzzzzzzzzzzzzzk_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)bzzzzzzzzzzzzzi_, bzzzzzzzzzzzzzj_);
            bool? bzzzzzzzzzzzzzl_(CqlConcept T)
            {
                CqlCode bzzzzzzzzzzzzzp_ = this.Postoperative_follow_up_visit__normally_included_in_the_surgical_package__to_indicate_that_an_evaluation_and_management_service_was_performed_during_a_postoperative_period_for_a_reason_s__related_to_the_original_procedure(context);
                CqlConcept bzzzzzzzzzzzzzq_ = context.Operators.ConvertCodeToConcept(bzzzzzzzzzzzzzp_);
                bool? bzzzzzzzzzzzzzr_ = context.Operators.Equivalent(T, bzzzzzzzzzzzzzq_);

                return bzzzzzzzzzzzzzr_;
            };
            IEnumerable<CqlConcept> bzzzzzzzzzzzzzm_ = context.Operators.Where<CqlConcept>(bzzzzzzzzzzzzzk_, bzzzzzzzzzzzzzl_);
            bool? bzzzzzzzzzzzzzn_ = context.Operators.Exists<CqlConcept>(bzzzzzzzzzzzzzm_);

            return bzzzzzzzzzzzzzn_;
        };
        IEnumerable<Encounter> azzzzzzzzzzzzzq_ = context.Operators.Where<Encounter>(azzzzzzzzzzzzzj_, azzzzzzzzzzzzzp_);
        CqlValueSet azzzzzzzzzzzzzr_ = this.Nutrition_Services(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> azzzzzzzzzzzzzt_ = context.Operators.Union<Encounter>(azzzzzzzzzzzzzq_, azzzzzzzzzzzzzs_);
        IEnumerable<Encounter> azzzzzzzzzzzzzu_ = context.Operators.Union<Encounter>(azzzzzzzzzzzzzn_, azzzzzzzzzzzzzt_);
        IEnumerable<Encounter> azzzzzzzzzzzzzv_ = Status_1_8_000.Instance.isEncounterPerformed(context, azzzzzzzzzzzzzu_);
        bool? azzzzzzzzzzzzzw_(Encounter PreventiveEncounter)
        {
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzs_ = this.Measurement_Period(context);
            Period bzzzzzzzzzzzzzt_ = PreventiveEncounter?.Period;
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzzzu_ as object);
            bool? bzzzzzzzzzzzzzw_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(bzzzzzzzzzzzzzs_, bzzzzzzzzzzzzzv_, "day");

            return bzzzzzzzzzzzzzw_;
        };
        IEnumerable<Encounter> azzzzzzzzzzzzzx_ = context.Operators.Where<Encounter>(azzzzzzzzzzzzzv_, azzzzzzzzzzzzzw_);

        return azzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient bzzzzzzzzzzzzzx_ = this.Patient(context);
        Date bzzzzzzzzzzzzzy_ = bzzzzzzzzzzzzzx_?.BirthDateElement;
        string bzzzzzzzzzzzzzz_ = bzzzzzzzzzzzzzy_?.Value;
        CqlDate czzzzzzzzzzzzza_ = context.Operators.ConvertStringToDate(bzzzzzzzzzzzzzz_);
        CqlInterval<CqlDateTime> czzzzzzzzzzzzzb_ = this.Measurement_Period(context);
        CqlDateTime czzzzzzzzzzzzzc_ = context.Operators.Start(czzzzzzzzzzzzzb_);
        CqlDate czzzzzzzzzzzzzd_ = context.Operators.DateFrom(czzzzzzzzzzzzzc_);
        int? czzzzzzzzzzzzze_ = context.Operators.CalculateAgeAt(czzzzzzzzzzzzza_, czzzzzzzzzzzzzd_, "year");
        bool? czzzzzzzzzzzzzf_ = context.Operators.GreaterOrEqual(czzzzzzzzzzzzze_, 12);
        IEnumerable<Encounter> czzzzzzzzzzzzzg_ = this.Qualifying_Visit_During_Measurement_Period(context);
        int? czzzzzzzzzzzzzh_ = context.Operators.Count<Encounter>(czzzzzzzzzzzzzg_);
        bool? czzzzzzzzzzzzzi_ = context.Operators.GreaterOrEqual(czzzzzzzzzzzzzh_, 2);
        IEnumerable<Encounter> czzzzzzzzzzzzzj_ = this.Preventive_Visit_During_Measurement_Period(context);
        bool? czzzzzzzzzzzzzk_ = context.Operators.Exists<Encounter>(czzzzzzzzzzzzzj_);
        bool? czzzzzzzzzzzzzl_ = context.Operators.Or(czzzzzzzzzzzzzi_, czzzzzzzzzzzzzk_);
        bool? czzzzzzzzzzzzzm_ = context.Operators.And(czzzzzzzzzzzzzf_, czzzzzzzzzzzzzl_);

        return czzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator 1")]
    public bool? Denominator_1(CqlContext context)
    {
        bool? czzzzzzzzzzzzzn_ = this.Initial_Population(context);

        return czzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition(
        definitionName: "Most Recent Tobacco Use Screening Indicates Tobacco User")]
    public Observation Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_User(CqlContext context)
    {
        CqlValueSet czzzzzzzzzzzzzo_ = this.Tobacco_Use_Screening(context);
        IEnumerable<Observation> czzzzzzzzzzzzzp_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, czzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> czzzzzzzzzzzzzq_ = Status_1_8_000.Instance.isAssessmentPerformed(context, czzzzzzzzzzzzzp_);
        bool? czzzzzzzzzzzzzr_(Observation TobaccoUseScreening)
        {
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzza_ = this.Measurement_Period(context);
            DataType dzzzzzzzzzzzzzb_ = TobaccoUseScreening?.Effective;
            object dzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.toInterval(context, dzzzzzzzzzzzzzc_);
            bool? dzzzzzzzzzzzzze_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(dzzzzzzzzzzzzza_, dzzzzzzzzzzzzzd_, "day");

            return dzzzzzzzzzzzzze_;
        };
        IEnumerable<Observation> czzzzzzzzzzzzzs_ = context.Operators.Where<Observation>(czzzzzzzzzzzzzq_, czzzzzzzzzzzzzr_);
        object czzzzzzzzzzzzzt_(Observation @this)
        {
            DataType dzzzzzzzzzzzzzf_ = @this?.Effective;
            object dzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.toInterval(context, dzzzzzzzzzzzzzg_);
            CqlDateTime dzzzzzzzzzzzzzi_ = context.Operators.Start(dzzzzzzzzzzzzzh_);

            return dzzzzzzzzzzzzzi_;
        };
        IEnumerable<Observation> czzzzzzzzzzzzzu_ = context.Operators.SortBy<Observation>(czzzzzzzzzzzzzs_, czzzzzzzzzzzzzt_, System.ComponentModel.ListSortDirection.Ascending);
        Observation czzzzzzzzzzzzzv_ = context.Operators.Last<Observation>(czzzzzzzzzzzzzu_);
        Observation[] czzzzzzzzzzzzzw_ = [
            czzzzzzzzzzzzzv_,
        ];
        bool? czzzzzzzzzzzzzx_(Observation MostRecentTobaccoUseScreening)
        {
            DataType dzzzzzzzzzzzzzj_ = MostRecentTobaccoUseScreening?.Value;
            object dzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzzj_);
            CqlValueSet dzzzzzzzzzzzzzl_ = this.Tobacco_User(context);
            bool? dzzzzzzzzzzzzzm_ = context.Operators.ConceptInValueSet(dzzzzzzzzzzzzzk_ as CqlConcept, dzzzzzzzzzzzzzl_);

            return dzzzzzzzzzzzzzm_;
        };
        IEnumerable<Observation> czzzzzzzzzzzzzy_ = context.Operators.Where<Observation>((IEnumerable<Observation>)czzzzzzzzzzzzzw_, czzzzzzzzzzzzzx_);
        Observation czzzzzzzzzzzzzz_ = context.Operators.SingletonFrom<Observation>(czzzzzzzzzzzzzy_);

        return czzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator 2")]
    public bool? Denominator_2(CqlContext context)
    {
        bool? dzzzzzzzzzzzzzn_ = this.Initial_Population(context);
        Observation dzzzzzzzzzzzzzo_ = this.Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_User(context);
        bool? dzzzzzzzzzzzzzp_ = context.Operators.Not((bool?)(dzzzzzzzzzzzzzo_ is null));
        bool? dzzzzzzzzzzzzzq_ = context.Operators.And(dzzzzzzzzzzzzzn_, dzzzzzzzzzzzzzp_);

        return dzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator 3")]
    public bool? Denominator_3(CqlContext context)
    {
        bool? dzzzzzzzzzzzzzr_ = this.Initial_Population(context);

        return dzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition(
        definitionName: "Most Recent Tobacco Use Screening Indicates Tobacco Non User")]
    public Observation Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_Non_User(CqlContext context)
    {
        CqlValueSet dzzzzzzzzzzzzzs_ = this.Tobacco_Use_Screening(context);
        IEnumerable<Observation> dzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, dzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> dzzzzzzzzzzzzzu_ = Status_1_8_000.Instance.isAssessmentPerformed(context, dzzzzzzzzzzzzzt_);
        bool? dzzzzzzzzzzzzzv_(Observation TobaccoUseScreening)
        {
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzze_ = this.Measurement_Period(context);
            DataType ezzzzzzzzzzzzzf_ = TobaccoUseScreening?.Effective;
            object ezzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.toInterval(context, ezzzzzzzzzzzzzg_);
            bool? ezzzzzzzzzzzzzi_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ezzzzzzzzzzzzze_, ezzzzzzzzzzzzzh_, "day");

            return ezzzzzzzzzzzzzi_;
        };
        IEnumerable<Observation> dzzzzzzzzzzzzzw_ = context.Operators.Where<Observation>(dzzzzzzzzzzzzzu_, dzzzzzzzzzzzzzv_);
        object dzzzzzzzzzzzzzx_(Observation @this)
        {
            DataType ezzzzzzzzzzzzzj_ = @this?.Effective;
            object ezzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, ezzzzzzzzzzzzzk_);
            CqlDateTime ezzzzzzzzzzzzzm_ = context.Operators.Start(ezzzzzzzzzzzzzl_);

            return ezzzzzzzzzzzzzm_;
        };
        IEnumerable<Observation> dzzzzzzzzzzzzzy_ = context.Operators.SortBy<Observation>(dzzzzzzzzzzzzzw_, dzzzzzzzzzzzzzx_, System.ComponentModel.ListSortDirection.Ascending);
        Observation dzzzzzzzzzzzzzz_ = context.Operators.Last<Observation>(dzzzzzzzzzzzzzy_);
        Observation[] ezzzzzzzzzzzzza_ = [
            dzzzzzzzzzzzzzz_,
        ];
        bool? ezzzzzzzzzzzzzb_(Observation MostRecentTobaccoUseScreening)
        {
            DataType ezzzzzzzzzzzzzn_ = MostRecentTobaccoUseScreening?.Value;
            object ezzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzn_);
            CqlValueSet ezzzzzzzzzzzzzp_ = this.Tobacco_Non_User(context);
            bool? ezzzzzzzzzzzzzq_ = context.Operators.ConceptInValueSet(ezzzzzzzzzzzzzo_ as CqlConcept, ezzzzzzzzzzzzzp_);

            return ezzzzzzzzzzzzzq_;
        };
        IEnumerable<Observation> ezzzzzzzzzzzzzc_ = context.Operators.Where<Observation>((IEnumerable<Observation>)ezzzzzzzzzzzzza_, ezzzzzzzzzzzzzb_);
        Observation ezzzzzzzzzzzzzd_ = context.Operators.SingletonFrom<Observation>(ezzzzzzzzzzzzzc_);

        return ezzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator 1")]
    public bool? Numerator_1(CqlContext context)
    {
        Observation ezzzzzzzzzzzzzr_ = this.Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_Non_User(context);
        bool? ezzzzzzzzzzzzzs_ = context.Operators.Not((bool?)(ezzzzzzzzzzzzzr_ is null));
        Observation ezzzzzzzzzzzzzt_ = this.Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_User(context);
        bool? ezzzzzzzzzzzzzu_ = context.Operators.Not((bool?)(ezzzzzzzzzzzzzt_ is null));
        bool? ezzzzzzzzzzzzzv_ = context.Operators.Or(ezzzzzzzzzzzzzs_, ezzzzzzzzzzzzzu_);

        return ezzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition(
        definitionName: "Tobacco Cessation Counseling Given")]
    public IEnumerable<object> Tobacco_Cessation_Counseling_Given(CqlContext context)
    {
        CqlValueSet ezzzzzzzzzzzzzw_ = this.Tobacco_Use_Cessation_Counseling(context);
        IEnumerable<Procedure> ezzzzzzzzzzzzzx_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, ezzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> ezzzzzzzzzzzzzy_ = Status_1_8_000.Instance.isInterventionPerformed(context, ezzzzzzzzzzzzzx_);
        bool? ezzzzzzzzzzzzzz_(Procedure TobaccoCessationCounseling)
        {
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzh_ = this.Measurement_Period(context);
            CqlDateTime fzzzzzzzzzzzzzi_ = context.Operators.Start(fzzzzzzzzzzzzzh_);
            CqlQuantity fzzzzzzzzzzzzzj_ = context.Operators.Quantity(6m, "months");
            CqlDateTime fzzzzzzzzzzzzzk_ = context.Operators.Subtract(fzzzzzzzzzzzzzi_, fzzzzzzzzzzzzzj_);
            CqlDateTime fzzzzzzzzzzzzzm_ = context.Operators.End(fzzzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzn_ = context.Operators.Interval(fzzzzzzzzzzzzzk_, fzzzzzzzzzzzzzm_, true, true);
            DataType fzzzzzzzzzzzzzo_ = TobaccoCessationCounseling?.Performed;
            object fzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.toInterval(context, fzzzzzzzzzzzzzp_);
            bool? fzzzzzzzzzzzzzr_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(fzzzzzzzzzzzzzn_, fzzzzzzzzzzzzzq_, "day");

            return fzzzzzzzzzzzzzr_;
        };
        IEnumerable<Procedure> fzzzzzzzzzzzzza_ = context.Operators.Where<Procedure>(ezzzzzzzzzzzzzy_, ezzzzzzzzzzzzzz_);
        CqlCode fzzzzzzzzzzzzzb_ = this.Tobacco_abuse_counseling(context);
        IEnumerable<CqlCode> fzzzzzzzzzzzzzc_ = context.Operators.ToList<CqlCode>(fzzzzzzzzzzzzzb_);
        IEnumerable<Condition> fzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, fzzzzzzzzzzzzzc_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? fzzzzzzzzzzzzze_(Condition TobaccoCounseling)
        {
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, TobaccoCounseling);
            CqlDateTime fzzzzzzzzzzzzzt_ = context.Operators.Start(fzzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzu_ = this.Measurement_Period(context);
            CqlDateTime fzzzzzzzzzzzzzv_ = context.Operators.Start(fzzzzzzzzzzzzzu_);
            CqlQuantity fzzzzzzzzzzzzzw_ = context.Operators.Quantity(6m, "months");
            CqlDateTime fzzzzzzzzzzzzzx_ = context.Operators.Subtract(fzzzzzzzzzzzzzv_, fzzzzzzzzzzzzzw_);
            CqlDateTime fzzzzzzzzzzzzzz_ = context.Operators.End(fzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzza_ = context.Operators.Interval(fzzzzzzzzzzzzzx_, fzzzzzzzzzzzzzz_, true, true);
            bool? gzzzzzzzzzzzzzb_ = context.Operators.In<CqlDateTime>(fzzzzzzzzzzzzzt_, gzzzzzzzzzzzzza_, "day");

            return gzzzzzzzzzzzzzb_;
        };
        IEnumerable<Condition> fzzzzzzzzzzzzzf_ = context.Operators.Where<Condition>(fzzzzzzzzzzzzzd_, fzzzzzzzzzzzzze_);
        IEnumerable<object> fzzzzzzzzzzzzzg_ = context.Operators.Union<object>(fzzzzzzzzzzzzza_ as IEnumerable<object>, fzzzzzzzzzzzzzf_ as IEnumerable<object>);

        return fzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition(
        definitionName: "Tobacco Cessation Pharmacotherapy Ordered")]
    public IEnumerable<MedicationRequest> Tobacco_Cessation_Pharmacotherapy_Ordered(CqlContext context)
    {
        CqlValueSet gzzzzzzzzzzzzzc_ = this.Tobacco_Use_Cessation_Pharmacotherapy(context);
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzd_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzf_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzg_ = context.Operators.Union<MedicationRequest>(gzzzzzzzzzzzzzd_, gzzzzzzzzzzzzzf_);
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzh_ = Status_1_8_000.Instance.isMedicationOrder(context, gzzzzzzzzzzzzzg_);
        bool? gzzzzzzzzzzzzzi_(MedicationRequest CessationPharmacotherapyOrdered)
        {
            FhirDateTime gzzzzzzzzzzzzzk_ = CessationPharmacotherapyOrdered?.AuthoredOnElement;
            CqlDateTime gzzzzzzzzzzzzzl_ = context.Operators.Convert<CqlDateTime>(gzzzzzzzzzzzzzk_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzm_ = this.Measurement_Period(context);
            CqlDateTime gzzzzzzzzzzzzzn_ = context.Operators.Start(gzzzzzzzzzzzzzm_);
            CqlQuantity gzzzzzzzzzzzzzo_ = context.Operators.Quantity(6m, "months");
            CqlDateTime gzzzzzzzzzzzzzp_ = context.Operators.Subtract(gzzzzzzzzzzzzzn_, gzzzzzzzzzzzzzo_);
            CqlDateTime gzzzzzzzzzzzzzr_ = context.Operators.End(gzzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzs_ = context.Operators.Interval(gzzzzzzzzzzzzzp_, gzzzzzzzzzzzzzr_, true, true);
            bool? gzzzzzzzzzzzzzt_ = context.Operators.In<CqlDateTime>(gzzzzzzzzzzzzzl_, gzzzzzzzzzzzzzs_, "day");

            return gzzzzzzzzzzzzzt_;
        };
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzj_ = context.Operators.Where<MedicationRequest>(gzzzzzzzzzzzzzh_, gzzzzzzzzzzzzzi_);

        return gzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition(
        definitionName: "Active Pharmacotherapy for Tobacco Cessation")]
    public IEnumerable<MedicationRequest> Active_Pharmacotherapy_for_Tobacco_Cessation(CqlContext context)
    {
        CqlValueSet gzzzzzzzzzzzzzu_ = this.Tobacco_Use_Cessation_Pharmacotherapy(context);
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzv_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzx_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, gzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzy_ = context.Operators.Union<MedicationRequest>(gzzzzzzzzzzzzzv_, gzzzzzzzzzzzzzx_);
        IEnumerable<MedicationRequest> gzzzzzzzzzzzzzz_ = Status_1_8_000.Instance.isMedicationActive(context, gzzzzzzzzzzzzzy_);
        bool? hzzzzzzzzzzzzza_(MedicationRequest TakingCessationPharmacotherapy)
        {
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzc_ = this.Measurement_Period(context);
            CqlDateTime hzzzzzzzzzzzzzd_ = context.Operators.Start(hzzzzzzzzzzzzzc_);
            CqlQuantity hzzzzzzzzzzzzze_ = context.Operators.Quantity(6m, "months");
            CqlDateTime hzzzzzzzzzzzzzf_ = context.Operators.Subtract(hzzzzzzzzzzzzzd_, hzzzzzzzzzzzzze_);
            CqlDateTime hzzzzzzzzzzzzzh_ = context.Operators.End(hzzzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzi_ = context.Operators.Interval(hzzzzzzzzzzzzzf_, hzzzzzzzzzzzzzh_, true, true);
            CqlInterval<CqlDate> hzzzzzzzzzzzzzj_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, TakingCessationPharmacotherapy);
            CqlDate hzzzzzzzzzzzzzk_ = hzzzzzzzzzzzzzj_?.low;
            CqlDateTime hzzzzzzzzzzzzzl_ = context.Operators.ConvertDateToDateTime(hzzzzzzzzzzzzzk_);
            CqlDate hzzzzzzzzzzzzzn_ = hzzzzzzzzzzzzzj_?.high;
            CqlDateTime hzzzzzzzzzzzzzo_ = context.Operators.ConvertDateToDateTime(hzzzzzzzzzzzzzn_);
            bool? hzzzzzzzzzzzzzq_ = hzzzzzzzzzzzzzj_?.lowClosed;
            bool? hzzzzzzzzzzzzzs_ = hzzzzzzzzzzzzzj_?.highClosed;
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzt_ = context.Operators.Interval(hzzzzzzzzzzzzzl_, hzzzzzzzzzzzzzo_, hzzzzzzzzzzzzzq_, hzzzzzzzzzzzzzs_);
            bool? hzzzzzzzzzzzzzu_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(hzzzzzzzzzzzzzi_, hzzzzzzzzzzzzzt_, "day");

            return hzzzzzzzzzzzzzu_;
        };
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzb_ = context.Operators.Where<MedicationRequest>(gzzzzzzzzzzzzzz_, hzzzzzzzzzzzzza_);

        return hzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator 2")]
    public bool? Numerator_2(CqlContext context)
    {
        IEnumerable<object> hzzzzzzzzzzzzzv_ = this.Tobacco_Cessation_Counseling_Given(context);
        bool? hzzzzzzzzzzzzzw_ = context.Operators.Exists<object>(hzzzzzzzzzzzzzv_);
        IEnumerable<MedicationRequest> hzzzzzzzzzzzzzx_ = this.Tobacco_Cessation_Pharmacotherapy_Ordered(context);
        bool? hzzzzzzzzzzzzzy_ = context.Operators.Exists<MedicationRequest>(hzzzzzzzzzzzzzx_);
        bool? hzzzzzzzzzzzzzz_ = context.Operators.Or(hzzzzzzzzzzzzzw_, hzzzzzzzzzzzzzy_);
        IEnumerable<MedicationRequest> izzzzzzzzzzzzza_ = this.Active_Pharmacotherapy_for_Tobacco_Cessation(context);
        bool? izzzzzzzzzzzzzb_ = context.Operators.Exists<MedicationRequest>(izzzzzzzzzzzzza_);
        bool? izzzzzzzzzzzzzc_ = context.Operators.Or(hzzzzzzzzzzzzzz_, izzzzzzzzzzzzzb_);

        return izzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator 3")]
    public bool? Numerator_3(CqlContext context)
    {
        Observation izzzzzzzzzzzzzd_ = this.Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_Non_User(context);
        bool? izzzzzzzzzzzzze_ = context.Operators.Not((bool?)(izzzzzzzzzzzzzd_ is null));
        Observation izzzzzzzzzzzzzf_ = this.Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_User(context);
        bool? izzzzzzzzzzzzzg_ = context.Operators.Not((bool?)(izzzzzzzzzzzzzf_ is null));
        IEnumerable<object> izzzzzzzzzzzzzh_ = this.Tobacco_Cessation_Counseling_Given(context);
        bool? izzzzzzzzzzzzzi_ = context.Operators.Exists<object>(izzzzzzzzzzzzzh_);
        IEnumerable<MedicationRequest> izzzzzzzzzzzzzj_ = this.Tobacco_Cessation_Pharmacotherapy_Ordered(context);
        bool? izzzzzzzzzzzzzk_ = context.Operators.Exists<MedicationRequest>(izzzzzzzzzzzzzj_);
        bool? izzzzzzzzzzzzzl_ = context.Operators.Or(izzzzzzzzzzzzzi_, izzzzzzzzzzzzzk_);
        IEnumerable<MedicationRequest> izzzzzzzzzzzzzm_ = this.Active_Pharmacotherapy_for_Tobacco_Cessation(context);
        bool? izzzzzzzzzzzzzn_ = context.Operators.Exists<MedicationRequest>(izzzzzzzzzzzzzm_);
        bool? izzzzzzzzzzzzzo_ = context.Operators.Or(izzzzzzzzzzzzzl_, izzzzzzzzzzzzzn_);
        bool? izzzzzzzzzzzzzp_ = context.Operators.And(izzzzzzzzzzzzzg_, izzzzzzzzzzzzzo_);
        bool? izzzzzzzzzzzzzq_ = context.Operators.Or(izzzzzzzzzzzzze_, izzzzzzzzzzzzzp_);

        return izzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator Exclusion")]
    public bool? Denominator_Exclusion(CqlContext context)
    {
        bool? izzzzzzzzzzzzzr_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);

        return izzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? izzzzzzzzzzzzzs_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return izzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> izzzzzzzzzzzzzt_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return izzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? izzzzzzzzzzzzzu_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return izzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode izzzzzzzzzzzzzv_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return izzzzzzzzzzzzzv_;
    }


    #endregion Expressions

}
