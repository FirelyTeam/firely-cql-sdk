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
        _cache?.GetOrCompute(_cacheIndex_SomethingTrueEqualsTrue, SomethingTrueEqualsTrue_Compute, context) ?? SomethingTrueEqualsTrue_Compute(context);

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

    // Reference to the execution cache instance that initialized this library
    private CqlLibrarySetInvocationCache _cache;

    /// <summary>
    /// Initializes cache indices for this library's cached expressions.
    /// </summary>
    /// <param name="cache">The execution cache instance performing initialization.</param>
    /// <param name="startIndex">The starting index for cache field assignment.</param>
    /// <returns>The number of cache indices initialized (number of cached expressions in this library).</returns>
    int ILibraryInternals.InitializeCacheIndices(
        CqlLibrarySetInvocationCache cache,
        int startIndex)
    {
        // Skip if already initialized by this cache instance (allows re-initialization with different cache)
        if (_cache == cache)
            return 0;

        _cache = cache;

        var index = startIndex;
        _cacheIndex_SomethingTrueEqualsTrue = index++;
        return index - startIndex;
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
