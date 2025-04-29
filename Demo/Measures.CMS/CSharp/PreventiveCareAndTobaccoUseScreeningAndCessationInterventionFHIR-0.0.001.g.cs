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
        CqlDateTime czzzzzo_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime czzzzzp_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> czzzzzq_ = context.Operators.Interval(czzzzzo_, czzzzzp_, true, true);
        object czzzzzr_ = context.ResolveParameter("PreventiveCareAndTobaccoUseScreeningAndCessationInterventionFHIR-0.0.001", "Measurement Period", czzzzzq_);

        return (CqlInterval<CqlDateTime>)czzzzzr_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> czzzzzs_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient czzzzzt_ = context.Operators.SingletonFrom<Patient>(czzzzzs_);

        return czzzzzt_;
    }


    [CqlExpressionDefinition("Qualifying Visit During Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Visit_During_Measurement_Period(CqlContext context)
    {
        IEnumerable<Encounter> czzzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? czzzzzv_(Encounter E)
        {
            List<CodeableConcept> ezzzzzl_ = E?.Type;
            CqlConcept ezzzzzm_(CodeableConcept @this)
            {
                CqlConcept ezzzzzr_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return ezzzzzr_;
            };
            IEnumerable<CqlConcept> ezzzzzn_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)ezzzzzl_, ezzzzzm_);
            bool? ezzzzzo_(CqlConcept T)
            {
                CqlCode ezzzzzs_ = this.Health_behavior_intervention__individual__face_to_face__initial_30_minutes(context);
                CqlConcept ezzzzzt_ = context.Operators.ConvertCodeToConcept(ezzzzzs_);
                bool? ezzzzzu_ = context.Operators.Equivalent(T, ezzzzzt_);

                return ezzzzzu_;
            };
            IEnumerable<CqlConcept> ezzzzzp_ = context.Operators.Where<CqlConcept>(ezzzzzn_, ezzzzzo_);
            bool? ezzzzzq_ = context.Operators.Exists<CqlConcept>(ezzzzzp_);

            return ezzzzzq_;
        };
        IEnumerable<Encounter> czzzzzw_ = context.Operators.Where<Encounter>(czzzzzu_, czzzzzv_);
        bool? czzzzzy_(Encounter E)
        {
            List<CodeableConcept> ezzzzzv_ = E?.Type;
            CqlConcept ezzzzzw_(CodeableConcept @this)
            {
                CqlConcept fzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return fzzzzzb_;
            };
            IEnumerable<CqlConcept> ezzzzzx_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)ezzzzzv_, ezzzzzw_);
            bool? ezzzzzy_(CqlConcept T)
            {
                CqlCode fzzzzzc_ = this.Health_behavior_assessment__or_re_assessment__ie__health_focused_clinical_interview__behavioral_observations__clinical_decision_making_(context);
                CqlConcept fzzzzzd_ = context.Operators.ConvertCodeToConcept(fzzzzzc_);
                bool? fzzzzze_ = context.Operators.Equivalent(T, fzzzzzd_);

                return fzzzzze_;
            };
            IEnumerable<CqlConcept> ezzzzzz_ = context.Operators.Where<CqlConcept>(ezzzzzx_, ezzzzzy_);
            bool? fzzzzza_ = context.Operators.Exists<CqlConcept>(ezzzzzz_);

            return fzzzzza_;
        };
        IEnumerable<Encounter> czzzzzz_ = context.Operators.Where<Encounter>(czzzzzu_, czzzzzy_);
        IEnumerable<Encounter> dzzzzza_ = context.Operators.Union<Encounter>(czzzzzw_, czzzzzz_);
        CqlValueSet dzzzzzb_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> dzzzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet dzzzzzd_ = this.Occupational_Therapy_Evaluation(context);
        IEnumerable<Encounter> dzzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> dzzzzzf_ = context.Operators.Union<Encounter>(dzzzzzc_, dzzzzze_);
        IEnumerable<Encounter> dzzzzzg_ = context.Operators.Union<Encounter>(dzzzzza_, dzzzzzf_);
        CqlValueSet dzzzzzh_ = this.Office_Visit(context);
        IEnumerable<Encounter> dzzzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet dzzzzzj_ = this.Ophthalmological_Services(context);
        IEnumerable<Encounter> dzzzzzk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> dzzzzzl_ = context.Operators.Union<Encounter>(dzzzzzi_, dzzzzzk_);
        IEnumerable<Encounter> dzzzzzm_ = context.Operators.Union<Encounter>(dzzzzzg_, dzzzzzl_);
        CqlValueSet dzzzzzn_ = this.Physical_Therapy_Evaluation(context);
        IEnumerable<Encounter> dzzzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet dzzzzzp_ = this.Psych_Visit_Diagnostic_Evaluation(context);
        IEnumerable<Encounter> dzzzzzq_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> dzzzzzr_ = context.Operators.Union<Encounter>(dzzzzzo_, dzzzzzq_);
        IEnumerable<Encounter> dzzzzzs_ = context.Operators.Union<Encounter>(dzzzzzm_, dzzzzzr_);
        CqlValueSet dzzzzzt_ = this.Psych_Visit_Psychotherapy(context);
        IEnumerable<Encounter> dzzzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet dzzzzzv_ = this.Psychoanalysis(context);
        IEnumerable<Encounter> dzzzzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> dzzzzzx_ = context.Operators.Union<Encounter>(dzzzzzu_, dzzzzzw_);
        IEnumerable<Encounter> dzzzzzy_ = context.Operators.Union<Encounter>(dzzzzzs_, dzzzzzx_);
        CqlValueSet dzzzzzz_ = this.Speech_and_Hearing_Evaluation(context);
        IEnumerable<Encounter> ezzzzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet ezzzzzb_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> ezzzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ezzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> ezzzzzd_ = context.Operators.Union<Encounter>(ezzzzza_, ezzzzzc_);
        IEnumerable<Encounter> ezzzzze_ = context.Operators.Union<Encounter>(dzzzzzy_, ezzzzzd_);
        CqlValueSet ezzzzzf_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> ezzzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ezzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> ezzzzzh_ = context.Operators.Union<Encounter>(ezzzzze_, ezzzzzg_);
        IEnumerable<Encounter> ezzzzzi_ = Status_1_8_000.Instance.isEncounterPerformed(context, ezzzzzh_);
        bool? ezzzzzj_(Encounter OfficeBasedEncounter)
        {
            CqlInterval<CqlDateTime> fzzzzzf_ = this.Measurement_Period(context);
            Period fzzzzzg_ = OfficeBasedEncounter?.Period;
            CqlInterval<CqlDateTime> fzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzg_);
            CqlInterval<CqlDateTime> fzzzzzi_ = QICoreCommon_2_1_000.Instance.toInterval(context, fzzzzzh_ as object);
            bool? fzzzzzj_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(fzzzzzf_, fzzzzzi_, "day");

            return fzzzzzj_;
        };
        IEnumerable<Encounter> ezzzzzk_ = context.Operators.Where<Encounter>(ezzzzzi_, ezzzzzj_);

        return ezzzzzk_;
    }


    [CqlExpressionDefinition("Preventive Visit During Measurement Period")]
    public IEnumerable<Encounter> Preventive_Visit_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet fzzzzzk_ = this.Annual_Wellness_Visit(context);
        IEnumerable<Encounter> fzzzzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet fzzzzzm_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> fzzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> fzzzzzo_ = context.Operators.Union<Encounter>(fzzzzzl_, fzzzzzn_);
        CqlValueSet fzzzzzp_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> fzzzzzq_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet fzzzzzr_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> fzzzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> fzzzzzt_ = context.Operators.Union<Encounter>(fzzzzzq_, fzzzzzs_);
        IEnumerable<Encounter> fzzzzzu_ = context.Operators.Union<Encounter>(fzzzzzo_, fzzzzzt_);
        CqlValueSet fzzzzzv_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> fzzzzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet fzzzzzx_ = this.Preventive_Care_Services_Group_Counseling(context);
        IEnumerable<Encounter> fzzzzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> fzzzzzz_ = context.Operators.Union<Encounter>(fzzzzzw_, fzzzzzy_);
        IEnumerable<Encounter> gzzzzza_ = context.Operators.Union<Encounter>(fzzzzzu_, fzzzzzz_);
        CqlValueSet gzzzzzb_ = this.Preventive_Care_Services_Individual_Counseling(context);
        IEnumerable<Encounter> gzzzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, gzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> gzzzzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? gzzzzze_(Encounter E)
        {
            List<CodeableConcept> gzzzzzs_ = E?.Type;
            CqlConcept gzzzzzt_(CodeableConcept @this)
            {
                CqlConcept gzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return gzzzzzy_;
            };
            IEnumerable<CqlConcept> gzzzzzu_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)gzzzzzs_, gzzzzzt_);
            bool? gzzzzzv_(CqlConcept T)
            {
                CqlCode gzzzzzz_ = this.Unlisted_preventive_medicine_service(context);
                CqlConcept hzzzzza_ = context.Operators.ConvertCodeToConcept(gzzzzzz_);
                bool? hzzzzzb_ = context.Operators.Equivalent(T, hzzzzza_);

                return hzzzzzb_;
            };
            IEnumerable<CqlConcept> gzzzzzw_ = context.Operators.Where<CqlConcept>(gzzzzzu_, gzzzzzv_);
            bool? gzzzzzx_ = context.Operators.Exists<CqlConcept>(gzzzzzw_);

            return gzzzzzx_;
        };
        IEnumerable<Encounter> gzzzzzf_ = context.Operators.Where<Encounter>(gzzzzzd_, gzzzzze_);
        IEnumerable<Encounter> gzzzzzg_ = context.Operators.Union<Encounter>(gzzzzzc_, gzzzzzf_);
        IEnumerable<Encounter> gzzzzzh_ = context.Operators.Union<Encounter>(gzzzzza_, gzzzzzg_);
        bool? gzzzzzj_(Encounter E)
        {
            List<CodeableConcept> hzzzzzc_ = E?.Type;
            CqlConcept hzzzzzd_(CodeableConcept @this)
            {
                CqlConcept hzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return hzzzzzi_;
            };
            IEnumerable<CqlConcept> hzzzzze_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)hzzzzzc_, hzzzzzd_);
            bool? hzzzzzf_(CqlConcept T)
            {
                CqlCode hzzzzzj_ = this.Postoperative_follow_up_visit__normally_included_in_the_surgical_package__to_indicate_that_an_evaluation_and_management_service_was_performed_during_a_postoperative_period_for_a_reason_s__related_to_the_original_procedure(context);
                CqlConcept hzzzzzk_ = context.Operators.ConvertCodeToConcept(hzzzzzj_);
                bool? hzzzzzl_ = context.Operators.Equivalent(T, hzzzzzk_);

                return hzzzzzl_;
            };
            IEnumerable<CqlConcept> hzzzzzg_ = context.Operators.Where<CqlConcept>(hzzzzze_, hzzzzzf_);
            bool? hzzzzzh_ = context.Operators.Exists<CqlConcept>(hzzzzzg_);

            return hzzzzzh_;
        };
        IEnumerable<Encounter> gzzzzzk_ = context.Operators.Where<Encounter>(gzzzzzd_, gzzzzzj_);
        CqlValueSet gzzzzzl_ = this.Nutrition_Services(context);
        IEnumerable<Encounter> gzzzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, gzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> gzzzzzn_ = context.Operators.Union<Encounter>(gzzzzzk_, gzzzzzm_);
        IEnumerable<Encounter> gzzzzzo_ = context.Operators.Union<Encounter>(gzzzzzh_, gzzzzzn_);
        IEnumerable<Encounter> gzzzzzp_ = Status_1_8_000.Instance.isEncounterPerformed(context, gzzzzzo_);
        bool? gzzzzzq_(Encounter PreventiveEncounter)
        {
            CqlInterval<CqlDateTime> hzzzzzm_ = this.Measurement_Period(context);
            Period hzzzzzn_ = PreventiveEncounter?.Period;
            CqlInterval<CqlDateTime> hzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzn_);
            CqlInterval<CqlDateTime> hzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, hzzzzzo_ as object);
            bool? hzzzzzq_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(hzzzzzm_, hzzzzzp_, "day");

            return hzzzzzq_;
        };
        IEnumerable<Encounter> gzzzzzr_ = context.Operators.Where<Encounter>(gzzzzzp_, gzzzzzq_);

        return gzzzzzr_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient hzzzzzr_ = this.Patient(context);
        Date hzzzzzs_ = hzzzzzr_?.BirthDateElement;
        string hzzzzzt_ = hzzzzzs_?.Value;
        CqlDate hzzzzzu_ = context.Operators.ConvertStringToDate(hzzzzzt_);
        CqlInterval<CqlDateTime> hzzzzzv_ = this.Measurement_Period(context);
        CqlDateTime hzzzzzw_ = context.Operators.Start(hzzzzzv_);
        CqlDate hzzzzzx_ = context.Operators.DateFrom(hzzzzzw_);
        int? hzzzzzy_ = context.Operators.CalculateAgeAt(hzzzzzu_, hzzzzzx_, "year");
        bool? hzzzzzz_ = context.Operators.GreaterOrEqual(hzzzzzy_, 12);
        IEnumerable<Encounter> izzzzza_ = this.Qualifying_Visit_During_Measurement_Period(context);
        int? izzzzzb_ = context.Operators.Count<Encounter>(izzzzza_);
        bool? izzzzzc_ = context.Operators.GreaterOrEqual(izzzzzb_, 2);
        IEnumerable<Encounter> izzzzzd_ = this.Preventive_Visit_During_Measurement_Period(context);
        bool? izzzzze_ = context.Operators.Exists<Encounter>(izzzzzd_);
        bool? izzzzzf_ = context.Operators.Or(izzzzzc_, izzzzze_);
        bool? izzzzzg_ = context.Operators.And(hzzzzzz_, izzzzzf_);

        return izzzzzg_;
    }


    [CqlExpressionDefinition("Denominator 1")]
    public bool? Denominator_1(CqlContext context)
    {
        bool? izzzzzh_ = this.Initial_Population(context);

        return izzzzzh_;
    }


    [CqlExpressionDefinition("Most Recent Tobacco Use Screening Indicates Tobacco User")]
    public Observation Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_User(CqlContext context)
    {
        CqlValueSet izzzzzi_ = this.Tobacco_Use_Screening(context);
        IEnumerable<Observation> izzzzzj_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, izzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> izzzzzk_ = Status_1_8_000.Instance.isAssessmentPerformed(context, izzzzzj_);
        bool? izzzzzl_(Observation TobaccoUseScreening)
        {
            CqlInterval<CqlDateTime> izzzzzu_ = this.Measurement_Period(context);
            DataType izzzzzv_ = TobaccoUseScreening?.Effective;
            object izzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzv_);
            CqlInterval<CqlDateTime> izzzzzx_ = QICoreCommon_2_1_000.Instance.toInterval(context, izzzzzw_);
            bool? izzzzzy_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(izzzzzu_, izzzzzx_, "day");

            return izzzzzy_;
        };
        IEnumerable<Observation> izzzzzm_ = context.Operators.Where<Observation>(izzzzzk_, izzzzzl_);
        object izzzzzn_(Observation @this)
        {
            DataType izzzzzz_ = @this?.Effective;
            object jzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzz_);
            CqlInterval<CqlDateTime> jzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, jzzzzza_);
            CqlDateTime jzzzzzc_ = context.Operators.Start(jzzzzzb_);

            return jzzzzzc_;
        };
        IEnumerable<Observation> izzzzzo_ = context.Operators.SortBy<Observation>(izzzzzm_, izzzzzn_, System.ComponentModel.ListSortDirection.Ascending);
        Observation izzzzzp_ = context.Operators.Last<Observation>(izzzzzo_);
        Observation[] izzzzzq_ = [
            izzzzzp_,
        ];
        bool? izzzzzr_(Observation MostRecentTobaccoUseScreening)
        {
            DataType jzzzzzd_ = MostRecentTobaccoUseScreening?.Value;
            object jzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzd_);
            CqlValueSet jzzzzzf_ = this.Tobacco_User(context);
            bool? jzzzzzg_ = context.Operators.ConceptInValueSet(jzzzzze_ as CqlConcept, jzzzzzf_);

            return jzzzzzg_;
        };
        IEnumerable<Observation> izzzzzs_ = context.Operators.Where<Observation>((IEnumerable<Observation>)izzzzzq_, izzzzzr_);
        Observation izzzzzt_ = context.Operators.SingletonFrom<Observation>(izzzzzs_);

        return izzzzzt_;
    }


    [CqlExpressionDefinition("Denominator 2")]
    public bool? Denominator_2(CqlContext context)
    {
        bool? jzzzzzh_ = this.Initial_Population(context);
        Observation jzzzzzi_ = this.Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_User(context);
        bool? jzzzzzj_ = context.Operators.Not((bool?)(jzzzzzi_ is null));
        bool? jzzzzzk_ = context.Operators.And(jzzzzzh_, jzzzzzj_);

        return jzzzzzk_;
    }


    [CqlExpressionDefinition("Denominator 3")]
    public bool? Denominator_3(CqlContext context)
    {
        bool? jzzzzzl_ = this.Initial_Population(context);

        return jzzzzzl_;
    }


    [CqlExpressionDefinition("Most Recent Tobacco Use Screening Indicates Tobacco Non User")]
    public Observation Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_Non_User(CqlContext context)
    {
        CqlValueSet jzzzzzm_ = this.Tobacco_Use_Screening(context);
        IEnumerable<Observation> jzzzzzn_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, jzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> jzzzzzo_ = Status_1_8_000.Instance.isAssessmentPerformed(context, jzzzzzn_);
        bool? jzzzzzp_(Observation TobaccoUseScreening)
        {
            CqlInterval<CqlDateTime> jzzzzzy_ = this.Measurement_Period(context);
            DataType jzzzzzz_ = TobaccoUseScreening?.Effective;
            object kzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzz_);
            CqlInterval<CqlDateTime> kzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzza_);
            bool? kzzzzzc_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(jzzzzzy_, kzzzzzb_, "day");

            return kzzzzzc_;
        };
        IEnumerable<Observation> jzzzzzq_ = context.Operators.Where<Observation>(jzzzzzo_, jzzzzzp_);
        object jzzzzzr_(Observation @this)
        {
            DataType kzzzzzd_ = @this?.Effective;
            object kzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzd_);
            CqlInterval<CqlDateTime> kzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzze_);
            CqlDateTime kzzzzzg_ = context.Operators.Start(kzzzzzf_);

            return kzzzzzg_;
        };
        IEnumerable<Observation> jzzzzzs_ = context.Operators.SortBy<Observation>(jzzzzzq_, jzzzzzr_, System.ComponentModel.ListSortDirection.Ascending);
        Observation jzzzzzt_ = context.Operators.Last<Observation>(jzzzzzs_);
        Observation[] jzzzzzu_ = [
            jzzzzzt_,
        ];
        bool? jzzzzzv_(Observation MostRecentTobaccoUseScreening)
        {
            DataType kzzzzzh_ = MostRecentTobaccoUseScreening?.Value;
            object kzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzh_);
            CqlValueSet kzzzzzj_ = this.Tobacco_Non_User(context);
            bool? kzzzzzk_ = context.Operators.ConceptInValueSet(kzzzzzi_ as CqlConcept, kzzzzzj_);

            return kzzzzzk_;
        };
        IEnumerable<Observation> jzzzzzw_ = context.Operators.Where<Observation>((IEnumerable<Observation>)jzzzzzu_, jzzzzzv_);
        Observation jzzzzzx_ = context.Operators.SingletonFrom<Observation>(jzzzzzw_);

        return jzzzzzx_;
    }


    [CqlExpressionDefinition("Numerator 1")]
    public bool? Numerator_1(CqlContext context)
    {
        Observation kzzzzzl_ = this.Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_Non_User(context);
        bool? kzzzzzm_ = context.Operators.Not((bool?)(kzzzzzl_ is null));
        Observation kzzzzzn_ = this.Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_User(context);
        bool? kzzzzzo_ = context.Operators.Not((bool?)(kzzzzzn_ is null));
        bool? kzzzzzp_ = context.Operators.Or(kzzzzzm_, kzzzzzo_);

        return kzzzzzp_;
    }


    [CqlExpressionDefinition("Tobacco Cessation Counseling Given")]
    public IEnumerable<object> Tobacco_Cessation_Counseling_Given(CqlContext context)
    {
        CqlValueSet kzzzzzq_ = this.Tobacco_Use_Cessation_Counseling(context);
        IEnumerable<Procedure> kzzzzzr_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, kzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> kzzzzzs_ = Status_1_8_000.Instance.isInterventionPerformed(context, kzzzzzr_);
        bool? kzzzzzt_(Procedure TobaccoCessationCounseling)
        {
            CqlInterval<CqlDateTime> lzzzzzb_ = this.Measurement_Period(context);
            CqlDateTime lzzzzzc_ = context.Operators.Start(lzzzzzb_);
            CqlQuantity lzzzzzd_ = context.Operators.Quantity(6m, "months");
            CqlDateTime lzzzzze_ = context.Operators.Subtract(lzzzzzc_, lzzzzzd_);
            CqlDateTime lzzzzzg_ = context.Operators.End(lzzzzzb_);
            CqlInterval<CqlDateTime> lzzzzzh_ = context.Operators.Interval(lzzzzze_, lzzzzzg_, true, true);
            DataType lzzzzzi_ = TobaccoCessationCounseling?.Performed;
            object lzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzi_);
            CqlInterval<CqlDateTime> lzzzzzk_ = QICoreCommon_2_1_000.Instance.toInterval(context, lzzzzzj_);
            bool? lzzzzzl_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(lzzzzzh_, lzzzzzk_, "day");

            return lzzzzzl_;
        };
        IEnumerable<Procedure> kzzzzzu_ = context.Operators.Where<Procedure>(kzzzzzs_, kzzzzzt_);
        CqlCode kzzzzzv_ = this.Tobacco_abuse_counseling(context);
        IEnumerable<CqlCode> kzzzzzw_ = context.Operators.ToList<CqlCode>(kzzzzzv_);
        IEnumerable<Condition> kzzzzzx_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, kzzzzzw_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? kzzzzzy_(Condition TobaccoCounseling)
        {
            CqlInterval<CqlDateTime> lzzzzzm_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, TobaccoCounseling);
            CqlDateTime lzzzzzn_ = context.Operators.Start(lzzzzzm_);
            CqlInterval<CqlDateTime> lzzzzzo_ = this.Measurement_Period(context);
            CqlDateTime lzzzzzp_ = context.Operators.Start(lzzzzzo_);
            CqlQuantity lzzzzzq_ = context.Operators.Quantity(6m, "months");
            CqlDateTime lzzzzzr_ = context.Operators.Subtract(lzzzzzp_, lzzzzzq_);
            CqlDateTime lzzzzzt_ = context.Operators.End(lzzzzzo_);
            CqlInterval<CqlDateTime> lzzzzzu_ = context.Operators.Interval(lzzzzzr_, lzzzzzt_, true, true);
            bool? lzzzzzv_ = context.Operators.In<CqlDateTime>(lzzzzzn_, lzzzzzu_, "day");

            return lzzzzzv_;
        };
        IEnumerable<Condition> kzzzzzz_ = context.Operators.Where<Condition>(kzzzzzx_, kzzzzzy_);
        IEnumerable<object> lzzzzza_ = context.Operators.Union<object>(kzzzzzu_ as IEnumerable<object>, kzzzzzz_ as IEnumerable<object>);

        return lzzzzza_;
    }


    [CqlExpressionDefinition("Tobacco Cessation Pharmacotherapy Ordered")]
    public IEnumerable<MedicationRequest> Tobacco_Cessation_Pharmacotherapy_Ordered(CqlContext context)
    {
        CqlValueSet lzzzzzw_ = this.Tobacco_Use_Cessation_Pharmacotherapy(context);
        IEnumerable<MedicationRequest> lzzzzzx_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, lzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> lzzzzzz_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, lzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> mzzzzza_ = context.Operators.Union<MedicationRequest>(lzzzzzx_, lzzzzzz_);
        IEnumerable<MedicationRequest> mzzzzzb_ = Status_1_8_000.Instance.isMedicationOrder(context, mzzzzza_);
        bool? mzzzzzc_(MedicationRequest CessationPharmacotherapyOrdered)
        {
            FhirDateTime mzzzzze_ = CessationPharmacotherapyOrdered?.AuthoredOnElement;
            CqlDateTime mzzzzzf_ = context.Operators.Convert<CqlDateTime>(mzzzzze_);
            CqlInterval<CqlDateTime> mzzzzzg_ = this.Measurement_Period(context);
            CqlDateTime mzzzzzh_ = context.Operators.Start(mzzzzzg_);
            CqlQuantity mzzzzzi_ = context.Operators.Quantity(6m, "months");
            CqlDateTime mzzzzzj_ = context.Operators.Subtract(mzzzzzh_, mzzzzzi_);
            CqlDateTime mzzzzzl_ = context.Operators.End(mzzzzzg_);
            CqlInterval<CqlDateTime> mzzzzzm_ = context.Operators.Interval(mzzzzzj_, mzzzzzl_, true, true);
            bool? mzzzzzn_ = context.Operators.In<CqlDateTime>(mzzzzzf_, mzzzzzm_, "day");

            return mzzzzzn_;
        };
        IEnumerable<MedicationRequest> mzzzzzd_ = context.Operators.Where<MedicationRequest>(mzzzzzb_, mzzzzzc_);

        return mzzzzzd_;
    }


    [CqlExpressionDefinition("Active Pharmacotherapy for Tobacco Cessation")]
    public IEnumerable<MedicationRequest> Active_Pharmacotherapy_for_Tobacco_Cessation(CqlContext context)
    {
        CqlValueSet mzzzzzo_ = this.Tobacco_Use_Cessation_Pharmacotherapy(context);
        IEnumerable<MedicationRequest> mzzzzzp_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, mzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> mzzzzzr_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, mzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> mzzzzzs_ = context.Operators.Union<MedicationRequest>(mzzzzzp_, mzzzzzr_);
        IEnumerable<MedicationRequest> mzzzzzt_ = Status_1_8_000.Instance.isMedicationActive(context, mzzzzzs_);
        bool? mzzzzzu_(MedicationRequest TakingCessationPharmacotherapy)
        {
            CqlInterval<CqlDateTime> mzzzzzw_ = this.Measurement_Period(context);
            CqlDateTime mzzzzzx_ = context.Operators.Start(mzzzzzw_);
            CqlQuantity mzzzzzy_ = context.Operators.Quantity(6m, "months");
            CqlDateTime mzzzzzz_ = context.Operators.Subtract(mzzzzzx_, mzzzzzy_);
            CqlDateTime nzzzzzb_ = context.Operators.End(mzzzzzw_);
            CqlInterval<CqlDateTime> nzzzzzc_ = context.Operators.Interval(mzzzzzz_, nzzzzzb_, true, true);
            CqlInterval<CqlDate> nzzzzzd_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, TakingCessationPharmacotherapy);
            CqlDate nzzzzze_ = nzzzzzd_?.low;
            CqlDateTime nzzzzzf_ = context.Operators.ConvertDateToDateTime(nzzzzze_);
            CqlDate nzzzzzh_ = nzzzzzd_?.high;
            CqlDateTime nzzzzzi_ = context.Operators.ConvertDateToDateTime(nzzzzzh_);
            bool? nzzzzzk_ = nzzzzzd_?.lowClosed;
            bool? nzzzzzm_ = nzzzzzd_?.highClosed;
            CqlInterval<CqlDateTime> nzzzzzn_ = context.Operators.Interval(nzzzzzf_, nzzzzzi_, nzzzzzk_, nzzzzzm_);
            bool? nzzzzzo_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(nzzzzzc_, nzzzzzn_, "day");

            return nzzzzzo_;
        };
        IEnumerable<MedicationRequest> mzzzzzv_ = context.Operators.Where<MedicationRequest>(mzzzzzt_, mzzzzzu_);

        return mzzzzzv_;
    }


    [CqlExpressionDefinition("Numerator 2")]
    public bool? Numerator_2(CqlContext context)
    {
        IEnumerable<object> nzzzzzp_ = this.Tobacco_Cessation_Counseling_Given(context);
        bool? nzzzzzq_ = context.Operators.Exists<object>(nzzzzzp_);
        IEnumerable<MedicationRequest> nzzzzzr_ = this.Tobacco_Cessation_Pharmacotherapy_Ordered(context);
        bool? nzzzzzs_ = context.Operators.Exists<MedicationRequest>(nzzzzzr_);
        bool? nzzzzzt_ = context.Operators.Or(nzzzzzq_, nzzzzzs_);
        IEnumerable<MedicationRequest> nzzzzzu_ = this.Active_Pharmacotherapy_for_Tobacco_Cessation(context);
        bool? nzzzzzv_ = context.Operators.Exists<MedicationRequest>(nzzzzzu_);
        bool? nzzzzzw_ = context.Operators.Or(nzzzzzt_, nzzzzzv_);

        return nzzzzzw_;
    }


    [CqlExpressionDefinition("Numerator 3")]
    public bool? Numerator_3(CqlContext context)
    {
        Observation nzzzzzx_ = this.Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_Non_User(context);
        bool? nzzzzzy_ = context.Operators.Not((bool?)(nzzzzzx_ is null));
        Observation nzzzzzz_ = this.Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_User(context);
        bool? ozzzzza_ = context.Operators.Not((bool?)(nzzzzzz_ is null));
        IEnumerable<object> ozzzzzb_ = this.Tobacco_Cessation_Counseling_Given(context);
        bool? ozzzzzc_ = context.Operators.Exists<object>(ozzzzzb_);
        IEnumerable<MedicationRequest> ozzzzzd_ = this.Tobacco_Cessation_Pharmacotherapy_Ordered(context);
        bool? ozzzzze_ = context.Operators.Exists<MedicationRequest>(ozzzzzd_);
        bool? ozzzzzf_ = context.Operators.Or(ozzzzzc_, ozzzzze_);
        IEnumerable<MedicationRequest> ozzzzzg_ = this.Active_Pharmacotherapy_for_Tobacco_Cessation(context);
        bool? ozzzzzh_ = context.Operators.Exists<MedicationRequest>(ozzzzzg_);
        bool? ozzzzzi_ = context.Operators.Or(ozzzzzf_, ozzzzzh_);
        bool? ozzzzzj_ = context.Operators.And(ozzzzza_, ozzzzzi_);
        bool? ozzzzzk_ = context.Operators.Or(nzzzzzy_, ozzzzzj_);

        return ozzzzzk_;
    }


    [CqlExpressionDefinition("Denominator Exclusion")]
    public bool? Denominator_Exclusion(CqlContext context)
    {
        bool? ozzzzzl_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);

        return ozzzzzl_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? ozzzzzm_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return ozzzzzm_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> ozzzzzn_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return ozzzzzn_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? ozzzzzo_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return ozzzzzo_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode ozzzzzp_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return ozzzzzp_;
    }


    #endregion Expressions

}
