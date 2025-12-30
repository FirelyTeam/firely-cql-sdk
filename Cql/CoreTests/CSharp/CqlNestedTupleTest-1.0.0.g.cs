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
[CqlLibrary("CqlNestedTupleTest", "1.0.0")]
public partial class CqlNestedTupleTest_1_0_0 : ILibrary, ISingleton<CqlNestedTupleTest_1_0_0>
{
    private CqlNestedTupleTest_1_0_0() {}

    public static CqlNestedTupleTest_1_0_0 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "CqlNestedTupleTest";
    public string Version => "1.0.0";
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

    private Cached<(CqlTupleMetadata, string status, (CqlTupleMetadata, string result1, string result2)? result)?> _Result_Cached = new();

    [CqlExpressionDefinition("Result")]
    public (CqlTupleMetadata, string status, (CqlTupleMetadata, string result1, string result2)? result)? Result(CqlContext context) =>
        _Result_Cached.GetOrReplace(
            context,
            () =>
            {
                (CqlTupleMetadata, string result1, string result2)? a_ = (CqlTupleMetadata_EPSaUMIUKUKJWbFHLJZKCNGEJ, "some first result", "some second result");
                (CqlTupleMetadata, string status, (CqlTupleMetadata, string result1, string result2)? result)? b_ = (CqlTupleMetadata_CDcDMaXTJEYjcbRFSXcEbIQKY, "success", a_);
                return b_;
            });


    #endregion Functions and Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_CDcDMaXTJEYjcbRFSXcEbIQKY = new(
       [typeof(string), typeof((CqlTupleMetadata, string result1, string result2)?)],
       ["status", "result"]);

    private static CqlTupleMetadata CqlTupleMetadata_EPSaUMIUKUKJWbFHLJZKCNGEJ = new(
       [typeof(string), typeof(string)],
       ["result1", "result2"]);

    #endregion CqlTupleMetadata Properties

}
