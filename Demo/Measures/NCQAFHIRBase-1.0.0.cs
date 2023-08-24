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
		var a_ = context?.DataRetriever.RetrieveByValueSet<Patient>(null, null);

		return context?.Operators.SingleOrNull<Patient>(a_);
	}

    [CqlDeclaration("Patient")]
    public Patient Patient() => __Patient.Value;

    [CqlDeclaration("Normalize Onset")]
    public CqlInterval<CqlDateTime> Normalize_Onset(object onset)
    {
        if (((onset is FhirDateTime as bool?) ?? false))
		{
			var a__ = FHIRHelpers_4_0_001.ToDateTime((onset as FhirDateTime));
			var b__ = FHIRHelpers_4_0_001.ToDateTime((onset as FhirDateTime));

			return context?.Operators.Interval(a__, b__, true, true);
		}
        else if (((onset is Period as bool?) ?? false))
		{
			var a__ = context?.Operators.LateBoundProperty<FhirDateTime>(onset, "start");
			var b__ = a__?.Value;
			var c__ = context?.Operators.ConvertStringToDateTime(b__);
			var d__ = context?.Operators.LateBoundProperty<FhirDateTime>(onset, "end");
			var e__ = d__?.Value;
			var f__ = context?.Operators.ConvertStringToDateTime(e__);

			return context?.Operators.Interval(c__, f__, true, true);
		}
        else if (((onset is FhirString as bool?) ?? false))
		{
			CqlInterval<CqlDateTime> a__ = null;
			var b__ = (a__ as CqlInterval<CqlDateTime>);

			return context?.Operators.Message<CqlInterval<CqlDateTime>>(b__, "1", "Error", "Cannot compute an interval from a String value");
		}
        else
		{
			var a__ = ((((onset is Age as bool?) ?? false))
	? (context?.Operators.Interval(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((Quantity)(onset as Age))), context?.Operators.Add(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((Quantity)(onset as Age))), context?.Operators.Quantity(1m, "year")), true, false))
	: (((((onset is Range as bool?) ?? false))
			? (context?.Operators.Interval(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((onset as Range)?.Low)), context?.Operators.Add(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((onset as Range)?.High)), context?.Operators.Quantity(1m, "year")), true, false))
			: ((null as CqlInterval<CqlDate>)))
))
?.low;
			var b__ = context?.Operators.ConvertDateToDateTime(a__);
			var c__ = ((((onset is Age as bool?) ?? false))
	? (context?.Operators.Interval(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((Quantity)(onset as Age))), context?.Operators.Add(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((Quantity)(onset as Age))), context?.Operators.Quantity(1m, "year")), true, false))
	: (((((onset is Range as bool?) ?? false))
			? (context?.Operators.Interval(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((onset as Range)?.Low)), context?.Operators.Add(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((onset as Range)?.High)), context?.Operators.Quantity(1m, "year")), true, false))
			: ((null as CqlInterval<CqlDate>)))
))
?.high;
			var d__ = context?.Operators.ConvertDateToDateTime(c__);
			var e__ = ((((onset is Age as bool?) ?? false))
	? (context?.Operators.Interval(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((Quantity)(onset as Age))), context?.Operators.Add(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((Quantity)(onset as Age))), context?.Operators.Quantity(1m, "year")), true, false))
	: (((((onset is Range as bool?) ?? false))
			? (context?.Operators.Interval(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((onset as Range)?.Low)), context?.Operators.Add(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((onset as Range)?.High)), context?.Operators.Quantity(1m, "year")), true, false))
			: ((null as CqlInterval<CqlDate>)))
))
?.lowClosed;
			var f__ = ((((onset is Age as bool?) ?? false))
	? (context?.Operators.Interval(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((Quantity)(onset as Age))), context?.Operators.Add(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((Quantity)(onset as Age))), context?.Operators.Quantity(1m, "year")), true, false))
	: (((((onset is Range as bool?) ?? false))
			? (context?.Operators.Interval(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((onset as Range)?.Low)), context?.Operators.Add(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((onset as Range)?.High)), context?.Operators.Quantity(1m, "year")), true, false))
			: ((null as CqlInterval<CqlDate>)))
))
?.highClosed;

			return context?.Operators.Interval(b__, d__, e__, f__);
		}
    }


    [CqlDeclaration("Normalize Abatement")]
    public CqlInterval<CqlDateTime> Normalize_Abatement(object abatement)
    {
        if (((abatement is FhirDateTime as bool?) ?? false))
		{
			var a__ = FHIRHelpers_4_0_001.ToDateTime((abatement as FhirDateTime));
			var b__ = FHIRHelpers_4_0_001.ToDateTime((abatement as FhirDateTime));

			return context?.Operators.Interval(a__, b__, true, true);
		}
        else if (((abatement is Period as bool?) ?? false))
		{
			var a__ = context?.Operators.LateBoundProperty<FhirDateTime>(abatement, "start");
			var b__ = a__?.Value;
			var c__ = context?.Operators.ConvertStringToDateTime(b__);
			var d__ = context?.Operators.LateBoundProperty<FhirDateTime>(abatement, "end");
			var e__ = d__?.Value;
			var f__ = context?.Operators.ConvertStringToDateTime(e__);

			return context?.Operators.Interval(c__, f__, true, true);
		}
        else if (((abatement is FhirString as bool?) ?? false))
		{
			CqlInterval<CqlDateTime> a__ = null;
			var b__ = (a__ as CqlInterval<CqlDateTime>);

			return context?.Operators.Message<CqlInterval<CqlDateTime>>(b__, "1", "Error", "Cannot compute an interval from a String value");
		}
        else
		{
			var a__ = ((((abatement is Age as bool?) ?? false))
	? (context?.Operators.Interval(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((Quantity)(abatement as Age))), context?.Operators.Add(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((Quantity)(abatement as Age))), context?.Operators.Quantity(1m, "year")), true, false))
	: (((((abatement is Range as bool?) ?? false))
			? (context?.Operators.Interval(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((abatement as Range)?.Low)), context?.Operators.Add(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((abatement as Range)?.High)), context?.Operators.Quantity(1m, "year")), true, false))
			: ((null as CqlInterval<CqlDate>)))
))
?.low;
			var b__ = context?.Operators.ConvertDateToDateTime(a__);
			var c__ = ((((abatement is Age as bool?) ?? false))
	? (context?.Operators.Interval(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((Quantity)(abatement as Age))), context?.Operators.Add(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((Quantity)(abatement as Age))), context?.Operators.Quantity(1m, "year")), true, false))
	: (((((abatement is Range as bool?) ?? false))
			? (context?.Operators.Interval(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((abatement as Range)?.Low)), context?.Operators.Add(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((abatement as Range)?.High)), context?.Operators.Quantity(1m, "year")), true, false))
			: ((null as CqlInterval<CqlDate>)))
))
?.high;
			var d__ = context?.Operators.ConvertDateToDateTime(c__);
			var e__ = ((((abatement is Age as bool?) ?? false))
	? (context?.Operators.Interval(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((Quantity)(abatement as Age))), context?.Operators.Add(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((Quantity)(abatement as Age))), context?.Operators.Quantity(1m, "year")), true, false))
	: (((((abatement is Range as bool?) ?? false))
			? (context?.Operators.Interval(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((abatement as Range)?.Low)), context?.Operators.Add(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((abatement as Range)?.High)), context?.Operators.Quantity(1m, "year")), true, false))
			: ((null as CqlInterval<CqlDate>)))
))
?.lowClosed;
			var f__ = ((((abatement is Age as bool?) ?? false))
	? (context?.Operators.Interval(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((Quantity)(abatement as Age))), context?.Operators.Add(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((Quantity)(abatement as Age))), context?.Operators.Quantity(1m, "year")), true, false))
	: (((((abatement is Range as bool?) ?? false))
			? (context?.Operators.Interval(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((abatement as Range)?.Low)), context?.Operators.Add(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((abatement as Range)?.High)), context?.Operators.Quantity(1m, "year")), true, false))
			: ((null as CqlInterval<CqlDate>)))
))
?.highClosed;

			return context?.Operators.Interval(b__, d__, e__, f__);
		}
    }


    [CqlDeclaration("Prevalence Period")]
    public CqlInterval<CqlDateTime> Prevalence_Period(Condition condition)
	{
		var a_ = condition?.Onset;
		var b_ = (a_ as object);
		var c_ = this.Normalize_Onset(b_);
		var d_ = context?.Operators.Start(c_);
		var e_ = condition?.Abatement;
		var f_ = (e_ as object);
		var g_ = this.Normalize_Abatement(f_);
		var h_ = context?.Operators.End(g_);

		return context?.Operators.Interval(d_, h_, true, true);
	}


    [CqlDeclaration("Normalize Interval")]
    public CqlInterval<CqlDateTime> Normalize_Interval(object choice)
    {
        if (((choice is FhirDateTime as bool?) ?? false))
		{
			var a__ = FHIRHelpers_4_0_001.ToDateTime((choice as FhirDateTime));
			var b__ = FHIRHelpers_4_0_001.ToDateTime((choice as FhirDateTime));

			return context?.Operators.Interval(a__, b__, true, true);
		}
        else if (((choice is Date as bool?) ?? false))
		{
			var a__ = FHIRHelpers_4_0_001.ToDate((choice as Date));
			var b__ = context?.Operators.ConvertDateToDateTime(a__);
			var c__ = FHIRHelpers_4_0_001.ToDate((choice as Date));
			var d__ = context?.Operators.ConvertDateToDateTime(c__);

			return context?.Operators.Interval(b__, d__, true, true);
		}
        else if (((choice is Period as bool?) ?? false))
		{
			var a__ = context?.Operators.LateBoundProperty<FhirDateTime>(choice, "start");
			var b__ = a__?.Value;
			var c__ = context?.Operators.ConvertStringToDateTime(b__);
			var d__ = context?.Operators.LateBoundProperty<FhirDateTime>(choice, "end");
			var e__ = d__?.Value;
			var f__ = context?.Operators.ConvertStringToDateTime(e__);

			return context?.Operators.Interval(c__, f__, true, true);
		}
        else if (((choice is Instant as bool?) ?? false))
		{
			var a__ = FHIRHelpers_4_0_001.ToDateTime((choice as Instant));
			var b__ = FHIRHelpers_4_0_001.ToDateTime((choice as Instant));

			return context?.Operators.Interval(a__, b__, true, true);
		}
        else if (((choice is Age as bool?) ?? false))
		{
			var a__ = this.Patient();
			var b__ = a__?.BirthDateElement;
			var c__ = FHIRHelpers_4_0_001.ToDate(b__);
			var d__ = (choice as Age);
			var e__ = (Quantity)d__;
			var f__ = FHIRHelpers_4_0_001.ToQuantity(e__);
			var g__ = context?.Operators.Add(c__, f__);
			var h__ = this.Patient();
			var i__ = h__?.BirthDateElement;
			var j__ = FHIRHelpers_4_0_001.ToDate(i__);
			var k__ = (choice as Age);
			var l__ = (Quantity)k__;
			var m__ = FHIRHelpers_4_0_001.ToQuantity(l__);
			var n__ = context?.Operators.Add(j__, m__);
			var o__ = context?.Operators.Quantity(1m, "year");
			var p__ = context?.Operators.Add(n__, o__);
			var q__ = context?.Operators.Interval(g__, p__, true, false);
			var r__ = q__?.low;
			var s__ = context?.Operators.ConvertDateToDateTime(r__);
			var t__ = this.Patient();
			var u__ = t__?.BirthDateElement;
			var v__ = FHIRHelpers_4_0_001.ToDate(u__);
			var w__ = (choice as Age);
			var x__ = (Quantity)w__;
			var y__ = FHIRHelpers_4_0_001.ToQuantity(x__);
			var z__ = context?.Operators.Add(v__, y__);
			var aa__ = this.Patient();
			var ab__ = aa__?.BirthDateElement;
			var ac__ = FHIRHelpers_4_0_001.ToDate(ab__);
			var ad__ = (choice as Age);
			var ae__ = (Quantity)ad__;
			var af__ = FHIRHelpers_4_0_001.ToQuantity(ae__);
			var ag__ = context?.Operators.Add(ac__, af__);
			var ah__ = context?.Operators.Quantity(1m, "year");
			var ai__ = context?.Operators.Add(ag__, ah__);
			var aj__ = context?.Operators.Interval(z__, ai__, true, false);
			var ak__ = aj__?.high;
			var al__ = context?.Operators.ConvertDateToDateTime(ak__);
			var am__ = this.Patient();
			var an__ = am__?.BirthDateElement;
			var ao__ = FHIRHelpers_4_0_001.ToDate(an__);
			var ap__ = (choice as Age);
			var aq__ = (Quantity)ap__;
			var ar__ = FHIRHelpers_4_0_001.ToQuantity(aq__);
			var as__ = context?.Operators.Add(ao__, ar__);
			var at__ = this.Patient();
			var au__ = at__?.BirthDateElement;
			var av__ = FHIRHelpers_4_0_001.ToDate(au__);
			var aw__ = (choice as Age);
			var ax__ = (Quantity)aw__;
			var ay__ = FHIRHelpers_4_0_001.ToQuantity(ax__);
			var az__ = context?.Operators.Add(av__, ay__);
			var ba__ = context?.Operators.Quantity(1m, "year");
			var bb__ = context?.Operators.Add(az__, ba__);
			var bc__ = context?.Operators.Interval(as__, bb__, true, false);
			var bd__ = bc__?.lowClosed;
			var be__ = this.Patient();
			var bf__ = be__?.BirthDateElement;
			var bg__ = FHIRHelpers_4_0_001.ToDate(bf__);
			var bh__ = (choice as Age);
			var bi__ = (Quantity)bh__;
			var bj__ = FHIRHelpers_4_0_001.ToQuantity(bi__);
			var bk__ = context?.Operators.Add(bg__, bj__);
			var bl__ = this.Patient();
			var bm__ = bl__?.BirthDateElement;
			var bn__ = FHIRHelpers_4_0_001.ToDate(bm__);
			var bo__ = (choice as Age);
			var bp__ = (Quantity)bo__;
			var bq__ = FHIRHelpers_4_0_001.ToQuantity(bp__);
			var br__ = context?.Operators.Add(bn__, bq__);
			var bs__ = context?.Operators.Quantity(1m, "year");
			var bt__ = context?.Operators.Add(br__, bs__);
			var bu__ = context?.Operators.Interval(bk__, bt__, true, false);
			var bv__ = bu__?.highClosed;

			return context?.Operators.Interval(s__, al__, bd__, bv__);
		}
        else if (((choice is Range as bool?) ?? false))
		{
			var a__ = this.Patient();
			var b__ = a__?.BirthDateElement;
			var c__ = FHIRHelpers_4_0_001.ToDate(b__);
			var d__ = (choice as Range)?.Low;
			var e__ = FHIRHelpers_4_0_001.ToQuantity(d__);
			var f__ = context?.Operators.Add(c__, e__);
			var g__ = this.Patient();
			var h__ = g__?.BirthDateElement;
			var i__ = FHIRHelpers_4_0_001.ToDate(h__);
			var j__ = (choice as Range)?.High;
			var k__ = FHIRHelpers_4_0_001.ToQuantity(j__);
			var l__ = context?.Operators.Add(i__, k__);
			var m__ = context?.Operators.Quantity(1m, "year");
			var n__ = context?.Operators.Add(l__, m__);
			var o__ = context?.Operators.Interval(f__, n__, true, false);
			var p__ = o__?.low;
			var q__ = context?.Operators.ConvertDateToDateTime(p__);
			var r__ = this.Patient();
			var s__ = r__?.BirthDateElement;
			var t__ = FHIRHelpers_4_0_001.ToDate(s__);
			var u__ = (choice as Range)?.Low;
			var v__ = FHIRHelpers_4_0_001.ToQuantity(u__);
			var w__ = context?.Operators.Add(t__, v__);
			var x__ = this.Patient();
			var y__ = x__?.BirthDateElement;
			var z__ = FHIRHelpers_4_0_001.ToDate(y__);
			var aa__ = (choice as Range)?.High;
			var ab__ = FHIRHelpers_4_0_001.ToQuantity(aa__);
			var ac__ = context?.Operators.Add(z__, ab__);
			var ad__ = context?.Operators.Quantity(1m, "year");
			var ae__ = context?.Operators.Add(ac__, ad__);
			var af__ = context?.Operators.Interval(w__, ae__, true, false);
			var ag__ = af__?.high;
			var ah__ = context?.Operators.ConvertDateToDateTime(ag__);
			var ai__ = this.Patient();
			var aj__ = ai__?.BirthDateElement;
			var ak__ = FHIRHelpers_4_0_001.ToDate(aj__);
			var al__ = (choice as Range)?.Low;
			var am__ = FHIRHelpers_4_0_001.ToQuantity(al__);
			var an__ = context?.Operators.Add(ak__, am__);
			var ao__ = this.Patient();
			var ap__ = ao__?.BirthDateElement;
			var aq__ = FHIRHelpers_4_0_001.ToDate(ap__);
			var ar__ = (choice as Range)?.High;
			var as__ = FHIRHelpers_4_0_001.ToQuantity(ar__);
			var at__ = context?.Operators.Add(aq__, as__);
			var au__ = context?.Operators.Quantity(1m, "year");
			var av__ = context?.Operators.Add(at__, au__);
			var aw__ = context?.Operators.Interval(an__, av__, true, false);
			var ax__ = aw__?.lowClosed;
			var ay__ = this.Patient();
			var az__ = ay__?.BirthDateElement;
			var ba__ = FHIRHelpers_4_0_001.ToDate(az__);
			var bb__ = (choice as Range)?.Low;
			var bc__ = FHIRHelpers_4_0_001.ToQuantity(bb__);
			var bd__ = context?.Operators.Add(ba__, bc__);
			var be__ = this.Patient();
			var bf__ = be__?.BirthDateElement;
			var bg__ = FHIRHelpers_4_0_001.ToDate(bf__);
			var bh__ = (choice as Range)?.High;
			var bi__ = FHIRHelpers_4_0_001.ToQuantity(bh__);
			var bj__ = context?.Operators.Add(bg__, bi__);
			var bk__ = context?.Operators.Quantity(1m, "year");
			var bl__ = context?.Operators.Add(bj__, bk__);
			var bm__ = context?.Operators.Interval(bd__, bl__, true, false);
			var bn__ = bm__?.highClosed;

			return context?.Operators.Interval(q__, ah__, ax__, bn__);
		}
        else if (((choice is Timing as bool?) ?? false))
		{
			CqlInterval<CqlDateTime> a__ = null;
			var b__ = (a__ as CqlInterval<CqlDateTime>);

			return context?.Operators.Message<CqlInterval<CqlDateTime>>(b__, "1", "Error", "Cannot compute a single interval from a Timing type");
		}
        else if (((choice is FhirString as bool?) ?? false))
		{
			CqlInterval<CqlDateTime> a__ = null;
			var b__ = (a__ as CqlInterval<CqlDateTime>);

			return context?.Operators.Message<CqlInterval<CqlDateTime>>(b__, "1", "Error", "Cannot compute an interval from a String value");
		}
        else
		{
			CqlInterval<CqlDateTime> a__ = null;

			return (a__ as CqlInterval<CqlDateTime>);
		}
    }


    [CqlDeclaration("GetId")]
    public string GetId(string uri)
    {
        if ((context?.Operators.Greater(context?.Operators.PositionOf("/", uri), (int?)0) ?? false))
		{
			var a__ = context?.Operators.Split(uri, "/");

			return context?.Operators.LastOfList<string>(a__);
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
		var ai_ = (CqlDate d) => d;
		var aj_ = context?.Operators.SelectOrNull<CqlDate, CqlDate>(DateList, ai_);
		var ak_ = context?.Operators.ListSort<CqlDate>(aj_, System.ComponentModel.ListSortDirection.Ascending);
		var al_ = (CqlDate X) =>
		{
			var a_ = (X == null);
			var b_ = (bool?)a_;

			return context?.Operators.Not(b_);
		};
		var am_ = context?.Operators.WhereOrNull<CqlDate>(ak_, al_);
		var an_ = new Tuples.Tuple_GcLaDggiecCUAgUhQSXhADYJf
		{
			SortedDates = am_,
		};
		var ao_ = new Tuples.Tuple_GcLaDggiecCUAgUhQSXhADYJf[]
		{
			an_,
		};
		var ap_ = (Tuples.Tuple_GcLaDggiecCUAgUhQSXhADYJf SortedDates) =>
		{
			var ac_ = SortedDates?.SortedDates;
			var ad_ = (int?)0;
			var ae_ = new Tuples.Tuple_GTiMeVaPZjPXLPBaGARAOCFd
			{
				SortedList = ac_,
				AnchorIndex = ad_,
			};
			var af_ = new Tuples.Tuple_GTiMeVaPZjPXLPBaGARAOCFd[]
			{
				ae_,
			};
			var ag_ = (Tuples.Tuple_GTiMeVaPZjPXLPBaGARAOCFd AnchorList) =>
			{
				var q_ = AnchorList?.SortedList;
				var r_ = AnchorList?.AnchorIndex;
				var s_ = context?.Operators.ListElementAt<CqlDate>(q_, r_);
				var t_ = (s_ as CqlDate);
				var u_ = (CqlDate X) =>
				{
					var c_ = AnchorList?.SortedList;
					var d_ = AnchorList?.AnchorIndex;
					var e_ = context?.Operators.ListElementAt<CqlDate>(c_, d_);
					var f_ = (e_ as CqlDate);
					var g_ = context?.Operators.Quantity(1m, "day");
					var h_ = context?.Operators.Add(f_, g_);
					var i_ = AnchorList?.SortedList;
					var j_ = AnchorList?.AnchorIndex;
					var k_ = context?.Operators.ListElementAt<CqlDate>(i_, j_);
					var l_ = (k_ as CqlDate);
					var m_ = context?.Operators.Quantity(30m, "days");
					var n_ = context?.Operators.Add(l_, m_);
					var o_ = context?.Operators.Interval(h_, n_, true, true);
					var p_ = context?.Operators.ElementInInterval<CqlDate>(X, o_, null);

					return context?.Operators.Not(p_);
				};
				var v_ = context?.Operators.WhereOrNull<CqlDate>(DateList, u_);
				var w_ = AnchorList?.AnchorIndex;
				var x_ = context?.Operators.Add(w_, (int?)1);
				var y_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
				{
					NextDate = t_,
					NewList = v_,
					IndexofNewDate = x_,
				};
				var z_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
				{
					y_,
				};
				var aa_ = (Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT FirstList) => (((context?.Operators.ListElementAt<CqlDate>(FirstList?.NewList, FirstList?.IndexofNewDate) == null))
					? (FirstList)
					: (context?.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(context?.Operators.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
								{
									new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
									{
										NextDate = (context?.Operators.ListElementAt<CqlDate>(FirstList?.NewList, FirstList?.IndexofNewDate) as CqlDate),
										NewList = context?.Operators.WhereOrNull<CqlDate>(FirstList?.NewList, (CqlDate X) => context?.Operators.Not(context?.Operators.ElementInInterval<CqlDate>(X, context?.Operators.Interval(context?.Operators.Add((context?.Operators.ListElementAt<CqlDate>(FirstList?.NewList, FirstList?.IndexofNewDate) as CqlDate), context?.Operators.Quantity(1m, "day")), context?.Operators.Add((context?.Operators.ListElementAt<CqlDate>(FirstList?.NewList, FirstList?.IndexofNewDate) as CqlDate), context?.Operators.Quantity(30m, "days")), true, true), null))),
										IndexofNewDate = context?.Operators.Add(FirstList?.IndexofNewDate, (int?)1),
									},
								}, (Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT SecondList) => (((context?.Operators.ListElementAt<CqlDate>(SecondList?.NewList, SecondList?.IndexofNewDate) == null))
									? (SecondList)
									: (context?.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(context?.Operators.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
												{
													new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
													{
														NextDate = (context?.Operators.ListElementAt<CqlDate>(SecondList?.NewList, SecondList?.IndexofNewDate) as CqlDate),
														NewList = context?.Operators.WhereOrNull<CqlDate>(SecondList?.NewList, (CqlDate X) => context?.Operators.Not(context?.Operators.ElementInInterval<CqlDate>(X, context?.Operators.Interval(context?.Operators.Add((context?.Operators.ListElementAt<CqlDate>(SecondList?.NewList, SecondList?.IndexofNewDate) as CqlDate), context?.Operators.Quantity(1m, "day")), context?.Operators.Add((context?.Operators.ListElementAt<CqlDate>(SecondList?.NewList, SecondList?.IndexofNewDate) as CqlDate), context?.Operators.Quantity(30m, "days")), true, true), null))),
														IndexofNewDate = context?.Operators.Add(SecondList?.IndexofNewDate, (int?)1),
													},
												}, (Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT ThirdList) => (((context?.Operators.ListElementAt<CqlDate>(ThirdList?.NewList, ThirdList?.IndexofNewDate) == null))
													? (ThirdList)
													: (context?.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(context?.Operators.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
																{
																	new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																	{
																		NextDate = (context?.Operators.ListElementAt<CqlDate>(ThirdList?.NewList, ThirdList?.IndexofNewDate) as CqlDate),
																		NewList = context?.Operators.WhereOrNull<CqlDate>(ThirdList?.NewList, (CqlDate X) => context?.Operators.Not(context?.Operators.ElementInInterval<CqlDate>(X, context?.Operators.Interval(context?.Operators.Add((context?.Operators.ListElementAt<CqlDate>(ThirdList?.NewList, ThirdList?.IndexofNewDate) as CqlDate), context?.Operators.Quantity(1m, "day")), context?.Operators.Add((context?.Operators.ListElementAt<CqlDate>(ThirdList?.NewList, ThirdList?.IndexofNewDate) as CqlDate), context?.Operators.Quantity(30m, "days")), true, true), null))),
																		IndexofNewDate = context?.Operators.Add(ThirdList?.IndexofNewDate, (int?)1),
																	},
																}, (Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT FourthList) => (((context?.Operators.ListElementAt<CqlDate>(FourthList?.NewList, FourthList?.IndexofNewDate) == null))
																	? (FourthList)
																	: (context?.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(context?.Operators.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
																				{
																					new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																					{
																						NextDate = (context?.Operators.ListElementAt<CqlDate>(FourthList?.NewList, FourthList?.IndexofNewDate) as CqlDate),
																						NewList = context?.Operators.WhereOrNull<CqlDate>(FourthList?.NewList, (CqlDate X) => context?.Operators.Not(context?.Operators.ElementInInterval<CqlDate>(X, context?.Operators.Interval(context?.Operators.Add((context?.Operators.ListElementAt<CqlDate>(FourthList?.NewList, FourthList?.IndexofNewDate) as CqlDate), context?.Operators.Quantity(1m, "day")), context?.Operators.Add((context?.Operators.ListElementAt<CqlDate>(FourthList?.NewList, FourthList?.IndexofNewDate) as CqlDate), context?.Operators.Quantity(30m, "days")), true, true), null))),
																						IndexofNewDate = context?.Operators.Add(FourthList?.IndexofNewDate, (int?)1),
																					},
																				}, (Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT FifthList) => (((context?.Operators.ListElementAt<CqlDate>(FifthList?.NewList, FifthList?.IndexofNewDate) == null))
																					? (FifthList)
																					: (context?.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(context?.Operators.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
																								{
																									new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																									{
																										NextDate = (context?.Operators.ListElementAt<CqlDate>(FifthList?.NewList, FifthList?.IndexofNewDate) as CqlDate),
																										NewList = context?.Operators.WhereOrNull<CqlDate>(FifthList?.NewList, (CqlDate X) => context?.Operators.Not(context?.Operators.ElementInInterval<CqlDate>(X, context?.Operators.Interval(context?.Operators.Add((context?.Operators.ListElementAt<CqlDate>(FifthList?.NewList, FifthList?.IndexofNewDate) as CqlDate), context?.Operators.Quantity(1m, "day")), context?.Operators.Add((context?.Operators.ListElementAt<CqlDate>(FifthList?.NewList, FifthList?.IndexofNewDate) as CqlDate), context?.Operators.Quantity(30m, "days")), true, true), null))),
																										IndexofNewDate = context?.Operators.Add(FifthList?.IndexofNewDate, (int?)1),
																									},
																								}, (Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT SixthList) => (((context?.Operators.ListElementAt<CqlDate>(SixthList?.NewList, SixthList?.IndexofNewDate) == null))
																									? (SixthList)
																									: (context?.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(context?.Operators.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
																												{
																													new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																													{
																														NextDate = (context?.Operators.ListElementAt<CqlDate>(SixthList?.NewList, SixthList?.IndexofNewDate) as CqlDate),
																														NewList = context?.Operators.WhereOrNull<CqlDate>(SixthList?.NewList, (CqlDate X) => context?.Operators.Not(context?.Operators.ElementInInterval<CqlDate>(X, context?.Operators.Interval(context?.Operators.Add((context?.Operators.ListElementAt<CqlDate>(SixthList?.NewList, SixthList?.IndexofNewDate) as CqlDate), context?.Operators.Quantity(1m, "day")), context?.Operators.Add((context?.Operators.ListElementAt<CqlDate>(SixthList?.NewList, SixthList?.IndexofNewDate) as CqlDate), context?.Operators.Quantity(30m, "days")), true, true), null))),
																														IndexofNewDate = context?.Operators.Add(SixthList?.IndexofNewDate, (int?)1),
																													},
																												}, (Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT SeventhList) => (((context?.Operators.ListElementAt<CqlDate>(SeventhList?.NewList, SeventhList?.IndexofNewDate) == null))
																													? (SeventhList)
																													: (context?.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(context?.Operators.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
																																{
																																	new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																																	{
																																		NextDate = (context?.Operators.ListElementAt<CqlDate>(SeventhList?.NewList, SeventhList?.IndexofNewDate) as CqlDate),
																																		NewList = context?.Operators.WhereOrNull<CqlDate>(SeventhList?.NewList, (CqlDate X) => context?.Operators.Not(context?.Operators.ElementInInterval<CqlDate>(X, context?.Operators.Interval(context?.Operators.Add((context?.Operators.ListElementAt<CqlDate>(SeventhList?.NewList, SeventhList?.IndexofNewDate) as CqlDate), context?.Operators.Quantity(1m, "day")), context?.Operators.Add((context?.Operators.ListElementAt<CqlDate>(SeventhList?.NewList, SeventhList?.IndexofNewDate) as CqlDate), context?.Operators.Quantity(30m, "days")), true, true), null))),
																																		IndexofNewDate = context?.Operators.Add(SeventhList?.IndexofNewDate, (int?)1),
																																	},
																																}, (Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT EighthList) => (((context?.Operators.ListElementAt<CqlDate>(EighthList?.NewList, EighthList?.IndexofNewDate) == null))
																																	? (EighthList)
																																	: (context?.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(context?.Operators.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
																																				{
																																					new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																																					{
																																						NextDate = (context?.Operators.ListElementAt<CqlDate>(EighthList?.NewList, EighthList?.IndexofNewDate) as CqlDate),
																																						NewList = context?.Operators.WhereOrNull<CqlDate>(EighthList?.NewList, (CqlDate X) => context?.Operators.Not(context?.Operators.ElementInInterval<CqlDate>(X, context?.Operators.Interval(context?.Operators.Add((context?.Operators.ListElementAt<CqlDate>(EighthList?.NewList, EighthList?.IndexofNewDate) as CqlDate), context?.Operators.Quantity(1m, "day")), context?.Operators.Add((context?.Operators.ListElementAt<CqlDate>(EighthList?.NewList, EighthList?.IndexofNewDate) as CqlDate), context?.Operators.Quantity(30m, "days")), true, true), null))),
																																						IndexofNewDate = context?.Operators.Add(EighthList?.IndexofNewDate, (int?)1),
																																					},
																																				}, (Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT NinethList) => (((context?.Operators.ListElementAt<CqlDate>(NinethList?.NewList, NinethList?.IndexofNewDate) == null))
																																					? (NinethList)
																																					: (context?.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(context?.Operators.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
																																								{
																																									new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																																									{
																																										NextDate = (context?.Operators.ListElementAt<CqlDate>(NinethList?.NewList, NinethList?.IndexofNewDate) as CqlDate),
																																										NewList = context?.Operators.WhereOrNull<CqlDate>(NinethList?.NewList, (CqlDate X) => context?.Operators.Not(context?.Operators.ElementInInterval<CqlDate>(X, context?.Operators.Interval(context?.Operators.Add((context?.Operators.ListElementAt<CqlDate>(NinethList?.NewList, NinethList?.IndexofNewDate) as CqlDate), context?.Operators.Quantity(1m, "day")), context?.Operators.Add((context?.Operators.ListElementAt<CqlDate>(NinethList?.NewList, NinethList?.IndexofNewDate) as CqlDate), context?.Operators.Quantity(30m, "days")), true, true), null))),
																																										IndexofNewDate = context?.Operators.Add(NinethList?.IndexofNewDate, (int?)1),
																																									},
																																								}, (Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT TenthList) => (((context?.Operators.ListElementAt<CqlDate>(TenthList?.NewList, TenthList?.IndexofNewDate) == null))
																																									? (TenthList)
																																									: (context?.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(context?.Operators.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
																																												{
																																													new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																																													{
																																														NextDate = (context?.Operators.ListElementAt<CqlDate>(TenthList?.NewList, TenthList?.IndexofNewDate) as CqlDate),
																																														NewList = context?.Operators.WhereOrNull<CqlDate>(TenthList?.NewList, (CqlDate X) => context?.Operators.Not(context?.Operators.ElementInInterval<CqlDate>(X, context?.Operators.Interval(context?.Operators.Add((context?.Operators.ListElementAt<CqlDate>(TenthList?.NewList, TenthList?.IndexofNewDate) as CqlDate), context?.Operators.Quantity(1m, "day")), context?.Operators.Add((context?.Operators.ListElementAt<CqlDate>(TenthList?.NewList, TenthList?.IndexofNewDate) as CqlDate), context?.Operators.Quantity(30m, "days")), true, true), null))),
																																														IndexofNewDate = context?.Operators.Add(TenthList?.IndexofNewDate, (int?)1),
																																													},
																																												}, (Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT EleventhList) => (((context?.Operators.ListElementAt<CqlDate>(EleventhList?.NewList, EleventhList?.IndexofNewDate) == null))
																																													? (EleventhList)
																																													: (new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																																														{
																																															NextDate = (context?.Operators.ListElementAt<CqlDate>(EleventhList?.NewList, EleventhList?.IndexofNewDate) as CqlDate),
																																															NewList = context?.Operators.WhereOrNull<CqlDate>(EleventhList?.NewList, (CqlDate X) => context?.Operators.Not(context?.Operators.ElementInInterval<CqlDate>(X, context?.Operators.Interval(context?.Operators.Add((context?.Operators.ListElementAt<CqlDate>(EleventhList?.NewList, EleventhList?.IndexofNewDate) as CqlDate), context?.Operators.Quantity(1m, "day")), context?.Operators.Add((context?.Operators.ListElementAt<CqlDate>(EleventhList?.NewList, EleventhList?.IndexofNewDate) as CqlDate), context?.Operators.Quantity(30m, "days")), true, true), null))),
																																															IndexofNewDate = context?.Operators.Add(EleventhList?.IndexofNewDate, (int?)1),
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
				var ab_ = context?.Operators.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(z_, aa_);

				return context?.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(ab_);
			};
			var ah_ = context?.Operators.SelectOrNull<Tuples.Tuple_GTiMeVaPZjPXLPBaGARAOCFd, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(af_, ag_);

			return context?.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(ah_);
		};
		var aq_ = context?.Operators.SelectOrNull<Tuples.Tuple_GcLaDggiecCUAgUhQSXhADYJf, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(ao_, ap_);

		return context?.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(aq_);
	}


}