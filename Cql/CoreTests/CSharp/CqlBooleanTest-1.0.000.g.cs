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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.0.0")]
[CqlLibrary("CqlBooleanTest", "1.0.000")]
public partial class CqlBooleanTest_1_0_000 : ILibrary, ISingleton<CqlBooleanTest_1_0_000>
{
    #region Functions and Expressions (1)

    [CqlExpressionDefinition("SomethingTrueEqualsTrue")]
    public bool? SomethingTrueEqualsTrue(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SomethingTrueEqualsTrue, SomethingTrueEqualsTrue_Compute);

    private const long _cacheIndex_SomethingTrueEqualsTrue = -7966027749533621960L;

    private bool? SomethingTrueEqualsTrue_Compute(CqlContext context)
    {
        bool? a_ = context.Operators.Equal(1, 1);
        bool? b_ = context.Operators.Equal(a_, true);
        return b_;
    }


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

}
