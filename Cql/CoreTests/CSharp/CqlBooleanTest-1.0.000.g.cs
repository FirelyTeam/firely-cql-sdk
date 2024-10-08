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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.4.0")]
[CqlLibrary("CqlBooleanTest", "1.0.000")]
public class CqlBooleanTest_1_0_000
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<bool?> __SomethingTrueEqualsTrue;

    #endregion
    public CqlBooleanTest_1_0_000(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");


        __SomethingTrueEqualsTrue = new Lazy<bool?>(this.SomethingTrueEqualsTrue_Value);
    }
	private bool? SomethingTrueEqualsTrue_Value()
	{
		bool? a_ = context.Operators.Equal(1, 1);
		bool? b_ = context.Operators.Equal(a_, true);

		return b_;
	}

    [CqlDeclaration("SomethingTrueEqualsTrue")]
	public bool? SomethingTrueEqualsTrue() => 
		__SomethingTrueEqualsTrue.Value;

}
