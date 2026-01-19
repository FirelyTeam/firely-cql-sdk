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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.0.0.0")]
[CqlLibrary("CqlNestedTupleTest", "1.0.0")]
public partial class CqlNestedTupleTest_1_0_0 : ILibrary, ISingleton<CqlNestedTupleTest_1_0_0>
{
    #region Functions and Expressions

    [CqlExpressionDefinition("Result")]
    public (CqlTupleMetadata, string status, (CqlTupleMetadata, string result1, string result2)? result)? Result(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<(CqlTupleMetadata, string status, (CqlTupleMetadata, string result1, string result2)? result)?>(_cacheIndex_Result, Result_Compute);

    private (CqlTupleMetadata, string status, (CqlTupleMetadata, string result1, string result2)? result)? Result_Compute(CqlContext context)
    {
        (CqlTupleMetadata, string result1, string result2)? a_ = (CqlTupleMetadata_EPSaUMIUKUKJWbFHLJZKCNGEJ, "some first result", "some second result");
        (CqlTupleMetadata, string status, (CqlTupleMetadata, string result1, string result2)? result)? b_ = (CqlTupleMetadata_CDcDMaXTJEYjcbRFSXcEbIQKY, "success", a_);
        return b_;
    }


    #endregion Functions and Expressions

    #region Cache Index Fields

    private int _cacheIndex_Result;

    #endregion Cache Index Fields

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

    private static CqlTupleMetadata CqlTupleMetadata_CDcDMaXTJEYjcbRFSXcEbIQKY = new(
       [typeof(string), typeof((CqlTupleMetadata, string result1, string result2)?)],
       ["status", "result"]);

    private static CqlTupleMetadata CqlTupleMetadata_EPSaUMIUKUKJWbFHLJZKCNGEJ = new(
       [typeof(string), typeof(string)],
       ["result1", "result2"]);

    #endregion CqlTupleMetadata Properties

}
