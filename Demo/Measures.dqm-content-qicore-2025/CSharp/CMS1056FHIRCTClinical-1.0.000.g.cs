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
[CqlLibrary("CMS1056FHIRCTClinical", "1.0.000")]
public partial class CMS1056FHIRCTClinical_1_0_000 : ILibrary, ILibraryInternals, ISingleton<CMS1056FHIRCTClinical_1_0_000>
{
    #region Codes (2)

    [CqlCodeDefinition("CT dose and image quality category", codeId: "96914-7", codeSystem: "http://loinc.org")]
    public CqlCode CT_dose_and_image_quality_category(CqlContext _) => _CT_dose_and_image_quality_category;
    private static readonly CqlCode _CT_dose_and_image_quality_category = new CqlCode("96914-7", "http://loinc.org");

    [CqlCodeDefinition("Full Body", codeId: "LA31771-1", codeSystem: "http://loinc.org")]
    public CqlCode Full_Body(CqlContext _) => _Full_Body;
    private static readonly CqlCode _Full_Body = new CqlCode("LA31771-1", "http://loinc.org");

    #endregion Codes

    #region CodeSystems (1)

    [CqlCodeSystemDefinition("LOINC", codeSystemId: "http://loinc.org", codeSystemVersion: null)]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, [
          _CT_dose_and_image_quality_category,
          _Full_Body]);

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
        object d_ = context.ResolveParameter("CMS1056FHIRCTClinical-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (11)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Patient, Patient_Compute, context) ?? Patient_Compute(context);

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
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


    [CqlExpressionDefinition("Patients with Qualifying CTScan")]
    public IEnumerable<Observation> Patients_with_Qualifying_CTScan(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Patients_with_Qualifying_CTScan, Patients_with_Qualifying_CTScan_Compute, context) ?? Patients_with_Qualifying_CTScan_Compute(context);

    private IEnumerable<Observation> Patients_with_Qualifying_CTScan_Compute(CqlContext context)
    {
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
    }


    [CqlExpressionDefinition("Patients with Qualifying CTScan with Values")]
    public IEnumerable<Observation> Patients_with_Qualifying_CTScan_with_Values(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Patients_with_Qualifying_CTScan_with_Values, Patients_with_Qualifying_CTScan_with_Values_Compute, context) ?? Patients_with_Qualifying_CTScan_with_Values_Compute(context);

    private IEnumerable<Observation> Patients_with_Qualifying_CTScan_with_Values_Compute(CqlContext context)
    {
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
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute, context) ?? Initial_Population_Compute(context);

    private bool? Initial_Population_Compute(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Patients_with_Qualifying_CTScan(context);
        bool? b_ = context.Operators.Exists<Observation>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute, context) ?? Denominator_Compute(context);

    private bool? Denominator_Compute(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Patients_with_Qualifying_CTScan_with_Values(context);
        bool? b_ = context.Operators.Exists<Observation>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Denominator Exclusion")]
    public bool? Denominator_Exclusion(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Denominator_Exclusion, Denominator_Exclusion_Compute, context) ?? Denominator_Exclusion_Compute(context);

    private bool? Denominator_Exclusion_Compute(CqlContext context)
    {
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
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute, context) ?? Numerator_Compute(context);

    private bool? Numerator_Compute(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Patients_with_Qualifying_CTScan_with_Values(context);

        bool? b_(Observation CTScanWithValues) {
            bool? e_ = AlaraCommonFunctions_1_10_000.Instance.ctScanQualifies(context, CTScanWithValues);
            return e_;
        }

        IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);
        bool? d_ = context.Operators.Exists<Observation>(c_);
        return d_;
    }


    #endregion Functions and Expressions

    #region Cache Index Fields (12)

    private int _cacheIndex_Measurement_Period = -1;
    private int _cacheIndex_Patient = -1;
    private int _cacheIndex_SDE_Ethnicity = -1;
    private int _cacheIndex_SDE_Payer = -1;
    private int _cacheIndex_SDE_Race = -1;
    private int _cacheIndex_SDE_Sex = -1;
    private int _cacheIndex_Patients_with_Qualifying_CTScan = -1;
    private int _cacheIndex_Patients_with_Qualifying_CTScan_with_Values = -1;
    private int _cacheIndex_Initial_Population = -1;
    private int _cacheIndex_Denominator = -1;
    private int _cacheIndex_Denominator_Exclusion = -1;
    private int _cacheIndex_Numerator = -1;

    #endregion Cache Index Fields

    #region ILibraryInternals Implementation

    // Reference to the execution cache instance that initialized this library
    private CqlLibrarySetInvocationCache _cache;

    /// <summary>
    /// Initializes cache indices for this library's cached expressions.
    /// </summary>
    /// <param name="cache">The execution cache instance performing initialization.</param>
    /// <param name="startIndex">The starting index for cache field assignment.</param>
    /// <returns>The number of cache indices initialized (number of cached expressions in this library).</returns>
    int ILibraryInternals.InitializeCacheIndices(
        CqlLibrarySetInvocationCache cache,
        int startIndex)
    {
        // Skip if already initialized by this cache instance (allows re-initialization with different cache)
        if (_cache == cache)
            return 0;

        _cache = cache;

        var index = startIndex;
        _cacheIndex_Measurement_Period = index++;
        _cacheIndex_Patient = index++;
        _cacheIndex_SDE_Ethnicity = index++;
        _cacheIndex_SDE_Payer = index++;
        _cacheIndex_SDE_Race = index++;
        _cacheIndex_SDE_Sex = index++;
        _cacheIndex_Patients_with_Qualifying_CTScan = index++;
        _cacheIndex_Patients_with_Qualifying_CTScan_with_Values = index++;
        _cacheIndex_Initial_Population = index++;
        _cacheIndex_Denominator = index++;
        _cacheIndex_Denominator_Exclusion = index++;
        _cacheIndex_Numerator = index++;
        return index - startIndex;
    }

    #endregion ILibraryInternals Implementation

    #region Singleton Lifetime Members

    private CMS1056FHIRCTClinical_1_0_000() {}

    public static CMS1056FHIRCTClinical_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS1056FHIRCTClinical";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, CQMCommon_4_1_000.Instance, QICoreCommon_4_0_000.Instance, SupplementalDataElements_5_1_000.Instance, AlaraCommonFunctions_1_10_000.Instance];

    #endregion ILibrary Implementation

}
