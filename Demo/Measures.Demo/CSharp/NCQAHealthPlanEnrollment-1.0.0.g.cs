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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.2.2.0")]
[CqlLibrary("NCQAHealthPlanEnrollment", "1.0.0")]
public partial class NCQAHealthPlanEnrollment_1_0_0 : ILibrary, ISingleton<NCQAHealthPlanEnrollment_1_0_0>
{
    #region Functions and Expressions (12)

    [CqlFunctionDefinition("CoverageIntervals")]
    public IEnumerable<CqlInterval<CqlDate>> CoverageIntervals(CqlContext context, IEnumerable<Coverage> Coverage, CqlInterval<CqlDate> participationPeriod)
    {

        CqlInterval<CqlDate> a_(Coverage C) {
            Period c_ = C?.Period;
            CqlInterval<CqlDateTime> d_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, c_);
            CqlDateTime e_ = context.Operators.Start(d_);
            CqlDate f_ = context.Operators.DateFrom(e_);
            CqlDateTime g_ = context.Operators.End(d_);
            CqlDate h_ = context.Operators.DateFrom(g_);
            CqlInterval<CqlDate> i_ = context.Operators.Interval(f_, h_, true, true);
            CqlDate j_ = context.Operators.Start(participationPeriod);
            CqlDate k_ = context.Operators.End(participationPeriod);
            CqlInterval<CqlDate> l_ = context.Operators.Interval(j_, k_, true, true);
            CqlInterval<CqlDate> m_ = context.Operators.Intersect<CqlDate>(i_, l_);
            return m_;
        }

        IEnumerable<CqlInterval<CqlDate>> b_ = context.Operators.SelectDistinct<Coverage, CqlInterval<CqlDate>>(Coverage, a_);
        return b_;
    }


    [CqlFunctionDefinition("Collapsed Coverage Intervals")]
    public IEnumerable<CqlInterval<CqlDate>> Collapsed_Coverage_Intervals(CqlContext context, IEnumerable<CqlInterval<CqlDate>> Intervals)
    {
        IEnumerable<CqlInterval<CqlDate>> a_ = NCQACQLBase_1_0_0.Instance.Collapse_Date_Interval_Workaround(context, Intervals);
        return a_;
    }


    [CqlFunctionDefinition("Collapsed Coverage Adjacent Intervals")]
    public IEnumerable<CqlInterval<CqlDate>> Collapsed_Coverage_Adjacent_Intervals(CqlContext context, IEnumerable<CqlInterval<CqlDate>> Intervals)
    {
        IEnumerable<ValueTuple<CqlInterval<CqlDate>, CqlInterval<CqlDate>>> a_ = context.Operators.CrossJoin<CqlInterval<CqlDate>, CqlInterval<CqlDate>>(Intervals, Intervals);

        (CqlTupleMetadata, CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)? b_(ValueTuple<CqlInterval<CqlDate>, CqlInterval<CqlDate>> _valueTuple) {
            (CqlTupleMetadata, CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)? g_ = (CqlTupleMetadata_BaNHUZXcQBUKLNgEDWdDHjYV, _valueTuple.Item1, _valueTuple.Item2);
            return g_;
        }


        bool? c_((CqlTupleMetadata, CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)? tuple_banhuzxcqbuklngedwddhjyv) {
            CqlDate h_ = context.Operators.End(tuple_banhuzxcqbuklngedwddhjyv?.Coverage1);
            CqlDate i_ = context.Operators.Start(tuple_banhuzxcqbuklngedwddhjyv?.Coverage2);
            CqlQuantity j_ = context.Operators.Quantity(1m, "day");
            CqlDate k_ = context.Operators.Subtract(i_, j_);
            CqlDate l_ = context.Operators.Add(i_, j_);
            CqlInterval<CqlDate> m_ = context.Operators.Interval(k_, l_, true, true);
            bool? n_ = context.Operators.In<CqlDate>(h_, m_, (string)default);
            // CQL 'and' (24:5-25:55): right operand skipped when left is false
            if (n_ is false)
            {
                return false;
            }
            else
            {
                CqlDate o_ = context.Operators.Start(tuple_banhuzxcqbuklngedwddhjyv?.Coverage2);
                return n_ & (!((bool?)(o_ is null)));
            }
        }

        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)?> d_ = context.Operators.SelectWhere<ValueTuple<CqlInterval<CqlDate>, CqlInterval<CqlDate>>, (CqlTupleMetadata, CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)?>(a_, b_, c_);

        CqlInterval<CqlDate> e_((CqlTupleMetadata, CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)? tuple_banhuzxcqbuklngedwddhjyv) {
            CqlDate p_ = context.Operators.Start(tuple_banhuzxcqbuklngedwddhjyv?.Coverage1);
            CqlDate q_ = context.Operators.End(tuple_banhuzxcqbuklngedwddhjyv?.Coverage2);
            CqlInterval<CqlDate> r_ = context.Operators.Interval(p_, q_, true, true);
            return r_;
        }

        IEnumerable<CqlInterval<CqlDate>> f_ = context.Operators.SelectDistinct<(CqlTupleMetadata, CqlInterval<CqlDate> Coverage1, CqlInterval<CqlDate> Coverage2)?, CqlInterval<CqlDate>>(d_, e_);
        return f_;
    }


    [CqlFunctionDefinition("Collapsed Final Coverage Intervals")]
    public IEnumerable<CqlInterval<CqlDate>> Collapsed_Final_Coverage_Intervals(CqlContext context, IEnumerable<CqlInterval<CqlDate>> collapsedI, IEnumerable<CqlInterval<CqlDate>> adjacentI)
    {
        IEnumerable<CqlInterval<CqlDate>> a_ = this.Collapsed_Coverage_Intervals(context, collapsedI);
        IEnumerable<CqlInterval<CqlDate>> b_ = this.Collapsed_Coverage_Adjacent_Intervals(context, adjacentI);
        IEnumerable<CqlInterval<CqlDate>> c_ = context.Operators.Union<CqlInterval<CqlDate>>(a_, b_);
        IEnumerable<CqlInterval<CqlDate>> d_ = NCQACQLBase_1_0_0.Instance.Collapse_Date_Interval_Workaround(context, c_);
        return d_;
    }


    [CqlFunctionDefinition("All Coverage Info")]
    public IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> All_Coverage_Info(CqlContext context, IEnumerable<Coverage> Coverage, CqlInterval<CqlDate> participationPeriod)
    {

        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? a_(Coverage C) {
            IEnumerable<CqlInterval<CqlDate>> c_ = this.CoverageIntervals(context, Coverage, participationPeriod);
            IEnumerable<CqlInterval<CqlDate>> d_ = this.Collapsed_Coverage_Intervals(context, c_);
            IEnumerable<CqlInterval<CqlDate>> e_ = this.Collapsed_Coverage_Adjacent_Intervals(context, d_);
            IEnumerable<CqlInterval<CqlDate>> f_ = this.Collapsed_Final_Coverage_Intervals(context, d_, e_);
            (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? g_ = (CqlTupleMetadata_DPLIOBaSciHAAETJOMSIjWgbP, c_, d_, e_, f_);
            return g_;
        }

        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> b_ = context.Operators.SelectDistinct<Coverage, (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?>(Coverage, a_);
        return b_;
    }


    [CqlFunctionDefinition("Health Plan Enrollment Criteria")]
    public bool? Health_Plan_Enrollment_Criteria(CqlContext context, IEnumerable<Coverage> Coverage, CqlDate AnchorDate, CqlInterval<CqlDate> participationPeriod, int? AllowedGapDays)
    {
        IEnumerable<Coverage> a_ = this.Health_Plan_Coverage_Resources(context, Coverage);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> b_ = this.All_Coverage_Info(context, a_, participationPeriod);

        bool? c_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? @this) {
            IEnumerable<CqlInterval<CqlDate>> l_ = @this?.CollapsedFinal;
            return !((bool?)(l_ is null));
        }


        IEnumerable<CqlInterval<CqlDate>> d_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? @this) {
            IEnumerable<CqlInterval<CqlDate>> m_ = @this?.CollapsedFinal;
            return m_;
        }

        IEnumerable<IEnumerable<CqlInterval<CqlDate>>> e_ = context.Operators.WhereSelect<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?, IEnumerable<CqlInterval<CqlDate>>>(b_, c_, d_);
        IEnumerable<CqlInterval<CqlDate>> f_ = context.Operators.Flatten<CqlInterval<CqlDate>>(e_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? g_ = NCQACQLBase_1_0_0.Instance.Date_Interval_Gaps_Relative_to_Base_Interval_Stats(context, participationPeriod, f_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?[] h_ = [
            g_,
        ];

        bool? i_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? GapsInEnrollment) {
            int? n_ = GapsInEnrollment?.Interval_Count;
            bool? o_ = context.Operators.LessOrEqual(n_, 1);
            bool? p_;
            // CQL 'and' (48:14-49:79): right operand skipped when left is false
            if (o_ is false)
            {
                p_ = false;
            }
            else
            {
                int? q_ = GapsInEnrollment?.Total_Days_In_Longest_Interval;
                bool? r_ = context.Operators.LessOrEqual(q_, AllowedGapDays);
                p_ = o_ & r_;
            }
            // CQL 'and' (48:12-51:5): right operand skipped when left is false
            if (p_ is false)
            {
                return false;
            }
            else
            {
                bool? s_ = this.Anchor_Date_Criteria(context, Coverage, AnchorDate, participationPeriod);
                return p_ & s_;
            }
        }

        IEnumerable<bool?> j_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?, bool?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>)h_, i_);
        bool? k_ = context.Operators.SingletonFrom<bool?>(j_);
        return k_;
    }


    [CqlFunctionDefinition("Health Plan Coverage Resources")]
    public IEnumerable<Coverage> Health_Plan_Coverage_Resources(CqlContext context, IEnumerable<Coverage> Coverage)
    {

        bool? a_(Coverage C) {
            CodeableConcept e_ = C?.Type;
            List<Coding> f_ = e_?.Coding;

            bool? g_(Coding cTypeCoding) {
                CqlCode i_ = FHIRHelpers_4_0_001.Instance.ToCode(context, cTypeCoding);
                CqlCode j_ = NCQATerminology_1_0_0.Instance.managed_care_policy(context);
                bool? k_ = context.Operators.Equivalent(i_, j_);
                bool? l_;
                // CQL 'or' (56:15-57:86): right operand skipped when left is true
                if (k_ is true)
                {
                    l_ = true;
                }
                else
                {
                    CqlCode m_ = FHIRHelpers_4_0_001.Instance.ToCode(context, cTypeCoding);
                    CqlCode n_ = NCQATerminology_1_0_0.Instance.retiree_health_program(context);
                    bool? o_ = context.Operators.Equivalent(m_, n_);
                    l_ = k_ | o_;
                }
                // CQL 'or' (56:7-59:7): right operand skipped when left is true
                if (l_ is true)
                {
                    return true;
                }
                else
                {
                    CqlCode p_ = FHIRHelpers_4_0_001.Instance.ToCode(context, cTypeCoding);
                    CqlCode q_ = NCQATerminology_1_0_0.Instance.subsidized_health_program(context);
                    bool? r_ = context.Operators.Equivalent(p_, q_);
                    return l_ | r_;
                }
            }

            bool? h_ = context.Operators.WhereAny<Coding>((IEnumerable<Coding>)f_, g_);
            return h_;
        }

        IEnumerable<Coverage> b_ = context.Operators.Where<Coverage>(Coverage, a_);
        bool? c_(Coverage HPCoverageResource) => !((bool?)(HPCoverageResource is null));
        IEnumerable<Coverage> d_ = context.Operators.Where<Coverage>(b_, c_);
        return d_;
    }


    [CqlFunctionDefinition("Anchor Date Criteria")]
    public bool? Anchor_Date_Criteria(CqlContext context, IEnumerable<Coverage> Coverage, CqlDate AnchorDate, CqlInterval<CqlDate> participationPeriod)
    {
        if ((context.Operators.In<CqlDate>(AnchorDate, participationPeriod, (string)default)) ?? false)
        {
            IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> a_ = this.All_Coverage_Info(context, Coverage, participationPeriod);

            bool? b_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? @this) {
                IEnumerable<CqlInterval<CqlDate>> h_ = @this?.CollapsedFinal;
                return !((bool?)(h_ is null));
            }


            IEnumerable<CqlInterval<CqlDate>> c_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? @this) {
                IEnumerable<CqlInterval<CqlDate>> i_ = @this?.CollapsedFinal;
                return i_;
            }

            IEnumerable<IEnumerable<CqlInterval<CqlDate>>> d_ = context.Operators.WhereSelect<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?, IEnumerable<CqlInterval<CqlDate>>>(a_, b_, c_);
            IEnumerable<CqlInterval<CqlDate>> e_ = context.Operators.Flatten<CqlInterval<CqlDate>>(d_);

            bool? f_(CqlInterval<CqlDate> FinalInterval) {
                bool? j_ = context.Operators.In<CqlDate>(AnchorDate, FinalInterval, (string)default);
                return j_;
            }

            bool? g_ = context.Operators.WhereAny<CqlInterval<CqlDate>>(e_, f_);
            return g_;
        }
        else if ((!(context.Operators.In<CqlDate>(AnchorDate, participationPeriod, (string)default))) ?? false)
        {

            bool? k_(Coverage @this) {
                Period p_ = @this?.Period;
                return !((bool?)(p_ is null));
            }


            Period l_(Coverage @this) {
                Period q_ = @this?.Period;
                return q_;
            }

            IEnumerable<Period> m_ = context.Operators.WhereSelect<Coverage, Period>(Coverage, k_, l_);

            bool? n_(Period Cperiod) {
                CqlInterval<CqlDateTime> r_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, Cperiod);
                CqlDateTime s_ = context.Operators.Start(r_);
                CqlDate t_ = context.Operators.DateFrom(s_);
                CqlDateTime u_ = context.Operators.End(r_);
                CqlDate v_ = context.Operators.DateFrom(u_);
                CqlInterval<CqlDate> w_ = context.Operators.Interval(t_, v_, true, true);
                bool? x_ = context.Operators.In<CqlDate>(AnchorDate, w_, (string)default);
                return x_;
            }

            bool? o_ = context.Operators.WhereAny<Period>(m_, n_);
            return o_;
        }
        else if (AnchorDate is null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


    [CqlFunctionDefinition("Pharmacy Benefit Enrollment Criteria")]
    public bool? Pharmacy_Benefit_Enrollment_Criteria(CqlContext context, IEnumerable<Coverage> PharmCoverage, CqlDate AnchorDate, CqlInterval<CqlDate> participationPeriod, int? AllowedGapDays)
    {
        IEnumerable<Coverage> a_ = this.Pharmacy_Benefit_Coverage_Resources(context, PharmCoverage);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> b_ = this.All_Coverage_Info(context, a_, participationPeriod);

        bool? c_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? @this) {
            IEnumerable<CqlInterval<CqlDate>> l_ = @this?.CollapsedFinal;
            return !((bool?)(l_ is null));
        }


        IEnumerable<CqlInterval<CqlDate>> d_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? @this) {
            IEnumerable<CqlInterval<CqlDate>> m_ = @this?.CollapsedFinal;
            return m_;
        }

        IEnumerable<IEnumerable<CqlInterval<CqlDate>>> e_ = context.Operators.WhereSelect<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?, IEnumerable<CqlInterval<CqlDate>>>(b_, c_, d_);
        IEnumerable<CqlInterval<CqlDate>> f_ = context.Operators.Flatten<CqlInterval<CqlDate>>(e_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? g_ = NCQACQLBase_1_0_0.Instance.Date_Interval_Gaps_Relative_to_Base_Interval_Stats(context, participationPeriod, f_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?[] h_ = [
            g_,
        ];

        bool? i_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? GapsInEnrollment) {
            int? n_ = GapsInEnrollment?.Interval_Count;
            bool? o_ = context.Operators.LessOrEqual(n_, 1);
            bool? p_;
            // CQL 'and' (64:14-65:79): right operand skipped when left is false
            if (o_ is false)
            {
                p_ = false;
            }
            else
            {
                int? q_ = GapsInEnrollment?.Total_Days_In_Longest_Interval;
                bool? r_ = context.Operators.LessOrEqual(q_, AllowedGapDays);
                p_ = o_ & r_;
            }
            // CQL 'and' (64:12-67:5): right operand skipped when left is false
            if (p_ is false)
            {
                return false;
            }
            else
            {
                bool? s_ = this.Anchor_Date_Criteria(context, PharmCoverage, AnchorDate, participationPeriod);
                return p_ & s_;
            }
        }

        IEnumerable<bool?> j_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?, bool?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>)h_, i_);
        bool? k_ = context.Operators.SingletonFrom<bool?>(j_);
        return k_;
    }


    [CqlFunctionDefinition("Pharmacy Benefit Coverage Resources")]
    public IEnumerable<Coverage> Pharmacy_Benefit_Coverage_Resources(CqlContext context, IEnumerable<Coverage> Coverage)
    {

        bool? a_(Coverage C) {
            CodeableConcept e_ = C?.Type;
            List<Coding> f_ = e_?.Coding;

            bool? g_(Coding cTypeCoding) {
                CqlCode i_ = FHIRHelpers_4_0_001.Instance.ToCode(context, cTypeCoding);
                CqlCode j_ = NCQATerminology_1_0_0.Instance.drug_policy(context);
                bool? k_ = context.Operators.Equivalent(i_, j_);
                return k_;
            }

            bool? h_ = context.Operators.WhereAny<Coding>((IEnumerable<Coding>)f_, g_);
            return h_;
        }

        IEnumerable<Coverage> b_ = context.Operators.Where<Coverage>(Coverage, a_);
        bool? c_(Coverage pharmacyCoverageResource) => !((bool?)(pharmacyCoverageResource is null));
        IEnumerable<Coverage> d_ = context.Operators.Where<Coverage>(b_, c_);
        return d_;
    }


    [CqlFunctionDefinition("Mental Health Benefit Enrollment Criteria")]
    public bool? Mental_Health_Benefit_Enrollment_Criteria(CqlContext context, IEnumerable<Coverage> MHCoverage, CqlDate AnchorDate, CqlInterval<CqlDate> participationPeriod, int? AllowedGapDays)
    {
        IEnumerable<Coverage> a_ = this.Mental_Health_Benefit_Coverage_Resources(context, MHCoverage);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?> b_ = this.All_Coverage_Info(context, a_, participationPeriod);

        bool? c_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? @this) {
            IEnumerable<CqlInterval<CqlDate>> l_ = @this?.CollapsedFinal;
            return !((bool?)(l_ is null));
        }


        IEnumerable<CqlInterval<CqlDate>> d_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)? @this) {
            IEnumerable<CqlInterval<CqlDate>> m_ = @this?.CollapsedFinal;
            return m_;
        }

        IEnumerable<IEnumerable<CqlInterval<CqlDate>>> e_ = context.Operators.WhereSelect<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> IntervalInfo, IEnumerable<CqlInterval<CqlDate>> Collapsed, IEnumerable<CqlInterval<CqlDate>> Adjacent, IEnumerable<CqlInterval<CqlDate>> CollapsedFinal)?, IEnumerable<CqlInterval<CqlDate>>>(b_, c_, d_);
        IEnumerable<CqlInterval<CqlDate>> f_ = context.Operators.Flatten<CqlInterval<CqlDate>>(e_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? g_ = NCQACQLBase_1_0_0.Instance.Date_Interval_Gaps_Relative_to_Base_Interval_Stats(context, participationPeriod, f_);
        (CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?[] h_ = [
            g_,
        ];

        bool? i_((CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)? GapsInEnrollment) {
            int? n_ = GapsInEnrollment?.Interval_Count;
            bool? o_ = context.Operators.LessOrEqual(n_, 1);
            bool? p_;
            // CQL 'and' (78:14-79:79): right operand skipped when left is false
            if (o_ is false)
            {
                p_ = false;
            }
            else
            {
                int? q_ = GapsInEnrollment?.Total_Days_In_Longest_Interval;
                bool? r_ = context.Operators.LessOrEqual(q_, AllowedGapDays);
                p_ = o_ & r_;
            }
            // CQL 'and' (78:12-81:5): right operand skipped when left is false
            if (p_ is false)
            {
                return false;
            }
            else
            {
                bool? s_ = this.Anchor_Date_Criteria(context, MHCoverage, AnchorDate, participationPeriod);
                return p_ & s_;
            }
        }

        IEnumerable<bool?> j_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?, bool?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlInterval<CqlDate>> Intervals, int? Interval_Count, int? Total_Days_In_Intervals, CqlInterval<CqlDate> Longest_Interval, int? Total_Days_In_Longest_Interval)?>)h_, i_);
        bool? k_ = context.Operators.SingletonFrom<bool?>(j_);
        return k_;
    }


    [CqlFunctionDefinition("Mental Health Benefit Coverage Resources")]
    public IEnumerable<Coverage> Mental_Health_Benefit_Coverage_Resources(CqlContext context, IEnumerable<Coverage> Coverage)
    {

        bool? a_(Coverage C) {
            CodeableConcept e_ = C?.Type;
            List<Coding> f_ = e_?.Coding;

            bool? g_(Coding cTypeCoding) {
                CqlCode i_ = FHIRHelpers_4_0_001.Instance.ToCode(context, cTypeCoding);
                CqlCode j_ = NCQATerminology_1_0_0.Instance.mental_health_policy(context);
                bool? k_ = context.Operators.Equivalent(i_, j_);
                return k_;
            }

            bool? h_ = context.Operators.WhereAny<Coding>((IEnumerable<Coding>)f_, g_);
            return h_;
        }

        IEnumerable<Coverage> b_ = context.Operators.Where<Coverage>(Coverage, a_);
        bool? c_(Coverage mentalHealthCoverageResource) => !((bool?)(mentalHealthCoverageResource is null));
        IEnumerable<Coverage> d_ = context.Operators.Where<Coverage>(b_, c_);
        return d_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private NCQAHealthPlanEnrollment_1_0_0() {}

    public static NCQAHealthPlanEnrollment_1_0_0 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "NCQAHealthPlanEnrollment";
    public string Version => "1.0.0";
    public ILibrary[] Dependencies => [NCQACQLBase_1_0_0.Instance, FHIRHelpers_4_0_001.Instance, NCQATerminology_1_0_0.Instance, NCQAFHIRBase_1_0_0.Instance];

    #endregion ILibrary Implementation

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_BaNHUZXcQBUKLNgEDWdDHjYV = new(
       [typeof(CqlInterval<CqlDate>), typeof(CqlInterval<CqlDate>)],
       ["Coverage1", "Coverage2"]);

    private static CqlTupleMetadata CqlTupleMetadata_DPLIOBaSciHAAETJOMSIjWgbP = new(
       [typeof(IEnumerable<CqlInterval<CqlDate>>), typeof(IEnumerable<CqlInterval<CqlDate>>), typeof(IEnumerable<CqlInterval<CqlDate>>), typeof(IEnumerable<CqlInterval<CqlDate>>)],
       ["IntervalInfo", "Collapsed", "Adjacent", "CollapsedFinal"]);

    #endregion CqlTupleMetadata Properties

}
