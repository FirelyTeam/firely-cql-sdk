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
        context.GetOrCompute(_cacheIndex_Result, Result_Compute);

    private (CqlTupleMetadata, string status, (CqlTupleMetadata, string result1, string result2)? result)? Result_Compute(CqlContext context)
    {
        (CqlTupleMetadata, string result1, string result2)? a_ = (CqlTupleMetadata_EPSaUMIUKUKJWbFHLJZKCNGEJ, "some first result", "some second result");
        (CqlTupleMetadata, string status, (CqlTupleMetadata, string result1, string result2)? result)? b_ = (CqlTupleMetadata_CDcDMaXTJEYjcbRFSXcEbIQKY, "success", a_);
        return b_;
    }


    #endregion Functions and Expressions

    #region Cache Index Fields (1)

    private int _cacheIndex_Result = -1;

    #endregion Cache Index Fields

    #region ILibraryInternals Implementation

    /// <summary>
    /// Initializes cache indices for this library's cached expressions.
    /// </summary>
    /// <param name="libraryInvocationSet">The library invocation set performing initialization.</param>
    /// <param name="startIndex">The starting index for cache field assignment.</param>
    /// <returns>The number of cache indices initialized (number of cached expressions in this library).</returns>
    int ILibraryInternals.InitializeCacheIndices(
        CqlLibraryInvocationSet libraryInvocationSet,
        int startIndex)
    {
        var index = startIndex;
        _cacheIndex_Result = index++;
        return index - startIndex;
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
