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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.1.0.0")]
[CqlLibrary("NCQACQLBase", "1.0.0")]
public partial class NCQACQLBase_1_0_0 : ILibrary, ISingleton<NCQACQLBase_1_0_0>
{
    private NCQACQLBase_1_0_0() {}

    public static NCQACQLBase_1_0_0 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "NCQACQLBase";
    public string Version => "1.0.0";
    public ILibrary[] Dependencies => [];

    #endregion ILibrary Implementation

    #region Definition Methods

    public IEnumerable<CqlInterval<CqlDate>> Sort_Date_Intervals(CqlContext context, IEnumerable<CqlInterval<CqlDate>> intervals)
    {
        IEnumerable<CqlInterval<CqlDate>> a_()
        {
            bool b_()
            {
                int? c_ = context.Operators.Count<CqlInterval<CqlDate>>(intervals);
                bool? d_ = context.Operators.Equal(c_, 0);

                return d_ ?? false;
            };
            if ((intervals as object) is null)
            {
                CqlInterval<CqlDate>[] e_ = []
;

                return e_ as IEnumerable<CqlInterval<CqlDate>>;
            }
            else if (b_())
            {
                CqlInterval<CqlDate>[] f_ = []
;

                return f_ as IEnumerable<CqlInterval<CqlDate>>;
            }
            else
            {
                (CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)? g_(CqlInterval<CqlDate> I)
                {
                    CqlDate o_()
                    {
                        if (((context.Operators.Start(I)) as object) is null)
                        {
                            CqlDate q_ = context.Operators.MinValue<CqlDate>();

                            return q_;
                        }
                        else
                        {
                            CqlDate r_ = context.Operators.Start(I);

                            return r_;
                        }
                    };
                    (CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)? p_ = (CqlTupleMetadata_GIMHfXDcFiAjSJBDGYeUeZLhW, I, o_());

                    return p_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)?> h_ = context.Operators.Select<CqlInterval<CqlDate>, (CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)?>(intervals, g_);
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)?> i_ = context.Operators.Distinct<(CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)?>(h_);
                object j_((CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)? @this)
                {
                    CqlDate s_ = @this?.startOfInterval;

                    return s_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)?> k_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)?>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
                CqlInterval<CqlDate> l_((CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)? sortedIntervals)
                {
                    CqlInterval<CqlDate> t_ = sortedIntervals?.interval;

                    return t_;
                };
                IEnumerable<CqlInterval<CqlDate>> m_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)?, CqlInterval<CqlDate>>(k_, l_);
                IEnumerable<CqlInterval<CqlDate>> n_ = context.Operators.Distinct<CqlInterval<CqlDate>>(m_);

                return n_;
            }
        };

        return a_();
    }


    public IEnumerable<CqlInterval<CqlDateTime>> Sort_DateTime_Intervals(CqlContext context, IEnumerable<CqlInterval<CqlDateTime>> intervals)
    {
        IEnumerable<CqlInterval<CqlDateTime>> a_()
        {
            bool b_()
            {
                int? c_ = context.Operators.Count<CqlInterval<CqlDateTime>>(intervals);
                bool? d_ = context.Operators.Equal(c_, 0);

                return d_ ?? false;
            };
            if ((intervals as object) is null)
            {
                CqlInterval<CqlDateTime>[] e_ = []
;

                return e_ as IEnumerable<CqlInterval<CqlDateTime>>;
            }
            else if (b_())
            {
                CqlInterval<CqlDateTime>[] f_ = []
;

                return f_ as IEnumerable<CqlInterval<CqlDateTime>>;
            }
            else
            {
                (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)? g_(CqlInterval<CqlDateTime> I)
                {
                    CqlDateTime o_()
                    {
                        if (((context.Operators.Start(I)) as object) is null)
                        {
                            CqlDateTime q_ = context.Operators.MinValue<CqlDateTime>();

                            return q_;
                        }
                        else
                        {
                            CqlDateTime r_ = context.Operators.Start(I);

                            return r_;
                        }
                    };
                    (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)? p_ = (CqlTupleMetadata_EQHOUSiiWahbJPOUjJGEhIAOV, I, o_());

                    return p_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?> h_ = context.Operators.Select<CqlInterval<CqlDateTime>, (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?>(intervals, g_);
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?> i_ = context.Operators.Distinct<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?>(h_);
                object j_((CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)? @this)
                {
                    CqlDateTime s_ = @this?.startOfInterval;

                    return s_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?> k_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
                CqlInterval<CqlDateTime> l_((CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)? sortedIntervals)
                {
                    CqlInterval<CqlDateTime> t_ = sortedIntervals?.interval;

                    return t_;
                };
                IEnumerable<CqlInterval<CqlDateTime>> m_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?, CqlInterval<CqlDateTime>>(k_, l_);
                IEnumerable<CqlInterval<CqlDateTime>> n_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(m_);

                return n_;
            }
        };

        return a_();
    }


    public IEnumerable<CqlInterval<CqlDate>> Collapse_Date_Interval_Workaround(CqlContext context, IEnumerable<CqlInterval<CqlDate>> intervals)
    {
        IEnumerable<CqlInterval<CqlDate>> a_()
        {
            bool b_()
            {
                int? c_ = context.Operators.Count<CqlInterval<CqlDate>>(intervals);
                bool? d_ = context.Operators.Equal(c_, 0);

                return d_ ?? false;
            };
            if ((intervals as object) is null)
            {
                CqlInterval<CqlDate>[] e_ = []
;

                return e_ as IEnumerable<CqlInterval<CqlDate>>;
            }
            else if (b_())
            {
                CqlInterval<CqlDate>[] f_ = []
;

                return f_ as IEnumerable<CqlInterval<CqlDate>>;
            }
            else
            {
                bool? g_(CqlInterval<CqlDate> I)
                {
                    bool? j_(CqlInterval<CqlDate> J)
                    {
                        bool? o_ = context.Operators.IntervalProperlyIncludesInterval<CqlDate>(J, I, default);

                        return o_;
                    };
                    IEnumerable<bool?> k_ = context.Operators.Select<CqlInterval<CqlDate>, bool?>(intervals, j_);
                    IEnumerable<bool?> l_ = context.Operators.Distinct<bool?>(k_);
                    bool? m_ = context.Operators.AnyTrue(l_);
                    bool? n_ = context.Operators.Not(m_);

                    return n_;
                };
                IEnumerable<CqlInterval<CqlDate>> h_ = context.Operators.Where<CqlInterval<CqlDate>>(intervals, g_);
                IEnumerable<CqlInterval<CqlDate>> i_ = context.Operators.Collapse(h_, "day");

                return i_;
            }
        };

        return a_();
    }


    public IEnumerable<CqlInterval<CqlDateTime>> Collapse_DateTime_Interval_Workaround(CqlContext context, IEnumerable<CqlInterval<CqlDateTime>> intervals)
    {
        IEnumerable<CqlInterval<CqlDateTime>> a_()
        {
            bool b_()
            {
                int? c_ = context.Operators.Count<CqlInterval<CqlDateTime>>(intervals);
                bool? d_ = context.Operators.Equal(c_, 0);

                return d_ ?? false;
            };
            if ((intervals as object) is null)
            {
                CqlInterval<CqlDateTime>[] e_ = []
;

                return e_ as IEnumerable<CqlInterval<CqlDateTime>>;
            }
            else if (b_())
            {
                CqlInterval<CqlDateTime>[] f_ = []
;

                return f_ as IEnumerable<CqlInterval<CqlDateTime>>;
            }
            else
            {
                bool? g_(CqlInterval<CqlDateTime> I)
                {
                    bool? j_(CqlInterval<CqlDateTime> J)
                    {
                        bool? o_ = context.Operators.IntervalProperlyIncludesInterval<CqlDateTime>(J, I, default);

                        return o_;
                    };
                    IEnumerable<bool?> k_ = context.Operators.Select<CqlInterval<CqlDateTime>, bool?>(intervals, j_);
                    IEnumerable<bool?> l_ = context.Operators.Distinct<bool?>(k_);
                    bool? m_ = context.Operators.AnyTrue(l_);
                    bool? n_ = context.Operators.Not(m_);

                    return n_;
                };
                IEnumerable<CqlInterval<CqlDateTime>> h_ = context.Operators.Where<CqlInterval<CqlDateTime>>(intervals, g_);
                IEnumerable<CqlInterval<CqlDateTime>> i_ = context.Operators.Collapse(h_, default);

                return i_;
            }
        };

        return a_();
    }


    public IEnumerable<CqlInterval<CqlDate>> Date_Interval_Covering_Relative_to_Base_Interval(CqlContext context, CqlInterval<CqlDate> baseInterval, IEnumerable<CqlInterval<CqlDate>> coveringIntervals)
    {
        IEnumerable<CqlInterval<CqlDate>> a_ = this.Sort_Date_Intervals(context, coveringIntervals);
        CqlInterval<CqlDate> b_(CqlInterval<CqlDate> sortedInterval)
        {
            CqlInterval<CqlDate> f_ = context.Operators.Intersect<CqlDate>(baseInterval, sortedInterval);

            return f_;
        };
        IEnumerable<CqlInterval<CqlDate>> c_ = context.Operators.Select<CqlInterval<CqlDate>, CqlInterval<CqlDate>>(a_, b_);
        IEnumerable<CqlInterval<CqlDate>> d_ = context.Operators.Distinct<CqlInterval<CqlDate>>(c_);
        IEnumerable<CqlInterval<CqlDate>> e_ = this.Collapse_Date_Interval_Workaround(context, d_);

        return e_;
    }


    public IEnumerable<CqlInterval<CqlDateTime>> DateTime_Interval_Covering_Relative_to_Base_Interval(CqlContext context, CqlInterval<CqlDateTime> baseInterval, IEnumerable<CqlInterval<CqlDateTime>> coveringIntervals)
    {
        IEnumerable<CqlInterval<CqlDateTime>> a_ = this.Sort_DateTime_Intervals(context, coveringIntervals);
        CqlInterval<CqlDateTime> b_(CqlInterval<CqlDateTime> sortedInterval)
        {
            CqlInterval<CqlDateTime> f_ = context.Operators.Intersect<CqlDateTime>(baseInterval, sortedInterval);

            return f_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(a_, b_);
        IEnumerable<CqlInterval<CqlDateTime>> d_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(c_);
        IEnumerable<CqlInterval<CqlDateTime>> e_ = this.Collapse_DateTime_Interval_Workaround(context, d_);

        return e_;
    }


    public IEnumerable<CqlInterval<CqlDate>> Date_Interval_Gaps_Relative_to_Base_Interval(CqlContext context, CqlInterval<CqlDate> baseInterval, IEnumerable<CqlInterval<CqlDate>> coveringIntervals)
    {
        IEnumerable<CqlInterval<CqlDate>> a_ = this.Date_Interval_Covering_Relative_to_Base_Interval(context, baseInterval, coveringIntervals);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> sortedCoverings)? b_ = (CqlTupleMetadata_EVRLVXPcBiDTIWfCCfKEWDfKI, a_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> sortedCoverings)?[] c_ = [
            b_,
        ];
        IEnumerable<CqlInterval<CqlDate>> d_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> sortedCoverings)? variableDeclarations)
        {
            IEnumerable<CqlInterval<CqlDate>> h_()
            {
                bool p_()
                {
                    IEnumerable<CqlInterval<CqlDate>> q_ = variableDeclarations?.sortedCoverings;
                    int? r_ = context.Operators.Count<CqlInterval<CqlDate>>(q_);
                    bool? s_ = context.Operators.Equal(r_, 0);

                    return s_ ?? false;
                };
                if (p_())
                {
                    CqlInterval<CqlDate>[] t_ = []
;

                    return t_ as IEnumerable<CqlInterval<CqlDate>>;
                }
                else
                {
                    IEnumerable<CqlInterval<CqlDate>> u_ = variableDeclarations?.sortedCoverings;
                    CqlInterval<CqlDate> v_ = context.Operators.Last<CqlInterval<CqlDate>>(u_);
                    CqlDate w_ = context.Operators.Start(v_);
                    CqlDate x_ = context.Operators.End(baseInterval);
                    CqlInterval<CqlDate> y_ = context.Operators.Interval(w_, x_, false, true);
                    CqlInterval<CqlDate> aa_ = context.Operators.Last<CqlInterval<CqlDate>>(u_);
                    CqlInterval<CqlDate> ab_ = context.Operators.Except(y_, aa_);
                    CqlInterval<CqlDate> ac_ = context.Operators.Intersect<CqlDate>(ab_, baseInterval);
                    CqlInterval<CqlDate>[] ad_ = [
                        ac_,
                    ];

                    return ad_ as IEnumerable<CqlInterval<CqlDate>>;
                }
            };
            IEnumerable<CqlInterval<CqlDate>> i_()
            {
                bool ae_()
                {
                    IEnumerable<CqlInterval<CqlDate>> af_ = variableDeclarations?.sortedCoverings;
                    int? ag_ = context.Operators.Count<CqlInterval<CqlDate>>(af_);
                    bool? ah_ = context.Operators.Equal(ag_, 0);

                    return ah_ ?? false;
                };
                if (ae_())
                {
                    CqlInterval<CqlDate>[] ai_ = [
                        baseInterval,
                    ];

                    return ai_ as IEnumerable<CqlInterval<CqlDate>>;
                }
                else
                {
                    IEnumerable<CqlInterval<CqlDate>> aj_ = variableDeclarations?.sortedCoverings;
                    CqlInterval<CqlDate> ak_(CqlInterval<CqlDate> sortedCovering)
                    {
                        CqlInterval<CqlDate> an_()
                        {
                            bool ao_()
                            {
                                IEnumerable<CqlInterval<CqlDate>> ap_ = variableDeclarations?.sortedCoverings;
                                int? aq_ = context.Operators.IndexOf<CqlInterval<CqlDate>>(ap_, sortedCovering);
                                bool? ar_ = context.Operators.Equal(aq_, 0);

                                return ar_ ?? false;
                            };
                            if (ao_())
                            {
                                CqlDate as_ = context.Operators.Start(baseInterval);
                                CqlDate at_ = context.Operators.Start(sortedCovering);
                                CqlInterval<CqlDate> au_ = context.Operators.Interval(as_, at_, true, true);
                                CqlInterval<CqlDate> av_ = context.Operators.Intersect<CqlDate>(au_, baseInterval);
                                CqlInterval<CqlDate> aw_ = context.Operators.Except(av_, sortedCovering);

                                return aw_;
                            }
                            else
                            {
                                IEnumerable<CqlInterval<CqlDate>> ax_ = variableDeclarations?.sortedCoverings;
                                int? az_ = context.Operators.IndexOf<CqlInterval<CqlDate>>(ax_, sortedCovering);
                                int? ba_ = context.Operators.Subtract(az_, 1);
                                CqlInterval<CqlDate> bb_ = context.Operators.Indexer<CqlInterval<CqlDate>>(ax_, ba_);
                                CqlDate bc_ = context.Operators.Start(bb_);
                                CqlDate bd_ = context.Operators.End(sortedCovering);
                                CqlInterval<CqlDate> be_ = context.Operators.Interval(bc_, bd_, false, false);
                                int? bh_ = context.Operators.IndexOf<CqlInterval<CqlDate>>(ax_, sortedCovering);
                                int? bi_ = context.Operators.Subtract(bh_, 1);
                                CqlInterval<CqlDate> bj_ = context.Operators.Indexer<CqlInterval<CqlDate>>(ax_, bi_);
                                CqlInterval<CqlDate> bk_ = context.Operators.Except(be_, bj_);
                                CqlInterval<CqlDate> bl_ = context.Operators.Except(bk_, sortedCovering);

                                return bl_;
                            }
                        };

                        return an_();
                    };
                    IEnumerable<CqlInterval<CqlDate>> al_ = context.Operators.Select<CqlInterval<CqlDate>, CqlInterval<CqlDate>>(aj_, ak_);
                    IEnumerable<CqlInterval<CqlDate>> am_ = context.Operators.Distinct<CqlInterval<CqlDate>>(al_);

                    return am_;
                }
            };
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> endgap, IEnumerable<CqlInterval<CqlDate>> frontgaps)? j_ = (CqlTupleMetadata_DECPbSATOETPaGfFJifhEcWWB, h_(), i_());
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> endgap, IEnumerable<CqlInterval<CqlDate>> frontgaps)?[] k_ = [
                j_,
            ];
            IEnumerable<CqlInterval<CqlDate>> l_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> endgap, IEnumerable<CqlInterval<CqlDate>> frontgaps)? calculations)
            {
                IEnumerable<CqlInterval<CqlDate>> bm_ = calculations?.frontgaps;
                IEnumerable<CqlInterval<CqlDate>> bn_ = calculations?.endgap;
                IEnumerable<CqlInterval<CqlDate>> bo_ = context.Operators.Union<CqlInterval<CqlDate>>(bm_, bn_);
                IEnumerable<CqlInterval<CqlDate>> bp_ = this.Collapse_Date_Interval_Workaround(context, bo_);

                return bp_;
            };
            IEnumerable<IEnumerable<CqlInterval<CqlDate>>> m_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> endgap, IEnumerable<CqlInterval<CqlDate>> frontgaps)?, IEnumerable<CqlInterval<CqlDate>>>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> endgap, IEnumerable<CqlInterval<CqlDate>> frontgaps)?>)k_, l_);
            IEnumerable<IEnumerable<CqlInterval<CqlDate>>> n_ = context.Operators.Distinct<IEnumerable<CqlInterval<CqlDate>>>(m_);
            IEnumerable<CqlInterval<CqlDate>> o_ = context.Operators.SingletonFrom<IEnumerable<CqlInterval<CqlDate>>>(n_);

            return o_;
        };
        IEnumerable<IEnumerable<CqlInterval<CqlDate>>> e_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> sortedCoverings)?, IEnumerable<CqlInterval<CqlDate>>>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> sortedCoverings)?>)c_, d_);
        IEnumerable<IEnumerable<CqlInterval<CqlDate>>> f_ = context.Operators.Distinct<IEnumerable<CqlInterval<CqlDate>>>(e_);
        IEnumerable<CqlInterval<CqlDate>> g_ = context.Operators.SingletonFrom<IEnumerable<CqlInterval<CqlDate>>>(f_);

        return g_;
    }


    public IEnumerable<CqlInterval<CqlDateTime>> DateTime_Interval_Gaps_Relative_to_Base_Interval(CqlContext context, CqlInterval<CqlDateTime> baseInterval, IEnumerable<CqlInterval<CqlDateTime>> coveringIntervals)
    {
        IEnumerable<CqlInterval<CqlDateTime>> a_ = this.DateTime_Interval_Covering_Relative_to_Base_Interval(context, baseInterval, coveringIntervals);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> sortedCoverings)? b_ = (CqlTupleMetadata_EdgSWaTaCbLYLJceGdIcWOLHd, a_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> sortedCoverings)?[] c_ = [
            b_,
        ];
        IEnumerable<CqlInterval<CqlDateTime>> d_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> sortedCoverings)? variableDeclarations)
        {
            IEnumerable<CqlInterval<CqlDateTime>> h_()
            {
                bool p_()
                {
                    IEnumerable<CqlInterval<CqlDateTime>> q_ = variableDeclarations?.sortedCoverings;
                    int? r_ = context.Operators.Count<CqlInterval<CqlDateTime>>(q_);
                    bool? s_ = context.Operators.Equal(r_, 0);

                    return s_ ?? false;
                };
                if (p_())
                {
                    CqlInterval<CqlDateTime>[] t_ = []
;

                    return t_ as IEnumerable<CqlInterval<CqlDateTime>>;
                }
                else
                {
                    IEnumerable<CqlInterval<CqlDateTime>> u_ = variableDeclarations?.sortedCoverings;
                    CqlInterval<CqlDateTime> v_ = context.Operators.Last<CqlInterval<CqlDateTime>>(u_);
                    CqlDateTime w_ = context.Operators.Start(v_);
                    CqlDateTime x_ = context.Operators.End(baseInterval);
                    CqlInterval<CqlDateTime> y_ = context.Operators.Interval(w_, x_, false, true);
                    CqlInterval<CqlDateTime> aa_ = context.Operators.Last<CqlInterval<CqlDateTime>>(u_);
                    CqlInterval<CqlDateTime> ab_ = context.Operators.Except(y_, aa_);
                    CqlInterval<CqlDateTime> ac_ = context.Operators.Intersect<CqlDateTime>(ab_, baseInterval);
                    CqlInterval<CqlDateTime>[] ad_ = [
                        ac_,
                    ];

                    return ad_ as IEnumerable<CqlInterval<CqlDateTime>>;
                }
            };
            IEnumerable<CqlInterval<CqlDateTime>> i_()
            {
                bool ae_()
                {
                    IEnumerable<CqlInterval<CqlDateTime>> af_ = variableDeclarations?.sortedCoverings;
                    int? ag_ = context.Operators.Count<CqlInterval<CqlDateTime>>(af_);
                    bool? ah_ = context.Operators.Equal(ag_, 0);

                    return ah_ ?? false;
                };
                if (ae_())
                {
                    CqlInterval<CqlDateTime>[] ai_ = [
                        baseInterval,
                    ];

                    return ai_ as IEnumerable<CqlInterval<CqlDateTime>>;
                }
                else
                {
                    IEnumerable<CqlInterval<CqlDateTime>> aj_ = variableDeclarations?.sortedCoverings;
                    CqlInterval<CqlDateTime> ak_(CqlInterval<CqlDateTime> sortedCovering)
                    {
                        CqlInterval<CqlDateTime> an_()
                        {
                            bool ao_()
                            {
                                IEnumerable<CqlInterval<CqlDateTime>> ap_ = variableDeclarations?.sortedCoverings;
                                int? aq_ = context.Operators.IndexOf<CqlInterval<CqlDateTime>>(ap_, sortedCovering);
                                bool? ar_ = context.Operators.Equal(aq_, 0);

                                return ar_ ?? false;
                            };
                            if (ao_())
                            {
                                CqlDateTime as_ = context.Operators.Start(baseInterval);
                                CqlDateTime at_ = context.Operators.Start(sortedCovering);
                                CqlInterval<CqlDateTime> au_ = context.Operators.Interval(as_, at_, true, true);
                                CqlInterval<CqlDateTime> av_ = context.Operators.Intersect<CqlDateTime>(au_, baseInterval);
                                CqlInterval<CqlDateTime> aw_ = context.Operators.Except(av_, sortedCovering);

                                return aw_;
                            }
                            else
                            {
                                IEnumerable<CqlInterval<CqlDateTime>> ax_ = variableDeclarations?.sortedCoverings;
                                int? az_ = context.Operators.IndexOf<CqlInterval<CqlDateTime>>(ax_, sortedCovering);
                                int? ba_ = context.Operators.Subtract(az_, 1);
                                CqlInterval<CqlDateTime> bb_ = context.Operators.Indexer<CqlInterval<CqlDateTime>>(ax_, ba_);
                                CqlDateTime bc_ = context.Operators.Start(bb_);
                                CqlDateTime bd_ = context.Operators.End(sortedCovering);
                                CqlInterval<CqlDateTime> be_ = context.Operators.Interval(bc_, bd_, false, false);
                                int? bh_ = context.Operators.IndexOf<CqlInterval<CqlDateTime>>(ax_, sortedCovering);
                                int? bi_ = context.Operators.Subtract(bh_, 1);
                                CqlInterval<CqlDateTime> bj_ = context.Operators.Indexer<CqlInterval<CqlDateTime>>(ax_, bi_);
                                CqlInterval<CqlDateTime> bk_ = context.Operators.Except(be_, bj_);
                                CqlInterval<CqlDateTime> bl_ = context.Operators.Except(bk_, sortedCovering);

                                return bl_;
                            }
                        };

                        return an_();
                    };
                    IEnumerable<CqlInterval<CqlDateTime>> al_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(aj_, ak_);
                    IEnumerable<CqlInterval<CqlDateTime>> am_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(al_);

                    return am_;
                }
            };
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> endgap, IEnumerable<CqlInterval<CqlDateTime>> frontgaps)? j_ = (CqlTupleMetadata_XhWJFQcLdRRLTdZNdjjLiSUI, h_(), i_());
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> endgap, IEnumerable<CqlInterval<CqlDateTime>> frontgaps)?[] k_ = [
                j_,
            ];
            IEnumerable<CqlInterval<CqlDateTime>> l_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> endgap, IEnumerable<CqlInterval<CqlDateTime>> frontgaps)? calculations)
            {
                IEnumerable<CqlInterval<CqlDateTime>> bm_ = calculations?.frontgaps;
                IEnumerable<CqlInterval<CqlDateTime>> bn_ = calculations?.endgap;
                IEnumerable<CqlInterval<CqlDateTime>> bo_ = context.Operators.Union<CqlInterval<CqlDateTime>>(bm_, bn_);
                IEnumerable<CqlInterval<CqlDateTime>> bp_ = this.Collapse_DateTime_Interval_Workaround(context, bo_);

                return bp_;
            };
            IEnumerable<IEnumerable<CqlInterval<CqlDateTime>>> m_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> endgap, IEnumerable<CqlInterval<CqlDateTime>> frontgaps)?, IEnumerable<CqlInterval<CqlDateTime>>>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> endgap, IEnumerable<CqlInterval<CqlDateTime>> frontgaps)?>)k_, l_);
            IEnumerable<IEnumerable<CqlInterval<CqlDateTime>>> n_ = context.Operators.Distinct<IEnumerable<CqlInterval<CqlDateTime>>>(m_);
            IEnumerable<CqlInterval<CqlDateTime>> o_ = context.Operators.SingletonFrom<IEnumerable<CqlInterval<CqlDateTime>>>(n_);

            return o_;
        };
        IEnumerable<IEnumerable<CqlInterval<CqlDateTime>>> e_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> sortedCoverings)?, IEnumerable<CqlInterval<CqlDateTime>>>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> sortedCoverings)?>)c_, d_);
        IEnumerable<IEnumerable<CqlInterval<CqlDateTime>>> f_ = context.Operators.Distinct<IEnumerable<CqlInterval<CqlDateTime>>>(e_);
        IEnumerable<CqlInterval<CqlDateTime>> g_ = context.Operators.SingletonFrom<IEnumerable<CqlInterval<CqlDateTime>>>(f_);

        return g_;
    }


    public (CqlTupleMetadata, int? Interval_Count, IEnumerable<CqlInterval<CqlDate>> Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Intervals, int? Total_Days_In_Longest_Interval)? Collapsed_Date_Interval_Stats(CqlContext context, IEnumerable<CqlInterval<CqlDate>> collapsedIntervals)
    {
        int? a_ = context.Operators.Count<CqlInterval<CqlDate>>(collapsedIntervals);
        CqlInterval<CqlDate> b_()
        {
            bool f_()
            {
                int? g_ = context.Operators.Count<CqlInterval<CqlDate>>(collapsedIntervals);
                bool? h_ = context.Operators.Equal(g_, 0);

                return h_ ?? false;
            };
            if (f_())
            {
                return null as CqlInterval<CqlDate>;
            }
            else
            {
                (CqlTupleMetadata, int? days, CqlInterval<CqlDate> interval)? i_(CqlInterval<CqlDate> I)
                {
                    CqlDate p_ = context.Operators.Start(I);
                    CqlDate q_ = context.Operators.End(I);
                    int? r_ = context.Operators.DurationBetween(p_, q_, "day");
                    int? s_ = context.Operators.Add(r_, 1);
                    int?[] t_ = [
                        s_,
                        0,
                    ];
                    int? u_ = context.Operators.Max<int?>(t_ as IEnumerable<int?>);
                    (CqlTupleMetadata, int? days, CqlInterval<CqlDate> interval)? v_ = (CqlTupleMetadata_CaKfRdNEDgKGCjhSPMGWIWQVV, u_, I);

                    return v_;
                };
                IEnumerable<(CqlTupleMetadata, int? days, CqlInterval<CqlDate> interval)?> j_ = context.Operators.Select<CqlInterval<CqlDate>, (CqlTupleMetadata, int? days, CqlInterval<CqlDate> interval)?>(collapsedIntervals, i_);
                IEnumerable<(CqlTupleMetadata, int? days, CqlInterval<CqlDate> interval)?> k_ = context.Operators.Distinct<(CqlTupleMetadata, int? days, CqlInterval<CqlDate> interval)?>(j_);
                object l_((CqlTupleMetadata, int? days, CqlInterval<CqlDate> interval)? @this)
                {
                    int? w_ = @this?.days;

                    return w_;
                };
                IEnumerable<(CqlTupleMetadata, int? days, CqlInterval<CqlDate> interval)?> m_ = context.Operators.SortBy<(CqlTupleMetadata, int? days, CqlInterval<CqlDate> interval)?>(k_, l_, System.ComponentModel.ListSortDirection.Descending);
                (CqlTupleMetadata, int? days, CqlInterval<CqlDate> interval)? n_ = context.Operators.First<(CqlTupleMetadata, int? days, CqlInterval<CqlDate> interval)?>(m_);
                CqlInterval<CqlDate> o_ = n_?.interval;

                return o_;
            }
        };
        int? c_()
        {
            bool x_()
            {
                int? y_ = context.Operators.Count<CqlInterval<CqlDate>>(collapsedIntervals);
                bool? z_ = context.Operators.Equal(y_, 0);

                return z_ ?? false;
            };
            if (x_())
            {
                return 0;
            }
            else
            {
                int? aa_(CqlInterval<CqlDate> I)
                {
                    CqlDate ae_ = context.Operators.Start(I);
                    CqlDate af_ = context.Operators.End(I);
                    int? ag_ = context.Operators.DurationBetween(ae_, af_, "day");
                    int? ah_ = context.Operators.Add(ag_, 1);
                    int?[] ai_ = [
                        ah_,
                        0,
                    ];
                    int? aj_ = context.Operators.Max<int?>(ai_ as IEnumerable<int?>);

                    return aj_;
                };
                IEnumerable<int?> ab_ = context.Operators.Select<CqlInterval<CqlDate>, int?>(collapsedIntervals, aa_);
                IEnumerable<int?> ac_ = context.Operators.Distinct<int?>(ab_);
                int? ad_ = context.Operators.Sum(ac_);

                return ad_;
            }
        };
        int? d_()
        {
            bool ak_()
            {
                int? al_ = context.Operators.Count<CqlInterval<CqlDate>>(collapsedIntervals);
                bool? am_ = context.Operators.Equal(al_, 0);

                return am_ ?? false;
            };
            if (ak_())
            {
                return 0;
            }
            else
            {
                (CqlTupleMetadata, int? days, CqlInterval<CqlDate> interval)? an_(CqlInterval<CqlDate> I)
                {
                    CqlDate bh_ = context.Operators.Start(I);
                    CqlDate bi_ = context.Operators.End(I);
                    int? bj_ = context.Operators.DurationBetween(bh_, bi_, "day");
                    int? bk_ = context.Operators.Add(bj_, 1);
                    int?[] bl_ = [
                        bk_,
                        0,
                    ];
                    int? bm_ = context.Operators.Max<int?>(bl_ as IEnumerable<int?>);
                    (CqlTupleMetadata, int? days, CqlInterval<CqlDate> interval)? bn_ = (CqlTupleMetadata_CaKfRdNEDgKGCjhSPMGWIWQVV, bm_, I);

                    return bn_;
                };
                IEnumerable<(CqlTupleMetadata, int? days, CqlInterval<CqlDate> interval)?> ao_ = context.Operators.Select<CqlInterval<CqlDate>, (CqlTupleMetadata, int? days, CqlInterval<CqlDate> interval)?>(collapsedIntervals, an_);
                IEnumerable<(CqlTupleMetadata, int? days, CqlInterval<CqlDate> interval)?> ap_ = context.Operators.Distinct<(CqlTupleMetadata, int? days, CqlInterval<CqlDate> interval)?>(ao_);
                object aq_((CqlTupleMetadata, int? days, CqlInterval<CqlDate> interval)? @this)
                {
                    int? bo_ = @this?.days;

                    return bo_;
                };
                IEnumerable<(CqlTupleMetadata, int? days, CqlInterval<CqlDate> interval)?> ar_ = context.Operators.SortBy<(CqlTupleMetadata, int? days, CqlInterval<CqlDate> interval)?>(ap_, aq_, System.ComponentModel.ListSortDirection.Descending);
                (CqlTupleMetadata, int? days, CqlInterval<CqlDate> interval)? as_ = context.Operators.First<(CqlTupleMetadata, int? days, CqlInterval<CqlDate> interval)?>(ar_);
                CqlInterval<CqlDate> at_ = as_?.interval;
                CqlDate au_ = context.Operators.Start(at_);
                (CqlTupleMetadata, int? days, CqlInterval<CqlDate> interval)? av_(CqlInterval<CqlDate> I)
                {
                    CqlDate bp_ = context.Operators.Start(I);
                    CqlDate bq_ = context.Operators.End(I);
                    int? br_ = context.Operators.DurationBetween(bp_, bq_, "day");
                    int? bs_ = context.Operators.Add(br_, 1);
                    int?[] bt_ = [
                        bs_,
                        0,
                    ];
                    int? bu_ = context.Operators.Max<int?>(bt_ as IEnumerable<int?>);
                    (CqlTupleMetadata, int? days, CqlInterval<CqlDate> interval)? bv_ = (CqlTupleMetadata_CaKfRdNEDgKGCjhSPMGWIWQVV, bu_, I);

                    return bv_;
                };
                IEnumerable<(CqlTupleMetadata, int? days, CqlInterval<CqlDate> interval)?> aw_ = context.Operators.Select<CqlInterval<CqlDate>, (CqlTupleMetadata, int? days, CqlInterval<CqlDate> interval)?>(collapsedIntervals, av_);
                IEnumerable<(CqlTupleMetadata, int? days, CqlInterval<CqlDate> interval)?> ax_ = context.Operators.Distinct<(CqlTupleMetadata, int? days, CqlInterval<CqlDate> interval)?>(aw_);
                object ay_((CqlTupleMetadata, int? days, CqlInterval<CqlDate> interval)? @this)
                {
                    int? bw_ = @this?.days;

                    return bw_;
                };
                IEnumerable<(CqlTupleMetadata, int? days, CqlInterval<CqlDate> interval)?> az_ = context.Operators.SortBy<(CqlTupleMetadata, int? days, CqlInterval<CqlDate> interval)?>(ax_, ay_, System.ComponentModel.ListSortDirection.Descending);
                (CqlTupleMetadata, int? days, CqlInterval<CqlDate> interval)? ba_ = context.Operators.First<(CqlTupleMetadata, int? days, CqlInterval<CqlDate> interval)?>(az_);
                CqlInterval<CqlDate> bb_ = ba_?.interval;
                CqlDate bc_ = context.Operators.End(bb_);
                int? bd_ = context.Operators.DurationBetween(au_, bc_, "day");
                int? be_ = context.Operators.Add(bd_, 1);
                int?[] bf_ = [
                    be_,
                    0,
                ];
                int? bg_ = context.Operators.Max<int?>(bf_ as IEnumerable<int?>);

                return bg_;
            }
        };
        (CqlTupleMetadata, int? Interval_Count, IEnumerable<CqlInterval<CqlDate>> Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Intervals, int? Total_Days_In_Longest_Interval)? e_ = (CqlTupleMetadata_GPAfNUdCHUQcLMLShHLcEPiEB, a_, collapsedIntervals, b_(), c_(), d_());

        return e_;
    }


    public (CqlTupleMetadata, int? Interval_Count, IEnumerable<CqlInterval<CqlDate>> Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Intervals, int? Total_Days_In_Longest_Interval)? Date_Interval_Covering_Relative_to_Base_Interval_Stats(CqlContext context, CqlInterval<CqlDate> baseInterval, IEnumerable<CqlInterval<CqlDate>> coveringIntervals)
    {
        IEnumerable<CqlInterval<CqlDate>> a_ = this.Date_Interval_Covering_Relative_to_Base_Interval(context, baseInterval, coveringIntervals);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Covering_Intervals)? b_ = (CqlTupleMetadata_DUiZjXRKgCPYVZQJbFVDKNMOi, a_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Covering_Intervals)?[] c_ = [
            b_,
        ];
        (CqlTupleMetadata, int? Interval_Count, IEnumerable<CqlInterval<CqlDate>> Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Intervals, int? Total_Days_In_Longest_Interval)? d_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Covering_Intervals)? variableDeclarations)
        {
            IEnumerable<CqlInterval<CqlDate>> h_ = variableDeclarations?.Covering_Intervals;
            (CqlTupleMetadata, int? Interval_Count, IEnumerable<CqlInterval<CqlDate>> Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Intervals, int? Total_Days_In_Longest_Interval)? i_ = this.Collapsed_Date_Interval_Stats(context, h_);

            return i_;
        };
        IEnumerable<(CqlTupleMetadata, int? Interval_Count, IEnumerable<CqlInterval<CqlDate>> Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Intervals, int? Total_Days_In_Longest_Interval)?> e_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Covering_Intervals)?, (CqlTupleMetadata, int? Interval_Count, IEnumerable<CqlInterval<CqlDate>> Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Intervals, int? Total_Days_In_Longest_Interval)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Covering_Intervals)?>)c_, d_);
        IEnumerable<(CqlTupleMetadata, int? Interval_Count, IEnumerable<CqlInterval<CqlDate>> Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Intervals, int? Total_Days_In_Longest_Interval)?> f_ = context.Operators.Distinct<(CqlTupleMetadata, int? Interval_Count, IEnumerable<CqlInterval<CqlDate>> Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Intervals, int? Total_Days_In_Longest_Interval)?>(e_);
        (CqlTupleMetadata, int? Interval_Count, IEnumerable<CqlInterval<CqlDate>> Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Intervals, int? Total_Days_In_Longest_Interval)? g_ = context.Operators.SingletonFrom<(CqlTupleMetadata, int? Interval_Count, IEnumerable<CqlInterval<CqlDate>> Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Intervals, int? Total_Days_In_Longest_Interval)?>(f_);

        return g_;
    }


    public (CqlTupleMetadata, int? Interval_Count, IEnumerable<CqlInterval<CqlDate>> Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Intervals, int? Total_Days_In_Longest_Interval)? Date_Interval_Gaps_Relative_to_Base_Interval_Stats(CqlContext context, CqlInterval<CqlDate> baseInterval, IEnumerable<CqlInterval<CqlDate>> coveringIntervals)
    {
        IEnumerable<CqlInterval<CqlDate>> a_ = this.Date_Interval_Gaps_Relative_to_Base_Interval(context, baseInterval, coveringIntervals);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Gap_Intervals)? b_ = (CqlTupleMetadata_GQPbYTYABjXFVLRKjXgcDJFSj, a_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Gap_Intervals)?[] c_ = [
            b_,
        ];
        (CqlTupleMetadata, int? Interval_Count, IEnumerable<CqlInterval<CqlDate>> Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Intervals, int? Total_Days_In_Longest_Interval)? d_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Gap_Intervals)? variableDeclarations)
        {
            IEnumerable<CqlInterval<CqlDate>> h_ = variableDeclarations?.Gap_Intervals;
            (CqlTupleMetadata, int? Interval_Count, IEnumerable<CqlInterval<CqlDate>> Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Intervals, int? Total_Days_In_Longest_Interval)? i_ = this.Collapsed_Date_Interval_Stats(context, h_);

            return i_;
        };
        IEnumerable<(CqlTupleMetadata, int? Interval_Count, IEnumerable<CqlInterval<CqlDate>> Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Intervals, int? Total_Days_In_Longest_Interval)?> e_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Gap_Intervals)?, (CqlTupleMetadata, int? Interval_Count, IEnumerable<CqlInterval<CqlDate>> Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Intervals, int? Total_Days_In_Longest_Interval)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Gap_Intervals)?>)c_, d_);
        IEnumerable<(CqlTupleMetadata, int? Interval_Count, IEnumerable<CqlInterval<CqlDate>> Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Intervals, int? Total_Days_In_Longest_Interval)?> f_ = context.Operators.Distinct<(CqlTupleMetadata, int? Interval_Count, IEnumerable<CqlInterval<CqlDate>> Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Intervals, int? Total_Days_In_Longest_Interval)?>(e_);
        (CqlTupleMetadata, int? Interval_Count, IEnumerable<CqlInterval<CqlDate>> Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Intervals, int? Total_Days_In_Longest_Interval)? g_ = context.Operators.SingletonFrom<(CqlTupleMetadata, int? Interval_Count, IEnumerable<CqlInterval<CqlDate>> Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Intervals, int? Total_Days_In_Longest_Interval)?>(f_);

        return g_;
    }


    public CqlInterval<CqlDateTime> DateTime_Interval_Set_Nulls_to_Zero(CqlContext context, CqlInterval<CqlDateTime> interval)
    {
        int? a_()
        {
            bool w_()
            {
                CqlDateTime x_ = context.Operators.End(interval);
                int? y_ = context.Operators.DateTimeComponentFrom(x_, "day");

                return y_ is null;
            };
            if (w_())
            {
                return 0;
            }
            else
            {
                CqlDateTime z_ = context.Operators.End(interval);
                int? aa_ = context.Operators.DateTimeComponentFrom(z_, "day");

                return aa_;
            }
        };
        int? b_()
        {
            bool ab_()
            {
                CqlDateTime ac_ = context.Operators.End(interval);
                int? ad_ = context.Operators.DateTimeComponentFrom(ac_, "hour");

                return ad_ is null;
            };
            if (ab_())
            {
                return 0;
            }
            else
            {
                CqlDateTime ae_ = context.Operators.End(interval);
                int? af_ = context.Operators.DateTimeComponentFrom(ae_, "hour");

                return af_;
            }
        };
        int? c_()
        {
            bool ag_()
            {
                CqlDateTime ah_ = context.Operators.End(interval);
                int? ai_ = context.Operators.DateTimeComponentFrom(ah_, "millisecond");

                return ai_ is null;
            };
            if (ag_())
            {
                return 0;
            }
            else
            {
                CqlDateTime aj_ = context.Operators.End(interval);
                int? ak_ = context.Operators.DateTimeComponentFrom(aj_, "millisecond");

                return ak_;
            }
        };
        int? d_()
        {
            bool al_()
            {
                CqlDateTime am_ = context.Operators.End(interval);
                int? an_ = context.Operators.DateTimeComponentFrom(am_, "minute");

                return an_ is null;
            };
            if (al_())
            {
                return 0;
            }
            else
            {
                CqlDateTime ao_ = context.Operators.End(interval);
                int? ap_ = context.Operators.DateTimeComponentFrom(ao_, "minute");

                return ap_;
            }
        };
        int? e_()
        {
            bool aq_()
            {
                CqlDateTime ar_ = context.Operators.End(interval);
                int? as_ = context.Operators.DateTimeComponentFrom(ar_, "month");

                return as_ is null;
            };
            if (aq_())
            {
                return 0;
            }
            else
            {
                CqlDateTime at_ = context.Operators.End(interval);
                int? au_ = context.Operators.DateTimeComponentFrom(at_, "month");

                return au_;
            }
        };
        int? f_()
        {
            bool av_()
            {
                CqlDateTime aw_ = context.Operators.End(interval);
                int? ax_ = context.Operators.DateTimeComponentFrom(aw_, "second");

                return ax_ is null;
            };
            if (av_())
            {
                return 0;
            }
            else
            {
                CqlDateTime ay_ = context.Operators.End(interval);
                int? az_ = context.Operators.DateTimeComponentFrom(ay_, "second");

                return az_;
            }
        };
        CqlDateTime g_ = context.Operators.End(interval);
        int? h_ = context.Operators.DateTimeComponentFrom(g_, "year");
        int? i_()
        {
            bool ba_()
            {
                CqlDateTime bb_ = context.Operators.Start(interval);
                int? bc_ = context.Operators.DateTimeComponentFrom(bb_, "day");

                return bc_ is null;
            };
            if (ba_())
            {
                return 0;
            }
            else
            {
                CqlDateTime bd_ = context.Operators.Start(interval);
                int? be_ = context.Operators.DateTimeComponentFrom(bd_, "day");

                return be_;
            }
        };
        int? j_()
        {
            bool bf_()
            {
                CqlDateTime bg_ = context.Operators.Start(interval);
                int? bh_ = context.Operators.DateTimeComponentFrom(bg_, "hour");

                return bh_ is null;
            };
            if (bf_())
            {
                return 0;
            }
            else
            {
                CqlDateTime bi_ = context.Operators.Start(interval);
                int? bj_ = context.Operators.DateTimeComponentFrom(bi_, "hour");

                return bj_;
            }
        };
        int? k_()
        {
            bool bk_()
            {
                CqlDateTime bl_ = context.Operators.Start(interval);
                int? bm_ = context.Operators.DateTimeComponentFrom(bl_, "millisecond");

                return bm_ is null;
            };
            if (bk_())
            {
                return 0;
            }
            else
            {
                CqlDateTime bn_ = context.Operators.Start(interval);
                int? bo_ = context.Operators.DateTimeComponentFrom(bn_, "millisecond");

                return bo_;
            }
        };
        int? l_()
        {
            bool bp_()
            {
                CqlDateTime bq_ = context.Operators.Start(interval);
                int? br_ = context.Operators.DateTimeComponentFrom(bq_, "minute");

                return br_ is null;
            };
            if (bp_())
            {
                return 0;
            }
            else
            {
                CqlDateTime bs_ = context.Operators.Start(interval);
                int? bt_ = context.Operators.DateTimeComponentFrom(bs_, "minute");

                return bt_;
            }
        };
        int? m_()
        {
            bool bu_()
            {
                CqlDateTime bv_ = context.Operators.Start(interval);
                int? bw_ = context.Operators.DateTimeComponentFrom(bv_, "month");

                return bw_ is null;
            };
            if (bu_())
            {
                return 0;
            }
            else
            {
                CqlDateTime bx_ = context.Operators.Start(interval);
                int? by_ = context.Operators.DateTimeComponentFrom(bx_, "month");

                return by_;
            }
        };
        int? n_()
        {
            bool bz_()
            {
                CqlDateTime ca_ = context.Operators.Start(interval);
                int? cb_ = context.Operators.DateTimeComponentFrom(ca_, "second");

                return cb_ is null;
            };
            if (bz_())
            {
                return 0;
            }
            else
            {
                CqlDateTime cc_ = context.Operators.Start(interval);
                int? cd_ = context.Operators.DateTimeComponentFrom(cc_, "second");

                return cd_;
            }
        };
        CqlDateTime o_ = context.Operators.Start(interval);
        int? p_ = context.Operators.DateTimeComponentFrom(o_, "year");
        (CqlTupleMetadata, int? EndDay, int? EndHour, int? EndMillisecond, int? EndMinute, int? EndMonth, int? EndSecond, int? EndYear, int? StartDay, int? StartHour, int? StartMillisecond, int? StartMinute, int? StartMonth, int? StartSecond, int? StartYear)? q_ = (CqlTupleMetadata_EgjgcAJPQYUjXRQgLXSaIjTai, a_(), b_(), c_(), d_(), e_(), f_(), h_, i_(), j_(), k_(), l_(), m_(), n_(), p_);
        (CqlTupleMetadata, int? EndDay, int? EndHour, int? EndMillisecond, int? EndMinute, int? EndMonth, int? EndSecond, int? EndYear, int? StartDay, int? StartHour, int? StartMillisecond, int? StartMinute, int? StartMonth, int? StartSecond, int? StartYear)?[] r_ = [
            q_,
        ];
        CqlInterval<CqlDateTime> s_((CqlTupleMetadata, int? EndDay, int? EndHour, int? EndMillisecond, int? EndMinute, int? EndMonth, int? EndSecond, int? EndYear, int? StartDay, int? StartHour, int? StartMillisecond, int? StartMinute, int? StartMonth, int? StartSecond, int? StartYear)? i)
        {
            int? ce_ = i?.StartYear;
            int? cf_ = i?.StartMonth;
            int? cg_ = i?.StartDay;
            int? ch_ = i?.StartHour;
            int? ci_ = i?.StartMinute;
            int? cj_ = i?.StartSecond;
            int? ck_ = i?.StartMillisecond;
            CqlDateTime cl_ = context.Operators.DateTime(ce_, cf_, cg_, ch_, ci_, cj_, ck_, default);
            int? cm_ = i?.EndYear;
            int? cn_ = i?.EndMonth;
            int? co_ = i?.EndDay;
            int? cp_ = i?.EndHour;
            int? cq_ = i?.EndMinute;
            int? cr_ = i?.EndSecond;
            int? cs_ = i?.EndMillisecond;
            CqlDateTime ct_ = context.Operators.DateTime(cm_, cn_, co_, cp_, cq_, cr_, cs_, default);
            CqlInterval<CqlDateTime> cu_ = context.Operators.Interval(cl_, ct_, true, true);

            return cu_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> t_ = context.Operators.Select<(CqlTupleMetadata, int? EndDay, int? EndHour, int? EndMillisecond, int? EndMinute, int? EndMonth, int? EndSecond, int? EndYear, int? StartDay, int? StartHour, int? StartMillisecond, int? StartMinute, int? StartMonth, int? StartSecond, int? StartYear)?, CqlInterval<CqlDateTime>>((IEnumerable<(CqlTupleMetadata, int? EndDay, int? EndHour, int? EndMillisecond, int? EndMinute, int? EndMonth, int? EndSecond, int? EndYear, int? StartDay, int? StartHour, int? StartMillisecond, int? StartMinute, int? StartMonth, int? StartSecond, int? StartYear)?>)r_, s_);
        IEnumerable<CqlInterval<CqlDateTime>> u_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(t_);
        CqlInterval<CqlDateTime> v_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(u_);

        return v_;
    }


    public (CqlTupleMetadata, int? Interval_Count, IEnumerable<CqlInterval<CqlDateTime>> Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Intervals, int? Total_Days_In_Longest_Interval)? Collapsed_DateTime_Interval_Stats(CqlContext context, IEnumerable<CqlInterval<CqlDateTime>> collapsedIntervals)
    {
        int? a_ = context.Operators.Count<CqlInterval<CqlDateTime>>(collapsedIntervals);
        CqlInterval<CqlDateTime> b_()
        {
            bool f_()
            {
                int? g_ = context.Operators.Count<CqlInterval<CqlDateTime>>(collapsedIntervals);
                bool? h_ = context.Operators.Equal(g_, 0);

                return h_ ?? false;
            };
            if (f_())
            {
                return null as CqlInterval<CqlDateTime>;
            }
            else
            {
                (CqlTupleMetadata, int? days, CqlInterval<CqlDateTime> interval)? i_(CqlInterval<CqlDateTime> I)
                {
                    CqlInterval<CqlDateTime> p_ = this.DateTime_Interval_Set_Nulls_to_Zero(context, I);
                    CqlDateTime q_ = context.Operators.Start(p_);
                    CqlDateTime s_ = context.Operators.End(p_);
                    int? t_ = context.Operators.DurationBetween(q_, s_, "day");
                    int? u_ = context.Operators.Add(t_, 1);
                    int?[] v_ = [
                        u_,
                        0,
                    ];
                    int? w_ = context.Operators.Max<int?>(v_ as IEnumerable<int?>);
                    (CqlTupleMetadata, int? days, CqlInterval<CqlDateTime> interval)? x_ = (CqlTupleMetadata_ELOhVFTXRQKHEUZWiNcOZVYWD, w_, I);

                    return x_;
                };
                IEnumerable<(CqlTupleMetadata, int? days, CqlInterval<CqlDateTime> interval)?> j_ = context.Operators.Select<CqlInterval<CqlDateTime>, (CqlTupleMetadata, int? days, CqlInterval<CqlDateTime> interval)?>(collapsedIntervals, i_);
                IEnumerable<(CqlTupleMetadata, int? days, CqlInterval<CqlDateTime> interval)?> k_ = context.Operators.Distinct<(CqlTupleMetadata, int? days, CqlInterval<CqlDateTime> interval)?>(j_);
                object l_((CqlTupleMetadata, int? days, CqlInterval<CqlDateTime> interval)? @this)
                {
                    int? y_ = @this?.days;

                    return y_;
                };
                IEnumerable<(CqlTupleMetadata, int? days, CqlInterval<CqlDateTime> interval)?> m_ = context.Operators.SortBy<(CqlTupleMetadata, int? days, CqlInterval<CqlDateTime> interval)?>(k_, l_, System.ComponentModel.ListSortDirection.Descending);
                (CqlTupleMetadata, int? days, CqlInterval<CqlDateTime> interval)? n_ = context.Operators.First<(CqlTupleMetadata, int? days, CqlInterval<CqlDateTime> interval)?>(m_);
                CqlInterval<CqlDateTime> o_ = n_?.interval;

                return o_;
            }
        };
        int? c_()
        {
            bool z_()
            {
                int? aa_ = context.Operators.Count<CqlInterval<CqlDateTime>>(collapsedIntervals);
                bool? ab_ = context.Operators.Equal(aa_, 0);

                return ab_ ?? false;
            };
            if (z_())
            {
                return 0;
            }
            else
            {
                int? ac_(CqlInterval<CqlDateTime> I)
                {
                    CqlInterval<CqlDateTime> ag_ = this.DateTime_Interval_Set_Nulls_to_Zero(context, I);
                    CqlDateTime ah_ = context.Operators.Start(ag_);
                    CqlDateTime aj_ = context.Operators.End(ag_);
                    int? ak_ = context.Operators.DurationBetween(ah_, aj_, "day");
                    int? al_ = context.Operators.Add(ak_, 1);
                    int?[] am_ = [
                        al_,
                        0,
                    ];
                    int? an_ = context.Operators.Max<int?>(am_ as IEnumerable<int?>);

                    return an_;
                };
                IEnumerable<int?> ad_ = context.Operators.Select<CqlInterval<CqlDateTime>, int?>(collapsedIntervals, ac_);
                IEnumerable<int?> ae_ = context.Operators.Distinct<int?>(ad_);
                int? af_ = context.Operators.Sum(ae_);

                return af_;
            }
        };
        int? d_()
        {
            bool ao_()
            {
                int? ap_ = context.Operators.Count<CqlInterval<CqlDateTime>>(collapsedIntervals);
                bool? aq_ = context.Operators.Equal(ap_, 0);

                return aq_ ?? false;
            };
            if (ao_())
            {
                return 0;
            }
            else
            {
                (CqlTupleMetadata, int? days, CqlInterval<CqlDateTime> interval)? ar_(CqlInterval<CqlDateTime> I)
                {
                    CqlInterval<CqlDateTime> bn_ = this.DateTime_Interval_Set_Nulls_to_Zero(context, I);
                    CqlDateTime bo_ = context.Operators.Start(bn_);
                    CqlDateTime bq_ = context.Operators.End(bn_);
                    int? br_ = context.Operators.DurationBetween(bo_, bq_, "day");
                    int? bs_ = context.Operators.Add(br_, 1);
                    int?[] bt_ = [
                        bs_,
                        0,
                    ];
                    int? bu_ = context.Operators.Max<int?>(bt_ as IEnumerable<int?>);
                    (CqlTupleMetadata, int? days, CqlInterval<CqlDateTime> interval)? bv_ = (CqlTupleMetadata_ELOhVFTXRQKHEUZWiNcOZVYWD, bu_, I);

                    return bv_;
                };
                IEnumerable<(CqlTupleMetadata, int? days, CqlInterval<CqlDateTime> interval)?> as_ = context.Operators.Select<CqlInterval<CqlDateTime>, (CqlTupleMetadata, int? days, CqlInterval<CqlDateTime> interval)?>(collapsedIntervals, ar_);
                IEnumerable<(CqlTupleMetadata, int? days, CqlInterval<CqlDateTime> interval)?> at_ = context.Operators.Distinct<(CqlTupleMetadata, int? days, CqlInterval<CqlDateTime> interval)?>(as_);
                object au_((CqlTupleMetadata, int? days, CqlInterval<CqlDateTime> interval)? @this)
                {
                    int? bw_ = @this?.days;

                    return bw_;
                };
                IEnumerable<(CqlTupleMetadata, int? days, CqlInterval<CqlDateTime> interval)?> av_ = context.Operators.SortBy<(CqlTupleMetadata, int? days, CqlInterval<CqlDateTime> interval)?>(at_, au_, System.ComponentModel.ListSortDirection.Descending);
                (CqlTupleMetadata, int? days, CqlInterval<CqlDateTime> interval)? aw_ = context.Operators.First<(CqlTupleMetadata, int? days, CqlInterval<CqlDateTime> interval)?>(av_);
                CqlInterval<CqlDateTime> ax_ = aw_?.interval;
                CqlInterval<CqlDateTime> ay_ = this.DateTime_Interval_Set_Nulls_to_Zero(context, ax_);
                CqlDateTime az_ = context.Operators.Start(ay_);
                (CqlTupleMetadata, int? days, CqlInterval<CqlDateTime> interval)? ba_(CqlInterval<CqlDateTime> I)
                {
                    CqlInterval<CqlDateTime> bx_ = this.DateTime_Interval_Set_Nulls_to_Zero(context, I);
                    CqlDateTime by_ = context.Operators.Start(bx_);
                    CqlDateTime ca_ = context.Operators.End(bx_);
                    int? cb_ = context.Operators.DurationBetween(by_, ca_, "day");
                    int? cc_ = context.Operators.Add(cb_, 1);
                    int?[] cd_ = [
                        cc_,
                        0,
                    ];
                    int? ce_ = context.Operators.Max<int?>(cd_ as IEnumerable<int?>);
                    (CqlTupleMetadata, int? days, CqlInterval<CqlDateTime> interval)? cf_ = (CqlTupleMetadata_ELOhVFTXRQKHEUZWiNcOZVYWD, ce_, I);

                    return cf_;
                };
                IEnumerable<(CqlTupleMetadata, int? days, CqlInterval<CqlDateTime> interval)?> bb_ = context.Operators.Select<CqlInterval<CqlDateTime>, (CqlTupleMetadata, int? days, CqlInterval<CqlDateTime> interval)?>(collapsedIntervals, ba_);
                IEnumerable<(CqlTupleMetadata, int? days, CqlInterval<CqlDateTime> interval)?> bc_ = context.Operators.Distinct<(CqlTupleMetadata, int? days, CqlInterval<CqlDateTime> interval)?>(bb_);
                object bd_((CqlTupleMetadata, int? days, CqlInterval<CqlDateTime> interval)? @this)
                {
                    int? cg_ = @this?.days;

                    return cg_;
                };
                IEnumerable<(CqlTupleMetadata, int? days, CqlInterval<CqlDateTime> interval)?> be_ = context.Operators.SortBy<(CqlTupleMetadata, int? days, CqlInterval<CqlDateTime> interval)?>(bc_, bd_, System.ComponentModel.ListSortDirection.Descending);
                (CqlTupleMetadata, int? days, CqlInterval<CqlDateTime> interval)? bf_ = context.Operators.First<(CqlTupleMetadata, int? days, CqlInterval<CqlDateTime> interval)?>(be_);
                CqlInterval<CqlDateTime> bg_ = bf_?.interval;
                CqlInterval<CqlDateTime> bh_ = this.DateTime_Interval_Set_Nulls_to_Zero(context, bg_);
                CqlDateTime bi_ = context.Operators.End(bh_);
                int? bj_ = context.Operators.DurationBetween(az_, bi_, "day");
                int? bk_ = context.Operators.Add(bj_, 1);
                int?[] bl_ = [
                    bk_,
                    0,
                ];
                int? bm_ = context.Operators.Max<int?>(bl_ as IEnumerable<int?>);

                return bm_;
            }
        };
        (CqlTupleMetadata, int? Interval_Count, IEnumerable<CqlInterval<CqlDateTime>> Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Intervals, int? Total_Days_In_Longest_Interval)? e_ = (CqlTupleMetadata_BCOQgagVPjGKjGhZbJGYVGIKJ, a_, collapsedIntervals, b_(), c_(), d_());

        return e_;
    }


    public (CqlTupleMetadata, int? Interval_Count, IEnumerable<CqlInterval<CqlDateTime>> Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Intervals, int? Total_Days_In_Longest_Interval)? DateTime_Interval_Covering_Relative_to_Base_Interval_Stats(CqlContext context, CqlInterval<CqlDateTime> baseInterval, IEnumerable<CqlInterval<CqlDateTime>> coveringIntervals)
    {
        IEnumerable<CqlInterval<CqlDateTime>> a_ = this.DateTime_Interval_Covering_Relative_to_Base_Interval(context, baseInterval, coveringIntervals);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Covering_Intervals)? b_ = (CqlTupleMetadata_GZMPWdGOJiTNjfWAcbZMePdXV, a_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Covering_Intervals)?[] c_ = [
            b_,
        ];
        (CqlTupleMetadata, int? Interval_Count, IEnumerable<CqlInterval<CqlDateTime>> Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Intervals, int? Total_Days_In_Longest_Interval)? d_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Covering_Intervals)? variableDeclarations)
        {
            IEnumerable<CqlInterval<CqlDateTime>> h_ = variableDeclarations?.Covering_Intervals;
            (CqlTupleMetadata, int? Interval_Count, IEnumerable<CqlInterval<CqlDateTime>> Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Intervals, int? Total_Days_In_Longest_Interval)? i_ = this.Collapsed_DateTime_Interval_Stats(context, h_);

            return i_;
        };
        IEnumerable<(CqlTupleMetadata, int? Interval_Count, IEnumerable<CqlInterval<CqlDateTime>> Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Intervals, int? Total_Days_In_Longest_Interval)?> e_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Covering_Intervals)?, (CqlTupleMetadata, int? Interval_Count, IEnumerable<CqlInterval<CqlDateTime>> Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Intervals, int? Total_Days_In_Longest_Interval)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Covering_Intervals)?>)c_, d_);
        IEnumerable<(CqlTupleMetadata, int? Interval_Count, IEnumerable<CqlInterval<CqlDateTime>> Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Intervals, int? Total_Days_In_Longest_Interval)?> f_ = context.Operators.Distinct<(CqlTupleMetadata, int? Interval_Count, IEnumerable<CqlInterval<CqlDateTime>> Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Intervals, int? Total_Days_In_Longest_Interval)?>(e_);
        (CqlTupleMetadata, int? Interval_Count, IEnumerable<CqlInterval<CqlDateTime>> Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Intervals, int? Total_Days_In_Longest_Interval)? g_ = context.Operators.SingletonFrom<(CqlTupleMetadata, int? Interval_Count, IEnumerable<CqlInterval<CqlDateTime>> Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Intervals, int? Total_Days_In_Longest_Interval)?>(f_);

        return g_;
    }


    public (CqlTupleMetadata, int? Interval_Count, IEnumerable<CqlInterval<CqlDateTime>> Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Intervals, int? Total_Days_In_Longest_Interval)? DateTime_Interval_Gaps_Relative_to_Base_Interval_Stats(CqlContext context, CqlInterval<CqlDateTime> baseInterval, IEnumerable<CqlInterval<CqlDateTime>> coveringIntervals)
    {
        IEnumerable<CqlInterval<CqlDateTime>> a_ = this.DateTime_Interval_Gaps_Relative_to_Base_Interval(context, baseInterval, coveringIntervals);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Gap_Intervals)? b_ = (CqlTupleMetadata_CKbERRbOPGNBBERUOghhaOYSE, a_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Gap_Intervals)?[] c_ = [
            b_,
        ];
        (CqlTupleMetadata, int? Interval_Count, IEnumerable<CqlInterval<CqlDateTime>> Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Intervals, int? Total_Days_In_Longest_Interval)? d_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Gap_Intervals)? variableDeclarations)
        {
            IEnumerable<CqlInterval<CqlDateTime>> h_ = variableDeclarations?.Gap_Intervals;
            (CqlTupleMetadata, int? Interval_Count, IEnumerable<CqlInterval<CqlDateTime>> Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Intervals, int? Total_Days_In_Longest_Interval)? i_ = this.Collapsed_DateTime_Interval_Stats(context, h_);

            return i_;
        };
        IEnumerable<(CqlTupleMetadata, int? Interval_Count, IEnumerable<CqlInterval<CqlDateTime>> Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Intervals, int? Total_Days_In_Longest_Interval)?> e_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Gap_Intervals)?, (CqlTupleMetadata, int? Interval_Count, IEnumerable<CqlInterval<CqlDateTime>> Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Intervals, int? Total_Days_In_Longest_Interval)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Gap_Intervals)?>)c_, d_);
        IEnumerable<(CqlTupleMetadata, int? Interval_Count, IEnumerable<CqlInterval<CqlDateTime>> Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Intervals, int? Total_Days_In_Longest_Interval)?> f_ = context.Operators.Distinct<(CqlTupleMetadata, int? Interval_Count, IEnumerable<CqlInterval<CqlDateTime>> Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Intervals, int? Total_Days_In_Longest_Interval)?>(e_);
        (CqlTupleMetadata, int? Interval_Count, IEnumerable<CqlInterval<CqlDateTime>> Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Intervals, int? Total_Days_In_Longest_Interval)? g_ = context.Operators.SingletonFrom<(CqlTupleMetadata, int? Interval_Count, IEnumerable<CqlInterval<CqlDateTime>> Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Intervals, int? Total_Days_In_Longest_Interval)?>(f_);

        return g_;
    }


    public CqlDateTime Convert_To_UTC_DateTime(CqlContext context, CqlDate d)
    {
        int? a_()
        {
            if ((context.Operators.DateTimeComponentFrom(d, "day")) is null)
            {
                return 0;
            }
            else
            {
                int? j_ = context.Operators.DateTimeComponentFrom(d, "day");

                return j_;
            }
        };
        int? b_()
        {
            if ((context.Operators.DateTimeComponentFrom(d, "month")) is null)
            {
                return 0;
            }
            else
            {
                int? k_ = context.Operators.DateTimeComponentFrom(d, "month");

                return k_;
            }
        };
        int? c_ = context.Operators.DateTimeComponentFrom(d, "year");
        (CqlTupleMetadata, int? EndDay, int? EndHour, int? EndMillisecond, int? EndMinute, int? EndMonth, int? EndSecond, int? EndYear, int? StartDay, int? StartHour, int? StartMillisecond, int? StartMinute, int? StartMonth, int? StartSecond, int? StartYear)? d_ = (CqlTupleMetadata_EgjgcAJPQYUjXRQgLXSaIjTai, default, default, default, default, default, default, default, a_(), default, default, default, b_(), default, c_);
        (CqlTupleMetadata, int? EndDay, int? EndHour, int? EndMillisecond, int? EndMinute, int? EndMonth, int? EndSecond, int? EndYear, int? StartDay, int? StartHour, int? StartMillisecond, int? StartMinute, int? StartMonth, int? StartSecond, int? StartYear)?[] e_ = [
            d_,
        ];
        CqlDateTime f_((CqlTupleMetadata, int? EndDay, int? EndHour, int? EndMillisecond, int? EndMinute, int? EndMonth, int? EndSecond, int? EndYear, int? StartDay, int? StartHour, int? StartMillisecond, int? StartMinute, int? StartMonth, int? StartSecond, int? StartYear)? i)
        {
            int? l_ = i?.StartYear;
            int? m_ = i?.StartMonth;
            int? n_ = i?.StartDay;
            decimal? o_ = context.Operators.ConvertIntegerToDecimal(0);
            CqlDateTime p_ = context.Operators.DateTime(l_, m_, n_, 0, 0, 0, 0, o_);

            return p_;
        };
        IEnumerable<CqlDateTime> g_ = context.Operators.Select<(CqlTupleMetadata, int? EndDay, int? EndHour, int? EndMillisecond, int? EndMinute, int? EndMonth, int? EndSecond, int? EndYear, int? StartDay, int? StartHour, int? StartMillisecond, int? StartMinute, int? StartMonth, int? StartSecond, int? StartYear)?, CqlDateTime>((IEnumerable<(CqlTupleMetadata, int? EndDay, int? EndHour, int? EndMillisecond, int? EndMinute, int? EndMonth, int? EndSecond, int? EndYear, int? StartDay, int? StartHour, int? StartMillisecond, int? StartMinute, int? StartMonth, int? StartSecond, int? StartYear)?>)e_, f_);
        IEnumerable<CqlDateTime> h_ = context.Operators.Distinct<CqlDateTime>(g_);
        CqlDateTime i_ = context.Operators.SingletonFrom<CqlDateTime>(h_);

        return i_;
    }


    public CqlInterval<CqlDateTime> Convert_Interval_Date_to_UTC_Interval_DateTime(CqlContext context, CqlInterval<CqlDate> interval)
    {
        CqlDate a_ = context.Operators.Start(interval);
        CqlDateTime b_ = this.Convert_To_UTC_DateTime(context, a_);
        CqlDate c_ = context.Operators.End(interval);
        CqlDateTime d_ = this.Convert_To_UTC_DateTime(context, c_);
        CqlInterval<CqlDateTime> e_ = context.Operators.Interval(b_, d_, true, true);

        return e_;
    }


    #endregion Definition Methods

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_BCOQgagVPjGKjGhZbJGYVGIKJ = new(
        [typeof(int?), typeof(IEnumerable<CqlInterval<CqlDateTime>>), typeof(CqlInterval<CqlDateTime>), typeof(int?), typeof(int?)],
        ["Interval_Count", "Intervals", "Longest_Interval", "Total_Days_In_Intervals", "Total_Days_In_Longest_Interval"]);

    private static CqlTupleMetadata CqlTupleMetadata_CaKfRdNEDgKGCjhSPMGWIWQVV = new(
        [typeof(int?), typeof(CqlInterval<CqlDate>)],
        ["days", "interval"]);

    private static CqlTupleMetadata CqlTupleMetadata_CKbERRbOPGNBBERUOghhaOYSE = new(
        [typeof(IEnumerable<CqlInterval<CqlDateTime>>)],
        ["Gap_Intervals"]);

    private static CqlTupleMetadata CqlTupleMetadata_DECPbSATOETPaGfFJifhEcWWB = new(
        [typeof(IEnumerable<CqlInterval<CqlDate>>), typeof(IEnumerable<CqlInterval<CqlDate>>)],
        ["endgap", "frontgaps"]);

    private static CqlTupleMetadata CqlTupleMetadata_DUiZjXRKgCPYVZQJbFVDKNMOi = new(
        [typeof(IEnumerable<CqlInterval<CqlDate>>)],
        ["Covering_Intervals"]);

    private static CqlTupleMetadata CqlTupleMetadata_EdgSWaTaCbLYLJceGdIcWOLHd = new(
        [typeof(IEnumerable<CqlInterval<CqlDateTime>>)],
        ["sortedCoverings"]);

    private static CqlTupleMetadata CqlTupleMetadata_EgjgcAJPQYUjXRQgLXSaIjTai = new(
        [typeof(int?), typeof(int?), typeof(int?), typeof(int?), typeof(int?), typeof(int?), typeof(int?), typeof(int?), typeof(int?), typeof(int?), typeof(int?), typeof(int?), typeof(int?), typeof(int?)],
        ["EndDay", "EndHour", "EndMillisecond", "EndMinute", "EndMonth", "EndSecond", "EndYear", "StartDay", "StartHour", "StartMillisecond", "StartMinute", "StartMonth", "StartSecond", "StartYear"]);

    private static CqlTupleMetadata CqlTupleMetadata_ELOhVFTXRQKHEUZWiNcOZVYWD = new(
        [typeof(int?), typeof(CqlInterval<CqlDateTime>)],
        ["days", "interval"]);

    private static CqlTupleMetadata CqlTupleMetadata_EQHOUSiiWahbJPOUjJGEhIAOV = new(
        [typeof(CqlInterval<CqlDateTime>), typeof(CqlDateTime)],
        ["interval", "startOfInterval"]);

    private static CqlTupleMetadata CqlTupleMetadata_EVRLVXPcBiDTIWfCCfKEWDfKI = new(
        [typeof(IEnumerable<CqlInterval<CqlDate>>)],
        ["sortedCoverings"]);

    private static CqlTupleMetadata CqlTupleMetadata_GIMHfXDcFiAjSJBDGYeUeZLhW = new(
        [typeof(CqlInterval<CqlDate>), typeof(CqlDate)],
        ["interval", "startOfInterval"]);

    private static CqlTupleMetadata CqlTupleMetadata_GPAfNUdCHUQcLMLShHLcEPiEB = new(
        [typeof(int?), typeof(IEnumerable<CqlInterval<CqlDate>>), typeof(CqlInterval<CqlDate>), typeof(int?), typeof(int?)],
        ["Interval_Count", "Intervals", "Longest_Interval", "Total_Days_In_Intervals", "Total_Days_In_Longest_Interval"]);

    private static CqlTupleMetadata CqlTupleMetadata_GQPbYTYABjXFVLRKjXgcDJFSj = new(
        [typeof(IEnumerable<CqlInterval<CqlDate>>)],
        ["Gap_Intervals"]);

    private static CqlTupleMetadata CqlTupleMetadata_GZMPWdGOJiTNjfWAcbZMePdXV = new(
        [typeof(IEnumerable<CqlInterval<CqlDateTime>>)],
        ["Covering_Intervals"]);

    private static CqlTupleMetadata CqlTupleMetadata_XhWJFQcLdRRLTdZNdjjLiSUI = new(
        [typeof(IEnumerable<CqlInterval<CqlDateTime>>), typeof(IEnumerable<CqlInterval<CqlDateTime>>)],
        ["endgap", "frontgaps"]);

    #endregion CqlTupleMetadata Properties

}
