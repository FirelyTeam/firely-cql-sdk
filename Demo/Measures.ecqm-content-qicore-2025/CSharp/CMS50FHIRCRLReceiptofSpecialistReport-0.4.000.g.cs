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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "3.1.0.0")]
[CqlLibrary("CMS50FHIRCRLReceiptofSpecialistReport", "0.4.000")]
public partial class CMS50FHIRCRLReceiptofSpecialistReport_0_4_000 : ILibrary, ISingleton<CMS50FHIRCRLReceiptofSpecialistReport_0_4_000>
{
    private CMS50FHIRCRLReceiptofSpecialistReport_0_4_000() {}

    public static CMS50FHIRCRLReceiptofSpecialistReport_0_4_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "CMS50FHIRCRLReceiptofSpecialistReport";
    public string Version => "0.4.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_5_1_000.Instance, QICoreCommon_4_0_000.Instance, Status_1_15_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

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

    #region Codes

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

    #region CodeSystems

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

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object a_ = context.ResolveParameter("CMS50FHIRCRLReceiptofSpecialistReport-0.4.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)a_;
    }


    #endregion Parameters

    #region Functions and Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

        return b_;
    }


    [CqlExpressionDefinition("Has Encounter during Measurement Period")]
    public bool? Has_Encounter_during_Measurement_Period(CqlContext context)
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
        bool? r_(Encounter ValidEncounter)
        {
            Code<Encounter.EncounterStatus> u_ = ValidEncounter?.StatusElement;
            Encounter.EncounterStatus? v_ = u_?.Value;
            Code<Encounter.EncounterStatus> w_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(v_);
            bool? x_ = context.Operators.Equal(w_, "finished");
            CqlInterval<CqlDateTime> y_ = this.Measurement_Period(context);
            Period z_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> aa_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, z_);
            CqlInterval<CqlDateTime> ab_ = QICoreCommon_4_0_000.Instance.toInterval(context, aa_ as object);
            bool? ac_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(y_, ab_, "day");
            bool? ad_ = context.Operators.And(x_, ac_);

            return ad_;
        };
        IEnumerable<Encounter> s_ = context.Operators.Where<Encounter>(q_, r_);
        bool? t_ = context.Operators.Exists<Encounter>(s_);

        return t_;
    }


    [CqlExpressionDefinition("Has Intervention during Measurement Period")]
    public bool? Has_Intervention_during_Measurement_Period(CqlContext context)
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
        bool? aa_(Procedure ValidIntervention)
        {
            CqlInterval<CqlDateTime> ad_ = this.Measurement_Period(context);
            object ae_()
            {
                bool ah_()
                {
                    DataType al_ = ValidIntervention?.Performed;
                    object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                    bool an_ = am_ is CqlDateTime;

                    return an_;
                };
                bool ai_()
                {
                    DataType ao_ = ValidIntervention?.Performed;
                    object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                    bool aq_ = ap_ is CqlInterval<CqlDateTime>;

                    return aq_;
                };
                bool aj_()
                {
                    DataType ar_ = ValidIntervention?.Performed;
                    object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                    bool at_ = as_ is CqlQuantity;

                    return at_;
                };
                bool ak_()
                {
                    DataType au_ = ValidIntervention?.Performed;
                    object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                    bool aw_ = av_ is CqlInterval<CqlQuantity>;

                    return aw_;
                };
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
                }
            };
            CqlInterval<CqlDateTime> af_ = QICoreCommon_4_0_000.Instance.toInterval(context, ae_());
            bool? ag_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ad_, af_, "day");

            return ag_;
        };
        IEnumerable<Procedure> ab_ = context.Operators.Where<Procedure>(z_, aa_);
        bool? ac_ = context.Operators.Exists<Procedure>(ab_);

        return ac_;
    }


    [CqlExpressionDefinition("First Referral during First 10 Months of Measurement Period")]
    public (CqlTupleMetadata, string ID, CqlDateTime AuthorDate)? First_Referral_during_First_10_Months_of_Measurement_Period(CqlContext context)
    {
        CqlValueSet a_ = this.Referral(context);
        IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        bool? c_(ServiceRequest ReferralOrder)
        {
            Code<RequestStatus> k_ = ReferralOrder?.StatusElement;
            RequestStatus? l_ = k_?.Value;
            Code<RequestStatus> m_ = context.Operators.Convert<Code<RequestStatus>>(l_);
            string n_ = context.Operators.Convert<string>(m_);
            string[] o_ = [
                "active",
                "completed",
            ];
            bool? p_ = context.Operators.In<string>(n_, (IEnumerable<string>)o_);
            Code<RequestIntent> q_ = ReferralOrder?.IntentElement;
            RequestIntent? r_ = q_?.Value;
            Code<RequestIntent> s_ = context.Operators.Convert<Code<RequestIntent>>(r_);
            bool? t_ = context.Operators.Equal(s_, "order");
            bool? u_ = context.Operators.And(p_, t_);
            FhirDateTime v_ = ReferralOrder?.AuthoredOnElement;
            CqlDateTime w_ = context.Operators.Convert<CqlDateTime>(v_);
            CqlInterval<CqlDateTime> x_ = this.Measurement_Period(context);
            CqlDateTime y_ = context.Operators.Start(x_);
            CqlDateTime aa_ = context.Operators.Start(x_);
            int? ab_ = context.Operators.DateTimeComponentFrom(aa_, "year");
            CqlDate ac_ = context.Operators.Date(ab_, 10, 31);
            CqlDateTime ad_ = context.Operators.ConvertDateToDateTime(ac_);
            CqlInterval<CqlDateTime> ae_ = context.Operators.Interval(y_, ad_, true, true);
            bool? af_ = context.Operators.In<CqlDateTime>(w_, ae_, "day");
            bool? ag_ = context.Operators.And(u_, af_);

            return ag_;
        };
        IEnumerable<ServiceRequest> d_ = context.Operators.Where<ServiceRequest>(b_, c_);
        (CqlTupleMetadata, string ID, CqlDateTime AuthorDate)? e_(ServiceRequest ReferralOrder)
        {
            Id ah_ = ReferralOrder?.IdElement;
            string ai_ = ah_?.Value;
            FhirDateTime aj_ = ReferralOrder?.AuthoredOnElement;
            CqlDateTime ak_ = context.Operators.Convert<CqlDateTime>(aj_);
            (CqlTupleMetadata, string ID, CqlDateTime AuthorDate)? al_ = (CqlTupleMetadata_EDdTRBfWHaSNbiiXJfIVJUXdb, ai_, ak_);

            return al_;
        };
        IEnumerable<(CqlTupleMetadata, string ID, CqlDateTime AuthorDate)?> f_ = context.Operators.Select<ServiceRequest, (CqlTupleMetadata, string ID, CqlDateTime AuthorDate)?>(d_, e_);
        IEnumerable<(CqlTupleMetadata, string ID, CqlDateTime AuthorDate)?> g_ = context.Operators.Distinct<(CqlTupleMetadata, string ID, CqlDateTime AuthorDate)?>(f_);
        object h_((CqlTupleMetadata, string ID, CqlDateTime AuthorDate)? @this)
        {
            CqlDateTime am_ = @this?.AuthorDate;

            return am_;
        };
        IEnumerable<(CqlTupleMetadata, string ID, CqlDateTime AuthorDate)?> i_ = context.Operators.SortBy<(CqlTupleMetadata, string ID, CqlDateTime AuthorDate)?>(g_, h_, System.ComponentModel.ListSortDirection.Ascending);
        (CqlTupleMetadata, string ID, CqlDateTime AuthorDate)? j_ = context.Operators.First<(CqlTupleMetadata, string ID, CqlDateTime AuthorDate)?>(i_);

        return j_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        bool? a_ = this.Has_Encounter_during_Measurement_Period(context);
        bool? b_ = this.Has_Intervention_during_Measurement_Period(context);
        bool? c_ = context.Operators.Or(a_, b_);
        (CqlTupleMetadata, string ID, CqlDateTime AuthorDate)? d_ = this.First_Referral_during_First_10_Months_of_Measurement_Period(context);
        bool? e_ = context.Operators.Not((bool?)(d_ is null));
        bool? f_ = context.Operators.And(c_, e_);

        return f_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);

        return a_;
    }


    [CqlExpressionDefinition("Has Encounter from Valuesets during Measurement Period")]
    public bool? Has_Encounter_from_Valuesets_during_Measurement_Period(CqlContext context)
    {
        CqlValueSet a_ = this.Behavioral_Neuropsych_Assessment(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet c_ = this.Office_Visit(context);
        IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
        CqlValueSet f_ = this.Ophthalmological_Services(context);
        IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet h_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> i_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
        CqlValueSet l_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> m_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet n_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> o_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> p_ = context.Operators.Union<Encounter>(m_, o_);
        IEnumerable<Encounter> q_ = context.Operators.Union<Encounter>(k_, p_);
        CqlValueSet r_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> s_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet t_ = this.Psych_Visit_Diagnostic_Evaluation(context);
        IEnumerable<Encounter> u_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, t_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> v_ = context.Operators.Union<Encounter>(s_, u_);
        IEnumerable<Encounter> w_ = context.Operators.Union<Encounter>(q_, v_);
        bool? x_(Encounter Encounter)
        {
            Code<Encounter.EncounterStatus> aa_ = Encounter?.StatusElement;
            Encounter.EncounterStatus? ab_ = aa_?.Value;
            Code<Encounter.EncounterStatus> ac_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ab_);
            bool? ad_ = context.Operators.Equal(ac_, "finished");
            CqlInterval<CqlDateTime> ae_ = this.Measurement_Period(context);
            Period af_ = Encounter?.Period;
            CqlInterval<CqlDateTime> ag_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, af_);
            bool? ah_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ae_, ag_, "day");
            bool? ai_ = context.Operators.And(ad_, ah_);

            return ai_;
        };
        IEnumerable<Encounter> y_ = context.Operators.Where<Encounter>(w_, x_);
        bool? z_ = context.Operators.Exists<Encounter>(y_);

        return z_;
    }


    [CqlExpressionDefinition("Has Encounter from DRCs during Measurement Period")]
    public bool? Has_Encounter_from_DRCs_during_Measurement_Period(CqlContext context)
    {
        IEnumerable<Encounter> a_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? b_(Encounter EncDRC)
        {
            List<CodeableConcept> g_ = EncDRC?.Type;
            CqlConcept h_(CodeableConcept @this)
            {
                CqlConcept ao_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return ao_;
            };
            IEnumerable<CqlConcept> i_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)g_, h_);
            bool? j_(CqlConcept T)
            {
                CqlCode ap_ = this.Psychological_or_neuropsychological_test_administration_and_scoring_by_physician_or_other_qualified_health_care_professional__two_or_more_tests__any_method__first_30_minutes(context);
                CqlConcept aq_ = context.Operators.ConvertCodeToConcept(ap_);
                bool? ar_ = context.Operators.Equivalent(T, aq_);

                return ar_;
            };
            IEnumerable<CqlConcept> k_ = context.Operators.Where<CqlConcept>(i_, j_);
            bool? l_ = context.Operators.Exists<CqlConcept>(k_);
            CqlConcept n_(CodeableConcept @this)
            {
                CqlConcept as_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return as_;
            };
            IEnumerable<CqlConcept> o_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)g_, n_);
            bool? p_(CqlConcept T)
            {
                CqlCode at_ = this.Psychological_or_neuropsychological_test_administration_and_scoring_by_technician__two_or_more_tests__any_method__first_30_minutes(context);
                CqlConcept au_ = context.Operators.ConvertCodeToConcept(at_);
                bool? av_ = context.Operators.Equivalent(T, au_);

                return av_;
            };
            IEnumerable<CqlConcept> q_ = context.Operators.Where<CqlConcept>(o_, p_);
            bool? r_ = context.Operators.Exists<CqlConcept>(q_);
            bool? s_ = context.Operators.Or(l_, r_);
            CqlConcept u_(CodeableConcept @this)
            {
                CqlConcept aw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return aw_;
            };
            IEnumerable<CqlConcept> v_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)g_, u_);
            bool? w_(CqlConcept T)
            {
                CqlCode ax_ = this.Psychotherapy_for_crisis__first_60_minutes(context);
                CqlConcept ay_ = context.Operators.ConvertCodeToConcept(ax_);
                bool? az_ = context.Operators.Equivalent(T, ay_);

                return az_;
            };
            IEnumerable<CqlConcept> x_ = context.Operators.Where<CqlConcept>(v_, w_);
            bool? y_ = context.Operators.Exists<CqlConcept>(x_);
            bool? z_ = context.Operators.Or(s_, y_);
            CqlConcept ab_(CodeableConcept @this)
            {
                CqlConcept ba_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return ba_;
            };
            IEnumerable<CqlConcept> ac_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)g_, ab_);
            bool? ad_(CqlConcept T)
            {
                CqlCode bb_ = this.Developmental_test_administration__including_assessment_of_fine_and_or_gross_motor__language__cognitive_level__social__memory_and_or_executive_functions_by_standardized_developmental_instruments_when_performed___by_physician_or_other_qualified_health_care_professional__with_interpretation_and_report__first_hour(context);
                CqlConcept bc_ = context.Operators.ConvertCodeToConcept(bb_);
                bool? bd_ = context.Operators.Equivalent(T, bc_);

                return bd_;
            };
            IEnumerable<CqlConcept> ae_ = context.Operators.Where<CqlConcept>(ac_, ad_);
            bool? af_ = context.Operators.Exists<CqlConcept>(ae_);
            bool? ag_ = context.Operators.Or(z_, af_);
            CqlConcept ai_(CodeableConcept @this)
            {
                CqlConcept be_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return be_;
            };
            IEnumerable<CqlConcept> aj_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)g_, ai_);
            bool? ak_(CqlConcept T)
            {
                CqlCode bf_ = this.Health_behavior_assessment__or_re_assessment__ie__health_focused_clinical_interview__behavioral_observations__clinical_decision_making_(context);
                CqlConcept bg_ = context.Operators.ConvertCodeToConcept(bf_);
                bool? bh_ = context.Operators.Equivalent(T, bg_);

                return bh_;
            };
            IEnumerable<CqlConcept> al_ = context.Operators.Where<CqlConcept>(aj_, ak_);
            bool? am_ = context.Operators.Exists<CqlConcept>(al_);
            bool? an_ = context.Operators.Or(ag_, am_);

            return an_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        bool? d_(Encounter Encounter)
        {
            Code<Encounter.EncounterStatus> bi_ = Encounter?.StatusElement;
            Encounter.EncounterStatus? bj_ = bi_?.Value;
            Code<Encounter.EncounterStatus> bk_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(bj_);
            bool? bl_ = context.Operators.Equal(bk_, "finished");
            CqlInterval<CqlDateTime> bm_ = this.Measurement_Period(context);
            Period bn_ = Encounter?.Period;
            CqlInterval<CqlDateTime> bo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bn_);
            bool? bp_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(bm_, bo_, "day");
            bool? bq_ = context.Operators.And(bl_, bp_);

            return bq_;
        };
        IEnumerable<Encounter> e_ = context.Operators.Where<Encounter>(c_, d_);
        bool? f_ = context.Operators.Exists<Encounter>(e_);

        return f_;
    }


    [CqlFunctionDefinition("TaskGetRequestID")]
    public IEnumerable<string> TaskGetRequestID(CqlContext context, Task task)
    {
        List<ResourceReference> a_ = task?.BasedOn;
        string b_(ResourceReference Task)
        {
            FhirString e_ = Task?.ReferenceElement;
            string f_ = e_?.Value;
            string g_ = QICoreCommon_4_0_000.Instance.GetId(context, f_);

            return g_;
        };
        IEnumerable<string> c_ = context.Operators.Select<ResourceReference, string>((IEnumerable<ResourceReference>)a_, b_);
        IEnumerable<string> d_ = context.Operators.Distinct<string>(c_);

        return d_;
    }


    [CqlExpressionDefinition("Referring Clinician Receives Consultant Report to Close Referral Loop")]
    public bool? Referring_Clinician_Receives_Consultant_Report_to_Close_Referral_Loop(CqlContext context)
    {
        CqlValueSet a_ = this.Consultant_Report(context);
        IEnumerable<Task> b_ = context.Operators.Retrieve<Task>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-task"));
        IEnumerable<Task> c_(Task ConsultantReportObtained)
        {
            (CqlTupleMetadata, string ID, CqlDateTime AuthorDate)? f_ = this.First_Referral_during_First_10_Months_of_Measurement_Period(context);
            (CqlTupleMetadata, string ID, CqlDateTime AuthorDate)?[] g_ = [
                f_,
            ];
            bool? h_((CqlTupleMetadata, string ID, CqlDateTime AuthorDate)? FirstReferral)
            {
                string l_ = FirstReferral?.ID;
                IEnumerable<string> m_ = this.TaskGetRequestID(context, ConsultantReportObtained);
                bool? n_ = context.Operators.In<string>(l_, m_);
                Period o_ = ConsultantReportObtained?.ExecutionPeriod;
                CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, o_);
                CqlDateTime q_ = context.Operators.End(p_);
                CqlDateTime r_ = FirstReferral?.AuthorDate;
                bool? s_ = context.Operators.After(q_, r_, default);
                bool? t_ = context.Operators.And(n_, s_);
                Code<Task.TaskStatus> u_ = ConsultantReportObtained?.StatusElement;
                Task.TaskStatus? v_ = u_?.Value;
                string w_ = context.Operators.Convert<string>(v_);
                bool? x_ = context.Operators.Equal(w_, "completed");
                bool? y_ = context.Operators.And(t_, x_);
                CqlInterval<CqlDateTime> aa_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, o_);
                CqlDateTime ab_ = context.Operators.End(aa_);
                CqlInterval<CqlDateTime> ac_ = this.Measurement_Period(context);
                bool? ad_ = context.Operators.In<CqlDateTime>(ab_, ac_, "day");
                bool? ae_ = context.Operators.And(y_, ad_);

                return ae_;
            };
            IEnumerable<(CqlTupleMetadata, string ID, CqlDateTime AuthorDate)?> i_ = context.Operators.Where<(CqlTupleMetadata, string ID, CqlDateTime AuthorDate)?>((IEnumerable<(CqlTupleMetadata, string ID, CqlDateTime AuthorDate)?>)g_, h_);
            Task j_((CqlTupleMetadata, string ID, CqlDateTime AuthorDate)? FirstReferral) =>
                ConsultantReportObtained;
            IEnumerable<Task> k_ = context.Operators.Select<(CqlTupleMetadata, string ID, CqlDateTime AuthorDate)?, Task>(i_, j_);

            return k_;
        };
        IEnumerable<Task> d_ = context.Operators.SelectMany<Task, Task>(b_, c_);
        bool? e_ = context.Operators.Exists<Task>(d_);

        return e_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? a_ = this.Referring_Clinician_Receives_Consultant_Report_to_Close_Referral_Loop(context);

        return a_;
    }


    #endregion Functions and Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_EDdTRBfWHaSNbiiXJfIVJUXdb = new(
      [typeof(string), typeof(CqlDateTime)],
      ["ID", "AuthorDate"]);

    #endregion CqlTupleMetadata Properties

}
