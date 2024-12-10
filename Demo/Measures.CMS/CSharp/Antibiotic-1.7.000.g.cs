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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.8.0")]
[CqlLibrary("Antibiotic", "1.7.000")]
public partial class Antibiotic_1_7_000 : ILibrary, ISingleton<Antibiotic_1_7_000>
{
    private Antibiotic_1_7_000() {}

    public static Antibiotic_1_7_000 Instance { get; } = new();

    #region Library Members
    public string Name => "Antibiotic";
    public string Version => "1.7.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, QICoreCommon_2_1_000.Instance, CumulativeMedicationDuration_4_1_000.Instance];
    #endregion Library Members

    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object a_ = context.ResolveParameter("Antibiotic-1.7.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)a_;
    }


    [CqlDeclaration("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

        return b_;
    }

    public IEnumerable<Encounter> Has_Comorbid_Condition_History(CqlContext context, IEnumerable<Encounter> episodeDate, IEnumerable<Condition> comorbidConditions)
    {
        IEnumerable<Encounter> a_(Encounter eDate)
        {
            bool? e_(Condition comcondition)
            {
                CqlInterval<CqlDateTime> i_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, comcondition);
                CqlDateTime j_ = context.Operators.Start(i_);
                CqlDate k_ = context.Operators.DateFrom(j_);
                Period l_ = eDate?.Period;
                CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
                CqlInterval<CqlDateTime> n_ = QICoreCommon_2_1_000.Instance.toInterval(context, m_ as object);
                CqlDateTime o_ = context.Operators.Start(n_);
                CqlDate p_ = context.Operators.DateFrom(o_);
                CqlQuantity q_ = context.Operators.Quantity(1m, "year");
                CqlDate r_ = context.Operators.Subtract(p_, q_);
                CqlInterval<CqlDateTime> t_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
                CqlInterval<CqlDateTime> u_ = QICoreCommon_2_1_000.Instance.toInterval(context, t_ as object);
                CqlDateTime v_ = context.Operators.Start(u_);
                CqlDate w_ = context.Operators.DateFrom(v_);
                CqlInterval<CqlDate> x_ = context.Operators.Interval(r_, w_, true, true);
                bool? y_ = context.Operators.In<CqlDate>(k_, x_, default);

                return y_;
            };
            IEnumerable<Condition> f_ = context.Operators.Where<Condition>(comorbidConditions, e_);
            Encounter g_(Condition comcondition) => 
                eDate;
            IEnumerable<Encounter> h_ = context.Operators.Select<Condition, Encounter>(f_, g_);

            return h_;
        };
        IEnumerable<Encounter> b_ = context.Operators.SelectMany<Encounter, Encounter>(episodeDate, a_);
        Encounter c_(Encounter eDate) => 
            eDate;
        IEnumerable<Encounter> d_ = context.Operators.Select<Encounter, Encounter>(b_, c_);

        return d_;
    }

    public IEnumerable<Encounter> Has_Competing_Diagnosis_History(CqlContext context, IEnumerable<Encounter> episodeDate, IEnumerable<Condition> competingConditions)
    {
        IEnumerable<Encounter> a_(Encounter eDate)
        {
            bool? e_(Condition competcondition)
            {
                CqlInterval<CqlDateTime> i_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, competcondition);
                CqlDateTime j_ = context.Operators.Start(i_);
                Period k_ = eDate?.Period;
                CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
                CqlDateTime m_ = context.Operators.Start(l_);
                CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
                CqlDateTime p_ = context.Operators.Start(o_);
                CqlQuantity q_ = context.Operators.Quantity(3m, "days");
                CqlDateTime r_ = context.Operators.Add(p_, q_);
                CqlInterval<CqlDateTime> s_ = context.Operators.Interval(m_, r_, true, true);
                bool? t_ = context.Operators.In<CqlDateTime>(j_, s_, "day");
                CqlInterval<CqlDateTime> v_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
                CqlDateTime w_ = context.Operators.Start(v_);
                bool? x_ = context.Operators.Not((bool?)(w_ is null));
                bool? y_ = context.Operators.And(t_, x_);

                return y_;
            };
            IEnumerable<Condition> f_ = context.Operators.Where<Condition>(competingConditions, e_);
            Encounter g_(Condition competcondition) => 
                eDate;
            IEnumerable<Encounter> h_ = context.Operators.Select<Condition, Encounter>(f_, g_);

            return h_;
        };
        IEnumerable<Encounter> b_ = context.Operators.SelectMany<Encounter, Encounter>(episodeDate, a_);
        Encounter c_(Encounter eDate) => 
            eDate;
        IEnumerable<Encounter> d_ = context.Operators.Select<Encounter, Encounter>(b_, c_);

        return d_;
    }

    public IEnumerable<Encounter> Has_Antibiotic_Medication_History(CqlContext context, IEnumerable<Encounter> episodeDate, IEnumerable<MedicationRequest> antibioticMedications)
    {
        IEnumerable<Encounter> a_(Encounter DateOfEpisode)
        {
            bool? c_(MedicationRequest ActiveMedication)
            {
                CqlInterval<CqlDate> g_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, ActiveMedication);
                Period h_ = DateOfEpisode?.Period;
                CqlInterval<CqlDateTime> i_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, h_);
                CqlInterval<CqlDateTime> j_ = QICoreCommon_2_1_000.Instance.toInterval(context, i_ as object);
                CqlDateTime k_ = context.Operators.Start(j_);
                CqlDate l_ = context.Operators.DateFrom(k_);
                CqlQuantity m_ = context.Operators.Quantity(30m, "days");
                CqlDate n_ = context.Operators.Subtract(l_, m_);
                CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, h_);
                CqlInterval<CqlDateTime> q_ = QICoreCommon_2_1_000.Instance.toInterval(context, p_ as object);
                CqlDateTime r_ = context.Operators.Start(q_);
                CqlDate s_ = context.Operators.DateFrom(r_);
                CqlQuantity t_ = context.Operators.Quantity(1m, "day");
                CqlDate u_ = context.Operators.Subtract(s_, t_);
                CqlInterval<CqlDate> v_ = context.Operators.Interval(n_, u_, true, true);
                bool? w_ = context.Operators.Overlaps(g_, v_, "day");

                return w_;
            };
            IEnumerable<MedicationRequest> d_ = context.Operators.Where<MedicationRequest>(antibioticMedications, c_);
            Encounter e_(MedicationRequest ActiveMedication) => 
                DateOfEpisode;
            IEnumerable<Encounter> f_ = context.Operators.Select<MedicationRequest, Encounter>(d_, e_);

            return f_;
        };
        IEnumerable<Encounter> b_ = context.Operators.SelectMany<Encounter, Encounter>(episodeDate, a_);

        return b_;
    }

}
