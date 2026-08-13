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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.0.0")]
[CqlLibrary("NCQACQLBase", "1.0.0")]
public partial class NCQACQLBase_1_0_0 : ILibrary, ISingleton<NCQACQLBase_1_0_0>
{
    #region Functions and Expressions (17)

    [CqlFunctionDefinition("Sort Date Intervals")]
    public IEnumerable<CqlInterval<CqlDate>> Sort_Date_Intervals(CqlContext context, IEnumerable<CqlInterval<CqlDate>> intervals)
    {
        if (intervals is null)
        {
            CqlInterval<CqlDate>[] a_ = [];
            return a_ as IEnumerable<CqlInterval<CqlDate>>;
        }
        else
        {
            int? b_ = context.Operators.Count<CqlInterval<CqlDate>>(intervals);
            bool? c_ = context.Operators.Equal(b_, 0);
            if (c_ ?? false)
            {
                CqlInterval<CqlDate>[] d_ = [];
                return d_ as IEnumerable<CqlInterval<CqlDate>>;
            }
            else
            {

                (CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)? e_(CqlInterval<CqlDate> I) {
                    CqlDate k_;
                    if ((context.Operators.Start(I)) is null)
                    {
                        CqlDate m_ = context.Operators.MinValue<CqlDate>();
                        k_ = m_;
                    }
                    else
                    {
                        CqlDate n_ = context.Operators.Start(I);
                        k_ = n_;
                    }
                    (CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)? l_ = (CqlTupleMetadata_GIMHfXDcFiAjSJBDGYeUeZLhW, I, k_);
                    return l_;
                }

                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)?> f_ = context.Operators.SelectDistinct<CqlInterval<CqlDate>, (CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)?>(intervals, e_);

                object g_((CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)? @this) {
                    CqlDate o_ = @this?.startOfInterval;
                    return o_;
                }

                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)?> h_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)?>(f_, g_, System.ComponentModel.ListSortDirection.Ascending);

                CqlInterval<CqlDate> i_((CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)? sortedIntervals) {
                    CqlInterval<CqlDate> p_ = sortedIntervals?.interval;
                    return p_;
                }

                IEnumerable<CqlInterval<CqlDate>> j_ = context.Operators.SelectDistinct<(CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)?, CqlInterval<CqlDate>>(h_, i_);
                return j_;
            }
        }
    }


    [CqlFunctionDefinition("Sort DateTime Intervals")]
    public IEnumerable<CqlInterval<CqlDateTime>> Sort_DateTime_Intervals(CqlContext context, IEnumerable<CqlInterval<CqlDateTime>> intervals)
    {
        if (intervals is null)
        {
            CqlInterval<CqlDateTime>[] a_ = [];
            return a_ as IEnumerable<CqlInterval<CqlDateTime>>;
        }
        else
        {
            int? b_ = context.Operators.Count<CqlInterval<CqlDateTime>>(intervals);
            bool? c_ = context.Operators.Equal(b_, 0);
            if (c_ ?? false)
            {
                CqlInterval<CqlDateTime>[] d_ = [];
                return d_ as IEnumerable<CqlInterval<CqlDateTime>>;
            }
            else
            {

                (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)? e_(CqlInterval<CqlDateTime> I) {
                    CqlDateTime k_;
                    if ((context.Operators.Start(I)) is null)
                    {
                        CqlDateTime m_ = context.Operators.MinValue<CqlDateTime>();
                        k_ = m_;
                    }
                    else
                    {
                        CqlDateTime n_ = context.Operators.Start(I);
                        k_ = n_;
                    }
                    (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)? l_ = (CqlTupleMetadata_EQHOUSiiWahbJPOUjJGEhIAOV, I, k_);
                    return l_;
                }

                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?> f_ = context.Operators.SelectDistinct<CqlInterval<CqlDateTime>, (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?>(intervals, e_);

                object g_((CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)? @this) {
                    CqlDateTime o_ = @this?.startOfInterval;
                    return o_;
                }

                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?> h_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?>(f_, g_, System.ComponentModel.ListSortDirection.Ascending);

                CqlInterval<CqlDateTime> i_((CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)? sortedIntervals) {
                    CqlInterval<CqlDateTime> p_ = sortedIntervals?.interval;
                    return p_;
                }

                IEnumerable<CqlInterval<CqlDateTime>> j_ = context.Operators.SelectDistinct<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?, CqlInterval<CqlDateTime>>(h_, i_);
                return j_;
            }
        }
    }


    [CqlFunctionDefinition("Collapse Date Interval Workaround")]
    public IEnumerable<CqlInterval<CqlDate>> Collapse_Date_Interval_Workaround(CqlContext context, IEnumerable<CqlInterval<CqlDate>> intervals)
    {
        if (intervals is null)
        {
            CqlInterval<CqlDate>[] a_ = [];
            return a_ as IEnumerable<CqlInterval<CqlDate>>;
        }
        else
        {
            int? b_ = context.Operators.Count<CqlInterval<CqlDate>>(intervals);
            bool? c_ = context.Operators.Equal(b_, 0);
            if (c_ ?? false)
            {
                CqlInterval<CqlDate>[] d_ = [];
                return d_ as IEnumerable<CqlInterval<CqlDate>>;
            }
            else
            {

                bool? e_(CqlInterval<CqlDate> I) {

                    bool? h_(CqlInterval<CqlDate> J) {
                        bool? k_ = context.Operators.IntervalProperlyIncludesInterval<CqlDate>(J, I, (string)default);
                        return k_;
                    }

                    IEnumerable<bool?> i_ = context.Operators.SelectDistinct<CqlInterval<CqlDate>, bool?>(intervals, h_);
                    bool? j_ = context.Operators.AnyTrue(i_);
                    return !j_;
                }

                IEnumerable<CqlInterval<CqlDate>> f_ = context.Operators.Where<CqlInterval<CqlDate>>(intervals, e_);
                IEnumerable<CqlInterval<CqlDate>> g_ = context.Operators.Collapse(f_, "day");
                return g_;
            }
        }
    }


    [CqlFunctionDefinition("Collapse DateTime Interval Workaround")]
    public IEnumerable<CqlInterval<CqlDateTime>> Collapse_DateTime_Interval_Workaround(CqlContext context, IEnumerable<CqlInterval<CqlDateTime>> intervals)
    {
        if (intervals is null)
        {
            CqlInterval<CqlDateTime>[] a_ = [];
            return a_ as IEnumerable<CqlInterval<CqlDateTime>>;
        }
        else
        {
            int? b_ = context.Operators.Count<CqlInterval<CqlDateTime>>(intervals);
            bool? c_ = context.Operators.Equal(b_, 0);
            if (c_ ?? false)
            {
                CqlInterval<CqlDateTime>[] d_ = [];
                return d_ as IEnumerable<CqlInterval<CqlDateTime>>;
            }
            else
            {

                bool? e_(CqlInterval<CqlDateTime> I) {

                    bool? h_(CqlInterval<CqlDateTime> J) {
                        bool? k_ = context.Operators.IntervalProperlyIncludesInterval<CqlDateTime>(J, I, (string)default);
                        return k_;
                    }

                    IEnumerable<bool?> i_ = context.Operators.SelectDistinct<CqlInterval<CqlDateTime>, bool?>(intervals, h_);
                    bool? j_ = context.Operators.AnyTrue(i_);
                    return !j_;
                }

                IEnumerable<CqlInterval<CqlDateTime>> f_ = context.Operators.Where<CqlInterval<CqlDateTime>>(intervals, e_);
                IEnumerable<CqlInterval<CqlDateTime>> g_ = context.Operators.Collapse(f_, (string)default);
                return g_;
            }
        }
    }


    [CqlFunctionDefinition("Date Interval Covering Relative to Base Interval")]
    public IEnumerable<CqlInterval<CqlDate>> Date_Interval_Covering_Relative_to_Base_Interval(CqlContext context, CqlInterval<CqlDate> baseInterval, IEnumerable<CqlInterval<CqlDate>> coveringIntervals)
    {
        IEnumerable<CqlInterval<CqlDate>> a_ = this.Sort_Date_Intervals(context, coveringIntervals);

        CqlInterval<CqlDate> b_(CqlInterval<CqlDate> sortedInterval) {
            CqlInterval<CqlDate> e_ = context.Operators.Intersect<CqlDate>(baseInterval, sortedInterval);
            return e_;
        }

        IEnumerable<CqlInterval<CqlDate>> c_ = context.Operators.SelectDistinct<CqlInterval<CqlDate>, CqlInterval<CqlDate>>(a_, b_);
        IEnumerable<CqlInterval<CqlDate>> d_ = this.Collapse_Date_Interval_Workaround(context, c_);
        return d_;
    }


    [CqlFunctionDefinition("DateTime Interval Covering Relative to Base Interval")]
    public IEnumerable<CqlInterval<CqlDateTime>> DateTime_Interval_Covering_Relative_to_Base_Interval(CqlContext context, CqlInterval<CqlDateTime> baseInterval, IEnumerable<CqlInterval<CqlDateTime>> coveringIntervals)
    {
        IEnumerable<CqlInterval<CqlDateTime>> a_ = this.Sort_DateTime_Intervals(context, coveringIntervals);

        CqlInterval<CqlDateTime> b_(CqlInterval<CqlDateTime> sortedInterval) {
            CqlInterval<CqlDateTime> e_ = context.Operators.Intersect<CqlDateTime>(baseInterval, sortedInterval);
            return e_;
        }

        IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.SelectDistinct<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(a_, b_);
        IEnumerable<CqlInterval<CqlDateTime>> d_ = this.Collapse_DateTime_Interval_Workaround(context, c_);
        return d_;
    }


    [CqlFunctionDefinition("Date Interval Gaps Relative to Base Interval")]
    public IEnumerable<CqlInterval<CqlDate>> Date_Interval_Gaps_Relative_to_Base_Interval(CqlContext context, CqlInterval<CqlDate> baseInterval, IEnumerable<CqlInterval<CqlDate>> coveringIntervals)
    {
        IEnumerable<CqlInterval<CqlDate>> a_ = this.Date_Interval_Covering_Relative_to_Base_Interval(context, baseInterval, coveringIntervals);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> sortedCoverings)? b_ = (CqlTupleMetadata_EVRLVXPcBiDTIWfCCfKEWDfKI, a_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> sortedCoverings)?[] c_ = [
            b_,
        ];

        IEnumerable<CqlInterval<CqlDate>> d_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> sortedCoverings)? variableDeclarations) {
            IEnumerable<CqlInterval<CqlDate>> g_;
            IEnumerable<CqlInterval<CqlDate>> n_ = variableDeclarations?.sortedCoverings;
            int? o_ = context.Operators.Count<CqlInterval<CqlDate>>(n_);
            bool? p_ = context.Operators.Equal(o_, 0);
            if (p_ ?? false)
            {
                CqlInterval<CqlDate>[] q_ = [
                    baseInterval,
                ];
                g_ = (IEnumerable<CqlInterval<CqlDate>>)q_;
            }
            else
            {
                IEnumerable<CqlInterval<CqlDate>> r_ = variableDeclarations?.sortedCoverings;

                CqlInterval<CqlDate> s_(CqlInterval<CqlDate> sortedCovering) {
                    IEnumerable<CqlInterval<CqlDate>> u_ = variableDeclarations?.sortedCoverings;
                    int? v_ = context.Operators.IndexOf<CqlInterval<CqlDate>>(u_, sortedCovering);
                    bool? w_ = context.Operators.Equal(v_, 0);
                    if (w_ ?? false)
                    {
                        CqlDate x_ = context.Operators.Start(baseInterval);
                        CqlDate y_ = context.Operators.Start(sortedCovering);
                        CqlInterval<CqlDate> z_ = context.Operators.Interval(x_, y_, true, true);
                        CqlInterval<CqlDate> aa_ = context.Operators.Intersect<CqlDate>(z_, baseInterval);
                        CqlInterval<CqlDate> ab_ = context.Operators.Except(aa_, sortedCovering);
                        return ab_;
                    }
                    else
                    {
                        IEnumerable<CqlInterval<CqlDate>> ac_ = variableDeclarations?.sortedCoverings;
                        int? ad_ = context.Operators.IndexOf<CqlInterval<CqlDate>>(ac_, sortedCovering);
                        int? ae_ = context.Operators.Subtract(ad_, 1);
                        CqlInterval<CqlDate> af_ = context.Operators.Indexer<CqlInterval<CqlDate>>(ac_, ae_);
                        CqlDate ag_ = context.Operators.Start(af_);
                        CqlDate ah_ = context.Operators.End(sortedCovering);
                        CqlInterval<CqlDate> ai_ = context.Operators.Interval(ag_, ah_, false, false);
                        CqlInterval<CqlDate> aj_ = context.Operators.Except(ai_, af_);
                        CqlInterval<CqlDate> ak_ = context.Operators.Except(aj_, sortedCovering);
                        return ak_;
                    }
                }

                IEnumerable<CqlInterval<CqlDate>> t_ = context.Operators.SelectDistinct<CqlInterval<CqlDate>, CqlInterval<CqlDate>>(r_, s_);
                g_ = t_;
            }
            IEnumerable<CqlInterval<CqlDate>> h_;
            IEnumerable<CqlInterval<CqlDate>> al_ = variableDeclarations?.sortedCoverings;
            int? am_ = context.Operators.Count<CqlInterval<CqlDate>>(al_);
            bool? an_ = context.Operators.Equal(am_, 0);
            if (an_ ?? false)
            {
                CqlInterval<CqlDate>[] ao_ = [];
                h_ = ao_ as IEnumerable<CqlInterval<CqlDate>>;
            }
            else
            {
                IEnumerable<CqlInterval<CqlDate>> ap_ = variableDeclarations?.sortedCoverings;
                CqlInterval<CqlDate> aq_ = context.Operators.Last<CqlInterval<CqlDate>>(ap_);
                CqlDate ar_ = context.Operators.Start(aq_);
                CqlDate as_ = context.Operators.End(baseInterval);
                CqlInterval<CqlDate> at_ = context.Operators.Interval(ar_, as_, false, true);
                CqlInterval<CqlDate> au_ = context.Operators.Except(at_, aq_);
                CqlInterval<CqlDate> av_ = context.Operators.Intersect<CqlDate>(au_, baseInterval);
                CqlInterval<CqlDate>[] aw_ = [
                    av_,
                ];
                h_ = (IEnumerable<CqlInterval<CqlDate>>)aw_;
            }
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> frontgaps, IEnumerable<CqlInterval<CqlDate>> endgap)? i_ = (CqlTupleMetadata_FKcLSALRMRfDigEFaJgDOPFRK, g_, h_);
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> frontgaps, IEnumerable<CqlInterval<CqlDate>> endgap)?[] j_ = [
                i_,
            ];

            IEnumerable<CqlInterval<CqlDate>> k_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> frontgaps, IEnumerable<CqlInterval<CqlDate>> endgap)? calculations) {
                IEnumerable<CqlInterval<CqlDate>> ax_ = calculations?.frontgaps;
                IEnumerable<CqlInterval<CqlDate>> ay_ = calculations?.endgap;
                IEnumerable<CqlInterval<CqlDate>> az_ = context.Operators.Union<CqlInterval<CqlDate>>(ax_, ay_);
                IEnumerable<CqlInterval<CqlDate>> ba_ = this.Collapse_Date_Interval_Workaround(context, az_);
                return ba_;
            }

            IEnumerable<IEnumerable<CqlInterval<CqlDate>>> l_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> frontgaps, IEnumerable<CqlInterval<CqlDate>> endgap)?, IEnumerable<CqlInterval<CqlDate>>>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> frontgaps, IEnumerable<CqlInterval<CqlDate>> endgap)?>)j_, k_);
            IEnumerable<CqlInterval<CqlDate>> m_ = context.Operators.SingletonFrom<IEnumerable<CqlInterval<CqlDate>>>(l_);
            return m_;
        }

        IEnumerable<IEnumerable<CqlInterval<CqlDate>>> e_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> sortedCoverings)?, IEnumerable<CqlInterval<CqlDate>>>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> sortedCoverings)?>)c_, d_);
        IEnumerable<CqlInterval<CqlDate>> f_ = context.Operators.SingletonFrom<IEnumerable<CqlInterval<CqlDate>>>(e_);
        return f_;
    }


    [CqlFunctionDefinition("DateTime Interval Gaps Relative to Base Interval")]
    public IEnumerable<CqlInterval<CqlDateTime>> DateTime_Interval_Gaps_Relative_to_Base_Interval(CqlContext context, CqlInterval<CqlDateTime> baseInterval, IEnumerable<CqlInterval<CqlDateTime>> coveringIntervals)
    {
        IEnumerable<CqlInterval<CqlDateTime>> a_ = this.DateTime_Interval_Covering_Relative_to_Base_Interval(context, baseInterval, coveringIntervals);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> sortedCoverings)? b_ = (CqlTupleMetadata_EdgSWaTaCbLYLJceGdIcWOLHd, a_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> sortedCoverings)?[] c_ = [
            b_,
        ];

        IEnumerable<CqlInterval<CqlDateTime>> d_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> sortedCoverings)? variableDeclarations) {
            IEnumerable<CqlInterval<CqlDateTime>> g_;
            IEnumerable<CqlInterval<CqlDateTime>> n_ = variableDeclarations?.sortedCoverings;
            int? o_ = context.Operators.Count<CqlInterval<CqlDateTime>>(n_);
            bool? p_ = context.Operators.Equal(o_, 0);
            if (p_ ?? false)
            {
                CqlInterval<CqlDateTime>[] q_ = [
                    baseInterval,
                ];
                g_ = (IEnumerable<CqlInterval<CqlDateTime>>)q_;
            }
            else
            {
                IEnumerable<CqlInterval<CqlDateTime>> r_ = variableDeclarations?.sortedCoverings;

                CqlInterval<CqlDateTime> s_(CqlInterval<CqlDateTime> sortedCovering) {
                    IEnumerable<CqlInterval<CqlDateTime>> u_ = variableDeclarations?.sortedCoverings;
                    int? v_ = context.Operators.IndexOf<CqlInterval<CqlDateTime>>(u_, sortedCovering);
                    bool? w_ = context.Operators.Equal(v_, 0);
                    if (w_ ?? false)
                    {
                        CqlDateTime x_ = context.Operators.Start(baseInterval);
                        CqlDateTime y_ = context.Operators.Start(sortedCovering);
                        CqlInterval<CqlDateTime> z_ = context.Operators.Interval(x_, y_, true, true);
                        CqlInterval<CqlDateTime> aa_ = context.Operators.Intersect<CqlDateTime>(z_, baseInterval);
                        CqlInterval<CqlDateTime> ab_ = context.Operators.Except(aa_, sortedCovering);
                        return ab_;
                    }
                    else
                    {
                        IEnumerable<CqlInterval<CqlDateTime>> ac_ = variableDeclarations?.sortedCoverings;
                        int? ad_ = context.Operators.IndexOf<CqlInterval<CqlDateTime>>(ac_, sortedCovering);
                        int? ae_ = context.Operators.Subtract(ad_, 1);
                        CqlInterval<CqlDateTime> af_ = context.Operators.Indexer<CqlInterval<CqlDateTime>>(ac_, ae_);
                        CqlDateTime ag_ = context.Operators.Start(af_);
                        CqlDateTime ah_ = context.Operators.End(sortedCovering);
                        CqlInterval<CqlDateTime> ai_ = context.Operators.Interval(ag_, ah_, false, false);
                        CqlInterval<CqlDateTime> aj_ = context.Operators.Except(ai_, af_);
                        CqlInterval<CqlDateTime> ak_ = context.Operators.Except(aj_, sortedCovering);
                        return ak_;
                    }
                }

                IEnumerable<CqlInterval<CqlDateTime>> t_ = context.Operators.SelectDistinct<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(r_, s_);
                g_ = t_;
            }
            IEnumerable<CqlInterval<CqlDateTime>> h_;
            IEnumerable<CqlInterval<CqlDateTime>> al_ = variableDeclarations?.sortedCoverings;
            int? am_ = context.Operators.Count<CqlInterval<CqlDateTime>>(al_);
            bool? an_ = context.Operators.Equal(am_, 0);
            if (an_ ?? false)
            {
                CqlInterval<CqlDateTime>[] ao_ = [];
                h_ = ao_ as IEnumerable<CqlInterval<CqlDateTime>>;
            }
            else
            {
                IEnumerable<CqlInterval<CqlDateTime>> ap_ = variableDeclarations?.sortedCoverings;
                CqlInterval<CqlDateTime> aq_ = context.Operators.Last<CqlInterval<CqlDateTime>>(ap_);
                CqlDateTime ar_ = context.Operators.Start(aq_);
                CqlDateTime as_ = context.Operators.End(baseInterval);
                CqlInterval<CqlDateTime> at_ = context.Operators.Interval(ar_, as_, false, true);
                CqlInterval<CqlDateTime> au_ = context.Operators.Except(at_, aq_);
                CqlInterval<CqlDateTime> av_ = context.Operators.Intersect<CqlDateTime>(au_, baseInterval);
                CqlInterval<CqlDateTime>[] aw_ = [
                    av_,
                ];
                h_ = (IEnumerable<CqlInterval<CqlDateTime>>)aw_;
            }
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> frontgaps, IEnumerable<CqlInterval<CqlDateTime>> endgap)? i_ = (CqlTupleMetadata_BBLSSiNBQBGUDJaVjMDZMSAXg, g_, h_);
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> frontgaps, IEnumerable<CqlInterval<CqlDateTime>> endgap)?[] j_ = [
                i_,
            ];

            IEnumerable<CqlInterval<CqlDateTime>> k_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> frontgaps, IEnumerable<CqlInterval<CqlDateTime>> endgap)? calculations) {
                IEnumerable<CqlInterval<CqlDateTime>> ax_ = calculations?.frontgaps;
                IEnumerable<CqlInterval<CqlDateTime>> ay_ = calculations?.endgap;
                IEnumerable<CqlInterval<CqlDateTime>> az_ = context.Operators.Union<CqlInterval<CqlDateTime>>(ax_, ay_);
                IEnumerable<CqlInterval<CqlDateTime>> ba_ = this.Collapse_DateTime_Interval_Workaround(context, az_);
                return ba_;
            }

            IEnumerable<IEnumerable<CqlInterval<CqlDateTime>>> l_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> frontgaps, IEnumerable<CqlInterval<CqlDateTime>> endgap)?, IEnumerable<CqlInterval<CqlDateTime>>>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> frontgaps, IEnumerable<CqlInterval<CqlDateTime>> endgap)?>)j_, k_);
            IEnumerable<CqlInterval<CqlDateTime>> m_ = context.Operators.SingletonFrom<IEnumerable<CqlInterval<CqlDateTime>>>(l_);
            return m_;
        }

        IEnumerable<IEnumerable<CqlInterval<CqlDateTime>>> e_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> sortedCoverings)?, IEnumerable<CqlInterval<CqlDateTime>>>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> sortedCoverings)?>)c_, d_);
        IEnumerable<CqlInterval<CqlDateTime>> f_ = context.Operators.SingletonFrom<IEnumerable<CqlInterval<CqlDateTime>>>(e_);
        return f_;
    }


    [CqlFunctionDefinition("Collapsed Date Interval Stats")]
    public (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? Collapsed_Date_Interval_Stats(CqlContext context, IEnumerable<CqlInterval<CqlDate>> collapsedIntervals)
    {
        int? a_ = context.Operators.Count<CqlInterval<CqlDate>>(collapsedIntervals);
        int? b_;
        int? f_ = context.Operators.Count<CqlInterval<CqlDate>>(collapsedIntervals);
        bool? g_ = context.Operators.Equal(f_, 0);
        if (g_ ?? false)
        {
            b_ = 0;
        }
        else
        {

            int? h_(CqlInterval<CqlDate> I) {
                CqlDate k_ = context.Operators.Start(I);
                CqlDate l_ = context.Operators.End(I);
                int? m_ = context.Operators.DurationBetween(k_, l_, "day");
                int? n_ = context.Operators.Add(m_, 1);
                int?[] o_ = [
                    n_,
                    0,
                ];
                int? p_ = context.Operators.Max<int?>((IEnumerable<int?>)o_);
                return p_;
            }

            IEnumerable<int?> i_ = context.Operators.SelectDistinct<CqlInterval<CqlDate>, int?>(collapsedIntervals, h_);
            int? j_ = context.Operators.Sum(i_);
            b_ = j_;
        }
        CqlInterval<CqlDate> c_;
        int? q_ = context.Operators.Count<CqlInterval<CqlDate>>(collapsedIntervals);
        bool? r_ = context.Operators.Equal(q_, 0);
        if (r_ ?? false)
        {
            c_ = null as CqlInterval<CqlDate>;
        }
        else
        {

            (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? s_(CqlInterval<CqlDate> I) {
                CqlDate y_ = context.Operators.Start(I);
                CqlDate z_ = context.Operators.End(I);
                int? aa_ = context.Operators.DurationBetween(y_, z_, "day");
                int? ab_ = context.Operators.Add(aa_, 1);
                int?[] ac_ = [
                    ab_,
                    0,
                ];
                int? ad_ = context.Operators.Max<int?>((IEnumerable<int?>)ac_);
                (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? ae_ = (CqlTupleMetadata_HEjPGjPEhLgQPGjROeWMgiGfC, I, ad_);
                return ae_;
            }

            IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> t_ = context.Operators.SelectDistinct<CqlInterval<CqlDate>, (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(collapsedIntervals, s_);

            object u_((CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? @this) {
                int? af_ = @this?.days;
                return af_;
            }

            IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> v_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(t_, u_, System.ComponentModel.ListSortDirection.Descending);
            (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? w_ = context.Operators.First<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(v_);
            CqlInterval<CqlDate> x_ = w_?.interval;
            c_ = x_;
        }
        int? d_;
        int? ag_ = context.Operators.Count<CqlInterval<CqlDate>>(collapsedIntervals);
        bool? ah_ = context.Operators.Equal(ag_, 0);
        if (ah_ ?? false)
        {
            d_ = 0;
        }
        else
        {

            (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? ai_(CqlInterval<CqlDate> I) {
                CqlDate ba_ = context.Operators.Start(I);
                CqlDate bb_ = context.Operators.End(I);
                int? bc_ = context.Operators.DurationBetween(ba_, bb_, "day");
                int? bd_ = context.Operators.Add(bc_, 1);
                int?[] be_ = [
                    bd_,
                    0,
                ];
                int? bf_ = context.Operators.Max<int?>((IEnumerable<int?>)be_);
                (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? bg_ = (CqlTupleMetadata_HEjPGjPEhLgQPGjROeWMgiGfC, I, bf_);
                return bg_;
            }

            IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> aj_ = context.Operators.SelectDistinct<CqlInterval<CqlDate>, (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(collapsedIntervals, ai_);

            object ak_((CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? @this) {
                int? bh_ = @this?.days;
                return bh_;
            }

            IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> al_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(aj_, ak_, System.ComponentModel.ListSortDirection.Descending);
            (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? am_ = context.Operators.First<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(al_);
            CqlInterval<CqlDate> an_ = am_?.interval;
            CqlDate ao_ = context.Operators.Start(an_);

            (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? ap_(CqlInterval<CqlDate> I) {
                CqlDate bi_ = context.Operators.Start(I);
                CqlDate bj_ = context.Operators.End(I);
                int? bk_ = context.Operators.DurationBetween(bi_, bj_, "day");
                int? bl_ = context.Operators.Add(bk_, 1);
                int?[] bm_ = [
                    bl_,
                    0,
                ];
                int? bn_ = context.Operators.Max<int?>((IEnumerable<int?>)bm_);
                (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? bo_ = (CqlTupleMetadata_HEjPGjPEhLgQPGjROeWMgiGfC, I, bn_);
                return bo_;
            }

            IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> aq_ = context.Operators.SelectDistinct<CqlInterval<CqlDate>, (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(collapsedIntervals, ap_);

            object ar_((CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? @this) {
                int? bp_ = @this?.days;
                return bp_;
            }

            IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> as_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(aq_, ar_, System.ComponentModel.ListSortDirection.Descending);
            (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? at_ = context.Operators.First<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(as_);
            CqlInterval<CqlDate> au_ = at_?.interval;
            CqlDate av_ = context.Operators.End(au_);
            int? aw_ = context.Operators.DurationBetween(ao_, av_, "day");
            int? ax_ = context.Operators.Add(aw_, 1);
            int?[] ay_ = [
                ax_,
                0,
            ];
            int? az_ = context.Operators.Max<int?>((IEnumerable<int?>)ay_);
            d_ = az_;
        }
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? e_ = (CqlTupleMetadata_HRbPDRZiOGGBceePOZWjVbXdP, collapsedIntervals, a_, b_, c_, d_);
        return e_;
    }


    [CqlFunctionDefinition("Date Interval Covering Relative to Base Interval Stats")]
    public (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? Date_Interval_Covering_Relative_to_Base_Interval_Stats(CqlContext context, CqlInterval<CqlDate> baseInterval, IEnumerable<CqlInterval<CqlDate>> coveringIntervals)
    {
        IEnumerable<CqlInterval<CqlDate>> a_ = this.Date_Interval_Covering_Relative_to_Base_Interval(context, baseInterval, coveringIntervals);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Covering_Intervals)? b_ = (CqlTupleMetadata_DUiZjXRKgCPYVZQJbFVDKNMOi, a_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Covering_Intervals)?[] c_ = [
            b_,
        ];

        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? d_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Covering_Intervals)? variableDeclarations) {
            IEnumerable<CqlInterval<CqlDate>> g_ = variableDeclarations?.Covering_Intervals;
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? h_ = this.Collapsed_Date_Interval_Stats(context, g_);
            return h_;
        }

        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?> e_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Covering_Intervals)?, (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Covering_Intervals)?>)c_, d_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? f_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>(e_);
        return f_;
    }


    [CqlFunctionDefinition("Date Interval Gaps Relative to Base Interval Stats")]
    public (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? Date_Interval_Gaps_Relative_to_Base_Interval_Stats(CqlContext context, CqlInterval<CqlDate> baseInterval, IEnumerable<CqlInterval<CqlDate>> coveringIntervals)
    {
        IEnumerable<CqlInterval<CqlDate>> a_ = this.Date_Interval_Gaps_Relative_to_Base_Interval(context, baseInterval, coveringIntervals);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Gap_Intervals)? b_ = (CqlTupleMetadata_GQPbYTYABjXFVLRKjXgcDJFSj, a_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Gap_Intervals)?[] c_ = [
            b_,
        ];

        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? d_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Gap_Intervals)? variableDeclarations) {
            IEnumerable<CqlInterval<CqlDate>> g_ = variableDeclarations?.Gap_Intervals;
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? h_ = this.Collapsed_Date_Interval_Stats(context, g_);
            return h_;
        }

        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?> e_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Gap_Intervals)?, (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Gap_Intervals)?>)c_, d_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? f_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>(e_);
        return f_;
    }


    [CqlFunctionDefinition("DateTime Interval Set Nulls to Zero")]
    public CqlInterval<CqlDateTime> DateTime_Interval_Set_Nulls_to_Zero(CqlContext context, CqlInterval<CqlDateTime> interval)
    {
        CqlDateTime a_ = context.Operators.Start(interval);
        int? b_ = context.Operators.DateTimeComponentFrom(a_, "year");
        int? c_;
        CqlDateTime v_ = context.Operators.Start(interval);
        int? w_ = context.Operators.DateTimeComponentFrom(v_, "month");
        if (w_ is null)
        {
            c_ = 0;
        }
        else
        {
            CqlDateTime x_ = context.Operators.Start(interval);
            int? y_ = context.Operators.DateTimeComponentFrom(x_, "month");
            c_ = y_;
        }
        int? d_;
        CqlDateTime z_ = context.Operators.Start(interval);
        int? aa_ = context.Operators.DateTimeComponentFrom(z_, "day");
        if (aa_ is null)
        {
            d_ = 0;
        }
        else
        {
            CqlDateTime ab_ = context.Operators.Start(interval);
            int? ac_ = context.Operators.DateTimeComponentFrom(ab_, "day");
            d_ = ac_;
        }
        int? e_;
        CqlDateTime ad_ = context.Operators.Start(interval);
        int? ae_ = context.Operators.DateTimeComponentFrom(ad_, "hour");
        if (ae_ is null)
        {
            e_ = 0;
        }
        else
        {
            CqlDateTime af_ = context.Operators.Start(interval);
            int? ag_ = context.Operators.DateTimeComponentFrom(af_, "hour");
            e_ = ag_;
        }
        int? f_;
        CqlDateTime ah_ = context.Operators.Start(interval);
        int? ai_ = context.Operators.DateTimeComponentFrom(ah_, "minute");
        if (ai_ is null)
        {
            f_ = 0;
        }
        else
        {
            CqlDateTime aj_ = context.Operators.Start(interval);
            int? ak_ = context.Operators.DateTimeComponentFrom(aj_, "minute");
            f_ = ak_;
        }
        int? g_;
        CqlDateTime al_ = context.Operators.Start(interval);
        int? am_ = context.Operators.DateTimeComponentFrom(al_, "second");
        if (am_ is null)
        {
            g_ = 0;
        }
        else
        {
            CqlDateTime an_ = context.Operators.Start(interval);
            int? ao_ = context.Operators.DateTimeComponentFrom(an_, "second");
            g_ = ao_;
        }
        int? h_;
        CqlDateTime ap_ = context.Operators.Start(interval);
        int? aq_ = context.Operators.DateTimeComponentFrom(ap_, "millisecond");
        if (aq_ is null)
        {
            h_ = 0;
        }
        else
        {
            CqlDateTime ar_ = context.Operators.Start(interval);
            int? as_ = context.Operators.DateTimeComponentFrom(ar_, "millisecond");
            h_ = as_;
        }
        CqlDateTime i_ = context.Operators.End(interval);
        int? j_ = context.Operators.DateTimeComponentFrom(i_, "year");
        int? k_;
        CqlDateTime at_ = context.Operators.End(interval);
        int? au_ = context.Operators.DateTimeComponentFrom(at_, "month");
        if (au_ is null)
        {
            k_ = 0;
        }
        else
        {
            CqlDateTime av_ = context.Operators.End(interval);
            int? aw_ = context.Operators.DateTimeComponentFrom(av_, "month");
            k_ = aw_;
        }
        int? l_;
        CqlDateTime ax_ = context.Operators.End(interval);
        int? ay_ = context.Operators.DateTimeComponentFrom(ax_, "day");
        if (ay_ is null)
        {
            l_ = 0;
        }
        else
        {
            CqlDateTime az_ = context.Operators.End(interval);
            int? ba_ = context.Operators.DateTimeComponentFrom(az_, "day");
            l_ = ba_;
        }
        int? m_;
        CqlDateTime bb_ = context.Operators.End(interval);
        int? bc_ = context.Operators.DateTimeComponentFrom(bb_, "hour");
        if (bc_ is null)
        {
            m_ = 0;
        }
        else
        {
            CqlDateTime bd_ = context.Operators.End(interval);
            int? be_ = context.Operators.DateTimeComponentFrom(bd_, "hour");
            m_ = be_;
        }
        int? n_;
        CqlDateTime bf_ = context.Operators.End(interval);
        int? bg_ = context.Operators.DateTimeComponentFrom(bf_, "minute");
        if (bg_ is null)
        {
            n_ = 0;
        }
        else
        {
            CqlDateTime bh_ = context.Operators.End(interval);
            int? bi_ = context.Operators.DateTimeComponentFrom(bh_, "minute");
            n_ = bi_;
        }
        int? o_;
        CqlDateTime bj_ = context.Operators.End(interval);
        int? bk_ = context.Operators.DateTimeComponentFrom(bj_, "second");
        if (bk_ is null)
        {
            o_ = 0;
        }
        else
        {
            CqlDateTime bl_ = context.Operators.End(interval);
            int? bm_ = context.Operators.DateTimeComponentFrom(bl_, "second");
            o_ = bm_;
        }
        int? p_;
        CqlDateTime bn_ = context.Operators.End(interval);
        int? bo_ = context.Operators.DateTimeComponentFrom(bn_, "millisecond");
        if (bo_ is null)
        {
            p_ = 0;
        }
        else
        {
            CqlDateTime bp_ = context.Operators.End(interval);
            int? bq_ = context.Operators.DateTimeComponentFrom(bp_, "millisecond");
            p_ = bq_;
        }
        (CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)? q_ = (CqlTupleMetadata_FcQREFSfPJSKYAhSEWVJcZVED, b_, c_, d_, e_, f_, g_, h_, j_, k_, l_, m_, n_, o_, p_);
        (CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)?[] r_ = [
            q_,
        ];

        CqlInterval<CqlDateTime> s_((CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)? i) {
            int? br_ = i?.StartYear;
            int? bs_ = i?.StartMonth;
            int? bt_ = i?.StartDay;
            int? bu_ = i?.StartHour;
            int? bv_ = i?.StartMinute;
            int? bw_ = i?.StartSecond;
            int? bx_ = i?.StartMillisecond;
            CqlDateTime by_ = context.Operators.DateTime(br_, bs_, bt_, bu_, bv_, bw_, bx_, (decimal?)default);
            int? bz_ = i?.EndYear;
            int? ca_ = i?.EndMonth;
            int? cb_ = i?.EndDay;
            int? cc_ = i?.EndHour;
            int? cd_ = i?.EndMinute;
            int? ce_ = i?.EndSecond;
            int? cf_ = i?.EndMillisecond;
            CqlDateTime cg_ = context.Operators.DateTime(bz_, ca_, cb_, cc_, cd_, ce_, cf_, (decimal?)default);
            CqlInterval<CqlDateTime> ch_ = context.Operators.Interval(by_, cg_, true, true);
            return ch_;
        }

        IEnumerable<CqlInterval<CqlDateTime>> t_ = context.Operators.SelectDistinct<(CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)?, CqlInterval<CqlDateTime>>((IEnumerable<(CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)?>)r_, s_);
        CqlInterval<CqlDateTime> u_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(t_);
        return u_;
    }


    [CqlFunctionDefinition("Collapsed DateTime Interval Stats")]
    public (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? Collapsed_DateTime_Interval_Stats(CqlContext context, IEnumerable<CqlInterval<CqlDateTime>> collapsedIntervals)
    {
        int? a_ = context.Operators.Count<CqlInterval<CqlDateTime>>(collapsedIntervals);
        int? b_;
        int? f_ = context.Operators.Count<CqlInterval<CqlDateTime>>(collapsedIntervals);
        bool? g_ = context.Operators.Equal(f_, 0);
        if (g_ ?? false)
        {
            b_ = 0;
        }
        else
        {

            int? h_(CqlInterval<CqlDateTime> I) {
                CqlInterval<CqlDateTime> k_ = this.DateTime_Interval_Set_Nulls_to_Zero(context, I);
                CqlDateTime l_ = context.Operators.Start(k_);
                CqlDateTime m_ = context.Operators.End(k_);
                int? n_ = context.Operators.DurationBetween(l_, m_, "day");
                int? o_ = context.Operators.Add(n_, 1);
                int?[] p_ = [
                    o_,
                    0,
                ];
                int? q_ = context.Operators.Max<int?>((IEnumerable<int?>)p_);
                return q_;
            }

            IEnumerable<int?> i_ = context.Operators.SelectDistinct<CqlInterval<CqlDateTime>, int?>(collapsedIntervals, h_);
            int? j_ = context.Operators.Sum(i_);
            b_ = j_;
        }
        CqlInterval<CqlDateTime> c_;
        int? r_ = context.Operators.Count<CqlInterval<CqlDateTime>>(collapsedIntervals);
        bool? s_ = context.Operators.Equal(r_, 0);
        if (s_ ?? false)
        {
            c_ = null as CqlInterval<CqlDateTime>;
        }
        else
        {

            (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? t_(CqlInterval<CqlDateTime> I) {
                CqlInterval<CqlDateTime> z_ = this.DateTime_Interval_Set_Nulls_to_Zero(context, I);
                CqlDateTime aa_ = context.Operators.Start(z_);
                CqlDateTime ab_ = context.Operators.End(z_);
                int? ac_ = context.Operators.DurationBetween(aa_, ab_, "day");
                int? ad_ = context.Operators.Add(ac_, 1);
                int?[] ae_ = [
                    ad_,
                    0,
                ];
                int? af_ = context.Operators.Max<int?>((IEnumerable<int?>)ae_);
                (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? ag_ = (CqlTupleMetadata_CGHEUIgjaCjJVKEADTSZEbdCL, I, af_);
                return ag_;
            }

            IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> u_ = context.Operators.SelectDistinct<CqlInterval<CqlDateTime>, (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(collapsedIntervals, t_);

            object v_((CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? @this) {
                int? ah_ = @this?.days;
                return ah_;
            }

            IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> w_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(u_, v_, System.ComponentModel.ListSortDirection.Descending);
            (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? x_ = context.Operators.First<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(w_);
            CqlInterval<CqlDateTime> y_ = x_?.interval;
            c_ = y_;
        }
        int? d_;
        int? ai_ = context.Operators.Count<CqlInterval<CqlDateTime>>(collapsedIntervals);
        bool? aj_ = context.Operators.Equal(ai_, 0);
        if (aj_ ?? false)
        {
            d_ = 0;
        }
        else
        {

            (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? ak_(CqlInterval<CqlDateTime> I) {
                CqlInterval<CqlDateTime> be_ = this.DateTime_Interval_Set_Nulls_to_Zero(context, I);
                CqlDateTime bf_ = context.Operators.Start(be_);
                CqlDateTime bg_ = context.Operators.End(be_);
                int? bh_ = context.Operators.DurationBetween(bf_, bg_, "day");
                int? bi_ = context.Operators.Add(bh_, 1);
                int?[] bj_ = [
                    bi_,
                    0,
                ];
                int? bk_ = context.Operators.Max<int?>((IEnumerable<int?>)bj_);
                (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? bl_ = (CqlTupleMetadata_CGHEUIgjaCjJVKEADTSZEbdCL, I, bk_);
                return bl_;
            }

            IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> al_ = context.Operators.SelectDistinct<CqlInterval<CqlDateTime>, (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(collapsedIntervals, ak_);

            object am_((CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? @this) {
                int? bm_ = @this?.days;
                return bm_;
            }

            IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> an_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(al_, am_, System.ComponentModel.ListSortDirection.Descending);
            (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? ao_ = context.Operators.First<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(an_);
            CqlInterval<CqlDateTime> ap_ = ao_?.interval;
            CqlInterval<CqlDateTime> aq_ = this.DateTime_Interval_Set_Nulls_to_Zero(context, ap_);
            CqlDateTime ar_ = context.Operators.Start(aq_);

            (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? as_(CqlInterval<CqlDateTime> I) {
                CqlInterval<CqlDateTime> bn_ = this.DateTime_Interval_Set_Nulls_to_Zero(context, I);
                CqlDateTime bo_ = context.Operators.Start(bn_);
                CqlDateTime bp_ = context.Operators.End(bn_);
                int? bq_ = context.Operators.DurationBetween(bo_, bp_, "day");
                int? br_ = context.Operators.Add(bq_, 1);
                int?[] bs_ = [
                    br_,
                    0,
                ];
                int? bt_ = context.Operators.Max<int?>((IEnumerable<int?>)bs_);
                (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? bu_ = (CqlTupleMetadata_CGHEUIgjaCjJVKEADTSZEbdCL, I, bt_);
                return bu_;
            }

            IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> at_ = context.Operators.SelectDistinct<CqlInterval<CqlDateTime>, (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(collapsedIntervals, as_);

            object au_((CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? @this) {
                int? bv_ = @this?.days;
                return bv_;
            }

            IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> av_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(at_, au_, System.ComponentModel.ListSortDirection.Descending);
            (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? aw_ = context.Operators.First<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(av_);
            CqlInterval<CqlDateTime> ax_ = aw_?.interval;
            CqlInterval<CqlDateTime> ay_ = this.DateTime_Interval_Set_Nulls_to_Zero(context, ax_);
            CqlDateTime az_ = context.Operators.End(ay_);
            int? ba_ = context.Operators.DurationBetween(ar_, az_, "day");
            int? bb_ = context.Operators.Add(ba_, 1);
            int?[] bc_ = [
                bb_,
                0,
            ];
            int? bd_ = context.Operators.Max<int?>((IEnumerable<int?>)bc_);
            d_ = bd_;
        }
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? e_ = (CqlTupleMetadata_HDihbLieYfQbgeSbOWZBAMUIQ, collapsedIntervals, a_, b_, c_, d_);
        return e_;
    }


    [CqlFunctionDefinition("DateTime Interval Covering Relative to Base Interval Stats")]
    public (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? DateTime_Interval_Covering_Relative_to_Base_Interval_Stats(CqlContext context, CqlInterval<CqlDateTime> baseInterval, IEnumerable<CqlInterval<CqlDateTime>> coveringIntervals)
    {
        IEnumerable<CqlInterval<CqlDateTime>> a_ = this.DateTime_Interval_Covering_Relative_to_Base_Interval(context, baseInterval, coveringIntervals);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Covering_Intervals)? b_ = (CqlTupleMetadata_GZMPWdGOJiTNjfWAcbZMePdXV, a_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Covering_Intervals)?[] c_ = [
            b_,
        ];

        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? d_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Covering_Intervals)? variableDeclarations) {
            IEnumerable<CqlInterval<CqlDateTime>> g_ = variableDeclarations?.Covering_Intervals;
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? h_ = this.Collapsed_DateTime_Interval_Stats(context, g_);
            return h_;
        }

        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?> e_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Covering_Intervals)?, (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Covering_Intervals)?>)c_, d_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? f_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?>(e_);
        return f_;
    }


    [CqlFunctionDefinition("DateTime Interval Gaps Relative to Base Interval Stats")]
    public (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? DateTime_Interval_Gaps_Relative_to_Base_Interval_Stats(CqlContext context, CqlInterval<CqlDateTime> baseInterval, IEnumerable<CqlInterval<CqlDateTime>> coveringIntervals)
    {
        IEnumerable<CqlInterval<CqlDateTime>> a_ = this.DateTime_Interval_Gaps_Relative_to_Base_Interval(context, baseInterval, coveringIntervals);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Gap_Intervals)? b_ = (CqlTupleMetadata_CKbERRbOPGNBBERUOghhaOYSE, a_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Gap_Intervals)?[] c_ = [
            b_,
        ];

        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? d_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Gap_Intervals)? variableDeclarations) {
            IEnumerable<CqlInterval<CqlDateTime>> g_ = variableDeclarations?.Gap_Intervals;
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? h_ = this.Collapsed_DateTime_Interval_Stats(context, g_);
            return h_;
        }

        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?> e_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Gap_Intervals)?, (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Gap_Intervals)?>)c_, d_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? f_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?>(e_);
        return f_;
    }


    [CqlFunctionDefinition("Convert To UTC DateTime")]
    public CqlDateTime Convert_To_UTC_DateTime(CqlContext context, CqlDate d)
    {
        int? a_ = context.Operators.DateTimeComponentFrom(d, "year");
        int? b_;
        if ((context.Operators.DateTimeComponentFrom(d, "month")) is null)
        {
            b_ = 0;
        }
        else
        {
            int? i_ = context.Operators.DateTimeComponentFrom(d, "month");
            b_ = i_;
        }
        int? c_;
        if ((context.Operators.DateTimeComponentFrom(d, "day")) is null)
        {
            c_ = 0;
        }
        else
        {
            int? j_ = context.Operators.DateTimeComponentFrom(d, "day");
            c_ = j_;
        }
        (CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay)? d_ = (CqlTupleMetadata_BgJFbOiFcaejXZjQOBFLJLhjg, a_, b_, c_);
        (CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay)?[] e_ = [
            d_,
        ];

        CqlDateTime f_((CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay)? i) {
            int? k_ = i?.StartYear;
            int? l_ = i?.StartMonth;
            int? m_ = i?.StartDay;
            decimal? n_ = context.Operators.ConvertIntegerToDecimal(0);
            CqlDateTime o_ = context.Operators.DateTime(k_, l_, m_, 0, 0, 0, 0, n_);
            return o_;
        }

        IEnumerable<CqlDateTime> g_ = context.Operators.SelectDistinct<(CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay)?, CqlDateTime>((IEnumerable<(CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay)?>)e_, f_);
        CqlDateTime h_ = context.Operators.SingletonFrom<CqlDateTime>(g_);
        return h_;
    }


    [CqlFunctionDefinition("Convert Interval Date to UTC Interval DateTime")]
    public CqlInterval<CqlDateTime> Convert_Interval_Date_to_UTC_Interval_DateTime(CqlContext context, CqlInterval<CqlDate> interval)
    {
        CqlDate a_ = context.Operators.Start(interval);
        CqlDateTime b_ = this.Convert_To_UTC_DateTime(context, a_);
        CqlDate c_ = context.Operators.End(interval);
        CqlDateTime d_ = this.Convert_To_UTC_DateTime(context, c_);
        CqlInterval<CqlDateTime> e_ = context.Operators.Interval(b_, d_, true, true);
        return e_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private NCQACQLBase_1_0_0() {}

    public static NCQACQLBase_1_0_0 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "NCQACQLBase";
    public string Version => "1.0.0";
    public ILibrary[] Dependencies => [];

    #endregion ILibrary Implementation

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_BBLSSiNBQBGUDJaVjMDZMSAXg = new(
       [typeof(IEnumerable<CqlInterval<CqlDateTime>>), typeof(IEnumerable<CqlInterval<CqlDateTime>>)],
       ["frontgaps", "endgap"]);

    private static CqlTupleMetadata CqlTupleMetadata_BgJFbOiFcaejXZjQOBFLJLhjg = new(
       [typeof(int?), typeof(int?), typeof(int?)],
       ["StartYear", "StartMonth", "StartDay"]);

    private static CqlTupleMetadata CqlTupleMetadata_CGHEUIgjaCjJVKEADTSZEbdCL = new(
       [typeof(CqlInterval<CqlDateTime>), typeof(int?)],
       ["interval", "days"]);

    private static CqlTupleMetadata CqlTupleMetadata_CKbERRbOPGNBBERUOghhaOYSE = new(
       [typeof(IEnumerable<CqlInterval<CqlDateTime>>)],
       ["Gap_Intervals"]);

    private static CqlTupleMetadata CqlTupleMetadata_DUiZjXRKgCPYVZQJbFVDKNMOi = new(
       [typeof(IEnumerable<CqlInterval<CqlDate>>)],
       ["Covering_Intervals"]);

    private static CqlTupleMetadata CqlTupleMetadata_EdgSWaTaCbLYLJceGdIcWOLHd = new(
       [typeof(IEnumerable<CqlInterval<CqlDateTime>>)],
       ["sortedCoverings"]);

    private static CqlTupleMetadata CqlTupleMetadata_EQHOUSiiWahbJPOUjJGEhIAOV = new(
       [typeof(CqlInterval<CqlDateTime>), typeof(CqlDateTime)],
       ["interval", "startOfInterval"]);

    private static CqlTupleMetadata CqlTupleMetadata_EVRLVXPcBiDTIWfCCfKEWDfKI = new(
       [typeof(IEnumerable<CqlInterval<CqlDate>>)],
       ["sortedCoverings"]);

    private static CqlTupleMetadata CqlTupleMetadata_FcQREFSfPJSKYAhSEWVJcZVED = new(
       [typeof(int?), typeof(int?), typeof(int?), typeof(int?), typeof(int?), typeof(int?), typeof(int?), typeof(int?), typeof(int?), typeof(int?), typeof(int?), typeof(int?), typeof(int?), typeof(int?)],
       ["StartYear", "StartMonth", "StartDay", "StartHour", "StartMinute", "StartSecond", "StartMillisecond", "EndYear", "EndMonth", "EndDay", "EndHour", "EndMinute", "EndSecond", "EndMillisecond"]);

    private static CqlTupleMetadata CqlTupleMetadata_FKcLSALRMRfDigEFaJgDOPFRK = new(
       [typeof(IEnumerable<CqlInterval<CqlDate>>), typeof(IEnumerable<CqlInterval<CqlDate>>)],
       ["frontgaps", "endgap"]);

    private static CqlTupleMetadata CqlTupleMetadata_GIMHfXDcFiAjSJBDGYeUeZLhW = new(
       [typeof(CqlInterval<CqlDate>), typeof(CqlDate)],
       ["interval", "startOfInterval"]);

    private static CqlTupleMetadata CqlTupleMetadata_GQPbYTYABjXFVLRKjXgcDJFSj = new(
       [typeof(IEnumerable<CqlInterval<CqlDate>>)],
       ["Gap_Intervals"]);

    private static CqlTupleMetadata CqlTupleMetadata_GZMPWdGOJiTNjfWAcbZMePdXV = new(
       [typeof(IEnumerable<CqlInterval<CqlDateTime>>)],
       ["Covering_Intervals"]);

    private static CqlTupleMetadata CqlTupleMetadata_HDihbLieYfQbgeSbOWZBAMUIQ = new(
       [typeof(IEnumerable<CqlInterval<CqlDateTime>>), typeof(int?), typeof(int?), typeof(CqlInterval<CqlDateTime>), typeof(int?)],
       ["Intervals", "Interval_Count", "Total_Days_In_Intervals", "Longest_Interval", "Total_Days_In_Longest_Interval"]);

    private static CqlTupleMetadata CqlTupleMetadata_HEjPGjPEhLgQPGjROeWMgiGfC = new(
       [typeof(CqlInterval<CqlDate>), typeof(int?)],
       ["interval", "days"]);

    private static CqlTupleMetadata CqlTupleMetadata_HRbPDRZiOGGBceePOZWjVbXdP = new(
       [typeof(IEnumerable<CqlInterval<CqlDate>>), typeof(int?), typeof(int?), typeof(CqlInterval<CqlDate>), typeof(int?)],
       ["Intervals", "Interval_Count", "Total_Days_In_Intervals", "Longest_Interval", "Total_Days_In_Longest_Interval"]);

    #endregion CqlTupleMetadata Properties

}
