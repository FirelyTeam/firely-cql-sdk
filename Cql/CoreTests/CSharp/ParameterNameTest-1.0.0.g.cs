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
[CqlLibrary("ParameterNameTest", "1.0.0")]
public partial class ParameterNameTest_1_0_0 : ILibrary, ISingleton<ParameterNameTest_1_0_0>
{
    #region Functions and Expressions

    [CqlFunctionDefinition("Test Function")]
    public int? Test_Function(CqlContext context, [CqlFunctionParameter("param with spaces")] int? param_with_spaces, string normalParam)
    {
        int? a_ = context.Operators.Add(param_with_spaces, (int?)10);
        return a_;
    }


    [CqlFunctionDefinition("Another Test")]
    public decimal? Another_Test(CqlContext context, [CqlFunctionParameter("param-with-dashes")] decimal? param_with_dashes)
    {
        decimal? a_ = context.Operators.Multiply(param_with_dashes, (decimal?)2.0m);
        return a_;
    }


    [CqlFunctionDefinition("Keyword Test")]
    public int? Keyword_Test(CqlContext context, int? @int, string @ref, bool? @class)
    {
        int? a_ = context.Operators.Add(@int, (int?)5);
        return a_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private ParameterNameTest_1_0_0() {}

    public static ParameterNameTest_1_0_0 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "ParameterNameTest";
    public string Version => "1.0.0";
    public ILibrary[] Dependencies => [];

    #endregion ILibrary Implementation

}
