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
        CqlInterval<CqlDate> gzzzzzzzzzk_(Coverage C)
        {
            Period gzzzzzzzzzn_ = C?.Period;
            CqlInterval<CqlDateTime> gzzzzzzzzzo_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, gzzzzzzzzzn_ as object);
            CqlDateTime gzzzzzzzzzp_ = context.Operators.Start(gzzzzzzzzzo_);
            CqlDate gzzzzzzzzzq_ = context.Operators.DateFrom(gzzzzzzzzzp_);
            CqlInterval<CqlDateTime> gzzzzzzzzzs_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, gzzzzzzzzzn_ as object);
            CqlDateTime gzzzzzzzzzt_ = context.Operators.End(gzzzzzzzzzs_);
            CqlDate gzzzzzzzzzu_ = context.Operators.DateFrom(gzzzzzzzzzt_);
            CqlInterval<CqlDate> gzzzzzzzzzv_ = context.Operators.Interval(gzzzzzzzzzq_, gzzzzzzzzzu_, true, true);
            CqlDate gzzzzzzzzzw_ = context.Operators.Start(participationPeriod);
            CqlDate gzzzzzzzzzx_ = context.Operators.End(participationPeriod);
            CqlInterval<CqlDate> gzzzzzzzzzy_ = context.Operators.Interval(gzzzzzzzzzw_, gzzzzzzzzzx_, true, true);
            CqlInterval<CqlDate> gzzzzzzzzzz_ = context.Operators.Intersect<CqlDate>(gzzzzzzzzzv_, gzzzzzzzzzy_);

            return gzzzzzzzzzz_;
        };
        IEnumerable<CqlInterval<CqlDate>> gzzzzzzzzzl_ = context.Operators.Select<Coverage, CqlInterval<CqlDate>>(Coverage, gzzzzzzzzzk_);
        IEnumerable<CqlInterval<CqlDate>> gzzzzzzzzzm_ = context.Operators.Distinct<CqlInterval<CqlDate>>(gzzzzzzzzzl_);

        return gzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Collapsed Coverage Intervals")]
    public IEnumerable<CqlInterval<CqlDate>> Collapsed_Coverage_Intervals(CqlContext context, IEnumerable<CqlInterval<CqlDate>> Intervals)
    {
        IEnumerable<CqlInterval<CqlDate>> hzzzzzzzzza_ = NCQACQLBase_1_0_0.Instance.Collapse_Date_Interval_Workaround(context, Intervals);

        return hzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Collapsed Coverage Adjacent Intervals")]
    public IEnumerable<CqlInterval<CqlDate>> Collapsed_Coverage_Adjacent_Intervals(CqlContext context, IEnumerable<CqlInterval<CqlDate>> Intervals)
    {
        IEnumerable<ValueTuple<CqlInterval<CqlDate>, CqlInterval<CqlDate>>> hzzzzzzzzzb_ = context.Operators.CrossJoin<CqlInterval<CqlDate>, CqlInterval<CqlDate>>(Intervals, Intervals);
        (CqlTupleMetadata, CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)? hzzzzzzzzzc_(ValueTuple<CqlInterval<CqlDate>, CqlInterval<CqlDate>> _valueTuple)
        {
            (CqlTupleMetadata, CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)? hzzzzzzzzzj_ = (CqlTupleMetadata_BaNHUZXcQBUKLNgEDWdDHjYV, _valueTuple.Item1, _valueTuple.Item2);

            return hzzzzzzzzzj_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)?> hzzzzzzzzzd_ = context.Operators.Select<ValueTuple<CqlInterval<CqlDate>, CqlInterval<CqlDate>>, (CqlTupleMetadata, CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)?>(hzzzzzzzzzb_, hzzzzzzzzzc_);
        bool? hzzzzzzzzze_((CqlTupleMetadata, CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)? tuple_banhuzxcqbuklngedwddhjyv)
        {
            CqlDate hzzzzzzzzzk_ = context.Operators.End(tuple_banhuzxcqbuklngedwddhjyv?.Coverage1);
            CqlDate hzzzzzzzzzl_ = context.Operators.Start(tuple_banhuzxcqbuklngedwddhjyv?.Coverage2);
            CqlQuantity hzzzzzzzzzm_ = context.Operators.Quantity(1m, "day");
            CqlDate hzzzzzzzzzn_ = context.Operators.Subtract(hzzzzzzzzzl_, hzzzzzzzzzm_);
            CqlDate hzzzzzzzzzq_ = context.Operators.Add(hzzzzzzzzzl_, hzzzzzzzzzm_);
            CqlInterval<CqlDate> hzzzzzzzzzr_ = context.Operators.Interval(hzzzzzzzzzn_, hzzzzzzzzzq_, true, true);
            bool? hzzzzzzzzzs_ = context.Operators.In<CqlDate>(hzzzzzzzzzk_, hzzzzzzzzzr_, default);
            bool? hzzzzzzzzzu_ = context.Operators.Not((bool?)(hzzzzzzzzzl_ is null));
            bool? hzzzzzzzzzv_ = context.Operators.And(hzzzzzzzzzs_, hzzzzzzzzzu_);

            return hzzzzzzzzzv_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)?> hzzzzzzzzzf_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)?>(hzzzzzzzzzd_, hzzzzzzzzze_);
        CqlInterval<CqlDate> hzzzzzzzzzg_((CqlTupleMetadata, CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)? tuple_banhuzxcqbuklngedwddhjyv)
        {
            CqlDate hzzzzzzzzzw_ = context.Operators.Start(tuple_banhuzxcqbuklngedwddhjyv?.Coverage1);
            CqlDate hzzzzzzzzzx_ = context.Operators.End(tuple_banhuzxcqbuklngedwddhjyv?.Coverage2);
            CqlInterval<CqlDate> hzzzzzzzzzy_ = context.Operators.Interval(hzzzzzzzzzw_, hzzzzzzzzzx_, true, true);

            return hzzzzzzzzzy_;
        };
        IEnumerable<CqlInterval<CqlDate>> hzzzzzzzzzh_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)?, CqlInterval<CqlDate>>(hzzzzzzzzzf_, hzzzzzzzzzg_);
        IEnumerable<CqlInterval<CqlDate>> hzzzzzzzzzi_ = context.Operators.Distinct<CqlInterval<CqlDate>>(hzzzzzzzzzh_);

        return hzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Collapsed Final Coverage Intervals")]
    public IEnumerable<CqlInterval<CqlDate>> Collapsed_Final_Coverage_Intervals(CqlContext context, IEnumerable<CqlInterval<CqlDate>> collapsedI, IEnumerable<CqlInterval<CqlDate>> adjacentI)
    {
        IEnumerable<CqlInterval<CqlDate>> hzzzzzzzzzz_ = this.Collapsed_Coverage_Intervals(context, collapsedI);
        IEnumerable<CqlInterval<CqlDate>> izzzzzzzzza_ = this.Collapsed_Coverage_Adjacent_Intervals(context, adjacentI);
        IEnumerable<CqlInterval<CqlDate>> izzzzzzzzzb_ = context.Operators.Union<CqlInterval<CqlDate>>(hzzzzzzzzzz_, izzzzzzzzza_);
        IEnumerable<CqlInterval<CqlDate>> izzzzzzzzzc_ = NCQACQLBase_1_0_0.Instance.Collapse_Date_Interval_Workaround(context, izzzzzzzzzb_);

        return izzzzzzzzzc_;
    }


    [CqlExpressionDefinition("All Coverage Info")]
    public IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> All_Coverage_Info(CqlContext context, IEnumerable<Coverage> Coverage, CqlInterval<CqlDate> participationPeriod)
    {
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? izzzzzzzzzd_(Coverage C)
        {
            IEnumerable<CqlInterval<CqlDate>> izzzzzzzzzg_ = this.CoverageIntervals(context, Coverage, participationPeriod);
            IEnumerable<CqlInterval<CqlDate>> izzzzzzzzzi_ = this.Collapsed_Coverage_Intervals(context, izzzzzzzzzg_);
            IEnumerable<CqlInterval<CqlDate>> izzzzzzzzzk_ = this.Collapsed_Coverage_Intervals(context, izzzzzzzzzg_);
            IEnumerable<CqlInterval<CqlDate>> izzzzzzzzzl_ = this.Collapsed_Coverage_Adjacent_Intervals(context, izzzzzzzzzk_);
            IEnumerable<CqlInterval<CqlDate>> izzzzzzzzzn_ = this.Collapsed_Coverage_Intervals(context, izzzzzzzzzg_);
            IEnumerable<CqlInterval<CqlDate>> izzzzzzzzzp_ = this.Collapsed_Coverage_Intervals(context, izzzzzzzzzg_);
            IEnumerable<CqlInterval<CqlDate>> izzzzzzzzzq_ = this.Collapsed_Coverage_Adjacent_Intervals(context, izzzzzzzzzp_);
            IEnumerable<CqlInterval<CqlDate>> izzzzzzzzzr_ = this.Collapsed_Final_Coverage_Intervals(context, izzzzzzzzzn_, izzzzzzzzzq_);
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? izzzzzzzzzs_ = (CqlTupleMetadata_DPLIOBaSciHAAETJOMSIjWgbP, izzzzzzzzzg_, izzzzzzzzzi_, izzzzzzzzzl_, izzzzzzzzzr_);

            return izzzzzzzzzs_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> izzzzzzzzze_ = context.Operators.Select<Coverage, (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?>(Coverage, izzzzzzzzzd_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> izzzzzzzzzf_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?>(izzzzzzzzze_);

        return izzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Health Plan Coverage Resources")]
    public IEnumerable<Coverage> Health_Plan_Coverage_Resources(CqlContext context, IEnumerable<Coverage> Coverage)
    {
        bool? izzzzzzzzzt_(Coverage C)
        {
            CodeableConcept izzzzzzzzzx_ = C?.Type;
            List<Coding> izzzzzzzzzy_ = izzzzzzzzzx_?.Coding;
            bool? izzzzzzzzzz_(Coding cTypeCoding)
            {
                CqlCode jzzzzzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToCode(context, cTypeCoding);
                CqlCode jzzzzzzzzzd_ = NCQATerminology_1_0_0.Instance.managed_care_policy(context);
                bool? jzzzzzzzzze_ = context.Operators.Equivalent(jzzzzzzzzzc_, jzzzzzzzzzd_);
                CqlCode jzzzzzzzzzg_ = NCQATerminology_1_0_0.Instance.retiree_health_program(context);
                bool? jzzzzzzzzzh_ = context.Operators.Equivalent(jzzzzzzzzzc_, jzzzzzzzzzg_);
                bool? jzzzzzzzzzi_ = context.Operators.Or(jzzzzzzzzze_, jzzzzzzzzzh_);
                CqlCode jzzzzzzzzzk_ = NCQATerminology_1_0_0.Instance.subsidized_health_program(context);
                bool? jzzzzzzzzzl_ = context.Operators.Equivalent(jzzzzzzzzzc_, jzzzzzzzzzk_);
                bool? jzzzzzzzzzm_ = context.Operators.Or(jzzzzzzzzzi_, jzzzzzzzzzl_);

                return jzzzzzzzzzm_;
            };
            IEnumerable<Coding> jzzzzzzzzza_ = context.Operators.Where<Coding>((IEnumerable<Coding>)izzzzzzzzzy_, izzzzzzzzzz_);
            bool? jzzzzzzzzzb_ = context.Operators.Exists<Coding>(jzzzzzzzzza_);

            return jzzzzzzzzzb_;
        };
        IEnumerable<Coverage> izzzzzzzzzu_ = context.Operators.Where<Coverage>(Coverage, izzzzzzzzzt_);
        bool? izzzzzzzzzv_(Coverage HPCoverageResource)
        {
            bool? jzzzzzzzzzn_ = context.Operators.Not((bool?)(HPCoverageResource is null));

            return jzzzzzzzzzn_;
        };
        IEnumerable<Coverage> izzzzzzzzzw_ = context.Operators.Where<Coverage>(izzzzzzzzzu_, izzzzzzzzzv_);

        return izzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Anchor Date Criteria")]
    public bool? Anchor_Date_Criteria(CqlContext context, IEnumerable<Coverage> Coverage, CqlDate AnchorDate, CqlInterval<CqlDate> participationPeriod)
    {
        bool? jzzzzzzzzzo_()
        {
            bool jzzzzzzzzzp_()
            {
                bool? jzzzzzzzzzq_ = context.Operators.In<CqlDate>(AnchorDate, participationPeriod, default);
                bool? jzzzzzzzzzr_ = context.Operators.Not(jzzzzzzzzzq_);

                return jzzzzzzzzzr_ ?? false;
            };
            if ((context.Operators.In<CqlDate>(AnchorDate, participationPeriod, default)) ?? false)
            {
                IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> jzzzzzzzzzs_ = this.All_Coverage_Info(context, Coverage, participationPeriod);
                bool? jzzzzzzzzzt_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? @this)
                {
                    IEnumerable<CqlInterval<CqlDate>> kzzzzzzzzzb_ = @this?.CollapsedFinal;
                    bool? kzzzzzzzzzc_ = context.Operators.Not((bool?)(kzzzzzzzzzb_ is null));

                    return kzzzzzzzzzc_;
                };
                IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> jzzzzzzzzzu_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?>(jzzzzzzzzzs_, jzzzzzzzzzt_);
                IEnumerable<CqlInterval<CqlDate>> jzzzzzzzzzv_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? @this)
                {
                    IEnumerable<CqlInterval<CqlDate>> kzzzzzzzzzd_ = @this?.CollapsedFinal;

                    return kzzzzzzzzzd_;
                };
                IEnumerable<IEnumerable<CqlInterval<CqlDate>>> jzzzzzzzzzw_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?, IEnumerable<CqlInterval<CqlDate>>>(jzzzzzzzzzu_, jzzzzzzzzzv_);
                IEnumerable<CqlInterval<CqlDate>> jzzzzzzzzzx_ = context.Operators.Flatten<CqlInterval<CqlDate>>(jzzzzzzzzzw_);
                bool? jzzzzzzzzzy_(CqlInterval<CqlDate> FinalInterval)
                {
                    bool? kzzzzzzzzze_ = context.Operators.In<CqlDate>(AnchorDate, FinalInterval, default);

                    return kzzzzzzzzze_;
                };
                IEnumerable<CqlInterval<CqlDate>> jzzzzzzzzzz_ = context.Operators.Where<CqlInterval<CqlDate>>(jzzzzzzzzzx_, jzzzzzzzzzy_);
                bool? kzzzzzzzzza_ = context.Operators.Exists<CqlInterval<CqlDate>>(jzzzzzzzzzz_);

                return kzzzzzzzzza_;
            }
            else if (jzzzzzzzzzp_())
            {
                bool? kzzzzzzzzzf_(Coverage @this)
                {
                    Period kzzzzzzzzzm_ = @this?.Period;
                    bool? kzzzzzzzzzn_ = context.Operators.Not((bool?)(kzzzzzzzzzm_ is null));

                    return kzzzzzzzzzn_;
                };
                IEnumerable<Coverage> kzzzzzzzzzg_ = context.Operators.Where<Coverage>(Coverage, kzzzzzzzzzf_);
                Period kzzzzzzzzzh_(Coverage @this)
                {
                    Period kzzzzzzzzzo_ = @this?.Period;

                    return kzzzzzzzzzo_;
                };
                IEnumerable<Period> kzzzzzzzzzi_ = context.Operators.Select<Coverage, Period>(kzzzzzzzzzg_, kzzzzzzzzzh_);
                bool? kzzzzzzzzzj_(Period Cperiod)
                {
                    CqlInterval<CqlDateTime> kzzzzzzzzzp_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, Cperiod as object);
                    CqlDateTime kzzzzzzzzzq_ = context.Operators.Start(kzzzzzzzzzp_);
                    CqlDate kzzzzzzzzzr_ = context.Operators.DateFrom(kzzzzzzzzzq_);
                    CqlDateTime kzzzzzzzzzt_ = context.Operators.End(kzzzzzzzzzp_);
                    CqlDate kzzzzzzzzzu_ = context.Operators.DateFrom(kzzzzzzzzzt_);
                    CqlInterval<CqlDate> kzzzzzzzzzv_ = context.Operators.Interval(kzzzzzzzzzr_, kzzzzzzzzzu_, true, true);
                    bool? kzzzzzzzzzw_ = context.Operators.In<CqlDate>(AnchorDate, kzzzzzzzzzv_, default);

                    return kzzzzzzzzzw_;
                };
                IEnumerable<Period> kzzzzzzzzzk_ = context.Operators.Where<Period>(kzzzzzzzzzi_, kzzzzzzzzzj_);
                bool? kzzzzzzzzzl_ = context.Operators.Exists<Period>(kzzzzzzzzzk_);

                return kzzzzzzzzzl_;
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

        return jzzzzzzzzzo_();
    }


    [CqlExpressionDefinition("Health Plan Enrollment Criteria")]
    public bool? Health_Plan_Enrollment_Criteria(CqlContext context, IEnumerable<Coverage> Coverage, CqlDate AnchorDate, CqlInterval<CqlDate> participationPeriod, int? AllowedGapDays)
    {
        IEnumerable<Coverage> kzzzzzzzzzx_ = this.Health_Plan_Coverage_Resources(context, Coverage);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> kzzzzzzzzzy_ = this.All_Coverage_Info(context, kzzzzzzzzzx_, participationPeriod);
        bool? kzzzzzzzzzz_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? @this)
        {
            IEnumerable<CqlInterval<CqlDate>> lzzzzzzzzzk_ = @this?.CollapsedFinal;
            bool? lzzzzzzzzzl_ = context.Operators.Not((bool?)(lzzzzzzzzzk_ is null));

            return lzzzzzzzzzl_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> lzzzzzzzzza_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?>(kzzzzzzzzzy_, kzzzzzzzzzz_);
        IEnumerable<CqlInterval<CqlDate>> lzzzzzzzzzb_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? @this)
        {
            IEnumerable<CqlInterval<CqlDate>> lzzzzzzzzzm_ = @this?.CollapsedFinal;

            return lzzzzzzzzzm_;
        };
        IEnumerable<IEnumerable<CqlInterval<CqlDate>>> lzzzzzzzzzc_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?, IEnumerable<CqlInterval<CqlDate>>>(lzzzzzzzzza_, lzzzzzzzzzb_);
        IEnumerable<CqlInterval<CqlDate>> lzzzzzzzzzd_ = context.Operators.Flatten<CqlInterval<CqlDate>>(lzzzzzzzzzc_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? lzzzzzzzzze_ = NCQACQLBase_1_0_0.Instance.Date_Interval_Gaps_Relative_to_Base_Interval_Stats(context, participationPeriod, lzzzzzzzzzd_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?[] lzzzzzzzzzf_ = [
            lzzzzzzzzze_,
        ];
        bool? lzzzzzzzzzg_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? GapsInEnrollment)
        {
            int? lzzzzzzzzzn_ = GapsInEnrollment?.Interval_Count;
            bool? lzzzzzzzzzo_ = context.Operators.LessOrEqual(lzzzzzzzzzn_, 1);
            int? lzzzzzzzzzp_ = GapsInEnrollment?.Total_Days_In_Longest_Interval;
            bool? lzzzzzzzzzq_ = context.Operators.LessOrEqual(lzzzzzzzzzp_, AllowedGapDays);
            bool? lzzzzzzzzzr_ = context.Operators.And(lzzzzzzzzzo_, lzzzzzzzzzq_);
            bool? lzzzzzzzzzs_ = this.Anchor_Date_Criteria(context, Coverage, AnchorDate, participationPeriod);
            bool? lzzzzzzzzzt_ = context.Operators.And(lzzzzzzzzzr_, lzzzzzzzzzs_);

            return lzzzzzzzzzt_;
        };
        IEnumerable<bool?> lzzzzzzzzzh_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?, bool?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>)lzzzzzzzzzf_, lzzzzzzzzzg_);
        IEnumerable<bool?> lzzzzzzzzzi_ = context.Operators.Distinct<bool?>(lzzzzzzzzzh_);
        bool? lzzzzzzzzzj_ = context.Operators.SingletonFrom<bool?>(lzzzzzzzzzi_);

        return lzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Pharmacy Benefit Coverage Resources")]
    public IEnumerable<Coverage> Pharmacy_Benefit_Coverage_Resources(CqlContext context, IEnumerable<Coverage> Coverage)
    {
        bool? lzzzzzzzzzu_(Coverage C)
        {
            CodeableConcept lzzzzzzzzzy_ = C?.Type;
            List<Coding> lzzzzzzzzzz_ = lzzzzzzzzzy_?.Coding;
            bool? mzzzzzzzzza_(Coding cTypeCoding)
            {
                CqlCode mzzzzzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToCode(context, cTypeCoding);
                CqlCode mzzzzzzzzze_ = NCQATerminology_1_0_0.Instance.drug_policy(context);
                bool? mzzzzzzzzzf_ = context.Operators.Equivalent(mzzzzzzzzzd_, mzzzzzzzzze_);

                return mzzzzzzzzzf_;
            };
            IEnumerable<Coding> mzzzzzzzzzb_ = context.Operators.Where<Coding>((IEnumerable<Coding>)lzzzzzzzzzz_, mzzzzzzzzza_);
            bool? mzzzzzzzzzc_ = context.Operators.Exists<Coding>(mzzzzzzzzzb_);

            return mzzzzzzzzzc_;
        };
        IEnumerable<Coverage> lzzzzzzzzzv_ = context.Operators.Where<Coverage>(Coverage, lzzzzzzzzzu_);
        bool? lzzzzzzzzzw_(Coverage pharmacyCoverageResource)
        {
            bool? mzzzzzzzzzg_ = context.Operators.Not((bool?)(pharmacyCoverageResource is null));

            return mzzzzzzzzzg_;
        };
        IEnumerable<Coverage> lzzzzzzzzzx_ = context.Operators.Where<Coverage>(lzzzzzzzzzv_, lzzzzzzzzzw_);

        return lzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Pharmacy Benefit Enrollment Criteria")]
    public bool? Pharmacy_Benefit_Enrollment_Criteria(CqlContext context, IEnumerable<Coverage> PharmCoverage, CqlDate AnchorDate, CqlInterval<CqlDate> participationPeriod, int? AllowedGapDays)
    {
        IEnumerable<Coverage> mzzzzzzzzzh_ = this.Pharmacy_Benefit_Coverage_Resources(context, PharmCoverage);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> mzzzzzzzzzi_ = this.All_Coverage_Info(context, mzzzzzzzzzh_, participationPeriod);
        bool? mzzzzzzzzzj_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? @this)
        {
            IEnumerable<CqlInterval<CqlDate>> mzzzzzzzzzu_ = @this?.CollapsedFinal;
            bool? mzzzzzzzzzv_ = context.Operators.Not((bool?)(mzzzzzzzzzu_ is null));

            return mzzzzzzzzzv_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> mzzzzzzzzzk_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?>(mzzzzzzzzzi_, mzzzzzzzzzj_);
        IEnumerable<CqlInterval<CqlDate>> mzzzzzzzzzl_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? @this)
        {
            IEnumerable<CqlInterval<CqlDate>> mzzzzzzzzzw_ = @this?.CollapsedFinal;

            return mzzzzzzzzzw_;
        };
        IEnumerable<IEnumerable<CqlInterval<CqlDate>>> mzzzzzzzzzm_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?, IEnumerable<CqlInterval<CqlDate>>>(mzzzzzzzzzk_, mzzzzzzzzzl_);
        IEnumerable<CqlInterval<CqlDate>> mzzzzzzzzzn_ = context.Operators.Flatten<CqlInterval<CqlDate>>(mzzzzzzzzzm_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? mzzzzzzzzzo_ = NCQACQLBase_1_0_0.Instance.Date_Interval_Gaps_Relative_to_Base_Interval_Stats(context, participationPeriod, mzzzzzzzzzn_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?[] mzzzzzzzzzp_ = [
            mzzzzzzzzzo_,
        ];
        bool? mzzzzzzzzzq_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? GapsInEnrollment)
        {
            int? mzzzzzzzzzx_ = GapsInEnrollment?.Interval_Count;
            bool? mzzzzzzzzzy_ = context.Operators.LessOrEqual(mzzzzzzzzzx_, 1);
            int? mzzzzzzzzzz_ = GapsInEnrollment?.Total_Days_In_Longest_Interval;
            bool? nzzzzzzzzza_ = context.Operators.LessOrEqual(mzzzzzzzzzz_, AllowedGapDays);
            bool? nzzzzzzzzzb_ = context.Operators.And(mzzzzzzzzzy_, nzzzzzzzzza_);
            bool? nzzzzzzzzzc_ = this.Anchor_Date_Criteria(context, PharmCoverage, AnchorDate, participationPeriod);
            bool? nzzzzzzzzzd_ = context.Operators.And(nzzzzzzzzzb_, nzzzzzzzzzc_);

            return nzzzzzzzzzd_;
        };
        IEnumerable<bool?> mzzzzzzzzzr_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?, bool?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>)mzzzzzzzzzp_, mzzzzzzzzzq_);
        IEnumerable<bool?> mzzzzzzzzzs_ = context.Operators.Distinct<bool?>(mzzzzzzzzzr_);
        bool? mzzzzzzzzzt_ = context.Operators.SingletonFrom<bool?>(mzzzzzzzzzs_);

        return mzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Mental Health Benefit Coverage Resources")]
    public IEnumerable<Coverage> Mental_Health_Benefit_Coverage_Resources(CqlContext context, IEnumerable<Coverage> Coverage)
    {
        bool? nzzzzzzzzze_(Coverage C)
        {
            CodeableConcept nzzzzzzzzzi_ = C?.Type;
            List<Coding> nzzzzzzzzzj_ = nzzzzzzzzzi_?.Coding;
            bool? nzzzzzzzzzk_(Coding cTypeCoding)
            {
                CqlCode nzzzzzzzzzn_ = FHIRHelpers_4_0_001.Instance.ToCode(context, cTypeCoding);
                CqlCode nzzzzzzzzzo_ = NCQATerminology_1_0_0.Instance.mental_health_policy(context);
                bool? nzzzzzzzzzp_ = context.Operators.Equivalent(nzzzzzzzzzn_, nzzzzzzzzzo_);

                return nzzzzzzzzzp_;
            };
            IEnumerable<Coding> nzzzzzzzzzl_ = context.Operators.Where<Coding>((IEnumerable<Coding>)nzzzzzzzzzj_, nzzzzzzzzzk_);
            bool? nzzzzzzzzzm_ = context.Operators.Exists<Coding>(nzzzzzzzzzl_);

            return nzzzzzzzzzm_;
        };
        IEnumerable<Coverage> nzzzzzzzzzf_ = context.Operators.Where<Coverage>(Coverage, nzzzzzzzzze_);
        bool? nzzzzzzzzzg_(Coverage mentalHealthCoverageResource)
        {
            bool? nzzzzzzzzzq_ = context.Operators.Not((bool?)(mentalHealthCoverageResource is null));

            return nzzzzzzzzzq_;
        };
        IEnumerable<Coverage> nzzzzzzzzzh_ = context.Operators.Where<Coverage>(nzzzzzzzzzf_, nzzzzzzzzzg_);

        return nzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Mental Health Benefit Enrollment Criteria")]
    public bool? Mental_Health_Benefit_Enrollment_Criteria(CqlContext context, IEnumerable<Coverage> MHCoverage, CqlDate AnchorDate, CqlInterval<CqlDate> participationPeriod, int? AllowedGapDays)
    {
        IEnumerable<Coverage> nzzzzzzzzzr_ = this.Mental_Health_Benefit_Coverage_Resources(context, MHCoverage);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> nzzzzzzzzzs_ = this.All_Coverage_Info(context, nzzzzzzzzzr_, participationPeriod);
        bool? nzzzzzzzzzt_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? @this)
        {
            IEnumerable<CqlInterval<CqlDate>> ozzzzzzzzze_ = @this?.CollapsedFinal;
            bool? ozzzzzzzzzf_ = context.Operators.Not((bool?)(ozzzzzzzzze_ is null));

            return ozzzzzzzzzf_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> nzzzzzzzzzu_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?>(nzzzzzzzzzs_, nzzzzzzzzzt_);
        IEnumerable<CqlInterval<CqlDate>> nzzzzzzzzzv_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? @this)
        {
            IEnumerable<CqlInterval<CqlDate>> ozzzzzzzzzg_ = @this?.CollapsedFinal;

            return ozzzzzzzzzg_;
        };
        IEnumerable<IEnumerable<CqlInterval<CqlDate>>> nzzzzzzzzzw_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?, IEnumerable<CqlInterval<CqlDate>>>(nzzzzzzzzzu_, nzzzzzzzzzv_);
        IEnumerable<CqlInterval<CqlDate>> nzzzzzzzzzx_ = context.Operators.Flatten<CqlInterval<CqlDate>>(nzzzzzzzzzw_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? nzzzzzzzzzy_ = NCQACQLBase_1_0_0.Instance.Date_Interval_Gaps_Relative_to_Base_Interval_Stats(context, participationPeriod, nzzzzzzzzzx_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?[] nzzzzzzzzzz_ = [
            nzzzzzzzzzy_,
        ];
        bool? ozzzzzzzzza_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? GapsInEnrollment)
        {
            int? ozzzzzzzzzh_ = GapsInEnrollment?.Interval_Count;
            bool? ozzzzzzzzzi_ = context.Operators.LessOrEqual(ozzzzzzzzzh_, 1);
            int? ozzzzzzzzzj_ = GapsInEnrollment?.Total_Days_In_Longest_Interval;
            bool? ozzzzzzzzzk_ = context.Operators.LessOrEqual(ozzzzzzzzzj_, AllowedGapDays);
            bool? ozzzzzzzzzl_ = context.Operators.And(ozzzzzzzzzi_, ozzzzzzzzzk_);
            bool? ozzzzzzzzzm_ = this.Anchor_Date_Criteria(context, MHCoverage, AnchorDate, participationPeriod);
            bool? ozzzzzzzzzn_ = context.Operators.And(ozzzzzzzzzl_, ozzzzzzzzzm_);

            return ozzzzzzzzzn_;
        };
        IEnumerable<bool?> ozzzzzzzzzb_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?, bool?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>)nzzzzzzzzzz_, ozzzzzzzzza_);
        IEnumerable<bool?> ozzzzzzzzzc_ = context.Operators.Distinct<bool?>(ozzzzzzzzzb_);
        bool? ozzzzzzzzzd_ = context.Operators.SingletonFrom<bool?>(ozzzzzzzzzc_);

        return ozzzzzzzzzd_;
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
