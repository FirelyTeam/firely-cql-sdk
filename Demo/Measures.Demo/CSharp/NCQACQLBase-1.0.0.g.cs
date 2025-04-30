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
        IEnumerable<CqlInterval<CqlDate>> dzzzzzzza_()
        {
            bool dzzzzzzzb_()
            {
                int? dzzzzzzzc_ = context.Operators.Count<CqlInterval<CqlDate>>(intervals);
                bool? dzzzzzzzd_ = context.Operators.Equal(dzzzzzzzc_, 0);

                return dzzzzzzzd_ ?? false;
            };
            if (intervals is null)
            {
                CqlInterval<CqlDate>[] dzzzzzzze_ = []
;

                return dzzzzzzze_ as IEnumerable<CqlInterval<CqlDate>>;
            }
            else if (dzzzzzzzb_())
            {
                CqlInterval<CqlDate>[] dzzzzzzzf_ = []
;

                return dzzzzzzzf_ as IEnumerable<CqlInterval<CqlDate>>;
            }
            else
            {
                (CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)? dzzzzzzzg_(CqlInterval<CqlDate> I)
                {
                    CqlDate dzzzzzzzo_()
                    {
                        if ((context.Operators.Start(I)) is null)
                        {
                            CqlDate dzzzzzzzq_ = context.Operators.MinValue<CqlDate>();

                            return dzzzzzzzq_;
                        }
                        else
                        {
                            CqlDate dzzzzzzzr_ = context.Operators.Start(I);

                            return dzzzzzzzr_;
                        }
                    };
                    (CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)? dzzzzzzzp_ = (CqlTupleMetadata_GIMHfXDcFiAjSJBDGYeUeZLhW, I, dzzzzzzzo_());

                    return dzzzzzzzp_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)?> dzzzzzzzh_ = context.Operators.Select<CqlInterval<CqlDate>, (CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)?>(intervals, dzzzzzzzg_);
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)?> dzzzzzzzi_ = context.Operators.Distinct<(CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)?>(dzzzzzzzh_);
                object dzzzzzzzj_((CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)? @this)
                {
                    CqlDate dzzzzzzzs_ = @this?.startOfInterval;

                    return dzzzzzzzs_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)?> dzzzzzzzk_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)?>(dzzzzzzzi_, dzzzzzzzj_, System.ComponentModel.ListSortDirection.Ascending);
                CqlInterval<CqlDate> dzzzzzzzl_((CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)? sortedIntervals)
                {
                    CqlInterval<CqlDate> dzzzzzzzt_ = sortedIntervals?.interval;

                    return dzzzzzzzt_;
                };
                IEnumerable<CqlInterval<CqlDate>> dzzzzzzzm_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)?, CqlInterval<CqlDate>>(dzzzzzzzk_, dzzzzzzzl_);
                IEnumerable<CqlInterval<CqlDate>> dzzzzzzzn_ = context.Operators.Distinct<CqlInterval<CqlDate>>(dzzzzzzzm_);

                return dzzzzzzzn_;
            }
        };

        return dzzzzzzza_();
    }


    [CqlExpressionDefinition("Sort DateTime Intervals")]
    public IEnumerable<CqlInterval<CqlDateTime>> Sort_DateTime_Intervals(CqlContext context, IEnumerable<CqlInterval<CqlDateTime>> intervals)
    {
        IEnumerable<CqlInterval<CqlDateTime>> dzzzzzzzu_()
        {
            bool dzzzzzzzv_()
            {
                int? dzzzzzzzw_ = context.Operators.Count<CqlInterval<CqlDateTime>>(intervals);
                bool? dzzzzzzzx_ = context.Operators.Equal(dzzzzzzzw_, 0);

                return dzzzzzzzx_ ?? false;
            };
            if (intervals is null)
            {
                CqlInterval<CqlDateTime>[] dzzzzzzzy_ = []
;

                return dzzzzzzzy_ as IEnumerable<CqlInterval<CqlDateTime>>;
            }
            else if (dzzzzzzzv_())
            {
                CqlInterval<CqlDateTime>[] dzzzzzzzz_ = []
;

                return dzzzzzzzz_ as IEnumerable<CqlInterval<CqlDateTime>>;
            }
            else
            {
                (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)? ezzzzzzza_(CqlInterval<CqlDateTime> I)
                {
                    CqlDateTime ezzzzzzzi_()
                    {
                        if ((context.Operators.Start(I)) is null)
                        {
                            CqlDateTime ezzzzzzzk_ = context.Operators.MinValue<CqlDateTime>();

                            return ezzzzzzzk_;
                        }
                        else
                        {
                            CqlDateTime ezzzzzzzl_ = context.Operators.Start(I);

                            return ezzzzzzzl_;
                        }
                    };
                    (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)? ezzzzzzzj_ = (CqlTupleMetadata_EQHOUSiiWahbJPOUjJGEhIAOV, I, ezzzzzzzi_());

                    return ezzzzzzzj_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?> ezzzzzzzb_ = context.Operators.Select<CqlInterval<CqlDateTime>, (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?>(intervals, ezzzzzzza_);
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?> ezzzzzzzc_ = context.Operators.Distinct<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?>(ezzzzzzzb_);
                object ezzzzzzzd_((CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)? @this)
                {
                    CqlDateTime ezzzzzzzm_ = @this?.startOfInterval;

                    return ezzzzzzzm_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?> ezzzzzzze_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?>(ezzzzzzzc_, ezzzzzzzd_, System.ComponentModel.ListSortDirection.Ascending);
                CqlInterval<CqlDateTime> ezzzzzzzf_((CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)? sortedIntervals)
                {
                    CqlInterval<CqlDateTime> ezzzzzzzn_ = sortedIntervals?.interval;

                    return ezzzzzzzn_;
                };
                IEnumerable<CqlInterval<CqlDateTime>> ezzzzzzzg_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?, CqlInterval<CqlDateTime>>(ezzzzzzze_, ezzzzzzzf_);
                IEnumerable<CqlInterval<CqlDateTime>> ezzzzzzzh_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(ezzzzzzzg_);

                return ezzzzzzzh_;
            }
        };

        return dzzzzzzzu_();
    }


    [CqlExpressionDefinition("Collapse Date Interval Workaround")]
    public IEnumerable<CqlInterval<CqlDate>> Collapse_Date_Interval_Workaround(CqlContext context, IEnumerable<CqlInterval<CqlDate>> intervals)
    {
        IEnumerable<CqlInterval<CqlDate>> ezzzzzzzo_()
        {
            bool ezzzzzzzp_()
            {
                int? ezzzzzzzq_ = context.Operators.Count<CqlInterval<CqlDate>>(intervals);
                bool? ezzzzzzzr_ = context.Operators.Equal(ezzzzzzzq_, 0);

                return ezzzzzzzr_ ?? false;
            };
            if (intervals is null)
            {
                CqlInterval<CqlDate>[] ezzzzzzzs_ = []
;

                return ezzzzzzzs_ as IEnumerable<CqlInterval<CqlDate>>;
            }
            else if (ezzzzzzzp_())
            {
                CqlInterval<CqlDate>[] ezzzzzzzt_ = []
;

                return ezzzzzzzt_ as IEnumerable<CqlInterval<CqlDate>>;
            }
            else
            {
                bool? ezzzzzzzu_(CqlInterval<CqlDate> I)
                {
                    bool? ezzzzzzzx_(CqlInterval<CqlDate> J)
                    {
                        bool? fzzzzzzzc_ = context.Operators.IntervalProperlyIncludesInterval<CqlDate>(J, I, default);

                        return fzzzzzzzc_;
                    };
                    IEnumerable<bool?> ezzzzzzzy_ = context.Operators.Select<CqlInterval<CqlDate>, bool?>(intervals, ezzzzzzzx_);
                    IEnumerable<bool?> ezzzzzzzz_ = context.Operators.Distinct<bool?>(ezzzzzzzy_);
                    bool? fzzzzzzza_ = context.Operators.AnyTrue(ezzzzzzzz_);
                    bool? fzzzzzzzb_ = context.Operators.Not(fzzzzzzza_);

                    return fzzzzzzzb_;
                };
                IEnumerable<CqlInterval<CqlDate>> ezzzzzzzv_ = context.Operators.Where<CqlInterval<CqlDate>>(intervals, ezzzzzzzu_);
                IEnumerable<CqlInterval<CqlDate>> ezzzzzzzw_ = context.Operators.Collapse(ezzzzzzzv_, "day");

                return ezzzzzzzw_;
            }
        };

        return ezzzzzzzo_();
    }


    [CqlExpressionDefinition("Collapse DateTime Interval Workaround")]
    public IEnumerable<CqlInterval<CqlDateTime>> Collapse_DateTime_Interval_Workaround(CqlContext context, IEnumerable<CqlInterval<CqlDateTime>> intervals)
    {
        IEnumerable<CqlInterval<CqlDateTime>> fzzzzzzzd_()
        {
            bool fzzzzzzze_()
            {
                int? fzzzzzzzf_ = context.Operators.Count<CqlInterval<CqlDateTime>>(intervals);
                bool? fzzzzzzzg_ = context.Operators.Equal(fzzzzzzzf_, 0);

                return fzzzzzzzg_ ?? false;
            };
            if (intervals is null)
            {
                CqlInterval<CqlDateTime>[] fzzzzzzzh_ = []
;

                return fzzzzzzzh_ as IEnumerable<CqlInterval<CqlDateTime>>;
            }
            else if (fzzzzzzze_())
            {
                CqlInterval<CqlDateTime>[] fzzzzzzzi_ = []
;

                return fzzzzzzzi_ as IEnumerable<CqlInterval<CqlDateTime>>;
            }
            else
            {
                bool? fzzzzzzzj_(CqlInterval<CqlDateTime> I)
                {
                    bool? fzzzzzzzm_(CqlInterval<CqlDateTime> J)
                    {
                        bool? fzzzzzzzr_ = context.Operators.IntervalProperlyIncludesInterval<CqlDateTime>(J, I, default);

                        return fzzzzzzzr_;
                    };
                    IEnumerable<bool?> fzzzzzzzn_ = context.Operators.Select<CqlInterval<CqlDateTime>, bool?>(intervals, fzzzzzzzm_);
                    IEnumerable<bool?> fzzzzzzzo_ = context.Operators.Distinct<bool?>(fzzzzzzzn_);
                    bool? fzzzzzzzp_ = context.Operators.AnyTrue(fzzzzzzzo_);
                    bool? fzzzzzzzq_ = context.Operators.Not(fzzzzzzzp_);

                    return fzzzzzzzq_;
                };
                IEnumerable<CqlInterval<CqlDateTime>> fzzzzzzzk_ = context.Operators.Where<CqlInterval<CqlDateTime>>(intervals, fzzzzzzzj_);
                IEnumerable<CqlInterval<CqlDateTime>> fzzzzzzzl_ = context.Operators.Collapse(fzzzzzzzk_, default);

                return fzzzzzzzl_;
            }
        };

        return fzzzzzzzd_();
    }


    [CqlExpressionDefinition("Date Interval Covering Relative to Base Interval")]
    public IEnumerable<CqlInterval<CqlDate>> Date_Interval_Covering_Relative_to_Base_Interval(CqlContext context, CqlInterval<CqlDate> baseInterval, IEnumerable<CqlInterval<CqlDate>> coveringIntervals)
    {
        IEnumerable<CqlInterval<CqlDate>> fzzzzzzzs_ = this.Sort_Date_Intervals(context, coveringIntervals);
        CqlInterval<CqlDate> fzzzzzzzt_(CqlInterval<CqlDate> sortedInterval)
        {
            CqlInterval<CqlDate> fzzzzzzzx_ = context.Operators.Intersect<CqlDate>(baseInterval, sortedInterval);

            return fzzzzzzzx_;
        };
        IEnumerable<CqlInterval<CqlDate>> fzzzzzzzu_ = context.Operators.Select<CqlInterval<CqlDate>, CqlInterval<CqlDate>>(fzzzzzzzs_, fzzzzzzzt_);
        IEnumerable<CqlInterval<CqlDate>> fzzzzzzzv_ = context.Operators.Distinct<CqlInterval<CqlDate>>(fzzzzzzzu_);
        IEnumerable<CqlInterval<CqlDate>> fzzzzzzzw_ = this.Collapse_Date_Interval_Workaround(context, fzzzzzzzv_);

        return fzzzzzzzw_;
    }


    [CqlExpressionDefinition("DateTime Interval Covering Relative to Base Interval")]
    public IEnumerable<CqlInterval<CqlDateTime>> DateTime_Interval_Covering_Relative_to_Base_Interval(CqlContext context, CqlInterval<CqlDateTime> baseInterval, IEnumerable<CqlInterval<CqlDateTime>> coveringIntervals)
    {
        IEnumerable<CqlInterval<CqlDateTime>> fzzzzzzzy_ = this.Sort_DateTime_Intervals(context, coveringIntervals);
        CqlInterval<CqlDateTime> fzzzzzzzz_(CqlInterval<CqlDateTime> sortedInterval)
        {
            CqlInterval<CqlDateTime> gzzzzzzzd_ = context.Operators.Intersect<CqlDateTime>(baseInterval, sortedInterval);

            return gzzzzzzzd_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> gzzzzzzza_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(fzzzzzzzy_, fzzzzzzzz_);
        IEnumerable<CqlInterval<CqlDateTime>> gzzzzzzzb_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(gzzzzzzza_);
        IEnumerable<CqlInterval<CqlDateTime>> gzzzzzzzc_ = this.Collapse_DateTime_Interval_Workaround(context, gzzzzzzzb_);

        return gzzzzzzzc_;
    }


    [CqlExpressionDefinition("Date Interval Gaps Relative to Base Interval")]
    public IEnumerable<CqlInterval<CqlDate>> Date_Interval_Gaps_Relative_to_Base_Interval(CqlContext context, CqlInterval<CqlDate> baseInterval, IEnumerable<CqlInterval<CqlDate>> coveringIntervals)
    {
        IEnumerable<CqlInterval<CqlDate>> gzzzzzzze_ = this.Date_Interval_Covering_Relative_to_Base_Interval(context, baseInterval, coveringIntervals);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> sortedCoverings)? gzzzzzzzf_ = (CqlTupleMetadata_EVRLVXPcBiDTIWfCCfKEWDfKI, gzzzzzzze_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> sortedCoverings)?[] gzzzzzzzg_ = [
            gzzzzzzzf_,
        ];
        IEnumerable<CqlInterval<CqlDate>> gzzzzzzzh_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> sortedCoverings)? variableDeclarations)
        {
            IEnumerable<CqlInterval<CqlDate>> gzzzzzzzl_()
            {
                bool gzzzzzzzt_()
                {
                    IEnumerable<CqlInterval<CqlDate>> gzzzzzzzu_ = variableDeclarations?.sortedCoverings;
                    int? gzzzzzzzv_ = context.Operators.Count<CqlInterval<CqlDate>>(gzzzzzzzu_);
                    bool? gzzzzzzzw_ = context.Operators.Equal(gzzzzzzzv_, 0);

                    return gzzzzzzzw_ ?? false;
                };
                if (gzzzzzzzt_())
                {
                    CqlInterval<CqlDate>[] gzzzzzzzx_ = [
                        baseInterval,
                    ];

                    return gzzzzzzzx_ as IEnumerable<CqlInterval<CqlDate>>;
                }
                else
                {
                    IEnumerable<CqlInterval<CqlDate>> gzzzzzzzy_ = variableDeclarations?.sortedCoverings;
                    CqlInterval<CqlDate> gzzzzzzzz_(CqlInterval<CqlDate> sortedCovering)
                    {
                        CqlInterval<CqlDate> hzzzzzzzc_()
                        {
                            bool hzzzzzzzd_()
                            {
                                IEnumerable<CqlInterval<CqlDate>> hzzzzzzze_ = variableDeclarations?.sortedCoverings;
                                int? hzzzzzzzf_ = context.Operators.IndexOf<CqlInterval<CqlDate>>(hzzzzzzze_, sortedCovering);
                                bool? hzzzzzzzg_ = context.Operators.Equal(hzzzzzzzf_, 0);

                                return hzzzzzzzg_ ?? false;
                            };
                            if (hzzzzzzzd_())
                            {
                                CqlDate hzzzzzzzh_ = context.Operators.Start(baseInterval);
                                CqlDate hzzzzzzzi_ = context.Operators.Start(sortedCovering);
                                CqlInterval<CqlDate> hzzzzzzzj_ = context.Operators.Interval(hzzzzzzzh_, hzzzzzzzi_, true, true);
                                CqlInterval<CqlDate> hzzzzzzzk_ = context.Operators.Intersect<CqlDate>(hzzzzzzzj_, baseInterval);
                                CqlInterval<CqlDate> hzzzzzzzl_ = context.Operators.Except(hzzzzzzzk_, sortedCovering);

                                return hzzzzzzzl_;
                            }
                            else
                            {
                                IEnumerable<CqlInterval<CqlDate>> hzzzzzzzm_ = variableDeclarations?.sortedCoverings;
                                int? hzzzzzzzo_ = context.Operators.IndexOf<CqlInterval<CqlDate>>(hzzzzzzzm_, sortedCovering);
                                int? hzzzzzzzp_ = context.Operators.Subtract(hzzzzzzzo_, 1);
                                CqlInterval<CqlDate> hzzzzzzzq_ = context.Operators.Indexer<CqlInterval<CqlDate>>(hzzzzzzzm_, hzzzzzzzp_);
                                CqlDate hzzzzzzzr_ = context.Operators.Start(hzzzzzzzq_);
                                CqlDate hzzzzzzzs_ = context.Operators.End(sortedCovering);
                                CqlInterval<CqlDate> hzzzzzzzt_ = context.Operators.Interval(hzzzzzzzr_, hzzzzzzzs_, false, false);
                                int? hzzzzzzzw_ = context.Operators.IndexOf<CqlInterval<CqlDate>>(hzzzzzzzm_, sortedCovering);
                                int? hzzzzzzzx_ = context.Operators.Subtract(hzzzzzzzw_, 1);
                                CqlInterval<CqlDate> hzzzzzzzy_ = context.Operators.Indexer<CqlInterval<CqlDate>>(hzzzzzzzm_, hzzzzzzzx_);
                                CqlInterval<CqlDate> hzzzzzzzz_ = context.Operators.Except(hzzzzzzzt_, hzzzzzzzy_);
                                CqlInterval<CqlDate> izzzzzzza_ = context.Operators.Except(hzzzzzzzz_, sortedCovering);

                                return izzzzzzza_;
                            }
                        };

                        return hzzzzzzzc_();
                    };
                    IEnumerable<CqlInterval<CqlDate>> hzzzzzzza_ = context.Operators.Select<CqlInterval<CqlDate>, CqlInterval<CqlDate>>(gzzzzzzzy_, gzzzzzzzz_);
                    IEnumerable<CqlInterval<CqlDate>> hzzzzzzzb_ = context.Operators.Distinct<CqlInterval<CqlDate>>(hzzzzzzza_);

                    return hzzzzzzzb_;
                }
            };
            IEnumerable<CqlInterval<CqlDate>> gzzzzzzzm_()
            {
                bool izzzzzzzb_()
                {
                    IEnumerable<CqlInterval<CqlDate>> izzzzzzzc_ = variableDeclarations?.sortedCoverings;
                    int? izzzzzzzd_ = context.Operators.Count<CqlInterval<CqlDate>>(izzzzzzzc_);
                    bool? izzzzzzze_ = context.Operators.Equal(izzzzzzzd_, 0);

                    return izzzzzzze_ ?? false;
                };
                if (izzzzzzzb_())
                {
                    CqlInterval<CqlDate>[] izzzzzzzf_ = []
;

                    return izzzzzzzf_ as IEnumerable<CqlInterval<CqlDate>>;
                }
                else
                {
                    IEnumerable<CqlInterval<CqlDate>> izzzzzzzg_ = variableDeclarations?.sortedCoverings;
                    CqlInterval<CqlDate> izzzzzzzh_ = context.Operators.Last<CqlInterval<CqlDate>>(izzzzzzzg_);
                    CqlDate izzzzzzzi_ = context.Operators.Start(izzzzzzzh_);
                    CqlDate izzzzzzzj_ = context.Operators.End(baseInterval);
                    CqlInterval<CqlDate> izzzzzzzk_ = context.Operators.Interval(izzzzzzzi_, izzzzzzzj_, false, true);
                    CqlInterval<CqlDate> izzzzzzzm_ = context.Operators.Last<CqlInterval<CqlDate>>(izzzzzzzg_);
                    CqlInterval<CqlDate> izzzzzzzn_ = context.Operators.Except(izzzzzzzk_, izzzzzzzm_);
                    CqlInterval<CqlDate> izzzzzzzo_ = context.Operators.Intersect<CqlDate>(izzzzzzzn_, baseInterval);
                    CqlInterval<CqlDate>[] izzzzzzzp_ = [
                        izzzzzzzo_,
                    ];

                    return izzzzzzzp_ as IEnumerable<CqlInterval<CqlDate>>;
                }
            };
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> frontgaps, IEnumerable<CqlInterval<CqlDate>> endgap)? gzzzzzzzn_ = (CqlTupleMetadata_FKcLSALRMRfDigEFaJgDOPFRK, gzzzzzzzl_(), gzzzzzzzm_());
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> frontgaps, IEnumerable<CqlInterval<CqlDate>> endgap)?[] gzzzzzzzo_ = [
                gzzzzzzzn_,
            ];
            IEnumerable<CqlInterval<CqlDate>> gzzzzzzzp_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> frontgaps, IEnumerable<CqlInterval<CqlDate>> endgap)? calculations)
            {
                IEnumerable<CqlInterval<CqlDate>> izzzzzzzq_ = calculations?.frontgaps;
                IEnumerable<CqlInterval<CqlDate>> izzzzzzzr_ = calculations?.endgap;
                IEnumerable<CqlInterval<CqlDate>> izzzzzzzs_ = context.Operators.Union<CqlInterval<CqlDate>>(izzzzzzzq_, izzzzzzzr_);
                IEnumerable<CqlInterval<CqlDate>> izzzzzzzt_ = this.Collapse_Date_Interval_Workaround(context, izzzzzzzs_);

                return izzzzzzzt_;
            };
            IEnumerable<IEnumerable<CqlInterval<CqlDate>>> gzzzzzzzq_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> frontgaps, IEnumerable<CqlInterval<CqlDate>> endgap)?, IEnumerable<CqlInterval<CqlDate>>>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> frontgaps, IEnumerable<CqlInterval<CqlDate>> endgap)?>)gzzzzzzzo_, gzzzzzzzp_);
            IEnumerable<IEnumerable<CqlInterval<CqlDate>>> gzzzzzzzr_ = context.Operators.Distinct<IEnumerable<CqlInterval<CqlDate>>>(gzzzzzzzq_);
            IEnumerable<CqlInterval<CqlDate>> gzzzzzzzs_ = context.Operators.SingletonFrom<IEnumerable<CqlInterval<CqlDate>>>(gzzzzzzzr_);

            return gzzzzzzzs_;
        };
        IEnumerable<IEnumerable<CqlInterval<CqlDate>>> gzzzzzzzi_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> sortedCoverings)?, IEnumerable<CqlInterval<CqlDate>>>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> sortedCoverings)?>)gzzzzzzzg_, gzzzzzzzh_);
        IEnumerable<IEnumerable<CqlInterval<CqlDate>>> gzzzzzzzj_ = context.Operators.Distinct<IEnumerable<CqlInterval<CqlDate>>>(gzzzzzzzi_);
        IEnumerable<CqlInterval<CqlDate>> gzzzzzzzk_ = context.Operators.SingletonFrom<IEnumerable<CqlInterval<CqlDate>>>(gzzzzzzzj_);

        return gzzzzzzzk_;
    }


    [CqlExpressionDefinition("DateTime Interval Gaps Relative to Base Interval")]
    public IEnumerable<CqlInterval<CqlDateTime>> DateTime_Interval_Gaps_Relative_to_Base_Interval(CqlContext context, CqlInterval<CqlDateTime> baseInterval, IEnumerable<CqlInterval<CqlDateTime>> coveringIntervals)
    {
        IEnumerable<CqlInterval<CqlDateTime>> izzzzzzzu_ = this.DateTime_Interval_Covering_Relative_to_Base_Interval(context, baseInterval, coveringIntervals);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> sortedCoverings)? izzzzzzzv_ = (CqlTupleMetadata_EdgSWaTaCbLYLJceGdIcWOLHd, izzzzzzzu_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> sortedCoverings)?[] izzzzzzzw_ = [
            izzzzzzzv_,
        ];
        IEnumerable<CqlInterval<CqlDateTime>> izzzzzzzx_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> sortedCoverings)? variableDeclarations)
        {
            IEnumerable<CqlInterval<CqlDateTime>> jzzzzzzzb_()
            {
                bool jzzzzzzzj_()
                {
                    IEnumerable<CqlInterval<CqlDateTime>> jzzzzzzzk_ = variableDeclarations?.sortedCoverings;
                    int? jzzzzzzzl_ = context.Operators.Count<CqlInterval<CqlDateTime>>(jzzzzzzzk_);
                    bool? jzzzzzzzm_ = context.Operators.Equal(jzzzzzzzl_, 0);

                    return jzzzzzzzm_ ?? false;
                };
                if (jzzzzzzzj_())
                {
                    CqlInterval<CqlDateTime>[] jzzzzzzzn_ = [
                        baseInterval,
                    ];

                    return jzzzzzzzn_ as IEnumerable<CqlInterval<CqlDateTime>>;
                }
                else
                {
                    IEnumerable<CqlInterval<CqlDateTime>> jzzzzzzzo_ = variableDeclarations?.sortedCoverings;
                    CqlInterval<CqlDateTime> jzzzzzzzp_(CqlInterval<CqlDateTime> sortedCovering)
                    {
                        CqlInterval<CqlDateTime> jzzzzzzzs_()
                        {
                            bool jzzzzzzzt_()
                            {
                                IEnumerable<CqlInterval<CqlDateTime>> jzzzzzzzu_ = variableDeclarations?.sortedCoverings;
                                int? jzzzzzzzv_ = context.Operators.IndexOf<CqlInterval<CqlDateTime>>(jzzzzzzzu_, sortedCovering);
                                bool? jzzzzzzzw_ = context.Operators.Equal(jzzzzzzzv_, 0);

                                return jzzzzzzzw_ ?? false;
                            };
                            if (jzzzzzzzt_())
                            {
                                CqlDateTime jzzzzzzzx_ = context.Operators.Start(baseInterval);
                                CqlDateTime jzzzzzzzy_ = context.Operators.Start(sortedCovering);
                                CqlInterval<CqlDateTime> jzzzzzzzz_ = context.Operators.Interval(jzzzzzzzx_, jzzzzzzzy_, true, true);
                                CqlInterval<CqlDateTime> kzzzzzzza_ = context.Operators.Intersect<CqlDateTime>(jzzzzzzzz_, baseInterval);
                                CqlInterval<CqlDateTime> kzzzzzzzb_ = context.Operators.Except(kzzzzzzza_, sortedCovering);

                                return kzzzzzzzb_;
                            }
                            else
                            {
                                IEnumerable<CqlInterval<CqlDateTime>> kzzzzzzzc_ = variableDeclarations?.sortedCoverings;
                                int? kzzzzzzze_ = context.Operators.IndexOf<CqlInterval<CqlDateTime>>(kzzzzzzzc_, sortedCovering);
                                int? kzzzzzzzf_ = context.Operators.Subtract(kzzzzzzze_, 1);
                                CqlInterval<CqlDateTime> kzzzzzzzg_ = context.Operators.Indexer<CqlInterval<CqlDateTime>>(kzzzzzzzc_, kzzzzzzzf_);
                                CqlDateTime kzzzzzzzh_ = context.Operators.Start(kzzzzzzzg_);
                                CqlDateTime kzzzzzzzi_ = context.Operators.End(sortedCovering);
                                CqlInterval<CqlDateTime> kzzzzzzzj_ = context.Operators.Interval(kzzzzzzzh_, kzzzzzzzi_, false, false);
                                int? kzzzzzzzm_ = context.Operators.IndexOf<CqlInterval<CqlDateTime>>(kzzzzzzzc_, sortedCovering);
                                int? kzzzzzzzn_ = context.Operators.Subtract(kzzzzzzzm_, 1);
                                CqlInterval<CqlDateTime> kzzzzzzzo_ = context.Operators.Indexer<CqlInterval<CqlDateTime>>(kzzzzzzzc_, kzzzzzzzn_);
                                CqlInterval<CqlDateTime> kzzzzzzzp_ = context.Operators.Except(kzzzzzzzj_, kzzzzzzzo_);
                                CqlInterval<CqlDateTime> kzzzzzzzq_ = context.Operators.Except(kzzzzzzzp_, sortedCovering);

                                return kzzzzzzzq_;
                            }
                        };

                        return jzzzzzzzs_();
                    };
                    IEnumerable<CqlInterval<CqlDateTime>> jzzzzzzzq_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(jzzzzzzzo_, jzzzzzzzp_);
                    IEnumerable<CqlInterval<CqlDateTime>> jzzzzzzzr_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(jzzzzzzzq_);

                    return jzzzzzzzr_;
                }
            };
            IEnumerable<CqlInterval<CqlDateTime>> jzzzzzzzc_()
            {
                bool kzzzzzzzr_()
                {
                    IEnumerable<CqlInterval<CqlDateTime>> kzzzzzzzs_ = variableDeclarations?.sortedCoverings;
                    int? kzzzzzzzt_ = context.Operators.Count<CqlInterval<CqlDateTime>>(kzzzzzzzs_);
                    bool? kzzzzzzzu_ = context.Operators.Equal(kzzzzzzzt_, 0);

                    return kzzzzzzzu_ ?? false;
                };
                if (kzzzzzzzr_())
                {
                    CqlInterval<CqlDateTime>[] kzzzzzzzv_ = []
;

                    return kzzzzzzzv_ as IEnumerable<CqlInterval<CqlDateTime>>;
                }
                else
                {
                    IEnumerable<CqlInterval<CqlDateTime>> kzzzzzzzw_ = variableDeclarations?.sortedCoverings;
                    CqlInterval<CqlDateTime> kzzzzzzzx_ = context.Operators.Last<CqlInterval<CqlDateTime>>(kzzzzzzzw_);
                    CqlDateTime kzzzzzzzy_ = context.Operators.Start(kzzzzzzzx_);
                    CqlDateTime kzzzzzzzz_ = context.Operators.End(baseInterval);
                    CqlInterval<CqlDateTime> lzzzzzzza_ = context.Operators.Interval(kzzzzzzzy_, kzzzzzzzz_, false, true);
                    CqlInterval<CqlDateTime> lzzzzzzzc_ = context.Operators.Last<CqlInterval<CqlDateTime>>(kzzzzzzzw_);
                    CqlInterval<CqlDateTime> lzzzzzzzd_ = context.Operators.Except(lzzzzzzza_, lzzzzzzzc_);
                    CqlInterval<CqlDateTime> lzzzzzzze_ = context.Operators.Intersect<CqlDateTime>(lzzzzzzzd_, baseInterval);
                    CqlInterval<CqlDateTime>[] lzzzzzzzf_ = [
                        lzzzzzzze_,
                    ];

                    return lzzzzzzzf_ as IEnumerable<CqlInterval<CqlDateTime>>;
                }
            };
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> frontgaps, IEnumerable<CqlInterval<CqlDateTime>> endgap)? jzzzzzzzd_ = (CqlTupleMetadata_BBLSSiNBQBGUDJaVjMDZMSAXg, jzzzzzzzb_(), jzzzzzzzc_());
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> frontgaps, IEnumerable<CqlInterval<CqlDateTime>> endgap)?[] jzzzzzzze_ = [
                jzzzzzzzd_,
            ];
            IEnumerable<CqlInterval<CqlDateTime>> jzzzzzzzf_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> frontgaps, IEnumerable<CqlInterval<CqlDateTime>> endgap)? calculations)
            {
                IEnumerable<CqlInterval<CqlDateTime>> lzzzzzzzg_ = calculations?.frontgaps;
                IEnumerable<CqlInterval<CqlDateTime>> lzzzzzzzh_ = calculations?.endgap;
                IEnumerable<CqlInterval<CqlDateTime>> lzzzzzzzi_ = context.Operators.Union<CqlInterval<CqlDateTime>>(lzzzzzzzg_, lzzzzzzzh_);
                IEnumerable<CqlInterval<CqlDateTime>> lzzzzzzzj_ = this.Collapse_DateTime_Interval_Workaround(context, lzzzzzzzi_);

                return lzzzzzzzj_;
            };
            IEnumerable<IEnumerable<CqlInterval<CqlDateTime>>> jzzzzzzzg_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> frontgaps, IEnumerable<CqlInterval<CqlDateTime>> endgap)?, IEnumerable<CqlInterval<CqlDateTime>>>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> frontgaps, IEnumerable<CqlInterval<CqlDateTime>> endgap)?>)jzzzzzzze_, jzzzzzzzf_);
            IEnumerable<IEnumerable<CqlInterval<CqlDateTime>>> jzzzzzzzh_ = context.Operators.Distinct<IEnumerable<CqlInterval<CqlDateTime>>>(jzzzzzzzg_);
            IEnumerable<CqlInterval<CqlDateTime>> jzzzzzzzi_ = context.Operators.SingletonFrom<IEnumerable<CqlInterval<CqlDateTime>>>(jzzzzzzzh_);

            return jzzzzzzzi_;
        };
        IEnumerable<IEnumerable<CqlInterval<CqlDateTime>>> izzzzzzzy_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> sortedCoverings)?, IEnumerable<CqlInterval<CqlDateTime>>>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> sortedCoverings)?>)izzzzzzzw_, izzzzzzzx_);
        IEnumerable<IEnumerable<CqlInterval<CqlDateTime>>> izzzzzzzz_ = context.Operators.Distinct<IEnumerable<CqlInterval<CqlDateTime>>>(izzzzzzzy_);
        IEnumerable<CqlInterval<CqlDateTime>> jzzzzzzza_ = context.Operators.SingletonFrom<IEnumerable<CqlInterval<CqlDateTime>>>(izzzzzzzz_);

        return jzzzzzzza_;
    }


    [CqlExpressionDefinition("Collapsed Date Interval Stats")]
    public (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? Collapsed_Date_Interval_Stats(CqlContext context, IEnumerable<CqlInterval<CqlDate>> collapsedIntervals)
    {
        int? lzzzzzzzk_ = context.Operators.Count<CqlInterval<CqlDate>>(collapsedIntervals);
        int? lzzzzzzzl_()
        {
            bool lzzzzzzzp_()
            {
                int? lzzzzzzzq_ = context.Operators.Count<CqlInterval<CqlDate>>(collapsedIntervals);
                bool? lzzzzzzzr_ = context.Operators.Equal(lzzzzzzzq_, 0);

                return lzzzzzzzr_ ?? false;
            };
            if (lzzzzzzzp_())
            {
                return 0;
            }
            else
            {
                int? lzzzzzzzs_(CqlInterval<CqlDate> I)
                {
                    CqlDate lzzzzzzzw_ = context.Operators.Start(I);
                    CqlDate lzzzzzzzx_ = context.Operators.End(I);
                    int? lzzzzzzzy_ = context.Operators.DurationBetween(lzzzzzzzw_, lzzzzzzzx_, "day");
                    int? lzzzzzzzz_ = context.Operators.Add(lzzzzzzzy_, 1);
                    int?[] mzzzzzzza_ = [
                        lzzzzzzzz_,
                        0,
                    ];
                    int? mzzzzzzzb_ = context.Operators.Max<int?>(mzzzzzzza_ as IEnumerable<int?>);

                    return mzzzzzzzb_;
                };
                IEnumerable<int?> lzzzzzzzt_ = context.Operators.Select<CqlInterval<CqlDate>, int?>(collapsedIntervals, lzzzzzzzs_);
                IEnumerable<int?> lzzzzzzzu_ = context.Operators.Distinct<int?>(lzzzzzzzt_);
                int? lzzzzzzzv_ = context.Operators.Sum(lzzzzzzzu_);

                return lzzzzzzzv_;
            }
        };
        CqlInterval<CqlDate> lzzzzzzzm_()
        {
            bool mzzzzzzzc_()
            {
                int? mzzzzzzzd_ = context.Operators.Count<CqlInterval<CqlDate>>(collapsedIntervals);
                bool? mzzzzzzze_ = context.Operators.Equal(mzzzzzzzd_, 0);

                return mzzzzzzze_ ?? false;
            };
            if (mzzzzzzzc_())
            {
                return null as CqlInterval<CqlDate>;
            }
            else
            {
                (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? mzzzzzzzf_(CqlInterval<CqlDate> I)
                {
                    CqlDate mzzzzzzzm_ = context.Operators.Start(I);
                    CqlDate mzzzzzzzn_ = context.Operators.End(I);
                    int? mzzzzzzzo_ = context.Operators.DurationBetween(mzzzzzzzm_, mzzzzzzzn_, "day");
                    int? mzzzzzzzp_ = context.Operators.Add(mzzzzzzzo_, 1);
                    int?[] mzzzzzzzq_ = [
                        mzzzzzzzp_,
                        0,
                    ];
                    int? mzzzzzzzr_ = context.Operators.Max<int?>(mzzzzzzzq_ as IEnumerable<int?>);
                    (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? mzzzzzzzs_ = (CqlTupleMetadata_HEjPGjPEhLgQPGjROeWMgiGfC, I, mzzzzzzzr_);

                    return mzzzzzzzs_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> mzzzzzzzg_ = context.Operators.Select<CqlInterval<CqlDate>, (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(collapsedIntervals, mzzzzzzzf_);
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> mzzzzzzzh_ = context.Operators.Distinct<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(mzzzzzzzg_);
                object mzzzzzzzi_((CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? @this)
                {
                    int? mzzzzzzzt_ = @this?.days;

                    return mzzzzzzzt_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> mzzzzzzzj_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(mzzzzzzzh_, mzzzzzzzi_, System.ComponentModel.ListSortDirection.Descending);
                (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? mzzzzzzzk_ = context.Operators.First<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(mzzzzzzzj_);
                CqlInterval<CqlDate> mzzzzzzzl_ = mzzzzzzzk_?.interval;

                return mzzzzzzzl_;
            }
        };
        int? lzzzzzzzn_()
        {
            bool mzzzzzzzu_()
            {
                int? mzzzzzzzv_ = context.Operators.Count<CqlInterval<CqlDate>>(collapsedIntervals);
                bool? mzzzzzzzw_ = context.Operators.Equal(mzzzzzzzv_, 0);

                return mzzzzzzzw_ ?? false;
            };
            if (mzzzzzzzu_())
            {
                return 0;
            }
            else
            {
                (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? mzzzzzzzx_(CqlInterval<CqlDate> I)
                {
                    CqlDate nzzzzzzzr_ = context.Operators.Start(I);
                    CqlDate nzzzzzzzs_ = context.Operators.End(I);
                    int? nzzzzzzzt_ = context.Operators.DurationBetween(nzzzzzzzr_, nzzzzzzzs_, "day");
                    int? nzzzzzzzu_ = context.Operators.Add(nzzzzzzzt_, 1);
                    int?[] nzzzzzzzv_ = [
                        nzzzzzzzu_,
                        0,
                    ];
                    int? nzzzzzzzw_ = context.Operators.Max<int?>(nzzzzzzzv_ as IEnumerable<int?>);
                    (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? nzzzzzzzx_ = (CqlTupleMetadata_HEjPGjPEhLgQPGjROeWMgiGfC, I, nzzzzzzzw_);

                    return nzzzzzzzx_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> mzzzzzzzy_ = context.Operators.Select<CqlInterval<CqlDate>, (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(collapsedIntervals, mzzzzzzzx_);
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> mzzzzzzzz_ = context.Operators.Distinct<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(mzzzzzzzy_);
                object nzzzzzzza_((CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? @this)
                {
                    int? nzzzzzzzy_ = @this?.days;

                    return nzzzzzzzy_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> nzzzzzzzb_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(mzzzzzzzz_, nzzzzzzza_, System.ComponentModel.ListSortDirection.Descending);
                (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? nzzzzzzzc_ = context.Operators.First<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(nzzzzzzzb_);
                CqlInterval<CqlDate> nzzzzzzzd_ = nzzzzzzzc_?.interval;
                CqlDate nzzzzzzze_ = context.Operators.Start(nzzzzzzzd_);
                (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? nzzzzzzzf_(CqlInterval<CqlDate> I)
                {
                    CqlDate nzzzzzzzz_ = context.Operators.Start(I);
                    CqlDate ozzzzzzza_ = context.Operators.End(I);
                    int? ozzzzzzzb_ = context.Operators.DurationBetween(nzzzzzzzz_, ozzzzzzza_, "day");
                    int? ozzzzzzzc_ = context.Operators.Add(ozzzzzzzb_, 1);
                    int?[] ozzzzzzzd_ = [
                        ozzzzzzzc_,
                        0,
                    ];
                    int? ozzzzzzze_ = context.Operators.Max<int?>(ozzzzzzzd_ as IEnumerable<int?>);
                    (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? ozzzzzzzf_ = (CqlTupleMetadata_HEjPGjPEhLgQPGjROeWMgiGfC, I, ozzzzzzze_);

                    return ozzzzzzzf_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> nzzzzzzzg_ = context.Operators.Select<CqlInterval<CqlDate>, (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(collapsedIntervals, nzzzzzzzf_);
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> nzzzzzzzh_ = context.Operators.Distinct<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(nzzzzzzzg_);
                object nzzzzzzzi_((CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? @this)
                {
                    int? ozzzzzzzg_ = @this?.days;

                    return ozzzzzzzg_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> nzzzzzzzj_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(nzzzzzzzh_, nzzzzzzzi_, System.ComponentModel.ListSortDirection.Descending);
                (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? nzzzzzzzk_ = context.Operators.First<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(nzzzzzzzj_);
                CqlInterval<CqlDate> nzzzzzzzl_ = nzzzzzzzk_?.interval;
                CqlDate nzzzzzzzm_ = context.Operators.End(nzzzzzzzl_);
                int? nzzzzzzzn_ = context.Operators.DurationBetween(nzzzzzzze_, nzzzzzzzm_, "day");
                int? nzzzzzzzo_ = context.Operators.Add(nzzzzzzzn_, 1);
                int?[] nzzzzzzzp_ = [
                    nzzzzzzzo_,
                    0,
                ];
                int? nzzzzzzzq_ = context.Operators.Max<int?>(nzzzzzzzp_ as IEnumerable<int?>);

                return nzzzzzzzq_;
            }
        };
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? lzzzzzzzo_ = (CqlTupleMetadata_HRbPDRZiOGGBceePOZWjVbXdP, collapsedIntervals, lzzzzzzzk_, lzzzzzzzl_(), lzzzzzzzm_(), lzzzzzzzn_());

        return lzzzzzzzo_;
    }


    [CqlExpressionDefinition("Date Interval Covering Relative to Base Interval Stats")]
    public (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? Date_Interval_Covering_Relative_to_Base_Interval_Stats(CqlContext context, CqlInterval<CqlDate> baseInterval, IEnumerable<CqlInterval<CqlDate>> coveringIntervals)
    {
        IEnumerable<CqlInterval<CqlDate>> ozzzzzzzh_ = this.Date_Interval_Covering_Relative_to_Base_Interval(context, baseInterval, coveringIntervals);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Covering_Intervals)? ozzzzzzzi_ = (CqlTupleMetadata_DUiZjXRKgCPYVZQJbFVDKNMOi, ozzzzzzzh_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Covering_Intervals)?[] ozzzzzzzj_ = [
            ozzzzzzzi_,
        ];
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? ozzzzzzzk_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Covering_Intervals)? variableDeclarations)
        {
            IEnumerable<CqlInterval<CqlDate>> ozzzzzzzo_ = variableDeclarations?.Covering_Intervals;
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? ozzzzzzzp_ = this.Collapsed_Date_Interval_Stats(context, ozzzzzzzo_);

            return ozzzzzzzp_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?> ozzzzzzzl_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Covering_Intervals)?, (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Covering_Intervals)?>)ozzzzzzzj_, ozzzzzzzk_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?> ozzzzzzzm_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>(ozzzzzzzl_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? ozzzzzzzn_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>(ozzzzzzzm_);

        return ozzzzzzzn_;
    }


    [CqlExpressionDefinition("Date Interval Gaps Relative to Base Interval Stats")]
    public (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? Date_Interval_Gaps_Relative_to_Base_Interval_Stats(CqlContext context, CqlInterval<CqlDate> baseInterval, IEnumerable<CqlInterval<CqlDate>> coveringIntervals)
    {
        IEnumerable<CqlInterval<CqlDate>> ozzzzzzzq_ = this.Date_Interval_Gaps_Relative_to_Base_Interval(context, baseInterval, coveringIntervals);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Gap_Intervals)? ozzzzzzzr_ = (CqlTupleMetadata_GQPbYTYABjXFVLRKjXgcDJFSj, ozzzzzzzq_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Gap_Intervals)?[] ozzzzzzzs_ = [
            ozzzzzzzr_,
        ];
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? ozzzzzzzt_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Gap_Intervals)? variableDeclarations)
        {
            IEnumerable<CqlInterval<CqlDate>> ozzzzzzzx_ = variableDeclarations?.Gap_Intervals;
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? ozzzzzzzy_ = this.Collapsed_Date_Interval_Stats(context, ozzzzzzzx_);

            return ozzzzzzzy_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?> ozzzzzzzu_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Gap_Intervals)?, (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Gap_Intervals)?>)ozzzzzzzs_, ozzzzzzzt_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?> ozzzzzzzv_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>(ozzzzzzzu_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? ozzzzzzzw_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>(ozzzzzzzv_);

        return ozzzzzzzw_;
    }


    [CqlExpressionDefinition("DateTime Interval Set Nulls to Zero")]
    public CqlInterval<CqlDateTime> DateTime_Interval_Set_Nulls_to_Zero(CqlContext context, CqlInterval<CqlDateTime> interval)
    {
        CqlDateTime ozzzzzzzz_ = context.Operators.Start(interval);
        int? pzzzzzzza_ = context.Operators.DateTimeComponentFrom(ozzzzzzzz_, "year");
        int? pzzzzzzzb_()
        {
            bool pzzzzzzzv_()
            {
                CqlDateTime pzzzzzzzw_ = context.Operators.Start(interval);
                int? pzzzzzzzx_ = context.Operators.DateTimeComponentFrom(pzzzzzzzw_, "month");

                return pzzzzzzzx_ is null;
            };
            if (pzzzzzzzv_())
            {
                return 0;
            }
            else
            {
                CqlDateTime pzzzzzzzy_ = context.Operators.Start(interval);
                int? pzzzzzzzz_ = context.Operators.DateTimeComponentFrom(pzzzzzzzy_, "month");

                return pzzzzzzzz_;
            }
        };
        int? pzzzzzzzc_()
        {
            bool qzzzzzzza_()
            {
                CqlDateTime qzzzzzzzb_ = context.Operators.Start(interval);
                int? qzzzzzzzc_ = context.Operators.DateTimeComponentFrom(qzzzzzzzb_, "day");

                return qzzzzzzzc_ is null;
            };
            if (qzzzzzzza_())
            {
                return 0;
            }
            else
            {
                CqlDateTime qzzzzzzzd_ = context.Operators.Start(interval);
                int? qzzzzzzze_ = context.Operators.DateTimeComponentFrom(qzzzzzzzd_, "day");

                return qzzzzzzze_;
            }
        };
        int? pzzzzzzzd_()
        {
            bool qzzzzzzzf_()
            {
                CqlDateTime qzzzzzzzg_ = context.Operators.Start(interval);
                int? qzzzzzzzh_ = context.Operators.DateTimeComponentFrom(qzzzzzzzg_, "hour");

                return qzzzzzzzh_ is null;
            };
            if (qzzzzzzzf_())
            {
                return 0;
            }
            else
            {
                CqlDateTime qzzzzzzzi_ = context.Operators.Start(interval);
                int? qzzzzzzzj_ = context.Operators.DateTimeComponentFrom(qzzzzzzzi_, "hour");

                return qzzzzzzzj_;
            }
        };
        int? pzzzzzzze_()
        {
            bool qzzzzzzzk_()
            {
                CqlDateTime qzzzzzzzl_ = context.Operators.Start(interval);
                int? qzzzzzzzm_ = context.Operators.DateTimeComponentFrom(qzzzzzzzl_, "minute");

                return qzzzzzzzm_ is null;
            };
            if (qzzzzzzzk_())
            {
                return 0;
            }
            else
            {
                CqlDateTime qzzzzzzzn_ = context.Operators.Start(interval);
                int? qzzzzzzzo_ = context.Operators.DateTimeComponentFrom(qzzzzzzzn_, "minute");

                return qzzzzzzzo_;
            }
        };
        int? pzzzzzzzf_()
        {
            bool qzzzzzzzp_()
            {
                CqlDateTime qzzzzzzzq_ = context.Operators.Start(interval);
                int? qzzzzzzzr_ = context.Operators.DateTimeComponentFrom(qzzzzzzzq_, "second");

                return qzzzzzzzr_ is null;
            };
            if (qzzzzzzzp_())
            {
                return 0;
            }
            else
            {
                CqlDateTime qzzzzzzzs_ = context.Operators.Start(interval);
                int? qzzzzzzzt_ = context.Operators.DateTimeComponentFrom(qzzzzzzzs_, "second");

                return qzzzzzzzt_;
            }
        };
        int? pzzzzzzzg_()
        {
            bool qzzzzzzzu_()
            {
                CqlDateTime qzzzzzzzv_ = context.Operators.Start(interval);
                int? qzzzzzzzw_ = context.Operators.DateTimeComponentFrom(qzzzzzzzv_, "millisecond");

                return qzzzzzzzw_ is null;
            };
            if (qzzzzzzzu_())
            {
                return 0;
            }
            else
            {
                CqlDateTime qzzzzzzzx_ = context.Operators.Start(interval);
                int? qzzzzzzzy_ = context.Operators.DateTimeComponentFrom(qzzzzzzzx_, "millisecond");

                return qzzzzzzzy_;
            }
        };
        CqlDateTime pzzzzzzzh_ = context.Operators.End(interval);
        int? pzzzzzzzi_ = context.Operators.DateTimeComponentFrom(pzzzzzzzh_, "year");
        int? pzzzzzzzj_()
        {
            bool qzzzzzzzz_()
            {
                CqlDateTime rzzzzzzza_ = context.Operators.End(interval);
                int? rzzzzzzzb_ = context.Operators.DateTimeComponentFrom(rzzzzzzza_, "month");

                return rzzzzzzzb_ is null;
            };
            if (qzzzzzzzz_())
            {
                return 0;
            }
            else
            {
                CqlDateTime rzzzzzzzc_ = context.Operators.End(interval);
                int? rzzzzzzzd_ = context.Operators.DateTimeComponentFrom(rzzzzzzzc_, "month");

                return rzzzzzzzd_;
            }
        };
        int? pzzzzzzzk_()
        {
            bool rzzzzzzze_()
            {
                CqlDateTime rzzzzzzzf_ = context.Operators.End(interval);
                int? rzzzzzzzg_ = context.Operators.DateTimeComponentFrom(rzzzzzzzf_, "day");

                return rzzzzzzzg_ is null;
            };
            if (rzzzzzzze_())
            {
                return 0;
            }
            else
            {
                CqlDateTime rzzzzzzzh_ = context.Operators.End(interval);
                int? rzzzzzzzi_ = context.Operators.DateTimeComponentFrom(rzzzzzzzh_, "day");

                return rzzzzzzzi_;
            }
        };
        int? pzzzzzzzl_()
        {
            bool rzzzzzzzj_()
            {
                CqlDateTime rzzzzzzzk_ = context.Operators.End(interval);
                int? rzzzzzzzl_ = context.Operators.DateTimeComponentFrom(rzzzzzzzk_, "hour");

                return rzzzzzzzl_ is null;
            };
            if (rzzzzzzzj_())
            {
                return 0;
            }
            else
            {
                CqlDateTime rzzzzzzzm_ = context.Operators.End(interval);
                int? rzzzzzzzn_ = context.Operators.DateTimeComponentFrom(rzzzzzzzm_, "hour");

                return rzzzzzzzn_;
            }
        };
        int? pzzzzzzzm_()
        {
            bool rzzzzzzzo_()
            {
                CqlDateTime rzzzzzzzp_ = context.Operators.End(interval);
                int? rzzzzzzzq_ = context.Operators.DateTimeComponentFrom(rzzzzzzzp_, "minute");

                return rzzzzzzzq_ is null;
            };
            if (rzzzzzzzo_())
            {
                return 0;
            }
            else
            {
                CqlDateTime rzzzzzzzr_ = context.Operators.End(interval);
                int? rzzzzzzzs_ = context.Operators.DateTimeComponentFrom(rzzzzzzzr_, "minute");

                return rzzzzzzzs_;
            }
        };
        int? pzzzzzzzn_()
        {
            bool rzzzzzzzt_()
            {
                CqlDateTime rzzzzzzzu_ = context.Operators.End(interval);
                int? rzzzzzzzv_ = context.Operators.DateTimeComponentFrom(rzzzzzzzu_, "second");

                return rzzzzzzzv_ is null;
            };
            if (rzzzzzzzt_())
            {
                return 0;
            }
            else
            {
                CqlDateTime rzzzzzzzw_ = context.Operators.End(interval);
                int? rzzzzzzzx_ = context.Operators.DateTimeComponentFrom(rzzzzzzzw_, "second");

                return rzzzzzzzx_;
            }
        };
        int? pzzzzzzzo_()
        {
            bool rzzzzzzzy_()
            {
                CqlDateTime rzzzzzzzz_ = context.Operators.End(interval);
                int? szzzzzzza_ = context.Operators.DateTimeComponentFrom(rzzzzzzzz_, "millisecond");

                return szzzzzzza_ is null;
            };
            if (rzzzzzzzy_())
            {
                return 0;
            }
            else
            {
                CqlDateTime szzzzzzzb_ = context.Operators.End(interval);
                int? szzzzzzzc_ = context.Operators.DateTimeComponentFrom(szzzzzzzb_, "millisecond");

                return szzzzzzzc_;
            }
        };
        (CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)? pzzzzzzzp_ = (CqlTupleMetadata_FcQREFSfPJSKYAhSEWVJcZVED, pzzzzzzza_, pzzzzzzzb_(), pzzzzzzzc_(), pzzzzzzzd_(), pzzzzzzze_(), pzzzzzzzf_(), pzzzzzzzg_(), pzzzzzzzi_, pzzzzzzzj_(), pzzzzzzzk_(), pzzzzzzzl_(), pzzzzzzzm_(), pzzzzzzzn_(), pzzzzzzzo_());
        (CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)?[] pzzzzzzzq_ = [
            pzzzzzzzp_,
        ];
        CqlInterval<CqlDateTime> pzzzzzzzr_((CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)? i)
        {
            int? szzzzzzzd_ = i?.StartYear;
            int? szzzzzzze_ = i?.StartMonth;
            int? szzzzzzzf_ = i?.StartDay;
            int? szzzzzzzg_ = i?.StartHour;
            int? szzzzzzzh_ = i?.StartMinute;
            int? szzzzzzzi_ = i?.StartSecond;
            int? szzzzzzzj_ = i?.StartMillisecond;
            CqlDateTime szzzzzzzk_ = context.Operators.DateTime(szzzzzzzd_, szzzzzzze_, szzzzzzzf_, szzzzzzzg_, szzzzzzzh_, szzzzzzzi_, szzzzzzzj_, default);
            int? szzzzzzzl_ = i?.EndYear;
            int? szzzzzzzm_ = i?.EndMonth;
            int? szzzzzzzn_ = i?.EndDay;
            int? szzzzzzzo_ = i?.EndHour;
            int? szzzzzzzp_ = i?.EndMinute;
            int? szzzzzzzq_ = i?.EndSecond;
            int? szzzzzzzr_ = i?.EndMillisecond;
            CqlDateTime szzzzzzzs_ = context.Operators.DateTime(szzzzzzzl_, szzzzzzzm_, szzzzzzzn_, szzzzzzzo_, szzzzzzzp_, szzzzzzzq_, szzzzzzzr_, default);
            CqlInterval<CqlDateTime> szzzzzzzt_ = context.Operators.Interval(szzzzzzzk_, szzzzzzzs_, true, true);

            return szzzzzzzt_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> pzzzzzzzs_ = context.Operators.Select<(CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)?, CqlInterval<CqlDateTime>>((IEnumerable<(CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)?>)pzzzzzzzq_, pzzzzzzzr_);
        IEnumerable<CqlInterval<CqlDateTime>> pzzzzzzzt_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(pzzzzzzzs_);
        CqlInterval<CqlDateTime> pzzzzzzzu_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(pzzzzzzzt_);

        return pzzzzzzzu_;
    }


    [CqlExpressionDefinition("Collapsed DateTime Interval Stats")]
    public (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? Collapsed_DateTime_Interval_Stats(CqlContext context, IEnumerable<CqlInterval<CqlDateTime>> collapsedIntervals)
    {
        int? szzzzzzzu_ = context.Operators.Count<CqlInterval<CqlDateTime>>(collapsedIntervals);
        int? szzzzzzzv_()
        {
            bool szzzzzzzz_()
            {
                int? tzzzzzzza_ = context.Operators.Count<CqlInterval<CqlDateTime>>(collapsedIntervals);
                bool? tzzzzzzzb_ = context.Operators.Equal(tzzzzzzza_, 0);

                return tzzzzzzzb_ ?? false;
            };
            if (szzzzzzzz_())
            {
                return 0;
            }
            else
            {
                int? tzzzzzzzc_(CqlInterval<CqlDateTime> I)
                {
                    CqlInterval<CqlDateTime> tzzzzzzzg_ = this.DateTime_Interval_Set_Nulls_to_Zero(context, I);
                    CqlDateTime tzzzzzzzh_ = context.Operators.Start(tzzzzzzzg_);
                    CqlDateTime tzzzzzzzj_ = context.Operators.End(tzzzzzzzg_);
                    int? tzzzzzzzk_ = context.Operators.DurationBetween(tzzzzzzzh_, tzzzzzzzj_, "day");
                    int? tzzzzzzzl_ = context.Operators.Add(tzzzzzzzk_, 1);
                    int?[] tzzzzzzzm_ = [
                        tzzzzzzzl_,
                        0,
                    ];
                    int? tzzzzzzzn_ = context.Operators.Max<int?>(tzzzzzzzm_ as IEnumerable<int?>);

                    return tzzzzzzzn_;
                };
                IEnumerable<int?> tzzzzzzzd_ = context.Operators.Select<CqlInterval<CqlDateTime>, int?>(collapsedIntervals, tzzzzzzzc_);
                IEnumerable<int?> tzzzzzzze_ = context.Operators.Distinct<int?>(tzzzzzzzd_);
                int? tzzzzzzzf_ = context.Operators.Sum(tzzzzzzze_);

                return tzzzzzzzf_;
            }
        };
        CqlInterval<CqlDateTime> szzzzzzzw_()
        {
            bool tzzzzzzzo_()
            {
                int? tzzzzzzzp_ = context.Operators.Count<CqlInterval<CqlDateTime>>(collapsedIntervals);
                bool? tzzzzzzzq_ = context.Operators.Equal(tzzzzzzzp_, 0);

                return tzzzzzzzq_ ?? false;
            };
            if (tzzzzzzzo_())
            {
                return null as CqlInterval<CqlDateTime>;
            }
            else
            {
                (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? tzzzzzzzr_(CqlInterval<CqlDateTime> I)
                {
                    CqlInterval<CqlDateTime> tzzzzzzzy_ = this.DateTime_Interval_Set_Nulls_to_Zero(context, I);
                    CqlDateTime tzzzzzzzz_ = context.Operators.Start(tzzzzzzzy_);
                    CqlDateTime uzzzzzzzb_ = context.Operators.End(tzzzzzzzy_);
                    int? uzzzzzzzc_ = context.Operators.DurationBetween(tzzzzzzzz_, uzzzzzzzb_, "day");
                    int? uzzzzzzzd_ = context.Operators.Add(uzzzzzzzc_, 1);
                    int?[] uzzzzzzze_ = [
                        uzzzzzzzd_,
                        0,
                    ];
                    int? uzzzzzzzf_ = context.Operators.Max<int?>(uzzzzzzze_ as IEnumerable<int?>);
                    (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? uzzzzzzzg_ = (CqlTupleMetadata_CGHEUIgjaCjJVKEADTSZEbdCL, I, uzzzzzzzf_);

                    return uzzzzzzzg_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> tzzzzzzzs_ = context.Operators.Select<CqlInterval<CqlDateTime>, (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(collapsedIntervals, tzzzzzzzr_);
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> tzzzzzzzt_ = context.Operators.Distinct<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(tzzzzzzzs_);
                object tzzzzzzzu_((CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? @this)
                {
                    int? uzzzzzzzh_ = @this?.days;

                    return uzzzzzzzh_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> tzzzzzzzv_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(tzzzzzzzt_, tzzzzzzzu_, System.ComponentModel.ListSortDirection.Descending);
                (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? tzzzzzzzw_ = context.Operators.First<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(tzzzzzzzv_);
                CqlInterval<CqlDateTime> tzzzzzzzx_ = tzzzzzzzw_?.interval;

                return tzzzzzzzx_;
            }
        };
        int? szzzzzzzx_()
        {
            bool uzzzzzzzi_()
            {
                int? uzzzzzzzj_ = context.Operators.Count<CqlInterval<CqlDateTime>>(collapsedIntervals);
                bool? uzzzzzzzk_ = context.Operators.Equal(uzzzzzzzj_, 0);

                return uzzzzzzzk_ ?? false;
            };
            if (uzzzzzzzi_())
            {
                return 0;
            }
            else
            {
                (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? uzzzzzzzl_(CqlInterval<CqlDateTime> I)
                {
                    CqlInterval<CqlDateTime> vzzzzzzzh_ = this.DateTime_Interval_Set_Nulls_to_Zero(context, I);
                    CqlDateTime vzzzzzzzi_ = context.Operators.Start(vzzzzzzzh_);
                    CqlDateTime vzzzzzzzk_ = context.Operators.End(vzzzzzzzh_);
                    int? vzzzzzzzl_ = context.Operators.DurationBetween(vzzzzzzzi_, vzzzzzzzk_, "day");
                    int? vzzzzzzzm_ = context.Operators.Add(vzzzzzzzl_, 1);
                    int?[] vzzzzzzzn_ = [
                        vzzzzzzzm_,
                        0,
                    ];
                    int? vzzzzzzzo_ = context.Operators.Max<int?>(vzzzzzzzn_ as IEnumerable<int?>);
                    (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? vzzzzzzzp_ = (CqlTupleMetadata_CGHEUIgjaCjJVKEADTSZEbdCL, I, vzzzzzzzo_);

                    return vzzzzzzzp_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> uzzzzzzzm_ = context.Operators.Select<CqlInterval<CqlDateTime>, (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(collapsedIntervals, uzzzzzzzl_);
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> uzzzzzzzn_ = context.Operators.Distinct<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(uzzzzzzzm_);
                object uzzzzzzzo_((CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? @this)
                {
                    int? vzzzzzzzq_ = @this?.days;

                    return vzzzzzzzq_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> uzzzzzzzp_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(uzzzzzzzn_, uzzzzzzzo_, System.ComponentModel.ListSortDirection.Descending);
                (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? uzzzzzzzq_ = context.Operators.First<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(uzzzzzzzp_);
                CqlInterval<CqlDateTime> uzzzzzzzr_ = uzzzzzzzq_?.interval;
                CqlInterval<CqlDateTime> uzzzzzzzs_ = this.DateTime_Interval_Set_Nulls_to_Zero(context, uzzzzzzzr_);
                CqlDateTime uzzzzzzzt_ = context.Operators.Start(uzzzzzzzs_);
                (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? uzzzzzzzu_(CqlInterval<CqlDateTime> I)
                {
                    CqlInterval<CqlDateTime> vzzzzzzzr_ = this.DateTime_Interval_Set_Nulls_to_Zero(context, I);
                    CqlDateTime vzzzzzzzs_ = context.Operators.Start(vzzzzzzzr_);
                    CqlDateTime vzzzzzzzu_ = context.Operators.End(vzzzzzzzr_);
                    int? vzzzzzzzv_ = context.Operators.DurationBetween(vzzzzzzzs_, vzzzzzzzu_, "day");
                    int? vzzzzzzzw_ = context.Operators.Add(vzzzzzzzv_, 1);
                    int?[] vzzzzzzzx_ = [
                        vzzzzzzzw_,
                        0,
                    ];
                    int? vzzzzzzzy_ = context.Operators.Max<int?>(vzzzzzzzx_ as IEnumerable<int?>);
                    (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? vzzzzzzzz_ = (CqlTupleMetadata_CGHEUIgjaCjJVKEADTSZEbdCL, I, vzzzzzzzy_);

                    return vzzzzzzzz_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> uzzzzzzzv_ = context.Operators.Select<CqlInterval<CqlDateTime>, (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(collapsedIntervals, uzzzzzzzu_);
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> uzzzzzzzw_ = context.Operators.Distinct<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(uzzzzzzzv_);
                object uzzzzzzzx_((CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? @this)
                {
                    int? wzzzzzzza_ = @this?.days;

                    return wzzzzzzza_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> uzzzzzzzy_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(uzzzzzzzw_, uzzzzzzzx_, System.ComponentModel.ListSortDirection.Descending);
                (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? uzzzzzzzz_ = context.Operators.First<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(uzzzzzzzy_);
                CqlInterval<CqlDateTime> vzzzzzzza_ = uzzzzzzzz_?.interval;
                CqlInterval<CqlDateTime> vzzzzzzzb_ = this.DateTime_Interval_Set_Nulls_to_Zero(context, vzzzzzzza_);
                CqlDateTime vzzzzzzzc_ = context.Operators.End(vzzzzzzzb_);
                int? vzzzzzzzd_ = context.Operators.DurationBetween(uzzzzzzzt_, vzzzzzzzc_, "day");
                int? vzzzzzzze_ = context.Operators.Add(vzzzzzzzd_, 1);
                int?[] vzzzzzzzf_ = [
                    vzzzzzzze_,
                    0,
                ];
                int? vzzzzzzzg_ = context.Operators.Max<int?>(vzzzzzzzf_ as IEnumerable<int?>);

                return vzzzzzzzg_;
            }
        };
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? szzzzzzzy_ = (CqlTupleMetadata_HDihbLieYfQbgeSbOWZBAMUIQ, collapsedIntervals, szzzzzzzu_, szzzzzzzv_(), szzzzzzzw_(), szzzzzzzx_());

        return szzzzzzzy_;
    }


    [CqlExpressionDefinition("DateTime Interval Covering Relative to Base Interval Stats")]
    public (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? DateTime_Interval_Covering_Relative_to_Base_Interval_Stats(CqlContext context, CqlInterval<CqlDateTime> baseInterval, IEnumerable<CqlInterval<CqlDateTime>> coveringIntervals)
    {
        IEnumerable<CqlInterval<CqlDateTime>> wzzzzzzzb_ = this.DateTime_Interval_Covering_Relative_to_Base_Interval(context, baseInterval, coveringIntervals);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Covering_Intervals)? wzzzzzzzc_ = (CqlTupleMetadata_GZMPWdGOJiTNjfWAcbZMePdXV, wzzzzzzzb_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Covering_Intervals)?[] wzzzzzzzd_ = [
            wzzzzzzzc_,
        ];
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? wzzzzzzze_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Covering_Intervals)? variableDeclarations)
        {
            IEnumerable<CqlInterval<CqlDateTime>> wzzzzzzzi_ = variableDeclarations?.Covering_Intervals;
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? wzzzzzzzj_ = this.Collapsed_DateTime_Interval_Stats(context, wzzzzzzzi_);

            return wzzzzzzzj_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?> wzzzzzzzf_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Covering_Intervals)?, (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Covering_Intervals)?>)wzzzzzzzd_, wzzzzzzze_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?> wzzzzzzzg_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?>(wzzzzzzzf_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? wzzzzzzzh_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?>(wzzzzzzzg_);

        return wzzzzzzzh_;
    }


    [CqlExpressionDefinition("DateTime Interval Gaps Relative to Base Interval Stats")]
    public (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? DateTime_Interval_Gaps_Relative_to_Base_Interval_Stats(CqlContext context, CqlInterval<CqlDateTime> baseInterval, IEnumerable<CqlInterval<CqlDateTime>> coveringIntervals)
    {
        IEnumerable<CqlInterval<CqlDateTime>> wzzzzzzzk_ = this.DateTime_Interval_Gaps_Relative_to_Base_Interval(context, baseInterval, coveringIntervals);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Gap_Intervals)? wzzzzzzzl_ = (CqlTupleMetadata_CKbERRbOPGNBBERUOghhaOYSE, wzzzzzzzk_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Gap_Intervals)?[] wzzzzzzzm_ = [
            wzzzzzzzl_,
        ];
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? wzzzzzzzn_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Gap_Intervals)? variableDeclarations)
        {
            IEnumerable<CqlInterval<CqlDateTime>> wzzzzzzzr_ = variableDeclarations?.Gap_Intervals;
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? wzzzzzzzs_ = this.Collapsed_DateTime_Interval_Stats(context, wzzzzzzzr_);

            return wzzzzzzzs_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?> wzzzzzzzo_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Gap_Intervals)?, (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Gap_Intervals)?>)wzzzzzzzm_, wzzzzzzzn_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?> wzzzzzzzp_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?>(wzzzzzzzo_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? wzzzzzzzq_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?>(wzzzzzzzp_);

        return wzzzzzzzq_;
    }


    [CqlExpressionDefinition("Convert To UTC DateTime")]
    public CqlDateTime Convert_To_UTC_DateTime(CqlContext context, CqlDate d)
    {
        int? wzzzzzzzt_ = context.Operators.DateTimeComponentFrom(d, "year");
        int? wzzzzzzzu_()
        {
            if ((context.Operators.DateTimeComponentFrom(d, "month")) is null)
            {
                return 0;
            }
            else
            {
                int? xzzzzzzzc_ = context.Operators.DateTimeComponentFrom(d, "month");

                return xzzzzzzzc_;
            }
        };
        int? wzzzzzzzv_()
        {
            if ((context.Operators.DateTimeComponentFrom(d, "day")) is null)
            {
                return 0;
            }
            else
            {
                int? xzzzzzzzd_ = context.Operators.DateTimeComponentFrom(d, "day");

                return xzzzzzzzd_;
            }
        };
        (CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)? wzzzzzzzw_ = (CqlTupleMetadata_FcQREFSfPJSKYAhSEWVJcZVED, wzzzzzzzt_, wzzzzzzzu_(), wzzzzzzzv_(), default, default, default, default, default, default, default, default, default, default, default);
        (CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)?[] wzzzzzzzx_ = [
            wzzzzzzzw_,
        ];
        CqlDateTime wzzzzzzzy_((CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)? i)
        {
            int? xzzzzzzze_ = i?.StartYear;
            int? xzzzzzzzf_ = i?.StartMonth;
            int? xzzzzzzzg_ = i?.StartDay;
            decimal? xzzzzzzzh_ = context.Operators.ConvertIntegerToDecimal(0);
            CqlDateTime xzzzzzzzi_ = context.Operators.DateTime(xzzzzzzze_, xzzzzzzzf_, xzzzzzzzg_, 0, 0, 0, 0, xzzzzzzzh_);

            return xzzzzzzzi_;
        };
        IEnumerable<CqlDateTime> wzzzzzzzz_ = context.Operators.Select<(CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)?, CqlDateTime>((IEnumerable<(CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)?>)wzzzzzzzx_, wzzzzzzzy_);
        IEnumerable<CqlDateTime> xzzzzzzza_ = context.Operators.Distinct<CqlDateTime>(wzzzzzzzz_);
        CqlDateTime xzzzzzzzb_ = context.Operators.SingletonFrom<CqlDateTime>(xzzzzzzza_);

        return xzzzzzzzb_;
    }


    [CqlExpressionDefinition("Convert Interval Date to UTC Interval DateTime")]
    public CqlInterval<CqlDateTime> Convert_Interval_Date_to_UTC_Interval_DateTime(CqlContext context, CqlInterval<CqlDate> interval)
    {
        CqlDate xzzzzzzzj_ = context.Operators.Start(interval);
        CqlDateTime xzzzzzzzk_ = this.Convert_To_UTC_DateTime(context, xzzzzzzzj_);
        CqlDate xzzzzzzzl_ = context.Operators.End(interval);
        CqlDateTime xzzzzzzzm_ = this.Convert_To_UTC_DateTime(context, xzzzzzzzl_);
        CqlInterval<CqlDateTime> xzzzzzzzn_ = context.Operators.Interval(xzzzzzzzk_, xzzzzzzzm_, true, true);

        return xzzzzzzzn_;
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
