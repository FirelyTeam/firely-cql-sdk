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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.8.0")]
[CqlLibrary("CMS138FHIRTobaccoScrnCessation", "1.0.000")]
public partial class CMS138FHIRTobaccoScrnCessation_1_0_000 : ILibrary, ISingleton<CMS138FHIRTobaccoScrnCessation_1_0_000>
{
    #region ValueSets (24)

    [CqlValueSetDefinition("Annual Wellness Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", valueSetVersion: null)]
    public CqlValueSet Annual_Wellness_Visit(CqlContext _) => _Annual_Wellness_Visit;
    private static readonly CqlValueSet _Annual_Wellness_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", null);

    [CqlValueSetDefinition("Home Healthcare Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", valueSetVersion: null)]
    public CqlValueSet Home_Healthcare_Services(CqlContext _) => _Home_Healthcare_Services;
    private static readonly CqlValueSet _Home_Healthcare_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);

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

    #region Codes (6)

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

    [CqlCodeDefinition("fulfill", codeId: "fulfill", codeSystem: "http://hl7.org/fhir/CodeSystem/task-code")]
    public CqlCode fulfill(CqlContext _) => _fulfill;
    private static readonly CqlCode _fulfill = new CqlCode("fulfill", "http://hl7.org/fhir/CodeSystem/task-code");

    #endregion Codes

    #region CodeSystems (3)

    [CqlCodeSystemDefinition("CPT", codeSystemId: "http://www.ama-assn.org/go/cpt", codeSystemVersion: null)]
    public CqlCodeSystem CPT(CqlContext _) => _CPT;
    private static readonly CqlCodeSystem _CPT =
      new CqlCodeSystem("http://www.ama-assn.org/go/cpt", null, [
          _Health_behavior_assessment__or_re_assessment__ie__health_focused_clinical_interview__behavioral_observations__clinical_decision_making_,
          _Health_behavior_intervention__individual__face_to_face__initial_30_minutes,
          _Postoperative_follow_up_visit__normally_included_in_the_surgical_package__to_indicate_that_an_evaluation_and_management_service_was_performed_during_a_postoperative_period_for_a_reason_s__related_to_the_original_procedure,
          _Unlisted_preventive_medicine_service]);

    [CqlCodeSystemDefinition("ICD10CM", codeSystemId: "http://hl7.org/fhir/sid/icd-10-cm", codeSystemVersion: null)]
    public CqlCodeSystem ICD10CM(CqlContext _) => _ICD10CM;
    private static readonly CqlCodeSystem _ICD10CM =
      new CqlCodeSystem("http://hl7.org/fhir/sid/icd-10-cm", null, [
          _Tobacco_abuse_counseling]);

    [CqlCodeSystemDefinition("TaskCode", codeSystemId: "http://hl7.org/fhir/CodeSystem/task-code", codeSystemVersion: null)]
    public CqlCodeSystem TaskCode(CqlContext _) => _TaskCode;
    private static readonly CqlCodeSystem _TaskCode =
      new CqlCodeSystem("http://hl7.org/fhir/CodeSystem/task-code", null, [
          _fulfill]);

    #endregion CodeSystems

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = -4959295622034925684L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("CMS138FHIRTobaccoScrnCessation-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (20)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = -7955012903259529784L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Qualifying Visit During Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Visit_During_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Qualifying_Visit_During_Measurement_Period, Qualifying_Visit_During_Measurement_Period_Compute);

    private const long _cacheIndex_Qualifying_Visit_During_Measurement_Period = 7177434960902520998L;

    private IEnumerable<Encounter> Qualifying_Visit_During_Measurement_Period_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

        bool? b_(Encounter E) {
            List<CodeableConcept> aq_ = E?.Type;

            CqlConcept ar_(CodeableConcept @this) {
                CqlConcept av_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return av_;
            }


            bool? as_(CqlConcept T) {
                CqlCode aw_ = this.Health_behavior_intervention__individual__face_to_face__initial_30_minutes(context);
                CqlConcept ax_ = context.Operators.ConvertCodeToConcept(aw_);
                bool? ay_ = context.Operators.Equivalent(T, ax_);
                return ay_;
            }

            IEnumerable<CqlConcept> at_ = context.Operators.SelectWhere<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)aq_, ar_, as_);
            bool? au_ = context.Operators.Exists<CqlConcept>(at_);
            return au_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        bool? d_(Encounter E) {
            List<CodeableConcept> az_ = E?.Type;

            CqlConcept ba_(CodeableConcept @this) {
                CqlConcept be_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return be_;
            }


            bool? bb_(CqlConcept T) {
                CqlCode bf_ = this.Health_behavior_assessment__or_re_assessment__ie__health_focused_clinical_interview__behavioral_observations__clinical_decision_making_(context);
                CqlConcept bg_ = context.Operators.ConvertCodeToConcept(bf_);
                bool? bh_ = context.Operators.Equivalent(T, bg_);
                return bh_;
            }

            IEnumerable<CqlConcept> bc_ = context.Operators.SelectWhere<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)az_, ba_, bb_);
            bool? bd_ = context.Operators.Exists<CqlConcept>(bc_);
            return bd_;
        }

        IEnumerable<Encounter> e_ = context.Operators.Where<Encounter>(a_, d_);
        IEnumerable<Encounter> f_ = context.Operators.Union<Encounter>(c_, e_);
        CqlValueSet g_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> h_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet i_ = this.Occupational_Therapy_Evaluation(context);
        IEnumerable<Encounter> j_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(h_, j_);
        IEnumerable<Encounter> l_ = context.Operators.Union<Encounter>(f_, k_);
        CqlValueSet m_ = this.Office_Visit(context);
        IEnumerable<Encounter> n_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, m_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet o_ = this.Ophthalmological_Services(context);
        IEnumerable<Encounter> p_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> q_ = context.Operators.Union<Encounter>(n_, p_);
        IEnumerable<Encounter> r_ = context.Operators.Union<Encounter>(l_, q_);
        CqlValueSet s_ = this.Physical_Therapy_Evaluation(context);
        IEnumerable<Encounter> t_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, s_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet u_ = this.Psych_Visit_Diagnostic_Evaluation(context);
        IEnumerable<Encounter> v_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, u_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> w_ = context.Operators.Union<Encounter>(t_, v_);
        IEnumerable<Encounter> x_ = context.Operators.Union<Encounter>(r_, w_);
        CqlValueSet y_ = this.Psych_Visit_Psychotherapy(context);
        IEnumerable<Encounter> z_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, y_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet aa_ = this.Psychoanalysis(context);
        IEnumerable<Encounter> ab_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, aa_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> ac_ = context.Operators.Union<Encounter>(z_, ab_);
        IEnumerable<Encounter> ad_ = context.Operators.Union<Encounter>(x_, ac_);
        CqlValueSet ae_ = this.Speech_and_Hearing_Evaluation(context);
        IEnumerable<Encounter> af_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ae_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet ag_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> ah_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ag_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> ai_ = context.Operators.Union<Encounter>(af_, ah_);
        IEnumerable<Encounter> aj_ = context.Operators.Union<Encounter>(ad_, ai_);
        CqlValueSet ak_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> al_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ak_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> am_ = context.Operators.Union<Encounter>(aj_, al_);
        IEnumerable<Encounter> an_ = Status_1_15_000.Instance.isEncounterPerformed(context, am_);

        bool? ao_(Encounter OfficeBasedEncounter) {
            CqlInterval<CqlDateTime> bi_ = this.Measurement_Period(context);
            Period bj_ = OfficeBasedEncounter?.Period;
            CqlInterval<CqlDateTime> bk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bj_);
            bool? bl_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(bi_, bk_, "day");
            return bl_;
        }

        IEnumerable<Encounter> ap_ = context.Operators.Where<Encounter>(an_, ao_);
        return ap_;
    }


    [CqlExpressionDefinition("Preventive Visit During Measurement Period")]
    public IEnumerable<Encounter> Preventive_Visit_During_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Preventive_Visit_During_Measurement_Period, Preventive_Visit_During_Measurement_Period_Compute);

    private const long _cacheIndex_Preventive_Visit_During_Measurement_Period = 5898871497816485333L;

    private IEnumerable<Encounter> Preventive_Visit_During_Measurement_Period_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Annual_Wellness_Visit(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet c_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
        CqlValueSet f_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet h_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> i_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
        CqlValueSet l_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> m_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet n_ = this.Preventive_Care_Services_Group_Counseling(context);
        IEnumerable<Encounter> o_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> p_ = context.Operators.Union<Encounter>(m_, o_);
        IEnumerable<Encounter> q_ = context.Operators.Union<Encounter>(k_, p_);
        CqlValueSet r_ = this.Preventive_Care_Services_Individual_Counseling(context);
        IEnumerable<Encounter> s_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> t_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

        bool? u_(Encounter E) {
            List<CodeableConcept> ah_ = E?.Type;

            CqlConcept ai_(CodeableConcept @this) {
                CqlConcept am_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return am_;
            }


            bool? aj_(CqlConcept T) {
                CqlCode an_ = this.Unlisted_preventive_medicine_service(context);
                CqlConcept ao_ = context.Operators.ConvertCodeToConcept(an_);
                bool? ap_ = context.Operators.Equivalent(T, ao_);
                return ap_;
            }

            IEnumerable<CqlConcept> ak_ = context.Operators.SelectWhere<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)ah_, ai_, aj_);
            bool? al_ = context.Operators.Exists<CqlConcept>(ak_);
            return al_;
        }

        IEnumerable<Encounter> v_ = context.Operators.Where<Encounter>(t_, u_);
        IEnumerable<Encounter> w_ = context.Operators.Union<Encounter>(s_, v_);
        IEnumerable<Encounter> x_ = context.Operators.Union<Encounter>(q_, w_);

        bool? y_(Encounter E) {
            List<CodeableConcept> aq_ = E?.Type;

            CqlConcept ar_(CodeableConcept @this) {
                CqlConcept av_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return av_;
            }


            bool? as_(CqlConcept T) {
                CqlCode aw_ = this.Postoperative_follow_up_visit__normally_included_in_the_surgical_package__to_indicate_that_an_evaluation_and_management_service_was_performed_during_a_postoperative_period_for_a_reason_s__related_to_the_original_procedure(context);
                CqlConcept ax_ = context.Operators.ConvertCodeToConcept(aw_);
                bool? ay_ = context.Operators.Equivalent(T, ax_);
                return ay_;
            }

            IEnumerable<CqlConcept> at_ = context.Operators.SelectWhere<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)aq_, ar_, as_);
            bool? au_ = context.Operators.Exists<CqlConcept>(at_);
            return au_;
        }

        IEnumerable<Encounter> z_ = context.Operators.Where<Encounter>(t_, y_);
        CqlValueSet aa_ = this.Nutrition_Services(context);
        IEnumerable<Encounter> ab_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, aa_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> ac_ = context.Operators.Union<Encounter>(z_, ab_);
        IEnumerable<Encounter> ad_ = context.Operators.Union<Encounter>(x_, ac_);
        IEnumerable<Encounter> ae_ = Status_1_15_000.Instance.isEncounterPerformed(context, ad_);

        bool? af_(Encounter PreventiveEncounter) {
            CqlInterval<CqlDateTime> az_ = this.Measurement_Period(context);
            Period ba_ = PreventiveEncounter?.Period;
            CqlInterval<CqlDateTime> bb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ba_);
            bool? bc_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(az_, bb_, "day");
            return bc_;
        }

        IEnumerable<Encounter> ag_ = context.Operators.Where<Encounter>(ae_, af_);
        return ag_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = 2669612615395309907L;

    private bool? Initial_Population_Compute(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Date b_ = a_?.BirthDateElement;
        string c_ = b_?.Value;
        CqlDate d_ = context.Operators.ConvertStringToDate(c_);
        CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
        CqlDateTime f_ = context.Operators.Start(e_);
        CqlDate g_ = context.Operators.DateFrom(f_);
        int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
        bool? i_ = context.Operators.GreaterOrEqual(h_, 12);
        IEnumerable<Encounter> j_ = this.Qualifying_Visit_During_Measurement_Period(context);
        int? k_ = context.Operators.Count<Encounter>(j_);
        bool? l_ = context.Operators.GreaterOrEqual(k_, 2);
        IEnumerable<Encounter> m_ = this.Preventive_Visit_During_Measurement_Period(context);
        bool? n_ = context.Operators.Exists<Encounter>(m_);
        bool? o_ = context.Operators.Or(l_, n_);
        bool? p_ = context.Operators.And(i_, o_);
        return p_;
    }


    [CqlExpressionDefinition("Denominator 1")]
    public bool? Denominator_1(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_1, Denominator_1_Compute);

    private const long _cacheIndex_Denominator_1 = -3285180068082547925L;

    private bool? Denominator_1_Compute(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlExpressionDefinition("Most Recent Tobacco Use Screening Indicates Tobacco User")]
    public Observation Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_User(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_User, Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_User_Compute);

    private const long _cacheIndex_Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_User = -2923731124351829025L;

    private Observation Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_User_Compute(CqlContext context)
    {
        IEnumerable<Observation> a_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-smokingstatus"));
        IEnumerable<Observation> b_ = Status_1_15_000.Instance.isObservationSmokingStatus(context, a_);

        bool? c_(Observation TobaccoUseScreening) {
            CqlInterval<CqlDateTime> l_ = this.Measurement_Period(context);
            DataType m_ = TobaccoUseScreening?.Effective;
            CqlDateTime n_ = context.Operators.LateBoundProperty<CqlDateTime>(m_, "value");
            CqlInterval<CqlDateTime> o_ = QICoreCommon_4_0_000.Instance.toInterval(context, n_);
            bool? p_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(l_, o_, "day");
            return p_;
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {
            DataType q_ = @this?.Effective;
            CqlDateTime r_ = context.Operators.LateBoundProperty<CqlDateTime>(q_, "value");
            CqlInterval<CqlDateTime> s_ = QICoreCommon_4_0_000.Instance.toInterval(context, r_);
            CqlDateTime t_ = context.Operators.Start(s_);
            return t_;
        }

        IEnumerable<Observation> f_ = context.Operators.SortBy<Observation>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
        Observation g_ = context.Operators.Last<Observation>(f_);
        Observation[] h_ = [
            g_,
        ];

        bool? i_(Observation MostRecentTobaccoUseScreening) {
            DataType u_ = MostRecentTobaccoUseScreening?.Value;
            object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
            CqlValueSet w_ = this.Tobacco_User(context);
            bool? x_ = context.Operators.ConceptInValueSet(v_ as CqlConcept, w_);
            return x_;
        }

        IEnumerable<Observation> j_ = context.Operators.Where<Observation>((IEnumerable<Observation>)h_, i_);
        Observation k_ = context.Operators.SingletonFrom<Observation>(j_);
        return k_;
    }


    [CqlExpressionDefinition("Denominator 2")]
    public bool? Denominator_2(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_2, Denominator_2_Compute);

    private const long _cacheIndex_Denominator_2 = -4662309398437711333L;

    private bool? Denominator_2_Compute(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);
        Observation b_ = this.Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_User(context);
        bool? c_ = context.Operators.Not((bool?)(b_ is null));
        bool? d_ = context.Operators.And(a_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Denominator 3")]
    public bool? Denominator_3(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_3, Denominator_3_Compute);

    private const long _cacheIndex_Denominator_3 = 3034990634367681347L;

    private bool? Denominator_3_Compute(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlExpressionDefinition("Most Recent Tobacco Use Screening Indicates Tobacco Non User")]
    public Observation Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_Non_User(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_Non_User, Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_Non_User_Compute);

    private const long _cacheIndex_Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_Non_User = 7185003250491743186L;

    private Observation Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_Non_User_Compute(CqlContext context)
    {
        IEnumerable<Observation> a_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-smokingstatus"));
        IEnumerable<Observation> b_ = Status_1_15_000.Instance.isObservationSmokingStatus(context, a_);

        bool? c_(Observation TobaccoUseScreening) {
            CqlInterval<CqlDateTime> l_ = this.Measurement_Period(context);
            DataType m_ = TobaccoUseScreening?.Effective;
            CqlDateTime n_ = context.Operators.LateBoundProperty<CqlDateTime>(m_, "value");
            CqlInterval<CqlDateTime> o_ = QICoreCommon_4_0_000.Instance.toInterval(context, n_);
            bool? p_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(l_, o_, "day");
            return p_;
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {
            DataType q_ = @this?.Effective;
            CqlDateTime r_ = context.Operators.LateBoundProperty<CqlDateTime>(q_, "value");
            CqlInterval<CqlDateTime> s_ = QICoreCommon_4_0_000.Instance.toInterval(context, r_);
            CqlDateTime t_ = context.Operators.Start(s_);
            return t_;
        }

        IEnumerable<Observation> f_ = context.Operators.SortBy<Observation>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
        Observation g_ = context.Operators.Last<Observation>(f_);
        Observation[] h_ = [
            g_,
        ];

        bool? i_(Observation MostRecentTobaccoUseScreening) {
            DataType u_ = MostRecentTobaccoUseScreening?.Value;
            object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
            CqlValueSet w_ = this.Tobacco_Non_User(context);
            bool? x_ = context.Operators.ConceptInValueSet(v_ as CqlConcept, w_);
            return x_;
        }

        IEnumerable<Observation> j_ = context.Operators.Where<Observation>((IEnumerable<Observation>)h_, i_);
        Observation k_ = context.Operators.SingletonFrom<Observation>(j_);
        return k_;
    }


    [CqlExpressionDefinition("Numerator 1")]
    public bool? Numerator_1(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator_1, Numerator_1_Compute);

    private const long _cacheIndex_Numerator_1 = -4578886531463750730L;

    private bool? Numerator_1_Compute(CqlContext context)
    {
        Observation a_ = this.Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_Non_User(context);
        bool? b_ = context.Operators.Not((bool?)(a_ is null));
        Observation c_ = this.Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_User(context);
        bool? d_ = context.Operators.Not((bool?)(c_ is null));
        bool? e_ = context.Operators.Or(b_, d_);
        return e_;
    }


    [CqlExpressionDefinition("Tobacco Cessation Counseling Given")]
    public IEnumerable<object> Tobacco_Cessation_Counseling_Given(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Tobacco_Cessation_Counseling_Given, Tobacco_Cessation_Counseling_Given_Compute);

    private const long _cacheIndex_Tobacco_Cessation_Counseling_Given = -1233005595140781584L;

    private IEnumerable<object> Tobacco_Cessation_Counseling_Given_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Tobacco_Use_Cessation_Counseling(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> c_ = Status_1_15_000.Instance.isInterventionPerformed(context, b_);

        bool? d_(Procedure TobaccoCessationCounseling) {
            CqlInterval<CqlDateTime> o_ = this.Measurement_Period(context);
            CqlDateTime p_ = context.Operators.Start(o_);
            CqlQuantity q_ = context.Operators.Quantity(6m, "months");
            CqlDateTime r_ = context.Operators.Subtract(p_, q_);
            CqlDateTime s_ = context.Operators.End(o_);
            CqlInterval<CqlDateTime> t_ = context.Operators.Interval(r_, s_, true, true);
            object u_;
            DataType x_ = TobaccoCessationCounseling?.Performed;
            object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
            bool z_ = y_ is CqlDateTime;
            if (z_)
            {
                DataType aa_ = TobaccoCessationCounseling?.Performed;
                object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                u_ = ab_ as CqlDateTime;
            }
            else
            {
                DataType ac_ = TobaccoCessationCounseling?.Performed;
                object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                bool ae_ = ad_ is CqlQuantity;
                if (ae_)
                {
                    DataType af_ = TobaccoCessationCounseling?.Performed;
                    object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                    u_ = ag_ as CqlQuantity;
                }
                else
                {
                    DataType ah_ = TobaccoCessationCounseling?.Performed;
                    object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                    bool aj_ = ai_ is CqlInterval<CqlDateTime>;
                    if (aj_)
                    {
                        DataType ak_ = TobaccoCessationCounseling?.Performed;
                        object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                        u_ = al_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType am_ = TobaccoCessationCounseling?.Performed;
                        object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                        bool ao_ = an_ is CqlInterval<CqlQuantity>;
                        if (ao_)
                        {
                            DataType ap_ = TobaccoCessationCounseling?.Performed;
                            object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                            u_ = aq_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            u_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> v_ = QICoreCommon_4_0_000.Instance.toInterval(context, u_);
            bool? w_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(t_, v_, "day");
            return w_;
        }

        IEnumerable<Procedure> e_ = context.Operators.Where<Procedure>(c_, d_);
        CqlCode f_ = this.Tobacco_abuse_counseling(context);
        IEnumerable<CqlCode> g_ = context.Operators.ToList<CqlCode>(f_);
        IEnumerable<Condition> h_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, g_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> i_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, g_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> j_ = context.Operators.Union<Condition>(h_ as IEnumerable<Condition>, i_ as IEnumerable<Condition>);
        IEnumerable<Condition> k_ = Status_1_15_000.Instance.verified(context, j_);

        bool? l_(Condition TobaccoCounseling) {
            CqlInterval<CqlDateTime> ar_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, TobaccoCounseling);
            CqlDateTime as_ = context.Operators.Start(ar_);
            CqlInterval<CqlDateTime> at_ = this.Measurement_Period(context);
            CqlDateTime au_ = context.Operators.Start(at_);
            CqlQuantity av_ = context.Operators.Quantity(6m, "months");
            CqlDateTime aw_ = context.Operators.Subtract(au_, av_);
            CqlDateTime ax_ = context.Operators.End(at_);
            CqlInterval<CqlDateTime> ay_ = context.Operators.Interval(aw_, ax_, true, true);
            bool? az_ = context.Operators.In<CqlDateTime>(as_, ay_, "day");
            return az_;
        }

        IEnumerable<Condition> m_ = context.Operators.Where<Condition>(k_, l_);
        IEnumerable<object> n_ = context.Operators.Union<object>(e_ as IEnumerable<object>, m_ as IEnumerable<object>);
        return n_;
    }


    [CqlExpressionDefinition("Tobacco Cessation Pharmacotherapy Ordered")]
    public IEnumerable<MedicationRequest> Tobacco_Cessation_Pharmacotherapy_Ordered(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Tobacco_Cessation_Pharmacotherapy_Ordered, Tobacco_Cessation_Pharmacotherapy_Ordered_Compute);

    private const long _cacheIndex_Tobacco_Cessation_Pharmacotherapy_Ordered = -8673418154702639994L;

    private IEnumerable<MedicationRequest> Tobacco_Cessation_Pharmacotherapy_Ordered_Compute(CqlContext context)
    {
        IEnumerable<MedicationRequest> a_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? b_(MedicationRequest MR) {
            IEnumerable<Medication> j_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? k_(Medication M) {
                object m_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object n_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> o_ = context.Operators.Split((string)n_, "/");
                string p_ = context.Operators.Last<string>(o_);
                bool? q_ = context.Operators.Equal(m_, p_);
                CodeableConcept r_ = M?.Code;
                CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, r_);
                CqlValueSet t_ = this.Tobacco_Use_Cessation_Pharmacotherapy(context);
                bool? u_ = context.Operators.ConceptInValueSet(s_, t_);
                bool? v_ = context.Operators.And(q_, u_);
                return v_;
            }

            bool? l_ = context.Operators.WhereAny<Medication>(j_, k_);
            return l_;
        }

        IEnumerable<MedicationRequest> c_ = context.Operators.Where<MedicationRequest>(a_, b_);
        CqlValueSet d_ = this.Tobacco_Use_Cessation_Pharmacotherapy(context);
        IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(c_, e_);
        IEnumerable<MedicationRequest> g_ = Status_1_15_000.Instance.isMedicationOrder(context, f_);

        bool? h_(MedicationRequest CessationPharmacotherapyOrdered) {
            FhirDateTime w_ = CessationPharmacotherapyOrdered?.AuthoredOnElement;
            CqlDateTime x_ = context.Operators.Convert<CqlDateTime>(w_);
            CqlInterval<CqlDateTime> y_ = this.Measurement_Period(context);
            CqlDateTime z_ = context.Operators.Start(y_);
            CqlQuantity aa_ = context.Operators.Quantity(6m, "months");
            CqlDateTime ab_ = context.Operators.Subtract(z_, aa_);
            CqlDateTime ac_ = context.Operators.End(y_);
            CqlInterval<CqlDateTime> ad_ = context.Operators.Interval(ab_, ac_, true, true);
            bool? ae_ = context.Operators.In<CqlDateTime>(x_, ad_, "day");
            IEnumerable<Task> af_ = context.Operators.Retrieve<Task>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-taskrejected"));

            bool? ag_(Task TaskReject) {
                ResourceReference ak_ = TaskReject?.Focus;
                bool? al_ = QICoreCommon_4_0_000.Instance.references(context, ak_, CessationPharmacotherapyOrdered);
                CodeableConcept am_ = TaskReject?.Code;
                CqlConcept an_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, am_);
                CqlCode ao_ = this.fulfill(context);
                CqlConcept ap_ = context.Operators.ConvertCodeToConcept(ao_);
                bool? aq_ = context.Operators.Equivalent(an_, ap_);
                bool? ar_ = context.Operators.And(al_, aq_);
                return ar_;
            }

            bool? ah_ = context.Operators.WhereAny<Task>(af_, ag_);
            bool? ai_ = context.Operators.Not(ah_);
            bool? aj_ = context.Operators.And(ae_, ai_);
            return aj_;
        }

        IEnumerable<MedicationRequest> i_ = context.Operators.Where<MedicationRequest>(g_, h_);
        return i_;
    }


    [CqlExpressionDefinition("Active Pharmacotherapy for Tobacco Cessation")]
    public IEnumerable<MedicationRequest> Active_Pharmacotherapy_for_Tobacco_Cessation(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Active_Pharmacotherapy_for_Tobacco_Cessation, Active_Pharmacotherapy_for_Tobacco_Cessation_Compute);

    private const long _cacheIndex_Active_Pharmacotherapy_for_Tobacco_Cessation = -4580032638158646680L;

    private IEnumerable<MedicationRequest> Active_Pharmacotherapy_for_Tobacco_Cessation_Compute(CqlContext context)
    {
        IEnumerable<MedicationRequest> a_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? b_(MedicationRequest MR) {
            IEnumerable<Medication> j_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? k_(Medication M) {
                object m_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object n_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> o_ = context.Operators.Split((string)n_, "/");
                string p_ = context.Operators.Last<string>(o_);
                bool? q_ = context.Operators.Equal(m_, p_);
                CodeableConcept r_ = M?.Code;
                CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, r_);
                CqlValueSet t_ = this.Tobacco_Use_Cessation_Pharmacotherapy(context);
                bool? u_ = context.Operators.ConceptInValueSet(s_, t_);
                bool? v_ = context.Operators.And(q_, u_);
                return v_;
            }

            bool? l_ = context.Operators.WhereAny<Medication>(j_, k_);
            return l_;
        }

        IEnumerable<MedicationRequest> c_ = context.Operators.Where<MedicationRequest>(a_, b_);
        CqlValueSet d_ = this.Tobacco_Use_Cessation_Pharmacotherapy(context);
        IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(c_, e_);
        IEnumerable<MedicationRequest> g_ = Status_1_15_000.Instance.isMedicationActive(context, f_);

        bool? h_(MedicationRequest TakingCessationPharmacotherapy) {
            CqlInterval<CqlDateTime> w_ = this.Measurement_Period(context);
            CqlDateTime x_ = context.Operators.Start(w_);
            CqlQuantity y_ = context.Operators.Quantity(6m, "months");
            CqlDateTime z_ = context.Operators.Subtract(x_, y_);
            CqlDateTime aa_ = context.Operators.End(w_);
            CqlInterval<CqlDateTime> ab_ = context.Operators.Interval(z_, aa_, true, true);
            CqlInterval<CqlDate> ac_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, TakingCessationPharmacotherapy);
            CqlDate ad_ = ac_?.low;
            CqlDateTime ae_ = context.Operators.ConvertDateToDateTime(ad_);
            CqlDate af_ = ac_?.high;
            CqlDateTime ag_ = context.Operators.ConvertDateToDateTime(af_);
            bool? ah_ = ac_?.lowClosed;
            bool? ai_ = ac_?.highClosed;
            CqlInterval<CqlDateTime> aj_ = context.Operators.Interval(ae_, ag_, ah_, ai_);
            bool? ak_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ab_, aj_, "day");
            return ak_;
        }

        IEnumerable<MedicationRequest> i_ = context.Operators.Where<MedicationRequest>(g_, h_);
        return i_;
    }


    [CqlExpressionDefinition("Numerator 2")]
    public bool? Numerator_2(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator_2, Numerator_2_Compute);

    private const long _cacheIndex_Numerator_2 = -8558024697869650102L;

    private bool? Numerator_2_Compute(CqlContext context)
    {
        IEnumerable<object> a_ = this.Tobacco_Cessation_Counseling_Given(context);
        bool? b_ = context.Operators.Exists<object>(a_);
        IEnumerable<MedicationRequest> c_ = this.Tobacco_Cessation_Pharmacotherapy_Ordered(context);
        bool? d_ = context.Operators.Exists<MedicationRequest>(c_);
        bool? e_ = context.Operators.Or(b_, d_);
        IEnumerable<MedicationRequest> f_ = this.Active_Pharmacotherapy_for_Tobacco_Cessation(context);
        bool? g_ = context.Operators.Exists<MedicationRequest>(f_);
        bool? h_ = context.Operators.Or(e_, g_);
        return h_;
    }


    [CqlExpressionDefinition("Numerator 3")]
    public bool? Numerator_3(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator_3, Numerator_3_Compute);

    private const long _cacheIndex_Numerator_3 = -1812779733273017819L;

    private bool? Numerator_3_Compute(CqlContext context)
    {
        Observation a_ = this.Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_Non_User(context);
        bool? b_ = context.Operators.Not((bool?)(a_ is null));
        Observation c_ = this.Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_User(context);
        bool? d_ = context.Operators.Not((bool?)(c_ is null));
        IEnumerable<object> e_ = this.Tobacco_Cessation_Counseling_Given(context);
        bool? f_ = context.Operators.Exists<object>(e_);
        IEnumerable<MedicationRequest> g_ = this.Tobacco_Cessation_Pharmacotherapy_Ordered(context);
        bool? h_ = context.Operators.Exists<MedicationRequest>(g_);
        bool? i_ = context.Operators.Or(f_, h_);
        IEnumerable<MedicationRequest> j_ = this.Active_Pharmacotherapy_for_Tobacco_Cessation(context);
        bool? k_ = context.Operators.Exists<MedicationRequest>(j_);
        bool? l_ = context.Operators.Or(i_, k_);
        bool? m_ = context.Operators.And(d_, l_);
        bool? n_ = context.Operators.Or(b_, m_);
        return n_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exclusions, Denominator_Exclusions_Compute);

    private const long _cacheIndex_Denominator_Exclusions = -6310344248357646308L;

    private bool? Denominator_Exclusions_Compute(CqlContext context)
    {
        bool? a_ = Hospice_6_18_000.Instance.Has_Hospice_Services(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = -1836264205076716889L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = -3692462481776107665L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = 2422896220304669821L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = 4364689585748560777L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private CMS138FHIRTobaccoScrnCessation_1_0_000() {}

    public static CMS138FHIRTobaccoScrnCessation_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS138FHIRTobaccoScrnCessation";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [Status_1_15_000.Instance, FHIRHelpers_4_4_000.Instance, SupplementalDataElements_5_1_000.Instance, QICoreCommon_4_0_000.Instance, Hospice_6_18_000.Instance, CumulativeMedicationDuration_6_0_000.Instance];

    #endregion ILibrary Implementation

}
