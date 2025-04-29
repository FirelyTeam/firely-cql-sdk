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
        CqlDateTime zzzzzzzzzzzzzw_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime zzzzzzzzzzzzzx_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> zzzzzzzzzzzzzy_ = context.Operators.Interval(zzzzzzzzzzzzzw_, zzzzzzzzzzzzzx_, true, true);
        object zzzzzzzzzzzzzz_ = context.ResolveParameter("PreventiveCareAndTobaccoUseScreeningAndCessationInterventionFHIR-0.0.001", "Measurement Period", zzzzzzzzzzzzzy_);

        return (CqlInterval<CqlDateTime>)zzzzzzzzzzzzzz_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> azzzzzzzzzzzzza_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient azzzzzzzzzzzzzb_ = context.Operators.SingletonFrom<Patient>(azzzzzzzzzzzzza_);

        return azzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Qualifying Visit During Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Visit_During_Measurement_Period(CqlContext context)
    {
        IEnumerable<Encounter> azzzzzzzzzzzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? azzzzzzzzzzzzzd_(Encounter E)
        {
            List<CodeableConcept> bzzzzzzzzzzzzzt_ = E?.Type;
            CqlConcept bzzzzzzzzzzzzzu_(CodeableConcept @this)
            {
                CqlConcept bzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return bzzzzzzzzzzzzzz_;
            };
            IEnumerable<CqlConcept> bzzzzzzzzzzzzzv_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)bzzzzzzzzzzzzzt_, bzzzzzzzzzzzzzu_);
            bool? bzzzzzzzzzzzzzw_(CqlConcept T)
            {
                CqlCode czzzzzzzzzzzzza_ = this.Health_behavior_intervention__individual__face_to_face__initial_30_minutes(context);
                CqlConcept czzzzzzzzzzzzzb_ = context.Operators.ConvertCodeToConcept(czzzzzzzzzzzzza_);
                bool? czzzzzzzzzzzzzc_ = context.Operators.Equivalent(T, czzzzzzzzzzzzzb_);

                return czzzzzzzzzzzzzc_;
            };
            IEnumerable<CqlConcept> bzzzzzzzzzzzzzx_ = context.Operators.Where<CqlConcept>(bzzzzzzzzzzzzzv_, bzzzzzzzzzzzzzw_);
            bool? bzzzzzzzzzzzzzy_ = context.Operators.Exists<CqlConcept>(bzzzzzzzzzzzzzx_);

            return bzzzzzzzzzzzzzy_;
        };
        IEnumerable<Encounter> azzzzzzzzzzzzze_ = context.Operators.Where<Encounter>(azzzzzzzzzzzzzc_, azzzzzzzzzzzzzd_);
        bool? azzzzzzzzzzzzzg_(Encounter E)
        {
            List<CodeableConcept> czzzzzzzzzzzzzd_ = E?.Type;
            CqlConcept czzzzzzzzzzzzze_(CodeableConcept @this)
            {
                CqlConcept czzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return czzzzzzzzzzzzzj_;
            };
            IEnumerable<CqlConcept> czzzzzzzzzzzzzf_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)czzzzzzzzzzzzzd_, czzzzzzzzzzzzze_);
            bool? czzzzzzzzzzzzzg_(CqlConcept T)
            {
                CqlCode czzzzzzzzzzzzzk_ = this.Health_behavior_assessment__or_re_assessment__ie__health_focused_clinical_interview__behavioral_observations__clinical_decision_making_(context);
                CqlConcept czzzzzzzzzzzzzl_ = context.Operators.ConvertCodeToConcept(czzzzzzzzzzzzzk_);
                bool? czzzzzzzzzzzzzm_ = context.Operators.Equivalent(T, czzzzzzzzzzzzzl_);

                return czzzzzzzzzzzzzm_;
            };
            IEnumerable<CqlConcept> czzzzzzzzzzzzzh_ = context.Operators.Where<CqlConcept>(czzzzzzzzzzzzzf_, czzzzzzzzzzzzzg_);
            bool? czzzzzzzzzzzzzi_ = context.Operators.Exists<CqlConcept>(czzzzzzzzzzzzzh_);

            return czzzzzzzzzzzzzi_;
        };
        IEnumerable<Encounter> azzzzzzzzzzzzzh_ = context.Operators.Where<Encounter>(azzzzzzzzzzzzzc_, azzzzzzzzzzzzzg_);
        IEnumerable<Encounter> azzzzzzzzzzzzzi_ = context.Operators.Union<Encounter>(azzzzzzzzzzzzze_, azzzzzzzzzzzzzh_);
        CqlValueSet azzzzzzzzzzzzzj_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet azzzzzzzzzzzzzl_ = this.Occupational_Therapy_Evaluation(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> azzzzzzzzzzzzzn_ = context.Operators.Union<Encounter>(azzzzzzzzzzzzzk_, azzzzzzzzzzzzzm_);
        IEnumerable<Encounter> azzzzzzzzzzzzzo_ = context.Operators.Union<Encounter>(azzzzzzzzzzzzzi_, azzzzzzzzzzzzzn_);
        CqlValueSet azzzzzzzzzzzzzp_ = this.Office_Visit(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzq_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet azzzzzzzzzzzzzr_ = this.Ophthalmological_Services(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> azzzzzzzzzzzzzt_ = context.Operators.Union<Encounter>(azzzzzzzzzzzzzq_, azzzzzzzzzzzzzs_);
        IEnumerable<Encounter> azzzzzzzzzzzzzu_ = context.Operators.Union<Encounter>(azzzzzzzzzzzzzo_, azzzzzzzzzzzzzt_);
        CqlValueSet azzzzzzzzzzzzzv_ = this.Physical_Therapy_Evaluation(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet azzzzzzzzzzzzzx_ = this.Psych_Visit_Diagnostic_Evaluation(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> azzzzzzzzzzzzzz_ = context.Operators.Union<Encounter>(azzzzzzzzzzzzzw_, azzzzzzzzzzzzzy_);
        IEnumerable<Encounter> bzzzzzzzzzzzzza_ = context.Operators.Union<Encounter>(azzzzzzzzzzzzzu_, azzzzzzzzzzzzzz_);
        CqlValueSet bzzzzzzzzzzzzzb_ = this.Psych_Visit_Psychotherapy(context);
        IEnumerable<Encounter> bzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet bzzzzzzzzzzzzzd_ = this.Psychoanalysis(context);
        IEnumerable<Encounter> bzzzzzzzzzzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> bzzzzzzzzzzzzzf_ = context.Operators.Union<Encounter>(bzzzzzzzzzzzzzc_, bzzzzzzzzzzzzze_);
        IEnumerable<Encounter> bzzzzzzzzzzzzzg_ = context.Operators.Union<Encounter>(bzzzzzzzzzzzzza_, bzzzzzzzzzzzzzf_);
        CqlValueSet bzzzzzzzzzzzzzh_ = this.Speech_and_Hearing_Evaluation(context);
        IEnumerable<Encounter> bzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet bzzzzzzzzzzzzzj_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> bzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> bzzzzzzzzzzzzzl_ = context.Operators.Union<Encounter>(bzzzzzzzzzzzzzi_, bzzzzzzzzzzzzzk_);
        IEnumerable<Encounter> bzzzzzzzzzzzzzm_ = context.Operators.Union<Encounter>(bzzzzzzzzzzzzzg_, bzzzzzzzzzzzzzl_);
        CqlValueSet bzzzzzzzzzzzzzn_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> bzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> bzzzzzzzzzzzzzp_ = context.Operators.Union<Encounter>(bzzzzzzzzzzzzzm_, bzzzzzzzzzzzzzo_);
        IEnumerable<Encounter> bzzzzzzzzzzzzzq_ = Status_1_8_000.Instance.isEncounterPerformed(context, bzzzzzzzzzzzzzp_);
        bool? bzzzzzzzzzzzzzr_(Encounter OfficeBasedEncounter)
        {
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzn_ = this.Measurement_Period(context);
            Period czzzzzzzzzzzzzo_ = OfficeBasedEncounter?.Period;
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, czzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.toInterval(context, czzzzzzzzzzzzzp_ as object);
            bool? czzzzzzzzzzzzzr_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(czzzzzzzzzzzzzn_, czzzzzzzzzzzzzq_, "day");

            return czzzzzzzzzzzzzr_;
        };
        IEnumerable<Encounter> bzzzzzzzzzzzzzs_ = context.Operators.Where<Encounter>(bzzzzzzzzzzzzzq_, bzzzzzzzzzzzzzr_);

        return bzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Preventive Visit During Measurement Period")]
    public IEnumerable<Encounter> Preventive_Visit_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet czzzzzzzzzzzzzs_ = this.Annual_Wellness_Visit(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, czzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet czzzzzzzzzzzzzu_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, czzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> czzzzzzzzzzzzzw_ = context.Operators.Union<Encounter>(czzzzzzzzzzzzzt_, czzzzzzzzzzzzzv_);
        CqlValueSet czzzzzzzzzzzzzx_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, czzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet czzzzzzzzzzzzzz_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> dzzzzzzzzzzzzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, czzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> dzzzzzzzzzzzzzb_ = context.Operators.Union<Encounter>(czzzzzzzzzzzzzy_, dzzzzzzzzzzzzza_);
        IEnumerable<Encounter> dzzzzzzzzzzzzzc_ = context.Operators.Union<Encounter>(czzzzzzzzzzzzzw_, dzzzzzzzzzzzzzb_);
        CqlValueSet dzzzzzzzzzzzzzd_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> dzzzzzzzzzzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet dzzzzzzzzzzzzzf_ = this.Preventive_Care_Services_Group_Counseling(context);
        IEnumerable<Encounter> dzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> dzzzzzzzzzzzzzh_ = context.Operators.Union<Encounter>(dzzzzzzzzzzzzze_, dzzzzzzzzzzzzzg_);
        IEnumerable<Encounter> dzzzzzzzzzzzzzi_ = context.Operators.Union<Encounter>(dzzzzzzzzzzzzzc_, dzzzzzzzzzzzzzh_);
        CqlValueSet dzzzzzzzzzzzzzj_ = this.Preventive_Care_Services_Individual_Counseling(context);
        IEnumerable<Encounter> dzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> dzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? dzzzzzzzzzzzzzm_(Encounter E)
        {
            List<CodeableConcept> ezzzzzzzzzzzzza_ = E?.Type;
            CqlConcept ezzzzzzzzzzzzzb_(CodeableConcept @this)
            {
                CqlConcept ezzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return ezzzzzzzzzzzzzg_;
            };
            IEnumerable<CqlConcept> ezzzzzzzzzzzzzc_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)ezzzzzzzzzzzzza_, ezzzzzzzzzzzzzb_);
            bool? ezzzzzzzzzzzzzd_(CqlConcept T)
            {
                CqlCode ezzzzzzzzzzzzzh_ = this.Unlisted_preventive_medicine_service(context);
                CqlConcept ezzzzzzzzzzzzzi_ = context.Operators.ConvertCodeToConcept(ezzzzzzzzzzzzzh_);
                bool? ezzzzzzzzzzzzzj_ = context.Operators.Equivalent(T, ezzzzzzzzzzzzzi_);

                return ezzzzzzzzzzzzzj_;
            };
            IEnumerable<CqlConcept> ezzzzzzzzzzzzze_ = context.Operators.Where<CqlConcept>(ezzzzzzzzzzzzzc_, ezzzzzzzzzzzzzd_);
            bool? ezzzzzzzzzzzzzf_ = context.Operators.Exists<CqlConcept>(ezzzzzzzzzzzzze_);

            return ezzzzzzzzzzzzzf_;
        };
        IEnumerable<Encounter> dzzzzzzzzzzzzzn_ = context.Operators.Where<Encounter>(dzzzzzzzzzzzzzl_, dzzzzzzzzzzzzzm_);
        IEnumerable<Encounter> dzzzzzzzzzzzzzo_ = context.Operators.Union<Encounter>(dzzzzzzzzzzzzzk_, dzzzzzzzzzzzzzn_);
        IEnumerable<Encounter> dzzzzzzzzzzzzzp_ = context.Operators.Union<Encounter>(dzzzzzzzzzzzzzi_, dzzzzzzzzzzzzzo_);
        bool? dzzzzzzzzzzzzzr_(Encounter E)
        {
            List<CodeableConcept> ezzzzzzzzzzzzzk_ = E?.Type;
            CqlConcept ezzzzzzzzzzzzzl_(CodeableConcept @this)
            {
                CqlConcept ezzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return ezzzzzzzzzzzzzq_;
            };
            IEnumerable<CqlConcept> ezzzzzzzzzzzzzm_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)ezzzzzzzzzzzzzk_, ezzzzzzzzzzzzzl_);
            bool? ezzzzzzzzzzzzzn_(CqlConcept T)
            {
                CqlCode ezzzzzzzzzzzzzr_ = this.Postoperative_follow_up_visit__normally_included_in_the_surgical_package__to_indicate_that_an_evaluation_and_management_service_was_performed_during_a_postoperative_period_for_a_reason_s__related_to_the_original_procedure(context);
                CqlConcept ezzzzzzzzzzzzzs_ = context.Operators.ConvertCodeToConcept(ezzzzzzzzzzzzzr_);
                bool? ezzzzzzzzzzzzzt_ = context.Operators.Equivalent(T, ezzzzzzzzzzzzzs_);

                return ezzzzzzzzzzzzzt_;
            };
            IEnumerable<CqlConcept> ezzzzzzzzzzzzzo_ = context.Operators.Where<CqlConcept>(ezzzzzzzzzzzzzm_, ezzzzzzzzzzzzzn_);
            bool? ezzzzzzzzzzzzzp_ = context.Operators.Exists<CqlConcept>(ezzzzzzzzzzzzzo_);

            return ezzzzzzzzzzzzzp_;
        };
        IEnumerable<Encounter> dzzzzzzzzzzzzzs_ = context.Operators.Where<Encounter>(dzzzzzzzzzzzzzl_, dzzzzzzzzzzzzzr_);
        CqlValueSet dzzzzzzzzzzzzzt_ = this.Nutrition_Services(context);
        IEnumerable<Encounter> dzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> dzzzzzzzzzzzzzv_ = context.Operators.Union<Encounter>(dzzzzzzzzzzzzzs_, dzzzzzzzzzzzzzu_);
        IEnumerable<Encounter> dzzzzzzzzzzzzzw_ = context.Operators.Union<Encounter>(dzzzzzzzzzzzzzp_, dzzzzzzzzzzzzzv_);
        IEnumerable<Encounter> dzzzzzzzzzzzzzx_ = Status_1_8_000.Instance.isEncounterPerformed(context, dzzzzzzzzzzzzzw_);
        bool? dzzzzzzzzzzzzzy_(Encounter PreventiveEncounter)
        {
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzu_ = this.Measurement_Period(context);
            Period ezzzzzzzzzzzzzv_ = PreventiveEncounter?.Period;
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.toInterval(context, ezzzzzzzzzzzzzw_ as object);
            bool? ezzzzzzzzzzzzzy_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ezzzzzzzzzzzzzu_, ezzzzzzzzzzzzzx_, "day");

            return ezzzzzzzzzzzzzy_;
        };
        IEnumerable<Encounter> dzzzzzzzzzzzzzz_ = context.Operators.Where<Encounter>(dzzzzzzzzzzzzzx_, dzzzzzzzzzzzzzy_);

        return dzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient ezzzzzzzzzzzzzz_ = this.Patient(context);
        Date fzzzzzzzzzzzzza_ = ezzzzzzzzzzzzzz_?.BirthDateElement;
        string fzzzzzzzzzzzzzb_ = fzzzzzzzzzzzzza_?.Value;
        CqlDate fzzzzzzzzzzzzzc_ = context.Operators.ConvertStringToDate(fzzzzzzzzzzzzzb_);
        CqlInterval<CqlDateTime> fzzzzzzzzzzzzzd_ = this.Measurement_Period(context);
        CqlDateTime fzzzzzzzzzzzzze_ = context.Operators.Start(fzzzzzzzzzzzzzd_);
        CqlDate fzzzzzzzzzzzzzf_ = context.Operators.DateFrom(fzzzzzzzzzzzzze_);
        int? fzzzzzzzzzzzzzg_ = context.Operators.CalculateAgeAt(fzzzzzzzzzzzzzc_, fzzzzzzzzzzzzzf_, "year");
        bool? fzzzzzzzzzzzzzh_ = context.Operators.GreaterOrEqual(fzzzzzzzzzzzzzg_, 12);
        IEnumerable<Encounter> fzzzzzzzzzzzzzi_ = this.Qualifying_Visit_During_Measurement_Period(context);
        int? fzzzzzzzzzzzzzj_ = context.Operators.Count<Encounter>(fzzzzzzzzzzzzzi_);
        bool? fzzzzzzzzzzzzzk_ = context.Operators.GreaterOrEqual(fzzzzzzzzzzzzzj_, 2);
        IEnumerable<Encounter> fzzzzzzzzzzzzzl_ = this.Preventive_Visit_During_Measurement_Period(context);
        bool? fzzzzzzzzzzzzzm_ = context.Operators.Exists<Encounter>(fzzzzzzzzzzzzzl_);
        bool? fzzzzzzzzzzzzzn_ = context.Operators.Or(fzzzzzzzzzzzzzk_, fzzzzzzzzzzzzzm_);
        bool? fzzzzzzzzzzzzzo_ = context.Operators.And(fzzzzzzzzzzzzzh_, fzzzzzzzzzzzzzn_);

        return fzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Denominator 1")]
    public bool? Denominator_1(CqlContext context)
    {
        bool? fzzzzzzzzzzzzzp_ = this.Initial_Population(context);

        return fzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Most Recent Tobacco Use Screening Indicates Tobacco User")]
    public Observation Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_User(CqlContext context)
    {
        CqlValueSet fzzzzzzzzzzzzzq_ = this.Tobacco_Use_Screening(context);
        IEnumerable<Observation> fzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, fzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> fzzzzzzzzzzzzzs_ = Status_1_8_000.Instance.isAssessmentPerformed(context, fzzzzzzzzzzzzzr_);
        bool? fzzzzzzzzzzzzzt_(Observation TobaccoUseScreening)
        {
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzc_ = this.Measurement_Period(context);
            DataType gzzzzzzzzzzzzzd_ = TobaccoUseScreening?.Effective;
            object gzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzzzzze_);
            bool? gzzzzzzzzzzzzzg_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(gzzzzzzzzzzzzzc_, gzzzzzzzzzzzzzf_, "day");

            return gzzzzzzzzzzzzzg_;
        };
        IEnumerable<Observation> fzzzzzzzzzzzzzu_ = context.Operators.Where<Observation>(fzzzzzzzzzzzzzs_, fzzzzzzzzzzzzzt_);
        object fzzzzzzzzzzzzzv_(Observation @this)
        {
            DataType gzzzzzzzzzzzzzh_ = @this?.Effective;
            object gzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzzzzzi_);
            CqlDateTime gzzzzzzzzzzzzzk_ = context.Operators.Start(gzzzzzzzzzzzzzj_);

            return gzzzzzzzzzzzzzk_;
        };
        IEnumerable<Observation> fzzzzzzzzzzzzzw_ = context.Operators.SortBy<Observation>(fzzzzzzzzzzzzzu_, fzzzzzzzzzzzzzv_, System.ComponentModel.ListSortDirection.Ascending);
        Observation fzzzzzzzzzzzzzx_ = context.Operators.Last<Observation>(fzzzzzzzzzzzzzw_);
        Observation[] fzzzzzzzzzzzzzy_ = [
            fzzzzzzzzzzzzzx_,
        ];
        bool? fzzzzzzzzzzzzzz_(Observation MostRecentTobaccoUseScreening)
        {
            DataType gzzzzzzzzzzzzzl_ = MostRecentTobaccoUseScreening?.Value;
            object gzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzl_);
            CqlValueSet gzzzzzzzzzzzzzn_ = this.Tobacco_User(context);
            bool? gzzzzzzzzzzzzzo_ = context.Operators.ConceptInValueSet(gzzzzzzzzzzzzzm_ as CqlConcept, gzzzzzzzzzzzzzn_);

            return gzzzzzzzzzzzzzo_;
        };
        IEnumerable<Observation> gzzzzzzzzzzzzza_ = context.Operators.Where<Observation>((IEnumerable<Observation>)fzzzzzzzzzzzzzy_, fzzzzzzzzzzzzzz_);
        Observation gzzzzzzzzzzzzzb_ = context.Operators.SingletonFrom<Observation>(gzzzzzzzzzzzzza_);

        return gzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Denominator 2")]
    public bool? Denominator_2(CqlContext context)
    {
        bool? gzzzzzzzzzzzzzp_ = this.Initial_Population(context);
        Observation gzzzzzzzzzzzzzq_ = this.Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_User(context);
        bool? gzzzzzzzzzzzzzr_ = context.Operators.Not((bool?)(gzzzzzzzzzzzzzq_ is null));
        bool? gzzzzzzzzzzzzzs_ = context.Operators.And(gzzzzzzzzzzzzzp_, gzzzzzzzzzzzzzr_);

        return gzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Denominator 3")]
    public bool? Denominator_3(CqlContext context)
    {
        bool? gzzzzzzzzzzzzzt_ = this.Initial_Population(context);

        return gzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Most Recent Tobacco Use Screening Indicates Tobacco Non User")]
    public Observation Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_Non_User(CqlContext context)
    {
        CqlValueSet gzzzzzzzzzzzzzu_ = this.Tobacco_Use_Screening(context);
        IEnumerable<Observation> gzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, gzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> gzzzzzzzzzzzzzw_ = Status_1_8_000.Instance.isAssessmentPerformed(context, gzzzzzzzzzzzzzv_);
        bool? gzzzzzzzzzzzzzx_(Observation TobaccoUseScreening)
        {
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzg_ = this.Measurement_Period(context);
            DataType hzzzzzzzzzzzzzh_ = TobaccoUseScreening?.Effective;
            object hzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.toInterval(context, hzzzzzzzzzzzzzi_);
            bool? hzzzzzzzzzzzzzk_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(hzzzzzzzzzzzzzg_, hzzzzzzzzzzzzzj_, "day");

            return hzzzzzzzzzzzzzk_;
        };
        IEnumerable<Observation> gzzzzzzzzzzzzzy_ = context.Operators.Where<Observation>(gzzzzzzzzzzzzzw_, gzzzzzzzzzzzzzx_);
        object gzzzzzzzzzzzzzz_(Observation @this)
        {
            DataType hzzzzzzzzzzzzzl_ = @this?.Effective;
            object hzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.toInterval(context, hzzzzzzzzzzzzzm_);
            CqlDateTime hzzzzzzzzzzzzzo_ = context.Operators.Start(hzzzzzzzzzzzzzn_);

            return hzzzzzzzzzzzzzo_;
        };
        IEnumerable<Observation> hzzzzzzzzzzzzza_ = context.Operators.SortBy<Observation>(gzzzzzzzzzzzzzy_, gzzzzzzzzzzzzzz_, System.ComponentModel.ListSortDirection.Ascending);
        Observation hzzzzzzzzzzzzzb_ = context.Operators.Last<Observation>(hzzzzzzzzzzzzza_);
        Observation[] hzzzzzzzzzzzzzc_ = [
            hzzzzzzzzzzzzzb_,
        ];
        bool? hzzzzzzzzzzzzzd_(Observation MostRecentTobaccoUseScreening)
        {
            DataType hzzzzzzzzzzzzzp_ = MostRecentTobaccoUseScreening?.Value;
            object hzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzp_);
            CqlValueSet hzzzzzzzzzzzzzr_ = this.Tobacco_Non_User(context);
            bool? hzzzzzzzzzzzzzs_ = context.Operators.ConceptInValueSet(hzzzzzzzzzzzzzq_ as CqlConcept, hzzzzzzzzzzzzzr_);

            return hzzzzzzzzzzzzzs_;
        };
        IEnumerable<Observation> hzzzzzzzzzzzzze_ = context.Operators.Where<Observation>((IEnumerable<Observation>)hzzzzzzzzzzzzzc_, hzzzzzzzzzzzzzd_);
        Observation hzzzzzzzzzzzzzf_ = context.Operators.SingletonFrom<Observation>(hzzzzzzzzzzzzze_);

        return hzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Numerator 1")]
    public bool? Numerator_1(CqlContext context)
    {
        Observation hzzzzzzzzzzzzzt_ = this.Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_Non_User(context);
        bool? hzzzzzzzzzzzzzu_ = context.Operators.Not((bool?)(hzzzzzzzzzzzzzt_ is null));
        Observation hzzzzzzzzzzzzzv_ = this.Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_User(context);
        bool? hzzzzzzzzzzzzzw_ = context.Operators.Not((bool?)(hzzzzzzzzzzzzzv_ is null));
        bool? hzzzzzzzzzzzzzx_ = context.Operators.Or(hzzzzzzzzzzzzzu_, hzzzzzzzzzzzzzw_);

        return hzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Tobacco Cessation Counseling Given")]
    public IEnumerable<object> Tobacco_Cessation_Counseling_Given(CqlContext context)
    {
        CqlValueSet hzzzzzzzzzzzzzy_ = this.Tobacco_Use_Cessation_Counseling(context);
        IEnumerable<Procedure> hzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, hzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> izzzzzzzzzzzzza_ = Status_1_8_000.Instance.isInterventionPerformed(context, hzzzzzzzzzzzzzz_);
        bool? izzzzzzzzzzzzzb_(Procedure TobaccoCessationCounseling)
        {
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzj_ = this.Measurement_Period(context);
            CqlDateTime izzzzzzzzzzzzzk_ = context.Operators.Start(izzzzzzzzzzzzzj_);
            CqlQuantity izzzzzzzzzzzzzl_ = context.Operators.Quantity(6m, "months");
            CqlDateTime izzzzzzzzzzzzzm_ = context.Operators.Subtract(izzzzzzzzzzzzzk_, izzzzzzzzzzzzzl_);
            CqlDateTime izzzzzzzzzzzzzo_ = context.Operators.End(izzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzp_ = context.Operators.Interval(izzzzzzzzzzzzzm_, izzzzzzzzzzzzzo_, true, true);
            DataType izzzzzzzzzzzzzq_ = TobaccoCessationCounseling?.Performed;
            object izzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.toInterval(context, izzzzzzzzzzzzzr_);
            bool? izzzzzzzzzzzzzt_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(izzzzzzzzzzzzzp_, izzzzzzzzzzzzzs_, "day");

            return izzzzzzzzzzzzzt_;
        };
        IEnumerable<Procedure> izzzzzzzzzzzzzc_ = context.Operators.Where<Procedure>(izzzzzzzzzzzzza_, izzzzzzzzzzzzzb_);
        CqlCode izzzzzzzzzzzzzd_ = this.Tobacco_abuse_counseling(context);
        IEnumerable<CqlCode> izzzzzzzzzzzzze_ = context.Operators.ToList<CqlCode>(izzzzzzzzzzzzzd_);
        IEnumerable<Condition> izzzzzzzzzzzzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, izzzzzzzzzzzzze_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? izzzzzzzzzzzzzg_(Condition TobaccoCounseling)
        {
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, TobaccoCounseling);
            CqlDateTime izzzzzzzzzzzzzv_ = context.Operators.Start(izzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzw_ = this.Measurement_Period(context);
            CqlDateTime izzzzzzzzzzzzzx_ = context.Operators.Start(izzzzzzzzzzzzzw_);
            CqlQuantity izzzzzzzzzzzzzy_ = context.Operators.Quantity(6m, "months");
            CqlDateTime izzzzzzzzzzzzzz_ = context.Operators.Subtract(izzzzzzzzzzzzzx_, izzzzzzzzzzzzzy_);
            CqlDateTime jzzzzzzzzzzzzzb_ = context.Operators.End(izzzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzc_ = context.Operators.Interval(izzzzzzzzzzzzzz_, jzzzzzzzzzzzzzb_, true, true);
            bool? jzzzzzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(izzzzzzzzzzzzzv_, jzzzzzzzzzzzzzc_, "day");

            return jzzzzzzzzzzzzzd_;
        };
        IEnumerable<Condition> izzzzzzzzzzzzzh_ = context.Operators.Where<Condition>(izzzzzzzzzzzzzf_, izzzzzzzzzzzzzg_);
        IEnumerable<object> izzzzzzzzzzzzzi_ = context.Operators.Union<object>(izzzzzzzzzzzzzc_ as IEnumerable<object>, izzzzzzzzzzzzzh_ as IEnumerable<object>);

        return izzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Tobacco Cessation Pharmacotherapy Ordered")]
    public IEnumerable<MedicationRequest> Tobacco_Cessation_Pharmacotherapy_Ordered(CqlContext context)
    {
        CqlValueSet jzzzzzzzzzzzzze_ = this.Tobacco_Use_Cessation_Pharmacotherapy(context);
        IEnumerable<MedicationRequest> jzzzzzzzzzzzzzf_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, jzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> jzzzzzzzzzzzzzh_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, jzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> jzzzzzzzzzzzzzi_ = context.Operators.Union<MedicationRequest>(jzzzzzzzzzzzzzf_, jzzzzzzzzzzzzzh_);
        IEnumerable<MedicationRequest> jzzzzzzzzzzzzzj_ = Status_1_8_000.Instance.isMedicationOrder(context, jzzzzzzzzzzzzzi_);
        bool? jzzzzzzzzzzzzzk_(MedicationRequest CessationPharmacotherapyOrdered)
        {
            FhirDateTime jzzzzzzzzzzzzzm_ = CessationPharmacotherapyOrdered?.AuthoredOnElement;
            CqlDateTime jzzzzzzzzzzzzzn_ = context.Operators.Convert<CqlDateTime>(jzzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzo_ = this.Measurement_Period(context);
            CqlDateTime jzzzzzzzzzzzzzp_ = context.Operators.Start(jzzzzzzzzzzzzzo_);
            CqlQuantity jzzzzzzzzzzzzzq_ = context.Operators.Quantity(6m, "months");
            CqlDateTime jzzzzzzzzzzzzzr_ = context.Operators.Subtract(jzzzzzzzzzzzzzp_, jzzzzzzzzzzzzzq_);
            CqlDateTime jzzzzzzzzzzzzzt_ = context.Operators.End(jzzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzu_ = context.Operators.Interval(jzzzzzzzzzzzzzr_, jzzzzzzzzzzzzzt_, true, true);
            bool? jzzzzzzzzzzzzzv_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzzzzzn_, jzzzzzzzzzzzzzu_, "day");

            return jzzzzzzzzzzzzzv_;
        };
        IEnumerable<MedicationRequest> jzzzzzzzzzzzzzl_ = context.Operators.Where<MedicationRequest>(jzzzzzzzzzzzzzj_, jzzzzzzzzzzzzzk_);

        return jzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Active Pharmacotherapy for Tobacco Cessation")]
    public IEnumerable<MedicationRequest> Active_Pharmacotherapy_for_Tobacco_Cessation(CqlContext context)
    {
        CqlValueSet jzzzzzzzzzzzzzw_ = this.Tobacco_Use_Cessation_Pharmacotherapy(context);
        IEnumerable<MedicationRequest> jzzzzzzzzzzzzzx_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, jzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> jzzzzzzzzzzzzzz_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, jzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> kzzzzzzzzzzzzza_ = context.Operators.Union<MedicationRequest>(jzzzzzzzzzzzzzx_, jzzzzzzzzzzzzzz_);
        IEnumerable<MedicationRequest> kzzzzzzzzzzzzzb_ = Status_1_8_000.Instance.isMedicationActive(context, kzzzzzzzzzzzzza_);
        bool? kzzzzzzzzzzzzzc_(MedicationRequest TakingCessationPharmacotherapy)
        {
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzze_ = this.Measurement_Period(context);
            CqlDateTime kzzzzzzzzzzzzzf_ = context.Operators.Start(kzzzzzzzzzzzzze_);
            CqlQuantity kzzzzzzzzzzzzzg_ = context.Operators.Quantity(6m, "months");
            CqlDateTime kzzzzzzzzzzzzzh_ = context.Operators.Subtract(kzzzzzzzzzzzzzf_, kzzzzzzzzzzzzzg_);
            CqlDateTime kzzzzzzzzzzzzzj_ = context.Operators.End(kzzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzk_ = context.Operators.Interval(kzzzzzzzzzzzzzh_, kzzzzzzzzzzzzzj_, true, true);
            CqlInterval<CqlDate> kzzzzzzzzzzzzzl_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, TakingCessationPharmacotherapy);
            CqlDate kzzzzzzzzzzzzzm_ = kzzzzzzzzzzzzzl_?.low;
            CqlDateTime kzzzzzzzzzzzzzn_ = context.Operators.ConvertDateToDateTime(kzzzzzzzzzzzzzm_);
            CqlDate kzzzzzzzzzzzzzp_ = kzzzzzzzzzzzzzl_?.high;
            CqlDateTime kzzzzzzzzzzzzzq_ = context.Operators.ConvertDateToDateTime(kzzzzzzzzzzzzzp_);
            bool? kzzzzzzzzzzzzzs_ = kzzzzzzzzzzzzzl_?.lowClosed;
            bool? kzzzzzzzzzzzzzu_ = kzzzzzzzzzzzzzl_?.highClosed;
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzv_ = context.Operators.Interval(kzzzzzzzzzzzzzn_, kzzzzzzzzzzzzzq_, kzzzzzzzzzzzzzs_, kzzzzzzzzzzzzzu_);
            bool? kzzzzzzzzzzzzzw_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(kzzzzzzzzzzzzzk_, kzzzzzzzzzzzzzv_, "day");

            return kzzzzzzzzzzzzzw_;
        };
        IEnumerable<MedicationRequest> kzzzzzzzzzzzzzd_ = context.Operators.Where<MedicationRequest>(kzzzzzzzzzzzzzb_, kzzzzzzzzzzzzzc_);

        return kzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Numerator 2")]
    public bool? Numerator_2(CqlContext context)
    {
        IEnumerable<object> kzzzzzzzzzzzzzx_ = this.Tobacco_Cessation_Counseling_Given(context);
        bool? kzzzzzzzzzzzzzy_ = context.Operators.Exists<object>(kzzzzzzzzzzzzzx_);
        IEnumerable<MedicationRequest> kzzzzzzzzzzzzzz_ = this.Tobacco_Cessation_Pharmacotherapy_Ordered(context);
        bool? lzzzzzzzzzzzzza_ = context.Operators.Exists<MedicationRequest>(kzzzzzzzzzzzzzz_);
        bool? lzzzzzzzzzzzzzb_ = context.Operators.Or(kzzzzzzzzzzzzzy_, lzzzzzzzzzzzzza_);
        IEnumerable<MedicationRequest> lzzzzzzzzzzzzzc_ = this.Active_Pharmacotherapy_for_Tobacco_Cessation(context);
        bool? lzzzzzzzzzzzzzd_ = context.Operators.Exists<MedicationRequest>(lzzzzzzzzzzzzzc_);
        bool? lzzzzzzzzzzzzze_ = context.Operators.Or(lzzzzzzzzzzzzzb_, lzzzzzzzzzzzzzd_);

        return lzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Numerator 3")]
    public bool? Numerator_3(CqlContext context)
    {
        Observation lzzzzzzzzzzzzzf_ = this.Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_Non_User(context);
        bool? lzzzzzzzzzzzzzg_ = context.Operators.Not((bool?)(lzzzzzzzzzzzzzf_ is null));
        Observation lzzzzzzzzzzzzzh_ = this.Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_User(context);
        bool? lzzzzzzzzzzzzzi_ = context.Operators.Not((bool?)(lzzzzzzzzzzzzzh_ is null));
        IEnumerable<object> lzzzzzzzzzzzzzj_ = this.Tobacco_Cessation_Counseling_Given(context);
        bool? lzzzzzzzzzzzzzk_ = context.Operators.Exists<object>(lzzzzzzzzzzzzzj_);
        IEnumerable<MedicationRequest> lzzzzzzzzzzzzzl_ = this.Tobacco_Cessation_Pharmacotherapy_Ordered(context);
        bool? lzzzzzzzzzzzzzm_ = context.Operators.Exists<MedicationRequest>(lzzzzzzzzzzzzzl_);
        bool? lzzzzzzzzzzzzzn_ = context.Operators.Or(lzzzzzzzzzzzzzk_, lzzzzzzzzzzzzzm_);
        IEnumerable<MedicationRequest> lzzzzzzzzzzzzzo_ = this.Active_Pharmacotherapy_for_Tobacco_Cessation(context);
        bool? lzzzzzzzzzzzzzp_ = context.Operators.Exists<MedicationRequest>(lzzzzzzzzzzzzzo_);
        bool? lzzzzzzzzzzzzzq_ = context.Operators.Or(lzzzzzzzzzzzzzn_, lzzzzzzzzzzzzzp_);
        bool? lzzzzzzzzzzzzzr_ = context.Operators.And(lzzzzzzzzzzzzzi_, lzzzzzzzzzzzzzq_);
        bool? lzzzzzzzzzzzzzs_ = context.Operators.Or(lzzzzzzzzzzzzzg_, lzzzzzzzzzzzzzr_);

        return lzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Denominator Exclusion")]
    public bool? Denominator_Exclusion(CqlContext context)
    {
        bool? lzzzzzzzzzzzzzt_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);

        return lzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? lzzzzzzzzzzzzzu_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return lzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> lzzzzzzzzzzzzzv_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return lzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? lzzzzzzzzzzzzzw_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return lzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode lzzzzzzzzzzzzzx_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return lzzzzzzzzzzzzzx_;
    }


    #endregion Expressions

}
