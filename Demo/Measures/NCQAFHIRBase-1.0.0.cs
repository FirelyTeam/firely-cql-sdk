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
			var a_ = FHIRHelpers_4_0_001.ToDateTime((onset as FhirDateTime));
			var b_ = FHIRHelpers_4_0_001.ToDateTime((onset as FhirDateTime));

			return context?.Operators.Interval(a_, b_, true, true);
		}
        else if (((onset is Period as bool?) ?? false))
		{
			var a_ = context?.Operators.LateBoundProperty<FhirDateTime>(onset, "start")?.Value;
			var b_ = context?.Operators.ConvertStringToDateTime(a_);
			var c_ = context?.Operators.LateBoundProperty<FhirDateTime>(onset, "end")?.Value;
			var d_ = context?.Operators.ConvertStringToDateTime(c_);

			return context?.Operators.Interval(b_, d_, true, true);
		}
        else if (((onset is FhirString as bool?) ?? false))
		{
			var a_ = (null as CqlInterval<CqlDateTime>);

			return context?.Operators.Message<CqlInterval<CqlDateTime>>(a_, "1", "Error", "Cannot compute an interval from a String value");
		}
        else
		{
			var a_ = ((((onset is Age as bool?) ?? false))
	? (context?.Operators.Interval(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((Quantity)(onset as Age))), context?.Operators.Add(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((Quantity)(onset as Age))), context?.Operators.Quantity(1m, "year")), true, false))
	: (((((onset is Range as bool?) ?? false))
			? (context?.Operators.Interval(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((onset as Range)?.Low)), context?.Operators.Add(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((onset as Range)?.High)), context?.Operators.Quantity(1m, "year")), true, false))
			: ((null as CqlInterval<CqlDate>)))
))
?.low;
			var b_ = context?.Operators.ConvertDateToDateTime(a_);
			var c_ = ((((onset is Age as bool?) ?? false))
	? (context?.Operators.Interval(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((Quantity)(onset as Age))), context?.Operators.Add(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((Quantity)(onset as Age))), context?.Operators.Quantity(1m, "year")), true, false))
	: (((((onset is Range as bool?) ?? false))
			? (context?.Operators.Interval(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((onset as Range)?.Low)), context?.Operators.Add(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((onset as Range)?.High)), context?.Operators.Quantity(1m, "year")), true, false))
			: ((null as CqlInterval<CqlDate>)))
))
?.high;
			var d_ = context?.Operators.ConvertDateToDateTime(c_);
			var e_ = ((((onset is Age as bool?) ?? false))
	? (context?.Operators.Interval(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((Quantity)(onset as Age))), context?.Operators.Add(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((Quantity)(onset as Age))), context?.Operators.Quantity(1m, "year")), true, false))
	: (((((onset is Range as bool?) ?? false))
			? (context?.Operators.Interval(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((onset as Range)?.Low)), context?.Operators.Add(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((onset as Range)?.High)), context?.Operators.Quantity(1m, "year")), true, false))
			: ((null as CqlInterval<CqlDate>)))
))
?.lowClosed;
			var f_ = ((((onset is Age as bool?) ?? false))
	? (context?.Operators.Interval(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((Quantity)(onset as Age))), context?.Operators.Add(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((Quantity)(onset as Age))), context?.Operators.Quantity(1m, "year")), true, false))
	: (((((onset is Range as bool?) ?? false))
			? (context?.Operators.Interval(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((onset as Range)?.Low)), context?.Operators.Add(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((onset as Range)?.High)), context?.Operators.Quantity(1m, "year")), true, false))
			: ((null as CqlInterval<CqlDate>)))
))
?.highClosed;

			return context?.Operators.Interval(b_, d_, e_, f_);
		}
    }


    [CqlDeclaration("Normalize Abatement")]
    public CqlInterval<CqlDateTime> Normalize_Abatement(object abatement)
    {
        if (((abatement is FhirDateTime as bool?) ?? false))
		{
			var a_ = FHIRHelpers_4_0_001.ToDateTime((abatement as FhirDateTime));
			var b_ = FHIRHelpers_4_0_001.ToDateTime((abatement as FhirDateTime));

			return context?.Operators.Interval(a_, b_, true, true);
		}
        else if (((abatement is Period as bool?) ?? false))
		{
			var a_ = context?.Operators.LateBoundProperty<FhirDateTime>(abatement, "start")?.Value;
			var b_ = context?.Operators.ConvertStringToDateTime(a_);
			var c_ = context?.Operators.LateBoundProperty<FhirDateTime>(abatement, "end")?.Value;
			var d_ = context?.Operators.ConvertStringToDateTime(c_);

			return context?.Operators.Interval(b_, d_, true, true);
		}
        else if (((abatement is FhirString as bool?) ?? false))
		{
			var a_ = (null as CqlInterval<CqlDateTime>);

			return context?.Operators.Message<CqlInterval<CqlDateTime>>(a_, "1", "Error", "Cannot compute an interval from a String value");
		}
        else
		{
			var a_ = ((((abatement is Age as bool?) ?? false))
	? (context?.Operators.Interval(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((Quantity)(abatement as Age))), context?.Operators.Add(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((Quantity)(abatement as Age))), context?.Operators.Quantity(1m, "year")), true, false))
	: (((((abatement is Range as bool?) ?? false))
			? (context?.Operators.Interval(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((abatement as Range)?.Low)), context?.Operators.Add(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((abatement as Range)?.High)), context?.Operators.Quantity(1m, "year")), true, false))
			: ((null as CqlInterval<CqlDate>)))
))
?.low;
			var b_ = context?.Operators.ConvertDateToDateTime(a_);
			var c_ = ((((abatement is Age as bool?) ?? false))
	? (context?.Operators.Interval(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((Quantity)(abatement as Age))), context?.Operators.Add(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((Quantity)(abatement as Age))), context?.Operators.Quantity(1m, "year")), true, false))
	: (((((abatement is Range as bool?) ?? false))
			? (context?.Operators.Interval(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((abatement as Range)?.Low)), context?.Operators.Add(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((abatement as Range)?.High)), context?.Operators.Quantity(1m, "year")), true, false))
			: ((null as CqlInterval<CqlDate>)))
))
?.high;
			var d_ = context?.Operators.ConvertDateToDateTime(c_);
			var e_ = ((((abatement is Age as bool?) ?? false))
	? (context?.Operators.Interval(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((Quantity)(abatement as Age))), context?.Operators.Add(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((Quantity)(abatement as Age))), context?.Operators.Quantity(1m, "year")), true, false))
	: (((((abatement is Range as bool?) ?? false))
			? (context?.Operators.Interval(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((abatement as Range)?.Low)), context?.Operators.Add(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((abatement as Range)?.High)), context?.Operators.Quantity(1m, "year")), true, false))
			: ((null as CqlInterval<CqlDate>)))
))
?.lowClosed;
			var f_ = ((((abatement is Age as bool?) ?? false))
	? (context?.Operators.Interval(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((Quantity)(abatement as Age))), context?.Operators.Add(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((Quantity)(abatement as Age))), context?.Operators.Quantity(1m, "year")), true, false))
	: (((((abatement is Range as bool?) ?? false))
			? (context?.Operators.Interval(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((abatement as Range)?.Low)), context?.Operators.Add(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((abatement as Range)?.High)), context?.Operators.Quantity(1m, "year")), true, false))
			: ((null as CqlInterval<CqlDate>)))
))
?.highClosed;

			return context?.Operators.Interval(b_, d_, e_, f_);
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
			var a_ = FHIRHelpers_4_0_001.ToDateTime((choice as FhirDateTime));
			var b_ = FHIRHelpers_4_0_001.ToDateTime((choice as FhirDateTime));

			return context?.Operators.Interval(a_, b_, true, true);
		}
        else if (((choice is Date as bool?) ?? false))
		{
			var a_ = FHIRHelpers_4_0_001.ToDate((choice as Date));
			var b_ = context?.Operators.ConvertDateToDateTime(a_);
			var c_ = FHIRHelpers_4_0_001.ToDate((choice as Date));
			var d_ = context?.Operators.ConvertDateToDateTime(c_);

			return context?.Operators.Interval(b_, d_, true, true);
		}
        else if (((choice is Period as bool?) ?? false))
		{
			var a_ = context?.Operators.LateBoundProperty<FhirDateTime>(choice, "start")?.Value;
			var b_ = context?.Operators.ConvertStringToDateTime(a_);
			var c_ = context?.Operators.LateBoundProperty<FhirDateTime>(choice, "end")?.Value;
			var d_ = context?.Operators.ConvertStringToDateTime(c_);

			return context?.Operators.Interval(b_, d_, true, true);
		}
        else if (((choice is Instant as bool?) ?? false))
		{
			var a_ = FHIRHelpers_4_0_001.ToDateTime((choice as Instant));
			var b_ = FHIRHelpers_4_0_001.ToDateTime((choice as Instant));

			return context?.Operators.Interval(a_, b_, true, true);
		}
        else if (((choice is Age as bool?) ?? false))
		{
			var a_ = this.Patient()?.BirthDateElement;
			var b_ = FHIRHelpers_4_0_001.ToDate(a_);
			var c_ = (Quantity)(choice as Age);
			var d_ = FHIRHelpers_4_0_001.ToQuantity(c_);
			var e_ = context?.Operators.Add(b_, d_);
			var f_ = this.Patient()?.BirthDateElement;
			var g_ = FHIRHelpers_4_0_001.ToDate(f_);
			var h_ = (Quantity)(choice as Age);
			var i_ = FHIRHelpers_4_0_001.ToQuantity(h_);
			var j_ = context?.Operators.Add(g_, i_);
			var k_ = context?.Operators.Quantity(1m, "year");
			var l_ = context?.Operators.Add(j_, k_);
			var m_ = context?.Operators.Interval(e_, l_, true, false);
			var n_ = m_?.low;
			var o_ = context?.Operators.ConvertDateToDateTime(n_);
			var p_ = this.Patient()?.BirthDateElement;
			var q_ = FHIRHelpers_4_0_001.ToDate(p_);
			var r_ = (Quantity)(choice as Age);
			var s_ = FHIRHelpers_4_0_001.ToQuantity(r_);
			var t_ = context?.Operators.Add(q_, s_);
			var u_ = this.Patient()?.BirthDateElement;
			var v_ = FHIRHelpers_4_0_001.ToDate(u_);
			var w_ = (Quantity)(choice as Age);
			var x_ = FHIRHelpers_4_0_001.ToQuantity(w_);
			var y_ = context?.Operators.Add(v_, x_);
			var z_ = context?.Operators.Quantity(1m, "year");
			var aa_ = context?.Operators.Add(y_, z_);
			var ab_ = context?.Operators.Interval(t_, aa_, true, false);
			var ac_ = ab_?.high;
			var ad_ = context?.Operators.ConvertDateToDateTime(ac_);
			var ae_ = this.Patient()?.BirthDateElement;
			var af_ = FHIRHelpers_4_0_001.ToDate(ae_);
			var ag_ = (Quantity)(choice as Age);
			var ah_ = FHIRHelpers_4_0_001.ToQuantity(ag_);
			var ai_ = context?.Operators.Add(af_, ah_);
			var aj_ = this.Patient()?.BirthDateElement;
			var ak_ = FHIRHelpers_4_0_001.ToDate(aj_);
			var al_ = (Quantity)(choice as Age);
			var am_ = FHIRHelpers_4_0_001.ToQuantity(al_);
			var an_ = context?.Operators.Add(ak_, am_);
			var ao_ = context?.Operators.Quantity(1m, "year");
			var ap_ = context?.Operators.Add(an_, ao_);
			var aq_ = context?.Operators.Interval(ai_, ap_, true, false);
			var ar_ = aq_?.lowClosed;
			var as_ = this.Patient()?.BirthDateElement;
			var at_ = FHIRHelpers_4_0_001.ToDate(as_);
			var au_ = (Quantity)(choice as Age);
			var av_ = FHIRHelpers_4_0_001.ToQuantity(au_);
			var aw_ = context?.Operators.Add(at_, av_);
			var ax_ = this.Patient()?.BirthDateElement;
			var ay_ = FHIRHelpers_4_0_001.ToDate(ax_);
			var az_ = (Quantity)(choice as Age);
			var ba_ = FHIRHelpers_4_0_001.ToQuantity(az_);
			var bb_ = context?.Operators.Add(ay_, ba_);
			var bc_ = context?.Operators.Quantity(1m, "year");
			var bd_ = context?.Operators.Add(bb_, bc_);
			var be_ = context?.Operators.Interval(aw_, bd_, true, false);
			var bf_ = be_?.highClosed;

			return context?.Operators.Interval(o_, ad_, ar_, bf_);
		}
        else if (((choice is Range as bool?) ?? false))
		{
			var a_ = this.Patient()?.BirthDateElement;
			var b_ = FHIRHelpers_4_0_001.ToDate(a_);
			var c_ = (choice as Range)?.Low;
			var d_ = FHIRHelpers_4_0_001.ToQuantity(c_);
			var e_ = context?.Operators.Add(b_, d_);
			var f_ = this.Patient()?.BirthDateElement;
			var g_ = FHIRHelpers_4_0_001.ToDate(f_);
			var h_ = (choice as Range)?.High;
			var i_ = FHIRHelpers_4_0_001.ToQuantity(h_);
			var j_ = context?.Operators.Add(g_, i_);
			var k_ = context?.Operators.Quantity(1m, "year");
			var l_ = context?.Operators.Add(j_, k_);
			var m_ = context?.Operators.Interval(e_, l_, true, false);
			var n_ = m_?.low;
			var o_ = context?.Operators.ConvertDateToDateTime(n_);
			var p_ = this.Patient()?.BirthDateElement;
			var q_ = FHIRHelpers_4_0_001.ToDate(p_);
			var r_ = (choice as Range)?.Low;
			var s_ = FHIRHelpers_4_0_001.ToQuantity(r_);
			var t_ = context?.Operators.Add(q_, s_);
			var u_ = this.Patient()?.BirthDateElement;
			var v_ = FHIRHelpers_4_0_001.ToDate(u_);
			var w_ = (choice as Range)?.High;
			var x_ = FHIRHelpers_4_0_001.ToQuantity(w_);
			var y_ = context?.Operators.Add(v_, x_);
			var z_ = context?.Operators.Quantity(1m, "year");
			var aa_ = context?.Operators.Add(y_, z_);
			var ab_ = context?.Operators.Interval(t_, aa_, true, false);
			var ac_ = ab_?.high;
			var ad_ = context?.Operators.ConvertDateToDateTime(ac_);
			var ae_ = this.Patient()?.BirthDateElement;
			var af_ = FHIRHelpers_4_0_001.ToDate(ae_);
			var ag_ = (choice as Range)?.Low;
			var ah_ = FHIRHelpers_4_0_001.ToQuantity(ag_);
			var ai_ = context?.Operators.Add(af_, ah_);
			var aj_ = this.Patient()?.BirthDateElement;
			var ak_ = FHIRHelpers_4_0_001.ToDate(aj_);
			var al_ = (choice as Range)?.High;
			var am_ = FHIRHelpers_4_0_001.ToQuantity(al_);
			var an_ = context?.Operators.Add(ak_, am_);
			var ao_ = context?.Operators.Quantity(1m, "year");
			var ap_ = context?.Operators.Add(an_, ao_);
			var aq_ = context?.Operators.Interval(ai_, ap_, true, false);
			var ar_ = aq_?.lowClosed;
			var as_ = this.Patient()?.BirthDateElement;
			var at_ = FHIRHelpers_4_0_001.ToDate(as_);
			var au_ = (choice as Range)?.Low;
			var av_ = FHIRHelpers_4_0_001.ToQuantity(au_);
			var aw_ = context?.Operators.Add(at_, av_);
			var ax_ = this.Patient()?.BirthDateElement;
			var ay_ = FHIRHelpers_4_0_001.ToDate(ax_);
			var az_ = (choice as Range)?.High;
			var ba_ = FHIRHelpers_4_0_001.ToQuantity(az_);
			var bb_ = context?.Operators.Add(ay_, ba_);
			var bc_ = context?.Operators.Quantity(1m, "year");
			var bd_ = context?.Operators.Add(bb_, bc_);
			var be_ = context?.Operators.Interval(aw_, bd_, true, false);
			var bf_ = be_?.highClosed;

			return context?.Operators.Interval(o_, ad_, ar_, bf_);
		}
        else if (((choice is Timing as bool?) ?? false))
		{
			var a_ = (null as CqlInterval<CqlDateTime>);

			return context?.Operators.Message<CqlInterval<CqlDateTime>>(a_, "1", "Error", "Cannot compute a single interval from a Timing type");
		}
        else if (((choice is FhirString as bool?) ?? false))
		{
			var a_ = (null as CqlInterval<CqlDateTime>);

			return context?.Operators.Message<CqlInterval<CqlDateTime>>(a_, "1", "Error", "Cannot compute an interval from a String value");
		}
        else
            return (null as CqlInterval<CqlDateTime>);
    }


    [CqlDeclaration("GetId")]
    public string GetId(string uri)
    {
        if ((context?.Operators.Greater((context?.Operators.PositionOf("/", uri) as object), ((int?)0 as object)) ?? false))
		{
			var a_ = context?.Operators.Split(uri, "/");

			return context?.Operators.LastOfList<string>(a_);
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
		var b_ = context?.Operators.SelectOrNull<CqlDate, CqlDate>(DateList, a_);
		var c_ = context?.Operators.ListSort<CqlDate>(b_, System.ComponentModel.ListSortDirection.Ascending);
		var d_ = (CqlDate X) =>
		{
			var a_ = (bool?)(X == null);

			return context?.Operators.Not(a_);
		};
		var e_ = context?.Operators.WhereOrNull<CqlDate>(c_, d_);
		var f_ = new Tuples.Tuple_GcLaDggiecCUAgUhQSXhADYJf
		{
			SortedDates = e_,
		};
		var g_ = new Tuples.Tuple_GcLaDggiecCUAgUhQSXhADYJf[]
		{
			f_,
		};
		var h_ = (Tuples.Tuple_GcLaDggiecCUAgUhQSXhADYJf SortedDates) =>
		{
			var a_ = SortedDates?.SortedDates;
			var b_ = (int?)0;
			var c_ = new Tuples.Tuple_GTiMeVaPZjPXLPBaGARAOCFd
			{
				SortedList = a_,
				AnchorIndex = b_,
			};
			var d_ = new Tuples.Tuple_GTiMeVaPZjPXLPBaGARAOCFd[]
			{
				c_,
			};
			var e_ = (Tuples.Tuple_GTiMeVaPZjPXLPBaGARAOCFd AnchorList) =>
			{
				var a_ = AnchorList?.SortedList;
				var b_ = AnchorList?.AnchorIndex;
				var c_ = context?.Operators.ListElementAt<CqlDate>(a_, b_);
				var d_ = (c_ as CqlDate);
				var e_ = (CqlDate X) =>
				{
					var a_ = AnchorList?.SortedList;
					var b_ = AnchorList?.AnchorIndex;
					var c_ = context?.Operators.ListElementAt<CqlDate>(a_, b_);
					var d_ = (c_ as CqlDate);
					var e_ = context?.Operators.Quantity(1m, "day");
					var f_ = context?.Operators.Add(d_, e_);
					var g_ = AnchorList?.SortedList;
					var h_ = AnchorList?.AnchorIndex;
					var i_ = context?.Operators.ListElementAt<CqlDate>(g_, h_);
					var j_ = (i_ as CqlDate);
					var k_ = context?.Operators.Quantity(30m, "days");
					var l_ = context?.Operators.Add(j_, k_);
					var m_ = context?.Operators.Interval(f_, l_, true, true);
					var n_ = context?.Operators.ElementInInterval<CqlDate>(X, m_, null);

					return context?.Operators.Not(n_);
				};
				var f_ = context?.Operators.WhereOrNull<CqlDate>(DateList, e_);
				var g_ = AnchorList?.AnchorIndex;
				var h_ = context?.Operators.Add(g_, (int?)1);
				var i_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
				{
					NextDate = d_,
					NewList = f_,
					IndexofNewDate = h_,
				};
				var j_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
				{
					i_,
				};
				var k_ = (Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT FirstList) => (((context?.Operators.ListElementAt<CqlDate>(FirstList?.NewList, FirstList?.IndexofNewDate) == null))
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
				var l_ = context?.Operators.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(j_, k_);

				return context?.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(l_);
			};
			var f_ = context?.Operators.SelectOrNull<Tuples.Tuple_GTiMeVaPZjPXLPBaGARAOCFd, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(d_, e_);

			return context?.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(f_);
		};
		var i_ = context?.Operators.SelectOrNull<Tuples.Tuple_GcLaDggiecCUAgUhQSXhADYJf, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(g_, h_);

		return context?.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(i_);
	}


}