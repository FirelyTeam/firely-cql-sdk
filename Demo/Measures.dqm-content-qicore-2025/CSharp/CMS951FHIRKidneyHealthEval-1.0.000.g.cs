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
[CqlLibrary("CMS951FHIRKidneyHealthEval", "1.0.000")]
public partial class CMS951FHIRKidneyHealthEval_1_0_000 : ILibrary, ISingleton<CMS951FHIRKidneyHealthEval_1_0_000>
{
    private CMS951FHIRKidneyHealthEval_1_0_000() {}

    public static CMS951FHIRKidneyHealthEval_1_0_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "CMS951FHIRKidneyHealthEval";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_5_1_000.Instance, Hospice_6_18_000.Instance, PalliativeCare_1_18_000.Instance, QICoreCommon_4_0_000.Instance];

    #endregion ILibrary Implementation

    #region Nested Type - Cached<T>

    private struct Cached<T>(object CacheVersion, T CachedValue)
    {
        public T GetOrReplace(ICqlContextInternals cqlContext, Func<T> factory)
        {
            var cqlContextCacheVersion = cqlContext.CacheVersion;
            if (cqlContextCacheVersion is null)
            {
                // No caching, clear out previous values
                CacheVersion = null;
                CachedValue = default;
                var value = factory();
                return value;
            }

            if (ReferenceEquals(CacheVersion, cqlContextCacheVersion))
            {
                // Cache hit
                return CachedValue;
            }
            else
            {
                // Cache miss, refresh and store
                var value = factory();
                CachedValue = value;
                CacheVersion = cqlContextCacheVersion;
                return value;
            }
        }
    }

    #endregion

    #region ValueSets

    [CqlValueSetDefinition("Annual Wellness Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", valueSetVersion: null)]
    public CqlValueSet Annual_Wellness_Visit(CqlContext _) => _Annual_Wellness_Visit;
    private static readonly CqlValueSet _Annual_Wellness_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", null);

    [CqlValueSetDefinition("Chronic Kidney Disease, Stage 5", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1002", valueSetVersion: null)]
    public CqlValueSet Chronic_Kidney_Disease__Stage_5(CqlContext _) => _Chronic_Kidney_Disease__Stage_5;
    private static readonly CqlValueSet _Chronic_Kidney_Disease__Stage_5 = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1002", null);

    [CqlValueSetDefinition("Diabetes", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001", valueSetVersion: null)]
    public CqlValueSet Diabetes(CqlContext _) => _Diabetes;
    private static readonly CqlValueSet _Diabetes = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001", null);

    [CqlValueSetDefinition("End Stage Renal Disease", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.353", valueSetVersion: null)]
    public CqlValueSet End_Stage_Renal_Disease(CqlContext _) => _End_Stage_Renal_Disease;
    private static readonly CqlValueSet _End_Stage_Renal_Disease = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.353", null);

    [CqlValueSetDefinition("Estimated Glomerular Filtration Rate", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.6929.3.1000", valueSetVersion: null)]
    public CqlValueSet Estimated_Glomerular_Filtration_Rate(CqlContext _) => _Estimated_Glomerular_Filtration_Rate;
    private static readonly CqlValueSet _Estimated_Glomerular_Filtration_Rate = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.6929.3.1000", null);

    [CqlValueSetDefinition("Home Healthcare Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", valueSetVersion: null)]
    public CqlValueSet Home_Healthcare_Services(CqlContext _) => _Home_Healthcare_Services;
    private static readonly CqlValueSet _Home_Healthcare_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);

    [CqlValueSetDefinition("Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext _) => _Office_Visit;
    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlValueSetDefinition("Outpatient Consultation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", valueSetVersion: null)]
    public CqlValueSet Outpatient_Consultation(CqlContext _) => _Outpatient_Consultation;
    private static readonly CqlValueSet _Outpatient_Consultation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", null);

    [CqlValueSetDefinition("Preventive Care Services Established Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services_Established_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services_Established_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);

    [CqlValueSetDefinition("Preventive Care Services Initial Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services_Initial_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services_Initial_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);

    [CqlValueSetDefinition("Telephone Visits", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", valueSetVersion: null)]
    public CqlValueSet Telephone_Visits(CqlContext _) => _Telephone_Visits;
    private static readonly CqlValueSet _Telephone_Visits = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    [CqlValueSetDefinition("Undetectable Lab Result Value", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.272", valueSetVersion: null)]
    public CqlValueSet Undetectable_Lab_Result_Value(CqlContext _) => _Undetectable_Lab_Result_Value;
    private static readonly CqlValueSet _Undetectable_Lab_Result_Value = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.272", null);

    [CqlValueSetDefinition("Urine Albumin", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.88", valueSetVersion: null)]
    public CqlValueSet Urine_Albumin(CqlContext _) => _Urine_Albumin;
    private static readonly CqlValueSet _Urine_Albumin = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.88", null);

    [CqlValueSetDefinition("Urine Albumin Creatinine Ratio", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.6929.3.1007", valueSetVersion: null)]
    public CqlValueSet Urine_Albumin_Creatinine_Ratio(CqlContext _) => _Urine_Albumin_Creatinine_Ratio;
    private static readonly CqlValueSet _Urine_Albumin_Creatinine_Ratio = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.6929.3.1007", null);

    [CqlValueSetDefinition("Urine Creatinine", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.87", valueSetVersion: null)]
    public CqlValueSet Urine_Creatinine(CqlContext _) => _Urine_Creatinine;
    private static readonly CqlValueSet _Urine_Creatinine = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.87", null);

    #endregion ValueSets

    #region Parameters

    private Cached<CqlInterval<CqlDateTime>> _Measurement_Period_Cached = new();

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        _Measurement_Period_Cached.GetOrReplace(
            context,
            () => {
                object a_ = context.ResolveParameter("CMS951FHIRKidneyHealthEval-1.0.000", "Measurement Period", null);
                return (CqlInterval<CqlDateTime>)a_;
            });


    #endregion Parameters

    #region Functions and Expressions

    private Cached<Patient> _Patient_Cached = new();

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        _Patient_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
                Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
                return b_;
            });


    private Cached<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> _SDE_Ethnicity_Cached = new();

    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        _SDE_Ethnicity_Cached.GetOrReplace(
            context,
            () => {
                (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
                return a_;
            });


    private Cached<IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?>> _SDE_Payer_Cached = new();

    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        _SDE_Payer_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
                return a_;
            });


    private Cached<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> _SDE_Race_Cached = new();

    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        _SDE_Race_Cached.GetOrReplace(
            context,
            () => {
                (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
                return a_;
            });


    private Cached<CqlCode> _SDE_Sex_Cached = new();

    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        _SDE_Sex_Cached.GetOrReplace(
            context,
            () => {
                CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
                return a_;
            });


    private Cached<bool?> _Has_Active_Diabetes_Overlaps_Start_Of_Measurement_Period_Cached = new();

    [CqlExpressionDefinition("Has Active Diabetes Overlaps Start Of Measurement Period")]
    public bool? Has_Active_Diabetes_Overlaps_Start_Of_Measurement_Period(CqlContext context) =>
        _Has_Active_Diabetes_Overlaps_Start_Of_Measurement_Period_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Diabetes(context);
                IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
                IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
                IEnumerable<object> e_ = context.Operators.Union<object>(b_ as IEnumerable<object>, d_ as IEnumerable<object>);

                bool? f_(object DiabetesDiagnosis) {
                    CqlInterval<CqlDateTime> i_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, DiabetesDiagnosis);
                    CqlInterval<CqlDateTime> j_ = this.Measurement_Period(context);
                    bool? k_ = context.Operators.OverlapsBefore(i_, j_, "day");
                    object l_ = context.Operators.LateBoundProperty<object>(DiabetesDiagnosis, "verificationStatus");
                    CqlConcept m_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, l_ as CodeableConcept);
                    bool? n_ = context.Operators.Not((bool?)(m_ is null));
                    CqlConcept p_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, l_ as CodeableConcept);
                    CqlCode q_ = QICoreCommon_4_0_000.Instance.refuted(context);
                    CqlConcept r_ = context.Operators.ConvertCodeToConcept(q_);
                    bool? s_ = context.Operators.Equivalent(p_, r_);
                    bool? t_ = context.Operators.Not(s_);
                    CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, l_ as CodeableConcept);
                    CqlCode w_ = QICoreCommon_4_0_000.Instance.entered_in_error(context);
                    CqlConcept x_ = context.Operators.ConvertCodeToConcept(w_);
                    bool? y_ = context.Operators.Equivalent(v_, x_);
                    bool? z_ = context.Operators.Not(y_);
                    bool? aa_ = context.Operators.And(t_, z_);
                    bool? ab_ = context.Operators.Implies(n_, aa_);
                    bool? ac_ = context.Operators.And(k_, ab_);
                    return ac_;
                }

                IEnumerable<object> g_ = context.Operators.Where<object>(e_, f_);
                bool? h_ = context.Operators.Exists<object>(g_);
                return h_;
            });


    private Cached<bool?> _Has_Outpatient_Visit_During_Measurement_Period_Cached = new();

    [CqlExpressionDefinition("Has Outpatient Visit During Measurement Period")]
    public bool? Has_Outpatient_Visit_During_Measurement_Period(CqlContext context) =>
        _Has_Outpatient_Visit_During_Measurement_Period_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Annual_Wellness_Visit(context);
                IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                CqlValueSet c_ = this.Home_Healthcare_Services(context);
                IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
                CqlValueSet f_ = this.Office_Visit(context);
                IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                CqlValueSet h_ = this.Outpatient_Consultation(context);
                IEnumerable<Encounter> i_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
                IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
                CqlValueSet l_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
                IEnumerable<Encounter> m_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                CqlValueSet n_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
                IEnumerable<Encounter> o_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                IEnumerable<Encounter> p_ = context.Operators.Union<Encounter>(m_, o_);
                IEnumerable<Encounter> q_ = context.Operators.Union<Encounter>(k_, p_);
                CqlValueSet r_ = this.Telephone_Visits(context);
                IEnumerable<Encounter> s_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                IEnumerable<Encounter> t_ = context.Operators.Union<Encounter>(q_, s_);

                bool? u_(Encounter ValidEncounter) {
                    CqlInterval<CqlDateTime> x_ = this.Measurement_Period(context);
                    Period y_ = ValidEncounter?.Period;
                    CqlInterval<CqlDateTime> z_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, y_);
                    bool? aa_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(x_, z_, "day");
                    Code<Encounter.EncounterStatus> ab_ = ValidEncounter?.StatusElement;
                    Encounter.EncounterStatus? ac_ = ab_?.Value;
                    Code<Encounter.EncounterStatus> ad_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ac_);
                    bool? ae_ = context.Operators.Equal(ad_, "finished");
                    bool? af_ = context.Operators.And(aa_, ae_);
                    return af_;
                }

                IEnumerable<Encounter> v_ = context.Operators.Where<Encounter>(t_, u_);
                bool? w_ = context.Operators.Exists<Encounter>(v_);
                return w_;
            });


    private Cached<bool?> _Initial_Population_Cached = new();

    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context) =>
        _Initial_Population_Cached.GetOrReplace(
            context,
            () => {
                Patient a_ = this.Patient(context);
                Date b_ = a_?.BirthDateElement;
                string c_ = b_?.Value;
                CqlDate d_ = context.Operators.ConvertStringToDate(c_);
                CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
                CqlDateTime f_ = context.Operators.Start(e_);
                CqlDate g_ = context.Operators.DateFrom(f_);
                int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
                CqlInterval<int?> i_ = context.Operators.Interval(18, 85, true, true);
                bool? j_ = context.Operators.In<int?>(h_, i_, default);
                bool? k_ = this.Has_Active_Diabetes_Overlaps_Start_Of_Measurement_Period(context);
                bool? l_ = context.Operators.And(j_, k_);
                bool? m_ = this.Has_Outpatient_Visit_During_Measurement_Period(context);
                bool? n_ = context.Operators.And(l_, m_);
                return n_;
            });


    private Cached<bool?> _Denominator_Cached = new();

    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context) =>
        _Denominator_Cached.GetOrReplace(
            context,
            () => {
                bool? a_ = this.Initial_Population(context);
                return a_;
            });


    private Cached<bool?> _Has_CKD_Stage_5_Or_ESRD_Diagnosis_Overlaps_Measurement_Period_Cached = new();

    [CqlExpressionDefinition("Has CKD Stage 5 Or ESRD Diagnosis Overlaps Measurement Period")]
    public bool? Has_CKD_Stage_5_Or_ESRD_Diagnosis_Overlaps_Measurement_Period(CqlContext context) =>
        _Has_CKD_Stage_5_Or_ESRD_Diagnosis_Overlaps_Measurement_Period_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Chronic_Kidney_Disease__Stage_5(context);
                IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
                IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
                IEnumerable<object> e_ = context.Operators.Union<object>(b_ as IEnumerable<object>, d_ as IEnumerable<object>);
                CqlValueSet f_ = this.End_Stage_Renal_Disease(context);
                IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
                IEnumerable<Condition> i_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
                IEnumerable<object> j_ = context.Operators.Union<object>(g_ as IEnumerable<object>, i_ as IEnumerable<object>);
                IEnumerable<object> k_ = context.Operators.Union<object>(e_, j_);

                bool? l_(object CKDOrESRD) {
                    CqlInterval<CqlDateTime> o_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, CKDOrESRD);
                    CqlInterval<CqlDateTime> p_ = this.Measurement_Period(context);
                    bool? q_ = context.Operators.Overlaps(o_, p_, "day");
                    object r_ = context.Operators.LateBoundProperty<object>(CKDOrESRD, "verificationStatus");
                    CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, r_ as CodeableConcept);
                    bool? t_ = context.Operators.Not((bool?)(s_ is null));
                    CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, r_ as CodeableConcept);
                    CqlCode w_ = QICoreCommon_4_0_000.Instance.refuted(context);
                    CqlConcept x_ = context.Operators.ConvertCodeToConcept(w_);
                    bool? y_ = context.Operators.Equivalent(v_, x_);
                    bool? z_ = context.Operators.Not(y_);
                    CqlConcept ab_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, r_ as CodeableConcept);
                    CqlCode ac_ = QICoreCommon_4_0_000.Instance.entered_in_error(context);
                    CqlConcept ad_ = context.Operators.ConvertCodeToConcept(ac_);
                    bool? ae_ = context.Operators.Equivalent(ab_, ad_);
                    bool? af_ = context.Operators.Not(ae_);
                    bool? ag_ = context.Operators.And(z_, af_);
                    bool? ah_ = context.Operators.Implies(t_, ag_);
                    bool? ai_ = context.Operators.And(q_, ah_);
                    return ai_;
                }

                IEnumerable<object> m_ = context.Operators.Where<object>(k_, l_);
                bool? n_ = context.Operators.Exists<object>(m_);
                return n_;
            });


    private Cached<bool?> _Denominator_Exclusions_Cached = new();

    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context) =>
        _Denominator_Exclusions_Cached.GetOrReplace(
            context,
            () => {
                bool? a_ = this.Has_CKD_Stage_5_Or_ESRD_Diagnosis_Overlaps_Measurement_Period(context);
                bool? b_ = Hospice_6_18_000.Instance.Has_Hospice_Services(context);
                bool? c_ = context.Operators.Or(a_, b_);
                bool? d_ = PalliativeCare_1_18_000.Instance.Has_Palliative_Care_in_the_Measurement_Period(context);
                bool? e_ = context.Operators.Or(c_, d_);
                return e_;
            });


    private Cached<bool?> _Has_Estimated_Glomerular_Filtration_Rate_Performed_During_Measurement_Period_Cached = new();

    [CqlExpressionDefinition("Has Estimated Glomerular Filtration Rate Performed During Measurement Period")]
    public bool? Has_Estimated_Glomerular_Filtration_Rate_Performed_During_Measurement_Period(CqlContext context) =>
        _Has_Estimated_Glomerular_Filtration_Rate_Performed_During_Measurement_Period_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Estimated_Glomerular_Filtration_Rate(context);
                IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

                bool? c_(Observation eGFRTest) {
                    CqlInterval<CqlDateTime> f_ = this.Measurement_Period(context);
                    DataType g_ = eGFRTest?.Effective;
                    object h_ = FHIRHelpers_4_4_000.Instance.ToValue(context, g_);
                    CqlInterval<CqlDateTime> i_ = QICoreCommon_4_0_000.Instance.toInterval(context, h_);
                    bool? j_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(f_, i_, "day");
                    DataType k_ = eGFRTest?.Value;
                    object l_ = FHIRHelpers_4_4_000.Instance.ToValue(context, k_);
                    bool? m_ = context.Operators.Not((bool?)(l_ is null));
                    bool? n_ = context.Operators.And(j_, m_);
                    Code<ObservationStatus> o_ = eGFRTest?.StatusElement;
                    ObservationStatus? p_ = o_?.Value;
                    string q_ = context.Operators.Convert<string>(p_);
                    string[] r_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? s_ = context.Operators.In<string>(q_, (IEnumerable<string>)r_);
                    bool? t_ = context.Operators.And(n_, s_);
                    return t_;
                }

                IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
                bool? e_ = context.Operators.Exists<Observation>(d_);
                return e_;
            });


    private Cached<bool?> _Has_Urine_Albumin_Creatinine_Ratio_Test_Performed_During_Measurement_Period_Cached = new();

    [CqlExpressionDefinition("Has Urine Albumin Creatinine Ratio Test Performed During Measurement Period")]
    public bool? Has_Urine_Albumin_Creatinine_Ratio_Test_Performed_During_Measurement_Period(CqlContext context) =>
        _Has_Urine_Albumin_Creatinine_Ratio_Test_Performed_During_Measurement_Period_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Urine_Albumin_Creatinine_Ratio(context);
                IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

                bool? c_(Observation uACRTest) {
                    CqlInterval<CqlDateTime> f_ = this.Measurement_Period(context);
                    DataType g_ = uACRTest?.Effective;
                    object h_ = FHIRHelpers_4_4_000.Instance.ToValue(context, g_);
                    CqlInterval<CqlDateTime> i_ = QICoreCommon_4_0_000.Instance.toInterval(context, h_);
                    bool? j_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(f_, i_, "day");
                    Code<ObservationStatus> k_ = uACRTest?.StatusElement;
                    ObservationStatus? l_ = k_?.Value;
                    string m_ = context.Operators.Convert<string>(l_);
                    string[] n_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? o_ = context.Operators.In<string>(m_, (IEnumerable<string>)n_);
                    bool? p_ = context.Operators.And(j_, o_);
                    DataType q_ = uACRTest?.Value;
                    object r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                    bool s_ = r_ is CqlQuantity;
                    object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                    CqlValueSet v_ = this.Undetectable_Lab_Result_Value(context);
                    bool? w_ = context.Operators.ConceptInValueSet(u_ as CqlConcept, v_);
                    bool? x_ = context.Operators.Or(s_ as bool?, w_);
                    bool? y_ = context.Operators.And(p_, x_);
                    return y_;
                }

                IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
                bool? e_ = context.Operators.Exists<Observation>(d_);
                return e_;
            });


    private Cached<IEnumerable<Observation>> _Urine_Albumin_Test_Performed_During_The_Measurement_Period_Cached = new();

    [CqlExpressionDefinition("Urine Albumin Test Performed During The Measurement Period")]
    public IEnumerable<Observation> Urine_Albumin_Test_Performed_During_The_Measurement_Period(CqlContext context) =>
        _Urine_Albumin_Test_Performed_During_The_Measurement_Period_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Urine_Albumin(context);
                IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

                bool? c_(Observation AlbuminTest) {
                    CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
                    DataType f_ = AlbuminTest?.Effective;
                    object g_ = FHIRHelpers_4_4_000.Instance.ToValue(context, f_);
                    CqlInterval<CqlDateTime> h_ = QICoreCommon_4_0_000.Instance.toInterval(context, g_);
                    bool? i_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(e_, h_, "day");
                    DataType j_ = AlbuminTest?.Value;
                    object k_ = FHIRHelpers_4_4_000.Instance.ToValue(context, j_);
                    bool? l_ = context.Operators.Not((bool?)(k_ is null));
                    bool? m_ = context.Operators.And(i_, l_);
                    Code<ObservationStatus> n_ = AlbuminTest?.StatusElement;
                    ObservationStatus? o_ = n_?.Value;
                    string p_ = context.Operators.Convert<string>(o_);
                    string[] q_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? r_ = context.Operators.In<string>(p_, (IEnumerable<string>)q_);
                    bool? s_ = context.Operators.And(m_, r_);
                    return s_;
                }

                IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
                return d_;
            });


    private Cached<IEnumerable<Observation>> _Urine_Creatinine_Test_Performed_During_The_Measurement_Period_Cached = new();

    [CqlExpressionDefinition("Urine Creatinine Test Performed During The Measurement Period")]
    public IEnumerable<Observation> Urine_Creatinine_Test_Performed_During_The_Measurement_Period(CqlContext context) =>
        _Urine_Creatinine_Test_Performed_During_The_Measurement_Period_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Urine_Creatinine(context);
                IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

                bool? c_(Observation CreatinineTest) {
                    CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
                    DataType f_ = CreatinineTest?.Effective;
                    object g_ = FHIRHelpers_4_4_000.Instance.ToValue(context, f_);
                    CqlInterval<CqlDateTime> h_ = QICoreCommon_4_0_000.Instance.toInterval(context, g_);
                    bool? i_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(e_, h_, "day");
                    DataType j_ = CreatinineTest?.Value;
                    object k_ = FHIRHelpers_4_4_000.Instance.ToValue(context, j_);
                    bool? l_ = context.Operators.Not((bool?)(k_ is null));
                    bool? m_ = context.Operators.And(i_, l_);
                    Code<ObservationStatus> n_ = CreatinineTest?.StatusElement;
                    ObservationStatus? o_ = n_?.Value;
                    string p_ = context.Operators.Convert<string>(o_);
                    string[] q_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? r_ = context.Operators.In<string>(p_, (IEnumerable<string>)q_);
                    bool? s_ = context.Operators.And(m_, r_);
                    return s_;
                }

                IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
                return d_;
            });


    private Cached<bool?> _Has_Urine_Albumin_Test_And_Urine_Creatine_Test_Less_Than_Or_Equal_To_Four_Days_Apart_Cached = new();

    [CqlExpressionDefinition("Has Urine Albumin Test And Urine Creatine Test Less Than Or Equal To Four Days Apart")]
    public bool? Has_Urine_Albumin_Test_And_Urine_Creatine_Test_Less_Than_Or_Equal_To_Four_Days_Apart(CqlContext context) =>
        _Has_Urine_Albumin_Test_And_Urine_Creatine_Test_Less_Than_Or_Equal_To_Four_Days_Apart_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<Observation> a_ = this.Urine_Albumin_Test_Performed_During_The_Measurement_Period(context);
                IEnumerable<Observation> b_ = this.Urine_Creatinine_Test_Performed_During_The_Measurement_Period(context);
                IEnumerable<ValueTuple<Observation, Observation>> c_ = context.Operators.CrossJoin<Observation, Observation>(a_, b_);

                (CqlTupleMetadata, Observation UrineAlbuminTest, Observation UrineCreatinineTest)? d_(ValueTuple<Observation, Observation> _valueTuple) {
                    (CqlTupleMetadata, Observation UrineAlbuminTest, Observation UrineCreatinineTest)? l_ = (CqlTupleMetadata_CELfNSUeJXKBGCPWLEBSIIJ, _valueTuple.Item1, _valueTuple.Item2);
                    return l_;
                }

                IEnumerable<(CqlTupleMetadata, Observation UrineAlbuminTest, Observation UrineCreatinineTest)?> e_ = context.Operators.Select<ValueTuple<Observation, Observation>, (CqlTupleMetadata, Observation UrineAlbuminTest, Observation UrineCreatinineTest)?>(c_, d_);

                bool? f_((CqlTupleMetadata, Observation UrineAlbuminTest, Observation UrineCreatinineTest)? tuple_celfnsuejxkbgcpwlebsiij) {
                    DataType m_ = tuple_celfnsuejxkbgcpwlebsiij?.UrineCreatinineTest?.Effective;
                    object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
                    CqlInterval<CqlDateTime> o_ = QICoreCommon_4_0_000.Instance.toInterval(context, n_);
                    CqlDateTime p_ = context.Operators.Start(o_);
                    CqlQuantity q_ = context.Operators.Quantity(4m, "days");
                    CqlDateTime r_ = context.Operators.Subtract(p_, q_);
                    object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
                    CqlInterval<CqlDateTime> u_ = QICoreCommon_4_0_000.Instance.toInterval(context, t_);
                    CqlDateTime v_ = context.Operators.End(u_);
                    CqlDateTime x_ = context.Operators.Add(v_, q_);
                    CqlInterval<CqlDateTime> y_ = context.Operators.Interval(r_, x_, true, true);
                    DataType z_ = tuple_celfnsuejxkbgcpwlebsiij?.UrineAlbuminTest?.Effective;
                    object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                    CqlInterval<CqlDateTime> ab_ = QICoreCommon_4_0_000.Instance.toInterval(context, aa_);
                    bool? ac_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(y_, ab_, default);
                    return ac_;
                }

                IEnumerable<(CqlTupleMetadata, Observation UrineAlbuminTest, Observation UrineCreatinineTest)?> g_ = context.Operators.Where<(CqlTupleMetadata, Observation UrineAlbuminTest, Observation UrineCreatinineTest)?>(e_, f_);

                (CqlTupleMetadata, Observation UrineAlbuminTest, Observation UrineCreatinineTest)? h_((CqlTupleMetadata, Observation UrineAlbuminTest, Observation UrineCreatinineTest)? tuple_celfnsuejxkbgcpwlebsiij) {
                    (CqlTupleMetadata, Observation UrineAlbuminTest, Observation UrineCreatinineTest)? ad_ = (CqlTupleMetadata_CELfNSUeJXKBGCPWLEBSIIJ, tuple_celfnsuejxkbgcpwlebsiij?.UrineAlbuminTest, tuple_celfnsuejxkbgcpwlebsiij?.UrineCreatinineTest);
                    return ad_;
                }

                IEnumerable<(CqlTupleMetadata, Observation UrineAlbuminTest, Observation UrineCreatinineTest)?> i_ = context.Operators.Select<(CqlTupleMetadata, Observation UrineAlbuminTest, Observation UrineCreatinineTest)?, (CqlTupleMetadata, Observation UrineAlbuminTest, Observation UrineCreatinineTest)?>(g_, h_);
                IEnumerable<(CqlTupleMetadata, Observation UrineAlbuminTest, Observation UrineCreatinineTest)?> j_ = context.Operators.Distinct<(CqlTupleMetadata, Observation UrineAlbuminTest, Observation UrineCreatinineTest)?>(i_);
                bool? k_ = context.Operators.Exists<(CqlTupleMetadata, Observation UrineAlbuminTest, Observation UrineCreatinineTest)?>(j_);
                return k_;
            });


    private Cached<bool?> _Kidney_Panel_Performed_During_Measurement_Period_Cached = new();

    [CqlExpressionDefinition("Kidney Panel Performed During Measurement Period")]
    public bool? Kidney_Panel_Performed_During_Measurement_Period(CqlContext context) =>
        _Kidney_Panel_Performed_During_Measurement_Period_Cached.GetOrReplace(
            context,
            () => {
                bool? a_ = this.Has_Estimated_Glomerular_Filtration_Rate_Performed_During_Measurement_Period(context);
                bool? b_ = this.Has_Urine_Albumin_Creatinine_Ratio_Test_Performed_During_Measurement_Period(context);
                bool? c_ = this.Has_Urine_Albumin_Test_And_Urine_Creatine_Test_Less_Than_Or_Equal_To_Four_Days_Apart(context);
                bool? d_ = context.Operators.Or(b_, c_);
                bool? e_ = context.Operators.And(a_, d_);
                return e_;
            });


    private Cached<bool?> _Numerator_Cached = new();

    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context) =>
        _Numerator_Cached.GetOrReplace(
            context,
            () => {
                bool? a_ = this.Kidney_Panel_Performed_During_Measurement_Period(context);
                return a_;
            });


    #endregion Functions and Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_CELfNSUeJXKBGCPWLEBSIIJ = new(
       [typeof(Observation), typeof(Observation)],
       ["UrineAlbuminTest", "UrineCreatinineTest"]);

    #endregion CqlTupleMetadata Properties

}
