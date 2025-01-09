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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.9.0")]
[CqlLibrary("NCQAEncounter", "1.0.0")]
public partial class NCQAEncounter_1_0_0 : ILibrary, ISingleton<NCQAEncounter_1_0_0>
{
    private NCQAEncounter_1_0_0() {}

    public static NCQAEncounter_1_0_0 Instance { get; } = new();

    #region Library Members
    string ILibrary.Name => "NCQAEncounter";
    string ILibrary.Version => "1.0.0";
    IReadOnlyList<ILibrary> ILibrary.Dependencies => [FHIRHelpers_4_0_001.Instance, NCQAFHIRBase_1_0_0.Instance, NCQAStatus_1_0_0.Instance, NCQATerminology_1_0_0.Instance];
    #endregion Library Members
    public bool? Encounter_Has_Diagnosis(CqlContext context, Encounter Encounter, IEnumerable<Condition> Conditions)
    {
        List<Encounter.DiagnosisComponent> a_ = Encounter?.Diagnosis;
        FhirString b_(Encounter.DiagnosisComponent D)
        {
            ResourceReference i_ = D?.Condition;
            FhirString j_ = i_?.ReferenceElement;

            return j_;
        };
        IEnumerable<FhirString> c_ = context.Operators.Select<Encounter.DiagnosisComponent, FhirString>((IEnumerable<Encounter.DiagnosisComponent>)a_, b_);
        IEnumerable<FhirString> d_ = context.Operators.Distinct<FhirString>(c_);
        bool? e_(FhirString CRef)
        {
            bool? k_(Condition C)
            {
                Id n_ = C?.IdElement;
                string o_ = FHIRHelpers_4_0_001.Instance.ToString(context, n_);
                string p_ = FHIRHelpers_4_0_001.Instance.ToString(context, CRef);
                string q_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, p_);
                bool? r_ = context.Operators.Equal(o_, q_);

                return r_;
            };
            IEnumerable<Condition> l_ = context.Operators.Where<Condition>(Conditions, k_);
            bool? m_ = context.Operators.Exists<Condition>(l_);

            return m_;
        };
        IEnumerable<bool?> f_ = context.Operators.Select<FhirString, bool?>(d_, e_);
        IEnumerable<bool?> g_ = context.Operators.Distinct<bool?>(f_);
        bool? h_ = context.Operators.AnyTrue(g_);

        return h_;
    }


    public bool? Encounter_Has_Principal_Diagnosis(CqlContext context, Encounter Encounter, IEnumerable<Condition> Conditions)
    {
        List<Encounter.DiagnosisComponent> a_ = Encounter?.Diagnosis;
        bool? b_(Encounter.DiagnosisComponent D)
        {
            PositiveInt j_ = D?.RankElement;
            Integer k_ = context.Operators.Convert<Integer>(j_);
            int? l_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, k_);
            bool? m_ = context.Operators.Equal(l_, 1);

            return m_;
        };
        IEnumerable<Encounter.DiagnosisComponent> c_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)a_, b_);
        Encounter.DiagnosisComponent d_ = context.Operators.SingletonFrom<Encounter.DiagnosisComponent>(c_);
        Encounter.DiagnosisComponent[] e_ = [
            d_,
        ];
        bool? f_(Encounter.DiagnosisComponent PrincipalDiagnosis)
        {
            bool? n_(Condition C)
            {
                Id q_ = C?.IdElement;
                string r_ = FHIRHelpers_4_0_001.Instance.ToString(context, q_);
                ResourceReference s_ = PrincipalDiagnosis?.Condition;
                FhirString t_ = s_?.ReferenceElement;
                string u_ = FHIRHelpers_4_0_001.Instance.ToString(context, t_);
                string v_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, u_);
                bool? w_ = context.Operators.Equal(r_, v_);

                return w_;
            };
            IEnumerable<Condition> o_ = context.Operators.Where<Condition>(Conditions, n_);
            bool? p_ = context.Operators.Exists<Condition>(o_);

            return p_;
        };
        IEnumerable<bool?> g_ = context.Operators.Select<Encounter.DiagnosisComponent, bool?>((IEnumerable<Encounter.DiagnosisComponent>)e_, f_);
        IEnumerable<bool?> h_ = context.Operators.Distinct<bool?>(g_);
        bool? i_ = context.Operators.SingletonFrom<bool?>(h_);

        return i_;
    }


    public bool? Encounter_Completed_during_Period(CqlContext context, IEnumerable<Encounter> Enc, CqlInterval<CqlDateTime> timeperiod)
    {
        IEnumerable<Encounter> a_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, Enc);
        bool? b_(Encounter EncounterPeriod)
        {
            Period e_ = EncounterPeriod?.Period;
            CqlInterval<CqlDateTime> f_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, e_ as object);
            CqlDateTime g_ = context.Operators.End(f_);
            bool? h_ = context.Operators.In<CqlDateTime>(g_, timeperiod, default);

            return h_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        bool? d_ = context.Operators.Exists<Encounter>(c_);

        return d_;
    }


    public IEnumerable<Encounter> Finished_Encounter_with_Telehealth_POS(CqlContext context, IEnumerable<Encounter> Encounter)
    {
        IEnumerable<Encounter> a_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, Encounter);
        bool? b_(Encounter E)
        {
            Coding d_ = E?.Class;
            bool? e_ = context.Operators.Not((bool?)(d_ is null));
            CqlCode g_ = FHIRHelpers_4_0_001.Instance.ToCode(context, d_);
            CqlCode h_ = NCQATerminology_1_0_0.Instance.@virtual(context);
            bool? i_ = context.Operators.Equivalent(g_, h_);
            bool? j_ = context.Operators.And(e_, i_);

            return j_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    public IEnumerable<Encounter> Finished_Encounter_with_Outpatient_POS(CqlContext context, IEnumerable<Encounter> Encounter)
    {
        IEnumerable<Encounter> a_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, Encounter);
        bool? b_(Encounter E)
        {
            Coding d_ = E?.Class;
            bool? e_ = context.Operators.Not((bool?)(d_ is null));
            CqlCode g_ = FHIRHelpers_4_0_001.Instance.ToCode(context, d_);
            CqlCode h_ = NCQATerminology_1_0_0.Instance.ambulatory(context);
            bool? i_ = context.Operators.Equivalent(g_, h_);
            CqlCode k_ = FHIRHelpers_4_0_001.Instance.ToCode(context, d_);
            CqlCode l_ = NCQATerminology_1_0_0.Instance.home_health(context);
            bool? m_ = context.Operators.Equivalent(k_, l_);
            bool? n_ = context.Operators.Or(i_, m_);
            bool? o_ = context.Operators.And(e_, n_);

            return o_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    public IEnumerable<Encounter> Finished_Encounter_with_Ambulatory_POS(CqlContext context, IEnumerable<Encounter> Encounter)
    {
        IEnumerable<Encounter> a_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, Encounter);
        bool? b_(Encounter E)
        {
            Coding d_ = E?.Class;
            bool? e_ = context.Operators.Not((bool?)(d_ is null));
            CqlCode g_ = FHIRHelpers_4_0_001.Instance.ToCode(context, d_);
            CqlCode h_ = NCQATerminology_1_0_0.Instance.ambulatory(context);
            bool? i_ = context.Operators.Equivalent(g_, h_);
            bool? j_ = context.Operators.And(e_, i_);

            return j_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    private static CqlTupleMetadata CqlTupleMetadata_CaKghTfWMNOTHSWhifjFZOVYO = new(
        [typeof(CodeableConcept), typeof(Period)],
        ["code", "period"]);

    private static CqlTupleMetadata CqlTupleMetadata_EaLaedgLDgRRYaLbKIIcBTOiA = new(
        [typeof(Encounter), typeof(Encounter)],
        ["OutpatientEncounter1", "OutpatientEncounter2"]);

    private static CqlTupleMetadata CqlTupleMetadata_CgaDVOXeQBMgMPCPZOThIIdDb = new(
        [typeof(CqlInterval<CqlDateTime>), typeof(CqlInterval<CqlDateTime>)],
        ["LTCPeriod1", "LTCPeriod2"]);

    private static CqlTupleMetadata CqlTupleMetadata_CfANiScMYDdVZFgRERKJQEVca = new(
        [typeof(IEnumerable<CqlDate>)],
        ["SortedDates"]);

    private static CqlTupleMetadata CqlTupleMetadata_BDeBMdFeZaVSehBSFYjTFdYYD = new(
        [typeof(IEnumerable<CqlDate>), typeof(int?)],
        ["SortedList", "AnchorIndex"]);

    private static CqlTupleMetadata CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc = new(
        [typeof(CqlDate), typeof(IEnumerable<CqlDate>), typeof(int?)],
        ["NextDate", "NewList", "IndexofNewDate"]);

}
