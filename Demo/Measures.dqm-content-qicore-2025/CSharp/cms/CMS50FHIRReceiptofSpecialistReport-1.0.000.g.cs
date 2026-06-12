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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.1.0")]
[CqlLibrary("CMS50FHIRReceiptofSpecialistReport", "1.0.000")]
public partial class CMS50FHIRReceiptofSpecialistReport_1_0_000 : ILibrary, ISingleton<CMS50FHIRReceiptofSpecialistReport_1_0_000>
{
    #region ValueSets (10)

    [CqlValueSetDefinition("Behavioral/Neuropsych Assessment", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1023", valueSetVersion: null)]
    public CqlValueSet Behavioral_Neuropsych_Assessment(CqlContext _) => _Behavioral_Neuropsych_Assessment;
    private static readonly CqlValueSet _Behavioral_Neuropsych_Assessment = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1023", null);

    [CqlValueSetDefinition("Consultant Report", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.121.12.1006", valueSetVersion: null)]
    public CqlValueSet Consultant_Report(CqlContext _) => _Consultant_Report;
    private static readonly CqlValueSet _Consultant_Report = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.121.12.1006", null);

    [CqlValueSetDefinition("Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext _) => _Office_Visit;
    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlValueSetDefinition("Ophthalmological Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285", valueSetVersion: null)]
    public CqlValueSet Ophthalmological_Services(CqlContext _) => _Ophthalmological_Services;
    private static readonly CqlValueSet _Ophthalmological_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285", null);

    [CqlValueSetDefinition("Preventive Care Services Established Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services_Established_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services_Established_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);

    [CqlValueSetDefinition("Preventive Care Services, Initial Office Visit, 0 to 17", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services__Initial_Office_Visit__0_to_17(CqlContext _) => _Preventive_Care_Services__Initial_Office_Visit__0_to_17;
    private static readonly CqlValueSet _Preventive_Care_Services__Initial_Office_Visit__0_to_17 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", null);

    [CqlValueSetDefinition("Preventive Care Services Initial Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services_Initial_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services_Initial_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);

    [CqlValueSetDefinition("Preventive Care, Established Office Visit, 0 to 17", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", valueSetVersion: null)]
    public CqlValueSet Preventive_Care__Established_Office_Visit__0_to_17(CqlContext _) => _Preventive_Care__Established_Office_Visit__0_to_17;
    private static readonly CqlValueSet _Preventive_Care__Established_Office_Visit__0_to_17 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", null);

    [CqlValueSetDefinition("Psych Visit Diagnostic Evaluation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1492", valueSetVersion: null)]
    public CqlValueSet Psych_Visit_Diagnostic_Evaluation(CqlContext _) => _Psych_Visit_Diagnostic_Evaluation;
    private static readonly CqlValueSet _Psych_Visit_Diagnostic_Evaluation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1492", null);

    [CqlValueSetDefinition("Referral", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1046", valueSetVersion: null)]
    public CqlValueSet Referral(CqlContext _) => _Referral;
    private static readonly CqlValueSet _Referral = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1046", null);

    #endregion ValueSets

    #region Codes (5)

    [CqlCodeDefinition("Developmental test administration (including assessment of fine and/or gross motor, language, cognitive level, social, memory and/or executive functions by standardized developmental instruments when performed), by physician or other qualified health care professional, with interpretation and report; first hour", codeId: "96112", codeSystem: "http://www.ama-assn.org/go/cpt")]
    public CqlCode Developmental_test_administration__including_assessment_of_fine_and_or_gross_motor__language__cognitive_level__social__memory_and_or_executive_functions_by_standardized_developmental_instruments_when_performed___by_physician_or_other_qualified_health_care_professional__with_interpretation_and_report__first_hour(CqlContext _) => _Developmental_test_administration__including_assessment_of_fine_and_or_gross_motor__language__cognitive_level__social__memory_and_or_executive_functions_by_standardized_developmental_instruments_when_performed___by_physician_or_other_qualified_health_care_professional__with_interpretation_and_report__first_hour;
    private static readonly CqlCode _Developmental_test_administration__including_assessment_of_fine_and_or_gross_motor__language__cognitive_level__social__memory_and_or_executive_functions_by_standardized_developmental_instruments_when_performed___by_physician_or_other_qualified_health_care_professional__with_interpretation_and_report__first_hour = new CqlCode("96112", "http://www.ama-assn.org/go/cpt");

    [CqlCodeDefinition("Health behavior assessment, or re-assessment (ie, health-focused clinical interview, behavioral observations, clinical decision making)", codeId: "96156", codeSystem: "http://www.ama-assn.org/go/cpt")]
    public CqlCode Health_behavior_assessment__or_re_assessment__ie__health_focused_clinical_interview__behavioral_observations__clinical_decision_making_(CqlContext _) => _Health_behavior_assessment__or_re_assessment__ie__health_focused_clinical_interview__behavioral_observations__clinical_decision_making_;
    private static readonly CqlCode _Health_behavior_assessment__or_re_assessment__ie__health_focused_clinical_interview__behavioral_observations__clinical_decision_making_ = new CqlCode("96156", "http://www.ama-assn.org/go/cpt");

    [CqlCodeDefinition("Psychological or neuropsychological test administration and scoring by physician or other qualified health care professional, two or more tests, any method; first 30 minutes", codeId: "96136", codeSystem: "http://www.ama-assn.org/go/cpt")]
    public CqlCode Psychological_or_neuropsychological_test_administration_and_scoring_by_physician_or_other_qualified_health_care_professional__two_or_more_tests__any_method__first_30_minutes(CqlContext _) => _Psychological_or_neuropsychological_test_administration_and_scoring_by_physician_or_other_qualified_health_care_professional__two_or_more_tests__any_method__first_30_minutes;
    private static readonly CqlCode _Psychological_or_neuropsychological_test_administration_and_scoring_by_physician_or_other_qualified_health_care_professional__two_or_more_tests__any_method__first_30_minutes = new CqlCode("96136", "http://www.ama-assn.org/go/cpt");

    [CqlCodeDefinition("Psychological or neuropsychological test administration and scoring by technician, two or more tests, any method; first 30 minutes", codeId: "96138", codeSystem: "http://www.ama-assn.org/go/cpt")]
    public CqlCode Psychological_or_neuropsychological_test_administration_and_scoring_by_technician__two_or_more_tests__any_method__first_30_minutes(CqlContext _) => _Psychological_or_neuropsychological_test_administration_and_scoring_by_technician__two_or_more_tests__any_method__first_30_minutes;
    private static readonly CqlCode _Psychological_or_neuropsychological_test_administration_and_scoring_by_technician__two_or_more_tests__any_method__first_30_minutes = new CqlCode("96138", "http://www.ama-assn.org/go/cpt");

    [CqlCodeDefinition("Psychotherapy for crisis; first 60 minutes", codeId: "90839", codeSystem: "http://www.ama-assn.org/go/cpt")]
    public CqlCode Psychotherapy_for_crisis__first_60_minutes(CqlContext _) => _Psychotherapy_for_crisis__first_60_minutes;
    private static readonly CqlCode _Psychotherapy_for_crisis__first_60_minutes = new CqlCode("90839", "http://www.ama-assn.org/go/cpt");

    #endregion Codes

    #region CodeSystems (1)

    [CqlCodeSystemDefinition("CPT", codeSystemId: "http://www.ama-assn.org/go/cpt", codeSystemVersion: null)]
    public CqlCodeSystem CPT(CqlContext _) => _CPT;
    private static readonly CqlCodeSystem _CPT =
      new CqlCodeSystem("http://www.ama-assn.org/go/cpt", null, [
          _Developmental_test_administration__including_assessment_of_fine_and_or_gross_motor__language__cognitive_level__social__memory_and_or_executive_functions_by_standardized_developmental_instruments_when_performed___by_physician_or_other_qualified_health_care_professional__with_interpretation_and_report__first_hour,
          _Health_behavior_assessment__or_re_assessment__ie__health_focused_clinical_interview__behavioral_observations__clinical_decision_making_,
          _Psychological_or_neuropsychological_test_administration_and_scoring_by_physician_or_other_qualified_health_care_professional__two_or_more_tests__any_method__first_30_minutes,
          _Psychological_or_neuropsychological_test_administration_and_scoring_by_technician__two_or_more_tests__any_method__first_30_minutes,
          _Psychotherapy_for_crisis__first_60_minutes]);

    #endregion CodeSystems

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = -8633000620496989027L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("CMS50FHIRReceiptofSpecialistReport-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (12)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = 993086970170150705L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Has Encounter during Measurement Period")]
    public bool? Has_Encounter_during_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Encounter_during_Measurement_Period, Has_Encounter_during_Measurement_Period_Compute);

    private const long _cacheIndex_Has_Encounter_during_Measurement_Period = 6342340037644257345L;

    private bool? Has_Encounter_during_Measurement_Period_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Office_Visit(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet c_ = this.Ophthalmological_Services(context);
        IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
        CqlValueSet f_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet h_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> i_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
        CqlValueSet l_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> m_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet n_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> o_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> p_ = context.Operators.Union<Encounter>(m_, o_);
        IEnumerable<Encounter> q_ = context.Operators.Union<Encounter>(k_, p_);

        bool? r_(Encounter ValidEncounter) {
            Code<Encounter.EncounterStatus> u_ = ValidEncounter?.StatusElement;
            Encounter.EncounterStatus? v_ = u_?.Value;
            Code<Encounter.EncounterStatus> w_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(v_);
            bool? x_ = context.Operators.Equal(w_, "finished");
            CqlInterval<CqlDateTime> y_ = this.Measurement_Period(context);
            Period z_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> aa_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, z_);
            bool? ab_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(y_, aa_, "day");
            bool? ac_ = context.Operators.And(x_, ab_);
            return ac_;
        }

        IEnumerable<Encounter> s_ = context.Operators.Where<Encounter>(q_, r_);
        bool? t_ = context.Operators.Exists<Encounter>(s_);
        return t_;
    }


    [CqlExpressionDefinition("Has Intervention during Measurement Period")]
    public bool? Has_Intervention_during_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Intervention_during_Measurement_Period, Has_Intervention_during_Measurement_Period_Compute);

    private const long _cacheIndex_Has_Intervention_during_Measurement_Period = 1165576977205401652L;

    private bool? Has_Intervention_during_Measurement_Period_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Behavioral_Neuropsych_Assessment(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        CqlCode c_ = this.Health_behavior_assessment__or_re_assessment__ie__health_focused_clinical_interview__behavioral_observations__clinical_decision_making_(context);
        IEnumerable<CqlCode> d_ = context.Operators.ToList<CqlCode>(c_);
        IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, d_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> f_ = context.Operators.Union<Procedure>(b_, e_);
        CqlCode g_ = this.Psychological_or_neuropsychological_test_administration_and_scoring_by_physician_or_other_qualified_health_care_professional__two_or_more_tests__any_method__first_30_minutes(context);
        IEnumerable<CqlCode> h_ = context.Operators.ToList<CqlCode>(g_);
        IEnumerable<Procedure> i_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, h_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        CqlCode j_ = this.Psychological_or_neuropsychological_test_administration_and_scoring_by_technician__two_or_more_tests__any_method__first_30_minutes(context);
        IEnumerable<CqlCode> k_ = context.Operators.ToList<CqlCode>(j_);
        IEnumerable<Procedure> l_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, k_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> m_ = context.Operators.Union<Procedure>(i_, l_);
        IEnumerable<Procedure> n_ = context.Operators.Union<Procedure>(f_, m_);
        CqlCode o_ = this.Psychotherapy_for_crisis__first_60_minutes(context);
        IEnumerable<CqlCode> p_ = context.Operators.ToList<CqlCode>(o_);
        IEnumerable<Procedure> q_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, p_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        CqlValueSet r_ = this.Psych_Visit_Diagnostic_Evaluation(context);
        IEnumerable<Procedure> s_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> t_ = context.Operators.Union<Procedure>(q_, s_);
        IEnumerable<Procedure> u_ = context.Operators.Union<Procedure>(n_, t_);
        CqlCode v_ = this.Developmental_test_administration__including_assessment_of_fine_and_or_gross_motor__language__cognitive_level__social__memory_and_or_executive_functions_by_standardized_developmental_instruments_when_performed___by_physician_or_other_qualified_health_care_professional__with_interpretation_and_report__first_hour(context);
        IEnumerable<CqlCode> w_ = context.Operators.ToList<CqlCode>(v_);
        IEnumerable<Procedure> x_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, default, w_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        IEnumerable<Procedure> y_ = context.Operators.Union<Procedure>(u_, x_);
        IEnumerable<Procedure> z_ = Status_1_15_000.Instance.isProcedurePerformed(context, y_);

        bool? aa_(Procedure ValidIntervention) {
            CqlInterval<CqlDateTime> ad_ = this.Measurement_Period(context);

            object ae_() {

                bool ah_() {
                    DataType al_ = ValidIntervention?.Performed;
                    object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                    bool an_ = am_ is CqlDateTime;
                    return an_;
                }


                bool ai_() {
                    DataType ao_ = ValidIntervention?.Performed;
                    object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                    bool aq_ = ap_ is CqlInterval<CqlDateTime>;
                    return aq_;
                }


                bool aj_() {
                    DataType ar_ = ValidIntervention?.Performed;
                    object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                    bool at_ = as_ is CqlQuantity;
                    return at_;
                }


                bool ak_() {
                    DataType au_ = ValidIntervention?.Performed;
                    object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                    bool aw_ = av_ is CqlInterval<CqlQuantity>;
                    return aw_;
                }

                if (ah_())
                {
                    DataType ax_ = ValidIntervention?.Performed;
                    object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                    return (ay_ as CqlDateTime) as object;
                }
                else if (ai_())
                {
                    DataType az_ = ValidIntervention?.Performed;
                    object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                    return (ba_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (aj_())
                {
                    DataType bb_ = ValidIntervention?.Performed;
                    object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                    return (bc_ as CqlQuantity) as object;
                }
                else if (ak_())
                {
                    DataType bd_ = ValidIntervention?.Performed;
                    object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                    return (be_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> af_ = QICoreCommon_4_0_000.Instance.toInterval(context, ae_());
            bool? ag_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ad_, af_, "day");
            return ag_;
        }

        IEnumerable<Procedure> ab_ = context.Operators.Where<Procedure>(z_, aa_);
        bool? ac_ = context.Operators.Exists<Procedure>(ab_);
        return ac_;
    }


    [CqlExpressionDefinition("First Referral during First 10 Months of Measurement Period")]
    public ServiceRequest First_Referral_during_First_10_Months_of_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_First_Referral_during_First_10_Months_of_Measurement_Period, First_Referral_during_First_10_Months_of_Measurement_Period_Compute);

    private const long _cacheIndex_First_Referral_during_First_10_Months_of_Measurement_Period = -6349200580831879765L;

    private ServiceRequest First_Referral_during_First_10_Months_of_Measurement_Period_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Referral(context);
        IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));

        bool? c_(ServiceRequest ReferralOrder) {
            Code<RequestStatus> h_ = ReferralOrder?.StatusElement;
            RequestStatus? i_ = h_?.Value;
            Code<RequestStatus> j_ = context.Operators.Convert<Code<RequestStatus>>(i_);
            string k_ = context.Operators.Convert<string>(j_);
            string[] l_ = [
                "active",
                "completed",
            ];
            bool? m_ = context.Operators.In<string>(k_, (IEnumerable<string>)l_);
            Code<RequestIntent> n_ = ReferralOrder?.IntentElement;
            RequestIntent? o_ = n_?.Value;
            Code<RequestIntent> p_ = context.Operators.Convert<Code<RequestIntent>>(o_);
            bool? q_ = context.Operators.Equal(p_, "order");
            bool? r_ = context.Operators.And(m_, q_);
            FhirDateTime s_ = ReferralOrder?.AuthoredOnElement;
            CqlDateTime t_ = context.Operators.Convert<CqlDateTime>(s_);
            CqlInterval<CqlDateTime> u_ = this.Measurement_Period(context);
            CqlDateTime v_ = context.Operators.Start(u_);
            CqlDateTime x_ = context.Operators.Start(u_);
            int? y_ = context.Operators.DateTimeComponentFrom(x_, "year");
            CqlDate z_ = context.Operators.Date(y_, 10, 31);
            CqlDateTime aa_ = context.Operators.ConvertDateToDateTime(z_);
            CqlInterval<CqlDateTime> ab_ = context.Operators.Interval(v_, aa_, true, true);
            bool? ac_ = context.Operators.In<CqlDateTime>(t_, ab_, "day");
            bool? ad_ = context.Operators.And(r_, ac_);
            return ad_;
        }

        IEnumerable<ServiceRequest> d_ = context.Operators.Where<ServiceRequest>(b_, c_);

        object e_(ServiceRequest @this) {
            FhirDateTime ae_ = @this?.AuthoredOnElement;
            CqlDateTime af_ = context.Operators.Convert<CqlDateTime>(ae_);
            return af_;
        }

        IEnumerable<ServiceRequest> f_ = context.Operators.SortBy<ServiceRequest>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
        ServiceRequest g_ = context.Operators.First<ServiceRequest>(f_);
        return g_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = -7184150108548928081L;

    private bool? Initial_Population_Compute(CqlContext context)
    {
        bool? a_ = this.Has_Encounter_during_Measurement_Period(context);
        bool? b_ = this.Has_Intervention_during_Measurement_Period(context);
        bool? c_ = context.Operators.Or(a_, b_);
        ServiceRequest d_ = this.First_Referral_during_First_10_Months_of_Measurement_Period(context);
        bool? e_ = context.Operators.Not((bool?)(d_ is null));
        bool? f_ = context.Operators.And(c_, e_);
        return f_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = 5090247856032037412L;

    private bool? Denominator_Compute(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = -3766651685399998887L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = 2101280260375690497L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = 4493470933035843420L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = -7763885849007845267L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    [CqlExpressionDefinition("Referring Clinician Receives Consultant Report to Close Referral Loop")]
    public bool? Referring_Clinician_Receives_Consultant_Report_to_Close_Referral_Loop(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Referring_Clinician_Receives_Consultant_Report_to_Close_Referral_Loop, Referring_Clinician_Receives_Consultant_Report_to_Close_Referral_Loop_Compute);

    private const long _cacheIndex_Referring_Clinician_Receives_Consultant_Report_to_Close_Referral_Loop = 216167620418217975L;

    private bool? Referring_Clinician_Receives_Consultant_Report_to_Close_Referral_Loop_Compute(CqlContext context)
    {
        CqlCode a_ = QICoreCommon_4_0_000.Instance.Fulfill(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Task> c_ = context.Operators.Retrieve<Task>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-task"));

        IEnumerable<Task> d_(Task ConsultantReportObtained) {
            ServiceRequest g_ = this.First_Referral_during_First_10_Months_of_Measurement_Period(context);
            ServiceRequest[] h_ = [
                g_,
            ];

            bool? i_(ServiceRequest FirstReferral) {
                ResourceReference m_ = ConsultantReportObtained?.Focus;
                bool? n_ = QICoreCommon_4_0_000.Instance.references(context, m_, FirstReferral);
                List<ResourceReference> o_ = ConsultantReportObtained?.BasedOn;
                bool? p_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)o_, FirstReferral);
                bool? q_ = context.Operators.Or(n_, p_);
                Period r_ = ConsultantReportObtained?.ExecutionPeriod;
                CqlInterval<CqlDateTime> s_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
                CqlDateTime t_ = context.Operators.End(s_);
                FhirDateTime u_ = FirstReferral?.AuthoredOnElement;
                CqlDateTime v_ = context.Operators.Convert<CqlDateTime>(u_);
                bool? w_ = context.Operators.After(t_, v_, (string)default);
                bool? x_ = context.Operators.And(q_, w_);
                CqlInterval<CqlDateTime> z_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
                CqlDateTime aa_ = context.Operators.End(z_);
                CqlInterval<CqlDateTime> ab_ = this.Measurement_Period(context);
                bool? ac_ = context.Operators.In<CqlDateTime>(aa_, ab_, "day");
                bool? ad_ = context.Operators.And(x_, ac_);
                Code<Task.TaskStatus> ae_ = ConsultantReportObtained?.StatusElement;
                Task.TaskStatus? af_ = ae_?.Value;
                string ag_ = context.Operators.Convert<string>(af_);
                bool? ah_ = context.Operators.Equal(ag_, "completed");
                bool? ai_ = context.Operators.And(ad_, ah_);
                CodeableConcept aj_ = ConsultantReportObtained?.ReasonCode;
                CqlConcept ak_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, aj_);
                CqlValueSet al_ = this.Consultant_Report(context);
                bool? am_ = context.Operators.ConceptInValueSet(ak_, al_);
                bool? an_ = context.Operators.And(ai_, am_);
                return an_;
            }

            IEnumerable<ServiceRequest> j_ = context.Operators.Where<ServiceRequest>((IEnumerable<ServiceRequest>)h_, i_);
            Task k_(ServiceRequest FirstReferral) => ConsultantReportObtained;
            IEnumerable<Task> l_ = context.Operators.Select<ServiceRequest, Task>(j_, k_);
            return l_;
        }

        IEnumerable<Task> e_ = context.Operators.SelectMany<Task, Task>(c_, d_);
        bool? f_ = context.Operators.Exists<Task>(e_);
        return f_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = 8962450575396821569L;

    private bool? Numerator_Compute(CqlContext context)
    {
        bool? a_ = this.Referring_Clinician_Receives_Consultant_Report_to_Close_Referral_Loop(context);
        return a_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private CMS50FHIRReceiptofSpecialistReport_1_0_000() {}

    public static CMS50FHIRReceiptofSpecialistReport_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS50FHIRReceiptofSpecialistReport";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_5_1_000.Instance, QICoreCommon_4_0_000.Instance, Status_1_15_000.Instance];

    #endregion ILibrary Implementation

}
