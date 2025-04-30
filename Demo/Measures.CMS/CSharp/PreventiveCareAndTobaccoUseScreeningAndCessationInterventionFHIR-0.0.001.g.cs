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

    [CqlValueSetDefinition("Annual Wellness Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", valueSetVersion: null)]
    public CqlValueSet Annual_Wellness_Visit(CqlContext _) => _Annual_Wellness_Visit;
    private static readonly CqlValueSet _Annual_Wellness_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", null);

    [CqlValueSetDefinition("Home Healthcare Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", valueSetVersion: null)]
    public CqlValueSet Home_Healthcare_Services(CqlContext _) => _Home_Healthcare_Services;
    private static readonly CqlValueSet _Home_Healthcare_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);

    [CqlValueSetDefinition("Limited Life Expectancy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1259", valueSetVersion: null)]
    public CqlValueSet Limited_Life_Expectancy(CqlContext _) => _Limited_Life_Expectancy;
    private static readonly CqlValueSet _Limited_Life_Expectancy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1259", null);

    [CqlValueSetDefinition("Medical Reason", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007", valueSetVersion: null)]
    public CqlValueSet Medical_Reason(CqlContext _) => _Medical_Reason;
    private static readonly CqlValueSet _Medical_Reason = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007", null);

    [CqlValueSetDefinition("Nutrition Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1006", valueSetVersion: null)]
    public CqlValueSet Nutrition_Services(CqlContext _) => _Nutrition_Services;
    private static readonly CqlValueSet _Nutrition_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1006", null);

    [CqlValueSetDefinition("Occupational Therapy Evaluation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1011", valueSetVersion: null)]
    public CqlValueSet Occupational_Therapy_Evaluation(CqlContext _) => _Occupational_Therapy_Evaluation;
    private static readonly CqlValueSet _Occupational_Therapy_Evaluation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1011", null);

    [CqlValueSetDefinition("Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext _) => _Office_Visit;
    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlValueSetDefinition("Ophthalmological Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285", valueSetVersion: null)]
    public CqlValueSet Ophthalmological_Services(CqlContext _) => _Ophthalmological_Services;
    private static readonly CqlValueSet _Ophthalmological_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285", null);

    [CqlValueSetDefinition("Physical Therapy Evaluation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1022", valueSetVersion: null)]
    public CqlValueSet Physical_Therapy_Evaluation(CqlContext _) => _Physical_Therapy_Evaluation;
    private static readonly CqlValueSet _Physical_Therapy_Evaluation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1022", null);

    [CqlValueSetDefinition("Preventive Care Services Established Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services_Established_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services_Established_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);

    [CqlValueSetDefinition("Preventive Care Services Group Counseling", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1027", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Group_Counseling(CqlContext _) => _Preventive_Care_Services_Group_Counseling;
    private static readonly CqlValueSet _Preventive_Care_Services_Group_Counseling = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1027", null);

    [CqlValueSetDefinition("Preventive Care Services Individual Counseling", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Individual_Counseling(CqlContext _) => _Preventive_Care_Services_Individual_Counseling;
    private static readonly CqlValueSet _Preventive_Care_Services_Individual_Counseling = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026", null);

    [CqlValueSetDefinition("Preventive Care Services Initial Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services_Initial_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services_Initial_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);

    [CqlValueSetDefinition("Preventive Care Services, Initial Office Visit, 0 to 17", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services__Initial_Office_Visit__0_to_17(CqlContext _) => _Preventive_Care_Services__Initial_Office_Visit__0_to_17;
    private static readonly CqlValueSet _Preventive_Care_Services__Initial_Office_Visit__0_to_17 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", null);

    [CqlValueSetDefinition("Preventive Care, Established Office Visit, 0 to 17", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", valueSetVersion: null)]
    public CqlValueSet Preventive_Care__Established_Office_Visit__0_to_17(CqlContext _) => _Preventive_Care__Established_Office_Visit__0_to_17;
    private static readonly CqlValueSet _Preventive_Care__Established_Office_Visit__0_to_17 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", null);

    [CqlValueSetDefinition("Psych Visit Diagnostic Evaluation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1492", valueSetVersion: null)]
    public CqlValueSet Psych_Visit_Diagnostic_Evaluation(CqlContext _) => _Psych_Visit_Diagnostic_Evaluation;
    private static readonly CqlValueSet _Psych_Visit_Diagnostic_Evaluation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1492", null);

    [CqlValueSetDefinition("Psych Visit Psychotherapy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1496", valueSetVersion: null)]
    public CqlValueSet Psych_Visit_Psychotherapy(CqlContext _) => _Psych_Visit_Psychotherapy;
    private static readonly CqlValueSet _Psych_Visit_Psychotherapy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1496", null);

    [CqlValueSetDefinition("Psychoanalysis", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1141", valueSetVersion: null)]
    public CqlValueSet Psychoanalysis(CqlContext _) => _Psychoanalysis;
    private static readonly CqlValueSet _Psychoanalysis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1141", null);

    [CqlValueSetDefinition("Speech and Hearing Evaluation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1530", valueSetVersion: null)]
    public CqlValueSet Speech_and_Hearing_Evaluation(CqlContext _) => _Speech_and_Hearing_Evaluation;
    private static readonly CqlValueSet _Speech_and_Hearing_Evaluation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1530", null);

    [CqlValueSetDefinition("Telephone Visits", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", valueSetVersion: null)]
    public CqlValueSet Telephone_Visits(CqlContext _) => _Telephone_Visits;
    private static readonly CqlValueSet _Telephone_Visits = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    [CqlValueSetDefinition("Tobacco Non User", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1189", valueSetVersion: null)]
    public CqlValueSet Tobacco_Non_User(CqlContext _) => _Tobacco_Non_User;
    private static readonly CqlValueSet _Tobacco_Non_User = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1189", null);

    [CqlValueSetDefinition("Tobacco Use Cessation Counseling", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.509", valueSetVersion: null)]
    public CqlValueSet Tobacco_Use_Cessation_Counseling(CqlContext _) => _Tobacco_Use_Cessation_Counseling;
    private static readonly CqlValueSet _Tobacco_Use_Cessation_Counseling = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.509", null);

    [CqlValueSetDefinition("Tobacco Use Cessation Pharmacotherapy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1190", valueSetVersion: null)]
    public CqlValueSet Tobacco_Use_Cessation_Pharmacotherapy(CqlContext _) => _Tobacco_Use_Cessation_Pharmacotherapy;
    private static readonly CqlValueSet _Tobacco_Use_Cessation_Pharmacotherapy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1190", null);

    [CqlValueSetDefinition("Tobacco Use Screening", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1278", valueSetVersion: null)]
    public CqlValueSet Tobacco_Use_Screening(CqlContext _) => _Tobacco_Use_Screening;
    private static readonly CqlValueSet _Tobacco_Use_Screening = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1278", null);

    [CqlValueSetDefinition("Tobacco User", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1170", valueSetVersion: null)]
    public CqlValueSet Tobacco_User(CqlContext _) => _Tobacco_User;
    private static readonly CqlValueSet _Tobacco_User = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1170", null);

    [CqlValueSetDefinition("Virtual Encounter", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", valueSetVersion: null)]
    public CqlValueSet Virtual_Encounter(CqlContext _) => _Virtual_Encounter;
    private static readonly CqlValueSet _Virtual_Encounter = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Health behavior assessment, or re-assessment (ie, health-focused clinical interview, behavioral observations, clinical decision making)", codeId: "96156", codeSystem: "http://www.ama-assn.org/go/cpt")]
    public CqlCode Health_behavior_assessment__or_re_assessment__ie__health_focused_clinical_interview__behavioral_observations__clinical_decision_making_(CqlContext _) => _Health_behavior_assessment__or_re_assessment__ie__health_focused_clinical_interview__behavioral_observations__clinical_decision_making_;
    private static readonly CqlCode _Health_behavior_assessment__or_re_assessment__ie__health_focused_clinical_interview__behavioral_observations__clinical_decision_making_ = new CqlCode("96156", "http://www.ama-assn.org/go/cpt", default, default);

    [CqlCodeDefinition("Health behavior intervention, individual, face-to-face; initial 30 minutes", codeId: "96158", codeSystem: "http://www.ama-assn.org/go/cpt")]
    public CqlCode Health_behavior_intervention__individual__face_to_face__initial_30_minutes(CqlContext _) => _Health_behavior_intervention__individual__face_to_face__initial_30_minutes;
    private static readonly CqlCode _Health_behavior_intervention__individual__face_to_face__initial_30_minutes = new CqlCode("96158", "http://www.ama-assn.org/go/cpt", default, default);

    [CqlCodeDefinition("Postoperative follow-up visit, normally included in the surgical package, to indicate that an evaluation and management service was performed during a postoperative period for a reason(s) related to the original procedure", codeId: "99024", codeSystem: "http://www.ama-assn.org/go/cpt")]
    public CqlCode Postoperative_follow_up_visit__normally_included_in_the_surgical_package__to_indicate_that_an_evaluation_and_management_service_was_performed_during_a_postoperative_period_for_a_reason_s__related_to_the_original_procedure(CqlContext _) => _Postoperative_follow_up_visit__normally_included_in_the_surgical_package__to_indicate_that_an_evaluation_and_management_service_was_performed_during_a_postoperative_period_for_a_reason_s__related_to_the_original_procedure;
    private static readonly CqlCode _Postoperative_follow_up_visit__normally_included_in_the_surgical_package__to_indicate_that_an_evaluation_and_management_service_was_performed_during_a_postoperative_period_for_a_reason_s__related_to_the_original_procedure = new CqlCode("99024", "http://www.ama-assn.org/go/cpt", default, default);

    [CqlCodeDefinition("Tobacco abuse counseling", codeId: "Z71.6", codeSystem: "http://hl7.org/fhir/sid/icd-10-cm")]
    public CqlCode Tobacco_abuse_counseling(CqlContext _) => _Tobacco_abuse_counseling;
    private static readonly CqlCode _Tobacco_abuse_counseling = new CqlCode("Z71.6", "http://hl7.org/fhir/sid/icd-10-cm", default, default);

    [CqlCodeDefinition("Unlisted preventive medicine service", codeId: "99429", codeSystem: "http://www.ama-assn.org/go/cpt")]
    public CqlCode Unlisted_preventive_medicine_service(CqlContext _) => _Unlisted_preventive_medicine_service;
    private static readonly CqlCode _Unlisted_preventive_medicine_service = new CqlCode("99429", "http://www.ama-assn.org/go/cpt", default, default);

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("CPT")]
    public CqlCodeSystem CPT(CqlContext _) => _CPT;
    private static readonly CqlCodeSystem _CPT = new CqlCodeSystem();

    [CqlCodeSystemDefinition("ICD10CM")]
    public CqlCodeSystem ICD10CM(CqlContext _) => _ICD10CM;
    private static readonly CqlCodeSystem _ICD10CM = new CqlCodeSystem();

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Interval(zzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, zzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, true, true);
        object azzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.ResolveParameter("PreventiveCareAndTobaccoUseScreeningAndCessationInterventionFHIR-0.0.001", "Measurement Period", azzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

        return (CqlInterval<CqlDateTime>)azzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient azzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.SingletonFrom<Patient>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Qualifying Visit During Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Visit_During_Measurement_Period(CqlContext context)
    {
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_(Encounter E)
        {
            List<CodeableConcept> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = E?.Type;
            CqlConcept bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_(CodeableConcept @this)
            {
                CqlConcept czzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<CqlConcept> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_(CqlConcept T)
            {
                CqlCode czzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Health_behavior_intervention__individual__face_to_face__initial_30_minutes(context);
                CqlConcept czzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ConvertCodeToConcept(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Equivalent(T, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

                return czzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<CqlConcept> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<CqlConcept>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Exists<CqlConcept>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

            return czzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Encounter>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        bool? azzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Encounter E)
        {
            List<CodeableConcept> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = E?.Type;
            CqlConcept czzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_(CodeableConcept @this)
            {
                CqlConcept czzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
            };
            IEnumerable<CqlConcept> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)czzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(CqlConcept T)
            {
                CqlCode czzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Health_behavior_assessment__or_re_assessment__ie__health_focused_clinical_interview__behavioral_observations__clinical_decision_making_(context);
                CqlConcept czzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.ConvertCodeToConcept(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Equivalent(T, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

                return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<CqlConcept> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<CqlConcept>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Exists<CqlConcept>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

            return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Encounter>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<Encounter>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Occupational_Therapy_Evaluation(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<Encounter>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<Encounter>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Office_Visit(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Ophthalmological_Services(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<Encounter>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Union<Encounter>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Physical_Therapy_Evaluation(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Psych_Visit_Diagnostic_Evaluation(context);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Union<Encounter>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Union<Encounter>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Psych_Visit_Psychotherapy(context);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Psychoanalysis(context);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<Encounter>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Union<Encounter>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Speech_and_Hearing_Evaluation(context);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Union<Encounter>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Union<Encounter>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Union<Encounter>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = Status_1_8_000.Instance.isEncounterPerformed(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_(Encounter OfficeBasedEncounter)
        {
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Measurement_Period(context);
            Period czzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = OfficeBasedEncounter?.Period;
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.toInterval(context, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ as object);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, "day");

            return czzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Encounter>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

        return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Preventive Visit During Measurement Period")]
    public IEnumerable<Encounter> Preventive_Visit_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Annual_Wellness_Visit(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<Encounter>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Union<Encounter>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<Encounter>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Preventive_Care_Services_Group_Counseling(context);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Union<Encounter>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<Encounter>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Preventive_Care_Services_Individual_Counseling(context);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(Encounter E)
        {
            List<CodeableConcept> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = E?.Type;
            CqlConcept ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_(CodeableConcept @this)
            {
                CqlConcept ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<CqlConcept> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_(CqlConcept T)
            {
                CqlCode ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Unlisted_preventive_medicine_service(context);
                CqlConcept ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.ConvertCodeToConcept(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Equivalent(T, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

                return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
            };
            IEnumerable<CqlConcept> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<CqlConcept>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Exists<CqlConcept>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

            return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<Encounter>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<Encounter>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Union<Encounter>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_(Encounter E)
        {
            List<CodeableConcept> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = E?.Type;
            CqlConcept ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(CodeableConcept @this)
            {
                CqlConcept ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<CqlConcept> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_(CqlConcept T)
            {
                CqlCode ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Postoperative_follow_up_visit__normally_included_in_the_surgical_package__to_indicate_that_an_evaluation_and_management_service_was_performed_during_a_postoperative_period_for_a_reason_s__related_to_the_original_procedure(context);
                CqlConcept ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.ConvertCodeToConcept(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Equivalent(T, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

                return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<CqlConcept> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<CqlConcept>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Exists<CqlConcept>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

            return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Encounter>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Nutrition_Services(context);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Union<Encounter>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<Encounter>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = Status_1_8_000.Instance.isEncounterPerformed(context, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzza_(Encounter PreventiveEncounter)
        {
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Measurement_Period(context);
            Period ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = PreventiveEncounter?.Period;
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ as object);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, "day");

            return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Encounter>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Patient(context);
        Date fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_?.BirthDateElement;
        string fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_?.Value;
        CqlDate fzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.ConvertStringToDate(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Measurement_Period(context);
        CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        CqlDate fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.DateFrom(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        int? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.CalculateAgeAt(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, "year");
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.GreaterOrEqual(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, 12);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Qualifying_Visit_During_Measurement_Period(context);
        int? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Count<Encounter>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.GreaterOrEqual(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, 2);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Preventive_Visit_During_Measurement_Period(context);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Exists<Encounter>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Or(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

        return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Denominator 1")]
    public bool? Denominator_1(CqlContext context)
    {
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Initial_Population(context);

        return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Most Recent Tobacco Use Screening Indicates Tobacco User")]
    public Observation Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_User(CqlContext context)
    {
        CqlValueSet fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Tobacco_Use_Screening(context);
        IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = Status_1_8_000.Instance.isAssessmentPerformed(context, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_(Observation TobaccoUseScreening)
        {
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Measurement_Period(context);
            DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = TobaccoUseScreening?.Effective;
            object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, "day");

            return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Observation>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        object fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_(Observation @this)
        {
            DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = @this?.Effective;
            object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);

            return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Observation> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.SortBy<Observation>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, System.ComponentModel.ListSortDirection.Ascending);
        Observation fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Last<Observation>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        Observation[] gzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = [
            fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_,
        ];
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_(Observation MostRecentTobaccoUseScreening)
        {
            DataType gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = MostRecentTobaccoUseScreening?.Value;
            object gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlValueSet gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Tobacco_User(context);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.ConceptInValueSet(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ as CqlConcept, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

            return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Observation>((IEnumerable<Observation>)gzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        Observation gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.SingletonFrom<Observation>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

        return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Denominator 2")]
    public bool? Denominator_2(CqlContext context)
    {
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Initial_Population(context);
        Observation gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_User(context);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Not((bool?)(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ is null));
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

        return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Denominator 3")]
    public bool? Denominator_3(CqlContext context)
    {
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Initial_Population(context);

        return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Most Recent Tobacco Use Screening Indicates Tobacco Non User")]
    public Observation Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_Non_User(CqlContext context)
    {
        CqlValueSet gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Tobacco_Use_Screening(context);
        IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = Status_1_8_000.Instance.isAssessmentPerformed(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_(Observation TobaccoUseScreening)
        {
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Measurement_Period(context);
            DataType hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = TobaccoUseScreening?.Effective;
            object hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, "day");

            return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Observation>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        object hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_(Observation @this)
        {
            DataType hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = @this?.Effective;
            object hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

            return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.SortBy<Observation>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, System.ComponentModel.ListSortDirection.Ascending);
        Observation hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Last<Observation>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        Observation[] hzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = [
            hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_,
        ];
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_(Observation MostRecentTobaccoUseScreening)
        {
            DataType hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = MostRecentTobaccoUseScreening?.Value;
            object hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlValueSet hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Tobacco_Non_User(context);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.ConceptInValueSet(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ as CqlConcept, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

            return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Observation>((IEnumerable<Observation>)hzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        Observation hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.SingletonFrom<Observation>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

        return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Numerator 1")]
    public bool? Numerator_1(CqlContext context)
    {
        Observation hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_Non_User(context);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Not((bool?)(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ is null));
        Observation hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_User(context);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Not((bool?)(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ is null));
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Or(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

        return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Tobacco Cessation Counseling Given")]
    public IEnumerable<object> Tobacco_Cessation_Counseling_Given(CqlContext context)
    {
        CqlValueSet izzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Tobacco_Use_Cessation_Counseling(context);
        IEnumerable<Procedure> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, izzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = Status_1_8_000.Instance.isInterventionPerformed(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_(Procedure TobaccoCessationCounseling)
        {
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Measurement_Period(context);
            CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlQuantity izzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Quantity(6m, "months");
            CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Subtract(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.End(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Interval(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, true, true);
            DataType izzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = TobaccoCessationCounseling?.Performed;
            object izzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, "day");

            return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Procedure> izzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Procedure>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        CqlCode izzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Tobacco_abuse_counseling(context);
        IEnumerable<CqlCode> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.ToList<CqlCode>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        IEnumerable<Condition> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Condition TobaccoCounseling)
        {
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, TobaccoCounseling);
            CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Measurement_Period(context);
            CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Start(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlQuantity jzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Quantity(6m, "months");
            CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Subtract(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.End(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Interval(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, true, true);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.In<CqlDateTime>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, "day");

            return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Condition> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Condition>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<object> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<object>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ as IEnumerable<object>, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ as IEnumerable<object>);

        return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Tobacco Cessation Pharmacotherapy Ordered")]
    public IEnumerable<MedicationRequest> Tobacco_Cessation_Pharmacotherapy_Ordered(CqlContext context)
    {
        CqlValueSet jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Tobacco_Use_Cessation_Pharmacotherapy(context);
        IEnumerable<MedicationRequest> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<MedicationRequest>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<MedicationRequest> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = Status_1_8_000.Instance.isMedicationOrder(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_(MedicationRequest CessationPharmacotherapyOrdered)
        {
            FhirDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = CessationPharmacotherapyOrdered?.AuthoredOnElement;
            CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Convert<CqlDateTime>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Measurement_Period(context);
            CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Start(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlQuantity jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Quantity(6m, "months");
            CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Subtract(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.End(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Interval(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, true, true);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, "day");

            return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<MedicationRequest> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<MedicationRequest>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

        return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Active Pharmacotherapy for Tobacco Cessation")]
    public IEnumerable<MedicationRequest> Active_Pharmacotherapy_for_Tobacco_Cessation(CqlContext context)
    {
        CqlValueSet jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Tobacco_Use_Cessation_Pharmacotherapy(context);
        IEnumerable<MedicationRequest> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Union<MedicationRequest>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<MedicationRequest> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = Status_1_8_000.Instance.isMedicationActive(context, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_(MedicationRequest TakingCessationPharmacotherapy)
        {
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Measurement_Period(context);
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlQuantity kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Quantity(6m, "months");
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Subtract(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.End(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Interval(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, true, true);
            CqlInterval<CqlDate> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, TakingCessationPharmacotherapy);
            CqlDate kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_?.low;
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.ConvertDateToDateTime(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlDate kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_?.high;
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ConvertDateToDateTime(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_?.lowClosed;
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_?.highClosed;
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Interval(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, "day");

            return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<MedicationRequest> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<MedicationRequest>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

        return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Numerator 2")]
    public bool? Numerator_2(CqlContext context)
    {
        IEnumerable<object> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Tobacco_Cessation_Counseling_Given(context);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Exists<object>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<MedicationRequest> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Tobacco_Cessation_Pharmacotherapy_Ordered(context);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Exists<MedicationRequest>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Or(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<MedicationRequest> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Active_Pharmacotherapy_for_Tobacco_Cessation(context);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Exists<MedicationRequest>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Or(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);

        return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Numerator 3")]
    public bool? Numerator_3(CqlContext context)
    {
        Observation lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_Non_User(context);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Not((bool?)(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ is null));
        Observation lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_User(context);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Not((bool?)(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ is null));
        IEnumerable<object> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Tobacco_Cessation_Counseling_Given(context);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Exists<object>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<MedicationRequest> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Tobacco_Cessation_Pharmacotherapy_Ordered(context);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Exists<MedicationRequest>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Or(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<MedicationRequest> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Active_Pharmacotherapy_for_Tobacco_Cessation(context);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Exists<MedicationRequest>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Or(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Or(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

        return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Denominator Exclusion")]
    public bool? Denominator_Exclusion(CqlContext context)
    {
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);

        return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    #endregion Expressions

}
