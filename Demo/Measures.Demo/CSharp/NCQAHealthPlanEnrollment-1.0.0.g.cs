using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using System.Reflection;
using Hl7.Cql.Operators;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.0.0")]
[CqlLibrary("NCQAHealthPlanEnrollment", "1.0.0")]
public partial class NCQAHealthPlanEnrollment_1_0_0 : ILibrary, ISingleton<NCQAHealthPlanEnrollment_1_0_0>
{
    #region Functions and Expressions (12)

    [CqlFunctionDefinition("CoverageIntervals")]
    public IEnumerable<CqlInterval<CqlDate>> CoverageIntervals(CqlContext context, IEnumerable<Coverage> Coverage, CqlInterval<CqlDate> participationPeriod)
    {

        CqlInterval<CqlDate> a_(Coverage C) {
            Period d_ = C?.Period;
            CqlInterval<CqlDateTime> e_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, d_ as object);
            CqlDateTime f_ = context.Operators.Start(e_);
            CqlDate g_ = context.Operators.DateFrom(f_);
            CqlInterval<CqlDateTime> i_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, d_ as object);
            CqlDateTime j_ = context.Operators.End(i_);
            CqlDate k_ = context.Operators.DateFrom(j_);
            CqlInterval<CqlDate> l_ = context.Operators.Interval(g_, k_, true, true);
            CqlDate m_ = context.Operators.Start(participationPeriod);
            CqlDate n_ = context.Operators.End(participationPeriod);
            CqlInterval<CqlDate> o_ = context.Operators.Interval(m_, n_, true, true);
            CqlInterval<CqlDate> p_ = context.Operators.Intersect<CqlDate>(l_, o_);
            return p_;
        }

        IEnumerable<CqlInterval<CqlDate>> b_ = context.Operators.Select<Coverage, CqlInterval<CqlDate>>(Coverage, a_);
        IEnumerable<CqlInterval<CqlDate>> c_ = context.Operators.Distinct<CqlInterval<CqlDate>>(b_);
        return c_;
    }


    [CqlFunctionDefinition("Collapsed Coverage Intervals")]
    public IEnumerable<CqlInterval<CqlDate>> Collapsed_Coverage_Intervals(CqlContext context, IEnumerable<CqlInterval<CqlDate>> Intervals)
    {
        IEnumerable<CqlInterval<CqlDate>> a_ = NCQACQLBase_1_0_0.Instance.Collapse_Date_Interval_Workaround(context, Intervals);
        return a_;
    }


    [CqlFunctionDefinition("Collapsed Coverage Adjacent Intervals")]
    public IEnumerable<CqlInterval<CqlDate>> Collapsed_Coverage_Adjacent_Intervals(CqlContext context, IEnumerable<CqlInterval<CqlDate>> Intervals)
    {
        IEnumerable<ValueTuple<CqlInterval<CqlDate>, CqlInterval<CqlDate>>> a_ = context.Operators.CrossJoin<CqlInterval<CqlDate>, CqlInterval<CqlDate>>(Intervals, Intervals);

        (CqlTupleMetadata, CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)? b_(ValueTuple<CqlInterval<CqlDate>, CqlInterval<CqlDate>> _valueTuple) {
            (CqlTupleMetadata, CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)? i_ = (CqlTupleMetadata_BaNHUZXcQBUKLNgEDWdDHjYV, _valueTuple.Item1, _valueTuple.Item2);
            return i_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)?> c_ = context.Operators.Select<ValueTuple<CqlInterval<CqlDate>, CqlInterval<CqlDate>>, (CqlTupleMetadata, CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)?>(a_, b_);

        bool? d_((CqlTupleMetadata, CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)? tuple_banhuzxcqbuklngedwddhjyv) {
            CqlDate j_ = context.Operators.End(tuple_banhuzxcqbuklngedwddhjyv?.Coverage1);
            CqlDate k_ = context.Operators.Start(tuple_banhuzxcqbuklngedwddhjyv?.Coverage2);
            CqlQuantity l_ = context.Operators.Quantity(1m, "day");
            CqlDate m_ = context.Operators.Subtract(k_, l_);
            CqlDate p_ = context.Operators.Add(k_, l_);
            CqlInterval<CqlDate> q_ = context.Operators.Interval(m_, p_, true, true);
            bool? r_ = context.Operators.In<CqlDate>(j_, q_, (string)default);
            bool? t_ = context.Operators.Not((bool?)(k_ is null));
            bool? u_ = context.Operators.And(r_, t_);
            return u_;
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)?> e_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)?>(c_, d_);

        CqlInterval<CqlDate> f_((CqlTupleMetadata, CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)? tuple_banhuzxcqbuklngedwddhjyv) {
            CqlDate v_ = context.Operators.Start(tuple_banhuzxcqbuklngedwddhjyv?.Coverage1);
            CqlDate w_ = context.Operators.End(tuple_banhuzxcqbuklngedwddhjyv?.Coverage2);
            CqlInterval<CqlDate> x_ = context.Operators.Interval(v_, w_, true, true);
            return x_;
        }

        IEnumerable<CqlInterval<CqlDate>> g_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)?, CqlInterval<CqlDate>>(e_, f_);
        IEnumerable<CqlInterval<CqlDate>> h_ = context.Operators.Distinct<CqlInterval<CqlDate>>(g_);
        return h_;
    }


    [CqlFunctionDefinition("Collapsed Final Coverage Intervals")]
    public IEnumerable<CqlInterval<CqlDate>> Collapsed_Final_Coverage_Intervals(CqlContext context, IEnumerable<CqlInterval<CqlDate>> collapsedI, IEnumerable<CqlInterval<CqlDate>> adjacentI)
    {
        IEnumerable<CqlInterval<CqlDate>> a_ = this.Collapsed_Coverage_Intervals(context, collapsedI);
        IEnumerable<CqlInterval<CqlDate>> b_ = this.Collapsed_Coverage_Adjacent_Intervals(context, adjacentI);
        IEnumerable<CqlInterval<CqlDate>> c_ = context.Operators.Union<CqlInterval<CqlDate>>(a_, b_);
        IEnumerable<CqlInterval<CqlDate>> d_ = NCQACQLBase_1_0_0.Instance.Collapse_Date_Interval_Workaround(context, c_);
        return d_;
    }


    [CqlFunctionDefinition("All Coverage Info")]
    public IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> All_Coverage_Info(CqlContext context, IEnumerable<Coverage> Coverage, CqlInterval<CqlDate> participationPeriod)
    {

        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? a_(Coverage C) {
            IEnumerable<CqlInterval<CqlDate>> d_ = this.CoverageIntervals(context, Coverage, participationPeriod);
            IEnumerable<CqlInterval<CqlDate>> f_ = this.Collapsed_Coverage_Intervals(context, d_);
            IEnumerable<CqlInterval<CqlDate>> h_ = this.Collapsed_Coverage_Intervals(context, d_);
            IEnumerable<CqlInterval<CqlDate>> i_ = this.Collapsed_Coverage_Adjacent_Intervals(context, h_);
            IEnumerable<CqlInterval<CqlDate>> k_ = this.Collapsed_Coverage_Intervals(context, d_);
            IEnumerable<CqlInterval<CqlDate>> m_ = this.Collapsed_Coverage_Intervals(context, d_);
            IEnumerable<CqlInterval<CqlDate>> n_ = this.Collapsed_Coverage_Adjacent_Intervals(context, m_);
            IEnumerable<CqlInterval<CqlDate>> o_ = this.Collapsed_Final_Coverage_Intervals(context, k_, n_);
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? p_ = (CqlTupleMetadata_DPLIOBaSciHAAETJOMSIjWgbP, d_, f_, i_, o_);
            return p_;
        }

        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> b_ = context.Operators.Select<Coverage, (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?>(Coverage, a_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> c_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?>(b_);
        return c_;
    }


    [CqlFunctionDefinition("Health Plan Enrollment Criteria")]
    public bool? Health_Plan_Enrollment_Criteria(CqlContext context, IEnumerable<Coverage> Coverage, CqlDate AnchorDate, CqlInterval<CqlDate> participationPeriod, int? AllowedGapDays)
    {
        IEnumerable<Coverage> a_ = this.Health_Plan_Coverage_Resources(context, Coverage);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> b_ = this.All_Coverage_Info(context, a_, participationPeriod);

        bool? c_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? @this) {
            IEnumerable<CqlInterval<CqlDate>> n_ = @this?.CollapsedFinal;
            bool? o_ = context.Operators.Not((bool?)(n_ is null));
            return o_;
        }

        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> d_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?>(b_, c_);

        IEnumerable<CqlInterval<CqlDate>> e_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? @this) {
            IEnumerable<CqlInterval<CqlDate>> p_ = @this?.CollapsedFinal;
            return p_;
        }

        IEnumerable<IEnumerable<CqlInterval<CqlDate>>> f_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?, IEnumerable<CqlInterval<CqlDate>>>(d_, e_);
        IEnumerable<CqlInterval<CqlDate>> g_ = context.Operators.Flatten<CqlInterval<CqlDate>>(f_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? h_ = NCQACQLBase_1_0_0.Instance.Date_Interval_Gaps_Relative_to_Base_Interval_Stats(context, participationPeriod, g_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?[] i_ = [
            h_,
        ];

        bool? j_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? GapsInEnrollment) {
            int? q_ = GapsInEnrollment?.Interval_Count;
            bool? r_ = context.Operators.LessOrEqual(q_, 1);
            int? s_ = GapsInEnrollment?.Total_Days_In_Longest_Interval;
            bool? t_ = context.Operators.LessOrEqual(s_, AllowedGapDays);
            bool? u_ = context.Operators.And(r_, t_);
            bool? v_ = this.Anchor_Date_Criteria(context, Coverage, AnchorDate, participationPeriod);
            bool? w_ = context.Operators.And(u_, v_);
            return w_;
        }

        IEnumerable<bool?> k_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?, bool?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>)i_, j_);
        IEnumerable<bool?> l_ = context.Operators.Distinct<bool?>(k_);
        bool? m_ = context.Operators.SingletonFrom<bool?>(l_);
        return m_;
    }


    [CqlFunctionDefinition("Health Plan Coverage Resources")]
    public IEnumerable<Coverage> Health_Plan_Coverage_Resources(CqlContext context, IEnumerable<Coverage> Coverage)
    {

        bool? a_(Coverage C) {
            CodeableConcept e_ = C?.Type;
            List<Coding> f_ = e_?.Coding;

            bool? g_(Coding cTypeCoding) {
                CqlCode j_ = FHIRHelpers_4_0_001.Instance.ToCode(context, cTypeCoding);
                CqlCode k_ = NCQATerminology_1_0_0.Instance.managed_care_policy(context);
                bool? l_ = context.Operators.Equivalent(j_, k_);
                CqlCode n_ = NCQATerminology_1_0_0.Instance.retiree_health_program(context);
                bool? o_ = context.Operators.Equivalent(j_, n_);
                bool? p_ = context.Operators.Or(l_, o_);
                CqlCode r_ = NCQATerminology_1_0_0.Instance.subsidized_health_program(context);
                bool? s_ = context.Operators.Equivalent(j_, r_);
                bool? t_ = context.Operators.Or(p_, s_);
                return t_;
            }

            IEnumerable<Coding> h_ = context.Operators.Where<Coding>((IEnumerable<Coding>)f_, g_);
            bool? i_ = context.Operators.Exists<Coding>(h_);
            return i_;
        }

        IEnumerable<Coverage> b_ = context.Operators.Where<Coverage>(Coverage, a_);

        bool? c_(Coverage HPCoverageResource) {
            bool? u_ = context.Operators.Not((bool?)(HPCoverageResource is null));
            return u_;
        }

        IEnumerable<Coverage> d_ = context.Operators.Where<Coverage>(b_, c_);
        return d_;
    }


    [CqlFunctionDefinition("Anchor Date Criteria")]
    public bool? Anchor_Date_Criteria(CqlContext context, IEnumerable<Coverage> Coverage, CqlDate AnchorDate, CqlInterval<CqlDate> participationPeriod)
    {

        bool? a_() {

            bool b_() {
                bool? c_ = context.Operators.In<CqlDate>(AnchorDate, participationPeriod, (string)default);
                bool? d_ = context.Operators.Not(c_);
                return d_ ?? false;
            }

            if ((context.Operators.In<CqlDate>(AnchorDate, participationPeriod, (string)default)) ?? false)
            {
                IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> e_ = this.All_Coverage_Info(context, Coverage, participationPeriod);

                bool? f_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? @this) {
                    IEnumerable<CqlInterval<CqlDate>> n_ = @this?.CollapsedFinal;
                    bool? o_ = context.Operators.Not((bool?)(n_ is null));
                    return o_;
                }

                IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> g_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?>(e_, f_);

                IEnumerable<CqlInterval<CqlDate>> h_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? @this) {
                    IEnumerable<CqlInterval<CqlDate>> p_ = @this?.CollapsedFinal;
                    return p_;
                }

                IEnumerable<IEnumerable<CqlInterval<CqlDate>>> i_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?, IEnumerable<CqlInterval<CqlDate>>>(g_, h_);
                IEnumerable<CqlInterval<CqlDate>> j_ = context.Operators.Flatten<CqlInterval<CqlDate>>(i_);

                bool? k_(CqlInterval<CqlDate> FinalInterval) {
                    bool? q_ = context.Operators.In<CqlDate>(AnchorDate, FinalInterval, (string)default);
                    return q_;
                }

                IEnumerable<CqlInterval<CqlDate>> l_ = context.Operators.Where<CqlInterval<CqlDate>>(j_, k_);
                bool? m_ = context.Operators.Exists<CqlInterval<CqlDate>>(l_);
                return m_;
            }
            else if (b_())
            {

                bool? r_(Coverage @this) {
                    Period y_ = @this?.Period;
                    bool? z_ = context.Operators.Not((bool?)(y_ is null));
                    return z_;
                }

                IEnumerable<Coverage> s_ = context.Operators.Where<Coverage>(Coverage, r_);

                Period t_(Coverage @this) {
                    Period aa_ = @this?.Period;
                    return aa_;
                }

                IEnumerable<Period> u_ = context.Operators.Select<Coverage, Period>(s_, t_);

                bool? v_(Period Cperiod) {
                    CqlInterval<CqlDateTime> ab_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, Cperiod as object);
                    CqlDateTime ac_ = context.Operators.Start(ab_);
                    CqlDate ad_ = context.Operators.DateFrom(ac_);
                    CqlDateTime af_ = context.Operators.End(ab_);
                    CqlDate ag_ = context.Operators.DateFrom(af_);
                    CqlInterval<CqlDate> ah_ = context.Operators.Interval(ad_, ag_, true, true);
                    bool? ai_ = context.Operators.In<CqlDate>(AnchorDate, ah_, (string)default);
                    return ai_;
                }

                IEnumerable<Period> w_ = context.Operators.Where<Period>(u_, v_);
                bool? x_ = context.Operators.Exists<Period>(w_);
                return x_;
            }
            else if (AnchorDate is null)
            {
                return true;
            }
            else
            {
                return false;
            };
        }

        return a_();
    }


    [CqlFunctionDefinition("Pharmacy Benefit Enrollment Criteria")]
    public bool? Pharmacy_Benefit_Enrollment_Criteria(CqlContext context, IEnumerable<Coverage> PharmCoverage, CqlDate AnchorDate, CqlInterval<CqlDate> participationPeriod, int? AllowedGapDays)
    {
        IEnumerable<Coverage> a_ = this.Pharmacy_Benefit_Coverage_Resources(context, PharmCoverage);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> b_ = this.All_Coverage_Info(context, a_, participationPeriod);

        bool? c_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? @this) {
            IEnumerable<CqlInterval<CqlDate>> n_ = @this?.CollapsedFinal;
            bool? o_ = context.Operators.Not((bool?)(n_ is null));
            return o_;
        }

        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> d_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?>(b_, c_);

        IEnumerable<CqlInterval<CqlDate>> e_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? @this) {
            IEnumerable<CqlInterval<CqlDate>> p_ = @this?.CollapsedFinal;
            return p_;
        }

        IEnumerable<IEnumerable<CqlInterval<CqlDate>>> f_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?, IEnumerable<CqlInterval<CqlDate>>>(d_, e_);
        IEnumerable<CqlInterval<CqlDate>> g_ = context.Operators.Flatten<CqlInterval<CqlDate>>(f_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? h_ = NCQACQLBase_1_0_0.Instance.Date_Interval_Gaps_Relative_to_Base_Interval_Stats(context, participationPeriod, g_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?[] i_ = [
            h_,
        ];

        bool? j_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? GapsInEnrollment) {
            int? q_ = GapsInEnrollment?.Interval_Count;
            bool? r_ = context.Operators.LessOrEqual(q_, 1);
            int? s_ = GapsInEnrollment?.Total_Days_In_Longest_Interval;
            bool? t_ = context.Operators.LessOrEqual(s_, AllowedGapDays);
            bool? u_ = context.Operators.And(r_, t_);
            bool? v_ = this.Anchor_Date_Criteria(context, PharmCoverage, AnchorDate, participationPeriod);
            bool? w_ = context.Operators.And(u_, v_);
            return w_;
        }

        IEnumerable<bool?> k_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?, bool?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>)i_, j_);
        IEnumerable<bool?> l_ = context.Operators.Distinct<bool?>(k_);
        bool? m_ = context.Operators.SingletonFrom<bool?>(l_);
        return m_;
    }


    [CqlFunctionDefinition("Pharmacy Benefit Coverage Resources")]
    public IEnumerable<Coverage> Pharmacy_Benefit_Coverage_Resources(CqlContext context, IEnumerable<Coverage> Coverage)
    {

        bool? a_(Coverage C) {
            CodeableConcept e_ = C?.Type;
            List<Coding> f_ = e_?.Coding;

            bool? g_(Coding cTypeCoding) {
                CqlCode j_ = FHIRHelpers_4_0_001.Instance.ToCode(context, cTypeCoding);
                CqlCode k_ = NCQATerminology_1_0_0.Instance.drug_policy(context);
                bool? l_ = context.Operators.Equivalent(j_, k_);
                return l_;
            }

            IEnumerable<Coding> h_ = context.Operators.Where<Coding>((IEnumerable<Coding>)f_, g_);
            bool? i_ = context.Operators.Exists<Coding>(h_);
            return i_;
        }

        IEnumerable<Coverage> b_ = context.Operators.Where<Coverage>(Coverage, a_);

        bool? c_(Coverage pharmacyCoverageResource) {
            bool? m_ = context.Operators.Not((bool?)(pharmacyCoverageResource is null));
            return m_;
        }

        IEnumerable<Coverage> d_ = context.Operators.Where<Coverage>(b_, c_);
        return d_;
    }


    [CqlFunctionDefinition("Mental Health Benefit Enrollment Criteria")]
    public bool? Mental_Health_Benefit_Enrollment_Criteria(CqlContext context, IEnumerable<Coverage> MHCoverage, CqlDate AnchorDate, CqlInterval<CqlDate> participationPeriod, int? AllowedGapDays)
    {
        IEnumerable<Coverage> a_ = this.Mental_Health_Benefit_Coverage_Resources(context, MHCoverage);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> b_ = this.All_Coverage_Info(context, a_, participationPeriod);

        bool? c_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? @this) {
            IEnumerable<CqlInterval<CqlDate>> n_ = @this?.CollapsedFinal;
            bool? o_ = context.Operators.Not((bool?)(n_ is null));
            return o_;
        }

        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> d_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?>(b_, c_);

        IEnumerable<CqlInterval<CqlDate>> e_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? @this) {
            IEnumerable<CqlInterval<CqlDate>> p_ = @this?.CollapsedFinal;
            return p_;
        }

        IEnumerable<IEnumerable<CqlInterval<CqlDate>>> f_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?, IEnumerable<CqlInterval<CqlDate>>>(d_, e_);
        IEnumerable<CqlInterval<CqlDate>> g_ = context.Operators.Flatten<CqlInterval<CqlDate>>(f_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? h_ = NCQACQLBase_1_0_0.Instance.Date_Interval_Gaps_Relative_to_Base_Interval_Stats(context, participationPeriod, g_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?[] i_ = [
            h_,
        ];

        bool? j_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? GapsInEnrollment) {
            int? q_ = GapsInEnrollment?.Interval_Count;
            bool? r_ = context.Operators.LessOrEqual(q_, 1);
            int? s_ = GapsInEnrollment?.Total_Days_In_Longest_Interval;
            bool? t_ = context.Operators.LessOrEqual(s_, AllowedGapDays);
            bool? u_ = context.Operators.And(r_, t_);
            bool? v_ = this.Anchor_Date_Criteria(context, MHCoverage, AnchorDate, participationPeriod);
            bool? w_ = context.Operators.And(u_, v_);
            return w_;
        }

        IEnumerable<bool?> k_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?, bool?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>)i_, j_);
        IEnumerable<bool?> l_ = context.Operators.Distinct<bool?>(k_);
        bool? m_ = context.Operators.SingletonFrom<bool?>(l_);
        return m_;
    }


    [CqlFunctionDefinition("Mental Health Benefit Coverage Resources")]
    public IEnumerable<Coverage> Mental_Health_Benefit_Coverage_Resources(CqlContext context, IEnumerable<Coverage> Coverage)
    {

        bool? a_(Coverage C) {
            CodeableConcept e_ = C?.Type;
            List<Coding> f_ = e_?.Coding;

            bool? g_(Coding cTypeCoding) {
                CqlCode j_ = FHIRHelpers_4_0_001.Instance.ToCode(context, cTypeCoding);
                CqlCode k_ = NCQATerminology_1_0_0.Instance.mental_health_policy(context);
                bool? l_ = context.Operators.Equivalent(j_, k_);
                return l_;
            }

            IEnumerable<Coding> h_ = context.Operators.Where<Coding>((IEnumerable<Coding>)f_, g_);
            bool? i_ = context.Operators.Exists<Coding>(h_);
            return i_;
        }

        IEnumerable<Coverage> b_ = context.Operators.Where<Coverage>(Coverage, a_);

        bool? c_(Coverage mentalHealthCoverageResource) {
            bool? m_ = context.Operators.Not((bool?)(mentalHealthCoverageResource is null));
            return m_;
        }

        IEnumerable<Coverage> d_ = context.Operators.Where<Coverage>(b_, c_);
        return d_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private NCQAHealthPlanEnrollment_1_0_0() {}

    public static NCQAHealthPlanEnrollment_1_0_0 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "NCQAHealthPlanEnrollment";
    public string Version => "1.0.0";
    public ILibrary[] Dependencies => [NCQACQLBase_1_0_0.Instance, FHIRHelpers_4_0_001.Instance, NCQATerminology_1_0_0.Instance, NCQAFHIRBase_1_0_0.Instance];

    #endregion ILibrary Implementation

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_BaNHUZXcQBUKLNgEDWdDHjYV = new(
       [typeof(CqlInterval<CqlDate>), typeof(CqlInterval<CqlDate>)],
       ["Coverage1", "Coverage2"]);

    private static CqlTupleMetadata CqlTupleMetadata_DPLIOBaSciHAAETJOMSIjWgbP = new(
       [typeof(IEnumerable<CqlInterval<CqlDate>>), typeof(IEnumerable<CqlInterval<CqlDate>>), typeof(IEnumerable<CqlInterval<CqlDate>>), typeof(IEnumerable<CqlInterval<CqlDate>>)],
       ["IntervalInfo", "Collapsed", "Adjacent", "CollapsedFinal"]);

    #endregion CqlTupleMetadata Properties

}
