using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "0.0.1.0")]
[CqlLibrary("NCQAFHIRBase", "1.0.0")]
public class NCQAFHIRBase_1_0_0
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<Patient> __Patient;

    #endregion
    public NCQAFHIRBase_1_0_0(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_0_001 = new FHIRHelpers_4_0_001(context);

        __Patient = new Lazy<Patient>(this.Patient_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_0_001 FHIRHelpers_4_0_001 { get; }

    #endregion

    private Patient Patient_Value()
	{
		var a_ = context.DataRetriever;
		var b_ = a_.RetrieveByValueSet<Patient>(null, null);
		var c_ = context.Operators;
		var d_ = c_.SingleOrNull<Patient>(b_);

		return d_;
	}

    [CqlDeclaration("Patient")]
    public Patient Patient() => __Patient.Value;

    [CqlDeclaration("Normalize Onset")]
    public CqlInterval<CqlDateTime> Normalize_Onset(object onset)
    {
        if (((onset is FhirDateTime as bool?) ?? false))
		{
			var a__ = (onset as FhirDateTime);
			var b__ = FHIRHelpers_4_0_001.ToDateTime(a__);
			var d__ = FHIRHelpers_4_0_001.ToDateTime(a__);
			var e__ = context.Operators;
			var f__ = e__.Interval(b__, d__, true, true);

			return f__;
		}
        else if (((onset is Period as bool?) ?? false))
		{
			var a__ = context.Operators;
			var b__ = a__.LateBoundProperty<FhirDateTime>(onset, "start");
			var c__ = b__.Value;
			var e__ = a__.ConvertStringToDateTime(c__);
			var g__ = a__.LateBoundProperty<FhirDateTime>(onset, "end");
			var h__ = g__.Value;
			var j__ = a__.ConvertStringToDateTime(h__);
			var l__ = a__.Interval(e__, j__, true, true);

			return l__;
		}
        else if (((onset is FhirString as bool?) ?? false))
		{
			CqlInterval<CqlDateTime> a__ = null;
			var b__ = (a__ as CqlInterval<CqlDateTime>);
			var c__ = context.Operators;
			var d__ = c__.Message<CqlInterval<CqlDateTime>>(b__, "1", "Error", "Cannot compute an interval from a String value");

			return d__;
		}
        else
		{
			var a__ = ((((onset is Age as bool?) ?? false))
	? (context.Operators.Interval(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient().BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((Quantity)(onset as Age))), context.Operators.Add(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient().BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((Quantity)(onset as Age))), context.Operators.Quantity(1m, "year")), true, false))
	: (((((onset is Range as bool?) ?? false))
			? (context.Operators.Interval(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient().BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((onset as Range).Low)), context.Operators.Add(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient().BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((onset as Range).High)), context.Operators.Quantity(1m, "year")), true, false))
			: ((null as CqlInterval<CqlDate>)))
))
.low;
			var b__ = context.Operators;
			var c__ = b__.ConvertDateToDateTime(a__);
			var d__ = ((((onset is Age as bool?) ?? false))
	? (context.Operators.Interval(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient().BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((Quantity)(onset as Age))), context.Operators.Add(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient().BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((Quantity)(onset as Age))), context.Operators.Quantity(1m, "year")), true, false))
	: (((((onset is Range as bool?) ?? false))
			? (context.Operators.Interval(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient().BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((onset as Range).Low)), context.Operators.Add(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient().BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((onset as Range).High)), context.Operators.Quantity(1m, "year")), true, false))
			: ((null as CqlInterval<CqlDate>)))
))
.high;
			var f__ = b__.ConvertDateToDateTime(d__);
			var g__ = ((((onset is Age as bool?) ?? false))
	? (context.Operators.Interval(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient().BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((Quantity)(onset as Age))), context.Operators.Add(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient().BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((Quantity)(onset as Age))), context.Operators.Quantity(1m, "year")), true, false))
	: (((((onset is Range as bool?) ?? false))
			? (context.Operators.Interval(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient().BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((onset as Range).Low)), context.Operators.Add(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient().BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((onset as Range).High)), context.Operators.Quantity(1m, "year")), true, false))
			: ((null as CqlInterval<CqlDate>)))
))
.lowClosed;
			var h__ = ((((onset is Age as bool?) ?? false))
	? (context.Operators.Interval(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient().BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((Quantity)(onset as Age))), context.Operators.Add(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient().BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((Quantity)(onset as Age))), context.Operators.Quantity(1m, "year")), true, false))
	: (((((onset is Range as bool?) ?? false))
			? (context.Operators.Interval(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient().BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((onset as Range).Low)), context.Operators.Add(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient().BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((onset as Range).High)), context.Operators.Quantity(1m, "year")), true, false))
			: ((null as CqlInterval<CqlDate>)))
))
.highClosed;
			var j__ = b__.Interval(c__, f__, g__, h__);

			return j__;
		}
    }


    [CqlDeclaration("Normalize Abatement")]
    public CqlInterval<CqlDateTime> Normalize_Abatement(object abatement)
    {
        if (((abatement is FhirDateTime as bool?) ?? false))
		{
			var a__ = (abatement as FhirDateTime);
			var b__ = FHIRHelpers_4_0_001.ToDateTime(a__);
			var d__ = FHIRHelpers_4_0_001.ToDateTime(a__);
			var e__ = context.Operators;
			var f__ = e__.Interval(b__, d__, true, true);

			return f__;
		}
        else if (((abatement is Period as bool?) ?? false))
		{
			var a__ = context.Operators;
			var b__ = a__.LateBoundProperty<FhirDateTime>(abatement, "start");
			var c__ = b__.Value;
			var e__ = a__.ConvertStringToDateTime(c__);
			var g__ = a__.LateBoundProperty<FhirDateTime>(abatement, "end");
			var h__ = g__.Value;
			var j__ = a__.ConvertStringToDateTime(h__);
			var l__ = a__.Interval(e__, j__, true, true);

			return l__;
		}
        else if (((abatement is FhirString as bool?) ?? false))
		{
			CqlInterval<CqlDateTime> a__ = null;
			var b__ = (a__ as CqlInterval<CqlDateTime>);
			var c__ = context.Operators;
			var d__ = c__.Message<CqlInterval<CqlDateTime>>(b__, "1", "Error", "Cannot compute an interval from a String value");

			return d__;
		}
        else
		{
			var a__ = ((((abatement is Age as bool?) ?? false))
	? (context.Operators.Interval(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient().BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((Quantity)(abatement as Age))), context.Operators.Add(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient().BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((Quantity)(abatement as Age))), context.Operators.Quantity(1m, "year")), true, false))
	: (((((abatement is Range as bool?) ?? false))
			? (context.Operators.Interval(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient().BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((abatement as Range).Low)), context.Operators.Add(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient().BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((abatement as Range).High)), context.Operators.Quantity(1m, "year")), true, false))
			: ((null as CqlInterval<CqlDate>)))
))
.low;
			var b__ = context.Operators;
			var c__ = b__.ConvertDateToDateTime(a__);
			var d__ = ((((abatement is Age as bool?) ?? false))
	? (context.Operators.Interval(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient().BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((Quantity)(abatement as Age))), context.Operators.Add(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient().BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((Quantity)(abatement as Age))), context.Operators.Quantity(1m, "year")), true, false))
	: (((((abatement is Range as bool?) ?? false))
			? (context.Operators.Interval(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient().BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((abatement as Range).Low)), context.Operators.Add(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient().BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((abatement as Range).High)), context.Operators.Quantity(1m, "year")), true, false))
			: ((null as CqlInterval<CqlDate>)))
))
.high;
			var f__ = b__.ConvertDateToDateTime(d__);
			var g__ = ((((abatement is Age as bool?) ?? false))
	? (context.Operators.Interval(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient().BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((Quantity)(abatement as Age))), context.Operators.Add(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient().BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((Quantity)(abatement as Age))), context.Operators.Quantity(1m, "year")), true, false))
	: (((((abatement is Range as bool?) ?? false))
			? (context.Operators.Interval(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient().BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((abatement as Range).Low)), context.Operators.Add(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient().BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((abatement as Range).High)), context.Operators.Quantity(1m, "year")), true, false))
			: ((null as CqlInterval<CqlDate>)))
))
.lowClosed;
			var h__ = ((((abatement is Age as bool?) ?? false))
	? (context.Operators.Interval(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient().BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((Quantity)(abatement as Age))), context.Operators.Add(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient().BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((Quantity)(abatement as Age))), context.Operators.Quantity(1m, "year")), true, false))
	: (((((abatement is Range as bool?) ?? false))
			? (context.Operators.Interval(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient().BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((abatement as Range).Low)), context.Operators.Add(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient().BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((abatement as Range).High)), context.Operators.Quantity(1m, "year")), true, false))
			: ((null as CqlInterval<CqlDate>)))
))
.highClosed;
			var j__ = b__.Interval(c__, f__, g__, h__);

			return j__;
		}
    }


    [CqlDeclaration("Prevalence Period")]
    public CqlInterval<CqlDateTime> Prevalence_Period(Condition condition)
	{
		var a_ = condition.Onset;
		var b_ = this.Normalize_Onset(a_);
		var c_ = context.Operators;
		var d_ = c_.Start(b_);
		var e_ = condition.Abatement;
		var f_ = this.Normalize_Abatement(e_);
		var h_ = c_.End(f_);
		var j_ = c_.Interval(d_, h_, true, true);

		return j_;
	}


    [CqlDeclaration("Normalize Interval")]
    public CqlInterval<CqlDateTime> Normalize_Interval(object choice)
    {
        if (((choice is FhirDateTime as bool?) ?? false))
		{
			var a__ = (choice as FhirDateTime);
			var b__ = FHIRHelpers_4_0_001.ToDateTime(a__);
			var d__ = FHIRHelpers_4_0_001.ToDateTime(a__);
			var e__ = context.Operators;
			var f__ = e__.Interval(b__, d__, true, true);

			return f__;
		}
        else if (((choice is Date as bool?) ?? false))
		{
			var a__ = (choice as Date);
			var b__ = FHIRHelpers_4_0_001.ToDate(a__);
			var c__ = context.Operators;
			var d__ = c__.ConvertDateToDateTime(b__);
			var f__ = FHIRHelpers_4_0_001.ToDate(a__);
			var h__ = c__.ConvertDateToDateTime(f__);
			var j__ = c__.Interval(d__, h__, true, true);

			return j__;
		}
        else if (((choice is Period as bool?) ?? false))
		{
			var a__ = context.Operators;
			var b__ = a__.LateBoundProperty<FhirDateTime>(choice, "start");
			var c__ = b__.Value;
			var e__ = a__.ConvertStringToDateTime(c__);
			var g__ = a__.LateBoundProperty<FhirDateTime>(choice, "end");
			var h__ = g__.Value;
			var j__ = a__.ConvertStringToDateTime(h__);
			var l__ = a__.Interval(e__, j__, true, true);

			return l__;
		}
        else if (((choice is Instant as bool?) ?? false))
		{
			var a__ = (choice as Instant);
			var b__ = FHIRHelpers_4_0_001.ToDateTime(a__);
			var d__ = FHIRHelpers_4_0_001.ToDateTime(a__);
			var e__ = context.Operators;
			var f__ = e__.Interval(b__, d__, true, true);

			return f__;
		}
        else if (((choice is Age as bool?) ?? false))
		{
			var a__ = this.Patient();
			var b__ = a__.BirthDateElement;
			var c__ = FHIRHelpers_4_0_001.ToDate(b__);
			var d__ = (choice as Age);
			var e__ = (Quantity)d__;
			var f__ = FHIRHelpers_4_0_001.ToQuantity(e__);
			var g__ = context.Operators;
			var h__ = g__.Add(c__, f__);
			var j__ = a__.BirthDateElement;
			var k__ = FHIRHelpers_4_0_001.ToDate(j__);
			var m__ = (Quantity)d__;
			var n__ = FHIRHelpers_4_0_001.ToQuantity(m__);
			var p__ = g__.Add(k__, n__);
			var r__ = g__.Quantity(1m, "year");
			var t__ = g__.Add(p__, r__);
			var v__ = g__.Interval(h__, t__, true, false);
			var w__ = v__.low;
			var y__ = g__.ConvertDateToDateTime(w__);
			var aa__ = a__.BirthDateElement;
			var ab__ = FHIRHelpers_4_0_001.ToDate(aa__);
			var ad__ = (Quantity)d__;
			var ae__ = FHIRHelpers_4_0_001.ToQuantity(ad__);
			var ag__ = g__.Add(ab__, ae__);
			var ai__ = a__.BirthDateElement;
			var aj__ = FHIRHelpers_4_0_001.ToDate(ai__);
			var al__ = (Quantity)d__;
			var am__ = FHIRHelpers_4_0_001.ToQuantity(al__);
			var ao__ = g__.Add(aj__, am__);
			var aq__ = g__.Quantity(1m, "year");
			var as__ = g__.Add(ao__, aq__);
			var au__ = g__.Interval(ag__, as__, true, false);
			var av__ = au__.high;
			var ax__ = g__.ConvertDateToDateTime(av__);
			var az__ = a__.BirthDateElement;
			var ba__ = FHIRHelpers_4_0_001.ToDate(az__);
			var bc__ = (Quantity)d__;
			var bd__ = FHIRHelpers_4_0_001.ToQuantity(bc__);
			var bf__ = g__.Add(ba__, bd__);
			var bh__ = a__.BirthDateElement;
			var bi__ = FHIRHelpers_4_0_001.ToDate(bh__);
			var bk__ = (Quantity)d__;
			var bl__ = FHIRHelpers_4_0_001.ToQuantity(bk__);
			var bn__ = g__.Add(bi__, bl__);
			var bp__ = g__.Quantity(1m, "year");
			var br__ = g__.Add(bn__, bp__);
			var bt__ = g__.Interval(bf__, br__, true, false);
			var bu__ = bt__.lowClosed;
			var bw__ = a__.BirthDateElement;
			var bx__ = FHIRHelpers_4_0_001.ToDate(bw__);
			var bz__ = (Quantity)d__;
			var ca__ = FHIRHelpers_4_0_001.ToQuantity(bz__);
			var cc__ = g__.Add(bx__, ca__);
			var ce__ = a__.BirthDateElement;
			var cf__ = FHIRHelpers_4_0_001.ToDate(ce__);
			var ch__ = (Quantity)d__;
			var ci__ = FHIRHelpers_4_0_001.ToQuantity(ch__);
			var ck__ = g__.Add(cf__, ci__);
			var cm__ = g__.Quantity(1m, "year");
			var co__ = g__.Add(ck__, cm__);
			var cq__ = g__.Interval(cc__, co__, true, false);
			var cr__ = cq__.highClosed;
			var ct__ = g__.Interval(y__, ax__, bu__, cr__);

			return ct__;
		}
        else if (((choice is Range as bool?) ?? false))
		{
			var a__ = this.Patient();
			var b__ = a__.BirthDateElement;
			var c__ = FHIRHelpers_4_0_001.ToDate(b__);
			var d__ = (choice as Range);
			var e__ = d__.Low;
			var f__ = FHIRHelpers_4_0_001.ToQuantity(e__);
			var g__ = context.Operators;
			var h__ = g__.Add(c__, f__);
			var j__ = a__.BirthDateElement;
			var k__ = FHIRHelpers_4_0_001.ToDate(j__);
			var m__ = d__.High;
			var n__ = FHIRHelpers_4_0_001.ToQuantity(m__);
			var p__ = g__.Add(k__, n__);
			var r__ = g__.Quantity(1m, "year");
			var t__ = g__.Add(p__, r__);
			var v__ = g__.Interval(h__, t__, true, false);
			var w__ = v__.low;
			var y__ = g__.ConvertDateToDateTime(w__);
			var aa__ = a__.BirthDateElement;
			var ab__ = FHIRHelpers_4_0_001.ToDate(aa__);
			var ad__ = d__.Low;
			var ae__ = FHIRHelpers_4_0_001.ToQuantity(ad__);
			var ag__ = g__.Add(ab__, ae__);
			var ai__ = a__.BirthDateElement;
			var aj__ = FHIRHelpers_4_0_001.ToDate(ai__);
			var al__ = d__.High;
			var am__ = FHIRHelpers_4_0_001.ToQuantity(al__);
			var ao__ = g__.Add(aj__, am__);
			var aq__ = g__.Quantity(1m, "year");
			var as__ = g__.Add(ao__, aq__);
			var au__ = g__.Interval(ag__, as__, true, false);
			var av__ = au__.high;
			var ax__ = g__.ConvertDateToDateTime(av__);
			var az__ = a__.BirthDateElement;
			var ba__ = FHIRHelpers_4_0_001.ToDate(az__);
			var bc__ = d__.Low;
			var bd__ = FHIRHelpers_4_0_001.ToQuantity(bc__);
			var bf__ = g__.Add(ba__, bd__);
			var bh__ = a__.BirthDateElement;
			var bi__ = FHIRHelpers_4_0_001.ToDate(bh__);
			var bk__ = d__.High;
			var bl__ = FHIRHelpers_4_0_001.ToQuantity(bk__);
			var bn__ = g__.Add(bi__, bl__);
			var bp__ = g__.Quantity(1m, "year");
			var br__ = g__.Add(bn__, bp__);
			var bt__ = g__.Interval(bf__, br__, true, false);
			var bu__ = bt__.lowClosed;
			var bw__ = a__.BirthDateElement;
			var bx__ = FHIRHelpers_4_0_001.ToDate(bw__);
			var bz__ = d__.Low;
			var ca__ = FHIRHelpers_4_0_001.ToQuantity(bz__);
			var cc__ = g__.Add(bx__, ca__);
			var ce__ = a__.BirthDateElement;
			var cf__ = FHIRHelpers_4_0_001.ToDate(ce__);
			var ch__ = d__.High;
			var ci__ = FHIRHelpers_4_0_001.ToQuantity(ch__);
			var ck__ = g__.Add(cf__, ci__);
			var cm__ = g__.Quantity(1m, "year");
			var co__ = g__.Add(ck__, cm__);
			var cq__ = g__.Interval(cc__, co__, true, false);
			var cr__ = cq__.highClosed;
			var ct__ = g__.Interval(y__, ax__, bu__, cr__);

			return ct__;
		}
        else if (((choice is Timing as bool?) ?? false))
		{
			CqlInterval<CqlDateTime> a__ = null;
			var b__ = (a__ as CqlInterval<CqlDateTime>);
			var c__ = context.Operators;
			var d__ = c__.Message<CqlInterval<CqlDateTime>>(b__, "1", "Error", "Cannot compute a single interval from a Timing type");

			return d__;
		}
        else if (((choice is FhirString as bool?) ?? false))
		{
			CqlInterval<CqlDateTime> a__ = null;
			var b__ = (a__ as CqlInterval<CqlDateTime>);
			var c__ = context.Operators;
			var d__ = c__.Message<CqlInterval<CqlDateTime>>(b__, "1", "Error", "Cannot compute an interval from a String value");

			return d__;
		}
        else
		{
			CqlInterval<CqlDateTime> a__ = null;
			var b__ = (a__ as CqlInterval<CqlDateTime>);

			return b__;
		}
    }


    [CqlDeclaration("GetId")]
    public string GetId(string uri)
    {
        if ((context.Operators.Greater(context.Operators.PositionOf("/", uri), (int?)0) ?? false))
		{
			var a__ = context.Operators;
			var b__ = a__.Split(uri, "/");
			var d__ = a__.LastOfList<string>(b__);

			return d__;
		}
        else
            return uri;
    }


    [CqlDeclaration("VS Cast Function")]
    public IEnumerable<CqlCode> VS_Cast_Function(IEnumerable<CqlCode> VSet) =>
		VSet;


    [CqlDeclaration("First Dates per 31 Day Periods")]
    public Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT First_Dates_per_31_Day_Periods(IEnumerable<CqlDate> DateList)
	{
		var a_ = (CqlDate d) => d;
		var b_ = context.Operators;
		var c_ = b_.SelectOrNull<CqlDate, CqlDate>(DateList, a_);
		var e_ = b_.ListSort<CqlDate>(c_, System.ComponentModel.ListSortDirection.Ascending);
		var f_ = (CqlDate X) =>
		{
			var p_ = (X == null);
			var q_ = (bool?)p_;
			var r_ = context.Operators;
			var s_ = r_.Not(q_);

			return s_;
		};
		var h_ = b_.WhereOrNull<CqlDate>(e_, f_);
		var i_ = new Tuples.Tuple_GcLaDggiecCUAgUhQSXhADYJf
		{
			SortedDates = h_,
		};
		var j_ = new Tuples.Tuple_GcLaDggiecCUAgUhQSXhADYJf[]
		{
			i_,
		};
		var k_ = (Tuples.Tuple_GcLaDggiecCUAgUhQSXhADYJf SortedDates) =>
		{
			var t_ = SortedDates.SortedDates;
			var u_ = (int?)0;
			var v_ = new Tuples.Tuple_GTiMeVaPZjPXLPBaGARAOCFd
			{
				SortedList = t_,
				AnchorIndex = u_,
			};
			var w_ = new Tuples.Tuple_GTiMeVaPZjPXLPBaGARAOCFd[]
			{
				v_,
			};
			var x_ = (Tuples.Tuple_GTiMeVaPZjPXLPBaGARAOCFd AnchorList) =>
			{
				var ac_ = AnchorList.SortedList;
				var ad_ = AnchorList.AnchorIndex;
				var ae_ = context.Operators;
				var af_ = ae_.ListElementAt<CqlDate>(ac_, ad_);
				var ag_ = (af_ as CqlDate);
				var ah_ = (CqlDate X) =>
				{
					var av_ = AnchorList.SortedList;
					var aw_ = AnchorList.AnchorIndex;
					var ax_ = context.Operators;
					var ay_ = ax_.ListElementAt<CqlDate>(av_, aw_);
					var az_ = (ay_ as CqlDate);
					var bb_ = ax_.Quantity(1m, "day");
					var bd_ = ax_.Add(az_, bb_);
					var bh_ = ax_.ListElementAt<CqlDate>(av_, aw_);
					var bi_ = (bh_ as CqlDate);
					var bk_ = ax_.Quantity(30m, "days");
					var bm_ = ax_.Add(bi_, bk_);
					var bo_ = ax_.Interval(bd_, bm_, true, true);
					var bq_ = ax_.ElementInInterval<CqlDate>(X, bo_, null);
					var bs_ = ax_.Not(bq_);

					return bs_;
				};
				var aj_ = ae_.WhereOrNull<CqlDate>(DateList, ah_);
				var al_ = (int?)1;
				var an_ = ae_.Add(ad_, al_);
				var ao_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
				{
					NextDate = ag_,
					NewList = aj_,
					IndexofNewDate = an_,
				};
				var ap_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
				{
					ao_,
				};
				var aq_ = (Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT FirstList) => (((context.Operators.ListElementAt<CqlDate>(FirstList.NewList, FirstList.IndexofNewDate) == null))
					? (FirstList)
					: (context.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(context.Operators.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
								{
									new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
									{
										NextDate = (context.Operators.ListElementAt<CqlDate>(FirstList.NewList, FirstList.IndexofNewDate) as CqlDate),
										NewList = context.Operators.WhereOrNull<CqlDate>(FirstList.NewList, (CqlDate X) => context.Operators.Not(context.Operators.ElementInInterval<CqlDate>(X, context.Operators.Interval(context.Operators.Add((context.Operators.ListElementAt<CqlDate>(FirstList.NewList, FirstList.IndexofNewDate) as CqlDate), context.Operators.Quantity(1m, "day")), context.Operators.Add((context.Operators.ListElementAt<CqlDate>(FirstList.NewList, FirstList.IndexofNewDate) as CqlDate), context.Operators.Quantity(30m, "days")), true, true), null))),
										IndexofNewDate = context.Operators.Add(FirstList.IndexofNewDate, (int?)1),
									},
								}, (Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT SecondList) => (((context.Operators.ListElementAt<CqlDate>(SecondList.NewList, SecondList.IndexofNewDate) == null))
									? (SecondList)
									: (context.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(context.Operators.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
												{
													new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
													{
														NextDate = (context.Operators.ListElementAt<CqlDate>(SecondList.NewList, SecondList.IndexofNewDate) as CqlDate),
														NewList = context.Operators.WhereOrNull<CqlDate>(SecondList.NewList, (CqlDate X) => context.Operators.Not(context.Operators.ElementInInterval<CqlDate>(X, context.Operators.Interval(context.Operators.Add((context.Operators.ListElementAt<CqlDate>(SecondList.NewList, SecondList.IndexofNewDate) as CqlDate), context.Operators.Quantity(1m, "day")), context.Operators.Add((context.Operators.ListElementAt<CqlDate>(SecondList.NewList, SecondList.IndexofNewDate) as CqlDate), context.Operators.Quantity(30m, "days")), true, true), null))),
														IndexofNewDate = context.Operators.Add(SecondList.IndexofNewDate, (int?)1),
													},
												}, (Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT ThirdList) => (((context.Operators.ListElementAt<CqlDate>(ThirdList.NewList, ThirdList.IndexofNewDate) == null))
													? (ThirdList)
													: (context.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(context.Operators.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
																{
																	new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																	{
																		NextDate = (context.Operators.ListElementAt<CqlDate>(ThirdList.NewList, ThirdList.IndexofNewDate) as CqlDate),
																		NewList = context.Operators.WhereOrNull<CqlDate>(ThirdList.NewList, (CqlDate X) => context.Operators.Not(context.Operators.ElementInInterval<CqlDate>(X, context.Operators.Interval(context.Operators.Add((context.Operators.ListElementAt<CqlDate>(ThirdList.NewList, ThirdList.IndexofNewDate) as CqlDate), context.Operators.Quantity(1m, "day")), context.Operators.Add((context.Operators.ListElementAt<CqlDate>(ThirdList.NewList, ThirdList.IndexofNewDate) as CqlDate), context.Operators.Quantity(30m, "days")), true, true), null))),
																		IndexofNewDate = context.Operators.Add(ThirdList.IndexofNewDate, (int?)1),
																	},
																}, (Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT FourthList) => (((context.Operators.ListElementAt<CqlDate>(FourthList.NewList, FourthList.IndexofNewDate) == null))
																	? (FourthList)
																	: (context.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(context.Operators.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
																				{
																					new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																					{
																						NextDate = (context.Operators.ListElementAt<CqlDate>(FourthList.NewList, FourthList.IndexofNewDate) as CqlDate),
																						NewList = context.Operators.WhereOrNull<CqlDate>(FourthList.NewList, (CqlDate X) => context.Operators.Not(context.Operators.ElementInInterval<CqlDate>(X, context.Operators.Interval(context.Operators.Add((context.Operators.ListElementAt<CqlDate>(FourthList.NewList, FourthList.IndexofNewDate) as CqlDate), context.Operators.Quantity(1m, "day")), context.Operators.Add((context.Operators.ListElementAt<CqlDate>(FourthList.NewList, FourthList.IndexofNewDate) as CqlDate), context.Operators.Quantity(30m, "days")), true, true), null))),
																						IndexofNewDate = context.Operators.Add(FourthList.IndexofNewDate, (int?)1),
																					},
																				}, (Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT FifthList) => (((context.Operators.ListElementAt<CqlDate>(FifthList.NewList, FifthList.IndexofNewDate) == null))
																					? (FifthList)
																					: (context.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(context.Operators.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
																								{
																									new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																									{
																										NextDate = (context.Operators.ListElementAt<CqlDate>(FifthList.NewList, FifthList.IndexofNewDate) as CqlDate),
																										NewList = context.Operators.WhereOrNull<CqlDate>(FifthList.NewList, (CqlDate X) => context.Operators.Not(context.Operators.ElementInInterval<CqlDate>(X, context.Operators.Interval(context.Operators.Add((context.Operators.ListElementAt<CqlDate>(FifthList.NewList, FifthList.IndexofNewDate) as CqlDate), context.Operators.Quantity(1m, "day")), context.Operators.Add((context.Operators.ListElementAt<CqlDate>(FifthList.NewList, FifthList.IndexofNewDate) as CqlDate), context.Operators.Quantity(30m, "days")), true, true), null))),
																										IndexofNewDate = context.Operators.Add(FifthList.IndexofNewDate, (int?)1),
																									},
																								}, (Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT SixthList) => (((context.Operators.ListElementAt<CqlDate>(SixthList.NewList, SixthList.IndexofNewDate) == null))
																									? (SixthList)
																									: (context.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(context.Operators.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
																												{
																													new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																													{
																														NextDate = (context.Operators.ListElementAt<CqlDate>(SixthList.NewList, SixthList.IndexofNewDate) as CqlDate),
																														NewList = context.Operators.WhereOrNull<CqlDate>(SixthList.NewList, (CqlDate X) => context.Operators.Not(context.Operators.ElementInInterval<CqlDate>(X, context.Operators.Interval(context.Operators.Add((context.Operators.ListElementAt<CqlDate>(SixthList.NewList, SixthList.IndexofNewDate) as CqlDate), context.Operators.Quantity(1m, "day")), context.Operators.Add((context.Operators.ListElementAt<CqlDate>(SixthList.NewList, SixthList.IndexofNewDate) as CqlDate), context.Operators.Quantity(30m, "days")), true, true), null))),
																														IndexofNewDate = context.Operators.Add(SixthList.IndexofNewDate, (int?)1),
																													},
																												}, (Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT SeventhList) => (((context.Operators.ListElementAt<CqlDate>(SeventhList.NewList, SeventhList.IndexofNewDate) == null))
																													? (SeventhList)
																													: (context.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(context.Operators.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
																																{
																																	new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																																	{
																																		NextDate = (context.Operators.ListElementAt<CqlDate>(SeventhList.NewList, SeventhList.IndexofNewDate) as CqlDate),
																																		NewList = context.Operators.WhereOrNull<CqlDate>(SeventhList.NewList, (CqlDate X) => context.Operators.Not(context.Operators.ElementInInterval<CqlDate>(X, context.Operators.Interval(context.Operators.Add((context.Operators.ListElementAt<CqlDate>(SeventhList.NewList, SeventhList.IndexofNewDate) as CqlDate), context.Operators.Quantity(1m, "day")), context.Operators.Add((context.Operators.ListElementAt<CqlDate>(SeventhList.NewList, SeventhList.IndexofNewDate) as CqlDate), context.Operators.Quantity(30m, "days")), true, true), null))),
																																		IndexofNewDate = context.Operators.Add(SeventhList.IndexofNewDate, (int?)1),
																																	},
																																}, (Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT EighthList) => (((context.Operators.ListElementAt<CqlDate>(EighthList.NewList, EighthList.IndexofNewDate) == null))
																																	? (EighthList)
																																	: (context.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(context.Operators.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
																																				{
																																					new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																																					{
																																						NextDate = (context.Operators.ListElementAt<CqlDate>(EighthList.NewList, EighthList.IndexofNewDate) as CqlDate),
																																						NewList = context.Operators.WhereOrNull<CqlDate>(EighthList.NewList, (CqlDate X) => context.Operators.Not(context.Operators.ElementInInterval<CqlDate>(X, context.Operators.Interval(context.Operators.Add((context.Operators.ListElementAt<CqlDate>(EighthList.NewList, EighthList.IndexofNewDate) as CqlDate), context.Operators.Quantity(1m, "day")), context.Operators.Add((context.Operators.ListElementAt<CqlDate>(EighthList.NewList, EighthList.IndexofNewDate) as CqlDate), context.Operators.Quantity(30m, "days")), true, true), null))),
																																						IndexofNewDate = context.Operators.Add(EighthList.IndexofNewDate, (int?)1),
																																					},
																																				}, (Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT NinethList) => (((context.Operators.ListElementAt<CqlDate>(NinethList.NewList, NinethList.IndexofNewDate) == null))
																																					? (NinethList)
																																					: (context.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(context.Operators.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
																																								{
																																									new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																																									{
																																										NextDate = (context.Operators.ListElementAt<CqlDate>(NinethList.NewList, NinethList.IndexofNewDate) as CqlDate),
																																										NewList = context.Operators.WhereOrNull<CqlDate>(NinethList.NewList, (CqlDate X) => context.Operators.Not(context.Operators.ElementInInterval<CqlDate>(X, context.Operators.Interval(context.Operators.Add((context.Operators.ListElementAt<CqlDate>(NinethList.NewList, NinethList.IndexofNewDate) as CqlDate), context.Operators.Quantity(1m, "day")), context.Operators.Add((context.Operators.ListElementAt<CqlDate>(NinethList.NewList, NinethList.IndexofNewDate) as CqlDate), context.Operators.Quantity(30m, "days")), true, true), null))),
																																										IndexofNewDate = context.Operators.Add(NinethList.IndexofNewDate, (int?)1),
																																									},
																																								}, (Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT TenthList) => (((context.Operators.ListElementAt<CqlDate>(TenthList.NewList, TenthList.IndexofNewDate) == null))
																																									? (TenthList)
																																									: (context.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(context.Operators.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
																																												{
																																													new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																																													{
																																														NextDate = (context.Operators.ListElementAt<CqlDate>(TenthList.NewList, TenthList.IndexofNewDate) as CqlDate),
																																														NewList = context.Operators.WhereOrNull<CqlDate>(TenthList.NewList, (CqlDate X) => context.Operators.Not(context.Operators.ElementInInterval<CqlDate>(X, context.Operators.Interval(context.Operators.Add((context.Operators.ListElementAt<CqlDate>(TenthList.NewList, TenthList.IndexofNewDate) as CqlDate), context.Operators.Quantity(1m, "day")), context.Operators.Add((context.Operators.ListElementAt<CqlDate>(TenthList.NewList, TenthList.IndexofNewDate) as CqlDate), context.Operators.Quantity(30m, "days")), true, true), null))),
																																														IndexofNewDate = context.Operators.Add(TenthList.IndexofNewDate, (int?)1),
																																													},
																																												}, (Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT EleventhList) => (((context.Operators.ListElementAt<CqlDate>(EleventhList.NewList, EleventhList.IndexofNewDate) == null))
																																													? (EleventhList)
																																													: (new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																																														{
																																															NextDate = (context.Operators.ListElementAt<CqlDate>(EleventhList.NewList, EleventhList.IndexofNewDate) as CqlDate),
																																															NewList = context.Operators.WhereOrNull<CqlDate>(EleventhList.NewList, (CqlDate X) => context.Operators.Not(context.Operators.ElementInInterval<CqlDate>(X, context.Operators.Interval(context.Operators.Add((context.Operators.ListElementAt<CqlDate>(EleventhList.NewList, EleventhList.IndexofNewDate) as CqlDate), context.Operators.Quantity(1m, "day")), context.Operators.Add((context.Operators.ListElementAt<CqlDate>(EleventhList.NewList, EleventhList.IndexofNewDate) as CqlDate), context.Operators.Quantity(30m, "days")), true, true), null))),
																																															IndexofNewDate = context.Operators.Add(EleventhList.IndexofNewDate, (int?)1),
																																														}))
))))
))))
))))
))))
))))
))))
))))
))))
))))
))))
;
				var as_ = ae_.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(ap_, aq_);
				var au_ = ae_.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(as_);

				return au_;
			};
			var y_ = context.Operators;
			var z_ = y_.SelectOrNull<Tuples.Tuple_GTiMeVaPZjPXLPBaGARAOCFd, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(w_, x_);
			var ab_ = y_.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(z_);

			return ab_;
		};
		var m_ = b_.SelectOrNull<Tuples.Tuple_GcLaDggiecCUAgUhQSXhADYJf, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(j_, k_);
		var o_ = b_.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(m_);

		return o_;
	}


}