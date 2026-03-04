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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.0.0")]
[CqlLibrary("DevDays", "2025.0.0")]
public partial class DevDays_2025_0_0 : ILibrary, ISingleton<DevDays_2025_0_0>
{
    #region Codes (2)

    [CqlCodeDefinition("Sucked into jet engine", codeId: "V97.33", codeSystem: "http://hl7.org/fhir/sid/icd-10")]
    public CqlCode Sucked_into_jet_engine(CqlContext _) => _Sucked_into_jet_engine;
    private static readonly CqlCode _Sucked_into_jet_engine = new CqlCode("V97.33", "http://hl7.org/fhir/sid/icd-10");

    [CqlCodeDefinition("Sucked into jet engine, subsequent encounter", codeId: "V97.33XD", codeSystem: "http://hl7.org/fhir/sid/icd-10")]
    public CqlCode Sucked_into_jet_engine__subsequent_encounter(CqlContext _) => _Sucked_into_jet_engine__subsequent_encounter;
    private static readonly CqlCode _Sucked_into_jet_engine__subsequent_encounter = new CqlCode("V97.33XD", "http://hl7.org/fhir/sid/icd-10");

    #endregion Codes

    #region CodeSystems (1)

    [CqlCodeSystemDefinition("ICD10", codeSystemId: "http://hl7.org/fhir/sid/icd-10", codeSystemVersion: null)]
    public CqlCodeSystem ICD10(CqlContext _) => _ICD10;
    private static readonly CqlCodeSystem _ICD10 =
      new CqlCodeSystem("http://hl7.org/fhir/sid/icd-10", null, [
          _Sucked_into_jet_engine,
          _Sucked_into_jet_engine__subsequent_encounter]);

    #endregion CodeSystems

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private static readonly long _cacheIndex_Measurement_Period = -8862873433198669670L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        object a_ = context.ResolveParameter("DevDays-2025.0.0", "Measurement Period", (object)null);
        return (CqlInterval<CqlDateTime>)a_;
    }


    #endregion Parameters

    #region Functions and Expressions (5)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private static readonly long _cacheIndex_Patient = -8712682712776301148L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Jet engine conditions")]
    public IEnumerable<Condition> Jet_engine_conditions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Jet_engine_conditions, Jet_engine_conditions_Compute);

    private static readonly long _cacheIndex_Jet_engine_conditions = 228823874437901456L;

    private IEnumerable<Condition> Jet_engine_conditions_Compute(CqlContext context)
    {
        IEnumerable<Condition> a_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Condition"));

        bool? b_(Condition c) {
            CodeableConcept d_ = c?.Code;
            List<Coding> e_ = d_?.Coding;

            bool? f_(Coding coding) {
                CqlCode n_ = FHIRHelpers_4_0_001.Instance.ToCode(context, coding);
                CqlCode o_ = this.Sucked_into_jet_engine(context);
                bool? p_ = context.Operators.Equivalent(n_, o_);
                return p_;
            }

            IEnumerable<Coding> g_ = context.Operators.Where<Coding>((IEnumerable<Coding>)e_, f_);
            bool? h_ = context.Operators.Exists<Coding>(g_);
            DataType i_ = c?.Onset;
            CqlDateTime j_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, i_ as FhirDateTime);
            CqlInterval<CqlDateTime> k_ = this.Measurement_Period(context);
            bool? l_ = context.Operators.In<CqlDateTime>(j_, k_, (string)default);
            bool? m_ = context.Operators.And(h_, l_);
            return m_;
        }

        IEnumerable<Condition> c_ = context.Operators.Where<Condition>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Subsequent encounters")]
    public IEnumerable<Condition> Subsequent_encounters(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Subsequent_encounters, Subsequent_encounters_Compute);

    private static readonly long _cacheIndex_Subsequent_encounters = 2496156818049639155L;

    private IEnumerable<Condition> Subsequent_encounters_Compute(CqlContext context)
    {
        IEnumerable<Condition> a_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Condition"));

        bool? b_(Condition c) {
            CodeableConcept d_ = c?.Code;
            List<Coding> e_ = d_?.Coding;

            bool? f_(Coding coding) {
                CqlCode n_ = FHIRHelpers_4_0_001.Instance.ToCode(context, coding);
                CqlCode o_ = this.Sucked_into_jet_engine__subsequent_encounter(context);
                bool? p_ = context.Operators.Equivalent(n_, o_);
                return p_;
            }

            IEnumerable<Coding> g_ = context.Operators.Where<Coding>((IEnumerable<Coding>)e_, f_);
            bool? h_ = context.Operators.Exists<Coding>(g_);
            DataType i_ = c?.Onset;
            CqlDateTime j_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, i_ as FhirDateTime);
            CqlInterval<CqlDateTime> k_ = this.Measurement_Period(context);
            bool? l_ = context.Operators.In<CqlDateTime>(j_, k_, (string)default);
            bool? m_ = context.Operators.And(h_, l_);
            return m_;
        }

        IEnumerable<Condition> c_ = context.Operators.Where<Condition>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Initial population")]
    public bool? Initial_population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_population, Initial_population_Compute);

    private static readonly long _cacheIndex_Initial_population = 5132124437758378855L;

    private bool? Initial_population_Compute(CqlContext context)
    {
        IEnumerable<Condition> a_ = this.Jet_engine_conditions(context);
        bool? b_ = context.Operators.Exists<Condition>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private static readonly long _cacheIndex_Numerator = -3598703308623807004L;

    private bool? Numerator_Compute(CqlContext context)
    {
        IEnumerable<Condition> a_ = this.Subsequent_encounters(context);
        bool? b_ = context.Operators.Exists<Condition>(a_);
        return b_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private DevDays_2025_0_0() {}

    public static DevDays_2025_0_0 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "DevDays";
    public string Version => "2025.0.0";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_001.Instance];

    #endregion ILibrary Implementation

}
