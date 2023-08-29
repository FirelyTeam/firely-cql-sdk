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
    public CqlInterval<CqlDateTime> Normalize_Onset(object onset) =>
((((onset is FhirDateTime as bool?) ?? false))
			? (context.Operators.Interval(FHIRHelpers_4_0_001.ToDateTime((onset as FhirDateTime)), FHIRHelpers_4_0_001.ToDateTime((onset as FhirDateTime)), true, true))
			: (((((onset is Period as bool?) ?? false))
					? (context.Operators.Interval(context.Operators.ConvertStringToDateTime((context.Operators.LateBoundProperty<FhirDateTime>(onset, "start"))?.Value), context.Operators.ConvertStringToDateTime((context.Operators.LateBoundProperty<FhirDateTime>(onset, "end"))?.Value), true, true))
					: (((((onset is FhirString as bool?) ?? false))
							? (context.Operators.Message<CqlInterval<CqlDateTime>>((null as CqlInterval<CqlDateTime>), "1", "Error", "Cannot compute an interval from a String value"))
							: (context.Operators.Interval(context.Operators.ConvertDateToDateTime(((((onset is Age as bool?) ?? false))
	? (context.Operators.Interval(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((Quantity)(onset as Age))), context.Operators.Add(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((Quantity)(onset as Age))), context.Operators.Quantity(1m, "year")), true, false))
	: (((((onset is Range as bool?) ?? false))
			? (context.Operators.Interval(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((onset as Range)?.Low)), context.Operators.Add(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((onset as Range)?.High)), context.Operators.Quantity(1m, "year")), true, false))
			: ((null as CqlInterval<CqlDate>)))))?.low), context.Operators.ConvertDateToDateTime(((((onset is Age as bool?) ?? false))
	? (context.Operators.Interval(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((Quantity)(onset as Age))), context.Operators.Add(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((Quantity)(onset as Age))), context.Operators.Quantity(1m, "year")), true, false))
	: (((((onset is Range as bool?) ?? false))
			? (context.Operators.Interval(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((onset as Range)?.Low)), context.Operators.Add(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((onset as Range)?.High)), context.Operators.Quantity(1m, "year")), true, false))
			: ((null as CqlInterval<CqlDate>)))))?.high), ((((onset is Age as bool?) ?? false))
	? (context.Operators.Interval(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((Quantity)(onset as Age))), context.Operators.Add(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((Quantity)(onset as Age))), context.Operators.Quantity(1m, "year")), true, false))
	: (((((onset is Range as bool?) ?? false))
			? (context.Operators.Interval(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((onset as Range)?.Low)), context.Operators.Add(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((onset as Range)?.High)), context.Operators.Quantity(1m, "year")), true, false))
			: ((null as CqlInterval<CqlDate>)))))?.lowClosed, ((((onset is Age as bool?) ?? false))
	? (context.Operators.Interval(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((Quantity)(onset as Age))), context.Operators.Add(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((Quantity)(onset as Age))), context.Operators.Quantity(1m, "year")), true, false))
	: (((((onset is Range as bool?) ?? false))
			? (context.Operators.Interval(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((onset as Range)?.Low)), context.Operators.Add(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((onset as Range)?.High)), context.Operators.Quantity(1m, "year")), true, false))
			: ((null as CqlInterval<CqlDate>)))))?.highClosed)))))));


    [CqlDeclaration("Normalize Abatement")]
    public CqlInterval<CqlDateTime> Normalize_Abatement(object abatement) =>
((((abatement is FhirDateTime as bool?) ?? false))
			? (context.Operators.Interval(FHIRHelpers_4_0_001.ToDateTime((abatement as FhirDateTime)), FHIRHelpers_4_0_001.ToDateTime((abatement as FhirDateTime)), true, true))
			: (((((abatement is Period as bool?) ?? false))
					? (context.Operators.Interval(context.Operators.ConvertStringToDateTime((context.Operators.LateBoundProperty<FhirDateTime>(abatement, "start"))?.Value), context.Operators.ConvertStringToDateTime((context.Operators.LateBoundProperty<FhirDateTime>(abatement, "end"))?.Value), true, true))
					: (((((abatement is FhirString as bool?) ?? false))
							? (context.Operators.Message<CqlInterval<CqlDateTime>>((null as CqlInterval<CqlDateTime>), "1", "Error", "Cannot compute an interval from a String value"))
							: (context.Operators.Interval(context.Operators.ConvertDateToDateTime(((((abatement is Age as bool?) ?? false))
	? (context.Operators.Interval(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((Quantity)(abatement as Age))), context.Operators.Add(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((Quantity)(abatement as Age))), context.Operators.Quantity(1m, "year")), true, false))
	: (((((abatement is Range as bool?) ?? false))
			? (context.Operators.Interval(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((abatement as Range)?.Low)), context.Operators.Add(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((abatement as Range)?.High)), context.Operators.Quantity(1m, "year")), true, false))
			: ((null as CqlInterval<CqlDate>)))))?.low), context.Operators.ConvertDateToDateTime(((((abatement is Age as bool?) ?? false))
	? (context.Operators.Interval(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((Quantity)(abatement as Age))), context.Operators.Add(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((Quantity)(abatement as Age))), context.Operators.Quantity(1m, "year")), true, false))
	: (((((abatement is Range as bool?) ?? false))
			? (context.Operators.Interval(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((abatement as Range)?.Low)), context.Operators.Add(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((abatement as Range)?.High)), context.Operators.Quantity(1m, "year")), true, false))
			: ((null as CqlInterval<CqlDate>)))))?.high), ((((abatement is Age as bool?) ?? false))
	? (context.Operators.Interval(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((Quantity)(abatement as Age))), context.Operators.Add(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((Quantity)(abatement as Age))), context.Operators.Quantity(1m, "year")), true, false))
	: (((((abatement is Range as bool?) ?? false))
			? (context.Operators.Interval(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((abatement as Range)?.Low)), context.Operators.Add(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((abatement as Range)?.High)), context.Operators.Quantity(1m, "year")), true, false))
			: ((null as CqlInterval<CqlDate>)))))?.lowClosed, ((((abatement is Age as bool?) ?? false))
	? (context.Operators.Interval(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((Quantity)(abatement as Age))), context.Operators.Add(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((Quantity)(abatement as Age))), context.Operators.Quantity(1m, "year")), true, false))
	: (((((abatement is Range as bool?) ?? false))
			? (context.Operators.Interval(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((abatement as Range)?.Low)), context.Operators.Add(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((abatement as Range)?.High)), context.Operators.Quantity(1m, "year")), true, false))
			: ((null as CqlInterval<CqlDate>)))))?.highClosed)))))));


    [CqlDeclaration("Prevalence Period")]
    public CqlInterval<CqlDateTime> Prevalence_Period(Condition condition)
	{
		var a_ = condition?.Onset;
		var b_ = this.Normalize_Onset(a_);
		var c_ = context.Operators;
		var d_ = c_.Start(b_);
		var e_ = condition?.Abatement;
		var f_ = this.Normalize_Abatement(e_);
		var h_ = c_.End(f_);
		var j_ = c_.Interval(d_, h_, true, true);

		return j_;
	}


    [CqlDeclaration("Normalize Interval")]
    public CqlInterval<CqlDateTime> Normalize_Interval(object choice)
	{
		CqlInterval<CqlDateTime> a_()
		{
			if (((choice is FhirDateTime as bool?) ?? false))
			{
				var b_ = FHIRHelpers_4_0_001.ToDateTime((choice as FhirDateTime));
				var d_ = context.Operators;
				var e_ = d_.Interval(b_, b_, true, true);

				return e_;
			}
			else if (((choice is Date as bool?) ?? false))
			{
				var f_ = FHIRHelpers_4_0_001.ToDate((choice as Date));
				var g_ = context.Operators;
				var h_ = g_.ConvertDateToDateTime(f_);
				var k_ = g_.ConvertDateToDateTime(f_);
				var m_ = g_.Interval(h_, k_, true, true);

				return m_;
			}
			else if (((choice is Period as bool?) ?? false))
			{
				var n_ = context.Operators;
				var o_ = n_.LateBoundProperty<FhirDateTime>(choice, "start");
				var p_ = o_?.Value;
				var r_ = n_.ConvertStringToDateTime(p_);
				var t_ = n_.LateBoundProperty<FhirDateTime>(choice, "end");
				var u_ = t_?.Value;
				var w_ = n_.ConvertStringToDateTime(u_);
				var y_ = n_.Interval(r_, w_, true, true);

				return y_;
			}
			else if (((choice is Instant as bool?) ?? false))
			{
				var z_ = FHIRHelpers_4_0_001.ToDateTime((choice as Instant));
				var ab_ = context.Operators;
				var ac_ = ab_.Interval(z_, z_, true, true);

				return ac_;
			}
			else if (((choice is Age as bool?) ?? false))
			{
				var ad_ = this.Patient();
				var ae_ = ad_?.BirthDateElement;
				var af_ = FHIRHelpers_4_0_001.ToDate(ae_);
				var ag_ = FHIRHelpers_4_0_001.ToQuantity((Quantity)(choice as Age));
				var ah_ = context.Operators;
				var ai_ = ah_.Add(af_, ag_);
				var ak_ = ad_?.BirthDateElement;
				var al_ = FHIRHelpers_4_0_001.ToDate(ak_);
				var ao_ = ah_.Add(al_, ag_);
				var aq_ = ah_.Quantity(1m, "year");
				var as_ = ah_.Add(ao_, aq_);
				var au_ = ah_.Interval(ai_, as_, true, false);
				var av_ = au_?.low;
				var ax_ = ah_.ConvertDateToDateTime(av_);
				var az_ = ad_?.BirthDateElement;
				var ba_ = FHIRHelpers_4_0_001.ToDate(az_);
				var bd_ = ah_.Add(ba_, ag_);
				var bf_ = ad_?.BirthDateElement;
				var bg_ = FHIRHelpers_4_0_001.ToDate(bf_);
				var bj_ = ah_.Add(bg_, ag_);
				var bl_ = ah_.Quantity(1m, "year");
				var bn_ = ah_.Add(bj_, bl_);
				var bp_ = ah_.Interval(bd_, bn_, true, false);
				var bq_ = bp_?.high;
				var bs_ = ah_.ConvertDateToDateTime(bq_);
				var bu_ = ad_?.BirthDateElement;
				var bv_ = FHIRHelpers_4_0_001.ToDate(bu_);
				var by_ = ah_.Add(bv_, ag_);
				var ca_ = ad_?.BirthDateElement;
				var cb_ = FHIRHelpers_4_0_001.ToDate(ca_);
				var ce_ = ah_.Add(cb_, ag_);
				var cg_ = ah_.Quantity(1m, "year");
				var ci_ = ah_.Add(ce_, cg_);
				var ck_ = ah_.Interval(by_, ci_, true, false);
				var cl_ = ck_?.lowClosed;
				var cn_ = ad_?.BirthDateElement;
				var co_ = FHIRHelpers_4_0_001.ToDate(cn_);
				var cr_ = ah_.Add(co_, ag_);
				var ct_ = ad_?.BirthDateElement;
				var cu_ = FHIRHelpers_4_0_001.ToDate(ct_);
				var cx_ = ah_.Add(cu_, ag_);
				var cz_ = ah_.Quantity(1m, "year");
				var db_ = ah_.Add(cx_, cz_);
				var dd_ = ah_.Interval(cr_, db_, true, false);
				var de_ = dd_?.highClosed;
				var dg_ = ah_.Interval(ax_, bs_, cl_, de_);

				return dg_;
			}
			else if (((choice is Range as bool?) ?? false))
			{
				var dh_ = this.Patient();
				var di_ = dh_?.BirthDateElement;
				var dj_ = FHIRHelpers_4_0_001.ToDate(di_);
				var dk_ = (choice as Range)?.Low;
				var dl_ = FHIRHelpers_4_0_001.ToQuantity(dk_);
				var dm_ = context.Operators;
				var dn_ = dm_.Add(dj_, dl_);
				var dp_ = dh_?.BirthDateElement;
				var dq_ = FHIRHelpers_4_0_001.ToDate(dp_);
				var dr_ = (choice as Range)?.High;
				var ds_ = FHIRHelpers_4_0_001.ToQuantity(dr_);
				var du_ = dm_.Add(dq_, ds_);
				var dw_ = dm_.Quantity(1m, "year");
				var dy_ = dm_.Add(du_, dw_);
				var ea_ = dm_.Interval(dn_, dy_, true, false);
				var eb_ = ea_?.low;
				var ed_ = dm_.ConvertDateToDateTime(eb_);
				var ef_ = dh_?.BirthDateElement;
				var eg_ = FHIRHelpers_4_0_001.ToDate(ef_);
				var ei_ = FHIRHelpers_4_0_001.ToQuantity(dk_);
				var ek_ = dm_.Add(eg_, ei_);
				var em_ = dh_?.BirthDateElement;
				var en_ = FHIRHelpers_4_0_001.ToDate(em_);
				var ep_ = FHIRHelpers_4_0_001.ToQuantity(dr_);
				var er_ = dm_.Add(en_, ep_);
				var et_ = dm_.Quantity(1m, "year");
				var ev_ = dm_.Add(er_, et_);
				var ex_ = dm_.Interval(ek_, ev_, true, false);
				var ey_ = ex_?.high;
				var fa_ = dm_.ConvertDateToDateTime(ey_);
				var fc_ = dh_?.BirthDateElement;
				var fd_ = FHIRHelpers_4_0_001.ToDate(fc_);
				var ff_ = FHIRHelpers_4_0_001.ToQuantity(dk_);
				var fh_ = dm_.Add(fd_, ff_);
				var fj_ = dh_?.BirthDateElement;
				var fk_ = FHIRHelpers_4_0_001.ToDate(fj_);
				var fm_ = FHIRHelpers_4_0_001.ToQuantity(dr_);
				var fo_ = dm_.Add(fk_, fm_);
				var fq_ = dm_.Quantity(1m, "year");
				var fs_ = dm_.Add(fo_, fq_);
				var fu_ = dm_.Interval(fh_, fs_, true, false);
				var fv_ = fu_?.lowClosed;
				var fx_ = dh_?.BirthDateElement;
				var fy_ = FHIRHelpers_4_0_001.ToDate(fx_);
				var ga_ = FHIRHelpers_4_0_001.ToQuantity(dk_);
				var gc_ = dm_.Add(fy_, ga_);
				var ge_ = dh_?.BirthDateElement;
				var gf_ = FHIRHelpers_4_0_001.ToDate(ge_);
				var gh_ = FHIRHelpers_4_0_001.ToQuantity(dr_);
				var gj_ = dm_.Add(gf_, gh_);
				var gl_ = dm_.Quantity(1m, "year");
				var gn_ = dm_.Add(gj_, gl_);
				var gp_ = dm_.Interval(gc_, gn_, true, false);
				var gq_ = gp_?.highClosed;
				var gs_ = dm_.Interval(ed_, fa_, fv_, gq_);

				return gs_;
			}
			else if (((choice is Timing as bool?) ?? false))
			{
				CqlInterval<CqlDateTime> gt_ = null;
				var gu_ = context.Operators;
				var gv_ = gu_.Message<CqlInterval<CqlDateTime>>((gt_ as CqlInterval<CqlDateTime>), "1", "Error", "Cannot compute a single interval from a Timing type");

				return gv_;
			}
			else if (((choice is FhirString as bool?) ?? false))
			{
				CqlInterval<CqlDateTime> gw_ = null;
				var gx_ = context.Operators;
				var gy_ = gx_.Message<CqlInterval<CqlDateTime>>((gw_ as CqlInterval<CqlDateTime>), "1", "Error", "Cannot compute an interval from a String value");

				return gy_;
			}
			else
			{
				CqlInterval<CqlDateTime> gz_ = null;

				return (gz_ as CqlInterval<CqlDateTime>);
			}
;
		};

		return a_();
	}


    [CqlDeclaration("GetId")]
    public string GetId(string uri) =>
(((context.Operators.Greater(context.Operators.PositionOf("/", uri), (int?)0) ?? false))
			? (context.Operators.LastOfList<string>(context.Operators.Split(uri, "/")))
			: (uri));


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
			var p_ = context.Operators;
			var q_ = p_.Not((bool?)(X is null));

			return q_;
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
			var r_ = SortedDates?.SortedDates;
			var s_ = new Tuples.Tuple_GTiMeVaPZjPXLPBaGARAOCFd
			{
				SortedList = r_,
				AnchorIndex = (int?)0,
			};
			var t_ = new Tuples.Tuple_GTiMeVaPZjPXLPBaGARAOCFd[]
			{
				s_,
			};
			Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT u_(Tuples.Tuple_GTiMeVaPZjPXLPBaGARAOCFd AnchorList)
			{
				var z_ = AnchorList?.SortedList;
				var aa_ = AnchorList?.AnchorIndex;
				var ab_ = context.Operators;
				var ac_ = ab_.ListElementAt<CqlDate>(z_, aa_);
				bool? ad_(CqlDate X)
				{
					var aq_ = AnchorList?.SortedList;
					var ar_ = AnchorList?.AnchorIndex;
					var as_ = context.Operators;
					var at_ = as_.ListElementAt<CqlDate>(aq_, ar_);
					var av_ = as_.Quantity(1m, "day");
					var ax_ = as_.Add((at_ as CqlDate), av_);
					var bb_ = as_.ListElementAt<CqlDate>(aq_, ar_);
					var bd_ = as_.Quantity(30m, "days");
					var bf_ = as_.Add((bb_ as CqlDate), bd_);
					var bh_ = as_.Interval(ax_, bf_, true, true);
					var bj_ = as_.ElementInInterval<CqlDate>(X, bh_, null);
					var bl_ = as_.Not(bj_);

					return bl_;
				};
				var af_ = ab_.WhereOrNull<CqlDate>(DateList, ad_);
				var ai_ = ab_.Add(aa_, (int?)1);
				var aj_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
				{
					NextDate = (ac_ as CqlDate),
					NewList = af_,
					IndexofNewDate = ai_,
				};
				var ak_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
				{
					aj_,
				};
				Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT al_(Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT FirstList) => (((context.Operators.ListElementAt<CqlDate>(FirstList?.NewList, FirstList?.IndexofNewDate) is null))
					? (FirstList)
					: (context.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(context.Operators.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
								{
									new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
									{
										NextDate = (context.Operators.ListElementAt<CqlDate>(FirstList?.NewList, FirstList?.IndexofNewDate) as CqlDate),
										NewList = context.Operators.WhereOrNull<CqlDate>(FirstList?.NewList, (CqlDate X) => context.Operators.Not(context.Operators.ElementInInterval<CqlDate>(X, context.Operators.Interval(context.Operators.Add((context.Operators.ListElementAt<CqlDate>(FirstList?.NewList, FirstList?.IndexofNewDate) as CqlDate), context.Operators.Quantity(1m, "day")), context.Operators.Add((context.Operators.ListElementAt<CqlDate>(FirstList?.NewList, FirstList?.IndexofNewDate) as CqlDate), context.Operators.Quantity(30m, "days")), true, true), null))),
										IndexofNewDate = context.Operators.Add(FirstList?.IndexofNewDate, (int?)1),
									},
								}, (Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT SecondList) => (((context.Operators.ListElementAt<CqlDate>(SecondList?.NewList, SecondList?.IndexofNewDate) is null))
									? (SecondList)
									: (context.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(context.Operators.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
												{
													new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
													{
														NextDate = (context.Operators.ListElementAt<CqlDate>(SecondList?.NewList, SecondList?.IndexofNewDate) as CqlDate),
														NewList = context.Operators.WhereOrNull<CqlDate>(SecondList?.NewList, (CqlDate X) => context.Operators.Not(context.Operators.ElementInInterval<CqlDate>(X, context.Operators.Interval(context.Operators.Add((context.Operators.ListElementAt<CqlDate>(SecondList?.NewList, SecondList?.IndexofNewDate) as CqlDate), context.Operators.Quantity(1m, "day")), context.Operators.Add((context.Operators.ListElementAt<CqlDate>(SecondList?.NewList, SecondList?.IndexofNewDate) as CqlDate), context.Operators.Quantity(30m, "days")), true, true), null))),
														IndexofNewDate = context.Operators.Add(SecondList?.IndexofNewDate, (int?)1),
													},
												}, (Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT ThirdList) => (((context.Operators.ListElementAt<CqlDate>(ThirdList?.NewList, ThirdList?.IndexofNewDate) is null))
													? (ThirdList)
													: (context.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(context.Operators.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
																{
																	new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																	{
																		NextDate = (context.Operators.ListElementAt<CqlDate>(ThirdList?.NewList, ThirdList?.IndexofNewDate) as CqlDate),
																		NewList = context.Operators.WhereOrNull<CqlDate>(ThirdList?.NewList, (CqlDate X) => context.Operators.Not(context.Operators.ElementInInterval<CqlDate>(X, context.Operators.Interval(context.Operators.Add((context.Operators.ListElementAt<CqlDate>(ThirdList?.NewList, ThirdList?.IndexofNewDate) as CqlDate), context.Operators.Quantity(1m, "day")), context.Operators.Add((context.Operators.ListElementAt<CqlDate>(ThirdList?.NewList, ThirdList?.IndexofNewDate) as CqlDate), context.Operators.Quantity(30m, "days")), true, true), null))),
																		IndexofNewDate = context.Operators.Add(ThirdList?.IndexofNewDate, (int?)1),
																	},
																}, (Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT FourthList) => (((context.Operators.ListElementAt<CqlDate>(FourthList?.NewList, FourthList?.IndexofNewDate) is null))
																	? (FourthList)
																	: (context.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(context.Operators.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
																				{
																					new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																					{
																						NextDate = (context.Operators.ListElementAt<CqlDate>(FourthList?.NewList, FourthList?.IndexofNewDate) as CqlDate),
																						NewList = context.Operators.WhereOrNull<CqlDate>(FourthList?.NewList, (CqlDate X) => context.Operators.Not(context.Operators.ElementInInterval<CqlDate>(X, context.Operators.Interval(context.Operators.Add((context.Operators.ListElementAt<CqlDate>(FourthList?.NewList, FourthList?.IndexofNewDate) as CqlDate), context.Operators.Quantity(1m, "day")), context.Operators.Add((context.Operators.ListElementAt<CqlDate>(FourthList?.NewList, FourthList?.IndexofNewDate) as CqlDate), context.Operators.Quantity(30m, "days")), true, true), null))),
																						IndexofNewDate = context.Operators.Add(FourthList?.IndexofNewDate, (int?)1),
																					},
																				}, (Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT FifthList) => (((context.Operators.ListElementAt<CqlDate>(FifthList?.NewList, FifthList?.IndexofNewDate) is null))
																					? (FifthList)
																					: (context.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(context.Operators.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
																								{
																									new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																									{
																										NextDate = (context.Operators.ListElementAt<CqlDate>(FifthList?.NewList, FifthList?.IndexofNewDate) as CqlDate),
																										NewList = context.Operators.WhereOrNull<CqlDate>(FifthList?.NewList, (CqlDate X) => context.Operators.Not(context.Operators.ElementInInterval<CqlDate>(X, context.Operators.Interval(context.Operators.Add((context.Operators.ListElementAt<CqlDate>(FifthList?.NewList, FifthList?.IndexofNewDate) as CqlDate), context.Operators.Quantity(1m, "day")), context.Operators.Add((context.Operators.ListElementAt<CqlDate>(FifthList?.NewList, FifthList?.IndexofNewDate) as CqlDate), context.Operators.Quantity(30m, "days")), true, true), null))),
																										IndexofNewDate = context.Operators.Add(FifthList?.IndexofNewDate, (int?)1),
																									},
																								}, (Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT SixthList) => (((context.Operators.ListElementAt<CqlDate>(SixthList?.NewList, SixthList?.IndexofNewDate) is null))
																									? (SixthList)
																									: (context.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(context.Operators.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
																												{
																													new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																													{
																														NextDate = (context.Operators.ListElementAt<CqlDate>(SixthList?.NewList, SixthList?.IndexofNewDate) as CqlDate),
																														NewList = context.Operators.WhereOrNull<CqlDate>(SixthList?.NewList, (CqlDate X) => context.Operators.Not(context.Operators.ElementInInterval<CqlDate>(X, context.Operators.Interval(context.Operators.Add((context.Operators.ListElementAt<CqlDate>(SixthList?.NewList, SixthList?.IndexofNewDate) as CqlDate), context.Operators.Quantity(1m, "day")), context.Operators.Add((context.Operators.ListElementAt<CqlDate>(SixthList?.NewList, SixthList?.IndexofNewDate) as CqlDate), context.Operators.Quantity(30m, "days")), true, true), null))),
																														IndexofNewDate = context.Operators.Add(SixthList?.IndexofNewDate, (int?)1),
																													},
																												}, (Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT SeventhList) => (((context.Operators.ListElementAt<CqlDate>(SeventhList?.NewList, SeventhList?.IndexofNewDate) is null))
																													? (SeventhList)
																													: (context.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(context.Operators.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
																																{
																																	new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																																	{
																																		NextDate = (context.Operators.ListElementAt<CqlDate>(SeventhList?.NewList, SeventhList?.IndexofNewDate) as CqlDate),
																																		NewList = context.Operators.WhereOrNull<CqlDate>(SeventhList?.NewList, (CqlDate X) => context.Operators.Not(context.Operators.ElementInInterval<CqlDate>(X, context.Operators.Interval(context.Operators.Add((context.Operators.ListElementAt<CqlDate>(SeventhList?.NewList, SeventhList?.IndexofNewDate) as CqlDate), context.Operators.Quantity(1m, "day")), context.Operators.Add((context.Operators.ListElementAt<CqlDate>(SeventhList?.NewList, SeventhList?.IndexofNewDate) as CqlDate), context.Operators.Quantity(30m, "days")), true, true), null))),
																																		IndexofNewDate = context.Operators.Add(SeventhList?.IndexofNewDate, (int?)1),
																																	},
																																}, (Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT EighthList) => (((context.Operators.ListElementAt<CqlDate>(EighthList?.NewList, EighthList?.IndexofNewDate) is null))
																																	? (EighthList)
																																	: (context.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(context.Operators.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
																																				{
																																					new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																																					{
																																						NextDate = (context.Operators.ListElementAt<CqlDate>(EighthList?.NewList, EighthList?.IndexofNewDate) as CqlDate),
																																						NewList = context.Operators.WhereOrNull<CqlDate>(EighthList?.NewList, (CqlDate X) => context.Operators.Not(context.Operators.ElementInInterval<CqlDate>(X, context.Operators.Interval(context.Operators.Add((context.Operators.ListElementAt<CqlDate>(EighthList?.NewList, EighthList?.IndexofNewDate) as CqlDate), context.Operators.Quantity(1m, "day")), context.Operators.Add((context.Operators.ListElementAt<CqlDate>(EighthList?.NewList, EighthList?.IndexofNewDate) as CqlDate), context.Operators.Quantity(30m, "days")), true, true), null))),
																																						IndexofNewDate = context.Operators.Add(EighthList?.IndexofNewDate, (int?)1),
																																					},
																																				}, (Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT NinethList) => (((context.Operators.ListElementAt<CqlDate>(NinethList?.NewList, NinethList?.IndexofNewDate) is null))
																																					? (NinethList)
																																					: (context.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(context.Operators.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
																																								{
																																									new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																																									{
																																										NextDate = (context.Operators.ListElementAt<CqlDate>(NinethList?.NewList, NinethList?.IndexofNewDate) as CqlDate),
																																										NewList = context.Operators.WhereOrNull<CqlDate>(NinethList?.NewList, (CqlDate X) => context.Operators.Not(context.Operators.ElementInInterval<CqlDate>(X, context.Operators.Interval(context.Operators.Add((context.Operators.ListElementAt<CqlDate>(NinethList?.NewList, NinethList?.IndexofNewDate) as CqlDate), context.Operators.Quantity(1m, "day")), context.Operators.Add((context.Operators.ListElementAt<CqlDate>(NinethList?.NewList, NinethList?.IndexofNewDate) as CqlDate), context.Operators.Quantity(30m, "days")), true, true), null))),
																																										IndexofNewDate = context.Operators.Add(NinethList?.IndexofNewDate, (int?)1),
																																									},
																																								}, (Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT TenthList) => (((context.Operators.ListElementAt<CqlDate>(TenthList?.NewList, TenthList?.IndexofNewDate) is null))
																																									? (TenthList)
																																									: (context.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(context.Operators.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
																																												{
																																													new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																																													{
																																														NextDate = (context.Operators.ListElementAt<CqlDate>(TenthList?.NewList, TenthList?.IndexofNewDate) as CqlDate),
																																														NewList = context.Operators.WhereOrNull<CqlDate>(TenthList?.NewList, (CqlDate X) => context.Operators.Not(context.Operators.ElementInInterval<CqlDate>(X, context.Operators.Interval(context.Operators.Add((context.Operators.ListElementAt<CqlDate>(TenthList?.NewList, TenthList?.IndexofNewDate) as CqlDate), context.Operators.Quantity(1m, "day")), context.Operators.Add((context.Operators.ListElementAt<CqlDate>(TenthList?.NewList, TenthList?.IndexofNewDate) as CqlDate), context.Operators.Quantity(30m, "days")), true, true), null))),
																																														IndexofNewDate = context.Operators.Add(TenthList?.IndexofNewDate, (int?)1),
																																													},
																																												}, (Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT EleventhList) => (((context.Operators.ListElementAt<CqlDate>(EleventhList?.NewList, EleventhList?.IndexofNewDate) is null))
																																													? (EleventhList)
																																													: (new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																																														{
																																															NextDate = (context.Operators.ListElementAt<CqlDate>(EleventhList?.NewList, EleventhList?.IndexofNewDate) as CqlDate),
																																															NewList = context.Operators.WhereOrNull<CqlDate>(EleventhList?.NewList, (CqlDate X) => context.Operators.Not(context.Operators.ElementInInterval<CqlDate>(X, context.Operators.Interval(context.Operators.Add((context.Operators.ListElementAt<CqlDate>(EleventhList?.NewList, EleventhList?.IndexofNewDate) as CqlDate), context.Operators.Quantity(1m, "day")), context.Operators.Add((context.Operators.ListElementAt<CqlDate>(EleventhList?.NewList, EleventhList?.IndexofNewDate) as CqlDate), context.Operators.Quantity(30m, "days")), true, true), null))),
																																															IndexofNewDate = context.Operators.Add(EleventhList?.IndexofNewDate, (int?)1),
																																														}))))))))))))))))))))))))))))))))))))))))));
				var an_ = ab_.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(ak_, al_);
				var ap_ = ab_.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(an_);

				return ap_;
			};
			var v_ = context.Operators;
			var w_ = v_.SelectOrNull<Tuples.Tuple_GTiMeVaPZjPXLPBaGARAOCFd, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(t_, u_);
			var y_ = v_.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(w_);

			return y_;
		};
		var m_ = b_.SelectOrNull<Tuples.Tuple_GcLaDggiecCUAgUhQSXhADYJf, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(j_, k_);
		var o_ = b_.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(m_);

		return o_;
	}


}