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
        CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Interval(ozzzzzzzzzzzzzzzzzzzzzzzzzh_, ozzzzzzzzzzzzzzzzzzzzzzzzzi_, true, true);
        object ozzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.ResolveParameter("CRLReceiptofSpecialistReportFHIR-0.3.000", "Measurement Period", ozzzzzzzzzzzzzzzzzzzzzzzzzj_);

        return (CqlInterval<CqlDateTime>)ozzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> ozzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient ozzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.SingletonFrom<Patient>(ozzzzzzzzzzzzzzzzzzzzzzzzzl_);

        return ozzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Has Encounter from Valuesets during Measurement Period")]
    public bool? Has_Encounter_from_Valuesets_during_Measurement_Period(CqlContext context)
    {
        CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Behavioral_Neuropsych_Assessment(context);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Office_Visit(context);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Union<Encounter>(ozzzzzzzzzzzzzzzzzzzzzzzzzo_, ozzzzzzzzzzzzzzzzzzzzzzzzzq_);
        CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Ophthalmological_Services(context);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzzzzzzs_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Union<Encounter>(ozzzzzzzzzzzzzzzzzzzzzzzzzt_, ozzzzzzzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Union<Encounter>(ozzzzzzzzzzzzzzzzzzzzzzzzzr_, ozzzzzzzzzzzzzzzzzzzzzzzzzw_);
        CqlValueSet ozzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> ozzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ozzzzzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzzza_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Union<Encounter>(ozzzzzzzzzzzzzzzzzzzzzzzzzz_, pzzzzzzzzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Union<Encounter>(ozzzzzzzzzzzzzzzzzzzzzzzzzx_, pzzzzzzzzzzzzzzzzzzzzzzzzzc_);
        CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet pzzzzzzzzzzzzzzzzzzzzzzzzzg_ = this.Psych_Visit_Diagnostic_Evaluation(context);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Union<Encounter>(pzzzzzzzzzzzzzzzzzzzzzzzzzf_, pzzzzzzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Union<Encounter>(pzzzzzzzzzzzzzzzzzzzzzzzzzd_, pzzzzzzzzzzzzzzzzzzzzzzzzzi_);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzk_(Encounter Encounter)
        {
            Code<Encounter.EncounterStatus> pzzzzzzzzzzzzzzzzzzzzzzzzzn_ = Encounter?.StatusElement;
            Encounter.EncounterStatus? pzzzzzzzzzzzzzzzzzzzzzzzzzo_ = pzzzzzzzzzzzzzzzzzzzzzzzzzn_?.Value;
            Code<Encounter.EncounterStatus> pzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(pzzzzzzzzzzzzzzzzzzzzzzzzzo_);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Equal(pzzzzzzzzzzzzzzzzzzzzzzzzzp_, "finished");
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Measurement_Period(context);
            Period pzzzzzzzzzzzzzzzzzzzzzzzzzs_ = Encounter?.Period;
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(pzzzzzzzzzzzzzzzzzzzzzzzzzr_, pzzzzzzzzzzzzzzzzzzzzzzzzzt_, "day");
            bool? pzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzzzzzq_, pzzzzzzzzzzzzzzzzzzzzzzzzzu_);

            return pzzzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Encounter>(pzzzzzzzzzzzzzzzzzzzzzzzzzj_, pzzzzzzzzzzzzzzzzzzzzzzzzzk_);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Exists<Encounter>(pzzzzzzzzzzzzzzzzzzzzzzzzzl_);

        return pzzzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Has Encounter from DRCs during Measurement Period")]
    public bool? Has_Encounter_from_DRCs_during_Measurement_Period(CqlContext context)
    {
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzx_(Encounter EncDRC)
        {
            List<CodeableConcept> qzzzzzzzzzzzzzzzzzzzzzzzzzc_ = EncDRC?.Type;
            CqlConcept qzzzzzzzzzzzzzzzzzzzzzzzzzd_(CodeableConcept @this)
            {
                CqlConcept rzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return rzzzzzzzzzzzzzzzzzzzzzzzzzk_;
            };
            IEnumerable<CqlConcept> qzzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)qzzzzzzzzzzzzzzzzzzzzzzzzzc_, qzzzzzzzzzzzzzzzzzzzzzzzzzd_);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzf_(CqlConcept T)
            {
                CqlCode rzzzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Psychological_or_neuropsychological_test_administration_and_scoring_by_physician_or_other_qualified_health_care_professional__two_or_more_tests__any_method__first_30_minutes(context);
                CqlConcept rzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.ConvertCodeToConcept(rzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Equivalent(T, rzzzzzzzzzzzzzzzzzzzzzzzzzm_);

                return rzzzzzzzzzzzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<CqlConcept> qzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<CqlConcept>(qzzzzzzzzzzzzzzzzzzzzzzzzze_, qzzzzzzzzzzzzzzzzzzzzzzzzzf_);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Exists<CqlConcept>(qzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlConcept qzzzzzzzzzzzzzzzzzzzzzzzzzj_(CodeableConcept @this)
            {
                CqlConcept rzzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return rzzzzzzzzzzzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<CqlConcept> qzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)qzzzzzzzzzzzzzzzzzzzzzzzzzc_, qzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzl_(CqlConcept T)
            {
                CqlCode rzzzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Psychological_or_neuropsychological_test_administration_and_scoring_by_technician__two_or_more_tests__any_method__first_30_minutes(context);
                CqlConcept rzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.ConvertCodeToConcept(rzzzzzzzzzzzzzzzzzzzzzzzzzp_);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Equivalent(T, rzzzzzzzzzzzzzzzzzzzzzzzzzq_);

                return rzzzzzzzzzzzzzzzzzzzzzzzzzr_;
            };
            IEnumerable<CqlConcept> qzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<CqlConcept>(qzzzzzzzzzzzzzzzzzzzzzzzzzk_, qzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Exists<CqlConcept>(qzzzzzzzzzzzzzzzzzzzzzzzzzm_);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Or(qzzzzzzzzzzzzzzzzzzzzzzzzzh_, qzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlConcept qzzzzzzzzzzzzzzzzzzzzzzzzzq_(CodeableConcept @this)
            {
                CqlConcept rzzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return rzzzzzzzzzzzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<CqlConcept> qzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)qzzzzzzzzzzzzzzzzzzzzzzzzzc_, qzzzzzzzzzzzzzzzzzzzzzzzzzq_);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzs_(CqlConcept T)
            {
                CqlCode rzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Psychotherapy_for_crisis__first_60_minutes(context);
                CqlConcept rzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.ConvertCodeToConcept(rzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Equivalent(T, rzzzzzzzzzzzzzzzzzzzzzzzzzu_);

                return rzzzzzzzzzzzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<CqlConcept> qzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<CqlConcept>(qzzzzzzzzzzzzzzzzzzzzzzzzzr_, qzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Exists<CqlConcept>(qzzzzzzzzzzzzzzzzzzzzzzzzzt_);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Or(qzzzzzzzzzzzzzzzzzzzzzzzzzo_, qzzzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlConcept qzzzzzzzzzzzzzzzzzzzzzzzzzx_(CodeableConcept @this)
            {
                CqlConcept rzzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return rzzzzzzzzzzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<CqlConcept> qzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)qzzzzzzzzzzzzzzzzzzzzzzzzzc_, qzzzzzzzzzzzzzzzzzzzzzzzzzx_);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzzzz_(CqlConcept T)
            {
                CqlCode rzzzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Developmental_test_administration__including_assessment_of_fine_and_or_gross_motor__language__cognitive_level__social__memory_and_or_executive_functions_by_standardized_developmental_instruments_when_performed___by_physician_or_other_qualified_health_care_professional__with_interpretation_and_report__first_hour(context);
                CqlConcept rzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.ConvertCodeToConcept(rzzzzzzzzzzzzzzzzzzzzzzzzzx_);
                bool? rzzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Equivalent(T, rzzzzzzzzzzzzzzzzzzzzzzzzzy_);

                return rzzzzzzzzzzzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<CqlConcept> rzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<CqlConcept>(qzzzzzzzzzzzzzzzzzzzzzzzzzy_, qzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Exists<CqlConcept>(rzzzzzzzzzzzzzzzzzzzzzzzzza_);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Or(qzzzzzzzzzzzzzzzzzzzzzzzzzv_, rzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlConcept rzzzzzzzzzzzzzzzzzzzzzzzzze_(CodeableConcept @this)
            {
                CqlConcept szzzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return szzzzzzzzzzzzzzzzzzzzzzzzza_;
            };
            IEnumerable<CqlConcept> rzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)qzzzzzzzzzzzzzzzzzzzzzzzzzc_, rzzzzzzzzzzzzzzzzzzzzzzzzze_);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzg_(CqlConcept T)
            {
                CqlCode szzzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Health_behavior_assessment__or_re_assessment__ie__health_focused_clinical_interview__behavioral_observations__clinical_decision_making_(context);
                CqlConcept szzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.ConvertCodeToConcept(szzzzzzzzzzzzzzzzzzzzzzzzzb_);
                bool? szzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Equivalent(T, szzzzzzzzzzzzzzzzzzzzzzzzzc_);

                return szzzzzzzzzzzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<CqlConcept> rzzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<CqlConcept>(rzzzzzzzzzzzzzzzzzzzzzzzzzf_, rzzzzzzzzzzzzzzzzzzzzzzzzzg_);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Exists<CqlConcept>(rzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Or(rzzzzzzzzzzzzzzzzzzzzzzzzzc_, rzzzzzzzzzzzzzzzzzzzzzzzzzi_);

            return rzzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Encounter>(pzzzzzzzzzzzzzzzzzzzzzzzzzw_, pzzzzzzzzzzzzzzzzzzzzzzzzzx_);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzzzz_(Encounter Encounter)
        {
            Code<Encounter.EncounterStatus> szzzzzzzzzzzzzzzzzzzzzzzzze_ = Encounter?.StatusElement;
            Encounter.EncounterStatus? szzzzzzzzzzzzzzzzzzzzzzzzzf_ = szzzzzzzzzzzzzzzzzzzzzzzzze_?.Value;
            Code<Encounter.EncounterStatus> szzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(szzzzzzzzzzzzzzzzzzzzzzzzzf_);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Equal(szzzzzzzzzzzzzzzzzzzzzzzzzg_, "finished");
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Measurement_Period(context);
            Period szzzzzzzzzzzzzzzzzzzzzzzzzj_ = Encounter?.Period;
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzzzzzzzzzzzzzzzzzzzj_);
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(szzzzzzzzzzzzzzzzzzzzzzzzzi_, szzzzzzzzzzzzzzzzzzzzzzzzzk_, "day");
            bool? szzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(szzzzzzzzzzzzzzzzzzzzzzzzzh_, szzzzzzzzzzzzzzzzzzzzzzzzzl_);

            return szzzzzzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Encounter>(pzzzzzzzzzzzzzzzzzzzzzzzzzy_, pzzzzzzzzzzzzzzzzzzzzzzzzzz_);
        bool? qzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Exists<Encounter>(qzzzzzzzzzzzzzzzzzzzzzzzzza_);

        return qzzzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Has Encounter during Measurement Period")]
    public bool? Has_Encounter_during_Measurement_Period(CqlContext context)
    {
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Has_Encounter_from_Valuesets_during_Measurement_Period(context);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Has_Encounter_from_DRCs_during_Measurement_Period(context);
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Or(szzzzzzzzzzzzzzzzzzzzzzzzzn_, szzzzzzzzzzzzzzzzzzzzzzzzzo_);

        return szzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("First Referral during First 10 Months of Measurement Period")]
    public (CqlTupleMetadata, string ID, CqlDateTime AuthorDate)? First_Referral_during_First_10_Months_of_Measurement_Period(CqlContext context)
    {
        CqlValueSet szzzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Referral(context);
        IEnumerable<ServiceRequest> szzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, szzzzzzzzzzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        bool? szzzzzzzzzzzzzzzzzzzzzzzzzs_(ServiceRequest ReferralOrder)
        {
            Code<RequestStatus> tzzzzzzzzzzzzzzzzzzzzzzzzza_ = ReferralOrder?.StatusElement;
            RequestStatus? tzzzzzzzzzzzzzzzzzzzzzzzzzb_ = tzzzzzzzzzzzzzzzzzzzzzzzzza_?.Value;
            Code<RequestStatus> tzzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<Code<RequestStatus>>(tzzzzzzzzzzzzzzzzzzzzzzzzzb_);
            string tzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Convert<string>(tzzzzzzzzzzzzzzzzzzzzzzzzzc_);
            string[] tzzzzzzzzzzzzzzzzzzzzzzzzze_ = [
                "active",
                "completed",
            ];
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.In<string>(tzzzzzzzzzzzzzzzzzzzzzzzzzd_, tzzzzzzzzzzzzzzzzzzzzzzzzze_ as IEnumerable<string>);
            Code<RequestIntent> tzzzzzzzzzzzzzzzzzzzzzzzzzg_ = ReferralOrder?.IntentElement;
            RequestIntent? tzzzzzzzzzzzzzzzzzzzzzzzzzh_ = tzzzzzzzzzzzzzzzzzzzzzzzzzg_?.Value;
            Code<RequestIntent> tzzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Convert<Code<RequestIntent>>(tzzzzzzzzzzzzzzzzzzzzzzzzzh_);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Equal(tzzzzzzzzzzzzzzzzzzzzzzzzzi_, "order");
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzzzzf_, tzzzzzzzzzzzzzzzzzzzzzzzzzj_);
            FhirDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzl_ = ReferralOrder?.AuthoredOnElement;
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Convert<CqlDateTime>(tzzzzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Measurement_Period(context);
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzzzzzzzzzn_);
            int? tzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.DateTimeComponentFrom(tzzzzzzzzzzzzzzzzzzzzzzzzzq_, "year");
            CqlDate tzzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Date(tzzzzzzzzzzzzzzzzzzzzzzzzzr_, 10, 31);
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.ConvertDateToDateTime(tzzzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Interval(tzzzzzzzzzzzzzzzzzzzzzzzzzo_, tzzzzzzzzzzzzzzzzzzzzzzzzzt_, true, true);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.In<CqlDateTime>(tzzzzzzzzzzzzzzzzzzzzzzzzzm_, tzzzzzzzzzzzzzzzzzzzzzzzzzu_, "day");
            bool? tzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzzzzk_, tzzzzzzzzzzzzzzzzzzzzzzzzzv_);

            return tzzzzzzzzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<ServiceRequest> szzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Where<ServiceRequest>(szzzzzzzzzzzzzzzzzzzzzzzzzr_, szzzzzzzzzzzzzzzzzzzzzzzzzs_);
        (CqlTupleMetadata, string ID, CqlDateTime AuthorDate)? szzzzzzzzzzzzzzzzzzzzzzzzzu_(ServiceRequest ReferralOrder)
        {
            Id tzzzzzzzzzzzzzzzzzzzzzzzzzx_ = ReferralOrder?.IdElement;
            string tzzzzzzzzzzzzzzzzzzzzzzzzzy_ = tzzzzzzzzzzzzzzzzzzzzzzzzzx_?.Value;
            FhirDateTime tzzzzzzzzzzzzzzzzzzzzzzzzzz_ = ReferralOrder?.AuthoredOnElement;
            CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<CqlDateTime>(tzzzzzzzzzzzzzzzzzzzzzzzzzz_);
            (CqlTupleMetadata, string ID, CqlDateTime AuthorDate)? uzzzzzzzzzzzzzzzzzzzzzzzzzb_ = (CqlTupleMetadata_EDdTRBfWHaSNbiiXJfIVJUXdb, tzzzzzzzzzzzzzzzzzzzzzzzzzy_, uzzzzzzzzzzzzzzzzzzzzzzzzza_);

            return uzzzzzzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<(CqlTupleMetadata, string ID, CqlDateTime AuthorDate)?> szzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Select<ServiceRequest, (CqlTupleMetadata, string ID, CqlDateTime AuthorDate)?>(szzzzzzzzzzzzzzzzzzzzzzzzzt_, szzzzzzzzzzzzzzzzzzzzzzzzzu_);
        IEnumerable<(CqlTupleMetadata, string ID, CqlDateTime AuthorDate)?> szzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Distinct<(CqlTupleMetadata, string ID, CqlDateTime AuthorDate)?>(szzzzzzzzzzzzzzzzzzzzzzzzzv_);
        object szzzzzzzzzzzzzzzzzzzzzzzzzx_((CqlTupleMetadata, string ID, CqlDateTime AuthorDate)? @this)
        {
            CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzzzzc_ = @this?.AuthorDate;

            return uzzzzzzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<(CqlTupleMetadata, string ID, CqlDateTime AuthorDate)?> szzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.SortBy<(CqlTupleMetadata, string ID, CqlDateTime AuthorDate)?>(szzzzzzzzzzzzzzzzzzzzzzzzzw_, szzzzzzzzzzzzzzzzzzzzzzzzzx_, System.ComponentModel.ListSortDirection.Ascending);
        (CqlTupleMetadata, string ID, CqlDateTime AuthorDate)? szzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.First<(CqlTupleMetadata, string ID, CqlDateTime AuthorDate)?>(szzzzzzzzzzzzzzzzzzzzzzzzzy_);

        return szzzzzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Has_Encounter_during_Measurement_Period(context);
        (CqlTupleMetadata, string ID, CqlDateTime AuthorDate)? uzzzzzzzzzzzzzzzzzzzzzzzzze_ = this.First_Referral_during_First_10_Months_of_Measurement_Period(context);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Not((bool?)(uzzzzzzzzzzzzzzzzzzzzzzzzze_ is null));
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzzzzzzzd_, uzzzzzzzzzzzzzzzzzzzzzzzzzf_);

        return uzzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Initial_Population(context);

        return uzzzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? uzzzzzzzzzzzzzzzzzzzzzzzzzi_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return uzzzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> uzzzzzzzzzzzzzzzzzzzzzzzzzj_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return uzzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? uzzzzzzzzzzzzzzzzzzzzzzzzzk_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return uzzzzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode uzzzzzzzzzzzzzzzzzzzzzzzzzl_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return uzzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("TaskGetRequestID")]
    public IEnumerable<string> TaskGetRequestID(CqlContext context, Task task)
    {
        List<ResourceReference> uzzzzzzzzzzzzzzzzzzzzzzzzzm_ = task?.BasedOn;
        string uzzzzzzzzzzzzzzzzzzzzzzzzzn_(ResourceReference Task)
        {
            FhirString uzzzzzzzzzzzzzzzzzzzzzzzzzq_ = Task?.ReferenceElement;
            string uzzzzzzzzzzzzzzzzzzzzzzzzzr_ = uzzzzzzzzzzzzzzzzzzzzzzzzzq_?.Value;
            string uzzzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.GetId(context, uzzzzzzzzzzzzzzzzzzzzzzzzzr_);

            return uzzzzzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<string> uzzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Select<ResourceReference, string>((IEnumerable<ResourceReference>)uzzzzzzzzzzzzzzzzzzzzzzzzzm_, uzzzzzzzzzzzzzzzzzzzzzzzzzn_);
        IEnumerable<string> uzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Distinct<string>(uzzzzzzzzzzzzzzzzzzzzzzzzzo_);

        return uzzzzzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Referring Clinician Receives Consultant Report to Close Referral Loop")]
    public bool? Referring_Clinician_Receives_Consultant_Report_to_Close_Referral_Loop(CqlContext context)
    {
        CqlValueSet uzzzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Consultant_Report(context);
        IEnumerable<Task> uzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Task>(new RetrieveParameters(default, uzzzzzzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-task"));
        IEnumerable<Task> uzzzzzzzzzzzzzzzzzzzzzzzzzv_(Task ConsultantReportObtained)
        {
            (CqlTupleMetadata, string ID, CqlDateTime AuthorDate)? uzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.First_Referral_during_First_10_Months_of_Measurement_Period(context);
            (CqlTupleMetadata, string ID, CqlDateTime AuthorDate)?[] uzzzzzzzzzzzzzzzzzzzzzzzzzz_ = [
                uzzzzzzzzzzzzzzzzzzzzzzzzzy_,
            ];
            bool? vzzzzzzzzzzzzzzzzzzzzzzzzza_((CqlTupleMetadata, string ID, CqlDateTime AuthorDate)? FirstReferral)
            {
                string vzzzzzzzzzzzzzzzzzzzzzzzzze_ = FirstReferral?.ID;
                IEnumerable<string> vzzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.TaskGetRequestID(context, ConsultantReportObtained);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.In<string>(vzzzzzzzzzzzzzzzzzzzzzzzzze_, vzzzzzzzzzzzzzzzzzzzzzzzzzf_);
                Period vzzzzzzzzzzzzzzzzzzzzzzzzzh_ = ConsultantReportObtained?.ExecutionPeriod;
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.End(vzzzzzzzzzzzzzzzzzzzzzzzzzi_);
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzk_ = FirstReferral?.AuthorDate;
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.After(vzzzzzzzzzzzzzzzzzzzzzzzzzj_, vzzzzzzzzzzzzzzzzzzzzzzzzzk_, default);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzzzzzzg_, vzzzzzzzzzzzzzzzzzzzzzzzzzl_);
                Code<Task.TaskStatus> vzzzzzzzzzzzzzzzzzzzzzzzzzn_ = ConsultantReportObtained?.StatusElement;
                Task.TaskStatus? vzzzzzzzzzzzzzzzzzzzzzzzzzo_ = vzzzzzzzzzzzzzzzzzzzzzzzzzn_?.Value;
                Code<Task.TaskStatus> vzzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Convert<Code<Task.TaskStatus>>(vzzzzzzzzzzzzzzzzzzzzzzzzzo_);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Equal(vzzzzzzzzzzzzzzzzzzzzzzzzzp_, "completed");
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzzzzzzm_, vzzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzzzzzzzzzzzzzzzzzzh_);
                CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.End(vzzzzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Measurement_Period(context);
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.In<CqlDateTime>(vzzzzzzzzzzzzzzzzzzzzzzzzzu_, vzzzzzzzzzzzzzzzzzzzzzzzzzv_, "day");
                bool? vzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzzzzzzr_, vzzzzzzzzzzzzzzzzzzzzzzzzzw_);

                return vzzzzzzzzzzzzzzzzzzzzzzzzzx_;
            };
            IEnumerable<(CqlTupleMetadata, string ID, CqlDateTime AuthorDate)?> vzzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<(CqlTupleMetadata, string ID, CqlDateTime AuthorDate)?>((IEnumerable<(CqlTupleMetadata, string ID, CqlDateTime AuthorDate)?>)uzzzzzzzzzzzzzzzzzzzzzzzzzz_, vzzzzzzzzzzzzzzzzzzzzzzzzza_);
            Task vzzzzzzzzzzzzzzzzzzzzzzzzzc_((CqlTupleMetadata, string ID, CqlDateTime AuthorDate)? FirstReferral) =>
                ConsultantReportObtained;
            IEnumerable<Task> vzzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Select<(CqlTupleMetadata, string ID, CqlDateTime AuthorDate)?, Task>(vzzzzzzzzzzzzzzzzzzzzzzzzzb_, vzzzzzzzzzzzzzzzzzzzzzzzzzc_);

            return vzzzzzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<Task> uzzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.SelectMany<Task, Task>(uzzzzzzzzzzzzzzzzzzzzzzzzzu_, uzzzzzzzzzzzzzzzzzzzzzzzzzv_);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Exists<Task>(uzzzzzzzzzzzzzzzzzzzzzzzzzw_);

        return uzzzzzzzzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? vzzzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Referring_Clinician_Receives_Consultant_Report_to_Close_Referral_Loop(context);

        return vzzzzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_EDdTRBfWHaSNbiiXJfIVJUXdb = new(
        [typeof(string), typeof(CqlDateTime)],
        ["ID", "AuthorDate"]);

    #endregion CqlTupleMetadata Properties

}
