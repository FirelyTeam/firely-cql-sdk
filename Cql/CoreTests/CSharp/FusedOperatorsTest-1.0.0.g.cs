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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.4.0")]
[CqlLibrary("FusedOperatorsTest", "1.0.0")]
public partial class FusedOperatorsTest_1_0_0 : ILibrary, ISingleton<FusedOperatorsTest_1_0_0>
{
    #region Functions and Expressions (5)

    [CqlExpressionDefinition("Numbers")]
    public IEnumerable<int?> Numbers(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numbers, Numbers_Compute);

    private const long _cacheIndex_Numbers = 5710833029308663172L;

    private IEnumerable<int?> Numbers_Compute(CqlContext context)
    {
        int?[] a_ = [
            1,
            2,
            3,
            4,
            5,
            2,
            3,
        ];
        return (IEnumerable<int?>)a_;
    }


    [CqlExpressionDefinition("AnyGreaterThanFour")]
    public bool? AnyGreaterThanFour(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_AnyGreaterThanFour, AnyGreaterThanFour_Compute);

    private const long _cacheIndex_AnyGreaterThanFour = 695039018078661524L;

    private bool? AnyGreaterThanFour_Compute(CqlContext context)
    {
        IEnumerable<int?> a_ = this.Numbers(context);

        bool? b_(int? N) {
            CqlBoolean d_ = context.Operators.Greater(N, 4);
            return d_;
        }

        CqlBoolean c_ = context.Operators.WhereAny<int?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("TenTimesEvens")]
    public IEnumerable<int?> TenTimesEvens(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_TenTimesEvens, TenTimesEvens_Compute);

    private const long _cacheIndex_TenTimesEvens = -8432815467079268054L;

    private IEnumerable<int?> TenTimesEvens_Compute(CqlContext context)
    {
        IEnumerable<int?> a_ = this.Numbers(context);

        bool? b_(int? N) {
            int? e_ = context.Operators.Modulo(N, 2);
            CqlBoolean f_ = context.Operators.Equal(e_, 0);
            return f_;
        }


        int? c_(int? N) {
            int? g_ = context.Operators.Multiply(N, 10);
            return g_;
        }

        IEnumerable<int?> d_ = context.Operators.WhereSelect<int?, int?>(a_, b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("DoublesOverSix")]
    public IEnumerable<int?> DoublesOverSix(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_DoublesOverSix, DoublesOverSix_Compute);

    private const long _cacheIndex_DoublesOverSix = -73810178161427429L;

    private IEnumerable<int?> DoublesOverSix_Compute(CqlContext context)
    {
        IEnumerable<int?> a_ = this.Numbers(context);

        int? b_(int? N) {
            int? e_ = context.Operators.Multiply(N, 2);
            return e_;
        }


        bool? c_(int? D) {
            CqlBoolean f_ = context.Operators.Greater(D, 6);
            return f_;
        }

        IEnumerable<int?> d_ = context.Operators.SelectWhere<int?, int?>(a_, b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("DistinctSquares")]
    public IEnumerable<int?> DistinctSquares(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_DistinctSquares, DistinctSquares_Compute);

    private const long _cacheIndex_DistinctSquares = 9095248241989806364L;

    private IEnumerable<int?> DistinctSquares_Compute(CqlContext context)
    {
        IEnumerable<int?> a_ = this.Numbers(context);

        int? b_(int? N) {
            int? d_ = context.Operators.Multiply(N, N);
            return d_;
        }

        IEnumerable<int?> c_ = context.Operators.SelectDistinct<int?, int?>(a_, b_);
        return c_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private FusedOperatorsTest_1_0_0() {}

    public static FusedOperatorsTest_1_0_0 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "FusedOperatorsTest";
    public string Version => "1.0.0";
    public ILibrary[] Dependencies => [];

    #endregion ILibrary Implementation

}
