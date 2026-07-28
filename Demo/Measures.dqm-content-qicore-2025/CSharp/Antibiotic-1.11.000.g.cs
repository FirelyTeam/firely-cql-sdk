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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.5.0")]
[CqlLibrary("Antibiotic", "1.11.000")]
public partial class Antibiotic_1_11_000 : ILibrary, ISingleton<Antibiotic_1_11_000>
{
    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = -2145052723438296680L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        object a_ = context.ResolveParameter("Antibiotic-1.11.000", "Measurement Period", (object)null);
        return (CqlInterval<CqlDateTime>)a_;
    }


    #endregion Parameters

    #region Functions and Expressions (4)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = 620094810471492361L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlFunctionDefinition("Encounter with Comorbid Condition History")]
    public IEnumerable<Encounter> Encounter_with_Comorbid_Condition_History(CqlContext context, IEnumerable<Encounter> episodes, IEnumerable<Condition> comorbidConditions)
    {

        bool? a_(Encounter episode) {

            bool? f_(Condition comcondition) {
                CqlInterval<CqlDateTime> i_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, comcondition as Condition);
                CqlDateTime j_ = context.Operators.Start(i_);
                CqlDate k_ = context.Operators.DateFrom(j_);
                Period l_ = episode?.Period;
                CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
                CqlDateTime n_ = context.Operators.Start(m_);
                CqlDate o_ = context.Operators.DateFrom(n_);
                CqlQuantity p_ = context.Operators.Quantity(1m, "year");
                CqlDate q_ = context.Operators.Subtract(o_, p_);
                CqlInterval<CqlDate> r_ = context.Operators.Interval(q_, o_, true, true);
                bool? s_ = context.Operators.In<CqlDate>(k_, r_, (string)default);
                return s_;
            }

            IEnumerable<Condition> g_ = context.Operators.Where<Condition>(comorbidConditions, f_);
            bool? h_ = context.Operators.Exists<Condition>(g_);
            return h_;
        }

        IEnumerable<Encounter> b_ = context.Operators.Where<Encounter>(episodes, a_);
        Encounter c_(Encounter episode) => episode;
        IEnumerable<Encounter> d_ = context.Operators.Select<Encounter, Encounter>(b_, c_);
        IEnumerable<Encounter> e_ = context.Operators.Distinct<Encounter>(d_);
        return e_;
    }


    [CqlFunctionDefinition("Encounter with Competing Diagnosis History")]
    public IEnumerable<Encounter> Encounter_with_Competing_Diagnosis_History(CqlContext context, IEnumerable<Encounter> episodes, IEnumerable<Condition> competingConditions)
    {

        bool? a_(Encounter episode) {

            bool? f_(Condition competcondition) {
                CqlInterval<CqlDateTime> i_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, competcondition as Condition);
                CqlDateTime j_ = context.Operators.Start(i_);
                Period k_ = episode?.Period;
                CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
                CqlDateTime m_ = context.Operators.Start(l_);
                CqlQuantity n_ = context.Operators.Quantity(3m, "days");
                CqlDateTime o_ = context.Operators.Add(m_, n_);
                CqlInterval<CqlDateTime> p_ = context.Operators.Interval(m_, o_, true, true);
                bool? q_ = context.Operators.In<CqlDateTime>(j_, p_, "day");
                bool? r_ = context.Operators.Not((bool?)(m_ is null));
                bool? s_ = context.Operators.And(q_, r_);
                return s_;
            }

            IEnumerable<Condition> g_ = context.Operators.Where<Condition>(competingConditions, f_);
            bool? h_ = context.Operators.Exists<Condition>(g_);
            return h_;
        }

        IEnumerable<Encounter> b_ = context.Operators.Where<Encounter>(episodes, a_);
        Encounter c_(Encounter episode) => episode;
        IEnumerable<Encounter> d_ = context.Operators.Select<Encounter, Encounter>(b_, c_);
        IEnumerable<Encounter> e_ = context.Operators.Distinct<Encounter>(d_);
        return e_;
    }


    [CqlFunctionDefinition("Encounter with Antibiotic Medication History")]
    public IEnumerable<Encounter> Encounter_with_Antibiotic_Medication_History(CqlContext context, IEnumerable<Encounter> episodes, IEnumerable<MedicationRequest> antibioticMedications)
    {

        bool? a_(Encounter episode) {

            bool? c_(MedicationRequest ActiveMedication) {
                CqlInterval<CqlDate> f_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, ActiveMedication);
                Period g_ = episode?.Period;
                CqlInterval<CqlDateTime> h_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, g_);
                CqlDateTime i_ = context.Operators.Start(h_);
                CqlDate j_ = context.Operators.DateFrom(i_);
                CqlQuantity k_ = context.Operators.Quantity(30m, "days");
                CqlDate l_ = context.Operators.Subtract(j_, k_);
                CqlQuantity m_ = context.Operators.Quantity(1m, "day");
                CqlDate n_ = context.Operators.Subtract(j_, m_);
                CqlInterval<CqlDate> o_ = context.Operators.Interval(l_, n_, true, true);
                bool? p_ = context.Operators.Overlaps(f_, o_, "day");
                return p_;
            }

            IEnumerable<MedicationRequest> d_ = context.Operators.Where<MedicationRequest>(antibioticMedications, c_);
            bool? e_ = context.Operators.Exists<MedicationRequest>(d_);
            return e_;
        }

        IEnumerable<Encounter> b_ = context.Operators.Where<Encounter>(episodes, a_);
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
