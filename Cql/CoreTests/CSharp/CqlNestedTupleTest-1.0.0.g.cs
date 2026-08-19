#nullable enable annotations

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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.0.0")]
[CqlLibrary("CqlNestedTupleTest", "1.0.0")]
public partial class CqlNestedTupleTest_1_0_0 : ILibrary, ISingleton<CqlNestedTupleTest_1_0_0>
{
    #region Functions and Expressions (1)

    [CqlExpressionDefinition("Result")]
    public (CqlTupleMetadata, (CqlTupleMetadata, string? result1, string? result2)? result, string? status)? Result(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Result, Result_Compute);

    private const long _cacheIndex_Result = -5211663732441812733L;

    private (CqlTupleMetadata, (CqlTupleMetadata, string? result1, string? result2)? result, string? status)? Result_Compute(CqlContext context)
    {
        (CqlTupleMetadata, string? result1, string? result2)? a_ = (CqlTupleMetadata_EPSaUMIUKUKJWbFHLJZKCNGEJ, "some first result", "some second result");
        (CqlTupleMetadata, (CqlTupleMetadata, string? result1, string? result2)? result, string? status)? b_ = (CqlTupleMetadata_EDCNVAaGTSjJYEdHbFSMjTdAe, a_, "success");
        return b_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private CqlNestedTupleTest_1_0_0() {}

    public static CqlNestedTupleTest_1_0_0 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CqlNestedTupleTest";
    public string Version => "1.0.0";
    public ILibrary[] Dependencies => [];

    #endregion ILibrary Implementation

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_EDCNVAaGTSjJYEdHbFSMjTdAe = new(
       [typeof((CqlTupleMetadata, string result1, string result2)?), typeof(string)],
       ["result", "status"]);

    private static CqlTupleMetadata CqlTupleMetadata_EPSaUMIUKUKJWbFHLJZKCNGEJ = new(
       [typeof(string), typeof(string)],
       ["result1", "result2"]);

    #endregion CqlTupleMetadata Properties

}
