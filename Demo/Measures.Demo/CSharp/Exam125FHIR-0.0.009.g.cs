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
[CqlLibrary("Exam125FHIR", "0.0.009")]
public partial class Exam125FHIR_0_0_009 : ILibrary, ISingleton<Exam125FHIR_0_0_009>
{
    private Exam125FHIR_0_0_009() {}

    public static Exam125FHIR_0_0_009 Instance { get; } = new();

    #region Library Members
    public string Name => "Exam125FHIR";
    public string Version => "0.0.009";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_001.Instance, SupplementalDataElementsFHIR4_2_0_000.Instance, MATGlobalCommonFunctionsFHIR4_6_1_000.Instance, AdultOutpatientEncountersFHIR4_2_2_000.Instance, AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance, PalliativeCareFHIR_0_6_000.Instance, CumulativeMedicationDurationFHIR4_1_0_000.Instance, HospiceFHIR4_2_3_000.Instance];
    #endregion Library Members

    [CqlDeclaration("Bilateral Mastectomy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1005")]
    public CqlValueSet Bilateral_Mastectomy(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1005", default);


    [CqlDeclaration("History of bilateral mastectomy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1068")]
    public CqlValueSet History_of_bilateral_mastectomy(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1068", default);


    [CqlDeclaration("Left")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.122.12.1036")]
    public CqlValueSet Left(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.122.12.1036", default);


    [CqlDeclaration("Mammography")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.11.1047")]
    public CqlValueSet Mammography(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.11.1047", default);


    [CqlDeclaration("Online Assessments")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089")]
    public CqlValueSet Online_Assessments(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", default);


    [CqlDeclaration("Right")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.122.12.1035")]
    public CqlValueSet Right(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.122.12.1035", default);


    [CqlDeclaration("Status Post Left Mastectomy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1069")]
    public CqlValueSet Status_Post_Left_Mastectomy(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1069", default);


    [CqlDeclaration("Status Post Right Mastectomy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1070")]
    public CqlValueSet Status_Post_Right_Mastectomy(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1070", default);


    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
    public CqlValueSet Telephone_Visits(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", default);


    [CqlDeclaration("Unilateral Mastectomy Left")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1133")]
    public CqlValueSet Unilateral_Mastectomy_Left(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1133", default);


    [CqlDeclaration("Unilateral Mastectomy Right")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1134")]
    public CqlValueSet Unilateral_Mastectomy_Right(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1134", default);


    [CqlDeclaration("Unilateral Mastectomy, Unspecified Laterality")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1071")]
    public CqlValueSet Unilateral_Mastectomy__Unspecified_Laterality(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1071", default);


    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2021, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime b_ = context.Operators.DateTime(2022, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("Exam125FHIR-0.0.009", "Measurement Period", c_);

        return (CqlInterval<CqlDateTime>)d_;
    }


    [CqlDeclaration("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

        return b_;
    }


    [CqlDeclaration("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Coding> a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

        return a_;
    }


    [CqlDeclaration("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

        return a_;
    }


    [CqlDeclaration("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Coding> a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

        return a_;
    }


    [CqlDeclaration("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

        return a_;
    }


    [CqlDeclaration("Telehealth Services")]
    public IEnumerable<Encounter> Telehealth_Services(CqlContext context)
    {
        CqlValueSet a_ = this.Online_Assessments(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        CqlValueSet c_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
        bool? f_(Encounter TelehealthEncounter)
        {
            Code<Encounter.EncounterStatus> h_ = TelehealthEncounter?.StatusElement;
            string i_ = FHIRHelpers_4_0_001.Instance.ToString(context, h_);
            bool? j_ = context.Operators.Equal(i_, "finished");
            CqlInterval<CqlDateTime> k_ = this.Measurement_Period(context);
            Period l_ = TelehealthEncounter?.Period;
            CqlInterval<CqlDateTime> m_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, l_ as object);
            bool? n_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(k_, m_, default);
            bool? o_ = context.Operators.And(j_, n_);

            return o_;
        };
        IEnumerable<Encounter> g_ = context.Operators.Where<Encounter>(e_, f_);

        return g_;
    }


    [CqlDeclaration("Age at start of Measurement Period")]
    public int? Age_at_start_of_Measurement_Period(CqlContext context)
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
        CqlInterval<int?> i_ = context.Operators.Interval(51, 74, true, false);
        bool? j_ = context.Operators.In<int?>(h_, i_, default);
        Code<AdministrativeGender> l_ = a_?.GenderElement;
        string m_ = FHIRHelpers_4_0_001.Instance.ToString(context, l_);
        bool? n_ = context.Operators.Equal(m_, "female");
        bool? o_ = context.Operators.And(j_, n_);
        IEnumerable<Encounter> p_ = AdultOutpatientEncountersFHIR4_2_2_000.Instance.Qualifying_Encounters(context);
        IEnumerable<Encounter> q_ = this.Telehealth_Services(context);
        IEnumerable<Encounter> r_ = context.Operators.Union<Encounter>(p_, q_);
        bool? s_ = context.Operators.Exists<Encounter>(r_);
        bool? t_ = context.Operators.And(o_, s_);

        return t_;
    }


    [CqlDeclaration("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);

        return a_;
    }


    [CqlDeclaration("Right Mastectomy Diagnosis")]
    public IEnumerable<Condition> Right_Mastectomy_Diagnosis(CqlContext context)
    {
        CqlValueSet a_ = this.Status_Post_Right_Mastectomy(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        CqlValueSet c_ = this.Unilateral_Mastectomy__Unspecified_Laterality(context);
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? e_(Condition UnilateralMastectomyDiagnosis)
        {
            List<CodeableConcept> j_ = UnilateralMastectomyDiagnosis?.BodySite;
            CqlConcept k_(CodeableConcept X)
            {
                CqlConcept o_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

                return o_;
            };
            IEnumerable<CqlConcept> l_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)j_, k_);
            CqlValueSet m_ = this.Right(context);
            bool? n_ = context.Operators.ConceptsInValueSet(l_, m_);

            return n_;
        };
        IEnumerable<Condition> f_ = context.Operators.Where<Condition>(d_, e_);
        IEnumerable<Condition> g_ = context.Operators.Union<Condition>(b_, f_);
        bool? h_(Condition RightMastectomy)
        {
            CqlInterval<CqlDateTime> p_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, RightMastectomy);
            CqlDateTime q_ = context.Operators.Start(p_);
            CqlInterval<CqlDateTime> r_ = this.Measurement_Period(context);
            CqlDateTime s_ = context.Operators.End(r_);
            bool? t_ = context.Operators.SameOrBefore(q_, s_, default);

            return t_;
        };
        IEnumerable<Condition> i_ = context.Operators.Where<Condition>(g_, h_);

        return i_;
    }


    [CqlDeclaration("Right Mastectomy Procedure")]
    public IEnumerable<Procedure> Right_Mastectomy_Procedure(CqlContext context)
    {
        CqlValueSet a_ = this.Unilateral_Mastectomy_Right(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? c_(Procedure UnilateralMastectomyRightPerformed)
        {
            Code<EventStatus> e_ = UnilateralMastectomyRightPerformed?.StatusElement;
            string f_ = FHIRHelpers_4_0_001.Instance.ToString(context, e_);
            bool? g_ = context.Operators.Equal(f_, "completed");
            DataType h_ = UnilateralMastectomyRightPerformed?.Performed;
            CqlInterval<CqlDateTime> i_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, h_);
            CqlDateTime j_ = context.Operators.End(i_);
            CqlInterval<CqlDateTime> k_ = this.Measurement_Period(context);
            CqlDateTime l_ = context.Operators.End(k_);
            bool? m_ = context.Operators.SameOrBefore(j_, l_, default);
            bool? n_ = context.Operators.And(g_, m_);

            return n_;
        };
        IEnumerable<Procedure> d_ = context.Operators.Where<Procedure>(b_, c_);

        return d_;
    }


    [CqlDeclaration("Left Mastectomy Diagnosis")]
    public IEnumerable<Condition> Left_Mastectomy_Diagnosis(CqlContext context)
    {
        CqlValueSet a_ = this.Status_Post_Left_Mastectomy(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        CqlValueSet c_ = this.Unilateral_Mastectomy__Unspecified_Laterality(context);
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? e_(Condition UnilateralMastectomyDiagnosis)
        {
            List<CodeableConcept> j_ = UnilateralMastectomyDiagnosis?.BodySite;
            CqlConcept k_(CodeableConcept X)
            {
                CqlConcept o_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);

                return o_;
            };
            IEnumerable<CqlConcept> l_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)j_, k_);
            CqlValueSet m_ = this.Left(context);
            bool? n_ = context.Operators.ConceptsInValueSet(l_, m_);

            return n_;
        };
        IEnumerable<Condition> f_ = context.Operators.Where<Condition>(d_, e_);
        IEnumerable<Condition> g_ = context.Operators.Union<Condition>(b_, f_);
        bool? h_(Condition LeftMastectomy)
        {
            CqlInterval<CqlDateTime> p_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, LeftMastectomy);
            CqlDateTime q_ = context.Operators.Start(p_);
            CqlInterval<CqlDateTime> r_ = this.Measurement_Period(context);
            CqlDateTime s_ = context.Operators.End(r_);
            bool? t_ = context.Operators.SameOrBefore(q_, s_, default);

            return t_;
        };
        IEnumerable<Condition> i_ = context.Operators.Where<Condition>(g_, h_);

        return i_;
    }


    [CqlDeclaration("Left Mastectomy Procedure")]
    public IEnumerable<Procedure> Left_Mastectomy_Procedure(CqlContext context)
    {
        CqlValueSet a_ = this.Unilateral_Mastectomy_Left(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? c_(Procedure UnilateralMastectomyLeftPerformed)
        {
            Code<EventStatus> e_ = UnilateralMastectomyLeftPerformed?.StatusElement;
            string f_ = FHIRHelpers_4_0_001.Instance.ToString(context, e_);
            bool? g_ = context.Operators.Equal(f_, "completed");
            DataType h_ = UnilateralMastectomyLeftPerformed?.Performed;
            CqlInterval<CqlDateTime> i_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, h_);
            CqlDateTime j_ = context.Operators.End(i_);
            CqlInterval<CqlDateTime> k_ = this.Measurement_Period(context);
            CqlDateTime l_ = context.Operators.End(k_);
            bool? m_ = context.Operators.SameOrBefore(j_, l_, default);
            bool? n_ = context.Operators.And(g_, m_);

            return n_;
        };
        IEnumerable<Procedure> d_ = context.Operators.Where<Procedure>(b_, c_);

        return d_;
    }


    [CqlDeclaration("Bilateral Mastectomy Diagnosis")]
    public IEnumerable<Condition> Bilateral_Mastectomy_Diagnosis(CqlContext context)
    {
        CqlValueSet a_ = this.History_of_bilateral_mastectomy(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
        bool? c_(Condition BilateralMastectomyHistory)
        {
            CqlInterval<CqlDateTime> e_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, BilateralMastectomyHistory);
            CqlDateTime f_ = context.Operators.Start(e_);
            CqlInterval<CqlDateTime> g_ = this.Measurement_Period(context);
            CqlDateTime h_ = context.Operators.End(g_);
            bool? i_ = context.Operators.SameOrBefore(f_, h_, default);

            return i_;
        };
        IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);

        return d_;
    }


    [CqlDeclaration("Bilateral Mastectomy Procedure")]
    public IEnumerable<Procedure> Bilateral_Mastectomy_Procedure(CqlContext context)
    {
        CqlValueSet a_ = this.Bilateral_Mastectomy(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
        bool? c_(Procedure BilateralMastectomyPerformed)
        {
            Code<EventStatus> e_ = BilateralMastectomyPerformed?.StatusElement;
            string f_ = FHIRHelpers_4_0_001.Instance.ToString(context, e_);
            bool? g_ = context.Operators.Equal(f_, "completed");
            DataType h_ = BilateralMastectomyPerformed?.Performed;
            CqlInterval<CqlDateTime> i_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, h_);
            CqlDateTime j_ = context.Operators.End(i_);
            CqlInterval<CqlDateTime> k_ = this.Measurement_Period(context);
            CqlDateTime l_ = context.Operators.End(k_);
            bool? m_ = context.Operators.SameOrBefore(j_, l_, default);
            bool? n_ = context.Operators.And(g_, m_);

            return n_;
        };
        IEnumerable<Procedure> d_ = context.Operators.Where<Procedure>(b_, c_);

        return d_;
    }


    [CqlDeclaration("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context)
    {
        bool? a_ = HospiceFHIR4_2_3_000.Instance.Has_Hospice(context);
        IEnumerable<Condition> b_ = this.Right_Mastectomy_Diagnosis(context);
        bool? c_ = context.Operators.Exists<Condition>(b_);
        IEnumerable<Procedure> d_ = this.Right_Mastectomy_Procedure(context);
        bool? e_ = context.Operators.Exists<Procedure>(d_);
        bool? f_ = context.Operators.Or(c_, e_);
        IEnumerable<Condition> g_ = this.Left_Mastectomy_Diagnosis(context);
        bool? h_ = context.Operators.Exists<Condition>(g_);
        IEnumerable<Procedure> i_ = this.Left_Mastectomy_Procedure(context);
        bool? j_ = context.Operators.Exists<Procedure>(i_);
        bool? k_ = context.Operators.Or(h_, j_);
        bool? l_ = context.Operators.And(f_, k_);
        bool? m_ = context.Operators.Or(a_, l_);
        IEnumerable<Condition> n_ = this.Bilateral_Mastectomy_Diagnosis(context);
        bool? o_ = context.Operators.Exists<Condition>(n_);
        bool? p_ = context.Operators.Or(m_, o_);
        IEnumerable<Procedure> q_ = this.Bilateral_Mastectomy_Procedure(context);
        bool? r_ = context.Operators.Exists<Procedure>(q_);
        bool? s_ = context.Operators.Or(p_, r_);
        bool? t_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance.Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80(context);
        bool? u_ = context.Operators.Or(s_, t_);
        Patient v_ = this.Patient(context);
        Date w_ = v_?.BirthDateElement;
        string x_ = w_?.Value;
        CqlDate y_ = context.Operators.ConvertStringToDate(x_);
        CqlInterval<CqlDateTime> z_ = this.Measurement_Period(context);
        CqlDateTime aa_ = context.Operators.Start(z_);
        CqlDate ab_ = context.Operators.DateFrom(aa_);
        int? ac_ = context.Operators.CalculateAgeAt(y_, ab_, "year");
        bool? ad_ = context.Operators.GreaterOrEqual(ac_, 65);
        bool? ae_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Instance.Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days(context);
        bool? af_ = context.Operators.And(ad_, ae_);
        bool? ag_ = context.Operators.Or(u_, af_);
        bool? ah_ = PalliativeCareFHIR_0_6_000.Instance.Palliative_Care_in_the_Measurement_Period(context);
        bool? ai_ = context.Operators.Or(ag_, ah_);

        return ai_;
    }


    [CqlDeclaration("Observation with status")]
    public bool? Observation_with_status(CqlContext context)
    {
        CqlValueSet a_ = this.Mammography(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? c_(Observation Mammogram)
        {
            Code<ObservationStatus> f_ = Mammogram?.StatusElement;
            string g_ = FHIRHelpers_4_0_001.Instance.ToString(context, f_);
            string[] h_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? i_ = context.Operators.In<string>(g_, h_ as IEnumerable<string>);
            DataType j_ = Mammogram?.Effective;
            CqlInterval<CqlDateTime> k_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, j_);
            CqlDateTime l_ = context.Operators.End(k_);
            CqlInterval<CqlDateTime> m_ = this.Measurement_Period(context);
            CqlDateTime n_ = context.Operators.End(m_);
            CqlQuantity o_ = context.Operators.Quantity(27m, "months");
            CqlDateTime p_ = context.Operators.Subtract(n_, o_);
            CqlDateTime r_ = context.Operators.End(m_);
            CqlInterval<CqlDateTime> s_ = context.Operators.Interval(p_, r_, true, true);
            bool? t_ = context.Operators.In<CqlDateTime>(l_, s_, default);
            CqlDateTime v_ = context.Operators.End(m_);
            bool? w_ = context.Operators.Not((bool?)(v_ is null));
            bool? x_ = context.Operators.And(t_, w_);
            bool? y_ = context.Operators.And(i_, x_);

            return y_;
        };
        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
        bool? e_ = context.Operators.Exists<Observation>(d_);

        return e_;
    }


    [CqlDeclaration("Diagnostic Report with status")]
    public bool? Diagnostic_Report_with_status(CqlContext context)
    {
        CqlValueSet a_ = this.Mammography(context);
        IEnumerable<DiagnosticReport> b_ = context.Operators.Retrieve<DiagnosticReport>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/DiagnosticReport"));
        bool? c_(DiagnosticReport Mammogram)
        {
            Code<DiagnosticReport.DiagnosticReportStatus> f_ = Mammogram?.StatusElement;
            string g_ = FHIRHelpers_4_0_001.Instance.ToString(context, f_);
            string[] h_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? i_ = context.Operators.In<string>(g_, h_ as IEnumerable<string>);
            DataType j_ = Mammogram?.Effective;
            CqlInterval<CqlDateTime> k_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, j_);
            CqlDateTime l_ = context.Operators.End(k_);
            CqlInterval<CqlDateTime> m_ = this.Measurement_Period(context);
            CqlDateTime n_ = context.Operators.End(m_);
            CqlQuantity o_ = context.Operators.Quantity(27m, "months");
            CqlDateTime p_ = context.Operators.Subtract(n_, o_);
            CqlDateTime r_ = context.Operators.End(m_);
            CqlInterval<CqlDateTime> s_ = context.Operators.Interval(p_, r_, true, true);
            bool? t_ = context.Operators.In<CqlDateTime>(l_, s_, default);
            CqlDateTime v_ = context.Operators.End(m_);
            bool? w_ = context.Operators.Not((bool?)(v_ is null));
            bool? x_ = context.Operators.And(t_, w_);
            bool? y_ = context.Operators.And(i_, x_);

            return y_;
        };
        IEnumerable<DiagnosticReport> d_ = context.Operators.Where<DiagnosticReport>(b_, c_);
        bool? e_ = context.Operators.Exists<DiagnosticReport>(d_);

        return e_;
    }


    [CqlDeclaration("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? a_ = this.Observation_with_status(context);
        bool? b_ = this.Diagnostic_Report_with_status(context);
        bool? c_ = context.Operators.Or(a_, b_);

        return c_;
    }


    [CqlDeclaration("Final Numerator Population")]
    public bool? Final_Numerator_Population(CqlContext context)
    {
        bool? a_ = this.Numerator(context);
        bool? b_ = this.Initial_Population(context);
        bool? c_ = context.Operators.And(a_, b_);
        bool? d_ = this.Denominator(context);
        bool? e_ = context.Operators.And(c_, d_);
        bool? f_ = this.Denominator_Exclusions(context);
        bool? g_ = context.Operators.Not(f_);
        bool? h_ = context.Operators.And(e_, g_);

        return h_;
    }


    [CqlDeclaration("Observation without appropriate status")]
    public bool? Observation_without_appropriate_status(CqlContext context)
    {
        CqlValueSet a_ = this.Mammography(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
        bool? c_(Observation Mammogram)
        {
            Code<ObservationStatus> f_ = Mammogram?.StatusElement;
            string g_ = FHIRHelpers_4_0_001.Instance.ToString(context, f_);
            string[] h_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? i_ = context.Operators.In<string>(g_, h_ as IEnumerable<string>);
            bool? j_ = context.Operators.Not(i_);
            DataType k_ = Mammogram?.Effective;
            CqlInterval<CqlDateTime> l_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, k_);
            CqlDateTime m_ = context.Operators.End(l_);
            CqlInterval<CqlDateTime> n_ = this.Measurement_Period(context);
            CqlDateTime o_ = context.Operators.End(n_);
            CqlQuantity p_ = context.Operators.Quantity(27m, "months");
            CqlDateTime q_ = context.Operators.Subtract(o_, p_);
            CqlDateTime s_ = context.Operators.End(n_);
            CqlInterval<CqlDateTime> t_ = context.Operators.Interval(q_, s_, true, true);
            bool? u_ = context.Operators.In<CqlDateTime>(m_, t_, default);
            CqlDateTime w_ = context.Operators.End(n_);
            bool? x_ = context.Operators.Not((bool?)(w_ is null));
            bool? y_ = context.Operators.And(u_, x_);
            bool? z_ = context.Operators.And(j_, y_);

            return z_;
        };
        IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
        bool? e_ = context.Operators.Exists<Observation>(d_);

        return e_;
    }


    [CqlDeclaration("Diagnostic Report without appropriate status")]
    public bool? Diagnostic_Report_without_appropriate_status(CqlContext context)
    {
        CqlValueSet a_ = this.Mammography(context);
        IEnumerable<DiagnosticReport> b_ = context.Operators.Retrieve<DiagnosticReport>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/DiagnosticReport"));
        bool? c_(DiagnosticReport Mammogram)
        {
            Code<DiagnosticReport.DiagnosticReportStatus> f_ = Mammogram?.StatusElement;
            string g_ = FHIRHelpers_4_0_001.Instance.ToString(context, f_);
            string[] h_ = [
                "final",
                "amended",
                "corrected",
                "appended",
            ];
            bool? i_ = context.Operators.In<string>(g_, h_ as IEnumerable<string>);
            bool? j_ = context.Operators.Not(i_);
            DataType k_ = Mammogram?.Effective;
            CqlInterval<CqlDateTime> l_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, k_);
            CqlDateTime m_ = context.Operators.End(l_);
            CqlInterval<CqlDateTime> n_ = this.Measurement_Period(context);
            CqlDateTime o_ = context.Operators.End(n_);
            CqlQuantity p_ = context.Operators.Quantity(27m, "months");
            CqlDateTime q_ = context.Operators.Subtract(o_, p_);
            CqlDateTime s_ = context.Operators.End(n_);
            CqlInterval<CqlDateTime> t_ = context.Operators.Interval(q_, s_, true, true);
            bool? u_ = context.Operators.In<CqlDateTime>(m_, t_, default);
            CqlDateTime w_ = context.Operators.End(n_);
            bool? x_ = context.Operators.Not((bool?)(w_ is null));
            bool? y_ = context.Operators.And(u_, x_);
            bool? z_ = context.Operators.And(j_, y_);

            return z_;
        };
        IEnumerable<DiagnosticReport> d_ = context.Operators.Where<DiagnosticReport>(b_, c_);
        bool? e_ = context.Operators.Exists<DiagnosticReport>(d_);

        return e_;
    }

}
