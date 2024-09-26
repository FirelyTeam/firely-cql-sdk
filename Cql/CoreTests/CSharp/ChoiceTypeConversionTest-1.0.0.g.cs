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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.4.0")]
[CqlLibrary("ChoiceTypeConversionTest", "1.0.0")]
public class ChoiceTypeConversionTest_1_0_0
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<object> __ReturnDateAsChoice;
    internal Lazy<object> __ReturnStringAsChoice;
    internal Lazy<bool?> __ReturnDateAsChoiceInRangeMustBeTrue;
    internal Lazy<bool?> __ReturnDateAsChoiceOutOfRangeMustBeFalse;
    internal Lazy<bool?> __ReturnStringAsChoiceInRangeMustBeNull;

    #endregion
    public ChoiceTypeConversionTest_1_0_0(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");


        __ReturnDateAsChoice = new Lazy<object>(this.ReturnDateAsChoice_Value);
        __ReturnStringAsChoice = new Lazy<object>(this.ReturnStringAsChoice_Value);
        __ReturnDateAsChoiceInRangeMustBeTrue = new Lazy<bool?>(this.ReturnDateAsChoiceInRangeMustBeTrue_Value);
        __ReturnDateAsChoiceOutOfRangeMustBeFalse = new Lazy<bool?>(this.ReturnDateAsChoiceOutOfRangeMustBeFalse_Value);
        __ReturnStringAsChoiceInRangeMustBeNull = new Lazy<bool?>(this.ReturnStringAsChoiceInRangeMustBeNull_Value);
    }
	private object ReturnDateAsChoice_Value()
	{
		CqlDate a_ = context.Operators.Date(2019, 1, 1);

		return a_ as object;
	}

    [CqlDeclaration("ReturnDateAsChoice")]
    [CqlTag("publisher", "Firely")]
    [CqlTag("description", "Library used to test conversions on choice types")]
	public object ReturnDateAsChoice() => 
		__ReturnDateAsChoice.Value;

	private object ReturnStringAsChoice_Value() => 
		"2019-01-01" as object;

    [CqlDeclaration("ReturnStringAsChoice")]
	public object ReturnStringAsChoice() => 
		__ReturnStringAsChoice.Value;

	private bool? ReturnDateAsChoiceInRangeMustBeTrue_Value()
	{
		object a_ = this.ReturnDateAsChoice();
		CqlDate b_ = a_ switch { null => null , CqlDate a => a, _ => throw new System.Diagnostics.UnreachableException() };
		CqlDateTime c_ = context.Operators.ConvertDateToDateTime(b_);
		CqlDateTime d_ = context.Operators.DateTime(2019, 1, 1, default, default, default, default, default);
		CqlDateTime e_ = context.Operators.DateTime(2019, 12, 31, default, default, default, default, default);
		CqlInterval<CqlDateTime> f_ = context.Operators.Interval(d_, e_, true, true);
		bool? g_ = context.Operators.In<CqlDateTime>(c_, f_, default);

		return g_;
	}

    [CqlDeclaration("ReturnDateAsChoiceInRangeMustBeTrue")]
	public bool? ReturnDateAsChoiceInRangeMustBeTrue() => 
		__ReturnDateAsChoiceInRangeMustBeTrue.Value;

	private bool? ReturnDateAsChoiceOutOfRangeMustBeFalse_Value()
	{
		object a_ = this.ReturnDateAsChoice();
		CqlDate b_ = a_ switch { null => null , CqlDate a => a, _ => throw new System.Diagnostics.UnreachableException() };
		CqlDateTime c_ = context.Operators.ConvertDateToDateTime(b_);
		CqlDateTime d_ = context.Operators.DateTime(2018, 1, 1, default, default, default, default, default);
		CqlDateTime e_ = context.Operators.DateTime(2018, 12, 31, default, default, default, default, default);
		CqlInterval<CqlDateTime> f_ = context.Operators.Interval(d_, e_, true, true);
		bool? g_ = context.Operators.In<CqlDateTime>(c_, f_, default);

		return g_;
	}

    [CqlDeclaration("ReturnDateAsChoiceOutOfRangeMustBeFalse")]
	public bool? ReturnDateAsChoiceOutOfRangeMustBeFalse() => 
		__ReturnDateAsChoiceOutOfRangeMustBeFalse.Value;

	private bool? ReturnStringAsChoiceInRangeMustBeNull_Value()
	{
		object a_ = this.ReturnStringAsChoice();
		CqlDate b_ = a_ switch { null => null , CqlDate a => a, _ => throw new System.Diagnostics.UnreachableException() };
		CqlDateTime c_ = context.Operators.ConvertDateToDateTime(b_);
		CqlDateTime d_ = context.Operators.DateTime(2019, 1, 1, default, default, default, default, default);
		CqlDateTime e_ = context.Operators.DateTime(2019, 12, 31, default, default, default, default, default);
		CqlInterval<CqlDateTime> f_ = context.Operators.Interval(d_, e_, true, true);
		bool? g_ = context.Operators.In<CqlDateTime>(c_, f_, default);

		return g_;
	}

    [CqlDeclaration("ReturnStringAsChoiceInRangeMustBeNull")]
	public bool? ReturnStringAsChoiceInRangeMustBeNull() => 
		__ReturnStringAsChoiceInRangeMustBeNull.Value;

}
