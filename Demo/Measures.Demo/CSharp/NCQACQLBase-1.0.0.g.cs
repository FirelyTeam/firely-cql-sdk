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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "3.0.0.0")]
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

    #region Expressions

    [CqlExpressionDefinition("Sort Date Intervals")]
    public IEnumerable<CqlInterval<CqlDate>> Sort_Date_Intervals(CqlContext context, IEnumerable<CqlInterval<CqlDate>> intervals)
    {
        IEnumerable<CqlInterval<CqlDate>> lzzzzzzzzw_()
        {
            bool lzzzzzzzzx_()
            {
                int? lzzzzzzzzy_ = context.Operators.Count<CqlInterval<CqlDate>>(intervals);
                bool? lzzzzzzzzz_ = context.Operators.Equal(lzzzzzzzzy_, 0);

                return lzzzzzzzzz_ ?? false;
            };
            if (intervals is null)
            {
                CqlInterval<CqlDate>[] mzzzzzzzza_ = []
;

                return mzzzzzzzza_ as IEnumerable<CqlInterval<CqlDate>>;
            }
            else if (lzzzzzzzzx_())
            {
                CqlInterval<CqlDate>[] mzzzzzzzzb_ = []
;

                return mzzzzzzzzb_ as IEnumerable<CqlInterval<CqlDate>>;
            }
            else
            {
                (CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)? mzzzzzzzzc_(CqlInterval<CqlDate> I)
                {
                    CqlDate mzzzzzzzzk_()
                    {
                        if ((context.Operators.Start(I)) is null)
                        {
                            CqlDate mzzzzzzzzm_ = context.Operators.MinValue<CqlDate>();

                            return mzzzzzzzzm_;
                        }
                        else
                        {
                            CqlDate mzzzzzzzzn_ = context.Operators.Start(I);

                            return mzzzzzzzzn_;
                        }
                    };
                    (CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)? mzzzzzzzzl_ = (CqlTupleMetadata_GIMHfXDcFiAjSJBDGYeUeZLhW, I, mzzzzzzzzk_());

                    return mzzzzzzzzl_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)?> mzzzzzzzzd_ = context.Operators.Select<CqlInterval<CqlDate>, (CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)?>(intervals, mzzzzzzzzc_);
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)?> mzzzzzzzze_ = context.Operators.Distinct<(CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)?>(mzzzzzzzzd_);
                object mzzzzzzzzf_((CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)? @this)
                {
                    CqlDate mzzzzzzzzo_ = @this?.startOfInterval;

                    return mzzzzzzzzo_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)?> mzzzzzzzzg_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)?>(mzzzzzzzze_, mzzzzzzzzf_, System.ComponentModel.ListSortDirection.Ascending);
                CqlInterval<CqlDate> mzzzzzzzzh_((CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)? sortedIntervals)
                {
                    CqlInterval<CqlDate> mzzzzzzzzp_ = sortedIntervals?.interval;

                    return mzzzzzzzzp_;
                };
                IEnumerable<CqlInterval<CqlDate>> mzzzzzzzzi_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)?, CqlInterval<CqlDate>>(mzzzzzzzzg_, mzzzzzzzzh_);
                IEnumerable<CqlInterval<CqlDate>> mzzzzzzzzj_ = context.Operators.Distinct<CqlInterval<CqlDate>>(mzzzzzzzzi_);

                return mzzzzzzzzj_;
            }
        };

        return lzzzzzzzzw_();
    }


    [CqlExpressionDefinition("Sort DateTime Intervals")]
    public IEnumerable<CqlInterval<CqlDateTime>> Sort_DateTime_Intervals(CqlContext context, IEnumerable<CqlInterval<CqlDateTime>> intervals)
    {
        IEnumerable<CqlInterval<CqlDateTime>> mzzzzzzzzq_()
        {
            bool mzzzzzzzzr_()
            {
                int? mzzzzzzzzs_ = context.Operators.Count<CqlInterval<CqlDateTime>>(intervals);
                bool? mzzzzzzzzt_ = context.Operators.Equal(mzzzzzzzzs_, 0);

                return mzzzzzzzzt_ ?? false;
            };
            if (intervals is null)
            {
                CqlInterval<CqlDateTime>[] mzzzzzzzzu_ = []
;

                return mzzzzzzzzu_ as IEnumerable<CqlInterval<CqlDateTime>>;
            }
            else if (mzzzzzzzzr_())
            {
                CqlInterval<CqlDateTime>[] mzzzzzzzzv_ = []
;

                return mzzzzzzzzv_ as IEnumerable<CqlInterval<CqlDateTime>>;
            }
            else
            {
                (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)? mzzzzzzzzw_(CqlInterval<CqlDateTime> I)
                {
                    CqlDateTime nzzzzzzzze_()
                    {
                        if ((context.Operators.Start(I)) is null)
                        {
                            CqlDateTime nzzzzzzzzg_ = context.Operators.MinValue<CqlDateTime>();

                            return nzzzzzzzzg_;
                        }
                        else
                        {
                            CqlDateTime nzzzzzzzzh_ = context.Operators.Start(I);

                            return nzzzzzzzzh_;
                        }
                    };
                    (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)? nzzzzzzzzf_ = (CqlTupleMetadata_EQHOUSiiWahbJPOUjJGEhIAOV, I, nzzzzzzzze_());

                    return nzzzzzzzzf_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?> mzzzzzzzzx_ = context.Operators.Select<CqlInterval<CqlDateTime>, (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?>(intervals, mzzzzzzzzw_);
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?> mzzzzzzzzy_ = context.Operators.Distinct<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?>(mzzzzzzzzx_);
                object mzzzzzzzzz_((CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)? @this)
                {
                    CqlDateTime nzzzzzzzzi_ = @this?.startOfInterval;

                    return nzzzzzzzzi_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?> nzzzzzzzza_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?>(mzzzzzzzzy_, mzzzzzzzzz_, System.ComponentModel.ListSortDirection.Ascending);
                CqlInterval<CqlDateTime> nzzzzzzzzb_((CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)? sortedIntervals)
                {
                    CqlInterval<CqlDateTime> nzzzzzzzzj_ = sortedIntervals?.interval;

                    return nzzzzzzzzj_;
                };
                IEnumerable<CqlInterval<CqlDateTime>> nzzzzzzzzc_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?, CqlInterval<CqlDateTime>>(nzzzzzzzza_, nzzzzzzzzb_);
                IEnumerable<CqlInterval<CqlDateTime>> nzzzzzzzzd_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(nzzzzzzzzc_);

                return nzzzzzzzzd_;
            }
        };

        return mzzzzzzzzq_();
    }


    [CqlExpressionDefinition("Collapse Date Interval Workaround")]
    public IEnumerable<CqlInterval<CqlDate>> Collapse_Date_Interval_Workaround(CqlContext context, IEnumerable<CqlInterval<CqlDate>> intervals)
    {
        IEnumerable<CqlInterval<CqlDate>> nzzzzzzzzk_()
        {
            bool nzzzzzzzzl_()
            {
                int? nzzzzzzzzm_ = context.Operators.Count<CqlInterval<CqlDate>>(intervals);
                bool? nzzzzzzzzn_ = context.Operators.Equal(nzzzzzzzzm_, 0);

                return nzzzzzzzzn_ ?? false;
            };
            if (intervals is null)
            {
                CqlInterval<CqlDate>[] nzzzzzzzzo_ = []
;

                return nzzzzzzzzo_ as IEnumerable<CqlInterval<CqlDate>>;
            }
            else if (nzzzzzzzzl_())
            {
                CqlInterval<CqlDate>[] nzzzzzzzzp_ = []
;

                return nzzzzzzzzp_ as IEnumerable<CqlInterval<CqlDate>>;
            }
            else
            {
                bool? nzzzzzzzzq_(CqlInterval<CqlDate> I)
                {
                    bool? nzzzzzzzzt_(CqlInterval<CqlDate> J)
                    {
                        bool? nzzzzzzzzy_ = context.Operators.IntervalProperlyIncludesInterval<CqlDate>(J, I, default);

                        return nzzzzzzzzy_;
                    };
                    IEnumerable<bool?> nzzzzzzzzu_ = context.Operators.Select<CqlInterval<CqlDate>, bool?>(intervals, nzzzzzzzzt_);
                    IEnumerable<bool?> nzzzzzzzzv_ = context.Operators.Distinct<bool?>(nzzzzzzzzu_);
                    bool? nzzzzzzzzw_ = context.Operators.AnyTrue(nzzzzzzzzv_);
                    bool? nzzzzzzzzx_ = context.Operators.Not(nzzzzzzzzw_);

                    return nzzzzzzzzx_;
                };
                IEnumerable<CqlInterval<CqlDate>> nzzzzzzzzr_ = context.Operators.Where<CqlInterval<CqlDate>>(intervals, nzzzzzzzzq_);
                IEnumerable<CqlInterval<CqlDate>> nzzzzzzzzs_ = context.Operators.Collapse(nzzzzzzzzr_, "day");

                return nzzzzzzzzs_;
            }
        };

        return nzzzzzzzzk_();
    }


    [CqlExpressionDefinition("Collapse DateTime Interval Workaround")]
    public IEnumerable<CqlInterval<CqlDateTime>> Collapse_DateTime_Interval_Workaround(CqlContext context, IEnumerable<CqlInterval<CqlDateTime>> intervals)
    {
        IEnumerable<CqlInterval<CqlDateTime>> nzzzzzzzzz_()
        {
            bool ozzzzzzzza_()
            {
                int? ozzzzzzzzb_ = context.Operators.Count<CqlInterval<CqlDateTime>>(intervals);
                bool? ozzzzzzzzc_ = context.Operators.Equal(ozzzzzzzzb_, 0);

                return ozzzzzzzzc_ ?? false;
            };
            if (intervals is null)
            {
                CqlInterval<CqlDateTime>[] ozzzzzzzzd_ = []
;

                return ozzzzzzzzd_ as IEnumerable<CqlInterval<CqlDateTime>>;
            }
            else if (ozzzzzzzza_())
            {
                CqlInterval<CqlDateTime>[] ozzzzzzzze_ = []
;

                return ozzzzzzzze_ as IEnumerable<CqlInterval<CqlDateTime>>;
            }
            else
            {
                bool? ozzzzzzzzf_(CqlInterval<CqlDateTime> I)
                {
                    bool? ozzzzzzzzi_(CqlInterval<CqlDateTime> J)
                    {
                        bool? ozzzzzzzzn_ = context.Operators.IntervalProperlyIncludesInterval<CqlDateTime>(J, I, default);

                        return ozzzzzzzzn_;
                    };
                    IEnumerable<bool?> ozzzzzzzzj_ = context.Operators.Select<CqlInterval<CqlDateTime>, bool?>(intervals, ozzzzzzzzi_);
                    IEnumerable<bool?> ozzzzzzzzk_ = context.Operators.Distinct<bool?>(ozzzzzzzzj_);
                    bool? ozzzzzzzzl_ = context.Operators.AnyTrue(ozzzzzzzzk_);
                    bool? ozzzzzzzzm_ = context.Operators.Not(ozzzzzzzzl_);

                    return ozzzzzzzzm_;
                };
                IEnumerable<CqlInterval<CqlDateTime>> ozzzzzzzzg_ = context.Operators.Where<CqlInterval<CqlDateTime>>(intervals, ozzzzzzzzf_);
                IEnumerable<CqlInterval<CqlDateTime>> ozzzzzzzzh_ = context.Operators.Collapse(ozzzzzzzzg_, default);

                return ozzzzzzzzh_;
            }
        };

        return nzzzzzzzzz_();
    }


    [CqlExpressionDefinition("Date Interval Covering Relative to Base Interval")]
    public IEnumerable<CqlInterval<CqlDate>> Date_Interval_Covering_Relative_to_Base_Interval(CqlContext context, CqlInterval<CqlDate> baseInterval, IEnumerable<CqlInterval<CqlDate>> coveringIntervals)
    {
        IEnumerable<CqlInterval<CqlDate>> ozzzzzzzzo_ = this.Sort_Date_Intervals(context, coveringIntervals);
        CqlInterval<CqlDate> ozzzzzzzzp_(CqlInterval<CqlDate> sortedInterval)
        {
            CqlInterval<CqlDate> ozzzzzzzzt_ = context.Operators.Intersect<CqlDate>(baseInterval, sortedInterval);

            return ozzzzzzzzt_;
        };
        IEnumerable<CqlInterval<CqlDate>> ozzzzzzzzq_ = context.Operators.Select<CqlInterval<CqlDate>, CqlInterval<CqlDate>>(ozzzzzzzzo_, ozzzzzzzzp_);
        IEnumerable<CqlInterval<CqlDate>> ozzzzzzzzr_ = context.Operators.Distinct<CqlInterval<CqlDate>>(ozzzzzzzzq_);
        IEnumerable<CqlInterval<CqlDate>> ozzzzzzzzs_ = this.Collapse_Date_Interval_Workaround(context, ozzzzzzzzr_);

        return ozzzzzzzzs_;
    }


    [CqlExpressionDefinition("DateTime Interval Covering Relative to Base Interval")]
    public IEnumerable<CqlInterval<CqlDateTime>> DateTime_Interval_Covering_Relative_to_Base_Interval(CqlContext context, CqlInterval<CqlDateTime> baseInterval, IEnumerable<CqlInterval<CqlDateTime>> coveringIntervals)
    {
        IEnumerable<CqlInterval<CqlDateTime>> ozzzzzzzzu_ = this.Sort_DateTime_Intervals(context, coveringIntervals);
        CqlInterval<CqlDateTime> ozzzzzzzzv_(CqlInterval<CqlDateTime> sortedInterval)
        {
            CqlInterval<CqlDateTime> ozzzzzzzzz_ = context.Operators.Intersect<CqlDateTime>(baseInterval, sortedInterval);

            return ozzzzzzzzz_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> ozzzzzzzzw_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(ozzzzzzzzu_, ozzzzzzzzv_);
        IEnumerable<CqlInterval<CqlDateTime>> ozzzzzzzzx_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(ozzzzzzzzw_);
        IEnumerable<CqlInterval<CqlDateTime>> ozzzzzzzzy_ = this.Collapse_DateTime_Interval_Workaround(context, ozzzzzzzzx_);

        return ozzzzzzzzy_;
    }


    [CqlExpressionDefinition("Date Interval Gaps Relative to Base Interval")]
    public IEnumerable<CqlInterval<CqlDate>> Date_Interval_Gaps_Relative_to_Base_Interval(CqlContext context, CqlInterval<CqlDate> baseInterval, IEnumerable<CqlInterval<CqlDate>> coveringIntervals)
    {
        IEnumerable<CqlInterval<CqlDate>> pzzzzzzzza_ = this.Date_Interval_Covering_Relative_to_Base_Interval(context, baseInterval, coveringIntervals);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> sortedCoverings)? pzzzzzzzzb_ = (CqlTupleMetadata_EVRLVXPcBiDTIWfCCfKEWDfKI, pzzzzzzzza_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> sortedCoverings)?[] pzzzzzzzzc_ = [
            pzzzzzzzzb_,
        ];
        IEnumerable<CqlInterval<CqlDate>> pzzzzzzzzd_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> sortedCoverings)? variableDeclarations)
        {
            IEnumerable<CqlInterval<CqlDate>> pzzzzzzzzh_()
            {
                bool pzzzzzzzzp_()
                {
                    IEnumerable<CqlInterval<CqlDate>> pzzzzzzzzq_ = variableDeclarations?.sortedCoverings;
                    int? pzzzzzzzzr_ = context.Operators.Count<CqlInterval<CqlDate>>(pzzzzzzzzq_);
                    bool? pzzzzzzzzs_ = context.Operators.Equal(pzzzzzzzzr_, 0);

                    return pzzzzzzzzs_ ?? false;
                };
                if (pzzzzzzzzp_())
                {
                    CqlInterval<CqlDate>[] pzzzzzzzzt_ = [
                        baseInterval,
                    ];

                    return pzzzzzzzzt_ as IEnumerable<CqlInterval<CqlDate>>;
                }
                else
                {
                    IEnumerable<CqlInterval<CqlDate>> pzzzzzzzzu_ = variableDeclarations?.sortedCoverings;
                    CqlInterval<CqlDate> pzzzzzzzzv_(CqlInterval<CqlDate> sortedCovering)
                    {
                        CqlInterval<CqlDate> pzzzzzzzzy_()
                        {
                            bool pzzzzzzzzz_()
                            {
                                IEnumerable<CqlInterval<CqlDate>> qzzzzzzzza_ = variableDeclarations?.sortedCoverings;
                                int? qzzzzzzzzb_ = context.Operators.IndexOf<CqlInterval<CqlDate>>(qzzzzzzzza_, sortedCovering);
                                bool? qzzzzzzzzc_ = context.Operators.Equal(qzzzzzzzzb_, 0);

                                return qzzzzzzzzc_ ?? false;
                            };
                            if (pzzzzzzzzz_())
                            {
                                CqlDate qzzzzzzzzd_ = context.Operators.Start(baseInterval);
                                CqlDate qzzzzzzzze_ = context.Operators.Start(sortedCovering);
                                CqlInterval<CqlDate> qzzzzzzzzf_ = context.Operators.Interval(qzzzzzzzzd_, qzzzzzzzze_, true, true);
                                CqlInterval<CqlDate> qzzzzzzzzg_ = context.Operators.Intersect<CqlDate>(qzzzzzzzzf_, baseInterval);
                                CqlInterval<CqlDate> qzzzzzzzzh_ = context.Operators.Except(qzzzzzzzzg_, sortedCovering);

                                return qzzzzzzzzh_;
                            }
                            else
                            {
                                IEnumerable<CqlInterval<CqlDate>> qzzzzzzzzi_ = variableDeclarations?.sortedCoverings;
                                int? qzzzzzzzzk_ = context.Operators.IndexOf<CqlInterval<CqlDate>>(qzzzzzzzzi_, sortedCovering);
                                int? qzzzzzzzzl_ = context.Operators.Subtract(qzzzzzzzzk_, 1);
                                CqlInterval<CqlDate> qzzzzzzzzm_ = context.Operators.Indexer<CqlInterval<CqlDate>>(qzzzzzzzzi_, qzzzzzzzzl_);
                                CqlDate qzzzzzzzzn_ = context.Operators.Start(qzzzzzzzzm_);
                                CqlDate qzzzzzzzzo_ = context.Operators.End(sortedCovering);
                                CqlInterval<CqlDate> qzzzzzzzzp_ = context.Operators.Interval(qzzzzzzzzn_, qzzzzzzzzo_, false, false);
                                int? qzzzzzzzzs_ = context.Operators.IndexOf<CqlInterval<CqlDate>>(qzzzzzzzzi_, sortedCovering);
                                int? qzzzzzzzzt_ = context.Operators.Subtract(qzzzzzzzzs_, 1);
                                CqlInterval<CqlDate> qzzzzzzzzu_ = context.Operators.Indexer<CqlInterval<CqlDate>>(qzzzzzzzzi_, qzzzzzzzzt_);
                                CqlInterval<CqlDate> qzzzzzzzzv_ = context.Operators.Except(qzzzzzzzzp_, qzzzzzzzzu_);
                                CqlInterval<CqlDate> qzzzzzzzzw_ = context.Operators.Except(qzzzzzzzzv_, sortedCovering);

                                return qzzzzzzzzw_;
                            }
                        };

                        return pzzzzzzzzy_();
                    };
                    IEnumerable<CqlInterval<CqlDate>> pzzzzzzzzw_ = context.Operators.Select<CqlInterval<CqlDate>, CqlInterval<CqlDate>>(pzzzzzzzzu_, pzzzzzzzzv_);
                    IEnumerable<CqlInterval<CqlDate>> pzzzzzzzzx_ = context.Operators.Distinct<CqlInterval<CqlDate>>(pzzzzzzzzw_);

                    return pzzzzzzzzx_;
                }
            };
            IEnumerable<CqlInterval<CqlDate>> pzzzzzzzzi_()
            {
                bool qzzzzzzzzx_()
                {
                    IEnumerable<CqlInterval<CqlDate>> qzzzzzzzzy_ = variableDeclarations?.sortedCoverings;
                    int? qzzzzzzzzz_ = context.Operators.Count<CqlInterval<CqlDate>>(qzzzzzzzzy_);
                    bool? rzzzzzzzza_ = context.Operators.Equal(qzzzzzzzzz_, 0);

                    return rzzzzzzzza_ ?? false;
                };
                if (qzzzzzzzzx_())
                {
                    CqlInterval<CqlDate>[] rzzzzzzzzb_ = []
;

                    return rzzzzzzzzb_ as IEnumerable<CqlInterval<CqlDate>>;
                }
                else
                {
                    IEnumerable<CqlInterval<CqlDate>> rzzzzzzzzc_ = variableDeclarations?.sortedCoverings;
                    CqlInterval<CqlDate> rzzzzzzzzd_ = context.Operators.Last<CqlInterval<CqlDate>>(rzzzzzzzzc_);
                    CqlDate rzzzzzzzze_ = context.Operators.Start(rzzzzzzzzd_);
                    CqlDate rzzzzzzzzf_ = context.Operators.End(baseInterval);
                    CqlInterval<CqlDate> rzzzzzzzzg_ = context.Operators.Interval(rzzzzzzzze_, rzzzzzzzzf_, false, true);
                    CqlInterval<CqlDate> rzzzzzzzzi_ = context.Operators.Last<CqlInterval<CqlDate>>(rzzzzzzzzc_);
                    CqlInterval<CqlDate> rzzzzzzzzj_ = context.Operators.Except(rzzzzzzzzg_, rzzzzzzzzi_);
                    CqlInterval<CqlDate> rzzzzzzzzk_ = context.Operators.Intersect<CqlDate>(rzzzzzzzzj_, baseInterval);
                    CqlInterval<CqlDate>[] rzzzzzzzzl_ = [
                        rzzzzzzzzk_,
                    ];

                    return rzzzzzzzzl_ as IEnumerable<CqlInterval<CqlDate>>;
                }
            };
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> frontgaps, IEnumerable<CqlInterval<CqlDate>> endgap)? pzzzzzzzzj_ = (CqlTupleMetadata_FKcLSALRMRfDigEFaJgDOPFRK, pzzzzzzzzh_(), pzzzzzzzzi_());
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> frontgaps, IEnumerable<CqlInterval<CqlDate>> endgap)?[] pzzzzzzzzk_ = [
                pzzzzzzzzj_,
            ];
            IEnumerable<CqlInterval<CqlDate>> pzzzzzzzzl_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> frontgaps, IEnumerable<CqlInterval<CqlDate>> endgap)? calculations)
            {
                IEnumerable<CqlInterval<CqlDate>> rzzzzzzzzm_ = calculations?.frontgaps;
                IEnumerable<CqlInterval<CqlDate>> rzzzzzzzzn_ = calculations?.endgap;
                IEnumerable<CqlInterval<CqlDate>> rzzzzzzzzo_ = context.Operators.Union<CqlInterval<CqlDate>>(rzzzzzzzzm_, rzzzzzzzzn_);
                IEnumerable<CqlInterval<CqlDate>> rzzzzzzzzp_ = this.Collapse_Date_Interval_Workaround(context, rzzzzzzzzo_);

                return rzzzzzzzzp_;
            };
            IEnumerable<IEnumerable<CqlInterval<CqlDate>>> pzzzzzzzzm_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> frontgaps, IEnumerable<CqlInterval<CqlDate>> endgap)?, IEnumerable<CqlInterval<CqlDate>>>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> frontgaps, IEnumerable<CqlInterval<CqlDate>> endgap)?>)pzzzzzzzzk_, pzzzzzzzzl_);
            IEnumerable<IEnumerable<CqlInterval<CqlDate>>> pzzzzzzzzn_ = context.Operators.Distinct<IEnumerable<CqlInterval<CqlDate>>>(pzzzzzzzzm_);
            IEnumerable<CqlInterval<CqlDate>> pzzzzzzzzo_ = context.Operators.SingletonFrom<IEnumerable<CqlInterval<CqlDate>>>(pzzzzzzzzn_);

            return pzzzzzzzzo_;
        };
        IEnumerable<IEnumerable<CqlInterval<CqlDate>>> pzzzzzzzze_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> sortedCoverings)?, IEnumerable<CqlInterval<CqlDate>>>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> sortedCoverings)?>)pzzzzzzzzc_, pzzzzzzzzd_);
        IEnumerable<IEnumerable<CqlInterval<CqlDate>>> pzzzzzzzzf_ = context.Operators.Distinct<IEnumerable<CqlInterval<CqlDate>>>(pzzzzzzzze_);
        IEnumerable<CqlInterval<CqlDate>> pzzzzzzzzg_ = context.Operators.SingletonFrom<IEnumerable<CqlInterval<CqlDate>>>(pzzzzzzzzf_);

        return pzzzzzzzzg_;
    }


    [CqlExpressionDefinition("DateTime Interval Gaps Relative to Base Interval")]
    public IEnumerable<CqlInterval<CqlDateTime>> DateTime_Interval_Gaps_Relative_to_Base_Interval(CqlContext context, CqlInterval<CqlDateTime> baseInterval, IEnumerable<CqlInterval<CqlDateTime>> coveringIntervals)
    {
        IEnumerable<CqlInterval<CqlDateTime>> rzzzzzzzzq_ = this.DateTime_Interval_Covering_Relative_to_Base_Interval(context, baseInterval, coveringIntervals);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> sortedCoverings)? rzzzzzzzzr_ = (CqlTupleMetadata_EdgSWaTaCbLYLJceGdIcWOLHd, rzzzzzzzzq_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> sortedCoverings)?[] rzzzzzzzzs_ = [
            rzzzzzzzzr_,
        ];
        IEnumerable<CqlInterval<CqlDateTime>> rzzzzzzzzt_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> sortedCoverings)? variableDeclarations)
        {
            IEnumerable<CqlInterval<CqlDateTime>> rzzzzzzzzx_()
            {
                bool szzzzzzzzf_()
                {
                    IEnumerable<CqlInterval<CqlDateTime>> szzzzzzzzg_ = variableDeclarations?.sortedCoverings;
                    int? szzzzzzzzh_ = context.Operators.Count<CqlInterval<CqlDateTime>>(szzzzzzzzg_);
                    bool? szzzzzzzzi_ = context.Operators.Equal(szzzzzzzzh_, 0);

                    return szzzzzzzzi_ ?? false;
                };
                if (szzzzzzzzf_())
                {
                    CqlInterval<CqlDateTime>[] szzzzzzzzj_ = [
                        baseInterval,
                    ];

                    return szzzzzzzzj_ as IEnumerable<CqlInterval<CqlDateTime>>;
                }
                else
                {
                    IEnumerable<CqlInterval<CqlDateTime>> szzzzzzzzk_ = variableDeclarations?.sortedCoverings;
                    CqlInterval<CqlDateTime> szzzzzzzzl_(CqlInterval<CqlDateTime> sortedCovering)
                    {
                        CqlInterval<CqlDateTime> szzzzzzzzo_()
                        {
                            bool szzzzzzzzp_()
                            {
                                IEnumerable<CqlInterval<CqlDateTime>> szzzzzzzzq_ = variableDeclarations?.sortedCoverings;
                                int? szzzzzzzzr_ = context.Operators.IndexOf<CqlInterval<CqlDateTime>>(szzzzzzzzq_, sortedCovering);
                                bool? szzzzzzzzs_ = context.Operators.Equal(szzzzzzzzr_, 0);

                                return szzzzzzzzs_ ?? false;
                            };
                            if (szzzzzzzzp_())
                            {
                                CqlDateTime szzzzzzzzt_ = context.Operators.Start(baseInterval);
                                CqlDateTime szzzzzzzzu_ = context.Operators.Start(sortedCovering);
                                CqlInterval<CqlDateTime> szzzzzzzzv_ = context.Operators.Interval(szzzzzzzzt_, szzzzzzzzu_, true, true);
                                CqlInterval<CqlDateTime> szzzzzzzzw_ = context.Operators.Intersect<CqlDateTime>(szzzzzzzzv_, baseInterval);
                                CqlInterval<CqlDateTime> szzzzzzzzx_ = context.Operators.Except(szzzzzzzzw_, sortedCovering);

                                return szzzzzzzzx_;
                            }
                            else
                            {
                                IEnumerable<CqlInterval<CqlDateTime>> szzzzzzzzy_ = variableDeclarations?.sortedCoverings;
                                int? tzzzzzzzza_ = context.Operators.IndexOf<CqlInterval<CqlDateTime>>(szzzzzzzzy_, sortedCovering);
                                int? tzzzzzzzzb_ = context.Operators.Subtract(tzzzzzzzza_, 1);
                                CqlInterval<CqlDateTime> tzzzzzzzzc_ = context.Operators.Indexer<CqlInterval<CqlDateTime>>(szzzzzzzzy_, tzzzzzzzzb_);
                                CqlDateTime tzzzzzzzzd_ = context.Operators.Start(tzzzzzzzzc_);
                                CqlDateTime tzzzzzzzze_ = context.Operators.End(sortedCovering);
                                CqlInterval<CqlDateTime> tzzzzzzzzf_ = context.Operators.Interval(tzzzzzzzzd_, tzzzzzzzze_, false, false);
                                int? tzzzzzzzzi_ = context.Operators.IndexOf<CqlInterval<CqlDateTime>>(szzzzzzzzy_, sortedCovering);
                                int? tzzzzzzzzj_ = context.Operators.Subtract(tzzzzzzzzi_, 1);
                                CqlInterval<CqlDateTime> tzzzzzzzzk_ = context.Operators.Indexer<CqlInterval<CqlDateTime>>(szzzzzzzzy_, tzzzzzzzzj_);
                                CqlInterval<CqlDateTime> tzzzzzzzzl_ = context.Operators.Except(tzzzzzzzzf_, tzzzzzzzzk_);
                                CqlInterval<CqlDateTime> tzzzzzzzzm_ = context.Operators.Except(tzzzzzzzzl_, sortedCovering);

                                return tzzzzzzzzm_;
                            }
                        };

                        return szzzzzzzzo_();
                    };
                    IEnumerable<CqlInterval<CqlDateTime>> szzzzzzzzm_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(szzzzzzzzk_, szzzzzzzzl_);
                    IEnumerable<CqlInterval<CqlDateTime>> szzzzzzzzn_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(szzzzzzzzm_);

                    return szzzzzzzzn_;
                }
            };
            IEnumerable<CqlInterval<CqlDateTime>> rzzzzzzzzy_()
            {
                bool tzzzzzzzzn_()
                {
                    IEnumerable<CqlInterval<CqlDateTime>> tzzzzzzzzo_ = variableDeclarations?.sortedCoverings;
                    int? tzzzzzzzzp_ = context.Operators.Count<CqlInterval<CqlDateTime>>(tzzzzzzzzo_);
                    bool? tzzzzzzzzq_ = context.Operators.Equal(tzzzzzzzzp_, 0);

                    return tzzzzzzzzq_ ?? false;
                };
                if (tzzzzzzzzn_())
                {
                    CqlInterval<CqlDateTime>[] tzzzzzzzzr_ = []
;

                    return tzzzzzzzzr_ as IEnumerable<CqlInterval<CqlDateTime>>;
                }
                else
                {
                    IEnumerable<CqlInterval<CqlDateTime>> tzzzzzzzzs_ = variableDeclarations?.sortedCoverings;
                    CqlInterval<CqlDateTime> tzzzzzzzzt_ = context.Operators.Last<CqlInterval<CqlDateTime>>(tzzzzzzzzs_);
                    CqlDateTime tzzzzzzzzu_ = context.Operators.Start(tzzzzzzzzt_);
                    CqlDateTime tzzzzzzzzv_ = context.Operators.End(baseInterval);
                    CqlInterval<CqlDateTime> tzzzzzzzzw_ = context.Operators.Interval(tzzzzzzzzu_, tzzzzzzzzv_, false, true);
                    CqlInterval<CqlDateTime> tzzzzzzzzy_ = context.Operators.Last<CqlInterval<CqlDateTime>>(tzzzzzzzzs_);
                    CqlInterval<CqlDateTime> tzzzzzzzzz_ = context.Operators.Except(tzzzzzzzzw_, tzzzzzzzzy_);
                    CqlInterval<CqlDateTime> uzzzzzzzza_ = context.Operators.Intersect<CqlDateTime>(tzzzzzzzzz_, baseInterval);
                    CqlInterval<CqlDateTime>[] uzzzzzzzzb_ = [
                        uzzzzzzzza_,
                    ];

                    return uzzzzzzzzb_ as IEnumerable<CqlInterval<CqlDateTime>>;
                }
            };
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> frontgaps, IEnumerable<CqlInterval<CqlDateTime>> endgap)? rzzzzzzzzz_ = (CqlTupleMetadata_BBLSSiNBQBGUDJaVjMDZMSAXg, rzzzzzzzzx_(), rzzzzzzzzy_());
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> frontgaps, IEnumerable<CqlInterval<CqlDateTime>> endgap)?[] szzzzzzzza_ = [
                rzzzzzzzzz_,
            ];
            IEnumerable<CqlInterval<CqlDateTime>> szzzzzzzzb_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> frontgaps, IEnumerable<CqlInterval<CqlDateTime>> endgap)? calculations)
            {
                IEnumerable<CqlInterval<CqlDateTime>> uzzzzzzzzc_ = calculations?.frontgaps;
                IEnumerable<CqlInterval<CqlDateTime>> uzzzzzzzzd_ = calculations?.endgap;
                IEnumerable<CqlInterval<CqlDateTime>> uzzzzzzzze_ = context.Operators.Union<CqlInterval<CqlDateTime>>(uzzzzzzzzc_, uzzzzzzzzd_);
                IEnumerable<CqlInterval<CqlDateTime>> uzzzzzzzzf_ = this.Collapse_DateTime_Interval_Workaround(context, uzzzzzzzze_);

                return uzzzzzzzzf_;
            };
            IEnumerable<IEnumerable<CqlInterval<CqlDateTime>>> szzzzzzzzc_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> frontgaps, IEnumerable<CqlInterval<CqlDateTime>> endgap)?, IEnumerable<CqlInterval<CqlDateTime>>>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> frontgaps, IEnumerable<CqlInterval<CqlDateTime>> endgap)?>)szzzzzzzza_, szzzzzzzzb_);
            IEnumerable<IEnumerable<CqlInterval<CqlDateTime>>> szzzzzzzzd_ = context.Operators.Distinct<IEnumerable<CqlInterval<CqlDateTime>>>(szzzzzzzzc_);
            IEnumerable<CqlInterval<CqlDateTime>> szzzzzzzze_ = context.Operators.SingletonFrom<IEnumerable<CqlInterval<CqlDateTime>>>(szzzzzzzzd_);

            return szzzzzzzze_;
        };
        IEnumerable<IEnumerable<CqlInterval<CqlDateTime>>> rzzzzzzzzu_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> sortedCoverings)?, IEnumerable<CqlInterval<CqlDateTime>>>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> sortedCoverings)?>)rzzzzzzzzs_, rzzzzzzzzt_);
        IEnumerable<IEnumerable<CqlInterval<CqlDateTime>>> rzzzzzzzzv_ = context.Operators.Distinct<IEnumerable<CqlInterval<CqlDateTime>>>(rzzzzzzzzu_);
        IEnumerable<CqlInterval<CqlDateTime>> rzzzzzzzzw_ = context.Operators.SingletonFrom<IEnumerable<CqlInterval<CqlDateTime>>>(rzzzzzzzzv_);

        return rzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Collapsed Date Interval Stats")]
    public (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? Collapsed_Date_Interval_Stats(CqlContext context, IEnumerable<CqlInterval<CqlDate>> collapsedIntervals)
    {
        int? uzzzzzzzzg_ = context.Operators.Count<CqlInterval<CqlDate>>(collapsedIntervals);
        int? uzzzzzzzzh_()
        {
            bool uzzzzzzzzl_()
            {
                int? uzzzzzzzzm_ = context.Operators.Count<CqlInterval<CqlDate>>(collapsedIntervals);
                bool? uzzzzzzzzn_ = context.Operators.Equal(uzzzzzzzzm_, 0);

                return uzzzzzzzzn_ ?? false;
            };
            if (uzzzzzzzzl_())
            {
                return 0;
            }
            else
            {
                int? uzzzzzzzzo_(CqlInterval<CqlDate> I)
                {
                    CqlDate uzzzzzzzzs_ = context.Operators.Start(I);
                    CqlDate uzzzzzzzzt_ = context.Operators.End(I);
                    int? uzzzzzzzzu_ = context.Operators.DurationBetween(uzzzzzzzzs_, uzzzzzzzzt_, "day");
                    int? uzzzzzzzzv_ = context.Operators.Add(uzzzzzzzzu_, 1);
                    int?[] uzzzzzzzzw_ = [
                        uzzzzzzzzv_,
                        0,
                    ];
                    int? uzzzzzzzzx_ = context.Operators.Max<int?>(uzzzzzzzzw_ as IEnumerable<int?>);

                    return uzzzzzzzzx_;
                };
                IEnumerable<int?> uzzzzzzzzp_ = context.Operators.Select<CqlInterval<CqlDate>, int?>(collapsedIntervals, uzzzzzzzzo_);
                IEnumerable<int?> uzzzzzzzzq_ = context.Operators.Distinct<int?>(uzzzzzzzzp_);
                int? uzzzzzzzzr_ = context.Operators.Sum(uzzzzzzzzq_);

                return uzzzzzzzzr_;
            }
        };
        CqlInterval<CqlDate> uzzzzzzzzi_()
        {
            bool uzzzzzzzzy_()
            {
                int? uzzzzzzzzz_ = context.Operators.Count<CqlInterval<CqlDate>>(collapsedIntervals);
                bool? vzzzzzzzza_ = context.Operators.Equal(uzzzzzzzzz_, 0);

                return vzzzzzzzza_ ?? false;
            };
            if (uzzzzzzzzy_())
            {
                return null as CqlInterval<CqlDate>;
            }
            else
            {
                (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? vzzzzzzzzb_(CqlInterval<CqlDate> I)
                {
                    CqlDate vzzzzzzzzi_ = context.Operators.Start(I);
                    CqlDate vzzzzzzzzj_ = context.Operators.End(I);
                    int? vzzzzzzzzk_ = context.Operators.DurationBetween(vzzzzzzzzi_, vzzzzzzzzj_, "day");
                    int? vzzzzzzzzl_ = context.Operators.Add(vzzzzzzzzk_, 1);
                    int?[] vzzzzzzzzm_ = [
                        vzzzzzzzzl_,
                        0,
                    ];
                    int? vzzzzzzzzn_ = context.Operators.Max<int?>(vzzzzzzzzm_ as IEnumerable<int?>);
                    (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? vzzzzzzzzo_ = (CqlTupleMetadata_HEjPGjPEhLgQPGjROeWMgiGfC, I, vzzzzzzzzn_);

                    return vzzzzzzzzo_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> vzzzzzzzzc_ = context.Operators.Select<CqlInterval<CqlDate>, (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(collapsedIntervals, vzzzzzzzzb_);
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> vzzzzzzzzd_ = context.Operators.Distinct<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(vzzzzzzzzc_);
                object vzzzzzzzze_((CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? @this)
                {
                    int? vzzzzzzzzp_ = @this?.days;

                    return vzzzzzzzzp_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> vzzzzzzzzf_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(vzzzzzzzzd_, vzzzzzzzze_, System.ComponentModel.ListSortDirection.Descending);
                (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? vzzzzzzzzg_ = context.Operators.First<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(vzzzzzzzzf_);
                CqlInterval<CqlDate> vzzzzzzzzh_ = vzzzzzzzzg_?.interval;

                return vzzzzzzzzh_;
            }
        };
        int? uzzzzzzzzj_()
        {
            bool vzzzzzzzzq_()
            {
                int? vzzzzzzzzr_ = context.Operators.Count<CqlInterval<CqlDate>>(collapsedIntervals);
                bool? vzzzzzzzzs_ = context.Operators.Equal(vzzzzzzzzr_, 0);

                return vzzzzzzzzs_ ?? false;
            };
            if (vzzzzzzzzq_())
            {
                return 0;
            }
            else
            {
                (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? vzzzzzzzzt_(CqlInterval<CqlDate> I)
                {
                    CqlDate wzzzzzzzzn_ = context.Operators.Start(I);
                    CqlDate wzzzzzzzzo_ = context.Operators.End(I);
                    int? wzzzzzzzzp_ = context.Operators.DurationBetween(wzzzzzzzzn_, wzzzzzzzzo_, "day");
                    int? wzzzzzzzzq_ = context.Operators.Add(wzzzzzzzzp_, 1);
                    int?[] wzzzzzzzzr_ = [
                        wzzzzzzzzq_,
                        0,
                    ];
                    int? wzzzzzzzzs_ = context.Operators.Max<int?>(wzzzzzzzzr_ as IEnumerable<int?>);
                    (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? wzzzzzzzzt_ = (CqlTupleMetadata_HEjPGjPEhLgQPGjROeWMgiGfC, I, wzzzzzzzzs_);

                    return wzzzzzzzzt_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> vzzzzzzzzu_ = context.Operators.Select<CqlInterval<CqlDate>, (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(collapsedIntervals, vzzzzzzzzt_);
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> vzzzzzzzzv_ = context.Operators.Distinct<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(vzzzzzzzzu_);
                object vzzzzzzzzw_((CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? @this)
                {
                    int? wzzzzzzzzu_ = @this?.days;

                    return wzzzzzzzzu_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> vzzzzzzzzx_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(vzzzzzzzzv_, vzzzzzzzzw_, System.ComponentModel.ListSortDirection.Descending);
                (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? vzzzzzzzzy_ = context.Operators.First<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(vzzzzzzzzx_);
                CqlInterval<CqlDate> vzzzzzzzzz_ = vzzzzzzzzy_?.interval;
                CqlDate wzzzzzzzza_ = context.Operators.Start(vzzzzzzzzz_);
                (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? wzzzzzzzzb_(CqlInterval<CqlDate> I)
                {
                    CqlDate wzzzzzzzzv_ = context.Operators.Start(I);
                    CqlDate wzzzzzzzzw_ = context.Operators.End(I);
                    int? wzzzzzzzzx_ = context.Operators.DurationBetween(wzzzzzzzzv_, wzzzzzzzzw_, "day");
                    int? wzzzzzzzzy_ = context.Operators.Add(wzzzzzzzzx_, 1);
                    int?[] wzzzzzzzzz_ = [
                        wzzzzzzzzy_,
                        0,
                    ];
                    int? xzzzzzzzza_ = context.Operators.Max<int?>(wzzzzzzzzz_ as IEnumerable<int?>);
                    (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? xzzzzzzzzb_ = (CqlTupleMetadata_HEjPGjPEhLgQPGjROeWMgiGfC, I, xzzzzzzzza_);

                    return xzzzzzzzzb_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> wzzzzzzzzc_ = context.Operators.Select<CqlInterval<CqlDate>, (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(collapsedIntervals, wzzzzzzzzb_);
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> wzzzzzzzzd_ = context.Operators.Distinct<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(wzzzzzzzzc_);
                object wzzzzzzzze_((CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? @this)
                {
                    int? xzzzzzzzzc_ = @this?.days;

                    return xzzzzzzzzc_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> wzzzzzzzzf_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(wzzzzzzzzd_, wzzzzzzzze_, System.ComponentModel.ListSortDirection.Descending);
                (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? wzzzzzzzzg_ = context.Operators.First<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(wzzzzzzzzf_);
                CqlInterval<CqlDate> wzzzzzzzzh_ = wzzzzzzzzg_?.interval;
                CqlDate wzzzzzzzzi_ = context.Operators.End(wzzzzzzzzh_);
                int? wzzzzzzzzj_ = context.Operators.DurationBetween(wzzzzzzzza_, wzzzzzzzzi_, "day");
                int? wzzzzzzzzk_ = context.Operators.Add(wzzzzzzzzj_, 1);
                int?[] wzzzzzzzzl_ = [
                    wzzzzzzzzk_,
                    0,
                ];
                int? wzzzzzzzzm_ = context.Operators.Max<int?>(wzzzzzzzzl_ as IEnumerable<int?>);

                return wzzzzzzzzm_;
            }
        };
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? uzzzzzzzzk_ = (CqlTupleMetadata_HRbPDRZiOGGBceePOZWjVbXdP, collapsedIntervals, uzzzzzzzzg_, uzzzzzzzzh_(), uzzzzzzzzi_(), uzzzzzzzzj_());

        return uzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Date Interval Covering Relative to Base Interval Stats")]
    public (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? Date_Interval_Covering_Relative_to_Base_Interval_Stats(CqlContext context, CqlInterval<CqlDate> baseInterval, IEnumerable<CqlInterval<CqlDate>> coveringIntervals)
    {
        IEnumerable<CqlInterval<CqlDate>> xzzzzzzzzd_ = this.Date_Interval_Covering_Relative_to_Base_Interval(context, baseInterval, coveringIntervals);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Covering_Intervals)? xzzzzzzzze_ = (CqlTupleMetadata_DUiZjXRKgCPYVZQJbFVDKNMOi, xzzzzzzzzd_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Covering_Intervals)?[] xzzzzzzzzf_ = [
            xzzzzzzzze_,
        ];
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? xzzzzzzzzg_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Covering_Intervals)? variableDeclarations)
        {
            IEnumerable<CqlInterval<CqlDate>> xzzzzzzzzk_ = variableDeclarations?.Covering_Intervals;
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? xzzzzzzzzl_ = this.Collapsed_Date_Interval_Stats(context, xzzzzzzzzk_);

            return xzzzzzzzzl_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?> xzzzzzzzzh_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Covering_Intervals)?, (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Covering_Intervals)?>)xzzzzzzzzf_, xzzzzzzzzg_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?> xzzzzzzzzi_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>(xzzzzzzzzh_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? xzzzzzzzzj_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>(xzzzzzzzzi_);

        return xzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Date Interval Gaps Relative to Base Interval Stats")]
    public (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? Date_Interval_Gaps_Relative_to_Base_Interval_Stats(CqlContext context, CqlInterval<CqlDate> baseInterval, IEnumerable<CqlInterval<CqlDate>> coveringIntervals)
    {
        IEnumerable<CqlInterval<CqlDate>> xzzzzzzzzm_ = this.Date_Interval_Gaps_Relative_to_Base_Interval(context, baseInterval, coveringIntervals);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Gap_Intervals)? xzzzzzzzzn_ = (CqlTupleMetadata_GQPbYTYABjXFVLRKjXgcDJFSj, xzzzzzzzzm_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Gap_Intervals)?[] xzzzzzzzzo_ = [
            xzzzzzzzzn_,
        ];
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? xzzzzzzzzp_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Gap_Intervals)? variableDeclarations)
        {
            IEnumerable<CqlInterval<CqlDate>> xzzzzzzzzt_ = variableDeclarations?.Gap_Intervals;
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? xzzzzzzzzu_ = this.Collapsed_Date_Interval_Stats(context, xzzzzzzzzt_);

            return xzzzzzzzzu_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?> xzzzzzzzzq_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Gap_Intervals)?, (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Gap_Intervals)?>)xzzzzzzzzo_, xzzzzzzzzp_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?> xzzzzzzzzr_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>(xzzzzzzzzq_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? xzzzzzzzzs_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>(xzzzzzzzzr_);

        return xzzzzzzzzs_;
    }


    [CqlExpressionDefinition("DateTime Interval Set Nulls to Zero")]
    public CqlInterval<CqlDateTime> DateTime_Interval_Set_Nulls_to_Zero(CqlContext context, CqlInterval<CqlDateTime> interval)
    {
        CqlDateTime xzzzzzzzzv_ = context.Operators.Start(interval);
        int? xzzzzzzzzw_ = context.Operators.DateTimeComponentFrom(xzzzzzzzzv_, "year");
        int? xzzzzzzzzx_()
        {
            bool yzzzzzzzzr_()
            {
                CqlDateTime yzzzzzzzzs_ = context.Operators.Start(interval);
                int? yzzzzzzzzt_ = context.Operators.DateTimeComponentFrom(yzzzzzzzzs_, "month");

                return yzzzzzzzzt_ is null;
            };
            if (yzzzzzzzzr_())
            {
                return 0;
            }
            else
            {
                CqlDateTime yzzzzzzzzu_ = context.Operators.Start(interval);
                int? yzzzzzzzzv_ = context.Operators.DateTimeComponentFrom(yzzzzzzzzu_, "month");

                return yzzzzzzzzv_;
            }
        };
        int? xzzzzzzzzy_()
        {
            bool yzzzzzzzzw_()
            {
                CqlDateTime yzzzzzzzzx_ = context.Operators.Start(interval);
                int? yzzzzzzzzy_ = context.Operators.DateTimeComponentFrom(yzzzzzzzzx_, "day");

                return yzzzzzzzzy_ is null;
            };
            if (yzzzzzzzzw_())
            {
                return 0;
            }
            else
            {
                CqlDateTime yzzzzzzzzz_ = context.Operators.Start(interval);
                int? zzzzzzzzza_ = context.Operators.DateTimeComponentFrom(yzzzzzzzzz_, "day");

                return zzzzzzzzza_;
            }
        };
        int? xzzzzzzzzz_()
        {
            bool zzzzzzzzzb_()
            {
                CqlDateTime zzzzzzzzzc_ = context.Operators.Start(interval);
                int? zzzzzzzzzd_ = context.Operators.DateTimeComponentFrom(zzzzzzzzzc_, "hour");

                return zzzzzzzzzd_ is null;
            };
            if (zzzzzzzzzb_())
            {
                return 0;
            }
            else
            {
                CqlDateTime zzzzzzzzze_ = context.Operators.Start(interval);
                int? zzzzzzzzzf_ = context.Operators.DateTimeComponentFrom(zzzzzzzzze_, "hour");

                return zzzzzzzzzf_;
            }
        };
        int? yzzzzzzzza_()
        {
            bool zzzzzzzzzg_()
            {
                CqlDateTime zzzzzzzzzh_ = context.Operators.Start(interval);
                int? zzzzzzzzzi_ = context.Operators.DateTimeComponentFrom(zzzzzzzzzh_, "minute");

                return zzzzzzzzzi_ is null;
            };
            if (zzzzzzzzzg_())
            {
                return 0;
            }
            else
            {
                CqlDateTime zzzzzzzzzj_ = context.Operators.Start(interval);
                int? zzzzzzzzzk_ = context.Operators.DateTimeComponentFrom(zzzzzzzzzj_, "minute");

                return zzzzzzzzzk_;
            }
        };
        int? yzzzzzzzzb_()
        {
            bool zzzzzzzzzl_()
            {
                CqlDateTime zzzzzzzzzm_ = context.Operators.Start(interval);
                int? zzzzzzzzzn_ = context.Operators.DateTimeComponentFrom(zzzzzzzzzm_, "second");

                return zzzzzzzzzn_ is null;
            };
            if (zzzzzzzzzl_())
            {
                return 0;
            }
            else
            {
                CqlDateTime zzzzzzzzzo_ = context.Operators.Start(interval);
                int? zzzzzzzzzp_ = context.Operators.DateTimeComponentFrom(zzzzzzzzzo_, "second");

                return zzzzzzzzzp_;
            }
        };
        int? yzzzzzzzzc_()
        {
            bool zzzzzzzzzq_()
            {
                CqlDateTime zzzzzzzzzr_ = context.Operators.Start(interval);
                int? zzzzzzzzzs_ = context.Operators.DateTimeComponentFrom(zzzzzzzzzr_, "millisecond");

                return zzzzzzzzzs_ is null;
            };
            if (zzzzzzzzzq_())
            {
                return 0;
            }
            else
            {
                CqlDateTime zzzzzzzzzt_ = context.Operators.Start(interval);
                int? zzzzzzzzzu_ = context.Operators.DateTimeComponentFrom(zzzzzzzzzt_, "millisecond");

                return zzzzzzzzzu_;
            }
        };
        CqlDateTime yzzzzzzzzd_ = context.Operators.End(interval);
        int? yzzzzzzzze_ = context.Operators.DateTimeComponentFrom(yzzzzzzzzd_, "year");
        int? yzzzzzzzzf_()
        {
            bool zzzzzzzzzv_()
            {
                CqlDateTime zzzzzzzzzw_ = context.Operators.End(interval);
                int? zzzzzzzzzx_ = context.Operators.DateTimeComponentFrom(zzzzzzzzzw_, "month");

                return zzzzzzzzzx_ is null;
            };
            if (zzzzzzzzzv_())
            {
                return 0;
            }
            else
            {
                CqlDateTime zzzzzzzzzy_ = context.Operators.End(interval);
                int? zzzzzzzzzz_ = context.Operators.DateTimeComponentFrom(zzzzzzzzzy_, "month");

                return zzzzzzzzzz_;
            }
        };
        int? yzzzzzzzzg_()
        {
            bool azzzzzzzzza_()
            {
                CqlDateTime azzzzzzzzzb_ = context.Operators.End(interval);
                int? azzzzzzzzzc_ = context.Operators.DateTimeComponentFrom(azzzzzzzzzb_, "day");

                return azzzzzzzzzc_ is null;
            };
            if (azzzzzzzzza_())
            {
                return 0;
            }
            else
            {
                CqlDateTime azzzzzzzzzd_ = context.Operators.End(interval);
                int? azzzzzzzzze_ = context.Operators.DateTimeComponentFrom(azzzzzzzzzd_, "day");

                return azzzzzzzzze_;
            }
        };
        int? yzzzzzzzzh_()
        {
            bool azzzzzzzzzf_()
            {
                CqlDateTime azzzzzzzzzg_ = context.Operators.End(interval);
                int? azzzzzzzzzh_ = context.Operators.DateTimeComponentFrom(azzzzzzzzzg_, "hour");

                return azzzzzzzzzh_ is null;
            };
            if (azzzzzzzzzf_())
            {
                return 0;
            }
            else
            {
                CqlDateTime azzzzzzzzzi_ = context.Operators.End(interval);
                int? azzzzzzzzzj_ = context.Operators.DateTimeComponentFrom(azzzzzzzzzi_, "hour");

                return azzzzzzzzzj_;
            }
        };
        int? yzzzzzzzzi_()
        {
            bool azzzzzzzzzk_()
            {
                CqlDateTime azzzzzzzzzl_ = context.Operators.End(interval);
                int? azzzzzzzzzm_ = context.Operators.DateTimeComponentFrom(azzzzzzzzzl_, "minute");

                return azzzzzzzzzm_ is null;
            };
            if (azzzzzzzzzk_())
            {
                return 0;
            }
            else
            {
                CqlDateTime azzzzzzzzzn_ = context.Operators.End(interval);
                int? azzzzzzzzzo_ = context.Operators.DateTimeComponentFrom(azzzzzzzzzn_, "minute");

                return azzzzzzzzzo_;
            }
        };
        int? yzzzzzzzzj_()
        {
            bool azzzzzzzzzp_()
            {
                CqlDateTime azzzzzzzzzq_ = context.Operators.End(interval);
                int? azzzzzzzzzr_ = context.Operators.DateTimeComponentFrom(azzzzzzzzzq_, "second");

                return azzzzzzzzzr_ is null;
            };
            if (azzzzzzzzzp_())
            {
                return 0;
            }
            else
            {
                CqlDateTime azzzzzzzzzs_ = context.Operators.End(interval);
                int? azzzzzzzzzt_ = context.Operators.DateTimeComponentFrom(azzzzzzzzzs_, "second");

                return azzzzzzzzzt_;
            }
        };
        int? yzzzzzzzzk_()
        {
            bool azzzzzzzzzu_()
            {
                CqlDateTime azzzzzzzzzv_ = context.Operators.End(interval);
                int? azzzzzzzzzw_ = context.Operators.DateTimeComponentFrom(azzzzzzzzzv_, "millisecond");

                return azzzzzzzzzw_ is null;
            };
            if (azzzzzzzzzu_())
            {
                return 0;
            }
            else
            {
                CqlDateTime azzzzzzzzzx_ = context.Operators.End(interval);
                int? azzzzzzzzzy_ = context.Operators.DateTimeComponentFrom(azzzzzzzzzx_, "millisecond");

                return azzzzzzzzzy_;
            }
        };
        (CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)? yzzzzzzzzl_ = (CqlTupleMetadata_FcQREFSfPJSKYAhSEWVJcZVED, xzzzzzzzzw_, xzzzzzzzzx_(), xzzzzzzzzy_(), xzzzzzzzzz_(), yzzzzzzzza_(), yzzzzzzzzb_(), yzzzzzzzzc_(), yzzzzzzzze_, yzzzzzzzzf_(), yzzzzzzzzg_(), yzzzzzzzzh_(), yzzzzzzzzi_(), yzzzzzzzzj_(), yzzzzzzzzk_());
        (CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)?[] yzzzzzzzzm_ = [
            yzzzzzzzzl_,
        ];
        CqlInterval<CqlDateTime> yzzzzzzzzn_((CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)? i)
        {
            int? azzzzzzzzzz_ = i?.StartYear;
            int? bzzzzzzzzza_ = i?.StartMonth;
            int? bzzzzzzzzzb_ = i?.StartDay;
            int? bzzzzzzzzzc_ = i?.StartHour;
            int? bzzzzzzzzzd_ = i?.StartMinute;
            int? bzzzzzzzzze_ = i?.StartSecond;
            int? bzzzzzzzzzf_ = i?.StartMillisecond;
            CqlDateTime bzzzzzzzzzg_ = context.Operators.DateTime(azzzzzzzzzz_, bzzzzzzzzza_, bzzzzzzzzzb_, bzzzzzzzzzc_, bzzzzzzzzzd_, bzzzzzzzzze_, bzzzzzzzzzf_, default);
            int? bzzzzzzzzzh_ = i?.EndYear;
            int? bzzzzzzzzzi_ = i?.EndMonth;
            int? bzzzzzzzzzj_ = i?.EndDay;
            int? bzzzzzzzzzk_ = i?.EndHour;
            int? bzzzzzzzzzl_ = i?.EndMinute;
            int? bzzzzzzzzzm_ = i?.EndSecond;
            int? bzzzzzzzzzn_ = i?.EndMillisecond;
            CqlDateTime bzzzzzzzzzo_ = context.Operators.DateTime(bzzzzzzzzzh_, bzzzzzzzzzi_, bzzzzzzzzzj_, bzzzzzzzzzk_, bzzzzzzzzzl_, bzzzzzzzzzm_, bzzzzzzzzzn_, default);
            CqlInterval<CqlDateTime> bzzzzzzzzzp_ = context.Operators.Interval(bzzzzzzzzzg_, bzzzzzzzzzo_, true, true);

            return bzzzzzzzzzp_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> yzzzzzzzzo_ = context.Operators.Select<(CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)?, CqlInterval<CqlDateTime>>((IEnumerable<(CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)?>)yzzzzzzzzm_, yzzzzzzzzn_);
        IEnumerable<CqlInterval<CqlDateTime>> yzzzzzzzzp_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(yzzzzzzzzo_);
        CqlInterval<CqlDateTime> yzzzzzzzzq_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(yzzzzzzzzp_);

        return yzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Collapsed DateTime Interval Stats")]
    public (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? Collapsed_DateTime_Interval_Stats(CqlContext context, IEnumerable<CqlInterval<CqlDateTime>> collapsedIntervals)
    {
        int? bzzzzzzzzzq_ = context.Operators.Count<CqlInterval<CqlDateTime>>(collapsedIntervals);
        int? bzzzzzzzzzr_()
        {
            bool bzzzzzzzzzv_()
            {
                int? bzzzzzzzzzw_ = context.Operators.Count<CqlInterval<CqlDateTime>>(collapsedIntervals);
                bool? bzzzzzzzzzx_ = context.Operators.Equal(bzzzzzzzzzw_, 0);

                return bzzzzzzzzzx_ ?? false;
            };
            if (bzzzzzzzzzv_())
            {
                return 0;
            }
            else
            {
                int? bzzzzzzzzzy_(CqlInterval<CqlDateTime> I)
                {
                    CqlInterval<CqlDateTime> czzzzzzzzzc_ = this.DateTime_Interval_Set_Nulls_to_Zero(context, I);
                    CqlDateTime czzzzzzzzzd_ = context.Operators.Start(czzzzzzzzzc_);
                    CqlDateTime czzzzzzzzzf_ = context.Operators.End(czzzzzzzzzc_);
                    int? czzzzzzzzzg_ = context.Operators.DurationBetween(czzzzzzzzzd_, czzzzzzzzzf_, "day");
                    int? czzzzzzzzzh_ = context.Operators.Add(czzzzzzzzzg_, 1);
                    int?[] czzzzzzzzzi_ = [
                        czzzzzzzzzh_,
                        0,
                    ];
                    int? czzzzzzzzzj_ = context.Operators.Max<int?>(czzzzzzzzzi_ as IEnumerable<int?>);

                    return czzzzzzzzzj_;
                };
                IEnumerable<int?> bzzzzzzzzzz_ = context.Operators.Select<CqlInterval<CqlDateTime>, int?>(collapsedIntervals, bzzzzzzzzzy_);
                IEnumerable<int?> czzzzzzzzza_ = context.Operators.Distinct<int?>(bzzzzzzzzzz_);
                int? czzzzzzzzzb_ = context.Operators.Sum(czzzzzzzzza_);

                return czzzzzzzzzb_;
            }
        };
        CqlInterval<CqlDateTime> bzzzzzzzzzs_()
        {
            bool czzzzzzzzzk_()
            {
                int? czzzzzzzzzl_ = context.Operators.Count<CqlInterval<CqlDateTime>>(collapsedIntervals);
                bool? czzzzzzzzzm_ = context.Operators.Equal(czzzzzzzzzl_, 0);

                return czzzzzzzzzm_ ?? false;
            };
            if (czzzzzzzzzk_())
            {
                return null as CqlInterval<CqlDateTime>;
            }
            else
            {
                (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? czzzzzzzzzn_(CqlInterval<CqlDateTime> I)
                {
                    CqlInterval<CqlDateTime> czzzzzzzzzu_ = this.DateTime_Interval_Set_Nulls_to_Zero(context, I);
                    CqlDateTime czzzzzzzzzv_ = context.Operators.Start(czzzzzzzzzu_);
                    CqlDateTime czzzzzzzzzx_ = context.Operators.End(czzzzzzzzzu_);
                    int? czzzzzzzzzy_ = context.Operators.DurationBetween(czzzzzzzzzv_, czzzzzzzzzx_, "day");
                    int? czzzzzzzzzz_ = context.Operators.Add(czzzzzzzzzy_, 1);
                    int?[] dzzzzzzzzza_ = [
                        czzzzzzzzzz_,
                        0,
                    ];
                    int? dzzzzzzzzzb_ = context.Operators.Max<int?>(dzzzzzzzzza_ as IEnumerable<int?>);
                    (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? dzzzzzzzzzc_ = (CqlTupleMetadata_CGHEUIgjaCjJVKEADTSZEbdCL, I, dzzzzzzzzzb_);

                    return dzzzzzzzzzc_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> czzzzzzzzzo_ = context.Operators.Select<CqlInterval<CqlDateTime>, (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(collapsedIntervals, czzzzzzzzzn_);
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> czzzzzzzzzp_ = context.Operators.Distinct<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(czzzzzzzzzo_);
                object czzzzzzzzzq_((CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? @this)
                {
                    int? dzzzzzzzzzd_ = @this?.days;

                    return dzzzzzzzzzd_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> czzzzzzzzzr_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(czzzzzzzzzp_, czzzzzzzzzq_, System.ComponentModel.ListSortDirection.Descending);
                (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? czzzzzzzzzs_ = context.Operators.First<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(czzzzzzzzzr_);
                CqlInterval<CqlDateTime> czzzzzzzzzt_ = czzzzzzzzzs_?.interval;

                return czzzzzzzzzt_;
            }
        };
        int? bzzzzzzzzzt_()
        {
            bool dzzzzzzzzze_()
            {
                int? dzzzzzzzzzf_ = context.Operators.Count<CqlInterval<CqlDateTime>>(collapsedIntervals);
                bool? dzzzzzzzzzg_ = context.Operators.Equal(dzzzzzzzzzf_, 0);

                return dzzzzzzzzzg_ ?? false;
            };
            if (dzzzzzzzzze_())
            {
                return 0;
            }
            else
            {
                (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? dzzzzzzzzzh_(CqlInterval<CqlDateTime> I)
                {
                    CqlInterval<CqlDateTime> ezzzzzzzzzd_ = this.DateTime_Interval_Set_Nulls_to_Zero(context, I);
                    CqlDateTime ezzzzzzzzze_ = context.Operators.Start(ezzzzzzzzzd_);
                    CqlDateTime ezzzzzzzzzg_ = context.Operators.End(ezzzzzzzzzd_);
                    int? ezzzzzzzzzh_ = context.Operators.DurationBetween(ezzzzzzzzze_, ezzzzzzzzzg_, "day");
                    int? ezzzzzzzzzi_ = context.Operators.Add(ezzzzzzzzzh_, 1);
                    int?[] ezzzzzzzzzj_ = [
                        ezzzzzzzzzi_,
                        0,
                    ];
                    int? ezzzzzzzzzk_ = context.Operators.Max<int?>(ezzzzzzzzzj_ as IEnumerable<int?>);
                    (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? ezzzzzzzzzl_ = (CqlTupleMetadata_CGHEUIgjaCjJVKEADTSZEbdCL, I, ezzzzzzzzzk_);

                    return ezzzzzzzzzl_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> dzzzzzzzzzi_ = context.Operators.Select<CqlInterval<CqlDateTime>, (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(collapsedIntervals, dzzzzzzzzzh_);
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> dzzzzzzzzzj_ = context.Operators.Distinct<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(dzzzzzzzzzi_);
                object dzzzzzzzzzk_((CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? @this)
                {
                    int? ezzzzzzzzzm_ = @this?.days;

                    return ezzzzzzzzzm_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> dzzzzzzzzzl_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(dzzzzzzzzzj_, dzzzzzzzzzk_, System.ComponentModel.ListSortDirection.Descending);
                (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? dzzzzzzzzzm_ = context.Operators.First<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(dzzzzzzzzzl_);
                CqlInterval<CqlDateTime> dzzzzzzzzzn_ = dzzzzzzzzzm_?.interval;
                CqlInterval<CqlDateTime> dzzzzzzzzzo_ = this.DateTime_Interval_Set_Nulls_to_Zero(context, dzzzzzzzzzn_);
                CqlDateTime dzzzzzzzzzp_ = context.Operators.Start(dzzzzzzzzzo_);
                (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? dzzzzzzzzzq_(CqlInterval<CqlDateTime> I)
                {
                    CqlInterval<CqlDateTime> ezzzzzzzzzn_ = this.DateTime_Interval_Set_Nulls_to_Zero(context, I);
                    CqlDateTime ezzzzzzzzzo_ = context.Operators.Start(ezzzzzzzzzn_);
                    CqlDateTime ezzzzzzzzzq_ = context.Operators.End(ezzzzzzzzzn_);
                    int? ezzzzzzzzzr_ = context.Operators.DurationBetween(ezzzzzzzzzo_, ezzzzzzzzzq_, "day");
                    int? ezzzzzzzzzs_ = context.Operators.Add(ezzzzzzzzzr_, 1);
                    int?[] ezzzzzzzzzt_ = [
                        ezzzzzzzzzs_,
                        0,
                    ];
                    int? ezzzzzzzzzu_ = context.Operators.Max<int?>(ezzzzzzzzzt_ as IEnumerable<int?>);
                    (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? ezzzzzzzzzv_ = (CqlTupleMetadata_CGHEUIgjaCjJVKEADTSZEbdCL, I, ezzzzzzzzzu_);

                    return ezzzzzzzzzv_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> dzzzzzzzzzr_ = context.Operators.Select<CqlInterval<CqlDateTime>, (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(collapsedIntervals, dzzzzzzzzzq_);
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> dzzzzzzzzzs_ = context.Operators.Distinct<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(dzzzzzzzzzr_);
                object dzzzzzzzzzt_((CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? @this)
                {
                    int? ezzzzzzzzzw_ = @this?.days;

                    return ezzzzzzzzzw_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> dzzzzzzzzzu_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(dzzzzzzzzzs_, dzzzzzzzzzt_, System.ComponentModel.ListSortDirection.Descending);
                (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? dzzzzzzzzzv_ = context.Operators.First<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(dzzzzzzzzzu_);
                CqlInterval<CqlDateTime> dzzzzzzzzzw_ = dzzzzzzzzzv_?.interval;
                CqlInterval<CqlDateTime> dzzzzzzzzzx_ = this.DateTime_Interval_Set_Nulls_to_Zero(context, dzzzzzzzzzw_);
                CqlDateTime dzzzzzzzzzy_ = context.Operators.End(dzzzzzzzzzx_);
                int? dzzzzzzzzzz_ = context.Operators.DurationBetween(dzzzzzzzzzp_, dzzzzzzzzzy_, "day");
                int? ezzzzzzzzza_ = context.Operators.Add(dzzzzzzzzzz_, 1);
                int?[] ezzzzzzzzzb_ = [
                    ezzzzzzzzza_,
                    0,
                ];
                int? ezzzzzzzzzc_ = context.Operators.Max<int?>(ezzzzzzzzzb_ as IEnumerable<int?>);

                return ezzzzzzzzzc_;
            }
        };
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? bzzzzzzzzzu_ = (CqlTupleMetadata_HDihbLieYfQbgeSbOWZBAMUIQ, collapsedIntervals, bzzzzzzzzzq_, bzzzzzzzzzr_(), bzzzzzzzzzs_(), bzzzzzzzzzt_());

        return bzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("DateTime Interval Covering Relative to Base Interval Stats")]
    public (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? DateTime_Interval_Covering_Relative_to_Base_Interval_Stats(CqlContext context, CqlInterval<CqlDateTime> baseInterval, IEnumerable<CqlInterval<CqlDateTime>> coveringIntervals)
    {
        IEnumerable<CqlInterval<CqlDateTime>> ezzzzzzzzzx_ = this.DateTime_Interval_Covering_Relative_to_Base_Interval(context, baseInterval, coveringIntervals);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Covering_Intervals)? ezzzzzzzzzy_ = (CqlTupleMetadata_GZMPWdGOJiTNjfWAcbZMePdXV, ezzzzzzzzzx_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Covering_Intervals)?[] ezzzzzzzzzz_ = [
            ezzzzzzzzzy_,
        ];
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? fzzzzzzzzza_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Covering_Intervals)? variableDeclarations)
        {
            IEnumerable<CqlInterval<CqlDateTime>> fzzzzzzzzze_ = variableDeclarations?.Covering_Intervals;
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? fzzzzzzzzzf_ = this.Collapsed_DateTime_Interval_Stats(context, fzzzzzzzzze_);

            return fzzzzzzzzzf_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?> fzzzzzzzzzb_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Covering_Intervals)?, (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Covering_Intervals)?>)ezzzzzzzzzz_, fzzzzzzzzza_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?> fzzzzzzzzzc_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?>(fzzzzzzzzzb_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? fzzzzzzzzzd_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?>(fzzzzzzzzzc_);

        return fzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("DateTime Interval Gaps Relative to Base Interval Stats")]
    public (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? DateTime_Interval_Gaps_Relative_to_Base_Interval_Stats(CqlContext context, CqlInterval<CqlDateTime> baseInterval, IEnumerable<CqlInterval<CqlDateTime>> coveringIntervals)
    {
        IEnumerable<CqlInterval<CqlDateTime>> fzzzzzzzzzg_ = this.DateTime_Interval_Gaps_Relative_to_Base_Interval(context, baseInterval, coveringIntervals);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Gap_Intervals)? fzzzzzzzzzh_ = (CqlTupleMetadata_CKbERRbOPGNBBERUOghhaOYSE, fzzzzzzzzzg_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Gap_Intervals)?[] fzzzzzzzzzi_ = [
            fzzzzzzzzzh_,
        ];
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? fzzzzzzzzzj_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Gap_Intervals)? variableDeclarations)
        {
            IEnumerable<CqlInterval<CqlDateTime>> fzzzzzzzzzn_ = variableDeclarations?.Gap_Intervals;
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? fzzzzzzzzzo_ = this.Collapsed_DateTime_Interval_Stats(context, fzzzzzzzzzn_);

            return fzzzzzzzzzo_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?> fzzzzzzzzzk_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Gap_Intervals)?, (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Gap_Intervals)?>)fzzzzzzzzzi_, fzzzzzzzzzj_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?> fzzzzzzzzzl_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?>(fzzzzzzzzzk_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? fzzzzzzzzzm_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?>(fzzzzzzzzzl_);

        return fzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Convert To UTC DateTime")]
    public CqlDateTime Convert_To_UTC_DateTime(CqlContext context, CqlDate d)
    {
        int? fzzzzzzzzzp_ = context.Operators.DateTimeComponentFrom(d, "year");
        int? fzzzzzzzzzq_()
        {
            if ((context.Operators.DateTimeComponentFrom(d, "month")) is null)
            {
                return 0;
            }
            else
            {
                int? fzzzzzzzzzy_ = context.Operators.DateTimeComponentFrom(d, "month");

                return fzzzzzzzzzy_;
            }
        };
        int? fzzzzzzzzzr_()
        {
            if ((context.Operators.DateTimeComponentFrom(d, "day")) is null)
            {
                return 0;
            }
            else
            {
                int? fzzzzzzzzzz_ = context.Operators.DateTimeComponentFrom(d, "day");

                return fzzzzzzzzzz_;
            }
        };
        (CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)? fzzzzzzzzzs_ = (CqlTupleMetadata_FcQREFSfPJSKYAhSEWVJcZVED, fzzzzzzzzzp_, fzzzzzzzzzq_(), fzzzzzzzzzr_(), default, default, default, default, default, default, default, default, default, default, default);
        (CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)?[] fzzzzzzzzzt_ = [
            fzzzzzzzzzs_,
        ];
        CqlDateTime fzzzzzzzzzu_((CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)? i)
        {
            int? gzzzzzzzzza_ = i?.StartYear;
            int? gzzzzzzzzzb_ = i?.StartMonth;
            int? gzzzzzzzzzc_ = i?.StartDay;
            decimal? gzzzzzzzzzd_ = context.Operators.ConvertIntegerToDecimal(0);
            CqlDateTime gzzzzzzzzze_ = context.Operators.DateTime(gzzzzzzzzza_, gzzzzzzzzzb_, gzzzzzzzzzc_, 0, 0, 0, 0, gzzzzzzzzzd_);

            return gzzzzzzzzze_;
        };
        IEnumerable<CqlDateTime> fzzzzzzzzzv_ = context.Operators.Select<(CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)?, CqlDateTime>((IEnumerable<(CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)?>)fzzzzzzzzzt_, fzzzzzzzzzu_);
        IEnumerable<CqlDateTime> fzzzzzzzzzw_ = context.Operators.Distinct<CqlDateTime>(fzzzzzzzzzv_);
        CqlDateTime fzzzzzzzzzx_ = context.Operators.SingletonFrom<CqlDateTime>(fzzzzzzzzzw_);

        return fzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Convert Interval Date to UTC Interval DateTime")]
    public CqlInterval<CqlDateTime> Convert_Interval_Date_to_UTC_Interval_DateTime(CqlContext context, CqlInterval<CqlDate> interval)
    {
        CqlDate gzzzzzzzzzf_ = context.Operators.Start(interval);
        CqlDateTime gzzzzzzzzzg_ = this.Convert_To_UTC_DateTime(context, gzzzzzzzzzf_);
        CqlDate gzzzzzzzzzh_ = context.Operators.End(interval);
        CqlDateTime gzzzzzzzzzi_ = this.Convert_To_UTC_DateTime(context, gzzzzzzzzzh_);
        CqlInterval<CqlDateTime> gzzzzzzzzzj_ = context.Operators.Interval(gzzzzzzzzzg_, gzzzzzzzzzi_, true, true);

        return gzzzzzzzzzj_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_BBLSSiNBQBGUDJaVjMDZMSAXg = new(
        [typeof(IEnumerable<CqlInterval<CqlDateTime>>), typeof(IEnumerable<CqlInterval<CqlDateTime>>)],
        ["frontgaps", "endgap"]);

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
