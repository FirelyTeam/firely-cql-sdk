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
[CqlLibrary("CMS1206FHIRCTOQR", "1.0.000")]
public partial class CMS1206FHIRCTOQR_1_0_000 : ILibrary, ILibraryInternals, ISingleton<CMS1206FHIRCTOQR_1_0_000>
{
    #region ValueSets (1)

    [CqlValueSetDefinition("Encounter Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext _) => _Encounter_Inpatient;
    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    #endregion ValueSets

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
        ((ICqlContextInternals)context).GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("CMS1206FHIRCTOQR-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (12)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Qualified Scan")]
    public IEnumerable<Observation> Qualified_Scan(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute(_cacheIndex_Qualified_Scan, Qualified_Scan_Compute);

    private IEnumerable<Observation> Qualified_Scan_Compute(CqlContext context)
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


    [CqlExpressionDefinition("Qualified Scan Without Inpatient Encounter")]
    public IEnumerable<Observation> Qualified_Scan_Without_Inpatient_Encounter(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute(_cacheIndex_Qualified_Scan_Without_Inpatient_Encounter, Qualified_Scan_Without_Inpatient_Encounter_Compute);

    private IEnumerable<Observation> Qualified_Scan_Without_Inpatient_Encounter_Compute(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Qualified_Scan(context);

        IEnumerable<Observation> c_(Observation QualifiedCTScan) {
            CqlValueSet f_ = this.Encounter_Inpatient(context);
            IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? h_(Encounter InpatientEncounter) {
                Code<Encounter.EncounterStatus> l_ = InpatientEncounter?.StatusElement;
                Encounter.EncounterStatus? m_ = l_?.Value;
                Code<Encounter.EncounterStatus> n_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(m_);
                bool? o_ = context.Operators.Equivalent(n_, "finished");
                Period p_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> q_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, p_);
                CqlDateTime r_ = context.Operators.End(q_);
                CqlInterval<CqlDateTime> s_ = this.Measurement_Period(context);
                bool? t_ = context.Operators.In<CqlDateTime>(r_, s_, "day");
                bool? u_ = context.Operators.And(o_, t_);
                DataType v_ = QualifiedCTScan?.Effective;
                object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                CqlInterval<CqlDateTime> x_ = QICoreCommon_4_0_000.Instance.toInterval(context, w_);
                CqlDateTime y_ = context.Operators.Start(x_);
                CqlInterval<CqlDateTime> aa_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, p_);
                bool? ab_ = context.Operators.In<CqlDateTime>(y_, aa_, default);
                bool? ac_ = context.Operators.And(u_, ab_);
                return ac_;
            }

            IEnumerable<Encounter> i_ = context.Operators.Where<Encounter>(g_, h_);
            Observation j_(Encounter InpatientEncounter) => QualifiedCTScan;
            IEnumerable<Observation> k_ = context.Operators.Select<Encounter, Observation>(i_, j_);
            return k_;
        }

        IEnumerable<Observation> d_ = context.Operators.SelectMany<Observation, Observation>(a_, c_);
        IEnumerable<Observation> e_ = context.Operators.Except<Observation>(a_, d_);
        return e_;
    }


    [CqlExpressionDefinition("Qualified Scan With Values")]
    public IEnumerable<Observation> Qualified_Scan_With_Values(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute(_cacheIndex_Qualified_Scan_With_Values, Qualified_Scan_With_Values_Compute);

    private IEnumerable<Observation> Qualified_Scan_With_Values_Compute(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Qualified_Scan_Without_Inpatient_Encounter(context);

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


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Observation> Denominator(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private IEnumerable<Observation> Denominator_Compute(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Qualified_Scan_With_Values(context);
        return a_;
    }


    [CqlExpressionDefinition("Denominator Exclusion")]
    public IEnumerable<Observation> Denominator_Exclusion(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute(_cacheIndex_Denominator_Exclusion, Denominator_Exclusion_Compute);

    private IEnumerable<Observation> Denominator_Exclusion_Compute(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Qualified_Scan_With_Values(context);

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
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Observation> Initial_Population(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private IEnumerable<Observation> Initial_Population_Compute(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Qualified_Scan_Without_Inpatient_Encounter(context);
        return a_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Observation> Numerator(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private IEnumerable<Observation> Numerator_Compute(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Qualified_Scan_With_Values(context);

        bool? b_(Observation CTScanWithValues) {
            bool? d_ = AlaraCommonFunctions_1_10_000.Instance.ctScanQualifies(context, CTScanWithValues);
            return d_;
        }

        IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    #endregion Functions and Expressions

    #region Cache Index Fields (13)

    private int _cacheIndex_Measurement_Period = -1;
    private int _cacheIndex_Patient = -1;
    private int _cacheIndex_Qualified_Scan = -1;
    private int _cacheIndex_Qualified_Scan_Without_Inpatient_Encounter = -1;
    private int _cacheIndex_Qualified_Scan_With_Values = -1;
    private int _cacheIndex_Denominator = -1;
    private int _cacheIndex_Denominator_Exclusion = -1;
    private int _cacheIndex_Initial_Population = -1;
    private int _cacheIndex_Numerator = -1;
    private int _cacheIndex_SDE_Ethnicity = -1;
    private int _cacheIndex_SDE_Payer = -1;
    private int _cacheIndex_SDE_Race = -1;
    private int _cacheIndex_SDE_Sex = -1;

    #endregion Cache Index Fields

    #region ILibraryInternals Implementation

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
        _cacheIndex_Qualified_Scan = index++;
        _cacheIndex_Qualified_Scan_Without_Inpatient_Encounter = index++;
        _cacheIndex_Qualified_Scan_With_Values = index++;
        _cacheIndex_Denominator = index++;
        _cacheIndex_Denominator_Exclusion = index++;
        _cacheIndex_Initial_Population = index++;
        _cacheIndex_Numerator = index++;
        _cacheIndex_SDE_Ethnicity = index++;
        _cacheIndex_SDE_Payer = index++;
        _cacheIndex_SDE_Race = index++;
        _cacheIndex_SDE_Sex = index++;
        return index - startIndex;
    }

    #endregion ILibraryInternals Implementation

    #region Singleton Lifetime Members

    private CMS1206FHIRCTOQR_1_0_000() {}

    public static CMS1206FHIRCTOQR_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS1206FHIRCTOQR";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, CQMCommon_4_1_000.Instance, QICoreCommon_4_0_000.Instance, SupplementalDataElements_5_1_000.Instance, AlaraCommonFunctions_1_10_000.Instance];

    #endregion ILibrary Implementation

}
