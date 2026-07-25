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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.5.0")]
[CqlLibrary("CMS771FHIRUrinarySymptomScoreBPH", "1.0.000")]
public partial class CMS771FHIRUrinarySymptomScoreBPH_1_0_000 : ILibrary, ISingleton<CMS771FHIRUrinarySymptomScoreBPH_1_0_000>
{
    #region ValueSets (4)

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

    #region Codes (5)

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

    #region CodeSystems (3)

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

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = -8833359695928542789L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("CMS771FHIRUrinarySymptomScoreBPH-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (26)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = -7136269309086747551L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Patient is Male")]
    public bool? Patient_is_Male(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient_is_Male, Patient_is_Male_Compute);

    private const long _cacheIndex_Patient_is_Male = 6060259234332509991L;

    private bool? Patient_is_Male_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        CqlCode b_ = SupplementalDataElements_5_1_000.Instance.Male__finding_(context);
        bool? c_ = context.Operators.Equivalent(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Has Qualifying Encounter")]
    public bool? Has_Qualifying_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Qualifying_Encounter, Has_Qualifying_Encounter_Compute);

    private const long _cacheIndex_Has_Qualifying_Encounter = -4068430116743739727L;

    private bool? Has_Qualifying_Encounter_Compute(CqlContext context)
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
    }


    [CqlFunctionDefinition("verificationStatusIsNotInvalid")]
    public bool? verificationStatusIsNotInvalid(CqlContext context, Condition condition)
    {
        CodeableConcept a_ = condition?.VerificationStatus;
        CqlConcept b_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_);
        CqlCode c_ = QICoreCommon_4_0_000.Instance.unconfirmed(context);
        CqlConcept d_ = context.Operators.ConvertCodeToConcept(c_);
        bool? e_ = context.Operators.Equivalent(b_, d_);
        CqlCode f_ = QICoreCommon_4_0_000.Instance.refuted(context);
        CqlConcept g_ = context.Operators.ConvertCodeToConcept(f_);
        bool? h_ = context.Operators.Equivalent(b_, g_);
        bool? i_ = context.Operators.Or(e_, h_);
        CqlCode j_ = QICoreCommon_4_0_000.Instance.entered_in_error(context);
        CqlConcept k_ = context.Operators.ConvertCodeToConcept(j_);
        bool? l_ = context.Operators.Equivalent(b_, k_);
        bool? m_ = context.Operators.Or(i_, l_);
        bool? n_ = context.Operators.Not(m_);
        bool? o_ = context.Operators.Or((bool?)(b_ is null), n_);
        return o_;
    }


    [CqlExpressionDefinition("Initial BPH Diagnosis Starts Within 6 Months Before the Measurement Period")]
    public Condition Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_the_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_the_Measurement_Period, Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_the_Measurement_Period_Compute);

    private const long _cacheIndex_Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_the_Measurement_Period = 2791684942891539381L;

    private Condition Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_the_Measurement_Period_Compute(CqlContext context)
    {
        CqlCode a_ = this.Benign_prostatic_hyperplasia_with_lower_urinary_tract_symptoms(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> e_ = context.Operators.Union<Condition>(c_ as IEnumerable<Condition>, d_ as IEnumerable<Condition>);

        bool? f_(Condition NewBPHDiagnosis) {
            CqlInterval<CqlDateTime> k_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, NewBPHDiagnosis);
            CqlDateTime l_ = context.Operators.Start(k_);
            CqlInterval<CqlDateTime> m_ = this.Measurement_Period(context);
            CqlDateTime n_ = context.Operators.Start(m_);
            CqlQuantity o_ = context.Operators.Quantity(6m, "months");
            CqlDateTime p_ = context.Operators.Subtract(n_, o_);
            CqlInterval<CqlDateTime> q_ = context.Operators.Interval(p_, n_, true, true);
            bool? r_ = context.Operators.In<CqlDateTime>(l_, q_, (string)default);
            bool? s_ = this.verificationStatusIsNotInvalid(context, NewBPHDiagnosis);
            bool? t_ = context.Operators.And(r_, s_);
            return t_;
        }

        IEnumerable<Condition> g_ = context.Operators.Where<Condition>(e_, f_);

        object h_(Condition @this) {
            DataType u_ = @this?.Onset;
            object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
            CqlInterval<CqlDateTime> w_ = QICoreCommon_4_0_000.Instance.toInterval(context, v_);
            CqlDateTime x_ = context.Operators.Start(w_);
            return x_;
        }

        IEnumerable<Condition> i_ = context.Operators.SortBy<Condition>(g_, h_, System.ComponentModel.ListSortDirection.Ascending);
        Condition j_ = context.Operators.First<Condition>(i_);
        return j_;
    }


    [CqlExpressionDefinition("Has Qualifying BPH Diagnosis")]
    public bool? Has_Qualifying_BPH_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Qualifying_BPH_Diagnosis, Has_Qualifying_BPH_Diagnosis_Compute);

    private const long _cacheIndex_Has_Qualifying_BPH_Diagnosis = -4191473135525818319L;

    private bool? Has_Qualifying_BPH_Diagnosis_Compute(CqlContext context)
    {
        Condition a_ = this.Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_the_Measurement_Period(context);
        bool? b_ = context.Operators.Not((bool?)(a_ is null));
        return b_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = 3181761122815071839L;

    private bool? Initial_Population_Compute(CqlContext context)
    {
        bool? a_ = this.Patient_is_Male(context);
        bool? b_ = this.Has_Qualifying_Encounter(context);
        bool? c_ = context.Operators.And(a_, b_);
        bool? d_ = this.Has_Qualifying_BPH_Diagnosis(context);
        bool? e_ = context.Operators.And(c_, d_);
        return e_;
    }


    [CqlExpressionDefinition("Documented IPSS Assessment Result")]
    public IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> Documented_IPSS_Assessment_Result(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Documented_IPSS_Assessment_Result, Documented_IPSS_Assessment_Result_Compute);

    private const long _cacheIndex_Documented_IPSS_Assessment_Result = -7237826570223623961L;

    private IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> Documented_IPSS_Assessment_Result_Compute(CqlContext context)
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
            object r_;
            DataType w_ = IPSSAssessment?.Effective;
            object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
            bool y_ = x_ is CqlDateTime;
            if (y_)
            {
                DataType z_ = IPSSAssessment?.Effective;
                object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                r_ = aa_ as CqlDateTime;
            }
            else
            {
                DataType ab_ = IPSSAssessment?.Effective;
                object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                bool ad_ = ac_ is CqlInterval<CqlDateTime>;
                if (ad_)
                {
                    DataType ae_ = IPSSAssessment?.Effective;
                    object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                    r_ = af_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType ag_ = IPSSAssessment?.Effective;
                    object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                    bool ai_ = ah_ is CqlDateTime;
                    if (ai_)
                    {
                        DataType aj_ = IPSSAssessment?.Effective;
                        object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                        r_ = ak_ as CqlDateTime;
                    }
                    else
                    {
                        r_ = null;
                    }
                }
            }
            CqlDateTime s_ = QICoreCommon_4_0_000.Instance.earliest(context, r_);
            DataType t_ = IPSSAssessment?.Value;
            object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
            (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? v_ = (CqlTupleMetadata_GNNDVIQPcTANSdLebhBKYIdga, s_, u_ as int?);
            return v_;
        }

        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> g_ = context.Operators.Select<Observation, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(e_, f_);
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> h_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(g_);
        return h_;
    }


    [CqlExpressionDefinition("AUA Symptom Index and Quality of Life Assessment Result")]
    public IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> AUA_Symptom_Index_and_Quality_of_Life_Assessment_Result(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_AUA_Symptom_Index_and_Quality_of_Life_Assessment_Result, AUA_Symptom_Index_and_Quality_of_Life_Assessment_Result_Compute);

    private const long _cacheIndex_AUA_Symptom_Index_and_Quality_of_Life_Assessment_Result = -5074193052768698502L;

    private IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> AUA_Symptom_Index_and_Quality_of_Life_Assessment_Result_Compute(CqlContext context)
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
            object r_;
            DataType ah_ = AUASIAssessment?.Effective;
            object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
            bool aj_ = ai_ is CqlDateTime;
            if (aj_)
            {
                DataType ak_ = AUASIAssessment?.Effective;
                object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                r_ = al_ as CqlDateTime;
            }
            else
            {
                DataType am_ = AUASIAssessment?.Effective;
                object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                bool ao_ = an_ is CqlInterval<CqlDateTime>;
                if (ao_)
                {
                    DataType ap_ = AUASIAssessment?.Effective;
                    object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                    r_ = aq_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    DataType ar_ = AUASIAssessment?.Effective;
                    object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                    bool at_ = as_ is CqlDateTime;
                    if (at_)
                    {
                        DataType au_ = AUASIAssessment?.Effective;
                        object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                        r_ = av_ as CqlDateTime;
                    }
                    else
                    {
                        r_ = null;
                    }
                }
            }
            CqlDateTime s_ = QICoreCommon_4_0_000.Instance.earliest(context, r_);
            DataType t_ = AUASIAssessment?.Value;
            object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
            CqlCode v_ = this.If_you_were_to_spend_the_rest_of_your_life_with_your_urinary_condition_just_the_way_it_is_now__how_would_you_feel_about_that__IPSS_(context);
            IEnumerable<CqlCode> w_ = context.Operators.ToList<CqlCode>(v_);
            IEnumerable<Observation> x_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, w_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));

            bool? y_(Observation QOLAssessment) {
                object aw_;
                DataType bl_ = QOLAssessment?.Effective;
                object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                bool bn_ = bm_ is CqlDateTime;
                if (bn_)
                {
                    DataType bo_ = QOLAssessment?.Effective;
                    object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                    aw_ = bp_ as CqlDateTime;
                }
                else
                {
                    DataType bq_ = QOLAssessment?.Effective;
                    object br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
                    bool bs_ = br_ is CqlInterval<CqlDateTime>;
                    if (bs_)
                    {
                        DataType bt_ = QOLAssessment?.Effective;
                        object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                        aw_ = bu_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType bv_ = QOLAssessment?.Effective;
                        object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                        bool bx_ = bw_ is CqlDateTime;
                        if (bx_)
                        {
                            DataType by_ = QOLAssessment?.Effective;
                            object bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);
                            aw_ = bz_ as CqlDateTime;
                        }
                        else
                        {
                            aw_ = null;
                        }
                    }
                }
                CqlDateTime ax_ = QICoreCommon_4_0_000.Instance.earliest(context, aw_);
                object ay_;
                DataType ca_ = AUASIAssessment?.Effective;
                object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                bool cc_ = cb_ is CqlDateTime;
                if (cc_)
                {
                    DataType cd_ = AUASIAssessment?.Effective;
                    object ce_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cd_);
                    ay_ = ce_ as CqlDateTime;
                }
                else
                {
                    DataType cf_ = AUASIAssessment?.Effective;
                    object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                    bool ch_ = cg_ is CqlInterval<CqlDateTime>;
                    if (ch_)
                    {
                        DataType ci_ = AUASIAssessment?.Effective;
                        object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                        ay_ = cj_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType ck_ = AUASIAssessment?.Effective;
                        object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                        bool cm_ = cl_ is CqlDateTime;
                        if (cm_)
                        {
                            DataType cn_ = AUASIAssessment?.Effective;
                            object co_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cn_);
                            ay_ = co_ as CqlDateTime;
                        }
                        else
                        {
                            ay_ = null;
                        }
                    }
                }
                CqlDateTime az_ = QICoreCommon_4_0_000.Instance.earliest(context, ay_);
                bool? ba_ = context.Operators.SameAs(ax_, az_, "day");
                Code<ObservationStatus> bb_ = QOLAssessment?.StatusElement;
                ObservationStatus? bc_ = bb_?.Value;
                string bd_ = context.Operators.Convert<string>(bc_);
                string[] be_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? bf_ = context.Operators.In<string>(bd_, (IEnumerable<string>)be_);
                bool? bg_ = context.Operators.And(ba_, bf_);
                DataType bh_ = QOLAssessment?.Value;
                object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                bool? bj_ = context.Operators.Not((bool?)(bi_ is null));
                bool? bk_ = context.Operators.And(bg_, bj_);
                return bk_;
            }

            IEnumerable<Observation> z_ = context.Operators.Where<Observation>(x_, y_);

            object aa_(Observation @this) {
                object cp_;
                DataType cr_ = @this?.Effective;
                object cs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cr_);
                bool ct_ = cs_ is CqlDateTime;
                if (ct_)
                {
                    DataType cu_ = @this?.Effective;
                    object cv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cu_);
                    cp_ = cv_ as CqlDateTime;
                }
                else
                {
                    DataType cw_ = @this?.Effective;
                    object cx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cw_);
                    bool cy_ = cx_ is CqlInterval<CqlDateTime>;
                    if (cy_)
                    {
                        DataType cz_ = @this?.Effective;
                        object da_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cz_);
                        cp_ = da_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType db_ = @this?.Effective;
                        object dc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, db_);
                        bool dd_ = dc_ is CqlDateTime;
                        if (dd_)
                        {
                            DataType de_ = @this?.Effective;
                            object df_ = FHIRHelpers_4_4_000.Instance.ToValue(context, de_);
                            cp_ = df_ as CqlDateTime;
                        }
                        else
                        {
                            cp_ = null;
                        }
                    }
                }
                CqlDateTime cq_ = QICoreCommon_4_0_000.Instance.earliest(context, cp_);
                return cq_;
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
    }


    [CqlExpressionDefinition("Urinary Symptom Score Assessment")]
    public IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> Urinary_Symptom_Score_Assessment(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Urinary_Symptom_Score_Assessment, Urinary_Symptom_Score_Assessment_Compute);

    private const long _cacheIndex_Urinary_Symptom_Score_Assessment = -6926091951122626887L;

    private IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> Urinary_Symptom_Score_Assessment_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> a_ = this.Documented_IPSS_Assessment_Result(context);
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> b_ = this.AUA_Symptom_Index_and_Quality_of_Life_Assessment_Result(context);
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> c_ = context.Operators.Union<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Urinary Symptom Score Within 1 Month After Initial BPH Diagnosis")]
    public (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? Urinary_Symptom_Score_Within_1_Month_After_Initial_BPH_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Urinary_Symptom_Score_Within_1_Month_After_Initial_BPH_Diagnosis, Urinary_Symptom_Score_Within_1_Month_After_Initial_BPH_Diagnosis_Compute);

    private const long _cacheIndex_Urinary_Symptom_Score_Within_1_Month_After_Initial_BPH_Diagnosis = -971062803861453571L;

    private (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? Urinary_Symptom_Score_Within_1_Month_After_Initial_BPH_Diagnosis_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> a_ = this.Urinary_Symptom_Score_Assessment(context);

        bool? b_((CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? USSAssessment) {
            Condition g_ = this.Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_the_Measurement_Period(context);
            Condition[] h_ = [
                g_,
            ];

            bool? i_(Condition InitialBPHDiagnosis) {
                CqlDateTime l_ = USSAssessment?.effectiveDatetime;
                CqlInterval<CqlDateTime> m_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, InitialBPHDiagnosis);
                CqlDateTime n_ = context.Operators.Start(m_);
                CqlQuantity o_ = context.Operators.Quantity(1m, "month");
                CqlDateTime p_ = context.Operators.Add(n_, o_);
                CqlInterval<CqlDateTime> q_ = context.Operators.Interval(n_, p_, true, true);
                bool? r_ = context.Operators.In<CqlDateTime>(l_, q_, "day");
                bool? s_ = context.Operators.Not((bool?)(n_ is null));
                bool? t_ = context.Operators.And(r_, s_);
                return t_;
            }

            IEnumerable<Condition> j_ = context.Operators.Where<Condition>((IEnumerable<Condition>)h_, i_);
            bool? k_ = context.Operators.Exists<Condition>(j_);
            return k_;
        }

        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> c_ = context.Operators.Where<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(a_, b_);

        object d_((CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? @this) {
            CqlDateTime u_ = @this?.effectiveDatetime;
            return u_;
        }

        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> e_ = context.Operators.SortBy<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(c_, d_, System.ComponentModel.ListSortDirection.Ascending);
        (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? f_ = context.Operators.First<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(e_);
        return f_;
    }


    [CqlExpressionDefinition("Urinary Symptom Score 6 to 12 Months After Initial BPH Diagnosis")]
    public (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis, Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis_Compute);

    private const long _cacheIndex_Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis = -324457888574945361L;

    private (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> a_ = this.Urinary_Symptom_Score_Assessment(context);

        bool? b_((CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? USSAssessment) {
            Condition g_ = this.Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_the_Measurement_Period(context);
            Condition[] h_ = [
                g_,
            ];

            bool? i_(Condition InitialBPHDiagnosis) {
                CqlInterval<CqlDateTime> l_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, InitialBPHDiagnosis);
                CqlDateTime m_ = context.Operators.Start(l_);
                CqlDateTime n_ = USSAssessment?.effectiveDatetime;
                int? o_ = context.Operators.DifferenceBetween(m_, n_, "month");
                CqlInterval<int?> p_ = context.Operators.Interval(6, 12, true, true);
                bool? q_ = context.Operators.In<int?>(o_, p_, (string)default);
                return q_;
            }

            IEnumerable<Condition> j_ = context.Operators.Where<Condition>((IEnumerable<Condition>)h_, i_);
            bool? k_ = context.Operators.Exists<Condition>(j_);
            return k_;
        }

        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> c_ = context.Operators.Where<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(a_, b_);

        object d_((CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? @this) {
            CqlDateTime r_ = @this?.effectiveDatetime;
            return r_;
        }

        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> e_ = context.Operators.SortBy<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(c_, d_, System.ComponentModel.ListSortDirection.Ascending);
        (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? f_ = context.Operators.Last<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(e_);
        return f_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = 7492513883980301647L;

    private bool? Denominator_Compute(CqlContext context)
    {
        bool? a_ = this.Initial_Population(context);
        (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? b_ = this.Urinary_Symptom_Score_Within_1_Month_After_Initial_BPH_Diagnosis(context);
        bool? c_ = context.Operators.Not((bool?)(b_ is null));
        bool? d_ = context.Operators.And(a_, c_);
        (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? e_ = this.Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis(context);
        bool? f_ = context.Operators.Not((bool?)(e_ is null));
        bool? g_ = context.Operators.And(d_, f_);
        return g_;
    }


    [CqlExpressionDefinition("Urinary Retention Diagnosis Starts Within 1 Year After Initial BPH Diagnosis")]
    public IEnumerable<Condition> Urinary_Retention_Diagnosis_Starts_Within_1_Year_After_Initial_BPH_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Urinary_Retention_Diagnosis_Starts_Within_1_Year_After_Initial_BPH_Diagnosis, Urinary_Retention_Diagnosis_Starts_Within_1_Year_After_Initial_BPH_Diagnosis_Compute);

    private const long _cacheIndex_Urinary_Retention_Diagnosis_Starts_Within_1_Year_After_Initial_BPH_Diagnosis = -1921163594377125910L;

    private IEnumerable<Condition> Urinary_Retention_Diagnosis_Starts_Within_1_Year_After_Initial_BPH_Diagnosis_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Urinary_Retention(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> d_ = context.Operators.Union<Condition>(b_ as IEnumerable<Condition>, c_ as IEnumerable<Condition>);

        bool? e_(Condition UrinaryRetention) {
            Condition i_ = this.Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_the_Measurement_Period(context);
            Condition[] j_ = [
                i_,
            ];

            bool? k_(Condition InitialBPHDiagnosis) {
                CqlInterval<CqlDateTime> n_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, UrinaryRetention);
                CqlDateTime o_ = context.Operators.Start(n_);
                CqlInterval<CqlDateTime> p_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, InitialBPHDiagnosis);
                CqlDateTime q_ = context.Operators.Start(p_);
                CqlQuantity r_ = context.Operators.Quantity(1m, "year");
                CqlDateTime s_ = context.Operators.Add(q_, r_);
                CqlInterval<CqlDateTime> t_ = context.Operators.Interval(q_, s_, true, true);
                bool? u_ = context.Operators.In<CqlDateTime>(o_, t_, "day");
                bool? v_ = context.Operators.Not((bool?)(q_ is null));
                bool? w_ = context.Operators.And(u_, v_);
                return w_;
            }

            IEnumerable<Condition> l_ = context.Operators.Where<Condition>((IEnumerable<Condition>)j_, k_);
            bool? m_ = context.Operators.Exists<Condition>(l_);
            return m_;
        }

        IEnumerable<Condition> f_ = context.Operators.Where<Condition>(d_, e_);

        bool? g_(Condition UrinaryRetention) {
            bool? x_ = this.verificationStatusIsNotInvalid(context, UrinaryRetention);
            return x_;
        }

        IEnumerable<Condition> h_ = context.Operators.Where<Condition>(f_, g_);
        return h_;
    }


    [CqlExpressionDefinition("Has Initial BPH Diagnosis Starts During or Within 30 Days After End of Hospitalization")]
    public Condition Has_Initial_BPH_Diagnosis_Starts_During_or_Within_30_Days_After_End_of_Hospitalization(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Initial_BPH_Diagnosis_Starts_During_or_Within_30_Days_After_End_of_Hospitalization, Has_Initial_BPH_Diagnosis_Starts_During_or_Within_30_Days_After_End_of_Hospitalization_Compute);

    private const long _cacheIndex_Has_Initial_BPH_Diagnosis_Starts_During_or_Within_30_Days_After_End_of_Hospitalization = -6925951689891403297L;

    private Condition Has_Initial_BPH_Diagnosis_Starts_During_or_Within_30_Days_After_End_of_Hospitalization_Compute(CqlContext context)
    {
        Condition a_ = this.Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_the_Measurement_Period(context);
        Condition[] b_ = [
            a_,
        ];

        bool? c_(Condition InitialBPHDiagnosis) {
            CqlValueSet f_ = this.Hospital_Services_for_Urology_Care(context);
            IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? h_(Encounter UrologyHospitalServices) {
                CqlInterval<CqlDateTime> k_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, InitialBPHDiagnosis);
                CqlDateTime l_ = context.Operators.Start(k_);
                Period m_ = UrologyHospitalServices?.Period;
                CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, m_);
                CqlDateTime o_ = context.Operators.Start(n_);
                CqlDateTime p_ = context.Operators.End(n_);
                CqlQuantity q_ = context.Operators.Quantity(31m, "days");
                CqlDateTime r_ = context.Operators.Add(p_, q_);
                CqlInterval<CqlDateTime> s_ = context.Operators.Interval(o_, r_, true, true);
                bool? t_ = context.Operators.In<CqlDateTime>(l_, s_, (string)default);
                Code<Encounter.EncounterStatus> u_ = UrologyHospitalServices?.StatusElement;
                Encounter.EncounterStatus? v_ = u_?.Value;
                Code<Encounter.EncounterStatus> w_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(v_);
                bool? x_ = context.Operators.Equal(w_, "finished");
                bool? y_ = context.Operators.And(t_, x_);
                return y_;
            }

            IEnumerable<Encounter> i_ = context.Operators.Where<Encounter>(g_, h_);
            bool? j_ = context.Operators.Exists<Encounter>(i_);
            return j_;
        }

        IEnumerable<Condition> d_ = context.Operators.Where<Condition>((IEnumerable<Condition>)b_, c_);
        Condition e_ = context.Operators.SingletonFrom<Condition>(d_);
        return e_;
    }


    [CqlExpressionDefinition("Morbid Obesity Diagnosis On or Before Follow Up USS Assessment")]
    public IEnumerable<Condition> Morbid_Obesity_Diagnosis_On_or_Before_Follow_Up_USS_Assessment(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Morbid_Obesity_Diagnosis_On_or_Before_Follow_Up_USS_Assessment, Morbid_Obesity_Diagnosis_On_or_Before_Follow_Up_USS_Assessment_Compute);

    private const long _cacheIndex_Morbid_Obesity_Diagnosis_On_or_Before_Follow_Up_USS_Assessment = 8671836689749221414L;

    private IEnumerable<Condition> Morbid_Obesity_Diagnosis_On_or_Before_Follow_Up_USS_Assessment_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Morbid_Obesity(context);
        IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition> c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition> d_ = context.Operators.Union<Condition>(b_ as IEnumerable<Condition>, c_ as IEnumerable<Condition>);

        bool? e_(Condition MorbidObesityDiagnosis) {
            (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? i_ = this.Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis(context);
            (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?[] j_ = [
                i_,
            ];

            bool? k_((CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment) {
                CqlInterval<CqlDateTime> n_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, MorbidObesityDiagnosis);
                CqlInterval<CqlDateTime> o_ = this.Measurement_Period(context);
                bool? p_ = context.Operators.Overlaps(n_, o_, (string)default);
                CqlDateTime q_ = context.Operators.Start(n_);
                CqlDateTime r_ = FollowUpUSSAssessment?.effectiveDatetime;
                bool? s_ = context.Operators.SameOrBefore(q_, r_, (string)default);
                bool? t_ = context.Operators.And(p_, s_);
                return t_;
            }

            IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> l_ = context.Operators.Where<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>((IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>)j_, k_);
            bool? m_ = context.Operators.Exists<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(l_);
            return m_;
        }

        IEnumerable<Condition> f_ = context.Operators.Where<Condition>(d_, e_);

        bool? g_(Condition MorbidObesityDiagnosis) {
            bool? u_ = this.verificationStatusIsNotInvalid(context, MorbidObesityDiagnosis);
            return u_;
        }

        IEnumerable<Condition> h_ = context.Operators.Where<Condition>(f_, g_);
        return h_;
    }


    [CqlExpressionDefinition("BMI Exam Result Greater Than or Equal To 40 During Measurement Period and On or Before Follow Up USS Assessment")]
    [CqlTag("code", "Body mass index (BMI) [Ratio] - 39156-5")]
    [CqlTag("profile", "http://hl7.org/fhir/StructureDefinition/bmi")]
    public bool? BMI_Exam_Result_Greater_Than_or_Equal_To_40_During_Measurement_Period_and_On_or_Before_Follow_Up_USS_Assessment(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_BMI_Exam_Result_Greater_Than_or_Equal_To_40_During_Measurement_Period_and_On_or_Before_Follow_Up_USS_Assessment, BMI_Exam_Result_Greater_Than_or_Equal_To_40_During_Measurement_Period_and_On_or_Before_Follow_Up_USS_Assessment_Compute);

    private const long _cacheIndex_BMI_Exam_Result_Greater_Than_or_Equal_To_40_During_Measurement_Period_and_On_or_Before_Follow_Up_USS_Assessment = 400125730302849922L;

    private bool? BMI_Exam_Result_Greater_Than_or_Equal_To_40_During_Measurement_Period_and_On_or_Before_Follow_Up_USS_Assessment_Compute(CqlContext context)
    {
        IEnumerable<Observation> a_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-bmi"));

        bool? b_(Observation BMIExam) {
            (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? h_ = this.Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis(context);
            (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?[] i_ = [
                h_,
            ];

            bool? j_((CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment) {
                DataType m_ = BMIExam?.Value;
                CqlQuantity n_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, m_ as Quantity);
                CqlQuantity o_ = context.Operators.Quantity(40m, "kg/m2");
                bool? p_ = context.Operators.GreaterOrEqual(n_, o_);
                Code<ObservationStatus> q_ = BMIExam?.StatusElement;
                ObservationStatus? r_ = q_?.Value;
                string s_ = context.Operators.Convert<string>(r_);
                string[] t_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? u_ = context.Operators.In<string>(s_, (IEnumerable<string>)t_);
                bool? v_ = context.Operators.And(p_, u_);
                DataType w_ = BMIExam?.Effective;
                object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                CqlDateTime y_ = QICoreCommon_4_0_000.Instance.earliest(context, x_);
                CqlInterval<CqlDateTime> z_ = this.Measurement_Period(context);
                bool? aa_ = context.Operators.In<CqlDateTime>(y_, z_, "day");
                bool? ab_ = context.Operators.And(v_, aa_);
                CqlDateTime ac_ = FollowUpUSSAssessment?.effectiveDatetime;
                bool? ad_ = context.Operators.SameOrBefore(y_, ac_, (string)default);
                bool? ae_ = context.Operators.And(ab_, ad_);
                return ae_;
            }

            IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> k_ = context.Operators.Where<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>((IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>)i_, j_);
            bool? l_ = context.Operators.Exists<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(k_);
            return l_;
        }

        IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);

        CqlDateTime d_(Observation BMIExam) {
            DataType af_ = BMIExam?.Effective;
            object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
            CqlDateTime ah_ = QICoreCommon_4_0_000.Instance.earliest(context, ag_);
            return ah_;
        }

        IEnumerable<CqlDateTime> e_ = context.Operators.Select<Observation, CqlDateTime>(c_, d_);
        IEnumerable<CqlDateTime> f_ = context.Operators.Distinct<CqlDateTime>(e_);
        bool? g_ = context.Operators.Exists<CqlDateTime>(f_);
        return g_;
    }


    [CqlExpressionDefinition("Morbid Obesity Diagnosis or BMI Exam Result Greater Than or Equal to 40 Starts On or Before Follow Up USS Assessment")]
    public bool? Morbid_Obesity_Diagnosis_or_BMI_Exam_Result_Greater_Than_or_Equal_to_40_Starts_On_or_Before_Follow_Up_USS_Assessment(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Morbid_Obesity_Diagnosis_or_BMI_Exam_Result_Greater_Than_or_Equal_to_40_Starts_On_or_Before_Follow_Up_USS_Assessment, Morbid_Obesity_Diagnosis_or_BMI_Exam_Result_Greater_Than_or_Equal_to_40_Starts_On_or_Before_Follow_Up_USS_Assessment_Compute);

    private const long _cacheIndex_Morbid_Obesity_Diagnosis_or_BMI_Exam_Result_Greater_Than_or_Equal_to_40_Starts_On_or_Before_Follow_Up_USS_Assessment = -775102312589408922L;

    private bool? Morbid_Obesity_Diagnosis_or_BMI_Exam_Result_Greater_Than_or_Equal_to_40_Starts_On_or_Before_Follow_Up_USS_Assessment_Compute(CqlContext context)
    {
        IEnumerable<Condition> a_ = this.Morbid_Obesity_Diagnosis_On_or_Before_Follow_Up_USS_Assessment(context);
        bool? b_ = context.Operators.Exists<Condition>(a_);
        bool? c_ = this.BMI_Exam_Result_Greater_Than_or_Equal_To_40_During_Measurement_Period_and_On_or_Before_Follow_Up_USS_Assessment(context);
        bool? d_ = context.Operators.Or(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exclusions, Denominator_Exclusions_Compute);

    private const long _cacheIndex_Denominator_Exclusions = 6226559503250220937L;

    private bool? Denominator_Exclusions_Compute(CqlContext context)
    {
        IEnumerable<Condition> a_ = this.Urinary_Retention_Diagnosis_Starts_Within_1_Year_After_Initial_BPH_Diagnosis(context);
        bool? b_ = context.Operators.Exists<Condition>(a_);
        Condition c_ = this.Has_Initial_BPH_Diagnosis_Starts_During_or_Within_30_Days_After_End_of_Hospitalization(context);
        bool? d_ = context.Operators.Not((bool?)(c_ is null));
        bool? e_ = context.Operators.Or(b_, d_);
        bool? f_ = this.Morbid_Obesity_Diagnosis_or_BMI_Exam_Result_Greater_Than_or_Equal_to_40_Starts_On_or_Before_Follow_Up_USS_Assessment(context);
        bool? g_ = context.Operators.Or(e_, f_);
        return g_;
    }


    [CqlExpressionDefinition("Urinary Symptom Score Change")]
    public int? Urinary_Symptom_Score_Change(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Urinary_Symptom_Score_Change, Urinary_Symptom_Score_Change_Compute);

    private const long _cacheIndex_Urinary_Symptom_Score_Change = -2949483701475691031L;

    private int? Urinary_Symptom_Score_Change_Compute(CqlContext context)
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
    }


    [CqlExpressionDefinition("Urinary Symptom Score Improvement Greater Than or Equal To 3")]
    public bool? Urinary_Symptom_Score_Improvement_Greater_Than_or_Equal_To_3(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Urinary_Symptom_Score_Improvement_Greater_Than_or_Equal_To_3, Urinary_Symptom_Score_Improvement_Greater_Than_or_Equal_To_3_Compute);

    private const long _cacheIndex_Urinary_Symptom_Score_Improvement_Greater_Than_or_Equal_To_3 = -4907289622604644412L;

    private bool? Urinary_Symptom_Score_Improvement_Greater_Than_or_Equal_To_3_Compute(CqlContext context)
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
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = 7932272766655260239L;

    private bool? Numerator_Compute(CqlContext context)
    {
        bool? a_ = this.Urinary_Symptom_Score_Improvement_Greater_Than_or_Equal_To_3(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = -5127160186345354969L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = 2525696613965935061L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = -4675145480817501309L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = -7551527745134025677L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private CMS771FHIRUrinarySymptomScoreBPH_1_0_000() {}

    public static CMS771FHIRUrinarySymptomScoreBPH_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS771FHIRUrinarySymptomScoreBPH";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_5_1_000.Instance, QICoreCommon_4_0_000.Instance];

    #endregion ILibrary Implementation

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_FBHNjYWJgMKheadEZUgcdQGXN = new(
       [typeof((CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?), typeof((CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?)],
       ["FirstUSSAssessment", "FollowUpUSSAssessment"]);

    private static CqlTupleMetadata CqlTupleMetadata_GNNDVIQPcTANSdLebhBKYIdga = new(
       [typeof(CqlDateTime), typeof(int?)],
       ["effectiveDatetime", "valueInteger"]);

    #endregion CqlTupleMetadata Properties

}
