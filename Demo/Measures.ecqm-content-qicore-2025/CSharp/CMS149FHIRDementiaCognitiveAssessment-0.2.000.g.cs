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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "3.1.0.0")]
[CqlLibrary("CMS149FHIRDementiaCognitiveAssessment", "0.2.000")]
public partial class CMS149FHIRDementiaCognitiveAssessment_0_2_000 : ILibrary, ISingleton<CMS149FHIRDementiaCognitiveAssessment_0_2_000>
{
    private CMS149FHIRDementiaCognitiveAssessment_0_2_000() {}

    public static CMS149FHIRDementiaCognitiveAssessment_0_2_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "CMS149FHIRDementiaCognitiveAssessment";
    public string Version => "0.2.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_5_1_000.Instance, QICoreCommon_4_0_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Behavioral or Neuropsych Assessment", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1023", valueSetVersion: null)]
    public CqlValueSet Behavioral_or_Neuropsych_Assessment(CqlContext _) => _Behavioral_or_Neuropsych_Assessment;
    private static readonly CqlValueSet _Behavioral_or_Neuropsych_Assessment = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1023", null);

    [CqlValueSetDefinition("Care Services in Long Term Residential Facility", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014", valueSetVersion: null)]
    public CqlValueSet Care_Services_in_Long_Term_Residential_Facility(CqlContext _) => _Care_Services_in_Long_Term_Residential_Facility;
    private static readonly CqlValueSet _Care_Services_in_Long_Term_Residential_Facility = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014", null);

    [CqlValueSetDefinition("Cognitive Assessment", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1332", valueSetVersion: null)]
    public CqlValueSet Cognitive_Assessment(CqlContext _) => _Cognitive_Assessment;
    private static readonly CqlValueSet _Cognitive_Assessment = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1332", null);

    [CqlValueSetDefinition("Dementia & Mental Degenerations", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1005", valueSetVersion: null)]
    public CqlValueSet Dementia__and__Mental_Degenerations(CqlContext _) => _Dementia__and__Mental_Degenerations;
    private static readonly CqlValueSet _Dementia__and__Mental_Degenerations = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1005", null);

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

    [CqlValueSetDefinition("Standardized Tools for Assessment of Cognition", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1006", valueSetVersion: null)]
    public CqlValueSet Standardized_Tools_for_Assessment_of_Cognition(CqlContext _) => _Standardized_Tools_for_Assessment_of_Cognition;
    private static readonly CqlValueSet _Standardized_Tools_for_Assessment_of_Cognition = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1006", null);

    #endregion ValueSets

    #region CodeSystems

    [CqlCodeSystemDefinition("ActCode", codeSystemId: "http://terminology.hl7.org/CodeSystem/v3-ActCode", codeSystemVersion: null)]
    public CqlCodeSystem ActCode(CqlContext _) => _ActCode;
    private static readonly CqlCodeSystem _ActCode =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/v3-ActCode", null, []);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object a_ = context.ResolveParameter("CMS149FHIRDementiaCognitiveAssessment-0.2.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)a_;
    }


    #endregion Parameters

    #region Functions and Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

        return b_;
    }


    [CqlExpressionDefinition("Encounter to Assess Cognition")]
    public IEnumerable<Encounter> Encounter_to_Assess_Cognition(CqlContext context)
    {
        CqlValueSet a_ = this.Psych_Visit_Diagnostic_Evaluation(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet c_ = this.Nursing_Facility_Visit(context);
        IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
        CqlValueSet f_ = this.Care_Services_in_Long_Term_Residential_Facility(context);
        IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet h_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> i_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
        CqlValueSet l_ = this.Psych_Visit_Psychotherapy(context);
        IEnumerable<Encounter> m_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet n_ = this.Behavioral_or_Neuropsych_Assessment(context);
        IEnumerable<Encounter> o_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> p_ = context.Operators.Union<Encounter>(m_, o_);
        IEnumerable<Encounter> q_ = context.Operators.Union<Encounter>(k_, p_);
        CqlValueSet r_ = this.Occupational_Therapy_Evaluation(context);
        IEnumerable<Encounter> s_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet t_ = this.Office_Visit(context);
        IEnumerable<Encounter> u_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, t_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> v_ = context.Operators.Union<Encounter>(s_, u_);
        IEnumerable<Encounter> w_ = context.Operators.Union<Encounter>(q_, v_);
        CqlValueSet x_ = this.Outpatient_Consultation(context);
        IEnumerable<Encounter> y_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, x_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> z_ = context.Operators.Union<Encounter>(w_, y_);

        return z_;
    }


    [CqlExpressionDefinition("Dementia Encounter During Measurement Period")]
    public IEnumerable<Encounter> Dementia_Encounter_During_Measurement_Period(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_to_Assess_Cognition(context);
        IEnumerable<Encounter> b_(Encounter EncounterAssessCognition)
        {
            CqlValueSet d_ = this.Dementia__and__Mental_Degenerations(context);
            IEnumerable<Condition> e_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<object> h_ = context.Operators.Union<object>(e_ as IEnumerable<object>, g_ as IEnumerable<object>);
            bool? i_(object Dementia)
            {
                CqlInterval<CqlDateTime> m_ = this.Measurement_Period(context);
                Period n_ = EncounterAssessCognition?.Period;
                CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                bool? p_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(m_, o_, default);
                CqlInterval<CqlDateTime> q_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, Dementia);
                CqlInterval<CqlDateTime> s_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                bool? t_ = context.Operators.Overlaps(q_, s_, default);
                bool? u_ = context.Operators.And(p_, t_);
                bool? v_ = QICoreCommon_4_0_000.Instance.isActive(context, Dementia);
                bool? w_ = context.Operators.And(u_, v_);
                object x_ = context.Operators.LateBoundProperty<object>(Dementia, "verificationStatus");
                CqlConcept y_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, x_ as CodeableConcept);
                CqlCode z_ = QICoreCommon_4_0_000.Instance.unconfirmed(context);
                CqlConcept aa_ = context.Operators.ConvertCodeToConcept(z_);
                bool? ab_ = context.Operators.Equivalent(y_, aa_);
                CqlConcept ad_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, x_ as CodeableConcept);
                CqlCode ae_ = QICoreCommon_4_0_000.Instance.refuted(context);
                CqlConcept af_ = context.Operators.ConvertCodeToConcept(ae_);
                bool? ag_ = context.Operators.Equivalent(ad_, af_);
                bool? ah_ = context.Operators.Or(ab_, ag_);
                CqlConcept aj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, x_ as CodeableConcept);
                CqlCode ak_ = QICoreCommon_4_0_000.Instance.entered_in_error(context);
                CqlConcept al_ = context.Operators.ConvertCodeToConcept(ak_);
                bool? am_ = context.Operators.Equivalent(aj_, al_);
                bool? an_ = context.Operators.Or(ah_, am_);
                bool? ao_ = context.Operators.Not(an_);
                bool? ap_ = context.Operators.And(w_, ao_);

                return ap_;
            };
            IEnumerable<object> j_ = context.Operators.Where<object>(h_, i_);
            Encounter k_(object Dementia) =>
                EncounterAssessCognition;
            IEnumerable<Encounter> l_ = context.Operators.Select<object, Encounter>(j_, k_);

            return l_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Qualifying Encounter During Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Encounter_During_Measurement_Period(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_to_Assess_Cognition(context);
        CqlValueSet b_ = this.Patient_Provider_Interaction(context);
        IEnumerable<Encounter> c_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> d_ = context.Operators.Union<Encounter>(a_, c_);
        bool? e_(Encounter ValidEncounter)
        {
            CqlInterval<CqlDateTime> g_ = this.Measurement_Period(context);
            Period h_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> i_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, h_);
            bool? j_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(g_, i_, default);
            Code<Encounter.EncounterStatus> k_ = ValidEncounter?.StatusElement;
            Encounter.EncounterStatus? l_ = k_?.Value;
            Code<Encounter.EncounterStatus> m_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(l_);
            bool? n_ = context.Operators.Equal(m_, "finished");
            bool? o_ = context.Operators.And(j_, n_);

            return o_;
        };
        IEnumerable<Encounter> f_ = context.Operators.Where<Encounter>(d_, e_);

        return f_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Dementia_Encounter_During_Measurement_Period(context);
        bool? b_ = context.Operators.Exists<Encounter>(a_);
        IEnumerable<Encounter> c_ = this.Qualifying_Encounter_During_Measurement_Period(context);
        int? d_ = context.Operators.Count<Encounter>(c_);
        bool? e_ = context.Operators.GreaterOrEqual(d_, 2);
        bool? f_ = context.Operators.And(b_, e_);

        return f_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);

        return a_;
    }


    [CqlExpressionDefinition("Assessment of Cognition Using Standardized Tools or Alternate Methods")]
    public IEnumerable<Observation> Assessment_of_Cognition_Using_Standardized_Tools_or_Alternate_Methods(CqlContext context)
    {
        CqlValueSet a_ = this.Standardized_Tools_for_Assessment_of_Cognition(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
        CqlValueSet c_ = this.Cognitive_Assessment(context);
        IEnumerable<Observation> d_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));
        IEnumerable<Observation> e_ = context.Operators.Union<Observation>(b_, d_);
        IEnumerable<Observation> f_(Observation CognitiveAssessment)
        {
            IEnumerable<Encounter> j_ = this.Dementia_Encounter_During_Measurement_Period(context);
            bool? k_(Encounter EncounterDementia)
            {
                DataType o_ = CognitiveAssessment?.Effective;
                object p_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
                CqlInterval<CqlDateTime> q_ = QICoreCommon_4_0_000.Instance.toInterval(context, p_);
                CqlDateTime r_ = context.Operators.Start(q_);
                Period s_ = EncounterDementia?.Period;
                CqlInterval<CqlDateTime> t_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, s_);
                CqlDateTime u_ = context.Operators.End(t_);
                CqlQuantity v_ = context.Operators.Quantity(12m, "months");
                CqlDateTime w_ = context.Operators.Subtract(u_, v_);
                CqlInterval<CqlDateTime> y_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, s_);
                CqlDateTime z_ = context.Operators.End(y_);
                CqlInterval<CqlDateTime> aa_ = context.Operators.Interval(w_, z_, true, true);
                bool? ab_ = context.Operators.In<CqlDateTime>(r_, aa_, "day");
                CqlInterval<CqlDateTime> ad_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, s_);
                CqlDateTime ae_ = context.Operators.End(ad_);
                bool? af_ = context.Operators.Not((bool?)(ae_ is null));
                bool? ag_ = context.Operators.And(ab_, af_);

                return ag_;
            };
            IEnumerable<Encounter> l_ = context.Operators.Where<Encounter>(j_, k_);
            Observation m_(Encounter EncounterDementia) =>
                CognitiveAssessment;
            IEnumerable<Observation> n_ = context.Operators.Select<Encounter, Observation>(l_, m_);

            return n_;
        };
        IEnumerable<Observation> g_ = context.Operators.SelectMany<Observation, Observation>(e_, f_);
        bool? h_(Observation CognitiveAssessment)
        {
            DataType ah_ = CognitiveAssessment?.Value;
            object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
            bool? aj_ = context.Operators.Not((bool?)(ai_ is null));
            Code<ObservationStatus> ak_ = CognitiveAssessment?.StatusElement;
            ObservationStatus? al_ = ak_?.Value;
            string am_ = context.Operators.Convert<string>(al_);
            string[] an_ = [
                "final",
                "amended",
                "corrected",
                "preliminary",
            ];
            bool? ao_ = context.Operators.In<string>(am_, an_ as IEnumerable<string>);
            bool? ap_ = context.Operators.And(aj_, ao_);

            return ap_;
        };
        IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);

        return i_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Assessment_of_Cognition_Using_Standardized_Tools_or_Alternate_Methods(context);
        bool? b_ = context.Operators.Exists<Observation>(a_);

        return b_;
    }


    [CqlExpressionDefinition("Patient Reason for Not Performing Assessment of Cognition Using Standardized Tools or Alternate Methods")]
    public IEnumerable<Observation> Patient_Reason_for_Not_Performing_Assessment_of_Cognition_Using_Standardized_Tools_or_Alternate_Methods(CqlContext context)
    {
        CqlValueSet a_ = this.Standardized_Tools_for_Assessment_of_Cognition(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observationcancelled"));
        CqlValueSet c_ = this.Cognitive_Assessment(context);
        IEnumerable<Observation> d_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observationcancelled"));
        IEnumerable<Observation> e_ = context.Operators.Union<Observation>(b_, d_);
        IEnumerable<Observation> f_(Observation NoCognitiveAssessment)
        {
            IEnumerable<Encounter> j_ = this.Dementia_Encounter_During_Measurement_Period(context);
            bool? k_(Encounter EncounterDementia)
            {
                Instant o_ = NoCognitiveAssessment?.IssuedElement;
                DateTimeOffset? p_ = o_?.Value;
                CqlDateTime q_ = context.Operators.Convert<CqlDateTime>(p_);
                Period r_ = EncounterDementia?.Period;
                CqlInterval<CqlDateTime> s_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
                bool? t_ = context.Operators.In<CqlDateTime>(q_, s_, "day");

                return t_;
            };
            IEnumerable<Encounter> l_ = context.Operators.Where<Encounter>(j_, k_);
            Observation m_(Encounter EncounterDementia) =>
                NoCognitiveAssessment;
            IEnumerable<Observation> n_ = context.Operators.Select<Encounter, Observation>(l_, m_);

            return n_;
        };
        IEnumerable<Observation> g_ = context.Operators.SelectMany<Observation, Observation>(e_, f_);
        bool? h_(Observation NoCognitiveAssessment)
        {
            bool? u_(Extension @this)
            {
                string ac_ = @this?.Url;
                FhirString ad_ = context.Operators.Convert<FhirString>(ac_);
                string ae_ = FHIRHelpers_4_4_000.Instance.ToString(context, ad_);
                bool? af_ = context.Operators.Equal(ae_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");

                return af_;
            };
            IEnumerable<Extension> v_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(NoCognitiveAssessment is DomainResource
                    ? (NoCognitiveAssessment as DomainResource).Extension
                    : default), u_);
            object w_(Extension @this)
            {
                DataType ag_ = @this?.Value;

                return ag_;
            };
            IEnumerable<object> x_ = context.Operators.Select<Extension, object>(v_, w_);
            object y_ = context.Operators.SingletonFrom<object>(x_);
            CqlConcept z_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, y_ as CodeableConcept);
            CqlValueSet aa_ = this.Patient_Reason(context);
            bool? ab_ = context.Operators.ConceptInValueSet(z_, aa_);

            return ab_;
        };
        IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);

        return i_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public bool? Denominator_Exceptions(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Patient_Reason_for_Not_Performing_Assessment_of_Cognition_Using_Standardized_Tools_or_Alternate_Methods(context);
        bool? b_ = context.Operators.Exists<Observation>(a_);

        return b_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);

        return a_;
    }


    #endregion Functions and Expressions

}
