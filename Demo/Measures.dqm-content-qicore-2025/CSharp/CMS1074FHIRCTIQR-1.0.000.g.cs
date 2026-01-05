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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "4.0.0.0")]
[CqlLibrary("CMS1074FHIRCTIQR", "1.0.000")]
public partial class CMS1074FHIRCTIQR_1_0_000 : ILibrary, ISingleton<CMS1074FHIRCTIQR_1_0_000>
{
    #region ValueSets

    [CqlValueSetDefinition("Encounter Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext _) => _Encounter_Inpatient;
    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("CT dose and image quality category", codeId: "96914-7", codeSystem: "http://loinc.org")]
    public CqlCode CT_dose_and_image_quality_category(CqlContext _) => _CT_dose_and_image_quality_category;
    private static readonly CqlCode _CT_dose_and_image_quality_category = new CqlCode("96914-7", "http://loinc.org");

    [CqlCodeDefinition("Full Body", codeId: "LA31771-1", codeSystem: "http://loinc.org")]
    public CqlCode Full_Body(CqlContext _) => _Full_Body;
    private static readonly CqlCode _Full_Body = new CqlCode("LA31771-1", "http://loinc.org");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC", codeSystemId: "http://loinc.org", codeSystemVersion: null)]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, [
          _CT_dose_and_image_quality_category,
          _Full_Body]);

    #endregion CodeSystems

    #region Parameters

    private readonly Cached<CqlInterval<CqlDateTime>> _Measurement_Period_Cached = new();

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        _Measurement_Period_Cached.GetOrReplace(
            context,
            () => {
                object a_ = context.ResolveParameter("CMS1074FHIRCTIQR-1.0.000", "Measurement Period", null);
                return (CqlInterval<CqlDateTime>)a_;
            });


    #endregion Parameters

    #region Functions and Expressions

    private readonly Cached<Patient> _Patient_Cached = new();

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        _Patient_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
                Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
                return b_;
            });


    private readonly Cached<IEnumerable<Encounter>> _Qualifying_Inpatient_Encounters_Cached = new();

    [CqlExpressionDefinition("Qualifying Inpatient Encounters")]
    public IEnumerable<Encounter> Qualifying_Inpatient_Encounters(CqlContext context) =>
        _Qualifying_Inpatient_Encounters_Cached.GetOrReplace(
            context,
            () => {
                CqlValueSet a_ = this.Encounter_Inpatient(context);
                IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                bool? c_(Encounter InpatientEncounter) {
                    Code<Encounter.EncounterStatus> e_ = InpatientEncounter?.StatusElement;
                    Encounter.EncounterStatus? f_ = e_?.Value;
                    Code<Encounter.EncounterStatus> g_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(f_);
                    bool? h_ = context.Operators.Equivalent(g_, "finished");
                    Period i_ = InpatientEncounter?.Period;
                    CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, i_);
                    CqlDateTime k_ = context.Operators.End(j_);
                    CqlInterval<CqlDateTime> l_ = this.Measurement_Period(context);
                    bool? m_ = context.Operators.In<CqlDateTime>(k_, l_, "day");
                    bool? n_ = context.Operators.And(h_, m_);
                    Patient o_ = this.Patient(context);
                    Date p_ = o_?.BirthDateElement;
                    string q_ = p_?.Value;
                    CqlDate r_ = context.Operators.ConvertStringToDate(q_);
                    CqlDateTime t_ = context.Operators.Start(l_);
                    CqlDate u_ = context.Operators.DateFrom(t_);
                    int? v_ = context.Operators.CalculateAgeAt(r_, u_, "year");
                    bool? w_ = context.Operators.GreaterOrEqual(v_, 18);
                    bool? x_ = context.Operators.And(n_, w_);
                    return x_;
                }

                IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);
                return d_;
            });


    private readonly Cached<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> _SDE_Ethnicity_Cached = new();

    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        _SDE_Ethnicity_Cached.GetOrReplace(
            context,
            () => {
                (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
                return a_;
            });


    private readonly Cached<IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?>> _SDE_Payer_Cached = new();

    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        _SDE_Payer_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
                return a_;
            });


    private readonly Cached<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> _SDE_Race_Cached = new();

    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        _SDE_Race_Cached.GetOrReplace(
            context,
            () => {
                (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
                return a_;
            });


    private readonly Cached<CqlCode> _SDE_Sex_Cached = new();

    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        _SDE_Sex_Cached.GetOrReplace(
            context,
            () => {
                CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
                return a_;
            });


    private readonly Cached<IEnumerable<Observation>> _Qualifying_Scan_During_Inpatient_Encounter_Cached = new();

    [CqlExpressionDefinition("Qualifying Scan During Inpatient Encounter")]
    public IEnumerable<Observation> Qualifying_Scan_During_Inpatient_Encounter(CqlContext context) =>
        _Qualifying_Scan_During_Inpatient_Encounter_Cached.GetOrReplace(
            context,
            () => {
                CqlCode a_ = this.CT_dose_and_image_quality_category(context);
                IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
                IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-clinical-result"));

                IEnumerable<Observation> d_(Observation CTScan) {
                    IEnumerable<Encounter> f_ = this.Qualifying_Inpatient_Encounters(context);

                    bool? g_(Encounter InpatientEncounters) {
                        Code<ObservationStatus> k_ = CTScan?.StatusElement;
                        ObservationStatus? l_ = k_?.Value;
                        string m_ = context.Operators.Convert<string>(l_);
                        string[] n_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? o_ = context.Operators.In<string>(m_, (IEnumerable<string>)n_);
                        DataType p_ = CTScan?.Effective;
                        object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
                        CqlInterval<CqlDateTime> r_ = QICoreCommon_4_0_000.Instance.toInterval(context, q_);
                        CqlDateTime s_ = context.Operators.Start(r_);
                        Period t_ = InpatientEncounters?.Period;
                        CqlInterval<CqlDateTime> u_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, t_);
                        bool? v_ = context.Operators.In<CqlDateTime>(s_, u_, default);
                        bool? w_ = context.Operators.And(o_, v_);
                        object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
                        CqlInterval<CqlDateTime> z_ = QICoreCommon_4_0_000.Instance.toInterval(context, y_);
                        CqlDateTime aa_ = context.Operators.End(z_);
                        CqlInterval<CqlDateTime> ab_ = this.Measurement_Period(context);
                        bool? ac_ = context.Operators.In<CqlDateTime>(aa_, ab_, "day");
                        bool? ad_ = context.Operators.And(w_, ac_);
                        return ad_;
                    }

                    IEnumerable<Encounter> h_ = context.Operators.Where<Encounter>(f_, g_);
                    Observation i_(Encounter InpatientEncounters) => CTScan;
                    IEnumerable<Observation> j_ = context.Operators.Select<Encounter, Observation>(h_, i_);
                    return j_;
                }

                IEnumerable<Observation> e_ = context.Operators.SelectMany<Observation, Observation>(c_, d_);
                return e_;
            });


    private readonly Cached<IEnumerable<Observation>> _Qualifying_Scan_With_Values_Cached = new();

    [CqlExpressionDefinition("Qualifying Scan With Values")]
    public IEnumerable<Observation> Qualifying_Scan_With_Values(CqlContext context) =>
        _Qualifying_Scan_With_Values_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<Observation> a_ = this.Qualifying_Scan_During_Inpatient_Encounter(context);

                bool? b_(Observation CTScan) {
                    decimal? d_ = AlaraCommonFunctions_1_10_000.Instance.globalNoiseValue(context, CTScan);
                    bool? e_ = context.Operators.Not((bool?)(d_ is null));
                    decimal? f_ = AlaraCommonFunctions_1_10_000.Instance.sizeAdjustedValue(context, CTScan);
                    bool? g_ = context.Operators.Not((bool?)(f_ is null));
                    bool? h_ = context.Operators.And(e_, g_);
                    DataType i_ = CTScan?.Value;
                    object j_ = FHIRHelpers_4_4_000.Instance.ToValue(context, i_);
                    bool? k_ = context.Operators.Not((bool?)(j_ is null));
                    bool? l_ = context.Operators.And(h_, k_);
                    return l_;
                }

                IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);
                return c_;
            });


    private readonly Cached<IEnumerable<Observation>> _Numerator_Cached = new();

    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Observation> Numerator(CqlContext context) =>
        _Numerator_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<Observation> a_ = this.Qualifying_Scan_With_Values(context);

                bool? b_(Observation CTScanWithValues) {
                    bool? d_ = AlaraCommonFunctions_1_10_000.Instance.ctScanQualifies(context, CTScanWithValues);
                    return d_;
                }

                IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);
                return c_;
            });


    private readonly Cached<IEnumerable<Observation>> _Initial_Population_Cached = new();

    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Observation> Initial_Population(CqlContext context) =>
        _Initial_Population_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<Observation> a_ = this.Qualifying_Scan_During_Inpatient_Encounter(context);
                return a_;
            });


    private readonly Cached<IEnumerable<Observation>> _Denominator_Cached = new();

    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Observation> Denominator(CqlContext context) =>
        _Denominator_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<Observation> a_ = this.Qualifying_Scan_With_Values(context);
                return a_;
            });


    private readonly Cached<IEnumerable<Observation>> _Denominator_Exclusion_Cached = new();

    [CqlExpressionDefinition("Denominator Exclusion")]
    public IEnumerable<Observation> Denominator_Exclusion(CqlContext context) =>
        _Denominator_Exclusion_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<Observation> a_ = this.Qualifying_Scan_With_Values(context);

                bool? b_(Observation CTScanWithValues) {
                    DataType d_ = CTScanWithValues?.Value;
                    object e_ = FHIRHelpers_4_4_000.Instance.ToValue(context, d_);
                    IReadOnlyList<CqlCode> f_ = (e_ as CqlConcept)?.codes;
                    CqlCode g_ = this.Full_Body(context);
                    bool? h_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)f_, g_);
                    return h_;
                }

                IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);
                return c_;
            });


    #endregion Functions and Expressions

    private CMS1074FHIRCTIQR_1_0_000() {}

    public static CMS1074FHIRCTIQR_1_0_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "CMS1074FHIRCTIQR";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, CQMCommon_4_1_000.Instance, QICoreCommon_4_0_000.Instance, SupplementalDataElements_5_1_000.Instance, AlaraCommonFunctions_1_10_000.Instance];

    #endregion ILibrary Implementation

    #region Nested Type - Cached<T>

    private struct Cached<T>(long CacheVersion, T CachedValue)
    {
        public T GetOrReplace(ICqlContextInternals cqlContext, Func<T> factory)
        {
            var cqlContextCacheVersion = cqlContext.CacheVersion;
            if (cqlContextCacheVersion is 0)
            {
                // No caching, clear out previous values
                CacheVersion = 0;
                CachedValue = default;
                var value = factory();
                return value;
            }

            if (CacheVersion == cqlContextCacheVersion)
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

}
