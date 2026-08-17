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
        bool? f_ = context.Operators.Equal(a_, 0);
        if (f_ ?? false)
        {
            b_ = 0;
        }
        else
        {

            int? g_(CqlInterval<CqlDate> I) {
                CqlDate j_ = context.Operators.Start(I);
                CqlDate k_ = context.Operators.End(I);
                int? l_ = context.Operators.DurationBetween(j_, k_, "day");
                int? m_ = context.Operators.Add(l_, 1);
                int?[] n_ = [
                    m_,
                    0,
                ];
                int? o_ = context.Operators.Max<int?>((IEnumerable<int?>)n_);
                return o_;
            }

            IEnumerable<int?> h_ = context.Operators.SelectDistinct<CqlInterval<CqlDate>, int?>(collapsedIntervals, g_);
            int? i_ = context.Operators.Sum(h_);
            b_ = i_;
        }
        CqlInterval<CqlDate> c_;
        bool? p_ = context.Operators.Equal(a_, 0);
        if (p_ ?? false)
        {
            c_ = null as CqlInterval<CqlDate>;
        }
        else
        {

            (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? q_(CqlInterval<CqlDate> I) {
                CqlDate w_ = context.Operators.Start(I);
                CqlDate x_ = context.Operators.End(I);
                int? y_ = context.Operators.DurationBetween(w_, x_, "day");
                int? z_ = context.Operators.Add(y_, 1);
                int?[] aa_ = [
                    z_,
                    0,
                ];
                int? ab_ = context.Operators.Max<int?>((IEnumerable<int?>)aa_);
                (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? ac_ = (CqlTupleMetadata_HEjPGjPEhLgQPGjROeWMgiGfC, I, ab_);
                return ac_;
            }

            IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> r_ = context.Operators.SelectDistinct<CqlInterval<CqlDate>, (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(collapsedIntervals, q_);

            object s_((CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? @this) {
                int? ad_ = @this?.days;
                return ad_;
            }

            IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> t_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(r_, s_, System.ComponentModel.ListSortDirection.Descending);
            (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? u_ = context.Operators.First<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(t_);
            CqlInterval<CqlDate> v_ = u_?.interval;
            c_ = v_;
        }
        int? d_;
        bool? ae_ = context.Operators.Equal(a_, 0);
        if (ae_ ?? false)
        {
            d_ = 0;
        }
        else
        {

            (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? af_(CqlInterval<CqlDate> I) {
                CqlDate ax_ = context.Operators.Start(I);
                CqlDate ay_ = context.Operators.End(I);
                int? az_ = context.Operators.DurationBetween(ax_, ay_, "day");
                int? ba_ = context.Operators.Add(az_, 1);
                int?[] bb_ = [
                    ba_,
                    0,
                ];
                int? bc_ = context.Operators.Max<int?>((IEnumerable<int?>)bb_);
                (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? bd_ = (CqlTupleMetadata_HEjPGjPEhLgQPGjROeWMgiGfC, I, bc_);
                return bd_;
            }

            IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> ag_ = context.Operators.SelectDistinct<CqlInterval<CqlDate>, (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(collapsedIntervals, af_);

            object ah_((CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? @this) {
                int? be_ = @this?.days;
                return be_;
            }

            IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> ai_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(ag_, ah_, System.ComponentModel.ListSortDirection.Descending);
            (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? aj_ = context.Operators.First<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(ai_);
            CqlInterval<CqlDate> ak_ = aj_?.interval;
            CqlDate al_ = context.Operators.Start(ak_);

            (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? am_(CqlInterval<CqlDate> I) {
                CqlDate bf_ = context.Operators.Start(I);
                CqlDate bg_ = context.Operators.End(I);
                int? bh_ = context.Operators.DurationBetween(bf_, bg_, "day");
                int? bi_ = context.Operators.Add(bh_, 1);
                int?[] bj_ = [
                    bi_,
                    0,
                ];
                int? bk_ = context.Operators.Max<int?>((IEnumerable<int?>)bj_);
                (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? bl_ = (CqlTupleMetadata_HEjPGjPEhLgQPGjROeWMgiGfC, I, bk_);
                return bl_;
            }

            IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> an_ = context.Operators.SelectDistinct<CqlInterval<CqlDate>, (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(collapsedIntervals, am_);

            object ao_((CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? @this) {
                int? bm_ = @this?.days;
                return bm_;
            }

            IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> ap_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(an_, ao_, System.ComponentModel.ListSortDirection.Descending);
            (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? aq_ = context.Operators.First<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(ap_);
            CqlInterval<CqlDate> ar_ = aq_?.interval;
            CqlDate as_ = context.Operators.End(ar_);
            int? at_ = context.Operators.DurationBetween(al_, as_, "day");
            int? au_ = context.Operators.Add(at_, 1);
            int?[] av_ = [
                au_,
                0,
            ];
            int? aw_ = context.Operators.Max<int?>((IEnumerable<int?>)av_);
            d_ = aw_;
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
        int? v_ = context.Operators.DateTimeComponentFrom(a_, "month");
        if (v_ is null)
        {
            c_ = 0;
        }
        else
        {
            int? w_ = context.Operators.DateTimeComponentFrom(a_, "month");
            c_ = w_;
        }
        int? d_;
        int? x_ = context.Operators.DateTimeComponentFrom(a_, "day");
        if (x_ is null)
        {
            d_ = 0;
        }
        else
        {
            int? y_ = context.Operators.DateTimeComponentFrom(a_, "day");
            d_ = y_;
        }
        int? e_;
        int? z_ = context.Operators.DateTimeComponentFrom(a_, "hour");
        if (z_ is null)
        {
            e_ = 0;
        }
        else
        {
            int? aa_ = context.Operators.DateTimeComponentFrom(a_, "hour");
            e_ = aa_;
        }
        int? f_;
        int? ab_ = context.Operators.DateTimeComponentFrom(a_, "minute");
        if (ab_ is null)
        {
            f_ = 0;
        }
        else
        {
            int? ac_ = context.Operators.DateTimeComponentFrom(a_, "minute");
            f_ = ac_;
        }
        int? g_;
        int? ad_ = context.Operators.DateTimeComponentFrom(a_, "second");
        if (ad_ is null)
        {
            g_ = 0;
        }
        else
        {
            int? ae_ = context.Operators.DateTimeComponentFrom(a_, "second");
            g_ = ae_;
        }
        int? h_;
        int? af_ = context.Operators.DateTimeComponentFrom(a_, "millisecond");
        if (af_ is null)
        {
            h_ = 0;
        }
        else
        {
            int? ag_ = context.Operators.DateTimeComponentFrom(a_, "millisecond");
            h_ = ag_;
        }
        CqlDateTime i_ = context.Operators.End(interval);
        int? j_ = context.Operators.DateTimeComponentFrom(i_, "year");
        int? k_;
        int? ah_ = context.Operators.DateTimeComponentFrom(i_, "month");
        if (ah_ is null)
        {
            k_ = 0;
        }
        else
        {
            int? ai_ = context.Operators.DateTimeComponentFrom(i_, "month");
            k_ = ai_;
        }
        int? l_;
        int? aj_ = context.Operators.DateTimeComponentFrom(i_, "day");
        if (aj_ is null)
        {
            l_ = 0;
        }
        else
        {
            int? ak_ = context.Operators.DateTimeComponentFrom(i_, "day");
            l_ = ak_;
        }
        int? m_;
        int? al_ = context.Operators.DateTimeComponentFrom(i_, "hour");
        if (al_ is null)
        {
            m_ = 0;
        }
        else
        {
            int? am_ = context.Operators.DateTimeComponentFrom(i_, "hour");
            m_ = am_;
        }
        int? n_;
        int? an_ = context.Operators.DateTimeComponentFrom(i_, "minute");
        if (an_ is null)
        {
            n_ = 0;
        }
        else
        {
            int? ao_ = context.Operators.DateTimeComponentFrom(i_, "minute");
            n_ = ao_;
        }
        int? o_;
        int? ap_ = context.Operators.DateTimeComponentFrom(i_, "second");
        if (ap_ is null)
        {
            o_ = 0;
        }
        else
        {
            int? aq_ = context.Operators.DateTimeComponentFrom(i_, "second");
            o_ = aq_;
        }
        int? p_;
        int? ar_ = context.Operators.DateTimeComponentFrom(i_, "millisecond");
        if (ar_ is null)
        {
            p_ = 0;
        }
        else
        {
            int? as_ = context.Operators.DateTimeComponentFrom(i_, "millisecond");
            p_ = as_;
        }
        (CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)? q_ = (CqlTupleMetadata_FcQREFSfPJSKYAhSEWVJcZVED, b_, c_, d_, e_, f_, g_, h_, j_, k_, l_, m_, n_, o_, p_);
        (CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)?[] r_ = [
            q_,
        ];

        CqlInterval<CqlDateTime> s_((CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)? i) {
            int? at_ = i?.StartYear;
            int? au_ = i?.StartMonth;
            int? av_ = i?.StartDay;
            int? aw_ = i?.StartHour;
            int? ax_ = i?.StartMinute;
            int? ay_ = i?.StartSecond;
            int? az_ = i?.StartMillisecond;
            CqlDateTime ba_ = context.Operators.DateTime(at_, au_, av_, aw_, ax_, ay_, az_, (decimal?)default);
            int? bb_ = i?.EndYear;
            int? bc_ = i?.EndMonth;
            int? bd_ = i?.EndDay;
            int? be_ = i?.EndHour;
            int? bf_ = i?.EndMinute;
            int? bg_ = i?.EndSecond;
            int? bh_ = i?.EndMillisecond;
            CqlDateTime bi_ = context.Operators.DateTime(bb_, bc_, bd_, be_, bf_, bg_, bh_, (decimal?)default);
            CqlInterval<CqlDateTime> bj_ = context.Operators.Interval(ba_, bi_, true, true);
            return bj_;
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
        bool? f_ = context.Operators.Equal(a_, 0);
        if (f_ ?? false)
        {
            b_ = 0;
        }
        else
        {

            int? g_(CqlInterval<CqlDateTime> I) {
                CqlInterval<CqlDateTime> j_ = this.DateTime_Interval_Set_Nulls_to_Zero(context, I);
                CqlDateTime k_ = context.Operators.Start(j_);
                CqlDateTime l_ = context.Operators.End(j_);
                int? m_ = context.Operators.DurationBetween(k_, l_, "day");
                int? n_ = context.Operators.Add(m_, 1);
                int?[] o_ = [
                    n_,
                    0,
                ];
                int? p_ = context.Operators.Max<int?>((IEnumerable<int?>)o_);
                return p_;
            }

            IEnumerable<int?> h_ = context.Operators.SelectDistinct<CqlInterval<CqlDateTime>, int?>(collapsedIntervals, g_);
            int? i_ = context.Operators.Sum(h_);
            b_ = i_;
        }
        CqlInterval<CqlDateTime> c_;
        bool? q_ = context.Operators.Equal(a_, 0);
        if (q_ ?? false)
        {
            c_ = null as CqlInterval<CqlDateTime>;
        }
        else
        {

            (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? r_(CqlInterval<CqlDateTime> I) {
                CqlInterval<CqlDateTime> x_ = this.DateTime_Interval_Set_Nulls_to_Zero(context, I);
                CqlDateTime y_ = context.Operators.Start(x_);
                CqlDateTime z_ = context.Operators.End(x_);
                int? aa_ = context.Operators.DurationBetween(y_, z_, "day");
                int? ab_ = context.Operators.Add(aa_, 1);
                int?[] ac_ = [
                    ab_,
                    0,
                ];
                int? ad_ = context.Operators.Max<int?>((IEnumerable<int?>)ac_);
                (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? ae_ = (CqlTupleMetadata_CGHEUIgjaCjJVKEADTSZEbdCL, I, ad_);
                return ae_;
            }

            IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> s_ = context.Operators.SelectDistinct<CqlInterval<CqlDateTime>, (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(collapsedIntervals, r_);

            object t_((CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? @this) {
                int? af_ = @this?.days;
                return af_;
            }

            IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> u_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(s_, t_, System.ComponentModel.ListSortDirection.Descending);
            (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? v_ = context.Operators.First<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(u_);
            CqlInterval<CqlDateTime> w_ = v_?.interval;
            c_ = w_;
        }
        int? d_;
        bool? ag_ = context.Operators.Equal(a_, 0);
        if (ag_ ?? false)
        {
            d_ = 0;
        }
        else
        {

            (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? ah_(CqlInterval<CqlDateTime> I) {
                CqlInterval<CqlDateTime> bb_ = this.DateTime_Interval_Set_Nulls_to_Zero(context, I);
                CqlDateTime bc_ = context.Operators.Start(bb_);
                CqlDateTime bd_ = context.Operators.End(bb_);
                int? be_ = context.Operators.DurationBetween(bc_, bd_, "day");
                int? bf_ = context.Operators.Add(be_, 1);
                int?[] bg_ = [
                    bf_,
                    0,
                ];
                int? bh_ = context.Operators.Max<int?>((IEnumerable<int?>)bg_);
                (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? bi_ = (CqlTupleMetadata_CGHEUIgjaCjJVKEADTSZEbdCL, I, bh_);
                return bi_;
            }

            IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> ai_ = context.Operators.SelectDistinct<CqlInterval<CqlDateTime>, (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(collapsedIntervals, ah_);

            object aj_((CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? @this) {
                int? bj_ = @this?.days;
                return bj_;
            }

            IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> ak_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(ai_, aj_, System.ComponentModel.ListSortDirection.Descending);
            (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? al_ = context.Operators.First<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(ak_);
            CqlInterval<CqlDateTime> am_ = al_?.interval;
            CqlInterval<CqlDateTime> an_ = this.DateTime_Interval_Set_Nulls_to_Zero(context, am_);
            CqlDateTime ao_ = context.Operators.Start(an_);

            (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? ap_(CqlInterval<CqlDateTime> I) {
                CqlInterval<CqlDateTime> bk_ = this.DateTime_Interval_Set_Nulls_to_Zero(context, I);
                CqlDateTime bl_ = context.Operators.Start(bk_);
                CqlDateTime bm_ = context.Operators.End(bk_);
                int? bn_ = context.Operators.DurationBetween(bl_, bm_, "day");
                int? bo_ = context.Operators.Add(bn_, 1);
                int?[] bp_ = [
                    bo_,
                    0,
                ];
                int? bq_ = context.Operators.Max<int?>((IEnumerable<int?>)bp_);
                (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? br_ = (CqlTupleMetadata_CGHEUIgjaCjJVKEADTSZEbdCL, I, bq_);
                return br_;
            }

            IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> aq_ = context.Operators.SelectDistinct<CqlInterval<CqlDateTime>, (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(collapsedIntervals, ap_);

            object ar_((CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? @this) {
                int? bs_ = @this?.days;
                return bs_;
            }

            IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> as_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(aq_, ar_, System.ComponentModel.ListSortDirection.Descending);
            (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? at_ = context.Operators.First<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(as_);
            CqlInterval<CqlDateTime> au_ = at_?.interval;
            CqlInterval<CqlDateTime> av_ = this.DateTime_Interval_Set_Nulls_to_Zero(context, au_);
            CqlDateTime aw_ = context.Operators.End(av_);
            int? ax_ = context.Operators.DurationBetween(ao_, aw_, "day");
            int? ay_ = context.Operators.Add(ax_, 1);
            int?[] az_ = [
                ay_,
                0,
            ];
            int? ba_ = context.Operators.Max<int?>((IEnumerable<int?>)az_);
            d_ = ba_;
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
