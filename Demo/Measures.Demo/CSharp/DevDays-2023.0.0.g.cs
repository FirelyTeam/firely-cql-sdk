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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "4.0.0.0")]
[CqlLibrary("DevDays", "2023.0.0")]
public partial class DevDays_2023_0_0 : ILibrary, ISingleton<DevDays_2023_0_0>
{
    #region Codes

    [CqlCodeDefinition("Sucked into jet engine", codeId: "V97.33", codeSystem: "http://hl7.org/fhir/sid/icd-10")]
    public CqlCode Sucked_into_jet_engine(CqlContext _) => _Sucked_into_jet_engine;
    private static readonly CqlCode _Sucked_into_jet_engine = new CqlCode("V97.33", "http://hl7.org/fhir/sid/icd-10");

    [CqlCodeDefinition("Sucked into jet engine, subsequent encounter", codeId: "V97.33XD", codeSystem: "http://hl7.org/fhir/sid/icd-10")]
    public CqlCode Sucked_into_jet_engine__subsequent_encounter(CqlContext _) => _Sucked_into_jet_engine__subsequent_encounter;
    private static readonly CqlCode _Sucked_into_jet_engine__subsequent_encounter = new CqlCode("V97.33XD", "http://hl7.org/fhir/sid/icd-10");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("ICD10", codeSystemId: "http://hl7.org/fhir/sid/icd-10", codeSystemVersion: null)]
    public CqlCodeSystem ICD10(CqlContext _) => _ICD10;
    private static readonly CqlCodeSystem _ICD10 =
      new CqlCodeSystem("http://hl7.org/fhir/sid/icd-10", null, [
          _Sucked_into_jet_engine,
          _Sucked_into_jet_engine__subsequent_encounter]);

    #endregion CodeSystems

    #region Parameters

    private readonly Cached<CqlInterval<CqlDateTime>> _Measurement_Period_Cached = new();

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        _Measurement_Period_Cached.GetOrReplace(
            context,
            () => {
                object a_ = context.ResolveParameter("DevDays-2023.0.0", "Measurement Period", null);
                return (CqlInterval<CqlDateTime>)a_;
            });


    #endregion Parameters

    #region Functions and Expressions

    private readonly Cached<Patient> _Patient_Cached = new();

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        _Patient_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
                Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
                return b_;
            });


    private readonly Cached<IEnumerable<Condition>> _Jet_engine_conditions_Cached = new();

    [CqlExpressionDefinition("Jet engine conditions")]
    public IEnumerable<Condition> Jet_engine_conditions(CqlContext context) =>
        _Jet_engine_conditions_Cached.GetOrReplace(
            context,
            () => {
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
                    bool? l_ = context.Operators.In<CqlDateTime>(j_, k_, default);
                    bool? m_ = context.Operators.And(h_, l_);
                    return m_;
                }

                IEnumerable<Condition> c_ = context.Operators.Where<Condition>(a_, b_);
                return c_;
            });


    private readonly Cached<IEnumerable<Condition>> _Subsequent_encounters_Cached = new();

    [CqlExpressionDefinition("Subsequent encounters")]
    public IEnumerable<Condition> Subsequent_encounters(CqlContext context) =>
        _Subsequent_encounters_Cached.GetOrReplace(
            context,
            () => {
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
                    bool? l_ = context.Operators.In<CqlDateTime>(j_, k_, default);
                    bool? m_ = context.Operators.And(h_, l_);
                    return m_;
                }

                IEnumerable<Condition> c_ = context.Operators.Where<Condition>(a_, b_);
                return c_;
            });


    private readonly Cached<bool?> _Initial_population_Cached = new();

    [CqlExpressionDefinition("Initial population")]
    public bool? Initial_population(CqlContext context) =>
        _Initial_population_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<Condition> a_ = this.Jet_engine_conditions(context);
                bool? b_ = context.Operators.Exists<Condition>(a_);
                return b_;
            });


    private readonly Cached<bool?> _Numerator_Cached = new();

    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context) =>
        _Numerator_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<Condition> a_ = this.Subsequent_encounters(context);
                bool? b_ = context.Operators.Exists<Condition>(a_);
                return b_;
            });


    #endregion Functions and Expressions

    private DevDays_2023_0_0() {}

    public static DevDays_2023_0_0 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "DevDays";
    public string Version => "2023.0.0";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_001.Instance];

    #endregion ILibrary Implementation

    #region Nested Type - Cached<T>

    private struct Cached<T>(long CacheVersion, T CachedValue)
    {
        public T GetOrReplace(ICqlContextInternals cqlContext, Func<T> factory)
        {
            var cqlContextCacheVersion = cqlContext.CacheVersion;
            if (cqlContextCacheVersion is 0)
            {
                // No caching, clear out previous values
                CacheVersion = 0;
                CachedValue = default;
                var value = factory();
                return value;
            }

            if (CacheVersion == cqlContextCacheVersion)
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

}
