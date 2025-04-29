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
        CqlDateTime czzzzzzzzzzzzze_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime czzzzzzzzzzzzzf_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> czzzzzzzzzzzzzg_ = context.Operators.Interval(czzzzzzzzzzzzze_, czzzzzzzzzzzzzf_, true, true);
        object czzzzzzzzzzzzzh_ = context.ResolveParameter("DementiaCognitiveAssessmentFHIR-0.1.000", "Measurement Period", czzzzzzzzzzzzzg_);

        return (CqlInterval<CqlDateTime>)czzzzzzzzzzzzzh_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> czzzzzzzzzzzzzi_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient czzzzzzzzzzzzzj_ = context.Operators.SingletonFrom<Patient>(czzzzzzzzzzzzzi_);

        return czzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Encounter to Assess Cognition")]
    public IEnumerable<Encounter> Encounter_to_Assess_Cognition(CqlContext context)
    {
        CqlValueSet czzzzzzzzzzzzzk_ = this.Psych_Visit_Diagnostic_Evaluation(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, czzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet czzzzzzzzzzzzzm_ = this.Nursing_Facility_Visit(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, czzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> czzzzzzzzzzzzzo_ = context.Operators.Union<Encounter>(czzzzzzzzzzzzzl_, czzzzzzzzzzzzzn_);
        CqlValueSet czzzzzzzzzzzzzp_ = this.Care_Services_in_Long_Term_Residential_Facility(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzq_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, czzzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet czzzzzzzzzzzzzr_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, czzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> czzzzzzzzzzzzzt_ = context.Operators.Union<Encounter>(czzzzzzzzzzzzzq_, czzzzzzzzzzzzzs_);
        IEnumerable<Encounter> czzzzzzzzzzzzzu_ = context.Operators.Union<Encounter>(czzzzzzzzzzzzzo_, czzzzzzzzzzzzzt_);
        CqlValueSet czzzzzzzzzzzzzv_ = this.Psych_Visit_Psychotherapy(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, czzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet czzzzzzzzzzzzzx_ = this.Behavioral_Neuropsych_Assessment(context);
        IEnumerable<Encounter> czzzzzzzzzzzzzy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, czzzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> czzzzzzzzzzzzzz_ = context.Operators.Union<Encounter>(czzzzzzzzzzzzzw_, czzzzzzzzzzzzzy_);
        IEnumerable<Encounter> dzzzzzzzzzzzzza_ = context.Operators.Union<Encounter>(czzzzzzzzzzzzzu_, czzzzzzzzzzzzzz_);
        CqlValueSet dzzzzzzzzzzzzzb_ = this.Occupational_Therapy_Evaluation(context);
        IEnumerable<Encounter> dzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet dzzzzzzzzzzzzzd_ = this.Office_Visit(context);
        IEnumerable<Encounter> dzzzzzzzzzzzzze_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> dzzzzzzzzzzzzzf_ = context.Operators.Union<Encounter>(dzzzzzzzzzzzzzc_, dzzzzzzzzzzzzze_);
        IEnumerable<Encounter> dzzzzzzzzzzzzzg_ = context.Operators.Union<Encounter>(dzzzzzzzzzzzzza_, dzzzzzzzzzzzzzf_);
        CqlValueSet dzzzzzzzzzzzzzh_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> dzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> dzzzzzzzzzzzzzj_ = context.Operators.Union<Encounter>(dzzzzzzzzzzzzzg_, dzzzzzzzzzzzzzi_);

        return dzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Dementia Encounter During Measurement Period")]
    public IEnumerable<Encounter> Dementia_Encounter_During_Measurement_Period(CqlContext context)
    {
        IEnumerable<Encounter> dzzzzzzzzzzzzzk_ = this.Encounter_to_Assess_Cognition(context);
        IEnumerable<Encounter> dzzzzzzzzzzzzzl_(Encounter EncounterAssessCognition)
        {
            CqlValueSet dzzzzzzzzzzzzzn_ = this.Dementia_and_Mental_Degenerations(context);
            IEnumerable<Condition> dzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dzzzzzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? dzzzzzzzzzzzzzp_(Condition Dementia)
            {
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzt_ = this.Measurement_Period(context);
                Period dzzzzzzzzzzzzzu_ = EncounterAssessCognition?.Period;
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzzzzzzu_);
                bool? dzzzzzzzzzzzzzw_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(dzzzzzzzzzzzzzt_, dzzzzzzzzzzzzzv_, "day");
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Dementia);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzzzzzzu_);
                bool? ezzzzzzzzzzzzza_ = context.Operators.Overlaps(dzzzzzzzzzzzzzx_, dzzzzzzzzzzzzzz_, "day");
                bool? ezzzzzzzzzzzzzb_ = context.Operators.And(dzzzzzzzzzzzzzw_, ezzzzzzzzzzzzza_);
                bool? ezzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.isActive(context, Dementia);
                bool? ezzzzzzzzzzzzzd_ = context.Operators.And(ezzzzzzzzzzzzzb_, ezzzzzzzzzzzzzc_);
                CodeableConcept ezzzzzzzzzzzzze_ = Dementia?.VerificationStatus;
                CqlConcept ezzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ezzzzzzzzzzzzze_);
                CqlCode ezzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.unconfirmed(context);
                CqlConcept ezzzzzzzzzzzzzh_ = context.Operators.ConvertCodeToConcept(ezzzzzzzzzzzzzg_);
                bool? ezzzzzzzzzzzzzi_ = context.Operators.Equivalent(ezzzzzzzzzzzzzf_, ezzzzzzzzzzzzzh_);
                CqlConcept ezzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ezzzzzzzzzzzzze_);
                CqlCode ezzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.refuted(context);
                CqlConcept ezzzzzzzzzzzzzm_ = context.Operators.ConvertCodeToConcept(ezzzzzzzzzzzzzl_);
                bool? ezzzzzzzzzzzzzn_ = context.Operators.Equivalent(ezzzzzzzzzzzzzk_, ezzzzzzzzzzzzzm_);
                bool? ezzzzzzzzzzzzzo_ = context.Operators.Or(ezzzzzzzzzzzzzi_, ezzzzzzzzzzzzzn_);
                CqlConcept ezzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ezzzzzzzzzzzzze_);
                CqlCode ezzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.entered_in_error(context);
                CqlConcept ezzzzzzzzzzzzzs_ = context.Operators.ConvertCodeToConcept(ezzzzzzzzzzzzzr_);
                bool? ezzzzzzzzzzzzzt_ = context.Operators.Equivalent(ezzzzzzzzzzzzzq_, ezzzzzzzzzzzzzs_);
                bool? ezzzzzzzzzzzzzu_ = context.Operators.Or(ezzzzzzzzzzzzzo_, ezzzzzzzzzzzzzt_);
                bool? ezzzzzzzzzzzzzv_ = context.Operators.Not(ezzzzzzzzzzzzzu_);
                bool? ezzzzzzzzzzzzzw_ = context.Operators.And(ezzzzzzzzzzzzzd_, ezzzzzzzzzzzzzv_);

                return ezzzzzzzzzzzzzw_;
            };
            IEnumerable<Condition> dzzzzzzzzzzzzzq_ = context.Operators.Where<Condition>(dzzzzzzzzzzzzzo_, dzzzzzzzzzzzzzp_);
            Encounter dzzzzzzzzzzzzzr_(Condition Dementia) =>
                EncounterAssessCognition;
            IEnumerable<Encounter> dzzzzzzzzzzzzzs_ = context.Operators.Select<Condition, Encounter>(dzzzzzzzzzzzzzq_, dzzzzzzzzzzzzzr_);

            return dzzzzzzzzzzzzzs_;
        };
        IEnumerable<Encounter> dzzzzzzzzzzzzzm_ = context.Operators.SelectMany<Encounter, Encounter>(dzzzzzzzzzzzzzk_, dzzzzzzzzzzzzzl_);

        return dzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Qualifying Encounter During Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Encounter_During_Measurement_Period(CqlContext context)
    {
        IEnumerable<Encounter> ezzzzzzzzzzzzzx_ = this.Encounter_to_Assess_Cognition(context);
        CqlValueSet ezzzzzzzzzzzzzy_ = this.Patient_Provider_Interaction(context);
        IEnumerable<Encounter> ezzzzzzzzzzzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ezzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> fzzzzzzzzzzzzza_ = context.Operators.Union<Encounter>(ezzzzzzzzzzzzzx_, ezzzzzzzzzzzzzz_);
        bool? fzzzzzzzzzzzzzb_(Encounter ValidEncounter)
        {
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzd_ = this.Measurement_Period(context);
            Period fzzzzzzzzzzzzze_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzzzzze_);
            bool? fzzzzzzzzzzzzzg_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(fzzzzzzzzzzzzzd_, fzzzzzzzzzzzzzf_, "day");
            Code<Encounter.EncounterStatus> fzzzzzzzzzzzzzh_ = ValidEncounter?.StatusElement;
            Encounter.EncounterStatus? fzzzzzzzzzzzzzi_ = fzzzzzzzzzzzzzh_?.Value;
            Code<Encounter.EncounterStatus> fzzzzzzzzzzzzzj_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(fzzzzzzzzzzzzzi_);
            bool? fzzzzzzzzzzzzzk_ = context.Operators.Equal(fzzzzzzzzzzzzzj_, "finished");
            bool? fzzzzzzzzzzzzzl_ = context.Operators.And(fzzzzzzzzzzzzzg_, fzzzzzzzzzzzzzk_);

            return fzzzzzzzzzzzzzl_;
        };
        IEnumerable<Encounter> fzzzzzzzzzzzzzc_ = context.Operators.Where<Encounter>(fzzzzzzzzzzzzza_, fzzzzzzzzzzzzzb_);

        return fzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> fzzzzzzzzzzzzzm_ = this.Dementia_Encounter_During_Measurement_Period(context);
        bool? fzzzzzzzzzzzzzn_ = context.Operators.Exists<Encounter>(fzzzzzzzzzzzzzm_);
        IEnumerable<Encounter> fzzzzzzzzzzzzzo_ = this.Qualifying_Encounter_During_Measurement_Period(context);
        int? fzzzzzzzzzzzzzp_ = context.Operators.Count<Encounter>(fzzzzzzzzzzzzzo_);
        bool? fzzzzzzzzzzzzzq_ = context.Operators.GreaterOrEqual(fzzzzzzzzzzzzzp_, 2);
        bool? fzzzzzzzzzzzzzr_ = context.Operators.And(fzzzzzzzzzzzzzn_, fzzzzzzzzzzzzzq_);

        return fzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? fzzzzzzzzzzzzzs_ = this.Initial_Population(context);

        return fzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Assessment of Cognition Using Standardized Tools or Alternate Methods")]
    public IEnumerable<Observation> Assessment_of_Cognition_Using_Standardized_Tools_or_Alternate_Methods(CqlContext context)
    {
        CqlValueSet fzzzzzzzzzzzzzt_ = this.Standardized_Tools_Score_for_Assessment_of_Cognition(context);
        IEnumerable<Observation> fzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, fzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        CqlValueSet fzzzzzzzzzzzzzv_ = this.Cognitive_Assessment(context);
        IEnumerable<Observation> fzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, fzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> fzzzzzzzzzzzzzx_ = context.Operators.Union<Observation>(fzzzzzzzzzzzzzu_, fzzzzzzzzzzzzzw_);
        IEnumerable<Observation> fzzzzzzzzzzzzzy_(Observation CognitiveAssessment)
        {
            IEnumerable<Encounter> gzzzzzzzzzzzzzc_ = this.Dementia_Encounter_During_Measurement_Period(context);
            bool? gzzzzzzzzzzzzzd_(Encounter EncounterDementia)
            {
                DataType gzzzzzzzzzzzzzh_ = CognitiveAssessment?.Effective;
                object gzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzzzzh_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzzzzzi_);
                CqlDateTime gzzzzzzzzzzzzzk_ = context.Operators.Start(gzzzzzzzzzzzzzj_);
                Period gzzzzzzzzzzzzzl_ = EncounterDementia?.Period;
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzzzzzl_);
                CqlDateTime gzzzzzzzzzzzzzn_ = context.Operators.End(gzzzzzzzzzzzzzm_);
                CqlQuantity gzzzzzzzzzzzzzo_ = context.Operators.Quantity(12m, "months");
                CqlDateTime gzzzzzzzzzzzzzp_ = context.Operators.Subtract(gzzzzzzzzzzzzzn_, gzzzzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzzzzzl_);
                CqlDateTime gzzzzzzzzzzzzzs_ = context.Operators.End(gzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzt_ = context.Operators.Interval(gzzzzzzzzzzzzzp_, gzzzzzzzzzzzzzs_, true, true);
                bool? gzzzzzzzzzzzzzu_ = context.Operators.In<CqlDateTime>(gzzzzzzzzzzzzzk_, gzzzzzzzzzzzzzt_, "day");
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gzzzzzzzzzzzzzl_);
                CqlDateTime gzzzzzzzzzzzzzx_ = context.Operators.End(gzzzzzzzzzzzzzw_);
                bool? gzzzzzzzzzzzzzy_ = context.Operators.Not((bool?)(gzzzzzzzzzzzzzx_ is null));
                bool? gzzzzzzzzzzzzzz_ = context.Operators.And(gzzzzzzzzzzzzzu_, gzzzzzzzzzzzzzy_);

                return gzzzzzzzzzzzzzz_;
            };
            IEnumerable<Encounter> gzzzzzzzzzzzzze_ = context.Operators.Where<Encounter>(gzzzzzzzzzzzzzc_, gzzzzzzzzzzzzzd_);
            Observation gzzzzzzzzzzzzzf_(Encounter EncounterDementia) =>
                CognitiveAssessment;
            IEnumerable<Observation> gzzzzzzzzzzzzzg_ = context.Operators.Select<Encounter, Observation>(gzzzzzzzzzzzzze_, gzzzzzzzzzzzzzf_);

            return gzzzzzzzzzzzzzg_;
        };
        IEnumerable<Observation> fzzzzzzzzzzzzzz_ = context.Operators.SelectMany<Observation, Observation>(fzzzzzzzzzzzzzx_, fzzzzzzzzzzzzzy_);
        bool? gzzzzzzzzzzzzza_(Observation CognitiveAssessment)
        {
            DataType hzzzzzzzzzzzzza_ = CognitiveAssessment?.Value;
            object hzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzza_);
            bool? hzzzzzzzzzzzzzc_ = context.Operators.Not((bool?)(hzzzzzzzzzzzzzb_ is null));
            Code<ObservationStatus> hzzzzzzzzzzzzzd_ = CognitiveAssessment?.StatusElement;
            ObservationStatus? hzzzzzzzzzzzzze_ = hzzzzzzzzzzzzzd_?.Value;
            Code<ObservationStatus> hzzzzzzzzzzzzzf_ = context.Operators.Convert<Code<ObservationStatus>>(hzzzzzzzzzzzzze_);
            string hzzzzzzzzzzzzzg_ = context.Operators.Convert<string>(hzzzzzzzzzzzzzf_);
            string[] hzzzzzzzzzzzzzh_ = [
                "final",
                "amended",
                "corrected",
                "preliminary",
            ];
            bool? hzzzzzzzzzzzzzi_ = context.Operators.In<string>(hzzzzzzzzzzzzzg_, hzzzzzzzzzzzzzh_ as IEnumerable<string>);
            bool? hzzzzzzzzzzzzzj_ = context.Operators.And(hzzzzzzzzzzzzzc_, hzzzzzzzzzzzzzi_);

            return hzzzzzzzzzzzzzj_;
        };
        IEnumerable<Observation> gzzzzzzzzzzzzzb_ = context.Operators.Where<Observation>(fzzzzzzzzzzzzzz_, gzzzzzzzzzzzzza_);

        return gzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<Observation> hzzzzzzzzzzzzzk_ = this.Assessment_of_Cognition_Using_Standardized_Tools_or_Alternate_Methods(context);
        bool? hzzzzzzzzzzzzzl_ = context.Operators.Exists<Observation>(hzzzzzzzzzzzzzk_);

        return hzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Patient Reason for Not Performing Assessment of Cognition Using Standardized Tools or Alternate Methods")]
    public IEnumerable<Observation> Patient_Reason_for_Not_Performing_Assessment_of_Cognition_Using_Standardized_Tools_or_Alternate_Methods(CqlContext context)
    {
        CqlValueSet hzzzzzzzzzzzzzm_ = this.Standardized_Tools_Score_for_Assessment_of_Cognition(context);
        IEnumerable<Observation> hzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, hzzzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observationnotdone"));
        CqlValueSet hzzzzzzzzzzzzzo_ = this.Cognitive_Assessment(context);
        IEnumerable<Observation> hzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, hzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observationnotdone"));
        IEnumerable<Observation> hzzzzzzzzzzzzzq_ = context.Operators.Union<Observation>(hzzzzzzzzzzzzzn_, hzzzzzzzzzzzzzp_);
        IEnumerable<Observation> hzzzzzzzzzzzzzr_(Observation NoCognitiveAssessment)
        {
            IEnumerable<Encounter> hzzzzzzzzzzzzzv_ = this.Dementia_Encounter_During_Measurement_Period(context);
            bool? hzzzzzzzzzzzzzw_(Encounter EncounterDementia)
            {
                Instant izzzzzzzzzzzzza_ = NoCognitiveAssessment?.IssuedElement;
                DateTimeOffset? izzzzzzzzzzzzzb_ = izzzzzzzzzzzzza_?.Value;
                CqlDateTime izzzzzzzzzzzzzc_ = context.Operators.Convert<CqlDateTime>(izzzzzzzzzzzzzb_);
                Period izzzzzzzzzzzzzd_ = EncounterDementia?.Period;
                CqlInterval<CqlDateTime> izzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzzzzd_);
                bool? izzzzzzzzzzzzzf_ = context.Operators.In<CqlDateTime>(izzzzzzzzzzzzzc_, izzzzzzzzzzzzze_, default);

                return izzzzzzzzzzzzzf_;
            };
            IEnumerable<Encounter> hzzzzzzzzzzzzzx_ = context.Operators.Where<Encounter>(hzzzzzzzzzzzzzv_, hzzzzzzzzzzzzzw_);
            Observation hzzzzzzzzzzzzzy_(Encounter EncounterDementia) =>
                NoCognitiveAssessment;
            IEnumerable<Observation> hzzzzzzzzzzzzzz_ = context.Operators.Select<Encounter, Observation>(hzzzzzzzzzzzzzx_, hzzzzzzzzzzzzzy_);

            return hzzzzzzzzzzzzzz_;
        };
        IEnumerable<Observation> hzzzzzzzzzzzzzs_ = context.Operators.SelectMany<Observation, Observation>(hzzzzzzzzzzzzzq_, hzzzzzzzzzzzzzr_);
        bool? hzzzzzzzzzzzzzt_(Observation NoCognitiveAssessment)
        {
            bool? izzzzzzzzzzzzzg_(Extension @this)
            {
                string izzzzzzzzzzzzzo_ = @this?.Url;
                FhirString izzzzzzzzzzzzzp_ = context.Operators.Convert<FhirString>(izzzzzzzzzzzzzo_);
                string izzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToString(context, izzzzzzzzzzzzzp_);
                bool? izzzzzzzzzzzzzr_ = context.Operators.Equal(izzzzzzzzzzzzzq_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");

                return izzzzzzzzzzzzzr_;
            };
            IEnumerable<Extension> izzzzzzzzzzzzzh_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(NoCognitiveAssessment is DomainResource
                    ? (NoCognitiveAssessment as DomainResource).Extension
                    : default), izzzzzzzzzzzzzg_);
            object izzzzzzzzzzzzzi_(Extension @this)
            {
                DataType izzzzzzzzzzzzzs_ = @this?.Value;

                return izzzzzzzzzzzzzs_;
            };
            IEnumerable<object> izzzzzzzzzzzzzj_ = context.Operators.Select<Extension, object>(izzzzzzzzzzzzzh_, izzzzzzzzzzzzzi_);
            object izzzzzzzzzzzzzk_ = context.Operators.SingletonFrom<object>(izzzzzzzzzzzzzj_);
            CqlConcept izzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, izzzzzzzzzzzzzk_ as CodeableConcept);
            CqlValueSet izzzzzzzzzzzzzm_ = this.Patient_Reason(context);
            bool? izzzzzzzzzzzzzn_ = context.Operators.ConceptInValueSet(izzzzzzzzzzzzzl_, izzzzzzzzzzzzzm_);

            return izzzzzzzzzzzzzn_;
        };
        IEnumerable<Observation> hzzzzzzzzzzzzzu_ = context.Operators.Where<Observation>(hzzzzzzzzzzzzzs_, hzzzzzzzzzzzzzt_);

        return hzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public bool? Denominator_Exceptions(CqlContext context)
    {
        IEnumerable<Observation> izzzzzzzzzzzzzt_ = this.Patient_Reason_for_Not_Performing_Assessment_of_Cognition_Using_Standardized_Tools_or_Alternate_Methods(context);
        bool? izzzzzzzzzzzzzu_ = context.Operators.Exists<Observation>(izzzzzzzzzzzzzt_);

        return izzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? izzzzzzzzzzzzzv_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return izzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? izzzzzzzzzzzzzw_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return izzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode izzzzzzzzzzzzzx_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return izzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> izzzzzzzzzzzzzy_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return izzzzzzzzzzzzzy_;
    }


    #endregion Expressions

}
