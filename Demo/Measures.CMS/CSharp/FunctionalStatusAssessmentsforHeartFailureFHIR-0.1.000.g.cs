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
    private static readonly CqlCode _Emotional_score__MLHFQ_ = new CqlCode("85609-6", "http://loinc.org");

    [CqlCodeDefinition("Kansas City Cardiomyopathy Questionnaire - 12 item [KCCQ-12]", codeId: "86923-0", codeSystem: "http://loinc.org")]
    public CqlCode Kansas_City_Cardiomyopathy_Questionnaire___12_item__KCCQ_12_(CqlContext _) => _Kansas_City_Cardiomyopathy_Questionnaire___12_item__KCCQ_12_;
    private static readonly CqlCode _Kansas_City_Cardiomyopathy_Questionnaire___12_item__KCCQ_12_ = new CqlCode("86923-0", "http://loinc.org");

    [CqlCodeDefinition("Overall summary score [KCCQ-12]", codeId: "86924-8", codeSystem: "http://loinc.org")]
    public CqlCode Overall_summary_score__KCCQ_12_(CqlContext _) => _Overall_summary_score__KCCQ_12_;
    private static readonly CqlCode _Overall_summary_score__KCCQ_12_ = new CqlCode("86924-8", "http://loinc.org");

    [CqlCodeDefinition("Overall summary score [KCCQ]", codeId: "71940-1", codeSystem: "http://loinc.org")]
    public CqlCode Overall_summary_score__KCCQ_(CqlContext _) => _Overall_summary_score__KCCQ_;
    private static readonly CqlCode _Overall_summary_score__KCCQ_ = new CqlCode("71940-1", "http://loinc.org");

    [CqlCodeDefinition("Physical limitation score [KCCQ]", codeId: "72195-1", codeSystem: "http://loinc.org")]
    public CqlCode Physical_limitation_score__KCCQ_(CqlContext _) => _Physical_limitation_score__KCCQ_;
    private static readonly CqlCode _Physical_limitation_score__KCCQ_ = new CqlCode("72195-1", "http://loinc.org");

    [CqlCodeDefinition("Physical score [MLHFQ]", codeId: "85618-7", codeSystem: "http://loinc.org")]
    public CqlCode Physical_score__MLHFQ_(CqlContext _) => _Physical_score__MLHFQ_;
    private static readonly CqlCode _Physical_score__MLHFQ_ = new CqlCode("85618-7", "http://loinc.org");

    [CqlCodeDefinition("PROMIS-10 Global Mental Health (GMH) score T-score", codeId: "71969-0", codeSystem: "http://loinc.org")]
    public CqlCode PROMIS_10_Global_Mental_Health__GMH__score_T_score(CqlContext _) => _PROMIS_10_Global_Mental_Health__GMH__score_T_score;
    private static readonly CqlCode _PROMIS_10_Global_Mental_Health__GMH__score_T_score = new CqlCode("71969-0", "http://loinc.org");

    [CqlCodeDefinition("PROMIS-10 Global Physical Health (GPH) score T-score", codeId: "71971-6", codeSystem: "http://loinc.org")]
    public CqlCode PROMIS_10_Global_Physical_Health__GPH__score_T_score(CqlContext _) => _PROMIS_10_Global_Physical_Health__GPH__score_T_score;
    private static readonly CqlCode _PROMIS_10_Global_Physical_Health__GPH__score_T_score = new CqlCode("71971-6", "http://loinc.org");

    [CqlCodeDefinition("PROMIS-29 Anxiety score T-score", codeId: "71967-4", codeSystem: "http://loinc.org")]
    public CqlCode PROMIS_29_Anxiety_score_T_score(CqlContext _) => _PROMIS_29_Anxiety_score_T_score;
    private static readonly CqlCode _PROMIS_29_Anxiety_score_T_score = new CqlCode("71967-4", "http://loinc.org");

    [CqlCodeDefinition("PROMIS-29 Depression score T-score", codeId: "71965-8", codeSystem: "http://loinc.org")]
    public CqlCode PROMIS_29_Depression_score_T_score(CqlContext _) => _PROMIS_29_Depression_score_T_score;
    private static readonly CqlCode _PROMIS_29_Depression_score_T_score = new CqlCode("71965-8", "http://loinc.org");

    [CqlCodeDefinition("PROMIS-29 Fatigue score T-score", codeId: "71963-3", codeSystem: "http://loinc.org")]
    public CqlCode PROMIS_29_Fatigue_score_T_score(CqlContext _) => _PROMIS_29_Fatigue_score_T_score;
    private static readonly CqlCode _PROMIS_29_Fatigue_score_T_score = new CqlCode("71963-3", "http://loinc.org");

    [CqlCodeDefinition("PROMIS-29 Pain interference score T-score", codeId: "71961-7", codeSystem: "http://loinc.org")]
    public CqlCode PROMIS_29_Pain_interference_score_T_score(CqlContext _) => _PROMIS_29_Pain_interference_score_T_score;
    private static readonly CqlCode _PROMIS_29_Pain_interference_score_T_score = new CqlCode("71961-7", "http://loinc.org");

    [CqlCodeDefinition("PROMIS-29 Physical function score T-score", codeId: "71959-1", codeSystem: "http://loinc.org")]
    public CqlCode PROMIS_29_Physical_function_score_T_score(CqlContext _) => _PROMIS_29_Physical_function_score_T_score;
    private static readonly CqlCode _PROMIS_29_Physical_function_score_T_score = new CqlCode("71959-1", "http://loinc.org");

    [CqlCodeDefinition("PROMIS-29 Satisfaction with participation in social roles score T-score", codeId: "71957-5", codeSystem: "http://loinc.org")]
    public CqlCode PROMIS_29_Satisfaction_with_participation_in_social_roles_score_T_score(CqlContext _) => _PROMIS_29_Satisfaction_with_participation_in_social_roles_score_T_score;
    private static readonly CqlCode _PROMIS_29_Satisfaction_with_participation_in_social_roles_score_T_score = new CqlCode("71957-5", "http://loinc.org");

    [CqlCodeDefinition("PROMIS-29 Sleep disturbance score T-score", codeId: "71955-9", codeSystem: "http://loinc.org")]
    public CqlCode PROMIS_29_Sleep_disturbance_score_T_score(CqlContext _) => _PROMIS_29_Sleep_disturbance_score_T_score;
    private static readonly CqlCode _PROMIS_29_Sleep_disturbance_score_T_score = new CqlCode("71955-9", "http://loinc.org");

    [CqlCodeDefinition("Quality of life score [KCCQ]", codeId: "72189-4", codeSystem: "http://loinc.org")]
    public CqlCode Quality_of_life_score__KCCQ_(CqlContext _) => _Quality_of_life_score__KCCQ_;
    private static readonly CqlCode _Quality_of_life_score__KCCQ_ = new CqlCode("72189-4", "http://loinc.org");

    [CqlCodeDefinition("Self-efficacy score [KCCQ]", codeId: "72190-2", codeSystem: "http://loinc.org")]
    public CqlCode Self_efficacy_score__KCCQ_(CqlContext _) => _Self_efficacy_score__KCCQ_;
    private static readonly CqlCode _Self_efficacy_score__KCCQ_ = new CqlCode("72190-2", "http://loinc.org");

    [CqlCodeDefinition("Severe cognitive impairment (finding)", codeId: "702956004", codeSystem: "http://snomed.info/sct")]
    public CqlCode Severe_cognitive_impairment__finding_(CqlContext _) => _Severe_cognitive_impairment__finding_;
    private static readonly CqlCode _Severe_cognitive_impairment__finding_ = new CqlCode("702956004", "http://snomed.info/sct");

    [CqlCodeDefinition("Social limitation score [KCCQ]", codeId: "72196-9", codeSystem: "http://loinc.org")]
    public CqlCode Social_limitation_score__KCCQ_(CqlContext _) => _Social_limitation_score__KCCQ_;
    private static readonly CqlCode _Social_limitation_score__KCCQ_ = new CqlCode("72196-9", "http://loinc.org");

    [CqlCodeDefinition("Symptom stability score [KCCQ]", codeId: "72194-4", codeSystem: "http://loinc.org")]
    public CqlCode Symptom_stability_score__KCCQ_(CqlContext _) => _Symptom_stability_score__KCCQ_;
    private static readonly CqlCode _Symptom_stability_score__KCCQ_ = new CqlCode("72194-4", "http://loinc.org");

    [CqlCodeDefinition("Total score [MLHFQ]", codeId: "71938-5", codeSystem: "http://loinc.org")]
    public CqlCode Total_score__MLHFQ_(CqlContext _) => _Total_score__MLHFQ_;
    private static readonly CqlCode _Total_score__MLHFQ_ = new CqlCode("71938-5", "http://loinc.org");

    [CqlCodeDefinition("Total symptom score [KCCQ]", codeId: "72191-0", codeSystem: "http://loinc.org")]
    public CqlCode Total_symptom_score__KCCQ_(CqlContext _) => _Total_symptom_score__KCCQ_;
    private static readonly CqlCode _Total_symptom_score__KCCQ_ = new CqlCode("72191-0", "http://loinc.org");

    [CqlCodeDefinition("VR-12 Mental component summary (MCS) score - oblique method T-score", codeId: "72026-8", codeSystem: "http://loinc.org")]
    public CqlCode VR_12_Mental_component_summary__MCS__score___oblique_method_T_score(CqlContext _) => _VR_12_Mental_component_summary__MCS__score___oblique_method_T_score;
    private static readonly CqlCode _VR_12_Mental_component_summary__MCS__score___oblique_method_T_score = new CqlCode("72026-8", "http://loinc.org");

    [CqlCodeDefinition("VR-12 Mental component summary (MCS) score - orthogonal method T-score", codeId: "72028-4", codeSystem: "http://loinc.org")]
    public CqlCode VR_12_Mental_component_summary__MCS__score___orthogonal_method_T_score(CqlContext _) => _VR_12_Mental_component_summary__MCS__score___orthogonal_method_T_score;
    private static readonly CqlCode _VR_12_Mental_component_summary__MCS__score___orthogonal_method_T_score = new CqlCode("72028-4", "http://loinc.org");

    [CqlCodeDefinition("VR-12 Physical component summary (PCS) score - oblique method T-score", codeId: "72025-0", codeSystem: "http://loinc.org")]
    public CqlCode VR_12_Physical_component_summary__PCS__score___oblique_method_T_score(CqlContext _) => _VR_12_Physical_component_summary__PCS__score___oblique_method_T_score;
    private static readonly CqlCode _VR_12_Physical_component_summary__PCS__score___oblique_method_T_score = new CqlCode("72025-0", "http://loinc.org");

    [CqlCodeDefinition("VR-12 Physical component summary (PCS) score - orthogonal method T-score", codeId: "72027-6", codeSystem: "http://loinc.org")]
    public CqlCode VR_12_Physical_component_summary__PCS__score___orthogonal_method_T_score(CqlContext _) => _VR_12_Physical_component_summary__PCS__score___orthogonal_method_T_score;
    private static readonly CqlCode _VR_12_Physical_component_summary__PCS__score___orthogonal_method_T_score = new CqlCode("72027-6", "http://loinc.org");

    [CqlCodeDefinition("VR-36 Mental component summary (MCS) score - oblique method T-score", codeId: "71990-6", codeSystem: "http://loinc.org")]
    public CqlCode VR_36_Mental_component_summary__MCS__score___oblique_method_T_score(CqlContext _) => _VR_36_Mental_component_summary__MCS__score___oblique_method_T_score;
    private static readonly CqlCode _VR_36_Mental_component_summary__MCS__score___oblique_method_T_score = new CqlCode("71990-6", "http://loinc.org");

    [CqlCodeDefinition("VR-36 Mental component summary (MCS) score - orthogonal method T-score", codeId: "72008-6", codeSystem: "http://loinc.org")]
    public CqlCode VR_36_Mental_component_summary__MCS__score___orthogonal_method_T_score(CqlContext _) => _VR_36_Mental_component_summary__MCS__score___orthogonal_method_T_score;
    private static readonly CqlCode _VR_36_Mental_component_summary__MCS__score___orthogonal_method_T_score = new CqlCode("72008-6", "http://loinc.org");

    [CqlCodeDefinition("VR-36 Physical component summary (PCS) score - oblique method T-score", codeId: "71989-8", codeSystem: "http://loinc.org")]
    public CqlCode VR_36_Physical_component_summary__PCS__score___oblique_method_T_score(CqlContext _) => _VR_36_Physical_component_summary__PCS__score___oblique_method_T_score;
    private static readonly CqlCode _VR_36_Physical_component_summary__PCS__score___oblique_method_T_score = new CqlCode("71989-8", "http://loinc.org");

    [CqlCodeDefinition("VR-36 Physical component summary (PCS) score - orthogonal method T-score", codeId: "72007-8", codeSystem: "http://loinc.org")]
    public CqlCode VR_36_Physical_component_summary__PCS__score___orthogonal_method_T_score(CqlContext _) => _VR_36_Physical_component_summary__PCS__score___orthogonal_method_T_score;
    private static readonly CqlCode _VR_36_Physical_component_summary__PCS__score___orthogonal_method_T_score = new CqlCode("72007-8", "http://loinc.org");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC")]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null,
          _Emotional_score__MLHFQ_,
          _Kansas_City_Cardiomyopathy_Questionnaire___12_item__KCCQ_12_,
          _Overall_summary_score__KCCQ_12_,
          _Overall_summary_score__KCCQ_,
          _Physical_limitation_score__KCCQ_,
          _Physical_score__MLHFQ_,
          _PROMIS_10_Global_Mental_Health__GMH__score_T_score,
          _PROMIS_10_Global_Physical_Health__GPH__score_T_score,
          _PROMIS_29_Anxiety_score_T_score,
          _PROMIS_29_Depression_score_T_score,
          _PROMIS_29_Fatigue_score_T_score,
          _PROMIS_29_Pain_interference_score_T_score,
          _PROMIS_29_Physical_function_score_T_score,
          _PROMIS_29_Satisfaction_with_participation_in_social_roles_score_T_score,
          _PROMIS_29_Sleep_disturbance_score_T_score,
          _Quality_of_life_score__KCCQ_,
          _Self_efficacy_score__KCCQ_,
          _Social_limitation_score__KCCQ_,
          _Symptom_stability_score__KCCQ_,
          _Total_score__MLHFQ_,
          _Total_symptom_score__KCCQ_,
          _VR_12_Mental_component_summary__MCS__score___oblique_method_T_score,
          _VR_12_Mental_component_summary__MCS__score___orthogonal_method_T_score,
          _VR_12_Physical_component_summary__PCS__score___oblique_method_T_score,
          _VR_12_Physical_component_summary__PCS__score___orthogonal_method_T_score,
          _VR_36_Mental_component_summary__MCS__score___oblique_method_T_score,
          _VR_36_Mental_component_summary__MCS__score___orthogonal_method_T_score,
          _VR_36_Physical_component_summary__PCS__score___oblique_method_T_score,
          _VR_36_Physical_component_summary__PCS__score___orthogonal_method_T_score);

    [CqlCodeSystemDefinition("SNOMEDCT")]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null,
          _Severe_cognitive_impairment__finding_);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime vzzzzzzzzzy_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime vzzzzzzzzzz_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> wzzzzzzzzza_ = context.Operators.Interval(vzzzzzzzzzy_, vzzzzzzzzzz_, true, true);
        object wzzzzzzzzzb_ = context.ResolveParameter("FunctionalStatusAssessmentsforHeartFailureFHIR-0.1.000", "Measurement Period", wzzzzzzzzza_);

        return (CqlInterval<CqlDateTime>)wzzzzzzzzzb_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> wzzzzzzzzzc_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient wzzzzzzzzzd_ = context.Operators.SingletonFrom<Patient>(wzzzzzzzzzc_);

        return wzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? wzzzzzzzzze_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return wzzzzzzzzze_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> wzzzzzzzzzf_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return wzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? wzzzzzzzzzg_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return wzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode wzzzzzzzzzh_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return wzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        CqlValueSet wzzzzzzzzzi_ = this.Office_Visit(context);
        IEnumerable<Encounter> wzzzzzzzzzj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet wzzzzzzzzzk_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> wzzzzzzzzzl_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> wzzzzzzzzzm_ = context.Operators.Union<Encounter>(wzzzzzzzzzj_, wzzzzzzzzzl_);
        CqlValueSet wzzzzzzzzzn_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> wzzzzzzzzzo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, wzzzzzzzzzn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> wzzzzzzzzzp_ = context.Operators.Union<Encounter>(wzzzzzzzzzm_, wzzzzzzzzzo_);
        IEnumerable<Encounter> wzzzzzzzzzq_ = Status_1_8_000.Instance.isEncounterPerformed(context, wzzzzzzzzzp_);
        bool? wzzzzzzzzzr_(Encounter ValidEncounter)
        {
            CqlInterval<CqlDateTime> wzzzzzzzzzt_ = this.Measurement_Period(context);
            Period wzzzzzzzzzu_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> wzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzu_);
            CqlInterval<CqlDateTime> wzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.toInterval(context, wzzzzzzzzzv_ as object);
            bool? wzzzzzzzzzx_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(wzzzzzzzzzt_, wzzzzzzzzzw_, "day");

            return wzzzzzzzzzx_;
        };
        IEnumerable<Encounter> wzzzzzzzzzs_ = context.Operators.Where<Encounter>(wzzzzzzzzzq_, wzzzzzzzzzr_);

        return wzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Two Outpatient Encounters during Measurement Period")]
    public IEnumerable<Encounter> Two_Outpatient_Encounters_during_Measurement_Period(CqlContext context)
    {
        IEnumerable<Encounter> wzzzzzzzzzy_ = this.Qualifying_Encounters(context);
        IEnumerable<ValueTuple<Encounter, Encounter>> xzzzzzzzzza_ = context.Operators.CrossJoin<Encounter, Encounter>(wzzzzzzzzzy_, wzzzzzzzzzy_);
        (CqlTupleMetadata, Encounter OfficeVisit1, Encounter OfficeVisit2)? xzzzzzzzzzb_(ValueTuple<Encounter, Encounter> _valueTuple)
        {
            (CqlTupleMetadata, Encounter OfficeVisit1, Encounter OfficeVisit2)? xzzzzzzzzzi_ = (CqlTupleMetadata_DbNMMZBTISSRTNdiShceSFVih, _valueTuple.Item1, _valueTuple.Item2);

            return xzzzzzzzzzi_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter OfficeVisit1, Encounter OfficeVisit2)?> xzzzzzzzzzc_ = context.Operators.Select<ValueTuple<Encounter, Encounter>, (CqlTupleMetadata, Encounter OfficeVisit1, Encounter OfficeVisit2)?>(xzzzzzzzzza_, xzzzzzzzzzb_);
        bool? xzzzzzzzzzd_((CqlTupleMetadata, Encounter OfficeVisit1, Encounter OfficeVisit2)? tuple_dbnmmzbtissrtndishcesfvih)
        {
            Period xzzzzzzzzzj_ = tuple_dbnmmzbtissrtndishcesfvih?.OfficeVisit2?.Period;
            CqlInterval<CqlDateTime> xzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzj_);
            CqlInterval<CqlDateTime> xzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzk_ as object);
            CqlDateTime xzzzzzzzzzm_ = context.Operators.Start(xzzzzzzzzzl_);
            Period xzzzzzzzzzn_ = tuple_dbnmmzbtissrtndishcesfvih?.OfficeVisit1?.Period;
            CqlInterval<CqlDateTime> xzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzn_);
            CqlInterval<CqlDateTime> xzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzo_ as object);
            CqlDateTime xzzzzzzzzzq_ = context.Operators.End(xzzzzzzzzzp_);
            CqlQuantity xzzzzzzzzzr_ = context.Operators.Quantity(1m, "day");
            CqlDateTime xzzzzzzzzzs_ = context.Operators.Add(xzzzzzzzzzq_, xzzzzzzzzzr_);
            bool? xzzzzzzzzzt_ = context.Operators.SameOrAfter(xzzzzzzzzzm_, xzzzzzzzzzs_, "day");

            return xzzzzzzzzzt_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter OfficeVisit1, Encounter OfficeVisit2)?> xzzzzzzzzze_ = context.Operators.Where<(CqlTupleMetadata, Encounter OfficeVisit1, Encounter OfficeVisit2)?>(xzzzzzzzzzc_, xzzzzzzzzzd_);
        Encounter xzzzzzzzzzf_((CqlTupleMetadata, Encounter OfficeVisit1, Encounter OfficeVisit2)? tuple_dbnmmzbtissrtndishcesfvih) =>
            tuple_dbnmmzbtissrtndishcesfvih?.OfficeVisit1;
        IEnumerable<Encounter> xzzzzzzzzzg_ = context.Operators.Select<(CqlTupleMetadata, Encounter OfficeVisit1, Encounter OfficeVisit2)?, Encounter>(xzzzzzzzzze_, xzzzzzzzzzf_);
        IEnumerable<Encounter> xzzzzzzzzzh_ = context.Operators.Distinct<Encounter>(xzzzzzzzzzg_);

        return xzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient xzzzzzzzzzu_ = this.Patient(context);
        Date xzzzzzzzzzv_ = xzzzzzzzzzu_?.BirthDateElement;
        string xzzzzzzzzzw_ = xzzzzzzzzzv_?.Value;
        CqlDate xzzzzzzzzzx_ = context.Operators.ConvertStringToDate(xzzzzzzzzzw_);
        CqlInterval<CqlDateTime> xzzzzzzzzzy_ = this.Measurement_Period(context);
        CqlDateTime xzzzzzzzzzz_ = context.Operators.Start(xzzzzzzzzzy_);
        CqlDate yzzzzzzzzza_ = context.Operators.DateFrom(xzzzzzzzzzz_);
        int? yzzzzzzzzzb_ = context.Operators.CalculateAgeAt(xzzzzzzzzzx_, yzzzzzzzzza_, "year");
        bool? yzzzzzzzzzc_ = context.Operators.GreaterOrEqual(yzzzzzzzzzb_, 18);
        CqlValueSet yzzzzzzzzzd_ = this.Heart_Failure(context);
        IEnumerable<Condition> yzzzzzzzzze_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, yzzzzzzzzzd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? yzzzzzzzzzf_(Condition HeartFailure)
        {
            CqlInterval<CqlDateTime> yzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HeartFailure);
            CqlInterval<CqlDateTime> yzzzzzzzzzn_ = this.Measurement_Period(context);
            bool? yzzzzzzzzzo_ = context.Operators.OverlapsBefore(yzzzzzzzzzm_, yzzzzzzzzzn_, default);

            return yzzzzzzzzzo_;
        };
        IEnumerable<Condition> yzzzzzzzzzg_ = context.Operators.Where<Condition>(yzzzzzzzzze_, yzzzzzzzzzf_);
        bool? yzzzzzzzzzh_ = context.Operators.Exists<Condition>(yzzzzzzzzzg_);
        bool? yzzzzzzzzzi_ = context.Operators.And(yzzzzzzzzzc_, yzzzzzzzzzh_);
        IEnumerable<Encounter> yzzzzzzzzzj_ = this.Two_Outpatient_Encounters_during_Measurement_Period(context);
        bool? yzzzzzzzzzk_ = context.Operators.Exists<Encounter>(yzzzzzzzzzj_);
        bool? yzzzzzzzzzl_ = context.Operators.And(yzzzzzzzzzi_, yzzzzzzzzzk_);

        return yzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? yzzzzzzzzzp_ = this.Initial_Population(context);

        return yzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? yzzzzzzzzzq_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        CqlCode yzzzzzzzzzr_ = this.Severe_cognitive_impairment__finding_(context);
        IEnumerable<CqlCode> yzzzzzzzzzs_ = context.Operators.ToList<CqlCode>(yzzzzzzzzzr_);
        IEnumerable<Condition> yzzzzzzzzzt_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, yzzzzzzzzzs_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? yzzzzzzzzzu_(Condition SevereCognitiveImpairment)
        {
            CqlInterval<CqlDateTime> yzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, SevereCognitiveImpairment);
            CqlInterval<CqlDateTime> yzzzzzzzzzz_ = this.Measurement_Period(context);
            bool? zzzzzzzzzza_ = context.Operators.Overlaps(yzzzzzzzzzy_, yzzzzzzzzzz_, default);

            return zzzzzzzzzza_;
        };
        IEnumerable<Condition> yzzzzzzzzzv_ = context.Operators.Where<Condition>(yzzzzzzzzzt_, yzzzzzzzzzu_);
        bool? yzzzzzzzzzw_ = context.Operators.Exists<Condition>(yzzzzzzzzzv_);
        bool? yzzzzzzzzzx_ = context.Operators.Or(yzzzzzzzzzq_, yzzzzzzzzzw_);

        return yzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Date PROMIS10 Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_PROMIS10_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode zzzzzzzzzzb_ = this.PROMIS_10_Global_Mental_Health__GMH__score_T_score(context);
        IEnumerable<CqlCode> zzzzzzzzzzc_ = context.Operators.ToList<CqlCode>(zzzzzzzzzzb_);
        IEnumerable<Observation> zzzzzzzzzzd_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, zzzzzzzzzzc_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> zzzzzzzzzze_ = Status_1_8_000.Instance.isAssessmentPerformed(context, zzzzzzzzzzd_);
        CqlCode zzzzzzzzzzf_ = this.PROMIS_10_Global_Physical_Health__GPH__score_T_score(context);
        IEnumerable<CqlCode> zzzzzzzzzzg_ = context.Operators.ToList<CqlCode>(zzzzzzzzzzf_);
        IEnumerable<Observation> zzzzzzzzzzh_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, zzzzzzzzzzg_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> zzzzzzzzzzi_ = Status_1_8_000.Instance.isAssessmentPerformed(context, zzzzzzzzzzh_);
        IEnumerable<ValueTuple<Observation, Observation>> zzzzzzzzzzj_ = context.Operators.CrossJoin<Observation, Observation>(zzzzzzzzzze_, zzzzzzzzzzi_);
        (CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)? zzzzzzzzzzk_(ValueTuple<Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)? zzzzzzzzzzr_ = (CqlTupleMetadata_DDTAOdcFieSJbGgRLLZPYbGQb, _valueTuple.Item1, _valueTuple.Item2);

            return zzzzzzzzzzr_;
        };
        IEnumerable<(CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?> zzzzzzzzzzl_ = context.Operators.Select<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?>(zzzzzzzzzzj_, zzzzzzzzzzk_);
        bool? zzzzzzzzzzm_((CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)? tuple_ddtaodcfiesjbggrllzpybgqb)
        {
            DataType zzzzzzzzzzs_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10MentalScore?.Effective;
            object zzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzs_);
            CqlInterval<CqlDateTime> zzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, zzzzzzzzzzt_);
            CqlDateTime zzzzzzzzzzv_ = context.Operators.Start(zzzzzzzzzzu_);
            CqlDate zzzzzzzzzzw_ = context.Operators.DateFrom(zzzzzzzzzzv_);
            DataType zzzzzzzzzzx_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10PhysicalScore?.Effective;
            object zzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzx_);
            CqlInterval<CqlDateTime> zzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, zzzzzzzzzzy_);
            CqlDateTime azzzzzzzzzza_ = context.Operators.Start(zzzzzzzzzzz_);
            CqlDate azzzzzzzzzzb_ = context.Operators.DateFrom(azzzzzzzzzza_);
            bool? azzzzzzzzzzc_ = context.Operators.SameAs(zzzzzzzzzzw_, azzzzzzzzzzb_, "day");
            DataType azzzzzzzzzzd_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10MentalScore?.Value;
            object azzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzd_);
            bool? azzzzzzzzzzf_ = context.Operators.Not((bool?)(azzzzzzzzzze_ is null));
            bool? azzzzzzzzzzg_ = context.Operators.And(azzzzzzzzzzc_, azzzzzzzzzzf_);
            DataType azzzzzzzzzzh_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10PhysicalScore?.Value;
            object azzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzh_);
            bool? azzzzzzzzzzj_ = context.Operators.Not((bool?)(azzzzzzzzzzi_ is null));
            bool? azzzzzzzzzzk_ = context.Operators.And(azzzzzzzzzzg_, azzzzzzzzzzj_);

            return azzzzzzzzzzk_;
        };
        IEnumerable<(CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?> zzzzzzzzzzn_ = context.Operators.Where<(CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?>(zzzzzzzzzzl_, zzzzzzzzzzm_);
        CqlDate zzzzzzzzzzo_((CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)? tuple_ddtaodcfiesjbggrllzpybgqb)
        {
            DataType azzzzzzzzzzl_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10MentalScore?.Effective;
            object azzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzl_);
            CqlInterval<CqlDateTime> azzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.toInterval(context, azzzzzzzzzzm_);
            CqlDateTime azzzzzzzzzzo_ = context.Operators.Start(azzzzzzzzzzn_);
            CqlDate azzzzzzzzzzp_ = context.Operators.DateFrom(azzzzzzzzzzo_);

            return azzzzzzzzzzp_;
        };
        IEnumerable<CqlDate> zzzzzzzzzzp_ = context.Operators.Select<(CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?, CqlDate>(zzzzzzzzzzn_, zzzzzzzzzzo_);
        IEnumerable<CqlDate> zzzzzzzzzzq_ = context.Operators.Distinct<CqlDate>(zzzzzzzzzzp_);

        return zzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Has Encounter with Initial and Follow Up PROMIS10 Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_PROMIS10_Assessments(CqlContext context)
    {
        IEnumerable<Encounter> azzzzzzzzzzq_ = this.Qualifying_Encounters(context);
        IEnumerable<CqlDate> azzzzzzzzzzr_ = this.Date_PROMIS10_Total_Assessment_Completed(context);
        IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> azzzzzzzzzzt_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(azzzzzzzzzzq_, azzzzzzzzzzr_, azzzzzzzzzzr_);
        (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS10Date, CqlDate FollowupPROMIS10Date)? azzzzzzzzzzu_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS10Date, CqlDate FollowupPROMIS10Date)? bzzzzzzzzzzc_ = (CqlTupleMetadata_BGYjYGLNPKWAZTBCVAdLDDTMj, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return bzzzzzzzzzzc_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS10Date, CqlDate FollowupPROMIS10Date)?> azzzzzzzzzzv_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS10Date, CqlDate FollowupPROMIS10Date)?>(azzzzzzzzzzt_, azzzzzzzzzzu_);
        bool? azzzzzzzzzzw_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS10Date, CqlDate FollowupPROMIS10Date)? tuple_dzhwgxhmbfavmzfaszbeksohj)
        {
            Period bzzzzzzzzzzd_ = tuple_dzhwgxhmbfavmzfaszbeksohj?.ValidEncounters?.Period;
            CqlInterval<CqlDateTime> bzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzze_ as object);
            CqlDateTime bzzzzzzzzzzg_ = context.Operators.End(bzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzh_ = this.Measurement_Period(context);
            CqlDateTime bzzzzzzzzzzi_ = context.Operators.End(bzzzzzzzzzzh_);
            CqlQuantity bzzzzzzzzzzj_ = context.Operators.Quantity(180m, "days");
            CqlDateTime bzzzzzzzzzzk_ = context.Operators.Subtract(bzzzzzzzzzzi_, bzzzzzzzzzzj_);
            bool? bzzzzzzzzzzl_ = context.Operators.SameOrBefore(bzzzzzzzzzzg_, bzzzzzzzzzzk_, "day");
            CqlDateTime bzzzzzzzzzzm_ = context.Operators.ConvertDateToDateTime(tuple_dzhwgxhmbfavmzfaszbeksohj?.InitialPROMIS10Date);
            CqlInterval<CqlDateTime> bzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzo_ as object);
            CqlDateTime bzzzzzzzzzzq_ = context.Operators.End(bzzzzzzzzzzp_);
            CqlQuantity bzzzzzzzzzzr_ = context.Operators.Quantity(14m, "days");
            CqlDateTime bzzzzzzzzzzs_ = context.Operators.Subtract(bzzzzzzzzzzq_, bzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzu_ as object);
            CqlDateTime bzzzzzzzzzzw_ = context.Operators.End(bzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzx_ = context.Operators.Interval(bzzzzzzzzzzs_, bzzzzzzzzzzw_, true, true);
            bool? bzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(bzzzzzzzzzzm_, bzzzzzzzzzzx_, "day");
            CqlInterval<CqlDateTime> czzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> czzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, czzzzzzzzzza_ as object);
            CqlDateTime czzzzzzzzzzc_ = context.Operators.End(czzzzzzzzzzb_);
            bool? czzzzzzzzzzd_ = context.Operators.Not((bool?)(czzzzzzzzzzc_ is null));
            bool? czzzzzzzzzze_ = context.Operators.And(bzzzzzzzzzzy_, czzzzzzzzzzd_);
            bool? czzzzzzzzzzf_ = context.Operators.And(bzzzzzzzzzzl_, czzzzzzzzzze_);
            CqlDateTime czzzzzzzzzzg_ = context.Operators.ConvertDateToDateTime(tuple_dzhwgxhmbfavmzfaszbeksohj?.FollowupPROMIS10Date);
            CqlDate czzzzzzzzzzh_ = context.Operators.DateFrom(czzzzzzzzzzg_);
            CqlDate czzzzzzzzzzj_ = context.Operators.DateFrom(bzzzzzzzzzzm_);
            CqlQuantity czzzzzzzzzzk_ = context.Operators.Quantity(30m, "days");
            CqlDate czzzzzzzzzzl_ = context.Operators.Add(czzzzzzzzzzj_, czzzzzzzzzzk_);
            CqlDate czzzzzzzzzzn_ = context.Operators.DateFrom(bzzzzzzzzzzm_);
            CqlDate czzzzzzzzzzp_ = context.Operators.Add(czzzzzzzzzzn_, bzzzzzzzzzzj_);
            CqlInterval<CqlDate> czzzzzzzzzzq_ = context.Operators.Interval(czzzzzzzzzzl_, czzzzzzzzzzp_, true, true);
            bool? czzzzzzzzzzr_ = context.Operators.In<CqlDate>(czzzzzzzzzzh_, czzzzzzzzzzq_, "day");
            bool? czzzzzzzzzzs_ = context.Operators.And(czzzzzzzzzzf_, czzzzzzzzzzr_);

            return czzzzzzzzzzs_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS10Date, CqlDate FollowupPROMIS10Date)?> azzzzzzzzzzx_ = context.Operators.Where<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS10Date, CqlDate FollowupPROMIS10Date)?>(azzzzzzzzzzv_, azzzzzzzzzzw_);
        Encounter azzzzzzzzzzy_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS10Date, CqlDate FollowupPROMIS10Date)? tuple_dzhwgxhmbfavmzfaszbeksohj) =>
            tuple_dzhwgxhmbfavmzfaszbeksohj?.ValidEncounters;
        IEnumerable<Encounter> azzzzzzzzzzz_ = context.Operators.Select<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS10Date, CqlDate FollowupPROMIS10Date)?, Encounter>(azzzzzzzzzzx_, azzzzzzzzzzy_);
        IEnumerable<Encounter> bzzzzzzzzzza_ = context.Operators.Distinct<Encounter>(azzzzzzzzzzz_);
        bool? bzzzzzzzzzzb_ = context.Operators.Exists<Encounter>(bzzzzzzzzzza_);

        return bzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Date PROMIS29 Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_PROMIS29_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode czzzzzzzzzzt_ = this.PROMIS_29_Sleep_disturbance_score_T_score(context);
        IEnumerable<CqlCode> czzzzzzzzzzu_ = context.Operators.ToList<CqlCode>(czzzzzzzzzzt_);
        IEnumerable<Observation> czzzzzzzzzzv_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, czzzzzzzzzzu_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> czzzzzzzzzzw_ = Status_1_8_000.Instance.isAssessmentPerformed(context, czzzzzzzzzzv_);
        CqlCode czzzzzzzzzzx_ = this.PROMIS_29_Satisfaction_with_participation_in_social_roles_score_T_score(context);
        IEnumerable<CqlCode> czzzzzzzzzzy_ = context.Operators.ToList<CqlCode>(czzzzzzzzzzx_);
        IEnumerable<Observation> czzzzzzzzzzz_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, czzzzzzzzzzy_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> dzzzzzzzzzza_ = Status_1_8_000.Instance.isAssessmentPerformed(context, czzzzzzzzzzz_);
        CqlCode dzzzzzzzzzzb_ = this.PROMIS_29_Physical_function_score_T_score(context);
        IEnumerable<CqlCode> dzzzzzzzzzzc_ = context.Operators.ToList<CqlCode>(dzzzzzzzzzzb_);
        IEnumerable<Observation> dzzzzzzzzzzd_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, dzzzzzzzzzzc_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> dzzzzzzzzzze_ = Status_1_8_000.Instance.isAssessmentPerformed(context, dzzzzzzzzzzd_);
        CqlCode dzzzzzzzzzzf_ = this.PROMIS_29_Pain_interference_score_T_score(context);
        IEnumerable<CqlCode> dzzzzzzzzzzg_ = context.Operators.ToList<CqlCode>(dzzzzzzzzzzf_);
        IEnumerable<Observation> dzzzzzzzzzzh_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, dzzzzzzzzzzg_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> dzzzzzzzzzzi_ = Status_1_8_000.Instance.isAssessmentPerformed(context, dzzzzzzzzzzh_);
        CqlCode dzzzzzzzzzzj_ = this.PROMIS_29_Fatigue_score_T_score(context);
        IEnumerable<CqlCode> dzzzzzzzzzzk_ = context.Operators.ToList<CqlCode>(dzzzzzzzzzzj_);
        IEnumerable<Observation> dzzzzzzzzzzl_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, dzzzzzzzzzzk_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> dzzzzzzzzzzm_ = Status_1_8_000.Instance.isAssessmentPerformed(context, dzzzzzzzzzzl_);
        CqlCode dzzzzzzzzzzn_ = this.PROMIS_29_Depression_score_T_score(context);
        IEnumerable<CqlCode> dzzzzzzzzzzo_ = context.Operators.ToList<CqlCode>(dzzzzzzzzzzn_);
        IEnumerable<Observation> dzzzzzzzzzzp_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, dzzzzzzzzzzo_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> dzzzzzzzzzzq_ = Status_1_8_000.Instance.isAssessmentPerformed(context, dzzzzzzzzzzp_);
        CqlCode dzzzzzzzzzzr_ = this.PROMIS_29_Anxiety_score_T_score(context);
        IEnumerable<CqlCode> dzzzzzzzzzzs_ = context.Operators.ToList<CqlCode>(dzzzzzzzzzzr_);
        IEnumerable<Observation> dzzzzzzzzzzt_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, dzzzzzzzzzzs_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> dzzzzzzzzzzu_ = Status_1_8_000.Instance.isAssessmentPerformed(context, dzzzzzzzzzzt_);
        IEnumerable<ValueTuple<Observation, Observation, Observation, Observation, Observation, Observation, Observation>> dzzzzzzzzzzv_ = context.Operators.CrossJoin<Observation, Observation, Observation, Observation, Observation, Observation, Observation>(czzzzzzzzzzw_, dzzzzzzzzzza_, dzzzzzzzzzze_, dzzzzzzzzzzi_, dzzzzzzzzzzm_, dzzzzzzzzzzq_, dzzzzzzzzzzu_);
        (CqlTupleMetadata, Observation Promis29Sleep, Observation Promis29SocialRoles, Observation Promis29Physical, Observation Promis29Pain, Observation Promis29Fatigue, Observation Promis29Depression, Observation Promis29Anxiety)? dzzzzzzzzzzw_(ValueTuple<Observation, Observation, Observation, Observation, Observation, Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation Promis29Sleep, Observation Promis29SocialRoles, Observation Promis29Physical, Observation Promis29Pain, Observation Promis29Fatigue, Observation Promis29Depression, Observation Promis29Anxiety)? ezzzzzzzzzzd_ = (CqlTupleMetadata_DBUJFOVGBcbhIQPWARNQHKUaX, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3, _valueTuple.Item4, _valueTuple.Item5, _valueTuple.Item6, _valueTuple.Item7);

            return ezzzzzzzzzzd_;
        };
        IEnumerable<(CqlTupleMetadata, Observation Promis29Sleep, Observation Promis29SocialRoles, Observation Promis29Physical, Observation Promis29Pain, Observation Promis29Fatigue, Observation Promis29Depression, Observation Promis29Anxiety)?> dzzzzzzzzzzx_ = context.Operators.Select<ValueTuple<Observation, Observation, Observation, Observation, Observation, Observation, Observation>, (CqlTupleMetadata, Observation Promis29Sleep, Observation Promis29SocialRoles, Observation Promis29Physical, Observation Promis29Pain, Observation Promis29Fatigue, Observation Promis29Depression, Observation Promis29Anxiety)?>(dzzzzzzzzzzv_, dzzzzzzzzzzw_);
        bool? dzzzzzzzzzzy_((CqlTupleMetadata, Observation Promis29Sleep, Observation Promis29SocialRoles, Observation Promis29Physical, Observation Promis29Pain, Observation Promis29Fatigue, Observation Promis29Depression, Observation Promis29Anxiety)? tuple_cbgpsarvwrsewlglehinjanim)
        {
            DataType ezzzzzzzzzze_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Sleep?.Effective;
            object ezzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzze_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.toInterval(context, ezzzzzzzzzzf_);
            CqlDateTime ezzzzzzzzzzh_ = context.Operators.Start(ezzzzzzzzzzg_);
            CqlDate ezzzzzzzzzzi_ = context.Operators.DateFrom(ezzzzzzzzzzh_);
            DataType ezzzzzzzzzzj_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29SocialRoles?.Effective;
            object ezzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzj_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, ezzzzzzzzzzk_);
            CqlDateTime ezzzzzzzzzzm_ = context.Operators.Start(ezzzzzzzzzzl_);
            CqlDate ezzzzzzzzzzn_ = context.Operators.DateFrom(ezzzzzzzzzzm_);
            bool? ezzzzzzzzzzo_ = context.Operators.SameAs(ezzzzzzzzzzi_, ezzzzzzzzzzn_, "day");
            DataType ezzzzzzzzzzp_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29SocialRoles?.Value;
            object ezzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzp_);
            bool? ezzzzzzzzzzr_ = context.Operators.Not((bool?)(ezzzzzzzzzzq_ is null));
            bool? ezzzzzzzzzzs_ = context.Operators.And(ezzzzzzzzzzo_, ezzzzzzzzzzr_);
            object ezzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzze_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, ezzzzzzzzzzu_);
            CqlDateTime ezzzzzzzzzzw_ = context.Operators.Start(ezzzzzzzzzzv_);
            CqlDate ezzzzzzzzzzx_ = context.Operators.DateFrom(ezzzzzzzzzzw_);
            DataType ezzzzzzzzzzy_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Physical?.Effective;
            object ezzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzy_);
            CqlInterval<CqlDateTime> fzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, ezzzzzzzzzzz_);
            CqlDateTime fzzzzzzzzzzb_ = context.Operators.Start(fzzzzzzzzzza_);
            CqlDate fzzzzzzzzzzc_ = context.Operators.DateFrom(fzzzzzzzzzzb_);
            bool? fzzzzzzzzzzd_ = context.Operators.SameAs(ezzzzzzzzzzx_, fzzzzzzzzzzc_, "day");
            bool? fzzzzzzzzzze_ = context.Operators.And(ezzzzzzzzzzs_, fzzzzzzzzzzd_);
            DataType fzzzzzzzzzzf_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Physical?.Value;
            object fzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzf_);
            bool? fzzzzzzzzzzh_ = context.Operators.Not((bool?)(fzzzzzzzzzzg_ is null));
            bool? fzzzzzzzzzzi_ = context.Operators.And(fzzzzzzzzzze_, fzzzzzzzzzzh_);
            object fzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzze_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, fzzzzzzzzzzk_);
            CqlDateTime fzzzzzzzzzzm_ = context.Operators.Start(fzzzzzzzzzzl_);
            CqlDate fzzzzzzzzzzn_ = context.Operators.DateFrom(fzzzzzzzzzzm_);
            DataType fzzzzzzzzzzo_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Pain?.Effective;
            object fzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.toInterval(context, fzzzzzzzzzzp_);
            CqlDateTime fzzzzzzzzzzr_ = context.Operators.Start(fzzzzzzzzzzq_);
            CqlDate fzzzzzzzzzzs_ = context.Operators.DateFrom(fzzzzzzzzzzr_);
            bool? fzzzzzzzzzzt_ = context.Operators.SameAs(fzzzzzzzzzzn_, fzzzzzzzzzzs_, "day");
            bool? fzzzzzzzzzzu_ = context.Operators.And(fzzzzzzzzzzi_, fzzzzzzzzzzt_);
            DataType fzzzzzzzzzzv_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Pain?.Value;
            object fzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzv_);
            bool? fzzzzzzzzzzx_ = context.Operators.Not((bool?)(fzzzzzzzzzzw_ is null));
            bool? fzzzzzzzzzzy_ = context.Operators.And(fzzzzzzzzzzu_, fzzzzzzzzzzx_);
            object gzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzze_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzza_);
            CqlDateTime gzzzzzzzzzzc_ = context.Operators.Start(gzzzzzzzzzzb_);
            CqlDate gzzzzzzzzzzd_ = context.Operators.DateFrom(gzzzzzzzzzzc_);
            DataType gzzzzzzzzzze_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Fatigue?.Effective;
            object gzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzze_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzzf_);
            CqlDateTime gzzzzzzzzzzh_ = context.Operators.Start(gzzzzzzzzzzg_);
            CqlDate gzzzzzzzzzzi_ = context.Operators.DateFrom(gzzzzzzzzzzh_);
            bool? gzzzzzzzzzzj_ = context.Operators.SameAs(gzzzzzzzzzzd_, gzzzzzzzzzzi_, "day");
            bool? gzzzzzzzzzzk_ = context.Operators.And(fzzzzzzzzzzy_, gzzzzzzzzzzj_);
            DataType gzzzzzzzzzzl_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Fatigue?.Value;
            object gzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzl_);
            bool? gzzzzzzzzzzn_ = context.Operators.Not((bool?)(gzzzzzzzzzzm_ is null));
            bool? gzzzzzzzzzzo_ = context.Operators.And(gzzzzzzzzzzk_, gzzzzzzzzzzn_);
            object gzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzze_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzzq_);
            CqlDateTime gzzzzzzzzzzs_ = context.Operators.Start(gzzzzzzzzzzr_);
            CqlDate gzzzzzzzzzzt_ = context.Operators.DateFrom(gzzzzzzzzzzs_);
            DataType gzzzzzzzzzzu_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Depression?.Effective;
            object gzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, gzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzzv_);
            CqlDateTime gzzzzzzzzzzx_ = context.Operators.Start(gzzzzzzzzzzw_);
            CqlDate gzzzzzzzzzzy_ = context.Operators.DateFrom(gzzzzzzzzzzx_);
            bool? gzzzzzzzzzzz_ = context.Operators.SameAs(gzzzzzzzzzzt_, gzzzzzzzzzzy_, "day");
            bool? hzzzzzzzzzza_ = context.Operators.And(gzzzzzzzzzzo_, gzzzzzzzzzzz_);
            DataType hzzzzzzzzzzb_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Depression?.Value;
            object hzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzb_);
            bool? hzzzzzzzzzzd_ = context.Operators.Not((bool?)(hzzzzzzzzzzc_ is null));
            bool? hzzzzzzzzzze_ = context.Operators.And(hzzzzzzzzzza_, hzzzzzzzzzzd_);
            object hzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzze_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.toInterval(context, hzzzzzzzzzzg_);
            CqlDateTime hzzzzzzzzzzi_ = context.Operators.Start(hzzzzzzzzzzh_);
            CqlDate hzzzzzzzzzzj_ = context.Operators.DateFrom(hzzzzzzzzzzi_);
            DataType hzzzzzzzzzzk_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Anxiety?.Effective;
            object hzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzk_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.toInterval(context, hzzzzzzzzzzl_);
            CqlDateTime hzzzzzzzzzzn_ = context.Operators.Start(hzzzzzzzzzzm_);
            CqlDate hzzzzzzzzzzo_ = context.Operators.DateFrom(hzzzzzzzzzzn_);
            bool? hzzzzzzzzzzp_ = context.Operators.SameAs(hzzzzzzzzzzj_, hzzzzzzzzzzo_, "day");
            bool? hzzzzzzzzzzq_ = context.Operators.And(hzzzzzzzzzze_, hzzzzzzzzzzp_);
            DataType hzzzzzzzzzzr_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Anxiety?.Value;
            object hzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzr_);
            bool? hzzzzzzzzzzt_ = context.Operators.Not((bool?)(hzzzzzzzzzzs_ is null));
            bool? hzzzzzzzzzzu_ = context.Operators.And(hzzzzzzzzzzq_, hzzzzzzzzzzt_);
            DataType hzzzzzzzzzzv_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Sleep?.Value;
            object hzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzv_);
            bool? hzzzzzzzzzzx_ = context.Operators.Not((bool?)(hzzzzzzzzzzw_ is null));
            bool? hzzzzzzzzzzy_ = context.Operators.And(hzzzzzzzzzzu_, hzzzzzzzzzzx_);

            return hzzzzzzzzzzy_;
        };
        IEnumerable<(CqlTupleMetadata, Observation Promis29Sleep, Observation Promis29SocialRoles, Observation Promis29Physical, Observation Promis29Pain, Observation Promis29Fatigue, Observation Promis29Depression, Observation Promis29Anxiety)?> dzzzzzzzzzzz_ = context.Operators.Where<(CqlTupleMetadata, Observation Promis29Sleep, Observation Promis29SocialRoles, Observation Promis29Physical, Observation Promis29Pain, Observation Promis29Fatigue, Observation Promis29Depression, Observation Promis29Anxiety)?>(dzzzzzzzzzzx_, dzzzzzzzzzzy_);
        CqlDate ezzzzzzzzzza_((CqlTupleMetadata, Observation Promis29Sleep, Observation Promis29SocialRoles, Observation Promis29Physical, Observation Promis29Pain, Observation Promis29Fatigue, Observation Promis29Depression, Observation Promis29Anxiety)? tuple_cbgpsarvwrsewlglehinjanim)
        {
            DataType hzzzzzzzzzzz_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Sleep?.Effective;
            object izzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> izzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, izzzzzzzzzza_);
            CqlDateTime izzzzzzzzzzc_ = context.Operators.Start(izzzzzzzzzzb_);
            CqlDate izzzzzzzzzzd_ = context.Operators.DateFrom(izzzzzzzzzzc_);

            return izzzzzzzzzzd_;
        };
        IEnumerable<CqlDate> ezzzzzzzzzzb_ = context.Operators.Select<(CqlTupleMetadata, Observation Promis29Sleep, Observation Promis29SocialRoles, Observation Promis29Physical, Observation Promis29Pain, Observation Promis29Fatigue, Observation Promis29Depression, Observation Promis29Anxiety)?, CqlDate>(dzzzzzzzzzzz_, ezzzzzzzzzza_);
        IEnumerable<CqlDate> ezzzzzzzzzzc_ = context.Operators.Distinct<CqlDate>(ezzzzzzzzzzb_);

        return ezzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Has Encounter with Initial and Follow Up PROMIS29 Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_PROMIS29_Assessments(CqlContext context)
    {
        IEnumerable<Encounter> izzzzzzzzzze_ = this.Qualifying_Encounters(context);
        IEnumerable<CqlDate> izzzzzzzzzzf_ = this.Date_PROMIS29_Total_Assessment_Completed(context);
        IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> izzzzzzzzzzh_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(izzzzzzzzzze_, izzzzzzzzzzf_, izzzzzzzzzzf_);
        (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS29Date, CqlDate FollowupPROMIS29Date)? izzzzzzzzzzi_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS29Date, CqlDate FollowupPROMIS29Date)? izzzzzzzzzzq_ = (CqlTupleMetadata_DSZKEYVbCINNIeAQiZdVaEJhG, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return izzzzzzzzzzq_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS29Date, CqlDate FollowupPROMIS29Date)?> izzzzzzzzzzj_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS29Date, CqlDate FollowupPROMIS29Date)?>(izzzzzzzzzzh_, izzzzzzzzzzi_);
        bool? izzzzzzzzzzk_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS29Date, CqlDate FollowupPROMIS29Date)? tuple_kmpntxjuhkpbcwgftqigieao)
        {
            Period izzzzzzzzzzr_ = tuple_kmpntxjuhkpbcwgftqigieao?.ValidEncounters?.Period;
            CqlInterval<CqlDateTime> izzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzr_);
            CqlInterval<CqlDateTime> izzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.toInterval(context, izzzzzzzzzzs_ as object);
            CqlDateTime izzzzzzzzzzu_ = context.Operators.End(izzzzzzzzzzt_);
            CqlInterval<CqlDateTime> izzzzzzzzzzv_ = this.Measurement_Period(context);
            CqlDateTime izzzzzzzzzzw_ = context.Operators.End(izzzzzzzzzzv_);
            CqlQuantity izzzzzzzzzzx_ = context.Operators.Quantity(180m, "days");
            CqlDateTime izzzzzzzzzzy_ = context.Operators.Subtract(izzzzzzzzzzw_, izzzzzzzzzzx_);
            bool? izzzzzzzzzzz_ = context.Operators.SameOrBefore(izzzzzzzzzzu_, izzzzzzzzzzy_, "day");
            CqlDateTime jzzzzzzzzzza_ = context.Operators.ConvertDateToDateTime(tuple_kmpntxjuhkpbcwgftqigieao?.InitialPROMIS29Date);
            CqlInterval<CqlDateTime> jzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzr_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.toInterval(context, jzzzzzzzzzzc_ as object);
            CqlDateTime jzzzzzzzzzze_ = context.Operators.End(jzzzzzzzzzzd_);
            CqlQuantity jzzzzzzzzzzf_ = context.Operators.Quantity(14m, "days");
            CqlDateTime jzzzzzzzzzzg_ = context.Operators.Subtract(jzzzzzzzzzze_, jzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzr_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.toInterval(context, jzzzzzzzzzzi_ as object);
            CqlDateTime jzzzzzzzzzzk_ = context.Operators.End(jzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzl_ = context.Operators.Interval(jzzzzzzzzzzg_, jzzzzzzzzzzk_, true, true);
            bool? jzzzzzzzzzzm_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzza_, jzzzzzzzzzzl_, "day");
            CqlInterval<CqlDateTime> jzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzr_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, jzzzzzzzzzzo_ as object);
            CqlDateTime jzzzzzzzzzzq_ = context.Operators.End(jzzzzzzzzzzp_);
            bool? jzzzzzzzzzzr_ = context.Operators.Not((bool?)(jzzzzzzzzzzq_ is null));
            bool? jzzzzzzzzzzs_ = context.Operators.And(jzzzzzzzzzzm_, jzzzzzzzzzzr_);
            bool? jzzzzzzzzzzt_ = context.Operators.And(izzzzzzzzzzz_, jzzzzzzzzzzs_);
            CqlDateTime jzzzzzzzzzzu_ = context.Operators.ConvertDateToDateTime(tuple_kmpntxjuhkpbcwgftqigieao?.FollowupPROMIS29Date);
            CqlDate jzzzzzzzzzzv_ = context.Operators.DateFrom(jzzzzzzzzzzu_);
            CqlDate jzzzzzzzzzzx_ = context.Operators.DateFrom(jzzzzzzzzzza_);
            CqlQuantity jzzzzzzzzzzy_ = context.Operators.Quantity(30m, "days");
            CqlDate jzzzzzzzzzzz_ = context.Operators.Add(jzzzzzzzzzzx_, jzzzzzzzzzzy_);
            CqlDate kzzzzzzzzzzb_ = context.Operators.DateFrom(jzzzzzzzzzza_);
            CqlDate kzzzzzzzzzzd_ = context.Operators.Add(kzzzzzzzzzzb_, izzzzzzzzzzx_);
            CqlInterval<CqlDate> kzzzzzzzzzze_ = context.Operators.Interval(jzzzzzzzzzzz_, kzzzzzzzzzzd_, true, true);
            bool? kzzzzzzzzzzf_ = context.Operators.In<CqlDate>(jzzzzzzzzzzv_, kzzzzzzzzzze_, "day");
            bool? kzzzzzzzzzzg_ = context.Operators.And(jzzzzzzzzzzt_, kzzzzzzzzzzf_);

            return kzzzzzzzzzzg_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS29Date, CqlDate FollowupPROMIS29Date)?> izzzzzzzzzzl_ = context.Operators.Where<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS29Date, CqlDate FollowupPROMIS29Date)?>(izzzzzzzzzzj_, izzzzzzzzzzk_);
        Encounter izzzzzzzzzzm_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS29Date, CqlDate FollowupPROMIS29Date)? tuple_kmpntxjuhkpbcwgftqigieao) =>
            tuple_kmpntxjuhkpbcwgftqigieao?.ValidEncounters;
        IEnumerable<Encounter> izzzzzzzzzzn_ = context.Operators.Select<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS29Date, CqlDate FollowupPROMIS29Date)?, Encounter>(izzzzzzzzzzl_, izzzzzzzzzzm_);
        IEnumerable<Encounter> izzzzzzzzzzo_ = context.Operators.Distinct<Encounter>(izzzzzzzzzzn_);
        bool? izzzzzzzzzzp_ = context.Operators.Exists<Encounter>(izzzzzzzzzzo_);

        return izzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Date VR12 Oblique Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_VR12_Oblique_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode kzzzzzzzzzzh_ = this.VR_12_Mental_component_summary__MCS__score___oblique_method_T_score(context);
        IEnumerable<CqlCode> kzzzzzzzzzzi_ = context.Operators.ToList<CqlCode>(kzzzzzzzzzzh_);
        IEnumerable<Observation> kzzzzzzzzzzj_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, kzzzzzzzzzzi_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> kzzzzzzzzzzk_ = Status_1_8_000.Instance.isAssessmentPerformed(context, kzzzzzzzzzzj_);
        CqlCode kzzzzzzzzzzl_ = this.VR_12_Physical_component_summary__PCS__score___oblique_method_T_score(context);
        IEnumerable<CqlCode> kzzzzzzzzzzm_ = context.Operators.ToList<CqlCode>(kzzzzzzzzzzl_);
        IEnumerable<Observation> kzzzzzzzzzzn_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, kzzzzzzzzzzm_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> kzzzzzzzzzzo_ = Status_1_8_000.Instance.isAssessmentPerformed(context, kzzzzzzzzzzn_);
        IEnumerable<ValueTuple<Observation, Observation>> kzzzzzzzzzzp_ = context.Operators.CrossJoin<Observation, Observation>(kzzzzzzzzzzk_, kzzzzzzzzzzo_);
        (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? kzzzzzzzzzzq_(ValueTuple<Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? kzzzzzzzzzzx_ = (CqlTupleMetadata_GAdRFKRaHUUGJcVHWQWRUjhRH, _valueTuple.Item1, _valueTuple.Item2);

            return kzzzzzzzzzzx_;
        };
        IEnumerable<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?> kzzzzzzzzzzr_ = context.Operators.Select<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?>(kzzzzzzzzzzp_, kzzzzzzzzzzq_);
        bool? kzzzzzzzzzzs_((CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? tuple_gadrfkrahuugjcvhwqwrujhrh)
        {
            DataType kzzzzzzzzzzy_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Effective;
            object kzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzy_);
            CqlInterval<CqlDateTime> lzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzz_);
            CqlDateTime lzzzzzzzzzzb_ = context.Operators.Start(lzzzzzzzzzza_);
            CqlDate lzzzzzzzzzzc_ = context.Operators.DateFrom(lzzzzzzzzzzb_);
            DataType lzzzzzzzzzzd_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Effective;
            object lzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, lzzzzzzzzzze_);
            CqlDateTime lzzzzzzzzzzg_ = context.Operators.Start(lzzzzzzzzzzf_);
            CqlDate lzzzzzzzzzzh_ = context.Operators.DateFrom(lzzzzzzzzzzg_);
            bool? lzzzzzzzzzzi_ = context.Operators.SameAs(lzzzzzzzzzzc_, lzzzzzzzzzzh_, "day");
            DataType lzzzzzzzzzzj_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Value;
            object lzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzj_);
            bool? lzzzzzzzzzzl_ = context.Operators.Not((bool?)(lzzzzzzzzzzk_ is null));
            bool? lzzzzzzzzzzm_ = context.Operators.And(lzzzzzzzzzzi_, lzzzzzzzzzzl_);
            DataType lzzzzzzzzzzn_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Value;
            object lzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzn_);
            bool? lzzzzzzzzzzp_ = context.Operators.Not((bool?)(lzzzzzzzzzzo_ is null));
            bool? lzzzzzzzzzzq_ = context.Operators.And(lzzzzzzzzzzm_, lzzzzzzzzzzp_);

            return lzzzzzzzzzzq_;
        };
        IEnumerable<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?> kzzzzzzzzzzt_ = context.Operators.Where<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?>(kzzzzzzzzzzr_, kzzzzzzzzzzs_);
        CqlDate kzzzzzzzzzzu_((CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? tuple_gadrfkrahuugjcvhwqwrujhrh)
        {
            DataType lzzzzzzzzzzr_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Effective;
            object lzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.toInterval(context, lzzzzzzzzzzs_);
            CqlDateTime lzzzzzzzzzzu_ = context.Operators.Start(lzzzzzzzzzzt_);
            CqlDate lzzzzzzzzzzv_ = context.Operators.DateFrom(lzzzzzzzzzzu_);

            return lzzzzzzzzzzv_;
        };
        IEnumerable<CqlDate> kzzzzzzzzzzv_ = context.Operators.Select<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?, CqlDate>(kzzzzzzzzzzt_, kzzzzzzzzzzu_);
        IEnumerable<CqlDate> kzzzzzzzzzzw_ = context.Operators.Distinct<CqlDate>(kzzzzzzzzzzv_);

        return kzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Has Encounter with Initial and Follow Up VR12 Oblique Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_VR12_Oblique_Assessments(CqlContext context)
    {
        IEnumerable<Encounter> lzzzzzzzzzzw_ = this.Qualifying_Encounters(context);
        IEnumerable<CqlDate> lzzzzzzzzzzx_ = this.Date_VR12_Oblique_Total_Assessment_Completed(context);
        IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> lzzzzzzzzzzz_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(lzzzzzzzzzzw_, lzzzzzzzzzzx_, lzzzzzzzzzzx_);
        (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12ObliqueDate, CqlDate FollowupVR12ObliqueDate)? mzzzzzzzzzza_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12ObliqueDate, CqlDate FollowupVR12ObliqueDate)? mzzzzzzzzzzi_ = (CqlTupleMetadata_FQKGdEYLiDFGMNAUAMETIHUQT, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return mzzzzzzzzzzi_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12ObliqueDate, CqlDate FollowupVR12ObliqueDate)?> mzzzzzzzzzzb_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12ObliqueDate, CqlDate FollowupVR12ObliqueDate)?>(lzzzzzzzzzzz_, mzzzzzzzzzza_);
        bool? mzzzzzzzzzzc_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12ObliqueDate, CqlDate FollowupVR12ObliqueDate)? tuple_fppktdiagiekhptnsbacpswh)
        {
            Period mzzzzzzzzzzj_ = tuple_fppktdiagiekhptnsbacpswh?.ValidEncounters?.Period;
            CqlInterval<CqlDateTime> mzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, mzzzzzzzzzzk_ as object);
            CqlDateTime mzzzzzzzzzzm_ = context.Operators.End(mzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzn_ = this.Measurement_Period(context);
            CqlDateTime mzzzzzzzzzzo_ = context.Operators.End(mzzzzzzzzzzn_);
            CqlQuantity mzzzzzzzzzzp_ = context.Operators.Quantity(180m, "days");
            CqlDateTime mzzzzzzzzzzq_ = context.Operators.Subtract(mzzzzzzzzzzo_, mzzzzzzzzzzp_);
            bool? mzzzzzzzzzzr_ = context.Operators.SameOrBefore(mzzzzzzzzzzm_, mzzzzzzzzzzq_, "day");
            CqlDateTime mzzzzzzzzzzs_ = context.Operators.ConvertDateToDateTime(tuple_fppktdiagiekhptnsbacpswh?.InitialVR12ObliqueDate);
            CqlInterval<CqlDateTime> mzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, mzzzzzzzzzzu_ as object);
            CqlDateTime mzzzzzzzzzzw_ = context.Operators.End(mzzzzzzzzzzv_);
            CqlQuantity mzzzzzzzzzzx_ = context.Operators.Quantity(14m, "days");
            CqlDateTime mzzzzzzzzzzy_ = context.Operators.Subtract(mzzzzzzzzzzw_, mzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> nzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzza_ as object);
            CqlDateTime nzzzzzzzzzzc_ = context.Operators.End(nzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzd_ = context.Operators.Interval(mzzzzzzzzzzy_, nzzzzzzzzzzc_, true, true);
            bool? nzzzzzzzzzze_ = context.Operators.In<CqlDateTime>(mzzzzzzzzzzs_, nzzzzzzzzzzd_, "day");
            CqlInterval<CqlDateTime> nzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzzg_ as object);
            CqlDateTime nzzzzzzzzzzi_ = context.Operators.End(nzzzzzzzzzzh_);
            bool? nzzzzzzzzzzj_ = context.Operators.Not((bool?)(nzzzzzzzzzzi_ is null));
            bool? nzzzzzzzzzzk_ = context.Operators.And(nzzzzzzzzzze_, nzzzzzzzzzzj_);
            bool? nzzzzzzzzzzl_ = context.Operators.And(mzzzzzzzzzzr_, nzzzzzzzzzzk_);
            CqlDateTime nzzzzzzzzzzm_ = context.Operators.ConvertDateToDateTime(tuple_fppktdiagiekhptnsbacpswh?.FollowupVR12ObliqueDate);
            CqlDate nzzzzzzzzzzn_ = context.Operators.DateFrom(nzzzzzzzzzzm_);
            CqlDate nzzzzzzzzzzp_ = context.Operators.DateFrom(mzzzzzzzzzzs_);
            CqlQuantity nzzzzzzzzzzq_ = context.Operators.Quantity(30m, "days");
            CqlDate nzzzzzzzzzzr_ = context.Operators.Add(nzzzzzzzzzzp_, nzzzzzzzzzzq_);
            CqlDate nzzzzzzzzzzt_ = context.Operators.DateFrom(mzzzzzzzzzzs_);
            CqlDate nzzzzzzzzzzv_ = context.Operators.Add(nzzzzzzzzzzt_, mzzzzzzzzzzp_);
            CqlInterval<CqlDate> nzzzzzzzzzzw_ = context.Operators.Interval(nzzzzzzzzzzr_, nzzzzzzzzzzv_, true, true);
            bool? nzzzzzzzzzzx_ = context.Operators.In<CqlDate>(nzzzzzzzzzzn_, nzzzzzzzzzzw_, "day");
            bool? nzzzzzzzzzzy_ = context.Operators.And(nzzzzzzzzzzl_, nzzzzzzzzzzx_);

            return nzzzzzzzzzzy_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12ObliqueDate, CqlDate FollowupVR12ObliqueDate)?> mzzzzzzzzzzd_ = context.Operators.Where<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12ObliqueDate, CqlDate FollowupVR12ObliqueDate)?>(mzzzzzzzzzzb_, mzzzzzzzzzzc_);
        Encounter mzzzzzzzzzze_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12ObliqueDate, CqlDate FollowupVR12ObliqueDate)? tuple_fppktdiagiekhptnsbacpswh) =>
            tuple_fppktdiagiekhptnsbacpswh?.ValidEncounters;
        IEnumerable<Encounter> mzzzzzzzzzzf_ = context.Operators.Select<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12ObliqueDate, CqlDate FollowupVR12ObliqueDate)?, Encounter>(mzzzzzzzzzzd_, mzzzzzzzzzze_);
        IEnumerable<Encounter> mzzzzzzzzzzg_ = context.Operators.Distinct<Encounter>(mzzzzzzzzzzf_);
        bool? mzzzzzzzzzzh_ = context.Operators.Exists<Encounter>(mzzzzzzzzzzg_);

        return mzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Date VR12 Orthogonal Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_VR12_Orthogonal_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode nzzzzzzzzzzz_ = this.VR_12_Mental_component_summary__MCS__score___orthogonal_method_T_score(context);
        IEnumerable<CqlCode> ozzzzzzzzzza_ = context.Operators.ToList<CqlCode>(nzzzzzzzzzzz_);
        IEnumerable<Observation> ozzzzzzzzzzb_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, ozzzzzzzzzza_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> ozzzzzzzzzzc_ = Status_1_8_000.Instance.isAssessmentPerformed(context, ozzzzzzzzzzb_);
        CqlCode ozzzzzzzzzzd_ = this.VR_12_Physical_component_summary__PCS__score___orthogonal_method_T_score(context);
        IEnumerable<CqlCode> ozzzzzzzzzze_ = context.Operators.ToList<CqlCode>(ozzzzzzzzzzd_);
        IEnumerable<Observation> ozzzzzzzzzzf_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, ozzzzzzzzzze_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> ozzzzzzzzzzg_ = Status_1_8_000.Instance.isAssessmentPerformed(context, ozzzzzzzzzzf_);
        IEnumerable<ValueTuple<Observation, Observation>> ozzzzzzzzzzh_ = context.Operators.CrossJoin<Observation, Observation>(ozzzzzzzzzzc_, ozzzzzzzzzzg_);
        (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? ozzzzzzzzzzi_(ValueTuple<Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? ozzzzzzzzzzp_ = (CqlTupleMetadata_GAdRFKRaHUUGJcVHWQWRUjhRH, _valueTuple.Item1, _valueTuple.Item2);

            return ozzzzzzzzzzp_;
        };
        IEnumerable<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?> ozzzzzzzzzzj_ = context.Operators.Select<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?>(ozzzzzzzzzzh_, ozzzzzzzzzzi_);
        bool? ozzzzzzzzzzk_((CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? tuple_gadrfkrahuugjcvhwqwrujhrh)
        {
            DataType ozzzzzzzzzzq_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Effective;
            object ozzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzq_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.toInterval(context, ozzzzzzzzzzr_);
            CqlDateTime ozzzzzzzzzzt_ = context.Operators.Start(ozzzzzzzzzzs_);
            CqlDate ozzzzzzzzzzu_ = context.Operators.DateFrom(ozzzzzzzzzzt_);
            DataType ozzzzzzzzzzv_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Effective;
            object ozzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzv_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.toInterval(context, ozzzzzzzzzzw_);
            CqlDateTime ozzzzzzzzzzy_ = context.Operators.Start(ozzzzzzzzzzx_);
            CqlDate ozzzzzzzzzzz_ = context.Operators.DateFrom(ozzzzzzzzzzy_);
            bool? pzzzzzzzzzza_ = context.Operators.SameAs(ozzzzzzzzzzu_, ozzzzzzzzzzz_, "day");
            DataType pzzzzzzzzzzb_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Value;
            object pzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzb_);
            bool? pzzzzzzzzzzd_ = context.Operators.Not((bool?)(pzzzzzzzzzzc_ is null));
            bool? pzzzzzzzzzze_ = context.Operators.And(pzzzzzzzzzza_, pzzzzzzzzzzd_);
            DataType pzzzzzzzzzzf_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Value;
            object pzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzf_);
            bool? pzzzzzzzzzzh_ = context.Operators.Not((bool?)(pzzzzzzzzzzg_ is null));
            bool? pzzzzzzzzzzi_ = context.Operators.And(pzzzzzzzzzze_, pzzzzzzzzzzh_);

            return pzzzzzzzzzzi_;
        };
        IEnumerable<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?> ozzzzzzzzzzl_ = context.Operators.Where<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?>(ozzzzzzzzzzj_, ozzzzzzzzzzk_);
        CqlDate ozzzzzzzzzzm_((CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? tuple_gadrfkrahuugjcvhwqwrujhrh)
        {
            DataType pzzzzzzzzzzj_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Effective;
            object pzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, pzzzzzzzzzzk_);
            CqlDateTime pzzzzzzzzzzm_ = context.Operators.Start(pzzzzzzzzzzl_);
            CqlDate pzzzzzzzzzzn_ = context.Operators.DateFrom(pzzzzzzzzzzm_);

            return pzzzzzzzzzzn_;
        };
        IEnumerable<CqlDate> ozzzzzzzzzzn_ = context.Operators.Select<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?, CqlDate>(ozzzzzzzzzzl_, ozzzzzzzzzzm_);
        IEnumerable<CqlDate> ozzzzzzzzzzo_ = context.Operators.Distinct<CqlDate>(ozzzzzzzzzzn_);

        return ozzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Has Encounter with Initial and Follow Up VR12 Orthogonal Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments(CqlContext context)
    {
        IEnumerable<Encounter> pzzzzzzzzzzo_ = this.Qualifying_Encounters(context);
        IEnumerable<CqlDate> pzzzzzzzzzzp_ = this.Date_VR12_Orthogonal_Total_Assessment_Completed(context);
        IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> pzzzzzzzzzzr_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(pzzzzzzzzzzo_, pzzzzzzzzzzp_, pzzzzzzzzzzp_);
        (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12OrthogonalDate, CqlDate FollowupVR12OrthogonalDate)? pzzzzzzzzzzs_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12OrthogonalDate, CqlDate FollowupVR12OrthogonalDate)? qzzzzzzzzzza_ = (CqlTupleMetadata_HSSAQEFQAOXLjUcOKGgicELWB, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return qzzzzzzzzzza_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12OrthogonalDate, CqlDate FollowupVR12OrthogonalDate)?> pzzzzzzzzzzt_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12OrthogonalDate, CqlDate FollowupVR12OrthogonalDate)?>(pzzzzzzzzzzr_, pzzzzzzzzzzs_);
        bool? pzzzzzzzzzzu_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12OrthogonalDate, CqlDate FollowupVR12OrthogonalDate)? tuple_fansvmjaedmvsdoyrozxdlsai)
        {
            Period qzzzzzzzzzzb_ = tuple_fansvmjaedmvsdoyrozxdlsai?.ValidEncounters?.Period;
            CqlInterval<CqlDateTime> qzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.toInterval(context, qzzzzzzzzzzc_ as object);
            CqlDateTime qzzzzzzzzzze_ = context.Operators.End(qzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzf_ = this.Measurement_Period(context);
            CqlDateTime qzzzzzzzzzzg_ = context.Operators.End(qzzzzzzzzzzf_);
            CqlQuantity qzzzzzzzzzzh_ = context.Operators.Quantity(180m, "days");
            CqlDateTime qzzzzzzzzzzi_ = context.Operators.Subtract(qzzzzzzzzzzg_, qzzzzzzzzzzh_);
            bool? qzzzzzzzzzzj_ = context.Operators.SameOrBefore(qzzzzzzzzzze_, qzzzzzzzzzzi_, "day");
            CqlDateTime qzzzzzzzzzzk_ = context.Operators.ConvertDateToDateTime(tuple_fansvmjaedmvsdoyrozxdlsai?.InitialVR12OrthogonalDate);
            CqlInterval<CqlDateTime> qzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.toInterval(context, qzzzzzzzzzzm_ as object);
            CqlDateTime qzzzzzzzzzzo_ = context.Operators.End(qzzzzzzzzzzn_);
            CqlQuantity qzzzzzzzzzzp_ = context.Operators.Quantity(14m, "days");
            CqlDateTime qzzzzzzzzzzq_ = context.Operators.Subtract(qzzzzzzzzzzo_, qzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.toInterval(context, qzzzzzzzzzzs_ as object);
            CqlDateTime qzzzzzzzzzzu_ = context.Operators.End(qzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzv_ = context.Operators.Interval(qzzzzzzzzzzq_, qzzzzzzzzzzu_, true, true);
            bool? qzzzzzzzzzzw_ = context.Operators.In<CqlDateTime>(qzzzzzzzzzzk_, qzzzzzzzzzzv_, "day");
            CqlInterval<CqlDateTime> qzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, qzzzzzzzzzzy_ as object);
            CqlDateTime rzzzzzzzzzza_ = context.Operators.End(qzzzzzzzzzzz_);
            bool? rzzzzzzzzzzb_ = context.Operators.Not((bool?)(rzzzzzzzzzza_ is null));
            bool? rzzzzzzzzzzc_ = context.Operators.And(qzzzzzzzzzzw_, rzzzzzzzzzzb_);
            bool? rzzzzzzzzzzd_ = context.Operators.And(qzzzzzzzzzzj_, rzzzzzzzzzzc_);
            CqlDateTime rzzzzzzzzzze_ = context.Operators.ConvertDateToDateTime(tuple_fansvmjaedmvsdoyrozxdlsai?.FollowupVR12OrthogonalDate);
            CqlDate rzzzzzzzzzzf_ = context.Operators.DateFrom(rzzzzzzzzzze_);
            CqlDate rzzzzzzzzzzh_ = context.Operators.DateFrom(qzzzzzzzzzzk_);
            CqlQuantity rzzzzzzzzzzi_ = context.Operators.Quantity(30m, "days");
            CqlDate rzzzzzzzzzzj_ = context.Operators.Add(rzzzzzzzzzzh_, rzzzzzzzzzzi_);
            CqlDate rzzzzzzzzzzl_ = context.Operators.DateFrom(qzzzzzzzzzzk_);
            CqlDate rzzzzzzzzzzn_ = context.Operators.Add(rzzzzzzzzzzl_, qzzzzzzzzzzh_);
            CqlInterval<CqlDate> rzzzzzzzzzzo_ = context.Operators.Interval(rzzzzzzzzzzj_, rzzzzzzzzzzn_, true, true);
            bool? rzzzzzzzzzzp_ = context.Operators.In<CqlDate>(rzzzzzzzzzzf_, rzzzzzzzzzzo_, "day");
            bool? rzzzzzzzzzzq_ = context.Operators.And(rzzzzzzzzzzd_, rzzzzzzzzzzp_);

            return rzzzzzzzzzzq_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12OrthogonalDate, CqlDate FollowupVR12OrthogonalDate)?> pzzzzzzzzzzv_ = context.Operators.Where<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12OrthogonalDate, CqlDate FollowupVR12OrthogonalDate)?>(pzzzzzzzzzzt_, pzzzzzzzzzzu_);
        Encounter pzzzzzzzzzzw_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12OrthogonalDate, CqlDate FollowupVR12OrthogonalDate)? tuple_fansvmjaedmvsdoyrozxdlsai) =>
            tuple_fansvmjaedmvsdoyrozxdlsai?.ValidEncounters;
        IEnumerable<Encounter> pzzzzzzzzzzx_ = context.Operators.Select<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12OrthogonalDate, CqlDate FollowupVR12OrthogonalDate)?, Encounter>(pzzzzzzzzzzv_, pzzzzzzzzzzw_);
        IEnumerable<Encounter> pzzzzzzzzzzy_ = context.Operators.Distinct<Encounter>(pzzzzzzzzzzx_);
        bool? pzzzzzzzzzzz_ = context.Operators.Exists<Encounter>(pzzzzzzzzzzy_);

        return pzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Date VR36 Oblique Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_VR36_Oblique_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode rzzzzzzzzzzr_ = this.VR_36_Mental_component_summary__MCS__score___oblique_method_T_score(context);
        IEnumerable<CqlCode> rzzzzzzzzzzs_ = context.Operators.ToList<CqlCode>(rzzzzzzzzzzr_);
        IEnumerable<Observation> rzzzzzzzzzzt_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, rzzzzzzzzzzs_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> rzzzzzzzzzzu_ = Status_1_8_000.Instance.isAssessmentPerformed(context, rzzzzzzzzzzt_);
        CqlCode rzzzzzzzzzzv_ = this.VR_36_Physical_component_summary__PCS__score___oblique_method_T_score(context);
        IEnumerable<CqlCode> rzzzzzzzzzzw_ = context.Operators.ToList<CqlCode>(rzzzzzzzzzzv_);
        IEnumerable<Observation> rzzzzzzzzzzx_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, rzzzzzzzzzzw_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> rzzzzzzzzzzy_ = Status_1_8_000.Instance.isAssessmentPerformed(context, rzzzzzzzzzzx_);
        IEnumerable<ValueTuple<Observation, Observation>> rzzzzzzzzzzz_ = context.Operators.CrossJoin<Observation, Observation>(rzzzzzzzzzzu_, rzzzzzzzzzzy_);
        (CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)? szzzzzzzzzza_(ValueTuple<Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)? szzzzzzzzzzh_ = (CqlTupleMetadata_DUcFTCLcQEWDGGQdFCWTHFaUK, _valueTuple.Item1, _valueTuple.Item2);

            return szzzzzzzzzzh_;
        };
        IEnumerable<(CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?> szzzzzzzzzzb_ = context.Operators.Select<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?>(rzzzzzzzzzzz_, szzzzzzzzzza_);
        bool? szzzzzzzzzzc_((CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)? tuple_ducftclcqewdggqdfcwthfauk)
        {
            DataType szzzzzzzzzzi_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36MentalAssessment?.Effective;
            object szzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzi_);
            CqlInterval<CqlDateTime> szzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.toInterval(context, szzzzzzzzzzj_);
            CqlDateTime szzzzzzzzzzl_ = context.Operators.Start(szzzzzzzzzzk_);
            CqlDate szzzzzzzzzzm_ = context.Operators.DateFrom(szzzzzzzzzzl_);
            DataType szzzzzzzzzzn_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36PhysicalAssessment?.Effective;
            object szzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzn_);
            CqlInterval<CqlDateTime> szzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, szzzzzzzzzzo_);
            CqlDateTime szzzzzzzzzzq_ = context.Operators.Start(szzzzzzzzzzp_);
            CqlDate szzzzzzzzzzr_ = context.Operators.DateFrom(szzzzzzzzzzq_);
            bool? szzzzzzzzzzs_ = context.Operators.SameAs(szzzzzzzzzzm_, szzzzzzzzzzr_, "day");
            DataType szzzzzzzzzzt_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36MentalAssessment?.Value;
            object szzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzt_);
            bool? szzzzzzzzzzv_ = context.Operators.Not((bool?)(szzzzzzzzzzu_ is null));
            bool? szzzzzzzzzzw_ = context.Operators.And(szzzzzzzzzzs_, szzzzzzzzzzv_);
            DataType szzzzzzzzzzx_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36PhysicalAssessment?.Value;
            object szzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzx_);
            bool? szzzzzzzzzzz_ = context.Operators.Not((bool?)(szzzzzzzzzzy_ is null));
            bool? tzzzzzzzzzza_ = context.Operators.And(szzzzzzzzzzw_, szzzzzzzzzzz_);

            return tzzzzzzzzzza_;
        };
        IEnumerable<(CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?> szzzzzzzzzzd_ = context.Operators.Where<(CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?>(szzzzzzzzzzb_, szzzzzzzzzzc_);
        CqlDate szzzzzzzzzze_((CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)? tuple_ducftclcqewdggqdfcwthfauk)
        {
            DataType tzzzzzzzzzzb_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36MentalAssessment?.Effective;
            object tzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.toInterval(context, tzzzzzzzzzzc_);
            CqlDateTime tzzzzzzzzzze_ = context.Operators.Start(tzzzzzzzzzzd_);
            CqlDate tzzzzzzzzzzf_ = context.Operators.DateFrom(tzzzzzzzzzze_);

            return tzzzzzzzzzzf_;
        };
        IEnumerable<CqlDate> szzzzzzzzzzf_ = context.Operators.Select<(CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?, CqlDate>(szzzzzzzzzzd_, szzzzzzzzzze_);
        IEnumerable<CqlDate> szzzzzzzzzzg_ = context.Operators.Distinct<CqlDate>(szzzzzzzzzzf_);

        return szzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Has Encounter with Initial and Follow Up VR36 Oblique Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_VR36_Oblique_Assessments(CqlContext context)
    {
        IEnumerable<Encounter> tzzzzzzzzzzg_ = this.Qualifying_Encounters(context);
        IEnumerable<CqlDate> tzzzzzzzzzzh_ = this.Date_VR36_Oblique_Total_Assessment_Completed(context);
        IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> tzzzzzzzzzzj_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(tzzzzzzzzzzg_, tzzzzzzzzzzh_, tzzzzzzzzzzh_);
        (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36ObliqueDate, CqlDate FollowupVR36ObliqueDate)? tzzzzzzzzzzk_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36ObliqueDate, CqlDate FollowupVR36ObliqueDate)? tzzzzzzzzzzs_ = (CqlTupleMetadata_HQfcMfhQUSTNYMWSgJHiFeahQ, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return tzzzzzzzzzzs_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36ObliqueDate, CqlDate FollowupVR36ObliqueDate)?> tzzzzzzzzzzl_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36ObliqueDate, CqlDate FollowupVR36ObliqueDate)?>(tzzzzzzzzzzj_, tzzzzzzzzzzk_);
        bool? tzzzzzzzzzzm_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36ObliqueDate, CqlDate FollowupVR36ObliqueDate)? tuple_elxicyhrdpyzpqyjphdifbiga)
        {
            Period tzzzzzzzzzzt_ = tuple_elxicyhrdpyzpqyjphdifbiga?.ValidEncounters?.Period;
            CqlInterval<CqlDateTime> tzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, tzzzzzzzzzzu_ as object);
            CqlDateTime tzzzzzzzzzzw_ = context.Operators.End(tzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzx_ = this.Measurement_Period(context);
            CqlDateTime tzzzzzzzzzzy_ = context.Operators.End(tzzzzzzzzzzx_);
            CqlQuantity tzzzzzzzzzzz_ = context.Operators.Quantity(180m, "days");
            CqlDateTime uzzzzzzzzzza_ = context.Operators.Subtract(tzzzzzzzzzzy_, tzzzzzzzzzzz_);
            bool? uzzzzzzzzzzb_ = context.Operators.SameOrBefore(tzzzzzzzzzzw_, uzzzzzzzzzza_, "day");
            CqlDateTime uzzzzzzzzzzc_ = context.Operators.ConvertDateToDateTime(tuple_elxicyhrdpyzpqyjphdifbiga?.InitialVR36ObliqueDate);
            CqlInterval<CqlDateTime> uzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, uzzzzzzzzzze_ as object);
            CqlDateTime uzzzzzzzzzzg_ = context.Operators.End(uzzzzzzzzzzf_);
            CqlQuantity uzzzzzzzzzzh_ = context.Operators.Quantity(14m, "days");
            CqlDateTime uzzzzzzzzzzi_ = context.Operators.Subtract(uzzzzzzzzzzg_, uzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, uzzzzzzzzzzk_ as object);
            CqlDateTime uzzzzzzzzzzm_ = context.Operators.End(uzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzn_ = context.Operators.Interval(uzzzzzzzzzzi_, uzzzzzzzzzzm_, true, true);
            bool? uzzzzzzzzzzo_ = context.Operators.In<CqlDateTime>(uzzzzzzzzzzc_, uzzzzzzzzzzn_, "day");
            CqlInterval<CqlDateTime> uzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, uzzzzzzzzzzq_ as object);
            CqlDateTime uzzzzzzzzzzs_ = context.Operators.End(uzzzzzzzzzzr_);
            bool? uzzzzzzzzzzt_ = context.Operators.Not((bool?)(uzzzzzzzzzzs_ is null));
            bool? uzzzzzzzzzzu_ = context.Operators.And(uzzzzzzzzzzo_, uzzzzzzzzzzt_);
            bool? uzzzzzzzzzzv_ = context.Operators.And(uzzzzzzzzzzb_, uzzzzzzzzzzu_);
            CqlDateTime uzzzzzzzzzzw_ = context.Operators.ConvertDateToDateTime(tuple_elxicyhrdpyzpqyjphdifbiga?.FollowupVR36ObliqueDate);
            CqlDate uzzzzzzzzzzx_ = context.Operators.DateFrom(uzzzzzzzzzzw_);
            CqlDate uzzzzzzzzzzz_ = context.Operators.DateFrom(uzzzzzzzzzzc_);
            CqlQuantity vzzzzzzzzzza_ = context.Operators.Quantity(30m, "days");
            CqlDate vzzzzzzzzzzb_ = context.Operators.Add(uzzzzzzzzzzz_, vzzzzzzzzzza_);
            CqlDate vzzzzzzzzzzd_ = context.Operators.DateFrom(uzzzzzzzzzzc_);
            CqlDate vzzzzzzzzzzf_ = context.Operators.Add(vzzzzzzzzzzd_, tzzzzzzzzzzz_);
            CqlInterval<CqlDate> vzzzzzzzzzzg_ = context.Operators.Interval(vzzzzzzzzzzb_, vzzzzzzzzzzf_, true, true);
            bool? vzzzzzzzzzzh_ = context.Operators.In<CqlDate>(uzzzzzzzzzzx_, vzzzzzzzzzzg_, "day");
            bool? vzzzzzzzzzzi_ = context.Operators.And(uzzzzzzzzzzv_, vzzzzzzzzzzh_);

            return vzzzzzzzzzzi_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36ObliqueDate, CqlDate FollowupVR36ObliqueDate)?> tzzzzzzzzzzn_ = context.Operators.Where<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36ObliqueDate, CqlDate FollowupVR36ObliqueDate)?>(tzzzzzzzzzzl_, tzzzzzzzzzzm_);
        Encounter tzzzzzzzzzzo_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36ObliqueDate, CqlDate FollowupVR36ObliqueDate)? tuple_elxicyhrdpyzpqyjphdifbiga) =>
            tuple_elxicyhrdpyzpqyjphdifbiga?.ValidEncounters;
        IEnumerable<Encounter> tzzzzzzzzzzp_ = context.Operators.Select<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36ObliqueDate, CqlDate FollowupVR36ObliqueDate)?, Encounter>(tzzzzzzzzzzn_, tzzzzzzzzzzo_);
        IEnumerable<Encounter> tzzzzzzzzzzq_ = context.Operators.Distinct<Encounter>(tzzzzzzzzzzp_);
        bool? tzzzzzzzzzzr_ = context.Operators.Exists<Encounter>(tzzzzzzzzzzq_);

        return tzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Date VR36 Orthogonal Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_VR36_Orthogonal_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode vzzzzzzzzzzj_ = this.VR_36_Mental_component_summary__MCS__score___orthogonal_method_T_score(context);
        IEnumerable<CqlCode> vzzzzzzzzzzk_ = context.Operators.ToList<CqlCode>(vzzzzzzzzzzj_);
        IEnumerable<Observation> vzzzzzzzzzzl_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, vzzzzzzzzzzk_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> vzzzzzzzzzzm_ = Status_1_8_000.Instance.isAssessmentPerformed(context, vzzzzzzzzzzl_);
        CqlCode vzzzzzzzzzzn_ = this.VR_36_Physical_component_summary__PCS__score___orthogonal_method_T_score(context);
        IEnumerable<CqlCode> vzzzzzzzzzzo_ = context.Operators.ToList<CqlCode>(vzzzzzzzzzzn_);
        IEnumerable<Observation> vzzzzzzzzzzp_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, vzzzzzzzzzzo_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> vzzzzzzzzzzq_ = Status_1_8_000.Instance.isAssessmentPerformed(context, vzzzzzzzzzzp_);
        IEnumerable<ValueTuple<Observation, Observation>> vzzzzzzzzzzr_ = context.Operators.CrossJoin<Observation, Observation>(vzzzzzzzzzzm_, vzzzzzzzzzzq_);
        (CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)? vzzzzzzzzzzs_(ValueTuple<Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)? vzzzzzzzzzzz_ = (CqlTupleMetadata_DUcFTCLcQEWDGGQdFCWTHFaUK, _valueTuple.Item1, _valueTuple.Item2);

            return vzzzzzzzzzzz_;
        };
        IEnumerable<(CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?> vzzzzzzzzzzt_ = context.Operators.Select<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?>(vzzzzzzzzzzr_, vzzzzzzzzzzs_);
        bool? vzzzzzzzzzzu_((CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)? tuple_ducftclcqewdggqdfcwthfauk)
        {
            DataType wzzzzzzzzzza_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36MentalAssessment?.Effective;
            object wzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzza_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, wzzzzzzzzzzb_);
            CqlDateTime wzzzzzzzzzzd_ = context.Operators.Start(wzzzzzzzzzzc_);
            CqlDate wzzzzzzzzzze_ = context.Operators.DateFrom(wzzzzzzzzzzd_);
            DataType wzzzzzzzzzzf_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36PhysicalAssessment?.Effective;
            object wzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.toInterval(context, wzzzzzzzzzzg_);
            CqlDateTime wzzzzzzzzzzi_ = context.Operators.Start(wzzzzzzzzzzh_);
            CqlDate wzzzzzzzzzzj_ = context.Operators.DateFrom(wzzzzzzzzzzi_);
            bool? wzzzzzzzzzzk_ = context.Operators.SameAs(wzzzzzzzzzze_, wzzzzzzzzzzj_, "day");
            DataType wzzzzzzzzzzl_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36MentalAssessment?.Value;
            object wzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzl_);
            bool? wzzzzzzzzzzn_ = context.Operators.Not((bool?)(wzzzzzzzzzzm_ is null));
            bool? wzzzzzzzzzzo_ = context.Operators.And(wzzzzzzzzzzk_, wzzzzzzzzzzn_);
            DataType wzzzzzzzzzzp_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36PhysicalAssessment?.Value;
            object wzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzp_);
            bool? wzzzzzzzzzzr_ = context.Operators.Not((bool?)(wzzzzzzzzzzq_ is null));
            bool? wzzzzzzzzzzs_ = context.Operators.And(wzzzzzzzzzzo_, wzzzzzzzzzzr_);

            return wzzzzzzzzzzs_;
        };
        IEnumerable<(CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?> vzzzzzzzzzzv_ = context.Operators.Where<(CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?>(vzzzzzzzzzzt_, vzzzzzzzzzzu_);
        CqlDate vzzzzzzzzzzw_((CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)? tuple_ducftclcqewdggqdfcwthfauk)
        {
            DataType wzzzzzzzzzzt_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36MentalAssessment?.Effective;
            object wzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, wzzzzzzzzzzu_);
            CqlDateTime wzzzzzzzzzzw_ = context.Operators.Start(wzzzzzzzzzzv_);
            CqlDate wzzzzzzzzzzx_ = context.Operators.DateFrom(wzzzzzzzzzzw_);

            return wzzzzzzzzzzx_;
        };
        IEnumerable<CqlDate> vzzzzzzzzzzx_ = context.Operators.Select<(CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?, CqlDate>(vzzzzzzzzzzv_, vzzzzzzzzzzw_);
        IEnumerable<CqlDate> vzzzzzzzzzzy_ = context.Operators.Distinct<CqlDate>(vzzzzzzzzzzx_);

        return vzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Has Encounter with Initial and Follow Up VR36 Orthogonal Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_VR36_Orthogonal_Assessments(CqlContext context)
    {
        IEnumerable<Encounter> wzzzzzzzzzzy_ = this.Qualifying_Encounters(context);
        IEnumerable<CqlDate> wzzzzzzzzzzz_ = this.Date_VR36_Orthogonal_Total_Assessment_Completed(context);
        IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> xzzzzzzzzzzb_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(wzzzzzzzzzzy_, wzzzzzzzzzzz_, wzzzzzzzzzzz_);
        (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36OrthogonalDate, CqlDate FollowupVR36OrthogonalDate)? xzzzzzzzzzzc_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36OrthogonalDate, CqlDate FollowupVR36OrthogonalDate)? xzzzzzzzzzzk_ = (CqlTupleMetadata_BFZHWdOOROjSjFSECHcQiaZZZ, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return xzzzzzzzzzzk_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36OrthogonalDate, CqlDate FollowupVR36OrthogonalDate)?> xzzzzzzzzzzd_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36OrthogonalDate, CqlDate FollowupVR36OrthogonalDate)?>(xzzzzzzzzzzb_, xzzzzzzzzzzc_);
        bool? xzzzzzzzzzze_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36OrthogonalDate, CqlDate FollowupVR36OrthogonalDate)? tuple_fucqujadjizabihdffformht)
        {
            Period xzzzzzzzzzzl_ = tuple_fucqujadjizabihdffformht?.ValidEncounters?.Period;
            CqlInterval<CqlDateTime> xzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzzm_ as object);
            CqlDateTime xzzzzzzzzzzo_ = context.Operators.End(xzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzp_ = this.Measurement_Period(context);
            CqlDateTime xzzzzzzzzzzq_ = context.Operators.End(xzzzzzzzzzzp_);
            CqlQuantity xzzzzzzzzzzr_ = context.Operators.Quantity(180m, "days");
            CqlDateTime xzzzzzzzzzzs_ = context.Operators.Subtract(xzzzzzzzzzzq_, xzzzzzzzzzzr_);
            bool? xzzzzzzzzzzt_ = context.Operators.SameOrBefore(xzzzzzzzzzzo_, xzzzzzzzzzzs_, "day");
            CqlDateTime xzzzzzzzzzzu_ = context.Operators.ConvertDateToDateTime(tuple_fucqujadjizabihdffformht?.InitialVR36OrthogonalDate);
            CqlInterval<CqlDateTime> xzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzzw_ as object);
            CqlDateTime xzzzzzzzzzzy_ = context.Operators.End(xzzzzzzzzzzx_);
            CqlQuantity xzzzzzzzzzzz_ = context.Operators.Quantity(14m, "days");
            CqlDateTime yzzzzzzzzzza_ = context.Operators.Subtract(xzzzzzzzzzzy_, xzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.toInterval(context, yzzzzzzzzzzc_ as object);
            CqlDateTime yzzzzzzzzzze_ = context.Operators.End(yzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzf_ = context.Operators.Interval(yzzzzzzzzzza_, yzzzzzzzzzze_, true, true);
            bool? yzzzzzzzzzzg_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzzu_, yzzzzzzzzzzf_, "day");
            CqlInterval<CqlDateTime> yzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.toInterval(context, yzzzzzzzzzzi_ as object);
            CqlDateTime yzzzzzzzzzzk_ = context.Operators.End(yzzzzzzzzzzj_);
            bool? yzzzzzzzzzzl_ = context.Operators.Not((bool?)(yzzzzzzzzzzk_ is null));
            bool? yzzzzzzzzzzm_ = context.Operators.And(yzzzzzzzzzzg_, yzzzzzzzzzzl_);
            bool? yzzzzzzzzzzn_ = context.Operators.And(xzzzzzzzzzzt_, yzzzzzzzzzzm_);
            CqlDateTime yzzzzzzzzzzo_ = context.Operators.ConvertDateToDateTime(tuple_fucqujadjizabihdffformht?.FollowupVR36OrthogonalDate);
            CqlDate yzzzzzzzzzzp_ = context.Operators.DateFrom(yzzzzzzzzzzo_);
            CqlDate yzzzzzzzzzzr_ = context.Operators.DateFrom(xzzzzzzzzzzu_);
            CqlQuantity yzzzzzzzzzzs_ = context.Operators.Quantity(30m, "days");
            CqlDate yzzzzzzzzzzt_ = context.Operators.Add(yzzzzzzzzzzr_, yzzzzzzzzzzs_);
            CqlDate yzzzzzzzzzzv_ = context.Operators.DateFrom(xzzzzzzzzzzu_);
            CqlDate yzzzzzzzzzzx_ = context.Operators.Add(yzzzzzzzzzzv_, xzzzzzzzzzzr_);
            CqlInterval<CqlDate> yzzzzzzzzzzy_ = context.Operators.Interval(yzzzzzzzzzzt_, yzzzzzzzzzzx_, true, true);
            bool? yzzzzzzzzzzz_ = context.Operators.In<CqlDate>(yzzzzzzzzzzp_, yzzzzzzzzzzy_, "day");
            bool? zzzzzzzzzzza_ = context.Operators.And(yzzzzzzzzzzn_, yzzzzzzzzzzz_);

            return zzzzzzzzzzza_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36OrthogonalDate, CqlDate FollowupVR36OrthogonalDate)?> xzzzzzzzzzzf_ = context.Operators.Where<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36OrthogonalDate, CqlDate FollowupVR36OrthogonalDate)?>(xzzzzzzzzzzd_, xzzzzzzzzzze_);
        Encounter xzzzzzzzzzzg_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36OrthogonalDate, CqlDate FollowupVR36OrthogonalDate)? tuple_fucqujadjizabihdffformht) =>
            tuple_fucqujadjizabihdffformht?.ValidEncounters;
        IEnumerable<Encounter> xzzzzzzzzzzh_ = context.Operators.Select<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36OrthogonalDate, CqlDate FollowupVR36OrthogonalDate)?, Encounter>(xzzzzzzzzzzf_, xzzzzzzzzzzg_);
        IEnumerable<Encounter> xzzzzzzzzzzi_ = context.Operators.Distinct<Encounter>(xzzzzzzzzzzh_);
        bool? xzzzzzzzzzzj_ = context.Operators.Exists<Encounter>(xzzzzzzzzzzi_);

        return xzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Date MLHFQ Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_MLHFQ_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode zzzzzzzzzzzb_ = this.Physical_score__MLHFQ_(context);
        IEnumerable<CqlCode> zzzzzzzzzzzc_ = context.Operators.ToList<CqlCode>(zzzzzzzzzzzb_);
        IEnumerable<Observation> zzzzzzzzzzzd_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, zzzzzzzzzzzc_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> zzzzzzzzzzze_ = Status_1_8_000.Instance.isAssessmentPerformed(context, zzzzzzzzzzzd_);
        CqlCode zzzzzzzzzzzf_ = this.Emotional_score__MLHFQ_(context);
        IEnumerable<CqlCode> zzzzzzzzzzzg_ = context.Operators.ToList<CqlCode>(zzzzzzzzzzzf_);
        IEnumerable<Observation> zzzzzzzzzzzh_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, zzzzzzzzzzzg_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> zzzzzzzzzzzi_ = Status_1_8_000.Instance.isAssessmentPerformed(context, zzzzzzzzzzzh_);
        IEnumerable<ValueTuple<Observation, Observation>> zzzzzzzzzzzj_ = context.Operators.CrossJoin<Observation, Observation>(zzzzzzzzzzze_, zzzzzzzzzzzi_);
        (CqlTupleMetadata, Observation MLHFQPhysical, Observation MLHFQEmotional)? zzzzzzzzzzzk_(ValueTuple<Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation MLHFQPhysical, Observation MLHFQEmotional)? zzzzzzzzzzzr_ = (CqlTupleMetadata_EBLWeAeedHPAfOJXKPZJKSCUf, _valueTuple.Item1, _valueTuple.Item2);

            return zzzzzzzzzzzr_;
        };
        IEnumerable<(CqlTupleMetadata, Observation MLHFQPhysical, Observation MLHFQEmotional)?> zzzzzzzzzzzl_ = context.Operators.Select<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation MLHFQPhysical, Observation MLHFQEmotional)?>(zzzzzzzzzzzj_, zzzzzzzzzzzk_);
        bool? zzzzzzzzzzzm_((CqlTupleMetadata, Observation MLHFQPhysical, Observation MLHFQEmotional)? tuple_fnofxckadaeusjerhbdqfoshe)
        {
            DataType zzzzzzzzzzzs_ = tuple_fnofxckadaeusjerhbdqfoshe?.MLHFQPhysical?.Effective;
            object zzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> zzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, zzzzzzzzzzzt_);
            CqlDateTime zzzzzzzzzzzv_ = context.Operators.Start(zzzzzzzzzzzu_);
            CqlDate zzzzzzzzzzzw_ = context.Operators.DateFrom(zzzzzzzzzzzv_);
            DataType zzzzzzzzzzzx_ = tuple_fnofxckadaeusjerhbdqfoshe?.MLHFQEmotional?.Effective;
            object zzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> zzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, zzzzzzzzzzzy_);
            CqlDateTime azzzzzzzzzzza_ = context.Operators.Start(zzzzzzzzzzzz_);
            CqlDate azzzzzzzzzzzb_ = context.Operators.DateFrom(azzzzzzzzzzza_);
            bool? azzzzzzzzzzzc_ = context.Operators.SameAs(zzzzzzzzzzzw_, azzzzzzzzzzzb_, "day");
            DataType azzzzzzzzzzzd_ = tuple_fnofxckadaeusjerhbdqfoshe?.MLHFQPhysical?.Value;
            object azzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzd_);
            bool? azzzzzzzzzzzf_ = context.Operators.Not((bool?)(azzzzzzzzzzze_ is null));
            bool? azzzzzzzzzzzg_ = context.Operators.And(azzzzzzzzzzzc_, azzzzzzzzzzzf_);
            DataType azzzzzzzzzzzh_ = tuple_fnofxckadaeusjerhbdqfoshe?.MLHFQEmotional?.Value;
            object azzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzh_);
            bool? azzzzzzzzzzzj_ = context.Operators.Not((bool?)(azzzzzzzzzzzi_ is null));
            bool? azzzzzzzzzzzk_ = context.Operators.And(azzzzzzzzzzzg_, azzzzzzzzzzzj_);

            return azzzzzzzzzzzk_;
        };
        IEnumerable<(CqlTupleMetadata, Observation MLHFQPhysical, Observation MLHFQEmotional)?> zzzzzzzzzzzn_ = context.Operators.Where<(CqlTupleMetadata, Observation MLHFQPhysical, Observation MLHFQEmotional)?>(zzzzzzzzzzzl_, zzzzzzzzzzzm_);
        CqlDate zzzzzzzzzzzo_((CqlTupleMetadata, Observation MLHFQPhysical, Observation MLHFQEmotional)? tuple_fnofxckadaeusjerhbdqfoshe)
        {
            DataType azzzzzzzzzzzl_ = tuple_fnofxckadaeusjerhbdqfoshe?.MLHFQPhysical?.Effective;
            object azzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.toInterval(context, azzzzzzzzzzzm_);
            CqlDateTime azzzzzzzzzzzo_ = context.Operators.Start(azzzzzzzzzzzn_);
            CqlDate azzzzzzzzzzzp_ = context.Operators.DateFrom(azzzzzzzzzzzo_);

            return azzzzzzzzzzzp_;
        };
        IEnumerable<CqlDate> zzzzzzzzzzzp_ = context.Operators.Select<(CqlTupleMetadata, Observation MLHFQPhysical, Observation MLHFQEmotional)?, CqlDate>(zzzzzzzzzzzn_, zzzzzzzzzzzo_);
        IEnumerable<CqlDate> zzzzzzzzzzzq_ = context.Operators.Distinct<CqlDate>(zzzzzzzzzzzp_);

        return zzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Has Encounter with Initial and Follow Up MLHFQ Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_MLHFQ_Assessments(CqlContext context)
    {
        IEnumerable<Encounter> azzzzzzzzzzzq_ = this.Qualifying_Encounters(context);
        IEnumerable<CqlDate> azzzzzzzzzzzr_ = this.Date_MLHFQ_Total_Assessment_Completed(context);
        IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> azzzzzzzzzzzt_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(azzzzzzzzzzzq_, azzzzzzzzzzzr_, azzzzzzzzzzzr_);
        (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialMLHFQDate, CqlDate FollowupMLHFQDate)? azzzzzzzzzzzu_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialMLHFQDate, CqlDate FollowupMLHFQDate)? bzzzzzzzzzzzc_ = (CqlTupleMetadata_CcaWSNDiVeaLebVKKWWWiBcEU, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return bzzzzzzzzzzzc_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialMLHFQDate, CqlDate FollowupMLHFQDate)?> azzzzzzzzzzzv_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialMLHFQDate, CqlDate FollowupMLHFQDate)?>(azzzzzzzzzzzt_, azzzzzzzzzzzu_);
        bool? azzzzzzzzzzzw_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialMLHFQDate, CqlDate FollowupMLHFQDate)? tuple_ncdawctnmbfmtibmihsfbaig)
        {
            Period bzzzzzzzzzzzd_ = tuple_ncdawctnmbfmtibmihsfbaig?.ValidEncounters?.Period;
            CqlInterval<CqlDateTime> bzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzze_ as object);
            CqlDateTime bzzzzzzzzzzzg_ = context.Operators.End(bzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzh_ = this.Measurement_Period(context);
            CqlDateTime bzzzzzzzzzzzi_ = context.Operators.End(bzzzzzzzzzzzh_);
            CqlQuantity bzzzzzzzzzzzj_ = context.Operators.Quantity(180m, "days");
            CqlDateTime bzzzzzzzzzzzk_ = context.Operators.Subtract(bzzzzzzzzzzzi_, bzzzzzzzzzzzj_);
            bool? bzzzzzzzzzzzl_ = context.Operators.SameOrBefore(bzzzzzzzzzzzg_, bzzzzzzzzzzzk_, "day");
            CqlDateTime bzzzzzzzzzzzm_ = context.Operators.ConvertDateToDateTime(tuple_ncdawctnmbfmtibmihsfbaig?.InitialMLHFQDate);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzo_ as object);
            CqlDateTime bzzzzzzzzzzzq_ = context.Operators.End(bzzzzzzzzzzzp_);
            CqlQuantity bzzzzzzzzzzzr_ = context.Operators.Quantity(14m, "days");
            CqlDateTime bzzzzzzzzzzzs_ = context.Operators.Subtract(bzzzzzzzzzzzq_, bzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzu_ as object);
            CqlDateTime bzzzzzzzzzzzw_ = context.Operators.End(bzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzx_ = context.Operators.Interval(bzzzzzzzzzzzs_, bzzzzzzzzzzzw_, true, true);
            bool? bzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(bzzzzzzzzzzzm_, bzzzzzzzzzzzx_, "day");
            CqlInterval<CqlDateTime> czzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, czzzzzzzzzzza_ as object);
            CqlDateTime czzzzzzzzzzzc_ = context.Operators.End(czzzzzzzzzzzb_);
            bool? czzzzzzzzzzzd_ = context.Operators.Not((bool?)(czzzzzzzzzzzc_ is null));
            bool? czzzzzzzzzzze_ = context.Operators.And(bzzzzzzzzzzzy_, czzzzzzzzzzzd_);
            bool? czzzzzzzzzzzf_ = context.Operators.And(bzzzzzzzzzzzl_, czzzzzzzzzzze_);
            CqlDateTime czzzzzzzzzzzg_ = context.Operators.ConvertDateToDateTime(tuple_ncdawctnmbfmtibmihsfbaig?.FollowupMLHFQDate);
            CqlDate czzzzzzzzzzzh_ = context.Operators.DateFrom(czzzzzzzzzzzg_);
            CqlDate czzzzzzzzzzzj_ = context.Operators.DateFrom(bzzzzzzzzzzzm_);
            CqlQuantity czzzzzzzzzzzk_ = context.Operators.Quantity(30m, "days");
            CqlDate czzzzzzzzzzzl_ = context.Operators.Add(czzzzzzzzzzzj_, czzzzzzzzzzzk_);
            CqlDate czzzzzzzzzzzn_ = context.Operators.DateFrom(bzzzzzzzzzzzm_);
            CqlDate czzzzzzzzzzzp_ = context.Operators.Add(czzzzzzzzzzzn_, bzzzzzzzzzzzj_);
            CqlInterval<CqlDate> czzzzzzzzzzzq_ = context.Operators.Interval(czzzzzzzzzzzl_, czzzzzzzzzzzp_, true, true);
            bool? czzzzzzzzzzzr_ = context.Operators.In<CqlDate>(czzzzzzzzzzzh_, czzzzzzzzzzzq_, "day");
            bool? czzzzzzzzzzzs_ = context.Operators.And(czzzzzzzzzzzf_, czzzzzzzzzzzr_);

            return czzzzzzzzzzzs_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialMLHFQDate, CqlDate FollowupMLHFQDate)?> azzzzzzzzzzzx_ = context.Operators.Where<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialMLHFQDate, CqlDate FollowupMLHFQDate)?>(azzzzzzzzzzzv_, azzzzzzzzzzzw_);
        Encounter azzzzzzzzzzzy_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialMLHFQDate, CqlDate FollowupMLHFQDate)? tuple_ncdawctnmbfmtibmihsfbaig) =>
            tuple_ncdawctnmbfmtibmihsfbaig?.ValidEncounters;
        IEnumerable<Encounter> azzzzzzzzzzzz_ = context.Operators.Select<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialMLHFQDate, CqlDate FollowupMLHFQDate)?, Encounter>(azzzzzzzzzzzx_, azzzzzzzzzzzy_);
        IEnumerable<Encounter> bzzzzzzzzzzza_ = context.Operators.Distinct<Encounter>(azzzzzzzzzzzz_);
        bool? bzzzzzzzzzzzb_ = context.Operators.Exists<Encounter>(bzzzzzzzzzzza_);

        return bzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Date KCCQ12 Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_KCCQ12_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode czzzzzzzzzzzt_ = this.Kansas_City_Cardiomyopathy_Questionnaire___12_item__KCCQ_12_(context);
        IEnumerable<CqlCode> czzzzzzzzzzzu_ = context.Operators.ToList<CqlCode>(czzzzzzzzzzzt_);
        IEnumerable<Observation> czzzzzzzzzzzv_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, czzzzzzzzzzzu_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> czzzzzzzzzzzw_ = Status_1_8_000.Instance.isAssessmentPerformed(context, czzzzzzzzzzzv_);
        CqlCode czzzzzzzzzzzx_ = this.Overall_summary_score__KCCQ_12_(context);
        IEnumerable<CqlCode> czzzzzzzzzzzy_ = context.Operators.ToList<CqlCode>(czzzzzzzzzzzx_);
        IEnumerable<Observation> czzzzzzzzzzzz_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, czzzzzzzzzzzy_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> dzzzzzzzzzzza_ = Status_1_8_000.Instance.isAssessmentPerformed(context, czzzzzzzzzzzz_);
        IEnumerable<ValueTuple<Observation, Observation>> dzzzzzzzzzzzb_ = context.Operators.CrossJoin<Observation, Observation>(czzzzzzzzzzzw_, dzzzzzzzzzzza_);
        (CqlTupleMetadata, Observation KCCQ12Item, Observation KCCQ12Summary)? dzzzzzzzzzzzc_(ValueTuple<Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation KCCQ12Item, Observation KCCQ12Summary)? dzzzzzzzzzzzj_ = (CqlTupleMetadata_DFKXORghhYafccUSbQaMfNTDj, _valueTuple.Item1, _valueTuple.Item2);

            return dzzzzzzzzzzzj_;
        };
        IEnumerable<(CqlTupleMetadata, Observation KCCQ12Item, Observation KCCQ12Summary)?> dzzzzzzzzzzzd_ = context.Operators.Select<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation KCCQ12Item, Observation KCCQ12Summary)?>(dzzzzzzzzzzzb_, dzzzzzzzzzzzc_);
        bool? dzzzzzzzzzzze_((CqlTupleMetadata, Observation KCCQ12Item, Observation KCCQ12Summary)? tuple_dfkxorghhyafccusbqamfntdj)
        {
            DataType dzzzzzzzzzzzk_ = tuple_dfkxorghhyafccusbqamfntdj?.KCCQ12Item?.Effective;
            object dzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzk_);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.toInterval(context, dzzzzzzzzzzzl_);
            CqlDateTime dzzzzzzzzzzzn_ = context.Operators.Start(dzzzzzzzzzzzm_);
            CqlDate dzzzzzzzzzzzo_ = context.Operators.DateFrom(dzzzzzzzzzzzn_);
            DataType dzzzzzzzzzzzp_ = tuple_dfkxorghhyafccusbqamfntdj?.KCCQ12Summary?.Effective;
            object dzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, dzzzzzzzzzzzq_);
            CqlDateTime dzzzzzzzzzzzs_ = context.Operators.Start(dzzzzzzzzzzzr_);
            CqlDate dzzzzzzzzzzzt_ = context.Operators.DateFrom(dzzzzzzzzzzzs_);
            bool? dzzzzzzzzzzzu_ = context.Operators.SameAs(dzzzzzzzzzzzo_, dzzzzzzzzzzzt_, "day");
            DataType dzzzzzzzzzzzv_ = tuple_dfkxorghhyafccusbqamfntdj?.KCCQ12Item?.Value;
            object dzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzv_);
            bool? dzzzzzzzzzzzx_ = context.Operators.Not((bool?)(dzzzzzzzzzzzw_ is null));
            bool? dzzzzzzzzzzzy_ = context.Operators.And(dzzzzzzzzzzzu_, dzzzzzzzzzzzx_);
            DataType dzzzzzzzzzzzz_ = tuple_dfkxorghhyafccusbqamfntdj?.KCCQ12Summary?.Value;
            object ezzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzz_);
            bool? ezzzzzzzzzzzb_ = context.Operators.Not((bool?)(ezzzzzzzzzzza_ is null));
            bool? ezzzzzzzzzzzc_ = context.Operators.And(dzzzzzzzzzzzy_, ezzzzzzzzzzzb_);

            return ezzzzzzzzzzzc_;
        };
        IEnumerable<(CqlTupleMetadata, Observation KCCQ12Item, Observation KCCQ12Summary)?> dzzzzzzzzzzzf_ = context.Operators.Where<(CqlTupleMetadata, Observation KCCQ12Item, Observation KCCQ12Summary)?>(dzzzzzzzzzzzd_, dzzzzzzzzzzze_);
        CqlDate dzzzzzzzzzzzg_((CqlTupleMetadata, Observation KCCQ12Item, Observation KCCQ12Summary)? tuple_dfkxorghhyafccusbqamfntdj)
        {
            DataType ezzzzzzzzzzzd_ = tuple_dfkxorghhyafccusbqamfntdj?.KCCQ12Item?.Effective;
            object ezzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, ezzzzzzzzzzze_);
            CqlDateTime ezzzzzzzzzzzg_ = context.Operators.Start(ezzzzzzzzzzzf_);
            CqlDate ezzzzzzzzzzzh_ = context.Operators.DateFrom(ezzzzzzzzzzzg_);

            return ezzzzzzzzzzzh_;
        };
        IEnumerable<CqlDate> dzzzzzzzzzzzh_ = context.Operators.Select<(CqlTupleMetadata, Observation KCCQ12Item, Observation KCCQ12Summary)?, CqlDate>(dzzzzzzzzzzzf_, dzzzzzzzzzzzg_);
        IEnumerable<CqlDate> dzzzzzzzzzzzi_ = context.Operators.Distinct<CqlDate>(dzzzzzzzzzzzh_);

        return dzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Has Encounter with Initial and Follow Up KCCQ12 Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_KCCQ12_Assessments(CqlContext context)
    {
        IEnumerable<Encounter> ezzzzzzzzzzzi_ = this.Qualifying_Encounters(context);
        IEnumerable<CqlDate> ezzzzzzzzzzzj_ = this.Date_KCCQ12_Total_Assessment_Completed(context);
        IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> ezzzzzzzzzzzl_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(ezzzzzzzzzzzi_, ezzzzzzzzzzzj_, ezzzzzzzzzzzj_);
        (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQ12Date, CqlDate FollowupKCCQ12Date)? ezzzzzzzzzzzm_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQ12Date, CqlDate FollowupKCCQ12Date)? ezzzzzzzzzzzu_ = (CqlTupleMetadata_EQQLFFBVIbLIQLiZDNfeYdMU, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return ezzzzzzzzzzzu_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQ12Date, CqlDate FollowupKCCQ12Date)?> ezzzzzzzzzzzn_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQ12Date, CqlDate FollowupKCCQ12Date)?>(ezzzzzzzzzzzl_, ezzzzzzzzzzzm_);
        bool? ezzzzzzzzzzzo_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQ12Date, CqlDate FollowupKCCQ12Date)? tuple_eoahgtwwdfqijhcjzqnvidvuo)
        {
            Period ezzzzzzzzzzzv_ = tuple_eoahgtwwdfqijhcjzqnvidvuo?.ValidEncounters?.Period;
            CqlInterval<CqlDateTime> ezzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.toInterval(context, ezzzzzzzzzzzw_ as object);
            CqlDateTime ezzzzzzzzzzzy_ = context.Operators.End(ezzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzz_ = this.Measurement_Period(context);
            CqlDateTime fzzzzzzzzzzza_ = context.Operators.End(ezzzzzzzzzzzz_);
            CqlQuantity fzzzzzzzzzzzb_ = context.Operators.Quantity(180m, "days");
            CqlDateTime fzzzzzzzzzzzc_ = context.Operators.Subtract(fzzzzzzzzzzza_, fzzzzzzzzzzzb_);
            bool? fzzzzzzzzzzzd_ = context.Operators.SameOrBefore(ezzzzzzzzzzzy_, fzzzzzzzzzzzc_, "day");
            CqlDateTime fzzzzzzzzzzze_ = context.Operators.ConvertDateToDateTime(tuple_eoahgtwwdfqijhcjzqnvidvuo?.InitialKCCQ12Date);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.toInterval(context, fzzzzzzzzzzzg_ as object);
            CqlDateTime fzzzzzzzzzzzi_ = context.Operators.End(fzzzzzzzzzzzh_);
            CqlQuantity fzzzzzzzzzzzj_ = context.Operators.Quantity(14m, "days");
            CqlDateTime fzzzzzzzzzzzk_ = context.Operators.Subtract(fzzzzzzzzzzzi_, fzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.toInterval(context, fzzzzzzzzzzzm_ as object);
            CqlDateTime fzzzzzzzzzzzo_ = context.Operators.End(fzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzp_ = context.Operators.Interval(fzzzzzzzzzzzk_, fzzzzzzzzzzzo_, true, true);
            bool? fzzzzzzzzzzzq_ = context.Operators.In<CqlDateTime>(fzzzzzzzzzzze_, fzzzzzzzzzzzp_, "day");
            CqlInterval<CqlDateTime> fzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ezzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.toInterval(context, fzzzzzzzzzzzs_ as object);
            CqlDateTime fzzzzzzzzzzzu_ = context.Operators.End(fzzzzzzzzzzzt_);
            bool? fzzzzzzzzzzzv_ = context.Operators.Not((bool?)(fzzzzzzzzzzzu_ is null));
            bool? fzzzzzzzzzzzw_ = context.Operators.And(fzzzzzzzzzzzq_, fzzzzzzzzzzzv_);
            bool? fzzzzzzzzzzzx_ = context.Operators.And(fzzzzzzzzzzzd_, fzzzzzzzzzzzw_);
            CqlDateTime fzzzzzzzzzzzy_ = context.Operators.ConvertDateToDateTime(tuple_eoahgtwwdfqijhcjzqnvidvuo?.FollowupKCCQ12Date);
            CqlDate fzzzzzzzzzzzz_ = context.Operators.DateFrom(fzzzzzzzzzzzy_);
            CqlDate gzzzzzzzzzzzb_ = context.Operators.DateFrom(fzzzzzzzzzzze_);
            CqlQuantity gzzzzzzzzzzzc_ = context.Operators.Quantity(30m, "days");
            CqlDate gzzzzzzzzzzzd_ = context.Operators.Add(gzzzzzzzzzzzb_, gzzzzzzzzzzzc_);
            CqlDate gzzzzzzzzzzzf_ = context.Operators.DateFrom(fzzzzzzzzzzze_);
            CqlDate gzzzzzzzzzzzh_ = context.Operators.Add(gzzzzzzzzzzzf_, fzzzzzzzzzzzb_);
            CqlInterval<CqlDate> gzzzzzzzzzzzi_ = context.Operators.Interval(gzzzzzzzzzzzd_, gzzzzzzzzzzzh_, true, true);
            bool? gzzzzzzzzzzzj_ = context.Operators.In<CqlDate>(fzzzzzzzzzzzz_, gzzzzzzzzzzzi_, "day");
            bool? gzzzzzzzzzzzk_ = context.Operators.And(fzzzzzzzzzzzx_, gzzzzzzzzzzzj_);

            return gzzzzzzzzzzzk_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQ12Date, CqlDate FollowupKCCQ12Date)?> ezzzzzzzzzzzp_ = context.Operators.Where<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQ12Date, CqlDate FollowupKCCQ12Date)?>(ezzzzzzzzzzzn_, ezzzzzzzzzzzo_);
        Encounter ezzzzzzzzzzzq_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQ12Date, CqlDate FollowupKCCQ12Date)? tuple_eoahgtwwdfqijhcjzqnvidvuo) =>
            tuple_eoahgtwwdfqijhcjzqnvidvuo?.ValidEncounters;
        IEnumerable<Encounter> ezzzzzzzzzzzr_ = context.Operators.Select<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQ12Date, CqlDate FollowupKCCQ12Date)?, Encounter>(ezzzzzzzzzzzp_, ezzzzzzzzzzzq_);
        IEnumerable<Encounter> ezzzzzzzzzzzs_ = context.Operators.Distinct<Encounter>(ezzzzzzzzzzzr_);
        bool? ezzzzzzzzzzzt_ = context.Operators.Exists<Encounter>(ezzzzzzzzzzzs_);

        return ezzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Date KCCQ Domain Assessment Completed")]
    public IEnumerable<CqlDate> Date_KCCQ_Domain_Assessment_Completed(CqlContext context)
    {
        CqlCode gzzzzzzzzzzzl_ = this.Quality_of_life_score__KCCQ_(context);
        IEnumerable<CqlCode> gzzzzzzzzzzzm_ = context.Operators.ToList<CqlCode>(gzzzzzzzzzzzl_);
        IEnumerable<Observation> gzzzzzzzzzzzn_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, gzzzzzzzzzzzm_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> gzzzzzzzzzzzo_ = Status_1_8_000.Instance.isAssessmentPerformed(context, gzzzzzzzzzzzn_);
        CqlCode gzzzzzzzzzzzp_ = this.Symptom_stability_score__KCCQ_(context);
        IEnumerable<CqlCode> gzzzzzzzzzzzq_ = context.Operators.ToList<CqlCode>(gzzzzzzzzzzzp_);
        IEnumerable<Observation> gzzzzzzzzzzzr_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, gzzzzzzzzzzzq_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> gzzzzzzzzzzzs_ = Status_1_8_000.Instance.isAssessmentPerformed(context, gzzzzzzzzzzzr_);
        CqlCode gzzzzzzzzzzzt_ = this.Self_efficacy_score__KCCQ_(context);
        IEnumerable<CqlCode> gzzzzzzzzzzzu_ = context.Operators.ToList<CqlCode>(gzzzzzzzzzzzt_);
        IEnumerable<Observation> gzzzzzzzzzzzv_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, gzzzzzzzzzzzu_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> gzzzzzzzzzzzw_ = Status_1_8_000.Instance.isAssessmentPerformed(context, gzzzzzzzzzzzv_);
        CqlCode gzzzzzzzzzzzx_ = this.Total_symptom_score__KCCQ_(context);
        IEnumerable<CqlCode> gzzzzzzzzzzzy_ = context.Operators.ToList<CqlCode>(gzzzzzzzzzzzx_);
        IEnumerable<Observation> gzzzzzzzzzzzz_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, gzzzzzzzzzzzy_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> hzzzzzzzzzzza_ = Status_1_8_000.Instance.isAssessmentPerformed(context, gzzzzzzzzzzzz_);
        CqlCode hzzzzzzzzzzzb_ = this.Physical_limitation_score__KCCQ_(context);
        IEnumerable<CqlCode> hzzzzzzzzzzzc_ = context.Operators.ToList<CqlCode>(hzzzzzzzzzzzb_);
        IEnumerable<Observation> hzzzzzzzzzzzd_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, hzzzzzzzzzzzc_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> hzzzzzzzzzzze_ = Status_1_8_000.Instance.isAssessmentPerformed(context, hzzzzzzzzzzzd_);
        CqlCode hzzzzzzzzzzzf_ = this.Social_limitation_score__KCCQ_(context);
        IEnumerable<CqlCode> hzzzzzzzzzzzg_ = context.Operators.ToList<CqlCode>(hzzzzzzzzzzzf_);
        IEnumerable<Observation> hzzzzzzzzzzzh_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, hzzzzzzzzzzzg_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> hzzzzzzzzzzzi_ = Status_1_8_000.Instance.isAssessmentPerformed(context, hzzzzzzzzzzzh_);
        IEnumerable<ValueTuple<Observation, Observation, Observation, Observation, Observation, Observation>> hzzzzzzzzzzzj_ = context.Operators.CrossJoin<Observation, Observation, Observation, Observation, Observation, Observation>(gzzzzzzzzzzzo_, gzzzzzzzzzzzs_, gzzzzzzzzzzzw_, hzzzzzzzzzzza_, hzzzzzzzzzzze_, hzzzzzzzzzzzi_);
        (CqlTupleMetadata, Observation KCCQLifeQuality, Observation KCCQSymptomStability, Observation KCCQSelfEfficacy, Observation KCCQSymptoms, Observation KCCQPhysicalLimits, Observation KCCQSocialLimits)? hzzzzzzzzzzzk_(ValueTuple<Observation, Observation, Observation, Observation, Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation KCCQLifeQuality, Observation KCCQSymptomStability, Observation KCCQSelfEfficacy, Observation KCCQSymptoms, Observation KCCQPhysicalLimits, Observation KCCQSocialLimits)? hzzzzzzzzzzzr_ = (CqlTupleMetadata_BbPMcXSJeOeGdRcaZWGYPhGBL, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3, _valueTuple.Item4, _valueTuple.Item5, _valueTuple.Item6);

            return hzzzzzzzzzzzr_;
        };
        IEnumerable<(CqlTupleMetadata, Observation KCCQLifeQuality, Observation KCCQSymptomStability, Observation KCCQSelfEfficacy, Observation KCCQSymptoms, Observation KCCQPhysicalLimits, Observation KCCQSocialLimits)?> hzzzzzzzzzzzl_ = context.Operators.Select<ValueTuple<Observation, Observation, Observation, Observation, Observation, Observation>, (CqlTupleMetadata, Observation KCCQLifeQuality, Observation KCCQSymptomStability, Observation KCCQSelfEfficacy, Observation KCCQSymptoms, Observation KCCQPhysicalLimits, Observation KCCQSocialLimits)?>(hzzzzzzzzzzzj_, hzzzzzzzzzzzk_);
        bool? hzzzzzzzzzzzm_((CqlTupleMetadata, Observation KCCQLifeQuality, Observation KCCQSymptomStability, Observation KCCQSelfEfficacy, Observation KCCQSymptoms, Observation KCCQPhysicalLimits, Observation KCCQSocialLimits)? tuple_etfcawdpmcqfbnayqdmdqqsdn)
        {
            DataType hzzzzzzzzzzzs_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQLifeQuality?.Effective;
            object hzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, hzzzzzzzzzzzt_);
            CqlDateTime hzzzzzzzzzzzv_ = context.Operators.Start(hzzzzzzzzzzzu_);
            CqlDate hzzzzzzzzzzzw_ = context.Operators.DateFrom(hzzzzzzzzzzzv_);
            DataType hzzzzzzzzzzzx_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQSymptomStability?.Effective;
            object hzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, hzzzzzzzzzzzy_);
            CqlDateTime izzzzzzzzzzza_ = context.Operators.Start(hzzzzzzzzzzzz_);
            CqlDate izzzzzzzzzzzb_ = context.Operators.DateFrom(izzzzzzzzzzza_);
            bool? izzzzzzzzzzzc_ = context.Operators.SameAs(hzzzzzzzzzzzw_, izzzzzzzzzzzb_, "day");
            DataType izzzzzzzzzzzd_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQSymptomStability?.Value;
            object izzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzd_);
            bool? izzzzzzzzzzzf_ = context.Operators.Not((bool?)(izzzzzzzzzzze_ is null));
            bool? izzzzzzzzzzzg_ = context.Operators.And(izzzzzzzzzzzc_, izzzzzzzzzzzf_);
            object izzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.toInterval(context, izzzzzzzzzzzi_);
            CqlDateTime izzzzzzzzzzzk_ = context.Operators.Start(izzzzzzzzzzzj_);
            CqlDate izzzzzzzzzzzl_ = context.Operators.DateFrom(izzzzzzzzzzzk_);
            DataType izzzzzzzzzzzm_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQSelfEfficacy?.Effective;
            object izzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.toInterval(context, izzzzzzzzzzzn_);
            CqlDateTime izzzzzzzzzzzp_ = context.Operators.Start(izzzzzzzzzzzo_);
            CqlDate izzzzzzzzzzzq_ = context.Operators.DateFrom(izzzzzzzzzzzp_);
            bool? izzzzzzzzzzzr_ = context.Operators.SameAs(izzzzzzzzzzzl_, izzzzzzzzzzzq_, "day");
            bool? izzzzzzzzzzzs_ = context.Operators.And(izzzzzzzzzzzg_, izzzzzzzzzzzr_);
            DataType izzzzzzzzzzzt_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQSelfEfficacy?.Value;
            object izzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzt_);
            bool? izzzzzzzzzzzv_ = context.Operators.Not((bool?)(izzzzzzzzzzzu_ is null));
            bool? izzzzzzzzzzzw_ = context.Operators.And(izzzzzzzzzzzs_, izzzzzzzzzzzv_);
            object izzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, izzzzzzzzzzzy_);
            CqlDateTime jzzzzzzzzzzza_ = context.Operators.Start(izzzzzzzzzzzz_);
            CqlDate jzzzzzzzzzzzb_ = context.Operators.DateFrom(jzzzzzzzzzzza_);
            DataType jzzzzzzzzzzzc_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQSymptoms?.Effective;
            object jzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.toInterval(context, jzzzzzzzzzzzd_);
            CqlDateTime jzzzzzzzzzzzf_ = context.Operators.Start(jzzzzzzzzzzze_);
            CqlDate jzzzzzzzzzzzg_ = context.Operators.DateFrom(jzzzzzzzzzzzf_);
            bool? jzzzzzzzzzzzh_ = context.Operators.SameAs(jzzzzzzzzzzzb_, jzzzzzzzzzzzg_, "day");
            bool? jzzzzzzzzzzzi_ = context.Operators.And(izzzzzzzzzzzw_, jzzzzzzzzzzzh_);
            DataType jzzzzzzzzzzzj_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQSymptoms?.Value;
            object jzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzj_);
            bool? jzzzzzzzzzzzl_ = context.Operators.Not((bool?)(jzzzzzzzzzzzk_ is null));
            bool? jzzzzzzzzzzzm_ = context.Operators.And(jzzzzzzzzzzzi_, jzzzzzzzzzzzl_);
            object jzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, jzzzzzzzzzzzo_);
            CqlDateTime jzzzzzzzzzzzq_ = context.Operators.Start(jzzzzzzzzzzzp_);
            CqlDate jzzzzzzzzzzzr_ = context.Operators.DateFrom(jzzzzzzzzzzzq_);
            DataType jzzzzzzzzzzzs_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQPhysicalLimits?.Effective;
            object jzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzu_ = QICoreCommon_2_1_000.Instance.toInterval(context, jzzzzzzzzzzzt_);
            CqlDateTime jzzzzzzzzzzzv_ = context.Operators.Start(jzzzzzzzzzzzu_);
            CqlDate jzzzzzzzzzzzw_ = context.Operators.DateFrom(jzzzzzzzzzzzv_);
            bool? jzzzzzzzzzzzx_ = context.Operators.SameAs(jzzzzzzzzzzzr_, jzzzzzzzzzzzw_, "day");
            bool? jzzzzzzzzzzzy_ = context.Operators.And(jzzzzzzzzzzzm_, jzzzzzzzzzzzx_);
            DataType jzzzzzzzzzzzz_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQPhysicalLimits?.Value;
            object kzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, jzzzzzzzzzzzz_);
            bool? kzzzzzzzzzzzb_ = context.Operators.Not((bool?)(kzzzzzzzzzzza_ is null));
            bool? kzzzzzzzzzzzc_ = context.Operators.And(jzzzzzzzzzzzy_, kzzzzzzzzzzzb_);
            object kzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzs_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzze_);
            CqlDateTime kzzzzzzzzzzzg_ = context.Operators.Start(kzzzzzzzzzzzf_);
            CqlDate kzzzzzzzzzzzh_ = context.Operators.DateFrom(kzzzzzzzzzzzg_);
            DataType kzzzzzzzzzzzi_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQSocialLimits?.Effective;
            object kzzzzzzzzzzzj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzi_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzj_);
            CqlDateTime kzzzzzzzzzzzl_ = context.Operators.Start(kzzzzzzzzzzzk_);
            CqlDate kzzzzzzzzzzzm_ = context.Operators.DateFrom(kzzzzzzzzzzzl_);
            bool? kzzzzzzzzzzzn_ = context.Operators.SameAs(kzzzzzzzzzzzh_, kzzzzzzzzzzzm_, "day");
            bool? kzzzzzzzzzzzo_ = context.Operators.And(kzzzzzzzzzzzc_, kzzzzzzzzzzzn_);
            DataType kzzzzzzzzzzzp_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQSocialLimits?.Value;
            object kzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzp_);
            bool? kzzzzzzzzzzzr_ = context.Operators.Not((bool?)(kzzzzzzzzzzzq_ is null));
            bool? kzzzzzzzzzzzs_ = context.Operators.And(kzzzzzzzzzzzo_, kzzzzzzzzzzzr_);
            DataType kzzzzzzzzzzzt_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQLifeQuality?.Value;
            object kzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzt_);
            bool? kzzzzzzzzzzzv_ = context.Operators.Not((bool?)(kzzzzzzzzzzzu_ is null));
            bool? kzzzzzzzzzzzw_ = context.Operators.And(kzzzzzzzzzzzs_, kzzzzzzzzzzzv_);

            return kzzzzzzzzzzzw_;
        };
        IEnumerable<(CqlTupleMetadata, Observation KCCQLifeQuality, Observation KCCQSymptomStability, Observation KCCQSelfEfficacy, Observation KCCQSymptoms, Observation KCCQPhysicalLimits, Observation KCCQSocialLimits)?> hzzzzzzzzzzzn_ = context.Operators.Where<(CqlTupleMetadata, Observation KCCQLifeQuality, Observation KCCQSymptomStability, Observation KCCQSelfEfficacy, Observation KCCQSymptoms, Observation KCCQPhysicalLimits, Observation KCCQSocialLimits)?>(hzzzzzzzzzzzl_, hzzzzzzzzzzzm_);
        CqlDate hzzzzzzzzzzzo_((CqlTupleMetadata, Observation KCCQLifeQuality, Observation KCCQSymptomStability, Observation KCCQSelfEfficacy, Observation KCCQSymptoms, Observation KCCQPhysicalLimits, Observation KCCQSocialLimits)? tuple_etfcawdpmcqfbnayqdmdqqsdn)
        {
            DataType kzzzzzzzzzzzx_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQLifeQuality?.Effective;
            object kzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, kzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, kzzzzzzzzzzzy_);
            CqlDateTime lzzzzzzzzzzza_ = context.Operators.Start(kzzzzzzzzzzzz_);
            CqlDate lzzzzzzzzzzzb_ = context.Operators.DateFrom(lzzzzzzzzzzza_);

            return lzzzzzzzzzzzb_;
        };
        IEnumerable<CqlDate> hzzzzzzzzzzzp_ = context.Operators.Select<(CqlTupleMetadata, Observation KCCQLifeQuality, Observation KCCQSymptomStability, Observation KCCQSelfEfficacy, Observation KCCQSymptoms, Observation KCCQPhysicalLimits, Observation KCCQSocialLimits)?, CqlDate>(hzzzzzzzzzzzn_, hzzzzzzzzzzzo_);
        IEnumerable<CqlDate> hzzzzzzzzzzzq_ = context.Operators.Distinct<CqlDate>(hzzzzzzzzzzzp_);

        return hzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Has Encounter with Initial and Follow Up KCCQ Domain Score Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_KCCQ_Domain_Score_Assessments(CqlContext context)
    {
        IEnumerable<Encounter> lzzzzzzzzzzzc_ = this.Qualifying_Encounters(context);
        IEnumerable<CqlDate> lzzzzzzzzzzzd_ = this.Date_KCCQ_Domain_Assessment_Completed(context);
        IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> lzzzzzzzzzzzf_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(lzzzzzzzzzzzc_, lzzzzzzzzzzzd_, lzzzzzzzzzzzd_);
        (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQAssessmentDate, CqlDate FollowupKCCQAssessmentDate)? lzzzzzzzzzzzg_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQAssessmentDate, CqlDate FollowupKCCQAssessmentDate)? lzzzzzzzzzzzo_ = (CqlTupleMetadata_HEFWLcHhCNCOQegEOfjWTXiGN, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return lzzzzzzzzzzzo_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQAssessmentDate, CqlDate FollowupKCCQAssessmentDate)?> lzzzzzzzzzzzh_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQAssessmentDate, CqlDate FollowupKCCQAssessmentDate)?>(lzzzzzzzzzzzf_, lzzzzzzzzzzzg_);
        bool? lzzzzzzzzzzzi_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQAssessmentDate, CqlDate FollowupKCCQAssessmentDate)? tuple_hrluhbcfcsvnvrrnjajahdcea)
        {
            Period lzzzzzzzzzzzp_ = tuple_hrluhbcfcsvnvrrnjajahdcea?.ValidEncounters?.Period;
            CqlInterval<CqlDateTime> lzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, lzzzzzzzzzzzq_ as object);
            CqlDateTime lzzzzzzzzzzzs_ = context.Operators.End(lzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzt_ = this.Measurement_Period(context);
            CqlDateTime lzzzzzzzzzzzu_ = context.Operators.End(lzzzzzzzzzzzt_);
            CqlQuantity lzzzzzzzzzzzv_ = context.Operators.Quantity(180m, "days");
            CqlDateTime lzzzzzzzzzzzw_ = context.Operators.Subtract(lzzzzzzzzzzzu_, lzzzzzzzzzzzv_);
            bool? lzzzzzzzzzzzx_ = context.Operators.SameOrBefore(lzzzzzzzzzzzs_, lzzzzzzzzzzzw_, "day");
            CqlDateTime lzzzzzzzzzzzy_ = context.Operators.ConvertDateToDateTime(tuple_hrluhbcfcsvnvrrnjajahdcea?.InitialKCCQAssessmentDate);
            CqlInterval<CqlDateTime> mzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, mzzzzzzzzzzza_ as object);
            CqlDateTime mzzzzzzzzzzzc_ = context.Operators.End(mzzzzzzzzzzzb_);
            CqlQuantity mzzzzzzzzzzzd_ = context.Operators.Quantity(14m, "days");
            CqlDateTime mzzzzzzzzzzze_ = context.Operators.Subtract(mzzzzzzzzzzzc_, mzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.toInterval(context, mzzzzzzzzzzzg_ as object);
            CqlDateTime mzzzzzzzzzzzi_ = context.Operators.End(mzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzj_ = context.Operators.Interval(mzzzzzzzzzzze_, mzzzzzzzzzzzi_, true, true);
            bool? mzzzzzzzzzzzk_ = context.Operators.In<CqlDateTime>(lzzzzzzzzzzzy_, mzzzzzzzzzzzj_, "day");
            CqlInterval<CqlDateTime> mzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.toInterval(context, mzzzzzzzzzzzm_ as object);
            CqlDateTime mzzzzzzzzzzzo_ = context.Operators.End(mzzzzzzzzzzzn_);
            bool? mzzzzzzzzzzzp_ = context.Operators.Not((bool?)(mzzzzzzzzzzzo_ is null));
            bool? mzzzzzzzzzzzq_ = context.Operators.And(mzzzzzzzzzzzk_, mzzzzzzzzzzzp_);
            bool? mzzzzzzzzzzzr_ = context.Operators.And(lzzzzzzzzzzzx_, mzzzzzzzzzzzq_);
            CqlDateTime mzzzzzzzzzzzs_ = context.Operators.ConvertDateToDateTime(tuple_hrluhbcfcsvnvrrnjajahdcea?.FollowupKCCQAssessmentDate);
            CqlDate mzzzzzzzzzzzt_ = context.Operators.DateFrom(mzzzzzzzzzzzs_);
            CqlDate mzzzzzzzzzzzv_ = context.Operators.DateFrom(lzzzzzzzzzzzy_);
            CqlQuantity mzzzzzzzzzzzw_ = context.Operators.Quantity(30m, "days");
            CqlDate mzzzzzzzzzzzx_ = context.Operators.Add(mzzzzzzzzzzzv_, mzzzzzzzzzzzw_);
            CqlDate mzzzzzzzzzzzz_ = context.Operators.DateFrom(lzzzzzzzzzzzy_);
            CqlDate nzzzzzzzzzzzb_ = context.Operators.Add(mzzzzzzzzzzzz_, lzzzzzzzzzzzv_);
            CqlInterval<CqlDate> nzzzzzzzzzzzc_ = context.Operators.Interval(mzzzzzzzzzzzx_, nzzzzzzzzzzzb_, true, true);
            bool? nzzzzzzzzzzzd_ = context.Operators.In<CqlDate>(mzzzzzzzzzzzt_, nzzzzzzzzzzzc_, "day");
            bool? nzzzzzzzzzzze_ = context.Operators.And(mzzzzzzzzzzzr_, nzzzzzzzzzzzd_);

            return nzzzzzzzzzzze_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQAssessmentDate, CqlDate FollowupKCCQAssessmentDate)?> lzzzzzzzzzzzj_ = context.Operators.Where<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQAssessmentDate, CqlDate FollowupKCCQAssessmentDate)?>(lzzzzzzzzzzzh_, lzzzzzzzzzzzi_);
        Encounter lzzzzzzzzzzzk_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQAssessmentDate, CqlDate FollowupKCCQAssessmentDate)? tuple_hrluhbcfcsvnvrrnjajahdcea) =>
            tuple_hrluhbcfcsvnvrrnjajahdcea?.ValidEncounters;
        IEnumerable<Encounter> lzzzzzzzzzzzl_ = context.Operators.Select<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQAssessmentDate, CqlDate FollowupKCCQAssessmentDate)?, Encounter>(lzzzzzzzzzzzj_, lzzzzzzzzzzzk_);
        IEnumerable<Encounter> lzzzzzzzzzzzm_ = context.Operators.Distinct<Encounter>(lzzzzzzzzzzzl_);
        bool? lzzzzzzzzzzzn_ = context.Operators.Exists<Encounter>(lzzzzzzzzzzzm_);

        return lzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Date KCCQ Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_KCCQ_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode nzzzzzzzzzzzf_ = this.Overall_summary_score__KCCQ_(context);
        IEnumerable<CqlCode> nzzzzzzzzzzzg_ = context.Operators.ToList<CqlCode>(nzzzzzzzzzzzf_);
        IEnumerable<Observation> nzzzzzzzzzzzh_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, nzzzzzzzzzzzg_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> nzzzzzzzzzzzi_ = Status_1_8_000.Instance.isAssessmentPerformed(context, nzzzzzzzzzzzh_);
        bool? nzzzzzzzzzzzj_(Observation KCCQSummaryScore)
        {
            DataType nzzzzzzzzzzzo_ = KCCQSummaryScore?.Value;
            object nzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzo_);
            bool? nzzzzzzzzzzzq_ = context.Operators.Not((bool?)(nzzzzzzzzzzzp_ is null));

            return nzzzzzzzzzzzq_;
        };
        IEnumerable<Observation> nzzzzzzzzzzzk_ = context.Operators.Where<Observation>(nzzzzzzzzzzzi_, nzzzzzzzzzzzj_);
        CqlDate nzzzzzzzzzzzl_(Observation KCCQSummaryScore)
        {
            DataType nzzzzzzzzzzzr_ = KCCQSummaryScore?.Effective;
            object nzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzzzs_);
            CqlDateTime nzzzzzzzzzzzu_ = context.Operators.Start(nzzzzzzzzzzzt_);
            CqlDate nzzzzzzzzzzzv_ = context.Operators.DateFrom(nzzzzzzzzzzzu_);

            return nzzzzzzzzzzzv_;
        };
        IEnumerable<CqlDate> nzzzzzzzzzzzm_ = context.Operators.Select<Observation, CqlDate>(nzzzzzzzzzzzk_, nzzzzzzzzzzzl_);
        IEnumerable<CqlDate> nzzzzzzzzzzzn_ = context.Operators.Distinct<CqlDate>(nzzzzzzzzzzzm_);

        return nzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Has Encounter with Initial and Follow Up KCCQ Total Score Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_KCCQ_Total_Score_Assessments(CqlContext context)
    {
        IEnumerable<Encounter> nzzzzzzzzzzzw_ = this.Qualifying_Encounters(context);
        IEnumerable<CqlDate> nzzzzzzzzzzzx_ = this.Date_KCCQ_Total_Assessment_Completed(context);
        IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> nzzzzzzzzzzzz_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(nzzzzzzzzzzzw_, nzzzzzzzzzzzx_, nzzzzzzzzzzzx_);
        (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQTotalScore, CqlDate FollowupKCCQTotalScore)? ozzzzzzzzzzza_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQTotalScore, CqlDate FollowupKCCQTotalScore)? ozzzzzzzzzzzi_ = (CqlTupleMetadata_DggZKjEbQUfLADMDMBeASLDR, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return ozzzzzzzzzzzi_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQTotalScore, CqlDate FollowupKCCQTotalScore)?> ozzzzzzzzzzzb_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQTotalScore, CqlDate FollowupKCCQTotalScore)?>(nzzzzzzzzzzzz_, ozzzzzzzzzzza_);
        bool? ozzzzzzzzzzzc_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQTotalScore, CqlDate FollowupKCCQTotalScore)? tuple_dgrojeekdvizsvyisepdjhjgj)
        {
            Period ozzzzzzzzzzzj_ = tuple_dgrojeekdvizsvyisepdjhjgj?.ValidEncounters?.Period;
            CqlInterval<CqlDateTime> ozzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, ozzzzzzzzzzzk_ as object);
            CqlDateTime ozzzzzzzzzzzm_ = context.Operators.End(ozzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzn_ = this.Measurement_Period(context);
            CqlDateTime ozzzzzzzzzzzo_ = context.Operators.End(ozzzzzzzzzzzn_);
            CqlQuantity ozzzzzzzzzzzp_ = context.Operators.Quantity(180m, "days");
            CqlDateTime ozzzzzzzzzzzq_ = context.Operators.Subtract(ozzzzzzzzzzzo_, ozzzzzzzzzzzp_);
            bool? ozzzzzzzzzzzr_ = context.Operators.SameOrBefore(ozzzzzzzzzzzm_, ozzzzzzzzzzzq_, "day");
            CqlDateTime ozzzzzzzzzzzs_ = context.Operators.ConvertDateToDateTime(tuple_dgrojeekdvizsvyisepdjhjgj?.InitialKCCQTotalScore);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, ozzzzzzzzzzzu_ as object);
            CqlDateTime ozzzzzzzzzzzw_ = context.Operators.End(ozzzzzzzzzzzv_);
            CqlQuantity ozzzzzzzzzzzx_ = context.Operators.Quantity(14m, "days");
            CqlDateTime ozzzzzzzzzzzy_ = context.Operators.Subtract(ozzzzzzzzzzzw_, ozzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, pzzzzzzzzzzza_ as object);
            CqlDateTime pzzzzzzzzzzzc_ = context.Operators.End(pzzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzd_ = context.Operators.Interval(ozzzzzzzzzzzy_, pzzzzzzzzzzzc_, true, true);
            bool? pzzzzzzzzzzze_ = context.Operators.In<CqlDateTime>(ozzzzzzzzzzzs_, pzzzzzzzzzzzd_, "day");
            CqlInterval<CqlDateTime> pzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ozzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.toInterval(context, pzzzzzzzzzzzg_ as object);
            CqlDateTime pzzzzzzzzzzzi_ = context.Operators.End(pzzzzzzzzzzzh_);
            bool? pzzzzzzzzzzzj_ = context.Operators.Not((bool?)(pzzzzzzzzzzzi_ is null));
            bool? pzzzzzzzzzzzk_ = context.Operators.And(pzzzzzzzzzzze_, pzzzzzzzzzzzj_);
            bool? pzzzzzzzzzzzl_ = context.Operators.And(ozzzzzzzzzzzr_, pzzzzzzzzzzzk_);
            CqlDateTime pzzzzzzzzzzzm_ = context.Operators.ConvertDateToDateTime(tuple_dgrojeekdvizsvyisepdjhjgj?.FollowupKCCQTotalScore);
            CqlDate pzzzzzzzzzzzn_ = context.Operators.DateFrom(pzzzzzzzzzzzm_);
            CqlDate pzzzzzzzzzzzp_ = context.Operators.DateFrom(ozzzzzzzzzzzs_);
            CqlQuantity pzzzzzzzzzzzq_ = context.Operators.Quantity(30m, "days");
            CqlDate pzzzzzzzzzzzr_ = context.Operators.Add(pzzzzzzzzzzzp_, pzzzzzzzzzzzq_);
            CqlDate pzzzzzzzzzzzt_ = context.Operators.DateFrom(ozzzzzzzzzzzs_);
            CqlDate pzzzzzzzzzzzv_ = context.Operators.Add(pzzzzzzzzzzzt_, ozzzzzzzzzzzp_);
            CqlInterval<CqlDate> pzzzzzzzzzzzw_ = context.Operators.Interval(pzzzzzzzzzzzr_, pzzzzzzzzzzzv_, true, true);
            bool? pzzzzzzzzzzzx_ = context.Operators.In<CqlDate>(pzzzzzzzzzzzn_, pzzzzzzzzzzzw_, "day");
            bool? pzzzzzzzzzzzy_ = context.Operators.And(pzzzzzzzzzzzl_, pzzzzzzzzzzzx_);

            return pzzzzzzzzzzzy_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQTotalScore, CqlDate FollowupKCCQTotalScore)?> ozzzzzzzzzzzd_ = context.Operators.Where<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQTotalScore, CqlDate FollowupKCCQTotalScore)?>(ozzzzzzzzzzzb_, ozzzzzzzzzzzc_);
        Encounter ozzzzzzzzzzze_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQTotalScore, CqlDate FollowupKCCQTotalScore)? tuple_dgrojeekdvizsvyisepdjhjgj) =>
            tuple_dgrojeekdvizsvyisepdjhjgj?.ValidEncounters;
        IEnumerable<Encounter> ozzzzzzzzzzzf_ = context.Operators.Select<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQTotalScore, CqlDate FollowupKCCQTotalScore)?, Encounter>(ozzzzzzzzzzzd_, ozzzzzzzzzzze_);
        IEnumerable<Encounter> ozzzzzzzzzzzg_ = context.Operators.Distinct<Encounter>(ozzzzzzzzzzzf_);
        bool? ozzzzzzzzzzzh_ = context.Operators.Exists<Encounter>(ozzzzzzzzzzzg_);

        return ozzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? pzzzzzzzzzzzz_ = this.Has_Encounter_with_Initial_and_Follow_Up_PROMIS10_Assessments(context);
        bool? qzzzzzzzzzzza_ = this.Has_Encounter_with_Initial_and_Follow_Up_PROMIS29_Assessments(context);
        bool? qzzzzzzzzzzzb_ = context.Operators.Or(pzzzzzzzzzzzz_, qzzzzzzzzzzza_);
        bool? qzzzzzzzzzzzc_ = this.Has_Encounter_with_Initial_and_Follow_Up_VR12_Oblique_Assessments(context);
        bool? qzzzzzzzzzzzd_ = context.Operators.Or(qzzzzzzzzzzzb_, qzzzzzzzzzzzc_);
        bool? qzzzzzzzzzzze_ = this.Has_Encounter_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments(context);
        bool? qzzzzzzzzzzzf_ = context.Operators.Or(qzzzzzzzzzzzd_, qzzzzzzzzzzze_);
        bool? qzzzzzzzzzzzg_ = this.Has_Encounter_with_Initial_and_Follow_Up_VR36_Oblique_Assessments(context);
        bool? qzzzzzzzzzzzh_ = context.Operators.Or(qzzzzzzzzzzzf_, qzzzzzzzzzzzg_);
        bool? qzzzzzzzzzzzi_ = this.Has_Encounter_with_Initial_and_Follow_Up_VR36_Orthogonal_Assessments(context);
        bool? qzzzzzzzzzzzj_ = context.Operators.Or(qzzzzzzzzzzzh_, qzzzzzzzzzzzi_);
        bool? qzzzzzzzzzzzk_ = this.Has_Encounter_with_Initial_and_Follow_Up_MLHFQ_Assessments(context);
        bool? qzzzzzzzzzzzl_ = context.Operators.Or(qzzzzzzzzzzzj_, qzzzzzzzzzzzk_);
        bool? qzzzzzzzzzzzm_ = this.Has_Encounter_with_Initial_and_Follow_Up_KCCQ12_Assessments(context);
        bool? qzzzzzzzzzzzn_ = context.Operators.Or(qzzzzzzzzzzzl_, qzzzzzzzzzzzm_);
        bool? qzzzzzzzzzzzo_ = this.Has_Encounter_with_Initial_and_Follow_Up_KCCQ_Domain_Score_Assessments(context);
        bool? qzzzzzzzzzzzp_ = context.Operators.Or(qzzzzzzzzzzzn_, qzzzzzzzzzzzo_);
        bool? qzzzzzzzzzzzq_ = this.Has_Encounter_with_Initial_and_Follow_Up_KCCQ_Total_Score_Assessments(context);
        bool? qzzzzzzzzzzzr_ = context.Operators.Or(qzzzzzzzzzzzp_, qzzzzzzzzzzzq_);

        return qzzzzzzzzzzzr_;
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
