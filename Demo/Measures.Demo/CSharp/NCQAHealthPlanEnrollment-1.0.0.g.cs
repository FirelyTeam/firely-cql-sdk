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

    [CqlExpressionDefinition("CoverageIntervals")]
    public IEnumerable<CqlInterval<CqlDate>> CoverageIntervals(CqlContext context, IEnumerable<Coverage> Coverage, CqlInterval<CqlDate> participationPeriod)
    {
        CqlInterval<CqlDate> dzzzzzzzzzzzw_(Coverage C)
        {
            Period dzzzzzzzzzzzz_ = C?.Period;
            CqlInterval<CqlDateTime> ezzzzzzzzzzza_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, dzzzzzzzzzzzz_ as object);
            CqlDateTime ezzzzzzzzzzzb_ = context.Operators.Start(ezzzzzzzzzzza_);
            CqlDate ezzzzzzzzzzzc_ = context.Operators.DateFrom(ezzzzzzzzzzzb_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzze_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, dzzzzzzzzzzzz_ as object);
            CqlDateTime ezzzzzzzzzzzf_ = context.Operators.End(ezzzzzzzzzzze_);
            CqlDate ezzzzzzzzzzzg_ = context.Operators.DateFrom(ezzzzzzzzzzzf_);
            CqlInterval<CqlDate> ezzzzzzzzzzzh_ = context.Operators.Interval(ezzzzzzzzzzzc_, ezzzzzzzzzzzg_, true, true);
            CqlDate ezzzzzzzzzzzi_ = context.Operators.Start(participationPeriod);
            CqlDate ezzzzzzzzzzzj_ = context.Operators.End(participationPeriod);
            CqlInterval<CqlDate> ezzzzzzzzzzzk_ = context.Operators.Interval(ezzzzzzzzzzzi_, ezzzzzzzzzzzj_, true, true);
            CqlInterval<CqlDate> ezzzzzzzzzzzl_ = context.Operators.Intersect<CqlDate>(ezzzzzzzzzzzh_, ezzzzzzzzzzzk_);

            return ezzzzzzzzzzzl_;
        };
        IEnumerable<CqlInterval<CqlDate>> dzzzzzzzzzzzx_ = context.Operators.Select<Coverage, CqlInterval<CqlDate>>(Coverage, dzzzzzzzzzzzw_);
        IEnumerable<CqlInterval<CqlDate>> dzzzzzzzzzzzy_ = context.Operators.Distinct<CqlInterval<CqlDate>>(dzzzzzzzzzzzx_);

        return dzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Collapsed Coverage Intervals")]
    public IEnumerable<CqlInterval<CqlDate>> Collapsed_Coverage_Intervals(CqlContext context, IEnumerable<CqlInterval<CqlDate>> Intervals)
    {
        IEnumerable<CqlInterval<CqlDate>> ezzzzzzzzzzzm_ = NCQACQLBase_1_0_0.Instance.Collapse_Date_Interval_Workaround(context, Intervals);

        return ezzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Collapsed Coverage Adjacent Intervals")]
    public IEnumerable<CqlInterval<CqlDate>> Collapsed_Coverage_Adjacent_Intervals(CqlContext context, IEnumerable<CqlInterval<CqlDate>> Intervals)
    {
        IEnumerable<ValueTuple<CqlInterval<CqlDate>, CqlInterval<CqlDate>>> ezzzzzzzzzzzn_ = context.Operators.CrossJoin<CqlInterval<CqlDate>, CqlInterval<CqlDate>>(Intervals, Intervals);
        (CqlTupleMetadata, CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)? ezzzzzzzzzzzo_(ValueTuple<CqlInterval<CqlDate>, CqlInterval<CqlDate>> _valueTuple)
        {
            (CqlTupleMetadata, CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)? ezzzzzzzzzzzv_ = (CqlTupleMetadata_BaNHUZXcQBUKLNgEDWdDHjYV, _valueTuple.Item1, _valueTuple.Item2);

            return ezzzzzzzzzzzv_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)?> ezzzzzzzzzzzp_ = context.Operators.Select<ValueTuple<CqlInterval<CqlDate>, CqlInterval<CqlDate>>, (CqlTupleMetadata, CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)?>(ezzzzzzzzzzzn_, ezzzzzzzzzzzo_);
        bool? ezzzzzzzzzzzq_((CqlTupleMetadata, CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)? tuple_banhuzxcqbuklngedwddhjyv)
        {
            CqlDate ezzzzzzzzzzzw_ = context.Operators.End(tuple_banhuzxcqbuklngedwddhjyv?.Coverage1);
            CqlDate ezzzzzzzzzzzx_ = context.Operators.Start(tuple_banhuzxcqbuklngedwddhjyv?.Coverage2);
            CqlQuantity ezzzzzzzzzzzy_ = context.Operators.Quantity(1m, "day");
            CqlDate ezzzzzzzzzzzz_ = context.Operators.Subtract(ezzzzzzzzzzzx_, ezzzzzzzzzzzy_);
            CqlDate fzzzzzzzzzzzc_ = context.Operators.Add(ezzzzzzzzzzzx_, ezzzzzzzzzzzy_);
            CqlInterval<CqlDate> fzzzzzzzzzzzd_ = context.Operators.Interval(ezzzzzzzzzzzz_, fzzzzzzzzzzzc_, true, true);
            bool? fzzzzzzzzzzze_ = context.Operators.In<CqlDate>(ezzzzzzzzzzzw_, fzzzzzzzzzzzd_, default);
            bool? fzzzzzzzzzzzg_ = context.Operators.Not((bool?)(ezzzzzzzzzzzx_ is null));
            bool? fzzzzzzzzzzzh_ = context.Operators.And(fzzzzzzzzzzze_, fzzzzzzzzzzzg_);

            return fzzzzzzzzzzzh_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)?> ezzzzzzzzzzzr_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)?>(ezzzzzzzzzzzp_, ezzzzzzzzzzzq_);
        CqlInterval<CqlDate> ezzzzzzzzzzzs_((CqlTupleMetadata, CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)? tuple_banhuzxcqbuklngedwddhjyv)
        {
            CqlDate fzzzzzzzzzzzi_ = context.Operators.Start(tuple_banhuzxcqbuklngedwddhjyv?.Coverage1);
            CqlDate fzzzzzzzzzzzj_ = context.Operators.End(tuple_banhuzxcqbuklngedwddhjyv?.Coverage2);
            CqlInterval<CqlDate> fzzzzzzzzzzzk_ = context.Operators.Interval(fzzzzzzzzzzzi_, fzzzzzzzzzzzj_, true, true);

            return fzzzzzzzzzzzk_;
        };
        IEnumerable<CqlInterval<CqlDate>> ezzzzzzzzzzzt_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)?, CqlInterval<CqlDate>>(ezzzzzzzzzzzr_, ezzzzzzzzzzzs_);
        IEnumerable<CqlInterval<CqlDate>> ezzzzzzzzzzzu_ = context.Operators.Distinct<CqlInterval<CqlDate>>(ezzzzzzzzzzzt_);

        return ezzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Collapsed Final Coverage Intervals")]
    public IEnumerable<CqlInterval<CqlDate>> Collapsed_Final_Coverage_Intervals(CqlContext context, IEnumerable<CqlInterval<CqlDate>> collapsedI, IEnumerable<CqlInterval<CqlDate>> adjacentI)
    {
        IEnumerable<CqlInterval<CqlDate>> fzzzzzzzzzzzl_ = this.Collapsed_Coverage_Intervals(context, collapsedI);
        IEnumerable<CqlInterval<CqlDate>> fzzzzzzzzzzzm_ = this.Collapsed_Coverage_Adjacent_Intervals(context, adjacentI);
        IEnumerable<CqlInterval<CqlDate>> fzzzzzzzzzzzn_ = context.Operators.Union<CqlInterval<CqlDate>>(fzzzzzzzzzzzl_, fzzzzzzzzzzzm_);
        IEnumerable<CqlInterval<CqlDate>> fzzzzzzzzzzzo_ = NCQACQLBase_1_0_0.Instance.Collapse_Date_Interval_Workaround(context, fzzzzzzzzzzzn_);

        return fzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("All Coverage Info")]
    public IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> All_Coverage_Info(CqlContext context, IEnumerable<Coverage> Coverage, CqlInterval<CqlDate> participationPeriod)
    {
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? fzzzzzzzzzzzp_(Coverage C)
        {
            IEnumerable<CqlInterval<CqlDate>> fzzzzzzzzzzzs_ = this.CoverageIntervals(context, Coverage, participationPeriod);
            IEnumerable<CqlInterval<CqlDate>> fzzzzzzzzzzzu_ = this.Collapsed_Coverage_Intervals(context, fzzzzzzzzzzzs_);
            IEnumerable<CqlInterval<CqlDate>> fzzzzzzzzzzzw_ = this.Collapsed_Coverage_Intervals(context, fzzzzzzzzzzzs_);
            IEnumerable<CqlInterval<CqlDate>> fzzzzzzzzzzzx_ = this.Collapsed_Coverage_Adjacent_Intervals(context, fzzzzzzzzzzzw_);
            IEnumerable<CqlInterval<CqlDate>> fzzzzzzzzzzzz_ = this.Collapsed_Coverage_Intervals(context, fzzzzzzzzzzzs_);
            IEnumerable<CqlInterval<CqlDate>> gzzzzzzzzzzzb_ = this.Collapsed_Coverage_Intervals(context, fzzzzzzzzzzzs_);
            IEnumerable<CqlInterval<CqlDate>> gzzzzzzzzzzzc_ = this.Collapsed_Coverage_Adjacent_Intervals(context, gzzzzzzzzzzzb_);
            IEnumerable<CqlInterval<CqlDate>> gzzzzzzzzzzzd_ = this.Collapsed_Final_Coverage_Intervals(context, fzzzzzzzzzzzz_, gzzzzzzzzzzzc_);
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? gzzzzzzzzzzze_ = (CqlTupleMetadata_DPLIOBaSciHAAETJOMSIjWgbP, fzzzzzzzzzzzs_, fzzzzzzzzzzzu_, fzzzzzzzzzzzx_, gzzzzzzzzzzzd_);

            return gzzzzzzzzzzze_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> fzzzzzzzzzzzq_ = context.Operators.Select<Coverage, (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?>(Coverage, fzzzzzzzzzzzp_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> fzzzzzzzzzzzr_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?>(fzzzzzzzzzzzq_);

        return fzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Health Plan Coverage Resources")]
    public IEnumerable<Coverage> Health_Plan_Coverage_Resources(CqlContext context, IEnumerable<Coverage> Coverage)
    {
        bool? gzzzzzzzzzzzf_(Coverage C)
        {
            CodeableConcept gzzzzzzzzzzzj_ = C?.Type;
            List<Coding> gzzzzzzzzzzzk_ = gzzzzzzzzzzzj_?.Coding;
            bool? gzzzzzzzzzzzl_(Coding cTypeCoding)
            {
                CqlCode gzzzzzzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToCode(context, cTypeCoding);
                CqlCode gzzzzzzzzzzzp_ = NCQATerminology_1_0_0.Instance.managed_care_policy(context);
                bool? gzzzzzzzzzzzq_ = context.Operators.Equivalent(gzzzzzzzzzzzo_, gzzzzzzzzzzzp_);
                CqlCode gzzzzzzzzzzzs_ = NCQATerminology_1_0_0.Instance.retiree_health_program(context);
                bool? gzzzzzzzzzzzt_ = context.Operators.Equivalent(gzzzzzzzzzzzo_, gzzzzzzzzzzzs_);
                bool? gzzzzzzzzzzzu_ = context.Operators.Or(gzzzzzzzzzzzq_, gzzzzzzzzzzzt_);
                CqlCode gzzzzzzzzzzzw_ = NCQATerminology_1_0_0.Instance.subsidized_health_program(context);
                bool? gzzzzzzzzzzzx_ = context.Operators.Equivalent(gzzzzzzzzzzzo_, gzzzzzzzzzzzw_);
                bool? gzzzzzzzzzzzy_ = context.Operators.Or(gzzzzzzzzzzzu_, gzzzzzzzzzzzx_);

                return gzzzzzzzzzzzy_;
            };
            IEnumerable<Coding> gzzzzzzzzzzzm_ = context.Operators.Where<Coding>((IEnumerable<Coding>)gzzzzzzzzzzzk_, gzzzzzzzzzzzl_);
            bool? gzzzzzzzzzzzn_ = context.Operators.Exists<Coding>(gzzzzzzzzzzzm_);

            return gzzzzzzzzzzzn_;
        };
        IEnumerable<Coverage> gzzzzzzzzzzzg_ = context.Operators.Where<Coverage>(Coverage, gzzzzzzzzzzzf_);
        bool? gzzzzzzzzzzzh_(Coverage HPCoverageResource)
        {
            bool? gzzzzzzzzzzzz_ = context.Operators.Not((bool?)(HPCoverageResource is null));

            return gzzzzzzzzzzzz_;
        };
        IEnumerable<Coverage> gzzzzzzzzzzzi_ = context.Operators.Where<Coverage>(gzzzzzzzzzzzg_, gzzzzzzzzzzzh_);

        return gzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Anchor Date Criteria")]
    public bool? Anchor_Date_Criteria(CqlContext context, IEnumerable<Coverage> Coverage, CqlDate AnchorDate, CqlInterval<CqlDate> participationPeriod)
    {
        bool? hzzzzzzzzzzza_()
        {
            bool hzzzzzzzzzzzb_()
            {
                bool? hzzzzzzzzzzzc_ = context.Operators.In<CqlDate>(AnchorDate, participationPeriod, default);
                bool? hzzzzzzzzzzzd_ = context.Operators.Not(hzzzzzzzzzzzc_);

                return hzzzzzzzzzzzd_ ?? false;
            };
            if ((context.Operators.In<CqlDate>(AnchorDate, participationPeriod, default)) ?? false)
            {
                IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> hzzzzzzzzzzze_ = this.All_Coverage_Info(context, Coverage, participationPeriod);
                bool? hzzzzzzzzzzzf_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? @this)
                {
                    IEnumerable<CqlInterval<CqlDate>> hzzzzzzzzzzzn_ = @this?.CollapsedFinal;
                    bool? hzzzzzzzzzzzo_ = context.Operators.Not((bool?)(hzzzzzzzzzzzn_ is null));

                    return hzzzzzzzzzzzo_;
                };
                IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> hzzzzzzzzzzzg_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?>(hzzzzzzzzzzze_, hzzzzzzzzzzzf_);
                IEnumerable<CqlInterval<CqlDate>> hzzzzzzzzzzzh_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? @this)
                {
                    IEnumerable<CqlInterval<CqlDate>> hzzzzzzzzzzzp_ = @this?.CollapsedFinal;

                    return hzzzzzzzzzzzp_;
                };
                IEnumerable<IEnumerable<CqlInterval<CqlDate>>> hzzzzzzzzzzzi_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?, IEnumerable<CqlInterval<CqlDate>>>(hzzzzzzzzzzzg_, hzzzzzzzzzzzh_);
                IEnumerable<CqlInterval<CqlDate>> hzzzzzzzzzzzj_ = context.Operators.Flatten<CqlInterval<CqlDate>>(hzzzzzzzzzzzi_);
                bool? hzzzzzzzzzzzk_(CqlInterval<CqlDate> FinalInterval)
                {
                    bool? hzzzzzzzzzzzq_ = context.Operators.In<CqlDate>(AnchorDate, FinalInterval, default);

                    return hzzzzzzzzzzzq_;
                };
                IEnumerable<CqlInterval<CqlDate>> hzzzzzzzzzzzl_ = context.Operators.Where<CqlInterval<CqlDate>>(hzzzzzzzzzzzj_, hzzzzzzzzzzzk_);
                bool? hzzzzzzzzzzzm_ = context.Operators.Exists<CqlInterval<CqlDate>>(hzzzzzzzzzzzl_);

                return hzzzzzzzzzzzm_;
            }
            else if (hzzzzzzzzzzzb_())
            {
                bool? hzzzzzzzzzzzr_(Coverage @this)
                {
                    Period hzzzzzzzzzzzy_ = @this?.Period;
                    bool? hzzzzzzzzzzzz_ = context.Operators.Not((bool?)(hzzzzzzzzzzzy_ is null));

                    return hzzzzzzzzzzzz_;
                };
                IEnumerable<Coverage> hzzzzzzzzzzzs_ = context.Operators.Where<Coverage>(Coverage, hzzzzzzzzzzzr_);
                Period hzzzzzzzzzzzt_(Coverage @this)
                {
                    Period izzzzzzzzzzza_ = @this?.Period;

                    return izzzzzzzzzzza_;
                };
                IEnumerable<Period> hzzzzzzzzzzzu_ = context.Operators.Select<Coverage, Period>(hzzzzzzzzzzzs_, hzzzzzzzzzzzt_);
                bool? hzzzzzzzzzzzv_(Period Cperiod)
                {
                    CqlInterval<CqlDateTime> izzzzzzzzzzzb_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, Cperiod as object);
                    CqlDateTime izzzzzzzzzzzc_ = context.Operators.Start(izzzzzzzzzzzb_);
                    CqlDate izzzzzzzzzzzd_ = context.Operators.DateFrom(izzzzzzzzzzzc_);
                    CqlDateTime izzzzzzzzzzzf_ = context.Operators.End(izzzzzzzzzzzb_);
                    CqlDate izzzzzzzzzzzg_ = context.Operators.DateFrom(izzzzzzzzzzzf_);
                    CqlInterval<CqlDate> izzzzzzzzzzzh_ = context.Operators.Interval(izzzzzzzzzzzd_, izzzzzzzzzzzg_, true, true);
                    bool? izzzzzzzzzzzi_ = context.Operators.In<CqlDate>(AnchorDate, izzzzzzzzzzzh_, default);

                    return izzzzzzzzzzzi_;
                };
                IEnumerable<Period> hzzzzzzzzzzzw_ = context.Operators.Where<Period>(hzzzzzzzzzzzu_, hzzzzzzzzzzzv_);
                bool? hzzzzzzzzzzzx_ = context.Operators.Exists<Period>(hzzzzzzzzzzzw_);

                return hzzzzzzzzzzzx_;
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

        return hzzzzzzzzzzza_();
    }


    [CqlExpressionDefinition("Health Plan Enrollment Criteria")]
    public bool? Health_Plan_Enrollment_Criteria(CqlContext context, IEnumerable<Coverage> Coverage, CqlDate AnchorDate, CqlInterval<CqlDate> participationPeriod, int? AllowedGapDays)
    {
        IEnumerable<Coverage> izzzzzzzzzzzj_ = this.Health_Plan_Coverage_Resources(context, Coverage);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> izzzzzzzzzzzk_ = this.All_Coverage_Info(context, izzzzzzzzzzzj_, participationPeriod);
        bool? izzzzzzzzzzzl_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? @this)
        {
            IEnumerable<CqlInterval<CqlDate>> izzzzzzzzzzzw_ = @this?.CollapsedFinal;
            bool? izzzzzzzzzzzx_ = context.Operators.Not((bool?)(izzzzzzzzzzzw_ is null));

            return izzzzzzzzzzzx_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> izzzzzzzzzzzm_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?>(izzzzzzzzzzzk_, izzzzzzzzzzzl_);
        IEnumerable<CqlInterval<CqlDate>> izzzzzzzzzzzn_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? @this)
        {
            IEnumerable<CqlInterval<CqlDate>> izzzzzzzzzzzy_ = @this?.CollapsedFinal;

            return izzzzzzzzzzzy_;
        };
        IEnumerable<IEnumerable<CqlInterval<CqlDate>>> izzzzzzzzzzzo_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?, IEnumerable<CqlInterval<CqlDate>>>(izzzzzzzzzzzm_, izzzzzzzzzzzn_);
        IEnumerable<CqlInterval<CqlDate>> izzzzzzzzzzzp_ = context.Operators.Flatten<CqlInterval<CqlDate>>(izzzzzzzzzzzo_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? izzzzzzzzzzzq_ = NCQACQLBase_1_0_0.Instance.Date_Interval_Gaps_Relative_to_Base_Interval_Stats(context, participationPeriod, izzzzzzzzzzzp_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?[] izzzzzzzzzzzr_ = [
            izzzzzzzzzzzq_,
        ];
        bool? izzzzzzzzzzzs_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? GapsInEnrollment)
        {
            int? izzzzzzzzzzzz_ = GapsInEnrollment?.Interval_Count;
            bool? jzzzzzzzzzzza_ = context.Operators.LessOrEqual(izzzzzzzzzzzz_, 1);
            int? jzzzzzzzzzzzb_ = GapsInEnrollment?.Total_Days_In_Longest_Interval;
            bool? jzzzzzzzzzzzc_ = context.Operators.LessOrEqual(jzzzzzzzzzzzb_, AllowedGapDays);
            bool? jzzzzzzzzzzzd_ = context.Operators.And(jzzzzzzzzzzza_, jzzzzzzzzzzzc_);
            bool? jzzzzzzzzzzze_ = this.Anchor_Date_Criteria(context, Coverage, AnchorDate, participationPeriod);
            bool? jzzzzzzzzzzzf_ = context.Operators.And(jzzzzzzzzzzzd_, jzzzzzzzzzzze_);

            return jzzzzzzzzzzzf_;
        };
        IEnumerable<bool?> izzzzzzzzzzzt_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?, bool?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>)izzzzzzzzzzzr_, izzzzzzzzzzzs_);
        IEnumerable<bool?> izzzzzzzzzzzu_ = context.Operators.Distinct<bool?>(izzzzzzzzzzzt_);
        bool? izzzzzzzzzzzv_ = context.Operators.SingletonFrom<bool?>(izzzzzzzzzzzu_);

        return izzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Pharmacy Benefit Coverage Resources")]
    public IEnumerable<Coverage> Pharmacy_Benefit_Coverage_Resources(CqlContext context, IEnumerable<Coverage> Coverage)
    {
        bool? jzzzzzzzzzzzg_(Coverage C)
        {
            CodeableConcept jzzzzzzzzzzzk_ = C?.Type;
            List<Coding> jzzzzzzzzzzzl_ = jzzzzzzzzzzzk_?.Coding;
            bool? jzzzzzzzzzzzm_(Coding cTypeCoding)
            {
                CqlCode jzzzzzzzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToCode(context, cTypeCoding);
                CqlCode jzzzzzzzzzzzq_ = NCQATerminology_1_0_0.Instance.drug_policy(context);
                bool? jzzzzzzzzzzzr_ = context.Operators.Equivalent(jzzzzzzzzzzzp_, jzzzzzzzzzzzq_);

                return jzzzzzzzzzzzr_;
            };
            IEnumerable<Coding> jzzzzzzzzzzzn_ = context.Operators.Where<Coding>((IEnumerable<Coding>)jzzzzzzzzzzzl_, jzzzzzzzzzzzm_);
            bool? jzzzzzzzzzzzo_ = context.Operators.Exists<Coding>(jzzzzzzzzzzzn_);

            return jzzzzzzzzzzzo_;
        };
        IEnumerable<Coverage> jzzzzzzzzzzzh_ = context.Operators.Where<Coverage>(Coverage, jzzzzzzzzzzzg_);
        bool? jzzzzzzzzzzzi_(Coverage pharmacyCoverageResource)
        {
            bool? jzzzzzzzzzzzs_ = context.Operators.Not((bool?)(pharmacyCoverageResource is null));

            return jzzzzzzzzzzzs_;
        };
        IEnumerable<Coverage> jzzzzzzzzzzzj_ = context.Operators.Where<Coverage>(jzzzzzzzzzzzh_, jzzzzzzzzzzzi_);

        return jzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Pharmacy Benefit Enrollment Criteria")]
    public bool? Pharmacy_Benefit_Enrollment_Criteria(CqlContext context, IEnumerable<Coverage> PharmCoverage, CqlDate AnchorDate, CqlInterval<CqlDate> participationPeriod, int? AllowedGapDays)
    {
        IEnumerable<Coverage> jzzzzzzzzzzzt_ = this.Pharmacy_Benefit_Coverage_Resources(context, PharmCoverage);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> jzzzzzzzzzzzu_ = this.All_Coverage_Info(context, jzzzzzzzzzzzt_, participationPeriod);
        bool? jzzzzzzzzzzzv_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? @this)
        {
            IEnumerable<CqlInterval<CqlDate>> kzzzzzzzzzzzg_ = @this?.CollapsedFinal;
            bool? kzzzzzzzzzzzh_ = context.Operators.Not((bool?)(kzzzzzzzzzzzg_ is null));

            return kzzzzzzzzzzzh_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> jzzzzzzzzzzzw_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?>(jzzzzzzzzzzzu_, jzzzzzzzzzzzv_);
        IEnumerable<CqlInterval<CqlDate>> jzzzzzzzzzzzx_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? @this)
        {
            IEnumerable<CqlInterval<CqlDate>> kzzzzzzzzzzzi_ = @this?.CollapsedFinal;

            return kzzzzzzzzzzzi_;
        };
        IEnumerable<IEnumerable<CqlInterval<CqlDate>>> jzzzzzzzzzzzy_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?, IEnumerable<CqlInterval<CqlDate>>>(jzzzzzzzzzzzw_, jzzzzzzzzzzzx_);
        IEnumerable<CqlInterval<CqlDate>> jzzzzzzzzzzzz_ = context.Operators.Flatten<CqlInterval<CqlDate>>(jzzzzzzzzzzzy_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? kzzzzzzzzzzza_ = NCQACQLBase_1_0_0.Instance.Date_Interval_Gaps_Relative_to_Base_Interval_Stats(context, participationPeriod, jzzzzzzzzzzzz_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?[] kzzzzzzzzzzzb_ = [
            kzzzzzzzzzzza_,
        ];
        bool? kzzzzzzzzzzzc_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? GapsInEnrollment)
        {
            int? kzzzzzzzzzzzj_ = GapsInEnrollment?.Interval_Count;
            bool? kzzzzzzzzzzzk_ = context.Operators.LessOrEqual(kzzzzzzzzzzzj_, 1);
            int? kzzzzzzzzzzzl_ = GapsInEnrollment?.Total_Days_In_Longest_Interval;
            bool? kzzzzzzzzzzzm_ = context.Operators.LessOrEqual(kzzzzzzzzzzzl_, AllowedGapDays);
            bool? kzzzzzzzzzzzn_ = context.Operators.And(kzzzzzzzzzzzk_, kzzzzzzzzzzzm_);
            bool? kzzzzzzzzzzzo_ = this.Anchor_Date_Criteria(context, PharmCoverage, AnchorDate, participationPeriod);
            bool? kzzzzzzzzzzzp_ = context.Operators.And(kzzzzzzzzzzzn_, kzzzzzzzzzzzo_);

            return kzzzzzzzzzzzp_;
        };
        IEnumerable<bool?> kzzzzzzzzzzzd_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?, bool?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>)kzzzzzzzzzzzb_, kzzzzzzzzzzzc_);
        IEnumerable<bool?> kzzzzzzzzzzze_ = context.Operators.Distinct<bool?>(kzzzzzzzzzzzd_);
        bool? kzzzzzzzzzzzf_ = context.Operators.SingletonFrom<bool?>(kzzzzzzzzzzze_);

        return kzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Mental Health Benefit Coverage Resources")]
    public IEnumerable<Coverage> Mental_Health_Benefit_Coverage_Resources(CqlContext context, IEnumerable<Coverage> Coverage)
    {
        bool? kzzzzzzzzzzzq_(Coverage C)
        {
            CodeableConcept kzzzzzzzzzzzu_ = C?.Type;
            List<Coding> kzzzzzzzzzzzv_ = kzzzzzzzzzzzu_?.Coding;
            bool? kzzzzzzzzzzzw_(Coding cTypeCoding)
            {
                CqlCode kzzzzzzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToCode(context, cTypeCoding);
                CqlCode lzzzzzzzzzzza_ = NCQATerminology_1_0_0.Instance.mental_health_policy(context);
                bool? lzzzzzzzzzzzb_ = context.Operators.Equivalent(kzzzzzzzzzzzz_, lzzzzzzzzzzza_);

                return lzzzzzzzzzzzb_;
            };
            IEnumerable<Coding> kzzzzzzzzzzzx_ = context.Operators.Where<Coding>((IEnumerable<Coding>)kzzzzzzzzzzzv_, kzzzzzzzzzzzw_);
            bool? kzzzzzzzzzzzy_ = context.Operators.Exists<Coding>(kzzzzzzzzzzzx_);

            return kzzzzzzzzzzzy_;
        };
        IEnumerable<Coverage> kzzzzzzzzzzzr_ = context.Operators.Where<Coverage>(Coverage, kzzzzzzzzzzzq_);
        bool? kzzzzzzzzzzzs_(Coverage mentalHealthCoverageResource)
        {
            bool? lzzzzzzzzzzzc_ = context.Operators.Not((bool?)(mentalHealthCoverageResource is null));

            return lzzzzzzzzzzzc_;
        };
        IEnumerable<Coverage> kzzzzzzzzzzzt_ = context.Operators.Where<Coverage>(kzzzzzzzzzzzr_, kzzzzzzzzzzzs_);

        return kzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Mental Health Benefit Enrollment Criteria")]
    public bool? Mental_Health_Benefit_Enrollment_Criteria(CqlContext context, IEnumerable<Coverage> MHCoverage, CqlDate AnchorDate, CqlInterval<CqlDate> participationPeriod, int? AllowedGapDays)
    {
        IEnumerable<Coverage> lzzzzzzzzzzzd_ = this.Mental_Health_Benefit_Coverage_Resources(context, MHCoverage);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> lzzzzzzzzzzze_ = this.All_Coverage_Info(context, lzzzzzzzzzzzd_, participationPeriod);
        bool? lzzzzzzzzzzzf_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? @this)
        {
            IEnumerable<CqlInterval<CqlDate>> lzzzzzzzzzzzq_ = @this?.CollapsedFinal;
            bool? lzzzzzzzzzzzr_ = context.Operators.Not((bool?)(lzzzzzzzzzzzq_ is null));

            return lzzzzzzzzzzzr_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> lzzzzzzzzzzzg_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?>(lzzzzzzzzzzze_, lzzzzzzzzzzzf_);
        IEnumerable<CqlInterval<CqlDate>> lzzzzzzzzzzzh_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? @this)
        {
            IEnumerable<CqlInterval<CqlDate>> lzzzzzzzzzzzs_ = @this?.CollapsedFinal;

            return lzzzzzzzzzzzs_;
        };
        IEnumerable<IEnumerable<CqlInterval<CqlDate>>> lzzzzzzzzzzzi_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?, IEnumerable<CqlInterval<CqlDate>>>(lzzzzzzzzzzzg_, lzzzzzzzzzzzh_);
        IEnumerable<CqlInterval<CqlDate>> lzzzzzzzzzzzj_ = context.Operators.Flatten<CqlInterval<CqlDate>>(lzzzzzzzzzzzi_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? lzzzzzzzzzzzk_ = NCQACQLBase_1_0_0.Instance.Date_Interval_Gaps_Relative_to_Base_Interval_Stats(context, participationPeriod, lzzzzzzzzzzzj_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?[] lzzzzzzzzzzzl_ = [
            lzzzzzzzzzzzk_,
        ];
        bool? lzzzzzzzzzzzm_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? GapsInEnrollment)
        {
            int? lzzzzzzzzzzzt_ = GapsInEnrollment?.Interval_Count;
            bool? lzzzzzzzzzzzu_ = context.Operators.LessOrEqual(lzzzzzzzzzzzt_, 1);
            int? lzzzzzzzzzzzv_ = GapsInEnrollment?.Total_Days_In_Longest_Interval;
            bool? lzzzzzzzzzzzw_ = context.Operators.LessOrEqual(lzzzzzzzzzzzv_, AllowedGapDays);
            bool? lzzzzzzzzzzzx_ = context.Operators.And(lzzzzzzzzzzzu_, lzzzzzzzzzzzw_);
            bool? lzzzzzzzzzzzy_ = this.Anchor_Date_Criteria(context, MHCoverage, AnchorDate, participationPeriod);
            bool? lzzzzzzzzzzzz_ = context.Operators.And(lzzzzzzzzzzzx_, lzzzzzzzzzzzy_);

            return lzzzzzzzzzzzz_;
        };
        IEnumerable<bool?> lzzzzzzzzzzzn_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?, bool?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>)lzzzzzzzzzzzl_, lzzzzzzzzzzzm_);
        IEnumerable<bool?> lzzzzzzzzzzzo_ = context.Operators.Distinct<bool?>(lzzzzzzzzzzzn_);
        bool? lzzzzzzzzzzzp_ = context.Operators.SingletonFrom<bool?>(lzzzzzzzzzzzo_);

        return lzzzzzzzzzzzp_;
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
