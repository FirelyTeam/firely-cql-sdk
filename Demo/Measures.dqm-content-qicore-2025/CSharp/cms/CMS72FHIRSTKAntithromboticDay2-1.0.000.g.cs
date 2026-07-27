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

                    bool x_() {
                        object ab_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                        object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                        bool ad_ = ac_ is CqlDateTime;
                        return ad_;
                    }


                    bool y_() {
                        object ae_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                        object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                        bool ag_ = af_ is CqlQuantity;
                        return ag_;
                    }


                    bool z_() {
                        object ah_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                        object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                        bool aj_ = ai_ is CqlInterval<CqlDateTime>;
                        return aj_;
                    }


                    bool aa_() {
                        object ak_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                        object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                        bool am_ = al_ is CqlInterval<CqlQuantity>;
                        return am_;
                    }

                    if (x_())
                    {
                        object an_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                        object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                        return ao_ as CqlDateTime;
                    }
                    else if (y_())
                    {
                        object ap_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                        object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                        return aq_ as CqlQuantity;
                    }
                    else if (z_())
                    {
                        object ar_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                        object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                        return as_ as CqlInterval<CqlDateTime>;
                    }
                    else if (aa_())
                    {
                        object at_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                        object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                        return au_ as CqlInterval<CqlQuantity>;
                    }
                    else
                    {
                        return null;
                    }
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
                CqlDate r_ = o_?.high;
                CqlDateTime s_ = context.Operators.ConvertDateToDateTime(r_);
                bool? t_ = o_?.lowClosed;
                bool? u_ = o_?.highClosed;
                CqlInterval<CqlDateTime> v_ = context.Operators.Interval(q_, s_, t_, u_);
                bool? w_ = context.Operators.In<CqlDateTime>(j_ ?? l_, v_, "day");
                return w_;
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
        IEnumerable<MedicationAdministration> a_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));

        bool? b_(MedicationAdministration MR) {
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

        IEnumerable<MedicationAdministration> c_ = context.Operators.Where<MedicationAdministration>(a_, b_);
        CqlValueSet d_ = this.Thrombolytic_tPA_Therapy(context);
        IEnumerable<MedicationAdministration> e_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> f_ = context.Operators.Union<MedicationAdministration>(c_, e_);

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

                    bool r_() {
                        object x_ = ThrombolyticTherapy?.effective;
                        bool y_ = x_ is CqlDateTime;
                        return y_;
                    }


                    bool s_() {
                        object z_ = ThrombolyticTherapy?.effective;
                        bool aa_ = z_ is CqlDateTime;
                        return aa_;
                    }


                    bool t_() {
                        object ab_ = ThrombolyticTherapy?.effective;
                        bool ac_ = ab_ is CqlQuantity;
                        return ac_;
                    }


                    bool u_() {
                        object ad_ = ThrombolyticTherapy?.effective;
                        bool ae_ = ad_ is CqlInterval<CqlDateTime>;
                        return ae_;
                    }


                    bool v_() {
                        object af_ = ThrombolyticTherapy?.effective;
                        bool ag_ = af_ is CqlInterval<CqlDateTime>;
                        return ag_;
                    }


                    bool w_() {
                        object ah_ = ThrombolyticTherapy?.effective;
                        bool ai_ = ah_ is CqlInterval<CqlQuantity>;
                        return ai_;
                    }

                    if (r_())
                    {
                        object aj_ = ThrombolyticTherapy?.effective;
                        return aj_ as CqlDateTime;
                    }
                    else if (s_())
                    {
                        object ak_ = ThrombolyticTherapy?.effective;
                        return ak_ as CqlDateTime;
                    }
                    else if (t_())
                    {
                        object al_ = ThrombolyticTherapy?.effective;
                        return al_ as CqlQuantity;
                    }
                    else if (u_())
                    {
                        object am_ = ThrombolyticTherapy?.effective;
                        return am_ as CqlInterval<CqlDateTime>;
                    }
                    else if (v_())
                    {
                        object an_ = ThrombolyticTherapy?.effective;
                        return an_ as CqlInterval<CqlDateTime>;
                    }
                    else if (w_())
                    {
                        object ao_ = ThrombolyticTherapy?.effective;
                        return ao_ as CqlInterval<CqlQuantity>;
                    }
                    else
                    {
                        return null;
                    }
                }

                CqlInterval<CqlDateTime> i_ = QICoreCommon_4_0_000.Instance.toInterval(context, h_());
                CqlDateTime j_ = context.Operators.Start(i_);
                CqlInterval<CqlDateTime> k_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, IschemicStrokeEncounter);
                CqlDateTime l_ = context.Operators.Start(k_);
                CqlQuantity m_ = context.Operators.Quantity(24m, "hours");
                CqlDateTime n_ = context.Operators.Subtract(l_, m_);
                CqlDateTime o_ = context.Operators.End(k_);
                CqlInterval<CqlDateTime> p_ = context.Operators.Interval(n_, o_, true, false);
                bool? q_ = context.Operators.In<CqlDateTime>(j_, p_, (string)default);
                return q_;
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
            CqlValueSet g_ = this.Intravenous_or_Intraarterial_Thrombolytic_tPA_Therapy_Prior_to_Arrival(context);
            IEnumerable<Condition> h_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

            bool? i_(Condition PriorTPA) {
                FhirDateTime l_ = PriorTPA?.RecordedDateElement;
                CqlDateTime m_ = context.Operators.Convert<CqlDateTime>(l_);
                CqlInterval<CqlDateTime> n_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, IschemicStrokeEncounter);
                bool? o_ = context.Operators.In<CqlDateTime>(m_, n_, (string)default);
                CodeableConcept p_ = PriorTPA?.VerificationStatus;
                CqlConcept q_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, p_);
                bool? r_ = context.Operators.Not((bool?)(q_ is null));
                bool? s_ = context.Operators.And(o_, r_);
                CqlCode t_ = QICoreCommon_4_0_000.Instance.refuted(context);
                CqlConcept u_ = context.Operators.ConvertCodeToConcept(t_);
                bool? v_ = context.Operators.Equivalent(q_, u_);
                bool? w_ = context.Operators.Not(v_);
                CqlCode x_ = QICoreCommon_4_0_000.Instance.entered_in_error(context);
                CqlConcept y_ = context.Operators.ConvertCodeToConcept(x_);
                bool? z_ = context.Operators.Equivalent(q_, y_);
                bool? aa_ = context.Operators.Not(z_);
                bool? ab_ = context.Operators.And(w_, aa_);
                bool? ac_ = context.Operators.Implies(s_, ab_);
                return ac_;
            }

            IEnumerable<Condition> j_ = context.Operators.Where<Condition>(h_, i_);
            bool? k_ = context.Operators.Exists<Condition>(j_);
            return k_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        bool? d_(Encounter IschemicStrokeEncounter) {
            IEnumerable<Condition> ad_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, IschemicStrokeEncounter);

            bool? ae_(Condition EncounterDiagnosis) {
                CodeableConcept ah_ = EncounterDiagnosis?.Code;
                CqlConcept ai_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ah_);
                CqlValueSet aj_ = this.Intravenous_or_Intraarterial_Thrombolytic_tPA_Therapy_Prior_to_Arrival(context);
                bool? ak_ = context.Operators.ConceptInValueSet(ai_, aj_);
                return ak_;
            }

            IEnumerable<Condition> af_ = context.Operators.Where<Condition>(ad_, ae_);
            bool? ag_ = context.Operators.Exists<Condition>(af_);
            return ag_;
        }

        IEnumerable<Encounter> e_ = context.Operators.Where<Encounter>(a_, d_);
        IEnumerable<Encounter> f_ = context.Operators.Union<Encounter>(c_, e_);
        return f_;
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
            IEnumerable<MedicationAdministration> d_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));

            bool? e_(MedicationAdministration MR) {
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

            IEnumerable<MedicationAdministration> f_ = context.Operators.Where<MedicationAdministration>(d_, e_);
            CqlValueSet g_ = this.Antithrombotic_Therapy_for_Ischemic_Stroke(context);
            IEnumerable<MedicationAdministration> h_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
            IEnumerable<MedicationAdministration> i_ = context.Operators.Union<MedicationAdministration>(f_, h_);

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
                CqlDate ao_ = al_?.high;
                CqlDateTime ap_ = context.Operators.ConvertDateToDateTime(ao_);
                bool? aq_ = al_?.lowClosed;
                bool? ar_ = al_?.highClosed;
                CqlInterval<CqlDateTime> as_ = context.Operators.Interval(an_, ap_, aq_, ar_);
                bool? at_ = context.Operators.In<CqlDateTime>(ai_, as_, "day");
                bool? au_ = context.Operators.And(ae_, at_);
                return au_;
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
        IEnumerable<MedicationRequest> c_ = context.Operators.Union<MedicationRequest>(b_, b_);

        bool? d_(MedicationRequest NoAntithromboticOrder) {
            List<CodeableConcept> t_ = NoAntithromboticOrder?.ReasonCode;

            CqlConcept u_(CodeableConcept @this) {
                CqlConcept ap_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return ap_;
            }

            IEnumerable<CqlConcept> v_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)t_, u_);
            CqlValueSet w_ = this.Medical_Reason_for_Not_Providing_Treatment(context);
            bool? x_ = context.Operators.ConceptsInValueSet(v_, w_);

            CqlConcept y_(CodeableConcept @this) {
                CqlConcept aq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return aq_;
            }

            IEnumerable<CqlConcept> z_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)t_, y_);
            CqlValueSet aa_ = this.Patient_Refusal(context);
            bool? ab_ = context.Operators.ConceptsInValueSet(z_, aa_);
            bool? ac_ = context.Operators.Or(x_, ab_);
            Code<MedicationRequest.MedicationrequestStatus> ad_ = NoAntithromboticOrder?.StatusElement;
            MedicationRequest.MedicationrequestStatus? ae_ = ad_?.Value;
            string af_ = context.Operators.Convert<string>(ae_);
            string[] ag_ = [
                "active",
                "completed",
            ];
            bool? ah_ = context.Operators.In<string>(af_, (IEnumerable<string>)ag_);
            bool? ai_ = context.Operators.And(ac_, ah_);
            Code<MedicationRequest.MedicationRequestIntent> aj_ = NoAntithromboticOrder?.IntentElement;
            MedicationRequest.MedicationRequestIntent? ak_ = aj_?.Value;
            string al_ = context.Operators.Convert<string>(ak_);
            string[] am_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? an_ = context.Operators.In<string>(al_, (IEnumerable<string>)am_);
            bool? ao_ = context.Operators.And(ai_, an_);
            return ao_;
        }

        IEnumerable<MedicationRequest> e_ = context.Operators.Where<MedicationRequest>(c_, d_);

        (CqlTupleMetadata, string id, CqlDateTime authoredOn)? f_(MedicationRequest NoAntithromboticOrder) {
            Id ar_ = NoAntithromboticOrder?.IdElement;
            string as_ = ar_?.Value;
            FhirDateTime at_ = NoAntithromboticOrder?.AuthoredOnElement;
            CqlDateTime au_ = context.Operators.Convert<CqlDateTime>(at_);
            (CqlTupleMetadata, string id, CqlDateTime authoredOn)? av_ = (CqlTupleMetadata_DeYYCcJRPXYVddOGVBSgSSNfR, as_, au_);
            return av_;
        }

        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?> g_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, string id, CqlDateTime authoredOn)?>(e_, f_);
        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?> h_ = context.Operators.Distinct<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?>(g_);
        IEnumerable<MedicationRequest> i_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? j_(MedicationRequest MR) {
            IEnumerable<Medication> aw_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? ax_(Medication M) {
                object ba_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object bb_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> bc_ = context.Operators.Split((string)bb_, "/");
                string bd_ = context.Operators.Last<string>(bc_);
                bool? be_ = context.Operators.Equal(ba_, bd_);
                CodeableConcept bf_ = M?.Code;
                CqlConcept bg_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bf_);
                CqlValueSet bh_ = this.Antithrombotic_Therapy_for_Ischemic_Stroke(context);
                bool? bi_ = context.Operators.ConceptInValueSet(bg_, bh_);
                bool? bj_ = context.Operators.And(be_, bi_);
                return bj_;
            }

            IEnumerable<Medication> ay_ = context.Operators.Where<Medication>(aw_, ax_);
            bool? az_ = context.Operators.Exists<Medication>(ay_);
            return az_;
        }

        IEnumerable<MedicationRequest> k_ = context.Operators.Where<MedicationRequest>(i_, j_);
        IEnumerable<MedicationRequest> l_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> m_ = context.Operators.Union<MedicationRequest>(k_, l_);

        bool? n_(MedicationRequest MedReqAntithrombotic) {
            IEnumerable<Task> bk_ = context.Operators.Retrieve<Task>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-taskrejected"));

            bool? bl_(Task TaskReject) {
                ResourceReference bo_ = TaskReject?.Focus;
                bool? bp_ = QICoreCommon_4_0_000.Instance.references(context, bo_, MedReqAntithrombotic);
                CodeableConcept bq_ = TaskReject?.StatusReason;
                CqlConcept br_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bq_);
                CqlValueSet bs_ = this.Medical_Reason_for_Not_Providing_Treatment(context);
                bool? bt_ = context.Operators.ConceptInValueSet(br_, bs_);
                CqlValueSet bu_ = this.Patient_Refusal(context);
                bool? bv_ = context.Operators.ConceptInValueSet(br_, bu_);
                bool? bw_ = context.Operators.Or(bt_, bv_);
                bool? bx_ = context.Operators.And(bp_, bw_);
                Code<MedicationRequest.MedicationrequestStatus> by_ = MedReqAntithrombotic?.StatusElement;
                MedicationRequest.MedicationrequestStatus? bz_ = by_?.Value;
                string ca_ = context.Operators.Convert<string>(bz_);
                string[] cb_ = [
                    "active",
                    "completed",
                ];
                bool? cc_ = context.Operators.In<string>(ca_, (IEnumerable<string>)cb_);
                CodeableConcept cd_ = TaskReject?.Code;
                CqlConcept ce_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cd_);
                CqlCode cf_ = QICoreCommon_4_0_000.Instance.Fulfill(context);
                CqlConcept cg_ = context.Operators.ConvertCodeToConcept(cf_);
                bool? ch_ = context.Operators.Equivalent(ce_, cg_);
                bool? ci_ = context.Operators.And(cc_, ch_);
                bool? cj_ = context.Operators.And(bx_, ci_);
                return cj_;
            }

            IEnumerable<Task> bm_ = context.Operators.Where<Task>(bk_, bl_);
            bool? bn_ = context.Operators.Exists<Task>(bm_);
            return bn_;
        }

        IEnumerable<MedicationRequest> o_ = context.Operators.Where<MedicationRequest>(m_, n_);

        (CqlTupleMetadata, string id, CqlDateTime authoredOn)? p_(MedicationRequest MedReqAntithrombotic) {
            Id ck_ = MedReqAntithrombotic?.IdElement;
            string cl_ = ck_?.Value;
            FhirDateTime cm_ = MedReqAntithrombotic?.AuthoredOnElement;
            CqlDateTime cn_ = context.Operators.Convert<CqlDateTime>(cm_);
            (CqlTupleMetadata, string id, CqlDateTime authoredOn)? co_ = (CqlTupleMetadata_DeYYCcJRPXYVddOGVBSgSSNfR, cl_, cn_);
            return co_;
        }

        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?> q_ = context.Operators.Select<MedicationRequest, (CqlTupleMetadata, string id, CqlDateTime authoredOn)?>(o_, p_);
        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?> r_ = context.Operators.Distinct<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?>(q_);
        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?> s_ = context.Operators.Union<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?>(h_, r_);
        return s_;
    }


    [CqlExpressionDefinition("Reason For Not Administering Antithrombotic")]
    public IEnumerable<(CqlTupleMetadata, string id, FhirDateTime authoredOn)?> Reason_For_Not_Administering_Antithrombotic(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Reason_For_Not_Administering_Antithrombotic, Reason_For_Not_Administering_Antithrombotic_Compute);

    private const long _cacheIndex_Reason_For_Not_Administering_Antithrombotic = 4621061554767489361L;

    private IEnumerable<(CqlTupleMetadata, string id, FhirDateTime authoredOn)?> Reason_For_Not_Administering_Antithrombotic_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Antithrombotic_Therapy_for_Ischemic_Stroke(context);
        IEnumerable<MedicationAdministration> b_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministrationnotdone"));
        IEnumerable<MedicationAdministration> c_ = context.Operators.Union<MedicationAdministration>(b_, b_);

        bool? d_(MedicationAdministration MedicationAdm) {
            List<CodeableConcept> i_ = MedicationAdm?.StatusReason;

            CqlConcept j_(CodeableConcept @this) {
                CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return s_;
            }

            IEnumerable<CqlConcept> k_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)i_, j_);
            CqlValueSet l_ = this.Medical_Reason_for_Not_Providing_Treatment(context);
            bool? m_ = context.Operators.ConceptsInValueSet(k_, l_);

            CqlConcept n_(CodeableConcept @this) {
                CqlConcept t_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return t_;
            }

            IEnumerable<CqlConcept> o_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)i_, n_);
            CqlValueSet p_ = this.Patient_Refusal(context);
            bool? q_ = context.Operators.ConceptsInValueSet(o_, p_);
            bool? r_ = context.Operators.Or(m_, q_);
            return r_;
        }

        IEnumerable<MedicationAdministration> e_ = context.Operators.Where<MedicationAdministration>(c_, d_);

        (CqlTupleMetadata, string id, FhirDateTime authoredOn)? f_(MedicationAdministration MedicationAdm) {
            Id u_ = MedicationAdm?.IdElement;
            string v_ = u_?.Value;

            bool? w_(Extension @this) {
                FhirUri ad_ = @this?.UrlElement;
                string ae_ = FHIRHelpers_4_4_000.Instance.ToString(context, ad_);
                bool? af_ = context.Operators.Equal(ae_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");
                return af_;
            }

            IEnumerable<Extension> x_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(MedicationAdm is DomainResource
                ? (MedicationAdm as DomainResource).Extension
                : default), w_);

            DataType y_(Extension @this) {
                DataType ag_ = @this?.Value;
                return ag_;
            }

            IEnumerable<DataType> z_ = context.Operators.Select<Extension, DataType>(x_, y_);
            DataType aa_ = context.Operators.SingletonFrom<DataType>(z_);
            FhirDateTime ab_ = context.Operators.Convert<FhirDateTime>(aa_);
            (CqlTupleMetadata, string id, FhirDateTime authoredOn)? ac_ = (CqlTupleMetadata_EOIGQCcgaQBFZACEUUODRVWXI, v_, ab_);
            return ac_;
        }

        IEnumerable<(CqlTupleMetadata, string id, FhirDateTime authoredOn)?> g_ = context.Operators.Select<MedicationAdministration, (CqlTupleMetadata, string id, FhirDateTime authoredOn)?>(e_, f_);
        IEnumerable<(CqlTupleMetadata, string id, FhirDateTime authoredOn)?> h_ = context.Operators.Distinct<(CqlTupleMetadata, string id, FhirDateTime authoredOn)?>(g_);
        return h_;
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
                    return default;
                }
                else
                {
                    CqlDateTime g_ = context.Operators.Convert<CqlDateTime>(tuple_bzzhjagbbziqiedycplbgcjbn?.authoredOn);
                    (CqlTupleMetadata, string id, CqlDateTime authoredOn)? h_ = (CqlTupleMetadata_DeYYCcJRPXYVddOGVBSgSSNfR, tuple_bzzhjagbbziqiedycplbgcjbn?.id, g_);
                    return h_;
                }
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
                CqlDate n_ = k_?.high;
                CqlDateTime o_ = context.Operators.ConvertDateToDateTime(n_);
                bool? p_ = k_?.lowClosed;
                bool? q_ = k_?.highClosed;
                CqlInterval<CqlDateTime> r_ = context.Operators.Interval(m_, o_, p_, q_);
                bool? s_ = context.Operators.In<CqlDateTime>(h_, r_, "day");
                return s_;
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
            IEnumerable<MedicationAdministration> d_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));

            bool? e_(MedicationAdministration MR) {
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

            IEnumerable<MedicationAdministration> f_ = context.Operators.Where<MedicationAdministration>(d_, e_);
            CqlValueSet g_ = this.Pharmacological_Contraindications_For_Antithrombotic_Therapy(context);
            IEnumerable<MedicationAdministration> h_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
            IEnumerable<MedicationAdministration> i_ = context.Operators.Union<MedicationAdministration>(f_, h_);

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
                CqlDate ao_ = al_?.high;
                CqlDateTime ap_ = context.Operators.ConvertDateToDateTime(ao_);
                bool? aq_ = al_?.lowClosed;
                bool? ar_ = al_?.highClosed;
                CqlInterval<CqlDateTime> as_ = context.Operators.Interval(an_, ap_, aq_, ar_);
                bool? at_ = context.Operators.In<CqlDateTime>(ai_, as_, "day");
                bool? au_ = context.Operators.And(ae_, at_);
                return au_;
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
                CqlDate aa_ = x_?.high;
                CqlDateTime ab_ = context.Operators.ConvertDateToDateTime(aa_);
                bool? ac_ = x_?.lowClosed;
                bool? ad_ = x_?.highClosed;
                CqlInterval<CqlDateTime> ae_ = context.Operators.Interval(z_, ab_, ac_, ad_);
                bool? af_ = context.Operators.In<CqlDateTime>(u_, ae_, "day");
                bool? ag_ = context.Operators.And(r_, af_);
                return ag_;
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
