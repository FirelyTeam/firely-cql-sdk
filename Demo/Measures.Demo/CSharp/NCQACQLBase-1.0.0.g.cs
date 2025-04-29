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

    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<CqlInterval<CqlDate>> Sort_Date_Intervals(CqlContext context, IEnumerable<CqlInterval<CqlDate>> intervals)
    {
        IEnumerable<CqlInterval<CqlDate>> nzzzzzzzzzy_()
        {
            bool nzzzzzzzzzz_()
            {
                int? ozzzzzzzzza_ = context.Operators.Count<CqlInterval<CqlDate>>(intervals);
                bool? ozzzzzzzzzb_ = context.Operators.Equal(ozzzzzzzzza_, 0);

                return ozzzzzzzzzb_ ?? false;
            };
            if (intervals is null)
            {
                CqlInterval<CqlDate>[] ozzzzzzzzzc_ = []
;

                return ozzzzzzzzzc_ as IEnumerable<CqlInterval<CqlDate>>;
            }
            else if (nzzzzzzzzzz_())
            {
                CqlInterval<CqlDate>[] ozzzzzzzzzd_ = []
;

                return ozzzzzzzzzd_ as IEnumerable<CqlInterval<CqlDate>>;
            }
            else
            {
                (CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)? ozzzzzzzzze_(CqlInterval<CqlDate> I)
                {
                    CqlDate ozzzzzzzzzm_()
                    {
                        if ((context.Operators.Start(I)) is null)
                        {
                            CqlDate ozzzzzzzzzo_ = context.Operators.MinValue<CqlDate>();

                            return ozzzzzzzzzo_;
                        }
                        else
                        {
                            CqlDate ozzzzzzzzzp_ = context.Operators.Start(I);

                            return ozzzzzzzzzp_;
                        }
                    };
                    (CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)? ozzzzzzzzzn_ = (CqlTupleMetadata_GIMHfXDcFiAjSJBDGYeUeZLhW, I, ozzzzzzzzzm_());

                    return ozzzzzzzzzn_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)?> ozzzzzzzzzf_ = context.Operators.Select<CqlInterval<CqlDate>, (CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)?>(intervals, ozzzzzzzzze_);
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)?> ozzzzzzzzzg_ = context.Operators.Distinct<(CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)?>(ozzzzzzzzzf_);
                object ozzzzzzzzzh_((CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)? @this)
                {
                    CqlDate ozzzzzzzzzq_ = @this?.startOfInterval;

                    return ozzzzzzzzzq_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)?> ozzzzzzzzzi_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)?>(ozzzzzzzzzg_, ozzzzzzzzzh_, System.ComponentModel.ListSortDirection.Ascending);
                CqlInterval<CqlDate> ozzzzzzzzzj_((CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)? sortedIntervals)
                {
                    CqlInterval<CqlDate> ozzzzzzzzzr_ = sortedIntervals?.interval;

                    return ozzzzzzzzzr_;
                };
                IEnumerable<CqlInterval<CqlDate>> ozzzzzzzzzk_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> interval, CqlDate startOfInterval)?, CqlInterval<CqlDate>>(ozzzzzzzzzi_, ozzzzzzzzzj_);
                IEnumerable<CqlInterval<CqlDate>> ozzzzzzzzzl_ = context.Operators.Distinct<CqlInterval<CqlDate>>(ozzzzzzzzzk_);

                return ozzzzzzzzzl_;
            }
        };

        return nzzzzzzzzzy_();
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<CqlInterval<CqlDateTime>> Sort_DateTime_Intervals(CqlContext context, IEnumerable<CqlInterval<CqlDateTime>> intervals)
    {
        IEnumerable<CqlInterval<CqlDateTime>> ozzzzzzzzzs_()
        {
            bool ozzzzzzzzzt_()
            {
                int? ozzzzzzzzzu_ = context.Operators.Count<CqlInterval<CqlDateTime>>(intervals);
                bool? ozzzzzzzzzv_ = context.Operators.Equal(ozzzzzzzzzu_, 0);

                return ozzzzzzzzzv_ ?? false;
            };
            if (intervals is null)
            {
                CqlInterval<CqlDateTime>[] ozzzzzzzzzw_ = []
;

                return ozzzzzzzzzw_ as IEnumerable<CqlInterval<CqlDateTime>>;
            }
            else if (ozzzzzzzzzt_())
            {
                CqlInterval<CqlDateTime>[] ozzzzzzzzzx_ = []
;

                return ozzzzzzzzzx_ as IEnumerable<CqlInterval<CqlDateTime>>;
            }
            else
            {
                (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)? ozzzzzzzzzy_(CqlInterval<CqlDateTime> I)
                {
                    CqlDateTime pzzzzzzzzzg_()
                    {
                        if ((context.Operators.Start(I)) is null)
                        {
                            CqlDateTime pzzzzzzzzzi_ = context.Operators.MinValue<CqlDateTime>();

                            return pzzzzzzzzzi_;
                        }
                        else
                        {
                            CqlDateTime pzzzzzzzzzj_ = context.Operators.Start(I);

                            return pzzzzzzzzzj_;
                        }
                    };
                    (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)? pzzzzzzzzzh_ = (CqlTupleMetadata_EQHOUSiiWahbJPOUjJGEhIAOV, I, pzzzzzzzzzg_());

                    return pzzzzzzzzzh_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?> ozzzzzzzzzz_ = context.Operators.Select<CqlInterval<CqlDateTime>, (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?>(intervals, ozzzzzzzzzy_);
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?> pzzzzzzzzza_ = context.Operators.Distinct<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?>(ozzzzzzzzzz_);
                object pzzzzzzzzzb_((CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)? @this)
                {
                    CqlDateTime pzzzzzzzzzk_ = @this?.startOfInterval;

                    return pzzzzzzzzzk_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?> pzzzzzzzzzc_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?>(pzzzzzzzzza_, pzzzzzzzzzb_, System.ComponentModel.ListSortDirection.Ascending);
                CqlInterval<CqlDateTime> pzzzzzzzzzd_((CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)? sortedIntervals)
                {
                    CqlInterval<CqlDateTime> pzzzzzzzzzl_ = sortedIntervals?.interval;

                    return pzzzzzzzzzl_;
                };
                IEnumerable<CqlInterval<CqlDateTime>> pzzzzzzzzze_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, CqlDateTime startOfInterval)?, CqlInterval<CqlDateTime>>(pzzzzzzzzzc_, pzzzzzzzzzd_);
                IEnumerable<CqlInterval<CqlDateTime>> pzzzzzzzzzf_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(pzzzzzzzzze_);

                return pzzzzzzzzzf_;
            }
        };

        return ozzzzzzzzzs_();
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<CqlInterval<CqlDate>> Collapse_Date_Interval_Workaround(CqlContext context, IEnumerable<CqlInterval<CqlDate>> intervals)
    {
        IEnumerable<CqlInterval<CqlDate>> pzzzzzzzzzm_()
        {
            bool pzzzzzzzzzn_()
            {
                int? pzzzzzzzzzo_ = context.Operators.Count<CqlInterval<CqlDate>>(intervals);
                bool? pzzzzzzzzzp_ = context.Operators.Equal(pzzzzzzzzzo_, 0);

                return pzzzzzzzzzp_ ?? false;
            };
            if (intervals is null)
            {
                CqlInterval<CqlDate>[] pzzzzzzzzzq_ = []
;

                return pzzzzzzzzzq_ as IEnumerable<CqlInterval<CqlDate>>;
            }
            else if (pzzzzzzzzzn_())
            {
                CqlInterval<CqlDate>[] pzzzzzzzzzr_ = []
;

                return pzzzzzzzzzr_ as IEnumerable<CqlInterval<CqlDate>>;
            }
            else
            {
                bool? pzzzzzzzzzs_(CqlInterval<CqlDate> I)
                {
                    bool? pzzzzzzzzzv_(CqlInterval<CqlDate> J)
                    {
                        bool? qzzzzzzzzza_ = context.Operators.IntervalProperlyIncludesInterval<CqlDate>(J, I, default);

                        return qzzzzzzzzza_;
                    };
                    IEnumerable<bool?> pzzzzzzzzzw_ = context.Operators.Select<CqlInterval<CqlDate>, bool?>(intervals, pzzzzzzzzzv_);
                    IEnumerable<bool?> pzzzzzzzzzx_ = context.Operators.Distinct<bool?>(pzzzzzzzzzw_);
                    bool? pzzzzzzzzzy_ = context.Operators.AnyTrue(pzzzzzzzzzx_);
                    bool? pzzzzzzzzzz_ = context.Operators.Not(pzzzzzzzzzy_);

                    return pzzzzzzzzzz_;
                };
                IEnumerable<CqlInterval<CqlDate>> pzzzzzzzzzt_ = context.Operators.Where<CqlInterval<CqlDate>>(intervals, pzzzzzzzzzs_);
                IEnumerable<CqlInterval<CqlDate>> pzzzzzzzzzu_ = context.Operators.Collapse(pzzzzzzzzzt_, "day");

                return pzzzzzzzzzu_;
            }
        };

        return pzzzzzzzzzm_();
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<CqlInterval<CqlDateTime>> Collapse_DateTime_Interval_Workaround(CqlContext context, IEnumerable<CqlInterval<CqlDateTime>> intervals)
    {
        IEnumerable<CqlInterval<CqlDateTime>> qzzzzzzzzzb_()
        {
            bool qzzzzzzzzzc_()
            {
                int? qzzzzzzzzzd_ = context.Operators.Count<CqlInterval<CqlDateTime>>(intervals);
                bool? qzzzzzzzzze_ = context.Operators.Equal(qzzzzzzzzzd_, 0);

                return qzzzzzzzzze_ ?? false;
            };
            if (intervals is null)
            {
                CqlInterval<CqlDateTime>[] qzzzzzzzzzf_ = []
;

                return qzzzzzzzzzf_ as IEnumerable<CqlInterval<CqlDateTime>>;
            }
            else if (qzzzzzzzzzc_())
            {
                CqlInterval<CqlDateTime>[] qzzzzzzzzzg_ = []
;

                return qzzzzzzzzzg_ as IEnumerable<CqlInterval<CqlDateTime>>;
            }
            else
            {
                bool? qzzzzzzzzzh_(CqlInterval<CqlDateTime> I)
                {
                    bool? qzzzzzzzzzk_(CqlInterval<CqlDateTime> J)
                    {
                        bool? qzzzzzzzzzp_ = context.Operators.IntervalProperlyIncludesInterval<CqlDateTime>(J, I, default);

                        return qzzzzzzzzzp_;
                    };
                    IEnumerable<bool?> qzzzzzzzzzl_ = context.Operators.Select<CqlInterval<CqlDateTime>, bool?>(intervals, qzzzzzzzzzk_);
                    IEnumerable<bool?> qzzzzzzzzzm_ = context.Operators.Distinct<bool?>(qzzzzzzzzzl_);
                    bool? qzzzzzzzzzn_ = context.Operators.AnyTrue(qzzzzzzzzzm_);
                    bool? qzzzzzzzzzo_ = context.Operators.Not(qzzzzzzzzzn_);

                    return qzzzzzzzzzo_;
                };
                IEnumerable<CqlInterval<CqlDateTime>> qzzzzzzzzzi_ = context.Operators.Where<CqlInterval<CqlDateTime>>(intervals, qzzzzzzzzzh_);
                IEnumerable<CqlInterval<CqlDateTime>> qzzzzzzzzzj_ = context.Operators.Collapse(qzzzzzzzzzi_, default);

                return qzzzzzzzzzj_;
            }
        };

        return qzzzzzzzzzb_();
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<CqlInterval<CqlDate>> Date_Interval_Covering_Relative_to_Base_Interval(CqlContext context, CqlInterval<CqlDate> baseInterval, IEnumerable<CqlInterval<CqlDate>> coveringIntervals)
    {
        IEnumerable<CqlInterval<CqlDate>> qzzzzzzzzzq_ = this.Sort_Date_Intervals(context, coveringIntervals);
        CqlInterval<CqlDate> qzzzzzzzzzr_(CqlInterval<CqlDate> sortedInterval)
        {
            CqlInterval<CqlDate> qzzzzzzzzzv_ = context.Operators.Intersect<CqlDate>(baseInterval, sortedInterval);

            return qzzzzzzzzzv_;
        };
        IEnumerable<CqlInterval<CqlDate>> qzzzzzzzzzs_ = context.Operators.Select<CqlInterval<CqlDate>, CqlInterval<CqlDate>>(qzzzzzzzzzq_, qzzzzzzzzzr_);
        IEnumerable<CqlInterval<CqlDate>> qzzzzzzzzzt_ = context.Operators.Distinct<CqlInterval<CqlDate>>(qzzzzzzzzzs_);
        IEnumerable<CqlInterval<CqlDate>> qzzzzzzzzzu_ = this.Collapse_Date_Interval_Workaround(context, qzzzzzzzzzt_);

        return qzzzzzzzzzu_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<CqlInterval<CqlDateTime>> DateTime_Interval_Covering_Relative_to_Base_Interval(CqlContext context, CqlInterval<CqlDateTime> baseInterval, IEnumerable<CqlInterval<CqlDateTime>> coveringIntervals)
    {
        IEnumerable<CqlInterval<CqlDateTime>> qzzzzzzzzzw_ = this.Sort_DateTime_Intervals(context, coveringIntervals);
        CqlInterval<CqlDateTime> qzzzzzzzzzx_(CqlInterval<CqlDateTime> sortedInterval)
        {
            CqlInterval<CqlDateTime> rzzzzzzzzzb_ = context.Operators.Intersect<CqlDateTime>(baseInterval, sortedInterval);

            return rzzzzzzzzzb_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> qzzzzzzzzzy_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(qzzzzzzzzzw_, qzzzzzzzzzx_);
        IEnumerable<CqlInterval<CqlDateTime>> qzzzzzzzzzz_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(qzzzzzzzzzy_);
        IEnumerable<CqlInterval<CqlDateTime>> rzzzzzzzzza_ = this.Collapse_DateTime_Interval_Workaround(context, qzzzzzzzzzz_);

        return rzzzzzzzzza_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<CqlInterval<CqlDate>> Date_Interval_Gaps_Relative_to_Base_Interval(CqlContext context, CqlInterval<CqlDate> baseInterval, IEnumerable<CqlInterval<CqlDate>> coveringIntervals)
    {
        IEnumerable<CqlInterval<CqlDate>> rzzzzzzzzzc_ = this.Date_Interval_Covering_Relative_to_Base_Interval(context, baseInterval, coveringIntervals);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> sortedCoverings)? rzzzzzzzzzd_ = (CqlTupleMetadata_EVRLVXPcBiDTIWfCCfKEWDfKI, rzzzzzzzzzc_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> sortedCoverings)?[] rzzzzzzzzze_ = [
            rzzzzzzzzzd_,
        ];
        IEnumerable<CqlInterval<CqlDate>> rzzzzzzzzzf_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> sortedCoverings)? variableDeclarations)
        {
            IEnumerable<CqlInterval<CqlDate>> rzzzzzzzzzj_()
            {
                bool rzzzzzzzzzr_()
                {
                    IEnumerable<CqlInterval<CqlDate>> rzzzzzzzzzs_ = variableDeclarations?.sortedCoverings;
                    int? rzzzzzzzzzt_ = context.Operators.Count<CqlInterval<CqlDate>>(rzzzzzzzzzs_);
                    bool? rzzzzzzzzzu_ = context.Operators.Equal(rzzzzzzzzzt_, 0);

                    return rzzzzzzzzzu_ ?? false;
                };
                if (rzzzzzzzzzr_())
                {
                    CqlInterval<CqlDate>[] rzzzzzzzzzv_ = [
                        baseInterval,
                    ];

                    return rzzzzzzzzzv_ as IEnumerable<CqlInterval<CqlDate>>;
                }
                else
                {
                    IEnumerable<CqlInterval<CqlDate>> rzzzzzzzzzw_ = variableDeclarations?.sortedCoverings;
                    CqlInterval<CqlDate> rzzzzzzzzzx_(CqlInterval<CqlDate> sortedCovering)
                    {
                        CqlInterval<CqlDate> szzzzzzzzza_()
                        {
                            bool szzzzzzzzzb_()
                            {
                                IEnumerable<CqlInterval<CqlDate>> szzzzzzzzzc_ = variableDeclarations?.sortedCoverings;
                                int? szzzzzzzzzd_ = context.Operators.IndexOf<CqlInterval<CqlDate>>(szzzzzzzzzc_, sortedCovering);
                                bool? szzzzzzzzze_ = context.Operators.Equal(szzzzzzzzzd_, 0);

                                return szzzzzzzzze_ ?? false;
                            };
                            if (szzzzzzzzzb_())
                            {
                                CqlDate szzzzzzzzzf_ = context.Operators.Start(baseInterval);
                                CqlDate szzzzzzzzzg_ = context.Operators.Start(sortedCovering);
                                CqlInterval<CqlDate> szzzzzzzzzh_ = context.Operators.Interval(szzzzzzzzzf_, szzzzzzzzzg_, true, true);
                                CqlInterval<CqlDate> szzzzzzzzzi_ = context.Operators.Intersect<CqlDate>(szzzzzzzzzh_, baseInterval);
                                CqlInterval<CqlDate> szzzzzzzzzj_ = context.Operators.Except(szzzzzzzzzi_, sortedCovering);

                                return szzzzzzzzzj_;
                            }
                            else
                            {
                                IEnumerable<CqlInterval<CqlDate>> szzzzzzzzzk_ = variableDeclarations?.sortedCoverings;
                                int? szzzzzzzzzm_ = context.Operators.IndexOf<CqlInterval<CqlDate>>(szzzzzzzzzk_, sortedCovering);
                                int? szzzzzzzzzn_ = context.Operators.Subtract(szzzzzzzzzm_, 1);
                                CqlInterval<CqlDate> szzzzzzzzzo_ = context.Operators.Indexer<CqlInterval<CqlDate>>(szzzzzzzzzk_, szzzzzzzzzn_);
                                CqlDate szzzzzzzzzp_ = context.Operators.Start(szzzzzzzzzo_);
                                CqlDate szzzzzzzzzq_ = context.Operators.End(sortedCovering);
                                CqlInterval<CqlDate> szzzzzzzzzr_ = context.Operators.Interval(szzzzzzzzzp_, szzzzzzzzzq_, false, false);
                                int? szzzzzzzzzu_ = context.Operators.IndexOf<CqlInterval<CqlDate>>(szzzzzzzzzk_, sortedCovering);
                                int? szzzzzzzzzv_ = context.Operators.Subtract(szzzzzzzzzu_, 1);
                                CqlInterval<CqlDate> szzzzzzzzzw_ = context.Operators.Indexer<CqlInterval<CqlDate>>(szzzzzzzzzk_, szzzzzzzzzv_);
                                CqlInterval<CqlDate> szzzzzzzzzx_ = context.Operators.Except(szzzzzzzzzr_, szzzzzzzzzw_);
                                CqlInterval<CqlDate> szzzzzzzzzy_ = context.Operators.Except(szzzzzzzzzx_, sortedCovering);

                                return szzzzzzzzzy_;
                            }
                        };

                        return szzzzzzzzza_();
                    };
                    IEnumerable<CqlInterval<CqlDate>> rzzzzzzzzzy_ = context.Operators.Select<CqlInterval<CqlDate>, CqlInterval<CqlDate>>(rzzzzzzzzzw_, rzzzzzzzzzx_);
                    IEnumerable<CqlInterval<CqlDate>> rzzzzzzzzzz_ = context.Operators.Distinct<CqlInterval<CqlDate>>(rzzzzzzzzzy_);

                    return rzzzzzzzzzz_;
                }
            };
            IEnumerable<CqlInterval<CqlDate>> rzzzzzzzzzk_()
            {
                bool szzzzzzzzzz_()
                {
                    IEnumerable<CqlInterval<CqlDate>> tzzzzzzzzza_ = variableDeclarations?.sortedCoverings;
                    int? tzzzzzzzzzb_ = context.Operators.Count<CqlInterval<CqlDate>>(tzzzzzzzzza_);
                    bool? tzzzzzzzzzc_ = context.Operators.Equal(tzzzzzzzzzb_, 0);

                    return tzzzzzzzzzc_ ?? false;
                };
                if (szzzzzzzzzz_())
                {
                    CqlInterval<CqlDate>[] tzzzzzzzzzd_ = []
;

                    return tzzzzzzzzzd_ as IEnumerable<CqlInterval<CqlDate>>;
                }
                else
                {
                    IEnumerable<CqlInterval<CqlDate>> tzzzzzzzzze_ = variableDeclarations?.sortedCoverings;
                    CqlInterval<CqlDate> tzzzzzzzzzf_ = context.Operators.Last<CqlInterval<CqlDate>>(tzzzzzzzzze_);
                    CqlDate tzzzzzzzzzg_ = context.Operators.Start(tzzzzzzzzzf_);
                    CqlDate tzzzzzzzzzh_ = context.Operators.End(baseInterval);
                    CqlInterval<CqlDate> tzzzzzzzzzi_ = context.Operators.Interval(tzzzzzzzzzg_, tzzzzzzzzzh_, false, true);
                    CqlInterval<CqlDate> tzzzzzzzzzk_ = context.Operators.Last<CqlInterval<CqlDate>>(tzzzzzzzzze_);
                    CqlInterval<CqlDate> tzzzzzzzzzl_ = context.Operators.Except(tzzzzzzzzzi_, tzzzzzzzzzk_);
                    CqlInterval<CqlDate> tzzzzzzzzzm_ = context.Operators.Intersect<CqlDate>(tzzzzzzzzzl_, baseInterval);
                    CqlInterval<CqlDate>[] tzzzzzzzzzn_ = [
                        tzzzzzzzzzm_,
                    ];

                    return tzzzzzzzzzn_ as IEnumerable<CqlInterval<CqlDate>>;
                }
            };
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> frontgaps, IEnumerable<CqlInterval<CqlDate>> endgap)? rzzzzzzzzzl_ = (CqlTupleMetadata_FKcLSALRMRfDigEFaJgDOPFRK, rzzzzzzzzzj_(), rzzzzzzzzzk_());
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> frontgaps, IEnumerable<CqlInterval<CqlDate>> endgap)?[] rzzzzzzzzzm_ = [
                rzzzzzzzzzl_,
            ];
            IEnumerable<CqlInterval<CqlDate>> rzzzzzzzzzn_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> frontgaps, IEnumerable<CqlInterval<CqlDate>> endgap)? calculations)
            {
                IEnumerable<CqlInterval<CqlDate>> tzzzzzzzzzo_ = calculations?.frontgaps;
                IEnumerable<CqlInterval<CqlDate>> tzzzzzzzzzp_ = calculations?.endgap;
                IEnumerable<CqlInterval<CqlDate>> tzzzzzzzzzq_ = context.Operators.Union<CqlInterval<CqlDate>>(tzzzzzzzzzo_, tzzzzzzzzzp_);
                IEnumerable<CqlInterval<CqlDate>> tzzzzzzzzzr_ = this.Collapse_Date_Interval_Workaround(context, tzzzzzzzzzq_);

                return tzzzzzzzzzr_;
            };
            IEnumerable<IEnumerable<CqlInterval<CqlDate>>> rzzzzzzzzzo_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> frontgaps, IEnumerable<CqlInterval<CqlDate>> endgap)?, IEnumerable<CqlInterval<CqlDate>>>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> frontgaps, IEnumerable<CqlInterval<CqlDate>> endgap)?>)rzzzzzzzzzm_, rzzzzzzzzzn_);
            IEnumerable<IEnumerable<CqlInterval<CqlDate>>> rzzzzzzzzzp_ = context.Operators.Distinct<IEnumerable<CqlInterval<CqlDate>>>(rzzzzzzzzzo_);
            IEnumerable<CqlInterval<CqlDate>> rzzzzzzzzzq_ = context.Operators.SingletonFrom<IEnumerable<CqlInterval<CqlDate>>>(rzzzzzzzzzp_);

            return rzzzzzzzzzq_;
        };
        IEnumerable<IEnumerable<CqlInterval<CqlDate>>> rzzzzzzzzzg_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> sortedCoverings)?, IEnumerable<CqlInterval<CqlDate>>>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> sortedCoverings)?>)rzzzzzzzzze_, rzzzzzzzzzf_);
        IEnumerable<IEnumerable<CqlInterval<CqlDate>>> rzzzzzzzzzh_ = context.Operators.Distinct<IEnumerable<CqlInterval<CqlDate>>>(rzzzzzzzzzg_);
        IEnumerable<CqlInterval<CqlDate>> rzzzzzzzzzi_ = context.Operators.SingletonFrom<IEnumerable<CqlInterval<CqlDate>>>(rzzzzzzzzzh_);

        return rzzzzzzzzzi_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<CqlInterval<CqlDateTime>> DateTime_Interval_Gaps_Relative_to_Base_Interval(CqlContext context, CqlInterval<CqlDateTime> baseInterval, IEnumerable<CqlInterval<CqlDateTime>> coveringIntervals)
    {
        IEnumerable<CqlInterval<CqlDateTime>> tzzzzzzzzzs_ = this.DateTime_Interval_Covering_Relative_to_Base_Interval(context, baseInterval, coveringIntervals);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> sortedCoverings)? tzzzzzzzzzt_ = (CqlTupleMetadata_EdgSWaTaCbLYLJceGdIcWOLHd, tzzzzzzzzzs_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> sortedCoverings)?[] tzzzzzzzzzu_ = [
            tzzzzzzzzzt_,
        ];
        IEnumerable<CqlInterval<CqlDateTime>> tzzzzzzzzzv_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> sortedCoverings)? variableDeclarations)
        {
            IEnumerable<CqlInterval<CqlDateTime>> tzzzzzzzzzz_()
            {
                bool uzzzzzzzzzh_()
                {
                    IEnumerable<CqlInterval<CqlDateTime>> uzzzzzzzzzi_ = variableDeclarations?.sortedCoverings;
                    int? uzzzzzzzzzj_ = context.Operators.Count<CqlInterval<CqlDateTime>>(uzzzzzzzzzi_);
                    bool? uzzzzzzzzzk_ = context.Operators.Equal(uzzzzzzzzzj_, 0);

                    return uzzzzzzzzzk_ ?? false;
                };
                if (uzzzzzzzzzh_())
                {
                    CqlInterval<CqlDateTime>[] uzzzzzzzzzl_ = [
                        baseInterval,
                    ];

                    return uzzzzzzzzzl_ as IEnumerable<CqlInterval<CqlDateTime>>;
                }
                else
                {
                    IEnumerable<CqlInterval<CqlDateTime>> uzzzzzzzzzm_ = variableDeclarations?.sortedCoverings;
                    CqlInterval<CqlDateTime> uzzzzzzzzzn_(CqlInterval<CqlDateTime> sortedCovering)
                    {
                        CqlInterval<CqlDateTime> uzzzzzzzzzq_()
                        {
                            bool uzzzzzzzzzr_()
                            {
                                IEnumerable<CqlInterval<CqlDateTime>> uzzzzzzzzzs_ = variableDeclarations?.sortedCoverings;
                                int? uzzzzzzzzzt_ = context.Operators.IndexOf<CqlInterval<CqlDateTime>>(uzzzzzzzzzs_, sortedCovering);
                                bool? uzzzzzzzzzu_ = context.Operators.Equal(uzzzzzzzzzt_, 0);

                                return uzzzzzzzzzu_ ?? false;
                            };
                            if (uzzzzzzzzzr_())
                            {
                                CqlDateTime uzzzzzzzzzv_ = context.Operators.Start(baseInterval);
                                CqlDateTime uzzzzzzzzzw_ = context.Operators.Start(sortedCovering);
                                CqlInterval<CqlDateTime> uzzzzzzzzzx_ = context.Operators.Interval(uzzzzzzzzzv_, uzzzzzzzzzw_, true, true);
                                CqlInterval<CqlDateTime> uzzzzzzzzzy_ = context.Operators.Intersect<CqlDateTime>(uzzzzzzzzzx_, baseInterval);
                                CqlInterval<CqlDateTime> uzzzzzzzzzz_ = context.Operators.Except(uzzzzzzzzzy_, sortedCovering);

                                return uzzzzzzzzzz_;
                            }
                            else
                            {
                                IEnumerable<CqlInterval<CqlDateTime>> vzzzzzzzzza_ = variableDeclarations?.sortedCoverings;
                                int? vzzzzzzzzzc_ = context.Operators.IndexOf<CqlInterval<CqlDateTime>>(vzzzzzzzzza_, sortedCovering);
                                int? vzzzzzzzzzd_ = context.Operators.Subtract(vzzzzzzzzzc_, 1);
                                CqlInterval<CqlDateTime> vzzzzzzzzze_ = context.Operators.Indexer<CqlInterval<CqlDateTime>>(vzzzzzzzzza_, vzzzzzzzzzd_);
                                CqlDateTime vzzzzzzzzzf_ = context.Operators.Start(vzzzzzzzzze_);
                                CqlDateTime vzzzzzzzzzg_ = context.Operators.End(sortedCovering);
                                CqlInterval<CqlDateTime> vzzzzzzzzzh_ = context.Operators.Interval(vzzzzzzzzzf_, vzzzzzzzzzg_, false, false);
                                int? vzzzzzzzzzk_ = context.Operators.IndexOf<CqlInterval<CqlDateTime>>(vzzzzzzzzza_, sortedCovering);
                                int? vzzzzzzzzzl_ = context.Operators.Subtract(vzzzzzzzzzk_, 1);
                                CqlInterval<CqlDateTime> vzzzzzzzzzm_ = context.Operators.Indexer<CqlInterval<CqlDateTime>>(vzzzzzzzzza_, vzzzzzzzzzl_);
                                CqlInterval<CqlDateTime> vzzzzzzzzzn_ = context.Operators.Except(vzzzzzzzzzh_, vzzzzzzzzzm_);
                                CqlInterval<CqlDateTime> vzzzzzzzzzo_ = context.Operators.Except(vzzzzzzzzzn_, sortedCovering);

                                return vzzzzzzzzzo_;
                            }
                        };

                        return uzzzzzzzzzq_();
                    };
                    IEnumerable<CqlInterval<CqlDateTime>> uzzzzzzzzzo_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlInterval<CqlDateTime>>(uzzzzzzzzzm_, uzzzzzzzzzn_);
                    IEnumerable<CqlInterval<CqlDateTime>> uzzzzzzzzzp_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(uzzzzzzzzzo_);

                    return uzzzzzzzzzp_;
                }
            };
            IEnumerable<CqlInterval<CqlDateTime>> uzzzzzzzzza_()
            {
                bool vzzzzzzzzzp_()
                {
                    IEnumerable<CqlInterval<CqlDateTime>> vzzzzzzzzzq_ = variableDeclarations?.sortedCoverings;
                    int? vzzzzzzzzzr_ = context.Operators.Count<CqlInterval<CqlDateTime>>(vzzzzzzzzzq_);
                    bool? vzzzzzzzzzs_ = context.Operators.Equal(vzzzzzzzzzr_, 0);

                    return vzzzzzzzzzs_ ?? false;
                };
                if (vzzzzzzzzzp_())
                {
                    CqlInterval<CqlDateTime>[] vzzzzzzzzzt_ = []
;

                    return vzzzzzzzzzt_ as IEnumerable<CqlInterval<CqlDateTime>>;
                }
                else
                {
                    IEnumerable<CqlInterval<CqlDateTime>> vzzzzzzzzzu_ = variableDeclarations?.sortedCoverings;
                    CqlInterval<CqlDateTime> vzzzzzzzzzv_ = context.Operators.Last<CqlInterval<CqlDateTime>>(vzzzzzzzzzu_);
                    CqlDateTime vzzzzzzzzzw_ = context.Operators.Start(vzzzzzzzzzv_);
                    CqlDateTime vzzzzzzzzzx_ = context.Operators.End(baseInterval);
                    CqlInterval<CqlDateTime> vzzzzzzzzzy_ = context.Operators.Interval(vzzzzzzzzzw_, vzzzzzzzzzx_, false, true);
                    CqlInterval<CqlDateTime> wzzzzzzzzza_ = context.Operators.Last<CqlInterval<CqlDateTime>>(vzzzzzzzzzu_);
                    CqlInterval<CqlDateTime> wzzzzzzzzzb_ = context.Operators.Except(vzzzzzzzzzy_, wzzzzzzzzza_);
                    CqlInterval<CqlDateTime> wzzzzzzzzzc_ = context.Operators.Intersect<CqlDateTime>(wzzzzzzzzzb_, baseInterval);
                    CqlInterval<CqlDateTime>[] wzzzzzzzzzd_ = [
                        wzzzzzzzzzc_,
                    ];

                    return wzzzzzzzzzd_ as IEnumerable<CqlInterval<CqlDateTime>>;
                }
            };
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> frontgaps, IEnumerable<CqlInterval<CqlDateTime>> endgap)? uzzzzzzzzzb_ = (CqlTupleMetadata_BBLSSiNBQBGUDJaVjMDZMSAXg, tzzzzzzzzzz_(), uzzzzzzzzza_());
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> frontgaps, IEnumerable<CqlInterval<CqlDateTime>> endgap)?[] uzzzzzzzzzc_ = [
                uzzzzzzzzzb_,
            ];
            IEnumerable<CqlInterval<CqlDateTime>> uzzzzzzzzzd_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> frontgaps, IEnumerable<CqlInterval<CqlDateTime>> endgap)? calculations)
            {
                IEnumerable<CqlInterval<CqlDateTime>> wzzzzzzzzze_ = calculations?.frontgaps;
                IEnumerable<CqlInterval<CqlDateTime>> wzzzzzzzzzf_ = calculations?.endgap;
                IEnumerable<CqlInterval<CqlDateTime>> wzzzzzzzzzg_ = context.Operators.Union<CqlInterval<CqlDateTime>>(wzzzzzzzzze_, wzzzzzzzzzf_);
                IEnumerable<CqlInterval<CqlDateTime>> wzzzzzzzzzh_ = this.Collapse_DateTime_Interval_Workaround(context, wzzzzzzzzzg_);

                return wzzzzzzzzzh_;
            };
            IEnumerable<IEnumerable<CqlInterval<CqlDateTime>>> uzzzzzzzzze_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> frontgaps, IEnumerable<CqlInterval<CqlDateTime>> endgap)?, IEnumerable<CqlInterval<CqlDateTime>>>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> frontgaps, IEnumerable<CqlInterval<CqlDateTime>> endgap)?>)uzzzzzzzzzc_, uzzzzzzzzzd_);
            IEnumerable<IEnumerable<CqlInterval<CqlDateTime>>> uzzzzzzzzzf_ = context.Operators.Distinct<IEnumerable<CqlInterval<CqlDateTime>>>(uzzzzzzzzze_);
            IEnumerable<CqlInterval<CqlDateTime>> uzzzzzzzzzg_ = context.Operators.SingletonFrom<IEnumerable<CqlInterval<CqlDateTime>>>(uzzzzzzzzzf_);

            return uzzzzzzzzzg_;
        };
        IEnumerable<IEnumerable<CqlInterval<CqlDateTime>>> tzzzzzzzzzw_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> sortedCoverings)?, IEnumerable<CqlInterval<CqlDateTime>>>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> sortedCoverings)?>)tzzzzzzzzzu_, tzzzzzzzzzv_);
        IEnumerable<IEnumerable<CqlInterval<CqlDateTime>>> tzzzzzzzzzx_ = context.Operators.Distinct<IEnumerable<CqlInterval<CqlDateTime>>>(tzzzzzzzzzw_);
        IEnumerable<CqlInterval<CqlDateTime>> tzzzzzzzzzy_ = context.Operators.SingletonFrom<IEnumerable<CqlInterval<CqlDateTime>>>(tzzzzzzzzzx_);

        return tzzzzzzzzzy_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? Collapsed_Date_Interval_Stats(CqlContext context, IEnumerable<CqlInterval<CqlDate>> collapsedIntervals)
    {
        int? wzzzzzzzzzi_ = context.Operators.Count<CqlInterval<CqlDate>>(collapsedIntervals);
        int? wzzzzzzzzzj_()
        {
            bool wzzzzzzzzzn_()
            {
                int? wzzzzzzzzzo_ = context.Operators.Count<CqlInterval<CqlDate>>(collapsedIntervals);
                bool? wzzzzzzzzzp_ = context.Operators.Equal(wzzzzzzzzzo_, 0);

                return wzzzzzzzzzp_ ?? false;
            };
            if (wzzzzzzzzzn_())
            {
                return 0;
            }
            else
            {
                int? wzzzzzzzzzq_(CqlInterval<CqlDate> I)
                {
                    CqlDate wzzzzzzzzzu_ = context.Operators.Start(I);
                    CqlDate wzzzzzzzzzv_ = context.Operators.End(I);
                    int? wzzzzzzzzzw_ = context.Operators.DurationBetween(wzzzzzzzzzu_, wzzzzzzzzzv_, "day");
                    int? wzzzzzzzzzx_ = context.Operators.Add(wzzzzzzzzzw_, 1);
                    int?[] wzzzzzzzzzy_ = [
                        wzzzzzzzzzx_,
                        0,
                    ];
                    int? wzzzzzzzzzz_ = context.Operators.Max<int?>(wzzzzzzzzzy_ as IEnumerable<int?>);

                    return wzzzzzzzzzz_;
                };
                IEnumerable<int?> wzzzzzzzzzr_ = context.Operators.Select<CqlInterval<CqlDate>, int?>(collapsedIntervals, wzzzzzzzzzq_);
                IEnumerable<int?> wzzzzzzzzzs_ = context.Operators.Distinct<int?>(wzzzzzzzzzr_);
                int? wzzzzzzzzzt_ = context.Operators.Sum(wzzzzzzzzzs_);

                return wzzzzzzzzzt_;
            }
        };
        CqlInterval<CqlDate> wzzzzzzzzzk_()
        {
            bool xzzzzzzzzza_()
            {
                int? xzzzzzzzzzb_ = context.Operators.Count<CqlInterval<CqlDate>>(collapsedIntervals);
                bool? xzzzzzzzzzc_ = context.Operators.Equal(xzzzzzzzzzb_, 0);

                return xzzzzzzzzzc_ ?? false;
            };
            if (xzzzzzzzzza_())
            {
                return null as CqlInterval<CqlDate>;
            }
            else
            {
                (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? xzzzzzzzzzd_(CqlInterval<CqlDate> I)
                {
                    CqlDate xzzzzzzzzzk_ = context.Operators.Start(I);
                    CqlDate xzzzzzzzzzl_ = context.Operators.End(I);
                    int? xzzzzzzzzzm_ = context.Operators.DurationBetween(xzzzzzzzzzk_, xzzzzzzzzzl_, "day");
                    int? xzzzzzzzzzn_ = context.Operators.Add(xzzzzzzzzzm_, 1);
                    int?[] xzzzzzzzzzo_ = [
                        xzzzzzzzzzn_,
                        0,
                    ];
                    int? xzzzzzzzzzp_ = context.Operators.Max<int?>(xzzzzzzzzzo_ as IEnumerable<int?>);
                    (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? xzzzzzzzzzq_ = (CqlTupleMetadata_HEjPGjPEhLgQPGjROeWMgiGfC, I, xzzzzzzzzzp_);

                    return xzzzzzzzzzq_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> xzzzzzzzzze_ = context.Operators.Select<CqlInterval<CqlDate>, (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(collapsedIntervals, xzzzzzzzzzd_);
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> xzzzzzzzzzf_ = context.Operators.Distinct<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(xzzzzzzzzze_);
                object xzzzzzzzzzg_((CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? @this)
                {
                    int? xzzzzzzzzzr_ = @this?.days;

                    return xzzzzzzzzzr_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> xzzzzzzzzzh_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(xzzzzzzzzzf_, xzzzzzzzzzg_, System.ComponentModel.ListSortDirection.Descending);
                (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? xzzzzzzzzzi_ = context.Operators.First<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(xzzzzzzzzzh_);
                CqlInterval<CqlDate> xzzzzzzzzzj_ = xzzzzzzzzzi_?.interval;

                return xzzzzzzzzzj_;
            }
        };
        int? wzzzzzzzzzl_()
        {
            bool xzzzzzzzzzs_()
            {
                int? xzzzzzzzzzt_ = context.Operators.Count<CqlInterval<CqlDate>>(collapsedIntervals);
                bool? xzzzzzzzzzu_ = context.Operators.Equal(xzzzzzzzzzt_, 0);

                return xzzzzzzzzzu_ ?? false;
            };
            if (xzzzzzzzzzs_())
            {
                return 0;
            }
            else
            {
                (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? xzzzzzzzzzv_(CqlInterval<CqlDate> I)
                {
                    CqlDate yzzzzzzzzzp_ = context.Operators.Start(I);
                    CqlDate yzzzzzzzzzq_ = context.Operators.End(I);
                    int? yzzzzzzzzzr_ = context.Operators.DurationBetween(yzzzzzzzzzp_, yzzzzzzzzzq_, "day");
                    int? yzzzzzzzzzs_ = context.Operators.Add(yzzzzzzzzzr_, 1);
                    int?[] yzzzzzzzzzt_ = [
                        yzzzzzzzzzs_,
                        0,
                    ];
                    int? yzzzzzzzzzu_ = context.Operators.Max<int?>(yzzzzzzzzzt_ as IEnumerable<int?>);
                    (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? yzzzzzzzzzv_ = (CqlTupleMetadata_HEjPGjPEhLgQPGjROeWMgiGfC, I, yzzzzzzzzzu_);

                    return yzzzzzzzzzv_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> xzzzzzzzzzw_ = context.Operators.Select<CqlInterval<CqlDate>, (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(collapsedIntervals, xzzzzzzzzzv_);
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> xzzzzzzzzzx_ = context.Operators.Distinct<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(xzzzzzzzzzw_);
                object xzzzzzzzzzy_((CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? @this)
                {
                    int? yzzzzzzzzzw_ = @this?.days;

                    return yzzzzzzzzzw_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> xzzzzzzzzzz_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(xzzzzzzzzzx_, xzzzzzzzzzy_, System.ComponentModel.ListSortDirection.Descending);
                (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? yzzzzzzzzza_ = context.Operators.First<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(xzzzzzzzzzz_);
                CqlInterval<CqlDate> yzzzzzzzzzb_ = yzzzzzzzzza_?.interval;
                CqlDate yzzzzzzzzzc_ = context.Operators.Start(yzzzzzzzzzb_);
                (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? yzzzzzzzzzd_(CqlInterval<CqlDate> I)
                {
                    CqlDate yzzzzzzzzzx_ = context.Operators.Start(I);
                    CqlDate yzzzzzzzzzy_ = context.Operators.End(I);
                    int? yzzzzzzzzzz_ = context.Operators.DurationBetween(yzzzzzzzzzx_, yzzzzzzzzzy_, "day");
                    int? zzzzzzzzzza_ = context.Operators.Add(yzzzzzzzzzz_, 1);
                    int?[] zzzzzzzzzzb_ = [
                        zzzzzzzzzza_,
                        0,
                    ];
                    int? zzzzzzzzzzc_ = context.Operators.Max<int?>(zzzzzzzzzzb_ as IEnumerable<int?>);
                    (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? zzzzzzzzzzd_ = (CqlTupleMetadata_HEjPGjPEhLgQPGjROeWMgiGfC, I, zzzzzzzzzzc_);

                    return zzzzzzzzzzd_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> yzzzzzzzzze_ = context.Operators.Select<CqlInterval<CqlDate>, (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(collapsedIntervals, yzzzzzzzzzd_);
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> yzzzzzzzzzf_ = context.Operators.Distinct<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(yzzzzzzzzze_);
                object yzzzzzzzzzg_((CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? @this)
                {
                    int? zzzzzzzzzze_ = @this?.days;

                    return zzzzzzzzzze_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?> yzzzzzzzzzh_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(yzzzzzzzzzf_, yzzzzzzzzzg_, System.ComponentModel.ListSortDirection.Descending);
                (CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)? yzzzzzzzzzi_ = context.Operators.First<(CqlTupleMetadata, CqlInterval<CqlDate> interval, int? days)?>(yzzzzzzzzzh_);
                CqlInterval<CqlDate> yzzzzzzzzzj_ = yzzzzzzzzzi_?.interval;
                CqlDate yzzzzzzzzzk_ = context.Operators.End(yzzzzzzzzzj_);
                int? yzzzzzzzzzl_ = context.Operators.DurationBetween(yzzzzzzzzzc_, yzzzzzzzzzk_, "day");
                int? yzzzzzzzzzm_ = context.Operators.Add(yzzzzzzzzzl_, 1);
                int?[] yzzzzzzzzzn_ = [
                    yzzzzzzzzzm_,
                    0,
                ];
                int? yzzzzzzzzzo_ = context.Operators.Max<int?>(yzzzzzzzzzn_ as IEnumerable<int?>);

                return yzzzzzzzzzo_;
            }
        };
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? wzzzzzzzzzm_ = (CqlTupleMetadata_HRbPDRZiOGGBceePOZWjVbXdP, collapsedIntervals, wzzzzzzzzzi_, wzzzzzzzzzj_(), wzzzzzzzzzk_(), wzzzzzzzzzl_());

        return wzzzzzzzzzm_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? Date_Interval_Covering_Relative_to_Base_Interval_Stats(CqlContext context, CqlInterval<CqlDate> baseInterval, IEnumerable<CqlInterval<CqlDate>> coveringIntervals)
    {
        IEnumerable<CqlInterval<CqlDate>> zzzzzzzzzzf_ = this.Date_Interval_Covering_Relative_to_Base_Interval(context, baseInterval, coveringIntervals);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Covering_Intervals)? zzzzzzzzzzg_ = (CqlTupleMetadata_DUiZjXRKgCPYVZQJbFVDKNMOi, zzzzzzzzzzf_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Covering_Intervals)?[] zzzzzzzzzzh_ = [
            zzzzzzzzzzg_,
        ];
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? zzzzzzzzzzi_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Covering_Intervals)? variableDeclarations)
        {
            IEnumerable<CqlInterval<CqlDate>> zzzzzzzzzzm_ = variableDeclarations?.Covering_Intervals;
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? zzzzzzzzzzn_ = this.Collapsed_Date_Interval_Stats(context, zzzzzzzzzzm_);

            return zzzzzzzzzzn_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?> zzzzzzzzzzj_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Covering_Intervals)?, (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Covering_Intervals)?>)zzzzzzzzzzh_, zzzzzzzzzzi_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?> zzzzzzzzzzk_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>(zzzzzzzzzzj_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? zzzzzzzzzzl_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>(zzzzzzzzzzk_);

        return zzzzzzzzzzl_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? Date_Interval_Gaps_Relative_to_Base_Interval_Stats(CqlContext context, CqlInterval<CqlDate> baseInterval, IEnumerable<CqlInterval<CqlDate>> coveringIntervals)
    {
        IEnumerable<CqlInterval<CqlDate>> zzzzzzzzzzo_ = this.Date_Interval_Gaps_Relative_to_Base_Interval(context, baseInterval, coveringIntervals);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Gap_Intervals)? zzzzzzzzzzp_ = (CqlTupleMetadata_GQPbYTYABjXFVLRKjXgcDJFSj, zzzzzzzzzzo_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Gap_Intervals)?[] zzzzzzzzzzq_ = [
            zzzzzzzzzzp_,
        ];
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? zzzzzzzzzzr_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Gap_Intervals)? variableDeclarations)
        {
            IEnumerable<CqlInterval<CqlDate>> zzzzzzzzzzv_ = variableDeclarations?.Gap_Intervals;
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? zzzzzzzzzzw_ = this.Collapsed_Date_Interval_Stats(context, zzzzzzzzzzv_);

            return zzzzzzzzzzw_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?> zzzzzzzzzzs_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Gap_Intervals)?, (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Gap_Intervals)?>)zzzzzzzzzzq_, zzzzzzzzzzr_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?> zzzzzzzzzzt_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>(zzzzzzzzzzs_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? zzzzzzzzzzu_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>(zzzzzzzzzzt_);

        return zzzzzzzzzzu_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CqlInterval<CqlDateTime> DateTime_Interval_Set_Nulls_to_Zero(CqlContext context, CqlInterval<CqlDateTime> interval)
    {
        CqlDateTime zzzzzzzzzzx_ = context.Operators.Start(interval);
        int? zzzzzzzzzzy_ = context.Operators.DateTimeComponentFrom(zzzzzzzzzzx_, "year");
        int? zzzzzzzzzzz_()
        {
            bool azzzzzzzzzzt_()
            {
                CqlDateTime azzzzzzzzzzu_ = context.Operators.Start(interval);
                int? azzzzzzzzzzv_ = context.Operators.DateTimeComponentFrom(azzzzzzzzzzu_, "month");

                return azzzzzzzzzzv_ is null;
            };
            if (azzzzzzzzzzt_())
            {
                return 0;
            }
            else
            {
                CqlDateTime azzzzzzzzzzw_ = context.Operators.Start(interval);
                int? azzzzzzzzzzx_ = context.Operators.DateTimeComponentFrom(azzzzzzzzzzw_, "month");

                return azzzzzzzzzzx_;
            }
        };
        int? azzzzzzzzzza_()
        {
            bool azzzzzzzzzzy_()
            {
                CqlDateTime azzzzzzzzzzz_ = context.Operators.Start(interval);
                int? bzzzzzzzzzza_ = context.Operators.DateTimeComponentFrom(azzzzzzzzzzz_, "day");

                return bzzzzzzzzzza_ is null;
            };
            if (azzzzzzzzzzy_())
            {
                return 0;
            }
            else
            {
                CqlDateTime bzzzzzzzzzzb_ = context.Operators.Start(interval);
                int? bzzzzzzzzzzc_ = context.Operators.DateTimeComponentFrom(bzzzzzzzzzzb_, "day");

                return bzzzzzzzzzzc_;
            }
        };
        int? azzzzzzzzzzb_()
        {
            bool bzzzzzzzzzzd_()
            {
                CqlDateTime bzzzzzzzzzze_ = context.Operators.Start(interval);
                int? bzzzzzzzzzzf_ = context.Operators.DateTimeComponentFrom(bzzzzzzzzzze_, "hour");

                return bzzzzzzzzzzf_ is null;
            };
            if (bzzzzzzzzzzd_())
            {
                return 0;
            }
            else
            {
                CqlDateTime bzzzzzzzzzzg_ = context.Operators.Start(interval);
                int? bzzzzzzzzzzh_ = context.Operators.DateTimeComponentFrom(bzzzzzzzzzzg_, "hour");

                return bzzzzzzzzzzh_;
            }
        };
        int? azzzzzzzzzzc_()
        {
            bool bzzzzzzzzzzi_()
            {
                CqlDateTime bzzzzzzzzzzj_ = context.Operators.Start(interval);
                int? bzzzzzzzzzzk_ = context.Operators.DateTimeComponentFrom(bzzzzzzzzzzj_, "minute");

                return bzzzzzzzzzzk_ is null;
            };
            if (bzzzzzzzzzzi_())
            {
                return 0;
            }
            else
            {
                CqlDateTime bzzzzzzzzzzl_ = context.Operators.Start(interval);
                int? bzzzzzzzzzzm_ = context.Operators.DateTimeComponentFrom(bzzzzzzzzzzl_, "minute");

                return bzzzzzzzzzzm_;
            }
        };
        int? azzzzzzzzzzd_()
        {
            bool bzzzzzzzzzzn_()
            {
                CqlDateTime bzzzzzzzzzzo_ = context.Operators.Start(interval);
                int? bzzzzzzzzzzp_ = context.Operators.DateTimeComponentFrom(bzzzzzzzzzzo_, "second");

                return bzzzzzzzzzzp_ is null;
            };
            if (bzzzzzzzzzzn_())
            {
                return 0;
            }
            else
            {
                CqlDateTime bzzzzzzzzzzq_ = context.Operators.Start(interval);
                int? bzzzzzzzzzzr_ = context.Operators.DateTimeComponentFrom(bzzzzzzzzzzq_, "second");

                return bzzzzzzzzzzr_;
            }
        };
        int? azzzzzzzzzze_()
        {
            bool bzzzzzzzzzzs_()
            {
                CqlDateTime bzzzzzzzzzzt_ = context.Operators.Start(interval);
                int? bzzzzzzzzzzu_ = context.Operators.DateTimeComponentFrom(bzzzzzzzzzzt_, "millisecond");

                return bzzzzzzzzzzu_ is null;
            };
            if (bzzzzzzzzzzs_())
            {
                return 0;
            }
            else
            {
                CqlDateTime bzzzzzzzzzzv_ = context.Operators.Start(interval);
                int? bzzzzzzzzzzw_ = context.Operators.DateTimeComponentFrom(bzzzzzzzzzzv_, "millisecond");

                return bzzzzzzzzzzw_;
            }
        };
        CqlDateTime azzzzzzzzzzf_ = context.Operators.End(interval);
        int? azzzzzzzzzzg_ = context.Operators.DateTimeComponentFrom(azzzzzzzzzzf_, "year");
        int? azzzzzzzzzzh_()
        {
            bool bzzzzzzzzzzx_()
            {
                CqlDateTime bzzzzzzzzzzy_ = context.Operators.End(interval);
                int? bzzzzzzzzzzz_ = context.Operators.DateTimeComponentFrom(bzzzzzzzzzzy_, "month");

                return bzzzzzzzzzzz_ is null;
            };
            if (bzzzzzzzzzzx_())
            {
                return 0;
            }
            else
            {
                CqlDateTime czzzzzzzzzza_ = context.Operators.End(interval);
                int? czzzzzzzzzzb_ = context.Operators.DateTimeComponentFrom(czzzzzzzzzza_, "month");

                return czzzzzzzzzzb_;
            }
        };
        int? azzzzzzzzzzi_()
        {
            bool czzzzzzzzzzc_()
            {
                CqlDateTime czzzzzzzzzzd_ = context.Operators.End(interval);
                int? czzzzzzzzzze_ = context.Operators.DateTimeComponentFrom(czzzzzzzzzzd_, "day");

                return czzzzzzzzzze_ is null;
            };
            if (czzzzzzzzzzc_())
            {
                return 0;
            }
            else
            {
                CqlDateTime czzzzzzzzzzf_ = context.Operators.End(interval);
                int? czzzzzzzzzzg_ = context.Operators.DateTimeComponentFrom(czzzzzzzzzzf_, "day");

                return czzzzzzzzzzg_;
            }
        };
        int? azzzzzzzzzzj_()
        {
            bool czzzzzzzzzzh_()
            {
                CqlDateTime czzzzzzzzzzi_ = context.Operators.End(interval);
                int? czzzzzzzzzzj_ = context.Operators.DateTimeComponentFrom(czzzzzzzzzzi_, "hour");

                return czzzzzzzzzzj_ is null;
            };
            if (czzzzzzzzzzh_())
            {
                return 0;
            }
            else
            {
                CqlDateTime czzzzzzzzzzk_ = context.Operators.End(interval);
                int? czzzzzzzzzzl_ = context.Operators.DateTimeComponentFrom(czzzzzzzzzzk_, "hour");

                return czzzzzzzzzzl_;
            }
        };
        int? azzzzzzzzzzk_()
        {
            bool czzzzzzzzzzm_()
            {
                CqlDateTime czzzzzzzzzzn_ = context.Operators.End(interval);
                int? czzzzzzzzzzo_ = context.Operators.DateTimeComponentFrom(czzzzzzzzzzn_, "minute");

                return czzzzzzzzzzo_ is null;
            };
            if (czzzzzzzzzzm_())
            {
                return 0;
            }
            else
            {
                CqlDateTime czzzzzzzzzzp_ = context.Operators.End(interval);
                int? czzzzzzzzzzq_ = context.Operators.DateTimeComponentFrom(czzzzzzzzzzp_, "minute");

                return czzzzzzzzzzq_;
            }
        };
        int? azzzzzzzzzzl_()
        {
            bool czzzzzzzzzzr_()
            {
                CqlDateTime czzzzzzzzzzs_ = context.Operators.End(interval);
                int? czzzzzzzzzzt_ = context.Operators.DateTimeComponentFrom(czzzzzzzzzzs_, "second");

                return czzzzzzzzzzt_ is null;
            };
            if (czzzzzzzzzzr_())
            {
                return 0;
            }
            else
            {
                CqlDateTime czzzzzzzzzzu_ = context.Operators.End(interval);
                int? czzzzzzzzzzv_ = context.Operators.DateTimeComponentFrom(czzzzzzzzzzu_, "second");

                return czzzzzzzzzzv_;
            }
        };
        int? azzzzzzzzzzm_()
        {
            bool czzzzzzzzzzw_()
            {
                CqlDateTime czzzzzzzzzzx_ = context.Operators.End(interval);
                int? czzzzzzzzzzy_ = context.Operators.DateTimeComponentFrom(czzzzzzzzzzx_, "millisecond");

                return czzzzzzzzzzy_ is null;
            };
            if (czzzzzzzzzzw_())
            {
                return 0;
            }
            else
            {
                CqlDateTime czzzzzzzzzzz_ = context.Operators.End(interval);
                int? dzzzzzzzzzza_ = context.Operators.DateTimeComponentFrom(czzzzzzzzzzz_, "millisecond");

                return dzzzzzzzzzza_;
            }
        };
        (CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)? azzzzzzzzzzn_ = (CqlTupleMetadata_FcQREFSfPJSKYAhSEWVJcZVED, zzzzzzzzzzy_, zzzzzzzzzzz_(), azzzzzzzzzza_(), azzzzzzzzzzb_(), azzzzzzzzzzc_(), azzzzzzzzzzd_(), azzzzzzzzzze_(), azzzzzzzzzzg_, azzzzzzzzzzh_(), azzzzzzzzzzi_(), azzzzzzzzzzj_(), azzzzzzzzzzk_(), azzzzzzzzzzl_(), azzzzzzzzzzm_());
        (CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)?[] azzzzzzzzzzo_ = [
            azzzzzzzzzzn_,
        ];
        CqlInterval<CqlDateTime> azzzzzzzzzzp_((CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)? i)
        {
            int? dzzzzzzzzzzb_ = i?.StartYear;
            int? dzzzzzzzzzzc_ = i?.StartMonth;
            int? dzzzzzzzzzzd_ = i?.StartDay;
            int? dzzzzzzzzzze_ = i?.StartHour;
            int? dzzzzzzzzzzf_ = i?.StartMinute;
            int? dzzzzzzzzzzg_ = i?.StartSecond;
            int? dzzzzzzzzzzh_ = i?.StartMillisecond;
            CqlDateTime dzzzzzzzzzzi_ = context.Operators.DateTime(dzzzzzzzzzzb_, dzzzzzzzzzzc_, dzzzzzzzzzzd_, dzzzzzzzzzze_, dzzzzzzzzzzf_, dzzzzzzzzzzg_, dzzzzzzzzzzh_, default);
            int? dzzzzzzzzzzj_ = i?.EndYear;
            int? dzzzzzzzzzzk_ = i?.EndMonth;
            int? dzzzzzzzzzzl_ = i?.EndDay;
            int? dzzzzzzzzzzm_ = i?.EndHour;
            int? dzzzzzzzzzzn_ = i?.EndMinute;
            int? dzzzzzzzzzzo_ = i?.EndSecond;
            int? dzzzzzzzzzzp_ = i?.EndMillisecond;
            CqlDateTime dzzzzzzzzzzq_ = context.Operators.DateTime(dzzzzzzzzzzj_, dzzzzzzzzzzk_, dzzzzzzzzzzl_, dzzzzzzzzzzm_, dzzzzzzzzzzn_, dzzzzzzzzzzo_, dzzzzzzzzzzp_, default);
            CqlInterval<CqlDateTime> dzzzzzzzzzzr_ = context.Operators.Interval(dzzzzzzzzzzi_, dzzzzzzzzzzq_, true, true);

            return dzzzzzzzzzzr_;
        };
        IEnumerable<CqlInterval<CqlDateTime>> azzzzzzzzzzq_ = context.Operators.Select<(CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)?, CqlInterval<CqlDateTime>>((IEnumerable<(CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)?>)azzzzzzzzzzo_, azzzzzzzzzzp_);
        IEnumerable<CqlInterval<CqlDateTime>> azzzzzzzzzzr_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(azzzzzzzzzzq_);
        CqlInterval<CqlDateTime> azzzzzzzzzzs_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(azzzzzzzzzzr_);

        return azzzzzzzzzzs_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? Collapsed_DateTime_Interval_Stats(CqlContext context, IEnumerable<CqlInterval<CqlDateTime>> collapsedIntervals)
    {
        int? dzzzzzzzzzzs_ = context.Operators.Count<CqlInterval<CqlDateTime>>(collapsedIntervals);
        int? dzzzzzzzzzzt_()
        {
            bool dzzzzzzzzzzx_()
            {
                int? dzzzzzzzzzzy_ = context.Operators.Count<CqlInterval<CqlDateTime>>(collapsedIntervals);
                bool? dzzzzzzzzzzz_ = context.Operators.Equal(dzzzzzzzzzzy_, 0);

                return dzzzzzzzzzzz_ ?? false;
            };
            if (dzzzzzzzzzzx_())
            {
                return 0;
            }
            else
            {
                int? ezzzzzzzzzza_(CqlInterval<CqlDateTime> I)
                {
                    CqlInterval<CqlDateTime> ezzzzzzzzzze_ = this.DateTime_Interval_Set_Nulls_to_Zero(context, I);
                    CqlDateTime ezzzzzzzzzzf_ = context.Operators.Start(ezzzzzzzzzze_);
                    CqlDateTime ezzzzzzzzzzh_ = context.Operators.End(ezzzzzzzzzze_);
                    int? ezzzzzzzzzzi_ = context.Operators.DurationBetween(ezzzzzzzzzzf_, ezzzzzzzzzzh_, "day");
                    int? ezzzzzzzzzzj_ = context.Operators.Add(ezzzzzzzzzzi_, 1);
                    int?[] ezzzzzzzzzzk_ = [
                        ezzzzzzzzzzj_,
                        0,
                    ];
                    int? ezzzzzzzzzzl_ = context.Operators.Max<int?>(ezzzzzzzzzzk_ as IEnumerable<int?>);

                    return ezzzzzzzzzzl_;
                };
                IEnumerable<int?> ezzzzzzzzzzb_ = context.Operators.Select<CqlInterval<CqlDateTime>, int?>(collapsedIntervals, ezzzzzzzzzza_);
                IEnumerable<int?> ezzzzzzzzzzc_ = context.Operators.Distinct<int?>(ezzzzzzzzzzb_);
                int? ezzzzzzzzzzd_ = context.Operators.Sum(ezzzzzzzzzzc_);

                return ezzzzzzzzzzd_;
            }
        };
        CqlInterval<CqlDateTime> dzzzzzzzzzzu_()
        {
            bool ezzzzzzzzzzm_()
            {
                int? ezzzzzzzzzzn_ = context.Operators.Count<CqlInterval<CqlDateTime>>(collapsedIntervals);
                bool? ezzzzzzzzzzo_ = context.Operators.Equal(ezzzzzzzzzzn_, 0);

                return ezzzzzzzzzzo_ ?? false;
            };
            if (ezzzzzzzzzzm_())
            {
                return null as CqlInterval<CqlDateTime>;
            }
            else
            {
                (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? ezzzzzzzzzzp_(CqlInterval<CqlDateTime> I)
                {
                    CqlInterval<CqlDateTime> ezzzzzzzzzzw_ = this.DateTime_Interval_Set_Nulls_to_Zero(context, I);
                    CqlDateTime ezzzzzzzzzzx_ = context.Operators.Start(ezzzzzzzzzzw_);
                    CqlDateTime ezzzzzzzzzzz_ = context.Operators.End(ezzzzzzzzzzw_);
                    int? fzzzzzzzzzza_ = context.Operators.DurationBetween(ezzzzzzzzzzx_, ezzzzzzzzzzz_, "day");
                    int? fzzzzzzzzzzb_ = context.Operators.Add(fzzzzzzzzzza_, 1);
                    int?[] fzzzzzzzzzzc_ = [
                        fzzzzzzzzzzb_,
                        0,
                    ];
                    int? fzzzzzzzzzzd_ = context.Operators.Max<int?>(fzzzzzzzzzzc_ as IEnumerable<int?>);
                    (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? fzzzzzzzzzze_ = (CqlTupleMetadata_CGHEUIgjaCjJVKEADTSZEbdCL, I, fzzzzzzzzzzd_);

                    return fzzzzzzzzzze_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> ezzzzzzzzzzq_ = context.Operators.Select<CqlInterval<CqlDateTime>, (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(collapsedIntervals, ezzzzzzzzzzp_);
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> ezzzzzzzzzzr_ = context.Operators.Distinct<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(ezzzzzzzzzzq_);
                object ezzzzzzzzzzs_((CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? @this)
                {
                    int? fzzzzzzzzzzf_ = @this?.days;

                    return fzzzzzzzzzzf_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> ezzzzzzzzzzt_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(ezzzzzzzzzzr_, ezzzzzzzzzzs_, System.ComponentModel.ListSortDirection.Descending);
                (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? ezzzzzzzzzzu_ = context.Operators.First<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(ezzzzzzzzzzt_);
                CqlInterval<CqlDateTime> ezzzzzzzzzzv_ = ezzzzzzzzzzu_?.interval;

                return ezzzzzzzzzzv_;
            }
        };
        int? dzzzzzzzzzzv_()
        {
            bool fzzzzzzzzzzg_()
            {
                int? fzzzzzzzzzzh_ = context.Operators.Count<CqlInterval<CqlDateTime>>(collapsedIntervals);
                bool? fzzzzzzzzzzi_ = context.Operators.Equal(fzzzzzzzzzzh_, 0);

                return fzzzzzzzzzzi_ ?? false;
            };
            if (fzzzzzzzzzzg_())
            {
                return 0;
            }
            else
            {
                (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? fzzzzzzzzzzj_(CqlInterval<CqlDateTime> I)
                {
                    CqlInterval<CqlDateTime> gzzzzzzzzzzf_ = this.DateTime_Interval_Set_Nulls_to_Zero(context, I);
                    CqlDateTime gzzzzzzzzzzg_ = context.Operators.Start(gzzzzzzzzzzf_);
                    CqlDateTime gzzzzzzzzzzi_ = context.Operators.End(gzzzzzzzzzzf_);
                    int? gzzzzzzzzzzj_ = context.Operators.DurationBetween(gzzzzzzzzzzg_, gzzzzzzzzzzi_, "day");
                    int? gzzzzzzzzzzk_ = context.Operators.Add(gzzzzzzzzzzj_, 1);
                    int?[] gzzzzzzzzzzl_ = [
                        gzzzzzzzzzzk_,
                        0,
                    ];
                    int? gzzzzzzzzzzm_ = context.Operators.Max<int?>(gzzzzzzzzzzl_ as IEnumerable<int?>);
                    (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? gzzzzzzzzzzn_ = (CqlTupleMetadata_CGHEUIgjaCjJVKEADTSZEbdCL, I, gzzzzzzzzzzm_);

                    return gzzzzzzzzzzn_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> fzzzzzzzzzzk_ = context.Operators.Select<CqlInterval<CqlDateTime>, (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(collapsedIntervals, fzzzzzzzzzzj_);
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> fzzzzzzzzzzl_ = context.Operators.Distinct<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(fzzzzzzzzzzk_);
                object fzzzzzzzzzzm_((CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? @this)
                {
                    int? gzzzzzzzzzzo_ = @this?.days;

                    return gzzzzzzzzzzo_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> fzzzzzzzzzzn_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(fzzzzzzzzzzl_, fzzzzzzzzzzm_, System.ComponentModel.ListSortDirection.Descending);
                (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? fzzzzzzzzzzo_ = context.Operators.First<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(fzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> fzzzzzzzzzzp_ = fzzzzzzzzzzo_?.interval;
                CqlInterval<CqlDateTime> fzzzzzzzzzzq_ = this.DateTime_Interval_Set_Nulls_to_Zero(context, fzzzzzzzzzzp_);
                CqlDateTime fzzzzzzzzzzr_ = context.Operators.Start(fzzzzzzzzzzq_);
                (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? fzzzzzzzzzzs_(CqlInterval<CqlDateTime> I)
                {
                    CqlInterval<CqlDateTime> gzzzzzzzzzzp_ = this.DateTime_Interval_Set_Nulls_to_Zero(context, I);
                    CqlDateTime gzzzzzzzzzzq_ = context.Operators.Start(gzzzzzzzzzzp_);
                    CqlDateTime gzzzzzzzzzzs_ = context.Operators.End(gzzzzzzzzzzp_);
                    int? gzzzzzzzzzzt_ = context.Operators.DurationBetween(gzzzzzzzzzzq_, gzzzzzzzzzzs_, "day");
                    int? gzzzzzzzzzzu_ = context.Operators.Add(gzzzzzzzzzzt_, 1);
                    int?[] gzzzzzzzzzzv_ = [
                        gzzzzzzzzzzu_,
                        0,
                    ];
                    int? gzzzzzzzzzzw_ = context.Operators.Max<int?>(gzzzzzzzzzzv_ as IEnumerable<int?>);
                    (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? gzzzzzzzzzzx_ = (CqlTupleMetadata_CGHEUIgjaCjJVKEADTSZEbdCL, I, gzzzzzzzzzzw_);

                    return gzzzzzzzzzzx_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> fzzzzzzzzzzt_ = context.Operators.Select<CqlInterval<CqlDateTime>, (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(collapsedIntervals, fzzzzzzzzzzs_);
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> fzzzzzzzzzzu_ = context.Operators.Distinct<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(fzzzzzzzzzzt_);
                object fzzzzzzzzzzv_((CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? @this)
                {
                    int? gzzzzzzzzzzy_ = @this?.days;

                    return gzzzzzzzzzzy_;
                };
                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?> fzzzzzzzzzzw_ = context.Operators.SortBy<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(fzzzzzzzzzzu_, fzzzzzzzzzzv_, System.ComponentModel.ListSortDirection.Descending);
                (CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)? fzzzzzzzzzzx_ = context.Operators.First<(CqlTupleMetadata, CqlInterval<CqlDateTime> interval, int? days)?>(fzzzzzzzzzzw_);
                CqlInterval<CqlDateTime> fzzzzzzzzzzy_ = fzzzzzzzzzzx_?.interval;
                CqlInterval<CqlDateTime> fzzzzzzzzzzz_ = this.DateTime_Interval_Set_Nulls_to_Zero(context, fzzzzzzzzzzy_);
                CqlDateTime gzzzzzzzzzza_ = context.Operators.End(fzzzzzzzzzzz_);
                int? gzzzzzzzzzzb_ = context.Operators.DurationBetween(fzzzzzzzzzzr_, gzzzzzzzzzza_, "day");
                int? gzzzzzzzzzzc_ = context.Operators.Add(gzzzzzzzzzzb_, 1);
                int?[] gzzzzzzzzzzd_ = [
                    gzzzzzzzzzzc_,
                    0,
                ];
                int? gzzzzzzzzzze_ = context.Operators.Max<int?>(gzzzzzzzzzzd_ as IEnumerable<int?>);

                return gzzzzzzzzzze_;
            }
        };
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? dzzzzzzzzzzw_ = (CqlTupleMetadata_HDihbLieYfQbgeSbOWZBAMUIQ, collapsedIntervals, dzzzzzzzzzzs_, dzzzzzzzzzzt_(), dzzzzzzzzzzu_(), dzzzzzzzzzzv_());

        return dzzzzzzzzzzw_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? DateTime_Interval_Covering_Relative_to_Base_Interval_Stats(CqlContext context, CqlInterval<CqlDateTime> baseInterval, IEnumerable<CqlInterval<CqlDateTime>> coveringIntervals)
    {
        IEnumerable<CqlInterval<CqlDateTime>> gzzzzzzzzzzz_ = this.DateTime_Interval_Covering_Relative_to_Base_Interval(context, baseInterval, coveringIntervals);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Covering_Intervals)? hzzzzzzzzzza_ = (CqlTupleMetadata_GZMPWdGOJiTNjfWAcbZMePdXV, gzzzzzzzzzzz_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Covering_Intervals)?[] hzzzzzzzzzzb_ = [
            hzzzzzzzzzza_,
        ];
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? hzzzzzzzzzzc_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Covering_Intervals)? variableDeclarations)
        {
            IEnumerable<CqlInterval<CqlDateTime>> hzzzzzzzzzzg_ = variableDeclarations?.Covering_Intervals;
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? hzzzzzzzzzzh_ = this.Collapsed_DateTime_Interval_Stats(context, hzzzzzzzzzzg_);

            return hzzzzzzzzzzh_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?> hzzzzzzzzzzd_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Covering_Intervals)?, (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Covering_Intervals)?>)hzzzzzzzzzzb_, hzzzzzzzzzzc_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?> hzzzzzzzzzze_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?>(hzzzzzzzzzzd_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? hzzzzzzzzzzf_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?>(hzzzzzzzzzze_);

        return hzzzzzzzzzzf_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? DateTime_Interval_Gaps_Relative_to_Base_Interval_Stats(CqlContext context, CqlInterval<CqlDateTime> baseInterval, IEnumerable<CqlInterval<CqlDateTime>> coveringIntervals)
    {
        IEnumerable<CqlInterval<CqlDateTime>> hzzzzzzzzzzi_ = this.DateTime_Interval_Gaps_Relative_to_Base_Interval(context, baseInterval, coveringIntervals);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Gap_Intervals)? hzzzzzzzzzzj_ = (CqlTupleMetadata_CKbERRbOPGNBBERUOghhaOYSE, hzzzzzzzzzzi_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Gap_Intervals)?[] hzzzzzzzzzzk_ = [
            hzzzzzzzzzzj_,
        ];
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? hzzzzzzzzzzl_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Gap_Intervals)? variableDeclarations)
        {
            IEnumerable<CqlInterval<CqlDateTime>> hzzzzzzzzzzp_ = variableDeclarations?.Gap_Intervals;
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? hzzzzzzzzzzq_ = this.Collapsed_DateTime_Interval_Stats(context, hzzzzzzzzzzp_);

            return hzzzzzzzzzzq_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?> hzzzzzzzzzzm_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Gap_Intervals)?, (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Gap_Intervals)?>)hzzzzzzzzzzk_, hzzzzzzzzzzl_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?> hzzzzzzzzzzn_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?>(hzzzzzzzzzzm_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)? hzzzzzzzzzzo_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDateTime>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDateTime> Longest_Interval, int? Total_Days_In_Longest_Interval)?>(hzzzzzzzzzzn_);

        return hzzzzzzzzzzo_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CqlDateTime Convert_To_UTC_DateTime(CqlContext context, CqlDate d)
    {
        int? hzzzzzzzzzzr_ = context.Operators.DateTimeComponentFrom(d, "year");
        int? hzzzzzzzzzzs_()
        {
            if ((context.Operators.DateTimeComponentFrom(d, "month")) is null)
            {
                return 0;
            }
            else
            {
                int? izzzzzzzzzza_ = context.Operators.DateTimeComponentFrom(d, "month");

                return izzzzzzzzzza_;
            }
        };
        int? hzzzzzzzzzzt_()
        {
            if ((context.Operators.DateTimeComponentFrom(d, "day")) is null)
            {
                return 0;
            }
            else
            {
                int? izzzzzzzzzzb_ = context.Operators.DateTimeComponentFrom(d, "day");

                return izzzzzzzzzzb_;
            }
        };
        (CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)? hzzzzzzzzzzu_ = (CqlTupleMetadata_FcQREFSfPJSKYAhSEWVJcZVED, hzzzzzzzzzzr_, hzzzzzzzzzzs_(), hzzzzzzzzzzt_(), default, default, default, default, default, default, default, default, default, default, default);
        (CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)?[] hzzzzzzzzzzv_ = [
            hzzzzzzzzzzu_,
        ];
        CqlDateTime hzzzzzzzzzzw_((CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)? i)
        {
            int? izzzzzzzzzzc_ = i?.StartYear;
            int? izzzzzzzzzzd_ = i?.StartMonth;
            int? izzzzzzzzzze_ = i?.StartDay;
            decimal? izzzzzzzzzzf_ = context.Operators.ConvertIntegerToDecimal(0);
            CqlDateTime izzzzzzzzzzg_ = context.Operators.DateTime(izzzzzzzzzzc_, izzzzzzzzzzd_, izzzzzzzzzze_, 0, 0, 0, 0, izzzzzzzzzzf_);

            return izzzzzzzzzzg_;
        };
        IEnumerable<CqlDateTime> hzzzzzzzzzzx_ = context.Operators.Select<(CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)?, CqlDateTime>((IEnumerable<(CqlTupleMetadata, int? StartYear, int? StartMonth, int? StartDay, int? StartHour, int? StartMinute, int? StartSecond, int? StartMillisecond, int? EndYear, int? EndMonth, int? EndDay, int? EndHour, int? EndMinute, int? EndSecond, int? EndMillisecond)?>)hzzzzzzzzzzv_, hzzzzzzzzzzw_);
        IEnumerable<CqlDateTime> hzzzzzzzzzzy_ = context.Operators.Distinct<CqlDateTime>(hzzzzzzzzzzx_);
        CqlDateTime hzzzzzzzzzzz_ = context.Operators.SingletonFrom<CqlDateTime>(hzzzzzzzzzzy_);

        return hzzzzzzzzzzz_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CqlInterval<CqlDateTime> Convert_Interval_Date_to_UTC_Interval_DateTime(CqlContext context, CqlInterval<CqlDate> interval)
    {
        CqlDate izzzzzzzzzzh_ = context.Operators.Start(interval);
        CqlDateTime izzzzzzzzzzi_ = this.Convert_To_UTC_DateTime(context, izzzzzzzzzzh_);
        CqlDate izzzzzzzzzzj_ = context.Operators.End(interval);
        CqlDateTime izzzzzzzzzzk_ = this.Convert_To_UTC_DateTime(context, izzzzzzzzzzj_);
        CqlInterval<CqlDateTime> izzzzzzzzzzl_ = context.Operators.Interval(izzzzzzzzzzi_, izzzzzzzzzzk_, true, true);

        return izzzzzzzzzzl_;
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
