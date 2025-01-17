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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.11.0")]
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

    #region Definition Methods

    [CqlDeclaration("Annual Wellness Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240")]
    public CqlValueSet Annual_Wellness_Visit(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", default);


    [CqlDeclaration("Home Healthcare Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016")]
    public CqlValueSet Home_Healthcare_Services(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", default);


    [CqlDeclaration("Limited Life Expectancy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1259")]
    public CqlValueSet Limited_Life_Expectancy(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1259", default);


    [CqlDeclaration("Medical Reason")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007")]
    public CqlValueSet Medical_Reason(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007", default);


    [CqlDeclaration("Nutrition Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1006")]
    public CqlValueSet Nutrition_Services(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1006", default);


    [CqlDeclaration("Occupational Therapy Evaluation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1011")]
    public CqlValueSet Occupational_Therapy_Evaluation(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1011", default);


    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
    public CqlValueSet Office_Visit(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", default);


    [CqlDeclaration("Ophthalmological Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285")]
    public CqlValueSet Ophthalmological_Services(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285", default);


    [CqlDeclaration("Physical Therapy Evaluation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1022")]
    public CqlValueSet Physical_Therapy_Evaluation(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1022", default);


    [CqlDeclaration("Preventive Care Services Established Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025")]
    public CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", default);


    [CqlDeclaration("Preventive Care Services Group Counseling")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1027")]
    public CqlValueSet Preventive_Care_Services_Group_Counseling(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1027", default);


    [CqlDeclaration("Preventive Care Services Individual Counseling")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026")]
    public CqlValueSet Preventive_Care_Services_Individual_Counseling(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026", default);


    [CqlDeclaration("Preventive Care Services Initial Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023")]
    public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", default);


    [CqlDeclaration("Preventive Care Services, Initial Office Visit, 0 to 17")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022")]
    public CqlValueSet Preventive_Care_Services__Initial_Office_Visit__0_to_17(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", default);


    [CqlDeclaration("Preventive Care, Established Office Visit, 0 to 17")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024")]
    public CqlValueSet Preventive_Care__Established_Office_Visit__0_to_17(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", default);


    [CqlDeclaration("Psych Visit Diagnostic Evaluation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1492")]
    public CqlValueSet Psych_Visit_Diagnostic_Evaluation(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1492", default);


    [CqlDeclaration("Psych Visit Psychotherapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1496")]
    public CqlValueSet Psych_Visit_Psychotherapy(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1496", default);


    [CqlDeclaration("Psychoanalysis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1141")]
    public CqlValueSet Psychoanalysis(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1141", default);


    [CqlDeclaration("Speech and Hearing Evaluation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1530")]
    public CqlValueSet Speech_and_Hearing_Evaluation(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1530", default);


    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
    public CqlValueSet Telephone_Visits(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", default);


    [CqlDeclaration("Tobacco Non User")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1189")]
    public CqlValueSet Tobacco_Non_User(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1189", default);


    [CqlDeclaration("Tobacco Use Cessation Counseling")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.509")]
    public CqlValueSet Tobacco_Use_Cessation_Counseling(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.509", default);


    [CqlDeclaration("Tobacco Use Cessation Pharmacotherapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1190")]
    public CqlValueSet Tobacco_Use_Cessation_Pharmacotherapy(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1190", default);


    [CqlDeclaration("Tobacco Use Screening")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1278")]
    public CqlValueSet Tobacco_Use_Screening(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1278", default);


    [CqlDeclaration("Tobacco User")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1170")]
    public CqlValueSet Tobacco_User(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1170", default);


    [CqlDeclaration("Virtual Encounter")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089")]
    public CqlValueSet Virtual_Encounter(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", default);


    [CqlDeclaration("Health behavior assessment, or re-assessment (ie, health-focused clinical interview, behavioral observations, clinical decision making)")]
    public CqlCode Health_behavior_assessment__or_re_assessment__ie__health_focused_clinical_interview__behavioral_observations__clinical_decision_making_(CqlContext context) =>
        new CqlCode("96156", "http://www.ama-assn.org/go/cpt", default, default);


    [CqlDeclaration("Health behavior intervention, individual, face-to-face; initial 30 minutes")]
    public CqlCode Health_behavior_intervention__individual__face_to_face__initial_30_minutes(CqlContext context) =>
        new CqlCode("96158", "http://www.ama-assn.org/go/cpt", default, default);


    [CqlDeclaration("Postoperative follow-up visit, normally included in the surgical package, to indicate that an evaluation and management service was performed during a postoperative period for a reason(s) related to the original procedure")]
    public CqlCode Postoperative_follow_up_visit__normally_included_in_the_surgical_package__to_indicate_that_an_evaluation_and_management_service_was_performed_during_a_postoperative_period_for_a_reason_s__related_to_the_original_procedure(CqlContext context) =>
        new CqlCode("99024", "http://www.ama-assn.org/go/cpt", default, default);


    [CqlDeclaration("Tobacco abuse counseling")]
    public CqlCode Tobacco_abuse_counseling(CqlContext context) =>
        new CqlCode("Z71.6", "http://hl7.org/fhir/sid/icd-10-cm", default, default);


    [CqlDeclaration("Unlisted preventive medicine service")]
    public CqlCode Unlisted_preventive_medicine_service(CqlContext context) =>
        new CqlCode("99429", "http://www.ama-assn.org/go/cpt", default, default);


    [CqlDeclaration("CPT")]
    public CqlCode[] CPT(CqlContext context)
    {
        CqlCode[] a_ = [
            new CqlCode("96156", "http://www.ama-assn.org/go/cpt", default, default),
            new CqlCode("96158", "http://www.ama-assn.org/go/cpt", default, default),
            new CqlCode("99024", "http://www.ama-assn.org/go/cpt", default, default),
            new CqlCode("99429", "http://www.ama-assn.org/go/cpt", default, default),
        ];

        return a_;
    }


    [CqlDeclaration("ICD10CM")]
    public CqlCode[] ICD10CM(CqlContext context)
    {
        CqlCode[] a_ = [
            new CqlCode("Z71.6", "http://hl7.org/fhir/sid/icd-10-cm", default, default),
        ];

        return a_;
    }


    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, true);
        object d_ = context.ResolveParameter("PreventiveCareAndTobaccoUseScreeningAndCessationInterventionFHIR-0.0.001", "Measurement Period", c_);

        return (CqlInterval<CqlDateTime>)d_;
    }


    [CqlDeclaration("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

        return b_;
    }


    [CqlDeclaration("Qualifying Visit During Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Visit_During_Measurement_Period(CqlContext context)
    {
        IEnumerable<Encounter> a_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? b_(Encounter E)
        {
            List<CodeableConcept> ar_ = E?.Type;
            CqlConcept as_(CodeableConcept @this)
            {
                CqlConcept ax_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return ax_;
            };
            IEnumerable<CqlConcept> at_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)ar_, as_);
            bool? au_(CqlConcept T)
            {
                CqlCode ay_ = this.Health_behavior_intervention__individual__face_to_face__initial_30_minutes(context);
                CqlConcept az_ = context.Operators.ConvertCodeToConcept(ay_);
                bool? ba_ = context.Operators.Equivalent(T, az_);

                return ba_;
            };
            IEnumerable<CqlConcept> av_ = context.Operators.Where<CqlConcept>(at_, au_);
            bool? aw_ = context.Operators.Exists<CqlConcept>(av_);

            return aw_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        bool? e_(Encounter E)
        {
            List<CodeableConcept> bb_ = E?.Type;
            CqlConcept bc_(CodeableConcept @this)
            {
                CqlConcept bh_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return bh_;
            };
            IEnumerable<CqlConcept> bd_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)bb_, bc_);
            bool? be_(CqlConcept T)
            {
                CqlCode bi_ = this.Health_behavior_assessment__or_re_assessment__ie__health_focused_clinical_interview__behavioral_observations__clinical_decision_making_(context);
                CqlConcept bj_ = context.Operators.ConvertCodeToConcept(bi_);
                bool? bk_ = context.Operators.Equivalent(T, bj_);

                return bk_;
            };
            IEnumerable<CqlConcept> bf_ = context.Operators.Where<CqlConcept>(bd_, be_);
            bool? bg_ = context.Operators.Exists<CqlConcept>(bf_);

            return bg_;
        };
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
        IEnumerable<Encounter> ao_ = Status_1_8_000.Instance.isEncounterPerformed(context, an_);
        bool? ap_(Encounter OfficeBasedEncounter)
        {
            CqlInterval<CqlDateTime> bl_ = this.Measurement_Period(context);
            Period bm_ = OfficeBasedEncounter?.Period;
            CqlInterval<CqlDateTime> bn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bm_);
            CqlInterval<CqlDateTime> bo_ = QICoreCommon_2_1_000.Instance.toInterval(context, bn_ as object);
            bool? bp_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(bl_, bo_, "day");

            return bp_;
        };
        IEnumerable<Encounter> aq_ = context.Operators.Where<Encounter>(ao_, ap_);

        return aq_;
    }


    [CqlDeclaration("Preventive Visit During Measurement Period")]
    public IEnumerable<Encounter> Preventive_Visit_During_Measurement_Period(CqlContext context)
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
        bool? u_(Encounter E)
        {
            List<CodeableConcept> ai_ = E?.Type;
            CqlConcept aj_(CodeableConcept @this)
            {
                CqlConcept ao_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return ao_;
            };
            IEnumerable<CqlConcept> ak_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)ai_, aj_);
            bool? al_(CqlConcept T)
            {
                CqlCode ap_ = this.Unlisted_preventive_medicine_service(context);
                CqlConcept aq_ = context.Operators.ConvertCodeToConcept(ap_);
                bool? ar_ = context.Operators.Equivalent(T, aq_);

                return ar_;
            };
            IEnumerable<CqlConcept> am_ = context.Operators.Where<CqlConcept>(ak_, al_);
            bool? an_ = context.Operators.Exists<CqlConcept>(am_);

            return an_;
        };
        IEnumerable<Encounter> v_ = context.Operators.Where<Encounter>(t_, u_);
        IEnumerable<Encounter> w_ = context.Operators.Union<Encounter>(s_, v_);
        IEnumerable<Encounter> x_ = context.Operators.Union<Encounter>(q_, w_);
        bool? z_(Encounter E)
        {
            List<CodeableConcept> as_ = E?.Type;
            CqlConcept at_(CodeableConcept @this)
            {
                CqlConcept ay_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return ay_;
            };
            IEnumerable<CqlConcept> au_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)as_, at_);
            bool? av_(CqlConcept T)
            {
                CqlCode az_ = this.Postoperative_follow_up_visit__normally_included_in_the_surgical_package__to_indicate_that_an_evaluation_and_management_service_was_performed_during_a_postoperative_period_for_a_reason_s__related_to_the_original_procedure(context);
                CqlConcept ba_ = context.Operators.ConvertCodeToConcept(az_);
                bool? bb_ = context.Operators.Equivalent(T, ba_);

                return bb_;
            };
            IEnumerable<CqlConcept> aw_ = context.Operators.Where<CqlConcept>(au_, av_);
            bool? ax_ = context.Operators.Exists<CqlConcept>(aw_);

            return ax_;
        };
        IEnumerable<Encounter> aa_ = context.Operators.Where<Encounter>(t_, z_);
        CqlValueSet ab_ = this.Nutrition_Services(context);
        IEnumerable<Encounter> ac_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ab_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> ad_ = context.Operators.Union<Encounter>(aa_, ac_);
        IEnumerable<Encounter> ae_ = context.Operators.Union<Encounter>(x_, ad_);
        IEnumerable<Encounter> af_ = Status_1_8_000.Instance.isEncounterPerformed(context, ae_);
        bool? ag_(Encounter PreventiveEncounter)
        {
            CqlInterval<CqlDateTime> bc_ = this.Measurement_Period(context);
            Period bd_ = PreventiveEncounter?.Period;
            CqlInterval<CqlDateTime> be_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bd_);
            CqlInterval<CqlDateTime> bf_ = QICoreCommon_2_1_000.Instance.toInterval(context, be_ as object);
            bool? bg_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(bc_, bf_, "day");

            return bg_;
        };
        IEnumerable<Encounter> ah_ = context.Operators.Where<Encounter>(af_, ag_);

        return ah_;
    }


    [CqlDeclaration("Initial Population")]
    public bool? Initial_Population(CqlContext context)
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


    [CqlDeclaration("Denominator 1")]
    public bool? Denominator_1(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);

        return a_;
    }


    [CqlDeclaration("Most Recent Tobacco Use Screening Indicates Tobacco User")]
    public Observation Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_User(CqlContext context)
    {
        CqlValueSet a_ = this.Tobacco_Use_Screening(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> c_ = Status_1_8_000.Instance.isAssessmentPerformed(context, b_);
        bool? d_(Observation TobaccoUseScreening)
        {
            CqlInterval<CqlDateTime> m_ = this.Measurement_Period(context);
            DataType n_ = TobaccoUseScreening?.Effective;
            object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
            CqlInterval<CqlDateTime> p_ = QICoreCommon_2_1_000.Instance.toInterval(context, o_);
            bool? q_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(m_, p_, "day");

            return q_;
        };
        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
        object f_(Observation @this)
        {
            DataType r_ = @this?.Effective;
            object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
            CqlInterval<CqlDateTime> t_ = QICoreCommon_2_1_000.Instance.toInterval(context, s_);
            CqlDateTime u_ = context.Operators.Start(t_);

            return u_;
        };
        IEnumerable<Observation> g_ = context.Operators.SortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
        Observation h_ = context.Operators.Last<Observation>(g_);
        Observation[] i_ = [
            h_,
        ];
        bool? j_(Observation MostRecentTobaccoUseScreening)
        {
            DataType v_ = MostRecentTobaccoUseScreening?.Value;
            object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
            CqlValueSet x_ = this.Tobacco_User(context);
            bool? y_ = context.Operators.ConceptInValueSet(w_ as CqlConcept, x_);

            return y_;
        };
        IEnumerable<Observation> k_ = context.Operators.Where<Observation>((IEnumerable<Observation>)i_, j_);
        Observation l_ = context.Operators.SingletonFrom<Observation>(k_);

        return l_;
    }


    [CqlDeclaration("Denominator 2")]
    public bool? Denominator_2(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);
        Observation b_ = this.Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_User(context);
        bool? c_ = context.Operators.Not((bool?)(b_ is null));
        bool? d_ = context.Operators.And(a_, c_);

        return d_;
    }


    [CqlDeclaration("Denominator 3")]
    public bool? Denominator_3(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);

        return a_;
    }


    [CqlDeclaration("Most Recent Tobacco Use Screening Indicates Tobacco Non User")]
    public Observation Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_Non_User(CqlContext context)
    {
        CqlValueSet a_ = this.Tobacco_Use_Screening(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> c_ = Status_1_8_000.Instance.isAssessmentPerformed(context, b_);
        bool? d_(Observation TobaccoUseScreening)
        {
            CqlInterval<CqlDateTime> m_ = this.Measurement_Period(context);
            DataType n_ = TobaccoUseScreening?.Effective;
            object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
            CqlInterval<CqlDateTime> p_ = QICoreCommon_2_1_000.Instance.toInterval(context, o_);
            bool? q_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(m_, p_, "day");

            return q_;
        };
        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
        object f_(Observation @this)
        {
            DataType r_ = @this?.Effective;
            object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
            CqlInterval<CqlDateTime> t_ = QICoreCommon_2_1_000.Instance.toInterval(context, s_);
            CqlDateTime u_ = context.Operators.Start(t_);

            return u_;
        };
        IEnumerable<Observation> g_ = context.Operators.SortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
        Observation h_ = context.Operators.Last<Observation>(g_);
        Observation[] i_ = [
            h_,
        ];
        bool? j_(Observation MostRecentTobaccoUseScreening)
        {
            DataType v_ = MostRecentTobaccoUseScreening?.Value;
            object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
            CqlValueSet x_ = this.Tobacco_Non_User(context);
            bool? y_ = context.Operators.ConceptInValueSet(w_ as CqlConcept, x_);

            return y_;
        };
        IEnumerable<Observation> k_ = context.Operators.Where<Observation>((IEnumerable<Observation>)i_, j_);
        Observation l_ = context.Operators.SingletonFrom<Observation>(k_);

        return l_;
    }


    [CqlDeclaration("Numerator 1")]
    public bool? Numerator_1(CqlContext context)
    {
        Observation a_ = this.Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_Non_User(context);
        bool? b_ = context.Operators.Not((bool?)(a_ is null));
        Observation c_ = this.Most_Recent_Tobacco_Use_Screening_Indicates_Tobacco_User(context);
        bool? d_ = context.Operators.Not((bool?)(c_ is null));
        bool? e_ = context.Operators.Or(b_, d_);

        return e_;
    }


    [CqlDeclaration("Tobacco Cessation Counseling Given")]
    public IEnumerable<object> Tobacco_Cessation_Counseling_Given(CqlContext context)
    {
        CqlValueSet a_ = this.Tobacco_Use_Cessation_Counseling(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> c_ = Status_1_8_000.Instance.isInterventionPerformed(context, b_);
        bool? d_(Procedure TobaccoCessationCounseling)
        {
            CqlInterval<CqlDateTime> l_ = this.Measurement_Period(context);
            CqlDateTime m_ = context.Operators.Start(l_);
            CqlQuantity n_ = context.Operators.Quantity(6m, "months");
            CqlDateTime o_ = context.Operators.Subtract(m_, n_);
            CqlDateTime q_ = context.Operators.End(l_);
            CqlInterval<CqlDateTime> r_ = context.Operators.Interval(o_, q_, true, true);
            DataType s_ = TobaccoCessationCounseling?.Performed;
            object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
            CqlInterval<CqlDateTime> u_ = QICoreCommon_2_1_000.Instance.toInterval(context, t_);
            bool? v_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(r_, u_, "day");

            return v_;
        };
        IEnumerable<Procedure> e_ = context.Operators.Where<Procedure>(c_, d_);
        CqlCode f_ = this.Tobacco_abuse_counseling(context);
        IEnumerable<CqlCode> g_ = context.Operators.ToList<CqlCode>(f_);
        IEnumerable<Condition> h_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, g_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? i_(Condition TobaccoCounseling)
        {
            CqlInterval<CqlDateTime> w_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, TobaccoCounseling);
            CqlDateTime x_ = context.Operators.Start(w_);
            CqlInterval<CqlDateTime> y_ = this.Measurement_Period(context);
            CqlDateTime z_ = context.Operators.Start(y_);
            CqlQuantity aa_ = context.Operators.Quantity(6m, "months");
            CqlDateTime ab_ = context.Operators.Subtract(z_, aa_);
            CqlDateTime ad_ = context.Operators.End(y_);
            CqlInterval<CqlDateTime> ae_ = context.Operators.Interval(ab_, ad_, true, true);
            bool? af_ = context.Operators.In<CqlDateTime>(x_, ae_, "day");

            return af_;
        };
        IEnumerable<Condition> j_ = context.Operators.Where<Condition>(h_, i_);
        IEnumerable<object> k_ = context.Operators.Union<object>(e_ as IEnumerable<object>, j_ as IEnumerable<object>);

        return k_;
    }


    [CqlDeclaration("Tobacco Cessation Pharmacotherapy Ordered")]
    public IEnumerable<MedicationRequest> Tobacco_Cessation_Pharmacotherapy_Ordered(CqlContext context)
    {
        CqlValueSet a_ = this.Tobacco_Use_Cessation_Pharmacotherapy(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> d_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> e_ = context.Operators.Union<MedicationRequest>(b_, d_);
        IEnumerable<MedicationRequest> f_ = Status_1_8_000.Instance.isMedicationOrder(context, e_);
        bool? g_(MedicationRequest CessationPharmacotherapyOrdered)
        {
            FhirDateTime i_ = CessationPharmacotherapyOrdered?.AuthoredOnElement;
            CqlDateTime j_ = context.Operators.Convert<CqlDateTime>(i_);
            CqlInterval<CqlDateTime> k_ = this.Measurement_Period(context);
            CqlDateTime l_ = context.Operators.Start(k_);
            CqlQuantity m_ = context.Operators.Quantity(6m, "months");
            CqlDateTime n_ = context.Operators.Subtract(l_, m_);
            CqlDateTime p_ = context.Operators.End(k_);
            CqlInterval<CqlDateTime> q_ = context.Operators.Interval(n_, p_, true, true);
            bool? r_ = context.Operators.In<CqlDateTime>(j_, q_, "day");

            return r_;
        };
        IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);

        return h_;
    }


    [CqlDeclaration("Active Pharmacotherapy for Tobacco Cessation")]
    public IEnumerable<MedicationRequest> Active_Pharmacotherapy_for_Tobacco_Cessation(CqlContext context)
    {
        CqlValueSet a_ = this.Tobacco_Use_Cessation_Pharmacotherapy(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> d_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> e_ = context.Operators.Union<MedicationRequest>(b_, d_);
        IEnumerable<MedicationRequest> f_ = Status_1_8_000.Instance.isMedicationActive(context, e_);
        bool? g_(MedicationRequest TakingCessationPharmacotherapy)
        {
            CqlInterval<CqlDateTime> i_ = this.Measurement_Period(context);
            CqlDateTime j_ = context.Operators.Start(i_);
            CqlQuantity k_ = context.Operators.Quantity(6m, "months");
            CqlDateTime l_ = context.Operators.Subtract(j_, k_);
            CqlDateTime n_ = context.Operators.End(i_);
            CqlInterval<CqlDateTime> o_ = context.Operators.Interval(l_, n_, true, true);
            CqlInterval<CqlDate> p_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, TakingCessationPharmacotherapy);
            CqlDate q_ = p_?.low;
            CqlDateTime r_ = context.Operators.ConvertDateToDateTime(q_);
            CqlDate t_ = p_?.high;
            CqlDateTime u_ = context.Operators.ConvertDateToDateTime(t_);
            bool? w_ = p_?.lowClosed;
            bool? y_ = p_?.highClosed;
            CqlInterval<CqlDateTime> z_ = context.Operators.Interval(r_, u_, w_, y_);
            bool? aa_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(o_, z_, "day");

            return aa_;
        };
        IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);

        return h_;
    }


    [CqlDeclaration("Numerator 2")]
    public bool? Numerator_2(CqlContext context)
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


    [CqlDeclaration("Numerator 3")]
    public bool? Numerator_3(CqlContext context)
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


    [CqlDeclaration("Denominator Exclusion")]
    public bool? Denominator_Exclusion(CqlContext context)
    {
        bool? a_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);

        return a_;
    }


    [CqlDeclaration("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return a_;
    }


    [CqlDeclaration("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return a_;
    }


    [CqlDeclaration("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return a_;
    }


    [CqlDeclaration("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return a_;
    }


    #endregion Definition Methods

}
