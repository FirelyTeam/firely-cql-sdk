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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.6.0")]
[CqlLibrary("NCQAEncounter", "1.0.0")]
public partial class NCQAEncounter_1_0_0 : ILibrary, ISingleton<NCQAEncounter_1_0_0>
{
    #region Functions and Expressions (6)

    [CqlFunctionDefinition("Encounter Has Diagnosis")]
    public bool? Encounter_Has_Diagnosis(CqlContext context, Encounter Encounter, IEnumerable<Condition> Conditions)
    {
        List<Encounter.DiagnosisComponent> a_ = Encounter?.Diagnosis;

        FhirString b_(Encounter.DiagnosisComponent D) {
            ResourceReference g_ = D?.Condition;
            FhirString h_ = g_?.ReferenceElement;
            return h_;
        }

        IEnumerable<FhirString> c_ = context.Operators.SelectDistinct<Encounter.DiagnosisComponent, FhirString>((IEnumerable<Encounter.DiagnosisComponent>)a_, b_);

        bool? d_(FhirString CRef) {

            bool? i_(Condition C) {
                Id k_ = C?.IdElement;
                string l_ = FHIRHelpers_4_0_001.Instance.ToString(context, k_);
                string m_ = FHIRHelpers_4_0_001.Instance.ToString(context, CRef);
                string n_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, m_);
                CqlBoolean o_ = context.Operators.Equal(l_, n_);
                return o_;
            }

            CqlBoolean j_ = context.Operators.WhereAny<Condition>(Conditions, i_);
            return j_;
        }

        IEnumerable<bool?> e_ = context.Operators.SelectDistinct<FhirString, bool?>(c_, d_);
        CqlBoolean f_ = context.Operators.AnyTrue(e_);
        return f_;
    }


    [CqlFunctionDefinition("Encounter Has Principal Diagnosis")]
    public bool? Encounter_Has_Principal_Diagnosis(CqlContext context, Encounter Encounter, IEnumerable<Condition> Conditions)
    {
        List<Encounter.DiagnosisComponent> a_ = Encounter?.Diagnosis;

        bool? b_(Encounter.DiagnosisComponent D) {
            PositiveInt i_ = D?.RankElement;
            Integer j_ = context.Operators.Convert<Integer>(i_);
            int? k_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, j_);
            CqlBoolean l_ = context.Operators.Equal(k_, 1);
            return l_;
        }

        IEnumerable<Encounter.DiagnosisComponent> c_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)a_, b_);
        Encounter.DiagnosisComponent d_ = context.Operators.SingletonFrom<Encounter.DiagnosisComponent>(c_);
        Encounter.DiagnosisComponent[] e_ = [
            d_,
        ];

        bool? f_(Encounter.DiagnosisComponent PrincipalDiagnosis) {

            bool? m_(Condition C) {
                Id o_ = C?.IdElement;
                string p_ = FHIRHelpers_4_0_001.Instance.ToString(context, o_);
                ResourceReference q_ = PrincipalDiagnosis?.Condition;
                FhirString r_ = q_?.ReferenceElement;
                string s_ = FHIRHelpers_4_0_001.Instance.ToString(context, r_);
                string t_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, s_);
                CqlBoolean u_ = context.Operators.Equal(p_, t_);
                return u_;
            }

            CqlBoolean n_ = context.Operators.WhereAny<Condition>(Conditions, m_);
            return n_;
        }

        IEnumerable<bool?> g_ = context.Operators.SelectDistinct<Encounter.DiagnosisComponent, bool?>((IEnumerable<Encounter.DiagnosisComponent>)e_, f_);
        CqlBoolean h_ = context.Operators.SingletonFrom<bool?>(g_);
        return h_;
    }


    [CqlFunctionDefinition("Encounter Completed during Period")]
    public bool? Encounter_Completed_during_Period(CqlContext context, IEnumerable<Encounter> Enc, CqlInterval<CqlDateTime> timeperiod)
    {
        IEnumerable<Encounter> a_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, Enc);

        bool? b_(Encounter EncounterPeriod) {
            Period d_ = EncounterPeriod?.Period;
            CqlInterval<CqlDateTime> e_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, d_);
            CqlDateTime f_ = context.Operators.End(e_);
            CqlBoolean g_ = context.Operators.In<CqlDateTime>(f_, timeperiod, (string)default);
            return g_;
        }

        CqlBoolean c_ = context.Operators.WhereAny<Encounter>(a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("Finished Encounter with Telehealth POS")]
    public IEnumerable<Encounter> Finished_Encounter_with_Telehealth_POS(CqlContext context, IEnumerable<Encounter> Encounter)
    {
        IEnumerable<Encounter> a_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, Encounter);

        bool? b_(Encounter E) {
            Coding d_ = E?.Class;

            CqlBoolean e_() {
                Coding f_ = E?.Class;
                CqlCode g_ = FHIRHelpers_4_0_001.Instance.ToCode(context, f_);
                CqlCode h_ = NCQATerminology_1_0_0.Instance.@virtual(context);
                CqlBoolean i_ = context.Operators.Equivalent(g_, h_);
                return i_;
            }

            return (CqlBoolean)(!((bool?)(d_ is null)))
                /* CQL 'and' (34:5-35:64) */ && e_();
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("Finished Encounter with Outpatient POS")]
    public IEnumerable<Encounter> Finished_Encounter_with_Outpatient_POS(CqlContext context, IEnumerable<Encounter> Encounter)
    {
        IEnumerable<Encounter> a_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, Encounter);

        bool? b_(Encounter E) {
            Coding d_ = E?.Class;

            CqlBoolean e_() {
                Coding f_ = E?.Class;
                CqlCode g_ = FHIRHelpers_4_0_001.Instance.ToCode(context, f_);
                CqlCode h_ = NCQATerminology_1_0_0.Instance.ambulatory(context);
                CqlBoolean i_ = context.Operators.Equivalent(g_, h_);

                CqlBoolean j_() {
                    Coding k_ = E?.Class;
                    CqlCode l_ = FHIRHelpers_4_0_001.Instance.ToCode(context, k_);
                    CqlCode m_ = NCQATerminology_1_0_0.Instance.home_health(context);
                    CqlBoolean n_ = context.Operators.Equivalent(l_, m_);
                    return n_;
                }

                return i_
                    /* CQL 'or' (40:11-42:7) */ || j_();
            }

            return (CqlBoolean)(!((bool?)(d_ is null)))
                /* CQL 'and' (39:5-42:7) */ && e_();
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("Finished Encounter with Ambulatory POS")]
    public IEnumerable<Encounter> Finished_Encounter_with_Ambulatory_POS(CqlContext context, IEnumerable<Encounter> Encounter)
    {
        IEnumerable<Encounter> a_ = NCQAStatus_1_0_0.Instance.Finished_Encounter(context, Encounter);

        bool? b_(Encounter E) {
            Coding d_ = E?.Class;

            CqlBoolean e_() {
                Coding f_ = E?.Class;
                CqlCode g_ = FHIRHelpers_4_0_001.Instance.ToCode(context, f_);
                CqlCode h_ = NCQATerminology_1_0_0.Instance.ambulatory(context);
                CqlBoolean i_ = context.Operators.Equivalent(g_, h_);
                return i_;
            }

            return (CqlBoolean)(!((bool?)(d_ is null)))
                /* CQL 'and' (46:5-47:67) */ && e_();
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private NCQAEncounter_1_0_0() {}

    public static NCQAEncounter_1_0_0 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "NCQAEncounter";
    public string Version => "1.0.0";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_001.Instance, NCQAFHIRBase_1_0_0.Instance, NCQAStatus_1_0_0.Instance, NCQATerminology_1_0_0.Instance];

    #endregion ILibrary Implementation

}
