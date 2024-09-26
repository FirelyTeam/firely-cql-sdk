﻿using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using System.Reflection;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.4.0")]
[CqlLibrary("CqlTupleTest", "1.0.0")]
public class CqlTupleTest_1_0_0
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<(string status, string result)?> __Result;

    #endregion
    public CqlTupleTest_1_0_0(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");


        __Result = new Lazy<(string status, string result)?>(this.Result_Value);
    }
	private (string status, string result)? Result_Value()
	{
		(string status, string result)? a_ = ("success", "some result");

		return a_;
	}

    [CqlDeclaration("Result")]
	public (string status, string result)? Result() => 
		__Result.Value;

}
