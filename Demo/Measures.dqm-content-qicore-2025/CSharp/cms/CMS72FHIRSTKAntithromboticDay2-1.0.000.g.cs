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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.2.0")]
[CqlLibrary("CMS72FHIRSTKAntithromboticDay2", "1.0.000")]
public partial class CMS72FHIRSTKAntithromboticDay2_1_0_000 : ILibrary, ISingleton<CMS72FHIRSTKAntithromboticDay2_1_0_000>
{
    #region ValueSets (8)

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

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = 2391673490967013253L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("CMS72FHIRSTKAntithromboticDay2-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (24)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = -3290964875584437754L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = 2163734512707144984L;

    private IEnumerable<Encounter> Initial_Population_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = TJCOverall_8_25_000.Instance.Ischemic_Stroke_Encounter(context);
        return a_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = -8847692956730205935L;

    private IEnumerable<Encounter> Denominator_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlExpressionDefinition("Encounter Less Than Two Days")]
    public IEnumerable<Encounter> Encounter_Less_Than_Two_Days(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_Less_Than_Two_Days, Encounter_Less_Than_Two_Days_Compute);

    private const long _cacheIndex_Encounter_Less_Than_Two_Days = -6849230433219179733L;

    private IEnumerable<Encounter> Encounter_Less_Than_Two_Days_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = TJCOverall_8_25_000.Instance.Ischemic_Stroke_Encounter(context);

        bool? b_(Encounter IschemicStrokeEncounter) {
            CqlInterval<CqlDateTime> d_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, IschemicStrokeEncounter);
            int? e_ = CQMCommon_4_1_000.Instance.lengthInDays(context, d_);
            bool? f_ = context.Operators.Less(e_, 2);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounter With Comfort Measures During Day Of Or Day After Arrival")]
    public IEnumerable<Encounter> Encounter_With_Comfort_Measures_During_Day_Of_Or_Day_After_Arrival(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Comfort_Measures_During_Day_Of_Or_Day_After_Arrival, Encounter_With_Comfort_Measures_During_Day_Of_Or_Day_After_Arrival_Compute);

    private const long _cacheIndex_Encounter_With_Comfort_Measures_During_Day_Of_Or_Day_After_Arrival = 767895877937121484L;

    private IEnumerable<Encounter> Encounter_With_Comfort_Measures_During_Day_Of_Or_Day_After_Arrival_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = TJCOverall_8_25_000.Instance.Ischemic_Stroke_Encounter(context);

        bool? b_(Encounter IschemicStrokeEncounter) {
            IEnumerable<object> d_ = TJCOverall_8_25_000.Instance.Intervention_Comfort_Measures(context);

            bool? e_(object ComfortMeasure) {

                object h_() {

                    bool ag_() {
                        object ak_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                        object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                        bool am_ = al_ is CqlDateTime;
                        return am_;
                    }


                    bool ah_() {
                        object an_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                        object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                        bool ap_ = ao_ is CqlInterval<CqlDateTime>;
                        return ap_;
                    }


                    bool ai_() {
                        object aq_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                        object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                        bool as_ = ar_ is CqlQuantity;
                        return as_;
                    }


                    bool aj_() {
                        object at_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                        object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                        bool av_ = au_ is CqlInterval<CqlQuantity>;
                        return av_;
                    }

                    if (ag_())
                    {
                        object aw_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                        object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                        return (ax_ as CqlDateTime) as object;
                    }
                    else if (ah_())
                    {
                        object ay_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                        object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                        return (az_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (ai_())
                    {
                        object ba_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                        object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                        return (bb_ as CqlQuantity) as object;
                    }
                    else if (aj_())
                    {
                        object bc_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                        object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                        return (bd_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> i_ = QICoreCommon_4_0_000.Instance.toInterval(context, h_());
                CqlDateTime j_ = context.Operators.Start(i_);
                object k_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "authoredOn");
                CqlDateTime l_ = context.Operators.LateBoundProperty<CqlDateTime>(k_, "value");
                CqlInterval<CqlDateTime> m_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, IschemicStrokeEncounter);
                CqlDateTime n_ = context.Operators.Start(m_);
                CqlInterval<CqlDate> o_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, n_);
                CqlDate p_ = o_?.low;
                CqlDateTime q_ = context.Operators.ConvertDateToDateTime(p_);
                CqlDateTime s_ = context.Operators.Start(m_);
                CqlInterval<CqlDate> t_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, s_);
                CqlDate u_ = t_?.high;
                CqlDateTime v_ = context.Operators.ConvertDateToDateTime(u_);
                CqlDateTime x_ = context.Operators.Start(m_);
                CqlInterval<CqlDate> y_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, x_);
                bool? z_ = y_?.lowClosed;
                CqlDateTime ab_ = context.Operators.Start(m_);
                CqlInterval<CqlDate> ac_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ab_);
                bool? ad_ = ac_?.highClosed;
                CqlInterval<CqlDateTime> ae_ = context.Operators.Interval(q_, v_, z_, ad_);
                bool? af_ = context.Operators.In<CqlDateTime>(j_ ?? l_, ae_, "day");
                return af_;
            }

            IEnumerable<object> f_ = context.Operators.Where<object>(d_, e_);
            bool? g_ = context.Operators.Exists<object>(f_);
            return g_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Thrombolytic Therapy Medication Or Procedures")]
    public IEnumerable<(CqlTupleMetadata, string id, object effective)?> Thrombolytic_Therapy_Medication_Or_Procedures(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Thrombolytic_Therapy_Medication_Or_Procedures, Thrombolytic_Therapy_Medication_Or_Procedures_Compute);

    private const long _cacheIndex_Thrombolytic_Therapy_Medication_Or_Procedures = 4283455175184797914L;

    private IEnumerable<(CqlTupleMetadata, string id, object effective)?> Thrombolytic_Therapy_Medication_Or_Procedures_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Thrombolytic_tPA_Therapy(context);
        IEnumerable<MedicationAdministration> b_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> c_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));

        bool? d_(MedicationAdministration MR) {
            IEnumerable<Medication> t_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? u_(Medication M) {
                object x_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object y_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> z_ = context.Operators.Split((string)y_, "/");
                string aa_ = context.Operators.Last<string>(z_);
                bool? ab_ = context.Operators.Equal(x_, aa_);
                CodeableConcept ac_ = M?.Code;
                CqlConcept ad_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ac_);
                CqlValueSet ae_ = this.Thrombolytic_tPA_Therapy(context);
                bool? af_ = context.Operators.ConceptInValueSet(ad_, ae_);
                bool? ag_ = context.Operators.And(ab_, af_);
                return ag_;
            }

            IEnumerable<Medication> v_ = context.Operators.Where<Medication>(t_, u_);
            bool? w_ = context.Operators.Exists<Medication>(v_);
            return w_;
        }

        IEnumerable<MedicationAdministration> e_ = context.Operators.Where<MedicationAdministration>(c_, d_);
        IEnumerable<MedicationAdministration> f_ = context.Operators.Union<MedicationAdministration>(b_, e_);

        bool? g_(MedicationAdministration ThrombolyticMedication) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> ah_ = ThrombolyticMedication?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? ai_ = ah_?.Value;
            string aj_ = context.Operators.Convert<string>(ai_);
            string[] ak_ = [
                "in-progress",
                "completed",
            ];
            bool? al_ = context.Operators.In<string>(aj_, (IEnumerable<string>)ak_);
            return al_;
        }

        IEnumerable<MedicationAdministration> h_ = context.Operators.Where<MedicationAdministration>(f_, g_);

        (CqlTupleMetadata, string id, object effective)? i_(MedicationAdministration ThrombolyticMedication) {
            Id am_ = ThrombolyticMedication?.IdElement;
            string an_ = am_?.Value;
            DataType ao_ = ThrombolyticMedication?.Effective;
            object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
            (CqlTupleMetadata, string id, object effective)? aq_ = (CqlTupleMetadata_DbNFZJaRJHECUfPGBeWSUEUQi, an_, ap_);
            return aq_;
        }

        IEnumerable<(CqlTupleMetadata, string id, object effective)?> j_ = context.Operators.Select<MedicationAdministration, (CqlTupleMetadata, string id, object effective)?>(h_, i_);
        IEnumerable<(CqlTupleMetadata, string id, object effective)?> k_ = context.Operators.Distinct<(CqlTupleMetadata, string id, object effective)?>(j_);
        CqlValueSet l_ = this.Intravenous_or_Intraarterial_Thrombolytic_tPA_Therapy(context);
        IEnumerable<Procedure> m_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

        bool? n_(Procedure ThrombolyticProcedure) {
            Code<EventStatus> ar_ = ThrombolyticProcedure?.StatusElement;
            EventStatus? as_ = ar_?.Value;
            string at_ = context.Operators.Convert<string>(as_);
            bool? au_ = context.Operators.Equal(at_, "completed");
            return au_;
        }

        IEnumerable<Procedure> o_ = context.Operators.Where<Procedure>(m_, n_);

        (CqlTupleMetadata, string id, object effective)? p_(Procedure ThrombolyticProcedure) {
            Id av_ = ThrombolyticProcedure?.IdElement;
            string aw_ = av_?.Value;
            DataType ax_ = ThrombolyticProcedure?.Performed;
            object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
            (CqlTupleMetadata, string id, object effective)? az_ = (CqlTupleMetadata_DbNFZJaRJHECUfPGBeWSUEUQi, aw_, ay_);
            return az_;
        }

        IEnumerable<(CqlTupleMetadata, string id, object effective)?> q_ = context.Operators.Select<Procedure, (CqlTupleMetadata, string id, object effective)?>(o_, p_);
        IEnumerable<(CqlTupleMetadata, string id, object effective)?> r_ = context.Operators.Distinct<(CqlTupleMetadata, string id, object effective)?>(q_);
        IEnumerable<(CqlTupleMetadata, string id, object effective)?> s_ = context.Operators.Union<(CqlTupleMetadata, string id, object effective)?>(k_ as IEnumerable<(CqlTupleMetadata, string id, object effective)?>, r_ as IEnumerable<(CqlTupleMetadata, string id, object effective)?>);
        return s_;
    }


    [CqlExpressionDefinition("Encounter With Thrombolytic Therapy Medication Or Procedures")]
    public IEnumerable<Encounter> Encounter_With_Thrombolytic_Therapy_Medication_Or_Procedures(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Thrombolytic_Therapy_Medication_Or_Procedures, Encounter_With_Thrombolytic_Therapy_Medication_Or_Procedures_Compute);

    private const long _cacheIndex_Encounter_With_Thrombolytic_Therapy_Medication_Or_Procedures = -2356475640381753881L;

    private IEnumerable<Encounter> Encounter_With_Thrombolytic_Therapy_Medication_Or_Procedures_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = TJCOverall_8_25_000.Instance.Ischemic_Stroke_Encounter(context);

        bool? b_(Encounter IschemicStrokeEncounter) {
            IEnumerable<(CqlTupleMetadata, string id, object effective)?> d_ = this.Thrombolytic_Therapy_Medication_Or_Procedures(context);

            bool? e_((CqlTupleMetadata, string id, object effective)? ThrombolyticTherapy) {

                object h_() {

                    bool s_() {
                        object y_ = ThrombolyticTherapy?.effective;
                        bool z_ = y_ is CqlDateTime;
                        return z_;
                    }


                    bool t_() {
                        object aa_ = ThrombolyticTherapy?.effective;
                        bool ab_ = aa_ is CqlInterval<CqlDateTime>;
                        return ab_;
                    }


                    bool u_() {
                        object ac_ = ThrombolyticTherapy?.effective;
                        bool ad_ = ac_ is CqlQuantity;
                        return ad_;
                    }


                    bool v_() {
                        object ae_ = ThrombolyticTherapy?.effective;
                        bool af_ = ae_ is CqlInterval<CqlQuantity>;
                        return af_;
                    }


                    bool w_() {
                        object ag_ = ThrombolyticTherapy?.effective;
                        bool ah_ = ag_ is CqlDateTime;
                        return ah_;
                    }


                    bool x_() {
                        object ai_ = ThrombolyticTherapy?.effective;
                        bool aj_ = ai_ is CqlInterval<CqlDateTime>;
                        return aj_;
                    }

                    if (s_())
                    {
                        object ak_ = ThrombolyticTherapy?.effective;
                        return (ak_ as CqlDateTime) as object;
                    }
                    else if (t_())
                    {
                        object al_ = ThrombolyticTherapy?.effective;
                        return (al_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (u_())
                    {
                        object am_ = ThrombolyticTherapy?.effective;
                        return (am_ as CqlQuantity) as object;
                    }
                    else if (v_())
                    {
                        object an_ = ThrombolyticTherapy?.effective;
                        return (an_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else if (w_())
                    {
                        object ao_ = ThrombolyticTherapy?.effective;
                        return (ao_ as CqlDateTime) as object;
                    }
                    else if (x_())
                    {
                        object ap_ = ThrombolyticTherapy?.effective;
                        return (ap_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> i_ = QICoreCommon_4_0_000.Instance.toInterval(context, h_());
                CqlDateTime j_ = context.Operators.Start(i_);
                CqlInterval<CqlDateTime> k_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, IschemicStrokeEncounter);
                CqlDateTime l_ = context.Operators.Start(k_);
                CqlQuantity m_ = context.Operators.Quantity(24m, "hours");
                CqlDateTime n_ = context.Operators.Subtract(l_, m_);
                CqlDateTime p_ = context.Operators.End(k_);
                CqlInterval<CqlDateTime> q_ = context.Operators.Interval(n_, p_, true, false);
                bool? r_ = context.Operators.In<CqlDateTime>(j_, q_, (string)default);
                return r_;
            }

            IEnumerable<(CqlTupleMetadata, string id, object effective)?> f_ = context.Operators.Where<(CqlTupleMetadata, string id, object effective)?>(d_, e_);
            bool? g_ = context.Operators.Exists<(CqlTupleMetadata, string id, object effective)?>(f_);
            return g_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounter With Thrombolytic Therapy Prior To Arrival")]
    public IEnumerable<Encounter> Encounter_With_Thrombolytic_Therapy_Prior_To_Arrival(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Thrombolytic_Therapy_Prior_To_Arrival, Encounter_With_Thrombolytic_Therapy_Prior_To_Arrival_Compute);

    private const long _cacheIndex_Encounter_With_Thrombolytic_Therapy_Prior_To_Arrival = 5512887700549487543L;

    private IEnumerable<Encounter> Encounter_With_Thrombolytic_Therapy_Prior_To_Arrival_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = TJCOverall_8_25_000.Instance.Ischemic_Stroke_Encounter(context);

        bool? b_(Encounter IschemicStrokeEncounter) {
            IEnumerable<Condition> d_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, IschemicStrokeEncounter);

            bool? e_(Condition EncounterDiagnosis) {
                CodeableConcept h_ = EncounterDiagnosis?.Code;
                CqlConcept i_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, h_);
                CqlValueSet j_ = this.Intravenous_or_Intraarterial_Thrombolytic_tPA_Therapy_Prior_to_Arrival(context);
                bool? k_ = context.Operators.ConceptInValueSet(i_, j_);
                return k_;
            }

            IEnumerable<Condition> f_ = context.Operators.Where<Condition>(d_, e_);
            bool? g_ = context.Operators.Exists<Condition>(f_);
            return g_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounter With Thrombolytic Therapy Documented As Already Given")]
    public IEnumerable<Encounter> Encounter_With_Thrombolytic_Therapy_Documented_As_Already_Given(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Thrombolytic_Therapy_Documented_As_Already_Given, Encounter_With_Thrombolytic_Therapy_Documented_As_Already_Given_Compute);

    private const long _cacheIndex_Encounter_With_Thrombolytic_Therapy_Documented_As_Already_Given = 2358470021370312532L;

    private IEnumerable<Encounter> Encounter_With_Thrombolytic_Therapy_Documented_As_Already_Given_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = TJCOverall_8_25_000.Instance.Ischemic_Stroke_Encounter(context);

        bool? b_(Encounter IschemicStrokeEncounter) {
            CqlValueSet h_ = this.Intravenous_or_Intraarterial_Thrombolytic_tPA_Therapy_Prior_to_Arrival(context);
            IEnumerable<Condition> i_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

            bool? j_(Condition PriorTPA) {
                FhirDateTime m_ = PriorTPA?.RecordedDateElement;
                CqlDateTime n_ = context.Operators.Convert<CqlDateTime>(m_);
                CqlInterval<CqlDateTime> o_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, IschemicStrokeEncounter);
                bool? p_ = context.Operators.In<CqlDateTime>(n_, o_, (string)default);
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
            }

            IEnumerable<Condition> k_ = context.Operators.Where<Condition>(i_, j_);
            bool? l_ = context.Operators.Exists<Condition>(k_);
            return l_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        bool? e_(Encounter IschemicStrokeEncounter) {
            IEnumerable<Condition> ai_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, IschemicStrokeEncounter);

            bool? aj_(Condition EncounterDiagnosis) {
                CodeableConcept am_ = EncounterDiagnosis?.Code;
                CqlConcept an_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, am_);
                CqlValueSet ao_ = this.Intravenous_or_Intraarterial_Thrombolytic_tPA_Therapy_Prior_to_Arrival(context);
                bool? ap_ = context.Operators.ConceptInValueSet(an_, ao_);
                return ap_;
            }

            IEnumerable<Condition> ak_ = context.Operators.Where<Condition>(ai_, aj_);
            bool? al_ = context.Operators.Exists<Condition>(ak_);
            return al_;
        }

        IEnumerable<Encounter> f_ = context.Operators.Where<Encounter>(a_, e_);
        IEnumerable<Encounter> g_ = context.Operators.Union<Encounter>(c_, f_);
        return g_;
    }


    [CqlExpressionDefinition("Encounter With Thrombolytic Therapy Given Prior To Arrival Or During Hospitalization")]
    public IEnumerable<Encounter> Encounter_With_Thrombolytic_Therapy_Given_Prior_To_Arrival_Or_During_Hospitalization(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Thrombolytic_Therapy_Given_Prior_To_Arrival_Or_During_Hospitalization, Encounter_With_Thrombolytic_Therapy_Given_Prior_To_Arrival_Or_During_Hospitalization_Compute);

    private const long _cacheIndex_Encounter_With_Thrombolytic_Therapy_Given_Prior_To_Arrival_Or_During_Hospitalization = 6404862824370978356L;

    private IEnumerable<Encounter> Encounter_With_Thrombolytic_Therapy_Given_Prior_To_Arrival_Or_During_Hospitalization_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_Thrombolytic_Therapy_Medication_Or_Procedures(context);
        IEnumerable<Encounter> b_ = this.Encounter_With_Thrombolytic_Therapy_Prior_To_Arrival(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
        IEnumerable<Encounter> d_ = this.Encounter_With_Thrombolytic_Therapy_Documented_As_Already_Given(context);
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(c_, d_);
        return e_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exclusions, Denominator_Exclusions_Compute);

    private const long _cacheIndex_Denominator_Exclusions = -4722773356805412957L;

    private IEnumerable<Encounter> Denominator_Exclusions_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_Less_Than_Two_Days(context);
        IEnumerable<Encounter> b_ = this.Encounter_With_Comfort_Measures_During_Day_Of_Or_Day_After_Arrival(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
        IEnumerable<Encounter> d_ = this.Encounter_With_Thrombolytic_Therapy_Given_Prior_To_Arrival_Or_During_Hospitalization(context);
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(c_, d_);
        return e_;
    }


    [CqlExpressionDefinition("Encounter With Antithrombotic Therapy")]
    public IEnumerable<Encounter> Encounter_With_Antithrombotic_Therapy(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Antithrombotic_Therapy, Encounter_With_Antithrombotic_Therapy_Compute);

    private const long _cacheIndex_Encounter_With_Antithrombotic_Therapy = -463511194713894222L;

    private IEnumerable<Encounter> Encounter_With_Antithrombotic_Therapy_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = TJCOverall_8_25_000.Instance.Ischemic_Stroke_Encounter(context);

        bool? b_(Encounter IschemicStrokeEncounter) {
            CqlValueSet d_ = this.Antithrombotic_Therapy_for_Ischemic_Stroke(context);
            IEnumerable<MedicationAdministration> e_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
            IEnumerable<MedicationAdministration> f_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));

            bool? g_(MedicationAdministration MR) {
                IEnumerable<Medication> m_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? n_(Medication M) {
                    object q_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object r_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> s_ = context.Operators.Split((string)r_, "/");
                    string t_ = context.Operators.Last<string>(s_);
                    bool? u_ = context.Operators.Equal(q_, t_);
                    CodeableConcept v_ = M?.Code;
                    CqlConcept w_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, v_);
                    CqlValueSet x_ = this.Antithrombotic_Therapy_for_Ischemic_Stroke(context);
                    bool? y_ = context.Operators.ConceptInValueSet(w_, x_);
                    bool? z_ = context.Operators.And(u_, y_);
                    return z_;
                }

                IEnumerable<Medication> o_ = context.Operators.Where<Medication>(m_, n_);
                bool? p_ = context.Operators.Exists<Medication>(o_);
                return p_;
            }

            IEnumerable<MedicationAdministration> h_ = context.Operators.Where<MedicationAdministration>(f_, g_);
            IEnumerable<MedicationAdministration> i_ = context.Operators.Union<MedicationAdministration>(e_, h_);

            bool? j_(MedicationAdministration Antithrombotic) {
                Code<MedicationAdministration.MedicationAdministrationStatusCodes> aa_ = Antithrombotic?.StatusElement;
                MedicationAdministration.MedicationAdministrationStatusCodes? ab_ = aa_?.Value;
                string ac_ = context.Operators.Convert<string>(ab_);
                string[] ad_ = [
                    "in-progress",
                    "completed",
                ];
                bool? ae_ = context.Operators.In<string>(ac_, (IEnumerable<string>)ad_);
                DataType af_ = Antithrombotic?.Effective;
                object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                CqlInterval<CqlDateTime> ah_ = QICoreCommon_4_0_000.Instance.toInterval(context, ag_);
                CqlDateTime ai_ = context.Operators.Start(ah_);
                CqlInterval<CqlDateTime> aj_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, IschemicStrokeEncounter);
                CqlDateTime ak_ = context.Operators.Start(aj_);
                CqlInterval<CqlDate> al_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ak_);
                CqlDate am_ = al_?.low;
                CqlDateTime an_ = context.Operators.ConvertDateToDateTime(am_);
                CqlDateTime ap_ = context.Operators.Start(aj_);
                CqlInterval<CqlDate> aq_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ap_);
                CqlDate ar_ = aq_?.high;
                CqlDateTime as_ = context.Operators.ConvertDateToDateTime(ar_);
                CqlDateTime au_ = context.Operators.Start(aj_);
                CqlInterval<CqlDate> av_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, au_);
                bool? aw_ = av_?.lowClosed;
                CqlDateTime ay_ = context.Operators.Start(aj_);
                CqlInterval<CqlDate> az_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ay_);
                bool? ba_ = az_?.highClosed;
                CqlInterval<CqlDateTime> bb_ = context.Operators.Interval(an_, as_, aw_, ba_);
                bool? bc_ = context.Operators.In<CqlDateTime>(ai_, bb_, "day");
                bool? bd_ = context.Operators.And(ae_, bc_);
                return bd_;
            }

            IEnumerable<MedicationAdministration> k_ = context.Operators.Where<MedicationAdministration>(i_, j_);
            bool? l_ = context.Operators.Exists<MedicationAdministration>(k_);
            return l_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = -881143965198563425L;

    private IEnumerable<Encounter> Numerator_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_Antithrombotic_Therapy(context);
        return a_;
    }


    [CqlExpressionDefinition("Reason For Not Ordering Antithrombotic")]
    public IEnumerable<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?> Reason_For_Not_Ordering_Antithrombotic(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Reason_For_Not_Ordering_Antithrombotic, Reason_For_Not_Ordering_Antithrombotic_Compute);

    private const long _cacheIndex_Reason_For_Not_Ordering_Antithrombotic = -6115959520988572008L;

    private IEnumerable<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?> Reason_For_Not_Ordering_Antithrombotic_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Antithrombotic_Therapy_for_Ischemic_Stroke(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationnotrequested"));
        IEnumerable<MedicationRequest> d_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationnotrequested"));
        IEnumerable<MedicationRequest> e_ = context.Operators.Union<MedicationRequest>(b_, d_);

        bool? f_(MedicationRequest NoAntithromboticOrder) {
            List<CodeableConcept> w_ = NoAntithromboticOrder?.ReasonCode;

            CqlConcept x_(CodeableConcept @this) {
                CqlConcept at_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return at_;
            }

            IEnumerable<CqlConcept> y_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)w_, x_);
            CqlValueSet z_ = this.Medical_Reason_for_Not_Providing_Treatment(context);
            bool? aa_ = context.Operators.ConceptsInValueSet(y_, z_);

            CqlConcept ac_(CodeableConcept @this) {
                CqlConcept au_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return au_;
            }

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
        }

        IEnumerable<MedicationRequest> g_ = context.Operators.Where<MedicationRequest>(e_, f_);

        (CqlTupleMetadata, string id, CqlDateTime authoredOn)? h_(MedicationRequest NoAntithromboticOrder) {
            Id av_ = NoAntithromboticOrder?.IdElement;
            string aw_ = av_?.Value;
            FhirDateTime ax_ = NoAntithromboticOrder?.AuthoredOnElement;
            CqlDateTime ay_ = context.Operators.Convert<CqlDateTime>(ax_);
            (CqlTupleMetadata, string id, CqlDateTime authoredOn)? az_ = (CqlTupleMetadata_DeYYCcJRPXYVddOGVBSgSSNfR, aw_, ay_);
            return az_;
        }

        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?> i_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, string id, CqlDateTime authoredOn)?>(g_, h_);
        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?> j_ = context.Operators.Distinct<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?>(i_);
        IEnumerable<MedicationRequest> l_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> m_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? n_(MedicationRequest MR) {
            IEnumerable<Medication> ba_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? bb_(Medication M) {
                object be_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object bf_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> bg_ = context.Operators.Split((string)bf_, "/");
                string bh_ = context.Operators.Last<string>(bg_);
                bool? bi_ = context.Operators.Equal(be_, bh_);
                CodeableConcept bj_ = M?.Code;
                CqlConcept bk_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bj_);
                CqlValueSet bl_ = this.Antithrombotic_Therapy_for_Ischemic_Stroke(context);
                bool? bm_ = context.Operators.ConceptInValueSet(bk_, bl_);
                bool? bn_ = context.Operators.And(bi_, bm_);
                return bn_;
            }

            IEnumerable<Medication> bc_ = context.Operators.Where<Medication>(ba_, bb_);
            bool? bd_ = context.Operators.Exists<Medication>(bc_);
            return bd_;
        }

        IEnumerable<MedicationRequest> o_ = context.Operators.Where<MedicationRequest>(m_, n_);
        IEnumerable<MedicationRequest> p_ = context.Operators.Union<MedicationRequest>(l_, o_);

        bool? q_(MedicationRequest MedReqAntithrombotic) {
            IEnumerable<Task> bo_ = context.Operators.Retrieve<Task>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-taskrejected"));

            bool? bp_(Task TaskReject) {
                ResourceReference bs_ = TaskReject?.Focus;
                bool? bt_ = QICoreCommon_4_0_000.Instance.references(context, bs_, MedReqAntithrombotic);
                CodeableConcept bu_ = TaskReject?.StatusReason;
                CqlConcept bv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bu_);
                CqlValueSet bw_ = this.Medical_Reason_for_Not_Providing_Treatment(context);
                bool? bx_ = context.Operators.ConceptInValueSet(bv_, bw_);
                CqlConcept bz_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bu_);
                CqlValueSet ca_ = this.Patient_Refusal(context);
                bool? cb_ = context.Operators.ConceptInValueSet(bz_, ca_);
                bool? cc_ = context.Operators.Or(bx_, cb_);
                bool? cd_ = context.Operators.And(bt_, cc_);
                Code<MedicationRequest.MedicationrequestStatus> ce_ = MedReqAntithrombotic?.StatusElement;
                MedicationRequest.MedicationrequestStatus? cf_ = ce_?.Value;
                string cg_ = context.Operators.Convert<string>(cf_);
                string[] ch_ = [
                    "active",
                    "completed",
                ];
                bool? ci_ = context.Operators.In<string>(cg_, (IEnumerable<string>)ch_);
                CodeableConcept cj_ = TaskReject?.Code;
                CqlConcept ck_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cj_);
                CqlCode cl_ = QICoreCommon_4_0_000.Instance.Fulfill(context);
                CqlConcept cm_ = context.Operators.ConvertCodeToConcept(cl_);
                bool? cn_ = context.Operators.Equivalent(ck_, cm_);
                bool? co_ = context.Operators.And(ci_, cn_);
                bool? cp_ = context.Operators.And(cd_, co_);
                return cp_;
            }

            IEnumerable<Task> bq_ = context.Operators.Where<Task>(bo_, bp_);
            bool? br_ = context.Operators.Exists<Task>(bq_);
            return br_;
        }

        IEnumerable<MedicationRequest> r_ = context.Operators.Where<MedicationRequest>(p_, q_);

        (CqlTupleMetadata, string id, CqlDateTime authoredOn)? s_(MedicationRequest MedReqAntithrombotic) {
            Id cq_ = MedReqAntithrombotic?.IdElement;
            string cr_ = cq_?.Value;
            FhirDateTime cs_ = MedReqAntithrombotic?.AuthoredOnElement;
            CqlDateTime ct_ = context.Operators.Convert<CqlDateTime>(cs_);
            (CqlTupleMetadata, string id, CqlDateTime authoredOn)? cu_ = (CqlTupleMetadata_DeYYCcJRPXYVddOGVBSgSSNfR, cr_, ct_);
            return cu_;
        }

        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?> t_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, string id, CqlDateTime authoredOn)?>(r_, s_);
        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?> u_ = context.Operators.Distinct<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?>(t_);
        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?> v_ = context.Operators.Union<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?>(j_, u_);
        return v_;
    }


    [CqlExpressionDefinition("Reason For Not Administering Antithrombotic")]
    public IEnumerable<(CqlTupleMetadata, string id, FhirDateTime authoredOn)?> Reason_For_Not_Administering_Antithrombotic(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Reason_For_Not_Administering_Antithrombotic, Reason_For_Not_Administering_Antithrombotic_Compute);

    private const long _cacheIndex_Reason_For_Not_Administering_Antithrombotic = 4621061554767489361L;

    private IEnumerable<(CqlTupleMetadata, string id, FhirDateTime authoredOn)?> Reason_For_Not_Administering_Antithrombotic_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Antithrombotic_Therapy_for_Ischemic_Stroke(context);
        IEnumerable<MedicationAdministration> b_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministrationnotdone"));
        IEnumerable<MedicationAdministration> d_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministrationnotdone"));
        IEnumerable<MedicationAdministration> e_ = context.Operators.Union<MedicationAdministration>(b_, d_);

        bool? f_(MedicationAdministration MedicationAdm) {
            List<CodeableConcept> k_ = MedicationAdm?.StatusReason;

            CqlConcept l_(CodeableConcept @this) {
                CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return v_;
            }

            IEnumerable<CqlConcept> m_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)k_, l_);
            CqlValueSet n_ = this.Medical_Reason_for_Not_Providing_Treatment(context);
            bool? o_ = context.Operators.ConceptsInValueSet(m_, n_);

            CqlConcept q_(CodeableConcept @this) {
                CqlConcept w_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return w_;
            }

            IEnumerable<CqlConcept> r_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)k_, q_);
            CqlValueSet s_ = this.Patient_Refusal(context);
            bool? t_ = context.Operators.ConceptsInValueSet(r_, s_);
            bool? u_ = context.Operators.Or(o_, t_);
            return u_;
        }

        IEnumerable<MedicationAdministration> g_ = context.Operators.Where<MedicationAdministration>(e_, f_);

        (CqlTupleMetadata, string id, FhirDateTime authoredOn)? h_(MedicationAdministration MedicationAdm) {
            Id x_ = MedicationAdm?.IdElement;
            string y_ = x_?.Value;

            bool? z_(Extension @this) {
                FhirUri ag_ = @this?.UrlElement;
                string ah_ = FHIRHelpers_4_4_000.Instance.ToString(context, ag_);
                bool? ai_ = context.Operators.Equal(ah_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");
                return ai_;
            }

            IEnumerable<Extension> aa_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(MedicationAdm is DomainResource
                ? (MedicationAdm as DomainResource).Extension
                : default), z_);

            DataType ab_(Extension @this) {
                DataType aj_ = @this?.Value;
                return aj_;
            }

            IEnumerable<DataType> ac_ = context.Operators.Select<Extension, DataType>(aa_, ab_);
            DataType ad_ = context.Operators.SingletonFrom<DataType>(ac_);
            FhirDateTime ae_ = context.Operators.Convert<FhirDateTime>(ad_);
            (CqlTupleMetadata, string id, FhirDateTime authoredOn)? af_ = (CqlTupleMetadata_EOIGQCcgaQBFZACEUUODRVWXI, y_, ae_);
            return af_;
        }

        IEnumerable<(CqlTupleMetadata, string id, FhirDateTime authoredOn)?> i_ = context.Operators.Select<MedicationAdministration, (CqlTupleMetadata, string id, FhirDateTime authoredOn)?>(g_, h_);
        IEnumerable<(CqlTupleMetadata, string id, FhirDateTime authoredOn)?> j_ = context.Operators.Distinct<(CqlTupleMetadata, string id, FhirDateTime authoredOn)?>(i_);
        return j_;
    }


    [CqlExpressionDefinition("Documented Reason For No Antithrombotic Ordered Or Administered")]
    public IEnumerable<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?> Documented_Reason_For_No_Antithrombotic_Ordered_Or_Administered(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Documented_Reason_For_No_Antithrombotic_Ordered_Or_Administered, Documented_Reason_For_No_Antithrombotic_Ordered_Or_Administered_Compute);

    private const long _cacheIndex_Documented_Reason_For_No_Antithrombotic_Ordered_Or_Administered = 3645062562921740862L;

    private IEnumerable<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?> Documented_Reason_For_No_Antithrombotic_Ordered_Or_Administered_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?> a_ = this.Reason_For_Not_Ordering_Antithrombotic(context);
        IEnumerable<(CqlTupleMetadata, string id, FhirDateTime authoredOn)?> b_ = this.Reason_For_Not_Administering_Antithrombotic(context);

        (CqlTupleMetadata, string id, CqlDateTime authoredOn)? c_((CqlTupleMetadata, string id, FhirDateTime authoredOn)? tuple_bzzhjagbbziqiedycplbgcjbn) {

            (CqlTupleMetadata, string id, CqlDateTime authoredOn)? f_() {
                if (tuple_bzzhjagbbziqiedycplbgcjbn is null)
                {
                    return null as (CqlTupleMetadata, string id, CqlDateTime authoredOn)?;
                }
                else
                {
                    CqlDateTime g_ = context.Operators.Convert<CqlDateTime>(tuple_bzzhjagbbziqiedycplbgcjbn?.authoredOn);
                    (CqlTupleMetadata, string id, CqlDateTime authoredOn)? h_ = (CqlTupleMetadata_DeYYCcJRPXYVddOGVBSgSSNfR, tuple_bzzhjagbbziqiedycplbgcjbn?.id, g_);
                    return h_;
                };
            }

            return f_();
        }

        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?> d_ = context.Operators.Select<(CqlTupleMetadata, string id, FhirDateTime authoredOn)?, (CqlTupleMetadata, string id, CqlDateTime authoredOn)?>(b_, c_);
        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?> e_ = context.Operators.Union<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?>(a_, d_);
        return e_;
    }


    [CqlExpressionDefinition("Encounter With Documented Reason For No Antithrombotic Ordered Or Administered Day Of Or Day After Hospital Arrival")]
    public IEnumerable<Encounter> Encounter_With_Documented_Reason_For_No_Antithrombotic_Ordered_Or_Administered_Day_Of_Or_Day_After_Hospital_Arrival(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Documented_Reason_For_No_Antithrombotic_Ordered_Or_Administered_Day_Of_Or_Day_After_Hospital_Arrival, Encounter_With_Documented_Reason_For_No_Antithrombotic_Ordered_Or_Administered_Day_Of_Or_Day_After_Hospital_Arrival_Compute);

    private const long _cacheIndex_Encounter_With_Documented_Reason_For_No_Antithrombotic_Ordered_Or_Administered_Day_Of_Or_Day_After_Hospital_Arrival = -933733756341877151L;

    private IEnumerable<Encounter> Encounter_With_Documented_Reason_For_No_Antithrombotic_Ordered_Or_Administered_Day_Of_Or_Day_After_Hospital_Arrival_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = TJCOverall_8_25_000.Instance.Ischemic_Stroke_Encounter(context);

        bool? b_(Encounter IschemicStrokeEncounter) {
            IEnumerable<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?> d_ = this.Documented_Reason_For_No_Antithrombotic_Ordered_Or_Administered(context);

            bool? e_((CqlTupleMetadata, string id, CqlDateTime authoredOn)? NoAntithrombotic) {
                CqlDateTime h_ = NoAntithrombotic?.authoredOn;
                CqlInterval<CqlDateTime> i_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, IschemicStrokeEncounter);
                CqlDateTime j_ = context.Operators.Start(i_);
                CqlInterval<CqlDate> k_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, j_);
                CqlDate l_ = k_?.low;
                CqlDateTime m_ = context.Operators.ConvertDateToDateTime(l_);
                CqlDateTime o_ = context.Operators.Start(i_);
                CqlInterval<CqlDate> p_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, o_);
                CqlDate q_ = p_?.high;
                CqlDateTime r_ = context.Operators.ConvertDateToDateTime(q_);
                CqlDateTime t_ = context.Operators.Start(i_);
                CqlInterval<CqlDate> u_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, t_);
                bool? v_ = u_?.lowClosed;
                CqlDateTime x_ = context.Operators.Start(i_);
                CqlInterval<CqlDate> y_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, x_);
                bool? z_ = y_?.highClosed;
                CqlInterval<CqlDateTime> aa_ = context.Operators.Interval(m_, r_, v_, z_);
                bool? ab_ = context.Operators.In<CqlDateTime>(h_, aa_, "day");
                return ab_;
            }

            IEnumerable<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?> f_ = context.Operators.Where<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?>(d_, e_);
            bool? g_ = context.Operators.Exists<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?>(f_);
            return g_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounter With Pharmacological Contraindications For Antithrombotic Therapy Given Day Of Or Day After Hospital Arrival")]
    public IEnumerable<Encounter> Encounter_With_Pharmacological_Contraindications_For_Antithrombotic_Therapy_Given_Day_Of_Or_Day_After_Hospital_Arrival(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Pharmacological_Contraindications_For_Antithrombotic_Therapy_Given_Day_Of_Or_Day_After_Hospital_Arrival, Encounter_With_Pharmacological_Contraindications_For_Antithrombotic_Therapy_Given_Day_Of_Or_Day_After_Hospital_Arrival_Compute);

    private const long _cacheIndex_Encounter_With_Pharmacological_Contraindications_For_Antithrombotic_Therapy_Given_Day_Of_Or_Day_After_Hospital_Arrival = -7327988219616958657L;

    private IEnumerable<Encounter> Encounter_With_Pharmacological_Contraindications_For_Antithrombotic_Therapy_Given_Day_Of_Or_Day_After_Hospital_Arrival_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = TJCOverall_8_25_000.Instance.Ischemic_Stroke_Encounter(context);

        bool? b_(Encounter IschemicStrokeEncounter) {
            CqlValueSet d_ = this.Pharmacological_Contraindications_For_Antithrombotic_Therapy(context);
            IEnumerable<MedicationAdministration> e_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
            IEnumerable<MedicationAdministration> f_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));

            bool? g_(MedicationAdministration MR) {
                IEnumerable<Medication> m_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? n_(Medication M) {
                    object q_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object r_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> s_ = context.Operators.Split((string)r_, "/");
                    string t_ = context.Operators.Last<string>(s_);
                    bool? u_ = context.Operators.Equal(q_, t_);
                    CodeableConcept v_ = M?.Code;
                    CqlConcept w_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, v_);
                    CqlValueSet x_ = this.Pharmacological_Contraindications_For_Antithrombotic_Therapy(context);
                    bool? y_ = context.Operators.ConceptInValueSet(w_, x_);
                    bool? z_ = context.Operators.And(u_, y_);
                    return z_;
                }

                IEnumerable<Medication> o_ = context.Operators.Where<Medication>(m_, n_);
                bool? p_ = context.Operators.Exists<Medication>(o_);
                return p_;
            }

            IEnumerable<MedicationAdministration> h_ = context.Operators.Where<MedicationAdministration>(f_, g_);
            IEnumerable<MedicationAdministration> i_ = context.Operators.Union<MedicationAdministration>(e_, h_);

            bool? j_(MedicationAdministration PharmacologicalContraindications) {
                Code<MedicationAdministration.MedicationAdministrationStatusCodes> aa_ = PharmacologicalContraindications?.StatusElement;
                MedicationAdministration.MedicationAdministrationStatusCodes? ab_ = aa_?.Value;
                string ac_ = context.Operators.Convert<string>(ab_);
                string[] ad_ = [
                    "in-progress",
                    "completed",
                ];
                bool? ae_ = context.Operators.In<string>(ac_, (IEnumerable<string>)ad_);
                DataType af_ = PharmacologicalContraindications?.Effective;
                object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                CqlInterval<CqlDateTime> ah_ = QICoreCommon_4_0_000.Instance.toInterval(context, ag_);
                CqlDateTime ai_ = context.Operators.Start(ah_);
                CqlInterval<CqlDateTime> aj_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, IschemicStrokeEncounter);
                CqlDateTime ak_ = context.Operators.Start(aj_);
                CqlInterval<CqlDate> al_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ak_);
                CqlDate am_ = al_?.low;
                CqlDateTime an_ = context.Operators.ConvertDateToDateTime(am_);
                CqlDateTime ap_ = context.Operators.Start(aj_);
                CqlInterval<CqlDate> aq_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ap_);
                CqlDate ar_ = aq_?.high;
                CqlDateTime as_ = context.Operators.ConvertDateToDateTime(ar_);
                CqlDateTime au_ = context.Operators.Start(aj_);
                CqlInterval<CqlDate> av_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, au_);
                bool? aw_ = av_?.lowClosed;
                CqlDateTime ay_ = context.Operators.Start(aj_);
                CqlInterval<CqlDate> az_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ay_);
                bool? ba_ = az_?.highClosed;
                CqlInterval<CqlDateTime> bb_ = context.Operators.Interval(an_, as_, aw_, ba_);
                bool? bc_ = context.Operators.In<CqlDateTime>(ai_, bb_, "day");
                bool? bd_ = context.Operators.And(ae_, bc_);
                return bd_;
            }

            IEnumerable<MedicationAdministration> k_ = context.Operators.Where<MedicationAdministration>(i_, j_);
            bool? l_ = context.Operators.Exists<MedicationAdministration>(k_);
            return l_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounter With An INR Greater Than 3.5")]
    public IEnumerable<Encounter> Encounter_With_An_INR_Greater_Than_3_5(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_An_INR_Greater_Than_3_5, Encounter_With_An_INR_Greater_Than_3_5_Compute);

    private const long _cacheIndex_Encounter_With_An_INR_Greater_Than_3_5 = 2623167398842182799L;

    private IEnumerable<Encounter> Encounter_With_An_INR_Greater_Than_3_5_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = TJCOverall_8_25_000.Instance.Ischemic_Stroke_Encounter(context);

        bool? b_(Encounter IschemicStrokeEncounter) {
            CqlValueSet d_ = this.INR(context);
            IEnumerable<Observation> e_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

            bool? f_(Observation INR) {
                DataType i_ = INR?.Value;
                object j_ = FHIRHelpers_4_4_000.Instance.ToValue(context, i_);
                CqlQuantity k_ = context.Operators.ConvertDecimalToQuantity(3.5m);
                bool? l_ = context.Operators.Greater(j_ as CqlQuantity, k_);
                Code<ObservationStatus> m_ = INR?.StatusElement;
                ObservationStatus? n_ = m_?.Value;
                string o_ = context.Operators.Convert<string>(n_);
                string[] p_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? q_ = context.Operators.In<string>(o_, (IEnumerable<string>)p_);
                bool? r_ = context.Operators.And(l_, q_);
                Instant s_ = INR?.IssuedElement;
                DateTimeOffset? t_ = s_?.Value;
                CqlDateTime u_ = context.Operators.Convert<CqlDateTime>(t_);
                CqlInterval<CqlDateTime> v_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, IschemicStrokeEncounter);
                CqlDateTime w_ = context.Operators.Start(v_);
                CqlInterval<CqlDate> x_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, w_);
                CqlDate y_ = x_?.low;
                CqlDateTime z_ = context.Operators.ConvertDateToDateTime(y_);
                CqlDateTime ab_ = context.Operators.Start(v_);
                CqlInterval<CqlDate> ac_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ab_);
                CqlDate ad_ = ac_?.high;
                CqlDateTime ae_ = context.Operators.ConvertDateToDateTime(ad_);
                CqlDateTime ag_ = context.Operators.Start(v_);
                CqlInterval<CqlDate> ah_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ag_);
                bool? ai_ = ah_?.lowClosed;
                CqlDateTime ak_ = context.Operators.Start(v_);
                CqlInterval<CqlDate> al_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ak_);
                bool? am_ = al_?.highClosed;
                CqlInterval<CqlDateTime> an_ = context.Operators.Interval(z_, ae_, ai_, am_);
                bool? ao_ = context.Operators.In<CqlDateTime>(u_, an_, "day");
                bool? ap_ = context.Operators.And(r_, ao_);
                return ap_;
            }

            IEnumerable<Observation> g_ = context.Operators.Where<Observation>(e_, f_);
            bool? h_ = context.Operators.Exists<Observation>(g_);
            return h_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public IEnumerable<Encounter> Denominator_Exceptions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exceptions, Denominator_Exceptions_Compute);

    private const long _cacheIndex_Denominator_Exceptions = 1446486872987181966L;

    private IEnumerable<Encounter> Denominator_Exceptions_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_Documented_Reason_For_No_Antithrombotic_Ordered_Or_Administered_Day_Of_Or_Day_After_Hospital_Arrival(context);
        IEnumerable<Encounter> b_ = this.Encounter_With_Pharmacological_Contraindications_For_Antithrombotic_Therapy_Given_Day_Of_Or_Day_After_Hospital_Arrival(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
        IEnumerable<Encounter> d_ = this.Encounter_With_An_INR_Greater_Than_3_5(context);
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(c_, d_);
        return e_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = -7230563638267797354L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = 8110443236674863966L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = 1993155501011154094L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = -8487983773849745178L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private CMS72FHIRSTKAntithromboticDay2_1_0_000() {}

    public static CMS72FHIRSTKAntithromboticDay2_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS72FHIRSTKAntithromboticDay2";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [CQMCommon_4_1_000.Instance, QICoreCommon_4_0_000.Instance, FHIRHelpers_4_4_000.Instance, SupplementalDataElements_5_1_000.Instance, TJCOverall_8_25_000.Instance];

    #endregion ILibrary Implementation

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
