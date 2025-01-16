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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.10.0")]
[CqlLibrary("ALARACTOQRFHIR", "0.4.000")]
public partial class ALARACTOQRFHIR_0_4_000 : ILibrary, ISingleton<ALARACTOQRFHIR_0_4_000>
{
    private ALARACTOQRFHIR_0_4_000() {}

    public static ALARACTOQRFHIR_0_4_000 Instance { get; } = new();

    #region ILibrary Implementation

    string ILibrary.Name => "ALARACTOQRFHIR";
    string ILibrary.Version => "0.4.000";
    IReadOnlyCollection<ILibrary> ILibrary.Dependencies => [FHIRHelpers_4_4_000.Instance, CQMCommon_2_2_000.Instance, QICoreCommon_2_1_000.Instance, SupplementalDataElements_3_5_000.Instance, AlaraCommonFunctions_1_5_000.Instance];

    #endregion ILibrary Implementation

    #region Definition Methods

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
    public CqlValueSet Encounter_Inpatient(CqlContext context) =>
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", default);


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
        object d_ = context.ResolveParameter("ALARACTOQRFHIR-0.4.000", "Measurement Period", c_);

        return (CqlInterval<CqlDateTime>)d_;
    }


    [CqlDeclaration("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

        return b_;
    }


    [CqlDeclaration("Qualified Scan")]
    public IEnumerable<Observation> Qualified_Scan(CqlContext context)
    {
        CqlCode a_ = this.CT_dose_and_image_quality_category(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        bool? d_(Observation CTScan)
        {
            DataType f_ = CTScan?.Effective;
            object g_ = FHIRHelpers_4_4_000.Instance.ToValue(context, f_);
            CqlInterval<CqlDateTime> h_ = QICoreCommon_2_1_000.Instance.ToInterval(context, g_);
            CqlDateTime i_ = context.Operators.End(h_);
            CqlInterval<CqlDateTime> j_ = this.Measurement_Period(context);
            bool? k_ = context.Operators.In<CqlDateTime>(i_, j_, "day");
            Patient l_ = this.Patient(context);
            Date m_ = l_?.BirthDateElement;
            string n_ = m_?.Value;
            CqlDate o_ = context.Operators.ConvertStringToDate(n_);
            CqlDateTime q_ = context.Operators.Start(j_);
            CqlDate r_ = context.Operators.DateFrom(q_);
            int? s_ = context.Operators.CalculateAgeAt(o_, r_, "year");
            bool? t_ = context.Operators.GreaterOrEqual(s_, 18);
            bool? u_ = context.Operators.And(k_, t_);

            return u_;
        };
        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

        return e_;
    }


    [CqlDeclaration("Qualified Scan without Inpatient Encounter")]
    public IEnumerable<Observation> Qualified_Scan_without_Inpatient_Encounter(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Qualified_Scan(context);
        IEnumerable<Observation> c_(Observation QualifiedCTScan)
        {
            CqlValueSet f_ = this.Encounter_Inpatient(context);
            IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
            bool? h_(Encounter InpatientEncounter)
            {
                DataType l_ = QualifiedCTScan?.Effective;
                object m_ = FHIRHelpers_4_4_000.Instance.ToValue(context, l_);
                CqlInterval<CqlDateTime> n_ = QICoreCommon_2_1_000.Instance.ToInterval(context, m_);
                CqlDateTime o_ = context.Operators.Start(n_);
                Period p_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> q_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, p_);
                CqlInterval<CqlDateTime> r_ = QICoreCommon_2_1_000.Instance.ToInterval(context, q_ as object);
                bool? s_ = context.Operators.In<CqlDateTime>(o_, r_, default);

                return s_;
            };
            IEnumerable<Encounter> i_ = context.Operators.Where<Encounter>(g_, h_);
            Observation j_(Encounter InpatientEncounter) =>
                QualifiedCTScan;
            IEnumerable<Observation> k_ = context.Operators.Select<Encounter, Observation>(i_, j_);

            return k_;
        };
        IEnumerable<Observation> d_ = context.Operators.SelectMany<Observation, Observation>(a_, c_);
        IEnumerable<Observation> e_ = context.Operators.Except<Observation>(a_, d_);

        return e_;
    }


    [CqlDeclaration("Qualified Scan with Values")]
    public IEnumerable<Observation> Qualified_Scan_with_Values(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Qualified_Scan_without_Inpatient_Encounter(context);
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


    [CqlDeclaration("Denominator")]
    public IEnumerable<Observation> Denominator(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Qualified_Scan_with_Values(context);

        return a_;
    }


    [CqlDeclaration("Denominator Exclusion")]
    public IEnumerable<Observation> Denominator_Exclusion(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Qualified_Scan_with_Values(context);
        bool? b_(Observation CTScan)
        {
            DataType d_ = CTScan?.Value;
            object e_ = FHIRHelpers_4_4_000.Instance.ToValue(context, d_);
            CqlCode[] f_ = (e_ as CqlConcept)?.codes;
            CqlCode g_ = this.Full_Body(context);
            bool? h_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)f_, g_);

            return h_;
        };
        IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);

        return c_;
    }


    [CqlDeclaration("Initial Population")]
    public IEnumerable<Observation> Initial_Population(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Qualified_Scan_without_Inpatient_Encounter(context);

        return a_;
    }


    [CqlDeclaration("Numerator")]
    public IEnumerable<Observation> Numerator(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Qualified_Scan_with_Values(context);
        bool? b_(Observation CTScan)
        {
            bool? d_ = AlaraCommonFunctions_1_5_000.Instance.CT_Scan_Qualifies(context, CTScan);

            return d_;
        };
        IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);

        return c_;
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


    #endregion Definition Methods

}
