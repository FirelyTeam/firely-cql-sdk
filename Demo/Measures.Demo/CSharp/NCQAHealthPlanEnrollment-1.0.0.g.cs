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
        CqlInterval<CqlDate> xzzzzzzzzzzzzr_(Coverage C)
        {
            Period xzzzzzzzzzzzzu_ = C?.Period;
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzv_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, xzzzzzzzzzzzzu_ as object);
            CqlDateTime xzzzzzzzzzzzzw_ = context.Operators.Start(xzzzzzzzzzzzzv_);
            CqlDate xzzzzzzzzzzzzx_ = context.Operators.DateFrom(xzzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzz_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, xzzzzzzzzzzzzu_ as object);
            CqlDateTime yzzzzzzzzzzzza_ = context.Operators.End(xzzzzzzzzzzzzz_);
            CqlDate yzzzzzzzzzzzzb_ = context.Operators.DateFrom(yzzzzzzzzzzzza_);
            CqlInterval<CqlDate> yzzzzzzzzzzzzc_ = context.Operators.Interval(xzzzzzzzzzzzzx_, yzzzzzzzzzzzzb_, true, true);
            CqlDate yzzzzzzzzzzzzd_ = context.Operators.Start(participationPeriod);
            CqlDate yzzzzzzzzzzzze_ = context.Operators.End(participationPeriod);
            CqlInterval<CqlDate> yzzzzzzzzzzzzf_ = context.Operators.Interval(yzzzzzzzzzzzzd_, yzzzzzzzzzzzze_, true, true);
            CqlInterval<CqlDate> yzzzzzzzzzzzzg_ = context.Operators.Intersect<CqlDate>(yzzzzzzzzzzzzc_, yzzzzzzzzzzzzf_);

            return yzzzzzzzzzzzzg_;
        };
        IEnumerable<CqlInterval<CqlDate>> xzzzzzzzzzzzzs_ = context.Operators.Select<Coverage, CqlInterval<CqlDate>>(Coverage, xzzzzzzzzzzzzr_);
        IEnumerable<CqlInterval<CqlDate>> xzzzzzzzzzzzzt_ = context.Operators.Distinct<CqlInterval<CqlDate>>(xzzzzzzzzzzzzs_);

        return xzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Collapsed Coverage Intervals")]
    public IEnumerable<CqlInterval<CqlDate>> Collapsed_Coverage_Intervals(CqlContext context, IEnumerable<CqlInterval<CqlDate>> Intervals)
    {
        IEnumerable<CqlInterval<CqlDate>> yzzzzzzzzzzzzh_ = NCQACQLBase_1_0_0.Instance.Collapse_Date_Interval_Workaround(context, Intervals);

        return yzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Collapsed Coverage Adjacent Intervals")]
    public IEnumerable<CqlInterval<CqlDate>> Collapsed_Coverage_Adjacent_Intervals(CqlContext context, IEnumerable<CqlInterval<CqlDate>> Intervals)
    {
        IEnumerable<ValueTuple<CqlInterval<CqlDate>, CqlInterval<CqlDate>>> yzzzzzzzzzzzzi_ = context.Operators.CrossJoin<CqlInterval<CqlDate>, CqlInterval<CqlDate>>(Intervals, Intervals);
        (CqlTupleMetadata, CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)? yzzzzzzzzzzzzj_(ValueTuple<CqlInterval<CqlDate>, CqlInterval<CqlDate>> _valueTuple)
        {
            (CqlTupleMetadata, CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)? yzzzzzzzzzzzzq_ = (CqlTupleMetadata_BaNHUZXcQBUKLNgEDWdDHjYV, _valueTuple.Item1, _valueTuple.Item2);

            return yzzzzzzzzzzzzq_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)?> yzzzzzzzzzzzzk_ = context.Operators.Select<ValueTuple<CqlInterval<CqlDate>, CqlInterval<CqlDate>>, (CqlTupleMetadata, CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)?>(yzzzzzzzzzzzzi_, yzzzzzzzzzzzzj_);
        bool? yzzzzzzzzzzzzl_((CqlTupleMetadata, CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)? tuple_banhuzxcqbuklngedwddhjyv)
        {
            CqlDate yzzzzzzzzzzzzr_ = context.Operators.End(tuple_banhuzxcqbuklngedwddhjyv?.Coverage1);
            CqlDate yzzzzzzzzzzzzs_ = context.Operators.Start(tuple_banhuzxcqbuklngedwddhjyv?.Coverage2);
            CqlQuantity yzzzzzzzzzzzzt_ = context.Operators.Quantity(1m, "day");
            CqlDate yzzzzzzzzzzzzu_ = context.Operators.Subtract(yzzzzzzzzzzzzs_, yzzzzzzzzzzzzt_);
            CqlDate yzzzzzzzzzzzzx_ = context.Operators.Add(yzzzzzzzzzzzzs_, yzzzzzzzzzzzzt_);
            CqlInterval<CqlDate> yzzzzzzzzzzzzy_ = context.Operators.Interval(yzzzzzzzzzzzzu_, yzzzzzzzzzzzzx_, true, true);
            bool? yzzzzzzzzzzzzz_ = context.Operators.In<CqlDate>(yzzzzzzzzzzzzr_, yzzzzzzzzzzzzy_, default);
            bool? zzzzzzzzzzzzzb_ = context.Operators.Not((bool?)(yzzzzzzzzzzzzs_ is null));
            bool? zzzzzzzzzzzzzc_ = context.Operators.And(yzzzzzzzzzzzzz_, zzzzzzzzzzzzzb_);

            return zzzzzzzzzzzzzc_;
        };
        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)?> yzzzzzzzzzzzzm_ = context.Operators.Where<(CqlTupleMetadata, CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)?>(yzzzzzzzzzzzzk_, yzzzzzzzzzzzzl_);
        CqlInterval<CqlDate> yzzzzzzzzzzzzn_((CqlTupleMetadata, CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)? tuple_banhuzxcqbuklngedwddhjyv)
        {
            CqlDate zzzzzzzzzzzzzd_ = context.Operators.Start(tuple_banhuzxcqbuklngedwddhjyv?.Coverage1);
            CqlDate zzzzzzzzzzzzze_ = context.Operators.End(tuple_banhuzxcqbuklngedwddhjyv?.Coverage2);
            CqlInterval<CqlDate> zzzzzzzzzzzzzf_ = context.Operators.Interval(zzzzzzzzzzzzzd_, zzzzzzzzzzzzze_, true, true);

            return zzzzzzzzzzzzzf_;
        };
        IEnumerable<CqlInterval<CqlDate>> yzzzzzzzzzzzzo_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)?, CqlInterval<CqlDate>>(yzzzzzzzzzzzzm_, yzzzzzzzzzzzzn_);
        IEnumerable<CqlInterval<CqlDate>> yzzzzzzzzzzzzp_ = context.Operators.Distinct<CqlInterval<CqlDate>>(yzzzzzzzzzzzzo_);

        return yzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Collapsed Final Coverage Intervals")]
    public IEnumerable<CqlInterval<CqlDate>> Collapsed_Final_Coverage_Intervals(CqlContext context, IEnumerable<CqlInterval<CqlDate>> collapsedI, IEnumerable<CqlInterval<CqlDate>> adjacentI)
    {
        IEnumerable<CqlInterval<CqlDate>> zzzzzzzzzzzzzg_ = this.Collapsed_Coverage_Intervals(context, collapsedI);
        IEnumerable<CqlInterval<CqlDate>> zzzzzzzzzzzzzh_ = this.Collapsed_Coverage_Adjacent_Intervals(context, adjacentI);
        IEnumerable<CqlInterval<CqlDate>> zzzzzzzzzzzzzi_ = context.Operators.Union<CqlInterval<CqlDate>>(zzzzzzzzzzzzzg_, zzzzzzzzzzzzzh_);
        IEnumerable<CqlInterval<CqlDate>> zzzzzzzzzzzzzj_ = NCQACQLBase_1_0_0.Instance.Collapse_Date_Interval_Workaround(context, zzzzzzzzzzzzzi_);

        return zzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("All Coverage Info")]
    public IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> All_Coverage_Info(CqlContext context, IEnumerable<Coverage> Coverage, CqlInterval<CqlDate> participationPeriod)
    {
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? zzzzzzzzzzzzzk_(Coverage C)
        {
            IEnumerable<CqlInterval<CqlDate>> zzzzzzzzzzzzzn_ = this.CoverageIntervals(context, Coverage, participationPeriod);
            IEnumerable<CqlInterval<CqlDate>> zzzzzzzzzzzzzp_ = this.Collapsed_Coverage_Intervals(context, zzzzzzzzzzzzzn_);
            IEnumerable<CqlInterval<CqlDate>> zzzzzzzzzzzzzr_ = this.Collapsed_Coverage_Intervals(context, zzzzzzzzzzzzzn_);
            IEnumerable<CqlInterval<CqlDate>> zzzzzzzzzzzzzs_ = this.Collapsed_Coverage_Adjacent_Intervals(context, zzzzzzzzzzzzzr_);
            IEnumerable<CqlInterval<CqlDate>> zzzzzzzzzzzzzu_ = this.Collapsed_Coverage_Intervals(context, zzzzzzzzzzzzzn_);
            IEnumerable<CqlInterval<CqlDate>> zzzzzzzzzzzzzw_ = this.Collapsed_Coverage_Intervals(context, zzzzzzzzzzzzzn_);
            IEnumerable<CqlInterval<CqlDate>> zzzzzzzzzzzzzx_ = this.Collapsed_Coverage_Adjacent_Intervals(context, zzzzzzzzzzzzzw_);
            IEnumerable<CqlInterval<CqlDate>> zzzzzzzzzzzzzy_ = this.Collapsed_Final_Coverage_Intervals(context, zzzzzzzzzzzzzu_, zzzzzzzzzzzzzx_);
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? zzzzzzzzzzzzzz_ = (CqlTupleMetadata_DPLIOBaSciHAAETJOMSIjWgbP, zzzzzzzzzzzzzn_, zzzzzzzzzzzzzp_, zzzzzzzzzzzzzs_, zzzzzzzzzzzzzy_);

            return zzzzzzzzzzzzzz_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> zzzzzzzzzzzzzl_ = context.Operators.Select<Coverage, (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?>(Coverage, zzzzzzzzzzzzzk_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> zzzzzzzzzzzzzm_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?>(zzzzzzzzzzzzzl_);

        return zzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Health Plan Coverage Resources")]
    public IEnumerable<Coverage> Health_Plan_Coverage_Resources(CqlContext context, IEnumerable<Coverage> Coverage)
    {
        bool? azzzzzzzzzzzzza_(Coverage C)
        {
            CodeableConcept azzzzzzzzzzzzze_ = C?.Type;
            List<Coding> azzzzzzzzzzzzzf_ = azzzzzzzzzzzzze_?.Coding;
            bool? azzzzzzzzzzzzzg_(Coding cTypeCoding)
            {
                CqlCode azzzzzzzzzzzzzj_ = FHIRHelpers_4_0_001.Instance.ToCode(context, cTypeCoding);
                CqlCode azzzzzzzzzzzzzk_ = NCQATerminology_1_0_0.Instance.managed_care_policy(context);
                bool? azzzzzzzzzzzzzl_ = context.Operators.Equivalent(azzzzzzzzzzzzzj_, azzzzzzzzzzzzzk_);
                CqlCode azzzzzzzzzzzzzn_ = NCQATerminology_1_0_0.Instance.retiree_health_program(context);
                bool? azzzzzzzzzzzzzo_ = context.Operators.Equivalent(azzzzzzzzzzzzzj_, azzzzzzzzzzzzzn_);
                bool? azzzzzzzzzzzzzp_ = context.Operators.Or(azzzzzzzzzzzzzl_, azzzzzzzzzzzzzo_);
                CqlCode azzzzzzzzzzzzzr_ = NCQATerminology_1_0_0.Instance.subsidized_health_program(context);
                bool? azzzzzzzzzzzzzs_ = context.Operators.Equivalent(azzzzzzzzzzzzzj_, azzzzzzzzzzzzzr_);
                bool? azzzzzzzzzzzzzt_ = context.Operators.Or(azzzzzzzzzzzzzp_, azzzzzzzzzzzzzs_);

                return azzzzzzzzzzzzzt_;
            };
            IEnumerable<Coding> azzzzzzzzzzzzzh_ = context.Operators.Where<Coding>((IEnumerable<Coding>)azzzzzzzzzzzzzf_, azzzzzzzzzzzzzg_);
            bool? azzzzzzzzzzzzzi_ = context.Operators.Exists<Coding>(azzzzzzzzzzzzzh_);

            return azzzzzzzzzzzzzi_;
        };
        IEnumerable<Coverage> azzzzzzzzzzzzzb_ = context.Operators.Where<Coverage>(Coverage, azzzzzzzzzzzzza_);
        bool? azzzzzzzzzzzzzc_(Coverage HPCoverageResource)
        {
            bool? azzzzzzzzzzzzzu_ = context.Operators.Not((bool?)(HPCoverageResource is null));

            return azzzzzzzzzzzzzu_;
        };
        IEnumerable<Coverage> azzzzzzzzzzzzzd_ = context.Operators.Where<Coverage>(azzzzzzzzzzzzzb_, azzzzzzzzzzzzzc_);

        return azzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Anchor Date Criteria")]
    public bool? Anchor_Date_Criteria(CqlContext context, IEnumerable<Coverage> Coverage, CqlDate AnchorDate, CqlInterval<CqlDate> participationPeriod)
    {
        bool? azzzzzzzzzzzzzv_()
        {
            bool azzzzzzzzzzzzzw_()
            {
                bool? azzzzzzzzzzzzzx_ = context.Operators.In<CqlDate>(AnchorDate, participationPeriod, default);
                bool? azzzzzzzzzzzzzy_ = context.Operators.Not(azzzzzzzzzzzzzx_);

                return azzzzzzzzzzzzzy_ ?? false;
            };
            if ((context.Operators.In<CqlDate>(AnchorDate, participationPeriod, default)) ?? false)
            {
                IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> azzzzzzzzzzzzzz_ = this.All_Coverage_Info(context, Coverage, participationPeriod);
                bool? bzzzzzzzzzzzzza_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? @this)
                {
                    IEnumerable<CqlInterval<CqlDate>> bzzzzzzzzzzzzzi_ = @this?.CollapsedFinal;
                    bool? bzzzzzzzzzzzzzj_ = context.Operators.Not((bool?)(bzzzzzzzzzzzzzi_ is null));

                    return bzzzzzzzzzzzzzj_;
                };
                IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> bzzzzzzzzzzzzzb_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?>(azzzzzzzzzzzzzz_, bzzzzzzzzzzzzza_);
                IEnumerable<CqlInterval<CqlDate>> bzzzzzzzzzzzzzc_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? @this)
                {
                    IEnumerable<CqlInterval<CqlDate>> bzzzzzzzzzzzzzk_ = @this?.CollapsedFinal;

                    return bzzzzzzzzzzzzzk_;
                };
                IEnumerable<IEnumerable<CqlInterval<CqlDate>>> bzzzzzzzzzzzzzd_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?, IEnumerable<CqlInterval<CqlDate>>>(bzzzzzzzzzzzzzb_, bzzzzzzzzzzzzzc_);
                IEnumerable<CqlInterval<CqlDate>> bzzzzzzzzzzzzze_ = context.Operators.Flatten<CqlInterval<CqlDate>>(bzzzzzzzzzzzzzd_);
                bool? bzzzzzzzzzzzzzf_(CqlInterval<CqlDate> FinalInterval)
                {
                    bool? bzzzzzzzzzzzzzl_ = context.Operators.In<CqlDate>(AnchorDate, FinalInterval, default);

                    return bzzzzzzzzzzzzzl_;
                };
                IEnumerable<CqlInterval<CqlDate>> bzzzzzzzzzzzzzg_ = context.Operators.Where<CqlInterval<CqlDate>>(bzzzzzzzzzzzzze_, bzzzzzzzzzzzzzf_);
                bool? bzzzzzzzzzzzzzh_ = context.Operators.Exists<CqlInterval<CqlDate>>(bzzzzzzzzzzzzzg_);

                return bzzzzzzzzzzzzzh_;
            }
            else if (azzzzzzzzzzzzzw_())
            {
                bool? bzzzzzzzzzzzzzm_(Coverage @this)
                {
                    Period bzzzzzzzzzzzzzt_ = @this?.Period;
                    bool? bzzzzzzzzzzzzzu_ = context.Operators.Not((bool?)(bzzzzzzzzzzzzzt_ is null));

                    return bzzzzzzzzzzzzzu_;
                };
                IEnumerable<Coverage> bzzzzzzzzzzzzzn_ = context.Operators.Where<Coverage>(Coverage, bzzzzzzzzzzzzzm_);
                Period bzzzzzzzzzzzzzo_(Coverage @this)
                {
                    Period bzzzzzzzzzzzzzv_ = @this?.Period;

                    return bzzzzzzzzzzzzzv_;
                };
                IEnumerable<Period> bzzzzzzzzzzzzzp_ = context.Operators.Select<Coverage, Period>(bzzzzzzzzzzzzzn_, bzzzzzzzzzzzzzo_);
                bool? bzzzzzzzzzzzzzq_(Period Cperiod)
                {
                    CqlInterval<CqlDateTime> bzzzzzzzzzzzzzw_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, Cperiod as object);
                    CqlDateTime bzzzzzzzzzzzzzx_ = context.Operators.Start(bzzzzzzzzzzzzzw_);
                    CqlDate bzzzzzzzzzzzzzy_ = context.Operators.DateFrom(bzzzzzzzzzzzzzx_);
                    CqlDateTime czzzzzzzzzzzzza_ = context.Operators.End(bzzzzzzzzzzzzzw_);
                    CqlDate czzzzzzzzzzzzzb_ = context.Operators.DateFrom(czzzzzzzzzzzzza_);
                    CqlInterval<CqlDate> czzzzzzzzzzzzzc_ = context.Operators.Interval(bzzzzzzzzzzzzzy_, czzzzzzzzzzzzzb_, true, true);
                    bool? czzzzzzzzzzzzzd_ = context.Operators.In<CqlDate>(AnchorDate, czzzzzzzzzzzzzc_, default);

                    return czzzzzzzzzzzzzd_;
                };
                IEnumerable<Period> bzzzzzzzzzzzzzr_ = context.Operators.Where<Period>(bzzzzzzzzzzzzzp_, bzzzzzzzzzzzzzq_);
                bool? bzzzzzzzzzzzzzs_ = context.Operators.Exists<Period>(bzzzzzzzzzzzzzr_);

                return bzzzzzzzzzzzzzs_;
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

        return azzzzzzzzzzzzzv_();
    }


    [CqlExpressionDefinition("Health Plan Enrollment Criteria")]
    public bool? Health_Plan_Enrollment_Criteria(CqlContext context, IEnumerable<Coverage> Coverage, CqlDate AnchorDate, CqlInterval<CqlDate> participationPeriod, int? AllowedGapDays)
    {
        IEnumerable<Coverage> czzzzzzzzzzzzze_ = this.Health_Plan_Coverage_Resources(context, Coverage);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> czzzzzzzzzzzzzf_ = this.All_Coverage_Info(context, czzzzzzzzzzzzze_, participationPeriod);
        bool? czzzzzzzzzzzzzg_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? @this)
        {
            IEnumerable<CqlInterval<CqlDate>> czzzzzzzzzzzzzr_ = @this?.CollapsedFinal;
            bool? czzzzzzzzzzzzzs_ = context.Operators.Not((bool?)(czzzzzzzzzzzzzr_ is null));

            return czzzzzzzzzzzzzs_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> czzzzzzzzzzzzzh_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?>(czzzzzzzzzzzzzf_, czzzzzzzzzzzzzg_);
        IEnumerable<CqlInterval<CqlDate>> czzzzzzzzzzzzzi_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? @this)
        {
            IEnumerable<CqlInterval<CqlDate>> czzzzzzzzzzzzzt_ = @this?.CollapsedFinal;

            return czzzzzzzzzzzzzt_;
        };
        IEnumerable<IEnumerable<CqlInterval<CqlDate>>> czzzzzzzzzzzzzj_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?, IEnumerable<CqlInterval<CqlDate>>>(czzzzzzzzzzzzzh_, czzzzzzzzzzzzzi_);
        IEnumerable<CqlInterval<CqlDate>> czzzzzzzzzzzzzk_ = context.Operators.Flatten<CqlInterval<CqlDate>>(czzzzzzzzzzzzzj_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? czzzzzzzzzzzzzl_ = NCQACQLBase_1_0_0.Instance.Date_Interval_Gaps_Relative_to_Base_Interval_Stats(context, participationPeriod, czzzzzzzzzzzzzk_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?[] czzzzzzzzzzzzzm_ = [
            czzzzzzzzzzzzzl_,
        ];
        bool? czzzzzzzzzzzzzn_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? GapsInEnrollment)
        {
            int? czzzzzzzzzzzzzu_ = GapsInEnrollment?.Interval_Count;
            bool? czzzzzzzzzzzzzv_ = context.Operators.LessOrEqual(czzzzzzzzzzzzzu_, 1);
            int? czzzzzzzzzzzzzw_ = GapsInEnrollment?.Total_Days_In_Longest_Interval;
            bool? czzzzzzzzzzzzzx_ = context.Operators.LessOrEqual(czzzzzzzzzzzzzw_, AllowedGapDays);
            bool? czzzzzzzzzzzzzy_ = context.Operators.And(czzzzzzzzzzzzzv_, czzzzzzzzzzzzzx_);
            bool? czzzzzzzzzzzzzz_ = this.Anchor_Date_Criteria(context, Coverage, AnchorDate, participationPeriod);
            bool? dzzzzzzzzzzzzza_ = context.Operators.And(czzzzzzzzzzzzzy_, czzzzzzzzzzzzzz_);

            return dzzzzzzzzzzzzza_;
        };
        IEnumerable<bool?> czzzzzzzzzzzzzo_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?, bool?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>)czzzzzzzzzzzzzm_, czzzzzzzzzzzzzn_);
        IEnumerable<bool?> czzzzzzzzzzzzzp_ = context.Operators.Distinct<bool?>(czzzzzzzzzzzzzo_);
        bool? czzzzzzzzzzzzzq_ = context.Operators.SingletonFrom<bool?>(czzzzzzzzzzzzzp_);

        return czzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Pharmacy Benefit Coverage Resources")]
    public IEnumerable<Coverage> Pharmacy_Benefit_Coverage_Resources(CqlContext context, IEnumerable<Coverage> Coverage)
    {
        bool? dzzzzzzzzzzzzzb_(Coverage C)
        {
            CodeableConcept dzzzzzzzzzzzzzf_ = C?.Type;
            List<Coding> dzzzzzzzzzzzzzg_ = dzzzzzzzzzzzzzf_?.Coding;
            bool? dzzzzzzzzzzzzzh_(Coding cTypeCoding)
            {
                CqlCode dzzzzzzzzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToCode(context, cTypeCoding);
                CqlCode dzzzzzzzzzzzzzl_ = NCQATerminology_1_0_0.Instance.drug_policy(context);
                bool? dzzzzzzzzzzzzzm_ = context.Operators.Equivalent(dzzzzzzzzzzzzzk_, dzzzzzzzzzzzzzl_);

                return dzzzzzzzzzzzzzm_;
            };
            IEnumerable<Coding> dzzzzzzzzzzzzzi_ = context.Operators.Where<Coding>((IEnumerable<Coding>)dzzzzzzzzzzzzzg_, dzzzzzzzzzzzzzh_);
            bool? dzzzzzzzzzzzzzj_ = context.Operators.Exists<Coding>(dzzzzzzzzzzzzzi_);

            return dzzzzzzzzzzzzzj_;
        };
        IEnumerable<Coverage> dzzzzzzzzzzzzzc_ = context.Operators.Where<Coverage>(Coverage, dzzzzzzzzzzzzzb_);
        bool? dzzzzzzzzzzzzzd_(Coverage pharmacyCoverageResource)
        {
            bool? dzzzzzzzzzzzzzn_ = context.Operators.Not((bool?)(pharmacyCoverageResource is null));

            return dzzzzzzzzzzzzzn_;
        };
        IEnumerable<Coverage> dzzzzzzzzzzzzze_ = context.Operators.Where<Coverage>(dzzzzzzzzzzzzzc_, dzzzzzzzzzzzzzd_);

        return dzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Pharmacy Benefit Enrollment Criteria")]
    public bool? Pharmacy_Benefit_Enrollment_Criteria(CqlContext context, IEnumerable<Coverage> PharmCoverage, CqlDate AnchorDate, CqlInterval<CqlDate> participationPeriod, int? AllowedGapDays)
    {
        IEnumerable<Coverage> dzzzzzzzzzzzzzo_ = this.Pharmacy_Benefit_Coverage_Resources(context, PharmCoverage);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> dzzzzzzzzzzzzzp_ = this.All_Coverage_Info(context, dzzzzzzzzzzzzzo_, participationPeriod);
        bool? dzzzzzzzzzzzzzq_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? @this)
        {
            IEnumerable<CqlInterval<CqlDate>> ezzzzzzzzzzzzzb_ = @this?.CollapsedFinal;
            bool? ezzzzzzzzzzzzzc_ = context.Operators.Not((bool?)(ezzzzzzzzzzzzzb_ is null));

            return ezzzzzzzzzzzzzc_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> dzzzzzzzzzzzzzr_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?>(dzzzzzzzzzzzzzp_, dzzzzzzzzzzzzzq_);
        IEnumerable<CqlInterval<CqlDate>> dzzzzzzzzzzzzzs_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? @this)
        {
            IEnumerable<CqlInterval<CqlDate>> ezzzzzzzzzzzzzd_ = @this?.CollapsedFinal;

            return ezzzzzzzzzzzzzd_;
        };
        IEnumerable<IEnumerable<CqlInterval<CqlDate>>> dzzzzzzzzzzzzzt_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?, IEnumerable<CqlInterval<CqlDate>>>(dzzzzzzzzzzzzzr_, dzzzzzzzzzzzzzs_);
        IEnumerable<CqlInterval<CqlDate>> dzzzzzzzzzzzzzu_ = context.Operators.Flatten<CqlInterval<CqlDate>>(dzzzzzzzzzzzzzt_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? dzzzzzzzzzzzzzv_ = NCQACQLBase_1_0_0.Instance.Date_Interval_Gaps_Relative_to_Base_Interval_Stats(context, participationPeriod, dzzzzzzzzzzzzzu_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?[] dzzzzzzzzzzzzzw_ = [
            dzzzzzzzzzzzzzv_,
        ];
        bool? dzzzzzzzzzzzzzx_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? GapsInEnrollment)
        {
            int? ezzzzzzzzzzzzze_ = GapsInEnrollment?.Interval_Count;
            bool? ezzzzzzzzzzzzzf_ = context.Operators.LessOrEqual(ezzzzzzzzzzzzze_, 1);
            int? ezzzzzzzzzzzzzg_ = GapsInEnrollment?.Total_Days_In_Longest_Interval;
            bool? ezzzzzzzzzzzzzh_ = context.Operators.LessOrEqual(ezzzzzzzzzzzzzg_, AllowedGapDays);
            bool? ezzzzzzzzzzzzzi_ = context.Operators.And(ezzzzzzzzzzzzzf_, ezzzzzzzzzzzzzh_);
            bool? ezzzzzzzzzzzzzj_ = this.Anchor_Date_Criteria(context, PharmCoverage, AnchorDate, participationPeriod);
            bool? ezzzzzzzzzzzzzk_ = context.Operators.And(ezzzzzzzzzzzzzi_, ezzzzzzzzzzzzzj_);

            return ezzzzzzzzzzzzzk_;
        };
        IEnumerable<bool?> dzzzzzzzzzzzzzy_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?, bool?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>)dzzzzzzzzzzzzzw_, dzzzzzzzzzzzzzx_);
        IEnumerable<bool?> dzzzzzzzzzzzzzz_ = context.Operators.Distinct<bool?>(dzzzzzzzzzzzzzy_);
        bool? ezzzzzzzzzzzzza_ = context.Operators.SingletonFrom<bool?>(dzzzzzzzzzzzzzz_);

        return ezzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Mental Health Benefit Coverage Resources")]
    public IEnumerable<Coverage> Mental_Health_Benefit_Coverage_Resources(CqlContext context, IEnumerable<Coverage> Coverage)
    {
        bool? ezzzzzzzzzzzzzl_(Coverage C)
        {
            CodeableConcept ezzzzzzzzzzzzzp_ = C?.Type;
            List<Coding> ezzzzzzzzzzzzzq_ = ezzzzzzzzzzzzzp_?.Coding;
            bool? ezzzzzzzzzzzzzr_(Coding cTypeCoding)
            {
                CqlCode ezzzzzzzzzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToCode(context, cTypeCoding);
                CqlCode ezzzzzzzzzzzzzv_ = NCQATerminology_1_0_0.Instance.mental_health_policy(context);
                bool? ezzzzzzzzzzzzzw_ = context.Operators.Equivalent(ezzzzzzzzzzzzzu_, ezzzzzzzzzzzzzv_);

                return ezzzzzzzzzzzzzw_;
            };
            IEnumerable<Coding> ezzzzzzzzzzzzzs_ = context.Operators.Where<Coding>((IEnumerable<Coding>)ezzzzzzzzzzzzzq_, ezzzzzzzzzzzzzr_);
            bool? ezzzzzzzzzzzzzt_ = context.Operators.Exists<Coding>(ezzzzzzzzzzzzzs_);

            return ezzzzzzzzzzzzzt_;
        };
        IEnumerable<Coverage> ezzzzzzzzzzzzzm_ = context.Operators.Where<Coverage>(Coverage, ezzzzzzzzzzzzzl_);
        bool? ezzzzzzzzzzzzzn_(Coverage mentalHealthCoverageResource)
        {
            bool? ezzzzzzzzzzzzzx_ = context.Operators.Not((bool?)(mentalHealthCoverageResource is null));

            return ezzzzzzzzzzzzzx_;
        };
        IEnumerable<Coverage> ezzzzzzzzzzzzzo_ = context.Operators.Where<Coverage>(ezzzzzzzzzzzzzm_, ezzzzzzzzzzzzzn_);

        return ezzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Mental Health Benefit Enrollment Criteria")]
    public bool? Mental_Health_Benefit_Enrollment_Criteria(CqlContext context, IEnumerable<Coverage> MHCoverage, CqlDate AnchorDate, CqlInterval<CqlDate> participationPeriod, int? AllowedGapDays)
    {
        IEnumerable<Coverage> ezzzzzzzzzzzzzy_ = this.Mental_Health_Benefit_Coverage_Resources(context, MHCoverage);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> ezzzzzzzzzzzzzz_ = this.All_Coverage_Info(context, ezzzzzzzzzzzzzy_, participationPeriod);
        bool? fzzzzzzzzzzzzza_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? @this)
        {
            IEnumerable<CqlInterval<CqlDate>> fzzzzzzzzzzzzzl_ = @this?.CollapsedFinal;
            bool? fzzzzzzzzzzzzzm_ = context.Operators.Not((bool?)(fzzzzzzzzzzzzzl_ is null));

            return fzzzzzzzzzzzzzm_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> fzzzzzzzzzzzzzb_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?>(ezzzzzzzzzzzzzz_, fzzzzzzzzzzzzza_);
        IEnumerable<CqlInterval<CqlDate>> fzzzzzzzzzzzzzc_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? @this)
        {
            IEnumerable<CqlInterval<CqlDate>> fzzzzzzzzzzzzzn_ = @this?.CollapsedFinal;

            return fzzzzzzzzzzzzzn_;
        };
        IEnumerable<IEnumerable<CqlInterval<CqlDate>>> fzzzzzzzzzzzzzd_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?, IEnumerable<CqlInterval<CqlDate>>>(fzzzzzzzzzzzzzb_, fzzzzzzzzzzzzzc_);
        IEnumerable<CqlInterval<CqlDate>> fzzzzzzzzzzzzze_ = context.Operators.Flatten<CqlInterval<CqlDate>>(fzzzzzzzzzzzzzd_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? fzzzzzzzzzzzzzf_ = NCQACQLBase_1_0_0.Instance.Date_Interval_Gaps_Relative_to_Base_Interval_Stats(context, participationPeriod, fzzzzzzzzzzzzze_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?[] fzzzzzzzzzzzzzg_ = [
            fzzzzzzzzzzzzzf_,
        ];
        bool? fzzzzzzzzzzzzzh_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? GapsInEnrollment)
        {
            int? fzzzzzzzzzzzzzo_ = GapsInEnrollment?.Interval_Count;
            bool? fzzzzzzzzzzzzzp_ = context.Operators.LessOrEqual(fzzzzzzzzzzzzzo_, 1);
            int? fzzzzzzzzzzzzzq_ = GapsInEnrollment?.Total_Days_In_Longest_Interval;
            bool? fzzzzzzzzzzzzzr_ = context.Operators.LessOrEqual(fzzzzzzzzzzzzzq_, AllowedGapDays);
            bool? fzzzzzzzzzzzzzs_ = context.Operators.And(fzzzzzzzzzzzzzp_, fzzzzzzzzzzzzzr_);
            bool? fzzzzzzzzzzzzzt_ = this.Anchor_Date_Criteria(context, MHCoverage, AnchorDate, participationPeriod);
            bool? fzzzzzzzzzzzzzu_ = context.Operators.And(fzzzzzzzzzzzzzs_, fzzzzzzzzzzzzzt_);

            return fzzzzzzzzzzzzzu_;
        };
        IEnumerable<bool?> fzzzzzzzzzzzzzi_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?, bool?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>)fzzzzzzzzzzzzzg_, fzzzzzzzzzzzzzh_);
        IEnumerable<bool?> fzzzzzzzzzzzzzj_ = context.Operators.Distinct<bool?>(fzzzzzzzzzzzzzi_);
        bool? fzzzzzzzzzzzzzk_ = context.Operators.SingletonFrom<bool?>(fzzzzzzzzzzzzzj_);

        return fzzzzzzzzzzzzzk_;
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
