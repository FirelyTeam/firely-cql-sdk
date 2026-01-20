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
using Hl7.Cql.Runtime.Internal;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "6.0.0.0")]
[CqlLibrary("CqlNestedTupleTest", "1.0.0")]
public partial class CqlNestedTupleTest_1_0_0 : ILibrary, ILibraryInternals, ISingleton<CqlNestedTupleTest_1_0_0>
{
    #region Functions and Expressions (1)

    [CqlExpressionDefinition("Result")]
    public (CqlTupleMetadata, string status, (CqlTupleMetadata, string result1, string result2)? result)? Result(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<(CqlTupleMetadata, string status, (CqlTupleMetadata, string result1, string result2)? result)?>(
            _cacheIndex_Result,
            Result_Compute);

    private (CqlTupleMetadata, string status, (CqlTupleMetadata, string result1, string result2)? result)? Result_Compute(CqlContext context)
    {
        (CqlTupleMetadata, string result1, string result2)? a_ = (CqlTupleMetadata_EPSaUMIUKUKJWbFHLJZKCNGEJ, "some first result", "some second result");
        (CqlTupleMetadata, string status, (CqlTupleMetadata, string result1, string result2)? result)? b_ = (CqlTupleMetadata_CDcDMaXTJEYjcbRFSXcEbIQKY, "success", a_);
        return b_;
    }


    #endregion Functions and Expressions

    #region Cache Index Fields (1)

    private int _cacheIndex_Result;

    #endregion Cache Index Fields

    #region ILibraryInternals Implementation

    bool ILibraryInternals.CacheIndicesInitialized { get; set; }

    int ILibraryInternals.InitializeCacheIndices(CacheIndexInitializer initializer)
    {
        // Skip if already processed
        if (!initializer.MarkAsProcessed(this))
            return 0;

        var count = 0;

        // Process dependencies first (depth-first traversal)
        if (Dependencies is { Length: > 0 })
        {
            foreach (var dependency in Dependencies)
            {
                if (dependency is ILibraryInternals internals)
                {
                    count += internals.InitializeCacheIndices(initializer);
                }
            }
        }

        // Initialize cache indices for this library
        if (_cacheIndex_Result != 0)
            throw new InvalidOperationException($"Cache index field '_cacheIndex_Result' in library '{{Name}}' version '{{Version}}' is already initialized to {{_cacheIndex_Result}}. Cache indices can only be initialized once.");
        _cacheIndex_Result = initializer.GetNextIndex();
        count++;

        return count;
    }

    #endregion ILibraryInternals Implementation

    #region Singleton Lifetime Members

    private CqlNestedTupleTest_1_0_0() {}

    public static CqlNestedTupleTest_1_0_0 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CqlNestedTupleTest";
    public string Version => "1.0.0";
    public ILibrary[] Dependencies => [];

    #endregion ILibrary Implementation

    #region CqlTupleMetadata Properties (2)

    private static CqlTupleMetadata CqlTupleMetadata_CDcDMaXTJEYjcbRFSXcEbIQKY = new(
       [typeof(string), typeof((CqlTupleMetadata, string result1, string result2)?)],
       ["status", "result"]);

    private static CqlTupleMetadata CqlTupleMetadata_EPSaUMIUKUKJWbFHLJZKCNGEJ = new(
       [typeof(string), typeof(string)],
       ["result1", "result2"]);

    #endregion CqlTupleMetadata Properties

}
