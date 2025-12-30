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
[CqlLibrary("CMS1056FHIRCTClinical", "1.0.000")]
public partial class CMS1056FHIRCTClinical_1_0_000 : ILibrary, ISingleton<CMS1056FHIRCTClinical_1_0_000>
{
    private CMS1056FHIRCTClinical_1_0_000() {}

    public static CMS1056FHIRCTClinical_1_0_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "CMS1056FHIRCTClinical";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, CQMCommon_4_1_000.Instance, QICoreCommon_4_0_000.Instance, SupplementalDataElements_5_1_000.Instance, AlaraCommonFunctions_1_10_000.Instance];

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

    private Cached<CqlInterval<CqlDateTime>> _Measurement_Period_Cached = new();

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        _Measurement_Period_Cached.GetOrReplace(
            context,
            () => {
                object a_ = context.ResolveParameter("CMS1056FHIRCTClinical-1.0.000", "Measurement Period", null);
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


    private Cached<IEnumerable<Observation>> _Patients_with_Qualifying_CTScan_Cached = new();

    [CqlExpressionDefinition("Patients with Qualifying CTScan")]
    public IEnumerable<Observation> Patients_with_Qualifying_CTScan(CqlContext context) =>
        _Patients_with_Qualifying_CTScan_Cached.GetOrReplace(
            context,
            () => {
                CqlCode a_ = this.CT_dose_and_image_quality_category(context);
                IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
                IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-clinical-result"));

                bool? d_(Observation CTScanResult) {
                    Code<ObservationStatus> f_ = CTScanResult?.StatusElement;
                    ObservationStatus? g_ = f_?.Value;
                    string h_ = context.Operators.Convert<string>(g_);
                    string[] i_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? j_ = context.Operators.In<string>(h_, (IEnumerable<string>)i_);
                    DataType k_ = CTScanResult?.Effective;
                    object l_ = FHIRHelpers_4_4_000.Instance.ToValue(context, k_);
                    CqlInterval<CqlDateTime> m_ = QICoreCommon_4_0_000.Instance.toInterval(context, l_);
                    CqlDateTime n_ = context.Operators.End(m_);
                    CqlInterval<CqlDateTime> o_ = this.Measurement_Period(context);
                    bool? p_ = context.Operators.In<CqlDateTime>(n_, o_, "day");
                    bool? q_ = context.Operators.And(j_, p_);
                    Patient r_ = this.Patient(context);
                    Date s_ = r_?.BirthDateElement;
                    string t_ = s_?.Value;
                    CqlDate u_ = context.Operators.ConvertStringToDate(t_);
                    CqlDateTime w_ = context.Operators.Start(o_);
                    CqlDate x_ = context.Operators.DateFrom(w_);
                    int? y_ = context.Operators.CalculateAgeAt(u_, x_, "year");
                    bool? z_ = context.Operators.GreaterOrEqual(y_, 18);
                    bool? aa_ = context.Operators.And(q_, z_);
                    return aa_;
                }

                IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
                return e_;
            });


    private Cached<IEnumerable<Observation>> _Patients_with_Qualifying_CTScan_with_Values_Cached = new();

    [CqlExpressionDefinition("Patients with Qualifying CTScan with Values")]
    public IEnumerable<Observation> Patients_with_Qualifying_CTScan_with_Values(CqlContext context) =>
        _Patients_with_Qualifying_CTScan_with_Values_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<Observation> a_ = this.Patients_with_Qualifying_CTScan(context);

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


    private Cached<bool?> _Initial_Population_Cached = new();

    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context) =>
        _Initial_Population_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<Observation> a_ = this.Patients_with_Qualifying_CTScan(context);
                bool? b_ = context.Operators.Exists<Observation>(a_);
                return b_;
            });


    private Cached<bool?> _Denominator_Cached = new();

    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context) =>
        _Denominator_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<Observation> a_ = this.Patients_with_Qualifying_CTScan_with_Values(context);
                bool? b_ = context.Operators.Exists<Observation>(a_);
                return b_;
            });


    private Cached<bool?> _Denominator_Exclusion_Cached = new();

    [CqlExpressionDefinition("Denominator Exclusion")]
    public bool? Denominator_Exclusion(CqlContext context) =>
        _Denominator_Exclusion_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<Observation> a_ = this.Patients_with_Qualifying_CTScan_with_Values(context);

                bool? b_(Observation CTScanWithValues) {
                    DataType e_ = CTScanWithValues?.Value;
                    object f_ = FHIRHelpers_4_4_000.Instance.ToValue(context, e_);
                    IReadOnlyList<CqlCode> g_ = (f_ as CqlConcept)?.codes;
                    CqlCode h_ = this.Full_Body(context);
                    bool? i_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)g_, h_);
                    return i_;
                }

                IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);
                bool? d_ = context.Operators.Exists<Observation>(c_);
                return d_;
            });


    private Cached<bool?> _Numerator_Cached = new();

    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context) =>
        _Numerator_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<Observation> a_ = this.Patients_with_Qualifying_CTScan_with_Values(context);

                bool? b_(Observation CTScanWithValues) {
                    bool? e_ = AlaraCommonFunctions_1_10_000.Instance.ctScanQualifies(context, CTScanWithValues);
                    return e_;
                }

                IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);
                bool? d_ = context.Operators.Exists<Observation>(c_);
                return d_;
            });


    #endregion Functions and Expressions

}
