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
[CqlLibrary("TestRetrieveInclude", "1.0.1")]
public partial class TestRetrieveInclude_1_0_1 : ILibrary, ISingleton<TestRetrieveInclude_1_0_1>
{
    #region ValueSets

    [CqlValueSetDefinition("Female Administrative Sex", valueSetId: "2.16.840.1.113883.3.560.100.2", valueSetVersion: null)]
    public CqlValueSet Female_Administrative_Sex(CqlContext _) => _Female_Administrative_Sex;
    private static readonly CqlValueSet _Female_Administrative_Sex = new CqlValueSet("2.16.840.1.113883.3.560.100.2", null);

    [CqlValueSetDefinition("Other Female Reproductive Conditions", valueSetId: "2.16.840.1.113883.3.464.1003.111.12.1006", valueSetVersion: null)]
    public CqlValueSet Other_Female_Reproductive_Conditions(CqlContext _) => _Other_Female_Reproductive_Conditions;
    private static readonly CqlValueSet _Other_Female_Reproductive_Conditions = new CqlValueSet("2.16.840.1.113883.3.464.1003.111.12.1006", null);

    [CqlValueSetDefinition("Genital Herpes", valueSetId: "2.16.840.1.113883.3.464.1003.110.12.1049", valueSetVersion: null)]
    public CqlValueSet Genital_Herpes(CqlContext _) => _Genital_Herpes;
    private static readonly CqlValueSet _Genital_Herpes = new CqlValueSet("2.16.840.1.113883.3.464.1003.110.12.1049", null);

    [CqlValueSetDefinition("Genococcal Infections and Venereal Diseases", valueSetId: "2.16.840.1.113883.3.464.1003.112.12.1001", valueSetVersion: null)]
    public CqlValueSet Genococcal_Infections_and_Venereal_Diseases(CqlContext _) => _Genococcal_Infections_and_Venereal_Diseases;
    private static readonly CqlValueSet _Genococcal_Infections_and_Venereal_Diseases = new CqlValueSet("2.16.840.1.113883.3.464.1003.112.12.1001", null);

    [CqlValueSetDefinition("Inflammatory Diseases of Female Reproductive Organs", valueSetId: "2.16.840.1.113883.3.464.1003.112.12.1004", valueSetVersion: null)]
    public CqlValueSet Inflammatory_Diseases_of_Female_Reproductive_Organs(CqlContext _) => _Inflammatory_Diseases_of_Female_Reproductive_Organs;
    private static readonly CqlValueSet _Inflammatory_Diseases_of_Female_Reproductive_Organs = new CqlValueSet("2.16.840.1.113883.3.464.1003.112.12.1004", null);

    [CqlValueSetDefinition("Chlamydia", valueSetId: "2.16.840.1.113883.3.464.1003.112.12.1003", valueSetVersion: null)]
    public CqlValueSet Chlamydia(CqlContext _) => _Chlamydia;
    private static readonly CqlValueSet _Chlamydia = new CqlValueSet("2.16.840.1.113883.3.464.1003.112.12.1003", null);

    #endregion ValueSets

    #region Functions and Expressions

    private readonly Cached<IEnumerable<Observation>> _InDemographic_Cached = new();

    [CqlExpressionDefinition("InDemographic")]
    public IEnumerable<Observation> InDemographic(CqlContext context) =>
        _InDemographic_Cached.GetOrReplace(
            context,
            () => {
                IEnumerable<Observation> a_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Observation")) /* CQL: 12:25-12:39 */;
                return a_;
            });


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private TestRetrieveInclude_1_0_1() {}

    public static TestRetrieveInclude_1_0_1 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "TestRetrieveInclude";
    public string Version => "1.0.1";
    public ILibrary[] Dependencies => [];

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
