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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.9.0")]
[CqlLibrary("AlaraCTClinicalFHIR", "0.4.000")]
public partial class AlaraCTClinicalFHIR_0_4_000 : ILibrary, ISingleton<AlaraCTClinicalFHIR_0_4_000>
{
    private AlaraCTClinicalFHIR_0_4_000() {}

    public static AlaraCTClinicalFHIR_0_4_000 Instance { get; } = new();

    #region ILibrary Implementation

    string ILibrary.Name => "AlaraCTClinicalFHIR";
    string ILibrary.Version => "0.4.000";
    IReadOnlyList<ILibrary> ILibrary.Dependencies => [FHIRHelpers_4_4_000.Instance, CQMCommon_2_2_000.Instance, QICoreCommon_2_1_000.Instance, SupplementalDataElements_3_5_000.Instance, AlaraCommonFunctions_1_5_000.Instance];
    #endregion Library Members

    #region Definition Methods

    [CqlDeclaration("Birth date")]
    public CqlCode Birth_date(CqlContext context) =>
        new CqlCode("21112-8", "http://loinc.org", default, default);

    [CqlDeclaration("CT dose and image quality category")]
    public CqlCode CT_dose_and_image_quality_category(CqlContext context) =>
        new CqlCode("96914-7", "http://loinc.org", default, default);

    [CqlDeclaration("Full Body")]
    public CqlCode Full_Body(CqlContext context) =>
        new CqlCode("LA31771-1", "http://loinc.org", default, default);

    [CqlDeclaration("LOINC")]
    public CqlCode[] LOINC(CqlContext context)
    {
        CqlCode[] a_ = [
            new CqlCode("21112-8", "http://loinc.org", default, default),
            new CqlCode("96914-7", "http://loinc.org", default, default),
            new CqlCode("LA31771-1", "http://loinc.org", default, default),
        ];

        return a_;
    }

    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, true);
        object d_ = context.ResolveParameter("AlaraCTClinicalFHIR-0.4.000", "Measurement Period", c_);

        return (CqlInterval<CqlDateTime>)d_;
    }

    [CqlDeclaration("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

        return b_;
    }

    [CqlDeclaration("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return a_;
    }

    [CqlDeclaration("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return a_;
    }

    [CqlDeclaration("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return a_;
    }

    [CqlDeclaration("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return a_;
    }

    [CqlDeclaration("Patients with Qualifying CTScan")]
    public IEnumerable<Observation> Patients_with_Qualifying_CTScan(CqlContext context)
    {
        CqlCode a_ = this.CT_dose_and_image_quality_category(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? d_(Observation CTScanResult)
        {
            DataType f_ = CTScanResult?.Effective;
            object g_ = FHIRHelpers_4_4_000.Instance.ToValue(context, f_);
            CqlInterval<CqlDateTime> h_ = QICoreCommon_2_1_000.Instance.ToInterval(context, g_);
            CqlDateTime i_ = context.Operators.End(h_);
            CqlInterval<CqlDateTime> j_ = this.Measurement_Period(context);
            bool? k_ = context.Operators.In<CqlDateTime>(i_, j_, "day");
            Patient l_ = this.Patient(context);
            Date m_ = l_?.BirthDateElement;
            string n_ = m_?.Value;
            CqlDateTime o_ = context.Operators.ConvertStringToDateTime(n_);
            CqlDateTime q_ = context.Operators.Start(j_);
            int? r_ = context.Operators.CalculateAgeAt(o_, q_, "year");
            bool? s_ = context.Operators.GreaterOrEqual(r_, 18);
            bool? t_ = context.Operators.And(k_, s_);

            return t_;
        };
        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

        return e_;
    }

    [CqlDeclaration("Patients with Qualifying CTScan with Values")]
    public IEnumerable<Observation> Patients_with_Qualifying_CTScan_with_Values(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Patients_with_Qualifying_CTScan(context);
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

    [CqlDeclaration("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Patients_with_Qualifying_CTScan(context);
        bool? b_ = context.Operators.Exists<Observation>(a_);

        return b_;
    }

    [CqlDeclaration("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Patients_with_Qualifying_CTScan_with_Values(context);
        bool? b_ = context.Operators.Exists<Observation>(a_);

        return b_;
    }

    [CqlDeclaration("Denominator Exclusion")]
    public bool? Denominator_Exclusion(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Patients_with_Qualifying_CTScan_with_Values(context);
        bool? b_(Observation CTScan)
        {
            DataType e_ = CTScan?.Value;
            object f_ = FHIRHelpers_4_4_000.Instance.ToValue(context, e_);
            CqlCode[] g_ = (f_ as CqlConcept)?.codes;
            CqlCode h_ = this.Full_Body(context);
            bool? i_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)g_, h_);

            return i_;
        };
        IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);
        bool? d_ = context.Operators.Exists<Observation>(c_);

        return d_;
    }

    [CqlDeclaration("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Patients_with_Qualifying_CTScan_with_Values(context);
        bool? b_(Observation CTScan)
        {
            bool? e_ = AlaraCommonFunctions_1_5_000.Instance.CT_Scan_Qualifies(context, CTScan);

            return e_;
        };
        IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);
        bool? d_ = context.Operators.Exists<Observation>(c_);

        return d_;
    }

    #endregion Definition Methods

}
