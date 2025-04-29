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
        CqlDateTime hzzzzzzzzzzzk_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime hzzzzzzzzzzzl_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> hzzzzzzzzzzzm_ = context.Operators.Interval(hzzzzzzzzzzzk_, hzzzzzzzzzzzl_, true, true);
        object hzzzzzzzzzzzn_ = context.ResolveParameter("FunctionalStatusAssessmentsforHeartFailureFHIR-0.1.000", "Measurement Period", hzzzzzzzzzzzm_);

        return (CqlInterval<CqlDateTime>)hzzzzzzzzzzzn_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> hzzzzzzzzzzzo_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient hzzzzzzzzzzzp_ = context.Operators.SingletonFrom<Patient>(hzzzzzzzzzzzo_);

        return hzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? hzzzzzzzzzzzq_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return hzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> hzzzzzzzzzzzr_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return hzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? hzzzzzzzzzzzs_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return hzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode hzzzzzzzzzzzt_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return hzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        CqlValueSet hzzzzzzzzzzzu_ = this.Office_Visit(context);
        IEnumerable<Encounter> hzzzzzzzzzzzv_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, hzzzzzzzzzzzu_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet hzzzzzzzzzzzw_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> hzzzzzzzzzzzx_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, hzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> hzzzzzzzzzzzy_ = context.Operators.Union<Encounter>(hzzzzzzzzzzzv_, hzzzzzzzzzzzx_);
        CqlValueSet hzzzzzzzzzzzz_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> izzzzzzzzzzza_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, hzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> izzzzzzzzzzzb_ = context.Operators.Union<Encounter>(hzzzzzzzzzzzy_, izzzzzzzzzzza_);
        IEnumerable<Encounter> izzzzzzzzzzzc_ = Status_1_8_000.Instance.isEncounterPerformed(context, izzzzzzzzzzzb_);
        bool? izzzzzzzzzzzd_(Encounter ValidEncounter)
        {
            CqlInterval<CqlDateTime> izzzzzzzzzzzf_ = this.Measurement_Period(context);
            Period izzzzzzzzzzzg_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> izzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.toInterval(context, izzzzzzzzzzzh_ as object);
            bool? izzzzzzzzzzzj_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(izzzzzzzzzzzf_, izzzzzzzzzzzi_, "day");

            return izzzzzzzzzzzj_;
        };
        IEnumerable<Encounter> izzzzzzzzzzze_ = context.Operators.Where<Encounter>(izzzzzzzzzzzc_, izzzzzzzzzzzd_);

        return izzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Two Outpatient Encounters during Measurement Period")]
    public IEnumerable<Encounter> Two_Outpatient_Encounters_during_Measurement_Period(CqlContext context)
    {
        IEnumerable<Encounter> izzzzzzzzzzzk_ = this.Qualifying_Encounters(context);
        IEnumerable<ValueTuple<Encounter, Encounter>> izzzzzzzzzzzm_ = context.Operators.CrossJoin<Encounter, Encounter>(izzzzzzzzzzzk_, izzzzzzzzzzzk_);
        (CqlTupleMetadata, Encounter OfficeVisit1, Encounter OfficeVisit2)? izzzzzzzzzzzn_(ValueTuple<Encounter, Encounter> _valueTuple)
        {
            (CqlTupleMetadata, Encounter OfficeVisit1, Encounter OfficeVisit2)? izzzzzzzzzzzu_ = (CqlTupleMetadata_DbNMMZBTISSRTNdiShceSFVih, _valueTuple.Item1, _valueTuple.Item2);

            return izzzzzzzzzzzu_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter OfficeVisit1, Encounter OfficeVisit2)?> izzzzzzzzzzzo_ = context.Operators.Select<ValueTuple<Encounter, Encounter>, (CqlTupleMetadata, Encounter OfficeVisit1, Encounter OfficeVisit2)?>(izzzzzzzzzzzm_, izzzzzzzzzzzn_);
        bool? izzzzzzzzzzzp_((CqlTupleMetadata, Encounter OfficeVisit1, Encounter OfficeVisit2)? tuple_dbnmmzbtissrtndishcesfvih)
        {
            Period izzzzzzzzzzzv_ = tuple_dbnmmzbtissrtndishcesfvih?.OfficeVisit2?.Period;
            CqlInterval<CqlDateTime> izzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.toInterval(context, izzzzzzzzzzzw_ as object);
            CqlDateTime izzzzzzzzzzzy_ = context.Operators.Start(izzzzzzzzzzzx_);
            Period izzzzzzzzzzzz_ = tuple_dbnmmzbtissrtndishcesfvih?.OfficeVisit1?.Period;
            CqlInterval<CqlDateTime> jzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, jzzzzzzzzzzza_ as object);
            CqlDateTime jzzzzzzzzzzzc_ = context.Operators.End(jzzzzzzzzzzzb_);
            CqlQuantity jzzzzzzzzzzzd_ = context.Operators.Quantity(1m, "day");
            CqlDateTime jzzzzzzzzzzze_ = context.Operators.Add(jzzzzzzzzzzzc_, jzzzzzzzzzzzd_);
            bool? jzzzzzzzzzzzf_ = context.Operators.SameOrAfter(izzzzzzzzzzzy_, jzzzzzzzzzzze_, "day");

            return jzzzzzzzzzzzf_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter OfficeVisit1, Encounter OfficeVisit2)?> izzzzzzzzzzzq_ = context.Operators.Where<(CqlTupleMetadata, Encounter OfficeVisit1, Encounter OfficeVisit2)?>(izzzzzzzzzzzo_, izzzzzzzzzzzp_);
        Encounter izzzzzzzzzzzr_((CqlTupleMetadata, Encounter OfficeVisit1, Encounter OfficeVisit2)? tuple_dbnmmzbtissrtndishcesfvih) =>
            tuple_dbnmmzbtissrtndishcesfvih?.OfficeVisit1;
        IEnumerable<Encounter> izzzzzzzzzzzs_ = context.Operators.Select<(CqlTupleMetadata, Encounter OfficeVisit1, Encounter OfficeVisit2)?, Encounter>(izzzzzzzzzzzq_, izzzzzzzzzzzr_);
        IEnumerable<Encounter> izzzzzzzzzzzt_ = context.Operators.Distinct<Encounter>(izzzzzzzzzzzs_);

        return izzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient jzzzzzzzzzzzg_ = this.Patient(context);
        Date jzzzzzzzzzzzh_ = jzzzzzzzzzzzg_?.BirthDateElement;
        string jzzzzzzzzzzzi_ = jzzzzzzzzzzzh_?.Value;
        CqlDate jzzzzzzzzzzzj_ = context.Operators.ConvertStringToDate(jzzzzzzzzzzzi_);
        CqlInterval<CqlDateTime> jzzzzzzzzzzzk_ = this.Measurement_Period(context);
        CqlDateTime jzzzzzzzzzzzl_ = context.Operators.Start(jzzzzzzzzzzzk_);
        CqlDate jzzzzzzzzzzzm_ = context.Operators.DateFrom(jzzzzzzzzzzzl_);
        int? jzzzzzzzzzzzn_ = context.Operators.CalculateAgeAt(jzzzzzzzzzzzj_, jzzzzzzzzzzzm_, "year");
        bool? jzzzzzzzzzzzo_ = context.Operators.GreaterOrEqual(jzzzzzzzzzzzn_, 18);
        CqlValueSet jzzzzzzzzzzzp_ = this.Heart_Failure(context);
        IEnumerable<Condition> jzzzzzzzzzzzq_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, jzzzzzzzzzzzp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? jzzzzzzzzzzzr_(Condition HeartFailure)
        {
            CqlInterval<CqlDateTime> jzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HeartFailure);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzz_ = this.Measurement_Period(context);
            bool? kzzzzzzzzzzza_ = context.Operators.OverlapsBefore(jzzzzzzzzzzzy_, jzzzzzzzzzzzz_, default);

            return kzzzzzzzzzzza_;
        };
        IEnumerable<Condition> jzzzzzzzzzzzs_ = context.Operators.Where<Condition>(jzzzzzzzzzzzq_, jzzzzzzzzzzzr_);
        bool? jzzzzzzzzzzzt_ = context.Operators.Exists<Condition>(jzzzzzzzzzzzs_);
        bool? jzzzzzzzzzzzu_ = context.Operators.And(jzzzzzzzzzzzo_, jzzzzzzzzzzzt_);
        IEnumerable<Encounter> jzzzzzzzzzzzv_ = this.Two_Outpatient_Encounters_during_Measurement_Period(context);
        bool? jzzzzzzzzzzzw_ = context.Operators.Exists<Encounter>(jzzzzzzzzzzzv_);
        bool? jzzzzzzzzzzzx_ = context.Operators.And(jzzzzzzzzzzzu_, jzzzzzzzzzzzw_);

        return jzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? kzzzzzzzzzzzb_ = this.Initial_Population(context);

        return kzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? kzzzzzzzzzzzc_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        CqlCode kzzzzzzzzzzzd_ = this.Severe_cognitive_impairment__finding_(context);
        IEnumerable<CqlCode> kzzzzzzzzzzze_ = context.Operators.ToList<CqlCode>(kzzzzzzzzzzzd_);
        IEnumerable<Condition> kzzzzzzzzzzzf_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, kzzzzzzzzzzze_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? kzzzzzzzzzzzg_(Condition SevereCognitiveImpairment)
        {
            CqlInterval<CqlDateTime> kzzzzzzzzzzzk_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, SevereCognitiveImpairment);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzl_ = this.Measurement_Period(context);
            bool? kzzzzzzzzzzzm_ = context.Operators.Overlaps(kzzzzzzzzzzzk_, kzzzzzzzzzzzl_, default);

            return kzzzzzzzzzzzm_;
        };
        IEnumerable<Condition> kzzzzzzzzzzzh_ = context.Operators.Where<Condition>(kzzzzzzzzzzzf_, kzzzzzzzzzzzg_);
        bool? kzzzzzzzzzzzi_ = context.Operators.Exists<Condition>(kzzzzzzzzzzzh_);
        bool? kzzzzzzzzzzzj_ = context.Operators.Or(kzzzzzzzzzzzc_, kzzzzzzzzzzzi_);

        return kzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Date PROMIS10 Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_PROMIS10_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode kzzzzzzzzzzzn_ = this.PROMIS_10_Global_Mental_Health__GMH__score_T_score(context);
        IEnumerable<CqlCode> kzzzzzzzzzzzo_ = context.Operators.ToList<CqlCode>(kzzzzzzzzzzzn_);
        IEnumerable<Observation> kzzzzzzzzzzzp_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, kzzzzzzzzzzzo_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> kzzzzzzzzzzzq_ = Status_1_8_000.Instance.isAssessmentPerformed(context, kzzzzzzzzzzzp_);
        CqlCode kzzzzzzzzzzzr_ = this.PROMIS_10_Global_Physical_Health__GPH__score_T_score(context);
        IEnumerable<CqlCode> kzzzzzzzzzzzs_ = context.Operators.ToList<CqlCode>(kzzzzzzzzzzzr_);
        IEnumerable<Observation> kzzzzzzzzzzzt_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, kzzzzzzzzzzzs_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> kzzzzzzzzzzzu_ = Status_1_8_000.Instance.isAssessmentPerformed(context, kzzzzzzzzzzzt_);
        IEnumerable<ValueTuple<Observation, Observation>> kzzzzzzzzzzzv_ = context.Operators.CrossJoin<Observation, Observation>(kzzzzzzzzzzzq_, kzzzzzzzzzzzu_);
        (CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)? kzzzzzzzzzzzw_(ValueTuple<Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)? lzzzzzzzzzzzd_ = (CqlTupleMetadata_DDTAOdcFieSJbGgRLLZPYbGQb, _valueTuple.Item1, _valueTuple.Item2);

            return lzzzzzzzzzzzd_;
        };
        IEnumerable<(CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?> kzzzzzzzzzzzx_ = context.Operators.Select<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?>(kzzzzzzzzzzzv_, kzzzzzzzzzzzw_);
        bool? kzzzzzzzzzzzy_((CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)? tuple_ddtaodcfiesjbggrllzpybgqb)
        {
            DataType lzzzzzzzzzzze_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10MentalScore?.Effective;
            object lzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.toInterval(context, lzzzzzzzzzzzf_);
            CqlDateTime lzzzzzzzzzzzh_ = context.Operators.Start(lzzzzzzzzzzzg_);
            CqlDate lzzzzzzzzzzzi_ = context.Operators.DateFrom(lzzzzzzzzzzzh_);
            DataType lzzzzzzzzzzzj_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10PhysicalScore?.Effective;
            object lzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, lzzzzzzzzzzzk_);
            CqlDateTime lzzzzzzzzzzzm_ = context.Operators.Start(lzzzzzzzzzzzl_);
            CqlDate lzzzzzzzzzzzn_ = context.Operators.DateFrom(lzzzzzzzzzzzm_);
            bool? lzzzzzzzzzzzo_ = context.Operators.SameAs(lzzzzzzzzzzzi_, lzzzzzzzzzzzn_, "day");
            DataType lzzzzzzzzzzzp_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10MentalScore?.Value;
            object lzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzp_);
            bool? lzzzzzzzzzzzr_ = context.Operators.Not((bool?)(lzzzzzzzzzzzq_ is null));
            bool? lzzzzzzzzzzzs_ = context.Operators.And(lzzzzzzzzzzzo_, lzzzzzzzzzzzr_);
            DataType lzzzzzzzzzzzt_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10PhysicalScore?.Value;
            object lzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzt_);
            bool? lzzzzzzzzzzzv_ = context.Operators.Not((bool?)(lzzzzzzzzzzzu_ is null));
            bool? lzzzzzzzzzzzw_ = context.Operators.And(lzzzzzzzzzzzs_, lzzzzzzzzzzzv_);

            return lzzzzzzzzzzzw_;
        };
        IEnumerable<(CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?> kzzzzzzzzzzzz_ = context.Operators.Where<(CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?>(kzzzzzzzzzzzx_, kzzzzzzzzzzzy_);
        CqlDate lzzzzzzzzzzza_((CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)? tuple_ddtaodcfiesjbggrllzpybgqb)
        {
            DataType lzzzzzzzzzzzx_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10MentalScore?.Effective;
            object lzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, lzzzzzzzzzzzy_);
            CqlDateTime mzzzzzzzzzzza_ = context.Operators.Start(lzzzzzzzzzzzz_);
            CqlDate mzzzzzzzzzzzb_ = context.Operators.DateFrom(mzzzzzzzzzzza_);

            return mzzzzzzzzzzzb_;
        };
        IEnumerable<CqlDate> lzzzzzzzzzzzb_ = context.Operators.Select<(CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?, CqlDate>(kzzzzzzzzzzzz_, lzzzzzzzzzzza_);
        IEnumerable<CqlDate> lzzzzzzzzzzzc_ = context.Operators.Distinct<CqlDate>(lzzzzzzzzzzzb_);

        return lzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Has Encounter with Initial and Follow Up PROMIS10 Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_PROMIS10_Assessments(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzzzzzzc_ = this.Qualifying_Encounters(context);
        IEnumerable<CqlDate> mzzzzzzzzzzzd_ = this.Date_PROMIS10_Total_Assessment_Completed(context);
        IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> mzzzzzzzzzzzf_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(mzzzzzzzzzzzc_, mzzzzzzzzzzzd_, mzzzzzzzzzzzd_);
        (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS10Date, CqlDate FollowupPROMIS10Date)? mzzzzzzzzzzzg_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS10Date, CqlDate FollowupPROMIS10Date)? mzzzzzzzzzzzo_ = (CqlTupleMetadata_BGYjYGLNPKWAZTBCVAdLDDTMj, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return mzzzzzzzzzzzo_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS10Date, CqlDate FollowupPROMIS10Date)?> mzzzzzzzzzzzh_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS10Date, CqlDate FollowupPROMIS10Date)?>(mzzzzzzzzzzzf_, mzzzzzzzzzzzg_);
        bool? mzzzzzzzzzzzi_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS10Date, CqlDate FollowupPROMIS10Date)? tuple_dzhwgxhmbfavmzfaszbeksohj)
        {
            Period mzzzzzzzzzzzp_ = tuple_dzhwgxhmbfavmzfaszbeksohj?.ValidEncounters?.Period;
            CqlInterval<CqlDateTime> mzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, mzzzzzzzzzzzq_ as object);
            CqlDateTime mzzzzzzzzzzzs_ = context.Operators.End(mzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzt_ = this.Measurement_Period(context);
            CqlDateTime mzzzzzzzzzzzu_ = context.Operators.End(mzzzzzzzzzzzt_);
            CqlQuantity mzzzzzzzzzzzv_ = context.Operators.Quantity(180m, "days");
            CqlDateTime mzzzzzzzzzzzw_ = context.Operators.Subtract(mzzzzzzzzzzzu_, mzzzzzzzzzzzv_);
            bool? mzzzzzzzzzzzx_ = context.Operators.SameOrBefore(mzzzzzzzzzzzs_, mzzzzzzzzzzzw_, "day");
            CqlDateTime mzzzzzzzzzzzy_ = context.Operators.ConvertDateToDateTime(tuple_dzhwgxhmbfavmzfaszbeksohj?.InitialPROMIS10Date);
            CqlInterval<CqlDateTime> nzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzzza_ as object);
            CqlDateTime nzzzzzzzzzzzc_ = context.Operators.End(nzzzzzzzzzzzb_);
            CqlQuantity nzzzzzzzzzzzd_ = context.Operators.Quantity(14m, "days");
            CqlDateTime nzzzzzzzzzzze_ = context.Operators.Subtract(nzzzzzzzzzzzc_, nzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzzzg_ as object);
            CqlDateTime nzzzzzzzzzzzi_ = context.Operators.End(nzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzj_ = context.Operators.Interval(nzzzzzzzzzzze_, nzzzzzzzzzzzi_, true, true);
            bool? nzzzzzzzzzzzk_ = context.Operators.In<CqlDateTime>(mzzzzzzzzzzzy_, nzzzzzzzzzzzj_, "day");
            CqlInterval<CqlDateTime> nzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzzzm_ as object);
            CqlDateTime nzzzzzzzzzzzo_ = context.Operators.End(nzzzzzzzzzzzn_);
            bool? nzzzzzzzzzzzp_ = context.Operators.Not((bool?)(nzzzzzzzzzzzo_ is null));
            bool? nzzzzzzzzzzzq_ = context.Operators.And(nzzzzzzzzzzzk_, nzzzzzzzzzzzp_);
            bool? nzzzzzzzzzzzr_ = context.Operators.And(mzzzzzzzzzzzx_, nzzzzzzzzzzzq_);
            CqlDateTime nzzzzzzzzzzzs_ = context.Operators.ConvertDateToDateTime(tuple_dzhwgxhmbfavmzfaszbeksohj?.FollowupPROMIS10Date);
            CqlDate nzzzzzzzzzzzt_ = context.Operators.DateFrom(nzzzzzzzzzzzs_);
            CqlDate nzzzzzzzzzzzv_ = context.Operators.DateFrom(mzzzzzzzzzzzy_);
            CqlQuantity nzzzzzzzzzzzw_ = context.Operators.Quantity(30m, "days");
            CqlDate nzzzzzzzzzzzx_ = context.Operators.Add(nzzzzzzzzzzzv_, nzzzzzzzzzzzw_);
            CqlDate nzzzzzzzzzzzz_ = context.Operators.DateFrom(mzzzzzzzzzzzy_);
            CqlDate ozzzzzzzzzzzb_ = context.Operators.Add(nzzzzzzzzzzzz_, mzzzzzzzzzzzv_);
            CqlInterval<CqlDate> ozzzzzzzzzzzc_ = context.Operators.Interval(nzzzzzzzzzzzx_, ozzzzzzzzzzzb_, true, true);
            bool? ozzzzzzzzzzzd_ = context.Operators.In<CqlDate>(nzzzzzzzzzzzt_, ozzzzzzzzzzzc_, "day");
            bool? ozzzzzzzzzzze_ = context.Operators.And(nzzzzzzzzzzzr_, ozzzzzzzzzzzd_);

            return ozzzzzzzzzzze_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS10Date, CqlDate FollowupPROMIS10Date)?> mzzzzzzzzzzzj_ = context.Operators.Where<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS10Date, CqlDate FollowupPROMIS10Date)?>(mzzzzzzzzzzzh_, mzzzzzzzzzzzi_);
        Encounter mzzzzzzzzzzzk_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS10Date, CqlDate FollowupPROMIS10Date)? tuple_dzhwgxhmbfavmzfaszbeksohj) =>
            tuple_dzhwgxhmbfavmzfaszbeksohj?.ValidEncounters;
        IEnumerable<Encounter> mzzzzzzzzzzzl_ = context.Operators.Select<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS10Date, CqlDate FollowupPROMIS10Date)?, Encounter>(mzzzzzzzzzzzj_, mzzzzzzzzzzzk_);
        IEnumerable<Encounter> mzzzzzzzzzzzm_ = context.Operators.Distinct<Encounter>(mzzzzzzzzzzzl_);
        bool? mzzzzzzzzzzzn_ = context.Operators.Exists<Encounter>(mzzzzzzzzzzzm_);

        return mzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Date PROMIS29 Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_PROMIS29_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode ozzzzzzzzzzzf_ = this.PROMIS_29_Sleep_disturbance_score_T_score(context);
        IEnumerable<CqlCode> ozzzzzzzzzzzg_ = context.Operators.ToList<CqlCode>(ozzzzzzzzzzzf_);
        IEnumerable<Observation> ozzzzzzzzzzzh_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, ozzzzzzzzzzzg_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> ozzzzzzzzzzzi_ = Status_1_8_000.Instance.isAssessmentPerformed(context, ozzzzzzzzzzzh_);
        CqlCode ozzzzzzzzzzzj_ = this.PROMIS_29_Satisfaction_with_participation_in_social_roles_score_T_score(context);
        IEnumerable<CqlCode> ozzzzzzzzzzzk_ = context.Operators.ToList<CqlCode>(ozzzzzzzzzzzj_);
        IEnumerable<Observation> ozzzzzzzzzzzl_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, ozzzzzzzzzzzk_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> ozzzzzzzzzzzm_ = Status_1_8_000.Instance.isAssessmentPerformed(context, ozzzzzzzzzzzl_);
        CqlCode ozzzzzzzzzzzn_ = this.PROMIS_29_Physical_function_score_T_score(context);
        IEnumerable<CqlCode> ozzzzzzzzzzzo_ = context.Operators.ToList<CqlCode>(ozzzzzzzzzzzn_);
        IEnumerable<Observation> ozzzzzzzzzzzp_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, ozzzzzzzzzzzo_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> ozzzzzzzzzzzq_ = Status_1_8_000.Instance.isAssessmentPerformed(context, ozzzzzzzzzzzp_);
        CqlCode ozzzzzzzzzzzr_ = this.PROMIS_29_Pain_interference_score_T_score(context);
        IEnumerable<CqlCode> ozzzzzzzzzzzs_ = context.Operators.ToList<CqlCode>(ozzzzzzzzzzzr_);
        IEnumerable<Observation> ozzzzzzzzzzzt_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, ozzzzzzzzzzzs_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> ozzzzzzzzzzzu_ = Status_1_8_000.Instance.isAssessmentPerformed(context, ozzzzzzzzzzzt_);
        CqlCode ozzzzzzzzzzzv_ = this.PROMIS_29_Fatigue_score_T_score(context);
        IEnumerable<CqlCode> ozzzzzzzzzzzw_ = context.Operators.ToList<CqlCode>(ozzzzzzzzzzzv_);
        IEnumerable<Observation> ozzzzzzzzzzzx_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, ozzzzzzzzzzzw_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> ozzzzzzzzzzzy_ = Status_1_8_000.Instance.isAssessmentPerformed(context, ozzzzzzzzzzzx_);
        CqlCode ozzzzzzzzzzzz_ = this.PROMIS_29_Depression_score_T_score(context);
        IEnumerable<CqlCode> pzzzzzzzzzzza_ = context.Operators.ToList<CqlCode>(ozzzzzzzzzzzz_);
        IEnumerable<Observation> pzzzzzzzzzzzb_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, pzzzzzzzzzzza_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> pzzzzzzzzzzzc_ = Status_1_8_000.Instance.isAssessmentPerformed(context, pzzzzzzzzzzzb_);
        CqlCode pzzzzzzzzzzzd_ = this.PROMIS_29_Anxiety_score_T_score(context);
        IEnumerable<CqlCode> pzzzzzzzzzzze_ = context.Operators.ToList<CqlCode>(pzzzzzzzzzzzd_);
        IEnumerable<Observation> pzzzzzzzzzzzf_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, pzzzzzzzzzzze_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> pzzzzzzzzzzzg_ = Status_1_8_000.Instance.isAssessmentPerformed(context, pzzzzzzzzzzzf_);
        IEnumerable<ValueTuple<Observation, Observation, Observation, Observation, Observation, Observation, Observation>> pzzzzzzzzzzzh_ = context.Operators.CrossJoin<Observation, Observation, Observation, Observation, Observation, Observation, Observation>(ozzzzzzzzzzzi_, ozzzzzzzzzzzm_, ozzzzzzzzzzzq_, ozzzzzzzzzzzu_, ozzzzzzzzzzzy_, pzzzzzzzzzzzc_, pzzzzzzzzzzzg_);
        (CqlTupleMetadata, Observation Promis29Sleep, Observation Promis29SocialRoles, Observation Promis29Physical, Observation Promis29Pain, Observation Promis29Fatigue, Observation Promis29Depression, Observation Promis29Anxiety)? pzzzzzzzzzzzi_(ValueTuple<Observation, Observation, Observation, Observation, Observation, Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation Promis29Sleep, Observation Promis29SocialRoles, Observation Promis29Physical, Observation Promis29Pain, Observation Promis29Fatigue, Observation Promis29Depression, Observation Promis29Anxiety)? pzzzzzzzzzzzp_ = (CqlTupleMetadata_DBUJFOVGBcbhIQPWARNQHKUaX, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3, _valueTuple.Item4, _valueTuple.Item5, _valueTuple.Item6, _valueTuple.Item7);

            return pzzzzzzzzzzzp_;
        };
        IEnumerable<(CqlTupleMetadata, Observation Promis29Sleep, Observation Promis29SocialRoles, Observation Promis29Physical, Observation Promis29Pain, Observation Promis29Fatigue, Observation Promis29Depression, Observation Promis29Anxiety)?> pzzzzzzzzzzzj_ = context.Operators.Select<ValueTuple<Observation, Observation, Observation, Observation, Observation, Observation, Observation>, (CqlTupleMetadata, Observation Promis29Sleep, Observation Promis29SocialRoles, Observation Promis29Physical, Observation Promis29Pain, Observation Promis29Fatigue, Observation Promis29Depression, Observation Promis29Anxiety)?>(pzzzzzzzzzzzh_, pzzzzzzzzzzzi_);
        bool? pzzzzzzzzzzzk_((CqlTupleMetadata, Observation Promis29Sleep, Observation Promis29SocialRoles, Observation Promis29Physical, Observation Promis29Pain, Observation Promis29Fatigue, Observation Promis29Depression, Observation Promis29Anxiety)? tuple_cbgpsarvwrsewlglehinjanim)
        {
            DataType pzzzzzzzzzzzq_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Sleep?.Effective;
            object pzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.toInterval(context, pzzzzzzzzzzzr_);
            CqlDateTime pzzzzzzzzzzzt_ = context.Operators.Start(pzzzzzzzzzzzs_);
            CqlDate pzzzzzzzzzzzu_ = context.Operators.DateFrom(pzzzzzzzzzzzt_);
            DataType pzzzzzzzzzzzv_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29SocialRoles?.Effective;
            object pzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.toInterval(context, pzzzzzzzzzzzw_);
            CqlDateTime pzzzzzzzzzzzy_ = context.Operators.Start(pzzzzzzzzzzzx_);
            CqlDate pzzzzzzzzzzzz_ = context.Operators.DateFrom(pzzzzzzzzzzzy_);
            bool? qzzzzzzzzzzza_ = context.Operators.SameAs(pzzzzzzzzzzzu_, pzzzzzzzzzzzz_, "day");
            DataType qzzzzzzzzzzzb_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29SocialRoles?.Value;
            object qzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzb_);
            bool? qzzzzzzzzzzzd_ = context.Operators.Not((bool?)(qzzzzzzzzzzzc_ is null));
            bool? qzzzzzzzzzzze_ = context.Operators.And(qzzzzzzzzzzza_, qzzzzzzzzzzzd_);
            object qzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.toInterval(context, qzzzzzzzzzzzg_);
            CqlDateTime qzzzzzzzzzzzi_ = context.Operators.Start(qzzzzzzzzzzzh_);
            CqlDate qzzzzzzzzzzzj_ = context.Operators.DateFrom(qzzzzzzzzzzzi_);
            DataType qzzzzzzzzzzzk_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Physical?.Effective;
            object qzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzk_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.toInterval(context, qzzzzzzzzzzzl_);
            CqlDateTime qzzzzzzzzzzzn_ = context.Operators.Start(qzzzzzzzzzzzm_);
            CqlDate qzzzzzzzzzzzo_ = context.Operators.DateFrom(qzzzzzzzzzzzn_);
            bool? qzzzzzzzzzzzp_ = context.Operators.SameAs(qzzzzzzzzzzzj_, qzzzzzzzzzzzo_, "day");
            bool? qzzzzzzzzzzzq_ = context.Operators.And(qzzzzzzzzzzze_, qzzzzzzzzzzzp_);
            DataType qzzzzzzzzzzzr_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Physical?.Value;
            object qzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, qzzzzzzzzzzzr_);
            bool? qzzzzzzzzzzzt_ = context.Operators.Not((bool?)(qzzzzzzzzzzzs_ is null));
            bool? qzzzzzzzzzzzu_ = context.Operators.And(qzzzzzzzzzzzq_, qzzzzzzzzzzzt_);
            object qzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.toInterval(context, qzzzzzzzzzzzw_);
            CqlDateTime qzzzzzzzzzzzy_ = context.Operators.Start(qzzzzzzzzzzzx_);
            CqlDate qzzzzzzzzzzzz_ = context.Operators.DateFrom(qzzzzzzzzzzzy_);
            DataType rzzzzzzzzzzza_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Pain?.Effective;
            object rzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzza_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, rzzzzzzzzzzzb_);
            CqlDateTime rzzzzzzzzzzzd_ = context.Operators.Start(rzzzzzzzzzzzc_);
            CqlDate rzzzzzzzzzzze_ = context.Operators.DateFrom(rzzzzzzzzzzzd_);
            bool? rzzzzzzzzzzzf_ = context.Operators.SameAs(qzzzzzzzzzzzz_, rzzzzzzzzzzze_, "day");
            bool? rzzzzzzzzzzzg_ = context.Operators.And(qzzzzzzzzzzzu_, rzzzzzzzzzzzf_);
            DataType rzzzzzzzzzzzh_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Pain?.Value;
            object rzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzh_);
            bool? rzzzzzzzzzzzj_ = context.Operators.Not((bool?)(rzzzzzzzzzzzi_ is null));
            bool? rzzzzzzzzzzzk_ = context.Operators.And(rzzzzzzzzzzzg_, rzzzzzzzzzzzj_);
            object rzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.toInterval(context, rzzzzzzzzzzzm_);
            CqlDateTime rzzzzzzzzzzzo_ = context.Operators.Start(rzzzzzzzzzzzn_);
            CqlDate rzzzzzzzzzzzp_ = context.Operators.DateFrom(rzzzzzzzzzzzo_);
            DataType rzzzzzzzzzzzq_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Fatigue?.Effective;
            object rzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.toInterval(context, rzzzzzzzzzzzr_);
            CqlDateTime rzzzzzzzzzzzt_ = context.Operators.Start(rzzzzzzzzzzzs_);
            CqlDate rzzzzzzzzzzzu_ = context.Operators.DateFrom(rzzzzzzzzzzzt_);
            bool? rzzzzzzzzzzzv_ = context.Operators.SameAs(rzzzzzzzzzzzp_, rzzzzzzzzzzzu_, "day");
            bool? rzzzzzzzzzzzw_ = context.Operators.And(rzzzzzzzzzzzk_, rzzzzzzzzzzzv_);
            DataType rzzzzzzzzzzzx_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Fatigue?.Value;
            object rzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, rzzzzzzzzzzzx_);
            bool? rzzzzzzzzzzzz_ = context.Operators.Not((bool?)(rzzzzzzzzzzzy_ is null));
            bool? szzzzzzzzzzza_ = context.Operators.And(rzzzzzzzzzzzw_, rzzzzzzzzzzzz_);
            object szzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.toInterval(context, szzzzzzzzzzzc_);
            CqlDateTime szzzzzzzzzzze_ = context.Operators.Start(szzzzzzzzzzzd_);
            CqlDate szzzzzzzzzzzf_ = context.Operators.DateFrom(szzzzzzzzzzze_);
            DataType szzzzzzzzzzzg_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Depression?.Effective;
            object szzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.toInterval(context, szzzzzzzzzzzh_);
            CqlDateTime szzzzzzzzzzzj_ = context.Operators.Start(szzzzzzzzzzzi_);
            CqlDate szzzzzzzzzzzk_ = context.Operators.DateFrom(szzzzzzzzzzzj_);
            bool? szzzzzzzzzzzl_ = context.Operators.SameAs(szzzzzzzzzzzf_, szzzzzzzzzzzk_, "day");
            bool? szzzzzzzzzzzm_ = context.Operators.And(szzzzzzzzzzza_, szzzzzzzzzzzl_);
            DataType szzzzzzzzzzzn_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Depression?.Value;
            object szzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzn_);
            bool? szzzzzzzzzzzp_ = context.Operators.Not((bool?)(szzzzzzzzzzzo_ is null));
            bool? szzzzzzzzzzzq_ = context.Operators.And(szzzzzzzzzzzm_, szzzzzzzzzzzp_);
            object szzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.toInterval(context, szzzzzzzzzzzs_);
            CqlDateTime szzzzzzzzzzzu_ = context.Operators.Start(szzzzzzzzzzzt_);
            CqlDate szzzzzzzzzzzv_ = context.Operators.DateFrom(szzzzzzzzzzzu_);
            DataType szzzzzzzzzzzw_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Anxiety?.Effective;
            object szzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, szzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> szzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.toInterval(context, szzzzzzzzzzzx_);
            CqlDateTime szzzzzzzzzzzz_ = context.Operators.Start(szzzzzzzzzzzy_);
            CqlDate tzzzzzzzzzzza_ = context.Operators.DateFrom(szzzzzzzzzzzz_);
            bool? tzzzzzzzzzzzb_ = context.Operators.SameAs(szzzzzzzzzzzv_, tzzzzzzzzzzza_, "day");
            bool? tzzzzzzzzzzzc_ = context.Operators.And(szzzzzzzzzzzq_, tzzzzzzzzzzzb_);
            DataType tzzzzzzzzzzzd_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Anxiety?.Value;
            object tzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzd_);
            bool? tzzzzzzzzzzzf_ = context.Operators.Not((bool?)(tzzzzzzzzzzze_ is null));
            bool? tzzzzzzzzzzzg_ = context.Operators.And(tzzzzzzzzzzzc_, tzzzzzzzzzzzf_);
            DataType tzzzzzzzzzzzh_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Sleep?.Value;
            object tzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzh_);
            bool? tzzzzzzzzzzzj_ = context.Operators.Not((bool?)(tzzzzzzzzzzzi_ is null));
            bool? tzzzzzzzzzzzk_ = context.Operators.And(tzzzzzzzzzzzg_, tzzzzzzzzzzzj_);

            return tzzzzzzzzzzzk_;
        };
        IEnumerable<(CqlTupleMetadata, Observation Promis29Sleep, Observation Promis29SocialRoles, Observation Promis29Physical, Observation Promis29Pain, Observation Promis29Fatigue, Observation Promis29Depression, Observation Promis29Anxiety)?> pzzzzzzzzzzzl_ = context.Operators.Where<(CqlTupleMetadata, Observation Promis29Sleep, Observation Promis29SocialRoles, Observation Promis29Physical, Observation Promis29Pain, Observation Promis29Fatigue, Observation Promis29Depression, Observation Promis29Anxiety)?>(pzzzzzzzzzzzj_, pzzzzzzzzzzzk_);
        CqlDate pzzzzzzzzzzzm_((CqlTupleMetadata, Observation Promis29Sleep, Observation Promis29SocialRoles, Observation Promis29Physical, Observation Promis29Pain, Observation Promis29Fatigue, Observation Promis29Depression, Observation Promis29Anxiety)? tuple_cbgpsarvwrsewlglehinjanim)
        {
            DataType tzzzzzzzzzzzl_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Sleep?.Effective;
            object tzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.toInterval(context, tzzzzzzzzzzzm_);
            CqlDateTime tzzzzzzzzzzzo_ = context.Operators.Start(tzzzzzzzzzzzn_);
            CqlDate tzzzzzzzzzzzp_ = context.Operators.DateFrom(tzzzzzzzzzzzo_);

            return tzzzzzzzzzzzp_;
        };
        IEnumerable<CqlDate> pzzzzzzzzzzzn_ = context.Operators.Select<(CqlTupleMetadata, Observation Promis29Sleep, Observation Promis29SocialRoles, Observation Promis29Physical, Observation Promis29Pain, Observation Promis29Fatigue, Observation Promis29Depression, Observation Promis29Anxiety)?, CqlDate>(pzzzzzzzzzzzl_, pzzzzzzzzzzzm_);
        IEnumerable<CqlDate> pzzzzzzzzzzzo_ = context.Operators.Distinct<CqlDate>(pzzzzzzzzzzzn_);

        return pzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Has Encounter with Initial and Follow Up PROMIS29 Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_PROMIS29_Assessments(CqlContext context)
    {
        IEnumerable<Encounter> tzzzzzzzzzzzq_ = this.Qualifying_Encounters(context);
        IEnumerable<CqlDate> tzzzzzzzzzzzr_ = this.Date_PROMIS29_Total_Assessment_Completed(context);
        IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> tzzzzzzzzzzzt_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(tzzzzzzzzzzzq_, tzzzzzzzzzzzr_, tzzzzzzzzzzzr_);
        (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS29Date, CqlDate FollowupPROMIS29Date)? tzzzzzzzzzzzu_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS29Date, CqlDate FollowupPROMIS29Date)? uzzzzzzzzzzzc_ = (CqlTupleMetadata_DSZKEYVbCINNIeAQiZdVaEJhG, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return uzzzzzzzzzzzc_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS29Date, CqlDate FollowupPROMIS29Date)?> tzzzzzzzzzzzv_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS29Date, CqlDate FollowupPROMIS29Date)?>(tzzzzzzzzzzzt_, tzzzzzzzzzzzu_);
        bool? tzzzzzzzzzzzw_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS29Date, CqlDate FollowupPROMIS29Date)? tuple_kmpntxjuhkpbcwgftqigieao)
        {
            Period uzzzzzzzzzzzd_ = tuple_kmpntxjuhkpbcwgftqigieao?.ValidEncounters?.Period;
            CqlInterval<CqlDateTime> uzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, uzzzzzzzzzzze_ as object);
            CqlDateTime uzzzzzzzzzzzg_ = context.Operators.End(uzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzh_ = this.Measurement_Period(context);
            CqlDateTime uzzzzzzzzzzzi_ = context.Operators.End(uzzzzzzzzzzzh_);
            CqlQuantity uzzzzzzzzzzzj_ = context.Operators.Quantity(180m, "days");
            CqlDateTime uzzzzzzzzzzzk_ = context.Operators.Subtract(uzzzzzzzzzzzi_, uzzzzzzzzzzzj_);
            bool? uzzzzzzzzzzzl_ = context.Operators.SameOrBefore(uzzzzzzzzzzzg_, uzzzzzzzzzzzk_, "day");
            CqlDateTime uzzzzzzzzzzzm_ = context.Operators.ConvertDateToDateTime(tuple_kmpntxjuhkpbcwgftqigieao?.InitialPROMIS29Date);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, uzzzzzzzzzzzo_ as object);
            CqlDateTime uzzzzzzzzzzzq_ = context.Operators.End(uzzzzzzzzzzzp_);
            CqlQuantity uzzzzzzzzzzzr_ = context.Operators.Quantity(14m, "days");
            CqlDateTime uzzzzzzzzzzzs_ = context.Operators.Subtract(uzzzzzzzzzzzq_, uzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, uzzzzzzzzzzzu_ as object);
            CqlDateTime uzzzzzzzzzzzw_ = context.Operators.End(uzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzx_ = context.Operators.Interval(uzzzzzzzzzzzs_, uzzzzzzzzzzzw_, true, true);
            bool? uzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(uzzzzzzzzzzzm_, uzzzzzzzzzzzx_, "day");
            CqlInterval<CqlDateTime> vzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, vzzzzzzzzzzza_ as object);
            CqlDateTime vzzzzzzzzzzzc_ = context.Operators.End(vzzzzzzzzzzzb_);
            bool? vzzzzzzzzzzzd_ = context.Operators.Not((bool?)(vzzzzzzzzzzzc_ is null));
            bool? vzzzzzzzzzzze_ = context.Operators.And(uzzzzzzzzzzzy_, vzzzzzzzzzzzd_);
            bool? vzzzzzzzzzzzf_ = context.Operators.And(uzzzzzzzzzzzl_, vzzzzzzzzzzze_);
            CqlDateTime vzzzzzzzzzzzg_ = context.Operators.ConvertDateToDateTime(tuple_kmpntxjuhkpbcwgftqigieao?.FollowupPROMIS29Date);
            CqlDate vzzzzzzzzzzzh_ = context.Operators.DateFrom(vzzzzzzzzzzzg_);
            CqlDate vzzzzzzzzzzzj_ = context.Operators.DateFrom(uzzzzzzzzzzzm_);
            CqlQuantity vzzzzzzzzzzzk_ = context.Operators.Quantity(30m, "days");
            CqlDate vzzzzzzzzzzzl_ = context.Operators.Add(vzzzzzzzzzzzj_, vzzzzzzzzzzzk_);
            CqlDate vzzzzzzzzzzzn_ = context.Operators.DateFrom(uzzzzzzzzzzzm_);
            CqlDate vzzzzzzzzzzzp_ = context.Operators.Add(vzzzzzzzzzzzn_, uzzzzzzzzzzzj_);
            CqlInterval<CqlDate> vzzzzzzzzzzzq_ = context.Operators.Interval(vzzzzzzzzzzzl_, vzzzzzzzzzzzp_, true, true);
            bool? vzzzzzzzzzzzr_ = context.Operators.In<CqlDate>(vzzzzzzzzzzzh_, vzzzzzzzzzzzq_, "day");
            bool? vzzzzzzzzzzzs_ = context.Operators.And(vzzzzzzzzzzzf_, vzzzzzzzzzzzr_);

            return vzzzzzzzzzzzs_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS29Date, CqlDate FollowupPROMIS29Date)?> tzzzzzzzzzzzx_ = context.Operators.Where<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS29Date, CqlDate FollowupPROMIS29Date)?>(tzzzzzzzzzzzv_, tzzzzzzzzzzzw_);
        Encounter tzzzzzzzzzzzy_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS29Date, CqlDate FollowupPROMIS29Date)? tuple_kmpntxjuhkpbcwgftqigieao) =>
            tuple_kmpntxjuhkpbcwgftqigieao?.ValidEncounters;
        IEnumerable<Encounter> tzzzzzzzzzzzz_ = context.Operators.Select<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS29Date, CqlDate FollowupPROMIS29Date)?, Encounter>(tzzzzzzzzzzzx_, tzzzzzzzzzzzy_);
        IEnumerable<Encounter> uzzzzzzzzzzza_ = context.Operators.Distinct<Encounter>(tzzzzzzzzzzzz_);
        bool? uzzzzzzzzzzzb_ = context.Operators.Exists<Encounter>(uzzzzzzzzzzza_);

        return uzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Date VR12 Oblique Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_VR12_Oblique_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode vzzzzzzzzzzzt_ = this.VR_12_Mental_component_summary__MCS__score___oblique_method_T_score(context);
        IEnumerable<CqlCode> vzzzzzzzzzzzu_ = context.Operators.ToList<CqlCode>(vzzzzzzzzzzzt_);
        IEnumerable<Observation> vzzzzzzzzzzzv_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, vzzzzzzzzzzzu_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> vzzzzzzzzzzzw_ = Status_1_8_000.Instance.isAssessmentPerformed(context, vzzzzzzzzzzzv_);
        CqlCode vzzzzzzzzzzzx_ = this.VR_12_Physical_component_summary__PCS__score___oblique_method_T_score(context);
        IEnumerable<CqlCode> vzzzzzzzzzzzy_ = context.Operators.ToList<CqlCode>(vzzzzzzzzzzzx_);
        IEnumerable<Observation> vzzzzzzzzzzzz_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, vzzzzzzzzzzzy_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> wzzzzzzzzzzza_ = Status_1_8_000.Instance.isAssessmentPerformed(context, vzzzzzzzzzzzz_);
        IEnumerable<ValueTuple<Observation, Observation>> wzzzzzzzzzzzb_ = context.Operators.CrossJoin<Observation, Observation>(vzzzzzzzzzzzw_, wzzzzzzzzzzza_);
        (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? wzzzzzzzzzzzc_(ValueTuple<Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? wzzzzzzzzzzzj_ = (CqlTupleMetadata_GAdRFKRaHUUGJcVHWQWRUjhRH, _valueTuple.Item1, _valueTuple.Item2);

            return wzzzzzzzzzzzj_;
        };
        IEnumerable<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?> wzzzzzzzzzzzd_ = context.Operators.Select<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?>(wzzzzzzzzzzzb_, wzzzzzzzzzzzc_);
        bool? wzzzzzzzzzzze_((CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? tuple_gadrfkrahuugjcvhwqwrujhrh)
        {
            DataType wzzzzzzzzzzzk_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Effective;
            object wzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzk_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.toInterval(context, wzzzzzzzzzzzl_);
            CqlDateTime wzzzzzzzzzzzn_ = context.Operators.Start(wzzzzzzzzzzzm_);
            CqlDate wzzzzzzzzzzzo_ = context.Operators.DateFrom(wzzzzzzzzzzzn_);
            DataType wzzzzzzzzzzzp_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Effective;
            object wzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, wzzzzzzzzzzzq_);
            CqlDateTime wzzzzzzzzzzzs_ = context.Operators.Start(wzzzzzzzzzzzr_);
            CqlDate wzzzzzzzzzzzt_ = context.Operators.DateFrom(wzzzzzzzzzzzs_);
            bool? wzzzzzzzzzzzu_ = context.Operators.SameAs(wzzzzzzzzzzzo_, wzzzzzzzzzzzt_, "day");
            DataType wzzzzzzzzzzzv_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Value;
            object wzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzv_);
            bool? wzzzzzzzzzzzx_ = context.Operators.Not((bool?)(wzzzzzzzzzzzw_ is null));
            bool? wzzzzzzzzzzzy_ = context.Operators.And(wzzzzzzzzzzzu_, wzzzzzzzzzzzx_);
            DataType wzzzzzzzzzzzz_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Value;
            object xzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzz_);
            bool? xzzzzzzzzzzzb_ = context.Operators.Not((bool?)(xzzzzzzzzzzza_ is null));
            bool? xzzzzzzzzzzzc_ = context.Operators.And(wzzzzzzzzzzzy_, xzzzzzzzzzzzb_);

            return xzzzzzzzzzzzc_;
        };
        IEnumerable<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?> wzzzzzzzzzzzf_ = context.Operators.Where<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?>(wzzzzzzzzzzzd_, wzzzzzzzzzzze_);
        CqlDate wzzzzzzzzzzzg_((CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? tuple_gadrfkrahuugjcvhwqwrujhrh)
        {
            DataType xzzzzzzzzzzzd_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Effective;
            object xzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, xzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzzze_);
            CqlDateTime xzzzzzzzzzzzg_ = context.Operators.Start(xzzzzzzzzzzzf_);
            CqlDate xzzzzzzzzzzzh_ = context.Operators.DateFrom(xzzzzzzzzzzzg_);

            return xzzzzzzzzzzzh_;
        };
        IEnumerable<CqlDate> wzzzzzzzzzzzh_ = context.Operators.Select<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?, CqlDate>(wzzzzzzzzzzzf_, wzzzzzzzzzzzg_);
        IEnumerable<CqlDate> wzzzzzzzzzzzi_ = context.Operators.Distinct<CqlDate>(wzzzzzzzzzzzh_);

        return wzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Has Encounter with Initial and Follow Up VR12 Oblique Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_VR12_Oblique_Assessments(CqlContext context)
    {
        IEnumerable<Encounter> xzzzzzzzzzzzi_ = this.Qualifying_Encounters(context);
        IEnumerable<CqlDate> xzzzzzzzzzzzj_ = this.Date_VR12_Oblique_Total_Assessment_Completed(context);
        IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> xzzzzzzzzzzzl_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(xzzzzzzzzzzzi_, xzzzzzzzzzzzj_, xzzzzzzzzzzzj_);
        (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12ObliqueDate, CqlDate FollowupVR12ObliqueDate)? xzzzzzzzzzzzm_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12ObliqueDate, CqlDate FollowupVR12ObliqueDate)? xzzzzzzzzzzzu_ = (CqlTupleMetadata_FQKGdEYLiDFGMNAUAMETIHUQT, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return xzzzzzzzzzzzu_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12ObliqueDate, CqlDate FollowupVR12ObliqueDate)?> xzzzzzzzzzzzn_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12ObliqueDate, CqlDate FollowupVR12ObliqueDate)?>(xzzzzzzzzzzzl_, xzzzzzzzzzzzm_);
        bool? xzzzzzzzzzzzo_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12ObliqueDate, CqlDate FollowupVR12ObliqueDate)? tuple_fppktdiagiekhptnsbacpswh)
        {
            Period xzzzzzzzzzzzv_ = tuple_fppktdiagiekhptnsbacpswh?.ValidEncounters?.Period;
            CqlInterval<CqlDateTime> xzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzzzw_ as object);
            CqlDateTime xzzzzzzzzzzzy_ = context.Operators.End(xzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzz_ = this.Measurement_Period(context);
            CqlDateTime yzzzzzzzzzzza_ = context.Operators.End(xzzzzzzzzzzzz_);
            CqlQuantity yzzzzzzzzzzzb_ = context.Operators.Quantity(180m, "days");
            CqlDateTime yzzzzzzzzzzzc_ = context.Operators.Subtract(yzzzzzzzzzzza_, yzzzzzzzzzzzb_);
            bool? yzzzzzzzzzzzd_ = context.Operators.SameOrBefore(xzzzzzzzzzzzy_, yzzzzzzzzzzzc_, "day");
            CqlDateTime yzzzzzzzzzzze_ = context.Operators.ConvertDateToDateTime(tuple_fppktdiagiekhptnsbacpswh?.InitialVR12ObliqueDate);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.toInterval(context, yzzzzzzzzzzzg_ as object);
            CqlDateTime yzzzzzzzzzzzi_ = context.Operators.End(yzzzzzzzzzzzh_);
            CqlQuantity yzzzzzzzzzzzj_ = context.Operators.Quantity(14m, "days");
            CqlDateTime yzzzzzzzzzzzk_ = context.Operators.Subtract(yzzzzzzzzzzzi_, yzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.toInterval(context, yzzzzzzzzzzzm_ as object);
            CqlDateTime yzzzzzzzzzzzo_ = context.Operators.End(yzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzp_ = context.Operators.Interval(yzzzzzzzzzzzk_, yzzzzzzzzzzzo_, true, true);
            bool? yzzzzzzzzzzzq_ = context.Operators.In<CqlDateTime>(yzzzzzzzzzzze_, yzzzzzzzzzzzp_, "day");
            CqlInterval<CqlDateTime> yzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.toInterval(context, yzzzzzzzzzzzs_ as object);
            CqlDateTime yzzzzzzzzzzzu_ = context.Operators.End(yzzzzzzzzzzzt_);
            bool? yzzzzzzzzzzzv_ = context.Operators.Not((bool?)(yzzzzzzzzzzzu_ is null));
            bool? yzzzzzzzzzzzw_ = context.Operators.And(yzzzzzzzzzzzq_, yzzzzzzzzzzzv_);
            bool? yzzzzzzzzzzzx_ = context.Operators.And(yzzzzzzzzzzzd_, yzzzzzzzzzzzw_);
            CqlDateTime yzzzzzzzzzzzy_ = context.Operators.ConvertDateToDateTime(tuple_fppktdiagiekhptnsbacpswh?.FollowupVR12ObliqueDate);
            CqlDate yzzzzzzzzzzzz_ = context.Operators.DateFrom(yzzzzzzzzzzzy_);
            CqlDate zzzzzzzzzzzzb_ = context.Operators.DateFrom(yzzzzzzzzzzze_);
            CqlQuantity zzzzzzzzzzzzc_ = context.Operators.Quantity(30m, "days");
            CqlDate zzzzzzzzzzzzd_ = context.Operators.Add(zzzzzzzzzzzzb_, zzzzzzzzzzzzc_);
            CqlDate zzzzzzzzzzzzf_ = context.Operators.DateFrom(yzzzzzzzzzzze_);
            CqlDate zzzzzzzzzzzzh_ = context.Operators.Add(zzzzzzzzzzzzf_, yzzzzzzzzzzzb_);
            CqlInterval<CqlDate> zzzzzzzzzzzzi_ = context.Operators.Interval(zzzzzzzzzzzzd_, zzzzzzzzzzzzh_, true, true);
            bool? zzzzzzzzzzzzj_ = context.Operators.In<CqlDate>(yzzzzzzzzzzzz_, zzzzzzzzzzzzi_, "day");
            bool? zzzzzzzzzzzzk_ = context.Operators.And(yzzzzzzzzzzzx_, zzzzzzzzzzzzj_);

            return zzzzzzzzzzzzk_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12ObliqueDate, CqlDate FollowupVR12ObliqueDate)?> xzzzzzzzzzzzp_ = context.Operators.Where<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12ObliqueDate, CqlDate FollowupVR12ObliqueDate)?>(xzzzzzzzzzzzn_, xzzzzzzzzzzzo_);
        Encounter xzzzzzzzzzzzq_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12ObliqueDate, CqlDate FollowupVR12ObliqueDate)? tuple_fppktdiagiekhptnsbacpswh) =>
            tuple_fppktdiagiekhptnsbacpswh?.ValidEncounters;
        IEnumerable<Encounter> xzzzzzzzzzzzr_ = context.Operators.Select<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12ObliqueDate, CqlDate FollowupVR12ObliqueDate)?, Encounter>(xzzzzzzzzzzzp_, xzzzzzzzzzzzq_);
        IEnumerable<Encounter> xzzzzzzzzzzzs_ = context.Operators.Distinct<Encounter>(xzzzzzzzzzzzr_);
        bool? xzzzzzzzzzzzt_ = context.Operators.Exists<Encounter>(xzzzzzzzzzzzs_);

        return xzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Date VR12 Orthogonal Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_VR12_Orthogonal_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode zzzzzzzzzzzzl_ = this.VR_12_Mental_component_summary__MCS__score___orthogonal_method_T_score(context);
        IEnumerable<CqlCode> zzzzzzzzzzzzm_ = context.Operators.ToList<CqlCode>(zzzzzzzzzzzzl_);
        IEnumerable<Observation> zzzzzzzzzzzzn_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, zzzzzzzzzzzzm_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> zzzzzzzzzzzzo_ = Status_1_8_000.Instance.isAssessmentPerformed(context, zzzzzzzzzzzzn_);
        CqlCode zzzzzzzzzzzzp_ = this.VR_12_Physical_component_summary__PCS__score___orthogonal_method_T_score(context);
        IEnumerable<CqlCode> zzzzzzzzzzzzq_ = context.Operators.ToList<CqlCode>(zzzzzzzzzzzzp_);
        IEnumerable<Observation> zzzzzzzzzzzzr_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, zzzzzzzzzzzzq_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> zzzzzzzzzzzzs_ = Status_1_8_000.Instance.isAssessmentPerformed(context, zzzzzzzzzzzzr_);
        IEnumerable<ValueTuple<Observation, Observation>> zzzzzzzzzzzzt_ = context.Operators.CrossJoin<Observation, Observation>(zzzzzzzzzzzzo_, zzzzzzzzzzzzs_);
        (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? zzzzzzzzzzzzu_(ValueTuple<Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? azzzzzzzzzzzzb_ = (CqlTupleMetadata_GAdRFKRaHUUGJcVHWQWRUjhRH, _valueTuple.Item1, _valueTuple.Item2);

            return azzzzzzzzzzzzb_;
        };
        IEnumerable<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?> zzzzzzzzzzzzv_ = context.Operators.Select<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?>(zzzzzzzzzzzzt_, zzzzzzzzzzzzu_);
        bool? zzzzzzzzzzzzw_((CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? tuple_gadrfkrahuugjcvhwqwrujhrh)
        {
            DataType azzzzzzzzzzzzc_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Effective;
            object azzzzzzzzzzzzd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzc_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzze_ = QICoreCommon_2_1_000.Instance.toInterval(context, azzzzzzzzzzzzd_);
            CqlDateTime azzzzzzzzzzzzf_ = context.Operators.Start(azzzzzzzzzzzze_);
            CqlDate azzzzzzzzzzzzg_ = context.Operators.DateFrom(azzzzzzzzzzzzf_);
            DataType azzzzzzzzzzzzh_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Effective;
            object azzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.toInterval(context, azzzzzzzzzzzzi_);
            CqlDateTime azzzzzzzzzzzzk_ = context.Operators.Start(azzzzzzzzzzzzj_);
            CqlDate azzzzzzzzzzzzl_ = context.Operators.DateFrom(azzzzzzzzzzzzk_);
            bool? azzzzzzzzzzzzm_ = context.Operators.SameAs(azzzzzzzzzzzzg_, azzzzzzzzzzzzl_, "day");
            DataType azzzzzzzzzzzzn_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Value;
            object azzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzn_);
            bool? azzzzzzzzzzzzp_ = context.Operators.Not((bool?)(azzzzzzzzzzzzo_ is null));
            bool? azzzzzzzzzzzzq_ = context.Operators.And(azzzzzzzzzzzzm_, azzzzzzzzzzzzp_);
            DataType azzzzzzzzzzzzr_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Value;
            object azzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzr_);
            bool? azzzzzzzzzzzzt_ = context.Operators.Not((bool?)(azzzzzzzzzzzzs_ is null));
            bool? azzzzzzzzzzzzu_ = context.Operators.And(azzzzzzzzzzzzq_, azzzzzzzzzzzzt_);

            return azzzzzzzzzzzzu_;
        };
        IEnumerable<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?> zzzzzzzzzzzzx_ = context.Operators.Where<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?>(zzzzzzzzzzzzv_, zzzzzzzzzzzzw_);
        CqlDate zzzzzzzzzzzzy_((CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? tuple_gadrfkrahuugjcvhwqwrujhrh)
        {
            DataType azzzzzzzzzzzzv_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Effective;
            object azzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, azzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.toInterval(context, azzzzzzzzzzzzw_);
            CqlDateTime azzzzzzzzzzzzy_ = context.Operators.Start(azzzzzzzzzzzzx_);
            CqlDate azzzzzzzzzzzzz_ = context.Operators.DateFrom(azzzzzzzzzzzzy_);

            return azzzzzzzzzzzzz_;
        };
        IEnumerable<CqlDate> zzzzzzzzzzzzz_ = context.Operators.Select<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?, CqlDate>(zzzzzzzzzzzzx_, zzzzzzzzzzzzy_);
        IEnumerable<CqlDate> azzzzzzzzzzzza_ = context.Operators.Distinct<CqlDate>(zzzzzzzzzzzzz_);

        return azzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Has Encounter with Initial and Follow Up VR12 Orthogonal Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments(CqlContext context)
    {
        IEnumerable<Encounter> bzzzzzzzzzzzza_ = this.Qualifying_Encounters(context);
        IEnumerable<CqlDate> bzzzzzzzzzzzzb_ = this.Date_VR12_Orthogonal_Total_Assessment_Completed(context);
        IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> bzzzzzzzzzzzzd_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(bzzzzzzzzzzzza_, bzzzzzzzzzzzzb_, bzzzzzzzzzzzzb_);
        (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12OrthogonalDate, CqlDate FollowupVR12OrthogonalDate)? bzzzzzzzzzzzze_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12OrthogonalDate, CqlDate FollowupVR12OrthogonalDate)? bzzzzzzzzzzzzm_ = (CqlTupleMetadata_HSSAQEFQAOXLjUcOKGgicELWB, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return bzzzzzzzzzzzzm_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12OrthogonalDate, CqlDate FollowupVR12OrthogonalDate)?> bzzzzzzzzzzzzf_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12OrthogonalDate, CqlDate FollowupVR12OrthogonalDate)?>(bzzzzzzzzzzzzd_, bzzzzzzzzzzzze_);
        bool? bzzzzzzzzzzzzg_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12OrthogonalDate, CqlDate FollowupVR12OrthogonalDate)? tuple_fansvmjaedmvsdoyrozxdlsai)
        {
            Period bzzzzzzzzzzzzn_ = tuple_fansvmjaedmvsdoyrozxdlsai?.ValidEncounters?.Period;
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzzo_ as object);
            CqlDateTime bzzzzzzzzzzzzq_ = context.Operators.End(bzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzr_ = this.Measurement_Period(context);
            CqlDateTime bzzzzzzzzzzzzs_ = context.Operators.End(bzzzzzzzzzzzzr_);
            CqlQuantity bzzzzzzzzzzzzt_ = context.Operators.Quantity(180m, "days");
            CqlDateTime bzzzzzzzzzzzzu_ = context.Operators.Subtract(bzzzzzzzzzzzzs_, bzzzzzzzzzzzzt_);
            bool? bzzzzzzzzzzzzv_ = context.Operators.SameOrBefore(bzzzzzzzzzzzzq_, bzzzzzzzzzzzzu_, "day");
            CqlDateTime bzzzzzzzzzzzzw_ = context.Operators.ConvertDateToDateTime(tuple_fansvmjaedmvsdoyrozxdlsai?.InitialVR12OrthogonalDate);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, bzzzzzzzzzzzzy_ as object);
            CqlDateTime czzzzzzzzzzzza_ = context.Operators.End(bzzzzzzzzzzzzz_);
            CqlQuantity czzzzzzzzzzzzb_ = context.Operators.Quantity(14m, "days");
            CqlDateTime czzzzzzzzzzzzc_ = context.Operators.Subtract(czzzzzzzzzzzza_, czzzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, czzzzzzzzzzzze_ as object);
            CqlDateTime czzzzzzzzzzzzg_ = context.Operators.End(czzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzh_ = context.Operators.Interval(czzzzzzzzzzzzc_, czzzzzzzzzzzzg_, true, true);
            bool? czzzzzzzzzzzzi_ = context.Operators.In<CqlDateTime>(bzzzzzzzzzzzzw_, czzzzzzzzzzzzh_, "day");
            CqlInterval<CqlDateTime> czzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> czzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, czzzzzzzzzzzzk_ as object);
            CqlDateTime czzzzzzzzzzzzm_ = context.Operators.End(czzzzzzzzzzzzl_);
            bool? czzzzzzzzzzzzn_ = context.Operators.Not((bool?)(czzzzzzzzzzzzm_ is null));
            bool? czzzzzzzzzzzzo_ = context.Operators.And(czzzzzzzzzzzzi_, czzzzzzzzzzzzn_);
            bool? czzzzzzzzzzzzp_ = context.Operators.And(bzzzzzzzzzzzzv_, czzzzzzzzzzzzo_);
            CqlDateTime czzzzzzzzzzzzq_ = context.Operators.ConvertDateToDateTime(tuple_fansvmjaedmvsdoyrozxdlsai?.FollowupVR12OrthogonalDate);
            CqlDate czzzzzzzzzzzzr_ = context.Operators.DateFrom(czzzzzzzzzzzzq_);
            CqlDate czzzzzzzzzzzzt_ = context.Operators.DateFrom(bzzzzzzzzzzzzw_);
            CqlQuantity czzzzzzzzzzzzu_ = context.Operators.Quantity(30m, "days");
            CqlDate czzzzzzzzzzzzv_ = context.Operators.Add(czzzzzzzzzzzzt_, czzzzzzzzzzzzu_);
            CqlDate czzzzzzzzzzzzx_ = context.Operators.DateFrom(bzzzzzzzzzzzzw_);
            CqlDate czzzzzzzzzzzzz_ = context.Operators.Add(czzzzzzzzzzzzx_, bzzzzzzzzzzzzt_);
            CqlInterval<CqlDate> dzzzzzzzzzzzza_ = context.Operators.Interval(czzzzzzzzzzzzv_, czzzzzzzzzzzzz_, true, true);
            bool? dzzzzzzzzzzzzb_ = context.Operators.In<CqlDate>(czzzzzzzzzzzzr_, dzzzzzzzzzzzza_, "day");
            bool? dzzzzzzzzzzzzc_ = context.Operators.And(czzzzzzzzzzzzp_, dzzzzzzzzzzzzb_);

            return dzzzzzzzzzzzzc_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12OrthogonalDate, CqlDate FollowupVR12OrthogonalDate)?> bzzzzzzzzzzzzh_ = context.Operators.Where<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12OrthogonalDate, CqlDate FollowupVR12OrthogonalDate)?>(bzzzzzzzzzzzzf_, bzzzzzzzzzzzzg_);
        Encounter bzzzzzzzzzzzzi_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12OrthogonalDate, CqlDate FollowupVR12OrthogonalDate)? tuple_fansvmjaedmvsdoyrozxdlsai) =>
            tuple_fansvmjaedmvsdoyrozxdlsai?.ValidEncounters;
        IEnumerable<Encounter> bzzzzzzzzzzzzj_ = context.Operators.Select<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12OrthogonalDate, CqlDate FollowupVR12OrthogonalDate)?, Encounter>(bzzzzzzzzzzzzh_, bzzzzzzzzzzzzi_);
        IEnumerable<Encounter> bzzzzzzzzzzzzk_ = context.Operators.Distinct<Encounter>(bzzzzzzzzzzzzj_);
        bool? bzzzzzzzzzzzzl_ = context.Operators.Exists<Encounter>(bzzzzzzzzzzzzk_);

        return bzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Date VR36 Oblique Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_VR36_Oblique_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode dzzzzzzzzzzzzd_ = this.VR_36_Mental_component_summary__MCS__score___oblique_method_T_score(context);
        IEnumerable<CqlCode> dzzzzzzzzzzzze_ = context.Operators.ToList<CqlCode>(dzzzzzzzzzzzzd_);
        IEnumerable<Observation> dzzzzzzzzzzzzf_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, dzzzzzzzzzzzze_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> dzzzzzzzzzzzzg_ = Status_1_8_000.Instance.isAssessmentPerformed(context, dzzzzzzzzzzzzf_);
        CqlCode dzzzzzzzzzzzzh_ = this.VR_36_Physical_component_summary__PCS__score___oblique_method_T_score(context);
        IEnumerable<CqlCode> dzzzzzzzzzzzzi_ = context.Operators.ToList<CqlCode>(dzzzzzzzzzzzzh_);
        IEnumerable<Observation> dzzzzzzzzzzzzj_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, dzzzzzzzzzzzzi_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> dzzzzzzzzzzzzk_ = Status_1_8_000.Instance.isAssessmentPerformed(context, dzzzzzzzzzzzzj_);
        IEnumerable<ValueTuple<Observation, Observation>> dzzzzzzzzzzzzl_ = context.Operators.CrossJoin<Observation, Observation>(dzzzzzzzzzzzzg_, dzzzzzzzzzzzzk_);
        (CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)? dzzzzzzzzzzzzm_(ValueTuple<Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)? dzzzzzzzzzzzzt_ = (CqlTupleMetadata_DUcFTCLcQEWDGGQdFCWTHFaUK, _valueTuple.Item1, _valueTuple.Item2);

            return dzzzzzzzzzzzzt_;
        };
        IEnumerable<(CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?> dzzzzzzzzzzzzn_ = context.Operators.Select<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?>(dzzzzzzzzzzzzl_, dzzzzzzzzzzzzm_);
        bool? dzzzzzzzzzzzzo_((CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)? tuple_ducftclcqewdggqdfcwthfauk)
        {
            DataType dzzzzzzzzzzzzu_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36MentalAssessment?.Effective;
            object dzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> dzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.toInterval(context, dzzzzzzzzzzzzv_);
            CqlDateTime dzzzzzzzzzzzzx_ = context.Operators.Start(dzzzzzzzzzzzzw_);
            CqlDate dzzzzzzzzzzzzy_ = context.Operators.DateFrom(dzzzzzzzzzzzzx_);
            DataType dzzzzzzzzzzzzz_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36PhysicalAssessment?.Effective;
            object ezzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dzzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, ezzzzzzzzzzzza_);
            CqlDateTime ezzzzzzzzzzzzc_ = context.Operators.Start(ezzzzzzzzzzzzb_);
            CqlDate ezzzzzzzzzzzzd_ = context.Operators.DateFrom(ezzzzzzzzzzzzc_);
            bool? ezzzzzzzzzzzze_ = context.Operators.SameAs(dzzzzzzzzzzzzy_, ezzzzzzzzzzzzd_, "day");
            DataType ezzzzzzzzzzzzf_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36MentalAssessment?.Value;
            object ezzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzf_);
            bool? ezzzzzzzzzzzzh_ = context.Operators.Not((bool?)(ezzzzzzzzzzzzg_ is null));
            bool? ezzzzzzzzzzzzi_ = context.Operators.And(ezzzzzzzzzzzze_, ezzzzzzzzzzzzh_);
            DataType ezzzzzzzzzzzzj_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36PhysicalAssessment?.Value;
            object ezzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzj_);
            bool? ezzzzzzzzzzzzl_ = context.Operators.Not((bool?)(ezzzzzzzzzzzzk_ is null));
            bool? ezzzzzzzzzzzzm_ = context.Operators.And(ezzzzzzzzzzzzi_, ezzzzzzzzzzzzl_);

            return ezzzzzzzzzzzzm_;
        };
        IEnumerable<(CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?> dzzzzzzzzzzzzp_ = context.Operators.Where<(CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?>(dzzzzzzzzzzzzn_, dzzzzzzzzzzzzo_);
        CqlDate dzzzzzzzzzzzzq_((CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)? tuple_ducftclcqewdggqdfcwthfauk)
        {
            DataType ezzzzzzzzzzzzn_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36MentalAssessment?.Effective;
            object ezzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, ezzzzzzzzzzzzo_);
            CqlDateTime ezzzzzzzzzzzzq_ = context.Operators.Start(ezzzzzzzzzzzzp_);
            CqlDate ezzzzzzzzzzzzr_ = context.Operators.DateFrom(ezzzzzzzzzzzzq_);

            return ezzzzzzzzzzzzr_;
        };
        IEnumerable<CqlDate> dzzzzzzzzzzzzr_ = context.Operators.Select<(CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?, CqlDate>(dzzzzzzzzzzzzp_, dzzzzzzzzzzzzq_);
        IEnumerable<CqlDate> dzzzzzzzzzzzzs_ = context.Operators.Distinct<CqlDate>(dzzzzzzzzzzzzr_);

        return dzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Has Encounter with Initial and Follow Up VR36 Oblique Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_VR36_Oblique_Assessments(CqlContext context)
    {
        IEnumerable<Encounter> ezzzzzzzzzzzzs_ = this.Qualifying_Encounters(context);
        IEnumerable<CqlDate> ezzzzzzzzzzzzt_ = this.Date_VR36_Oblique_Total_Assessment_Completed(context);
        IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> ezzzzzzzzzzzzv_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(ezzzzzzzzzzzzs_, ezzzzzzzzzzzzt_, ezzzzzzzzzzzzt_);
        (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36ObliqueDate, CqlDate FollowupVR36ObliqueDate)? ezzzzzzzzzzzzw_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36ObliqueDate, CqlDate FollowupVR36ObliqueDate)? fzzzzzzzzzzzze_ = (CqlTupleMetadata_HQfcMfhQUSTNYMWSgJHiFeahQ, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return fzzzzzzzzzzzze_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36ObliqueDate, CqlDate FollowupVR36ObliqueDate)?> ezzzzzzzzzzzzx_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36ObliqueDate, CqlDate FollowupVR36ObliqueDate)?>(ezzzzzzzzzzzzv_, ezzzzzzzzzzzzw_);
        bool? ezzzzzzzzzzzzy_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36ObliqueDate, CqlDate FollowupVR36ObliqueDate)? tuple_elxicyhrdpyzpqyjphdifbiga)
        {
            Period fzzzzzzzzzzzzf_ = tuple_elxicyhrdpyzpqyjphdifbiga?.ValidEncounters?.Period;
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.toInterval(context, fzzzzzzzzzzzzg_ as object);
            CqlDateTime fzzzzzzzzzzzzi_ = context.Operators.End(fzzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzj_ = this.Measurement_Period(context);
            CqlDateTime fzzzzzzzzzzzzk_ = context.Operators.End(fzzzzzzzzzzzzj_);
            CqlQuantity fzzzzzzzzzzzzl_ = context.Operators.Quantity(180m, "days");
            CqlDateTime fzzzzzzzzzzzzm_ = context.Operators.Subtract(fzzzzzzzzzzzzk_, fzzzzzzzzzzzzl_);
            bool? fzzzzzzzzzzzzn_ = context.Operators.SameOrBefore(fzzzzzzzzzzzzi_, fzzzzzzzzzzzzm_, "day");
            CqlDateTime fzzzzzzzzzzzzo_ = context.Operators.ConvertDateToDateTime(tuple_elxicyhrdpyzpqyjphdifbiga?.InitialVR36ObliqueDate);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, fzzzzzzzzzzzzq_ as object);
            CqlDateTime fzzzzzzzzzzzzs_ = context.Operators.End(fzzzzzzzzzzzzr_);
            CqlQuantity fzzzzzzzzzzzzt_ = context.Operators.Quantity(14m, "days");
            CqlDateTime fzzzzzzzzzzzzu_ = context.Operators.Subtract(fzzzzzzzzzzzzs_, fzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.toInterval(context, fzzzzzzzzzzzzw_ as object);
            CqlDateTime fzzzzzzzzzzzzy_ = context.Operators.End(fzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> fzzzzzzzzzzzzz_ = context.Operators.Interval(fzzzzzzzzzzzzu_, fzzzzzzzzzzzzy_, true, true);
            bool? gzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(fzzzzzzzzzzzzo_, fzzzzzzzzzzzzz_, "day");
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fzzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.toInterval(context, gzzzzzzzzzzzzc_ as object);
            CqlDateTime gzzzzzzzzzzzze_ = context.Operators.End(gzzzzzzzzzzzzd_);
            bool? gzzzzzzzzzzzzf_ = context.Operators.Not((bool?)(gzzzzzzzzzzzze_ is null));
            bool? gzzzzzzzzzzzzg_ = context.Operators.And(gzzzzzzzzzzzza_, gzzzzzzzzzzzzf_);
            bool? gzzzzzzzzzzzzh_ = context.Operators.And(fzzzzzzzzzzzzn_, gzzzzzzzzzzzzg_);
            CqlDateTime gzzzzzzzzzzzzi_ = context.Operators.ConvertDateToDateTime(tuple_elxicyhrdpyzpqyjphdifbiga?.FollowupVR36ObliqueDate);
            CqlDate gzzzzzzzzzzzzj_ = context.Operators.DateFrom(gzzzzzzzzzzzzi_);
            CqlDate gzzzzzzzzzzzzl_ = context.Operators.DateFrom(fzzzzzzzzzzzzo_);
            CqlQuantity gzzzzzzzzzzzzm_ = context.Operators.Quantity(30m, "days");
            CqlDate gzzzzzzzzzzzzn_ = context.Operators.Add(gzzzzzzzzzzzzl_, gzzzzzzzzzzzzm_);
            CqlDate gzzzzzzzzzzzzp_ = context.Operators.DateFrom(fzzzzzzzzzzzzo_);
            CqlDate gzzzzzzzzzzzzr_ = context.Operators.Add(gzzzzzzzzzzzzp_, fzzzzzzzzzzzzl_);
            CqlInterval<CqlDate> gzzzzzzzzzzzzs_ = context.Operators.Interval(gzzzzzzzzzzzzn_, gzzzzzzzzzzzzr_, true, true);
            bool? gzzzzzzzzzzzzt_ = context.Operators.In<CqlDate>(gzzzzzzzzzzzzj_, gzzzzzzzzzzzzs_, "day");
            bool? gzzzzzzzzzzzzu_ = context.Operators.And(gzzzzzzzzzzzzh_, gzzzzzzzzzzzzt_);

            return gzzzzzzzzzzzzu_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36ObliqueDate, CqlDate FollowupVR36ObliqueDate)?> ezzzzzzzzzzzzz_ = context.Operators.Where<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36ObliqueDate, CqlDate FollowupVR36ObliqueDate)?>(ezzzzzzzzzzzzx_, ezzzzzzzzzzzzy_);
        Encounter fzzzzzzzzzzzza_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36ObliqueDate, CqlDate FollowupVR36ObliqueDate)? tuple_elxicyhrdpyzpqyjphdifbiga) =>
            tuple_elxicyhrdpyzpqyjphdifbiga?.ValidEncounters;
        IEnumerable<Encounter> fzzzzzzzzzzzzb_ = context.Operators.Select<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36ObliqueDate, CqlDate FollowupVR36ObliqueDate)?, Encounter>(ezzzzzzzzzzzzz_, fzzzzzzzzzzzza_);
        IEnumerable<Encounter> fzzzzzzzzzzzzc_ = context.Operators.Distinct<Encounter>(fzzzzzzzzzzzzb_);
        bool? fzzzzzzzzzzzzd_ = context.Operators.Exists<Encounter>(fzzzzzzzzzzzzc_);

        return fzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Date VR36 Orthogonal Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_VR36_Orthogonal_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode gzzzzzzzzzzzzv_ = this.VR_36_Mental_component_summary__MCS__score___orthogonal_method_T_score(context);
        IEnumerable<CqlCode> gzzzzzzzzzzzzw_ = context.Operators.ToList<CqlCode>(gzzzzzzzzzzzzv_);
        IEnumerable<Observation> gzzzzzzzzzzzzx_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, gzzzzzzzzzzzzw_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> gzzzzzzzzzzzzy_ = Status_1_8_000.Instance.isAssessmentPerformed(context, gzzzzzzzzzzzzx_);
        CqlCode gzzzzzzzzzzzzz_ = this.VR_36_Physical_component_summary__PCS__score___orthogonal_method_T_score(context);
        IEnumerable<CqlCode> hzzzzzzzzzzzza_ = context.Operators.ToList<CqlCode>(gzzzzzzzzzzzzz_);
        IEnumerable<Observation> hzzzzzzzzzzzzb_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, hzzzzzzzzzzzza_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> hzzzzzzzzzzzzc_ = Status_1_8_000.Instance.isAssessmentPerformed(context, hzzzzzzzzzzzzb_);
        IEnumerable<ValueTuple<Observation, Observation>> hzzzzzzzzzzzzd_ = context.Operators.CrossJoin<Observation, Observation>(gzzzzzzzzzzzzy_, hzzzzzzzzzzzzc_);
        (CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)? hzzzzzzzzzzzze_(ValueTuple<Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)? hzzzzzzzzzzzzl_ = (CqlTupleMetadata_DUcFTCLcQEWDGGQdFCWTHFaUK, _valueTuple.Item1, _valueTuple.Item2);

            return hzzzzzzzzzzzzl_;
        };
        IEnumerable<(CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?> hzzzzzzzzzzzzf_ = context.Operators.Select<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?>(hzzzzzzzzzzzzd_, hzzzzzzzzzzzze_);
        bool? hzzzzzzzzzzzzg_((CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)? tuple_ducftclcqewdggqdfcwthfauk)
        {
            DataType hzzzzzzzzzzzzm_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36MentalAssessment?.Effective;
            object hzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.toInterval(context, hzzzzzzzzzzzzn_);
            CqlDateTime hzzzzzzzzzzzzp_ = context.Operators.Start(hzzzzzzzzzzzzo_);
            CqlDate hzzzzzzzzzzzzq_ = context.Operators.DateFrom(hzzzzzzzzzzzzp_);
            DataType hzzzzzzzzzzzzr_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36PhysicalAssessment?.Effective;
            object hzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.toInterval(context, hzzzzzzzzzzzzs_);
            CqlDateTime hzzzzzzzzzzzzu_ = context.Operators.Start(hzzzzzzzzzzzzt_);
            CqlDate hzzzzzzzzzzzzv_ = context.Operators.DateFrom(hzzzzzzzzzzzzu_);
            bool? hzzzzzzzzzzzzw_ = context.Operators.SameAs(hzzzzzzzzzzzzq_, hzzzzzzzzzzzzv_, "day");
            DataType hzzzzzzzzzzzzx_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36MentalAssessment?.Value;
            object hzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzx_);
            bool? hzzzzzzzzzzzzz_ = context.Operators.Not((bool?)(hzzzzzzzzzzzzy_ is null));
            bool? izzzzzzzzzzzza_ = context.Operators.And(hzzzzzzzzzzzzw_, hzzzzzzzzzzzzz_);
            DataType izzzzzzzzzzzzb_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36PhysicalAssessment?.Value;
            object izzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzb_);
            bool? izzzzzzzzzzzzd_ = context.Operators.Not((bool?)(izzzzzzzzzzzzc_ is null));
            bool? izzzzzzzzzzzze_ = context.Operators.And(izzzzzzzzzzzza_, izzzzzzzzzzzzd_);

            return izzzzzzzzzzzze_;
        };
        IEnumerable<(CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?> hzzzzzzzzzzzzh_ = context.Operators.Where<(CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?>(hzzzzzzzzzzzzf_, hzzzzzzzzzzzzg_);
        CqlDate hzzzzzzzzzzzzi_((CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)? tuple_ducftclcqewdggqdfcwthfauk)
        {
            DataType izzzzzzzzzzzzf_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36MentalAssessment?.Effective;
            object izzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, izzzzzzzzzzzzf_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.toInterval(context, izzzzzzzzzzzzg_);
            CqlDateTime izzzzzzzzzzzzi_ = context.Operators.Start(izzzzzzzzzzzzh_);
            CqlDate izzzzzzzzzzzzj_ = context.Operators.DateFrom(izzzzzzzzzzzzi_);

            return izzzzzzzzzzzzj_;
        };
        IEnumerable<CqlDate> hzzzzzzzzzzzzj_ = context.Operators.Select<(CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?, CqlDate>(hzzzzzzzzzzzzh_, hzzzzzzzzzzzzi_);
        IEnumerable<CqlDate> hzzzzzzzzzzzzk_ = context.Operators.Distinct<CqlDate>(hzzzzzzzzzzzzj_);

        return hzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Has Encounter with Initial and Follow Up VR36 Orthogonal Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_VR36_Orthogonal_Assessments(CqlContext context)
    {
        IEnumerable<Encounter> izzzzzzzzzzzzk_ = this.Qualifying_Encounters(context);
        IEnumerable<CqlDate> izzzzzzzzzzzzl_ = this.Date_VR36_Orthogonal_Total_Assessment_Completed(context);
        IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> izzzzzzzzzzzzn_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(izzzzzzzzzzzzk_, izzzzzzzzzzzzl_, izzzzzzzzzzzzl_);
        (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36OrthogonalDate, CqlDate FollowupVR36OrthogonalDate)? izzzzzzzzzzzzo_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36OrthogonalDate, CqlDate FollowupVR36OrthogonalDate)? izzzzzzzzzzzzw_ = (CqlTupleMetadata_BFZHWdOOROjSjFSECHcQiaZZZ, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return izzzzzzzzzzzzw_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36OrthogonalDate, CqlDate FollowupVR36OrthogonalDate)?> izzzzzzzzzzzzp_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36OrthogonalDate, CqlDate FollowupVR36OrthogonalDate)?>(izzzzzzzzzzzzn_, izzzzzzzzzzzzo_);
        bool? izzzzzzzzzzzzq_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36OrthogonalDate, CqlDate FollowupVR36OrthogonalDate)? tuple_fucqujadjizabihdffformht)
        {
            Period izzzzzzzzzzzzx_ = tuple_fucqujadjizabihdffformht?.ValidEncounters?.Period;
            CqlInterval<CqlDateTime> izzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> izzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, izzzzzzzzzzzzy_ as object);
            CqlDateTime jzzzzzzzzzzzza_ = context.Operators.End(izzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzb_ = this.Measurement_Period(context);
            CqlDateTime jzzzzzzzzzzzzc_ = context.Operators.End(jzzzzzzzzzzzzb_);
            CqlQuantity jzzzzzzzzzzzzd_ = context.Operators.Quantity(180m, "days");
            CqlDateTime jzzzzzzzzzzzze_ = context.Operators.Subtract(jzzzzzzzzzzzzc_, jzzzzzzzzzzzzd_);
            bool? jzzzzzzzzzzzzf_ = context.Operators.SameOrBefore(jzzzzzzzzzzzza_, jzzzzzzzzzzzze_, "day");
            CqlDateTime jzzzzzzzzzzzzg_ = context.Operators.ConvertDateToDateTime(tuple_fucqujadjizabihdffformht?.InitialVR36OrthogonalDate);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.toInterval(context, jzzzzzzzzzzzzi_ as object);
            CqlDateTime jzzzzzzzzzzzzk_ = context.Operators.End(jzzzzzzzzzzzzj_);
            CqlQuantity jzzzzzzzzzzzzl_ = context.Operators.Quantity(14m, "days");
            CqlDateTime jzzzzzzzzzzzzm_ = context.Operators.Subtract(jzzzzzzzzzzzzk_, jzzzzzzzzzzzzl_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, jzzzzzzzzzzzzo_ as object);
            CqlDateTime jzzzzzzzzzzzzq_ = context.Operators.End(jzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzr_ = context.Operators.Interval(jzzzzzzzzzzzzm_, jzzzzzzzzzzzzq_, true, true);
            bool? jzzzzzzzzzzzzs_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzzzzg_, jzzzzzzzzzzzzr_, "day");
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> jzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, jzzzzzzzzzzzzu_ as object);
            CqlDateTime jzzzzzzzzzzzzw_ = context.Operators.End(jzzzzzzzzzzzzv_);
            bool? jzzzzzzzzzzzzx_ = context.Operators.Not((bool?)(jzzzzzzzzzzzzw_ is null));
            bool? jzzzzzzzzzzzzy_ = context.Operators.And(jzzzzzzzzzzzzs_, jzzzzzzzzzzzzx_);
            bool? jzzzzzzzzzzzzz_ = context.Operators.And(jzzzzzzzzzzzzf_, jzzzzzzzzzzzzy_);
            CqlDateTime kzzzzzzzzzzzza_ = context.Operators.ConvertDateToDateTime(tuple_fucqujadjizabihdffformht?.FollowupVR36OrthogonalDate);
            CqlDate kzzzzzzzzzzzzb_ = context.Operators.DateFrom(kzzzzzzzzzzzza_);
            CqlDate kzzzzzzzzzzzzd_ = context.Operators.DateFrom(jzzzzzzzzzzzzg_);
            CqlQuantity kzzzzzzzzzzzze_ = context.Operators.Quantity(30m, "days");
            CqlDate kzzzzzzzzzzzzf_ = context.Operators.Add(kzzzzzzzzzzzzd_, kzzzzzzzzzzzze_);
            CqlDate kzzzzzzzzzzzzh_ = context.Operators.DateFrom(jzzzzzzzzzzzzg_);
            CqlDate kzzzzzzzzzzzzj_ = context.Operators.Add(kzzzzzzzzzzzzh_, jzzzzzzzzzzzzd_);
            CqlInterval<CqlDate> kzzzzzzzzzzzzk_ = context.Operators.Interval(kzzzzzzzzzzzzf_, kzzzzzzzzzzzzj_, true, true);
            bool? kzzzzzzzzzzzzl_ = context.Operators.In<CqlDate>(kzzzzzzzzzzzzb_, kzzzzzzzzzzzzk_, "day");
            bool? kzzzzzzzzzzzzm_ = context.Operators.And(jzzzzzzzzzzzzz_, kzzzzzzzzzzzzl_);

            return kzzzzzzzzzzzzm_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36OrthogonalDate, CqlDate FollowupVR36OrthogonalDate)?> izzzzzzzzzzzzr_ = context.Operators.Where<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36OrthogonalDate, CqlDate FollowupVR36OrthogonalDate)?>(izzzzzzzzzzzzp_, izzzzzzzzzzzzq_);
        Encounter izzzzzzzzzzzzs_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36OrthogonalDate, CqlDate FollowupVR36OrthogonalDate)? tuple_fucqujadjizabihdffformht) =>
            tuple_fucqujadjizabihdffformht?.ValidEncounters;
        IEnumerable<Encounter> izzzzzzzzzzzzt_ = context.Operators.Select<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36OrthogonalDate, CqlDate FollowupVR36OrthogonalDate)?, Encounter>(izzzzzzzzzzzzr_, izzzzzzzzzzzzs_);
        IEnumerable<Encounter> izzzzzzzzzzzzu_ = context.Operators.Distinct<Encounter>(izzzzzzzzzzzzt_);
        bool? izzzzzzzzzzzzv_ = context.Operators.Exists<Encounter>(izzzzzzzzzzzzu_);

        return izzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Date MLHFQ Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_MLHFQ_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode kzzzzzzzzzzzzn_ = this.Physical_score__MLHFQ_(context);
        IEnumerable<CqlCode> kzzzzzzzzzzzzo_ = context.Operators.ToList<CqlCode>(kzzzzzzzzzzzzn_);
        IEnumerable<Observation> kzzzzzzzzzzzzp_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, kzzzzzzzzzzzzo_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> kzzzzzzzzzzzzq_ = Status_1_8_000.Instance.isAssessmentPerformed(context, kzzzzzzzzzzzzp_);
        CqlCode kzzzzzzzzzzzzr_ = this.Emotional_score__MLHFQ_(context);
        IEnumerable<CqlCode> kzzzzzzzzzzzzs_ = context.Operators.ToList<CqlCode>(kzzzzzzzzzzzzr_);
        IEnumerable<Observation> kzzzzzzzzzzzzt_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, kzzzzzzzzzzzzs_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> kzzzzzzzzzzzzu_ = Status_1_8_000.Instance.isAssessmentPerformed(context, kzzzzzzzzzzzzt_);
        IEnumerable<ValueTuple<Observation, Observation>> kzzzzzzzzzzzzv_ = context.Operators.CrossJoin<Observation, Observation>(kzzzzzzzzzzzzq_, kzzzzzzzzzzzzu_);
        (CqlTupleMetadata, Observation MLHFQPhysical, Observation MLHFQEmotional)? kzzzzzzzzzzzzw_(ValueTuple<Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation MLHFQPhysical, Observation MLHFQEmotional)? lzzzzzzzzzzzzd_ = (CqlTupleMetadata_EBLWeAeedHPAfOJXKPZJKSCUf, _valueTuple.Item1, _valueTuple.Item2);

            return lzzzzzzzzzzzzd_;
        };
        IEnumerable<(CqlTupleMetadata, Observation MLHFQPhysical, Observation MLHFQEmotional)?> kzzzzzzzzzzzzx_ = context.Operators.Select<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation MLHFQPhysical, Observation MLHFQEmotional)?>(kzzzzzzzzzzzzv_, kzzzzzzzzzzzzw_);
        bool? kzzzzzzzzzzzzy_((CqlTupleMetadata, Observation MLHFQPhysical, Observation MLHFQEmotional)? tuple_fnofxckadaeusjerhbdqfoshe)
        {
            DataType lzzzzzzzzzzzze_ = tuple_fnofxckadaeusjerhbdqfoshe?.MLHFQPhysical?.Effective;
            object lzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.toInterval(context, lzzzzzzzzzzzzf_);
            CqlDateTime lzzzzzzzzzzzzh_ = context.Operators.Start(lzzzzzzzzzzzzg_);
            CqlDate lzzzzzzzzzzzzi_ = context.Operators.DateFrom(lzzzzzzzzzzzzh_);
            DataType lzzzzzzzzzzzzj_ = tuple_fnofxckadaeusjerhbdqfoshe?.MLHFQEmotional?.Effective;
            object lzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, lzzzzzzzzzzzzk_);
            CqlDateTime lzzzzzzzzzzzzm_ = context.Operators.Start(lzzzzzzzzzzzzl_);
            CqlDate lzzzzzzzzzzzzn_ = context.Operators.DateFrom(lzzzzzzzzzzzzm_);
            bool? lzzzzzzzzzzzzo_ = context.Operators.SameAs(lzzzzzzzzzzzzi_, lzzzzzzzzzzzzn_, "day");
            DataType lzzzzzzzzzzzzp_ = tuple_fnofxckadaeusjerhbdqfoshe?.MLHFQPhysical?.Value;
            object lzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzp_);
            bool? lzzzzzzzzzzzzr_ = context.Operators.Not((bool?)(lzzzzzzzzzzzzq_ is null));
            bool? lzzzzzzzzzzzzs_ = context.Operators.And(lzzzzzzzzzzzzo_, lzzzzzzzzzzzzr_);
            DataType lzzzzzzzzzzzzt_ = tuple_fnofxckadaeusjerhbdqfoshe?.MLHFQEmotional?.Value;
            object lzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzt_);
            bool? lzzzzzzzzzzzzv_ = context.Operators.Not((bool?)(lzzzzzzzzzzzzu_ is null));
            bool? lzzzzzzzzzzzzw_ = context.Operators.And(lzzzzzzzzzzzzs_, lzzzzzzzzzzzzv_);

            return lzzzzzzzzzzzzw_;
        };
        IEnumerable<(CqlTupleMetadata, Observation MLHFQPhysical, Observation MLHFQEmotional)?> kzzzzzzzzzzzzz_ = context.Operators.Where<(CqlTupleMetadata, Observation MLHFQPhysical, Observation MLHFQEmotional)?>(kzzzzzzzzzzzzx_, kzzzzzzzzzzzzy_);
        CqlDate lzzzzzzzzzzzza_((CqlTupleMetadata, Observation MLHFQPhysical, Observation MLHFQEmotional)? tuple_fnofxckadaeusjerhbdqfoshe)
        {
            DataType lzzzzzzzzzzzzx_ = tuple_fnofxckadaeusjerhbdqfoshe?.MLHFQPhysical?.Effective;
            object lzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> lzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, lzzzzzzzzzzzzy_);
            CqlDateTime mzzzzzzzzzzzza_ = context.Operators.Start(lzzzzzzzzzzzzz_);
            CqlDate mzzzzzzzzzzzzb_ = context.Operators.DateFrom(mzzzzzzzzzzzza_);

            return mzzzzzzzzzzzzb_;
        };
        IEnumerable<CqlDate> lzzzzzzzzzzzzb_ = context.Operators.Select<(CqlTupleMetadata, Observation MLHFQPhysical, Observation MLHFQEmotional)?, CqlDate>(kzzzzzzzzzzzzz_, lzzzzzzzzzzzza_);
        IEnumerable<CqlDate> lzzzzzzzzzzzzc_ = context.Operators.Distinct<CqlDate>(lzzzzzzzzzzzzb_);

        return lzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Has Encounter with Initial and Follow Up MLHFQ Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_MLHFQ_Assessments(CqlContext context)
    {
        IEnumerable<Encounter> mzzzzzzzzzzzzc_ = this.Qualifying_Encounters(context);
        IEnumerable<CqlDate> mzzzzzzzzzzzzd_ = this.Date_MLHFQ_Total_Assessment_Completed(context);
        IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> mzzzzzzzzzzzzf_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(mzzzzzzzzzzzzc_, mzzzzzzzzzzzzd_, mzzzzzzzzzzzzd_);
        (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialMLHFQDate, CqlDate FollowupMLHFQDate)? mzzzzzzzzzzzzg_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialMLHFQDate, CqlDate FollowupMLHFQDate)? mzzzzzzzzzzzzo_ = (CqlTupleMetadata_CcaWSNDiVeaLebVKKWWWiBcEU, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return mzzzzzzzzzzzzo_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialMLHFQDate, CqlDate FollowupMLHFQDate)?> mzzzzzzzzzzzzh_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialMLHFQDate, CqlDate FollowupMLHFQDate)?>(mzzzzzzzzzzzzf_, mzzzzzzzzzzzzg_);
        bool? mzzzzzzzzzzzzi_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialMLHFQDate, CqlDate FollowupMLHFQDate)? tuple_ncdawctnmbfmtibmihsfbaig)
        {
            Period mzzzzzzzzzzzzp_ = tuple_ncdawctnmbfmtibmihsfbaig?.ValidEncounters?.Period;
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, mzzzzzzzzzzzzq_ as object);
            CqlDateTime mzzzzzzzzzzzzs_ = context.Operators.End(mzzzzzzzzzzzzr_);
            CqlInterval<CqlDateTime> mzzzzzzzzzzzzt_ = this.Measurement_Period(context);
            CqlDateTime mzzzzzzzzzzzzu_ = context.Operators.End(mzzzzzzzzzzzzt_);
            CqlQuantity mzzzzzzzzzzzzv_ = context.Operators.Quantity(180m, "days");
            CqlDateTime mzzzzzzzzzzzzw_ = context.Operators.Subtract(mzzzzzzzzzzzzu_, mzzzzzzzzzzzzv_);
            bool? mzzzzzzzzzzzzx_ = context.Operators.SameOrBefore(mzzzzzzzzzzzzs_, mzzzzzzzzzzzzw_, "day");
            CqlDateTime mzzzzzzzzzzzzy_ = context.Operators.ConvertDateToDateTime(tuple_ncdawctnmbfmtibmihsfbaig?.InitialMLHFQDate);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzzzza_ as object);
            CqlDateTime nzzzzzzzzzzzzc_ = context.Operators.End(nzzzzzzzzzzzzb_);
            CqlQuantity nzzzzzzzzzzzzd_ = context.Operators.Quantity(14m, "days");
            CqlDateTime nzzzzzzzzzzzze_ = context.Operators.Subtract(nzzzzzzzzzzzzc_, nzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzzzzg_ as object);
            CqlDateTime nzzzzzzzzzzzzi_ = context.Operators.End(nzzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzj_ = context.Operators.Interval(nzzzzzzzzzzzze_, nzzzzzzzzzzzzi_, true, true);
            bool? nzzzzzzzzzzzzk_ = context.Operators.In<CqlDateTime>(mzzzzzzzzzzzzy_, nzzzzzzzzzzzzj_, "day");
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzzzzm_ as object);
            CqlDateTime nzzzzzzzzzzzzo_ = context.Operators.End(nzzzzzzzzzzzzn_);
            bool? nzzzzzzzzzzzzp_ = context.Operators.Not((bool?)(nzzzzzzzzzzzzo_ is null));
            bool? nzzzzzzzzzzzzq_ = context.Operators.And(nzzzzzzzzzzzzk_, nzzzzzzzzzzzzp_);
            bool? nzzzzzzzzzzzzr_ = context.Operators.And(mzzzzzzzzzzzzx_, nzzzzzzzzzzzzq_);
            CqlDateTime nzzzzzzzzzzzzs_ = context.Operators.ConvertDateToDateTime(tuple_ncdawctnmbfmtibmihsfbaig?.FollowupMLHFQDate);
            CqlDate nzzzzzzzzzzzzt_ = context.Operators.DateFrom(nzzzzzzzzzzzzs_);
            CqlDate nzzzzzzzzzzzzv_ = context.Operators.DateFrom(mzzzzzzzzzzzzy_);
            CqlQuantity nzzzzzzzzzzzzw_ = context.Operators.Quantity(30m, "days");
            CqlDate nzzzzzzzzzzzzx_ = context.Operators.Add(nzzzzzzzzzzzzv_, nzzzzzzzzzzzzw_);
            CqlDate nzzzzzzzzzzzzz_ = context.Operators.DateFrom(mzzzzzzzzzzzzy_);
            CqlDate ozzzzzzzzzzzzb_ = context.Operators.Add(nzzzzzzzzzzzzz_, mzzzzzzzzzzzzv_);
            CqlInterval<CqlDate> ozzzzzzzzzzzzc_ = context.Operators.Interval(nzzzzzzzzzzzzx_, ozzzzzzzzzzzzb_, true, true);
            bool? ozzzzzzzzzzzzd_ = context.Operators.In<CqlDate>(nzzzzzzzzzzzzt_, ozzzzzzzzzzzzc_, "day");
            bool? ozzzzzzzzzzzze_ = context.Operators.And(nzzzzzzzzzzzzr_, ozzzzzzzzzzzzd_);

            return ozzzzzzzzzzzze_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialMLHFQDate, CqlDate FollowupMLHFQDate)?> mzzzzzzzzzzzzj_ = context.Operators.Where<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialMLHFQDate, CqlDate FollowupMLHFQDate)?>(mzzzzzzzzzzzzh_, mzzzzzzzzzzzzi_);
        Encounter mzzzzzzzzzzzzk_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialMLHFQDate, CqlDate FollowupMLHFQDate)? tuple_ncdawctnmbfmtibmihsfbaig) =>
            tuple_ncdawctnmbfmtibmihsfbaig?.ValidEncounters;
        IEnumerable<Encounter> mzzzzzzzzzzzzl_ = context.Operators.Select<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialMLHFQDate, CqlDate FollowupMLHFQDate)?, Encounter>(mzzzzzzzzzzzzj_, mzzzzzzzzzzzzk_);
        IEnumerable<Encounter> mzzzzzzzzzzzzm_ = context.Operators.Distinct<Encounter>(mzzzzzzzzzzzzl_);
        bool? mzzzzzzzzzzzzn_ = context.Operators.Exists<Encounter>(mzzzzzzzzzzzzm_);

        return mzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Date KCCQ12 Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_KCCQ12_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode ozzzzzzzzzzzzf_ = this.Kansas_City_Cardiomyopathy_Questionnaire___12_item__KCCQ_12_(context);
        IEnumerable<CqlCode> ozzzzzzzzzzzzg_ = context.Operators.ToList<CqlCode>(ozzzzzzzzzzzzf_);
        IEnumerable<Observation> ozzzzzzzzzzzzh_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, ozzzzzzzzzzzzg_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> ozzzzzzzzzzzzi_ = Status_1_8_000.Instance.isAssessmentPerformed(context, ozzzzzzzzzzzzh_);
        CqlCode ozzzzzzzzzzzzj_ = this.Overall_summary_score__KCCQ_12_(context);
        IEnumerable<CqlCode> ozzzzzzzzzzzzk_ = context.Operators.ToList<CqlCode>(ozzzzzzzzzzzzj_);
        IEnumerable<Observation> ozzzzzzzzzzzzl_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, ozzzzzzzzzzzzk_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> ozzzzzzzzzzzzm_ = Status_1_8_000.Instance.isAssessmentPerformed(context, ozzzzzzzzzzzzl_);
        IEnumerable<ValueTuple<Observation, Observation>> ozzzzzzzzzzzzn_ = context.Operators.CrossJoin<Observation, Observation>(ozzzzzzzzzzzzi_, ozzzzzzzzzzzzm_);
        (CqlTupleMetadata, Observation KCCQ12Item, Observation KCCQ12Summary)? ozzzzzzzzzzzzo_(ValueTuple<Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation KCCQ12Item, Observation KCCQ12Summary)? ozzzzzzzzzzzzv_ = (CqlTupleMetadata_DFKXORghhYafccUSbQaMfNTDj, _valueTuple.Item1, _valueTuple.Item2);

            return ozzzzzzzzzzzzv_;
        };
        IEnumerable<(CqlTupleMetadata, Observation KCCQ12Item, Observation KCCQ12Summary)?> ozzzzzzzzzzzzp_ = context.Operators.Select<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation KCCQ12Item, Observation KCCQ12Summary)?>(ozzzzzzzzzzzzn_, ozzzzzzzzzzzzo_);
        bool? ozzzzzzzzzzzzq_((CqlTupleMetadata, Observation KCCQ12Item, Observation KCCQ12Summary)? tuple_dfkxorghhyafccusbqamfntdj)
        {
            DataType ozzzzzzzzzzzzw_ = tuple_dfkxorghhyafccusbqamfntdj?.KCCQ12Item?.Effective;
            object ozzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ozzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzzy_ = QICoreCommon_2_1_000.Instance.toInterval(context, ozzzzzzzzzzzzx_);
            CqlDateTime ozzzzzzzzzzzzz_ = context.Operators.Start(ozzzzzzzzzzzzy_);
            CqlDate pzzzzzzzzzzzza_ = context.Operators.DateFrom(ozzzzzzzzzzzzz_);
            DataType pzzzzzzzzzzzzb_ = tuple_dfkxorghhyafccusbqamfntdj?.KCCQ12Summary?.Effective;
            object pzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.toInterval(context, pzzzzzzzzzzzzc_);
            CqlDateTime pzzzzzzzzzzzze_ = context.Operators.Start(pzzzzzzzzzzzzd_);
            CqlDate pzzzzzzzzzzzzf_ = context.Operators.DateFrom(pzzzzzzzzzzzze_);
            bool? pzzzzzzzzzzzzg_ = context.Operators.SameAs(pzzzzzzzzzzzza_, pzzzzzzzzzzzzf_, "day");
            DataType pzzzzzzzzzzzzh_ = tuple_dfkxorghhyafccusbqamfntdj?.KCCQ12Item?.Value;
            object pzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzh_);
            bool? pzzzzzzzzzzzzj_ = context.Operators.Not((bool?)(pzzzzzzzzzzzzi_ is null));
            bool? pzzzzzzzzzzzzk_ = context.Operators.And(pzzzzzzzzzzzzg_, pzzzzzzzzzzzzj_);
            DataType pzzzzzzzzzzzzl_ = tuple_dfkxorghhyafccusbqamfntdj?.KCCQ12Summary?.Value;
            object pzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzl_);
            bool? pzzzzzzzzzzzzn_ = context.Operators.Not((bool?)(pzzzzzzzzzzzzm_ is null));
            bool? pzzzzzzzzzzzzo_ = context.Operators.And(pzzzzzzzzzzzzk_, pzzzzzzzzzzzzn_);

            return pzzzzzzzzzzzzo_;
        };
        IEnumerable<(CqlTupleMetadata, Observation KCCQ12Item, Observation KCCQ12Summary)?> ozzzzzzzzzzzzr_ = context.Operators.Where<(CqlTupleMetadata, Observation KCCQ12Item, Observation KCCQ12Summary)?>(ozzzzzzzzzzzzp_, ozzzzzzzzzzzzq_);
        CqlDate ozzzzzzzzzzzzs_((CqlTupleMetadata, Observation KCCQ12Item, Observation KCCQ12Summary)? tuple_dfkxorghhyafccusbqamfntdj)
        {
            DataType pzzzzzzzzzzzzp_ = tuple_dfkxorghhyafccusbqamfntdj?.KCCQ12Item?.Effective;
            object pzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, pzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> pzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, pzzzzzzzzzzzzq_);
            CqlDateTime pzzzzzzzzzzzzs_ = context.Operators.Start(pzzzzzzzzzzzzr_);
            CqlDate pzzzzzzzzzzzzt_ = context.Operators.DateFrom(pzzzzzzzzzzzzs_);

            return pzzzzzzzzzzzzt_;
        };
        IEnumerable<CqlDate> ozzzzzzzzzzzzt_ = context.Operators.Select<(CqlTupleMetadata, Observation KCCQ12Item, Observation KCCQ12Summary)?, CqlDate>(ozzzzzzzzzzzzr_, ozzzzzzzzzzzzs_);
        IEnumerable<CqlDate> ozzzzzzzzzzzzu_ = context.Operators.Distinct<CqlDate>(ozzzzzzzzzzzzt_);

        return ozzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Has Encounter with Initial and Follow Up KCCQ12 Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_KCCQ12_Assessments(CqlContext context)
    {
        IEnumerable<Encounter> pzzzzzzzzzzzzu_ = this.Qualifying_Encounters(context);
        IEnumerable<CqlDate> pzzzzzzzzzzzzv_ = this.Date_KCCQ12_Total_Assessment_Completed(context);
        IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> pzzzzzzzzzzzzx_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(pzzzzzzzzzzzzu_, pzzzzzzzzzzzzv_, pzzzzzzzzzzzzv_);
        (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQ12Date, CqlDate FollowupKCCQ12Date)? pzzzzzzzzzzzzy_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQ12Date, CqlDate FollowupKCCQ12Date)? qzzzzzzzzzzzzg_ = (CqlTupleMetadata_EQQLFFBVIbLIQLiZDNfeYdMU, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return qzzzzzzzzzzzzg_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQ12Date, CqlDate FollowupKCCQ12Date)?> pzzzzzzzzzzzzz_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQ12Date, CqlDate FollowupKCCQ12Date)?>(pzzzzzzzzzzzzx_, pzzzzzzzzzzzzy_);
        bool? qzzzzzzzzzzzza_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQ12Date, CqlDate FollowupKCCQ12Date)? tuple_eoahgtwwdfqijhcjzqnvidvuo)
        {
            Period qzzzzzzzzzzzzh_ = tuple_eoahgtwwdfqijhcjzqnvidvuo?.ValidEncounters?.Period;
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.toInterval(context, qzzzzzzzzzzzzi_ as object);
            CqlDateTime qzzzzzzzzzzzzk_ = context.Operators.End(qzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzl_ = this.Measurement_Period(context);
            CqlDateTime qzzzzzzzzzzzzm_ = context.Operators.End(qzzzzzzzzzzzzl_);
            CqlQuantity qzzzzzzzzzzzzn_ = context.Operators.Quantity(180m, "days");
            CqlDateTime qzzzzzzzzzzzzo_ = context.Operators.Subtract(qzzzzzzzzzzzzm_, qzzzzzzzzzzzzn_);
            bool? qzzzzzzzzzzzzp_ = context.Operators.SameOrBefore(qzzzzzzzzzzzzk_, qzzzzzzzzzzzzo_, "day");
            CqlDateTime qzzzzzzzzzzzzq_ = context.Operators.ConvertDateToDateTime(tuple_eoahgtwwdfqijhcjzqnvidvuo?.InitialKCCQ12Date);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.toInterval(context, qzzzzzzzzzzzzs_ as object);
            CqlDateTime qzzzzzzzzzzzzu_ = context.Operators.End(qzzzzzzzzzzzzt_);
            CqlQuantity qzzzzzzzzzzzzv_ = context.Operators.Quantity(14m, "days");
            CqlDateTime qzzzzzzzzzzzzw_ = context.Operators.Subtract(qzzzzzzzzzzzzu_, qzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> qzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, qzzzzzzzzzzzzy_ as object);
            CqlDateTime rzzzzzzzzzzzza_ = context.Operators.End(qzzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzb_ = context.Operators.Interval(qzzzzzzzzzzzzw_, rzzzzzzzzzzzza_, true, true);
            bool? rzzzzzzzzzzzzc_ = context.Operators.In<CqlDateTime>(qzzzzzzzzzzzzq_, rzzzzzzzzzzzzb_, "day");
            CqlInterval<CqlDateTime> rzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qzzzzzzzzzzzzh_);
            CqlInterval<CqlDateTime> rzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, rzzzzzzzzzzzze_ as object);
            CqlDateTime rzzzzzzzzzzzzg_ = context.Operators.End(rzzzzzzzzzzzzf_);
            bool? rzzzzzzzzzzzzh_ = context.Operators.Not((bool?)(rzzzzzzzzzzzzg_ is null));
            bool? rzzzzzzzzzzzzi_ = context.Operators.And(rzzzzzzzzzzzzc_, rzzzzzzzzzzzzh_);
            bool? rzzzzzzzzzzzzj_ = context.Operators.And(qzzzzzzzzzzzzp_, rzzzzzzzzzzzzi_);
            CqlDateTime rzzzzzzzzzzzzk_ = context.Operators.ConvertDateToDateTime(tuple_eoahgtwwdfqijhcjzqnvidvuo?.FollowupKCCQ12Date);
            CqlDate rzzzzzzzzzzzzl_ = context.Operators.DateFrom(rzzzzzzzzzzzzk_);
            CqlDate rzzzzzzzzzzzzn_ = context.Operators.DateFrom(qzzzzzzzzzzzzq_);
            CqlQuantity rzzzzzzzzzzzzo_ = context.Operators.Quantity(30m, "days");
            CqlDate rzzzzzzzzzzzzp_ = context.Operators.Add(rzzzzzzzzzzzzn_, rzzzzzzzzzzzzo_);
            CqlDate rzzzzzzzzzzzzr_ = context.Operators.DateFrom(qzzzzzzzzzzzzq_);
            CqlDate rzzzzzzzzzzzzt_ = context.Operators.Add(rzzzzzzzzzzzzr_, qzzzzzzzzzzzzn_);
            CqlInterval<CqlDate> rzzzzzzzzzzzzu_ = context.Operators.Interval(rzzzzzzzzzzzzp_, rzzzzzzzzzzzzt_, true, true);
            bool? rzzzzzzzzzzzzv_ = context.Operators.In<CqlDate>(rzzzzzzzzzzzzl_, rzzzzzzzzzzzzu_, "day");
            bool? rzzzzzzzzzzzzw_ = context.Operators.And(rzzzzzzzzzzzzj_, rzzzzzzzzzzzzv_);

            return rzzzzzzzzzzzzw_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQ12Date, CqlDate FollowupKCCQ12Date)?> qzzzzzzzzzzzzb_ = context.Operators.Where<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQ12Date, CqlDate FollowupKCCQ12Date)?>(pzzzzzzzzzzzzz_, qzzzzzzzzzzzza_);
        Encounter qzzzzzzzzzzzzc_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQ12Date, CqlDate FollowupKCCQ12Date)? tuple_eoahgtwwdfqijhcjzqnvidvuo) =>
            tuple_eoahgtwwdfqijhcjzqnvidvuo?.ValidEncounters;
        IEnumerable<Encounter> qzzzzzzzzzzzzd_ = context.Operators.Select<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQ12Date, CqlDate FollowupKCCQ12Date)?, Encounter>(qzzzzzzzzzzzzb_, qzzzzzzzzzzzzc_);
        IEnumerable<Encounter> qzzzzzzzzzzzze_ = context.Operators.Distinct<Encounter>(qzzzzzzzzzzzzd_);
        bool? qzzzzzzzzzzzzf_ = context.Operators.Exists<Encounter>(qzzzzzzzzzzzze_);

        return qzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Date KCCQ Domain Assessment Completed")]
    public IEnumerable<CqlDate> Date_KCCQ_Domain_Assessment_Completed(CqlContext context)
    {
        CqlCode rzzzzzzzzzzzzx_ = this.Quality_of_life_score__KCCQ_(context);
        IEnumerable<CqlCode> rzzzzzzzzzzzzy_ = context.Operators.ToList<CqlCode>(rzzzzzzzzzzzzx_);
        IEnumerable<Observation> rzzzzzzzzzzzzz_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, rzzzzzzzzzzzzy_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> szzzzzzzzzzzza_ = Status_1_8_000.Instance.isAssessmentPerformed(context, rzzzzzzzzzzzzz_);
        CqlCode szzzzzzzzzzzzb_ = this.Symptom_stability_score__KCCQ_(context);
        IEnumerable<CqlCode> szzzzzzzzzzzzc_ = context.Operators.ToList<CqlCode>(szzzzzzzzzzzzb_);
        IEnumerable<Observation> szzzzzzzzzzzzd_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, szzzzzzzzzzzzc_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> szzzzzzzzzzzze_ = Status_1_8_000.Instance.isAssessmentPerformed(context, szzzzzzzzzzzzd_);
        CqlCode szzzzzzzzzzzzf_ = this.Self_efficacy_score__KCCQ_(context);
        IEnumerable<CqlCode> szzzzzzzzzzzzg_ = context.Operators.ToList<CqlCode>(szzzzzzzzzzzzf_);
        IEnumerable<Observation> szzzzzzzzzzzzh_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, szzzzzzzzzzzzg_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> szzzzzzzzzzzzi_ = Status_1_8_000.Instance.isAssessmentPerformed(context, szzzzzzzzzzzzh_);
        CqlCode szzzzzzzzzzzzj_ = this.Total_symptom_score__KCCQ_(context);
        IEnumerable<CqlCode> szzzzzzzzzzzzk_ = context.Operators.ToList<CqlCode>(szzzzzzzzzzzzj_);
        IEnumerable<Observation> szzzzzzzzzzzzl_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, szzzzzzzzzzzzk_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> szzzzzzzzzzzzm_ = Status_1_8_000.Instance.isAssessmentPerformed(context, szzzzzzzzzzzzl_);
        CqlCode szzzzzzzzzzzzn_ = this.Physical_limitation_score__KCCQ_(context);
        IEnumerable<CqlCode> szzzzzzzzzzzzo_ = context.Operators.ToList<CqlCode>(szzzzzzzzzzzzn_);
        IEnumerable<Observation> szzzzzzzzzzzzp_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, szzzzzzzzzzzzo_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> szzzzzzzzzzzzq_ = Status_1_8_000.Instance.isAssessmentPerformed(context, szzzzzzzzzzzzp_);
        CqlCode szzzzzzzzzzzzr_ = this.Social_limitation_score__KCCQ_(context);
        IEnumerable<CqlCode> szzzzzzzzzzzzs_ = context.Operators.ToList<CqlCode>(szzzzzzzzzzzzr_);
        IEnumerable<Observation> szzzzzzzzzzzzt_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, szzzzzzzzzzzzs_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> szzzzzzzzzzzzu_ = Status_1_8_000.Instance.isAssessmentPerformed(context, szzzzzzzzzzzzt_);
        IEnumerable<ValueTuple<Observation, Observation, Observation, Observation, Observation, Observation>> szzzzzzzzzzzzv_ = context.Operators.CrossJoin<Observation, Observation, Observation, Observation, Observation, Observation>(szzzzzzzzzzzza_, szzzzzzzzzzzze_, szzzzzzzzzzzzi_, szzzzzzzzzzzzm_, szzzzzzzzzzzzq_, szzzzzzzzzzzzu_);
        (CqlTupleMetadata, Observation KCCQLifeQuality, Observation KCCQSymptomStability, Observation KCCQSelfEfficacy, Observation KCCQSymptoms, Observation KCCQPhysicalLimits, Observation KCCQSocialLimits)? szzzzzzzzzzzzw_(ValueTuple<Observation, Observation, Observation, Observation, Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation KCCQLifeQuality, Observation KCCQSymptomStability, Observation KCCQSelfEfficacy, Observation KCCQSymptoms, Observation KCCQPhysicalLimits, Observation KCCQSocialLimits)? tzzzzzzzzzzzzd_ = (CqlTupleMetadata_BbPMcXSJeOeGdRcaZWGYPhGBL, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3, _valueTuple.Item4, _valueTuple.Item5, _valueTuple.Item6);

            return tzzzzzzzzzzzzd_;
        };
        IEnumerable<(CqlTupleMetadata, Observation KCCQLifeQuality, Observation KCCQSymptomStability, Observation KCCQSelfEfficacy, Observation KCCQSymptoms, Observation KCCQPhysicalLimits, Observation KCCQSocialLimits)?> szzzzzzzzzzzzx_ = context.Operators.Select<ValueTuple<Observation, Observation, Observation, Observation, Observation, Observation>, (CqlTupleMetadata, Observation KCCQLifeQuality, Observation KCCQSymptomStability, Observation KCCQSelfEfficacy, Observation KCCQSymptoms, Observation KCCQPhysicalLimits, Observation KCCQSocialLimits)?>(szzzzzzzzzzzzv_, szzzzzzzzzzzzw_);
        bool? szzzzzzzzzzzzy_((CqlTupleMetadata, Observation KCCQLifeQuality, Observation KCCQSymptomStability, Observation KCCQSelfEfficacy, Observation KCCQSymptoms, Observation KCCQPhysicalLimits, Observation KCCQSocialLimits)? tuple_etfcawdpmcqfbnayqdmdqqsdn)
        {
            DataType tzzzzzzzzzzzze_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQLifeQuality?.Effective;
            object tzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.toInterval(context, tzzzzzzzzzzzzf_);
            CqlDateTime tzzzzzzzzzzzzh_ = context.Operators.Start(tzzzzzzzzzzzzg_);
            CqlDate tzzzzzzzzzzzzi_ = context.Operators.DateFrom(tzzzzzzzzzzzzh_);
            DataType tzzzzzzzzzzzzj_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQSymptomStability?.Effective;
            object tzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, tzzzzzzzzzzzzk_);
            CqlDateTime tzzzzzzzzzzzzm_ = context.Operators.Start(tzzzzzzzzzzzzl_);
            CqlDate tzzzzzzzzzzzzn_ = context.Operators.DateFrom(tzzzzzzzzzzzzm_);
            bool? tzzzzzzzzzzzzo_ = context.Operators.SameAs(tzzzzzzzzzzzzi_, tzzzzzzzzzzzzn_, "day");
            DataType tzzzzzzzzzzzzp_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQSymptomStability?.Value;
            object tzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzp_);
            bool? tzzzzzzzzzzzzr_ = context.Operators.Not((bool?)(tzzzzzzzzzzzzq_ is null));
            bool? tzzzzzzzzzzzzs_ = context.Operators.And(tzzzzzzzzzzzzo_, tzzzzzzzzzzzzr_);
            object tzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> tzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, tzzzzzzzzzzzzu_);
            CqlDateTime tzzzzzzzzzzzzw_ = context.Operators.Start(tzzzzzzzzzzzzv_);
            CqlDate tzzzzzzzzzzzzx_ = context.Operators.DateFrom(tzzzzzzzzzzzzw_);
            DataType tzzzzzzzzzzzzy_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQSelfEfficacy?.Effective;
            object tzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzzy_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, tzzzzzzzzzzzzz_);
            CqlDateTime uzzzzzzzzzzzzb_ = context.Operators.Start(uzzzzzzzzzzzza_);
            CqlDate uzzzzzzzzzzzzc_ = context.Operators.DateFrom(uzzzzzzzzzzzzb_);
            bool? uzzzzzzzzzzzzd_ = context.Operators.SameAs(tzzzzzzzzzzzzx_, uzzzzzzzzzzzzc_, "day");
            bool? uzzzzzzzzzzzze_ = context.Operators.And(tzzzzzzzzzzzzs_, uzzzzzzzzzzzzd_);
            DataType uzzzzzzzzzzzzf_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQSelfEfficacy?.Value;
            object uzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzf_);
            bool? uzzzzzzzzzzzzh_ = context.Operators.Not((bool?)(uzzzzzzzzzzzzg_ is null));
            bool? uzzzzzzzzzzzzi_ = context.Operators.And(uzzzzzzzzzzzze_, uzzzzzzzzzzzzh_);
            object uzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, uzzzzzzzzzzzzk_);
            CqlDateTime uzzzzzzzzzzzzm_ = context.Operators.Start(uzzzzzzzzzzzzl_);
            CqlDate uzzzzzzzzzzzzn_ = context.Operators.DateFrom(uzzzzzzzzzzzzm_);
            DataType uzzzzzzzzzzzzo_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQSymptoms?.Effective;
            object uzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzo_);
            CqlInterval<CqlDateTime> uzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.toInterval(context, uzzzzzzzzzzzzp_);
            CqlDateTime uzzzzzzzzzzzzr_ = context.Operators.Start(uzzzzzzzzzzzzq_);
            CqlDate uzzzzzzzzzzzzs_ = context.Operators.DateFrom(uzzzzzzzzzzzzr_);
            bool? uzzzzzzzzzzzzt_ = context.Operators.SameAs(uzzzzzzzzzzzzn_, uzzzzzzzzzzzzs_, "day");
            bool? uzzzzzzzzzzzzu_ = context.Operators.And(uzzzzzzzzzzzzi_, uzzzzzzzzzzzzt_);
            DataType uzzzzzzzzzzzzv_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQSymptoms?.Value;
            object uzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzzv_);
            bool? uzzzzzzzzzzzzx_ = context.Operators.Not((bool?)(uzzzzzzzzzzzzw_ is null));
            bool? uzzzzzzzzzzzzy_ = context.Operators.And(uzzzzzzzzzzzzu_, uzzzzzzzzzzzzx_);
            object vzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.toInterval(context, vzzzzzzzzzzzza_);
            CqlDateTime vzzzzzzzzzzzzc_ = context.Operators.Start(vzzzzzzzzzzzzb_);
            CqlDate vzzzzzzzzzzzzd_ = context.Operators.DateFrom(vzzzzzzzzzzzzc_);
            DataType vzzzzzzzzzzzze_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQPhysicalLimits?.Effective;
            object vzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.toInterval(context, vzzzzzzzzzzzzf_);
            CqlDateTime vzzzzzzzzzzzzh_ = context.Operators.Start(vzzzzzzzzzzzzg_);
            CqlDate vzzzzzzzzzzzzi_ = context.Operators.DateFrom(vzzzzzzzzzzzzh_);
            bool? vzzzzzzzzzzzzj_ = context.Operators.SameAs(vzzzzzzzzzzzzd_, vzzzzzzzzzzzzi_, "day");
            bool? vzzzzzzzzzzzzk_ = context.Operators.And(uzzzzzzzzzzzzy_, vzzzzzzzzzzzzj_);
            DataType vzzzzzzzzzzzzl_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQPhysicalLimits?.Value;
            object vzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzl_);
            bool? vzzzzzzzzzzzzn_ = context.Operators.Not((bool?)(vzzzzzzzzzzzzm_ is null));
            bool? vzzzzzzzzzzzzo_ = context.Operators.And(vzzzzzzzzzzzzk_, vzzzzzzzzzzzzn_);
            object vzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, tzzzzzzzzzzzze_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzr_ = QICoreCommon_2_1_000.Instance.toInterval(context, vzzzzzzzzzzzzq_);
            CqlDateTime vzzzzzzzzzzzzs_ = context.Operators.Start(vzzzzzzzzzzzzr_);
            CqlDate vzzzzzzzzzzzzt_ = context.Operators.DateFrom(vzzzzzzzzzzzzs_);
            DataType vzzzzzzzzzzzzu_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQSocialLimits?.Effective;
            object vzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, vzzzzzzzzzzzzu_);
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.toInterval(context, vzzzzzzzzzzzzv_);
            CqlDateTime vzzzzzzzzzzzzx_ = context.Operators.Start(vzzzzzzzzzzzzw_);
            CqlDate vzzzzzzzzzzzzy_ = context.Operators.DateFrom(vzzzzzzzzzzzzx_);
            bool? vzzzzzzzzzzzzz_ = context.Operators.SameAs(vzzzzzzzzzzzzt_, vzzzzzzzzzzzzy_, "day");
            bool? wzzzzzzzzzzzza_ = context.Operators.And(vzzzzzzzzzzzzo_, vzzzzzzzzzzzzz_);
            DataType wzzzzzzzzzzzzb_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQSocialLimits?.Value;
            object wzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzb_);
            bool? wzzzzzzzzzzzzd_ = context.Operators.Not((bool?)(wzzzzzzzzzzzzc_ is null));
            bool? wzzzzzzzzzzzze_ = context.Operators.And(wzzzzzzzzzzzza_, wzzzzzzzzzzzzd_);
            DataType wzzzzzzzzzzzzf_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQLifeQuality?.Value;
            object wzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzf_);
            bool? wzzzzzzzzzzzzh_ = context.Operators.Not((bool?)(wzzzzzzzzzzzzg_ is null));
            bool? wzzzzzzzzzzzzi_ = context.Operators.And(wzzzzzzzzzzzze_, wzzzzzzzzzzzzh_);

            return wzzzzzzzzzzzzi_;
        };
        IEnumerable<(CqlTupleMetadata, Observation KCCQLifeQuality, Observation KCCQSymptomStability, Observation KCCQSelfEfficacy, Observation KCCQSymptoms, Observation KCCQPhysicalLimits, Observation KCCQSocialLimits)?> szzzzzzzzzzzzz_ = context.Operators.Where<(CqlTupleMetadata, Observation KCCQLifeQuality, Observation KCCQSymptomStability, Observation KCCQSelfEfficacy, Observation KCCQSymptoms, Observation KCCQPhysicalLimits, Observation KCCQSocialLimits)?>(szzzzzzzzzzzzx_, szzzzzzzzzzzzy_);
        CqlDate tzzzzzzzzzzzza_((CqlTupleMetadata, Observation KCCQLifeQuality, Observation KCCQSymptomStability, Observation KCCQSelfEfficacy, Observation KCCQSymptoms, Observation KCCQPhysicalLimits, Observation KCCQSocialLimits)? tuple_etfcawdpmcqfbnayqdmdqqsdn)
        {
            DataType wzzzzzzzzzzzzj_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQLifeQuality?.Effective;
            object wzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, wzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> wzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.toInterval(context, wzzzzzzzzzzzzk_);
            CqlDateTime wzzzzzzzzzzzzm_ = context.Operators.Start(wzzzzzzzzzzzzl_);
            CqlDate wzzzzzzzzzzzzn_ = context.Operators.DateFrom(wzzzzzzzzzzzzm_);

            return wzzzzzzzzzzzzn_;
        };
        IEnumerable<CqlDate> tzzzzzzzzzzzzb_ = context.Operators.Select<(CqlTupleMetadata, Observation KCCQLifeQuality, Observation KCCQSymptomStability, Observation KCCQSelfEfficacy, Observation KCCQSymptoms, Observation KCCQPhysicalLimits, Observation KCCQSocialLimits)?, CqlDate>(szzzzzzzzzzzzz_, tzzzzzzzzzzzza_);
        IEnumerable<CqlDate> tzzzzzzzzzzzzc_ = context.Operators.Distinct<CqlDate>(tzzzzzzzzzzzzb_);

        return tzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Has Encounter with Initial and Follow Up KCCQ Domain Score Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_KCCQ_Domain_Score_Assessments(CqlContext context)
    {
        IEnumerable<Encounter> wzzzzzzzzzzzzo_ = this.Qualifying_Encounters(context);
        IEnumerable<CqlDate> wzzzzzzzzzzzzp_ = this.Date_KCCQ_Domain_Assessment_Completed(context);
        IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> wzzzzzzzzzzzzr_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(wzzzzzzzzzzzzo_, wzzzzzzzzzzzzp_, wzzzzzzzzzzzzp_);
        (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQAssessmentDate, CqlDate FollowupKCCQAssessmentDate)? wzzzzzzzzzzzzs_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQAssessmentDate, CqlDate FollowupKCCQAssessmentDate)? xzzzzzzzzzzzza_ = (CqlTupleMetadata_HEFWLcHhCNCOQegEOfjWTXiGN, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return xzzzzzzzzzzzza_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQAssessmentDate, CqlDate FollowupKCCQAssessmentDate)?> wzzzzzzzzzzzzt_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQAssessmentDate, CqlDate FollowupKCCQAssessmentDate)?>(wzzzzzzzzzzzzr_, wzzzzzzzzzzzzs_);
        bool? wzzzzzzzzzzzzu_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQAssessmentDate, CqlDate FollowupKCCQAssessmentDate)? tuple_hrluhbcfcsvnvrrnjajahdcea)
        {
            Period xzzzzzzzzzzzzb_ = tuple_hrluhbcfcsvnvrrnjajahdcea?.ValidEncounters?.Period;
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzd_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzzzzc_ as object);
            CqlDateTime xzzzzzzzzzzzze_ = context.Operators.End(xzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzf_ = this.Measurement_Period(context);
            CqlDateTime xzzzzzzzzzzzzg_ = context.Operators.End(xzzzzzzzzzzzzf_);
            CqlQuantity xzzzzzzzzzzzzh_ = context.Operators.Quantity(180m, "days");
            CqlDateTime xzzzzzzzzzzzzi_ = context.Operators.Subtract(xzzzzzzzzzzzzg_, xzzzzzzzzzzzzh_);
            bool? xzzzzzzzzzzzzj_ = context.Operators.SameOrBefore(xzzzzzzzzzzzze_, xzzzzzzzzzzzzi_, "day");
            CqlDateTime xzzzzzzzzzzzzk_ = context.Operators.ConvertDateToDateTime(tuple_hrluhbcfcsvnvrrnjajahdcea?.InitialKCCQAssessmentDate);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzzzzm_ as object);
            CqlDateTime xzzzzzzzzzzzzo_ = context.Operators.End(xzzzzzzzzzzzzn_);
            CqlQuantity xzzzzzzzzzzzzp_ = context.Operators.Quantity(14m, "days");
            CqlDateTime xzzzzzzzzzzzzq_ = context.Operators.Subtract(xzzzzzzzzzzzzo_, xzzzzzzzzzzzzp_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzzzzs_ as object);
            CqlDateTime xzzzzzzzzzzzzu_ = context.Operators.End(xzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzv_ = context.Operators.Interval(xzzzzzzzzzzzzq_, xzzzzzzzzzzzzu_, true, true);
            bool? xzzzzzzzzzzzzw_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzzzzk_, xzzzzzzzzzzzzv_, "day");
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, xzzzzzzzzzzzzy_ as object);
            CqlDateTime yzzzzzzzzzzzza_ = context.Operators.End(xzzzzzzzzzzzzz_);
            bool? yzzzzzzzzzzzzb_ = context.Operators.Not((bool?)(yzzzzzzzzzzzza_ is null));
            bool? yzzzzzzzzzzzzc_ = context.Operators.And(xzzzzzzzzzzzzw_, yzzzzzzzzzzzzb_);
            bool? yzzzzzzzzzzzzd_ = context.Operators.And(xzzzzzzzzzzzzj_, yzzzzzzzzzzzzc_);
            CqlDateTime yzzzzzzzzzzzze_ = context.Operators.ConvertDateToDateTime(tuple_hrluhbcfcsvnvrrnjajahdcea?.FollowupKCCQAssessmentDate);
            CqlDate yzzzzzzzzzzzzf_ = context.Operators.DateFrom(yzzzzzzzzzzzze_);
            CqlDate yzzzzzzzzzzzzh_ = context.Operators.DateFrom(xzzzzzzzzzzzzk_);
            CqlQuantity yzzzzzzzzzzzzi_ = context.Operators.Quantity(30m, "days");
            CqlDate yzzzzzzzzzzzzj_ = context.Operators.Add(yzzzzzzzzzzzzh_, yzzzzzzzzzzzzi_);
            CqlDate yzzzzzzzzzzzzl_ = context.Operators.DateFrom(xzzzzzzzzzzzzk_);
            CqlDate yzzzzzzzzzzzzn_ = context.Operators.Add(yzzzzzzzzzzzzl_, xzzzzzzzzzzzzh_);
            CqlInterval<CqlDate> yzzzzzzzzzzzzo_ = context.Operators.Interval(yzzzzzzzzzzzzj_, yzzzzzzzzzzzzn_, true, true);
            bool? yzzzzzzzzzzzzp_ = context.Operators.In<CqlDate>(yzzzzzzzzzzzzf_, yzzzzzzzzzzzzo_, "day");
            bool? yzzzzzzzzzzzzq_ = context.Operators.And(yzzzzzzzzzzzzd_, yzzzzzzzzzzzzp_);

            return yzzzzzzzzzzzzq_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQAssessmentDate, CqlDate FollowupKCCQAssessmentDate)?> wzzzzzzzzzzzzv_ = context.Operators.Where<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQAssessmentDate, CqlDate FollowupKCCQAssessmentDate)?>(wzzzzzzzzzzzzt_, wzzzzzzzzzzzzu_);
        Encounter wzzzzzzzzzzzzw_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQAssessmentDate, CqlDate FollowupKCCQAssessmentDate)? tuple_hrluhbcfcsvnvrrnjajahdcea) =>
            tuple_hrluhbcfcsvnvrrnjajahdcea?.ValidEncounters;
        IEnumerable<Encounter> wzzzzzzzzzzzzx_ = context.Operators.Select<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQAssessmentDate, CqlDate FollowupKCCQAssessmentDate)?, Encounter>(wzzzzzzzzzzzzv_, wzzzzzzzzzzzzw_);
        IEnumerable<Encounter> wzzzzzzzzzzzzy_ = context.Operators.Distinct<Encounter>(wzzzzzzzzzzzzx_);
        bool? wzzzzzzzzzzzzz_ = context.Operators.Exists<Encounter>(wzzzzzzzzzzzzy_);

        return wzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Date KCCQ Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_KCCQ_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode yzzzzzzzzzzzzr_ = this.Overall_summary_score__KCCQ_(context);
        IEnumerable<CqlCode> yzzzzzzzzzzzzs_ = context.Operators.ToList<CqlCode>(yzzzzzzzzzzzzr_);
        IEnumerable<Observation> yzzzzzzzzzzzzt_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, yzzzzzzzzzzzzs_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> yzzzzzzzzzzzzu_ = Status_1_8_000.Instance.isAssessmentPerformed(context, yzzzzzzzzzzzzt_);
        bool? yzzzzzzzzzzzzv_(Observation KCCQSummaryScore)
        {
            DataType zzzzzzzzzzzzza_ = KCCQSummaryScore?.Value;
            object zzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzza_);
            bool? zzzzzzzzzzzzzc_ = context.Operators.Not((bool?)(zzzzzzzzzzzzzb_ is null));

            return zzzzzzzzzzzzzc_;
        };
        IEnumerable<Observation> yzzzzzzzzzzzzw_ = context.Operators.Where<Observation>(yzzzzzzzzzzzzu_, yzzzzzzzzzzzzv_);
        CqlDate yzzzzzzzzzzzzx_(Observation KCCQSummaryScore)
        {
            DataType zzzzzzzzzzzzzd_ = KCCQSummaryScore?.Effective;
            object zzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, zzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, zzzzzzzzzzzzze_);
            CqlDateTime zzzzzzzzzzzzzg_ = context.Operators.Start(zzzzzzzzzzzzzf_);
            CqlDate zzzzzzzzzzzzzh_ = context.Operators.DateFrom(zzzzzzzzzzzzzg_);

            return zzzzzzzzzzzzzh_;
        };
        IEnumerable<CqlDate> yzzzzzzzzzzzzy_ = context.Operators.Select<Observation, CqlDate>(yzzzzzzzzzzzzw_, yzzzzzzzzzzzzx_);
        IEnumerable<CqlDate> yzzzzzzzzzzzzz_ = context.Operators.Distinct<CqlDate>(yzzzzzzzzzzzzy_);

        return yzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Has Encounter with Initial and Follow Up KCCQ Total Score Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_KCCQ_Total_Score_Assessments(CqlContext context)
    {
        IEnumerable<Encounter> zzzzzzzzzzzzzi_ = this.Qualifying_Encounters(context);
        IEnumerable<CqlDate> zzzzzzzzzzzzzj_ = this.Date_KCCQ_Total_Assessment_Completed(context);
        IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> zzzzzzzzzzzzzl_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(zzzzzzzzzzzzzi_, zzzzzzzzzzzzzj_, zzzzzzzzzzzzzj_);
        (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQTotalScore, CqlDate FollowupKCCQTotalScore)? zzzzzzzzzzzzzm_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQTotalScore, CqlDate FollowupKCCQTotalScore)? zzzzzzzzzzzzzu_ = (CqlTupleMetadata_DggZKjEbQUfLADMDMBeASLDR, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return zzzzzzzzzzzzzu_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQTotalScore, CqlDate FollowupKCCQTotalScore)?> zzzzzzzzzzzzzn_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQTotalScore, CqlDate FollowupKCCQTotalScore)?>(zzzzzzzzzzzzzl_, zzzzzzzzzzzzzm_);
        bool? zzzzzzzzzzzzzo_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQTotalScore, CqlDate FollowupKCCQTotalScore)? tuple_dgrojeekdvizsvyisepdjhjgj)
        {
            Period zzzzzzzzzzzzzv_ = tuple_dgrojeekdvizsvyisepdjhjgj?.ValidEncounters?.Period;
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzx_ = QICoreCommon_2_1_000.Instance.toInterval(context, zzzzzzzzzzzzzw_ as object);
            CqlDateTime zzzzzzzzzzzzzy_ = context.Operators.End(zzzzzzzzzzzzzx_);
            CqlInterval<CqlDateTime> zzzzzzzzzzzzzz_ = this.Measurement_Period(context);
            CqlDateTime azzzzzzzzzzzzza_ = context.Operators.End(zzzzzzzzzzzzzz_);
            CqlQuantity azzzzzzzzzzzzzb_ = context.Operators.Quantity(180m, "days");
            CqlDateTime azzzzzzzzzzzzzc_ = context.Operators.Subtract(azzzzzzzzzzzzza_, azzzzzzzzzzzzzb_);
            bool? azzzzzzzzzzzzzd_ = context.Operators.SameOrBefore(zzzzzzzzzzzzzy_, azzzzzzzzzzzzzc_, "day");
            CqlDateTime azzzzzzzzzzzzze_ = context.Operators.ConvertDateToDateTime(tuple_dgrojeekdvizsvyisepdjhjgj?.InitialKCCQTotalScore);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzh_ = QICoreCommon_2_1_000.Instance.toInterval(context, azzzzzzzzzzzzzg_ as object);
            CqlDateTime azzzzzzzzzzzzzi_ = context.Operators.End(azzzzzzzzzzzzzh_);
            CqlQuantity azzzzzzzzzzzzzj_ = context.Operators.Quantity(14m, "days");
            CqlDateTime azzzzzzzzzzzzzk_ = context.Operators.Subtract(azzzzzzzzzzzzzi_, azzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzn_ = QICoreCommon_2_1_000.Instance.toInterval(context, azzzzzzzzzzzzzm_ as object);
            CqlDateTime azzzzzzzzzzzzzo_ = context.Operators.End(azzzzzzzzzzzzzn_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzp_ = context.Operators.Interval(azzzzzzzzzzzzzk_, azzzzzzzzzzzzzo_, true, true);
            bool? azzzzzzzzzzzzzq_ = context.Operators.In<CqlDateTime>(azzzzzzzzzzzzze_, azzzzzzzzzzzzzp_, "day");
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, zzzzzzzzzzzzzv_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.toInterval(context, azzzzzzzzzzzzzs_ as object);
            CqlDateTime azzzzzzzzzzzzzu_ = context.Operators.End(azzzzzzzzzzzzzt_);
            bool? azzzzzzzzzzzzzv_ = context.Operators.Not((bool?)(azzzzzzzzzzzzzu_ is null));
            bool? azzzzzzzzzzzzzw_ = context.Operators.And(azzzzzzzzzzzzzq_, azzzzzzzzzzzzzv_);
            bool? azzzzzzzzzzzzzx_ = context.Operators.And(azzzzzzzzzzzzzd_, azzzzzzzzzzzzzw_);
            CqlDateTime azzzzzzzzzzzzzy_ = context.Operators.ConvertDateToDateTime(tuple_dgrojeekdvizsvyisepdjhjgj?.FollowupKCCQTotalScore);
            CqlDate azzzzzzzzzzzzzz_ = context.Operators.DateFrom(azzzzzzzzzzzzzy_);
            CqlDate bzzzzzzzzzzzzzb_ = context.Operators.DateFrom(azzzzzzzzzzzzze_);
            CqlQuantity bzzzzzzzzzzzzzc_ = context.Operators.Quantity(30m, "days");
            CqlDate bzzzzzzzzzzzzzd_ = context.Operators.Add(bzzzzzzzzzzzzzb_, bzzzzzzzzzzzzzc_);
            CqlDate bzzzzzzzzzzzzzf_ = context.Operators.DateFrom(azzzzzzzzzzzzze_);
            CqlDate bzzzzzzzzzzzzzh_ = context.Operators.Add(bzzzzzzzzzzzzzf_, azzzzzzzzzzzzzb_);
            CqlInterval<CqlDate> bzzzzzzzzzzzzzi_ = context.Operators.Interval(bzzzzzzzzzzzzzd_, bzzzzzzzzzzzzzh_, true, true);
            bool? bzzzzzzzzzzzzzj_ = context.Operators.In<CqlDate>(azzzzzzzzzzzzzz_, bzzzzzzzzzzzzzi_, "day");
            bool? bzzzzzzzzzzzzzk_ = context.Operators.And(azzzzzzzzzzzzzx_, bzzzzzzzzzzzzzj_);

            return bzzzzzzzzzzzzzk_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQTotalScore, CqlDate FollowupKCCQTotalScore)?> zzzzzzzzzzzzzp_ = context.Operators.Where<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQTotalScore, CqlDate FollowupKCCQTotalScore)?>(zzzzzzzzzzzzzn_, zzzzzzzzzzzzzo_);
        Encounter zzzzzzzzzzzzzq_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQTotalScore, CqlDate FollowupKCCQTotalScore)? tuple_dgrojeekdvizsvyisepdjhjgj) =>
            tuple_dgrojeekdvizsvyisepdjhjgj?.ValidEncounters;
        IEnumerable<Encounter> zzzzzzzzzzzzzr_ = context.Operators.Select<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQTotalScore, CqlDate FollowupKCCQTotalScore)?, Encounter>(zzzzzzzzzzzzzp_, zzzzzzzzzzzzzq_);
        IEnumerable<Encounter> zzzzzzzzzzzzzs_ = context.Operators.Distinct<Encounter>(zzzzzzzzzzzzzr_);
        bool? zzzzzzzzzzzzzt_ = context.Operators.Exists<Encounter>(zzzzzzzzzzzzzs_);

        return zzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? bzzzzzzzzzzzzzl_ = this.Has_Encounter_with_Initial_and_Follow_Up_PROMIS10_Assessments(context);
        bool? bzzzzzzzzzzzzzm_ = this.Has_Encounter_with_Initial_and_Follow_Up_PROMIS29_Assessments(context);
        bool? bzzzzzzzzzzzzzn_ = context.Operators.Or(bzzzzzzzzzzzzzl_, bzzzzzzzzzzzzzm_);
        bool? bzzzzzzzzzzzzzo_ = this.Has_Encounter_with_Initial_and_Follow_Up_VR12_Oblique_Assessments(context);
        bool? bzzzzzzzzzzzzzp_ = context.Operators.Or(bzzzzzzzzzzzzzn_, bzzzzzzzzzzzzzo_);
        bool? bzzzzzzzzzzzzzq_ = this.Has_Encounter_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments(context);
        bool? bzzzzzzzzzzzzzr_ = context.Operators.Or(bzzzzzzzzzzzzzp_, bzzzzzzzzzzzzzq_);
        bool? bzzzzzzzzzzzzzs_ = this.Has_Encounter_with_Initial_and_Follow_Up_VR36_Oblique_Assessments(context);
        bool? bzzzzzzzzzzzzzt_ = context.Operators.Or(bzzzzzzzzzzzzzr_, bzzzzzzzzzzzzzs_);
        bool? bzzzzzzzzzzzzzu_ = this.Has_Encounter_with_Initial_and_Follow_Up_VR36_Orthogonal_Assessments(context);
        bool? bzzzzzzzzzzzzzv_ = context.Operators.Or(bzzzzzzzzzzzzzt_, bzzzzzzzzzzzzzu_);
        bool? bzzzzzzzzzzzzzw_ = this.Has_Encounter_with_Initial_and_Follow_Up_MLHFQ_Assessments(context);
        bool? bzzzzzzzzzzzzzx_ = context.Operators.Or(bzzzzzzzzzzzzzv_, bzzzzzzzzzzzzzw_);
        bool? bzzzzzzzzzzzzzy_ = this.Has_Encounter_with_Initial_and_Follow_Up_KCCQ12_Assessments(context);
        bool? bzzzzzzzzzzzzzz_ = context.Operators.Or(bzzzzzzzzzzzzzx_, bzzzzzzzzzzzzzy_);
        bool? czzzzzzzzzzzzza_ = this.Has_Encounter_with_Initial_and_Follow_Up_KCCQ_Domain_Score_Assessments(context);
        bool? czzzzzzzzzzzzzb_ = context.Operators.Or(bzzzzzzzzzzzzzz_, czzzzzzzzzzzzza_);
        bool? czzzzzzzzzzzzzc_ = this.Has_Encounter_with_Initial_and_Follow_Up_KCCQ_Total_Score_Assessments(context);
        bool? czzzzzzzzzzzzzd_ = context.Operators.Or(czzzzzzzzzzzzzb_, czzzzzzzzzzzzzc_);

        return czzzzzzzzzzzzzd_;
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
