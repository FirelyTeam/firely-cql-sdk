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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.0.0.0")]
[CqlLibrary("CMS90FHIRFSAforHeartFailure", "1.0.000")]
public partial class CMS90FHIRFSAforHeartFailure_1_0_000 : ILibrary, ISingleton<CMS90FHIRFSAforHeartFailure_1_0_000>
{
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

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<CqlInterval<CqlDateTime>>(-650903179446011642L, () => {
            CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
            CqlDateTime b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
            CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
            object d_ = context.ResolveParameter("CMS90FHIRFSAforHeartFailure-1.0.000", "Measurement Period", c_);
            return (CqlInterval<CqlDateTime>)d_;
        });


    #endregion Parameters

    #region Functions and Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<Patient>(-1669321019754182478L, () => {
            IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
            Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
            return b_;
        });


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(84564949379321772L, () => {
            (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
            return a_;
        });


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?>>(8582605658905008518L, () => {
            IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
            return a_;
        });


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(365259754375553276L, () => {
            (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
            return a_;
        });


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<CqlCode>(-4531448496698277885L, () => {
            CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
            return a_;
        });


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(8160197854541943299L, () => {
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
        });


    [CqlExpressionDefinition("Outpatient Encounters with at least one subsequent Outpatient Encounter during Measurement Period")]
    public IEnumerable<Encounter> Outpatient_Encounters_with_at_least_one_subsequent_Outpatient_Encounter_during_Measurement_Period(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(3299355288199571478L, () => {
            IEnumerable<Encounter> a_ = this.Qualifying_Encounters(context);

            IEnumerable<Encounter> b_(Encounter OfficeVisit1) {
                IEnumerable<Encounter> d_ = this.Qualifying_Encounters(context);

                bool? e_(Encounter OfficeVisit2) {
                    Period i_ = OfficeVisit2?.Period;
                    CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, i_);
                    CqlDateTime k_ = context.Operators.Start(j_);
                    Period l_ = OfficeVisit1?.Period;
                    CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
                    CqlDateTime n_ = context.Operators.End(m_);
                    CqlQuantity o_ = context.Operators.Quantity(1m, "day");
                    CqlDateTime p_ = context.Operators.Add(n_, o_);
                    bool? q_ = context.Operators.SameOrAfter(k_, p_, "day");
                    return q_;
                }

                IEnumerable<Encounter> f_ = context.Operators.Where<Encounter>(d_, e_);
                Encounter g_(Encounter OfficeVisit2) => OfficeVisit1;
                IEnumerable<Encounter> h_ = context.Operators.Select<Encounter, Encounter>(f_, g_);
                return h_;
            }

            IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
            return c_;
        });


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(-5068561849240932665L, () => {
            Patient a_ = this.Patient(context);
            Date b_ = a_?.BirthDateElement;
            string c_ = b_?.Value;
            CqlDate d_ = context.Operators.ConvertStringToDate(c_);
            CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
            CqlDateTime f_ = context.Operators.Start(e_);
            CqlDate g_ = context.Operators.DateFrom(f_);
            int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
            bool? i_ = context.Operators.GreaterOrEqual(h_, 18);
            CqlValueSet j_ = this.Heart_Failure(context);
            IEnumerable<Condition> k_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, j_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> m_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, j_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<object> n_ = context.Operators.Union<object>(k_ as IEnumerable<object>, m_ as IEnumerable<object>);
            IEnumerable<object> o_ = Status_1_15_000.Instance.verified(context, n_);

            bool? p_(object HeartFailure) {
                CqlInterval<CqlDateTime> w_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, HeartFailure);
                CqlInterval<CqlDateTime> x_ = this.Measurement_Period(context);
                bool? y_ = context.Operators.OverlapsBefore(w_, x_, "day");
                return y_;
            }

            IEnumerable<object> q_ = context.Operators.Where<object>(o_, p_);
            bool? r_ = context.Operators.Exists<object>(q_);
            bool? s_ = context.Operators.And(i_, r_);
            IEnumerable<Encounter> t_ = this.Outpatient_Encounters_with_at_least_one_subsequent_Outpatient_Encounter_during_Measurement_Period(context);
            bool? u_ = context.Operators.Exists<Encounter>(t_);
            bool? v_ = context.Operators.And(s_, u_);
            return v_;
        });


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(6741930247475943811L, () => {
            bool? a_ = this.Initial_Population(context);
            return a_;
        });


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(4543796399844502819L, () => {
            bool? a_ = Hospice_6_18_000.Instance.Has_Hospice_Services(context);
            CqlCode b_ = this.Severe_cognitive_impairment__finding_(context);
            IEnumerable<CqlCode> c_ = context.Operators.ToList<CqlCode>(b_);
            IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, c_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<CqlCode> f_ = context.Operators.ToList<CqlCode>(b_);
            IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, f_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<object> h_ = context.Operators.Union<object>(d_ as IEnumerable<object>, g_ as IEnumerable<object>);
            IEnumerable<object> i_ = Status_1_15_000.Instance.verified(context, h_);

            bool? j_(object SevereCognitiveImpairment) {
                CqlInterval<CqlDateTime> n_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, SevereCognitiveImpairment);
                CqlInterval<CqlDateTime> o_ = this.Measurement_Period(context);
                bool? p_ = context.Operators.Overlaps(n_, o_, "day");
                return p_;
            }

            IEnumerable<object> k_ = context.Operators.Where<object>(i_, j_);
            bool? l_ = context.Operators.Exists<object>(k_);
            bool? m_ = context.Operators.Or(a_, l_);
            return m_;
        });


    [CqlExpressionDefinition("Date PROMIS10 Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_PROMIS10_Total_Assessment_Completed(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<CqlDate>>(3566032284114220134L, () => {
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
                (CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)? q_ = (CqlTupleMetadata_DDTAOdcFieSJbGgRLLZPYbGQb, _valueTuple.Item1, _valueTuple.Item2);
                return q_;
            }

            IEnumerable<(CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?> k_ = context.Operators.Select<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?>(i_, j_);

            bool? l_((CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)? tuple_ddtaodcfiesjbggrllzpybgqb) {
                DataType r_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10MentalScore?.Effective;
                object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                CqlInterval<CqlDateTime> t_ = QICoreCommon_4_0_000.Instance.toInterval(context, s_);
                CqlDateTime u_ = context.Operators.Start(t_);
                CqlDate v_ = context.Operators.DateFrom(u_);
                DataType w_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10PhysicalScore?.Effective;
                object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                CqlInterval<CqlDateTime> y_ = QICoreCommon_4_0_000.Instance.toInterval(context, x_);
                CqlDateTime z_ = context.Operators.Start(y_);
                CqlDate aa_ = context.Operators.DateFrom(z_);
                bool? ab_ = context.Operators.SameAs(v_, aa_, "day");
                DataType ac_ = (tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10MentalScore as Observation)?.Value;
                object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                bool? ae_ = context.Operators.Not((bool?)(ad_ is null));
                bool? af_ = context.Operators.And(ab_, ae_);
                DataType ag_ = (tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10PhysicalScore as Observation)?.Value;
                object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                bool? ai_ = context.Operators.Not((bool?)(ah_ is null));
                bool? aj_ = context.Operators.And(af_, ai_);
                return aj_;
            }

            IEnumerable<(CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?> m_ = context.Operators.Where<(CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?>(k_, l_);

            CqlDate n_((CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)? tuple_ddtaodcfiesjbggrllzpybgqb) {
                DataType ak_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10MentalScore?.Effective;
                object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                CqlInterval<CqlDateTime> am_ = QICoreCommon_4_0_000.Instance.toInterval(context, al_);
                CqlDateTime an_ = context.Operators.Start(am_);
                CqlDate ao_ = context.Operators.DateFrom(an_);
                return ao_;
            }

            IEnumerable<CqlDate> o_ = context.Operators.Select<(CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?, CqlDate>(m_, n_);
            IEnumerable<CqlDate> p_ = context.Operators.Distinct<CqlDate>(o_);
            return p_;
        });


    [CqlExpressionDefinition("Has Encounter with Initial and Follow Up PROMIS10 Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_PROMIS10_Assessments(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(-7119418943023617715L, () => {
            IEnumerable<Encounter> a_ = this.Qualifying_Encounters(context);
            IEnumerable<CqlDate> b_ = this.Date_PROMIS10_Total_Assessment_Completed(context);
            IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> d_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(a_, b_, b_);

            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS10Date, CqlDate FollowupPROMIS10Date)? e_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple) {
                (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS10Date, CqlDate FollowupPROMIS10Date)? m_ = (CqlTupleMetadata_BGYjYGLNPKWAZTBCVAdLDDTMj, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
                return m_;
            }

            IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS10Date, CqlDate FollowupPROMIS10Date)?> f_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS10Date, CqlDate FollowupPROMIS10Date)?>(d_, e_);

            bool? g_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS10Date, CqlDate FollowupPROMIS10Date)? tuple_dzhwgxhmbfavmzfaszbeksohj) {
                Period n_ = tuple_dzhwgxhmbfavmzfaszbeksohj?.ValidEncounters?.Period;
                CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                CqlDateTime p_ = context.Operators.End(o_);
                CqlInterval<CqlDateTime> q_ = this.Measurement_Period(context);
                CqlDateTime r_ = context.Operators.End(q_);
                CqlQuantity s_ = context.Operators.Quantity(180m, "days");
                CqlDateTime t_ = context.Operators.Subtract(r_, s_);
                bool? u_ = context.Operators.SameOrBefore(p_, t_, "day");
                CqlDateTime v_ = context.Operators.ConvertDateToDateTime(tuple_dzhwgxhmbfavmzfaszbeksohj?.InitialPROMIS10Date);
                CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                CqlDateTime y_ = context.Operators.End(x_);
                CqlQuantity z_ = context.Operators.Quantity(14m, "days");
                CqlDateTime aa_ = context.Operators.Subtract(y_, z_);
                CqlInterval<CqlDateTime> ac_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                CqlDateTime ad_ = context.Operators.End(ac_);
                CqlInterval<CqlDateTime> ae_ = context.Operators.Interval(aa_, ad_, true, true);
                bool? af_ = context.Operators.In<CqlDateTime>(v_, ae_, "day");
                CqlInterval<CqlDateTime> ah_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                CqlDateTime ai_ = context.Operators.End(ah_);
                bool? aj_ = context.Operators.Not((bool?)(ai_ is null));
                bool? ak_ = context.Operators.And(af_, aj_);
                bool? al_ = context.Operators.And(u_, ak_);
                CqlDateTime am_ = context.Operators.ConvertDateToDateTime(tuple_dzhwgxhmbfavmzfaszbeksohj?.FollowupPROMIS10Date);
                CqlDate an_ = context.Operators.DateFrom(am_);
                CqlDate ap_ = context.Operators.DateFrom(v_);
                CqlQuantity aq_ = context.Operators.Quantity(30m, "days");
                CqlDate ar_ = context.Operators.Add(ap_, aq_);
                CqlDate at_ = context.Operators.DateFrom(v_);
                CqlDate av_ = context.Operators.Add(at_, s_);
                CqlInterval<CqlDate> aw_ = context.Operators.Interval(ar_, av_, true, true);
                bool? ax_ = context.Operators.In<CqlDate>(an_, aw_, "day");
                bool? ay_ = context.Operators.And(al_, ax_);
                return ay_;
            }

            IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS10Date, CqlDate FollowupPROMIS10Date)?> h_ = context.Operators.Where<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS10Date, CqlDate FollowupPROMIS10Date)?>(f_, g_);
            Encounter i_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS10Date, CqlDate FollowupPROMIS10Date)? tuple_dzhwgxhmbfavmzfaszbeksohj) => tuple_dzhwgxhmbfavmzfaszbeksohj?.ValidEncounters;
            IEnumerable<Encounter> j_ = context.Operators.Select<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS10Date, CqlDate FollowupPROMIS10Date)?, Encounter>(h_, i_);
            IEnumerable<Encounter> k_ = context.Operators.Distinct<Encounter>(j_);
            bool? l_ = context.Operators.Exists<Encounter>(k_);
            return l_;
        });


    [CqlExpressionDefinition("Date PROMIS29 Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_PROMIS29_Total_Assessment_Completed(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<CqlDate>>(-7228807294603665886L, () => {
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
                (CqlTupleMetadata, Observation Promis29Sleep, Observation Promis29SocialRoles, Observation Promis29Physical, Observation Promis29Pain, Observation Promis29Fatigue, Observation Promis29Depression, Observation Promis29Anxiety)? ak_ = (CqlTupleMetadata_DBUJFOVGBcbhIQPWARNQHKUaX, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3, _valueTuple.Item4, _valueTuple.Item5, _valueTuple.Item6, _valueTuple.Item7);
                return ak_;
            }

            IEnumerable<(CqlTupleMetadata, Observation Promis29Sleep, Observation Promis29SocialRoles, Observation Promis29Physical, Observation Promis29Pain, Observation Promis29Fatigue, Observation Promis29Depression, Observation Promis29Anxiety)?> ae_ = context.Operators.Select<ValueTuple<Observation, Observation, Observation, Observation, Observation, Observation, Observation>, (CqlTupleMetadata, Observation Promis29Sleep, Observation Promis29SocialRoles, Observation Promis29Physical, Observation Promis29Pain, Observation Promis29Fatigue, Observation Promis29Depression, Observation Promis29Anxiety)?>(ac_, ad_);

            bool? af_((CqlTupleMetadata, Observation Promis29Sleep, Observation Promis29SocialRoles, Observation Promis29Physical, Observation Promis29Pain, Observation Promis29Fatigue, Observation Promis29Depression, Observation Promis29Anxiety)? tuple_cbgpsarvwrsewlglehinjanim) {
                DataType al_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Sleep?.Effective;
                object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                CqlInterval<CqlDateTime> an_ = QICoreCommon_4_0_000.Instance.toInterval(context, am_);
                CqlDateTime ao_ = context.Operators.Start(an_);
                CqlDate ap_ = context.Operators.DateFrom(ao_);
                DataType aq_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29SocialRoles?.Effective;
                object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                CqlInterval<CqlDateTime> as_ = QICoreCommon_4_0_000.Instance.toInterval(context, ar_);
                CqlDateTime at_ = context.Operators.Start(as_);
                CqlDate au_ = context.Operators.DateFrom(at_);
                bool? av_ = context.Operators.SameAs(ap_, au_, "day");
                DataType aw_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29SocialRoles?.Value;
                object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                bool? ay_ = context.Operators.Not((bool?)(ax_ is null));
                bool? az_ = context.Operators.And(av_, ay_);
                object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                CqlInterval<CqlDateTime> bc_ = QICoreCommon_4_0_000.Instance.toInterval(context, bb_);
                CqlDateTime bd_ = context.Operators.Start(bc_);
                CqlDate be_ = context.Operators.DateFrom(bd_);
                DataType bf_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Physical?.Effective;
                object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                CqlInterval<CqlDateTime> bh_ = QICoreCommon_4_0_000.Instance.toInterval(context, bg_);
                CqlDateTime bi_ = context.Operators.Start(bh_);
                CqlDate bj_ = context.Operators.DateFrom(bi_);
                bool? bk_ = context.Operators.SameAs(be_, bj_, "day");
                bool? bl_ = context.Operators.And(az_, bk_);
                DataType bm_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Physical?.Value;
                object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                bool? bo_ = context.Operators.Not((bool?)(bn_ is null));
                bool? bp_ = context.Operators.And(bl_, bo_);
                object br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                CqlInterval<CqlDateTime> bs_ = QICoreCommon_4_0_000.Instance.toInterval(context, br_);
                CqlDateTime bt_ = context.Operators.Start(bs_);
                CqlDate bu_ = context.Operators.DateFrom(bt_);
                DataType bv_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Pain?.Effective;
                object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                CqlInterval<CqlDateTime> bx_ = QICoreCommon_4_0_000.Instance.toInterval(context, bw_);
                CqlDateTime by_ = context.Operators.Start(bx_);
                CqlDate bz_ = context.Operators.DateFrom(by_);
                bool? ca_ = context.Operators.SameAs(bu_, bz_, "day");
                bool? cb_ = context.Operators.And(bp_, ca_);
                DataType cc_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Pain?.Value;
                object cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                bool? ce_ = context.Operators.Not((bool?)(cd_ is null));
                bool? cf_ = context.Operators.And(cb_, ce_);
                object ch_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                CqlInterval<CqlDateTime> ci_ = QICoreCommon_4_0_000.Instance.toInterval(context, ch_);
                CqlDateTime cj_ = context.Operators.Start(ci_);
                CqlDate ck_ = context.Operators.DateFrom(cj_);
                DataType cl_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Fatigue?.Effective;
                object cm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cl_);
                CqlInterval<CqlDateTime> cn_ = QICoreCommon_4_0_000.Instance.toInterval(context, cm_);
                CqlDateTime co_ = context.Operators.Start(cn_);
                CqlDate cp_ = context.Operators.DateFrom(co_);
                bool? cq_ = context.Operators.SameAs(ck_, cp_, "day");
                bool? cr_ = context.Operators.And(cf_, cq_);
                DataType cs_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Fatigue?.Value;
                object ct_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cs_);
                bool? cu_ = context.Operators.Not((bool?)(ct_ is null));
                bool? cv_ = context.Operators.And(cr_, cu_);
                object cx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                CqlInterval<CqlDateTime> cy_ = QICoreCommon_4_0_000.Instance.toInterval(context, cx_);
                CqlDateTime cz_ = context.Operators.Start(cy_);
                CqlDate da_ = context.Operators.DateFrom(cz_);
                DataType db_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Depression?.Effective;
                object dc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, db_);
                CqlInterval<CqlDateTime> dd_ = QICoreCommon_4_0_000.Instance.toInterval(context, dc_);
                CqlDateTime de_ = context.Operators.Start(dd_);
                CqlDate df_ = context.Operators.DateFrom(de_);
                bool? dg_ = context.Operators.SameAs(da_, df_, "day");
                bool? dh_ = context.Operators.And(cv_, dg_);
                DataType di_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Depression?.Value;
                object dj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, di_);
                bool? dk_ = context.Operators.Not((bool?)(dj_ is null));
                bool? dl_ = context.Operators.And(dh_, dk_);
                object dn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                CqlInterval<CqlDateTime> do_ = QICoreCommon_4_0_000.Instance.toInterval(context, dn_);
                CqlDateTime dp_ = context.Operators.Start(do_);
                CqlDate dq_ = context.Operators.DateFrom(dp_);
                DataType dr_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Anxiety?.Effective;
                object ds_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dr_);
                CqlInterval<CqlDateTime> dt_ = QICoreCommon_4_0_000.Instance.toInterval(context, ds_);
                CqlDateTime du_ = context.Operators.Start(dt_);
                CqlDate dv_ = context.Operators.DateFrom(du_);
                bool? dw_ = context.Operators.SameAs(dq_, dv_, "day");
                bool? dx_ = context.Operators.And(dl_, dw_);
                DataType dy_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Anxiety?.Value;
                object dz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dy_);
                bool? ea_ = context.Operators.Not((bool?)(dz_ is null));
                bool? eb_ = context.Operators.And(dx_, ea_);
                DataType ec_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Sleep?.Value;
                object ed_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ec_);
                bool? ee_ = context.Operators.Not((bool?)(ed_ is null));
                bool? ef_ = context.Operators.And(eb_, ee_);
                return ef_;
            }

            IEnumerable<(CqlTupleMetadata, Observation Promis29Sleep, Observation Promis29SocialRoles, Observation Promis29Physical, Observation Promis29Pain, Observation Promis29Fatigue, Observation Promis29Depression, Observation Promis29Anxiety)?> ag_ = context.Operators.Where<(CqlTupleMetadata, Observation Promis29Sleep, Observation Promis29SocialRoles, Observation Promis29Physical, Observation Promis29Pain, Observation Promis29Fatigue, Observation Promis29Depression, Observation Promis29Anxiety)?>(ae_, af_);

            CqlDate ah_((CqlTupleMetadata, Observation Promis29Sleep, Observation Promis29SocialRoles, Observation Promis29Physical, Observation Promis29Pain, Observation Promis29Fatigue, Observation Promis29Depression, Observation Promis29Anxiety)? tuple_cbgpsarvwrsewlglehinjanim) {
                DataType eg_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Sleep?.Effective;
                object eh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eg_);
                CqlInterval<CqlDateTime> ei_ = QICoreCommon_4_0_000.Instance.toInterval(context, eh_);
                CqlDateTime ej_ = context.Operators.Start(ei_);
                CqlDate ek_ = context.Operators.DateFrom(ej_);
                return ek_;
            }

            IEnumerable<CqlDate> ai_ = context.Operators.Select<(CqlTupleMetadata, Observation Promis29Sleep, Observation Promis29SocialRoles, Observation Promis29Physical, Observation Promis29Pain, Observation Promis29Fatigue, Observation Promis29Depression, Observation Promis29Anxiety)?, CqlDate>(ag_, ah_);
            IEnumerable<CqlDate> aj_ = context.Operators.Distinct<CqlDate>(ai_);
            return aj_;
        });


    [CqlExpressionDefinition("Has Encounter with Initial and Follow Up PROMIS29 Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_PROMIS29_Assessments(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(-8148014470304297646L, () => {
            IEnumerable<Encounter> a_ = this.Qualifying_Encounters(context);
            IEnumerable<CqlDate> b_ = this.Date_PROMIS29_Total_Assessment_Completed(context);
            IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> d_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(a_, b_, b_);

            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS29Date, CqlDate FollowupPROMIS29Date)? e_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple) {
                (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS29Date, CqlDate FollowupPROMIS29Date)? m_ = (CqlTupleMetadata_DSZKEYVbCINNIeAQiZdVaEJhG, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
                return m_;
            }

            IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS29Date, CqlDate FollowupPROMIS29Date)?> f_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS29Date, CqlDate FollowupPROMIS29Date)?>(d_, e_);

            bool? g_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS29Date, CqlDate FollowupPROMIS29Date)? tuple_kmpntxjuhkpbcwgftqigieao) {
                Period n_ = tuple_kmpntxjuhkpbcwgftqigieao?.ValidEncounters?.Period;
                CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                CqlDateTime p_ = context.Operators.End(o_);
                CqlInterval<CqlDateTime> q_ = this.Measurement_Period(context);
                CqlDateTime r_ = context.Operators.End(q_);
                CqlQuantity s_ = context.Operators.Quantity(180m, "days");
                CqlDateTime t_ = context.Operators.Subtract(r_, s_);
                bool? u_ = context.Operators.SameOrBefore(p_, t_, "day");
                CqlDateTime v_ = context.Operators.ConvertDateToDateTime(tuple_kmpntxjuhkpbcwgftqigieao?.InitialPROMIS29Date);
                CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                CqlDateTime y_ = context.Operators.End(x_);
                CqlQuantity z_ = context.Operators.Quantity(14m, "days");
                CqlDateTime aa_ = context.Operators.Subtract(y_, z_);
                CqlInterval<CqlDateTime> ac_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                CqlDateTime ad_ = context.Operators.End(ac_);
                CqlInterval<CqlDateTime> ae_ = context.Operators.Interval(aa_, ad_, true, true);
                bool? af_ = context.Operators.In<CqlDateTime>(v_, ae_, "day");
                CqlInterval<CqlDateTime> ah_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                CqlDateTime ai_ = context.Operators.End(ah_);
                bool? aj_ = context.Operators.Not((bool?)(ai_ is null));
                bool? ak_ = context.Operators.And(af_, aj_);
                bool? al_ = context.Operators.And(u_, ak_);
                CqlDateTime am_ = context.Operators.ConvertDateToDateTime(tuple_kmpntxjuhkpbcwgftqigieao?.FollowupPROMIS29Date);
                CqlDate an_ = context.Operators.DateFrom(am_);
                CqlDate ap_ = context.Operators.DateFrom(v_);
                CqlQuantity aq_ = context.Operators.Quantity(30m, "days");
                CqlDate ar_ = context.Operators.Add(ap_, aq_);
                CqlDate at_ = context.Operators.DateFrom(v_);
                CqlDate av_ = context.Operators.Add(at_, s_);
                CqlInterval<CqlDate> aw_ = context.Operators.Interval(ar_, av_, true, true);
                bool? ax_ = context.Operators.In<CqlDate>(an_, aw_, "day");
                bool? ay_ = context.Operators.And(al_, ax_);
                return ay_;
            }

            IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS29Date, CqlDate FollowupPROMIS29Date)?> h_ = context.Operators.Where<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS29Date, CqlDate FollowupPROMIS29Date)?>(f_, g_);
            Encounter i_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS29Date, CqlDate FollowupPROMIS29Date)? tuple_kmpntxjuhkpbcwgftqigieao) => tuple_kmpntxjuhkpbcwgftqigieao?.ValidEncounters;
            IEnumerable<Encounter> j_ = context.Operators.Select<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS29Date, CqlDate FollowupPROMIS29Date)?, Encounter>(h_, i_);
            IEnumerable<Encounter> k_ = context.Operators.Distinct<Encounter>(j_);
            bool? l_ = context.Operators.Exists<Encounter>(k_);
            return l_;
        });


    [CqlExpressionDefinition("Date VR12 Oblique Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_VR12_Oblique_Total_Assessment_Completed(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<CqlDate>>(5285028890419299069L, () => {
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
                (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? q_ = (CqlTupleMetadata_GAdRFKRaHUUGJcVHWQWRUjhRH, _valueTuple.Item1, _valueTuple.Item2);
                return q_;
            }

            IEnumerable<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?> k_ = context.Operators.Select<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?>(i_, j_);

            bool? l_((CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? tuple_gadrfkrahuugjcvhwqwrujhrh) {
                DataType r_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Effective;
                object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                CqlInterval<CqlDateTime> t_ = QICoreCommon_4_0_000.Instance.toInterval(context, s_);
                CqlDateTime u_ = context.Operators.Start(t_);
                CqlDate v_ = context.Operators.DateFrom(u_);
                DataType w_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Effective;
                object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                CqlInterval<CqlDateTime> y_ = QICoreCommon_4_0_000.Instance.toInterval(context, x_);
                CqlDateTime z_ = context.Operators.Start(y_);
                CqlDate aa_ = context.Operators.DateFrom(z_);
                bool? ab_ = context.Operators.SameAs(v_, aa_, "day");
                DataType ac_ = (tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment as Observation)?.Value;
                object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                bool? ae_ = context.Operators.Not((bool?)(ad_ is null));
                bool? af_ = context.Operators.And(ab_, ae_);
                DataType ag_ = (tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment as Observation)?.Value;
                object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                bool? ai_ = context.Operators.Not((bool?)(ah_ is null));
                bool? aj_ = context.Operators.And(af_, ai_);
                return aj_;
            }

            IEnumerable<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?> m_ = context.Operators.Where<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?>(k_, l_);

            CqlDate n_((CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? tuple_gadrfkrahuugjcvhwqwrujhrh) {
                DataType ak_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Effective;
                object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                CqlInterval<CqlDateTime> am_ = QICoreCommon_4_0_000.Instance.toInterval(context, al_);
                CqlDateTime an_ = context.Operators.Start(am_);
                CqlDate ao_ = context.Operators.DateFrom(an_);
                return ao_;
            }

            IEnumerable<CqlDate> o_ = context.Operators.Select<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?, CqlDate>(m_, n_);
            IEnumerable<CqlDate> p_ = context.Operators.Distinct<CqlDate>(o_);
            return p_;
        });


    [CqlExpressionDefinition("Has Encounter with Initial and Follow Up VR12 Oblique Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_VR12_Oblique_Assessments(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(-9101247183797375897L, () => {
            IEnumerable<Encounter> a_ = this.Qualifying_Encounters(context);
            IEnumerable<CqlDate> b_ = this.Date_VR12_Oblique_Total_Assessment_Completed(context);
            IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> d_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(a_, b_, b_);

            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12ObliqueDate, CqlDate FollowupVR12ObliqueDate)? e_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple) {
                (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12ObliqueDate, CqlDate FollowupVR12ObliqueDate)? m_ = (CqlTupleMetadata_FQKGdEYLiDFGMNAUAMETIHUQT, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
                return m_;
            }

            IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12ObliqueDate, CqlDate FollowupVR12ObliqueDate)?> f_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12ObliqueDate, CqlDate FollowupVR12ObliqueDate)?>(d_, e_);

            bool? g_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12ObliqueDate, CqlDate FollowupVR12ObliqueDate)? tuple_fppktdiagiekhptnsbacpswh) {
                Period n_ = tuple_fppktdiagiekhptnsbacpswh?.ValidEncounters?.Period;
                CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                CqlDateTime p_ = context.Operators.End(o_);
                CqlInterval<CqlDateTime> q_ = this.Measurement_Period(context);
                CqlDateTime r_ = context.Operators.End(q_);
                CqlQuantity s_ = context.Operators.Quantity(180m, "days");
                CqlDateTime t_ = context.Operators.Subtract(r_, s_);
                bool? u_ = context.Operators.SameOrBefore(p_, t_, "day");
                CqlDateTime v_ = context.Operators.ConvertDateToDateTime(tuple_fppktdiagiekhptnsbacpswh?.InitialVR12ObliqueDate);
                CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                CqlDateTime y_ = context.Operators.End(x_);
                CqlQuantity z_ = context.Operators.Quantity(14m, "days");
                CqlDateTime aa_ = context.Operators.Subtract(y_, z_);
                CqlInterval<CqlDateTime> ac_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                CqlDateTime ad_ = context.Operators.End(ac_);
                CqlInterval<CqlDateTime> ae_ = context.Operators.Interval(aa_, ad_, true, true);
                bool? af_ = context.Operators.In<CqlDateTime>(v_, ae_, "day");
                CqlInterval<CqlDateTime> ah_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                CqlDateTime ai_ = context.Operators.End(ah_);
                bool? aj_ = context.Operators.Not((bool?)(ai_ is null));
                bool? ak_ = context.Operators.And(af_, aj_);
                bool? al_ = context.Operators.And(u_, ak_);
                CqlDateTime am_ = context.Operators.ConvertDateToDateTime(tuple_fppktdiagiekhptnsbacpswh?.FollowupVR12ObliqueDate);
                CqlDate an_ = context.Operators.DateFrom(am_);
                CqlDate ap_ = context.Operators.DateFrom(v_);
                CqlQuantity aq_ = context.Operators.Quantity(30m, "days");
                CqlDate ar_ = context.Operators.Add(ap_, aq_);
                CqlDate at_ = context.Operators.DateFrom(v_);
                CqlDate av_ = context.Operators.Add(at_, s_);
                CqlInterval<CqlDate> aw_ = context.Operators.Interval(ar_, av_, true, true);
                bool? ax_ = context.Operators.In<CqlDate>(an_, aw_, "day");
                bool? ay_ = context.Operators.And(al_, ax_);
                return ay_;
            }

            IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12ObliqueDate, CqlDate FollowupVR12ObliqueDate)?> h_ = context.Operators.Where<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12ObliqueDate, CqlDate FollowupVR12ObliqueDate)?>(f_, g_);
            Encounter i_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12ObliqueDate, CqlDate FollowupVR12ObliqueDate)? tuple_fppktdiagiekhptnsbacpswh) => tuple_fppktdiagiekhptnsbacpswh?.ValidEncounters;
            IEnumerable<Encounter> j_ = context.Operators.Select<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12ObliqueDate, CqlDate FollowupVR12ObliqueDate)?, Encounter>(h_, i_);
            IEnumerable<Encounter> k_ = context.Operators.Distinct<Encounter>(j_);
            bool? l_ = context.Operators.Exists<Encounter>(k_);
            return l_;
        });


    [CqlExpressionDefinition("Date VR12 Orthogonal Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_VR12_Orthogonal_Total_Assessment_Completed(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<CqlDate>>(-4308956976409684029L, () => {
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
                (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? q_ = (CqlTupleMetadata_GAdRFKRaHUUGJcVHWQWRUjhRH, _valueTuple.Item1, _valueTuple.Item2);
                return q_;
            }

            IEnumerable<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?> k_ = context.Operators.Select<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?>(i_, j_);

            bool? l_((CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? tuple_gadrfkrahuugjcvhwqwrujhrh) {
                DataType r_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Effective;
                object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                CqlInterval<CqlDateTime> t_ = QICoreCommon_4_0_000.Instance.toInterval(context, s_);
                CqlDateTime u_ = context.Operators.Start(t_);
                CqlDate v_ = context.Operators.DateFrom(u_);
                DataType w_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Effective;
                object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                CqlInterval<CqlDateTime> y_ = QICoreCommon_4_0_000.Instance.toInterval(context, x_);
                CqlDateTime z_ = context.Operators.Start(y_);
                CqlDate aa_ = context.Operators.DateFrom(z_);
                bool? ab_ = context.Operators.SameAs(v_, aa_, "day");
                DataType ac_ = (tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment as Observation)?.Value;
                object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                bool? ae_ = context.Operators.Not((bool?)(ad_ is null));
                bool? af_ = context.Operators.And(ab_, ae_);
                DataType ag_ = (tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment as Observation)?.Value;
                object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                bool? ai_ = context.Operators.Not((bool?)(ah_ is null));
                bool? aj_ = context.Operators.And(af_, ai_);
                return aj_;
            }

            IEnumerable<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?> m_ = context.Operators.Where<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?>(k_, l_);

            CqlDate n_((CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? tuple_gadrfkrahuugjcvhwqwrujhrh) {
                DataType ak_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Effective;
                object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                CqlInterval<CqlDateTime> am_ = QICoreCommon_4_0_000.Instance.toInterval(context, al_);
                CqlDateTime an_ = context.Operators.Start(am_);
                CqlDate ao_ = context.Operators.DateFrom(an_);
                return ao_;
            }

            IEnumerable<CqlDate> o_ = context.Operators.Select<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?, CqlDate>(m_, n_);
            IEnumerable<CqlDate> p_ = context.Operators.Distinct<CqlDate>(o_);
            return p_;
        });


    [CqlExpressionDefinition("Has Encounter with Initial and Follow Up VR12 Orthogonal Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(-3523837020378714173L, () => {
            IEnumerable<Encounter> a_ = this.Qualifying_Encounters(context);
            IEnumerable<CqlDate> b_ = this.Date_VR12_Orthogonal_Total_Assessment_Completed(context);
            IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> d_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(a_, b_, b_);

            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12OrthogonalDate, CqlDate FollowupVR12OrthogonalDate)? e_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple) {
                (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12OrthogonalDate, CqlDate FollowupVR12OrthogonalDate)? m_ = (CqlTupleMetadata_HSSAQEFQAOXLjUcOKGgicELWB, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
                return m_;
            }

            IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12OrthogonalDate, CqlDate FollowupVR12OrthogonalDate)?> f_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12OrthogonalDate, CqlDate FollowupVR12OrthogonalDate)?>(d_, e_);

            bool? g_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12OrthogonalDate, CqlDate FollowupVR12OrthogonalDate)? tuple_fansvmjaedmvsdoyrozxdlsai) {
                Period n_ = tuple_fansvmjaedmvsdoyrozxdlsai?.ValidEncounters?.Period;
                CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                CqlDateTime p_ = context.Operators.End(o_);
                CqlInterval<CqlDateTime> q_ = this.Measurement_Period(context);
                CqlDateTime r_ = context.Operators.End(q_);
                CqlQuantity s_ = context.Operators.Quantity(180m, "days");
                CqlDateTime t_ = context.Operators.Subtract(r_, s_);
                bool? u_ = context.Operators.SameOrBefore(p_, t_, "day");
                CqlDateTime v_ = context.Operators.ConvertDateToDateTime(tuple_fansvmjaedmvsdoyrozxdlsai?.InitialVR12OrthogonalDate);
                CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                CqlDateTime y_ = context.Operators.End(x_);
                CqlQuantity z_ = context.Operators.Quantity(14m, "days");
                CqlDateTime aa_ = context.Operators.Subtract(y_, z_);
                CqlInterval<CqlDateTime> ac_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                CqlDateTime ad_ = context.Operators.End(ac_);
                CqlInterval<CqlDateTime> ae_ = context.Operators.Interval(aa_, ad_, true, true);
                bool? af_ = context.Operators.In<CqlDateTime>(v_, ae_, "day");
                CqlInterval<CqlDateTime> ah_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                CqlDateTime ai_ = context.Operators.End(ah_);
                bool? aj_ = context.Operators.Not((bool?)(ai_ is null));
                bool? ak_ = context.Operators.And(af_, aj_);
                bool? al_ = context.Operators.And(u_, ak_);
                CqlDateTime am_ = context.Operators.ConvertDateToDateTime(tuple_fansvmjaedmvsdoyrozxdlsai?.FollowupVR12OrthogonalDate);
                CqlDate an_ = context.Operators.DateFrom(am_);
                CqlDate ap_ = context.Operators.DateFrom(v_);
                CqlQuantity aq_ = context.Operators.Quantity(30m, "days");
                CqlDate ar_ = context.Operators.Add(ap_, aq_);
                CqlDate at_ = context.Operators.DateFrom(v_);
                CqlDate av_ = context.Operators.Add(at_, s_);
                CqlInterval<CqlDate> aw_ = context.Operators.Interval(ar_, av_, true, true);
                bool? ax_ = context.Operators.In<CqlDate>(an_, aw_, "day");
                bool? ay_ = context.Operators.And(al_, ax_);
                return ay_;
            }

            IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12OrthogonalDate, CqlDate FollowupVR12OrthogonalDate)?> h_ = context.Operators.Where<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12OrthogonalDate, CqlDate FollowupVR12OrthogonalDate)?>(f_, g_);
            Encounter i_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12OrthogonalDate, CqlDate FollowupVR12OrthogonalDate)? tuple_fansvmjaedmvsdoyrozxdlsai) => tuple_fansvmjaedmvsdoyrozxdlsai?.ValidEncounters;
            IEnumerable<Encounter> j_ = context.Operators.Select<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12OrthogonalDate, CqlDate FollowupVR12OrthogonalDate)?, Encounter>(h_, i_);
            IEnumerable<Encounter> k_ = context.Operators.Distinct<Encounter>(j_);
            bool? l_ = context.Operators.Exists<Encounter>(k_);
            return l_;
        });


    [CqlExpressionDefinition("Date VR36 Oblique Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_VR36_Oblique_Total_Assessment_Completed(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<CqlDate>>(156742284346193099L, () => {
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
                (CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)? q_ = (CqlTupleMetadata_DUcFTCLcQEWDGGQdFCWTHFaUK, _valueTuple.Item1, _valueTuple.Item2);
                return q_;
            }

            IEnumerable<(CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?> k_ = context.Operators.Select<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?>(i_, j_);

            bool? l_((CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)? tuple_ducftclcqewdggqdfcwthfauk) {
                DataType r_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36MentalAssessment?.Effective;
                object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                CqlInterval<CqlDateTime> t_ = QICoreCommon_4_0_000.Instance.toInterval(context, s_);
                CqlDateTime u_ = context.Operators.Start(t_);
                CqlDate v_ = context.Operators.DateFrom(u_);
                DataType w_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36PhysicalAssessment?.Effective;
                object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                CqlInterval<CqlDateTime> y_ = QICoreCommon_4_0_000.Instance.toInterval(context, x_);
                CqlDateTime z_ = context.Operators.Start(y_);
                CqlDate aa_ = context.Operators.DateFrom(z_);
                bool? ab_ = context.Operators.SameAs(v_, aa_, "day");
                DataType ac_ = (tuple_ducftclcqewdggqdfcwthfauk?.VR36MentalAssessment as Observation)?.Value;
                object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                bool? ae_ = context.Operators.Not((bool?)(ad_ is null));
                bool? af_ = context.Operators.And(ab_, ae_);
                DataType ag_ = (tuple_ducftclcqewdggqdfcwthfauk?.VR36PhysicalAssessment as Observation)?.Value;
                object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                bool? ai_ = context.Operators.Not((bool?)(ah_ is null));
                bool? aj_ = context.Operators.And(af_, ai_);
                return aj_;
            }

            IEnumerable<(CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?> m_ = context.Operators.Where<(CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?>(k_, l_);

            CqlDate n_((CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)? tuple_ducftclcqewdggqdfcwthfauk) {
                DataType ak_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36MentalAssessment?.Effective;
                object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                CqlInterval<CqlDateTime> am_ = QICoreCommon_4_0_000.Instance.toInterval(context, al_);
                CqlDateTime an_ = context.Operators.Start(am_);
                CqlDate ao_ = context.Operators.DateFrom(an_);
                return ao_;
            }

            IEnumerable<CqlDate> o_ = context.Operators.Select<(CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?, CqlDate>(m_, n_);
            IEnumerable<CqlDate> p_ = context.Operators.Distinct<CqlDate>(o_);
            return p_;
        });


    [CqlExpressionDefinition("Has Encounter with Initial and Follow Up VR36 Oblique Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_VR36_Oblique_Assessments(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(-4830229598614441452L, () => {
            IEnumerable<Encounter> a_ = this.Qualifying_Encounters(context);
            IEnumerable<CqlDate> b_ = this.Date_VR36_Oblique_Total_Assessment_Completed(context);
            IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> d_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(a_, b_, b_);

            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36ObliqueDate, CqlDate FollowupVR36ObliqueDate)? e_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple) {
                (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36ObliqueDate, CqlDate FollowupVR36ObliqueDate)? m_ = (CqlTupleMetadata_HQfcMfhQUSTNYMWSgJHiFeahQ, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
                return m_;
            }

            IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36ObliqueDate, CqlDate FollowupVR36ObliqueDate)?> f_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36ObliqueDate, CqlDate FollowupVR36ObliqueDate)?>(d_, e_);

            bool? g_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36ObliqueDate, CqlDate FollowupVR36ObliqueDate)? tuple_elxicyhrdpyzpqyjphdifbiga) {
                Period n_ = tuple_elxicyhrdpyzpqyjphdifbiga?.ValidEncounters?.Period;
                CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                CqlDateTime p_ = context.Operators.End(o_);
                CqlInterval<CqlDateTime> q_ = this.Measurement_Period(context);
                CqlDateTime r_ = context.Operators.End(q_);
                CqlQuantity s_ = context.Operators.Quantity(180m, "days");
                CqlDateTime t_ = context.Operators.Subtract(r_, s_);
                bool? u_ = context.Operators.SameOrBefore(p_, t_, "day");
                CqlDateTime v_ = context.Operators.ConvertDateToDateTime(tuple_elxicyhrdpyzpqyjphdifbiga?.InitialVR36ObliqueDate);
                CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                CqlDateTime y_ = context.Operators.End(x_);
                CqlQuantity z_ = context.Operators.Quantity(14m, "days");
                CqlDateTime aa_ = context.Operators.Subtract(y_, z_);
                CqlInterval<CqlDateTime> ac_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                CqlDateTime ad_ = context.Operators.End(ac_);
                CqlInterval<CqlDateTime> ae_ = context.Operators.Interval(aa_, ad_, true, true);
                bool? af_ = context.Operators.In<CqlDateTime>(v_, ae_, "day");
                CqlInterval<CqlDateTime> ah_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                CqlDateTime ai_ = context.Operators.End(ah_);
                bool? aj_ = context.Operators.Not((bool?)(ai_ is null));
                bool? ak_ = context.Operators.And(af_, aj_);
                bool? al_ = context.Operators.And(u_, ak_);
                CqlDateTime am_ = context.Operators.ConvertDateToDateTime(tuple_elxicyhrdpyzpqyjphdifbiga?.FollowupVR36ObliqueDate);
                CqlDate an_ = context.Operators.DateFrom(am_);
                CqlDate ap_ = context.Operators.DateFrom(v_);
                CqlQuantity aq_ = context.Operators.Quantity(30m, "days");
                CqlDate ar_ = context.Operators.Add(ap_, aq_);
                CqlDate at_ = context.Operators.DateFrom(v_);
                CqlDate av_ = context.Operators.Add(at_, s_);
                CqlInterval<CqlDate> aw_ = context.Operators.Interval(ar_, av_, true, true);
                bool? ax_ = context.Operators.In<CqlDate>(an_, aw_, "day");
                bool? ay_ = context.Operators.And(al_, ax_);
                return ay_;
            }

            IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36ObliqueDate, CqlDate FollowupVR36ObliqueDate)?> h_ = context.Operators.Where<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36ObliqueDate, CqlDate FollowupVR36ObliqueDate)?>(f_, g_);
            Encounter i_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36ObliqueDate, CqlDate FollowupVR36ObliqueDate)? tuple_elxicyhrdpyzpqyjphdifbiga) => tuple_elxicyhrdpyzpqyjphdifbiga?.ValidEncounters;
            IEnumerable<Encounter> j_ = context.Operators.Select<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36ObliqueDate, CqlDate FollowupVR36ObliqueDate)?, Encounter>(h_, i_);
            IEnumerable<Encounter> k_ = context.Operators.Distinct<Encounter>(j_);
            bool? l_ = context.Operators.Exists<Encounter>(k_);
            return l_;
        });


    [CqlExpressionDefinition("Date VR36 Orthogonal Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_VR36_Orthogonal_Total_Assessment_Completed(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<CqlDate>>(-6950216527866873198L, () => {
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
                (CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)? q_ = (CqlTupleMetadata_DUcFTCLcQEWDGGQdFCWTHFaUK, _valueTuple.Item1, _valueTuple.Item2);
                return q_;
            }

            IEnumerable<(CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?> k_ = context.Operators.Select<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?>(i_, j_);

            bool? l_((CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)? tuple_ducftclcqewdggqdfcwthfauk) {
                DataType r_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36MentalAssessment?.Effective;
                object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                CqlInterval<CqlDateTime> t_ = QICoreCommon_4_0_000.Instance.toInterval(context, s_);
                CqlDateTime u_ = context.Operators.Start(t_);
                CqlDate v_ = context.Operators.DateFrom(u_);
                DataType w_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36PhysicalAssessment?.Effective;
                object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                CqlInterval<CqlDateTime> y_ = QICoreCommon_4_0_000.Instance.toInterval(context, x_);
                CqlDateTime z_ = context.Operators.Start(y_);
                CqlDate aa_ = context.Operators.DateFrom(z_);
                bool? ab_ = context.Operators.SameAs(v_, aa_, "day");
                DataType ac_ = (tuple_ducftclcqewdggqdfcwthfauk?.VR36MentalAssessment as Observation)?.Value;
                object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                bool? ae_ = context.Operators.Not((bool?)(ad_ is null));
                bool? af_ = context.Operators.And(ab_, ae_);
                DataType ag_ = (tuple_ducftclcqewdggqdfcwthfauk?.VR36PhysicalAssessment as Observation)?.Value;
                object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                bool? ai_ = context.Operators.Not((bool?)(ah_ is null));
                bool? aj_ = context.Operators.And(af_, ai_);
                return aj_;
            }

            IEnumerable<(CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?> m_ = context.Operators.Where<(CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?>(k_, l_);

            CqlDate n_((CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)? tuple_ducftclcqewdggqdfcwthfauk) {
                DataType ak_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36MentalAssessment?.Effective;
                object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                CqlInterval<CqlDateTime> am_ = QICoreCommon_4_0_000.Instance.toInterval(context, al_);
                CqlDateTime an_ = context.Operators.Start(am_);
                CqlDate ao_ = context.Operators.DateFrom(an_);
                return ao_;
            }

            IEnumerable<CqlDate> o_ = context.Operators.Select<(CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?, CqlDate>(m_, n_);
            IEnumerable<CqlDate> p_ = context.Operators.Distinct<CqlDate>(o_);
            return p_;
        });


    [CqlExpressionDefinition("Has Encounter with Initial and Follow Up VR36 Orthogonal Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_VR36_Orthogonal_Assessments(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(6268914066794038861L, () => {
            IEnumerable<Encounter> a_ = this.Qualifying_Encounters(context);
            IEnumerable<CqlDate> b_ = this.Date_VR36_Orthogonal_Total_Assessment_Completed(context);
            IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> d_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(a_, b_, b_);

            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36OrthogonalDate, CqlDate FollowupVR36OrthogonalDate)? e_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple) {
                (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36OrthogonalDate, CqlDate FollowupVR36OrthogonalDate)? m_ = (CqlTupleMetadata_BFZHWdOOROjSjFSECHcQiaZZZ, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
                return m_;
            }

            IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36OrthogonalDate, CqlDate FollowupVR36OrthogonalDate)?> f_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36OrthogonalDate, CqlDate FollowupVR36OrthogonalDate)?>(d_, e_);

            bool? g_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36OrthogonalDate, CqlDate FollowupVR36OrthogonalDate)? tuple_fucqujadjizabihdffformht) {
                Period n_ = tuple_fucqujadjizabihdffformht?.ValidEncounters?.Period;
                CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                CqlDateTime p_ = context.Operators.End(o_);
                CqlInterval<CqlDateTime> q_ = this.Measurement_Period(context);
                CqlDateTime r_ = context.Operators.End(q_);
                CqlQuantity s_ = context.Operators.Quantity(180m, "days");
                CqlDateTime t_ = context.Operators.Subtract(r_, s_);
                bool? u_ = context.Operators.SameOrBefore(p_, t_, "day");
                CqlDateTime v_ = context.Operators.ConvertDateToDateTime(tuple_fucqujadjizabihdffformht?.InitialVR36OrthogonalDate);
                CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                CqlDateTime y_ = context.Operators.End(x_);
                CqlQuantity z_ = context.Operators.Quantity(14m, "days");
                CqlDateTime aa_ = context.Operators.Subtract(y_, z_);
                CqlInterval<CqlDateTime> ac_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                CqlDateTime ad_ = context.Operators.End(ac_);
                CqlInterval<CqlDateTime> ae_ = context.Operators.Interval(aa_, ad_, true, true);
                bool? af_ = context.Operators.In<CqlDateTime>(v_, ae_, "day");
                CqlInterval<CqlDateTime> ah_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                CqlDateTime ai_ = context.Operators.End(ah_);
                bool? aj_ = context.Operators.Not((bool?)(ai_ is null));
                bool? ak_ = context.Operators.And(af_, aj_);
                bool? al_ = context.Operators.And(u_, ak_);
                CqlDateTime am_ = context.Operators.ConvertDateToDateTime(tuple_fucqujadjizabihdffformht?.FollowupVR36OrthogonalDate);
                CqlDate an_ = context.Operators.DateFrom(am_);
                CqlDate ap_ = context.Operators.DateFrom(v_);
                CqlQuantity aq_ = context.Operators.Quantity(30m, "days");
                CqlDate ar_ = context.Operators.Add(ap_, aq_);
                CqlDate at_ = context.Operators.DateFrom(v_);
                CqlDate av_ = context.Operators.Add(at_, s_);
                CqlInterval<CqlDate> aw_ = context.Operators.Interval(ar_, av_, true, true);
                bool? ax_ = context.Operators.In<CqlDate>(an_, aw_, "day");
                bool? ay_ = context.Operators.And(al_, ax_);
                return ay_;
            }

            IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36OrthogonalDate, CqlDate FollowupVR36OrthogonalDate)?> h_ = context.Operators.Where<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36OrthogonalDate, CqlDate FollowupVR36OrthogonalDate)?>(f_, g_);
            Encounter i_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36OrthogonalDate, CqlDate FollowupVR36OrthogonalDate)? tuple_fucqujadjizabihdffformht) => tuple_fucqujadjizabihdffformht?.ValidEncounters;
            IEnumerable<Encounter> j_ = context.Operators.Select<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36OrthogonalDate, CqlDate FollowupVR36OrthogonalDate)?, Encounter>(h_, i_);
            IEnumerable<Encounter> k_ = context.Operators.Distinct<Encounter>(j_);
            bool? l_ = context.Operators.Exists<Encounter>(k_);
            return l_;
        });


    [CqlExpressionDefinition("Date MLHFQ Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_MLHFQ_Total_Assessment_Completed(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<CqlDate>>(7426662041656437075L, () => {
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
                (CqlTupleMetadata, Observation MLHFQPhysical, Observation MLHFQEmotional)? q_ = (CqlTupleMetadata_EBLWeAeedHPAfOJXKPZJKSCUf, _valueTuple.Item1, _valueTuple.Item2);
                return q_;
            }

            IEnumerable<(CqlTupleMetadata, Observation MLHFQPhysical, Observation MLHFQEmotional)?> k_ = context.Operators.Select<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation MLHFQPhysical, Observation MLHFQEmotional)?>(i_, j_);

            bool? l_((CqlTupleMetadata, Observation MLHFQPhysical, Observation MLHFQEmotional)? tuple_fnofxckadaeusjerhbdqfoshe) {
                DataType r_ = tuple_fnofxckadaeusjerhbdqfoshe?.MLHFQPhysical?.Effective;
                object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                CqlInterval<CqlDateTime> t_ = QICoreCommon_4_0_000.Instance.toInterval(context, s_);
                CqlDateTime u_ = context.Operators.Start(t_);
                CqlDate v_ = context.Operators.DateFrom(u_);
                DataType w_ = tuple_fnofxckadaeusjerhbdqfoshe?.MLHFQEmotional?.Effective;
                object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                CqlInterval<CqlDateTime> y_ = QICoreCommon_4_0_000.Instance.toInterval(context, x_);
                CqlDateTime z_ = context.Operators.Start(y_);
                CqlDate aa_ = context.Operators.DateFrom(z_);
                bool? ab_ = context.Operators.SameAs(v_, aa_, "day");
                DataType ac_ = (tuple_fnofxckadaeusjerhbdqfoshe?.MLHFQPhysical as Observation)?.Value;
                object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                bool? ae_ = context.Operators.Not((bool?)(ad_ is null));
                bool? af_ = context.Operators.And(ab_, ae_);
                DataType ag_ = (tuple_fnofxckadaeusjerhbdqfoshe?.MLHFQEmotional as Observation)?.Value;
                object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                bool? ai_ = context.Operators.Not((bool?)(ah_ is null));
                bool? aj_ = context.Operators.And(af_, ai_);
                return aj_;
            }

            IEnumerable<(CqlTupleMetadata, Observation MLHFQPhysical, Observation MLHFQEmotional)?> m_ = context.Operators.Where<(CqlTupleMetadata, Observation MLHFQPhysical, Observation MLHFQEmotional)?>(k_, l_);

            CqlDate n_((CqlTupleMetadata, Observation MLHFQPhysical, Observation MLHFQEmotional)? tuple_fnofxckadaeusjerhbdqfoshe) {
                DataType ak_ = tuple_fnofxckadaeusjerhbdqfoshe?.MLHFQPhysical?.Effective;
                object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                CqlInterval<CqlDateTime> am_ = QICoreCommon_4_0_000.Instance.toInterval(context, al_);
                CqlDateTime an_ = context.Operators.Start(am_);
                CqlDate ao_ = context.Operators.DateFrom(an_);
                return ao_;
            }

            IEnumerable<CqlDate> o_ = context.Operators.Select<(CqlTupleMetadata, Observation MLHFQPhysical, Observation MLHFQEmotional)?, CqlDate>(m_, n_);
            IEnumerable<CqlDate> p_ = context.Operators.Distinct<CqlDate>(o_);
            return p_;
        });


    [CqlExpressionDefinition("Has Encounter with Initial and Follow Up MLHFQ Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_MLHFQ_Assessments(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(-2626207006591928399L, () => {
            IEnumerable<Encounter> a_ = this.Qualifying_Encounters(context);
            IEnumerable<CqlDate> b_ = this.Date_MLHFQ_Total_Assessment_Completed(context);
            IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> d_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(a_, b_, b_);

            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialMLHFQDate, CqlDate FollowupMLHFQDate)? e_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple) {
                (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialMLHFQDate, CqlDate FollowupMLHFQDate)? m_ = (CqlTupleMetadata_CcaWSNDiVeaLebVKKWWWiBcEU, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
                return m_;
            }

            IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialMLHFQDate, CqlDate FollowupMLHFQDate)?> f_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialMLHFQDate, CqlDate FollowupMLHFQDate)?>(d_, e_);

            bool? g_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialMLHFQDate, CqlDate FollowupMLHFQDate)? tuple_ncdawctnmbfmtibmihsfbaig) {
                Period n_ = tuple_ncdawctnmbfmtibmihsfbaig?.ValidEncounters?.Period;
                CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                CqlDateTime p_ = context.Operators.End(o_);
                CqlInterval<CqlDateTime> q_ = this.Measurement_Period(context);
                CqlDateTime r_ = context.Operators.End(q_);
                CqlQuantity s_ = context.Operators.Quantity(180m, "days");
                CqlDateTime t_ = context.Operators.Subtract(r_, s_);
                bool? u_ = context.Operators.SameOrBefore(p_, t_, "day");
                CqlDateTime v_ = context.Operators.ConvertDateToDateTime(tuple_ncdawctnmbfmtibmihsfbaig?.InitialMLHFQDate);
                CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                CqlDateTime y_ = context.Operators.End(x_);
                CqlQuantity z_ = context.Operators.Quantity(14m, "days");
                CqlDateTime aa_ = context.Operators.Subtract(y_, z_);
                CqlInterval<CqlDateTime> ac_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                CqlDateTime ad_ = context.Operators.End(ac_);
                CqlInterval<CqlDateTime> ae_ = context.Operators.Interval(aa_, ad_, true, true);
                bool? af_ = context.Operators.In<CqlDateTime>(v_, ae_, "day");
                CqlInterval<CqlDateTime> ah_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                CqlDateTime ai_ = context.Operators.End(ah_);
                bool? aj_ = context.Operators.Not((bool?)(ai_ is null));
                bool? ak_ = context.Operators.And(af_, aj_);
                bool? al_ = context.Operators.And(u_, ak_);
                CqlDateTime am_ = context.Operators.ConvertDateToDateTime(tuple_ncdawctnmbfmtibmihsfbaig?.FollowupMLHFQDate);
                CqlDate an_ = context.Operators.DateFrom(am_);
                CqlDate ap_ = context.Operators.DateFrom(v_);
                CqlQuantity aq_ = context.Operators.Quantity(30m, "days");
                CqlDate ar_ = context.Operators.Add(ap_, aq_);
                CqlDate at_ = context.Operators.DateFrom(v_);
                CqlDate av_ = context.Operators.Add(at_, s_);
                CqlInterval<CqlDate> aw_ = context.Operators.Interval(ar_, av_, true, true);
                bool? ax_ = context.Operators.In<CqlDate>(an_, aw_, "day");
                bool? ay_ = context.Operators.And(al_, ax_);
                return ay_;
            }

            IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialMLHFQDate, CqlDate FollowupMLHFQDate)?> h_ = context.Operators.Where<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialMLHFQDate, CqlDate FollowupMLHFQDate)?>(f_, g_);
            Encounter i_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialMLHFQDate, CqlDate FollowupMLHFQDate)? tuple_ncdawctnmbfmtibmihsfbaig) => tuple_ncdawctnmbfmtibmihsfbaig?.ValidEncounters;
            IEnumerable<Encounter> j_ = context.Operators.Select<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialMLHFQDate, CqlDate FollowupMLHFQDate)?, Encounter>(h_, i_);
            IEnumerable<Encounter> k_ = context.Operators.Distinct<Encounter>(j_);
            bool? l_ = context.Operators.Exists<Encounter>(k_);
            return l_;
        });


    [CqlExpressionDefinition("Date KCCQ12 Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_KCCQ12_Total_Assessment_Completed(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<CqlDate>>(-213750493608688425L, () => {
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
                (CqlTupleMetadata, Observation KCCQ12Item, Observation KCCQ12Summary)? q_ = (CqlTupleMetadata_DFKXORghhYafccUSbQaMfNTDj, _valueTuple.Item1, _valueTuple.Item2);
                return q_;
            }

            IEnumerable<(CqlTupleMetadata, Observation KCCQ12Item, Observation KCCQ12Summary)?> k_ = context.Operators.Select<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation KCCQ12Item, Observation KCCQ12Summary)?>(i_, j_);

            bool? l_((CqlTupleMetadata, Observation KCCQ12Item, Observation KCCQ12Summary)? tuple_dfkxorghhyafccusbqamfntdj) {
                DataType r_ = tuple_dfkxorghhyafccusbqamfntdj?.KCCQ12Item?.Effective;
                object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                CqlInterval<CqlDateTime> t_ = QICoreCommon_4_0_000.Instance.toInterval(context, s_);
                CqlDateTime u_ = context.Operators.Start(t_);
                CqlDate v_ = context.Operators.DateFrom(u_);
                DataType w_ = tuple_dfkxorghhyafccusbqamfntdj?.KCCQ12Summary?.Effective;
                object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                CqlInterval<CqlDateTime> y_ = QICoreCommon_4_0_000.Instance.toInterval(context, x_);
                CqlDateTime z_ = context.Operators.Start(y_);
                CqlDate aa_ = context.Operators.DateFrom(z_);
                bool? ab_ = context.Operators.SameAs(v_, aa_, "day");
                DataType ac_ = (tuple_dfkxorghhyafccusbqamfntdj?.KCCQ12Item as Observation)?.Value;
                object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                bool? ae_ = context.Operators.Not((bool?)(ad_ is null));
                bool? af_ = context.Operators.And(ab_, ae_);
                DataType ag_ = (tuple_dfkxorghhyafccusbqamfntdj?.KCCQ12Summary as Observation)?.Value;
                object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                bool? ai_ = context.Operators.Not((bool?)(ah_ is null));
                bool? aj_ = context.Operators.And(af_, ai_);
                return aj_;
            }

            IEnumerable<(CqlTupleMetadata, Observation KCCQ12Item, Observation KCCQ12Summary)?> m_ = context.Operators.Where<(CqlTupleMetadata, Observation KCCQ12Item, Observation KCCQ12Summary)?>(k_, l_);

            CqlDate n_((CqlTupleMetadata, Observation KCCQ12Item, Observation KCCQ12Summary)? tuple_dfkxorghhyafccusbqamfntdj) {
                DataType ak_ = tuple_dfkxorghhyafccusbqamfntdj?.KCCQ12Item?.Effective;
                object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                CqlInterval<CqlDateTime> am_ = QICoreCommon_4_0_000.Instance.toInterval(context, al_);
                CqlDateTime an_ = context.Operators.Start(am_);
                CqlDate ao_ = context.Operators.DateFrom(an_);
                return ao_;
            }

            IEnumerable<CqlDate> o_ = context.Operators.Select<(CqlTupleMetadata, Observation KCCQ12Item, Observation KCCQ12Summary)?, CqlDate>(m_, n_);
            IEnumerable<CqlDate> p_ = context.Operators.Distinct<CqlDate>(o_);
            return p_;
        });


    [CqlExpressionDefinition("Has Encounter with Initial and Follow Up KCCQ12 Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_KCCQ12_Assessments(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(-6010909731121068185L, () => {
            IEnumerable<Encounter> a_ = this.Qualifying_Encounters(context);
            IEnumerable<CqlDate> b_ = this.Date_KCCQ12_Total_Assessment_Completed(context);
            IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> d_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(a_, b_, b_);

            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQ12Date, CqlDate FollowupKCCQ12Date)? e_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple) {
                (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQ12Date, CqlDate FollowupKCCQ12Date)? m_ = (CqlTupleMetadata_EQQLFFBVIbLIQLiZDNfeYdMU, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
                return m_;
            }

            IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQ12Date, CqlDate FollowupKCCQ12Date)?> f_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQ12Date, CqlDate FollowupKCCQ12Date)?>(d_, e_);

            bool? g_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQ12Date, CqlDate FollowupKCCQ12Date)? tuple_eoahgtwwdfqijhcjzqnvidvuo) {
                Period n_ = tuple_eoahgtwwdfqijhcjzqnvidvuo?.ValidEncounters?.Period;
                CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                CqlDateTime p_ = context.Operators.End(o_);
                CqlInterval<CqlDateTime> q_ = this.Measurement_Period(context);
                CqlDateTime r_ = context.Operators.End(q_);
                CqlQuantity s_ = context.Operators.Quantity(180m, "days");
                CqlDateTime t_ = context.Operators.Subtract(r_, s_);
                bool? u_ = context.Operators.SameOrBefore(p_, t_, "day");
                CqlDateTime v_ = context.Operators.ConvertDateToDateTime(tuple_eoahgtwwdfqijhcjzqnvidvuo?.InitialKCCQ12Date);
                CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                CqlDateTime y_ = context.Operators.End(x_);
                CqlQuantity z_ = context.Operators.Quantity(14m, "days");
                CqlDateTime aa_ = context.Operators.Subtract(y_, z_);
                CqlInterval<CqlDateTime> ac_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                CqlDateTime ad_ = context.Operators.End(ac_);
                CqlInterval<CqlDateTime> ae_ = context.Operators.Interval(aa_, ad_, true, true);
                bool? af_ = context.Operators.In<CqlDateTime>(v_, ae_, "day");
                CqlInterval<CqlDateTime> ah_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                CqlDateTime ai_ = context.Operators.End(ah_);
                bool? aj_ = context.Operators.Not((bool?)(ai_ is null));
                bool? ak_ = context.Operators.And(af_, aj_);
                bool? al_ = context.Operators.And(u_, ak_);
                CqlDateTime am_ = context.Operators.ConvertDateToDateTime(tuple_eoahgtwwdfqijhcjzqnvidvuo?.FollowupKCCQ12Date);
                CqlDate an_ = context.Operators.DateFrom(am_);
                CqlDate ap_ = context.Operators.DateFrom(v_);
                CqlQuantity aq_ = context.Operators.Quantity(30m, "days");
                CqlDate ar_ = context.Operators.Add(ap_, aq_);
                CqlDate at_ = context.Operators.DateFrom(v_);
                CqlDate av_ = context.Operators.Add(at_, s_);
                CqlInterval<CqlDate> aw_ = context.Operators.Interval(ar_, av_, true, true);
                bool? ax_ = context.Operators.In<CqlDate>(an_, aw_, "day");
                bool? ay_ = context.Operators.And(al_, ax_);
                return ay_;
            }

            IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQ12Date, CqlDate FollowupKCCQ12Date)?> h_ = context.Operators.Where<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQ12Date, CqlDate FollowupKCCQ12Date)?>(f_, g_);
            Encounter i_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQ12Date, CqlDate FollowupKCCQ12Date)? tuple_eoahgtwwdfqijhcjzqnvidvuo) => tuple_eoahgtwwdfqijhcjzqnvidvuo?.ValidEncounters;
            IEnumerable<Encounter> j_ = context.Operators.Select<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQ12Date, CqlDate FollowupKCCQ12Date)?, Encounter>(h_, i_);
            IEnumerable<Encounter> k_ = context.Operators.Distinct<Encounter>(j_);
            bool? l_ = context.Operators.Exists<Encounter>(k_);
            return l_;
        });


    [CqlExpressionDefinition("Date KCCQ Domain Assessment Completed")]
    public IEnumerable<CqlDate> Date_KCCQ_Domain_Assessment_Completed(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<CqlDate>>(-2182281870167914021L, () => {
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
                (CqlTupleMetadata, Observation KCCQLifeQuality, Observation KCCQSymptomStability, Observation KCCQSelfEfficacy, Observation KCCQSymptoms, Observation KCCQPhysicalLimits, Observation KCCQSocialLimits)? ag_ = (CqlTupleMetadata_BbPMcXSJeOeGdRcaZWGYPhGBL, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3, _valueTuple.Item4, _valueTuple.Item5, _valueTuple.Item6);
                return ag_;
            }

            IEnumerable<(CqlTupleMetadata, Observation KCCQLifeQuality, Observation KCCQSymptomStability, Observation KCCQSelfEfficacy, Observation KCCQSymptoms, Observation KCCQPhysicalLimits, Observation KCCQSocialLimits)?> aa_ = context.Operators.Select<ValueTuple<Observation, Observation, Observation, Observation, Observation, Observation>, (CqlTupleMetadata, Observation KCCQLifeQuality, Observation KCCQSymptomStability, Observation KCCQSelfEfficacy, Observation KCCQSymptoms, Observation KCCQPhysicalLimits, Observation KCCQSocialLimits)?>(y_, z_);

            bool? ab_((CqlTupleMetadata, Observation KCCQLifeQuality, Observation KCCQSymptomStability, Observation KCCQSelfEfficacy, Observation KCCQSymptoms, Observation KCCQPhysicalLimits, Observation KCCQSocialLimits)? tuple_etfcawdpmcqfbnayqdmdqqsdn) {
                DataType ah_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQLifeQuality?.Effective;
                object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                CqlInterval<CqlDateTime> aj_ = QICoreCommon_4_0_000.Instance.toInterval(context, ai_);
                CqlDateTime ak_ = context.Operators.Start(aj_);
                CqlDate al_ = context.Operators.DateFrom(ak_);
                DataType am_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQSymptomStability?.Effective;
                object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                CqlInterval<CqlDateTime> ao_ = QICoreCommon_4_0_000.Instance.toInterval(context, an_);
                CqlDateTime ap_ = context.Operators.Start(ao_);
                CqlDate aq_ = context.Operators.DateFrom(ap_);
                bool? ar_ = context.Operators.SameAs(al_, aq_, "day");
                DataType as_ = (tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQSymptomStability as Observation)?.Value;
                object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                bool? au_ = context.Operators.Not((bool?)(at_ is null));
                bool? av_ = context.Operators.And(ar_, au_);
                object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                CqlInterval<CqlDateTime> ay_ = QICoreCommon_4_0_000.Instance.toInterval(context, ax_);
                CqlDateTime az_ = context.Operators.Start(ay_);
                CqlDate ba_ = context.Operators.DateFrom(az_);
                DataType bb_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQSelfEfficacy?.Effective;
                object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                CqlInterval<CqlDateTime> bd_ = QICoreCommon_4_0_000.Instance.toInterval(context, bc_);
                CqlDateTime be_ = context.Operators.Start(bd_);
                CqlDate bf_ = context.Operators.DateFrom(be_);
                bool? bg_ = context.Operators.SameAs(ba_, bf_, "day");
                bool? bh_ = context.Operators.And(av_, bg_);
                DataType bi_ = (tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQSelfEfficacy as Observation)?.Value;
                object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                bool? bk_ = context.Operators.Not((bool?)(bj_ is null));
                bool? bl_ = context.Operators.And(bh_, bk_);
                object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                CqlInterval<CqlDateTime> bo_ = QICoreCommon_4_0_000.Instance.toInterval(context, bn_);
                CqlDateTime bp_ = context.Operators.Start(bo_);
                CqlDate bq_ = context.Operators.DateFrom(bp_);
                DataType br_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQSymptoms?.Effective;
                object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
                CqlInterval<CqlDateTime> bt_ = QICoreCommon_4_0_000.Instance.toInterval(context, bs_);
                CqlDateTime bu_ = context.Operators.Start(bt_);
                CqlDate bv_ = context.Operators.DateFrom(bu_);
                bool? bw_ = context.Operators.SameAs(bq_, bv_, "day");
                bool? bx_ = context.Operators.And(bl_, bw_);
                DataType by_ = (tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQSymptoms as Observation)?.Value;
                object bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);
                bool? ca_ = context.Operators.Not((bool?)(bz_ is null));
                bool? cb_ = context.Operators.And(bx_, ca_);
                object cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                CqlInterval<CqlDateTime> ce_ = QICoreCommon_4_0_000.Instance.toInterval(context, cd_);
                CqlDateTime cf_ = context.Operators.Start(ce_);
                CqlDate cg_ = context.Operators.DateFrom(cf_);
                DataType ch_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQPhysicalLimits?.Effective;
                object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                CqlInterval<CqlDateTime> cj_ = QICoreCommon_4_0_000.Instance.toInterval(context, ci_);
                CqlDateTime ck_ = context.Operators.Start(cj_);
                CqlDate cl_ = context.Operators.DateFrom(ck_);
                bool? cm_ = context.Operators.SameAs(cg_, cl_, "day");
                bool? cn_ = context.Operators.And(cb_, cm_);
                DataType co_ = (tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQPhysicalLimits as Observation)?.Value;
                object cp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, co_);
                bool? cq_ = context.Operators.Not((bool?)(cp_ is null));
                bool? cr_ = context.Operators.And(cn_, cq_);
                object ct_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                CqlInterval<CqlDateTime> cu_ = QICoreCommon_4_0_000.Instance.toInterval(context, ct_);
                CqlDateTime cv_ = context.Operators.Start(cu_);
                CqlDate cw_ = context.Operators.DateFrom(cv_);
                DataType cx_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQSocialLimits?.Effective;
                object cy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                CqlInterval<CqlDateTime> cz_ = QICoreCommon_4_0_000.Instance.toInterval(context, cy_);
                CqlDateTime da_ = context.Operators.Start(cz_);
                CqlDate db_ = context.Operators.DateFrom(da_);
                bool? dc_ = context.Operators.SameAs(cw_, db_, "day");
                bool? dd_ = context.Operators.And(cr_, dc_);
                DataType de_ = (tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQSocialLimits as Observation)?.Value;
                object df_ = FHIRHelpers_4_4_000.Instance.ToValue(context, de_);
                bool? dg_ = context.Operators.Not((bool?)(df_ is null));
                bool? dh_ = context.Operators.And(dd_, dg_);
                DataType di_ = (tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQLifeQuality as Observation)?.Value;
                object dj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, di_);
                bool? dk_ = context.Operators.Not((bool?)(dj_ is null));
                bool? dl_ = context.Operators.And(dh_, dk_);
                return dl_;
            }

            IEnumerable<(CqlTupleMetadata, Observation KCCQLifeQuality, Observation KCCQSymptomStability, Observation KCCQSelfEfficacy, Observation KCCQSymptoms, Observation KCCQPhysicalLimits, Observation KCCQSocialLimits)?> ac_ = context.Operators.Where<(CqlTupleMetadata, Observation KCCQLifeQuality, Observation KCCQSymptomStability, Observation KCCQSelfEfficacy, Observation KCCQSymptoms, Observation KCCQPhysicalLimits, Observation KCCQSocialLimits)?>(aa_, ab_);

            CqlDate ad_((CqlTupleMetadata, Observation KCCQLifeQuality, Observation KCCQSymptomStability, Observation KCCQSelfEfficacy, Observation KCCQSymptoms, Observation KCCQPhysicalLimits, Observation KCCQSocialLimits)? tuple_etfcawdpmcqfbnayqdmdqqsdn) {
                DataType dm_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQLifeQuality?.Effective;
                object dn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dm_);
                CqlInterval<CqlDateTime> do_ = QICoreCommon_4_0_000.Instance.toInterval(context, dn_);
                CqlDateTime dp_ = context.Operators.Start(do_);
                CqlDate dq_ = context.Operators.DateFrom(dp_);
                return dq_;
            }

            IEnumerable<CqlDate> ae_ = context.Operators.Select<(CqlTupleMetadata, Observation KCCQLifeQuality, Observation KCCQSymptomStability, Observation KCCQSelfEfficacy, Observation KCCQSymptoms, Observation KCCQPhysicalLimits, Observation KCCQSocialLimits)?, CqlDate>(ac_, ad_);
            IEnumerable<CqlDate> af_ = context.Operators.Distinct<CqlDate>(ae_);
            return af_;
        });


    [CqlExpressionDefinition("Has Encounter with Initial and Follow Up KCCQ Domain Score Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_KCCQ_Domain_Score_Assessments(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(-2096359522954143043L, () => {
            IEnumerable<Encounter> a_ = this.Qualifying_Encounters(context);
            IEnumerable<CqlDate> b_ = this.Date_KCCQ_Domain_Assessment_Completed(context);
            IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> d_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(a_, b_, b_);

            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQAssessmentDate, CqlDate FollowupKCCQAssessmentDate)? e_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple) {
                (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQAssessmentDate, CqlDate FollowupKCCQAssessmentDate)? m_ = (CqlTupleMetadata_HEFWLcHhCNCOQegEOfjWTXiGN, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
                return m_;
            }

            IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQAssessmentDate, CqlDate FollowupKCCQAssessmentDate)?> f_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQAssessmentDate, CqlDate FollowupKCCQAssessmentDate)?>(d_, e_);

            bool? g_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQAssessmentDate, CqlDate FollowupKCCQAssessmentDate)? tuple_hrluhbcfcsvnvrrnjajahdcea) {
                Period n_ = tuple_hrluhbcfcsvnvrrnjajahdcea?.ValidEncounters?.Period;
                CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                CqlDateTime p_ = context.Operators.End(o_);
                CqlInterval<CqlDateTime> q_ = this.Measurement_Period(context);
                CqlDateTime r_ = context.Operators.End(q_);
                CqlQuantity s_ = context.Operators.Quantity(180m, "days");
                CqlDateTime t_ = context.Operators.Subtract(r_, s_);
                bool? u_ = context.Operators.SameOrBefore(p_, t_, "day");
                CqlDateTime v_ = context.Operators.ConvertDateToDateTime(tuple_hrluhbcfcsvnvrrnjajahdcea?.InitialKCCQAssessmentDate);
                CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                CqlDateTime y_ = context.Operators.End(x_);
                CqlQuantity z_ = context.Operators.Quantity(14m, "days");
                CqlDateTime aa_ = context.Operators.Subtract(y_, z_);
                CqlInterval<CqlDateTime> ac_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                CqlDateTime ad_ = context.Operators.End(ac_);
                CqlInterval<CqlDateTime> ae_ = context.Operators.Interval(aa_, ad_, true, true);
                bool? af_ = context.Operators.In<CqlDateTime>(v_, ae_, "day");
                CqlInterval<CqlDateTime> ah_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                CqlDateTime ai_ = context.Operators.End(ah_);
                bool? aj_ = context.Operators.Not((bool?)(ai_ is null));
                bool? ak_ = context.Operators.And(af_, aj_);
                bool? al_ = context.Operators.And(u_, ak_);
                CqlDateTime am_ = context.Operators.ConvertDateToDateTime(tuple_hrluhbcfcsvnvrrnjajahdcea?.FollowupKCCQAssessmentDate);
                CqlDate an_ = context.Operators.DateFrom(am_);
                CqlDate ap_ = context.Operators.DateFrom(v_);
                CqlQuantity aq_ = context.Operators.Quantity(30m, "days");
                CqlDate ar_ = context.Operators.Add(ap_, aq_);
                CqlDate at_ = context.Operators.DateFrom(v_);
                CqlDate av_ = context.Operators.Add(at_, s_);
                CqlInterval<CqlDate> aw_ = context.Operators.Interval(ar_, av_, true, true);
                bool? ax_ = context.Operators.In<CqlDate>(an_, aw_, "day");
                bool? ay_ = context.Operators.And(al_, ax_);
                return ay_;
            }

            IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQAssessmentDate, CqlDate FollowupKCCQAssessmentDate)?> h_ = context.Operators.Where<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQAssessmentDate, CqlDate FollowupKCCQAssessmentDate)?>(f_, g_);
            Encounter i_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQAssessmentDate, CqlDate FollowupKCCQAssessmentDate)? tuple_hrluhbcfcsvnvrrnjajahdcea) => tuple_hrluhbcfcsvnvrrnjajahdcea?.ValidEncounters;
            IEnumerable<Encounter> j_ = context.Operators.Select<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQAssessmentDate, CqlDate FollowupKCCQAssessmentDate)?, Encounter>(h_, i_);
            IEnumerable<Encounter> k_ = context.Operators.Distinct<Encounter>(j_);
            bool? l_ = context.Operators.Exists<Encounter>(k_);
            return l_;
        });


    [CqlExpressionDefinition("Date KCCQ Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_KCCQ_Total_Assessment_Completed(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<CqlDate>>(6106274396873857332L, () => {
            CqlCode a_ = this.Overall_summary_score__KCCQ_(context);
            IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
            IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
            IEnumerable<Observation> d_ = Status_1_15_000.Instance.isAssessmentPerformed(context, c_);

            bool? e_(Observation KCCQSummaryScore) {
                DataType j_ = (KCCQSummaryScore as Observation)?.Value;
                object k_ = FHIRHelpers_4_4_000.Instance.ToValue(context, j_);
                bool? l_ = context.Operators.Not((bool?)(k_ is null));
                return l_;
            }

            IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);

            CqlDate g_(Observation KCCQSummaryScore) {
                DataType m_ = KCCQSummaryScore?.Effective;
                object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
                CqlInterval<CqlDateTime> o_ = QICoreCommon_4_0_000.Instance.toInterval(context, n_);
                CqlDateTime p_ = context.Operators.Start(o_);
                CqlDate q_ = context.Operators.DateFrom(p_);
                return q_;
            }

            IEnumerable<CqlDate> h_ = context.Operators.Select<Observation, CqlDate>(f_, g_);
            IEnumerable<CqlDate> i_ = context.Operators.Distinct<CqlDate>(h_);
            return i_;
        });


    [CqlExpressionDefinition("Has Encounter with Initial and Follow Up KCCQ Total Score Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_KCCQ_Total_Score_Assessments(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(-6324806271972964859L, () => {
            IEnumerable<Encounter> a_ = this.Qualifying_Encounters(context);
            IEnumerable<CqlDate> b_ = this.Date_KCCQ_Total_Assessment_Completed(context);
            IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> d_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(a_, b_, b_);

            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQTotalScore, CqlDate FollowupKCCQTotalScore)? e_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple) {
                (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQTotalScore, CqlDate FollowupKCCQTotalScore)? m_ = (CqlTupleMetadata_DggZKjEbQUfLADMDMBeASLDR, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
                return m_;
            }

            IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQTotalScore, CqlDate FollowupKCCQTotalScore)?> f_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQTotalScore, CqlDate FollowupKCCQTotalScore)?>(d_, e_);

            bool? g_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQTotalScore, CqlDate FollowupKCCQTotalScore)? tuple_dgrojeekdvizsvyisepdjhjgj) {
                Period n_ = tuple_dgrojeekdvizsvyisepdjhjgj?.ValidEncounters?.Period;
                CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                CqlDateTime p_ = context.Operators.End(o_);
                CqlInterval<CqlDateTime> q_ = this.Measurement_Period(context);
                CqlDateTime r_ = context.Operators.End(q_);
                CqlQuantity s_ = context.Operators.Quantity(180m, "days");
                CqlDateTime t_ = context.Operators.Subtract(r_, s_);
                bool? u_ = context.Operators.SameOrBefore(p_, t_, "day");
                CqlDateTime v_ = context.Operators.ConvertDateToDateTime(tuple_dgrojeekdvizsvyisepdjhjgj?.InitialKCCQTotalScore);
                CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                CqlDateTime y_ = context.Operators.End(x_);
                CqlQuantity z_ = context.Operators.Quantity(14m, "days");
                CqlDateTime aa_ = context.Operators.Subtract(y_, z_);
                CqlInterval<CqlDateTime> ac_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                CqlDateTime ad_ = context.Operators.End(ac_);
                CqlInterval<CqlDateTime> ae_ = context.Operators.Interval(aa_, ad_, true, true);
                bool? af_ = context.Operators.In<CqlDateTime>(v_, ae_, "day");
                CqlInterval<CqlDateTime> ah_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                CqlDateTime ai_ = context.Operators.End(ah_);
                bool? aj_ = context.Operators.Not((bool?)(ai_ is null));
                bool? ak_ = context.Operators.And(af_, aj_);
                bool? al_ = context.Operators.And(u_, ak_);
                CqlDateTime am_ = context.Operators.ConvertDateToDateTime(tuple_dgrojeekdvizsvyisepdjhjgj?.FollowupKCCQTotalScore);
                CqlDate an_ = context.Operators.DateFrom(am_);
                CqlDate ap_ = context.Operators.DateFrom(v_);
                CqlQuantity aq_ = context.Operators.Quantity(30m, "days");
                CqlDate ar_ = context.Operators.Add(ap_, aq_);
                CqlDate at_ = context.Operators.DateFrom(v_);
                CqlDate av_ = context.Operators.Add(at_, s_);
                CqlInterval<CqlDate> aw_ = context.Operators.Interval(ar_, av_, true, true);
                bool? ax_ = context.Operators.In<CqlDate>(an_, aw_, "day");
                bool? ay_ = context.Operators.And(al_, ax_);
                return ay_;
            }

            IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQTotalScore, CqlDate FollowupKCCQTotalScore)?> h_ = context.Operators.Where<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQTotalScore, CqlDate FollowupKCCQTotalScore)?>(f_, g_);
            Encounter i_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQTotalScore, CqlDate FollowupKCCQTotalScore)? tuple_dgrojeekdvizsvyisepdjhjgj) => tuple_dgrojeekdvizsvyisepdjhjgj?.ValidEncounters;
            IEnumerable<Encounter> j_ = context.Operators.Select<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQTotalScore, CqlDate FollowupKCCQTotalScore)?, Encounter>(h_, i_);
            IEnumerable<Encounter> k_ = context.Operators.Distinct<Encounter>(j_);
            bool? l_ = context.Operators.Exists<Encounter>(k_);
            return l_;
        });


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(2652104320779056033L, () => {
            bool? a_ = this.Has_Encounter_with_Initial_and_Follow_Up_PROMIS10_Assessments(context);
            bool? b_ = this.Has_Encounter_with_Initial_and_Follow_Up_PROMIS29_Assessments(context);
            bool? c_ = context.Operators.Or(a_, b_);
            bool? d_ = this.Has_Encounter_with_Initial_and_Follow_Up_VR12_Oblique_Assessments(context);
            bool? e_ = context.Operators.Or(c_, d_);
            bool? f_ = this.Has_Encounter_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments(context);
            bool? g_ = context.Operators.Or(e_, f_);
            bool? h_ = this.Has_Encounter_with_Initial_and_Follow_Up_VR36_Oblique_Assessments(context);
            bool? i_ = context.Operators.Or(g_, h_);
            bool? j_ = this.Has_Encounter_with_Initial_and_Follow_Up_VR36_Orthogonal_Assessments(context);
            bool? k_ = context.Operators.Or(i_, j_);
            bool? l_ = this.Has_Encounter_with_Initial_and_Follow_Up_MLHFQ_Assessments(context);
            bool? m_ = context.Operators.Or(k_, l_);
            bool? n_ = this.Has_Encounter_with_Initial_and_Follow_Up_KCCQ12_Assessments(context);
            bool? o_ = context.Operators.Or(m_, n_);
            bool? p_ = this.Has_Encounter_with_Initial_and_Follow_Up_KCCQ_Domain_Score_Assessments(context);
            bool? q_ = context.Operators.Or(o_, p_);
            bool? r_ = this.Has_Encounter_with_Initial_and_Follow_Up_KCCQ_Total_Score_Assessments(context);
            bool? s_ = context.Operators.Or(q_, r_);
            return s_;
        });


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
