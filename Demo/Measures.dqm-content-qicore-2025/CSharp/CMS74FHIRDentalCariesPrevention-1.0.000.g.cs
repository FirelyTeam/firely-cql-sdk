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
[CqlLibrary("CMS74FHIRDentalCariesPrevention", "1.0.000")]
public partial class CMS74FHIRDentalCariesPrevention_1_0_000 : ILibrary, ISingleton<CMS74FHIRDentalCariesPrevention_1_0_000>
{
    private CMS74FHIRDentalCariesPrevention_1_0_000() {}

    public static CMS74FHIRDentalCariesPrevention_1_0_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "CMS74FHIRDentalCariesPrevention";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_5_1_000.Instance, QICoreCommon_4_0_000.Instance, Hospice_6_18_000.Instance, Status_1_15_000.Instance];

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

    [CqlValueSetDefinition("Clinical Oral Evaluation", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.125.12.1003", valueSetVersion: null)]
    public CqlValueSet Clinical_Oral_Evaluation(CqlContext _) => _Clinical_Oral_Evaluation;
    private static readonly CqlValueSet _Clinical_Oral_Evaluation = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.125.12.1003", null);

    [CqlValueSetDefinition("Discharged to Health Care Facility for Hospice Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207", valueSetVersion: null)]
    public CqlValueSet Discharged_to_Health_Care_Facility_for_Hospice_Care(CqlContext _) => _Discharged_to_Health_Care_Facility_for_Hospice_Care;
    private static readonly CqlValueSet _Discharged_to_Health_Care_Facility_for_Hospice_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207", null);

    [CqlValueSetDefinition("Discharged to Home for Hosice Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209", valueSetVersion: null)]
    public CqlValueSet Discharged_to_Home_for_Hosice_Care(CqlContext _) => _Discharged_to_Home_for_Hosice_Care;
    private static readonly CqlValueSet _Discharged_to_Home_for_Hosice_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209", null);

    [CqlValueSetDefinition("Encounter Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext _) => _Encounter_Inpatient;
    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlValueSetDefinition("Fluoride Varnish Application for Children", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.125.12.1002", valueSetVersion: null)]
    public CqlValueSet Fluoride_Varnish_Application_for_Children(CqlContext _) => _Fluoride_Varnish_Application_for_Children;
    private static readonly CqlValueSet _Fluoride_Varnish_Application_for_Children = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.125.12.1002", null);

    #endregion ValueSets

    #region Parameters

    private Cached<CqlInterval<CqlDateTime>> _Measurement_Period_Cached = new();

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        _Measurement_Period_Cached.GetOrReplace(
            context,
            () =>
            {
                object a_ = context.ResolveParameter("CMS74FHIRDentalCariesPrevention-1.0.000", "Measurement Period", null);
                return (CqlInterval<CqlDateTime>)a_;
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
                IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
                Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
                return b_;
            });


    private Cached<IEnumerable<Encounter>> _Qualifying_Encounters_Cached = new();

    [CqlExpressionDefinition("Qualifying Encounters")]
    public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context) =>
        _Qualifying_Encounters_Cached.GetOrReplace(
            context,
            () =>
            {
                CqlValueSet a_ = this.Clinical_Oral_Evaluation(context);
                IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
                IEnumerable<Encounter> c_ = Status_1_15_000.Instance.isEncounterPerformed(context, b_);

                bool? d_(Encounter ValidEncounter) {
                    CqlInterval<CqlDateTime> f_ = this.Measurement_Period(context);
                    Period g_ = ValidEncounter?.Period;
                    CqlInterval<CqlDateTime> h_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, g_);
                    bool? i_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(f_, h_, "day");
                    return i_;
                }

                IEnumerable<Encounter> e_ = context.Operators.Where<Encounter>(c_, d_);
                return e_;
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
                CqlInterval<int?> i_ = context.Operators.Interval(1, 20, true, true);
                bool? j_ = context.Operators.In<int?>(h_, i_, default);
                IEnumerable<Encounter> k_ = this.Qualifying_Encounters(context);
                bool? l_ = context.Operators.Exists<Encounter>(k_);
                bool? m_ = context.Operators.And(j_, l_);
                return m_;
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


    private Cached<bool?> _Denominator_Exclusions_Cached = new();

    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context) =>
        _Denominator_Exclusions_Cached.GetOrReplace(
            context,
            () =>
            {
                bool? a_ = Hospice_6_18_000.Instance.Has_Hospice_Services(context);
                return a_;
            });


    private Cached<bool?> _Numerator_Cached = new();

    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context) =>
        _Numerator_Cached.GetOrReplace(
            context,
            () =>
            {
                CqlValueSet a_ = this.Fluoride_Varnish_Application_for_Children(context);
                IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
                IEnumerable<Procedure> c_ = Status_1_15_000.Instance.isProcedurePerformed(context, b_);

                bool? d_(Procedure FluorideApplication) {

                    object k_() {

                        bool p_() {
                            DataType t_ = FluorideApplication?.Performed;
                            object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                            bool v_ = u_ is CqlDateTime;
                            return v_;
                        }


                        bool q_() {
                            DataType w_ = FluorideApplication?.Performed;
                            object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                            bool y_ = x_ is CqlInterval<CqlDateTime>;
                            return y_;
                        }


                        bool r_() {
                            DataType z_ = FluorideApplication?.Performed;
                            object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                            bool ab_ = aa_ is CqlQuantity;
                            return ab_;
                        }


                        bool s_() {
                            DataType ac_ = FluorideApplication?.Performed;
                            object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                            bool ae_ = ad_ is CqlInterval<CqlQuantity>;
                            return ae_;
                        }

                        if (p_())
                        {
                            DataType af_ = FluorideApplication?.Performed;
                            object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                            return (ag_ as CqlDateTime) as object;
                        }
                        else if (q_())
                        {
                            DataType ah_ = FluorideApplication?.Performed;
                            object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                            return (ai_ as CqlInterval<CqlDateTime>) as object;
                        }
                        else if (r_())
                        {
                            DataType aj_ = FluorideApplication?.Performed;
                            object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                            return (ak_ as CqlQuantity) as object;
                        }
                        else if (s_())
                        {
                            DataType al_ = FluorideApplication?.Performed;
                            object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                            return (am_ as CqlInterval<CqlQuantity>) as object;
                        }
                        else
                        {
                            return null;
                        };
                    }

                    CqlInterval<CqlDateTime> l_ = QICoreCommon_4_0_000.Instance.toInterval(context, k_());
                    CqlDateTime m_ = context.Operators.End(l_);
                    CqlInterval<CqlDateTime> n_ = this.Measurement_Period(context);
                    bool? o_ = context.Operators.In<CqlDateTime>(m_, n_, "day");
                    return o_;
                }

                IEnumerable<Procedure> e_ = context.Operators.Where<Procedure>(c_, d_);

                CqlDate f_(Procedure FluorideApplication) {

                    object an_() {

                        bool ar_() {
                            DataType av_ = FluorideApplication?.Performed;
                            object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                            bool ax_ = aw_ is CqlDateTime;
                            return ax_;
                        }


                        bool as_() {
                            DataType ay_ = FluorideApplication?.Performed;
                            object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                            bool ba_ = az_ is CqlInterval<CqlDateTime>;
                            return ba_;
                        }


                        bool at_() {
                            DataType bb_ = FluorideApplication?.Performed;
                            object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                            bool bd_ = bc_ is CqlQuantity;
                            return bd_;
                        }


                        bool au_() {
                            DataType be_ = FluorideApplication?.Performed;
                            object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                            bool bg_ = bf_ is CqlInterval<CqlQuantity>;
                            return bg_;
                        }

                        if (ar_())
                        {
                            DataType bh_ = FluorideApplication?.Performed;
                            object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                            return (bi_ as CqlDateTime) as object;
                        }
                        else if (as_())
                        {
                            DataType bj_ = FluorideApplication?.Performed;
                            object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                            return (bk_ as CqlInterval<CqlDateTime>) as object;
                        }
                        else if (at_())
                        {
                            DataType bl_ = FluorideApplication?.Performed;
                            object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                            return (bm_ as CqlQuantity) as object;
                        }
                        else if (au_())
                        {
                            DataType bn_ = FluorideApplication?.Performed;
                            object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                            return (bo_ as CqlInterval<CqlQuantity>) as object;
                        }
                        else
                        {
                            return null;
                        };
                    }

                    CqlInterval<CqlDateTime> ao_ = QICoreCommon_4_0_000.Instance.toInterval(context, an_());
                    CqlDateTime ap_ = context.Operators.End(ao_);
                    CqlDate aq_ = context.Operators.DateFrom(ap_);
                    return aq_;
                }

                IEnumerable<CqlDate> g_ = context.Operators.Select<Procedure, CqlDate>(e_, f_);
                IEnumerable<CqlDate> h_ = context.Operators.Distinct<CqlDate>(g_);
                int? i_ = context.Operators.Count<CqlDate>(h_);
                bool? j_ = context.Operators.GreaterOrEqual(i_, 2);
                return j_;
            });


    private Cached<bool?> _Stratification_1_Cached = new();

    [CqlExpressionDefinition("Stratification 1")]
    public bool? Stratification_1(CqlContext context) =>
        _Stratification_1_Cached.GetOrReplace(
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
                CqlInterval<int?> i_ = context.Operators.Interval(1, 5, true, true);
                bool? j_ = context.Operators.In<int?>(h_, i_, default);
                return j_;
            });


    private Cached<bool?> _Stratification_2_Cached = new();

    [CqlExpressionDefinition("Stratification 2")]
    public bool? Stratification_2(CqlContext context) =>
        _Stratification_2_Cached.GetOrReplace(
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
                CqlInterval<int?> i_ = context.Operators.Interval(6, 12, true, true);
                bool? j_ = context.Operators.In<int?>(h_, i_, default);
                return j_;
            });


    private Cached<bool?> _Stratification_3_Cached = new();

    [CqlExpressionDefinition("Stratification 3")]
    public bool? Stratification_3(CqlContext context) =>
        _Stratification_3_Cached.GetOrReplace(
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
                CqlInterval<int?> i_ = context.Operators.Interval(13, 20, true, true);
                bool? j_ = context.Operators.In<int?>(h_, i_, default);
                return j_;
            });


    private Cached<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> _SDE_Ethnicity_Cached = new();

    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        _SDE_Ethnicity_Cached.GetOrReplace(
            context,
            () =>
            {
                (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
                return a_;
            });


    private Cached<IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?>> _SDE_Payer_Cached = new();

    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        _SDE_Payer_Cached.GetOrReplace(
            context,
            () =>
            {
                IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
                return a_;
            });


    private Cached<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> _SDE_Race_Cached = new();

    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        _SDE_Race_Cached.GetOrReplace(
            context,
            () =>
            {
                (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
                return a_;
            });


    private Cached<CqlCode> _SDE_Sex_Cached = new();

    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        _SDE_Sex_Cached.GetOrReplace(
            context,
            () =>
            {
                CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
                return a_;
            });


    #endregion Functions and Expressions

}
