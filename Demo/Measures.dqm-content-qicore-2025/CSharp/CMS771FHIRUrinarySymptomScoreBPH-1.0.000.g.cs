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
[CqlLibrary("CMS771FHIRUrinarySymptomScoreBPH", "1.0.000")]
public partial class CMS771FHIRUrinarySymptomScoreBPH_1_0_000 : ILibrary, ISingleton<CMS771FHIRUrinarySymptomScoreBPH_1_0_000>
{
    private CMS771FHIRUrinarySymptomScoreBPH_1_0_000() {}

    public static CMS771FHIRUrinarySymptomScoreBPH_1_0_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "CMS771FHIRUrinarySymptomScoreBPH";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_5_1_000.Instance, QICoreCommon_4_0_000.Instance];

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

    [CqlValueSetDefinition("Hospital Services for Urology Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.360", valueSetVersion: null)]
    public CqlValueSet Hospital_Services_for_Urology_Care(CqlContext _) => _Hospital_Services_for_Urology_Care;
    private static readonly CqlValueSet _Hospital_Services_for_Urology_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.360", null);

    [CqlValueSetDefinition("Morbid Obesity", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.368", valueSetVersion: null)]
    public CqlValueSet Morbid_Obesity(CqlContext _) => _Morbid_Obesity;
    private static readonly CqlValueSet _Morbid_Obesity = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.368", null);

    [CqlValueSetDefinition("Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext _) => _Office_Visit;
    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlValueSetDefinition("Urinary Retention", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.372", valueSetVersion: null)]
    public CqlValueSet Urinary_Retention(CqlContext _) => _Urinary_Retention;
    private static readonly CqlValueSet _Urinary_Retention = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.372", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("American Urological Association Symptom Index [AUASI]", codeId: "80883-2", codeSystem: "http://loinc.org")]
    public CqlCode American_Urological_Association_Symptom_Index__AUASI_(CqlContext _) => _American_Urological_Association_Symptom_Index__AUASI_;
    private static readonly CqlCode _American_Urological_Association_Symptom_Index__AUASI_ = new CqlCode("80883-2", "http://loinc.org");

    [CqlCodeDefinition("Benign prostatic hyperplasia with lower urinary tract symptoms", codeId: "N40.1", codeSystem: "http://hl7.org/fhir/sid/icd-10-cm")]
    public CqlCode Benign_prostatic_hyperplasia_with_lower_urinary_tract_symptoms(CqlContext _) => _Benign_prostatic_hyperplasia_with_lower_urinary_tract_symptoms;
    private static readonly CqlCode _Benign_prostatic_hyperplasia_with_lower_urinary_tract_symptoms = new CqlCode("N40.1", "http://hl7.org/fhir/sid/icd-10-cm");

    [CqlCodeDefinition("If you were to spend the rest of your life with your urinary condition just the way it is now, how would you feel about that [IPSS]", codeId: "81090-3", codeSystem: "http://loinc.org")]
    public CqlCode If_you_were_to_spend_the_rest_of_your_life_with_your_urinary_condition_just_the_way_it_is_now__how_would_you_feel_about_that__IPSS_(CqlContext _) => _If_you_were_to_spend_the_rest_of_your_life_with_your_urinary_condition_just_the_way_it_is_now__how_would_you_feel_about_that__IPSS_;
    private static readonly CqlCode _If_you_were_to_spend_the_rest_of_your_life_with_your_urinary_condition_just_the_way_it_is_now__how_would_you_feel_about_that__IPSS_ = new CqlCode("81090-3", "http://loinc.org");

    [CqlCodeDefinition("International Prostate Symptom Score [IPSS]", codeId: "80976-4", codeSystem: "http://loinc.org")]
    public CqlCode International_Prostate_Symptom_Score__IPSS_(CqlContext _) => _International_Prostate_Symptom_Score__IPSS_;
    private static readonly CqlCode _International_Prostate_Symptom_Score__IPSS_ = new CqlCode("80976-4", "http://loinc.org");

    [CqlCodeDefinition("virtual", codeId: "VR", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode @virtual(CqlContext _) => _virtual;
    private static readonly CqlCode _virtual = new CqlCode("VR", "http://terminology.hl7.org/CodeSystem/v3-ActCode");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC", codeSystemId: "http://loinc.org", codeSystemVersion: null)]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, [
          _American_Urological_Association_Symptom_Index__AUASI_,
          _If_you_were_to_spend_the_rest_of_your_life_with_your_urinary_condition_just_the_way_it_is_now__how_would_you_feel_about_that__IPSS_,
          _International_Prostate_Symptom_Score__IPSS_]);

    [CqlCodeSystemDefinition("ICD10CM", codeSystemId: "http://hl7.org/fhir/sid/icd-10-cm", codeSystemVersion: null)]
    public CqlCodeSystem ICD10CM(CqlContext _) => _ICD10CM;
    private static readonly CqlCodeSystem _ICD10CM =
      new CqlCodeSystem("http://hl7.org/fhir/sid/icd-10-cm", null, [
          _Benign_prostatic_hyperplasia_with_lower_urinary_tract_symptoms]);

    [CqlCodeSystemDefinition("ActCode", codeSystemId: "http://terminology.hl7.org/CodeSystem/v3-ActCode", codeSystemVersion: null)]
    public CqlCodeSystem ActCode(CqlContext _) => _ActCode;
    private static readonly CqlCodeSystem _ActCode =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/v3-ActCode", null, [
          _virtual]);

    #endregion CodeSystems

    #region Parameters

    private Cached<CqlInterval<CqlDateTime>> _Measurement_Period_Cached = new();

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        _Measurement_Period_Cached.GetOrReplace(
            context,
            () =>
            {
                object a_ = context.ResolveParameter("CMS771FHIRUrinarySymptomScoreBPH-1.0.000", "Measurement Period", null);
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


    private Cached<bool?> _Patient_is_Male_Cached = new();

    [CqlExpressionDefinition("Patient is Male")]
    public bool? Patient_is_Male(CqlContext context) =>
        _Patient_is_Male_Cached.GetOrReplace(
            context,
            () =>
            {
                CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
                CqlCode b_ = SupplementalDataElements_5_1_000.Instance.Male__finding_(context);
                bool? c_ = context.Operators.Equivalent(a_, b_);
                return c_;
            });


    private Cached<bool?> _Has_Qualifying_Encounter_Cached = new();

    [CqlExpressionDefinition("Has Qualifying Encounter")]
    public bool? Has_Qualifying_Encounter(CqlContext context) =>
        _Has_Qualifying_Encounter_Cached.GetOrReplace(
            context,
            () =>
            {
                CqlValueSet a_ = this.Office_Visit(context);
                IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                bool? c_(Encounter ValidEncounter) {
                    CqlInterval<CqlDateTime> f_ = this.Measurement_Period(context);
                    Period g_ = ValidEncounter?.Period;
                    CqlInterval<CqlDateTime> h_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, g_);
                    bool? i_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(f_, h_, "day");
                    Coding j_ = ValidEncounter?.Class;
                    CqlCode k_ = FHIRHelpers_4_4_000.Instance.ToCode(context, j_);
                    CqlCode l_ = this.@virtual(context);
                    bool? m_ = context.Operators.Equivalent(k_, l_);
                    bool? n_ = context.Operators.Not(m_);
                    bool? o_ = context.Operators.And(i_, n_);
                    Code<Encounter.EncounterStatus> p_ = ValidEncounter?.StatusElement;
                    Encounter.EncounterStatus? q_ = p_?.Value;
                    Code<Encounter.EncounterStatus> r_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(q_);
                    bool? s_ = context.Operators.Equal(r_, "finished");
                    bool? t_ = context.Operators.And(o_, s_);
                    return t_;
                }

                IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);
                bool? e_ = context.Operators.Exists<Encounter>(d_);
                return e_;
            });


    [CqlFunctionDefinition("verificationStatusIsNotInvalid")]
    public bool? verificationStatusIsNotInvalid(CqlContext context, object condition)
    {
        object a_ = context.Operators.LateBoundProperty<object>(condition, "verificationStatus");
        CqlConcept b_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_ as CodeableConcept);
        CqlConcept d_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_ as CodeableConcept);
        CqlCode e_ = QICoreCommon_4_0_000.Instance.unconfirmed(context);
        CqlConcept f_ = context.Operators.ConvertCodeToConcept(e_);
        bool? g_ = context.Operators.Equivalent(d_, f_);
        CqlConcept i_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_ as CodeableConcept);
        CqlCode j_ = QICoreCommon_4_0_000.Instance.refuted(context);
        CqlConcept k_ = context.Operators.ConvertCodeToConcept(j_);
        bool? l_ = context.Operators.Equivalent(i_, k_);
        bool? m_ = context.Operators.Or(g_, l_);
        CqlConcept o_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_ as CodeableConcept);
        CqlCode p_ = QICoreCommon_4_0_000.Instance.entered_in_error(context);
        CqlConcept q_ = context.Operators.ConvertCodeToConcept(p_);
        bool? r_ = context.Operators.Equivalent(o_, q_);
        bool? s_ = context.Operators.Or(m_, r_);
        bool? t_ = context.Operators.Not(s_);
        bool? u_ = context.Operators.Or((bool?)(b_ is null), t_);
        return u_;
    }


    private Cached<object> _Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_the_Measurement_Period_Cached = new();

    [CqlExpressionDefinition("Initial BPH Diagnosis Starts Within 6 Months Before the Measurement Period")]
    public object Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_the_Measurement_Period(CqlContext context) =>
        _Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_the_Measurement_Period_Cached.GetOrReplace(
            context,
            () =>
            {
                CqlCode a_ = this.Benign_prostatic_hyperplasia_with_lower_urinary_tract_symptoms(context);
                IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
                IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
                IEnumerable<CqlCode> e_ = context.Operators.ToList<CqlCode>(a_);
                IEnumerable<Condition> f_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, e_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
                IEnumerable<object> g_ = context.Operators.Union<object>(c_ as IEnumerable<object>, f_ as IEnumerable<object>);

                bool? h_(object NewBPHDiagnosis) {
                    CqlInterval<CqlDateTime> m_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, NewBPHDiagnosis);
                    CqlDateTime n_ = context.Operators.Start(m_);
                    CqlInterval<CqlDateTime> o_ = this.Measurement_Period(context);
                    CqlDateTime p_ = context.Operators.Start(o_);
                    CqlQuantity q_ = context.Operators.Quantity(6m, "months");
                    CqlDateTime r_ = context.Operators.Subtract(p_, q_);
                    CqlDateTime t_ = context.Operators.Start(o_);
                    CqlInterval<CqlDateTime> u_ = context.Operators.Interval(r_, t_, true, true);
                    bool? v_ = context.Operators.In<CqlDateTime>(n_, u_, default);
                    bool? w_ = this.verificationStatusIsNotInvalid(context, NewBPHDiagnosis);
                    bool? x_ = context.Operators.And(v_, w_);
                    return x_;
                }

                IEnumerable<object> i_ = context.Operators.Where<object>(g_, h_);

                object j_(object @this) {
                    object y_ = context.Operators.LateBoundProperty<object>(@this, "onset");
                    object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                    CqlInterval<CqlDateTime> aa_ = QICoreCommon_4_0_000.Instance.toInterval(context, z_);
                    CqlDateTime ab_ = context.Operators.Start(aa_);
                    return ab_;
                }

                IEnumerable<object> k_ = context.Operators.SortBy<object>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
                object l_ = context.Operators.First<object>(k_);
                return l_;
            });


    private Cached<bool?> _Has_Qualifying_BPH_Diagnosis_Cached = new();

    [CqlExpressionDefinition("Has Qualifying BPH Diagnosis")]
    public bool? Has_Qualifying_BPH_Diagnosis(CqlContext context) =>
        _Has_Qualifying_BPH_Diagnosis_Cached.GetOrReplace(
            context,
            () =>
            {
                object a_ = this.Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_the_Measurement_Period(context);
                bool? b_ = context.Operators.Not((bool?)(a_ is null));
                return b_;
            });


    private Cached<bool?> _Initial_Population_Cached = new();

    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context) =>
        _Initial_Population_Cached.GetOrReplace(
            context,
            () =>
            {
                bool? a_ = this.Patient_is_Male(context);
                bool? b_ = this.Has_Qualifying_Encounter(context);
                bool? c_ = context.Operators.And(a_, b_);
                bool? d_ = this.Has_Qualifying_BPH_Diagnosis(context);
                bool? e_ = context.Operators.And(c_, d_);
                return e_;
            });


    private Cached<IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>> _Documented_IPSS_Assessment_Result_Cached = new();

    [CqlExpressionDefinition("Documented IPSS Assessment Result")]
    public IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> Documented_IPSS_Assessment_Result(CqlContext context) =>
        _Documented_IPSS_Assessment_Result_Cached.GetOrReplace(
            context,
            () =>
            {
                CqlCode a_ = this.International_Prostate_Symptom_Score__IPSS_(context);
                IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
                IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));

                bool? d_(Observation IPSSAssessment) {
                    Code<ObservationStatus> i_ = IPSSAssessment?.StatusElement;
                    ObservationStatus? j_ = i_?.Value;
                    string k_ = context.Operators.Convert<string>(j_);
                    string[] l_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? m_ = context.Operators.In<string>(k_, (IEnumerable<string>)l_);
                    DataType n_ = IPSSAssessment?.Value;
                    object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
                    bool? p_ = context.Operators.Not((bool?)(o_ is null));
                    bool? q_ = context.Operators.And(m_, p_);
                    return q_;
                }

                IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

                (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? f_(Observation IPSSAssessment) {

                    object r_() {

                        bool w_() {
                            DataType z_ = IPSSAssessment?.Effective;
                            object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                            bool ab_ = aa_ is CqlDateTime;
                            return ab_;
                        }


                        bool x_() {
                            DataType ac_ = IPSSAssessment?.Effective;
                            object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                            bool ae_ = ad_ is CqlInterval<CqlDateTime>;
                            return ae_;
                        }


                        bool y_() {
                            DataType af_ = IPSSAssessment?.Effective;
                            object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                            bool ah_ = ag_ is CqlDateTime;
                            return ah_;
                        }

                        if (w_())
                        {
                            DataType ai_ = IPSSAssessment?.Effective;
                            object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                            return (aj_ as CqlDateTime) as object;
                        }
                        else if (x_())
                        {
                            DataType ak_ = IPSSAssessment?.Effective;
                            object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                            return (al_ as CqlInterval<CqlDateTime>) as object;
                        }
                        else if (y_())
                        {
                            DataType am_ = IPSSAssessment?.Effective;
                            object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                            return (an_ as CqlDateTime) as object;
                        }
                        else
                        {
                            return null;
                        };
                    }

                    CqlDateTime s_ = QICoreCommon_4_0_000.Instance.earliest(context, r_());
                    DataType t_ = IPSSAssessment?.Value;
                    object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                    (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? v_ = (CqlTupleMetadata_GNNDVIQPcTANSdLebhBKYIdga, s_, u_ as int?);
                    return v_;
                }

                IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> g_ = context.Operators.Select<Observation, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(e_, f_);
                IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> h_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(g_);
                return h_;
            });


    private Cached<IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>> _AUA_Symptom_Index_and_Quality_of_Life_Assessment_Result_Cached = new();

    [CqlExpressionDefinition("AUA Symptom Index and Quality of Life Assessment Result")]
    public IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> AUA_Symptom_Index_and_Quality_of_Life_Assessment_Result(CqlContext context) =>
        _AUA_Symptom_Index_and_Quality_of_Life_Assessment_Result_Cached.GetOrReplace(
            context,
            () =>
            {
                CqlCode a_ = this.American_Urological_Association_Symptom_Index__AUASI_(context);
                IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
                IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));

                bool? d_(Observation AUASIAssessment) {
                    Code<ObservationStatus> i_ = AUASIAssessment?.StatusElement;
                    ObservationStatus? j_ = i_?.Value;
                    string k_ = context.Operators.Convert<string>(j_);
                    string[] l_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? m_ = context.Operators.In<string>(k_, (IEnumerable<string>)l_);
                    DataType n_ = AUASIAssessment?.Value;
                    object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
                    bool? p_ = context.Operators.Not((bool?)(o_ is null));
                    bool? q_ = context.Operators.And(m_, p_);
                    return q_;
                }

                IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);

                (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? f_(Observation AUASIAssessment) {

                    object r_() {

                        bool ah_() {
                            DataType ak_ = AUASIAssessment?.Effective;
                            object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                            bool am_ = al_ is CqlDateTime;
                            return am_;
                        }


                        bool ai_() {
                            DataType an_ = AUASIAssessment?.Effective;
                            object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                            bool ap_ = ao_ is CqlInterval<CqlDateTime>;
                            return ap_;
                        }


                        bool aj_() {
                            DataType aq_ = AUASIAssessment?.Effective;
                            object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                            bool as_ = ar_ is CqlDateTime;
                            return as_;
                        }

                        if (ah_())
                        {
                            DataType at_ = AUASIAssessment?.Effective;
                            object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                            return (au_ as CqlDateTime) as object;
                        }
                        else if (ai_())
                        {
                            DataType av_ = AUASIAssessment?.Effective;
                            object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                            return (aw_ as CqlInterval<CqlDateTime>) as object;
                        }
                        else if (aj_())
                        {
                            DataType ax_ = AUASIAssessment?.Effective;
                            object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                            return (ay_ as CqlDateTime) as object;
                        }
                        else
                        {
                            return null;
                        };
                    }

                    CqlDateTime s_ = QICoreCommon_4_0_000.Instance.earliest(context, r_());
                    DataType t_ = AUASIAssessment?.Value;
                    object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                    CqlCode v_ = this.If_you_were_to_spend_the_rest_of_your_life_with_your_urinary_condition_just_the_way_it_is_now__how_would_you_feel_about_that__IPSS_(context);
                    IEnumerable<CqlCode> w_ = context.Operators.ToList<CqlCode>(v_);
                    IEnumerable<Observation> x_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, w_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));

                    bool? y_(Observation QOLAssessment) {

                        object az_() {

                            bool bo_() {
                                DataType br_ = QOLAssessment?.Effective;
                                object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
                                bool bt_ = bs_ is CqlDateTime;
                                return bt_;
                            }


                            bool bp_() {
                                DataType bu_ = QOLAssessment?.Effective;
                                object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                                bool bw_ = bv_ is CqlInterval<CqlDateTime>;
                                return bw_;
                            }


                            bool bq_() {
                                DataType bx_ = QOLAssessment?.Effective;
                                object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                                bool bz_ = by_ is CqlDateTime;
                                return bz_;
                            }

                            if (bo_())
                            {
                                DataType ca_ = QOLAssessment?.Effective;
                                object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                                return (cb_ as CqlDateTime) as object;
                            }
                            else if (bp_())
                            {
                                DataType cc_ = QOLAssessment?.Effective;
                                object cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                                return (cd_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (bq_())
                            {
                                DataType ce_ = QOLAssessment?.Effective;
                                object cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);
                                return (cf_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            };
                        }

                        CqlDateTime ba_ = QICoreCommon_4_0_000.Instance.earliest(context, az_());

                        object bb_() {

                            bool cg_() {
                                DataType cj_ = AUASIAssessment?.Effective;
                                object ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
                                bool cl_ = ck_ is CqlDateTime;
                                return cl_;
                            }


                            bool ch_() {
                                DataType cm_ = AUASIAssessment?.Effective;
                                object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                                bool co_ = cn_ is CqlInterval<CqlDateTime>;
                                return co_;
                            }


                            bool ci_() {
                                DataType cp_ = AUASIAssessment?.Effective;
                                object cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
                                bool cr_ = cq_ is CqlDateTime;
                                return cr_;
                            }

                            if (cg_())
                            {
                                DataType cs_ = AUASIAssessment?.Effective;
                                object ct_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cs_);
                                return (ct_ as CqlDateTime) as object;
                            }
                            else if (ch_())
                            {
                                DataType cu_ = AUASIAssessment?.Effective;
                                object cv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cu_);
                                return (cv_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (ci_())
                            {
                                DataType cw_ = AUASIAssessment?.Effective;
                                object cx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cw_);
                                return (cx_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            };
                        }

                        CqlDateTime bc_ = QICoreCommon_4_0_000.Instance.earliest(context, bb_());
                        bool? bd_ = context.Operators.SameAs(ba_, bc_, "day");
                        Code<ObservationStatus> be_ = QOLAssessment?.StatusElement;
                        ObservationStatus? bf_ = be_?.Value;
                        string bg_ = context.Operators.Convert<string>(bf_);
                        string[] bh_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? bi_ = context.Operators.In<string>(bg_, (IEnumerable<string>)bh_);
                        bool? bj_ = context.Operators.And(bd_, bi_);
                        DataType bk_ = QOLAssessment?.Value;
                        object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                        bool? bm_ = context.Operators.Not((bool?)(bl_ is null));
                        bool? bn_ = context.Operators.And(bj_, bm_);
                        return bn_;
                    }

                    IEnumerable<Observation> z_ = context.Operators.Where<Observation>(x_, y_);

                    object aa_(Observation @this) {

                        object cy_() {

                            bool da_() {
                                DataType dd_ = @this?.Effective;
                                object de_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dd_);
                                bool df_ = de_ is CqlDateTime;
                                return df_;
                            }


                            bool db_() {
                                DataType dg_ = @this?.Effective;
                                object dh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dg_);
                                bool di_ = dh_ is CqlInterval<CqlDateTime>;
                                return di_;
                            }


                            bool dc_() {
                                DataType dj_ = @this?.Effective;
                                object dk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dj_);
                                bool dl_ = dk_ is CqlDateTime;
                                return dl_;
                            }

                            if (da_())
                            {
                                DataType dm_ = @this?.Effective;
                                object dn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dm_);
                                return (dn_ as CqlDateTime) as object;
                            }
                            else if (db_())
                            {
                                DataType do_ = @this?.Effective;
                                object dp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, do_);
                                return (dp_ as CqlInterval<CqlDateTime>) as object;
                            }
                            else if (dc_())
                            {
                                DataType dq_ = @this?.Effective;
                                object dr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dq_);
                                return (dr_ as CqlDateTime) as object;
                            }
                            else
                            {
                                return null;
                            };
                        }

                        CqlDateTime cz_ = QICoreCommon_4_0_000.Instance.earliest(context, cy_());
                        return cz_;
                    }

                    IEnumerable<Observation> ab_ = context.Operators.SortBy<Observation>(z_, aa_, System.ComponentModel.ListSortDirection.Ascending);
                    Observation ac_ = context.Operators.Last<Observation>(ab_);
                    DataType ad_ = ac_?.Value;
                    object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                    int? af_ = context.Operators.Add(u_ as int?, ae_ as int?);
                    (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? ag_ = (CqlTupleMetadata_GNNDVIQPcTANSdLebhBKYIdga, s_, af_);
                    return ag_;
                }

                IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> g_ = context.Operators.Select<Observation, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(e_, f_);
                IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> h_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(g_);
                return h_;
            });


    private Cached<IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>> _Urinary_Symptom_Score_Assessment_Cached = new();

    [CqlExpressionDefinition("Urinary Symptom Score Assessment")]
    public IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> Urinary_Symptom_Score_Assessment(CqlContext context) =>
        _Urinary_Symptom_Score_Assessment_Cached.GetOrReplace(
            context,
            () =>
            {
                IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> a_ = this.Documented_IPSS_Assessment_Result(context);
                IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> b_ = this.AUA_Symptom_Index_and_Quality_of_Life_Assessment_Result(context);
                IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> c_ = context.Operators.Union<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(a_, b_);
                return c_;
            });


    private Cached<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> _Urinary_Symptom_Score_Within_1_Month_After_Initial_BPH_Diagnosis_Cached = new();

    [CqlExpressionDefinition("Urinary Symptom Score Within 1 Month After Initial BPH Diagnosis")]
    public (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? Urinary_Symptom_Score_Within_1_Month_After_Initial_BPH_Diagnosis(CqlContext context) =>
        _Urinary_Symptom_Score_Within_1_Month_After_Initial_BPH_Diagnosis_Cached.GetOrReplace(
            context,
            () =>
            {
                IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> a_ = this.Urinary_Symptom_Score_Assessment(context);

                IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> b_((CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? USSAssessment) {
                    object g_ = this.Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_the_Measurement_Period(context);
                    object[] h_ = [
                        g_,
                    ];

                    bool? i_(object InitialBPHDiagnosis) {
                        CqlDateTime m_ = USSAssessment?.effectiveDatetime;
                        CqlInterval<CqlDateTime> n_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, InitialBPHDiagnosis);
                        CqlDateTime o_ = context.Operators.Start(n_);
                        CqlDateTime q_ = context.Operators.Start(n_);
                        CqlQuantity r_ = context.Operators.Quantity(1m, "month");
                        CqlDateTime s_ = context.Operators.Add(q_, r_);
                        CqlInterval<CqlDateTime> t_ = context.Operators.Interval(o_, s_, true, true);
                        bool? u_ = context.Operators.In<CqlDateTime>(m_, t_, "day");
                        CqlDateTime w_ = context.Operators.Start(n_);
                        bool? x_ = context.Operators.Not((bool?)(w_ is null));
                        bool? y_ = context.Operators.And(u_, x_);
                        return y_;
                    }

                    IEnumerable<object> j_ = context.Operators.Where<object>((IEnumerable<object>)h_, i_);
                    (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? k_(object InitialBPHDiagnosis) => USSAssessment;
                    IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> l_ = context.Operators.Select<object, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(j_, k_);
                    return l_;
                }

                IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> c_ = context.Operators.SelectMany<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(a_, b_);

                object d_((CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? @this) {
                    CqlDateTime z_ = @this?.effectiveDatetime;
                    return z_;
                }

                IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> e_ = context.Operators.SortBy<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(c_, d_, System.ComponentModel.ListSortDirection.Ascending);
                (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? f_ = context.Operators.First<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(e_);
                return f_;
            });


    private Cached<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> _Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis_Cached = new();

    [CqlExpressionDefinition("Urinary Symptom Score 6 to 12 Months After Initial BPH Diagnosis")]
    public (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis(CqlContext context) =>
        _Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis_Cached.GetOrReplace(
            context,
            () =>
            {
                IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> a_ = this.Urinary_Symptom_Score_Assessment(context);

                IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> b_((CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? USSAssessment) {
                    object g_ = this.Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_the_Measurement_Period(context);
                    object[] h_ = [
                        g_,
                    ];

                    bool? i_(object InitialBPHDiagnosis) {
                        CqlInterval<CqlDateTime> m_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, InitialBPHDiagnosis);
                        CqlDateTime n_ = context.Operators.Start(m_);
                        CqlDateTime o_ = USSAssessment?.effectiveDatetime;
                        int? p_ = context.Operators.DifferenceBetween(n_, o_, "month");
                        CqlInterval<int?> q_ = context.Operators.Interval(6, 12, true, true);
                        bool? r_ = context.Operators.In<int?>(p_, q_, default);
                        return r_;
                    }

                    IEnumerable<object> j_ = context.Operators.Where<object>((IEnumerable<object>)h_, i_);
                    (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? k_(object InitialBPHDiagnosis) => USSAssessment;
                    IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> l_ = context.Operators.Select<object, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(j_, k_);
                    return l_;
                }

                IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> c_ = context.Operators.SelectMany<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(a_, b_);

                object d_((CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? @this) {
                    CqlDateTime s_ = @this?.effectiveDatetime;
                    return s_;
                }

                IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> e_ = context.Operators.SortBy<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(c_, d_, System.ComponentModel.ListSortDirection.Ascending);
                (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? f_ = context.Operators.Last<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(e_);
                return f_;
            });


    private Cached<bool?> _Denominator_Cached = new();

    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context) =>
        _Denominator_Cached.GetOrReplace(
            context,
            () =>
            {
                bool? a_ = this.Initial_Population(context);
                (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? b_ = this.Urinary_Symptom_Score_Within_1_Month_After_Initial_BPH_Diagnosis(context);
                bool? c_ = context.Operators.Not((bool?)(b_ is null));
                bool? d_ = context.Operators.And(a_, c_);
                (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? e_ = this.Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis(context);
                bool? f_ = context.Operators.Not((bool?)(e_ is null));
                bool? g_ = context.Operators.And(d_, f_);
                return g_;
            });


    private Cached<IEnumerable<object>> _Urinary_Retention_Diagnosis_Starts_Within_1_Year_After_Initial_BPH_Diagnosis_Cached = new();

    [CqlExpressionDefinition("Urinary Retention Diagnosis Starts Within 1 Year After Initial BPH Diagnosis")]
    public IEnumerable<object> Urinary_Retention_Diagnosis_Starts_Within_1_Year_After_Initial_BPH_Diagnosis(CqlContext context) =>
        _Urinary_Retention_Diagnosis_Starts_Within_1_Year_After_Initial_BPH_Diagnosis_Cached.GetOrReplace(
            context,
            () =>
            {
                CqlValueSet a_ = this.Urinary_Retention(context);
                IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
                IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
                IEnumerable<object> e_ = context.Operators.Union<object>(b_ as IEnumerable<object>, d_ as IEnumerable<object>);

                IEnumerable<object> f_(object UrinaryRetention) {
                    object j_ = this.Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_the_Measurement_Period(context);
                    object[] k_ = [
                        j_,
                    ];

                    bool? l_(object InitialBPHDiagnosis) {
                        CqlInterval<CqlDateTime> p_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, UrinaryRetention);
                        CqlDateTime q_ = context.Operators.Start(p_);
                        CqlInterval<CqlDateTime> r_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, InitialBPHDiagnosis);
                        CqlDateTime s_ = context.Operators.Start(r_);
                        CqlDateTime u_ = context.Operators.Start(r_);
                        CqlQuantity v_ = context.Operators.Quantity(1m, "year");
                        CqlDateTime w_ = context.Operators.Add(u_, v_);
                        CqlInterval<CqlDateTime> x_ = context.Operators.Interval(s_, w_, true, true);
                        bool? y_ = context.Operators.In<CqlDateTime>(q_, x_, "day");
                        CqlDateTime aa_ = context.Operators.Start(r_);
                        bool? ab_ = context.Operators.Not((bool?)(aa_ is null));
                        bool? ac_ = context.Operators.And(y_, ab_);
                        return ac_;
                    }

                    IEnumerable<object> m_ = context.Operators.Where<object>((IEnumerable<object>)k_, l_);
                    object n_(object InitialBPHDiagnosis) => UrinaryRetention;
                    IEnumerable<object> o_ = context.Operators.Select<object, object>(m_, n_);
                    return o_;
                }

                IEnumerable<object> g_ = context.Operators.SelectMany<object, object>(e_, f_);

                bool? h_(object UrinaryRetention) {
                    bool? ad_ = this.verificationStatusIsNotInvalid(context, UrinaryRetention);
                    return ad_;
                }

                IEnumerable<object> i_ = context.Operators.Where<object>(g_, h_);
                return i_;
            });


    private Cached<object> _Has_Initial_BPH_Diagnosis_Starts_During_or_Within_30_Days_After_End_of_Hospitalization_Cached = new();

    [CqlExpressionDefinition("Has Initial BPH Diagnosis Starts During or Within 30 Days After End of Hospitalization")]
    public object Has_Initial_BPH_Diagnosis_Starts_During_or_Within_30_Days_After_End_of_Hospitalization(CqlContext context) =>
        _Has_Initial_BPH_Diagnosis_Starts_During_or_Within_30_Days_After_End_of_Hospitalization_Cached.GetOrReplace(
            context,
            () =>
            {
                object a_ = this.Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_the_Measurement_Period(context);
                object[] b_ = [
                    a_,
                ];

                IEnumerable<object> c_(object InitialBPHDiagnosis) {
                    CqlValueSet f_ = this.Hospital_Services_for_Urology_Care(context);
                    IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                    bool? h_(Encounter UrologyHospitalServices) {
                        CqlInterval<CqlDateTime> l_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, InitialBPHDiagnosis);
                        CqlDateTime m_ = context.Operators.Start(l_);
                        Period n_ = UrologyHospitalServices?.Period;
                        CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                        CqlDateTime p_ = context.Operators.Start(o_);
                        CqlInterval<CqlDateTime> r_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
                        CqlDateTime s_ = context.Operators.End(r_);
                        CqlQuantity t_ = context.Operators.Quantity(31m, "days");
                        CqlDateTime u_ = context.Operators.Add(s_, t_);
                        CqlInterval<CqlDateTime> v_ = context.Operators.Interval(p_, u_, true, true);
                        bool? w_ = context.Operators.In<CqlDateTime>(m_, v_, default);
                        Code<Encounter.EncounterStatus> x_ = UrologyHospitalServices?.StatusElement;
                        Encounter.EncounterStatus? y_ = x_?.Value;
                        Code<Encounter.EncounterStatus> z_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(y_);
                        bool? aa_ = context.Operators.Equal(z_, "finished");
                        bool? ab_ = context.Operators.And(w_, aa_);
                        return ab_;
                    }

                    IEnumerable<Encounter> i_ = context.Operators.Where<Encounter>(g_, h_);
                    object j_(Encounter UrologyHospitalServices) => InitialBPHDiagnosis;
                    IEnumerable<object> k_ = context.Operators.Select<Encounter, object>(i_, j_);
                    return k_;
                }

                IEnumerable<object> d_ = context.Operators.SelectMany<object, object>((IEnumerable<object>)b_, c_);
                object e_ = context.Operators.SingletonFrom<object>(d_);
                return e_;
            });


    private Cached<IEnumerable<object>> _Morbid_Obesity_Diagnosis_On_or_Before_Follow_Up_USS_Assessment_Cached = new();

    [CqlExpressionDefinition("Morbid Obesity Diagnosis On or Before Follow Up USS Assessment")]
    public IEnumerable<object> Morbid_Obesity_Diagnosis_On_or_Before_Follow_Up_USS_Assessment(CqlContext context) =>
        _Morbid_Obesity_Diagnosis_On_or_Before_Follow_Up_USS_Assessment_Cached.GetOrReplace(
            context,
            () =>
            {
                CqlValueSet a_ = this.Morbid_Obesity(context);
                IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
                IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
                IEnumerable<object> e_ = context.Operators.Union<object>(b_ as IEnumerable<object>, d_ as IEnumerable<object>);

                IEnumerable<object> f_(object MorbidObesityDiagnosis) {
                    (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? j_ = this.Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis(context);
                    (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?[] k_ = [
                        j_,
                    ];

                    bool? l_((CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment) {
                        CqlInterval<CqlDateTime> p_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, MorbidObesityDiagnosis);
                        CqlInterval<CqlDateTime> q_ = this.Measurement_Period(context);
                        bool? r_ = context.Operators.Overlaps(p_, q_, default);
                        CqlDateTime t_ = context.Operators.Start(p_);
                        CqlDateTime u_ = FollowUpUSSAssessment?.effectiveDatetime;
                        bool? v_ = context.Operators.SameOrBefore(t_, u_, default);
                        bool? w_ = context.Operators.And(r_, v_);
                        return w_;
                    }

                    IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> m_ = context.Operators.Where<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>((IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>)k_, l_);
                    object n_((CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment) => MorbidObesityDiagnosis;
                    IEnumerable<object> o_ = context.Operators.Select<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?, object>(m_, n_);
                    return o_;
                }

                IEnumerable<object> g_ = context.Operators.SelectMany<object, object>(e_, f_);

                bool? h_(object MorbidObesityDiagnosis) {
                    bool? x_ = this.verificationStatusIsNotInvalid(context, MorbidObesityDiagnosis);
                    return x_;
                }

                IEnumerable<object> i_ = context.Operators.Where<object>(g_, h_);
                return i_;
            });


    private Cached<bool?> _BMI_Exam_Result_Greater_Than_or_Equal_To_40_During_Measurement_Period_and_On_or_Before_Follow_Up_USS_Assessment_Cached = new();

    [CqlExpressionDefinition("BMI Exam Result Greater Than or Equal To 40 During Measurement Period and On or Before Follow Up USS Assessment")]
    [CqlTag("code", "Body mass index (BMI) [Ratio] - 39156-5")]
    [CqlTag("profile", "http://hl7.org/fhir/StructureDefinition/bmi")]
    public bool? BMI_Exam_Result_Greater_Than_or_Equal_To_40_During_Measurement_Period_and_On_or_Before_Follow_Up_USS_Assessment(CqlContext context) =>
        _BMI_Exam_Result_Greater_Than_or_Equal_To_40_During_Measurement_Period_and_On_or_Before_Follow_Up_USS_Assessment_Cached.GetOrReplace(
            context,
            () =>
            {
                IEnumerable<Observation> a_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-bmi"));

                IEnumerable<Observation> b_(Observation BMIExam) {
                    (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? h_ = this.Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis(context);
                    (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?[] i_ = [
                        h_,
                    ];

                    bool? j_((CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment) {
                        DataType n_ = BMIExam?.Value;
                        CqlQuantity o_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, n_ as Quantity);
                        CqlQuantity p_ = context.Operators.Quantity(40m, "kg/m2");
                        bool? q_ = context.Operators.GreaterOrEqual(o_, p_);
                        Code<ObservationStatus> r_ = BMIExam?.StatusElement;
                        ObservationStatus? s_ = r_?.Value;
                        string t_ = context.Operators.Convert<string>(s_);
                        string[] u_ = [
                            "final",
                            "amended",
                            "corrected",
                        ];
                        bool? v_ = context.Operators.In<string>(t_, (IEnumerable<string>)u_);
                        bool? w_ = context.Operators.And(q_, v_);
                        DataType x_ = BMIExam?.Effective;
                        object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                        CqlDateTime z_ = QICoreCommon_4_0_000.Instance.earliest(context, y_);
                        CqlInterval<CqlDateTime> aa_ = this.Measurement_Period(context);
                        bool? ab_ = context.Operators.In<CqlDateTime>(z_, aa_, "day");
                        bool? ac_ = context.Operators.And(w_, ab_);
                        object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                        CqlDateTime af_ = QICoreCommon_4_0_000.Instance.earliest(context, ae_);
                        CqlDateTime ag_ = FollowUpUSSAssessment?.effectiveDatetime;
                        bool? ah_ = context.Operators.SameOrBefore(af_, ag_, default);
                        bool? ai_ = context.Operators.And(ac_, ah_);
                        return ai_;
                    }

                    IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> k_ = context.Operators.Where<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>((IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>)i_, j_);
                    Observation l_((CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment) => BMIExam;
                    IEnumerable<Observation> m_ = context.Operators.Select<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?, Observation>(k_, l_);
                    return m_;
                }

                IEnumerable<Observation> c_ = context.Operators.SelectMany<Observation, Observation>(a_, b_);

                CqlDateTime d_(Observation BMIExam) {
                    DataType aj_ = BMIExam?.Effective;
                    object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                    CqlDateTime al_ = QICoreCommon_4_0_000.Instance.earliest(context, ak_);
                    return al_;
                }

                IEnumerable<CqlDateTime> e_ = context.Operators.Select<Observation, CqlDateTime>(c_, d_);
                IEnumerable<CqlDateTime> f_ = context.Operators.Distinct<CqlDateTime>(e_);
                bool? g_ = context.Operators.Exists<CqlDateTime>(f_);
                return g_;
            });


    private Cached<bool?> _Morbid_Obesity_Diagnosis_or_BMI_Exam_Result_Greater_Than_or_Equal_to_40_Starts_On_or_Before_Follow_Up_USS_Assessment_Cached = new();

    [CqlExpressionDefinition("Morbid Obesity Diagnosis or BMI Exam Result Greater Than or Equal to 40 Starts On or Before Follow Up USS Assessment")]
    public bool? Morbid_Obesity_Diagnosis_or_BMI_Exam_Result_Greater_Than_or_Equal_to_40_Starts_On_or_Before_Follow_Up_USS_Assessment(CqlContext context) =>
        _Morbid_Obesity_Diagnosis_or_BMI_Exam_Result_Greater_Than_or_Equal_to_40_Starts_On_or_Before_Follow_Up_USS_Assessment_Cached.GetOrReplace(
            context,
            () =>
            {
                IEnumerable<object> a_ = this.Morbid_Obesity_Diagnosis_On_or_Before_Follow_Up_USS_Assessment(context);
                bool? b_ = context.Operators.Exists<object>(a_);
                bool? c_ = this.BMI_Exam_Result_Greater_Than_or_Equal_To_40_During_Measurement_Period_and_On_or_Before_Follow_Up_USS_Assessment(context);
                bool? d_ = context.Operators.Or(b_, c_);
                return d_;
            });


    private Cached<bool?> _Denominator_Exclusions_Cached = new();

    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context) =>
        _Denominator_Exclusions_Cached.GetOrReplace(
            context,
            () =>
            {
                IEnumerable<object> a_ = this.Urinary_Retention_Diagnosis_Starts_Within_1_Year_After_Initial_BPH_Diagnosis(context);
                bool? b_ = context.Operators.Exists<object>(a_);
                object c_ = this.Has_Initial_BPH_Diagnosis_Starts_During_or_Within_30_Days_After_End_of_Hospitalization(context);
                bool? d_ = context.Operators.Not((bool?)(c_ is null));
                bool? e_ = context.Operators.Or(b_, d_);
                bool? f_ = this.Morbid_Obesity_Diagnosis_or_BMI_Exam_Result_Greater_Than_or_Equal_to_40_Starts_On_or_Before_Follow_Up_USS_Assessment(context);
                bool? g_ = context.Operators.Or(e_, f_);
                return g_;
            });


    private Cached<int?> _Urinary_Symptom_Score_Change_Cached = new();

    [CqlExpressionDefinition("Urinary Symptom Score Change")]
    public int? Urinary_Symptom_Score_Change(CqlContext context) =>
        _Urinary_Symptom_Score_Change_Cached.GetOrReplace(
            context,
            () =>
            {
                (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? a_ = this.Urinary_Symptom_Score_Within_1_Month_After_Initial_BPH_Diagnosis(context);
                (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?[] b_ = [
                    a_,
                ];
                (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? c_ = this.Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis(context);
                (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?[] d_ = [
                    c_,
                ];
                IEnumerable<ValueTuple<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>> e_ = context.Operators.CrossJoin<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>((IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>)b_, (IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>)d_);

                (CqlTupleMetadata, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FirstUSSAssessment, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment)? f_(ValueTuple<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> _valueTuple) {
                    (CqlTupleMetadata, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FirstUSSAssessment, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment)? l_ = (CqlTupleMetadata_FBHNjYWJgMKheadEZUgcdQGXN, _valueTuple.Item1, _valueTuple.Item2);
                    return l_;
                }

                IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FirstUSSAssessment, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment)?> g_ = context.Operators.Select<ValueTuple<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>, (CqlTupleMetadata, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FirstUSSAssessment, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment)?>(e_, f_);

                int? h_((CqlTupleMetadata, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FirstUSSAssessment, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment)? tuple_fbhnjywjgmkheadezugcdqgxn) {
                    int? m_ = tuple_fbhnjywjgmkheadezugcdqgxn?.FirstUSSAssessment?.valueInteger;
                    int? n_ = tuple_fbhnjywjgmkheadezugcdqgxn?.FollowUpUSSAssessment?.valueInteger;
                    int? o_ = context.Operators.Subtract(m_, n_);
                    return o_;
                }

                IEnumerable<int?> i_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FirstUSSAssessment, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment)?, int?>(g_, h_);
                IEnumerable<int?> j_ = context.Operators.Distinct<int?>(i_);
                int? k_ = context.Operators.SingletonFrom<int?>(j_);
                return k_;
            });


    private Cached<bool?> _Urinary_Symptom_Score_Improvement_Greater_Than_or_Equal_To_3_Cached = new();

    [CqlExpressionDefinition("Urinary Symptom Score Improvement Greater Than or Equal To 3")]
    public bool? Urinary_Symptom_Score_Improvement_Greater_Than_or_Equal_To_3(CqlContext context) =>
        _Urinary_Symptom_Score_Improvement_Greater_Than_or_Equal_To_3_Cached.GetOrReplace(
            context,
            () =>
            {
                int? a_ = this.Urinary_Symptom_Score_Change(context);
                int?[] b_ = [
                    a_,
                ];

                bool? c_(int? USSImprovement) {
                    bool? g_ = context.Operators.GreaterOrEqual(USSImprovement, 3);
                    return g_;
                }

                IEnumerable<int?> d_ = context.Operators.Where<int?>((IEnumerable<int?>)b_, c_);
                int? e_ = context.Operators.SingletonFrom<int?>(d_);
                bool? f_ = context.Operators.Not((bool?)(e_ is null));
                return f_;
            });


    private Cached<bool?> _Numerator_Cached = new();

    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context) =>
        _Numerator_Cached.GetOrReplace(
            context,
            () =>
            {
                bool? a_ = this.Urinary_Symptom_Score_Improvement_Greater_Than_or_Equal_To_3(context);
                return a_;
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

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_FBHNjYWJgMKheadEZUgcdQGXN = new(
       [typeof((CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?), typeof((CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?)],
       ["FirstUSSAssessment", "FollowUpUSSAssessment"]);

    private static CqlTupleMetadata CqlTupleMetadata_GNNDVIQPcTANSdLebhBKYIdga = new(
       [typeof(CqlDateTime), typeof(int?)],
       ["effectiveDatetime", "valueInteger"]);

    #endregion CqlTupleMetadata Properties

}
