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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.2.0")]
[CqlLibrary("CMS2FHIRPCSDepScreenAndFollowUp", "1.0.000")]
public partial class CMS2FHIRPCSDepScreenAndFollowUp_1_0_000 : ILibrary, ISingleton<CMS2FHIRPCSDepScreenAndFollowUp_1_0_000>
{
    #region ValueSets (11)

    [CqlValueSetDefinition("Adolescent Depression Medications", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1567", valueSetVersion: null)]
    public CqlValueSet Adolescent_Depression_Medications(CqlContext _) => _Adolescent_Depression_Medications;
    private static readonly CqlValueSet _Adolescent_Depression_Medications = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1567", null);

    [CqlValueSetDefinition("Adult Depression Medications", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1566", valueSetVersion: null)]
    public CqlValueSet Adult_Depression_Medications(CqlContext _) => _Adult_Depression_Medications;
    private static readonly CqlValueSet _Adult_Depression_Medications = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1566", null);

    [CqlValueSetDefinition("Bipolar Disorder", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.67.1.101.1.128", valueSetVersion: null)]
    public CqlValueSet Bipolar_Disorder(CqlContext _) => _Bipolar_Disorder;
    private static readonly CqlValueSet _Bipolar_Disorder = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.67.1.101.1.128", null);

    [CqlValueSetDefinition("Encounter to Screen for Depression", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1916", valueSetVersion: null)]
    public CqlValueSet Encounter_to_Screen_for_Depression(CqlContext _) => _Encounter_to_Screen_for_Depression;
    private static readonly CqlValueSet _Encounter_to_Screen_for_Depression = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1916", null);

    [CqlValueSetDefinition("Follow Up for Adolescent Depression", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1569", valueSetVersion: null)]
    public CqlValueSet Follow_Up_for_Adolescent_Depression(CqlContext _) => _Follow_Up_for_Adolescent_Depression;
    private static readonly CqlValueSet _Follow_Up_for_Adolescent_Depression = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1569", null);

    [CqlValueSetDefinition("Follow Up for Adult Depression", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1568", valueSetVersion: null)]
    public CqlValueSet Follow_Up_for_Adult_Depression(CqlContext _) => _Follow_Up_for_Adult_Depression;
    private static readonly CqlValueSet _Follow_Up_for_Adult_Depression = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1568", null);

    [CqlValueSetDefinition("Medical Reason", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007", valueSetVersion: null)]
    public CqlValueSet Medical_Reason(CqlContext _) => _Medical_Reason;
    private static readonly CqlValueSet _Medical_Reason = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007", null);

    [CqlValueSetDefinition("Physical Therapy Evaluation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1022", valueSetVersion: null)]
    public CqlValueSet Physical_Therapy_Evaluation(CqlContext _) => _Physical_Therapy_Evaluation;
    private static readonly CqlValueSet _Physical_Therapy_Evaluation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1022", null);

    [CqlValueSetDefinition("Referral for Adolescent Depression", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1570", valueSetVersion: null)]
    public CqlValueSet Referral_for_Adolescent_Depression(CqlContext _) => _Referral_for_Adolescent_Depression;
    private static readonly CqlValueSet _Referral_for_Adolescent_Depression = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1570", null);

    [CqlValueSetDefinition("Referral for Adult Depression", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1571", valueSetVersion: null)]
    public CqlValueSet Referral_for_Adult_Depression(CqlContext _) => _Referral_for_Adult_Depression;
    private static readonly CqlValueSet _Referral_for_Adult_Depression = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1571", null);

    [CqlValueSetDefinition("Telephone Visits", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", valueSetVersion: null)]
    public CqlValueSet Telephone_Visits(CqlContext _) => _Telephone_Visits;
    private static readonly CqlValueSet _Telephone_Visits = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    #endregion ValueSets

    #region Codes (5)

    [CqlCodeDefinition("Adolescent depression screening assessment", codeId: "73831-0", codeSystem: "http://loinc.org")]
    public CqlCode Adolescent_depression_screening_assessment(CqlContext _) => _Adolescent_depression_screening_assessment;
    private static readonly CqlCode _Adolescent_depression_screening_assessment = new CqlCode("73831-0", "http://loinc.org");

    [CqlCodeDefinition("Adult depression screening assessment", codeId: "73832-8", codeSystem: "http://loinc.org")]
    public CqlCode Adult_depression_screening_assessment(CqlContext _) => _Adult_depression_screening_assessment;
    private static readonly CqlCode _Adult_depression_screening_assessment = new CqlCode("73832-8", "http://loinc.org");

    [CqlCodeDefinition("Depression screening declined (situation)", codeId: "720834000", codeSystem: "http://snomed.info/sct")]
    public CqlCode Depression_screening_declined__situation_(CqlContext _) => _Depression_screening_declined__situation_;
    private static readonly CqlCode _Depression_screening_declined__situation_ = new CqlCode("720834000", "http://snomed.info/sct");

    [CqlCodeDefinition("Depression screening negative (finding)", codeId: "428171000124102", codeSystem: "http://snomed.info/sct")]
    public CqlCode Depression_screening_negative__finding_(CqlContext _) => _Depression_screening_negative__finding_;
    private static readonly CqlCode _Depression_screening_negative__finding_ = new CqlCode("428171000124102", "http://snomed.info/sct");

    [CqlCodeDefinition("Depression screening positive (finding)", codeId: "428181000124104", codeSystem: "http://snomed.info/sct")]
    public CqlCode Depression_screening_positive__finding_(CqlContext _) => _Depression_screening_positive__finding_;
    private static readonly CqlCode _Depression_screening_positive__finding_ = new CqlCode("428181000124104", "http://snomed.info/sct");

    #endregion Codes

    #region CodeSystems (2)

    [CqlCodeSystemDefinition("LOINC", codeSystemId: "http://loinc.org", codeSystemVersion: null)]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, [
          _Adolescent_depression_screening_assessment,
          _Adult_depression_screening_assessment]);

    [CqlCodeSystemDefinition("SNOMEDCT", codeSystemId: "http://snomed.info/sct", codeSystemVersion: null)]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Depression_screening_declined__situation_,
          _Depression_screening_negative__finding_,
          _Depression_screening_positive__finding_]);

    #endregion CodeSystems

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = -5242312262230522551L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("CMS2FHIRPCSDepScreenAndFollowUp-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (28)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = 5190855989691056461L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Patient Age 12 Years or Older at Start of Measurement Period")]
    public bool? Patient_Age_12_Years_or_Older_at_Start_of_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient_Age_12_Years_or_Older_at_Start_of_Measurement_Period, Patient_Age_12_Years_or_Older_at_Start_of_Measurement_Period_Compute);

    private const long _cacheIndex_Patient_Age_12_Years_or_Older_at_Start_of_Measurement_Period = 2783151870802141391L;

    private bool? Patient_Age_12_Years_or_Older_at_Start_of_Measurement_Period_Compute(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Date b_ = a_?.BirthDateElement;
        string c_ = b_?.Value;
        CqlDate d_ = context.Operators.ConvertStringToDate(c_);
        CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
        CqlDateTime f_ = context.Operators.Start(e_);
        CqlDate g_ = context.Operators.DateFrom(f_);
        int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
        bool? i_ = context.Operators.GreaterOrEqual(h_, 12);
        return i_;
    }


    [CqlExpressionDefinition("Qualifying Encounter During Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Encounter_During_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Qualifying_Encounter_During_Measurement_Period, Qualifying_Encounter_During_Measurement_Period_Compute);

    private const long _cacheIndex_Qualifying_Encounter_During_Measurement_Period = -2035822618492698192L;

    private IEnumerable<Encounter> Qualifying_Encounter_During_Measurement_Period_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Encounter_to_Screen_for_Depression(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet c_ = this.Physical_Therapy_Evaluation(context);
        IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
        CqlValueSet f_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> h_ = context.Operators.Union<Encounter>(e_, g_);

        bool? i_(Encounter QualifyingEncounter) {
            CqlInterval<CqlDateTime> k_ = this.Measurement_Period(context);
            Period l_ = QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
            bool? n_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(k_, m_, "day");
            Code<Encounter.EncounterStatus> o_ = QualifyingEncounter?.StatusElement;
            Encounter.EncounterStatus? p_ = o_?.Value;
            Code<Encounter.EncounterStatus> q_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(p_);
            bool? r_ = context.Operators.Equal(q_, "finished");
            bool? s_ = context.Operators.And(n_, r_);
            return s_;
        }

        IEnumerable<Encounter> j_ = context.Operators.Where<Encounter>(h_, i_);
        return j_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = 2488112324664879244L;

    private bool? Initial_Population_Compute(CqlContext context)
    {
        bool? a_ = this.Patient_Age_12_Years_or_Older_at_Start_of_Measurement_Period(context);
        IEnumerable<Encounter> b_ = this.Qualifying_Encounter_During_Measurement_Period(context);
        bool? c_ = context.Operators.Exists<Encounter>(b_);
        bool? d_ = context.Operators.And(a_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = -3614056152365125233L;

    private bool? Denominator_Compute(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlExpressionDefinition("History of Bipolar Diagnosis Before Qualifying Encounter")]
    public IEnumerable<Condition> History_of_Bipolar_Diagnosis_Before_Qualifying_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_History_of_Bipolar_Diagnosis_Before_Qualifying_Encounter, History_of_Bipolar_Diagnosis_Before_Qualifying_Encounter_Compute);

    private const long _cacheIndex_History_of_Bipolar_Diagnosis_Before_Qualifying_Encounter = 4747339406206575732L;

    private IEnumerable<Condition> History_of_Bipolar_Diagnosis_Before_Qualifying_Encounter_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Bipolar_Disorder(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

        bool? c_(Condition BipolarDiagnosis) {
            IEnumerable<Encounter> e_ = this.Qualifying_Encounter_During_Measurement_Period(context);

            bool? f_(Encounter QualifyingEncounter) {
                CqlInterval<CqlDateTime> i_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, BipolarDiagnosis as Condition);
                CqlDateTime j_ = context.Operators.Start(i_);
                Period k_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
                CqlDateTime m_ = context.Operators.Start(l_);
                bool? n_ = context.Operators.Before(j_, m_, "day");
                return n_;
            }

            IEnumerable<Encounter> g_ = context.Operators.Where<Encounter>(e_, f_);
            bool? h_ = context.Operators.Exists<Encounter>(g_);
            return h_;
        }

        IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exclusions, Denominator_Exclusions_Compute);

    private const long _cacheIndex_Denominator_Exclusions = -8456017939157185868L;

    private bool? Denominator_Exclusions_Compute(CqlContext context)
    {
        IEnumerable<Condition> a_ = this.History_of_Bipolar_Diagnosis_Before_Qualifying_Encounter(context);
        bool? b_ = context.Operators.Exists<Condition>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Patient Age 12 to 16 Years at Start of Measurement Period")]
    public bool? Patient_Age_12_to_16_Years_at_Start_of_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient_Age_12_to_16_Years_at_Start_of_Measurement_Period, Patient_Age_12_to_16_Years_at_Start_of_Measurement_Period_Compute);

    private const long _cacheIndex_Patient_Age_12_to_16_Years_at_Start_of_Measurement_Period = 1190507547705569881L;

    private bool? Patient_Age_12_to_16_Years_at_Start_of_Measurement_Period_Compute(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Date b_ = a_?.BirthDateElement;
        string c_ = b_?.Value;
        CqlDate d_ = context.Operators.ConvertStringToDate(c_);
        CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
        CqlDateTime f_ = context.Operators.Start(e_);
        CqlDate g_ = context.Operators.DateFrom(f_);
        int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
        CqlInterval<int?> i_ = context.Operators.Interval(12, 16, true, true);
        bool? j_ = context.Operators.In<int?>(h_, i_, (string)default);
        return j_;
    }


    [CqlExpressionDefinition("Most Recent Adolescent Depression Screening")]
    public Observation Most_Recent_Adolescent_Depression_Screening(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Most_Recent_Adolescent_Depression_Screening, Most_Recent_Adolescent_Depression_Screening_Compute);

    private const long _cacheIndex_Most_Recent_Adolescent_Depression_Screening = -4120863769250766051L;

    private Observation Most_Recent_Adolescent_Depression_Screening_Compute(CqlContext context)
    {
        CqlCode a_ = this.Adolescent_depression_screening_assessment(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));

        bool? d_(Observation AdolescentDepressionScreening) {
            IEnumerable<Encounter> i_ = this.Qualifying_Encounter_During_Measurement_Period(context);

            bool? j_(Encounter QualifyingEncounter) {
                DataType m_ = AdolescentDepressionScreening?.Effective;
                object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
                CqlInterval<CqlDateTime> o_ = QICoreCommon_4_0_000.Instance.toInterval(context, n_);
                CqlDateTime p_ = context.Operators.End(o_);
                Period q_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> r_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, q_);
                CqlDateTime s_ = context.Operators.Start(r_);
                CqlQuantity t_ = context.Operators.Quantity(14m, "days");
                CqlDateTime u_ = context.Operators.Subtract(s_, t_);
                CqlInterval<CqlDateTime> w_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, q_);
                CqlDateTime x_ = context.Operators.Start(w_);
                CqlInterval<CqlDateTime> y_ = context.Operators.Interval(u_, x_, true, true);
                bool? z_ = context.Operators.In<CqlDateTime>(p_, y_, "day");
                CqlInterval<CqlDateTime> ab_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, q_);
                CqlDateTime ac_ = context.Operators.Start(ab_);
                bool? ad_ = context.Operators.Not((bool?)(ac_ is null));
                bool? ae_ = context.Operators.And(z_, ad_);
                DataType af_ = AdolescentDepressionScreening?.Value;
                object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                bool? ah_ = context.Operators.Not((bool?)(ag_ is null));
                bool? ai_ = context.Operators.And(ae_, ah_);
                Code<ObservationStatus> aj_ = AdolescentDepressionScreening?.StatusElement;
                ObservationStatus? ak_ = aj_?.Value;
                string al_ = context.Operators.Convert<string>(ak_);
                string[] am_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? an_ = context.Operators.In<string>(al_, (IEnumerable<string>)am_);
                bool? ao_ = context.Operators.And(ai_, an_);
                return ao_;
            }

            IEnumerable<Encounter> k_ = context.Operators.Where<Encounter>(i_, j_);
            bool? l_ = context.Operators.Exists<Encounter>(k_);
            return l_;
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

        object f_(Observation @this) {
            DataType ap_ = @this?.Effective;
            object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
            CqlInterval<CqlDateTime> ar_ = QICoreCommon_4_0_000.Instance.toInterval(context, aq_);
            CqlDateTime as_ = context.Operators.Start(ar_);
            return as_;
        }

        IEnumerable<Observation> g_ = context.Operators.SortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
        Observation h_ = context.Operators.Last<Observation>(g_);
        return h_;
    }


    [CqlExpressionDefinition("Has Most Recent Adolescent Screening Negative")]
    public bool? Has_Most_Recent_Adolescent_Screening_Negative(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Most_Recent_Adolescent_Screening_Negative, Has_Most_Recent_Adolescent_Screening_Negative_Compute);

    private const long _cacheIndex_Has_Most_Recent_Adolescent_Screening_Negative = -7795550947536406787L;

    private bool? Has_Most_Recent_Adolescent_Screening_Negative_Compute(CqlContext context)
    {
        Observation a_ = this.Most_Recent_Adolescent_Depression_Screening(context);
        Observation[] b_ = [
            a_,
        ];

        bool? c_(Observation AdolescentScreen) {
            DataType g_ = AdolescentScreen?.Value;
            object h_ = FHIRHelpers_4_4_000.Instance.ToValue(context, g_);
            CqlCode i_ = this.Depression_screening_negative__finding_(context);
            CqlConcept j_ = context.Operators.ConvertCodeToConcept(i_);
            bool? k_ = context.Operators.Equivalent(h_ as CqlConcept, j_);
            return k_;
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>((IEnumerable<Observation>)b_, c_);
        Observation e_ = context.Operators.SingletonFrom<Observation>(d_);
        bool? f_ = context.Operators.Not((bool?)(e_ is null));
        return f_;
    }


    [CqlExpressionDefinition("Follow Up Intervention for Positive Adolescent Depression Screening")]
    public IEnumerable<object> Follow_Up_Intervention_for_Positive_Adolescent_Depression_Screening(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Follow_Up_Intervention_for_Positive_Adolescent_Depression_Screening, Follow_Up_Intervention_for_Positive_Adolescent_Depression_Screening_Compute);

    private const long _cacheIndex_Follow_Up_Intervention_for_Positive_Adolescent_Depression_Screening = -2454462295688409122L;

    private IEnumerable<object> Follow_Up_Intervention_for_Positive_Adolescent_Depression_Screening_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Adolescent_Depression_Medications(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> c_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? d_(MedicationRequest MR) {
            IEnumerable<Medication> s_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? t_(Medication M) {
                object w_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object x_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> y_ = context.Operators.Split((string)x_, "/");
                string z_ = context.Operators.Last<string>(y_);
                bool? aa_ = context.Operators.Equal(w_, z_);
                CodeableConcept ab_ = M?.Code;
                CqlConcept ac_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ab_);
                CqlValueSet ad_ = this.Adolescent_Depression_Medications(context);
                bool? ae_ = context.Operators.ConceptInValueSet(ac_, ad_);
                bool? af_ = context.Operators.And(aa_, ae_);
                return af_;
            }

            IEnumerable<Medication> u_ = context.Operators.Where<Medication>(s_, t_);
            bool? v_ = context.Operators.Exists<Medication>(u_);
            return v_;
        }

        IEnumerable<MedicationRequest> e_ = context.Operators.Where<MedicationRequest>(c_, d_);
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(b_, e_);

        bool? g_(MedicationRequest AdolescentMed) {
            IEnumerable<Encounter> ag_ = this.Qualifying_Encounter_During_Measurement_Period(context);

            bool? ah_(Encounter QualifyingEncounter) {
                Observation ak_ = this.Most_Recent_Adolescent_Depression_Screening(context);
                DataType al_ = ak_?.Effective;
                object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                CqlInterval<CqlDateTime> an_ = QICoreCommon_4_0_000.Instance.toInterval(context, am_);
                CqlDateTime ao_ = context.Operators.Start(an_);
                Period ap_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> aq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ap_);
                CqlDateTime ar_ = context.Operators.Start(aq_);
                CqlQuantity as_ = context.Operators.Quantity(14m, "days");
                CqlDateTime at_ = context.Operators.Subtract(ar_, as_);
                CqlInterval<CqlDateTime> av_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ap_);
                CqlDateTime aw_ = context.Operators.Start(av_);
                CqlInterval<CqlDateTime> ax_ = context.Operators.Interval(at_, aw_, true, true);
                bool? ay_ = context.Operators.In<CqlDateTime>(ao_, ax_, "day");
                CqlInterval<CqlDateTime> ba_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ap_);
                CqlDateTime bb_ = context.Operators.Start(ba_);
                bool? bc_ = context.Operators.Not((bool?)(bb_ is null));
                bool? bd_ = context.Operators.And(ay_, bc_);
                CqlInterval<CqlDate> be_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, AdolescentMed);
                CqlDate bf_ = (be_ as CqlInterval<CqlDate>)?.low;
                CqlDateTime bg_ = context.Operators.ConvertDateToDateTime(bf_);
                CqlDate bi_ = (be_ as CqlInterval<CqlDate>)?.high;
                CqlDateTime bj_ = context.Operators.ConvertDateToDateTime(bi_);
                bool? bl_ = (be_ as CqlInterval<CqlDate>)?.lowClosed;
                bool? bn_ = (be_ as CqlInterval<CqlDate>)?.highClosed;
                CqlInterval<CqlDateTime> bo_ = context.Operators.Interval(bg_, bj_, bl_, bn_);
                CqlInterval<CqlDateTime> bp_ = QICoreCommon_4_0_000.Instance.toInterval(context, bo_);
                CqlInterval<CqlDateTime> br_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ap_);
                bool? bs_ = context.Operators.OverlapsAfter(bp_, br_, "day");
                bool? bt_ = context.Operators.And(bd_, bs_);
                DataType bv_ = ak_?.Value;
                object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                CqlCode bx_ = this.Depression_screening_positive__finding_(context);
                CqlConcept by_ = context.Operators.ConvertCodeToConcept(bx_);
                bool? bz_ = context.Operators.Equivalent(bw_ as CqlConcept, by_);
                bool? ca_ = context.Operators.And(bt_, bz_);
                Code<MedicationRequest.MedicationrequestStatus> cb_ = AdolescentMed?.StatusElement;
                MedicationRequest.MedicationrequestStatus? cc_ = cb_?.Value;
                string cd_ = context.Operators.Convert<string>(cc_);
                string[] ce_ = [
                    "active",
                    "completed",
                ];
                bool? cf_ = context.Operators.In<string>(cd_, (IEnumerable<string>)ce_);
                bool? cg_ = context.Operators.And(ca_, cf_);
                Code<MedicationRequest.MedicationRequestIntent> ch_ = AdolescentMed?.IntentElement;
                MedicationRequest.MedicationRequestIntent? ci_ = ch_?.Value;
                string cj_ = context.Operators.Convert<string>(ci_);
                string[] ck_ = [
                    "order",
                    "original-order",
                    "reflex-order",
                    "filler-order",
                    "instance-order",
                ];
                bool? cl_ = context.Operators.In<string>(cj_, (IEnumerable<string>)ck_);
                bool? cm_ = context.Operators.And(cg_, cl_);
                return cm_;
            }

            IEnumerable<Encounter> ai_ = context.Operators.Where<Encounter>(ag_, ah_);
            bool? aj_ = context.Operators.Exists<Encounter>(ai_);
            return aj_;
        }

        IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);
        CqlValueSet i_ = this.Referral_for_Adolescent_Depression(context);
        IEnumerable<ServiceRequest> j_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));

        bool? k_(ServiceRequest AdolescentReferral) {
            Code<RequestStatus> cn_ = AdolescentReferral?.StatusElement;
            RequestStatus? co_ = cn_?.Value;
            Code<RequestStatus> cp_ = context.Operators.Convert<Code<RequestStatus>>(co_);
            string cq_ = context.Operators.Convert<string>(cp_);
            string[] cr_ = [
                "active",
                "completed",
            ];
            bool? cs_ = context.Operators.In<string>(cq_, (IEnumerable<string>)cr_);
            return cs_;
        }

        IEnumerable<ServiceRequest> l_ = context.Operators.Where<ServiceRequest>(j_, k_);
        IEnumerable<object> m_ = context.Operators.Union<object>(h_ as IEnumerable<object>, l_ as IEnumerable<object>);
        CqlValueSet n_ = this.Follow_Up_for_Adolescent_Depression(context);
        IEnumerable<Procedure> o_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

        bool? p_(Procedure AdolescentFollowUp) {
            Code<EventStatus> ct_ = AdolescentFollowUp?.StatusElement;
            EventStatus? cu_ = ct_?.Value;
            string cv_ = context.Operators.Convert<string>(cu_);
            bool? cw_ = context.Operators.Equal(cv_, "completed");
            return cw_;
        }

        IEnumerable<Procedure> q_ = context.Operators.Where<Procedure>(o_, p_);
        IEnumerable<object> r_ = context.Operators.Union<object>(m_ as IEnumerable<object>, q_ as IEnumerable<object>);
        return r_;
    }


    [CqlExpressionDefinition("Most Recent Adolescent Depression Screening Positive and Follow Up Provided")]
    public IEnumerable<(CqlTupleMetadata, Observation LastAdolescentScreen, object FollowUpPositiveAdolescentScreen, Encounter QualifyingEncounter)?> Most_Recent_Adolescent_Depression_Screening_Positive_and_Follow_Up_Provided(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Most_Recent_Adolescent_Depression_Screening_Positive_and_Follow_Up_Provided, Most_Recent_Adolescent_Depression_Screening_Positive_and_Follow_Up_Provided_Compute);

    private const long _cacheIndex_Most_Recent_Adolescent_Depression_Screening_Positive_and_Follow_Up_Provided = -3834289523634019273L;

    private IEnumerable<(CqlTupleMetadata, Observation LastAdolescentScreen, object FollowUpPositiveAdolescentScreen, Encounter QualifyingEncounter)?> Most_Recent_Adolescent_Depression_Screening_Positive_and_Follow_Up_Provided_Compute(CqlContext context)
    {
        Observation a_ = this.Most_Recent_Adolescent_Depression_Screening(context);
        Observation[] b_ = [
            a_,
        ];
        IEnumerable<object> c_ = this.Follow_Up_Intervention_for_Positive_Adolescent_Depression_Screening(context);
        IEnumerable<Encounter> d_ = this.Qualifying_Encounter_During_Measurement_Period(context);
        IEnumerable<ValueTuple<Observation, object, Encounter>> e_ = context.Operators.CrossJoin<Observation, object, Encounter>((IEnumerable<Observation>)b_, c_, d_);

        (CqlTupleMetadata, Observation LastAdolescentScreen, object FollowUpPositiveAdolescentScreen, Encounter QualifyingEncounter)? f_(ValueTuple<Observation, object, Encounter> _valueTuple) {
            (CqlTupleMetadata, Observation LastAdolescentScreen, object FollowUpPositiveAdolescentScreen, Encounter QualifyingEncounter)? m_ = (CqlTupleMetadata_ZRHehPJEDEeRJPiLbCPjUggS, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return m_;
        }

        IEnumerable<(CqlTupleMetadata, Observation LastAdolescentScreen, object FollowUpPositiveAdolescentScreen, Encounter QualifyingEncounter)?> g_ = context.Operators.Select<ValueTuple<Observation, object, Encounter>, (CqlTupleMetadata, Observation LastAdolescentScreen, object FollowUpPositiveAdolescentScreen, Encounter QualifyingEncounter)?>(e_, f_);

        bool? h_((CqlTupleMetadata, Observation LastAdolescentScreen, object FollowUpPositiveAdolescentScreen, Encounter QualifyingEncounter)? tuple_ewmohjtdtinujhphqjvbwmmhh) {
            DataType n_ = tuple_ewmohjtdtinujhphqjvbwmmhh?.LastAdolescentScreen?.Effective;
            object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
            CqlInterval<CqlDateTime> p_ = QICoreCommon_4_0_000.Instance.toInterval(context, o_);
            CqlDateTime q_ = context.Operators.Start(p_);
            Period r_ = tuple_ewmohjtdtinujhphqjvbwmmhh?.QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> s_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
            CqlDateTime t_ = context.Operators.Start(s_);
            CqlQuantity u_ = context.Operators.Quantity(14m, "days");
            CqlDateTime v_ = context.Operators.Subtract(t_, u_);
            CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
            CqlDateTime y_ = context.Operators.Start(x_);
            CqlInterval<CqlDateTime> z_ = context.Operators.Interval(v_, y_, true, true);
            bool? aa_ = context.Operators.In<CqlDateTime>(q_, z_, "day");
            CqlInterval<CqlDateTime> ac_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
            CqlDateTime ad_ = context.Operators.Start(ac_);
            bool? ae_ = context.Operators.Not((bool?)(ad_ is null));
            bool? af_ = context.Operators.And(aa_, ae_);
            DataType ag_ = tuple_ewmohjtdtinujhphqjvbwmmhh?.LastAdolescentScreen?.Value;
            object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
            CqlCode ai_ = this.Depression_screening_positive__finding_(context);
            CqlConcept aj_ = context.Operators.ConvertCodeToConcept(ai_);
            bool? ak_ = context.Operators.Equivalent(ah_ as CqlConcept, aj_);
            bool? al_ = context.Operators.And(af_, ak_);

            object am_() {

                bool bt_() {
                    object bx_ = context.Operators.LateBoundProperty<object>(tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen, "performed");
                    object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                    bool bz_ = by_ is CqlDateTime;
                    return bz_;
                }


                bool bu_() {
                    object ca_ = context.Operators.LateBoundProperty<object>(tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen, "performed");
                    object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                    bool cc_ = cb_ is CqlInterval<CqlDateTime>;
                    return cc_;
                }


                bool bv_() {
                    object cd_ = context.Operators.LateBoundProperty<object>(tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen, "performed");
                    object ce_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cd_);
                    bool cf_ = ce_ is CqlQuantity;
                    return cf_;
                }


                bool bw_() {
                    object cg_ = context.Operators.LateBoundProperty<object>(tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen, "performed");
                    object ch_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cg_);
                    bool ci_ = ch_ is CqlInterval<CqlQuantity>;
                    return ci_;
                }

                if (bt_())
                {
                    object cj_ = context.Operators.LateBoundProperty<object>(tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen, "performed");
                    object ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
                    return (ck_ as CqlDateTime) as object;
                }
                else if (bu_())
                {
                    object cl_ = context.Operators.LateBoundProperty<object>(tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen, "performed");
                    object cm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cl_);
                    return (cm_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (bv_())
                {
                    object cn_ = context.Operators.LateBoundProperty<object>(tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen, "performed");
                    object co_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cn_);
                    return (co_ as CqlQuantity) as object;
                }
                else if (bw_())
                {
                    object cp_ = context.Operators.LateBoundProperty<object>(tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen, "performed");
                    object cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
                    return (cq_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> an_ = QICoreCommon_4_0_000.Instance.toInterval(context, am_());
            CqlDateTime ao_ = context.Operators.Start(an_);
            CqlInterval<CqlDateTime> aq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
            bool? ar_ = context.Operators.In<CqlDateTime>(ao_, aq_, (string)default);
            object as_ = context.Operators.LateBoundProperty<object>(tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen, "authoredOn");
            CqlDateTime at_ = context.Operators.LateBoundProperty<CqlDateTime>(as_, "value");
            CqlInterval<CqlDateTime> av_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
            CqlDateTime aw_ = context.Operators.End(av_);
            CqlInterval<CqlDateTime> ay_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
            CqlDateTime az_ = context.Operators.End(ay_);
            CqlQuantity ba_ = context.Operators.Quantity(2m, "days");
            CqlDateTime bb_ = context.Operators.Add(az_, ba_);
            CqlInterval<CqlDateTime> bc_ = context.Operators.Interval(aw_, bb_, true, true);
            bool? bd_ = context.Operators.In<CqlDateTime>(at_, bc_, "day");
            CqlInterval<CqlDateTime> bf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
            CqlDateTime bg_ = context.Operators.End(bf_);
            bool? bh_ = context.Operators.Not((bool?)(bg_ is null));
            bool? bi_ = context.Operators.And(bd_, bh_);
            bool? bj_ = context.Operators.Or(ar_, bi_);
            bool? bk_ = context.Operators.And(al_, bj_);

            object bl_() {

                bool cr_() {
                    object cv_ = context.Operators.LateBoundProperty<object>(tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen, "performed");
                    object cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);
                    bool cx_ = cw_ is CqlDateTime;
                    return cx_;
                }


                bool cs_() {
                    object cy_ = context.Operators.LateBoundProperty<object>(tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen, "performed");
                    object cz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cy_);
                    bool da_ = cz_ is CqlInterval<CqlDateTime>;
                    return da_;
                }


                bool ct_() {
                    object db_ = context.Operators.LateBoundProperty<object>(tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen, "performed");
                    object dc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, db_);
                    bool dd_ = dc_ is CqlQuantity;
                    return dd_;
                }


                bool cu_() {
                    object de_ = context.Operators.LateBoundProperty<object>(tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen, "performed");
                    object df_ = FHIRHelpers_4_4_000.Instance.ToValue(context, de_);
                    bool dg_ = df_ is CqlInterval<CqlQuantity>;
                    return dg_;
                }

                if (cr_())
                {
                    object dh_ = context.Operators.LateBoundProperty<object>(tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen, "performed");
                    object di_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dh_);
                    return (di_ as CqlDateTime) as object;
                }
                else if (cs_())
                {
                    object dj_ = context.Operators.LateBoundProperty<object>(tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen, "performed");
                    object dk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dj_);
                    return (dk_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (ct_())
                {
                    object dl_ = context.Operators.LateBoundProperty<object>(tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen, "performed");
                    object dm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dl_);
                    return (dm_ as CqlQuantity) as object;
                }
                else if (cu_())
                {
                    object dn_ = context.Operators.LateBoundProperty<object>(tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen, "performed");
                    object do_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dn_);
                    return (do_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> bm_ = QICoreCommon_4_0_000.Instance.toInterval(context, bl_());
            CqlDateTime bn_ = context.Operators.Start(bm_);
            CqlDateTime bp_ = context.Operators.LateBoundProperty<CqlDateTime>(as_, "value");
            CqlInterval<CqlDateTime> bq_ = this.Measurement_Period(context);
            bool? br_ = context.Operators.In<CqlDateTime>(bn_ ?? bp_, bq_, "day");
            bool? bs_ = context.Operators.And(bk_, br_);
            return bs_;
        }

        IEnumerable<(CqlTupleMetadata, Observation LastAdolescentScreen, object FollowUpPositiveAdolescentScreen, Encounter QualifyingEncounter)?> i_ = context.Operators.Where<(CqlTupleMetadata, Observation LastAdolescentScreen, object FollowUpPositiveAdolescentScreen, Encounter QualifyingEncounter)?>(g_, h_);

        (CqlTupleMetadata, Observation LastAdolescentScreen, object FollowUpPositiveAdolescentScreen, Encounter QualifyingEncounter)? j_((CqlTupleMetadata, Observation LastAdolescentScreen, object FollowUpPositiveAdolescentScreen, Encounter QualifyingEncounter)? tuple_ewmohjtdtinujhphqjvbwmmhh) {
            (CqlTupleMetadata, Observation LastAdolescentScreen, object FollowUpPositiveAdolescentScreen, Encounter QualifyingEncounter)? dp_ = (CqlTupleMetadata_ZRHehPJEDEeRJPiLbCPjUggS, tuple_ewmohjtdtinujhphqjvbwmmhh?.LastAdolescentScreen, tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen, tuple_ewmohjtdtinujhphqjvbwmmhh?.QualifyingEncounter);
            return dp_;
        }

        IEnumerable<(CqlTupleMetadata, Observation LastAdolescentScreen, object FollowUpPositiveAdolescentScreen, Encounter QualifyingEncounter)?> k_ = context.Operators.Select<(CqlTupleMetadata, Observation LastAdolescentScreen, object FollowUpPositiveAdolescentScreen, Encounter QualifyingEncounter)?, (CqlTupleMetadata, Observation LastAdolescentScreen, object FollowUpPositiveAdolescentScreen, Encounter QualifyingEncounter)?>(i_, j_);
        IEnumerable<(CqlTupleMetadata, Observation LastAdolescentScreen, object FollowUpPositiveAdolescentScreen, Encounter QualifyingEncounter)?> l_ = context.Operators.Distinct<(CqlTupleMetadata, Observation LastAdolescentScreen, object FollowUpPositiveAdolescentScreen, Encounter QualifyingEncounter)?>(k_);
        return l_;
    }


    [CqlExpressionDefinition("Patient Age 17 Years at Start of Measurement Period")]
    public bool? Patient_Age_17_Years_at_Start_of_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient_Age_17_Years_at_Start_of_Measurement_Period, Patient_Age_17_Years_at_Start_of_Measurement_Period_Compute);

    private const long _cacheIndex_Patient_Age_17_Years_at_Start_of_Measurement_Period = -6839495476783362047L;

    private bool? Patient_Age_17_Years_at_Start_of_Measurement_Period_Compute(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Date b_ = a_?.BirthDateElement;
        string c_ = b_?.Value;
        CqlDate d_ = context.Operators.ConvertStringToDate(c_);
        CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
        CqlDateTime f_ = context.Operators.Start(e_);
        CqlDate g_ = context.Operators.DateFrom(f_);
        int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
        bool? i_ = context.Operators.Equal(h_, 17);
        return i_;
    }


    [CqlExpressionDefinition("Most Recent Adult Depression Screening")]
    public Observation Most_Recent_Adult_Depression_Screening(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Most_Recent_Adult_Depression_Screening, Most_Recent_Adult_Depression_Screening_Compute);

    private const long _cacheIndex_Most_Recent_Adult_Depression_Screening = -2260780317776156740L;

    private Observation Most_Recent_Adult_Depression_Screening_Compute(CqlContext context)
    {
        CqlCode a_ = this.Adult_depression_screening_assessment(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));

        bool? d_(Observation AdultDepressionScreening) {
            IEnumerable<Encounter> i_ = this.Qualifying_Encounter_During_Measurement_Period(context);

            bool? j_(Encounter QualifyingEncounter) {
                DataType m_ = AdultDepressionScreening?.Effective;
                object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
                CqlInterval<CqlDateTime> o_ = QICoreCommon_4_0_000.Instance.toInterval(context, n_);
                CqlDateTime p_ = context.Operators.End(o_);
                Period q_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> r_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, q_);
                CqlDateTime s_ = context.Operators.Start(r_);
                CqlQuantity t_ = context.Operators.Quantity(14m, "days");
                CqlDateTime u_ = context.Operators.Subtract(s_, t_);
                CqlInterval<CqlDateTime> w_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, q_);
                CqlDateTime x_ = context.Operators.Start(w_);
                CqlInterval<CqlDateTime> y_ = context.Operators.Interval(u_, x_, true, true);
                bool? z_ = context.Operators.In<CqlDateTime>(p_, y_, "day");
                CqlInterval<CqlDateTime> ab_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, q_);
                CqlDateTime ac_ = context.Operators.Start(ab_);
                bool? ad_ = context.Operators.Not((bool?)(ac_ is null));
                bool? ae_ = context.Operators.And(z_, ad_);
                DataType af_ = AdultDepressionScreening?.Value;
                object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                bool? ah_ = context.Operators.Not((bool?)(ag_ is null));
                bool? ai_ = context.Operators.And(ae_, ah_);
                Code<ObservationStatus> aj_ = AdultDepressionScreening?.StatusElement;
                ObservationStatus? ak_ = aj_?.Value;
                string al_ = context.Operators.Convert<string>(ak_);
                string[] am_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? an_ = context.Operators.In<string>(al_, (IEnumerable<string>)am_);
                bool? ao_ = context.Operators.And(ai_, an_);
                return ao_;
            }

            IEnumerable<Encounter> k_ = context.Operators.Where<Encounter>(i_, j_);
            bool? l_ = context.Operators.Exists<Encounter>(k_);
            return l_;
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

        object f_(Observation @this) {
            DataType ap_ = @this?.Effective;
            object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
            CqlInterval<CqlDateTime> ar_ = QICoreCommon_4_0_000.Instance.toInterval(context, aq_);
            CqlDateTime as_ = context.Operators.Start(ar_);
            return as_;
        }

        IEnumerable<Observation> g_ = context.Operators.SortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
        Observation h_ = context.Operators.Last<Observation>(g_);
        return h_;
    }


    [CqlExpressionDefinition("Has Most Recent Adult Screening Negative")]
    public bool? Has_Most_Recent_Adult_Screening_Negative(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Most_Recent_Adult_Screening_Negative, Has_Most_Recent_Adult_Screening_Negative_Compute);

    private const long _cacheIndex_Has_Most_Recent_Adult_Screening_Negative = -2761200117802345495L;

    private bool? Has_Most_Recent_Adult_Screening_Negative_Compute(CqlContext context)
    {
        Observation a_ = this.Most_Recent_Adult_Depression_Screening(context);
        Observation[] b_ = [
            a_,
        ];

        bool? c_(Observation AdultScreen) {
            DataType g_ = AdultScreen?.Value;
            object h_ = FHIRHelpers_4_4_000.Instance.ToValue(context, g_);
            CqlCode i_ = this.Depression_screening_negative__finding_(context);
            CqlConcept j_ = context.Operators.ConvertCodeToConcept(i_);
            bool? k_ = context.Operators.Equivalent(h_ as CqlConcept, j_);
            return k_;
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>((IEnumerable<Observation>)b_, c_);
        Observation e_ = context.Operators.SingletonFrom<Observation>(d_);
        bool? f_ = context.Operators.Not((bool?)(e_ is null));
        return f_;
    }


    [CqlExpressionDefinition("Follow Up Intervention for Positive Adult Depression Screening")]
    public IEnumerable<object> Follow_Up_Intervention_for_Positive_Adult_Depression_Screening(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Follow_Up_Intervention_for_Positive_Adult_Depression_Screening, Follow_Up_Intervention_for_Positive_Adult_Depression_Screening_Compute);

    private const long _cacheIndex_Follow_Up_Intervention_for_Positive_Adult_Depression_Screening = 8801585706686387465L;

    private IEnumerable<object> Follow_Up_Intervention_for_Positive_Adult_Depression_Screening_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Adult_Depression_Medications(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> c_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? d_(MedicationRequest MR) {
            IEnumerable<Medication> s_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? t_(Medication M) {
                object w_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object x_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> y_ = context.Operators.Split((string)x_, "/");
                string z_ = context.Operators.Last<string>(y_);
                bool? aa_ = context.Operators.Equal(w_, z_);
                CodeableConcept ab_ = M?.Code;
                CqlConcept ac_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ab_);
                CqlValueSet ad_ = this.Adult_Depression_Medications(context);
                bool? ae_ = context.Operators.ConceptInValueSet(ac_, ad_);
                bool? af_ = context.Operators.And(aa_, ae_);
                return af_;
            }

            IEnumerable<Medication> u_ = context.Operators.Where<Medication>(s_, t_);
            bool? v_ = context.Operators.Exists<Medication>(u_);
            return v_;
        }

        IEnumerable<MedicationRequest> e_ = context.Operators.Where<MedicationRequest>(c_, d_);
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(b_, e_);

        bool? g_(MedicationRequest AdultMed) {
            IEnumerable<Encounter> ag_ = this.Qualifying_Encounter_During_Measurement_Period(context);

            bool? ah_(Encounter QualifyingEncounter) {
                Observation ak_ = this.Most_Recent_Adult_Depression_Screening(context);
                DataType al_ = ak_?.Effective;
                object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                CqlInterval<CqlDateTime> an_ = QICoreCommon_4_0_000.Instance.toInterval(context, am_);
                CqlDateTime ao_ = context.Operators.Start(an_);
                Period ap_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> aq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ap_);
                CqlDateTime ar_ = context.Operators.Start(aq_);
                CqlQuantity as_ = context.Operators.Quantity(14m, "days");
                CqlDateTime at_ = context.Operators.Subtract(ar_, as_);
                CqlInterval<CqlDateTime> av_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ap_);
                CqlDateTime aw_ = context.Operators.Start(av_);
                CqlInterval<CqlDateTime> ax_ = context.Operators.Interval(at_, aw_, true, true);
                bool? ay_ = context.Operators.In<CqlDateTime>(ao_, ax_, "day");
                CqlInterval<CqlDateTime> ba_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ap_);
                CqlDateTime bb_ = context.Operators.Start(ba_);
                bool? bc_ = context.Operators.Not((bool?)(bb_ is null));
                bool? bd_ = context.Operators.And(ay_, bc_);
                CqlInterval<CqlDate> be_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, AdultMed);
                CqlDate bf_ = (be_ as CqlInterval<CqlDate>)?.low;
                CqlDateTime bg_ = context.Operators.ConvertDateToDateTime(bf_);
                CqlDate bi_ = (be_ as CqlInterval<CqlDate>)?.high;
                CqlDateTime bj_ = context.Operators.ConvertDateToDateTime(bi_);
                bool? bl_ = (be_ as CqlInterval<CqlDate>)?.lowClosed;
                bool? bn_ = (be_ as CqlInterval<CqlDate>)?.highClosed;
                CqlInterval<CqlDateTime> bo_ = context.Operators.Interval(bg_, bj_, bl_, bn_);
                CqlInterval<CqlDateTime> bp_ = QICoreCommon_4_0_000.Instance.toInterval(context, bo_);
                CqlInterval<CqlDateTime> br_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ap_);
                bool? bs_ = context.Operators.OverlapsAfter(bp_, br_, "day");
                bool? bt_ = context.Operators.And(bd_, bs_);
                DataType bv_ = ak_?.Value;
                object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                CqlCode bx_ = this.Depression_screening_positive__finding_(context);
                CqlConcept by_ = context.Operators.ConvertCodeToConcept(bx_);
                bool? bz_ = context.Operators.Equivalent(bw_ as CqlConcept, by_);
                bool? ca_ = context.Operators.And(bt_, bz_);
                Code<MedicationRequest.MedicationrequestStatus> cb_ = AdultMed?.StatusElement;
                MedicationRequest.MedicationrequestStatus? cc_ = cb_?.Value;
                string cd_ = context.Operators.Convert<string>(cc_);
                string[] ce_ = [
                    "active",
                    "completed",
                ];
                bool? cf_ = context.Operators.In<string>(cd_, (IEnumerable<string>)ce_);
                bool? cg_ = context.Operators.And(ca_, cf_);
                Code<MedicationRequest.MedicationRequestIntent> ch_ = AdultMed?.IntentElement;
                MedicationRequest.MedicationRequestIntent? ci_ = ch_?.Value;
                string cj_ = context.Operators.Convert<string>(ci_);
                string[] ck_ = [
                    "order",
                    "original-order",
                    "reflex-order",
                    "filler-order",
                    "instance-order",
                ];
                bool? cl_ = context.Operators.In<string>(cj_, (IEnumerable<string>)ck_);
                bool? cm_ = context.Operators.And(cg_, cl_);
                return cm_;
            }

            IEnumerable<Encounter> ai_ = context.Operators.Where<Encounter>(ag_, ah_);
            bool? aj_ = context.Operators.Exists<Encounter>(ai_);
            return aj_;
        }

        IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);
        CqlValueSet i_ = this.Referral_for_Adult_Depression(context);
        IEnumerable<ServiceRequest> j_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));

        bool? k_(ServiceRequest AdultReferral) {
            Code<RequestStatus> cn_ = AdultReferral?.StatusElement;
            RequestStatus? co_ = cn_?.Value;
            Code<RequestStatus> cp_ = context.Operators.Convert<Code<RequestStatus>>(co_);
            string cq_ = context.Operators.Convert<string>(cp_);
            string[] cr_ = [
                "active",
                "completed",
            ];
            bool? cs_ = context.Operators.In<string>(cq_, (IEnumerable<string>)cr_);
            return cs_;
        }

        IEnumerable<ServiceRequest> l_ = context.Operators.Where<ServiceRequest>(j_, k_);
        IEnumerable<object> m_ = context.Operators.Union<object>(h_ as IEnumerable<object>, l_ as IEnumerable<object>);
        CqlValueSet n_ = this.Follow_Up_for_Adult_Depression(context);
        IEnumerable<Procedure> o_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

        bool? p_(Procedure AdultFollowUp) {
            Code<EventStatus> ct_ = AdultFollowUp?.StatusElement;
            EventStatus? cu_ = ct_?.Value;
            string cv_ = context.Operators.Convert<string>(cu_);
            bool? cw_ = context.Operators.Equal(cv_, "completed");
            return cw_;
        }

        IEnumerable<Procedure> q_ = context.Operators.Where<Procedure>(o_, p_);
        IEnumerable<object> r_ = context.Operators.Union<object>(m_ as IEnumerable<object>, q_ as IEnumerable<object>);
        return r_;
    }


    [CqlExpressionDefinition("Most Recent Adult Depression Screening Positive and Follow Up Provided")]
    public IEnumerable<(CqlTupleMetadata, Observation LastAdultScreen, object FollowUpPositiveAdultScreen, Encounter QualifyingEncounter)?> Most_Recent_Adult_Depression_Screening_Positive_and_Follow_Up_Provided(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Most_Recent_Adult_Depression_Screening_Positive_and_Follow_Up_Provided, Most_Recent_Adult_Depression_Screening_Positive_and_Follow_Up_Provided_Compute);

    private const long _cacheIndex_Most_Recent_Adult_Depression_Screening_Positive_and_Follow_Up_Provided = -4270614387795433444L;

    private IEnumerable<(CqlTupleMetadata, Observation LastAdultScreen, object FollowUpPositiveAdultScreen, Encounter QualifyingEncounter)?> Most_Recent_Adult_Depression_Screening_Positive_and_Follow_Up_Provided_Compute(CqlContext context)
    {
        Observation a_ = this.Most_Recent_Adult_Depression_Screening(context);
        Observation[] b_ = [
            a_,
        ];
        IEnumerable<object> c_ = this.Follow_Up_Intervention_for_Positive_Adult_Depression_Screening(context);
        IEnumerable<Encounter> d_ = this.Qualifying_Encounter_During_Measurement_Period(context);
        IEnumerable<ValueTuple<Observation, object, Encounter>> e_ = context.Operators.CrossJoin<Observation, object, Encounter>((IEnumerable<Observation>)b_, c_, d_);

        (CqlTupleMetadata, Observation LastAdultScreen, object FollowUpPositiveAdultScreen, Encounter QualifyingEncounter)? f_(ValueTuple<Observation, object, Encounter> _valueTuple) {
            (CqlTupleMetadata, Observation LastAdultScreen, object FollowUpPositiveAdultScreen, Encounter QualifyingEncounter)? m_ = (CqlTupleMetadata_ICeCVaggPeLLMJUWQdWMZROe, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return m_;
        }

        IEnumerable<(CqlTupleMetadata, Observation LastAdultScreen, object FollowUpPositiveAdultScreen, Encounter QualifyingEncounter)?> g_ = context.Operators.Select<ValueTuple<Observation, object, Encounter>, (CqlTupleMetadata, Observation LastAdultScreen, object FollowUpPositiveAdultScreen, Encounter QualifyingEncounter)?>(e_, f_);

        bool? h_((CqlTupleMetadata, Observation LastAdultScreen, object FollowUpPositiveAdultScreen, Encounter QualifyingEncounter)? tuple_cgtoaqsajoehgwcararimqzsa) {
            DataType n_ = tuple_cgtoaqsajoehgwcararimqzsa?.LastAdultScreen?.Effective;
            object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
            CqlInterval<CqlDateTime> p_ = QICoreCommon_4_0_000.Instance.toInterval(context, o_);
            CqlDateTime q_ = context.Operators.Start(p_);
            Period r_ = tuple_cgtoaqsajoehgwcararimqzsa?.QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> s_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
            CqlDateTime t_ = context.Operators.Start(s_);
            CqlQuantity u_ = context.Operators.Quantity(14m, "days");
            CqlDateTime v_ = context.Operators.Subtract(t_, u_);
            CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
            CqlDateTime y_ = context.Operators.Start(x_);
            CqlInterval<CqlDateTime> z_ = context.Operators.Interval(v_, y_, true, true);
            bool? aa_ = context.Operators.In<CqlDateTime>(q_, z_, "day");
            CqlInterval<CqlDateTime> ac_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
            CqlDateTime ad_ = context.Operators.Start(ac_);
            bool? ae_ = context.Operators.Not((bool?)(ad_ is null));
            bool? af_ = context.Operators.And(aa_, ae_);
            DataType ag_ = tuple_cgtoaqsajoehgwcararimqzsa?.LastAdultScreen?.Value;
            object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
            CqlCode ai_ = this.Depression_screening_positive__finding_(context);
            CqlConcept aj_ = context.Operators.ConvertCodeToConcept(ai_);
            bool? ak_ = context.Operators.Equivalent(ah_ as CqlConcept, aj_);
            bool? al_ = context.Operators.And(af_, ak_);

            object am_() {

                bool bt_() {
                    object bx_ = context.Operators.LateBoundProperty<object>(tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen, "performed");
                    object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                    bool bz_ = by_ is CqlDateTime;
                    return bz_;
                }


                bool bu_() {
                    object ca_ = context.Operators.LateBoundProperty<object>(tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen, "performed");
                    object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                    bool cc_ = cb_ is CqlInterval<CqlDateTime>;
                    return cc_;
                }


                bool bv_() {
                    object cd_ = context.Operators.LateBoundProperty<object>(tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen, "performed");
                    object ce_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cd_);
                    bool cf_ = ce_ is CqlQuantity;
                    return cf_;
                }


                bool bw_() {
                    object cg_ = context.Operators.LateBoundProperty<object>(tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen, "performed");
                    object ch_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cg_);
                    bool ci_ = ch_ is CqlInterval<CqlQuantity>;
                    return ci_;
                }

                if (bt_())
                {
                    object cj_ = context.Operators.LateBoundProperty<object>(tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen, "performed");
                    object ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
                    return (ck_ as CqlDateTime) as object;
                }
                else if (bu_())
                {
                    object cl_ = context.Operators.LateBoundProperty<object>(tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen, "performed");
                    object cm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cl_);
                    return (cm_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (bv_())
                {
                    object cn_ = context.Operators.LateBoundProperty<object>(tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen, "performed");
                    object co_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cn_);
                    return (co_ as CqlQuantity) as object;
                }
                else if (bw_())
                {
                    object cp_ = context.Operators.LateBoundProperty<object>(tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen, "performed");
                    object cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
                    return (cq_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> an_ = QICoreCommon_4_0_000.Instance.toInterval(context, am_());
            CqlDateTime ao_ = context.Operators.Start(an_);
            CqlInterval<CqlDateTime> aq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
            bool? ar_ = context.Operators.In<CqlDateTime>(ao_, aq_, (string)default);
            object as_ = context.Operators.LateBoundProperty<object>(tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen, "authoredOn");
            CqlDateTime at_ = context.Operators.LateBoundProperty<CqlDateTime>(as_, "value");
            CqlInterval<CqlDateTime> av_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
            CqlDateTime aw_ = context.Operators.End(av_);
            CqlInterval<CqlDateTime> ay_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
            CqlDateTime az_ = context.Operators.End(ay_);
            CqlQuantity ba_ = context.Operators.Quantity(2m, "days");
            CqlDateTime bb_ = context.Operators.Add(az_, ba_);
            CqlInterval<CqlDateTime> bc_ = context.Operators.Interval(aw_, bb_, true, true);
            bool? bd_ = context.Operators.In<CqlDateTime>(at_, bc_, "day");
            CqlInterval<CqlDateTime> bf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
            CqlDateTime bg_ = context.Operators.End(bf_);
            bool? bh_ = context.Operators.Not((bool?)(bg_ is null));
            bool? bi_ = context.Operators.And(bd_, bh_);
            bool? bj_ = context.Operators.Or(ar_, bi_);
            bool? bk_ = context.Operators.And(al_, bj_);

            object bl_() {

                bool cr_() {
                    object cv_ = context.Operators.LateBoundProperty<object>(tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen, "performed");
                    object cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);
                    bool cx_ = cw_ is CqlDateTime;
                    return cx_;
                }


                bool cs_() {
                    object cy_ = context.Operators.LateBoundProperty<object>(tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen, "performed");
                    object cz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cy_);
                    bool da_ = cz_ is CqlInterval<CqlDateTime>;
                    return da_;
                }


                bool ct_() {
                    object db_ = context.Operators.LateBoundProperty<object>(tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen, "performed");
                    object dc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, db_);
                    bool dd_ = dc_ is CqlQuantity;
                    return dd_;
                }


                bool cu_() {
                    object de_ = context.Operators.LateBoundProperty<object>(tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen, "performed");
                    object df_ = FHIRHelpers_4_4_000.Instance.ToValue(context, de_);
                    bool dg_ = df_ is CqlInterval<CqlQuantity>;
                    return dg_;
                }

                if (cr_())
                {
                    object dh_ = context.Operators.LateBoundProperty<object>(tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen, "performed");
                    object di_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dh_);
                    return (di_ as CqlDateTime) as object;
                }
                else if (cs_())
                {
                    object dj_ = context.Operators.LateBoundProperty<object>(tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen, "performed");
                    object dk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dj_);
                    return (dk_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (ct_())
                {
                    object dl_ = context.Operators.LateBoundProperty<object>(tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen, "performed");
                    object dm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dl_);
                    return (dm_ as CqlQuantity) as object;
                }
                else if (cu_())
                {
                    object dn_ = context.Operators.LateBoundProperty<object>(tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen, "performed");
                    object do_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dn_);
                    return (do_ as CqlInterval<CqlQuantity>) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlInterval<CqlDateTime> bm_ = QICoreCommon_4_0_000.Instance.toInterval(context, bl_());
            CqlDateTime bn_ = context.Operators.Start(bm_);
            CqlDateTime bp_ = context.Operators.LateBoundProperty<CqlDateTime>(as_, "value");
            CqlInterval<CqlDateTime> bq_ = this.Measurement_Period(context);
            bool? br_ = context.Operators.In<CqlDateTime>(bn_ ?? bp_, bq_, "day");
            bool? bs_ = context.Operators.And(bk_, br_);
            return bs_;
        }

        IEnumerable<(CqlTupleMetadata, Observation LastAdultScreen, object FollowUpPositiveAdultScreen, Encounter QualifyingEncounter)?> i_ = context.Operators.Where<(CqlTupleMetadata, Observation LastAdultScreen, object FollowUpPositiveAdultScreen, Encounter QualifyingEncounter)?>(g_, h_);

        (CqlTupleMetadata, Observation LastAdultScreen, object FollowUpPositiveAdultScreen, Encounter QualifyingEncounter)? j_((CqlTupleMetadata, Observation LastAdultScreen, object FollowUpPositiveAdultScreen, Encounter QualifyingEncounter)? tuple_cgtoaqsajoehgwcararimqzsa) {
            (CqlTupleMetadata, Observation LastAdultScreen, object FollowUpPositiveAdultScreen, Encounter QualifyingEncounter)? dp_ = (CqlTupleMetadata_ICeCVaggPeLLMJUWQdWMZROe, tuple_cgtoaqsajoehgwcararimqzsa?.LastAdultScreen, tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen, tuple_cgtoaqsajoehgwcararimqzsa?.QualifyingEncounter);
            return dp_;
        }

        IEnumerable<(CqlTupleMetadata, Observation LastAdultScreen, object FollowUpPositiveAdultScreen, Encounter QualifyingEncounter)?> k_ = context.Operators.Select<(CqlTupleMetadata, Observation LastAdultScreen, object FollowUpPositiveAdultScreen, Encounter QualifyingEncounter)?, (CqlTupleMetadata, Observation LastAdultScreen, object FollowUpPositiveAdultScreen, Encounter QualifyingEncounter)?>(i_, j_);
        IEnumerable<(CqlTupleMetadata, Observation LastAdultScreen, object FollowUpPositiveAdultScreen, Encounter QualifyingEncounter)?> l_ = context.Operators.Distinct<(CqlTupleMetadata, Observation LastAdultScreen, object FollowUpPositiveAdultScreen, Encounter QualifyingEncounter)?>(k_);
        return l_;
    }


    [CqlExpressionDefinition("Patient Age 18 Years or Older at Start of Measurement Period")]
    public bool? Patient_Age_18_Years_or_Older_at_Start_of_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient_Age_18_Years_or_Older_at_Start_of_Measurement_Period, Patient_Age_18_Years_or_Older_at_Start_of_Measurement_Period_Compute);

    private const long _cacheIndex_Patient_Age_18_Years_or_Older_at_Start_of_Measurement_Period = 7123036550210893039L;

    private bool? Patient_Age_18_Years_or_Older_at_Start_of_Measurement_Period_Compute(CqlContext context)
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
        return i_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = 8434610617295647640L;

    private bool? Numerator_Compute(CqlContext context)
    {
        bool? a_ = this.Patient_Age_12_to_16_Years_at_Start_of_Measurement_Period(context);
        bool? b_ = this.Has_Most_Recent_Adolescent_Screening_Negative(context);
        IEnumerable<(CqlTupleMetadata, Observation LastAdolescentScreen, object FollowUpPositiveAdolescentScreen, Encounter QualifyingEncounter)?> c_ = this.Most_Recent_Adolescent_Depression_Screening_Positive_and_Follow_Up_Provided(context);
        bool? d_ = context.Operators.Exists<(CqlTupleMetadata, Observation LastAdolescentScreen, object FollowUpPositiveAdolescentScreen, Encounter QualifyingEncounter)?>(c_);
        bool? e_ = context.Operators.Or(b_, d_);
        bool? f_ = context.Operators.And(a_, e_);
        bool? g_ = this.Patient_Age_17_Years_at_Start_of_Measurement_Period(context);
        bool? j_ = context.Operators.Exists<(CqlTupleMetadata, Observation LastAdolescentScreen, object FollowUpPositiveAdolescentScreen, Encounter QualifyingEncounter)?>(c_);
        bool? k_ = context.Operators.Or(b_, j_);
        bool? l_ = this.Has_Most_Recent_Adult_Screening_Negative(context);
        bool? m_ = context.Operators.Or(k_, l_);
        IEnumerable<(CqlTupleMetadata, Observation LastAdultScreen, object FollowUpPositiveAdultScreen, Encounter QualifyingEncounter)?> n_ = this.Most_Recent_Adult_Depression_Screening_Positive_and_Follow_Up_Provided(context);
        bool? o_ = context.Operators.Exists<(CqlTupleMetadata, Observation LastAdultScreen, object FollowUpPositiveAdultScreen, Encounter QualifyingEncounter)?>(n_);
        bool? p_ = context.Operators.Or(m_, o_);
        bool? q_ = context.Operators.And(g_, p_);
        bool? r_ = context.Operators.Or(f_, q_);
        bool? s_ = this.Patient_Age_18_Years_or_Older_at_Start_of_Measurement_Period(context);
        bool? v_ = context.Operators.Exists<(CqlTupleMetadata, Observation LastAdultScreen, object FollowUpPositiveAdultScreen, Encounter QualifyingEncounter)?>(n_);
        bool? w_ = context.Operators.Or(l_, v_);
        bool? x_ = context.Operators.And(s_, w_);
        bool? y_ = context.Operators.Or(r_, x_);
        return y_;
    }


    [CqlExpressionDefinition("Medical or Patient Reason for Not Screening Adolescent for Depression")]
    public IEnumerable<Observation> Medical_or_Patient_Reason_for_Not_Screening_Adolescent_for_Depression(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Medical_or_Patient_Reason_for_Not_Screening_Adolescent_for_Depression, Medical_or_Patient_Reason_for_Not_Screening_Adolescent_for_Depression_Compute);

    private const long _cacheIndex_Medical_or_Patient_Reason_for_Not_Screening_Adolescent_for_Depression = -2936847757700556546L;

    private IEnumerable<Observation> Medical_or_Patient_Reason_for_Not_Screening_Adolescent_for_Depression_Compute(CqlContext context)
    {
        CqlCode a_ = this.Adolescent_depression_screening_assessment(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observationcancelled"));

        bool? d_(Observation NoAdolescentScreen) {
            IEnumerable<Encounter> h_ = this.Qualifying_Encounter_During_Measurement_Period(context);

            bool? i_(Encounter QualifyingEncounter) {
                Instant l_ = NoAdolescentScreen?.IssuedElement;
                DateTimeOffset? m_ = l_?.Value;
                CqlDateTime n_ = context.Operators.Convert<CqlDateTime>(m_);
                Period o_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, o_);
                bool? q_ = context.Operators.In<CqlDateTime>(n_, p_, "day");
                return q_;
            }

            IEnumerable<Encounter> j_ = context.Operators.Where<Encounter>(h_, i_);
            bool? k_ = context.Operators.Exists<Encounter>(j_);
            return k_;
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

        bool? f_(Observation NoAdolescentScreen) {

            bool? r_(Extension @this) {
                FhirUri aj_ = @this?.UrlElement;
                string ak_ = FHIRHelpers_4_4_000.Instance.ToString(context, aj_);
                bool? al_ = context.Operators.Equal(ak_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");
                return al_;
            }

            IEnumerable<Extension> s_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(NoAdolescentScreen is DomainResource
                ? (NoAdolescentScreen as DomainResource).Extension
                : default), r_);

            object t_(Extension @this) {
                DataType am_ = @this?.Value;
                return am_;
            }

            IEnumerable<object> u_ = context.Operators.Select<Extension, object>(s_, t_);
            object v_ = context.Operators.SingletonFrom<object>(u_);
            CqlConcept w_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, v_ as CodeableConcept);
            CqlCode x_ = this.Depression_screening_declined__situation_(context);
            CqlConcept y_ = context.Operators.ConvertCodeToConcept(x_);
            bool? z_ = context.Operators.Equivalent(w_, y_);

            bool? aa_(Extension @this) {
                FhirUri an_ = @this?.UrlElement;
                string ao_ = FHIRHelpers_4_4_000.Instance.ToString(context, an_);
                bool? ap_ = context.Operators.Equal(ao_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");
                return ap_;
            }

            IEnumerable<Extension> ab_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(NoAdolescentScreen is DomainResource
                ? (NoAdolescentScreen as DomainResource).Extension
                : default), aa_);

            object ac_(Extension @this) {
                DataType aq_ = @this?.Value;
                return aq_;
            }

            IEnumerable<object> ad_ = context.Operators.Select<Extension, object>(ab_, ac_);
            object ae_ = context.Operators.SingletonFrom<object>(ad_);
            CqlConcept af_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ae_ as CodeableConcept);
            CqlValueSet ag_ = this.Medical_Reason(context);
            bool? ah_ = context.Operators.ConceptInValueSet(af_, ag_);
            bool? ai_ = context.Operators.Or(z_, ah_);
            return ai_;
        }

        IEnumerable<Observation> g_ = context.Operators.Where<Observation>(e_, f_);
        return g_;
    }


    [CqlExpressionDefinition("Has Adolescent Depression Screening")]
    public bool? Has_Adolescent_Depression_Screening(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Adolescent_Depression_Screening, Has_Adolescent_Depression_Screening_Compute);

    private const long _cacheIndex_Has_Adolescent_Depression_Screening = 6252947328516455428L;

    private bool? Has_Adolescent_Depression_Screening_Compute(CqlContext context)
    {
        CqlCode a_ = this.Adolescent_depression_screening_assessment(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));

        bool? d_(Observation AdolescentScreening) {
            IEnumerable<Encounter> g_ = this.Qualifying_Encounter_During_Measurement_Period(context);

            bool? h_(Encounter QualifyingEncounter) {
                DataType k_ = AdolescentScreening?.Effective;
                object l_ = FHIRHelpers_4_4_000.Instance.ToValue(context, k_);
                CqlInterval<CqlDateTime> m_ = QICoreCommon_4_0_000.Instance.toInterval(context, l_);
                CqlDateTime n_ = context.Operators.End(m_);
                Period o_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, o_);
                CqlDateTime q_ = context.Operators.Start(p_);
                CqlQuantity r_ = context.Operators.Quantity(14m, "days");
                CqlDateTime s_ = context.Operators.Subtract(q_, r_);
                CqlInterval<CqlDateTime> u_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, o_);
                CqlDateTime v_ = context.Operators.Start(u_);
                CqlInterval<CqlDateTime> w_ = context.Operators.Interval(s_, v_, true, true);
                bool? x_ = context.Operators.In<CqlDateTime>(n_, w_, "day");
                CqlInterval<CqlDateTime> z_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, o_);
                CqlDateTime aa_ = context.Operators.Start(z_);
                bool? ab_ = context.Operators.Not((bool?)(aa_ is null));
                bool? ac_ = context.Operators.And(x_, ab_);
                DataType ad_ = AdolescentScreening?.Value;
                object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                bool? af_ = context.Operators.Not((bool?)(ae_ is null));
                bool? ag_ = context.Operators.And(ac_, af_);
                Code<ObservationStatus> ah_ = AdolescentScreening?.StatusElement;
                ObservationStatus? ai_ = ah_?.Value;
                string aj_ = context.Operators.Convert<string>(ai_);
                string[] ak_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? al_ = context.Operators.In<string>(aj_, (IEnumerable<string>)ak_);
                bool? am_ = context.Operators.And(ag_, al_);
                return am_;
            }

            IEnumerable<Encounter> i_ = context.Operators.Where<Encounter>(g_, h_);
            bool? j_ = context.Operators.Exists<Encounter>(i_);
            return j_;
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
        bool? f_ = context.Operators.Exists<Observation>(e_);
        return f_;
    }


    [CqlExpressionDefinition("Medical or Patient Reason for Not Screening Adult for Depression")]
    public IEnumerable<Observation> Medical_or_Patient_Reason_for_Not_Screening_Adult_for_Depression(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Medical_or_Patient_Reason_for_Not_Screening_Adult_for_Depression, Medical_or_Patient_Reason_for_Not_Screening_Adult_for_Depression_Compute);

    private const long _cacheIndex_Medical_or_Patient_Reason_for_Not_Screening_Adult_for_Depression = -6580700843671872767L;

    private IEnumerable<Observation> Medical_or_Patient_Reason_for_Not_Screening_Adult_for_Depression_Compute(CqlContext context)
    {
        CqlCode a_ = this.Adult_depression_screening_assessment(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observationcancelled"));

        bool? d_(Observation NoAdultScreen) {
            IEnumerable<Encounter> h_ = this.Qualifying_Encounter_During_Measurement_Period(context);

            bool? i_(Encounter QualifyingEncounter) {
                Instant l_ = NoAdultScreen?.IssuedElement;
                DateTimeOffset? m_ = l_?.Value;
                CqlDateTime n_ = context.Operators.Convert<CqlDateTime>(m_);
                Period o_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, o_);
                bool? q_ = context.Operators.In<CqlDateTime>(n_, p_, "day");
                return q_;
            }

            IEnumerable<Encounter> j_ = context.Operators.Where<Encounter>(h_, i_);
            bool? k_ = context.Operators.Exists<Encounter>(j_);
            return k_;
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

        bool? f_(Observation NoAdultScreen) {

            bool? r_(Extension @this) {
                FhirUri aj_ = @this?.UrlElement;
                string ak_ = FHIRHelpers_4_4_000.Instance.ToString(context, aj_);
                bool? al_ = context.Operators.Equal(ak_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");
                return al_;
            }

            IEnumerable<Extension> s_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(NoAdultScreen is DomainResource
                ? (NoAdultScreen as DomainResource).Extension
                : default), r_);

            object t_(Extension @this) {
                DataType am_ = @this?.Value;
                return am_;
            }

            IEnumerable<object> u_ = context.Operators.Select<Extension, object>(s_, t_);
            object v_ = context.Operators.SingletonFrom<object>(u_);
            CqlConcept w_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, v_ as CodeableConcept);
            CqlCode x_ = this.Depression_screening_declined__situation_(context);
            CqlConcept y_ = context.Operators.ConvertCodeToConcept(x_);
            bool? z_ = context.Operators.Equivalent(w_, y_);

            bool? aa_(Extension @this) {
                FhirUri an_ = @this?.UrlElement;
                string ao_ = FHIRHelpers_4_4_000.Instance.ToString(context, an_);
                bool? ap_ = context.Operators.Equal(ao_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");
                return ap_;
            }

            IEnumerable<Extension> ab_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(NoAdultScreen is DomainResource
                ? (NoAdultScreen as DomainResource).Extension
                : default), aa_);

            object ac_(Extension @this) {
                DataType aq_ = @this?.Value;
                return aq_;
            }

            IEnumerable<object> ad_ = context.Operators.Select<Extension, object>(ab_, ac_);
            object ae_ = context.Operators.SingletonFrom<object>(ad_);
            CqlConcept af_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ae_ as CodeableConcept);
            CqlValueSet ag_ = this.Medical_Reason(context);
            bool? ah_ = context.Operators.ConceptInValueSet(af_, ag_);
            bool? ai_ = context.Operators.Or(z_, ah_);
            return ai_;
        }

        IEnumerable<Observation> g_ = context.Operators.Where<Observation>(e_, f_);
        return g_;
    }


    [CqlExpressionDefinition("Has Adult Depression Screening")]
    public bool? Has_Adult_Depression_Screening(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Adult_Depression_Screening, Has_Adult_Depression_Screening_Compute);

    private const long _cacheIndex_Has_Adult_Depression_Screening = 4182860248521833426L;

    private bool? Has_Adult_Depression_Screening_Compute(CqlContext context)
    {
        CqlCode a_ = this.Adult_depression_screening_assessment(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));

        bool? d_(Observation AdultScreening) {
            IEnumerable<Encounter> g_ = this.Qualifying_Encounter_During_Measurement_Period(context);

            bool? h_(Encounter QualifyingEncounter) {
                DataType k_ = AdultScreening?.Effective;
                object l_ = FHIRHelpers_4_4_000.Instance.ToValue(context, k_);
                CqlInterval<CqlDateTime> m_ = QICoreCommon_4_0_000.Instance.toInterval(context, l_);
                CqlDateTime n_ = context.Operators.End(m_);
                Period o_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, o_);
                CqlDateTime q_ = context.Operators.Start(p_);
                CqlQuantity r_ = context.Operators.Quantity(14m, "days");
                CqlDateTime s_ = context.Operators.Subtract(q_, r_);
                CqlInterval<CqlDateTime> u_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, o_);
                CqlDateTime v_ = context.Operators.Start(u_);
                CqlInterval<CqlDateTime> w_ = context.Operators.Interval(s_, v_, true, true);
                bool? x_ = context.Operators.In<CqlDateTime>(n_, w_, "day");
                CqlInterval<CqlDateTime> z_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, o_);
                CqlDateTime aa_ = context.Operators.Start(z_);
                bool? ab_ = context.Operators.Not((bool?)(aa_ is null));
                bool? ac_ = context.Operators.And(x_, ab_);
                DataType ad_ = AdultScreening?.Value;
                object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                bool? af_ = context.Operators.Not((bool?)(ae_ is null));
                bool? ag_ = context.Operators.And(ac_, af_);
                Code<ObservationStatus> ah_ = AdultScreening?.StatusElement;
                ObservationStatus? ai_ = ah_?.Value;
                string aj_ = context.Operators.Convert<string>(ai_);
                string[] ak_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? al_ = context.Operators.In<string>(aj_, (IEnumerable<string>)ak_);
                bool? am_ = context.Operators.And(ag_, al_);
                return am_;
            }

            IEnumerable<Encounter> i_ = context.Operators.Where<Encounter>(g_, h_);
            bool? j_ = context.Operators.Exists<Encounter>(i_);
            return j_;
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
        bool? f_ = context.Operators.Exists<Observation>(e_);
        return f_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public bool? Denominator_Exceptions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exceptions, Denominator_Exceptions_Compute);

    private const long _cacheIndex_Denominator_Exceptions = 5259574378864861192L;

    private bool? Denominator_Exceptions_Compute(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Medical_or_Patient_Reason_for_Not_Screening_Adolescent_for_Depression(context);
        bool? b_ = context.Operators.Exists<Observation>(a_);
        bool? c_ = this.Has_Adolescent_Depression_Screening(context);
        bool? d_ = context.Operators.Not(c_);
        bool? e_ = context.Operators.And(b_, d_);
        IEnumerable<Observation> f_ = this.Medical_or_Patient_Reason_for_Not_Screening_Adult_for_Depression(context);
        bool? g_ = context.Operators.Exists<Observation>(f_);
        bool? h_ = this.Has_Adult_Depression_Screening(context);
        bool? i_ = context.Operators.Not(h_);
        bool? j_ = context.Operators.And(g_, i_);
        bool? k_ = context.Operators.Or(e_, j_);
        return k_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = -4996802696824837470L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = 8307048373131935046L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = -7267954952347399329L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = -1037285051859248970L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private CMS2FHIRPCSDepScreenAndFollowUp_1_0_000() {}

    public static CMS2FHIRPCSDepScreenAndFollowUp_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS2FHIRPCSDepScreenAndFollowUp";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, QICoreCommon_4_0_000.Instance, CumulativeMedicationDuration_6_0_000.Instance, SupplementalDataElements_5_1_000.Instance];

    #endregion ILibrary Implementation

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_ICeCVaggPeLLMJUWQdWMZROe = new(
       [typeof(Observation), typeof(object), typeof(Encounter)],
       ["LastAdultScreen", "FollowUpPositiveAdultScreen", "QualifyingEncounter"]);

    private static CqlTupleMetadata CqlTupleMetadata_ZRHehPJEDEeRJPiLbCPjUggS = new(
       [typeof(Observation), typeof(object), typeof(Encounter)],
       ["LastAdolescentScreen", "FollowUpPositiveAdolescentScreen", "QualifyingEncounter"]);

    #endregion CqlTupleMetadata Properties

}
