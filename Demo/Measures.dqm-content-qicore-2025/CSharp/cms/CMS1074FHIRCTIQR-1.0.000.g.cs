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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.2.0")]
[CqlLibrary("CMS1074FHIRCTIQR", "1.0.000")]
public partial class CMS1074FHIRCTIQR_1_0_000 : ILibrary, ISingleton<CMS1074FHIRCTIQR_1_0_000>
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
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = 4881502281241321616L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("CMS1074FHIRCTIQR-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (12)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = -3725977917517927085L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Qualifying Inpatient Encounters")]
    public IEnumerable<Encounter> Qualifying_Inpatient_Encounters(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Qualifying_Inpatient_Encounters, Qualifying_Inpatient_Encounters_Compute);

    private const long _cacheIndex_Qualifying_Inpatient_Encounters = -531974183908169674L;

    private IEnumerable<Encounter> Qualifying_Inpatient_Encounters_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

        bool? c_(Encounter InpatientEncounter) {
            Code<Encounter.EncounterStatus> e_ = InpatientEncounter?.StatusElement;
            Encounter.EncounterStatus? f_ = e_?.Value;
            Code<Encounter.EncounterStatus> g_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(f_);
            bool? h_ = context.Operators.Equivalent(g_, "finished");

            CqlBoolean i_() {
                Period k_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
                CqlDateTime m_ = context.Operators.End(l_);
                CqlInterval<CqlDateTime> n_ = this.Measurement_Period(context);
                bool? o_ = context.Operators.In<CqlDateTime>(m_, n_, "day");
                return o_;
            }


            CqlBoolean j_() {
                Patient p_ = this.Patient(context);
                Date q_ = p_?.BirthDateElement;
                string r_ = q_?.Value;
                CqlDate s_ = context.Operators.ConvertStringToDate(r_);
                CqlInterval<CqlDateTime> t_ = this.Measurement_Period(context);
                CqlDateTime u_ = context.Operators.Start(t_);
                CqlDate v_ = context.Operators.DateFrom(u_);
                int? w_ = context.Operators.CalculateAgeAt(s_, v_, "year");
                bool? x_ = context.Operators.GreaterOrEqual(w_, 18);
                return x_;
            }

            return /* CQL 'and' (25:5-27:69) */ (/* CQL 'and' (25:11-26:75) */ ((CqlBoolean)h_
                && i_())
                && j_());
        }

        IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = -4908206822605951338L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = 6185991466726679010L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = -1487013177177422162L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = -640909610564644632L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    [CqlExpressionDefinition("Qualifying Scan During Inpatient Encounter")]
    public IEnumerable<Observation> Qualifying_Scan_During_Inpatient_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Qualifying_Scan_During_Inpatient_Encounter, Qualifying_Scan_During_Inpatient_Encounter_Compute);

    private const long _cacheIndex_Qualifying_Scan_During_Inpatient_Encounter = -2140962754819817913L;

    private IEnumerable<Observation> Qualifying_Scan_During_Inpatient_Encounter_Compute(CqlContext context)
    {
        CqlCode a_ = this.CT_dose_and_image_quality_category(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-clinical-result"));

        bool? d_(Observation CTScan) {
            IEnumerable<Encounter> f_ = this.Qualifying_Inpatient_Encounters(context);

            bool? g_(Encounter InpatientEncounters) {
                Code<ObservationStatus> i_ = CTScan?.StatusElement;
                ObservationStatus? j_ = i_?.Value;
                string k_ = context.Operators.Convert<string>(j_);
                string[] l_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? m_ = context.Operators.In<string>(k_, (IEnumerable<string>)l_);

                CqlBoolean n_() {
                    DataType p_ = CTScan?.Effective;
                    object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
                    CqlInterval<CqlDateTime> r_ = QICoreCommon_4_0_000.Instance.toInterval(context, q_);
                    CqlDateTime s_ = context.Operators.Start(r_);
                    Period t_ = InpatientEncounters?.Period;
                    CqlInterval<CqlDateTime> u_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, t_);
                    bool? v_ = context.Operators.In<CqlDateTime>(s_, u_, (string)default);
                    return v_;
                }


                CqlBoolean o_() {
                    DataType w_ = CTScan?.Effective;
                    object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                    CqlInterval<CqlDateTime> y_ = QICoreCommon_4_0_000.Instance.toInterval(context, x_);
                    CqlDateTime z_ = context.Operators.End(y_);
                    CqlInterval<CqlDateTime> aa_ = this.Measurement_Period(context);
                    bool? ab_ = context.Operators.In<CqlDateTime>(z_, aa_, "day");
                    return ab_;
                }

                return /* CQL 'and' (64:17-66:83) */ (/* CQL 'and' (64:17-65:84) */ ((CqlBoolean)m_
                    && n_())
                    && o_());
            }

            bool? h_ = context.Operators.WhereAny<Encounter>(f_, g_);
            return h_;
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
        return e_;
    }


    [CqlExpressionDefinition("Qualifying Scan With Values")]
    public IEnumerable<Observation> Qualifying_Scan_With_Values(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Qualifying_Scan_With_Values, Qualifying_Scan_With_Values_Compute);

    private const long _cacheIndex_Qualifying_Scan_With_Values = -5289659592704077932L;

    private IEnumerable<Observation> Qualifying_Scan_With_Values_Compute(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Qualifying_Scan_During_Inpatient_Encounter(context);

        bool? b_(Observation CTScan) {
            decimal? d_ = AlaraCommonFunctions_1_10_000.Instance.globalNoiseValue(context, CTScan);

            CqlBoolean e_() {
                DataType f_ = CTScan?.Value;
                object g_ = FHIRHelpers_4_4_000.Instance.ToValue(context, f_);
                return !((bool?)(g_ is null));
            }

            return /* CQL 'and' (57:5-59:34) */ (/* CQL 'and' (57:11-58:50) */ ((CqlBoolean)(!((bool?)(d_ is null)))
                && !((bool?)((AlaraCommonFunctions_1_10_000.Instance.sizeAdjustedValue(context, CTScan)) is null)))
                && e_());
        }

        IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Observation> Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = -483329915085667812L;

    private IEnumerable<Observation> Numerator_Compute(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Qualifying_Scan_With_Values(context);

        bool? b_(Observation CTScanWithValues) {
            bool? d_ = AlaraCommonFunctions_1_10_000.Instance.ctScanQualifies(context, CTScanWithValues);
            return d_;
        }

        IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Observation> Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = -3454090351737308790L;

    private IEnumerable<Observation> Initial_Population_Compute(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Qualifying_Scan_During_Inpatient_Encounter(context);
        return a_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Observation> Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = 3143525204808867338L;

    private IEnumerable<Observation> Denominator_Compute(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Qualifying_Scan_With_Values(context);
        return a_;
    }


    [CqlExpressionDefinition("Denominator Exclusion")]
    public IEnumerable<Observation> Denominator_Exclusion(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exclusion, Denominator_Exclusion_Compute);

    private const long _cacheIndex_Denominator_Exclusion = -3937048714320910955L;

    private IEnumerable<Observation> Denominator_Exclusion_Compute(CqlContext context)
    {
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
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private CMS1074FHIRCTIQR_1_0_000() {}

    public static CMS1074FHIRCTIQR_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS1074FHIRCTIQR";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, CQMCommon_4_1_000.Instance, QICoreCommon_4_0_000.Instance, SupplementalDataElements_5_1_000.Instance, AlaraCommonFunctions_1_10_000.Instance];

    #endregion ILibrary Implementation

}
