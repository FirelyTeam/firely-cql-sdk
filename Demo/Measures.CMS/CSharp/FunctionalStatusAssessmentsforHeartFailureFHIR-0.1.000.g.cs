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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.6.0")]
[CqlLibrary("FunctionalStatusAssessmentsforHeartFailureFHIR", "0.1.000")]
public partial class FunctionalStatusAssessmentsforHeartFailureFHIR_0_1_000 : ILibrary, ISingleton<FunctionalStatusAssessmentsforHeartFailureFHIR_0_1_000>
{
    private FunctionalStatusAssessmentsforHeartFailureFHIR_0_1_000() {}

    public static FunctionalStatusAssessmentsforHeartFailureFHIR_0_1_000 Instance { get; } = new();

    #region Library Members
    public string Name => "FunctionalStatusAssessmentsforHeartFailureFHIR";
    public string Version => "0.1.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_3_000.Instance, SupplementalDataElements_3_4_000.Instance, CQMCommon_2_0_000.Instance, Hospice_6_9_000.Instance, Status_1_6_000.Instance, QICoreCommon_2_0_000.Instance];
    #endregion Library Members

    [CqlDeclaration("Heart Failure")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.376")]
    public CqlValueSet Heart_Failure(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.376", default);


    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
    public CqlValueSet Office_Visit(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", default);


    [CqlDeclaration("Online Assessments")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089")]
    public CqlValueSet Online_Assessments(CqlContext context) => 
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
        CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
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
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_4_000.Instance.SDE_Ethnicity(context);

        return a_;
    }


    [CqlDeclaration("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_3_4_000.Instance.SDE_Payer(context);

        return a_;
    }


    [CqlDeclaration("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_4_000.Instance.SDE_Race(context);

        return a_;
    }


    [CqlDeclaration("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_3_4_000.Instance.SDE_Sex(context);

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
        CqlValueSet f_ = this.Online_Assessments(context);
        IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> h_ = context.Operators.Union<Encounter>(e_, g_);
        IEnumerable<Encounter> i_ = Status_1_6_000.Instance.Finished_Encounter(context, h_);
        bool? j_(Encounter ValidEncounter)
        {
            CqlInterval<CqlDateTime> l_ = this.Measurement_Period(context);
            Period m_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, m_);
            CqlInterval<CqlDateTime> o_ = QICoreCommon_2_0_000.Instance.ToInterval(context, n_ as object);
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
            (CqlTupleMetadata, Encounter OfficeVisit1, Encounter OfficeVisit2)? j_ = (CqlTupleMetadata_DbNMMZBTISSRTNdiShceSFVih, _valueTuple.Item1, _valueTuple.Item2);

            return j_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter OfficeVisit1, Encounter OfficeVisit2)?> e_ = context.Operators.Select<ValueTuple<Encounter, Encounter>, (CqlTupleMetadata, Encounter OfficeVisit1, Encounter OfficeVisit2)?>(c_, d_);
        bool? f_((CqlTupleMetadata, Encounter OfficeVisit1, Encounter OfficeVisit2)? tuple_dbnmmzbtissrtndishcesfvih)
        {
            Period k_ = tuple_dbnmmzbtissrtndishcesfvih?.OfficeVisit2?.Period;
            CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, k_);
            CqlInterval<CqlDateTime> m_ = QICoreCommon_2_0_000.Instance.ToInterval(context, l_ as object);
            CqlDateTime n_ = context.Operators.Start(m_);
            Period o_ = tuple_dbnmmzbtissrtndishcesfvih?.OfficeVisit1?.Period;
            CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, o_);
            CqlInterval<CqlDateTime> q_ = QICoreCommon_2_0_000.Instance.ToInterval(context, p_ as object);
            CqlDateTime r_ = context.Operators.End(q_);
            CqlQuantity s_ = context.Operators.Quantity(1m, "day");
            CqlDateTime t_ = context.Operators.Add(r_, s_);
            bool? u_ = context.Operators.SameOrAfter(n_, t_, "day");

            return u_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter OfficeVisit1, Encounter OfficeVisit2)?> g_ = context.Operators.Where<(CqlTupleMetadata, Encounter OfficeVisit1, Encounter OfficeVisit2)?>(e_, f_);
        Encounter h_((CqlTupleMetadata, Encounter OfficeVisit1, Encounter OfficeVisit2)? tuple_dbnmmzbtissrtndishcesfvih) => 
            tuple_dbnmmzbtissrtndishcesfvih?.OfficeVisit1;
        IEnumerable<Encounter> i_ = context.Operators.Select<(CqlTupleMetadata, Encounter OfficeVisit1, Encounter OfficeVisit2)?, Encounter>(g_, h_);

        return i_;
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
            CqlInterval<CqlDateTime> s_ = QICoreCommon_2_0_000.Instance.ToPrevalenceInterval(context, HeartFailure);
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
        bool? a_ = Hospice_6_9_000.Instance.Has_Hospice_Services(context);
        CqlCode b_ = this.Severe_cognitive_impairment__finding_(context);
        IEnumerable<CqlCode> c_ = context.Operators.ToList<CqlCode>(b_);
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, c_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? e_(Condition Dementia)
        {
            CqlInterval<CqlDateTime> i_ = QICoreCommon_2_0_000.Instance.ToPrevalenceInterval(context, Dementia);
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
        IEnumerable<Observation> d_ = Status_1_6_000.Instance.Final_Survey_Observation(context, c_);
        CqlCode e_ = this.PROMIS_10_Global_Physical_Health__GPH__score_T_score(context);
        IEnumerable<CqlCode> f_ = context.Operators.ToList<CqlCode>(e_);
        IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, f_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> h_ = Status_1_6_000.Instance.Final_Survey_Observation(context, g_);
        IEnumerable<ValueTuple<Observation, Observation>> i_ = context.Operators.CrossJoin<Observation, Observation>(d_, h_);
        (CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)? j_(ValueTuple<Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)? p_ = (CqlTupleMetadata_DDTAOdcFieSJbGgRLLZPYbGQb, _valueTuple.Item1, _valueTuple.Item2);

            return p_;
        };
        IEnumerable<(CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?> k_ = context.Operators.Select<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?>(i_, j_);
        bool? l_((CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)? tuple_ddtaodcfiesjbggrllzpybgqb)
        {
            DataType q_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10MentalScore?.Effective;
            object r_ = FHIRHelpers_4_3_000.Instance.ToValue(context, q_);
            CqlInterval<CqlDateTime> s_ = QICoreCommon_2_0_000.Instance.ToInterval(context, r_);
            CqlDateTime t_ = context.Operators.Start(s_);
            CqlDate u_ = context.Operators.DateFrom(t_);
            DataType v_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10PhysicalScore?.Effective;
            object w_ = FHIRHelpers_4_3_000.Instance.ToValue(context, v_);
            CqlInterval<CqlDateTime> x_ = QICoreCommon_2_0_000.Instance.ToInterval(context, w_);
            CqlDateTime y_ = context.Operators.Start(x_);
            CqlDate z_ = context.Operators.DateFrom(y_);
            bool? aa_ = context.Operators.SameAs(u_, z_, "day");
            DataType ab_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10MentalScore?.Value;
            object ac_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ab_);
            bool? ad_ = context.Operators.Not((bool?)(ac_ is null));
            bool? ae_ = context.Operators.And(aa_, ad_);
            DataType af_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10PhysicalScore?.Value;
            object ag_ = FHIRHelpers_4_3_000.Instance.ToValue(context, af_);
            bool? ah_ = context.Operators.Not((bool?)(ag_ is null));
            bool? ai_ = context.Operators.And(ae_, ah_);

            return ai_;
        };
        IEnumerable<(CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?> m_ = context.Operators.Where<(CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?>(k_, l_);
        CqlDate n_((CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)? tuple_ddtaodcfiesjbggrllzpybgqb)
        {
            DataType aj_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10MentalScore?.Effective;
            object ak_ = FHIRHelpers_4_3_000.Instance.ToValue(context, aj_);
            CqlInterval<CqlDateTime> al_ = QICoreCommon_2_0_000.Instance.ToInterval(context, ak_);
            CqlDateTime am_ = context.Operators.Start(al_);
            CqlDate an_ = context.Operators.DateFrom(am_);
            DataType ao_ = tuple_ddtaodcfiesjbggrllzpybgqb?.PROMIS10PhysicalScore?.Effective;
            object ap_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ao_);
            CqlInterval<CqlDateTime> aq_ = QICoreCommon_2_0_000.Instance.ToInterval(context, ap_);
            CqlDateTime ar_ = context.Operators.Start(aq_);
            CqlDate as_ = context.Operators.DateFrom(ar_);
            CqlDate[] at_ = [
                an_,
                as_,
            ];
            CqlDate au_ = context.Operators.Max<CqlDate>(at_ as IEnumerable<CqlDate>);

            return au_;
        };
        IEnumerable<CqlDate> o_ = context.Operators.Select<(CqlTupleMetadata, Observation PROMIS10MentalScore, Observation PROMIS10PhysicalScore)?, CqlDate>(m_, n_);

        return o_;
    }


    [CqlDeclaration("Has Encounter with Initial and Follow Up PROMIS10 Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_PROMIS10_Assessments(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounters(context);
        IEnumerable<CqlDate> b_ = this.Date_PROMIS10_Total_Assessment_Completed(context);
        IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> d_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(a_, b_, b_);
        (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS10Date, CqlDate FollowupPROMIS10Date)? e_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS10Date, CqlDate FollowupPROMIS10Date)? l_ = (CqlTupleMetadata_DZhWGXhMBfAVMZfaSZbEKSOHj, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return l_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS10Date, CqlDate FollowupPROMIS10Date)?> f_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS10Date, CqlDate FollowupPROMIS10Date)?>(d_, e_);
        bool? g_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS10Date, CqlDate FollowupPROMIS10Date)? tuple_dzhwgxhmbfavmzfaszbeksohj)
        {
            Period m_ = tuple_dzhwgxhmbfavmzfaszbeksohj?.ValidEncounters?.Period;
            CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, m_);
            CqlInterval<CqlDateTime> o_ = QICoreCommon_2_0_000.Instance.ToInterval(context, n_ as object);
            CqlDateTime p_ = context.Operators.End(o_);
            CqlInterval<CqlDateTime> q_ = this.Measurement_Period(context);
            CqlDateTime r_ = context.Operators.End(q_);
            CqlQuantity s_ = context.Operators.Quantity(180m, "days");
            CqlDateTime t_ = context.Operators.Subtract(r_, s_);
            bool? u_ = context.Operators.SameOrBefore(p_, t_, "day");
            CqlDateTime v_ = context.Operators.ConvertDateToDateTime(tuple_dzhwgxhmbfavmzfaszbeksohj?.InitialPROMIS10Date);
            CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, m_);
            CqlInterval<CqlDateTime> y_ = QICoreCommon_2_0_000.Instance.ToInterval(context, x_ as object);
            CqlDateTime z_ = context.Operators.End(y_);
            CqlQuantity aa_ = context.Operators.Quantity(14m, "days");
            CqlDateTime ab_ = context.Operators.Subtract(z_, aa_);
            CqlInterval<CqlDateTime> ad_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, m_);
            CqlInterval<CqlDateTime> ae_ = QICoreCommon_2_0_000.Instance.ToInterval(context, ad_ as object);
            CqlDateTime af_ = context.Operators.End(ae_);
            CqlInterval<CqlDateTime> ag_ = context.Operators.Interval(ab_, af_, true, true);
            bool? ah_ = context.Operators.In<CqlDateTime>(v_, ag_, "day");
            CqlInterval<CqlDateTime> aj_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, m_);
            CqlInterval<CqlDateTime> ak_ = QICoreCommon_2_0_000.Instance.ToInterval(context, aj_ as object);
            CqlDateTime al_ = context.Operators.End(ak_);
            bool? am_ = context.Operators.Not((bool?)(al_ is null));
            bool? an_ = context.Operators.And(ah_, am_);
            bool? ao_ = context.Operators.And(u_, an_);
            CqlDateTime ap_ = context.Operators.ConvertDateToDateTime(tuple_dzhwgxhmbfavmzfaszbeksohj?.FollowupPROMIS10Date);
            CqlDate aq_ = context.Operators.DateFrom(ap_);
            CqlDate as_ = context.Operators.DateFrom(v_);
            CqlQuantity at_ = context.Operators.Quantity(30m, "days");
            CqlDate au_ = context.Operators.Add(as_, at_);
            CqlDate aw_ = context.Operators.DateFrom(v_);
            CqlDate ay_ = context.Operators.Add(aw_, s_);
            CqlInterval<CqlDate> az_ = context.Operators.Interval(au_, ay_, true, true);
            bool? ba_ = context.Operators.In<CqlDate>(aq_, az_, "day");
            bool? bb_ = context.Operators.And(ao_, ba_);

            return bb_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS10Date, CqlDate FollowupPROMIS10Date)?> h_ = context.Operators.Where<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS10Date, CqlDate FollowupPROMIS10Date)?>(f_, g_);
        Encounter i_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS10Date, CqlDate FollowupPROMIS10Date)? tuple_dzhwgxhmbfavmzfaszbeksohj) => 
            tuple_dzhwgxhmbfavmzfaszbeksohj?.ValidEncounters;
        IEnumerable<Encounter> j_ = context.Operators.Select<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS10Date, CqlDate FollowupPROMIS10Date)?, Encounter>(h_, i_);
        bool? k_ = context.Operators.Exists<Encounter>(j_);

        return k_;
    }


    [CqlDeclaration("Date PROMIS29 Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_PROMIS29_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode a_ = this.PROMIS_29_Sleep_disturbance_score_T_score(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> d_ = Status_1_6_000.Instance.Final_Survey_Observation(context, c_);
        CqlCode e_ = this.PROMIS_29_Satisfaction_with_participation_in_social_roles_score_T_score(context);
        IEnumerable<CqlCode> f_ = context.Operators.ToList<CqlCode>(e_);
        IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, f_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> h_ = Status_1_6_000.Instance.Final_Survey_Observation(context, g_);
        CqlCode i_ = this.PROMIS_29_Physical_function_score_T_score(context);
        IEnumerable<CqlCode> j_ = context.Operators.ToList<CqlCode>(i_);
        IEnumerable<Observation> k_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, j_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> l_ = Status_1_6_000.Instance.Final_Survey_Observation(context, k_);
        CqlCode m_ = this.PROMIS_29_Pain_interference_score_T_score(context);
        IEnumerable<CqlCode> n_ = context.Operators.ToList<CqlCode>(m_);
        IEnumerable<Observation> o_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, n_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> p_ = Status_1_6_000.Instance.Final_Survey_Observation(context, o_);
        CqlCode q_ = this.PROMIS_29_Fatigue_score_T_score(context);
        IEnumerable<CqlCode> r_ = context.Operators.ToList<CqlCode>(q_);
        IEnumerable<Observation> s_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, r_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> t_ = Status_1_6_000.Instance.Final_Survey_Observation(context, s_);
        CqlCode u_ = this.PROMIS_29_Depression_score_T_score(context);
        IEnumerable<CqlCode> v_ = context.Operators.ToList<CqlCode>(u_);
        IEnumerable<Observation> w_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, v_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> x_ = Status_1_6_000.Instance.Final_Survey_Observation(context, w_);
        CqlCode y_ = this.PROMIS_29_Anxiety_score_T_score(context);
        IEnumerable<CqlCode> z_ = context.Operators.ToList<CqlCode>(y_);
        IEnumerable<Observation> aa_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, z_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> ab_ = Status_1_6_000.Instance.Final_Survey_Observation(context, aa_);
        IEnumerable<ValueTuple<Observation, Observation, Observation, Observation, Observation, Observation, Observation>> ac_ = context.Operators.CrossJoin<Observation, Observation, Observation, Observation, Observation, Observation, Observation>(d_, h_, l_, p_, t_, x_, ab_);
        (CqlTupleMetadata, Observation Promis29Sleep, Observation Promis29SocialRoles, Observation Promis29Physical, Observation Promis29Pain, Observation Promis29Fatigue, Observation Promis29Depression, Observation Promis29Anxiety)? ad_(ValueTuple<Observation, Observation, Observation, Observation, Observation, Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation Promis29Sleep, Observation Promis29SocialRoles, Observation Promis29Physical, Observation Promis29Pain, Observation Promis29Fatigue, Observation Promis29Depression, Observation Promis29Anxiety)? aj_ = (CqlTupleMetadata_CbgPSARVWRSeWLgLehiNjaNiM, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3, _valueTuple.Item4, _valueTuple.Item5, _valueTuple.Item6, _valueTuple.Item7);

            return aj_;
        };
        IEnumerable<(CqlTupleMetadata, Observation Promis29Sleep, Observation Promis29SocialRoles, Observation Promis29Physical, Observation Promis29Pain, Observation Promis29Fatigue, Observation Promis29Depression, Observation Promis29Anxiety)?> ae_ = context.Operators.Select<ValueTuple<Observation, Observation, Observation, Observation, Observation, Observation, Observation>, (CqlTupleMetadata, Observation Promis29Sleep, Observation Promis29SocialRoles, Observation Promis29Physical, Observation Promis29Pain, Observation Promis29Fatigue, Observation Promis29Depression, Observation Promis29Anxiety)?>(ac_, ad_);
        bool? af_((CqlTupleMetadata, Observation Promis29Sleep, Observation Promis29SocialRoles, Observation Promis29Physical, Observation Promis29Pain, Observation Promis29Fatigue, Observation Promis29Depression, Observation Promis29Anxiety)? tuple_cbgpsarvwrsewlglehinjanim)
        {
            DataType ak_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Sleep?.Effective;
            object al_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ak_);
            CqlInterval<CqlDateTime> am_ = QICoreCommon_2_0_000.Instance.ToInterval(context, al_);
            CqlDateTime an_ = context.Operators.Start(am_);
            CqlDate ao_ = context.Operators.DateFrom(an_);
            DataType ap_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29SocialRoles?.Effective;
            object aq_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ap_);
            CqlInterval<CqlDateTime> ar_ = QICoreCommon_2_0_000.Instance.ToInterval(context, aq_);
            CqlDateTime as_ = context.Operators.Start(ar_);
            CqlDate at_ = context.Operators.DateFrom(as_);
            bool? au_ = context.Operators.SameAs(ao_, at_, "day");
            DataType av_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29SocialRoles?.Value;
            object aw_ = FHIRHelpers_4_3_000.Instance.ToValue(context, av_);
            bool? ax_ = context.Operators.Not((bool?)(aw_ is null));
            bool? ay_ = context.Operators.And(au_, ax_);
            object ba_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ak_);
            CqlInterval<CqlDateTime> bb_ = QICoreCommon_2_0_000.Instance.ToInterval(context, ba_);
            CqlDateTime bc_ = context.Operators.Start(bb_);
            CqlDate bd_ = context.Operators.DateFrom(bc_);
            DataType be_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Physical?.Effective;
            object bf_ = FHIRHelpers_4_3_000.Instance.ToValue(context, be_);
            CqlInterval<CqlDateTime> bg_ = QICoreCommon_2_0_000.Instance.ToInterval(context, bf_);
            CqlDateTime bh_ = context.Operators.Start(bg_);
            CqlDate bi_ = context.Operators.DateFrom(bh_);
            bool? bj_ = context.Operators.SameAs(bd_, bi_, "day");
            bool? bk_ = context.Operators.And(ay_, bj_);
            DataType bl_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Physical?.Value;
            object bm_ = FHIRHelpers_4_3_000.Instance.ToValue(context, bl_);
            bool? bn_ = context.Operators.Not((bool?)(bm_ is null));
            bool? bo_ = context.Operators.And(bk_, bn_);
            object bq_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ak_);
            CqlInterval<CqlDateTime> br_ = QICoreCommon_2_0_000.Instance.ToInterval(context, bq_);
            CqlDateTime bs_ = context.Operators.Start(br_);
            CqlDate bt_ = context.Operators.DateFrom(bs_);
            DataType bu_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Pain?.Effective;
            object bv_ = FHIRHelpers_4_3_000.Instance.ToValue(context, bu_);
            CqlInterval<CqlDateTime> bw_ = QICoreCommon_2_0_000.Instance.ToInterval(context, bv_);
            CqlDateTime bx_ = context.Operators.Start(bw_);
            CqlDate by_ = context.Operators.DateFrom(bx_);
            bool? bz_ = context.Operators.SameAs(bt_, by_, "day");
            bool? ca_ = context.Operators.And(bo_, bz_);
            DataType cb_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Pain?.Value;
            object cc_ = FHIRHelpers_4_3_000.Instance.ToValue(context, cb_);
            bool? cd_ = context.Operators.Not((bool?)(cc_ is null));
            bool? ce_ = context.Operators.And(ca_, cd_);
            object cg_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ak_);
            CqlInterval<CqlDateTime> ch_ = QICoreCommon_2_0_000.Instance.ToInterval(context, cg_);
            CqlDateTime ci_ = context.Operators.Start(ch_);
            CqlDate cj_ = context.Operators.DateFrom(ci_);
            DataType ck_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Fatigue?.Effective;
            object cl_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ck_);
            CqlInterval<CqlDateTime> cm_ = QICoreCommon_2_0_000.Instance.ToInterval(context, cl_);
            CqlDateTime cn_ = context.Operators.Start(cm_);
            CqlDate co_ = context.Operators.DateFrom(cn_);
            bool? cp_ = context.Operators.SameAs(cj_, co_, "day");
            bool? cq_ = context.Operators.And(ce_, cp_);
            DataType cr_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Fatigue?.Value;
            object cs_ = FHIRHelpers_4_3_000.Instance.ToValue(context, cr_);
            bool? ct_ = context.Operators.Not((bool?)(cs_ is null));
            bool? cu_ = context.Operators.And(cq_, ct_);
            object cw_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ak_);
            CqlInterval<CqlDateTime> cx_ = QICoreCommon_2_0_000.Instance.ToInterval(context, cw_);
            CqlDateTime cy_ = context.Operators.Start(cx_);
            CqlDate cz_ = context.Operators.DateFrom(cy_);
            DataType da_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Depression?.Effective;
            object db_ = FHIRHelpers_4_3_000.Instance.ToValue(context, da_);
            CqlInterval<CqlDateTime> dc_ = QICoreCommon_2_0_000.Instance.ToInterval(context, db_);
            CqlDateTime dd_ = context.Operators.Start(dc_);
            CqlDate de_ = context.Operators.DateFrom(dd_);
            bool? df_ = context.Operators.SameAs(cz_, de_, "day");
            bool? dg_ = context.Operators.And(cu_, df_);
            DataType dh_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Depression?.Value;
            object di_ = FHIRHelpers_4_3_000.Instance.ToValue(context, dh_);
            bool? dj_ = context.Operators.Not((bool?)(di_ is null));
            bool? dk_ = context.Operators.And(dg_, dj_);
            object dm_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ak_);
            CqlInterval<CqlDateTime> dn_ = QICoreCommon_2_0_000.Instance.ToInterval(context, dm_);
            CqlDateTime do_ = context.Operators.Start(dn_);
            CqlDate dp_ = context.Operators.DateFrom(do_);
            DataType dq_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Anxiety?.Effective;
            object dr_ = FHIRHelpers_4_3_000.Instance.ToValue(context, dq_);
            CqlInterval<CqlDateTime> ds_ = QICoreCommon_2_0_000.Instance.ToInterval(context, dr_);
            CqlDateTime dt_ = context.Operators.Start(ds_);
            CqlDate du_ = context.Operators.DateFrom(dt_);
            bool? dv_ = context.Operators.SameAs(dp_, du_, "day");
            bool? dw_ = context.Operators.And(dk_, dv_);
            DataType dx_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Anxiety?.Value;
            object dy_ = FHIRHelpers_4_3_000.Instance.ToValue(context, dx_);
            bool? dz_ = context.Operators.Not((bool?)(dy_ is null));
            bool? ea_ = context.Operators.And(dw_, dz_);
            DataType eb_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Sleep?.Value;
            object ec_ = FHIRHelpers_4_3_000.Instance.ToValue(context, eb_);
            bool? ed_ = context.Operators.Not((bool?)(ec_ is null));
            bool? ee_ = context.Operators.And(ea_, ed_);

            return ee_;
        };
        IEnumerable<(CqlTupleMetadata, Observation Promis29Sleep, Observation Promis29SocialRoles, Observation Promis29Physical, Observation Promis29Pain, Observation Promis29Fatigue, Observation Promis29Depression, Observation Promis29Anxiety)?> ag_ = context.Operators.Where<(CqlTupleMetadata, Observation Promis29Sleep, Observation Promis29SocialRoles, Observation Promis29Physical, Observation Promis29Pain, Observation Promis29Fatigue, Observation Promis29Depression, Observation Promis29Anxiety)?>(ae_, af_);
        CqlDate ah_((CqlTupleMetadata, Observation Promis29Sleep, Observation Promis29SocialRoles, Observation Promis29Physical, Observation Promis29Pain, Observation Promis29Fatigue, Observation Promis29Depression, Observation Promis29Anxiety)? tuple_cbgpsarvwrsewlglehinjanim)
        {
            DataType ef_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Sleep?.Effective;
            object eg_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ef_);
            CqlInterval<CqlDateTime> eh_ = QICoreCommon_2_0_000.Instance.ToInterval(context, eg_);
            CqlDateTime ei_ = context.Operators.Start(eh_);
            CqlDate ej_ = context.Operators.DateFrom(ei_);
            DataType ek_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29SocialRoles?.Effective;
            object el_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ek_);
            CqlInterval<CqlDateTime> em_ = QICoreCommon_2_0_000.Instance.ToInterval(context, el_);
            CqlDateTime en_ = context.Operators.Start(em_);
            CqlDate eo_ = context.Operators.DateFrom(en_);
            DataType ep_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Physical?.Effective;
            object eq_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ep_);
            CqlInterval<CqlDateTime> er_ = QICoreCommon_2_0_000.Instance.ToInterval(context, eq_);
            CqlDateTime es_ = context.Operators.Start(er_);
            CqlDate et_ = context.Operators.DateFrom(es_);
            DataType eu_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Pain?.Effective;
            object ev_ = FHIRHelpers_4_3_000.Instance.ToValue(context, eu_);
            CqlInterval<CqlDateTime> ew_ = QICoreCommon_2_0_000.Instance.ToInterval(context, ev_);
            CqlDateTime ex_ = context.Operators.Start(ew_);
            CqlDate ey_ = context.Operators.DateFrom(ex_);
            DataType ez_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Fatigue?.Effective;
            object fa_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ez_);
            CqlInterval<CqlDateTime> fb_ = QICoreCommon_2_0_000.Instance.ToInterval(context, fa_);
            CqlDateTime fc_ = context.Operators.Start(fb_);
            CqlDate fd_ = context.Operators.DateFrom(fc_);
            DataType fe_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Depression?.Effective;
            object ff_ = FHIRHelpers_4_3_000.Instance.ToValue(context, fe_);
            CqlInterval<CqlDateTime> fg_ = QICoreCommon_2_0_000.Instance.ToInterval(context, ff_);
            CqlDateTime fh_ = context.Operators.Start(fg_);
            CqlDate fi_ = context.Operators.DateFrom(fh_);
            DataType fj_ = tuple_cbgpsarvwrsewlglehinjanim?.Promis29Anxiety?.Effective;
            object fk_ = FHIRHelpers_4_3_000.Instance.ToValue(context, fj_);
            CqlInterval<CqlDateTime> fl_ = QICoreCommon_2_0_000.Instance.ToInterval(context, fk_);
            CqlDateTime fm_ = context.Operators.Start(fl_);
            CqlDate fn_ = context.Operators.DateFrom(fm_);
            CqlDate[] fo_ = [
                ej_,
                eo_,
                et_,
                ey_,
                fd_,
                fi_,
                fn_,
            ];
            CqlDate fp_ = context.Operators.Max<CqlDate>(fo_ as IEnumerable<CqlDate>);

            return fp_;
        };
        IEnumerable<CqlDate> ai_ = context.Operators.Select<(CqlTupleMetadata, Observation Promis29Sleep, Observation Promis29SocialRoles, Observation Promis29Physical, Observation Promis29Pain, Observation Promis29Fatigue, Observation Promis29Depression, Observation Promis29Anxiety)?, CqlDate>(ag_, ah_);

        return ai_;
    }


    [CqlDeclaration("Has Encounter with Initial and Follow Up PROMIS29 Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_PROMIS29_Assessments(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounters(context);
        IEnumerable<CqlDate> b_ = this.Date_PROMIS29_Total_Assessment_Completed(context);
        IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> d_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(a_, b_, b_);
        (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS29Date, CqlDate FollowupPROMIS29Date)? e_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS29Date, CqlDate FollowupPROMIS29Date)? l_ = (CqlTupleMetadata_KMPNTXjUhKPBcWGfTQIGieaO, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return l_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS29Date, CqlDate FollowupPROMIS29Date)?> f_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS29Date, CqlDate FollowupPROMIS29Date)?>(d_, e_);
        bool? g_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS29Date, CqlDate FollowupPROMIS29Date)? tuple_kmpntxjuhkpbcwgftqigieao)
        {
            Period m_ = tuple_kmpntxjuhkpbcwgftqigieao?.ValidEncounters?.Period;
            CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, m_);
            CqlInterval<CqlDateTime> o_ = QICoreCommon_2_0_000.Instance.ToInterval(context, n_ as object);
            CqlDateTime p_ = context.Operators.End(o_);
            CqlInterval<CqlDateTime> q_ = this.Measurement_Period(context);
            CqlDateTime r_ = context.Operators.End(q_);
            CqlQuantity s_ = context.Operators.Quantity(180m, "days");
            CqlDateTime t_ = context.Operators.Subtract(r_, s_);
            bool? u_ = context.Operators.SameOrBefore(p_, t_, "day");
            CqlDateTime v_ = context.Operators.ConvertDateToDateTime(tuple_kmpntxjuhkpbcwgftqigieao?.InitialPROMIS29Date);
            CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, m_);
            CqlInterval<CqlDateTime> y_ = QICoreCommon_2_0_000.Instance.ToInterval(context, x_ as object);
            CqlDateTime z_ = context.Operators.End(y_);
            CqlQuantity aa_ = context.Operators.Quantity(14m, "days");
            CqlDateTime ab_ = context.Operators.Subtract(z_, aa_);
            CqlInterval<CqlDateTime> ad_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, m_);
            CqlInterval<CqlDateTime> ae_ = QICoreCommon_2_0_000.Instance.ToInterval(context, ad_ as object);
            CqlDateTime af_ = context.Operators.End(ae_);
            CqlInterval<CqlDateTime> ag_ = context.Operators.Interval(ab_, af_, true, true);
            bool? ah_ = context.Operators.In<CqlDateTime>(v_, ag_, "day");
            CqlInterval<CqlDateTime> aj_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, m_);
            CqlInterval<CqlDateTime> ak_ = QICoreCommon_2_0_000.Instance.ToInterval(context, aj_ as object);
            CqlDateTime al_ = context.Operators.End(ak_);
            bool? am_ = context.Operators.Not((bool?)(al_ is null));
            bool? an_ = context.Operators.And(ah_, am_);
            bool? ao_ = context.Operators.And(u_, an_);
            CqlDateTime ap_ = context.Operators.ConvertDateToDateTime(tuple_kmpntxjuhkpbcwgftqigieao?.FollowupPROMIS29Date);
            CqlDate aq_ = context.Operators.DateFrom(ap_);
            CqlDate as_ = context.Operators.DateFrom(v_);
            CqlQuantity at_ = context.Operators.Quantity(30m, "days");
            CqlDate au_ = context.Operators.Add(as_, at_);
            CqlDate aw_ = context.Operators.DateFrom(v_);
            CqlDate ay_ = context.Operators.Add(aw_, s_);
            CqlInterval<CqlDate> az_ = context.Operators.Interval(au_, ay_, true, true);
            bool? ba_ = context.Operators.In<CqlDate>(aq_, az_, "day");
            bool? bb_ = context.Operators.And(ao_, ba_);

            return bb_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS29Date, CqlDate FollowupPROMIS29Date)?> h_ = context.Operators.Where<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS29Date, CqlDate FollowupPROMIS29Date)?>(f_, g_);
        Encounter i_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS29Date, CqlDate FollowupPROMIS29Date)? tuple_kmpntxjuhkpbcwgftqigieao) => 
            tuple_kmpntxjuhkpbcwgftqigieao?.ValidEncounters;
        IEnumerable<Encounter> j_ = context.Operators.Select<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialPROMIS29Date, CqlDate FollowupPROMIS29Date)?, Encounter>(h_, i_);
        bool? k_ = context.Operators.Exists<Encounter>(j_);

        return k_;
    }


    [CqlDeclaration("Date VR12 Oblique Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_VR12_Oblique_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode a_ = this.VR_12_Mental_component_summary__MCS__score___oblique_method_T_score(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> d_ = Status_1_6_000.Instance.Final_Survey_Observation(context, c_);
        CqlCode e_ = this.VR_12_Physical_component_summary__PCS__score___oblique_method_T_score(context);
        IEnumerable<CqlCode> f_ = context.Operators.ToList<CqlCode>(e_);
        IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, f_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> h_ = Status_1_6_000.Instance.Final_Survey_Observation(context, g_);
        IEnumerable<ValueTuple<Observation, Observation>> i_ = context.Operators.CrossJoin<Observation, Observation>(d_, h_);
        (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? j_(ValueTuple<Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? p_ = (CqlTupleMetadata_GAdRFKRaHUUGJcVHWQWRUjhRH, _valueTuple.Item1, _valueTuple.Item2);

            return p_;
        };
        IEnumerable<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?> k_ = context.Operators.Select<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?>(i_, j_);
        bool? l_((CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? tuple_gadrfkrahuugjcvhwqwrujhrh)
        {
            DataType q_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Effective;
            object r_ = FHIRHelpers_4_3_000.Instance.ToValue(context, q_);
            CqlInterval<CqlDateTime> s_ = QICoreCommon_2_0_000.Instance.ToInterval(context, r_);
            CqlDateTime t_ = context.Operators.Start(s_);
            CqlDate u_ = context.Operators.DateFrom(t_);
            DataType v_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Effective;
            object w_ = FHIRHelpers_4_3_000.Instance.ToValue(context, v_);
            CqlInterval<CqlDateTime> x_ = QICoreCommon_2_0_000.Instance.ToInterval(context, w_);
            CqlDateTime y_ = context.Operators.Start(x_);
            CqlDate z_ = context.Operators.DateFrom(y_);
            bool? aa_ = context.Operators.SameAs(u_, z_, "day");
            DataType ab_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Value;
            object ac_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ab_);
            bool? ad_ = context.Operators.Not((bool?)(ac_ is null));
            bool? ae_ = context.Operators.And(aa_, ad_);
            DataType af_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Value;
            object ag_ = FHIRHelpers_4_3_000.Instance.ToValue(context, af_);
            bool? ah_ = context.Operators.Not((bool?)(ag_ is null));
            bool? ai_ = context.Operators.And(ae_, ah_);

            return ai_;
        };
        IEnumerable<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?> m_ = context.Operators.Where<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?>(k_, l_);
        CqlDate n_((CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? tuple_gadrfkrahuugjcvhwqwrujhrh)
        {
            DataType aj_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Effective;
            object ak_ = FHIRHelpers_4_3_000.Instance.ToValue(context, aj_);
            CqlInterval<CqlDateTime> al_ = QICoreCommon_2_0_000.Instance.ToInterval(context, ak_);
            CqlDateTime am_ = context.Operators.Start(al_);
            CqlDate an_ = context.Operators.DateFrom(am_);
            DataType ao_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Effective;
            object ap_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ao_);
            CqlInterval<CqlDateTime> aq_ = QICoreCommon_2_0_000.Instance.ToInterval(context, ap_);
            CqlDateTime ar_ = context.Operators.Start(aq_);
            CqlDate as_ = context.Operators.DateFrom(ar_);
            CqlDate[] at_ = [
                an_,
                as_,
            ];
            CqlDate au_ = context.Operators.Max<CqlDate>(at_ as IEnumerable<CqlDate>);

            return au_;
        };
        IEnumerable<CqlDate> o_ = context.Operators.Select<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?, CqlDate>(m_, n_);

        return o_;
    }


    [CqlDeclaration("Has Encounter with Initial and Follow Up VR12 Oblique Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_VR12_Oblique_Assessments(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounters(context);
        IEnumerable<CqlDate> b_ = this.Date_VR12_Oblique_Total_Assessment_Completed(context);
        IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> d_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(a_, b_, b_);
        (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12ObliqueDate, CqlDate FollowupVR12ObliqueDate)? e_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12ObliqueDate, CqlDate FollowupVR12ObliqueDate)? l_ = (CqlTupleMetadata_FPPKTdIagiEKHPTNSBAcPSWH, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return l_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12ObliqueDate, CqlDate FollowupVR12ObliqueDate)?> f_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12ObliqueDate, CqlDate FollowupVR12ObliqueDate)?>(d_, e_);
        bool? g_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12ObliqueDate, CqlDate FollowupVR12ObliqueDate)? tuple_fppktdiagiekhptnsbacpswh)
        {
            Period m_ = tuple_fppktdiagiekhptnsbacpswh?.ValidEncounters?.Period;
            CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, m_);
            CqlInterval<CqlDateTime> o_ = QICoreCommon_2_0_000.Instance.ToInterval(context, n_ as object);
            CqlDateTime p_ = context.Operators.End(o_);
            CqlInterval<CqlDateTime> q_ = this.Measurement_Period(context);
            CqlDateTime r_ = context.Operators.End(q_);
            CqlQuantity s_ = context.Operators.Quantity(180m, "days");
            CqlDateTime t_ = context.Operators.Subtract(r_, s_);
            bool? u_ = context.Operators.SameOrBefore(p_, t_, "day");
            CqlDateTime v_ = context.Operators.ConvertDateToDateTime(tuple_fppktdiagiekhptnsbacpswh?.InitialVR12ObliqueDate);
            CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, m_);
            CqlInterval<CqlDateTime> y_ = QICoreCommon_2_0_000.Instance.ToInterval(context, x_ as object);
            CqlDateTime z_ = context.Operators.End(y_);
            CqlQuantity aa_ = context.Operators.Quantity(14m, "days");
            CqlDateTime ab_ = context.Operators.Subtract(z_, aa_);
            CqlInterval<CqlDateTime> ad_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, m_);
            CqlInterval<CqlDateTime> ae_ = QICoreCommon_2_0_000.Instance.ToInterval(context, ad_ as object);
            CqlDateTime af_ = context.Operators.End(ae_);
            CqlInterval<CqlDateTime> ag_ = context.Operators.Interval(ab_, af_, true, true);
            bool? ah_ = context.Operators.In<CqlDateTime>(v_, ag_, "day");
            CqlInterval<CqlDateTime> aj_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, m_);
            CqlInterval<CqlDateTime> ak_ = QICoreCommon_2_0_000.Instance.ToInterval(context, aj_ as object);
            CqlDateTime al_ = context.Operators.End(ak_);
            bool? am_ = context.Operators.Not((bool?)(al_ is null));
            bool? an_ = context.Operators.And(ah_, am_);
            bool? ao_ = context.Operators.And(u_, an_);
            CqlDateTime ap_ = context.Operators.ConvertDateToDateTime(tuple_fppktdiagiekhptnsbacpswh?.FollowupVR12ObliqueDate);
            CqlDate aq_ = context.Operators.DateFrom(ap_);
            CqlDate as_ = context.Operators.DateFrom(v_);
            CqlQuantity at_ = context.Operators.Quantity(30m, "days");
            CqlDate au_ = context.Operators.Add(as_, at_);
            CqlDate aw_ = context.Operators.DateFrom(v_);
            CqlDate ay_ = context.Operators.Add(aw_, s_);
            CqlInterval<CqlDate> az_ = context.Operators.Interval(au_, ay_, true, true);
            bool? ba_ = context.Operators.In<CqlDate>(aq_, az_, "day");
            bool? bb_ = context.Operators.And(ao_, ba_);

            return bb_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12ObliqueDate, CqlDate FollowupVR12ObliqueDate)?> h_ = context.Operators.Where<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12ObliqueDate, CqlDate FollowupVR12ObliqueDate)?>(f_, g_);
        Encounter i_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12ObliqueDate, CqlDate FollowupVR12ObliqueDate)? tuple_fppktdiagiekhptnsbacpswh) => 
            tuple_fppktdiagiekhptnsbacpswh?.ValidEncounters;
        IEnumerable<Encounter> j_ = context.Operators.Select<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12ObliqueDate, CqlDate FollowupVR12ObliqueDate)?, Encounter>(h_, i_);
        bool? k_ = context.Operators.Exists<Encounter>(j_);

        return k_;
    }


    [CqlDeclaration("Date VR12 Orthogonal Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_VR12_Orthogonal_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode a_ = this.VR_12_Mental_component_summary__MCS__score___orthogonal_method_T_score(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> d_ = Status_1_6_000.Instance.Final_Survey_Observation(context, c_);
        CqlCode e_ = this.VR_12_Physical_component_summary__PCS__score___orthogonal_method_T_score(context);
        IEnumerable<CqlCode> f_ = context.Operators.ToList<CqlCode>(e_);
        IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, f_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> h_ = Status_1_6_000.Instance.Final_Survey_Observation(context, g_);
        IEnumerable<ValueTuple<Observation, Observation>> i_ = context.Operators.CrossJoin<Observation, Observation>(d_, h_);
        (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? j_(ValueTuple<Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? p_ = (CqlTupleMetadata_GAdRFKRaHUUGJcVHWQWRUjhRH, _valueTuple.Item1, _valueTuple.Item2);

            return p_;
        };
        IEnumerable<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?> k_ = context.Operators.Select<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?>(i_, j_);
        bool? l_((CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? tuple_gadrfkrahuugjcvhwqwrujhrh)
        {
            DataType q_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Effective;
            object r_ = FHIRHelpers_4_3_000.Instance.ToValue(context, q_);
            CqlInterval<CqlDateTime> s_ = QICoreCommon_2_0_000.Instance.ToInterval(context, r_);
            CqlDateTime t_ = context.Operators.Start(s_);
            CqlDate u_ = context.Operators.DateFrom(t_);
            DataType v_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Effective;
            object w_ = FHIRHelpers_4_3_000.Instance.ToValue(context, v_);
            CqlInterval<CqlDateTime> x_ = QICoreCommon_2_0_000.Instance.ToInterval(context, w_);
            CqlDateTime y_ = context.Operators.Start(x_);
            CqlDate z_ = context.Operators.DateFrom(y_);
            bool? aa_ = context.Operators.SameAs(u_, z_, "day");
            DataType ab_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Value;
            object ac_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ab_);
            bool? ad_ = context.Operators.Not((bool?)(ac_ is null));
            bool? ae_ = context.Operators.And(aa_, ad_);
            DataType af_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Value;
            object ag_ = FHIRHelpers_4_3_000.Instance.ToValue(context, af_);
            bool? ah_ = context.Operators.Not((bool?)(ag_ is null));
            bool? ai_ = context.Operators.And(ae_, ah_);

            return ai_;
        };
        IEnumerable<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?> m_ = context.Operators.Where<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?>(k_, l_);
        CqlDate n_((CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)? tuple_gadrfkrahuugjcvhwqwrujhrh)
        {
            DataType aj_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12MentalAssessment?.Effective;
            object ak_ = FHIRHelpers_4_3_000.Instance.ToValue(context, aj_);
            CqlInterval<CqlDateTime> al_ = QICoreCommon_2_0_000.Instance.ToInterval(context, ak_);
            CqlDateTime am_ = context.Operators.Start(al_);
            CqlDate an_ = context.Operators.DateFrom(am_);
            DataType ao_ = tuple_gadrfkrahuugjcvhwqwrujhrh?.VR12PhysicalAssessment?.Effective;
            object ap_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ao_);
            CqlInterval<CqlDateTime> aq_ = QICoreCommon_2_0_000.Instance.ToInterval(context, ap_);
            CqlDateTime ar_ = context.Operators.Start(aq_);
            CqlDate as_ = context.Operators.DateFrom(ar_);
            CqlDate[] at_ = [
                an_,
                as_,
            ];
            CqlDate au_ = context.Operators.Max<CqlDate>(at_ as IEnumerable<CqlDate>);

            return au_;
        };
        IEnumerable<CqlDate> o_ = context.Operators.Select<(CqlTupleMetadata, Observation VR12MentalAssessment, Observation VR12PhysicalAssessment)?, CqlDate>(m_, n_);

        return o_;
    }


    [CqlDeclaration("Has Encounter with Initial and Follow Up VR12 Orthogonal Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_VR12_Orthogonal_Assessments(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounters(context);
        IEnumerable<CqlDate> b_ = this.Date_VR12_Orthogonal_Total_Assessment_Completed(context);
        IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> d_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(a_, b_, b_);
        (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12OrthogonalDate, CqlDate FollowupVR12OrthogonalDate)? e_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12OrthogonalDate, CqlDate FollowupVR12OrthogonalDate)? l_ = (CqlTupleMetadata_FaNSVMJaEDMVSdOYROZXdLSaI, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return l_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12OrthogonalDate, CqlDate FollowupVR12OrthogonalDate)?> f_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12OrthogonalDate, CqlDate FollowupVR12OrthogonalDate)?>(d_, e_);
        bool? g_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12OrthogonalDate, CqlDate FollowupVR12OrthogonalDate)? tuple_fansvmjaedmvsdoyrozxdlsai)
        {
            Period m_ = tuple_fansvmjaedmvsdoyrozxdlsai?.ValidEncounters?.Period;
            CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, m_);
            CqlInterval<CqlDateTime> o_ = QICoreCommon_2_0_000.Instance.ToInterval(context, n_ as object);
            CqlDateTime p_ = context.Operators.End(o_);
            CqlInterval<CqlDateTime> q_ = this.Measurement_Period(context);
            CqlDateTime r_ = context.Operators.End(q_);
            CqlQuantity s_ = context.Operators.Quantity(180m, "days");
            CqlDateTime t_ = context.Operators.Subtract(r_, s_);
            bool? u_ = context.Operators.SameOrBefore(p_, t_, "day");
            CqlDateTime v_ = context.Operators.ConvertDateToDateTime(tuple_fansvmjaedmvsdoyrozxdlsai?.InitialVR12OrthogonalDate);
            CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, m_);
            CqlInterval<CqlDateTime> y_ = QICoreCommon_2_0_000.Instance.ToInterval(context, x_ as object);
            CqlDateTime z_ = context.Operators.End(y_);
            CqlQuantity aa_ = context.Operators.Quantity(14m, "days");
            CqlDateTime ab_ = context.Operators.Subtract(z_, aa_);
            CqlInterval<CqlDateTime> ad_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, m_);
            CqlInterval<CqlDateTime> ae_ = QICoreCommon_2_0_000.Instance.ToInterval(context, ad_ as object);
            CqlDateTime af_ = context.Operators.End(ae_);
            CqlInterval<CqlDateTime> ag_ = context.Operators.Interval(ab_, af_, true, true);
            bool? ah_ = context.Operators.In<CqlDateTime>(v_, ag_, "day");
            CqlInterval<CqlDateTime> aj_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, m_);
            CqlInterval<CqlDateTime> ak_ = QICoreCommon_2_0_000.Instance.ToInterval(context, aj_ as object);
            CqlDateTime al_ = context.Operators.End(ak_);
            bool? am_ = context.Operators.Not((bool?)(al_ is null));
            bool? an_ = context.Operators.And(ah_, am_);
            bool? ao_ = context.Operators.And(u_, an_);
            CqlDateTime ap_ = context.Operators.ConvertDateToDateTime(tuple_fansvmjaedmvsdoyrozxdlsai?.FollowupVR12OrthogonalDate);
            CqlDate aq_ = context.Operators.DateFrom(ap_);
            CqlDate as_ = context.Operators.DateFrom(v_);
            CqlQuantity at_ = context.Operators.Quantity(30m, "days");
            CqlDate au_ = context.Operators.Add(as_, at_);
            CqlDate aw_ = context.Operators.DateFrom(v_);
            CqlDate ay_ = context.Operators.Add(aw_, s_);
            CqlInterval<CqlDate> az_ = context.Operators.Interval(au_, ay_, true, true);
            bool? ba_ = context.Operators.In<CqlDate>(aq_, az_, "day");
            bool? bb_ = context.Operators.And(ao_, ba_);

            return bb_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12OrthogonalDate, CqlDate FollowupVR12OrthogonalDate)?> h_ = context.Operators.Where<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12OrthogonalDate, CqlDate FollowupVR12OrthogonalDate)?>(f_, g_);
        Encounter i_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12OrthogonalDate, CqlDate FollowupVR12OrthogonalDate)? tuple_fansvmjaedmvsdoyrozxdlsai) => 
            tuple_fansvmjaedmvsdoyrozxdlsai?.ValidEncounters;
        IEnumerable<Encounter> j_ = context.Operators.Select<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR12OrthogonalDate, CqlDate FollowupVR12OrthogonalDate)?, Encounter>(h_, i_);
        bool? k_ = context.Operators.Exists<Encounter>(j_);

        return k_;
    }


    [CqlDeclaration("Date VR36 Oblique Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_VR36_Oblique_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode a_ = this.VR_36_Mental_component_summary__MCS__score___oblique_method_T_score(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> d_ = Status_1_6_000.Instance.Final_Survey_Observation(context, c_);
        CqlCode e_ = this.VR_36_Physical_component_summary__PCS__score___oblique_method_T_score(context);
        IEnumerable<CqlCode> f_ = context.Operators.ToList<CqlCode>(e_);
        IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, f_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> h_ = Status_1_6_000.Instance.Final_Survey_Observation(context, g_);
        IEnumerable<ValueTuple<Observation, Observation>> i_ = context.Operators.CrossJoin<Observation, Observation>(d_, h_);
        (CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)? j_(ValueTuple<Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)? p_ = (CqlTupleMetadata_DUcFTCLcQEWDGGQdFCWTHFaUK, _valueTuple.Item1, _valueTuple.Item2);

            return p_;
        };
        IEnumerable<(CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?> k_ = context.Operators.Select<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?>(i_, j_);
        bool? l_((CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)? tuple_ducftclcqewdggqdfcwthfauk)
        {
            DataType q_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36MentalAssessment?.Effective;
            object r_ = FHIRHelpers_4_3_000.Instance.ToValue(context, q_);
            CqlInterval<CqlDateTime> s_ = QICoreCommon_2_0_000.Instance.ToInterval(context, r_);
            CqlDateTime t_ = context.Operators.Start(s_);
            CqlDate u_ = context.Operators.DateFrom(t_);
            DataType v_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36PhysicalAssessment?.Effective;
            object w_ = FHIRHelpers_4_3_000.Instance.ToValue(context, v_);
            CqlInterval<CqlDateTime> x_ = QICoreCommon_2_0_000.Instance.ToInterval(context, w_);
            CqlDateTime y_ = context.Operators.Start(x_);
            CqlDate z_ = context.Operators.DateFrom(y_);
            bool? aa_ = context.Operators.SameAs(u_, z_, "day");
            DataType ab_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36MentalAssessment?.Value;
            object ac_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ab_);
            bool? ad_ = context.Operators.Not((bool?)(ac_ is null));
            bool? ae_ = context.Operators.And(aa_, ad_);
            DataType af_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36PhysicalAssessment?.Value;
            object ag_ = FHIRHelpers_4_3_000.Instance.ToValue(context, af_);
            bool? ah_ = context.Operators.Not((bool?)(ag_ is null));
            bool? ai_ = context.Operators.And(ae_, ah_);

            return ai_;
        };
        IEnumerable<(CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?> m_ = context.Operators.Where<(CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?>(k_, l_);
        CqlDate n_((CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)? tuple_ducftclcqewdggqdfcwthfauk)
        {
            DataType aj_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36MentalAssessment?.Effective;
            object ak_ = FHIRHelpers_4_3_000.Instance.ToValue(context, aj_);
            CqlInterval<CqlDateTime> al_ = QICoreCommon_2_0_000.Instance.ToInterval(context, ak_);
            CqlDateTime am_ = context.Operators.Start(al_);
            CqlDate an_ = context.Operators.DateFrom(am_);
            DataType ao_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36PhysicalAssessment?.Effective;
            object ap_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ao_);
            CqlInterval<CqlDateTime> aq_ = QICoreCommon_2_0_000.Instance.ToInterval(context, ap_);
            CqlDateTime ar_ = context.Operators.Start(aq_);
            CqlDate as_ = context.Operators.DateFrom(ar_);
            CqlDate[] at_ = [
                an_,
                as_,
            ];
            CqlDate au_ = context.Operators.Max<CqlDate>(at_ as IEnumerable<CqlDate>);

            return au_;
        };
        IEnumerable<CqlDate> o_ = context.Operators.Select<(CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?, CqlDate>(m_, n_);

        return o_;
    }


    [CqlDeclaration("Has Encounter with Initial and Follow Up VR36 Oblique Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_VR36_Oblique_Assessments(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounters(context);
        IEnumerable<CqlDate> b_ = this.Date_VR36_Oblique_Total_Assessment_Completed(context);
        IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> d_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(a_, b_, b_);
        (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36ObliqueDate, CqlDate FollowupVR36ObliqueDate)? e_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36ObliqueDate, CqlDate FollowupVR36ObliqueDate)? l_ = (CqlTupleMetadata_ELXIcYHRDPYZPQYJPHdiFBiGA, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return l_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36ObliqueDate, CqlDate FollowupVR36ObliqueDate)?> f_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36ObliqueDate, CqlDate FollowupVR36ObliqueDate)?>(d_, e_);
        bool? g_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36ObliqueDate, CqlDate FollowupVR36ObliqueDate)? tuple_elxicyhrdpyzpqyjphdifbiga)
        {
            Period m_ = tuple_elxicyhrdpyzpqyjphdifbiga?.ValidEncounters?.Period;
            CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, m_);
            CqlInterval<CqlDateTime> o_ = QICoreCommon_2_0_000.Instance.ToInterval(context, n_ as object);
            CqlDateTime p_ = context.Operators.End(o_);
            CqlInterval<CqlDateTime> q_ = this.Measurement_Period(context);
            CqlDateTime r_ = context.Operators.End(q_);
            CqlQuantity s_ = context.Operators.Quantity(180m, "days");
            CqlDateTime t_ = context.Operators.Subtract(r_, s_);
            bool? u_ = context.Operators.SameOrBefore(p_, t_, "day");
            CqlDateTime v_ = context.Operators.ConvertDateToDateTime(tuple_elxicyhrdpyzpqyjphdifbiga?.InitialVR36ObliqueDate);
            CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, m_);
            CqlInterval<CqlDateTime> y_ = QICoreCommon_2_0_000.Instance.ToInterval(context, x_ as object);
            CqlDateTime z_ = context.Operators.End(y_);
            CqlQuantity aa_ = context.Operators.Quantity(14m, "days");
            CqlDateTime ab_ = context.Operators.Subtract(z_, aa_);
            CqlInterval<CqlDateTime> ad_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, m_);
            CqlInterval<CqlDateTime> ae_ = QICoreCommon_2_0_000.Instance.ToInterval(context, ad_ as object);
            CqlDateTime af_ = context.Operators.End(ae_);
            CqlInterval<CqlDateTime> ag_ = context.Operators.Interval(ab_, af_, true, true);
            bool? ah_ = context.Operators.In<CqlDateTime>(v_, ag_, "day");
            CqlInterval<CqlDateTime> aj_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, m_);
            CqlInterval<CqlDateTime> ak_ = QICoreCommon_2_0_000.Instance.ToInterval(context, aj_ as object);
            CqlDateTime al_ = context.Operators.End(ak_);
            bool? am_ = context.Operators.Not((bool?)(al_ is null));
            bool? an_ = context.Operators.And(ah_, am_);
            bool? ao_ = context.Operators.And(u_, an_);
            CqlDateTime ap_ = context.Operators.ConvertDateToDateTime(tuple_elxicyhrdpyzpqyjphdifbiga?.FollowupVR36ObliqueDate);
            CqlDate aq_ = context.Operators.DateFrom(ap_);
            CqlDate as_ = context.Operators.DateFrom(v_);
            CqlQuantity at_ = context.Operators.Quantity(30m, "days");
            CqlDate au_ = context.Operators.Add(as_, at_);
            CqlDate aw_ = context.Operators.DateFrom(v_);
            CqlDate ay_ = context.Operators.Add(aw_, s_);
            CqlInterval<CqlDate> az_ = context.Operators.Interval(au_, ay_, true, true);
            bool? ba_ = context.Operators.In<CqlDate>(aq_, az_, "day");
            bool? bb_ = context.Operators.And(ao_, ba_);

            return bb_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36ObliqueDate, CqlDate FollowupVR36ObliqueDate)?> h_ = context.Operators.Where<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36ObliqueDate, CqlDate FollowupVR36ObliqueDate)?>(f_, g_);
        Encounter i_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36ObliqueDate, CqlDate FollowupVR36ObliqueDate)? tuple_elxicyhrdpyzpqyjphdifbiga) => 
            tuple_elxicyhrdpyzpqyjphdifbiga?.ValidEncounters;
        IEnumerable<Encounter> j_ = context.Operators.Select<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36ObliqueDate, CqlDate FollowupVR36ObliqueDate)?, Encounter>(h_, i_);
        bool? k_ = context.Operators.Exists<Encounter>(j_);

        return k_;
    }


    [CqlDeclaration("Date VR36 Orthogonal Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_VR36_Orthogonal_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode a_ = this.VR_36_Mental_component_summary__MCS__score___orthogonal_method_T_score(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> d_ = Status_1_6_000.Instance.Final_Survey_Observation(context, c_);
        CqlCode e_ = this.VR_36_Physical_component_summary__PCS__score___orthogonal_method_T_score(context);
        IEnumerable<CqlCode> f_ = context.Operators.ToList<CqlCode>(e_);
        IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, f_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> h_ = Status_1_6_000.Instance.Final_Survey_Observation(context, g_);
        IEnumerable<ValueTuple<Observation, Observation>> i_ = context.Operators.CrossJoin<Observation, Observation>(d_, h_);
        (CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)? j_(ValueTuple<Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)? p_ = (CqlTupleMetadata_DUcFTCLcQEWDGGQdFCWTHFaUK, _valueTuple.Item1, _valueTuple.Item2);

            return p_;
        };
        IEnumerable<(CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?> k_ = context.Operators.Select<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?>(i_, j_);
        bool? l_((CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)? tuple_ducftclcqewdggqdfcwthfauk)
        {
            DataType q_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36MentalAssessment?.Effective;
            object r_ = FHIRHelpers_4_3_000.Instance.ToValue(context, q_);
            CqlInterval<CqlDateTime> s_ = QICoreCommon_2_0_000.Instance.ToInterval(context, r_);
            CqlDateTime t_ = context.Operators.Start(s_);
            CqlDate u_ = context.Operators.DateFrom(t_);
            DataType v_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36PhysicalAssessment?.Effective;
            object w_ = FHIRHelpers_4_3_000.Instance.ToValue(context, v_);
            CqlInterval<CqlDateTime> x_ = QICoreCommon_2_0_000.Instance.ToInterval(context, w_);
            CqlDateTime y_ = context.Operators.Start(x_);
            CqlDate z_ = context.Operators.DateFrom(y_);
            bool? aa_ = context.Operators.SameAs(u_, z_, "day");
            DataType ab_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36MentalAssessment?.Value;
            object ac_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ab_);
            bool? ad_ = context.Operators.Not((bool?)(ac_ is null));
            bool? ae_ = context.Operators.And(aa_, ad_);
            DataType af_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36PhysicalAssessment?.Value;
            object ag_ = FHIRHelpers_4_3_000.Instance.ToValue(context, af_);
            bool? ah_ = context.Operators.Not((bool?)(ag_ is null));
            bool? ai_ = context.Operators.And(ae_, ah_);

            return ai_;
        };
        IEnumerable<(CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?> m_ = context.Operators.Where<(CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?>(k_, l_);
        CqlDate n_((CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)? tuple_ducftclcqewdggqdfcwthfauk)
        {
            DataType aj_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36MentalAssessment?.Effective;
            object ak_ = FHIRHelpers_4_3_000.Instance.ToValue(context, aj_);
            CqlInterval<CqlDateTime> al_ = QICoreCommon_2_0_000.Instance.ToInterval(context, ak_);
            CqlDateTime am_ = context.Operators.Start(al_);
            CqlDate an_ = context.Operators.DateFrom(am_);
            DataType ao_ = tuple_ducftclcqewdggqdfcwthfauk?.VR36PhysicalAssessment?.Effective;
            object ap_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ao_);
            CqlInterval<CqlDateTime> aq_ = QICoreCommon_2_0_000.Instance.ToInterval(context, ap_);
            CqlDateTime ar_ = context.Operators.Start(aq_);
            CqlDate as_ = context.Operators.DateFrom(ar_);
            CqlDate[] at_ = [
                an_,
                as_,
            ];
            CqlDate au_ = context.Operators.Max<CqlDate>(at_ as IEnumerable<CqlDate>);

            return au_;
        };
        IEnumerable<CqlDate> o_ = context.Operators.Select<(CqlTupleMetadata, Observation VR36MentalAssessment, Observation VR36PhysicalAssessment)?, CqlDate>(m_, n_);

        return o_;
    }


    [CqlDeclaration("Has Encounter with Initial and Follow Up VR36 Orthogonal Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_VR36_Orthogonal_Assessments(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounters(context);
        IEnumerable<CqlDate> b_ = this.Date_VR36_Orthogonal_Total_Assessment_Completed(context);
        IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> d_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(a_, b_, b_);
        (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36OrthogonalDate, CqlDate FollowupVR36OrthogonalDate)? e_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36OrthogonalDate, CqlDate FollowupVR36OrthogonalDate)? l_ = (CqlTupleMetadata_fUCQUjAdjiZABIHDfFFORMHT, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return l_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36OrthogonalDate, CqlDate FollowupVR36OrthogonalDate)?> f_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36OrthogonalDate, CqlDate FollowupVR36OrthogonalDate)?>(d_, e_);
        bool? g_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36OrthogonalDate, CqlDate FollowupVR36OrthogonalDate)? tuple_fucqujadjizabihdffformht)
        {
            Period m_ = tuple_fucqujadjizabihdffformht?.ValidEncounters?.Period;
            CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, m_);
            CqlInterval<CqlDateTime> o_ = QICoreCommon_2_0_000.Instance.ToInterval(context, n_ as object);
            CqlDateTime p_ = context.Operators.End(o_);
            CqlInterval<CqlDateTime> q_ = this.Measurement_Period(context);
            CqlDateTime r_ = context.Operators.End(q_);
            CqlQuantity s_ = context.Operators.Quantity(180m, "days");
            CqlDateTime t_ = context.Operators.Subtract(r_, s_);
            bool? u_ = context.Operators.SameOrBefore(p_, t_, "day");
            CqlDateTime v_ = context.Operators.ConvertDateToDateTime(tuple_fucqujadjizabihdffformht?.InitialVR36OrthogonalDate);
            CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, m_);
            CqlInterval<CqlDateTime> y_ = QICoreCommon_2_0_000.Instance.ToInterval(context, x_ as object);
            CqlDateTime z_ = context.Operators.End(y_);
            CqlQuantity aa_ = context.Operators.Quantity(14m, "days");
            CqlDateTime ab_ = context.Operators.Subtract(z_, aa_);
            CqlInterval<CqlDateTime> ad_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, m_);
            CqlInterval<CqlDateTime> ae_ = QICoreCommon_2_0_000.Instance.ToInterval(context, ad_ as object);
            CqlDateTime af_ = context.Operators.End(ae_);
            CqlInterval<CqlDateTime> ag_ = context.Operators.Interval(ab_, af_, true, true);
            bool? ah_ = context.Operators.In<CqlDateTime>(v_, ag_, "day");
            CqlInterval<CqlDateTime> aj_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, m_);
            CqlInterval<CqlDateTime> ak_ = QICoreCommon_2_0_000.Instance.ToInterval(context, aj_ as object);
            CqlDateTime al_ = context.Operators.End(ak_);
            bool? am_ = context.Operators.Not((bool?)(al_ is null));
            bool? an_ = context.Operators.And(ah_, am_);
            bool? ao_ = context.Operators.And(u_, an_);
            CqlDateTime ap_ = context.Operators.ConvertDateToDateTime(tuple_fucqujadjizabihdffformht?.FollowupVR36OrthogonalDate);
            CqlDate aq_ = context.Operators.DateFrom(ap_);
            CqlDate as_ = context.Operators.DateFrom(v_);
            CqlQuantity at_ = context.Operators.Quantity(30m, "days");
            CqlDate au_ = context.Operators.Add(as_, at_);
            CqlDate aw_ = context.Operators.DateFrom(v_);
            CqlDate ay_ = context.Operators.Add(aw_, s_);
            CqlInterval<CqlDate> az_ = context.Operators.Interval(au_, ay_, true, true);
            bool? ba_ = context.Operators.In<CqlDate>(aq_, az_, "day");
            bool? bb_ = context.Operators.And(ao_, ba_);

            return bb_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36OrthogonalDate, CqlDate FollowupVR36OrthogonalDate)?> h_ = context.Operators.Where<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36OrthogonalDate, CqlDate FollowupVR36OrthogonalDate)?>(f_, g_);
        Encounter i_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36OrthogonalDate, CqlDate FollowupVR36OrthogonalDate)? tuple_fucqujadjizabihdffformht) => 
            tuple_fucqujadjizabihdffformht?.ValidEncounters;
        IEnumerable<Encounter> j_ = context.Operators.Select<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialVR36OrthogonalDate, CqlDate FollowupVR36OrthogonalDate)?, Encounter>(h_, i_);
        bool? k_ = context.Operators.Exists<Encounter>(j_);

        return k_;
    }


    [CqlDeclaration("Date MLHFQ Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_MLHFQ_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode a_ = this.Physical_score__MLHFQ_(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> d_ = Status_1_6_000.Instance.Final_Survey_Observation(context, c_);
        CqlCode e_ = this.Emotional_score__MLHFQ_(context);
        IEnumerable<CqlCode> f_ = context.Operators.ToList<CqlCode>(e_);
        IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, f_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> h_ = Status_1_6_000.Instance.Final_Survey_Observation(context, g_);
        IEnumerable<ValueTuple<Observation, Observation>> i_ = context.Operators.CrossJoin<Observation, Observation>(d_, h_);
        (CqlTupleMetadata, Observation MLHFQPhysical, Observation MLHFQEmotional)? j_(ValueTuple<Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation MLHFQPhysical, Observation MLHFQEmotional)? p_ = (CqlTupleMetadata_FNOFXCKadAeUSJERHBDQfOShE, _valueTuple.Item1, _valueTuple.Item2);

            return p_;
        };
        IEnumerable<(CqlTupleMetadata, Observation MLHFQPhysical, Observation MLHFQEmotional)?> k_ = context.Operators.Select<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation MLHFQPhysical, Observation MLHFQEmotional)?>(i_, j_);
        bool? l_((CqlTupleMetadata, Observation MLHFQPhysical, Observation MLHFQEmotional)? tuple_fnofxckadaeusjerhbdqfoshe)
        {
            DataType q_ = tuple_fnofxckadaeusjerhbdqfoshe?.MLHFQPhysical?.Effective;
            object r_ = FHIRHelpers_4_3_000.Instance.ToValue(context, q_);
            CqlInterval<CqlDateTime> s_ = QICoreCommon_2_0_000.Instance.ToInterval(context, r_);
            CqlDateTime t_ = context.Operators.Start(s_);
            CqlDate u_ = context.Operators.DateFrom(t_);
            DataType v_ = tuple_fnofxckadaeusjerhbdqfoshe?.MLHFQEmotional?.Effective;
            object w_ = FHIRHelpers_4_3_000.Instance.ToValue(context, v_);
            CqlInterval<CqlDateTime> x_ = QICoreCommon_2_0_000.Instance.ToInterval(context, w_);
            CqlDateTime y_ = context.Operators.Start(x_);
            CqlDate z_ = context.Operators.DateFrom(y_);
            bool? aa_ = context.Operators.SameAs(u_, z_, "day");
            DataType ab_ = tuple_fnofxckadaeusjerhbdqfoshe?.MLHFQPhysical?.Value;
            object ac_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ab_);
            bool? ad_ = context.Operators.Not((bool?)(ac_ is null));
            bool? ae_ = context.Operators.And(aa_, ad_);
            DataType af_ = tuple_fnofxckadaeusjerhbdqfoshe?.MLHFQEmotional?.Value;
            object ag_ = FHIRHelpers_4_3_000.Instance.ToValue(context, af_);
            bool? ah_ = context.Operators.Not((bool?)(ag_ is null));
            bool? ai_ = context.Operators.And(ae_, ah_);

            return ai_;
        };
        IEnumerable<(CqlTupleMetadata, Observation MLHFQPhysical, Observation MLHFQEmotional)?> m_ = context.Operators.Where<(CqlTupleMetadata, Observation MLHFQPhysical, Observation MLHFQEmotional)?>(k_, l_);
        CqlDate n_((CqlTupleMetadata, Observation MLHFQPhysical, Observation MLHFQEmotional)? tuple_fnofxckadaeusjerhbdqfoshe)
        {
            DataType aj_ = tuple_fnofxckadaeusjerhbdqfoshe?.MLHFQPhysical?.Effective;
            object ak_ = FHIRHelpers_4_3_000.Instance.ToValue(context, aj_);
            CqlInterval<CqlDateTime> al_ = QICoreCommon_2_0_000.Instance.ToInterval(context, ak_);
            CqlDateTime am_ = context.Operators.Start(al_);
            CqlDate an_ = context.Operators.DateFrom(am_);
            DataType ao_ = tuple_fnofxckadaeusjerhbdqfoshe?.MLHFQEmotional?.Effective;
            object ap_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ao_);
            CqlInterval<CqlDateTime> aq_ = QICoreCommon_2_0_000.Instance.ToInterval(context, ap_);
            CqlDateTime ar_ = context.Operators.Start(aq_);
            CqlDate as_ = context.Operators.DateFrom(ar_);
            CqlDate[] at_ = [
                an_,
                as_,
            ];
            CqlDate au_ = context.Operators.Max<CqlDate>(at_ as IEnumerable<CqlDate>);

            return au_;
        };
        IEnumerable<CqlDate> o_ = context.Operators.Select<(CqlTupleMetadata, Observation MLHFQPhysical, Observation MLHFQEmotional)?, CqlDate>(m_, n_);

        return o_;
    }


    [CqlDeclaration("Has Encounter with Initial and Follow Up MLHFQ Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_MLHFQ_Assessments(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounters(context);
        IEnumerable<CqlDate> b_ = this.Date_MLHFQ_Total_Assessment_Completed(context);
        IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> d_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(a_, b_, b_);
        (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialMLHFQDate, CqlDate FollowupMLHFQDate)? e_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialMLHFQDate, CqlDate FollowupMLHFQDate)? l_ = (CqlTupleMetadata_NCDAWCTNMBFMTibMiHSFBAIG, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return l_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialMLHFQDate, CqlDate FollowupMLHFQDate)?> f_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialMLHFQDate, CqlDate FollowupMLHFQDate)?>(d_, e_);
        bool? g_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialMLHFQDate, CqlDate FollowupMLHFQDate)? tuple_ncdawctnmbfmtibmihsfbaig)
        {
            Period m_ = tuple_ncdawctnmbfmtibmihsfbaig?.ValidEncounters?.Period;
            CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, m_);
            CqlInterval<CqlDateTime> o_ = QICoreCommon_2_0_000.Instance.ToInterval(context, n_ as object);
            CqlDateTime p_ = context.Operators.End(o_);
            CqlInterval<CqlDateTime> q_ = this.Measurement_Period(context);
            CqlDateTime r_ = context.Operators.End(q_);
            CqlQuantity s_ = context.Operators.Quantity(180m, "days");
            CqlDateTime t_ = context.Operators.Subtract(r_, s_);
            bool? u_ = context.Operators.SameOrBefore(p_, t_, "day");
            CqlDateTime v_ = context.Operators.ConvertDateToDateTime(tuple_ncdawctnmbfmtibmihsfbaig?.InitialMLHFQDate);
            CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, m_);
            CqlInterval<CqlDateTime> y_ = QICoreCommon_2_0_000.Instance.ToInterval(context, x_ as object);
            CqlDateTime z_ = context.Operators.End(y_);
            CqlQuantity aa_ = context.Operators.Quantity(14m, "days");
            CqlDateTime ab_ = context.Operators.Subtract(z_, aa_);
            CqlInterval<CqlDateTime> ad_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, m_);
            CqlInterval<CqlDateTime> ae_ = QICoreCommon_2_0_000.Instance.ToInterval(context, ad_ as object);
            CqlDateTime af_ = context.Operators.End(ae_);
            CqlInterval<CqlDateTime> ag_ = context.Operators.Interval(ab_, af_, true, true);
            bool? ah_ = context.Operators.In<CqlDateTime>(v_, ag_, "day");
            CqlInterval<CqlDateTime> aj_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, m_);
            CqlInterval<CqlDateTime> ak_ = QICoreCommon_2_0_000.Instance.ToInterval(context, aj_ as object);
            CqlDateTime al_ = context.Operators.End(ak_);
            bool? am_ = context.Operators.Not((bool?)(al_ is null));
            bool? an_ = context.Operators.And(ah_, am_);
            bool? ao_ = context.Operators.And(u_, an_);
            CqlDateTime ap_ = context.Operators.ConvertDateToDateTime(tuple_ncdawctnmbfmtibmihsfbaig?.FollowupMLHFQDate);
            CqlDate aq_ = context.Operators.DateFrom(ap_);
            CqlDate as_ = context.Operators.DateFrom(v_);
            CqlQuantity at_ = context.Operators.Quantity(30m, "days");
            CqlDate au_ = context.Operators.Add(as_, at_);
            CqlDate aw_ = context.Operators.DateFrom(v_);
            CqlDate ay_ = context.Operators.Add(aw_, s_);
            CqlInterval<CqlDate> az_ = context.Operators.Interval(au_, ay_, true, true);
            bool? ba_ = context.Operators.In<CqlDate>(aq_, az_, "day");
            bool? bb_ = context.Operators.And(ao_, ba_);

            return bb_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialMLHFQDate, CqlDate FollowupMLHFQDate)?> h_ = context.Operators.Where<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialMLHFQDate, CqlDate FollowupMLHFQDate)?>(f_, g_);
        Encounter i_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialMLHFQDate, CqlDate FollowupMLHFQDate)? tuple_ncdawctnmbfmtibmihsfbaig) => 
            tuple_ncdawctnmbfmtibmihsfbaig?.ValidEncounters;
        IEnumerable<Encounter> j_ = context.Operators.Select<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialMLHFQDate, CqlDate FollowupMLHFQDate)?, Encounter>(h_, i_);
        bool? k_ = context.Operators.Exists<Encounter>(j_);

        return k_;
    }


    [CqlDeclaration("Date KCCQ12 Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_KCCQ12_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode a_ = this.Kansas_City_Cardiomyopathy_Questionnaire___12_item__KCCQ_12_(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> d_ = Status_1_6_000.Instance.Final_Survey_Observation(context, c_);
        CqlCode e_ = this.Overall_summary_score__KCCQ_12_(context);
        IEnumerable<CqlCode> f_ = context.Operators.ToList<CqlCode>(e_);
        IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, f_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> h_ = Status_1_6_000.Instance.Final_Survey_Observation(context, g_);
        IEnumerable<ValueTuple<Observation, Observation>> i_ = context.Operators.CrossJoin<Observation, Observation>(d_, h_);
        (CqlTupleMetadata, Observation KCCQ12Item, Observation KCCQ12Summary)? j_(ValueTuple<Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation KCCQ12Item, Observation KCCQ12Summary)? p_ = (CqlTupleMetadata_DFKXORghhYafccUSbQaMfNTDj, _valueTuple.Item1, _valueTuple.Item2);

            return p_;
        };
        IEnumerable<(CqlTupleMetadata, Observation KCCQ12Item, Observation KCCQ12Summary)?> k_ = context.Operators.Select<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation KCCQ12Item, Observation KCCQ12Summary)?>(i_, j_);
        bool? l_((CqlTupleMetadata, Observation KCCQ12Item, Observation KCCQ12Summary)? tuple_dfkxorghhyafccusbqamfntdj)
        {
            DataType q_ = tuple_dfkxorghhyafccusbqamfntdj?.KCCQ12Item?.Effective;
            object r_ = FHIRHelpers_4_3_000.Instance.ToValue(context, q_);
            CqlInterval<CqlDateTime> s_ = QICoreCommon_2_0_000.Instance.ToInterval(context, r_);
            CqlDateTime t_ = context.Operators.Start(s_);
            CqlDate u_ = context.Operators.DateFrom(t_);
            DataType v_ = tuple_dfkxorghhyafccusbqamfntdj?.KCCQ12Summary?.Effective;
            object w_ = FHIRHelpers_4_3_000.Instance.ToValue(context, v_);
            CqlInterval<CqlDateTime> x_ = QICoreCommon_2_0_000.Instance.ToInterval(context, w_);
            CqlDateTime y_ = context.Operators.Start(x_);
            CqlDate z_ = context.Operators.DateFrom(y_);
            bool? aa_ = context.Operators.SameAs(u_, z_, "day");
            DataType ab_ = tuple_dfkxorghhyafccusbqamfntdj?.KCCQ12Item?.Value;
            object ac_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ab_);
            bool? ad_ = context.Operators.Not((bool?)(ac_ is null));
            bool? ae_ = context.Operators.And(aa_, ad_);
            DataType af_ = tuple_dfkxorghhyafccusbqamfntdj?.KCCQ12Summary?.Value;
            object ag_ = FHIRHelpers_4_3_000.Instance.ToValue(context, af_);
            bool? ah_ = context.Operators.Not((bool?)(ag_ is null));
            bool? ai_ = context.Operators.And(ae_, ah_);

            return ai_;
        };
        IEnumerable<(CqlTupleMetadata, Observation KCCQ12Item, Observation KCCQ12Summary)?> m_ = context.Operators.Where<(CqlTupleMetadata, Observation KCCQ12Item, Observation KCCQ12Summary)?>(k_, l_);
        CqlDate n_((CqlTupleMetadata, Observation KCCQ12Item, Observation KCCQ12Summary)? tuple_dfkxorghhyafccusbqamfntdj)
        {
            DataType aj_ = tuple_dfkxorghhyafccusbqamfntdj?.KCCQ12Item?.Effective;
            object ak_ = FHIRHelpers_4_3_000.Instance.ToValue(context, aj_);
            CqlInterval<CqlDateTime> al_ = QICoreCommon_2_0_000.Instance.ToInterval(context, ak_);
            CqlDateTime am_ = context.Operators.Start(al_);
            CqlDate an_ = context.Operators.DateFrom(am_);
            DataType ao_ = tuple_dfkxorghhyafccusbqamfntdj?.KCCQ12Summary?.Effective;
            object ap_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ao_);
            CqlInterval<CqlDateTime> aq_ = QICoreCommon_2_0_000.Instance.ToInterval(context, ap_);
            CqlDateTime ar_ = context.Operators.Start(aq_);
            CqlDate as_ = context.Operators.DateFrom(ar_);
            CqlDate[] at_ = [
                an_,
                as_,
            ];
            CqlDate au_ = context.Operators.Max<CqlDate>(at_ as IEnumerable<CqlDate>);

            return au_;
        };
        IEnumerable<CqlDate> o_ = context.Operators.Select<(CqlTupleMetadata, Observation KCCQ12Item, Observation KCCQ12Summary)?, CqlDate>(m_, n_);

        return o_;
    }


    [CqlDeclaration("Has Encounter with Initial and Follow Up KCCQ12 Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_KCCQ12_Assessments(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounters(context);
        IEnumerable<CqlDate> b_ = this.Date_KCCQ12_Total_Assessment_Completed(context);
        IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> d_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(a_, b_, b_);
        (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQ12Date, CqlDate FollowupKCCQ12Date)? e_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQ12Date, CqlDate FollowupKCCQ12Date)? l_ = (CqlTupleMetadata_EOaHGTWWdfQIJhCjZQNViDVUO, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return l_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQ12Date, CqlDate FollowupKCCQ12Date)?> f_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQ12Date, CqlDate FollowupKCCQ12Date)?>(d_, e_);
        bool? g_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQ12Date, CqlDate FollowupKCCQ12Date)? tuple_eoahgtwwdfqijhcjzqnvidvuo)
        {
            Period m_ = tuple_eoahgtwwdfqijhcjzqnvidvuo?.ValidEncounters?.Period;
            CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, m_);
            CqlInterval<CqlDateTime> o_ = QICoreCommon_2_0_000.Instance.ToInterval(context, n_ as object);
            CqlDateTime p_ = context.Operators.End(o_);
            CqlInterval<CqlDateTime> q_ = this.Measurement_Period(context);
            CqlDateTime r_ = context.Operators.End(q_);
            CqlQuantity s_ = context.Operators.Quantity(180m, "days");
            CqlDateTime t_ = context.Operators.Subtract(r_, s_);
            bool? u_ = context.Operators.SameOrBefore(p_, t_, "day");
            CqlDateTime v_ = context.Operators.ConvertDateToDateTime(tuple_eoahgtwwdfqijhcjzqnvidvuo?.InitialKCCQ12Date);
            CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, m_);
            CqlInterval<CqlDateTime> y_ = QICoreCommon_2_0_000.Instance.ToInterval(context, x_ as object);
            CqlDateTime z_ = context.Operators.End(y_);
            CqlQuantity aa_ = context.Operators.Quantity(14m, "days");
            CqlDateTime ab_ = context.Operators.Subtract(z_, aa_);
            CqlInterval<CqlDateTime> ad_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, m_);
            CqlInterval<CqlDateTime> ae_ = QICoreCommon_2_0_000.Instance.ToInterval(context, ad_ as object);
            CqlDateTime af_ = context.Operators.End(ae_);
            CqlInterval<CqlDateTime> ag_ = context.Operators.Interval(ab_, af_, true, true);
            bool? ah_ = context.Operators.In<CqlDateTime>(v_, ag_, "day");
            CqlInterval<CqlDateTime> aj_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, m_);
            CqlInterval<CqlDateTime> ak_ = QICoreCommon_2_0_000.Instance.ToInterval(context, aj_ as object);
            CqlDateTime al_ = context.Operators.End(ak_);
            bool? am_ = context.Operators.Not((bool?)(al_ is null));
            bool? an_ = context.Operators.And(ah_, am_);
            bool? ao_ = context.Operators.And(u_, an_);
            CqlDateTime ap_ = context.Operators.ConvertDateToDateTime(tuple_eoahgtwwdfqijhcjzqnvidvuo?.FollowupKCCQ12Date);
            CqlDate aq_ = context.Operators.DateFrom(ap_);
            CqlDate as_ = context.Operators.DateFrom(v_);
            CqlQuantity at_ = context.Operators.Quantity(30m, "days");
            CqlDate au_ = context.Operators.Add(as_, at_);
            CqlDate aw_ = context.Operators.DateFrom(v_);
            CqlDate ay_ = context.Operators.Add(aw_, s_);
            CqlInterval<CqlDate> az_ = context.Operators.Interval(au_, ay_, true, true);
            bool? ba_ = context.Operators.In<CqlDate>(aq_, az_, "day");
            bool? bb_ = context.Operators.And(ao_, ba_);

            return bb_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQ12Date, CqlDate FollowupKCCQ12Date)?> h_ = context.Operators.Where<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQ12Date, CqlDate FollowupKCCQ12Date)?>(f_, g_);
        Encounter i_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQ12Date, CqlDate FollowupKCCQ12Date)? tuple_eoahgtwwdfqijhcjzqnvidvuo) => 
            tuple_eoahgtwwdfqijhcjzqnvidvuo?.ValidEncounters;
        IEnumerable<Encounter> j_ = context.Operators.Select<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQ12Date, CqlDate FollowupKCCQ12Date)?, Encounter>(h_, i_);
        bool? k_ = context.Operators.Exists<Encounter>(j_);

        return k_;
    }


    [CqlDeclaration("Date KCCQ Domain Assessment Completed")]
    public IEnumerable<CqlDate> Date_KCCQ_Domain_Assessment_Completed(CqlContext context)
    {
        CqlCode a_ = this.Quality_of_life_score__KCCQ_(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> d_ = Status_1_6_000.Instance.Final_Survey_Observation(context, c_);
        CqlCode e_ = this.Symptom_stability_score__KCCQ_(context);
        IEnumerable<CqlCode> f_ = context.Operators.ToList<CqlCode>(e_);
        IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, f_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> h_ = Status_1_6_000.Instance.Final_Survey_Observation(context, g_);
        CqlCode i_ = this.Self_efficacy_score__KCCQ_(context);
        IEnumerable<CqlCode> j_ = context.Operators.ToList<CqlCode>(i_);
        IEnumerable<Observation> k_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, j_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> l_ = Status_1_6_000.Instance.Final_Survey_Observation(context, k_);
        CqlCode m_ = this.Total_symptom_score__KCCQ_(context);
        IEnumerable<CqlCode> n_ = context.Operators.ToList<CqlCode>(m_);
        IEnumerable<Observation> o_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, n_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> p_ = Status_1_6_000.Instance.Final_Survey_Observation(context, o_);
        CqlCode q_ = this.Physical_limitation_score__KCCQ_(context);
        IEnumerable<CqlCode> r_ = context.Operators.ToList<CqlCode>(q_);
        IEnumerable<Observation> s_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, r_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> t_ = Status_1_6_000.Instance.Final_Survey_Observation(context, s_);
        CqlCode u_ = this.Social_limitation_score__KCCQ_(context);
        IEnumerable<CqlCode> v_ = context.Operators.ToList<CqlCode>(u_);
        IEnumerable<Observation> w_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, v_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> x_ = Status_1_6_000.Instance.Final_Survey_Observation(context, w_);
        IEnumerable<ValueTuple<Observation, Observation, Observation, Observation, Observation, Observation>> y_ = context.Operators.CrossJoin<Observation, Observation, Observation, Observation, Observation, Observation>(d_, h_, l_, p_, t_, x_);
        (CqlTupleMetadata, Observation KCCQLifeQuality, Observation KCCQSymptomStability, Observation KCCQSelfEfficacy, Observation KCCQSymptoms, Observation KCCQPhysicalLimits, Observation KCCQSocialLimits)? z_(ValueTuple<Observation, Observation, Observation, Observation, Observation, Observation> _valueTuple)
        {
            (CqlTupleMetadata, Observation KCCQLifeQuality, Observation KCCQSymptomStability, Observation KCCQSelfEfficacy, Observation KCCQSymptoms, Observation KCCQPhysicalLimits, Observation KCCQSocialLimits)? af_ = (CqlTupleMetadata_ETfcAWdPMcQFBNAYQdMDQQSdN, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3, _valueTuple.Item4, _valueTuple.Item5, _valueTuple.Item6);

            return af_;
        };
        IEnumerable<(CqlTupleMetadata, Observation KCCQLifeQuality, Observation KCCQSymptomStability, Observation KCCQSelfEfficacy, Observation KCCQSymptoms, Observation KCCQPhysicalLimits, Observation KCCQSocialLimits)?> aa_ = context.Operators.Select<ValueTuple<Observation, Observation, Observation, Observation, Observation, Observation>, (CqlTupleMetadata, Observation KCCQLifeQuality, Observation KCCQSymptomStability, Observation KCCQSelfEfficacy, Observation KCCQSymptoms, Observation KCCQPhysicalLimits, Observation KCCQSocialLimits)?>(y_, z_);
        bool? ab_((CqlTupleMetadata, Observation KCCQLifeQuality, Observation KCCQSymptomStability, Observation KCCQSelfEfficacy, Observation KCCQSymptoms, Observation KCCQPhysicalLimits, Observation KCCQSocialLimits)? tuple_etfcawdpmcqfbnayqdmdqqsdn)
        {
            DataType ag_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQLifeQuality?.Effective;
            object ah_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ag_);
            CqlInterval<CqlDateTime> ai_ = QICoreCommon_2_0_000.Instance.ToInterval(context, ah_);
            CqlDateTime aj_ = context.Operators.Start(ai_);
            CqlDate ak_ = context.Operators.DateFrom(aj_);
            DataType al_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQSymptomStability?.Effective;
            object am_ = FHIRHelpers_4_3_000.Instance.ToValue(context, al_);
            CqlInterval<CqlDateTime> an_ = QICoreCommon_2_0_000.Instance.ToInterval(context, am_);
            CqlDateTime ao_ = context.Operators.Start(an_);
            CqlDate ap_ = context.Operators.DateFrom(ao_);
            bool? aq_ = context.Operators.SameAs(ak_, ap_, "day");
            DataType ar_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQSymptomStability?.Value;
            object as_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ar_);
            bool? at_ = context.Operators.Not((bool?)(as_ is null));
            bool? au_ = context.Operators.And(aq_, at_);
            object aw_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ag_);
            CqlInterval<CqlDateTime> ax_ = QICoreCommon_2_0_000.Instance.ToInterval(context, aw_);
            CqlDateTime ay_ = context.Operators.Start(ax_);
            CqlDate az_ = context.Operators.DateFrom(ay_);
            DataType ba_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQSelfEfficacy?.Effective;
            object bb_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ba_);
            CqlInterval<CqlDateTime> bc_ = QICoreCommon_2_0_000.Instance.ToInterval(context, bb_);
            CqlDateTime bd_ = context.Operators.Start(bc_);
            CqlDate be_ = context.Operators.DateFrom(bd_);
            bool? bf_ = context.Operators.SameAs(az_, be_, "day");
            bool? bg_ = context.Operators.And(au_, bf_);
            DataType bh_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQSelfEfficacy?.Value;
            object bi_ = FHIRHelpers_4_3_000.Instance.ToValue(context, bh_);
            bool? bj_ = context.Operators.Not((bool?)(bi_ is null));
            bool? bk_ = context.Operators.And(bg_, bj_);
            object bm_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ag_);
            CqlInterval<CqlDateTime> bn_ = QICoreCommon_2_0_000.Instance.ToInterval(context, bm_);
            CqlDateTime bo_ = context.Operators.Start(bn_);
            CqlDate bp_ = context.Operators.DateFrom(bo_);
            DataType bq_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQSymptoms?.Effective;
            object br_ = FHIRHelpers_4_3_000.Instance.ToValue(context, bq_);
            CqlInterval<CqlDateTime> bs_ = QICoreCommon_2_0_000.Instance.ToInterval(context, br_);
            CqlDateTime bt_ = context.Operators.Start(bs_);
            CqlDate bu_ = context.Operators.DateFrom(bt_);
            bool? bv_ = context.Operators.SameAs(bp_, bu_, "day");
            bool? bw_ = context.Operators.And(bk_, bv_);
            DataType bx_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQSymptoms?.Value;
            object by_ = FHIRHelpers_4_3_000.Instance.ToValue(context, bx_);
            bool? bz_ = context.Operators.Not((bool?)(by_ is null));
            bool? ca_ = context.Operators.And(bw_, bz_);
            object cc_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ag_);
            CqlInterval<CqlDateTime> cd_ = QICoreCommon_2_0_000.Instance.ToInterval(context, cc_);
            CqlDateTime ce_ = context.Operators.Start(cd_);
            CqlDate cf_ = context.Operators.DateFrom(ce_);
            DataType cg_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQPhysicalLimits?.Effective;
            object ch_ = FHIRHelpers_4_3_000.Instance.ToValue(context, cg_);
            CqlInterval<CqlDateTime> ci_ = QICoreCommon_2_0_000.Instance.ToInterval(context, ch_);
            CqlDateTime cj_ = context.Operators.Start(ci_);
            CqlDate ck_ = context.Operators.DateFrom(cj_);
            bool? cl_ = context.Operators.SameAs(cf_, ck_, "day");
            bool? cm_ = context.Operators.And(ca_, cl_);
            DataType cn_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQPhysicalLimits?.Value;
            object co_ = FHIRHelpers_4_3_000.Instance.ToValue(context, cn_);
            bool? cp_ = context.Operators.Not((bool?)(co_ is null));
            bool? cq_ = context.Operators.And(cm_, cp_);
            object cs_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ag_);
            CqlInterval<CqlDateTime> ct_ = QICoreCommon_2_0_000.Instance.ToInterval(context, cs_);
            CqlDateTime cu_ = context.Operators.Start(ct_);
            CqlDate cv_ = context.Operators.DateFrom(cu_);
            DataType cw_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQSocialLimits?.Effective;
            object cx_ = FHIRHelpers_4_3_000.Instance.ToValue(context, cw_);
            CqlInterval<CqlDateTime> cy_ = QICoreCommon_2_0_000.Instance.ToInterval(context, cx_);
            CqlDateTime cz_ = context.Operators.Start(cy_);
            CqlDate da_ = context.Operators.DateFrom(cz_);
            bool? db_ = context.Operators.SameAs(cv_, da_, "day");
            bool? dc_ = context.Operators.And(cq_, db_);
            DataType dd_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQSocialLimits?.Value;
            object de_ = FHIRHelpers_4_3_000.Instance.ToValue(context, dd_);
            bool? df_ = context.Operators.Not((bool?)(de_ is null));
            bool? dg_ = context.Operators.And(dc_, df_);
            DataType dh_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQLifeQuality?.Value;
            object di_ = FHIRHelpers_4_3_000.Instance.ToValue(context, dh_);
            bool? dj_ = context.Operators.Not((bool?)(di_ is null));
            bool? dk_ = context.Operators.And(dg_, dj_);

            return dk_;
        };
        IEnumerable<(CqlTupleMetadata, Observation KCCQLifeQuality, Observation KCCQSymptomStability, Observation KCCQSelfEfficacy, Observation KCCQSymptoms, Observation KCCQPhysicalLimits, Observation KCCQSocialLimits)?> ac_ = context.Operators.Where<(CqlTupleMetadata, Observation KCCQLifeQuality, Observation KCCQSymptomStability, Observation KCCQSelfEfficacy, Observation KCCQSymptoms, Observation KCCQPhysicalLimits, Observation KCCQSocialLimits)?>(aa_, ab_);
        CqlDate ad_((CqlTupleMetadata, Observation KCCQLifeQuality, Observation KCCQSymptomStability, Observation KCCQSelfEfficacy, Observation KCCQSymptoms, Observation KCCQPhysicalLimits, Observation KCCQSocialLimits)? tuple_etfcawdpmcqfbnayqdmdqqsdn)
        {
            DataType dl_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQLifeQuality?.Effective;
            object dm_ = FHIRHelpers_4_3_000.Instance.ToValue(context, dl_);
            CqlInterval<CqlDateTime> dn_ = QICoreCommon_2_0_000.Instance.ToInterval(context, dm_);
            CqlDateTime do_ = context.Operators.Start(dn_);
            CqlDate dp_ = context.Operators.DateFrom(do_);
            DataType dq_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQSymptomStability?.Effective;
            object dr_ = FHIRHelpers_4_3_000.Instance.ToValue(context, dq_);
            CqlInterval<CqlDateTime> ds_ = QICoreCommon_2_0_000.Instance.ToInterval(context, dr_);
            CqlDateTime dt_ = context.Operators.Start(ds_);
            CqlDate du_ = context.Operators.DateFrom(dt_);
            DataType dv_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQSelfEfficacy?.Effective;
            object dw_ = FHIRHelpers_4_3_000.Instance.ToValue(context, dv_);
            CqlInterval<CqlDateTime> dx_ = QICoreCommon_2_0_000.Instance.ToInterval(context, dw_);
            CqlDateTime dy_ = context.Operators.Start(dx_);
            CqlDate dz_ = context.Operators.DateFrom(dy_);
            DataType ea_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQSymptoms?.Effective;
            object eb_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ea_);
            CqlInterval<CqlDateTime> ec_ = QICoreCommon_2_0_000.Instance.ToInterval(context, eb_);
            CqlDateTime ed_ = context.Operators.Start(ec_);
            CqlDate ee_ = context.Operators.DateFrom(ed_);
            DataType ef_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQPhysicalLimits?.Effective;
            object eg_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ef_);
            CqlInterval<CqlDateTime> eh_ = QICoreCommon_2_0_000.Instance.ToInterval(context, eg_);
            CqlDateTime ei_ = context.Operators.Start(eh_);
            CqlDate ej_ = context.Operators.DateFrom(ei_);
            DataType ek_ = tuple_etfcawdpmcqfbnayqdmdqqsdn?.KCCQSocialLimits?.Effective;
            object el_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ek_);
            CqlInterval<CqlDateTime> em_ = QICoreCommon_2_0_000.Instance.ToInterval(context, el_);
            CqlDateTime en_ = context.Operators.Start(em_);
            CqlDate eo_ = context.Operators.DateFrom(en_);
            CqlDate[] ep_ = [
                dp_,
                du_,
                dz_,
                ee_,
                ej_,
                eo_,
            ];
            CqlDate eq_ = context.Operators.Max<CqlDate>(ep_ as IEnumerable<CqlDate>);

            return eq_;
        };
        IEnumerable<CqlDate> ae_ = context.Operators.Select<(CqlTupleMetadata, Observation KCCQLifeQuality, Observation KCCQSymptomStability, Observation KCCQSelfEfficacy, Observation KCCQSymptoms, Observation KCCQPhysicalLimits, Observation KCCQSocialLimits)?, CqlDate>(ac_, ad_);

        return ae_;
    }


    [CqlDeclaration("Has Encounter with Initial and Follow Up KCCQ Domain Score Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_KCCQ_Domain_Score_Assessments(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounters(context);
        IEnumerable<CqlDate> b_ = this.Date_KCCQ_Domain_Assessment_Completed(context);
        IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> d_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(a_, b_, b_);
        (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQAssessmentDate, CqlDate FollowupKCCQAssessmentDate)? e_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQAssessmentDate, CqlDate FollowupKCCQAssessmentDate)? l_ = (CqlTupleMetadata_HRLUHbCfCSVNVRRNjajAHdcEA, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return l_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQAssessmentDate, CqlDate FollowupKCCQAssessmentDate)?> f_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQAssessmentDate, CqlDate FollowupKCCQAssessmentDate)?>(d_, e_);
        bool? g_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQAssessmentDate, CqlDate FollowupKCCQAssessmentDate)? tuple_hrluhbcfcsvnvrrnjajahdcea)
        {
            Period m_ = tuple_hrluhbcfcsvnvrrnjajahdcea?.ValidEncounters?.Period;
            CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, m_);
            CqlInterval<CqlDateTime> o_ = QICoreCommon_2_0_000.Instance.ToInterval(context, n_ as object);
            CqlDateTime p_ = context.Operators.End(o_);
            CqlInterval<CqlDateTime> q_ = this.Measurement_Period(context);
            CqlDateTime r_ = context.Operators.End(q_);
            CqlQuantity s_ = context.Operators.Quantity(180m, "days");
            CqlDateTime t_ = context.Operators.Subtract(r_, s_);
            bool? u_ = context.Operators.SameOrBefore(p_, t_, "day");
            CqlDateTime v_ = context.Operators.ConvertDateToDateTime(tuple_hrluhbcfcsvnvrrnjajahdcea?.InitialKCCQAssessmentDate);
            CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, m_);
            CqlInterval<CqlDateTime> y_ = QICoreCommon_2_0_000.Instance.ToInterval(context, x_ as object);
            CqlDateTime z_ = context.Operators.End(y_);
            CqlQuantity aa_ = context.Operators.Quantity(14m, "days");
            CqlDateTime ab_ = context.Operators.Subtract(z_, aa_);
            CqlInterval<CqlDateTime> ad_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, m_);
            CqlInterval<CqlDateTime> ae_ = QICoreCommon_2_0_000.Instance.ToInterval(context, ad_ as object);
            CqlDateTime af_ = context.Operators.End(ae_);
            CqlInterval<CqlDateTime> ag_ = context.Operators.Interval(ab_, af_, true, true);
            bool? ah_ = context.Operators.In<CqlDateTime>(v_, ag_, "day");
            CqlInterval<CqlDateTime> aj_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, m_);
            CqlInterval<CqlDateTime> ak_ = QICoreCommon_2_0_000.Instance.ToInterval(context, aj_ as object);
            CqlDateTime al_ = context.Operators.End(ak_);
            bool? am_ = context.Operators.Not((bool?)(al_ is null));
            bool? an_ = context.Operators.And(ah_, am_);
            bool? ao_ = context.Operators.And(u_, an_);
            CqlDateTime ap_ = context.Operators.ConvertDateToDateTime(tuple_hrluhbcfcsvnvrrnjajahdcea?.FollowupKCCQAssessmentDate);
            CqlDate aq_ = context.Operators.DateFrom(ap_);
            CqlDate as_ = context.Operators.DateFrom(v_);
            CqlQuantity at_ = context.Operators.Quantity(30m, "days");
            CqlDate au_ = context.Operators.Add(as_, at_);
            CqlDate aw_ = context.Operators.DateFrom(v_);
            CqlDate ay_ = context.Operators.Add(aw_, s_);
            CqlInterval<CqlDate> az_ = context.Operators.Interval(au_, ay_, true, true);
            bool? ba_ = context.Operators.In<CqlDate>(aq_, az_, "day");
            bool? bb_ = context.Operators.And(ao_, ba_);

            return bb_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQAssessmentDate, CqlDate FollowupKCCQAssessmentDate)?> h_ = context.Operators.Where<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQAssessmentDate, CqlDate FollowupKCCQAssessmentDate)?>(f_, g_);
        Encounter i_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQAssessmentDate, CqlDate FollowupKCCQAssessmentDate)? tuple_hrluhbcfcsvnvrrnjajahdcea) => 
            tuple_hrluhbcfcsvnvrrnjajahdcea?.ValidEncounters;
        IEnumerable<Encounter> j_ = context.Operators.Select<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQAssessmentDate, CqlDate FollowupKCCQAssessmentDate)?, Encounter>(h_, i_);
        bool? k_ = context.Operators.Exists<Encounter>(j_);

        return k_;
    }


    [CqlDeclaration("Date KCCQ Total Assessment Completed")]
    public IEnumerable<CqlDate> Date_KCCQ_Total_Assessment_Completed(CqlContext context)
    {
        CqlCode a_ = this.Overall_summary_score__KCCQ_(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> d_ = Status_1_6_000.Instance.Final_Survey_Observation(context, c_);
        bool? e_(Observation KCCQSummaryScore)
        {
            DataType i_ = KCCQSummaryScore?.Value;
            object j_ = FHIRHelpers_4_3_000.Instance.ToValue(context, i_);
            bool? k_ = context.Operators.Not((bool?)(j_ is null));

            return k_;
        };
        IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);
        CqlDate g_(Observation KCCQSummaryScore)
        {
            DataType l_ = KCCQSummaryScore?.Effective;
            object m_ = FHIRHelpers_4_3_000.Instance.ToValue(context, l_);
            CqlInterval<CqlDateTime> n_ = QICoreCommon_2_0_000.Instance.ToInterval(context, m_);
            CqlDateTime o_ = context.Operators.Start(n_);
            CqlDate p_ = context.Operators.DateFrom(o_);
            CqlDate[] q_ = [
                p_,
            ];
            CqlDate r_ = context.Operators.Max<CqlDate>(q_ as IEnumerable<CqlDate>);

            return r_;
        };
        IEnumerable<CqlDate> h_ = context.Operators.Select<Observation, CqlDate>(f_, g_);

        return h_;
    }


    [CqlDeclaration("Has Encounter with Initial and Follow Up KCCQ Total Score Assessments")]
    public bool? Has_Encounter_with_Initial_and_Follow_Up_KCCQ_Total_Score_Assessments(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounters(context);
        IEnumerable<CqlDate> b_ = this.Date_KCCQ_Total_Assessment_Completed(context);
        IEnumerable<ValueTuple<Encounter, CqlDate, CqlDate>> d_ = context.Operators.CrossJoin<Encounter, CqlDate, CqlDate>(a_, b_, b_);
        (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQTotalScore, CqlDate FollowupKCCQTotalScore)? e_(ValueTuple<Encounter, CqlDate, CqlDate> _valueTuple)
        {
            (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQTotalScore, CqlDate FollowupKCCQTotalScore)? l_ = (CqlTupleMetadata_DGROjeEKDVIZSVYiSEPDjhJgj, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);

            return l_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQTotalScore, CqlDate FollowupKCCQTotalScore)?> f_ = context.Operators.Select<ValueTuple<Encounter, CqlDate, CqlDate>, (CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQTotalScore, CqlDate FollowupKCCQTotalScore)?>(d_, e_);
        bool? g_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQTotalScore, CqlDate FollowupKCCQTotalScore)? tuple_dgrojeekdvizsvyisepdjhjgj)
        {
            Period m_ = tuple_dgrojeekdvizsvyisepdjhjgj?.ValidEncounters?.Period;
            CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, m_);
            CqlInterval<CqlDateTime> o_ = QICoreCommon_2_0_000.Instance.ToInterval(context, n_ as object);
            CqlDateTime p_ = context.Operators.End(o_);
            CqlInterval<CqlDateTime> q_ = this.Measurement_Period(context);
            CqlDateTime r_ = context.Operators.End(q_);
            CqlQuantity s_ = context.Operators.Quantity(180m, "days");
            CqlDateTime t_ = context.Operators.Subtract(r_, s_);
            bool? u_ = context.Operators.SameOrBefore(p_, t_, "day");
            CqlDateTime v_ = context.Operators.ConvertDateToDateTime(tuple_dgrojeekdvizsvyisepdjhjgj?.InitialKCCQTotalScore);
            CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, m_);
            CqlInterval<CqlDateTime> y_ = QICoreCommon_2_0_000.Instance.ToInterval(context, x_ as object);
            CqlDateTime z_ = context.Operators.End(y_);
            CqlQuantity aa_ = context.Operators.Quantity(14m, "days");
            CqlDateTime ab_ = context.Operators.Subtract(z_, aa_);
            CqlInterval<CqlDateTime> ad_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, m_);
            CqlInterval<CqlDateTime> ae_ = QICoreCommon_2_0_000.Instance.ToInterval(context, ad_ as object);
            CqlDateTime af_ = context.Operators.End(ae_);
            CqlInterval<CqlDateTime> ag_ = context.Operators.Interval(ab_, af_, true, true);
            bool? ah_ = context.Operators.In<CqlDateTime>(v_, ag_, "day");
            CqlInterval<CqlDateTime> aj_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, m_);
            CqlInterval<CqlDateTime> ak_ = QICoreCommon_2_0_000.Instance.ToInterval(context, aj_ as object);
            CqlDateTime al_ = context.Operators.End(ak_);
            bool? am_ = context.Operators.Not((bool?)(al_ is null));
            bool? an_ = context.Operators.And(ah_, am_);
            bool? ao_ = context.Operators.And(u_, an_);
            CqlDateTime ap_ = context.Operators.ConvertDateToDateTime(tuple_dgrojeekdvizsvyisepdjhjgj?.FollowupKCCQTotalScore);
            CqlDate aq_ = context.Operators.DateFrom(ap_);
            CqlDate as_ = context.Operators.DateFrom(v_);
            CqlQuantity at_ = context.Operators.Quantity(30m, "days");
            CqlDate au_ = context.Operators.Add(as_, at_);
            CqlDate aw_ = context.Operators.DateFrom(v_);
            CqlDate ay_ = context.Operators.Add(aw_, s_);
            CqlInterval<CqlDate> az_ = context.Operators.Interval(au_, ay_, true, true);
            bool? ba_ = context.Operators.In<CqlDate>(aq_, az_, "day");
            bool? bb_ = context.Operators.And(ao_, ba_);

            return bb_;
        };
        IEnumerable<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQTotalScore, CqlDate FollowupKCCQTotalScore)?> h_ = context.Operators.Where<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQTotalScore, CqlDate FollowupKCCQTotalScore)?>(f_, g_);
        Encounter i_((CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQTotalScore, CqlDate FollowupKCCQTotalScore)? tuple_dgrojeekdvizsvyisepdjhjgj) => 
            tuple_dgrojeekdvizsvyisepdjhjgj?.ValidEncounters;
        IEnumerable<Encounter> j_ = context.Operators.Select<(CqlTupleMetadata, Encounter ValidEncounters, CqlDate InitialKCCQTotalScore, CqlDate FollowupKCCQTotalScore)?, Encounter>(h_, i_);
        bool? k_ = context.Operators.Exists<Encounter>(j_);

        return k_;
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

    private static CqlTupleMetadata CqlTupleMetadata_DbNMMZBTISSRTNdiShceSFVih = new(
        [typeof(Encounter), typeof(Encounter)],
        ["OfficeVisit1", "OfficeVisit2"]);

    private static CqlTupleMetadata CqlTupleMetadata_DDTAOdcFieSJbGgRLLZPYbGQb = new(
        [typeof(Observation), typeof(Observation)],
        ["PROMIS10MentalScore", "PROMIS10PhysicalScore"]);

    private static CqlTupleMetadata CqlTupleMetadata_DZhWGXhMBfAVMZfaSZbEKSOHj = new(
        [typeof(Encounter), typeof(CqlDate), typeof(CqlDate)],
        ["ValidEncounters", "InitialPROMIS10Date", "FollowupPROMIS10Date"]);

    private static CqlTupleMetadata CqlTupleMetadata_CbgPSARVWRSeWLgLehiNjaNiM = new(
        [typeof(Observation), typeof(Observation), typeof(Observation), typeof(Observation), typeof(Observation), typeof(Observation), typeof(Observation)],
        ["Promis29Sleep", "Promis29SocialRoles", "Promis29Physical", "Promis29Pain", "Promis29Fatigue", "Promis29Depression", "Promis29Anxiety"]);

    private static CqlTupleMetadata CqlTupleMetadata_KMPNTXjUhKPBcWGfTQIGieaO = new(
        [typeof(Encounter), typeof(CqlDate), typeof(CqlDate)],
        ["ValidEncounters", "InitialPROMIS29Date", "FollowupPROMIS29Date"]);

    private static CqlTupleMetadata CqlTupleMetadata_GAdRFKRaHUUGJcVHWQWRUjhRH = new(
        [typeof(Observation), typeof(Observation)],
        ["VR12MentalAssessment", "VR12PhysicalAssessment"]);

    private static CqlTupleMetadata CqlTupleMetadata_FPPKTdIagiEKHPTNSBAcPSWH = new(
        [typeof(Encounter), typeof(CqlDate), typeof(CqlDate)],
        ["ValidEncounters", "InitialVR12ObliqueDate", "FollowupVR12ObliqueDate"]);

    private static CqlTupleMetadata CqlTupleMetadata_FaNSVMJaEDMVSdOYROZXdLSaI = new(
        [typeof(Encounter), typeof(CqlDate), typeof(CqlDate)],
        ["ValidEncounters", "InitialVR12OrthogonalDate", "FollowupVR12OrthogonalDate"]);

    private static CqlTupleMetadata CqlTupleMetadata_DUcFTCLcQEWDGGQdFCWTHFaUK = new(
        [typeof(Observation), typeof(Observation)],
        ["VR36MentalAssessment", "VR36PhysicalAssessment"]);

    private static CqlTupleMetadata CqlTupleMetadata_ELXIcYHRDPYZPQYJPHdiFBiGA = new(
        [typeof(Encounter), typeof(CqlDate), typeof(CqlDate)],
        ["ValidEncounters", "InitialVR36ObliqueDate", "FollowupVR36ObliqueDate"]);

    private static CqlTupleMetadata CqlTupleMetadata_fUCQUjAdjiZABIHDfFFORMHT = new(
        [typeof(Encounter), typeof(CqlDate), typeof(CqlDate)],
        ["ValidEncounters", "InitialVR36OrthogonalDate", "FollowupVR36OrthogonalDate"]);

    private static CqlTupleMetadata CqlTupleMetadata_FNOFXCKadAeUSJERHBDQfOShE = new(
        [typeof(Observation), typeof(Observation)],
        ["MLHFQPhysical", "MLHFQEmotional"]);

    private static CqlTupleMetadata CqlTupleMetadata_NCDAWCTNMBFMTibMiHSFBAIG = new(
        [typeof(Encounter), typeof(CqlDate), typeof(CqlDate)],
        ["ValidEncounters", "InitialMLHFQDate", "FollowupMLHFQDate"]);

    private static CqlTupleMetadata CqlTupleMetadata_DFKXORghhYafccUSbQaMfNTDj = new(
        [typeof(Observation), typeof(Observation)],
        ["KCCQ12Item", "KCCQ12Summary"]);

    private static CqlTupleMetadata CqlTupleMetadata_EOaHGTWWdfQIJhCjZQNViDVUO = new(
        [typeof(Encounter), typeof(CqlDate), typeof(CqlDate)],
        ["ValidEncounters", "InitialKCCQ12Date", "FollowupKCCQ12Date"]);

    private static CqlTupleMetadata CqlTupleMetadata_ETfcAWdPMcQFBNAYQdMDQQSdN = new(
        [typeof(Observation), typeof(Observation), typeof(Observation), typeof(Observation), typeof(Observation), typeof(Observation)],
        ["KCCQLifeQuality", "KCCQSymptomStability", "KCCQSelfEfficacy", "KCCQSymptoms", "KCCQPhysicalLimits", "KCCQSocialLimits"]);

    private static CqlTupleMetadata CqlTupleMetadata_HRLUHbCfCSVNVRRNjajAHdcEA = new(
        [typeof(Encounter), typeof(CqlDate), typeof(CqlDate)],
        ["ValidEncounters", "InitialKCCQAssessmentDate", "FollowupKCCQAssessmentDate"]);

    private static CqlTupleMetadata CqlTupleMetadata_DGROjeEKDVIZSVYiSEPDjhJgj = new(
        [typeof(Encounter), typeof(CqlDate), typeof(CqlDate)],
        ["ValidEncounters", "InitialKCCQTotalScore", "FollowupKCCQTotalScore"]);

}
