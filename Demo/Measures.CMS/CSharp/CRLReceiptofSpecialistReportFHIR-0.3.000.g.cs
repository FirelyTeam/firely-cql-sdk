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
[CqlLibrary("CRLReceiptofSpecialistReportFHIR", "0.3.000")]
public partial class CRLReceiptofSpecialistReportFHIR_0_3_000 : ILibrary, ISingleton<CRLReceiptofSpecialistReportFHIR_0_3_000>
{
    private CRLReceiptofSpecialistReportFHIR_0_3_000() {}

    public static CRLReceiptofSpecialistReportFHIR_0_3_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "CRLReceiptofSpecialistReportFHIR";
    public string Version => "0.3.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_3_5_000.Instance, QICoreCommon_2_1_000.Instance];

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
    private static readonly CqlCode _Developmental_test_administration__including_assessment_of_fine_and_or_gross_motor__language__cognitive_level__social__memory_and_or_executive_functions_by_standardized_developmental_instruments_when_performed___by_physician_or_other_qualified_health_care_professional__with_interpretation_and_report__first_hour = new CqlCode("96112", "http://www.ama-assn.org/go/cpt", default, default);

    [CqlCodeDefinition("Health behavior assessment, or re-assessment (ie, health-focused clinical interview, behavioral observations, clinical decision making)", codeId: "96156", codeSystem: "http://www.ama-assn.org/go/cpt")]
    public CqlCode Health_behavior_assessment__or_re_assessment__ie__health_focused_clinical_interview__behavioral_observations__clinical_decision_making_(CqlContext _) => _Health_behavior_assessment__or_re_assessment__ie__health_focused_clinical_interview__behavioral_observations__clinical_decision_making_;
    private static readonly CqlCode _Health_behavior_assessment__or_re_assessment__ie__health_focused_clinical_interview__behavioral_observations__clinical_decision_making_ = new CqlCode("96156", "http://www.ama-assn.org/go/cpt", default, default);

    [CqlCodeDefinition("Psychological or neuropsychological test administration and scoring by physician or other qualified health care professional, two or more tests, any method; first 30 minutes", codeId: "96136", codeSystem: "http://www.ama-assn.org/go/cpt")]
    public CqlCode Psychological_or_neuropsychological_test_administration_and_scoring_by_physician_or_other_qualified_health_care_professional__two_or_more_tests__any_method__first_30_minutes(CqlContext _) => _Psychological_or_neuropsychological_test_administration_and_scoring_by_physician_or_other_qualified_health_care_professional__two_or_more_tests__any_method__first_30_minutes;
    private static readonly CqlCode _Psychological_or_neuropsychological_test_administration_and_scoring_by_physician_or_other_qualified_health_care_professional__two_or_more_tests__any_method__first_30_minutes = new CqlCode("96136", "http://www.ama-assn.org/go/cpt", default, default);

    [CqlCodeDefinition("Psychological or neuropsychological test administration and scoring by technician, two or more tests, any method; first 30 minutes", codeId: "96138", codeSystem: "http://www.ama-assn.org/go/cpt")]
    public CqlCode Psychological_or_neuropsychological_test_administration_and_scoring_by_technician__two_or_more_tests__any_method__first_30_minutes(CqlContext _) => _Psychological_or_neuropsychological_test_administration_and_scoring_by_technician__two_or_more_tests__any_method__first_30_minutes;
    private static readonly CqlCode _Psychological_or_neuropsychological_test_administration_and_scoring_by_technician__two_or_more_tests__any_method__first_30_minutes = new CqlCode("96138", "http://www.ama-assn.org/go/cpt", default, default);

    [CqlCodeDefinition("Psychotherapy for crisis; first 60 minutes", codeId: "90839", codeSystem: "http://www.ama-assn.org/go/cpt")]
    public CqlCode Psychotherapy_for_crisis__first_60_minutes(CqlContext _) => _Psychotherapy_for_crisis__first_60_minutes;
    private static readonly CqlCode _Psychotherapy_for_crisis__first_60_minutes = new CqlCode("90839", "http://www.ama-assn.org/go/cpt", default, default);

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("CPT")]
    public CqlCodeSystem CPT(CqlContext _) => _CPT;
    private static readonly CqlCodeSystem _CPT = new CqlCodeSystem();

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Interval(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, true, true);
        object hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.ResolveParameter("CRLReceiptofSpecialistReportFHIR-0.3.000", "Measurement Period", hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);

        return (CqlInterval<CqlDateTime>)hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.SingletonFrom<Patient>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

        return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Has Encounter from Valuesets during Measurement Period")]
    public bool? Has_Encounter_from_Valuesets_during_Measurement_Period(CqlContext context)
    {
        CqlValueSet hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Behavioral_Neuropsych_Assessment(context);
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Office_Visit(context);
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Union<Encounter>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
        CqlValueSet izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Ophthalmological_Services(context);
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<Encounter>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Union<Encounter>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
        CqlValueSet izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<Encounter>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Union<Encounter>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        CqlValueSet izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Psych_Visit_Diagnostic_Evaluation(context);
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<Encounter>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Union<Encounter>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(Encounter Encounter)
        {
            Code<Encounter.EncounterStatus> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = Encounter?.StatusElement;
            Encounter.EncounterStatus? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_?.Value;
            Code<Encounter.EncounterStatus> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
            bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Equal(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, "finished");
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Measurement_Period(context);
            Period jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = Encounter?.Period;
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, "day");
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

            return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<Encounter>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        bool? izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Exists<Encounter>(izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

        return izzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Has Encounter from DRCs during Measurement Period")]
    public bool? Has_Encounter_from_DRCs_during_Measurement_Period(CqlContext context)
    {
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_(Encounter EncDRC)
        {
            List<CodeableConcept> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = EncDRC?.Type;
            CqlConcept jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_(CodeableConcept @this)
            {
                CqlConcept kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<CqlConcept> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_(CqlConcept T)
            {
                CqlCode kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Psychological_or_neuropsychological_test_administration_and_scoring_by_physician_or_other_qualified_health_care_professional__two_or_more_tests__any_method__first_30_minutes(context);
                CqlConcept kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.ConvertCodeToConcept(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Equivalent(T, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

                return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<CqlConcept> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<CqlConcept>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Exists<CqlConcept>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlConcept jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_(CodeableConcept @this)
            {
                CqlConcept kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<CqlConcept> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_(CqlConcept T)
            {
                CqlCode kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Psychological_or_neuropsychological_test_administration_and_scoring_by_technician__two_or_more_tests__any_method__first_30_minutes(context);
                CqlConcept kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.ConvertCodeToConcept(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Equivalent(T, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

                return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<CqlConcept> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<CqlConcept>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Exists<CqlConcept>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Or(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlConcept jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_(CodeableConcept @this)
            {
                CqlConcept lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
            };
            IEnumerable<CqlConcept> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_(CqlConcept T)
            {
                CqlCode lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Psychotherapy_for_crisis__first_60_minutes(context);
                CqlConcept lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.ConvertCodeToConcept(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Equivalent(T, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);

                return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<CqlConcept> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<CqlConcept>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Exists<CqlConcept>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Or(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlConcept kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_(CodeableConcept @this)
            {
                CqlConcept lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<CqlConcept> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(CqlConcept T)
            {
                CqlCode lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Developmental_test_administration__including_assessment_of_fine_and_or_gross_motor__language__cognitive_level__social__memory_and_or_executive_functions_by_standardized_developmental_instruments_when_performed___by_physician_or_other_qualified_health_care_professional__with_interpretation_and_report__first_hour(context);
                CqlConcept lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.ConvertCodeToConcept(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Equivalent(T, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

                return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<CqlConcept> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<CqlConcept>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Exists<CqlConcept>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Or(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlConcept kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_(CodeableConcept @this)
            {
                CqlConcept lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<CqlConcept> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(CqlConcept T)
            {
                CqlCode lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Health_behavior_assessment__or_re_assessment__ie__health_focused_clinical_interview__behavioral_observations__clinical_decision_making_(context);
                CqlConcept lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.ConvertCodeToConcept(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Equivalent(T, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

                return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
            };
            IEnumerable<CqlConcept> kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<CqlConcept>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Exists<CqlConcept>(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Or(kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);

            return kzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Encounter>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(Encounter Encounter)
        {
            Code<Encounter.EncounterStatus> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = Encounter?.StatusElement;
            Encounter.EncounterStatus? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_?.Value;
            Code<Encounter.EncounterStatus> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Equal(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, "finished");
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Measurement_Period(context);
            Period lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = Encounter?.Period;
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, "day");
            bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

            return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Encounter>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        bool? jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Exists<Encounter>(jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

        return jzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Has Encounter during Measurement Period")]
    public bool? Has_Encounter_during_Measurement_Period(CqlContext context)
    {
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Has_Encounter_from_Valuesets_during_Measurement_Period(context);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Has_Encounter_from_DRCs_during_Measurement_Period(context);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Or(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

        return lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("First Referral during First 10 Months of Measurement Period")]
    public (CqlTupleMetadata, string ID, CqlDateTime AuthorDate)? First_Referral_during_First_10_Months_of_Measurement_Period(CqlContext context)
    {
        CqlValueSet lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Referral(context);
        IEnumerable<ServiceRequest> lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_(ServiceRequest ReferralOrder)
        {
            Code<RequestStatus> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = ReferralOrder?.StatusElement;
            RequestStatus? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_?.Value;
            Code<RequestStatus> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<Code<RequestStatus>>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            string mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<string>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            string[] mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = [
                "active",
                "completed",
            ];
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.In<string>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ as IEnumerable<string>);
            Code<RequestIntent> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = ReferralOrder?.IntentElement;
            RequestIntent? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_?.Value;
            Code<RequestIntent> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<Code<RequestIntent>>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Equal(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, "order");
            bool? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            FhirDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = ReferralOrder?.AuthoredOnElement;
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Convert<CqlDateTime>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Measurement_Period(context);
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            int? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.DateTimeComponentFrom(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, "year");
            CqlDate nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Date(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, 10, 31);
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.ConvertDateToDateTime(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Interval(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, true, true);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, "day");
            bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

            return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<ServiceRequest> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<ServiceRequest>(lzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        (CqlTupleMetadata, string ID, CqlDateTime AuthorDate)? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_(ServiceRequest ReferralOrder)
        {
            Id nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = ReferralOrder?.IdElement;
            string nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_?.Value;
            FhirDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = ReferralOrder?.AuthoredOnElement;
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Convert<CqlDateTime>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            (CqlTupleMetadata, string ID, CqlDateTime AuthorDate)? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = (CqlTupleMetadata_EDdTRBfWHaSNbiiXJfIVJUXdb, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);

            return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<(CqlTupleMetadata, string ID, CqlDateTime AuthorDate)?> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Select<ServiceRequest, (CqlTupleMetadata, string ID, CqlDateTime AuthorDate)?>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<(CqlTupleMetadata, string ID, CqlDateTime AuthorDate)?> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Distinct<(CqlTupleMetadata, string ID, CqlDateTime AuthorDate)?>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        object mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_((CqlTupleMetadata, string ID, CqlDateTime AuthorDate)? @this)
        {
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = @this?.AuthorDate;

            return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<(CqlTupleMetadata, string ID, CqlDateTime AuthorDate)?> mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.SortBy<(CqlTupleMetadata, string ID, CqlDateTime AuthorDate)?>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, System.ComponentModel.ListSortDirection.Ascending);
        (CqlTupleMetadata, string ID, CqlDateTime AuthorDate)? mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.First<(CqlTupleMetadata, string ID, CqlDateTime AuthorDate)?>(mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

        return mzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Has_Encounter_during_Measurement_Period(context);
        (CqlTupleMetadata, string ID, CqlDateTime AuthorDate)? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.First_Referral_during_First_10_Months_of_Measurement_Period(context);
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Not((bool?)(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ is null));
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);

        return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Initial_Population(context);

        return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("TaskGetRequestID")]
    public IEnumerable<string> TaskGetRequestID(CqlContext context, Task task)
    {
        List<ResourceReference> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = task?.BasedOn;
        string nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_(ResourceReference Task)
        {
            FhirString nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = Task?.ReferenceElement;
            string nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_?.Value;
            string ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.GetId(context, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);

            return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<string> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Select<ResourceReference, string>((IEnumerable<ResourceReference>)nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<string> nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Distinct<string>(nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

        return nzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Referring Clinician Receives Consultant Report to Close Referral Loop")]
    public bool? Referring_Clinician_Receives_Consultant_Report_to_Close_Referral_Loop(CqlContext context)
    {
        CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Consultant_Report(context);
        IEnumerable<Task> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Task>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-task"));
        IEnumerable<Task> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_(Task ConsultantReportObtained)
        {
            (CqlTupleMetadata, string ID, CqlDateTime AuthorDate)? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.First_Referral_during_First_10_Months_of_Measurement_Period(context);
            (CqlTupleMetadata, string ID, CqlDateTime AuthorDate)?[] ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = [
                ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_,
            ];
            bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_((CqlTupleMetadata, string ID, CqlDateTime AuthorDate)? FirstReferral)
            {
                string ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FirstReferral?.ID;
                IEnumerable<string> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.TaskGetRequestID(context, ConsultantReportObtained);
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.In<string>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                Period ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = ConsultantReportObtained?.ExecutionPeriod;
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.End(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FirstReferral?.AuthorDate;
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.After(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, default);
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                Code<Task.TaskStatus> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = ConsultantReportObtained?.StatusElement;
                Task.TaskStatus? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_?.Value;
                Code<Task.TaskStatus> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<Code<Task.TaskStatus>>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Equal(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, "completed");
                bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.End(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Measurement_Period(context);
                bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.In<CqlDateTime>(pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, "day");
                bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

                return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<(CqlTupleMetadata, string ID, CqlDateTime AuthorDate)?> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<(CqlTupleMetadata, string ID, CqlDateTime AuthorDate)?>((IEnumerable<(CqlTupleMetadata, string ID, CqlDateTime AuthorDate)?>)ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
            Task ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_((CqlTupleMetadata, string ID, CqlDateTime AuthorDate)? FirstReferral) =>
                ConsultantReportObtained;
            IEnumerable<Task> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Select<(CqlTupleMetadata, string ID, CqlDateTime AuthorDate)?, Task>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

            return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Task> ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.SelectMany<Task, Task>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
        bool? ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Exists<Task>(ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Referring_Clinician_Receives_Consultant_Report_to_Close_Referral_Loop(context);

        return pzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_EDdTRBfWHaSNbiiXJfIVJUXdb = new(
        [typeof(string), typeof(CqlDateTime)],
        ["ID", "AuthorDate"]);

    #endregion CqlTupleMetadata Properties

}
