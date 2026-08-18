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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.8.0")]
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
        CqlBoolean i_ = context.Operators.GreaterOrEqual(h_, 12);
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
            CqlBoolean n_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(k_, m_, "day");
            Code<Encounter.EncounterStatus> o_ = QualifyingEncounter?.StatusElement;
            Encounter.EncounterStatus? p_ = o_?.Value;
            Code<Encounter.EncounterStatus> q_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(p_);
            CqlBoolean r_ = context.Operators.Equal(q_, "finished");
            CqlBoolean s_ = r_;
            return n_
                /* CQL 'and' (212:5-213:49) */ && s_;
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
        CqlBoolean a_ = this.Patient_Age_12_Years_or_Older_at_Start_of_Measurement_Period(context);
        IEnumerable<Encounter> b_ = this.Qualifying_Encounter_During_Measurement_Period(context);
        CqlBoolean c_ = context.Operators.Exists<Encounter>(b_);
        CqlBoolean d_ = c_;
        return a_
            /* CQL 'and' (37:3-38:67) */ && d_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = -3614056152365125233L;

    private bool? Denominator_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.Initial_Population(context);
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
                CqlInterval<CqlDateTime> h_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, BipolarDiagnosis as Condition);
                CqlDateTime i_ = context.Operators.Start(h_);
                Period j_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> k_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, j_);
                CqlDateTime l_ = context.Operators.Start(k_);
                CqlBoolean m_ = context.Operators.Before(i_, l_, "day");
                return m_;
            }

            CqlBoolean g_ = context.Operators.WhereAny<Encounter>(e_, f_);
            return g_;
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
        CqlBoolean b_ = context.Operators.Exists<Condition>(a_);
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
        CqlBoolean j_ = context.Operators.In<int?>(h_, i_, (string)default);
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
                DataType l_ = AdolescentDepressionScreening?.Effective;
                object m_ = FHIRHelpers_4_4_000.Instance.ToValue(context, l_);
                CqlInterval<CqlDateTime> n_ = QICoreCommon_4_0_000.Instance.toInterval(context, m_);
                CqlDateTime o_ = context.Operators.End(n_);
                Period p_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> q_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, p_);
                CqlDateTime r_ = context.Operators.Start(q_);
                CqlQuantity s_ = context.Operators.Quantity(14m, "days");
                CqlDateTime t_ = context.Operators.Subtract(r_, s_);
                CqlInterval<CqlDateTime> u_ = context.Operators.Interval(t_, r_, true, true);
                CqlBoolean v_ = context.Operators.In<CqlDateTime>(o_, u_, "day");
                CqlBoolean w_ = (CqlBoolean)(r_ is not null);
                DataType x_ = AdolescentDepressionScreening?.Value;
                object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                CqlBoolean z_ = (CqlBoolean)(y_ is not null);
                Code<ObservationStatus> aa_ = AdolescentDepressionScreening?.StatusElement;
                ObservationStatus? ab_ = aa_?.Value;
                string ac_ = context.Operators.Convert<string>(ab_);
                string[] ad_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                CqlBoolean ae_ = context.Operators.In<string>(ac_, (IEnumerable<string>)ad_);
                CqlBoolean af_ = ae_;
                return v_
                    /* CQL 'and' (157:19-157:142) */ && w_
                    /* CQL 'and' (157:19-158:61) */ && z_
                    /* CQL 'and' (157:19-159:89) */ && af_;
            }

            CqlBoolean k_ = context.Operators.WhereAny<Encounter>(i_, j_);
            return k_;
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

        object f_(Observation @this) {
            DataType ag_ = @this?.Effective;
            object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
            CqlInterval<CqlDateTime> ai_ = QICoreCommon_4_0_000.Instance.toInterval(context, ah_);
            CqlDateTime aj_ = context.Operators.Start(ai_);
            return aj_;
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
            DataType f_ = AdolescentScreen?.Value;
            object g_ = FHIRHelpers_4_4_000.Instance.ToValue(context, f_);
            CqlCode h_ = this.Depression_screening_negative__finding_(context);
            CqlConcept i_ = context.Operators.ConvertCodeToConcept(h_);
            CqlBoolean j_ = context.Operators.Equivalent(g_ as CqlConcept, i_);
            return j_;
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>((IEnumerable<Observation>)b_, c_);
        Observation e_ = context.Operators.SingletonFrom<Observation>(d_);
        return e_ is not null;
    }


    [CqlExpressionDefinition("Follow Up Intervention for Positive Adolescent Depression Screening")]
    public IEnumerable<object> Follow_Up_Intervention_for_Positive_Adolescent_Depression_Screening(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Follow_Up_Intervention_for_Positive_Adolescent_Depression_Screening, Follow_Up_Intervention_for_Positive_Adolescent_Depression_Screening_Compute);

    private const long _cacheIndex_Follow_Up_Intervention_for_Positive_Adolescent_Depression_Screening = -2454462295688409122L;

    private IEnumerable<object> Follow_Up_Intervention_for_Positive_Adolescent_Depression_Screening_Compute(CqlContext context)
    {
        IEnumerable<MedicationRequest> a_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? b_(MedicationRequest MR) {
            IEnumerable<Medication> s_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? t_(Medication M) {
                object v_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object w_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> x_ = context.Operators.Split((string)w_, "/");
                string y_ = context.Operators.Last<string>(x_);
                CqlBoolean z_ = context.Operators.Equal(v_, y_);
                CodeableConcept aa_ = M?.Code;
                CqlConcept ab_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, aa_);
                CqlValueSet ac_ = this.Adolescent_Depression_Medications(context);
                CqlBoolean ad_ = context.Operators.ConceptInValueSet(ab_, ac_);
                CqlBoolean ae_ = ad_;
                return z_
                    /* CQL 'and' */ && ae_;
            }

            CqlBoolean u_ = context.Operators.WhereAny<Medication>(s_, t_);
            return u_;
        }

        IEnumerable<MedicationRequest> c_ = context.Operators.Where<MedicationRequest>(a_, b_);
        CqlValueSet d_ = this.Adolescent_Depression_Medications(context);
        IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(c_, e_);

        bool? g_(MedicationRequest AdolescentMed) {
            IEnumerable<Encounter> af_ = this.Qualifying_Encounter_During_Measurement_Period(context);

            bool? ag_(Encounter QualifyingEncounter) {
                Observation ai_ = this.Most_Recent_Adolescent_Depression_Screening(context);
                DataType aj_ = ai_?.Effective;
                object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                CqlInterval<CqlDateTime> al_ = QICoreCommon_4_0_000.Instance.toInterval(context, ak_);
                CqlDateTime am_ = context.Operators.Start(al_);
                Period an_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> ao_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, an_);
                CqlDateTime ap_ = context.Operators.Start(ao_);
                CqlQuantity aq_ = context.Operators.Quantity(14m, "days");
                CqlDateTime ar_ = context.Operators.Subtract(ap_, aq_);
                CqlInterval<CqlDateTime> as_ = context.Operators.Interval(ar_, ap_, true, true);
                CqlBoolean at_ = context.Operators.In<CqlDateTime>(am_, as_, "day");
                CqlBoolean au_ = (CqlBoolean)(ap_ is not null);
                CqlInterval<CqlDate> av_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, AdolescentMed);
                CqlDate aw_ = (av_ as CqlInterval<CqlDate>)?.low;
                CqlDateTime ax_ = context.Operators.ConvertDateToDateTime(aw_);
                CqlDate ay_ = (av_ as CqlInterval<CqlDate>)?.high;
                CqlDateTime az_ = context.Operators.ConvertDateToDateTime(ay_);
                CqlBoolean ba_ = (av_ as CqlInterval<CqlDate>)?.lowClosed;
                CqlBoolean bb_ = (av_ as CqlInterval<CqlDate>)?.highClosed;
                CqlInterval<CqlDateTime> bc_ = context.Operators.Interval(ax_, az_, ba_, bb_);
                CqlInterval<CqlDateTime> bd_ = QICoreCommon_4_0_000.Instance.toInterval(context, bc_);
                CqlBoolean be_ = context.Operators.OverlapsAfter(bd_, ao_, "day");
                CqlBoolean bf_ = be_;
                DataType bg_ = ai_?.Value;
                object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                CqlCode bi_ = this.Depression_screening_positive__finding_(context);
                CqlConcept bj_ = context.Operators.ConvertCodeToConcept(bi_);
                CqlBoolean bk_ = context.Operators.Equivalent(bh_ as CqlConcept, bj_);
                CqlBoolean bl_ = bk_;
                Code<MedicationRequest.MedicationrequestStatus> bm_ = AdolescentMed?.StatusElement;
                MedicationRequest.MedicationrequestStatus? bn_ = bm_?.Value;
                string bo_ = context.Operators.Convert<string>(bn_);
                string[] bp_ = [
                    "active",
                    "completed",
                ];
                CqlBoolean bq_ = context.Operators.In<string>(bo_, (IEnumerable<string>)bp_);
                CqlBoolean br_ = bq_;
                Code<MedicationRequest.MedicationRequestIntent> bs_ = AdolescentMed?.IntentElement;
                MedicationRequest.MedicationRequestIntent? bt_ = bs_?.Value;
                string bu_ = context.Operators.Convert<string>(bt_);
                string[] bv_ = [
                    "order",
                    "original-order",
                    "reflex-order",
                    "filler-order",
                    "instance-order",
                ];
                CqlBoolean bw_ = context.Operators.In<string>(bu_, (IEnumerable<string>)bv_);
                CqlBoolean bx_ = bw_;
                return at_
                    /* CQL 'and' (76:21-76:169) */ && au_
                    /* CQL 'and' (76:21-77:121) */ && bf_
                    /* CQL 'and' (76:21-78:111) */ && bl_
                    /* CQL 'and' (76:21-79:65) */ && br_
                    /* CQL 'and' (76:21-80:119) */ && bx_;
            }

            CqlBoolean ah_ = context.Operators.WhereAny<Encounter>(af_, ag_);
            return ah_;
        }

        IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);
        CqlValueSet i_ = this.Referral_for_Adolescent_Depression(context);
        IEnumerable<ServiceRequest> j_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));

        bool? k_(ServiceRequest AdolescentReferral) {
            Code<RequestStatus> by_ = AdolescentReferral?.StatusElement;
            RequestStatus? bz_ = by_?.Value;
            Code<RequestStatus> ca_ = context.Operators.Convert<Code<RequestStatus>>(bz_);
            string cb_ = context.Operators.Convert<string>(ca_);
            string[] cc_ = [
                "active",
                "completed",
            ];
            CqlBoolean cd_ = context.Operators.In<string>(cb_, (IEnumerable<string>)cc_);
            return cd_;
        }

        IEnumerable<ServiceRequest> l_ = context.Operators.Where<ServiceRequest>(j_, k_);
        IEnumerable<object> m_ = context.Operators.Union<object>(h_ as IEnumerable<object>, l_ as IEnumerable<object>);
        CqlValueSet n_ = this.Follow_Up_for_Adolescent_Depression(context);
        IEnumerable<Procedure> o_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

        bool? p_(Procedure AdolescentFollowUp) {
            Code<EventStatus> ce_ = AdolescentFollowUp?.StatusElement;
            EventStatus? cf_ = ce_?.Value;
            string cg_ = context.Operators.Convert<string>(cf_);
            CqlBoolean ch_ = context.Operators.Equal(cg_, "completed");
            return ch_;
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
            (CqlTupleMetadata, Observation LastAdolescentScreen, object FollowUpPositiveAdolescentScreen, Encounter QualifyingEncounter)? k_ = (CqlTupleMetadata_ZRHehPJEDEeRJPiLbCPjUggS, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return k_;
        }


        bool? g_((CqlTupleMetadata, Observation LastAdolescentScreen, object FollowUpPositiveAdolescentScreen, Encounter QualifyingEncounter)? tuple_ewmohjtdtinujhphqjvbwmmhh) {
            DataType l_ = tuple_ewmohjtdtinujhphqjvbwmmhh?.LastAdolescentScreen?.Effective;
            object m_ = FHIRHelpers_4_4_000.Instance.ToValue(context, l_);
            CqlInterval<CqlDateTime> n_ = QICoreCommon_4_0_000.Instance.toInterval(context, m_);
            CqlDateTime o_ = context.Operators.Start(n_);
            Period p_ = tuple_ewmohjtdtinujhphqjvbwmmhh?.QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> q_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, p_);
            CqlDateTime r_ = context.Operators.Start(q_);
            CqlQuantity s_ = context.Operators.Quantity(14m, "days");
            CqlDateTime t_ = context.Operators.Subtract(r_, s_);
            CqlInterval<CqlDateTime> u_ = context.Operators.Interval(t_, r_, true, true);
            CqlBoolean v_ = context.Operators.In<CqlDateTime>(o_, u_, "day");
            CqlBoolean w_ = (CqlBoolean)(r_ is not null);
            DataType x_ = tuple_ewmohjtdtinujhphqjvbwmmhh?.LastAdolescentScreen?.Value;
            object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
            CqlCode z_ = this.Depression_screening_positive__finding_(context);
            CqlConcept aa_ = context.Operators.ConvertCodeToConcept(z_);
            CqlBoolean ab_ = context.Operators.Equivalent(y_ as CqlConcept, aa_);
            CqlBoolean ac_ = ab_;
            object ad_;
            object ax_ = context.Operators.LateBoundProperty<object>(tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen, "performed");
            object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
            bool az_ = ay_ is CqlDateTime;
            if (az_)
            {
                ad_ = ay_ as CqlDateTime;
            }
            else
            {
                bool ba_ = ay_ is CqlQuantity;
                if (ba_)
                {
                    ad_ = ay_ as CqlQuantity;
                }
                else
                {
                    bool bb_ = ay_ is CqlInterval<CqlDateTime>;
                    if (bb_)
                    {
                        ad_ = ay_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool bc_ = ay_ is CqlInterval<CqlQuantity>;
                        if (bc_)
                        {
                            ad_ = ay_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            ad_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> ae_ = QICoreCommon_4_0_000.Instance.toInterval(context, ad_);
            CqlDateTime af_ = context.Operators.Start(ae_);
            CqlBoolean ag_ = context.Operators.In<CqlDateTime>(af_, q_, (string)default);
            object ah_ = context.Operators.LateBoundProperty<object>(tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen, "authoredOn");
            CqlDateTime ai_ = context.Operators.LateBoundProperty<CqlDateTime>(ah_, "value");
            CqlDateTime aj_ = context.Operators.End(q_);
            CqlQuantity ak_ = context.Operators.Quantity(2m, "days");
            CqlDateTime al_ = context.Operators.Add(aj_, ak_);
            CqlInterval<CqlDateTime> am_ = context.Operators.Interval(aj_, al_, true, true);
            CqlBoolean an_ = context.Operators.In<CqlDateTime>(ai_, am_, "day");
            CqlBoolean ao_ = (CqlBoolean)(aj_ is not null);
            CqlBoolean ap_ = an_
                /* CQL 'and' (171:14-171:124) */ && ao_;
            CqlBoolean aq_ = ag_
                /* CQL 'or' (170:11-172:7) */ || ap_;
            object ar_;
            object bd_ = context.Operators.LateBoundProperty<object>(tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen, "performed");
            object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
            bool bf_ = be_ is CqlDateTime;
            if (bf_)
            {
                ar_ = be_ as CqlDateTime;
            }
            else
            {
                bool bg_ = be_ is CqlQuantity;
                if (bg_)
                {
                    ar_ = be_ as CqlQuantity;
                }
                else
                {
                    bool bh_ = be_ is CqlInterval<CqlDateTime>;
                    if (bh_)
                    {
                        ar_ = be_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool bi_ = be_ is CqlInterval<CqlQuantity>;
                        if (bi_)
                        {
                            ar_ = be_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            ar_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> as_ = QICoreCommon_4_0_000.Instance.toInterval(context, ar_);
            CqlDateTime at_ = context.Operators.Start(as_);
            CqlInterval<CqlDateTime> au_ = this.Measurement_Period(context);
            CqlBoolean av_ = context.Operators.In<CqlDateTime>(at_ ?? ai_, au_, "day");
            CqlBoolean aw_ = av_;
            return v_
                /* CQL 'and' (168:11-168:134) */ && w_
                /* CQL 'and' (168:11-169:80) */ && ac_
                /* CQL 'and' (168:11-172:7) */ && aq_
                /* CQL 'and' (168:5-173:168) */ && aw_;
        }

        IEnumerable<(CqlTupleMetadata, Observation LastAdolescentScreen, object FollowUpPositiveAdolescentScreen, Encounter QualifyingEncounter)?> h_ = context.Operators.SelectWhere<ValueTuple<Observation, object, Encounter>, (CqlTupleMetadata, Observation LastAdolescentScreen, object FollowUpPositiveAdolescentScreen, Encounter QualifyingEncounter)?>(e_, f_, g_);

        (CqlTupleMetadata, Observation LastAdolescentScreen, object FollowUpPositiveAdolescentScreen, Encounter QualifyingEncounter)? i_((CqlTupleMetadata, Observation LastAdolescentScreen, object FollowUpPositiveAdolescentScreen, Encounter QualifyingEncounter)? tuple_ewmohjtdtinujhphqjvbwmmhh) {
            (CqlTupleMetadata, Observation LastAdolescentScreen, object FollowUpPositiveAdolescentScreen, Encounter QualifyingEncounter)? bj_ = (CqlTupleMetadata_ZRHehPJEDEeRJPiLbCPjUggS, tuple_ewmohjtdtinujhphqjvbwmmhh?.LastAdolescentScreen, tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen, tuple_ewmohjtdtinujhphqjvbwmmhh?.QualifyingEncounter);
            return bj_;
        }

        IEnumerable<(CqlTupleMetadata, Observation LastAdolescentScreen, object FollowUpPositiveAdolescentScreen, Encounter QualifyingEncounter)?> j_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Observation LastAdolescentScreen, object FollowUpPositiveAdolescentScreen, Encounter QualifyingEncounter)?, (CqlTupleMetadata, Observation LastAdolescentScreen, object FollowUpPositiveAdolescentScreen, Encounter QualifyingEncounter)?>(h_, i_);
        return j_;
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
        CqlBoolean i_ = context.Operators.Equal(h_, 17);
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
                DataType l_ = AdultDepressionScreening?.Effective;
                object m_ = FHIRHelpers_4_4_000.Instance.ToValue(context, l_);
                CqlInterval<CqlDateTime> n_ = QICoreCommon_4_0_000.Instance.toInterval(context, m_);
                CqlDateTime o_ = context.Operators.End(n_);
                Period p_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> q_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, p_);
                CqlDateTime r_ = context.Operators.Start(q_);
                CqlQuantity s_ = context.Operators.Quantity(14m, "days");
                CqlDateTime t_ = context.Operators.Subtract(r_, s_);
                CqlInterval<CqlDateTime> u_ = context.Operators.Interval(t_, r_, true, true);
                CqlBoolean v_ = context.Operators.In<CqlDateTime>(o_, u_, "day");
                CqlBoolean w_ = (CqlBoolean)(r_ is not null);
                DataType x_ = AdultDepressionScreening?.Value;
                object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                CqlBoolean z_ = (CqlBoolean)(y_ is not null);
                Code<ObservationStatus> aa_ = AdultDepressionScreening?.StatusElement;
                ObservationStatus? ab_ = aa_?.Value;
                string ac_ = context.Operators.Convert<string>(ab_);
                string[] ad_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                CqlBoolean ae_ = context.Operators.In<string>(ac_, (IEnumerable<string>)ad_);
                CqlBoolean af_ = ae_;
                return v_
                    /* CQL 'and' (178:19-178:137) */ && w_
                    /* CQL 'and' (178:19-179:56) */ && z_
                    /* CQL 'and' (178:19-180:84) */ && af_;
            }

            CqlBoolean k_ = context.Operators.WhereAny<Encounter>(i_, j_);
            return k_;
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

        object f_(Observation @this) {
            DataType ag_ = @this?.Effective;
            object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
            CqlInterval<CqlDateTime> ai_ = QICoreCommon_4_0_000.Instance.toInterval(context, ah_);
            CqlDateTime aj_ = context.Operators.Start(ai_);
            return aj_;
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
            DataType f_ = AdultScreen?.Value;
            object g_ = FHIRHelpers_4_4_000.Instance.ToValue(context, f_);
            CqlCode h_ = this.Depression_screening_negative__finding_(context);
            CqlConcept i_ = context.Operators.ConvertCodeToConcept(h_);
            CqlBoolean j_ = context.Operators.Equivalent(g_ as CqlConcept, i_);
            return j_;
        }

        IEnumerable<Observation> d_ = context.Operators.Where<Observation>((IEnumerable<Observation>)b_, c_);
        Observation e_ = context.Operators.SingletonFrom<Observation>(d_);
        return e_ is not null;
    }


    [CqlExpressionDefinition("Follow Up Intervention for Positive Adult Depression Screening")]
    public IEnumerable<object> Follow_Up_Intervention_for_Positive_Adult_Depression_Screening(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Follow_Up_Intervention_for_Positive_Adult_Depression_Screening, Follow_Up_Intervention_for_Positive_Adult_Depression_Screening_Compute);

    private const long _cacheIndex_Follow_Up_Intervention_for_Positive_Adult_Depression_Screening = 8801585706686387465L;

    private IEnumerable<object> Follow_Up_Intervention_for_Positive_Adult_Depression_Screening_Compute(CqlContext context)
    {
        IEnumerable<MedicationRequest> a_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? b_(MedicationRequest MR) {
            IEnumerable<Medication> s_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? t_(Medication M) {
                object v_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object w_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> x_ = context.Operators.Split((string)w_, "/");
                string y_ = context.Operators.Last<string>(x_);
                CqlBoolean z_ = context.Operators.Equal(v_, y_);
                CodeableConcept aa_ = M?.Code;
                CqlConcept ab_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, aa_);
                CqlValueSet ac_ = this.Adult_Depression_Medications(context);
                CqlBoolean ad_ = context.Operators.ConceptInValueSet(ab_, ac_);
                CqlBoolean ae_ = ad_;
                return z_
                    /* CQL 'and' */ && ae_;
            }

            CqlBoolean u_ = context.Operators.WhereAny<Medication>(s_, t_);
            return u_;
        }

        IEnumerable<MedicationRequest> c_ = context.Operators.Where<MedicationRequest>(a_, b_);
        CqlValueSet d_ = this.Adult_Depression_Medications(context);
        IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(c_, e_);

        bool? g_(MedicationRequest AdultMed) {
            IEnumerable<Encounter> af_ = this.Qualifying_Encounter_During_Measurement_Period(context);

            bool? ag_(Encounter QualifyingEncounter) {
                Observation ai_ = this.Most_Recent_Adult_Depression_Screening(context);
                DataType aj_ = ai_?.Effective;
                object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                CqlInterval<CqlDateTime> al_ = QICoreCommon_4_0_000.Instance.toInterval(context, ak_);
                CqlDateTime am_ = context.Operators.Start(al_);
                Period an_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> ao_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, an_);
                CqlDateTime ap_ = context.Operators.Start(ao_);
                CqlQuantity aq_ = context.Operators.Quantity(14m, "days");
                CqlDateTime ar_ = context.Operators.Subtract(ap_, aq_);
                CqlInterval<CqlDateTime> as_ = context.Operators.Interval(ar_, ap_, true, true);
                CqlBoolean at_ = context.Operators.In<CqlDateTime>(am_, as_, "day");
                CqlBoolean au_ = (CqlBoolean)(ap_ is not null);
                CqlInterval<CqlDate> av_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, AdultMed);
                CqlDate aw_ = (av_ as CqlInterval<CqlDate>)?.low;
                CqlDateTime ax_ = context.Operators.ConvertDateToDateTime(aw_);
                CqlDate ay_ = (av_ as CqlInterval<CqlDate>)?.high;
                CqlDateTime az_ = context.Operators.ConvertDateToDateTime(ay_);
                CqlBoolean ba_ = (av_ as CqlInterval<CqlDate>)?.lowClosed;
                CqlBoolean bb_ = (av_ as CqlInterval<CqlDate>)?.highClosed;
                CqlInterval<CqlDateTime> bc_ = context.Operators.Interval(ax_, az_, ba_, bb_);
                CqlInterval<CqlDateTime> bd_ = QICoreCommon_4_0_000.Instance.toInterval(context, bc_);
                CqlBoolean be_ = context.Operators.OverlapsAfter(bd_, ao_, "day");
                CqlBoolean bf_ = be_;
                DataType bg_ = ai_?.Value;
                object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                CqlCode bi_ = this.Depression_screening_positive__finding_(context);
                CqlConcept bj_ = context.Operators.ConvertCodeToConcept(bi_);
                CqlBoolean bk_ = context.Operators.Equivalent(bh_ as CqlConcept, bj_);
                CqlBoolean bl_ = bk_;
                Code<MedicationRequest.MedicationrequestStatus> bm_ = AdultMed?.StatusElement;
                MedicationRequest.MedicationrequestStatus? bn_ = bm_?.Value;
                string bo_ = context.Operators.Convert<string>(bn_);
                string[] bp_ = [
                    "active",
                    "completed",
                ];
                CqlBoolean bq_ = context.Operators.In<string>(bo_, (IEnumerable<string>)bp_);
                CqlBoolean br_ = bq_;
                Code<MedicationRequest.MedicationRequestIntent> bs_ = AdultMed?.IntentElement;
                MedicationRequest.MedicationRequestIntent? bt_ = bs_?.Value;
                string bu_ = context.Operators.Convert<string>(bt_);
                string[] bv_ = [
                    "order",
                    "original-order",
                    "reflex-order",
                    "filler-order",
                    "instance-order",
                ];
                CqlBoolean bw_ = context.Operators.In<string>(bu_, (IEnumerable<string>)bv_);
                CqlBoolean bx_ = bw_;
                return at_
                    /* CQL 'and' (93:21-93:164) */ && au_
                    /* CQL 'and' (93:21-94:116) */ && bf_
                    /* CQL 'and' (93:21-95:106) */ && bl_
                    /* CQL 'and' (93:21-96:60) */ && br_
                    /* CQL 'and' (93:21-97:114) */ && bx_;
            }

            CqlBoolean ah_ = context.Operators.WhereAny<Encounter>(af_, ag_);
            return ah_;
        }

        IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);
        CqlValueSet i_ = this.Referral_for_Adult_Depression(context);
        IEnumerable<ServiceRequest> j_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));

        bool? k_(ServiceRequest AdultReferral) {
            Code<RequestStatus> by_ = AdultReferral?.StatusElement;
            RequestStatus? bz_ = by_?.Value;
            Code<RequestStatus> ca_ = context.Operators.Convert<Code<RequestStatus>>(bz_);
            string cb_ = context.Operators.Convert<string>(ca_);
            string[] cc_ = [
                "active",
                "completed",
            ];
            CqlBoolean cd_ = context.Operators.In<string>(cb_, (IEnumerable<string>)cc_);
            return cd_;
        }

        IEnumerable<ServiceRequest> l_ = context.Operators.Where<ServiceRequest>(j_, k_);
        IEnumerable<object> m_ = context.Operators.Union<object>(h_ as IEnumerable<object>, l_ as IEnumerable<object>);
        CqlValueSet n_ = this.Follow_Up_for_Adult_Depression(context);
        IEnumerable<Procedure> o_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

        bool? p_(Procedure AdultFollowUp) {
            Code<EventStatus> ce_ = AdultFollowUp?.StatusElement;
            EventStatus? cf_ = ce_?.Value;
            string cg_ = context.Operators.Convert<string>(cf_);
            CqlBoolean ch_ = context.Operators.Equal(cg_, "completed");
            return ch_;
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
            (CqlTupleMetadata, Observation LastAdultScreen, object FollowUpPositiveAdultScreen, Encounter QualifyingEncounter)? k_ = (CqlTupleMetadata_ICeCVaggPeLLMJUWQdWMZROe, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return k_;
        }


        bool? g_((CqlTupleMetadata, Observation LastAdultScreen, object FollowUpPositiveAdultScreen, Encounter QualifyingEncounter)? tuple_cgtoaqsajoehgwcararimqzsa) {
            DataType l_ = tuple_cgtoaqsajoehgwcararimqzsa?.LastAdultScreen?.Effective;
            object m_ = FHIRHelpers_4_4_000.Instance.ToValue(context, l_);
            CqlInterval<CqlDateTime> n_ = QICoreCommon_4_0_000.Instance.toInterval(context, m_);
            CqlDateTime o_ = context.Operators.Start(n_);
            Period p_ = tuple_cgtoaqsajoehgwcararimqzsa?.QualifyingEncounter?.Period;
            CqlInterval<CqlDateTime> q_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, p_);
            CqlDateTime r_ = context.Operators.Start(q_);
            CqlQuantity s_ = context.Operators.Quantity(14m, "days");
            CqlDateTime t_ = context.Operators.Subtract(r_, s_);
            CqlInterval<CqlDateTime> u_ = context.Operators.Interval(t_, r_, true, true);
            CqlBoolean v_ = context.Operators.In<CqlDateTime>(o_, u_, "day");
            CqlBoolean w_ = (CqlBoolean)(r_ is not null);
            DataType x_ = tuple_cgtoaqsajoehgwcararimqzsa?.LastAdultScreen?.Value;
            object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
            CqlCode z_ = this.Depression_screening_positive__finding_(context);
            CqlConcept aa_ = context.Operators.ConvertCodeToConcept(z_);
            CqlBoolean ab_ = context.Operators.Equivalent(y_ as CqlConcept, aa_);
            CqlBoolean ac_ = ab_;
            object ad_;
            object ax_ = context.Operators.LateBoundProperty<object>(tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen, "performed");
            object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
            bool az_ = ay_ is CqlDateTime;
            if (az_)
            {
                ad_ = ay_ as CqlDateTime;
            }
            else
            {
                bool ba_ = ay_ is CqlQuantity;
                if (ba_)
                {
                    ad_ = ay_ as CqlQuantity;
                }
                else
                {
                    bool bb_ = ay_ is CqlInterval<CqlDateTime>;
                    if (bb_)
                    {
                        ad_ = ay_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool bc_ = ay_ is CqlInterval<CqlQuantity>;
                        if (bc_)
                        {
                            ad_ = ay_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            ad_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> ae_ = QICoreCommon_4_0_000.Instance.toInterval(context, ad_);
            CqlDateTime af_ = context.Operators.Start(ae_);
            CqlBoolean ag_ = context.Operators.In<CqlDateTime>(af_, q_, (string)default);
            object ah_ = context.Operators.LateBoundProperty<object>(tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen, "authoredOn");
            CqlDateTime ai_ = context.Operators.LateBoundProperty<CqlDateTime>(ah_, "value");
            CqlDateTime aj_ = context.Operators.End(q_);
            CqlQuantity ak_ = context.Operators.Quantity(2m, "days");
            CqlDateTime al_ = context.Operators.Add(aj_, ak_);
            CqlInterval<CqlDateTime> am_ = context.Operators.Interval(aj_, al_, true, true);
            CqlBoolean an_ = context.Operators.In<CqlDateTime>(ai_, am_, "day");
            CqlBoolean ao_ = (CqlBoolean)(aj_ is not null);
            CqlBoolean ap_ = an_
                /* CQL 'and' (192:14-192:119) */ && ao_;
            CqlBoolean aq_ = ag_
                /* CQL 'or' (191:11-193:7) */ || ap_;
            object ar_;
            object bd_ = context.Operators.LateBoundProperty<object>(tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen, "performed");
            object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
            bool bf_ = be_ is CqlDateTime;
            if (bf_)
            {
                ar_ = be_ as CqlDateTime;
            }
            else
            {
                bool bg_ = be_ is CqlQuantity;
                if (bg_)
                {
                    ar_ = be_ as CqlQuantity;
                }
                else
                {
                    bool bh_ = be_ is CqlInterval<CqlDateTime>;
                    if (bh_)
                    {
                        ar_ = be_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        bool bi_ = be_ is CqlInterval<CqlQuantity>;
                        if (bi_)
                        {
                            ar_ = be_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            ar_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> as_ = QICoreCommon_4_0_000.Instance.toInterval(context, ar_);
            CqlDateTime at_ = context.Operators.Start(as_);
            CqlInterval<CqlDateTime> au_ = this.Measurement_Period(context);
            CqlBoolean av_ = context.Operators.In<CqlDateTime>(at_ ?? ai_, au_, "day");
            CqlBoolean aw_ = av_;
            return v_
                /* CQL 'and' (189:11-189:129) */ && w_
                /* CQL 'and' (189:11-190:75) */ && ac_
                /* CQL 'and' (189:11-193:7) */ && aq_
                /* CQL 'and' (189:5-194:158) */ && aw_;
        }

        IEnumerable<(CqlTupleMetadata, Observation LastAdultScreen, object FollowUpPositiveAdultScreen, Encounter QualifyingEncounter)?> h_ = context.Operators.SelectWhere<ValueTuple<Observation, object, Encounter>, (CqlTupleMetadata, Observation LastAdultScreen, object FollowUpPositiveAdultScreen, Encounter QualifyingEncounter)?>(e_, f_, g_);

        (CqlTupleMetadata, Observation LastAdultScreen, object FollowUpPositiveAdultScreen, Encounter QualifyingEncounter)? i_((CqlTupleMetadata, Observation LastAdultScreen, object FollowUpPositiveAdultScreen, Encounter QualifyingEncounter)? tuple_cgtoaqsajoehgwcararimqzsa) {
            (CqlTupleMetadata, Observation LastAdultScreen, object FollowUpPositiveAdultScreen, Encounter QualifyingEncounter)? bj_ = (CqlTupleMetadata_ICeCVaggPeLLMJUWQdWMZROe, tuple_cgtoaqsajoehgwcararimqzsa?.LastAdultScreen, tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen, tuple_cgtoaqsajoehgwcararimqzsa?.QualifyingEncounter);
            return bj_;
        }

        IEnumerable<(CqlTupleMetadata, Observation LastAdultScreen, object FollowUpPositiveAdultScreen, Encounter QualifyingEncounter)?> j_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Observation LastAdultScreen, object FollowUpPositiveAdultScreen, Encounter QualifyingEncounter)?, (CqlTupleMetadata, Observation LastAdultScreen, object FollowUpPositiveAdultScreen, Encounter QualifyingEncounter)?>(h_, i_);
        return j_;
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
        CqlBoolean i_ = context.Operators.GreaterOrEqual(h_, 18);
        return i_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = 8434610617295647640L;

    private bool? Numerator_Compute(CqlContext context)
    {
        CqlBoolean a_ = this.Patient_Age_12_to_16_Years_at_Start_of_Measurement_Period(context);
        CqlBoolean b_ = this.Has_Most_Recent_Adolescent_Screening_Negative(context);
        IEnumerable<(CqlTupleMetadata, Observation LastAdolescentScreen, object FollowUpPositiveAdolescentScreen, Encounter QualifyingEncounter)?> c_ = this.Most_Recent_Adolescent_Depression_Screening_Positive_and_Follow_Up_Provided(context);
        CqlBoolean d_ = context.Operators.Exists<(CqlTupleMetadata, Observation LastAdolescentScreen, object FollowUpPositiveAdolescentScreen, Encounter QualifyingEncounter)?>(c_);
        CqlBoolean e_ = d_;
        CqlBoolean f_ = b_
            /* CQL 'or' (48:11-50:7) */ || e_;
        CqlBoolean g_ = this.Patient_Age_17_Years_at_Start_of_Measurement_Period(context);
        IEnumerable<(CqlTupleMetadata, Observation LastAdultScreen, object FollowUpPositiveAdultScreen, Encounter QualifyingEncounter)?> h_ = this.Most_Recent_Adult_Depression_Screening_Positive_and_Follow_Up_Provided(context);
        CqlBoolean i_ = context.Operators.Exists<(CqlTupleMetadata, Observation LastAdultScreen, object FollowUpPositiveAdultScreen, Encounter QualifyingEncounter)?>(h_);
        CqlBoolean j_ = i_;
        CqlBoolean k_ = b_
            /* CQL 'or' (53:15-54:99) */ || e_
            /* CQL 'or' (53:15-55:57) */ || this.Has_Most_Recent_Adult_Screening_Negative(context)
            /* CQL 'or' (53:13-57:9) */ || j_;
        CqlBoolean l_ = g_
            /* CQL 'and' (52:8-58:5) */ && k_;
        CqlBoolean m_ = this.Patient_Age_18_Years_or_Older_at_Start_of_Measurement_Period(context);
        CqlBoolean n_ = this.Has_Most_Recent_Adult_Screening_Negative(context);
        CqlBoolean o_ = n_
            /* CQL 'or' (60:13-62:9) */ || j_;
        CqlBoolean p_ = m_
            /* CQL 'and' (59:8-63:5) */ && o_;
        return (a_
            /* CQL 'and' (47:3-51:3) */ && f_)
            /* CQL 'or' (47:3-58:5) */ || l_
            /* CQL 'or' (47:3-63:5) */ || p_;
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
                Instant k_ = NoAdolescentScreen?.IssuedElement;
                DateTimeOffset? l_ = k_?.Value;
                CqlDateTime m_ = context.Operators.Convert<CqlDateTime>(l_);
                Period n_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                CqlBoolean p_ = context.Operators.In<CqlDateTime>(m_, o_, "day");
                return p_;
            }

            CqlBoolean j_ = context.Operators.WhereAny<Encounter>(h_, i_);
            return j_;
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

        bool? f_(Observation NoAdolescentScreen) {

            bool? q_(Extension @this) {
                FhirUri ag_ = @this?.UrlElement;
                string ah_ = FHIRHelpers_4_4_000.Instance.ToString(context, ag_);
                CqlBoolean ai_ = context.Operators.Equal(ah_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");
                return ai_;
            }


            object r_(Extension @this) {
                DataType aj_ = @this?.Value;
                return aj_;
            }

            IEnumerable<object> s_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)(NoAdolescentScreen is DomainResource
                ? (NoAdolescentScreen as DomainResource).Extension
                : default), q_, r_);
            object t_ = context.Operators.SingletonFrom<object>(s_);
            CqlConcept u_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, t_ as CodeableConcept);
            CqlCode v_ = this.Depression_screening_declined__situation_(context);
            CqlConcept w_ = context.Operators.ConvertCodeToConcept(v_);
            CqlBoolean x_ = context.Operators.Equivalent(u_, w_);

            bool? y_(Extension @this) {
                FhirUri ak_ = @this?.UrlElement;
                string al_ = FHIRHelpers_4_4_000.Instance.ToString(context, ak_);
                CqlBoolean am_ = context.Operators.Equal(al_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");
                return am_;
            }


            object z_(Extension @this) {
                DataType an_ = @this?.Value;
                return an_;
            }

            IEnumerable<object> aa_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)(NoAdolescentScreen is DomainResource
                ? (NoAdolescentScreen as DomainResource).Extension
                : default), y_, z_);
            object ab_ = context.Operators.SingletonFrom<object>(aa_);
            CqlConcept ac_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ab_ as CodeableConcept);
            CqlValueSet ad_ = this.Medical_Reason(context);
            CqlBoolean ae_ = context.Operators.ConceptInValueSet(ac_, ad_);
            CqlBoolean af_ = ae_;
            return x_
                /* CQL 'or' (142:5-144:5) */ || af_;
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
            IEnumerable<Encounter> f_ = this.Qualifying_Encounter_During_Measurement_Period(context);

            bool? g_(Encounter QualifyingEncounter) {
                DataType i_ = AdolescentScreening?.Effective;
                object j_ = FHIRHelpers_4_4_000.Instance.ToValue(context, i_);
                CqlInterval<CqlDateTime> k_ = QICoreCommon_4_0_000.Instance.toInterval(context, j_);
                CqlDateTime l_ = context.Operators.End(k_);
                Period m_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, m_);
                CqlDateTime o_ = context.Operators.Start(n_);
                CqlQuantity p_ = context.Operators.Quantity(14m, "days");
                CqlDateTime q_ = context.Operators.Subtract(o_, p_);
                CqlInterval<CqlDateTime> r_ = context.Operators.Interval(q_, o_, true, true);
                CqlBoolean s_ = context.Operators.In<CqlDateTime>(l_, r_, "day");
                CqlBoolean t_ = (CqlBoolean)(o_ is not null);
                DataType u_ = AdolescentScreening?.Value;
                object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                CqlBoolean w_ = (CqlBoolean)(v_ is not null);
                Code<ObservationStatus> x_ = AdolescentScreening?.StatusElement;
                ObservationStatus? y_ = x_?.Value;
                string z_ = context.Operators.Convert<string>(y_);
                string[] aa_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                CqlBoolean ab_ = context.Operators.In<string>(z_, (IEnumerable<string>)aa_);
                CqlBoolean ac_ = ab_;
                return s_
                    /* CQL 'and' (110:19-110:134) */ && t_
                    /* CQL 'and' (110:19-111:51) */ && w_
                    /* CQL 'and' (110:19-112:79) */ && ac_;
            }

            CqlBoolean h_ = context.Operators.WhereAny<Encounter>(f_, g_);
            return h_;
        }

        CqlBoolean e_ = context.Operators.WhereAny<Observation>(c_, d_);
        return e_;
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
                Instant k_ = NoAdultScreen?.IssuedElement;
                DateTimeOffset? l_ = k_?.Value;
                CqlDateTime m_ = context.Operators.Convert<CqlDateTime>(l_);
                Period n_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                CqlBoolean p_ = context.Operators.In<CqlDateTime>(m_, o_, "day");
                return p_;
            }

            CqlBoolean j_ = context.Operators.WhereAny<Encounter>(h_, i_);
            return j_;
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

        bool? f_(Observation NoAdultScreen) {

            bool? q_(Extension @this) {
                FhirUri ag_ = @this?.UrlElement;
                string ah_ = FHIRHelpers_4_4_000.Instance.ToString(context, ag_);
                CqlBoolean ai_ = context.Operators.Equal(ah_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");
                return ai_;
            }


            object r_(Extension @this) {
                DataType aj_ = @this?.Value;
                return aj_;
            }

            IEnumerable<object> s_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)(NoAdultScreen is DomainResource
                ? (NoAdultScreen as DomainResource).Extension
                : default), q_, r_);
            object t_ = context.Operators.SingletonFrom<object>(s_);
            CqlConcept u_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, t_ as CodeableConcept);
            CqlCode v_ = this.Depression_screening_declined__situation_(context);
            CqlConcept w_ = context.Operators.ConvertCodeToConcept(v_);
            CqlBoolean x_ = context.Operators.Equivalent(u_, w_);

            bool? y_(Extension @this) {
                FhirUri ak_ = @this?.UrlElement;
                string al_ = FHIRHelpers_4_4_000.Instance.ToString(context, ak_);
                CqlBoolean am_ = context.Operators.Equal(al_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");
                return am_;
            }


            object z_(Extension @this) {
                DataType an_ = @this?.Value;
                return an_;
            }

            IEnumerable<object> aa_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)(NoAdultScreen is DomainResource
                ? (NoAdultScreen as DomainResource).Extension
                : default), y_, z_);
            object ab_ = context.Operators.SingletonFrom<object>(aa_);
            CqlConcept ac_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ab_ as CodeableConcept);
            CqlValueSet ad_ = this.Medical_Reason(context);
            CqlBoolean ae_ = context.Operators.ConceptInValueSet(ac_, ad_);
            CqlBoolean af_ = ae_;
            return x_
                /* CQL 'or' (150:5-152:5) */ || af_;
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
            IEnumerable<Encounter> f_ = this.Qualifying_Encounter_During_Measurement_Period(context);

            bool? g_(Encounter QualifyingEncounter) {
                DataType i_ = AdultScreening?.Effective;
                object j_ = FHIRHelpers_4_4_000.Instance.ToValue(context, i_);
                CqlInterval<CqlDateTime> k_ = QICoreCommon_4_0_000.Instance.toInterval(context, j_);
                CqlDateTime l_ = context.Operators.End(k_);
                Period m_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, m_);
                CqlDateTime o_ = context.Operators.Start(n_);
                CqlQuantity p_ = context.Operators.Quantity(14m, "days");
                CqlDateTime q_ = context.Operators.Subtract(o_, p_);
                CqlInterval<CqlDateTime> r_ = context.Operators.Interval(q_, o_, true, true);
                CqlBoolean s_ = context.Operators.In<CqlDateTime>(l_, r_, "day");
                CqlBoolean t_ = (CqlBoolean)(o_ is not null);
                DataType u_ = AdultScreening?.Value;
                object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                CqlBoolean w_ = (CqlBoolean)(v_ is not null);
                Code<ObservationStatus> x_ = AdultScreening?.StatusElement;
                ObservationStatus? y_ = x_?.Value;
                string z_ = context.Operators.Convert<string>(y_);
                string[] aa_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                CqlBoolean ab_ = context.Operators.In<string>(z_, (IEnumerable<string>)aa_);
                CqlBoolean ac_ = ab_;
                return s_
                    /* CQL 'and' (118:19-118:129) */ && t_
                    /* CQL 'and' (118:19-119:46) */ && w_
                    /* CQL 'and' (118:19-120:74) */ && ac_;
            }

            CqlBoolean h_ = context.Operators.WhereAny<Encounter>(f_, g_);
            return h_;
        }

        CqlBoolean e_ = context.Operators.WhereAny<Observation>(c_, d_);
        return e_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public bool? Denominator_Exceptions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exceptions, Denominator_Exceptions_Compute);

    private const long _cacheIndex_Denominator_Exceptions = 5259574378864861192L;

    private bool? Denominator_Exceptions_Compute(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Medical_or_Patient_Reason_for_Not_Screening_Adolescent_for_Depression(context);
        CqlBoolean b_ = context.Operators.Exists<Observation>(a_);
        IEnumerable<Observation> c_ = this.Medical_or_Patient_Reason_for_Not_Screening_Adult_for_Depression(context);
        CqlBoolean d_ = context.Operators.Exists<Observation>(c_);
        CqlBoolean e_ = d_
            /* CQL 'and' (69:8-71:5) */ && !(this.Has_Adult_Depression_Screening(context));
        return (b_
            /* CQL 'and' (66:3-68:3) */ && !(this.Has_Adolescent_Depression_Screening(context)))
            /* CQL 'or' (66:3-71:5) */ || e_;
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
