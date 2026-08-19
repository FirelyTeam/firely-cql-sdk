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
            Code<ObservationStatus> p_ = PalliativeAssessment?.StatusElement;
            string q_ = FHIRHelpers_4_0_001.Instance.ToString(context, p_);
            string[] r_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? s_ = context.Operators.In<string>(q_, (IEnumerable<string>)r_);
            List<CodeableConcept> t_ = PalliativeAssessment?.Category;

            bool? u_(CodeableConcept PalliativeAssessmentCategory) {
                CqlCode ac_ = this.survey(context);
                CqlConcept ad_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, PalliativeAssessmentCategory);
                IReadOnlyList<CqlCode> ae_ = ad_?.codes;
                bool? af_ = context.Operators.In<CqlCode>(ac_, (IEnumerable<CqlCode>)ae_);
                return af_;
            }

            bool? v_ = context.Operators.WhereAny<CodeableConcept>((IEnumerable<CodeableConcept>)t_, u_);
            bool? w_ = context.Operators.And(s_, v_);
            DataType x_ = PalliativeAssessment?.Effective;
            CqlInterval<CqlDateTime> y_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, x_);
            CqlInterval<CqlDateTime> z_ = this.Measurement_Period(context);
            bool? aa_ = context.Operators.Overlaps(y_, z_, (string)default);
            bool? ab_ = context.Operators.And(w_, aa_);
            return ab_;
        }

        bool? e_ = context.Operators.WhereAny<Observation>(c_, d_);
        CqlValueSet f_ = this.Palliative_Care_Encounter(context);
        IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));

        bool? h_(Encounter PalliativeEncounter) {
            Code<Encounter.EncounterStatus> ag_ = PalliativeEncounter?.StatusElement;
            string ah_ = FHIRHelpers_4_0_001.Instance.ToString(context, ag_);
            bool? ai_ = context.Operators.Equal(ah_, "finished");
            Period aj_ = PalliativeEncounter?.Period;
            CqlInterval<CqlDateTime> ak_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, aj_);
            CqlInterval<CqlDateTime> al_ = this.Measurement_Period(context);
            bool? am_ = context.Operators.Overlaps(ak_, al_, (string)default);
            bool? an_ = context.Operators.And(ai_, am_);
            return an_;
        }

        bool? i_ = context.Operators.WhereAny<Encounter>(g_, h_);
        bool? j_ = context.Operators.Or(e_, i_);
        CqlValueSet k_ = this.Palliative_Care_Intervention(context);
        IEnumerable<Procedure> l_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, k_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));

        bool? m_(Procedure PalliativeIntervention) {
            Code<EventStatus> ao_ = PalliativeIntervention?.StatusElement;
            string ap_ = FHIRHelpers_4_0_001.Instance.ToString(context, ao_);
            string[] aq_ = [
                "completed",
                "in-progress",
            ];
            bool? ar_ = context.Operators.In<string>(ap_, (IEnumerable<string>)aq_);
            DataType as_ = PalliativeIntervention?.Performed;
            CqlInterval<CqlDateTime> at_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, as_);
            CqlInterval<CqlDateTime> au_ = this.Measurement_Period(context);
            bool? av_ = context.Operators.Overlaps(at_, au_, (string)default);
            bool? aw_ = context.Operators.And(ar_, av_);
            return aw_;
        }

        bool? n_ = context.Operators.WhereAny<Procedure>(l_, m_);
        bool? o_ = context.Operators.Or(j_, n_);
        return o_;
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
