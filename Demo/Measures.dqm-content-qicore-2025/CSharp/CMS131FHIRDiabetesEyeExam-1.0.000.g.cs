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
using Hl7.Cql.Runtime.Internal;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "6.0.0.0")]
[CqlLibrary("CMS131FHIRDiabetesEyeExam", "1.0.000")]
public partial class CMS131FHIRDiabetesEyeExam_1_0_000 : ILibrary, ILibraryInternals, ISingleton<CMS131FHIRDiabetesEyeExam_1_0_000>
{
    #region ValueSets (12)

    [CqlValueSetDefinition("Annual Wellness Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", valueSetVersion: null)]
    public CqlValueSet Annual_Wellness_Visit(CqlContext _) => _Annual_Wellness_Visit;
    private static readonly CqlValueSet _Annual_Wellness_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", null);

    [CqlValueSetDefinition("Autonomous Eye Exam Result or Finding", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1004.2616", valueSetVersion: null)]
    public CqlValueSet Autonomous_Eye_Exam_Result_or_Finding(CqlContext _) => _Autonomous_Eye_Exam_Result_or_Finding;
    private static readonly CqlValueSet _Autonomous_Eye_Exam_Result_or_Finding = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1004.2616", null);

    [CqlValueSetDefinition("Diabetes", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001", valueSetVersion: null)]
    public CqlValueSet Diabetes(CqlContext _) => _Diabetes;
    private static readonly CqlValueSet _Diabetes = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001", null);

    [CqlValueSetDefinition("Diabetic Retinopathy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.327", valueSetVersion: null)]
    public CqlValueSet Diabetic_Retinopathy(CqlContext _) => _Diabetic_Retinopathy;
    private static readonly CqlValueSet _Diabetic_Retinopathy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.327", null);

    [CqlValueSetDefinition("Diabetic Retinopathy Severity Level", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1266", valueSetVersion: null)]
    public CqlValueSet Diabetic_Retinopathy_Severity_Level(CqlContext _) => _Diabetic_Retinopathy_Severity_Level;
    private static readonly CqlValueSet _Diabetic_Retinopathy_Severity_Level = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1266", null);

    [CqlValueSetDefinition("Home Healthcare Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", valueSetVersion: null)]
    public CqlValueSet Home_Healthcare_Services(CqlContext _) => _Home_Healthcare_Services;
    private static readonly CqlValueSet _Home_Healthcare_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);

    [CqlValueSetDefinition("Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext _) => _Office_Visit;
    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlValueSetDefinition("Ophthalmological Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285", valueSetVersion: null)]
    public CqlValueSet Ophthalmological_Services(CqlContext _) => _Ophthalmological_Services;
    private static readonly CqlValueSet _Ophthalmological_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285", null);

    [CqlValueSetDefinition("Preventive Care Services Established Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services_Established_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services_Established_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);

    [CqlValueSetDefinition("Preventive Care Services Initial Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services_Initial_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services_Initial_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);

    [CqlValueSetDefinition("Retinal or Dilated Eye Exam", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.115.12.1088", valueSetVersion: null)]
    public CqlValueSet Retinal_or_Dilated_Eye_Exam(CqlContext _) => _Retinal_or_Dilated_Eye_Exam;
    private static readonly CqlValueSet _Retinal_or_Dilated_Eye_Exam = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.115.12.1088", null);

    [CqlValueSetDefinition("Telephone Visits", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", valueSetVersion: null)]
    public CqlValueSet Telephone_Visits(CqlContext _) => _Telephone_Visits;
    private static readonly CqlValueSet _Telephone_Visits = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    #endregion ValueSets

    #region Codes (5)

    [CqlCodeDefinition("Anophthalmos of bilateral eyes (disorder)", codeId: "15665641000119103", codeSystem: "http://snomed.info/sct")]
    public CqlCode Anophthalmos_of_bilateral_eyes__disorder_(CqlContext _) => _Anophthalmos_of_bilateral_eyes__disorder_;
    private static readonly CqlCode _Anophthalmos_of_bilateral_eyes__disorder_ = new CqlCode("15665641000119103", "http://snomed.info/sct");

    [CqlCodeDefinition("Eye Diabetic retinopathy screening Autonomous artificial intelligence", codeId: "105914-6", codeSystem: "http://loinc.org")]
    public CqlCode Eye_Diabetic_retinopathy_screening_Autonomous_artificial_intelligence(CqlContext _) => _Eye_Diabetic_retinopathy_screening_Autonomous_artificial_intelligence;
    private static readonly CqlCode _Eye_Diabetic_retinopathy_screening_Autonomous_artificial_intelligence = new CqlCode("105914-6", "http://loinc.org");

    [CqlCodeDefinition("Left eye Diabetic retinopathy severity level by Ophthalmoscopy", codeId: "71490-7", codeSystem: "http://loinc.org")]
    public CqlCode Left_eye_Diabetic_retinopathy_severity_level_by_Ophthalmoscopy(CqlContext _) => _Left_eye_Diabetic_retinopathy_severity_level_by_Ophthalmoscopy;
    private static readonly CqlCode _Left_eye_Diabetic_retinopathy_severity_level_by_Ophthalmoscopy = new CqlCode("71490-7", "http://loinc.org");

    [CqlCodeDefinition("No apparent retinopathy", codeId: "LA18643-9", codeSystem: "http://loinc.org")]
    public CqlCode No_apparent_retinopathy(CqlContext _) => _No_apparent_retinopathy;
    private static readonly CqlCode _No_apparent_retinopathy = new CqlCode("LA18643-9", "http://loinc.org");

    [CqlCodeDefinition("Right eye Diabetic retinopathy severity level by Ophthalmoscopy", codeId: "71491-5", codeSystem: "http://loinc.org")]
    public CqlCode Right_eye_Diabetic_retinopathy_severity_level_by_Ophthalmoscopy(CqlContext _) => _Right_eye_Diabetic_retinopathy_severity_level_by_Ophthalmoscopy;
    private static readonly CqlCode _Right_eye_Diabetic_retinopathy_severity_level_by_Ophthalmoscopy = new CqlCode("71491-5", "http://loinc.org");

    #endregion Codes

    #region CodeSystems (2)

    [CqlCodeSystemDefinition("LOINC", codeSystemId: "http://loinc.org", codeSystemVersion: null)]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, [
          _Eye_Diabetic_retinopathy_screening_Autonomous_artificial_intelligence,
          _Left_eye_Diabetic_retinopathy_severity_level_by_Ophthalmoscopy,
          _No_apparent_retinopathy,
          _Right_eye_Diabetic_retinopathy_severity_level_by_Ophthalmoscopy]);

    [CqlCodeSystemDefinition("SNOMEDCT", codeSystemId: "http://snomed.info/sct", codeSystemVersion: null)]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Anophthalmos_of_bilateral_eyes__disorder_]);

    #endregion CodeSystems

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute, context) ?? Measurement_Period_Compute(context);

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("CMS131FHIRDiabetesEyeExam-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (21)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Patient, Patient_Compute, context) ?? Patient_Compute(context);

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Qualifying_Encounters, Qualifying_Encounters_Compute, context) ?? Qualifying_Encounters_Compute(context);

    private IEnumerable<Encounter> Qualifying_Encounters_Compute(CqlContext context)
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
        IEnumerable<Encounter> u_ = Status_1_15_000.Instance.isEncounterPerformed(context, t_);

        bool? v_(Encounter ValidEncounters) {
            CqlInterval<CqlDateTime> x_ = this.Measurement_Period(context);
            Period y_ = ValidEncounters?.Period;
            CqlInterval<CqlDateTime> z_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, y_);
            bool? aa_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(x_, z_, "day");
            return aa_;
        }

        IEnumerable<Encounter> w_ = context.Operators.Where<Encounter>(u_, v_);
        return w_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute, context) ?? Initial_Population_Compute(context);

    private bool? Initial_Population_Compute(CqlContext context)
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
        IEnumerable<Condition> o_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        object p_(Condition X) => X as object;
        IEnumerable<object> q_ = context.Operators.Select<Condition, object>(o_, p_);
        IEnumerable<object> r_ = Status_1_15_000.Instance.verified(context, q_);

        bool? s_(object DiabetesDx) {
            CqlInterval<CqlDateTime> w_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, DiabetesDx);
            CqlInterval<CqlDateTime> x_ = this.Measurement_Period(context);
            bool? y_ = context.Operators.Overlaps(w_, x_, "day");
            return y_;
        }

        IEnumerable<object> t_ = context.Operators.Where<object>(r_, s_);
        bool? u_ = context.Operators.Exists<object>(t_);
        bool? v_ = context.Operators.And(m_, u_);
        return v_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute, context) ?? Denominator_Compute(context);

    private bool? Denominator_Compute(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlExpressionDefinition("Bilateral Absence of Eyes")]
    public bool? Bilateral_Absence_of_Eyes(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Bilateral_Absence_of_Eyes, Bilateral_Absence_of_Eyes_Compute, context) ?? Bilateral_Absence_of_Eyes_Compute(context);

    private bool? Bilateral_Absence_of_Eyes_Compute(CqlContext context)
    {
        CqlCode a_ = this.Anophthalmos_of_bilateral_eyes__disorder_(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<CqlCode> e_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Condition> f_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, e_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<object> g_ = context.Operators.Union<object>(c_ as IEnumerable<object>, f_ as IEnumerable<object>);
        IEnumerable<object> h_ = Status_1_15_000.Instance.verified(context, g_);

        bool? i_(object BilateralAbsenceEyes) {
            CqlInterval<CqlDateTime> l_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, BilateralAbsenceEyes);
            CqlDateTime m_ = context.Operators.Start(l_);
            CqlInterval<CqlDateTime> n_ = this.Measurement_Period(context);
            CqlDateTime o_ = context.Operators.End(n_);
            bool? p_ = context.Operators.SameOrBefore(m_, o_, "day");
            return p_;
        }

        IEnumerable<object> j_ = context.Operators.Where<object>(h_, i_);
        bool? k_ = context.Operators.Exists<object>(j_);
        return k_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Denominator_Exclusions, Denominator_Exclusions_Compute, context) ?? Denominator_Exclusions_Compute(context);

    private bool? Denominator_Exclusions_Compute(CqlContext context)
    {
        bool? a_ = Hospice_6_18_000.Instance.Has_Hospice_Services(context);
        bool? b_ = AdvancedIllnessandFrailty_1_27_000.Instance.Is_Age_66_or_Older_with_Advanced_Illness_and_Frailty(context);
        bool? c_ = context.Operators.Or(a_, b_);
        bool? d_ = AdvancedIllnessandFrailty_1_27_000.Instance.Is_Age_66_or_Older_Living_Long_Term_in_a_Nursing_Home(context);
        bool? e_ = context.Operators.Or(c_, d_);
        bool? f_ = PalliativeCare_1_18_000.Instance.Has_Palliative_Care_in_the_Measurement_Period(context);
        bool? g_ = context.Operators.Or(e_, f_);
        bool? h_ = this.Bilateral_Absence_of_Eyes(context);
        bool? i_ = context.Operators.Or(g_, h_);
        return i_;
    }


    [CqlExpressionDefinition("Diabetic Retinopathy Overlapping Measurement Period")]
    public bool? Diabetic_Retinopathy_Overlapping_Measurement_Period(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Diabetic_Retinopathy_Overlapping_Measurement_Period, Diabetic_Retinopathy_Overlapping_Measurement_Period_Compute, context) ?? Diabetic_Retinopathy_Overlapping_Measurement_Period_Compute(context);

    private bool? Diabetic_Retinopathy_Overlapping_Measurement_Period_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Diabetic_Retinopathy(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<object> e_ = context.Operators.Union<object>(b_ as IEnumerable<object>, d_ as IEnumerable<object>);
        IEnumerable<object> f_ = Status_1_15_000.Instance.verified(context, e_);

        bool? g_(object Retinopathy) {
            CqlInterval<CqlDateTime> j_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, Retinopathy);
            CqlInterval<CqlDateTime> k_ = this.Measurement_Period(context);
            bool? l_ = context.Operators.Overlaps(j_, k_, "day");
            return l_;
        }

        IEnumerable<object> h_ = context.Operators.Where<object>(f_, g_);
        bool? i_ = context.Operators.Exists<object>(h_);
        return i_;
    }


    [CqlExpressionDefinition("Retinal Exam in Measurement Period")]
    public bool? Retinal_Exam_in_Measurement_Period(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Retinal_Exam_in_Measurement_Period, Retinal_Exam_in_Measurement_Period_Compute, context) ?? Retinal_Exam_in_Measurement_Period_Compute(context);

    private bool? Retinal_Exam_in_Measurement_Period_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Retinal_or_Dilated_Eye_Exam(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-clinical-result"));
        IEnumerable<Observation> c_ = Status_1_15_000.Instance.isPhysicalExamPerformed(context, b_);

        bool? d_(Observation RetinalExam) {
            CqlInterval<CqlDateTime> g_ = this.Measurement_Period(context);
            DataType h_ = RetinalExam?.Effective;
            object i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);
            CqlInterval<CqlDateTime> j_ = QICoreCommon_4_0_000.Instance.toInterval(context, i_);
            bool? k_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(g_, j_, "day");
            return k_;
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
        bool? f_ = context.Operators.Exists<Observation>(e_);
        return f_;
    }


    [CqlExpressionDefinition("Retinal Exam in Measurement Period or Year Prior")]
    public bool? Retinal_Exam_in_Measurement_Period_or_Year_Prior(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Retinal_Exam_in_Measurement_Period_or_Year_Prior, Retinal_Exam_in_Measurement_Period_or_Year_Prior_Compute, context) ?? Retinal_Exam_in_Measurement_Period_or_Year_Prior_Compute(context);

    private bool? Retinal_Exam_in_Measurement_Period_or_Year_Prior_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Retinal_or_Dilated_Eye_Exam(context);
        IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-clinical-result"));
        IEnumerable<Observation> c_ = Status_1_15_000.Instance.isPhysicalExamPerformed(context, b_);

        bool? d_(Observation RetinalExam) {
            CqlInterval<CqlDateTime> g_ = this.Measurement_Period(context);
            CqlDateTime h_ = context.Operators.Start(g_);
            CqlQuantity i_ = context.Operators.Quantity(1m, "year");
            CqlDateTime j_ = context.Operators.Subtract(h_, i_);
            CqlDateTime l_ = context.Operators.End(g_);
            CqlInterval<CqlDateTime> m_ = context.Operators.Interval(j_, l_, true, true);
            DataType n_ = RetinalExam?.Effective;
            object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
            CqlInterval<CqlDateTime> p_ = QICoreCommon_4_0_000.Instance.toInterval(context, o_);
            bool? q_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(m_, p_, "day");
            return q_;
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
        bool? f_ = context.Operators.Exists<Observation>(e_);
        return f_;
    }


    [CqlExpressionDefinition("Autonomous Eye Exam in Measurement Period")]
    public bool? Autonomous_Eye_Exam_in_Measurement_Period(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Autonomous_Eye_Exam_in_Measurement_Period, Autonomous_Eye_Exam_in_Measurement_Period_Compute, context) ?? Autonomous_Eye_Exam_in_Measurement_Period_Compute(context);

    private bool? Autonomous_Eye_Exam_in_Measurement_Period_Compute(CqlContext context)
    {
        CqlCode a_ = this.Eye_Diabetic_retinopathy_screening_Autonomous_artificial_intelligence(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-clinical-result"));
        IEnumerable<Observation> d_ = Status_1_15_000.Instance.isPhysicalExamPerformed(context, c_);

        bool? e_(Observation AutonomousEyeExam) {
            DataType h_ = AutonomousEyeExam?.Value;
            object i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);
            CqlValueSet j_ = this.Autonomous_Eye_Exam_Result_or_Finding(context);
            bool? k_ = context.Operators.ConceptInValueSet(i_ as CqlConcept, j_);
            CqlInterval<CqlDateTime> l_ = this.Measurement_Period(context);
            DataType m_ = AutonomousEyeExam?.Effective;
            object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
            CqlInterval<CqlDateTime> o_ = QICoreCommon_4_0_000.Instance.toInterval(context, n_);
            bool? p_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(l_, o_, "day");
            bool? q_ = context.Operators.And(k_, p_);
            return q_;
        }

        IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);
        bool? g_ = context.Operators.Exists<Observation>(f_);
        return g_;
    }


    [CqlExpressionDefinition("Has Left Eye Retinopathy")]
    public bool? Has_Left_Eye_Retinopathy(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Has_Left_Eye_Retinopathy, Has_Left_Eye_Retinopathy_Compute, context) ?? Has_Left_Eye_Retinopathy_Compute(context);

    private bool? Has_Left_Eye_Retinopathy_Compute(CqlContext context)
    {
        CqlCode a_ = this.Left_eye_Diabetic_retinopathy_severity_level_by_Ophthalmoscopy(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-clinical-result"));
        IEnumerable<Observation> d_ = Status_1_15_000.Instance.isPhysicalExamPerformed(context, c_);

        bool? e_(Observation LeftEyeRetinopathy) {
            DataType h_ = LeftEyeRetinopathy?.Value;
            object i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);
            CqlValueSet j_ = this.Diabetic_Retinopathy_Severity_Level(context);
            bool? k_ = context.Operators.ConceptInValueSet(i_ as CqlConcept, j_);
            CqlInterval<CqlDateTime> l_ = this.Measurement_Period(context);
            DataType m_ = LeftEyeRetinopathy?.Effective;
            object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
            CqlInterval<CqlDateTime> o_ = QICoreCommon_4_0_000.Instance.toInterval(context, n_);
            bool? p_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(l_, o_, "day");
            bool? q_ = context.Operators.And(k_, p_);
            return q_;
        }

        IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);
        bool? g_ = context.Operators.Exists<Observation>(f_);
        return g_;
    }


    [CqlExpressionDefinition("Has Right Eye Retinopathy")]
    public bool? Has_Right_Eye_Retinopathy(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Has_Right_Eye_Retinopathy, Has_Right_Eye_Retinopathy_Compute, context) ?? Has_Right_Eye_Retinopathy_Compute(context);

    private bool? Has_Right_Eye_Retinopathy_Compute(CqlContext context)
    {
        CqlCode a_ = this.Right_eye_Diabetic_retinopathy_severity_level_by_Ophthalmoscopy(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-clinical-result"));
        IEnumerable<Observation> d_ = Status_1_15_000.Instance.isPhysicalExamPerformed(context, c_);

        bool? e_(Observation RightEyeRetinopathy) {
            DataType h_ = RightEyeRetinopathy?.Value;
            object i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);
            CqlValueSet j_ = this.Diabetic_Retinopathy_Severity_Level(context);
            bool? k_ = context.Operators.ConceptInValueSet(i_ as CqlConcept, j_);
            CqlInterval<CqlDateTime> l_ = this.Measurement_Period(context);
            DataType m_ = RightEyeRetinopathy?.Effective;
            object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
            CqlInterval<CqlDateTime> o_ = QICoreCommon_4_0_000.Instance.toInterval(context, n_);
            bool? p_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(l_, o_, "day");
            bool? q_ = context.Operators.And(k_, p_);
            return q_;
        }

        IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);
        bool? g_ = context.Operators.Exists<Observation>(f_);
        return g_;
    }


    [CqlExpressionDefinition("Has Right Eye No Retinopathy in Year Prior")]
    public bool? Has_Right_Eye_No_Retinopathy_in_Year_Prior(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Has_Right_Eye_No_Retinopathy_in_Year_Prior, Has_Right_Eye_No_Retinopathy_in_Year_Prior_Compute, context) ?? Has_Right_Eye_No_Retinopathy_in_Year_Prior_Compute(context);

    private bool? Has_Right_Eye_No_Retinopathy_in_Year_Prior_Compute(CqlContext context)
    {
        CqlCode a_ = this.Right_eye_Diabetic_retinopathy_severity_level_by_Ophthalmoscopy(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-clinical-result"));
        IEnumerable<Observation> d_ = Status_1_15_000.Instance.isPhysicalExamPerformed(context, c_);

        bool? e_(Observation RightEyeNoRetinopathy) {
            DataType h_ = RightEyeNoRetinopathy?.Value;
            object i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);
            CqlCode j_ = this.No_apparent_retinopathy(context);
            CqlConcept k_ = context.Operators.ConvertCodeToConcept(j_);
            bool? l_ = context.Operators.Equivalent(i_ as CqlConcept, k_);
            CqlInterval<CqlDateTime> m_ = this.Measurement_Period(context);
            CqlDateTime n_ = context.Operators.Start(m_);
            CqlQuantity o_ = context.Operators.Quantity(1m, "year");
            CqlDateTime p_ = context.Operators.Subtract(n_, o_);
            CqlDateTime r_ = context.Operators.End(m_);
            CqlDateTime t_ = context.Operators.Subtract(r_, o_);
            CqlInterval<CqlDateTime> u_ = context.Operators.Interval(p_, t_, true, true);
            DataType v_ = RightEyeNoRetinopathy?.Effective;
            object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
            CqlInterval<CqlDateTime> x_ = QICoreCommon_4_0_000.Instance.toInterval(context, w_);
            bool? y_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(u_, x_, "day");
            bool? z_ = context.Operators.And(l_, y_);
            return z_;
        }

        IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);
        bool? g_ = context.Operators.Exists<Observation>(f_);
        return g_;
    }


    [CqlExpressionDefinition("Has Left Eye No Retinopathy in Year Prior")]
    public bool? Has_Left_Eye_No_Retinopathy_in_Year_Prior(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Has_Left_Eye_No_Retinopathy_in_Year_Prior, Has_Left_Eye_No_Retinopathy_in_Year_Prior_Compute, context) ?? Has_Left_Eye_No_Retinopathy_in_Year_Prior_Compute(context);

    private bool? Has_Left_Eye_No_Retinopathy_in_Year_Prior_Compute(CqlContext context)
    {
        CqlCode a_ = this.Left_eye_Diabetic_retinopathy_severity_level_by_Ophthalmoscopy(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-clinical-result"));
        IEnumerable<Observation> d_ = Status_1_15_000.Instance.isPhysicalExamPerformed(context, c_);

        bool? e_(Observation LeftEyeNoRetinopathy) {
            DataType h_ = LeftEyeNoRetinopathy?.Value;
            object i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);
            CqlCode j_ = this.No_apparent_retinopathy(context);
            CqlConcept k_ = context.Operators.ConvertCodeToConcept(j_);
            bool? l_ = context.Operators.Equivalent(i_ as CqlConcept, k_);
            CqlInterval<CqlDateTime> m_ = this.Measurement_Period(context);
            CqlDateTime n_ = context.Operators.Start(m_);
            CqlQuantity o_ = context.Operators.Quantity(1m, "year");
            CqlDateTime p_ = context.Operators.Subtract(n_, o_);
            CqlDateTime r_ = context.Operators.End(m_);
            CqlDateTime t_ = context.Operators.Subtract(r_, o_);
            CqlInterval<CqlDateTime> u_ = context.Operators.Interval(p_, t_, true, true);
            DataType v_ = LeftEyeNoRetinopathy?.Effective;
            object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
            CqlInterval<CqlDateTime> x_ = QICoreCommon_4_0_000.Instance.toInterval(context, w_);
            bool? y_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(u_, x_, "day");
            bool? z_ = context.Operators.And(l_, y_);
            return z_;
        }

        IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);
        bool? g_ = context.Operators.Exists<Observation>(f_);
        return g_;
    }


    [CqlExpressionDefinition("Retinal Exam Finding with Retinopathy Severity Level in Measurement Period")]
    public bool? Retinal_Exam_Finding_with_Retinopathy_Severity_Level_in_Measurement_Period(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Retinal_Exam_Finding_with_Retinopathy_Severity_Level_in_Measurement_Period, Retinal_Exam_Finding_with_Retinopathy_Severity_Level_in_Measurement_Period_Compute, context) ?? Retinal_Exam_Finding_with_Retinopathy_Severity_Level_in_Measurement_Period_Compute(context);

    private bool? Retinal_Exam_Finding_with_Retinopathy_Severity_Level_in_Measurement_Period_Compute(CqlContext context)
    {
        bool? a_ = this.Has_Left_Eye_Retinopathy(context);
        bool? b_ = this.Has_Right_Eye_Retinopathy(context);
        bool? c_ = context.Operators.And(a_, b_);
        bool? e_ = this.Has_Right_Eye_No_Retinopathy_in_Year_Prior(context);
        bool? f_ = context.Operators.And(a_, e_);
        bool? g_ = context.Operators.Or(c_, f_);
        bool? i_ = this.Has_Left_Eye_No_Retinopathy_in_Year_Prior(context);
        bool? j_ = context.Operators.And(b_, i_);
        bool? k_ = context.Operators.Or(g_, j_);
        return k_;
    }


    [CqlExpressionDefinition("Retinal Exam Finding with No Retinopathy Severity Level in Year Prior")]
    public bool? Retinal_Exam_Finding_with_No_Retinopathy_Severity_Level_in_Year_Prior(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Retinal_Exam_Finding_with_No_Retinopathy_Severity_Level_in_Year_Prior, Retinal_Exam_Finding_with_No_Retinopathy_Severity_Level_in_Year_Prior_Compute, context) ?? Retinal_Exam_Finding_with_No_Retinopathy_Severity_Level_in_Year_Prior_Compute(context);

    private bool? Retinal_Exam_Finding_with_No_Retinopathy_Severity_Level_in_Year_Prior_Compute(CqlContext context)
    {
        bool? a_ = this.Has_Left_Eye_No_Retinopathy_in_Year_Prior(context);
        bool? b_ = this.Has_Right_Eye_No_Retinopathy_in_Year_Prior(context);
        bool? c_ = context.Operators.And(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute, context) ?? Numerator_Compute(context);

    private bool? Numerator_Compute(CqlContext context)
    {
        bool? a_ = this.Diabetic_Retinopathy_Overlapping_Measurement_Period(context);
        bool? b_ = this.Retinal_Exam_in_Measurement_Period(context);
        bool? c_ = context.Operators.And(a_, b_);
        bool? e_ = context.Operators.Not(a_);
        bool? f_ = this.Retinal_Exam_in_Measurement_Period_or_Year_Prior(context);
        bool? g_ = context.Operators.And(e_, f_);
        bool? h_ = context.Operators.Or(c_, g_);
        bool? i_ = this.Autonomous_Eye_Exam_in_Measurement_Period(context);
        bool? j_ = context.Operators.Or(h_, i_);
        bool? k_ = this.Retinal_Exam_Finding_with_Retinopathy_Severity_Level_in_Measurement_Period(context);
        bool? l_ = context.Operators.Or(j_, k_);
        bool? m_ = this.Retinal_Exam_Finding_with_No_Retinopathy_Severity_Level_in_Year_Prior(context);
        bool? n_ = context.Operators.Or(l_, m_);
        return n_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute, context) ?? SDE_Ethnicity_Compute(context);

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute, context) ?? SDE_Payer_Compute(context);

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute, context) ?? SDE_Race_Compute(context);

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute, context) ?? SDE_Sex_Compute(context);

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    #endregion Functions and Expressions

    #region Cache Index Fields (22)

    private int _cacheIndex_Measurement_Period = -1;
    private int _cacheIndex_Patient = -1;
    private int _cacheIndex_Qualifying_Encounters = -1;
    private int _cacheIndex_Initial_Population = -1;
    private int _cacheIndex_Denominator = -1;
    private int _cacheIndex_Bilateral_Absence_of_Eyes = -1;
    private int _cacheIndex_Denominator_Exclusions = -1;
    private int _cacheIndex_Diabetic_Retinopathy_Overlapping_Measurement_Period = -1;
    private int _cacheIndex_Retinal_Exam_in_Measurement_Period = -1;
    private int _cacheIndex_Retinal_Exam_in_Measurement_Period_or_Year_Prior = -1;
    private int _cacheIndex_Autonomous_Eye_Exam_in_Measurement_Period = -1;
    private int _cacheIndex_Has_Left_Eye_Retinopathy = -1;
    private int _cacheIndex_Has_Right_Eye_Retinopathy = -1;
    private int _cacheIndex_Has_Right_Eye_No_Retinopathy_in_Year_Prior = -1;
    private int _cacheIndex_Has_Left_Eye_No_Retinopathy_in_Year_Prior = -1;
    private int _cacheIndex_Retinal_Exam_Finding_with_Retinopathy_Severity_Level_in_Measurement_Period = -1;
    private int _cacheIndex_Retinal_Exam_Finding_with_No_Retinopathy_Severity_Level_in_Year_Prior = -1;
    private int _cacheIndex_Numerator = -1;
    private int _cacheIndex_SDE_Ethnicity = -1;
    private int _cacheIndex_SDE_Payer = -1;
    private int _cacheIndex_SDE_Race = -1;
    private int _cacheIndex_SDE_Sex = -1;

    #endregion Cache Index Fields

    #region ILibraryInternals Implementation

    private CqlLibraryInvocationCache _cache = CqlLibraryInvocationCache.NeverCached;

    /// <summary>
    /// Initializes cache indices for this library's cached expressions.
    /// </summary>
    /// <param name="libraryInvocationSet">The library invocation set performing initialization.</param>
    /// <param name="startIndex">The starting index for cache field assignment.</param>
    /// <returns>The number of cache indices initialized (number of cached expressions in this library).</returns>
    int ILibraryInternals.InitializeCacheIndices(
        CqlLibraryInvocationSet libraryInvocationSet,
        int startIndex)
    {
        var index = startIndex;
        _cacheIndex_Measurement_Period = index++;
        _cacheIndex_Patient = index++;
        _cacheIndex_Qualifying_Encounters = index++;
        _cacheIndex_Initial_Population = index++;
        _cacheIndex_Denominator = index++;
        _cacheIndex_Bilateral_Absence_of_Eyes = index++;
        _cacheIndex_Denominator_Exclusions = index++;
        _cacheIndex_Diabetic_Retinopathy_Overlapping_Measurement_Period = index++;
        _cacheIndex_Retinal_Exam_in_Measurement_Period = index++;
        _cacheIndex_Retinal_Exam_in_Measurement_Period_or_Year_Prior = index++;
        _cacheIndex_Autonomous_Eye_Exam_in_Measurement_Period = index++;
        _cacheIndex_Has_Left_Eye_Retinopathy = index++;
        _cacheIndex_Has_Right_Eye_Retinopathy = index++;
        _cacheIndex_Has_Right_Eye_No_Retinopathy_in_Year_Prior = index++;
        _cacheIndex_Has_Left_Eye_No_Retinopathy_in_Year_Prior = index++;
        _cacheIndex_Retinal_Exam_Finding_with_Retinopathy_Severity_Level_in_Measurement_Period = index++;
        _cacheIndex_Retinal_Exam_Finding_with_No_Retinopathy_Severity_Level_in_Year_Prior = index++;
        _cacheIndex_Numerator = index++;
        _cacheIndex_SDE_Ethnicity = index++;
        _cacheIndex_SDE_Payer = index++;
        _cacheIndex_SDE_Race = index++;
        _cacheIndex_SDE_Sex = index++;
        return index - startIndex;
    }

    /// <summary>
    /// Sets the cache instance that this library will use for caching computed values.
    /// </summary>
    /// <param name="cache">The cache instance to use.</param>
    void ILibraryInternals.SetCacheInstance(CqlLibraryInvocationCache cache)
    {
        _cache = cache;
    }

    #endregion ILibraryInternals Implementation

    #region Singleton Lifetime Members

    private CMS131FHIRDiabetesEyeExam_1_0_000() {}

    public static CMS131FHIRDiabetesEyeExam_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS131FHIRDiabetesEyeExam";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_5_1_000.Instance, QICoreCommon_4_0_000.Instance, Hospice_6_18_000.Instance, Status_1_15_000.Instance, PalliativeCare_1_18_000.Instance, AdvancedIllnessandFrailty_1_27_000.Instance];

    #endregion ILibrary Implementation

}
