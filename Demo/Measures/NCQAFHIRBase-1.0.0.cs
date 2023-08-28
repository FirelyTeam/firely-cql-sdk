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
			var a__ = FHIRHelpers_4_0_001.ToDateTime((onset as FhirDateTime));
			var c__ = context.Operators;
			var d__ = c__.Interval(a__, a__, true, true);

			return d__;
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
			var b__ = context.Operators;
			var c__ = b__.Message<CqlInterval<CqlDateTime>>((a__ as CqlInterval<CqlDateTime>), "1", "Error", "Cannot compute an interval from a String value");

			return c__;
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
			var a__ = FHIRHelpers_4_0_001.ToDateTime((abatement as FhirDateTime));
			var c__ = context.Operators;
			var d__ = c__.Interval(a__, a__, true, true);

			return d__;
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
			var b__ = context.Operators;
			var c__ = b__.Message<CqlInterval<CqlDateTime>>((a__ as CqlInterval<CqlDateTime>), "1", "Error", "Cannot compute an interval from a String value");

			return c__;
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
			var a__ = FHIRHelpers_4_0_001.ToDateTime((choice as FhirDateTime));
			var c__ = context.Operators;
			var d__ = c__.Interval(a__, a__, true, true);

			return d__;
		}
        else if (((choice is Date as bool?) ?? false))
		{
			var a__ = FHIRHelpers_4_0_001.ToDate((choice as Date));
			var b__ = context.Operators;
			var c__ = b__.ConvertDateToDateTime(a__);
			var f__ = b__.ConvertDateToDateTime(a__);
			var h__ = b__.Interval(c__, f__, true, true);

			return h__;
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
			var a__ = FHIRHelpers_4_0_001.ToDateTime((choice as Instant));
			var c__ = context.Operators;
			var d__ = c__.Interval(a__, a__, true, true);

			return d__;
		}
        else if (((choice is Age as bool?) ?? false))
		{
			var a__ = this.Patient();
			var b__ = a__.BirthDateElement;
			var c__ = FHIRHelpers_4_0_001.ToDate(b__);
			var d__ = FHIRHelpers_4_0_001.ToQuantity((Quantity)(choice as Age));
			var e__ = context.Operators;
			var f__ = e__.Add(c__, d__);
			var h__ = a__.BirthDateElement;
			var i__ = FHIRHelpers_4_0_001.ToDate(h__);
			var l__ = e__.Add(i__, d__);
			var n__ = e__.Quantity(1m, "year");
			var p__ = e__.Add(l__, n__);
			var r__ = e__.Interval(f__, p__, true, false);
			var s__ = r__.low;
			var u__ = e__.ConvertDateToDateTime(s__);
			var w__ = a__.BirthDateElement;
			var x__ = FHIRHelpers_4_0_001.ToDate(w__);
			var aa__ = e__.Add(x__, d__);
			var ac__ = a__.BirthDateElement;
			var ad__ = FHIRHelpers_4_0_001.ToDate(ac__);
			var ag__ = e__.Add(ad__, d__);
			var ai__ = e__.Quantity(1m, "year");
			var ak__ = e__.Add(ag__, ai__);
			var am__ = e__.Interval(aa__, ak__, true, false);
			var an__ = am__.high;
			var ap__ = e__.ConvertDateToDateTime(an__);
			var ar__ = a__.BirthDateElement;
			var as__ = FHIRHelpers_4_0_001.ToDate(ar__);
			var av__ = e__.Add(as__, d__);
			var ax__ = a__.BirthDateElement;
			var ay__ = FHIRHelpers_4_0_001.ToDate(ax__);
			var bb__ = e__.Add(ay__, d__);
			var bd__ = e__.Quantity(1m, "year");
			var bf__ = e__.Add(bb__, bd__);
			var bh__ = e__.Interval(av__, bf__, true, false);
			var bi__ = bh__.lowClosed;
			var bk__ = a__.BirthDateElement;
			var bl__ = FHIRHelpers_4_0_001.ToDate(bk__);
			var bo__ = e__.Add(bl__, d__);
			var bq__ = a__.BirthDateElement;
			var br__ = FHIRHelpers_4_0_001.ToDate(bq__);
			var bu__ = e__.Add(br__, d__);
			var bw__ = e__.Quantity(1m, "year");
			var by__ = e__.Add(bu__, bw__);
			var ca__ = e__.Interval(bo__, by__, true, false);
			var cb__ = ca__.highClosed;
			var cd__ = e__.Interval(u__, ap__, bi__, cb__);

			return cd__;
		}
        else if (((choice is Range as bool?) ?? false))
		{
			var a__ = this.Patient();
			var b__ = a__.BirthDateElement;
			var c__ = FHIRHelpers_4_0_001.ToDate(b__);
			var d__ = (choice as Range).Low;
			var e__ = FHIRHelpers_4_0_001.ToQuantity(d__);
			var f__ = context.Operators;
			var g__ = f__.Add(c__, e__);
			var i__ = a__.BirthDateElement;
			var j__ = FHIRHelpers_4_0_001.ToDate(i__);
			var k__ = (choice as Range).High;
			var l__ = FHIRHelpers_4_0_001.ToQuantity(k__);
			var n__ = f__.Add(j__, l__);
			var p__ = f__.Quantity(1m, "year");
			var r__ = f__.Add(n__, p__);
			var t__ = f__.Interval(g__, r__, true, false);
			var u__ = t__.low;
			var w__ = f__.ConvertDateToDateTime(u__);
			var y__ = a__.BirthDateElement;
			var z__ = FHIRHelpers_4_0_001.ToDate(y__);
			var ab__ = FHIRHelpers_4_0_001.ToQuantity(d__);
			var ad__ = f__.Add(z__, ab__);
			var af__ = a__.BirthDateElement;
			var ag__ = FHIRHelpers_4_0_001.ToDate(af__);
			var ai__ = FHIRHelpers_4_0_001.ToQuantity(k__);
			var ak__ = f__.Add(ag__, ai__);
			var am__ = f__.Quantity(1m, "year");
			var ao__ = f__.Add(ak__, am__);
			var aq__ = f__.Interval(ad__, ao__, true, false);
			var ar__ = aq__.high;
			var at__ = f__.ConvertDateToDateTime(ar__);
			var av__ = a__.BirthDateElement;
			var aw__ = FHIRHelpers_4_0_001.ToDate(av__);
			var ay__ = FHIRHelpers_4_0_001.ToQuantity(d__);
			var ba__ = f__.Add(aw__, ay__);
			var bc__ = a__.BirthDateElement;
			var bd__ = FHIRHelpers_4_0_001.ToDate(bc__);
			var bf__ = FHIRHelpers_4_0_001.ToQuantity(k__);
			var bh__ = f__.Add(bd__, bf__);
			var bj__ = f__.Quantity(1m, "year");
			var bl__ = f__.Add(bh__, bj__);
			var bn__ = f__.Interval(ba__, bl__, true, false);
			var bo__ = bn__.lowClosed;
			var bq__ = a__.BirthDateElement;
			var br__ = FHIRHelpers_4_0_001.ToDate(bq__);
			var bt__ = FHIRHelpers_4_0_001.ToQuantity(d__);
			var bv__ = f__.Add(br__, bt__);
			var bx__ = a__.BirthDateElement;
			var by__ = FHIRHelpers_4_0_001.ToDate(bx__);
			var ca__ = FHIRHelpers_4_0_001.ToQuantity(k__);
			var cc__ = f__.Add(by__, ca__);
			var ce__ = f__.Quantity(1m, "year");
			var cg__ = f__.Add(cc__, ce__);
			var ci__ = f__.Interval(bv__, cg__, true, false);
			var cj__ = ci__.highClosed;
			var cl__ = f__.Interval(w__, at__, bo__, cj__);

			return cl__;
		}
        else if (((choice is Timing as bool?) ?? false))
		{
			CqlInterval<CqlDateTime> a__ = null;
			var b__ = context.Operators;
			var c__ = b__.Message<CqlInterval<CqlDateTime>>((a__ as CqlInterval<CqlDateTime>), "1", "Error", "Cannot compute a single interval from a Timing type");

			return c__;
		}
        else if (((choice is FhirString as bool?) ?? false))
		{
			CqlInterval<CqlDateTime> a__ = null;
			var b__ = context.Operators;
			var c__ = b__.Message<CqlInterval<CqlDateTime>>((a__ as CqlInterval<CqlDateTime>), "1", "Error", "Cannot compute an interval from a String value");

			return c__;
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
		CqlDate a_(CqlDate d) => d;
		var b_ = context.Operators;
		var c_ = b_.SelectOrNull<CqlDate, CqlDate>(DateList, a_);
		var e_ = b_.ListSort<CqlDate>(c_, System.ComponentModel.ListSortDirection.Ascending);
		bool? f_(CqlDate X)
		{
			var p_ = (X == null);
			var q_ = context.Operators;
			var r_ = q_.Not((bool?)p_);

			return r_;
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
		Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT k_(Tuples.Tuple_GcLaDggiecCUAgUhQSXhADYJf SortedDates)
		{
			var s_ = SortedDates.SortedDates;
			var t_ = new Tuples.Tuple_GTiMeVaPZjPXLPBaGARAOCFd
			{
				SortedList = s_,
				AnchorIndex = (int?)0,
			};
			var u_ = new Tuples.Tuple_GTiMeVaPZjPXLPBaGARAOCFd[]
			{
				t_,
			};
			Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT v_(Tuples.Tuple_GTiMeVaPZjPXLPBaGARAOCFd AnchorList)
			{
				var aa_ = AnchorList.SortedList;
				var ab_ = AnchorList.AnchorIndex;
				var ac_ = context.Operators;
				var ad_ = ac_.ListElementAt<CqlDate>(aa_, ab_);
				bool? ae_(CqlDate X)
				{
					var ar_ = AnchorList.SortedList;
					var as_ = AnchorList.AnchorIndex;
					var at_ = context.Operators;
					var au_ = at_.ListElementAt<CqlDate>(ar_, as_);
					var aw_ = at_.Quantity(1m, "day");
					var ay_ = at_.Add((au_ as CqlDate), aw_);
					var bc_ = at_.ListElementAt<CqlDate>(ar_, as_);
					var be_ = at_.Quantity(30m, "days");
					var bg_ = at_.Add((bc_ as CqlDate), be_);
					var bi_ = at_.Interval(ay_, bg_, true, true);
					var bk_ = at_.ElementInInterval<CqlDate>(X, bi_, null);
					var bm_ = at_.Not(bk_);

					return bm_;
				};
				var ag_ = ac_.WhereOrNull<CqlDate>(DateList, ae_);
				var aj_ = ac_.Add(ab_, (int?)1);
				var ak_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
				{
					NextDate = (ad_ as CqlDate),
					NewList = ag_,
					IndexofNewDate = aj_,
				};
				var al_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
				{
					ak_,
				};
				Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT am_(Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT FirstList) => (((context.Operators.ListElementAt<CqlDate>(FirstList.NewList, FirstList.IndexofNewDate) == null))
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
				var ao_ = ac_.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(al_, am_);
				var aq_ = ac_.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(ao_);

				return aq_;
			};
			var w_ = context.Operators;
			var x_ = w_.SelectOrNull<Tuples.Tuple_GTiMeVaPZjPXLPBaGARAOCFd, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(u_, v_);
			var z_ = w_.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(x_);

			return z_;
		};
		var m_ = b_.SelectOrNull<Tuples.Tuple_GcLaDggiecCUAgUhQSXhADYJf, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(j_, k_);
		var o_ = b_.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(m_);

		return o_;
	}


}