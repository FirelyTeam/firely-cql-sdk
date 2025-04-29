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
        CqlDateTime dzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime dzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Interval(dzzzzzzzzzzzzzzzzzzzzza_, dzzzzzzzzzzzzzzzzzzzzzb_, true, true);
        object dzzzzzzzzzzzzzzzzzzzzzd_ = context.ResolveParameter("PreventiveCareAndTobaccoUseScreeningAndCessationInterventionFHIR-0.0.001", "Measurement Period", dzzzzzzzzzzzzzzzzzzzzzc_);

        return (CqlInterval<CqlDateTime>)dzzzzzzzzzzzzzzzzzzzzzd_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> dzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient dzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.SingletonFrom<Patient>(dzzzzzzzzzzzzzzzzzzzzze_);

        return dzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Qualifying Visit During Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Visit_During_Measurement_Period(CqlContext context)
    {
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? dzzzzzzzzzzzzzzzzzzzzzh_(Encounter E)
        {
            List<CodeableConcept> ezzzzzzzzzzzzzzzzzzzzzx_ = E?.Type;
            CqlConcept ezzzzzzzzzzzzzzzzzzzzzy_(CodeableConcept @this)
            {
                CqlConcept fzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return fzzzzzzzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<CqlConcept> ezzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)ezzzzzzzzzzzzzzzzzzzzzx_, ezzzzzzzzzzzzzzzzzzzzzy_);
            bool? fzzzzzzzzzzzzzzzzzzzzza_(CqlConcept T)
            {
                CqlCode fzzzzzzzzzzzzzzzzzzzzze_ = this.Health_behavior_intervention__individual__face_to_face__initial_30_minutes(context);
                CqlConcept fzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.ConvertCodeToConcept(fzzzzzzzzzzzzzzzzzzzzze_);
                bool? fzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Equivalent(T, fzzzzzzzzzzzzzzzzzzzzzf_);

                return fzzzzzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<CqlConcept> fzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<CqlConcept>(ezzzzzzzzzzzzzzzzzzzzzz_, fzzzzzzzzzzzzzzzzzzzzza_);
            bool? fzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Exists<CqlConcept>(fzzzzzzzzzzzzzzzzzzzzzb_);

            return fzzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Encounter>(dzzzzzzzzzzzzzzzzzzzzzg_, dzzzzzzzzzzzzzzzzzzzzzh_);
        bool? dzzzzzzzzzzzzzzzzzzzzzk_(Encounter E)
        {
            List<CodeableConcept> fzzzzzzzzzzzzzzzzzzzzzh_ = E?.Type;
            CqlConcept fzzzzzzzzzzzzzzzzzzzzzi_(CodeableConcept @this)
            {
                CqlConcept fzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return fzzzzzzzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<CqlConcept> fzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)fzzzzzzzzzzzzzzzzzzzzzh_, fzzzzzzzzzzzzzzzzzzzzzi_);
            bool? fzzzzzzzzzzzzzzzzzzzzzk_(CqlConcept T)
            {
                CqlCode fzzzzzzzzzzzzzzzzzzzzzo_ = this.Health_behavior_assessment__or_re_assessment__ie__health_focused_clinical_interview__behavioral_observations__clinical_decision_making_(context);
                CqlConcept fzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.ConvertCodeToConcept(fzzzzzzzzzzzzzzzzzzzzzo_);
                bool? fzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Equivalent(T, fzzzzzzzzzzzzzzzzzzzzzp_);

                return fzzzzzzzzzzzzzzzzzzzzzq_;
            };
            IEnumerable<CqlConcept> fzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<CqlConcept>(fzzzzzzzzzzzzzzzzzzzzzj_, fzzzzzzzzzzzzzzzzzzzzzk_);
            bool? fzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Exists<CqlConcept>(fzzzzzzzzzzzzzzzzzzzzzl_);

            return fzzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Encounter>(dzzzzzzzzzzzzzzzzzzzzzg_, dzzzzzzzzzzzzzzzzzzzzzk_);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Union<Encounter>(dzzzzzzzzzzzzzzzzzzzzzi_, dzzzzzzzzzzzzzzzzzzzzzl_);
        CqlValueSet dzzzzzzzzzzzzzzzzzzzzzn_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet dzzzzzzzzzzzzzzzzzzzzzp_ = this.Occupational_Therapy_Evaluation(context);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Union<Encounter>(dzzzzzzzzzzzzzzzzzzzzzo_, dzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Union<Encounter>(dzzzzzzzzzzzzzzzzzzzzzm_, dzzzzzzzzzzzzzzzzzzzzzr_);
        CqlValueSet dzzzzzzzzzzzzzzzzzzzzzt_ = this.Office_Visit(context);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet dzzzzzzzzzzzzzzzzzzzzzv_ = this.Ophthalmological_Services(context);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Union<Encounter>(dzzzzzzzzzzzzzzzzzzzzzu_, dzzzzzzzzzzzzzzzzzzzzzw_);
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<Encounter>(dzzzzzzzzzzzzzzzzzzzzzs_, dzzzzzzzzzzzzzzzzzzzzzx_);
        CqlValueSet dzzzzzzzzzzzzzzzzzzzzzz_ = this.Physical_Therapy_Evaluation(context);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet ezzzzzzzzzzzzzzzzzzzzzb_ = this.Psych_Visit_Diagnostic_Evaluation(context);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Union<Encounter>(ezzzzzzzzzzzzzzzzzzzzza_, ezzzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<Encounter>(dzzzzzzzzzzzzzzzzzzzzzy_, ezzzzzzzzzzzzzzzzzzzzzd_);
        CqlValueSet ezzzzzzzzzzzzzzzzzzzzzf_ = this.Psych_Visit_Psychotherapy(context);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet ezzzzzzzzzzzzzzzzzzzzzh_ = this.Psychoanalysis(context);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Union<Encounter>(ezzzzzzzzzzzzzzzzzzzzzg_, ezzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<Encounter>(ezzzzzzzzzzzzzzzzzzzzze_, ezzzzzzzzzzzzzzzzzzzzzj_);
        CqlValueSet ezzzzzzzzzzzzzzzzzzzzzl_ = this.Speech_and_Hearing_Evaluation(context);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet ezzzzzzzzzzzzzzzzzzzzzn_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<Encounter>(ezzzzzzzzzzzzzzzzzzzzzm_, ezzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<Encounter>(ezzzzzzzzzzzzzzzzzzzzzk_, ezzzzzzzzzzzzzzzzzzzzzp_);
        CqlValueSet ezzzzzzzzzzzzzzzzzzzzzr_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Union<Encounter>(ezzzzzzzzzzzzzzzzzzzzzq_, ezzzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzu_ = Status_1_8_000.Instance.isEncounterPerformed(context, ezzzzzzzzzzzzzzzzzzzzzt_);
        bool? ezzzzzzzzzzzzzzzzzzzzzv_(Encounter OfficeBasedEncounter)
        {
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzr_ = this.Measurement_Period(context);
            Period fzzzzzzzzzzzzzzzzzzzzzs_ = OfficeBasedEncounter?.Period;
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, fzzzzzzzzzzzzzzzzzzzzzt_ as object);
            bool? fzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(fzzzzzzzzzzzzzzzzzzzzzr_, fzzzzzzzzzzzzzzzzzzzzzu_, "day");

            return fzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Encounter>(ezzzzzzzzzzzzzzzzzzzzzu_, ezzzzzzzzzzzzzzzzzzzzzv_);

        return ezzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Preventive Visit During Measurement Period")]
    public IEnumerable<Encounter> Preventive_Visit_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet fzzzzzzzzzzzzzzzzzzzzzw_ = this.Annual_Wellness_Visit(context);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet fzzzzzzzzzzzzzzzzzzzzzy_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Union<Encounter>(fzzzzzzzzzzzzzzzzzzzzzx_, fzzzzzzzzzzzzzzzzzzzzzz_);
        CqlValueSet gzzzzzzzzzzzzzzzzzzzzzb_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet gzzzzzzzzzzzzzzzzzzzzzd_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Union<Encounter>(gzzzzzzzzzzzzzzzzzzzzzc_, gzzzzzzzzzzzzzzzzzzzzze_);
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Union<Encounter>(gzzzzzzzzzzzzzzzzzzzzza_, gzzzzzzzzzzzzzzzzzzzzzf_);
        CqlValueSet gzzzzzzzzzzzzzzzzzzzzzh_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet gzzzzzzzzzzzzzzzzzzzzzj_ = this.Preventive_Care_Services_Group_Counseling(context);
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Union<Encounter>(gzzzzzzzzzzzzzzzzzzzzzi_, gzzzzzzzzzzzzzzzzzzzzzk_);
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Union<Encounter>(gzzzzzzzzzzzzzzzzzzzzzg_, gzzzzzzzzzzzzzzzzzzzzzl_);
        CqlValueSet gzzzzzzzzzzzzzzzzzzzzzn_ = this.Preventive_Care_Services_Individual_Counseling(context);
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? gzzzzzzzzzzzzzzzzzzzzzq_(Encounter E)
        {
            List<CodeableConcept> hzzzzzzzzzzzzzzzzzzzzze_ = E?.Type;
            CqlConcept hzzzzzzzzzzzzzzzzzzzzzf_(CodeableConcept @this)
            {
                CqlConcept hzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return hzzzzzzzzzzzzzzzzzzzzzk_;
            };
            IEnumerable<CqlConcept> hzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)hzzzzzzzzzzzzzzzzzzzzze_, hzzzzzzzzzzzzzzzzzzzzzf_);
            bool? hzzzzzzzzzzzzzzzzzzzzzh_(CqlConcept T)
            {
                CqlCode hzzzzzzzzzzzzzzzzzzzzzl_ = this.Unlisted_preventive_medicine_service(context);
                CqlConcept hzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.ConvertCodeToConcept(hzzzzzzzzzzzzzzzzzzzzzl_);
                bool? hzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Equivalent(T, hzzzzzzzzzzzzzzzzzzzzzm_);

                return hzzzzzzzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<CqlConcept> hzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<CqlConcept>(hzzzzzzzzzzzzzzzzzzzzzg_, hzzzzzzzzzzzzzzzzzzzzzh_);
            bool? hzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Exists<CqlConcept>(hzzzzzzzzzzzzzzzzzzzzzi_);

            return hzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Encounter>(gzzzzzzzzzzzzzzzzzzzzzp_, gzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Union<Encounter>(gzzzzzzzzzzzzzzzzzzzzzo_, gzzzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Union<Encounter>(gzzzzzzzzzzzzzzzzzzzzzm_, gzzzzzzzzzzzzzzzzzzzzzs_);
        bool? gzzzzzzzzzzzzzzzzzzzzzv_(Encounter E)
        {
            List<CodeableConcept> hzzzzzzzzzzzzzzzzzzzzzo_ = E?.Type;
            CqlConcept hzzzzzzzzzzzzzzzzzzzzzp_(CodeableConcept @this)
            {
                CqlConcept hzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return hzzzzzzzzzzzzzzzzzzzzzu_;
            };
            IEnumerable<CqlConcept> hzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)hzzzzzzzzzzzzzzzzzzzzzo_, hzzzzzzzzzzzzzzzzzzzzzp_);
            bool? hzzzzzzzzzzzzzzzzzzzzzr_(CqlConcept T)
            {
                CqlCode hzzzzzzzzzzzzzzzzzzzzzv_ = this.Postoperative_follow_up_visit__normally_included_in_the_surgical_package__to_indicate_that_an_evaluation_and_management_service_was_performed_during_a_postoperative_period_for_a_reason_s__related_to_the_original_procedure(context);
                CqlConcept hzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.ConvertCodeToConcept(hzzzzzzzzzzzzzzzzzzzzzv_);
                bool? hzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Equivalent(T, hzzzzzzzzzzzzzzzzzzzzzw_);

                return hzzzzzzzzzzzzzzzzzzzzzx_;
            };
            IEnumerable<CqlConcept> hzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Where<CqlConcept>(hzzzzzzzzzzzzzzzzzzzzzq_, hzzzzzzzzzzzzzzzzzzzzzr_);
            bool? hzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Exists<CqlConcept>(hzzzzzzzzzzzzzzzzzzzzzs_);

            return hzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Encounter>(gzzzzzzzzzzzzzzzzzzzzzp_, gzzzzzzzzzzzzzzzzzzzzzv_);
        CqlValueSet gzzzzzzzzzzzzzzzzzzzzzx_ = this.Nutrition_Services(context);
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> gzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Union<Encounter>(gzzzzzzzzzzzzzzzzzzzzzw_, gzzzzzzzzzzzzzzzzzzzzzy_);
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Union<Encounter>(gzzzzzzzzzzzzzzzzzzzzzt_, gzzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzb_ = Status_1_8_000.Instance.isEncounterPerformed(context, hzzzzzzzzzzzzzzzzzzzzza_);
        bool? hzzzzzzzzzzzzzzzzzzzzzc_(Encounter PreventiveEncounter)
        {
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzy_ = this.Measurement_Period(context);
            Period hzzzzzzzzzzzzzzzzzzzzzz_ = PreventiveEncounter?.Period;
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, izzzzzzzzzzzzzzzzzzzzza_ as object);
            bool? izzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(hzzzzzzzzzzzzzzzzzzzzzy_, izzzzzzzzzzzzzzzzzzzzzb_, "day");

            return izzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Encounter>(hzzzzzzzzzzzzzzzzzzzzzb_, hzzzzzzzzzzzzzzzzzzzzzc_);

        return hzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient izzzzzzzzzzzzzzzzzzzzzd_ = this.Patient(context);
        Date izzzzzzzzzzzzzzzzzzzzze_ = izzzzzzzzzzzzzzzzzzzzzd_?.BirthDateElement;
        string izzzzzzzzzzzzzzzzzzzzzf_ = izzzzzzzzzzzzzzzzzzzzze_?.Value;
        CqlDate izzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.ConvertStringToDate(izzzzzzzzzzzzzzzzzzzzzf_);
        CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzh_ = this.Measurement_Period(context);
        CqlDateTime izzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Start(izzzzzzzzzzzzzzzzzzzzzh_);
        CqlDate izzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.DateFrom(izzzzzzzzzzzzzzzzzzzzzi_);
        int? izzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.CalculateAgeAt(izzzzzzzzzzzzzzzzzzzzzg_, izzzzzzzzzzzzzzzzzzzzzj_, "year");
        bool? izzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.GreaterOrEqual(izzzzzzzzzzzzzzzzzzzzzk_, 12);
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzm_ = this.Qualifying_Visit_During_Measurement_Period(context);
        int? izzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Count<Encounter>(izzzzzzzzzzzzzzzzzzzzzm_);
        bool? izzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.GreaterOrEqual(izzzzzzzzzzzzzzzzzzzzzn_, 2);
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzp_ = this.Preventive_Visit_During_Measurement_Period(context);
        bool? izzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Exists<Encounter>(izzzzzzzzzzzzzzzzzzzzzp_);
        bool? izzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Or(izzzzzzzzzzzzzzzzzzzzzo_, izzzzzzzzzzzzzzzzzzzzzq_);
        bool? izzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzl_, izzzzzzzzzzzzzzzzzzzzzr_);

        return izzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Denominator 1")]
    public bool? Denominator_1(CqlContext context)
    {
        bool? izzzzzzzzzzzzzzzzzzzzzt_ = this.Initial_Population(context);

        return izzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Most Recent Tobacco Use Screening Indicates Tobacco User")]
    public Observation Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_User(CqlContext context)
    {
        CqlValueSet izzzzzzzzzzzzzzzzzzzzzu_ = this.Tobacco_Use_Screening(context);
        IEnumerable<Observation> izzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, izzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> izzzzzzzzzzzzzzzzzzzzzw_ = Status_1_8_000.Instance.isAssessmentPerformed(context, izzzzzzzzzzzzzzzzzzzzzv_);
        bool? izzzzzzzzzzzzzzzzzzzzzx_(Observation TobaccoUseScreening)
        {
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzg_ = this.Measurement_Period(context);
            DataType jzzzzzzzzzzzzzzzzzzzzzh_ = TobaccoUseScreening?.Effective;
            object jzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.toInterval(context, jzzzzzzzzzzzzzzzzzzzzzi_);
            bool? jzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(jzzzzzzzzzzzzzzzzzzzzzg_, jzzzzzzzzzzzzzzzzzzzzzj_, "day");

            return jzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Observation> izzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Observation>(izzzzzzzzzzzzzzzzzzzzzw_, izzzzzzzzzzzzzzzzzzzzzx_);
        object izzzzzzzzzzzzzzzzzzzzzz_(Observation @this)
        {
            DataType jzzzzzzzzzzzzzzzzzzzzzl_ = @this?.Effective;
            object jzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.toInterval(context, jzzzzzzzzzzzzzzzzzzzzzm_);
            CqlDateTime jzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Start(jzzzzzzzzzzzzzzzzzzzzzn_);

            return jzzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.SortBy<Observation>(izzzzzzzzzzzzzzzzzzzzzy_, izzzzzzzzzzzzzzzzzzzzzz_, System.ComponentModel.ListSortDirection.Ascending);
        Observation jzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Last<Observation>(jzzzzzzzzzzzzzzzzzzzzza_);
        Observation[] jzzzzzzzzzzzzzzzzzzzzzc_ = [
            jzzzzzzzzzzzzzzzzzzzzzb_,
        ];
        bool? jzzzzzzzzzzzzzzzzzzzzzd_(Observation MostRecentTobaccoUseScreening)
        {
            DataType jzzzzzzzzzzzzzzzzzzzzzp_ = MostRecentTobaccoUseScreening?.Value;
            object jzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzp_);
            CqlValueSet jzzzzzzzzzzzzzzzzzzzzzr_ = this.Tobacco_User(context);
            bool? jzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ConceptInValueSet(jzzzzzzzzzzzzzzzzzzzzzq_ as CqlConcept, jzzzzzzzzzzzzzzzzzzzzzr_);

            return jzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Observation>((IEnumerable<Observation>)jzzzzzzzzzzzzzzzzzzzzzc_, jzzzzzzzzzzzzzzzzzzzzzd_);
        Observation jzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.SingletonFrom<Observation>(jzzzzzzzzzzzzzzzzzzzzze_);

        return jzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Denominator 2")]
    public bool? Denominator_2(CqlContext context)
    {
        bool? jzzzzzzzzzzzzzzzzzzzzzt_ = this.Initial_Population(context);
        Observation jzzzzzzzzzzzzzzzzzzzzzu_ = this.Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_User(context);
        bool? jzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Not((bool?)(jzzzzzzzzzzzzzzzzzzzzzu_ is null));
        bool? jzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzzt_, jzzzzzzzzzzzzzzzzzzzzzv_);

        return jzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Denominator 3")]
    public bool? Denominator_3(CqlContext context)
    {
        bool? jzzzzzzzzzzzzzzzzzzzzzx_ = this.Initial_Population(context);

        return jzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Most Recent Tobacco Use Screening Indicates Tobacco Non User")]
    public Observation Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_Non_User(CqlContext context)
    {
        CqlValueSet jzzzzzzzzzzzzzzzzzzzzzy_ = this.Tobacco_Use_Screening(context);
        IEnumerable<Observation> jzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, jzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> kzzzzzzzzzzzzzzzzzzzzza_ = Status_1_8_000.Instance.isAssessmentPerformed(context, jzzzzzzzzzzzzzzzzzzzzzz_);
        bool? kzzzzzzzzzzzzzzzzzzzzzb_(Observation TobaccoUseScreening)
        {
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzk_ = this.Measurement_Period(context);
            DataType kzzzzzzzzzzzzzzzzzzzzzl_ = TobaccoUseScreening?.Effective;
            object kzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzzzzzzzzzzm_);
            bool? kzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(kzzzzzzzzzzzzzzzzzzzzzk_, kzzzzzzzzzzzzzzzzzzzzzn_, "day");

            return kzzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<Observation> kzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Where<Observation>(kzzzzzzzzzzzzzzzzzzzzza_, kzzzzzzzzzzzzzzzzzzzzzb_);
        object kzzzzzzzzzzzzzzzzzzzzzd_(Observation @this)
        {
            DataType kzzzzzzzzzzzzzzzzzzzzzp_ = @this?.Effective;
            object kzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzzzzzzzzzzq_);
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzzzr_);

            return kzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Observation> kzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.SortBy<Observation>(kzzzzzzzzzzzzzzzzzzzzzc_, kzzzzzzzzzzzzzzzzzzzzzd_, System.ComponentModel.ListSortDirection.Ascending);
        Observation kzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Last<Observation>(kzzzzzzzzzzzzzzzzzzzzze_);
        Observation[] kzzzzzzzzzzzzzzzzzzzzzg_ = [
            kzzzzzzzzzzzzzzzzzzzzzf_,
        ];
        bool? kzzzzzzzzzzzzzzzzzzzzzh_(Observation MostRecentTobaccoUseScreening)
        {
            DataType kzzzzzzzzzzzzzzzzzzzzzt_ = MostRecentTobaccoUseScreening?.Value;
            object kzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzt_);
            CqlValueSet kzzzzzzzzzzzzzzzzzzzzzv_ = this.Tobacco_Non_User(context);
            bool? kzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.ConceptInValueSet(kzzzzzzzzzzzzzzzzzzzzzu_ as CqlConcept, kzzzzzzzzzzzzzzzzzzzzzv_);

            return kzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<Observation> kzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Observation>((IEnumerable<Observation>)kzzzzzzzzzzzzzzzzzzzzzg_, kzzzzzzzzzzzzzzzzzzzzzh_);
        Observation kzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.SingletonFrom<Observation>(kzzzzzzzzzzzzzzzzzzzzzi_);

        return kzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Numerator 1")]
    public bool? Numerator_1(CqlContext context)
    {
        Observation kzzzzzzzzzzzzzzzzzzzzzx_ = this.Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_Non_User(context);
        bool? kzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Not((bool?)(kzzzzzzzzzzzzzzzzzzzzzx_ is null));
        Observation kzzzzzzzzzzzzzzzzzzzzzz_ = this.Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_User(context);
        bool? lzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Not((bool?)(kzzzzzzzzzzzzzzzzzzzzzz_ is null));
        bool? lzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Or(kzzzzzzzzzzzzzzzzzzzzzy_, lzzzzzzzzzzzzzzzzzzzzza_);

        return lzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Tobacco Cessation Counseling Given")]
    public IEnumerable<object> Tobacco_Cessation_Counseling_Given(CqlContext context)
    {
        CqlValueSet lzzzzzzzzzzzzzzzzzzzzzc_ = this.Tobacco_Use_Cessation_Counseling(context);
        IEnumerable<Procedure> lzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> lzzzzzzzzzzzzzzzzzzzzze_ = Status_1_8_000.Instance.isInterventionPerformed(context, lzzzzzzzzzzzzzzzzzzzzzd_);
        bool? lzzzzzzzzzzzzzzzzzzzzzf_(Procedure TobaccoCessationCounseling)
        {
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzn_ = this.Measurement_Period(context);
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzzzzzn_);
            CqlQuantity lzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Quantity(6m, "months");
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Subtract(lzzzzzzzzzzzzzzzzzzzzzo_, lzzzzzzzzzzzzzzzzzzzzzp_);
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.End(lzzzzzzzzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Interval(lzzzzzzzzzzzzzzzzzzzzzq_, lzzzzzzzzzzzzzzzzzzzzzs_, true, true);
            DataType lzzzzzzzzzzzzzzzzzzzzzu_ = TobaccoCessationCounseling?.Performed;
            object lzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.toInterval(context, lzzzzzzzzzzzzzzzzzzzzzv_);
            bool? lzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(lzzzzzzzzzzzzzzzzzzzzzt_, lzzzzzzzzzzzzzzzzzzzzzw_, "day");

            return lzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Procedure> lzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Procedure>(lzzzzzzzzzzzzzzzzzzzzze_, lzzzzzzzzzzzzzzzzzzzzzf_);
        CqlCode lzzzzzzzzzzzzzzzzzzzzzh_ = this.Tobacco_abuse_counseling(context);
        IEnumerable<CqlCode> lzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.ToList<CqlCode>(lzzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<Condition> lzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, lzzzzzzzzzzzzzzzzzzzzzi_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? lzzzzzzzzzzzzzzzzzzzzzk_(Condition TobaccoCounseling)
        {
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, TobaccoCounseling);
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzzzzzy_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzza_ = this.Measurement_Period(context);
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzza_);
            CqlQuantity mzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Quantity(6m, "months");
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Subtract(mzzzzzzzzzzzzzzzzzzzzzb_, mzzzzzzzzzzzzzzzzzzzzzc_);
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.End(mzzzzzzzzzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Interval(mzzzzzzzzzzzzzzzzzzzzzd_, mzzzzzzzzzzzzzzzzzzzzzf_, true, true);
            bool? mzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.In<CqlDateTime>(lzzzzzzzzzzzzzzzzzzzzzz_, mzzzzzzzzzzzzzzzzzzzzzg_, "day");

            return mzzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Condition> lzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Condition>(lzzzzzzzzzzzzzzzzzzzzzj_, lzzzzzzzzzzzzzzzzzzzzzk_);
        IEnumerable<object> lzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Union<object>(lzzzzzzzzzzzzzzzzzzzzzg_ as IEnumerable<object>, lzzzzzzzzzzzzzzzzzzzzzl_ as IEnumerable<object>);

        return lzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Tobacco Cessation Pharmacotherapy Ordered")]
    public IEnumerable<MedicationRequest> Tobacco_Cessation_Pharmacotherapy_Ordered(CqlContext context)
    {
        CqlValueSet mzzzzzzzzzzzzzzzzzzzzzi_ = this.Tobacco_Use_Cessation_Pharmacotherapy(context);
        IEnumerable<MedicationRequest> mzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> mzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, mzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> mzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Union<MedicationRequest>(mzzzzzzzzzzzzzzzzzzzzzj_, mzzzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<MedicationRequest> mzzzzzzzzzzzzzzzzzzzzzn_ = Status_1_8_000.Instance.isMedicationOrder(context, mzzzzzzzzzzzzzzzzzzzzzm_);
        bool? mzzzzzzzzzzzzzzzzzzzzzo_(MedicationRequest CessationPharmacotherapyOrdered)
        {
            FhirDateTime mzzzzzzzzzzzzzzzzzzzzzq_ = CessationPharmacotherapyOrdered?.AuthoredOnElement;
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Convert<CqlDateTime>(mzzzzzzzzzzzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzs_ = this.Measurement_Period(context);
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzs_);
            CqlQuantity mzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Quantity(6m, "months");
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Subtract(mzzzzzzzzzzzzzzzzzzzzzt_, mzzzzzzzzzzzzzzzzzzzzzu_);
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.End(mzzzzzzzzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Interval(mzzzzzzzzzzzzzzzzzzzzzv_, mzzzzzzzzzzzzzzzzzzzzzx_, true, true);
            bool? mzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<CqlDateTime>(mzzzzzzzzzzzzzzzzzzzzzr_, mzzzzzzzzzzzzzzzzzzzzzy_, "day");

            return mzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<MedicationRequest> mzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<MedicationRequest>(mzzzzzzzzzzzzzzzzzzzzzn_, mzzzzzzzzzzzzzzzzzzzzzo_);

        return mzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Active Pharmacotherapy for Tobacco Cessation")]
    public IEnumerable<MedicationRequest> Active_Pharmacotherapy_for_Tobacco_Cessation(CqlContext context)
    {
        CqlValueSet nzzzzzzzzzzzzzzzzzzzzza_ = this.Tobacco_Use_Cessation_Pharmacotherapy(context);
        IEnumerable<MedicationRequest> nzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> nzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> nzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<MedicationRequest>(nzzzzzzzzzzzzzzzzzzzzzb_, nzzzzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<MedicationRequest> nzzzzzzzzzzzzzzzzzzzzzf_ = Status_1_8_000.Instance.isMedicationActive(context, nzzzzzzzzzzzzzzzzzzzzze_);
        bool? nzzzzzzzzzzzzzzzzzzzzzg_(MedicationRequest TakingCessationPharmacotherapy)
        {
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzi_ = this.Measurement_Period(context);
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzzzzi_);
            CqlQuantity nzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Quantity(6m, "months");
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Subtract(nzzzzzzzzzzzzzzzzzzzzzj_, nzzzzzzzzzzzzzzzzzzzzzk_);
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.End(nzzzzzzzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Interval(nzzzzzzzzzzzzzzzzzzzzzl_, nzzzzzzzzzzzzzzzzzzzzzn_, true, true);
            CqlInterval<CqlDate> nzzzzzzzzzzzzzzzzzzzzzp_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, TakingCessationPharmacotherapy);
            CqlDate nzzzzzzzzzzzzzzzzzzzzzq_ = nzzzzzzzzzzzzzzzzzzzzzp_?.low;
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ConvertDateToDateTime(nzzzzzzzzzzzzzzzzzzzzzq_);
            CqlDate nzzzzzzzzzzzzzzzzzzzzzt_ = nzzzzzzzzzzzzzzzzzzzzzp_?.high;
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.ConvertDateToDateTime(nzzzzzzzzzzzzzzzzzzzzzt_);
            bool? nzzzzzzzzzzzzzzzzzzzzzw_ = nzzzzzzzzzzzzzzzzzzzzzp_?.lowClosed;
            bool? nzzzzzzzzzzzzzzzzzzzzzy_ = nzzzzzzzzzzzzzzzzzzzzzp_?.highClosed;
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Interval(nzzzzzzzzzzzzzzzzzzzzzr_, nzzzzzzzzzzzzzzzzzzzzzu_, nzzzzzzzzzzzzzzzzzzzzzw_, nzzzzzzzzzzzzzzzzzzzzzy_);
            bool? ozzzzzzzzzzzzzzzzzzzzza_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(nzzzzzzzzzzzzzzzzzzzzzo_, nzzzzzzzzzzzzzzzzzzzzzz_, "day");

            return ozzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<MedicationRequest> nzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<MedicationRequest>(nzzzzzzzzzzzzzzzzzzzzzf_, nzzzzzzzzzzzzzzzzzzzzzg_);

        return nzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Numerator 2")]
    public bool? Numerator_2(CqlContext context)
    {
        IEnumerable<object> ozzzzzzzzzzzzzzzzzzzzzb_ = this.Tobacco_Cessation_Counseling_Given(context);
        bool? ozzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Exists<object>(ozzzzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<MedicationRequest> ozzzzzzzzzzzzzzzzzzzzzd_ = this.Tobacco_Cessation_Pharmacotherapy_Ordered(context);
        bool? ozzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Exists<MedicationRequest>(ozzzzzzzzzzzzzzzzzzzzzd_);
        bool? ozzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Or(ozzzzzzzzzzzzzzzzzzzzzc_, ozzzzzzzzzzzzzzzzzzzzze_);
        IEnumerable<MedicationRequest> ozzzzzzzzzzzzzzzzzzzzzg_ = this.Active_Pharmacotherapy_for_Tobacco_Cessation(context);
        bool? ozzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Exists<MedicationRequest>(ozzzzzzzzzzzzzzzzzzzzzg_);
        bool? ozzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Or(ozzzzzzzzzzzzzzzzzzzzzf_, ozzzzzzzzzzzzzzzzzzzzzh_);

        return ozzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Numerator 3")]
    public bool? Numerator_3(CqlContext context)
    {
        Observation ozzzzzzzzzzzzzzzzzzzzzj_ = this.Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_Non_User(context);
        bool? ozzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Not((bool?)(ozzzzzzzzzzzzzzzzzzzzzj_ is null));
        Observation ozzzzzzzzzzzzzzzzzzzzzl_ = this.Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_User(context);
        bool? ozzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Not((bool?)(ozzzzzzzzzzzzzzzzzzzzzl_ is null));
        IEnumerable<object> ozzzzzzzzzzzzzzzzzzzzzn_ = this.Tobacco_Cessation_Counseling_Given(context);
        bool? ozzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Exists<object>(ozzzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<MedicationRequest> ozzzzzzzzzzzzzzzzzzzzzp_ = this.Tobacco_Cessation_Pharmacotherapy_Ordered(context);
        bool? ozzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Exists<MedicationRequest>(ozzzzzzzzzzzzzzzzzzzzzp_);
        bool? ozzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Or(ozzzzzzzzzzzzzzzzzzzzzo_, ozzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<MedicationRequest> ozzzzzzzzzzzzzzzzzzzzzs_ = this.Active_Pharmacotherapy_for_Tobacco_Cessation(context);
        bool? ozzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Exists<MedicationRequest>(ozzzzzzzzzzzzzzzzzzzzzs_);
        bool? ozzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Or(ozzzzzzzzzzzzzzzzzzzzzr_, ozzzzzzzzzzzzzzzzzzzzzt_);
        bool? ozzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzm_, ozzzzzzzzzzzzzzzzzzzzzu_);
        bool? ozzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Or(ozzzzzzzzzzzzzzzzzzzzzk_, ozzzzzzzzzzzzzzzzzzzzzv_);

        return ozzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Denominator Exclusion")]
    public bool? Denominator_Exclusion(CqlContext context)
    {
        bool? ozzzzzzzzzzzzzzzzzzzzzx_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);

        return ozzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? ozzzzzzzzzzzzzzzzzzzzzy_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return ozzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> ozzzzzzzzzzzzzzzzzzzzzz_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return ozzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? pzzzzzzzzzzzzzzzzzzzzza_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return pzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode pzzzzzzzzzzzzzzzzzzzzzb_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return pzzzzzzzzzzzzzzzzzzzzzb_;
    }


    #endregion Expressions

}
