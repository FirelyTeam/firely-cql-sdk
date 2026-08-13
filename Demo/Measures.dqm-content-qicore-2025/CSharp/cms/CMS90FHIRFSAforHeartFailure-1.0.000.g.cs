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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.2.2.0")]
[CqlLibrary("CMS90FHIRFSAforHeartFailure", "1.0.000")]
public partial class CMS90FHIRFSAforHeartFailure_1_0_000 : ILibrary, ISingleton<CMS90FHIRFSAforHeartFailure_1_0_000>
{
    #region ValueSets (4)

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

    #region Codes (29)

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

    #region CodeSystems (2)

    [CqlCodeSystemDefinition("LOINC", codeSystemId: "http://loinc.org", codeSystemVersion: null)]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, [
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
          _Total_symptom_score__KCCQ_,
          _VR_12_Mental_component_summary__MCS__score___oblique_method_T_score,
          _VR_12_Mental_component_summary__MCS__score___orthogonal_method_T_score,
          _VR_12_Physical_component_summary__PCS__score___oblique_method_T_score,
          _VR_12_Physical_component_summary__PCS__score___orthogonal_method_T_score,
          _VR_36_Mental_component_summary__MCS__score___oblique_method_T_score,
          _VR_36_Mental_component_summary__MCS__score___orthogonal_method_T_score,
          _VR_36_Physical_component_summary__PCS__score___oblique_method_T_score,
          _VR_36_Physical_component_summary__PCS__score___orthogonal_method_T_score]);

    [CqlCodeSystemDefinition("SNOMEDCT", codeSystemId: "http://snomed.info/sct", codeSystemVersion: null)]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Severe_cognitive_impairment__finding_]);

    #endregion CodeSystems

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = -650903179446011642L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("CMS90FHIRFSAforHeartFailure-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (31)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = -1669321019754182478L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = 84564949379321772L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = 8582605658905008518L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = 365259754375553276L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = -4531448496698277885L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Qualifying_Encounters, Qualifying_Encounters_Compute);

    private const long _cacheIndex_Qualifying_Encounters = 8160197854541943299L;

    private IEnumerable<Encounter> Qualifying_Encounters_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Office_Visit(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet c_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
        CqlValueSet f_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> h_ = context.Operators.Union<Encounter>(e_, g_);
        IEnumerable<Encounter> i_ = Status_1_15_000.Instance.isEncounterPerformed(context, h_);

        bool? j_(Encounter ValidEncounter) {
            CqlInterval<CqlDateTime> l_ = this.Measurement_Period(context);
            Period m_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, m_);
            bool? o_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(l_, n_, "day");
            return o_;
        }

        IEnumerable<Encounter> k_ = context.Operators.Where<Encounter>(i_, j_);
        return k_;
    }


    [CqlExpressionDefinition("Outpatient Encounters with at least one subsequent Outpatient Encounter during Measurement Period")]
    public IEnumerable<Encounter> Outpatient_Encounters_with_at_least_one_subsequent_Outpatient_Encounter_during_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Outpatient_Encounters_with_at_least_one_subsequent_Outpatient_Encounter_during_Measurement_Period, Outpatient_Encounters_with_at_least_one_subsequent_Outpatient_Encounter_during_Measurement_Period_Compute);

    private const long _cacheIndex_Outpatient_Encounters_with_at_least_one_subsequent_Outpatient_Encounter_during_Measurement_Period = 3299355288199571478L;

    private IEnumerable<Encounter> Outpatient_Encounters_with_at_least_one_subsequent_Outpatient_Encounter_during_Measurement_Period_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounters(context);

        bool? b_(Encounter OfficeVisit1) {
            IEnumerable<Encounter> d_ = this.Qualifying_Encounters(context);

            bool? e_(Encounter OfficeVisit2) {
                Period g_ = OfficeVisit2?.Period;
                CqlInterval<CqlDateTime> h_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, g_);
                CqlDateTime i_ = context.Operators.Start(h_);
                Period j_ = OfficeVisit1?.Period;
                CqlInterval<CqlDateTime> k_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, j_);
                CqlDateTime l_ = context.Operators.End(k_);
                CqlQuantity m_ = context.Operators.Quantity(1m, "day");
                CqlDateTime n_ = context.Operators.Add(l_, m_);
                bool? o_ = context.Operators.SameOrAfter(i_, n_, "day");
                return o_;
            }

            bool? f_ = context.Operators.WhereAny<Encounter>(d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = -5068561849240932665L;

    private bool? Initial_Population_Compute(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Date b_ = a_?.BirthDateElement;
        string c_ = b_?.Value;
        CqlDate d_ = context.Operators.ConvertStringToDate(c_);
        CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
        CqlDateTime f_ = context.Operators.Start(e_);
        CqlDate g_ = context.Operators.DateFrom(f_);
        int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
        bool? i_ = context.Operators.GreaterOrEqual(h_, 18);
        bool? j_;
        // CQL 'and' (67:3-72:5): right operand skipped when left is false
        if (i_ is false)
        {
            j_ = false;
        }
        else
        {
            CqlValueSet k_ = this.Heart_Failure(context);
            IEnumerable<Condition> l_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, k_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> m_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, k_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> n_ = context.Operators.Union<Condition>(l_ as IEnumerable<Condition>, m_ as IEnumerable<Condition>);
            IEnumerable<Condition> o_ = Status_1_15_000.Instance.verified(context, n_);

            bool? p_(Condition HeartFailure) {
                CqlInterval<CqlDateTime> r_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, HeartFailure);
                CqlInterval<CqlDateTime> s_ = this.Measurement_Period(context);
                bool? t_ = context.Operators.OverlapsBefore(r_, s_, "day");
                return t_;
            }

            bool? q_ = context.Operators.WhereAny<Condition>(o_, p_);
            j_ = i_ & q_;
        }
        // CQL 'and' (67:3-73:118): right operand skipped when left is false
        if (j_ is false)
        {
            return false;
        }
        else
        {
            IEnumerable<Encounter> u_ = this.Outpatient_Encounters_with_at_least_one_subsequent_Outpatient_Encounter_during_Measurement_Period(context);
            bool? v_ = context.Operators.Exists<Encounter>(u_);
            return j_ & v_;
        }
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = 6741930247475943811L;

    private bool? Denominator_Compute(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exclusions, Denominator_Exclusions_Compute);

    private const long _cacheIndex_Denominator_Exclusions = 4543796399844502819L;

    private bool? Denominator_Exclusions_Compute(CqlContext context)
    {
        bool? a_ = Hospice_6_18_000.Instance.Has_Hospice_Services(context);
        // CQL 'or' (79:3-84:5): right operand skipped when left is true
        if (a_ is true)
        {
            return true;
        }
        else
        {
            CqlCode b_ = this.Severe_cognitive_impairment__finding_(context);
            IEnumerable<CqlCode> c_ = context.Operators.ToList<CqlCode>(b_);
            IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, c_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> e_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, c_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> f_ = context.Operators.Union<Condition>(d_ as IEnumerable<Condition>, e_ as IEnumerable<Condition>);
            IEnumerable<Condition> g_ = Status_1_15_000.Instance.verified(context, f_);

            bool? h_(Condition SevereCognitiveImpairment) {
                CqlInterval<CqlDateTime> j_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, SevereCognitiveImpairment);
                CqlInterval<CqlDateTime> k_ = this.Measurement_Period(context);
                bool? l_ = context.Operators.Overlaps(j_, k_, "day");
                return l_;
            }

            bool? i_ = context.Operators.WhereAny<Condition>(g_, h_);
            return a_ | i_;
        }
    }


    [CqlExpressionDefinition("Date PROMIS10 Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_PROMIS10_Total_Assessment_Completed(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Date_PROMIS10_Total_Assessment_Completed, Date_PROMIS10_Total_Assessment_Completed_Compute);

    private const long _cacheIndex_Date_PROMIS10_Total_Assessment_Completed = 3566032284114220134L;

    private IEnumerable<CqlDate> Date_PROMIS10_Total_Assessment_Completed_Compute(CqlContext context)
    {
        CqlCode a_ = this.PROMIS_10_Global_Mental_Health__GMH__score_T_score(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
        IEnumerable<Observation> d_ = Status_1_15_000.Instance.isAssessmentPerformed(context, c_);
        CqlCode e_ = this.PROMIS_10_Global_Physical_Health__GPH__score_T_score(context);
        IEnumerable<CqlCode> f_ = context.Operators.ToList<CqlCode>(e_);
        IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, f_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
        IEnumerable<Observation> h_ = Status_1_15_000.Instance.isAssessmentPerformed(context, g_);
        IEnumerable<ValueTuple<Observation, Observation>> i_ = context.Operators.CrossJoin<Observation, Observation>(d_, h_);

        (CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)? j_(ValueTuple<Observation, Observation> _valueTuple) {
            (CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)? o_ = (CqlTupleMetadata_DDTAOdcFieSJbGgRLLZPYbGQb, _valueTuple.Item1, _valueTuple.Item2);
            return o_;
        }


        bool? k_((CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)? tuple_ddtaodcfiesjbggrllzpybgqb) {
            DataType p_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10MentalScore?.Effective;
            object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
            CqlInterval<CqlDateTime> r_ = QICoreCommon_4_0_000.Instance.toInterval(context, q_);
            CqlDateTime s_ = context.Operators.Start(r_);
            CqlDate t_ = context.Operators.DateFrom(s_);
            DataType u_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10PhysicalScore?.Effective;
            object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
            CqlInterval<CqlDateTime> w_ = QICoreCommon_4_0_000.Instance.toInterval(context, v_);
            CqlDateTime x_ = context.Operators.Start(w_);
            CqlDate y_ = context.Operators.DateFrom(x_);
            bool? z_ = context.Operators.SameAs(t_, y_, "day");
            bool? aa_;
            // CQL 'and' (128:11-129:85): right operand skipped when left is false
            if (z_ is false)
            {
                aa_ = false;
            }
            else
            {
                DataType ab_ = (tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10MentalScore as Observation)?.Value;
                object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                aa_ = z_ & (!((bool?)(ac_ is null)));
            }
            // CQL 'and' (128:5-130:87): right operand skipped when left is false
            if (aa_ is false)
            {
                return false;
            }
            else
            {
                DataType ad_ = (tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10PhysicalScore as Observation)?.Value;
                object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                return aa_ & (!((bool?)(ae_ is null)));
            }
        }

        IEnumerable<(CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?> l_ = context.Operators.SelectWhere<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?>(i_, j_, k_);

        CqlDate m_((CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)? tuple_ddtaodcfiesjbggrllzpybgqb) {
            DataType af_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10MentalScore?.Effective;
            object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
            CqlInterval<CqlDateTime> ah_ = QICoreCommon_4_0_000.Instance.toInterval(context, ag_);
            CqlDateTime ai_ = context.Operators.Start(ah_);
            CqlDate aj_ = context.Operators.DateFrom(ai_);
            return aj_;
        }

        IEnumerable<CqlDate> n_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?, CqlDate>(l_, m_);
        return n_;
    }


    [CqlExpressionDefinition("Has Encounter with Initial and Follow Up PROMIS10 Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_PROMIS10_Assessments(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Encounter_with_Initial_and_Follow_Up_PROMIS10_Assessments, Has_Encounter_with_Initial_and_Follow_Up_PROMIS10_Assessments_Compute);

    private const long _cacheIndex_Has_Encounter_with_Initial_and_Follow_Up_PROMIS10_Assessments = -7119418943023617715L;

    private bool? Has_Encounter_with_Initial_and_Follow_Up_PROMIS10_Assessments_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounters(context);
        IEnumerable<CqlDate> b_ = this.Date_PROMIS10_Total_Assessment_Completed(context);
        IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> c_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(a_, b_, b_);

        (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS10Date, CqlDate FollowupPROMIS10Date)? d_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple) {
            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS10Date, CqlDate FollowupPROMIS10Date)? j_ = (CqlTupleMetadata_BGYjYGLNPKWAZTBCVAdLDDTMj, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return j_;
        }


        bool? e_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS10Date, CqlDate FollowupPROMIS10Date)? tuple_dzhwgxhmbfavmzfaszbeksohj) {
            Period k_ = tuple_dzhwgxhmbfavmzfaszbeksohj?.ValidEncounters?.Period;
            CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
            CqlDateTime m_ = context.Operators.End(l_);
            CqlInterval<CqlDateTime> n_ = this.Measurement_Period(context);
            CqlDateTime o_ = context.Operators.End(n_);
            CqlQuantity p_ = context.Operators.Quantity(180m, "days");
            CqlDateTime q_ = context.Operators.Subtract(o_, p_);
            bool? r_ = context.Operators.SameOrBefore(m_, q_, "day");
            bool? s_;
            // CQL 'and' (116:13-117:97): right operand skipped when left is false
            if (r_ is false)
            {
                s_ = false;
            }
            else
            {
                CqlDateTime t_ = context.Operators.ConvertDateToDateTime(tuple_dzhwgxhmbfavmzfaszbeksohj?.InitialPROMIS10Date);
                Period u_ = tuple_dzhwgxhmbfavmzfaszbeksohj?.ValidEncounters?.Period;
                CqlInterval<CqlDateTime> v_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, u_);
                CqlDateTime w_ = context.Operators.End(v_);
                CqlQuantity x_ = context.Operators.Quantity(14m, "days");
                CqlDateTime y_ = context.Operators.Subtract(w_, x_);
                CqlInterval<CqlDateTime> z_ = context.Operators.Interval(y_, w_, true, true);
                bool? aa_ = context.Operators.In<CqlDateTime>(t_, z_, "day");
                bool? ab_;
                // CQL 'and' (117:13-117:97): right operand skipped when left is false
                if (aa_ is false)
                {
                    ab_ = false;
                }
                else
                {
                    Period ac_ = tuple_dzhwgxhmbfavmzfaszbeksohj?.ValidEncounters?.Period;
                    CqlInterval<CqlDateTime> ad_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ac_);
                    CqlDateTime ae_ = context.Operators.End(ad_);
                    ab_ = aa_ & (!((bool?)(ae_ is null)));
                }
                s_ = r_ & ab_;
            }
            // CQL 'and' (116:7-118:148): right operand skipped when left is false
            if (s_ is false)
            {
                return false;
            }
            else
            {
                CqlDateTime af_ = context.Operators.ConvertDateToDateTime(tuple_dzhwgxhmbfavmzfaszbeksohj?.FollowupPROMIS10Date);
                CqlDate ag_ = context.Operators.DateFrom(af_);
                CqlDateTime ah_ = context.Operators.ConvertDateToDateTime(tuple_dzhwgxhmbfavmzfaszbeksohj?.InitialPROMIS10Date);
                CqlDate ai_ = context.Operators.DateFrom(ah_);
                CqlQuantity aj_ = context.Operators.Quantity(30m, "days");
                CqlDate ak_ = context.Operators.Add(ai_, aj_);
                CqlQuantity al_ = context.Operators.Quantity(180m, "days");
                CqlDate am_ = context.Operators.Add(ai_, al_);
                CqlInterval<CqlDate> an_ = context.Operators.Interval(ak_, am_, true, true);
                bool? ao_ = context.Operators.In<CqlDate>(ag_, an_, "day");
                return s_ & ao_;
            }
        }

        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS10Date, CqlDate FollowupPROMIS10Date)?> f_ = context.Operators.SelectWhere<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS10Date, CqlDate FollowupPROMIS10Date)?>(c_, d_, e_);
        Encounter g_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS10Date, CqlDate FollowupPROMIS10Date)? tuple_dzhwgxhmbfavmzfaszbeksohj) => tuple_dzhwgxhmbfavmzfaszbeksohj?.ValidEncounters;
        IEnumerable<Encounter> h_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS10Date, CqlDate FollowupPROMIS10Date)?, Encounter>(f_, g_);
        bool? i_ = context.Operators.Exists<Encounter>(h_);
        return i_;
    }


    [CqlExpressionDefinition("Date PROMIS29 Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_PROMIS29_Total_Assessment_Completed(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Date_PROMIS29_Total_Assessment_Completed, Date_PROMIS29_Total_Assessment_Completed_Compute);

    private const long _cacheIndex_Date_PROMIS29_Total_Assessment_Completed = -7228807294603665886L;

    private IEnumerable<CqlDate> Date_PROMIS29_Total_Assessment_Completed_Compute(CqlContext context)
    {
        CqlCode a_ = this.PROMIS_29_Sleep_disturbance_score_T_score(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
        IEnumerable<Observation> d_ = Status_1_15_000.Instance.isAssessmentPerformed(context, c_);
        CqlCode e_ = this.PROMIS_29_Satisfaction_with_participation_in_social_roles_score_T_score(context);
        IEnumerable<CqlCode> f_ = context.Operators.ToList<CqlCode>(e_);
        IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, f_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
        IEnumerable<Observation> h_ = Status_1_15_000.Instance.isAssessmentPerformed(context, g_);
        CqlCode i_ = this.PROMIS_29_Physical_function_score_T_score(context);
        IEnumerable<CqlCode> j_ = context.Operators.ToList<CqlCode>(i_);
        IEnumerable<Observation> k_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, j_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
        IEnumerable<Observation> l_ = Status_1_15_000.Instance.isAssessmentPerformed(context, k_);
        CqlCode m_ = this.PROMIS_29_Pain_interference_score_T_score(context);
        IEnumerable<CqlCode> n_ = context.Operators.ToList<CqlCode>(m_);
        IEnumerable<Observation> o_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, n_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
        IEnumerable<Observation> p_ = Status_1_15_000.Instance.isAssessmentPerformed(context, o_);
        CqlCode q_ = this.PROMIS_29_Fatigue_score_T_score(context);
        IEnumerable<CqlCode> r_ = context.Operators.ToList<CqlCode>(q_);
        IEnumerable<Observation> s_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, r_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
        IEnumerable<Observation> t_ = Status_1_15_000.Instance.isAssessmentPerformed(context, s_);
        CqlCode u_ = this.PROMIS_29_Depression_score_T_score(context);
        IEnumerable<CqlCode> v_ = context.Operators.ToList<CqlCode>(u_);
        IEnumerable<Observation> w_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, v_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
        IEnumerable<Observation> x_ = Status_1_15_000.Instance.isAssessmentPerformed(context, w_);
        CqlCode y_ = this.PROMIS_29_Anxiety_score_T_score(context);
        IEnumerable<CqlCode> z_ = context.Operators.ToList<CqlCode>(y_);
        IEnumerable<Observation> aa_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, z_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
        IEnumerable<Observation> ab_ = Status_1_15_000.Instance.isAssessmentPerformed(context, aa_);
        IEnumerable<ValueTuple<Observation, Observation, Observation, Observation, Observation, Observation, Observation>> ac_ = context.Operators.CrossJoin<Observation, Observation, Observation, Observation, Observation, Observation, Observation>(d_, h_, l_, p_, t_, x_, ab_);

        (CqlTupleMetadata, Observation Promis29Sleep, Observation Promis29SocialRoles, Observation Promis29Physical, Observation Promis29Pain, Observation Promis29Fatigue, Observation Promis29Depression, Observation Promis29Anxiety)? ad_(ValueTuple<Observation, Observation, Observation, Observation, Observation, Observation, Observation> _valueTuple) {
            (CqlTupleMetadata, Observation Promis29Sleep, Observation Promis29SocialRoles, Observation Promis29Physical, Observation Promis29Pain, Observation Promis29Fatigue, Observation Promis29Depression, Observation Promis29Anxiety)? ai_ = (CqlTupleMetadata_DBUJFOVGBcbhIQPWARNQHKUaX, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3, _valueTuple.Item4, _valueTuple.Item5, _valueTuple.Item6, _valueTuple.Item7);
            return ai_;
        }


        bool? ae_((CqlTupleMetadata, Observation Promis29Sleep, Observation Promis29SocialRoles, Observation Promis29Physical, Observation Promis29Pain, Observation Promis29Fatigue, Observation Promis29Depression, Observation Promis29Anxiety)? tuple_cbgpsarvwrsewlglehinjanim) {
            DataType aj_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Sleep?.Effective;
            object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
            CqlInterval<CqlDateTime> al_ = QICoreCommon_4_0_000.Instance.toInterval(context, ak_);
            CqlDateTime am_ = context.Operators.Start(al_);
            CqlDate an_ = context.Operators.DateFrom(am_);
            DataType ao_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29SocialRoles?.Effective;
            object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
            CqlInterval<CqlDateTime> aq_ = QICoreCommon_4_0_000.Instance.toInterval(context, ap_);
            CqlDateTime ar_ = context.Operators.Start(aq_);
            CqlDate as_ = context.Operators.DateFrom(ar_);
            bool? at_ = context.Operators.SameAs(an_, as_, "day");
            bool? au_;
            // CQL 'and' (160:11-161:47): right operand skipped when left is false
            if (at_ is false)
            {
                au_ = false;
            }
            else
            {
                DataType bf_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29SocialRoles?.Value;
                object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                au_ = at_ & (!((bool?)(bg_ is null)));
            }
            bool? av_;
            // CQL 'and' (160:11-162:60): right operand skipped when left is false
            if (au_ is false)
            {
                av_ = false;
            }
            else
            {
                DataType bh_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Sleep?.Effective;
                object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                CqlInterval<CqlDateTime> bj_ = QICoreCommon_4_0_000.Instance.toInterval(context, bi_);
                CqlDateTime bk_ = context.Operators.Start(bj_);
                CqlDate bl_ = context.Operators.DateFrom(bk_);
                DataType bm_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Physical?.Effective;
                object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                CqlInterval<CqlDateTime> bo_ = QICoreCommon_4_0_000.Instance.toInterval(context, bn_);
                CqlDateTime bp_ = context.Operators.Start(bo_);
                CqlDate bq_ = context.Operators.DateFrom(bp_);
                bool? br_ = context.Operators.SameAs(bl_, bq_, "day");
                av_ = au_ & br_;
            }
            bool? aw_;
            // CQL 'and' (160:11-163:44): right operand skipped when left is false
            if (av_ is false)
            {
                aw_ = false;
            }
            else
            {
                DataType bs_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Physical?.Value;
                object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                aw_ = av_ & (!((bool?)(bt_ is null)));
            }
            bool? ax_;
            // CQL 'and' (160:11-164:56): right operand skipped when left is false
            if (aw_ is false)
            {
                ax_ = false;
            }
            else
            {
                DataType bu_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Sleep?.Effective;
                object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                CqlInterval<CqlDateTime> bw_ = QICoreCommon_4_0_000.Instance.toInterval(context, bv_);
                CqlDateTime bx_ = context.Operators.Start(bw_);
                CqlDate by_ = context.Operators.DateFrom(bx_);
                DataType bz_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Pain?.Effective;
                object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                CqlInterval<CqlDateTime> cb_ = QICoreCommon_4_0_000.Instance.toInterval(context, ca_);
                CqlDateTime cc_ = context.Operators.Start(cb_);
                CqlDate cd_ = context.Operators.DateFrom(cc_);
                bool? ce_ = context.Operators.SameAs(by_, cd_, "day");
                ax_ = aw_ & ce_;
            }
            bool? ay_;
            // CQL 'and' (160:11-165:40): right operand skipped when left is false
            if (ax_ is false)
            {
                ay_ = false;
            }
            else
            {
                DataType cf_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Pain?.Value;
                object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                ay_ = ax_ & (!((bool?)(cg_ is null)));
            }
            bool? az_;
            // CQL 'and' (160:11-166:59): right operand skipped when left is false
            if (ay_ is false)
            {
                az_ = false;
            }
            else
            {
                DataType ch_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Sleep?.Effective;
                object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                CqlInterval<CqlDateTime> cj_ = QICoreCommon_4_0_000.Instance.toInterval(context, ci_);
                CqlDateTime ck_ = context.Operators.Start(cj_);
                CqlDate cl_ = context.Operators.DateFrom(ck_);
                DataType cm_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Fatigue?.Effective;
                object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                CqlInterval<CqlDateTime> co_ = QICoreCommon_4_0_000.Instance.toInterval(context, cn_);
                CqlDateTime cp_ = context.Operators.Start(co_);
                CqlDate cq_ = context.Operators.DateFrom(cp_);
                bool? cr_ = context.Operators.SameAs(cl_, cq_, "day");
                az_ = ay_ & cr_;
            }
            bool? ba_;
            // CQL 'and' (160:11-167:43): right operand skipped when left is false
            if (az_ is false)
            {
                ba_ = false;
            }
            else
            {
                DataType cs_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Fatigue?.Value;
                object ct_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cs_);
                ba_ = az_ & (!((bool?)(ct_ is null)));
            }
            bool? bb_;
            // CQL 'and' (160:11-168:62): right operand skipped when left is false
            if (ba_ is false)
            {
                bb_ = false;
            }
            else
            {
                DataType cu_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Sleep?.Effective;
                object cv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cu_);
                CqlInterval<CqlDateTime> cw_ = QICoreCommon_4_0_000.Instance.toInterval(context, cv_);
                CqlDateTime cx_ = context.Operators.Start(cw_);
                CqlDate cy_ = context.Operators.DateFrom(cx_);
                DataType cz_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Depression?.Effective;
                object da_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cz_);
                CqlInterval<CqlDateTime> db_ = QICoreCommon_4_0_000.Instance.toInterval(context, da_);
                CqlDateTime dc_ = context.Operators.Start(db_);
                CqlDate dd_ = context.Operators.DateFrom(dc_);
                bool? de_ = context.Operators.SameAs(cy_, dd_, "day");
                bb_ = ba_ & de_;
            }
            bool? bc_;
            // CQL 'and' (160:11-169:46): right operand skipped when left is false
            if (bb_ is false)
            {
                bc_ = false;
            }
            else
            {
                DataType df_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Depression?.Value;
                object dg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, df_);
                bc_ = bb_ & (!((bool?)(dg_ is null)));
            }
            bool? bd_;
            // CQL 'and' (160:11-170:59): right operand skipped when left is false
            if (bc_ is false)
            {
                bd_ = false;
            }
            else
            {
                DataType dh_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Sleep?.Effective;
                object di_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dh_);
                CqlInterval<CqlDateTime> dj_ = QICoreCommon_4_0_000.Instance.toInterval(context, di_);
                CqlDateTime dk_ = context.Operators.Start(dj_);
                CqlDate dl_ = context.Operators.DateFrom(dk_);
                DataType dm_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Anxiety?.Effective;
                object dn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dm_);
                CqlInterval<CqlDateTime> do_ = QICoreCommon_4_0_000.Instance.toInterval(context, dn_);
                CqlDateTime dp_ = context.Operators.Start(do_);
                CqlDate dq_ = context.Operators.DateFrom(dp_);
                bool? dr_ = context.Operators.SameAs(dl_, dq_, "day");
                bd_ = bc_ & dr_;
            }
            bool? be_;
            // CQL 'and' (160:11-171:43): right operand skipped when left is false
            if (bd_ is false)
            {
                be_ = false;
            }
            else
            {
                DataType ds_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Anxiety?.Value;
                object dt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ds_);
                be_ = bd_ & (!((bool?)(dt_ is null)));
            }
            // CQL 'and' (160:5-172:41): right operand skipped when left is false
            if (be_ is false)
            {
                return false;
            }
            else
            {
                DataType du_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Sleep?.Value;
                object dv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, du_);
                return be_ & (!((bool?)(dv_ is null)));
            }
        }

        IEnumerable<(CqlTupleMetadata, Observation Promis29Sleep, Observation Promis29SocialRoles, Observation Promis29Physical, Observation Promis29Pain, Observation Promis29Fatigue, Observation Promis29Depression, Observation Promis29Anxiety)?> af_ = context.Operators.SelectWhere<ValueTuple<Observation, Observation, Observation, Observation, Observation, Observation, Observation>, (CqlTupleMetadata, Observation Promis29Sleep, Observation Promis29SocialRoles, Observation Promis29Physical, Observation Promis29Pain, Observation Promis29Fatigue, Observation Promis29Depression, Observation Promis29Anxiety)?>(ac_, ad_, ae_);

        CqlDate ag_((CqlTupleMetadata, Observation Promis29Sleep, Observation Promis29SocialRoles, Observation Promis29Physical, Observation Promis29Pain, Observation Promis29Fatigue, Observation Promis29Depression, Observation Promis29Anxiety)? tuple_cbgpsarvwrsewlglehinjanim) {
            DataType dw_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Sleep?.Effective;
            object dx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dw_);
            CqlInterval<CqlDateTime> dy_ = QICoreCommon_4_0_000.Instance.toInterval(context, dx_);
            CqlDateTime dz_ = context.Operators.Start(dy_);
            CqlDate ea_ = context.Operators.DateFrom(dz_);
            return ea_;
        }

        IEnumerable<CqlDate> ah_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Observation Promis29Sleep, Observation Promis29SocialRoles, Observation Promis29Physical, Observation Promis29Pain, Observation Promis29Fatigue, Observation Promis29Depression, Observation Promis29Anxiety)?, CqlDate>(af_, ag_);
        return ah_;
    }


    [CqlExpressionDefinition("Has Encounter with Initial and Follow Up PROMIS29 Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_PROMIS29_Assessments(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Encounter_with_Initial_and_Follow_Up_PROMIS29_Assessments, Has_Encounter_with_Initial_and_Follow_Up_PROMIS29_Assessments_Compute);

    private const long _cacheIndex_Has_Encounter_with_Initial_and_Follow_Up_PROMIS29_Assessments = -8148014470304297646L;

    private bool? Has_Encounter_with_Initial_and_Follow_Up_PROMIS29_Assessments_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounters(context);
        IEnumerable<CqlDate> b_ = this.Date_PROMIS29_Total_Assessment_Completed(context);
        IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> c_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(a_, b_, b_);

        (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS29Date, CqlDate FollowupPROMIS29Date)? d_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple) {
            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS29Date, CqlDate FollowupPROMIS29Date)? j_ = (CqlTupleMetadata_DSZKEYVbCINNIeAQiZdVaEJhG, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return j_;
        }


        bool? e_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS29Date, CqlDate FollowupPROMIS29Date)? tuple_kmpntxjuhkpbcwgftqigieao) {
            Period k_ = tuple_kmpntxjuhkpbcwgftqigieao?.ValidEncounters?.Period;
            CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
            CqlDateTime m_ = context.Operators.End(l_);
            CqlInterval<CqlDateTime> n_ = this.Measurement_Period(context);
            CqlDateTime o_ = context.Operators.End(n_);
            CqlQuantity p_ = context.Operators.Quantity(180m, "days");
            CqlDateTime q_ = context.Operators.Subtract(o_, p_);
            bool? r_ = context.Operators.SameOrBefore(m_, q_, "day");
            bool? s_;
            // CQL 'and' (138:13-139:97): right operand skipped when left is false
            if (r_ is false)
            {
                s_ = false;
            }
            else
            {
                CqlDateTime t_ = context.Operators.ConvertDateToDateTime(tuple_kmpntxjuhkpbcwgftqigieao?.InitialPROMIS29Date);
                Period u_ = tuple_kmpntxjuhkpbcwgftqigieao?.ValidEncounters?.Period;
                CqlInterval<CqlDateTime> v_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, u_);
                CqlDateTime w_ = context.Operators.End(v_);
                CqlQuantity x_ = context.Operators.Quantity(14m, "days");
                CqlDateTime y_ = context.Operators.Subtract(w_, x_);
                CqlInterval<CqlDateTime> z_ = context.Operators.Interval(y_, w_, true, true);
                bool? aa_ = context.Operators.In<CqlDateTime>(t_, z_, "day");
                bool? ab_;
                // CQL 'and' (139:13-139:97): right operand skipped when left is false
                if (aa_ is false)
                {
                    ab_ = false;
                }
                else
                {
                    Period ac_ = tuple_kmpntxjuhkpbcwgftqigieao?.ValidEncounters?.Period;
                    CqlInterval<CqlDateTime> ad_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ac_);
                    CqlDateTime ae_ = context.Operators.End(ad_);
                    ab_ = aa_ & (!((bool?)(ae_ is null)));
                }
                s_ = r_ & ab_;
            }
            // CQL 'and' (138:7-140:148): right operand skipped when left is false
            if (s_ is false)
            {
                return false;
            }
            else
            {
                CqlDateTime af_ = context.Operators.ConvertDateToDateTime(tuple_kmpntxjuhkpbcwgftqigieao?.FollowupPROMIS29Date);
                CqlDate ag_ = context.Operators.DateFrom(af_);
                CqlDateTime ah_ = context.Operators.ConvertDateToDateTime(tuple_kmpntxjuhkpbcwgftqigieao?.InitialPROMIS29Date);
                CqlDate ai_ = context.Operators.DateFrom(ah_);
                CqlQuantity aj_ = context.Operators.Quantity(30m, "days");
                CqlDate ak_ = context.Operators.Add(ai_, aj_);
                CqlQuantity al_ = context.Operators.Quantity(180m, "days");
                CqlDate am_ = context.Operators.Add(ai_, al_);
                CqlInterval<CqlDate> an_ = context.Operators.Interval(ak_, am_, true, true);
                bool? ao_ = context.Operators.In<CqlDate>(ag_, an_, "day");
                return s_ & ao_;
            }
        }

        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS29Date, CqlDate FollowupPROMIS29Date)?> f_ = context.Operators.SelectWhere<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS29Date, CqlDate FollowupPROMIS29Date)?>(c_, d_, e_);
        Encounter g_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS29Date, CqlDate FollowupPROMIS29Date)? tuple_kmpntxjuhkpbcwgftqigieao) => tuple_kmpntxjuhkpbcwgftqigieao?.ValidEncounters;
        IEnumerable<Encounter> h_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS29Date, CqlDate FollowupPROMIS29Date)?, Encounter>(f_, g_);
        bool? i_ = context.Operators.Exists<Encounter>(h_);
        return i_;
    }


    [CqlExpressionDefinition("Date VR12 Oblique Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_VR12_Oblique_Total_Assessment_Completed(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Date_VR12_Oblique_Total_Assessment_Completed, Date_VR12_Oblique_Total_Assessment_Completed_Compute);

    private const long _cacheIndex_Date_VR12_Oblique_Total_Assessment_Completed = 5285028890419299069L;

    private IEnumerable<CqlDate> Date_VR12_Oblique_Total_Assessment_Completed_Compute(CqlContext context)
    {
        CqlCode a_ = this.VR_12_Mental_component_summary__MCS__score___oblique_method_T_score(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
        IEnumerable<Observation> d_ = Status_1_15_000.Instance.isAssessmentPerformed(context, c_);
        CqlCode e_ = this.VR_12_Physical_component_summary__PCS__score___oblique_method_T_score(context);
        IEnumerable<CqlCode> f_ = context.Operators.ToList<CqlCode>(e_);
        IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, f_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
        IEnumerable<Observation> h_ = Status_1_15_000.Instance.isAssessmentPerformed(context, g_);
        IEnumerable<ValueTuple<Observation, Observation>> i_ = context.Operators.CrossJoin<Observation, Observation>(d_, h_);

        (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? j_(ValueTuple<Observation, Observation> _valueTuple) {
            (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? o_ = (CqlTupleMetadata_GAdRFKRaHUUGJcVHWQWRUjhRH, _valueTuple.Item1, _valueTuple.Item2);
            return o_;
        }


        bool? k_((CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? tuple_gadrfkrahuugjcvhwqwrujhrh) {
            DataType p_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Effective;
            object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
            CqlInterval<CqlDateTime> r_ = QICoreCommon_4_0_000.Instance.toInterval(context, q_);
            CqlDateTime s_ = context.Operators.Start(r_);
            CqlDate t_ = context.Operators.DateFrom(s_);
            DataType u_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Effective;
            object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
            CqlInterval<CqlDateTime> w_ = QICoreCommon_4_0_000.Instance.toInterval(context, v_);
            CqlDateTime x_ = context.Operators.Start(w_);
            CqlDate y_ = context.Operators.DateFrom(x_);
            bool? z_ = context.Operators.SameAs(t_, y_, "day");
            bool? aa_;
            // CQL 'and' (192:11-193:86): right operand skipped when left is false
            if (z_ is false)
            {
                aa_ = false;
            }
            else
            {
                DataType ab_ = (tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment as Observation)?.Value;
                object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                aa_ = z_ & (!((bool?)(ac_ is null)));
            }
            // CQL 'and' (192:5-194:88): right operand skipped when left is false
            if (aa_ is false)
            {
                return false;
            }
            else
            {
                DataType ad_ = (tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment as Observation)?.Value;
                object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                return aa_ & (!((bool?)(ae_ is null)));
            }
        }

        IEnumerable<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?> l_ = context.Operators.SelectWhere<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?>(i_, j_, k_);

        CqlDate m_((CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? tuple_gadrfkrahuugjcvhwqwrujhrh) {
            DataType af_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Effective;
            object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
            CqlInterval<CqlDateTime> ah_ = QICoreCommon_4_0_000.Instance.toInterval(context, ag_);
            CqlDateTime ai_ = context.Operators.Start(ah_);
            CqlDate aj_ = context.Operators.DateFrom(ai_);
            return aj_;
        }

        IEnumerable<CqlDate> n_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?, CqlDate>(l_, m_);
        return n_;
    }


    [CqlExpressionDefinition("Has Encounter with Initial and Follow Up VR12 Oblique Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_VR12_Oblique_Assessments(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Encounter_with_Initial_and_Follow_Up_VR12_Oblique_Assessments, Has_Encounter_with_Initial_and_Follow_Up_VR12_Oblique_Assessments_Compute);

    private const long _cacheIndex_Has_Encounter_with_Initial_and_Follow_Up_VR12_Oblique_Assessments = -9101247183797375897L;

    private bool? Has_Encounter_with_Initial_and_Follow_Up_VR12_Oblique_Assessments_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounters(context);
        IEnumerable<CqlDate> b_ = this.Date_VR12_Oblique_Total_Assessment_Completed(context);
        IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> c_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(a_, b_, b_);

        (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12ObliqueDate, CqlDate FollowupVR12ObliqueDate)? d_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple) {
            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12ObliqueDate, CqlDate FollowupVR12ObliqueDate)? j_ = (CqlTupleMetadata_FQKGdEYLiDFGMNAUAMETIHUQT, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return j_;
        }


        bool? e_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12ObliqueDate, CqlDate FollowupVR12ObliqueDate)? tuple_fppktdiagiekhptnsbacpswh) {
            Period k_ = tuple_fppktdiagiekhptnsbacpswh?.ValidEncounters?.Period;
            CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
            CqlDateTime m_ = context.Operators.End(l_);
            CqlInterval<CqlDateTime> n_ = this.Measurement_Period(context);
            CqlDateTime o_ = context.Operators.End(n_);
            CqlQuantity p_ = context.Operators.Quantity(180m, "days");
            CqlDateTime q_ = context.Operators.Subtract(o_, p_);
            bool? r_ = context.Operators.SameOrBefore(m_, q_, "day");
            bool? s_;
            // CQL 'and' (180:13-181:100): right operand skipped when left is false
            if (r_ is false)
            {
                s_ = false;
            }
            else
            {
                CqlDateTime t_ = context.Operators.ConvertDateToDateTime(tuple_fppktdiagiekhptnsbacpswh?.InitialVR12ObliqueDate);
                Period u_ = tuple_fppktdiagiekhptnsbacpswh?.ValidEncounters?.Period;
                CqlInterval<CqlDateTime> v_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, u_);
                CqlDateTime w_ = context.Operators.End(v_);
                CqlQuantity x_ = context.Operators.Quantity(14m, "days");
                CqlDateTime y_ = context.Operators.Subtract(w_, x_);
                CqlInterval<CqlDateTime> z_ = context.Operators.Interval(y_, w_, true, true);
                bool? aa_ = context.Operators.In<CqlDateTime>(t_, z_, "day");
                bool? ab_;
                // CQL 'and' (181:13-181:100): right operand skipped when left is false
                if (aa_ is false)
                {
                    ab_ = false;
                }
                else
                {
                    Period ac_ = tuple_fppktdiagiekhptnsbacpswh?.ValidEncounters?.Period;
                    CqlInterval<CqlDateTime> ad_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ac_);
                    CqlDateTime ae_ = context.Operators.End(ad_);
                    ab_ = aa_ & (!((bool?)(ae_ is null)));
                }
                s_ = r_ & ab_;
            }
            // CQL 'and' (180:7-182:157): right operand skipped when left is false
            if (s_ is false)
            {
                return false;
            }
            else
            {
                CqlDateTime af_ = context.Operators.ConvertDateToDateTime(tuple_fppktdiagiekhptnsbacpswh?.FollowupVR12ObliqueDate);
                CqlDate ag_ = context.Operators.DateFrom(af_);
                CqlDateTime ah_ = context.Operators.ConvertDateToDateTime(tuple_fppktdiagiekhptnsbacpswh?.InitialVR12ObliqueDate);
                CqlDate ai_ = context.Operators.DateFrom(ah_);
                CqlQuantity aj_ = context.Operators.Quantity(30m, "days");
                CqlDate ak_ = context.Operators.Add(ai_, aj_);
                CqlQuantity al_ = context.Operators.Quantity(180m, "days");
                CqlDate am_ = context.Operators.Add(ai_, al_);
                CqlInterval<CqlDate> an_ = context.Operators.Interval(ak_, am_, true, true);
                bool? ao_ = context.Operators.In<CqlDate>(ag_, an_, "day");
                return s_ & ao_;
            }
        }

        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12ObliqueDate, CqlDate FollowupVR12ObliqueDate)?> f_ = context.Operators.SelectWhere<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12ObliqueDate, CqlDate FollowupVR12ObliqueDate)?>(c_, d_, e_);
        Encounter g_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12ObliqueDate, CqlDate FollowupVR12ObliqueDate)? tuple_fppktdiagiekhptnsbacpswh) => tuple_fppktdiagiekhptnsbacpswh?.ValidEncounters;
        IEnumerable<Encounter> h_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12ObliqueDate, CqlDate FollowupVR12ObliqueDate)?, Encounter>(f_, g_);
        bool? i_ = context.Operators.Exists<Encounter>(h_);
        return i_;
    }


    [CqlExpressionDefinition("Date VR12 Orthogonal Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_VR12_Orthogonal_Total_Assessment_Completed(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Date_VR12_Orthogonal_Total_Assessment_Completed, Date_VR12_Orthogonal_Total_Assessment_Completed_Compute);

    private const long _cacheIndex_Date_VR12_Orthogonal_Total_Assessment_Completed = -4308956976409684029L;

    private IEnumerable<CqlDate> Date_VR12_Orthogonal_Total_Assessment_Completed_Compute(CqlContext context)
    {
        CqlCode a_ = this.VR_12_Mental_component_summary__MCS__score___orthogonal_method_T_score(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
        IEnumerable<Observation> d_ = Status_1_15_000.Instance.isAssessmentPerformed(context, c_);
        CqlCode e_ = this.VR_12_Physical_component_summary__PCS__score___orthogonal_method_T_score(context);
        IEnumerable<CqlCode> f_ = context.Operators.ToList<CqlCode>(e_);
        IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, f_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
        IEnumerable<Observation> h_ = Status_1_15_000.Instance.isAssessmentPerformed(context, g_);
        IEnumerable<ValueTuple<Observation, Observation>> i_ = context.Operators.CrossJoin<Observation, Observation>(d_, h_);

        (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? j_(ValueTuple<Observation, Observation> _valueTuple) {
            (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? o_ = (CqlTupleMetadata_GAdRFKRaHUUGJcVHWQWRUjhRH, _valueTuple.Item1, _valueTuple.Item2);
            return o_;
        }


        bool? k_((CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? tuple_gadrfkrahuugjcvhwqwrujhrh) {
            DataType p_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Effective;
            object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
            CqlInterval<CqlDateTime> r_ = QICoreCommon_4_0_000.Instance.toInterval(context, q_);
            CqlDateTime s_ = context.Operators.Start(r_);
            CqlDate t_ = context.Operators.DateFrom(s_);
            DataType u_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Effective;
            object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
            CqlInterval<CqlDateTime> w_ = QICoreCommon_4_0_000.Instance.toInterval(context, v_);
            CqlDateTime x_ = context.Operators.Start(w_);
            CqlDate y_ = context.Operators.DateFrom(x_);
            bool? z_ = context.Operators.SameAs(t_, y_, "day");
            bool? aa_;
            // CQL 'and' (214:11-215:86): right operand skipped when left is false
            if (z_ is false)
            {
                aa_ = false;
            }
            else
            {
                DataType ab_ = (tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment as Observation)?.Value;
                object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                aa_ = z_ & (!((bool?)(ac_ is null)));
            }
            // CQL 'and' (214:5-216:88): right operand skipped when left is false
            if (aa_ is false)
            {
                return false;
            }
            else
            {
                DataType ad_ = (tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment as Observation)?.Value;
                object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                return aa_ & (!((bool?)(ae_ is null)));
            }
        }

        IEnumerable<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?> l_ = context.Operators.SelectWhere<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?>(i_, j_, k_);

        CqlDate m_((CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? tuple_gadrfkrahuugjcvhwqwrujhrh) {
            DataType af_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Effective;
            object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
            CqlInterval<CqlDateTime> ah_ = QICoreCommon_4_0_000.Instance.toInterval(context, ag_);
            CqlDateTime ai_ = context.Operators.Start(ah_);
            CqlDate aj_ = context.Operators.DateFrom(ai_);
            return aj_;
        }

        IEnumerable<CqlDate> n_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?, CqlDate>(l_, m_);
        return n_;
    }


    [CqlExpressionDefinition("Has Encounter with Initial and Follow Up VR12 Orthogonal Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Encounter_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments, Has_Encounter_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments_Compute);

    private const long _cacheIndex_Has_Encounter_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments = -3523837020378714173L;

    private bool? Has_Encounter_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounters(context);
        IEnumerable<CqlDate> b_ = this.Date_VR12_Orthogonal_Total_Assessment_Completed(context);
        IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> c_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(a_, b_, b_);

        (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12OrthogonalDate, CqlDate FollowupVR12OrthogonalDate)? d_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple) {
            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12OrthogonalDate, CqlDate FollowupVR12OrthogonalDate)? j_ = (CqlTupleMetadata_HSSAQEFQAOXLjUcOKGgicELWB, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return j_;
        }


        bool? e_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12OrthogonalDate, CqlDate FollowupVR12OrthogonalDate)? tuple_fansvmjaedmvsdoyrozxdlsai) {
            Period k_ = tuple_fansvmjaedmvsdoyrozxdlsai?.ValidEncounters?.Period;
            CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
            CqlDateTime m_ = context.Operators.End(l_);
            CqlInterval<CqlDateTime> n_ = this.Measurement_Period(context);
            CqlDateTime o_ = context.Operators.End(n_);
            CqlQuantity p_ = context.Operators.Quantity(180m, "days");
            CqlDateTime q_ = context.Operators.Subtract(o_, p_);
            bool? r_ = context.Operators.SameOrBefore(m_, q_, "day");
            bool? s_;
            // CQL 'and' (202:13-203:103): right operand skipped when left is false
            if (r_ is false)
            {
                s_ = false;
            }
            else
            {
                CqlDateTime t_ = context.Operators.ConvertDateToDateTime(tuple_fansvmjaedmvsdoyrozxdlsai?.InitialVR12OrthogonalDate);
                Period u_ = tuple_fansvmjaedmvsdoyrozxdlsai?.ValidEncounters?.Period;
                CqlInterval<CqlDateTime> v_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, u_);
                CqlDateTime w_ = context.Operators.End(v_);
                CqlQuantity x_ = context.Operators.Quantity(14m, "days");
                CqlDateTime y_ = context.Operators.Subtract(w_, x_);
                CqlInterval<CqlDateTime> z_ = context.Operators.Interval(y_, w_, true, true);
                bool? aa_ = context.Operators.In<CqlDateTime>(t_, z_, "day");
                bool? ab_;
                // CQL 'and' (203:13-203:103): right operand skipped when left is false
                if (aa_ is false)
                {
                    ab_ = false;
                }
                else
                {
                    Period ac_ = tuple_fansvmjaedmvsdoyrozxdlsai?.ValidEncounters?.Period;
                    CqlInterval<CqlDateTime> ad_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ac_);
                    CqlDateTime ae_ = context.Operators.End(ad_);
                    ab_ = aa_ & (!((bool?)(ae_ is null)));
                }
                s_ = r_ & ab_;
            }
            // CQL 'and' (202:7-204:166): right operand skipped when left is false
            if (s_ is false)
            {
                return false;
            }
            else
            {
                CqlDateTime af_ = context.Operators.ConvertDateToDateTime(tuple_fansvmjaedmvsdoyrozxdlsai?.FollowupVR12OrthogonalDate);
                CqlDate ag_ = context.Operators.DateFrom(af_);
                CqlDateTime ah_ = context.Operators.ConvertDateToDateTime(tuple_fansvmjaedmvsdoyrozxdlsai?.InitialVR12OrthogonalDate);
                CqlDate ai_ = context.Operators.DateFrom(ah_);
                CqlQuantity aj_ = context.Operators.Quantity(30m, "days");
                CqlDate ak_ = context.Operators.Add(ai_, aj_);
                CqlQuantity al_ = context.Operators.Quantity(180m, "days");
                CqlDate am_ = context.Operators.Add(ai_, al_);
                CqlInterval<CqlDate> an_ = context.Operators.Interval(ak_, am_, true, true);
                bool? ao_ = context.Operators.In<CqlDate>(ag_, an_, "day");
                return s_ & ao_;
            }
        }

        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12OrthogonalDate, CqlDate FollowupVR12OrthogonalDate)?> f_ = context.Operators.SelectWhere<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12OrthogonalDate, CqlDate FollowupVR12OrthogonalDate)?>(c_, d_, e_);
        Encounter g_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12OrthogonalDate, CqlDate FollowupVR12OrthogonalDate)? tuple_fansvmjaedmvsdoyrozxdlsai) => tuple_fansvmjaedmvsdoyrozxdlsai?.ValidEncounters;
        IEnumerable<Encounter> h_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12OrthogonalDate, CqlDate FollowupVR12OrthogonalDate)?, Encounter>(f_, g_);
        bool? i_ = context.Operators.Exists<Encounter>(h_);
        return i_;
    }


    [CqlExpressionDefinition("Date VR36 Oblique Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_VR36_Oblique_Total_Assessment_Completed(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Date_VR36_Oblique_Total_Assessment_Completed, Date_VR36_Oblique_Total_Assessment_Completed_Compute);

    private const long _cacheIndex_Date_VR36_Oblique_Total_Assessment_Completed = 156742284346193099L;

    private IEnumerable<CqlDate> Date_VR36_Oblique_Total_Assessment_Completed_Compute(CqlContext context)
    {
        CqlCode a_ = this.VR_36_Mental_component_summary__MCS__score___oblique_method_T_score(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
        IEnumerable<Observation> d_ = Status_1_15_000.Instance.isAssessmentPerformed(context, c_);
        CqlCode e_ = this.VR_36_Physical_component_summary__PCS__score___oblique_method_T_score(context);
        IEnumerable<CqlCode> f_ = context.Operators.ToList<CqlCode>(e_);
        IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, f_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
        IEnumerable<Observation> h_ = Status_1_15_000.Instance.isAssessmentPerformed(context, g_);
        IEnumerable<ValueTuple<Observation, Observation>> i_ = context.Operators.CrossJoin<Observation, Observation>(d_, h_);

        (CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)? j_(ValueTuple<Observation, Observation> _valueTuple) {
            (CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)? o_ = (CqlTupleMetadata_DUcFTCLcQEWDGGQdFCWTHFaUK, _valueTuple.Item1, _valueTuple.Item2);
            return o_;
        }


        bool? k_((CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)? tuple_ducftclcqewdggqdfcwthfauk) {
            DataType p_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36MentalAssessment?.Effective;
            object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
            CqlInterval<CqlDateTime> r_ = QICoreCommon_4_0_000.Instance.toInterval(context, q_);
            CqlDateTime s_ = context.Operators.Start(r_);
            CqlDate t_ = context.Operators.DateFrom(s_);
            DataType u_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36PhysicalAssessment?.Effective;
            object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
            CqlInterval<CqlDateTime> w_ = QICoreCommon_4_0_000.Instance.toInterval(context, v_);
            CqlDateTime x_ = context.Operators.Start(w_);
            CqlDate y_ = context.Operators.DateFrom(x_);
            bool? z_ = context.Operators.SameAs(t_, y_, "day");
            bool? aa_;
            // CQL 'and' (236:11-237:86): right operand skipped when left is false
            if (z_ is false)
            {
                aa_ = false;
            }
            else
            {
                DataType ab_ = (tuple_ducftclcqewdggqdfcwthfauk?.VR36MentalAssessment as Observation)?.Value;
                object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                aa_ = z_ & (!((bool?)(ac_ is null)));
            }
            // CQL 'and' (236:5-238:88): right operand skipped when left is false
            if (aa_ is false)
            {
                return false;
            }
            else
            {
                DataType ad_ = (tuple_ducftclcqewdggqdfcwthfauk?.VR36PhysicalAssessment as Observation)?.Value;
                object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                return aa_ & (!((bool?)(ae_ is null)));
            }
        }

        IEnumerable<(CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?> l_ = context.Operators.SelectWhere<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?>(i_, j_, k_);

        CqlDate m_((CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)? tuple_ducftclcqewdggqdfcwthfauk) {
            DataType af_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36MentalAssessment?.Effective;
            object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
            CqlInterval<CqlDateTime> ah_ = QICoreCommon_4_0_000.Instance.toInterval(context, ag_);
            CqlDateTime ai_ = context.Operators.Start(ah_);
            CqlDate aj_ = context.Operators.DateFrom(ai_);
            return aj_;
        }

        IEnumerable<CqlDate> n_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?, CqlDate>(l_, m_);
        return n_;
    }


    [CqlExpressionDefinition("Has Encounter with Initial and Follow Up VR36 Oblique Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_VR36_Oblique_Assessments(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Encounter_with_Initial_and_Follow_Up_VR36_Oblique_Assessments, Has_Encounter_with_Initial_and_Follow_Up_VR36_Oblique_Assessments_Compute);

    private const long _cacheIndex_Has_Encounter_with_Initial_and_Follow_Up_VR36_Oblique_Assessments = -4830229598614441452L;

    private bool? Has_Encounter_with_Initial_and_Follow_Up_VR36_Oblique_Assessments_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounters(context);
        IEnumerable<CqlDate> b_ = this.Date_VR36_Oblique_Total_Assessment_Completed(context);
        IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> c_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(a_, b_, b_);

        (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36ObliqueDate, CqlDate FollowupVR36ObliqueDate)? d_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple) {
            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36ObliqueDate, CqlDate FollowupVR36ObliqueDate)? j_ = (CqlTupleMetadata_HQfcMfhQUSTNYMWSgJHiFeahQ, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return j_;
        }


        bool? e_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36ObliqueDate, CqlDate FollowupVR36ObliqueDate)? tuple_elxicyhrdpyzpqyjphdifbiga) {
            Period k_ = tuple_elxicyhrdpyzpqyjphdifbiga?.ValidEncounters?.Period;
            CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
            CqlDateTime m_ = context.Operators.End(l_);
            CqlInterval<CqlDateTime> n_ = this.Measurement_Period(context);
            CqlDateTime o_ = context.Operators.End(n_);
            CqlQuantity p_ = context.Operators.Quantity(180m, "days");
            CqlDateTime q_ = context.Operators.Subtract(o_, p_);
            bool? r_ = context.Operators.SameOrBefore(m_, q_, "day");
            bool? s_;
            // CQL 'and' (224:13-225:100): right operand skipped when left is false
            if (r_ is false)
            {
                s_ = false;
            }
            else
            {
                CqlDateTime t_ = context.Operators.ConvertDateToDateTime(tuple_elxicyhrdpyzpqyjphdifbiga?.InitialVR36ObliqueDate);
                Period u_ = tuple_elxicyhrdpyzpqyjphdifbiga?.ValidEncounters?.Period;
                CqlInterval<CqlDateTime> v_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, u_);
                CqlDateTime w_ = context.Operators.End(v_);
                CqlQuantity x_ = context.Operators.Quantity(14m, "days");
                CqlDateTime y_ = context.Operators.Subtract(w_, x_);
                CqlInterval<CqlDateTime> z_ = context.Operators.Interval(y_, w_, true, true);
                bool? aa_ = context.Operators.In<CqlDateTime>(t_, z_, "day");
                bool? ab_;
                // CQL 'and' (225:13-225:100): right operand skipped when left is false
                if (aa_ is false)
                {
                    ab_ = false;
                }
                else
                {
                    Period ac_ = tuple_elxicyhrdpyzpqyjphdifbiga?.ValidEncounters?.Period;
                    CqlInterval<CqlDateTime> ad_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ac_);
                    CqlDateTime ae_ = context.Operators.End(ad_);
                    ab_ = aa_ & (!((bool?)(ae_ is null)));
                }
                s_ = r_ & ab_;
            }
            // CQL 'and' (224:7-226:157): right operand skipped when left is false
            if (s_ is false)
            {
                return false;
            }
            else
            {
                CqlDateTime af_ = context.Operators.ConvertDateToDateTime(tuple_elxicyhrdpyzpqyjphdifbiga?.FollowupVR36ObliqueDate);
                CqlDate ag_ = context.Operators.DateFrom(af_);
                CqlDateTime ah_ = context.Operators.ConvertDateToDateTime(tuple_elxicyhrdpyzpqyjphdifbiga?.InitialVR36ObliqueDate);
                CqlDate ai_ = context.Operators.DateFrom(ah_);
                CqlQuantity aj_ = context.Operators.Quantity(30m, "days");
                CqlDate ak_ = context.Operators.Add(ai_, aj_);
                CqlQuantity al_ = context.Operators.Quantity(180m, "days");
                CqlDate am_ = context.Operators.Add(ai_, al_);
                CqlInterval<CqlDate> an_ = context.Operators.Interval(ak_, am_, true, true);
                bool? ao_ = context.Operators.In<CqlDate>(ag_, an_, "day");
                return s_ & ao_;
            }
        }

        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36ObliqueDate, CqlDate FollowupVR36ObliqueDate)?> f_ = context.Operators.SelectWhere<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36ObliqueDate, CqlDate FollowupVR36ObliqueDate)?>(c_, d_, e_);
        Encounter g_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36ObliqueDate, CqlDate FollowupVR36ObliqueDate)? tuple_elxicyhrdpyzpqyjphdifbiga) => tuple_elxicyhrdpyzpqyjphdifbiga?.ValidEncounters;
        IEnumerable<Encounter> h_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36ObliqueDate, CqlDate FollowupVR36ObliqueDate)?, Encounter>(f_, g_);
        bool? i_ = context.Operators.Exists<Encounter>(h_);
        return i_;
    }


    [CqlExpressionDefinition("Date VR36 Orthogonal Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_VR36_Orthogonal_Total_Assessment_Completed(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Date_VR36_Orthogonal_Total_Assessment_Completed, Date_VR36_Orthogonal_Total_Assessment_Completed_Compute);

    private const long _cacheIndex_Date_VR36_Orthogonal_Total_Assessment_Completed = -6950216527866873198L;

    private IEnumerable<CqlDate> Date_VR36_Orthogonal_Total_Assessment_Completed_Compute(CqlContext context)
    {
        CqlCode a_ = this.VR_36_Mental_component_summary__MCS__score___orthogonal_method_T_score(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
        IEnumerable<Observation> d_ = Status_1_15_000.Instance.isAssessmentPerformed(context, c_);
        CqlCode e_ = this.VR_36_Physical_component_summary__PCS__score___orthogonal_method_T_score(context);
        IEnumerable<CqlCode> f_ = context.Operators.ToList<CqlCode>(e_);
        IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, f_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
        IEnumerable<Observation> h_ = Status_1_15_000.Instance.isAssessmentPerformed(context, g_);
        IEnumerable<ValueTuple<Observation, Observation>> i_ = context.Operators.CrossJoin<Observation, Observation>(d_, h_);

        (CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)? j_(ValueTuple<Observation, Observation> _valueTuple) {
            (CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)? o_ = (CqlTupleMetadata_DUcFTCLcQEWDGGQdFCWTHFaUK, _valueTuple.Item1, _valueTuple.Item2);
            return o_;
        }


        bool? k_((CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)? tuple_ducftclcqewdggqdfcwthfauk) {
            DataType p_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36MentalAssessment?.Effective;
            object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
            CqlInterval<CqlDateTime> r_ = QICoreCommon_4_0_000.Instance.toInterval(context, q_);
            CqlDateTime s_ = context.Operators.Start(r_);
            CqlDate t_ = context.Operators.DateFrom(s_);
            DataType u_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36PhysicalAssessment?.Effective;
            object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
            CqlInterval<CqlDateTime> w_ = QICoreCommon_4_0_000.Instance.toInterval(context, v_);
            CqlDateTime x_ = context.Operators.Start(w_);
            CqlDate y_ = context.Operators.DateFrom(x_);
            bool? z_ = context.Operators.SameAs(t_, y_, "day");
            bool? aa_;
            // CQL 'and' (258:11-259:86): right operand skipped when left is false
            if (z_ is false)
            {
                aa_ = false;
            }
            else
            {
                DataType ab_ = (tuple_ducftclcqewdggqdfcwthfauk?.VR36MentalAssessment as Observation)?.Value;
                object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                aa_ = z_ & (!((bool?)(ac_ is null)));
            }
            // CQL 'and' (258:5-260:88): right operand skipped when left is false
            if (aa_ is false)
            {
                return false;
            }
            else
            {
                DataType ad_ = (tuple_ducftclcqewdggqdfcwthfauk?.VR36PhysicalAssessment as Observation)?.Value;
                object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                return aa_ & (!((bool?)(ae_ is null)));
            }
        }

        IEnumerable<(CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?> l_ = context.Operators.SelectWhere<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?>(i_, j_, k_);

        CqlDate m_((CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)? tuple_ducftclcqewdggqdfcwthfauk) {
            DataType af_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36MentalAssessment?.Effective;
            object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
            CqlInterval<CqlDateTime> ah_ = QICoreCommon_4_0_000.Instance.toInterval(context, ag_);
            CqlDateTime ai_ = context.Operators.Start(ah_);
            CqlDate aj_ = context.Operators.DateFrom(ai_);
            return aj_;
        }

        IEnumerable<CqlDate> n_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?, CqlDate>(l_, m_);
        return n_;
    }


    [CqlExpressionDefinition("Has Encounter with Initial and Follow Up VR36 Orthogonal Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_VR36_Orthogonal_Assessments(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Encounter_with_Initial_and_Follow_Up_VR36_Orthogonal_Assessments, Has_Encounter_with_Initial_and_Follow_Up_VR36_Orthogonal_Assessments_Compute);

    private const long _cacheIndex_Has_Encounter_with_Initial_and_Follow_Up_VR36_Orthogonal_Assessments = 6268914066794038861L;

    private bool? Has_Encounter_with_Initial_and_Follow_Up_VR36_Orthogonal_Assessments_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounters(context);
        IEnumerable<CqlDate> b_ = this.Date_VR36_Orthogonal_Total_Assessment_Completed(context);
        IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> c_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(a_, b_, b_);

        (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36OrthogonalDate, CqlDate FollowupVR36OrthogonalDate)? d_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple) {
            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36OrthogonalDate, CqlDate FollowupVR36OrthogonalDate)? j_ = (CqlTupleMetadata_BFZHWdOOROjSjFSECHcQiaZZZ, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return j_;
        }


        bool? e_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36OrthogonalDate, CqlDate FollowupVR36OrthogonalDate)? tuple_fucqujadjizabihdffformht) {
            Period k_ = tuple_fucqujadjizabihdffformht?.ValidEncounters?.Period;
            CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
            CqlDateTime m_ = context.Operators.End(l_);
            CqlInterval<CqlDateTime> n_ = this.Measurement_Period(context);
            CqlDateTime o_ = context.Operators.End(n_);
            CqlQuantity p_ = context.Operators.Quantity(180m, "days");
            CqlDateTime q_ = context.Operators.Subtract(o_, p_);
            bool? r_ = context.Operators.SameOrBefore(m_, q_, "day");
            bool? s_;
            // CQL 'and' (246:13-247:103): right operand skipped when left is false
            if (r_ is false)
            {
                s_ = false;
            }
            else
            {
                CqlDateTime t_ = context.Operators.ConvertDateToDateTime(tuple_fucqujadjizabihdffformht?.InitialVR36OrthogonalDate);
                Period u_ = tuple_fucqujadjizabihdffformht?.ValidEncounters?.Period;
                CqlInterval<CqlDateTime> v_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, u_);
                CqlDateTime w_ = context.Operators.End(v_);
                CqlQuantity x_ = context.Operators.Quantity(14m, "days");
                CqlDateTime y_ = context.Operators.Subtract(w_, x_);
                CqlInterval<CqlDateTime> z_ = context.Operators.Interval(y_, w_, true, true);
                bool? aa_ = context.Operators.In<CqlDateTime>(t_, z_, "day");
                bool? ab_;
                // CQL 'and' (247:13-247:103): right operand skipped when left is false
                if (aa_ is false)
                {
                    ab_ = false;
                }
                else
                {
                    Period ac_ = tuple_fucqujadjizabihdffformht?.ValidEncounters?.Period;
                    CqlInterval<CqlDateTime> ad_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ac_);
                    CqlDateTime ae_ = context.Operators.End(ad_);
                    ab_ = aa_ & (!((bool?)(ae_ is null)));
                }
                s_ = r_ & ab_;
            }
            // CQL 'and' (246:7-248:166): right operand skipped when left is false
            if (s_ is false)
            {
                return false;
            }
            else
            {
                CqlDateTime af_ = context.Operators.ConvertDateToDateTime(tuple_fucqujadjizabihdffformht?.FollowupVR36OrthogonalDate);
                CqlDate ag_ = context.Operators.DateFrom(af_);
                CqlDateTime ah_ = context.Operators.ConvertDateToDateTime(tuple_fucqujadjizabihdffformht?.InitialVR36OrthogonalDate);
                CqlDate ai_ = context.Operators.DateFrom(ah_);
                CqlQuantity aj_ = context.Operators.Quantity(30m, "days");
                CqlDate ak_ = context.Operators.Add(ai_, aj_);
                CqlQuantity al_ = context.Operators.Quantity(180m, "days");
                CqlDate am_ = context.Operators.Add(ai_, al_);
                CqlInterval<CqlDate> an_ = context.Operators.Interval(ak_, am_, true, true);
                bool? ao_ = context.Operators.In<CqlDate>(ag_, an_, "day");
                return s_ & ao_;
            }
        }

        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36OrthogonalDate, CqlDate FollowupVR36OrthogonalDate)?> f_ = context.Operators.SelectWhere<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36OrthogonalDate, CqlDate FollowupVR36OrthogonalDate)?>(c_, d_, e_);
        Encounter g_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36OrthogonalDate, CqlDate FollowupVR36OrthogonalDate)? tuple_fucqujadjizabihdffformht) => tuple_fucqujadjizabihdffformht?.ValidEncounters;
        IEnumerable<Encounter> h_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36OrthogonalDate, CqlDate FollowupVR36OrthogonalDate)?, Encounter>(f_, g_);
        bool? i_ = context.Operators.Exists<Encounter>(h_);
        return i_;
    }


    [CqlExpressionDefinition("Date MLHFQ Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_MLHFQ_Total_Assessment_Completed(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Date_MLHFQ_Total_Assessment_Completed, Date_MLHFQ_Total_Assessment_Completed_Compute);

    private const long _cacheIndex_Date_MLHFQ_Total_Assessment_Completed = 7426662041656437075L;

    private IEnumerable<CqlDate> Date_MLHFQ_Total_Assessment_Completed_Compute(CqlContext context)
    {
        CqlCode a_ = this.Physical_score__MLHFQ_(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
        IEnumerable<Observation> d_ = Status_1_15_000.Instance.isAssessmentPerformed(context, c_);
        CqlCode e_ = this.Emotional_score__MLHFQ_(context);
        IEnumerable<CqlCode> f_ = context.Operators.ToList<CqlCode>(e_);
        IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, f_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
        IEnumerable<Observation> h_ = Status_1_15_000.Instance.isAssessmentPerformed(context, g_);
        IEnumerable<ValueTuple<Observation, Observation>> i_ = context.Operators.CrossJoin<Observation, Observation>(d_, h_);

        (CqlTupleMetadata, Observation MLHFQPhysical, Observation MLHFQEmotional)? j_(ValueTuple<Observation, Observation> _valueTuple) {
            (CqlTupleMetadata, Observation MLHFQPhysical, Observation MLHFQEmotional)? o_ = (CqlTupleMetadata_EBLWeAeedHPAfOJXKPZJKSCUf, _valueTuple.Item1, _valueTuple.Item2);
            return o_;
        }


        bool? k_((CqlTupleMetadata, Observation MLHFQPhysical, Observation MLHFQEmotional)? tuple_fnofxckadaeusjerhbdqfoshe) {
            DataType p_ = tuple_fnofxckadaeusjerhbdqfoshe?.MLHFQPhysical?.Effective;
            object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
            CqlInterval<CqlDateTime> r_ = QICoreCommon_4_0_000.Instance.toInterval(context, q_);
            CqlDateTime s_ = context.Operators.Start(r_);
            CqlDate t_ = context.Operators.DateFrom(s_);
            DataType u_ = tuple_fnofxckadaeusjerhbdqfoshe?.MLHFQEmotional?.Effective;
            object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
            CqlInterval<CqlDateTime> w_ = QICoreCommon_4_0_000.Instance.toInterval(context, v_);
            CqlDateTime x_ = context.Operators.Start(w_);
            CqlDate y_ = context.Operators.DateFrom(x_);
            bool? z_ = context.Operators.SameAs(t_, y_, "day");
            bool? aa_;
            // CQL 'and' (280:11-281:79): right operand skipped when left is false
            if (z_ is false)
            {
                aa_ = false;
            }
            else
            {
                DataType ab_ = (tuple_fnofxckadaeusjerhbdqfoshe?.MLHFQPhysical as Observation)?.Value;
                object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                aa_ = z_ & (!((bool?)(ac_ is null)));
            }
            // CQL 'and' (280:5-282:80): right operand skipped when left is false
            if (aa_ is false)
            {
                return false;
            }
            else
            {
                DataType ad_ = (tuple_fnofxckadaeusjerhbdqfoshe?.MLHFQEmotional as Observation)?.Value;
                object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                return aa_ & (!((bool?)(ae_ is null)));
            }
        }

        IEnumerable<(CqlTupleMetadata, Observation MLHFQPhysical, Observation MLHFQEmotional)?> l_ = context.Operators.SelectWhere<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation MLHFQPhysical, Observation MLHFQEmotional)?>(i_, j_, k_);

        CqlDate m_((CqlTupleMetadata, Observation MLHFQPhysical, Observation MLHFQEmotional)? tuple_fnofxckadaeusjerhbdqfoshe) {
            DataType af_ = tuple_fnofxckadaeusjerhbdqfoshe?.MLHFQPhysical?.Effective;
            object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
            CqlInterval<CqlDateTime> ah_ = QICoreCommon_4_0_000.Instance.toInterval(context, ag_);
            CqlDateTime ai_ = context.Operators.Start(ah_);
            CqlDate aj_ = context.Operators.DateFrom(ai_);
            return aj_;
        }

        IEnumerable<CqlDate> n_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Observation MLHFQPhysical, Observation MLHFQEmotional)?, CqlDate>(l_, m_);
        return n_;
    }


    [CqlExpressionDefinition("Has Encounter with Initial and Follow Up MLHFQ Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_MLHFQ_Assessments(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Encounter_with_Initial_and_Follow_Up_MLHFQ_Assessments, Has_Encounter_with_Initial_and_Follow_Up_MLHFQ_Assessments_Compute);

    private const long _cacheIndex_Has_Encounter_with_Initial_and_Follow_Up_MLHFQ_Assessments = -2626207006591928399L;

    private bool? Has_Encounter_with_Initial_and_Follow_Up_MLHFQ_Assessments_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounters(context);
        IEnumerable<CqlDate> b_ = this.Date_MLHFQ_Total_Assessment_Completed(context);
        IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> c_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(a_, b_, b_);

        (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialMLHFQDate, CqlDate FollowupMLHFQDate)? d_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple) {
            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialMLHFQDate, CqlDate FollowupMLHFQDate)? j_ = (CqlTupleMetadata_CcaWSNDiVeaLebVKKWWWiBcEU, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return j_;
        }


        bool? e_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialMLHFQDate, CqlDate FollowupMLHFQDate)? tuple_ncdawctnmbfmtibmihsfbaig) {
            Period k_ = tuple_ncdawctnmbfmtibmihsfbaig?.ValidEncounters?.Period;
            CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
            CqlDateTime m_ = context.Operators.End(l_);
            CqlInterval<CqlDateTime> n_ = this.Measurement_Period(context);
            CqlDateTime o_ = context.Operators.End(n_);
            CqlQuantity p_ = context.Operators.Quantity(180m, "days");
            CqlDateTime q_ = context.Operators.Subtract(o_, p_);
            bool? r_ = context.Operators.SameOrBefore(m_, q_, "day");
            bool? s_;
            // CQL 'and' (268:13-269:94): right operand skipped when left is false
            if (r_ is false)
            {
                s_ = false;
            }
            else
            {
                CqlDateTime t_ = context.Operators.ConvertDateToDateTime(tuple_ncdawctnmbfmtibmihsfbaig?.InitialMLHFQDate);
                Period u_ = tuple_ncdawctnmbfmtibmihsfbaig?.ValidEncounters?.Period;
                CqlInterval<CqlDateTime> v_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, u_);
                CqlDateTime w_ = context.Operators.End(v_);
                CqlQuantity x_ = context.Operators.Quantity(14m, "days");
                CqlDateTime y_ = context.Operators.Subtract(w_, x_);
                CqlInterval<CqlDateTime> z_ = context.Operators.Interval(y_, w_, true, true);
                bool? aa_ = context.Operators.In<CqlDateTime>(t_, z_, "day");
                bool? ab_;
                // CQL 'and' (269:13-269:94): right operand skipped when left is false
                if (aa_ is false)
                {
                    ab_ = false;
                }
                else
                {
                    Period ac_ = tuple_ncdawctnmbfmtibmihsfbaig?.ValidEncounters?.Period;
                    CqlInterval<CqlDateTime> ad_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ac_);
                    CqlDateTime ae_ = context.Operators.End(ad_);
                    ab_ = aa_ & (!((bool?)(ae_ is null)));
                }
                s_ = r_ & ab_;
            }
            // CQL 'and' (268:7-270:139): right operand skipped when left is false
            if (s_ is false)
            {
                return false;
            }
            else
            {
                CqlDateTime af_ = context.Operators.ConvertDateToDateTime(tuple_ncdawctnmbfmtibmihsfbaig?.FollowupMLHFQDate);
                CqlDate ag_ = context.Operators.DateFrom(af_);
                CqlDateTime ah_ = context.Operators.ConvertDateToDateTime(tuple_ncdawctnmbfmtibmihsfbaig?.InitialMLHFQDate);
                CqlDate ai_ = context.Operators.DateFrom(ah_);
                CqlQuantity aj_ = context.Operators.Quantity(30m, "days");
                CqlDate ak_ = context.Operators.Add(ai_, aj_);
                CqlQuantity al_ = context.Operators.Quantity(180m, "days");
                CqlDate am_ = context.Operators.Add(ai_, al_);
                CqlInterval<CqlDate> an_ = context.Operators.Interval(ak_, am_, true, true);
                bool? ao_ = context.Operators.In<CqlDate>(ag_, an_, "day");
                return s_ & ao_;
            }
        }

        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialMLHFQDate, CqlDate FollowupMLHFQDate)?> f_ = context.Operators.SelectWhere<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialMLHFQDate, CqlDate FollowupMLHFQDate)?>(c_, d_, e_);
        Encounter g_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialMLHFQDate, CqlDate FollowupMLHFQDate)? tuple_ncdawctnmbfmtibmihsfbaig) => tuple_ncdawctnmbfmtibmihsfbaig?.ValidEncounters;
        IEnumerable<Encounter> h_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialMLHFQDate, CqlDate FollowupMLHFQDate)?, Encounter>(f_, g_);
        bool? i_ = context.Operators.Exists<Encounter>(h_);
        return i_;
    }


    [CqlExpressionDefinition("Date KCCQ12 Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_KCCQ12_Total_Assessment_Completed(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Date_KCCQ12_Total_Assessment_Completed, Date_KCCQ12_Total_Assessment_Completed_Compute);

    private const long _cacheIndex_Date_KCCQ12_Total_Assessment_Completed = -213750493608688425L;

    private IEnumerable<CqlDate> Date_KCCQ12_Total_Assessment_Completed_Compute(CqlContext context)
    {
        CqlCode a_ = this.Kansas_City_Cardiomyopathy_Questionnaire___12_item__KCCQ_12_(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
        IEnumerable<Observation> d_ = Status_1_15_000.Instance.isAssessmentPerformed(context, c_);
        CqlCode e_ = this.Overall_summary_score__KCCQ_12_(context);
        IEnumerable<CqlCode> f_ = context.Operators.ToList<CqlCode>(e_);
        IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, f_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
        IEnumerable<Observation> h_ = Status_1_15_000.Instance.isAssessmentPerformed(context, g_);
        IEnumerable<ValueTuple<Observation, Observation>> i_ = context.Operators.CrossJoin<Observation, Observation>(d_, h_);

        (CqlTupleMetadata, Observation KCCQ12Item, Observation KCCQ12Summary)? j_(ValueTuple<Observation, Observation> _valueTuple) {
            (CqlTupleMetadata, Observation KCCQ12Item, Observation KCCQ12Summary)? o_ = (CqlTupleMetadata_DFKXORghhYafccUSbQaMfNTDj, _valueTuple.Item1, _valueTuple.Item2);
            return o_;
        }


        bool? k_((CqlTupleMetadata, Observation KCCQ12Item, Observation KCCQ12Summary)? tuple_dfkxorghhyafccusbqamfntdj) {
            DataType p_ = tuple_dfkxorghhyafccusbqamfntdj?.KCCQ12Item?.Effective;
            object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
            CqlInterval<CqlDateTime> r_ = QICoreCommon_4_0_000.Instance.toInterval(context, q_);
            CqlDateTime s_ = context.Operators.Start(r_);
            CqlDate t_ = context.Operators.DateFrom(s_);
            DataType u_ = tuple_dfkxorghhyafccusbqamfntdj?.KCCQ12Summary?.Effective;
            object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
            CqlInterval<CqlDateTime> w_ = QICoreCommon_4_0_000.Instance.toInterval(context, v_);
            CqlDateTime x_ = context.Operators.Start(w_);
            CqlDate y_ = context.Operators.DateFrom(x_);
            bool? z_ = context.Operators.SameAs(t_, y_, "day");
            bool? aa_;
            // CQL 'and' (302:11-303:76): right operand skipped when left is false
            if (z_ is false)
            {
                aa_ = false;
            }
            else
            {
                DataType ab_ = (tuple_dfkxorghhyafccusbqamfntdj?.KCCQ12Item as Observation)?.Value;
                object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                aa_ = z_ & (!((bool?)(ac_ is null)));
            }
            // CQL 'and' (302:5-304:79): right operand skipped when left is false
            if (aa_ is false)
            {
                return false;
            }
            else
            {
                DataType ad_ = (tuple_dfkxorghhyafccusbqamfntdj?.KCCQ12Summary as Observation)?.Value;
                object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                return aa_ & (!((bool?)(ae_ is null)));
            }
        }

        IEnumerable<(CqlTupleMetadata, Observation KCCQ12Item, Observation KCCQ12Summary)?> l_ = context.Operators.SelectWhere<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation KCCQ12Item, Observation KCCQ12Summary)?>(i_, j_, k_);

        CqlDate m_((CqlTupleMetadata, Observation KCCQ12Item, Observation KCCQ12Summary)? tuple_dfkxorghhyafccusbqamfntdj) {
            DataType af_ = tuple_dfkxorghhyafccusbqamfntdj?.KCCQ12Item?.Effective;
            object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
            CqlInterval<CqlDateTime> ah_ = QICoreCommon_4_0_000.Instance.toInterval(context, ag_);
            CqlDateTime ai_ = context.Operators.Start(ah_);
            CqlDate aj_ = context.Operators.DateFrom(ai_);
            return aj_;
        }

        IEnumerable<CqlDate> n_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Observation KCCQ12Item, Observation KCCQ12Summary)?, CqlDate>(l_, m_);
        return n_;
    }


    [CqlExpressionDefinition("Has Encounter with Initial and Follow Up KCCQ12 Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_KCCQ12_Assessments(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Encounter_with_Initial_and_Follow_Up_KCCQ12_Assessments, Has_Encounter_with_Initial_and_Follow_Up_KCCQ12_Assessments_Compute);

    private const long _cacheIndex_Has_Encounter_with_Initial_and_Follow_Up_KCCQ12_Assessments = -6010909731121068185L;

    private bool? Has_Encounter_with_Initial_and_Follow_Up_KCCQ12_Assessments_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounters(context);
        IEnumerable<CqlDate> b_ = this.Date_KCCQ12_Total_Assessment_Completed(context);
        IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> c_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(a_, b_, b_);

        (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQ12Date, CqlDate FollowupKCCQ12Date)? d_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple) {
            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQ12Date, CqlDate FollowupKCCQ12Date)? j_ = (CqlTupleMetadata_EQQLFFBVIbLIQLiZDNfeYdMU, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return j_;
        }


        bool? e_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQ12Date, CqlDate FollowupKCCQ12Date)? tuple_eoahgtwwdfqijhcjzqnvidvuo) {
            Period k_ = tuple_eoahgtwwdfqijhcjzqnvidvuo?.ValidEncounters?.Period;
            CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
            CqlDateTime m_ = context.Operators.End(l_);
            CqlInterval<CqlDateTime> n_ = this.Measurement_Period(context);
            CqlDateTime o_ = context.Operators.End(n_);
            CqlQuantity p_ = context.Operators.Quantity(180m, "days");
            CqlDateTime q_ = context.Operators.Subtract(o_, p_);
            bool? r_ = context.Operators.SameOrBefore(m_, q_, "day");
            bool? s_;
            // CQL 'and' (290:13-291:95): right operand skipped when left is false
            if (r_ is false)
            {
                s_ = false;
            }
            else
            {
                CqlDateTime t_ = context.Operators.ConvertDateToDateTime(tuple_eoahgtwwdfqijhcjzqnvidvuo?.InitialKCCQ12Date);
                Period u_ = tuple_eoahgtwwdfqijhcjzqnvidvuo?.ValidEncounters?.Period;
                CqlInterval<CqlDateTime> v_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, u_);
                CqlDateTime w_ = context.Operators.End(v_);
                CqlQuantity x_ = context.Operators.Quantity(14m, "days");
                CqlDateTime y_ = context.Operators.Subtract(w_, x_);
                CqlInterval<CqlDateTime> z_ = context.Operators.Interval(y_, w_, true, true);
                bool? aa_ = context.Operators.In<CqlDateTime>(t_, z_, "day");
                bool? ab_;
                // CQL 'and' (291:13-291:95): right operand skipped when left is false
                if (aa_ is false)
                {
                    ab_ = false;
                }
                else
                {
                    Period ac_ = tuple_eoahgtwwdfqijhcjzqnvidvuo?.ValidEncounters?.Period;
                    CqlInterval<CqlDateTime> ad_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ac_);
                    CqlDateTime ae_ = context.Operators.End(ad_);
                    ab_ = aa_ & (!((bool?)(ae_ is null)));
                }
                s_ = r_ & ab_;
            }
            // CQL 'and' (290:7-292:142): right operand skipped when left is false
            if (s_ is false)
            {
                return false;
            }
            else
            {
                CqlDateTime af_ = context.Operators.ConvertDateToDateTime(tuple_eoahgtwwdfqijhcjzqnvidvuo?.FollowupKCCQ12Date);
                CqlDate ag_ = context.Operators.DateFrom(af_);
                CqlDateTime ah_ = context.Operators.ConvertDateToDateTime(tuple_eoahgtwwdfqijhcjzqnvidvuo?.InitialKCCQ12Date);
                CqlDate ai_ = context.Operators.DateFrom(ah_);
                CqlQuantity aj_ = context.Operators.Quantity(30m, "days");
                CqlDate ak_ = context.Operators.Add(ai_, aj_);
                CqlQuantity al_ = context.Operators.Quantity(180m, "days");
                CqlDate am_ = context.Operators.Add(ai_, al_);
                CqlInterval<CqlDate> an_ = context.Operators.Interval(ak_, am_, true, true);
                bool? ao_ = context.Operators.In<CqlDate>(ag_, an_, "day");
                return s_ & ao_;
            }
        }

        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQ12Date, CqlDate FollowupKCCQ12Date)?> f_ = context.Operators.SelectWhere<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQ12Date, CqlDate FollowupKCCQ12Date)?>(c_, d_, e_);
        Encounter g_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQ12Date, CqlDate FollowupKCCQ12Date)? tuple_eoahgtwwdfqijhcjzqnvidvuo) => tuple_eoahgtwwdfqijhcjzqnvidvuo?.ValidEncounters;
        IEnumerable<Encounter> h_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQ12Date, CqlDate FollowupKCCQ12Date)?, Encounter>(f_, g_);
        bool? i_ = context.Operators.Exists<Encounter>(h_);
        return i_;
    }


    [CqlExpressionDefinition("Date KCCQ Domain Assessment Completed")]
    public IEnumerable<CqlDate> Date_KCCQ_Domain_Assessment_Completed(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Date_KCCQ_Domain_Assessment_Completed, Date_KCCQ_Domain_Assessment_Completed_Compute);

    private const long _cacheIndex_Date_KCCQ_Domain_Assessment_Completed = -2182281870167914021L;

    private IEnumerable<CqlDate> Date_KCCQ_Domain_Assessment_Completed_Compute(CqlContext context)
    {
        CqlCode a_ = this.Quality_of_life_score__KCCQ_(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
        IEnumerable<Observation> d_ = Status_1_15_000.Instance.isAssessmentPerformed(context, c_);
        CqlCode e_ = this.Symptom_stability_score__KCCQ_(context);
        IEnumerable<CqlCode> f_ = context.Operators.ToList<CqlCode>(e_);
        IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, f_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
        IEnumerable<Observation> h_ = Status_1_15_000.Instance.isAssessmentPerformed(context, g_);
        CqlCode i_ = this.Self_efficacy_score__KCCQ_(context);
        IEnumerable<CqlCode> j_ = context.Operators.ToList<CqlCode>(i_);
        IEnumerable<Observation> k_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, j_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
        IEnumerable<Observation> l_ = Status_1_15_000.Instance.isAssessmentPerformed(context, k_);
        CqlCode m_ = this.Total_symptom_score__KCCQ_(context);
        IEnumerable<CqlCode> n_ = context.Operators.ToList<CqlCode>(m_);
        IEnumerable<Observation> o_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, n_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
        IEnumerable<Observation> p_ = Status_1_15_000.Instance.isAssessmentPerformed(context, o_);
        CqlCode q_ = this.Physical_limitation_score__KCCQ_(context);
        IEnumerable<CqlCode> r_ = context.Operators.ToList<CqlCode>(q_);
        IEnumerable<Observation> s_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, r_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
        IEnumerable<Observation> t_ = Status_1_15_000.Instance.isAssessmentPerformed(context, s_);
        CqlCode u_ = this.Social_limitation_score__KCCQ_(context);
        IEnumerable<CqlCode> v_ = context.Operators.ToList<CqlCode>(u_);
        IEnumerable<Observation> w_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, v_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
        IEnumerable<Observation> x_ = Status_1_15_000.Instance.isAssessmentPerformed(context, w_);
        IEnumerable<ValueTuple<Observation, Observation, Observation, Observation, Observation, Observation>> y_ = context.Operators.CrossJoin<Observation, Observation, Observation, Observation, Observation, Observation>(d_, h_, l_, p_, t_, x_);

        (CqlTupleMetadata, Observation KCCQLifeQuality, Observation KCCQSymptomStability, Observation KCCQSelfEfficacy, Observation KCCQSymptoms, Observation KCCQPhysicalLimits, Observation KCCQSocialLimits)? z_(ValueTuple<Observation, Observation, Observation, Observation, Observation, Observation> _valueTuple) {
            (CqlTupleMetadata, Observation KCCQLifeQuality, Observation KCCQSymptomStability, Observation KCCQSelfEfficacy, Observation KCCQSymptoms, Observation KCCQPhysicalLimits, Observation KCCQSocialLimits)? ae_ = (CqlTupleMetadata_BbPMcXSJeOeGdRcaZWGYPhGBL, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3, _valueTuple.Item4, _valueTuple.Item5, _valueTuple.Item6);
            return ae_;
        }


        bool? aa_((CqlTupleMetadata, Observation KCCQLifeQuality, Observation KCCQSymptomStability, Observation KCCQSelfEfficacy, Observation KCCQSymptoms, Observation KCCQPhysicalLimits, Observation KCCQSocialLimits)? tuple_etfcawdpmcqfbnayqdmdqqsdn) {
            DataType af_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQLifeQuality?.Effective;
            object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
            CqlInterval<CqlDateTime> ah_ = QICoreCommon_4_0_000.Instance.toInterval(context, ag_);
            CqlDateTime ai_ = context.Operators.Start(ah_);
            CqlDate aj_ = context.Operators.DateFrom(ai_);
            DataType ak_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQSymptomStability?.Effective;
            object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
            CqlInterval<CqlDateTime> am_ = QICoreCommon_4_0_000.Instance.toInterval(context, al_);
            CqlDateTime an_ = context.Operators.Start(am_);
            CqlDate ao_ = context.Operators.DateFrom(an_);
            bool? ap_ = context.Operators.SameAs(aj_, ao_, "day");
            bool? aq_;
            // CQL 'and' (332:11-333:86): right operand skipped when left is false
            if (ap_ is false)
            {
                aq_ = false;
            }
            else
            {
                DataType az_ = (tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQSymptomStability as Observation)?.Value;
                object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                aq_ = ap_ & (!((bool?)(ba_ is null)));
            }
            bool? ar_;
            // CQL 'and' (332:11-334:62): right operand skipped when left is false
            if (aq_ is false)
            {
                ar_ = false;
            }
            else
            {
                DataType bb_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQLifeQuality?.Effective;
                object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                CqlInterval<CqlDateTime> bd_ = QICoreCommon_4_0_000.Instance.toInterval(context, bc_);
                CqlDateTime be_ = context.Operators.Start(bd_);
                CqlDate bf_ = context.Operators.DateFrom(be_);
                DataType bg_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQSelfEfficacy?.Effective;
                object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                CqlInterval<CqlDateTime> bi_ = QICoreCommon_4_0_000.Instance.toInterval(context, bh_);
                CqlDateTime bj_ = context.Operators.Start(bi_);
                CqlDate bk_ = context.Operators.DateFrom(bj_);
                bool? bl_ = context.Operators.SameAs(bf_, bk_, "day");
                ar_ = aq_ & bl_;
            }
            bool? as_;
            // CQL 'and' (332:11-335:82): right operand skipped when left is false
            if (ar_ is false)
            {
                as_ = false;
            }
            else
            {
                DataType bm_ = (tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQSelfEfficacy as Observation)?.Value;
                object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                as_ = ar_ & (!((bool?)(bn_ is null)));
            }
            bool? at_;
            // CQL 'and' (332:11-336:58): right operand skipped when left is false
            if (as_ is false)
            {
                at_ = false;
            }
            else
            {
                DataType bo_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQLifeQuality?.Effective;
                object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                CqlInterval<CqlDateTime> bq_ = QICoreCommon_4_0_000.Instance.toInterval(context, bp_);
                CqlDateTime br_ = context.Operators.Start(bq_);
                CqlDate bs_ = context.Operators.DateFrom(br_);
                DataType bt_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQSymptoms?.Effective;
                object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                CqlInterval<CqlDateTime> bv_ = QICoreCommon_4_0_000.Instance.toInterval(context, bu_);
                CqlDateTime bw_ = context.Operators.Start(bv_);
                CqlDate bx_ = context.Operators.DateFrom(bw_);
                bool? by_ = context.Operators.SameAs(bs_, bx_, "day");
                at_ = as_ & by_;
            }
            bool? au_;
            // CQL 'and' (332:11-337:78): right operand skipped when left is false
            if (at_ is false)
            {
                au_ = false;
            }
            else
            {
                DataType bz_ = (tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQSymptoms as Observation)?.Value;
                object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                au_ = at_ & (!((bool?)(ca_ is null)));
            }
            bool? av_;
            // CQL 'and' (332:11-338:64): right operand skipped when left is false
            if (au_ is false)
            {
                av_ = false;
            }
            else
            {
                DataType cb_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQLifeQuality?.Effective;
                object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                CqlInterval<CqlDateTime> cd_ = QICoreCommon_4_0_000.Instance.toInterval(context, cc_);
                CqlDateTime ce_ = context.Operators.Start(cd_);
                CqlDate cf_ = context.Operators.DateFrom(ce_);
                DataType cg_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQPhysicalLimits?.Effective;
                object ch_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cg_);
                CqlInterval<CqlDateTime> ci_ = QICoreCommon_4_0_000.Instance.toInterval(context, ch_);
                CqlDateTime cj_ = context.Operators.Start(ci_);
                CqlDate ck_ = context.Operators.DateFrom(cj_);
                bool? cl_ = context.Operators.SameAs(cf_, ck_, "day");
                av_ = au_ & cl_;
            }
            bool? aw_;
            // CQL 'and' (332:11-339:84): right operand skipped when left is false
            if (av_ is false)
            {
                aw_ = false;
            }
            else
            {
                DataType cm_ = (tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQPhysicalLimits as Observation)?.Value;
                object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                aw_ = av_ & (!((bool?)(cn_ is null)));
            }
            bool? ax_;
            // CQL 'and' (332:11-340:62): right operand skipped when left is false
            if (aw_ is false)
            {
                ax_ = false;
            }
            else
            {
                DataType co_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQLifeQuality?.Effective;
                object cp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, co_);
                CqlInterval<CqlDateTime> cq_ = QICoreCommon_4_0_000.Instance.toInterval(context, cp_);
                CqlDateTime cr_ = context.Operators.Start(cq_);
                CqlDate cs_ = context.Operators.DateFrom(cr_);
                DataType ct_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQSocialLimits?.Effective;
                object cu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ct_);
                CqlInterval<CqlDateTime> cv_ = QICoreCommon_4_0_000.Instance.toInterval(context, cu_);
                CqlDateTime cw_ = context.Operators.Start(cv_);
                CqlDate cx_ = context.Operators.DateFrom(cw_);
                bool? cy_ = context.Operators.SameAs(cs_, cx_, "day");
                ax_ = aw_ & cy_;
            }
            bool? ay_;
            // CQL 'and' (332:11-341:82): right operand skipped when left is false
            if (ax_ is false)
            {
                ay_ = false;
            }
            else
            {
                DataType cz_ = (tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQSocialLimits as Observation)?.Value;
                object da_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cz_);
                ay_ = ax_ & (!((bool?)(da_ is null)));
            }
            // CQL 'and' (332:5-342:81): right operand skipped when left is false
            if (ay_ is false)
            {
                return false;
            }
            else
            {
                DataType db_ = (tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQLifeQuality as Observation)?.Value;
                object dc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, db_);
                return ay_ & (!((bool?)(dc_ is null)));
            }
        }

        IEnumerable<(CqlTupleMetadata, Observation KCCQLifeQuality, Observation KCCQSymptomStability, Observation KCCQSelfEfficacy, Observation KCCQSymptoms, Observation KCCQPhysicalLimits, Observation KCCQSocialLimits)?> ab_ = context.Operators.SelectWhere<ValueTuple<Observation, Observation, Observation, Observation, Observation, Observation>, (CqlTupleMetadata, Observation KCCQLifeQuality, Observation KCCQSymptomStability, Observation KCCQSelfEfficacy, Observation KCCQSymptoms, Observation KCCQPhysicalLimits, Observation KCCQSocialLimits)?>(y_, z_, aa_);

        CqlDate ac_((CqlTupleMetadata, Observation KCCQLifeQuality, Observation KCCQSymptomStability, Observation KCCQSelfEfficacy, Observation KCCQSymptoms, Observation KCCQPhysicalLimits, Observation KCCQSocialLimits)? tuple_etfcawdpmcqfbnayqdmdqqsdn) {
            DataType dd_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQLifeQuality?.Effective;
            object de_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dd_);
            CqlInterval<CqlDateTime> df_ = QICoreCommon_4_0_000.Instance.toInterval(context, de_);
            CqlDateTime dg_ = context.Operators.Start(df_);
            CqlDate dh_ = context.Operators.DateFrom(dg_);
            return dh_;
        }

        IEnumerable<CqlDate> ad_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Observation KCCQLifeQuality, Observation KCCQSymptomStability, Observation KCCQSelfEfficacy, Observation KCCQSymptoms, Observation KCCQPhysicalLimits, Observation KCCQSocialLimits)?, CqlDate>(ab_, ac_);
        return ad_;
    }


    [CqlExpressionDefinition("Has Encounter with Initial and Follow Up KCCQ Domain Score Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_KCCQ_Domain_Score_Assessments(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Encounter_with_Initial_and_Follow_Up_KCCQ_Domain_Score_Assessments, Has_Encounter_with_Initial_and_Follow_Up_KCCQ_Domain_Score_Assessments_Compute);

    private const long _cacheIndex_Has_Encounter_with_Initial_and_Follow_Up_KCCQ_Domain_Score_Assessments = -2096359522954143043L;

    private bool? Has_Encounter_with_Initial_and_Follow_Up_KCCQ_Domain_Score_Assessments_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounters(context);
        IEnumerable<CqlDate> b_ = this.Date_KCCQ_Domain_Assessment_Completed(context);
        IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> c_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(a_, b_, b_);

        (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQAssessmentDate, CqlDate FollowupKCCQAssessmentDate)? d_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple) {
            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQAssessmentDate, CqlDate FollowupKCCQAssessmentDate)? j_ = (CqlTupleMetadata_HEFWLcHhCNCOQegEOfjWTXiGN, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return j_;
        }


        bool? e_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQAssessmentDate, CqlDate FollowupKCCQAssessmentDate)? tuple_hrluhbcfcsvnvrrnjajahdcea) {
            Period k_ = tuple_hrluhbcfcsvnvrrnjajahdcea?.ValidEncounters?.Period;
            CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
            CqlDateTime m_ = context.Operators.End(l_);
            CqlInterval<CqlDateTime> n_ = this.Measurement_Period(context);
            CqlDateTime o_ = context.Operators.End(n_);
            CqlQuantity p_ = context.Operators.Quantity(180m, "days");
            CqlDateTime q_ = context.Operators.Subtract(o_, p_);
            bool? r_ = context.Operators.SameOrBefore(m_, q_, "day");
            bool? s_;
            // CQL 'and' (312:13-313:103): right operand skipped when left is false
            if (r_ is false)
            {
                s_ = false;
            }
            else
            {
                CqlDateTime t_ = context.Operators.ConvertDateToDateTime(tuple_hrluhbcfcsvnvrrnjajahdcea?.InitialKCCQAssessmentDate);
                Period u_ = tuple_hrluhbcfcsvnvrrnjajahdcea?.ValidEncounters?.Period;
                CqlInterval<CqlDateTime> v_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, u_);
                CqlDateTime w_ = context.Operators.End(v_);
                CqlQuantity x_ = context.Operators.Quantity(14m, "days");
                CqlDateTime y_ = context.Operators.Subtract(w_, x_);
                CqlInterval<CqlDateTime> z_ = context.Operators.Interval(y_, w_, true, true);
                bool? aa_ = context.Operators.In<CqlDateTime>(t_, z_, "day");
                bool? ab_;
                // CQL 'and' (313:13-313:103): right operand skipped when left is false
                if (aa_ is false)
                {
                    ab_ = false;
                }
                else
                {
                    Period ac_ = tuple_hrluhbcfcsvnvrrnjajahdcea?.ValidEncounters?.Period;
                    CqlInterval<CqlDateTime> ad_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ac_);
                    CqlDateTime ae_ = context.Operators.End(ad_);
                    ab_ = aa_ & (!((bool?)(ae_ is null)));
                }
                s_ = r_ & ab_;
            }
            // CQL 'and' (312:7-314:166): right operand skipped when left is false
            if (s_ is false)
            {
                return false;
            }
            else
            {
                CqlDateTime af_ = context.Operators.ConvertDateToDateTime(tuple_hrluhbcfcsvnvrrnjajahdcea?.FollowupKCCQAssessmentDate);
                CqlDate ag_ = context.Operators.DateFrom(af_);
                CqlDateTime ah_ = context.Operators.ConvertDateToDateTime(tuple_hrluhbcfcsvnvrrnjajahdcea?.InitialKCCQAssessmentDate);
                CqlDate ai_ = context.Operators.DateFrom(ah_);
                CqlQuantity aj_ = context.Operators.Quantity(30m, "days");
                CqlDate ak_ = context.Operators.Add(ai_, aj_);
                CqlQuantity al_ = context.Operators.Quantity(180m, "days");
                CqlDate am_ = context.Operators.Add(ai_, al_);
                CqlInterval<CqlDate> an_ = context.Operators.Interval(ak_, am_, true, true);
                bool? ao_ = context.Operators.In<CqlDate>(ag_, an_, "day");
                return s_ & ao_;
            }
        }

        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQAssessmentDate, CqlDate FollowupKCCQAssessmentDate)?> f_ = context.Operators.SelectWhere<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQAssessmentDate, CqlDate FollowupKCCQAssessmentDate)?>(c_, d_, e_);
        Encounter g_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQAssessmentDate, CqlDate FollowupKCCQAssessmentDate)? tuple_hrluhbcfcsvnvrrnjajahdcea) => tuple_hrluhbcfcsvnvrrnjajahdcea?.ValidEncounters;
        IEnumerable<Encounter> h_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQAssessmentDate, CqlDate FollowupKCCQAssessmentDate)?, Encounter>(f_, g_);
        bool? i_ = context.Operators.Exists<Encounter>(h_);
        return i_;
    }


    [CqlExpressionDefinition("Date KCCQ Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_KCCQ_Total_Assessment_Completed(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Date_KCCQ_Total_Assessment_Completed, Date_KCCQ_Total_Assessment_Completed_Compute);

    private const long _cacheIndex_Date_KCCQ_Total_Assessment_Completed = 6106274396873857332L;

    private IEnumerable<CqlDate> Date_KCCQ_Total_Assessment_Completed_Compute(CqlContext context)
    {
        CqlCode a_ = this.Overall_summary_score__KCCQ_(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
        IEnumerable<Observation> d_ = Status_1_15_000.Instance.isAssessmentPerformed(context, c_);

        bool? e_(Observation KCCQSummaryScore) {
            DataType i_ = (KCCQSummaryScore as Observation)?.Value;
            object j_ = FHIRHelpers_4_4_000.Instance.ToValue(context, i_);
            return !((bool?)(j_ is null));
        }


        CqlDate f_(Observation KCCQSummaryScore) {
            DataType k_ = KCCQSummaryScore?.Effective;
            object l_ = FHIRHelpers_4_4_000.Instance.ToValue(context, k_);
            CqlInterval<CqlDateTime> m_ = QICoreCommon_4_0_000.Instance.toInterval(context, l_);
            CqlDateTime n_ = context.Operators.Start(m_);
            CqlDate o_ = context.Operators.DateFrom(n_);
            return o_;
        }

        IEnumerable<CqlDate> g_ = context.Operators.WhereSelect<Observation, CqlDate>(d_, e_, f_);
        IEnumerable<CqlDate> h_ = context.Operators.Distinct<CqlDate>(g_);
        return h_;
    }


    [CqlExpressionDefinition("Has Encounter with Initial and Follow Up KCCQ Total Score Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_KCCQ_Total_Score_Assessments(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Encounter_with_Initial_and_Follow_Up_KCCQ_Total_Score_Assessments, Has_Encounter_with_Initial_and_Follow_Up_KCCQ_Total_Score_Assessments_Compute);

    private const long _cacheIndex_Has_Encounter_with_Initial_and_Follow_Up_KCCQ_Total_Score_Assessments = -6324806271972964859L;

    private bool? Has_Encounter_with_Initial_and_Follow_Up_KCCQ_Total_Score_Assessments_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounters(context);
        IEnumerable<CqlDate> b_ = this.Date_KCCQ_Total_Assessment_Completed(context);
        IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> c_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(a_, b_, b_);

        (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQTotalScore, CqlDate FollowupKCCQTotalScore)? d_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple) {
            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQTotalScore, CqlDate FollowupKCCQTotalScore)? j_ = (CqlTupleMetadata_DggZKjEbQUfLADMDMBeASLDR, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return j_;
        }


        bool? e_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQTotalScore, CqlDate FollowupKCCQTotalScore)? tuple_dgrojeekdvizsvyisepdjhjgj) {
            Period k_ = tuple_dgrojeekdvizsvyisepdjhjgj?.ValidEncounters?.Period;
            CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
            CqlDateTime m_ = context.Operators.End(l_);
            CqlInterval<CqlDateTime> n_ = this.Measurement_Period(context);
            CqlDateTime o_ = context.Operators.End(n_);
            CqlQuantity p_ = context.Operators.Quantity(180m, "days");
            CqlDateTime q_ = context.Operators.Subtract(o_, p_);
            bool? r_ = context.Operators.SameOrBefore(m_, q_, "day");
            bool? s_;
            // CQL 'and' (355:13-356:99): right operand skipped when left is false
            if (r_ is false)
            {
                s_ = false;
            }
            else
            {
                CqlDateTime t_ = context.Operators.ConvertDateToDateTime(tuple_dgrojeekdvizsvyisepdjhjgj?.InitialKCCQTotalScore);
                Period u_ = tuple_dgrojeekdvizsvyisepdjhjgj?.ValidEncounters?.Period;
                CqlInterval<CqlDateTime> v_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, u_);
                CqlDateTime w_ = context.Operators.End(v_);
                CqlQuantity x_ = context.Operators.Quantity(14m, "days");
                CqlDateTime y_ = context.Operators.Subtract(w_, x_);
                CqlInterval<CqlDateTime> z_ = context.Operators.Interval(y_, w_, true, true);
                bool? aa_ = context.Operators.In<CqlDateTime>(t_, z_, "day");
                bool? ab_;
                // CQL 'and' (356:13-356:99): right operand skipped when left is false
                if (aa_ is false)
                {
                    ab_ = false;
                }
                else
                {
                    Period ac_ = tuple_dgrojeekdvizsvyisepdjhjgj?.ValidEncounters?.Period;
                    CqlInterval<CqlDateTime> ad_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ac_);
                    CqlDateTime ae_ = context.Operators.End(ad_);
                    ab_ = aa_ & (!((bool?)(ae_ is null)));
                }
                s_ = r_ & ab_;
            }
            // CQL 'and' (355:7-357:154): right operand skipped when left is false
            if (s_ is false)
            {
                return false;
            }
            else
            {
                CqlDateTime af_ = context.Operators.ConvertDateToDateTime(tuple_dgrojeekdvizsvyisepdjhjgj?.FollowupKCCQTotalScore);
                CqlDate ag_ = context.Operators.DateFrom(af_);
                CqlDateTime ah_ = context.Operators.ConvertDateToDateTime(tuple_dgrojeekdvizsvyisepdjhjgj?.InitialKCCQTotalScore);
                CqlDate ai_ = context.Operators.DateFrom(ah_);
                CqlQuantity aj_ = context.Operators.Quantity(30m, "days");
                CqlDate ak_ = context.Operators.Add(ai_, aj_);
                CqlQuantity al_ = context.Operators.Quantity(180m, "days");
                CqlDate am_ = context.Operators.Add(ai_, al_);
                CqlInterval<CqlDate> an_ = context.Operators.Interval(ak_, am_, true, true);
                bool? ao_ = context.Operators.In<CqlDate>(ag_, an_, "day");
                return s_ & ao_;
            }
        }

        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQTotalScore, CqlDate FollowupKCCQTotalScore)?> f_ = context.Operators.SelectWhere<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQTotalScore, CqlDate FollowupKCCQTotalScore)?>(c_, d_, e_);
        Encounter g_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQTotalScore, CqlDate FollowupKCCQTotalScore)? tuple_dgrojeekdvizsvyisepdjhjgj) => tuple_dgrojeekdvizsvyisepdjhjgj?.ValidEncounters;
        IEnumerable<Encounter> h_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQTotalScore, CqlDate FollowupKCCQTotalScore)?, Encounter>(f_, g_);
        bool? i_ = context.Operators.Exists<Encounter>(h_);
        return i_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = 2652104320779056033L;

    private bool? Numerator_Compute(CqlContext context)
    {
        bool? a_ = this.Has_Encounter_with_Initial_and_Follow_Up_PROMIS10_Assessments(context);
        bool? b_;
        // CQL 'or' (87:3-88:74): right operand skipped when left is true
        if (a_ is true)
        {
            b_ = true;
        }
        else
        {
            bool? j_ = this.Has_Encounter_with_Initial_and_Follow_Up_PROMIS29_Assessments(context);
            b_ = a_ | j_;
        }
        bool? c_;
        // CQL 'or' (87:3-89:78): right operand skipped when left is true
        if (b_ is true)
        {
            c_ = true;
        }
        else
        {
            bool? k_ = this.Has_Encounter_with_Initial_and_Follow_Up_VR12_Oblique_Assessments(context);
            c_ = b_ | k_;
        }
        bool? d_;
        // CQL 'or' (87:3-90:81): right operand skipped when left is true
        if (c_ is true)
        {
            d_ = true;
        }
        else
        {
            bool? l_ = this.Has_Encounter_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments(context);
            d_ = c_ | l_;
        }
        bool? e_;
        // CQL 'or' (87:3-91:78): right operand skipped when left is true
        if (d_ is true)
        {
            e_ = true;
        }
        else
        {
            bool? m_ = this.Has_Encounter_with_Initial_and_Follow_Up_VR36_Oblique_Assessments(context);
            e_ = d_ | m_;
        }
        bool? f_;
        // CQL 'or' (87:3-92:81): right operand skipped when left is true
        if (e_ is true)
        {
            f_ = true;
        }
        else
        {
            bool? n_ = this.Has_Encounter_with_Initial_and_Follow_Up_VR36_Orthogonal_Assessments(context);
            f_ = e_ | n_;
        }
        bool? g_;
        // CQL 'or' (87:3-93:71): right operand skipped when left is true
        if (f_ is true)
        {
            g_ = true;
        }
        else
        {
            bool? o_ = this.Has_Encounter_with_Initial_and_Follow_Up_MLHFQ_Assessments(context);
            g_ = f_ | o_;
        }
        bool? h_;
        // CQL 'or' (87:3-94:72): right operand skipped when left is true
        if (g_ is true)
        {
            h_ = true;
        }
        else
        {
            bool? p_ = this.Has_Encounter_with_Initial_and_Follow_Up_KCCQ12_Assessments(context);
            h_ = g_ | p_;
        }
        bool? i_;
        // CQL 'or' (87:3-95:83): right operand skipped when left is true
        if (h_ is true)
        {
            i_ = true;
        }
        else
        {
            bool? q_ = this.Has_Encounter_with_Initial_and_Follow_Up_KCCQ_Domain_Score_Assessments(context);
            i_ = h_ | q_;
        }
        // CQL 'or' (87:3-96:82): right operand skipped when left is true
        if (i_ is true)
        {
            return true;
        }
        else
        {
            bool? r_ = this.Has_Encounter_with_Initial_and_Follow_Up_KCCQ_Total_Score_Assessments(context);
            return i_ | r_;
        }
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private CMS90FHIRFSAforHeartFailure_1_0_000() {}

    public static CMS90FHIRFSAforHeartFailure_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS90FHIRFSAforHeartFailure";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, QICoreCommon_4_0_000.Instance, SupplementalDataElements_5_1_000.Instance, Hospice_6_18_000.Instance, Status_1_15_000.Instance];

    #endregion ILibrary Implementation

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
