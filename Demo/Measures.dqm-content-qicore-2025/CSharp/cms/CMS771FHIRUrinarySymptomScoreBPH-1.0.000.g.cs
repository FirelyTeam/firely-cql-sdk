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
            CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
            Period f_ = ValidEncounter?.Period;
            CqlInterval<CqlDateTime> g_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, f_);
            bool? h_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(e_, g_, "day");

            bool? i_() {
                Coding k_ = ValidEncounter?.Class;
                CqlCode l_ = FHIRHelpers_4_4_000.Instance.ToCode(context, k_);
                CqlCode m_ = this.@virtual(context);
                bool? n_ = context.Operators.Equivalent(l_, m_);
                return (bool?)((CqlBoolean)!n_);
            }


            bool? j_() {
                Code<Encounter.EncounterStatus> o_ = ValidEncounter?.StatusElement;
                Encounter.EncounterStatus? p_ = o_?.Value;
                Code<Encounter.EncounterStatus> q_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(p_);
                bool? r_ = context.Operators.Equal(q_, "finished");
                return (bool?)((CqlBoolean)r_);
            }

            return (bool?)(/* CQL 'and' (107:7-109:46) */ (/* CQL 'and' (107:13-108:45) */ ((CqlBoolean)h_
                && (CqlBoolean)i_())
                && (CqlBoolean)j_()));
        }

        bool? d_ = context.Operators.WhereAny<Encounter>(b_, c_);
        return d_;
    }


    [CqlFunctionDefinition("verificationStatusIsNotInvalid")]
    public bool? verificationStatusIsNotInvalid(CqlContext context, Condition condition)
    {
        CodeableConcept a_ = condition?.VerificationStatus;
        CqlConcept b_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_);

        bool? c_() {
            CodeableConcept d_ = condition?.VerificationStatus;
            CqlConcept e_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, d_);
            CqlCode f_ = QICoreCommon_4_0_000.Instance.unconfirmed(context);
            CqlConcept g_ = context.Operators.ConvertCodeToConcept(f_);
            bool? h_ = context.Operators.Equivalent(e_, g_);

            bool? i_() {
                CodeableConcept k_ = condition?.VerificationStatus;
                CqlConcept l_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, k_);
                CqlCode m_ = QICoreCommon_4_0_000.Instance.refuted(context);
                CqlConcept n_ = context.Operators.ConvertCodeToConcept(m_);
                bool? o_ = context.Operators.Equivalent(l_, n_);
                return (bool?)((CqlBoolean)o_);
            }


            bool? j_() {
                CodeableConcept p_ = condition?.VerificationStatus;
                CqlConcept q_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, p_);
                CqlCode r_ = QICoreCommon_4_0_000.Instance.entered_in_error(context);
                CqlConcept s_ = context.Operators.ConvertCodeToConcept(r_);
                bool? t_ = context.Operators.Equivalent(q_, s_);
                return (bool?)((CqlBoolean)t_);
            }

            return (bool?)((CqlBoolean)(!((bool?)(/* CQL 'or' (177:12-180:5) */ (/* CQL 'or' (177:14-178:64) */ ((CqlBoolean)h_
                || (CqlBoolean)i_())
                || (CqlBoolean)j_())))));
        }

        return (bool?)(/* CQL 'or' (176:3-180:5) */ ((CqlBoolean)((bool?)(b_ is null))
            || (CqlBoolean)c_()));
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
            return (bool?)(/* CQL 'and' (146:7-147:60) */ ((CqlBoolean)r_
                && (CqlBoolean)(this.verificationStatusIsNotInvalid(context, NewBPHDiagnosis))));
        }

        IEnumerable<Condition> g_ = context.Operators.Where<Condition>(e_, f_);

        object h_(Condition @this) {
            DataType s_ = @this?.Onset;
            object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
            CqlInterval<CqlDateTime> u_ = QICoreCommon_4_0_000.Instance.toInterval(context, t_);
            CqlDateTime v_ = context.Operators.Start(u_);
            return v_;
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
        return !((bool?)(a_ is null));
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = 3181761122815071839L;

    private bool? Initial_Population_Compute(CqlContext context)
    {
        bool? a_ = this.Patient_is_Male(context);
        return (bool?)(/* CQL 'and' (30:3-32:38) */ (/* CQL 'and' (30:3-31:34) */ ((CqlBoolean)a_
            && (CqlBoolean)(this.Has_Qualifying_Encounter(context)))
            && (CqlBoolean)(this.Has_Qualifying_BPH_Diagnosis(context))));
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
            Code<ObservationStatus> h_ = IPSSAssessment?.StatusElement;
            ObservationStatus? i_ = h_?.Value;
            string j_ = context.Operators.Convert<string>(i_);
            string[] k_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? l_ = context.Operators.In<string>(j_, (IEnumerable<string>)k_);

            bool? m_() {
                DataType n_ = IPSSAssessment?.Value;
                object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
                return (bool?)((CqlBoolean)(!((bool?)(o_ is null))));
            }

            return (bool?)(/* CQL 'and' (83:5-84:42) */ ((CqlBoolean)l_
                && (CqlBoolean)m_()));
        }


        (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? e_(Observation IPSSAssessment) {
            object p_;
            DataType u_ = IPSSAssessment?.Effective;
            object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
            bool w_ = v_ is CqlDateTime;
            if (w_)
            {
                p_ = v_ as CqlDateTime;
            }
            else
            {
                if (w_)
                {
                    p_ = v_ as CqlDateTime;
                }
                else
                {
                    bool x_ = v_ is CqlInterval<CqlDateTime>;
                    if (x_)
                    {
                        p_ = v_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        p_ = null;
                    }
                }
            }
            CqlDateTime q_ = QICoreCommon_4_0_000.Instance.earliest(context, p_);
            DataType r_ = IPSSAssessment?.Value;
            object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
            (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? t_ = (CqlTupleMetadata_GNNDVIQPcTANSdLebhBKYIdga, q_, s_ as int?);
            return t_;
        }

        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> f_ = context.Operators.WhereSelect<Observation, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(c_, d_, e_);
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> g_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(f_);
        return g_;
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
            Code<ObservationStatus> h_ = AUASIAssessment?.StatusElement;
            ObservationStatus? i_ = h_?.Value;
            string j_ = context.Operators.Convert<string>(i_);
            string[] k_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? l_ = context.Operators.In<string>(j_, (IEnumerable<string>)k_);

            bool? m_() {
                DataType n_ = AUASIAssessment?.Value;
                object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
                return (bool?)((CqlBoolean)(!((bool?)(o_ is null))));
            }

            return (bool?)(/* CQL 'and' (98:5-99:43) */ ((CqlBoolean)l_
                && (CqlBoolean)m_()));
        }


        (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? e_(Observation AUASIAssessment) {
            object p_;
            DataType af_ = AUASIAssessment?.Effective;
            object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
            bool ah_ = ag_ is CqlDateTime;
            if (ah_)
            {
                p_ = ag_ as CqlDateTime;
            }
            else
            {
                if (ah_)
                {
                    p_ = ag_ as CqlDateTime;
                }
                else
                {
                    bool ai_ = ag_ is CqlInterval<CqlDateTime>;
                    if (ai_)
                    {
                        p_ = ag_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        p_ = null;
                    }
                }
            }
            CqlDateTime q_ = QICoreCommon_4_0_000.Instance.earliest(context, p_);
            DataType r_ = AUASIAssessment?.Value;
            object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
            CqlCode t_ = this.If_you_were_to_spend_the_rest_of_your_life_with_your_urinary_condition_just_the_way_it_is_now__how_would_you_feel_about_that__IPSS_(context);
            IEnumerable<CqlCode> u_ = context.Operators.ToList<CqlCode>(t_);
            IEnumerable<Observation> v_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, u_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));

            bool? w_(Observation QOLAssessment) {
                object aj_;
                DataType aq_ = QOLAssessment?.Effective;
                object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                bool as_ = ar_ is CqlDateTime;
                if (as_)
                {
                    aj_ = ar_ as CqlDateTime;
                }
                else
                {
                    if (as_)
                    {
                        aj_ = ar_ as CqlDateTime;
                    }
                    else
                    {
                        bool at_ = ar_ is CqlInterval<CqlDateTime>;
                        if (at_)
                        {
                            aj_ = ar_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            aj_ = null;
                        }
                    }
                }
                CqlDateTime ak_ = QICoreCommon_4_0_000.Instance.earliest(context, aj_);
                object al_;
                DataType au_ = AUASIAssessment?.Effective;
                object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                bool aw_ = av_ is CqlDateTime;
                if (aw_)
                {
                    al_ = av_ as CqlDateTime;
                }
                else
                {
                    if (aw_)
                    {
                        al_ = av_ as CqlDateTime;
                    }
                    else
                    {
                        bool ax_ = av_ is CqlInterval<CqlDateTime>;
                        if (ax_)
                        {
                            al_ = av_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            al_ = null;
                        }
                    }
                }
                CqlDateTime am_ = QICoreCommon_4_0_000.Instance.earliest(context, al_);
                bool? an_ = context.Operators.SameAs(ak_, am_, "day");

                bool? ao_() {
                    Code<ObservationStatus> ay_ = QOLAssessment?.StatusElement;
                    ObservationStatus? az_ = ay_?.Value;
                    string ba_ = context.Operators.Convert<string>(az_);
                    string[] bb_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? bc_ = context.Operators.In<string>(ba_, (IEnumerable<string>)bb_);
                    return (bool?)((CqlBoolean)bc_);
                }


                bool? ap_() {
                    DataType bd_ = QOLAssessment?.Value;
                    object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                    return (bool?)((CqlBoolean)(!((bool?)(be_ is null))));
                }

                return (bool?)(/* CQL 'and' (93:9-95:45) */ (/* CQL 'and' (93:15-94:73) */ ((CqlBoolean)an_
                    && (CqlBoolean)ao_())
                    && (CqlBoolean)ap_()));
            }

            IEnumerable<Observation> x_ = context.Operators.Where<Observation>(v_, w_);

            object y_(Observation @this) {
                object bf_;
                DataType bh_ = @this?.Effective;
                object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                bool bj_ = bi_ is CqlDateTime;
                if (bj_)
                {
                    bf_ = bi_ as CqlDateTime;
                }
                else
                {
                    if (bj_)
                    {
                        bf_ = bi_ as CqlDateTime;
                    }
                    else
                    {
                        bool bk_ = bi_ is CqlInterval<CqlDateTime>;
                        if (bk_)
                        {
                            bf_ = bi_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bf_ = null;
                        }
                    }
                }
                CqlDateTime bg_ = QICoreCommon_4_0_000.Instance.earliest(context, bf_);
                return bg_;
            }

            IEnumerable<Observation> z_ = context.Operators.SortBy<Observation>(x_, y_, System.ComponentModel.ListSortDirection.Ascending);
            Observation aa_ = context.Operators.Last<Observation>(z_);
            DataType ab_ = aa_?.Value;
            object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
            int? ad_ = context.Operators.Add(s_ as int?, ac_ as int?);
            (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? ae_ = (CqlTupleMetadata_GNNDVIQPcTANSdLebhBKYIdga, q_, ad_);
            return ae_;
        }

        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> f_ = context.Operators.WhereSelect<Observation, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(c_, d_, e_);
        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> g_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(f_);
        return g_;
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
                CqlDateTime k_ = USSAssessment?.effectiveDatetime;
                CqlInterval<CqlDateTime> l_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, InitialBPHDiagnosis);
                CqlDateTime m_ = context.Operators.Start(l_);
                CqlQuantity n_ = context.Operators.Quantity(1m, "month");
                CqlDateTime o_ = context.Operators.Add(m_, n_);
                CqlInterval<CqlDateTime> p_ = context.Operators.Interval(m_, o_, true, true);
                bool? q_ = context.Operators.In<CqlDateTime>(k_, p_, "day");

                bool? r_() {
                    CqlInterval<CqlDateTime> s_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, InitialBPHDiagnosis);
                    CqlDateTime t_ = context.Operators.Start(s_);
                    return (bool?)((CqlBoolean)(!((bool?)(t_ is null))));
                }

                return (bool?)(/* CQL 'and' (133:19-133:134) */ ((CqlBoolean)q_
                    && (CqlBoolean)r_()));
            }

            bool? j_ = context.Operators.WhereAny<Condition>((IEnumerable<Condition>)h_, i_);
            return j_;
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
                CqlInterval<CqlDateTime> k_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, InitialBPHDiagnosis);
                CqlDateTime l_ = context.Operators.Start(k_);
                CqlDateTime m_ = USSAssessment?.effectiveDatetime;
                int? n_ = context.Operators.DifferenceBetween(l_, m_, "month");
                CqlInterval<int?> o_ = context.Operators.Interval(6, 12, true, true);
                bool? p_ = context.Operators.In<int?>(n_, o_, (string)default);
                return p_;
            }

            bool? j_ = context.Operators.WhereAny<Condition>((IEnumerable<Condition>)h_, i_);
            return j_;
        }

        IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?> c_ = context.Operators.Where<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>(a_, b_);

        object d_((CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? @this) {
            CqlDateTime q_ = @this?.effectiveDatetime;
            return q_;
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
        return (bool?)(/* CQL 'and' (35:3-37:86) */ (/* CQL 'and' (35:3-36:86) */ ((CqlBoolean)a_
            && (CqlBoolean)(!((bool?)((this.Urinary_Symptom_Score_Within_1_Month_After_Initial_BPH_Diagnosis(context)) is null))))
            && (CqlBoolean)(!((bool?)((this.Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis(context)) is null)))));
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
                CqlInterval<CqlDateTime> m_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, UrinaryRetention);
                CqlDateTime n_ = context.Operators.Start(m_);
                CqlInterval<CqlDateTime> o_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, InitialBPHDiagnosis);
                CqlDateTime p_ = context.Operators.Start(o_);
                CqlQuantity q_ = context.Operators.Quantity(1m, "year");
                CqlDateTime r_ = context.Operators.Add(p_, q_);
                CqlInterval<CqlDateTime> s_ = context.Operators.Interval(p_, r_, true, true);
                bool? t_ = context.Operators.In<CqlDateTime>(n_, s_, "day");

                bool? u_() {
                    CqlInterval<CqlDateTime> v_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, InitialBPHDiagnosis);
                    CqlDateTime w_ = context.Operators.Start(v_);
                    return (bool?)((CqlBoolean)(!((bool?)(w_ is null))));
                }

                return (bool?)(/* CQL 'and' (120:17-120:148) */ ((CqlBoolean)t_
                    && (CqlBoolean)u_()));
            }

            bool? l_ = context.Operators.WhereAny<Condition>((IEnumerable<Condition>)j_, k_);
            return l_;
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
                CqlInterval<CqlDateTime> j_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, InitialBPHDiagnosis);
                CqlDateTime k_ = context.Operators.Start(j_);
                Period l_ = UrologyHospitalServices?.Period;
                CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
                CqlDateTime n_ = context.Operators.Start(m_);
                CqlDateTime o_ = context.Operators.End(m_);
                CqlQuantity p_ = context.Operators.Quantity(31m, "days");
                CqlDateTime q_ = context.Operators.Add(o_, p_);
                CqlInterval<CqlDateTime> r_ = context.Operators.Interval(n_, q_, true, true);
                bool? s_ = context.Operators.In<CqlDateTime>(k_, r_, (string)default);

                bool? t_() {
                    Code<Encounter.EncounterStatus> u_ = UrologyHospitalServices?.StatusElement;
                    Encounter.EncounterStatus? v_ = u_?.Value;
                    Code<Encounter.EncounterStatus> w_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(v_);
                    bool? x_ = context.Operators.Equal(w_, "finished");
                    return (bool?)((CqlBoolean)x_);
                }

                return (bool?)(/* CQL 'and' (140:17-141:55) */ ((CqlBoolean)s_
                    && (CqlBoolean)t_()));
            }

            bool? i_ = context.Operators.WhereAny<Encounter>(g_, h_);
            return i_;
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
                CqlInterval<CqlDateTime> m_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, MorbidObesityDiagnosis);
                CqlInterval<CqlDateTime> n_ = this.Measurement_Period(context);
                bool? o_ = context.Operators.Overlaps(m_, n_, (string)default);

                bool? p_() {
                    CqlInterval<CqlDateTime> q_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, MorbidObesityDiagnosis);
                    CqlDateTime r_ = context.Operators.Start(q_);
                    CqlDateTime s_ = FollowUpUSSAssessment?.effectiveDatetime;
                    bool? t_ = context.Operators.SameOrBefore(r_, s_, (string)default);
                    return (bool?)((CqlBoolean)t_);
                }

                return (bool?)(/* CQL 'and' (155:17-156:117) */ ((CqlBoolean)o_
                    && (CqlBoolean)p_()));
            }

            bool? l_ = context.Operators.WhereAny<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>((IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>)j_, k_);
            return l_;
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
            (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? g_ = this.Urinary_Symptom_Score_6_to_12_Months_After_Initial_BPH_Diagnosis(context);
            (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?[] h_ = [
                g_,
            ];

            bool? i_((CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment) {
                DataType k_ = BMIExam?.Value;
                CqlQuantity l_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, k_ as Quantity);
                CqlQuantity m_ = context.Operators.Quantity(40m, "kg/m2");
                bool? n_ = context.Operators.GreaterOrEqual(l_, m_);

                bool? o_() {
                    Code<ObservationStatus> r_ = BMIExam?.StatusElement;
                    ObservationStatus? s_ = r_?.Value;
                    string t_ = context.Operators.Convert<string>(s_);
                    string[] u_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? v_ = context.Operators.In<string>(t_, (IEnumerable<string>)u_);
                    return (bool?)((CqlBoolean)v_);
                }


                bool? p_() {
                    DataType w_ = BMIExam?.Effective;
                    object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                    CqlDateTime y_ = QICoreCommon_4_0_000.Instance.earliest(context, x_);
                    CqlInterval<CqlDateTime> z_ = this.Measurement_Period(context);
                    bool? aa_ = context.Operators.In<CqlDateTime>(y_, z_, "day");
                    return (bool?)((CqlBoolean)aa_);
                }


                bool? q_() {
                    DataType ab_ = BMIExam?.Effective;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    CqlDateTime ad_ = QICoreCommon_4_0_000.Instance.earliest(context, ac_);
                    CqlDateTime ae_ = FollowUpUSSAssessment?.effectiveDatetime;
                    bool? af_ = context.Operators.SameOrBefore(ad_, ae_, (string)default);
                    return (bool?)((CqlBoolean)af_);
                }

                return (bool?)(/* CQL 'and' (168:19-171:97) */ (/* CQL 'and' (168:19-170:79) */ (/* CQL 'and' (168:19-169:67) */ ((CqlBoolean)n_
                    && (CqlBoolean)o_())
                    && (CqlBoolean)p_())
                    && (CqlBoolean)q_()));
            }

            bool? j_ = context.Operators.WhereAny<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>((IEnumerable<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>)h_, i_);
            return j_;
        }


        CqlDateTime c_(Observation BMIExam) {
            DataType ag_ = BMIExam?.Effective;
            object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
            CqlDateTime ai_ = QICoreCommon_4_0_000.Instance.earliest(context, ah_);
            return ai_;
        }

        IEnumerable<CqlDateTime> d_ = context.Operators.WhereSelect<Observation, CqlDateTime>(a_, b_, c_);
        IEnumerable<CqlDateTime> e_ = context.Operators.Distinct<CqlDateTime>(d_);
        bool? f_ = context.Operators.Exists<CqlDateTime>(e_);
        return f_;
    }


    [CqlExpressionDefinition("Morbid Obesity Diagnosis or BMI Exam Result Greater Than or Equal to 40 Starts On or Before Follow Up USS Assessment")]
    public bool? Morbid_Obesity_Diagnosis_or_BMI_Exam_Result_Greater_Than_or_Equal_to_40_Starts_On_or_Before_Follow_Up_USS_Assessment(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Morbid_Obesity_Diagnosis_or_BMI_Exam_Result_Greater_Than_or_Equal_to_40_Starts_On_or_Before_Follow_Up_USS_Assessment, Morbid_Obesity_Diagnosis_or_BMI_Exam_Result_Greater_Than_or_Equal_to_40_Starts_On_or_Before_Follow_Up_USS_Assessment_Compute);

    private const long _cacheIndex_Morbid_Obesity_Diagnosis_or_BMI_Exam_Result_Greater_Than_or_Equal_to_40_Starts_On_or_Before_Follow_Up_USS_Assessment = -775102312589408922L;

    private bool? Morbid_Obesity_Diagnosis_or_BMI_Exam_Result_Greater_Than_or_Equal_to_40_Starts_On_or_Before_Follow_Up_USS_Assessment_Compute(CqlContext context)
    {
        IEnumerable<Condition> a_ = this.Morbid_Obesity_Diagnosis_On_or_Before_Follow_Up_USS_Assessment(context);
        bool? b_ = context.Operators.Exists<Condition>(a_);
        return (bool?)(/* CQL 'or' (113:3-114:120) */ ((CqlBoolean)b_
            || (CqlBoolean)(this.BMI_Exam_Result_Greater_Than_or_Equal_To_40_During_Measurement_Period_and_On_or_Before_Follow_Up_USS_Assessment(context))));
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public bool? Denominator_Exclusions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exclusions, Denominator_Exclusions_Compute);

    private const long _cacheIndex_Denominator_Exclusions = 6226559503250220937L;

    private bool? Denominator_Exclusions_Compute(CqlContext context)
    {
        IEnumerable<Condition> a_ = this.Urinary_Retention_Diagnosis_Starts_Within_1_Year_After_Initial_BPH_Diagnosis(context);
        bool? b_ = context.Operators.Exists<Condition>(a_);
        return (bool?)(/* CQL 'or' (40:3-42:129) */ (/* CQL 'or' (40:3-41:111) */ ((CqlBoolean)b_
            || (CqlBoolean)(!((bool?)((this.Has_Initial_BPH_Diagnosis_Starts_During_or_Within_30_Days_After_End_of_Hospitalization(context)) is null))))
            || (CqlBoolean)(this.Morbid_Obesity_Diagnosis_or_BMI_Exam_Result_Greater_Than_or_Equal_to_40_Starts_On_or_Before_Follow_Up_USS_Assessment(context))));
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
            (CqlTupleMetadata, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FirstUSSAssessment, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment)? k_ = (CqlTupleMetadata_FBHNjYWJgMKheadEZUgcdQGXN, _valueTuple.Item1, _valueTuple.Item2);
            return k_;
        }

        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FirstUSSAssessment, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment)?> g_ = context.Operators.Select<ValueTuple<(CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)?>, (CqlTupleMetadata, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FirstUSSAssessment, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment)?>(e_, f_);

        int? h_((CqlTupleMetadata, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FirstUSSAssessment, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment)? tuple_fbhnjywjgmkheadezugcdqgxn) {
            int? l_ = tuple_fbhnjywjgmkheadezugcdqgxn?.FirstUSSAssessment?.valueInteger;
            int? m_ = tuple_fbhnjywjgmkheadezugcdqgxn?.FollowUpUSSAssessment?.valueInteger;
            int? n_ = context.Operators.Subtract(l_, m_);
            return n_;
        }

        IEnumerable<int?> i_ = context.Operators.SelectDistinct<(CqlTupleMetadata, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FirstUSSAssessment, (CqlTupleMetadata, CqlDateTime effectiveDatetime, int? valueInteger)? FollowUpUSSAssessment)?, int?>(g_, h_);
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
        int?[] b_ = [
            a_,
        ];

        bool? c_(int? USSImprovement) {
            bool? f_ = context.Operators.GreaterOrEqual(USSImprovement, 3);
            return f_;
        }

        IEnumerable<int?> d_ = context.Operators.Where<int?>((IEnumerable<int?>)b_, c_);
        int? e_ = context.Operators.SingletonFrom<int?>(d_);
        return !((bool?)(e_ is null));
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
