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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.5.0")]
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
            Code<ObservationStatus> h_ = PalliativeAssessment?.StatusElement;
            string i_ = FHIRHelpers_4_0_001.Instance.ToString(context, h_);
            string[] j_ = [
                "final",
                "amended",
                "corrected",
            ];
            CqlBoolean k_ = context.Operators.In<string>(i_, (IEnumerable<string>)j_);

            CqlBoolean l_() {
                List<CodeableConcept> n_ = PalliativeAssessment?.Category;

                bool? o_(CodeableConcept PalliativeAssessmentCategory) {
                    CqlCode q_ = this.survey(context);
                    CqlConcept r_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, PalliativeAssessmentCategory);
                    IReadOnlyList<CqlCode> s_ = r_?.codes;
                    CqlBoolean t_ = context.Operators.In<CqlCode>(q_, (IEnumerable<CqlCode>)s_);
                    return t_;
                }

                CqlBoolean p_ = context.Operators.WhereAny<CodeableConcept>((IEnumerable<CodeableConcept>)n_, o_);
                return p_;
            }


            CqlBoolean m_() {
                DataType u_ = PalliativeAssessment?.Effective;
                CqlInterval<CqlDateTime> v_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, u_);
                CqlInterval<CqlDateTime> w_ = this.Measurement_Period(context);
                CqlBoolean x_ = context.Operators.Overlaps(v_, w_, (string)default);
                return x_;
            }

            return k_
                /* CQL 'and' (23:21-26:17) */ && l_()
                /* CQL 'and' (23:15-27:112) */ && m_();
        }

        CqlBoolean e_ = context.Operators.WhereAny<Observation>(c_, d_);

        CqlBoolean f_() {
            CqlValueSet y_ = this.Palliative_Care_Encounter(context);
            IEnumerable<Encounter> z_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, y_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));

            bool? aa_(Encounter PalliativeEncounter) {
                Code<Encounter.EncounterStatus> ac_ = PalliativeEncounter?.StatusElement;
                string ad_ = FHIRHelpers_4_0_001.Instance.ToString(context, ac_);
                CqlBoolean ae_ = context.Operators.Equal(ad_, "finished");

                CqlBoolean af_() {
                    Period ag_ = PalliativeEncounter?.Period;
                    CqlInterval<CqlDateTime> ah_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ag_);
                    CqlInterval<CqlDateTime> ai_ = this.Measurement_Period(context);
                    CqlBoolean aj_ = context.Operators.Overlaps(ah_, ai_, (string)default);
                    return aj_;
                }

                return ae_
                    /* CQL 'and' (30:17-31:110) */ && af_();
            }

            CqlBoolean ab_ = context.Operators.WhereAny<Encounter>(z_, aa_);
            return ab_;
        }


        CqlBoolean g_() {
            CqlValueSet ak_ = this.Palliative_Care_Intervention(context);
            IEnumerable<Procedure> al_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, ak_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));

            bool? am_(Procedure PalliativeIntervention) {
                Code<EventStatus> ao_ = PalliativeIntervention?.StatusElement;
                string ap_ = FHIRHelpers_4_0_001.Instance.ToString(context, ao_);
                string[] aq_ = [
                    "completed",
                    "in-progress",
                ];
                CqlBoolean ar_ = context.Operators.In<string>(ap_, (IEnumerable<string>)aq_);

                CqlBoolean as_() {
                    DataType at_ = PalliativeIntervention?.Performed;
                    CqlInterval<CqlDateTime> au_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, at_);
                    CqlInterval<CqlDateTime> av_ = this.Measurement_Period(context);
                    CqlBoolean aw_ = context.Operators.Overlaps(au_, av_, (string)default);
                    return aw_;
                }

                return ar_
                    /* CQL 'and' (34:17-35:116) */ && as_();
            }

            CqlBoolean an_ = context.Operators.WhereAny<Procedure>(al_, am_);
            return an_;
        }

        return e_
            /* CQL 'or' (22:3-32:13) */ || f_()
            /* CQL 'or' (22:3-36:13) */ || g_();
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
