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
        IEnumerable<CqlInterval<CqlDate>> jzzzzzzzzzzi_()
        {
            bool jzzzzzzzzzzj_()
            {
                int? jzzzzzzzzzzk_ = context.Operators.Count<CqlInterval<CqlDate>>(intervals);
                bool? jzzzzzzzzzzl_ = context.Operators.Equal(jzzzzzzzzzzk_, 0);

                return jzzzzzzzzzzl_ ?? false;
            };
            if (intervals is null)
            {
                CqlInterval<CqlDate>[] jzzzzzzzzzzm_ = []
;

                return jzzzzzzzzzzm_ as IEnumerable<CqlInterval<CqlDate>>;
            }
            else if (jzzzzzzzzzzj_())
            {
                CqlInterval<CqlDate>[] jzzzzzzzzzzn_ = []
;

                return jzzzzzzzzzzn_ as IEnumerable<CqlInterval<CqlDate>>;
            }
            else
            {
                (CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)? jzzzzzzzzzzo_(CqlInterval<CqlDate> I)
                {
                    CqlDate jzzzzzzzzzzw_()
                    {
                        if ((context.Operators.Start(I)) is null)
                        {
                            CqlDate jzzzzzzzzzzy_ = context.Operators.MinValue<CqlDate>();

                            return jzzzzzzzzzzy_;
                        }
                        else
                        {
                            CqlDate jzzzzzzzzzzz_ = context.Operators.Start(I);

                            return jzzzzzzzzzzz_;
                        }
                    };
                    (CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)? jzzzzzzzzzzx_ = (CqlTupleMetadata_GIMHfXDcFiAjSJBDGYeUeZLhW, I, jzzzzzzzzzzw_());

                    return jzzzzzzzzzzx_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)?> jzzzzzzzzzzp_ = context.Operators.Select<CqlInterval<CqlDate>, (CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)?>(intervals, jzzzzzzzzzzo_);
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)?> jzzzzzzzzzzq_ = context.Operators.Distinct<(CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)?>(jzzzzzzzzzzp_);
                object jzzzzzzzzzzr_((CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)? @this)
                {
                    CqlDate kzzzzzzzzzza_ = @this?.startOfInterval;

                    return kzzzzzzzzzza_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)?> jzzzzzzzzzzs_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)?>(jzzzzzzzzzzq_, jzzzzzzzzzzr_, System.ComponentModel.ListSortDirection.Ascending);
                CqlInterval<CqlDate> jzzzzzzzzzzt_((CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)? sortedIntervals)
                {
                    CqlInterval<CqlDate> kzzzzzzzzzzb_ = sortedIntervals?.interval;

                    return kzzzzzzzzzzb_;
                };
                IEnumerable<CqlInterval<CqlDate>> jzzzzzzzzzzu_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)?, CqlInterval<CqlDate>>(jzzzzzzzzzzs_, jzzzzzzzzzzt_);
                IEnumerable<CqlInterval<CqlDate>> jzzzzzzzzzzv_ = context.Operators.Distinct<CqlInterval<CqlDate>>(jzzzzzzzzzzu_);

                return jzzzzzzzzzzv_;
            }
        };

        return jzzzzzzzzzzi_();
    }


    [CqlExpressionDefinition("Sort DateTime Intervals")]
    public IEnumerable<CqlInterval<CqlDateTime>> Sort_DateTime_Intervals(CqlContext context, IEnumerable<CqlInterval<CqlDateTime>> intervals)
    {
        IEnumerable<CqlInterval<CqlDateTime>> kzzzzzzzzzzc_()
        {
            bool kzzzzzzzzzzd_()
            {
                int? kzzzzzzzzzze_ = context.Operators.Count<CqlInterval<CqlDateTime>>(intervals);
                bool? kzzzzzzzzzzf_ = context.Operators.Equal(kzzzzzzzzzze_, 0);

                return kzzzzzzzzzzf_ ?? false;
            };
            if (intervals is null)
            {
                CqlInterval<CqlDateTime>[] kzzzzzzzzzzg_ = []
;

                return kzzzzzzzzzzg_ as IEnumerable<CqlInterval<CqlDateTime>>;
            }
            else if (kzzzzzzzzzzd_())
            {
                CqlInterval<CqlDateTime>[] kzzzzzzzzzzh_ = []
;

                return kzzzzzzzzzzh_ as IEnumerable<CqlInterval<CqlDateTime>>;
            }
            else
            {
                (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)? kzzzzzzzzzzi_(CqlInterval<CqlDateTime> I)
                {
                    CqlDateTime kzzzzzzzzzzq_()
                    {
                        if ((context.Operators.Start(I)) is null)
                        {
                            CqlDateTime kzzzzzzzzzzs_ = context.Operators.MinValue<CqlDateTime>();

                            return kzzzzzzzzzzs_;
                        }
                        else
                        {
                            CqlDateTime kzzzzzzzzzzt_ = context.Operators.Start(I);

                            return kzzzzzzzzzzt_;
                        }
                    };
                    (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)? kzzzzzzzzzzr_ = (CqlTupleMetadata_EQHOUSiiWahbJPOUjJGEhIAOV, I, kzzzzzzzzzzq_());

                    return kzzzzzzzzzzr_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?> kzzzzzzzzzzj_ = context.Operators.Select<CqlInterval<CqlDateTime>, (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?>(intervals, kzzzzzzzzzzi_);
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?> kzzzzzzzzzzk_ = context.Operators.Distinct<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?>(kzzzzzzzzzzj_);
                object kzzzzzzzzzzl_((CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)? @this)
                {
                    CqlDateTime kzzzzzzzzzzu_ = @this?.startOfInterval;

                    return kzzzzzzzzzzu_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?> kzzzzzzzzzzm_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?>(kzzzzzzzzzzk_, kzzzzzzzzzzl_, System.ComponentModel.ListSortDirection.Ascending);
                CqlInterval<CqlDateTime> kzzzzzzzzzzn_((CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)? sortedIntervals)
                {
                    CqlInterval<CqlDateTime> kzzzzzzzzzzv_ = sortedIntervals?.interval;

                    return kzzzzzzzzzzv_;
                };
                IEnumerable<CqlInterval<CqlDateTime>> kzzzzzzzzzzo_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?, CqlInterval<CqlDateTime>>(kzzzzzzzzzzm_, kzzzzzzzzzzn_);
                IEnumerable<CqlInterval<CqlDateTime>> kzzzzzzzzzzp_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(kzzzzzzzzzzo_);

                return kzzzzzzzzzzp_;
            }
        };

        return kzzzzzzzzzzc_();
    }


    [CqlExpressionDefinition("Collapse Date Interval Workaround")]
    public IEnumerable<CqlInterval<CqlDate>> Collapse_Date_Interval_Workaround(CqlContext context, IEnumerable<CqlInterval<CqlDate>> intervals)
    {
        IEnumerable<CqlInterval<CqlDate>> kzzzzzzzzzzw_()
        {
            bool kzzzzzzzzzzx_()
            {
                int? kzzzzzzzzzzy_ = context.Operators.Count<CqlInterval<CqlDate>>(intervals);
                bool? kzzzzzzzzzzz_ = context.Operators.Equal(kzzzzzzzzzzy_, 0);

                return kzzzzzzzzzzz_ ?? false;
            };
            if (intervals is null)
            {
                CqlInterval<CqlDate>[] lzzzzzzzzzza_ = []
;

                return lzzzzzzzzzza_ as IEnumerable<CqlInterval<CqlDate>>;
            }
            else if (kzzzzzzzzzzx_())
            {
                CqlInterval<CqlDate>[] lzzzzzzzzzzb_ = []
;

                return lzzzzzzzzzzb_ as IEnumerable<CqlInterval<CqlDate>>;
            }
            else
            {
                bool? lzzzzzzzzzzc_(CqlInterval<CqlDate> I)
                {
                    bool? lzzzzzzzzzzf_(CqlInterval<CqlDate> J)
                    {
                        bool? lzzzzzzzzzzk_ = context.Operators.IntervalProperlyIncludesInterval<CqlDate>(J, I, default);

                        return lzzzzzzzzzzk_;
                    };
                    IEnumerable<bool?> lzzzzzzzzzzg_ = context.Operators.Select<CqlInterval<CqlDate>, bool?>(intervals, lzzzzzzzzzzf_);
                    IEnumerable<bool?> lzzzzzzzzzzh_ = context.Operators.Distinct<bool?>(lzzzzzzzzzzg_);
                    bool? lzzzzzzzzzzi_ = context.Operators.AnyTrue(lzzzzzzzzzzh_);
                    bool? lzzzzzzzzzzj_ = context.Operators.Not(lzzzzzzzzzzi_);

                    return lzzzzzzzzzzj_;
                };
                IEnumerable<CqlInterval<CqlDate>> lzzzzzzzzzzd_ = context.Operators.Where<CqlInterval<CqlDate>>(intervals, lzzzzzzzzzzc_);
                IEnumerable<CqlInterval<CqlDate>> lzzzzzzzzzze_ = context.Operators.Collapse(lzzzzzzzzzzd_, "day");

                return lzzzzzzzzzze_;
            }
        };

        return kzzzzzzzzzzw_();
    }


    [CqlExpressionDefinition("Collapse DateTime Interval Workaround")]
    public IEnumerable<CqlInterval<CqlDateTime>> Collapse_DateTime_Interval_Workaround(CqlContext context, IEnumerable<CqlInterval<CqlDateTime>> intervals)
    {
        IEnumerable<CqlInterval<CqlDateTime>> lzzzzzzzzzzl_()
        {
            bool lzzzzzzzzzzm_()
            {
                int? lzzzzzzzzzzn_ = context.Operators.Count<CqlInterval<CqlDateTime>>(intervals);
                bool? lzzzzzzzzzzo_ = context.Operators.Equal(lzzzzzzzzzzn_, 0);

                return lzzzzzzzzzzo_ ?? false;
            };
            if (intervals is null)
            {
                CqlInterval<CqlDateTime>[] lzzzzzzzzzzp_ = []
;

                return lzzzzzzzzzzp_ as IEnumerable<CqlInterval<CqlDateTime>>;
            }
            else if (lzzzzzzzzzzm_())
            {
                CqlInterval<CqlDateTime>[] lzzzzzzzzzzq_ = []
;

                return lzzzzzzzzzzq_ as IEnumerable<CqlInterval<CqlDateTime>>;
            }
            else
            {
                bool? lzzzzzzzzzzr_(CqlInterval<CqlDateTime> I)
                {
                    bool? lzzzzzzzzzzu_(CqlInterval<CqlDateTime> J)
                    {
                        bool? lzzzzzzzzzzz_ = context.Operators.IntervalProperlyIncludesInterval<CqlDateTime>(J, I, default);

                        return lzzzzzzzzzzz_;
                    };
                    IEnumerable<bool?> lzzzzzzzzzzv_ = context.Operators.Select<CqlInterval<CqlDateTime>, bool?>(intervals, lzzzzzzzzzzu_);
                    IEnumerable<bool?> lzzzzzzzzzzw_ = context.Operators.Distinct<bool?>(lzzzzzzzzzzv_);
                    bool? lzzzzzzzzzzx_ = context.Operators.AnyTrue(lzzzzzzzzzzw_);
                    bool? lzzzzzzzzzzy_ = context.Operators.Not(lzzzzzzzzzzx_);

                    return lzzzzzzzzzzy_;
                };
                IEnumerable<CqlInterval<CqlDateTime>> lzzzzzzzzzzs_ = context.Operators.Where<CqlInterval<CqlDateTime>>(intervals, lzzzzzzzzzzr_);
                IEnumerable<CqlInterval<CqlDateTime>> lzzzzzzzzzzt_ = context.Operators.Collapse(lzzzzzzzzzzs_, default);

                return lzzzzzzzzzzt_;
            }
        };

        return lzzzzzzzzzzl_();
    }


    [CqlExpressionDefinition("Date Interval Covering Relative to Base Interval")]
    public IEnumerable<CqlInterval<CqlDate>> Date_Interval_Covering_Relative_to_Base_Interval(CqlContext context, CqlInterval<CqlDate> baseInterval, IEnumerable<CqlInterval<CqlDate>> coveringIntervals)
    {
        IEnumerable<CqlInterval<CqlDate>> mzzzzzzzzzza_ = this.Sort_Date_Intervals(context, coveringIntervals);
        CqlInterval<CqlDate> mzzzzzzzzzzb_(CqlInterval<CqlDate> sortedInterval)
        {
            CqlInterval<CqlDate> mzzzzzzzzzzf_ = context.Operators.Intersect<CqlDate>(baseInterval, sortedInterval);

            return mzzzzzzzzzzf_;
        };
        IEnumerable<CqlInterval<CqlDate>> mzzzzzzzzzzc_ = context.Operators.Select<CqlInterval<CqlDate>, CqlInterval<CqlDate>>(mzzzzzzzzzza_, mzzzzzzzzzzb_);
        IEnumerable<CqlInterval<CqlDate>> mzzzzzzzzzzd_ = context.Operators.Distinct<CqlInterval<CqlDate>>(mzzzzzzzzzzc_);
        IEnumerable<CqlInterval<CqlDate>> mzzzzzzzzzze_ = this.Collapse_Date_Interval_Workaround(context, mzzzzzzzzzzd_);

        return mzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("DateTime Interval Covering Relative to Base Interval")]
    public IEnumerable<CqlInterval<CqlDateTime>> DateTime_Interval_Covering_Relative_to_Base_Interval(CqlContext context, CqlInterval<CqlDateTime> baseInterval, IEnumerable<CqlInterval<CqlDateTime>> coveringIntervals)
    {
        IEnumerable<CqlInterval<CqlDateTime>> mzzzzzzzzzzg_ = this.Sort_DateTime_Intervals(context, coveringIntervals);
        CqlInterval<CqlDateTime> mzzzzzzzzzzh_(CqlInterval<CqlDateTime> sortedInterval)
        {
            CqlInterval<CqlDateTime> mzzzzzzzzzzl_ = context.Operators.Intersect<CqlDateTime>(baseInterval, sortedInterval);

            return mzzzzzzzzzzl_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> mzzzzzzzzzzi_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(mzzzzzzzzzzg_, mzzzzzzzzzzh_);
        IEnumerable<CqlInterval<CqlDateTime>> mzzzzzzzzzzj_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(mzzzzzzzzzzi_);
        IEnumerable<CqlInterval<CqlDateTime>> mzzzzzzzzzzk_ = this.Collapse_DateTime_Interval_Workaround(context, mzzzzzzzzzzj_);

        return mzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Date Interval Gaps Relative to Base Interval")]
    public IEnumerable<CqlInterval<CqlDate>> Date_Interval_Gaps_Relative_to_Base_Interval(CqlContext context, CqlInterval<CqlDate> baseInterval, IEnumerable<CqlInterval<CqlDate>> coveringIntervals)
    {
        IEnumerable<CqlInterval<CqlDate>> mzzzzzzzzzzm_ = this.Date_Interval_Covering_Relative_to_Base_Interval(context, baseInterval, coveringIntervals);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> sortedCoverings)? mzzzzzzzzzzn_ = (CqlTupleMetadata_EVRLVXPcBiDTIWfCCfKEWDfKI, mzzzzzzzzzzm_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> sortedCoverings)?[] mzzzzzzzzzzo_ = [
            mzzzzzzzzzzn_,
        ];
        IEnumerable<CqlInterval<CqlDate>> mzzzzzzzzzzp_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> sortedCoverings)? variableDeclarations)
        {
            IEnumerable<CqlInterval<CqlDate>> mzzzzzzzzzzt_()
            {
                bool nzzzzzzzzzzb_()
                {
                    IEnumerable<CqlInterval<CqlDate>> nzzzzzzzzzzc_ = variableDeclarations?.sortedCoverings;
                    int? nzzzzzzzzzzd_ = context.Operators.Count<CqlInterval<CqlDate>>(nzzzzzzzzzzc_);
                    bool? nzzzzzzzzzze_ = context.Operators.Equal(nzzzzzzzzzzd_, 0);

                    return nzzzzzzzzzze_ ?? false;
                };
                if (nzzzzzzzzzzb_())
                {
                    CqlInterval<CqlDate>[] nzzzzzzzzzzf_ = [
                        baseInterval,
                    ];

                    return nzzzzzzzzzzf_ as IEnumerable<CqlInterval<CqlDate>>;
                }
                else
                {
                    IEnumerable<CqlInterval<CqlDate>> nzzzzzzzzzzg_ = variableDeclarations?.sortedCoverings;
                    CqlInterval<CqlDate> nzzzzzzzzzzh_(CqlInterval<CqlDate> sortedCovering)
                    {
                        CqlInterval<CqlDate> nzzzzzzzzzzk_()
                        {
                            bool nzzzzzzzzzzl_()
                            {
                                IEnumerable<CqlInterval<CqlDate>> nzzzzzzzzzzm_ = variableDeclarations?.sortedCoverings;
                                int? nzzzzzzzzzzn_ = context.Operators.IndexOf<CqlInterval<CqlDate>>(nzzzzzzzzzzm_, sortedCovering);
                                bool? nzzzzzzzzzzo_ = context.Operators.Equal(nzzzzzzzzzzn_, 0);

                                return nzzzzzzzzzzo_ ?? false;
                            };
                            if (nzzzzzzzzzzl_())
                            {
                                CqlDate nzzzzzzzzzzp_ = context.Operators.Start(baseInterval);
                                CqlDate nzzzzzzzzzzq_ = context.Operators.Start(sortedCovering);
                                CqlInterval<CqlDate> nzzzzzzzzzzr_ = context.Operators.Interval(nzzzzzzzzzzp_, nzzzzzzzzzzq_, true, true);
                                CqlInterval<CqlDate> nzzzzzzzzzzs_ = context.Operators.Intersect<CqlDate>(nzzzzzzzzzzr_, baseInterval);
                                CqlInterval<CqlDate> nzzzzzzzzzzt_ = context.Operators.Except(nzzzzzzzzzzs_, sortedCovering);

                                return nzzzzzzzzzzt_;
                            }
                            else
                            {
                                IEnumerable<CqlInterval<CqlDate>> nzzzzzzzzzzu_ = variableDeclarations?.sortedCoverings;
                                int? nzzzzzzzzzzw_ = context.Operators.IndexOf<CqlInterval<CqlDate>>(nzzzzzzzzzzu_, sortedCovering);
                                int? nzzzzzzzzzzx_ = context.Operators.Subtract(nzzzzzzzzzzw_, 1);
                                CqlInterval<CqlDate> nzzzzzzzzzzy_ = context.Operators.Indexer<CqlInterval<CqlDate>>(nzzzzzzzzzzu_, nzzzzzzzzzzx_);
                                CqlDate nzzzzzzzzzzz_ = context.Operators.Start(nzzzzzzzzzzy_);
                                CqlDate ozzzzzzzzzza_ = context.Operators.End(sortedCovering);
                                CqlInterval<CqlDate> ozzzzzzzzzzb_ = context.Operators.Interval(nzzzzzzzzzzz_, ozzzzzzzzzza_, false, false);
                                int? ozzzzzzzzzze_ = context.Operators.IndexOf<CqlInterval<CqlDate>>(nzzzzzzzzzzu_, sortedCovering);
                                int? ozzzzzzzzzzf_ = context.Operators.Subtract(ozzzzzzzzzze_, 1);
                                CqlInterval<CqlDate> ozzzzzzzzzzg_ = context.Operators.Indexer<CqlInterval<CqlDate>>(nzzzzzzzzzzu_, ozzzzzzzzzzf_);
                                CqlInterval<CqlDate> ozzzzzzzzzzh_ = context.Operators.Except(ozzzzzzzzzzb_, ozzzzzzzzzzg_);
                                CqlInterval<CqlDate> ozzzzzzzzzzi_ = context.Operators.Except(ozzzzzzzzzzh_, sortedCovering);

                                return ozzzzzzzzzzi_;
                            }
                        };

                        return nzzzzzzzzzzk_();
                    };
                    IEnumerable<CqlInterval<CqlDate>> nzzzzzzzzzzi_ = context.Operators.Select<CqlInterval<CqlDate>, CqlInterval<CqlDate>>(nzzzzzzzzzzg_, nzzzzzzzzzzh_);
                    IEnumerable<CqlInterval<CqlDate>> nzzzzzzzzzzj_ = context.Operators.Distinct<CqlInterval<CqlDate>>(nzzzzzzzzzzi_);

                    return nzzzzzzzzzzj_;
                }
            };
            IEnumerable<CqlInterval<CqlDate>> mzzzzzzzzzzu_()
            {
                bool ozzzzzzzzzzj_()
                {
                    IEnumerable<CqlInterval<CqlDate>> ozzzzzzzzzzk_ = variableDeclarations?.sortedCoverings;
                    int? ozzzzzzzzzzl_ = context.Operators.Count<CqlInterval<CqlDate>>(ozzzzzzzzzzk_);
                    bool? ozzzzzzzzzzm_ = context.Operators.Equal(ozzzzzzzzzzl_, 0);

                    return ozzzzzzzzzzm_ ?? false;
                };
                if (ozzzzzzzzzzj_())
                {
                    CqlInterval<CqlDate>[] ozzzzzzzzzzn_ = []
;

                    return ozzzzzzzzzzn_ as IEnumerable<CqlInterval<CqlDate>>;
                }
                else
                {
                    IEnumerable<CqlInterval<CqlDate>> ozzzzzzzzzzo_ = variableDeclarations?.sortedCoverings;
                    CqlInterval<CqlDate> ozzzzzzzzzzp_ = context.Operators.Last<CqlInterval<CqlDate>>(ozzzzzzzzzzo_);
                    CqlDate ozzzzzzzzzzq_ = context.Operators.Start(ozzzzzzzzzzp_);
                    CqlDate ozzzzzzzzzzr_ = context.Operators.End(baseInterval);
                    CqlInterval<CqlDate> ozzzzzzzzzzs_ = context.Operators.Interval(ozzzzzzzzzzq_, ozzzzzzzzzzr_, false, true);
                    CqlInterval<CqlDate> ozzzzzzzzzzu_ = context.Operators.Last<CqlInterval<CqlDate>>(ozzzzzzzzzzo_);
                    CqlInterval<CqlDate> ozzzzzzzzzzv_ = context.Operators.Except(ozzzzzzzzzzs_, ozzzzzzzzzzu_);
                    CqlInterval<CqlDate> ozzzzzzzzzzw_ = context.Operators.Intersect<CqlDate>(ozzzzzzzzzzv_, baseInterval);
                    CqlInterval<CqlDate>[] ozzzzzzzzzzx_ = [
                        ozzzzzzzzzzw_,
                    ];

                    return ozzzzzzzzzzx_ as IEnumerable<CqlInterval<CqlDate>>;
                }
            };
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> frontgaps, IEnumerable<CqlInterval<CqlDate>> endgap)? mzzzzzzzzzzv_ = (CqlTupleMetadata_FKcLSALRMRfDigEFaJgDOPFRK, mzzzzzzzzzzt_(), mzzzzzzzzzzu_());
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> frontgaps, IEnumerable<CqlInterval<CqlDate>> endgap)?[] mzzzzzzzzzzw_ = [
                mzzzzzzzzzzv_,
            ];
            IEnumerable<CqlInterval<CqlDate>> mzzzzzzzzzzx_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> frontgaps, IEnumerable<CqlInterval<CqlDate>> endgap)? calculations)
            {
                IEnumerable<CqlInterval<CqlDate>> ozzzzzzzzzzy_ = calculations?.frontgaps;
                IEnumerable<CqlInterval<CqlDate>> ozzzzzzzzzzz_ = calculations?.endgap;
                IEnumerable<CqlInterval<CqlDate>> pzzzzzzzzzza_ = context.Operators.Union<CqlInterval<CqlDate>>(ozzzzzzzzzzy_, ozzzzzzzzzzz_);
                IEnumerable<CqlInterval<CqlDate>> pzzzzzzzzzzb_ = this.Collapse_Date_Interval_Workaround(context, pzzzzzzzzzza_);

                return pzzzzzzzzzzb_;
            };
            IEnumerable<IEnumerable<CqlInterval<CqlDate>>> mzzzzzzzzzzy_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> frontgaps, IEnumerable<CqlInterval<CqlDate>> endgap)?, IEnumerable<CqlInterval<CqlDate>>>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> frontgaps, IEnumerable<CqlInterval<CqlDate>> endgap)?>)mzzzzzzzzzzw_, mzzzzzzzzzzx_);
            IEnumerable<IEnumerable<CqlInterval<CqlDate>>> mzzzzzzzzzzz_ = context.Operators.Distinct<IEnumerable<CqlInterval<CqlDate>>>(mzzzzzzzzzzy_);
            IEnumerable<CqlInterval<CqlDate>> nzzzzzzzzzza_ = context.Operators.SingletonFrom<IEnumerable<CqlInterval<CqlDate>>>(mzzzzzzzzzzz_);

            return nzzzzzzzzzza_;
        };
        IEnumerable<IEnumerable<CqlInterval<CqlDate>>> mzzzzzzzzzzq_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> sortedCoverings)?, IEnumerable<CqlInterval<CqlDate>>>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> sortedCoverings)?>)mzzzzzzzzzzo_, mzzzzzzzzzzp_);
        IEnumerable<IEnumerable<CqlInterval<CqlDate>>> mzzzzzzzzzzr_ = context.Operators.Distinct<IEnumerable<CqlInterval<CqlDate>>>(mzzzzzzzzzzq_);
        IEnumerable<CqlInterval<CqlDate>> mzzzzzzzzzzs_ = context.Operators.SingletonFrom<IEnumerable<CqlInterval<CqlDate>>>(mzzzzzzzzzzr_);

        return mzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("DateTime Interval Gaps Relative to Base Interval")]
    public IEnumerable<CqlInterval<CqlDateTime>> DateTime_Interval_Gaps_Relative_to_Base_Interval(CqlContext context, CqlInterval<CqlDateTime> baseInterval, IEnumerable<CqlInterval<CqlDateTime>> coveringIntervals)
    {
        IEnumerable<CqlInterval<CqlDateTime>> pzzzzzzzzzzc_ = this.DateTime_Interval_Covering_Relative_to_Base_Interval(context, baseInterval, coveringIntervals);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> sortedCoverings)? pzzzzzzzzzzd_ = (CqlTupleMetadata_EdgSWaTaCbLYLJceGdIcWOLHd, pzzzzzzzzzzc_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> sortedCoverings)?[] pzzzzzzzzzze_ = [
            pzzzzzzzzzzd_,
        ];
        IEnumerable<CqlInterval<CqlDateTime>> pzzzzzzzzzzf_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> sortedCoverings)? variableDeclarations)
        {
            IEnumerable<CqlInterval<CqlDateTime>> pzzzzzzzzzzj_()
            {
                bool pzzzzzzzzzzr_()
                {
                    IEnumerable<CqlInterval<CqlDateTime>> pzzzzzzzzzzs_ = variableDeclarations?.sortedCoverings;
                    int? pzzzzzzzzzzt_ = context.Operators.Count<CqlInterval<CqlDateTime>>(pzzzzzzzzzzs_);
                    bool? pzzzzzzzzzzu_ = context.Operators.Equal(pzzzzzzzzzzt_, 0);

                    return pzzzzzzzzzzu_ ?? false;
                };
                if (pzzzzzzzzzzr_())
                {
                    CqlInterval<CqlDateTime>[] pzzzzzzzzzzv_ = [
                        baseInterval,
                    ];

                    return pzzzzzzzzzzv_ as IEnumerable<CqlInterval<CqlDateTime>>;
                }
                else
                {
                    IEnumerable<CqlInterval<CqlDateTime>> pzzzzzzzzzzw_ = variableDeclarations?.sortedCoverings;
                    CqlInterval<CqlDateTime> pzzzzzzzzzzx_(CqlInterval<CqlDateTime> sortedCovering)
                    {
                        CqlInterval<CqlDateTime> qzzzzzzzzzza_()
                        {
                            bool qzzzzzzzzzzb_()
                            {
                                IEnumerable<CqlInterval<CqlDateTime>> qzzzzzzzzzzc_ = variableDeclarations?.sortedCoverings;
                                int? qzzzzzzzzzzd_ = context.Operators.IndexOf<CqlInterval<CqlDateTime>>(qzzzzzzzzzzc_, sortedCovering);
                                bool? qzzzzzzzzzze_ = context.Operators.Equal(qzzzzzzzzzzd_, 0);

                                return qzzzzzzzzzze_ ?? false;
                            };
                            if (qzzzzzzzzzzb_())
                            {
                                CqlDateTime qzzzzzzzzzzf_ = context.Operators.Start(baseInterval);
                                CqlDateTime qzzzzzzzzzzg_ = context.Operators.Start(sortedCovering);
                                CqlInterval<CqlDateTime> qzzzzzzzzzzh_ = context.Operators.Interval(qzzzzzzzzzzf_, qzzzzzzzzzzg_, true, true);
                                CqlInterval<CqlDateTime> qzzzzzzzzzzi_ = context.Operators.Intersect<CqlDateTime>(qzzzzzzzzzzh_, baseInterval);
                                CqlInterval<CqlDateTime> qzzzzzzzzzzj_ = context.Operators.Except(qzzzzzzzzzzi_, sortedCovering);

                                return qzzzzzzzzzzj_;
                            }
                            else
                            {
                                IEnumerable<CqlInterval<CqlDateTime>> qzzzzzzzzzzk_ = variableDeclarations?.sortedCoverings;
                                int? qzzzzzzzzzzm_ = context.Operators.IndexOf<CqlInterval<CqlDateTime>>(qzzzzzzzzzzk_, sortedCovering);
                                int? qzzzzzzzzzzn_ = context.Operators.Subtract(qzzzzzzzzzzm_, 1);
                                CqlInterval<CqlDateTime> qzzzzzzzzzzo_ = context.Operators.Indexer<CqlInterval<CqlDateTime>>(qzzzzzzzzzzk_, qzzzzzzzzzzn_);
                                CqlDateTime qzzzzzzzzzzp_ = context.Operators.Start(qzzzzzzzzzzo_);
                                CqlDateTime qzzzzzzzzzzq_ = context.Operators.End(sortedCovering);
                                CqlInterval<CqlDateTime> qzzzzzzzzzzr_ = context.Operators.Interval(qzzzzzzzzzzp_, qzzzzzzzzzzq_, false, false);
                                int? qzzzzzzzzzzu_ = context.Operators.IndexOf<CqlInterval<CqlDateTime>>(qzzzzzzzzzzk_, sortedCovering);
                                int? qzzzzzzzzzzv_ = context.Operators.Subtract(qzzzzzzzzzzu_, 1);
                                CqlInterval<CqlDateTime> qzzzzzzzzzzw_ = context.Operators.Indexer<CqlInterval<CqlDateTime>>(qzzzzzzzzzzk_, qzzzzzzzzzzv_);
                                CqlInterval<CqlDateTime> qzzzzzzzzzzx_ = context.Operators.Except(qzzzzzzzzzzr_, qzzzzzzzzzzw_);
                                CqlInterval<CqlDateTime> qzzzzzzzzzzy_ = context.Operators.Except(qzzzzzzzzzzx_, sortedCovering);

                                return qzzzzzzzzzzy_;
                            }
                        };

                        return qzzzzzzzzzza_();
                    };
                    IEnumerable<CqlInterval<CqlDateTime>> pzzzzzzzzzzy_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(pzzzzzzzzzzw_, pzzzzzzzzzzx_);
                    IEnumerable<CqlInterval<CqlDateTime>> pzzzzzzzzzzz_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(pzzzzzzzzzzy_);

                    return pzzzzzzzzzzz_;
                }
            };
            IEnumerable<CqlInterval<CqlDateTime>> pzzzzzzzzzzk_()
            {
                bool qzzzzzzzzzzz_()
                {
                    IEnumerable<CqlInterval<CqlDateTime>> rzzzzzzzzzza_ = variableDeclarations?.sortedCoverings;
                    int? rzzzzzzzzzzb_ = context.Operators.Count<CqlInterval<CqlDateTime>>(rzzzzzzzzzza_);
                    bool? rzzzzzzzzzzc_ = context.Operators.Equal(rzzzzzzzzzzb_, 0);

                    return rzzzzzzzzzzc_ ?? false;
                };
                if (qzzzzzzzzzzz_())
                {
                    CqlInterval<CqlDateTime>[] rzzzzzzzzzzd_ = []
;

                    return rzzzzzzzzzzd_ as IEnumerable<CqlInterval<CqlDateTime>>;
                }
                else
                {
                    IEnumerable<CqlInterval<CqlDateTime>> rzzzzzzzzzze_ = variableDeclarations?.sortedCoverings;
                    CqlInterval<CqlDateTime> rzzzzzzzzzzf_ = context.Operators.Last<CqlInterval<CqlDateTime>>(rzzzzzzzzzze_);
                    CqlDateTime rzzzzzzzzzzg_ = context.Operators.Start(rzzzzzzzzzzf_);
                    CqlDateTime rzzzzzzzzzzh_ = context.Operators.End(baseInterval);
                    CqlInterval<CqlDateTime> rzzzzzzzzzzi_ = context.Operators.Interval(rzzzzzzzzzzg_, rzzzzzzzzzzh_, false, true);
                    CqlInterval<CqlDateTime> rzzzzzzzzzzk_ = context.Operators.Last<CqlInterval<CqlDateTime>>(rzzzzzzzzzze_);
                    CqlInterval<CqlDateTime> rzzzzzzzzzzl_ = context.Operators.Except(rzzzzzzzzzzi_, rzzzzzzzzzzk_);
                    CqlInterval<CqlDateTime> rzzzzzzzzzzm_ = context.Operators.Intersect<CqlDateTime>(rzzzzzzzzzzl_, baseInterval);
                    CqlInterval<CqlDateTime>[] rzzzzzzzzzzn_ = [
                        rzzzzzzzzzzm_,
                    ];

                    return rzzzzzzzzzzn_ as IEnumerable<CqlInterval<CqlDateTime>>;
                }
            };
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> frontgaps, IEnumerable<CqlInterval<CqlDateTime>> endgap)? pzzzzzzzzzzl_ = (CqlTupleMetadata_BBLSSiNBQBGUDJaVjMDZMSAXg, pzzzzzzzzzzj_(), pzzzzzzzzzzk_());
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> frontgaps, IEnumerable<CqlInterval<CqlDateTime>> endgap)?[] pzzzzzzzzzzm_ = [
                pzzzzzzzzzzl_,
            ];
            IEnumerable<CqlInterval<CqlDateTime>> pzzzzzzzzzzn_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> frontgaps, IEnumerable<CqlInterval<CqlDateTime>> endgap)? calculations)
            {
                IEnumerable<CqlInterval<CqlDateTime>> rzzzzzzzzzzo_ = calculations?.frontgaps;
                IEnumerable<CqlInterval<CqlDateTime>> rzzzzzzzzzzp_ = calculations?.endgap;
                IEnumerable<CqlInterval<CqlDateTime>> rzzzzzzzzzzq_ = context.Operators.Union<CqlInterval<CqlDateTime>>(rzzzzzzzzzzo_, rzzzzzzzzzzp_);
                IEnumerable<CqlInterval<CqlDateTime>> rzzzzzzzzzzr_ = this.Collapse_DateTime_Interval_Workaround(context, rzzzzzzzzzzq_);

                return rzzzzzzzzzzr_;
            };
            IEnumerable<IEnumerable<CqlInterval<CqlDateTime>>> pzzzzzzzzzzo_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> frontgaps, IEnumerable<CqlInterval<CqlDateTime>> endgap)?, IEnumerable<CqlInterval<CqlDateTime>>>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> frontgaps, IEnumerable<CqlInterval<CqlDateTime>> endgap)?>)pzzzzzzzzzzm_, pzzzzzzzzzzn_);
            IEnumerable<IEnumerable<CqlInterval<CqlDateTime>>> pzzzzzzzzzzp_ = context.Operators.Distinct<IEnumerable<CqlInterval<CqlDateTime>>>(pzzzzzzzzzzo_);
            IEnumerable<CqlInterval<CqlDateTime>> pzzzzzzzzzzq_ = context.Operators.SingletonFrom<IEnumerable<CqlInterval<CqlDateTime>>>(pzzzzzzzzzzp_);

            return pzzzzzzzzzzq_;
        };
        IEnumerable<IEnumerable<CqlInterval<CqlDateTime>>> pzzzzzzzzzzg_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> sortedCoverings)?, IEnumerable<CqlInterval<CqlDateTime>>>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> sortedCoverings)?>)pzzzzzzzzzze_, pzzzzzzzzzzf_);
        IEnumerable<IEnumerable<CqlInterval<CqlDateTime>>> pzzzzzzzzzzh_ = context.Operators.Distinct<IEnumerable<CqlInterval<CqlDateTime>>>(pzzzzzzzzzzg_);
        IEnumerable<CqlInterval<CqlDateTime>> pzzzzzzzzzzi_ = context.Operators.SingletonFrom<IEnumerable<CqlInterval<CqlDateTime>>>(pzzzzzzzzzzh_);

        return pzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Collapsed Date Interval Stats")]
    public (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? Collapsed_Date_Interval_Stats(CqlContext context, IEnumerable<CqlInterval<CqlDate>> collapsedIntervals)
    {
        int? rzzzzzzzzzzs_ = context.Operators.Count<CqlInterval<CqlDate>>(collapsedIntervals);
        int? rzzzzzzzzzzt_()
        {
            bool rzzzzzzzzzzx_()
            {
                int? rzzzzzzzzzzy_ = context.Operators.Count<CqlInterval<CqlDate>>(collapsedIntervals);
                bool? rzzzzzzzzzzz_ = context.Operators.Equal(rzzzzzzzzzzy_, 0);

                return rzzzzzzzzzzz_ ?? false;
            };
            if (rzzzzzzzzzzx_())
            {
                return 0;
            }
            else
            {
                int? szzzzzzzzzza_(CqlInterval<CqlDate> I)
                {
                    CqlDate szzzzzzzzzze_ = context.Operators.Start(I);
                    CqlDate szzzzzzzzzzf_ = context.Operators.End(I);
                    int? szzzzzzzzzzg_ = context.Operators.DurationBetween(szzzzzzzzzze_, szzzzzzzzzzf_, "day");
                    int? szzzzzzzzzzh_ = context.Operators.Add(szzzzzzzzzzg_, 1);
                    int?[] szzzzzzzzzzi_ = [
                        szzzzzzzzzzh_,
                        0,
                    ];
                    int? szzzzzzzzzzj_ = context.Operators.Max<int?>(szzzzzzzzzzi_ as IEnumerable<int?>);

                    return szzzzzzzzzzj_;
                };
                IEnumerable<int?> szzzzzzzzzzb_ = context.Operators.Select<CqlInterval<CqlDate>, int?>(collapsedIntervals, szzzzzzzzzza_);
                IEnumerable<int?> szzzzzzzzzzc_ = context.Operators.Distinct<int?>(szzzzzzzzzzb_);
                int? szzzzzzzzzzd_ = context.Operators.Sum(szzzzzzzzzzc_);

                return szzzzzzzzzzd_;
            }
        };
        CqlInterval<CqlDate> rzzzzzzzzzzu_()
        {
            bool szzzzzzzzzzk_()
            {
                int? szzzzzzzzzzl_ = context.Operators.Count<CqlInterval<CqlDate>>(collapsedIntervals);
                bool? szzzzzzzzzzm_ = context.Operators.Equal(szzzzzzzzzzl_, 0);

                return szzzzzzzzzzm_ ?? false;
            };
            if (szzzzzzzzzzk_())
            {
                return null as CqlInterval<CqlDate>;
            }
            else
            {
                (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? szzzzzzzzzzn_(CqlInterval<CqlDate> I)
                {
                    CqlDate szzzzzzzzzzu_ = context.Operators.Start(I);
                    CqlDate szzzzzzzzzzv_ = context.Operators.End(I);
                    int? szzzzzzzzzzw_ = context.Operators.DurationBetween(szzzzzzzzzzu_, szzzzzzzzzzv_, "day");
                    int? szzzzzzzzzzx_ = context.Operators.Add(szzzzzzzzzzw_, 1);
                    int?[] szzzzzzzzzzy_ = [
                        szzzzzzzzzzx_,
                        0,
                    ];
                    int? szzzzzzzzzzz_ = context.Operators.Max<int?>(szzzzzzzzzzy_ as IEnumerable<int?>);
                    (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? tzzzzzzzzzza_ = (CqlTupleMetadata_HEjPGjPEhLgQPGjROeWMgiGfC, I, szzzzzzzzzzz_);

                    return tzzzzzzzzzza_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> szzzzzzzzzzo_ = context.Operators.Select<CqlInterval<CqlDate>, (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(collapsedIntervals, szzzzzzzzzzn_);
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> szzzzzzzzzzp_ = context.Operators.Distinct<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(szzzzzzzzzzo_);
                object szzzzzzzzzzq_((CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? @this)
                {
                    int? tzzzzzzzzzzb_ = @this?.days;

                    return tzzzzzzzzzzb_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> szzzzzzzzzzr_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(szzzzzzzzzzp_, szzzzzzzzzzq_, System.ComponentModel.ListSortDirection.Descending);
                (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? szzzzzzzzzzs_ = context.Operators.First<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(szzzzzzzzzzr_);
                CqlInterval<CqlDate> szzzzzzzzzzt_ = szzzzzzzzzzs_?.interval;

                return szzzzzzzzzzt_;
            }
        };
        int? rzzzzzzzzzzv_()
        {
            bool tzzzzzzzzzzc_()
            {
                int? tzzzzzzzzzzd_ = context.Operators.Count<CqlInterval<CqlDate>>(collapsedIntervals);
                bool? tzzzzzzzzzze_ = context.Operators.Equal(tzzzzzzzzzzd_, 0);

                return tzzzzzzzzzze_ ?? false;
            };
            if (tzzzzzzzzzzc_())
            {
                return 0;
            }
            else
            {
                (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? tzzzzzzzzzzf_(CqlInterval<CqlDate> I)
                {
                    CqlDate tzzzzzzzzzzz_ = context.Operators.Start(I);
                    CqlDate uzzzzzzzzzza_ = context.Operators.End(I);
                    int? uzzzzzzzzzzb_ = context.Operators.DurationBetween(tzzzzzzzzzzz_, uzzzzzzzzzza_, "day");
                    int? uzzzzzzzzzzc_ = context.Operators.Add(uzzzzzzzzzzb_, 1);
                    int?[] uzzzzzzzzzzd_ = [
                        uzzzzzzzzzzc_,
                        0,
                    ];
                    int? uzzzzzzzzzze_ = context.Operators.Max<int?>(uzzzzzzzzzzd_ as IEnumerable<int?>);
                    (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? uzzzzzzzzzzf_ = (CqlTupleMetadata_HEjPGjPEhLgQPGjROeWMgiGfC, I, uzzzzzzzzzze_);

                    return uzzzzzzzzzzf_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> tzzzzzzzzzzg_ = context.Operators.Select<CqlInterval<CqlDate>, (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(collapsedIntervals, tzzzzzzzzzzf_);
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> tzzzzzzzzzzh_ = context.Operators.Distinct<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(tzzzzzzzzzzg_);
                object tzzzzzzzzzzi_((CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? @this)
                {
                    int? uzzzzzzzzzzg_ = @this?.days;

                    return uzzzzzzzzzzg_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> tzzzzzzzzzzj_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(tzzzzzzzzzzh_, tzzzzzzzzzzi_, System.ComponentModel.ListSortDirection.Descending);
                (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? tzzzzzzzzzzk_ = context.Operators.First<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(tzzzzzzzzzzj_);
                CqlInterval<CqlDate> tzzzzzzzzzzl_ = tzzzzzzzzzzk_?.interval;
                CqlDate tzzzzzzzzzzm_ = context.Operators.Start(tzzzzzzzzzzl_);
                (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? tzzzzzzzzzzn_(CqlInterval<CqlDate> I)
                {
                    CqlDate uzzzzzzzzzzh_ = context.Operators.Start(I);
                    CqlDate uzzzzzzzzzzi_ = context.Operators.End(I);
                    int? uzzzzzzzzzzj_ = context.Operators.DurationBetween(uzzzzzzzzzzh_, uzzzzzzzzzzi_, "day");
                    int? uzzzzzzzzzzk_ = context.Operators.Add(uzzzzzzzzzzj_, 1);
                    int?[] uzzzzzzzzzzl_ = [
                        uzzzzzzzzzzk_,
                        0,
                    ];
                    int? uzzzzzzzzzzm_ = context.Operators.Max<int?>(uzzzzzzzzzzl_ as IEnumerable<int?>);
                    (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? uzzzzzzzzzzn_ = (CqlTupleMetadata_HEjPGjPEhLgQPGjROeWMgiGfC, I, uzzzzzzzzzzm_);

                    return uzzzzzzzzzzn_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> tzzzzzzzzzzo_ = context.Operators.Select<CqlInterval<CqlDate>, (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(collapsedIntervals, tzzzzzzzzzzn_);
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> tzzzzzzzzzzp_ = context.Operators.Distinct<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(tzzzzzzzzzzo_);
                object tzzzzzzzzzzq_((CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? @this)
                {
                    int? uzzzzzzzzzzo_ = @this?.days;

                    return uzzzzzzzzzzo_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> tzzzzzzzzzzr_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(tzzzzzzzzzzp_, tzzzzzzzzzzq_, System.ComponentModel.ListSortDirection.Descending);
                (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? tzzzzzzzzzzs_ = context.Operators.First<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(tzzzzzzzzzzr_);
                CqlInterval<CqlDate> tzzzzzzzzzzt_ = tzzzzzzzzzzs_?.interval;
                CqlDate tzzzzzzzzzzu_ = context.Operators.End(tzzzzzzzzzzt_);
                int? tzzzzzzzzzzv_ = context.Operators.DurationBetween(tzzzzzzzzzzm_, tzzzzzzzzzzu_, "day");
                int? tzzzzzzzzzzw_ = context.Operators.Add(tzzzzzzzzzzv_, 1);
                int?[] tzzzzzzzzzzx_ = [
                    tzzzzzzzzzzw_,
                    0,
                ];
                int? tzzzzzzzzzzy_ = context.Operators.Max<int?>(tzzzzzzzzzzx_ as IEnumerable<int?>);

                return tzzzzzzzzzzy_;
            }
        };
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? rzzzzzzzzzzw_ = (CqlTupleMetadata_HRbPDRZiOGGBceePOZWjVbXdP, collapsedIntervals, rzzzzzzzzzzs_, rzzzzzzzzzzt_(), rzzzzzzzzzzu_(), rzzzzzzzzzzv_());

        return rzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Date Interval Covering Relative to Base Interval Stats")]
    public (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? Date_Interval_Covering_Relative_to_Base_Interval_Stats(CqlContext context, CqlInterval<CqlDate> baseInterval, IEnumerable<CqlInterval<CqlDate>> coveringIntervals)
    {
        IEnumerable<CqlInterval<CqlDate>> uzzzzzzzzzzp_ = this.Date_Interval_Covering_Relative_to_Base_Interval(context, baseInterval, coveringIntervals);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Covering_Intervals)? uzzzzzzzzzzq_ = (CqlTupleMetadata_DUiZjXRKgCPYVZQJbFVDKNMOi, uzzzzzzzzzzp_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Covering_Intervals)?[] uzzzzzzzzzzr_ = [
            uzzzzzzzzzzq_,
        ];
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? uzzzzzzzzzzs_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Covering_Intervals)? variableDeclarations)
        {
            IEnumerable<CqlInterval<CqlDate>> uzzzzzzzzzzw_ = variableDeclarations?.Covering_Intervals;
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? uzzzzzzzzzzx_ = this.Collapsed_Date_Interval_Stats(context, uzzzzzzzzzzw_);

            return uzzzzzzzzzzx_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?> uzzzzzzzzzzt_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Covering_Intervals)?, (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Covering_Intervals)?>)uzzzzzzzzzzr_, uzzzzzzzzzzs_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?> uzzzzzzzzzzu_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>(uzzzzzzzzzzt_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? uzzzzzzzzzzv_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>(uzzzzzzzzzzu_);

        return uzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Date Interval Gaps Relative to Base Interval Stats")]
    public (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? Date_Interval_Gaps_Relative_to_Base_Interval_Stats(CqlContext context, CqlInterval<CqlDate> baseInterval, IEnumerable<CqlInterval<CqlDate>> coveringIntervals)
    {
        IEnumerable<CqlInterval<CqlDate>> uzzzzzzzzzzy_ = this.Date_Interval_Gaps_Relative_to_Base_Interval(context, baseInterval, coveringIntervals);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Gap_Intervals)? uzzzzzzzzzzz_ = (CqlTupleMetadata_GQPbYTYABjXFVLRKjXgcDJFSj, uzzzzzzzzzzy_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Gap_Intervals)?[] vzzzzzzzzzza_ = [
            uzzzzzzzzzzz_,
        ];
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? vzzzzzzzzzzb_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Gap_Intervals)? variableDeclarations)
        {
            IEnumerable<CqlInterval<CqlDate>> vzzzzzzzzzzf_ = variableDeclarations?.Gap_Intervals;
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? vzzzzzzzzzzg_ = this.Collapsed_Date_Interval_Stats(context, vzzzzzzzzzzf_);

            return vzzzzzzzzzzg_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?> vzzzzzzzzzzc_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Gap_Intervals)?, (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Gap_Intervals)?>)vzzzzzzzzzza_, vzzzzzzzzzzb_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?> vzzzzzzzzzzd_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>(vzzzzzzzzzzc_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? vzzzzzzzzzze_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>(vzzzzzzzzzzd_);

        return vzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("DateTime Interval Set Nulls to Zero")]
    public CqlInterval<CqlDateTime> DateTime_Interval_Set_Nulls_to_Zero(CqlContext context, CqlInterval<CqlDateTime> interval)
    {
        CqlDateTime vzzzzzzzzzzh_ = context.Operators.Start(interval);
        int? vzzzzzzzzzzi_ = context.Operators.DateTimeComponentFrom(vzzzzzzzzzzh_, "year");
        int? vzzzzzzzzzzj_()
        {
            bool wzzzzzzzzzzd_()
            {
                CqlDateTime wzzzzzzzzzze_ = context.Operators.Start(interval);
                int? wzzzzzzzzzzf_ = context.Operators.DateTimeComponentFrom(wzzzzzzzzzze_, "month");

                return wzzzzzzzzzzf_ is null;
            };
            if (wzzzzzzzzzzd_())
            {
                return 0;
            }
            else
            {
                CqlDateTime wzzzzzzzzzzg_ = context.Operators.Start(interval);
                int? wzzzzzzzzzzh_ = context.Operators.DateTimeComponentFrom(wzzzzzzzzzzg_, "month");

                return wzzzzzzzzzzh_;
            }
        };
        int? vzzzzzzzzzzk_()
        {
            bool wzzzzzzzzzzi_()
            {
                CqlDateTime wzzzzzzzzzzj_ = context.Operators.Start(interval);
                int? wzzzzzzzzzzk_ = context.Operators.DateTimeComponentFrom(wzzzzzzzzzzj_, "day");

                return wzzzzzzzzzzk_ is null;
            };
            if (wzzzzzzzzzzi_())
            {
                return 0;
            }
            else
            {
                CqlDateTime wzzzzzzzzzzl_ = context.Operators.Start(interval);
                int? wzzzzzzzzzzm_ = context.Operators.DateTimeComponentFrom(wzzzzzzzzzzl_, "day");

                return wzzzzzzzzzzm_;
            }
        };
        int? vzzzzzzzzzzl_()
        {
            bool wzzzzzzzzzzn_()
            {
                CqlDateTime wzzzzzzzzzzo_ = context.Operators.Start(interval);
                int? wzzzzzzzzzzp_ = context.Operators.DateTimeComponentFrom(wzzzzzzzzzzo_, "hour");

                return wzzzzzzzzzzp_ is null;
            };
            if (wzzzzzzzzzzn_())
            {
                return 0;
            }
            else
            {
                CqlDateTime wzzzzzzzzzzq_ = context.Operators.Start(interval);
                int? wzzzzzzzzzzr_ = context.Operators.DateTimeComponentFrom(wzzzzzzzzzzq_, "hour");

                return wzzzzzzzzzzr_;
            }
        };
        int? vzzzzzzzzzzm_()
        {
            bool wzzzzzzzzzzs_()
            {
                CqlDateTime wzzzzzzzzzzt_ = context.Operators.Start(interval);
                int? wzzzzzzzzzzu_ = context.Operators.DateTimeComponentFrom(wzzzzzzzzzzt_, "minute");

                return wzzzzzzzzzzu_ is null;
            };
            if (wzzzzzzzzzzs_())
            {
                return 0;
            }
            else
            {
                CqlDateTime wzzzzzzzzzzv_ = context.Operators.Start(interval);
                int? wzzzzzzzzzzw_ = context.Operators.DateTimeComponentFrom(wzzzzzzzzzzv_, "minute");

                return wzzzzzzzzzzw_;
            }
        };
        int? vzzzzzzzzzzn_()
        {
            bool wzzzzzzzzzzx_()
            {
                CqlDateTime wzzzzzzzzzzy_ = context.Operators.Start(interval);
                int? wzzzzzzzzzzz_ = context.Operators.DateTimeComponentFrom(wzzzzzzzzzzy_, "second");

                return wzzzzzzzzzzz_ is null;
            };
            if (wzzzzzzzzzzx_())
            {
                return 0;
            }
            else
            {
                CqlDateTime xzzzzzzzzzza_ = context.Operators.Start(interval);
                int? xzzzzzzzzzzb_ = context.Operators.DateTimeComponentFrom(xzzzzzzzzzza_, "second");

                return xzzzzzzzzzzb_;
            }
        };
        int? vzzzzzzzzzzo_()
        {
            bool xzzzzzzzzzzc_()
            {
                CqlDateTime xzzzzzzzzzzd_ = context.Operators.Start(interval);
                int? xzzzzzzzzzze_ = context.Operators.DateTimeComponentFrom(xzzzzzzzzzzd_, "millisecond");

                return xzzzzzzzzzze_ is null;
            };
            if (xzzzzzzzzzzc_())
            {
                return 0;
            }
            else
            {
                CqlDateTime xzzzzzzzzzzf_ = context.Operators.Start(interval);
                int? xzzzzzzzzzzg_ = context.Operators.DateTimeComponentFrom(xzzzzzzzzzzf_, "millisecond");

                return xzzzzzzzzzzg_;
            }
        };
        CqlDateTime vzzzzzzzzzzp_ = context.Operators.End(interval);
        int? vzzzzzzzzzzq_ = context.Operators.DateTimeComponentFrom(vzzzzzzzzzzp_, "year");
        int? vzzzzzzzzzzr_()
        {
            bool xzzzzzzzzzzh_()
            {
                CqlDateTime xzzzzzzzzzzi_ = context.Operators.End(interval);
                int? xzzzzzzzzzzj_ = context.Operators.DateTimeComponentFrom(xzzzzzzzzzzi_, "month");

                return xzzzzzzzzzzj_ is null;
            };
            if (xzzzzzzzzzzh_())
            {
                return 0;
            }
            else
            {
                CqlDateTime xzzzzzzzzzzk_ = context.Operators.End(interval);
                int? xzzzzzzzzzzl_ = context.Operators.DateTimeComponentFrom(xzzzzzzzzzzk_, "month");

                return xzzzzzzzzzzl_;
            }
        };
        int? vzzzzzzzzzzs_()
        {
            bool xzzzzzzzzzzm_()
            {
                CqlDateTime xzzzzzzzzzzn_ = context.Operators.End(interval);
                int? xzzzzzzzzzzo_ = context.Operators.DateTimeComponentFrom(xzzzzzzzzzzn_, "day");

                return xzzzzzzzzzzo_ is null;
            };
            if (xzzzzzzzzzzm_())
            {
                return 0;
            }
            else
            {
                CqlDateTime xzzzzzzzzzzp_ = context.Operators.End(interval);
                int? xzzzzzzzzzzq_ = context.Operators.DateTimeComponentFrom(xzzzzzzzzzzp_, "day");

                return xzzzzzzzzzzq_;
            }
        };
        int? vzzzzzzzzzzt_()
        {
            bool xzzzzzzzzzzr_()
            {
                CqlDateTime xzzzzzzzzzzs_ = context.Operators.End(interval);
                int? xzzzzzzzzzzt_ = context.Operators.DateTimeComponentFrom(xzzzzzzzzzzs_, "hour");

                return xzzzzzzzzzzt_ is null;
            };
            if (xzzzzzzzzzzr_())
            {
                return 0;
            }
            else
            {
                CqlDateTime xzzzzzzzzzzu_ = context.Operators.End(interval);
                int? xzzzzzzzzzzv_ = context.Operators.DateTimeComponentFrom(xzzzzzzzzzzu_, "hour");

                return xzzzzzzzzzzv_;
            }
        };
        int? vzzzzzzzzzzu_()
        {
            bool xzzzzzzzzzzw_()
            {
                CqlDateTime xzzzzzzzzzzx_ = context.Operators.End(interval);
                int? xzzzzzzzzzzy_ = context.Operators.DateTimeComponentFrom(xzzzzzzzzzzx_, "minute");

                return xzzzzzzzzzzy_ is null;
            };
            if (xzzzzzzzzzzw_())
            {
                return 0;
            }
            else
            {
                CqlDateTime xzzzzzzzzzzz_ = context.Operators.End(interval);
                int? yzzzzzzzzzza_ = context.Operators.DateTimeComponentFrom(xzzzzzzzzzzz_, "minute");

                return yzzzzzzzzzza_;
            }
        };
        int? vzzzzzzzzzzv_()
        {
            bool yzzzzzzzzzzb_()
            {
                CqlDateTime yzzzzzzzzzzc_ = context.Operators.End(interval);
                int? yzzzzzzzzzzd_ = context.Operators.DateTimeComponentFrom(yzzzzzzzzzzc_, "second");

                return yzzzzzzzzzzd_ is null;
            };
            if (yzzzzzzzzzzb_())
            {
                return 0;
            }
            else
            {
                CqlDateTime yzzzzzzzzzze_ = context.Operators.End(interval);
                int? yzzzzzzzzzzf_ = context.Operators.DateTimeComponentFrom(yzzzzzzzzzze_, "second");

                return yzzzzzzzzzzf_;
            }
        };
        int? vzzzzzzzzzzw_()
        {
            bool yzzzzzzzzzzg_()
            {
                CqlDateTime yzzzzzzzzzzh_ = context.Operators.End(interval);
                int? yzzzzzzzzzzi_ = context.Operators.DateTimeComponentFrom(yzzzzzzzzzzh_, "millisecond");

                return yzzzzzzzzzzi_ is null;
            };
            if (yzzzzzzzzzzg_())
            {
                return 0;
            }
            else
            {
                CqlDateTime yzzzzzzzzzzj_ = context.Operators.End(interval);
                int? yzzzzzzzzzzk_ = context.Operators.DateTimeComponentFrom(yzzzzzzzzzzj_, "millisecond");

                return yzzzzzzzzzzk_;
            }
        };
        (CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)? vzzzzzzzzzzx_ = (CqlTupleMetadata_FcQREFSfPJSKYAhSEWVJcZVED, vzzzzzzzzzzi_, vzzzzzzzzzzj_(), vzzzzzzzzzzk_(), vzzzzzzzzzzl_(), vzzzzzzzzzzm_(), vzzzzzzzzzzn_(), vzzzzzzzzzzo_(), vzzzzzzzzzzq_, vzzzzzzzzzzr_(), vzzzzzzzzzzs_(), vzzzzzzzzzzt_(), vzzzzzzzzzzu_(), vzzzzzzzzzzv_(), vzzzzzzzzzzw_());
        (CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)?[] vzzzzzzzzzzy_ = [
            vzzzzzzzzzzx_,
        ];
        CqlInterval<CqlDateTime> vzzzzzzzzzzz_((CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)? i)
        {
            int? yzzzzzzzzzzl_ = i?.StartYear;
            int? yzzzzzzzzzzm_ = i?.StartMonth;
            int? yzzzzzzzzzzn_ = i?.StartDay;
            int? yzzzzzzzzzzo_ = i?.StartHour;
            int? yzzzzzzzzzzp_ = i?.StartMinute;
            int? yzzzzzzzzzzq_ = i?.StartSecond;
            int? yzzzzzzzzzzr_ = i?.StartMillisecond;
            CqlDateTime yzzzzzzzzzzs_ = context.Operators.DateTime(yzzzzzzzzzzl_, yzzzzzzzzzzm_, yzzzzzzzzzzn_, yzzzzzzzzzzo_, yzzzzzzzzzzp_, yzzzzzzzzzzq_, yzzzzzzzzzzr_, default);
            int? yzzzzzzzzzzt_ = i?.EndYear;
            int? yzzzzzzzzzzu_ = i?.EndMonth;
            int? yzzzzzzzzzzv_ = i?.EndDay;
            int? yzzzzzzzzzzw_ = i?.EndHour;
            int? yzzzzzzzzzzx_ = i?.EndMinute;
            int? yzzzzzzzzzzy_ = i?.EndSecond;
            int? yzzzzzzzzzzz_ = i?.EndMillisecond;
            CqlDateTime zzzzzzzzzzza_ = context.Operators.DateTime(yzzzzzzzzzzt_, yzzzzzzzzzzu_, yzzzzzzzzzzv_, yzzzzzzzzzzw_, yzzzzzzzzzzx_, yzzzzzzzzzzy_, yzzzzzzzzzzz_, default);
            CqlInterval<CqlDateTime> zzzzzzzzzzzb_ = context.Operators.Interval(yzzzzzzzzzzs_, zzzzzzzzzzza_, true, true);

            return zzzzzzzzzzzb_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> wzzzzzzzzzza_ = context.Operators.Select<(CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)?, CqlInterval<CqlDateTime>>((IEnumerable<(CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)?>)vzzzzzzzzzzy_, vzzzzzzzzzzz_);
        IEnumerable<CqlInterval<CqlDateTime>> wzzzzzzzzzzb_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(wzzzzzzzzzza_);
        CqlInterval<CqlDateTime> wzzzzzzzzzzc_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(wzzzzzzzzzzb_);

        return wzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Collapsed DateTime Interval Stats")]
    public (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? Collapsed_DateTime_Interval_Stats(CqlContext context, IEnumerable<CqlInterval<CqlDateTime>> collapsedIntervals)
    {
        int? zzzzzzzzzzzc_ = context.Operators.Count<CqlInterval<CqlDateTime>>(collapsedIntervals);
        int? zzzzzzzzzzzd_()
        {
            bool zzzzzzzzzzzh_()
            {
                int? zzzzzzzzzzzi_ = context.Operators.Count<CqlInterval<CqlDateTime>>(collapsedIntervals);
                bool? zzzzzzzzzzzj_ = context.Operators.Equal(zzzzzzzzzzzi_, 0);

                return zzzzzzzzzzzj_ ?? false;
            };
            if (zzzzzzzzzzzh_())
            {
                return 0;
            }
            else
            {
                int? zzzzzzzzzzzk_(CqlInterval<CqlDateTime> I)
                {
                    CqlInterval<CqlDateTime> zzzzzzzzzzzo_ = this.DateTime_Interval_Set_Nulls_to_Zero(context, I);
                    CqlDateTime zzzzzzzzzzzp_ = context.Operators.Start(zzzzzzzzzzzo_);
                    CqlDateTime zzzzzzzzzzzr_ = context.Operators.End(zzzzzzzzzzzo_);
                    int? zzzzzzzzzzzs_ = context.Operators.DurationBetween(zzzzzzzzzzzp_, zzzzzzzzzzzr_, "day");
                    int? zzzzzzzzzzzt_ = context.Operators.Add(zzzzzzzzzzzs_, 1);
                    int?[] zzzzzzzzzzzu_ = [
                        zzzzzzzzzzzt_,
                        0,
                    ];
                    int? zzzzzzzzzzzv_ = context.Operators.Max<int?>(zzzzzzzzzzzu_ as IEnumerable<int?>);

                    return zzzzzzzzzzzv_;
                };
                IEnumerable<int?> zzzzzzzzzzzl_ = context.Operators.Select<CqlInterval<CqlDateTime>, int?>(collapsedIntervals, zzzzzzzzzzzk_);
                IEnumerable<int?> zzzzzzzzzzzm_ = context.Operators.Distinct<int?>(zzzzzzzzzzzl_);
                int? zzzzzzzzzzzn_ = context.Operators.Sum(zzzzzzzzzzzm_);

                return zzzzzzzzzzzn_;
            }
        };
        CqlInterval<CqlDateTime> zzzzzzzzzzze_()
        {
            bool zzzzzzzzzzzw_()
            {
                int? zzzzzzzzzzzx_ = context.Operators.Count<CqlInterval<CqlDateTime>>(collapsedIntervals);
                bool? zzzzzzzzzzzy_ = context.Operators.Equal(zzzzzzzzzzzx_, 0);

                return zzzzzzzzzzzy_ ?? false;
            };
            if (zzzzzzzzzzzw_())
            {
                return null as CqlInterval<CqlDateTime>;
            }
            else
            {
                (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? zzzzzzzzzzzz_(CqlInterval<CqlDateTime> I)
                {
                    CqlInterval<CqlDateTime> azzzzzzzzzzzg_ = this.DateTime_Interval_Set_Nulls_to_Zero(context, I);
                    CqlDateTime azzzzzzzzzzzh_ = context.Operators.Start(azzzzzzzzzzzg_);
                    CqlDateTime azzzzzzzzzzzj_ = context.Operators.End(azzzzzzzzzzzg_);
                    int? azzzzzzzzzzzk_ = context.Operators.DurationBetween(azzzzzzzzzzzh_, azzzzzzzzzzzj_, "day");
                    int? azzzzzzzzzzzl_ = context.Operators.Add(azzzzzzzzzzzk_, 1);
                    int?[] azzzzzzzzzzzm_ = [
                        azzzzzzzzzzzl_,
                        0,
                    ];
                    int? azzzzzzzzzzzn_ = context.Operators.Max<int?>(azzzzzzzzzzzm_ as IEnumerable<int?>);
                    (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? azzzzzzzzzzzo_ = (CqlTupleMetadata_CGHEUIgjaCjJVKEADTSZEbdCL, I, azzzzzzzzzzzn_);

                    return azzzzzzzzzzzo_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> azzzzzzzzzzza_ = context.Operators.Select<CqlInterval<CqlDateTime>, (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(collapsedIntervals, zzzzzzzzzzzz_);
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> azzzzzzzzzzzb_ = context.Operators.Distinct<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(azzzzzzzzzzza_);
                object azzzzzzzzzzzc_((CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? @this)
                {
                    int? azzzzzzzzzzzp_ = @this?.days;

                    return azzzzzzzzzzzp_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> azzzzzzzzzzzd_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(azzzzzzzzzzzb_, azzzzzzzzzzzc_, System.ComponentModel.ListSortDirection.Descending);
                (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? azzzzzzzzzzze_ = context.Operators.First<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(azzzzzzzzzzzd_);
                CqlInterval<CqlDateTime> azzzzzzzzzzzf_ = azzzzzzzzzzze_?.interval;

                return azzzzzzzzzzzf_;
            }
        };
        int? zzzzzzzzzzzf_()
        {
            bool azzzzzzzzzzzq_()
            {
                int? azzzzzzzzzzzr_ = context.Operators.Count<CqlInterval<CqlDateTime>>(collapsedIntervals);
                bool? azzzzzzzzzzzs_ = context.Operators.Equal(azzzzzzzzzzzr_, 0);

                return azzzzzzzzzzzs_ ?? false;
            };
            if (azzzzzzzzzzzq_())
            {
                return 0;
            }
            else
            {
                (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? azzzzzzzzzzzt_(CqlInterval<CqlDateTime> I)
                {
                    CqlInterval<CqlDateTime> bzzzzzzzzzzzp_ = this.DateTime_Interval_Set_Nulls_to_Zero(context, I);
                    CqlDateTime bzzzzzzzzzzzq_ = context.Operators.Start(bzzzzzzzzzzzp_);
                    CqlDateTime bzzzzzzzzzzzs_ = context.Operators.End(bzzzzzzzzzzzp_);
                    int? bzzzzzzzzzzzt_ = context.Operators.DurationBetween(bzzzzzzzzzzzq_, bzzzzzzzzzzzs_, "day");
                    int? bzzzzzzzzzzzu_ = context.Operators.Add(bzzzzzzzzzzzt_, 1);
                    int?[] bzzzzzzzzzzzv_ = [
                        bzzzzzzzzzzzu_,
                        0,
                    ];
                    int? bzzzzzzzzzzzw_ = context.Operators.Max<int?>(bzzzzzzzzzzzv_ as IEnumerable<int?>);
                    (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? bzzzzzzzzzzzx_ = (CqlTupleMetadata_CGHEUIgjaCjJVKEADTSZEbdCL, I, bzzzzzzzzzzzw_);

                    return bzzzzzzzzzzzx_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> azzzzzzzzzzzu_ = context.Operators.Select<CqlInterval<CqlDateTime>, (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(collapsedIntervals, azzzzzzzzzzzt_);
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> azzzzzzzzzzzv_ = context.Operators.Distinct<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(azzzzzzzzzzzu_);
                object azzzzzzzzzzzw_((CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? @this)
                {
                    int? bzzzzzzzzzzzy_ = @this?.days;

                    return bzzzzzzzzzzzy_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> azzzzzzzzzzzx_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(azzzzzzzzzzzv_, azzzzzzzzzzzw_, System.ComponentModel.ListSortDirection.Descending);
                (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? azzzzzzzzzzzy_ = context.Operators.First<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(azzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> azzzzzzzzzzzz_ = azzzzzzzzzzzy_?.interval;
                CqlInterval<CqlDateTime> bzzzzzzzzzzza_ = this.DateTime_Interval_Set_Nulls_to_Zero(context, azzzzzzzzzzzz_);
                CqlDateTime bzzzzzzzzzzzb_ = context.Operators.Start(bzzzzzzzzzzza_);
                (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? bzzzzzzzzzzzc_(CqlInterval<CqlDateTime> I)
                {
                    CqlInterval<CqlDateTime> bzzzzzzzzzzzz_ = this.DateTime_Interval_Set_Nulls_to_Zero(context, I);
                    CqlDateTime czzzzzzzzzzza_ = context.Operators.Start(bzzzzzzzzzzzz_);
                    CqlDateTime czzzzzzzzzzzc_ = context.Operators.End(bzzzzzzzzzzzz_);
                    int? czzzzzzzzzzzd_ = context.Operators.DurationBetween(czzzzzzzzzzza_, czzzzzzzzzzzc_, "day");
                    int? czzzzzzzzzzze_ = context.Operators.Add(czzzzzzzzzzzd_, 1);
                    int?[] czzzzzzzzzzzf_ = [
                        czzzzzzzzzzze_,
                        0,
                    ];
                    int? czzzzzzzzzzzg_ = context.Operators.Max<int?>(czzzzzzzzzzzf_ as IEnumerable<int?>);
                    (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? czzzzzzzzzzzh_ = (CqlTupleMetadata_CGHEUIgjaCjJVKEADTSZEbdCL, I, czzzzzzzzzzzg_);

                    return czzzzzzzzzzzh_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> bzzzzzzzzzzzd_ = context.Operators.Select<CqlInterval<CqlDateTime>, (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(collapsedIntervals, bzzzzzzzzzzzc_);
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> bzzzzzzzzzzze_ = context.Operators.Distinct<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(bzzzzzzzzzzzd_);
                object bzzzzzzzzzzzf_((CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? @this)
                {
                    int? czzzzzzzzzzzi_ = @this?.days;

                    return czzzzzzzzzzzi_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> bzzzzzzzzzzzg_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(bzzzzzzzzzzze_, bzzzzzzzzzzzf_, System.ComponentModel.ListSortDirection.Descending);
                (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? bzzzzzzzzzzzh_ = context.Operators.First<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(bzzzzzzzzzzzg_);
                CqlInterval<CqlDateTime> bzzzzzzzzzzzi_ = bzzzzzzzzzzzh_?.interval;
                CqlInterval<CqlDateTime> bzzzzzzzzzzzj_ = this.DateTime_Interval_Set_Nulls_to_Zero(context, bzzzzzzzzzzzi_);
                CqlDateTime bzzzzzzzzzzzk_ = context.Operators.End(bzzzzzzzzzzzj_);
                int? bzzzzzzzzzzzl_ = context.Operators.DurationBetween(bzzzzzzzzzzzb_, bzzzzzzzzzzzk_, "day");
                int? bzzzzzzzzzzzm_ = context.Operators.Add(bzzzzzzzzzzzl_, 1);
                int?[] bzzzzzzzzzzzn_ = [
                    bzzzzzzzzzzzm_,
                    0,
                ];
                int? bzzzzzzzzzzzo_ = context.Operators.Max<int?>(bzzzzzzzzzzzn_ as IEnumerable<int?>);

                return bzzzzzzzzzzzo_;
            }
        };
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? zzzzzzzzzzzg_ = (CqlTupleMetadata_HDihbLieYfQbgeSbOWZBAMUIQ, collapsedIntervals, zzzzzzzzzzzc_, zzzzzzzzzzzd_(), zzzzzzzzzzze_(), zzzzzzzzzzzf_());

        return zzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("DateTime Interval Covering Relative to Base Interval Stats")]
    public (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? DateTime_Interval_Covering_Relative_to_Base_Interval_Stats(CqlContext context, CqlInterval<CqlDateTime> baseInterval, IEnumerable<CqlInterval<CqlDateTime>> coveringIntervals)
    {
        IEnumerable<CqlInterval<CqlDateTime>> czzzzzzzzzzzj_ = this.DateTime_Interval_Covering_Relative_to_Base_Interval(context, baseInterval, coveringIntervals);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Covering_Intervals)? czzzzzzzzzzzk_ = (CqlTupleMetadata_GZMPWdGOJiTNjfWAcbZMePdXV, czzzzzzzzzzzj_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Covering_Intervals)?[] czzzzzzzzzzzl_ = [
            czzzzzzzzzzzk_,
        ];
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? czzzzzzzzzzzm_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Covering_Intervals)? variableDeclarations)
        {
            IEnumerable<CqlInterval<CqlDateTime>> czzzzzzzzzzzq_ = variableDeclarations?.Covering_Intervals;
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? czzzzzzzzzzzr_ = this.Collapsed_DateTime_Interval_Stats(context, czzzzzzzzzzzq_);

            return czzzzzzzzzzzr_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?> czzzzzzzzzzzn_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Covering_Intervals)?, (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Covering_Intervals)?>)czzzzzzzzzzzl_, czzzzzzzzzzzm_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?> czzzzzzzzzzzo_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?>(czzzzzzzzzzzn_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? czzzzzzzzzzzp_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?>(czzzzzzzzzzzo_);

        return czzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("DateTime Interval Gaps Relative to Base Interval Stats")]
    public (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? DateTime_Interval_Gaps_Relative_to_Base_Interval_Stats(CqlContext context, CqlInterval<CqlDateTime> baseInterval, IEnumerable<CqlInterval<CqlDateTime>> coveringIntervals)
    {
        IEnumerable<CqlInterval<CqlDateTime>> czzzzzzzzzzzs_ = this.DateTime_Interval_Gaps_Relative_to_Base_Interval(context, baseInterval, coveringIntervals);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Gap_Intervals)? czzzzzzzzzzzt_ = (CqlTupleMetadata_CKbERRbOPGNBBERUOghhaOYSE, czzzzzzzzzzzs_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Gap_Intervals)?[] czzzzzzzzzzzu_ = [
            czzzzzzzzzzzt_,
        ];
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? czzzzzzzzzzzv_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Gap_Intervals)? variableDeclarations)
        {
            IEnumerable<CqlInterval<CqlDateTime>> czzzzzzzzzzzz_ = variableDeclarations?.Gap_Intervals;
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? dzzzzzzzzzzza_ = this.Collapsed_DateTime_Interval_Stats(context, czzzzzzzzzzzz_);

            return dzzzzzzzzzzza_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?> czzzzzzzzzzzw_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Gap_Intervals)?, (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Gap_Intervals)?>)czzzzzzzzzzzu_, czzzzzzzzzzzv_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?> czzzzzzzzzzzx_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?>(czzzzzzzzzzzw_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? czzzzzzzzzzzy_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?>(czzzzzzzzzzzx_);

        return czzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Convert To UTC DateTime")]
    public CqlDateTime Convert_To_UTC_DateTime(CqlContext context, CqlDate d)
    {
        int? dzzzzzzzzzzzb_ = context.Operators.DateTimeComponentFrom(d, "year");
        int? dzzzzzzzzzzzc_()
        {
            if ((context.Operators.DateTimeComponentFrom(d, "month")) is null)
            {
                return 0;
            }
            else
            {
                int? dzzzzzzzzzzzk_ = context.Operators.DateTimeComponentFrom(d, "month");

                return dzzzzzzzzzzzk_;
            }
        };
        int? dzzzzzzzzzzzd_()
        {
            if ((context.Operators.DateTimeComponentFrom(d, "day")) is null)
            {
                return 0;
            }
            else
            {
                int? dzzzzzzzzzzzl_ = context.Operators.DateTimeComponentFrom(d, "day");

                return dzzzzzzzzzzzl_;
            }
        };
        (CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)? dzzzzzzzzzzze_ = (CqlTupleMetadata_FcQREFSfPJSKYAhSEWVJcZVED, dzzzzzzzzzzzb_, dzzzzzzzzzzzc_(), dzzzzzzzzzzzd_(), default, default, default, default, default, default, default, default, default, default, default);
        (CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)?[] dzzzzzzzzzzzf_ = [
            dzzzzzzzzzzze_,
        ];
        CqlDateTime dzzzzzzzzzzzg_((CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)? i)
        {
            int? dzzzzzzzzzzzm_ = i?.StartYear;
            int? dzzzzzzzzzzzn_ = i?.StartMonth;
            int? dzzzzzzzzzzzo_ = i?.StartDay;
            decimal? dzzzzzzzzzzzp_ = context.Operators.ConvertIntegerToDecimal(0);
            CqlDateTime dzzzzzzzzzzzq_ = context.Operators.DateTime(dzzzzzzzzzzzm_, dzzzzzzzzzzzn_, dzzzzzzzzzzzo_, 0, 0, 0, 0, dzzzzzzzzzzzp_);

            return dzzzzzzzzzzzq_;
        };
        IEnumerable<CqlDateTime> dzzzzzzzzzzzh_ = context.Operators.Select<(CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)?, CqlDateTime>((IEnumerable<(CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)?>)dzzzzzzzzzzzf_, dzzzzzzzzzzzg_);
        IEnumerable<CqlDateTime> dzzzzzzzzzzzi_ = context.Operators.Distinct<CqlDateTime>(dzzzzzzzzzzzh_);
        CqlDateTime dzzzzzzzzzzzj_ = context.Operators.SingletonFrom<CqlDateTime>(dzzzzzzzzzzzi_);

        return dzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Convert Interval Date to UTC Interval DateTime")]
    public CqlInterval<CqlDateTime> Convert_Interval_Date_to_UTC_Interval_DateTime(CqlContext context, CqlInterval<CqlDate> interval)
    {
        CqlDate dzzzzzzzzzzzr_ = context.Operators.Start(interval);
        CqlDateTime dzzzzzzzzzzzs_ = this.Convert_To_UTC_DateTime(context, dzzzzzzzzzzzr_);
        CqlDate dzzzzzzzzzzzt_ = context.Operators.End(interval);
        CqlDateTime dzzzzzzzzzzzu_ = this.Convert_To_UTC_DateTime(context, dzzzzzzzzzzzt_);
        CqlInterval<CqlDateTime> dzzzzzzzzzzzv_ = context.Operators.Interval(dzzzzzzzzzzzs_, dzzzzzzzzzzzu_, true, true);

        return dzzzzzzzzzzzv_;
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
