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
[CqlLibrary("ValueSetExprExample", "1.0.0")]
public partial class ValueSetExprExample_1_0_0 : ILibrary, ISingleton<ValueSetExprExample_1_0_0>
{
    #region ValueSets

    [CqlValueSetDefinition("ValueSet-A-1", valueSetId: "http://fire.ly/ValueSet/ValueSet-A-1", valueSetVersion: null)]
    public CqlValueSet ValueSet_A_1(CqlContext _) => _ValueSet_A_1;
    private static readonly CqlValueSet _ValueSet_A_1 = new CqlValueSet("http://fire.ly/ValueSet/ValueSet-A-1", null);

    [CqlValueSetDefinition("ValueSet-A-2", valueSetId: "http://fire.ly/ValueSet/ValueSet-A-2", valueSetVersion: null)]
    public CqlValueSet ValueSet_A_2(CqlContext _) => _ValueSet_A_2;
    private static readonly CqlValueSet _ValueSet_A_2 = new CqlValueSet("http://fire.ly/ValueSet/ValueSet-A-2", null);

    [CqlValueSetDefinition("ValueSet-B-1", valueSetId: "http://fire.ly/ValueSet/ValueSet-B-1", valueSetVersion: null)]
    public CqlValueSet ValueSet_B_1(CqlContext _) => _ValueSet_B_1;
    private static readonly CqlValueSet _ValueSet_B_1 = new CqlValueSet("http://fire.ly/ValueSet/ValueSet-B-1", null);

    [CqlValueSetDefinition("ValueSet-B-2", valueSetId: "http://fire.ly/ValueSet/ValueSet-B-2", valueSetVersion: null)]
    public CqlValueSet ValueSet_B_2(CqlContext _) => _ValueSet_B_2;
    private static readonly CqlValueSet _ValueSet_B_2 = new CqlValueSet("http://fire.ly/ValueSet/ValueSet-B-2", null);

    #endregion ValueSets

    #region Parameters

    [CqlParameterDefinition("ChosenSubCategory")]
    public string ChosenSubCategory(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<string>(6542735316349801256L, () => {
            object a_ = context.ResolveParameter("ValueSetExprExample-1.0.0", "ChosenSubCategory", "1");
            return (string)a_;
        });


    [CqlParameterDefinition("ChosenCode")]
    public CqlCode ChosenCode(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<CqlCode>(6542735333663349376L, () => {
            object a_ = context.ResolveParameter("ValueSetExprExample-1.0.0", "ChosenCode", new CqlCode("A-1-A", "http://fire.ly/CodeSystem/Test", default, default));
            return (CqlCode)a_;
        });


    #endregion Parameters

    #region Functions and Expressions

    [CqlExpressionDefinition("ValueSetA")]
    public CqlValueSet ValueSetA(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<CqlValueSet>(6542735335405875800L, () => {

            CqlValueSet a_() {

                bool b_() {
                    string d_ = this.ChosenSubCategory(context);
                    bool? e_ = context.Operators.Equal(d_, "1");
                    return e_ ?? false;
                }


                bool c_() {
                    string f_ = this.ChosenSubCategory(context);
                    bool? g_ = context.Operators.Equal(f_, "2");
                    return g_ ?? false;
                }

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
                };
            }

            return a_();
        });


    [CqlExpressionDefinition("ValueSetB")]
    public CqlValueSet ValueSetB(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<CqlValueSet>(6542735335540096752L, () => {

            CqlValueSet a_() {

                bool b_() {
                    string d_ = this.ChosenSubCategory(context);
                    bool? e_ = context.Operators.Equal(d_, "1");
                    return e_ ?? false;
                }


                bool c_() {
                    string f_ = this.ChosenSubCategory(context);
                    bool? g_ = context.Operators.Equal(f_, "2");
                    return g_ ?? false;
                }

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
                };
            }

            return a_();
        });


    [CqlExpressionDefinition("Result")]
    public string Result(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<string>(6542735321280780304L, () => {

            string a_() {

                bool b_() {
                    CqlCode d_ = this.ChosenCode(context);
                    CqlValueSet e_ = this.ValueSetA(context);
                    bool? f_ = context.Operators.CodeInValueSet(d_, e_);
                    return f_ ?? false;
                }


                bool c_() {
                    CqlCode g_ = this.ChosenCode(context);
                    CqlValueSet h_ = this.ValueSetB(context);
                    bool? i_ = context.Operators.CodeInValueSet(g_, h_);
                    return i_ ?? false;
                }

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
                };
            }

            return a_();
        });


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private ValueSetExprExample_1_0_0() {}

    public static ValueSetExprExample_1_0_0 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "ValueSetExprExample";
    public string Version => "1.0.0";
    public ILibrary[] Dependencies => [];

    #endregion ILibrary Implementation

}
