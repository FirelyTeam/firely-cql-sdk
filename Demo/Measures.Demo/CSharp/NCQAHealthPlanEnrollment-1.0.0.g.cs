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
[CqlLibrary("NCQAHealthPlanEnrollment", "1.0.0")]
public partial class NCQAHealthPlanEnrollment_1_0_0 : ILibrary, ISingleton<NCQAHealthPlanEnrollment_1_0_0>
{
    private NCQAHealthPlanEnrollment_1_0_0() {}

    public static NCQAHealthPlanEnrollment_1_0_0 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "NCQAHealthPlanEnrollment";
    public string Version => "1.0.0";
    public ILibrary[] Dependencies => [NCQACQLBase_1_0_0.Instance, FHIRHelpers_4_0_001.Instance, NCQATerminology_1_0_0.Instance, NCQAFHIRBase_1_0_0.Instance];

    #endregion ILibrary Implementation

    #region Expressions

    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<CqlInterval<CqlDate>> CoverageIntervals(CqlContext context, IEnumerable<Coverage> Coverage, CqlInterval<CqlDate> participationPeriod)
    {
        CqlInterval<CqlDate> izzzzzzzzzzm_(Coverage C)
        {
            Period izzzzzzzzzzp_ = C?.Period;
            CqlInterval<CqlDateTime> izzzzzzzzzzq_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, izzzzzzzzzzp_ as object);
            CqlDateTime izzzzzzzzzzr_ = context.Operators.Start(izzzzzzzzzzq_);
            CqlDate izzzzzzzzzzs_ = context.Operators.DateFrom(izzzzzzzzzzr_);
            CqlInterval<CqlDateTime> izzzzzzzzzzu_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, izzzzzzzzzzp_ as object);
            CqlDateTime izzzzzzzzzzv_ = context.Operators.End(izzzzzzzzzzu_);
            CqlDate izzzzzzzzzzw_ = context.Operators.DateFrom(izzzzzzzzzzv_);
            CqlInterval<CqlDate> izzzzzzzzzzx_ = context.Operators.Interval(izzzzzzzzzzs_, izzzzzzzzzzw_, true, true);
            CqlDate izzzzzzzzzzy_ = context.Operators.Start(participationPeriod);
            CqlDate izzzzzzzzzzz_ = context.Operators.End(participationPeriod);
            CqlInterval<CqlDate> jzzzzzzzzzza_ = context.Operators.Interval(izzzzzzzzzzy_, izzzzzzzzzzz_, true, true);
            CqlInterval<CqlDate> jzzzzzzzzzzb_ = context.Operators.Intersect<CqlDate>(izzzzzzzzzzx_, jzzzzzzzzzza_);

            return jzzzzzzzzzzb_;
        };
        IEnumerable<CqlInterval<CqlDate>> izzzzzzzzzzn_ = context.Operators.Select<Coverage, CqlInterval<CqlDate>>(Coverage, izzzzzzzzzzm_);
        IEnumerable<CqlInterval<CqlDate>> izzzzzzzzzzo_ = context.Operators.Distinct<CqlInterval<CqlDate>>(izzzzzzzzzzn_);

        return izzzzzzzzzzo_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<CqlInterval<CqlDate>> Collapsed_Coverage_Intervals(CqlContext context, IEnumerable<CqlInterval<CqlDate>> Intervals)
    {
        IEnumerable<CqlInterval<CqlDate>> jzzzzzzzzzzc_ = NCQACQLBase_1_0_0.Instance.Collapse_Date_Interval_Workaround(context, Intervals);

        return jzzzzzzzzzzc_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<CqlInterval<CqlDate>> Collapsed_Coverage_Adjacent_Intervals(CqlContext context, IEnumerable<CqlInterval<CqlDate>> Intervals)
    {
        IEnumerable<ValueTuple<CqlInterval<CqlDate>, CqlInterval<CqlDate>>> jzzzzzzzzzzd_ = context.Operators.CrossJoin<CqlInterval<CqlDate>, CqlInterval<CqlDate>>(Intervals, Intervals);
        (CqlTupleMetadata, CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)? jzzzzzzzzzze_(ValueTuple<CqlInterval<CqlDate>, CqlInterval<CqlDate>> _valueTuple)
        {
            (CqlTupleMetadata, CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)? jzzzzzzzzzzl_ = (CqlTupleMetadata_BaNHUZXcQBUKLNgEDWdDHjYV, _valueTuple.Item1, _valueTuple.Item2);

            return jzzzzzzzzzzl_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)?> jzzzzzzzzzzf_ = context.Operators.Select<ValueTuple<CqlInterval<CqlDate>, CqlInterval<CqlDate>>, (CqlTupleMetadata, CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)?>(jzzzzzzzzzzd_, jzzzzzzzzzze_);
        bool? jzzzzzzzzzzg_((CqlTupleMetadata, CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)? tuple_banhuzxcqbuklngedwddhjyv)
        {
            CqlDate jzzzzzzzzzzm_ = context.Operators.End(tuple_banhuzxcqbuklngedwddhjyv?.Coverage1);
            CqlDate jzzzzzzzzzzn_ = context.Operators.Start(tuple_banhuzxcqbuklngedwddhjyv?.Coverage2);
            CqlQuantity jzzzzzzzzzzo_ = context.Operators.Quantity(1m, "day");
            CqlDate jzzzzzzzzzzp_ = context.Operators.Subtract(jzzzzzzzzzzn_, jzzzzzzzzzzo_);
            CqlDate jzzzzzzzzzzs_ = context.Operators.Add(jzzzzzzzzzzn_, jzzzzzzzzzzo_);
            CqlInterval<CqlDate> jzzzzzzzzzzt_ = context.Operators.Interval(jzzzzzzzzzzp_, jzzzzzzzzzzs_, true, true);
            bool? jzzzzzzzzzzu_ = context.Operators.In<CqlDate>(jzzzzzzzzzzm_, jzzzzzzzzzzt_, default);
            bool? jzzzzzzzzzzw_ = context.Operators.Not((bool?)(jzzzzzzzzzzn_ is null));
            bool? jzzzzzzzzzzx_ = context.Operators.And(jzzzzzzzzzzu_, jzzzzzzzzzzw_);

            return jzzzzzzzzzzx_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)?> jzzzzzzzzzzh_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)?>(jzzzzzzzzzzf_, jzzzzzzzzzzg_);
        CqlInterval<CqlDate> jzzzzzzzzzzi_((CqlTupleMetadata, CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)? tuple_banhuzxcqbuklngedwddhjyv)
        {
            CqlDate jzzzzzzzzzzy_ = context.Operators.Start(tuple_banhuzxcqbuklngedwddhjyv?.Coverage1);
            CqlDate jzzzzzzzzzzz_ = context.Operators.End(tuple_banhuzxcqbuklngedwddhjyv?.Coverage2);
            CqlInterval<CqlDate> kzzzzzzzzzza_ = context.Operators.Interval(jzzzzzzzzzzy_, jzzzzzzzzzzz_, true, true);

            return kzzzzzzzzzza_;
        };
        IEnumerable<CqlInterval<CqlDate>> jzzzzzzzzzzj_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)?, CqlInterval<CqlDate>>(jzzzzzzzzzzh_, jzzzzzzzzzzi_);
        IEnumerable<CqlInterval<CqlDate>> jzzzzzzzzzzk_ = context.Operators.Distinct<CqlInterval<CqlDate>>(jzzzzzzzzzzj_);

        return jzzzzzzzzzzk_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<CqlInterval<CqlDate>> Collapsed_Final_Coverage_Intervals(CqlContext context, IEnumerable<CqlInterval<CqlDate>> collapsedI, IEnumerable<CqlInterval<CqlDate>> adjacentI)
    {
        IEnumerable<CqlInterval<CqlDate>> kzzzzzzzzzzb_ = this.Collapsed_Coverage_Intervals(context, collapsedI);
        IEnumerable<CqlInterval<CqlDate>> kzzzzzzzzzzc_ = this.Collapsed_Coverage_Adjacent_Intervals(context, adjacentI);
        IEnumerable<CqlInterval<CqlDate>> kzzzzzzzzzzd_ = context.Operators.Union<CqlInterval<CqlDate>>(kzzzzzzzzzzb_, kzzzzzzzzzzc_);
        IEnumerable<CqlInterval<CqlDate>> kzzzzzzzzzze_ = NCQACQLBase_1_0_0.Instance.Collapse_Date_Interval_Workaround(context, kzzzzzzzzzzd_);

        return kzzzzzzzzzze_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> All_Coverage_Info(CqlContext context, IEnumerable<Coverage> Coverage, CqlInterval<CqlDate> participationPeriod)
    {
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? kzzzzzzzzzzf_(Coverage C)
        {
            IEnumerable<CqlInterval<CqlDate>> kzzzzzzzzzzi_ = this.CoverageIntervals(context, Coverage, participationPeriod);
            IEnumerable<CqlInterval<CqlDate>> kzzzzzzzzzzk_ = this.Collapsed_Coverage_Intervals(context, kzzzzzzzzzzi_);
            IEnumerable<CqlInterval<CqlDate>> kzzzzzzzzzzm_ = this.Collapsed_Coverage_Intervals(context, kzzzzzzzzzzi_);
            IEnumerable<CqlInterval<CqlDate>> kzzzzzzzzzzn_ = this.Collapsed_Coverage_Adjacent_Intervals(context, kzzzzzzzzzzm_);
            IEnumerable<CqlInterval<CqlDate>> kzzzzzzzzzzp_ = this.Collapsed_Coverage_Intervals(context, kzzzzzzzzzzi_);
            IEnumerable<CqlInterval<CqlDate>> kzzzzzzzzzzr_ = this.Collapsed_Coverage_Intervals(context, kzzzzzzzzzzi_);
            IEnumerable<CqlInterval<CqlDate>> kzzzzzzzzzzs_ = this.Collapsed_Coverage_Adjacent_Intervals(context, kzzzzzzzzzzr_);
            IEnumerable<CqlInterval<CqlDate>> kzzzzzzzzzzt_ = this.Collapsed_Final_Coverage_Intervals(context, kzzzzzzzzzzp_, kzzzzzzzzzzs_);
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? kzzzzzzzzzzu_ = (CqlTupleMetadata_DPLIOBaSciHAAETJOMSIjWgbP, kzzzzzzzzzzi_, kzzzzzzzzzzk_, kzzzzzzzzzzn_, kzzzzzzzzzzt_);

            return kzzzzzzzzzzu_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> kzzzzzzzzzzg_ = context.Operators.Select<Coverage, (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?>(Coverage, kzzzzzzzzzzf_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> kzzzzzzzzzzh_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?>(kzzzzzzzzzzg_);

        return kzzzzzzzzzzh_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<Coverage> Health_Plan_Coverage_Resources(CqlContext context, IEnumerable<Coverage> Coverage)
    {
        bool? kzzzzzzzzzzv_(Coverage C)
        {
            CodeableConcept kzzzzzzzzzzz_ = C?.Type;
            List<Coding> lzzzzzzzzzza_ = kzzzzzzzzzzz_?.Coding;
            bool? lzzzzzzzzzzb_(Coding cTypeCoding)
            {
                CqlCode lzzzzzzzzzze_ = FHIRHelpers_4_0_001.Instance.ToCode(context, cTypeCoding);
                CqlCode lzzzzzzzzzzf_ = NCQATerminology_1_0_0.Instance.managed_care_policy(context);
                bool? lzzzzzzzzzzg_ = context.Operators.Equivalent(lzzzzzzzzzze_, lzzzzzzzzzzf_);
                CqlCode lzzzzzzzzzzi_ = NCQATerminology_1_0_0.Instance.retiree_health_program(context);
                bool? lzzzzzzzzzzj_ = context.Operators.Equivalent(lzzzzzzzzzze_, lzzzzzzzzzzi_);
                bool? lzzzzzzzzzzk_ = context.Operators.Or(lzzzzzzzzzzg_, lzzzzzzzzzzj_);
                CqlCode lzzzzzzzzzzm_ = NCQATerminology_1_0_0.Instance.subsidized_health_program(context);
                bool? lzzzzzzzzzzn_ = context.Operators.Equivalent(lzzzzzzzzzze_, lzzzzzzzzzzm_);
                bool? lzzzzzzzzzzo_ = context.Operators.Or(lzzzzzzzzzzk_, lzzzzzzzzzzn_);

                return lzzzzzzzzzzo_;
            };
            IEnumerable<Coding> lzzzzzzzzzzc_ = context.Operators.Where<Coding>((IEnumerable<Coding>)lzzzzzzzzzza_, lzzzzzzzzzzb_);
            bool? lzzzzzzzzzzd_ = context.Operators.Exists<Coding>(lzzzzzzzzzzc_);

            return lzzzzzzzzzzd_;
        };
        IEnumerable<Coverage> kzzzzzzzzzzw_ = context.Operators.Where<Coverage>(Coverage, kzzzzzzzzzzv_);
        bool? kzzzzzzzzzzx_(Coverage HPCoverageResource)
        {
            bool? lzzzzzzzzzzp_ = context.Operators.Not((bool?)(HPCoverageResource is null));

            return lzzzzzzzzzzp_;
        };
        IEnumerable<Coverage> kzzzzzzzzzzy_ = context.Operators.Where<Coverage>(kzzzzzzzzzzw_, kzzzzzzzzzzx_);

        return kzzzzzzzzzzy_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public bool? Anchor_Date_Criteria(CqlContext context, IEnumerable<Coverage> Coverage, CqlDate AnchorDate, CqlInterval<CqlDate> participationPeriod)
    {
        bool? lzzzzzzzzzzq_()
        {
            bool lzzzzzzzzzzr_()
            {
                bool? lzzzzzzzzzzs_ = context.Operators.In<CqlDate>(AnchorDate, participationPeriod, default);
                bool? lzzzzzzzzzzt_ = context.Operators.Not(lzzzzzzzzzzs_);

                return lzzzzzzzzzzt_ ?? false;
            };
            if ((context.Operators.In<CqlDate>(AnchorDate, participationPeriod, default)) ?? false)
            {
                IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> lzzzzzzzzzzu_ = this.All_Coverage_Info(context, Coverage, participationPeriod);
                bool? lzzzzzzzzzzv_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? @this)
                {
                    IEnumerable<CqlInterval<CqlDate>> mzzzzzzzzzzd_ = @this?.CollapsedFinal;
                    bool? mzzzzzzzzzze_ = context.Operators.Not((bool?)(mzzzzzzzzzzd_ is null));

                    return mzzzzzzzzzze_;
                };
                IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> lzzzzzzzzzzw_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?>(lzzzzzzzzzzu_, lzzzzzzzzzzv_);
                IEnumerable<CqlInterval<CqlDate>> lzzzzzzzzzzx_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? @this)
                {
                    IEnumerable<CqlInterval<CqlDate>> mzzzzzzzzzzf_ = @this?.CollapsedFinal;

                    return mzzzzzzzzzzf_;
                };
                IEnumerable<IEnumerable<CqlInterval<CqlDate>>> lzzzzzzzzzzy_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?, IEnumerable<CqlInterval<CqlDate>>>(lzzzzzzzzzzw_, lzzzzzzzzzzx_);
                IEnumerable<CqlInterval<CqlDate>> lzzzzzzzzzzz_ = context.Operators.Flatten<CqlInterval<CqlDate>>(lzzzzzzzzzzy_);
                bool? mzzzzzzzzzza_(CqlInterval<CqlDate> FinalInterval)
                {
                    bool? mzzzzzzzzzzg_ = context.Operators.In<CqlDate>(AnchorDate, FinalInterval, default);

                    return mzzzzzzzzzzg_;
                };
                IEnumerable<CqlInterval<CqlDate>> mzzzzzzzzzzb_ = context.Operators.Where<CqlInterval<CqlDate>>(lzzzzzzzzzzz_, mzzzzzzzzzza_);
                bool? mzzzzzzzzzzc_ = context.Operators.Exists<CqlInterval<CqlDate>>(mzzzzzzzzzzb_);

                return mzzzzzzzzzzc_;
            }
            else if (lzzzzzzzzzzr_())
            {
                bool? mzzzzzzzzzzh_(Coverage @this)
                {
                    Period mzzzzzzzzzzo_ = @this?.Period;
                    bool? mzzzzzzzzzzp_ = context.Operators.Not((bool?)(mzzzzzzzzzzo_ is null));

                    return mzzzzzzzzzzp_;
                };
                IEnumerable<Coverage> mzzzzzzzzzzi_ = context.Operators.Where<Coverage>(Coverage, mzzzzzzzzzzh_);
                Period mzzzzzzzzzzj_(Coverage @this)
                {
                    Period mzzzzzzzzzzq_ = @this?.Period;

                    return mzzzzzzzzzzq_;
                };
                IEnumerable<Period> mzzzzzzzzzzk_ = context.Operators.Select<Coverage, Period>(mzzzzzzzzzzi_, mzzzzzzzzzzj_);
                bool? mzzzzzzzzzzl_(Period Cperiod)
                {
                    CqlInterval<CqlDateTime> mzzzzzzzzzzr_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, Cperiod as object);
                    CqlDateTime mzzzzzzzzzzs_ = context.Operators.Start(mzzzzzzzzzzr_);
                    CqlDate mzzzzzzzzzzt_ = context.Operators.DateFrom(mzzzzzzzzzzs_);
                    CqlDateTime mzzzzzzzzzzv_ = context.Operators.End(mzzzzzzzzzzr_);
                    CqlDate mzzzzzzzzzzw_ = context.Operators.DateFrom(mzzzzzzzzzzv_);
                    CqlInterval<CqlDate> mzzzzzzzzzzx_ = context.Operators.Interval(mzzzzzzzzzzt_, mzzzzzzzzzzw_, true, true);
                    bool? mzzzzzzzzzzy_ = context.Operators.In<CqlDate>(AnchorDate, mzzzzzzzzzzx_, default);

                    return mzzzzzzzzzzy_;
                };
                IEnumerable<Period> mzzzzzzzzzzm_ = context.Operators.Where<Period>(mzzzzzzzzzzk_, mzzzzzzzzzzl_);
                bool? mzzzzzzzzzzn_ = context.Operators.Exists<Period>(mzzzzzzzzzzm_);

                return mzzzzzzzzzzn_;
            }
            else if (AnchorDate is null)
            {
                return true;
            }
            else
            {
                return false;
            }
        };

        return lzzzzzzzzzzq_();
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public bool? Health_Plan_Enrollment_Criteria(CqlContext context, IEnumerable<Coverage> Coverage, CqlDate AnchorDate, CqlInterval<CqlDate> participationPeriod, int? AllowedGapDays)
    {
        IEnumerable<Coverage> mzzzzzzzzzzz_ = this.Health_Plan_Coverage_Resources(context, Coverage);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> nzzzzzzzzzza_ = this.All_Coverage_Info(context, mzzzzzzzzzzz_, participationPeriod);
        bool? nzzzzzzzzzzb_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? @this)
        {
            IEnumerable<CqlInterval<CqlDate>> nzzzzzzzzzzm_ = @this?.CollapsedFinal;
            bool? nzzzzzzzzzzn_ = context.Operators.Not((bool?)(nzzzzzzzzzzm_ is null));

            return nzzzzzzzzzzn_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> nzzzzzzzzzzc_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?>(nzzzzzzzzzza_, nzzzzzzzzzzb_);
        IEnumerable<CqlInterval<CqlDate>> nzzzzzzzzzzd_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? @this)
        {
            IEnumerable<CqlInterval<CqlDate>> nzzzzzzzzzzo_ = @this?.CollapsedFinal;

            return nzzzzzzzzzzo_;
        };
        IEnumerable<IEnumerable<CqlInterval<CqlDate>>> nzzzzzzzzzze_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?, IEnumerable<CqlInterval<CqlDate>>>(nzzzzzzzzzzc_, nzzzzzzzzzzd_);
        IEnumerable<CqlInterval<CqlDate>> nzzzzzzzzzzf_ = context.Operators.Flatten<CqlInterval<CqlDate>>(nzzzzzzzzzze_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? nzzzzzzzzzzg_ = NCQACQLBase_1_0_0.Instance.Date_Interval_Gaps_Relative_to_Base_Interval_Stats(context, participationPeriod, nzzzzzzzzzzf_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?[] nzzzzzzzzzzh_ = [
            nzzzzzzzzzzg_,
        ];
        bool? nzzzzzzzzzzi_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? GapsInEnrollment)
        {
            int? nzzzzzzzzzzp_ = GapsInEnrollment?.Interval_Count;
            bool? nzzzzzzzzzzq_ = context.Operators.LessOrEqual(nzzzzzzzzzzp_, 1);
            int? nzzzzzzzzzzr_ = GapsInEnrollment?.Total_Days_In_Longest_Interval;
            bool? nzzzzzzzzzzs_ = context.Operators.LessOrEqual(nzzzzzzzzzzr_, AllowedGapDays);
            bool? nzzzzzzzzzzt_ = context.Operators.And(nzzzzzzzzzzq_, nzzzzzzzzzzs_);
            bool? nzzzzzzzzzzu_ = this.Anchor_Date_Criteria(context, Coverage, AnchorDate, participationPeriod);
            bool? nzzzzzzzzzzv_ = context.Operators.And(nzzzzzzzzzzt_, nzzzzzzzzzzu_);

            return nzzzzzzzzzzv_;
        };
        IEnumerable<bool?> nzzzzzzzzzzj_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?, bool?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>)nzzzzzzzzzzh_, nzzzzzzzzzzi_);
        IEnumerable<bool?> nzzzzzzzzzzk_ = context.Operators.Distinct<bool?>(nzzzzzzzzzzj_);
        bool? nzzzzzzzzzzl_ = context.Operators.SingletonFrom<bool?>(nzzzzzzzzzzk_);

        return nzzzzzzzzzzl_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<Coverage> Pharmacy_Benefit_Coverage_Resources(CqlContext context, IEnumerable<Coverage> Coverage)
    {
        bool? nzzzzzzzzzzw_(Coverage C)
        {
            CodeableConcept ozzzzzzzzzza_ = C?.Type;
            List<Coding> ozzzzzzzzzzb_ = ozzzzzzzzzza_?.Coding;
            bool? ozzzzzzzzzzc_(Coding cTypeCoding)
            {
                CqlCode ozzzzzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToCode(context, cTypeCoding);
                CqlCode ozzzzzzzzzzg_ = NCQATerminology_1_0_0.Instance.drug_policy(context);
                bool? ozzzzzzzzzzh_ = context.Operators.Equivalent(ozzzzzzzzzzf_, ozzzzzzzzzzg_);

                return ozzzzzzzzzzh_;
            };
            IEnumerable<Coding> ozzzzzzzzzzd_ = context.Operators.Where<Coding>((IEnumerable<Coding>)ozzzzzzzzzzb_, ozzzzzzzzzzc_);
            bool? ozzzzzzzzzze_ = context.Operators.Exists<Coding>(ozzzzzzzzzzd_);

            return ozzzzzzzzzze_;
        };
        IEnumerable<Coverage> nzzzzzzzzzzx_ = context.Operators.Where<Coverage>(Coverage, nzzzzzzzzzzw_);
        bool? nzzzzzzzzzzy_(Coverage pharmacyCoverageResource)
        {
            bool? ozzzzzzzzzzi_ = context.Operators.Not((bool?)(pharmacyCoverageResource is null));

            return ozzzzzzzzzzi_;
        };
        IEnumerable<Coverage> nzzzzzzzzzzz_ = context.Operators.Where<Coverage>(nzzzzzzzzzzx_, nzzzzzzzzzzy_);

        return nzzzzzzzzzzz_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public bool? Pharmacy_Benefit_Enrollment_Criteria(CqlContext context, IEnumerable<Coverage> PharmCoverage, CqlDate AnchorDate, CqlInterval<CqlDate> participationPeriod, int? AllowedGapDays)
    {
        IEnumerable<Coverage> ozzzzzzzzzzj_ = this.Pharmacy_Benefit_Coverage_Resources(context, PharmCoverage);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> ozzzzzzzzzzk_ = this.All_Coverage_Info(context, ozzzzzzzzzzj_, participationPeriod);
        bool? ozzzzzzzzzzl_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? @this)
        {
            IEnumerable<CqlInterval<CqlDate>> ozzzzzzzzzzw_ = @this?.CollapsedFinal;
            bool? ozzzzzzzzzzx_ = context.Operators.Not((bool?)(ozzzzzzzzzzw_ is null));

            return ozzzzzzzzzzx_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> ozzzzzzzzzzm_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?>(ozzzzzzzzzzk_, ozzzzzzzzzzl_);
        IEnumerable<CqlInterval<CqlDate>> ozzzzzzzzzzn_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? @this)
        {
            IEnumerable<CqlInterval<CqlDate>> ozzzzzzzzzzy_ = @this?.CollapsedFinal;

            return ozzzzzzzzzzy_;
        };
        IEnumerable<IEnumerable<CqlInterval<CqlDate>>> ozzzzzzzzzzo_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?, IEnumerable<CqlInterval<CqlDate>>>(ozzzzzzzzzzm_, ozzzzzzzzzzn_);
        IEnumerable<CqlInterval<CqlDate>> ozzzzzzzzzzp_ = context.Operators.Flatten<CqlInterval<CqlDate>>(ozzzzzzzzzzo_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? ozzzzzzzzzzq_ = NCQACQLBase_1_0_0.Instance.Date_Interval_Gaps_Relative_to_Base_Interval_Stats(context, participationPeriod, ozzzzzzzzzzp_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?[] ozzzzzzzzzzr_ = [
            ozzzzzzzzzzq_,
        ];
        bool? ozzzzzzzzzzs_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? GapsInEnrollment)
        {
            int? ozzzzzzzzzzz_ = GapsInEnrollment?.Interval_Count;
            bool? pzzzzzzzzzza_ = context.Operators.LessOrEqual(ozzzzzzzzzzz_, 1);
            int? pzzzzzzzzzzb_ = GapsInEnrollment?.Total_Days_In_Longest_Interval;
            bool? pzzzzzzzzzzc_ = context.Operators.LessOrEqual(pzzzzzzzzzzb_, AllowedGapDays);
            bool? pzzzzzzzzzzd_ = context.Operators.And(pzzzzzzzzzza_, pzzzzzzzzzzc_);
            bool? pzzzzzzzzzze_ = this.Anchor_Date_Criteria(context, PharmCoverage, AnchorDate, participationPeriod);
            bool? pzzzzzzzzzzf_ = context.Operators.And(pzzzzzzzzzzd_, pzzzzzzzzzze_);

            return pzzzzzzzzzzf_;
        };
        IEnumerable<bool?> ozzzzzzzzzzt_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?, bool?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>)ozzzzzzzzzzr_, ozzzzzzzzzzs_);
        IEnumerable<bool?> ozzzzzzzzzzu_ = context.Operators.Distinct<bool?>(ozzzzzzzzzzt_);
        bool? ozzzzzzzzzzv_ = context.Operators.SingletonFrom<bool?>(ozzzzzzzzzzu_);

        return ozzzzzzzzzzv_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<Coverage> Mental_Health_Benefit_Coverage_Resources(CqlContext context, IEnumerable<Coverage> Coverage)
    {
        bool? pzzzzzzzzzzg_(Coverage C)
        {
            CodeableConcept pzzzzzzzzzzk_ = C?.Type;
            List<Coding> pzzzzzzzzzzl_ = pzzzzzzzzzzk_?.Coding;
            bool? pzzzzzzzzzzm_(Coding cTypeCoding)
            {
                CqlCode pzzzzzzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToCode(context, cTypeCoding);
                CqlCode pzzzzzzzzzzq_ = NCQATerminology_1_0_0.Instance.mental_health_policy(context);
                bool? pzzzzzzzzzzr_ = context.Operators.Equivalent(pzzzzzzzzzzp_, pzzzzzzzzzzq_);

                return pzzzzzzzzzzr_;
            };
            IEnumerable<Coding> pzzzzzzzzzzn_ = context.Operators.Where<Coding>((IEnumerable<Coding>)pzzzzzzzzzzl_, pzzzzzzzzzzm_);
            bool? pzzzzzzzzzzo_ = context.Operators.Exists<Coding>(pzzzzzzzzzzn_);

            return pzzzzzzzzzzo_;
        };
        IEnumerable<Coverage> pzzzzzzzzzzh_ = context.Operators.Where<Coverage>(Coverage, pzzzzzzzzzzg_);
        bool? pzzzzzzzzzzi_(Coverage mentalHealthCoverageResource)
        {
            bool? pzzzzzzzzzzs_ = context.Operators.Not((bool?)(mentalHealthCoverageResource is null));

            return pzzzzzzzzzzs_;
        };
        IEnumerable<Coverage> pzzzzzzzzzzj_ = context.Operators.Where<Coverage>(pzzzzzzzzzzh_, pzzzzzzzzzzi_);

        return pzzzzzzzzzzj_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public bool? Mental_Health_Benefit_Enrollment_Criteria(CqlContext context, IEnumerable<Coverage> MHCoverage, CqlDate AnchorDate, CqlInterval<CqlDate> participationPeriod, int? AllowedGapDays)
    {
        IEnumerable<Coverage> pzzzzzzzzzzt_ = this.Mental_Health_Benefit_Coverage_Resources(context, MHCoverage);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> pzzzzzzzzzzu_ = this.All_Coverage_Info(context, pzzzzzzzzzzt_, participationPeriod);
        bool? pzzzzzzzzzzv_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? @this)
        {
            IEnumerable<CqlInterval<CqlDate>> qzzzzzzzzzzg_ = @this?.CollapsedFinal;
            bool? qzzzzzzzzzzh_ = context.Operators.Not((bool?)(qzzzzzzzzzzg_ is null));

            return qzzzzzzzzzzh_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> pzzzzzzzzzzw_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?>(pzzzzzzzzzzu_, pzzzzzzzzzzv_);
        IEnumerable<CqlInterval<CqlDate>> pzzzzzzzzzzx_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? @this)
        {
            IEnumerable<CqlInterval<CqlDate>> qzzzzzzzzzzi_ = @this?.CollapsedFinal;

            return qzzzzzzzzzzi_;
        };
        IEnumerable<IEnumerable<CqlInterval<CqlDate>>> pzzzzzzzzzzy_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?, IEnumerable<CqlInterval<CqlDate>>>(pzzzzzzzzzzw_, pzzzzzzzzzzx_);
        IEnumerable<CqlInterval<CqlDate>> pzzzzzzzzzzz_ = context.Operators.Flatten<CqlInterval<CqlDate>>(pzzzzzzzzzzy_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? qzzzzzzzzzza_ = NCQACQLBase_1_0_0.Instance.Date_Interval_Gaps_Relative_to_Base_Interval_Stats(context, participationPeriod, pzzzzzzzzzzz_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?[] qzzzzzzzzzzb_ = [
            qzzzzzzzzzza_,
        ];
        bool? qzzzzzzzzzzc_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? GapsInEnrollment)
        {
            int? qzzzzzzzzzzj_ = GapsInEnrollment?.Interval_Count;
            bool? qzzzzzzzzzzk_ = context.Operators.LessOrEqual(qzzzzzzzzzzj_, 1);
            int? qzzzzzzzzzzl_ = GapsInEnrollment?.Total_Days_In_Longest_Interval;
            bool? qzzzzzzzzzzm_ = context.Operators.LessOrEqual(qzzzzzzzzzzl_, AllowedGapDays);
            bool? qzzzzzzzzzzn_ = context.Operators.And(qzzzzzzzzzzk_, qzzzzzzzzzzm_);
            bool? qzzzzzzzzzzo_ = this.Anchor_Date_Criteria(context, MHCoverage, AnchorDate, participationPeriod);
            bool? qzzzzzzzzzzp_ = context.Operators.And(qzzzzzzzzzzn_, qzzzzzzzzzzo_);

            return qzzzzzzzzzzp_;
        };
        IEnumerable<bool?> qzzzzzzzzzzd_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?, bool?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>)qzzzzzzzzzzb_, qzzzzzzzzzzc_);
        IEnumerable<bool?> qzzzzzzzzzze_ = context.Operators.Distinct<bool?>(qzzzzzzzzzzd_);
        bool? qzzzzzzzzzzf_ = context.Operators.SingletonFrom<bool?>(qzzzzzzzzzze_);

        return qzzzzzzzzzzf_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_BaNHUZXcQBUKLNgEDWdDHjYV = new(
        [typeof(CqlInterval<CqlDate>), typeof(CqlInterval<CqlDate>)],
        ["Coverage1", "Coverage2"]);

    private static CqlTupleMetadata CqlTupleMetadata_DPLIOBaSciHAAETJOMSIjWgbP = new(
        [typeof(IEnumerable<CqlInterval<CqlDate>>), typeof(IEnumerable<CqlInterval<CqlDate>>), typeof(IEnumerable<CqlInterval<CqlDate>>), typeof(IEnumerable<CqlInterval<CqlDate>>)],
        ["IntervalInfo", "Collapsed", "Adjacent", "CollapsedFinal"]);

    #endregion CqlTupleMetadata Properties

}
