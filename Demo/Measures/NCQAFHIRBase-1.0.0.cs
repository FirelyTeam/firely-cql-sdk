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
			var a__ = context?.Operators.LateBoundProperty<FhirDateTime>(onset, "start")?.Value;
			var b__ = context?.Operators.ConvertStringToDateTime(a__);
			var c__ = context?.Operators.LateBoundProperty<FhirDateTime>(onset, "end")?.Value;
			var d__ = context?.Operators.ConvertStringToDateTime(c__);

			return context?.Operators.Interval(b__, d__, true, true);
		}
        else if (((onset is FhirString as bool?) ?? false))
		{
			var a__ = (null as CqlInterval<CqlDateTime>);

			return context?.Operators.Message<CqlInterval<CqlDateTime>>(a__, "1", "Error", "Cannot compute an interval from a String value");
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
			var a__ = context?.Operators.LateBoundProperty<FhirDateTime>(abatement, "start")?.Value;
			var b__ = context?.Operators.ConvertStringToDateTime(a__);
			var c__ = context?.Operators.LateBoundProperty<FhirDateTime>(abatement, "end")?.Value;
			var d__ = context?.Operators.ConvertStringToDateTime(c__);

			return context?.Operators.Interval(b__, d__, true, true);
		}
        else if (((abatement is FhirString as bool?) ?? false))
		{
			var a__ = (null as CqlInterval<CqlDateTime>);

			return context?.Operators.Message<CqlInterval<CqlDateTime>>(a__, "1", "Error", "Cannot compute an interval from a String value");
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
		var a_ = (condition?.Onset as object);
		var b_ = this.Normalize_Onset(a_);
		var c_ = context?.Operators.Start(b_);
		var d_ = (condition?.Abatement as object);
		var e_ = this.Normalize_Abatement(d_);
		var f_ = context?.Operators.End(e_);

		return context?.Operators.Interval(c_, f_, true, true);
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
			var a__ = context?.Operators.LateBoundProperty<FhirDateTime>(choice, "start")?.Value;
			var b__ = context?.Operators.ConvertStringToDateTime(a__);
			var c__ = context?.Operators.LateBoundProperty<FhirDateTime>(choice, "end")?.Value;
			var d__ = context?.Operators.ConvertStringToDateTime(c__);

			return context?.Operators.Interval(b__, d__, true, true);
		}
        else if (((choice is Instant as bool?) ?? false))
		{
			var a__ = FHIRHelpers_4_0_001.ToDateTime((choice as Instant));
			var b__ = FHIRHelpers_4_0_001.ToDateTime((choice as Instant));

			return context?.Operators.Interval(a__, b__, true, true);
		}
        else if (((choice is Age as bool?) ?? false))
		{
			var a__ = this.Patient()?.BirthDateElement;
			var b__ = FHIRHelpers_4_0_001.ToDate(a__);
			var c__ = (Quantity)(choice as Age);
			var d__ = FHIRHelpers_4_0_001.ToQuantity(c__);
			var e__ = context?.Operators.Add(b__, d__);
			var f__ = this.Patient()?.BirthDateElement;
			var g__ = FHIRHelpers_4_0_001.ToDate(f__);
			var h__ = (Quantity)(choice as Age);
			var i__ = FHIRHelpers_4_0_001.ToQuantity(h__);
			var j__ = context?.Operators.Add(g__, i__);
			var k__ = context?.Operators.Quantity(1m, "year");
			var l__ = context?.Operators.Add(j__, k__);
			var m__ = context?.Operators.Interval(e__, l__, true, false);
			var n__ = m__?.low;
			var o__ = context?.Operators.ConvertDateToDateTime(n__);
			var p__ = this.Patient()?.BirthDateElement;
			var q__ = FHIRHelpers_4_0_001.ToDate(p__);
			var r__ = (Quantity)(choice as Age);
			var s__ = FHIRHelpers_4_0_001.ToQuantity(r__);
			var t__ = context?.Operators.Add(q__, s__);
			var u__ = this.Patient()?.BirthDateElement;
			var v__ = FHIRHelpers_4_0_001.ToDate(u__);
			var w__ = (Quantity)(choice as Age);
			var x__ = FHIRHelpers_4_0_001.ToQuantity(w__);
			var y__ = context?.Operators.Add(v__, x__);
			var z__ = context?.Operators.Quantity(1m, "year");
			var aa__ = context?.Operators.Add(y__, z__);
			var ab__ = context?.Operators.Interval(t__, aa__, true, false);
			var ac__ = ab__?.high;
			var ad__ = context?.Operators.ConvertDateToDateTime(ac__);
			var ae__ = this.Patient()?.BirthDateElement;
			var af__ = FHIRHelpers_4_0_001.ToDate(ae__);
			var ag__ = (Quantity)(choice as Age);
			var ah__ = FHIRHelpers_4_0_001.ToQuantity(ag__);
			var ai__ = context?.Operators.Add(af__, ah__);
			var aj__ = this.Patient()?.BirthDateElement;
			var ak__ = FHIRHelpers_4_0_001.ToDate(aj__);
			var al__ = (Quantity)(choice as Age);
			var am__ = FHIRHelpers_4_0_001.ToQuantity(al__);
			var an__ = context?.Operators.Add(ak__, am__);
			var ao__ = context?.Operators.Quantity(1m, "year");
			var ap__ = context?.Operators.Add(an__, ao__);
			var aq__ = context?.Operators.Interval(ai__, ap__, true, false);
			var ar__ = aq__?.lowClosed;
			var as__ = this.Patient()?.BirthDateElement;
			var at__ = FHIRHelpers_4_0_001.ToDate(as__);
			var au__ = (Quantity)(choice as Age);
			var av__ = FHIRHelpers_4_0_001.ToQuantity(au__);
			var aw__ = context?.Operators.Add(at__, av__);
			var ax__ = this.Patient()?.BirthDateElement;
			var ay__ = FHIRHelpers_4_0_001.ToDate(ax__);
			var az__ = (Quantity)(choice as Age);
			var ba__ = FHIRHelpers_4_0_001.ToQuantity(az__);
			var bb__ = context?.Operators.Add(ay__, ba__);
			var bc__ = context?.Operators.Quantity(1m, "year");
			var bd__ = context?.Operators.Add(bb__, bc__);
			var be__ = context?.Operators.Interval(aw__, bd__, true, false);
			var bf__ = be__?.highClosed;

			return context?.Operators.Interval(o__, ad__, ar__, bf__);
		}
        else if (((choice is Range as bool?) ?? false))
		{
			var a__ = this.Patient()?.BirthDateElement;
			var b__ = FHIRHelpers_4_0_001.ToDate(a__);
			var c__ = (choice as Range)?.Low;
			var d__ = FHIRHelpers_4_0_001.ToQuantity(c__);
			var e__ = context?.Operators.Add(b__, d__);
			var f__ = this.Patient()?.BirthDateElement;
			var g__ = FHIRHelpers_4_0_001.ToDate(f__);
			var h__ = (choice as Range)?.High;
			var i__ = FHIRHelpers_4_0_001.ToQuantity(h__);
			var j__ = context?.Operators.Add(g__, i__);
			var k__ = context?.Operators.Quantity(1m, "year");
			var l__ = context?.Operators.Add(j__, k__);
			var m__ = context?.Operators.Interval(e__, l__, true, false);
			var n__ = m__?.low;
			var o__ = context?.Operators.ConvertDateToDateTime(n__);
			var p__ = this.Patient()?.BirthDateElement;
			var q__ = FHIRHelpers_4_0_001.ToDate(p__);
			var r__ = (choice as Range)?.Low;
			var s__ = FHIRHelpers_4_0_001.ToQuantity(r__);
			var t__ = context?.Operators.Add(q__, s__);
			var u__ = this.Patient()?.BirthDateElement;
			var v__ = FHIRHelpers_4_0_001.ToDate(u__);
			var w__ = (choice as Range)?.High;
			var x__ = FHIRHelpers_4_0_001.ToQuantity(w__);
			var y__ = context?.Operators.Add(v__, x__);
			var z__ = context?.Operators.Quantity(1m, "year");
			var aa__ = context?.Operators.Add(y__, z__);
			var ab__ = context?.Operators.Interval(t__, aa__, true, false);
			var ac__ = ab__?.high;
			var ad__ = context?.Operators.ConvertDateToDateTime(ac__);
			var ae__ = this.Patient()?.BirthDateElement;
			var af__ = FHIRHelpers_4_0_001.ToDate(ae__);
			var ag__ = (choice as Range)?.Low;
			var ah__ = FHIRHelpers_4_0_001.ToQuantity(ag__);
			var ai__ = context?.Operators.Add(af__, ah__);
			var aj__ = this.Patient()?.BirthDateElement;
			var ak__ = FHIRHelpers_4_0_001.ToDate(aj__);
			var al__ = (choice as Range)?.High;
			var am__ = FHIRHelpers_4_0_001.ToQuantity(al__);
			var an__ = context?.Operators.Add(ak__, am__);
			var ao__ = context?.Operators.Quantity(1m, "year");
			var ap__ = context?.Operators.Add(an__, ao__);
			var aq__ = context?.Operators.Interval(ai__, ap__, true, false);
			var ar__ = aq__?.lowClosed;
			var as__ = this.Patient()?.BirthDateElement;
			var at__ = FHIRHelpers_4_0_001.ToDate(as__);
			var au__ = (choice as Range)?.Low;
			var av__ = FHIRHelpers_4_0_001.ToQuantity(au__);
			var aw__ = context?.Operators.Add(at__, av__);
			var ax__ = this.Patient()?.BirthDateElement;
			var ay__ = FHIRHelpers_4_0_001.ToDate(ax__);
			var az__ = (choice as Range)?.High;
			var ba__ = FHIRHelpers_4_0_001.ToQuantity(az__);
			var bb__ = context?.Operators.Add(ay__, ba__);
			var bc__ = context?.Operators.Quantity(1m, "year");
			var bd__ = context?.Operators.Add(bb__, bc__);
			var be__ = context?.Operators.Interval(aw__, bd__, true, false);
			var bf__ = be__?.highClosed;

			return context?.Operators.Interval(o__, ad__, ar__, bf__);
		}
        else if (((choice is Timing as bool?) ?? false))
		{
			var a__ = (null as CqlInterval<CqlDateTime>);

			return context?.Operators.Message<CqlInterval<CqlDateTime>>(a__, "1", "Error", "Cannot compute a single interval from a Timing type");
		}
        else if (((choice is FhirString as bool?) ?? false))
		{
			var a__ = (null as CqlInterval<CqlDateTime>);

			return context?.Operators.Message<CqlInterval<CqlDateTime>>(a__, "1", "Error", "Cannot compute an interval from a String value");
		}
        else
            return (null as CqlInterval<CqlDateTime>);
    }


    [CqlDeclaration("GetId")]
    public string GetId(string uri)
    {
        if ((context?.Operators.Greater((context?.Operators.PositionOf("/", uri) as object), ((int?)0 as object)) ?? false))
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
		var ah_ = (CqlDate d) => d;
		var ai_ = context?.Operators.SelectOrNull<CqlDate, CqlDate>(DateList, ah_);
		var aj_ = context?.Operators.ListSort<CqlDate>(ai_, System.ComponentModel.ListSortDirection.Ascending);
		var ak_ = (CqlDate X) =>
		{
			var a_ = (bool?)(X == null);

			return context?.Operators.Not(a_);
		};
		var al_ = context?.Operators.WhereOrNull<CqlDate>(aj_, ak_);
		var am_ = new Tuples.Tuple_GcLaDggiecCUAgUhQSXhADYJf
		{
			SortedDates = al_,
		};
		var an_ = new Tuples.Tuple_GcLaDggiecCUAgUhQSXhADYJf[]
		{
			am_,
		};
		var ao_ = (Tuples.Tuple_GcLaDggiecCUAgUhQSXhADYJf SortedDates) =>
		{
			var ab_ = SortedDates?.SortedDates;
			var ac_ = (int?)0;
			var ad_ = new Tuples.Tuple_GTiMeVaPZjPXLPBaGARAOCFd
			{
				SortedList = ab_,
				AnchorIndex = ac_,
			};
			var ae_ = new Tuples.Tuple_GTiMeVaPZjPXLPBaGARAOCFd[]
			{
				ad_,
			};
			var af_ = (Tuples.Tuple_GTiMeVaPZjPXLPBaGARAOCFd AnchorList) =>
			{
				var p_ = AnchorList?.SortedList;
				var q_ = AnchorList?.AnchorIndex;
				var r_ = context?.Operators.ListElementAt<CqlDate>(p_, q_);
				var s_ = (r_ as CqlDate);
				var t_ = (CqlDate X) =>
				{
					var b_ = AnchorList?.SortedList;
					var c_ = AnchorList?.AnchorIndex;
					var d_ = context?.Operators.ListElementAt<CqlDate>(b_, c_);
					var e_ = (d_ as CqlDate);
					var f_ = context?.Operators.Quantity(1m, "day");
					var g_ = context?.Operators.Add(e_, f_);
					var h_ = AnchorList?.SortedList;
					var i_ = AnchorList?.AnchorIndex;
					var j_ = context?.Operators.ListElementAt<CqlDate>(h_, i_);
					var k_ = (j_ as CqlDate);
					var l_ = context?.Operators.Quantity(30m, "days");
					var m_ = context?.Operators.Add(k_, l_);
					var n_ = context?.Operators.Interval(g_, m_, true, true);
					var o_ = context?.Operators.ElementInInterval<CqlDate>(X, n_, null);

					return context?.Operators.Not(o_);
				};
				var u_ = context?.Operators.WhereOrNull<CqlDate>(DateList, t_);
				var v_ = AnchorList?.AnchorIndex;
				var w_ = context?.Operators.Add(v_, (int?)1);
				var x_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
				{
					NextDate = s_,
					NewList = u_,
					IndexofNewDate = w_,
				};
				var y_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
				{
					x_,
				};
				var z_ = (Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT FirstList) => (((context?.Operators.ListElementAt<CqlDate>(FirstList?.NewList, FirstList?.IndexofNewDate) == null))
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
				var aa_ = context?.Operators.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(y_, z_);

				return context?.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(aa_);
			};
			var ag_ = context?.Operators.SelectOrNull<Tuples.Tuple_GTiMeVaPZjPXLPBaGARAOCFd, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(ae_, af_);

			return context?.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(ag_);
		};
		var ap_ = context?.Operators.SelectOrNull<Tuples.Tuple_GcLaDggiecCUAgUhQSXhADYJf, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(an_, ao_);

		return context?.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(ap_);
	}


}