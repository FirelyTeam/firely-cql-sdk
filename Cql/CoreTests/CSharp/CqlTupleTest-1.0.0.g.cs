using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using System.Reflection;
using System.Dynamic;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.4.0")]
[CqlLibrary("CqlTupleTest", "1.0.0")]
public class CqlTupleTest_1_0_0
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<dynamic> __Result;

    #endregion
    public CqlTupleTest_1_0_0(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");


        __Result = new Lazy<dynamic>(this.Result_Value);
    }
	private dynamic Result_Value()
	{
		dynamic a_ = new ExpandoObject();
		a_.status = "success";
		a_.result = "some result";


		return a_;
	}

    [CqlDeclaration("Result")]
	public dynamic Result() => 
		__Result.Value;

}
