#nullable enable annotations

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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.0.0")]
[CqlLibrary("CMS771FHIRUrinarySymptomScoreBPH", "1.0.000")]
public partial class CMS771FHIRUrinarySymptomScoreBPH_1_0_000 : ILibrary, ISingleton<CMS771FHIRUrinarySymptomScoreBPH_1_0_000>
{
    #region ValueSets (4)

    [CqlValueSetDefinition("Hospital Services for Urology Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.360", valueSetVersion: null)]
    public CqlValueSet? Hospital_Services_for_Urology_Care(CqlContext _) => _Hospital_Services_for_Urology_Care;
    private static readonly CqlValueSet? _Hospital_Services_for_Urology_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.360", null);

    [CqlValueSetDefinition("Morbid Obesity", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.368", valueSetVersion: null)]
    public CqlValueSet? Morbid_Obesity(CqlContext _) => _Morbid_Obesity;
    private static readonly CqlValueSet? _Morbid_Obesity = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.368", null);

    [CqlValueSetDefinition("Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", valueSetVersion: null)]
    public CqlValueSet? Office_Visit(CqlContext _) => _Office_Visit;
    private static readonly CqlValueSet? _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlValueSetDefinition("Urinary Retention", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.372", valueSetVersion: null)]
    public CqlValueSet? Urinary_Retention(CqlContext _) => _Urinary_Retention;
    private static readonly CqlValueSet? _Urinary_Retention = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.372", null);

    #endregion ValueSets

    #region Codes (5)

    [CqlCodeDefinition("American Urological Association Symptom Index [AUASI]", codeId: "80883-2", codeSystem: "http://loinc.org")]
    public CqlCode? American_Urological_Association_Symptom_Index__AUASI_(CqlContext _) => _American_Urological_Association_Symptom_Index__AUASI_;
    private static readonly CqlCode? _American_Urological_Association_Symptom_Index__AUASI_ = new CqlCode("80883-2", "http://loinc.org");

    [CqlCodeDefinition("Benign prostatic hyperplasia with lower urinary tract symptoms", codeId: "N40.1", codeSystem: "http://hl7.org/fhir/sid/icd-10-cm")]
    public CqlCode? Benign_prostatic_hyperplasia_with_lower_urinary_tract_symptoms(CqlContext _) => _Benign_prostatic_hyperplasia_with_lower_urinary_tract_symptoms;
    private static readonly CqlCode? _Benign_prostatic_hyperplasia_with_lower_urinary_tract_symptoms = new CqlCode("N40.1", "http://hl7.org/fhir/sid/icd-10-cm");

    [CqlCodeDefinition("If you were to spend the rest of your life with your urinary condition just the way it is now, how would you feel about that [IPSS]", codeId: "81090-3", codeSystem: "http://loinc.org")]
    public CqlCode? If_you_were_to_spend_the_rest_of_your_life_with_your_urinary_condition_just_the_way_it_is_now__how_would_you_feel_about_that__IPSS_(CqlContext _) => _If_you_were_to_spend_the_rest_of_your_life_with_your_urinary_condition_just_the_way_it_is_now__how_would_you_feel_about_that__IPSS_;
    private static readonly CqlCode? _If_you_were_to_spend_the_rest_of_your_life_with_your_urinary_condition_just_the_way_it_is_now__how_would_you_feel_about_that__IPSS_ = new CqlCode("81090-3", "http://loinc.org");

    [CqlCodeDefinition("International Prostate Symptom Score [IPSS]", codeId: "80976-4", codeSystem: "http://loinc.org")]
    public CqlCode? International_Prostate_Symptom_Score__IPSS_(CqlContext _) => _International_Prostate_Symptom_Score__IPSS_;
    private static readonly CqlCode? _International_Prostate_Symptom_Score__IPSS_ = new CqlCode("80976-4", "http://loinc.org");

    [CqlCodeDefinition("virtual", codeId: "VR", codeSystem: "http://terminology.hl7.org/CodeSystem/v3-ActCode")]
    public CqlCode? @virtual(CqlContext _) => _virtual;
    private static readonly CqlCode? _virtual = new CqlCode("VR", "http://terminology.hl7.org/CodeSystem/v3-ActCode");

    #endregion Codes

    #region CodeSystems (3)

    [CqlCodeSystemDefinition("LOINC", codeSystemId: "http://loinc.org", codeSystemVersion: null)]
    public CqlCodeSystem? LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem? _LOINC =
      new CqlCodeSystem("http://loinc.org", null, [
          _American_Urological_Association_Symptom_Index__AUASI_,
          _If_you_were_to_spend_the_rest_of_your_life_with_your_urinary_condition_just_the_way_it_is_now__how_would_you_feel_about_that__IPSS_,
          _International_Prostate_Symptom_Score__IPSS_]);

    [CqlCodeSystemDefinition("ICD10CM", codeSystemId: "http://hl7.org/fhir/sid/icd-10-cm", codeSystemVersion: null)]
    public CqlCodeSystem? ICD10CM(CqlContext _) => _ICD10CM;
    private static readonly CqlCodeSystem? _ICD10CM =
      new CqlCodeSystem("http://hl7.org/fhir/sid/icd-10-cm", null, [
          _Benign_prostatic_hyperplasia_with_lower_urinary_tract_symptoms]);

    [CqlCodeSystemDefinition("ActCode", codeSystemId: "http://terminology.hl7.org/CodeSystem/v3-ActCode", codeSystemVersion: null)]
    public CqlCodeSystem? ActCode(CqlContext _) => _ActCode;
    private static readonly CqlCodeSystem? _ActCode =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/v3-ActCode", null, [
          _virtual]);

    #endregion CodeSystems

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime?>? Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = -8833359695928542789L;

    private CqlInterval<CqlDateTime?>? Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime? a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime? b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime?>? c_ = context.Operators.Interval(a_, b_, true, false);
        object? d_ = context.ResolveParameter("CMS771FHIRUrinarySymptomScoreBPH-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (26)

    [CqlExpressionDefinition("Patient")]
    public Patient? Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = -7136269309086747551L;

    private Patient? Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient?>? a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient? b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Patient is Male")]
    public bool? Patient_is_Male(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient_is_Male, Patient_is_Male_Compute);

    private const long _cacheIndex_Patient_is_Male = 6060259234332509991L;

    private bool? Patient_is_Male_Compute(CqlContext context)
    {
        CqlCode? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        CqlCode? b_ = SupplementalDataElements_5_1_000.Instance.Male__finding_(context);
        bool? c_ = context.Operators.Equivalent(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Has Qualifying Encounter")]
    public bool? Has_Qualifying_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Qualifying_Encounter, Has_Qualifying_Encounter_Compute);

    private const long _cacheIndex_Has_Qualifying_Encounter = -4068430116743739727L;

    private bool? Has_Qualifying_Encounter_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Office_Visit(context);
        IEnumerable<Encounter?>? b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

        bool? c_(Encounter? ValidEncounter) {
            CqlInterval<CqlDateTime?>? e_ = this.Measurement_Period(context);
            Period? f_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime?>? g_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, f_);
            bool? h_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(e_, g_, "day");
            Coding? i_ = ValidEncounter?.Class;
            CqlCode? j_ = FHIRHelpers_4_4_000.Instance.ToCode(context, i_);
            CqlCode? k_ = this.@virtual(context);
            bool? l_ = context.Operators.Equivalent(j_, k_);
            bool? m_ = context.Operators.Not(l_);
            bool? n_ = context.Operators.And(h_, m_);
            Code<Encounter.EncounterStatus>? o_ = ValidEncounter?.StatusElement;
            Encounter.EncounterStatus? p_ = o_?.Value;
            Code<Encounter.EncounterStatus>? q_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(p_);
            bool? r_ = context.Operators.Equal(q_, "finished");
            bool? s_ = context.Operators.And(n_, r_);
            return s_;
        }

        bool? d_ = context.Operators.WhereAny<Encounter>(b_, c_);
        return d_;
    }


    [CqlFunctionDefinition("verificationStatusIsNotInvalid")]
    public bool? verificationStatusIsNotInvalid(CqlContext context, Condition? condition)
    {
        CodeableConcept? a_ = condition?.VerificationStatus;
        CqlConcept? b_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_);
        CqlCode? c_ = QICoreCommon_4_0_000.Instance.unconfirmed(context);
        CqlConcept? d_ = context.Operators.ConvertCodeToConcept(c_);
        bool? e_ = context.Operators.Equivalent(b_, d_);
        CqlCode? f_ = QICoreCommon_4_0_000.Instance.refuted(context);
        CqlConcept? g_ = context.Operators.ConvertCodeToConcept(f_);
        bool? h_ = context.Operators.Equivalent(b_, g_);
        bool? i_ = context.Operators.Or(e_, h_);
        CqlCode? j_ = QICoreCommon_4_0_000.Instance.entered_in_error(context);
        CqlConcept? k_ = context.Operators.ConvertCodeToConcept(j_);
        bool? l_ = context.Operators.Equivalent(b_, k_);
        bool? m_ = context.Operators.Or(i_, l_);
        bool? n_ = context.Operators.Not(m_);
        bool? o_ = context.Operators.Or((bool?)(b_ is null), n_);
        return o_;
    }


    [CqlExpressionDefinition("Initial BPH Diagnosis Starts Within 6 Months Before the Measurement Period")]
    public Condition? Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_the_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_the_Measurement_Period, Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_the_Measurement_Period_Compute);

    private const long _cacheIndex_Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_the_Measurement_Period = 2791684942891539381L;

    private Condition? Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_the_Measurement_Period_Compute(CqlContext context)
    {
        CqlCode? a_ = this.Benign_prostatic_hyperplasia_with_lower_urinary_tract_symptoms(context);
        IEnumerable<CqlCode?>? b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Condition?>? c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition?>? d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition?>? e_ = context.Operators.Union<Condition>(c_ as IEnumerable<Condition>, d_ as IEnumerable<Condition>);

        bool? f_(Condition? NewBPHDiagnosis) {
            CqlInterval<CqlDateTime?>? k_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, NewBPHDiagnosis);
            CqlDateTime? l_ = context.Operators.Start(k_);
            CqlInterval<CqlDateTime?>? m_ = this.Measurement_Period(context);
            CqlDateTime? n_ = context.Operators.Start(m_);
            CqlQuantity? o_ = context.Operators.Quantity(6m, "months");
            CqlDateTime? p_ = context.Operators.Subtract(n_, o_);
            CqlInterval<CqlDateTime?>? q_ = context.Operators.Interval(p_, n_, true, true);
            bool? r_ = context.Operators.In<CqlDateTime>(l_, q_, (string)default);
            bool? s_ = this.verificationStatusIsNotInvalid(context, NewBPHDiagnosis);
            bool? t_ = context.Operators.And(r_, s_);
            return t_;
        }

        IEnumerable<Condition?>? g_ = context.Operators.Where<Condition>(e_, f_);

        object? h_(Condition? @this) {
            DataType? u_ = @this?.Onset;
            object? v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
            CqlInterval<CqlDateTime?>? w_ = QICoreCommon_4_0_000.Instance.toInterval(context, v_);
            CqlDateTime? x_ = context.Operators.Start(w_);
            return x_;
        }

        IEnumerable<Condition?>? i_ = context.Operators.SortBy<Condition>(g_, h_, System.ComponentModel.ListSortDirection.Ascending);
        Condition? j_ = context.Operators.First<Condition>(i_);
        return j_;
    }


    [CqlExpressionDefinition("Has Qualifying BPH Diagnosis")]
    public bool? Has_Qualifying_BPH_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Qualifying_BPH_Diagnosis, Has_Qualifying_BPH_Diagnosis_Compute);

    private const long _cacheIndex_Has_Qualifying_BPH_Diagnosis = -4191473135525818319L;

    private bool? Has_Qualifying_BPH_Diagnosis_Compute(CqlContext context)
    {
        Condition? a_ = this.Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_the_Measurement_Period(context);
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
    public IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>? Documented_IPSS_Assessment_Result(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Documented_IPSS_Assessment_Result, Documented_IPSS_Assessment_Result_Compute);

    private const long _cacheIndex_Documented_IPSS_Assessment_Result = -7237826570223623961L;

    private IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>? Documented_IPSS_Assessment_Result_Compute(CqlContext context)
    {
        CqlCode? a_ = this.International_Prostate_Symptom_Score__IPSS_(context);
        IEnumerable<CqlCode?>? b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation?>? c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));

        bool? d_(Observation? IPSSAssessment) {
            Code<ObservationStatus>? h_ = IPSSAssessment?.StatusElement;
            ObservationStatus? i_ = h_?.Value;
            string? j_ = context.Operators.Convert<string>(i_);
            string?[]? k_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? l_ = context.Operators.In<string>(j_, (IEnumerable<string>)k_);
            DataType? m_ = IPSSAssessment?.Value;
            object? n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
            bool? o_ = context.Operators.Not((bool?)(n_ is null));
            bool? p_ = context.Operators.And(l_, o_);
            return p_;
        }


        (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? e_(Observation? IPSSAssessment) {
            object? q_;
            DataType? v_ = IPSSAssessment?.Effective;
            object? w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
            bool x_ = w_ is CqlDateTime;
            if (x_)
            {
                DataType? y_ = IPSSAssessment?.Effective;
                object? z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                q_ = z_ as CqlDateTime;
            }
            else
            {
                DataType? aa_ = IPSSAssessment?.Effective;
                object? ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                bool ac_ = ab_ is CqlDateTime;
                if (ac_)
                {
                    DataType? ad_ = IPSSAssessment?.Effective;
                    object? ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                    q_ = ae_ as CqlDateTime;
                }
                else
                {
                    DataType? af_ = IPSSAssessment?.Effective;
                    object? ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                    bool ah_ = ag_ is CqlInterval<CqlDateTime>;
                    if (ah_)
                    {
                        DataType? ai_ = IPSSAssessment?.Effective;
                        object? aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                        q_ = aj_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        q_ = null;
                    }
                }
            }
            CqlDateTime? r_ = QICoreCommon_4_0_000.Instance.earliest(context, q_);
            DataType? s_ = IPSSAssessment?.Value;
            object? t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
            (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? u_ = (CqlTupleMetadata_GNNDVIQPcTANSdLebhBKYIdga, r_, t_ as int?);
            return u_;
        }

        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>? f_ = context.Operators.WhereSelect<Observation, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(c_, d_, e_);
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>? g_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(f_);
        return g_;
    }


    [CqlExpressionDefinition("AUA Symptom Index and Quality of Life Assessment Result")]
    public IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>? AUA_Symptom_Index_and_Quality_of_Life_Assessment_Result(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_AUA_Symptom_Index_and_Quality_of_Life_Assessment_Result, AUA_Symptom_Index_and_Quality_of_Life_Assessment_Result_Compute);

    private const long _cacheIndex_AUA_Symptom_Index_and_Quality_of_Life_Assessment_Result = -5074193052768698502L;

    private IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>? AUA_Symptom_Index_and_Quality_of_Life_Assessment_Result_Compute(CqlContext context)
    {
        CqlCode? a_ = this.American_Urological_Association_Symptom_Index__AUASI_(context);
        IEnumerable<CqlCode?>? b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation?>? c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));

        bool? d_(Observation? AUASIAssessment) {
            Code<ObservationStatus>? h_ = AUASIAssessment?.StatusElement;
            ObservationStatus? i_ = h_?.Value;
            string? j_ = context.Operators.Convert<string>(i_);
            string?[]? k_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? l_ = context.Operators.In<string>(j_, (IEnumerable<string>)k_);
            DataType? m_ = AUASIAssessment?.Value;
            object? n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
            bool? o_ = context.Operators.Not((bool?)(n_ is null));
            bool? p_ = context.Operators.And(l_, o_);
            return p_;
        }


        (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? e_(Observation? AUASIAssessment) {
            object? q_;
            DataType? ag_ = AUASIAssessment?.Effective;
            object? ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
            bool ai_ = ah_ is CqlDateTime;
            if (ai_)
            {
                DataType? aj_ = AUASIAssessment?.Effective;
                object? ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                q_ = ak_ as CqlDateTime;
            }
            else
            {
                DataType? al_ = AUASIAssessment?.Effective;
                object? am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                bool an_ = am_ is CqlDateTime;
                if (an_)
                {
                    DataType? ao_ = AUASIAssessment?.Effective;
                    object? ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                    q_ = ap_ as CqlDateTime;
                }
                else
                {
                    DataType? aq_ = AUASIAssessment?.Effective;
                    object? ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                    bool as_ = ar_ is CqlInterval<CqlDateTime>;
                    if (as_)
                    {
                        DataType? at_ = AUASIAssessment?.Effective;
                        object? au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                        q_ = au_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        q_ = null;
                    }
                }
            }
            CqlDateTime? r_ = QICoreCommon_4_0_000.Instance.earliest(context, q_);
            DataType? s_ = AUASIAssessment?.Value;
            object? t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
            CqlCode? u_ = this.If_you_were_to_spend_the_rest_of_your_life_with_your_urinary_condition_just_the_way_it_is_now__how_would_you_feel_about_that__IPSS_(context);
            IEnumerable<CqlCode?>? v_ = context.Operators.ToList<CqlCode>(u_);
            IEnumerable<Observation?>? w_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, v_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));

            bool? x_(Observation? QOLAssessment) {
                object? av_;
                DataType? bk_ = QOLAssessment?.Effective;
                object? bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                bool bm_ = bl_ is CqlDateTime;
                if (bm_)
                {
                    DataType? bn_ = QOLAssessment?.Effective;
                    object? bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                    av_ = bo_ as CqlDateTime;
                }
                else
                {
                    DataType? bp_ = QOLAssessment?.Effective;
                    object? bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                    bool br_ = bq_ is CqlDateTime;
                    if (br_)
                    {
                        DataType? bs_ = QOLAssessment?.Effective;
                        object? bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                        av_ = bt_ as CqlDateTime;
                    }
                    else
                    {
                        DataType? bu_ = QOLAssessment?.Effective;
                        object? bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                        bool bw_ = bv_ is CqlInterval<CqlDateTime>;
                        if (bw_)
                        {
                            DataType? bx_ = QOLAssessment?.Effective;
                            object? by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                            av_ = by_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            av_ = null;
                        }
                    }
                }
                CqlDateTime? aw_ = QICoreCommon_4_0_000.Instance.earliest(context, av_);
                object? ax_;
                DataType? bz_ = AUASIAssessment?.Effective;
                object? ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                bool cb_ = ca_ is CqlDateTime;
                if (cb_)
                {
                    DataType? cc_ = AUASIAssessment?.Effective;
                    object? cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                    ax_ = cd_ as CqlDateTime;
                }
                else
                {
                    DataType? ce_ = AUASIAssessment?.Effective;
                    object? cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);
                    bool cg_ = cf_ is CqlDateTime;
                    if (cg_)
                    {
                        DataType? ch_ = AUASIAssessment?.Effective;
                        object? ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                        ax_ = ci_ as CqlDateTime;
                    }
                    else
                    {
                        DataType? cj_ = AUASIAssessment?.Effective;
                        object? ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
                        bool cl_ = ck_ is CqlInterval<CqlDateTime>;
                        if (cl_)
                        {
                            DataType? cm_ = AUASIAssessment?.Effective;
                            object? cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                            ax_ = cn_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            ax_ = null;
                        }
                    }
                }
                CqlDateTime? ay_ = QICoreCommon_4_0_000.Instance.earliest(context, ax_);
                bool? az_ = context.Operators.SameAs(aw_, ay_, "day");
                Code<ObservationStatus>? ba_ = QOLAssessment?.StatusElement;
                ObservationStatus? bb_ = ba_?.Value;
                string? bc_ = context.Operators.Convert<string>(bb_);
                string?[]? bd_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? be_ = context.Operators.In<string>(bc_, (IEnumerable<string>)bd_);
                bool? bf_ = context.Operators.And(az_, be_);
                DataType? bg_ = QOLAssessment?.Value;
                object? bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                bool? bi_ = context.Operators.Not((bool?)(bh_ is null));
                bool? bj_ = context.Operators.And(bf_, bi_);
                return bj_;
            }

            IEnumerable<Observation?>? y_ = context.Operators.Where<Observation>(w_, x_);

            object? z_(Observation? @this) {
                object? co_;
                DataType? cq_ = @this?.Effective;
                object? cr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cq_);
                bool cs_ = cr_ is CqlDateTime;
                if (cs_)
                {
                    DataType? ct_ = @this?.Effective;
                    object? cu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ct_);
                    co_ = cu_ as CqlDateTime;
                }
                else
                {
                    DataType? cv_ = @this?.Effective;
                    object? cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);
                    bool cx_ = cw_ is CqlDateTime;
                    if (cx_)
                    {
                        DataType? cy_ = @this?.Effective;
                        object? cz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cy_);
                        co_ = cz_ as CqlDateTime;
                    }
                    else
                    {
                        DataType? da_ = @this?.Effective;
                        object? db_ = FHIRHelpers_4_4_000.Instance.ToValue(context, da_);
                        bool dc_ = db_ is CqlInterval<CqlDateTime>;
                        if (dc_)
                        {
                            DataType? dd_ = @this?.Effective;
                            object? de_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dd_);
                            co_ = de_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            co_ = null;
                        }
                    }
                }
                CqlDateTime? cp_ = QICoreCommon_4_0_000.Instance.earliest(context, co_);
                return cp_;
            }

            IEnumerable<Observation?>? aa_ = context.Operators.SortBy<Observation>(y_, z_, System.ComponentModel.ListSortDirection.Ascending);
            Observation? ab_ = context.Operators.Last<Observation>(aa_);
            DataType? ac_ = ab_?.Value;
            object? ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
            int? ae_ = context.Operators.Add(t_ as int?, ad_ as int?);
            (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? af_ = (CqlTupleMetadata_GNNDVIQPcTANSdLebhBKYIdga, r_, ae_);
            return af_;
        }

        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>? f_ = context.Operators.WhereSelect<Observation, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(c_, d_, e_);
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>? g_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(f_);
        return g_;
    }


    [CqlExpressionDefinition("Urinary Symptom Score Assessment")]
    public IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>? Urinary_Symptom_Score_Assessment(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Urinary_Symptom_Score_Assessment, Urinary_Symptom_Score_Assessment_Compute);

    private const long _cacheIndex_Urinary_Symptom_Score_Assessment = -6926091951122626887L;

    private IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>? Urinary_Symptom_Score_Assessment_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>? a_ = this.Documented_IPSS_Assessment_Result(context);
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>? b_ = this.AUA_Symptom_Index_and_Quality_of_Life_Assessment_Result(context);
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>? c_ = context.Operators.Union<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Urinary Symptom Score Within 1 Month After Initial BPH Diagnosis")]
    public (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? Urinary_Symptom_Score_Within_1_Month_After_Initial_BPH_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Urinary_Symptom_Score_Within_1_Month_After_Initial_BPH_Diagnosis, Urinary_Symptom_Score_Within_1_Month_After_Initial_BPH_Diagnosis_Compute);

    private const long _cacheIndex_Urinary_Symptom_Score_Within_1_Month_After_Initial_BPH_Diagnosis = -971062803861453571L;

    private (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? Urinary_Symptom_Score_Within_1_Month_After_Initial_BPH_Diagnosis_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>? a_ = this.Urinary_Symptom_Score_Assessment(context);

        bool? b_((CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? USSAssessment) {
            Condition? g_ = this.Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_the_Measurement_Period(context);
            Condition?[]? h_ = [
                g_,
            ];

            bool? i_(Condition? InitialBPHDiagnosis) {
                CqlDateTime? k_ = USSAssessment?.effectiveDatetime;
                CqlInterval<CqlDateTime?>? l_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, InitialBPHDiagnosis);
                CqlDateTime? m_ = context.Operators.Start(l_);
                CqlQuantity? n_ = context.Operators.Quantity(1m, "month");
                CqlDateTime? o_ = context.Operators.Add(m_, n_);
                CqlInterval<CqlDateTime?>? p_ = context.Operators.Interval(m_, o_, true, true);
                bool? q_ = context.Operators.In<CqlDateTime>(k_, p_, "day");
                bool? r_ = context.Operators.Not((bool?)(m_ is null));
                bool? s_ = context.Operators.And(q_, r_);
                return s_;
            }

            bool? j_ = context.Operators.WhereAny<Condition>((IEnumerable<Condition>)h_, i_);
            return j_;
        }

        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>? c_ = context.Operators.Where<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(a_, b_);

        object? d_((CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? @this) {
            CqlDateTime? t_ = @this?.effectiveDatetime;
            return t_;
        }

        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>? e_ = context.Operators.SortBy<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(c_, d_, System.ComponentModel.ListSortDirection.Ascending);
        (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? f_ = context.Operators.First<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(e_);
        return f_;
    }


    [CqlExpressionDefinition("Urinary Symptom Score 6 to 12 Months After Initial BPH Diagnosis")]
    public (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis, Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis_Compute);

    private const long _cacheIndex_Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis = -324457888574945361L;

    private (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>? a_ = this.Urinary_Symptom_Score_Assessment(context);

        bool? b_((CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? USSAssessment) {
            Condition? g_ = this.Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_the_Measurement_Period(context);
            Condition?[]? h_ = [
                g_,
            ];

            bool? i_(Condition? InitialBPHDiagnosis) {
                CqlInterval<CqlDateTime?>? k_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, InitialBPHDiagnosis);
                CqlDateTime? l_ = context.Operators.Start(k_);
                CqlDateTime? m_ = USSAssessment?.effectiveDatetime;
                int? n_ = context.Operators.DifferenceBetween(l_, m_, "month");
                CqlInterval<int?>? o_ = context.Operators.Interval(6, 12, true, true);
                bool? p_ = context.Operators.In<int?>(n_, o_, (string)default);
                return p_;
            }

            bool? j_ = context.Operators.WhereAny<Condition>((IEnumerable<Condition>)h_, i_);
            return j_;
        }

        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>? c_ = context.Operators.Where<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(a_, b_);

        object? d_((CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? @this) {
            CqlDateTime? q_ = @this?.effectiveDatetime;
            return q_;
        }

        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>? e_ = context.Operators.SortBy<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(c_, d_, System.ComponentModel.ListSortDirection.Ascending);
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
    public IEnumerable<Condition?>? Urinary_Retention_Diagnosis_Starts_Within_1_Year_After_Initial_BPH_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Urinary_Retention_Diagnosis_Starts_Within_1_Year_After_Initial_BPH_Diagnosis, Urinary_Retention_Diagnosis_Starts_Within_1_Year_After_Initial_BPH_Diagnosis_Compute);

    private const long _cacheIndex_Urinary_Retention_Diagnosis_Starts_Within_1_Year_After_Initial_BPH_Diagnosis = -1921163594377125910L;

    private IEnumerable<Condition?>? Urinary_Retention_Diagnosis_Starts_Within_1_Year_After_Initial_BPH_Diagnosis_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Urinary_Retention(context);
        IEnumerable<Condition?>? b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition?>? c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition?>? d_ = context.Operators.Union<Condition>(b_ as IEnumerable<Condition>, c_ as IEnumerable<Condition>);

        bool? e_(Condition? UrinaryRetention) {
            Condition? i_ = this.Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_the_Measurement_Period(context);
            Condition?[]? j_ = [
                i_,
            ];

            bool? k_(Condition? InitialBPHDiagnosis) {
                CqlInterval<CqlDateTime?>? m_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, UrinaryRetention);
                CqlDateTime? n_ = context.Operators.Start(m_);
                CqlInterval<CqlDateTime?>? o_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, InitialBPHDiagnosis);
                CqlDateTime? p_ = context.Operators.Start(o_);
                CqlQuantity? q_ = context.Operators.Quantity(1m, "year");
                CqlDateTime? r_ = context.Operators.Add(p_, q_);
                CqlInterval<CqlDateTime?>? s_ = context.Operators.Interval(p_, r_, true, true);
                bool? t_ = context.Operators.In<CqlDateTime>(n_, s_, "day");
                bool? u_ = context.Operators.Not((bool?)(p_ is null));
                bool? v_ = context.Operators.And(t_, u_);
                return v_;
            }

            bool? l_ = context.Operators.WhereAny<Condition>((IEnumerable<Condition>)j_, k_);
            return l_;
        }

        IEnumerable<Condition?>? f_ = context.Operators.Where<Condition>(d_, e_);

        bool? g_(Condition? UrinaryRetention) {
            bool? w_ = this.verificationStatusIsNotInvalid(context, UrinaryRetention);
            return w_;
        }

        IEnumerable<Condition?>? h_ = context.Operators.Where<Condition>(f_, g_);
        return h_;
    }


    [CqlExpressionDefinition("Has Initial BPH Diagnosis Starts During or Within 30 Days After End of Hospitalization")]
    public Condition? Has_Initial_BPH_Diagnosis_Starts_During_or_Within_30_Days_After_End_of_Hospitalization(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Has_Initial_BPH_Diagnosis_Starts_During_or_Within_30_Days_After_End_of_Hospitalization, Has_Initial_BPH_Diagnosis_Starts_During_or_Within_30_Days_After_End_of_Hospitalization_Compute);

    private const long _cacheIndex_Has_Initial_BPH_Diagnosis_Starts_During_or_Within_30_Days_After_End_of_Hospitalization = -6925951689891403297L;

    private Condition? Has_Initial_BPH_Diagnosis_Starts_During_or_Within_30_Days_After_End_of_Hospitalization_Compute(CqlContext context)
    {
        Condition? a_ = this.Initial_BPH_Diagnosis_Starts_Within_6_Months_Before_the_Measurement_Period(context);
        Condition?[]? b_ = [
            a_,
        ];

        bool? c_(Condition? InitialBPHDiagnosis) {
            CqlValueSet? f_ = this.Hospital_Services_for_Urology_Care(context);
            IEnumerable<Encounter?>? g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? h_(Encounter? UrologyHospitalServices) {
                CqlInterval<CqlDateTime?>? j_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, InitialBPHDiagnosis);
                CqlDateTime? k_ = context.Operators.Start(j_);
                Period? l_ = UrologyHospitalServices?.Period;
                CqlInterval<CqlDateTime?>? m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
                CqlDateTime? n_ = context.Operators.Start(m_);
                CqlDateTime? o_ = context.Operators.End(m_);
                CqlQuantity? p_ = context.Operators.Quantity(31m, "days");
                CqlDateTime? q_ = context.Operators.Add(o_, p_);
                CqlInterval<CqlDateTime?>? r_ = context.Operators.Interval(n_, q_, true, true);
                bool? s_ = context.Operators.In<CqlDateTime>(k_, r_, (string)default);
                Code<Encounter.EncounterStatus>? t_ = UrologyHospitalServices?.StatusElement;
                Encounter.EncounterStatus? u_ = t_?.Value;
                Code<Encounter.EncounterStatus>? v_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(u_);
                bool? w_ = context.Operators.Equal(v_, "finished");
                bool? x_ = context.Operators.And(s_, w_);
                return x_;
            }

            bool? i_ = context.Operators.WhereAny<Encounter>(g_, h_);
            return i_;
        }

        IEnumerable<Condition?>? d_ = context.Operators.Where<Condition>((IEnumerable<Condition>)b_, c_);
        Condition? e_ = context.Operators.SingletonFrom<Condition>(d_);
        return e_;
    }


    [CqlExpressionDefinition("Morbid Obesity Diagnosis On or Before Follow Up USS Assessment")]
    public IEnumerable<Condition?>? Morbid_Obesity_Diagnosis_On_or_Before_Follow_Up_USS_Assessment(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Morbid_Obesity_Diagnosis_On_or_Before_Follow_Up_USS_Assessment, Morbid_Obesity_Diagnosis_On_or_Before_Follow_Up_USS_Assessment_Compute);

    private const long _cacheIndex_Morbid_Obesity_Diagnosis_On_or_Before_Follow_Up_USS_Assessment = 8671836689749221414L;

    private IEnumerable<Condition?>? Morbid_Obesity_Diagnosis_On_or_Before_Follow_Up_USS_Assessment_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Morbid_Obesity(context);
        IEnumerable<Condition?>? b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition?>? c_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition?>? d_ = context.Operators.Union<Condition>(b_ as IEnumerable<Condition>, c_ as IEnumerable<Condition>);

        bool? e_(Condition? MorbidObesityDiagnosis) {
            (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? i_ = this.Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis(context);
            (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?[]? j_ = [
                i_,
            ];

            bool? k_((CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment) {
                CqlInterval<CqlDateTime?>? m_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, MorbidObesityDiagnosis);
                CqlInterval<CqlDateTime?>? n_ = this.Measurement_Period(context);
                bool? o_ = context.Operators.Overlaps(m_, n_, (string)default);
                CqlDateTime? p_ = context.Operators.Start(m_);
                CqlDateTime? q_ = FollowUpUSSAssessment?.effectiveDatetime;
                bool? r_ = context.Operators.SameOrBefore(p_, q_, (string)default);
                bool? s_ = context.Operators.And(o_, r_);
                return s_;
            }

            bool? l_ = context.Operators.WhereAny<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>((IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>)j_, k_);
            return l_;
        }

        IEnumerable<Condition?>? f_ = context.Operators.Where<Condition>(d_, e_);

        bool? g_(Condition? MorbidObesityDiagnosis) {
            bool? t_ = this.verificationStatusIsNotInvalid(context, MorbidObesityDiagnosis);
            return t_;
        }

        IEnumerable<Condition?>? h_ = context.Operators.Where<Condition>(f_, g_);
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
        IEnumerable<Observation?>? a_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-bmi"));

        bool? b_(Observation? BMIExam) {
            (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? g_ = this.Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis(context);
            (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?[]? h_ = [
                g_,
            ];

            bool? i_((CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment) {
                DataType? k_ = BMIExam?.Value;
                CqlQuantity? l_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, k_ as Quantity);
                CqlQuantity? m_ = context.Operators.Quantity(40m, "kg/m2");
                bool? n_ = context.Operators.GreaterOrEqual(l_, m_);
                Code<ObservationStatus>? o_ = BMIExam?.StatusElement;
                ObservationStatus? p_ = o_?.Value;
                string? q_ = context.Operators.Convert<string>(p_);
                string?[]? r_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? s_ = context.Operators.In<string>(q_, (IEnumerable<string>)r_);
                bool? t_ = context.Operators.And(n_, s_);
                DataType? u_ = BMIExam?.Effective;
                object? v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                CqlDateTime? w_ = QICoreCommon_4_0_000.Instance.earliest(context, v_);
                CqlInterval<CqlDateTime?>? x_ = this.Measurement_Period(context);
                bool? y_ = context.Operators.In<CqlDateTime>(w_, x_, "day");
                bool? z_ = context.Operators.And(t_, y_);
                CqlDateTime? aa_ = FollowUpUSSAssessment?.effectiveDatetime;
                bool? ab_ = context.Operators.SameOrBefore(w_, aa_, (string)default);
                bool? ac_ = context.Operators.And(z_, ab_);
                return ac_;
            }

            bool? j_ = context.Operators.WhereAny<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>((IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>)h_, i_);
            return j_;
        }


        CqlDateTime? c_(Observation? BMIExam) {
            DataType? ad_ = BMIExam?.Effective;
            object? ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
            CqlDateTime? af_ = QICoreCommon_4_0_000.Instance.earliest(context, ae_);
            return af_;
        }

        IEnumerable<CqlDateTime?>? d_ = context.Operators.WhereSelect<Observation, CqlDateTime>(a_, b_, c_);
        IEnumerable<CqlDateTime?>? e_ = context.Operators.Distinct<CqlDateTime>(d_);
        bool? f_ = context.Operators.Exists<CqlDateTime>(e_);
        return f_;
    }


    [CqlExpressionDefinition("Morbid Obesity Diagnosis or BMI Exam Result Greater Than or Equal to 40 Starts On or Before Follow Up USS Assessment")]
    public bool? Morbid_Obesity_Diagnosis_or_BMI_Exam_Result_Greater_Than_or_Equal_to_40_Starts_On_or_Before_Follow_Up_USS_Assessment(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Morbid_Obesity_Diagnosis_or_BMI_Exam_Result_Greater_Than_or_Equal_to_40_Starts_On_or_Before_Follow_Up_USS_Assessment, Morbid_Obesity_Diagnosis_or_BMI_Exam_Result_Greater_Than_or_Equal_to_40_Starts_On_or_Before_Follow_Up_USS_Assessment_Compute);

    private const long _cacheIndex_Morbid_Obesity_Diagnosis_or_BMI_Exam_Result_Greater_Than_or_Equal_to_40_Starts_On_or_Before_Follow_Up_USS_Assessment = -775102312589408922L;

    private bool? Morbid_Obesity_Diagnosis_or_BMI_Exam_Result_Greater_Than_or_Equal_to_40_Starts_On_or_Before_Follow_Up_USS_Assessment_Compute(CqlContext context)
    {
        IEnumerable<Condition?>? a_ = this.Morbid_Obesity_Diagnosis_On_or_Before_Follow_Up_USS_Assessment(context);
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
        IEnumerable<Condition?>? a_ = this.Urinary_Retention_Diagnosis_Starts_Within_1_Year_After_Initial_BPH_Diagnosis(context);
        bool? b_ = context.Operators.Exists<Condition>(a_);
        Condition? c_ = this.Has_Initial_BPH_Diagnosis_Starts_During_or_Within_30_Days_After_End_of_Hospitalization(context);
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
        (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?[]? b_ = [
            a_,
        ];
        (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? c_ = this.Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis(context);
        (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?[]? d_ = [
            c_,
        ];
        IEnumerable<ValueTuple<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>>? e_ = context.Operators.CrossJoin<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>((IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>)b_, (IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>)d_);

        (CqlTupleMetadata, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FirstUSSAssessment, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment)? f_(ValueTuple<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> _valueTuple) {
            (CqlTupleMetadata, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FirstUSSAssessment, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment)? k_ = (CqlTupleMetadata_FBHNjYWJgMKheadEZUgcdQGXN, _valueTuple.Item1, _valueTuple.Item2);
            return k_;
        }

        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FirstUSSAssessment, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment)?>? g_ = context.Operators.Select<ValueTuple<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>, (CqlTupleMetadata, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FirstUSSAssessment, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment)?>(e_, f_);

        int? h_((CqlTupleMetadata, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FirstUSSAssessment, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment)? tuple_fbhnjywjgmkheadezugcdqgxn) {
            int? l_ = tuple_fbhnjywjgmkheadezugcdqgxn?.FirstUSSAssessment?.valueInteger;
            int? m_ = tuple_fbhnjywjgmkheadezugcdqgxn?.FollowUpUSSAssessment?.valueInteger;
            int? n_ = context.Operators.Subtract(l_, m_);
            return n_;
        }

        IEnumerable<int?>? i_ = context.Operators.SelectDistinct<(CqlTupleMetadata, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FirstUSSAssessment, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment)?, int?>(g_, h_);
        int? j_ = context.Operators.SingletonFrom<int?>(i_);
        return j_;
    }


    [CqlExpressionDefinition("Urinary Symptom Score Improvement Greater Than or Equal To 3")]
    public bool? Urinary_Symptom_Score_Improvement_Greater_Than_or_Equal_To_3(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Urinary_Symptom_Score_Improvement_Greater_Than_or_Equal_To_3, Urinary_Symptom_Score_Improvement_Greater_Than_or_Equal_To_3_Compute);

    private const long _cacheIndex_Urinary_Symptom_Score_Improvement_Greater_Than_or_Equal_To_3 = -4907289622604644412L;

    private bool? Urinary_Symptom_Score_Improvement_Greater_Than_or_Equal_To_3_Compute(CqlContext context)
    {
        int? a_ = this.Urinary_Symptom_Score_Change(context);
        int?[]? b_ = [
            a_,
        ];

        bool? c_(int? USSImprovement) {
            bool? g_ = context.Operators.GreaterOrEqual(USSImprovement, 3);
            return g_;
        }

        IEnumerable<int?>? d_ = context.Operators.Where<int?>((IEnumerable<int?>)b_, c_);
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
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?>? SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = 2525696613965935061L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?>? SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?>? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
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
    public CqlCode? SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = -7551527745134025677L;

    private CqlCode? SDE_Sex_Compute(CqlContext context)
    {
        CqlCode? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
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
