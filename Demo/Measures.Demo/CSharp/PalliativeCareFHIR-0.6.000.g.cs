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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.1.0")]
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
            Code<ObservationStatus> s_ = PalliativeAssessment?.StatusElement;
            string t_ = FHIRHelpers_4_0_001.Instance.ToString(context, s_);
            string[] u_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? v_ = context.Operators.In<string>(t_, (IEnumerable<string>)u_);
            List<CodeableConcept> w_ = PalliativeAssessment?.Category;

            bool? x_(CodeableConcept PalliativeAssessmentCategory) {
                CqlCode ag_ = this.survey(context);
                CqlConcept ah_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, PalliativeAssessmentCategory);
                IReadOnlyList<CqlCode> ai_ = ah_?.codes;
                bool? aj_ = context.Operators.In<CqlCode>(ag_, (IEnumerable<CqlCode>)ai_);
                return aj_;
            }

            IEnumerable<CodeableConcept> y_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)w_, x_);
            bool? z_ = context.Operators.Exists<CodeableConcept>(y_);
            bool? aa_ = context.Operators.And(v_, z_);
            DataType ab_ = PalliativeAssessment?.Effective;
            CqlInterval<CqlDateTime> ac_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ab_);
            CqlInterval<CqlDateTime> ad_ = this.Measurement_Period(context);
            bool? ae_ = context.Operators.Overlaps(ac_, ad_, (string)default);
            bool? af_ = context.Operators.And(aa_, ae_);
            return af_;
        }

        IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
        bool? f_ = context.Operators.Exists<Observation>(e_);
        CqlValueSet g_ = this.Palliative_Care_Encounter(context);
        IEnumerable<Encounter> h_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));

        bool? i_(Encounter PalliativeEncounter) {
            Code<Encounter.EncounterStatus> ak_ = PalliativeEncounter?.StatusElement;
            string al_ = FHIRHelpers_4_0_001.Instance.ToString(context, ak_);
            bool? am_ = context.Operators.Equal(al_, "finished");
            Period an_ = PalliativeEncounter?.Period;
            CqlInterval<CqlDateTime> ao_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, an_ as object);
            CqlInterval<CqlDateTime> ap_ = this.Measurement_Period(context);
            bool? aq_ = context.Operators.Overlaps(ao_, ap_, (string)default);
            bool? ar_ = context.Operators.And(am_, aq_);
            return ar_;
        }

        IEnumerable<Encounter> j_ = context.Operators.Where<Encounter>(h_, i_);
        bool? k_ = context.Operators.Exists<Encounter>(j_);
        bool? l_ = context.Operators.Or(f_, k_);
        CqlValueSet m_ = this.Palliative_Care_Intervention(context);
        IEnumerable<Procedure> n_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, m_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));

        bool? o_(Procedure PalliativeIntervention) {
            Code<EventStatus> as_ = PalliativeIntervention?.StatusElement;
            string at_ = FHIRHelpers_4_0_001.Instance.ToString(context, as_);
            string[] au_ = [
                "completed",
                "in-progress",
            ];
            bool? av_ = context.Operators.In<string>(at_, (IEnumerable<string>)au_);
            DataType aw_ = PalliativeIntervention?.Performed;
            CqlInterval<CqlDateTime> ax_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, aw_);
            CqlInterval<CqlDateTime> ay_ = this.Measurement_Period(context);
            bool? az_ = context.Operators.Overlaps(ax_, ay_, (string)default);
            bool? ba_ = context.Operators.And(av_, az_);
            return ba_;
        }

        IEnumerable<Procedure> p_ = context.Operators.Where<Procedure>(n_, o_);
        bool? q_ = context.Operators.Exists<Procedure>(p_);
        bool? r_ = context.Operators.Or(l_, q_);
        return r_;
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
