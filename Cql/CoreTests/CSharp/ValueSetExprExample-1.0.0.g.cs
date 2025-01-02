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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.8.0")]
[CqlLibrary("ValueSetExprExample", "1.0.0")]
public partial class ValueSetExprExample_1_0_0 : ILibrary, ISingleton<ValueSetExprExample_1_0_0>
{
    private ValueSetExprExample_1_0_0() {}

    public static ValueSetExprExample_1_0_0 Instance { get; } = new();

    #region Library Members
    string ILibrary.Name => "ValueSetExprExample";
    string ILibrary.Version => "1.0.0";
    IReadOnlyList<ILibrary> ILibrary.Dependencies => [];
    #endregion Library Members

    [CqlDeclaration("ValueSet-A-1")]
    [CqlValueSet("http://fire.ly/ValueSet/ValueSet-A-1")]
    public CqlValueSet ValueSet_A_1(CqlContext context) =>
        new CqlValueSet("http://fire.ly/ValueSet/ValueSet-A-1", default);



    [CqlDeclaration("ValueSet-A-2")]
    [CqlValueSet("http://fire.ly/ValueSet/ValueSet-A-2")]
    public CqlValueSet ValueSet_A_2(CqlContext context) =>
        new CqlValueSet("http://fire.ly/ValueSet/ValueSet-A-2", default);



    [CqlDeclaration("ValueSet-B-1")]
    [CqlValueSet("http://fire.ly/ValueSet/ValueSet-B-1")]
    public CqlValueSet ValueSet_B_1(CqlContext context) =>
        new CqlValueSet("http://fire.ly/ValueSet/ValueSet-B-1", default);



    [CqlDeclaration("ValueSet-B-2")]
    [CqlValueSet("http://fire.ly/ValueSet/ValueSet-B-2")]
    public CqlValueSet ValueSet_B_2(CqlContext context) =>
        new CqlValueSet("http://fire.ly/ValueSet/ValueSet-B-2", default);



    [CqlDeclaration("ChosenSubCategory")]
    public string ChosenSubCategory(CqlContext context)
    {
        object a_ = context.ResolveParameter("ValueSetExprExample-1.0.0", "ChosenSubCategory", "1");

        return (string)a_;
    }



    [CqlDeclaration("ChosenCode")]
    public CqlCode ChosenCode(CqlContext context)
    {
        object a_ = context.ResolveParameter("ValueSetExprExample-1.0.0", "ChosenCode", new CqlCode("A-1-A", "http://fire.ly/CodeSystem/Test", null, null));

        return (CqlCode)a_;
    }



    [CqlDeclaration("ValueSetA")]
    public CqlValueSet ValueSetA(CqlContext context)
    {
        CqlValueSet a_()
        {
            bool b_()
            {
                string d_ = this.ChosenSubCategory(context);
                bool? e_ = context.Operators.Equal(d_, "1");

                return e_ ?? false;
            };
            bool c_()
            {
                string f_ = this.ChosenSubCategory(context);
                bool? g_ = context.Operators.Equal(f_, "2");

                return g_ ?? false;
            };
            if (b_())
            {
                CqlValueSet h_ = this.ValueSet_A_1(context);

                return h_;
            }
            else if (c_())
            {
                CqlValueSet i_ = this.ValueSet_A_2(context);

                return i_;
            }
            else
            {
                return default;
            }
        };

        return a_();
    }



    [CqlDeclaration("ValueSetB")]
    public CqlValueSet ValueSetB(CqlContext context)
    {
        CqlValueSet a_()
        {
            bool b_()
            {
                string d_ = this.ChosenSubCategory(context);
                bool? e_ = context.Operators.Equal(d_, "1");

                return e_ ?? false;
            };
            bool c_()
            {
                string f_ = this.ChosenSubCategory(context);
                bool? g_ = context.Operators.Equal(f_, "2");

                return g_ ?? false;
            };
            if (b_())
            {
                CqlValueSet h_ = this.ValueSet_B_1(context);

                return h_;
            }
            else if (c_())
            {
                CqlValueSet i_ = this.ValueSet_B_2(context);

                return i_;
            }
            else
            {
                return default;
            }
        };

        return a_();
    }



    [CqlDeclaration("Result")]
    public string Result(CqlContext context)
    {
        string a_()
        {
            bool b_()
            {
                CqlCode d_ = this.ChosenCode(context);
                CqlValueSet e_ = this.ValueSetA(context);
                bool? f_ = context.Operators.CodeInValueSet(d_, e_);

                return f_ ?? false;
            };
            bool c_()
            {
                CqlCode g_ = this.ChosenCode(context);
                CqlValueSet h_ = this.ValueSetB(context);
                bool? i_ = context.Operators.CodeInValueSet(g_, h_);

                return i_ ?? false;
            };
            if (b_())
            {
                return "a";
            }
            else if (c_())
            {
                return "b";
            }
            else
            {
                return default;
            }
        };

        return a_();
    }


    private static CqlTupleMetadata CqlTupleMetadata_EPSaUMIUKUKJWbFHLJZKCNGEJ = new(
        [typeof(string), typeof(string)],
        ["result1", "result2"]);

    private static CqlTupleMetadata CqlTupleMetadata_CDcDMaXTJEYjcbRFSXcEbIQKY = new(
        [typeof(string), typeof((CqlTupleMetadata, string result1, string result2)?)],
        ["status", "result"]);

}
