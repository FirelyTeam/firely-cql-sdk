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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.2.2.0")]
[CqlLibrary("PalliativeCareFHIR", "0.6.000")]
public partial class PalliativeCareFHIR_0_6_000 : ILibrary, ISingleton<PalliativeCareFHIR_0_6_000>
{
    #region ValueSets (2)

    [CqlValueSetDefinition("Palliative Care Encounter", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1090", valueSetVersion: null)]
    public CqlValueSet Palliative_Care_Encounter(CqlContext _) => _Palliative_Care_Encounter;
    private static readonly CqlValueSet _Palliative_Care_Encounter = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1090", null);

    [CqlValueSetDefinition("Palliative Care Intervention", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1135", valueSetVersion: null)]
    public CqlValueSet Palliative_Care_Intervention(CqlContext _) => _Palliative_Care_Intervention;
    private static readonly CqlValueSet _Palliative_Care_Intervention = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1135", null);

    #endregion ValueSets

    #region Codes (2)

    [CqlCodeDefinition("Functional Assessment of Chronic Illness Therapy - Palliative Care Questionnaire (FACIT-Pal)", codeId: "71007-9", codeSystem: "http://loinc.org")]
    public CqlCode Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_(CqlContext _) => _Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_;
    private static readonly CqlCode _Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_ = new CqlCode("71007-9", "http://loinc.org");

    [CqlCodeDefinition("survey", codeId: "survey", codeSystem: "http://terminology.hl7.org/CodeSystem/observation-category")]
    public CqlCode survey(CqlContext _) => _survey;
    private static readonly CqlCode _survey = new CqlCode("survey", "http://terminology.hl7.org/CodeSystem/observation-category");

    #endregion Codes

    #region CodeSystems (2)

    [CqlCodeSystemDefinition("LOINC", codeSystemId: "http://loinc.org", codeSystemVersion: null)]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, [
          _Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_]);

    [CqlCodeSystemDefinition("ObservationCategoryCodes", codeSystemId: "http://terminology.hl7.org/CodeSystem/observation-category", codeSystemVersion: null)]
    public CqlCodeSystem ObservationCategoryCodes(CqlContext _) => _ObservationCategoryCodes;
    private static readonly CqlCodeSystem _ObservationCategoryCodes =
      new CqlCodeSystem("http://terminology.hl7.org/CodeSystem/observation-category", null, [
          _survey]);

    #endregion CodeSystems

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = -7635985198364237165L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        object a_ = context.ResolveParameter("PalliativeCareFHIR-0.6.000", "Measurement Period", (object)null);
        return (CqlInterval<CqlDateTime>)a_;
    }


    #endregion Parameters

    #region Functions and Expressions (2)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = 7402591205230841493L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Palliative Care in the Measurement Period")]
    public bool? Palliative_Care_in_the_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Palliative_Care_in_the_Measurement_Period, Palliative_Care_in_the_Measurement_Period_Compute);

    private const long _cacheIndex_Palliative_Care_in_the_Measurement_Period = -8977964396406550542L;

    private bool? Palliative_Care_in_the_Measurement_Period_Compute(CqlContext context)
    {
        CqlCode a_ = this.Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_(context);
        IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/StructureDefinition/Observation"));

        bool? d_(Observation PalliativeAssessment) {
            Code<ObservationStatus> g_ = PalliativeAssessment?.StatusElement;
            string h_ = FHIRHelpers_4_0_001.Instance.ToString(context, g_);
            string[] i_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? j_ = context.Operators.In<string>(h_, (IEnumerable<string>)i_);
            bool? k_;
            // CQL 'and' (23:21-26:17): right operand skipped when left is false
            if (j_ is false)
            {
                k_ = false;
            }
            else
            {
                List<CodeableConcept> l_ = PalliativeAssessment?.Category;

                bool? m_(CodeableConcept PalliativeAssessmentCategory) {
                    CqlCode o_ = this.survey(context);
                    CqlConcept p_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, PalliativeAssessmentCategory);
                    IReadOnlyList<CqlCode> q_ = p_?.codes;
                    bool? r_ = context.Operators.In<CqlCode>(o_, (IEnumerable<CqlCode>)q_);
                    return r_;
                }

                bool? n_ = context.Operators.WhereAny<CodeableConcept>((IEnumerable<CodeableConcept>)l_, m_);
                k_ = j_ & n_;
            }
            // CQL 'and' (23:15-27:112): right operand skipped when left is false
            if (k_ is false)
            {
                return false;
            }
            else
            {
                DataType s_ = PalliativeAssessment?.Effective;
                CqlInterval<CqlDateTime> t_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, s_);
                CqlInterval<CqlDateTime> u_ = this.Measurement_Period(context);
                bool? v_ = context.Operators.Overlaps(t_, u_, (string)default);
                return k_ & v_;
            }
        }

        bool? e_ = context.Operators.WhereAny<Observation>(c_, d_);
        bool? f_;
        // CQL 'or' (22:3-32:13): right operand skipped when left is true
        if (e_ is true)
        {
            f_ = true;
        }
        else
        {
            CqlValueSet w_ = this.Palliative_Care_Encounter(context);
            IEnumerable<Encounter> x_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, w_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));

            bool? y_(Encounter PalliativeEncounter) {
                Code<Encounter.EncounterStatus> aa_ = PalliativeEncounter?.StatusElement;
                string ab_ = FHIRHelpers_4_0_001.Instance.ToString(context, aa_);
                bool? ac_ = context.Operators.Equal(ab_, "finished");
                // CQL 'and' (30:17-31:110): right operand skipped when left is false
                if (ac_ is false)
                {
                    return false;
                }
                else
                {
                    Period ad_ = PalliativeEncounter?.Period;
                    CqlInterval<CqlDateTime> ae_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ad_);
                    CqlInterval<CqlDateTime> af_ = this.Measurement_Period(context);
                    bool? ag_ = context.Operators.Overlaps(ae_, af_, (string)default);
                    return ac_ & ag_;
                }
            }

            bool? z_ = context.Operators.WhereAny<Encounter>(x_, y_);
            f_ = e_ | z_;
        }
        // CQL 'or' (22:3-36:13): right operand skipped when left is true
        if (f_ is true)
        {
            return true;
        }
        else
        {
            CqlValueSet ah_ = this.Palliative_Care_Intervention(context);
            IEnumerable<Procedure> ai_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, ah_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));

            bool? aj_(Procedure PalliativeIntervention) {
                Code<EventStatus> al_ = PalliativeIntervention?.StatusElement;
                string am_ = FHIRHelpers_4_0_001.Instance.ToString(context, al_);
                string[] an_ = [
                    "completed",
                    "in-progress",
                ];
                bool? ao_ = context.Operators.In<string>(am_, (IEnumerable<string>)an_);
                // CQL 'and' (34:17-35:116): right operand skipped when left is false
                if (ao_ is false)
                {
                    return false;
                }
                else
                {
                    DataType ap_ = PalliativeIntervention?.Performed;
                    CqlInterval<CqlDateTime> aq_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ap_);
                    CqlInterval<CqlDateTime> ar_ = this.Measurement_Period(context);
                    bool? as_ = context.Operators.Overlaps(aq_, ar_, (string)default);
                    return ao_ & as_;
                }
            }

            bool? ak_ = context.Operators.WhereAny<Procedure>(ai_, aj_);
            return f_ | ak_;
        }
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private PalliativeCareFHIR_0_6_000() {}

    public static PalliativeCareFHIR_0_6_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "PalliativeCareFHIR";
    public string Version => "0.6.000";
    public ILibrary[] Dependencies => [MATGlobalCommonFunctionsFHIR4_6_1_000.Instance, FHIRHelpers_4_0_001.Instance];

    #endregion ILibrary Implementation

}
