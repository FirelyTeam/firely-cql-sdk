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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.5.0")]
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
                    CqlDate m_;
                    if ((context.Operators.Start(I)) is null)
                    {
                        CqlDate o_ = context.Operators.MinValue<CqlDate>();
                        m_ = o_;
                    }
                    else
                    {
                        CqlDate p_ = context.Operators.Start(I);
                        m_ = p_;
                    }
                    (CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)? n_ = (CqlTupleMetadata_GIMHfXDcFiAjSJBDGYeUeZLhW, I, m_);
                    return n_;
                }

                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)?> f_ = context.Operators.Select<CqlInterval<CqlDate>, (CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)?>(intervals, e_);
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)?> g_ = context.Operators.Distinct<(CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)?>(f_);

                object h_((CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)? @this) {
                    CqlDate q_ = @this?.startOfInterval;
                    return q_;
                }

                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)?> i_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)?>(g_, h_, System.ComponentModel.ListSortDirection.Ascending);

                CqlInterval<CqlDate> j_((CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)? sortedIntervals) {
                    CqlInterval<CqlDate> r_ = sortedIntervals?.interval;
                    return r_;
                }

                IEnumerable<CqlInterval<CqlDate>> k_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)?, CqlInterval<CqlDate>>(i_, j_);
                IEnumerable<CqlInterval<CqlDate>> l_ = context.Operators.Distinct<CqlInterval<CqlDate>>(k_);
                return l_;
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
                    CqlDateTime m_;
                    if ((context.Operators.Start(I)) is null)
                    {
                        CqlDateTime o_ = context.Operators.MinValue<CqlDateTime>();
                        m_ = o_;
                    }
                    else
                    {
                        CqlDateTime p_ = context.Operators.Start(I);
                        m_ = p_;
                    }
                    (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)? n_ = (CqlTupleMetadata_EQHOUSiiWahbJPOUjJGEhIAOV, I, m_);
                    return n_;
                }

                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?> f_ = context.Operators.Select<CqlInterval<CqlDateTime>, (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?>(intervals, e_);
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?> g_ = context.Operators.Distinct<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?>(f_);

                object h_((CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)? @this) {
                    CqlDateTime q_ = @this?.startOfInterval;
                    return q_;
                }

                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?> i_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?>(g_, h_, System.ComponentModel.ListSortDirection.Ascending);

                CqlInterval<CqlDateTime> j_((CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)? sortedIntervals) {
                    CqlInterval<CqlDateTime> r_ = sortedIntervals?.interval;
                    return r_;
                }

                IEnumerable<CqlInterval<CqlDateTime>> k_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?, CqlInterval<CqlDateTime>>(i_, j_);
                IEnumerable<CqlInterval<CqlDateTime>> l_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(k_);
                return l_;
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
                        bool? m_ = context.Operators.IntervalProperlyIncludesInterval<CqlDate>(J, I, (string)default);
                        return m_;
                    }

                    IEnumerable<bool?> i_ = context.Operators.Select<CqlInterval<CqlDate>, bool?>(intervals, h_);
                    IEnumerable<bool?> j_ = context.Operators.Distinct<bool?>(i_);
                    bool? k_ = context.Operators.AnyTrue(j_);
                    bool? l_ = context.Operators.Not(k_);
                    return l_;
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
                        bool? m_ = context.Operators.IntervalProperlyIncludesInterval<CqlDateTime>(J, I, (string)default);
                        return m_;
                    }

                    IEnumerable<bool?> i_ = context.Operators.Select<CqlInterval<CqlDateTime>, bool?>(intervals, h_);
                    IEnumerable<bool?> j_ = context.Operators.Distinct<bool?>(i_);
                    bool? k_ = context.Operators.AnyTrue(j_);
                    bool? l_ = context.Operators.Not(k_);
                    return l_;
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
            CqlInterval<CqlDate> f_ = context.Operators.Intersect<CqlDate>(baseInterval, sortedInterval);
            return f_;
        }

        IEnumerable<CqlInterval<CqlDate>> c_ = context.Operators.Select<CqlInterval<CqlDate>, CqlInterval<CqlDate>>(a_, b_);
        IEnumerable<CqlInterval<CqlDate>> d_ = context.Operators.Distinct<CqlInterval<CqlDate>>(c_);
        IEnumerable<CqlInterval<CqlDate>> e_ = this.Collapse_Date_Interval_Workaround(context, d_);
        return e_;
    }


    [CqlFunctionDefinition("DateTime Interval Covering Relative to Base Interval")]
    public IEnumerable<CqlInterval<CqlDateTime>> DateTime_Interval_Covering_Relative_to_Base_Interval(CqlContext context, CqlInterval<CqlDateTime> baseInterval, IEnumerable<CqlInterval<CqlDateTime>> coveringIntervals)
    {
        IEnumerable<CqlInterval<CqlDateTime>> a_ = this.Sort_DateTime_Intervals(context, coveringIntervals);

        CqlInterval<CqlDateTime> b_(CqlInterval<CqlDateTime> sortedInterval) {
            CqlInterval<CqlDateTime> f_ = context.Operators.Intersect<CqlDateTime>(baseInterval, sortedInterval);
            return f_;
        }

        IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(a_, b_);
        IEnumerable<CqlInterval<CqlDateTime>> d_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(c_);
        IEnumerable<CqlInterval<CqlDateTime>> e_ = this.Collapse_DateTime_Interval_Workaround(context, d_);
        return e_;
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
            IEnumerable<CqlInterval<CqlDate>> h_;
            IEnumerable<CqlInterval<CqlDate>> p_ = variableDeclarations?.sortedCoverings;
            int? q_ = context.Operators.Count<CqlInterval<CqlDate>>(p_);
            bool? r_ = context.Operators.Equal(q_, 0);
            if (r_ ?? false)
            {
                CqlInterval<CqlDate>[] s_ = [
                    baseInterval,
                ];
                h_ = (IEnumerable<CqlInterval<CqlDate>>)s_;
            }
            else
            {
                IEnumerable<CqlInterval<CqlDate>> t_ = variableDeclarations?.sortedCoverings;

                CqlInterval<CqlDate> u_(CqlInterval<CqlDate> sortedCovering) {
                    IEnumerable<CqlInterval<CqlDate>> x_ = variableDeclarations?.sortedCoverings;
                    int? y_ = context.Operators.IndexOf<CqlInterval<CqlDate>>(x_, sortedCovering);
                    bool? z_ = context.Operators.Equal(y_, 0);
                    if (z_ ?? false)
                    {
                        CqlDate aa_ = context.Operators.Start(baseInterval);
                        CqlDate ab_ = context.Operators.Start(sortedCovering);
                        CqlInterval<CqlDate> ac_ = context.Operators.Interval(aa_, ab_, true, true);
                        CqlInterval<CqlDate> ad_ = context.Operators.Intersect<CqlDate>(ac_, baseInterval);
                        CqlInterval<CqlDate> ae_ = context.Operators.Except(ad_, sortedCovering);
                        return ae_;
                    }
                    else
                    {
                        IEnumerable<CqlInterval<CqlDate>> af_ = variableDeclarations?.sortedCoverings;
                        int? ag_ = context.Operators.IndexOf<CqlInterval<CqlDate>>(af_, sortedCovering);
                        int? ah_ = context.Operators.Subtract(ag_, 1);
                        CqlInterval<CqlDate> ai_ = context.Operators.Indexer<CqlInterval<CqlDate>>(af_, ah_);
                        CqlDate aj_ = context.Operators.Start(ai_);
                        CqlDate ak_ = context.Operators.End(sortedCovering);
                        CqlInterval<CqlDate> al_ = context.Operators.Interval(aj_, ak_, false, false);
                        CqlInterval<CqlDate> am_ = context.Operators.Except(al_, ai_);
                        CqlInterval<CqlDate> an_ = context.Operators.Except(am_, sortedCovering);
                        return an_;
                    }
                }

                IEnumerable<CqlInterval<CqlDate>> v_ = context.Operators.Select<CqlInterval<CqlDate>, CqlInterval<CqlDate>>(t_, u_);
                IEnumerable<CqlInterval<CqlDate>> w_ = context.Operators.Distinct<CqlInterval<CqlDate>>(v_);
                h_ = w_;
            }
            IEnumerable<CqlInterval<CqlDate>> i_;
            IEnumerable<CqlInterval<CqlDate>> ao_ = variableDeclarations?.sortedCoverings;
            int? ap_ = context.Operators.Count<CqlInterval<CqlDate>>(ao_);
            bool? aq_ = context.Operators.Equal(ap_, 0);
            if (aq_ ?? false)
            {
                CqlInterval<CqlDate>[] ar_ = [];
                i_ = ar_ as IEnumerable<CqlInterval<CqlDate>>;
            }
            else
            {
                IEnumerable<CqlInterval<CqlDate>> as_ = variableDeclarations?.sortedCoverings;
                CqlInterval<CqlDate> at_ = context.Operators.Last<CqlInterval<CqlDate>>(as_);
                CqlDate au_ = context.Operators.Start(at_);
                CqlDate av_ = context.Operators.End(baseInterval);
                CqlInterval<CqlDate> aw_ = context.Operators.Interval(au_, av_, false, true);
                CqlInterval<CqlDate> ax_ = context.Operators.Except(aw_, at_);
                CqlInterval<CqlDate> ay_ = context.Operators.Intersect<CqlDate>(ax_, baseInterval);
                CqlInterval<CqlDate>[] az_ = [
                    ay_,
                ];
                i_ = (IEnumerable<CqlInterval<CqlDate>>)az_;
            }
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> frontgaps, IEnumerable<CqlInterval<CqlDate>> endgap)? j_ = (CqlTupleMetadata_FKcLSALRMRfDigEFaJgDOPFRK, h_, i_);
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> frontgaps, IEnumerable<CqlInterval<CqlDate>> endgap)?[] k_ = [
                j_,
            ];

            IEnumerable<CqlInterval<CqlDate>> l_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> frontgaps, IEnumerable<CqlInterval<CqlDate>> endgap)? calculations) {
                IEnumerable<CqlInterval<CqlDate>> ba_ = calculations?.frontgaps;
                IEnumerable<CqlInterval<CqlDate>> bb_ = calculations?.endgap;
                IEnumerable<CqlInterval<CqlDate>> bc_ = context.Operators.Union<CqlInterval<CqlDate>>(ba_, bb_);
                IEnumerable<CqlInterval<CqlDate>> bd_ = this.Collapse_Date_Interval_Workaround(context, bc_);
                return bd_;
            }

            IEnumerable<IEnumerable<CqlInterval<CqlDate>>> m_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> frontgaps, IEnumerable<CqlInterval<CqlDate>> endgap)?, IEnumerable<CqlInterval<CqlDate>>>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> frontgaps, IEnumerable<CqlInterval<CqlDate>> endgap)?>)k_, l_);
            IEnumerable<IEnumerable<CqlInterval<CqlDate>>> n_ = context.Operators.Distinct<IEnumerable<CqlInterval<CqlDate>>>(m_);
            IEnumerable<CqlInterval<CqlDate>> o_ = context.Operators.SingletonFrom<IEnumerable<CqlInterval<CqlDate>>>(n_);
            return o_;
        }

        IEnumerable<IEnumerable<CqlInterval<CqlDate>>> e_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> sortedCoverings)?, IEnumerable<CqlInterval<CqlDate>>>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> sortedCoverings)?>)c_, d_);
        IEnumerable<IEnumerable<CqlInterval<CqlDate>>> f_ = context.Operators.Distinct<IEnumerable<CqlInterval<CqlDate>>>(e_);
        IEnumerable<CqlInterval<CqlDate>> g_ = context.Operators.SingletonFrom<IEnumerable<CqlInterval<CqlDate>>>(f_);
        return g_;
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
            IEnumerable<CqlInterval<CqlDateTime>> h_;
            IEnumerable<CqlInterval<CqlDateTime>> p_ = variableDeclarations?.sortedCoverings;
            int? q_ = context.Operators.Count<CqlInterval<CqlDateTime>>(p_);
            bool? r_ = context.Operators.Equal(q_, 0);
            if (r_ ?? false)
            {
                CqlInterval<CqlDateTime>[] s_ = [
                    baseInterval,
                ];
                h_ = (IEnumerable<CqlInterval<CqlDateTime>>)s_;
            }
            else
            {
                IEnumerable<CqlInterval<CqlDateTime>> t_ = variableDeclarations?.sortedCoverings;

                CqlInterval<CqlDateTime> u_(CqlInterval<CqlDateTime> sortedCovering) {
                    IEnumerable<CqlInterval<CqlDateTime>> x_ = variableDeclarations?.sortedCoverings;
                    int? y_ = context.Operators.IndexOf<CqlInterval<CqlDateTime>>(x_, sortedCovering);
                    bool? z_ = context.Operators.Equal(y_, 0);
                    if (z_ ?? false)
                    {
                        CqlDateTime aa_ = context.Operators.Start(baseInterval);
                        CqlDateTime ab_ = context.Operators.Start(sortedCovering);
                        CqlInterval<CqlDateTime> ac_ = context.Operators.Interval(aa_, ab_, true, true);
                        CqlInterval<CqlDateTime> ad_ = context.Operators.Intersect<CqlDateTime>(ac_, baseInterval);
                        CqlInterval<CqlDateTime> ae_ = context.Operators.Except(ad_, sortedCovering);
                        return ae_;
                    }
                    else
                    {
                        IEnumerable<CqlInterval<CqlDateTime>> af_ = variableDeclarations?.sortedCoverings;
                        int? ag_ = context.Operators.IndexOf<CqlInterval<CqlDateTime>>(af_, sortedCovering);
                        int? ah_ = context.Operators.Subtract(ag_, 1);
                        CqlInterval<CqlDateTime> ai_ = context.Operators.Indexer<CqlInterval<CqlDateTime>>(af_, ah_);
                        CqlDateTime aj_ = context.Operators.Start(ai_);
                        CqlDateTime ak_ = context.Operators.End(sortedCovering);
                        CqlInterval<CqlDateTime> al_ = context.Operators.Interval(aj_, ak_, false, false);
                        CqlInterval<CqlDateTime> am_ = context.Operators.Except(al_, ai_);
                        CqlInterval<CqlDateTime> an_ = context.Operators.Except(am_, sortedCovering);
                        return an_;
                    }
                }

                IEnumerable<CqlInterval<CqlDateTime>> v_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(t_, u_);
                IEnumerable<CqlInterval<CqlDateTime>> w_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(v_);
                h_ = w_;
            }
            IEnumerable<CqlInterval<CqlDateTime>> i_;
            IEnumerable<CqlInterval<CqlDateTime>> ao_ = variableDeclarations?.sortedCoverings;
            int? ap_ = context.Operators.Count<CqlInterval<CqlDateTime>>(ao_);
            bool? aq_ = context.Operators.Equal(ap_, 0);
            if (aq_ ?? false)
            {
                CqlInterval<CqlDateTime>[] ar_ = [];
                i_ = ar_ as IEnumerable<CqlInterval<CqlDateTime>>;
            }
            else
            {
                IEnumerable<CqlInterval<CqlDateTime>> as_ = variableDeclarations?.sortedCoverings;
                CqlInterval<CqlDateTime> at_ = context.Operators.Last<CqlInterval<CqlDateTime>>(as_);
                CqlDateTime au_ = context.Operators.Start(at_);
                CqlDateTime av_ = context.Operators.End(baseInterval);
                CqlInterval<CqlDateTime> aw_ = context.Operators.Interval(au_, av_, false, true);
                CqlInterval<CqlDateTime> ax_ = context.Operators.Except(aw_, at_);
                CqlInterval<CqlDateTime> ay_ = context.Operators.Intersect<CqlDateTime>(ax_, baseInterval);
                CqlInterval<CqlDateTime>[] az_ = [
                    ay_,
                ];
                i_ = (IEnumerable<CqlInterval<CqlDateTime>>)az_;
            }
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> frontgaps, IEnumerable<CqlInterval<CqlDateTime>> endgap)? j_ = (CqlTupleMetadata_BBLSSiNBQBGUDJaVjMDZMSAXg, h_, i_);
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> frontgaps, IEnumerable<CqlInterval<CqlDateTime>> endgap)?[] k_ = [
                j_,
            ];

            IEnumerable<CqlInterval<CqlDateTime>> l_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> frontgaps, IEnumerable<CqlInterval<CqlDateTime>> endgap)? calculations) {
                IEnumerable<CqlInterval<CqlDateTime>> ba_ = calculations?.frontgaps;
                IEnumerable<CqlInterval<CqlDateTime>> bb_ = calculations?.endgap;
                IEnumerable<CqlInterval<CqlDateTime>> bc_ = context.Operators.Union<CqlInterval<CqlDateTime>>(ba_, bb_);
                IEnumerable<CqlInterval<CqlDateTime>> bd_ = this.Collapse_DateTime_Interval_Workaround(context, bc_);
                return bd_;
            }

            IEnumerable<IEnumerable<CqlInterval<CqlDateTime>>> m_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> frontgaps, IEnumerable<CqlInterval<CqlDateTime>> endgap)?, IEnumerable<CqlInterval<CqlDateTime>>>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> frontgaps, IEnumerable<CqlInterval<CqlDateTime>> endgap)?>)k_, l_);
            IEnumerable<IEnumerable<CqlInterval<CqlDateTime>>> n_ = context.Operators.Distinct<IEnumerable<CqlInterval<CqlDateTime>>>(m_);
            IEnumerable<CqlInterval<CqlDateTime>> o_ = context.Operators.SingletonFrom<IEnumerable<CqlInterval<CqlDateTime>>>(n_);
            return o_;
        }

        IEnumerable<IEnumerable<CqlInterval<CqlDateTime>>> e_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> sortedCoverings)?, IEnumerable<CqlInterval<CqlDateTime>>>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> sortedCoverings)?>)c_, d_);
        IEnumerable<IEnumerable<CqlInterval<CqlDateTime>>> f_ = context.Operators.Distinct<IEnumerable<CqlInterval<CqlDateTime>>>(e_);
        IEnumerable<CqlInterval<CqlDateTime>> g_ = context.Operators.SingletonFrom<IEnumerable<CqlInterval<CqlDateTime>>>(f_);
        return g_;
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
                CqlDate l_ = context.Operators.Start(I);
                CqlDate m_ = context.Operators.End(I);
                int? n_ = context.Operators.DurationBetween(l_, m_, "day");
                int? o_ = context.Operators.Add(n_, 1);
                int?[] p_ = [
                    o_,
                    0,
                ];
                int? q_ = context.Operators.Max<int?>((IEnumerable<int?>)p_);
                return q_;
            }

            IEnumerable<int?> i_ = context.Operators.Select<CqlInterval<CqlDate>, int?>(collapsedIntervals, h_);
            IEnumerable<int?> j_ = context.Operators.Distinct<int?>(i_);
            int? k_ = context.Operators.Sum(j_);
            b_ = k_;
        }
        CqlInterval<CqlDate> c_;
        int? r_ = context.Operators.Count<CqlInterval<CqlDate>>(collapsedIntervals);
        bool? s_ = context.Operators.Equal(r_, 0);
        if (s_ ?? false)
        {
            c_ = null as CqlInterval<CqlDate>;
        }
        else
        {

            (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? t_(CqlInterval<CqlDate> I) {
                CqlDate aa_ = context.Operators.Start(I);
                CqlDate ab_ = context.Operators.End(I);
                int? ac_ = context.Operators.DurationBetween(aa_, ab_, "day");
                int? ad_ = context.Operators.Add(ac_, 1);
                int?[] ae_ = [
                    ad_,
                    0,
                ];
                int? af_ = context.Operators.Max<int?>((IEnumerable<int?>)ae_);
                (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? ag_ = (CqlTupleMetadata_HEjPGjPEhLgQPGjROeWMgiGfC, I, af_);
                return ag_;
            }

            IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> u_ = context.Operators.Select<CqlInterval<CqlDate>, (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(collapsedIntervals, t_);
            IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> v_ = context.Operators.Distinct<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(u_);

            object w_((CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? @this) {
                int? ah_ = @this?.days;
                return ah_;
            }

            IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> x_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(v_, w_, System.ComponentModel.ListSortDirection.Descending);
            (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? y_ = context.Operators.First<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(x_);
            CqlInterval<CqlDate> z_ = y_?.interval;
            c_ = z_;
        }
        int? d_;
        int? ai_ = context.Operators.Count<CqlInterval<CqlDate>>(collapsedIntervals);
        bool? aj_ = context.Operators.Equal(ai_, 0);
        if (aj_ ?? false)
        {
            d_ = 0;
        }
        else
        {

            (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? ak_(CqlInterval<CqlDate> I) {
                CqlDate be_ = context.Operators.Start(I);
                CqlDate bf_ = context.Operators.End(I);
                int? bg_ = context.Operators.DurationBetween(be_, bf_, "day");
                int? bh_ = context.Operators.Add(bg_, 1);
                int?[] bi_ = [
                    bh_,
                    0,
                ];
                int? bj_ = context.Operators.Max<int?>((IEnumerable<int?>)bi_);
                (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? bk_ = (CqlTupleMetadata_HEjPGjPEhLgQPGjROeWMgiGfC, I, bj_);
                return bk_;
            }

            IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> al_ = context.Operators.Select<CqlInterval<CqlDate>, (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(collapsedIntervals, ak_);
            IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> am_ = context.Operators.Distinct<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(al_);

            object an_((CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? @this) {
                int? bl_ = @this?.days;
                return bl_;
            }

            IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> ao_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(am_, an_, System.ComponentModel.ListSortDirection.Descending);
            (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? ap_ = context.Operators.First<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(ao_);
            CqlInterval<CqlDate> aq_ = ap_?.interval;
            CqlDate ar_ = context.Operators.Start(aq_);

            (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? as_(CqlInterval<CqlDate> I) {
                CqlDate bm_ = context.Operators.Start(I);
                CqlDate bn_ = context.Operators.End(I);
                int? bo_ = context.Operators.DurationBetween(bm_, bn_, "day");
                int? bp_ = context.Operators.Add(bo_, 1);
                int?[] bq_ = [
                    bp_,
                    0,
                ];
                int? br_ = context.Operators.Max<int?>((IEnumerable<int?>)bq_);
                (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? bs_ = (CqlTupleMetadata_HEjPGjPEhLgQPGjROeWMgiGfC, I, br_);
                return bs_;
            }

            IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> at_ = context.Operators.Select<CqlInterval<CqlDate>, (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(collapsedIntervals, as_);
            IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> au_ = context.Operators.Distinct<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(at_);

            object av_((CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? @this) {
                int? bt_ = @this?.days;
                return bt_;
            }

            IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> aw_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(au_, av_, System.ComponentModel.ListSortDirection.Descending);
            (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? ax_ = context.Operators.First<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(aw_);
            CqlInterval<CqlDate> ay_ = ax_?.interval;
            CqlDate az_ = context.Operators.End(ay_);
            int? ba_ = context.Operators.DurationBetween(ar_, az_, "day");
            int? bb_ = context.Operators.Add(ba_, 1);
            int?[] bc_ = [
                bb_,
                0,
            ];
            int? bd_ = context.Operators.Max<int?>((IEnumerable<int?>)bc_);
            d_ = bd_;
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
            IEnumerable<CqlInterval<CqlDate>> h_ = variableDeclarations?.Covering_Intervals;
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? i_ = this.Collapsed_Date_Interval_Stats(context, h_);
            return i_;
        }

        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?> e_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Covering_Intervals)?, (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Covering_Intervals)?>)c_, d_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?> f_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>(e_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? g_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>(f_);
        return g_;
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
            IEnumerable<CqlInterval<CqlDate>> h_ = variableDeclarations?.Gap_Intervals;
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? i_ = this.Collapsed_Date_Interval_Stats(context, h_);
            return i_;
        }

        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?> e_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Gap_Intervals)?, (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Gap_Intervals)?>)c_, d_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?> f_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>(e_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? g_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>(f_);
        return g_;
    }


    [CqlFunctionDefinition("DateTime Interval Set Nulls to Zero")]
    public CqlInterval<CqlDateTime> DateTime_Interval_Set_Nulls_to_Zero(CqlContext context, CqlInterval<CqlDateTime> interval)
    {
        CqlDateTime a_ = context.Operators.Start(interval);
        int? b_ = context.Operators.DateTimeComponentFrom(a_, "year");
        int? c_;
        CqlDateTime w_ = context.Operators.Start(interval);
        int? x_ = context.Operators.DateTimeComponentFrom(w_, "month");
        if (x_ is null)
        {
            c_ = 0;
        }
        else
        {
            CqlDateTime y_ = context.Operators.Start(interval);
            int? z_ = context.Operators.DateTimeComponentFrom(y_, "month");
            c_ = z_;
        }
        int? d_;
        CqlDateTime aa_ = context.Operators.Start(interval);
        int? ab_ = context.Operators.DateTimeComponentFrom(aa_, "day");
        if (ab_ is null)
        {
            d_ = 0;
        }
        else
        {
            CqlDateTime ac_ = context.Operators.Start(interval);
            int? ad_ = context.Operators.DateTimeComponentFrom(ac_, "day");
            d_ = ad_;
        }
        int? e_;
        CqlDateTime ae_ = context.Operators.Start(interval);
        int? af_ = context.Operators.DateTimeComponentFrom(ae_, "hour");
        if (af_ is null)
        {
            e_ = 0;
        }
        else
        {
            CqlDateTime ag_ = context.Operators.Start(interval);
            int? ah_ = context.Operators.DateTimeComponentFrom(ag_, "hour");
            e_ = ah_;
        }
        int? f_;
        CqlDateTime ai_ = context.Operators.Start(interval);
        int? aj_ = context.Operators.DateTimeComponentFrom(ai_, "minute");
        if (aj_ is null)
        {
            f_ = 0;
        }
        else
        {
            CqlDateTime ak_ = context.Operators.Start(interval);
            int? al_ = context.Operators.DateTimeComponentFrom(ak_, "minute");
            f_ = al_;
        }
        int? g_;
        CqlDateTime am_ = context.Operators.Start(interval);
        int? an_ = context.Operators.DateTimeComponentFrom(am_, "second");
        if (an_ is null)
        {
            g_ = 0;
        }
        else
        {
            CqlDateTime ao_ = context.Operators.Start(interval);
            int? ap_ = context.Operators.DateTimeComponentFrom(ao_, "second");
            g_ = ap_;
        }
        int? h_;
        CqlDateTime aq_ = context.Operators.Start(interval);
        int? ar_ = context.Operators.DateTimeComponentFrom(aq_, "millisecond");
        if (ar_ is null)
        {
            h_ = 0;
        }
        else
        {
            CqlDateTime as_ = context.Operators.Start(interval);
            int? at_ = context.Operators.DateTimeComponentFrom(as_, "millisecond");
            h_ = at_;
        }
        CqlDateTime i_ = context.Operators.End(interval);
        int? j_ = context.Operators.DateTimeComponentFrom(i_, "year");
        int? k_;
        CqlDateTime au_ = context.Operators.End(interval);
        int? av_ = context.Operators.DateTimeComponentFrom(au_, "month");
        if (av_ is null)
        {
            k_ = 0;
        }
        else
        {
            CqlDateTime aw_ = context.Operators.End(interval);
            int? ax_ = context.Operators.DateTimeComponentFrom(aw_, "month");
            k_ = ax_;
        }
        int? l_;
        CqlDateTime ay_ = context.Operators.End(interval);
        int? az_ = context.Operators.DateTimeComponentFrom(ay_, "day");
        if (az_ is null)
        {
            l_ = 0;
        }
        else
        {
            CqlDateTime ba_ = context.Operators.End(interval);
            int? bb_ = context.Operators.DateTimeComponentFrom(ba_, "day");
            l_ = bb_;
        }
        int? m_;
        CqlDateTime bc_ = context.Operators.End(interval);
        int? bd_ = context.Operators.DateTimeComponentFrom(bc_, "hour");
        if (bd_ is null)
        {
            m_ = 0;
        }
        else
        {
            CqlDateTime be_ = context.Operators.End(interval);
            int? bf_ = context.Operators.DateTimeComponentFrom(be_, "hour");
            m_ = bf_;
        }
        int? n_;
        CqlDateTime bg_ = context.Operators.End(interval);
        int? bh_ = context.Operators.DateTimeComponentFrom(bg_, "minute");
        if (bh_ is null)
        {
            n_ = 0;
        }
        else
        {
            CqlDateTime bi_ = context.Operators.End(interval);
            int? bj_ = context.Operators.DateTimeComponentFrom(bi_, "minute");
            n_ = bj_;
        }
        int? o_;
        CqlDateTime bk_ = context.Operators.End(interval);
        int? bl_ = context.Operators.DateTimeComponentFrom(bk_, "second");
        if (bl_ is null)
        {
            o_ = 0;
        }
        else
        {
            CqlDateTime bm_ = context.Operators.End(interval);
            int? bn_ = context.Operators.DateTimeComponentFrom(bm_, "second");
            o_ = bn_;
        }
        int? p_;
        CqlDateTime bo_ = context.Operators.End(interval);
        int? bp_ = context.Operators.DateTimeComponentFrom(bo_, "millisecond");
        if (bp_ is null)
        {
            p_ = 0;
        }
        else
        {
            CqlDateTime bq_ = context.Operators.End(interval);
            int? br_ = context.Operators.DateTimeComponentFrom(bq_, "millisecond");
            p_ = br_;
        }
        (CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)? q_ = (CqlTupleMetadata_FcQREFSfPJSKYAhSEWVJcZVED, b_, c_, d_, e_, f_, g_, h_, j_, k_, l_, m_, n_, o_, p_);
        (CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)?[] r_ = [
            q_,
        ];

        CqlInterval<CqlDateTime> s_((CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)? i) {
            int? bs_ = i?.StartYear;
            int? bt_ = i?.StartMonth;
            int? bu_ = i?.StartDay;
            int? bv_ = i?.StartHour;
            int? bw_ = i?.StartMinute;
            int? bx_ = i?.StartSecond;
            int? by_ = i?.StartMillisecond;
            CqlDateTime bz_ = context.Operators.DateTime(bs_, bt_, bu_, bv_, bw_, bx_, by_, (decimal?)default);
            int? ca_ = i?.EndYear;
            int? cb_ = i?.EndMonth;
            int? cc_ = i?.EndDay;
            int? cd_ = i?.EndHour;
            int? ce_ = i?.EndMinute;
            int? cf_ = i?.EndSecond;
            int? cg_ = i?.EndMillisecond;
            CqlDateTime ch_ = context.Operators.DateTime(ca_, cb_, cc_, cd_, ce_, cf_, cg_, (decimal?)default);
            CqlInterval<CqlDateTime> ci_ = context.Operators.Interval(bz_, ch_, true, true);
            return ci_;
        }

        IEnumerable<CqlInterval<CqlDateTime>> t_ = context.Operators.Select<(CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)?, CqlInterval<CqlDateTime>>((IEnumerable<(CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)?>)r_, s_);
        IEnumerable<CqlInterval<CqlDateTime>> u_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(t_);
        CqlInterval<CqlDateTime> v_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(u_);
        return v_;
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
                CqlInterval<CqlDateTime> l_ = this.DateTime_Interval_Set_Nulls_to_Zero(context, I);
                CqlDateTime m_ = context.Operators.Start(l_);
                CqlDateTime n_ = context.Operators.End(l_);
                int? o_ = context.Operators.DurationBetween(m_, n_, "day");
                int? p_ = context.Operators.Add(o_, 1);
                int?[] q_ = [
                    p_,
                    0,
                ];
                int? r_ = context.Operators.Max<int?>((IEnumerable<int?>)q_);
                return r_;
            }

            IEnumerable<int?> i_ = context.Operators.Select<CqlInterval<CqlDateTime>, int?>(collapsedIntervals, h_);
            IEnumerable<int?> j_ = context.Operators.Distinct<int?>(i_);
            int? k_ = context.Operators.Sum(j_);
            b_ = k_;
        }
        CqlInterval<CqlDateTime> c_;
        int? s_ = context.Operators.Count<CqlInterval<CqlDateTime>>(collapsedIntervals);
        bool? t_ = context.Operators.Equal(s_, 0);
        if (t_ ?? false)
        {
            c_ = null as CqlInterval<CqlDateTime>;
        }
        else
        {

            (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? u_(CqlInterval<CqlDateTime> I) {
                CqlInterval<CqlDateTime> ab_ = this.DateTime_Interval_Set_Nulls_to_Zero(context, I);
                CqlDateTime ac_ = context.Operators.Start(ab_);
                CqlDateTime ad_ = context.Operators.End(ab_);
                int? ae_ = context.Operators.DurationBetween(ac_, ad_, "day");
                int? af_ = context.Operators.Add(ae_, 1);
                int?[] ag_ = [
                    af_,
                    0,
                ];
                int? ah_ = context.Operators.Max<int?>((IEnumerable<int?>)ag_);
                (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? ai_ = (CqlTupleMetadata_CGHEUIgjaCjJVKEADTSZEbdCL, I, ah_);
                return ai_;
            }

            IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> v_ = context.Operators.Select<CqlInterval<CqlDateTime>, (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(collapsedIntervals, u_);
            IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> w_ = context.Operators.Distinct<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(v_);

            object x_((CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? @this) {
                int? aj_ = @this?.days;
                return aj_;
            }

            IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> y_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(w_, x_, System.ComponentModel.ListSortDirection.Descending);
            (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? z_ = context.Operators.First<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(y_);
            CqlInterval<CqlDateTime> aa_ = z_?.interval;
            c_ = aa_;
        }
        int? d_;
        int? ak_ = context.Operators.Count<CqlInterval<CqlDateTime>>(collapsedIntervals);
        bool? al_ = context.Operators.Equal(ak_, 0);
        if (al_ ?? false)
        {
            d_ = 0;
        }
        else
        {

            (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? am_(CqlInterval<CqlDateTime> I) {
                CqlInterval<CqlDateTime> bi_ = this.DateTime_Interval_Set_Nulls_to_Zero(context, I);
                CqlDateTime bj_ = context.Operators.Start(bi_);
                CqlDateTime bk_ = context.Operators.End(bi_);
                int? bl_ = context.Operators.DurationBetween(bj_, bk_, "day");
                int? bm_ = context.Operators.Add(bl_, 1);
                int?[] bn_ = [
                    bm_,
                    0,
                ];
                int? bo_ = context.Operators.Max<int?>((IEnumerable<int?>)bn_);
                (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? bp_ = (CqlTupleMetadata_CGHEUIgjaCjJVKEADTSZEbdCL, I, bo_);
                return bp_;
            }

            IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> an_ = context.Operators.Select<CqlInterval<CqlDateTime>, (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(collapsedIntervals, am_);
            IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> ao_ = context.Operators.Distinct<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(an_);

            object ap_((CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? @this) {
                int? bq_ = @this?.days;
                return bq_;
            }

            IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> aq_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(ao_, ap_, System.ComponentModel.ListSortDirection.Descending);
            (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? ar_ = context.Operators.First<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(aq_);
            CqlInterval<CqlDateTime> as_ = ar_?.interval;
            CqlInterval<CqlDateTime> at_ = this.DateTime_Interval_Set_Nulls_to_Zero(context, as_);
            CqlDateTime au_ = context.Operators.Start(at_);

            (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? av_(CqlInterval<CqlDateTime> I) {
                CqlInterval<CqlDateTime> br_ = this.DateTime_Interval_Set_Nulls_to_Zero(context, I);
                CqlDateTime bs_ = context.Operators.Start(br_);
                CqlDateTime bt_ = context.Operators.End(br_);
                int? bu_ = context.Operators.DurationBetween(bs_, bt_, "day");
                int? bv_ = context.Operators.Add(bu_, 1);
                int?[] bw_ = [
                    bv_,
                    0,
                ];
                int? bx_ = context.Operators.Max<int?>((IEnumerable<int?>)bw_);
                (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? by_ = (CqlTupleMetadata_CGHEUIgjaCjJVKEADTSZEbdCL, I, bx_);
                return by_;
            }

            IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> aw_ = context.Operators.Select<CqlInterval<CqlDateTime>, (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(collapsedIntervals, av_);
            IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> ax_ = context.Operators.Distinct<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(aw_);

            object ay_((CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? @this) {
                int? bz_ = @this?.days;
                return bz_;
            }

            IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> az_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(ax_, ay_, System.ComponentModel.ListSortDirection.Descending);
            (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? ba_ = context.Operators.First<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(az_);
            CqlInterval<CqlDateTime> bb_ = ba_?.interval;
            CqlInterval<CqlDateTime> bc_ = this.DateTime_Interval_Set_Nulls_to_Zero(context, bb_);
            CqlDateTime bd_ = context.Operators.End(bc_);
            int? be_ = context.Operators.DurationBetween(au_, bd_, "day");
            int? bf_ = context.Operators.Add(be_, 1);
            int?[] bg_ = [
                bf_,
                0,
            ];
            int? bh_ = context.Operators.Max<int?>((IEnumerable<int?>)bg_);
            d_ = bh_;
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
            IEnumerable<CqlInterval<CqlDateTime>> h_ = variableDeclarations?.Covering_Intervals;
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? i_ = this.Collapsed_DateTime_Interval_Stats(context, h_);
            return i_;
        }

        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?> e_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Covering_Intervals)?, (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Covering_Intervals)?>)c_, d_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?> f_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?>(e_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? g_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?>(f_);
        return g_;
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
            IEnumerable<CqlInterval<CqlDateTime>> h_ = variableDeclarations?.Gap_Intervals;
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? i_ = this.Collapsed_DateTime_Interval_Stats(context, h_);
            return i_;
        }

        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?> e_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Gap_Intervals)?, (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Gap_Intervals)?>)c_, d_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?> f_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?>(e_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? g_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?>(f_);
        return g_;
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
            int? j_ = context.Operators.DateTimeComponentFrom(d, "month");
            b_ = j_;
        }
        int? c_;
        if ((context.Operators.DateTimeComponentFrom(d, "day")) is null)
        {
            c_ = 0;
        }
        else
        {
            int? k_ = context.Operators.DateTimeComponentFrom(d, "day");
            c_ = k_;
        }
        (CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay)? d_ = (CqlTupleMetadata_BgJFbOiFcaejXZjQOBFLJLhjg, a_, b_, c_);
        (CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay)?[] e_ = [
            d_,
        ];

        CqlDateTime f_((CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay)? i) {
            int? l_ = i?.StartYear;
            int? m_ = i?.StartMonth;
            int? n_ = i?.StartDay;
            decimal? o_ = context.Operators.ConvertIntegerToDecimal(0);
            CqlDateTime p_ = context.Operators.DateTime(l_, m_, n_, 0, 0, 0, 0, o_);
            return p_;
        }

        IEnumerable<CqlDateTime> g_ = context.Operators.Select<(CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay)?, CqlDateTime>((IEnumerable<(CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay)?>)e_, f_);
        IEnumerable<CqlDateTime> h_ = context.Operators.Distinct<CqlDateTime>(g_);
        CqlDateTime i_ = context.Operators.SingletonFrom<CqlDateTime>(h_);
        return i_;
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
