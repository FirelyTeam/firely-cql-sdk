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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "3.0.0.0")]
[CqlLibrary("AlaraCTIQRFHIR", "0.4.000")]
public partial class AlaraCTIQRFHIR_0_4_000 : ILibrary, ISingleton<AlaraCTIQRFHIR_0_4_000>
{
    private AlaraCTIQRFHIR_0_4_000() {}

    public static AlaraCTIQRFHIR_0_4_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "AlaraCTIQRFHIR";
    public string Version => "0.4.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, CQMCommon_2_2_000.Instance, QICoreCommon_2_1_000.Instance, SupplementalDataElements_3_5_000.Instance, AlaraCommonFunctions_1_5_000.Instance];

    #endregion ILibrary Implementation

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

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, true);
        object d_ = context.ResolveParameter("AlaraCTIQRFHIR-0.4.000", "Measurement Period", c_);

        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

        return b_;
    }


    [CqlExpressionDefinition("Qualifying Inpatient Encounters")]
    public IEnumerable<Encounter> Qualifying_Inpatient_Encounters(CqlContext context)
    {
        CqlValueSet a_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? c_(Encounter InpatientEncounter)
        {
            Period e_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> f_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, e_);
            CqlInterval<CqlDateTime> g_ = this.Measurement_Period(context);
            bool? h_ = context.Operators.Overlaps(f_, g_, default);
            Patient i_ = this.Patient(context);
            Date j_ = i_?.BirthDateElement;
            string k_ = j_?.Value;
            CqlDate l_ = context.Operators.ConvertStringToDate(k_);
            CqlDateTime n_ = context.Operators.Start(g_);
            CqlDate o_ = context.Operators.DateFrom(n_);
            int? p_ = context.Operators.CalculateAgeAt(l_, o_, "year");
            bool? q_ = context.Operators.GreaterOrEqual(p_, 18);
            bool? r_ = context.Operators.And(h_, q_);

            return r_;
        };
        IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);

        return d_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return a_;
    }


    [CqlExpressionDefinition("Qualifying Scan During Inpatient Encounter")]
    public IEnumerable<Observation> Qualifying_Scan_During_Inpatient_Encounter(CqlContext context)
    {
        CqlCode a_ = this.CT_dose_and_image_quality_category(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> d_(Observation CTScan)
        {
            IEnumerable<Encounter> f_ = this.Qualifying_Inpatient_Encounters(context);
            bool? g_(Encounter InpatientEncounters)
            {
                DataType k_ = CTScan?.Effective;
                object l_ = FHIRHelpers_4_4_000.Instance.ToValue(context, k_);
                CqlInterval<CqlDateTime> m_ = QICoreCommon_2_1_000.Instance.ToInterval(context, l_);
                CqlDateTime n_ = context.Operators.Start(m_);
                Period o_ = InpatientEncounters?.Period;
                CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, o_);
                bool? q_ = context.Operators.In<CqlDateTime>(n_, p_, default);
                object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, k_);
                CqlInterval<CqlDateTime> t_ = QICoreCommon_2_1_000.Instance.ToInterval(context, s_);
                CqlDateTime u_ = context.Operators.End(t_);
                CqlInterval<CqlDateTime> v_ = this.Measurement_Period(context);
                bool? w_ = context.Operators.In<CqlDateTime>(u_, v_, "day");
                bool? x_ = context.Operators.And(q_, w_);

                return x_;
            };
            IEnumerable<Encounter> h_ = context.Operators.Where<Encounter>(f_, g_);
            Observation i_(Encounter InpatientEncounters) =>
                CTScan;
            IEnumerable<Observation> j_ = context.Operators.Select<Encounter, Observation>(h_, i_);

            return j_;
        };
        IEnumerable<Observation> e_ = context.Operators.SelectMany<Observation, Observation>(c_, d_);

        return e_;
    }


    [CqlExpressionDefinition("Qualifying Scan with Values")]
    public IEnumerable<Observation> Qualifying_Scan_with_Values(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Qualifying_Scan_During_Inpatient_Encounter(context);
        bool? b_(Observation CTScan)
        {
            decimal? d_ = AlaraCommonFunctions_1_5_000.Instance.Global_Noise_Value(context, CTScan);
            bool? e_ = context.Operators.Not((bool?)(d_ is null));
            decimal? f_ = AlaraCommonFunctions_1_5_000.Instance.Size_Adjusted_Value(context, CTScan);
            bool? g_ = context.Operators.Not((bool?)(f_ is null));
            bool? h_ = context.Operators.And(e_, g_);
            DataType i_ = CTScan?.Value;
            object j_ = FHIRHelpers_4_4_000.Instance.ToValue(context, i_);
            bool? k_ = context.Operators.Not((bool?)(j_ is null));
            bool? l_ = context.Operators.And(h_, k_);

            return l_;
        };
        IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Observation> Numerator(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Qualifying_Scan_with_Values(context);
        bool? b_(Observation CTScan)
        {
            bool? d_ = AlaraCommonFunctions_1_5_000.Instance.CT_Scan_Qualifies(context, CTScan);

            return d_;
        };
        IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Observation> Initial_Population(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Qualifying_Scan_During_Inpatient_Encounter(context);

        return a_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Observation> Denominator(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Qualifying_Scan_with_Values(context);

        return a_;
    }


    [CqlExpressionDefinition("Denominator Exclusion")]
    public IEnumerable<Observation> Denominator_Exclusion(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Qualifying_Scan_with_Values(context);
        bool? b_(Observation CTScan)
        {
            DataType d_ = CTScan?.Value;
            object e_ = FHIRHelpers_4_4_000.Instance.ToValue(context, d_);
            IReadOnlyList<CqlCode> f_ = (e_ as CqlConcept)?.codes;
            CqlCode g_ = this.Full_Body(context);
            bool? h_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)f_, g_);

            return h_;
        };
        IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);

        return c_;
    }


    #endregion Expressions

}
