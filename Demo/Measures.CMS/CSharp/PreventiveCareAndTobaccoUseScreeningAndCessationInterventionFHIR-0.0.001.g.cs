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
    private static readonly CqlCode _Health_behavior_assessment__or_re_assessment__ie__health_focused_clinical_interview__behavioral_observations__clinical_decision_making_ = new CqlCode("96156", "http://www.ama-assn.org/go/cpt");

    [CqlCodeDefinition("Health behavior intervention, individual, face-to-face; initial 30 minutes", codeId: "96158", codeSystem: "http://www.ama-assn.org/go/cpt")]
    public CqlCode Health_behavior_intervention__individual__face_to_face__initial_30_minutes(CqlContext _) => _Health_behavior_intervention__individual__face_to_face__initial_30_minutes;
    private static readonly CqlCode _Health_behavior_intervention__individual__face_to_face__initial_30_minutes = new CqlCode("96158", "http://www.ama-assn.org/go/cpt");

    [CqlCodeDefinition("Postoperative follow-up visit, normally included in the surgical package, to indicate that an evaluation and management service was performed during a postoperative period for a reason(s) related to the original procedure", codeId: "99024", codeSystem: "http://www.ama-assn.org/go/cpt")]
    public CqlCode Postoperative_follow_up_visit__normally_included_in_the_surgical_package__to_indicate_that_an_evaluation_and_management_service_was_performed_during_a_postoperative_period_for_a_reason_s__related_to_the_original_procedure(CqlContext _) => _Postoperative_follow_up_visit__normally_included_in_the_surgical_package__to_indicate_that_an_evaluation_and_management_service_was_performed_during_a_postoperative_period_for_a_reason_s__related_to_the_original_procedure;
    private static readonly CqlCode _Postoperative_follow_up_visit__normally_included_in_the_surgical_package__to_indicate_that_an_evaluation_and_management_service_was_performed_during_a_postoperative_period_for_a_reason_s__related_to_the_original_procedure = new CqlCode("99024", "http://www.ama-assn.org/go/cpt");

    [CqlCodeDefinition("Tobacco abuse counseling", codeId: "Z71.6", codeSystem: "http://hl7.org/fhir/sid/icd-10-cm")]
    public CqlCode Tobacco_abuse_counseling(CqlContext _) => _Tobacco_abuse_counseling;
    private static readonly CqlCode _Tobacco_abuse_counseling = new CqlCode("Z71.6", "http://hl7.org/fhir/sid/icd-10-cm");

    [CqlCodeDefinition("Unlisted preventive medicine service", codeId: "99429", codeSystem: "http://www.ama-assn.org/go/cpt")]
    public CqlCode Unlisted_preventive_medicine_service(CqlContext _) => _Unlisted_preventive_medicine_service;
    private static readonly CqlCode _Unlisted_preventive_medicine_service = new CqlCode("99429", "http://www.ama-assn.org/go/cpt");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("CPT")]
    public CqlCodeSystem CPT(CqlContext _) => _CPT;
    private static readonly CqlCodeSystem _CPT =
      new CqlCodeSystem("http://www.ama-assn.org/go/cpt", null,
          _Health_behavior_assessment__or_re_assessment__ie__health_focused_clinical_interview__behavioral_observations__clinical_decision_making_,
          _Health_behavior_intervention__individual__face_to_face__initial_30_minutes,
          _Postoperative_follow_up_visit__normally_included_in_the_surgical_package__to_indicate_that_an_evaluation_and_management_service_was_performed_during_a_postoperative_period_for_a_reason_s__related_to_the_original_procedure,
          _Unlisted_preventive_medicine_service);

    [CqlCodeSystemDefinition("ICD10CM")]
    public CqlCodeSystem ICD10CM(CqlContext _) => _ICD10CM;
    private static readonly CqlCodeSystem _ICD10CM =
      new CqlCodeSystem("http://hl7.org/fhir/sid/icd-10-cm", null,
          _Tobacco_abuse_counseling);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime yzzzzzzzzzzzzzzzx_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime yzzzzzzzzzzzzzzzy_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzz_ = context.Operators.Interval(yzzzzzzzzzzzzzzzx_, yzzzzzzzzzzzzzzzy_, true, true);
        object zzzzzzzzzzzzzzzza_ = context.ResolveParameter("PreventiveCareAndTobaccoUseScreeningAndCessationInterventionFHIR-0.0.001", "Measurement Period", yzzzzzzzzzzzzzzzz_);

        return (CqlInterval<CqlDateTime>)zzzzzzzzzzzzzzzza_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> zzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient zzzzzzzzzzzzzzzzc_ = context.Operators.SingletonFrom<Patient>(zzzzzzzzzzzzzzzzb_);

        return zzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Qualifying Visit During Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Visit_During_Measurement_Period(CqlContext context)
    {
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? zzzzzzzzzzzzzzzze_(Encounter E)
        {
            List<CodeableConcept> azzzzzzzzzzzzzzzzu_ = E?.Type;
            CqlConcept azzzzzzzzzzzzzzzzv_(CodeableConcept @this)
            {
                CqlConcept bzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return bzzzzzzzzzzzzzzzza_;
            };
            IEnumerable<CqlConcept> azzzzzzzzzzzzzzzzw_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)azzzzzzzzzzzzzzzzu_, azzzzzzzzzzzzzzzzv_);
            bool? azzzzzzzzzzzzzzzzx_(CqlConcept T)
            {
                CqlCode bzzzzzzzzzzzzzzzzb_ = this.Health_behavior_intervention__individual__face_to_face__initial_30_minutes(context);
                CqlConcept bzzzzzzzzzzzzzzzzc_ = context.Operators.ConvertCodeToConcept(bzzzzzzzzzzzzzzzzb_);
                bool? bzzzzzzzzzzzzzzzzd_ = context.Operators.Equivalent(T, bzzzzzzzzzzzzzzzzc_);

                return bzzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<CqlConcept> azzzzzzzzzzzzzzzzy_ = context.Operators.Where<CqlConcept>(azzzzzzzzzzzzzzzzw_, azzzzzzzzzzzzzzzzx_);
            bool? azzzzzzzzzzzzzzzzz_ = context.Operators.Exists<CqlConcept>(azzzzzzzzzzzzzzzzy_);

            return azzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzf_ = context.Operators.Where<Encounter>(zzzzzzzzzzzzzzzzd_, zzzzzzzzzzzzzzzze_);
        bool? zzzzzzzzzzzzzzzzh_(Encounter E)
        {
            List<CodeableConcept> bzzzzzzzzzzzzzzzze_ = E?.Type;
            CqlConcept bzzzzzzzzzzzzzzzzf_(CodeableConcept @this)
            {
                CqlConcept bzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return bzzzzzzzzzzzzzzzzk_;
            };
            IEnumerable<CqlConcept> bzzzzzzzzzzzzzzzzg_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)bzzzzzzzzzzzzzzzze_, bzzzzzzzzzzzzzzzzf_);
            bool? bzzzzzzzzzzzzzzzzh_(CqlConcept T)
            {
                CqlCode bzzzzzzzzzzzzzzzzl_ = this.Health_behavior_assessment__or_re_assessment__ie__health_focused_clinical_interview__behavioral_observations__clinical_decision_making_(context);
                CqlConcept bzzzzzzzzzzzzzzzzm_ = context.Operators.ConvertCodeToConcept(bzzzzzzzzzzzzzzzzl_);
                bool? bzzzzzzzzzzzzzzzzn_ = context.Operators.Equivalent(T, bzzzzzzzzzzzzzzzzm_);

                return bzzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<CqlConcept> bzzzzzzzzzzzzzzzzi_ = context.Operators.Where<CqlConcept>(bzzzzzzzzzzzzzzzzg_, bzzzzzzzzzzzzzzzzh_);
            bool? bzzzzzzzzzzzzzzzzj_ = context.Operators.Exists<CqlConcept>(bzzzzzzzzzzzzzzzzi_);

            return bzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzi_ = context.Operators.Where<Encounter>(zzzzzzzzzzzzzzzzd_, zzzzzzzzzzzzzzzzh_);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzj_ = context.Operators.Union<Encounter>(zzzzzzzzzzzzzzzzf_, zzzzzzzzzzzzzzzzi_);
        CqlValueSet zzzzzzzzzzzzzzzzk_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet zzzzzzzzzzzzzzzzm_ = this.Occupational_Therapy_Evaluation(context);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzo_ = context.Operators.Union<Encounter>(zzzzzzzzzzzzzzzzl_, zzzzzzzzzzzzzzzzn_);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzp_ = context.Operators.Union<Encounter>(zzzzzzzzzzzzzzzzj_, zzzzzzzzzzzzzzzzo_);
        CqlValueSet zzzzzzzzzzzzzzzzq_ = this.Office_Visit(context);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet zzzzzzzzzzzzzzzzs_ = this.Ophthalmological_Services(context);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzu_ = context.Operators.Union<Encounter>(zzzzzzzzzzzzzzzzr_, zzzzzzzzzzzzzzzzt_);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzv_ = context.Operators.Union<Encounter>(zzzzzzzzzzzzzzzzp_, zzzzzzzzzzzzzzzzu_);
        CqlValueSet zzzzzzzzzzzzzzzzw_ = this.Physical_Therapy_Evaluation(context);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet zzzzzzzzzzzzzzzzy_ = this.Psych_Visit_Diagnostic_Evaluation(context);
        IEnumerable<Encounter> zzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, zzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> azzzzzzzzzzzzzzzza_ = context.Operators.Union<Encounter>(zzzzzzzzzzzzzzzzx_, zzzzzzzzzzzzzzzzz_);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzb_ = context.Operators.Union<Encounter>(zzzzzzzzzzzzzzzzv_, azzzzzzzzzzzzzzzza_);
        CqlValueSet azzzzzzzzzzzzzzzzc_ = this.Psych_Visit_Psychotherapy(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet azzzzzzzzzzzzzzzze_ = this.Psychoanalysis(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzg_ = context.Operators.Union<Encounter>(azzzzzzzzzzzzzzzzd_, azzzzzzzzzzzzzzzzf_);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzh_ = context.Operators.Union<Encounter>(azzzzzzzzzzzzzzzzb_, azzzzzzzzzzzzzzzzg_);
        CqlValueSet azzzzzzzzzzzzzzzzi_ = this.Speech_and_Hearing_Evaluation(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet azzzzzzzzzzzzzzzzk_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzm_ = context.Operators.Union<Encounter>(azzzzzzzzzzzzzzzzj_, azzzzzzzzzzzzzzzzl_);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzn_ = context.Operators.Union<Encounter>(azzzzzzzzzzzzzzzzh_, azzzzzzzzzzzzzzzzm_);
        CqlValueSet azzzzzzzzzzzzzzzzo_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzq_ = context.Operators.Union<Encounter>(azzzzzzzzzzzzzzzzn_, azzzzzzzzzzzzzzzzp_);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzr_ = Status_1_8_000.Instance.isEncounterPerformed(context, azzzzzzzzzzzzzzzzq_);
        bool? azzzzzzzzzzzzzzzzs_(Encounter OfficeBasedEncounter)
        {
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzo_ = this.Measurement_Period(context);
            Period bzzzzzzzzzzzzzzzzp_ = OfficeBasedEncounter?.Period;
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzzzzzzq_ as object);
            bool? bzzzzzzzzzzzzzzzzs_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(bzzzzzzzzzzzzzzzzo_, bzzzzzzzzzzzzzzzzr_, "day");

            return bzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzt_ = context.Operators.Where<Encounter>(azzzzzzzzzzzzzzzzr_, azzzzzzzzzzzzzzzzs_);

        return azzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Preventive Visit During Measurement Period")]
    public IEnumerable<Encounter> Preventive_Visit_During_Measurement_Period(CqlContext context)
    {
        CqlValueSet bzzzzzzzzzzzzzzzzt_ = this.Annual_Wellness_Visit(context);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet bzzzzzzzzzzzzzzzzv_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzx_ = context.Operators.Union<Encounter>(bzzzzzzzzzzzzzzzzu_, bzzzzzzzzzzzzzzzzw_);
        CqlValueSet bzzzzzzzzzzzzzzzzy_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet czzzzzzzzzzzzzzzza_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, czzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzc_ = context.Operators.Union<Encounter>(bzzzzzzzzzzzzzzzzz_, czzzzzzzzzzzzzzzzb_);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzd_ = context.Operators.Union<Encounter>(bzzzzzzzzzzzzzzzzx_, czzzzzzzzzzzzzzzzc_);
        CqlValueSet czzzzzzzzzzzzzzzze_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, czzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet czzzzzzzzzzzzzzzzg_ = this.Preventive_Care_Services_Group_Counseling(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzi_ = context.Operators.Union<Encounter>(czzzzzzzzzzzzzzzzf_, czzzzzzzzzzzzzzzzh_);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzj_ = context.Operators.Union<Encounter>(czzzzzzzzzzzzzzzzd_, czzzzzzzzzzzzzzzzi_);
        CqlValueSet czzzzzzzzzzzzzzzzk_ = this.Preventive_Care_Services_Individual_Counseling(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? czzzzzzzzzzzzzzzzn_(Encounter E)
        {
            List<CodeableConcept> dzzzzzzzzzzzzzzzzb_ = E?.Type;
            CqlConcept dzzzzzzzzzzzzzzzzc_(CodeableConcept @this)
            {
                CqlConcept dzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return dzzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<CqlConcept> dzzzzzzzzzzzzzzzzd_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)dzzzzzzzzzzzzzzzzb_, dzzzzzzzzzzzzzzzzc_);
            bool? dzzzzzzzzzzzzzzzze_(CqlConcept T)
            {
                CqlCode dzzzzzzzzzzzzzzzzi_ = this.Unlisted_preventive_medicine_service(context);
                CqlConcept dzzzzzzzzzzzzzzzzj_ = context.Operators.ConvertCodeToConcept(dzzzzzzzzzzzzzzzzi_);
                bool? dzzzzzzzzzzzzzzzzk_ = context.Operators.Equivalent(T, dzzzzzzzzzzzzzzzzj_);

                return dzzzzzzzzzzzzzzzzk_;
            };
            IEnumerable<CqlConcept> dzzzzzzzzzzzzzzzzf_ = context.Operators.Where<CqlConcept>(dzzzzzzzzzzzzzzzzd_, dzzzzzzzzzzzzzzzze_);
            bool? dzzzzzzzzzzzzzzzzg_ = context.Operators.Exists<CqlConcept>(dzzzzzzzzzzzzzzzzf_);

            return dzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzo_ = context.Operators.Where<Encounter>(czzzzzzzzzzzzzzzzm_, czzzzzzzzzzzzzzzzn_);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzp_ = context.Operators.Union<Encounter>(czzzzzzzzzzzzzzzzl_, czzzzzzzzzzzzzzzzo_);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzq_ = context.Operators.Union<Encounter>(czzzzzzzzzzzzzzzzj_, czzzzzzzzzzzzzzzzp_);
        bool? czzzzzzzzzzzzzzzzs_(Encounter E)
        {
            List<CodeableConcept> dzzzzzzzzzzzzzzzzl_ = E?.Type;
            CqlConcept dzzzzzzzzzzzzzzzzm_(CodeableConcept @this)
            {
                CqlConcept dzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return dzzzzzzzzzzzzzzzzr_;
            };
            IEnumerable<CqlConcept> dzzzzzzzzzzzzzzzzn_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)dzzzzzzzzzzzzzzzzl_, dzzzzzzzzzzzzzzzzm_);
            bool? dzzzzzzzzzzzzzzzzo_(CqlConcept T)
            {
                CqlCode dzzzzzzzzzzzzzzzzs_ = this.Postoperative_follow_up_visit__normally_included_in_the_surgical_package__to_indicate_that_an_evaluation_and_management_service_was_performed_during_a_postoperative_period_for_a_reason_s__related_to_the_original_procedure(context);
                CqlConcept dzzzzzzzzzzzzzzzzt_ = context.Operators.ConvertCodeToConcept(dzzzzzzzzzzzzzzzzs_);
                bool? dzzzzzzzzzzzzzzzzu_ = context.Operators.Equivalent(T, dzzzzzzzzzzzzzzzzt_);

                return dzzzzzzzzzzzzzzzzu_;
            };
            IEnumerable<CqlConcept> dzzzzzzzzzzzzzzzzp_ = context.Operators.Where<CqlConcept>(dzzzzzzzzzzzzzzzzn_, dzzzzzzzzzzzzzzzzo_);
            bool? dzzzzzzzzzzzzzzzzq_ = context.Operators.Exists<CqlConcept>(dzzzzzzzzzzzzzzzzp_);

            return dzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzt_ = context.Operators.Where<Encounter>(czzzzzzzzzzzzzzzzm_, czzzzzzzzzzzzzzzzs_);
        CqlValueSet czzzzzzzzzzzzzzzzu_ = this.Nutrition_Services(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzw_ = context.Operators.Union<Encounter>(czzzzzzzzzzzzzzzzt_, czzzzzzzzzzzzzzzzv_);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzx_ = context.Operators.Union<Encounter>(czzzzzzzzzzzzzzzzq_, czzzzzzzzzzzzzzzzw_);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzy_ = Status_1_8_000.Instance.isEncounterPerformed(context, czzzzzzzzzzzzzzzzx_);
        bool? czzzzzzzzzzzzzzzzz_(Encounter PreventiveEncounter)
        {
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzv_ = this.Measurement_Period(context);
            Period dzzzzzzzzzzzzzzzzw_ = PreventiveEncounter?.Period;
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.toInterval(context, dzzzzzzzzzzzzzzzzx_ as object);
            bool? dzzzzzzzzzzzzzzzzz_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(dzzzzzzzzzzzzzzzzv_, dzzzzzzzzzzzzzzzzy_, "day");

            return dzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Encounter> dzzzzzzzzzzzzzzzza_ = context.Operators.Where<Encounter>(czzzzzzzzzzzzzzzzy_, czzzzzzzzzzzzzzzzz_);

        return dzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient ezzzzzzzzzzzzzzzza_ = this.Patient(context);
        Date ezzzzzzzzzzzzzzzzb_ = ezzzzzzzzzzzzzzzza_?.BirthDateElement;
        string ezzzzzzzzzzzzzzzzc_ = ezzzzzzzzzzzzzzzzb_?.Value;
        CqlDate ezzzzzzzzzzzzzzzzd_ = context.Operators.ConvertStringToDate(ezzzzzzzzzzzzzzzzc_);
        CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzze_ = this.Measurement_Period(context);
        CqlDateTime ezzzzzzzzzzzzzzzzf_ = context.Operators.Start(ezzzzzzzzzzzzzzzze_);
        CqlDate ezzzzzzzzzzzzzzzzg_ = context.Operators.DateFrom(ezzzzzzzzzzzzzzzzf_);
        int? ezzzzzzzzzzzzzzzzh_ = context.Operators.CalculateAgeAt(ezzzzzzzzzzzzzzzzd_, ezzzzzzzzzzzzzzzzg_, "year");
        bool? ezzzzzzzzzzzzzzzzi_ = context.Operators.GreaterOrEqual(ezzzzzzzzzzzzzzzzh_, 12);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzj_ = this.Qualifying_Visit_During_Measurement_Period(context);
        int? ezzzzzzzzzzzzzzzzk_ = context.Operators.Count<Encounter>(ezzzzzzzzzzzzzzzzj_);
        bool? ezzzzzzzzzzzzzzzzl_ = context.Operators.GreaterOrEqual(ezzzzzzzzzzzzzzzzk_, 2);
        IEnumerable<Encounter> ezzzzzzzzzzzzzzzzm_ = this.Preventive_Visit_During_Measurement_Period(context);
        bool? ezzzzzzzzzzzzzzzzn_ = context.Operators.Exists<Encounter>(ezzzzzzzzzzzzzzzzm_);
        bool? ezzzzzzzzzzzzzzzzo_ = context.Operators.Or(ezzzzzzzzzzzzzzzzl_, ezzzzzzzzzzzzzzzzn_);
        bool? ezzzzzzzzzzzzzzzzp_ = context.Operators.And(ezzzzzzzzzzzzzzzzi_, ezzzzzzzzzzzzzzzzo_);

        return ezzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Denominator 1")]
    public bool? Denominator_1(CqlContext context)
    {
        bool? ezzzzzzzzzzzzzzzzq_ = this.Initial_Population(context);

        return ezzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Most Recent Tobacco Use Screening Indicates Tobacco User")]
    public Observation Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_User(CqlContext context)
    {
        CqlValueSet ezzzzzzzzzzzzzzzzr_ = this.Tobacco_Use_Screening(context);
        IEnumerable<Observation> ezzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> ezzzzzzzzzzzzzzzzt_ = Status_1_8_000.Instance.isAssessmentPerformed(context, ezzzzzzzzzzzzzzzzs_);
        bool? ezzzzzzzzzzzzzzzzu_(Observation TobaccoUseScreening)
        {
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzd_ = this.Measurement_Period(context);
            DataType fzzzzzzzzzzzzzzzze_ = TobaccoUseScreening?.Effective;
            object fzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.toInterval(context, fzzzzzzzzzzzzzzzzf_);
            bool? fzzzzzzzzzzzzzzzzh_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(fzzzzzzzzzzzzzzzzd_, fzzzzzzzzzzzzzzzzg_, "day");

            return fzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Observation> ezzzzzzzzzzzzzzzzv_ = context.Operators.Where<Observation>(ezzzzzzzzzzzzzzzzt_, ezzzzzzzzzzzzzzzzu_);
        object ezzzzzzzzzzzzzzzzw_(Observation @this)
        {
            DataType fzzzzzzzzzzzzzzzzi_ = @this?.Effective;
            object fzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.toInterval(context, fzzzzzzzzzzzzzzzzj_);
            CqlDateTime fzzzzzzzzzzzzzzzzl_ = context.Operators.Start(fzzzzzzzzzzzzzzzzk_);

            return fzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Observation> ezzzzzzzzzzzzzzzzx_ = context.Operators.SortBy<Observation>(ezzzzzzzzzzzzzzzzv_, ezzzzzzzzzzzzzzzzw_, System.ComponentModel.ListSortDirection.Ascending);
        Observation ezzzzzzzzzzzzzzzzy_ = context.Operators.Last<Observation>(ezzzzzzzzzzzzzzzzx_);
        Observation[] ezzzzzzzzzzzzzzzzz_ = [
            ezzzzzzzzzzzzzzzzy_,
        ];
        bool? fzzzzzzzzzzzzzzzza_(Observation MostRecentTobaccoUseScreening)
        {
            DataType fzzzzzzzzzzzzzzzzm_ = MostRecentTobaccoUseScreening?.Value;
            object fzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzm_);
            CqlValueSet fzzzzzzzzzzzzzzzzo_ = this.Tobacco_User(context);
            bool? fzzzzzzzzzzzzzzzzp_ = context.Operators.ConceptInValueSet(fzzzzzzzzzzzzzzzzn_ as CqlConcept, fzzzzzzzzzzzzzzzzo_);

            return fzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Observation> fzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Observation>((IEnumerable<Observation>)ezzzzzzzzzzzzzzzzz_, fzzzzzzzzzzzzzzzza_);
        Observation fzzzzzzzzzzzzzzzzc_ = context.Operators.SingletonFrom<Observation>(fzzzzzzzzzzzzzzzzb_);

        return fzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Denominator 2")]
    public bool? Denominator_2(CqlContext context)
    {
        bool? fzzzzzzzzzzzzzzzzq_ = this.Initial_Population(context);
        Observation fzzzzzzzzzzzzzzzzr_ = this.Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_User(context);
        bool? fzzzzzzzzzzzzzzzzs_ = context.Operators.Not((bool?)(fzzzzzzzzzzzzzzzzr_ is null));
        bool? fzzzzzzzzzzzzzzzzt_ = context.Operators.And(fzzzzzzzzzzzzzzzzq_, fzzzzzzzzzzzzzzzzs_);

        return fzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Denominator 3")]
    public bool? Denominator_3(CqlContext context)
    {
        bool? fzzzzzzzzzzzzzzzzu_ = this.Initial_Population(context);

        return fzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Most Recent Tobacco Use Screening Indicates Tobacco Non User")]
    public Observation Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_Non_User(CqlContext context)
    {
        CqlValueSet fzzzzzzzzzzzzzzzzv_ = this.Tobacco_Use_Screening(context);
        IEnumerable<Observation> fzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> fzzzzzzzzzzzzzzzzx_ = Status_1_8_000.Instance.isAssessmentPerformed(context, fzzzzzzzzzzzzzzzzw_);
        bool? fzzzzzzzzzzzzzzzzy_(Observation TobaccoUseScreening)
        {
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzh_ = this.Measurement_Period(context);
            DataType gzzzzzzzzzzzzzzzzi_ = TobaccoUseScreening?.Effective;
            object gzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzzzzzzzzj_);
            bool? gzzzzzzzzzzzzzzzzl_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(gzzzzzzzzzzzzzzzzh_, gzzzzzzzzzzzzzzzzk_, "day");

            return gzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Observation> fzzzzzzzzzzzzzzzzz_ = context.Operators.Where<Observation>(fzzzzzzzzzzzzzzzzx_, fzzzzzzzzzzzzzzzzy_);
        object gzzzzzzzzzzzzzzzza_(Observation @this)
        {
            DataType gzzzzzzzzzzzzzzzzm_ = @this?.Effective;
            object gzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzzzzzzzzn_);
            CqlDateTime gzzzzzzzzzzzzzzzzp_ = context.Operators.Start(gzzzzzzzzzzzzzzzzo_);

            return gzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Observation> gzzzzzzzzzzzzzzzzb_ = context.Operators.SortBy<Observation>(fzzzzzzzzzzzzzzzzz_, gzzzzzzzzzzzzzzzza_, System.ComponentModel.ListSortDirection.Ascending);
        Observation gzzzzzzzzzzzzzzzzc_ = context.Operators.Last<Observation>(gzzzzzzzzzzzzzzzzb_);
        Observation[] gzzzzzzzzzzzzzzzzd_ = [
            gzzzzzzzzzzzzzzzzc_,
        ];
        bool? gzzzzzzzzzzzzzzzze_(Observation MostRecentTobaccoUseScreening)
        {
            DataType gzzzzzzzzzzzzzzzzq_ = MostRecentTobaccoUseScreening?.Value;
            object gzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzzzzq_);
            CqlValueSet gzzzzzzzzzzzzzzzzs_ = this.Tobacco_Non_User(context);
            bool? gzzzzzzzzzzzzzzzzt_ = context.Operators.ConceptInValueSet(gzzzzzzzzzzzzzzzzr_ as CqlConcept, gzzzzzzzzzzzzzzzzs_);

            return gzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Observation> gzzzzzzzzzzzzzzzzf_ = context.Operators.Where<Observation>((IEnumerable<Observation>)gzzzzzzzzzzzzzzzzd_, gzzzzzzzzzzzzzzzze_);
        Observation gzzzzzzzzzzzzzzzzg_ = context.Operators.SingletonFrom<Observation>(gzzzzzzzzzzzzzzzzf_);

        return gzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Numerator 1")]
    public bool? Numerator_1(CqlContext context)
    {
        Observation gzzzzzzzzzzzzzzzzu_ = this.Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_Non_User(context);
        bool? gzzzzzzzzzzzzzzzzv_ = context.Operators.Not((bool?)(gzzzzzzzzzzzzzzzzu_ is null));
        Observation gzzzzzzzzzzzzzzzzw_ = this.Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_User(context);
        bool? gzzzzzzzzzzzzzzzzx_ = context.Operators.Not((bool?)(gzzzzzzzzzzzzzzzzw_ is null));
        bool? gzzzzzzzzzzzzzzzzy_ = context.Operators.Or(gzzzzzzzzzzzzzzzzv_, gzzzzzzzzzzzzzzzzx_);

        return gzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Tobacco Cessation Counseling Given")]
    public IEnumerable<object> Tobacco_Cessation_Counseling_Given(CqlContext context)
    {
        CqlValueSet gzzzzzzzzzzzzzzzzz_ = this.Tobacco_Use_Cessation_Counseling(context);
        IEnumerable<Procedure> hzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> hzzzzzzzzzzzzzzzzb_ = Status_1_8_000.Instance.isInterventionPerformed(context, hzzzzzzzzzzzzzzzza_);
        bool? hzzzzzzzzzzzzzzzzc_(Procedure TobaccoCessationCounseling)
        {
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzk_ = this.Measurement_Period(context);
            CqlDateTime hzzzzzzzzzzzzzzzzl_ = context.Operators.Start(hzzzzzzzzzzzzzzzzk_);
            CqlQuantity hzzzzzzzzzzzzzzzzm_ = context.Operators.Quantity(6m, "months");
            CqlDateTime hzzzzzzzzzzzzzzzzn_ = context.Operators.Subtract(hzzzzzzzzzzzzzzzzl_, hzzzzzzzzzzzzzzzzm_);
            CqlDateTime hzzzzzzzzzzzzzzzzp_ = context.Operators.End(hzzzzzzzzzzzzzzzzk_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzq_ = context.Operators.Interval(hzzzzzzzzzzzzzzzzn_, hzzzzzzzzzzzzzzzzp_, true, true);
            DataType hzzzzzzzzzzzzzzzzr_ = TobaccoCessationCounseling?.Performed;
            object hzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.toInterval(context, hzzzzzzzzzzzzzzzzs_);
            bool? hzzzzzzzzzzzzzzzzu_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(hzzzzzzzzzzzzzzzzq_, hzzzzzzzzzzzzzzzzt_, "day");

            return hzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Procedure> hzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Procedure>(hzzzzzzzzzzzzzzzzb_, hzzzzzzzzzzzzzzzzc_);
        CqlCode hzzzzzzzzzzzzzzzze_ = this.Tobacco_abuse_counseling(context);
        IEnumerable<CqlCode> hzzzzzzzzzzzzzzzzf_ = context.Operators.ToList<CqlCode>(hzzzzzzzzzzzzzzzze_);
        IEnumerable<Condition> hzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, hzzzzzzzzzzzzzzzzf_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? hzzzzzzzzzzzzzzzzh_(Condition TobaccoCounseling)
        {
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, TobaccoCounseling);
            CqlDateTime hzzzzzzzzzzzzzzzzw_ = context.Operators.Start(hzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzx_ = this.Measurement_Period(context);
            CqlDateTime hzzzzzzzzzzzzzzzzy_ = context.Operators.Start(hzzzzzzzzzzzzzzzzx_);
            CqlQuantity hzzzzzzzzzzzzzzzzz_ = context.Operators.Quantity(6m, "months");
            CqlDateTime izzzzzzzzzzzzzzzza_ = context.Operators.Subtract(hzzzzzzzzzzzzzzzzy_, hzzzzzzzzzzzzzzzzz_);
            CqlDateTime izzzzzzzzzzzzzzzzc_ = context.Operators.End(hzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzd_ = context.Operators.Interval(izzzzzzzzzzzzzzzza_, izzzzzzzzzzzzzzzzc_, true, true);
            bool? izzzzzzzzzzzzzzzze_ = context.Operators.In<CqlDateTime>(hzzzzzzzzzzzzzzzzw_, izzzzzzzzzzzzzzzzd_, "day");

            return izzzzzzzzzzzzzzzze_;
        };
        IEnumerable<Condition> hzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Condition>(hzzzzzzzzzzzzzzzzg_, hzzzzzzzzzzzzzzzzh_);
        IEnumerable<object> hzzzzzzzzzzzzzzzzj_ = context.Operators.Union<object>(hzzzzzzzzzzzzzzzzd_ as IEnumerable<object>, hzzzzzzzzzzzzzzzzi_ as IEnumerable<object>);

        return hzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Tobacco Cessation Pharmacotherapy Ordered")]
    public IEnumerable<MedicationRequest> Tobacco_Cessation_Pharmacotherapy_Ordered(CqlContext context)
    {
        CqlValueSet izzzzzzzzzzzzzzzzf_ = this.Tobacco_Use_Cessation_Pharmacotherapy(context);
        IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, izzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, izzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzzj_ = context.Operators.Union<MedicationRequest>(izzzzzzzzzzzzzzzzg_, izzzzzzzzzzzzzzzzi_);
        IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzzk_ = Status_1_8_000.Instance.isMedicationOrder(context, izzzzzzzzzzzzzzzzj_);
        bool? izzzzzzzzzzzzzzzzl_(MedicationRequest CessationPharmacotherapyOrdered)
        {
            FhirDateTime izzzzzzzzzzzzzzzzn_ = CessationPharmacotherapyOrdered?.AuthoredOnElement;
            CqlDateTime izzzzzzzzzzzzzzzzo_ = context.Operators.Convert<CqlDateTime>(izzzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzp_ = this.Measurement_Period(context);
            CqlDateTime izzzzzzzzzzzzzzzzq_ = context.Operators.Start(izzzzzzzzzzzzzzzzp_);
            CqlQuantity izzzzzzzzzzzzzzzzr_ = context.Operators.Quantity(6m, "months");
            CqlDateTime izzzzzzzzzzzzzzzzs_ = context.Operators.Subtract(izzzzzzzzzzzzzzzzq_, izzzzzzzzzzzzzzzzr_);
            CqlDateTime izzzzzzzzzzzzzzzzu_ = context.Operators.End(izzzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzv_ = context.Operators.Interval(izzzzzzzzzzzzzzzzs_, izzzzzzzzzzzzzzzzu_, true, true);
            bool? izzzzzzzzzzzzzzzzw_ = context.Operators.In<CqlDateTime>(izzzzzzzzzzzzzzzzo_, izzzzzzzzzzzzzzzzv_, "day");

            return izzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzzm_ = context.Operators.Where<MedicationRequest>(izzzzzzzzzzzzzzzzk_, izzzzzzzzzzzzzzzzl_);

        return izzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Active Pharmacotherapy for Tobacco Cessation")]
    public IEnumerable<MedicationRequest> Active_Pharmacotherapy_for_Tobacco_Cessation(CqlContext context)
    {
        CqlValueSet izzzzzzzzzzzzzzzzx_ = this.Tobacco_Use_Cessation_Pharmacotherapy(context);
        IEnumerable<MedicationRequest> izzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, izzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> jzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, izzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> jzzzzzzzzzzzzzzzzb_ = context.Operators.Union<MedicationRequest>(izzzzzzzzzzzzzzzzy_, jzzzzzzzzzzzzzzzza_);
        IEnumerable<MedicationRequest> jzzzzzzzzzzzzzzzzc_ = Status_1_8_000.Instance.isMedicationActive(context, jzzzzzzzzzzzzzzzzb_);
        bool? jzzzzzzzzzzzzzzzzd_(MedicationRequest TakingCessationPharmacotherapy)
        {
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzf_ = this.Measurement_Period(context);
            CqlDateTime jzzzzzzzzzzzzzzzzg_ = context.Operators.Start(jzzzzzzzzzzzzzzzzf_);
            CqlQuantity jzzzzzzzzzzzzzzzzh_ = context.Operators.Quantity(6m, "months");
            CqlDateTime jzzzzzzzzzzzzzzzzi_ = context.Operators.Subtract(jzzzzzzzzzzzzzzzzg_, jzzzzzzzzzzzzzzzzh_);
            CqlDateTime jzzzzzzzzzzzzzzzzk_ = context.Operators.End(jzzzzzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzl_ = context.Operators.Interval(jzzzzzzzzzzzzzzzzi_, jzzzzzzzzzzzzzzzzk_, true, true);
            CqlInterval<CqlDate> jzzzzzzzzzzzzzzzzm_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, TakingCessationPharmacotherapy);
            CqlDate jzzzzzzzzzzzzzzzzn_ = jzzzzzzzzzzzzzzzzm_?.low;
            CqlDateTime jzzzzzzzzzzzzzzzzo_ = context.Operators.ConvertDateToDateTime(jzzzzzzzzzzzzzzzzn_);
            CqlDate jzzzzzzzzzzzzzzzzq_ = jzzzzzzzzzzzzzzzzm_?.high;
            CqlDateTime jzzzzzzzzzzzzzzzzr_ = context.Operators.ConvertDateToDateTime(jzzzzzzzzzzzzzzzzq_);
            bool? jzzzzzzzzzzzzzzzzt_ = jzzzzzzzzzzzzzzzzm_?.lowClosed;
            bool? jzzzzzzzzzzzzzzzzv_ = jzzzzzzzzzzzzzzzzm_?.highClosed;
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzw_ = context.Operators.Interval(jzzzzzzzzzzzzzzzzo_, jzzzzzzzzzzzzzzzzr_, jzzzzzzzzzzzzzzzzt_, jzzzzzzzzzzzzzzzzv_);
            bool? jzzzzzzzzzzzzzzzzx_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(jzzzzzzzzzzzzzzzzl_, jzzzzzzzzzzzzzzzzw_, "day");

            return jzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<MedicationRequest> jzzzzzzzzzzzzzzzze_ = context.Operators.Where<MedicationRequest>(jzzzzzzzzzzzzzzzzc_, jzzzzzzzzzzzzzzzzd_);

        return jzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Numerator 2")]
    public bool? Numerator_2(CqlContext context)
    {
        IEnumerable<object> jzzzzzzzzzzzzzzzzy_ = this.Tobacco_Cessation_Counseling_Given(context);
        bool? jzzzzzzzzzzzzzzzzz_ = context.Operators.Exists<object>(jzzzzzzzzzzzzzzzzy_);
        IEnumerable<MedicationRequest> kzzzzzzzzzzzzzzzza_ = this.Tobacco_Cessation_Pharmacotherapy_Ordered(context);
        bool? kzzzzzzzzzzzzzzzzb_ = context.Operators.Exists<MedicationRequest>(kzzzzzzzzzzzzzzzza_);
        bool? kzzzzzzzzzzzzzzzzc_ = context.Operators.Or(jzzzzzzzzzzzzzzzzz_, kzzzzzzzzzzzzzzzzb_);
        IEnumerable<MedicationRequest> kzzzzzzzzzzzzzzzzd_ = this.Active_Pharmacotherapy_for_Tobacco_Cessation(context);
        bool? kzzzzzzzzzzzzzzzze_ = context.Operators.Exists<MedicationRequest>(kzzzzzzzzzzzzzzzzd_);
        bool? kzzzzzzzzzzzzzzzzf_ = context.Operators.Or(kzzzzzzzzzzzzzzzzc_, kzzzzzzzzzzzzzzzze_);

        return kzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Numerator 3")]
    public bool? Numerator_3(CqlContext context)
    {
        Observation kzzzzzzzzzzzzzzzzg_ = this.Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_Non_User(context);
        bool? kzzzzzzzzzzzzzzzzh_ = context.Operators.Not((bool?)(kzzzzzzzzzzzzzzzzg_ is null));
        Observation kzzzzzzzzzzzzzzzzi_ = this.Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_User(context);
        bool? kzzzzzzzzzzzzzzzzj_ = context.Operators.Not((bool?)(kzzzzzzzzzzzzzzzzi_ is null));
        IEnumerable<object> kzzzzzzzzzzzzzzzzk_ = this.Tobacco_Cessation_Counseling_Given(context);
        bool? kzzzzzzzzzzzzzzzzl_ = context.Operators.Exists<object>(kzzzzzzzzzzzzzzzzk_);
        IEnumerable<MedicationRequest> kzzzzzzzzzzzzzzzzm_ = this.Tobacco_Cessation_Pharmacotherapy_Ordered(context);
        bool? kzzzzzzzzzzzzzzzzn_ = context.Operators.Exists<MedicationRequest>(kzzzzzzzzzzzzzzzzm_);
        bool? kzzzzzzzzzzzzzzzzo_ = context.Operators.Or(kzzzzzzzzzzzzzzzzl_, kzzzzzzzzzzzzzzzzn_);
        IEnumerable<MedicationRequest> kzzzzzzzzzzzzzzzzp_ = this.Active_Pharmacotherapy_for_Tobacco_Cessation(context);
        bool? kzzzzzzzzzzzzzzzzq_ = context.Operators.Exists<MedicationRequest>(kzzzzzzzzzzzzzzzzp_);
        bool? kzzzzzzzzzzzzzzzzr_ = context.Operators.Or(kzzzzzzzzzzzzzzzzo_, kzzzzzzzzzzzzzzzzq_);
        bool? kzzzzzzzzzzzzzzzzs_ = context.Operators.And(kzzzzzzzzzzzzzzzzj_, kzzzzzzzzzzzzzzzzr_);
        bool? kzzzzzzzzzzzzzzzzt_ = context.Operators.Or(kzzzzzzzzzzzzzzzzh_, kzzzzzzzzzzzzzzzzs_);

        return kzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Denominator Exclusion")]
    public bool? Denominator_Exclusion(CqlContext context)
    {
        bool? kzzzzzzzzzzzzzzzzu_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);

        return kzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? kzzzzzzzzzzzzzzzzv_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return kzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> kzzzzzzzzzzzzzzzzw_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return kzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? kzzzzzzzzzzzzzzzzx_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return kzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode kzzzzzzzzzzzzzzzzy_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return kzzzzzzzzzzzzzzzzy_;
    }


    #endregion Expressions

}
