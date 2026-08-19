#nullable enable annotations

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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.0.0")]
[CqlLibrary("Antibiotic", "1.11.000")]
public partial class Antibiotic_1_11_000 : ILibrary, ISingleton<Antibiotic_1_11_000>
{
    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime?>? Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = -2145052723438296680L;

    private CqlInterval<CqlDateTime?>? Measurement_Period_Compute(CqlContext context)
    {
        object? a_ = context.ResolveParameter("Antibiotic-1.11.000", "Measurement Period", (object)null);
        return (CqlInterval<CqlDateTime>)a_;
    }


    #endregion Parameters

    #region Functions and Expressions (4)

    [CqlExpressionDefinition("Patient")]
    public Patient? Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = 620094810471492361L;

    private Patient? Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient?>? a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient? b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlFunctionDefinition("Encounter with Comorbid Condition History")]
    public IEnumerable<Encounter?>? Encounter_with_Comorbid_Condition_History(CqlContext context, IEnumerable<Encounter?>? episodes, IEnumerable<Condition?>? comorbidConditions)
    {

        bool? a_(Encounter? episode) {

            bool? e_(Condition? comcondition) {
                CqlInterval<CqlDateTime?>? g_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, comcondition as Condition);
                CqlDateTime? h_ = context.Operators.Start(g_);
                CqlDate? i_ = context.Operators.DateFrom(h_);
                Period? j_ = episode?.Period;
                CqlInterval<CqlDateTime?>? k_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, j_);
                CqlDateTime? l_ = context.Operators.Start(k_);
                CqlDate? m_ = context.Operators.DateFrom(l_);
                CqlQuantity? n_ = context.Operators.Quantity(1m, "year");
                CqlDate? o_ = context.Operators.Subtract(m_, n_);
                CqlInterval<CqlDate?>? p_ = context.Operators.Interval(o_, m_, true, true);
                bool? q_ = context.Operators.In<CqlDate>(i_, p_, (string)default);
                return q_;
            }

            bool? f_ = context.Operators.WhereAny<Condition>(comorbidConditions, e_);
            return f_;
        }

        Encounter? b_(Encounter? episode) => episode;
        IEnumerable<Encounter?>? c_ = context.Operators.WhereSelect<Encounter, Encounter>(episodes, a_, b_);
        IEnumerable<Encounter?>? d_ = context.Operators.Distinct<Encounter>(c_);
        return d_;
    }


    [CqlFunctionDefinition("Encounter with Competing Diagnosis History")]
    public IEnumerable<Encounter?>? Encounter_with_Competing_Diagnosis_History(CqlContext context, IEnumerable<Encounter?>? episodes, IEnumerable<Condition?>? competingConditions)
    {

        bool? a_(Encounter? episode) {

            bool? e_(Condition? competcondition) {
                CqlInterval<CqlDateTime?>? g_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, competcondition as Condition);
                CqlDateTime? h_ = context.Operators.Start(g_);
                Period? i_ = episode?.Period;
                CqlInterval<CqlDateTime?>? j_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, i_);
                CqlDateTime? k_ = context.Operators.Start(j_);
                CqlQuantity? l_ = context.Operators.Quantity(3m, "days");
                CqlDateTime? m_ = context.Operators.Add(k_, l_);
                CqlInterval<CqlDateTime?>? n_ = context.Operators.Interval(k_, m_, true, true);
                bool? o_ = context.Operators.In<CqlDateTime>(h_, n_, "day");
                bool? p_ = context.Operators.Not((bool?)(k_ is null));
                bool? q_ = context.Operators.And(o_, p_);
                return q_;
            }

            bool? f_ = context.Operators.WhereAny<Condition>(competingConditions, e_);
            return f_;
        }

        Encounter? b_(Encounter? episode) => episode;
        IEnumerable<Encounter?>? c_ = context.Operators.WhereSelect<Encounter, Encounter>(episodes, a_, b_);
        IEnumerable<Encounter?>? d_ = context.Operators.Distinct<Encounter>(c_);
        return d_;
    }


    [CqlFunctionDefinition("Encounter with Antibiotic Medication History")]
    public IEnumerable<Encounter?>? Encounter_with_Antibiotic_Medication_History(CqlContext context, IEnumerable<Encounter?>? episodes, IEnumerable<MedicationRequest?>? antibioticMedications)
    {

        bool? a_(Encounter? episode) {

            bool? c_(MedicationRequest? ActiveMedication) {
                CqlInterval<CqlDate?>? e_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, ActiveMedication);
                Period? f_ = episode?.Period;
                CqlInterval<CqlDateTime?>? g_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, f_);
                CqlDateTime? h_ = context.Operators.Start(g_);
                CqlDate? i_ = context.Operators.DateFrom(h_);
                CqlQuantity? j_ = context.Operators.Quantity(30m, "days");
                CqlDate? k_ = context.Operators.Subtract(i_, j_);
                CqlQuantity? l_ = context.Operators.Quantity(1m, "day");
                CqlDate? m_ = context.Operators.Subtract(i_, l_);
                CqlInterval<CqlDate?>? n_ = context.Operators.Interval(k_, m_, true, true);
                bool? o_ = context.Operators.Overlaps(e_, n_, "day");
                return o_;
            }

            bool? d_ = context.Operators.WhereAny<MedicationRequest>(antibioticMedications, c_);
            return d_;
        }

        IEnumerable<Encounter?>? b_ = context.Operators.Where<Encounter>(episodes, a_);
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
