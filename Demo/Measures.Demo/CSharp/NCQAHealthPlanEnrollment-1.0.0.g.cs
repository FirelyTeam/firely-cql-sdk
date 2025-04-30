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
        CqlInterval<CqlDate> xzzzzzzzo_(Coverage C)
        {
            Period xzzzzzzzr_ = C?.Period;
            CqlInterval<CqlDateTime> xzzzzzzzs_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, xzzzzzzzr_ as object);
            CqlDateTime xzzzzzzzt_ = context.Operators.Start(xzzzzzzzs_);
            CqlDate xzzzzzzzu_ = context.Operators.DateFrom(xzzzzzzzt_);
            CqlInterval<CqlDateTime> xzzzzzzzw_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, xzzzzzzzr_ as object);
            CqlDateTime xzzzzzzzx_ = context.Operators.End(xzzzzzzzw_);
            CqlDate xzzzzzzzy_ = context.Operators.DateFrom(xzzzzzzzx_);
            CqlInterval<CqlDate> xzzzzzzzz_ = context.Operators.Interval(xzzzzzzzu_, xzzzzzzzy_, true, true);
            CqlDate yzzzzzzza_ = context.Operators.Start(participationPeriod);
            CqlDate yzzzzzzzb_ = context.Operators.End(participationPeriod);
            CqlInterval<CqlDate> yzzzzzzzc_ = context.Operators.Interval(yzzzzzzza_, yzzzzzzzb_, true, true);
            CqlInterval<CqlDate> yzzzzzzzd_ = context.Operators.Intersect<CqlDate>(xzzzzzzzz_, yzzzzzzzc_);

            return yzzzzzzzd_;
        };
        IEnumerable<CqlInterval<CqlDate>> xzzzzzzzp_ = context.Operators.Select<Coverage, CqlInterval<CqlDate>>(Coverage, xzzzzzzzo_);
        IEnumerable<CqlInterval<CqlDate>> xzzzzzzzq_ = context.Operators.Distinct<CqlInterval<CqlDate>>(xzzzzzzzp_);

        return xzzzzzzzq_;
    }


    [CqlExpressionDefinition("Collapsed Coverage Intervals")]
    public IEnumerable<CqlInterval<CqlDate>> Collapsed_Coverage_Intervals(CqlContext context, IEnumerable<CqlInterval<CqlDate>> Intervals)
    {
        IEnumerable<CqlInterval<CqlDate>> yzzzzzzze_ = NCQACQLBase_1_0_0.Instance.Collapse_Date_Interval_Workaround(context, Intervals);

        return yzzzzzzze_;
    }


    [CqlExpressionDefinition("Collapsed Coverage Adjacent Intervals")]
    public IEnumerable<CqlInterval<CqlDate>> Collapsed_Coverage_Adjacent_Intervals(CqlContext context, IEnumerable<CqlInterval<CqlDate>> Intervals)
    {
        IEnumerable<ValueTuple<CqlInterval<CqlDate>, CqlInterval<CqlDate>>> yzzzzzzzf_ = context.Operators.CrossJoin<CqlInterval<CqlDate>, CqlInterval<CqlDate>>(Intervals, Intervals);
        (CqlTupleMetadata, CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)? yzzzzzzzg_(ValueTuple<CqlInterval<CqlDate>, CqlInterval<CqlDate>> _valueTuple)
        {
            (CqlTupleMetadata, CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)? yzzzzzzzn_ = (CqlTupleMetadata_BaNHUZXcQBUKLNgEDWdDHjYV, _valueTuple.Item1, _valueTuple.Item2);

            return yzzzzzzzn_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)?> yzzzzzzzh_ = context.Operators.Select<ValueTuple<CqlInterval<CqlDate>, CqlInterval<CqlDate>>, (CqlTupleMetadata, CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)?>(yzzzzzzzf_, yzzzzzzzg_);
        bool? yzzzzzzzi_((CqlTupleMetadata, CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)? tuple_banhuzxcqbuklngedwddhjyv)
        {
            CqlDate yzzzzzzzo_ = context.Operators.End(tuple_banhuzxcqbuklngedwddhjyv?.Coverage1);
            CqlDate yzzzzzzzp_ = context.Operators.Start(tuple_banhuzxcqbuklngedwddhjyv?.Coverage2);
            CqlQuantity yzzzzzzzq_ = context.Operators.Quantity(1m, "day");
            CqlDate yzzzzzzzr_ = context.Operators.Subtract(yzzzzzzzp_, yzzzzzzzq_);
            CqlDate yzzzzzzzu_ = context.Operators.Add(yzzzzzzzp_, yzzzzzzzq_);
            CqlInterval<CqlDate> yzzzzzzzv_ = context.Operators.Interval(yzzzzzzzr_, yzzzzzzzu_, true, true);
            bool? yzzzzzzzw_ = context.Operators.In<CqlDate>(yzzzzzzzo_, yzzzzzzzv_, default);
            bool? yzzzzzzzy_ = context.Operators.Not((bool?)(yzzzzzzzp_ is null));
            bool? yzzzzzzzz_ = context.Operators.And(yzzzzzzzw_, yzzzzzzzy_);

            return yzzzzzzzz_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)?> yzzzzzzzj_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)?>(yzzzzzzzh_, yzzzzzzzi_);
        CqlInterval<CqlDate> yzzzzzzzk_((CqlTupleMetadata, CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)? tuple_banhuzxcqbuklngedwddhjyv)
        {
            CqlDate zzzzzzzza_ = context.Operators.Start(tuple_banhuzxcqbuklngedwddhjyv?.Coverage1);
            CqlDate zzzzzzzzb_ = context.Operators.End(tuple_banhuzxcqbuklngedwddhjyv?.Coverage2);
            CqlInterval<CqlDate> zzzzzzzzc_ = context.Operators.Interval(zzzzzzzza_, zzzzzzzzb_, true, true);

            return zzzzzzzzc_;
        };
        IEnumerable<CqlInterval<CqlDate>> yzzzzzzzl_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)?, CqlInterval<CqlDate>>(yzzzzzzzj_, yzzzzzzzk_);
        IEnumerable<CqlInterval<CqlDate>> yzzzzzzzm_ = context.Operators.Distinct<CqlInterval<CqlDate>>(yzzzzzzzl_);

        return yzzzzzzzm_;
    }


    [CqlExpressionDefinition("Collapsed Final Coverage Intervals")]
    public IEnumerable<CqlInterval<CqlDate>> Collapsed_Final_Coverage_Intervals(CqlContext context, IEnumerable<CqlInterval<CqlDate>> collapsedI, IEnumerable<CqlInterval<CqlDate>> adjacentI)
    {
        IEnumerable<CqlInterval<CqlDate>> zzzzzzzzd_ = this.Collapsed_Coverage_Intervals(context, collapsedI);
        IEnumerable<CqlInterval<CqlDate>> zzzzzzzze_ = this.Collapsed_Coverage_Adjacent_Intervals(context, adjacentI);
        IEnumerable<CqlInterval<CqlDate>> zzzzzzzzf_ = context.Operators.Union<CqlInterval<CqlDate>>(zzzzzzzzd_, zzzzzzzze_);
        IEnumerable<CqlInterval<CqlDate>> zzzzzzzzg_ = NCQACQLBase_1_0_0.Instance.Collapse_Date_Interval_Workaround(context, zzzzzzzzf_);

        return zzzzzzzzg_;
    }


    [CqlExpressionDefinition("All Coverage Info")]
    public IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> All_Coverage_Info(CqlContext context, IEnumerable<Coverage> Coverage, CqlInterval<CqlDate> participationPeriod)
    {
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? zzzzzzzzh_(Coverage C)
        {
            IEnumerable<CqlInterval<CqlDate>> zzzzzzzzk_ = this.CoverageIntervals(context, Coverage, participationPeriod);
            IEnumerable<CqlInterval<CqlDate>> zzzzzzzzm_ = this.Collapsed_Coverage_Intervals(context, zzzzzzzzk_);
            IEnumerable<CqlInterval<CqlDate>> zzzzzzzzo_ = this.Collapsed_Coverage_Intervals(context, zzzzzzzzk_);
            IEnumerable<CqlInterval<CqlDate>> zzzzzzzzp_ = this.Collapsed_Coverage_Adjacent_Intervals(context, zzzzzzzzo_);
            IEnumerable<CqlInterval<CqlDate>> zzzzzzzzr_ = this.Collapsed_Coverage_Intervals(context, zzzzzzzzk_);
            IEnumerable<CqlInterval<CqlDate>> zzzzzzzzt_ = this.Collapsed_Coverage_Intervals(context, zzzzzzzzk_);
            IEnumerable<CqlInterval<CqlDate>> zzzzzzzzu_ = this.Collapsed_Coverage_Adjacent_Intervals(context, zzzzzzzzt_);
            IEnumerable<CqlInterval<CqlDate>> zzzzzzzzv_ = this.Collapsed_Final_Coverage_Intervals(context, zzzzzzzzr_, zzzzzzzzu_);
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? zzzzzzzzw_ = (CqlTupleMetadata_DPLIOBaSciHAAETJOMSIjWgbP, zzzzzzzzk_, zzzzzzzzm_, zzzzzzzzp_, zzzzzzzzv_);

            return zzzzzzzzw_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> zzzzzzzzi_ = context.Operators.Select<Coverage, (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?>(Coverage, zzzzzzzzh_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> zzzzzzzzj_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?>(zzzzzzzzi_);

        return zzzzzzzzj_;
    }


    [CqlExpressionDefinition("Health Plan Coverage Resources")]
    public IEnumerable<Coverage> Health_Plan_Coverage_Resources(CqlContext context, IEnumerable<Coverage> Coverage)
    {
        bool? zzzzzzzzx_(Coverage C)
        {
            CodeableConcept azzzzzzzzb_ = C?.Type;
            List<Coding> azzzzzzzzc_ = azzzzzzzzb_?.Coding;
            bool? azzzzzzzzd_(Coding cTypeCoding)
            {
                CqlCode azzzzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToCode(context, cTypeCoding);
                CqlCode azzzzzzzzh_ = NCQATerminology_1_0_0.Instance.managed_care_policy(context);
                bool? azzzzzzzzi_ = context.Operators.Equivalent(azzzzzzzzg_, azzzzzzzzh_);
                CqlCode azzzzzzzzk_ = NCQATerminology_1_0_0.Instance.retiree_health_program(context);
                bool? azzzzzzzzl_ = context.Operators.Equivalent(azzzzzzzzg_, azzzzzzzzk_);
                bool? azzzzzzzzm_ = context.Operators.Or(azzzzzzzzi_, azzzzzzzzl_);
                CqlCode azzzzzzzzo_ = NCQATerminology_1_0_0.Instance.subsidized_health_program(context);
                bool? azzzzzzzzp_ = context.Operators.Equivalent(azzzzzzzzg_, azzzzzzzzo_);
                bool? azzzzzzzzq_ = context.Operators.Or(azzzzzzzzm_, azzzzzzzzp_);

                return azzzzzzzzq_;
            };
            IEnumerable<Coding> azzzzzzzze_ = context.Operators.Where<Coding>((IEnumerable<Coding>)azzzzzzzzc_, azzzzzzzzd_);
            bool? azzzzzzzzf_ = context.Operators.Exists<Coding>(azzzzzzzze_);

            return azzzzzzzzf_;
        };
        IEnumerable<Coverage> zzzzzzzzy_ = context.Operators.Where<Coverage>(Coverage, zzzzzzzzx_);
        bool? zzzzzzzzz_(Coverage HPCoverageResource)
        {
            bool? azzzzzzzzr_ = context.Operators.Not((bool?)(HPCoverageResource is null));

            return azzzzzzzzr_;
        };
        IEnumerable<Coverage> azzzzzzzza_ = context.Operators.Where<Coverage>(zzzzzzzzy_, zzzzzzzzz_);

        return azzzzzzzza_;
    }


    [CqlExpressionDefinition("Anchor Date Criteria")]
    public bool? Anchor_Date_Criteria(CqlContext context, IEnumerable<Coverage> Coverage, CqlDate AnchorDate, CqlInterval<CqlDate> participationPeriod)
    {
        bool? azzzzzzzzs_()
        {
            bool azzzzzzzzt_()
            {
                bool? azzzzzzzzu_ = context.Operators.In<CqlDate>(AnchorDate, participationPeriod, default);
                bool? azzzzzzzzv_ = context.Operators.Not(azzzzzzzzu_);

                return azzzzzzzzv_ ?? false;
            };
            if ((context.Operators.In<CqlDate>(AnchorDate, participationPeriod, default)) ?? false)
            {
                IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> azzzzzzzzw_ = this.All_Coverage_Info(context, Coverage, participationPeriod);
                bool? azzzzzzzzx_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? @this)
                {
                    IEnumerable<CqlInterval<CqlDate>> bzzzzzzzzf_ = @this?.CollapsedFinal;
                    bool? bzzzzzzzzg_ = context.Operators.Not((bool?)(bzzzzzzzzf_ is null));

                    return bzzzzzzzzg_;
                };
                IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> azzzzzzzzy_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?>(azzzzzzzzw_, azzzzzzzzx_);
                IEnumerable<CqlInterval<CqlDate>> azzzzzzzzz_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? @this)
                {
                    IEnumerable<CqlInterval<CqlDate>> bzzzzzzzzh_ = @this?.CollapsedFinal;

                    return bzzzzzzzzh_;
                };
                IEnumerable<IEnumerable<CqlInterval<CqlDate>>> bzzzzzzzza_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?, IEnumerable<CqlInterval<CqlDate>>>(azzzzzzzzy_, azzzzzzzzz_);
                IEnumerable<CqlInterval<CqlDate>> bzzzzzzzzb_ = context.Operators.Flatten<CqlInterval<CqlDate>>(bzzzzzzzza_);
                bool? bzzzzzzzzc_(CqlInterval<CqlDate> FinalInterval)
                {
                    bool? bzzzzzzzzi_ = context.Operators.In<CqlDate>(AnchorDate, FinalInterval, default);

                    return bzzzzzzzzi_;
                };
                IEnumerable<CqlInterval<CqlDate>> bzzzzzzzzd_ = context.Operators.Where<CqlInterval<CqlDate>>(bzzzzzzzzb_, bzzzzzzzzc_);
                bool? bzzzzzzzze_ = context.Operators.Exists<CqlInterval<CqlDate>>(bzzzzzzzzd_);

                return bzzzzzzzze_;
            }
            else if (azzzzzzzzt_())
            {
                bool? bzzzzzzzzj_(Coverage @this)
                {
                    Period bzzzzzzzzq_ = @this?.Period;
                    bool? bzzzzzzzzr_ = context.Operators.Not((bool?)(bzzzzzzzzq_ is null));

                    return bzzzzzzzzr_;
                };
                IEnumerable<Coverage> bzzzzzzzzk_ = context.Operators.Where<Coverage>(Coverage, bzzzzzzzzj_);
                Period bzzzzzzzzl_(Coverage @this)
                {
                    Period bzzzzzzzzs_ = @this?.Period;

                    return bzzzzzzzzs_;
                };
                IEnumerable<Period> bzzzzzzzzm_ = context.Operators.Select<Coverage, Period>(bzzzzzzzzk_, bzzzzzzzzl_);
                bool? bzzzzzzzzn_(Period Cperiod)
                {
                    CqlInterval<CqlDateTime> bzzzzzzzzt_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, Cperiod as object);
                    CqlDateTime bzzzzzzzzu_ = context.Operators.Start(bzzzzzzzzt_);
                    CqlDate bzzzzzzzzv_ = context.Operators.DateFrom(bzzzzzzzzu_);
                    CqlDateTime bzzzzzzzzx_ = context.Operators.End(bzzzzzzzzt_);
                    CqlDate bzzzzzzzzy_ = context.Operators.DateFrom(bzzzzzzzzx_);
                    CqlInterval<CqlDate> bzzzzzzzzz_ = context.Operators.Interval(bzzzzzzzzv_, bzzzzzzzzy_, true, true);
                    bool? czzzzzzzza_ = context.Operators.In<CqlDate>(AnchorDate, bzzzzzzzzz_, default);

                    return czzzzzzzza_;
                };
                IEnumerable<Period> bzzzzzzzzo_ = context.Operators.Where<Period>(bzzzzzzzzm_, bzzzzzzzzn_);
                bool? bzzzzzzzzp_ = context.Operators.Exists<Period>(bzzzzzzzzo_);

                return bzzzzzzzzp_;
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

        return azzzzzzzzs_();
    }


    [CqlExpressionDefinition("Health Plan Enrollment Criteria")]
    public bool? Health_Plan_Enrollment_Criteria(CqlContext context, IEnumerable<Coverage> Coverage, CqlDate AnchorDate, CqlInterval<CqlDate> participationPeriod, int? AllowedGapDays)
    {
        IEnumerable<Coverage> czzzzzzzzb_ = this.Health_Plan_Coverage_Resources(context, Coverage);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> czzzzzzzzc_ = this.All_Coverage_Info(context, czzzzzzzzb_, participationPeriod);
        bool? czzzzzzzzd_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? @this)
        {
            IEnumerable<CqlInterval<CqlDate>> czzzzzzzzo_ = @this?.CollapsedFinal;
            bool? czzzzzzzzp_ = context.Operators.Not((bool?)(czzzzzzzzo_ is null));

            return czzzzzzzzp_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> czzzzzzzze_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?>(czzzzzzzzc_, czzzzzzzzd_);
        IEnumerable<CqlInterval<CqlDate>> czzzzzzzzf_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? @this)
        {
            IEnumerable<CqlInterval<CqlDate>> czzzzzzzzq_ = @this?.CollapsedFinal;

            return czzzzzzzzq_;
        };
        IEnumerable<IEnumerable<CqlInterval<CqlDate>>> czzzzzzzzg_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?, IEnumerable<CqlInterval<CqlDate>>>(czzzzzzzze_, czzzzzzzzf_);
        IEnumerable<CqlInterval<CqlDate>> czzzzzzzzh_ = context.Operators.Flatten<CqlInterval<CqlDate>>(czzzzzzzzg_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? czzzzzzzzi_ = NCQACQLBase_1_0_0.Instance.Date_Interval_Gaps_Relative_to_Base_Interval_Stats(context, participationPeriod, czzzzzzzzh_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?[] czzzzzzzzj_ = [
            czzzzzzzzi_,
        ];
        bool? czzzzzzzzk_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? GapsInEnrollment)
        {
            int? czzzzzzzzr_ = GapsInEnrollment?.Interval_Count;
            bool? czzzzzzzzs_ = context.Operators.LessOrEqual(czzzzzzzzr_, 1);
            int? czzzzzzzzt_ = GapsInEnrollment?.Total_Days_In_Longest_Interval;
            bool? czzzzzzzzu_ = context.Operators.LessOrEqual(czzzzzzzzt_, AllowedGapDays);
            bool? czzzzzzzzv_ = context.Operators.And(czzzzzzzzs_, czzzzzzzzu_);
            bool? czzzzzzzzw_ = this.Anchor_Date_Criteria(context, Coverage, AnchorDate, participationPeriod);
            bool? czzzzzzzzx_ = context.Operators.And(czzzzzzzzv_, czzzzzzzzw_);

            return czzzzzzzzx_;
        };
        IEnumerable<bool?> czzzzzzzzl_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?, bool?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>)czzzzzzzzj_, czzzzzzzzk_);
        IEnumerable<bool?> czzzzzzzzm_ = context.Operators.Distinct<bool?>(czzzzzzzzl_);
        bool? czzzzzzzzn_ = context.Operators.SingletonFrom<bool?>(czzzzzzzzm_);

        return czzzzzzzzn_;
    }


    [CqlExpressionDefinition("Pharmacy Benefit Coverage Resources")]
    public IEnumerable<Coverage> Pharmacy_Benefit_Coverage_Resources(CqlContext context, IEnumerable<Coverage> Coverage)
    {
        bool? czzzzzzzzy_(Coverage C)
        {
            CodeableConcept dzzzzzzzzc_ = C?.Type;
            List<Coding> dzzzzzzzzd_ = dzzzzzzzzc_?.Coding;
            bool? dzzzzzzzze_(Coding cTypeCoding)
            {
                CqlCode dzzzzzzzzh_ = FHIRHelpers_4_0_001.Instance.ToCode(context, cTypeCoding);
                CqlCode dzzzzzzzzi_ = NCQATerminology_1_0_0.Instance.drug_policy(context);
                bool? dzzzzzzzzj_ = context.Operators.Equivalent(dzzzzzzzzh_, dzzzzzzzzi_);

                return dzzzzzzzzj_;
            };
            IEnumerable<Coding> dzzzzzzzzf_ = context.Operators.Where<Coding>((IEnumerable<Coding>)dzzzzzzzzd_, dzzzzzzzze_);
            bool? dzzzzzzzzg_ = context.Operators.Exists<Coding>(dzzzzzzzzf_);

            return dzzzzzzzzg_;
        };
        IEnumerable<Coverage> czzzzzzzzz_ = context.Operators.Where<Coverage>(Coverage, czzzzzzzzy_);
        bool? dzzzzzzzza_(Coverage pharmacyCoverageResource)
        {
            bool? dzzzzzzzzk_ = context.Operators.Not((bool?)(pharmacyCoverageResource is null));

            return dzzzzzzzzk_;
        };
        IEnumerable<Coverage> dzzzzzzzzb_ = context.Operators.Where<Coverage>(czzzzzzzzz_, dzzzzzzzza_);

        return dzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Pharmacy Benefit Enrollment Criteria")]
    public bool? Pharmacy_Benefit_Enrollment_Criteria(CqlContext context, IEnumerable<Coverage> PharmCoverage, CqlDate AnchorDate, CqlInterval<CqlDate> participationPeriod, int? AllowedGapDays)
    {
        IEnumerable<Coverage> dzzzzzzzzl_ = this.Pharmacy_Benefit_Coverage_Resources(context, PharmCoverage);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> dzzzzzzzzm_ = this.All_Coverage_Info(context, dzzzzzzzzl_, participationPeriod);
        bool? dzzzzzzzzn_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? @this)
        {
            IEnumerable<CqlInterval<CqlDate>> dzzzzzzzzy_ = @this?.CollapsedFinal;
            bool? dzzzzzzzzz_ = context.Operators.Not((bool?)(dzzzzzzzzy_ is null));

            return dzzzzzzzzz_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> dzzzzzzzzo_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?>(dzzzzzzzzm_, dzzzzzzzzn_);
        IEnumerable<CqlInterval<CqlDate>> dzzzzzzzzp_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? @this)
        {
            IEnumerable<CqlInterval<CqlDate>> ezzzzzzzza_ = @this?.CollapsedFinal;

            return ezzzzzzzza_;
        };
        IEnumerable<IEnumerable<CqlInterval<CqlDate>>> dzzzzzzzzq_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?, IEnumerable<CqlInterval<CqlDate>>>(dzzzzzzzzo_, dzzzzzzzzp_);
        IEnumerable<CqlInterval<CqlDate>> dzzzzzzzzr_ = context.Operators.Flatten<CqlInterval<CqlDate>>(dzzzzzzzzq_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? dzzzzzzzzs_ = NCQACQLBase_1_0_0.Instance.Date_Interval_Gaps_Relative_to_Base_Interval_Stats(context, participationPeriod, dzzzzzzzzr_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?[] dzzzzzzzzt_ = [
            dzzzzzzzzs_,
        ];
        bool? dzzzzzzzzu_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? GapsInEnrollment)
        {
            int? ezzzzzzzzb_ = GapsInEnrollment?.Interval_Count;
            bool? ezzzzzzzzc_ = context.Operators.LessOrEqual(ezzzzzzzzb_, 1);
            int? ezzzzzzzzd_ = GapsInEnrollment?.Total_Days_In_Longest_Interval;
            bool? ezzzzzzzze_ = context.Operators.LessOrEqual(ezzzzzzzzd_, AllowedGapDays);
            bool? ezzzzzzzzf_ = context.Operators.And(ezzzzzzzzc_, ezzzzzzzze_);
            bool? ezzzzzzzzg_ = this.Anchor_Date_Criteria(context, PharmCoverage, AnchorDate, participationPeriod);
            bool? ezzzzzzzzh_ = context.Operators.And(ezzzzzzzzf_, ezzzzzzzzg_);

            return ezzzzzzzzh_;
        };
        IEnumerable<bool?> dzzzzzzzzv_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?, bool?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>)dzzzzzzzzt_, dzzzzzzzzu_);
        IEnumerable<bool?> dzzzzzzzzw_ = context.Operators.Distinct<bool?>(dzzzzzzzzv_);
        bool? dzzzzzzzzx_ = context.Operators.SingletonFrom<bool?>(dzzzzzzzzw_);

        return dzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Mental Health Benefit Coverage Resources")]
    public IEnumerable<Coverage> Mental_Health_Benefit_Coverage_Resources(CqlContext context, IEnumerable<Coverage> Coverage)
    {
        bool? ezzzzzzzzi_(Coverage C)
        {
            CodeableConcept ezzzzzzzzm_ = C?.Type;
            List<Coding> ezzzzzzzzn_ = ezzzzzzzzm_?.Coding;
            bool? ezzzzzzzzo_(Coding cTypeCoding)
            {
                CqlCode ezzzzzzzzr_ = FHIRHelpers_4_0_001.Instance.ToCode(context, cTypeCoding);
                CqlCode ezzzzzzzzs_ = NCQATerminology_1_0_0.Instance.mental_health_policy(context);
                bool? ezzzzzzzzt_ = context.Operators.Equivalent(ezzzzzzzzr_, ezzzzzzzzs_);

                return ezzzzzzzzt_;
            };
            IEnumerable<Coding> ezzzzzzzzp_ = context.Operators.Where<Coding>((IEnumerable<Coding>)ezzzzzzzzn_, ezzzzzzzzo_);
            bool? ezzzzzzzzq_ = context.Operators.Exists<Coding>(ezzzzzzzzp_);

            return ezzzzzzzzq_;
        };
        IEnumerable<Coverage> ezzzzzzzzj_ = context.Operators.Where<Coverage>(Coverage, ezzzzzzzzi_);
        bool? ezzzzzzzzk_(Coverage mentalHealthCoverageResource)
        {
            bool? ezzzzzzzzu_ = context.Operators.Not((bool?)(mentalHealthCoverageResource is null));

            return ezzzzzzzzu_;
        };
        IEnumerable<Coverage> ezzzzzzzzl_ = context.Operators.Where<Coverage>(ezzzzzzzzj_, ezzzzzzzzk_);

        return ezzzzzzzzl_;
    }


    [CqlExpressionDefinition("Mental Health Benefit Enrollment Criteria")]
    public bool? Mental_Health_Benefit_Enrollment_Criteria(CqlContext context, IEnumerable<Coverage> MHCoverage, CqlDate AnchorDate, CqlInterval<CqlDate> participationPeriod, int? AllowedGapDays)
    {
        IEnumerable<Coverage> ezzzzzzzzv_ = this.Mental_Health_Benefit_Coverage_Resources(context, MHCoverage);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> ezzzzzzzzw_ = this.All_Coverage_Info(context, ezzzzzzzzv_, participationPeriod);
        bool? ezzzzzzzzx_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? @this)
        {
            IEnumerable<CqlInterval<CqlDate>> fzzzzzzzzi_ = @this?.CollapsedFinal;
            bool? fzzzzzzzzj_ = context.Operators.Not((bool?)(fzzzzzzzzi_ is null));

            return fzzzzzzzzj_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> ezzzzzzzzy_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?>(ezzzzzzzzw_, ezzzzzzzzx_);
        IEnumerable<CqlInterval<CqlDate>> ezzzzzzzzz_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? @this)
        {
            IEnumerable<CqlInterval<CqlDate>> fzzzzzzzzk_ = @this?.CollapsedFinal;

            return fzzzzzzzzk_;
        };
        IEnumerable<IEnumerable<CqlInterval<CqlDate>>> fzzzzzzzza_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?, IEnumerable<CqlInterval<CqlDate>>>(ezzzzzzzzy_, ezzzzzzzzz_);
        IEnumerable<CqlInterval<CqlDate>> fzzzzzzzzb_ = context.Operators.Flatten<CqlInterval<CqlDate>>(fzzzzzzzza_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? fzzzzzzzzc_ = NCQACQLBase_1_0_0.Instance.Date_Interval_Gaps_Relative_to_Base_Interval_Stats(context, participationPeriod, fzzzzzzzzb_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?[] fzzzzzzzzd_ = [
            fzzzzzzzzc_,
        ];
        bool? fzzzzzzzze_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? GapsInEnrollment)
        {
            int? fzzzzzzzzl_ = GapsInEnrollment?.Interval_Count;
            bool? fzzzzzzzzm_ = context.Operators.LessOrEqual(fzzzzzzzzl_, 1);
            int? fzzzzzzzzn_ = GapsInEnrollment?.Total_Days_In_Longest_Interval;
            bool? fzzzzzzzzo_ = context.Operators.LessOrEqual(fzzzzzzzzn_, AllowedGapDays);
            bool? fzzzzzzzzp_ = context.Operators.And(fzzzzzzzzm_, fzzzzzzzzo_);
            bool? fzzzzzzzzq_ = this.Anchor_Date_Criteria(context, MHCoverage, AnchorDate, participationPeriod);
            bool? fzzzzzzzzr_ = context.Operators.And(fzzzzzzzzp_, fzzzzzzzzq_);

            return fzzzzzzzzr_;
        };
        IEnumerable<bool?> fzzzzzzzzf_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?, bool?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>)fzzzzzzzzd_, fzzzzzzzze_);
        IEnumerable<bool?> fzzzzzzzzg_ = context.Operators.Distinct<bool?>(fzzzzzzzzf_);
        bool? fzzzzzzzzh_ = context.Operators.SingletonFrom<bool?>(fzzzzzzzzg_);

        return fzzzzzzzzh_;
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
