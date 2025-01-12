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
[CqlLibrary("Antibiotic", "1.7.000")]
public partial class Antibiotic_1_7_000 : ILibrary, ISingleton<Antibiotic_1_7_000>
{
    private Antibiotic_1_7_000() {}

    public static Antibiotic_1_7_000 Instance { get; } = new();

    public string Name => "Antibiotic";
    public string Version => "1.7.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, QICoreCommon_2_1_000.Instance, CumulativeMedicationDuration_4_1_000.Instance];

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
            bool? f_(Condition comcondition)
            {
                CqlInterval<CqlDateTime> j_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, comcondition);
                CqlDateTime k_ = context.Operators.Start(j_);
                CqlDate l_ = context.Operators.DateFrom(k_);
                Period m_ = eDate?.Period;
                CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, m_);
                CqlInterval<CqlDateTime> o_ = QICoreCommon_2_1_000.Instance.toInterval(context, n_ as object);
                CqlDateTime p_ = context.Operators.Start(o_);
                CqlDate q_ = context.Operators.DateFrom(p_);
                CqlQuantity r_ = context.Operators.Quantity(1m, "year");
                CqlDate s_ = context.Operators.Subtract(q_, r_);
                CqlInterval<CqlDateTime> u_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, m_);
                CqlInterval<CqlDateTime> v_ = QICoreCommon_2_1_000.Instance.toInterval(context, u_ as object);
                CqlDateTime w_ = context.Operators.Start(v_);
                CqlDate x_ = context.Operators.DateFrom(w_);
                CqlInterval<CqlDate> y_ = context.Operators.Interval(s_, x_, true, true);
                bool? z_ = context.Operators.In<CqlDate>(l_, y_, default);

                return z_;
            };
            IEnumerable<Condition> g_ = context.Operators.Where<Condition>(comorbidConditions, f_);
            Encounter h_(Condition comcondition) =>
                eDate;
            IEnumerable<Encounter> i_ = context.Operators.Select<Condition, Encounter>(g_, h_);

            return i_;
        };
        IEnumerable<Encounter> b_ = context.Operators.SelectMany<Encounter, Encounter>(episodeDate, a_);
        Encounter c_(Encounter eDate) =>
            eDate;
        IEnumerable<Encounter> d_ = context.Operators.Select<Encounter, Encounter>(b_, c_);
        IEnumerable<Encounter> e_ = context.Operators.Distinct<Encounter>(d_);

        return e_;
    }

    public IEnumerable<Encounter> Has_Competing_Diagnosis_History(CqlContext context, IEnumerable<Encounter> episodeDate, IEnumerable<Condition> competingConditions)
    {
        IEnumerable<Encounter> a_(Encounter eDate)
        {
            bool? f_(Condition competcondition)
            {
                CqlInterval<CqlDateTime> j_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, competcondition);
                CqlDateTime k_ = context.Operators.Start(j_);
                Period l_ = eDate?.Period;
                CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
                CqlDateTime n_ = context.Operators.Start(m_);
                CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
                CqlDateTime q_ = context.Operators.Start(p_);
                CqlQuantity r_ = context.Operators.Quantity(3m, "days");
                CqlDateTime s_ = context.Operators.Add(q_, r_);
                CqlInterval<CqlDateTime> t_ = context.Operators.Interval(n_, s_, true, true);
                bool? u_ = context.Operators.In<CqlDateTime>(k_, t_, "day");
                CqlInterval<CqlDateTime> w_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
                CqlDateTime x_ = context.Operators.Start(w_);
                bool? y_ = context.Operators.Not((bool?)(x_ is null));
                bool? z_ = context.Operators.And(u_, y_);

                return z_;
            };
            IEnumerable<Condition> g_ = context.Operators.Where<Condition>(competingConditions, f_);
            Encounter h_(Condition competcondition) =>
                eDate;
            IEnumerable<Encounter> i_ = context.Operators.Select<Condition, Encounter>(g_, h_);

            return i_;
        };
        IEnumerable<Encounter> b_ = context.Operators.SelectMany<Encounter, Encounter>(episodeDate, a_);
        Encounter c_(Encounter eDate) =>
            eDate;
        IEnumerable<Encounter> d_ = context.Operators.Select<Encounter, Encounter>(b_, c_);
        IEnumerable<Encounter> e_ = context.Operators.Distinct<Encounter>(d_);

        return e_;
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
