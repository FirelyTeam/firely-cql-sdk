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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "3.1.0.0")]
[CqlLibrary("CMS72FHIRSTKAntithromboticDay2", "0.7.002")]
public partial class CMS72FHIRSTKAntithromboticDay2_0_7_002 : ILibrary, ISingleton<CMS72FHIRSTKAntithromboticDay2_0_7_002>
{
    private CMS72FHIRSTKAntithromboticDay2_0_7_002() {}

    public static CMS72FHIRSTKAntithromboticDay2_0_7_002 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "CMS72FHIRSTKAntithromboticDay2";
    public string Version => "0.7.002";
    public ILibrary[] Dependencies => [CQMCommon_4_1_000.Instance, QICoreCommon_4_0_000.Instance, FHIRHelpers_4_4_000.Instance, SupplementalDataElements_5_1_000.Instance, TJCOverall_8_24_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    [CqlValueSetDefinition("Antithrombotic Therapy for Ischemic Stroke", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.62", valueSetVersion: null)]
    public CqlValueSet Antithrombotic_Therapy_for_Ischemic_Stroke(CqlContext _) => _Antithrombotic_Therapy_for_Ischemic_Stroke;
    private static readonly CqlValueSet _Antithrombotic_Therapy_for_Ischemic_Stroke = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.62", null);

    [CqlValueSetDefinition("INR", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.213", valueSetVersion: null)]
    public CqlValueSet INR(CqlContext _) => _INR;
    private static readonly CqlValueSet _INR = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.213", null);

    [CqlValueSetDefinition("Intravenous or Intraarterial Thrombolytic tPA Therapy Prior to Arrival", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.21", valueSetVersion: null)]
    public CqlValueSet Intravenous_or_Intraarterial_Thrombolytic_tPA_Therapy_Prior_to_Arrival(CqlContext _) => _Intravenous_or_Intraarterial_Thrombolytic_tPA_Therapy_Prior_to_Arrival;
    private static readonly CqlValueSet _Intravenous_or_Intraarterial_Thrombolytic_tPA_Therapy_Prior_to_Arrival = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.21", null);

    [CqlValueSetDefinition("Intravenous or Intraarterial Thrombolytic tPA Therapy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.21", valueSetVersion: null)]
    public CqlValueSet Intravenous_or_Intraarterial_Thrombolytic_tPA_Therapy(CqlContext _) => _Intravenous_or_Intraarterial_Thrombolytic_tPA_Therapy;
    private static readonly CqlValueSet _Intravenous_or_Intraarterial_Thrombolytic_tPA_Therapy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.21", null);

    [CqlValueSetDefinition("Medical Reason for Not Providing Treatment", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.473", valueSetVersion: null)]
    public CqlValueSet Medical_Reason_for_Not_Providing_Treatment(CqlContext _) => _Medical_Reason_for_Not_Providing_Treatment;
    private static readonly CqlValueSet _Medical_Reason_for_Not_Providing_Treatment = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.473", null);

    [CqlValueSetDefinition("Patient Refusal", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.93", valueSetVersion: null)]
    public CqlValueSet Patient_Refusal(CqlContext _) => _Patient_Refusal;
    private static readonly CqlValueSet _Patient_Refusal = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.93", null);

    [CqlValueSetDefinition("Pharmacological Contraindications For Antithrombotic Therapy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.52", valueSetVersion: null)]
    public CqlValueSet Pharmacological_Contraindications_For_Antithrombotic_Therapy(CqlContext _) => _Pharmacological_Contraindications_For_Antithrombotic_Therapy;
    private static readonly CqlValueSet _Pharmacological_Contraindications_For_Antithrombotic_Therapy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.52", null);

    [CqlValueSetDefinition("Thrombolytic tPA Therapy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.226", valueSetVersion: null)]
    public CqlValueSet Thrombolytic_tPA_Therapy(CqlContext _) => _Thrombolytic_tPA_Therapy;
    private static readonly CqlValueSet _Thrombolytic_tPA_Therapy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.226", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("fulfill", codeId: "fulfill", codeSystem: "http://hl7.org/fhir/CodeSystem/task-code")]
    public CqlCode fulfill(CqlContext _) => _fulfill;
    private static readonly CqlCode _fulfill = new CqlCode("fulfill", "http://hl7.org/fhir/CodeSystem/task-code");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("TaskCode", codeSystemId: "http://hl7.org/fhir/CodeSystem/task-code", codeSystemVersion: null)]
    public CqlCodeSystem TaskCode(CqlContext _) => _TaskCode;
    private static readonly CqlCodeSystem _TaskCode =
      new CqlCodeSystem("http://hl7.org/fhir/CodeSystem/task-code", null, [
          _fulfill]);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object a_ = context.ResolveParameter("CMS72FHIRSTKAntithromboticDay2-0.7.002", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)a_;
    }


    #endregion Parameters

    #region Functions and Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

        return b_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context)
    {
        IEnumerable<Encounter> a_ = TJCOverall_8_24_000.Instance.Ischemic_Stroke_Encounter(context);

        return a_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);

        return a_;
    }


    [CqlExpressionDefinition("Encounter Less Than Two Days")]
    public IEnumerable<Encounter> Encounter_Less_Than_Two_Days(CqlContext context)
    {
        IEnumerable<Encounter> a_ = TJCOverall_8_24_000.Instance.Ischemic_Stroke_Encounter(context);
        bool? b_(Encounter IschemicStrokeEncounter)
        {
            CqlInterval<CqlDateTime> d_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, IschemicStrokeEncounter);
            int? e_ = CQMCommon_4_1_000.Instance.lengthInDays(context, d_);
            bool? f_ = context.Operators.Less(e_, 2);

            return f_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Encounter With Comfort Measures During Day Of Or Day After Arrival")]
    public IEnumerable<Encounter> Encounter_With_Comfort_Measures_During_Day_Of_Or_Day_After_Arrival(CqlContext context)
    {
        IEnumerable<Encounter> a_ = TJCOverall_8_24_000.Instance.Ischemic_Stroke_Encounter(context);
        IEnumerable<Encounter> b_(Encounter IschemicStrokeEncounter)
        {
            IEnumerable<object> d_ = TJCOverall_8_24_000.Instance.Intervention_Comfort_Measures(context);
            bool? e_(object ComfortMeasure)
            {
                object i_()
                {
                    bool ah_()
                    {
                        object al_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                        object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                        bool an_ = am_ is CqlDateTime;

                        return an_;
                    };
                    bool ai_()
                    {
                        object ao_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                        object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                        bool aq_ = ap_ is CqlInterval<CqlDateTime>;

                        return aq_;
                    };
                    bool aj_()
                    {
                        object ar_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                        object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                        bool at_ = as_ is CqlQuantity;

                        return at_;
                    };
                    bool ak_()
                    {
                        object au_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                        object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                        bool aw_ = av_ is CqlInterval<CqlQuantity>;

                        return aw_;
                    };
                    if (ah_())
                    {
                        object ax_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                        object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);

                        return (ay_ as CqlDateTime) as object;
                    }
                    else if (ai_())
                    {
                        object az_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                        object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);

                        return (ba_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (aj_())
                    {
                        object bb_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                        object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);

                        return (bc_ as CqlQuantity) as object;
                    }
                    else if (ak_())
                    {
                        object bd_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                        object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);

                        return (be_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlInterval<CqlDateTime> j_ = QICoreCommon_4_0_000.Instance.toInterval(context, i_());
                CqlDateTime k_ = context.Operators.Start(j_);
                object l_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "authoredOn");
                CqlDateTime m_ = context.Operators.LateBoundProperty<CqlDateTime>(l_, "value");
                CqlInterval<CqlDateTime> n_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, IschemicStrokeEncounter);
                CqlDateTime o_ = context.Operators.Start(n_);
                CqlInterval<CqlDate> p_ = TJCOverall_8_24_000.Instance.CalendarDayOfOrDayAfter(context, o_);
                CqlDate q_ = p_?.low;
                CqlDateTime r_ = context.Operators.ConvertDateToDateTime(q_);
                CqlDateTime t_ = context.Operators.Start(n_);
                CqlInterval<CqlDate> u_ = TJCOverall_8_24_000.Instance.CalendarDayOfOrDayAfter(context, t_);
                CqlDate v_ = u_?.high;
                CqlDateTime w_ = context.Operators.ConvertDateToDateTime(v_);
                CqlDateTime y_ = context.Operators.Start(n_);
                CqlInterval<CqlDate> z_ = TJCOverall_8_24_000.Instance.CalendarDayOfOrDayAfter(context, y_);
                bool? aa_ = z_?.lowClosed;
                CqlDateTime ac_ = context.Operators.Start(n_);
                CqlInterval<CqlDate> ad_ = TJCOverall_8_24_000.Instance.CalendarDayOfOrDayAfter(context, ac_);
                bool? ae_ = ad_?.highClosed;
                CqlInterval<CqlDateTime> af_ = context.Operators.Interval(r_, w_, aa_, ae_);
                bool? ag_ = context.Operators.In<CqlDateTime>(k_ ?? m_, af_, "day");

                return ag_;
            };
            IEnumerable<object> f_ = context.Operators.Where<object>(d_, e_);
            Encounter g_(object ComfortMeasure) =>
                IschemicStrokeEncounter;
            IEnumerable<Encounter> h_ = context.Operators.Select<object, Encounter>(f_, g_);

            return h_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Thrombolytic Therapy Medication Or Procedures")]
    public IEnumerable<object> Thrombolytic_Therapy_Medication_Or_Procedures(CqlContext context)
    {
        CqlValueSet a_ = this.Thrombolytic_tPA_Therapy(context);
        IEnumerable<MedicationAdministration> b_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        bool? c_(MedicationAdministration ThrombolyticMedication)
        {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> p_ = ThrombolyticMedication?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? q_ = p_?.Value;
            string r_ = context.Operators.Convert<string>(q_);
            string[] s_ = [
                "in-progress",
                "completed",
            ];
            bool? t_ = context.Operators.In<string>(r_, (IEnumerable<string>)s_);

            return t_;
        };
        IEnumerable<MedicationAdministration> d_ = context.Operators.Where<MedicationAdministration>(b_, c_);
        (CqlTupleMetadata, string id, object effective)? e_(MedicationAdministration ThrombolyticMedication)
        {
            Id u_ = ThrombolyticMedication?.IdElement;
            string v_ = u_?.Value;
            DataType w_ = ThrombolyticMedication?.Effective;
            object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
            (CqlTupleMetadata, string id, object effective)? y_ = (CqlTupleMetadata_DbNFZJaRJHECUfPGBeWSUEUQi, v_, x_);

            return y_;
        };
        IEnumerable<(CqlTupleMetadata, string id, object effective)?> f_ = context.Operators.Select<MedicationAdministration, (CqlTupleMetadata, string id, object effective)?>(d_, e_);
        IEnumerable<(CqlTupleMetadata, string id, object effective)?> g_ = context.Operators.Distinct<(CqlTupleMetadata, string id, object effective)?>(f_);
        CqlValueSet h_ = this.Intravenous_or_Intraarterial_Thrombolytic_tPA_Therapy(context);
        IEnumerable<Procedure> i_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        bool? j_(Procedure ThrombolyticProcedure)
        {
            Code<EventStatus> z_ = ThrombolyticProcedure?.StatusElement;
            EventStatus? aa_ = z_?.Value;
            string ab_ = context.Operators.Convert<string>(aa_);
            bool? ac_ = context.Operators.Equal(ab_, "completed");

            return ac_;
        };
        IEnumerable<Procedure> k_ = context.Operators.Where<Procedure>(i_, j_);
        (CqlTupleMetadata, string id, object effective)? l_(Procedure ThrombolyticProcedure)
        {
            Id ad_ = ThrombolyticProcedure?.IdElement;
            string ae_ = ad_?.Value;
            DataType af_ = ThrombolyticProcedure?.Performed;
            object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
            (CqlTupleMetadata, string id, object effective)? ah_ = (CqlTupleMetadata_DbNFZJaRJHECUfPGBeWSUEUQi, ae_, ag_);

            return ah_;
        };
        IEnumerable<(CqlTupleMetadata, string id, object effective)?> m_ = context.Operators.Select<Procedure, (CqlTupleMetadata, string id, object effective)?>(k_, l_);
        IEnumerable<(CqlTupleMetadata, string id, object effective)?> n_ = context.Operators.Distinct<(CqlTupleMetadata, string id, object effective)?>(m_);
        IEnumerable<object> o_ = context.Operators.Union<object>(g_ as IEnumerable<object>, n_ as IEnumerable<object>);

        return o_;
    }


    [CqlExpressionDefinition("Encounter With Thrombolytic Therapy Medication Or Procedures")]
    public IEnumerable<Encounter> Encounter_With_Thrombolytic_Therapy_Medication_Or_Procedures(CqlContext context)
    {
        IEnumerable<Encounter> a_ = TJCOverall_8_24_000.Instance.Ischemic_Stroke_Encounter(context);
        IEnumerable<Encounter> b_(Encounter IschemicStrokeEncounter)
        {
            IEnumerable<object> d_ = this.Thrombolytic_Therapy_Medication_Or_Procedures(context);
            bool? e_(object ThrombolyticTherapy)
            {
                object i_()
                {
                    bool t_()
                    {
                        object z_ = context.Operators.LateBoundProperty<object>(ThrombolyticTherapy, "effective");
                        bool aa_ = z_ is CqlDateTime;

                        return aa_;
                    };
                    bool u_()
                    {
                        object ab_ = context.Operators.LateBoundProperty<object>(ThrombolyticTherapy, "effective");
                        bool ac_ = ab_ is CqlInterval<CqlDateTime>;

                        return ac_;
                    };
                    bool v_()
                    {
                        object ad_ = context.Operators.LateBoundProperty<object>(ThrombolyticTherapy, "effective");
                        bool ae_ = ad_ is CqlQuantity;

                        return ae_;
                    };
                    bool w_()
                    {
                        object af_ = context.Operators.LateBoundProperty<object>(ThrombolyticTherapy, "effective");
                        bool ag_ = af_ is CqlInterval<CqlQuantity>;

                        return ag_;
                    };
                    bool x_()
                    {
                        object ah_ = context.Operators.LateBoundProperty<object>(ThrombolyticTherapy, "effective");
                        bool ai_ = ah_ is CqlDateTime;

                        return ai_;
                    };
                    bool y_()
                    {
                        object aj_ = context.Operators.LateBoundProperty<object>(ThrombolyticTherapy, "effective");
                        bool ak_ = aj_ is CqlInterval<CqlDateTime>;

                        return ak_;
                    };
                    if (t_())
                    {
                        object al_ = context.Operators.LateBoundProperty<object>(ThrombolyticTherapy, "effective");

                        return (al_ as CqlDateTime) as object;
                    }
                    else if (u_())
                    {
                        object am_ = context.Operators.LateBoundProperty<object>(ThrombolyticTherapy, "effective");

                        return (am_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (v_())
                    {
                        object an_ = context.Operators.LateBoundProperty<object>(ThrombolyticTherapy, "effective");

                        return (an_ as CqlQuantity) as object;
                    }
                    else if (w_())
                    {
                        object ao_ = context.Operators.LateBoundProperty<object>(ThrombolyticTherapy, "effective");

                        return (ao_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else if (x_())
                    {
                        object ap_ = context.Operators.LateBoundProperty<object>(ThrombolyticTherapy, "effective");

                        return (ap_ as CqlDateTime) as object;
                    }
                    else if (y_())
                    {
                        object aq_ = context.Operators.LateBoundProperty<object>(ThrombolyticTherapy, "effective");

                        return (aq_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else
                    {
                        return null;
                    }
                };
                CqlInterval<CqlDateTime> j_ = QICoreCommon_4_0_000.Instance.toInterval(context, i_());
                CqlDateTime k_ = context.Operators.Start(j_);
                CqlInterval<CqlDateTime> l_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, IschemicStrokeEncounter);
                CqlDateTime m_ = context.Operators.Start(l_);
                CqlQuantity n_ = context.Operators.Quantity(24m, "hours");
                CqlDateTime o_ = context.Operators.Subtract(m_, n_);
                CqlDateTime q_ = context.Operators.End(l_);
                CqlInterval<CqlDateTime> r_ = context.Operators.Interval(o_, q_, true, false);
                bool? s_ = context.Operators.In<CqlDateTime>(k_, r_, default);

                return s_;
            };
            IEnumerable<object> f_ = context.Operators.Where<object>(d_, e_);
            Encounter g_(object ThrombolyticTherapy) =>
                IschemicStrokeEncounter;
            IEnumerable<Encounter> h_ = context.Operators.Select<object, Encounter>(f_, g_);

            return h_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Encounter With Thrombolytic Therapy Prior To Arrival")]
    public IEnumerable<Encounter> Encounter_With_Thrombolytic_Therapy_Prior_To_Arrival(CqlContext context)
    {
        IEnumerable<Encounter> a_ = TJCOverall_8_24_000.Instance.Ischemic_Stroke_Encounter(context);
        bool? b_(Encounter IschemicStrokeEncounter)
        {
            IEnumerable<object> d_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, IschemicStrokeEncounter);
            bool? e_(object EncounterDiagnosis)
            {
                object h_ = context.Operators.LateBoundProperty<object>(EncounterDiagnosis, "code");
                CqlConcept i_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, h_ as CodeableConcept);
                CqlValueSet j_ = this.Intravenous_or_Intraarterial_Thrombolytic_tPA_Therapy_Prior_to_Arrival(context);
                bool? k_ = context.Operators.ConceptInValueSet(i_, j_);

                return k_;
            };
            IEnumerable<object> f_ = context.Operators.Where<object>(d_, e_);
            bool? g_ = context.Operators.Exists<object>(f_);

            return g_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Encounter With Thrombolytic Therapy Documented As Already Given")]
    public IEnumerable<Encounter> Encounter_With_Thrombolytic_Therapy_Documented_As_Already_Given(CqlContext context)
    {
        IEnumerable<Encounter> a_ = TJCOverall_8_24_000.Instance.Ischemic_Stroke_Encounter(context);
        bool? b_(Encounter IschemicStrokeEncounter)
        {
            CqlValueSet h_ = this.Intravenous_or_Intraarterial_Thrombolytic_tPA_Therapy_Prior_to_Arrival(context);
            IEnumerable<Condition> i_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            bool? j_(Condition PriorTPA)
            {
                FhirDateTime m_ = PriorTPA?.RecordedDateElement;
                CqlDateTime n_ = context.Operators.Convert<CqlDateTime>(m_);
                CqlInterval<CqlDateTime> o_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, IschemicStrokeEncounter);
                bool? p_ = context.Operators.In<CqlDateTime>(n_, o_, default);
                CodeableConcept q_ = PriorTPA?.VerificationStatus;
                CqlConcept r_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, q_);
                bool? s_ = context.Operators.Not((bool?)(r_ is null));
                bool? t_ = context.Operators.And(p_, s_);
                CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, q_);
                CqlCode w_ = QICoreCommon_4_0_000.Instance.refuted(context);
                CqlConcept x_ = context.Operators.ConvertCodeToConcept(w_);
                bool? y_ = context.Operators.Equivalent(v_, x_);
                bool? z_ = context.Operators.Not(y_);
                CqlConcept ab_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, q_);
                CqlCode ac_ = QICoreCommon_4_0_000.Instance.entered_in_error(context);
                CqlConcept ad_ = context.Operators.ConvertCodeToConcept(ac_);
                bool? ae_ = context.Operators.Equivalent(ab_, ad_);
                bool? af_ = context.Operators.Not(ae_);
                bool? ag_ = context.Operators.And(z_, af_);
                bool? ah_ = context.Operators.Implies(t_, ag_);

                return ah_;
            };
            IEnumerable<Condition> k_ = context.Operators.Where<Condition>(i_, j_);
            bool? l_ = context.Operators.Exists<Condition>(k_);

            return l_;
        };
        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        bool? e_(Encounter IschemicStrokeEncounter)
        {
            IEnumerable<object> ai_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, IschemicStrokeEncounter);
            bool? aj_(object EncounterDiagnosis)
            {
                object am_ = context.Operators.LateBoundProperty<object>(EncounterDiagnosis, "code");
                CqlConcept an_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, am_ as CodeableConcept);
                CqlValueSet ao_ = this.Intravenous_or_Intraarterial_Thrombolytic_tPA_Therapy_Prior_to_Arrival(context);
                bool? ap_ = context.Operators.ConceptInValueSet(an_, ao_);

                return ap_;
            };
            IEnumerable<object> ak_ = context.Operators.Where<object>(ai_, aj_);
            bool? al_ = context.Operators.Exists<object>(ak_);

            return al_;
        };
        IEnumerable<Encounter> f_ = context.Operators.Where<Encounter>(a_, e_);
        IEnumerable<Encounter> g_ = context.Operators.Union<Encounter>(c_, f_);

        return g_;
    }


    [CqlExpressionDefinition("Encounter With Thrombolytic Therapy Given Prior To Arrival Or During Hospitalization")]
    public IEnumerable<Encounter> Encounter_With_Thrombolytic_Therapy_Given_Prior_To_Arrival_Or_During_Hospitalization(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_Thrombolytic_Therapy_Medication_Or_Procedures(context);
        IEnumerable<Encounter> b_ = this.Encounter_With_Thrombolytic_Therapy_Prior_To_Arrival(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
        IEnumerable<Encounter> d_ = this.Encounter_With_Thrombolytic_Therapy_Documented_As_Already_Given(context);
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(c_, d_);

        return e_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_Less_Than_Two_Days(context);
        IEnumerable<Encounter> b_ = this.Encounter_With_Comfort_Measures_During_Day_Of_Or_Day_After_Arrival(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
        IEnumerable<Encounter> d_ = this.Encounter_With_Thrombolytic_Therapy_Given_Prior_To_Arrival_Or_During_Hospitalization(context);
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(c_, d_);

        return e_;
    }


    [CqlExpressionDefinition("Encounter With Antithrombotic Therapy")]
    public IEnumerable<Encounter> Encounter_With_Antithrombotic_Therapy(CqlContext context)
    {
        IEnumerable<Encounter> a_ = TJCOverall_8_24_000.Instance.Ischemic_Stroke_Encounter(context);
        IEnumerable<Encounter> b_(Encounter IschemicStrokeEncounter)
        {
            CqlValueSet d_ = this.Antithrombotic_Therapy_for_Ischemic_Stroke(context);
            IEnumerable<MedicationAdministration> e_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
            bool? f_(MedicationAdministration Antithrombotic)
            {
                Code<MedicationAdministration.MedicationAdministrationStatusCodes> j_ = Antithrombotic?.StatusElement;
                MedicationAdministration.MedicationAdministrationStatusCodes? k_ = j_?.Value;
                string l_ = context.Operators.Convert<string>(k_);
                string[] m_ = [
                    "in-progress",
                    "completed",
                ];
                bool? n_ = context.Operators.In<string>(l_, (IEnumerable<string>)m_);
                DataType o_ = Antithrombotic?.Effective;
                object p_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
                CqlInterval<CqlDateTime> q_ = QICoreCommon_4_0_000.Instance.toInterval(context, p_);
                CqlDateTime r_ = context.Operators.Start(q_);
                CqlInterval<CqlDateTime> s_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, IschemicStrokeEncounter);
                CqlDateTime t_ = context.Operators.Start(s_);
                CqlInterval<CqlDate> u_ = TJCOverall_8_24_000.Instance.CalendarDayOfOrDayAfter(context, t_);
                CqlDate v_ = u_?.low;
                CqlDateTime w_ = context.Operators.ConvertDateToDateTime(v_);
                CqlDateTime y_ = context.Operators.Start(s_);
                CqlInterval<CqlDate> z_ = TJCOverall_8_24_000.Instance.CalendarDayOfOrDayAfter(context, y_);
                CqlDate aa_ = z_?.high;
                CqlDateTime ab_ = context.Operators.ConvertDateToDateTime(aa_);
                CqlDateTime ad_ = context.Operators.Start(s_);
                CqlInterval<CqlDate> ae_ = TJCOverall_8_24_000.Instance.CalendarDayOfOrDayAfter(context, ad_);
                bool? af_ = ae_?.lowClosed;
                CqlDateTime ah_ = context.Operators.Start(s_);
                CqlInterval<CqlDate> ai_ = TJCOverall_8_24_000.Instance.CalendarDayOfOrDayAfter(context, ah_);
                bool? aj_ = ai_?.highClosed;
                CqlInterval<CqlDateTime> ak_ = context.Operators.Interval(w_, ab_, af_, aj_);
                bool? al_ = context.Operators.In<CqlDateTime>(r_, ak_, "day");
                bool? am_ = context.Operators.And(n_, al_);

                return am_;
            };
            IEnumerable<MedicationAdministration> g_ = context.Operators.Where<MedicationAdministration>(e_, f_);
            Encounter h_(MedicationAdministration Antithrombotic) =>
                IschemicStrokeEncounter;
            IEnumerable<Encounter> i_ = context.Operators.Select<MedicationAdministration, Encounter>(g_, h_);

            return i_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_Antithrombotic_Therapy(context);

        return a_;
    }


    [CqlExpressionDefinition("Reason For Not Ordering Antithrombotic")]
    public IEnumerable<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?> Reason_For_Not_Ordering_Antithrombotic(CqlContext context)
    {
        CqlValueSet a_ = this.Antithrombotic_Therapy_for_Ischemic_Stroke(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationnotrequested"));
        bool? c_(MedicationRequest NoAntithromboticOrder)
        {
            List<CodeableConcept> t_ = NoAntithromboticOrder?.ReasonCode;
            CqlConcept u_(CodeableConcept @this)
            {
                CqlConcept aq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return aq_;
            };
            IEnumerable<CqlConcept> v_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)t_, u_);
            CqlValueSet w_ = this.Medical_Reason_for_Not_Providing_Treatment(context);
            bool? x_ = context.Operators.ConceptsInValueSet(v_, w_);
            CqlConcept z_(CodeableConcept @this)
            {
                CqlConcept ar_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return ar_;
            };
            IEnumerable<CqlConcept> aa_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)t_, z_);
            CqlValueSet ab_ = this.Patient_Refusal(context);
            bool? ac_ = context.Operators.ConceptsInValueSet(aa_, ab_);
            bool? ad_ = context.Operators.Or(x_, ac_);
            Code<MedicationRequest.MedicationrequestStatus> ae_ = NoAntithromboticOrder?.StatusElement;
            MedicationRequest.MedicationrequestStatus? af_ = ae_?.Value;
            string ag_ = context.Operators.Convert<string>(af_);
            string[] ah_ = [
                "active",
                "completed",
            ];
            bool? ai_ = context.Operators.In<string>(ag_, (IEnumerable<string>)ah_);
            bool? aj_ = context.Operators.And(ad_, ai_);
            Code<MedicationRequest.MedicationRequestIntent> ak_ = NoAntithromboticOrder?.IntentElement;
            MedicationRequest.MedicationRequestIntent? al_ = ak_?.Value;
            string am_ = context.Operators.Convert<string>(al_);
            string[] an_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? ao_ = context.Operators.In<string>(am_, (IEnumerable<string>)an_);
            bool? ap_ = context.Operators.And(aj_, ao_);

            return ap_;
        };
        IEnumerable<MedicationRequest> d_ = context.Operators.Where<MedicationRequest>(b_, c_);
        (CqlTupleMetadata, string id, CqlDateTime authoredOn)? e_(MedicationRequest NoAntithromboticOrder)
        {
            Id as_ = NoAntithromboticOrder?.IdElement;
            string at_ = as_?.Value;
            FhirDateTime au_ = NoAntithromboticOrder?.AuthoredOnElement;
            CqlDateTime av_ = context.Operators.Convert<CqlDateTime>(au_);
            (CqlTupleMetadata, string id, CqlDateTime authoredOn)? aw_ = (CqlTupleMetadata_DeYYCcJRPXYVddOGVBSgSSNfR, at_, av_);

            return aw_;
        };
        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?> f_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, string id, CqlDateTime authoredOn)?>(d_, e_);
        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?> g_ = context.Operators.Distinct<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?>(f_);
        IEnumerable<MedicationRequest> i_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> j_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> k_(MedicationRequest MR)
        {
            IEnumerable<Medication> ax_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
            bool? ay_(Medication M)
            {
                object bc_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object bd_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> be_ = context.Operators.Split((string)bd_, "/");
                string bf_ = context.Operators.Last<string>(be_);
                bool? bg_ = context.Operators.Equal(bc_, bf_);
                CodeableConcept bh_ = M?.Code;
                CqlConcept bi_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bh_);
                CqlValueSet bj_ = this.Antithrombotic_Therapy_for_Ischemic_Stroke(context);
                bool? bk_ = context.Operators.ConceptInValueSet(bi_, bj_);
                bool? bl_ = context.Operators.And(bg_, bk_);

                return bl_;
            };
            IEnumerable<Medication> az_ = context.Operators.Where<Medication>(ax_, ay_);
            MedicationRequest ba_(Medication M) =>
                MR;
            IEnumerable<MedicationRequest> bb_ = context.Operators.Select<Medication, MedicationRequest>(az_, ba_);

            return bb_;
        };
        IEnumerable<MedicationRequest> l_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(j_, k_);
        IEnumerable<MedicationRequest> m_ = context.Operators.Union<MedicationRequest>(i_, l_);
        IEnumerable<MedicationRequest> n_(MedicationRequest MedReqAntithrombotic)
        {
            IEnumerable<Task> bm_ = context.Operators.Retrieve<Task>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-taskrejected"));
            bool? bn_(Task TaskReject)
            {
                ResourceReference br_ = TaskReject?.Focus;
                bool? bs_ = QICoreCommon_4_0_000.Instance.references(context, br_, MedReqAntithrombotic);
                CodeableConcept bt_ = TaskReject?.StatusReason;
                CqlConcept bu_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bt_);
                CqlValueSet bv_ = this.Medical_Reason_for_Not_Providing_Treatment(context);
                bool? bw_ = context.Operators.ConceptInValueSet(bu_, bv_);
                CqlConcept by_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bt_);
                CqlValueSet bz_ = this.Patient_Refusal(context);
                bool? ca_ = context.Operators.ConceptInValueSet(by_, bz_);
                bool? cb_ = context.Operators.Or(bw_, ca_);
                bool? cc_ = context.Operators.And(bs_, cb_);
                Code<MedicationRequest.MedicationrequestStatus> cd_ = MedReqAntithrombotic?.StatusElement;
                MedicationRequest.MedicationrequestStatus? ce_ = cd_?.Value;
                string cf_ = context.Operators.Convert<string>(ce_);
                string[] cg_ = [
                    "active",
                    "completed",
                ];
                bool? ch_ = context.Operators.In<string>(cf_, (IEnumerable<string>)cg_);
                CodeableConcept ci_ = TaskReject?.Code;
                CqlConcept cj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ci_);
                CqlCode ck_ = this.fulfill(context);
                CqlConcept cl_ = context.Operators.ConvertCodeToConcept(ck_);
                bool? cm_ = context.Operators.Equivalent(cj_, cl_);
                bool? cn_ = context.Operators.And(ch_, cm_);
                bool? co_ = context.Operators.And(cc_, cn_);

                return co_;
            };
            IEnumerable<Task> bo_ = context.Operators.Where<Task>(bm_, bn_);
            MedicationRequest bp_(Task TaskReject) =>
                MedReqAntithrombotic;
            IEnumerable<MedicationRequest> bq_ = context.Operators.Select<Task, MedicationRequest>(bo_, bp_);

            return bq_;
        };
        IEnumerable<MedicationRequest> o_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(m_, n_);
        (CqlTupleMetadata, string id, CqlDateTime authoredOn)? p_(MedicationRequest MedReqAntithrombotic)
        {
            Id cp_ = MedReqAntithrombotic?.IdElement;
            string cq_ = cp_?.Value;
            FhirDateTime cr_ = MedReqAntithrombotic?.AuthoredOnElement;
            CqlDateTime cs_ = context.Operators.Convert<CqlDateTime>(cr_);
            (CqlTupleMetadata, string id, CqlDateTime authoredOn)? ct_ = (CqlTupleMetadata_DeYYCcJRPXYVddOGVBSgSSNfR, cq_, cs_);

            return ct_;
        };
        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?> q_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, string id, CqlDateTime authoredOn)?>(o_, p_);
        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?> r_ = context.Operators.Distinct<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?>(q_);
        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?> s_ = context.Operators.Union<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?>(g_, r_);

        return s_;
    }


    [CqlExpressionDefinition("Reason For Not Administering Antithrombotic")]
    public IEnumerable<(CqlTupleMetadata, string id, FhirDateTime authoredOn)?> Reason_For_Not_Administering_Antithrombotic(CqlContext context)
    {
        CqlValueSet a_ = this.Antithrombotic_Therapy_for_Ischemic_Stroke(context);
        IEnumerable<MedicationAdministration> b_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministrationnotdone"));
        bool? c_(MedicationAdministration MedicationAdm)
        {
            List<CodeableConcept> h_ = MedicationAdm?.StatusReason;
            CqlConcept i_(CodeableConcept @this)
            {
                CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return s_;
            };
            IEnumerable<CqlConcept> j_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)h_, i_);
            CqlValueSet k_ = this.Medical_Reason_for_Not_Providing_Treatment(context);
            bool? l_ = context.Operators.ConceptsInValueSet(j_, k_);
            CqlConcept n_(CodeableConcept @this)
            {
                CqlConcept t_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return t_;
            };
            IEnumerable<CqlConcept> o_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)h_, n_);
            CqlValueSet p_ = this.Patient_Refusal(context);
            bool? q_ = context.Operators.ConceptsInValueSet(o_, p_);
            bool? r_ = context.Operators.Or(l_, q_);

            return r_;
        };
        IEnumerable<MedicationAdministration> d_ = context.Operators.Where<MedicationAdministration>(b_, c_);
        (CqlTupleMetadata, string id, FhirDateTime authoredOn)? e_(MedicationAdministration MedicationAdm)
        {
            Id u_ = MedicationAdm?.IdElement;
            string v_ = u_?.Value;
            bool? w_(Extension @this)
            {
                string ad_ = @this?.Url;
                FhirString ae_ = context.Operators.Convert<FhirString>(ad_);
                string af_ = FHIRHelpers_4_4_000.Instance.ToString(context, ae_);
                bool? ag_ = context.Operators.Equal(af_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");

                return ag_;
            };
            IEnumerable<Extension> x_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(MedicationAdm is DomainResource
                    ? (MedicationAdm as DomainResource).Extension
                    : default), w_);
            DataType y_(Extension @this)
            {
                DataType ah_ = @this?.Value;

                return ah_;
            };
            IEnumerable<DataType> z_ = context.Operators.Select<Extension, DataType>(x_, y_);
            DataType aa_ = context.Operators.SingletonFrom<DataType>(z_);
            FhirDateTime ab_ = context.Operators.Convert<FhirDateTime>(aa_);
            (CqlTupleMetadata, string id, FhirDateTime authoredOn)? ac_ = (CqlTupleMetadata_EOIGQCcgaQBFZACEUUODRVWXI, v_, ab_);

            return ac_;
        };
        IEnumerable<(CqlTupleMetadata, string id, FhirDateTime authoredOn)?> f_ = context.Operators.Select<MedicationAdministration, (CqlTupleMetadata, string id, FhirDateTime authoredOn)?>(d_, e_);
        IEnumerable<(CqlTupleMetadata, string id, FhirDateTime authoredOn)?> g_ = context.Operators.Distinct<(CqlTupleMetadata, string id, FhirDateTime authoredOn)?>(f_);

        return g_;
    }


    [CqlExpressionDefinition("Documented Reason For No Antithrombotic Ordered Or Administered")]
    public IEnumerable<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?> Documented_Reason_For_No_Antithrombotic_Ordered_Or_Administered(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?> a_ = this.Reason_For_Not_Ordering_Antithrombotic(context);
        IEnumerable<(CqlTupleMetadata, string id, FhirDateTime authoredOn)?> b_ = this.Reason_For_Not_Administering_Antithrombotic(context);
        IEnumerable<object> c_ = context.Operators.Union<object>(a_ as IEnumerable<object>, b_ as IEnumerable<object>);
        (CqlTupleMetadata, string id, CqlDateTime authoredOn)? d_(object @object) =>
            ((CqlTupleMetadata, string id, CqlDateTime authoredOn)?)@object;
        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?> e_ = context.Operators.Select<object, (CqlTupleMetadata, string id, CqlDateTime authoredOn)?>(c_, d_);

        return e_;
    }


    [CqlExpressionDefinition("Encounter With Documented Reason For No Antithrombotic Ordered Or Administered Day Of Or Day After Hospital Arrival")]
    public IEnumerable<Encounter> Encounter_With_Documented_Reason_For_No_Antithrombotic_Ordered_Or_Administered_Day_Of_Or_Day_After_Hospital_Arrival(CqlContext context)
    {
        IEnumerable<Encounter> a_ = TJCOverall_8_24_000.Instance.Ischemic_Stroke_Encounter(context);
        IEnumerable<Encounter> b_(Encounter IschemicStrokeEncounter)
        {
            IEnumerable<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?> d_ = this.Documented_Reason_For_No_Antithrombotic_Ordered_Or_Administered(context);
            bool? e_((CqlTupleMetadata, string id, CqlDateTime authoredOn)? NoAntithrombotic)
            {
                CqlDateTime i_ = NoAntithrombotic?.authoredOn;
                CqlInterval<CqlDateTime> j_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, IschemicStrokeEncounter);
                CqlDateTime k_ = context.Operators.Start(j_);
                CqlInterval<CqlDate> l_ = TJCOverall_8_24_000.Instance.CalendarDayOfOrDayAfter(context, k_);
                CqlDate m_ = l_?.low;
                CqlDateTime n_ = context.Operators.ConvertDateToDateTime(m_);
                CqlDateTime p_ = context.Operators.Start(j_);
                CqlInterval<CqlDate> q_ = TJCOverall_8_24_000.Instance.CalendarDayOfOrDayAfter(context, p_);
                CqlDate r_ = q_?.high;
                CqlDateTime s_ = context.Operators.ConvertDateToDateTime(r_);
                CqlDateTime u_ = context.Operators.Start(j_);
                CqlInterval<CqlDate> v_ = TJCOverall_8_24_000.Instance.CalendarDayOfOrDayAfter(context, u_);
                bool? w_ = v_?.lowClosed;
                CqlDateTime y_ = context.Operators.Start(j_);
                CqlInterval<CqlDate> z_ = TJCOverall_8_24_000.Instance.CalendarDayOfOrDayAfter(context, y_);
                bool? aa_ = z_?.highClosed;
                CqlInterval<CqlDateTime> ab_ = context.Operators.Interval(n_, s_, w_, aa_);
                bool? ac_ = context.Operators.In<CqlDateTime>(i_, ab_, "day");

                return ac_;
            };
            IEnumerable<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?> f_ = context.Operators.Where<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?>(d_, e_);
            Encounter g_((CqlTupleMetadata, string id, CqlDateTime authoredOn)? NoAntithrombotic) =>
                IschemicStrokeEncounter;
            IEnumerable<Encounter> h_ = context.Operators.Select<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?, Encounter>(f_, g_);

            return h_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Encounter With Pharmacological Contraindications For Antithrombotic Therapy Given Day Of Or Day After Hospital Arrival")]
    public IEnumerable<Encounter> Encounter_With_Pharmacological_Contraindications_For_Antithrombotic_Therapy_Given_Day_Of_Or_Day_After_Hospital_Arrival(CqlContext context)
    {
        IEnumerable<Encounter> a_ = TJCOverall_8_24_000.Instance.Ischemic_Stroke_Encounter(context);
        IEnumerable<Encounter> b_(Encounter IschemicStrokeEncounter)
        {
            CqlValueSet d_ = this.Pharmacological_Contraindications_For_Antithrombotic_Therapy(context);
            IEnumerable<MedicationAdministration> e_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
            bool? f_(MedicationAdministration PharmacologicalContraindications)
            {
                Code<MedicationAdministration.MedicationAdministrationStatusCodes> j_ = PharmacologicalContraindications?.StatusElement;
                MedicationAdministration.MedicationAdministrationStatusCodes? k_ = j_?.Value;
                string l_ = context.Operators.Convert<string>(k_);
                string[] m_ = [
                    "in-progress",
                    "completed",
                ];
                bool? n_ = context.Operators.In<string>(l_, (IEnumerable<string>)m_);
                DataType o_ = PharmacologicalContraindications?.Effective;
                object p_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
                CqlInterval<CqlDateTime> q_ = QICoreCommon_4_0_000.Instance.toInterval(context, p_);
                CqlDateTime r_ = context.Operators.Start(q_);
                CqlInterval<CqlDateTime> s_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, IschemicStrokeEncounter);
                CqlDateTime t_ = context.Operators.Start(s_);
                CqlInterval<CqlDate> u_ = TJCOverall_8_24_000.Instance.CalendarDayOfOrDayAfter(context, t_);
                CqlDate v_ = u_?.low;
                CqlDateTime w_ = context.Operators.ConvertDateToDateTime(v_);
                CqlDateTime y_ = context.Operators.Start(s_);
                CqlInterval<CqlDate> z_ = TJCOverall_8_24_000.Instance.CalendarDayOfOrDayAfter(context, y_);
                CqlDate aa_ = z_?.high;
                CqlDateTime ab_ = context.Operators.ConvertDateToDateTime(aa_);
                CqlDateTime ad_ = context.Operators.Start(s_);
                CqlInterval<CqlDate> ae_ = TJCOverall_8_24_000.Instance.CalendarDayOfOrDayAfter(context, ad_);
                bool? af_ = ae_?.lowClosed;
                CqlDateTime ah_ = context.Operators.Start(s_);
                CqlInterval<CqlDate> ai_ = TJCOverall_8_24_000.Instance.CalendarDayOfOrDayAfter(context, ah_);
                bool? aj_ = ai_?.highClosed;
                CqlInterval<CqlDateTime> ak_ = context.Operators.Interval(w_, ab_, af_, aj_);
                bool? al_ = context.Operators.In<CqlDateTime>(r_, ak_, "day");
                bool? am_ = context.Operators.And(n_, al_);

                return am_;
            };
            IEnumerable<MedicationAdministration> g_ = context.Operators.Where<MedicationAdministration>(e_, f_);
            Encounter h_(MedicationAdministration PharmacologicalContraindications) =>
                IschemicStrokeEncounter;
            IEnumerable<Encounter> i_ = context.Operators.Select<MedicationAdministration, Encounter>(g_, h_);

            return i_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Encounter With An INR Greater Than 3.5")]
    public IEnumerable<Encounter> Encounter_With_An_INR_Greater_Than_3_5(CqlContext context)
    {
        IEnumerable<Encounter> a_ = TJCOverall_8_24_000.Instance.Ischemic_Stroke_Encounter(context);
        IEnumerable<Encounter> b_(Encounter IschemicStrokeEncounter)
        {
            CqlValueSet d_ = this.INR(context);
            IEnumerable<Observation> e_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));
            bool? f_(Observation INR)
            {
                DataType j_ = INR?.Value;
                object k_ = FHIRHelpers_4_4_000.Instance.ToValue(context, j_);
                CqlQuantity l_ = context.Operators.ConvertDecimalToQuantity(3.5m);
                bool? m_ = context.Operators.Greater(k_ as CqlQuantity, l_);
                Code<ObservationStatus> n_ = INR?.StatusElement;
                ObservationStatus? o_ = n_?.Value;
                string p_ = context.Operators.Convert<string>(o_);
                string[] q_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? r_ = context.Operators.In<string>(p_, (IEnumerable<string>)q_);
                bool? s_ = context.Operators.And(m_, r_);
                Instant t_ = INR?.IssuedElement;
                DateTimeOffset? u_ = t_?.Value;
                CqlDateTime v_ = context.Operators.Convert<CqlDateTime>(u_);
                CqlInterval<CqlDateTime> w_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, IschemicStrokeEncounter);
                CqlDateTime x_ = context.Operators.Start(w_);
                CqlInterval<CqlDate> y_ = TJCOverall_8_24_000.Instance.CalendarDayOfOrDayAfter(context, x_);
                CqlDate z_ = y_?.low;
                CqlDateTime aa_ = context.Operators.ConvertDateToDateTime(z_);
                CqlDateTime ac_ = context.Operators.Start(w_);
                CqlInterval<CqlDate> ad_ = TJCOverall_8_24_000.Instance.CalendarDayOfOrDayAfter(context, ac_);
                CqlDate ae_ = ad_?.high;
                CqlDateTime af_ = context.Operators.ConvertDateToDateTime(ae_);
                CqlDateTime ah_ = context.Operators.Start(w_);
                CqlInterval<CqlDate> ai_ = TJCOverall_8_24_000.Instance.CalendarDayOfOrDayAfter(context, ah_);
                bool? aj_ = ai_?.lowClosed;
                CqlDateTime al_ = context.Operators.Start(w_);
                CqlInterval<CqlDate> am_ = TJCOverall_8_24_000.Instance.CalendarDayOfOrDayAfter(context, al_);
                bool? an_ = am_?.highClosed;
                CqlInterval<CqlDateTime> ao_ = context.Operators.Interval(aa_, af_, aj_, an_);
                bool? ap_ = context.Operators.In<CqlDateTime>(v_, ao_, "day");
                bool? aq_ = context.Operators.And(s_, ap_);

                return aq_;
            };
            IEnumerable<Observation> g_ = context.Operators.Where<Observation>(e_, f_);
            Encounter h_(Observation INR) =>
                IschemicStrokeEncounter;
            IEnumerable<Encounter> i_ = context.Operators.Select<Observation, Encounter>(g_, h_);

            return i_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public IEnumerable<Encounter> Denominator_Exceptions(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_Documented_Reason_For_No_Antithrombotic_Ordered_Or_Administered_Day_Of_Or_Day_After_Hospital_Arrival(context);
        IEnumerable<Encounter> b_ = this.Encounter_With_Pharmacological_Contraindications_For_Antithrombotic_Therapy_Given_Day_Of_Or_Day_After_Hospital_Arrival(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
        IEnumerable<Encounter> d_ = this.Encounter_With_An_INR_Greater_Than_3_5(context);
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(c_, d_);

        return e_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);

        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);

        return a_;
    }


    #endregion Functions and Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_DbNFZJaRJHECUfPGBeWSUEUQi = new(
      [typeof(string), typeof(object)],
      ["id", "effective"]);

    private static CqlTupleMetadata CqlTupleMetadata_DeYYCcJRPXYVddOGVBSgSSNfR = new(
      [typeof(string), typeof(CqlDateTime)],
      ["id", "authoredOn"]);

    private static CqlTupleMetadata CqlTupleMetadata_EOIGQCcgaQBFZACEUUODRVWXI = new(
      [typeof(string), typeof(FhirDateTime)],
      ["id", "authoredOn"]);

    #endregion CqlTupleMetadata Properties

}
