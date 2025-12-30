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
[CqlLibrary("MeasureExample", "0.0.1")]
public partial class MeasureExample_0_0_1 : ILibrary, ISingleton<MeasureExample_0_0_1>
{
    private MeasureExample_0_0_1() {}

    public static MeasureExample_0_0_1 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "MeasureExample";
    public string Version => "0.0.1";
    public ILibrary[] Dependencies => [];

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

    #region Functions and Expressions

    private Cached<Patient> _Patient_Cached = new();

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        _Patient_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
                Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
                return b_;
            });


    private Cached<bool?> _Initial_population_Cached = new();

    [CqlExpressionDefinition("Initial population")]
    [CqlTag("measure", "Measure Resource Example")]
    [CqlTag("year", "2024")]
    [CqlTag("domain", "Testing Measures")]
    [CqlTag("group", "1")]
    [CqlTag("group", "2")]
    [CqlTag("population", "initial-population")]
    [CqlTag("description", "Patients in the IP")]
    public bool? Initial_population(CqlContext context) =>
        _Initial_population_Cached.GetOrReplace(
            context,
            () => true);


    private Cached<bool?> _Exclusion_Cached = new();

    [CqlExpressionDefinition("Exclusion")]
    [CqlTag("group", "1")]
    [CqlTag("group", "2")]
    [CqlTag("population", "denominator-exclusion")]
    public bool? Exclusion(CqlContext context) =>
        _Exclusion_Cached.GetOrReplace(
            context,
            () => false);


    private Cached<bool?> _Denominator_Cached = new();

    [CqlExpressionDefinition("Denominator")]
    [CqlTag("group", "1")]
    [CqlTag("group", "2")]
    [CqlTag("population", "denominator")]
    public bool? Denominator(CqlContext context) =>
        _Denominator_Cached.GetOrReplace(
            context,
            () => {
                bool? a_ = this.Initial_population(context);
                bool? b_ = this.Exclusion(context);
                bool? c_ = context.Operators.Not(b_);
                bool? d_ = context.Operators.And(a_, c_);
                return d_;
            });


    private Cached<bool?> _Numerator_1_Cached = new();

    [CqlExpressionDefinition("Numerator 1")]
    [CqlTag("group", "1")]
    [CqlTag("population", "numerator")]
    public bool? Numerator_1(CqlContext context) =>
        _Numerator_1_Cached.GetOrReplace(
            context,
            () => true);


    private Cached<bool?> _Numerator_2_Cached = new();

    [CqlExpressionDefinition("Numerator 2")]
    [CqlTag("group", "2")]
    [CqlTag("population", "numerator")]
    public bool? Numerator_2(CqlContext context) =>
        _Numerator_2_Cached.GetOrReplace(
            context,
            () => false);


    #endregion Functions and Expressions

}
