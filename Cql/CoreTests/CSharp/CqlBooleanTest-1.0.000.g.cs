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
[CqlLibrary("CqlBooleanTest", "1.0.000")]
public partial class CqlBooleanTest_1_0_000 : ILibrary, ILibraryInternals, ISingleton<CqlBooleanTest_1_0_000>
{
    #region Functions and Expressions (1)

    [CqlExpressionDefinition("SomethingTrueEqualsTrue")]
    public bool? SomethingTrueEqualsTrue(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<bool?>(
            _cacheIndex_SomethingTrueEqualsTrue,
            SomethingTrueEqualsTrue_Compute);

    private bool? SomethingTrueEqualsTrue_Compute(CqlContext context)
    {
        bool? a_ = context.Operators.Equal(1, 1);
        bool? b_ = context.Operators.Equal(a_, true);
        return b_;
    }


    #endregion Functions and Expressions

    #region Cache Index Fields (1)

    private int _cacheIndex_SomethingTrueEqualsTrue = -1;

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
        if (_cacheIndex_SomethingTrueEqualsTrue != -1)
            throw new InvalidOperationException($"Cache index field '_cacheIndex_SomethingTrueEqualsTrue' in library '{{Name}}' version '{{Version}}' is already initialized to {{_cacheIndex_SomethingTrueEqualsTrue}}. Cache indices can only be initialized once.");
        _cacheIndex_SomethingTrueEqualsTrue = initializer.GetNextIndex();
        count++;

        return count;
    }

    #endregion ILibraryInternals Implementation

    #region Singleton Lifetime Members

    private CqlBooleanTest_1_0_000() {}

    public static CqlBooleanTest_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CqlBooleanTest";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [];

    #endregion ILibrary Implementation

}
