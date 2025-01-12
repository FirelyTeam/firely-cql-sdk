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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.9.0")]
[CqlLibrary("FunctionalStatusAssessmentsforHeartFailureFHIR", "0.1.000")]
public partial class FunctionalStatusAssessmentsforHeartFailureFHIR_0_1_000 : ILibrary, ISingleton<FunctionalStatusAssessmentsforHeartFailureFHIR_0_1_000>
{
    private FunctionalStatusAssessmentsforHeartFailureFHIR_0_1_000() {}

    public static FunctionalStatusAssessmentsforHeartFailureFHIR_0_1_000 Instance { get; } = new();

    public string Name => "FunctionalStatusAssessmentsforHeartFailureFHIR";
    public string Version => "0.1.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, QICoreCommon_2_1_000.Instance, SupplementalDataElements_3_5_000.Instance, Hospice_6_12_000.Instance, Status_1_8_000.Instance];

    [CqlDeclaration("Heart Failure")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.376")]
    public CqlValueSet Heart_Failure(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.376", default);

    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
    public CqlValueSet Office_Visit(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", default);

    [CqlDeclaration("Virtual Encounter")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089")]
    public CqlValueSet Virtual_Encounter(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", default);

    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
    public CqlValueSet Telephone_Visits(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", default);

    [CqlDeclaration("Emotional score [MLHFQ]")]
    public CqlCode Emotional_score__MLHFQ_(CqlContext context) =>
        new CqlCode("85609-6", "http://loinc.org", default, default);

    [CqlDeclaration("Kansas City Cardiomyopathy Questionnaire - 12 item [KCCQ-12]")]
    public CqlCode Kansas_City_Cardiomyopathy_Questionnaire___12_item__KCCQ_12_(CqlContext context) =>
        new CqlCode("86923-0", "http://loinc.org", default, default);

    [CqlDeclaration("Overall summary score [KCCQ-12]")]
    public CqlCode Overall_summary_score__KCCQ_12_(CqlContext context) =>
        new CqlCode("86924-8", "http://loinc.org", default, default);

    [CqlDeclaration("Overall summary score [KCCQ]")]
    public CqlCode Overall_summary_score__KCCQ_(CqlContext context) =>
        new CqlCode("71940-1", "http://loinc.org", default, default);

    [CqlDeclaration("Physical limitation score [KCCQ]")]
    public CqlCode Physical_limitation_score__KCCQ_(CqlContext context) =>
        new CqlCode("72195-1", "http://loinc.org", default, default);

    [CqlDeclaration("Physical score [MLHFQ]")]
    public CqlCode Physical_score__MLHFQ_(CqlContext context) =>
        new CqlCode("85618-7", "http://loinc.org", default, default);

    [CqlDeclaration("PROMIS-10 Global Mental Health (GMH) score T-score")]
    public CqlCode PROMIS_10_Global_Mental_Health__GMH__score_T_score(CqlContext context) =>
        new CqlCode("71969-0", "http://loinc.org", default, default);

    [CqlDeclaration("PROMIS-10 Global Physical Health (GPH) score T-score")]
    public CqlCode PROMIS_10_Global_Physical_Health__GPH__score_T_score(CqlContext context) =>
        new CqlCode("71971-6", "http://loinc.org", default, default);

    [CqlDeclaration("PROMIS-29 Anxiety score T-score")]
    public CqlCode PROMIS_29_Anxiety_score_T_score(CqlContext context) =>
        new CqlCode("71967-4", "http://loinc.org", default, default);

    [CqlDeclaration("PROMIS-29 Depression score T-score")]
    public CqlCode PROMIS_29_Depression_score_T_score(CqlContext context) =>
        new CqlCode("71965-8", "http://loinc.org", default, default);

    [CqlDeclaration("PROMIS-29 Fatigue score T-score")]
    public CqlCode PROMIS_29_Fatigue_score_T_score(CqlContext context) =>
        new CqlCode("71963-3", "http://loinc.org", default, default);

    [CqlDeclaration("PROMIS-29 Pain interference score T-score")]
    public CqlCode PROMIS_29_Pain_interference_score_T_score(CqlContext context) =>
        new CqlCode("71961-7", "http://loinc.org", default, default);

    [CqlDeclaration("PROMIS-29 Physical function score T-score")]
    public CqlCode PROMIS_29_Physical_function_score_T_score(CqlContext context) =>
        new CqlCode("71959-1", "http://loinc.org", default, default);

    [CqlDeclaration("PROMIS-29 Satisfaction with participation in social roles score T-score")]
    public CqlCode PROMIS_29_Satisfaction_with_participation_in_social_roles_score_T_score(CqlContext context) =>
        new CqlCode("71957-5", "http://loinc.org", default, default);

    [CqlDeclaration("PROMIS-29 Sleep disturbance score T-score")]
    public CqlCode PROMIS_29_Sleep_disturbance_score_T_score(CqlContext context) =>
        new CqlCode("71955-9", "http://loinc.org", default, default);

    [CqlDeclaration("Quality of life score [KCCQ]")]
    public CqlCode Quality_of_life_score__KCCQ_(CqlContext context) =>
        new CqlCode("72189-4", "http://loinc.org", default, default);

    [CqlDeclaration("Self-efficacy score [KCCQ]")]
    public CqlCode Self_efficacy_score__KCCQ_(CqlContext context) =>
        new CqlCode("72190-2", "http://loinc.org", default, default);

    [CqlDeclaration("Severe cognitive impairment (finding)")]
    public CqlCode Severe_cognitive_impairment__finding_(CqlContext context) =>
        new CqlCode("702956004", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Social limitation score [KCCQ]")]
    public CqlCode Social_limitation_score__KCCQ_(CqlContext context) =>
        new CqlCode("72196-9", "http://loinc.org", default, default);

    [CqlDeclaration("Symptom stability score [KCCQ]")]
    public CqlCode Symptom_stability_score__KCCQ_(CqlContext context) =>
        new CqlCode("72194-4", "http://loinc.org", default, default);

    [CqlDeclaration("Total score [MLHFQ]")]
    public CqlCode Total_score__MLHFQ_(CqlContext context) =>
        new CqlCode("71938-5", "http://loinc.org", default, default);

    [CqlDeclaration("Total symptom score [KCCQ]")]
    public CqlCode Total_symptom_score__KCCQ_(CqlContext context) =>
        new CqlCode("72191-0", "http://loinc.org", default, default);

    [CqlDeclaration("VR-12 Mental component summary (MCS) score - oblique method T-score")]
    public CqlCode VR_12_Mental_component_summary__MCS__score___oblique_method_T_score(CqlContext context) =>
        new CqlCode("72026-8", "http://loinc.org", default, default);

    [CqlDeclaration("VR-12 Mental component summary (MCS) score - orthogonal method T-score")]
    public CqlCode VR_12_Mental_component_summary__MCS__score___orthogonal_method_T_score(CqlContext context) =>
        new CqlCode("72028-4", "http://loinc.org", default, default);

    [CqlDeclaration("VR-12 Physical component summary (PCS) score - oblique method T-score")]
    public CqlCode VR_12_Physical_component_summary__PCS__score___oblique_method_T_score(CqlContext context) =>
        new CqlCode("72025-0", "http://loinc.org", default, default);

    [CqlDeclaration("VR-12 Physical component summary (PCS) score - orthogonal method T-score")]
    public CqlCode VR_12_Physical_component_summary__PCS__score___orthogonal_method_T_score(CqlContext context) =>
        new CqlCode("72027-6", "http://loinc.org", default, default);

    [CqlDeclaration("VR-36 Mental component summary (MCS) score - oblique method T-score")]
    public CqlCode VR_36_Mental_component_summary__MCS__score___oblique_method_T_score(CqlContext context) =>
        new CqlCode("71990-6", "http://loinc.org", default, default);

    [CqlDeclaration("VR-36 Mental component summary (MCS) score - orthogonal method T-score")]
    public CqlCode VR_36_Mental_component_summary__MCS__score___orthogonal_method_T_score(CqlContext context) =>
        new CqlCode("72008-6", "http://loinc.org", default, default);

    [CqlDeclaration("VR-36 Physical component summary (PCS) score - oblique method T-score")]
    public CqlCode VR_36_Physical_component_summary__PCS__score___oblique_method_T_score(CqlContext context) =>
        new CqlCode("71989-8", "http://loinc.org", default, default);

    [CqlDeclaration("VR-36 Physical component summary (PCS) score - orthogonal method T-score")]
    public CqlCode VR_36_Physical_component_summary__PCS__score___orthogonal_method_T_score(CqlContext context) =>
        new CqlCode("72007-8", "http://loinc.org", default, default);

    [CqlDeclaration("LOINC")]
    public CqlCode[] LOINC(CqlContext context)
    {
        CqlCode[] a_ = [
            new CqlCode("85609-6", "http://loinc.org", default, default),
            new CqlCode("86923-0", "http://loinc.org", default, default),
            new CqlCode("86924-8", "http://loinc.org", default, default),
            new CqlCode("71940-1", "http://loinc.org", default, default),
            new CqlCode("72195-1", "http://loinc.org", default, default),
            new CqlCode("85618-7", "http://loinc.org", default, default),
            new CqlCode("71969-0", "http://loinc.org", default, default),
            new CqlCode("71971-6", "http://loinc.org", default, default),
            new CqlCode("71967-4", "http://loinc.org", default, default),
            new CqlCode("71965-8", "http://loinc.org", default, default),
            new CqlCode("71963-3", "http://loinc.org", default, default),
            new CqlCode("71961-7", "http://loinc.org", default, default),
            new CqlCode("71959-1", "http://loinc.org", default, default),
            new CqlCode("71957-5", "http://loinc.org", default, default),
            new CqlCode("71955-9", "http://loinc.org", default, default),
            new CqlCode("72189-4", "http://loinc.org", default, default),
            new CqlCode("72190-2", "http://loinc.org", default, default),
            new CqlCode("72196-9", "http://loinc.org", default, default),
            new CqlCode("72194-4", "http://loinc.org", default, default),
            new CqlCode("71938-5", "http://loinc.org", default, default),
            new CqlCode("72191-0", "http://loinc.org", default, default),
            new CqlCode("72026-8", "http://loinc.org", default, default),
            new CqlCode("72028-4", "http://loinc.org", default, default),
            new CqlCode("72025-0", "http://loinc.org", default, default),
            new CqlCode("72027-6", "http://loinc.org", default, default),
            new CqlCode("71990-6", "http://loinc.org", default, default),
            new CqlCode("72008-6", "http://loinc.org", default, default),
            new CqlCode("71989-8", "http://loinc.org", default, default),
            new CqlCode("72007-8", "http://loinc.org", default, default),
        ];

        return a_;
    }

    [CqlDeclaration("SNOMEDCT")]
    public CqlCode[] SNOMEDCT(CqlContext context)
    {
        CqlCode[] a_ = [
            new CqlCode("702956004", "http://snomed.info/sct", default, default),
        ];

        return a_;
    }

    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, true);
        object d_ = context.ResolveParameter("FunctionalStatusAssessmentsforHeartFailureFHIR-0.1.000", "Measurement Period", c_);

        return (CqlInterval<CqlDateTime>)d_;
    }

    [CqlDeclaration("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

        return b_;
    }

    [CqlDeclaration("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return a_;
    }

    [CqlDeclaration("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return a_;
    }

    [CqlDeclaration("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return a_;
    }

    [CqlDeclaration("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return a_;
    }

    [CqlDeclaration("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        CqlValueSet a_ = this.Office_Visit(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet c_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
        CqlValueSet f_ = this.Virtual_Encounter(context);
        IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> h_ = context.Operators.Union<Encounter>(e_, g_);
        IEnumerable<Encounter> i_ = Status_1_8_000.Instance.isEncounterPerformed(context, h_);
        bool? j_(Encounter ValidEncounter)
        {
            CqlInterval<CqlDateTime> l_ = this.Measurement_Period(context);
            Period m_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, m_);
            CqlInterval<CqlDateTime> o_ = QICoreCommon_2_1_000.Instance.toInterval(context, n_ as object);
            bool? p_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(l_, o_, "day");

            return p_;
        };
        IEnumerable<Encounter> k_ = context.Operators.Where<Encounter>(i_, j_);

        return k_;
    }

    [CqlDeclaration("Two Outpatient Encounters during Measurement Period")]
    public IEnumerable<Encounter> Two_Outpatient_Encounters_during_Measurement_Period(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounters(context);
        IEnumerable<ValueTuple<Encounter, Encounter>> c_ = context.Operators.CrossJoin<Encounter, Encounter>(a_, a_);
        (CqlTupleMetadata, Encounter OfficeVisit1, Encounter OfficeVisit2)? d_(ValueTuple<Encounter, Encounter> _valueTuple)
        {
            (CqlTupleMetadata, Encounter OfficeVisit1, Encounter OfficeVisit2)? k_ = (CqlTupleMetadata_DbNMMZBTISSRTNdiShceSFVih, _valueTuple.Item1, _valueTuple.Item2);

            return k_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter OfficeVisit1, Encounter OfficeVisit2)?> e_ = context.Operators.Select<ValueTuple<Encounter, Encounter>, (CqlTupleMetadata, Encounter OfficeVisit1, Encounter OfficeVisit2)?>(c_, d_);
        bool? f_((CqlTupleMetadata, Encounter OfficeVisit1, Encounter OfficeVisit2)? tuple_dbnmmzbtissrtndishcesfvih)
        {
            Period l_ = tuple_dbnmmzbtissrtndishcesfvih?.OfficeVisit2?.Period;
            CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
            CqlInterval<CqlDateTime> n_ = QICoreCommon_2_1_000.Instance.toInterval(context, m_ as object);
            CqlDateTime o_ = context.Operators.Start(n_);
            Period p_ = tuple_dbnmmzbtissrtndishcesfvih?.OfficeVisit1?.Period;
            CqlInterval<CqlDateTime> q_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, p_);
            CqlInterval<CqlDateTime> r_ = QICoreCommon_2_1_000.Instance.toInterval(context, q_ as object);
            CqlDateTime s_ = context.Operators.End(r_);
            CqlQuantity t_ = context.Operators.Quantity(1m, "day");
            CqlDateTime u_ = context.Operators.Add(s_, t_);
            bool? v_ = context.Operators.SameOrAfter(o_, u_, "day");

            return v_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter OfficeVisit1, Encounter OfficeVisit2)?> g_ = context.Operators.Where<(CqlTupleMetadata, Encounter OfficeVisit1, Encounter OfficeVisit2)?>(e_, f_);
        Encounter h_((CqlTupleMetadata, Encounter OfficeVisit1, Encounter OfficeVisit2)? tuple_dbnmmzbtissrtndishcesfvih) =>
            tuple_dbnmmzbtissrtndishcesfvih?.OfficeVisit1;
        IEnumerable<Encounter> i_ = context.Operators.Select<(CqlTupleMetadata, Encounter OfficeVisit1, Encounter OfficeVisit2)?, Encounter>(g_, h_);
        IEnumerable<Encounter> j_ = context.Operators.Distinct<Encounter>(i_);

        return j_;
    }

    [CqlDeclaration("Initial Population")]
    public bool? Initial_Population(CqlContext context)
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
        CqlValueSet j_ = this.Heart_Failure(context);
        IEnumerable<Condition> k_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, j_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? l_(Condition HeartFailure)
        {
            CqlInterval<CqlDateTime> s_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, HeartFailure);
            CqlInterval<CqlDateTime> t_ = this.Measurement_Period(context);
            bool? u_ = context.Operators.OverlapsBefore(s_, t_, default);

            return u_;
        };
        IEnumerable<Condition> m_ = context.Operators.Where<Condition>(k_, l_);
        bool? n_ = context.Operators.Exists<Condition>(m_);
        bool? o_ = context.Operators.And(i_, n_);
        IEnumerable<Encounter> p_ = this.Two_Outpatient_Encounters_during_Measurement_Period(context);
        bool? q_ = context.Operators.Exists<Encounter>(p_);
        bool? r_ = context.Operators.And(o_, q_);

        return r_;
    }

    [CqlDeclaration("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);

        return a_;
    }

    [CqlDeclaration("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? a_ = Hospice_6_12_000.Instance.Has_Hospice_Services(context);
        CqlCode b_ = this.Severe_cognitive_impairment__finding_(context);
        IEnumerable<CqlCode> c_ = context.Operators.ToList<CqlCode>(b_);
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, c_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? e_(Condition SevereCognitiveImpairment)
        {
            CqlInterval<CqlDateTime> i_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, SevereCognitiveImpairment);
            CqlInterval<CqlDateTime> j_ = this.Measurement_Period(context);
            bool? k_ = context.Operators.Overlaps(i_, j_, default);

            return k_;
        };
        IEnumerable<Condition> f_ = context.Operators.Where<Condition>(d_, e_);
        bool? g_ = context.Operators.Exists<Condition>(f_);
        bool? h_ = context.Operators.Or(a_, g_);

        return h_;
    }

    [CqlDeclaration("Date PROMIS10 Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_PROMIS10_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode a_ = this.PROMIS_10_Global_Mental_Health__GMH__score_T_score(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> d_ = Status_1_8_000.Instance.isAssessmentPerformed(context, c_);
        CqlCode e_ = this.PROMIS_10_Global_Physical_Health__GPH__score_T_score(context);
        IEnumerable<CqlCode> f_ = context.Operators.ToList<CqlCode>(e_);
        IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, f_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> h_ = Status_1_8_000.Instance.isAssessmentPerformed(context, g_);
        IEnumerable<ValueTuple<Observation, Observation>> i_ = context.Operators.CrossJoin<Observation, Observation>(d_, h_);
        (CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)? j_(ValueTuple<Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)? q_ = (CqlTupleMetadata_DDTAOdcFieSJbGgRLLZPYbGQb, _valueTuple.Item1, _valueTuple.Item2);

            return q_;
        };
        IEnumerable<(CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?> k_ = context.Operators.Select<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?>(i_, j_);
        bool? l_((CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)? tuple_ddtaodcfiesjbggrllzpybgqb)
        {
            DataType r_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10MentalScore?.Effective;
            object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
            CqlInterval<CqlDateTime> t_ = QICoreCommon_2_1_000.Instance.toInterval(context, s_);
            CqlDateTime u_ = context.Operators.Start(t_);
            CqlDate v_ = context.Operators.DateFrom(u_);
            DataType w_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10PhysicalScore?.Effective;
            object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
            CqlInterval<CqlDateTime> y_ = QICoreCommon_2_1_000.Instance.toInterval(context, x_);
            CqlDateTime z_ = context.Operators.Start(y_);
            CqlDate aa_ = context.Operators.DateFrom(z_);
            bool? ab_ = context.Operators.SameAs(v_, aa_, "day");
            DataType ac_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10MentalScore?.Value;
            object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
            bool? ae_ = context.Operators.Not((bool?)(ad_ is null));
            bool? af_ = context.Operators.And(ab_, ae_);
            DataType ag_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10PhysicalScore?.Value;
            object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
            bool? ai_ = context.Operators.Not((bool?)(ah_ is null));
            bool? aj_ = context.Operators.And(af_, ai_);

            return aj_;
        };
        IEnumerable<(CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?> m_ = context.Operators.Where<(CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?>(k_, l_);
        CqlDate n_((CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)? tuple_ddtaodcfiesjbggrllzpybgqb)
        {
            DataType ak_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10MentalScore?.Effective;
            object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
            CqlInterval<CqlDateTime> am_ = QICoreCommon_2_1_000.Instance.toInterval(context, al_);
            CqlDateTime an_ = context.Operators.Start(am_);
            CqlDate ao_ = context.Operators.DateFrom(an_);

            return ao_;
        };
        IEnumerable<CqlDate> o_ = context.Operators.Select<(CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?, CqlDate>(m_, n_);
        IEnumerable<CqlDate> p_ = context.Operators.Distinct<CqlDate>(o_);

        return p_;
    }

    [CqlDeclaration("Has Encounter with Initial and Follow Up PROMIS10 Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_PROMIS10_Assessments(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounters(context);
        IEnumerable<CqlDate> b_ = this.Date_PROMIS10_Total_Assessment_Completed(context);
        IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> d_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(a_, b_, b_);
        (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS10Date, CqlDate FollowupPROMIS10Date)? e_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS10Date, CqlDate FollowupPROMIS10Date)? m_ = (CqlTupleMetadata_BGYjYGLNPKWAZTBCVAdLDDTMj, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return m_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS10Date, CqlDate FollowupPROMIS10Date)?> f_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS10Date, CqlDate FollowupPROMIS10Date)?>(d_, e_);
        bool? g_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS10Date, CqlDate FollowupPROMIS10Date)? tuple_dzhwgxhmbfavmzfaszbeksohj)
        {
            Period n_ = tuple_dzhwgxhmbfavmzfaszbeksohj?.ValidEncounters?.Period;
            CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
            CqlInterval<CqlDateTime> p_ = QICoreCommon_2_1_000.Instance.toInterval(context, o_ as object);
            CqlDateTime q_ = context.Operators.End(p_);
            CqlInterval<CqlDateTime> r_ = this.Measurement_Period(context);
            CqlDateTime s_ = context.Operators.End(r_);
            CqlQuantity t_ = context.Operators.Quantity(180m, "days");
            CqlDateTime u_ = context.Operators.Subtract(s_, t_);
            bool? v_ = context.Operators.SameOrBefore(q_, u_, "day");
            CqlDateTime w_ = context.Operators.ConvertDateToDateTime(tuple_dzhwgxhmbfavmzfaszbeksohj?.InitialPROMIS10Date);
            CqlInterval<CqlDateTime> y_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
            CqlInterval<CqlDateTime> z_ = QICoreCommon_2_1_000.Instance.toInterval(context, y_ as object);
            CqlDateTime aa_ = context.Operators.End(z_);
            CqlQuantity ab_ = context.Operators.Quantity(14m, "days");
            CqlDateTime ac_ = context.Operators.Subtract(aa_, ab_);
            CqlInterval<CqlDateTime> ae_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
            CqlInterval<CqlDateTime> af_ = QICoreCommon_2_1_000.Instance.toInterval(context, ae_ as object);
            CqlDateTime ag_ = context.Operators.End(af_);
            CqlInterval<CqlDateTime> ah_ = context.Operators.Interval(ac_, ag_, true, true);
            bool? ai_ = context.Operators.In<CqlDateTime>(w_, ah_, "day");
            CqlInterval<CqlDateTime> ak_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
            CqlInterval<CqlDateTime> al_ = QICoreCommon_2_1_000.Instance.toInterval(context, ak_ as object);
            CqlDateTime am_ = context.Operators.End(al_);
            bool? an_ = context.Operators.Not((bool?)(am_ is null));
            bool? ao_ = context.Operators.And(ai_, an_);
            bool? ap_ = context.Operators.And(v_, ao_);
            CqlDateTime aq_ = context.Operators.ConvertDateToDateTime(tuple_dzhwgxhmbfavmzfaszbeksohj?.FollowupPROMIS10Date);
            CqlDate ar_ = context.Operators.DateFrom(aq_);
            CqlDate at_ = context.Operators.DateFrom(w_);
            CqlQuantity au_ = context.Operators.Quantity(30m, "days");
            CqlDate av_ = context.Operators.Add(at_, au_);
            CqlDate ax_ = context.Operators.DateFrom(w_);
            CqlDate az_ = context.Operators.Add(ax_, t_);
            CqlInterval<CqlDate> ba_ = context.Operators.Interval(av_, az_, true, true);
            bool? bb_ = context.Operators.In<CqlDate>(ar_, ba_, "day");
            bool? bc_ = context.Operators.And(ap_, bb_);

            return bc_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS10Date, CqlDate FollowupPROMIS10Date)?> h_ = context.Operators.Where<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS10Date, CqlDate FollowupPROMIS10Date)?>(f_, g_);
        Encounter i_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS10Date, CqlDate FollowupPROMIS10Date)? tuple_dzhwgxhmbfavmzfaszbeksohj) =>
            tuple_dzhwgxhmbfavmzfaszbeksohj?.ValidEncounters;
        IEnumerable<Encounter> j_ = context.Operators.Select<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS10Date, CqlDate FollowupPROMIS10Date)?, Encounter>(h_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Distinct<Encounter>(j_);
        bool? l_ = context.Operators.Exists<Encounter>(k_);

        return l_;
    }

    [CqlDeclaration("Date PROMIS29 Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_PROMIS29_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode a_ = this.PROMIS_29_Sleep_disturbance_score_T_score(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> d_ = Status_1_8_000.Instance.isAssessmentPerformed(context, c_);
        CqlCode e_ = this.PROMIS_29_Satisfaction_with_participation_in_social_roles_score_T_score(context);
        IEnumerable<CqlCode> f_ = context.Operators.ToList<CqlCode>(e_);
        IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, f_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> h_ = Status_1_8_000.Instance.isAssessmentPerformed(context, g_);
        CqlCode i_ = this.PROMIS_29_Physical_function_score_T_score(context);
        IEnumerable<CqlCode> j_ = context.Operators.ToList<CqlCode>(i_);
        IEnumerable<Observation> k_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, j_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> l_ = Status_1_8_000.Instance.isAssessmentPerformed(context, k_);
        CqlCode m_ = this.PROMIS_29_Pain_interference_score_T_score(context);
        IEnumerable<CqlCode> n_ = context.Operators.ToList<CqlCode>(m_);
        IEnumerable<Observation> o_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, n_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> p_ = Status_1_8_000.Instance.isAssessmentPerformed(context, o_);
        CqlCode q_ = this.PROMIS_29_Fatigue_score_T_score(context);
        IEnumerable<CqlCode> r_ = context.Operators.ToList<CqlCode>(q_);
        IEnumerable<Observation> s_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, r_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> t_ = Status_1_8_000.Instance.isAssessmentPerformed(context, s_);
        CqlCode u_ = this.PROMIS_29_Depression_score_T_score(context);
        IEnumerable<CqlCode> v_ = context.Operators.ToList<CqlCode>(u_);
        IEnumerable<Observation> w_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, v_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> x_ = Status_1_8_000.Instance.isAssessmentPerformed(context, w_);
        CqlCode y_ = this.PROMIS_29_Anxiety_score_T_score(context);
        IEnumerable<CqlCode> z_ = context.Operators.ToList<CqlCode>(y_);
        IEnumerable<Observation> aa_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, z_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> ab_ = Status_1_8_000.Instance.isAssessmentPerformed(context, aa_);
        IEnumerable<ValueTuple<Observation, Observation, Observation, Observation, Observation, Observation, Observation>> ac_ = context.Operators.CrossJoin<Observation, Observation, Observation, Observation, Observation, Observation, Observation>(d_, h_, l_, p_, t_, x_, ab_);
        (CqlTupleMetadata, Observation Promis29Sleep, Observation Promis29SocialRoles, Observation Promis29Physical, Observation Promis29Pain, Observation Promis29Fatigue, Observation Promis29Depression, Observation Promis29Anxiety)? ad_(ValueTuple<Observation, Observation, Observation, Observation, Observation, Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation Promis29Sleep, Observation Promis29SocialRoles, Observation Promis29Physical, Observation Promis29Pain, Observation Promis29Fatigue, Observation Promis29Depression, Observation Promis29Anxiety)? ak_ = (CqlTupleMetadata_DBUJFOVGBcbhIQPWARNQHKUaX, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3, _valueTuple.Item4, _valueTuple.Item5, _valueTuple.Item6, _valueTuple.Item7);

            return ak_;
        };
        IEnumerable<(CqlTupleMetadata, Observation Promis29Sleep, Observation Promis29SocialRoles, Observation Promis29Physical, Observation Promis29Pain, Observation Promis29Fatigue, Observation Promis29Depression, Observation Promis29Anxiety)?> ae_ = context.Operators.Select<ValueTuple<Observation, Observation, Observation, Observation, Observation, Observation, Observation>, (CqlTupleMetadata, Observation Promis29Sleep, Observation Promis29SocialRoles, Observation Promis29Physical, Observation Promis29Pain, Observation Promis29Fatigue, Observation Promis29Depression, Observation Promis29Anxiety)?>(ac_, ad_);
        bool? af_((CqlTupleMetadata, Observation Promis29Sleep, Observation Promis29SocialRoles, Observation Promis29Physical, Observation Promis29Pain, Observation Promis29Fatigue, Observation Promis29Depression, Observation Promis29Anxiety)? tuple_cbgpsarvwrsewlglehinjanim)
        {
            DataType al_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Sleep?.Effective;
            object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
            CqlInterval<CqlDateTime> an_ = QICoreCommon_2_1_000.Instance.toInterval(context, am_);
            CqlDateTime ao_ = context.Operators.Start(an_);
            CqlDate ap_ = context.Operators.DateFrom(ao_);
            DataType aq_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29SocialRoles?.Effective;
            object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
            CqlInterval<CqlDateTime> as_ = QICoreCommon_2_1_000.Instance.toInterval(context, ar_);
            CqlDateTime at_ = context.Operators.Start(as_);
            CqlDate au_ = context.Operators.DateFrom(at_);
            bool? av_ = context.Operators.SameAs(ap_, au_, "day");
            DataType aw_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29SocialRoles?.Value;
            object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
            bool? ay_ = context.Operators.Not((bool?)(ax_ is null));
            bool? az_ = context.Operators.And(av_, ay_);
            object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
            CqlInterval<CqlDateTime> bc_ = QICoreCommon_2_1_000.Instance.toInterval(context, bb_);
            CqlDateTime bd_ = context.Operators.Start(bc_);
            CqlDate be_ = context.Operators.DateFrom(bd_);
            DataType bf_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Physical?.Effective;
            object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
            CqlInterval<CqlDateTime> bh_ = QICoreCommon_2_1_000.Instance.toInterval(context, bg_);
            CqlDateTime bi_ = context.Operators.Start(bh_);
            CqlDate bj_ = context.Operators.DateFrom(bi_);
            bool? bk_ = context.Operators.SameAs(be_, bj_, "day");
            bool? bl_ = context.Operators.And(az_, bk_);
            DataType bm_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Physical?.Value;
            object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
            bool? bo_ = context.Operators.Not((bool?)(bn_ is null));
            bool? bp_ = context.Operators.And(bl_, bo_);
            object br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
            CqlInterval<CqlDateTime> bs_ = QICoreCommon_2_1_000.Instance.toInterval(context, br_);
            CqlDateTime bt_ = context.Operators.Start(bs_);
            CqlDate bu_ = context.Operators.DateFrom(bt_);
            DataType bv_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Pain?.Effective;
            object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
            CqlInterval<CqlDateTime> bx_ = QICoreCommon_2_1_000.Instance.toInterval(context, bw_);
            CqlDateTime by_ = context.Operators.Start(bx_);
            CqlDate bz_ = context.Operators.DateFrom(by_);
            bool? ca_ = context.Operators.SameAs(bu_, bz_, "day");
            bool? cb_ = context.Operators.And(bp_, ca_);
            DataType cc_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Pain?.Value;
            object cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
            bool? ce_ = context.Operators.Not((bool?)(cd_ is null));
            bool? cf_ = context.Operators.And(cb_, ce_);
            object ch_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
            CqlInterval<CqlDateTime> ci_ = QICoreCommon_2_1_000.Instance.toInterval(context, ch_);
            CqlDateTime cj_ = context.Operators.Start(ci_);
            CqlDate ck_ = context.Operators.DateFrom(cj_);
            DataType cl_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Fatigue?.Effective;
            object cm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cl_);
            CqlInterval<CqlDateTime> cn_ = QICoreCommon_2_1_000.Instance.toInterval(context, cm_);
            CqlDateTime co_ = context.Operators.Start(cn_);
            CqlDate cp_ = context.Operators.DateFrom(co_);
            bool? cq_ = context.Operators.SameAs(ck_, cp_, "day");
            bool? cr_ = context.Operators.And(cf_, cq_);
            DataType cs_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Fatigue?.Value;
            object ct_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cs_);
            bool? cu_ = context.Operators.Not((bool?)(ct_ is null));
            bool? cv_ = context.Operators.And(cr_, cu_);
            object cx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
            CqlInterval<CqlDateTime> cy_ = QICoreCommon_2_1_000.Instance.toInterval(context, cx_);
            CqlDateTime cz_ = context.Operators.Start(cy_);
            CqlDate da_ = context.Operators.DateFrom(cz_);
            DataType db_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Depression?.Effective;
            object dc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, db_);
            CqlInterval<CqlDateTime> dd_ = QICoreCommon_2_1_000.Instance.toInterval(context, dc_);
            CqlDateTime de_ = context.Operators.Start(dd_);
            CqlDate df_ = context.Operators.DateFrom(de_);
            bool? dg_ = context.Operators.SameAs(da_, df_, "day");
            bool? dh_ = context.Operators.And(cv_, dg_);
            DataType di_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Depression?.Value;
            object dj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, di_);
            bool? dk_ = context.Operators.Not((bool?)(dj_ is null));
            bool? dl_ = context.Operators.And(dh_, dk_);
            object dn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
            CqlInterval<CqlDateTime> do_ = QICoreCommon_2_1_000.Instance.toInterval(context, dn_);
            CqlDateTime dp_ = context.Operators.Start(do_);
            CqlDate dq_ = context.Operators.DateFrom(dp_);
            DataType dr_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Anxiety?.Effective;
            object ds_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dr_);
            CqlInterval<CqlDateTime> dt_ = QICoreCommon_2_1_000.Instance.toInterval(context, ds_);
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
        };
        IEnumerable<(CqlTupleMetadata, Observation Promis29Sleep, Observation Promis29SocialRoles, Observation Promis29Physical, Observation Promis29Pain, Observation Promis29Fatigue, Observation Promis29Depression, Observation Promis29Anxiety)?> ag_ = context.Operators.Where<(CqlTupleMetadata, Observation Promis29Sleep, Observation Promis29SocialRoles, Observation Promis29Physical, Observation Promis29Pain, Observation Promis29Fatigue, Observation Promis29Depression, Observation Promis29Anxiety)?>(ae_, af_);
        CqlDate ah_((CqlTupleMetadata, Observation Promis29Sleep, Observation Promis29SocialRoles, Observation Promis29Physical, Observation Promis29Pain, Observation Promis29Fatigue, Observation Promis29Depression, Observation Promis29Anxiety)? tuple_cbgpsarvwrsewlglehinjanim)
        {
            DataType eg_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Sleep?.Effective;
            object eh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eg_);
            CqlInterval<CqlDateTime> ei_ = QICoreCommon_2_1_000.Instance.toInterval(context, eh_);
            CqlDateTime ej_ = context.Operators.Start(ei_);
            CqlDate ek_ = context.Operators.DateFrom(ej_);

            return ek_;
        };
        IEnumerable<CqlDate> ai_ = context.Operators.Select<(CqlTupleMetadata, Observation Promis29Sleep, Observation Promis29SocialRoles, Observation Promis29Physical, Observation Promis29Pain, Observation Promis29Fatigue, Observation Promis29Depression, Observation Promis29Anxiety)?, CqlDate>(ag_, ah_);
        IEnumerable<CqlDate> aj_ = context.Operators.Distinct<CqlDate>(ai_);

        return aj_;
    }

    [CqlDeclaration("Has Encounter with Initial and Follow Up PROMIS29 Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_PROMIS29_Assessments(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounters(context);
        IEnumerable<CqlDate> b_ = this.Date_PROMIS29_Total_Assessment_Completed(context);
        IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> d_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(a_, b_, b_);
        (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS29Date, CqlDate FollowupPROMIS29Date)? e_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS29Date, CqlDate FollowupPROMIS29Date)? m_ = (CqlTupleMetadata_DSZKEYVbCINNIeAQiZdVaEJhG, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return m_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS29Date, CqlDate FollowupPROMIS29Date)?> f_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS29Date, CqlDate FollowupPROMIS29Date)?>(d_, e_);
        bool? g_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS29Date, CqlDate FollowupPROMIS29Date)? tuple_kmpntxjuhkpbcwgftqigieao)
        {
            Period n_ = tuple_kmpntxjuhkpbcwgftqigieao?.ValidEncounters?.Period;
            CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
            CqlInterval<CqlDateTime> p_ = QICoreCommon_2_1_000.Instance.toInterval(context, o_ as object);
            CqlDateTime q_ = context.Operators.End(p_);
            CqlInterval<CqlDateTime> r_ = this.Measurement_Period(context);
            CqlDateTime s_ = context.Operators.End(r_);
            CqlQuantity t_ = context.Operators.Quantity(180m, "days");
            CqlDateTime u_ = context.Operators.Subtract(s_, t_);
            bool? v_ = context.Operators.SameOrBefore(q_, u_, "day");
            CqlDateTime w_ = context.Operators.ConvertDateToDateTime(tuple_kmpntxjuhkpbcwgftqigieao?.InitialPROMIS29Date);
            CqlInterval<CqlDateTime> y_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
            CqlInterval<CqlDateTime> z_ = QICoreCommon_2_1_000.Instance.toInterval(context, y_ as object);
            CqlDateTime aa_ = context.Operators.End(z_);
            CqlQuantity ab_ = context.Operators.Quantity(14m, "days");
            CqlDateTime ac_ = context.Operators.Subtract(aa_, ab_);
            CqlInterval<CqlDateTime> ae_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
            CqlInterval<CqlDateTime> af_ = QICoreCommon_2_1_000.Instance.toInterval(context, ae_ as object);
            CqlDateTime ag_ = context.Operators.End(af_);
            CqlInterval<CqlDateTime> ah_ = context.Operators.Interval(ac_, ag_, true, true);
            bool? ai_ = context.Operators.In<CqlDateTime>(w_, ah_, "day");
            CqlInterval<CqlDateTime> ak_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
            CqlInterval<CqlDateTime> al_ = QICoreCommon_2_1_000.Instance.toInterval(context, ak_ as object);
            CqlDateTime am_ = context.Operators.End(al_);
            bool? an_ = context.Operators.Not((bool?)(am_ is null));
            bool? ao_ = context.Operators.And(ai_, an_);
            bool? ap_ = context.Operators.And(v_, ao_);
            CqlDateTime aq_ = context.Operators.ConvertDateToDateTime(tuple_kmpntxjuhkpbcwgftqigieao?.FollowupPROMIS29Date);
            CqlDate ar_ = context.Operators.DateFrom(aq_);
            CqlDate at_ = context.Operators.DateFrom(w_);
            CqlQuantity au_ = context.Operators.Quantity(30m, "days");
            CqlDate av_ = context.Operators.Add(at_, au_);
            CqlDate ax_ = context.Operators.DateFrom(w_);
            CqlDate az_ = context.Operators.Add(ax_, t_);
            CqlInterval<CqlDate> ba_ = context.Operators.Interval(av_, az_, true, true);
            bool? bb_ = context.Operators.In<CqlDate>(ar_, ba_, "day");
            bool? bc_ = context.Operators.And(ap_, bb_);

            return bc_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS29Date, CqlDate FollowupPROMIS29Date)?> h_ = context.Operators.Where<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS29Date, CqlDate FollowupPROMIS29Date)?>(f_, g_);
        Encounter i_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS29Date, CqlDate FollowupPROMIS29Date)? tuple_kmpntxjuhkpbcwgftqigieao) =>
            tuple_kmpntxjuhkpbcwgftqigieao?.ValidEncounters;
        IEnumerable<Encounter> j_ = context.Operators.Select<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS29Date, CqlDate FollowupPROMIS29Date)?, Encounter>(h_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Distinct<Encounter>(j_);
        bool? l_ = context.Operators.Exists<Encounter>(k_);

        return l_;
    }

    [CqlDeclaration("Date VR12 Oblique Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_VR12_Oblique_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode a_ = this.VR_12_Mental_component_summary__MCS__score___oblique_method_T_score(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> d_ = Status_1_8_000.Instance.isAssessmentPerformed(context, c_);
        CqlCode e_ = this.VR_12_Physical_component_summary__PCS__score___oblique_method_T_score(context);
        IEnumerable<CqlCode> f_ = context.Operators.ToList<CqlCode>(e_);
        IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, f_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> h_ = Status_1_8_000.Instance.isAssessmentPerformed(context, g_);
        IEnumerable<ValueTuple<Observation, Observation>> i_ = context.Operators.CrossJoin<Observation, Observation>(d_, h_);
        (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? j_(ValueTuple<Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? q_ = (CqlTupleMetadata_GAdRFKRaHUUGJcVHWQWRUjhRH, _valueTuple.Item1, _valueTuple.Item2);

            return q_;
        };
        IEnumerable<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?> k_ = context.Operators.Select<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?>(i_, j_);
        bool? l_((CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? tuple_gadrfkrahuugjcvhwqwrujhrh)
        {
            DataType r_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Effective;
            object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
            CqlInterval<CqlDateTime> t_ = QICoreCommon_2_1_000.Instance.toInterval(context, s_);
            CqlDateTime u_ = context.Operators.Start(t_);
            CqlDate v_ = context.Operators.DateFrom(u_);
            DataType w_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Effective;
            object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
            CqlInterval<CqlDateTime> y_ = QICoreCommon_2_1_000.Instance.toInterval(context, x_);
            CqlDateTime z_ = context.Operators.Start(y_);
            CqlDate aa_ = context.Operators.DateFrom(z_);
            bool? ab_ = context.Operators.SameAs(v_, aa_, "day");
            DataType ac_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Value;
            object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
            bool? ae_ = context.Operators.Not((bool?)(ad_ is null));
            bool? af_ = context.Operators.And(ab_, ae_);
            DataType ag_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Value;
            object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
            bool? ai_ = context.Operators.Not((bool?)(ah_ is null));
            bool? aj_ = context.Operators.And(af_, ai_);

            return aj_;
        };
        IEnumerable<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?> m_ = context.Operators.Where<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?>(k_, l_);
        CqlDate n_((CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? tuple_gadrfkrahuugjcvhwqwrujhrh)
        {
            DataType ak_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Effective;
            object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
            CqlInterval<CqlDateTime> am_ = QICoreCommon_2_1_000.Instance.toInterval(context, al_);
            CqlDateTime an_ = context.Operators.Start(am_);
            CqlDate ao_ = context.Operators.DateFrom(an_);

            return ao_;
        };
        IEnumerable<CqlDate> o_ = context.Operators.Select<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?, CqlDate>(m_, n_);
        IEnumerable<CqlDate> p_ = context.Operators.Distinct<CqlDate>(o_);

        return p_;
    }

    [CqlDeclaration("Has Encounter with Initial and Follow Up VR12 Oblique Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_VR12_Oblique_Assessments(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounters(context);
        IEnumerable<CqlDate> b_ = this.Date_VR12_Oblique_Total_Assessment_Completed(context);
        IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> d_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(a_, b_, b_);
        (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12ObliqueDate, CqlDate FollowupVR12ObliqueDate)? e_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12ObliqueDate, CqlDate FollowupVR12ObliqueDate)? m_ = (CqlTupleMetadata_FQKGdEYLiDFGMNAUAMETIHUQT, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return m_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12ObliqueDate, CqlDate FollowupVR12ObliqueDate)?> f_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12ObliqueDate, CqlDate FollowupVR12ObliqueDate)?>(d_, e_);
        bool? g_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12ObliqueDate, CqlDate FollowupVR12ObliqueDate)? tuple_fppktdiagiekhptnsbacpswh)
        {
            Period n_ = tuple_fppktdiagiekhptnsbacpswh?.ValidEncounters?.Period;
            CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
            CqlInterval<CqlDateTime> p_ = QICoreCommon_2_1_000.Instance.toInterval(context, o_ as object);
            CqlDateTime q_ = context.Operators.End(p_);
            CqlInterval<CqlDateTime> r_ = this.Measurement_Period(context);
            CqlDateTime s_ = context.Operators.End(r_);
            CqlQuantity t_ = context.Operators.Quantity(180m, "days");
            CqlDateTime u_ = context.Operators.Subtract(s_, t_);
            bool? v_ = context.Operators.SameOrBefore(q_, u_, "day");
            CqlDateTime w_ = context.Operators.ConvertDateToDateTime(tuple_fppktdiagiekhptnsbacpswh?.InitialVR12ObliqueDate);
            CqlInterval<CqlDateTime> y_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
            CqlInterval<CqlDateTime> z_ = QICoreCommon_2_1_000.Instance.toInterval(context, y_ as object);
            CqlDateTime aa_ = context.Operators.End(z_);
            CqlQuantity ab_ = context.Operators.Quantity(14m, "days");
            CqlDateTime ac_ = context.Operators.Subtract(aa_, ab_);
            CqlInterval<CqlDateTime> ae_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
            CqlInterval<CqlDateTime> af_ = QICoreCommon_2_1_000.Instance.toInterval(context, ae_ as object);
            CqlDateTime ag_ = context.Operators.End(af_);
            CqlInterval<CqlDateTime> ah_ = context.Operators.Interval(ac_, ag_, true, true);
            bool? ai_ = context.Operators.In<CqlDateTime>(w_, ah_, "day");
            CqlInterval<CqlDateTime> ak_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
            CqlInterval<CqlDateTime> al_ = QICoreCommon_2_1_000.Instance.toInterval(context, ak_ as object);
            CqlDateTime am_ = context.Operators.End(al_);
            bool? an_ = context.Operators.Not((bool?)(am_ is null));
            bool? ao_ = context.Operators.And(ai_, an_);
            bool? ap_ = context.Operators.And(v_, ao_);
            CqlDateTime aq_ = context.Operators.ConvertDateToDateTime(tuple_fppktdiagiekhptnsbacpswh?.FollowupVR12ObliqueDate);
            CqlDate ar_ = context.Operators.DateFrom(aq_);
            CqlDate at_ = context.Operators.DateFrom(w_);
            CqlQuantity au_ = context.Operators.Quantity(30m, "days");
            CqlDate av_ = context.Operators.Add(at_, au_);
            CqlDate ax_ = context.Operators.DateFrom(w_);
            CqlDate az_ = context.Operators.Add(ax_, t_);
            CqlInterval<CqlDate> ba_ = context.Operators.Interval(av_, az_, true, true);
            bool? bb_ = context.Operators.In<CqlDate>(ar_, ba_, "day");
            bool? bc_ = context.Operators.And(ap_, bb_);

            return bc_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12ObliqueDate, CqlDate FollowupVR12ObliqueDate)?> h_ = context.Operators.Where<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12ObliqueDate, CqlDate FollowupVR12ObliqueDate)?>(f_, g_);
        Encounter i_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12ObliqueDate, CqlDate FollowupVR12ObliqueDate)? tuple_fppktdiagiekhptnsbacpswh) =>
            tuple_fppktdiagiekhptnsbacpswh?.ValidEncounters;
        IEnumerable<Encounter> j_ = context.Operators.Select<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12ObliqueDate, CqlDate FollowupVR12ObliqueDate)?, Encounter>(h_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Distinct<Encounter>(j_);
        bool? l_ = context.Operators.Exists<Encounter>(k_);

        return l_;
    }

    [CqlDeclaration("Date VR12 Orthogonal Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_VR12_Orthogonal_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode a_ = this.VR_12_Mental_component_summary__MCS__score___orthogonal_method_T_score(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> d_ = Status_1_8_000.Instance.isAssessmentPerformed(context, c_);
        CqlCode e_ = this.VR_12_Physical_component_summary__PCS__score___orthogonal_method_T_score(context);
        IEnumerable<CqlCode> f_ = context.Operators.ToList<CqlCode>(e_);
        IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, f_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> h_ = Status_1_8_000.Instance.isAssessmentPerformed(context, g_);
        IEnumerable<ValueTuple<Observation, Observation>> i_ = context.Operators.CrossJoin<Observation, Observation>(d_, h_);
        (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? j_(ValueTuple<Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? q_ = (CqlTupleMetadata_GAdRFKRaHUUGJcVHWQWRUjhRH, _valueTuple.Item1, _valueTuple.Item2);

            return q_;
        };
        IEnumerable<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?> k_ = context.Operators.Select<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?>(i_, j_);
        bool? l_((CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? tuple_gadrfkrahuugjcvhwqwrujhrh)
        {
            DataType r_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Effective;
            object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
            CqlInterval<CqlDateTime> t_ = QICoreCommon_2_1_000.Instance.toInterval(context, s_);
            CqlDateTime u_ = context.Operators.Start(t_);
            CqlDate v_ = context.Operators.DateFrom(u_);
            DataType w_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Effective;
            object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
            CqlInterval<CqlDateTime> y_ = QICoreCommon_2_1_000.Instance.toInterval(context, x_);
            CqlDateTime z_ = context.Operators.Start(y_);
            CqlDate aa_ = context.Operators.DateFrom(z_);
            bool? ab_ = context.Operators.SameAs(v_, aa_, "day");
            DataType ac_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Value;
            object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
            bool? ae_ = context.Operators.Not((bool?)(ad_ is null));
            bool? af_ = context.Operators.And(ab_, ae_);
            DataType ag_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Value;
            object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
            bool? ai_ = context.Operators.Not((bool?)(ah_ is null));
            bool? aj_ = context.Operators.And(af_, ai_);

            return aj_;
        };
        IEnumerable<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?> m_ = context.Operators.Where<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?>(k_, l_);
        CqlDate n_((CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? tuple_gadrfkrahuugjcvhwqwrujhrh)
        {
            DataType ak_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Effective;
            object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
            CqlInterval<CqlDateTime> am_ = QICoreCommon_2_1_000.Instance.toInterval(context, al_);
            CqlDateTime an_ = context.Operators.Start(am_);
            CqlDate ao_ = context.Operators.DateFrom(an_);

            return ao_;
        };
        IEnumerable<CqlDate> o_ = context.Operators.Select<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?, CqlDate>(m_, n_);
        IEnumerable<CqlDate> p_ = context.Operators.Distinct<CqlDate>(o_);

        return p_;
    }

    [CqlDeclaration("Has Encounter with Initial and Follow Up VR12 Orthogonal Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounters(context);
        IEnumerable<CqlDate> b_ = this.Date_VR12_Orthogonal_Total_Assessment_Completed(context);
        IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> d_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(a_, b_, b_);
        (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12OrthogonalDate, CqlDate FollowupVR12OrthogonalDate)? e_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12OrthogonalDate, CqlDate FollowupVR12OrthogonalDate)? m_ = (CqlTupleMetadata_HSSAQEFQAOXLjUcOKGgicELWB, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return m_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12OrthogonalDate, CqlDate FollowupVR12OrthogonalDate)?> f_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12OrthogonalDate, CqlDate FollowupVR12OrthogonalDate)?>(d_, e_);
        bool? g_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12OrthogonalDate, CqlDate FollowupVR12OrthogonalDate)? tuple_fansvmjaedmvsdoyrozxdlsai)
        {
            Period n_ = tuple_fansvmjaedmvsdoyrozxdlsai?.ValidEncounters?.Period;
            CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
            CqlInterval<CqlDateTime> p_ = QICoreCommon_2_1_000.Instance.toInterval(context, o_ as object);
            CqlDateTime q_ = context.Operators.End(p_);
            CqlInterval<CqlDateTime> r_ = this.Measurement_Period(context);
            CqlDateTime s_ = context.Operators.End(r_);
            CqlQuantity t_ = context.Operators.Quantity(180m, "days");
            CqlDateTime u_ = context.Operators.Subtract(s_, t_);
            bool? v_ = context.Operators.SameOrBefore(q_, u_, "day");
            CqlDateTime w_ = context.Operators.ConvertDateToDateTime(tuple_fansvmjaedmvsdoyrozxdlsai?.InitialVR12OrthogonalDate);
            CqlInterval<CqlDateTime> y_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
            CqlInterval<CqlDateTime> z_ = QICoreCommon_2_1_000.Instance.toInterval(context, y_ as object);
            CqlDateTime aa_ = context.Operators.End(z_);
            CqlQuantity ab_ = context.Operators.Quantity(14m, "days");
            CqlDateTime ac_ = context.Operators.Subtract(aa_, ab_);
            CqlInterval<CqlDateTime> ae_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
            CqlInterval<CqlDateTime> af_ = QICoreCommon_2_1_000.Instance.toInterval(context, ae_ as object);
            CqlDateTime ag_ = context.Operators.End(af_);
            CqlInterval<CqlDateTime> ah_ = context.Operators.Interval(ac_, ag_, true, true);
            bool? ai_ = context.Operators.In<CqlDateTime>(w_, ah_, "day");
            CqlInterval<CqlDateTime> ak_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
            CqlInterval<CqlDateTime> al_ = QICoreCommon_2_1_000.Instance.toInterval(context, ak_ as object);
            CqlDateTime am_ = context.Operators.End(al_);
            bool? an_ = context.Operators.Not((bool?)(am_ is null));
            bool? ao_ = context.Operators.And(ai_, an_);
            bool? ap_ = context.Operators.And(v_, ao_);
            CqlDateTime aq_ = context.Operators.ConvertDateToDateTime(tuple_fansvmjaedmvsdoyrozxdlsai?.FollowupVR12OrthogonalDate);
            CqlDate ar_ = context.Operators.DateFrom(aq_);
            CqlDate at_ = context.Operators.DateFrom(w_);
            CqlQuantity au_ = context.Operators.Quantity(30m, "days");
            CqlDate av_ = context.Operators.Add(at_, au_);
            CqlDate ax_ = context.Operators.DateFrom(w_);
            CqlDate az_ = context.Operators.Add(ax_, t_);
            CqlInterval<CqlDate> ba_ = context.Operators.Interval(av_, az_, true, true);
            bool? bb_ = context.Operators.In<CqlDate>(ar_, ba_, "day");
            bool? bc_ = context.Operators.And(ap_, bb_);

            return bc_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12OrthogonalDate, CqlDate FollowupVR12OrthogonalDate)?> h_ = context.Operators.Where<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12OrthogonalDate, CqlDate FollowupVR12OrthogonalDate)?>(f_, g_);
        Encounter i_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12OrthogonalDate, CqlDate FollowupVR12OrthogonalDate)? tuple_fansvmjaedmvsdoyrozxdlsai) =>
            tuple_fansvmjaedmvsdoyrozxdlsai?.ValidEncounters;
        IEnumerable<Encounter> j_ = context.Operators.Select<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12OrthogonalDate, CqlDate FollowupVR12OrthogonalDate)?, Encounter>(h_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Distinct<Encounter>(j_);
        bool? l_ = context.Operators.Exists<Encounter>(k_);

        return l_;
    }

    [CqlDeclaration("Date VR36 Oblique Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_VR36_Oblique_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode a_ = this.VR_36_Mental_component_summary__MCS__score___oblique_method_T_score(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> d_ = Status_1_8_000.Instance.isAssessmentPerformed(context, c_);
        CqlCode e_ = this.VR_36_Physical_component_summary__PCS__score___oblique_method_T_score(context);
        IEnumerable<CqlCode> f_ = context.Operators.ToList<CqlCode>(e_);
        IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, f_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> h_ = Status_1_8_000.Instance.isAssessmentPerformed(context, g_);
        IEnumerable<ValueTuple<Observation, Observation>> i_ = context.Operators.CrossJoin<Observation, Observation>(d_, h_);
        (CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)? j_(ValueTuple<Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)? q_ = (CqlTupleMetadata_DUcFTCLcQEWDGGQdFCWTHFaUK, _valueTuple.Item1, _valueTuple.Item2);

            return q_;
        };
        IEnumerable<(CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?> k_ = context.Operators.Select<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?>(i_, j_);
        bool? l_((CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)? tuple_ducftclcqewdggqdfcwthfauk)
        {
            DataType r_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36MentalAssessment?.Effective;
            object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
            CqlInterval<CqlDateTime> t_ = QICoreCommon_2_1_000.Instance.toInterval(context, s_);
            CqlDateTime u_ = context.Operators.Start(t_);
            CqlDate v_ = context.Operators.DateFrom(u_);
            DataType w_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36PhysicalAssessment?.Effective;
            object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
            CqlInterval<CqlDateTime> y_ = QICoreCommon_2_1_000.Instance.toInterval(context, x_);
            CqlDateTime z_ = context.Operators.Start(y_);
            CqlDate aa_ = context.Operators.DateFrom(z_);
            bool? ab_ = context.Operators.SameAs(v_, aa_, "day");
            DataType ac_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36MentalAssessment?.Value;
            object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
            bool? ae_ = context.Operators.Not((bool?)(ad_ is null));
            bool? af_ = context.Operators.And(ab_, ae_);
            DataType ag_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36PhysicalAssessment?.Value;
            object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
            bool? ai_ = context.Operators.Not((bool?)(ah_ is null));
            bool? aj_ = context.Operators.And(af_, ai_);

            return aj_;
        };
        IEnumerable<(CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?> m_ = context.Operators.Where<(CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?>(k_, l_);
        CqlDate n_((CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)? tuple_ducftclcqewdggqdfcwthfauk)
        {
            DataType ak_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36MentalAssessment?.Effective;
            object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
            CqlInterval<CqlDateTime> am_ = QICoreCommon_2_1_000.Instance.toInterval(context, al_);
            CqlDateTime an_ = context.Operators.Start(am_);
            CqlDate ao_ = context.Operators.DateFrom(an_);

            return ao_;
        };
        IEnumerable<CqlDate> o_ = context.Operators.Select<(CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?, CqlDate>(m_, n_);
        IEnumerable<CqlDate> p_ = context.Operators.Distinct<CqlDate>(o_);

        return p_;
    }

    [CqlDeclaration("Has Encounter with Initial and Follow Up VR36 Oblique Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_VR36_Oblique_Assessments(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounters(context);
        IEnumerable<CqlDate> b_ = this.Date_VR36_Oblique_Total_Assessment_Completed(context);
        IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> d_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(a_, b_, b_);
        (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36ObliqueDate, CqlDate FollowupVR36ObliqueDate)? e_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36ObliqueDate, CqlDate FollowupVR36ObliqueDate)? m_ = (CqlTupleMetadata_HQfcMfhQUSTNYMWSgJHiFeahQ, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return m_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36ObliqueDate, CqlDate FollowupVR36ObliqueDate)?> f_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36ObliqueDate, CqlDate FollowupVR36ObliqueDate)?>(d_, e_);
        bool? g_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36ObliqueDate, CqlDate FollowupVR36ObliqueDate)? tuple_elxicyhrdpyzpqyjphdifbiga)
        {
            Period n_ = tuple_elxicyhrdpyzpqyjphdifbiga?.ValidEncounters?.Period;
            CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
            CqlInterval<CqlDateTime> p_ = QICoreCommon_2_1_000.Instance.toInterval(context, o_ as object);
            CqlDateTime q_ = context.Operators.End(p_);
            CqlInterval<CqlDateTime> r_ = this.Measurement_Period(context);
            CqlDateTime s_ = context.Operators.End(r_);
            CqlQuantity t_ = context.Operators.Quantity(180m, "days");
            CqlDateTime u_ = context.Operators.Subtract(s_, t_);
            bool? v_ = context.Operators.SameOrBefore(q_, u_, "day");
            CqlDateTime w_ = context.Operators.ConvertDateToDateTime(tuple_elxicyhrdpyzpqyjphdifbiga?.InitialVR36ObliqueDate);
            CqlInterval<CqlDateTime> y_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
            CqlInterval<CqlDateTime> z_ = QICoreCommon_2_1_000.Instance.toInterval(context, y_ as object);
            CqlDateTime aa_ = context.Operators.End(z_);
            CqlQuantity ab_ = context.Operators.Quantity(14m, "days");
            CqlDateTime ac_ = context.Operators.Subtract(aa_, ab_);
            CqlInterval<CqlDateTime> ae_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
            CqlInterval<CqlDateTime> af_ = QICoreCommon_2_1_000.Instance.toInterval(context, ae_ as object);
            CqlDateTime ag_ = context.Operators.End(af_);
            CqlInterval<CqlDateTime> ah_ = context.Operators.Interval(ac_, ag_, true, true);
            bool? ai_ = context.Operators.In<CqlDateTime>(w_, ah_, "day");
            CqlInterval<CqlDateTime> ak_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
            CqlInterval<CqlDateTime> al_ = QICoreCommon_2_1_000.Instance.toInterval(context, ak_ as object);
            CqlDateTime am_ = context.Operators.End(al_);
            bool? an_ = context.Operators.Not((bool?)(am_ is null));
            bool? ao_ = context.Operators.And(ai_, an_);
            bool? ap_ = context.Operators.And(v_, ao_);
            CqlDateTime aq_ = context.Operators.ConvertDateToDateTime(tuple_elxicyhrdpyzpqyjphdifbiga?.FollowupVR36ObliqueDate);
            CqlDate ar_ = context.Operators.DateFrom(aq_);
            CqlDate at_ = context.Operators.DateFrom(w_);
            CqlQuantity au_ = context.Operators.Quantity(30m, "days");
            CqlDate av_ = context.Operators.Add(at_, au_);
            CqlDate ax_ = context.Operators.DateFrom(w_);
            CqlDate az_ = context.Operators.Add(ax_, t_);
            CqlInterval<CqlDate> ba_ = context.Operators.Interval(av_, az_, true, true);
            bool? bb_ = context.Operators.In<CqlDate>(ar_, ba_, "day");
            bool? bc_ = context.Operators.And(ap_, bb_);

            return bc_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36ObliqueDate, CqlDate FollowupVR36ObliqueDate)?> h_ = context.Operators.Where<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36ObliqueDate, CqlDate FollowupVR36ObliqueDate)?>(f_, g_);
        Encounter i_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36ObliqueDate, CqlDate FollowupVR36ObliqueDate)? tuple_elxicyhrdpyzpqyjphdifbiga) =>
            tuple_elxicyhrdpyzpqyjphdifbiga?.ValidEncounters;
        IEnumerable<Encounter> j_ = context.Operators.Select<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36ObliqueDate, CqlDate FollowupVR36ObliqueDate)?, Encounter>(h_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Distinct<Encounter>(j_);
        bool? l_ = context.Operators.Exists<Encounter>(k_);

        return l_;
    }

    [CqlDeclaration("Date VR36 Orthogonal Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_VR36_Orthogonal_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode a_ = this.VR_36_Mental_component_summary__MCS__score___orthogonal_method_T_score(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> d_ = Status_1_8_000.Instance.isAssessmentPerformed(context, c_);
        CqlCode e_ = this.VR_36_Physical_component_summary__PCS__score___orthogonal_method_T_score(context);
        IEnumerable<CqlCode> f_ = context.Operators.ToList<CqlCode>(e_);
        IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, f_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> h_ = Status_1_8_000.Instance.isAssessmentPerformed(context, g_);
        IEnumerable<ValueTuple<Observation, Observation>> i_ = context.Operators.CrossJoin<Observation, Observation>(d_, h_);
        (CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)? j_(ValueTuple<Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)? q_ = (CqlTupleMetadata_DUcFTCLcQEWDGGQdFCWTHFaUK, _valueTuple.Item1, _valueTuple.Item2);

            return q_;
        };
        IEnumerable<(CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?> k_ = context.Operators.Select<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?>(i_, j_);
        bool? l_((CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)? tuple_ducftclcqewdggqdfcwthfauk)
        {
            DataType r_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36MentalAssessment?.Effective;
            object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
            CqlInterval<CqlDateTime> t_ = QICoreCommon_2_1_000.Instance.toInterval(context, s_);
            CqlDateTime u_ = context.Operators.Start(t_);
            CqlDate v_ = context.Operators.DateFrom(u_);
            DataType w_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36PhysicalAssessment?.Effective;
            object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
            CqlInterval<CqlDateTime> y_ = QICoreCommon_2_1_000.Instance.toInterval(context, x_);
            CqlDateTime z_ = context.Operators.Start(y_);
            CqlDate aa_ = context.Operators.DateFrom(z_);
            bool? ab_ = context.Operators.SameAs(v_, aa_, "day");
            DataType ac_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36MentalAssessment?.Value;
            object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
            bool? ae_ = context.Operators.Not((bool?)(ad_ is null));
            bool? af_ = context.Operators.And(ab_, ae_);
            DataType ag_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36PhysicalAssessment?.Value;
            object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
            bool? ai_ = context.Operators.Not((bool?)(ah_ is null));
            bool? aj_ = context.Operators.And(af_, ai_);

            return aj_;
        };
        IEnumerable<(CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?> m_ = context.Operators.Where<(CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?>(k_, l_);
        CqlDate n_((CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)? tuple_ducftclcqewdggqdfcwthfauk)
        {
            DataType ak_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36MentalAssessment?.Effective;
            object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
            CqlInterval<CqlDateTime> am_ = QICoreCommon_2_1_000.Instance.toInterval(context, al_);
            CqlDateTime an_ = context.Operators.Start(am_);
            CqlDate ao_ = context.Operators.DateFrom(an_);

            return ao_;
        };
        IEnumerable<CqlDate> o_ = context.Operators.Select<(CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?, CqlDate>(m_, n_);
        IEnumerable<CqlDate> p_ = context.Operators.Distinct<CqlDate>(o_);

        return p_;
    }

    [CqlDeclaration("Has Encounter with Initial and Follow Up VR36 Orthogonal Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_VR36_Orthogonal_Assessments(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounters(context);
        IEnumerable<CqlDate> b_ = this.Date_VR36_Orthogonal_Total_Assessment_Completed(context);
        IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> d_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(a_, b_, b_);
        (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36OrthogonalDate, CqlDate FollowupVR36OrthogonalDate)? e_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36OrthogonalDate, CqlDate FollowupVR36OrthogonalDate)? m_ = (CqlTupleMetadata_BFZHWdOOROjSjFSECHcQiaZZZ, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return m_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36OrthogonalDate, CqlDate FollowupVR36OrthogonalDate)?> f_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36OrthogonalDate, CqlDate FollowupVR36OrthogonalDate)?>(d_, e_);
        bool? g_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36OrthogonalDate, CqlDate FollowupVR36OrthogonalDate)? tuple_fucqujadjizabihdffformht)
        {
            Period n_ = tuple_fucqujadjizabihdffformht?.ValidEncounters?.Period;
            CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
            CqlInterval<CqlDateTime> p_ = QICoreCommon_2_1_000.Instance.toInterval(context, o_ as object);
            CqlDateTime q_ = context.Operators.End(p_);
            CqlInterval<CqlDateTime> r_ = this.Measurement_Period(context);
            CqlDateTime s_ = context.Operators.End(r_);
            CqlQuantity t_ = context.Operators.Quantity(180m, "days");
            CqlDateTime u_ = context.Operators.Subtract(s_, t_);
            bool? v_ = context.Operators.SameOrBefore(q_, u_, "day");
            CqlDateTime w_ = context.Operators.ConvertDateToDateTime(tuple_fucqujadjizabihdffformht?.InitialVR36OrthogonalDate);
            CqlInterval<CqlDateTime> y_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
            CqlInterval<CqlDateTime> z_ = QICoreCommon_2_1_000.Instance.toInterval(context, y_ as object);
            CqlDateTime aa_ = context.Operators.End(z_);
            CqlQuantity ab_ = context.Operators.Quantity(14m, "days");
            CqlDateTime ac_ = context.Operators.Subtract(aa_, ab_);
            CqlInterval<CqlDateTime> ae_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
            CqlInterval<CqlDateTime> af_ = QICoreCommon_2_1_000.Instance.toInterval(context, ae_ as object);
            CqlDateTime ag_ = context.Operators.End(af_);
            CqlInterval<CqlDateTime> ah_ = context.Operators.Interval(ac_, ag_, true, true);
            bool? ai_ = context.Operators.In<CqlDateTime>(w_, ah_, "day");
            CqlInterval<CqlDateTime> ak_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
            CqlInterval<CqlDateTime> al_ = QICoreCommon_2_1_000.Instance.toInterval(context, ak_ as object);
            CqlDateTime am_ = context.Operators.End(al_);
            bool? an_ = context.Operators.Not((bool?)(am_ is null));
            bool? ao_ = context.Operators.And(ai_, an_);
            bool? ap_ = context.Operators.And(v_, ao_);
            CqlDateTime aq_ = context.Operators.ConvertDateToDateTime(tuple_fucqujadjizabihdffformht?.FollowupVR36OrthogonalDate);
            CqlDate ar_ = context.Operators.DateFrom(aq_);
            CqlDate at_ = context.Operators.DateFrom(w_);
            CqlQuantity au_ = context.Operators.Quantity(30m, "days");
            CqlDate av_ = context.Operators.Add(at_, au_);
            CqlDate ax_ = context.Operators.DateFrom(w_);
            CqlDate az_ = context.Operators.Add(ax_, t_);
            CqlInterval<CqlDate> ba_ = context.Operators.Interval(av_, az_, true, true);
            bool? bb_ = context.Operators.In<CqlDate>(ar_, ba_, "day");
            bool? bc_ = context.Operators.And(ap_, bb_);

            return bc_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36OrthogonalDate, CqlDate FollowupVR36OrthogonalDate)?> h_ = context.Operators.Where<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36OrthogonalDate, CqlDate FollowupVR36OrthogonalDate)?>(f_, g_);
        Encounter i_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36OrthogonalDate, CqlDate FollowupVR36OrthogonalDate)? tuple_fucqujadjizabihdffformht) =>
            tuple_fucqujadjizabihdffformht?.ValidEncounters;
        IEnumerable<Encounter> j_ = context.Operators.Select<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36OrthogonalDate, CqlDate FollowupVR36OrthogonalDate)?, Encounter>(h_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Distinct<Encounter>(j_);
        bool? l_ = context.Operators.Exists<Encounter>(k_);

        return l_;
    }

    [CqlDeclaration("Date MLHFQ Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_MLHFQ_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode a_ = this.Physical_score__MLHFQ_(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> d_ = Status_1_8_000.Instance.isAssessmentPerformed(context, c_);
        CqlCode e_ = this.Emotional_score__MLHFQ_(context);
        IEnumerable<CqlCode> f_ = context.Operators.ToList<CqlCode>(e_);
        IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, f_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> h_ = Status_1_8_000.Instance.isAssessmentPerformed(context, g_);
        IEnumerable<ValueTuple<Observation, Observation>> i_ = context.Operators.CrossJoin<Observation, Observation>(d_, h_);
        (CqlTupleMetadata, Observation MLHFQPhysical, Observation MLHFQEmotional)? j_(ValueTuple<Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation MLHFQPhysical, Observation MLHFQEmotional)? q_ = (CqlTupleMetadata_EBLWeAeedHPAfOJXKPZJKSCUf, _valueTuple.Item1, _valueTuple.Item2);

            return q_;
        };
        IEnumerable<(CqlTupleMetadata, Observation MLHFQPhysical, Observation MLHFQEmotional)?> k_ = context.Operators.Select<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation MLHFQPhysical, Observation MLHFQEmotional)?>(i_, j_);
        bool? l_((CqlTupleMetadata, Observation MLHFQPhysical, Observation MLHFQEmotional)? tuple_fnofxckadaeusjerhbdqfoshe)
        {
            DataType r_ = tuple_fnofxckadaeusjerhbdqfoshe?.MLHFQPhysical?.Effective;
            object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
            CqlInterval<CqlDateTime> t_ = QICoreCommon_2_1_000.Instance.toInterval(context, s_);
            CqlDateTime u_ = context.Operators.Start(t_);
            CqlDate v_ = context.Operators.DateFrom(u_);
            DataType w_ = tuple_fnofxckadaeusjerhbdqfoshe?.MLHFQEmotional?.Effective;
            object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
            CqlInterval<CqlDateTime> y_ = QICoreCommon_2_1_000.Instance.toInterval(context, x_);
            CqlDateTime z_ = context.Operators.Start(y_);
            CqlDate aa_ = context.Operators.DateFrom(z_);
            bool? ab_ = context.Operators.SameAs(v_, aa_, "day");
            DataType ac_ = tuple_fnofxckadaeusjerhbdqfoshe?.MLHFQPhysical?.Value;
            object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
            bool? ae_ = context.Operators.Not((bool?)(ad_ is null));
            bool? af_ = context.Operators.And(ab_, ae_);
            DataType ag_ = tuple_fnofxckadaeusjerhbdqfoshe?.MLHFQEmotional?.Value;
            object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
            bool? ai_ = context.Operators.Not((bool?)(ah_ is null));
            bool? aj_ = context.Operators.And(af_, ai_);

            return aj_;
        };
        IEnumerable<(CqlTupleMetadata, Observation MLHFQPhysical, Observation MLHFQEmotional)?> m_ = context.Operators.Where<(CqlTupleMetadata, Observation MLHFQPhysical, Observation MLHFQEmotional)?>(k_, l_);
        CqlDate n_((CqlTupleMetadata, Observation MLHFQPhysical, Observation MLHFQEmotional)? tuple_fnofxckadaeusjerhbdqfoshe)
        {
            DataType ak_ = tuple_fnofxckadaeusjerhbdqfoshe?.MLHFQPhysical?.Effective;
            object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
            CqlInterval<CqlDateTime> am_ = QICoreCommon_2_1_000.Instance.toInterval(context, al_);
            CqlDateTime an_ = context.Operators.Start(am_);
            CqlDate ao_ = context.Operators.DateFrom(an_);

            return ao_;
        };
        IEnumerable<CqlDate> o_ = context.Operators.Select<(CqlTupleMetadata, Observation MLHFQPhysical, Observation MLHFQEmotional)?, CqlDate>(m_, n_);
        IEnumerable<CqlDate> p_ = context.Operators.Distinct<CqlDate>(o_);

        return p_;
    }

    [CqlDeclaration("Has Encounter with Initial and Follow Up MLHFQ Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_MLHFQ_Assessments(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounters(context);
        IEnumerable<CqlDate> b_ = this.Date_MLHFQ_Total_Assessment_Completed(context);
        IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> d_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(a_, b_, b_);
        (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialMLHFQDate, CqlDate FollowupMLHFQDate)? e_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialMLHFQDate, CqlDate FollowupMLHFQDate)? m_ = (CqlTupleMetadata_CcaWSNDiVeaLebVKKWWWiBcEU, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return m_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialMLHFQDate, CqlDate FollowupMLHFQDate)?> f_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialMLHFQDate, CqlDate FollowupMLHFQDate)?>(d_, e_);
        bool? g_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialMLHFQDate, CqlDate FollowupMLHFQDate)? tuple_ncdawctnmbfmtibmihsfbaig)
        {
            Period n_ = tuple_ncdawctnmbfmtibmihsfbaig?.ValidEncounters?.Period;
            CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
            CqlInterval<CqlDateTime> p_ = QICoreCommon_2_1_000.Instance.toInterval(context, o_ as object);
            CqlDateTime q_ = context.Operators.End(p_);
            CqlInterval<CqlDateTime> r_ = this.Measurement_Period(context);
            CqlDateTime s_ = context.Operators.End(r_);
            CqlQuantity t_ = context.Operators.Quantity(180m, "days");
            CqlDateTime u_ = context.Operators.Subtract(s_, t_);
            bool? v_ = context.Operators.SameOrBefore(q_, u_, "day");
            CqlDateTime w_ = context.Operators.ConvertDateToDateTime(tuple_ncdawctnmbfmtibmihsfbaig?.InitialMLHFQDate);
            CqlInterval<CqlDateTime> y_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
            CqlInterval<CqlDateTime> z_ = QICoreCommon_2_1_000.Instance.toInterval(context, y_ as object);
            CqlDateTime aa_ = context.Operators.End(z_);
            CqlQuantity ab_ = context.Operators.Quantity(14m, "days");
            CqlDateTime ac_ = context.Operators.Subtract(aa_, ab_);
            CqlInterval<CqlDateTime> ae_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
            CqlInterval<CqlDateTime> af_ = QICoreCommon_2_1_000.Instance.toInterval(context, ae_ as object);
            CqlDateTime ag_ = context.Operators.End(af_);
            CqlInterval<CqlDateTime> ah_ = context.Operators.Interval(ac_, ag_, true, true);
            bool? ai_ = context.Operators.In<CqlDateTime>(w_, ah_, "day");
            CqlInterval<CqlDateTime> ak_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
            CqlInterval<CqlDateTime> al_ = QICoreCommon_2_1_000.Instance.toInterval(context, ak_ as object);
            CqlDateTime am_ = context.Operators.End(al_);
            bool? an_ = context.Operators.Not((bool?)(am_ is null));
            bool? ao_ = context.Operators.And(ai_, an_);
            bool? ap_ = context.Operators.And(v_, ao_);
            CqlDateTime aq_ = context.Operators.ConvertDateToDateTime(tuple_ncdawctnmbfmtibmihsfbaig?.FollowupMLHFQDate);
            CqlDate ar_ = context.Operators.DateFrom(aq_);
            CqlDate at_ = context.Operators.DateFrom(w_);
            CqlQuantity au_ = context.Operators.Quantity(30m, "days");
            CqlDate av_ = context.Operators.Add(at_, au_);
            CqlDate ax_ = context.Operators.DateFrom(w_);
            CqlDate az_ = context.Operators.Add(ax_, t_);
            CqlInterval<CqlDate> ba_ = context.Operators.Interval(av_, az_, true, true);
            bool? bb_ = context.Operators.In<CqlDate>(ar_, ba_, "day");
            bool? bc_ = context.Operators.And(ap_, bb_);

            return bc_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialMLHFQDate, CqlDate FollowupMLHFQDate)?> h_ = context.Operators.Where<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialMLHFQDate, CqlDate FollowupMLHFQDate)?>(f_, g_);
        Encounter i_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialMLHFQDate, CqlDate FollowupMLHFQDate)? tuple_ncdawctnmbfmtibmihsfbaig) =>
            tuple_ncdawctnmbfmtibmihsfbaig?.ValidEncounters;
        IEnumerable<Encounter> j_ = context.Operators.Select<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialMLHFQDate, CqlDate FollowupMLHFQDate)?, Encounter>(h_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Distinct<Encounter>(j_);
        bool? l_ = context.Operators.Exists<Encounter>(k_);

        return l_;
    }

    [CqlDeclaration("Date KCCQ12 Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_KCCQ12_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode a_ = this.Kansas_City_Cardiomyopathy_Questionnaire___12_item__KCCQ_12_(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> d_ = Status_1_8_000.Instance.isAssessmentPerformed(context, c_);
        CqlCode e_ = this.Overall_summary_score__KCCQ_12_(context);
        IEnumerable<CqlCode> f_ = context.Operators.ToList<CqlCode>(e_);
        IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, f_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> h_ = Status_1_8_000.Instance.isAssessmentPerformed(context, g_);
        IEnumerable<ValueTuple<Observation, Observation>> i_ = context.Operators.CrossJoin<Observation, Observation>(d_, h_);
        (CqlTupleMetadata, Observation KCCQ12Item, Observation KCCQ12Summary)? j_(ValueTuple<Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation KCCQ12Item, Observation KCCQ12Summary)? q_ = (CqlTupleMetadata_DFKXORghhYafccUSbQaMfNTDj, _valueTuple.Item1, _valueTuple.Item2);

            return q_;
        };
        IEnumerable<(CqlTupleMetadata, Observation KCCQ12Item, Observation KCCQ12Summary)?> k_ = context.Operators.Select<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation KCCQ12Item, Observation KCCQ12Summary)?>(i_, j_);
        bool? l_((CqlTupleMetadata, Observation KCCQ12Item, Observation KCCQ12Summary)? tuple_dfkxorghhyafccusbqamfntdj)
        {
            DataType r_ = tuple_dfkxorghhyafccusbqamfntdj?.KCCQ12Item?.Effective;
            object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
            CqlInterval<CqlDateTime> t_ = QICoreCommon_2_1_000.Instance.toInterval(context, s_);
            CqlDateTime u_ = context.Operators.Start(t_);
            CqlDate v_ = context.Operators.DateFrom(u_);
            DataType w_ = tuple_dfkxorghhyafccusbqamfntdj?.KCCQ12Summary?.Effective;
            object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
            CqlInterval<CqlDateTime> y_ = QICoreCommon_2_1_000.Instance.toInterval(context, x_);
            CqlDateTime z_ = context.Operators.Start(y_);
            CqlDate aa_ = context.Operators.DateFrom(z_);
            bool? ab_ = context.Operators.SameAs(v_, aa_, "day");
            DataType ac_ = tuple_dfkxorghhyafccusbqamfntdj?.KCCQ12Item?.Value;
            object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
            bool? ae_ = context.Operators.Not((bool?)(ad_ is null));
            bool? af_ = context.Operators.And(ab_, ae_);
            DataType ag_ = tuple_dfkxorghhyafccusbqamfntdj?.KCCQ12Summary?.Value;
            object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
            bool? ai_ = context.Operators.Not((bool?)(ah_ is null));
            bool? aj_ = context.Operators.And(af_, ai_);

            return aj_;
        };
        IEnumerable<(CqlTupleMetadata, Observation KCCQ12Item, Observation KCCQ12Summary)?> m_ = context.Operators.Where<(CqlTupleMetadata, Observation KCCQ12Item, Observation KCCQ12Summary)?>(k_, l_);
        CqlDate n_((CqlTupleMetadata, Observation KCCQ12Item, Observation KCCQ12Summary)? tuple_dfkxorghhyafccusbqamfntdj)
        {
            DataType ak_ = tuple_dfkxorghhyafccusbqamfntdj?.KCCQ12Item?.Effective;
            object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
            CqlInterval<CqlDateTime> am_ = QICoreCommon_2_1_000.Instance.toInterval(context, al_);
            CqlDateTime an_ = context.Operators.Start(am_);
            CqlDate ao_ = context.Operators.DateFrom(an_);

            return ao_;
        };
        IEnumerable<CqlDate> o_ = context.Operators.Select<(CqlTupleMetadata, Observation KCCQ12Item, Observation KCCQ12Summary)?, CqlDate>(m_, n_);
        IEnumerable<CqlDate> p_ = context.Operators.Distinct<CqlDate>(o_);

        return p_;
    }

    [CqlDeclaration("Has Encounter with Initial and Follow Up KCCQ12 Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_KCCQ12_Assessments(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounters(context);
        IEnumerable<CqlDate> b_ = this.Date_KCCQ12_Total_Assessment_Completed(context);
        IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> d_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(a_, b_, b_);
        (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQ12Date, CqlDate FollowupKCCQ12Date)? e_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQ12Date, CqlDate FollowupKCCQ12Date)? m_ = (CqlTupleMetadata_EQQLFFBVIbLIQLiZDNfeYdMU, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return m_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQ12Date, CqlDate FollowupKCCQ12Date)?> f_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQ12Date, CqlDate FollowupKCCQ12Date)?>(d_, e_);
        bool? g_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQ12Date, CqlDate FollowupKCCQ12Date)? tuple_eoahgtwwdfqijhcjzqnvidvuo)
        {
            Period n_ = tuple_eoahgtwwdfqijhcjzqnvidvuo?.ValidEncounters?.Period;
            CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
            CqlInterval<CqlDateTime> p_ = QICoreCommon_2_1_000.Instance.toInterval(context, o_ as object);
            CqlDateTime q_ = context.Operators.End(p_);
            CqlInterval<CqlDateTime> r_ = this.Measurement_Period(context);
            CqlDateTime s_ = context.Operators.End(r_);
            CqlQuantity t_ = context.Operators.Quantity(180m, "days");
            CqlDateTime u_ = context.Operators.Subtract(s_, t_);
            bool? v_ = context.Operators.SameOrBefore(q_, u_, "day");
            CqlDateTime w_ = context.Operators.ConvertDateToDateTime(tuple_eoahgtwwdfqijhcjzqnvidvuo?.InitialKCCQ12Date);
            CqlInterval<CqlDateTime> y_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
            CqlInterval<CqlDateTime> z_ = QICoreCommon_2_1_000.Instance.toInterval(context, y_ as object);
            CqlDateTime aa_ = context.Operators.End(z_);
            CqlQuantity ab_ = context.Operators.Quantity(14m, "days");
            CqlDateTime ac_ = context.Operators.Subtract(aa_, ab_);
            CqlInterval<CqlDateTime> ae_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
            CqlInterval<CqlDateTime> af_ = QICoreCommon_2_1_000.Instance.toInterval(context, ae_ as object);
            CqlDateTime ag_ = context.Operators.End(af_);
            CqlInterval<CqlDateTime> ah_ = context.Operators.Interval(ac_, ag_, true, true);
            bool? ai_ = context.Operators.In<CqlDateTime>(w_, ah_, "day");
            CqlInterval<CqlDateTime> ak_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
            CqlInterval<CqlDateTime> al_ = QICoreCommon_2_1_000.Instance.toInterval(context, ak_ as object);
            CqlDateTime am_ = context.Operators.End(al_);
            bool? an_ = context.Operators.Not((bool?)(am_ is null));
            bool? ao_ = context.Operators.And(ai_, an_);
            bool? ap_ = context.Operators.And(v_, ao_);
            CqlDateTime aq_ = context.Operators.ConvertDateToDateTime(tuple_eoahgtwwdfqijhcjzqnvidvuo?.FollowupKCCQ12Date);
            CqlDate ar_ = context.Operators.DateFrom(aq_);
            CqlDate at_ = context.Operators.DateFrom(w_);
            CqlQuantity au_ = context.Operators.Quantity(30m, "days");
            CqlDate av_ = context.Operators.Add(at_, au_);
            CqlDate ax_ = context.Operators.DateFrom(w_);
            CqlDate az_ = context.Operators.Add(ax_, t_);
            CqlInterval<CqlDate> ba_ = context.Operators.Interval(av_, az_, true, true);
            bool? bb_ = context.Operators.In<CqlDate>(ar_, ba_, "day");
            bool? bc_ = context.Operators.And(ap_, bb_);

            return bc_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQ12Date, CqlDate FollowupKCCQ12Date)?> h_ = context.Operators.Where<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQ12Date, CqlDate FollowupKCCQ12Date)?>(f_, g_);
        Encounter i_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQ12Date, CqlDate FollowupKCCQ12Date)? tuple_eoahgtwwdfqijhcjzqnvidvuo) =>
            tuple_eoahgtwwdfqijhcjzqnvidvuo?.ValidEncounters;
        IEnumerable<Encounter> j_ = context.Operators.Select<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQ12Date, CqlDate FollowupKCCQ12Date)?, Encounter>(h_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Distinct<Encounter>(j_);
        bool? l_ = context.Operators.Exists<Encounter>(k_);

        return l_;
    }

    [CqlDeclaration("Date KCCQ Domain Assessment Completed")]
    public IEnumerable<CqlDate> Date_KCCQ_Domain_Assessment_Completed(CqlContext context)
    {
        CqlCode a_ = this.Quality_of_life_score__KCCQ_(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> d_ = Status_1_8_000.Instance.isAssessmentPerformed(context, c_);
        CqlCode e_ = this.Symptom_stability_score__KCCQ_(context);
        IEnumerable<CqlCode> f_ = context.Operators.ToList<CqlCode>(e_);
        IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, f_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> h_ = Status_1_8_000.Instance.isAssessmentPerformed(context, g_);
        CqlCode i_ = this.Self_efficacy_score__KCCQ_(context);
        IEnumerable<CqlCode> j_ = context.Operators.ToList<CqlCode>(i_);
        IEnumerable<Observation> k_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, j_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> l_ = Status_1_8_000.Instance.isAssessmentPerformed(context, k_);
        CqlCode m_ = this.Total_symptom_score__KCCQ_(context);
        IEnumerable<CqlCode> n_ = context.Operators.ToList<CqlCode>(m_);
        IEnumerable<Observation> o_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, n_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> p_ = Status_1_8_000.Instance.isAssessmentPerformed(context, o_);
        CqlCode q_ = this.Physical_limitation_score__KCCQ_(context);
        IEnumerable<CqlCode> r_ = context.Operators.ToList<CqlCode>(q_);
        IEnumerable<Observation> s_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, r_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> t_ = Status_1_8_000.Instance.isAssessmentPerformed(context, s_);
        CqlCode u_ = this.Social_limitation_score__KCCQ_(context);
        IEnumerable<CqlCode> v_ = context.Operators.ToList<CqlCode>(u_);
        IEnumerable<Observation> w_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, v_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> x_ = Status_1_8_000.Instance.isAssessmentPerformed(context, w_);
        IEnumerable<ValueTuple<Observation, Observation, Observation, Observation, Observation, Observation>> y_ = context.Operators.CrossJoin<Observation, Observation, Observation, Observation, Observation, Observation>(d_, h_, l_, p_, t_, x_);
        (CqlTupleMetadata, Observation KCCQLifeQuality, Observation KCCQSymptomStability, Observation KCCQSelfEfficacy, Observation KCCQSymptoms, Observation KCCQPhysicalLimits, Observation KCCQSocialLimits)? z_(ValueTuple<Observation, Observation, Observation, Observation, Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation KCCQLifeQuality, Observation KCCQSymptomStability, Observation KCCQSelfEfficacy, Observation KCCQSymptoms, Observation KCCQPhysicalLimits, Observation KCCQSocialLimits)? ag_ = (CqlTupleMetadata_BbPMcXSJeOeGdRcaZWGYPhGBL, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3, _valueTuple.Item4, _valueTuple.Item5, _valueTuple.Item6);

            return ag_;
        };
        IEnumerable<(CqlTupleMetadata, Observation KCCQLifeQuality, Observation KCCQSymptomStability, Observation KCCQSelfEfficacy, Observation KCCQSymptoms, Observation KCCQPhysicalLimits, Observation KCCQSocialLimits)?> aa_ = context.Operators.Select<ValueTuple<Observation, Observation, Observation, Observation, Observation, Observation>, (CqlTupleMetadata, Observation KCCQLifeQuality, Observation KCCQSymptomStability, Observation KCCQSelfEfficacy, Observation KCCQSymptoms, Observation KCCQPhysicalLimits, Observation KCCQSocialLimits)?>(y_, z_);
        bool? ab_((CqlTupleMetadata, Observation KCCQLifeQuality, Observation KCCQSymptomStability, Observation KCCQSelfEfficacy, Observation KCCQSymptoms, Observation KCCQPhysicalLimits, Observation KCCQSocialLimits)? tuple_etfcawdpmcqfbnayqdmdqqsdn)
        {
            DataType ah_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQLifeQuality?.Effective;
            object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
            CqlInterval<CqlDateTime> aj_ = QICoreCommon_2_1_000.Instance.toInterval(context, ai_);
            CqlDateTime ak_ = context.Operators.Start(aj_);
            CqlDate al_ = context.Operators.DateFrom(ak_);
            DataType am_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQSymptomStability?.Effective;
            object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
            CqlInterval<CqlDateTime> ao_ = QICoreCommon_2_1_000.Instance.toInterval(context, an_);
            CqlDateTime ap_ = context.Operators.Start(ao_);
            CqlDate aq_ = context.Operators.DateFrom(ap_);
            bool? ar_ = context.Operators.SameAs(al_, aq_, "day");
            DataType as_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQSymptomStability?.Value;
            object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
            bool? au_ = context.Operators.Not((bool?)(at_ is null));
            bool? av_ = context.Operators.And(ar_, au_);
            object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
            CqlInterval<CqlDateTime> ay_ = QICoreCommon_2_1_000.Instance.toInterval(context, ax_);
            CqlDateTime az_ = context.Operators.Start(ay_);
            CqlDate ba_ = context.Operators.DateFrom(az_);
            DataType bb_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQSelfEfficacy?.Effective;
            object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
            CqlInterval<CqlDateTime> bd_ = QICoreCommon_2_1_000.Instance.toInterval(context, bc_);
            CqlDateTime be_ = context.Operators.Start(bd_);
            CqlDate bf_ = context.Operators.DateFrom(be_);
            bool? bg_ = context.Operators.SameAs(ba_, bf_, "day");
            bool? bh_ = context.Operators.And(av_, bg_);
            DataType bi_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQSelfEfficacy?.Value;
            object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
            bool? bk_ = context.Operators.Not((bool?)(bj_ is null));
            bool? bl_ = context.Operators.And(bh_, bk_);
            object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
            CqlInterval<CqlDateTime> bo_ = QICoreCommon_2_1_000.Instance.toInterval(context, bn_);
            CqlDateTime bp_ = context.Operators.Start(bo_);
            CqlDate bq_ = context.Operators.DateFrom(bp_);
            DataType br_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQSymptoms?.Effective;
            object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
            CqlInterval<CqlDateTime> bt_ = QICoreCommon_2_1_000.Instance.toInterval(context, bs_);
            CqlDateTime bu_ = context.Operators.Start(bt_);
            CqlDate bv_ = context.Operators.DateFrom(bu_);
            bool? bw_ = context.Operators.SameAs(bq_, bv_, "day");
            bool? bx_ = context.Operators.And(bl_, bw_);
            DataType by_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQSymptoms?.Value;
            object bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);
            bool? ca_ = context.Operators.Not((bool?)(bz_ is null));
            bool? cb_ = context.Operators.And(bx_, ca_);
            object cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
            CqlInterval<CqlDateTime> ce_ = QICoreCommon_2_1_000.Instance.toInterval(context, cd_);
            CqlDateTime cf_ = context.Operators.Start(ce_);
            CqlDate cg_ = context.Operators.DateFrom(cf_);
            DataType ch_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQPhysicalLimits?.Effective;
            object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
            CqlInterval<CqlDateTime> cj_ = QICoreCommon_2_1_000.Instance.toInterval(context, ci_);
            CqlDateTime ck_ = context.Operators.Start(cj_);
            CqlDate cl_ = context.Operators.DateFrom(ck_);
            bool? cm_ = context.Operators.SameAs(cg_, cl_, "day");
            bool? cn_ = context.Operators.And(cb_, cm_);
            DataType co_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQPhysicalLimits?.Value;
            object cp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, co_);
            bool? cq_ = context.Operators.Not((bool?)(cp_ is null));
            bool? cr_ = context.Operators.And(cn_, cq_);
            object ct_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
            CqlInterval<CqlDateTime> cu_ = QICoreCommon_2_1_000.Instance.toInterval(context, ct_);
            CqlDateTime cv_ = context.Operators.Start(cu_);
            CqlDate cw_ = context.Operators.DateFrom(cv_);
            DataType cx_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQSocialLimits?.Effective;
            object cy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
            CqlInterval<CqlDateTime> cz_ = QICoreCommon_2_1_000.Instance.toInterval(context, cy_);
            CqlDateTime da_ = context.Operators.Start(cz_);
            CqlDate db_ = context.Operators.DateFrom(da_);
            bool? dc_ = context.Operators.SameAs(cw_, db_, "day");
            bool? dd_ = context.Operators.And(cr_, dc_);
            DataType de_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQSocialLimits?.Value;
            object df_ = FHIRHelpers_4_4_000.Instance.ToValue(context, de_);
            bool? dg_ = context.Operators.Not((bool?)(df_ is null));
            bool? dh_ = context.Operators.And(dd_, dg_);
            DataType di_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQLifeQuality?.Value;
            object dj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, di_);
            bool? dk_ = context.Operators.Not((bool?)(dj_ is null));
            bool? dl_ = context.Operators.And(dh_, dk_);

            return dl_;
        };
        IEnumerable<(CqlTupleMetadata, Observation KCCQLifeQuality, Observation KCCQSymptomStability, Observation KCCQSelfEfficacy, Observation KCCQSymptoms, Observation KCCQPhysicalLimits, Observation KCCQSocialLimits)?> ac_ = context.Operators.Where<(CqlTupleMetadata, Observation KCCQLifeQuality, Observation KCCQSymptomStability, Observation KCCQSelfEfficacy, Observation KCCQSymptoms, Observation KCCQPhysicalLimits, Observation KCCQSocialLimits)?>(aa_, ab_);
        CqlDate ad_((CqlTupleMetadata, Observation KCCQLifeQuality, Observation KCCQSymptomStability, Observation KCCQSelfEfficacy, Observation KCCQSymptoms, Observation KCCQPhysicalLimits, Observation KCCQSocialLimits)? tuple_etfcawdpmcqfbnayqdmdqqsdn)
        {
            DataType dm_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQLifeQuality?.Effective;
            object dn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dm_);
            CqlInterval<CqlDateTime> do_ = QICoreCommon_2_1_000.Instance.toInterval(context, dn_);
            CqlDateTime dp_ = context.Operators.Start(do_);
            CqlDate dq_ = context.Operators.DateFrom(dp_);

            return dq_;
        };
        IEnumerable<CqlDate> ae_ = context.Operators.Select<(CqlTupleMetadata, Observation KCCQLifeQuality, Observation KCCQSymptomStability, Observation KCCQSelfEfficacy, Observation KCCQSymptoms, Observation KCCQPhysicalLimits, Observation KCCQSocialLimits)?, CqlDate>(ac_, ad_);
        IEnumerable<CqlDate> af_ = context.Operators.Distinct<CqlDate>(ae_);

        return af_;
    }

    [CqlDeclaration("Has Encounter with Initial and Follow Up KCCQ Domain Score Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_KCCQ_Domain_Score_Assessments(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounters(context);
        IEnumerable<CqlDate> b_ = this.Date_KCCQ_Domain_Assessment_Completed(context);
        IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> d_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(a_, b_, b_);
        (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQAssessmentDate, CqlDate FollowupKCCQAssessmentDate)? e_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQAssessmentDate, CqlDate FollowupKCCQAssessmentDate)? m_ = (CqlTupleMetadata_HEFWLcHhCNCOQegEOfjWTXiGN, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return m_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQAssessmentDate, CqlDate FollowupKCCQAssessmentDate)?> f_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQAssessmentDate, CqlDate FollowupKCCQAssessmentDate)?>(d_, e_);
        bool? g_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQAssessmentDate, CqlDate FollowupKCCQAssessmentDate)? tuple_hrluhbcfcsvnvrrnjajahdcea)
        {
            Period n_ = tuple_hrluhbcfcsvnvrrnjajahdcea?.ValidEncounters?.Period;
            CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
            CqlInterval<CqlDateTime> p_ = QICoreCommon_2_1_000.Instance.toInterval(context, o_ as object);
            CqlDateTime q_ = context.Operators.End(p_);
            CqlInterval<CqlDateTime> r_ = this.Measurement_Period(context);
            CqlDateTime s_ = context.Operators.End(r_);
            CqlQuantity t_ = context.Operators.Quantity(180m, "days");
            CqlDateTime u_ = context.Operators.Subtract(s_, t_);
            bool? v_ = context.Operators.SameOrBefore(q_, u_, "day");
            CqlDateTime w_ = context.Operators.ConvertDateToDateTime(tuple_hrluhbcfcsvnvrrnjajahdcea?.InitialKCCQAssessmentDate);
            CqlInterval<CqlDateTime> y_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
            CqlInterval<CqlDateTime> z_ = QICoreCommon_2_1_000.Instance.toInterval(context, y_ as object);
            CqlDateTime aa_ = context.Operators.End(z_);
            CqlQuantity ab_ = context.Operators.Quantity(14m, "days");
            CqlDateTime ac_ = context.Operators.Subtract(aa_, ab_);
            CqlInterval<CqlDateTime> ae_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
            CqlInterval<CqlDateTime> af_ = QICoreCommon_2_1_000.Instance.toInterval(context, ae_ as object);
            CqlDateTime ag_ = context.Operators.End(af_);
            CqlInterval<CqlDateTime> ah_ = context.Operators.Interval(ac_, ag_, true, true);
            bool? ai_ = context.Operators.In<CqlDateTime>(w_, ah_, "day");
            CqlInterval<CqlDateTime> ak_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
            CqlInterval<CqlDateTime> al_ = QICoreCommon_2_1_000.Instance.toInterval(context, ak_ as object);
            CqlDateTime am_ = context.Operators.End(al_);
            bool? an_ = context.Operators.Not((bool?)(am_ is null));
            bool? ao_ = context.Operators.And(ai_, an_);
            bool? ap_ = context.Operators.And(v_, ao_);
            CqlDateTime aq_ = context.Operators.ConvertDateToDateTime(tuple_hrluhbcfcsvnvrrnjajahdcea?.FollowupKCCQAssessmentDate);
            CqlDate ar_ = context.Operators.DateFrom(aq_);
            CqlDate at_ = context.Operators.DateFrom(w_);
            CqlQuantity au_ = context.Operators.Quantity(30m, "days");
            CqlDate av_ = context.Operators.Add(at_, au_);
            CqlDate ax_ = context.Operators.DateFrom(w_);
            CqlDate az_ = context.Operators.Add(ax_, t_);
            CqlInterval<CqlDate> ba_ = context.Operators.Interval(av_, az_, true, true);
            bool? bb_ = context.Operators.In<CqlDate>(ar_, ba_, "day");
            bool? bc_ = context.Operators.And(ap_, bb_);

            return bc_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQAssessmentDate, CqlDate FollowupKCCQAssessmentDate)?> h_ = context.Operators.Where<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQAssessmentDate, CqlDate FollowupKCCQAssessmentDate)?>(f_, g_);
        Encounter i_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQAssessmentDate, CqlDate FollowupKCCQAssessmentDate)? tuple_hrluhbcfcsvnvrrnjajahdcea) =>
            tuple_hrluhbcfcsvnvrrnjajahdcea?.ValidEncounters;
        IEnumerable<Encounter> j_ = context.Operators.Select<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQAssessmentDate, CqlDate FollowupKCCQAssessmentDate)?, Encounter>(h_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Distinct<Encounter>(j_);
        bool? l_ = context.Operators.Exists<Encounter>(k_);

        return l_;
    }

    [CqlDeclaration("Date KCCQ Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_KCCQ_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode a_ = this.Overall_summary_score__KCCQ_(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> d_ = Status_1_8_000.Instance.isAssessmentPerformed(context, c_);
        bool? e_(Observation KCCQSummaryScore)
        {
            DataType j_ = KCCQSummaryScore?.Value;
            object k_ = FHIRHelpers_4_4_000.Instance.ToValue(context, j_);
            bool? l_ = context.Operators.Not((bool?)(k_ is null));

            return l_;
        };
        IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);
        CqlDate g_(Observation KCCQSummaryScore)
        {
            DataType m_ = KCCQSummaryScore?.Effective;
            object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
            CqlInterval<CqlDateTime> o_ = QICoreCommon_2_1_000.Instance.toInterval(context, n_);
            CqlDateTime p_ = context.Operators.Start(o_);
            CqlDate q_ = context.Operators.DateFrom(p_);

            return q_;
        };
        IEnumerable<CqlDate> h_ = context.Operators.Select<Observation, CqlDate>(f_, g_);
        IEnumerable<CqlDate> i_ = context.Operators.Distinct<CqlDate>(h_);

        return i_;
    }

    [CqlDeclaration("Has Encounter with Initial and Follow Up KCCQ Total Score Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_KCCQ_Total_Score_Assessments(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounters(context);
        IEnumerable<CqlDate> b_ = this.Date_KCCQ_Total_Assessment_Completed(context);
        IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> d_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(a_, b_, b_);
        (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQTotalScore, CqlDate FollowupKCCQTotalScore)? e_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQTotalScore, CqlDate FollowupKCCQTotalScore)? m_ = (CqlTupleMetadata_DggZKjEbQUfLADMDMBeASLDR, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return m_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQTotalScore, CqlDate FollowupKCCQTotalScore)?> f_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQTotalScore, CqlDate FollowupKCCQTotalScore)?>(d_, e_);
        bool? g_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQTotalScore, CqlDate FollowupKCCQTotalScore)? tuple_dgrojeekdvizsvyisepdjhjgj)
        {
            Period n_ = tuple_dgrojeekdvizsvyisepdjhjgj?.ValidEncounters?.Period;
            CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
            CqlInterval<CqlDateTime> p_ = QICoreCommon_2_1_000.Instance.toInterval(context, o_ as object);
            CqlDateTime q_ = context.Operators.End(p_);
            CqlInterval<CqlDateTime> r_ = this.Measurement_Period(context);
            CqlDateTime s_ = context.Operators.End(r_);
            CqlQuantity t_ = context.Operators.Quantity(180m, "days");
            CqlDateTime u_ = context.Operators.Subtract(s_, t_);
            bool? v_ = context.Operators.SameOrBefore(q_, u_, "day");
            CqlDateTime w_ = context.Operators.ConvertDateToDateTime(tuple_dgrojeekdvizsvyisepdjhjgj?.InitialKCCQTotalScore);
            CqlInterval<CqlDateTime> y_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
            CqlInterval<CqlDateTime> z_ = QICoreCommon_2_1_000.Instance.toInterval(context, y_ as object);
            CqlDateTime aa_ = context.Operators.End(z_);
            CqlQuantity ab_ = context.Operators.Quantity(14m, "days");
            CqlDateTime ac_ = context.Operators.Subtract(aa_, ab_);
            CqlInterval<CqlDateTime> ae_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
            CqlInterval<CqlDateTime> af_ = QICoreCommon_2_1_000.Instance.toInterval(context, ae_ as object);
            CqlDateTime ag_ = context.Operators.End(af_);
            CqlInterval<CqlDateTime> ah_ = context.Operators.Interval(ac_, ag_, true, true);
            bool? ai_ = context.Operators.In<CqlDateTime>(w_, ah_, "day");
            CqlInterval<CqlDateTime> ak_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
            CqlInterval<CqlDateTime> al_ = QICoreCommon_2_1_000.Instance.toInterval(context, ak_ as object);
            CqlDateTime am_ = context.Operators.End(al_);
            bool? an_ = context.Operators.Not((bool?)(am_ is null));
            bool? ao_ = context.Operators.And(ai_, an_);
            bool? ap_ = context.Operators.And(v_, ao_);
            CqlDateTime aq_ = context.Operators.ConvertDateToDateTime(tuple_dgrojeekdvizsvyisepdjhjgj?.FollowupKCCQTotalScore);
            CqlDate ar_ = context.Operators.DateFrom(aq_);
            CqlDate at_ = context.Operators.DateFrom(w_);
            CqlQuantity au_ = context.Operators.Quantity(30m, "days");
            CqlDate av_ = context.Operators.Add(at_, au_);
            CqlDate ax_ = context.Operators.DateFrom(w_);
            CqlDate az_ = context.Operators.Add(ax_, t_);
            CqlInterval<CqlDate> ba_ = context.Operators.Interval(av_, az_, true, true);
            bool? bb_ = context.Operators.In<CqlDate>(ar_, ba_, "day");
            bool? bc_ = context.Operators.And(ap_, bb_);

            return bc_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQTotalScore, CqlDate FollowupKCCQTotalScore)?> h_ = context.Operators.Where<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQTotalScore, CqlDate FollowupKCCQTotalScore)?>(f_, g_);
        Encounter i_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQTotalScore, CqlDate FollowupKCCQTotalScore)? tuple_dgrojeekdvizsvyisepdjhjgj) =>
            tuple_dgrojeekdvizsvyisepdjhjgj?.ValidEncounters;
        IEnumerable<Encounter> j_ = context.Operators.Select<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQTotalScore, CqlDate FollowupKCCQTotalScore)?, Encounter>(h_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Distinct<Encounter>(j_);
        bool? l_ = context.Operators.Exists<Encounter>(k_);

        return l_;
    }

    [CqlDeclaration("Numerator")]
    public bool? Numerator(CqlContext context)
    {
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
    }

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


}
