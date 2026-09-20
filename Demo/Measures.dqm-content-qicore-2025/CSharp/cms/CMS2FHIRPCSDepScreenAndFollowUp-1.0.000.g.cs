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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.2.4.0")]
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
                CqlInterval<CqlDateTime> h_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, BipolarDiagnosis as Condition);
                CqlDateTime i_ = context.Operators.Start(h_);
                Period j_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> k_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, j_);
                CqlDateTime l_ = context.Operators.Start(k_);
                bool? m_ = context.Operators.Before(i_, l_, "day");
                return m_;
            }

            bool? g_ = context.Operators.WhereAny<Encounter>(e_, f_);
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
                bool? v_ = context.Operators.In<CqlDateTime>(o_, u_, "day");
                bool? w_ = context.Operators.Not((bool?)(r_ is null));
                bool? x_ = context.Operators.And(v_, w_);
                DataType y_ = AdolescentDepressionScreening?.Value;
                object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                bool? aa_ = context.Operators.Not((bool?)(z_ is null));
                bool? ab_ = context.Operators.And(x_, aa_);
                Code<ObservationStatus> ac_ = AdolescentDepressionScreening?.StatusElement;
                ObservationStatus? ad_ = ac_?.Value;
                string ae_ = context.Operators.Convert<string>(ad_);
                string[] af_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ag_ = context.Operators.In<string>(ae_, (IEnumerable<string>)af_);
                bool? ah_ = context.Operators.And(ab_, ag_);
                return ah_;
            }

            bool? k_ = context.Operators.WhereAny<Encounter>(i_, j_);
            return k_;
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

        object f_(Observation @this) {
            DataType ai_ = @this?.Effective;
            object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
            CqlInterval<CqlDateTime> ak_ = QICoreCommon_4_0_000.Instance.toInterval(context, aj_);
            CqlDateTime al_ = context.Operators.Start(ak_);
            return al_;
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
        IEnumerable<MedicationRequest> a_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? b_(MedicationRequest MR) {
            IEnumerable<Medication> s_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? t_(Medication M) {
                Id v_ = M?.IdElement;
                string w_ = v_?.Value;
                FhirString x_;
                DataType ah_ = MR?.Medication;
                bool ai_ = ah_ is ResourceReference;
                if (ai_)
                {
                    FhirString aj_ = (ah_ as ResourceReference)?.ReferenceElement;
                    x_ = aj_;
                }
                else
                {
                    x_ = default;
                }
                string y_ = x_?.Value;
                IEnumerable<string> z_ = context.Operators.Split(y_, "/");
                string aa_ = context.Operators.Last<string>(z_);
                bool? ab_ = context.Operators.Equal(w_, aa_);
                CodeableConcept ac_ = M?.Code;
                CqlConcept ad_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ac_);
                CqlValueSet ae_ = this.Adolescent_Depression_Medications(context);
                bool? af_ = context.Operators.ConceptInValueSet(ad_, ae_);
                bool? ag_ = context.Operators.And(ab_, af_);
                return ag_;
            }

            bool? u_ = context.Operators.WhereAny<Medication>(s_, t_);
            return u_;
        }

        IEnumerable<MedicationRequest> c_ = context.Operators.Where<MedicationRequest>(a_, b_);
        CqlValueSet d_ = this.Adolescent_Depression_Medications(context);
        IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(c_, e_);

        bool? g_(MedicationRequest AdolescentMed) {
            IEnumerable<Encounter> ak_ = this.Qualifying_Encounter_During_Measurement_Period(context);

            bool? al_(Encounter QualifyingEncounter) {
                Observation an_ = this.Most_Recent_Adolescent_Depression_Screening(context);
                DataType ao_ = an_?.Effective;
                object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                CqlInterval<CqlDateTime> aq_ = QICoreCommon_4_0_000.Instance.toInterval(context, ap_);
                CqlDateTime ar_ = context.Operators.Start(aq_);
                Period as_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> at_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, as_);
                CqlDateTime au_ = context.Operators.Start(at_);
                CqlQuantity av_ = context.Operators.Quantity(14m, "days");
                CqlDateTime aw_ = context.Operators.Subtract(au_, av_);
                CqlInterval<CqlDateTime> ax_ = context.Operators.Interval(aw_, au_, true, true);
                bool? ay_ = context.Operators.In<CqlDateTime>(ar_, ax_, "day");
                bool? az_ = context.Operators.Not((bool?)(au_ is null));
                bool? ba_ = context.Operators.And(ay_, az_);
                CqlInterval<CqlDate> bb_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, AdolescentMed);
                CqlDate bc_ = (bb_ as CqlInterval<CqlDate>)?.low;
                CqlDateTime bd_ = context.Operators.ConvertDateToDateTime(bc_);
                CqlDate be_ = (bb_ as CqlInterval<CqlDate>)?.high;
                CqlDateTime bf_ = context.Operators.ConvertDateToDateTime(be_);
                bool? bg_ = (bb_ as CqlInterval<CqlDate>)?.lowClosed;
                bool? bh_ = (bb_ as CqlInterval<CqlDate>)?.highClosed;
                CqlInterval<CqlDateTime> bi_ = context.Operators.Interval(bd_, bf_, bg_, bh_);
                CqlInterval<CqlDateTime> bj_ = QICoreCommon_4_0_000.Instance.toInterval(context, bi_);
                bool? bk_ = context.Operators.OverlapsAfter(bj_, at_, "day");
                bool? bl_ = context.Operators.And(ba_, bk_);
                DataType bm_ = an_?.Value;
                object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                CqlCode bo_ = this.Depression_screening_positive__finding_(context);
                CqlConcept bp_ = context.Operators.ConvertCodeToConcept(bo_);
                bool? bq_ = context.Operators.Equivalent(bn_ as CqlConcept, bp_);
                bool? br_ = context.Operators.And(bl_, bq_);
                Code<MedicationRequest.MedicationrequestStatus> bs_ = AdolescentMed?.StatusElement;
                MedicationRequest.MedicationrequestStatus? bt_ = bs_?.Value;
                string bu_ = context.Operators.Convert<string>(bt_);
                string[] bv_ = [
                    "active",
                    "completed",
                ];
                bool? bw_ = context.Operators.In<string>(bu_, (IEnumerable<string>)bv_);
                bool? bx_ = context.Operators.And(br_, bw_);
                Code<MedicationRequest.MedicationRequestIntent> by_ = AdolescentMed?.IntentElement;
                MedicationRequest.MedicationRequestIntent? bz_ = by_?.Value;
                string ca_ = context.Operators.Convert<string>(bz_);
                string[] cb_ = [
                    "order",
                    "original-order",
                    "reflex-order",
                    "filler-order",
                    "instance-order",
                ];
                bool? cc_ = context.Operators.In<string>(ca_, (IEnumerable<string>)cb_);
                bool? cd_ = context.Operators.And(bx_, cc_);
                return cd_;
            }

            bool? am_ = context.Operators.WhereAny<Encounter>(ak_, al_);
            return am_;
        }

        IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);
        CqlValueSet i_ = this.Referral_for_Adolescent_Depression(context);
        IEnumerable<ServiceRequest> j_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));

        bool? k_(ServiceRequest AdolescentReferral) {
            Code<RequestStatus> ce_ = AdolescentReferral?.StatusElement;
            RequestStatus? cf_ = ce_?.Value;
            Code<RequestStatus> cg_ = context.Operators.Convert<Code<RequestStatus>>(cf_);
            string ch_ = context.Operators.Convert<string>(cg_);
            string[] ci_ = [
                "active",
                "completed",
            ];
            bool? cj_ = context.Operators.In<string>(ch_, (IEnumerable<string>)ci_);
            return cj_;
        }

        IEnumerable<ServiceRequest> l_ = context.Operators.Where<ServiceRequest>(j_, k_);
        IEnumerable<object> m_ = context.Operators.Union<object>(h_ as IEnumerable<object>, l_ as IEnumerable<object>);
        CqlValueSet n_ = this.Follow_Up_for_Adolescent_Depression(context);
        IEnumerable<Procedure> o_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

        bool? p_(Procedure AdolescentFollowUp) {
            Code<EventStatus> ck_ = AdolescentFollowUp?.StatusElement;
            EventStatus? cl_ = ck_?.Value;
            string cm_ = context.Operators.Convert<string>(cl_);
            bool? cn_ = context.Operators.Equal(cm_, "completed");
            return cn_;
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
            bool? v_ = context.Operators.In<CqlDateTime>(o_, u_, "day");
            bool? w_ = context.Operators.Not((bool?)(r_ is null));
            bool? x_ = context.Operators.And(v_, w_);
            DataType y_ = tuple_ewmohjtdtinujhphqjvbwmmhh?.LastAdolescentScreen?.Value;
            object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
            CqlCode aa_ = this.Depression_screening_positive__finding_(context);
            CqlConcept ab_ = context.Operators.ConvertCodeToConcept(aa_);
            bool? ac_ = context.Operators.Equivalent(z_ as CqlConcept, ab_);
            bool? ad_ = context.Operators.And(x_, ac_);
            object ae_;
            object bb_;
            if (tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen is Procedure)
            {
                DataType be_ = (tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen as Procedure)?.Performed;
                bb_ = be_;
            }
            else
            {
                bb_ = null;
            }
            object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
            bool bd_ = bc_ is CqlDateTime;
            if (bd_)
            {
                object bf_;
                if (tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen is Procedure)
                {
                    DataType bh_ = (tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen as Procedure)?.Performed;
                    bf_ = bh_;
                }
                else
                {
                    bf_ = null;
                }
                object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                ae_ = bg_ as CqlDateTime;
            }
            else
            {
                object bi_;
                if (tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen is Procedure)
                {
                    DataType bl_ = (tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen as Procedure)?.Performed;
                    bi_ = bl_;
                }
                else
                {
                    bi_ = null;
                }
                object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                bool bk_ = bj_ is CqlQuantity;
                if (bk_)
                {
                    object bm_;
                    if (tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen is Procedure)
                    {
                        DataType bo_ = (tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen as Procedure)?.Performed;
                        bm_ = bo_;
                    }
                    else
                    {
                        bm_ = null;
                    }
                    object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                    ae_ = bn_ as CqlQuantity;
                }
                else
                {
                    object bp_;
                    if (tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen is Procedure)
                    {
                        DataType bs_ = (tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen as Procedure)?.Performed;
                        bp_ = bs_;
                    }
                    else
                    {
                        bp_ = null;
                    }
                    object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                    bool br_ = bq_ is CqlInterval<CqlDateTime>;
                    if (br_)
                    {
                        object bt_;
                        if (tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen is Procedure)
                        {
                            DataType bv_ = (tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen as Procedure)?.Performed;
                            bt_ = bv_;
                        }
                        else
                        {
                            bt_ = null;
                        }
                        object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                        ae_ = bu_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        object bw_;
                        if (tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen is Procedure)
                        {
                            DataType bz_ = (tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen as Procedure)?.Performed;
                            bw_ = bz_;
                        }
                        else
                        {
                            bw_ = null;
                        }
                        object bx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bw_);
                        bool by_ = bx_ is CqlInterval<CqlQuantity>;
                        if (by_)
                        {
                            object ca_;
                            if (tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen is Procedure)
                            {
                                DataType cc_ = (tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen as Procedure)?.Performed;
                                ca_ = cc_;
                            }
                            else
                            {
                                ca_ = null;
                            }
                            object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                            ae_ = cb_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            ae_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> af_ = QICoreCommon_4_0_000.Instance.toInterval(context, ae_);
            CqlDateTime ag_ = context.Operators.Start(af_);
            bool? ah_ = context.Operators.In<CqlDateTime>(ag_, q_, (string)default);
            FhirDateTime ai_;
            if (tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen is MedicationRequest)
            {
                FhirDateTime cd_ = (tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen as MedicationRequest)?.AuthoredOnElement;
                ai_ = cd_;
            }
            else if (tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen is ServiceRequest)
            {
                FhirDateTime ce_ = (tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen as ServiceRequest)?.AuthoredOnElement;
                ai_ = ce_;
            }
            else
            {
                ai_ = default;
            }
            CqlDateTime aj_ = context.Operators.Convert<CqlDateTime>(ai_);
            CqlDateTime ak_ = context.Operators.End(q_);
            CqlQuantity al_ = context.Operators.Quantity(2m, "days");
            CqlDateTime am_ = context.Operators.Add(ak_, al_);
            CqlInterval<CqlDateTime> an_ = context.Operators.Interval(ak_, am_, true, true);
            bool? ao_ = context.Operators.In<CqlDateTime>(aj_, an_, "day");
            bool? ap_ = context.Operators.Not((bool?)(ak_ is null));
            bool? aq_ = context.Operators.And(ao_, ap_);
            bool? ar_ = context.Operators.Or(ah_, aq_);
            bool? as_ = context.Operators.And(ad_, ar_);
            object at_;
            object cf_;
            if (tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen is Procedure)
            {
                DataType ci_ = (tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen as Procedure)?.Performed;
                cf_ = ci_;
            }
            else
            {
                cf_ = null;
            }
            object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
            bool ch_ = cg_ is CqlDateTime;
            if (ch_)
            {
                object cj_;
                if (tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen is Procedure)
                {
                    DataType cl_ = (tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen as Procedure)?.Performed;
                    cj_ = cl_;
                }
                else
                {
                    cj_ = null;
                }
                object ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
                at_ = ck_ as CqlDateTime;
            }
            else
            {
                object cm_;
                if (tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen is Procedure)
                {
                    DataType cp_ = (tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen as Procedure)?.Performed;
                    cm_ = cp_;
                }
                else
                {
                    cm_ = null;
                }
                object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                bool co_ = cn_ is CqlQuantity;
                if (co_)
                {
                    object cq_;
                    if (tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen is Procedure)
                    {
                        DataType cs_ = (tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen as Procedure)?.Performed;
                        cq_ = cs_;
                    }
                    else
                    {
                        cq_ = null;
                    }
                    object cr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cq_);
                    at_ = cr_ as CqlQuantity;
                }
                else
                {
                    object ct_;
                    if (tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen is Procedure)
                    {
                        DataType cw_ = (tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen as Procedure)?.Performed;
                        ct_ = cw_;
                    }
                    else
                    {
                        ct_ = null;
                    }
                    object cu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ct_);
                    bool cv_ = cu_ is CqlInterval<CqlDateTime>;
                    if (cv_)
                    {
                        object cx_;
                        if (tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen is Procedure)
                        {
                            DataType cz_ = (tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen as Procedure)?.Performed;
                            cx_ = cz_;
                        }
                        else
                        {
                            cx_ = null;
                        }
                        object cy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                        at_ = cy_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        object da_;
                        if (tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen is Procedure)
                        {
                            DataType dd_ = (tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen as Procedure)?.Performed;
                            da_ = dd_;
                        }
                        else
                        {
                            da_ = null;
                        }
                        object db_ = FHIRHelpers_4_4_000.Instance.ToValue(context, da_);
                        bool dc_ = db_ is CqlInterval<CqlQuantity>;
                        if (dc_)
                        {
                            object de_;
                            if (tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen is Procedure)
                            {
                                DataType dg_ = (tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen as Procedure)?.Performed;
                                de_ = dg_;
                            }
                            else
                            {
                                de_ = null;
                            }
                            object df_ = FHIRHelpers_4_4_000.Instance.ToValue(context, de_);
                            at_ = df_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            at_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> au_ = QICoreCommon_4_0_000.Instance.toInterval(context, at_);
            CqlDateTime av_ = context.Operators.Start(au_);
            FhirDateTime aw_;
            if (tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen is MedicationRequest)
            {
                FhirDateTime dh_ = (tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen as MedicationRequest)?.AuthoredOnElement;
                aw_ = dh_;
            }
            else if (tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen is ServiceRequest)
            {
                FhirDateTime di_ = (tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen as ServiceRequest)?.AuthoredOnElement;
                aw_ = di_;
            }
            else
            {
                aw_ = default;
            }
            CqlDateTime ax_ = context.Operators.Convert<CqlDateTime>(aw_);
            CqlInterval<CqlDateTime> ay_ = this.Measurement_Period(context);
            bool? az_ = context.Operators.In<CqlDateTime>(av_ ?? ax_, ay_, "day");
            bool? ba_ = context.Operators.And(as_, az_);
            return ba_;
        }

        IEnumerable<(CqlTupleMetadata, Observation LastAdolescentScreen, object FollowUpPositiveAdolescentScreen, Encounter QualifyingEncounter)?> h_ = context.Operators.SelectWhere<ValueTuple<Observation, object, Encounter>, (CqlTupleMetadata, Observation LastAdolescentScreen, object FollowUpPositiveAdolescentScreen, Encounter QualifyingEncounter)?>(e_, f_, g_);

        (CqlTupleMetadata, Observation LastAdolescentScreen, object FollowUpPositiveAdolescentScreen, Encounter QualifyingEncounter)? i_((CqlTupleMetadata, Observation LastAdolescentScreen, object FollowUpPositiveAdolescentScreen, Encounter QualifyingEncounter)? tuple_ewmohjtdtinujhphqjvbwmmhh) {
            (CqlTupleMetadata, Observation LastAdolescentScreen, object FollowUpPositiveAdolescentScreen, Encounter QualifyingEncounter)? dj_ = (CqlTupleMetadata_ZRHehPJEDEeRJPiLbCPjUggS, tuple_ewmohjtdtinujhphqjvbwmmhh?.LastAdolescentScreen, tuple_ewmohjtdtinujhphqjvbwmmhh?.FollowUpPositiveAdolescentScreen, tuple_ewmohjtdtinujhphqjvbwmmhh?.QualifyingEncounter);
            return dj_;
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
                bool? v_ = context.Operators.In<CqlDateTime>(o_, u_, "day");
                bool? w_ = context.Operators.Not((bool?)(r_ is null));
                bool? x_ = context.Operators.And(v_, w_);
                DataType y_ = AdultDepressionScreening?.Value;
                object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                bool? aa_ = context.Operators.Not((bool?)(z_ is null));
                bool? ab_ = context.Operators.And(x_, aa_);
                Code<ObservationStatus> ac_ = AdultDepressionScreening?.StatusElement;
                ObservationStatus? ad_ = ac_?.Value;
                string ae_ = context.Operators.Convert<string>(ad_);
                string[] af_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ag_ = context.Operators.In<string>(ae_, (IEnumerable<string>)af_);
                bool? ah_ = context.Operators.And(ab_, ag_);
                return ah_;
            }

            bool? k_ = context.Operators.WhereAny<Encounter>(i_, j_);
            return k_;
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

        object f_(Observation @this) {
            DataType ai_ = @this?.Effective;
            object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
            CqlInterval<CqlDateTime> ak_ = QICoreCommon_4_0_000.Instance.toInterval(context, aj_);
            CqlDateTime al_ = context.Operators.Start(ak_);
            return al_;
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
        IEnumerable<MedicationRequest> a_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? b_(MedicationRequest MR) {
            IEnumerable<Medication> s_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? t_(Medication M) {
                Id v_ = M?.IdElement;
                string w_ = v_?.Value;
                FhirString x_;
                DataType ah_ = MR?.Medication;
                bool ai_ = ah_ is ResourceReference;
                if (ai_)
                {
                    FhirString aj_ = (ah_ as ResourceReference)?.ReferenceElement;
                    x_ = aj_;
                }
                else
                {
                    x_ = default;
                }
                string y_ = x_?.Value;
                IEnumerable<string> z_ = context.Operators.Split(y_, "/");
                string aa_ = context.Operators.Last<string>(z_);
                bool? ab_ = context.Operators.Equal(w_, aa_);
                CodeableConcept ac_ = M?.Code;
                CqlConcept ad_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ac_);
                CqlValueSet ae_ = this.Adult_Depression_Medications(context);
                bool? af_ = context.Operators.ConceptInValueSet(ad_, ae_);
                bool? ag_ = context.Operators.And(ab_, af_);
                return ag_;
            }

            bool? u_ = context.Operators.WhereAny<Medication>(s_, t_);
            return u_;
        }

        IEnumerable<MedicationRequest> c_ = context.Operators.Where<MedicationRequest>(a_, b_);
        CqlValueSet d_ = this.Adult_Depression_Medications(context);
        IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(c_, e_);

        bool? g_(MedicationRequest AdultMed) {
            IEnumerable<Encounter> ak_ = this.Qualifying_Encounter_During_Measurement_Period(context);

            bool? al_(Encounter QualifyingEncounter) {
                Observation an_ = this.Most_Recent_Adult_Depression_Screening(context);
                DataType ao_ = an_?.Effective;
                object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                CqlInterval<CqlDateTime> aq_ = QICoreCommon_4_0_000.Instance.toInterval(context, ap_);
                CqlDateTime ar_ = context.Operators.Start(aq_);
                Period as_ = QualifyingEncounter?.Period;
                CqlInterval<CqlDateTime> at_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, as_);
                CqlDateTime au_ = context.Operators.Start(at_);
                CqlQuantity av_ = context.Operators.Quantity(14m, "days");
                CqlDateTime aw_ = context.Operators.Subtract(au_, av_);
                CqlInterval<CqlDateTime> ax_ = context.Operators.Interval(aw_, au_, true, true);
                bool? ay_ = context.Operators.In<CqlDateTime>(ar_, ax_, "day");
                bool? az_ = context.Operators.Not((bool?)(au_ is null));
                bool? ba_ = context.Operators.And(ay_, az_);
                CqlInterval<CqlDate> bb_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, AdultMed);
                CqlDate bc_ = (bb_ as CqlInterval<CqlDate>)?.low;
                CqlDateTime bd_ = context.Operators.ConvertDateToDateTime(bc_);
                CqlDate be_ = (bb_ as CqlInterval<CqlDate>)?.high;
                CqlDateTime bf_ = context.Operators.ConvertDateToDateTime(be_);
                bool? bg_ = (bb_ as CqlInterval<CqlDate>)?.lowClosed;
                bool? bh_ = (bb_ as CqlInterval<CqlDate>)?.highClosed;
                CqlInterval<CqlDateTime> bi_ = context.Operators.Interval(bd_, bf_, bg_, bh_);
                CqlInterval<CqlDateTime> bj_ = QICoreCommon_4_0_000.Instance.toInterval(context, bi_);
                bool? bk_ = context.Operators.OverlapsAfter(bj_, at_, "day");
                bool? bl_ = context.Operators.And(ba_, bk_);
                DataType bm_ = an_?.Value;
                object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                CqlCode bo_ = this.Depression_screening_positive__finding_(context);
                CqlConcept bp_ = context.Operators.ConvertCodeToConcept(bo_);
                bool? bq_ = context.Operators.Equivalent(bn_ as CqlConcept, bp_);
                bool? br_ = context.Operators.And(bl_, bq_);
                Code<MedicationRequest.MedicationrequestStatus> bs_ = AdultMed?.StatusElement;
                MedicationRequest.MedicationrequestStatus? bt_ = bs_?.Value;
                string bu_ = context.Operators.Convert<string>(bt_);
                string[] bv_ = [
                    "active",
                    "completed",
                ];
                bool? bw_ = context.Operators.In<string>(bu_, (IEnumerable<string>)bv_);
                bool? bx_ = context.Operators.And(br_, bw_);
                Code<MedicationRequest.MedicationRequestIntent> by_ = AdultMed?.IntentElement;
                MedicationRequest.MedicationRequestIntent? bz_ = by_?.Value;
                string ca_ = context.Operators.Convert<string>(bz_);
                string[] cb_ = [
                    "order",
                    "original-order",
                    "reflex-order",
                    "filler-order",
                    "instance-order",
                ];
                bool? cc_ = context.Operators.In<string>(ca_, (IEnumerable<string>)cb_);
                bool? cd_ = context.Operators.And(bx_, cc_);
                return cd_;
            }

            bool? am_ = context.Operators.WhereAny<Encounter>(ak_, al_);
            return am_;
        }

        IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);
        CqlValueSet i_ = this.Referral_for_Adult_Depression(context);
        IEnumerable<ServiceRequest> j_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));

        bool? k_(ServiceRequest AdultReferral) {
            Code<RequestStatus> ce_ = AdultReferral?.StatusElement;
            RequestStatus? cf_ = ce_?.Value;
            Code<RequestStatus> cg_ = context.Operators.Convert<Code<RequestStatus>>(cf_);
            string ch_ = context.Operators.Convert<string>(cg_);
            string[] ci_ = [
                "active",
                "completed",
            ];
            bool? cj_ = context.Operators.In<string>(ch_, (IEnumerable<string>)ci_);
            return cj_;
        }

        IEnumerable<ServiceRequest> l_ = context.Operators.Where<ServiceRequest>(j_, k_);
        IEnumerable<object> m_ = context.Operators.Union<object>(h_ as IEnumerable<object>, l_ as IEnumerable<object>);
        CqlValueSet n_ = this.Follow_Up_for_Adult_Depression(context);
        IEnumerable<Procedure> o_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

        bool? p_(Procedure AdultFollowUp) {
            Code<EventStatus> ck_ = AdultFollowUp?.StatusElement;
            EventStatus? cl_ = ck_?.Value;
            string cm_ = context.Operators.Convert<string>(cl_);
            bool? cn_ = context.Operators.Equal(cm_, "completed");
            return cn_;
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
            bool? v_ = context.Operators.In<CqlDateTime>(o_, u_, "day");
            bool? w_ = context.Operators.Not((bool?)(r_ is null));
            bool? x_ = context.Operators.And(v_, w_);
            DataType y_ = tuple_cgtoaqsajoehgwcararimqzsa?.LastAdultScreen?.Value;
            object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
            CqlCode aa_ = this.Depression_screening_positive__finding_(context);
            CqlConcept ab_ = context.Operators.ConvertCodeToConcept(aa_);
            bool? ac_ = context.Operators.Equivalent(z_ as CqlConcept, ab_);
            bool? ad_ = context.Operators.And(x_, ac_);
            object ae_;
            object bb_;
            if (tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen is Procedure)
            {
                DataType be_ = (tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen as Procedure)?.Performed;
                bb_ = be_;
            }
            else
            {
                bb_ = null;
            }
            object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
            bool bd_ = bc_ is CqlDateTime;
            if (bd_)
            {
                object bf_;
                if (tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen is Procedure)
                {
                    DataType bh_ = (tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen as Procedure)?.Performed;
                    bf_ = bh_;
                }
                else
                {
                    bf_ = null;
                }
                object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                ae_ = bg_ as CqlDateTime;
            }
            else
            {
                object bi_;
                if (tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen is Procedure)
                {
                    DataType bl_ = (tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen as Procedure)?.Performed;
                    bi_ = bl_;
                }
                else
                {
                    bi_ = null;
                }
                object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                bool bk_ = bj_ is CqlQuantity;
                if (bk_)
                {
                    object bm_;
                    if (tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen is Procedure)
                    {
                        DataType bo_ = (tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen as Procedure)?.Performed;
                        bm_ = bo_;
                    }
                    else
                    {
                        bm_ = null;
                    }
                    object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                    ae_ = bn_ as CqlQuantity;
                }
                else
                {
                    object bp_;
                    if (tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen is Procedure)
                    {
                        DataType bs_ = (tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen as Procedure)?.Performed;
                        bp_ = bs_;
                    }
                    else
                    {
                        bp_ = null;
                    }
                    object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                    bool br_ = bq_ is CqlInterval<CqlDateTime>;
                    if (br_)
                    {
                        object bt_;
                        if (tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen is Procedure)
                        {
                            DataType bv_ = (tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen as Procedure)?.Performed;
                            bt_ = bv_;
                        }
                        else
                        {
                            bt_ = null;
                        }
                        object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                        ae_ = bu_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        object bw_;
                        if (tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen is Procedure)
                        {
                            DataType bz_ = (tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen as Procedure)?.Performed;
                            bw_ = bz_;
                        }
                        else
                        {
                            bw_ = null;
                        }
                        object bx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bw_);
                        bool by_ = bx_ is CqlInterval<CqlQuantity>;
                        if (by_)
                        {
                            object ca_;
                            if (tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen is Procedure)
                            {
                                DataType cc_ = (tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen as Procedure)?.Performed;
                                ca_ = cc_;
                            }
                            else
                            {
                                ca_ = null;
                            }
                            object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                            ae_ = cb_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            ae_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> af_ = QICoreCommon_4_0_000.Instance.toInterval(context, ae_);
            CqlDateTime ag_ = context.Operators.Start(af_);
            bool? ah_ = context.Operators.In<CqlDateTime>(ag_, q_, (string)default);
            FhirDateTime ai_;
            if (tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen is MedicationRequest)
            {
                FhirDateTime cd_ = (tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen as MedicationRequest)?.AuthoredOnElement;
                ai_ = cd_;
            }
            else if (tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen is ServiceRequest)
            {
                FhirDateTime ce_ = (tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen as ServiceRequest)?.AuthoredOnElement;
                ai_ = ce_;
            }
            else
            {
                ai_ = default;
            }
            CqlDateTime aj_ = context.Operators.Convert<CqlDateTime>(ai_);
            CqlDateTime ak_ = context.Operators.End(q_);
            CqlQuantity al_ = context.Operators.Quantity(2m, "days");
            CqlDateTime am_ = context.Operators.Add(ak_, al_);
            CqlInterval<CqlDateTime> an_ = context.Operators.Interval(ak_, am_, true, true);
            bool? ao_ = context.Operators.In<CqlDateTime>(aj_, an_, "day");
            bool? ap_ = context.Operators.Not((bool?)(ak_ is null));
            bool? aq_ = context.Operators.And(ao_, ap_);
            bool? ar_ = context.Operators.Or(ah_, aq_);
            bool? as_ = context.Operators.And(ad_, ar_);
            object at_;
            object cf_;
            if (tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen is Procedure)
            {
                DataType ci_ = (tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen as Procedure)?.Performed;
                cf_ = ci_;
            }
            else
            {
                cf_ = null;
            }
            object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
            bool ch_ = cg_ is CqlDateTime;
            if (ch_)
            {
                object cj_;
                if (tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen is Procedure)
                {
                    DataType cl_ = (tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen as Procedure)?.Performed;
                    cj_ = cl_;
                }
                else
                {
                    cj_ = null;
                }
                object ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
                at_ = ck_ as CqlDateTime;
            }
            else
            {
                object cm_;
                if (tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen is Procedure)
                {
                    DataType cp_ = (tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen as Procedure)?.Performed;
                    cm_ = cp_;
                }
                else
                {
                    cm_ = null;
                }
                object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                bool co_ = cn_ is CqlQuantity;
                if (co_)
                {
                    object cq_;
                    if (tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen is Procedure)
                    {
                        DataType cs_ = (tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen as Procedure)?.Performed;
                        cq_ = cs_;
                    }
                    else
                    {
                        cq_ = null;
                    }
                    object cr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cq_);
                    at_ = cr_ as CqlQuantity;
                }
                else
                {
                    object ct_;
                    if (tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen is Procedure)
                    {
                        DataType cw_ = (tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen as Procedure)?.Performed;
                        ct_ = cw_;
                    }
                    else
                    {
                        ct_ = null;
                    }
                    object cu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ct_);
                    bool cv_ = cu_ is CqlInterval<CqlDateTime>;
                    if (cv_)
                    {
                        object cx_;
                        if (tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen is Procedure)
                        {
                            DataType cz_ = (tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen as Procedure)?.Performed;
                            cx_ = cz_;
                        }
                        else
                        {
                            cx_ = null;
                        }
                        object cy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                        at_ = cy_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        object da_;
                        if (tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen is Procedure)
                        {
                            DataType dd_ = (tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen as Procedure)?.Performed;
                            da_ = dd_;
                        }
                        else
                        {
                            da_ = null;
                        }
                        object db_ = FHIRHelpers_4_4_000.Instance.ToValue(context, da_);
                        bool dc_ = db_ is CqlInterval<CqlQuantity>;
                        if (dc_)
                        {
                            object de_;
                            if (tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen is Procedure)
                            {
                                DataType dg_ = (tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen as Procedure)?.Performed;
                                de_ = dg_;
                            }
                            else
                            {
                                de_ = null;
                            }
                            object df_ = FHIRHelpers_4_4_000.Instance.ToValue(context, de_);
                            at_ = df_ as CqlInterval<CqlQuantity>;
                        }
                        else
                        {
                            at_ = null;
                        }
                    }
                }
            }
            CqlInterval<CqlDateTime> au_ = QICoreCommon_4_0_000.Instance.toInterval(context, at_);
            CqlDateTime av_ = context.Operators.Start(au_);
            FhirDateTime aw_;
            if (tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen is MedicationRequest)
            {
                FhirDateTime dh_ = (tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen as MedicationRequest)?.AuthoredOnElement;
                aw_ = dh_;
            }
            else if (tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen is ServiceRequest)
            {
                FhirDateTime di_ = (tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen as ServiceRequest)?.AuthoredOnElement;
                aw_ = di_;
            }
            else
            {
                aw_ = default;
            }
            CqlDateTime ax_ = context.Operators.Convert<CqlDateTime>(aw_);
            CqlInterval<CqlDateTime> ay_ = this.Measurement_Period(context);
            bool? az_ = context.Operators.In<CqlDateTime>(av_ ?? ax_, ay_, "day");
            bool? ba_ = context.Operators.And(as_, az_);
            return ba_;
        }

        IEnumerable<(CqlTupleMetadata, Observation LastAdultScreen, object FollowUpPositiveAdultScreen, Encounter QualifyingEncounter)?> h_ = context.Operators.SelectWhere<ValueTuple<Observation, object, Encounter>, (CqlTupleMetadata, Observation LastAdultScreen, object FollowUpPositiveAdultScreen, Encounter QualifyingEncounter)?>(e_, f_, g_);

        (CqlTupleMetadata, Observation LastAdultScreen, object FollowUpPositiveAdultScreen, Encounter QualifyingEncounter)? i_((CqlTupleMetadata, Observation LastAdultScreen, object FollowUpPositiveAdultScreen, Encounter QualifyingEncounter)? tuple_cgtoaqsajoehgwcararimqzsa) {
            (CqlTupleMetadata, Observation LastAdultScreen, object FollowUpPositiveAdultScreen, Encounter QualifyingEncounter)? dj_ = (CqlTupleMetadata_ICeCVaggPeLLMJUWQdWMZROe, tuple_cgtoaqsajoehgwcararimqzsa?.LastAdultScreen, tuple_cgtoaqsajoehgwcararimqzsa?.FollowUpPositiveAdultScreen, tuple_cgtoaqsajoehgwcararimqzsa?.QualifyingEncounter);
            return dj_;
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
        bool? h_ = this.Has_Most_Recent_Adult_Screening_Negative(context);
        bool? i_ = context.Operators.Or(e_, h_);
        IEnumerable<(CqlTupleMetadata, Observation LastAdultScreen, object FollowUpPositiveAdultScreen, Encounter QualifyingEncounter)?> j_ = this.Most_Recent_Adult_Depression_Screening_Positive_and_Follow_Up_Provided(context);
        bool? k_ = context.Operators.Exists<(CqlTupleMetadata, Observation LastAdultScreen, object FollowUpPositiveAdultScreen, Encounter QualifyingEncounter)?>(j_);
        bool? l_ = context.Operators.Or(i_, k_);
        bool? m_ = context.Operators.And(g_, l_);
        bool? n_ = context.Operators.Or(f_, m_);
        bool? o_ = this.Patient_Age_18_Years_or_Older_at_Start_of_Measurement_Period(context);
        bool? p_ = context.Operators.Or(h_, k_);
        bool? q_ = context.Operators.And(o_, p_);
        bool? r_ = context.Operators.Or(n_, q_);
        return r_;
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
                bool? p_ = context.Operators.In<CqlDateTime>(m_, o_, "day");
                return p_;
            }

            bool? j_ = context.Operators.WhereAny<Encounter>(h_, i_);
            return j_;
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

        bool? f_(Observation NoAdolescentScreen) {
            List<Extension> q_ = NoAdolescentScreen?.Extension;

            bool? r_(Extension @this) {
                FhirUri ah_ = @this?.UrlElement;
                string ai_ = FHIRHelpers_4_4_000.Instance.ToString(context, ah_);
                bool? aj_ = context.Operators.Equal(ai_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");
                return aj_;
            }


            object s_(Extension @this) {
                DataType ak_ = @this?.Value;
                return ak_;
            }

            IEnumerable<object> t_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)q_, r_, s_);
            object u_ = context.Operators.SingletonFrom<object>(t_);
            CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, u_ as CodeableConcept);
            CqlCode w_ = this.Depression_screening_declined__situation_(context);
            CqlConcept x_ = context.Operators.ConvertCodeToConcept(w_);
            bool? y_ = context.Operators.Equivalent(v_, x_);

            bool? z_(Extension @this) {
                FhirUri al_ = @this?.UrlElement;
                string am_ = FHIRHelpers_4_4_000.Instance.ToString(context, al_);
                bool? an_ = context.Operators.Equal(am_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");
                return an_;
            }


            object aa_(Extension @this) {
                DataType ao_ = @this?.Value;
                return ao_;
            }

            IEnumerable<object> ab_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)q_, z_, aa_);
            object ac_ = context.Operators.SingletonFrom<object>(ab_);
            CqlConcept ad_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ac_ as CodeableConcept);
            CqlValueSet ae_ = this.Medical_Reason(context);
            bool? af_ = context.Operators.ConceptInValueSet(ad_, ae_);
            bool? ag_ = context.Operators.Or(y_, af_);
            return ag_;
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
                bool? s_ = context.Operators.In<CqlDateTime>(l_, r_, "day");
                bool? t_ = context.Operators.Not((bool?)(o_ is null));
                bool? u_ = context.Operators.And(s_, t_);
                DataType v_ = AdolescentScreening?.Value;
                object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                bool? x_ = context.Operators.Not((bool?)(w_ is null));
                bool? y_ = context.Operators.And(u_, x_);
                Code<ObservationStatus> z_ = AdolescentScreening?.StatusElement;
                ObservationStatus? aa_ = z_?.Value;
                string ab_ = context.Operators.Convert<string>(aa_);
                string[] ac_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ad_ = context.Operators.In<string>(ab_, (IEnumerable<string>)ac_);
                bool? ae_ = context.Operators.And(y_, ad_);
                return ae_;
            }

            bool? h_ = context.Operators.WhereAny<Encounter>(f_, g_);
            return h_;
        }

        bool? e_ = context.Operators.WhereAny<Observation>(c_, d_);
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
                bool? p_ = context.Operators.In<CqlDateTime>(m_, o_, "day");
                return p_;
            }

            bool? j_ = context.Operators.WhereAny<Encounter>(h_, i_);
            return j_;
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

        bool? f_(Observation NoAdultScreen) {
            List<Extension> q_ = NoAdultScreen?.Extension;

            bool? r_(Extension @this) {
                FhirUri ah_ = @this?.UrlElement;
                string ai_ = FHIRHelpers_4_4_000.Instance.ToString(context, ah_);
                bool? aj_ = context.Operators.Equal(ai_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");
                return aj_;
            }


            object s_(Extension @this) {
                DataType ak_ = @this?.Value;
                return ak_;
            }

            IEnumerable<object> t_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)q_, r_, s_);
            object u_ = context.Operators.SingletonFrom<object>(t_);
            CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, u_ as CodeableConcept);
            CqlCode w_ = this.Depression_screening_declined__situation_(context);
            CqlConcept x_ = context.Operators.ConvertCodeToConcept(w_);
            bool? y_ = context.Operators.Equivalent(v_, x_);

            bool? z_(Extension @this) {
                FhirUri al_ = @this?.UrlElement;
                string am_ = FHIRHelpers_4_4_000.Instance.ToString(context, al_);
                bool? an_ = context.Operators.Equal(am_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");
                return an_;
            }


            object aa_(Extension @this) {
                DataType ao_ = @this?.Value;
                return ao_;
            }

            IEnumerable<object> ab_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)q_, z_, aa_);
            object ac_ = context.Operators.SingletonFrom<object>(ab_);
            CqlConcept ad_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ac_ as CodeableConcept);
            CqlValueSet ae_ = this.Medical_Reason(context);
            bool? af_ = context.Operators.ConceptInValueSet(ad_, ae_);
            bool? ag_ = context.Operators.Or(y_, af_);
            return ag_;
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
                bool? s_ = context.Operators.In<CqlDateTime>(l_, r_, "day");
                bool? t_ = context.Operators.Not((bool?)(o_ is null));
                bool? u_ = context.Operators.And(s_, t_);
                DataType v_ = AdultScreening?.Value;
                object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                bool? x_ = context.Operators.Not((bool?)(w_ is null));
                bool? y_ = context.Operators.And(u_, x_);
                Code<ObservationStatus> z_ = AdultScreening?.StatusElement;
                ObservationStatus? aa_ = z_?.Value;
                string ab_ = context.Operators.Convert<string>(aa_);
                string[] ac_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ad_ = context.Operators.In<string>(ab_, (IEnumerable<string>)ac_);
                bool? ae_ = context.Operators.And(y_, ad_);
                return ae_;
            }

            bool? h_ = context.Operators.WhereAny<Encounter>(f_, g_);
            return h_;
        }

        bool? e_ = context.Operators.WhereAny<Observation>(c_, d_);
        return e_;
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
