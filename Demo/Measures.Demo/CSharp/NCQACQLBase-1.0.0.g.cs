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
        IEnumerable<CqlInterval<CqlDate>> izzzzzzzzzzza_()
        {
            bool izzzzzzzzzzzb_()
            {
                int? izzzzzzzzzzzc_ = context.Operators.Count<CqlInterval<CqlDate>>(intervals);
                bool? izzzzzzzzzzzd_ = context.Operators.Equal(izzzzzzzzzzzc_, 0);

                return izzzzzzzzzzzd_ ?? false;
            };
            if (intervals is null)
            {
                CqlInterval<CqlDate>[] izzzzzzzzzzze_ = []
;

                return izzzzzzzzzzze_ as IEnumerable<CqlInterval<CqlDate>>;
            }
            else if (izzzzzzzzzzzb_())
            {
                CqlInterval<CqlDate>[] izzzzzzzzzzzf_ = []
;

                return izzzzzzzzzzzf_ as IEnumerable<CqlInterval<CqlDate>>;
            }
            else
            {
                (CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)? izzzzzzzzzzzg_(CqlInterval<CqlDate> I)
                {
                    CqlDate izzzzzzzzzzzo_()
                    {
                        if ((context.Operators.Start(I)) is null)
                        {
                            CqlDate izzzzzzzzzzzq_ = context.Operators.MinValue<CqlDate>();

                            return izzzzzzzzzzzq_;
                        }
                        else
                        {
                            CqlDate izzzzzzzzzzzr_ = context.Operators.Start(I);

                            return izzzzzzzzzzzr_;
                        }
                    };
                    (CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)? izzzzzzzzzzzp_ = (CqlTupleMetadata_GIMHfXDcFiAjSJBDGYeUeZLhW, I, izzzzzzzzzzzo_());

                    return izzzzzzzzzzzp_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)?> izzzzzzzzzzzh_ = context.Operators.Select<CqlInterval<CqlDate>, (CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)?>(intervals, izzzzzzzzzzzg_);
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)?> izzzzzzzzzzzi_ = context.Operators.Distinct<(CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)?>(izzzzzzzzzzzh_);
                object izzzzzzzzzzzj_((CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)? @this)
                {
                    CqlDate izzzzzzzzzzzs_ = @this?.startOfInterval;

                    return izzzzzzzzzzzs_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)?> izzzzzzzzzzzk_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)?>(izzzzzzzzzzzi_, izzzzzzzzzzzj_, System.ComponentModel.ListSortDirection.Ascending);
                CqlInterval<CqlDate> izzzzzzzzzzzl_((CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)? sortedIntervals)
                {
                    CqlInterval<CqlDate> izzzzzzzzzzzt_ = sortedIntervals?.interval;

                    return izzzzzzzzzzzt_;
                };
                IEnumerable<CqlInterval<CqlDate>> izzzzzzzzzzzm_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)?, CqlInterval<CqlDate>>(izzzzzzzzzzzk_, izzzzzzzzzzzl_);
                IEnumerable<CqlInterval<CqlDate>> izzzzzzzzzzzn_ = context.Operators.Distinct<CqlInterval<CqlDate>>(izzzzzzzzzzzm_);

                return izzzzzzzzzzzn_;
            }
        };

        return izzzzzzzzzzza_();
    }


    [CqlExpressionDefinition("Sort DateTime Intervals")]
    public IEnumerable<CqlInterval<CqlDateTime>> Sort_DateTime_Intervals(CqlContext context, IEnumerable<CqlInterval<CqlDateTime>> intervals)
    {
        IEnumerable<CqlInterval<CqlDateTime>> izzzzzzzzzzzu_()
        {
            bool izzzzzzzzzzzv_()
            {
                int? izzzzzzzzzzzw_ = context.Operators.Count<CqlInterval<CqlDateTime>>(intervals);
                bool? izzzzzzzzzzzx_ = context.Operators.Equal(izzzzzzzzzzzw_, 0);

                return izzzzzzzzzzzx_ ?? false;
            };
            if (intervals is null)
            {
                CqlInterval<CqlDateTime>[] izzzzzzzzzzzy_ = []
;

                return izzzzzzzzzzzy_ as IEnumerable<CqlInterval<CqlDateTime>>;
            }
            else if (izzzzzzzzzzzv_())
            {
                CqlInterval<CqlDateTime>[] izzzzzzzzzzzz_ = []
;

                return izzzzzzzzzzzz_ as IEnumerable<CqlInterval<CqlDateTime>>;
            }
            else
            {
                (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)? jzzzzzzzzzzza_(CqlInterval<CqlDateTime> I)
                {
                    CqlDateTime jzzzzzzzzzzzi_()
                    {
                        if ((context.Operators.Start(I)) is null)
                        {
                            CqlDateTime jzzzzzzzzzzzk_ = context.Operators.MinValue<CqlDateTime>();

                            return jzzzzzzzzzzzk_;
                        }
                        else
                        {
                            CqlDateTime jzzzzzzzzzzzl_ = context.Operators.Start(I);

                            return jzzzzzzzzzzzl_;
                        }
                    };
                    (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)? jzzzzzzzzzzzj_ = (CqlTupleMetadata_EQHOUSiiWahbJPOUjJGEhIAOV, I, jzzzzzzzzzzzi_());

                    return jzzzzzzzzzzzj_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?> jzzzzzzzzzzzb_ = context.Operators.Select<CqlInterval<CqlDateTime>, (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?>(intervals, jzzzzzzzzzzza_);
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?> jzzzzzzzzzzzc_ = context.Operators.Distinct<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?>(jzzzzzzzzzzzb_);
                object jzzzzzzzzzzzd_((CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)? @this)
                {
                    CqlDateTime jzzzzzzzzzzzm_ = @this?.startOfInterval;

                    return jzzzzzzzzzzzm_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?> jzzzzzzzzzzze_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?>(jzzzzzzzzzzzc_, jzzzzzzzzzzzd_, System.ComponentModel.ListSortDirection.Ascending);
                CqlInterval<CqlDateTime> jzzzzzzzzzzzf_((CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)? sortedIntervals)
                {
                    CqlInterval<CqlDateTime> jzzzzzzzzzzzn_ = sortedIntervals?.interval;

                    return jzzzzzzzzzzzn_;
                };
                IEnumerable<CqlInterval<CqlDateTime>> jzzzzzzzzzzzg_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?, CqlInterval<CqlDateTime>>(jzzzzzzzzzzze_, jzzzzzzzzzzzf_);
                IEnumerable<CqlInterval<CqlDateTime>> jzzzzzzzzzzzh_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(jzzzzzzzzzzzg_);

                return jzzzzzzzzzzzh_;
            }
        };

        return izzzzzzzzzzzu_();
    }


    [CqlExpressionDefinition("Collapse Date Interval Workaround")]
    public IEnumerable<CqlInterval<CqlDate>> Collapse_Date_Interval_Workaround(CqlContext context, IEnumerable<CqlInterval<CqlDate>> intervals)
    {
        IEnumerable<CqlInterval<CqlDate>> jzzzzzzzzzzzo_()
        {
            bool jzzzzzzzzzzzp_()
            {
                int? jzzzzzzzzzzzq_ = context.Operators.Count<CqlInterval<CqlDate>>(intervals);
                bool? jzzzzzzzzzzzr_ = context.Operators.Equal(jzzzzzzzzzzzq_, 0);

                return jzzzzzzzzzzzr_ ?? false;
            };
            if (intervals is null)
            {
                CqlInterval<CqlDate>[] jzzzzzzzzzzzs_ = []
;

                return jzzzzzzzzzzzs_ as IEnumerable<CqlInterval<CqlDate>>;
            }
            else if (jzzzzzzzzzzzp_())
            {
                CqlInterval<CqlDate>[] jzzzzzzzzzzzt_ = []
;

                return jzzzzzzzzzzzt_ as IEnumerable<CqlInterval<CqlDate>>;
            }
            else
            {
                bool? jzzzzzzzzzzzu_(CqlInterval<CqlDate> I)
                {
                    bool? jzzzzzzzzzzzx_(CqlInterval<CqlDate> J)
                    {
                        bool? kzzzzzzzzzzzc_ = context.Operators.IntervalProperlyIncludesInterval<CqlDate>(J, I, default);

                        return kzzzzzzzzzzzc_;
                    };
                    IEnumerable<bool?> jzzzzzzzzzzzy_ = context.Operators.Select<CqlInterval<CqlDate>, bool?>(intervals, jzzzzzzzzzzzx_);
                    IEnumerable<bool?> jzzzzzzzzzzzz_ = context.Operators.Distinct<bool?>(jzzzzzzzzzzzy_);
                    bool? kzzzzzzzzzzza_ = context.Operators.AnyTrue(jzzzzzzzzzzzz_);
                    bool? kzzzzzzzzzzzb_ = context.Operators.Not(kzzzzzzzzzzza_);

                    return kzzzzzzzzzzzb_;
                };
                IEnumerable<CqlInterval<CqlDate>> jzzzzzzzzzzzv_ = context.Operators.Where<CqlInterval<CqlDate>>(intervals, jzzzzzzzzzzzu_);
                IEnumerable<CqlInterval<CqlDate>> jzzzzzzzzzzzw_ = context.Operators.Collapse(jzzzzzzzzzzzv_, "day");

                return jzzzzzzzzzzzw_;
            }
        };

        return jzzzzzzzzzzzo_();
    }


    [CqlExpressionDefinition("Collapse DateTime Interval Workaround")]
    public IEnumerable<CqlInterval<CqlDateTime>> Collapse_DateTime_Interval_Workaround(CqlContext context, IEnumerable<CqlInterval<CqlDateTime>> intervals)
    {
        IEnumerable<CqlInterval<CqlDateTime>> kzzzzzzzzzzzd_()
        {
            bool kzzzzzzzzzzze_()
            {
                int? kzzzzzzzzzzzf_ = context.Operators.Count<CqlInterval<CqlDateTime>>(intervals);
                bool? kzzzzzzzzzzzg_ = context.Operators.Equal(kzzzzzzzzzzzf_, 0);

                return kzzzzzzzzzzzg_ ?? false;
            };
            if (intervals is null)
            {
                CqlInterval<CqlDateTime>[] kzzzzzzzzzzzh_ = []
;

                return kzzzzzzzzzzzh_ as IEnumerable<CqlInterval<CqlDateTime>>;
            }
            else if (kzzzzzzzzzzze_())
            {
                CqlInterval<CqlDateTime>[] kzzzzzzzzzzzi_ = []
;

                return kzzzzzzzzzzzi_ as IEnumerable<CqlInterval<CqlDateTime>>;
            }
            else
            {
                bool? kzzzzzzzzzzzj_(CqlInterval<CqlDateTime> I)
                {
                    bool? kzzzzzzzzzzzm_(CqlInterval<CqlDateTime> J)
                    {
                        bool? kzzzzzzzzzzzr_ = context.Operators.IntervalProperlyIncludesInterval<CqlDateTime>(J, I, default);

                        return kzzzzzzzzzzzr_;
                    };
                    IEnumerable<bool?> kzzzzzzzzzzzn_ = context.Operators.Select<CqlInterval<CqlDateTime>, bool?>(intervals, kzzzzzzzzzzzm_);
                    IEnumerable<bool?> kzzzzzzzzzzzo_ = context.Operators.Distinct<bool?>(kzzzzzzzzzzzn_);
                    bool? kzzzzzzzzzzzp_ = context.Operators.AnyTrue(kzzzzzzzzzzzo_);
                    bool? kzzzzzzzzzzzq_ = context.Operators.Not(kzzzzzzzzzzzp_);

                    return kzzzzzzzzzzzq_;
                };
                IEnumerable<CqlInterval<CqlDateTime>> kzzzzzzzzzzzk_ = context.Operators.Where<CqlInterval<CqlDateTime>>(intervals, kzzzzzzzzzzzj_);
                IEnumerable<CqlInterval<CqlDateTime>> kzzzzzzzzzzzl_ = context.Operators.Collapse(kzzzzzzzzzzzk_, default);

                return kzzzzzzzzzzzl_;
            }
        };

        return kzzzzzzzzzzzd_();
    }


    [CqlExpressionDefinition("Date Interval Covering Relative to Base Interval")]
    public IEnumerable<CqlInterval<CqlDate>> Date_Interval_Covering_Relative_to_Base_Interval(CqlContext context, CqlInterval<CqlDate> baseInterval, IEnumerable<CqlInterval<CqlDate>> coveringIntervals)
    {
        IEnumerable<CqlInterval<CqlDate>> kzzzzzzzzzzzs_ = this.Sort_Date_Intervals(context, coveringIntervals);
        CqlInterval<CqlDate> kzzzzzzzzzzzt_(CqlInterval<CqlDate> sortedInterval)
        {
            CqlInterval<CqlDate> kzzzzzzzzzzzx_ = context.Operators.Intersect<CqlDate>(baseInterval, sortedInterval);

            return kzzzzzzzzzzzx_;
        };
        IEnumerable<CqlInterval<CqlDate>> kzzzzzzzzzzzu_ = context.Operators.Select<CqlInterval<CqlDate>, CqlInterval<CqlDate>>(kzzzzzzzzzzzs_, kzzzzzzzzzzzt_);
        IEnumerable<CqlInterval<CqlDate>> kzzzzzzzzzzzv_ = context.Operators.Distinct<CqlInterval<CqlDate>>(kzzzzzzzzzzzu_);
        IEnumerable<CqlInterval<CqlDate>> kzzzzzzzzzzzw_ = this.Collapse_Date_Interval_Workaround(context, kzzzzzzzzzzzv_);

        return kzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("DateTime Interval Covering Relative to Base Interval")]
    public IEnumerable<CqlInterval<CqlDateTime>> DateTime_Interval_Covering_Relative_to_Base_Interval(CqlContext context, CqlInterval<CqlDateTime> baseInterval, IEnumerable<CqlInterval<CqlDateTime>> coveringIntervals)
    {
        IEnumerable<CqlInterval<CqlDateTime>> kzzzzzzzzzzzy_ = this.Sort_DateTime_Intervals(context, coveringIntervals);
        CqlInterval<CqlDateTime> kzzzzzzzzzzzz_(CqlInterval<CqlDateTime> sortedInterval)
        {
            CqlInterval<CqlDateTime> lzzzzzzzzzzzd_ = context.Operators.Intersect<CqlDateTime>(baseInterval, sortedInterval);

            return lzzzzzzzzzzzd_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> lzzzzzzzzzzza_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(kzzzzzzzzzzzy_, kzzzzzzzzzzzz_);
        IEnumerable<CqlInterval<CqlDateTime>> lzzzzzzzzzzzb_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(lzzzzzzzzzzza_);
        IEnumerable<CqlInterval<CqlDateTime>> lzzzzzzzzzzzc_ = this.Collapse_DateTime_Interval_Workaround(context, lzzzzzzzzzzzb_);

        return lzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Date Interval Gaps Relative to Base Interval")]
    public IEnumerable<CqlInterval<CqlDate>> Date_Interval_Gaps_Relative_to_Base_Interval(CqlContext context, CqlInterval<CqlDate> baseInterval, IEnumerable<CqlInterval<CqlDate>> coveringIntervals)
    {
        IEnumerable<CqlInterval<CqlDate>> lzzzzzzzzzzze_ = this.Date_Interval_Covering_Relative_to_Base_Interval(context, baseInterval, coveringIntervals);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> sortedCoverings)? lzzzzzzzzzzzf_ = (CqlTupleMetadata_EVRLVXPcBiDTIWfCCfKEWDfKI, lzzzzzzzzzzze_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> sortedCoverings)?[] lzzzzzzzzzzzg_ = [
            lzzzzzzzzzzzf_,
        ];
        IEnumerable<CqlInterval<CqlDate>> lzzzzzzzzzzzh_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> sortedCoverings)? variableDeclarations)
        {
            IEnumerable<CqlInterval<CqlDate>> lzzzzzzzzzzzl_()
            {
                bool lzzzzzzzzzzzt_()
                {
                    IEnumerable<CqlInterval<CqlDate>> lzzzzzzzzzzzu_ = variableDeclarations?.sortedCoverings;
                    int? lzzzzzzzzzzzv_ = context.Operators.Count<CqlInterval<CqlDate>>(lzzzzzzzzzzzu_);
                    bool? lzzzzzzzzzzzw_ = context.Operators.Equal(lzzzzzzzzzzzv_, 0);

                    return lzzzzzzzzzzzw_ ?? false;
                };
                if (lzzzzzzzzzzzt_())
                {
                    CqlInterval<CqlDate>[] lzzzzzzzzzzzx_ = [
                        baseInterval,
                    ];

                    return lzzzzzzzzzzzx_ as IEnumerable<CqlInterval<CqlDate>>;
                }
                else
                {
                    IEnumerable<CqlInterval<CqlDate>> lzzzzzzzzzzzy_ = variableDeclarations?.sortedCoverings;
                    CqlInterval<CqlDate> lzzzzzzzzzzzz_(CqlInterval<CqlDate> sortedCovering)
                    {
                        CqlInterval<CqlDate> mzzzzzzzzzzzc_()
                        {
                            bool mzzzzzzzzzzzd_()
                            {
                                IEnumerable<CqlInterval<CqlDate>> mzzzzzzzzzzze_ = variableDeclarations?.sortedCoverings;
                                int? mzzzzzzzzzzzf_ = context.Operators.IndexOf<CqlInterval<CqlDate>>(mzzzzzzzzzzze_, sortedCovering);
                                bool? mzzzzzzzzzzzg_ = context.Operators.Equal(mzzzzzzzzzzzf_, 0);

                                return mzzzzzzzzzzzg_ ?? false;
                            };
                            if (mzzzzzzzzzzzd_())
                            {
                                CqlDate mzzzzzzzzzzzh_ = context.Operators.Start(baseInterval);
                                CqlDate mzzzzzzzzzzzi_ = context.Operators.Start(sortedCovering);
                                CqlInterval<CqlDate> mzzzzzzzzzzzj_ = context.Operators.Interval(mzzzzzzzzzzzh_, mzzzzzzzzzzzi_, true, true);
                                CqlInterval<CqlDate> mzzzzzzzzzzzk_ = context.Operators.Intersect<CqlDate>(mzzzzzzzzzzzj_, baseInterval);
                                CqlInterval<CqlDate> mzzzzzzzzzzzl_ = context.Operators.Except(mzzzzzzzzzzzk_, sortedCovering);

                                return mzzzzzzzzzzzl_;
                            }
                            else
                            {
                                IEnumerable<CqlInterval<CqlDate>> mzzzzzzzzzzzm_ = variableDeclarations?.sortedCoverings;
                                int? mzzzzzzzzzzzo_ = context.Operators.IndexOf<CqlInterval<CqlDate>>(mzzzzzzzzzzzm_, sortedCovering);
                                int? mzzzzzzzzzzzp_ = context.Operators.Subtract(mzzzzzzzzzzzo_, 1);
                                CqlInterval<CqlDate> mzzzzzzzzzzzq_ = context.Operators.Indexer<CqlInterval<CqlDate>>(mzzzzzzzzzzzm_, mzzzzzzzzzzzp_);
                                CqlDate mzzzzzzzzzzzr_ = context.Operators.Start(mzzzzzzzzzzzq_);
                                CqlDate mzzzzzzzzzzzs_ = context.Operators.End(sortedCovering);
                                CqlInterval<CqlDate> mzzzzzzzzzzzt_ = context.Operators.Interval(mzzzzzzzzzzzr_, mzzzzzzzzzzzs_, false, false);
                                int? mzzzzzzzzzzzw_ = context.Operators.IndexOf<CqlInterval<CqlDate>>(mzzzzzzzzzzzm_, sortedCovering);
                                int? mzzzzzzzzzzzx_ = context.Operators.Subtract(mzzzzzzzzzzzw_, 1);
                                CqlInterval<CqlDate> mzzzzzzzzzzzy_ = context.Operators.Indexer<CqlInterval<CqlDate>>(mzzzzzzzzzzzm_, mzzzzzzzzzzzx_);
                                CqlInterval<CqlDate> mzzzzzzzzzzzz_ = context.Operators.Except(mzzzzzzzzzzzt_, mzzzzzzzzzzzy_);
                                CqlInterval<CqlDate> nzzzzzzzzzzza_ = context.Operators.Except(mzzzzzzzzzzzz_, sortedCovering);

                                return nzzzzzzzzzzza_;
                            }
                        };

                        return mzzzzzzzzzzzc_();
                    };
                    IEnumerable<CqlInterval<CqlDate>> mzzzzzzzzzzza_ = context.Operators.Select<CqlInterval<CqlDate>, CqlInterval<CqlDate>>(lzzzzzzzzzzzy_, lzzzzzzzzzzzz_);
                    IEnumerable<CqlInterval<CqlDate>> mzzzzzzzzzzzb_ = context.Operators.Distinct<CqlInterval<CqlDate>>(mzzzzzzzzzzza_);

                    return mzzzzzzzzzzzb_;
                }
            };
            IEnumerable<CqlInterval<CqlDate>> lzzzzzzzzzzzm_()
            {
                bool nzzzzzzzzzzzb_()
                {
                    IEnumerable<CqlInterval<CqlDate>> nzzzzzzzzzzzc_ = variableDeclarations?.sortedCoverings;
                    int? nzzzzzzzzzzzd_ = context.Operators.Count<CqlInterval<CqlDate>>(nzzzzzzzzzzzc_);
                    bool? nzzzzzzzzzzze_ = context.Operators.Equal(nzzzzzzzzzzzd_, 0);

                    return nzzzzzzzzzzze_ ?? false;
                };
                if (nzzzzzzzzzzzb_())
                {
                    CqlInterval<CqlDate>[] nzzzzzzzzzzzf_ = []
;

                    return nzzzzzzzzzzzf_ as IEnumerable<CqlInterval<CqlDate>>;
                }
                else
                {
                    IEnumerable<CqlInterval<CqlDate>> nzzzzzzzzzzzg_ = variableDeclarations?.sortedCoverings;
                    CqlInterval<CqlDate> nzzzzzzzzzzzh_ = context.Operators.Last<CqlInterval<CqlDate>>(nzzzzzzzzzzzg_);
                    CqlDate nzzzzzzzzzzzi_ = context.Operators.Start(nzzzzzzzzzzzh_);
                    CqlDate nzzzzzzzzzzzj_ = context.Operators.End(baseInterval);
                    CqlInterval<CqlDate> nzzzzzzzzzzzk_ = context.Operators.Interval(nzzzzzzzzzzzi_, nzzzzzzzzzzzj_, false, true);
                    CqlInterval<CqlDate> nzzzzzzzzzzzm_ = context.Operators.Last<CqlInterval<CqlDate>>(nzzzzzzzzzzzg_);
                    CqlInterval<CqlDate> nzzzzzzzzzzzn_ = context.Operators.Except(nzzzzzzzzzzzk_, nzzzzzzzzzzzm_);
                    CqlInterval<CqlDate> nzzzzzzzzzzzo_ = context.Operators.Intersect<CqlDate>(nzzzzzzzzzzzn_, baseInterval);
                    CqlInterval<CqlDate>[] nzzzzzzzzzzzp_ = [
                        nzzzzzzzzzzzo_,
                    ];

                    return nzzzzzzzzzzzp_ as IEnumerable<CqlInterval<CqlDate>>;
                }
            };
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> frontgaps, IEnumerable<CqlInterval<CqlDate>> endgap)? lzzzzzzzzzzzn_ = (CqlTupleMetadata_FKcLSALRMRfDigEFaJgDOPFRK, lzzzzzzzzzzzl_(), lzzzzzzzzzzzm_());
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> frontgaps, IEnumerable<CqlInterval<CqlDate>> endgap)?[] lzzzzzzzzzzzo_ = [
                lzzzzzzzzzzzn_,
            ];
            IEnumerable<CqlInterval<CqlDate>> lzzzzzzzzzzzp_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> frontgaps, IEnumerable<CqlInterval<CqlDate>> endgap)? calculations)
            {
                IEnumerable<CqlInterval<CqlDate>> nzzzzzzzzzzzq_ = calculations?.frontgaps;
                IEnumerable<CqlInterval<CqlDate>> nzzzzzzzzzzzr_ = calculations?.endgap;
                IEnumerable<CqlInterval<CqlDate>> nzzzzzzzzzzzs_ = context.Operators.Union<CqlInterval<CqlDate>>(nzzzzzzzzzzzq_, nzzzzzzzzzzzr_);
                IEnumerable<CqlInterval<CqlDate>> nzzzzzzzzzzzt_ = this.Collapse_Date_Interval_Workaround(context, nzzzzzzzzzzzs_);

                return nzzzzzzzzzzzt_;
            };
            IEnumerable<IEnumerable<CqlInterval<CqlDate>>> lzzzzzzzzzzzq_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> frontgaps, IEnumerable<CqlInterval<CqlDate>> endgap)?, IEnumerable<CqlInterval<CqlDate>>>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> frontgaps, IEnumerable<CqlInterval<CqlDate>> endgap)?>)lzzzzzzzzzzzo_, lzzzzzzzzzzzp_);
            IEnumerable<IEnumerable<CqlInterval<CqlDate>>> lzzzzzzzzzzzr_ = context.Operators.Distinct<IEnumerable<CqlInterval<CqlDate>>>(lzzzzzzzzzzzq_);
            IEnumerable<CqlInterval<CqlDate>> lzzzzzzzzzzzs_ = context.Operators.SingletonFrom<IEnumerable<CqlInterval<CqlDate>>>(lzzzzzzzzzzzr_);

            return lzzzzzzzzzzzs_;
        };
        IEnumerable<IEnumerable<CqlInterval<CqlDate>>> lzzzzzzzzzzzi_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> sortedCoverings)?, IEnumerable<CqlInterval<CqlDate>>>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> sortedCoverings)?>)lzzzzzzzzzzzg_, lzzzzzzzzzzzh_);
        IEnumerable<IEnumerable<CqlInterval<CqlDate>>> lzzzzzzzzzzzj_ = context.Operators.Distinct<IEnumerable<CqlInterval<CqlDate>>>(lzzzzzzzzzzzi_);
        IEnumerable<CqlInterval<CqlDate>> lzzzzzzzzzzzk_ = context.Operators.SingletonFrom<IEnumerable<CqlInterval<CqlDate>>>(lzzzzzzzzzzzj_);

        return lzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("DateTime Interval Gaps Relative to Base Interval")]
    public IEnumerable<CqlInterval<CqlDateTime>> DateTime_Interval_Gaps_Relative_to_Base_Interval(CqlContext context, CqlInterval<CqlDateTime> baseInterval, IEnumerable<CqlInterval<CqlDateTime>> coveringIntervals)
    {
        IEnumerable<CqlInterval<CqlDateTime>> nzzzzzzzzzzzu_ = this.DateTime_Interval_Covering_Relative_to_Base_Interval(context, baseInterval, coveringIntervals);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> sortedCoverings)? nzzzzzzzzzzzv_ = (CqlTupleMetadata_EdgSWaTaCbLYLJceGdIcWOLHd, nzzzzzzzzzzzu_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> sortedCoverings)?[] nzzzzzzzzzzzw_ = [
            nzzzzzzzzzzzv_,
        ];
        IEnumerable<CqlInterval<CqlDateTime>> nzzzzzzzzzzzx_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> sortedCoverings)? variableDeclarations)
        {
            IEnumerable<CqlInterval<CqlDateTime>> ozzzzzzzzzzzb_()
            {
                bool ozzzzzzzzzzzj_()
                {
                    IEnumerable<CqlInterval<CqlDateTime>> ozzzzzzzzzzzk_ = variableDeclarations?.sortedCoverings;
                    int? ozzzzzzzzzzzl_ = context.Operators.Count<CqlInterval<CqlDateTime>>(ozzzzzzzzzzzk_);
                    bool? ozzzzzzzzzzzm_ = context.Operators.Equal(ozzzzzzzzzzzl_, 0);

                    return ozzzzzzzzzzzm_ ?? false;
                };
                if (ozzzzzzzzzzzj_())
                {
                    CqlInterval<CqlDateTime>[] ozzzzzzzzzzzn_ = [
                        baseInterval,
                    ];

                    return ozzzzzzzzzzzn_ as IEnumerable<CqlInterval<CqlDateTime>>;
                }
                else
                {
                    IEnumerable<CqlInterval<CqlDateTime>> ozzzzzzzzzzzo_ = variableDeclarations?.sortedCoverings;
                    CqlInterval<CqlDateTime> ozzzzzzzzzzzp_(CqlInterval<CqlDateTime> sortedCovering)
                    {
                        CqlInterval<CqlDateTime> ozzzzzzzzzzzs_()
                        {
                            bool ozzzzzzzzzzzt_()
                            {
                                IEnumerable<CqlInterval<CqlDateTime>> ozzzzzzzzzzzu_ = variableDeclarations?.sortedCoverings;
                                int? ozzzzzzzzzzzv_ = context.Operators.IndexOf<CqlInterval<CqlDateTime>>(ozzzzzzzzzzzu_, sortedCovering);
                                bool? ozzzzzzzzzzzw_ = context.Operators.Equal(ozzzzzzzzzzzv_, 0);

                                return ozzzzzzzzzzzw_ ?? false;
                            };
                            if (ozzzzzzzzzzzt_())
                            {
                                CqlDateTime ozzzzzzzzzzzx_ = context.Operators.Start(baseInterval);
                                CqlDateTime ozzzzzzzzzzzy_ = context.Operators.Start(sortedCovering);
                                CqlInterval<CqlDateTime> ozzzzzzzzzzzz_ = context.Operators.Interval(ozzzzzzzzzzzx_, ozzzzzzzzzzzy_, true, true);
                                CqlInterval<CqlDateTime> pzzzzzzzzzzza_ = context.Operators.Intersect<CqlDateTime>(ozzzzzzzzzzzz_, baseInterval);
                                CqlInterval<CqlDateTime> pzzzzzzzzzzzb_ = context.Operators.Except(pzzzzzzzzzzza_, sortedCovering);

                                return pzzzzzzzzzzzb_;
                            }
                            else
                            {
                                IEnumerable<CqlInterval<CqlDateTime>> pzzzzzzzzzzzc_ = variableDeclarations?.sortedCoverings;
                                int? pzzzzzzzzzzze_ = context.Operators.IndexOf<CqlInterval<CqlDateTime>>(pzzzzzzzzzzzc_, sortedCovering);
                                int? pzzzzzzzzzzzf_ = context.Operators.Subtract(pzzzzzzzzzzze_, 1);
                                CqlInterval<CqlDateTime> pzzzzzzzzzzzg_ = context.Operators.Indexer<CqlInterval<CqlDateTime>>(pzzzzzzzzzzzc_, pzzzzzzzzzzzf_);
                                CqlDateTime pzzzzzzzzzzzh_ = context.Operators.Start(pzzzzzzzzzzzg_);
                                CqlDateTime pzzzzzzzzzzzi_ = context.Operators.End(sortedCovering);
                                CqlInterval<CqlDateTime> pzzzzzzzzzzzj_ = context.Operators.Interval(pzzzzzzzzzzzh_, pzzzzzzzzzzzi_, false, false);
                                int? pzzzzzzzzzzzm_ = context.Operators.IndexOf<CqlInterval<CqlDateTime>>(pzzzzzzzzzzzc_, sortedCovering);
                                int? pzzzzzzzzzzzn_ = context.Operators.Subtract(pzzzzzzzzzzzm_, 1);
                                CqlInterval<CqlDateTime> pzzzzzzzzzzzo_ = context.Operators.Indexer<CqlInterval<CqlDateTime>>(pzzzzzzzzzzzc_, pzzzzzzzzzzzn_);
                                CqlInterval<CqlDateTime> pzzzzzzzzzzzp_ = context.Operators.Except(pzzzzzzzzzzzj_, pzzzzzzzzzzzo_);
                                CqlInterval<CqlDateTime> pzzzzzzzzzzzq_ = context.Operators.Except(pzzzzzzzzzzzp_, sortedCovering);

                                return pzzzzzzzzzzzq_;
                            }
                        };

                        return ozzzzzzzzzzzs_();
                    };
                    IEnumerable<CqlInterval<CqlDateTime>> ozzzzzzzzzzzq_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(ozzzzzzzzzzzo_, ozzzzzzzzzzzp_);
                    IEnumerable<CqlInterval<CqlDateTime>> ozzzzzzzzzzzr_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(ozzzzzzzzzzzq_);

                    return ozzzzzzzzzzzr_;
                }
            };
            IEnumerable<CqlInterval<CqlDateTime>> ozzzzzzzzzzzc_()
            {
                bool pzzzzzzzzzzzr_()
                {
                    IEnumerable<CqlInterval<CqlDateTime>> pzzzzzzzzzzzs_ = variableDeclarations?.sortedCoverings;
                    int? pzzzzzzzzzzzt_ = context.Operators.Count<CqlInterval<CqlDateTime>>(pzzzzzzzzzzzs_);
                    bool? pzzzzzzzzzzzu_ = context.Operators.Equal(pzzzzzzzzzzzt_, 0);

                    return pzzzzzzzzzzzu_ ?? false;
                };
                if (pzzzzzzzzzzzr_())
                {
                    CqlInterval<CqlDateTime>[] pzzzzzzzzzzzv_ = []
;

                    return pzzzzzzzzzzzv_ as IEnumerable<CqlInterval<CqlDateTime>>;
                }
                else
                {
                    IEnumerable<CqlInterval<CqlDateTime>> pzzzzzzzzzzzw_ = variableDeclarations?.sortedCoverings;
                    CqlInterval<CqlDateTime> pzzzzzzzzzzzx_ = context.Operators.Last<CqlInterval<CqlDateTime>>(pzzzzzzzzzzzw_);
                    CqlDateTime pzzzzzzzzzzzy_ = context.Operators.Start(pzzzzzzzzzzzx_);
                    CqlDateTime pzzzzzzzzzzzz_ = context.Operators.End(baseInterval);
                    CqlInterval<CqlDateTime> qzzzzzzzzzzza_ = context.Operators.Interval(pzzzzzzzzzzzy_, pzzzzzzzzzzzz_, false, true);
                    CqlInterval<CqlDateTime> qzzzzzzzzzzzc_ = context.Operators.Last<CqlInterval<CqlDateTime>>(pzzzzzzzzzzzw_);
                    CqlInterval<CqlDateTime> qzzzzzzzzzzzd_ = context.Operators.Except(qzzzzzzzzzzza_, qzzzzzzzzzzzc_);
                    CqlInterval<CqlDateTime> qzzzzzzzzzzze_ = context.Operators.Intersect<CqlDateTime>(qzzzzzzzzzzzd_, baseInterval);
                    CqlInterval<CqlDateTime>[] qzzzzzzzzzzzf_ = [
                        qzzzzzzzzzzze_,
                    ];

                    return qzzzzzzzzzzzf_ as IEnumerable<CqlInterval<CqlDateTime>>;
                }
            };
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> frontgaps, IEnumerable<CqlInterval<CqlDateTime>> endgap)? ozzzzzzzzzzzd_ = (CqlTupleMetadata_BBLSSiNBQBGUDJaVjMDZMSAXg, ozzzzzzzzzzzb_(), ozzzzzzzzzzzc_());
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> frontgaps, IEnumerable<CqlInterval<CqlDateTime>> endgap)?[] ozzzzzzzzzzze_ = [
                ozzzzzzzzzzzd_,
            ];
            IEnumerable<CqlInterval<CqlDateTime>> ozzzzzzzzzzzf_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> frontgaps, IEnumerable<CqlInterval<CqlDateTime>> endgap)? calculations)
            {
                IEnumerable<CqlInterval<CqlDateTime>> qzzzzzzzzzzzg_ = calculations?.frontgaps;
                IEnumerable<CqlInterval<CqlDateTime>> qzzzzzzzzzzzh_ = calculations?.endgap;
                IEnumerable<CqlInterval<CqlDateTime>> qzzzzzzzzzzzi_ = context.Operators.Union<CqlInterval<CqlDateTime>>(qzzzzzzzzzzzg_, qzzzzzzzzzzzh_);
                IEnumerable<CqlInterval<CqlDateTime>> qzzzzzzzzzzzj_ = this.Collapse_DateTime_Interval_Workaround(context, qzzzzzzzzzzzi_);

                return qzzzzzzzzzzzj_;
            };
            IEnumerable<IEnumerable<CqlInterval<CqlDateTime>>> ozzzzzzzzzzzg_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> frontgaps, IEnumerable<CqlInterval<CqlDateTime>> endgap)?, IEnumerable<CqlInterval<CqlDateTime>>>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> frontgaps, IEnumerable<CqlInterval<CqlDateTime>> endgap)?>)ozzzzzzzzzzze_, ozzzzzzzzzzzf_);
            IEnumerable<IEnumerable<CqlInterval<CqlDateTime>>> ozzzzzzzzzzzh_ = context.Operators.Distinct<IEnumerable<CqlInterval<CqlDateTime>>>(ozzzzzzzzzzzg_);
            IEnumerable<CqlInterval<CqlDateTime>> ozzzzzzzzzzzi_ = context.Operators.SingletonFrom<IEnumerable<CqlInterval<CqlDateTime>>>(ozzzzzzzzzzzh_);

            return ozzzzzzzzzzzi_;
        };
        IEnumerable<IEnumerable<CqlInterval<CqlDateTime>>> nzzzzzzzzzzzy_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> sortedCoverings)?, IEnumerable<CqlInterval<CqlDateTime>>>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> sortedCoverings)?>)nzzzzzzzzzzzw_, nzzzzzzzzzzzx_);
        IEnumerable<IEnumerable<CqlInterval<CqlDateTime>>> nzzzzzzzzzzzz_ = context.Operators.Distinct<IEnumerable<CqlInterval<CqlDateTime>>>(nzzzzzzzzzzzy_);
        IEnumerable<CqlInterval<CqlDateTime>> ozzzzzzzzzzza_ = context.Operators.SingletonFrom<IEnumerable<CqlInterval<CqlDateTime>>>(nzzzzzzzzzzzz_);

        return ozzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Collapsed Date Interval Stats")]
    public (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? Collapsed_Date_Interval_Stats(CqlContext context, IEnumerable<CqlInterval<CqlDate>> collapsedIntervals)
    {
        int? qzzzzzzzzzzzk_ = context.Operators.Count<CqlInterval<CqlDate>>(collapsedIntervals);
        int? qzzzzzzzzzzzl_()
        {
            bool qzzzzzzzzzzzp_()
            {
                int? qzzzzzzzzzzzq_ = context.Operators.Count<CqlInterval<CqlDate>>(collapsedIntervals);
                bool? qzzzzzzzzzzzr_ = context.Operators.Equal(qzzzzzzzzzzzq_, 0);

                return qzzzzzzzzzzzr_ ?? false;
            };
            if (qzzzzzzzzzzzp_())
            {
                return 0;
            }
            else
            {
                int? qzzzzzzzzzzzs_(CqlInterval<CqlDate> I)
                {
                    CqlDate qzzzzzzzzzzzw_ = context.Operators.Start(I);
                    CqlDate qzzzzzzzzzzzx_ = context.Operators.End(I);
                    int? qzzzzzzzzzzzy_ = context.Operators.DurationBetween(qzzzzzzzzzzzw_, qzzzzzzzzzzzx_, "day");
                    int? qzzzzzzzzzzzz_ = context.Operators.Add(qzzzzzzzzzzzy_, 1);
                    int?[] rzzzzzzzzzzza_ = [
                        qzzzzzzzzzzzz_,
                        0,
                    ];
                    int? rzzzzzzzzzzzb_ = context.Operators.Max<int?>(rzzzzzzzzzzza_ as IEnumerable<int?>);

                    return rzzzzzzzzzzzb_;
                };
                IEnumerable<int?> qzzzzzzzzzzzt_ = context.Operators.Select<CqlInterval<CqlDate>, int?>(collapsedIntervals, qzzzzzzzzzzzs_);
                IEnumerable<int?> qzzzzzzzzzzzu_ = context.Operators.Distinct<int?>(qzzzzzzzzzzzt_);
                int? qzzzzzzzzzzzv_ = context.Operators.Sum(qzzzzzzzzzzzu_);

                return qzzzzzzzzzzzv_;
            }
        };
        CqlInterval<CqlDate> qzzzzzzzzzzzm_()
        {
            bool rzzzzzzzzzzzc_()
            {
                int? rzzzzzzzzzzzd_ = context.Operators.Count<CqlInterval<CqlDate>>(collapsedIntervals);
                bool? rzzzzzzzzzzze_ = context.Operators.Equal(rzzzzzzzzzzzd_, 0);

                return rzzzzzzzzzzze_ ?? false;
            };
            if (rzzzzzzzzzzzc_())
            {
                return null as CqlInterval<CqlDate>;
            }
            else
            {
                (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? rzzzzzzzzzzzf_(CqlInterval<CqlDate> I)
                {
                    CqlDate rzzzzzzzzzzzm_ = context.Operators.Start(I);
                    CqlDate rzzzzzzzzzzzn_ = context.Operators.End(I);
                    int? rzzzzzzzzzzzo_ = context.Operators.DurationBetween(rzzzzzzzzzzzm_, rzzzzzzzzzzzn_, "day");
                    int? rzzzzzzzzzzzp_ = context.Operators.Add(rzzzzzzzzzzzo_, 1);
                    int?[] rzzzzzzzzzzzq_ = [
                        rzzzzzzzzzzzp_,
                        0,
                    ];
                    int? rzzzzzzzzzzzr_ = context.Operators.Max<int?>(rzzzzzzzzzzzq_ as IEnumerable<int?>);
                    (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? rzzzzzzzzzzzs_ = (CqlTupleMetadata_HEjPGjPEhLgQPGjROeWMgiGfC, I, rzzzzzzzzzzzr_);

                    return rzzzzzzzzzzzs_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> rzzzzzzzzzzzg_ = context.Operators.Select<CqlInterval<CqlDate>, (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(collapsedIntervals, rzzzzzzzzzzzf_);
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> rzzzzzzzzzzzh_ = context.Operators.Distinct<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(rzzzzzzzzzzzg_);
                object rzzzzzzzzzzzi_((CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? @this)
                {
                    int? rzzzzzzzzzzzt_ = @this?.days;

                    return rzzzzzzzzzzzt_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> rzzzzzzzzzzzj_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(rzzzzzzzzzzzh_, rzzzzzzzzzzzi_, System.ComponentModel.ListSortDirection.Descending);
                (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? rzzzzzzzzzzzk_ = context.Operators.First<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(rzzzzzzzzzzzj_);
                CqlInterval<CqlDate> rzzzzzzzzzzzl_ = rzzzzzzzzzzzk_?.interval;

                return rzzzzzzzzzzzl_;
            }
        };
        int? qzzzzzzzzzzzn_()
        {
            bool rzzzzzzzzzzzu_()
            {
                int? rzzzzzzzzzzzv_ = context.Operators.Count<CqlInterval<CqlDate>>(collapsedIntervals);
                bool? rzzzzzzzzzzzw_ = context.Operators.Equal(rzzzzzzzzzzzv_, 0);

                return rzzzzzzzzzzzw_ ?? false;
            };
            if (rzzzzzzzzzzzu_())
            {
                return 0;
            }
            else
            {
                (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? rzzzzzzzzzzzx_(CqlInterval<CqlDate> I)
                {
                    CqlDate szzzzzzzzzzzr_ = context.Operators.Start(I);
                    CqlDate szzzzzzzzzzzs_ = context.Operators.End(I);
                    int? szzzzzzzzzzzt_ = context.Operators.DurationBetween(szzzzzzzzzzzr_, szzzzzzzzzzzs_, "day");
                    int? szzzzzzzzzzzu_ = context.Operators.Add(szzzzzzzzzzzt_, 1);
                    int?[] szzzzzzzzzzzv_ = [
                        szzzzzzzzzzzu_,
                        0,
                    ];
                    int? szzzzzzzzzzzw_ = context.Operators.Max<int?>(szzzzzzzzzzzv_ as IEnumerable<int?>);
                    (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? szzzzzzzzzzzx_ = (CqlTupleMetadata_HEjPGjPEhLgQPGjROeWMgiGfC, I, szzzzzzzzzzzw_);

                    return szzzzzzzzzzzx_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> rzzzzzzzzzzzy_ = context.Operators.Select<CqlInterval<CqlDate>, (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(collapsedIntervals, rzzzzzzzzzzzx_);
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> rzzzzzzzzzzzz_ = context.Operators.Distinct<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(rzzzzzzzzzzzy_);
                object szzzzzzzzzzza_((CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? @this)
                {
                    int? szzzzzzzzzzzy_ = @this?.days;

                    return szzzzzzzzzzzy_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> szzzzzzzzzzzb_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(rzzzzzzzzzzzz_, szzzzzzzzzzza_, System.ComponentModel.ListSortDirection.Descending);
                (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? szzzzzzzzzzzc_ = context.Operators.First<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(szzzzzzzzzzzb_);
                CqlInterval<CqlDate> szzzzzzzzzzzd_ = szzzzzzzzzzzc_?.interval;
                CqlDate szzzzzzzzzzze_ = context.Operators.Start(szzzzzzzzzzzd_);
                (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? szzzzzzzzzzzf_(CqlInterval<CqlDate> I)
                {
                    CqlDate szzzzzzzzzzzz_ = context.Operators.Start(I);
                    CqlDate tzzzzzzzzzzza_ = context.Operators.End(I);
                    int? tzzzzzzzzzzzb_ = context.Operators.DurationBetween(szzzzzzzzzzzz_, tzzzzzzzzzzza_, "day");
                    int? tzzzzzzzzzzzc_ = context.Operators.Add(tzzzzzzzzzzzb_, 1);
                    int?[] tzzzzzzzzzzzd_ = [
                        tzzzzzzzzzzzc_,
                        0,
                    ];
                    int? tzzzzzzzzzzze_ = context.Operators.Max<int?>(tzzzzzzzzzzzd_ as IEnumerable<int?>);
                    (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? tzzzzzzzzzzzf_ = (CqlTupleMetadata_HEjPGjPEhLgQPGjROeWMgiGfC, I, tzzzzzzzzzzze_);

                    return tzzzzzzzzzzzf_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> szzzzzzzzzzzg_ = context.Operators.Select<CqlInterval<CqlDate>, (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(collapsedIntervals, szzzzzzzzzzzf_);
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> szzzzzzzzzzzh_ = context.Operators.Distinct<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(szzzzzzzzzzzg_);
                object szzzzzzzzzzzi_((CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? @this)
                {
                    int? tzzzzzzzzzzzg_ = @this?.days;

                    return tzzzzzzzzzzzg_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> szzzzzzzzzzzj_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(szzzzzzzzzzzh_, szzzzzzzzzzzi_, System.ComponentModel.ListSortDirection.Descending);
                (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? szzzzzzzzzzzk_ = context.Operators.First<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(szzzzzzzzzzzj_);
                CqlInterval<CqlDate> szzzzzzzzzzzl_ = szzzzzzzzzzzk_?.interval;
                CqlDate szzzzzzzzzzzm_ = context.Operators.End(szzzzzzzzzzzl_);
                int? szzzzzzzzzzzn_ = context.Operators.DurationBetween(szzzzzzzzzzze_, szzzzzzzzzzzm_, "day");
                int? szzzzzzzzzzzo_ = context.Operators.Add(szzzzzzzzzzzn_, 1);
                int?[] szzzzzzzzzzzp_ = [
                    szzzzzzzzzzzo_,
                    0,
                ];
                int? szzzzzzzzzzzq_ = context.Operators.Max<int?>(szzzzzzzzzzzp_ as IEnumerable<int?>);

                return szzzzzzzzzzzq_;
            }
        };
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? qzzzzzzzzzzzo_ = (CqlTupleMetadata_HRbPDRZiOGGBceePOZWjVbXdP, collapsedIntervals, qzzzzzzzzzzzk_, qzzzzzzzzzzzl_(), qzzzzzzzzzzzm_(), qzzzzzzzzzzzn_());

        return qzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Date Interval Covering Relative to Base Interval Stats")]
    public (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? Date_Interval_Covering_Relative_to_Base_Interval_Stats(CqlContext context, CqlInterval<CqlDate> baseInterval, IEnumerable<CqlInterval<CqlDate>> coveringIntervals)
    {
        IEnumerable<CqlInterval<CqlDate>> tzzzzzzzzzzzh_ = this.Date_Interval_Covering_Relative_to_Base_Interval(context, baseInterval, coveringIntervals);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Covering_Intervals)? tzzzzzzzzzzzi_ = (CqlTupleMetadata_DUiZjXRKgCPYVZQJbFVDKNMOi, tzzzzzzzzzzzh_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Covering_Intervals)?[] tzzzzzzzzzzzj_ = [
            tzzzzzzzzzzzi_,
        ];
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? tzzzzzzzzzzzk_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Covering_Intervals)? variableDeclarations)
        {
            IEnumerable<CqlInterval<CqlDate>> tzzzzzzzzzzzo_ = variableDeclarations?.Covering_Intervals;
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? tzzzzzzzzzzzp_ = this.Collapsed_Date_Interval_Stats(context, tzzzzzzzzzzzo_);

            return tzzzzzzzzzzzp_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?> tzzzzzzzzzzzl_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Covering_Intervals)?, (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Covering_Intervals)?>)tzzzzzzzzzzzj_, tzzzzzzzzzzzk_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?> tzzzzzzzzzzzm_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>(tzzzzzzzzzzzl_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? tzzzzzzzzzzzn_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>(tzzzzzzzzzzzm_);

        return tzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Date Interval Gaps Relative to Base Interval Stats")]
    public (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? Date_Interval_Gaps_Relative_to_Base_Interval_Stats(CqlContext context, CqlInterval<CqlDate> baseInterval, IEnumerable<CqlInterval<CqlDate>> coveringIntervals)
    {
        IEnumerable<CqlInterval<CqlDate>> tzzzzzzzzzzzq_ = this.Date_Interval_Gaps_Relative_to_Base_Interval(context, baseInterval, coveringIntervals);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Gap_Intervals)? tzzzzzzzzzzzr_ = (CqlTupleMetadata_GQPbYTYABjXFVLRKjXgcDJFSj, tzzzzzzzzzzzq_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Gap_Intervals)?[] tzzzzzzzzzzzs_ = [
            tzzzzzzzzzzzr_,
        ];
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? tzzzzzzzzzzzt_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Gap_Intervals)? variableDeclarations)
        {
            IEnumerable<CqlInterval<CqlDate>> tzzzzzzzzzzzx_ = variableDeclarations?.Gap_Intervals;
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? tzzzzzzzzzzzy_ = this.Collapsed_Date_Interval_Stats(context, tzzzzzzzzzzzx_);

            return tzzzzzzzzzzzy_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?> tzzzzzzzzzzzu_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Gap_Intervals)?, (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Gap_Intervals)?>)tzzzzzzzzzzzs_, tzzzzzzzzzzzt_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?> tzzzzzzzzzzzv_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>(tzzzzzzzzzzzu_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? tzzzzzzzzzzzw_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>(tzzzzzzzzzzzv_);

        return tzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("DateTime Interval Set Nulls to Zero")]
    public CqlInterval<CqlDateTime> DateTime_Interval_Set_Nulls_to_Zero(CqlContext context, CqlInterval<CqlDateTime> interval)
    {
        CqlDateTime tzzzzzzzzzzzz_ = context.Operators.Start(interval);
        int? uzzzzzzzzzzza_ = context.Operators.DateTimeComponentFrom(tzzzzzzzzzzzz_, "year");
        int? uzzzzzzzzzzzb_()
        {
            bool uzzzzzzzzzzzv_()
            {
                CqlDateTime uzzzzzzzzzzzw_ = context.Operators.Start(interval);
                int? uzzzzzzzzzzzx_ = context.Operators.DateTimeComponentFrom(uzzzzzzzzzzzw_, "month");

                return uzzzzzzzzzzzx_ is null;
            };
            if (uzzzzzzzzzzzv_())
            {
                return 0;
            }
            else
            {
                CqlDateTime uzzzzzzzzzzzy_ = context.Operators.Start(interval);
                int? uzzzzzzzzzzzz_ = context.Operators.DateTimeComponentFrom(uzzzzzzzzzzzy_, "month");

                return uzzzzzzzzzzzz_;
            }
        };
        int? uzzzzzzzzzzzc_()
        {
            bool vzzzzzzzzzzza_()
            {
                CqlDateTime vzzzzzzzzzzzb_ = context.Operators.Start(interval);
                int? vzzzzzzzzzzzc_ = context.Operators.DateTimeComponentFrom(vzzzzzzzzzzzb_, "day");

                return vzzzzzzzzzzzc_ is null;
            };
            if (vzzzzzzzzzzza_())
            {
                return 0;
            }
            else
            {
                CqlDateTime vzzzzzzzzzzzd_ = context.Operators.Start(interval);
                int? vzzzzzzzzzzze_ = context.Operators.DateTimeComponentFrom(vzzzzzzzzzzzd_, "day");

                return vzzzzzzzzzzze_;
            }
        };
        int? uzzzzzzzzzzzd_()
        {
            bool vzzzzzzzzzzzf_()
            {
                CqlDateTime vzzzzzzzzzzzg_ = context.Operators.Start(interval);
                int? vzzzzzzzzzzzh_ = context.Operators.DateTimeComponentFrom(vzzzzzzzzzzzg_, "hour");

                return vzzzzzzzzzzzh_ is null;
            };
            if (vzzzzzzzzzzzf_())
            {
                return 0;
            }
            else
            {
                CqlDateTime vzzzzzzzzzzzi_ = context.Operators.Start(interval);
                int? vzzzzzzzzzzzj_ = context.Operators.DateTimeComponentFrom(vzzzzzzzzzzzi_, "hour");

                return vzzzzzzzzzzzj_;
            }
        };
        int? uzzzzzzzzzzze_()
        {
            bool vzzzzzzzzzzzk_()
            {
                CqlDateTime vzzzzzzzzzzzl_ = context.Operators.Start(interval);
                int? vzzzzzzzzzzzm_ = context.Operators.DateTimeComponentFrom(vzzzzzzzzzzzl_, "minute");

                return vzzzzzzzzzzzm_ is null;
            };
            if (vzzzzzzzzzzzk_())
            {
                return 0;
            }
            else
            {
                CqlDateTime vzzzzzzzzzzzn_ = context.Operators.Start(interval);
                int? vzzzzzzzzzzzo_ = context.Operators.DateTimeComponentFrom(vzzzzzzzzzzzn_, "minute");

                return vzzzzzzzzzzzo_;
            }
        };
        int? uzzzzzzzzzzzf_()
        {
            bool vzzzzzzzzzzzp_()
            {
                CqlDateTime vzzzzzzzzzzzq_ = context.Operators.Start(interval);
                int? vzzzzzzzzzzzr_ = context.Operators.DateTimeComponentFrom(vzzzzzzzzzzzq_, "second");

                return vzzzzzzzzzzzr_ is null;
            };
            if (vzzzzzzzzzzzp_())
            {
                return 0;
            }
            else
            {
                CqlDateTime vzzzzzzzzzzzs_ = context.Operators.Start(interval);
                int? vzzzzzzzzzzzt_ = context.Operators.DateTimeComponentFrom(vzzzzzzzzzzzs_, "second");

                return vzzzzzzzzzzzt_;
            }
        };
        int? uzzzzzzzzzzzg_()
        {
            bool vzzzzzzzzzzzu_()
            {
                CqlDateTime vzzzzzzzzzzzv_ = context.Operators.Start(interval);
                int? vzzzzzzzzzzzw_ = context.Operators.DateTimeComponentFrom(vzzzzzzzzzzzv_, "millisecond");

                return vzzzzzzzzzzzw_ is null;
            };
            if (vzzzzzzzzzzzu_())
            {
                return 0;
            }
            else
            {
                CqlDateTime vzzzzzzzzzzzx_ = context.Operators.Start(interval);
                int? vzzzzzzzzzzzy_ = context.Operators.DateTimeComponentFrom(vzzzzzzzzzzzx_, "millisecond");

                return vzzzzzzzzzzzy_;
            }
        };
        CqlDateTime uzzzzzzzzzzzh_ = context.Operators.End(interval);
        int? uzzzzzzzzzzzi_ = context.Operators.DateTimeComponentFrom(uzzzzzzzzzzzh_, "year");
        int? uzzzzzzzzzzzj_()
        {
            bool vzzzzzzzzzzzz_()
            {
                CqlDateTime wzzzzzzzzzzza_ = context.Operators.End(interval);
                int? wzzzzzzzzzzzb_ = context.Operators.DateTimeComponentFrom(wzzzzzzzzzzza_, "month");

                return wzzzzzzzzzzzb_ is null;
            };
            if (vzzzzzzzzzzzz_())
            {
                return 0;
            }
            else
            {
                CqlDateTime wzzzzzzzzzzzc_ = context.Operators.End(interval);
                int? wzzzzzzzzzzzd_ = context.Operators.DateTimeComponentFrom(wzzzzzzzzzzzc_, "month");

                return wzzzzzzzzzzzd_;
            }
        };
        int? uzzzzzzzzzzzk_()
        {
            bool wzzzzzzzzzzze_()
            {
                CqlDateTime wzzzzzzzzzzzf_ = context.Operators.End(interval);
                int? wzzzzzzzzzzzg_ = context.Operators.DateTimeComponentFrom(wzzzzzzzzzzzf_, "day");

                return wzzzzzzzzzzzg_ is null;
            };
            if (wzzzzzzzzzzze_())
            {
                return 0;
            }
            else
            {
                CqlDateTime wzzzzzzzzzzzh_ = context.Operators.End(interval);
                int? wzzzzzzzzzzzi_ = context.Operators.DateTimeComponentFrom(wzzzzzzzzzzzh_, "day");

                return wzzzzzzzzzzzi_;
            }
        };
        int? uzzzzzzzzzzzl_()
        {
            bool wzzzzzzzzzzzj_()
            {
                CqlDateTime wzzzzzzzzzzzk_ = context.Operators.End(interval);
                int? wzzzzzzzzzzzl_ = context.Operators.DateTimeComponentFrom(wzzzzzzzzzzzk_, "hour");

                return wzzzzzzzzzzzl_ is null;
            };
            if (wzzzzzzzzzzzj_())
            {
                return 0;
            }
            else
            {
                CqlDateTime wzzzzzzzzzzzm_ = context.Operators.End(interval);
                int? wzzzzzzzzzzzn_ = context.Operators.DateTimeComponentFrom(wzzzzzzzzzzzm_, "hour");

                return wzzzzzzzzzzzn_;
            }
        };
        int? uzzzzzzzzzzzm_()
        {
            bool wzzzzzzzzzzzo_()
            {
                CqlDateTime wzzzzzzzzzzzp_ = context.Operators.End(interval);
                int? wzzzzzzzzzzzq_ = context.Operators.DateTimeComponentFrom(wzzzzzzzzzzzp_, "minute");

                return wzzzzzzzzzzzq_ is null;
            };
            if (wzzzzzzzzzzzo_())
            {
                return 0;
            }
            else
            {
                CqlDateTime wzzzzzzzzzzzr_ = context.Operators.End(interval);
                int? wzzzzzzzzzzzs_ = context.Operators.DateTimeComponentFrom(wzzzzzzzzzzzr_, "minute");

                return wzzzzzzzzzzzs_;
            }
        };
        int? uzzzzzzzzzzzn_()
        {
            bool wzzzzzzzzzzzt_()
            {
                CqlDateTime wzzzzzzzzzzzu_ = context.Operators.End(interval);
                int? wzzzzzzzzzzzv_ = context.Operators.DateTimeComponentFrom(wzzzzzzzzzzzu_, "second");

                return wzzzzzzzzzzzv_ is null;
            };
            if (wzzzzzzzzzzzt_())
            {
                return 0;
            }
            else
            {
                CqlDateTime wzzzzzzzzzzzw_ = context.Operators.End(interval);
                int? wzzzzzzzzzzzx_ = context.Operators.DateTimeComponentFrom(wzzzzzzzzzzzw_, "second");

                return wzzzzzzzzzzzx_;
            }
        };
        int? uzzzzzzzzzzzo_()
        {
            bool wzzzzzzzzzzzy_()
            {
                CqlDateTime wzzzzzzzzzzzz_ = context.Operators.End(interval);
                int? xzzzzzzzzzzza_ = context.Operators.DateTimeComponentFrom(wzzzzzzzzzzzz_, "millisecond");

                return xzzzzzzzzzzza_ is null;
            };
            if (wzzzzzzzzzzzy_())
            {
                return 0;
            }
            else
            {
                CqlDateTime xzzzzzzzzzzzb_ = context.Operators.End(interval);
                int? xzzzzzzzzzzzc_ = context.Operators.DateTimeComponentFrom(xzzzzzzzzzzzb_, "millisecond");

                return xzzzzzzzzzzzc_;
            }
        };
        (CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)? uzzzzzzzzzzzp_ = (CqlTupleMetadata_FcQREFSfPJSKYAhSEWVJcZVED, uzzzzzzzzzzza_, uzzzzzzzzzzzb_(), uzzzzzzzzzzzc_(), uzzzzzzzzzzzd_(), uzzzzzzzzzzze_(), uzzzzzzzzzzzf_(), uzzzzzzzzzzzg_(), uzzzzzzzzzzzi_, uzzzzzzzzzzzj_(), uzzzzzzzzzzzk_(), uzzzzzzzzzzzl_(), uzzzzzzzzzzzm_(), uzzzzzzzzzzzn_(), uzzzzzzzzzzzo_());
        (CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)?[] uzzzzzzzzzzzq_ = [
            uzzzzzzzzzzzp_,
        ];
        CqlInterval<CqlDateTime> uzzzzzzzzzzzr_((CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)? i)
        {
            int? xzzzzzzzzzzzd_ = i?.StartYear;
            int? xzzzzzzzzzzze_ = i?.StartMonth;
            int? xzzzzzzzzzzzf_ = i?.StartDay;
            int? xzzzzzzzzzzzg_ = i?.StartHour;
            int? xzzzzzzzzzzzh_ = i?.StartMinute;
            int? xzzzzzzzzzzzi_ = i?.StartSecond;
            int? xzzzzzzzzzzzj_ = i?.StartMillisecond;
            CqlDateTime xzzzzzzzzzzzk_ = context.Operators.DateTime(xzzzzzzzzzzzd_, xzzzzzzzzzzze_, xzzzzzzzzzzzf_, xzzzzzzzzzzzg_, xzzzzzzzzzzzh_, xzzzzzzzzzzzi_, xzzzzzzzzzzzj_, default);
            int? xzzzzzzzzzzzl_ = i?.EndYear;
            int? xzzzzzzzzzzzm_ = i?.EndMonth;
            int? xzzzzzzzzzzzn_ = i?.EndDay;
            int? xzzzzzzzzzzzo_ = i?.EndHour;
            int? xzzzzzzzzzzzp_ = i?.EndMinute;
            int? xzzzzzzzzzzzq_ = i?.EndSecond;
            int? xzzzzzzzzzzzr_ = i?.EndMillisecond;
            CqlDateTime xzzzzzzzzzzzs_ = context.Operators.DateTime(xzzzzzzzzzzzl_, xzzzzzzzzzzzm_, xzzzzzzzzzzzn_, xzzzzzzzzzzzo_, xzzzzzzzzzzzp_, xzzzzzzzzzzzq_, xzzzzzzzzzzzr_, default);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzt_ = context.Operators.Interval(xzzzzzzzzzzzk_, xzzzzzzzzzzzs_, true, true);

            return xzzzzzzzzzzzt_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> uzzzzzzzzzzzs_ = context.Operators.Select<(CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)?, CqlInterval<CqlDateTime>>((IEnumerable<(CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)?>)uzzzzzzzzzzzq_, uzzzzzzzzzzzr_);
        IEnumerable<CqlInterval<CqlDateTime>> uzzzzzzzzzzzt_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(uzzzzzzzzzzzs_);
        CqlInterval<CqlDateTime> uzzzzzzzzzzzu_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(uzzzzzzzzzzzt_);

        return uzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Collapsed DateTime Interval Stats")]
    public (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? Collapsed_DateTime_Interval_Stats(CqlContext context, IEnumerable<CqlInterval<CqlDateTime>> collapsedIntervals)
    {
        int? xzzzzzzzzzzzu_ = context.Operators.Count<CqlInterval<CqlDateTime>>(collapsedIntervals);
        int? xzzzzzzzzzzzv_()
        {
            bool xzzzzzzzzzzzz_()
            {
                int? yzzzzzzzzzzza_ = context.Operators.Count<CqlInterval<CqlDateTime>>(collapsedIntervals);
                bool? yzzzzzzzzzzzb_ = context.Operators.Equal(yzzzzzzzzzzza_, 0);

                return yzzzzzzzzzzzb_ ?? false;
            };
            if (xzzzzzzzzzzzz_())
            {
                return 0;
            }
            else
            {
                int? yzzzzzzzzzzzc_(CqlInterval<CqlDateTime> I)
                {
                    CqlInterval<CqlDateTime> yzzzzzzzzzzzg_ = this.DateTime_Interval_Set_Nulls_to_Zero(context, I);
                    CqlDateTime yzzzzzzzzzzzh_ = context.Operators.Start(yzzzzzzzzzzzg_);
                    CqlDateTime yzzzzzzzzzzzj_ = context.Operators.End(yzzzzzzzzzzzg_);
                    int? yzzzzzzzzzzzk_ = context.Operators.DurationBetween(yzzzzzzzzzzzh_, yzzzzzzzzzzzj_, "day");
                    int? yzzzzzzzzzzzl_ = context.Operators.Add(yzzzzzzzzzzzk_, 1);
                    int?[] yzzzzzzzzzzzm_ = [
                        yzzzzzzzzzzzl_,
                        0,
                    ];
                    int? yzzzzzzzzzzzn_ = context.Operators.Max<int?>(yzzzzzzzzzzzm_ as IEnumerable<int?>);

                    return yzzzzzzzzzzzn_;
                };
                IEnumerable<int?> yzzzzzzzzzzzd_ = context.Operators.Select<CqlInterval<CqlDateTime>, int?>(collapsedIntervals, yzzzzzzzzzzzc_);
                IEnumerable<int?> yzzzzzzzzzzze_ = context.Operators.Distinct<int?>(yzzzzzzzzzzzd_);
                int? yzzzzzzzzzzzf_ = context.Operators.Sum(yzzzzzzzzzzze_);

                return yzzzzzzzzzzzf_;
            }
        };
        CqlInterval<CqlDateTime> xzzzzzzzzzzzw_()
        {
            bool yzzzzzzzzzzzo_()
            {
                int? yzzzzzzzzzzzp_ = context.Operators.Count<CqlInterval<CqlDateTime>>(collapsedIntervals);
                bool? yzzzzzzzzzzzq_ = context.Operators.Equal(yzzzzzzzzzzzp_, 0);

                return yzzzzzzzzzzzq_ ?? false;
            };
            if (yzzzzzzzzzzzo_())
            {
                return null as CqlInterval<CqlDateTime>;
            }
            else
            {
                (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? yzzzzzzzzzzzr_(CqlInterval<CqlDateTime> I)
                {
                    CqlInterval<CqlDateTime> yzzzzzzzzzzzy_ = this.DateTime_Interval_Set_Nulls_to_Zero(context, I);
                    CqlDateTime yzzzzzzzzzzzz_ = context.Operators.Start(yzzzzzzzzzzzy_);
                    CqlDateTime zzzzzzzzzzzzb_ = context.Operators.End(yzzzzzzzzzzzy_);
                    int? zzzzzzzzzzzzc_ = context.Operators.DurationBetween(yzzzzzzzzzzzz_, zzzzzzzzzzzzb_, "day");
                    int? zzzzzzzzzzzzd_ = context.Operators.Add(zzzzzzzzzzzzc_, 1);
                    int?[] zzzzzzzzzzzze_ = [
                        zzzzzzzzzzzzd_,
                        0,
                    ];
                    int? zzzzzzzzzzzzf_ = context.Operators.Max<int?>(zzzzzzzzzzzze_ as IEnumerable<int?>);
                    (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? zzzzzzzzzzzzg_ = (CqlTupleMetadata_CGHEUIgjaCjJVKEADTSZEbdCL, I, zzzzzzzzzzzzf_);

                    return zzzzzzzzzzzzg_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> yzzzzzzzzzzzs_ = context.Operators.Select<CqlInterval<CqlDateTime>, (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(collapsedIntervals, yzzzzzzzzzzzr_);
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> yzzzzzzzzzzzt_ = context.Operators.Distinct<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(yzzzzzzzzzzzs_);
                object yzzzzzzzzzzzu_((CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? @this)
                {
                    int? zzzzzzzzzzzzh_ = @this?.days;

                    return zzzzzzzzzzzzh_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> yzzzzzzzzzzzv_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(yzzzzzzzzzzzt_, yzzzzzzzzzzzu_, System.ComponentModel.ListSortDirection.Descending);
                (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? yzzzzzzzzzzzw_ = context.Operators.First<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(yzzzzzzzzzzzv_);
                CqlInterval<CqlDateTime> yzzzzzzzzzzzx_ = yzzzzzzzzzzzw_?.interval;

                return yzzzzzzzzzzzx_;
            }
        };
        int? xzzzzzzzzzzzx_()
        {
            bool zzzzzzzzzzzzi_()
            {
                int? zzzzzzzzzzzzj_ = context.Operators.Count<CqlInterval<CqlDateTime>>(collapsedIntervals);
                bool? zzzzzzzzzzzzk_ = context.Operators.Equal(zzzzzzzzzzzzj_, 0);

                return zzzzzzzzzzzzk_ ?? false;
            };
            if (zzzzzzzzzzzzi_())
            {
                return 0;
            }
            else
            {
                (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? zzzzzzzzzzzzl_(CqlInterval<CqlDateTime> I)
                {
                    CqlInterval<CqlDateTime> azzzzzzzzzzzzh_ = this.DateTime_Interval_Set_Nulls_to_Zero(context, I);
                    CqlDateTime azzzzzzzzzzzzi_ = context.Operators.Start(azzzzzzzzzzzzh_);
                    CqlDateTime azzzzzzzzzzzzk_ = context.Operators.End(azzzzzzzzzzzzh_);
                    int? azzzzzzzzzzzzl_ = context.Operators.DurationBetween(azzzzzzzzzzzzi_, azzzzzzzzzzzzk_, "day");
                    int? azzzzzzzzzzzzm_ = context.Operators.Add(azzzzzzzzzzzzl_, 1);
                    int?[] azzzzzzzzzzzzn_ = [
                        azzzzzzzzzzzzm_,
                        0,
                    ];
                    int? azzzzzzzzzzzzo_ = context.Operators.Max<int?>(azzzzzzzzzzzzn_ as IEnumerable<int?>);
                    (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? azzzzzzzzzzzzp_ = (CqlTupleMetadata_CGHEUIgjaCjJVKEADTSZEbdCL, I, azzzzzzzzzzzzo_);

                    return azzzzzzzzzzzzp_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> zzzzzzzzzzzzm_ = context.Operators.Select<CqlInterval<CqlDateTime>, (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(collapsedIntervals, zzzzzzzzzzzzl_);
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> zzzzzzzzzzzzn_ = context.Operators.Distinct<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(zzzzzzzzzzzzm_);
                object zzzzzzzzzzzzo_((CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? @this)
                {
                    int? azzzzzzzzzzzzq_ = @this?.days;

                    return azzzzzzzzzzzzq_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> zzzzzzzzzzzzp_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(zzzzzzzzzzzzn_, zzzzzzzzzzzzo_, System.ComponentModel.ListSortDirection.Descending);
                (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? zzzzzzzzzzzzq_ = context.Operators.First<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(zzzzzzzzzzzzp_);
                CqlInterval<CqlDateTime> zzzzzzzzzzzzr_ = zzzzzzzzzzzzq_?.interval;
                CqlInterval<CqlDateTime> zzzzzzzzzzzzs_ = this.DateTime_Interval_Set_Nulls_to_Zero(context, zzzzzzzzzzzzr_);
                CqlDateTime zzzzzzzzzzzzt_ = context.Operators.Start(zzzzzzzzzzzzs_);
                (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? zzzzzzzzzzzzu_(CqlInterval<CqlDateTime> I)
                {
                    CqlInterval<CqlDateTime> azzzzzzzzzzzzr_ = this.DateTime_Interval_Set_Nulls_to_Zero(context, I);
                    CqlDateTime azzzzzzzzzzzzs_ = context.Operators.Start(azzzzzzzzzzzzr_);
                    CqlDateTime azzzzzzzzzzzzu_ = context.Operators.End(azzzzzzzzzzzzr_);
                    int? azzzzzzzzzzzzv_ = context.Operators.DurationBetween(azzzzzzzzzzzzs_, azzzzzzzzzzzzu_, "day");
                    int? azzzzzzzzzzzzw_ = context.Operators.Add(azzzzzzzzzzzzv_, 1);
                    int?[] azzzzzzzzzzzzx_ = [
                        azzzzzzzzzzzzw_,
                        0,
                    ];
                    int? azzzzzzzzzzzzy_ = context.Operators.Max<int?>(azzzzzzzzzzzzx_ as IEnumerable<int?>);
                    (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? azzzzzzzzzzzzz_ = (CqlTupleMetadata_CGHEUIgjaCjJVKEADTSZEbdCL, I, azzzzzzzzzzzzy_);

                    return azzzzzzzzzzzzz_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> zzzzzzzzzzzzv_ = context.Operators.Select<CqlInterval<CqlDateTime>, (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(collapsedIntervals, zzzzzzzzzzzzu_);
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> zzzzzzzzzzzzw_ = context.Operators.Distinct<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(zzzzzzzzzzzzv_);
                object zzzzzzzzzzzzx_((CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? @this)
                {
                    int? bzzzzzzzzzzzza_ = @this?.days;

                    return bzzzzzzzzzzzza_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> zzzzzzzzzzzzy_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(zzzzzzzzzzzzw_, zzzzzzzzzzzzx_, System.ComponentModel.ListSortDirection.Descending);
                (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? zzzzzzzzzzzzz_ = context.Operators.First<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(zzzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> azzzzzzzzzzzza_ = zzzzzzzzzzzzz_?.interval;
                CqlInterval<CqlDateTime> azzzzzzzzzzzzb_ = this.DateTime_Interval_Set_Nulls_to_Zero(context, azzzzzzzzzzzza_);
                CqlDateTime azzzzzzzzzzzzc_ = context.Operators.End(azzzzzzzzzzzzb_);
                int? azzzzzzzzzzzzd_ = context.Operators.DurationBetween(zzzzzzzzzzzzt_, azzzzzzzzzzzzc_, "day");
                int? azzzzzzzzzzzze_ = context.Operators.Add(azzzzzzzzzzzzd_, 1);
                int?[] azzzzzzzzzzzzf_ = [
                    azzzzzzzzzzzze_,
                    0,
                ];
                int? azzzzzzzzzzzzg_ = context.Operators.Max<int?>(azzzzzzzzzzzzf_ as IEnumerable<int?>);

                return azzzzzzzzzzzzg_;
            }
        };
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? xzzzzzzzzzzzy_ = (CqlTupleMetadata_HDihbLieYfQbgeSbOWZBAMUIQ, collapsedIntervals, xzzzzzzzzzzzu_, xzzzzzzzzzzzv_(), xzzzzzzzzzzzw_(), xzzzzzzzzzzzx_());

        return xzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("DateTime Interval Covering Relative to Base Interval Stats")]
    public (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? DateTime_Interval_Covering_Relative_to_Base_Interval_Stats(CqlContext context, CqlInterval<CqlDateTime> baseInterval, IEnumerable<CqlInterval<CqlDateTime>> coveringIntervals)
    {
        IEnumerable<CqlInterval<CqlDateTime>> bzzzzzzzzzzzzb_ = this.DateTime_Interval_Covering_Relative_to_Base_Interval(context, baseInterval, coveringIntervals);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Covering_Intervals)? bzzzzzzzzzzzzc_ = (CqlTupleMetadata_GZMPWdGOJiTNjfWAcbZMePdXV, bzzzzzzzzzzzzb_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Covering_Intervals)?[] bzzzzzzzzzzzzd_ = [
            bzzzzzzzzzzzzc_,
        ];
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? bzzzzzzzzzzzze_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Covering_Intervals)? variableDeclarations)
        {
            IEnumerable<CqlInterval<CqlDateTime>> bzzzzzzzzzzzzi_ = variableDeclarations?.Covering_Intervals;
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? bzzzzzzzzzzzzj_ = this.Collapsed_DateTime_Interval_Stats(context, bzzzzzzzzzzzzi_);

            return bzzzzzzzzzzzzj_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?> bzzzzzzzzzzzzf_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Covering_Intervals)?, (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Covering_Intervals)?>)bzzzzzzzzzzzzd_, bzzzzzzzzzzzze_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?> bzzzzzzzzzzzzg_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?>(bzzzzzzzzzzzzf_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? bzzzzzzzzzzzzh_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?>(bzzzzzzzzzzzzg_);

        return bzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("DateTime Interval Gaps Relative to Base Interval Stats")]
    public (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? DateTime_Interval_Gaps_Relative_to_Base_Interval_Stats(CqlContext context, CqlInterval<CqlDateTime> baseInterval, IEnumerable<CqlInterval<CqlDateTime>> coveringIntervals)
    {
        IEnumerable<CqlInterval<CqlDateTime>> bzzzzzzzzzzzzk_ = this.DateTime_Interval_Gaps_Relative_to_Base_Interval(context, baseInterval, coveringIntervals);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Gap_Intervals)? bzzzzzzzzzzzzl_ = (CqlTupleMetadata_CKbERRbOPGNBBERUOghhaOYSE, bzzzzzzzzzzzzk_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Gap_Intervals)?[] bzzzzzzzzzzzzm_ = [
            bzzzzzzzzzzzzl_,
        ];
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? bzzzzzzzzzzzzn_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Gap_Intervals)? variableDeclarations)
        {
            IEnumerable<CqlInterval<CqlDateTime>> bzzzzzzzzzzzzr_ = variableDeclarations?.Gap_Intervals;
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? bzzzzzzzzzzzzs_ = this.Collapsed_DateTime_Interval_Stats(context, bzzzzzzzzzzzzr_);

            return bzzzzzzzzzzzzs_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?> bzzzzzzzzzzzzo_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Gap_Intervals)?, (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Gap_Intervals)?>)bzzzzzzzzzzzzm_, bzzzzzzzzzzzzn_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?> bzzzzzzzzzzzzp_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?>(bzzzzzzzzzzzzo_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? bzzzzzzzzzzzzq_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?>(bzzzzzzzzzzzzp_);

        return bzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Convert To UTC DateTime")]
    public CqlDateTime Convert_To_UTC_DateTime(CqlContext context, CqlDate d)
    {
        int? bzzzzzzzzzzzzt_ = context.Operators.DateTimeComponentFrom(d, "year");
        int? bzzzzzzzzzzzzu_()
        {
            if ((context.Operators.DateTimeComponentFrom(d, "month")) is null)
            {
                return 0;
            }
            else
            {
                int? czzzzzzzzzzzzc_ = context.Operators.DateTimeComponentFrom(d, "month");

                return czzzzzzzzzzzzc_;
            }
        };
        int? bzzzzzzzzzzzzv_()
        {
            if ((context.Operators.DateTimeComponentFrom(d, "day")) is null)
            {
                return 0;
            }
            else
            {
                int? czzzzzzzzzzzzd_ = context.Operators.DateTimeComponentFrom(d, "day");

                return czzzzzzzzzzzzd_;
            }
        };
        (CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)? bzzzzzzzzzzzzw_ = (CqlTupleMetadata_FcQREFSfPJSKYAhSEWVJcZVED, bzzzzzzzzzzzzt_, bzzzzzzzzzzzzu_(), bzzzzzzzzzzzzv_(), default, default, default, default, default, default, default, default, default, default, default);
        (CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)?[] bzzzzzzzzzzzzx_ = [
            bzzzzzzzzzzzzw_,
        ];
        CqlDateTime bzzzzzzzzzzzzy_((CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)? i)
        {
            int? czzzzzzzzzzzze_ = i?.StartYear;
            int? czzzzzzzzzzzzf_ = i?.StartMonth;
            int? czzzzzzzzzzzzg_ = i?.StartDay;
            decimal? czzzzzzzzzzzzh_ = context.Operators.ConvertIntegerToDecimal(0);
            CqlDateTime czzzzzzzzzzzzi_ = context.Operators.DateTime(czzzzzzzzzzzze_, czzzzzzzzzzzzf_, czzzzzzzzzzzzg_, 0, 0, 0, 0, czzzzzzzzzzzzh_);

            return czzzzzzzzzzzzi_;
        };
        IEnumerable<CqlDateTime> bzzzzzzzzzzzzz_ = context.Operators.Select<(CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)?, CqlDateTime>((IEnumerable<(CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)?>)bzzzzzzzzzzzzx_, bzzzzzzzzzzzzy_);
        IEnumerable<CqlDateTime> czzzzzzzzzzzza_ = context.Operators.Distinct<CqlDateTime>(bzzzzzzzzzzzzz_);
        CqlDateTime czzzzzzzzzzzzb_ = context.Operators.SingletonFrom<CqlDateTime>(czzzzzzzzzzzza_);

        return czzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Convert Interval Date to UTC Interval DateTime")]
    public CqlInterval<CqlDateTime> Convert_Interval_Date_to_UTC_Interval_DateTime(CqlContext context, CqlInterval<CqlDate> interval)
    {
        CqlDate czzzzzzzzzzzzj_ = context.Operators.Start(interval);
        CqlDateTime czzzzzzzzzzzzk_ = this.Convert_To_UTC_DateTime(context, czzzzzzzzzzzzj_);
        CqlDate czzzzzzzzzzzzl_ = context.Operators.End(interval);
        CqlDateTime czzzzzzzzzzzzm_ = this.Convert_To_UTC_DateTime(context, czzzzzzzzzzzzl_);
        CqlInterval<CqlDateTime> czzzzzzzzzzzzn_ = context.Operators.Interval(czzzzzzzzzzzzk_, czzzzzzzzzzzzm_, true, true);

        return czzzzzzzzzzzzn_;
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
