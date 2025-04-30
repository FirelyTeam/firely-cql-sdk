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
[CqlLibrary("DementiaCognitiveAssessmentFHIR", "0.1.000")]
public partial class DementiaCognitiveAssessmentFHIR_0_1_000 : ILibrary, ISingleton<DementiaCognitiveAssessmentFHIR_0_1_000>
{
    private DementiaCognitiveAssessmentFHIR_0_1_000() {}

    public static DementiaCognitiveAssessmentFHIR_0_1_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "DementiaCognitiveAssessmentFHIR";
    public string Version => "0.1.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_3_5_000.Instance, QICoreCommon_2_1_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Behavioral/Neuropsych Assessment", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1023", valueSetVersion: null)]
    public CqlValueSet Behavioral_Neuropsych_Assessment(CqlContext _) => _Behavioral_Neuropsych_Assessment;
    private static readonly CqlValueSet _Behavioral_Neuropsych_Assessment = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1023", null);

    [CqlValueSetDefinition("Care Services in Long Term Residential Facility", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014", valueSetVersion: null)]
    public CqlValueSet Care_Services_in_Long_Term_Residential_Facility(CqlContext _) => _Care_Services_in_Long_Term_Residential_Facility;
    private static readonly CqlValueSet _Care_Services_in_Long_Term_Residential_Facility = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014", null);

    [CqlValueSetDefinition("Cognitive Assessment", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1332", valueSetVersion: null)]
    public CqlValueSet Cognitive_Assessment(CqlContext _) => _Cognitive_Assessment;
    private static readonly CqlValueSet _Cognitive_Assessment = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1332", null);

    [CqlValueSetDefinition("Dementia & Mental Degenerations", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1005", valueSetVersion: null)]
    public CqlValueSet Dementia_and_Mental_Degenerations(CqlContext _) => _Dementia_and_Mental_Degenerations;
    private static readonly CqlValueSet _Dementia_and_Mental_Degenerations = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1005", null);

    [CqlValueSetDefinition("Face-to-Face Interaction", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1048", valueSetVersion: null)]
    public CqlValueSet Face_to_Face_Interaction(CqlContext _) => _Face_to_Face_Interaction;
    private static readonly CqlValueSet _Face_to_Face_Interaction = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1048", null);

    [CqlValueSetDefinition("Home Healthcare Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", valueSetVersion: null)]
    public CqlValueSet Home_Healthcare_Services(CqlContext _) => _Home_Healthcare_Services;
    private static readonly CqlValueSet _Home_Healthcare_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);

    [CqlValueSetDefinition("Nursing Facility Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012", valueSetVersion: null)]
    public CqlValueSet Nursing_Facility_Visit(CqlContext _) => _Nursing_Facility_Visit;
    private static readonly CqlValueSet _Nursing_Facility_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012", null);

    [CqlValueSetDefinition("Occupational Therapy Evaluation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1011", valueSetVersion: null)]
    public CqlValueSet Occupational_Therapy_Evaluation(CqlContext _) => _Occupational_Therapy_Evaluation;
    private static readonly CqlValueSet _Occupational_Therapy_Evaluation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1011", null);

    [CqlValueSetDefinition("Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext _) => _Office_Visit;
    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlValueSetDefinition("Outpatient Consultation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", valueSetVersion: null)]
    public CqlValueSet Outpatient_Consultation(CqlContext _) => _Outpatient_Consultation;
    private static readonly CqlValueSet _Outpatient_Consultation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", null);

    [CqlValueSetDefinition("Patient Provider Interaction", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1012", valueSetVersion: null)]
    public CqlValueSet Patient_Provider_Interaction(CqlContext _) => _Patient_Provider_Interaction;
    private static readonly CqlValueSet _Patient_Provider_Interaction = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1012", null);

    [CqlValueSetDefinition("Patient Reason", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1008", valueSetVersion: null)]
    public CqlValueSet Patient_Reason(CqlContext _) => _Patient_Reason;
    private static readonly CqlValueSet _Patient_Reason = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1008", null);

    [CqlValueSetDefinition("Psych Visit Diagnostic Evaluation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1492", valueSetVersion: null)]
    public CqlValueSet Psych_Visit_Diagnostic_Evaluation(CqlContext _) => _Psych_Visit_Diagnostic_Evaluation;
    private static readonly CqlValueSet _Psych_Visit_Diagnostic_Evaluation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1492", null);

    [CqlValueSetDefinition("Psych Visit Psychotherapy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1496", valueSetVersion: null)]
    public CqlValueSet Psych_Visit_Psychotherapy(CqlContext _) => _Psych_Visit_Psychotherapy;
    private static readonly CqlValueSet _Psych_Visit_Psychotherapy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1496", null);

    [CqlValueSetDefinition("Standardized Tools Score for Assessment of Cognition", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1006", valueSetVersion: null)]
    public CqlValueSet Standardized_Tools_Score_for_Assessment_of_Cognition(CqlContext _) => _Standardized_Tools_Score_for_Assessment_of_Cognition;
    private static readonly CqlValueSet _Standardized_Tools_Score_for_Assessment_of_Cognition = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1006", null);

    #endregion ValueSets

    #region CodeSystems

    [CqlCodeSystemDefinition("ActCode")]
    public CqlCodeSystem ActCode(CqlContext _) => _ActCode;
    private static readonly CqlCodeSystem _ActCode = new CqlCodeSystem();

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Interval(xzzzzzzzzzzzzzzzzzzzzzzzo_, xzzzzzzzzzzzzzzzzzzzzzzzp_, true, true);
        object xzzzzzzzzzzzzzzzzzzzzzzzr_ = context.ResolveParameter("DementiaCognitiveAssessmentFHIR-0.1.000", "Measurement Period", xzzzzzzzzzzzzzzzzzzzzzzzq_);

        return (CqlInterval<CqlDateTime>)xzzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> xzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient xzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.SingletonFrom<Patient>(xzzzzzzzzzzzzzzzzzzzzzzzs_);

        return xzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Encounter to Assess Cognition")]
    public IEnumerable<Encounter> Encounter_to_Assess_Cognition(CqlContext context)
    {
        CqlValueSet xzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Psych_Visit_Diagnostic_Evaluation(context);
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet xzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Nursing_Facility_Visit(context);
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Union<Encounter>(xzzzzzzzzzzzzzzzzzzzzzzzv_, xzzzzzzzzzzzzzzzzzzzzzzzx_);
        CqlValueSet xzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Care_Services_in_Long_Term_Residential_Facility(context);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Union<Encounter>(yzzzzzzzzzzzzzzzzzzzzzzza_, yzzzzzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<Encounter>(xzzzzzzzzzzzzzzzzzzzzzzzy_, yzzzzzzzzzzzzzzzzzzzzzzzd_);
        CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Psych_Visit_Psychotherapy(context);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Behavioral_Neuropsych_Assessment(context);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Union<Encounter>(yzzzzzzzzzzzzzzzzzzzzzzzg_, yzzzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<Encounter>(yzzzzzzzzzzzzzzzzzzzzzzze_, yzzzzzzzzzzzzzzzzzzzzzzzj_);
        CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Occupational_Therapy_Evaluation(context);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzzzl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Office_Visit(context);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Union<Encounter>(yzzzzzzzzzzzzzzzzzzzzzzzm_, yzzzzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<Encounter>(yzzzzzzzzzzzzzzzzzzzzzzzk_, yzzzzzzzzzzzzzzzzzzzzzzzp_);
        CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Union<Encounter>(yzzzzzzzzzzzzzzzzzzzzzzzq_, yzzzzzzzzzzzzzzzzzzzzzzzs_);

        return yzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Dementia Encounter During Measurement Period")]
    public IEnumerable<Encounter> Dementia_Encounter_During_Measurement_Period(CqlContext context)
    {
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Encounter_to_Assess_Cognition(context);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzv_(Encounter EncounterAssessCognition)
        {
            CqlValueSet yzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Dementia_and_Mental_Degenerations(context);
            IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? yzzzzzzzzzzzzzzzzzzzzzzzz_(Condition Dementia)
            {
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Measurement_Period(context);
                Period zzzzzzzzzzzzzzzzzzzzzzzze_ = EncounterAssessCognition?.Period;
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzzzzzzzzzzzze_);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(zzzzzzzzzzzzzzzzzzzzzzzzd_, zzzzzzzzzzzzzzzzzzzzzzzzf_, "day");
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Dementia);
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzzzzzzzzzzzze_);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Overlaps(zzzzzzzzzzzzzzzzzzzzzzzzh_, zzzzzzzzzzzzzzzzzzzzzzzzj_, "day");
                bool? zzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzzzg_, zzzzzzzzzzzzzzzzzzzzzzzzk_);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.isActive(context, Dementia);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzzzl_, zzzzzzzzzzzzzzzzzzzzzzzzm_);
                CodeableConcept zzzzzzzzzzzzzzzzzzzzzzzzo_ = Dementia?.VerificationStatus;
                CqlConcept zzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, zzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlCode zzzzzzzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.unconfirmed(context);
                CqlConcept zzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ConvertCodeToConcept(zzzzzzzzzzzzzzzzzzzzzzzzq_);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Equivalent(zzzzzzzzzzzzzzzzzzzzzzzzp_, zzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlConcept zzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, zzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlCode zzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.refuted(context);
                CqlConcept zzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.ConvertCodeToConcept(zzzzzzzzzzzzzzzzzzzzzzzzv_);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Equivalent(zzzzzzzzzzzzzzzzzzzzzzzzu_, zzzzzzzzzzzzzzzzzzzzzzzzw_);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Or(zzzzzzzzzzzzzzzzzzzzzzzzs_, zzzzzzzzzzzzzzzzzzzzzzzzx_);
                CqlConcept azzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, zzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlCode azzzzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.entered_in_error(context);
                CqlConcept azzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.ConvertCodeToConcept(azzzzzzzzzzzzzzzzzzzzzzzzb_);
                bool? azzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Equivalent(azzzzzzzzzzzzzzzzzzzzzzzza_, azzzzzzzzzzzzzzzzzzzzzzzzc_);
                bool? azzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Or(zzzzzzzzzzzzzzzzzzzzzzzzy_, azzzzzzzzzzzzzzzzzzzzzzzzd_);
                bool? azzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Not(azzzzzzzzzzzzzzzzzzzzzzzze_);
                bool? azzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzzzn_, azzzzzzzzzzzzzzzzzzzzzzzzf_);

                return azzzzzzzzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Condition> zzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<Condition>(yzzzzzzzzzzzzzzzzzzzzzzzy_, yzzzzzzzzzzzzzzzzzzzzzzzz_);
            Encounter zzzzzzzzzzzzzzzzzzzzzzzzb_(Condition Dementia) =>
                EncounterAssessCognition;
            IEnumerable<Encounter> zzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Select<Condition, Encounter>(zzzzzzzzzzzzzzzzzzzzzzzza_, zzzzzzzzzzzzzzzzzzzzzzzzb_);

            return zzzzzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.SelectMany<Encounter, Encounter>(yzzzzzzzzzzzzzzzzzzzzzzzu_, yzzzzzzzzzzzzzzzzzzzzzzzv_);

        return yzzzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Qualifying Encounter During Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Encounter_During_Measurement_Period(CqlContext context)
    {
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzh_ = this.Encounter_to_Assess_Cognition(context);
        CqlValueSet azzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Patient_Provider_Interaction(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Union<Encounter>(azzzzzzzzzzzzzzzzzzzzzzzzh_, azzzzzzzzzzzzzzzzzzzzzzzzj_);
        bool? azzzzzzzzzzzzzzzzzzzzzzzzl_(Encounter ValidEncounter)
        {
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Measurement_Period(context);
            Period azzzzzzzzzzzzzzzzzzzzzzzzo_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzzzzzzzzzzo_);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(azzzzzzzzzzzzzzzzzzzzzzzzn_, azzzzzzzzzzzzzzzzzzzzzzzzp_, "day");
            Code<Encounter.EncounterStatus> azzzzzzzzzzzzzzzzzzzzzzzzr_ = ValidEncounter?.StatusElement;
            Encounter.EncounterStatus? azzzzzzzzzzzzzzzzzzzzzzzzs_ = azzzzzzzzzzzzzzzzzzzzzzzzr_?.Value;
            Code<Encounter.EncounterStatus> azzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(azzzzzzzzzzzzzzzzzzzzzzzzs_);
            bool? azzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Equal(azzzzzzzzzzzzzzzzzzzzzzzzt_, "finished");
            bool? azzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzzzzzzq_, azzzzzzzzzzzzzzzzzzzzzzzzu_);

            return azzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Encounter>(azzzzzzzzzzzzzzzzzzzzzzzzk_, azzzzzzzzzzzzzzzzzzzzzzzzl_);

        return azzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Dementia_Encounter_During_Measurement_Period(context);
        bool? azzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Exists<Encounter>(azzzzzzzzzzzzzzzzzzzzzzzzw_);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Qualifying_Encounter_During_Measurement_Period(context);
        int? azzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Count<Encounter>(azzzzzzzzzzzzzzzzzzzzzzzzy_);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.GreaterOrEqual(azzzzzzzzzzzzzzzzzzzzzzzzz_, 2);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzzzzzzx_, bzzzzzzzzzzzzzzzzzzzzzzzza_);

        return bzzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Initial_Population(context);

        return bzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Assessment of Cognition Using Standardized Tools or Alternate Methods")]
    public IEnumerable<Observation> Assessment_of_Cognition_Using_Standardized_Tools_or_Alternate_Methods(CqlContext context)
    {
        CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Standardized_Tools_Score_for_Assessment_of_Cognition(context);
        IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        CqlValueSet bzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Cognitive_Assessment(context);
        IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<Observation>(bzzzzzzzzzzzzzzzzzzzzzzzze_, bzzzzzzzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzzzzzzi_(Observation CognitiveAssessment)
        {
            IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Dementia_Encounter_During_Measurement_Period(context);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzzn_(Encounter EncounterDementia)
            {
                DataType bzzzzzzzzzzzzzzzzzzzzzzzzr_ = CognitiveAssessment?.Effective;
                object bzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzzzzzzzzzzzzzzs_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzzzzzzt_);
                Period bzzzzzzzzzzzzzzzzzzzzzzzzv_ = EncounterDementia?.Period;
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.End(bzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlQuantity bzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Quantity(12m, "months");
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Subtract(bzzzzzzzzzzzzzzzzzzzzzzzzx_, bzzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.End(czzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Interval(bzzzzzzzzzzzzzzzzzzzzzzzzz_, czzzzzzzzzzzzzzzzzzzzzzzzc_, true, true);
                bool? czzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.In<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzzzzzu_, czzzzzzzzzzzzzzzzzzzzzzzzd_, "day");
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.End(czzzzzzzzzzzzzzzzzzzzzzzzg_);
                bool? czzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Not((bool?)(czzzzzzzzzzzzzzzzzzzzzzzzh_ is null));
                bool? czzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzzzzze_, czzzzzzzzzzzzzzzzzzzzzzzzi_);

                return czzzzzzzzzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Encounter>(bzzzzzzzzzzzzzzzzzzzzzzzzm_, bzzzzzzzzzzzzzzzzzzzzzzzzn_);
            Observation bzzzzzzzzzzzzzzzzzzzzzzzzp_(Encounter EncounterDementia) =>
                CognitiveAssessment;
            IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Select<Encounter, Observation>(bzzzzzzzzzzzzzzzzzzzzzzzzo_, bzzzzzzzzzzzzzzzzzzzzzzzzp_);

            return bzzzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.SelectMany<Observation, Observation>(bzzzzzzzzzzzzzzzzzzzzzzzzh_, bzzzzzzzzzzzzzzzzzzzzzzzzi_);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzzk_(Observation CognitiveAssessment)
        {
            DataType czzzzzzzzzzzzzzzzzzzzzzzzk_ = CognitiveAssessment?.Value;
            object czzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzzzzk_);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Not((bool?)(czzzzzzzzzzzzzzzzzzzzzzzzl_ is null));
            Code<ObservationStatus> czzzzzzzzzzzzzzzzzzzzzzzzn_ = CognitiveAssessment?.StatusElement;
            ObservationStatus? czzzzzzzzzzzzzzzzzzzzzzzzo_ = czzzzzzzzzzzzzzzzzzzzzzzzn_?.Value;
            Code<ObservationStatus> czzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Convert<Code<ObservationStatus>>(czzzzzzzzzzzzzzzzzzzzzzzzo_);
            string czzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<string>(czzzzzzzzzzzzzzzzzzzzzzzzp_);
            string[] czzzzzzzzzzzzzzzzzzzzzzzzr_ = [
                "final",
                "amended",
                "corrected",
                "preliminary",
            ];
            bool? czzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.In<string>(czzzzzzzzzzzzzzzzzzzzzzzzq_, czzzzzzzzzzzzzzzzzzzzzzzzr_ as IEnumerable<string>);
            bool? czzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzzzzzm_, czzzzzzzzzzzzzzzzzzzzzzzzs_);

            return czzzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Observation>(bzzzzzzzzzzzzzzzzzzzzzzzzj_, bzzzzzzzzzzzzzzzzzzzzzzzzk_);

        return bzzzzzzzzzzzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzzzzu_ = this.Assessment_of_Cognition_Using_Standardized_Tools_or_Alternate_Methods(context);
        bool? czzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Exists<Observation>(czzzzzzzzzzzzzzzzzzzzzzzzu_);

        return czzzzzzzzzzzzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Patient Reason for Not Performing Assessment of Cognition Using Standardized Tools or Alternate Methods")]
    public IEnumerable<Observation> Patient_Reason_for_Not_Performing_Assessment_of_Cognition_Using_Standardized_Tools_or_Alternate_Methods(CqlContext context)
    {
        CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Standardized_Tools_Score_for_Assessment_of_Cognition(context);
        IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observationnotdone"));
        CqlValueSet czzzzzzzzzzzzzzzzzzzzzzzzy_ = this.Cognitive_Assessment(context);
        IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observationnotdone"));
        IEnumerable<Observation> dzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Union<Observation>(czzzzzzzzzzzzzzzzzzzzzzzzx_, czzzzzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<Observation> dzzzzzzzzzzzzzzzzzzzzzzzzb_(Observation NoCognitiveAssessment)
        {
            IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzf_ = this.Dementia_Encounter_During_Measurement_Period(context);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzg_(Encounter EncounterDementia)
            {
                Instant dzzzzzzzzzzzzzzzzzzzzzzzzk_ = NoCognitiveAssessment?.IssuedElement;
                DateTimeOffset? dzzzzzzzzzzzzzzzzzzzzzzzzl_ = dzzzzzzzzzzzzzzzzzzzzzzzzk_?.Value;
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Convert<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzzzzzl_);
                Period dzzzzzzzzzzzzzzzzzzzzzzzzn_ = EncounterDementia?.Period;
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzzzzzzzzzzzzzzzzzn_);
                bool? dzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.In<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzzzzzm_, dzzzzzzzzzzzzzzzzzzzzzzzzo_, default);

                return dzzzzzzzzzzzzzzzzzzzzzzzzp_;
            };
            IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Encounter>(dzzzzzzzzzzzzzzzzzzzzzzzzf_, dzzzzzzzzzzzzzzzzzzzzzzzzg_);
            Observation dzzzzzzzzzzzzzzzzzzzzzzzzi_(Encounter EncounterDementia) =>
                NoCognitiveAssessment;
            IEnumerable<Observation> dzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<Encounter, Observation>(dzzzzzzzzzzzzzzzzzzzzzzzzh_, dzzzzzzzzzzzzzzzzzzzzzzzzi_);

            return dzzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<Observation> dzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.SelectMany<Observation, Observation>(dzzzzzzzzzzzzzzzzzzzzzzzza_, dzzzzzzzzzzzzzzzzzzzzzzzzb_);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzzd_(Observation NoCognitiveAssessment)
        {
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzq_(Extension @this)
            {
                string dzzzzzzzzzzzzzzzzzzzzzzzzy_ = @this?.Url;
                FhirString dzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Convert<FhirString>(dzzzzzzzzzzzzzzzzzzzzzzzzy_);
                string ezzzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToString(context, dzzzzzzzzzzzzzzzzzzzzzzzzz_);
                bool? ezzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Equal(ezzzzzzzzzzzzzzzzzzzzzzzza_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");

                return ezzzzzzzzzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<Extension> dzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(NoCognitiveAssessment is DomainResource
                    ? (NoCognitiveAssessment as DomainResource).Extension
                    : default), dzzzzzzzzzzzzzzzzzzzzzzzzq_);
            object dzzzzzzzzzzzzzzzzzzzzzzzzs_(Extension @this)
            {
                DataType ezzzzzzzzzzzzzzzzzzzzzzzzc_ = @this?.Value;

                return ezzzzzzzzzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<object> dzzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Select<Extension, object>(dzzzzzzzzzzzzzzzzzzzzzzzzr_, dzzzzzzzzzzzzzzzzzzzzzzzzs_);
            object dzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.SingletonFrom<object>(dzzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlConcept dzzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dzzzzzzzzzzzzzzzzzzzzzzzzu_ as CodeableConcept);
            CqlValueSet dzzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Patient_Reason(context);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.ConceptInValueSet(dzzzzzzzzzzzzzzzzzzzzzzzzv_, dzzzzzzzzzzzzzzzzzzzzzzzzw_);

            return dzzzzzzzzzzzzzzzzzzzzzzzzx_;
        };
        IEnumerable<Observation> dzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Observation>(dzzzzzzzzzzzzzzzzzzzzzzzzc_, dzzzzzzzzzzzzzzzzzzzzzzzzd_);

        return dzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public bool? Denominator_Exceptions(CqlContext context)
    {
        IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzzzzzzd_ = this.Patient_Reason_for_Not_Performing_Assessment_of_Cognition_Using_Standardized_Tools_or_Alternate_Methods(context);
        bool? ezzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Exists<Observation>(ezzzzzzzzzzzzzzzzzzzzzzzzd_);

        return ezzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? ezzzzzzzzzzzzzzzzzzzzzzzzf_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return ezzzzzzzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? ezzzzzzzzzzzzzzzzzzzzzzzzg_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return ezzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode ezzzzzzzzzzzzzzzzzzzzzzzzh_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return ezzzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> ezzzzzzzzzzzzzzzzzzzzzzzzi_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return ezzzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    #endregion Expressions

}
