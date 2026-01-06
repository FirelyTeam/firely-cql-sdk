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
[CqlLibrary("CqlBooleanTest", "1.0.000")]
public partial class CqlBooleanTest_1_0_000 : ILibrary, ISingleton<CqlBooleanTest_1_0_000>
{
    #region Functions and Expressions

    private readonly Cached<bool?> _SomethingTrueEqualsTrue_Cached = new();

    [CqlExpressionDefinition("SomethingTrueEqualsTrue")]
    public bool? SomethingTrueEqualsTrue(CqlContext context) =>
        _SomethingTrueEqualsTrue_Cached.GetOrReplace(
            context,
            () => {
                bool? a_ = context.Operators.Equal(1, 1) /* CQL: 3:35-3:39 */;
                bool? b_ = context.Operators.Equal(a_, true);
                return b_;
            });


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private CqlBooleanTest_1_0_000() {}

    public static CqlBooleanTest_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CqlBooleanTest";
    public string Version => "1.0.000";
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
