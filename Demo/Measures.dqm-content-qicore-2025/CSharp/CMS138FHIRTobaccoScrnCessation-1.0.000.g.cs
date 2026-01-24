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
using Hl7.Cql.Runtime.Internal;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "6.0.0.0")]
[CqlLibrary("CMS138FHIRTobaccoScrnCessation", "1.0.000")]
public partial class CMS138FHIRTobaccoScrnCessation_1_0_000 : ILibrary, ILibraryInternals, ISingleton<CMS138FHIRTobaccoScrnCessation_1_0_000>
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

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Qualifying Visit During Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Visit_During_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Qualifying_Visit_During_Measurement_Period, Qualifying_Visit_During_Measurement_Period_Compute);

    private IEnumerable<Encounter> Qualifying_Visit_During_Measurement_Period_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

        bool? b_(Encounter E) {
            List<CodeableConcept> ar_ = E?.Type;

            CqlConcept as_(CodeableConcept @this) {
                CqlConcept ax_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return ax_;
            }

            IEnumerable<CqlConcept> at_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)ar_, as_);

            bool? au_(CqlConcept T) {
                CqlCode ay_ = this.Health_behavior_intervention__individual__face_to_face__initial_30_minutes(context);
                CqlConcept az_ = context.Operators.ConvertCodeToConcept(ay_);
                bool? ba_ = context.Operators.Equivalent(T, az_);
                return ba_;
            }

            IEnumerable<CqlConcept> av_ = context.Operators.Where<CqlConcept>(at_, au_);
            bool? aw_ = context.Operators.Exists<CqlConcept>(av_);
            return aw_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        bool? e_(Encounter E) {
            List<CodeableConcept> bb_ = E?.Type;

            CqlConcept bc_(CodeableConcept @this) {
                CqlConcept bh_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return bh_;
            }

            IEnumerable<CqlConcept> bd_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)bb_, bc_);

            bool? be_(CqlConcept T) {
                CqlCode bi_ = this.Health_behavior_assessment__or_re_assessment__ie__health_focused_clinical_interview__behavioral_observations__clinical_decision_making_(context);
                CqlConcept bj_ = context.Operators.ConvertCodeToConcept(bi_);
                bool? bk_ = context.Operators.Equivalent(T, bj_);
                return bk_;
            }

            IEnumerable<CqlConcept> bf_ = context.Operators.Where<CqlConcept>(bd_, be_);
            bool? bg_ = context.Operators.Exists<CqlConcept>(bf_);
            return bg_;
        }

        IEnumerable<Encounter> f_ = context.Operators.Where<Encounter>(a_, e_);
        IEnumerable<Encounter> g_ = context.Operators.Union<Encounter>(c_, f_);
        CqlValueSet h_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> i_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet j_ = this.Occupational_Therapy_Evaluation(context);
        IEnumerable<Encounter> k_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, j_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> l_ = context.Operators.Union<Encounter>(i_, k_);
        IEnumerable<Encounter> m_ = context.Operators.Union<Encounter>(g_, l_);
        CqlValueSet n_ = this.Office_Visit(context);
        IEnumerable<Encounter> o_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet p_ = this.Ophthalmological_Services(context);
        IEnumerable<Encounter> q_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, p_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> r_ = context.Operators.Union<Encounter>(o_, q_);
        IEnumerable<Encounter> s_ = context.Operators.Union<Encounter>(m_, r_);
        CqlValueSet t_ = this.Physical_Therapy_Evaluation(context);
        IEnumerable<Encounter> u_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, t_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet v_ = this.Psych_Visit_Diagnostic_Evaluation(context);
        IEnumerable<Encounter> w_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, v_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> x_ = context.Operators.Union<Encounter>(u_, w_);
        IEnumerable<Encounter> y_ = context.Operators.Union<Encounter>(s_, x_);
        CqlValueSet z_ = this.Psych_Visit_Psychotherapy(context);
        IEnumerable<Encounter> aa_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, z_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet ab_ = this.Psychoanalysis(context);
        IEnumerable<Encounter> ac_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ab_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> ad_ = context.Operators.Union<Encounter>(aa_, ac_);
        IEnumerable<Encounter> ae_ = context.Operators.Union<Encounter>(y_, ad_);
        CqlValueSet af_ = this.Speech_and_Hearing_Evaluation(context);
        IEnumerable<Encounter> ag_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, af_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet ah_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> ai_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ah_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> aj_ = context.Operators.Union<Encounter>(ag_, ai_);
        IEnumerable<Encounter> ak_ = context.Operators.Union<Encounter>(ae_, aj_);
        CqlValueSet al_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> am_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, al_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> an_ = context.Operators.Union<Encounter>(ak_, am_);
        IEnumerable<Encounter> ao_ = Status_1_15_000.Instance.isEncounterPerformed(context, an_);

        bool? ap_(Encounter OfficeBasedEncounter) {
            CqlInterval<CqlDateTime> bl_ = this.Measurement_Period(context);
            Period bm_ = OfficeBasedEncounter?.Period;
            CqlInterval<CqlDateTime> bn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bm_);
            bool? bo_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(bl_, bn_, "day");
            return bo_;
        }

        IEnumerable<Encounter> aq_ = context.Operators.Where<Encounter>(ao_, ap_);
        return aq_;
    }


    [CqlExpressionDefinition("Preventive Visit During Measurement Period")]
    public IEnumerable<Encounter> Preventive_Visit_During_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Preventive_Visit_During_Measurement_Period, Preventive_Visit_During_Measurement_Period_Compute);

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
            List<CodeableConcept> ai_ = E?.Type;

            CqlConcept aj_(CodeableConcept @this) {
                CqlConcept ao_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return ao_;
            }

            IEnumerable<CqlConcept> ak_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)ai_, aj_);

            bool? al_(CqlConcept T) {
                CqlCode ap_ = this.Unlisted_preventive_medicine_service(context);
                CqlConcept aq_ = context.Operators.ConvertCodeToConcept(ap_);
                bool? ar_ = context.Operators.Equivalent(T, aq_);
                return ar_;
            }

            IEnumerable<CqlConcept> am_ = context.Operators.Where<CqlConcept>(ak_, al_);
            bool? an_ = context.Operators.Exists<CqlConcept>(am_);
            return an_;
        }

        IEnumerable<Encounter> v_ = context.Operators.Where<Encounter>(t_, u_);
        IEnumerable<Encounter> w_ = context.Operators.Union<Encounter>(s_, v_);
        IEnumerable<Encounter> x_ = context.Operators.Union<Encounter>(q_, w_);

        bool? z_(Encounter E) {
            List<CodeableConcept> as_ = E?.Type;

            CqlConcept at_(CodeableConcept @this) {
                CqlConcept ay_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return ay_;
            }

            IEnumerable<CqlConcept> au_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)as_, at_);

            bool? av_(CqlConcept T) {
                CqlCode az_ = this.Postoperative_follow_up_visit__normally_included_in_the_surgical_package__to_indicate_that_an_evaluation_and_management_service_was_performed_during_a_postoperative_period_for_a_reason_s__related_to_the_original_procedure(context);
                CqlConcept ba_ = context.Operators.ConvertCodeToConcept(az_);
                bool? bb_ = context.Operators.Equivalent(T, ba_);
                return bb_;
            }

            IEnumerable<CqlConcept> aw_ = context.Operators.Where<CqlConcept>(au_, av_);
            bool? ax_ = context.Operators.Exists<CqlConcept>(aw_);
            return ax_;
        }

        IEnumerable<Encounter> aa_ = context.Operators.Where<Encounter>(t_, z_);
        CqlValueSet ab_ = this.Nutrition_Services(context);
        IEnumerable<Encounter> ac_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ab_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> ad_ = context.Operators.Union<Encounter>(aa_, ac_);
        IEnumerable<Encounter> ae_ = context.Operators.Union<Encounter>(x_, ad_);
        IEnumerable<Encounter> af_ = Status_1_15_000.Instance.isEncounterPerformed(context, ae_);

        bool? ag_(Encounter PreventiveEncounter) {
            CqlInterval<CqlDateTime> bc_ = this.Measurement_Period(context);
            Period bd_ = PreventiveEncounter?.Period;
            CqlInterval<CqlDateTime> be_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bd_);
            bool? bf_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(bc_, be_, "day");
            return bf_;
        }

        IEnumerable<Encounter> ah_ = context.Operators.Where<Encounter>(af_, ag_);
        return ah_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

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

    private bool? Denominator_1_Compute(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlExpressionDefinition("Most Recent Tobacco Use Screening Indicates Tobacco User")]
    public Observation Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_User(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_User, Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_User_Compute);

    private Observation Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_User_Compute(CqlContext context)
    {
        IEnumerable<Observation> a_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-smokingstatus"));
        IEnumerable<Observation> b_ = Status_1_15_000.Instance.isObservationSmokingStatus(context, a_);

        bool? c_(Observation TobaccoUseScreening) {
            CqlInterval<CqlDateTime> l_ = this.Measurement_Period(context);
            DataType m_ = TobaccoUseScreening?.Effective;
            CqlDateTime n_ = context.Operators.LateBoundProperty<CqlDateTime>(m_, "value");
            CqlInterval<CqlDateTime> o_ = QICoreCommon_4_0_000.Instance.toInterval(context, n_ as object);
            bool? p_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(l_, o_, "day");
            return p_;
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {
            DataType q_ = @this?.Effective;
            CqlDateTime r_ = context.Operators.LateBoundProperty<CqlDateTime>(q_, "value");
            CqlInterval<CqlDateTime> s_ = QICoreCommon_4_0_000.Instance.toInterval(context, r_ as object);
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

    private bool? Denominator_3_Compute(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlExpressionDefinition("Most Recent Tobacco Use Screening Indicates Tobacco Non User")]
    public Observation Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_Non_User(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_Non_User, Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_Non_User_Compute);

    private Observation Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_Non_User_Compute(CqlContext context)
    {
        IEnumerable<Observation> a_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-smokingstatus"));
        IEnumerable<Observation> b_ = Status_1_15_000.Instance.isObservationSmokingStatus(context, a_);

        bool? c_(Observation TobaccoUseScreening) {
            CqlInterval<CqlDateTime> l_ = this.Measurement_Period(context);
            DataType m_ = TobaccoUseScreening?.Effective;
            CqlDateTime n_ = context.Operators.LateBoundProperty<CqlDateTime>(m_, "value");
            CqlInterval<CqlDateTime> o_ = QICoreCommon_4_0_000.Instance.toInterval(context, n_ as object);
            bool? p_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(l_, o_, "day");
            return p_;
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

        object e_(Observation @this) {
            DataType q_ = @this?.Effective;
            CqlDateTime r_ = context.Operators.LateBoundProperty<CqlDateTime>(q_, "value");
            CqlInterval<CqlDateTime> s_ = QICoreCommon_4_0_000.Instance.toInterval(context, r_ as object);
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

    private IEnumerable<object> Tobacco_Cessation_Counseling_Given_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Tobacco_Use_Cessation_Counseling(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> c_ = Status_1_15_000.Instance.isInterventionPerformed(context, b_);

        bool? d_(Procedure TobaccoCessationCounseling) {
            CqlInterval<CqlDateTime> q_ = this.Measurement_Period(context);
            CqlDateTime r_ = context.Operators.Start(q_);
            CqlQuantity s_ = context.Operators.Quantity(6m, "months");
            CqlDateTime t_ = context.Operators.Subtract(r_, s_);
            CqlDateTime v_ = context.Operators.End(q_);
            CqlInterval<CqlDateTime> w_ = context.Operators.Interval(t_, v_, true, true);

            object x_() {

                bool aa_() {
                    DataType ae_ = TobaccoCessationCounseling?.Performed;
                    object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                    bool ag_ = af_ is CqlDateTime;
                    return ag_;
                }


                bool ab_() {
                    DataType ah_ = TobaccoCessationCounseling?.Performed;
                    object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                    bool aj_ = ai_ is CqlInterval<CqlDateTime>;
                    return aj_;
                }


                bool ac_() {
                    DataType ak_ = TobaccoCessationCounseling?.Performed;
                    object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                    bool am_ = al_ is CqlQuantity;
                    return am_;
                }


                bool ad_() {
                    DataType an_ = TobaccoCessationCounseling?.Performed;
                    object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                    bool ap_ = ao_ is CqlInterval<CqlQuantity>;
                    return ap_;
                }

                if (aa_())
                {
                    DataType aq_ = TobaccoCessationCounseling?.Performed;
                    object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                    return (ar_ as CqlDateTime) as object;
                }
                else if (ab_())
                {
                    DataType as_ = TobaccoCessationCounseling?.Performed;
                    object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                    return (at_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (ac_())
                {
                    DataType au_ = TobaccoCessationCounseling?.Performed;
                    object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                    return (av_ as CqlQuantity) as object;
                }
                else if (ad_())
                {
                    DataType aw_ = TobaccoCessationCounseling?.Performed;
                    object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                    return (ax_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> y_ = QICoreCommon_4_0_000.Instance.toInterval(context, x_());
            bool? z_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(w_, y_, "day");
            return z_;
        }

        IEnumerable<Procedure> e_ = context.Operators.Where<Procedure>(c_, d_);
        CqlCode f_ = this.Tobacco_abuse_counseling(context);
        IEnumerable<CqlCode> g_ = context.Operators.ToList<CqlCode>(f_);
        IEnumerable<Condition> h_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, g_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<CqlCode> j_ = context.Operators.ToList<CqlCode>(f_);
        IEnumerable<Condition> k_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, j_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<object> l_ = context.Operators.Union<object>(h_ as IEnumerable<object>, k_ as IEnumerable<object>);
        IEnumerable<object> m_ = Status_1_15_000.Instance.verified(context, l_);

        bool? n_(object TobaccoCounseling) {
            CqlInterval<CqlDateTime> ay_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, TobaccoCounseling);
            CqlDateTime az_ = context.Operators.Start(ay_);
            CqlInterval<CqlDateTime> ba_ = this.Measurement_Period(context);
            CqlDateTime bb_ = context.Operators.Start(ba_);
            CqlQuantity bc_ = context.Operators.Quantity(6m, "months");
            CqlDateTime bd_ = context.Operators.Subtract(bb_, bc_);
            CqlDateTime bf_ = context.Operators.End(ba_);
            CqlInterval<CqlDateTime> bg_ = context.Operators.Interval(bd_, bf_, true, true);
            bool? bh_ = context.Operators.In<CqlDateTime>(az_, bg_, "day");
            return bh_;
        }

        IEnumerable<object> o_ = context.Operators.Where<object>(m_, n_);
        IEnumerable<object> p_ = context.Operators.Union<object>(e_ as IEnumerable<object>, o_ as IEnumerable<object>);
        return p_;
    }


    [CqlExpressionDefinition("Tobacco Cessation Pharmacotherapy Ordered")]
    public IEnumerable<MedicationRequest> Tobacco_Cessation_Pharmacotherapy_Ordered(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Tobacco_Cessation_Pharmacotherapy_Ordered, Tobacco_Cessation_Pharmacotherapy_Ordered_Compute);

    private IEnumerable<MedicationRequest> Tobacco_Cessation_Pharmacotherapy_Ordered_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Tobacco_Use_Cessation_Pharmacotherapy(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> c_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        IEnumerable<MedicationRequest> d_(MedicationRequest MR) {
            IEnumerable<Medication> j_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? k_(Medication M) {
                object o_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object p_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> q_ = context.Operators.Split((string)p_, "/");
                string r_ = context.Operators.Last<string>(q_);
                bool? s_ = context.Operators.Equal(o_, r_);
                CodeableConcept t_ = M?.Code;
                CqlConcept u_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, t_);
                CqlValueSet v_ = this.Tobacco_Use_Cessation_Pharmacotherapy(context);
                bool? w_ = context.Operators.ConceptInValueSet(u_, v_);
                bool? x_ = context.Operators.And(s_, w_);
                return x_;
            }

            IEnumerable<Medication> l_ = context.Operators.Where<Medication>(j_, k_);
            MedicationRequest m_(Medication M) => MR;
            IEnumerable<MedicationRequest> n_ = context.Operators.Select<Medication, MedicationRequest>(l_, m_);
            return n_;
        }

        IEnumerable<MedicationRequest> e_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, d_);
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(b_, e_);
        IEnumerable<MedicationRequest> g_ = Status_1_15_000.Instance.isMedicationOrder(context, f_);

        bool? h_(MedicationRequest CessationPharmacotherapyOrdered) {
            FhirDateTime y_ = CessationPharmacotherapyOrdered?.AuthoredOnElement;
            CqlDateTime z_ = context.Operators.Convert<CqlDateTime>(y_);
            CqlInterval<CqlDateTime> aa_ = this.Measurement_Period(context);
            CqlDateTime ab_ = context.Operators.Start(aa_);
            CqlQuantity ac_ = context.Operators.Quantity(6m, "months");
            CqlDateTime ad_ = context.Operators.Subtract(ab_, ac_);
            CqlDateTime af_ = context.Operators.End(aa_);
            CqlInterval<CqlDateTime> ag_ = context.Operators.Interval(ad_, af_, true, true);
            bool? ah_ = context.Operators.In<CqlDateTime>(z_, ag_, "day");
            IEnumerable<Task> ai_ = context.Operators.Retrieve<Task>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-taskrejected"));

            bool? aj_(Task TaskReject) {
                ResourceReference ao_ = TaskReject?.Focus;
                bool? ap_ = QICoreCommon_4_0_000.Instance.references(context, ao_, CessationPharmacotherapyOrdered);
                CodeableConcept aq_ = TaskReject?.Code;
                CqlConcept ar_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, aq_);
                CqlCode as_ = this.fulfill(context);
                CqlConcept at_ = context.Operators.ConvertCodeToConcept(as_);
                bool? au_ = context.Operators.Equivalent(ar_, at_);
                bool? av_ = context.Operators.And(ap_, au_);
                return av_;
            }

            IEnumerable<Task> ak_ = context.Operators.Where<Task>(ai_, aj_);
            bool? al_ = context.Operators.Exists<Task>(ak_);
            bool? am_ = context.Operators.Not(al_);
            bool? an_ = context.Operators.And(ah_, am_);
            return an_;
        }

        IEnumerable<MedicationRequest> i_ = context.Operators.Where<MedicationRequest>(g_, h_);
        return i_;
    }


    [CqlExpressionDefinition("Active Pharmacotherapy for Tobacco Cessation")]
    public IEnumerable<MedicationRequest> Active_Pharmacotherapy_for_Tobacco_Cessation(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Active_Pharmacotherapy_for_Tobacco_Cessation, Active_Pharmacotherapy_for_Tobacco_Cessation_Compute);

    private IEnumerable<MedicationRequest> Active_Pharmacotherapy_for_Tobacco_Cessation_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Tobacco_Use_Cessation_Pharmacotherapy(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> c_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        IEnumerable<MedicationRequest> d_(MedicationRequest MR) {
            IEnumerable<Medication> j_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? k_(Medication M) {
                object o_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object p_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> q_ = context.Operators.Split((string)p_, "/");
                string r_ = context.Operators.Last<string>(q_);
                bool? s_ = context.Operators.Equal(o_, r_);
                CodeableConcept t_ = M?.Code;
                CqlConcept u_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, t_);
                CqlValueSet v_ = this.Tobacco_Use_Cessation_Pharmacotherapy(context);
                bool? w_ = context.Operators.ConceptInValueSet(u_, v_);
                bool? x_ = context.Operators.And(s_, w_);
                return x_;
            }

            IEnumerable<Medication> l_ = context.Operators.Where<Medication>(j_, k_);
            MedicationRequest m_(Medication M) => MR;
            IEnumerable<MedicationRequest> n_ = context.Operators.Select<Medication, MedicationRequest>(l_, m_);
            return n_;
        }

        IEnumerable<MedicationRequest> e_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, d_);
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(b_, e_);
        IEnumerable<MedicationRequest> g_ = Status_1_15_000.Instance.isMedicationActive(context, f_);

        bool? h_(MedicationRequest TakingCessationPharmacotherapy) {
            CqlInterval<CqlDateTime> y_ = this.Measurement_Period(context);
            CqlDateTime z_ = context.Operators.Start(y_);
            CqlQuantity aa_ = context.Operators.Quantity(6m, "months");
            CqlDateTime ab_ = context.Operators.Subtract(z_, aa_);
            CqlDateTime ad_ = context.Operators.End(y_);
            CqlInterval<CqlDateTime> ae_ = context.Operators.Interval(ab_, ad_, true, true);
            CqlInterval<CqlDate> af_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, TakingCessationPharmacotherapy);
            CqlDate ag_ = af_?.low;
            CqlDateTime ah_ = context.Operators.ConvertDateToDateTime(ag_);
            CqlDate aj_ = af_?.high;
            CqlDateTime ak_ = context.Operators.ConvertDateToDateTime(aj_);
            bool? am_ = af_?.lowClosed;
            bool? ao_ = af_?.highClosed;
            CqlInterval<CqlDateTime> ap_ = context.Operators.Interval(ah_, ak_, am_, ao_);
            bool? aq_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ae_, ap_, "day");
            return aq_;
        }

        IEnumerable<MedicationRequest> i_ = context.Operators.Where<MedicationRequest>(g_, h_);
        return i_;
    }


    [CqlExpressionDefinition("Numerator 2")]
    public bool? Numerator_2(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator_2, Numerator_2_Compute);

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

    private bool? Denominator_Exclusions_Compute(CqlContext context)
    {
        bool? a_ = Hospice_6_18_000.Instance.Has_Hospice_Services(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    #endregion Functions and Expressions

    #region Cache Index Fields (21)

    private int _cacheIndex_Measurement_Period = -1;
    private int _cacheIndex_Patient = -1;
    private int _cacheIndex_Qualifying_Visit_During_Measurement_Period = -1;
    private int _cacheIndex_Preventive_Visit_During_Measurement_Period = -1;
    private int _cacheIndex_Initial_Population = -1;
    private int _cacheIndex_Denominator_1 = -1;
    private int _cacheIndex_Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_User = -1;
    private int _cacheIndex_Denominator_2 = -1;
    private int _cacheIndex_Denominator_3 = -1;
    private int _cacheIndex_Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_Non_User = -1;
    private int _cacheIndex_Numerator_1 = -1;
    private int _cacheIndex_Tobacco_Cessation_Counseling_Given = -1;
    private int _cacheIndex_Tobacco_Cessation_Pharmacotherapy_Ordered = -1;
    private int _cacheIndex_Active_Pharmacotherapy_for_Tobacco_Cessation = -1;
    private int _cacheIndex_Numerator_2 = -1;
    private int _cacheIndex_Numerator_3 = -1;
    private int _cacheIndex_Denominator_Exclusions = -1;
    private int _cacheIndex_SDE_Ethnicity = -1;
    private int _cacheIndex_SDE_Payer = -1;
    private int _cacheIndex_SDE_Race = -1;
    private int _cacheIndex_SDE_Sex = -1;

    #endregion Cache Index Fields

    #region ILibraryInternals Implementation

    /// <summary>
    /// Initializes cache indices for this library's cached expressions.
    /// </summary>
    /// <param name="libraryInvocationSet">The library invocation set performing initialization.</param>
    /// <param name="startIndex">The starting index for cache field assignment.</param>
    /// <returns>The number of cache indices initialized (number of cached expressions in this library).</returns>
    int ILibraryInternals.InitializeCacheIndices(
        CqlLibraryInvocationSet libraryInvocationSet,
        int startIndex)
    {
        var index = startIndex;
        _cacheIndex_Measurement_Period = index++;
        _cacheIndex_Patient = index++;
        _cacheIndex_Qualifying_Visit_During_Measurement_Period = index++;
        _cacheIndex_Preventive_Visit_During_Measurement_Period = index++;
        _cacheIndex_Initial_Population = index++;
        _cacheIndex_Denominator_1 = index++;
        _cacheIndex_Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_User = index++;
        _cacheIndex_Denominator_2 = index++;
        _cacheIndex_Denominator_3 = index++;
        _cacheIndex_Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_Non_User = index++;
        _cacheIndex_Numerator_1 = index++;
        _cacheIndex_Tobacco_Cessation_Counseling_Given = index++;
        _cacheIndex_Tobacco_Cessation_Pharmacotherapy_Ordered = index++;
        _cacheIndex_Active_Pharmacotherapy_for_Tobacco_Cessation = index++;
        _cacheIndex_Numerator_2 = index++;
        _cacheIndex_Numerator_3 = index++;
        _cacheIndex_Denominator_Exclusions = index++;
        _cacheIndex_SDE_Ethnicity = index++;
        _cacheIndex_SDE_Payer = index++;
        _cacheIndex_SDE_Race = index++;
        _cacheIndex_SDE_Sex = index++;
        return index - startIndex;
    }

    #endregion ILibraryInternals Implementation

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
