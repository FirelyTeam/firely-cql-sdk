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
[CqlLibrary("NCQACQLBase", "1.0.0")]
public partial class NCQACQLBase_1_0_0 : ILibrary, ISingleton<NCQACQLBase_1_0_0>
{
    #region Functions and Expressions (17)

    [CqlFunctionDefinition("Sort Date Intervals")]
    public IEnumerable<CqlInterval<CqlDate>> Sort_Date_Intervals(CqlContext context, IEnumerable<CqlInterval<CqlDate>> intervals)
    {

        IEnumerable<CqlInterval<CqlDate>> a_() {

            bool b_() {
                int? c_ = context.Operators.Count<CqlInterval<CqlDate>>(intervals);
                bool? d_ = context.Operators.Equal(c_, 0);
                return d_ ?? false;
            }

            if (intervals is null)
            {
                CqlInterval<CqlDate>[] e_ = [];
                return e_ as IEnumerable<CqlInterval<CqlDate>>;
            }
            else if (b_())
            {
                CqlInterval<CqlDate>[] f_ = [];
                return f_ as IEnumerable<CqlInterval<CqlDate>>;
            }
            else
            {

                (CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)? g_(CqlInterval<CqlDate> I) {

                    CqlDate o_() {
                        if ((context.Operators.Start(I)) is null)
                        {
                            CqlDate q_ = context.Operators.MinValue<CqlDate>();
                            return q_;
                        }
                        else
                        {
                            CqlDate r_ = context.Operators.Start(I);
                            return r_;
                        };
                    }

                    (CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)? p_ = (CqlTupleMetadata_GIMHfXDcFiAjSJBDGYeUeZLhW, I, o_());
                    return p_;
                }

                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)?> h_ = context.Operators.Select<CqlInterval<CqlDate>, (CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)?>(intervals, g_);
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)?> i_ = context.Operators.Distinct<(CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)?>(h_);

                object j_((CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)? @this) {
                    CqlDate s_ = @this?.startOfInterval;
                    return s_;
                }

                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)?> k_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)?>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);

                CqlInterval<CqlDate> l_((CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)? sortedIntervals) {
                    CqlInterval<CqlDate> t_ = sortedIntervals?.interval;
                    return t_;
                }

                IEnumerable<CqlInterval<CqlDate>> m_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)?, CqlInterval<CqlDate>>(k_, l_);
                IEnumerable<CqlInterval<CqlDate>> n_ = context.Operators.Distinct<CqlInterval<CqlDate>>(m_);
                return n_;
            };
        }

        return a_();
    }


    [CqlFunctionDefinition("Sort DateTime Intervals")]
    public IEnumerable<CqlInterval<CqlDateTime>> Sort_DateTime_Intervals(CqlContext context, IEnumerable<CqlInterval<CqlDateTime>> intervals)
    {

        IEnumerable<CqlInterval<CqlDateTime>> a_() {

            bool b_() {
                int? c_ = context.Operators.Count<CqlInterval<CqlDateTime>>(intervals);
                bool? d_ = context.Operators.Equal(c_, 0);
                return d_ ?? false;
            }

            if (intervals is null)
            {
                CqlInterval<CqlDateTime>[] e_ = [];
                return e_ as IEnumerable<CqlInterval<CqlDateTime>>;
            }
            else if (b_())
            {
                CqlInterval<CqlDateTime>[] f_ = [];
                return f_ as IEnumerable<CqlInterval<CqlDateTime>>;
            }
            else
            {

                (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)? g_(CqlInterval<CqlDateTime> I) {

                    CqlDateTime o_() {
                        if ((context.Operators.Start(I)) is null)
                        {
                            CqlDateTime q_ = context.Operators.MinValue<CqlDateTime>();
                            return q_;
                        }
                        else
                        {
                            CqlDateTime r_ = context.Operators.Start(I);
                            return r_;
                        };
                    }

                    (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)? p_ = (CqlTupleMetadata_EQHOUSiiWahbJPOUjJGEhIAOV, I, o_());
                    return p_;
                }

                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?> h_ = context.Operators.Select<CqlInterval<CqlDateTime>, (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?>(intervals, g_);
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?> i_ = context.Operators.Distinct<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?>(h_);

                object j_((CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)? @this) {
                    CqlDateTime s_ = @this?.startOfInterval;
                    return s_;
                }

                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?> k_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);

                CqlInterval<CqlDateTime> l_((CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)? sortedIntervals) {
                    CqlInterval<CqlDateTime> t_ = sortedIntervals?.interval;
                    return t_;
                }

                IEnumerable<CqlInterval<CqlDateTime>> m_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?, CqlInterval<CqlDateTime>>(k_, l_);
                IEnumerable<CqlInterval<CqlDateTime>> n_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(m_);
                return n_;
            };
        }

        return a_();
    }


    [CqlFunctionDefinition("Collapse Date Interval Workaround")]
    public IEnumerable<CqlInterval<CqlDate>> Collapse_Date_Interval_Workaround(CqlContext context, IEnumerable<CqlInterval<CqlDate>> intervals)
    {

        IEnumerable<CqlInterval<CqlDate>> a_() {

            bool b_() {
                int? c_ = context.Operators.Count<CqlInterval<CqlDate>>(intervals);
                bool? d_ = context.Operators.Equal(c_, 0);
                return d_ ?? false;
            }

            if (intervals is null)
            {
                CqlInterval<CqlDate>[] e_ = [];
                return e_ as IEnumerable<CqlInterval<CqlDate>>;
            }
            else if (b_())
            {
                CqlInterval<CqlDate>[] f_ = [];
                return f_ as IEnumerable<CqlInterval<CqlDate>>;
            }
            else
            {

                bool? g_(CqlInterval<CqlDate> I) {

                    bool? j_(CqlInterval<CqlDate> J) {
                        bool? o_ = context.Operators.IntervalProperlyIncludesInterval<CqlDate>(J, I, (string)default);
                        return o_;
                    }

                    IEnumerable<bool?> k_ = context.Operators.Select<CqlInterval<CqlDate>, bool?>(intervals, j_);
                    IEnumerable<bool?> l_ = context.Operators.Distinct<bool?>(k_);
                    bool? m_ = context.Operators.AnyTrue(l_);
                    bool? n_ = context.Operators.Not(m_);
                    return n_;
                }

                IEnumerable<CqlInterval<CqlDate>> h_ = context.Operators.Where<CqlInterval<CqlDate>>(intervals, g_);
                IEnumerable<CqlInterval<CqlDate>> i_ = context.Operators.Collapse(h_, "day");
                return i_;
            };
        }

        return a_();
    }


    [CqlFunctionDefinition("Collapse DateTime Interval Workaround")]
    public IEnumerable<CqlInterval<CqlDateTime>> Collapse_DateTime_Interval_Workaround(CqlContext context, IEnumerable<CqlInterval<CqlDateTime>> intervals)
    {

        IEnumerable<CqlInterval<CqlDateTime>> a_() {

            bool b_() {
                int? c_ = context.Operators.Count<CqlInterval<CqlDateTime>>(intervals);
                bool? d_ = context.Operators.Equal(c_, 0);
                return d_ ?? false;
            }

            if (intervals is null)
            {
                CqlInterval<CqlDateTime>[] e_ = [];
                return e_ as IEnumerable<CqlInterval<CqlDateTime>>;
            }
            else if (b_())
            {
                CqlInterval<CqlDateTime>[] f_ = [];
                return f_ as IEnumerable<CqlInterval<CqlDateTime>>;
            }
            else
            {

                bool? g_(CqlInterval<CqlDateTime> I) {

                    bool? j_(CqlInterval<CqlDateTime> J) {
                        bool? o_ = context.Operators.IntervalProperlyIncludesInterval<CqlDateTime>(J, I, (string)default);
                        return o_;
                    }

                    IEnumerable<bool?> k_ = context.Operators.Select<CqlInterval<CqlDateTime>, bool?>(intervals, j_);
                    IEnumerable<bool?> l_ = context.Operators.Distinct<bool?>(k_);
                    bool? m_ = context.Operators.AnyTrue(l_);
                    bool? n_ = context.Operators.Not(m_);
                    return n_;
                }

                IEnumerable<CqlInterval<CqlDateTime>> h_ = context.Operators.Where<CqlInterval<CqlDateTime>>(intervals, g_);
                IEnumerable<CqlInterval<CqlDateTime>> i_ = context.Operators.Collapse(h_, (string)default);
                return i_;
            };
        }

        return a_();
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

            IEnumerable<CqlInterval<CqlDate>> h_() {

                bool p_() {
                    IEnumerable<CqlInterval<CqlDate>> q_ = variableDeclarations?.sortedCoverings;
                    int? r_ = context.Operators.Count<CqlInterval<CqlDate>>(q_);
                    bool? s_ = context.Operators.Equal(r_, 0);
                    return s_ ?? false;
                }

                if (p_())
                {
                    CqlInterval<CqlDate>[] t_ = [
                        baseInterval,
                    ];
                    return (IEnumerable<CqlInterval<CqlDate>>)t_;
                }
                else
                {
                    IEnumerable<CqlInterval<CqlDate>> u_ = variableDeclarations?.sortedCoverings;

                    CqlInterval<CqlDate> v_(CqlInterval<CqlDate> sortedCovering) {

                        CqlInterval<CqlDate> y_() {

                            bool z_() {
                                IEnumerable<CqlInterval<CqlDate>> aa_ = variableDeclarations?.sortedCoverings;
                                int? ab_ = context.Operators.IndexOf<CqlInterval<CqlDate>>(aa_, sortedCovering);
                                bool? ac_ = context.Operators.Equal(ab_, 0);
                                return ac_ ?? false;
                            }

                            if (z_())
                            {
                                CqlDate ad_ = context.Operators.Start(baseInterval);
                                CqlDate ae_ = context.Operators.Start(sortedCovering);
                                CqlInterval<CqlDate> af_ = context.Operators.Interval(ad_, ae_, true, true);
                                CqlInterval<CqlDate> ag_ = context.Operators.Intersect<CqlDate>(af_, baseInterval);
                                CqlInterval<CqlDate> ah_ = context.Operators.Except(ag_, sortedCovering);
                                return ah_;
                            }
                            else
                            {
                                IEnumerable<CqlInterval<CqlDate>> ai_ = variableDeclarations?.sortedCoverings;
                                int? ak_ = context.Operators.IndexOf<CqlInterval<CqlDate>>(ai_, sortedCovering);
                                int? al_ = context.Operators.Subtract(ak_, 1);
                                CqlInterval<CqlDate> am_ = context.Operators.Indexer<CqlInterval<CqlDate>>(ai_, al_);
                                CqlDate an_ = context.Operators.Start(am_);
                                CqlDate ao_ = context.Operators.End(sortedCovering);
                                CqlInterval<CqlDate> ap_ = context.Operators.Interval(an_, ao_, false, false);
                                int? as_ = context.Operators.IndexOf<CqlInterval<CqlDate>>(ai_, sortedCovering);
                                int? at_ = context.Operators.Subtract(as_, 1);
                                CqlInterval<CqlDate> au_ = context.Operators.Indexer<CqlInterval<CqlDate>>(ai_, at_);
                                CqlInterval<CqlDate> av_ = context.Operators.Except(ap_, au_);
                                CqlInterval<CqlDate> aw_ = context.Operators.Except(av_, sortedCovering);
                                return aw_;
                            };
                        }

                        return y_();
                    }

                    IEnumerable<CqlInterval<CqlDate>> w_ = context.Operators.Select<CqlInterval<CqlDate>, CqlInterval<CqlDate>>(u_, v_);
                    IEnumerable<CqlInterval<CqlDate>> x_ = context.Operators.Distinct<CqlInterval<CqlDate>>(w_);
                    return x_;
                };
            }


            IEnumerable<CqlInterval<CqlDate>> i_() {

                bool ax_() {
                    IEnumerable<CqlInterval<CqlDate>> ay_ = variableDeclarations?.sortedCoverings;
                    int? az_ = context.Operators.Count<CqlInterval<CqlDate>>(ay_);
                    bool? ba_ = context.Operators.Equal(az_, 0);
                    return ba_ ?? false;
                }

                if (ax_())
                {
                    CqlInterval<CqlDate>[] bb_ = [];
                    return bb_ as IEnumerable<CqlInterval<CqlDate>>;
                }
                else
                {
                    IEnumerable<CqlInterval<CqlDate>> bc_ = variableDeclarations?.sortedCoverings;
                    CqlInterval<CqlDate> bd_ = context.Operators.Last<CqlInterval<CqlDate>>(bc_);
                    CqlDate be_ = context.Operators.Start(bd_);
                    CqlDate bf_ = context.Operators.End(baseInterval);
                    CqlInterval<CqlDate> bg_ = context.Operators.Interval(be_, bf_, false, true);
                    CqlInterval<CqlDate> bi_ = context.Operators.Last<CqlInterval<CqlDate>>(bc_);
                    CqlInterval<CqlDate> bj_ = context.Operators.Except(bg_, bi_);
                    CqlInterval<CqlDate> bk_ = context.Operators.Intersect<CqlDate>(bj_, baseInterval);
                    CqlInterval<CqlDate>[] bl_ = [
                        bk_,
                    ];
                    return (IEnumerable<CqlInterval<CqlDate>>)bl_;
                };
            }

            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> frontgaps, IEnumerable<CqlInterval<CqlDate>> endgap)? j_ = (CqlTupleMetadata_FKcLSALRMRfDigEFaJgDOPFRK, h_(), i_());
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> frontgaps, IEnumerable<CqlInterval<CqlDate>> endgap)?[] k_ = [
                j_,
            ];

            IEnumerable<CqlInterval<CqlDate>> l_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> frontgaps, IEnumerable<CqlInterval<CqlDate>> endgap)? calculations) {
                IEnumerable<CqlInterval<CqlDate>> bm_ = calculations?.frontgaps;
                IEnumerable<CqlInterval<CqlDate>> bn_ = calculations?.endgap;
                IEnumerable<CqlInterval<CqlDate>> bo_ = context.Operators.Union<CqlInterval<CqlDate>>(bm_, bn_);
                IEnumerable<CqlInterval<CqlDate>> bp_ = this.Collapse_Date_Interval_Workaround(context, bo_);
                return bp_;
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

            IEnumerable<CqlInterval<CqlDateTime>> h_() {

                bool p_() {
                    IEnumerable<CqlInterval<CqlDateTime>> q_ = variableDeclarations?.sortedCoverings;
                    int? r_ = context.Operators.Count<CqlInterval<CqlDateTime>>(q_);
                    bool? s_ = context.Operators.Equal(r_, 0);
                    return s_ ?? false;
                }

                if (p_())
                {
                    CqlInterval<CqlDateTime>[] t_ = [
                        baseInterval,
                    ];
                    return (IEnumerable<CqlInterval<CqlDateTime>>)t_;
                }
                else
                {
                    IEnumerable<CqlInterval<CqlDateTime>> u_ = variableDeclarations?.sortedCoverings;

                    CqlInterval<CqlDateTime> v_(CqlInterval<CqlDateTime> sortedCovering) {

                        CqlInterval<CqlDateTime> y_() {

                            bool z_() {
                                IEnumerable<CqlInterval<CqlDateTime>> aa_ = variableDeclarations?.sortedCoverings;
                                int? ab_ = context.Operators.IndexOf<CqlInterval<CqlDateTime>>(aa_, sortedCovering);
                                bool? ac_ = context.Operators.Equal(ab_, 0);
                                return ac_ ?? false;
                            }

                            if (z_())
                            {
                                CqlDateTime ad_ = context.Operators.Start(baseInterval);
                                CqlDateTime ae_ = context.Operators.Start(sortedCovering);
                                CqlInterval<CqlDateTime> af_ = context.Operators.Interval(ad_, ae_, true, true);
                                CqlInterval<CqlDateTime> ag_ = context.Operators.Intersect<CqlDateTime>(af_, baseInterval);
                                CqlInterval<CqlDateTime> ah_ = context.Operators.Except(ag_, sortedCovering);
                                return ah_;
                            }
                            else
                            {
                                IEnumerable<CqlInterval<CqlDateTime>> ai_ = variableDeclarations?.sortedCoverings;
                                int? ak_ = context.Operators.IndexOf<CqlInterval<CqlDateTime>>(ai_, sortedCovering);
                                int? al_ = context.Operators.Subtract(ak_, 1);
                                CqlInterval<CqlDateTime> am_ = context.Operators.Indexer<CqlInterval<CqlDateTime>>(ai_, al_);
                                CqlDateTime an_ = context.Operators.Start(am_);
                                CqlDateTime ao_ = context.Operators.End(sortedCovering);
                                CqlInterval<CqlDateTime> ap_ = context.Operators.Interval(an_, ao_, false, false);
                                int? as_ = context.Operators.IndexOf<CqlInterval<CqlDateTime>>(ai_, sortedCovering);
                                int? at_ = context.Operators.Subtract(as_, 1);
                                CqlInterval<CqlDateTime> au_ = context.Operators.Indexer<CqlInterval<CqlDateTime>>(ai_, at_);
                                CqlInterval<CqlDateTime> av_ = context.Operators.Except(ap_, au_);
                                CqlInterval<CqlDateTime> aw_ = context.Operators.Except(av_, sortedCovering);
                                return aw_;
                            };
                        }

                        return y_();
                    }

                    IEnumerable<CqlInterval<CqlDateTime>> w_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(u_, v_);
                    IEnumerable<CqlInterval<CqlDateTime>> x_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(w_);
                    return x_;
                };
            }


            IEnumerable<CqlInterval<CqlDateTime>> i_() {

                bool ax_() {
                    IEnumerable<CqlInterval<CqlDateTime>> ay_ = variableDeclarations?.sortedCoverings;
                    int? az_ = context.Operators.Count<CqlInterval<CqlDateTime>>(ay_);
                    bool? ba_ = context.Operators.Equal(az_, 0);
                    return ba_ ?? false;
                }

                if (ax_())
                {
                    CqlInterval<CqlDateTime>[] bb_ = [];
                    return bb_ as IEnumerable<CqlInterval<CqlDateTime>>;
                }
                else
                {
                    IEnumerable<CqlInterval<CqlDateTime>> bc_ = variableDeclarations?.sortedCoverings;
                    CqlInterval<CqlDateTime> bd_ = context.Operators.Last<CqlInterval<CqlDateTime>>(bc_);
                    CqlDateTime be_ = context.Operators.Start(bd_);
                    CqlDateTime bf_ = context.Operators.End(baseInterval);
                    CqlInterval<CqlDateTime> bg_ = context.Operators.Interval(be_, bf_, false, true);
                    CqlInterval<CqlDateTime> bi_ = context.Operators.Last<CqlInterval<CqlDateTime>>(bc_);
                    CqlInterval<CqlDateTime> bj_ = context.Operators.Except(bg_, bi_);
                    CqlInterval<CqlDateTime> bk_ = context.Operators.Intersect<CqlDateTime>(bj_, baseInterval);
                    CqlInterval<CqlDateTime>[] bl_ = [
                        bk_,
                    ];
                    return (IEnumerable<CqlInterval<CqlDateTime>>)bl_;
                };
            }

            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> frontgaps, IEnumerable<CqlInterval<CqlDateTime>> endgap)? j_ = (CqlTupleMetadata_BBLSSiNBQBGUDJaVjMDZMSAXg, h_(), i_());
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> frontgaps, IEnumerable<CqlInterval<CqlDateTime>> endgap)?[] k_ = [
                j_,
            ];

            IEnumerable<CqlInterval<CqlDateTime>> l_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> frontgaps, IEnumerable<CqlInterval<CqlDateTime>> endgap)? calculations) {
                IEnumerable<CqlInterval<CqlDateTime>> bm_ = calculations?.frontgaps;
                IEnumerable<CqlInterval<CqlDateTime>> bn_ = calculations?.endgap;
                IEnumerable<CqlInterval<CqlDateTime>> bo_ = context.Operators.Union<CqlInterval<CqlDateTime>>(bm_, bn_);
                IEnumerable<CqlInterval<CqlDateTime>> bp_ = this.Collapse_DateTime_Interval_Workaround(context, bo_);
                return bp_;
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

        int? b_() {

            bool f_() {
                int? g_ = context.Operators.Count<CqlInterval<CqlDate>>(collapsedIntervals);
                bool? h_ = context.Operators.Equal(g_, 0);
                return h_ ?? false;
            }

            if (f_())
            {
                return 0;
            }
            else
            {

                int? i_(CqlInterval<CqlDate> I) {
                    CqlDate m_ = context.Operators.Start(I);
                    CqlDate n_ = context.Operators.End(I);
                    int? o_ = context.Operators.DurationBetween(m_, n_, "day");
                    int? p_ = context.Operators.Add(o_, 1);
                    int?[] q_ = [
                        p_,
                        0,
                    ];
                    int? r_ = context.Operators.Max<int?>((IEnumerable<int?>)q_);
                    return r_;
                }

                IEnumerable<int?> j_ = context.Operators.Select<CqlInterval<CqlDate>, int?>(collapsedIntervals, i_);
                IEnumerable<int?> k_ = context.Operators.Distinct<int?>(j_);
                int? l_ = context.Operators.Sum(k_);
                return l_;
            };
        }


        CqlInterval<CqlDate> c_() {

            bool s_() {
                int? t_ = context.Operators.Count<CqlInterval<CqlDate>>(collapsedIntervals);
                bool? u_ = context.Operators.Equal(t_, 0);
                return u_ ?? false;
            }

            if (s_())
            {
                return null as CqlInterval<CqlDate>;
            }
            else
            {

                (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? v_(CqlInterval<CqlDate> I) {
                    CqlDate ac_ = context.Operators.Start(I);
                    CqlDate ad_ = context.Operators.End(I);
                    int? ae_ = context.Operators.DurationBetween(ac_, ad_, "day");
                    int? af_ = context.Operators.Add(ae_, 1);
                    int?[] ag_ = [
                        af_,
                        0,
                    ];
                    int? ah_ = context.Operators.Max<int?>((IEnumerable<int?>)ag_);
                    (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? ai_ = (CqlTupleMetadata_HEjPGjPEhLgQPGjROeWMgiGfC, I, ah_);
                    return ai_;
                }

                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> w_ = context.Operators.Select<CqlInterval<CqlDate>, (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(collapsedIntervals, v_);
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> x_ = context.Operators.Distinct<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(w_);

                object y_((CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? @this) {
                    int? aj_ = @this?.days;
                    return aj_;
                }

                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> z_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(x_, y_, System.ComponentModel.ListSortDirection.Descending);
                (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? aa_ = context.Operators.First<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(z_);
                CqlInterval<CqlDate> ab_ = aa_?.interval;
                return ab_;
            };
        }


        int? d_() {

            bool ak_() {
                int? al_ = context.Operators.Count<CqlInterval<CqlDate>>(collapsedIntervals);
                bool? am_ = context.Operators.Equal(al_, 0);
                return am_ ?? false;
            }

            if (ak_())
            {
                return 0;
            }
            else
            {

                (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? an_(CqlInterval<CqlDate> I) {
                    CqlDate bh_ = context.Operators.Start(I);
                    CqlDate bi_ = context.Operators.End(I);
                    int? bj_ = context.Operators.DurationBetween(bh_, bi_, "day");
                    int? bk_ = context.Operators.Add(bj_, 1);
                    int?[] bl_ = [
                        bk_,
                        0,
                    ];
                    int? bm_ = context.Operators.Max<int?>((IEnumerable<int?>)bl_);
                    (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? bn_ = (CqlTupleMetadata_HEjPGjPEhLgQPGjROeWMgiGfC, I, bm_);
                    return bn_;
                }

                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> ao_ = context.Operators.Select<CqlInterval<CqlDate>, (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(collapsedIntervals, an_);
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> ap_ = context.Operators.Distinct<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(ao_);

                object aq_((CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? @this) {
                    int? bo_ = @this?.days;
                    return bo_;
                }

                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> ar_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(ap_, aq_, System.ComponentModel.ListSortDirection.Descending);
                (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? as_ = context.Operators.First<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(ar_);
                CqlInterval<CqlDate> at_ = as_?.interval;
                CqlDate au_ = context.Operators.Start(at_);

                (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? av_(CqlInterval<CqlDate> I) {
                    CqlDate bp_ = context.Operators.Start(I);
                    CqlDate bq_ = context.Operators.End(I);
                    int? br_ = context.Operators.DurationBetween(bp_, bq_, "day");
                    int? bs_ = context.Operators.Add(br_, 1);
                    int?[] bt_ = [
                        bs_,
                        0,
                    ];
                    int? bu_ = context.Operators.Max<int?>((IEnumerable<int?>)bt_);
                    (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? bv_ = (CqlTupleMetadata_HEjPGjPEhLgQPGjROeWMgiGfC, I, bu_);
                    return bv_;
                }

                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> aw_ = context.Operators.Select<CqlInterval<CqlDate>, (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(collapsedIntervals, av_);
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> ax_ = context.Operators.Distinct<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(aw_);

                object ay_((CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? @this) {
                    int? bw_ = @this?.days;
                    return bw_;
                }

                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> az_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(ax_, ay_, System.ComponentModel.ListSortDirection.Descending);
                (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? ba_ = context.Operators.First<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(az_);
                CqlInterval<CqlDate> bb_ = ba_?.interval;
                CqlDate bc_ = context.Operators.End(bb_);
                int? bd_ = context.Operators.DurationBetween(au_, bc_, "day");
                int? be_ = context.Operators.Add(bd_, 1);
                int?[] bf_ = [
                    be_,
                    0,
                ];
                int? bg_ = context.Operators.Max<int?>((IEnumerable<int?>)bf_);
                return bg_;
            };
        }

        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? e_ = (CqlTupleMetadata_HRbPDRZiOGGBceePOZWjVbXdP, collapsedIntervals, a_, b_(), c_(), d_());
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

        int? c_() {

            bool w_() {
                CqlDateTime x_ = context.Operators.Start(interval);
                int? y_ = context.Operators.DateTimeComponentFrom(x_, "month");
                return y_ is null;
            }

            if (w_())
            {
                return 0;
            }
            else
            {
                CqlDateTime z_ = context.Operators.Start(interval);
                int? aa_ = context.Operators.DateTimeComponentFrom(z_, "month");
                return aa_;
            };
        }


        int? d_() {

            bool ab_() {
                CqlDateTime ac_ = context.Operators.Start(interval);
                int? ad_ = context.Operators.DateTimeComponentFrom(ac_, "day");
                return ad_ is null;
            }

            if (ab_())
            {
                return 0;
            }
            else
            {
                CqlDateTime ae_ = context.Operators.Start(interval);
                int? af_ = context.Operators.DateTimeComponentFrom(ae_, "day");
                return af_;
            };
        }


        int? e_() {

            bool ag_() {
                CqlDateTime ah_ = context.Operators.Start(interval);
                int? ai_ = context.Operators.DateTimeComponentFrom(ah_, "hour");
                return ai_ is null;
            }

            if (ag_())
            {
                return 0;
            }
            else
            {
                CqlDateTime aj_ = context.Operators.Start(interval);
                int? ak_ = context.Operators.DateTimeComponentFrom(aj_, "hour");
                return ak_;
            };
        }


        int? f_() {

            bool al_() {
                CqlDateTime am_ = context.Operators.Start(interval);
                int? an_ = context.Operators.DateTimeComponentFrom(am_, "minute");
                return an_ is null;
            }

            if (al_())
            {
                return 0;
            }
            else
            {
                CqlDateTime ao_ = context.Operators.Start(interval);
                int? ap_ = context.Operators.DateTimeComponentFrom(ao_, "minute");
                return ap_;
            };
        }


        int? g_() {

            bool aq_() {
                CqlDateTime ar_ = context.Operators.Start(interval);
                int? as_ = context.Operators.DateTimeComponentFrom(ar_, "second");
                return as_ is null;
            }

            if (aq_())
            {
                return 0;
            }
            else
            {
                CqlDateTime at_ = context.Operators.Start(interval);
                int? au_ = context.Operators.DateTimeComponentFrom(at_, "second");
                return au_;
            };
        }


        int? h_() {

            bool av_() {
                CqlDateTime aw_ = context.Operators.Start(interval);
                int? ax_ = context.Operators.DateTimeComponentFrom(aw_, "millisecond");
                return ax_ is null;
            }

            if (av_())
            {
                return 0;
            }
            else
            {
                CqlDateTime ay_ = context.Operators.Start(interval);
                int? az_ = context.Operators.DateTimeComponentFrom(ay_, "millisecond");
                return az_;
            };
        }

        CqlDateTime i_ = context.Operators.End(interval);
        int? j_ = context.Operators.DateTimeComponentFrom(i_, "year");

        int? k_() {

            bool ba_() {
                CqlDateTime bb_ = context.Operators.End(interval);
                int? bc_ = context.Operators.DateTimeComponentFrom(bb_, "month");
                return bc_ is null;
            }

            if (ba_())
            {
                return 0;
            }
            else
            {
                CqlDateTime bd_ = context.Operators.End(interval);
                int? be_ = context.Operators.DateTimeComponentFrom(bd_, "month");
                return be_;
            };
        }


        int? l_() {

            bool bf_() {
                CqlDateTime bg_ = context.Operators.End(interval);
                int? bh_ = context.Operators.DateTimeComponentFrom(bg_, "day");
                return bh_ is null;
            }

            if (bf_())
            {
                return 0;
            }
            else
            {
                CqlDateTime bi_ = context.Operators.End(interval);
                int? bj_ = context.Operators.DateTimeComponentFrom(bi_, "day");
                return bj_;
            };
        }


        int? m_() {

            bool bk_() {
                CqlDateTime bl_ = context.Operators.End(interval);
                int? bm_ = context.Operators.DateTimeComponentFrom(bl_, "hour");
                return bm_ is null;
            }

            if (bk_())
            {
                return 0;
            }
            else
            {
                CqlDateTime bn_ = context.Operators.End(interval);
                int? bo_ = context.Operators.DateTimeComponentFrom(bn_, "hour");
                return bo_;
            };
        }


        int? n_() {

            bool bp_() {
                CqlDateTime bq_ = context.Operators.End(interval);
                int? br_ = context.Operators.DateTimeComponentFrom(bq_, "minute");
                return br_ is null;
            }

            if (bp_())
            {
                return 0;
            }
            else
            {
                CqlDateTime bs_ = context.Operators.End(interval);
                int? bt_ = context.Operators.DateTimeComponentFrom(bs_, "minute");
                return bt_;
            };
        }


        int? o_() {

            bool bu_() {
                CqlDateTime bv_ = context.Operators.End(interval);
                int? bw_ = context.Operators.DateTimeComponentFrom(bv_, "second");
                return bw_ is null;
            }

            if (bu_())
            {
                return 0;
            }
            else
            {
                CqlDateTime bx_ = context.Operators.End(interval);
                int? by_ = context.Operators.DateTimeComponentFrom(bx_, "second");
                return by_;
            };
        }


        int? p_() {

            bool bz_() {
                CqlDateTime ca_ = context.Operators.End(interval);
                int? cb_ = context.Operators.DateTimeComponentFrom(ca_, "millisecond");
                return cb_ is null;
            }

            if (bz_())
            {
                return 0;
            }
            else
            {
                CqlDateTime cc_ = context.Operators.End(interval);
                int? cd_ = context.Operators.DateTimeComponentFrom(cc_, "millisecond");
                return cd_;
            };
        }

        (CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)? q_ = (CqlTupleMetadata_FcQREFSfPJSKYAhSEWVJcZVED, b_, c_(), d_(), e_(), f_(), g_(), h_(), j_, k_(), l_(), m_(), n_(), o_(), p_());
        (CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)?[] r_ = [
            q_,
        ];

        CqlInterval<CqlDateTime> s_((CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)? i) {
            int? ce_ = i?.StartYear;
            int? cf_ = i?.StartMonth;
            int? cg_ = i?.StartDay;
            int? ch_ = i?.StartHour;
            int? ci_ = i?.StartMinute;
            int? cj_ = i?.StartSecond;
            int? ck_ = i?.StartMillisecond;
            CqlDateTime cl_ = context.Operators.DateTime(ce_, cf_, cg_, ch_, ci_, cj_, ck_, (decimal?)default);
            int? cm_ = i?.EndYear;
            int? cn_ = i?.EndMonth;
            int? co_ = i?.EndDay;
            int? cp_ = i?.EndHour;
            int? cq_ = i?.EndMinute;
            int? cr_ = i?.EndSecond;
            int? cs_ = i?.EndMillisecond;
            CqlDateTime ct_ = context.Operators.DateTime(cm_, cn_, co_, cp_, cq_, cr_, cs_, (decimal?)default);
            CqlInterval<CqlDateTime> cu_ = context.Operators.Interval(cl_, ct_, true, true);
            return cu_;
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

        int? b_() {

            bool f_() {
                int? g_ = context.Operators.Count<CqlInterval<CqlDateTime>>(collapsedIntervals);
                bool? h_ = context.Operators.Equal(g_, 0);
                return h_ ?? false;
            }

            if (f_())
            {
                return 0;
            }
            else
            {

                int? i_(CqlInterval<CqlDateTime> I) {
                    CqlInterval<CqlDateTime> m_ = this.DateTime_Interval_Set_Nulls_to_Zero(context, I);
                    CqlDateTime n_ = context.Operators.Start(m_);
                    CqlDateTime p_ = context.Operators.End(m_);
                    int? q_ = context.Operators.DurationBetween(n_, p_, "day");
                    int? r_ = context.Operators.Add(q_, 1);
                    int?[] s_ = [
                        r_,
                        0,
                    ];
                    int? t_ = context.Operators.Max<int?>((IEnumerable<int?>)s_);
                    return t_;
                }

                IEnumerable<int?> j_ = context.Operators.Select<CqlInterval<CqlDateTime>, int?>(collapsedIntervals, i_);
                IEnumerable<int?> k_ = context.Operators.Distinct<int?>(j_);
                int? l_ = context.Operators.Sum(k_);
                return l_;
            };
        }


        CqlInterval<CqlDateTime> c_() {

            bool u_() {
                int? v_ = context.Operators.Count<CqlInterval<CqlDateTime>>(collapsedIntervals);
                bool? w_ = context.Operators.Equal(v_, 0);
                return w_ ?? false;
            }

            if (u_())
            {
                return null as CqlInterval<CqlDateTime>;
            }
            else
            {

                (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? x_(CqlInterval<CqlDateTime> I) {
                    CqlInterval<CqlDateTime> ae_ = this.DateTime_Interval_Set_Nulls_to_Zero(context, I);
                    CqlDateTime af_ = context.Operators.Start(ae_);
                    CqlDateTime ah_ = context.Operators.End(ae_);
                    int? ai_ = context.Operators.DurationBetween(af_, ah_, "day");
                    int? aj_ = context.Operators.Add(ai_, 1);
                    int?[] ak_ = [
                        aj_,
                        0,
                    ];
                    int? al_ = context.Operators.Max<int?>((IEnumerable<int?>)ak_);
                    (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? am_ = (CqlTupleMetadata_CGHEUIgjaCjJVKEADTSZEbdCL, I, al_);
                    return am_;
                }

                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> y_ = context.Operators.Select<CqlInterval<CqlDateTime>, (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(collapsedIntervals, x_);
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> z_ = context.Operators.Distinct<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(y_);

                object aa_((CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? @this) {
                    int? an_ = @this?.days;
                    return an_;
                }

                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> ab_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(z_, aa_, System.ComponentModel.ListSortDirection.Descending);
                (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? ac_ = context.Operators.First<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(ab_);
                CqlInterval<CqlDateTime> ad_ = ac_?.interval;
                return ad_;
            };
        }


        int? d_() {

            bool ao_() {
                int? ap_ = context.Operators.Count<CqlInterval<CqlDateTime>>(collapsedIntervals);
                bool? aq_ = context.Operators.Equal(ap_, 0);
                return aq_ ?? false;
            }

            if (ao_())
            {
                return 0;
            }
            else
            {

                (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? ar_(CqlInterval<CqlDateTime> I) {
                    CqlInterval<CqlDateTime> bn_ = this.DateTime_Interval_Set_Nulls_to_Zero(context, I);
                    CqlDateTime bo_ = context.Operators.Start(bn_);
                    CqlDateTime bq_ = context.Operators.End(bn_);
                    int? br_ = context.Operators.DurationBetween(bo_, bq_, "day");
                    int? bs_ = context.Operators.Add(br_, 1);
                    int?[] bt_ = [
                        bs_,
                        0,
                    ];
                    int? bu_ = context.Operators.Max<int?>((IEnumerable<int?>)bt_);
                    (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? bv_ = (CqlTupleMetadata_CGHEUIgjaCjJVKEADTSZEbdCL, I, bu_);
                    return bv_;
                }

                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> as_ = context.Operators.Select<CqlInterval<CqlDateTime>, (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(collapsedIntervals, ar_);
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> at_ = context.Operators.Distinct<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(as_);

                object au_((CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? @this) {
                    int? bw_ = @this?.days;
                    return bw_;
                }

                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> av_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(at_, au_, System.ComponentModel.ListSortDirection.Descending);
                (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? aw_ = context.Operators.First<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(av_);
                CqlInterval<CqlDateTime> ax_ = aw_?.interval;
                CqlInterval<CqlDateTime> ay_ = this.DateTime_Interval_Set_Nulls_to_Zero(context, ax_);
                CqlDateTime az_ = context.Operators.Start(ay_);

                (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? ba_(CqlInterval<CqlDateTime> I) {
                    CqlInterval<CqlDateTime> bx_ = this.DateTime_Interval_Set_Nulls_to_Zero(context, I);
                    CqlDateTime by_ = context.Operators.Start(bx_);
                    CqlDateTime ca_ = context.Operators.End(bx_);
                    int? cb_ = context.Operators.DurationBetween(by_, ca_, "day");
                    int? cc_ = context.Operators.Add(cb_, 1);
                    int?[] cd_ = [
                        cc_,
                        0,
                    ];
                    int? ce_ = context.Operators.Max<int?>((IEnumerable<int?>)cd_);
                    (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? cf_ = (CqlTupleMetadata_CGHEUIgjaCjJVKEADTSZEbdCL, I, ce_);
                    return cf_;
                }

                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> bb_ = context.Operators.Select<CqlInterval<CqlDateTime>, (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(collapsedIntervals, ba_);
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> bc_ = context.Operators.Distinct<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(bb_);

                object bd_((CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? @this) {
                    int? cg_ = @this?.days;
                    return cg_;
                }

                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> be_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(bc_, bd_, System.ComponentModel.ListSortDirection.Descending);
                (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? bf_ = context.Operators.First<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(be_);
                CqlInterval<CqlDateTime> bg_ = bf_?.interval;
                CqlInterval<CqlDateTime> bh_ = this.DateTime_Interval_Set_Nulls_to_Zero(context, bg_);
                CqlDateTime bi_ = context.Operators.End(bh_);
                int? bj_ = context.Operators.DurationBetween(az_, bi_, "day");
                int? bk_ = context.Operators.Add(bj_, 1);
                int?[] bl_ = [
                    bk_,
                    0,
                ];
                int? bm_ = context.Operators.Max<int?>((IEnumerable<int?>)bl_);
                return bm_;
            };
        }

        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? e_ = (CqlTupleMetadata_HDihbLieYfQbgeSbOWZBAMUIQ, collapsedIntervals, a_, b_(), c_(), d_());
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

        int? b_() {
            if ((context.Operators.DateTimeComponentFrom(d, "month")) is null)
            {
                return 0;
            }
            else
            {
                int? j_ = context.Operators.DateTimeComponentFrom(d, "month");
                return j_;
            };
        }


        int? c_() {
            if ((context.Operators.DateTimeComponentFrom(d, "day")) is null)
            {
                return 0;
            }
            else
            {
                int? k_ = context.Operators.DateTimeComponentFrom(d, "day");
                return k_;
            };
        }

        (CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay)? d_ = (CqlTupleMetadata_BgJFbOiFcaejXZjQOBFLJLhjg, a_, b_(), c_());
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
