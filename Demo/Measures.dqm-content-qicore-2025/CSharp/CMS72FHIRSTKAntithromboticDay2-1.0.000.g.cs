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
[CqlLibrary("CMS72FHIRSTKAntithromboticDay2", "1.0.000")]
public partial class CMS72FHIRSTKAntithromboticDay2_1_0_000 : ILibrary, ISingleton<CMS72FHIRSTKAntithromboticDay2_1_0_000>
{
    private CMS72FHIRSTKAntithromboticDay2_1_0_000() {}

    public static CMS72FHIRSTKAntithromboticDay2_1_0_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "CMS72FHIRSTKAntithromboticDay2";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [CQMCommon_4_1_000.Instance, QICoreCommon_4_0_000.Instance, FHIRHelpers_4_4_000.Instance, SupplementalDataElements_5_1_000.Instance, TJCOverall_8_25_000.Instance];

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

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object a_ = context.ResolveParameter("CMS72FHIRSTKAntithromboticDay2-1.0.000", "Measurement Period", null);

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
        IEnumerable<Encounter> a_ = TJCOverall_8_25_000.Instance.Ischemic_Stroke_Encounter(context);

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
        IEnumerable<Encounter> a_ = TJCOverall_8_25_000.Instance.Ischemic_Stroke_Encounter(context);
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
        IEnumerable<Encounter> a_ = TJCOverall_8_25_000.Instance.Ischemic_Stroke_Encounter(context);
        IEnumerable<Encounter> b_(Encounter IschemicStrokeEncounter)
        {
            IEnumerable<object> d_ = TJCOverall_8_25_000.Instance.Intervention_Comfort_Measures(context);
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
                CqlInterval<CqlDate> p_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, o_);
                CqlDate q_ = p_?.low;
                CqlDateTime r_ = context.Operators.ConvertDateToDateTime(q_);
                CqlDateTime t_ = context.Operators.Start(n_);
                CqlInterval<CqlDate> u_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, t_);
                CqlDate v_ = u_?.high;
                CqlDateTime w_ = context.Operators.ConvertDateToDateTime(v_);
                CqlDateTime y_ = context.Operators.Start(n_);
                CqlInterval<CqlDate> z_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, y_);
                bool? aa_ = z_?.lowClosed;
                CqlDateTime ac_ = context.Operators.Start(n_);
                CqlInterval<CqlDate> ad_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ac_);
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
        IEnumerable<MedicationAdministration> c_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> d_(MedicationAdministration MR)
        {
            IEnumerable<Medication> t_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
            bool? u_(Medication M)
            {
                object y_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object z_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> aa_ = context.Operators.Split((string)z_, "/");
                string ab_ = context.Operators.Last<string>(aa_);
                bool? ac_ = context.Operators.Equal(y_, ab_);
                CodeableConcept ad_ = M?.Code;
                CqlConcept ae_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ad_);
                CqlValueSet af_ = this.Thrombolytic_tPA_Therapy(context);
                bool? ag_ = context.Operators.ConceptInValueSet(ae_, af_);
                bool? ah_ = context.Operators.And(ac_, ag_);

                return ah_;
            };
            IEnumerable<Medication> v_ = context.Operators.Where<Medication>(t_, u_);
            MedicationAdministration w_(Medication M) =>
            MR;
            IEnumerable<MedicationAdministration> x_ = context.Operators.Select<Medication, MedicationAdministration>(v_, w_);

            return x_;
        };
        IEnumerable<MedicationAdministration> e_ = context.Operators.SelectMany<MedicationAdministration, MedicationAdministration>(c_, d_);
        IEnumerable<MedicationAdministration> f_ = context.Operators.Union<MedicationAdministration>(b_, e_);
        bool? g_(MedicationAdministration ThrombolyticMedication)
        {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> ai_ = ThrombolyticMedication?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? aj_ = ai_?.Value;
            string ak_ = context.Operators.Convert<string>(aj_);
            string[] al_ = [
                "in-progress",
                "completed",
            ];
            bool? am_ = context.Operators.In<string>(ak_, (IEnumerable<string>)al_);

            return am_;
        };
        IEnumerable<MedicationAdministration> h_ = context.Operators.Where<MedicationAdministration>(f_, g_);
        (CqlTupleMetadata, string id, object effective)? i_(MedicationAdministration ThrombolyticMedication)
        {
            Id an_ = ThrombolyticMedication?.IdElement;
            string ao_ = an_?.Value;
            DataType ap_ = ThrombolyticMedication?.Effective;
            object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
            (CqlTupleMetadata, string id, object effective)? ar_ = (CqlTupleMetadata_DbNFZJaRJHECUfPGBeWSUEUQi, ao_, aq_);

            return ar_;
        };
        IEnumerable<(CqlTupleMetadata, string id, object effective)?> j_ = context.Operators.Select<MedicationAdministration, (CqlTupleMetadata, string id, object effective)?>(h_, i_);
        IEnumerable<(CqlTupleMetadata, string id, object effective)?> k_ = context.Operators.Distinct<(CqlTupleMetadata, string id, object effective)?>(j_);
        CqlValueSet l_ = this.Intravenous_or_Intraarterial_Thrombolytic_tPA_Therapy(context);
        IEnumerable<Procedure> m_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
        bool? n_(Procedure ThrombolyticProcedure)
        {
            Code<EventStatus> as_ = ThrombolyticProcedure?.StatusElement;
            EventStatus? at_ = as_?.Value;
            string au_ = context.Operators.Convert<string>(at_);
            bool? av_ = context.Operators.Equal(au_, "completed");

            return av_;
        };
        IEnumerable<Procedure> o_ = context.Operators.Where<Procedure>(m_, n_);
        (CqlTupleMetadata, string id, object effective)? p_(Procedure ThrombolyticProcedure)
        {
            Id aw_ = ThrombolyticProcedure?.IdElement;
            string ax_ = aw_?.Value;
            DataType ay_ = ThrombolyticProcedure?.Performed;
            object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
            (CqlTupleMetadata, string id, object effective)? ba_ = (CqlTupleMetadata_DbNFZJaRJHECUfPGBeWSUEUQi, ax_, az_);

            return ba_;
        };
        IEnumerable<(CqlTupleMetadata, string id, object effective)?> q_ = context.Operators.Select<Procedure, (CqlTupleMetadata, string id, object effective)?>(o_, p_);
        IEnumerable<(CqlTupleMetadata, string id, object effective)?> r_ = context.Operators.Distinct<(CqlTupleMetadata, string id, object effective)?>(q_);
        IEnumerable<object> s_ = context.Operators.Union<object>(k_ as IEnumerable<object>, r_ as IEnumerable<object>);

        return s_;
    }


    [CqlExpressionDefinition("Encounter With Thrombolytic Therapy Medication Or Procedures")]
    public IEnumerable<Encounter> Encounter_With_Thrombolytic_Therapy_Medication_Or_Procedures(CqlContext context)
    {
        IEnumerable<Encounter> a_ = TJCOverall_8_25_000.Instance.Ischemic_Stroke_Encounter(context);
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
        IEnumerable<Encounter> a_ = TJCOverall_8_25_000.Instance.Ischemic_Stroke_Encounter(context);
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
        IEnumerable<Encounter> a_ = TJCOverall_8_25_000.Instance.Ischemic_Stroke_Encounter(context);
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
        IEnumerable<Encounter> a_ = TJCOverall_8_25_000.Instance.Ischemic_Stroke_Encounter(context);
        IEnumerable<Encounter> b_(Encounter IschemicStrokeEncounter)
        {
            CqlValueSet d_ = this.Antithrombotic_Therapy_for_Ischemic_Stroke(context);
            IEnumerable<MedicationAdministration> e_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
            IEnumerable<MedicationAdministration> f_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
            IEnumerable<MedicationAdministration> g_(MedicationAdministration MR)
            {
                IEnumerable<Medication> n_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
                bool? o_(Medication M)
                {
                    object s_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object t_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> u_ = context.Operators.Split((string)t_, "/");
                    string v_ = context.Operators.Last<string>(u_);
                    bool? w_ = context.Operators.Equal(s_, v_);
                    CodeableConcept x_ = M?.Code;
                    CqlConcept y_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, x_);
                    CqlValueSet z_ = this.Antithrombotic_Therapy_for_Ischemic_Stroke(context);
                    bool? aa_ = context.Operators.ConceptInValueSet(y_, z_);
                    bool? ab_ = context.Operators.And(w_, aa_);

                    return ab_;
                };
                IEnumerable<Medication> p_ = context.Operators.Where<Medication>(n_, o_);
                MedicationAdministration q_(Medication M) =>
                MR;
                IEnumerable<MedicationAdministration> r_ = context.Operators.Select<Medication, MedicationAdministration>(p_, q_);

                return r_;
            };
            IEnumerable<MedicationAdministration> h_ = context.Operators.SelectMany<MedicationAdministration, MedicationAdministration>(f_, g_);
            IEnumerable<MedicationAdministration> i_ = context.Operators.Union<MedicationAdministration>(e_, h_);
            bool? j_(MedicationAdministration Antithrombotic)
            {
                Code<MedicationAdministration.MedicationAdministrationStatusCodes> ac_ = Antithrombotic?.StatusElement;
                MedicationAdministration.MedicationAdministrationStatusCodes? ad_ = ac_?.Value;
                string ae_ = context.Operators.Convert<string>(ad_);
                string[] af_ = [
                    "in-progress",
                    "completed",
                ];
                bool? ag_ = context.Operators.In<string>(ae_, (IEnumerable<string>)af_);
                DataType ah_ = Antithrombotic?.Effective;
                object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                CqlInterval<CqlDateTime> aj_ = QICoreCommon_4_0_000.Instance.toInterval(context, ai_);
                CqlDateTime ak_ = context.Operators.Start(aj_);
                CqlInterval<CqlDateTime> al_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, IschemicStrokeEncounter);
                CqlDateTime am_ = context.Operators.Start(al_);
                CqlInterval<CqlDate> an_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, am_);
                CqlDate ao_ = an_?.low;
                CqlDateTime ap_ = context.Operators.ConvertDateToDateTime(ao_);
                CqlDateTime ar_ = context.Operators.Start(al_);
                CqlInterval<CqlDate> as_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ar_);
                CqlDate at_ = as_?.high;
                CqlDateTime au_ = context.Operators.ConvertDateToDateTime(at_);
                CqlDateTime aw_ = context.Operators.Start(al_);
                CqlInterval<CqlDate> ax_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, aw_);
                bool? ay_ = ax_?.lowClosed;
                CqlDateTime ba_ = context.Operators.Start(al_);
                CqlInterval<CqlDate> bb_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ba_);
                bool? bc_ = bb_?.highClosed;
                CqlInterval<CqlDateTime> bd_ = context.Operators.Interval(ap_, au_, ay_, bc_);
                bool? be_ = context.Operators.In<CqlDateTime>(ak_, bd_, "day");
                bool? bf_ = context.Operators.And(ag_, be_);

                return bf_;
            };
            IEnumerable<MedicationAdministration> k_ = context.Operators.Where<MedicationAdministration>(i_, j_);
            Encounter l_(MedicationAdministration Antithrombotic) =>
            IschemicStrokeEncounter;
            IEnumerable<Encounter> m_ = context.Operators.Select<MedicationAdministration, Encounter>(k_, l_);

            return m_;
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
        IEnumerable<MedicationRequest> d_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationnotrequested"));
        IEnumerable<MedicationRequest> e_ = context.Operators.Union<MedicationRequest>(b_, d_);
        bool? f_(MedicationRequest NoAntithromboticOrder)
        {
            List<CodeableConcept> w_ = NoAntithromboticOrder?.ReasonCode;
            CqlConcept x_(CodeableConcept @this)
            {
                CqlConcept at_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return at_;
            };
            IEnumerable<CqlConcept> y_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)w_, x_);
            CqlValueSet z_ = this.Medical_Reason_for_Not_Providing_Treatment(context);
            bool? aa_ = context.Operators.ConceptsInValueSet(y_, z_);
            CqlConcept ac_(CodeableConcept @this)
            {
                CqlConcept au_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return au_;
            };
            IEnumerable<CqlConcept> ad_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)w_, ac_);
            CqlValueSet ae_ = this.Patient_Refusal(context);
            bool? af_ = context.Operators.ConceptsInValueSet(ad_, ae_);
            bool? ag_ = context.Operators.Or(aa_, af_);
            Code<MedicationRequest.MedicationrequestStatus> ah_ = NoAntithromboticOrder?.StatusElement;
            MedicationRequest.MedicationrequestStatus? ai_ = ah_?.Value;
            string aj_ = context.Operators.Convert<string>(ai_);
            string[] ak_ = [
                "active",
                "completed",
            ];
            bool? al_ = context.Operators.In<string>(aj_, (IEnumerable<string>)ak_);
            bool? am_ = context.Operators.And(ag_, al_);
            Code<MedicationRequest.MedicationRequestIntent> an_ = NoAntithromboticOrder?.IntentElement;
            MedicationRequest.MedicationRequestIntent? ao_ = an_?.Value;
            string ap_ = context.Operators.Convert<string>(ao_);
            string[] aq_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? ar_ = context.Operators.In<string>(ap_, (IEnumerable<string>)aq_);
            bool? as_ = context.Operators.And(am_, ar_);

            return as_;
        };
        IEnumerable<MedicationRequest> g_ = context.Operators.Where<MedicationRequest>(e_, f_);
        (CqlTupleMetadata, string id, CqlDateTime authoredOn)? h_(MedicationRequest NoAntithromboticOrder)
        {
            Id av_ = NoAntithromboticOrder?.IdElement;
            string aw_ = av_?.Value;
            FhirDateTime ax_ = NoAntithromboticOrder?.AuthoredOnElement;
            CqlDateTime ay_ = context.Operators.Convert<CqlDateTime>(ax_);
            (CqlTupleMetadata, string id, CqlDateTime authoredOn)? az_ = (CqlTupleMetadata_DeYYCcJRPXYVddOGVBSgSSNfR, aw_, ay_);

            return az_;
        };
        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?> i_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, string id, CqlDateTime authoredOn)?>(g_, h_);
        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?> j_ = context.Operators.Distinct<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?>(i_);
        IEnumerable<MedicationRequest> l_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> m_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> n_(MedicationRequest MR)
        {
            IEnumerable<Medication> ba_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
            bool? bb_(Medication M)
            {
                object bf_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object bg_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> bh_ = context.Operators.Split((string)bg_, "/");
                string bi_ = context.Operators.Last<string>(bh_);
                bool? bj_ = context.Operators.Equal(bf_, bi_);
                CodeableConcept bk_ = M?.Code;
                CqlConcept bl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bk_);
                CqlValueSet bm_ = this.Antithrombotic_Therapy_for_Ischemic_Stroke(context);
                bool? bn_ = context.Operators.ConceptInValueSet(bl_, bm_);
                bool? bo_ = context.Operators.And(bj_, bn_);

                return bo_;
            };
            IEnumerable<Medication> bc_ = context.Operators.Where<Medication>(ba_, bb_);
            MedicationRequest bd_(Medication M) =>
            MR;
            IEnumerable<MedicationRequest> be_ = context.Operators.Select<Medication, MedicationRequest>(bc_, bd_);

            return be_;
        };
        IEnumerable<MedicationRequest> o_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(m_, n_);
        IEnumerable<MedicationRequest> p_ = context.Operators.Union<MedicationRequest>(l_, o_);
        IEnumerable<MedicationRequest> q_(MedicationRequest MedReqAntithrombotic)
        {
            IEnumerable<Task> bp_ = context.Operators.Retrieve<Task>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-taskrejected"));
            bool? bq_(Task TaskReject)
            {
                ResourceReference bu_ = TaskReject?.Focus;
                bool? bv_ = QICoreCommon_4_0_000.Instance.references(context, bu_, MedReqAntithrombotic);
                CodeableConcept bw_ = TaskReject?.StatusReason;
                CqlConcept bx_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bw_);
                CqlValueSet by_ = this.Medical_Reason_for_Not_Providing_Treatment(context);
                bool? bz_ = context.Operators.ConceptInValueSet(bx_, by_);
                CqlConcept cb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bw_);
                CqlValueSet cc_ = this.Patient_Refusal(context);
                bool? cd_ = context.Operators.ConceptInValueSet(cb_, cc_);
                bool? ce_ = context.Operators.Or(bz_, cd_);
                bool? cf_ = context.Operators.And(bv_, ce_);
                Code<MedicationRequest.MedicationrequestStatus> cg_ = MedReqAntithrombotic?.StatusElement;
                MedicationRequest.MedicationrequestStatus? ch_ = cg_?.Value;
                string ci_ = context.Operators.Convert<string>(ch_);
                string[] cj_ = [
                    "active",
                    "completed",
                ];
                bool? ck_ = context.Operators.In<string>(ci_, (IEnumerable<string>)cj_);
                CodeableConcept cl_ = TaskReject?.Code;
                CqlConcept cm_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cl_);
                CqlCode cn_ = QICoreCommon_4_0_000.Instance.Fulfill(context);
                CqlConcept co_ = context.Operators.ConvertCodeToConcept(cn_);
                bool? cp_ = context.Operators.Equivalent(cm_, co_);
                bool? cq_ = context.Operators.And(ck_, cp_);
                bool? cr_ = context.Operators.And(cf_, cq_);

                return cr_;
            };
            IEnumerable<Task> br_ = context.Operators.Where<Task>(bp_, bq_);
            MedicationRequest bs_(Task TaskReject) =>
            MedReqAntithrombotic;
            IEnumerable<MedicationRequest> bt_ = context.Operators.Select<Task, MedicationRequest>(br_, bs_);

            return bt_;
        };
        IEnumerable<MedicationRequest> r_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(p_, q_);
        (CqlTupleMetadata, string id, CqlDateTime authoredOn)? s_(MedicationRequest MedReqAntithrombotic)
        {
            Id cs_ = MedReqAntithrombotic?.IdElement;
            string ct_ = cs_?.Value;
            FhirDateTime cu_ = MedReqAntithrombotic?.AuthoredOnElement;
            CqlDateTime cv_ = context.Operators.Convert<CqlDateTime>(cu_);
            (CqlTupleMetadata, string id, CqlDateTime authoredOn)? cw_ = (CqlTupleMetadata_DeYYCcJRPXYVddOGVBSgSSNfR, ct_, cv_);

            return cw_;
        };
        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?> t_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, string id, CqlDateTime authoredOn)?>(r_, s_);
        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?> u_ = context.Operators.Distinct<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?>(t_);
        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?> v_ = context.Operators.Union<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?>(j_, u_);

        return v_;
    }


    [CqlExpressionDefinition("Reason For Not Administering Antithrombotic")]
    public IEnumerable<(CqlTupleMetadata, string id, FhirDateTime authoredOn)?> Reason_For_Not_Administering_Antithrombotic(CqlContext context)
    {
        CqlValueSet a_ = this.Antithrombotic_Therapy_for_Ischemic_Stroke(context);
        IEnumerable<MedicationAdministration> b_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministrationnotdone"));
        IEnumerable<MedicationAdministration> d_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministrationnotdone"));
        IEnumerable<MedicationAdministration> e_ = context.Operators.Union<MedicationAdministration>(b_, d_);
        bool? f_(MedicationAdministration MedicationAdm)
        {
            List<CodeableConcept> k_ = MedicationAdm?.StatusReason;
            CqlConcept l_(CodeableConcept @this)
            {
                CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return v_;
            };
            IEnumerable<CqlConcept> m_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)k_, l_);
            CqlValueSet n_ = this.Medical_Reason_for_Not_Providing_Treatment(context);
            bool? o_ = context.Operators.ConceptsInValueSet(m_, n_);
            CqlConcept q_(CodeableConcept @this)
            {
                CqlConcept w_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);

                return w_;
            };
            IEnumerable<CqlConcept> r_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)k_, q_);
            CqlValueSet s_ = this.Patient_Refusal(context);
            bool? t_ = context.Operators.ConceptsInValueSet(r_, s_);
            bool? u_ = context.Operators.Or(o_, t_);

            return u_;
        };
        IEnumerable<MedicationAdministration> g_ = context.Operators.Where<MedicationAdministration>(e_, f_);
        (CqlTupleMetadata, string id, FhirDateTime authoredOn)? h_(MedicationAdministration MedicationAdm)
        {
            Id x_ = MedicationAdm?.IdElement;
            string y_ = x_?.Value;
            bool? z_(Extension @this)
            {
                FhirUri ag_ = @this?.UrlElement;
                FhirString ah_ = context.Operators.Convert<FhirString>(ag_);
                string ai_ = FHIRHelpers_4_4_000.Instance.ToString(context, ah_);
                bool? aj_ = context.Operators.Equal(ai_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");

                return aj_;
            };
            IEnumerable<Extension> aa_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(MedicationAdm is DomainResource
                ? (MedicationAdm as DomainResource).Extension
                : default), z_);
            DataType ab_(Extension @this)
            {
                DataType ak_ = @this?.Value;

                return ak_;
            };
            IEnumerable<DataType> ac_ = context.Operators.Select<Extension, DataType>(aa_, ab_);
            DataType ad_ = context.Operators.SingletonFrom<DataType>(ac_);
            FhirDateTime ae_ = context.Operators.Convert<FhirDateTime>(ad_);
            (CqlTupleMetadata, string id, FhirDateTime authoredOn)? af_ = (CqlTupleMetadata_EOIGQCcgaQBFZACEUUODRVWXI, y_, ae_);

            return af_;
        };
        IEnumerable<(CqlTupleMetadata, string id, FhirDateTime authoredOn)?> i_ = context.Operators.Select<MedicationAdministration, (CqlTupleMetadata, string id, FhirDateTime authoredOn)?>(g_, h_);
        IEnumerable<(CqlTupleMetadata, string id, FhirDateTime authoredOn)?> j_ = context.Operators.Distinct<(CqlTupleMetadata, string id, FhirDateTime authoredOn)?>(i_);

        return j_;
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
        IEnumerable<Encounter> a_ = TJCOverall_8_25_000.Instance.Ischemic_Stroke_Encounter(context);
        IEnumerable<Encounter> b_(Encounter IschemicStrokeEncounter)
        {
            IEnumerable<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?> d_ = this.Documented_Reason_For_No_Antithrombotic_Ordered_Or_Administered(context);
            bool? e_((CqlTupleMetadata, string id, CqlDateTime authoredOn)? NoAntithrombotic)
            {
                CqlDateTime i_ = NoAntithrombotic?.authoredOn;
                CqlInterval<CqlDateTime> j_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, IschemicStrokeEncounter);
                CqlDateTime k_ = context.Operators.Start(j_);
                CqlInterval<CqlDate> l_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, k_);
                CqlDate m_ = l_?.low;
                CqlDateTime n_ = context.Operators.ConvertDateToDateTime(m_);
                CqlDateTime p_ = context.Operators.Start(j_);
                CqlInterval<CqlDate> q_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, p_);
                CqlDate r_ = q_?.high;
                CqlDateTime s_ = context.Operators.ConvertDateToDateTime(r_);
                CqlDateTime u_ = context.Operators.Start(j_);
                CqlInterval<CqlDate> v_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, u_);
                bool? w_ = v_?.lowClosed;
                CqlDateTime y_ = context.Operators.Start(j_);
                CqlInterval<CqlDate> z_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, y_);
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
        IEnumerable<Encounter> a_ = TJCOverall_8_25_000.Instance.Ischemic_Stroke_Encounter(context);
        IEnumerable<Encounter> b_(Encounter IschemicStrokeEncounter)
        {
            CqlValueSet d_ = this.Pharmacological_Contraindications_For_Antithrombotic_Therapy(context);
            IEnumerable<MedicationAdministration> e_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
            IEnumerable<MedicationAdministration> f_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
            IEnumerable<MedicationAdministration> g_(MedicationAdministration MR)
            {
                IEnumerable<Medication> n_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));
                bool? o_(Medication M)
                {
                    object s_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object t_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> u_ = context.Operators.Split((string)t_, "/");
                    string v_ = context.Operators.Last<string>(u_);
                    bool? w_ = context.Operators.Equal(s_, v_);
                    CodeableConcept x_ = M?.Code;
                    CqlConcept y_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, x_);
                    CqlValueSet z_ = this.Pharmacological_Contraindications_For_Antithrombotic_Therapy(context);
                    bool? aa_ = context.Operators.ConceptInValueSet(y_, z_);
                    bool? ab_ = context.Operators.And(w_, aa_);

                    return ab_;
                };
                IEnumerable<Medication> p_ = context.Operators.Where<Medication>(n_, o_);
                MedicationAdministration q_(Medication M) =>
                MR;
                IEnumerable<MedicationAdministration> r_ = context.Operators.Select<Medication, MedicationAdministration>(p_, q_);

                return r_;
            };
            IEnumerable<MedicationAdministration> h_ = context.Operators.SelectMany<MedicationAdministration, MedicationAdministration>(f_, g_);
            IEnumerable<MedicationAdministration> i_ = context.Operators.Union<MedicationAdministration>(e_, h_);
            bool? j_(MedicationAdministration PharmacologicalContraindications)
            {
                Code<MedicationAdministration.MedicationAdministrationStatusCodes> ac_ = PharmacologicalContraindications?.StatusElement;
                MedicationAdministration.MedicationAdministrationStatusCodes? ad_ = ac_?.Value;
                string ae_ = context.Operators.Convert<string>(ad_);
                string[] af_ = [
                    "in-progress",
                    "completed",
                ];
                bool? ag_ = context.Operators.In<string>(ae_, (IEnumerable<string>)af_);
                DataType ah_ = PharmacologicalContraindications?.Effective;
                object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                CqlInterval<CqlDateTime> aj_ = QICoreCommon_4_0_000.Instance.toInterval(context, ai_);
                CqlDateTime ak_ = context.Operators.Start(aj_);
                CqlInterval<CqlDateTime> al_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, IschemicStrokeEncounter);
                CqlDateTime am_ = context.Operators.Start(al_);
                CqlInterval<CqlDate> an_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, am_);
                CqlDate ao_ = an_?.low;
                CqlDateTime ap_ = context.Operators.ConvertDateToDateTime(ao_);
                CqlDateTime ar_ = context.Operators.Start(al_);
                CqlInterval<CqlDate> as_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ar_);
                CqlDate at_ = as_?.high;
                CqlDateTime au_ = context.Operators.ConvertDateToDateTime(at_);
                CqlDateTime aw_ = context.Operators.Start(al_);
                CqlInterval<CqlDate> ax_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, aw_);
                bool? ay_ = ax_?.lowClosed;
                CqlDateTime ba_ = context.Operators.Start(al_);
                CqlInterval<CqlDate> bb_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ba_);
                bool? bc_ = bb_?.highClosed;
                CqlInterval<CqlDateTime> bd_ = context.Operators.Interval(ap_, au_, ay_, bc_);
                bool? be_ = context.Operators.In<CqlDateTime>(ak_, bd_, "day");
                bool? bf_ = context.Operators.And(ag_, be_);

                return bf_;
            };
            IEnumerable<MedicationAdministration> k_ = context.Operators.Where<MedicationAdministration>(i_, j_);
            Encounter l_(MedicationAdministration PharmacologicalContraindications) =>
            IschemicStrokeEncounter;
            IEnumerable<Encounter> m_ = context.Operators.Select<MedicationAdministration, Encounter>(k_, l_);

            return m_;
        };
        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

        return c_;
    }


    [CqlExpressionDefinition("Encounter With An INR Greater Than 3.5")]
    public IEnumerable<Encounter> Encounter_With_An_INR_Greater_Than_3_5(CqlContext context)
    {
        IEnumerable<Encounter> a_ = TJCOverall_8_25_000.Instance.Ischemic_Stroke_Encounter(context);
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
                CqlInterval<CqlDate> y_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, x_);
                CqlDate z_ = y_?.low;
                CqlDateTime aa_ = context.Operators.ConvertDateToDateTime(z_);
                CqlDateTime ac_ = context.Operators.Start(w_);
                CqlInterval<CqlDate> ad_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ac_);
                CqlDate ae_ = ad_?.high;
                CqlDateTime af_ = context.Operators.ConvertDateToDateTime(ae_);
                CqlDateTime ah_ = context.Operators.Start(w_);
                CqlInterval<CqlDate> ai_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ah_);
                bool? aj_ = ai_?.lowClosed;
                CqlDateTime al_ = context.Operators.Start(w_);
                CqlInterval<CqlDate> am_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, al_);
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
