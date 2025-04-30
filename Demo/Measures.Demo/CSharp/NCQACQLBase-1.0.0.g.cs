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
        IEnumerable<CqlInterval<CqlDate>> dzzzzzzzzzzzzd_()
        {
            bool dzzzzzzzzzzzze_()
            {
                int? dzzzzzzzzzzzzf_ = context.Operators.Count<CqlInterval<CqlDate>>(intervals);
                bool? dzzzzzzzzzzzzg_ = context.Operators.Equal(dzzzzzzzzzzzzf_, 0);

                return dzzzzzzzzzzzzg_ ?? false;
            };
            if (intervals is null)
            {
                CqlInterval<CqlDate>[] dzzzzzzzzzzzzh_ = []
;

                return dzzzzzzzzzzzzh_ as IEnumerable<CqlInterval<CqlDate>>;
            }
            else if (dzzzzzzzzzzzze_())
            {
                CqlInterval<CqlDate>[] dzzzzzzzzzzzzi_ = []
;

                return dzzzzzzzzzzzzi_ as IEnumerable<CqlInterval<CqlDate>>;
            }
            else
            {
                (CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)? dzzzzzzzzzzzzj_(CqlInterval<CqlDate> I)
                {
                    CqlDate dzzzzzzzzzzzzr_()
                    {
                        if ((context.Operators.Start(I)) is null)
                        {
                            CqlDate dzzzzzzzzzzzzt_ = context.Operators.MinValue<CqlDate>();

                            return dzzzzzzzzzzzzt_;
                        }
                        else
                        {
                            CqlDate dzzzzzzzzzzzzu_ = context.Operators.Start(I);

                            return dzzzzzzzzzzzzu_;
                        }
                    };
                    (CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)? dzzzzzzzzzzzzs_ = (CqlTupleMetadata_GIMHfXDcFiAjSJBDGYeUeZLhW, I, dzzzzzzzzzzzzr_());

                    return dzzzzzzzzzzzzs_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)?> dzzzzzzzzzzzzk_ = context.Operators.Select<CqlInterval<CqlDate>, (CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)?>(intervals, dzzzzzzzzzzzzj_);
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)?> dzzzzzzzzzzzzl_ = context.Operators.Distinct<(CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)?>(dzzzzzzzzzzzzk_);
                object dzzzzzzzzzzzzm_((CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)? @this)
                {
                    CqlDate dzzzzzzzzzzzzv_ = @this?.startOfInterval;

                    return dzzzzzzzzzzzzv_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)?> dzzzzzzzzzzzzn_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)?>(dzzzzzzzzzzzzl_, dzzzzzzzzzzzzm_, System.ComponentModel.ListSortDirection.Ascending);
                CqlInterval<CqlDate> dzzzzzzzzzzzzo_((CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)? sortedIntervals)
                {
                    CqlInterval<CqlDate> dzzzzzzzzzzzzw_ = sortedIntervals?.interval;

                    return dzzzzzzzzzzzzw_;
                };
                IEnumerable<CqlInterval<CqlDate>> dzzzzzzzzzzzzp_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)?, CqlInterval<CqlDate>>(dzzzzzzzzzzzzn_, dzzzzzzzzzzzzo_);
                IEnumerable<CqlInterval<CqlDate>> dzzzzzzzzzzzzq_ = context.Operators.Distinct<CqlInterval<CqlDate>>(dzzzzzzzzzzzzp_);

                return dzzzzzzzzzzzzq_;
            }
        };

        return dzzzzzzzzzzzzd_();
    }


    [CqlExpressionDefinition("Sort DateTime Intervals")]
    public IEnumerable<CqlInterval<CqlDateTime>> Sort_DateTime_Intervals(CqlContext context, IEnumerable<CqlInterval<CqlDateTime>> intervals)
    {
        IEnumerable<CqlInterval<CqlDateTime>> dzzzzzzzzzzzzx_()
        {
            bool dzzzzzzzzzzzzy_()
            {
                int? dzzzzzzzzzzzzz_ = context.Operators.Count<CqlInterval<CqlDateTime>>(intervals);
                bool? ezzzzzzzzzzzza_ = context.Operators.Equal(dzzzzzzzzzzzzz_, 0);

                return ezzzzzzzzzzzza_ ?? false;
            };
            if (intervals is null)
            {
                CqlInterval<CqlDateTime>[] ezzzzzzzzzzzzb_ = []
;

                return ezzzzzzzzzzzzb_ as IEnumerable<CqlInterval<CqlDateTime>>;
            }
            else if (dzzzzzzzzzzzzy_())
            {
                CqlInterval<CqlDateTime>[] ezzzzzzzzzzzzc_ = []
;

                return ezzzzzzzzzzzzc_ as IEnumerable<CqlInterval<CqlDateTime>>;
            }
            else
            {
                (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)? ezzzzzzzzzzzzd_(CqlInterval<CqlDateTime> I)
                {
                    CqlDateTime ezzzzzzzzzzzzl_()
                    {
                        if ((context.Operators.Start(I)) is null)
                        {
                            CqlDateTime ezzzzzzzzzzzzn_ = context.Operators.MinValue<CqlDateTime>();

                            return ezzzzzzzzzzzzn_;
                        }
                        else
                        {
                            CqlDateTime ezzzzzzzzzzzzo_ = context.Operators.Start(I);

                            return ezzzzzzzzzzzzo_;
                        }
                    };
                    (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)? ezzzzzzzzzzzzm_ = (CqlTupleMetadata_EQHOUSiiWahbJPOUjJGEhIAOV, I, ezzzzzzzzzzzzl_());

                    return ezzzzzzzzzzzzm_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?> ezzzzzzzzzzzze_ = context.Operators.Select<CqlInterval<CqlDateTime>, (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?>(intervals, ezzzzzzzzzzzzd_);
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?> ezzzzzzzzzzzzf_ = context.Operators.Distinct<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?>(ezzzzzzzzzzzze_);
                object ezzzzzzzzzzzzg_((CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)? @this)
                {
                    CqlDateTime ezzzzzzzzzzzzp_ = @this?.startOfInterval;

                    return ezzzzzzzzzzzzp_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?> ezzzzzzzzzzzzh_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?>(ezzzzzzzzzzzzf_, ezzzzzzzzzzzzg_, System.ComponentModel.ListSortDirection.Ascending);
                CqlInterval<CqlDateTime> ezzzzzzzzzzzzi_((CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)? sortedIntervals)
                {
                    CqlInterval<CqlDateTime> ezzzzzzzzzzzzq_ = sortedIntervals?.interval;

                    return ezzzzzzzzzzzzq_;
                };
                IEnumerable<CqlInterval<CqlDateTime>> ezzzzzzzzzzzzj_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?, CqlInterval<CqlDateTime>>(ezzzzzzzzzzzzh_, ezzzzzzzzzzzzi_);
                IEnumerable<CqlInterval<CqlDateTime>> ezzzzzzzzzzzzk_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(ezzzzzzzzzzzzj_);

                return ezzzzzzzzzzzzk_;
            }
        };

        return dzzzzzzzzzzzzx_();
    }


    [CqlExpressionDefinition("Collapse Date Interval Workaround")]
    public IEnumerable<CqlInterval<CqlDate>> Collapse_Date_Interval_Workaround(CqlContext context, IEnumerable<CqlInterval<CqlDate>> intervals)
    {
        IEnumerable<CqlInterval<CqlDate>> ezzzzzzzzzzzzr_()
        {
            bool ezzzzzzzzzzzzs_()
            {
                int? ezzzzzzzzzzzzt_ = context.Operators.Count<CqlInterval<CqlDate>>(intervals);
                bool? ezzzzzzzzzzzzu_ = context.Operators.Equal(ezzzzzzzzzzzzt_, 0);

                return ezzzzzzzzzzzzu_ ?? false;
            };
            if (intervals is null)
            {
                CqlInterval<CqlDate>[] ezzzzzzzzzzzzv_ = []
;

                return ezzzzzzzzzzzzv_ as IEnumerable<CqlInterval<CqlDate>>;
            }
            else if (ezzzzzzzzzzzzs_())
            {
                CqlInterval<CqlDate>[] ezzzzzzzzzzzzw_ = []
;

                return ezzzzzzzzzzzzw_ as IEnumerable<CqlInterval<CqlDate>>;
            }
            else
            {
                bool? ezzzzzzzzzzzzx_(CqlInterval<CqlDate> I)
                {
                    bool? fzzzzzzzzzzzza_(CqlInterval<CqlDate> J)
                    {
                        bool? fzzzzzzzzzzzzf_ = context.Operators.IntervalProperlyIncludesInterval<CqlDate>(J, I, default);

                        return fzzzzzzzzzzzzf_;
                    };
                    IEnumerable<bool?> fzzzzzzzzzzzzb_ = context.Operators.Select<CqlInterval<CqlDate>, bool?>(intervals, fzzzzzzzzzzzza_);
                    IEnumerable<bool?> fzzzzzzzzzzzzc_ = context.Operators.Distinct<bool?>(fzzzzzzzzzzzzb_);
                    bool? fzzzzzzzzzzzzd_ = context.Operators.AnyTrue(fzzzzzzzzzzzzc_);
                    bool? fzzzzzzzzzzzze_ = context.Operators.Not(fzzzzzzzzzzzzd_);

                    return fzzzzzzzzzzzze_;
                };
                IEnumerable<CqlInterval<CqlDate>> ezzzzzzzzzzzzy_ = context.Operators.Where<CqlInterval<CqlDate>>(intervals, ezzzzzzzzzzzzx_);
                IEnumerable<CqlInterval<CqlDate>> ezzzzzzzzzzzzz_ = context.Operators.Collapse(ezzzzzzzzzzzzy_, "day");

                return ezzzzzzzzzzzzz_;
            }
        };

        return ezzzzzzzzzzzzr_();
    }


    [CqlExpressionDefinition("Collapse DateTime Interval Workaround")]
    public IEnumerable<CqlInterval<CqlDateTime>> Collapse_DateTime_Interval_Workaround(CqlContext context, IEnumerable<CqlInterval<CqlDateTime>> intervals)
    {
        IEnumerable<CqlInterval<CqlDateTime>> fzzzzzzzzzzzzg_()
        {
            bool fzzzzzzzzzzzzh_()
            {
                int? fzzzzzzzzzzzzi_ = context.Operators.Count<CqlInterval<CqlDateTime>>(intervals);
                bool? fzzzzzzzzzzzzj_ = context.Operators.Equal(fzzzzzzzzzzzzi_, 0);

                return fzzzzzzzzzzzzj_ ?? false;
            };
            if (intervals is null)
            {
                CqlInterval<CqlDateTime>[] fzzzzzzzzzzzzk_ = []
;

                return fzzzzzzzzzzzzk_ as IEnumerable<CqlInterval<CqlDateTime>>;
            }
            else if (fzzzzzzzzzzzzh_())
            {
                CqlInterval<CqlDateTime>[] fzzzzzzzzzzzzl_ = []
;

                return fzzzzzzzzzzzzl_ as IEnumerable<CqlInterval<CqlDateTime>>;
            }
            else
            {
                bool? fzzzzzzzzzzzzm_(CqlInterval<CqlDateTime> I)
                {
                    bool? fzzzzzzzzzzzzp_(CqlInterval<CqlDateTime> J)
                    {
                        bool? fzzzzzzzzzzzzu_ = context.Operators.IntervalProperlyIncludesInterval<CqlDateTime>(J, I, default);

                        return fzzzzzzzzzzzzu_;
                    };
                    IEnumerable<bool?> fzzzzzzzzzzzzq_ = context.Operators.Select<CqlInterval<CqlDateTime>, bool?>(intervals, fzzzzzzzzzzzzp_);
                    IEnumerable<bool?> fzzzzzzzzzzzzr_ = context.Operators.Distinct<bool?>(fzzzzzzzzzzzzq_);
                    bool? fzzzzzzzzzzzzs_ = context.Operators.AnyTrue(fzzzzzzzzzzzzr_);
                    bool? fzzzzzzzzzzzzt_ = context.Operators.Not(fzzzzzzzzzzzzs_);

                    return fzzzzzzzzzzzzt_;
                };
                IEnumerable<CqlInterval<CqlDateTime>> fzzzzzzzzzzzzn_ = context.Operators.Where<CqlInterval<CqlDateTime>>(intervals, fzzzzzzzzzzzzm_);
                IEnumerable<CqlInterval<CqlDateTime>> fzzzzzzzzzzzzo_ = context.Operators.Collapse(fzzzzzzzzzzzzn_, default);

                return fzzzzzzzzzzzzo_;
            }
        };

        return fzzzzzzzzzzzzg_();
    }


    [CqlExpressionDefinition("Date Interval Covering Relative to Base Interval")]
    public IEnumerable<CqlInterval<CqlDate>> Date_Interval_Covering_Relative_to_Base_Interval(CqlContext context, CqlInterval<CqlDate> baseInterval, IEnumerable<CqlInterval<CqlDate>> coveringIntervals)
    {
        IEnumerable<CqlInterval<CqlDate>> fzzzzzzzzzzzzv_ = this.Sort_Date_Intervals(context, coveringIntervals);
        CqlInterval<CqlDate> fzzzzzzzzzzzzw_(CqlInterval<CqlDate> sortedInterval)
        {
            CqlInterval<CqlDate> gzzzzzzzzzzzza_ = context.Operators.Intersect<CqlDate>(baseInterval, sortedInterval);

            return gzzzzzzzzzzzza_;
        };
        IEnumerable<CqlInterval<CqlDate>> fzzzzzzzzzzzzx_ = context.Operators.Select<CqlInterval<CqlDate>, CqlInterval<CqlDate>>(fzzzzzzzzzzzzv_, fzzzzzzzzzzzzw_);
        IEnumerable<CqlInterval<CqlDate>> fzzzzzzzzzzzzy_ = context.Operators.Distinct<CqlInterval<CqlDate>>(fzzzzzzzzzzzzx_);
        IEnumerable<CqlInterval<CqlDate>> fzzzzzzzzzzzzz_ = this.Collapse_Date_Interval_Workaround(context, fzzzzzzzzzzzzy_);

        return fzzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("DateTime Interval Covering Relative to Base Interval")]
    public IEnumerable<CqlInterval<CqlDateTime>> DateTime_Interval_Covering_Relative_to_Base_Interval(CqlContext context, CqlInterval<CqlDateTime> baseInterval, IEnumerable<CqlInterval<CqlDateTime>> coveringIntervals)
    {
        IEnumerable<CqlInterval<CqlDateTime>> gzzzzzzzzzzzzb_ = this.Sort_DateTime_Intervals(context, coveringIntervals);
        CqlInterval<CqlDateTime> gzzzzzzzzzzzzc_(CqlInterval<CqlDateTime> sortedInterval)
        {
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzg_ = context.Operators.Intersect<CqlDateTime>(baseInterval, sortedInterval);

            return gzzzzzzzzzzzzg_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> gzzzzzzzzzzzzd_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(gzzzzzzzzzzzzb_, gzzzzzzzzzzzzc_);
        IEnumerable<CqlInterval<CqlDateTime>> gzzzzzzzzzzzze_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(gzzzzzzzzzzzzd_);
        IEnumerable<CqlInterval<CqlDateTime>> gzzzzzzzzzzzzf_ = this.Collapse_DateTime_Interval_Workaround(context, gzzzzzzzzzzzze_);

        return gzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Date Interval Gaps Relative to Base Interval")]
    public IEnumerable<CqlInterval<CqlDate>> Date_Interval_Gaps_Relative_to_Base_Interval(CqlContext context, CqlInterval<CqlDate> baseInterval, IEnumerable<CqlInterval<CqlDate>> coveringIntervals)
    {
        IEnumerable<CqlInterval<CqlDate>> gzzzzzzzzzzzzh_ = this.Date_Interval_Covering_Relative_to_Base_Interval(context, baseInterval, coveringIntervals);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> sortedCoverings)? gzzzzzzzzzzzzi_ = (CqlTupleMetadata_EVRLVXPcBiDTIWfCCfKEWDfKI, gzzzzzzzzzzzzh_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> sortedCoverings)?[] gzzzzzzzzzzzzj_ = [
            gzzzzzzzzzzzzi_,
        ];
        IEnumerable<CqlInterval<CqlDate>> gzzzzzzzzzzzzk_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> sortedCoverings)? variableDeclarations)
        {
            IEnumerable<CqlInterval<CqlDate>> gzzzzzzzzzzzzo_()
            {
                bool gzzzzzzzzzzzzw_()
                {
                    IEnumerable<CqlInterval<CqlDate>> gzzzzzzzzzzzzx_ = variableDeclarations?.sortedCoverings;
                    int? gzzzzzzzzzzzzy_ = context.Operators.Count<CqlInterval<CqlDate>>(gzzzzzzzzzzzzx_);
                    bool? gzzzzzzzzzzzzz_ = context.Operators.Equal(gzzzzzzzzzzzzy_, 0);

                    return gzzzzzzzzzzzzz_ ?? false;
                };
                if (gzzzzzzzzzzzzw_())
                {
                    CqlInterval<CqlDate>[] hzzzzzzzzzzzza_ = [
                        baseInterval,
                    ];

                    return hzzzzzzzzzzzza_ as IEnumerable<CqlInterval<CqlDate>>;
                }
                else
                {
                    IEnumerable<CqlInterval<CqlDate>> hzzzzzzzzzzzzb_ = variableDeclarations?.sortedCoverings;
                    CqlInterval<CqlDate> hzzzzzzzzzzzzc_(CqlInterval<CqlDate> sortedCovering)
                    {
                        CqlInterval<CqlDate> hzzzzzzzzzzzzf_()
                        {
                            bool hzzzzzzzzzzzzg_()
                            {
                                IEnumerable<CqlInterval<CqlDate>> hzzzzzzzzzzzzh_ = variableDeclarations?.sortedCoverings;
                                int? hzzzzzzzzzzzzi_ = context.Operators.IndexOf<CqlInterval<CqlDate>>(hzzzzzzzzzzzzh_, sortedCovering);
                                bool? hzzzzzzzzzzzzj_ = context.Operators.Equal(hzzzzzzzzzzzzi_, 0);

                                return hzzzzzzzzzzzzj_ ?? false;
                            };
                            if (hzzzzzzzzzzzzg_())
                            {
                                CqlDate hzzzzzzzzzzzzk_ = context.Operators.Start(baseInterval);
                                CqlDate hzzzzzzzzzzzzl_ = context.Operators.Start(sortedCovering);
                                CqlInterval<CqlDate> hzzzzzzzzzzzzm_ = context.Operators.Interval(hzzzzzzzzzzzzk_, hzzzzzzzzzzzzl_, true, true);
                                CqlInterval<CqlDate> hzzzzzzzzzzzzn_ = context.Operators.Intersect<CqlDate>(hzzzzzzzzzzzzm_, baseInterval);
                                CqlInterval<CqlDate> hzzzzzzzzzzzzo_ = context.Operators.Except(hzzzzzzzzzzzzn_, sortedCovering);

                                return hzzzzzzzzzzzzo_;
                            }
                            else
                            {
                                IEnumerable<CqlInterval<CqlDate>> hzzzzzzzzzzzzp_ = variableDeclarations?.sortedCoverings;
                                int? hzzzzzzzzzzzzr_ = context.Operators.IndexOf<CqlInterval<CqlDate>>(hzzzzzzzzzzzzp_, sortedCovering);
                                int? hzzzzzzzzzzzzs_ = context.Operators.Subtract(hzzzzzzzzzzzzr_, 1);
                                CqlInterval<CqlDate> hzzzzzzzzzzzzt_ = context.Operators.Indexer<CqlInterval<CqlDate>>(hzzzzzzzzzzzzp_, hzzzzzzzzzzzzs_);
                                CqlDate hzzzzzzzzzzzzu_ = context.Operators.Start(hzzzzzzzzzzzzt_);
                                CqlDate hzzzzzzzzzzzzv_ = context.Operators.End(sortedCovering);
                                CqlInterval<CqlDate> hzzzzzzzzzzzzw_ = context.Operators.Interval(hzzzzzzzzzzzzu_, hzzzzzzzzzzzzv_, false, false);
                                int? hzzzzzzzzzzzzz_ = context.Operators.IndexOf<CqlInterval<CqlDate>>(hzzzzzzzzzzzzp_, sortedCovering);
                                int? izzzzzzzzzzzza_ = context.Operators.Subtract(hzzzzzzzzzzzzz_, 1);
                                CqlInterval<CqlDate> izzzzzzzzzzzzb_ = context.Operators.Indexer<CqlInterval<CqlDate>>(hzzzzzzzzzzzzp_, izzzzzzzzzzzza_);
                                CqlInterval<CqlDate> izzzzzzzzzzzzc_ = context.Operators.Except(hzzzzzzzzzzzzw_, izzzzzzzzzzzzb_);
                                CqlInterval<CqlDate> izzzzzzzzzzzzd_ = context.Operators.Except(izzzzzzzzzzzzc_, sortedCovering);

                                return izzzzzzzzzzzzd_;
                            }
                        };

                        return hzzzzzzzzzzzzf_();
                    };
                    IEnumerable<CqlInterval<CqlDate>> hzzzzzzzzzzzzd_ = context.Operators.Select<CqlInterval<CqlDate>, CqlInterval<CqlDate>>(hzzzzzzzzzzzzb_, hzzzzzzzzzzzzc_);
                    IEnumerable<CqlInterval<CqlDate>> hzzzzzzzzzzzze_ = context.Operators.Distinct<CqlInterval<CqlDate>>(hzzzzzzzzzzzzd_);

                    return hzzzzzzzzzzzze_;
                }
            };
            IEnumerable<CqlInterval<CqlDate>> gzzzzzzzzzzzzp_()
            {
                bool izzzzzzzzzzzze_()
                {
                    IEnumerable<CqlInterval<CqlDate>> izzzzzzzzzzzzf_ = variableDeclarations?.sortedCoverings;
                    int? izzzzzzzzzzzzg_ = context.Operators.Count<CqlInterval<CqlDate>>(izzzzzzzzzzzzf_);
                    bool? izzzzzzzzzzzzh_ = context.Operators.Equal(izzzzzzzzzzzzg_, 0);

                    return izzzzzzzzzzzzh_ ?? false;
                };
                if (izzzzzzzzzzzze_())
                {
                    CqlInterval<CqlDate>[] izzzzzzzzzzzzi_ = []
;

                    return izzzzzzzzzzzzi_ as IEnumerable<CqlInterval<CqlDate>>;
                }
                else
                {
                    IEnumerable<CqlInterval<CqlDate>> izzzzzzzzzzzzj_ = variableDeclarations?.sortedCoverings;
                    CqlInterval<CqlDate> izzzzzzzzzzzzk_ = context.Operators.Last<CqlInterval<CqlDate>>(izzzzzzzzzzzzj_);
                    CqlDate izzzzzzzzzzzzl_ = context.Operators.Start(izzzzzzzzzzzzk_);
                    CqlDate izzzzzzzzzzzzm_ = context.Operators.End(baseInterval);
                    CqlInterval<CqlDate> izzzzzzzzzzzzn_ = context.Operators.Interval(izzzzzzzzzzzzl_, izzzzzzzzzzzzm_, false, true);
                    CqlInterval<CqlDate> izzzzzzzzzzzzp_ = context.Operators.Last<CqlInterval<CqlDate>>(izzzzzzzzzzzzj_);
                    CqlInterval<CqlDate> izzzzzzzzzzzzq_ = context.Operators.Except(izzzzzzzzzzzzn_, izzzzzzzzzzzzp_);
                    CqlInterval<CqlDate> izzzzzzzzzzzzr_ = context.Operators.Intersect<CqlDate>(izzzzzzzzzzzzq_, baseInterval);
                    CqlInterval<CqlDate>[] izzzzzzzzzzzzs_ = [
                        izzzzzzzzzzzzr_,
                    ];

                    return izzzzzzzzzzzzs_ as IEnumerable<CqlInterval<CqlDate>>;
                }
            };
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> frontgaps, IEnumerable<CqlInterval<CqlDate>> endgap)? gzzzzzzzzzzzzq_ = (CqlTupleMetadata_FKcLSALRMRfDigEFaJgDOPFRK, gzzzzzzzzzzzzo_(), gzzzzzzzzzzzzp_());
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> frontgaps, IEnumerable<CqlInterval<CqlDate>> endgap)?[] gzzzzzzzzzzzzr_ = [
                gzzzzzzzzzzzzq_,
            ];
            IEnumerable<CqlInterval<CqlDate>> gzzzzzzzzzzzzs_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> frontgaps, IEnumerable<CqlInterval<CqlDate>> endgap)? calculations)
            {
                IEnumerable<CqlInterval<CqlDate>> izzzzzzzzzzzzt_ = calculations?.frontgaps;
                IEnumerable<CqlInterval<CqlDate>> izzzzzzzzzzzzu_ = calculations?.endgap;
                IEnumerable<CqlInterval<CqlDate>> izzzzzzzzzzzzv_ = context.Operators.Union<CqlInterval<CqlDate>>(izzzzzzzzzzzzt_, izzzzzzzzzzzzu_);
                IEnumerable<CqlInterval<CqlDate>> izzzzzzzzzzzzw_ = this.Collapse_Date_Interval_Workaround(context, izzzzzzzzzzzzv_);

                return izzzzzzzzzzzzw_;
            };
            IEnumerable<IEnumerable<CqlInterval<CqlDate>>> gzzzzzzzzzzzzt_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> frontgaps, IEnumerable<CqlInterval<CqlDate>> endgap)?, IEnumerable<CqlInterval<CqlDate>>>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> frontgaps, IEnumerable<CqlInterval<CqlDate>> endgap)?>)gzzzzzzzzzzzzr_, gzzzzzzzzzzzzs_);
            IEnumerable<IEnumerable<CqlInterval<CqlDate>>> gzzzzzzzzzzzzu_ = context.Operators.Distinct<IEnumerable<CqlInterval<CqlDate>>>(gzzzzzzzzzzzzt_);
            IEnumerable<CqlInterval<CqlDate>> gzzzzzzzzzzzzv_ = context.Operators.SingletonFrom<IEnumerable<CqlInterval<CqlDate>>>(gzzzzzzzzzzzzu_);

            return gzzzzzzzzzzzzv_;
        };
        IEnumerable<IEnumerable<CqlInterval<CqlDate>>> gzzzzzzzzzzzzl_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> sortedCoverings)?, IEnumerable<CqlInterval<CqlDate>>>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> sortedCoverings)?>)gzzzzzzzzzzzzj_, gzzzzzzzzzzzzk_);
        IEnumerable<IEnumerable<CqlInterval<CqlDate>>> gzzzzzzzzzzzzm_ = context.Operators.Distinct<IEnumerable<CqlInterval<CqlDate>>>(gzzzzzzzzzzzzl_);
        IEnumerable<CqlInterval<CqlDate>> gzzzzzzzzzzzzn_ = context.Operators.SingletonFrom<IEnumerable<CqlInterval<CqlDate>>>(gzzzzzzzzzzzzm_);

        return gzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("DateTime Interval Gaps Relative to Base Interval")]
    public IEnumerable<CqlInterval<CqlDateTime>> DateTime_Interval_Gaps_Relative_to_Base_Interval(CqlContext context, CqlInterval<CqlDateTime> baseInterval, IEnumerable<CqlInterval<CqlDateTime>> coveringIntervals)
    {
        IEnumerable<CqlInterval<CqlDateTime>> izzzzzzzzzzzzx_ = this.DateTime_Interval_Covering_Relative_to_Base_Interval(context, baseInterval, coveringIntervals);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> sortedCoverings)? izzzzzzzzzzzzy_ = (CqlTupleMetadata_EdgSWaTaCbLYLJceGdIcWOLHd, izzzzzzzzzzzzx_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> sortedCoverings)?[] izzzzzzzzzzzzz_ = [
            izzzzzzzzzzzzy_,
        ];
        IEnumerable<CqlInterval<CqlDateTime>> jzzzzzzzzzzzza_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> sortedCoverings)? variableDeclarations)
        {
            IEnumerable<CqlInterval<CqlDateTime>> jzzzzzzzzzzzze_()
            {
                bool jzzzzzzzzzzzzm_()
                {
                    IEnumerable<CqlInterval<CqlDateTime>> jzzzzzzzzzzzzn_ = variableDeclarations?.sortedCoverings;
                    int? jzzzzzzzzzzzzo_ = context.Operators.Count<CqlInterval<CqlDateTime>>(jzzzzzzzzzzzzn_);
                    bool? jzzzzzzzzzzzzp_ = context.Operators.Equal(jzzzzzzzzzzzzo_, 0);

                    return jzzzzzzzzzzzzp_ ?? false;
                };
                if (jzzzzzzzzzzzzm_())
                {
                    CqlInterval<CqlDateTime>[] jzzzzzzzzzzzzq_ = [
                        baseInterval,
                    ];

                    return jzzzzzzzzzzzzq_ as IEnumerable<CqlInterval<CqlDateTime>>;
                }
                else
                {
                    IEnumerable<CqlInterval<CqlDateTime>> jzzzzzzzzzzzzr_ = variableDeclarations?.sortedCoverings;
                    CqlInterval<CqlDateTime> jzzzzzzzzzzzzs_(CqlInterval<CqlDateTime> sortedCovering)
                    {
                        CqlInterval<CqlDateTime> jzzzzzzzzzzzzv_()
                        {
                            bool jzzzzzzzzzzzzw_()
                            {
                                IEnumerable<CqlInterval<CqlDateTime>> jzzzzzzzzzzzzx_ = variableDeclarations?.sortedCoverings;
                                int? jzzzzzzzzzzzzy_ = context.Operators.IndexOf<CqlInterval<CqlDateTime>>(jzzzzzzzzzzzzx_, sortedCovering);
                                bool? jzzzzzzzzzzzzz_ = context.Operators.Equal(jzzzzzzzzzzzzy_, 0);

                                return jzzzzzzzzzzzzz_ ?? false;
                            };
                            if (jzzzzzzzzzzzzw_())
                            {
                                CqlDateTime kzzzzzzzzzzzza_ = context.Operators.Start(baseInterval);
                                CqlDateTime kzzzzzzzzzzzzb_ = context.Operators.Start(sortedCovering);
                                CqlInterval<CqlDateTime> kzzzzzzzzzzzzc_ = context.Operators.Interval(kzzzzzzzzzzzza_, kzzzzzzzzzzzzb_, true, true);
                                CqlInterval<CqlDateTime> kzzzzzzzzzzzzd_ = context.Operators.Intersect<CqlDateTime>(kzzzzzzzzzzzzc_, baseInterval);
                                CqlInterval<CqlDateTime> kzzzzzzzzzzzze_ = context.Operators.Except(kzzzzzzzzzzzzd_, sortedCovering);

                                return kzzzzzzzzzzzze_;
                            }
                            else
                            {
                                IEnumerable<CqlInterval<CqlDateTime>> kzzzzzzzzzzzzf_ = variableDeclarations?.sortedCoverings;
                                int? kzzzzzzzzzzzzh_ = context.Operators.IndexOf<CqlInterval<CqlDateTime>>(kzzzzzzzzzzzzf_, sortedCovering);
                                int? kzzzzzzzzzzzzi_ = context.Operators.Subtract(kzzzzzzzzzzzzh_, 1);
                                CqlInterval<CqlDateTime> kzzzzzzzzzzzzj_ = context.Operators.Indexer<CqlInterval<CqlDateTime>>(kzzzzzzzzzzzzf_, kzzzzzzzzzzzzi_);
                                CqlDateTime kzzzzzzzzzzzzk_ = context.Operators.Start(kzzzzzzzzzzzzj_);
                                CqlDateTime kzzzzzzzzzzzzl_ = context.Operators.End(sortedCovering);
                                CqlInterval<CqlDateTime> kzzzzzzzzzzzzm_ = context.Operators.Interval(kzzzzzzzzzzzzk_, kzzzzzzzzzzzzl_, false, false);
                                int? kzzzzzzzzzzzzp_ = context.Operators.IndexOf<CqlInterval<CqlDateTime>>(kzzzzzzzzzzzzf_, sortedCovering);
                                int? kzzzzzzzzzzzzq_ = context.Operators.Subtract(kzzzzzzzzzzzzp_, 1);
                                CqlInterval<CqlDateTime> kzzzzzzzzzzzzr_ = context.Operators.Indexer<CqlInterval<CqlDateTime>>(kzzzzzzzzzzzzf_, kzzzzzzzzzzzzq_);
                                CqlInterval<CqlDateTime> kzzzzzzzzzzzzs_ = context.Operators.Except(kzzzzzzzzzzzzm_, kzzzzzzzzzzzzr_);
                                CqlInterval<CqlDateTime> kzzzzzzzzzzzzt_ = context.Operators.Except(kzzzzzzzzzzzzs_, sortedCovering);

                                return kzzzzzzzzzzzzt_;
                            }
                        };

                        return jzzzzzzzzzzzzv_();
                    };
                    IEnumerable<CqlInterval<CqlDateTime>> jzzzzzzzzzzzzt_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(jzzzzzzzzzzzzr_, jzzzzzzzzzzzzs_);
                    IEnumerable<CqlInterval<CqlDateTime>> jzzzzzzzzzzzzu_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(jzzzzzzzzzzzzt_);

                    return jzzzzzzzzzzzzu_;
                }
            };
            IEnumerable<CqlInterval<CqlDateTime>> jzzzzzzzzzzzzf_()
            {
                bool kzzzzzzzzzzzzu_()
                {
                    IEnumerable<CqlInterval<CqlDateTime>> kzzzzzzzzzzzzv_ = variableDeclarations?.sortedCoverings;
                    int? kzzzzzzzzzzzzw_ = context.Operators.Count<CqlInterval<CqlDateTime>>(kzzzzzzzzzzzzv_);
                    bool? kzzzzzzzzzzzzx_ = context.Operators.Equal(kzzzzzzzzzzzzw_, 0);

                    return kzzzzzzzzzzzzx_ ?? false;
                };
                if (kzzzzzzzzzzzzu_())
                {
                    CqlInterval<CqlDateTime>[] kzzzzzzzzzzzzy_ = []
;

                    return kzzzzzzzzzzzzy_ as IEnumerable<CqlInterval<CqlDateTime>>;
                }
                else
                {
                    IEnumerable<CqlInterval<CqlDateTime>> kzzzzzzzzzzzzz_ = variableDeclarations?.sortedCoverings;
                    CqlInterval<CqlDateTime> lzzzzzzzzzzzza_ = context.Operators.Last<CqlInterval<CqlDateTime>>(kzzzzzzzzzzzzz_);
                    CqlDateTime lzzzzzzzzzzzzb_ = context.Operators.Start(lzzzzzzzzzzzza_);
                    CqlDateTime lzzzzzzzzzzzzc_ = context.Operators.End(baseInterval);
                    CqlInterval<CqlDateTime> lzzzzzzzzzzzzd_ = context.Operators.Interval(lzzzzzzzzzzzzb_, lzzzzzzzzzzzzc_, false, true);
                    CqlInterval<CqlDateTime> lzzzzzzzzzzzzf_ = context.Operators.Last<CqlInterval<CqlDateTime>>(kzzzzzzzzzzzzz_);
                    CqlInterval<CqlDateTime> lzzzzzzzzzzzzg_ = context.Operators.Except(lzzzzzzzzzzzzd_, lzzzzzzzzzzzzf_);
                    CqlInterval<CqlDateTime> lzzzzzzzzzzzzh_ = context.Operators.Intersect<CqlDateTime>(lzzzzzzzzzzzzg_, baseInterval);
                    CqlInterval<CqlDateTime>[] lzzzzzzzzzzzzi_ = [
                        lzzzzzzzzzzzzh_,
                    ];

                    return lzzzzzzzzzzzzi_ as IEnumerable<CqlInterval<CqlDateTime>>;
                }
            };
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> frontgaps, IEnumerable<CqlInterval<CqlDateTime>> endgap)? jzzzzzzzzzzzzg_ = (CqlTupleMetadata_BBLSSiNBQBGUDJaVjMDZMSAXg, jzzzzzzzzzzzze_(), jzzzzzzzzzzzzf_());
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> frontgaps, IEnumerable<CqlInterval<CqlDateTime>> endgap)?[] jzzzzzzzzzzzzh_ = [
                jzzzzzzzzzzzzg_,
            ];
            IEnumerable<CqlInterval<CqlDateTime>> jzzzzzzzzzzzzi_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> frontgaps, IEnumerable<CqlInterval<CqlDateTime>> endgap)? calculations)
            {
                IEnumerable<CqlInterval<CqlDateTime>> lzzzzzzzzzzzzj_ = calculations?.frontgaps;
                IEnumerable<CqlInterval<CqlDateTime>> lzzzzzzzzzzzzk_ = calculations?.endgap;
                IEnumerable<CqlInterval<CqlDateTime>> lzzzzzzzzzzzzl_ = context.Operators.Union<CqlInterval<CqlDateTime>>(lzzzzzzzzzzzzj_, lzzzzzzzzzzzzk_);
                IEnumerable<CqlInterval<CqlDateTime>> lzzzzzzzzzzzzm_ = this.Collapse_DateTime_Interval_Workaround(context, lzzzzzzzzzzzzl_);

                return lzzzzzzzzzzzzm_;
            };
            IEnumerable<IEnumerable<CqlInterval<CqlDateTime>>> jzzzzzzzzzzzzj_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> frontgaps, IEnumerable<CqlInterval<CqlDateTime>> endgap)?, IEnumerable<CqlInterval<CqlDateTime>>>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> frontgaps, IEnumerable<CqlInterval<CqlDateTime>> endgap)?>)jzzzzzzzzzzzzh_, jzzzzzzzzzzzzi_);
            IEnumerable<IEnumerable<CqlInterval<CqlDateTime>>> jzzzzzzzzzzzzk_ = context.Operators.Distinct<IEnumerable<CqlInterval<CqlDateTime>>>(jzzzzzzzzzzzzj_);
            IEnumerable<CqlInterval<CqlDateTime>> jzzzzzzzzzzzzl_ = context.Operators.SingletonFrom<IEnumerable<CqlInterval<CqlDateTime>>>(jzzzzzzzzzzzzk_);

            return jzzzzzzzzzzzzl_;
        };
        IEnumerable<IEnumerable<CqlInterval<CqlDateTime>>> jzzzzzzzzzzzzb_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> sortedCoverings)?, IEnumerable<CqlInterval<CqlDateTime>>>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> sortedCoverings)?>)izzzzzzzzzzzzz_, jzzzzzzzzzzzza_);
        IEnumerable<IEnumerable<CqlInterval<CqlDateTime>>> jzzzzzzzzzzzzc_ = context.Operators.Distinct<IEnumerable<CqlInterval<CqlDateTime>>>(jzzzzzzzzzzzzb_);
        IEnumerable<CqlInterval<CqlDateTime>> jzzzzzzzzzzzzd_ = context.Operators.SingletonFrom<IEnumerable<CqlInterval<CqlDateTime>>>(jzzzzzzzzzzzzc_);

        return jzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Collapsed Date Interval Stats")]
    public (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? Collapsed_Date_Interval_Stats(CqlContext context, IEnumerable<CqlInterval<CqlDate>> collapsedIntervals)
    {
        int? lzzzzzzzzzzzzn_ = context.Operators.Count<CqlInterval<CqlDate>>(collapsedIntervals);
        int? lzzzzzzzzzzzzo_()
        {
            bool lzzzzzzzzzzzzs_()
            {
                int? lzzzzzzzzzzzzt_ = context.Operators.Count<CqlInterval<CqlDate>>(collapsedIntervals);
                bool? lzzzzzzzzzzzzu_ = context.Operators.Equal(lzzzzzzzzzzzzt_, 0);

                return lzzzzzzzzzzzzu_ ?? false;
            };
            if (lzzzzzzzzzzzzs_())
            {
                return 0;
            }
            else
            {
                int? lzzzzzzzzzzzzv_(CqlInterval<CqlDate> I)
                {
                    CqlDate lzzzzzzzzzzzzz_ = context.Operators.Start(I);
                    CqlDate mzzzzzzzzzzzza_ = context.Operators.End(I);
                    int? mzzzzzzzzzzzzb_ = context.Operators.DurationBetween(lzzzzzzzzzzzzz_, mzzzzzzzzzzzza_, "day");
                    int? mzzzzzzzzzzzzc_ = context.Operators.Add(mzzzzzzzzzzzzb_, 1);
                    int?[] mzzzzzzzzzzzzd_ = [
                        mzzzzzzzzzzzzc_,
                        0,
                    ];
                    int? mzzzzzzzzzzzze_ = context.Operators.Max<int?>(mzzzzzzzzzzzzd_ as IEnumerable<int?>);

                    return mzzzzzzzzzzzze_;
                };
                IEnumerable<int?> lzzzzzzzzzzzzw_ = context.Operators.Select<CqlInterval<CqlDate>, int?>(collapsedIntervals, lzzzzzzzzzzzzv_);
                IEnumerable<int?> lzzzzzzzzzzzzx_ = context.Operators.Distinct<int?>(lzzzzzzzzzzzzw_);
                int? lzzzzzzzzzzzzy_ = context.Operators.Sum(lzzzzzzzzzzzzx_);

                return lzzzzzzzzzzzzy_;
            }
        };
        CqlInterval<CqlDate> lzzzzzzzzzzzzp_()
        {
            bool mzzzzzzzzzzzzf_()
            {
                int? mzzzzzzzzzzzzg_ = context.Operators.Count<CqlInterval<CqlDate>>(collapsedIntervals);
                bool? mzzzzzzzzzzzzh_ = context.Operators.Equal(mzzzzzzzzzzzzg_, 0);

                return mzzzzzzzzzzzzh_ ?? false;
            };
            if (mzzzzzzzzzzzzf_())
            {
                return null as CqlInterval<CqlDate>;
            }
            else
            {
                (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? mzzzzzzzzzzzzi_(CqlInterval<CqlDate> I)
                {
                    CqlDate mzzzzzzzzzzzzp_ = context.Operators.Start(I);
                    CqlDate mzzzzzzzzzzzzq_ = context.Operators.End(I);
                    int? mzzzzzzzzzzzzr_ = context.Operators.DurationBetween(mzzzzzzzzzzzzp_, mzzzzzzzzzzzzq_, "day");
                    int? mzzzzzzzzzzzzs_ = context.Operators.Add(mzzzzzzzzzzzzr_, 1);
                    int?[] mzzzzzzzzzzzzt_ = [
                        mzzzzzzzzzzzzs_,
                        0,
                    ];
                    int? mzzzzzzzzzzzzu_ = context.Operators.Max<int?>(mzzzzzzzzzzzzt_ as IEnumerable<int?>);
                    (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? mzzzzzzzzzzzzv_ = (CqlTupleMetadata_HEjPGjPEhLgQPGjROeWMgiGfC, I, mzzzzzzzzzzzzu_);

                    return mzzzzzzzzzzzzv_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> mzzzzzzzzzzzzj_ = context.Operators.Select<CqlInterval<CqlDate>, (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(collapsedIntervals, mzzzzzzzzzzzzi_);
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> mzzzzzzzzzzzzk_ = context.Operators.Distinct<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(mzzzzzzzzzzzzj_);
                object mzzzzzzzzzzzzl_((CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? @this)
                {
                    int? mzzzzzzzzzzzzw_ = @this?.days;

                    return mzzzzzzzzzzzzw_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> mzzzzzzzzzzzzm_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(mzzzzzzzzzzzzk_, mzzzzzzzzzzzzl_, System.ComponentModel.ListSortDirection.Descending);
                (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? mzzzzzzzzzzzzn_ = context.Operators.First<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(mzzzzzzzzzzzzm_);
                CqlInterval<CqlDate> mzzzzzzzzzzzzo_ = mzzzzzzzzzzzzn_?.interval;

                return mzzzzzzzzzzzzo_;
            }
        };
        int? lzzzzzzzzzzzzq_()
        {
            bool mzzzzzzzzzzzzx_()
            {
                int? mzzzzzzzzzzzzy_ = context.Operators.Count<CqlInterval<CqlDate>>(collapsedIntervals);
                bool? mzzzzzzzzzzzzz_ = context.Operators.Equal(mzzzzzzzzzzzzy_, 0);

                return mzzzzzzzzzzzzz_ ?? false;
            };
            if (mzzzzzzzzzzzzx_())
            {
                return 0;
            }
            else
            {
                (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? nzzzzzzzzzzzza_(CqlInterval<CqlDate> I)
                {
                    CqlDate nzzzzzzzzzzzzu_ = context.Operators.Start(I);
                    CqlDate nzzzzzzzzzzzzv_ = context.Operators.End(I);
                    int? nzzzzzzzzzzzzw_ = context.Operators.DurationBetween(nzzzzzzzzzzzzu_, nzzzzzzzzzzzzv_, "day");
                    int? nzzzzzzzzzzzzx_ = context.Operators.Add(nzzzzzzzzzzzzw_, 1);
                    int?[] nzzzzzzzzzzzzy_ = [
                        nzzzzzzzzzzzzx_,
                        0,
                    ];
                    int? nzzzzzzzzzzzzz_ = context.Operators.Max<int?>(nzzzzzzzzzzzzy_ as IEnumerable<int?>);
                    (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? ozzzzzzzzzzzza_ = (CqlTupleMetadata_HEjPGjPEhLgQPGjROeWMgiGfC, I, nzzzzzzzzzzzzz_);

                    return ozzzzzzzzzzzza_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> nzzzzzzzzzzzzb_ = context.Operators.Select<CqlInterval<CqlDate>, (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(collapsedIntervals, nzzzzzzzzzzzza_);
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> nzzzzzzzzzzzzc_ = context.Operators.Distinct<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(nzzzzzzzzzzzzb_);
                object nzzzzzzzzzzzzd_((CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? @this)
                {
                    int? ozzzzzzzzzzzzb_ = @this?.days;

                    return ozzzzzzzzzzzzb_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> nzzzzzzzzzzzze_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(nzzzzzzzzzzzzc_, nzzzzzzzzzzzzd_, System.ComponentModel.ListSortDirection.Descending);
                (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? nzzzzzzzzzzzzf_ = context.Operators.First<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(nzzzzzzzzzzzze_);
                CqlInterval<CqlDate> nzzzzzzzzzzzzg_ = nzzzzzzzzzzzzf_?.interval;
                CqlDate nzzzzzzzzzzzzh_ = context.Operators.Start(nzzzzzzzzzzzzg_);
                (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? nzzzzzzzzzzzzi_(CqlInterval<CqlDate> I)
                {
                    CqlDate ozzzzzzzzzzzzc_ = context.Operators.Start(I);
                    CqlDate ozzzzzzzzzzzzd_ = context.Operators.End(I);
                    int? ozzzzzzzzzzzze_ = context.Operators.DurationBetween(ozzzzzzzzzzzzc_, ozzzzzzzzzzzzd_, "day");
                    int? ozzzzzzzzzzzzf_ = context.Operators.Add(ozzzzzzzzzzzze_, 1);
                    int?[] ozzzzzzzzzzzzg_ = [
                        ozzzzzzzzzzzzf_,
                        0,
                    ];
                    int? ozzzzzzzzzzzzh_ = context.Operators.Max<int?>(ozzzzzzzzzzzzg_ as IEnumerable<int?>);
                    (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? ozzzzzzzzzzzzi_ = (CqlTupleMetadata_HEjPGjPEhLgQPGjROeWMgiGfC, I, ozzzzzzzzzzzzh_);

                    return ozzzzzzzzzzzzi_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> nzzzzzzzzzzzzj_ = context.Operators.Select<CqlInterval<CqlDate>, (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(collapsedIntervals, nzzzzzzzzzzzzi_);
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> nzzzzzzzzzzzzk_ = context.Operators.Distinct<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(nzzzzzzzzzzzzj_);
                object nzzzzzzzzzzzzl_((CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? @this)
                {
                    int? ozzzzzzzzzzzzj_ = @this?.days;

                    return ozzzzzzzzzzzzj_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> nzzzzzzzzzzzzm_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(nzzzzzzzzzzzzk_, nzzzzzzzzzzzzl_, System.ComponentModel.ListSortDirection.Descending);
                (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? nzzzzzzzzzzzzn_ = context.Operators.First<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(nzzzzzzzzzzzzm_);
                CqlInterval<CqlDate> nzzzzzzzzzzzzo_ = nzzzzzzzzzzzzn_?.interval;
                CqlDate nzzzzzzzzzzzzp_ = context.Operators.End(nzzzzzzzzzzzzo_);
                int? nzzzzzzzzzzzzq_ = context.Operators.DurationBetween(nzzzzzzzzzzzzh_, nzzzzzzzzzzzzp_, "day");
                int? nzzzzzzzzzzzzr_ = context.Operators.Add(nzzzzzzzzzzzzq_, 1);
                int?[] nzzzzzzzzzzzzs_ = [
                    nzzzzzzzzzzzzr_,
                    0,
                ];
                int? nzzzzzzzzzzzzt_ = context.Operators.Max<int?>(nzzzzzzzzzzzzs_ as IEnumerable<int?>);

                return nzzzzzzzzzzzzt_;
            }
        };
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? lzzzzzzzzzzzzr_ = (CqlTupleMetadata_HRbPDRZiOGGBceePOZWjVbXdP, collapsedIntervals, lzzzzzzzzzzzzn_, lzzzzzzzzzzzzo_(), lzzzzzzzzzzzzp_(), lzzzzzzzzzzzzq_());

        return lzzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Date Interval Covering Relative to Base Interval Stats")]
    public (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? Date_Interval_Covering_Relative_to_Base_Interval_Stats(CqlContext context, CqlInterval<CqlDate> baseInterval, IEnumerable<CqlInterval<CqlDate>> coveringIntervals)
    {
        IEnumerable<CqlInterval<CqlDate>> ozzzzzzzzzzzzk_ = this.Date_Interval_Covering_Relative_to_Base_Interval(context, baseInterval, coveringIntervals);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Covering_Intervals)? ozzzzzzzzzzzzl_ = (CqlTupleMetadata_DUiZjXRKgCPYVZQJbFVDKNMOi, ozzzzzzzzzzzzk_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Covering_Intervals)?[] ozzzzzzzzzzzzm_ = [
            ozzzzzzzzzzzzl_,
        ];
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? ozzzzzzzzzzzzn_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Covering_Intervals)? variableDeclarations)
        {
            IEnumerable<CqlInterval<CqlDate>> ozzzzzzzzzzzzr_ = variableDeclarations?.Covering_Intervals;
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? ozzzzzzzzzzzzs_ = this.Collapsed_Date_Interval_Stats(context, ozzzzzzzzzzzzr_);

            return ozzzzzzzzzzzzs_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?> ozzzzzzzzzzzzo_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Covering_Intervals)?, (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Covering_Intervals)?>)ozzzzzzzzzzzzm_, ozzzzzzzzzzzzn_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?> ozzzzzzzzzzzzp_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>(ozzzzzzzzzzzzo_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? ozzzzzzzzzzzzq_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>(ozzzzzzzzzzzzp_);

        return ozzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Date Interval Gaps Relative to Base Interval Stats")]
    public (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? Date_Interval_Gaps_Relative_to_Base_Interval_Stats(CqlContext context, CqlInterval<CqlDate> baseInterval, IEnumerable<CqlInterval<CqlDate>> coveringIntervals)
    {
        IEnumerable<CqlInterval<CqlDate>> ozzzzzzzzzzzzt_ = this.Date_Interval_Gaps_Relative_to_Base_Interval(context, baseInterval, coveringIntervals);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Gap_Intervals)? ozzzzzzzzzzzzu_ = (CqlTupleMetadata_GQPbYTYABjXFVLRKjXgcDJFSj, ozzzzzzzzzzzzt_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Gap_Intervals)?[] ozzzzzzzzzzzzv_ = [
            ozzzzzzzzzzzzu_,
        ];
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? ozzzzzzzzzzzzw_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Gap_Intervals)? variableDeclarations)
        {
            IEnumerable<CqlInterval<CqlDate>> pzzzzzzzzzzzza_ = variableDeclarations?.Gap_Intervals;
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? pzzzzzzzzzzzzb_ = this.Collapsed_Date_Interval_Stats(context, pzzzzzzzzzzzza_);

            return pzzzzzzzzzzzzb_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?> ozzzzzzzzzzzzx_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Gap_Intervals)?, (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Gap_Intervals)?>)ozzzzzzzzzzzzv_, ozzzzzzzzzzzzw_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?> ozzzzzzzzzzzzy_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>(ozzzzzzzzzzzzx_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? ozzzzzzzzzzzzz_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>(ozzzzzzzzzzzzy_);

        return ozzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("DateTime Interval Set Nulls to Zero")]
    public CqlInterval<CqlDateTime> DateTime_Interval_Set_Nulls_to_Zero(CqlContext context, CqlInterval<CqlDateTime> interval)
    {
        CqlDateTime pzzzzzzzzzzzzc_ = context.Operators.Start(interval);
        int? pzzzzzzzzzzzzd_ = context.Operators.DateTimeComponentFrom(pzzzzzzzzzzzzc_, "year");
        int? pzzzzzzzzzzzze_()
        {
            bool pzzzzzzzzzzzzy_()
            {
                CqlDateTime pzzzzzzzzzzzzz_ = context.Operators.Start(interval);
                int? qzzzzzzzzzzzza_ = context.Operators.DateTimeComponentFrom(pzzzzzzzzzzzzz_, "month");

                return qzzzzzzzzzzzza_ is null;
            };
            if (pzzzzzzzzzzzzy_())
            {
                return 0;
            }
            else
            {
                CqlDateTime qzzzzzzzzzzzzb_ = context.Operators.Start(interval);
                int? qzzzzzzzzzzzzc_ = context.Operators.DateTimeComponentFrom(qzzzzzzzzzzzzb_, "month");

                return qzzzzzzzzzzzzc_;
            }
        };
        int? pzzzzzzzzzzzzf_()
        {
            bool qzzzzzzzzzzzzd_()
            {
                CqlDateTime qzzzzzzzzzzzze_ = context.Operators.Start(interval);
                int? qzzzzzzzzzzzzf_ = context.Operators.DateTimeComponentFrom(qzzzzzzzzzzzze_, "day");

                return qzzzzzzzzzzzzf_ is null;
            };
            if (qzzzzzzzzzzzzd_())
            {
                return 0;
            }
            else
            {
                CqlDateTime qzzzzzzzzzzzzg_ = context.Operators.Start(interval);
                int? qzzzzzzzzzzzzh_ = context.Operators.DateTimeComponentFrom(qzzzzzzzzzzzzg_, "day");

                return qzzzzzzzzzzzzh_;
            }
        };
        int? pzzzzzzzzzzzzg_()
        {
            bool qzzzzzzzzzzzzi_()
            {
                CqlDateTime qzzzzzzzzzzzzj_ = context.Operators.Start(interval);
                int? qzzzzzzzzzzzzk_ = context.Operators.DateTimeComponentFrom(qzzzzzzzzzzzzj_, "hour");

                return qzzzzzzzzzzzzk_ is null;
            };
            if (qzzzzzzzzzzzzi_())
            {
                return 0;
            }
            else
            {
                CqlDateTime qzzzzzzzzzzzzl_ = context.Operators.Start(interval);
                int? qzzzzzzzzzzzzm_ = context.Operators.DateTimeComponentFrom(qzzzzzzzzzzzzl_, "hour");

                return qzzzzzzzzzzzzm_;
            }
        };
        int? pzzzzzzzzzzzzh_()
        {
            bool qzzzzzzzzzzzzn_()
            {
                CqlDateTime qzzzzzzzzzzzzo_ = context.Operators.Start(interval);
                int? qzzzzzzzzzzzzp_ = context.Operators.DateTimeComponentFrom(qzzzzzzzzzzzzo_, "minute");

                return qzzzzzzzzzzzzp_ is null;
            };
            if (qzzzzzzzzzzzzn_())
            {
                return 0;
            }
            else
            {
                CqlDateTime qzzzzzzzzzzzzq_ = context.Operators.Start(interval);
                int? qzzzzzzzzzzzzr_ = context.Operators.DateTimeComponentFrom(qzzzzzzzzzzzzq_, "minute");

                return qzzzzzzzzzzzzr_;
            }
        };
        int? pzzzzzzzzzzzzi_()
        {
            bool qzzzzzzzzzzzzs_()
            {
                CqlDateTime qzzzzzzzzzzzzt_ = context.Operators.Start(interval);
                int? qzzzzzzzzzzzzu_ = context.Operators.DateTimeComponentFrom(qzzzzzzzzzzzzt_, "second");

                return qzzzzzzzzzzzzu_ is null;
            };
            if (qzzzzzzzzzzzzs_())
            {
                return 0;
            }
            else
            {
                CqlDateTime qzzzzzzzzzzzzv_ = context.Operators.Start(interval);
                int? qzzzzzzzzzzzzw_ = context.Operators.DateTimeComponentFrom(qzzzzzzzzzzzzv_, "second");

                return qzzzzzzzzzzzzw_;
            }
        };
        int? pzzzzzzzzzzzzj_()
        {
            bool qzzzzzzzzzzzzx_()
            {
                CqlDateTime qzzzzzzzzzzzzy_ = context.Operators.Start(interval);
                int? qzzzzzzzzzzzzz_ = context.Operators.DateTimeComponentFrom(qzzzzzzzzzzzzy_, "millisecond");

                return qzzzzzzzzzzzzz_ is null;
            };
            if (qzzzzzzzzzzzzx_())
            {
                return 0;
            }
            else
            {
                CqlDateTime rzzzzzzzzzzzza_ = context.Operators.Start(interval);
                int? rzzzzzzzzzzzzb_ = context.Operators.DateTimeComponentFrom(rzzzzzzzzzzzza_, "millisecond");

                return rzzzzzzzzzzzzb_;
            }
        };
        CqlDateTime pzzzzzzzzzzzzk_ = context.Operators.End(interval);
        int? pzzzzzzzzzzzzl_ = context.Operators.DateTimeComponentFrom(pzzzzzzzzzzzzk_, "year");
        int? pzzzzzzzzzzzzm_()
        {
            bool rzzzzzzzzzzzzc_()
            {
                CqlDateTime rzzzzzzzzzzzzd_ = context.Operators.End(interval);
                int? rzzzzzzzzzzzze_ = context.Operators.DateTimeComponentFrom(rzzzzzzzzzzzzd_, "month");

                return rzzzzzzzzzzzze_ is null;
            };
            if (rzzzzzzzzzzzzc_())
            {
                return 0;
            }
            else
            {
                CqlDateTime rzzzzzzzzzzzzf_ = context.Operators.End(interval);
                int? rzzzzzzzzzzzzg_ = context.Operators.DateTimeComponentFrom(rzzzzzzzzzzzzf_, "month");

                return rzzzzzzzzzzzzg_;
            }
        };
        int? pzzzzzzzzzzzzn_()
        {
            bool rzzzzzzzzzzzzh_()
            {
                CqlDateTime rzzzzzzzzzzzzi_ = context.Operators.End(interval);
                int? rzzzzzzzzzzzzj_ = context.Operators.DateTimeComponentFrom(rzzzzzzzzzzzzi_, "day");

                return rzzzzzzzzzzzzj_ is null;
            };
            if (rzzzzzzzzzzzzh_())
            {
                return 0;
            }
            else
            {
                CqlDateTime rzzzzzzzzzzzzk_ = context.Operators.End(interval);
                int? rzzzzzzzzzzzzl_ = context.Operators.DateTimeComponentFrom(rzzzzzzzzzzzzk_, "day");

                return rzzzzzzzzzzzzl_;
            }
        };
        int? pzzzzzzzzzzzzo_()
        {
            bool rzzzzzzzzzzzzm_()
            {
                CqlDateTime rzzzzzzzzzzzzn_ = context.Operators.End(interval);
                int? rzzzzzzzzzzzzo_ = context.Operators.DateTimeComponentFrom(rzzzzzzzzzzzzn_, "hour");

                return rzzzzzzzzzzzzo_ is null;
            };
            if (rzzzzzzzzzzzzm_())
            {
                return 0;
            }
            else
            {
                CqlDateTime rzzzzzzzzzzzzp_ = context.Operators.End(interval);
                int? rzzzzzzzzzzzzq_ = context.Operators.DateTimeComponentFrom(rzzzzzzzzzzzzp_, "hour");

                return rzzzzzzzzzzzzq_;
            }
        };
        int? pzzzzzzzzzzzzp_()
        {
            bool rzzzzzzzzzzzzr_()
            {
                CqlDateTime rzzzzzzzzzzzzs_ = context.Operators.End(interval);
                int? rzzzzzzzzzzzzt_ = context.Operators.DateTimeComponentFrom(rzzzzzzzzzzzzs_, "minute");

                return rzzzzzzzzzzzzt_ is null;
            };
            if (rzzzzzzzzzzzzr_())
            {
                return 0;
            }
            else
            {
                CqlDateTime rzzzzzzzzzzzzu_ = context.Operators.End(interval);
                int? rzzzzzzzzzzzzv_ = context.Operators.DateTimeComponentFrom(rzzzzzzzzzzzzu_, "minute");

                return rzzzzzzzzzzzzv_;
            }
        };
        int? pzzzzzzzzzzzzq_()
        {
            bool rzzzzzzzzzzzzw_()
            {
                CqlDateTime rzzzzzzzzzzzzx_ = context.Operators.End(interval);
                int? rzzzzzzzzzzzzy_ = context.Operators.DateTimeComponentFrom(rzzzzzzzzzzzzx_, "second");

                return rzzzzzzzzzzzzy_ is null;
            };
            if (rzzzzzzzzzzzzw_())
            {
                return 0;
            }
            else
            {
                CqlDateTime rzzzzzzzzzzzzz_ = context.Operators.End(interval);
                int? szzzzzzzzzzzza_ = context.Operators.DateTimeComponentFrom(rzzzzzzzzzzzzz_, "second");

                return szzzzzzzzzzzza_;
            }
        };
        int? pzzzzzzzzzzzzr_()
        {
            bool szzzzzzzzzzzzb_()
            {
                CqlDateTime szzzzzzzzzzzzc_ = context.Operators.End(interval);
                int? szzzzzzzzzzzzd_ = context.Operators.DateTimeComponentFrom(szzzzzzzzzzzzc_, "millisecond");

                return szzzzzzzzzzzzd_ is null;
            };
            if (szzzzzzzzzzzzb_())
            {
                return 0;
            }
            else
            {
                CqlDateTime szzzzzzzzzzzze_ = context.Operators.End(interval);
                int? szzzzzzzzzzzzf_ = context.Operators.DateTimeComponentFrom(szzzzzzzzzzzze_, "millisecond");

                return szzzzzzzzzzzzf_;
            }
        };
        (CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)? pzzzzzzzzzzzzs_ = (CqlTupleMetadata_FcQREFSfPJSKYAhSEWVJcZVED, pzzzzzzzzzzzzd_, pzzzzzzzzzzzze_(), pzzzzzzzzzzzzf_(), pzzzzzzzzzzzzg_(), pzzzzzzzzzzzzh_(), pzzzzzzzzzzzzi_(), pzzzzzzzzzzzzj_(), pzzzzzzzzzzzzl_, pzzzzzzzzzzzzm_(), pzzzzzzzzzzzzn_(), pzzzzzzzzzzzzo_(), pzzzzzzzzzzzzp_(), pzzzzzzzzzzzzq_(), pzzzzzzzzzzzzr_());
        (CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)?[] pzzzzzzzzzzzzt_ = [
            pzzzzzzzzzzzzs_,
        ];
        CqlInterval<CqlDateTime> pzzzzzzzzzzzzu_((CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)? i)
        {
            int? szzzzzzzzzzzzg_ = i?.StartYear;
            int? szzzzzzzzzzzzh_ = i?.StartMonth;
            int? szzzzzzzzzzzzi_ = i?.StartDay;
            int? szzzzzzzzzzzzj_ = i?.StartHour;
            int? szzzzzzzzzzzzk_ = i?.StartMinute;
            int? szzzzzzzzzzzzl_ = i?.StartSecond;
            int? szzzzzzzzzzzzm_ = i?.StartMillisecond;
            CqlDateTime szzzzzzzzzzzzn_ = context.Operators.DateTime(szzzzzzzzzzzzg_, szzzzzzzzzzzzh_, szzzzzzzzzzzzi_, szzzzzzzzzzzzj_, szzzzzzzzzzzzk_, szzzzzzzzzzzzl_, szzzzzzzzzzzzm_, default);
            int? szzzzzzzzzzzzo_ = i?.EndYear;
            int? szzzzzzzzzzzzp_ = i?.EndMonth;
            int? szzzzzzzzzzzzq_ = i?.EndDay;
            int? szzzzzzzzzzzzr_ = i?.EndHour;
            int? szzzzzzzzzzzzs_ = i?.EndMinute;
            int? szzzzzzzzzzzzt_ = i?.EndSecond;
            int? szzzzzzzzzzzzu_ = i?.EndMillisecond;
            CqlDateTime szzzzzzzzzzzzv_ = context.Operators.DateTime(szzzzzzzzzzzzo_, szzzzzzzzzzzzp_, szzzzzzzzzzzzq_, szzzzzzzzzzzzr_, szzzzzzzzzzzzs_, szzzzzzzzzzzzt_, szzzzzzzzzzzzu_, default);
            CqlInterval<CqlDateTime> szzzzzzzzzzzzw_ = context.Operators.Interval(szzzzzzzzzzzzn_, szzzzzzzzzzzzv_, true, true);

            return szzzzzzzzzzzzw_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> pzzzzzzzzzzzzv_ = context.Operators.Select<(CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)?, CqlInterval<CqlDateTime>>((IEnumerable<(CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)?>)pzzzzzzzzzzzzt_, pzzzzzzzzzzzzu_);
        IEnumerable<CqlInterval<CqlDateTime>> pzzzzzzzzzzzzw_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(pzzzzzzzzzzzzv_);
        CqlInterval<CqlDateTime> pzzzzzzzzzzzzx_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(pzzzzzzzzzzzzw_);

        return pzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Collapsed DateTime Interval Stats")]
    public (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? Collapsed_DateTime_Interval_Stats(CqlContext context, IEnumerable<CqlInterval<CqlDateTime>> collapsedIntervals)
    {
        int? szzzzzzzzzzzzx_ = context.Operators.Count<CqlInterval<CqlDateTime>>(collapsedIntervals);
        int? szzzzzzzzzzzzy_()
        {
            bool tzzzzzzzzzzzzc_()
            {
                int? tzzzzzzzzzzzzd_ = context.Operators.Count<CqlInterval<CqlDateTime>>(collapsedIntervals);
                bool? tzzzzzzzzzzzze_ = context.Operators.Equal(tzzzzzzzzzzzzd_, 0);

                return tzzzzzzzzzzzze_ ?? false;
            };
            if (tzzzzzzzzzzzzc_())
            {
                return 0;
            }
            else
            {
                int? tzzzzzzzzzzzzf_(CqlInterval<CqlDateTime> I)
                {
                    CqlInterval<CqlDateTime> tzzzzzzzzzzzzj_ = this.DateTime_Interval_Set_Nulls_to_Zero(context, I);
                    CqlDateTime tzzzzzzzzzzzzk_ = context.Operators.Start(tzzzzzzzzzzzzj_);
                    CqlDateTime tzzzzzzzzzzzzm_ = context.Operators.End(tzzzzzzzzzzzzj_);
                    int? tzzzzzzzzzzzzn_ = context.Operators.DurationBetween(tzzzzzzzzzzzzk_, tzzzzzzzzzzzzm_, "day");
                    int? tzzzzzzzzzzzzo_ = context.Operators.Add(tzzzzzzzzzzzzn_, 1);
                    int?[] tzzzzzzzzzzzzp_ = [
                        tzzzzzzzzzzzzo_,
                        0,
                    ];
                    int? tzzzzzzzzzzzzq_ = context.Operators.Max<int?>(tzzzzzzzzzzzzp_ as IEnumerable<int?>);

                    return tzzzzzzzzzzzzq_;
                };
                IEnumerable<int?> tzzzzzzzzzzzzg_ = context.Operators.Select<CqlInterval<CqlDateTime>, int?>(collapsedIntervals, tzzzzzzzzzzzzf_);
                IEnumerable<int?> tzzzzzzzzzzzzh_ = context.Operators.Distinct<int?>(tzzzzzzzzzzzzg_);
                int? tzzzzzzzzzzzzi_ = context.Operators.Sum(tzzzzzzzzzzzzh_);

                return tzzzzzzzzzzzzi_;
            }
        };
        CqlInterval<CqlDateTime> szzzzzzzzzzzzz_()
        {
            bool tzzzzzzzzzzzzr_()
            {
                int? tzzzzzzzzzzzzs_ = context.Operators.Count<CqlInterval<CqlDateTime>>(collapsedIntervals);
                bool? tzzzzzzzzzzzzt_ = context.Operators.Equal(tzzzzzzzzzzzzs_, 0);

                return tzzzzzzzzzzzzt_ ?? false;
            };
            if (tzzzzzzzzzzzzr_())
            {
                return null as CqlInterval<CqlDateTime>;
            }
            else
            {
                (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? tzzzzzzzzzzzzu_(CqlInterval<CqlDateTime> I)
                {
                    CqlInterval<CqlDateTime> uzzzzzzzzzzzzb_ = this.DateTime_Interval_Set_Nulls_to_Zero(context, I);
                    CqlDateTime uzzzzzzzzzzzzc_ = context.Operators.Start(uzzzzzzzzzzzzb_);
                    CqlDateTime uzzzzzzzzzzzze_ = context.Operators.End(uzzzzzzzzzzzzb_);
                    int? uzzzzzzzzzzzzf_ = context.Operators.DurationBetween(uzzzzzzzzzzzzc_, uzzzzzzzzzzzze_, "day");
                    int? uzzzzzzzzzzzzg_ = context.Operators.Add(uzzzzzzzzzzzzf_, 1);
                    int?[] uzzzzzzzzzzzzh_ = [
                        uzzzzzzzzzzzzg_,
                        0,
                    ];
                    int? uzzzzzzzzzzzzi_ = context.Operators.Max<int?>(uzzzzzzzzzzzzh_ as IEnumerable<int?>);
                    (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? uzzzzzzzzzzzzj_ = (CqlTupleMetadata_CGHEUIgjaCjJVKEADTSZEbdCL, I, uzzzzzzzzzzzzi_);

                    return uzzzzzzzzzzzzj_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> tzzzzzzzzzzzzv_ = context.Operators.Select<CqlInterval<CqlDateTime>, (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(collapsedIntervals, tzzzzzzzzzzzzu_);
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> tzzzzzzzzzzzzw_ = context.Operators.Distinct<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(tzzzzzzzzzzzzv_);
                object tzzzzzzzzzzzzx_((CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? @this)
                {
                    int? uzzzzzzzzzzzzk_ = @this?.days;

                    return uzzzzzzzzzzzzk_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> tzzzzzzzzzzzzy_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(tzzzzzzzzzzzzw_, tzzzzzzzzzzzzx_, System.ComponentModel.ListSortDirection.Descending);
                (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? tzzzzzzzzzzzzz_ = context.Operators.First<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(tzzzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> uzzzzzzzzzzzza_ = tzzzzzzzzzzzzz_?.interval;

                return uzzzzzzzzzzzza_;
            }
        };
        int? tzzzzzzzzzzzza_()
        {
            bool uzzzzzzzzzzzzl_()
            {
                int? uzzzzzzzzzzzzm_ = context.Operators.Count<CqlInterval<CqlDateTime>>(collapsedIntervals);
                bool? uzzzzzzzzzzzzn_ = context.Operators.Equal(uzzzzzzzzzzzzm_, 0);

                return uzzzzzzzzzzzzn_ ?? false;
            };
            if (uzzzzzzzzzzzzl_())
            {
                return 0;
            }
            else
            {
                (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? uzzzzzzzzzzzzo_(CqlInterval<CqlDateTime> I)
                {
                    CqlInterval<CqlDateTime> vzzzzzzzzzzzzk_ = this.DateTime_Interval_Set_Nulls_to_Zero(context, I);
                    CqlDateTime vzzzzzzzzzzzzl_ = context.Operators.Start(vzzzzzzzzzzzzk_);
                    CqlDateTime vzzzzzzzzzzzzn_ = context.Operators.End(vzzzzzzzzzzzzk_);
                    int? vzzzzzzzzzzzzo_ = context.Operators.DurationBetween(vzzzzzzzzzzzzl_, vzzzzzzzzzzzzn_, "day");
                    int? vzzzzzzzzzzzzp_ = context.Operators.Add(vzzzzzzzzzzzzo_, 1);
                    int?[] vzzzzzzzzzzzzq_ = [
                        vzzzzzzzzzzzzp_,
                        0,
                    ];
                    int? vzzzzzzzzzzzzr_ = context.Operators.Max<int?>(vzzzzzzzzzzzzq_ as IEnumerable<int?>);
                    (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? vzzzzzzzzzzzzs_ = (CqlTupleMetadata_CGHEUIgjaCjJVKEADTSZEbdCL, I, vzzzzzzzzzzzzr_);

                    return vzzzzzzzzzzzzs_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> uzzzzzzzzzzzzp_ = context.Operators.Select<CqlInterval<CqlDateTime>, (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(collapsedIntervals, uzzzzzzzzzzzzo_);
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> uzzzzzzzzzzzzq_ = context.Operators.Distinct<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(uzzzzzzzzzzzzp_);
                object uzzzzzzzzzzzzr_((CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? @this)
                {
                    int? vzzzzzzzzzzzzt_ = @this?.days;

                    return vzzzzzzzzzzzzt_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> uzzzzzzzzzzzzs_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(uzzzzzzzzzzzzq_, uzzzzzzzzzzzzr_, System.ComponentModel.ListSortDirection.Descending);
                (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? uzzzzzzzzzzzzt_ = context.Operators.First<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(uzzzzzzzzzzzzs_);
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzu_ = uzzzzzzzzzzzzt_?.interval;
                CqlInterval<CqlDateTime> uzzzzzzzzzzzzv_ = this.DateTime_Interval_Set_Nulls_to_Zero(context, uzzzzzzzzzzzzu_);
                CqlDateTime uzzzzzzzzzzzzw_ = context.Operators.Start(uzzzzzzzzzzzzv_);
                (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? uzzzzzzzzzzzzx_(CqlInterval<CqlDateTime> I)
                {
                    CqlInterval<CqlDateTime> vzzzzzzzzzzzzu_ = this.DateTime_Interval_Set_Nulls_to_Zero(context, I);
                    CqlDateTime vzzzzzzzzzzzzv_ = context.Operators.Start(vzzzzzzzzzzzzu_);
                    CqlDateTime vzzzzzzzzzzzzx_ = context.Operators.End(vzzzzzzzzzzzzu_);
                    int? vzzzzzzzzzzzzy_ = context.Operators.DurationBetween(vzzzzzzzzzzzzv_, vzzzzzzzzzzzzx_, "day");
                    int? vzzzzzzzzzzzzz_ = context.Operators.Add(vzzzzzzzzzzzzy_, 1);
                    int?[] wzzzzzzzzzzzza_ = [
                        vzzzzzzzzzzzzz_,
                        0,
                    ];
                    int? wzzzzzzzzzzzzb_ = context.Operators.Max<int?>(wzzzzzzzzzzzza_ as IEnumerable<int?>);
                    (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? wzzzzzzzzzzzzc_ = (CqlTupleMetadata_CGHEUIgjaCjJVKEADTSZEbdCL, I, wzzzzzzzzzzzzb_);

                    return wzzzzzzzzzzzzc_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> uzzzzzzzzzzzzy_ = context.Operators.Select<CqlInterval<CqlDateTime>, (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(collapsedIntervals, uzzzzzzzzzzzzx_);
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> uzzzzzzzzzzzzz_ = context.Operators.Distinct<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(uzzzzzzzzzzzzy_);
                object vzzzzzzzzzzzza_((CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? @this)
                {
                    int? wzzzzzzzzzzzzd_ = @this?.days;

                    return wzzzzzzzzzzzzd_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> vzzzzzzzzzzzzb_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(uzzzzzzzzzzzzz_, vzzzzzzzzzzzza_, System.ComponentModel.ListSortDirection.Descending);
                (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? vzzzzzzzzzzzzc_ = context.Operators.First<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(vzzzzzzzzzzzzb_);
                CqlInterval<CqlDateTime> vzzzzzzzzzzzzd_ = vzzzzzzzzzzzzc_?.interval;
                CqlInterval<CqlDateTime> vzzzzzzzzzzzze_ = this.DateTime_Interval_Set_Nulls_to_Zero(context, vzzzzzzzzzzzzd_);
                CqlDateTime vzzzzzzzzzzzzf_ = context.Operators.End(vzzzzzzzzzzzze_);
                int? vzzzzzzzzzzzzg_ = context.Operators.DurationBetween(uzzzzzzzzzzzzw_, vzzzzzzzzzzzzf_, "day");
                int? vzzzzzzzzzzzzh_ = context.Operators.Add(vzzzzzzzzzzzzg_, 1);
                int?[] vzzzzzzzzzzzzi_ = [
                    vzzzzzzzzzzzzh_,
                    0,
                ];
                int? vzzzzzzzzzzzzj_ = context.Operators.Max<int?>(vzzzzzzzzzzzzi_ as IEnumerable<int?>);

                return vzzzzzzzzzzzzj_;
            }
        };
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? tzzzzzzzzzzzzb_ = (CqlTupleMetadata_HDihbLieYfQbgeSbOWZBAMUIQ, collapsedIntervals, szzzzzzzzzzzzx_, szzzzzzzzzzzzy_(), szzzzzzzzzzzzz_(), tzzzzzzzzzzzza_());

        return tzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("DateTime Interval Covering Relative to Base Interval Stats")]
    public (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? DateTime_Interval_Covering_Relative_to_Base_Interval_Stats(CqlContext context, CqlInterval<CqlDateTime> baseInterval, IEnumerable<CqlInterval<CqlDateTime>> coveringIntervals)
    {
        IEnumerable<CqlInterval<CqlDateTime>> wzzzzzzzzzzzze_ = this.DateTime_Interval_Covering_Relative_to_Base_Interval(context, baseInterval, coveringIntervals);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Covering_Intervals)? wzzzzzzzzzzzzf_ = (CqlTupleMetadata_GZMPWdGOJiTNjfWAcbZMePdXV, wzzzzzzzzzzzze_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Covering_Intervals)?[] wzzzzzzzzzzzzg_ = [
            wzzzzzzzzzzzzf_,
        ];
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? wzzzzzzzzzzzzh_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Covering_Intervals)? variableDeclarations)
        {
            IEnumerable<CqlInterval<CqlDateTime>> wzzzzzzzzzzzzl_ = variableDeclarations?.Covering_Intervals;
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? wzzzzzzzzzzzzm_ = this.Collapsed_DateTime_Interval_Stats(context, wzzzzzzzzzzzzl_);

            return wzzzzzzzzzzzzm_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?> wzzzzzzzzzzzzi_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Covering_Intervals)?, (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Covering_Intervals)?>)wzzzzzzzzzzzzg_, wzzzzzzzzzzzzh_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?> wzzzzzzzzzzzzj_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?>(wzzzzzzzzzzzzi_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? wzzzzzzzzzzzzk_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?>(wzzzzzzzzzzzzj_);

        return wzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("DateTime Interval Gaps Relative to Base Interval Stats")]
    public (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? DateTime_Interval_Gaps_Relative_to_Base_Interval_Stats(CqlContext context, CqlInterval<CqlDateTime> baseInterval, IEnumerable<CqlInterval<CqlDateTime>> coveringIntervals)
    {
        IEnumerable<CqlInterval<CqlDateTime>> wzzzzzzzzzzzzn_ = this.DateTime_Interval_Gaps_Relative_to_Base_Interval(context, baseInterval, coveringIntervals);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Gap_Intervals)? wzzzzzzzzzzzzo_ = (CqlTupleMetadata_CKbERRbOPGNBBERUOghhaOYSE, wzzzzzzzzzzzzn_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Gap_Intervals)?[] wzzzzzzzzzzzzp_ = [
            wzzzzzzzzzzzzo_,
        ];
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? wzzzzzzzzzzzzq_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Gap_Intervals)? variableDeclarations)
        {
            IEnumerable<CqlInterval<CqlDateTime>> wzzzzzzzzzzzzu_ = variableDeclarations?.Gap_Intervals;
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? wzzzzzzzzzzzzv_ = this.Collapsed_DateTime_Interval_Stats(context, wzzzzzzzzzzzzu_);

            return wzzzzzzzzzzzzv_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?> wzzzzzzzzzzzzr_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Gap_Intervals)?, (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Gap_Intervals)?>)wzzzzzzzzzzzzp_, wzzzzzzzzzzzzq_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?> wzzzzzzzzzzzzs_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?>(wzzzzzzzzzzzzr_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? wzzzzzzzzzzzzt_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?>(wzzzzzzzzzzzzs_);

        return wzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Convert To UTC DateTime")]
    public CqlDateTime Convert_To_UTC_DateTime(CqlContext context, CqlDate d)
    {
        int? wzzzzzzzzzzzzw_ = context.Operators.DateTimeComponentFrom(d, "year");
        int? wzzzzzzzzzzzzx_()
        {
            if ((context.Operators.DateTimeComponentFrom(d, "month")) is null)
            {
                return 0;
            }
            else
            {
                int? xzzzzzzzzzzzzf_ = context.Operators.DateTimeComponentFrom(d, "month");

                return xzzzzzzzzzzzzf_;
            }
        };
        int? wzzzzzzzzzzzzy_()
        {
            if ((context.Operators.DateTimeComponentFrom(d, "day")) is null)
            {
                return 0;
            }
            else
            {
                int? xzzzzzzzzzzzzg_ = context.Operators.DateTimeComponentFrom(d, "day");

                return xzzzzzzzzzzzzg_;
            }
        };
        (CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)? wzzzzzzzzzzzzz_ = (CqlTupleMetadata_FcQREFSfPJSKYAhSEWVJcZVED, wzzzzzzzzzzzzw_, wzzzzzzzzzzzzx_(), wzzzzzzzzzzzzy_(), default, default, default, default, default, default, default, default, default, default, default);
        (CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)?[] xzzzzzzzzzzzza_ = [
            wzzzzzzzzzzzzz_,
        ];
        CqlDateTime xzzzzzzzzzzzzb_((CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)? i)
        {
            int? xzzzzzzzzzzzzh_ = i?.StartYear;
            int? xzzzzzzzzzzzzi_ = i?.StartMonth;
            int? xzzzzzzzzzzzzj_ = i?.StartDay;
            decimal? xzzzzzzzzzzzzk_ = context.Operators.ConvertIntegerToDecimal(0);
            CqlDateTime xzzzzzzzzzzzzl_ = context.Operators.DateTime(xzzzzzzzzzzzzh_, xzzzzzzzzzzzzi_, xzzzzzzzzzzzzj_, 0, 0, 0, 0, xzzzzzzzzzzzzk_);

            return xzzzzzzzzzzzzl_;
        };
        IEnumerable<CqlDateTime> xzzzzzzzzzzzzc_ = context.Operators.Select<(CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)?, CqlDateTime>((IEnumerable<(CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)?>)xzzzzzzzzzzzza_, xzzzzzzzzzzzzb_);
        IEnumerable<CqlDateTime> xzzzzzzzzzzzzd_ = context.Operators.Distinct<CqlDateTime>(xzzzzzzzzzzzzc_);
        CqlDateTime xzzzzzzzzzzzze_ = context.Operators.SingletonFrom<CqlDateTime>(xzzzzzzzzzzzzd_);

        return xzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Convert Interval Date to UTC Interval DateTime")]
    public CqlInterval<CqlDateTime> Convert_Interval_Date_to_UTC_Interval_DateTime(CqlContext context, CqlInterval<CqlDate> interval)
    {
        CqlDate xzzzzzzzzzzzzm_ = context.Operators.Start(interval);
        CqlDateTime xzzzzzzzzzzzzn_ = this.Convert_To_UTC_DateTime(context, xzzzzzzzzzzzzm_);
        CqlDate xzzzzzzzzzzzzo_ = context.Operators.End(interval);
        CqlDateTime xzzzzzzzzzzzzp_ = this.Convert_To_UTC_DateTime(context, xzzzzzzzzzzzzo_);
        CqlInterval<CqlDateTime> xzzzzzzzzzzzzq_ = context.Operators.Interval(xzzzzzzzzzzzzn_, xzzzzzzzzzzzzp_, true, true);

        return xzzzzzzzzzzzzq_;
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
