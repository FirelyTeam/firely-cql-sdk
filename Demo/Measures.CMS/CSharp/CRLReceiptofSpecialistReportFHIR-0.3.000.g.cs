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

    #region ValueSet: Behavioral/Neuropsych Assessment
    [CqlValueSetDefinition(
        definitionName: "Behavioral/Neuropsych Assessment",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1023",
        valueSetVersion: null)]
    public CqlValueSet Behavioral_Neuropsych_Assessment(CqlContext context) => _Behavioral_Neuropsych_Assessment;

    private static readonly CqlValueSet _Behavioral_Neuropsych_Assessment = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1023", null);
    #endregion

    #region ValueSet: Consultant Report
    [CqlValueSetDefinition(
        definitionName: "Consultant Report",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.121.12.1006",
        valueSetVersion: null)]
    public CqlValueSet Consultant_Report(CqlContext context) => _Consultant_Report;

    private static readonly CqlValueSet _Consultant_Report = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.121.12.1006", null);
    #endregion

    #region ValueSet: Office Visit
    [CqlValueSetDefinition(
        definitionName: "Office Visit",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001",
        valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext context) => _Office_Visit;

    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);
    #endregion

    #region ValueSet: Ophthalmological Services
    [CqlValueSetDefinition(
        definitionName: "Ophthalmological Services",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285",
        valueSetVersion: null)]
    public CqlValueSet Ophthalmological_Services(CqlContext context) => _Ophthalmological_Services;

    private static readonly CqlValueSet _Ophthalmological_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285", null);
    #endregion

    #region ValueSet: Preventive Care Services Established Office Visit, 18 and Up
    [CqlValueSetDefinition(
        definitionName: "Preventive Care Services Established Office Visit, 18 and Up",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025",
        valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up(CqlContext context) => _Preventive_Care_Services_Established_Office_Visit__18_and_Up;

    private static readonly CqlValueSet _Preventive_Care_Services_Established_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);
    #endregion

    #region ValueSet: Preventive Care Services, Initial Office Visit, 0 to 17
    [CqlValueSetDefinition(
        definitionName: "Preventive Care Services, Initial Office Visit, 0 to 17",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022",
        valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services__Initial_Office_Visit__0_to_17(CqlContext context) => _Preventive_Care_Services__Initial_Office_Visit__0_to_17;

    private static readonly CqlValueSet _Preventive_Care_Services__Initial_Office_Visit__0_to_17 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", null);
    #endregion

    #region ValueSet: Preventive Care Services Initial Office Visit, 18 and Up
    [CqlValueSetDefinition(
        definitionName: "Preventive Care Services Initial Office Visit, 18 and Up",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023",
        valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext context) => _Preventive_Care_Services_Initial_Office_Visit__18_and_Up;

    private static readonly CqlValueSet _Preventive_Care_Services_Initial_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);
    #endregion

    #region ValueSet: Preventive Care, Established Office Visit, 0 to 17
    [CqlValueSetDefinition(
        definitionName: "Preventive Care, Established Office Visit, 0 to 17",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024",
        valueSetVersion: null)]
    public CqlValueSet Preventive_Care__Established_Office_Visit__0_to_17(CqlContext context) => _Preventive_Care__Established_Office_Visit__0_to_17;

    private static readonly CqlValueSet _Preventive_Care__Established_Office_Visit__0_to_17 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", null);
    #endregion

    #region ValueSet: Psych Visit Diagnostic Evaluation
    [CqlValueSetDefinition(
        definitionName: "Psych Visit Diagnostic Evaluation",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1492",
        valueSetVersion: null)]
    public CqlValueSet Psych_Visit_Diagnostic_Evaluation(CqlContext context) => _Psych_Visit_Diagnostic_Evaluation;

    private static readonly CqlValueSet _Psych_Visit_Diagnostic_Evaluation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1492", null);
    #endregion

    #region ValueSet: Referral
    [CqlValueSetDefinition(
        definitionName: "Referral",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1046",
        valueSetVersion: null)]
    public CqlValueSet Referral(CqlContext context) => _Referral;

    private static readonly CqlValueSet _Referral = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1046", null);
    #endregion

    #endregion ValueSets

    #region Codes

    #region Code: Developmental test administration (including assessment of fine and/or gross motor, language, cognitive level, social, memory and/or executive functions by standardized developmental instruments when performed), by physician or other qualified health care professional, with interpretation and report; first hour
    [CqlCodeDefinition(
        definitionName: "Developmental test administration (including assessment of fine and/or gross motor, language, cognitive level, social, memory and/or executive functions by standardized developmental instruments when performed), by physician or other qualified health care professional, with interpretation and report; first hour",
        codeId: "96112",
        codeSystem: "http://www.ama-assn.org/go/cpt")]
    public CqlCode Developmental_test_administration__including_assessment_of_fine_and_or_gross_motor__language__cognitive_level__social__memory_and_or_executive_functions_by_standardized_developmental_instruments_when_performed___by_physician_or_other_qualified_health_care_professional__with_interpretation_and_report__first_hour(CqlContext context) => _Developmental_test_administration__including_assessment_of_fine_and_or_gross_motor__language__cognitive_level__social__memory_and_or_executive_functions_by_standardized_developmental_instruments_when_performed___by_physician_or_other_qualified_health_care_professional__with_interpretation_and_report__first_hour;

    private static readonly CqlCode _Developmental_test_administration__including_assessment_of_fine_and_or_gross_motor__language__cognitive_level__social__memory_and_or_executive_functions_by_standardized_developmental_instruments_when_performed___by_physician_or_other_qualified_health_care_professional__with_interpretation_and_report__first_hour = new CqlCode("96112", "http://www.ama-assn.org/go/cpt", default, default);
    #endregion

    #region Code: Health behavior assessment, or re-assessment (ie, health-focused clinical interview, behavioral observations, clinical decision making)
    [CqlCodeDefinition(
        definitionName: "Health behavior assessment, or re-assessment (ie, health-focused clinical interview, behavioral observations, clinical decision making)",
        codeId: "96156",
        codeSystem: "http://www.ama-assn.org/go/cpt")]
    public CqlCode Health_behavior_assessment__or_re_assessment__ie__health_focused_clinical_interview__behavioral_observations__clinical_decision_making_(CqlContext context) => _Health_behavior_assessment__or_re_assessment__ie__health_focused_clinical_interview__behavioral_observations__clinical_decision_making_;

    private static readonly CqlCode _Health_behavior_assessment__or_re_assessment__ie__health_focused_clinical_interview__behavioral_observations__clinical_decision_making_ = new CqlCode("96156", "http://www.ama-assn.org/go/cpt", default, default);
    #endregion

    #region Code: Psychological or neuropsychological test administration and scoring by physician or other qualified health care professional, two or more tests, any method; first 30 minutes
    [CqlCodeDefinition(
        definitionName: "Psychological or neuropsychological test administration and scoring by physician or other qualified health care professional, two or more tests, any method; first 30 minutes",
        codeId: "96136",
        codeSystem: "http://www.ama-assn.org/go/cpt")]
    public CqlCode Psychological_or_neuropsychological_test_administration_and_scoring_by_physician_or_other_qualified_health_care_professional__two_or_more_tests__any_method__first_30_minutes(CqlContext context) => _Psychological_or_neuropsychological_test_administration_and_scoring_by_physician_or_other_qualified_health_care_professional__two_or_more_tests__any_method__first_30_minutes;

    private static readonly CqlCode _Psychological_or_neuropsychological_test_administration_and_scoring_by_physician_or_other_qualified_health_care_professional__two_or_more_tests__any_method__first_30_minutes = new CqlCode("96136", "http://www.ama-assn.org/go/cpt", default, default);
    #endregion

    #region Code: Psychological or neuropsychological test administration and scoring by technician, two or more tests, any method; first 30 minutes
    [CqlCodeDefinition(
        definitionName: "Psychological or neuropsychological test administration and scoring by technician, two or more tests, any method; first 30 minutes",
        codeId: "96138",
        codeSystem: "http://www.ama-assn.org/go/cpt")]
    public CqlCode Psychological_or_neuropsychological_test_administration_and_scoring_by_technician__two_or_more_tests__any_method__first_30_minutes(CqlContext context) => _Psychological_or_neuropsychological_test_administration_and_scoring_by_technician__two_or_more_tests__any_method__first_30_minutes;

    private static readonly CqlCode _Psychological_or_neuropsychological_test_administration_and_scoring_by_technician__two_or_more_tests__any_method__first_30_minutes = new CqlCode("96138", "http://www.ama-assn.org/go/cpt", default, default);
    #endregion

    #region Code: Psychotherapy for crisis; first 60 minutes
    [CqlCodeDefinition(
        definitionName: "Psychotherapy for crisis; first 60 minutes",
        codeId: "90839",
        codeSystem: "http://www.ama-assn.org/go/cpt")]
    public CqlCode Psychotherapy_for_crisis__first_60_minutes(CqlContext context) => _Psychotherapy_for_crisis__first_60_minutes;

    private static readonly CqlCode _Psychotherapy_for_crisis__first_60_minutes = new CqlCode("90839", "http://www.ama-assn.org/go/cpt", default, default);
    #endregion

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition(
        definitionName: "CPT")]
    public CqlCode[] CPT(CqlContext context)
    {
        CqlCode[] azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = [
            new CqlCode("96112", "http://www.ama-assn.org/go/cpt", default, default),
            new CqlCode("96156", "http://www.ama-assn.org/go/cpt", default, default),
            new CqlCode("96136", "http://www.ama-assn.org/go/cpt", default, default),
            new CqlCode("96138", "http://www.ama-assn.org/go/cpt", default, default),
            new CqlCode("90839", "http://www.ama-assn.org/go/cpt", default, default),
        ];

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Interval(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, true, true);
        object azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.ResolveParameter("CRLReceiptofSpecialistReportFHIR-0.3.000", "Measurement Period", azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);

        return (CqlInterval<CqlDateTime>)azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.SingletonFrom<Patient>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

        return azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Encounter from Valuesets during Measurement Period")]
    public bool? Has_Encounter_from_Valuesets_during_Measurement_Period(CqlContext context)
    {
        CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Behavioral_Neuropsych_Assessment(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Office_Visit(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<Encounter>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
        CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Ophthalmological_Services(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Union<Encounter>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<Encounter>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);
        CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Union<Encounter>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Union<Encounter>(azzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
        CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Psych_Visit_Diagnostic_Evaluation(context);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Union<Encounter>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<Encounter>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_(Encounter Encounter)
        {
            Code<Encounter.EncounterStatus> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = Encounter?.StatusElement;
            Encounter.EncounterStatus? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_?.Value;
            Code<Encounter.EncounterStatus> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Equal(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, "finished");
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Measurement_Period(context);
            Period bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = Encounter?.Period;
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, "day");
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

            return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Encounter>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Exists<Encounter>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

        return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Encounter from DRCs during Measurement Period")]
    public bool? Has_Encounter_from_DRCs_during_Measurement_Period(CqlContext context)
    {
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_(Encounter EncDRC)
        {
            List<CodeableConcept> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = EncDRC?.Type;
            CqlConcept czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_(CodeableConcept @this)
            {
                CqlConcept dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<CqlConcept> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_(CqlConcept T)
            {
                CqlCode dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Psychological_or_neuropsychological_test_administration_and_scoring_by_physician_or_other_qualified_health_care_professional__two_or_more_tests__any_method__first_30_minutes(context);
                CqlConcept dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.ConvertCodeToConcept(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Equivalent(T, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);

                return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_;
            };
            IEnumerable<CqlConcept> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<CqlConcept>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Exists<CqlConcept>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlConcept czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_(CodeableConcept @this)
            {
                CqlConcept dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_;
            };
            IEnumerable<CqlConcept> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_(CqlConcept T)
            {
                CqlCode dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Psychological_or_neuropsychological_test_administration_and_scoring_by_technician__two_or_more_tests__any_method__first_30_minutes(context);
                CqlConcept dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.ConvertCodeToConcept(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_);
                bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Equivalent(T, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);

                return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_;
            };
            IEnumerable<CqlConcept> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<CqlConcept>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Exists<CqlConcept>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Or(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlConcept czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_(CodeableConcept @this)
            {
                CqlConcept dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
            };
            IEnumerable<CqlConcept> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_(CqlConcept T)
            {
                CqlCode dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Psychotherapy_for_crisis__first_60_minutes(context);
                CqlConcept dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.ConvertCodeToConcept(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Equivalent(T, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);

                return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<CqlConcept> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<CqlConcept>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Exists<CqlConcept>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Or(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlConcept czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_(CodeableConcept @this)
            {
                CqlConcept dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
            };
            IEnumerable<CqlConcept> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_(CqlConcept T)
            {
                CqlCode dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Developmental_test_administration__including_assessment_of_fine_and_or_gross_motor__language__cognitive_level__social__memory_and_or_executive_functions_by_standardized_developmental_instruments_when_performed___by_physician_or_other_qualified_health_care_professional__with_interpretation_and_report__first_hour(context);
                CqlConcept dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.ConvertCodeToConcept(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
                bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Equivalent(T, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

                return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
            };
            IEnumerable<CqlConcept> czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<CqlConcept>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Exists<CqlConcept>(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Or(czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlConcept dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_(CodeableConcept @this)
            {
                CqlConcept dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_;
            };
            IEnumerable<CqlConcept> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)czzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_(CqlConcept T)
            {
                CqlCode dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Health_behavior_assessment__or_re_assessment__ie__health_focused_clinical_interview__behavioral_observations__clinical_decision_making_(context);
                CqlConcept ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.ConvertCodeToConcept(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Equivalent(T, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

                return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<CqlConcept> dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<CqlConcept>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Exists<CqlConcept>(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Or(dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_, dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);

            return dzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Encounter>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_(Encounter Encounter)
        {
            Code<Encounter.EncounterStatus> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = Encounter?.StatusElement;
            Encounter.EncounterStatus? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_?.Value;
            Code<Encounter.EncounterStatus> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Equal(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, "finished");
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Measurement_Period(context);
            Period ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = Encounter?.Period;
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, "day");
            bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);

            return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Encounter>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Exists<Encounter>(bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

        return bzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Encounter during Measurement Period")]
    public bool? Has_Encounter_during_Measurement_Period(CqlContext context)
    {
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Has_Encounter_from_Valuesets_during_Measurement_Period(context);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Has_Encounter_from_DRCs_during_Measurement_Period(context);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Or(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition(
        definitionName: "First Referral during First 10 Months of Measurement Period")]
    public (CqlTupleMetadata, string ID, CqlDateTime AuthorDate)? First_Referral_during_First_10_Months_of_Measurement_Period(CqlContext context)
    {
        CqlValueSet ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Referral(context);
        IEnumerable<ServiceRequest> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        bool? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_(ServiceRequest ReferralOrder)
        {
            Code<RequestStatus> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = ReferralOrder?.StatusElement;
            RequestStatus? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_?.Value;
            Code<RequestStatus> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<Code<RequestStatus>>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            string fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Convert<string>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);
            string[] fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = [
                "active",
                "completed",
            ];
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<string>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ as IEnumerable<string>);
            Code<RequestIntent> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = ReferralOrder?.IntentElement;
            RequestIntent? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_?.Value;
            Code<RequestIntent> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<Code<RequestIntent>>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Equal(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_, "order");
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            FhirDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = ReferralOrder?.AuthoredOnElement;
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<CqlDateTime>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Measurement_Period(context);
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Start(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            int? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.DateTimeComponentFrom(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_, "year");
            CqlDate fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Date(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, 10, 31);
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ConvertDateToDateTime(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Interval(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, true, true);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.In<CqlDateTime>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, "day");
            bool? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);

            return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<ServiceRequest> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<ServiceRequest>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_);
        (CqlTupleMetadata, string ID, CqlDateTime AuthorDate)? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_(ServiceRequest ReferralOrder)
        {
            Id fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = ReferralOrder?.IdElement;
            string fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_?.Value;
            FhirDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = ReferralOrder?.AuthoredOnElement;
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<CqlDateTime>(fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            (CqlTupleMetadata, string ID, CqlDateTime AuthorDate)? fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = (CqlTupleMetadata_EDdTRBfWHaSNbiiXJfIVJUXdb, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_, fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);

            return fzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<(CqlTupleMetadata, string ID, CqlDateTime AuthorDate)?> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Select<ServiceRequest, (CqlTupleMetadata, string ID, CqlDateTime AuthorDate)?>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<(CqlTupleMetadata, string ID, CqlDateTime AuthorDate)?> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Distinct<(CqlTupleMetadata, string ID, CqlDateTime AuthorDate)?>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        object ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_((CqlTupleMetadata, string ID, CqlDateTime AuthorDate)? @this)
        {
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_ = @this?.AuthorDate;

            return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<(CqlTupleMetadata, string ID, CqlDateTime AuthorDate)?> ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.SortBy<(CqlTupleMetadata, string ID, CqlDateTime AuthorDate)?>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_, ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_, System.ComponentModel.ListSortDirection.Ascending);
        (CqlTupleMetadata, string ID, CqlDateTime AuthorDate)? ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.First<(CqlTupleMetadata, string ID, CqlDateTime AuthorDate)?>(ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_);

        return ezzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Has_Encounter_during_Measurement_Period(context);
        (CqlTupleMetadata, string ID, CqlDateTime AuthorDate)? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.First_Referral_during_First_10_Months_of_Measurement_Period(context);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Not((bool?)(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ is null));
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);

        return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Initial_Population(context);

        return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<string> TaskGetRequestID(CqlContext context, Task task)
    {
        List<ResourceReference> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = task?.BasedOn;
        string gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_(ResourceReference Task)
        {
            FhirString gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = Task?.ReferenceElement;
            string gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_?.Value;
            string gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.GetId(context, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_);

            return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<string> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Select<ResourceReference, string>((IEnumerable<ResourceReference>)gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<string> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Distinct<string>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);

        return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition(
        definitionName: "Referring Clinician Receives Consultant Report to Close Referral Loop")]
    public bool? Referring_Clinician_Receives_Consultant_Report_to_Close_Referral_Loop(CqlContext context)
    {
        CqlValueSet gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Consultant_Report(context);
        IEnumerable<Task> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Task>(new RetrieveParameters(default, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-task"));
        IEnumerable<Task> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_(Task ConsultantReportObtained)
        {
            (CqlTupleMetadata, string ID, CqlDateTime AuthorDate)? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.First_Referral_during_First_10_Months_of_Measurement_Period(context);
            (CqlTupleMetadata, string ID, CqlDateTime AuthorDate)?[] gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_ = [
                gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_,
            ];
            bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_((CqlTupleMetadata, string ID, CqlDateTime AuthorDate)? FirstReferral)
            {
                string hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_ = FirstReferral?.ID;
                IEnumerable<string> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.TaskGetRequestID(context, ConsultantReportObtained);
                bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.In<string>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzc_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzd_);
                Period hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_ = ConsultantReportObtained?.ExecutionPeriod;
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.End(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzg_);
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FirstReferral?.AuthorDate;
                bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.After(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzh_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzi_, default);
                bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzze_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzj_);
                Code<Task.TaskStatus> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_ = ConsultantReportObtained?.StatusElement;
                Task.TaskStatus? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_ = hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzl_?.Value;
                Code<Task.TaskStatus> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Convert<Code<Task.TaskStatus>>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzm_);
                bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Equal(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzn_, "completed");
                bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzk_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.End(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Measurement_Period(context);
                bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_, "day");
                bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzp_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

                return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<(CqlTupleMetadata, string ID, CqlDateTime AuthorDate)?> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Where<(CqlTupleMetadata, string ID, CqlDateTime AuthorDate)?>((IEnumerable<(CqlTupleMetadata, string ID, CqlDateTime AuthorDate)?>)gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzx_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzy_);
            Task hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_((CqlTupleMetadata, string ID, CqlDateTime AuthorDate)? FirstReferral) =>
                ConsultantReportObtained;
            IEnumerable<Task> hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Select<(CqlTupleMetadata, string ID, CqlDateTime AuthorDate)?, Task>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz_, hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzza_);

            return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<Task> gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.SelectMany<Task, Task>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzs_, gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzt_);
        bool? gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Exists<Task>(gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzu_);

        return gzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Referring_Clinician_Receives_Consultant_Report_to_Close_Referral_Loop(context);

        return hzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_EDdTRBfWHaSNbiiXJfIVJUXdb = new(
        [typeof(string), typeof(CqlDateTime)],
        ["ID", "AuthorDate"]);

    #endregion CqlTupleMetadata Properties

}
