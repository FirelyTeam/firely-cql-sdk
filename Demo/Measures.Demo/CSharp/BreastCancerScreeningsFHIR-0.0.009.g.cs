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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.0.0")]
[CqlLibrary("BreastCancerScreeningsFHIR", "0.0.009")]
public partial class BreastCancerScreeningsFHIR_0_0_009 : ILibrary, ISingleton<BreastCancerScreeningsFHIR_0_0_009>
{
    #region ValueSets (12)

    [CqlValueSetDefinition("Bilateral Mastectomy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1005", valueSetVersion: null)]
    public CqlValueSet Bilateral_Mastectomy(CqlContext _) => _Bilateral_Mastectomy;
    private static readonly CqlValueSet _Bilateral_Mastectomy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1005", null);

    [CqlValueSetDefinition("History of bilateral mastectomy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1068", valueSetVersion: null)]
    public CqlValueSet History_of_bilateral_mastectomy(CqlContext _) => _History_of_bilateral_mastectomy;
    private static readonly CqlValueSet _History_of_bilateral_mastectomy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1068", null);

    [CqlValueSetDefinition("Left", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.122.12.1036", valueSetVersion: null)]
    public CqlValueSet Left(CqlContext _) => _Left;
    private static readonly CqlValueSet _Left = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.122.12.1036", null);

    [CqlValueSetDefinition("Mammography", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.11.1047", valueSetVersion: null)]
    public CqlValueSet Mammography(CqlContext _) => _Mammography;
    private static readonly CqlValueSet _Mammography = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.11.1047", null);

    [CqlValueSetDefinition("Online Assessments", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", valueSetVersion: null)]
    public CqlValueSet Online_Assessments(CqlContext _) => _Online_Assessments;
    private static readonly CqlValueSet _Online_Assessments = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", null);

    [CqlValueSetDefinition("Right", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.122.12.1035", valueSetVersion: null)]
    public CqlValueSet Right(CqlContext _) => _Right;
    private static readonly CqlValueSet _Right = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.122.12.1035", null);

    [CqlValueSetDefinition("Status Post Left Mastectomy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1069", valueSetVersion: null)]
    public CqlValueSet Status_Post_Left_Mastectomy(CqlContext _) => _Status_Post_Left_Mastectomy;
    private static readonly CqlValueSet _Status_Post_Left_Mastectomy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1069", null);

    [CqlValueSetDefinition("Status Post Right Mastectomy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1070", valueSetVersion: null)]
    public CqlValueSet Status_Post_Right_Mastectomy(CqlContext _) => _Status_Post_Right_Mastectomy;
    private static readonly CqlValueSet _Status_Post_Right_Mastectomy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1070", null);

    [CqlValueSetDefinition("Telephone Visits", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", valueSetVersion: null)]
    public CqlValueSet Telephone_Visits(CqlContext _) => _Telephone_Visits;
    private static readonly CqlValueSet _Telephone_Visits = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    [CqlValueSetDefinition("Unilateral Mastectomy Left", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1133", valueSetVersion: null)]
    public CqlValueSet Unilateral_Mastectomy_Left(CqlContext _) => _Unilateral_Mastectomy_Left;
    private static readonly CqlValueSet _Unilateral_Mastectomy_Left = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1133", null);

    [CqlValueSetDefinition("Unilateral Mastectomy Right", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1134", valueSetVersion: null)]
    public CqlValueSet Unilateral_Mastectomy_Right(CqlContext _) => _Unilateral_Mastectomy_Right;
    private static readonly CqlValueSet _Unilateral_Mastectomy_Right = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1134", null);

    [CqlValueSetDefinition("Unilateral Mastectomy, Unspecified Laterality", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1071", valueSetVersion: null)]
    public CqlValueSet Unilateral_Mastectomy__Unspecified_Laterality(CqlContext _) => _Unilateral_Mastectomy__Unspecified_Laterality;
    private static readonly CqlValueSet _Unilateral_Mastectomy__Unspecified_Laterality = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1071", null);

    #endregion ValueSets

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = -2207426731370318965L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2021, 1, 1, 0, 0, 0, 0, (decimal?)default);
        CqlDateTime b_ = context.Operators.DateTime(2022, 1, 1, 0, 0, 0, 0, (decimal?)default);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("BreastCancerScreeningsFHIR-0.0.009", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (22)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = 5570106870785194822L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = 3199891238918059275L;

    private IEnumerable<Coding> SDE_Ethnicity_Compute(CqlContext context)
    {
        IEnumerable<Coding> a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = 5445575742970110470L;

    private IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = -232079090114154694L;

    private IEnumerable<Coding> SDE_Race_Compute(CqlContext context)
    {
        IEnumerable<Coding> a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = 7084186765858753302L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);
        return a_;
    }


    [CqlExpressionDefinition("Telehealth Services")]
    public IEnumerable<Encounter> Telehealth_Services(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Telehealth_Services, Telehealth_Services_Compute);

    private const long _cacheIndex_Telehealth_Services = -7813635683541175529L;

    private IEnumerable<Encounter> Telehealth_Services_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Online_Assessments(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet c_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);

        bool? f_(Encounter TelehealthEncounter) {
            Code<Encounter.EncounterStatus> h_ = TelehealthEncounter?.StatusElement;
            string i_ = FHIRHelpers_4_0_001.Instance.ToString(context, h_);
            bool? j_ = context.Operators.Equal(i_, "finished");
            // CQL 'and' (50:19-51:110): right operand skipped when left is false
            if (j_ is false)
            {
                return false;
            }
            else
            {
                CqlInterval<CqlDateTime> k_ = this.Measurement_Period(context);
                Period l_ = TelehealthEncounter?.Period;
                CqlInterval<CqlDateTime> m_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, l_);
                bool? n_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(k_, m_, (string)default);
                return j_ & n_;
            }
        }

        IEnumerable<Encounter> g_ = context.Operators.Where<Encounter>(e_, f_);
        return g_;
    }


    [CqlExpressionDefinition("Age at start of Measurement Period")]
    public int? Age_at_start_of_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Age_at_start_of_Measurement_Period, Age_at_start_of_Measurement_Period_Compute);

    private const long _cacheIndex_Age_at_start_of_Measurement_Period = 7644643045620551999L;

    private int? Age_at_start_of_Measurement_Period_Compute(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Date b_ = a_?.BirthDateElement;
        string c_ = b_?.Value;
        CqlDate d_ = context.Operators.ConvertStringToDate(c_);
        CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
        CqlDateTime f_ = context.Operators.Start(e_);
        CqlDate g_ = context.Operators.DateFrom(f_);
        int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
        return h_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = -6792269563159157682L;

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
        CqlInterval<int?> i_ = context.Operators.Interval(51, 74, true, false);
        bool? j_ = context.Operators.In<int?>(h_, i_, (string)default);
        bool? k_;
        // CQL 'and' (58:3-59:47): right operand skipped when left is false
        if (j_ is false)
        {
            k_ = false;
        }
        else
        {
            Patient l_ = this.Patient(context);
            Code<AdministrativeGender> m_ = l_?.GenderElement;
            string n_ = FHIRHelpers_4_0_001.Instance.ToString(context, m_);
            bool? o_ = context.Operators.Equal(n_, "female");
            k_ = j_ & o_;
        }
        // CQL 'and' (58:3-62:19): right operand skipped when left is false
        if (k_ is false)
        {
            return false;
        }
        else
        {
            IEnumerable<Encounter> p_ = AdultOutpatientEncountersFHIR4_2_2_000.Instance.Qualifying_Encounters(context);
            IEnumerable<Encounter> q_ = this.Telehealth_Services(context);
            IEnumerable<Encounter> r_ = context.Operators.Union<Encounter>(p_, q_);
            bool? s_ = context.Operators.Exists<Encounter>(r_);
            return k_ & s_;
        }
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = 7510229845399598539L;

    private bool? Denominator_Compute(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlExpressionDefinition("Right Mastectomy Diagnosis")]
    public IEnumerable<Condition> Right_Mastectomy_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Right_Mastectomy_Diagnosis, Right_Mastectomy_Diagnosis_Compute);

    private const long _cacheIndex_Right_Mastectomy_Diagnosis = 2315704434442719000L;

    private IEnumerable<Condition> Right_Mastectomy_Diagnosis_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Status_Post_Right_Mastectomy(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        CqlValueSet c_ = this.Unilateral_Mastectomy__Unspecified_Laterality(context);
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));

        bool? e_(Condition UnilateralMastectomyDiagnosis) {
            List<CodeableConcept> j_ = UnilateralMastectomyDiagnosis?.BodySite;

            CqlConcept k_(CodeableConcept X) {
                CqlConcept o_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);
                return o_;
            }

            IEnumerable<CqlConcept> l_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)j_, k_);
            CqlValueSet m_ = this.Right(context);
            bool? n_ = context.Operators.ConceptsInValueSet(l_, m_);
            return n_;
        }

        IEnumerable<Condition> f_ = context.Operators.Where<Condition>(d_, e_);
        IEnumerable<Condition> g_ = context.Operators.Union<Condition>(b_, f_);

        bool? h_(Condition RightMastectomy) {
            CqlInterval<CqlDateTime> p_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, RightMastectomy);
            CqlDateTime q_ = context.Operators.Start(p_);
            CqlInterval<CqlDateTime> r_ = this.Measurement_Period(context);
            CqlDateTime s_ = context.Operators.End(r_);
            bool? t_ = context.Operators.SameOrBefore(q_, s_, (string)default);
            return t_;
        }

        IEnumerable<Condition> i_ = context.Operators.Where<Condition>(g_, h_);
        return i_;
    }


    [CqlExpressionDefinition("Right Mastectomy Procedure")]
    public IEnumerable<Procedure> Right_Mastectomy_Procedure(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Right_Mastectomy_Procedure, Right_Mastectomy_Procedure_Compute);

    private const long _cacheIndex_Right_Mastectomy_Procedure = 6490593119952607665L;

    private IEnumerable<Procedure> Right_Mastectomy_Procedure_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Unilateral_Mastectomy_Right(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));

        bool? c_(Procedure UnilateralMastectomyRightPerformed) {
            Code<EventStatus> e_ = UnilateralMastectomyRightPerformed?.StatusElement;
            string f_ = FHIRHelpers_4_0_001.Instance.ToString(context, e_);
            bool? g_ = context.Operators.Equal(f_, "completed");
            // CQL 'and' (154:19-156:47): right operand skipped when left is false
            if (g_ is false)
            {
                return false;
            }
            else
            {
                DataType h_ = UnilateralMastectomyRightPerformed?.Performed;
                CqlInterval<CqlDateTime> i_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, h_);
                CqlDateTime j_ = context.Operators.End(i_);
                CqlInterval<CqlDateTime> k_ = this.Measurement_Period(context);
                CqlDateTime l_ = context.Operators.End(k_);
                bool? m_ = context.Operators.SameOrBefore(j_, l_, (string)default);
                return g_ & m_;
            }
        }

        IEnumerable<Procedure> d_ = context.Operators.Where<Procedure>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Left Mastectomy Diagnosis")]
    public IEnumerable<Condition> Left_Mastectomy_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Left_Mastectomy_Diagnosis, Left_Mastectomy_Diagnosis_Compute);

    private const long _cacheIndex_Left_Mastectomy_Diagnosis = -5706647408619357406L;

    private IEnumerable<Condition> Left_Mastectomy_Diagnosis_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Status_Post_Left_Mastectomy(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        CqlValueSet c_ = this.Unilateral_Mastectomy__Unspecified_Laterality(context);
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));

        bool? e_(Condition UnilateralMastectomyDiagnosis) {
            List<CodeableConcept> j_ = UnilateralMastectomyDiagnosis?.BodySite;

            CqlConcept k_(CodeableConcept X) {
                CqlConcept o_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);
                return o_;
            }

            IEnumerable<CqlConcept> l_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)j_, k_);
            CqlValueSet m_ = this.Left(context);
            bool? n_ = context.Operators.ConceptsInValueSet(l_, m_);
            return n_;
        }

        IEnumerable<Condition> f_ = context.Operators.Where<Condition>(d_, e_);
        IEnumerable<Condition> g_ = context.Operators.Union<Condition>(b_, f_);

        bool? h_(Condition LeftMastectomy) {
            CqlInterval<CqlDateTime> p_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, LeftMastectomy);
            CqlDateTime q_ = context.Operators.Start(p_);
            CqlInterval<CqlDateTime> r_ = this.Measurement_Period(context);
            CqlDateTime s_ = context.Operators.End(r_);
            bool? t_ = context.Operators.SameOrBefore(q_, s_, (string)default);
            return t_;
        }

        IEnumerable<Condition> i_ = context.Operators.Where<Condition>(g_, h_);
        return i_;
    }


    [CqlExpressionDefinition("Left Mastectomy Procedure")]
    public IEnumerable<Procedure> Left_Mastectomy_Procedure(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Left_Mastectomy_Procedure, Left_Mastectomy_Procedure_Compute);

    private const long _cacheIndex_Left_Mastectomy_Procedure = 7379586125197607600L;

    private IEnumerable<Procedure> Left_Mastectomy_Procedure_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Unilateral_Mastectomy_Left(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));

        bool? c_(Procedure UnilateralMastectomyLeftPerformed) {
            Code<EventStatus> e_ = UnilateralMastectomyLeftPerformed?.StatusElement;
            string f_ = FHIRHelpers_4_0_001.Instance.ToString(context, e_);
            bool? g_ = context.Operators.Equal(f_, "completed");
            // CQL 'and' (168:19-170:47): right operand skipped when left is false
            if (g_ is false)
            {
                return false;
            }
            else
            {
                DataType h_ = UnilateralMastectomyLeftPerformed?.Performed;
                CqlInterval<CqlDateTime> i_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, h_);
                CqlDateTime j_ = context.Operators.End(i_);
                CqlInterval<CqlDateTime> k_ = this.Measurement_Period(context);
                CqlDateTime l_ = context.Operators.End(k_);
                bool? m_ = context.Operators.SameOrBefore(j_, l_, (string)default);
                return g_ & m_;
            }
        }

        IEnumerable<Procedure> d_ = context.Operators.Where<Procedure>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Bilateral Mastectomy Diagnosis")]
    public IEnumerable<Condition> Bilateral_Mastectomy_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Bilateral_Mastectomy_Diagnosis, Bilateral_Mastectomy_Diagnosis_Compute);

    private const long _cacheIndex_Bilateral_Mastectomy_Diagnosis = -2442296618649008220L;

    private IEnumerable<Condition> Bilateral_Mastectomy_Diagnosis_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.History_of_bilateral_mastectomy(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));

        bool? c_(Condition BilateralMastectomyHistory) {
            CqlInterval<CqlDateTime> e_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, BilateralMastectomyHistory);
            CqlDateTime f_ = context.Operators.Start(e_);
            CqlInterval<CqlDateTime> g_ = this.Measurement_Period(context);
            CqlDateTime h_ = context.Operators.End(g_);
            bool? i_ = context.Operators.SameOrBefore(f_, h_, (string)default);
            return i_;
        }

        IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Bilateral Mastectomy Procedure")]
    public IEnumerable<Procedure> Bilateral_Mastectomy_Procedure(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Bilateral_Mastectomy_Procedure, Bilateral_Mastectomy_Procedure_Compute);

    private const long _cacheIndex_Bilateral_Mastectomy_Procedure = 4919458562761610194L;

    private IEnumerable<Procedure> Bilateral_Mastectomy_Procedure_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Bilateral_Mastectomy(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));

        bool? c_(Procedure BilateralMastectomyPerformed) {
            Code<EventStatus> e_ = BilateralMastectomyPerformed?.StatusElement;
            string f_ = FHIRHelpers_4_0_001.Instance.ToString(context, e_);
            bool? g_ = context.Operators.Equal(f_, "completed");
            // CQL 'and' (179:19-181:47): right operand skipped when left is false
            if (g_ is false)
            {
                return false;
            }
            else
            {
                DataType h_ = BilateralMastectomyPerformed?.Performed;
                CqlInterval<CqlDateTime> i_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, h_);
                CqlDateTime j_ = context.Operators.End(i_);
                CqlInterval<CqlDateTime> k_ = this.Measurement_Period(context);
                CqlDateTime l_ = context.Operators.End(k_);
                bool? m_ = context.Operators.SameOrBefore(j_, l_, (string)default);
                return g_ & m_;
            }
        }

        IEnumerable<Procedure> d_ = context.Operators.Where<Procedure>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exclusions, Denominator_Exclusions_Compute);

    private const long _cacheIndex_Denominator_Exclusions = 9107634671931457698L;

    private bool? Denominator_Exclusions_Compute(CqlContext context)
    {
        bool? a_ = HospiceFHIR4_2_3_000.Instance.Has_Hospice(context);
        bool? b_;
        // CQL 'or' (68:5-75:21): right operand skipped when left is true
        if (a_ is true)
        {
            b_ = true;
        }
        else
        {
            IEnumerable<Condition> g_ = this.Right_Mastectomy_Diagnosis(context);
            bool? h_ = context.Operators.Exists<Condition>(g_);
            bool? i_;
            // CQL 'or' (69:26-71:23): right operand skipped when left is true
            if (h_ is true)
            {
                i_ = true;
            }
            else
            {
                IEnumerable<Procedure> k_ = this.Right_Mastectomy_Procedure(context);
                bool? l_ = context.Operators.Exists<Procedure>(k_);
                i_ = h_ | l_;
            }
            bool? j_;
            // CQL 'and' (69:24-75:21): right operand skipped when left is false
            if (i_ is false)
            {
                j_ = false;
            }
            else
            {
                IEnumerable<Condition> m_ = this.Left_Mastectomy_Diagnosis(context);
                bool? n_ = context.Operators.Exists<Condition>(m_);
                bool? o_;
                // CQL 'or' (72:29-74:25): right operand skipped when left is true
                if (n_ is true)
                {
                    o_ = true;
                }
                else
                {
                    IEnumerable<Procedure> p_ = this.Left_Mastectomy_Procedure(context);
                    bool? q_ = context.Operators.Exists<Procedure>(p_);
                    o_ = n_ | q_;
                }
                j_ = i_ & o_;
            }
            b_ = a_ | j_;
        }
        bool? c_;
        // CQL 'or' (68:5-76:62): right operand skipped when left is true
        if (b_ is true)
        {
            c_ = true;
        }
        else
        {
            IEnumerable<Condition> r_ = this.Bilateral_Mastectomy_Diagnosis(context);
            bool? s_ = context.Operators.Exists<Condition>(r_);
            c_ = b_ | s_;
        }
        bool? d_;
        // CQL 'or' (68:5-77:62): right operand skipped when left is true
        if (c_ is true)
        {
            d_ = true;
        }
        else
        {
            IEnumerable<Procedure> t_ = this.Bilateral_Mastectomy_Procedure(context);
            bool? u_ = context.Operators.Exists<Procedure>(t_);
            d_ = c_ | u_;
        }
        bool? e_;
        // CQL 'or' (68:5-78:104): right operand skipped when left is true
        if (d_ is true)
        {
            e_ = true;
        }
        else
        {
            bool? v_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance.Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80(context);
            e_ = d_ | v_;
        }
        bool? f_;
        // CQL 'or' (68:5-81:21): right operand skipped when left is true
        if (e_ is true)
        {
            f_ = true;
        }
        else
        {
            Patient w_ = this.Patient(context);
            Date x_ = w_?.BirthDateElement;
            string y_ = x_?.Value;
            CqlDate z_ = context.Operators.ConvertStringToDate(y_);
            CqlInterval<CqlDateTime> aa_ = this.Measurement_Period(context);
            CqlDateTime ab_ = context.Operators.Start(aa_);
            CqlDate ac_ = context.Operators.DateFrom(ab_);
            int? ad_ = context.Operators.CalculateAgeAt(z_, ac_, "year");
            bool? ae_ = context.Operators.GreaterOrEqual(ad_, 65);
            bool? af_;
            // CQL 'and' (79:24-81:21): right operand skipped when left is false
            if (ae_ is false)
            {
                af_ = false;
            }
            else
            {
                bool? ag_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance.Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days(context);
                af_ = ae_ & ag_;
            }
            f_ = e_ | af_;
        }
        // CQL 'or' (68:3-83:17): right operand skipped when left is true
        if (f_ is true)
        {
            return true;
        }
        else
        {
            bool? ah_ = PalliativeCareFHIR_0_6_000.Instance.Palliative_Care_in_the_Measurement_Period(context);
            return f_ | ah_;
        }
    }


    [CqlExpressionDefinition("Observation with status")]
    public bool? Observation_with_status(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Observation_with_status, Observation_with_status_Compute);

    private const long _cacheIndex_Observation_with_status = 1405724507471036994L;

    private bool? Observation_with_status_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Mammography(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));

        bool? c_(Observation Mammogram) {
            Code<ObservationStatus> e_ = Mammogram?.StatusElement;
            string f_ = FHIRHelpers_4_0_001.Instance.ToString(context, e_);
            string[] g_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? h_ = context.Operators.In<string>(f_, (IEnumerable<string>)g_);
            // CQL 'and' (111:21-114:23): right operand skipped when left is false
            if (h_ is false)
            {
                return false;
            }
            else
            {
                DataType i_ = Mammogram?.Effective;
                CqlInterval<CqlDateTime> j_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, i_);
                CqlDateTime k_ = context.Operators.End(j_);
                CqlInterval<CqlDateTime> l_ = this.Measurement_Period(context);
                CqlDateTime m_ = context.Operators.End(l_);
                CqlQuantity n_ = context.Operators.Quantity(27m, "months");
                CqlDateTime o_ = context.Operators.Subtract(m_, n_);
                CqlInterval<CqlDateTime> p_ = context.Operators.Interval(o_, m_, true, true);
                bool? q_ = context.Operators.In<CqlDateTime>(k_, p_, (string)default);
                bool? r_;
                // CQL 'and' (112:27-114:23): right operand skipped when left is false
                if (q_ is false)
                {
                    r_ = false;
                }
                else
                {
                    CqlInterval<CqlDateTime> s_ = this.Measurement_Period(context);
                    CqlDateTime t_ = context.Operators.End(s_);
                    r_ = q_ & (!((bool?)(t_ is null)));
                }
                return h_ & r_;
            }
        }

        bool? d_ = context.Operators.WhereAny<Observation>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Diagnostic Report with status")]
    public bool? Diagnostic_Report_with_status(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Diagnostic_Report_with_status, Diagnostic_Report_with_status_Compute);

    private const long _cacheIndex_Diagnostic_Report_with_status = 6907193818074381608L;

    private bool? Diagnostic_Report_with_status_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Mammography(context);
        IEnumerable<DiagnosticReport> b_ = context.Operators.Retrieve<DiagnosticReport>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/DiagnosticReport"));

        bool? c_(DiagnosticReport Mammogram) {
            Code<DiagnosticReport.DiagnosticReportStatus> e_ = Mammogram?.StatusElement;
            string f_ = FHIRHelpers_4_0_001.Instance.ToString(context, e_);
            string[] g_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? h_ = context.Operators.In<string>(f_, (IEnumerable<string>)g_);
            // CQL 'and' (129:21-132:23): right operand skipped when left is false
            if (h_ is false)
            {
                return false;
            }
            else
            {
                DataType i_ = Mammogram?.Effective;
                CqlInterval<CqlDateTime> j_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, i_);
                CqlDateTime k_ = context.Operators.End(j_);
                CqlInterval<CqlDateTime> l_ = this.Measurement_Period(context);
                CqlDateTime m_ = context.Operators.End(l_);
                CqlQuantity n_ = context.Operators.Quantity(27m, "months");
                CqlDateTime o_ = context.Operators.Subtract(m_, n_);
                CqlInterval<CqlDateTime> p_ = context.Operators.Interval(o_, m_, true, true);
                bool? q_ = context.Operators.In<CqlDateTime>(k_, p_, (string)default);
                bool? r_;
                // CQL 'and' (130:27-132:23): right operand skipped when left is false
                if (q_ is false)
                {
                    r_ = false;
                }
                else
                {
                    CqlInterval<CqlDateTime> s_ = this.Measurement_Period(context);
                    CqlDateTime t_ = context.Operators.End(s_);
                    r_ = q_ & (!((bool?)(t_ is null)));
                }
                return h_ & r_;
            }
        }

        bool? d_ = context.Operators.WhereAny<DiagnosticReport>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = -57300270904157551L;

    private bool? Numerator_Compute(CqlContext context)
    {
        bool? a_ = this.Observation_with_status(context);
        // CQL 'or' (98:3-99:38): right operand skipped when left is true
        if (a_ is true)
        {
            return true;
        }
        else
        {
            bool? b_ = this.Diagnostic_Report_with_status(context);
            return a_ | b_;
        }
    }


    [CqlExpressionDefinition("Final Numerator Population")]
    public bool? Final_Numerator_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Final_Numerator_Population, Final_Numerator_Population_Compute);

    private const long _cacheIndex_Final_Numerator_Population = -3698449656444778429L;

    private bool? Final_Numerator_Population_Compute(CqlContext context)
    {
        bool? a_ = this.Numerator(context);
        bool? b_;
        // CQL 'and' (103:3-104:26): right operand skipped when left is false
        if (a_ is false)
        {
            b_ = false;
        }
        else
        {
            bool? d_ = this.Initial_Population(context);
            b_ = a_ & d_;
        }
        bool? c_;
        // CQL 'and' (103:3-105:19): right operand skipped when left is false
        if (b_ is false)
        {
            c_ = false;
        }
        else
        {
            bool? e_ = this.Denominator(context);
            c_ = b_ & e_;
        }
        // CQL 'and' (103:3-106:34): right operand skipped when left is false
        if (c_ is false)
        {
            return false;
        }
        else
        {
            bool? f_ = this.Denominator_Exclusions(context);
            return c_ & !f_;
        }
    }


    [CqlExpressionDefinition("Observation without appropriate status")]
    public bool? Observation_without_appropriate_status(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Observation_without_appropriate_status, Observation_without_appropriate_status_Compute);

    private const long _cacheIndex_Observation_without_appropriate_status = 6819886229452016587L;

    private bool? Observation_without_appropriate_status_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Mammography(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));

        bool? c_(Observation Mammogram) {
            Code<ObservationStatus> e_ = Mammogram?.StatusElement;
            string f_ = FHIRHelpers_4_0_001.Instance.ToString(context, e_);
            string[] g_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? h_ = context.Operators.In<string>(f_, (IEnumerable<string>)g_);
            bool? i_ = !h_;
            // CQL 'and' (120:21-123:23): right operand skipped when left is false
            if (i_ is false)
            {
                return false;
            }
            else
            {
                DataType j_ = Mammogram?.Effective;
                CqlInterval<CqlDateTime> k_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, j_);
                CqlDateTime l_ = context.Operators.End(k_);
                CqlInterval<CqlDateTime> m_ = this.Measurement_Period(context);
                CqlDateTime n_ = context.Operators.End(m_);
                CqlQuantity o_ = context.Operators.Quantity(27m, "months");
                CqlDateTime p_ = context.Operators.Subtract(n_, o_);
                CqlInterval<CqlDateTime> q_ = context.Operators.Interval(p_, n_, true, true);
                bool? r_ = context.Operators.In<CqlDateTime>(l_, q_, (string)default);
                bool? s_;
                // CQL 'and' (121:27-123:23): right operand skipped when left is false
                if (r_ is false)
                {
                    s_ = false;
                }
                else
                {
                    CqlInterval<CqlDateTime> t_ = this.Measurement_Period(context);
                    CqlDateTime u_ = context.Operators.End(t_);
                    s_ = r_ & (!((bool?)(u_ is null)));
                }
                return i_ & s_;
            }
        }

        bool? d_ = context.Operators.WhereAny<Observation>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Diagnostic Report without appropriate status")]
    public bool? Diagnostic_Report_without_appropriate_status(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Diagnostic_Report_without_appropriate_status, Diagnostic_Report_without_appropriate_status_Compute);

    private const long _cacheIndex_Diagnostic_Report_without_appropriate_status = -7830090240520039054L;

    private bool? Diagnostic_Report_without_appropriate_status_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Mammography(context);
        IEnumerable<DiagnosticReport> b_ = context.Operators.Retrieve<DiagnosticReport>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/DiagnosticReport"));

        bool? c_(DiagnosticReport Mammogram) {
            Code<DiagnosticReport.DiagnosticReportStatus> e_ = Mammogram?.StatusElement;
            string f_ = FHIRHelpers_4_0_001.Instance.ToString(context, e_);
            string[] g_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? h_ = context.Operators.In<string>(f_, (IEnumerable<string>)g_);
            bool? i_ = !h_;
            // CQL 'and' (138:21-141:23): right operand skipped when left is false
            if (i_ is false)
            {
                return false;
            }
            else
            {
                DataType j_ = Mammogram?.Effective;
                CqlInterval<CqlDateTime> k_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, j_);
                CqlDateTime l_ = context.Operators.End(k_);
                CqlInterval<CqlDateTime> m_ = this.Measurement_Period(context);
                CqlDateTime n_ = context.Operators.End(m_);
                CqlQuantity o_ = context.Operators.Quantity(27m, "months");
                CqlDateTime p_ = context.Operators.Subtract(n_, o_);
                CqlInterval<CqlDateTime> q_ = context.Operators.Interval(p_, n_, true, true);
                bool? r_ = context.Operators.In<CqlDateTime>(l_, q_, (string)default);
                bool? s_;
                // CQL 'and' (139:27-141:23): right operand skipped when left is false
                if (r_ is false)
                {
                    s_ = false;
                }
                else
                {
                    CqlInterval<CqlDateTime> t_ = this.Measurement_Period(context);
                    CqlDateTime u_ = context.Operators.End(t_);
                    s_ = r_ & (!((bool?)(u_ is null)));
                }
                return i_ & s_;
            }
        }

        bool? d_ = context.Operators.WhereAny<DiagnosticReport>(b_, c_);
        return d_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private BreastCancerScreeningsFHIR_0_0_009() {}

    public static BreastCancerScreeningsFHIR_0_0_009 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "BreastCancerScreeningsFHIR";
    public string Version => "0.0.009";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_001.Instance, SupplementalDataElementsFHIR4_2_0_000.Instance, MATGlobalCommonFunctionsFHIR4_6_1_000.Instance, AdultOutpatientEncountersFHIR4_2_2_000.Instance, AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance, PalliativeCareFHIR_0_6_000.Instance, CumulativeMedicationDurationFHIR4_1_0_000.Instance, HospiceFHIR4_2_3_000.Instance];

    #endregion ILibrary Implementation

}
