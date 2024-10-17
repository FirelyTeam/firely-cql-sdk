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
[CqlLibrary("DiabetesEyeExamFHIR", "0.0.001")]
public partial class DiabetesEyeExamFHIR_0_0_001 : ILibrary, ISingleton<DiabetesEyeExamFHIR_0_0_001>
{
    private DiabetesEyeExamFHIR_0_0_001() {}

    public static DiabetesEyeExamFHIR_0_0_001 Instance { get; } = new();

    #region Library Members
    public string Name => "DiabetesEyeExamFHIR";
    public string Version => "0.0.001";
    public ILibrary[] Dependencies => [FHIRHelpers_4_3_000.Instance, SupplementalDataElements_3_4_000.Instance, QICoreCommon_2_0_000.Instance, CQMCommon_2_0_000.Instance, Hospice_6_9_000.Instance, Status_1_6_000.Instance, PalliativeCare_1_9_000.Instance, AdvancedIllnessandFrailty_1_8_000.Instance];
    #endregion Library Members

    [CqlDeclaration("Annual Wellness Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240")]
    public CqlValueSet Annual_Wellness_Visit(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", default);


    [CqlDeclaration("Diabetes")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001")]
    public CqlValueSet Diabetes(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001", default);


    [CqlDeclaration("Diabetic Retinopathy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.327")]
    public CqlValueSet Diabetic_Retinopathy(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.327", default);


    [CqlDeclaration("Discharged to Health Care Facility for Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207")]
    public CqlValueSet Discharged_to_Health_Care_Facility_for_Hospice_Care(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207", default);


    [CqlDeclaration("Discharged to Home for Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209")]
    public CqlValueSet Discharged_to_Home_for_Hospice_Care(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209", default);


    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
    public CqlValueSet Encounter_Inpatient(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", default);


    [CqlDeclaration("Home Healthcare Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016")]
    public CqlValueSet Home_Healthcare_Services(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", default);


    [CqlDeclaration("Hospice Care Ambulatory")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15")]
    public CqlValueSet Hospice_Care_Ambulatory(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15", default);


    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
    public CqlValueSet Office_Visit(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", default);


    [CqlDeclaration("Ophthalmological Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285")]
    public CqlValueSet Ophthalmological_Services(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285", default);


    [CqlDeclaration("Preventive Care Services Established Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025")]
    public CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", default);


    [CqlDeclaration("Preventive Care Services Initial Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023")]
    public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", default);


    [CqlDeclaration("Retinal or Dilated Eye Exam")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.115.12.1088")]
    public CqlValueSet Retinal_or_Dilated_Eye_Exam(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.115.12.1088", default);


    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
    public CqlValueSet Telephone_Visits(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", default);


    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("DiabetesEyeExamFHIR-0.0.001", "Measurement Period", c_);

        return (CqlInterval<CqlDateTime>)d_;
    }


    [CqlDeclaration("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

        return b_;
    }


    [CqlDeclaration("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
    {
        CqlValueSet a_ = this.Office_Visit(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet c_ = this.Annual_Wellness_Visit(context);
        IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
        CqlValueSet f_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet h_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
        IEnumerable<Encounter> i_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
        IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
        CqlValueSet l_ = this.Home_Healthcare_Services(context);
        IEnumerable<Encounter> m_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet n_ = this.Ophthalmological_Services(context);
        IEnumerable<Encounter> o_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> p_ = context.Operators.Union<Encounter>(m_, o_);
        IEnumerable<Encounter> q_ = context.Operators.Union<Encounter>(k_, p_);
        CqlValueSet r_ = this.Telephone_Visits(context);
        IEnumerable<Encounter> s_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> t_ = context.Operators.Union<Encounter>(q_, s_);
        IEnumerable<Encounter> u_ = Status_1_6_000.Instance.isEncounterPerformed(context, t_);
        bool? v_(Encounter ValidEncounters)
        {
            CqlInterval<CqlDateTime> x_ = this.Measurement_Period(context);
            Period y_ = ValidEncounters?.Period;
            CqlInterval<CqlDateTime> z_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, y_);
            bool? aa_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(x_, z_, "day");

            return aa_;
        };
        IEnumerable<Encounter> w_ = context.Operators.Where<Encounter>(u_, v_);

        return w_;
    }


    [CqlDeclaration("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Date b_ = a_?.BirthDateElement;
        string c_ = b_?.Value;
        CqlDate d_ = context.Operators.ConvertStringToDate(c_);
        CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
        CqlDateTime f_ = context.Operators.End(e_);
        CqlDate g_ = context.Operators.DateFrom(f_);
        int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
        CqlInterval<int?> i_ = context.Operators.Interval(18, 75, true, true);
        bool? j_ = context.Operators.In<int?>(h_, i_, default);
        IEnumerable<Encounter> k_ = this.Qualifying_Encounters(context);
        bool? l_ = context.Operators.Exists<Encounter>(k_);
        bool? m_ = context.Operators.And(j_, l_);
        CqlValueSet n_ = this.Diabetes(context);
        IEnumerable<Condition> o_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? p_(Condition Diabetes)
        {
            CqlInterval<CqlDateTime> t_ = QICoreCommon_2_0_000.Instance.prevalenceInterval(context, Diabetes);
            CqlInterval<CqlDateTime> u_ = this.Measurement_Period(context);
            bool? v_ = context.Operators.Overlaps(t_, u_, default);

            return v_;
        };
        IEnumerable<Condition> q_ = context.Operators.Where<Condition>(o_, p_);
        bool? r_ = context.Operators.Exists<Condition>(q_);
        bool? s_ = context.Operators.And(m_, r_);

        return s_;
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
        bool? b_ = AdvancedIllnessandFrailty_1_8_000.Instance.Is_Age_66_or_Older_with_Advanced_Illness_and_Frailty(context);
        bool? c_ = context.Operators.Or(a_, b_);
        bool? d_ = AdvancedIllnessandFrailty_1_8_000.Instance.Is_Age_66_or_Older_Living_Long_Term_in_a_Nursing_Home(context);
        bool? e_ = context.Operators.Or(c_, d_);
        bool? f_ = PalliativeCare_1_9_000.Instance.Has_Palliative_Care_in_the_Measurement_Period(context);
        bool? g_ = context.Operators.Or(e_, f_);

        return g_;
    }


    [CqlDeclaration("Diabetic Retinopathy Overlapping Measurement Period")]
    public bool? Diabetic_Retinopathy_Overlapping_Measurement_Period(CqlContext context)
    {
        CqlValueSet a_ = this.Diabetic_Retinopathy(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? c_(Condition Retinopathy)
        {
            CqlInterval<CqlDateTime> f_ = QICoreCommon_2_0_000.Instance.prevalenceInterval(context, Retinopathy);
            CqlInterval<CqlDateTime> g_ = this.Measurement_Period(context);
            bool? h_ = context.Operators.Overlaps(f_, g_, default);

            return h_;
        };
        IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
        bool? e_ = context.Operators.Exists<Condition>(d_);

        return e_;
    }


    [CqlDeclaration("Retinal Exam in Measurement Period")]
    public IEnumerable<Observation> Retinal_Exam_in_Measurement_Period(CqlContext context)
    {
        CqlValueSet a_ = this.Retinal_or_Dilated_Eye_Exam(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> c_ = Status_1_6_000.Instance.isAssessmentPerformed(context, b_);
        bool? d_(Observation RetinalExam)
        {
            CqlInterval<CqlDateTime> f_ = this.Measurement_Period(context);
            DataType g_ = RetinalExam?.Effective;
            object h_ = FHIRHelpers_4_3_000.Instance.ToValue(context, g_);
            CqlInterval<CqlDateTime> i_ = QICoreCommon_2_0_000.Instance.toInterval(context, h_);
            bool? j_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(f_, i_, "day");

            return j_;
        };
        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

        return e_;
    }


    [CqlDeclaration("Retinal Exam in Measurement Period or Year Prior")]
    public IEnumerable<Observation> Retinal_Exam_in_Measurement_Period_or_Year_Prior(CqlContext context)
    {
        CqlValueSet a_ = this.Retinal_or_Dilated_Eye_Exam(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> c_ = Status_1_6_000.Instance.isAssessmentPerformed(context, b_);
        bool? d_(Observation RetinalExam)
        {
            CqlInterval<CqlDateTime> f_ = this.Measurement_Period(context);
            CqlDateTime g_ = context.Operators.Start(f_);
            CqlQuantity h_ = context.Operators.Quantity(1m, "year");
            CqlDateTime i_ = context.Operators.Subtract(g_, h_);
            CqlDateTime k_ = context.Operators.End(f_);
            CqlInterval<CqlDateTime> l_ = context.Operators.Interval(i_, k_, true, true);
            DataType m_ = RetinalExam?.Effective;
            object n_ = FHIRHelpers_4_3_000.Instance.ToValue(context, m_);
            CqlInterval<CqlDateTime> o_ = QICoreCommon_2_0_000.Instance.toInterval(context, n_);
            bool? p_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(l_, o_, "day");

            return p_;
        };
        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

        return e_;
    }


    [CqlDeclaration("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? a_ = this.Diabetic_Retinopathy_Overlapping_Measurement_Period(context);
        IEnumerable<Observation> b_ = this.Retinal_Exam_in_Measurement_Period(context);
        bool? c_ = context.Operators.Exists<Observation>(b_);
        bool? d_ = context.Operators.And(a_, c_);
        bool? f_ = context.Operators.Not(a_);
        IEnumerable<Observation> g_ = this.Retinal_Exam_in_Measurement_Period_or_Year_Prior(context);
        bool? h_ = context.Operators.Exists<Observation>(g_);
        bool? i_ = context.Operators.And(f_, h_);
        bool? j_ = context.Operators.Or(d_, i_);

        return j_;
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

}
