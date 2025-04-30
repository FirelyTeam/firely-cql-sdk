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
    private static readonly CqlCodeSystem _ActCode =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/v3-ActCode", null, []);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime xzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime xzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Interval(xzzzzzzzzzzzzzzzzzzzzl_, xzzzzzzzzzzzzzzzzzzzzm_, true, true);
        object xzzzzzzzzzzzzzzzzzzzzo_ = context.ResolveParameter("DementiaCognitiveAssessmentFHIR-0.1.000", "Measurement Period", xzzzzzzzzzzzzzzzzzzzzn_);

        return (CqlInterval<CqlDateTime>)xzzzzzzzzzzzzzzzzzzzzo_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> xzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient xzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.SingletonFrom<Patient>(xzzzzzzzzzzzzzzzzzzzzp_);

        return xzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Encounter to Assess Cognition")]
    public IEnumerable<Encounter> Encounter_to_Assess_Cognition(CqlContext context)
    {
        CqlValueSet xzzzzzzzzzzzzzzzzzzzzr_ = this.Psych_Visit_Diagnostic_Evaluation(context);
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet xzzzzzzzzzzzzzzzzzzzzt_ = this.Nursing_Facility_Visit(context);
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Union<Encounter>(xzzzzzzzzzzzzzzzzzzzzs_, xzzzzzzzzzzzzzzzzzzzzu_);
        CqlValueSet xzzzzzzzzzzzzzzzzzzzzw_ = this.Care_Services_in_Long_Term_Residential_Facility(context);
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet xzzzzzzzzzzzzzzzzzzzzy_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, xzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Union<Encounter>(xzzzzzzzzzzzzzzzzzzzzx_, xzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Union<Encounter>(xzzzzzzzzzzzzzzzzzzzzv_, yzzzzzzzzzzzzzzzzzzzza_);
        CqlValueSet yzzzzzzzzzzzzzzzzzzzzc_ = this.Psych_Visit_Psychotherapy(context);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet yzzzzzzzzzzzzzzzzzzzze_ = this.Behavioral_Neuropsych_Assessment(context);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Union<Encounter>(yzzzzzzzzzzzzzzzzzzzzd_, yzzzzzzzzzzzzzzzzzzzzf_);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<Encounter>(yzzzzzzzzzzzzzzzzzzzzb_, yzzzzzzzzzzzzzzzzzzzzg_);
        CqlValueSet yzzzzzzzzzzzzzzzzzzzzi_ = this.Occupational_Therapy_Evaluation(context);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet yzzzzzzzzzzzzzzzzzzzzk_ = this.Office_Visit(context);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Union<Encounter>(yzzzzzzzzzzzzzzzzzzzzj_, yzzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Union<Encounter>(yzzzzzzzzzzzzzzzzzzzzh_, yzzzzzzzzzzzzzzzzzzzzm_);
        CqlValueSet yzzzzzzzzzzzzzzzzzzzzo_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Union<Encounter>(yzzzzzzzzzzzzzzzzzzzzn_, yzzzzzzzzzzzzzzzzzzzzp_);

        return yzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Dementia Encounter During Measurement Period")]
    public IEnumerable<Encounter> Dementia_Encounter_During_Measurement_Period(CqlContext context)
    {
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzr_ = this.Encounter_to_Assess_Cognition(context);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzs_(Encounter EncounterAssessCognition)
        {
            CqlValueSet yzzzzzzzzzzzzzzzzzzzzu_ = this.Dementia_and_Mental_Degenerations(context);
            IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, yzzzzzzzzzzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
            bool? yzzzzzzzzzzzzzzzzzzzzw_(Condition Dementia)
            {
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzza_ = this.Measurement_Period(context);
                Period zzzzzzzzzzzzzzzzzzzzzb_ = EncounterAssessCognition?.Period;
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzzzzzzzzzb_);
                bool? zzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(zzzzzzzzzzzzzzzzzzzzza_, zzzzzzzzzzzzzzzzzzzzzc_, "day");
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, Dementia);
                CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzzzzzzzzzb_);
                bool? zzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Overlaps(zzzzzzzzzzzzzzzzzzzzze_, zzzzzzzzzzzzzzzzzzzzzg_, "day");
                bool? zzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzd_, zzzzzzzzzzzzzzzzzzzzzh_);
                bool? zzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.isActive(context, Dementia);
                bool? zzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzi_, zzzzzzzzzzzzzzzzzzzzzj_);
                CodeableConcept zzzzzzzzzzzzzzzzzzzzzl_ = Dementia?.VerificationStatus;
                CqlConcept zzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, zzzzzzzzzzzzzzzzzzzzzl_);
                CqlCode zzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.unconfirmed(context);
                CqlConcept zzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.ConvertCodeToConcept(zzzzzzzzzzzzzzzzzzzzzn_);
                bool? zzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Equivalent(zzzzzzzzzzzzzzzzzzzzzm_, zzzzzzzzzzzzzzzzzzzzzo_);
                CqlConcept zzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, zzzzzzzzzzzzzzzzzzzzzl_);
                CqlCode zzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.refuted(context);
                CqlConcept zzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.ConvertCodeToConcept(zzzzzzzzzzzzzzzzzzzzzs_);
                bool? zzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Equivalent(zzzzzzzzzzzzzzzzzzzzzr_, zzzzzzzzzzzzzzzzzzzzzt_);
                bool? zzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Or(zzzzzzzzzzzzzzzzzzzzzp_, zzzzzzzzzzzzzzzzzzzzzu_);
                CqlConcept zzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, zzzzzzzzzzzzzzzzzzzzzl_);
                CqlCode zzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.entered_in_error(context);
                CqlConcept zzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.ConvertCodeToConcept(zzzzzzzzzzzzzzzzzzzzzy_);
                bool? azzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Equivalent(zzzzzzzzzzzzzzzzzzzzzx_, zzzzzzzzzzzzzzzzzzzzzz_);
                bool? azzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Or(zzzzzzzzzzzzzzzzzzzzzv_, azzzzzzzzzzzzzzzzzzzzza_);
                bool? azzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Not(azzzzzzzzzzzzzzzzzzzzzb_);
                bool? azzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzk_, azzzzzzzzzzzzzzzzzzzzzc_);

                return azzzzzzzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<Condition> yzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Where<Condition>(yzzzzzzzzzzzzzzzzzzzzv_, yzzzzzzzzzzzzzzzzzzzzw_);
            Encounter yzzzzzzzzzzzzzzzzzzzzy_(Condition Dementia) =>
                EncounterAssessCognition;
            IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Select<Condition, Encounter>(yzzzzzzzzzzzzzzzzzzzzx_, yzzzzzzzzzzzzzzzzzzzzy_);

            return yzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.SelectMany<Encounter, Encounter>(yzzzzzzzzzzzzzzzzzzzzr_, yzzzzzzzzzzzzzzzzzzzzs_);

        return yzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Qualifying Encounter During Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Encounter_During_Measurement_Period(CqlContext context)
    {
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzze_ = this.Encounter_to_Assess_Cognition(context);
        CqlValueSet azzzzzzzzzzzzzzzzzzzzzf_ = this.Patient_Provider_Interaction(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Union<Encounter>(azzzzzzzzzzzzzzzzzzzzze_, azzzzzzzzzzzzzzzzzzzzzg_);
        bool? azzzzzzzzzzzzzzzzzzzzzi_(Encounter ValidEncounter)
        {
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzk_ = this.Measurement_Period(context);
            Period azzzzzzzzzzzzzzzzzzzzzl_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, azzzzzzzzzzzzzzzzzzzzzl_);
            bool? azzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(azzzzzzzzzzzzzzzzzzzzzk_, azzzzzzzzzzzzzzzzzzzzzm_, "day");
            Code<Encounter.EncounterStatus> azzzzzzzzzzzzzzzzzzzzzo_ = ValidEncounter?.StatusElement;
            Encounter.EncounterStatus? azzzzzzzzzzzzzzzzzzzzzp_ = azzzzzzzzzzzzzzzzzzzzzo_?.Value;
            Code<Encounter.EncounterStatus> azzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(azzzzzzzzzzzzzzzzzzzzzp_);
            bool? azzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Equal(azzzzzzzzzzzzzzzzzzzzzq_, "finished");
            bool? azzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzzzn_, azzzzzzzzzzzzzzzzzzzzzr_);

            return azzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Encounter>(azzzzzzzzzzzzzzzzzzzzzh_, azzzzzzzzzzzzzzzzzzzzzi_);

        return azzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzt_ = this.Dementia_Encounter_During_Measurement_Period(context);
        bool? azzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Exists<Encounter>(azzzzzzzzzzzzzzzzzzzzzt_);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzv_ = this.Qualifying_Encounter_During_Measurement_Period(context);
        int? azzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Count<Encounter>(azzzzzzzzzzzzzzzzzzzzzv_);
        bool? azzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.GreaterOrEqual(azzzzzzzzzzzzzzzzzzzzzw_, 2);
        bool? azzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzzzu_, azzzzzzzzzzzzzzzzzzzzzx_);

        return azzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? azzzzzzzzzzzzzzzzzzzzzz_ = this.Initial_Population(context);

        return azzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Assessment of Cognition Using Standardized Tools or Alternate Methods")]
    public IEnumerable<Observation> Assessment_of_Cognition_Using_Standardized_Tools_or_Alternate_Methods(CqlContext context)
    {
        CqlValueSet bzzzzzzzzzzzzzzzzzzzzza_ = this.Standardized_Tools_Score_for_Assessment_of_Cognition(context);
        IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzza_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        CqlValueSet bzzzzzzzzzzzzzzzzzzzzzc_ = this.Cognitive_Assessment(context);
        IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzzzzc_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Union<Observation>(bzzzzzzzzzzzzzzzzzzzzzb_, bzzzzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzzzf_(Observation CognitiveAssessment)
        {
            IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzj_ = this.Dementia_Encounter_During_Measurement_Period(context);
            bool? bzzzzzzzzzzzzzzzzzzzzzk_(Encounter EncounterDementia)
            {
                DataType bzzzzzzzzzzzzzzzzzzzzzo_ = CognitiveAssessment?.Effective;
                object bzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzo_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzzzzzzzzzzzp_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzzzq_);
                Period bzzzzzzzzzzzzzzzzzzzzzs_ = EncounterDementia?.Period;
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzzzzzzs_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.End(bzzzzzzzzzzzzzzzzzzzzzt_);
                CqlQuantity bzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Quantity(12m, "months");
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Subtract(bzzzzzzzzzzzzzzzzzzzzzu_, bzzzzzzzzzzzzzzzzzzzzzv_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzzzzzzs_);
                CqlDateTime bzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.End(bzzzzzzzzzzzzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Interval(bzzzzzzzzzzzzzzzzzzzzzw_, bzzzzzzzzzzzzzzzzzzzzzz_, true, true);
                bool? czzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzzr_, czzzzzzzzzzzzzzzzzzzzza_, "day");
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzzzzzzs_);
                CqlDateTime czzzzzzzzzzzzzzzzzzzzze_ = context.Operators.End(czzzzzzzzzzzzzzzzzzzzzd_);
                bool? czzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Not((bool?)(czzzzzzzzzzzzzzzzzzzzze_ is null));
                bool? czzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzzb_, czzzzzzzzzzzzzzzzzzzzzf_);

                return czzzzzzzzzzzzzzzzzzzzzg_;
            };
            IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Encounter>(bzzzzzzzzzzzzzzzzzzzzzj_, bzzzzzzzzzzzzzzzzzzzzzk_);
            Observation bzzzzzzzzzzzzzzzzzzzzzm_(Encounter EncounterDementia) =>
                CognitiveAssessment;
            IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Select<Encounter, Observation>(bzzzzzzzzzzzzzzzzzzzzzl_, bzzzzzzzzzzzzzzzzzzzzzm_);

            return bzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.SelectMany<Observation, Observation>(bzzzzzzzzzzzzzzzzzzzzze_, bzzzzzzzzzzzzzzzzzzzzzf_);
        bool? bzzzzzzzzzzzzzzzzzzzzzh_(Observation CognitiveAssessment)
        {
            DataType czzzzzzzzzzzzzzzzzzzzzh_ = CognitiveAssessment?.Value;
            object czzzzzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, czzzzzzzzzzzzzzzzzzzzzh_);
            bool? czzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Not((bool?)(czzzzzzzzzzzzzzzzzzzzzi_ is null));
            Code<ObservationStatus> czzzzzzzzzzzzzzzzzzzzzk_ = CognitiveAssessment?.StatusElement;
            ObservationStatus? czzzzzzzzzzzzzzzzzzzzzl_ = czzzzzzzzzzzzzzzzzzzzzk_?.Value;
            Code<ObservationStatus> czzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Convert<Code<ObservationStatus>>(czzzzzzzzzzzzzzzzzzzzzl_);
            string czzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Convert<string>(czzzzzzzzzzzzzzzzzzzzzm_);
            string[] czzzzzzzzzzzzzzzzzzzzzo_ = [
                "final",
                "amended",
                "corrected",
                "preliminary",
            ];
            bool? czzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.In<string>(czzzzzzzzzzzzzzzzzzzzzn_, czzzzzzzzzzzzzzzzzzzzzo_ as IEnumerable<string>);
            bool? czzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzzj_, czzzzzzzzzzzzzzzzzzzzzp_);

            return czzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<Observation> bzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<Observation>(bzzzzzzzzzzzzzzzzzzzzzg_, bzzzzzzzzzzzzzzzzzzzzzh_);

        return bzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzr_ = this.Assessment_of_Cognition_Using_Standardized_Tools_or_Alternate_Methods(context);
        bool? czzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Exists<Observation>(czzzzzzzzzzzzzzzzzzzzzr_);

        return czzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Patient Reason for Not Performing Assessment of Cognition Using Standardized Tools or Alternate Methods")]
    public IEnumerable<Observation> Patient_Reason_for_Not_Performing_Assessment_of_Cognition_Using_Standardized_Tools_or_Alternate_Methods(CqlContext context)
    {
        CqlValueSet czzzzzzzzzzzzzzzzzzzzzt_ = this.Standardized_Tools_Score_for_Assessment_of_Cognition(context);
        IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observationnotdone"));
        CqlValueSet czzzzzzzzzzzzzzzzzzzzzv_ = this.Cognitive_Assessment(context);
        IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observationnotdone"));
        IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Union<Observation>(czzzzzzzzzzzzzzzzzzzzzu_, czzzzzzzzzzzzzzzzzzzzzw_);
        IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzy_(Observation NoCognitiveAssessment)
        {
            IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzzc_ = this.Dementia_Encounter_During_Measurement_Period(context);
            bool? dzzzzzzzzzzzzzzzzzzzzzd_(Encounter EncounterDementia)
            {
                Instant dzzzzzzzzzzzzzzzzzzzzzh_ = NoCognitiveAssessment?.IssuedElement;
                DateTimeOffset? dzzzzzzzzzzzzzzzzzzzzzi_ = dzzzzzzzzzzzzzzzzzzzzzh_?.Value;
                CqlDateTime dzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Convert<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzzi_);
                Period dzzzzzzzzzzzzzzzzzzzzzk_ = EncounterDementia?.Period;
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dzzzzzzzzzzzzzzzzzzzzzk_);
                bool? dzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.In<CqlDateTime>(dzzzzzzzzzzzzzzzzzzzzzj_, dzzzzzzzzzzzzzzzzzzzzzl_, default);

                return dzzzzzzzzzzzzzzzzzzzzzm_;
            };
            IEnumerable<Encounter> dzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<Encounter>(dzzzzzzzzzzzzzzzzzzzzzc_, dzzzzzzzzzzzzzzzzzzzzzd_);
            Observation dzzzzzzzzzzzzzzzzzzzzzf_(Encounter EncounterDementia) =>
                NoCognitiveAssessment;
            IEnumerable<Observation> dzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Select<Encounter, Observation>(dzzzzzzzzzzzzzzzzzzzzze_, dzzzzzzzzzzzzzzzzzzzzzf_);

            return dzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Observation> czzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.SelectMany<Observation, Observation>(czzzzzzzzzzzzzzzzzzzzzx_, czzzzzzzzzzzzzzzzzzzzzy_);
        bool? dzzzzzzzzzzzzzzzzzzzzza_(Observation NoCognitiveAssessment)
        {
            bool? dzzzzzzzzzzzzzzzzzzzzzn_(Extension @this)
            {
                string dzzzzzzzzzzzzzzzzzzzzzv_ = @this?.Url;
                FhirString dzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Convert<FhirString>(dzzzzzzzzzzzzzzzzzzzzzv_);
                string dzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToString(context, dzzzzzzzzzzzzzzzzzzzzzw_);
                bool? dzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Equal(dzzzzzzzzzzzzzzzzzzzzzx_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");

                return dzzzzzzzzzzzzzzzzzzzzzy_;
            };
            IEnumerable<Extension> dzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(NoCognitiveAssessment is DomainResource
                    ? (NoCognitiveAssessment as DomainResource).Extension
                    : default), dzzzzzzzzzzzzzzzzzzzzzn_);
            object dzzzzzzzzzzzzzzzzzzzzzp_(Extension @this)
            {
                DataType dzzzzzzzzzzzzzzzzzzzzzz_ = @this?.Value;

                return dzzzzzzzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<object> dzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Select<Extension, object>(dzzzzzzzzzzzzzzzzzzzzzo_, dzzzzzzzzzzzzzzzzzzzzzp_);
            object dzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.SingletonFrom<object>(dzzzzzzzzzzzzzzzzzzzzzq_);
            CqlConcept dzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, dzzzzzzzzzzzzzzzzzzzzzr_ as CodeableConcept);
            CqlValueSet dzzzzzzzzzzzzzzzzzzzzzt_ = this.Patient_Reason(context);
            bool? dzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.ConceptInValueSet(dzzzzzzzzzzzzzzzzzzzzzs_, dzzzzzzzzzzzzzzzzzzzzzt_);

            return dzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<Observation> dzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Where<Observation>(czzzzzzzzzzzzzzzzzzzzzz_, dzzzzzzzzzzzzzzzzzzzzza_);

        return dzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public bool? Denominator_Exceptions(CqlContext context)
    {
        IEnumerable<Observation> ezzzzzzzzzzzzzzzzzzzzza_ = this.Patient_Reason_for_Not_Performing_Assessment_of_Cognition_Using_Standardized_Tools_or_Alternate_Methods(context);
        bool? ezzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Exists<Observation>(ezzzzzzzzzzzzzzzzzzzzza_);

        return ezzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? ezzzzzzzzzzzzzzzzzzzzzc_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return ezzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? ezzzzzzzzzzzzzzzzzzzzzd_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return ezzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode ezzzzzzzzzzzzzzzzzzzzze_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return ezzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> ezzzzzzzzzzzzzzzzzzzzzf_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return ezzzzzzzzzzzzzzzzzzzzzf_;
    }


    #endregion Expressions

}
