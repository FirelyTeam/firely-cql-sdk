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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "0.9.0.0")]
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
        var a_ = context?.Operators.RetrieveByValueSet<Patient>(null, 
			null);
        return context?.Operators.SingleOrNull<Patient>(a_);
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
                return context?.Operators.Interval(b__, 
					b__, 
					true, 
					true);
            }
        else if (((onset is Period as bool?) ?? false))
            {
                var a__ = (context?.Operators.LateBoundProperty<FhirDateTime>(onset, 
						"start"))?.Value;
                var b__ = context?.Operators.ConvertStringToDateTime(a__);
                var c__ = (context?.Operators.LateBoundProperty<FhirDateTime>(onset, 
						"end"))?.Value;
                var d__ = context?.Operators.ConvertStringToDateTime(c__);
                return context?.Operators.Interval(b__, 
					d__, 
					true, 
					true);
            }
        else if (((onset is FhirString as bool?) ?? false))
            return context?.Operators.Message<CqlInterval<CqlDateTime>>((null as CqlInterval<CqlDateTime>), 
				"1", 
				"Error", 
				"Cannot compute an interval from a String value");

        else 
            {
                var a__ = (((((onset is Age as bool?) ?? false))
						? (context?.Operators.Interval(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
									FHIRHelpers_4_0_001.ToQuantity(((Quantity)(onset as Age)))), 
								context?.Operators.Add(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
										FHIRHelpers_4_0_001.ToQuantity(((Quantity)(onset as Age)))), 
									context?.Operators.Quantity(1m, 
										"year")), 
								true, 
								false))
						: (((((onset is Range as bool?) ?? false))
								? (context?.Operators.Interval(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
											FHIRHelpers_4_0_001.ToQuantity(((onset as Range))?.Low)), 
										context?.Operators.Add(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
												FHIRHelpers_4_0_001.ToQuantity(((onset as Range))?.High)), 
											context?.Operators.Quantity(1m, 
												"year")), 
										true, 
										false))
								: ((null as CqlInterval<CqlDate>)))
))
)?.low;
                var b__ = context?.Operators.ConvertDateToDateTime(a__);
                var c__ = (((((onset is Age as bool?) ?? false))
						? (context?.Operators.Interval(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
									FHIRHelpers_4_0_001.ToQuantity(((Quantity)(onset as Age)))), 
								context?.Operators.Add(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
										FHIRHelpers_4_0_001.ToQuantity(((Quantity)(onset as Age)))), 
									context?.Operators.Quantity(1m, 
										"year")), 
								true, 
								false))
						: (((((onset is Range as bool?) ?? false))
								? (context?.Operators.Interval(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
											FHIRHelpers_4_0_001.ToQuantity(((onset as Range))?.Low)), 
										context?.Operators.Add(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
												FHIRHelpers_4_0_001.ToQuantity(((onset as Range))?.High)), 
											context?.Operators.Quantity(1m, 
												"year")), 
										true, 
										false))
								: ((null as CqlInterval<CqlDate>)))
))
)?.high;
                var d__ = context?.Operators.ConvertDateToDateTime(c__);
                var e__ = (((((onset is Age as bool?) ?? false))
						? (context?.Operators.Interval(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
									FHIRHelpers_4_0_001.ToQuantity(((Quantity)(onset as Age)))), 
								context?.Operators.Add(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
										FHIRHelpers_4_0_001.ToQuantity(((Quantity)(onset as Age)))), 
									context?.Operators.Quantity(1m, 
										"year")), 
								true, 
								false))
						: (((((onset is Range as bool?) ?? false))
								? (context?.Operators.Interval(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
											FHIRHelpers_4_0_001.ToQuantity(((onset as Range))?.Low)), 
										context?.Operators.Add(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
												FHIRHelpers_4_0_001.ToQuantity(((onset as Range))?.High)), 
											context?.Operators.Quantity(1m, 
												"year")), 
										true, 
										false))
								: ((null as CqlInterval<CqlDate>)))
))
)?.lowClosed;
                var f__ = (((((onset is Age as bool?) ?? false))
						? (context?.Operators.Interval(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
									FHIRHelpers_4_0_001.ToQuantity(((Quantity)(onset as Age)))), 
								context?.Operators.Add(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
										FHIRHelpers_4_0_001.ToQuantity(((Quantity)(onset as Age)))), 
									context?.Operators.Quantity(1m, 
										"year")), 
								true, 
								false))
						: (((((onset is Range as bool?) ?? false))
								? (context?.Operators.Interval(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
											FHIRHelpers_4_0_001.ToQuantity(((onset as Range))?.Low)), 
										context?.Operators.Add(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
												FHIRHelpers_4_0_001.ToQuantity(((onset as Range))?.High)), 
											context?.Operators.Quantity(1m, 
												"year")), 
										true, 
										false))
								: ((null as CqlInterval<CqlDate>)))
))
)?.highClosed;
                return context?.Operators.Interval(b__, 
					d__, 
					e__, 
					f__);
            }
    }


    [CqlDeclaration("Normalize Abatement")]
    public CqlInterval<CqlDateTime> Normalize_Abatement(object abatement)
    {
        if (((abatement is FhirDateTime as bool?) ?? false))
            {
                var a__ = (abatement as FhirDateTime);
                var b__ = FHIRHelpers_4_0_001.ToDateTime(a__);
                return context?.Operators.Interval(b__, 
					b__, 
					true, 
					true);
            }
        else if (((abatement is Period as bool?) ?? false))
            {
                var a__ = (context?.Operators.LateBoundProperty<FhirDateTime>(abatement, 
						"start"))?.Value;
                var b__ = context?.Operators.ConvertStringToDateTime(a__);
                var c__ = (context?.Operators.LateBoundProperty<FhirDateTime>(abatement, 
						"end"))?.Value;
                var d__ = context?.Operators.ConvertStringToDateTime(c__);
                return context?.Operators.Interval(b__, 
					d__, 
					true, 
					true);
            }
        else if (((abatement is FhirString as bool?) ?? false))
            return context?.Operators.Message<CqlInterval<CqlDateTime>>((null as CqlInterval<CqlDateTime>), 
				"1", 
				"Error", 
				"Cannot compute an interval from a String value");

        else 
            {
                var a__ = (((((abatement is Age as bool?) ?? false))
						? (context?.Operators.Interval(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
									FHIRHelpers_4_0_001.ToQuantity(((Quantity)(abatement as Age)))), 
								context?.Operators.Add(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
										FHIRHelpers_4_0_001.ToQuantity(((Quantity)(abatement as Age)))), 
									context?.Operators.Quantity(1m, 
										"year")), 
								true, 
								false))
						: (((((abatement is Range as bool?) ?? false))
								? (context?.Operators.Interval(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
											FHIRHelpers_4_0_001.ToQuantity(((abatement as Range))?.Low)), 
										context?.Operators.Add(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
												FHIRHelpers_4_0_001.ToQuantity(((abatement as Range))?.High)), 
											context?.Operators.Quantity(1m, 
												"year")), 
										true, 
										false))
								: ((null as CqlInterval<CqlDate>)))
))
)?.low;
                var b__ = context?.Operators.ConvertDateToDateTime(a__);
                var c__ = (((((abatement is Age as bool?) ?? false))
						? (context?.Operators.Interval(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
									FHIRHelpers_4_0_001.ToQuantity(((Quantity)(abatement as Age)))), 
								context?.Operators.Add(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
										FHIRHelpers_4_0_001.ToQuantity(((Quantity)(abatement as Age)))), 
									context?.Operators.Quantity(1m, 
										"year")), 
								true, 
								false))
						: (((((abatement is Range as bool?) ?? false))
								? (context?.Operators.Interval(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
											FHIRHelpers_4_0_001.ToQuantity(((abatement as Range))?.Low)), 
										context?.Operators.Add(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
												FHIRHelpers_4_0_001.ToQuantity(((abatement as Range))?.High)), 
											context?.Operators.Quantity(1m, 
												"year")), 
										true, 
										false))
								: ((null as CqlInterval<CqlDate>)))
))
)?.high;
                var d__ = context?.Operators.ConvertDateToDateTime(c__);
                var e__ = (((((abatement is Age as bool?) ?? false))
						? (context?.Operators.Interval(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
									FHIRHelpers_4_0_001.ToQuantity(((Quantity)(abatement as Age)))), 
								context?.Operators.Add(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
										FHIRHelpers_4_0_001.ToQuantity(((Quantity)(abatement as Age)))), 
									context?.Operators.Quantity(1m, 
										"year")), 
								true, 
								false))
						: (((((abatement is Range as bool?) ?? false))
								? (context?.Operators.Interval(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
											FHIRHelpers_4_0_001.ToQuantity(((abatement as Range))?.Low)), 
										context?.Operators.Add(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
												FHIRHelpers_4_0_001.ToQuantity(((abatement as Range))?.High)), 
											context?.Operators.Quantity(1m, 
												"year")), 
										true, 
										false))
								: ((null as CqlInterval<CqlDate>)))
))
)?.lowClosed;
                var f__ = (((((abatement is Age as bool?) ?? false))
						? (context?.Operators.Interval(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
									FHIRHelpers_4_0_001.ToQuantity(((Quantity)(abatement as Age)))), 
								context?.Operators.Add(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
										FHIRHelpers_4_0_001.ToQuantity(((Quantity)(abatement as Age)))), 
									context?.Operators.Quantity(1m, 
										"year")), 
								true, 
								false))
						: (((((abatement is Range as bool?) ?? false))
								? (context?.Operators.Interval(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
											FHIRHelpers_4_0_001.ToQuantity(((abatement as Range))?.Low)), 
										context?.Operators.Add(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
												FHIRHelpers_4_0_001.ToQuantity(((abatement as Range))?.High)), 
											context?.Operators.Quantity(1m, 
												"year")), 
										true, 
										false))
								: ((null as CqlInterval<CqlDate>)))
))
)?.highClosed;
                return context?.Operators.Interval(b__, 
					d__, 
					e__, 
					f__);
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
        return context?.Operators.Interval(c_, 
			f_, 
			true, 
			true);
    }

    [CqlDeclaration("Normalize Interval")]
    public CqlInterval<CqlDateTime> Normalize_Interval(object choice)
    {
        if (((choice is FhirDateTime as bool?) ?? false))
            {
                var a__ = (choice as FhirDateTime);
                var b__ = FHIRHelpers_4_0_001.ToDateTime(a__);
                return context?.Operators.Interval(b__, 
					b__, 
					true, 
					true);
            }
        else if (((choice is Date as bool?) ?? false))
            {
                var a__ = (choice as Date);
                var b__ = FHIRHelpers_4_0_001.ToDate(a__);
                var c__ = context?.Operators.ConvertDateToDateTime(b__);
                return context?.Operators.Interval(c__, 
					c__, 
					true, 
					true);
            }
        else if (((choice is Period as bool?) ?? false))
            {
                var a__ = (context?.Operators.LateBoundProperty<FhirDateTime>(choice, 
						"start"))?.Value;
                var b__ = context?.Operators.ConvertStringToDateTime(a__);
                var c__ = (context?.Operators.LateBoundProperty<FhirDateTime>(choice, 
						"end"))?.Value;
                var d__ = context?.Operators.ConvertStringToDateTime(c__);
                return context?.Operators.Interval(b__, 
					d__, 
					true, 
					true);
            }
        else if (((choice is Instant as bool?) ?? false))
            {
                var a__ = (choice as Instant);
                var b__ = FHIRHelpers_4_0_001.ToDateTime(a__);
                return context?.Operators.Interval(b__, 
					b__, 
					true, 
					true);
            }
        else if (((choice is Age as bool?) ?? false))
            {
                var a__ = (context?.Operators.Interval(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
							FHIRHelpers_4_0_001.ToQuantity(((Quantity)(choice as Age)))), 
						context?.Operators.Add(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
								FHIRHelpers_4_0_001.ToQuantity(((Quantity)(choice as Age)))), 
							context?.Operators.Quantity(1m, 
								"year")), 
						true, 
						false))?.low;
                var b__ = context?.Operators.ConvertDateToDateTime(a__);
                var c__ = (context?.Operators.Interval(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
							FHIRHelpers_4_0_001.ToQuantity(((Quantity)(choice as Age)))), 
						context?.Operators.Add(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
								FHIRHelpers_4_0_001.ToQuantity(((Quantity)(choice as Age)))), 
							context?.Operators.Quantity(1m, 
								"year")), 
						true, 
						false))?.high;
                var d__ = context?.Operators.ConvertDateToDateTime(c__);
                var e__ = (context?.Operators.Interval(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
							FHIRHelpers_4_0_001.ToQuantity(((Quantity)(choice as Age)))), 
						context?.Operators.Add(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
								FHIRHelpers_4_0_001.ToQuantity(((Quantity)(choice as Age)))), 
							context?.Operators.Quantity(1m, 
								"year")), 
						true, 
						false))?.lowClosed;
                var f__ = (context?.Operators.Interval(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
							FHIRHelpers_4_0_001.ToQuantity(((Quantity)(choice as Age)))), 
						context?.Operators.Add(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
								FHIRHelpers_4_0_001.ToQuantity(((Quantity)(choice as Age)))), 
							context?.Operators.Quantity(1m, 
								"year")), 
						true, 
						false))?.highClosed;
                return context?.Operators.Interval(b__, 
					d__, 
					e__, 
					f__);
            }
        else if (((choice is Range as bool?) ?? false))
            {
                var a__ = (context?.Operators.Interval(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
							FHIRHelpers_4_0_001.ToQuantity(((choice as Range))?.Low)), 
						context?.Operators.Add(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
								FHIRHelpers_4_0_001.ToQuantity(((choice as Range))?.High)), 
							context?.Operators.Quantity(1m, 
								"year")), 
						true, 
						false))?.low;
                var b__ = context?.Operators.ConvertDateToDateTime(a__);
                var c__ = (context?.Operators.Interval(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
							FHIRHelpers_4_0_001.ToQuantity(((choice as Range))?.Low)), 
						context?.Operators.Add(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
								FHIRHelpers_4_0_001.ToQuantity(((choice as Range))?.High)), 
							context?.Operators.Quantity(1m, 
								"year")), 
						true, 
						false))?.high;
                var d__ = context?.Operators.ConvertDateToDateTime(c__);
                var e__ = (context?.Operators.Interval(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
							FHIRHelpers_4_0_001.ToQuantity(((choice as Range))?.Low)), 
						context?.Operators.Add(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
								FHIRHelpers_4_0_001.ToQuantity(((choice as Range))?.High)), 
							context?.Operators.Quantity(1m, 
								"year")), 
						true, 
						false))?.lowClosed;
                var f__ = (context?.Operators.Interval(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
							FHIRHelpers_4_0_001.ToQuantity(((choice as Range))?.Low)), 
						context?.Operators.Add(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
								FHIRHelpers_4_0_001.ToQuantity(((choice as Range))?.High)), 
							context?.Operators.Quantity(1m, 
								"year")), 
						true, 
						false))?.highClosed;
                return context?.Operators.Interval(b__, 
					d__, 
					e__, 
					f__);
            }
        else if (((choice is Timing as bool?) ?? false))
            return context?.Operators.Message<CqlInterval<CqlDateTime>>((null as CqlInterval<CqlDateTime>), 
				"1", 
				"Error", 
				"Cannot compute a single interval from a Timing type");

        else if (((choice is FhirString as bool?) ?? false))
            return context?.Operators.Message<CqlInterval<CqlDateTime>>((null as CqlInterval<CqlDateTime>), 
				"1", 
				"Error", 
				"Cannot compute an interval from a String value");

        else 
            return (null as CqlInterval<CqlDateTime>);

    }


    [CqlDeclaration("GetId")]
    public string GetId(string uri)
    {
        if ((context?.Operators.Greater((context?.Operators.PositionOf("/", 
					uri) as object), 
(((int?)0) as object)) ?? false))
            {
                var a__ = context?.Operators.Split(uri, 
					"/");
                return context?.Operators.LastOfList<string>(a__);
            }
        else 
            return uri;

    }


    [CqlDeclaration("VS Cast Function")]
    public IEnumerable<CqlCode> VS_Cast_Function(IEnumerable<CqlCode> VSet)
    {
        return VSet;
    }


    [CqlDeclaration("First Dates per 31 Day Periods")]
    public Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT First_Dates_per_31_Day_Periods(IEnumerable<CqlDate> DateList)
    {
        Func<CqlDate,CqlDate> d_ = (d) => d;
        var e_ = context?.Operators.SelectOrNull<CqlDate, CqlDate>(DateList, 
			d_);
        var f_ = context?.Operators.ListSort<CqlDate>(e_, 
			System.ComponentModel.ListSortDirection.Ascending);
        Func<CqlDate,bool?> h_ = (X) => 
        {
            bool? g_ = ((bool?)(X == null));
            return context?.Operators.Not(g_);
        };
        var c_ = context?.Operators.WhereOrNull<CqlDate>(f_, 
			h_);
        var b_ = new Tuples.Tuple_GcLaDggiecCUAgUhQSXhADYJf
		{
			SortedDates = c_,
		};
        var a_ = new Tuples.Tuple_GcLaDggiecCUAgUhQSXhADYJf[]
		{
			b_,
		};
        Func<Tuples.Tuple_GcLaDggiecCUAgUhQSXhADYJf,Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT> al_ = (SortedDates) => 
        {
            var k_ = SortedDates?.SortedDates;
            int? l_ = ((int?)0);
            var j_ = new Tuples.Tuple_GTiMeVaPZjPXLPBaGARAOCFd
			{
				SortedList = k_,
				AnchorIndex = l_,
			};
            var i_ = new Tuples.Tuple_GTiMeVaPZjPXLPBaGARAOCFd[]
			{
				j_,
			};
            Func<Tuples.Tuple_GTiMeVaPZjPXLPBaGARAOCFd,Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT> aj_ = (AnchorList) => 
            {
                var p_ = AnchorList?.SortedList;
                var q_ = AnchorList?.AnchorIndex;
                var o_ = (context?.Operators.ListElementAt<CqlDate>(p_, 
					q_) as CqlDate);
                Func<CqlDate,bool?> ae_ = (X) => 
                {
                    var t_ = AnchorList?.SortedList;
                    var u_ = AnchorList?.AnchorIndex;
                    var s_ = (context?.Operators.ListElementAt<CqlDate>(t_, 
						u_) as CqlDate);
                    var v_ = context?.Operators.Quantity(1m, 
						"day");
                    var w_ = context?.Operators.Add(s_, 
						v_);
                    var aa_ = context?.Operators.Quantity(30m, 
						"days");
                    var ab_ = context?.Operators.Add(s_, 
						aa_);
                    var ac_ = context?.Operators.Interval(w_, 
						ab_, 
						true, 
						true);
                    var ad_ = context?.Operators.ElementInInterval<CqlDate>(X, 
						ac_, 
						null);
                    return context?.Operators.Not(ad_);
                };
                var r_ = context?.Operators.WhereOrNull<CqlDate>(DateList, 
					ae_);
                var af_ = context?.Operators.Add(q_, 
((int?)1));
                var n_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
				{
					NextDate = o_,
					NewList = r_,
					IndexofNewDate = af_,
				};
                var m_ = new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
				{
					n_,
				};
                Func<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT,Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT> ah_ = (FirstList) => (((context?.Operators.ListElementAt<CqlDate>(FirstList?.NewList, 
FirstList?.IndexofNewDate) == null))
						? (FirstList)
						: (context?.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(context?.Operators.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
									{
										new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
										{
											NextDate = (context?.Operators.ListElementAt<CqlDate>(FirstList?.NewList, 
FirstList?.IndexofNewDate) as CqlDate),
											NewList = context?.Operators.WhereOrNull<CqlDate>(FirstList?.NewList, 
												(X) => context?.Operators.Not(context?.Operators.ElementInInterval<CqlDate>(X, 
															context?.Operators.Interval(context?.Operators.Add((context?.Operators.ListElementAt<CqlDate>(FirstList?.NewList, 
FirstList?.IndexofNewDate) as CqlDate), 
																	context?.Operators.Quantity(1m, 
																		"day")), 
																context?.Operators.Add((context?.Operators.ListElementAt<CqlDate>(FirstList?.NewList, 
FirstList?.IndexofNewDate) as CqlDate), 
																	context?.Operators.Quantity(30m, 
																		"days")), 
																true, 
																true), 
															null))),
											IndexofNewDate = context?.Operators.Add(FirstList?.IndexofNewDate, 
((int?)1)),
										},
									}, 
									(SecondList) => (((context?.Operators.ListElementAt<CqlDate>(SecondList?.NewList, 
SecondList?.IndexofNewDate) == null))
											? (SecondList)
											: (context?.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(context?.Operators.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
														{
															new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
															{
																NextDate = (context?.Operators.ListElementAt<CqlDate>(SecondList?.NewList, 
SecondList?.IndexofNewDate) as CqlDate),
																NewList = context?.Operators.WhereOrNull<CqlDate>(SecondList?.NewList, 
																	(X) => context?.Operators.Not(context?.Operators.ElementInInterval<CqlDate>(X, 
																				context?.Operators.Interval(context?.Operators.Add((context?.Operators.ListElementAt<CqlDate>(SecondList?.NewList, 
SecondList?.IndexofNewDate) as CqlDate), 
																						context?.Operators.Quantity(1m, 
																							"day")), 
																					context?.Operators.Add((context?.Operators.ListElementAt<CqlDate>(SecondList?.NewList, 
SecondList?.IndexofNewDate) as CqlDate), 
																						context?.Operators.Quantity(30m, 
																							"days")), 
																					true, 
																					true), 
																				null))),
																IndexofNewDate = context?.Operators.Add(SecondList?.IndexofNewDate, 
((int?)1)),
															},
														}, 
														(ThirdList) => (((context?.Operators.ListElementAt<CqlDate>(ThirdList?.NewList, 
ThirdList?.IndexofNewDate) == null))
																? (ThirdList)
																: (context?.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(context?.Operators.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
																			{
																				new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																				{
																					NextDate = (context?.Operators.ListElementAt<CqlDate>(ThirdList?.NewList, 
ThirdList?.IndexofNewDate) as CqlDate),
																					NewList = context?.Operators.WhereOrNull<CqlDate>(ThirdList?.NewList, 
																						(X) => context?.Operators.Not(context?.Operators.ElementInInterval<CqlDate>(X, 
																									context?.Operators.Interval(context?.Operators.Add((context?.Operators.ListElementAt<CqlDate>(ThirdList?.NewList, 
ThirdList?.IndexofNewDate) as CqlDate), 
																											context?.Operators.Quantity(1m, 
																												"day")), 
																										context?.Operators.Add((context?.Operators.ListElementAt<CqlDate>(ThirdList?.NewList, 
ThirdList?.IndexofNewDate) as CqlDate), 
																											context?.Operators.Quantity(30m, 
																												"days")), 
																										true, 
																										true), 
																									null))),
																					IndexofNewDate = context?.Operators.Add(ThirdList?.IndexofNewDate, 
((int?)1)),
																				},
																			}, 
																			(FourthList) => (((context?.Operators.ListElementAt<CqlDate>(FourthList?.NewList, 
FourthList?.IndexofNewDate) == null))
																					? (FourthList)
																					: (context?.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(context?.Operators.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
																								{
																									new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																									{
																										NextDate = (context?.Operators.ListElementAt<CqlDate>(FourthList?.NewList, 
FourthList?.IndexofNewDate) as CqlDate),
																										NewList = context?.Operators.WhereOrNull<CqlDate>(FourthList?.NewList, 
																											(X) => context?.Operators.Not(context?.Operators.ElementInInterval<CqlDate>(X, 
																														context?.Operators.Interval(context?.Operators.Add((context?.Operators.ListElementAt<CqlDate>(FourthList?.NewList, 
FourthList?.IndexofNewDate) as CqlDate), 
																																context?.Operators.Quantity(1m, 
																																	"day")), 
																															context?.Operators.Add((context?.Operators.ListElementAt<CqlDate>(FourthList?.NewList, 
FourthList?.IndexofNewDate) as CqlDate), 
																																context?.Operators.Quantity(30m, 
																																	"days")), 
																															true, 
																															true), 
																														null))),
																										IndexofNewDate = context?.Operators.Add(FourthList?.IndexofNewDate, 
((int?)1)),
																									},
																								}, 
																								(FifthList) => (((context?.Operators.ListElementAt<CqlDate>(FifthList?.NewList, 
FifthList?.IndexofNewDate) == null))
																										? (FifthList)
																										: (context?.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(context?.Operators.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
																													{
																														new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																														{
																															NextDate = (context?.Operators.ListElementAt<CqlDate>(FifthList?.NewList, 
FifthList?.IndexofNewDate) as CqlDate),
																															NewList = context?.Operators.WhereOrNull<CqlDate>(FifthList?.NewList, 
																																(X) => context?.Operators.Not(context?.Operators.ElementInInterval<CqlDate>(X, 
																																			context?.Operators.Interval(context?.Operators.Add((context?.Operators.ListElementAt<CqlDate>(FifthList?.NewList, 
FifthList?.IndexofNewDate) as CqlDate), 
																																					context?.Operators.Quantity(1m, 
																																						"day")), 
																																				context?.Operators.Add((context?.Operators.ListElementAt<CqlDate>(FifthList?.NewList, 
FifthList?.IndexofNewDate) as CqlDate), 
																																					context?.Operators.Quantity(30m, 
																																						"days")), 
																																				true, 
																																				true), 
																																			null))),
																															IndexofNewDate = context?.Operators.Add(FifthList?.IndexofNewDate, 
((int?)1)),
																														},
																													}, 
																													(SixthList) => (((context?.Operators.ListElementAt<CqlDate>(SixthList?.NewList, 
SixthList?.IndexofNewDate) == null))
																															? (SixthList)
																															: (context?.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(context?.Operators.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
																																		{
																																			new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																																			{
																																				NextDate = (context?.Operators.ListElementAt<CqlDate>(SixthList?.NewList, 
SixthList?.IndexofNewDate) as CqlDate),
																																				NewList = context?.Operators.WhereOrNull<CqlDate>(SixthList?.NewList, 
																																					(X) => context?.Operators.Not(context?.Operators.ElementInInterval<CqlDate>(X, 
																																								context?.Operators.Interval(context?.Operators.Add((context?.Operators.ListElementAt<CqlDate>(SixthList?.NewList, 
SixthList?.IndexofNewDate) as CqlDate), 
																																										context?.Operators.Quantity(1m, 
																																											"day")), 
																																									context?.Operators.Add((context?.Operators.ListElementAt<CqlDate>(SixthList?.NewList, 
SixthList?.IndexofNewDate) as CqlDate), 
																																										context?.Operators.Quantity(30m, 
																																											"days")), 
																																									true, 
																																									true), 
																																								null))),
																																				IndexofNewDate = context?.Operators.Add(SixthList?.IndexofNewDate, 
((int?)1)),
																																			},
																																		}, 
																																		(SeventhList) => (((context?.Operators.ListElementAt<CqlDate>(SeventhList?.NewList, 
SeventhList?.IndexofNewDate) == null))
																																				? (SeventhList)
																																				: (context?.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(context?.Operators.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
																																							{
																																								new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																																								{
																																									NextDate = (context?.Operators.ListElementAt<CqlDate>(SeventhList?.NewList, 
SeventhList?.IndexofNewDate) as CqlDate),
																																									NewList = context?.Operators.WhereOrNull<CqlDate>(SeventhList?.NewList, 
																																										(X) => context?.Operators.Not(context?.Operators.ElementInInterval<CqlDate>(X, 
																																													context?.Operators.Interval(context?.Operators.Add((context?.Operators.ListElementAt<CqlDate>(SeventhList?.NewList, 
SeventhList?.IndexofNewDate) as CqlDate), 
																																															context?.Operators.Quantity(1m, 
																																																"day")), 
																																														context?.Operators.Add((context?.Operators.ListElementAt<CqlDate>(SeventhList?.NewList, 
SeventhList?.IndexofNewDate) as CqlDate), 
																																															context?.Operators.Quantity(30m, 
																																																"days")), 
																																														true, 
																																														true), 
																																													null))),
																																									IndexofNewDate = context?.Operators.Add(SeventhList?.IndexofNewDate, 
((int?)1)),
																																								},
																																							}, 
																																							(EighthList) => (((context?.Operators.ListElementAt<CqlDate>(EighthList?.NewList, 
EighthList?.IndexofNewDate) == null))
																																									? (EighthList)
																																									: (context?.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(context?.Operators.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
																																												{
																																													new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																																													{
																																														NextDate = (context?.Operators.ListElementAt<CqlDate>(EighthList?.NewList, 
EighthList?.IndexofNewDate) as CqlDate),
																																														NewList = context?.Operators.WhereOrNull<CqlDate>(EighthList?.NewList, 
																																															(X) => context?.Operators.Not(context?.Operators.ElementInInterval<CqlDate>(X, 
																																																		context?.Operators.Interval(context?.Operators.Add((context?.Operators.ListElementAt<CqlDate>(EighthList?.NewList, 
EighthList?.IndexofNewDate) as CqlDate), 
																																																				context?.Operators.Quantity(1m, 
																																																					"day")), 
																																																			context?.Operators.Add((context?.Operators.ListElementAt<CqlDate>(EighthList?.NewList, 
EighthList?.IndexofNewDate) as CqlDate), 
																																																				context?.Operators.Quantity(30m, 
																																																					"days")), 
																																																			true, 
																																																			true), 
																																																		null))),
																																														IndexofNewDate = context?.Operators.Add(EighthList?.IndexofNewDate, 
((int?)1)),
																																													},
																																												}, 
																																												(NinethList) => (((context?.Operators.ListElementAt<CqlDate>(NinethList?.NewList, 
NinethList?.IndexofNewDate) == null))
																																														? (NinethList)
																																														: (context?.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(context?.Operators.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
																																																	{
																																																		new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																																																		{
																																																			NextDate = (context?.Operators.ListElementAt<CqlDate>(NinethList?.NewList, 
NinethList?.IndexofNewDate) as CqlDate),
																																																			NewList = context?.Operators.WhereOrNull<CqlDate>(NinethList?.NewList, 
																																																				(X) => context?.Operators.Not(context?.Operators.ElementInInterval<CqlDate>(X, 
																																																							context?.Operators.Interval(context?.Operators.Add((context?.Operators.ListElementAt<CqlDate>(NinethList?.NewList, 
NinethList?.IndexofNewDate) as CqlDate), 
																																																									context?.Operators.Quantity(1m, 
																																																										"day")), 
																																																								context?.Operators.Add((context?.Operators.ListElementAt<CqlDate>(NinethList?.NewList, 
NinethList?.IndexofNewDate) as CqlDate), 
																																																									context?.Operators.Quantity(30m, 
																																																										"days")), 
																																																								true, 
																																																								true), 
																																																							null))),
																																																			IndexofNewDate = context?.Operators.Add(NinethList?.IndexofNewDate, 
((int?)1)),
																																																		},
																																																	}, 
																																																	(TenthList) => (((context?.Operators.ListElementAt<CqlDate>(TenthList?.NewList, 
TenthList?.IndexofNewDate) == null))
																																																			? (TenthList)
																																																			: (context?.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(context?.Operators.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT[]
																																																						{
																																																							new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																																																							{
																																																								NextDate = (context?.Operators.ListElementAt<CqlDate>(TenthList?.NewList, 
TenthList?.IndexofNewDate) as CqlDate),
																																																								NewList = context?.Operators.WhereOrNull<CqlDate>(TenthList?.NewList, 
																																																									(X) => context?.Operators.Not(context?.Operators.ElementInInterval<CqlDate>(X, 
																																																												context?.Operators.Interval(context?.Operators.Add((context?.Operators.ListElementAt<CqlDate>(TenthList?.NewList, 
TenthList?.IndexofNewDate) as CqlDate), 
																																																														context?.Operators.Quantity(1m, 
																																																															"day")), 
																																																													context?.Operators.Add((context?.Operators.ListElementAt<CqlDate>(TenthList?.NewList, 
TenthList?.IndexofNewDate) as CqlDate), 
																																																														context?.Operators.Quantity(30m, 
																																																															"days")), 
																																																													true, 
																																																													true), 
																																																												null))),
																																																								IndexofNewDate = context?.Operators.Add(TenthList?.IndexofNewDate, 
((int?)1)),
																																																							},
																																																						}, 
																																																						(EleventhList) => (((context?.Operators.ListElementAt<CqlDate>(EleventhList?.NewList, 
EleventhList?.IndexofNewDate) == null))
																																																								? (EleventhList)
																																																								: (new Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT
																																																									{
																																																										NextDate = (context?.Operators.ListElementAt<CqlDate>(EleventhList?.NewList, 
EleventhList?.IndexofNewDate) as CqlDate),
																																																										NewList = context?.Operators.WhereOrNull<CqlDate>(EleventhList?.NewList, 
																																																											(X) => context?.Operators.Not(context?.Operators.ElementInInterval<CqlDate>(X, 
																																																														context?.Operators.Interval(context?.Operators.Add((context?.Operators.ListElementAt<CqlDate>(EleventhList?.NewList, 
EleventhList?.IndexofNewDate) as CqlDate), 
																																																																context?.Operators.Quantity(1m, 
																																																																	"day")), 
																																																															context?.Operators.Add((context?.Operators.ListElementAt<CqlDate>(EleventhList?.NewList, 
EleventhList?.IndexofNewDate) as CqlDate), 
																																																																context?.Operators.Quantity(30m, 
																																																																	"days")), 
																																																															true, 
																																																															true), 
																																																														null))),
																																																										IndexofNewDate = context?.Operators.Add(EleventhList?.IndexofNewDate, 
((int?)1)),
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
                var ai_ = context?.Operators.SelectOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(m_, 
					ah_);
                return context?.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(ai_);
            };
            var ak_ = context?.Operators.SelectOrNull<Tuples.Tuple_GTiMeVaPZjPXLPBaGARAOCFd, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(i_, 
				aj_);
            return context?.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(ak_);
        };
        var am_ = context?.Operators.SelectOrNull<Tuples.Tuple_GcLaDggiecCUAgUhQSXhADYJf, Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(a_, 
			al_);
        return context?.Operators.SingleOrNull<Tuples.Tuple_DUDddjZaCdFGjLXVHKdDKIRfT>(am_);
    }

}