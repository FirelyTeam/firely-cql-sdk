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
[CqlLibrary("ParameterNameTest", "1.0.0")]
public partial class ParameterNameTest_1_0_0 : ILibrary, ILibraryInternals, ISingleton<ParameterNameTest_1_0_0>
{
    #region Functions and Expressions (3)

    [CqlFunctionDefinition("Test Function")]
    public int? Test_Function(CqlContext context, [CqlFunctionParameter("param with spaces")] int? param_with_spaces, string normalParam)
    {
        int? a_ = context.Operators.Add(param_with_spaces, 10);
        return a_;
    }


    [CqlFunctionDefinition("Another Test")]
    public decimal? Another_Test(CqlContext context, [CqlFunctionParameter("param-with-dashes")] decimal? param_with_dashes)
    {
        decimal? a_ = context.Operators.Multiply(param_with_dashes, 2.0m);
        return a_;
    }


    [CqlFunctionDefinition("Keyword Test")]
    public int? Keyword_Test(CqlContext context, int? @int, string @ref, bool? @class)
    {
        int? a_ = context.Operators.Add(@int, 5);
        return a_;
    }


    #endregion Functions and Expressions

    #region ILibraryInternals Implementation

    private CqlLibrariesExecutionCache CacheInstance { get; set; }

    int ILibraryInternals.InitializeCacheIndices(CqlLibrariesExecutionCache cache)
    {
        if (CacheInstance == cache)
            return 0;

        CacheInstance = cache;

        var count = 0;

        if (Dependencies is { Length: > 0 })
        {
            foreach (var dependency in Dependencies)
            {
                if (dependency is ILibraryInternals internals)
                {
                    count += internals.InitializeCacheIndices(cache);
                }
            }
        }

        return count;
    }

    #endregion ILibraryInternals Implementation

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
