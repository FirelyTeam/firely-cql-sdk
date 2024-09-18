using System;
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

#pragma warning disable CS9113 // Parameter is unread.

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.3.0")]
[CqlLibrary("CqlBooleanTest", "1.0.000")]
public class CqlBooleanTest_1_0_000
{

    [CqlDeclaration("SomethingTrueEqualsTrue")]
	public  bool? SomethingTrueEqualsTrue(CqlContext context)
	{
		bool? a_ = context.Operators.Equal(1, 1);
		bool? b_ = context.Operators.Equal(a_, true);

		return b_;
	}

}
