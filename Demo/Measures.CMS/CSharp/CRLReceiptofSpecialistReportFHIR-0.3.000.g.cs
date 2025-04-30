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

    [CqlCodeSystemDefinition("CPT")]
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
        CqlDateTime hzzzzzzzzzzzzzzzzd_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime hzzzzzzzzzzzzzzzze_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzf_ = context.Operators.Interval(hzzzzzzzzzzzzzzzzd_, hzzzzzzzzzzzzzzzze_, true, true);
        object hzzzzzzzzzzzzzzzzg_ = context.ResolveParameter("CRLReceiptofSpecialistReportFHIR-0.3.000", "Measurement Period", hzzzzzzzzzzzzzzzzf_);

        return (CqlInterval<CqlDateTime>)hzzzzzzzzzzzzzzzzg_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> hzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient hzzzzzzzzzzzzzzzzi_ = context.Operators.SingletonFrom<Patient>(hzzzzzzzzzzzzzzzzh_);

        return hzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Has Encounter from Valuesets during Measurement Period")]
    public bool? Has_Encounter_from_Valuesets_during_Measurement_Period(CqlContext context)
    {
        CqlValueSet hzzzzzzzzzzzzzzzzj_ = this.Behavioral_Neuropsych_Assessment(context);
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet hzzzzzzzzzzzzzzzzl_ = this.Office_Visit(context);
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzn_ = context.Operators.Union<Encounter>(hzzzzzzzzzzzzzzzzk_, hzzzzzzzzzzzzzzzzm_);
        CqlValueSet hzzzzzzzzzzzzzzzzo_ = this.Ophthalmological_Services(context);
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet hzzzzzzzzzzzzzzzzq_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzs_ = context.Operators.Union<Encounter>(hzzzzzzzzzzzzzzzzp_, hzzzzzzzzzzzzzzzzr_);
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzt_ = context.Operators.Union<Encounter>(hzzzzzzzzzzzzzzzzn_, hzzzzzzzzzzzzzzzzs_);
        CqlValueSet hzzzzzzzzzzzzzzzzu_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet hzzzzzzzzzzzzzzzzw_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzy_ = context.Operators.Union<Encounter>(hzzzzzzzzzzzzzzzzv_, hzzzzzzzzzzzzzzzzx_);
        IEnumerable<Encounter> hzzzzzzzzzzzzzzzzz_ = context.Operators.Union<Encounter>(hzzzzzzzzzzzzzzzzt_, hzzzzzzzzzzzzzzzzy_);
        CqlValueSet izzzzzzzzzzzzzzzza_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet izzzzzzzzzzzzzzzzc_ = this.Psych_Visit_Diagnostic_Evaluation(context);
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> izzzzzzzzzzzzzzzze_ = context.Operators.Union<Encounter>(izzzzzzzzzzzzzzzzb_, izzzzzzzzzzzzzzzzd_);
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzf_ = context.Operators.Union<Encounter>(hzzzzzzzzzzzzzzzzz_, izzzzzzzzzzzzzzzze_);
        bool? izzzzzzzzzzzzzzzzg_(Encounter Encounter)
        {
            Code<Encounter.EncounterStatus> izzzzzzzzzzzzzzzzj_ = Encounter?.StatusElement;
            Encounter.EncounterStatus? izzzzzzzzzzzzzzzzk_ = izzzzzzzzzzzzzzzzj_?.Value;
            Code<Encounter.EncounterStatus> izzzzzzzzzzzzzzzzl_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(izzzzzzzzzzzzzzzzk_);
            bool? izzzzzzzzzzzzzzzzm_ = context.Operators.Equal(izzzzzzzzzzzzzzzzl_, "finished");
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzn_ = this.Measurement_Period(context);
            Period izzzzzzzzzzzzzzzzo_ = Encounter?.Period;
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzzzzzzzo_);
            bool? izzzzzzzzzzzzzzzzq_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(izzzzzzzzzzzzzzzzn_, izzzzzzzzzzzzzzzzp_, "day");
            bool? izzzzzzzzzzzzzzzzr_ = context.Operators.And(izzzzzzzzzzzzzzzzm_, izzzzzzzzzzzzzzzzq_);

            return izzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzh_ = context.Operators.Where<Encounter>(izzzzzzzzzzzzzzzzf_, izzzzzzzzzzzzzzzzg_);
        bool? izzzzzzzzzzzzzzzzi_ = context.Operators.Exists<Encounter>(izzzzzzzzzzzzzzzzh_);

        return izzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Has Encounter from DRCs during Measurement Period")]
    public bool? Has_Encounter_from_DRCs_during_Measurement_Period(CqlContext context)
    {
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? izzzzzzzzzzzzzzzzt_(Encounter EncDRC)
        {
            List<CodeableConcept> izzzzzzzzzzzzzzzzy_ = EncDRC?.Type;
            CqlConcept izzzzzzzzzzzzzzzzz_(CodeableConcept @this)
            {
                CqlConcept kzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return kzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<CqlConcept> jzzzzzzzzzzzzzzzza_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)izzzzzzzzzzzzzzzzy_, izzzzzzzzzzzzzzzzz_);
            bool? jzzzzzzzzzzzzzzzzb_(CqlConcept T)
            {
                CqlCode kzzzzzzzzzzzzzzzzh_ = this.Psychological_or_neuropsychological_test_administration_and_scoring_by_physician_or_other_qualified_health_care_professional__two_or_more_tests__any_method__first_30_minutes(context);
                CqlConcept kzzzzzzzzzzzzzzzzi_ = context.Operators.ConvertCodeToConcept(kzzzzzzzzzzzzzzzzh_);
                bool? kzzzzzzzzzzzzzzzzj_ = context.Operators.Equivalent(T, kzzzzzzzzzzzzzzzzi_);

                return kzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<CqlConcept> jzzzzzzzzzzzzzzzzc_ = context.Operators.Where<CqlConcept>(jzzzzzzzzzzzzzzzza_, jzzzzzzzzzzzzzzzzb_);
            bool? jzzzzzzzzzzzzzzzzd_ = context.Operators.Exists<CqlConcept>(jzzzzzzzzzzzzzzzzc_);
            CqlConcept jzzzzzzzzzzzzzzzzf_(CodeableConcept @this)
            {
                CqlConcept kzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return kzzzzzzzzzzzzzzzzk_;
            };
            IEnumerable<CqlConcept> jzzzzzzzzzzzzzzzzg_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)izzzzzzzzzzzzzzzzy_, jzzzzzzzzzzzzzzzzf_);
            bool? jzzzzzzzzzzzzzzzzh_(CqlConcept T)
            {
                CqlCode kzzzzzzzzzzzzzzzzl_ = this.Psychological_or_neuropsychological_test_administration_and_scoring_by_technician__two_or_more_tests__any_method__first_30_minutes(context);
                CqlConcept kzzzzzzzzzzzzzzzzm_ = context.Operators.ConvertCodeToConcept(kzzzzzzzzzzzzzzzzl_);
                bool? kzzzzzzzzzzzzzzzzn_ = context.Operators.Equivalent(T, kzzzzzzzzzzzzzzzzm_);

                return kzzzzzzzzzzzzzzzzn_;
            };
            IEnumerable<CqlConcept> jzzzzzzzzzzzzzzzzi_ = context.Operators.Where<CqlConcept>(jzzzzzzzzzzzzzzzzg_, jzzzzzzzzzzzzzzzzh_);
            bool? jzzzzzzzzzzzzzzzzj_ = context.Operators.Exists<CqlConcept>(jzzzzzzzzzzzzzzzzi_);
            bool? jzzzzzzzzzzzzzzzzk_ = context.Operators.Or(jzzzzzzzzzzzzzzzzd_, jzzzzzzzzzzzzzzzzj_);
            CqlConcept jzzzzzzzzzzzzzzzzm_(CodeableConcept @this)
            {
                CqlConcept kzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return kzzzzzzzzzzzzzzzzo_;
            };
            IEnumerable<CqlConcept> jzzzzzzzzzzzzzzzzn_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)izzzzzzzzzzzzzzzzy_, jzzzzzzzzzzzzzzzzm_);
            bool? jzzzzzzzzzzzzzzzzo_(CqlConcept T)
            {
                CqlCode kzzzzzzzzzzzzzzzzp_ = this.Psychotherapy_for_crisis__first_60_minutes(context);
                CqlConcept kzzzzzzzzzzzzzzzzq_ = context.Operators.ConvertCodeToConcept(kzzzzzzzzzzzzzzzzp_);
                bool? kzzzzzzzzzzzzzzzzr_ = context.Operators.Equivalent(T, kzzzzzzzzzzzzzzzzq_);

                return kzzzzzzzzzzzzzzzzr_;
            };
            IEnumerable<CqlConcept> jzzzzzzzzzzzzzzzzp_ = context.Operators.Where<CqlConcept>(jzzzzzzzzzzzzzzzzn_, jzzzzzzzzzzzzzzzzo_);
            bool? jzzzzzzzzzzzzzzzzq_ = context.Operators.Exists<CqlConcept>(jzzzzzzzzzzzzzzzzp_);
            bool? jzzzzzzzzzzzzzzzzr_ = context.Operators.Or(jzzzzzzzzzzzzzzzzk_, jzzzzzzzzzzzzzzzzq_);
            CqlConcept jzzzzzzzzzzzzzzzzt_(CodeableConcept @this)
            {
                CqlConcept kzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return kzzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<CqlConcept> jzzzzzzzzzzzzzzzzu_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)izzzzzzzzzzzzzzzzy_, jzzzzzzzzzzzzzzzzt_);
            bool? jzzzzzzzzzzzzzzzzv_(CqlConcept T)
            {
                CqlCode kzzzzzzzzzzzzzzzzt_ = this.Developmental_test_administration__including_assessment_of_fine_and_or_gross_motor__language__cognitive_level__social__memory_and_or_executive_functions_by_standardized_developmental_instruments_when_performed___by_physician_or_other_qualified_health_care_professional__with_interpretation_and_report__first_hour(context);
                CqlConcept kzzzzzzzzzzzzzzzzu_ = context.Operators.ConvertCodeToConcept(kzzzzzzzzzzzzzzzzt_);
                bool? kzzzzzzzzzzzzzzzzv_ = context.Operators.Equivalent(T, kzzzzzzzzzzzzzzzzu_);

                return kzzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<CqlConcept> jzzzzzzzzzzzzzzzzw_ = context.Operators.Where<CqlConcept>(jzzzzzzzzzzzzzzzzu_, jzzzzzzzzzzzzzzzzv_);
            bool? jzzzzzzzzzzzzzzzzx_ = context.Operators.Exists<CqlConcept>(jzzzzzzzzzzzzzzzzw_);
            bool? jzzzzzzzzzzzzzzzzy_ = context.Operators.Or(jzzzzzzzzzzzzzzzzr_, jzzzzzzzzzzzzzzzzx_);
            CqlConcept kzzzzzzzzzzzzzzzza_(CodeableConcept @this)
            {
                CqlConcept kzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return kzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<CqlConcept> kzzzzzzzzzzzzzzzzb_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)izzzzzzzzzzzzzzzzy_, kzzzzzzzzzzzzzzzza_);
            bool? kzzzzzzzzzzzzzzzzc_(CqlConcept T)
            {
                CqlCode kzzzzzzzzzzzzzzzzx_ = this.Health_behavior_assessment__or_re_assessment__ie__health_focused_clinical_interview__behavioral_observations__clinical_decision_making_(context);
                CqlConcept kzzzzzzzzzzzzzzzzy_ = context.Operators.ConvertCodeToConcept(kzzzzzzzzzzzzzzzzx_);
                bool? kzzzzzzzzzzzzzzzzz_ = context.Operators.Equivalent(T, kzzzzzzzzzzzzzzzzy_);

                return kzzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<CqlConcept> kzzzzzzzzzzzzzzzzd_ = context.Operators.Where<CqlConcept>(kzzzzzzzzzzzzzzzzb_, kzzzzzzzzzzzzzzzzc_);
            bool? kzzzzzzzzzzzzzzzze_ = context.Operators.Exists<CqlConcept>(kzzzzzzzzzzzzzzzzd_);
            bool? kzzzzzzzzzzzzzzzzf_ = context.Operators.Or(jzzzzzzzzzzzzzzzzy_, kzzzzzzzzzzzzzzzze_);

            return kzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzu_ = context.Operators.Where<Encounter>(izzzzzzzzzzzzzzzzs_, izzzzzzzzzzzzzzzzt_);
        bool? izzzzzzzzzzzzzzzzv_(Encounter Encounter)
        {
            Code<Encounter.EncounterStatus> lzzzzzzzzzzzzzzzza_ = Encounter?.StatusElement;
            Encounter.EncounterStatus? lzzzzzzzzzzzzzzzzb_ = lzzzzzzzzzzzzzzzza_?.Value;
            Code<Encounter.EncounterStatus> lzzzzzzzzzzzzzzzzc_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(lzzzzzzzzzzzzzzzzb_);
            bool? lzzzzzzzzzzzzzzzzd_ = context.Operators.Equal(lzzzzzzzzzzzzzzzzc_, "finished");
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzze_ = this.Measurement_Period(context);
            Period lzzzzzzzzzzzzzzzzf_ = Encounter?.Period;
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzzzzzzzf_);
            bool? lzzzzzzzzzzzzzzzzh_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(lzzzzzzzzzzzzzzzze_, lzzzzzzzzzzzzzzzzg_, "day");
            bool? lzzzzzzzzzzzzzzzzi_ = context.Operators.And(lzzzzzzzzzzzzzzzzd_, lzzzzzzzzzzzzzzzzh_);

            return lzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzw_ = context.Operators.Where<Encounter>(izzzzzzzzzzzzzzzzu_, izzzzzzzzzzzzzzzzv_);
        bool? izzzzzzzzzzzzzzzzx_ = context.Operators.Exists<Encounter>(izzzzzzzzzzzzzzzzw_);

        return izzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Has Encounter during Measurement Period")]
    public bool? Has_Encounter_during_Measurement_Period(CqlContext context)
    {
        bool? lzzzzzzzzzzzzzzzzj_ = this.Has_Encounter_from_Valuesets_during_Measurement_Period(context);
        bool? lzzzzzzzzzzzzzzzzk_ = this.Has_Encounter_from_DRCs_during_Measurement_Period(context);
        bool? lzzzzzzzzzzzzzzzzl_ = context.Operators.Or(lzzzzzzzzzzzzzzzzj_, lzzzzzzzzzzzzzzzzk_);

        return lzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("First Referral during First 10 Months of Measurement Period")]
    public (CqlTupleMetadata, string ID, CqlDateTime AuthorDate)? First_Referral_during_First_10_Months_of_Measurement_Period(CqlContext context)
    {
        CqlValueSet lzzzzzzzzzzzzzzzzm_ = this.Referral(context);
        IEnumerable<ServiceRequest> lzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, lzzzzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        bool? lzzzzzzzzzzzzzzzzo_(ServiceRequest ReferralOrder)
        {
            Code<RequestStatus> lzzzzzzzzzzzzzzzzw_ = ReferralOrder?.StatusElement;
            RequestStatus? lzzzzzzzzzzzzzzzzx_ = lzzzzzzzzzzzzzzzzw_?.Value;
            Code<RequestStatus> lzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<Code<RequestStatus>>(lzzzzzzzzzzzzzzzzx_);
            string lzzzzzzzzzzzzzzzzz_ = context.Operators.Convert<string>(lzzzzzzzzzzzzzzzzy_);
            string[] mzzzzzzzzzzzzzzzza_ = [
                "active",
                "completed",
            ];
            bool? mzzzzzzzzzzzzzzzzb_ = context.Operators.In<string>(lzzzzzzzzzzzzzzzzz_, mzzzzzzzzzzzzzzzza_ as IEnumerable<string>);
            Code<RequestIntent> mzzzzzzzzzzzzzzzzc_ = ReferralOrder?.IntentElement;
            RequestIntent? mzzzzzzzzzzzzzzzzd_ = mzzzzzzzzzzzzzzzzc_?.Value;
            Code<RequestIntent> mzzzzzzzzzzzzzzzze_ = context.Operators.Convert<Code<RequestIntent>>(mzzzzzzzzzzzzzzzzd_);
            bool? mzzzzzzzzzzzzzzzzf_ = context.Operators.Equal(mzzzzzzzzzzzzzzzze_, "order");
            bool? mzzzzzzzzzzzzzzzzg_ = context.Operators.And(mzzzzzzzzzzzzzzzzb_, mzzzzzzzzzzzzzzzzf_);
            FhirDateTime mzzzzzzzzzzzzzzzzh_ = ReferralOrder?.AuthoredOnElement;
            CqlDateTime mzzzzzzzzzzzzzzzzi_ = context.Operators.Convert<CqlDateTime>(mzzzzzzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzj_ = this.Measurement_Period(context);
            CqlDateTime mzzzzzzzzzzzzzzzzk_ = context.Operators.Start(mzzzzzzzzzzzzzzzzj_);
            CqlDateTime mzzzzzzzzzzzzzzzzm_ = context.Operators.Start(mzzzzzzzzzzzzzzzzj_);
            int? mzzzzzzzzzzzzzzzzn_ = context.Operators.DateTimeComponentFrom(mzzzzzzzzzzzzzzzzm_, "year");
            CqlDate mzzzzzzzzzzzzzzzzo_ = context.Operators.Date(mzzzzzzzzzzzzzzzzn_, 10, 31);
            CqlDateTime mzzzzzzzzzzzzzzzzp_ = context.Operators.ConvertDateToDateTime(mzzzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzq_ = context.Operators.Interval(mzzzzzzzzzzzzzzzzk_, mzzzzzzzzzzzzzzzzp_, true, true);
            bool? mzzzzzzzzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(mzzzzzzzzzzzzzzzzi_, mzzzzzzzzzzzzzzzzq_, "day");
            bool? mzzzzzzzzzzzzzzzzs_ = context.Operators.And(mzzzzzzzzzzzzzzzzg_, mzzzzzzzzzzzzzzzzr_);

            return mzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<ServiceRequest> lzzzzzzzzzzzzzzzzp_ = context.Operators.Where<ServiceRequest>(lzzzzzzzzzzzzzzzzn_, lzzzzzzzzzzzzzzzzo_);
        (CqlTupleMetadata, string ID, CqlDateTime AuthorDate)? lzzzzzzzzzzzzzzzzq_(ServiceRequest ReferralOrder)
        {
            Id mzzzzzzzzzzzzzzzzt_ = ReferralOrder?.IdElement;
            string mzzzzzzzzzzzzzzzzu_ = mzzzzzzzzzzzzzzzzt_?.Value;
            FhirDateTime mzzzzzzzzzzzzzzzzv_ = ReferralOrder?.AuthoredOnElement;
            CqlDateTime mzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<CqlDateTime>(mzzzzzzzzzzzzzzzzv_);
            (CqlTupleMetadata, string ID, CqlDateTime AuthorDate)? mzzzzzzzzzzzzzzzzx_ = (CqlTupleMetadata_EDdTRBfWHaSNbiiXJfIVJUXdb, mzzzzzzzzzzzzzzzzu_, mzzzzzzzzzzzzzzzzw_);

            return mzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<(CqlTupleMetadata, string ID, CqlDateTime AuthorDate)?> lzzzzzzzzzzzzzzzzr_ = context.Operators.Select<ServiceRequest, (CqlTupleMetadata, string ID, CqlDateTime AuthorDate)?>(lzzzzzzzzzzzzzzzzp_, lzzzzzzzzzzzzzzzzq_);
        IEnumerable<(CqlTupleMetadata, string ID, CqlDateTime AuthorDate)?> lzzzzzzzzzzzzzzzzs_ = context.Operators.Distinct<(CqlTupleMetadata, string ID, CqlDateTime AuthorDate)?>(lzzzzzzzzzzzzzzzzr_);
        object lzzzzzzzzzzzzzzzzt_((CqlTupleMetadata, string ID, CqlDateTime AuthorDate)? @this)
        {
            CqlDateTime mzzzzzzzzzzzzzzzzy_ = @this?.AuthorDate;

            return mzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<(CqlTupleMetadata, string ID, CqlDateTime AuthorDate)?> lzzzzzzzzzzzzzzzzu_ = context.Operators.SortBy<(CqlTupleMetadata, string ID, CqlDateTime AuthorDate)?>(lzzzzzzzzzzzzzzzzs_, lzzzzzzzzzzzzzzzzt_, System.ComponentModel.ListSortDirection.Ascending);
        (CqlTupleMetadata, string ID, CqlDateTime AuthorDate)? lzzzzzzzzzzzzzzzzv_ = context.Operators.First<(CqlTupleMetadata, string ID, CqlDateTime AuthorDate)?>(lzzzzzzzzzzzzzzzzu_);

        return lzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        bool? mzzzzzzzzzzzzzzzzz_ = this.Has_Encounter_during_Measurement_Period(context);
        (CqlTupleMetadata, string ID, CqlDateTime AuthorDate)? nzzzzzzzzzzzzzzzza_ = this.First_Referral_during_First_10_Months_of_Measurement_Period(context);
        bool? nzzzzzzzzzzzzzzzzb_ = context.Operators.Not((bool?)(nzzzzzzzzzzzzzzzza_ is null));
        bool? nzzzzzzzzzzzzzzzzc_ = context.Operators.And(mzzzzzzzzzzzzzzzzz_, nzzzzzzzzzzzzzzzzb_);

        return nzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? nzzzzzzzzzzzzzzzzd_ = this.Initial_Population(context);

        return nzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? nzzzzzzzzzzzzzzzze_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return nzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> nzzzzzzzzzzzzzzzzf_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return nzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? nzzzzzzzzzzzzzzzzg_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return nzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode nzzzzzzzzzzzzzzzzh_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return nzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("TaskGetRequestID")]
    public IEnumerable<string> TaskGetRequestID(CqlContext context, Task task)
    {
        List<ResourceReference> nzzzzzzzzzzzzzzzzi_ = task?.BasedOn;
        string nzzzzzzzzzzzzzzzzj_(ResourceReference Task)
        {
            FhirString nzzzzzzzzzzzzzzzzm_ = Task?.ReferenceElement;
            string nzzzzzzzzzzzzzzzzn_ = nzzzzzzzzzzzzzzzzm_?.Value;
            string nzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.GetId(context, nzzzzzzzzzzzzzzzzn_);

            return nzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<string> nzzzzzzzzzzzzzzzzk_ = context.Operators.Select<ResourceReference, string>((IEnumerable<ResourceReference>)nzzzzzzzzzzzzzzzzi_, nzzzzzzzzzzzzzzzzj_);
        IEnumerable<string> nzzzzzzzzzzzzzzzzl_ = context.Operators.Distinct<string>(nzzzzzzzzzzzzzzzzk_);

        return nzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Referring Clinician Receives Consultant Report to Close Referral Loop")]
    public bool? Referring_Clinician_Receives_Consultant_Report_to_Close_Referral_Loop(CqlContext context)
    {
        CqlValueSet nzzzzzzzzzzzzzzzzp_ = this.Consultant_Report(context);
        IEnumerable<Task> nzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Task>(new RetrieveParameters(default, nzzzzzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-task"));
        IEnumerable<Task> nzzzzzzzzzzzzzzzzr_(Task ConsultantReportObtained)
        {
            (CqlTupleMetadata, string ID, CqlDateTime AuthorDate)? nzzzzzzzzzzzzzzzzu_ = this.First_Referral_during_First_10_Months_of_Measurement_Period(context);
            (CqlTupleMetadata, string ID, CqlDateTime AuthorDate)?[] nzzzzzzzzzzzzzzzzv_ = [
                nzzzzzzzzzzzzzzzzu_,
            ];
            bool? nzzzzzzzzzzzzzzzzw_((CqlTupleMetadata, string ID, CqlDateTime AuthorDate)? FirstReferral)
            {
                string ozzzzzzzzzzzzzzzza_ = FirstReferral?.ID;
                IEnumerable<string> ozzzzzzzzzzzzzzzzb_ = this.TaskGetRequestID(context, ConsultantReportObtained);
                bool? ozzzzzzzzzzzzzzzzc_ = context.Operators.In<string>(ozzzzzzzzzzzzzzzza_, ozzzzzzzzzzzzzzzzb_);
                Period ozzzzzzzzzzzzzzzzd_ = ConsultantReportObtained?.ExecutionPeriod;
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzzzzzzzzd_);
                CqlDateTime ozzzzzzzzzzzzzzzzf_ = context.Operators.End(ozzzzzzzzzzzzzzzze_);
                CqlDateTime ozzzzzzzzzzzzzzzzg_ = FirstReferral?.AuthorDate;
                bool? ozzzzzzzzzzzzzzzzh_ = context.Operators.After(ozzzzzzzzzzzzzzzzf_, ozzzzzzzzzzzzzzzzg_, default);
                bool? ozzzzzzzzzzzzzzzzi_ = context.Operators.And(ozzzzzzzzzzzzzzzzc_, ozzzzzzzzzzzzzzzzh_);
                Code<Task.TaskStatus> ozzzzzzzzzzzzzzzzj_ = ConsultantReportObtained?.StatusElement;
                Task.TaskStatus? ozzzzzzzzzzzzzzzzk_ = ozzzzzzzzzzzzzzzzj_?.Value;
                Code<Task.TaskStatus> ozzzzzzzzzzzzzzzzl_ = context.Operators.Convert<Code<Task.TaskStatus>>(ozzzzzzzzzzzzzzzzk_);
                bool? ozzzzzzzzzzzzzzzzm_ = context.Operators.Equal(ozzzzzzzzzzzzzzzzl_, "completed");
                bool? ozzzzzzzzzzzzzzzzn_ = context.Operators.And(ozzzzzzzzzzzzzzzzi_, ozzzzzzzzzzzzzzzzm_);
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzzzzzzzzd_);
                CqlDateTime ozzzzzzzzzzzzzzzzq_ = context.Operators.End(ozzzzzzzzzzzzzzzzp_);
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzr_ = this.Measurement_Period(context);
                bool? ozzzzzzzzzzzzzzzzs_ = context.Operators.In<CqlDateTime>(ozzzzzzzzzzzzzzzzq_, ozzzzzzzzzzzzzzzzr_, "day");
                bool? ozzzzzzzzzzzzzzzzt_ = context.Operators.And(ozzzzzzzzzzzzzzzzn_, ozzzzzzzzzzzzzzzzs_);

                return ozzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<(CqlTupleMetadata, string ID, CqlDateTime AuthorDate)?> nzzzzzzzzzzzzzzzzx_ = context.Operators.Where<(CqlTupleMetadata, string ID, CqlDateTime AuthorDate)?>((IEnumerable<(CqlTupleMetadata, string ID, CqlDateTime AuthorDate)?>)nzzzzzzzzzzzzzzzzv_, nzzzzzzzzzzzzzzzzw_);
            Task nzzzzzzzzzzzzzzzzy_((CqlTupleMetadata, string ID, CqlDateTime AuthorDate)? FirstReferral) =>
                ConsultantReportObtained;
            IEnumerable<Task> nzzzzzzzzzzzzzzzzz_ = context.Operators.Select<(CqlTupleMetadata, string ID, CqlDateTime AuthorDate)?, Task>(nzzzzzzzzzzzzzzzzx_, nzzzzzzzzzzzzzzzzy_);

            return nzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Task> nzzzzzzzzzzzzzzzzs_ = context.Operators.SelectMany<Task, Task>(nzzzzzzzzzzzzzzzzq_, nzzzzzzzzzzzzzzzzr_);
        bool? nzzzzzzzzzzzzzzzzt_ = context.Operators.Exists<Task>(nzzzzzzzzzzzzzzzzs_);

        return nzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? ozzzzzzzzzzzzzzzzu_ = this.Referring_Clinician_Receives_Consultant_Report_to_Close_Referral_Loop(context);

        return ozzzzzzzzzzzzzzzzu_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_EDdTRBfWHaSNbiiXJfIVJUXdb = new(
        [typeof(string), typeof(CqlDateTime)],
        ["ID", "AuthorDate"]);

    #endregion CqlTupleMetadata Properties

}
