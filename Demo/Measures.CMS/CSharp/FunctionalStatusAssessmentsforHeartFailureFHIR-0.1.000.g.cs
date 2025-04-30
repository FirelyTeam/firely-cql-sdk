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
[CqlLibrary("FunctionalStatusAssessmentsforHeartFailureFHIR", "0.1.000")]
public partial class FunctionalStatusAssessmentsforHeartFailureFHIR_0_1_000 : ILibrary, ISingleton<FunctionalStatusAssessmentsforHeartFailureFHIR_0_1_000>
{
    private FunctionalStatusAssessmentsforHeartFailureFHIR_0_1_000() {}

    public static FunctionalStatusAssessmentsforHeartFailureFHIR_0_1_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "FunctionalStatusAssessmentsforHeartFailureFHIR";
    public string Version => "0.1.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, QICoreCommon_2_1_000.Instance, SupplementalDataElements_3_5_000.Instance, Hospice_6_12_000.Instance, Status_1_8_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Heart Failure", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.376", valueSetVersion: null)]
    public CqlValueSet Heart_Failure(CqlContext _) => _Heart_Failure;
    private static readonly CqlValueSet _Heart_Failure = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.376", null);

    [CqlValueSetDefinition("Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext _) => _Office_Visit;
    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlValueSetDefinition("Virtual Encounter", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", valueSetVersion: null)]
    public CqlValueSet Virtual_Encounter(CqlContext _) => _Virtual_Encounter;
    private static readonly CqlValueSet _Virtual_Encounter = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", null);

    [CqlValueSetDefinition("Telephone Visits", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", valueSetVersion: null)]
    public CqlValueSet Telephone_Visits(CqlContext _) => _Telephone_Visits;
    private static readonly CqlValueSet _Telephone_Visits = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Emotional score [MLHFQ]", codeId: "85609-6", codeSystem: "http://loinc.org")]
    public CqlCode Emotional_score__MLHFQ_(CqlContext _) => _Emotional_score__MLHFQ_;
    private static readonly CqlCode _Emotional_score__MLHFQ_ = new CqlCode("85609-6", "http://loinc.org", default, default);

    [CqlCodeDefinition("Kansas City Cardiomyopathy Questionnaire - 12 item [KCCQ-12]", codeId: "86923-0", codeSystem: "http://loinc.org")]
    public CqlCode Kansas_City_Cardiomyopathy_Questionnaire___12_item__KCCQ_12_(CqlContext _) => _Kansas_City_Cardiomyopathy_Questionnaire___12_item__KCCQ_12_;
    private static readonly CqlCode _Kansas_City_Cardiomyopathy_Questionnaire___12_item__KCCQ_12_ = new CqlCode("86923-0", "http://loinc.org", default, default);

    [CqlCodeDefinition("Overall summary score [KCCQ-12]", codeId: "86924-8", codeSystem: "http://loinc.org")]
    public CqlCode Overall_summary_score__KCCQ_12_(CqlContext _) => _Overall_summary_score__KCCQ_12_;
    private static readonly CqlCode _Overall_summary_score__KCCQ_12_ = new CqlCode("86924-8", "http://loinc.org", default, default);

    [CqlCodeDefinition("Overall summary score [KCCQ]", codeId: "71940-1", codeSystem: "http://loinc.org")]
    public CqlCode Overall_summary_score__KCCQ_(CqlContext _) => _Overall_summary_score__KCCQ_;
    private static readonly CqlCode _Overall_summary_score__KCCQ_ = new CqlCode("71940-1", "http://loinc.org", default, default);

    [CqlCodeDefinition("Physical limitation score [KCCQ]", codeId: "72195-1", codeSystem: "http://loinc.org")]
    public CqlCode Physical_limitation_score__KCCQ_(CqlContext _) => _Physical_limitation_score__KCCQ_;
    private static readonly CqlCode _Physical_limitation_score__KCCQ_ = new CqlCode("72195-1", "http://loinc.org", default, default);

    [CqlCodeDefinition("Physical score [MLHFQ]", codeId: "85618-7", codeSystem: "http://loinc.org")]
    public CqlCode Physical_score__MLHFQ_(CqlContext _) => _Physical_score__MLHFQ_;
    private static readonly CqlCode _Physical_score__MLHFQ_ = new CqlCode("85618-7", "http://loinc.org", default, default);

    [CqlCodeDefinition("PROMIS-10 Global Mental Health (GMH) score T-score", codeId: "71969-0", codeSystem: "http://loinc.org")]
    public CqlCode PROMIS_10_Global_Mental_Health__GMH__score_T_score(CqlContext _) => _PROMIS_10_Global_Mental_Health__GMH__score_T_score;
    private static readonly CqlCode _PROMIS_10_Global_Mental_Health__GMH__score_T_score = new CqlCode("71969-0", "http://loinc.org", default, default);

    [CqlCodeDefinition("PROMIS-10 Global Physical Health (GPH) score T-score", codeId: "71971-6", codeSystem: "http://loinc.org")]
    public CqlCode PROMIS_10_Global_Physical_Health__GPH__score_T_score(CqlContext _) => _PROMIS_10_Global_Physical_Health__GPH__score_T_score;
    private static readonly CqlCode _PROMIS_10_Global_Physical_Health__GPH__score_T_score = new CqlCode("71971-6", "http://loinc.org", default, default);

    [CqlCodeDefinition("PROMIS-29 Anxiety score T-score", codeId: "71967-4", codeSystem: "http://loinc.org")]
    public CqlCode PROMIS_29_Anxiety_score_T_score(CqlContext _) => _PROMIS_29_Anxiety_score_T_score;
    private static readonly CqlCode _PROMIS_29_Anxiety_score_T_score = new CqlCode("71967-4", "http://loinc.org", default, default);

    [CqlCodeDefinition("PROMIS-29 Depression score T-score", codeId: "71965-8", codeSystem: "http://loinc.org")]
    public CqlCode PROMIS_29_Depression_score_T_score(CqlContext _) => _PROMIS_29_Depression_score_T_score;
    private static readonly CqlCode _PROMIS_29_Depression_score_T_score = new CqlCode("71965-8", "http://loinc.org", default, default);

    [CqlCodeDefinition("PROMIS-29 Fatigue score T-score", codeId: "71963-3", codeSystem: "http://loinc.org")]
    public CqlCode PROMIS_29_Fatigue_score_T_score(CqlContext _) => _PROMIS_29_Fatigue_score_T_score;
    private static readonly CqlCode _PROMIS_29_Fatigue_score_T_score = new CqlCode("71963-3", "http://loinc.org", default, default);

    [CqlCodeDefinition("PROMIS-29 Pain interference score T-score", codeId: "71961-7", codeSystem: "http://loinc.org")]
    public CqlCode PROMIS_29_Pain_interference_score_T_score(CqlContext _) => _PROMIS_29_Pain_interference_score_T_score;
    private static readonly CqlCode _PROMIS_29_Pain_interference_score_T_score = new CqlCode("71961-7", "http://loinc.org", default, default);

    [CqlCodeDefinition("PROMIS-29 Physical function score T-score", codeId: "71959-1", codeSystem: "http://loinc.org")]
    public CqlCode PROMIS_29_Physical_function_score_T_score(CqlContext _) => _PROMIS_29_Physical_function_score_T_score;
    private static readonly CqlCode _PROMIS_29_Physical_function_score_T_score = new CqlCode("71959-1", "http://loinc.org", default, default);

    [CqlCodeDefinition("PROMIS-29 Satisfaction with participation in social roles score T-score", codeId: "71957-5", codeSystem: "http://loinc.org")]
    public CqlCode PROMIS_29_Satisfaction_with_participation_in_social_roles_score_T_score(CqlContext _) => _PROMIS_29_Satisfaction_with_participation_in_social_roles_score_T_score;
    private static readonly CqlCode _PROMIS_29_Satisfaction_with_participation_in_social_roles_score_T_score = new CqlCode("71957-5", "http://loinc.org", default, default);

    [CqlCodeDefinition("PROMIS-29 Sleep disturbance score T-score", codeId: "71955-9", codeSystem: "http://loinc.org")]
    public CqlCode PROMIS_29_Sleep_disturbance_score_T_score(CqlContext _) => _PROMIS_29_Sleep_disturbance_score_T_score;
    private static readonly CqlCode _PROMIS_29_Sleep_disturbance_score_T_score = new CqlCode("71955-9", "http://loinc.org", default, default);

    [CqlCodeDefinition("Quality of life score [KCCQ]", codeId: "72189-4", codeSystem: "http://loinc.org")]
    public CqlCode Quality_of_life_score__KCCQ_(CqlContext _) => _Quality_of_life_score__KCCQ_;
    private static readonly CqlCode _Quality_of_life_score__KCCQ_ = new CqlCode("72189-4", "http://loinc.org", default, default);

    [CqlCodeDefinition("Self-efficacy score [KCCQ]", codeId: "72190-2", codeSystem: "http://loinc.org")]
    public CqlCode Self_efficacy_score__KCCQ_(CqlContext _) => _Self_efficacy_score__KCCQ_;
    private static readonly CqlCode _Self_efficacy_score__KCCQ_ = new CqlCode("72190-2", "http://loinc.org", default, default);

    [CqlCodeDefinition("Severe cognitive impairment (finding)", codeId: "702956004", codeSystem: "http://snomed.info/sct")]
    public CqlCode Severe_cognitive_impairment__finding_(CqlContext _) => _Severe_cognitive_impairment__finding_;
    private static readonly CqlCode _Severe_cognitive_impairment__finding_ = new CqlCode("702956004", "http://snomed.info/sct", default, default);

    [CqlCodeDefinition("Social limitation score [KCCQ]", codeId: "72196-9", codeSystem: "http://loinc.org")]
    public CqlCode Social_limitation_score__KCCQ_(CqlContext _) => _Social_limitation_score__KCCQ_;
    private static readonly CqlCode _Social_limitation_score__KCCQ_ = new CqlCode("72196-9", "http://loinc.org", default, default);

    [CqlCodeDefinition("Symptom stability score [KCCQ]", codeId: "72194-4", codeSystem: "http://loinc.org")]
    public CqlCode Symptom_stability_score__KCCQ_(CqlContext _) => _Symptom_stability_score__KCCQ_;
    private static readonly CqlCode _Symptom_stability_score__KCCQ_ = new CqlCode("72194-4", "http://loinc.org", default, default);

    [CqlCodeDefinition("Total score [MLHFQ]", codeId: "71938-5", codeSystem: "http://loinc.org")]
    public CqlCode Total_score__MLHFQ_(CqlContext _) => _Total_score__MLHFQ_;
    private static readonly CqlCode _Total_score__MLHFQ_ = new CqlCode("71938-5", "http://loinc.org", default, default);

    [CqlCodeDefinition("Total symptom score [KCCQ]", codeId: "72191-0", codeSystem: "http://loinc.org")]
    public CqlCode Total_symptom_score__KCCQ_(CqlContext _) => _Total_symptom_score__KCCQ_;
    private static readonly CqlCode _Total_symptom_score__KCCQ_ = new CqlCode("72191-0", "http://loinc.org", default, default);

    [CqlCodeDefinition("VR-12 Mental component summary (MCS) score - oblique method T-score", codeId: "72026-8", codeSystem: "http://loinc.org")]
    public CqlCode VR_12_Mental_component_summary__MCS__score___oblique_method_T_score(CqlContext _) => _VR_12_Mental_component_summary__MCS__score___oblique_method_T_score;
    private static readonly CqlCode _VR_12_Mental_component_summary__MCS__score___oblique_method_T_score = new CqlCode("72026-8", "http://loinc.org", default, default);

    [CqlCodeDefinition("VR-12 Mental component summary (MCS) score - orthogonal method T-score", codeId: "72028-4", codeSystem: "http://loinc.org")]
    public CqlCode VR_12_Mental_component_summary__MCS__score___orthogonal_method_T_score(CqlContext _) => _VR_12_Mental_component_summary__MCS__score___orthogonal_method_T_score;
    private static readonly CqlCode _VR_12_Mental_component_summary__MCS__score___orthogonal_method_T_score = new CqlCode("72028-4", "http://loinc.org", default, default);

    [CqlCodeDefinition("VR-12 Physical component summary (PCS) score - oblique method T-score", codeId: "72025-0", codeSystem: "http://loinc.org")]
    public CqlCode VR_12_Physical_component_summary__PCS__score___oblique_method_T_score(CqlContext _) => _VR_12_Physical_component_summary__PCS__score___oblique_method_T_score;
    private static readonly CqlCode _VR_12_Physical_component_summary__PCS__score___oblique_method_T_score = new CqlCode("72025-0", "http://loinc.org", default, default);

    [CqlCodeDefinition("VR-12 Physical component summary (PCS) score - orthogonal method T-score", codeId: "72027-6", codeSystem: "http://loinc.org")]
    public CqlCode VR_12_Physical_component_summary__PCS__score___orthogonal_method_T_score(CqlContext _) => _VR_12_Physical_component_summary__PCS__score___orthogonal_method_T_score;
    private static readonly CqlCode _VR_12_Physical_component_summary__PCS__score___orthogonal_method_T_score = new CqlCode("72027-6", "http://loinc.org", default, default);

    [CqlCodeDefinition("VR-36 Mental component summary (MCS) score - oblique method T-score", codeId: "71990-6", codeSystem: "http://loinc.org")]
    public CqlCode VR_36_Mental_component_summary__MCS__score___oblique_method_T_score(CqlContext _) => _VR_36_Mental_component_summary__MCS__score___oblique_method_T_score;
    private static readonly CqlCode _VR_36_Mental_component_summary__MCS__score___oblique_method_T_score = new CqlCode("71990-6", "http://loinc.org", default, default);

    [CqlCodeDefinition("VR-36 Mental component summary (MCS) score - orthogonal method T-score", codeId: "72008-6", codeSystem: "http://loinc.org")]
    public CqlCode VR_36_Mental_component_summary__MCS__score___orthogonal_method_T_score(CqlContext _) => _VR_36_Mental_component_summary__MCS__score___orthogonal_method_T_score;
    private static readonly CqlCode _VR_36_Mental_component_summary__MCS__score___orthogonal_method_T_score = new CqlCode("72008-6", "http://loinc.org", default, default);

    [CqlCodeDefinition("VR-36 Physical component summary (PCS) score - oblique method T-score", codeId: "71989-8", codeSystem: "http://loinc.org")]
    public CqlCode VR_36_Physical_component_summary__PCS__score___oblique_method_T_score(CqlContext _) => _VR_36_Physical_component_summary__PCS__score___oblique_method_T_score;
    private static readonly CqlCode _VR_36_Physical_component_summary__PCS__score___oblique_method_T_score = new CqlCode("71989-8", "http://loinc.org", default, default);

    [CqlCodeDefinition("VR-36 Physical component summary (PCS) score - orthogonal method T-score", codeId: "72007-8", codeSystem: "http://loinc.org")]
    public CqlCode VR_36_Physical_component_summary__PCS__score___orthogonal_method_T_score(CqlContext _) => _VR_36_Physical_component_summary__PCS__score___orthogonal_method_T_score;
    private static readonly CqlCode _VR_36_Physical_component_summary__PCS__score___orthogonal_method_T_score = new CqlCode("72007-8", "http://loinc.org", default, default);

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC")]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC = new CqlCodeSystem();

    [CqlCodeSystemDefinition("SNOMEDCT")]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT = new CqlCodeSystem();

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime azzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime azzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Interval(azzzzzzzzzzzzzzzzzzzzzzj_, azzzzzzzzzzzzzzzzzzzzzzk_, true, true);
        object azzzzzzzzzzzzzzzzzzzzzzm_ = context.ResolveParameter("FunctionalStatusAssessmentsforHeartFailureFHIR-0.1.000", "Measurement Period", azzzzzzzzzzzzzzzzzzzzzzl_);

        return (CqlInterval<CqlDateTime>)azzzzzzzzzzzzzzzzzzzzzzm_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> azzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient azzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.SingletonFrom<Patient>(azzzzzzzzzzzzzzzzzzzzzzn_);

        return azzzzzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? azzzzzzzzzzzzzzzzzzzzzzp_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return azzzzzzzzzzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> azzzzzzzzzzzzzzzzzzzzzzq_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return azzzzzzzzzzzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? azzzzzzzzzzzzzzzzzzzzzzr_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return azzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode azzzzzzzzzzzzzzzzzzzzzzs_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return azzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        CqlValueSet azzzzzzzzzzzzzzzzzzzzzzt_ = this.Office_Visit(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet azzzzzzzzzzzzzzzzzzzzzzv_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Union<Encounter>(azzzzzzzzzzzzzzzzzzzzzzu_, azzzzzzzzzzzzzzzzzzzzzzw_);
        CqlValueSet azzzzzzzzzzzzzzzzzzzzzzy_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> azzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, azzzzzzzzzzzzzzzzzzzzzzy_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Union<Encounter>(azzzzzzzzzzzzzzzzzzzzzzx_, azzzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzb_ = Status_1_8_000.Instance.isEncounterPerformed(context, bzzzzzzzzzzzzzzzzzzzzzza_);
        bool? bzzzzzzzzzzzzzzzzzzzzzzc_(Encounter ValidEncounter)
        {
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzze_ = this.Measurement_Period(context);
            Period bzzzzzzzzzzzzzzzzzzzzzzf_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzzzzzzzzzzzzg_ as object);
            bool? bzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(bzzzzzzzzzzzzzzzzzzzzzze_, bzzzzzzzzzzzzzzzzzzzzzzh_, "day");

            return bzzzzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Encounter>(bzzzzzzzzzzzzzzzzzzzzzzb_, bzzzzzzzzzzzzzzzzzzzzzzc_);

        return bzzzzzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Two Outpatient Encounters during Measurement Period")]
    public IEnumerable<Encounter> Two_Outpatient_Encounters_during_Measurement_Period(CqlContext context)
    {
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzj_ = this.Qualifying_Encounters(context);
        IEnumerable<ValueTuple<Encounter, Encounter>> bzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.CrossJoin<Encounter, Encounter>(bzzzzzzzzzzzzzzzzzzzzzzj_, bzzzzzzzzzzzzzzzzzzzzzzj_);
        (CqlTupleMetadata, Encounter OfficeVisit1, Encounter OfficeVisit2)? bzzzzzzzzzzzzzzzzzzzzzzm_(ValueTuple<Encounter, Encounter> _valueTuple)
        {
            (CqlTupleMetadata, Encounter OfficeVisit1, Encounter OfficeVisit2)? bzzzzzzzzzzzzzzzzzzzzzzt_ = (CqlTupleMetadata_DbNMMZBTISSRTNdiShceSFVih, _valueTuple.Item1, _valueTuple.Item2);

            return bzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter OfficeVisit1, Encounter OfficeVisit2)?> bzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Select<ValueTuple<Encounter, Encounter>, (CqlTupleMetadata, Encounter OfficeVisit1, Encounter OfficeVisit2)?>(bzzzzzzzzzzzzzzzzzzzzzzl_, bzzzzzzzzzzzzzzzzzzzzzzm_);
        bool? bzzzzzzzzzzzzzzzzzzzzzzo_((CqlTupleMetadata, Encounter OfficeVisit1, Encounter OfficeVisit2)? tuple_dbnmmzbtissrtndishcesfvih)
        {
            Period bzzzzzzzzzzzzzzzzzzzzzzu_ = tuple_dbnmmzbtissrtndishcesfvih?.OfficeVisit2?.Period;
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzzzzzzzzzzzzv_ as object);
            CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzzzzw_);
            Period bzzzzzzzzzzzzzzzzzzzzzzy_ = tuple_dbnmmzbtissrtndishcesfvih?.OfficeVisit1?.Period;
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzzzzzzzzzzzzz_ as object);
            CqlDateTime czzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.End(czzzzzzzzzzzzzzzzzzzzzza_);
            CqlQuantity czzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Quantity(1m, "day");
            CqlDateTime czzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Add(czzzzzzzzzzzzzzzzzzzzzzb_, czzzzzzzzzzzzzzzzzzzzzzc_);
            bool? czzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.SameOrAfter(bzzzzzzzzzzzzzzzzzzzzzzx_, czzzzzzzzzzzzzzzzzzzzzzd_, "day");

            return czzzzzzzzzzzzzzzzzzzzzze_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter OfficeVisit1, Encounter OfficeVisit2)?> bzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<(CqlTupleMetadata, Encounter OfficeVisit1, Encounter OfficeVisit2)?>(bzzzzzzzzzzzzzzzzzzzzzzn_, bzzzzzzzzzzzzzzzzzzzzzzo_);
        Encounter bzzzzzzzzzzzzzzzzzzzzzzq_((CqlTupleMetadata, Encounter OfficeVisit1, Encounter OfficeVisit2)? tuple_dbnmmzbtissrtndishcesfvih) =>
            tuple_dbnmmzbtissrtndishcesfvih?.OfficeVisit1;
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Select<(CqlTupleMetadata, Encounter OfficeVisit1, Encounter OfficeVisit2)?, Encounter>(bzzzzzzzzzzzzzzzzzzzzzzp_, bzzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Distinct<Encounter>(bzzzzzzzzzzzzzzzzzzzzzzr_);

        return bzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient czzzzzzzzzzzzzzzzzzzzzzf_ = this.Patient(context);
        Date czzzzzzzzzzzzzzzzzzzzzzg_ = czzzzzzzzzzzzzzzzzzzzzzf_?.BirthDateElement;
        string czzzzzzzzzzzzzzzzzzzzzzh_ = czzzzzzzzzzzzzzzzzzzzzzg_?.Value;
        CqlDate czzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.ConvertStringToDate(czzzzzzzzzzzzzzzzzzzzzzh_);
        CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzj_ = this.Measurement_Period(context);
        CqlDateTime czzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Start(czzzzzzzzzzzzzzzzzzzzzzj_);
        CqlDate czzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.DateFrom(czzzzzzzzzzzzzzzzzzzzzzk_);
        int? czzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.CalculateAgeAt(czzzzzzzzzzzzzzzzzzzzzzi_, czzzzzzzzzzzzzzzzzzzzzzl_, "year");
        bool? czzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.GreaterOrEqual(czzzzzzzzzzzzzzzzzzzzzzm_, 18);
        CqlValueSet czzzzzzzzzzzzzzzzzzzzzzo_ = this.Heart_Failure(context);
        IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzzzzzo_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? czzzzzzzzzzzzzzzzzzzzzzq_(Condition HeartFailure)
        {
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HeartFailure);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzy_ = this.Measurement_Period(context);
            bool? czzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.OverlapsBefore(czzzzzzzzzzzzzzzzzzzzzzx_, czzzzzzzzzzzzzzzzzzzzzzy_, default);

            return czzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Condition> czzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<Condition>(czzzzzzzzzzzzzzzzzzzzzzp_, czzzzzzzzzzzzzzzzzzzzzzq_);
        bool? czzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Exists<Condition>(czzzzzzzzzzzzzzzzzzzzzzr_);
        bool? czzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzzzn_, czzzzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<Encounter> czzzzzzzzzzzzzzzzzzzzzzu_ = this.Two_Outpatient_Encounters_during_Measurement_Period(context);
        bool? czzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Exists<Encounter>(czzzzzzzzzzzzzzzzzzzzzzu_);
        bool? czzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzzzt_, czzzzzzzzzzzzzzzzzzzzzzv_);

        return czzzzzzzzzzzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? dzzzzzzzzzzzzzzzzzzzzzza_ = this.Initial_Population(context);

        return dzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? dzzzzzzzzzzzzzzzzzzzzzzb_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        CqlCode dzzzzzzzzzzzzzzzzzzzzzzc_ = this.Severe_cognitive_impairment__finding_(context);
        IEnumerable<CqlCode> dzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ToList<CqlCode>(dzzzzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<Condition> dzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, dzzzzzzzzzzzzzzzzzzzzzzd_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? dzzzzzzzzzzzzzzzzzzzzzzf_(Condition SevereCognitiveImpairment)
        {
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, SevereCognitiveImpairment);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzzzzzzzzzk_ = this.Measurement_Period(context);
            bool? dzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Overlaps(dzzzzzzzzzzzzzzzzzzzzzzj_, dzzzzzzzzzzzzzzzzzzzzzzk_, default);

            return dzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<Condition> dzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Condition>(dzzzzzzzzzzzzzzzzzzzzzze_, dzzzzzzzzzzzzzzzzzzzzzzf_);
        bool? dzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Exists<Condition>(dzzzzzzzzzzzzzzzzzzzzzzg_);
        bool? dzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Or(dzzzzzzzzzzzzzzzzzzzzzzb_, dzzzzzzzzzzzzzzzzzzzzzzh_);

        return dzzzzzzzzzzzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Date PROMIS10 Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_PROMIS10_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode dzzzzzzzzzzzzzzzzzzzzzzm_ = this.PROMIS_10_Global_Mental_Health__GMH__score_T_score(context);
        IEnumerable<CqlCode> dzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.ToList<CqlCode>(dzzzzzzzzzzzzzzzzzzzzzzm_);
        IEnumerable<Observation> dzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, dzzzzzzzzzzzzzzzzzzzzzzn_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> dzzzzzzzzzzzzzzzzzzzzzzp_ = Status_1_8_000.Instance.isAssessmentPerformed(context, dzzzzzzzzzzzzzzzzzzzzzzo_);
        CqlCode dzzzzzzzzzzzzzzzzzzzzzzq_ = this.PROMIS_10_Global_Physical_Health__GPH__score_T_score(context);
        IEnumerable<CqlCode> dzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ToList<CqlCode>(dzzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<Observation> dzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, dzzzzzzzzzzzzzzzzzzzzzzr_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> dzzzzzzzzzzzzzzzzzzzzzzt_ = Status_1_8_000.Instance.isAssessmentPerformed(context, dzzzzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<ValueTuple<Observation, Observation>> dzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.CrossJoin<Observation, Observation>(dzzzzzzzzzzzzzzzzzzzzzzp_, dzzzzzzzzzzzzzzzzzzzzzzt_);
        (CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)? dzzzzzzzzzzzzzzzzzzzzzzv_(ValueTuple<Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)? ezzzzzzzzzzzzzzzzzzzzzzc_ = (CqlTupleMetadata_DDTAOdcFieSJbGgRLLZPYbGQb, _valueTuple.Item1, _valueTuple.Item2);

            return ezzzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<(CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?> dzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Select<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?>(dzzzzzzzzzzzzzzzzzzzzzzu_, dzzzzzzzzzzzzzzzzzzzzzzv_);
        bool? dzzzzzzzzzzzzzzzzzzzzzzx_((CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)? tuple_ddtaodcfiesjbggrllzpybgqb)
        {
            DataType ezzzzzzzzzzzzzzzzzzzzzzd_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10MentalScore?.Effective;
            object ezzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, ezzzzzzzzzzzzzzzzzzzzzze_);
            CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzzzzzzf_);
            CqlDate ezzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.DateFrom(ezzzzzzzzzzzzzzzzzzzzzzg_);
            DataType ezzzzzzzzzzzzzzzzzzzzzzi_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10PhysicalScore?.Effective;
            object ezzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.toInterval(context, ezzzzzzzzzzzzzzzzzzzzzzj_);
            CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzzzzzzk_);
            CqlDate ezzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.DateFrom(ezzzzzzzzzzzzzzzzzzzzzzl_);
            bool? ezzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.SameAs(ezzzzzzzzzzzzzzzzzzzzzzh_, ezzzzzzzzzzzzzzzzzzzzzzm_, "day");
            DataType ezzzzzzzzzzzzzzzzzzzzzzo_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10MentalScore?.Value;
            object ezzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzo_);
            bool? ezzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Not((bool?)(ezzzzzzzzzzzzzzzzzzzzzzp_ is null));
            bool? ezzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(ezzzzzzzzzzzzzzzzzzzzzzn_, ezzzzzzzzzzzzzzzzzzzzzzq_);
            DataType ezzzzzzzzzzzzzzzzzzzzzzs_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10PhysicalScore?.Value;
            object ezzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzs_);
            bool? ezzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Not((bool?)(ezzzzzzzzzzzzzzzzzzzzzzt_ is null));
            bool? ezzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(ezzzzzzzzzzzzzzzzzzzzzzr_, ezzzzzzzzzzzzzzzzzzzzzzu_);

            return ezzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<(CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?> dzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<(CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?>(dzzzzzzzzzzzzzzzzzzzzzzw_, dzzzzzzzzzzzzzzzzzzzzzzx_);
        CqlDate dzzzzzzzzzzzzzzzzzzzzzzz_((CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)? tuple_ddtaodcfiesjbggrllzpybgqb)
        {
            DataType ezzzzzzzzzzzzzzzzzzzzzzw_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10MentalScore?.Effective;
            object ezzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.toInterval(context, ezzzzzzzzzzzzzzzzzzzzzzx_);
            CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzzzzzzy_);
            CqlDate fzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.DateFrom(ezzzzzzzzzzzzzzzzzzzzzzz_);

            return fzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<CqlDate> ezzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Select<(CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?, CqlDate>(dzzzzzzzzzzzzzzzzzzzzzzy_, dzzzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<CqlDate> ezzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Distinct<CqlDate>(ezzzzzzzzzzzzzzzzzzzzzza_);

        return ezzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Has Encounter with Initial and Follow Up PROMIS10 Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_PROMIS10_Assessments(CqlContext context)
    {
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzb_ = this.Qualifying_Encounters(context);
        IEnumerable<CqlDate> fzzzzzzzzzzzzzzzzzzzzzzc_ = this.Date_PROMIS10_Total_Assessment_Completed(context);
        IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> fzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(fzzzzzzzzzzzzzzzzzzzzzzb_, fzzzzzzzzzzzzzzzzzzzzzzc_, fzzzzzzzzzzzzzzzzzzzzzzc_);
        (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS10Date, CqlDate FollowupPROMIS10Date)? fzzzzzzzzzzzzzzzzzzzzzzf_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS10Date, CqlDate FollowupPROMIS10Date)? fzzzzzzzzzzzzzzzzzzzzzzn_ = (CqlTupleMetadata_BGYjYGLNPKWAZTBCVAdLDDTMj, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return fzzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS10Date, CqlDate FollowupPROMIS10Date)?> fzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS10Date, CqlDate FollowupPROMIS10Date)?>(fzzzzzzzzzzzzzzzzzzzzzze_, fzzzzzzzzzzzzzzzzzzzzzzf_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzh_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS10Date, CqlDate FollowupPROMIS10Date)? tuple_dzhwgxhmbfavmzfaszbeksohj)
        {
            Period fzzzzzzzzzzzzzzzzzzzzzzo_ = tuple_dzhwgxhmbfavmzfaszbeksohj?.ValidEncounters?.Period;
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.toInterval(context, fzzzzzzzzzzzzzzzzzzzzzzp_ as object);
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.End(fzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzs_ = this.Measurement_Period(context);
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.End(fzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlQuantity fzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Quantity(180m, "days");
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Subtract(fzzzzzzzzzzzzzzzzzzzzzzt_, fzzzzzzzzzzzzzzzzzzzzzzu_);
            bool? fzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.SameOrBefore(fzzzzzzzzzzzzzzzzzzzzzzr_, fzzzzzzzzzzzzzzzzzzzzzzv_, "day");
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.ConvertDateToDateTime(tuple_dzhwgxhmbfavmzfaszbeksohj?.InitialPROMIS10Date);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, fzzzzzzzzzzzzzzzzzzzzzzz_ as object);
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.End(gzzzzzzzzzzzzzzzzzzzzzza_);
            CqlQuantity gzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Quantity(14m, "days");
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Subtract(gzzzzzzzzzzzzzzzzzzzzzzb_, gzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzzzzzzzzzzzzzzf_ as object);
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.End(gzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Interval(gzzzzzzzzzzzzzzzzzzzzzzd_, gzzzzzzzzzzzzzzzzzzzzzzh_, true, true);
            bool? gzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.In<CqlDateTime>(fzzzzzzzzzzzzzzzzzzzzzzx_, gzzzzzzzzzzzzzzzzzzzzzzi_, "day");
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzzzzzzzzzzzzzzl_ as object);
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.End(gzzzzzzzzzzzzzzzzzzzzzzm_);
            bool? gzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Not((bool?)(gzzzzzzzzzzzzzzzzzzzzzzn_ is null));
            bool? gzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzzj_, gzzzzzzzzzzzzzzzzzzzzzzo_);
            bool? gzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzw_, gzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ConvertDateToDateTime(tuple_dzhwgxhmbfavmzfaszbeksohj?.FollowupPROMIS10Date);
            CqlDate gzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.DateFrom(gzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlDate gzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.DateFrom(fzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlQuantity gzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Quantity(30m, "days");
            CqlDate gzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Add(gzzzzzzzzzzzzzzzzzzzzzzu_, gzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlDate gzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.DateFrom(fzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlDate hzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Add(gzzzzzzzzzzzzzzzzzzzzzzy_, fzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDate> hzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Interval(gzzzzzzzzzzzzzzzzzzzzzzw_, hzzzzzzzzzzzzzzzzzzzzzza_, true, true);
            bool? hzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.In<CqlDate>(gzzzzzzzzzzzzzzzzzzzzzzs_, hzzzzzzzzzzzzzzzzzzzzzzb_, "day");
            bool? hzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzzq_, hzzzzzzzzzzzzzzzzzzzzzzc_);

            return hzzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS10Date, CqlDate FollowupPROMIS10Date)?> fzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS10Date, CqlDate FollowupPROMIS10Date)?>(fzzzzzzzzzzzzzzzzzzzzzzg_, fzzzzzzzzzzzzzzzzzzzzzzh_);
        Encounter fzzzzzzzzzzzzzzzzzzzzzzj_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS10Date, CqlDate FollowupPROMIS10Date)? tuple_dzhwgxhmbfavmzfaszbeksohj) =>
            tuple_dzhwgxhmbfavmzfaszbeksohj?.ValidEncounters;
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Select<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS10Date, CqlDate FollowupPROMIS10Date)?, Encounter>(fzzzzzzzzzzzzzzzzzzzzzzi_, fzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Distinct<Encounter>(fzzzzzzzzzzzzzzzzzzzzzzk_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Exists<Encounter>(fzzzzzzzzzzzzzzzzzzzzzzl_);

        return fzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Date PROMIS29 Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_PROMIS29_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode hzzzzzzzzzzzzzzzzzzzzzze_ = this.PROMIS_29_Sleep_disturbance_score_T_score(context);
        IEnumerable<CqlCode> hzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.ToList<CqlCode>(hzzzzzzzzzzzzzzzzzzzzzze_);
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, hzzzzzzzzzzzzzzzzzzzzzzf_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzh_ = Status_1_8_000.Instance.isAssessmentPerformed(context, hzzzzzzzzzzzzzzzzzzzzzzg_);
        CqlCode hzzzzzzzzzzzzzzzzzzzzzzi_ = this.PROMIS_29_Satisfaction_with_participation_in_social_roles_score_T_score(context);
        IEnumerable<CqlCode> hzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.ToList<CqlCode>(hzzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, hzzzzzzzzzzzzzzzzzzzzzzj_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzl_ = Status_1_8_000.Instance.isAssessmentPerformed(context, hzzzzzzzzzzzzzzzzzzzzzzk_);
        CqlCode hzzzzzzzzzzzzzzzzzzzzzzm_ = this.PROMIS_29_Physical_function_score_T_score(context);
        IEnumerable<CqlCode> hzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.ToList<CqlCode>(hzzzzzzzzzzzzzzzzzzzzzzm_);
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, hzzzzzzzzzzzzzzzzzzzzzzn_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzp_ = Status_1_8_000.Instance.isAssessmentPerformed(context, hzzzzzzzzzzzzzzzzzzzzzzo_);
        CqlCode hzzzzzzzzzzzzzzzzzzzzzzq_ = this.PROMIS_29_Pain_interference_score_T_score(context);
        IEnumerable<CqlCode> hzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ToList<CqlCode>(hzzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, hzzzzzzzzzzzzzzzzzzzzzzr_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzt_ = Status_1_8_000.Instance.isAssessmentPerformed(context, hzzzzzzzzzzzzzzzzzzzzzzs_);
        CqlCode hzzzzzzzzzzzzzzzzzzzzzzu_ = this.PROMIS_29_Fatigue_score_T_score(context);
        IEnumerable<CqlCode> hzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.ToList<CqlCode>(hzzzzzzzzzzzzzzzzzzzzzzu_);
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, hzzzzzzzzzzzzzzzzzzzzzzv_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzx_ = Status_1_8_000.Instance.isAssessmentPerformed(context, hzzzzzzzzzzzzzzzzzzzzzzw_);
        CqlCode hzzzzzzzzzzzzzzzzzzzzzzy_ = this.PROMIS_29_Depression_score_T_score(context);
        IEnumerable<CqlCode> hzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.ToList<CqlCode>(hzzzzzzzzzzzzzzzzzzzzzzy_);
        IEnumerable<Observation> izzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, hzzzzzzzzzzzzzzzzzzzzzzz_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> izzzzzzzzzzzzzzzzzzzzzzb_ = Status_1_8_000.Instance.isAssessmentPerformed(context, izzzzzzzzzzzzzzzzzzzzzza_);
        CqlCode izzzzzzzzzzzzzzzzzzzzzzc_ = this.PROMIS_29_Anxiety_score_T_score(context);
        IEnumerable<CqlCode> izzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ToList<CqlCode>(izzzzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<Observation> izzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, izzzzzzzzzzzzzzzzzzzzzzd_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> izzzzzzzzzzzzzzzzzzzzzzf_ = Status_1_8_000.Instance.isAssessmentPerformed(context, izzzzzzzzzzzzzzzzzzzzzze_);
        IEnumerable<ValueTuple<Observation, Observation, Observation, Observation, Observation, Observation, Observation>> izzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.CrossJoin<Observation, Observation, Observation, Observation, Observation, Observation, Observation>(hzzzzzzzzzzzzzzzzzzzzzzh_, hzzzzzzzzzzzzzzzzzzzzzzl_, hzzzzzzzzzzzzzzzzzzzzzzp_, hzzzzzzzzzzzzzzzzzzzzzzt_, hzzzzzzzzzzzzzzzzzzzzzzx_, izzzzzzzzzzzzzzzzzzzzzzb_, izzzzzzzzzzzzzzzzzzzzzzf_);
        (CqlTupleMetadata, Observation Promis29Sleep, Observation Promis29SocialRoles, Observation Promis29Physical, Observation Promis29Pain, Observation Promis29Fatigue, Observation Promis29Depression, Observation Promis29Anxiety)? izzzzzzzzzzzzzzzzzzzzzzh_(ValueTuple<Observation, Observation, Observation, Observation, Observation, Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation Promis29Sleep, Observation Promis29SocialRoles, Observation Promis29Physical, Observation Promis29Pain, Observation Promis29Fatigue, Observation Promis29Depression, Observation Promis29Anxiety)? izzzzzzzzzzzzzzzzzzzzzzo_ = (CqlTupleMetadata_DBUJFOVGBcbhIQPWARNQHKUaX, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3, _valueTuple.Item4, _valueTuple.Item5, _valueTuple.Item6, _valueTuple.Item7);

            return izzzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<(CqlTupleMetadata, Observation Promis29Sleep, Observation Promis29SocialRoles, Observation Promis29Physical, Observation Promis29Pain, Observation Promis29Fatigue, Observation Promis29Depression, Observation Promis29Anxiety)?> izzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Select<ValueTuple<Observation, Observation, Observation, Observation, Observation, Observation, Observation>, (CqlTupleMetadata, Observation Promis29Sleep, Observation Promis29SocialRoles, Observation Promis29Physical, Observation Promis29Pain, Observation Promis29Fatigue, Observation Promis29Depression, Observation Promis29Anxiety)?>(izzzzzzzzzzzzzzzzzzzzzzg_, izzzzzzzzzzzzzzzzzzzzzzh_);
        bool? izzzzzzzzzzzzzzzzzzzzzzj_((CqlTupleMetadata, Observation Promis29Sleep, Observation Promis29SocialRoles, Observation Promis29Physical, Observation Promis29Pain, Observation Promis29Fatigue, Observation Promis29Depression, Observation Promis29Anxiety)? tuple_cbgpsarvwrsewlglehinjanim)
        {
            DataType izzzzzzzzzzzzzzzzzzzzzzp_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Sleep?.Effective;
            object izzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, izzzzzzzzzzzzzzzzzzzzzzq_);
            CqlDateTime izzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(izzzzzzzzzzzzzzzzzzzzzzr_);
            CqlDate izzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.DateFrom(izzzzzzzzzzzzzzzzzzzzzzs_);
            DataType izzzzzzzzzzzzzzzzzzzzzzu_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29SocialRoles?.Effective;
            object izzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.toInterval(context, izzzzzzzzzzzzzzzzzzzzzzv_);
            CqlDateTime izzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(izzzzzzzzzzzzzzzzzzzzzzw_);
            CqlDate izzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.DateFrom(izzzzzzzzzzzzzzzzzzzzzzx_);
            bool? izzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.SameAs(izzzzzzzzzzzzzzzzzzzzzzt_, izzzzzzzzzzzzzzzzzzzzzzy_, "day");
            DataType jzzzzzzzzzzzzzzzzzzzzzza_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29SocialRoles?.Value;
            object jzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzza_);
            bool? jzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Not((bool?)(jzzzzzzzzzzzzzzzzzzzzzzb_ is null));
            bool? jzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzz_, jzzzzzzzzzzzzzzzzzzzzzzc_);
            object jzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.toInterval(context, jzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Start(jzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlDate jzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.DateFrom(jzzzzzzzzzzzzzzzzzzzzzzh_);
            DataType jzzzzzzzzzzzzzzzzzzzzzzj_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Physical?.Effective;
            object jzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, jzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(jzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlDate jzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.DateFrom(jzzzzzzzzzzzzzzzzzzzzzzm_);
            bool? jzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.SameAs(jzzzzzzzzzzzzzzzzzzzzzzi_, jzzzzzzzzzzzzzzzzzzzzzzn_, "day");
            bool? jzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzzzd_, jzzzzzzzzzzzzzzzzzzzzzzo_);
            DataType jzzzzzzzzzzzzzzzzzzzzzzq_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Physical?.Value;
            object jzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzq_);
            bool? jzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Not((bool?)(jzzzzzzzzzzzzzzzzzzzzzzr_ is null));
            bool? jzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzzzp_, jzzzzzzzzzzzzzzzzzzzzzzs_);
            object jzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.toInterval(context, jzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(jzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlDate jzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.DateFrom(jzzzzzzzzzzzzzzzzzzzzzzx_);
            DataType jzzzzzzzzzzzzzzzzzzzzzzz_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Pain?.Effective;
            object kzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzzzzzzzzzzza_);
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlDate kzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.DateFrom(kzzzzzzzzzzzzzzzzzzzzzzc_);
            bool? kzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.SameAs(jzzzzzzzzzzzzzzzzzzzzzzy_, kzzzzzzzzzzzzzzzzzzzzzzd_, "day");
            bool? kzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzzzt_, kzzzzzzzzzzzzzzzzzzzzzze_);
            DataType kzzzzzzzzzzzzzzzzzzzzzzg_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Pain?.Value;
            object kzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzg_);
            bool? kzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Not((bool?)(kzzzzzzzzzzzzzzzzzzzzzzh_ is null));
            bool? kzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzf_, kzzzzzzzzzzzzzzzzzzzzzzi_);
            object kzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlDate kzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.DateFrom(kzzzzzzzzzzzzzzzzzzzzzzn_);
            DataType kzzzzzzzzzzzzzzzzzzzzzzp_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Fatigue?.Effective;
            object kzzzzzzzzzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(kzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlDate kzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.DateFrom(kzzzzzzzzzzzzzzzzzzzzzzs_);
            bool? kzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.SameAs(kzzzzzzzzzzzzzzzzzzzzzzo_, kzzzzzzzzzzzzzzzzzzzzzzt_, "day");
            bool? kzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzj_, kzzzzzzzzzzzzzzzzzzzzzzu_);
            DataType kzzzzzzzzzzzzzzzzzzzzzzw_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Fatigue?.Value;
            object kzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzzzzzzzzzzzzw_);
            bool? kzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Not((bool?)(kzzzzzzzzzzzzzzzzzzzzzzx_ is null));
            bool? kzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzv_, kzzzzzzzzzzzzzzzzzzzzzzy_);
            object lzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, lzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlDate lzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.DateFrom(lzzzzzzzzzzzzzzzzzzzzzzd_);
            DataType lzzzzzzzzzzzzzzzzzzzzzzf_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Depression?.Effective;
            object lzzzzzzzzzzzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.toInterval(context, lzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlDate lzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.DateFrom(lzzzzzzzzzzzzzzzzzzzzzzi_);
            bool? lzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.SameAs(lzzzzzzzzzzzzzzzzzzzzzze_, lzzzzzzzzzzzzzzzzzzzzzzj_, "day");
            bool? lzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzz_, lzzzzzzzzzzzzzzzzzzzzzzk_);
            DataType lzzzzzzzzzzzzzzzzzzzzzzm_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Depression?.Value;
            object lzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzm_);
            bool? lzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Not((bool?)(lzzzzzzzzzzzzzzzzzzzzzzn_ is null));
            bool? lzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzl_, lzzzzzzzzzzzzzzzzzzzzzzo_);
            object lzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.toInterval(context, lzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlDate lzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.DateFrom(lzzzzzzzzzzzzzzzzzzzzzzt_);
            DataType lzzzzzzzzzzzzzzzzzzzzzzv_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Anxiety?.Effective;
            object lzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.toInterval(context, lzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlDateTime lzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(lzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlDate lzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.DateFrom(lzzzzzzzzzzzzzzzzzzzzzzy_);
            bool? mzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.SameAs(lzzzzzzzzzzzzzzzzzzzzzzu_, lzzzzzzzzzzzzzzzzzzzzzzz_, "day");
            bool? mzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(lzzzzzzzzzzzzzzzzzzzzzzp_, mzzzzzzzzzzzzzzzzzzzzzza_);
            DataType mzzzzzzzzzzzzzzzzzzzzzzc_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Anxiety?.Value;
            object mzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzc_);
            bool? mzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Not((bool?)(mzzzzzzzzzzzzzzzzzzzzzzd_ is null));
            bool? mzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzzzb_, mzzzzzzzzzzzzzzzzzzzzzze_);
            DataType mzzzzzzzzzzzzzzzzzzzzzzg_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Sleep?.Value;
            object mzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzg_);
            bool? mzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Not((bool?)(mzzzzzzzzzzzzzzzzzzzzzzh_ is null));
            bool? mzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzzzf_, mzzzzzzzzzzzzzzzzzzzzzzi_);

            return mzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<(CqlTupleMetadata, Observation Promis29Sleep, Observation Promis29SocialRoles, Observation Promis29Physical, Observation Promis29Pain, Observation Promis29Fatigue, Observation Promis29Depression, Observation Promis29Anxiety)?> izzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<(CqlTupleMetadata, Observation Promis29Sleep, Observation Promis29SocialRoles, Observation Promis29Physical, Observation Promis29Pain, Observation Promis29Fatigue, Observation Promis29Depression, Observation Promis29Anxiety)?>(izzzzzzzzzzzzzzzzzzzzzzi_, izzzzzzzzzzzzzzzzzzzzzzj_);
        CqlDate izzzzzzzzzzzzzzzzzzzzzzl_((CqlTupleMetadata, Observation Promis29Sleep, Observation Promis29SocialRoles, Observation Promis29Physical, Observation Promis29Pain, Observation Promis29Fatigue, Observation Promis29Depression, Observation Promis29Anxiety)? tuple_cbgpsarvwrsewlglehinjanim)
        {
            DataType mzzzzzzzzzzzzzzzzzzzzzzk_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Sleep?.Effective;
            object mzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.toInterval(context, mzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlDate mzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.DateFrom(mzzzzzzzzzzzzzzzzzzzzzzn_);

            return mzzzzzzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<CqlDate> izzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Select<(CqlTupleMetadata, Observation Promis29Sleep, Observation Promis29SocialRoles, Observation Promis29Physical, Observation Promis29Pain, Observation Promis29Fatigue, Observation Promis29Depression, Observation Promis29Anxiety)?, CqlDate>(izzzzzzzzzzzzzzzzzzzzzzk_, izzzzzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<CqlDate> izzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Distinct<CqlDate>(izzzzzzzzzzzzzzzzzzzzzzm_);

        return izzzzzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Has Encounter with Initial and Follow Up PROMIS29 Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_PROMIS29_Assessments(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzp_ = this.Qualifying_Encounters(context);
        IEnumerable<CqlDate> mzzzzzzzzzzzzzzzzzzzzzzq_ = this.Date_PROMIS29_Total_Assessment_Completed(context);
        IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> mzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(mzzzzzzzzzzzzzzzzzzzzzzp_, mzzzzzzzzzzzzzzzzzzzzzzq_, mzzzzzzzzzzzzzzzzzzzzzzq_);
        (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS29Date, CqlDate FollowupPROMIS29Date)? mzzzzzzzzzzzzzzzzzzzzzzt_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS29Date, CqlDate FollowupPROMIS29Date)? nzzzzzzzzzzzzzzzzzzzzzzb_ = (CqlTupleMetadata_DSZKEYVbCINNIeAQiZdVaEJhG, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return nzzzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS29Date, CqlDate FollowupPROMIS29Date)?> mzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS29Date, CqlDate FollowupPROMIS29Date)?>(mzzzzzzzzzzzzzzzzzzzzzzs_, mzzzzzzzzzzzzzzzzzzzzzzt_);
        bool? mzzzzzzzzzzzzzzzzzzzzzzv_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS29Date, CqlDate FollowupPROMIS29Date)? tuple_kmpntxjuhkpbcwgftqigieao)
        {
            Period nzzzzzzzzzzzzzzzzzzzzzzc_ = tuple_kmpntxjuhkpbcwgftqigieao?.ValidEncounters?.Period;
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzzzzzzzzzzzzzzd_ as object);
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.End(nzzzzzzzzzzzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzg_ = this.Measurement_Period(context);
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.End(nzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlQuantity nzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Quantity(180m, "days");
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Subtract(nzzzzzzzzzzzzzzzzzzzzzzh_, nzzzzzzzzzzzzzzzzzzzzzzi_);
            bool? nzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.SameOrBefore(nzzzzzzzzzzzzzzzzzzzzzzf_, nzzzzzzzzzzzzzzzzzzzzzzj_, "day");
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.ConvertDateToDateTime(tuple_kmpntxjuhkpbcwgftqigieao?.InitialPROMIS29Date);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzzzzzzzzzzzzzzn_ as object);
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.End(nzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlQuantity nzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Quantity(14m, "days");
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Subtract(nzzzzzzzzzzzzzzzzzzzzzzp_, nzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzzzzzzzzzzzzzzt_ as object);
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.End(nzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Interval(nzzzzzzzzzzzzzzzzzzzzzzr_, nzzzzzzzzzzzzzzzzzzzzzzv_, true, true);
            bool? nzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.In<CqlDateTime>(nzzzzzzzzzzzzzzzzzzzzzzl_, nzzzzzzzzzzzzzzzzzzzzzzw_, "day");
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzzzzzzzzzzzzzzz_ as object);
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.End(ozzzzzzzzzzzzzzzzzzzzzza_);
            bool? ozzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Not((bool?)(ozzzzzzzzzzzzzzzzzzzzzzb_ is null));
            bool? ozzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzx_, ozzzzzzzzzzzzzzzzzzzzzzc_);
            bool? ozzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzk_, ozzzzzzzzzzzzzzzzzzzzzzd_);
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.ConvertDateToDateTime(tuple_kmpntxjuhkpbcwgftqigieao?.FollowupPROMIS29Date);
            CqlDate ozzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.DateFrom(ozzzzzzzzzzzzzzzzzzzzzzf_);
            CqlDate ozzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.DateFrom(nzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlQuantity ozzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Quantity(30m, "days");
            CqlDate ozzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Add(ozzzzzzzzzzzzzzzzzzzzzzi_, ozzzzzzzzzzzzzzzzzzzzzzj_);
            CqlDate ozzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.DateFrom(nzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlDate ozzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Add(ozzzzzzzzzzzzzzzzzzzzzzm_, nzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDate> ozzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Interval(ozzzzzzzzzzzzzzzzzzzzzzk_, ozzzzzzzzzzzzzzzzzzzzzzo_, true, true);
            bool? ozzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.In<CqlDate>(ozzzzzzzzzzzzzzzzzzzzzzg_, ozzzzzzzzzzzzzzzzzzzzzzp_, "day");
            bool? ozzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzze_, ozzzzzzzzzzzzzzzzzzzzzzq_);

            return ozzzzzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS29Date, CqlDate FollowupPROMIS29Date)?> mzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS29Date, CqlDate FollowupPROMIS29Date)?>(mzzzzzzzzzzzzzzzzzzzzzzu_, mzzzzzzzzzzzzzzzzzzzzzzv_);
        Encounter mzzzzzzzzzzzzzzzzzzzzzzx_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS29Date, CqlDate FollowupPROMIS29Date)? tuple_kmpntxjuhkpbcwgftqigieao) =>
            tuple_kmpntxjuhkpbcwgftqigieao?.ValidEncounters;
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Select<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS29Date, CqlDate FollowupPROMIS29Date)?, Encounter>(mzzzzzzzzzzzzzzzzzzzzzzw_, mzzzzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<Encounter> mzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Distinct<Encounter>(mzzzzzzzzzzzzzzzzzzzzzzy_);
        bool? nzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Exists<Encounter>(mzzzzzzzzzzzzzzzzzzzzzzz_);

        return nzzzzzzzzzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Date VR12 Oblique Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_VR12_Oblique_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode ozzzzzzzzzzzzzzzzzzzzzzs_ = this.VR_12_Mental_component_summary__MCS__score___oblique_method_T_score(context);
        IEnumerable<CqlCode> ozzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.ToList<CqlCode>(ozzzzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<Observation> ozzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, ozzzzzzzzzzzzzzzzzzzzzzt_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> ozzzzzzzzzzzzzzzzzzzzzzv_ = Status_1_8_000.Instance.isAssessmentPerformed(context, ozzzzzzzzzzzzzzzzzzzzzzu_);
        CqlCode ozzzzzzzzzzzzzzzzzzzzzzw_ = this.VR_12_Physical_component_summary__PCS__score___oblique_method_T_score(context);
        IEnumerable<CqlCode> ozzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.ToList<CqlCode>(ozzzzzzzzzzzzzzzzzzzzzzw_);
        IEnumerable<Observation> ozzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, ozzzzzzzzzzzzzzzzzzzzzzx_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> ozzzzzzzzzzzzzzzzzzzzzzz_ = Status_1_8_000.Instance.isAssessmentPerformed(context, ozzzzzzzzzzzzzzzzzzzzzzy_);
        IEnumerable<ValueTuple<Observation, Observation>> pzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.CrossJoin<Observation, Observation>(ozzzzzzzzzzzzzzzzzzzzzzv_, ozzzzzzzzzzzzzzzzzzzzzzz_);
        (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? pzzzzzzzzzzzzzzzzzzzzzzb_(ValueTuple<Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? pzzzzzzzzzzzzzzzzzzzzzzi_ = (CqlTupleMetadata_GAdRFKRaHUUGJcVHWQWRUjhRH, _valueTuple.Item1, _valueTuple.Item2);

            return pzzzzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?> pzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Select<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?>(pzzzzzzzzzzzzzzzzzzzzzza_, pzzzzzzzzzzzzzzzzzzzzzzb_);
        bool? pzzzzzzzzzzzzzzzzzzzzzzd_((CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? tuple_gadrfkrahuugjcvhwqwrujhrh)
        {
            DataType pzzzzzzzzzzzzzzzzzzzzzzj_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Effective;
            object pzzzzzzzzzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, pzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Start(pzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlDate pzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.DateFrom(pzzzzzzzzzzzzzzzzzzzzzzm_);
            DataType pzzzzzzzzzzzzzzzzzzzzzzo_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Effective;
            object pzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.toInterval(context, pzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Start(pzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlDate pzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.DateFrom(pzzzzzzzzzzzzzzzzzzzzzzr_);
            bool? pzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.SameAs(pzzzzzzzzzzzzzzzzzzzzzzn_, pzzzzzzzzzzzzzzzzzzzzzzs_, "day");
            DataType pzzzzzzzzzzzzzzzzzzzzzzu_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Value;
            object pzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzu_);
            bool? pzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Not((bool?)(pzzzzzzzzzzzzzzzzzzzzzzv_ is null));
            bool? pzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzzt_, pzzzzzzzzzzzzzzzzzzzzzzw_);
            DataType pzzzzzzzzzzzzzzzzzzzzzzy_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Value;
            object pzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzy_);
            bool? qzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Not((bool?)(pzzzzzzzzzzzzzzzzzzzzzzz_ is null));
            bool? qzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzzx_, qzzzzzzzzzzzzzzzzzzzzzza_);

            return qzzzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?> pzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?>(pzzzzzzzzzzzzzzzzzzzzzzc_, pzzzzzzzzzzzzzzzzzzzzzzd_);
        CqlDate pzzzzzzzzzzzzzzzzzzzzzzf_((CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? tuple_gadrfkrahuugjcvhwqwrujhrh)
        {
            DataType qzzzzzzzzzzzzzzzzzzzzzzc_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Effective;
            object qzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.toInterval(context, qzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(qzzzzzzzzzzzzzzzzzzzzzze_);
            CqlDate qzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.DateFrom(qzzzzzzzzzzzzzzzzzzzzzzf_);

            return qzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<CqlDate> pzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Select<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?, CqlDate>(pzzzzzzzzzzzzzzzzzzzzzze_, pzzzzzzzzzzzzzzzzzzzzzzf_);
        IEnumerable<CqlDate> pzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Distinct<CqlDate>(pzzzzzzzzzzzzzzzzzzzzzzg_);

        return pzzzzzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Has Encounter with Initial and Follow Up VR12 Oblique Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_VR12_Oblique_Assessments(CqlContext context)
    {
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzh_ = this.Qualifying_Encounters(context);
        IEnumerable<CqlDate> qzzzzzzzzzzzzzzzzzzzzzzi_ = this.Date_VR12_Oblique_Total_Assessment_Completed(context);
        IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> qzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(qzzzzzzzzzzzzzzzzzzzzzzh_, qzzzzzzzzzzzzzzzzzzzzzzi_, qzzzzzzzzzzzzzzzzzzzzzzi_);
        (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12ObliqueDate, CqlDate FollowupVR12ObliqueDate)? qzzzzzzzzzzzzzzzzzzzzzzl_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12ObliqueDate, CqlDate FollowupVR12ObliqueDate)? qzzzzzzzzzzzzzzzzzzzzzzt_ = (CqlTupleMetadata_FQKGdEYLiDFGMNAUAMETIHUQT, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return qzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12ObliqueDate, CqlDate FollowupVR12ObliqueDate)?> qzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12ObliqueDate, CqlDate FollowupVR12ObliqueDate)?>(qzzzzzzzzzzzzzzzzzzzzzzk_, qzzzzzzzzzzzzzzzzzzzzzzl_);
        bool? qzzzzzzzzzzzzzzzzzzzzzzn_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12ObliqueDate, CqlDate FollowupVR12ObliqueDate)? tuple_fppktdiagiekhptnsbacpswh)
        {
            Period qzzzzzzzzzzzzzzzzzzzzzzu_ = tuple_fppktdiagiekhptnsbacpswh?.ValidEncounters?.Period;
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.toInterval(context, qzzzzzzzzzzzzzzzzzzzzzzv_ as object);
            CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.End(qzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzy_ = this.Measurement_Period(context);
            CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.End(qzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlQuantity rzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Quantity(180m, "days");
            CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Subtract(qzzzzzzzzzzzzzzzzzzzzzzz_, rzzzzzzzzzzzzzzzzzzzzzza_);
            bool? rzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.SameOrBefore(qzzzzzzzzzzzzzzzzzzzzzzx_, rzzzzzzzzzzzzzzzzzzzzzzb_, "day");
            CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ConvertDateToDateTime(tuple_fppktdiagiekhptnsbacpswh?.InitialVR12ObliqueDate);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.toInterval(context, rzzzzzzzzzzzzzzzzzzzzzzf_ as object);
            CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.End(rzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlQuantity rzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Quantity(14m, "days");
            CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Subtract(rzzzzzzzzzzzzzzzzzzzzzzh_, rzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.toInterval(context, rzzzzzzzzzzzzzzzzzzzzzzl_ as object);
            CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.End(rzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Interval(rzzzzzzzzzzzzzzzzzzzzzzj_, rzzzzzzzzzzzzzzzzzzzzzzn_, true, true);
            bool? rzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.In<CqlDateTime>(rzzzzzzzzzzzzzzzzzzzzzzd_, rzzzzzzzzzzzzzzzzzzzzzzo_, "day");
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.toInterval(context, rzzzzzzzzzzzzzzzzzzzzzzr_ as object);
            CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.End(rzzzzzzzzzzzzzzzzzzzzzzs_);
            bool? rzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Not((bool?)(rzzzzzzzzzzzzzzzzzzzzzzt_ is null));
            bool? rzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzzzp_, rzzzzzzzzzzzzzzzzzzzzzzu_);
            bool? rzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzzzc_, rzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.ConvertDateToDateTime(tuple_fppktdiagiekhptnsbacpswh?.FollowupVR12ObliqueDate);
            CqlDate rzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.DateFrom(rzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlDate szzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.DateFrom(rzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlQuantity szzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Quantity(30m, "days");
            CqlDate szzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Add(szzzzzzzzzzzzzzzzzzzzzza_, szzzzzzzzzzzzzzzzzzzzzzb_);
            CqlDate szzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.DateFrom(rzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlDate szzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Add(szzzzzzzzzzzzzzzzzzzzzze_, rzzzzzzzzzzzzzzzzzzzzzza_);
            CqlInterval<CqlDate> szzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Interval(szzzzzzzzzzzzzzzzzzzzzzc_, szzzzzzzzzzzzzzzzzzzzzzg_, true, true);
            bool? szzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.In<CqlDate>(rzzzzzzzzzzzzzzzzzzzzzzy_, szzzzzzzzzzzzzzzzzzzzzzh_, "day");
            bool? szzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzzzw_, szzzzzzzzzzzzzzzzzzzzzzi_);

            return szzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12ObliqueDate, CqlDate FollowupVR12ObliqueDate)?> qzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12ObliqueDate, CqlDate FollowupVR12ObliqueDate)?>(qzzzzzzzzzzzzzzzzzzzzzzm_, qzzzzzzzzzzzzzzzzzzzzzzn_);
        Encounter qzzzzzzzzzzzzzzzzzzzzzzp_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12ObliqueDate, CqlDate FollowupVR12ObliqueDate)? tuple_fppktdiagiekhptnsbacpswh) =>
            tuple_fppktdiagiekhptnsbacpswh?.ValidEncounters;
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Select<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12ObliqueDate, CqlDate FollowupVR12ObliqueDate)?, Encounter>(qzzzzzzzzzzzzzzzzzzzzzzo_, qzzzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<Encounter> qzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Distinct<Encounter>(qzzzzzzzzzzzzzzzzzzzzzzq_);
        bool? qzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Exists<Encounter>(qzzzzzzzzzzzzzzzzzzzzzzr_);

        return qzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Date VR12 Orthogonal Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_VR12_Orthogonal_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode szzzzzzzzzzzzzzzzzzzzzzk_ = this.VR_12_Mental_component_summary__MCS__score___orthogonal_method_T_score(context);
        IEnumerable<CqlCode> szzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.ToList<CqlCode>(szzzzzzzzzzzzzzzzzzzzzzk_);
        IEnumerable<Observation> szzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, szzzzzzzzzzzzzzzzzzzzzzl_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> szzzzzzzzzzzzzzzzzzzzzzn_ = Status_1_8_000.Instance.isAssessmentPerformed(context, szzzzzzzzzzzzzzzzzzzzzzm_);
        CqlCode szzzzzzzzzzzzzzzzzzzzzzo_ = this.VR_12_Physical_component_summary__PCS__score___orthogonal_method_T_score(context);
        IEnumerable<CqlCode> szzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.ToList<CqlCode>(szzzzzzzzzzzzzzzzzzzzzzo_);
        IEnumerable<Observation> szzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, szzzzzzzzzzzzzzzzzzzzzzp_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> szzzzzzzzzzzzzzzzzzzzzzr_ = Status_1_8_000.Instance.isAssessmentPerformed(context, szzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<ValueTuple<Observation, Observation>> szzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.CrossJoin<Observation, Observation>(szzzzzzzzzzzzzzzzzzzzzzn_, szzzzzzzzzzzzzzzzzzzzzzr_);
        (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? szzzzzzzzzzzzzzzzzzzzzzt_(ValueTuple<Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? tzzzzzzzzzzzzzzzzzzzzzza_ = (CqlTupleMetadata_GAdRFKRaHUUGJcVHWQWRUjhRH, _valueTuple.Item1, _valueTuple.Item2);

            return tzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?> szzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Select<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?>(szzzzzzzzzzzzzzzzzzzzzzs_, szzzzzzzzzzzzzzzzzzzzzzt_);
        bool? szzzzzzzzzzzzzzzzzzzzzzv_((CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? tuple_gadrfkrahuugjcvhwqwrujhrh)
        {
            DataType tzzzzzzzzzzzzzzzzzzzzzzb_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Effective;
            object tzzzzzzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.toInterval(context, tzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlDate tzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.DateFrom(tzzzzzzzzzzzzzzzzzzzzzze_);
            DataType tzzzzzzzzzzzzzzzzzzzzzzg_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Effective;
            object tzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.toInterval(context, tzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlDate tzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.DateFrom(tzzzzzzzzzzzzzzzzzzzzzzj_);
            bool? tzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.SameAs(tzzzzzzzzzzzzzzzzzzzzzzf_, tzzzzzzzzzzzzzzzzzzzzzzk_, "day");
            DataType tzzzzzzzzzzzzzzzzzzzzzzm_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Value;
            object tzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzm_);
            bool? tzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Not((bool?)(tzzzzzzzzzzzzzzzzzzzzzzn_ is null));
            bool? tzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzl_, tzzzzzzzzzzzzzzzzzzzzzzo_);
            DataType tzzzzzzzzzzzzzzzzzzzzzzq_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Value;
            object tzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzq_);
            bool? tzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Not((bool?)(tzzzzzzzzzzzzzzzzzzzzzzr_ is null));
            bool? tzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzp_, tzzzzzzzzzzzzzzzzzzzzzzs_);

            return tzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?> szzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?>(szzzzzzzzzzzzzzzzzzzzzzu_, szzzzzzzzzzzzzzzzzzzzzzv_);
        CqlDate szzzzzzzzzzzzzzzzzzzzzzx_((CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? tuple_gadrfkrahuugjcvhwqwrujhrh)
        {
            DataType tzzzzzzzzzzzzzzzzzzzzzzu_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Effective;
            object tzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.toInterval(context, tzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(tzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlDate tzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.DateFrom(tzzzzzzzzzzzzzzzzzzzzzzx_);

            return tzzzzzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<CqlDate> szzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Select<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?, CqlDate>(szzzzzzzzzzzzzzzzzzzzzzw_, szzzzzzzzzzzzzzzzzzzzzzx_);
        IEnumerable<CqlDate> szzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Distinct<CqlDate>(szzzzzzzzzzzzzzzzzzzzzzy_);

        return szzzzzzzzzzzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Has Encounter with Initial and Follow Up VR12 Orthogonal Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments(CqlContext context)
    {
        IEnumerable<Encounter> tzzzzzzzzzzzzzzzzzzzzzzz_ = this.Qualifying_Encounters(context);
        IEnumerable<CqlDate> uzzzzzzzzzzzzzzzzzzzzzza_ = this.Date_VR12_Orthogonal_Total_Assessment_Completed(context);
        IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> uzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(tzzzzzzzzzzzzzzzzzzzzzzz_, uzzzzzzzzzzzzzzzzzzzzzza_, uzzzzzzzzzzzzzzzzzzzzzza_);
        (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12OrthogonalDate, CqlDate FollowupVR12OrthogonalDate)? uzzzzzzzzzzzzzzzzzzzzzzd_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12OrthogonalDate, CqlDate FollowupVR12OrthogonalDate)? uzzzzzzzzzzzzzzzzzzzzzzl_ = (CqlTupleMetadata_HSSAQEFQAOXLjUcOKGgicELWB, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return uzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12OrthogonalDate, CqlDate FollowupVR12OrthogonalDate)?> uzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12OrthogonalDate, CqlDate FollowupVR12OrthogonalDate)?>(uzzzzzzzzzzzzzzzzzzzzzzc_, uzzzzzzzzzzzzzzzzzzzzzzd_);
        bool? uzzzzzzzzzzzzzzzzzzzzzzf_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12OrthogonalDate, CqlDate FollowupVR12OrthogonalDate)? tuple_fansvmjaedmvsdoyrozxdlsai)
        {
            Period uzzzzzzzzzzzzzzzzzzzzzzm_ = tuple_fansvmjaedmvsdoyrozxdlsai?.ValidEncounters?.Period;
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.toInterval(context, uzzzzzzzzzzzzzzzzzzzzzzn_ as object);
            CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.End(uzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzq_ = this.Measurement_Period(context);
            CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.End(uzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlQuantity uzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Quantity(180m, "days");
            CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Subtract(uzzzzzzzzzzzzzzzzzzzzzzr_, uzzzzzzzzzzzzzzzzzzzzzzs_);
            bool? uzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.SameOrBefore(uzzzzzzzzzzzzzzzzzzzzzzp_, uzzzzzzzzzzzzzzzzzzzzzzt_, "day");
            CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.ConvertDateToDateTime(tuple_fansvmjaedmvsdoyrozxdlsai?.InitialVR12OrthogonalDate);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.toInterval(context, uzzzzzzzzzzzzzzzzzzzzzzx_ as object);
            CqlDateTime uzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.End(uzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlQuantity vzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Quantity(14m, "days");
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Subtract(uzzzzzzzzzzzzzzzzzzzzzzz_, vzzzzzzzzzzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.toInterval(context, vzzzzzzzzzzzzzzzzzzzzzzd_ as object);
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.End(vzzzzzzzzzzzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Interval(vzzzzzzzzzzzzzzzzzzzzzzb_, vzzzzzzzzzzzzzzzzzzzzzzf_, true, true);
            bool? vzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.In<CqlDateTime>(uzzzzzzzzzzzzzzzzzzzzzzv_, vzzzzzzzzzzzzzzzzzzzzzzg_, "day");
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.toInterval(context, vzzzzzzzzzzzzzzzzzzzzzzj_ as object);
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.End(vzzzzzzzzzzzzzzzzzzzzzzk_);
            bool? vzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Not((bool?)(vzzzzzzzzzzzzzzzzzzzzzzl_ is null));
            bool? vzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzzzh_, vzzzzzzzzzzzzzzzzzzzzzzm_);
            bool? vzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(uzzzzzzzzzzzzzzzzzzzzzzu_, vzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlDateTime vzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.ConvertDateToDateTime(tuple_fansvmjaedmvsdoyrozxdlsai?.FollowupVR12OrthogonalDate);
            CqlDate vzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.DateFrom(vzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlDate vzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.DateFrom(uzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlQuantity vzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Quantity(30m, "days");
            CqlDate vzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Add(vzzzzzzzzzzzzzzzzzzzzzzs_, vzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlDate vzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.DateFrom(uzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlDate vzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Add(vzzzzzzzzzzzzzzzzzzzzzzw_, uzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDate> vzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Interval(vzzzzzzzzzzzzzzzzzzzzzzu_, vzzzzzzzzzzzzzzzzzzzzzzy_, true, true);
            bool? wzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDate>(vzzzzzzzzzzzzzzzzzzzzzzq_, vzzzzzzzzzzzzzzzzzzzzzzz_, "day");
            bool? wzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(vzzzzzzzzzzzzzzzzzzzzzzo_, wzzzzzzzzzzzzzzzzzzzzzza_);

            return wzzzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12OrthogonalDate, CqlDate FollowupVR12OrthogonalDate)?> uzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12OrthogonalDate, CqlDate FollowupVR12OrthogonalDate)?>(uzzzzzzzzzzzzzzzzzzzzzze_, uzzzzzzzzzzzzzzzzzzzzzzf_);
        Encounter uzzzzzzzzzzzzzzzzzzzzzzh_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12OrthogonalDate, CqlDate FollowupVR12OrthogonalDate)? tuple_fansvmjaedmvsdoyrozxdlsai) =>
            tuple_fansvmjaedmvsdoyrozxdlsai?.ValidEncounters;
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Select<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12OrthogonalDate, CqlDate FollowupVR12OrthogonalDate)?, Encounter>(uzzzzzzzzzzzzzzzzzzzzzzg_, uzzzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<Encounter> uzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Distinct<Encounter>(uzzzzzzzzzzzzzzzzzzzzzzi_);
        bool? uzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Exists<Encounter>(uzzzzzzzzzzzzzzzzzzzzzzj_);

        return uzzzzzzzzzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Date VR36 Oblique Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_VR36_Oblique_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode wzzzzzzzzzzzzzzzzzzzzzzc_ = this.VR_36_Mental_component_summary__MCS__score___oblique_method_T_score(context);
        IEnumerable<CqlCode> wzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ToList<CqlCode>(wzzzzzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, wzzzzzzzzzzzzzzzzzzzzzzd_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzzzzf_ = Status_1_8_000.Instance.isAssessmentPerformed(context, wzzzzzzzzzzzzzzzzzzzzzze_);
        CqlCode wzzzzzzzzzzzzzzzzzzzzzzg_ = this.VR_36_Physical_component_summary__PCS__score___oblique_method_T_score(context);
        IEnumerable<CqlCode> wzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.ToList<CqlCode>(wzzzzzzzzzzzzzzzzzzzzzzg_);
        IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, wzzzzzzzzzzzzzzzzzzzzzzh_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> wzzzzzzzzzzzzzzzzzzzzzzj_ = Status_1_8_000.Instance.isAssessmentPerformed(context, wzzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<ValueTuple<Observation, Observation>> wzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.CrossJoin<Observation, Observation>(wzzzzzzzzzzzzzzzzzzzzzzf_, wzzzzzzzzzzzzzzzzzzzzzzj_);
        (CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)? wzzzzzzzzzzzzzzzzzzzzzzl_(ValueTuple<Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)? wzzzzzzzzzzzzzzzzzzzzzzs_ = (CqlTupleMetadata_DUcFTCLcQEWDGGQdFCWTHFaUK, _valueTuple.Item1, _valueTuple.Item2);

            return wzzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<(CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?> wzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Select<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?>(wzzzzzzzzzzzzzzzzzzzzzzk_, wzzzzzzzzzzzzzzzzzzzzzzl_);
        bool? wzzzzzzzzzzzzzzzzzzzzzzn_((CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)? tuple_ducftclcqewdggqdfcwthfauk)
        {
            DataType wzzzzzzzzzzzzzzzzzzzzzzt_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36MentalAssessment?.Effective;
            object wzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, wzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(wzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlDate wzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.DateFrom(wzzzzzzzzzzzzzzzzzzzzzzw_);
            DataType wzzzzzzzzzzzzzzzzzzzzzzy_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36PhysicalAssessment?.Effective;
            object wzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, wzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzzzza_);
            CqlDate xzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.DateFrom(xzzzzzzzzzzzzzzzzzzzzzzb_);
            bool? xzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.SameAs(wzzzzzzzzzzzzzzzzzzzzzzx_, xzzzzzzzzzzzzzzzzzzzzzzc_, "day");
            DataType xzzzzzzzzzzzzzzzzzzzzzze_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36MentalAssessment?.Value;
            object xzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzze_);
            bool? xzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Not((bool?)(xzzzzzzzzzzzzzzzzzzzzzzf_ is null));
            bool? xzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzzd_, xzzzzzzzzzzzzzzzzzzzzzzg_);
            DataType xzzzzzzzzzzzzzzzzzzzzzzi_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36PhysicalAssessment?.Value;
            object xzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzi_);
            bool? xzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Not((bool?)(xzzzzzzzzzzzzzzzzzzzzzzj_ is null));
            bool? xzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzzh_, xzzzzzzzzzzzzzzzzzzzzzzk_);

            return xzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<(CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?> wzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<(CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?>(wzzzzzzzzzzzzzzzzzzzzzzm_, wzzzzzzzzzzzzzzzzzzzzzzn_);
        CqlDate wzzzzzzzzzzzzzzzzzzzzzzp_((CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)? tuple_ducftclcqewdggqdfcwthfauk)
        {
            DataType xzzzzzzzzzzzzzzzzzzzzzzm_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36MentalAssessment?.Effective;
            object xzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlDate xzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.DateFrom(xzzzzzzzzzzzzzzzzzzzzzzp_);

            return xzzzzzzzzzzzzzzzzzzzzzzq_;
        };
        IEnumerable<CqlDate> wzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Select<(CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?, CqlDate>(wzzzzzzzzzzzzzzzzzzzzzzo_, wzzzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<CqlDate> wzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Distinct<CqlDate>(wzzzzzzzzzzzzzzzzzzzzzzq_);

        return wzzzzzzzzzzzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Has Encounter with Initial and Follow Up VR36 Oblique Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_VR36_Oblique_Assessments(CqlContext context)
    {
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzr_ = this.Qualifying_Encounters(context);
        IEnumerable<CqlDate> xzzzzzzzzzzzzzzzzzzzzzzs_ = this.Date_VR36_Oblique_Total_Assessment_Completed(context);
        IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> xzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(xzzzzzzzzzzzzzzzzzzzzzzr_, xzzzzzzzzzzzzzzzzzzzzzzs_, xzzzzzzzzzzzzzzzzzzzzzzs_);
        (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36ObliqueDate, CqlDate FollowupVR36ObliqueDate)? xzzzzzzzzzzzzzzzzzzzzzzv_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36ObliqueDate, CqlDate FollowupVR36ObliqueDate)? yzzzzzzzzzzzzzzzzzzzzzzd_ = (CqlTupleMetadata_HQfcMfhQUSTNYMWSgJHiFeahQ, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return yzzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36ObliqueDate, CqlDate FollowupVR36ObliqueDate)?> xzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36ObliqueDate, CqlDate FollowupVR36ObliqueDate)?>(xzzzzzzzzzzzzzzzzzzzzzzu_, xzzzzzzzzzzzzzzzzzzzzzzv_);
        bool? xzzzzzzzzzzzzzzzzzzzzzzx_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36ObliqueDate, CqlDate FollowupVR36ObliqueDate)? tuple_elxicyhrdpyzpqyjphdifbiga)
        {
            Period yzzzzzzzzzzzzzzzzzzzzzze_ = tuple_elxicyhrdpyzpqyjphdifbiga?.ValidEncounters?.Period;
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzzzzzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.toInterval(context, yzzzzzzzzzzzzzzzzzzzzzzf_ as object);
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.End(yzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzi_ = this.Measurement_Period(context);
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.End(yzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlQuantity yzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Quantity(180m, "days");
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Subtract(yzzzzzzzzzzzzzzzzzzzzzzj_, yzzzzzzzzzzzzzzzzzzzzzzk_);
            bool? yzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.SameOrBefore(yzzzzzzzzzzzzzzzzzzzzzzh_, yzzzzzzzzzzzzzzzzzzzzzzl_, "day");
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.ConvertDateToDateTime(tuple_elxicyhrdpyzpqyjphdifbiga?.InitialVR36ObliqueDate);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzzzzzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.toInterval(context, yzzzzzzzzzzzzzzzzzzzzzzp_ as object);
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.End(yzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlQuantity yzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Quantity(14m, "days");
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Subtract(yzzzzzzzzzzzzzzzzzzzzzzr_, yzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzzzzzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.toInterval(context, yzzzzzzzzzzzzzzzzzzzzzzv_ as object);
            CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.End(yzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Interval(yzzzzzzzzzzzzzzzzzzzzzzt_, yzzzzzzzzzzzzzzzzzzzzzzx_, true, true);
            bool? yzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<CqlDateTime>(yzzzzzzzzzzzzzzzzzzzzzzn_, yzzzzzzzzzzzzzzzzzzzzzzy_, "day");
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzzzzzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, zzzzzzzzzzzzzzzzzzzzzzzb_ as object);
            CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.End(zzzzzzzzzzzzzzzzzzzzzzzc_);
            bool? zzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Not((bool?)(zzzzzzzzzzzzzzzzzzzzzzzd_ is null));
            bool? zzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzzzzz_, zzzzzzzzzzzzzzzzzzzzzzze_);
            bool? zzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.And(yzzzzzzzzzzzzzzzzzzzzzzm_, zzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlDateTime zzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.ConvertDateToDateTime(tuple_elxicyhrdpyzpqyjphdifbiga?.FollowupVR36ObliqueDate);
            CqlDate zzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.DateFrom(zzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlDate zzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.DateFrom(yzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlQuantity zzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Quantity(30m, "days");
            CqlDate zzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Add(zzzzzzzzzzzzzzzzzzzzzzzk_, zzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlDate zzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.DateFrom(yzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlDate zzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Add(zzzzzzzzzzzzzzzzzzzzzzzo_, yzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlInterval<CqlDate> zzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Interval(zzzzzzzzzzzzzzzzzzzzzzzm_, zzzzzzzzzzzzzzzzzzzzzzzq_, true, true);
            bool? zzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.In<CqlDate>(zzzzzzzzzzzzzzzzzzzzzzzi_, zzzzzzzzzzzzzzzzzzzzzzzr_, "day");
            bool? zzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(zzzzzzzzzzzzzzzzzzzzzzzg_, zzzzzzzzzzzzzzzzzzzzzzzs_);

            return zzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36ObliqueDate, CqlDate FollowupVR36ObliqueDate)?> xzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36ObliqueDate, CqlDate FollowupVR36ObliqueDate)?>(xzzzzzzzzzzzzzzzzzzzzzzw_, xzzzzzzzzzzzzzzzzzzzzzzx_);
        Encounter xzzzzzzzzzzzzzzzzzzzzzzz_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36ObliqueDate, CqlDate FollowupVR36ObliqueDate)? tuple_elxicyhrdpyzpqyjphdifbiga) =>
            tuple_elxicyhrdpyzpqyjphdifbiga?.ValidEncounters;
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Select<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36ObliqueDate, CqlDate FollowupVR36ObliqueDate)?, Encounter>(xzzzzzzzzzzzzzzzzzzzzzzy_, xzzzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Distinct<Encounter>(yzzzzzzzzzzzzzzzzzzzzzza_);
        bool? yzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Exists<Encounter>(yzzzzzzzzzzzzzzzzzzzzzzb_);

        return yzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Date VR36 Orthogonal Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_VR36_Orthogonal_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode zzzzzzzzzzzzzzzzzzzzzzzu_ = this.VR_36_Mental_component_summary__MCS__score___orthogonal_method_T_score(context);
        IEnumerable<CqlCode> zzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.ToList<CqlCode>(zzzzzzzzzzzzzzzzzzzzzzzu_);
        IEnumerable<Observation> zzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, zzzzzzzzzzzzzzzzzzzzzzzv_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> zzzzzzzzzzzzzzzzzzzzzzzx_ = Status_1_8_000.Instance.isAssessmentPerformed(context, zzzzzzzzzzzzzzzzzzzzzzzw_);
        CqlCode zzzzzzzzzzzzzzzzzzzzzzzy_ = this.VR_36_Physical_component_summary__PCS__score___orthogonal_method_T_score(context);
        IEnumerable<CqlCode> zzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.ToList<CqlCode>(zzzzzzzzzzzzzzzzzzzzzzzy_);
        IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, zzzzzzzzzzzzzzzzzzzzzzzz_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> azzzzzzzzzzzzzzzzzzzzzzzb_ = Status_1_8_000.Instance.isAssessmentPerformed(context, azzzzzzzzzzzzzzzzzzzzzzza_);
        IEnumerable<ValueTuple<Observation, Observation>> azzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.CrossJoin<Observation, Observation>(zzzzzzzzzzzzzzzzzzzzzzzx_, azzzzzzzzzzzzzzzzzzzzzzzb_);
        (CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)? azzzzzzzzzzzzzzzzzzzzzzzd_(ValueTuple<Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)? azzzzzzzzzzzzzzzzzzzzzzzk_ = (CqlTupleMetadata_DUcFTCLcQEWDGGQdFCWTHFaUK, _valueTuple.Item1, _valueTuple.Item2);

            return azzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<(CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?> azzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Select<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?>(azzzzzzzzzzzzzzzzzzzzzzzc_, azzzzzzzzzzzzzzzzzzzzzzzd_);
        bool? azzzzzzzzzzzzzzzzzzzzzzzf_((CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)? tuple_ducftclcqewdggqdfcwthfauk)
        {
            DataType azzzzzzzzzzzzzzzzzzzzzzzl_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36MentalAssessment?.Effective;
            object azzzzzzzzzzzzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.toInterval(context, azzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Start(azzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlDate azzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.DateFrom(azzzzzzzzzzzzzzzzzzzzzzzo_);
            DataType azzzzzzzzzzzzzzzzzzzzzzzq_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36PhysicalAssessment?.Effective;
            object azzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.toInterval(context, azzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlDateTime azzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(azzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlDate azzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.DateFrom(azzzzzzzzzzzzzzzzzzzzzzzt_);
            bool? azzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.SameAs(azzzzzzzzzzzzzzzzzzzzzzzp_, azzzzzzzzzzzzzzzzzzzzzzzu_, "day");
            DataType azzzzzzzzzzzzzzzzzzzzzzzw_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36MentalAssessment?.Value;
            object azzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzzzzzzzzzzzzw_);
            bool? azzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Not((bool?)(azzzzzzzzzzzzzzzzzzzzzzzx_ is null));
            bool? azzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzzzzzv_, azzzzzzzzzzzzzzzzzzzzzzzy_);
            DataType bzzzzzzzzzzzzzzzzzzzzzzza_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36PhysicalAssessment?.Value;
            object bzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzza_);
            bool? bzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Not((bool?)(bzzzzzzzzzzzzzzzzzzzzzzzb_ is null));
            bool? bzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(azzzzzzzzzzzzzzzzzzzzzzzz_, bzzzzzzzzzzzzzzzzzzzzzzzc_);

            return bzzzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<(CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?> azzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<(CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?>(azzzzzzzzzzzzzzzzzzzzzzze_, azzzzzzzzzzzzzzzzzzzzzzzf_);
        CqlDate azzzzzzzzzzzzzzzzzzzzzzzh_((CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)? tuple_ducftclcqewdggqdfcwthfauk)
        {
            DataType bzzzzzzzzzzzzzzzzzzzzzzze_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36MentalAssessment?.Effective;
            object bzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Start(bzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlDate bzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.DateFrom(bzzzzzzzzzzzzzzzzzzzzzzzh_);

            return bzzzzzzzzzzzzzzzzzzzzzzzi_;
        };
        IEnumerable<CqlDate> azzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Select<(CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?, CqlDate>(azzzzzzzzzzzzzzzzzzzzzzzg_, azzzzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<CqlDate> azzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Distinct<CqlDate>(azzzzzzzzzzzzzzzzzzzzzzzi_);

        return azzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Has Encounter with Initial and Follow Up VR36 Orthogonal Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_VR36_Orthogonal_Assessments(CqlContext context)
    {
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzj_ = this.Qualifying_Encounters(context);
        IEnumerable<CqlDate> bzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Date_VR36_Orthogonal_Total_Assessment_Completed(context);
        IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> bzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(bzzzzzzzzzzzzzzzzzzzzzzzj_, bzzzzzzzzzzzzzzzzzzzzzzzk_, bzzzzzzzzzzzzzzzzzzzzzzzk_);
        (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36OrthogonalDate, CqlDate FollowupVR36OrthogonalDate)? bzzzzzzzzzzzzzzzzzzzzzzzn_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36OrthogonalDate, CqlDate FollowupVR36OrthogonalDate)? bzzzzzzzzzzzzzzzzzzzzzzzv_ = (CqlTupleMetadata_BFZHWdOOROjSjFSECHcQiaZZZ, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return bzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36OrthogonalDate, CqlDate FollowupVR36OrthogonalDate)?> bzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36OrthogonalDate, CqlDate FollowupVR36OrthogonalDate)?>(bzzzzzzzzzzzzzzzzzzzzzzzm_, bzzzzzzzzzzzzzzzzzzzzzzzn_);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzp_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36OrthogonalDate, CqlDate FollowupVR36OrthogonalDate)? tuple_fucqujadjizabihdffformht)
        {
            Period bzzzzzzzzzzzzzzzzzzzzzzzw_ = tuple_fucqujadjizabihdffformht?.ValidEncounters?.Period;
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzzzzzzzzzzzzzx_ as object);
            CqlDateTime bzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.End(bzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzza_ = this.Measurement_Period(context);
            CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.End(czzzzzzzzzzzzzzzzzzzzzzza_);
            CqlQuantity czzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Quantity(180m, "days");
            CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Subtract(czzzzzzzzzzzzzzzzzzzzzzzb_, czzzzzzzzzzzzzzzzzzzzzzzc_);
            bool? czzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.SameOrBefore(bzzzzzzzzzzzzzzzzzzzzzzzz_, czzzzzzzzzzzzzzzzzzzzzzzd_, "day");
            CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.ConvertDateToDateTime(tuple_fucqujadjizabihdffformht?.InitialVR36OrthogonalDate);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.toInterval(context, czzzzzzzzzzzzzzzzzzzzzzzh_ as object);
            CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.End(czzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlQuantity czzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Quantity(14m, "days");
            CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Subtract(czzzzzzzzzzzzzzzzzzzzzzzj_, czzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.toInterval(context, czzzzzzzzzzzzzzzzzzzzzzzn_ as object);
            CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.End(czzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Interval(czzzzzzzzzzzzzzzzzzzzzzzl_, czzzzzzzzzzzzzzzzzzzzzzzp_, true, true);
            bool? czzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(czzzzzzzzzzzzzzzzzzzzzzzf_, czzzzzzzzzzzzzzzzzzzzzzzq_, "day");
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, czzzzzzzzzzzzzzzzzzzzzzzt_ as object);
            CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.End(czzzzzzzzzzzzzzzzzzzzzzzu_);
            bool? czzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Not((bool?)(czzzzzzzzzzzzzzzzzzzzzzzv_ is null));
            bool? czzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzzzzr_, czzzzzzzzzzzzzzzzzzzzzzzw_);
            bool? czzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzzzze_, czzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlDateTime czzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.ConvertDateToDateTime(tuple_fucqujadjizabihdffformht?.FollowupVR36OrthogonalDate);
            CqlDate dzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.DateFrom(czzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlDate dzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.DateFrom(czzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlQuantity dzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Quantity(30m, "days");
            CqlDate dzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Add(dzzzzzzzzzzzzzzzzzzzzzzzc_, dzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlDate dzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.DateFrom(czzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlDate dzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Add(dzzzzzzzzzzzzzzzzzzzzzzzg_, czzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlInterval<CqlDate> dzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Interval(dzzzzzzzzzzzzzzzzzzzzzzze_, dzzzzzzzzzzzzzzzzzzzzzzzi_, true, true);
            bool? dzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.In<CqlDate>(dzzzzzzzzzzzzzzzzzzzzzzza_, dzzzzzzzzzzzzzzzzzzzzzzzj_, "day");
            bool? dzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.And(czzzzzzzzzzzzzzzzzzzzzzzy_, dzzzzzzzzzzzzzzzzzzzzzzzk_);

            return dzzzzzzzzzzzzzzzzzzzzzzzl_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36OrthogonalDate, CqlDate FollowupVR36OrthogonalDate)?> bzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36OrthogonalDate, CqlDate FollowupVR36OrthogonalDate)?>(bzzzzzzzzzzzzzzzzzzzzzzzo_, bzzzzzzzzzzzzzzzzzzzzzzzp_);
        Encounter bzzzzzzzzzzzzzzzzzzzzzzzr_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36OrthogonalDate, CqlDate FollowupVR36OrthogonalDate)? tuple_fucqujadjizabihdffformht) =>
            tuple_fucqujadjizabihdffformht?.ValidEncounters;
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Select<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36OrthogonalDate, CqlDate FollowupVR36OrthogonalDate)?, Encounter>(bzzzzzzzzzzzzzzzzzzzzzzzq_, bzzzzzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Distinct<Encounter>(bzzzzzzzzzzzzzzzzzzzzzzzs_);
        bool? bzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Exists<Encounter>(bzzzzzzzzzzzzzzzzzzzzzzzt_);

        return bzzzzzzzzzzzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Date MLHFQ Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_MLHFQ_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode dzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Physical_score__MLHFQ_(context);
        IEnumerable<CqlCode> dzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.ToList<CqlCode>(dzzzzzzzzzzzzzzzzzzzzzzzm_);
        IEnumerable<Observation> dzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, dzzzzzzzzzzzzzzzzzzzzzzzn_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> dzzzzzzzzzzzzzzzzzzzzzzzp_ = Status_1_8_000.Instance.isAssessmentPerformed(context, dzzzzzzzzzzzzzzzzzzzzzzzo_);
        CqlCode dzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Emotional_score__MLHFQ_(context);
        IEnumerable<CqlCode> dzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ToList<CqlCode>(dzzzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<Observation> dzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, dzzzzzzzzzzzzzzzzzzzzzzzr_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> dzzzzzzzzzzzzzzzzzzzzzzzt_ = Status_1_8_000.Instance.isAssessmentPerformed(context, dzzzzzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<ValueTuple<Observation, Observation>> dzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.CrossJoin<Observation, Observation>(dzzzzzzzzzzzzzzzzzzzzzzzp_, dzzzzzzzzzzzzzzzzzzzzzzzt_);
        (CqlTupleMetadata, Observation MLHFQPhysical, Observation MLHFQEmotional)? dzzzzzzzzzzzzzzzzzzzzzzzv_(ValueTuple<Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation MLHFQPhysical, Observation MLHFQEmotional)? ezzzzzzzzzzzzzzzzzzzzzzzc_ = (CqlTupleMetadata_EBLWeAeedHPAfOJXKPZJKSCUf, _valueTuple.Item1, _valueTuple.Item2);

            return ezzzzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<(CqlTupleMetadata, Observation MLHFQPhysical, Observation MLHFQEmotional)?> dzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Select<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation MLHFQPhysical, Observation MLHFQEmotional)?>(dzzzzzzzzzzzzzzzzzzzzzzzu_, dzzzzzzzzzzzzzzzzzzzzzzzv_);
        bool? dzzzzzzzzzzzzzzzzzzzzzzzx_((CqlTupleMetadata, Observation MLHFQPhysical, Observation MLHFQEmotional)? tuple_fnofxckadaeusjerhbdqfoshe)
        {
            DataType ezzzzzzzzzzzzzzzzzzzzzzzd_ = tuple_fnofxckadaeusjerhbdqfoshe?.MLHFQPhysical?.Effective;
            object ezzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, ezzzzzzzzzzzzzzzzzzzzzzze_);
            CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlDate ezzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.DateFrom(ezzzzzzzzzzzzzzzzzzzzzzzg_);
            DataType ezzzzzzzzzzzzzzzzzzzzzzzi_ = tuple_fnofxckadaeusjerhbdqfoshe?.MLHFQEmotional?.Effective;
            object ezzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.toInterval(context, ezzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlDate ezzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.DateFrom(ezzzzzzzzzzzzzzzzzzzzzzzl_);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.SameAs(ezzzzzzzzzzzzzzzzzzzzzzzh_, ezzzzzzzzzzzzzzzzzzzzzzzm_, "day");
            DataType ezzzzzzzzzzzzzzzzzzzzzzzo_ = tuple_fnofxckadaeusjerhbdqfoshe?.MLHFQPhysical?.Value;
            object ezzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzo_);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Not((bool?)(ezzzzzzzzzzzzzzzzzzzzzzzp_ is null));
            bool? ezzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(ezzzzzzzzzzzzzzzzzzzzzzzn_, ezzzzzzzzzzzzzzzzzzzzzzzq_);
            DataType ezzzzzzzzzzzzzzzzzzzzzzzs_ = tuple_fnofxckadaeusjerhbdqfoshe?.MLHFQEmotional?.Value;
            object ezzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzs_);
            bool? ezzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Not((bool?)(ezzzzzzzzzzzzzzzzzzzzzzzt_ is null));
            bool? ezzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(ezzzzzzzzzzzzzzzzzzzzzzzr_, ezzzzzzzzzzzzzzzzzzzzzzzu_);

            return ezzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<(CqlTupleMetadata, Observation MLHFQPhysical, Observation MLHFQEmotional)?> dzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<(CqlTupleMetadata, Observation MLHFQPhysical, Observation MLHFQEmotional)?>(dzzzzzzzzzzzzzzzzzzzzzzzw_, dzzzzzzzzzzzzzzzzzzzzzzzx_);
        CqlDate dzzzzzzzzzzzzzzzzzzzzzzzz_((CqlTupleMetadata, Observation MLHFQPhysical, Observation MLHFQEmotional)? tuple_fnofxckadaeusjerhbdqfoshe)
        {
            DataType ezzzzzzzzzzzzzzzzzzzzzzzw_ = tuple_fnofxckadaeusjerhbdqfoshe?.MLHFQPhysical?.Effective;
            object ezzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.toInterval(context, ezzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlDateTime ezzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Start(ezzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlDate fzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.DateFrom(ezzzzzzzzzzzzzzzzzzzzzzzz_);

            return fzzzzzzzzzzzzzzzzzzzzzzza_;
        };
        IEnumerable<CqlDate> ezzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Select<(CqlTupleMetadata, Observation MLHFQPhysical, Observation MLHFQEmotional)?, CqlDate>(dzzzzzzzzzzzzzzzzzzzzzzzy_, dzzzzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<CqlDate> ezzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Distinct<CqlDate>(ezzzzzzzzzzzzzzzzzzzzzzza_);

        return ezzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Has Encounter with Initial and Follow Up MLHFQ Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_MLHFQ_Assessments(CqlContext context)
    {
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Qualifying_Encounters(context);
        IEnumerable<CqlDate> fzzzzzzzzzzzzzzzzzzzzzzzc_ = this.Date_MLHFQ_Total_Assessment_Completed(context);
        IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> fzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(fzzzzzzzzzzzzzzzzzzzzzzzb_, fzzzzzzzzzzzzzzzzzzzzzzzc_, fzzzzzzzzzzzzzzzzzzzzzzzc_);
        (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialMLHFQDate, CqlDate FollowupMLHFQDate)? fzzzzzzzzzzzzzzzzzzzzzzzf_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialMLHFQDate, CqlDate FollowupMLHFQDate)? fzzzzzzzzzzzzzzzzzzzzzzzn_ = (CqlTupleMetadata_CcaWSNDiVeaLebVKKWWWiBcEU, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return fzzzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialMLHFQDate, CqlDate FollowupMLHFQDate)?> fzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialMLHFQDate, CqlDate FollowupMLHFQDate)?>(fzzzzzzzzzzzzzzzzzzzzzzze_, fzzzzzzzzzzzzzzzzzzzzzzzf_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzh_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialMLHFQDate, CqlDate FollowupMLHFQDate)? tuple_ncdawctnmbfmtibmihsfbaig)
        {
            Period fzzzzzzzzzzzzzzzzzzzzzzzo_ = tuple_ncdawctnmbfmtibmihsfbaig?.ValidEncounters?.Period;
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.toInterval(context, fzzzzzzzzzzzzzzzzzzzzzzzp_ as object);
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.End(fzzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzs_ = this.Measurement_Period(context);
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.End(fzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlQuantity fzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Quantity(180m, "days");
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Subtract(fzzzzzzzzzzzzzzzzzzzzzzzt_, fzzzzzzzzzzzzzzzzzzzzzzzu_);
            bool? fzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.SameOrBefore(fzzzzzzzzzzzzzzzzzzzzzzzr_, fzzzzzzzzzzzzzzzzzzzzzzzv_, "day");
            CqlDateTime fzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.ConvertDateToDateTime(tuple_ncdawctnmbfmtibmihsfbaig?.InitialMLHFQDate);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, fzzzzzzzzzzzzzzzzzzzzzzzz_ as object);
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.End(gzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlQuantity gzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Quantity(14m, "days");
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Subtract(gzzzzzzzzzzzzzzzzzzzzzzzb_, gzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzzzzzzzzzzzzzzzf_ as object);
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.End(gzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Interval(gzzzzzzzzzzzzzzzzzzzzzzzd_, gzzzzzzzzzzzzzzzzzzzzzzzh_, true, true);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.In<CqlDateTime>(fzzzzzzzzzzzzzzzzzzzzzzzx_, gzzzzzzzzzzzzzzzzzzzzzzzi_, "day");
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzzzzzzzzzzzzzzzl_ as object);
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.End(gzzzzzzzzzzzzzzzzzzzzzzzm_);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Not((bool?)(gzzzzzzzzzzzzzzzzzzzzzzzn_ is null));
            bool? gzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzzzj_, gzzzzzzzzzzzzzzzzzzzzzzzo_);
            bool? gzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzzzzzzw_, gzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlDateTime gzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ConvertDateToDateTime(tuple_ncdawctnmbfmtibmihsfbaig?.FollowupMLHFQDate);
            CqlDate gzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.DateFrom(gzzzzzzzzzzzzzzzzzzzzzzzr_);
            CqlDate gzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.DateFrom(fzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlQuantity gzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Quantity(30m, "days");
            CqlDate gzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Add(gzzzzzzzzzzzzzzzzzzzzzzzu_, gzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlDate gzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.DateFrom(fzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlDate hzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Add(gzzzzzzzzzzzzzzzzzzzzzzzy_, fzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDate> hzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Interval(gzzzzzzzzzzzzzzzzzzzzzzzw_, hzzzzzzzzzzzzzzzzzzzzzzza_, true, true);
            bool? hzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.In<CqlDate>(gzzzzzzzzzzzzzzzzzzzzzzzs_, hzzzzzzzzzzzzzzzzzzzzzzzb_, "day");
            bool? hzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(gzzzzzzzzzzzzzzzzzzzzzzzq_, hzzzzzzzzzzzzzzzzzzzzzzzc_);

            return hzzzzzzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialMLHFQDate, CqlDate FollowupMLHFQDate)?> fzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialMLHFQDate, CqlDate FollowupMLHFQDate)?>(fzzzzzzzzzzzzzzzzzzzzzzzg_, fzzzzzzzzzzzzzzzzzzzzzzzh_);
        Encounter fzzzzzzzzzzzzzzzzzzzzzzzj_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialMLHFQDate, CqlDate FollowupMLHFQDate)? tuple_ncdawctnmbfmtibmihsfbaig) =>
            tuple_ncdawctnmbfmtibmihsfbaig?.ValidEncounters;
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Select<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialMLHFQDate, CqlDate FollowupMLHFQDate)?, Encounter>(fzzzzzzzzzzzzzzzzzzzzzzzi_, fzzzzzzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<Encounter> fzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Distinct<Encounter>(fzzzzzzzzzzzzzzzzzzzzzzzk_);
        bool? fzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Exists<Encounter>(fzzzzzzzzzzzzzzzzzzzzzzzl_);

        return fzzzzzzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Date KCCQ12 Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_KCCQ12_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode hzzzzzzzzzzzzzzzzzzzzzzze_ = this.Kansas_City_Cardiomyopathy_Questionnaire___12_item__KCCQ_12_(context);
        IEnumerable<CqlCode> hzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.ToList<CqlCode>(hzzzzzzzzzzzzzzzzzzzzzzze_);
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, hzzzzzzzzzzzzzzzzzzzzzzzf_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzh_ = Status_1_8_000.Instance.isAssessmentPerformed(context, hzzzzzzzzzzzzzzzzzzzzzzzg_);
        CqlCode hzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Overall_summary_score__KCCQ_12_(context);
        IEnumerable<CqlCode> hzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.ToList<CqlCode>(hzzzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, hzzzzzzzzzzzzzzzzzzzzzzzj_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> hzzzzzzzzzzzzzzzzzzzzzzzl_ = Status_1_8_000.Instance.isAssessmentPerformed(context, hzzzzzzzzzzzzzzzzzzzzzzzk_);
        IEnumerable<ValueTuple<Observation, Observation>> hzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.CrossJoin<Observation, Observation>(hzzzzzzzzzzzzzzzzzzzzzzzh_, hzzzzzzzzzzzzzzzzzzzzzzzl_);
        (CqlTupleMetadata, Observation KCCQ12Item, Observation KCCQ12Summary)? hzzzzzzzzzzzzzzzzzzzzzzzn_(ValueTuple<Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation KCCQ12Item, Observation KCCQ12Summary)? hzzzzzzzzzzzzzzzzzzzzzzzu_ = (CqlTupleMetadata_DFKXORghhYafccUSbQaMfNTDj, _valueTuple.Item1, _valueTuple.Item2);

            return hzzzzzzzzzzzzzzzzzzzzzzzu_;
        };
        IEnumerable<(CqlTupleMetadata, Observation KCCQ12Item, Observation KCCQ12Summary)?> hzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Select<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation KCCQ12Item, Observation KCCQ12Summary)?>(hzzzzzzzzzzzzzzzzzzzzzzzm_, hzzzzzzzzzzzzzzzzzzzzzzzn_);
        bool? hzzzzzzzzzzzzzzzzzzzzzzzp_((CqlTupleMetadata, Observation KCCQ12Item, Observation KCCQ12Summary)? tuple_dfkxorghhyafccusbqamfntdj)
        {
            DataType hzzzzzzzzzzzzzzzzzzzzzzzv_ = tuple_dfkxorghhyafccusbqamfntdj?.KCCQ12Item?.Effective;
            object hzzzzzzzzzzzzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.toInterval(context, hzzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlDateTime hzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Start(hzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlDate hzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.DateFrom(hzzzzzzzzzzzzzzzzzzzzzzzy_);
            DataType izzzzzzzzzzzzzzzzzzzzzzza_ = tuple_dfkxorghhyafccusbqamfntdj?.KCCQ12Summary?.Effective;
            object izzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, izzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(izzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlDate izzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.DateFrom(izzzzzzzzzzzzzzzzzzzzzzzd_);
            bool? izzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.SameAs(hzzzzzzzzzzzzzzzzzzzzzzzz_, izzzzzzzzzzzzzzzzzzzzzzze_, "day");
            DataType izzzzzzzzzzzzzzzzzzzzzzzg_ = tuple_dfkxorghhyafccusbqamfntdj?.KCCQ12Item?.Value;
            object izzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzg_);
            bool? izzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Not((bool?)(izzzzzzzzzzzzzzzzzzzzzzzh_ is null));
            bool? izzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzzf_, izzzzzzzzzzzzzzzzzzzzzzzi_);
            DataType izzzzzzzzzzzzzzzzzzzzzzzk_ = tuple_dfkxorghhyafccusbqamfntdj?.KCCQ12Summary?.Value;
            object izzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzk_);
            bool? izzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Not((bool?)(izzzzzzzzzzzzzzzzzzzzzzzl_ is null));
            bool? izzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(izzzzzzzzzzzzzzzzzzzzzzzj_, izzzzzzzzzzzzzzzzzzzzzzzm_);

            return izzzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<(CqlTupleMetadata, Observation KCCQ12Item, Observation KCCQ12Summary)?> hzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<(CqlTupleMetadata, Observation KCCQ12Item, Observation KCCQ12Summary)?>(hzzzzzzzzzzzzzzzzzzzzzzzo_, hzzzzzzzzzzzzzzzzzzzzzzzp_);
        CqlDate hzzzzzzzzzzzzzzzzzzzzzzzr_((CqlTupleMetadata, Observation KCCQ12Item, Observation KCCQ12Summary)? tuple_dfkxorghhyafccusbqamfntdj)
        {
            DataType izzzzzzzzzzzzzzzzzzzzzzzo_ = tuple_dfkxorghhyafccusbqamfntdj?.KCCQ12Item?.Effective;
            object izzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.toInterval(context, izzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlDateTime izzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Start(izzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlDate izzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.DateFrom(izzzzzzzzzzzzzzzzzzzzzzzr_);

            return izzzzzzzzzzzzzzzzzzzzzzzs_;
        };
        IEnumerable<CqlDate> hzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Select<(CqlTupleMetadata, Observation KCCQ12Item, Observation KCCQ12Summary)?, CqlDate>(hzzzzzzzzzzzzzzzzzzzzzzzq_, hzzzzzzzzzzzzzzzzzzzzzzzr_);
        IEnumerable<CqlDate> hzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Distinct<CqlDate>(hzzzzzzzzzzzzzzzzzzzzzzzs_);

        return hzzzzzzzzzzzzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Has Encounter with Initial and Follow Up KCCQ12 Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_KCCQ12_Assessments(CqlContext context)
    {
        IEnumerable<Encounter> izzzzzzzzzzzzzzzzzzzzzzzt_ = this.Qualifying_Encounters(context);
        IEnumerable<CqlDate> izzzzzzzzzzzzzzzzzzzzzzzu_ = this.Date_KCCQ12_Total_Assessment_Completed(context);
        IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> izzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(izzzzzzzzzzzzzzzzzzzzzzzt_, izzzzzzzzzzzzzzzzzzzzzzzu_, izzzzzzzzzzzzzzzzzzzzzzzu_);
        (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQ12Date, CqlDate FollowupKCCQ12Date)? izzzzzzzzzzzzzzzzzzzzzzzx_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQ12Date, CqlDate FollowupKCCQ12Date)? jzzzzzzzzzzzzzzzzzzzzzzzf_ = (CqlTupleMetadata_EQQLFFBVIbLIQLiZDNfeYdMU, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return jzzzzzzzzzzzzzzzzzzzzzzzf_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQ12Date, CqlDate FollowupKCCQ12Date)?> izzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQ12Date, CqlDate FollowupKCCQ12Date)?>(izzzzzzzzzzzzzzzzzzzzzzzw_, izzzzzzzzzzzzzzzzzzzzzzzx_);
        bool? izzzzzzzzzzzzzzzzzzzzzzzz_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQ12Date, CqlDate FollowupKCCQ12Date)? tuple_eoahgtwwdfqijhcjzqnvidvuo)
        {
            Period jzzzzzzzzzzzzzzzzzzzzzzzg_ = tuple_eoahgtwwdfqijhcjzqnvidvuo?.ValidEncounters?.Period;
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.toInterval(context, jzzzzzzzzzzzzzzzzzzzzzzzh_ as object);
            CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.End(jzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Measurement_Period(context);
            CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.End(jzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlQuantity jzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Quantity(180m, "days");
            CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Subtract(jzzzzzzzzzzzzzzzzzzzzzzzl_, jzzzzzzzzzzzzzzzzzzzzzzzm_);
            bool? jzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.SameOrBefore(jzzzzzzzzzzzzzzzzzzzzzzzj_, jzzzzzzzzzzzzzzzzzzzzzzzn_, "day");
            CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.ConvertDateToDateTime(tuple_eoahgtwwdfqijhcjzqnvidvuo?.InitialKCCQ12Date);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.toInterval(context, jzzzzzzzzzzzzzzzzzzzzzzzr_ as object);
            CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.End(jzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlQuantity jzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Quantity(14m, "days");
            CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Subtract(jzzzzzzzzzzzzzzzzzzzzzzzt_, jzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.toInterval(context, jzzzzzzzzzzzzzzzzzzzzzzzx_ as object);
            CqlDateTime jzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.End(jzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Interval(jzzzzzzzzzzzzzzzzzzzzzzzv_, jzzzzzzzzzzzzzzzzzzzzzzzz_, true, true);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzzzzzzzzzzzzzzzp_, kzzzzzzzzzzzzzzzzzzzzzzza_, "day");
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzzzzzzzzzzzzzd_ as object);
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.End(kzzzzzzzzzzzzzzzzzzzzzzze_);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Not((bool?)(kzzzzzzzzzzzzzzzzzzzzzzzf_ is null));
            bool? kzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzzb_, kzzzzzzzzzzzzzzzzzzzzzzzg_);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzzzzzzo_, kzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlDateTime kzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.ConvertDateToDateTime(tuple_eoahgtwwdfqijhcjzqnvidvuo?.FollowupKCCQ12Date);
            CqlDate kzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.DateFrom(kzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlDate kzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.DateFrom(jzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlQuantity kzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Quantity(30m, "days");
            CqlDate kzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Add(kzzzzzzzzzzzzzzzzzzzzzzzm_, kzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlDate kzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.DateFrom(jzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlDate kzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Add(kzzzzzzzzzzzzzzzzzzzzzzzq_, jzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDate> kzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.Interval(kzzzzzzzzzzzzzzzzzzzzzzzo_, kzzzzzzzzzzzzzzzzzzzzzzzs_, true, true);
            bool? kzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.In<CqlDate>(kzzzzzzzzzzzzzzzzzzzzzzzk_, kzzzzzzzzzzzzzzzzzzzzzzzt_, "day");
            bool? kzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzzzzzzi_, kzzzzzzzzzzzzzzzzzzzzzzzu_);

            return kzzzzzzzzzzzzzzzzzzzzzzzv_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQ12Date, CqlDate FollowupKCCQ12Date)?> jzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Where<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQ12Date, CqlDate FollowupKCCQ12Date)?>(izzzzzzzzzzzzzzzzzzzzzzzy_, izzzzzzzzzzzzzzzzzzzzzzzz_);
        Encounter jzzzzzzzzzzzzzzzzzzzzzzzb_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQ12Date, CqlDate FollowupKCCQ12Date)? tuple_eoahgtwwdfqijhcjzqnvidvuo) =>
            tuple_eoahgtwwdfqijhcjzqnvidvuo?.ValidEncounters;
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Select<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQ12Date, CqlDate FollowupKCCQ12Date)?, Encounter>(jzzzzzzzzzzzzzzzzzzzzzzza_, jzzzzzzzzzzzzzzzzzzzzzzzb_);
        IEnumerable<Encounter> jzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Distinct<Encounter>(jzzzzzzzzzzzzzzzzzzzzzzzc_);
        bool? jzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.Exists<Encounter>(jzzzzzzzzzzzzzzzzzzzzzzzd_);

        return jzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Date KCCQ Domain Assessment Completed")]
    public IEnumerable<CqlDate> Date_KCCQ_Domain_Assessment_Completed(CqlContext context)
    {
        CqlCode kzzzzzzzzzzzzzzzzzzzzzzzw_ = this.Quality_of_life_score__KCCQ_(context);
        IEnumerable<CqlCode> kzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.ToList<CqlCode>(kzzzzzzzzzzzzzzzzzzzzzzzw_);
        IEnumerable<Observation> kzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, kzzzzzzzzzzzzzzzzzzzzzzzx_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> kzzzzzzzzzzzzzzzzzzzzzzzz_ = Status_1_8_000.Instance.isAssessmentPerformed(context, kzzzzzzzzzzzzzzzzzzzzzzzy_);
        CqlCode lzzzzzzzzzzzzzzzzzzzzzzza_ = this.Symptom_stability_score__KCCQ_(context);
        IEnumerable<CqlCode> lzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.ToList<CqlCode>(lzzzzzzzzzzzzzzzzzzzzzzza_);
        IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, lzzzzzzzzzzzzzzzzzzzzzzzb_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzzzzzzd_ = Status_1_8_000.Instance.isAssessmentPerformed(context, lzzzzzzzzzzzzzzzzzzzzzzzc_);
        CqlCode lzzzzzzzzzzzzzzzzzzzzzzze_ = this.Self_efficacy_score__KCCQ_(context);
        IEnumerable<CqlCode> lzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.ToList<CqlCode>(lzzzzzzzzzzzzzzzzzzzzzzze_);
        IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, lzzzzzzzzzzzzzzzzzzzzzzzf_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzzzzzzh_ = Status_1_8_000.Instance.isAssessmentPerformed(context, lzzzzzzzzzzzzzzzzzzzzzzzg_);
        CqlCode lzzzzzzzzzzzzzzzzzzzzzzzi_ = this.Total_symptom_score__KCCQ_(context);
        IEnumerable<CqlCode> lzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.ToList<CqlCode>(lzzzzzzzzzzzzzzzzzzzzzzzi_);
        IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, lzzzzzzzzzzzzzzzzzzzzzzzj_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzzzzzzl_ = Status_1_8_000.Instance.isAssessmentPerformed(context, lzzzzzzzzzzzzzzzzzzzzzzzk_);
        CqlCode lzzzzzzzzzzzzzzzzzzzzzzzm_ = this.Physical_limitation_score__KCCQ_(context);
        IEnumerable<CqlCode> lzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.ToList<CqlCode>(lzzzzzzzzzzzzzzzzzzzzzzzm_);
        IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, lzzzzzzzzzzzzzzzzzzzzzzzn_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzzzzzzp_ = Status_1_8_000.Instance.isAssessmentPerformed(context, lzzzzzzzzzzzzzzzzzzzzzzzo_);
        CqlCode lzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Social_limitation_score__KCCQ_(context);
        IEnumerable<CqlCode> lzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ToList<CqlCode>(lzzzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, lzzzzzzzzzzzzzzzzzzzzzzzr_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzzzzzzt_ = Status_1_8_000.Instance.isAssessmentPerformed(context, lzzzzzzzzzzzzzzzzzzzzzzzs_);
        IEnumerable<ValueTuple<Observation, Observation, Observation, Observation, Observation, Observation>> lzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.CrossJoin<Observation, Observation, Observation, Observation, Observation, Observation>(kzzzzzzzzzzzzzzzzzzzzzzzz_, lzzzzzzzzzzzzzzzzzzzzzzzd_, lzzzzzzzzzzzzzzzzzzzzzzzh_, lzzzzzzzzzzzzzzzzzzzzzzzl_, lzzzzzzzzzzzzzzzzzzzzzzzp_, lzzzzzzzzzzzzzzzzzzzzzzzt_);
        (CqlTupleMetadata, Observation KCCQLifeQuality, Observation KCCQSymptomStability, Observation KCCQSelfEfficacy, Observation KCCQSymptoms, Observation KCCQPhysicalLimits, Observation KCCQSocialLimits)? lzzzzzzzzzzzzzzzzzzzzzzzv_(ValueTuple<Observation, Observation, Observation, Observation, Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation KCCQLifeQuality, Observation KCCQSymptomStability, Observation KCCQSelfEfficacy, Observation KCCQSymptoms, Observation KCCQPhysicalLimits, Observation KCCQSocialLimits)? mzzzzzzzzzzzzzzzzzzzzzzzc_ = (CqlTupleMetadata_BbPMcXSJeOeGdRcaZWGYPhGBL, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3, _valueTuple.Item4, _valueTuple.Item5, _valueTuple.Item6);

            return mzzzzzzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<(CqlTupleMetadata, Observation KCCQLifeQuality, Observation KCCQSymptomStability, Observation KCCQSelfEfficacy, Observation KCCQSymptoms, Observation KCCQPhysicalLimits, Observation KCCQSocialLimits)?> lzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Select<ValueTuple<Observation, Observation, Observation, Observation, Observation, Observation>, (CqlTupleMetadata, Observation KCCQLifeQuality, Observation KCCQSymptomStability, Observation KCCQSelfEfficacy, Observation KCCQSymptoms, Observation KCCQPhysicalLimits, Observation KCCQSocialLimits)?>(lzzzzzzzzzzzzzzzzzzzzzzzu_, lzzzzzzzzzzzzzzzzzzzzzzzv_);
        bool? lzzzzzzzzzzzzzzzzzzzzzzzx_((CqlTupleMetadata, Observation KCCQLifeQuality, Observation KCCQSymptomStability, Observation KCCQSelfEfficacy, Observation KCCQSymptoms, Observation KCCQPhysicalLimits, Observation KCCQSocialLimits)? tuple_etfcawdpmcqfbnayqdmdqqsdn)
        {
            DataType mzzzzzzzzzzzzzzzzzzzzzzzd_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQLifeQuality?.Effective;
            object mzzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, mzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlDate mzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.DateFrom(mzzzzzzzzzzzzzzzzzzzzzzzg_);
            DataType mzzzzzzzzzzzzzzzzzzzzzzzi_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQSymptomStability?.Effective;
            object mzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.toInterval(context, mzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlDate mzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.DateFrom(mzzzzzzzzzzzzzzzzzzzzzzzl_);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.SameAs(mzzzzzzzzzzzzzzzzzzzzzzzh_, mzzzzzzzzzzzzzzzzzzzzzzzm_, "day");
            DataType mzzzzzzzzzzzzzzzzzzzzzzzo_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQSymptomStability?.Value;
            object mzzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzo_);
            bool? mzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Not((bool?)(mzzzzzzzzzzzzzzzzzzzzzzzp_ is null));
            bool? mzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzzzzn_, mzzzzzzzzzzzzzzzzzzzzzzzq_);
            object mzzzzzzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, mzzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlDateTime mzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlDate mzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.DateFrom(mzzzzzzzzzzzzzzzzzzzzzzzv_);
            DataType mzzzzzzzzzzzzzzzzzzzzzzzx_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQSelfEfficacy?.Effective;
            object mzzzzzzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, mzzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Start(mzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlDate nzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.DateFrom(nzzzzzzzzzzzzzzzzzzzzzzza_);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.SameAs(mzzzzzzzzzzzzzzzzzzzzzzzw_, nzzzzzzzzzzzzzzzzzzzzzzzb_, "day");
            bool? nzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzzzzzzr_, nzzzzzzzzzzzzzzzzzzzzzzzc_);
            DataType nzzzzzzzzzzzzzzzzzzzzzzze_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQSelfEfficacy?.Value;
            object nzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzze_);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Not((bool?)(nzzzzzzzzzzzzzzzzzzzzzzzf_ is null));
            bool? nzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzd_, nzzzzzzzzzzzzzzzzzzzzzzzg_);
            object nzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlDate nzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.DateFrom(nzzzzzzzzzzzzzzzzzzzzzzzl_);
            DataType nzzzzzzzzzzzzzzzzzzzzzzzn_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQSymptoms?.Effective;
            object nzzzzzzzzzzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlDateTime nzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlDate nzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.DateFrom(nzzzzzzzzzzzzzzzzzzzzzzzq_);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.SameAs(nzzzzzzzzzzzzzzzzzzzzzzzm_, nzzzzzzzzzzzzzzzzzzzzzzzr_, "day");
            bool? nzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzh_, nzzzzzzzzzzzzzzzzzzzzzzzs_);
            DataType nzzzzzzzzzzzzzzzzzzzzzzzu_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQSymptoms?.Value;
            object nzzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzzzzzzu_);
            bool? nzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Not((bool?)(nzzzzzzzzzzzzzzzzzzzzzzzv_ is null));
            bool? nzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzt_, nzzzzzzzzzzzzzzzzzzzzzzzw_);
            object nzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzzzzzzzzzzzzzzzz_);
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzzzzza_);
            CqlDate ozzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.DateFrom(ozzzzzzzzzzzzzzzzzzzzzzzb_);
            DataType ozzzzzzzzzzzzzzzzzzzzzzzd_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQPhysicalLimits?.Effective;
            object ozzzzzzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, ozzzzzzzzzzzzzzzzzzzzzzze_);
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzzzzzf_);
            CqlDate ozzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.DateFrom(ozzzzzzzzzzzzzzzzzzzzzzzg_);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.SameAs(ozzzzzzzzzzzzzzzzzzzzzzzc_, ozzzzzzzzzzzzzzzzzzzzzzzh_, "day");
            bool? ozzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzzzzzzx_, ozzzzzzzzzzzzzzzzzzzzzzzi_);
            DataType ozzzzzzzzzzzzzzzzzzzzzzzk_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQPhysicalLimits?.Value;
            object ozzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzk_);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Not((bool?)(ozzzzzzzzzzzzzzzzzzzzzzzl_ is null));
            bool? ozzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzj_, ozzzzzzzzzzzzzzzzzzzzzzzm_);
            object ozzzzzzzzzzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, mzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.toInterval(context, ozzzzzzzzzzzzzzzzzzzzzzzp_);
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzzzzzq_);
            CqlDate ozzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.DateFrom(ozzzzzzzzzzzzzzzzzzzzzzzr_);
            DataType ozzzzzzzzzzzzzzzzzzzzzzzt_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQSocialLimits?.Effective;
            object ozzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, ozzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlDateTime ozzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(ozzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlDate ozzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.DateFrom(ozzzzzzzzzzzzzzzzzzzzzzzw_);
            bool? ozzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.SameAs(ozzzzzzzzzzzzzzzzzzzzzzzs_, ozzzzzzzzzzzzzzzzzzzzzzzx_, "day");
            bool? ozzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzn_, ozzzzzzzzzzzzzzzzzzzzzzzy_);
            DataType pzzzzzzzzzzzzzzzzzzzzzzza_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQSocialLimits?.Value;
            object pzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzza_);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Not((bool?)(pzzzzzzzzzzzzzzzzzzzzzzzb_ is null));
            bool? pzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzzzzzzz_, pzzzzzzzzzzzzzzzzzzzzzzzc_);
            DataType pzzzzzzzzzzzzzzzzzzzzzzze_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQLifeQuality?.Value;
            object pzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzze_);
            bool? pzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Not((bool?)(pzzzzzzzzzzzzzzzzzzzzzzzf_ is null));
            bool? pzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(pzzzzzzzzzzzzzzzzzzzzzzzd_, pzzzzzzzzzzzzzzzzzzzzzzzg_);

            return pzzzzzzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<(CqlTupleMetadata, Observation KCCQLifeQuality, Observation KCCQSymptomStability, Observation KCCQSelfEfficacy, Observation KCCQSymptoms, Observation KCCQPhysicalLimits, Observation KCCQSocialLimits)?> lzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<(CqlTupleMetadata, Observation KCCQLifeQuality, Observation KCCQSymptomStability, Observation KCCQSelfEfficacy, Observation KCCQSymptoms, Observation KCCQPhysicalLimits, Observation KCCQSocialLimits)?>(lzzzzzzzzzzzzzzzzzzzzzzzw_, lzzzzzzzzzzzzzzzzzzzzzzzx_);
        CqlDate lzzzzzzzzzzzzzzzzzzzzzzzz_((CqlTupleMetadata, Observation KCCQLifeQuality, Observation KCCQSymptomStability, Observation KCCQSelfEfficacy, Observation KCCQSymptoms, Observation KCCQPhysicalLimits, Observation KCCQSocialLimits)? tuple_etfcawdpmcqfbnayqdmdqqsdn)
        {
            DataType pzzzzzzzzzzzzzzzzzzzzzzzi_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQLifeQuality?.Effective;
            object pzzzzzzzzzzzzzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.toInterval(context, pzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlDateTime pzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Start(pzzzzzzzzzzzzzzzzzzzzzzzk_);
            CqlDate pzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.DateFrom(pzzzzzzzzzzzzzzzzzzzzzzzl_);

            return pzzzzzzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<CqlDate> mzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Select<(CqlTupleMetadata, Observation KCCQLifeQuality, Observation KCCQSymptomStability, Observation KCCQSelfEfficacy, Observation KCCQSymptoms, Observation KCCQPhysicalLimits, Observation KCCQSocialLimits)?, CqlDate>(lzzzzzzzzzzzzzzzzzzzzzzzy_, lzzzzzzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<CqlDate> mzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Distinct<CqlDate>(mzzzzzzzzzzzzzzzzzzzzzzza_);

        return mzzzzzzzzzzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Has Encounter with Initial and Follow Up KCCQ Domain Score Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_KCCQ_Domain_Score_Assessments(CqlContext context)
    {
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Qualifying_Encounters(context);
        IEnumerable<CqlDate> pzzzzzzzzzzzzzzzzzzzzzzzo_ = this.Date_KCCQ_Domain_Assessment_Completed(context);
        IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> pzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(pzzzzzzzzzzzzzzzzzzzzzzzn_, pzzzzzzzzzzzzzzzzzzzzzzzo_, pzzzzzzzzzzzzzzzzzzzzzzzo_);
        (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQAssessmentDate, CqlDate FollowupKCCQAssessmentDate)? pzzzzzzzzzzzzzzzzzzzzzzzr_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQAssessmentDate, CqlDate FollowupKCCQAssessmentDate)? pzzzzzzzzzzzzzzzzzzzzzzzz_ = (CqlTupleMetadata_HEFWLcHhCNCOQegEOfjWTXiGN, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return pzzzzzzzzzzzzzzzzzzzzzzzz_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQAssessmentDate, CqlDate FollowupKCCQAssessmentDate)?> pzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQAssessmentDate, CqlDate FollowupKCCQAssessmentDate)?>(pzzzzzzzzzzzzzzzzzzzzzzzq_, pzzzzzzzzzzzzzzzzzzzzzzzr_);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzt_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQAssessmentDate, CqlDate FollowupKCCQAssessmentDate)? tuple_hrluhbcfcsvnvrrnjajahdcea)
        {
            Period qzzzzzzzzzzzzzzzzzzzzzzza_ = tuple_hrluhbcfcsvnvrrnjajahdcea?.ValidEncounters?.Period;
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, qzzzzzzzzzzzzzzzzzzzzzzzb_ as object);
            CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.End(qzzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzze_ = this.Measurement_Period(context);
            CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.End(qzzzzzzzzzzzzzzzzzzzzzzze_);
            CqlQuantity qzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Quantity(180m, "days");
            CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Subtract(qzzzzzzzzzzzzzzzzzzzzzzzf_, qzzzzzzzzzzzzzzzzzzzzzzzg_);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.SameOrBefore(qzzzzzzzzzzzzzzzzzzzzzzzd_, qzzzzzzzzzzzzzzzzzzzzzzzh_, "day");
            CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.ConvertDateToDateTime(tuple_hrluhbcfcsvnvrrnjajahdcea?.InitialKCCQAssessmentDate);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.toInterval(context, qzzzzzzzzzzzzzzzzzzzzzzzl_ as object);
            CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.End(qzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlQuantity qzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Quantity(14m, "days");
            CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Subtract(qzzzzzzzzzzzzzzzzzzzzzzzn_, qzzzzzzzzzzzzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.toInterval(context, qzzzzzzzzzzzzzzzzzzzzzzzr_ as object);
            CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.End(qzzzzzzzzzzzzzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Interval(qzzzzzzzzzzzzzzzzzzzzzzzp_, qzzzzzzzzzzzzzzzzzzzzzzzt_, true, true);
            bool? qzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.In<CqlDateTime>(qzzzzzzzzzzzzzzzzzzzzzzzj_, qzzzzzzzzzzzzzzzzzzzzzzzu_, "day");
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.toInterval(context, qzzzzzzzzzzzzzzzzzzzzzzzx_ as object);
            CqlDateTime qzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.End(qzzzzzzzzzzzzzzzzzzzzzzzy_);
            bool? rzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Not((bool?)(qzzzzzzzzzzzzzzzzzzzzzzzz_ is null));
            bool? rzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzzv_, rzzzzzzzzzzzzzzzzzzzzzzza_);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzzzzzzi_, rzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlDateTime rzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ConvertDateToDateTime(tuple_hrluhbcfcsvnvrrnjajahdcea?.FollowupKCCQAssessmentDate);
            CqlDate rzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.DateFrom(rzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlDate rzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.DateFrom(qzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlQuantity rzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Quantity(30m, "days");
            CqlDate rzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Add(rzzzzzzzzzzzzzzzzzzzzzzzg_, rzzzzzzzzzzzzzzzzzzzzzzzh_);
            CqlDate rzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.DateFrom(qzzzzzzzzzzzzzzzzzzzzzzzj_);
            CqlDate rzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Add(rzzzzzzzzzzzzzzzzzzzzzzzk_, qzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDate> rzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Interval(rzzzzzzzzzzzzzzzzzzzzzzzi_, rzzzzzzzzzzzzzzzzzzzzzzzm_, true, true);
            bool? rzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.In<CqlDate>(rzzzzzzzzzzzzzzzzzzzzzzze_, rzzzzzzzzzzzzzzzzzzzzzzzn_, "day");
            bool? rzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzzzzzzc_, rzzzzzzzzzzzzzzzzzzzzzzzo_);

            return rzzzzzzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQAssessmentDate, CqlDate FollowupKCCQAssessmentDate)?> pzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQAssessmentDate, CqlDate FollowupKCCQAssessmentDate)?>(pzzzzzzzzzzzzzzzzzzzzzzzs_, pzzzzzzzzzzzzzzzzzzzzzzzt_);
        Encounter pzzzzzzzzzzzzzzzzzzzzzzzv_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQAssessmentDate, CqlDate FollowupKCCQAssessmentDate)? tuple_hrluhbcfcsvnvrrnjajahdcea) =>
            tuple_hrluhbcfcsvnvrrnjajahdcea?.ValidEncounters;
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Select<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQAssessmentDate, CqlDate FollowupKCCQAssessmentDate)?, Encounter>(pzzzzzzzzzzzzzzzzzzzzzzzu_, pzzzzzzzzzzzzzzzzzzzzzzzv_);
        IEnumerable<Encounter> pzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Distinct<Encounter>(pzzzzzzzzzzzzzzzzzzzzzzzw_);
        bool? pzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Exists<Encounter>(pzzzzzzzzzzzzzzzzzzzzzzzx_);

        return pzzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Date KCCQ Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_KCCQ_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode rzzzzzzzzzzzzzzzzzzzzzzzq_ = this.Overall_summary_score__KCCQ_(context);
        IEnumerable<CqlCode> rzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.ToList<CqlCode>(rzzzzzzzzzzzzzzzzzzzzzzzq_);
        IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, rzzzzzzzzzzzzzzzzzzzzzzzr_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzzzzzt_ = Status_1_8_000.Instance.isAssessmentPerformed(context, rzzzzzzzzzzzzzzzzzzzzzzzs_);
        bool? rzzzzzzzzzzzzzzzzzzzzzzzu_(Observation KCCQSummaryScore)
        {
            DataType rzzzzzzzzzzzzzzzzzzzzzzzz_ = KCCQSummaryScore?.Value;
            object szzzzzzzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzzzzzzzzzzzzzz_);
            bool? szzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Not((bool?)(szzzzzzzzzzzzzzzzzzzzzzza_ is null));

            return szzzzzzzzzzzzzzzzzzzzzzzb_;
        };
        IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Where<Observation>(rzzzzzzzzzzzzzzzzzzzzzzzt_, rzzzzzzzzzzzzzzzzzzzzzzzu_);
        CqlDate rzzzzzzzzzzzzzzzzzzzzzzzw_(Observation KCCQSummaryScore)
        {
            DataType szzzzzzzzzzzzzzzzzzzzzzzc_ = KCCQSummaryScore?.Effective;
            object szzzzzzzzzzzzzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzzzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.toInterval(context, szzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzf_ = context.Operators.Start(szzzzzzzzzzzzzzzzzzzzzzze_);
            CqlDate szzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.DateFrom(szzzzzzzzzzzzzzzzzzzzzzzf_);

            return szzzzzzzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<CqlDate> rzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Select<Observation, CqlDate>(rzzzzzzzzzzzzzzzzzzzzzzzv_, rzzzzzzzzzzzzzzzzzzzzzzzw_);
        IEnumerable<CqlDate> rzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Distinct<CqlDate>(rzzzzzzzzzzzzzzzzzzzzzzzx_);

        return rzzzzzzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Has Encounter with Initial and Follow Up KCCQ Total Score Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_KCCQ_Total_Score_Assessments(CqlContext context)
    {
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzzzh_ = this.Qualifying_Encounters(context);
        IEnumerable<CqlDate> szzzzzzzzzzzzzzzzzzzzzzzi_ = this.Date_KCCQ_Total_Assessment_Completed(context);
        IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> szzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(szzzzzzzzzzzzzzzzzzzzzzzh_, szzzzzzzzzzzzzzzzzzzzzzzi_, szzzzzzzzzzzzzzzzzzzzzzzi_);
        (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQTotalScore, CqlDate FollowupKCCQTotalScore)? szzzzzzzzzzzzzzzzzzzzzzzl_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQTotalScore, CqlDate FollowupKCCQTotalScore)? szzzzzzzzzzzzzzzzzzzzzzzt_ = (CqlTupleMetadata_DggZKjEbQUfLADMDMBeASLDR, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return szzzzzzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQTotalScore, CqlDate FollowupKCCQTotalScore)?> szzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQTotalScore, CqlDate FollowupKCCQTotalScore)?>(szzzzzzzzzzzzzzzzzzzzzzzk_, szzzzzzzzzzzzzzzzzzzzzzzl_);
        bool? szzzzzzzzzzzzzzzzzzzzzzzn_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQTotalScore, CqlDate FollowupKCCQTotalScore)? tuple_dgrojeekdvizsvyisepdjhjgj)
        {
            Period szzzzzzzzzzzzzzzzzzzzzzzu_ = tuple_dgrojeekdvizsvyisepdjhjgj?.ValidEncounters?.Period;
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.toInterval(context, szzzzzzzzzzzzzzzzzzzzzzzv_ as object);
            CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.End(szzzzzzzzzzzzzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzzzzzzzzzzzzy_ = this.Measurement_Period(context);
            CqlDateTime szzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.End(szzzzzzzzzzzzzzzzzzzzzzzy_);
            CqlQuantity tzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Quantity(180m, "days");
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Subtract(szzzzzzzzzzzzzzzzzzzzzzzz_, tzzzzzzzzzzzzzzzzzzzzzzza_);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.SameOrBefore(szzzzzzzzzzzzzzzzzzzzzzzx_, tzzzzzzzzzzzzzzzzzzzzzzzb_, "day");
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.ConvertDateToDateTime(tuple_dgrojeekdvizsvyisepdjhjgj?.InitialKCCQTotalScore);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.toInterval(context, tzzzzzzzzzzzzzzzzzzzzzzzf_ as object);
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.End(tzzzzzzzzzzzzzzzzzzzzzzzg_);
            CqlQuantity tzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Quantity(14m, "days");
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Subtract(tzzzzzzzzzzzzzzzzzzzzzzzh_, tzzzzzzzzzzzzzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.toInterval(context, tzzzzzzzzzzzzzzzzzzzzzzzl_ as object);
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.End(tzzzzzzzzzzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Interval(tzzzzzzzzzzzzzzzzzzzzzzzj_, tzzzzzzzzzzzzzzzzzzzzzzzn_, true, true);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.In<CqlDateTime>(tzzzzzzzzzzzzzzzzzzzzzzzd_, tzzzzzzzzzzzzzzzzzzzzzzzo_, "day");
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, szzzzzzzzzzzzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.toInterval(context, tzzzzzzzzzzzzzzzzzzzzzzzr_ as object);
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzt_ = context.Operators.End(tzzzzzzzzzzzzzzzzzzzzzzzs_);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Not((bool?)(tzzzzzzzzzzzzzzzzzzzzzzzt_ is null));
            bool? tzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzzp_, tzzzzzzzzzzzzzzzzzzzzzzzu_);
            bool? tzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzzc_, tzzzzzzzzzzzzzzzzzzzzzzzv_);
            CqlDateTime tzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.ConvertDateToDateTime(tuple_dgrojeekdvizsvyisepdjhjgj?.FollowupKCCQTotalScore);
            CqlDate tzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.DateFrom(tzzzzzzzzzzzzzzzzzzzzzzzx_);
            CqlDate uzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.DateFrom(tzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlQuantity uzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Quantity(30m, "days");
            CqlDate uzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Add(uzzzzzzzzzzzzzzzzzzzzzzza_, uzzzzzzzzzzzzzzzzzzzzzzzb_);
            CqlDate uzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.DateFrom(tzzzzzzzzzzzzzzzzzzzzzzzd_);
            CqlDate uzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.Add(uzzzzzzzzzzzzzzzzzzzzzzze_, tzzzzzzzzzzzzzzzzzzzzzzza_);
            CqlInterval<CqlDate> uzzzzzzzzzzzzzzzzzzzzzzzh_ = context.Operators.Interval(uzzzzzzzzzzzzzzzzzzzzzzzc_, uzzzzzzzzzzzzzzzzzzzzzzzg_, true, true);
            bool? uzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.In<CqlDate>(tzzzzzzzzzzzzzzzzzzzzzzzy_, uzzzzzzzzzzzzzzzzzzzzzzzh_, "day");
            bool? uzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(tzzzzzzzzzzzzzzzzzzzzzzzw_, uzzzzzzzzzzzzzzzzzzzzzzzi_);

            return uzzzzzzzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQTotalScore, CqlDate FollowupKCCQTotalScore)?> szzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Where<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQTotalScore, CqlDate FollowupKCCQTotalScore)?>(szzzzzzzzzzzzzzzzzzzzzzzm_, szzzzzzzzzzzzzzzzzzzzzzzn_);
        Encounter szzzzzzzzzzzzzzzzzzzzzzzp_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQTotalScore, CqlDate FollowupKCCQTotalScore)? tuple_dgrojeekdvizsvyisepdjhjgj) =>
            tuple_dgrojeekdvizsvyisepdjhjgj?.ValidEncounters;
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Select<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQTotalScore, CqlDate FollowupKCCQTotalScore)?, Encounter>(szzzzzzzzzzzzzzzzzzzzzzzo_, szzzzzzzzzzzzzzzzzzzzzzzp_);
        IEnumerable<Encounter> szzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Distinct<Encounter>(szzzzzzzzzzzzzzzzzzzzzzzq_);
        bool? szzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Exists<Encounter>(szzzzzzzzzzzzzzzzzzzzzzzr_);

        return szzzzzzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? uzzzzzzzzzzzzzzzzzzzzzzzk_ = this.Has_Encounter_with_Initial_and_Follow_Up_PROMIS10_Assessments(context);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzl_ = this.Has_Encounter_with_Initial_and_Follow_Up_PROMIS29_Assessments(context);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzm_ = context.Operators.Or(uzzzzzzzzzzzzzzzzzzzzzzzk_, uzzzzzzzzzzzzzzzzzzzzzzzl_);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzn_ = this.Has_Encounter_with_Initial_and_Follow_Up_VR12_Oblique_Assessments(context);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzo_ = context.Operators.Or(uzzzzzzzzzzzzzzzzzzzzzzzm_, uzzzzzzzzzzzzzzzzzzzzzzzn_);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzp_ = this.Has_Encounter_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments(context);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.Or(uzzzzzzzzzzzzzzzzzzzzzzzo_, uzzzzzzzzzzzzzzzzzzzzzzzp_);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzr_ = this.Has_Encounter_with_Initial_and_Follow_Up_VR36_Oblique_Assessments(context);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Or(uzzzzzzzzzzzzzzzzzzzzzzzq_, uzzzzzzzzzzzzzzzzzzzzzzzr_);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzt_ = this.Has_Encounter_with_Initial_and_Follow_Up_VR36_Orthogonal_Assessments(context);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Or(uzzzzzzzzzzzzzzzzzzzzzzzs_, uzzzzzzzzzzzzzzzzzzzzzzzt_);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzv_ = this.Has_Encounter_with_Initial_and_Follow_Up_MLHFQ_Assessments(context);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Or(uzzzzzzzzzzzzzzzzzzzzzzzu_, uzzzzzzzzzzzzzzzzzzzzzzzv_);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzx_ = this.Has_Encounter_with_Initial_and_Follow_Up_KCCQ12_Assessments(context);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Or(uzzzzzzzzzzzzzzzzzzzzzzzw_, uzzzzzzzzzzzzzzzzzzzzzzzx_);
        bool? uzzzzzzzzzzzzzzzzzzzzzzzz_ = this.Has_Encounter_with_Initial_and_Follow_Up_KCCQ_Domain_Score_Assessments(context);
        bool? vzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Or(uzzzzzzzzzzzzzzzzzzzzzzzy_, uzzzzzzzzzzzzzzzzzzzzzzzz_);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzb_ = this.Has_Encounter_with_Initial_and_Follow_Up_KCCQ_Total_Score_Assessments(context);
        bool? vzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Or(vzzzzzzzzzzzzzzzzzzzzzzza_, vzzzzzzzzzzzzzzzzzzzzzzzb_);

        return vzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_BbPMcXSJeOeGdRcaZWGYPhGBL = new(
        [typeof(Observation), typeof(Observation), typeof(Observation), typeof(Observation), typeof(Observation), typeof(Observation)],
        ["KCCQLifeQuality", "KCCQSymptomStability", "KCCQSelfEfficacy", "KCCQSymptoms", "KCCQPhysicalLimits", "KCCQSocialLimits"]);

    private static CqlTupleMetadata CqlTupleMetadata_BFZHWdOOROjSjFSECHcQiaZZZ = new(
        [typeof(Encounter), typeof(CqlDate), typeof(CqlDate)],
        ["ValidEncounters", "InitialVR36OrthogonalDate", "FollowupVR36OrthogonalDate"]);

    private static CqlTupleMetadata CqlTupleMetadata_BGYjYGLNPKWAZTBCVAdLDDTMj = new(
        [typeof(Encounter), typeof(CqlDate), typeof(CqlDate)],
        ["ValidEncounters", "InitialPROMIS10Date", "FollowupPROMIS10Date"]);

    private static CqlTupleMetadata CqlTupleMetadata_CcaWSNDiVeaLebVKKWWWiBcEU = new(
        [typeof(Encounter), typeof(CqlDate), typeof(CqlDate)],
        ["ValidEncounters", "InitialMLHFQDate", "FollowupMLHFQDate"]);

    private static CqlTupleMetadata CqlTupleMetadata_DbNMMZBTISSRTNdiShceSFVih = new(
        [typeof(Encounter), typeof(Encounter)],
        ["OfficeVisit1", "OfficeVisit2"]);

    private static CqlTupleMetadata CqlTupleMetadata_DBUJFOVGBcbhIQPWARNQHKUaX = new(
        [typeof(Observation), typeof(Observation), typeof(Observation), typeof(Observation), typeof(Observation), typeof(Observation), typeof(Observation)],
        ["Promis29Sleep", "Promis29SocialRoles", "Promis29Physical", "Promis29Pain", "Promis29Fatigue", "Promis29Depression", "Promis29Anxiety"]);

    private static CqlTupleMetadata CqlTupleMetadata_DDTAOdcFieSJbGgRLLZPYbGQb = new(
        [typeof(Observation), typeof(Observation)],
        ["PROMIS10MentalScore", "PROMIS10PhysicalScore"]);

    private static CqlTupleMetadata CqlTupleMetadata_DFKXORghhYafccUSbQaMfNTDj = new(
        [typeof(Observation), typeof(Observation)],
        ["KCCQ12Item", "KCCQ12Summary"]);

    private static CqlTupleMetadata CqlTupleMetadata_DggZKjEbQUfLADMDMBeASLDR = new(
        [typeof(Encounter), typeof(CqlDate), typeof(CqlDate)],
        ["ValidEncounters", "InitialKCCQTotalScore", "FollowupKCCQTotalScore"]);

    private static CqlTupleMetadata CqlTupleMetadata_DSZKEYVbCINNIeAQiZdVaEJhG = new(
        [typeof(Encounter), typeof(CqlDate), typeof(CqlDate)],
        ["ValidEncounters", "InitialPROMIS29Date", "FollowupPROMIS29Date"]);

    private static CqlTupleMetadata CqlTupleMetadata_DUcFTCLcQEWDGGQdFCWTHFaUK = new(
        [typeof(Observation), typeof(Observation)],
        ["VR36MentalAssessment", "VR36PhysicalAssessment"]);

    private static CqlTupleMetadata CqlTupleMetadata_EBLWeAeedHPAfOJXKPZJKSCUf = new(
        [typeof(Observation), typeof(Observation)],
        ["MLHFQPhysical", "MLHFQEmotional"]);

    private static CqlTupleMetadata CqlTupleMetadata_EQQLFFBVIbLIQLiZDNfeYdMU = new(
        [typeof(Encounter), typeof(CqlDate), typeof(CqlDate)],
        ["ValidEncounters", "InitialKCCQ12Date", "FollowupKCCQ12Date"]);

    private static CqlTupleMetadata CqlTupleMetadata_FQKGdEYLiDFGMNAUAMETIHUQT = new(
        [typeof(Encounter), typeof(CqlDate), typeof(CqlDate)],
        ["ValidEncounters", "InitialVR12ObliqueDate", "FollowupVR12ObliqueDate"]);

    private static CqlTupleMetadata CqlTupleMetadata_GAdRFKRaHUUGJcVHWQWRUjhRH = new(
        [typeof(Observation), typeof(Observation)],
        ["VR12MentalAssessment", "VR12PhysicalAssessment"]);

    private static CqlTupleMetadata CqlTupleMetadata_HEFWLcHhCNCOQegEOfjWTXiGN = new(
        [typeof(Encounter), typeof(CqlDate), typeof(CqlDate)],
        ["ValidEncounters", "InitialKCCQAssessmentDate", "FollowupKCCQAssessmentDate"]);

    private static CqlTupleMetadata CqlTupleMetadata_HQfcMfhQUSTNYMWSgJHiFeahQ = new(
        [typeof(Encounter), typeof(CqlDate), typeof(CqlDate)],
        ["ValidEncounters", "InitialVR36ObliqueDate", "FollowupVR36ObliqueDate"]);

    private static CqlTupleMetadata CqlTupleMetadata_HSSAQEFQAOXLjUcOKGgicELWB = new(
        [typeof(Encounter), typeof(CqlDate), typeof(CqlDate)],
        ["ValidEncounters", "InitialVR12OrthogonalDate", "FollowupVR12OrthogonalDate"]);

    #endregion CqlTupleMetadata Properties

}
