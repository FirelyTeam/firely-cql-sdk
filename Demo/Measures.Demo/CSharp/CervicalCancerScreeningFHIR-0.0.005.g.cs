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
[CqlLibrary("CervicalCancerScreeningFHIR", "0.0.005")]
public partial class CervicalCancerScreeningFHIR_0_0_005 : ILibrary, ISingleton<CervicalCancerScreeningFHIR_0_0_005>
{
    private CervicalCancerScreeningFHIR_0_0_005() {}

    public static CervicalCancerScreeningFHIR_0_0_005 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "CervicalCancerScreeningFHIR";
    public string Version => "0.0.005";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_001.Instance, SupplementalDataElementsFHIR4_2_0_000.Instance, MATGlobalCommonFunctionsFHIR4_6_1_000.Instance, HospiceFHIR4_2_3_000.Instance, PalliativeCareFHIR_0_6_000.Instance];

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

    [CqlValueSetDefinition("Congenital or Acquired Absence of Cervix", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1016", valueSetVersion: null)]
    public CqlValueSet Congenital_or_Acquired_Absence_of_Cervix(CqlContext _) => _Congenital_or_Acquired_Absence_of_Cervix;
    private static readonly CqlValueSet _Congenital_or_Acquired_Absence_of_Cervix = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1016", null);

    [CqlValueSetDefinition("Home Healthcare Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", valueSetVersion: null)]
    public CqlValueSet Home_Healthcare_Services(CqlContext _) => _Home_Healthcare_Services;
    private static readonly CqlValueSet _Home_Healthcare_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);

    [CqlValueSetDefinition("HPV Test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1059", valueSetVersion: null)]
    public CqlValueSet HPV_Test(CqlContext _) => _HPV_Test;
    private static readonly CqlValueSet _HPV_Test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1059", null);

    [CqlValueSetDefinition("Hysterectomy with No Residual Cervix", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1014", valueSetVersion: null)]
    public CqlValueSet Hysterectomy_with_No_Residual_Cervix(CqlContext _) => _Hysterectomy_with_No_Residual_Cervix;
    private static readonly CqlValueSet _Hysterectomy_with_No_Residual_Cervix = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1014", null);

    [CqlValueSetDefinition("Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext _) => _Office_Visit;
    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlValueSetDefinition("Online Assessments", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", valueSetVersion: null)]
    public CqlValueSet Online_Assessments(CqlContext _) => _Online_Assessments;
    private static readonly CqlValueSet _Online_Assessments = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", null);

    [CqlValueSetDefinition("Pap Test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1017", valueSetVersion: null)]
    public CqlValueSet Pap_Test(CqlContext _) => _Pap_Test;
    private static readonly CqlValueSet _Pap_Test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1017", null);

    [CqlValueSetDefinition("Preventive Care Services - Established Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services___Established_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services___Established_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services___Established_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);

    [CqlValueSetDefinition("Preventive Care Services-Initial Office Visit, 18 and Up", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", valueSetVersion: null)]
    public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext _) => _Preventive_Care_Services_Initial_Office_Visit__18_and_Up;
    private static readonly CqlValueSet _Preventive_Care_Services_Initial_Office_Visit__18_and_Up = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);

    [CqlValueSetDefinition("Telephone Visits", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", valueSetVersion: null)]
    public CqlValueSet Telephone_Visits(CqlContext _) => _Telephone_Visits;
    private static readonly CqlValueSet _Telephone_Visits = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("laboratory", codeId: "laboratory", codeSystem: "http://terminology.hl7.org/CodeSystem/observation-category")]
    public CqlCode laboratory(CqlContext _) => _laboratory;
    private static readonly CqlCode _laboratory = new CqlCode("laboratory", "http://terminology.hl7.org/CodeSystem/observation-category");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("ObservationCategoryCodes", codeSystemId: "http://terminology.hl7.org/CodeSystem/observation-category", codeSystemVersion: null)]
    public CqlCodeSystem ObservationCategoryCodes(CqlContext _) => _ObservationCategoryCodes;
    private static readonly CqlCodeSystem _ObservationCategoryCodes =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/observation-category", null, [
          _laboratory]);

    #endregion CodeSystems

    #region Parameters

    private Cached<CqlInterval<CqlDateTime>> _Measurement_Period_Cached = new();

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        _Measurement_Period_Cached.GetOrReplace(
            context,
            () =>
            {
                CqlDateTime a_ = context.Operators.DateTime(2019, 1, 1, 0, 0, 0, 0, default);
                CqlDateTime b_ = context.Operators.DateTime(2020, 1, 1, 0, 0, 0, 0, default);
                CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
                object d_ = context.ResolveParameter("CervicalCancerScreeningFHIR-0.0.005", "Measurement Period", c_);
                return (CqlInterval<CqlDateTime>)d_;
            });


    #endregion Parameters

    #region Functions and Expressions

    private Cached<Patient> _Patient_Cached = new();

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        _Patient_Cached.GetOrReplace(
            context,
            () =>
            {
                IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
                Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
                return b_;
            });


    private Cached<IEnumerable<Coding>> _SDE_Ethnicity_Cached = new();

    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context) =>
        _SDE_Ethnicity_Cached.GetOrReplace(
            context,
            () =>
            {
                IEnumerable<Coding> a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);
                return a_;
            });


    private Cached<IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?>> _SDE_Payer_Cached = new();

    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context) =>
        _SDE_Payer_Cached.GetOrReplace(
            context,
            () =>
            {
                IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);
                return a_;
            });


    private Cached<IEnumerable<Coding>> _SDE_Race_Cached = new();

    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context) =>
        _SDE_Race_Cached.GetOrReplace(
            context,
            () =>
            {
                IEnumerable<Coding> a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);
                return a_;
            });


    private Cached<CqlCode> _SDE_Sex_Cached = new();

    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        _SDE_Sex_Cached.GetOrReplace(
            context,
            () =>
            {
                CqlCode a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);
                return a_;
            });


    private Cached<IEnumerable<Encounter>> _Qualifying_Encounters_Cached = new();

    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context) =>
        _Qualifying_Encounters_Cached.GetOrReplace(
            context,
            () =>
            {
                CqlValueSet a_ = this.Office_Visit(context);
                IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
                CqlValueSet c_ = this.Preventive_Care_Services___Established_Office_Visit__18_and_Up(context);
                IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
                IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
                CqlValueSet f_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
                IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
                CqlValueSet h_ = this.Home_Healthcare_Services(context);
                IEnumerable<Encounter> i_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
                IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
                IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
                CqlValueSet l_ = this.Telephone_Visits(context);
                IEnumerable<Encounter> m_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
                CqlValueSet n_ = this.Online_Assessments(context);
                IEnumerable<Encounter> o_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
                IEnumerable<Encounter> p_ = context.Operators.Union<Encounter>(m_, o_);
                IEnumerable<Encounter> q_ = context.Operators.Union<Encounter>(k_, p_);
                bool? r_(Encounter ValidEncounter)
                {
                    Code<Encounter.EncounterStatus> t_ = ValidEncounter?.StatusElement;
                    string u_ = FHIRHelpers_4_0_001.Instance.ToString(context, t_);
                    bool? v_ = context.Operators.Equal(u_, "finished");
                    CqlInterval<CqlDateTime> w_ = this.Measurement_Period(context);
                    Period x_ = ValidEncounter?.Period;
                    CqlInterval<CqlDateTime> y_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, x_);
                    bool? z_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(w_, y_, default);
                    bool? aa_ = context.Operators.And(v_, z_);
                    return aa_;
                };
                IEnumerable<Encounter> s_ = context.Operators.Where<Encounter>(q_, r_);
                return s_;
            });


    private Cached<bool?> _Initial_Population_Cached = new();

    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context) =>
        _Initial_Population_Cached.GetOrReplace(
            context,
            () =>
            {
                Patient a_ = this.Patient(context);
                Date b_ = a_?.BirthDateElement;
                string c_ = b_?.Value;
                CqlDate d_ = context.Operators.ConvertStringToDate(c_);
                CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
                CqlDateTime f_ = context.Operators.Start(e_);
                CqlDate g_ = context.Operators.DateFrom(f_);
                int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
                CqlInterval<int?> i_ = context.Operators.Interval(23, 64, true, false);
                bool? j_ = context.Operators.In<int?>(h_, i_, default);
                Code<AdministrativeGender> l_ = a_?.GenderElement;
                string m_ = FHIRHelpers_4_0_001.Instance.ToString(context, l_);
                bool? n_ = context.Operators.Equal(m_, "female");
                bool? o_ = context.Operators.And(j_, n_);
                IEnumerable<Encounter> p_ = this.Qualifying_Encounters(context);
                bool? q_ = context.Operators.Exists<Encounter>(p_);
                bool? r_ = context.Operators.And(o_, q_);
                return r_;
            });


    private Cached<bool?> _Denominator_Cached = new();

    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context) =>
        _Denominator_Cached.GetOrReplace(
            context,
            () =>
            {
                bool? a_ = this.Initial_Population(context);
                return a_;
            });


    private Cached<IEnumerable<object>> _Absence_of_Cervix_Cached = new();

    [CqlExpressionDefinition("Absence of Cervix")]
    public IEnumerable<object> Absence_of_Cervix(CqlContext context) =>
        _Absence_of_Cervix_Cached.GetOrReplace(
            context,
            () =>
            {
                CqlValueSet a_ = this.Hysterectomy_with_No_Residual_Cervix(context);
                IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
                bool? c_(Procedure NoCervixProcedure)
                {
                    Code<EventStatus> j_ = NoCervixProcedure?.StatusElement;
                    string k_ = FHIRHelpers_4_0_001.Instance.ToString(context, j_);
                    bool? l_ = context.Operators.Equal(k_, "completed");
                    DataType m_ = NoCervixProcedure?.Performed;
                    CqlInterval<CqlDateTime> n_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, m_);
                    CqlDateTime o_ = context.Operators.End(n_);
                    CqlInterval<CqlDateTime> p_ = this.Measurement_Period(context);
                    CqlDateTime q_ = context.Operators.End(p_);
                    bool? r_ = context.Operators.SameOrBefore(o_, q_, default);
                    bool? s_ = context.Operators.And(l_, r_);
                    return s_;
                };
                IEnumerable<Procedure> d_ = context.Operators.Where<Procedure>(b_, c_);
                CqlValueSet e_ = this.Congenital_or_Acquired_Absence_of_Cervix(context);
                IEnumerable<Condition> f_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
                bool? g_(Condition NoCervixDiagnosis)
                {
                    CqlInterval<CqlDateTime> t_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, NoCervixDiagnosis);
                    CqlDateTime u_ = context.Operators.Start(t_);
                    CqlInterval<CqlDateTime> v_ = this.Measurement_Period(context);
                    CqlDateTime w_ = context.Operators.End(v_);
                    bool? x_ = context.Operators.SameOrBefore(u_, w_, default);
                    return x_;
                };
                IEnumerable<Condition> h_ = context.Operators.Where<Condition>(f_, g_);
                IEnumerable<object> i_ = context.Operators.Union<object>(d_ as IEnumerable<object>, h_ as IEnumerable<object>);
                return i_;
            });


    private Cached<bool?> _Denominator_Exclusions_Cached = new();

    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context) =>
        _Denominator_Exclusions_Cached.GetOrReplace(
            context,
            () =>
            {
                bool? a_ = HospiceFHIR4_2_3_000.Instance.Has_Hospice(context);
                IEnumerable<object> b_ = this.Absence_of_Cervix(context);
                bool? c_ = context.Operators.Exists<object>(b_);
                bool? d_ = context.Operators.Or(a_, c_);
                bool? e_ = PalliativeCareFHIR_0_6_000.Instance.Palliative_Care_in_the_Measurement_Period(context);
                bool? f_ = context.Operators.Or(d_, e_);
                return f_;
            });


    private Cached<IEnumerable<Observation>> _Cervical_Cytology_Within_3_Years_Cached = new();

    [CqlExpressionDefinition("Cervical Cytology Within 3 Years")]
    public IEnumerable<Observation> Cervical_Cytology_Within_3_Years(CqlContext context) =>
        _Cervical_Cytology_Within_3_Years_Cached.GetOrReplace(
            context,
            () =>
            {
                CqlValueSet a_ = this.Pap_Test(context);
                IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
                bool? c_(Observation CervicalCytology)
                {
                    Code<ObservationStatus> e_ = CervicalCytology?.StatusElement;
                    string f_ = FHIRHelpers_4_0_001.Instance.ToString(context, e_);
                    string[] g_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? h_ = context.Operators.In<string>(f_, (IEnumerable<string>)g_);
                    List<CodeableConcept> i_ = CervicalCytology?.Category;
                    bool? j_(CodeableConcept CervicalCytologyCategory)
                    {
                        CqlCode af_ = this.laboratory(context);
                        CqlConcept ag_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, CervicalCytologyCategory);
                        IReadOnlyList<CqlCode> ah_ = ag_?.codes;
                        bool? ai_ = context.Operators.In<CqlCode>(af_, (IEnumerable<CqlCode>)ah_);
                        return ai_;
                    };
                    IEnumerable<CodeableConcept> k_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)i_, j_);
                    bool? l_ = context.Operators.Exists<CodeableConcept>(k_);
                    bool? m_ = context.Operators.And(h_, l_);
                    DataType n_ = CervicalCytology?.Effective;
                    CqlDateTime o_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, n_);
                    CqlInterval<CqlDateTime> p_ = this.Measurement_Period(context);
                    CqlDateTime q_ = context.Operators.End(p_);
                    CqlQuantity r_ = context.Operators.Quantity(3m, "years");
                    CqlDateTime s_ = context.Operators.Subtract(q_, r_);
                    CqlDateTime u_ = context.Operators.End(p_);
                    CqlInterval<CqlDateTime> v_ = context.Operators.Interval(s_, u_, true, true);
                    bool? w_ = context.Operators.In<CqlDateTime>(o_, v_, default);
                    CqlDateTime y_ = context.Operators.End(p_);
                    bool? z_ = context.Operators.Not((bool?)(y_ is null));
                    bool? aa_ = context.Operators.And(w_, z_);
                    bool? ab_ = context.Operators.And(m_, aa_);
                    DataType ac_ = CervicalCytology?.Value;
                    bool? ad_ = context.Operators.Not((bool?)(ac_ is null));
                    bool? ae_ = context.Operators.And(ab_, ad_);
                    return ae_;
                };
                IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
                return d_;
            });


    private Cached<IEnumerable<Observation>> _HPV_Test_Within_5_Years_for_Women_Age_30_and_Older_Cached = new();

    [CqlExpressionDefinition("HPV Test Within 5 Years for Women Age 30 and Older")]
    public IEnumerable<Observation> HPV_Test_Within_5_Years_for_Women_Age_30_and_Older(CqlContext context) =>
        _HPV_Test_Within_5_Years_for_Women_Age_30_and_Older_Cached.GetOrReplace(
            context,
            () =>
            {
                CqlValueSet a_ = this.HPV_Test(context);
                IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
                bool? c_(Observation HPVTest)
                {
                    Code<ObservationStatus> e_ = HPVTest?.StatusElement;
                    string f_ = FHIRHelpers_4_0_001.Instance.ToString(context, e_);
                    string[] g_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? h_ = context.Operators.In<string>(f_, (IEnumerable<string>)g_);
                    List<CodeableConcept> i_ = HPVTest?.Category;
                    bool? j_(CodeableConcept HPVTestCategory)
                    {
                        CqlCode aq_ = this.laboratory(context);
                        CqlConcept ar_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, HPVTestCategory);
                        IReadOnlyList<CqlCode> as_ = ar_?.codes;
                        bool? at_ = context.Operators.In<CqlCode>(aq_, (IEnumerable<CqlCode>)as_);
                        return at_;
                    };
                    IEnumerable<CodeableConcept> k_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)i_, j_);
                    bool? l_ = context.Operators.Exists<CodeableConcept>(k_);
                    bool? m_ = context.Operators.And(h_, l_);
                    Patient n_ = this.Patient(context);
                    Date o_ = n_?.BirthDateElement;
                    string p_ = o_?.Value;
                    CqlDate q_ = context.Operators.ConvertStringToDate(p_);
                    DataType r_ = HPVTest?.Effective;
                    CqlInterval<CqlDateTime> s_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, r_);
                    CqlDateTime t_ = context.Operators.Start(s_);
                    CqlDate u_ = context.Operators.DateFrom(t_);
                    int? v_ = context.Operators.CalculateAgeAt(q_, u_, "year");
                    bool? w_ = context.Operators.GreaterOrEqual(v_, 30);
                    bool? x_ = context.Operators.And(m_, w_);
                    CqlDateTime z_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, r_);
                    CqlInterval<CqlDateTime> aa_ = this.Measurement_Period(context);
                    CqlDateTime ab_ = context.Operators.End(aa_);
                    CqlQuantity ac_ = context.Operators.Quantity(5m, "years");
                    CqlDateTime ad_ = context.Operators.Subtract(ab_, ac_);
                    CqlDateTime af_ = context.Operators.End(aa_);
                    CqlInterval<CqlDateTime> ag_ = context.Operators.Interval(ad_, af_, true, true);
                    bool? ah_ = context.Operators.In<CqlDateTime>(z_, ag_, default);
                    CqlDateTime aj_ = context.Operators.End(aa_);
                    bool? ak_ = context.Operators.Not((bool?)(aj_ is null));
                    bool? al_ = context.Operators.And(ah_, ak_);
                    bool? am_ = context.Operators.And(x_, al_);
                    DataType an_ = HPVTest?.Value;
                    bool? ao_ = context.Operators.Not((bool?)(an_ is null));
                    bool? ap_ = context.Operators.And(am_, ao_);
                    return ap_;
                };
                IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
                return d_;
            });


    private Cached<bool?> _Numerator_Cached = new();

    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context) =>
        _Numerator_Cached.GetOrReplace(
            context,
            () =>
            {
                IEnumerable<Observation> a_ = this.Cervical_Cytology_Within_3_Years(context);
                bool? b_ = context.Operators.Exists<Observation>(a_);
                IEnumerable<Observation> c_ = this.HPV_Test_Within_5_Years_for_Women_Age_30_and_Older(context);
                bool? d_ = context.Operators.Exists<Observation>(c_);
                bool? e_ = context.Operators.Or(b_, d_);
                return e_;
            });


    [CqlFunctionDefinition("isComplete")]
    public bool? isComplete(CqlContext context, Observation observation)
    {
        Code<ObservationStatus> a_ = observation?.StatusElement;
        string b_ = FHIRHelpers_4_0_001.Instance.ToString(context, a_);
        string[] c_ = [
            "final",
            "amended",
            "corrected",
        ];
        bool? d_ = context.Operators.In<string>(b_, (IEnumerable<string>)c_);
        return d_;
    }


    [CqlFunctionDefinition("isLaboratoryTest")]
    public bool? isLaboratoryTest(CqlContext context, Observation observation)
    {
        List<CodeableConcept> a_ = observation?.Category;
        bool? b_(CodeableConcept category)
        {
            CqlCode e_ = this.laboratory(context);
            CqlConcept f_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, category);
            IReadOnlyList<CqlCode> g_ = f_?.codes;
            bool? h_ = context.Operators.In<CqlCode>(e_, (IEnumerable<CqlCode>)g_);
            return h_;
        };
        IEnumerable<CodeableConcept> c_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)a_, b_);
        bool? d_ = context.Operators.Exists<CodeableConcept>(c_);
        return d_;
    }


    [CqlFunctionDefinition("latest")]
    public CqlDateTime latest(CqlContext context, object choice)
    {
        CqlDateTime a_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Latest(context, choice);
        return a_;
    }


    private Cached<IEnumerable<Observation>> _Cervical_Cytology_Within_3_Years__2__Cached = new();

    [CqlExpressionDefinition("Cervical Cytology Within 3 Years (2)")]
    public IEnumerable<Observation> Cervical_Cytology_Within_3_Years__2_(CqlContext context) =>
        _Cervical_Cytology_Within_3_Years__2__Cached.GetOrReplace(
            context,
            () =>
            {
                CqlValueSet a_ = this.Pap_Test(context);
                IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
                bool? c_(Observation CervicalCytology)
                {
                    bool? e_ = this.isComplete(context, CervicalCytology);
                    bool? f_ = this.isLaboratoryTest(context, CervicalCytology);
                    bool? g_ = context.Operators.And(e_, f_);
                    DataType h_ = CervicalCytology?.Effective;
                    CqlDateTime i_ = this.latest(context, h_);
                    CqlInterval<CqlDateTime> j_ = this.Measurement_Period(context);
                    CqlDateTime k_ = context.Operators.End(j_);
                    CqlQuantity l_ = context.Operators.Quantity(3m, "years");
                    CqlDateTime m_ = context.Operators.Subtract(k_, l_);
                    CqlDateTime o_ = context.Operators.End(j_);
                    CqlInterval<CqlDateTime> p_ = context.Operators.Interval(m_, o_, true, true);
                    bool? q_ = context.Operators.In<CqlDateTime>(i_, p_, default);
                    CqlDateTime s_ = context.Operators.End(j_);
                    bool? t_ = context.Operators.Not((bool?)(s_ is null));
                    bool? u_ = context.Operators.And(q_, t_);
                    bool? v_ = context.Operators.And(g_, u_);
                    DataType w_ = CervicalCytology?.Value;
                    bool? x_ = context.Operators.Not((bool?)(w_ is null));
                    bool? y_ = context.Operators.And(v_, x_);
                    return y_;
                };
                IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
                return d_;
            });


    [CqlFunctionDefinition("toInterval")]
    public CqlInterval<CqlDateTime> toInterval(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> a_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, choice);
        return a_;
    }


    private Cached<IEnumerable<Observation>> _HPV_Test_Within_5_Years_for_Women_Age_30_and_Older__2__Cached = new();

    [CqlExpressionDefinition("HPV Test Within 5 Years for Women Age 30 and Older (2)")]
    public IEnumerable<Observation> HPV_Test_Within_5_Years_for_Women_Age_30_and_Older__2_(CqlContext context) =>
        _HPV_Test_Within_5_Years_for_Women_Age_30_and_Older__2__Cached.GetOrReplace(
            context,
            () =>
            {
                CqlValueSet a_ = this.HPV_Test(context);
                IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));
                bool? c_(Observation HPVTest)
                {
                    bool? e_ = this.isComplete(context, HPVTest);
                    bool? f_ = this.isLaboratoryTest(context, HPVTest);
                    bool? g_ = context.Operators.And(e_, f_);
                    Patient h_ = this.Patient(context);
                    Date i_ = h_?.BirthDateElement;
                    string j_ = i_?.Value;
                    CqlDate k_ = context.Operators.ConvertStringToDate(j_);
                    DataType l_ = HPVTest?.Effective;
                    CqlInterval<CqlDateTime> m_ = this.toInterval(context, l_);
                    CqlDateTime n_ = context.Operators.Start(m_);
                    CqlDate o_ = context.Operators.DateFrom(n_);
                    int? p_ = context.Operators.CalculateAgeAt(k_, o_, "year");
                    bool? q_ = context.Operators.GreaterOrEqual(p_, 30);
                    bool? r_ = context.Operators.And(g_, q_);
                    CqlDateTime t_ = this.latest(context, l_);
                    CqlInterval<CqlDateTime> u_ = this.Measurement_Period(context);
                    CqlDateTime v_ = context.Operators.End(u_);
                    CqlQuantity w_ = context.Operators.Quantity(5m, "years");
                    CqlDateTime x_ = context.Operators.Subtract(v_, w_);
                    CqlDateTime z_ = context.Operators.End(u_);
                    CqlInterval<CqlDateTime> aa_ = context.Operators.Interval(x_, z_, true, true);
                    bool? ab_ = context.Operators.In<CqlDateTime>(t_, aa_, default);
                    CqlDateTime ad_ = context.Operators.End(u_);
                    bool? ae_ = context.Operators.Not((bool?)(ad_ is null));
                    bool? af_ = context.Operators.And(ab_, ae_);
                    bool? ag_ = context.Operators.And(r_, af_);
                    DataType ah_ = HPVTest?.Value;
                    bool? ai_ = context.Operators.Not((bool?)(ah_ is null));
                    bool? aj_ = context.Operators.And(ag_, ai_);
                    return aj_;
                };
                IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
                return d_;
            });


    #endregion Functions and Expressions

}
