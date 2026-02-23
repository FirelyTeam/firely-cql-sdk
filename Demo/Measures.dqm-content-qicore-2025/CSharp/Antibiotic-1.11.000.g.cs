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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.0.0.0")]
[CqlLibrary("Antibiotic", "1.11.000")]
public partial class Antibiotic_1_11_000 : ILibrary, ISingleton<Antibiotic_1_11_000>
{
    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<CqlInterval<CqlDateTime>>(-2145052723438296680L, () => {
            object a_ = context.ResolveParameter("Antibiotic-1.11.000", "Measurement Period", (object)null);
            return (CqlInterval<CqlDateTime>)a_;
        });


    #endregion Parameters

    #region Functions and Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<Patient>(620094810471492361L, () => {
            IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
            Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
            return b_;
        });


    [CqlFunctionDefinition("Encounter with Comorbid Condition History")]
    public IEnumerable<Encounter> Encounter_with_Comorbid_Condition_History(CqlContext context, IEnumerable<Encounter> episodes, IEnumerable<Condition> comorbidConditions)
    {

        IEnumerable<Encounter> a_(Encounter episode) {

            bool? f_(Condition comcondition) {
                CqlInterval<CqlDateTime> j_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, comcondition as object);
                CqlDateTime k_ = context.Operators.Start(j_);
                CqlDate l_ = context.Operators.DateFrom(k_);
                Period m_ = episode?.Period;
                CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, m_);
                CqlDateTime o_ = context.Operators.Start(n_);
                CqlDate p_ = context.Operators.DateFrom(o_);
                CqlQuantity q_ = context.Operators.Quantity(1m, "year");
                CqlDate r_ = context.Operators.Subtract(p_, q_);
                CqlInterval<CqlDateTime> t_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, m_);
                CqlDateTime u_ = context.Operators.Start(t_);
                CqlDate v_ = context.Operators.DateFrom(u_);
                CqlInterval<CqlDate> w_ = context.Operators.Interval(r_, v_, true, true);
                bool? x_ = context.Operators.In<CqlDate>(l_, w_, (string)default);
                return x_;
            }

            IEnumerable<Condition> g_ = context.Operators.Where<Condition>(comorbidConditions, f_);
            Encounter h_(Condition comcondition) => episode;
            IEnumerable<Encounter> i_ = context.Operators.Select<Condition, Encounter>(g_, h_);
            return i_;
        }

        IEnumerable<Encounter> b_ = context.Operators.SelectMany<Encounter, Encounter>(episodes, a_);
        Encounter c_(Encounter episode) => episode;
        IEnumerable<Encounter> d_ = context.Operators.Select<Encounter, Encounter>(b_, c_);
        IEnumerable<Encounter> e_ = context.Operators.Distinct<Encounter>(d_);
        return e_;
    }


    [CqlFunctionDefinition("Encounter with Competing Diagnosis History")]
    public IEnumerable<Encounter> Encounter_with_Competing_Diagnosis_History(CqlContext context, IEnumerable<Encounter> episodes, IEnumerable<Condition> competingConditions)
    {

        IEnumerable<Encounter> a_(Encounter episode) {

            bool? f_(Condition competcondition) {
                CqlInterval<CqlDateTime> j_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, competcondition as object);
                CqlDateTime k_ = context.Operators.Start(j_);
                Period l_ = episode?.Period;
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
            }

            IEnumerable<Condition> g_ = context.Operators.Where<Condition>(competingConditions, f_);
            Encounter h_(Condition competcondition) => episode;
            IEnumerable<Encounter> i_ = context.Operators.Select<Condition, Encounter>(g_, h_);
            return i_;
        }

        IEnumerable<Encounter> b_ = context.Operators.SelectMany<Encounter, Encounter>(episodes, a_);
        Encounter c_(Encounter episode) => episode;
        IEnumerable<Encounter> d_ = context.Operators.Select<Encounter, Encounter>(b_, c_);
        IEnumerable<Encounter> e_ = context.Operators.Distinct<Encounter>(d_);
        return e_;
    }


    [CqlFunctionDefinition("Encounter with Antibiotic Medication History")]
    public IEnumerable<Encounter> Encounter_with_Antibiotic_Medication_History(CqlContext context, IEnumerable<Encounter> episodes, IEnumerable<MedicationRequest> antibioticMedications)
    {

        IEnumerable<Encounter> a_(Encounter episode) {

            bool? c_(MedicationRequest ActiveMedication) {
                CqlInterval<CqlDate> g_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, ActiveMedication);
                Period h_ = episode?.Period;
                CqlInterval<CqlDateTime> i_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, h_);
                CqlDateTime j_ = context.Operators.Start(i_);
                CqlDate k_ = context.Operators.DateFrom(j_);
                CqlQuantity l_ = context.Operators.Quantity(30m, "days");
                CqlDate m_ = context.Operators.Subtract(k_, l_);
                CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, h_);
                CqlDateTime p_ = context.Operators.Start(o_);
                CqlDate q_ = context.Operators.DateFrom(p_);
                CqlQuantity r_ = context.Operators.Quantity(1m, "day");
                CqlDate s_ = context.Operators.Subtract(q_, r_);
                CqlInterval<CqlDate> t_ = context.Operators.Interval(m_, s_, true, true);
                bool? u_ = context.Operators.Overlaps(g_, t_, "day");
                return u_;
            }

            IEnumerable<MedicationRequest> d_ = context.Operators.Where<MedicationRequest>(antibioticMedications, c_);
            Encounter e_(MedicationRequest ActiveMedication) => episode;
            IEnumerable<Encounter> f_ = context.Operators.Select<MedicationRequest, Encounter>(d_, e_);
            return f_;
        }

        IEnumerable<Encounter> b_ = context.Operators.SelectMany<Encounter, Encounter>(episodes, a_);
        return b_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private Antibiotic_1_11_000() {}

    public static Antibiotic_1_11_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "Antibiotic";
    public string Version => "1.11.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, QICoreCommon_4_0_000.Instance, CumulativeMedicationDuration_6_0_000.Instance];

    #endregion ILibrary Implementation

}
