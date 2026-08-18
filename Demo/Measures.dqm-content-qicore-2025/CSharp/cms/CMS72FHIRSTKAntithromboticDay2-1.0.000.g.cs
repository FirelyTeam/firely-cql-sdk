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
            CqlBoolean f_ = context.Operators.Less(e_, 2);
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
                object g_;
                object w_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                bool y_ = x_ is CqlDateTime;
                if (y_)
                {
                    g_ = x_ as CqlDateTime;
                }
                else
                {
                    bool z_ = x_ is CqlQuantity;
                    if (z_)
                    {
                        g_ = x_ as CqlQuantity;
                    }
                    else
                    {
                        bool aa_ = x_ is CqlInterval<CqlDateTime>;
                        if (aa_)
                        {
                            g_ = x_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool ab_ = x_ is CqlInterval<CqlQuantity>;
                            if (ab_)
                            {
                                g_ = x_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                g_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> h_ = QICoreCommon_4_0_000.Instance.toInterval(context, g_);
                CqlDateTime i_ = context.Operators.Start(h_);
                object j_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "authoredOn");
                CqlDateTime k_ = context.Operators.LateBoundProperty<CqlDateTime>(j_, "value");
                CqlInterval<CqlDateTime> l_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, IschemicStrokeEncounter);
                CqlDateTime m_ = context.Operators.Start(l_);
                CqlInterval<CqlDate> n_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, m_);
                CqlDate o_ = n_?.low;
                CqlDateTime p_ = context.Operators.ConvertDateToDateTime(o_);
                CqlDate q_ = n_?.high;
                CqlDateTime r_ = context.Operators.ConvertDateToDateTime(q_);
                CqlBoolean s_ = n_?.lowClosed;
                CqlBoolean t_ = n_?.highClosed;
                CqlInterval<CqlDateTime> u_ = context.Operators.Interval(p_, r_, s_, t_);
                CqlBoolean v_ = context.Operators.In<CqlDateTime>(i_ ?? k_, u_, "day");
                return v_;
            }

            CqlBoolean f_ = context.Operators.WhereAny<object>(d_, e_);
            return f_;
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
            IEnumerable<Medication> r_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? s_(Medication M) {
                object u_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object v_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> w_ = context.Operators.Split((string)v_, "/");
                string x_ = context.Operators.Last<string>(w_);
                CqlBoolean y_ = context.Operators.Equal(u_, x_);

                CqlBoolean z_() {
                    CodeableConcept aa_ = M?.Code;
                    CqlConcept ab_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, aa_);
                    CqlValueSet ac_ = this.Thrombolytic_tPA_Therapy(context);
                    CqlBoolean ad_ = context.Operators.ConceptInValueSet(ab_, ac_);
                    return ad_;
                }

                return y_
                    /* CQL 'and' */ && z_();
            }

            CqlBoolean t_ = context.Operators.WhereAny<Medication>(r_, s_);
            return t_;
        }

        IEnumerable<MedicationAdministration> c_ = context.Operators.Where<MedicationAdministration>(a_, b_);
        CqlValueSet d_ = this.Thrombolytic_tPA_Therapy(context);
        IEnumerable<MedicationAdministration> e_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> f_ = context.Operators.Union<MedicationAdministration>(c_, e_);

        bool? g_(MedicationAdministration ThrombolyticMedication) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> ae_ = ThrombolyticMedication?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? af_ = ae_?.Value;
            string ag_ = context.Operators.Convert<string>(af_);
            string[] ah_ = [
                "in-progress",
                "completed",
            ];
            CqlBoolean ai_ = context.Operators.In<string>(ag_, (IEnumerable<string>)ah_);
            return ai_;
        }


        (CqlTupleMetadata, string id, object effective)? h_(MedicationAdministration ThrombolyticMedication) {
            Id aj_ = ThrombolyticMedication?.IdElement;
            string ak_ = aj_?.Value;
            DataType al_ = ThrombolyticMedication?.Effective;
            object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
            (CqlTupleMetadata, string id, object effective)? an_ = (CqlTupleMetadata_DbNFZJaRJHECUfPGBeWSUEUQi, ak_, am_);
            return an_;
        }

        IEnumerable<(CqlTupleMetadata, string id, object effective)?> i_ = context.Operators.WhereSelect<MedicationAdministration, (CqlTupleMetadata, string id, object effective)?>(f_, g_, h_);
        IEnumerable<(CqlTupleMetadata, string id, object effective)?> j_ = context.Operators.Distinct<(CqlTupleMetadata, string id, object effective)?>(i_);
        CqlValueSet k_ = this.Intravenous_or_Intraarterial_Thrombolytic_tPA_Therapy(context);
        IEnumerable<Procedure> l_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, k_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

        bool? m_(Procedure ThrombolyticProcedure) {
            Code<EventStatus> ao_ = ThrombolyticProcedure?.StatusElement;
            EventStatus? ap_ = ao_?.Value;
            string aq_ = context.Operators.Convert<string>(ap_);
            CqlBoolean ar_ = context.Operators.Equal(aq_, "completed");
            return ar_;
        }


        (CqlTupleMetadata, string id, object effective)? n_(Procedure ThrombolyticProcedure) {
            Id as_ = ThrombolyticProcedure?.IdElement;
            string at_ = as_?.Value;
            DataType au_ = ThrombolyticProcedure?.Performed;
            object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
            (CqlTupleMetadata, string id, object effective)? aw_ = (CqlTupleMetadata_DbNFZJaRJHECUfPGBeWSUEUQi, at_, av_);
            return aw_;
        }

        IEnumerable<(CqlTupleMetadata, string id, object effective)?> o_ = context.Operators.WhereSelect<Procedure, (CqlTupleMetadata, string id, object effective)?>(l_, m_, n_);
        IEnumerable<(CqlTupleMetadata, string id, object effective)?> p_ = context.Operators.Distinct<(CqlTupleMetadata, string id, object effective)?>(o_);
        IEnumerable<(CqlTupleMetadata, string id, object effective)?> q_ = context.Operators.Union<(CqlTupleMetadata, string id, object effective)?>(j_ as IEnumerable<(CqlTupleMetadata, string id, object effective)?>, p_ as IEnumerable<(CqlTupleMetadata, string id, object effective)?>);
        return q_;
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
                object g_;
                object q_ = ThrombolyticTherapy?.effective;
                bool r_ = q_ is CqlDateTime;
                if (r_)
                {
                    g_ = q_ as CqlDateTime;
                }
                else
                {
                    if (r_)
                    {
                        g_ = q_ as CqlDateTime;
                    }
                    else
                    {
                        bool s_ = q_ is CqlQuantity;
                        if (s_)
                        {
                            g_ = q_ as CqlQuantity;
                        }
                        else
                        {
                            bool t_ = q_ is CqlInterval<CqlDateTime>;
                            if (t_)
                            {
                                g_ = q_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                if (t_)
                                {
                                    g_ = q_ as CqlInterval<CqlDateTime>;
                                }
                                else
                                {
                                    bool u_ = q_ is CqlInterval<CqlQuantity>;
                                    if (u_)
                                    {
                                        g_ = q_ as CqlInterval<CqlQuantity>;
                                    }
                                    else
                                    {
                                        g_ = null;
                                    }
                                }
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> h_ = QICoreCommon_4_0_000.Instance.toInterval(context, g_);
                CqlDateTime i_ = context.Operators.Start(h_);
                CqlInterval<CqlDateTime> j_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, IschemicStrokeEncounter);
                CqlDateTime k_ = context.Operators.Start(j_);
                CqlQuantity l_ = context.Operators.Quantity(24m, "hours");
                CqlDateTime m_ = context.Operators.Subtract(k_, l_);
                CqlDateTime n_ = context.Operators.End(j_);
                CqlInterval<CqlDateTime> o_ = context.Operators.Interval(m_, n_, true, false);
                CqlBoolean p_ = context.Operators.In<CqlDateTime>(i_, o_, (string)default);
                return p_;
            }

            CqlBoolean f_ = context.Operators.WhereAny<(CqlTupleMetadata, string id, object effective)?>(d_, e_);
            return f_;
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
                CodeableConcept g_ = EncounterDiagnosis?.Code;
                CqlConcept h_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, g_);
                CqlValueSet i_ = this.Intravenous_or_Intraarterial_Thrombolytic_tPA_Therapy_Prior_to_Arrival(context);
                CqlBoolean j_ = context.Operators.ConceptInValueSet(h_, i_);
                return j_;
            }

            CqlBoolean f_ = context.Operators.WhereAny<Condition>(d_, e_);
            return f_;
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
                FhirDateTime k_ = PriorTPA?.RecordedDateElement;
                CqlDateTime l_ = context.Operators.Convert<CqlDateTime>(k_);
                CqlInterval<CqlDateTime> m_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, IschemicStrokeEncounter);
                CqlBoolean n_ = context.Operators.In<CqlDateTime>(l_, m_, (string)default);

                CqlBoolean o_() {
                    CodeableConcept q_ = PriorTPA?.VerificationStatus;
                    CqlConcept r_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, q_);
                    return !((bool?)(r_ is null));
                }


                CqlBoolean p_() {
                    CodeableConcept s_ = PriorTPA?.VerificationStatus;
                    CqlConcept t_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, s_);
                    CqlCode u_ = QICoreCommon_4_0_000.Instance.refuted(context);
                    CqlConcept v_ = context.Operators.ConvertCodeToConcept(u_);
                    CqlBoolean w_ = context.Operators.Equivalent(t_, v_);

                    CqlBoolean x_() {
                        CodeableConcept y_ = PriorTPA?.VerificationStatus;
                        CqlConcept z_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, y_);
                        CqlCode aa_ = QICoreCommon_4_0_000.Instance.entered_in_error(context);
                        CqlConcept ab_ = context.Operators.ConvertCodeToConcept(aa_);
                        CqlBoolean ac_ = context.Operators.Equivalent(z_, ab_);
                        return !ac_;
                    }

                    return (CqlBoolean)!w_
                        /* CQL 'and' (81:63-83:9) */ && x_();
                }

                return (CqlBoolean)(!((bool?)(n_
                    /* CQL 'and' (80:15-81:53) */ && o_())))
                    /* CQL 'implies' (80:9-83:9) */ || p_();
            }

            CqlBoolean j_ = context.Operators.WhereAny<Condition>(h_, i_);
            return j_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        bool? d_(Encounter IschemicStrokeEncounter) {
            IEnumerable<Condition> ad_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, IschemicStrokeEncounter);

            bool? ae_(Condition EncounterDiagnosis) {
                CodeableConcept ag_ = EncounterDiagnosis?.Code;
                CqlConcept ah_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ag_);
                CqlValueSet ai_ = this.Intravenous_or_Intraarterial_Thrombolytic_tPA_Therapy_Prior_to_Arrival(context);
                CqlBoolean aj_ = context.Operators.ConceptInValueSet(ah_, ai_);
                return aj_;
            }

            CqlBoolean af_ = context.Operators.WhereAny<Condition>(ad_, ae_);
            return af_;
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
                IEnumerable<Medication> l_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? m_(Medication M) {
                    object o_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object p_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> q_ = context.Operators.Split((string)p_, "/");
                    string r_ = context.Operators.Last<string>(q_);
                    CqlBoolean s_ = context.Operators.Equal(o_, r_);

                    CqlBoolean t_() {
                        CodeableConcept u_ = M?.Code;
                        CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, u_);
                        CqlValueSet w_ = this.Antithrombotic_Therapy_for_Ischemic_Stroke(context);
                        CqlBoolean x_ = context.Operators.ConceptInValueSet(v_, w_);
                        return x_;
                    }

                    return s_
                        /* CQL 'and' */ && t_();
                }

                CqlBoolean n_ = context.Operators.WhereAny<Medication>(l_, m_);
                return n_;
            }

            IEnumerable<MedicationAdministration> f_ = context.Operators.Where<MedicationAdministration>(d_, e_);
            CqlValueSet g_ = this.Antithrombotic_Therapy_for_Ischemic_Stroke(context);
            IEnumerable<MedicationAdministration> h_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
            IEnumerable<MedicationAdministration> i_ = context.Operators.Union<MedicationAdministration>(f_, h_);

            bool? j_(MedicationAdministration Antithrombotic) {
                Code<MedicationAdministration.MedicationAdministrationStatusCodes> y_ = Antithrombotic?.StatusElement;
                MedicationAdministration.MedicationAdministrationStatusCodes? z_ = y_?.Value;
                string aa_ = context.Operators.Convert<string>(z_);
                string[] ab_ = [
                    "in-progress",
                    "completed",
                ];
                CqlBoolean ac_ = context.Operators.In<string>(aa_, (IEnumerable<string>)ab_);

                CqlBoolean ad_() {
                    DataType ae_ = Antithrombotic?.Effective;
                    object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                    CqlInterval<CqlDateTime> ag_ = QICoreCommon_4_0_000.Instance.toInterval(context, af_);
                    CqlDateTime ah_ = context.Operators.Start(ag_);
                    CqlInterval<CqlDateTime> ai_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, IschemicStrokeEncounter);
                    CqlDateTime aj_ = context.Operators.Start(ai_);
                    CqlInterval<CqlDate> ak_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, aj_);
                    CqlDate al_ = ak_?.low;
                    CqlDateTime am_ = context.Operators.ConvertDateToDateTime(al_);
                    CqlDate an_ = ak_?.high;
                    CqlDateTime ao_ = context.Operators.ConvertDateToDateTime(an_);
                    CqlBoolean ap_ = ak_?.lowClosed;
                    CqlBoolean aq_ = ak_?.highClosed;
                    CqlInterval<CqlDateTime> ar_ = context.Operators.Interval(am_, ao_, ap_, aq_);
                    CqlBoolean as_ = context.Operators.In<CqlDateTime>(ah_, ar_, "day");
                    return as_;
                }

                return ac_
                    /* CQL 'and' (96:17-97:172) */ && ad_();
            }

            CqlBoolean k_ = context.Operators.WhereAny<MedicationAdministration>(i_, j_);
            return k_;
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
            List<CodeableConcept> r_ = NoAntithromboticOrder?.ReasonCode;

            CqlConcept s_(CodeableConcept @this) {
                CqlConcept z_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return z_;
            }

            IEnumerable<CqlConcept> t_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)r_, s_);
            CqlValueSet u_ = this.Medical_Reason_for_Not_Providing_Treatment(context);
            CqlBoolean v_ = context.Operators.ConceptsInValueSet(t_, u_);

            CqlBoolean w_() {
                List<CodeableConcept> aa_ = NoAntithromboticOrder?.ReasonCode;

                CqlConcept ab_(CodeableConcept @this) {
                    CqlConcept af_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                    return af_;
                }

                IEnumerable<CqlConcept> ac_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)aa_, ab_);
                CqlValueSet ad_ = this.Patient_Refusal(context);
                CqlBoolean ae_ = context.Operators.ConceptsInValueSet(ac_, ad_);
                return ae_;
            }


            CqlBoolean x_() {
                Code<MedicationRequest.MedicationrequestStatus> ag_ = NoAntithromboticOrder?.StatusElement;
                MedicationRequest.MedicationrequestStatus? ah_ = ag_?.Value;
                string ai_ = context.Operators.Convert<string>(ah_);
                string[] aj_ = [
                    "active",
                    "completed",
                ];
                CqlBoolean ak_ = context.Operators.In<string>(ai_, (IEnumerable<string>)aj_);
                return ak_;
            }


            CqlBoolean y_() {
                Code<MedicationRequest.MedicationRequestIntent> al_ = NoAntithromboticOrder?.IntentElement;
                MedicationRequest.MedicationRequestIntent? am_ = al_?.Value;
                string an_ = context.Operators.Convert<string>(am_);
                string[] ao_ = [
                    "order",
                    "original-order",
                    "reflex-order",
                    "filler-order",
                    "instance-order",
                ];
                CqlBoolean ap_ = context.Operators.In<string>(an_, (IEnumerable<string>)ao_);
                return ap_;
            }

            return (v_
                /* CQL 'or' (125:13-127:7) */ || w_())
                /* CQL 'and' (125:13-128:69) */ && x_()
                /* CQL 'and' (125:7-129:123) */ && y_();
        }


        (CqlTupleMetadata, string id, CqlDateTime authoredOn)? e_(MedicationRequest NoAntithromboticOrder) {
            Id aq_ = NoAntithromboticOrder?.IdElement;
            string ar_ = aq_?.Value;
            FhirDateTime as_ = NoAntithromboticOrder?.AuthoredOnElement;
            CqlDateTime at_ = context.Operators.Convert<CqlDateTime>(as_);
            (CqlTupleMetadata, string id, CqlDateTime authoredOn)? au_ = (CqlTupleMetadata_DeYYCcJRPXYVddOGVBSgSSNfR, ar_, at_);
            return au_;
        }

        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?> f_ = context.Operators.WhereSelect<MedicationRequest, (CqlTupleMetadata, string id, CqlDateTime authoredOn)?>(c_, d_, e_);
        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?> g_ = context.Operators.Distinct<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?>(f_);
        IEnumerable<MedicationRequest> h_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? i_(MedicationRequest MR) {
            IEnumerable<Medication> av_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? aw_(Medication M) {
                object ay_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object az_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> ba_ = context.Operators.Split((string)az_, "/");
                string bb_ = context.Operators.Last<string>(ba_);
                CqlBoolean bc_ = context.Operators.Equal(ay_, bb_);

                CqlBoolean bd_() {
                    CodeableConcept be_ = M?.Code;
                    CqlConcept bf_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, be_);
                    CqlValueSet bg_ = this.Antithrombotic_Therapy_for_Ischemic_Stroke(context);
                    CqlBoolean bh_ = context.Operators.ConceptInValueSet(bf_, bg_);
                    return bh_;
                }

                return bc_
                    /* CQL 'and' */ && bd_();
            }

            CqlBoolean ax_ = context.Operators.WhereAny<Medication>(av_, aw_);
            return ax_;
        }

        IEnumerable<MedicationRequest> j_ = context.Operators.Where<MedicationRequest>(h_, i_);
        IEnumerable<MedicationRequest> k_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> l_ = context.Operators.Union<MedicationRequest>(j_, k_);

        bool? m_(MedicationRequest MedReqAntithrombotic) {
            IEnumerable<Task> bi_ = context.Operators.Retrieve<Task>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-taskrejected"));

            bool? bj_(Task TaskReject) {
                ResourceReference bl_ = TaskReject?.Focus;
                CqlBoolean bm_ = QICoreCommon_4_0_000.Instance.references(context, bl_, MedReqAntithrombotic);

                CqlBoolean bn_() {
                    CodeableConcept bp_ = TaskReject?.StatusReason;
                    CqlConcept bq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bp_);
                    CqlValueSet br_ = this.Medical_Reason_for_Not_Providing_Treatment(context);
                    CqlBoolean bs_ = context.Operators.ConceptInValueSet(bq_, br_);

                    CqlBoolean bt_() {
                        CodeableConcept bu_ = TaskReject?.StatusReason;
                        CqlConcept bv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bu_);
                        CqlValueSet bw_ = this.Patient_Refusal(context);
                        CqlBoolean bx_ = context.Operators.ConceptInValueSet(bv_, bw_);
                        return bx_;
                    }

                    return bs_
                        /* CQL 'or' (138:17-140:13) */ || bt_();
                }


                CqlBoolean bo_() {
                    Code<MedicationRequest.MedicationrequestStatus> by_ = MedReqAntithrombotic?.StatusElement;
                    MedicationRequest.MedicationrequestStatus? bz_ = by_?.Value;
                    string ca_ = context.Operators.Convert<string>(bz_);
                    string[] cb_ = [
                        "active",
                        "completed",
                    ];
                    CqlBoolean cc_ = context.Operators.In<string>(ca_, (IEnumerable<string>)cb_);

                    CqlBoolean cd_() {
                        CodeableConcept ce_ = TaskReject?.Code;
                        CqlConcept cf_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ce_);
                        CqlCode cg_ = QICoreCommon_4_0_000.Instance.Fulfill(context);
                        CqlConcept ch_ = context.Operators.ConvertCodeToConcept(cg_);
                        CqlBoolean ci_ = context.Operators.Equivalent(cf_, ch_);
                        return ci_;
                    }

                    return cc_
                        /* CQL 'and' (141:17-143:13) */ && cd_();
                }

                return bm_
                    /* CQL 'and' (137:21-140:13) */ && bn_()
                    /* CQL 'and' (137:21-143:13) */ && bo_();
            }

            CqlBoolean bk_ = context.Operators.WhereAny<Task>(bi_, bj_);
            return bk_;
        }


        (CqlTupleMetadata, string id, CqlDateTime authoredOn)? n_(MedicationRequest MedReqAntithrombotic) {
            Id cj_ = MedReqAntithrombotic?.IdElement;
            string ck_ = cj_?.Value;
            FhirDateTime cl_ = MedReqAntithrombotic?.AuthoredOnElement;
            CqlDateTime cm_ = context.Operators.Convert<CqlDateTime>(cl_);
            (CqlTupleMetadata, string id, CqlDateTime authoredOn)? cn_ = (CqlTupleMetadata_DeYYCcJRPXYVddOGVBSgSSNfR, ck_, cm_);
            return cn_;
        }

        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?> o_ = context.Operators.WhereSelect<MedicationRequest, (CqlTupleMetadata, string id, CqlDateTime authoredOn)?>(l_, m_, n_);
        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?> p_ = context.Operators.Distinct<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?>(o_);
        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?> q_ = context.Operators.Union<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?>(g_, p_);
        return q_;
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
            List<CodeableConcept> h_ = MedicationAdm?.StatusReason;

            CqlConcept i_(CodeableConcept @this) {
                CqlConcept n_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return n_;
            }

            IEnumerable<CqlConcept> j_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)h_, i_);
            CqlValueSet k_ = this.Medical_Reason_for_Not_Providing_Treatment(context);
            CqlBoolean l_ = context.Operators.ConceptsInValueSet(j_, k_);

            CqlBoolean m_() {
                List<CodeableConcept> o_ = MedicationAdm?.StatusReason;

                CqlConcept p_(CodeableConcept @this) {
                    CqlConcept t_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                    return t_;
                }

                IEnumerable<CqlConcept> q_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)o_, p_);
                CqlValueSet r_ = this.Patient_Refusal(context);
                CqlBoolean s_ = context.Operators.ConceptsInValueSet(q_, r_);
                return s_;
            }

            return l_
                /* CQL 'or' (115:5-117:5) */ || m_();
        }


        (CqlTupleMetadata, string id, FhirDateTime authoredOn)? e_(MedicationAdministration MedicationAdm) {
            Id u_ = MedicationAdm?.IdElement;
            string v_ = u_?.Value;

            bool? w_(Extension @this) {
                FhirUri ac_ = @this?.UrlElement;
                string ad_ = FHIRHelpers_4_4_000.Instance.ToString(context, ac_);
                CqlBoolean ae_ = context.Operators.Equal(ad_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");
                return ae_;
            }


            DataType x_(Extension @this) {
                DataType af_ = @this?.Value;
                return af_;
            }

            IEnumerable<DataType> y_ = context.Operators.WhereSelect<Extension, DataType>((IEnumerable<Extension>)(MedicationAdm is DomainResource
                ? (MedicationAdm as DomainResource).Extension
                : default), w_, x_);
            DataType z_ = context.Operators.SingletonFrom<DataType>(y_);
            FhirDateTime aa_ = context.Operators.Convert<FhirDateTime>(z_);
            (CqlTupleMetadata, string id, FhirDateTime authoredOn)? ab_ = (CqlTupleMetadata_EOIGQCcgaQBFZACEUUODRVWXI, v_, aa_);
            return ab_;
        }

        IEnumerable<(CqlTupleMetadata, string id, FhirDateTime authoredOn)?> f_ = context.Operators.WhereSelect<MedicationAdministration, (CqlTupleMetadata, string id, FhirDateTime authoredOn)?>(c_, d_, e_);
        IEnumerable<(CqlTupleMetadata, string id, FhirDateTime authoredOn)?> g_ = context.Operators.Distinct<(CqlTupleMetadata, string id, FhirDateTime authoredOn)?>(f_);
        return g_;
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
            if (tuple_bzzhjagbbziqiedycplbgcjbn is null)
            {
                return default;
            }
            else
            {
                CqlDateTime f_ = context.Operators.Convert<CqlDateTime>(tuple_bzzhjagbbziqiedycplbgcjbn?.authoredOn);
                (CqlTupleMetadata, string id, CqlDateTime authoredOn)? g_ = (CqlTupleMetadata_DeYYCcJRPXYVddOGVBSgSSNfR, tuple_bzzhjagbbziqiedycplbgcjbn?.id, f_);
                return g_;
            }
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
                CqlDateTime g_ = NoAntithrombotic?.authoredOn;
                CqlInterval<CqlDateTime> h_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, IschemicStrokeEncounter);
                CqlDateTime i_ = context.Operators.Start(h_);
                CqlInterval<CqlDate> j_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, i_);
                CqlDate k_ = j_?.low;
                CqlDateTime l_ = context.Operators.ConvertDateToDateTime(k_);
                CqlDate m_ = j_?.high;
                CqlDateTime n_ = context.Operators.ConvertDateToDateTime(m_);
                CqlBoolean o_ = j_?.lowClosed;
                CqlBoolean p_ = j_?.highClosed;
                CqlInterval<CqlDateTime> q_ = context.Operators.Interval(l_, n_, o_, p_);
                CqlBoolean r_ = context.Operators.In<CqlDateTime>(g_, q_, "day");
                return r_;
            }

            CqlBoolean f_ = context.Operators.WhereAny<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?>(d_, e_);
            return f_;
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
                IEnumerable<Medication> l_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? m_(Medication M) {
                    object o_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object p_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> q_ = context.Operators.Split((string)p_, "/");
                    string r_ = context.Operators.Last<string>(q_);
                    CqlBoolean s_ = context.Operators.Equal(o_, r_);

                    CqlBoolean t_() {
                        CodeableConcept u_ = M?.Code;
                        CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, u_);
                        CqlValueSet w_ = this.Pharmacological_Contraindications_For_Antithrombotic_Therapy(context);
                        CqlBoolean x_ = context.Operators.ConceptInValueSet(v_, w_);
                        return x_;
                    }

                    return s_
                        /* CQL 'and' */ && t_();
                }

                CqlBoolean n_ = context.Operators.WhereAny<Medication>(l_, m_);
                return n_;
            }

            IEnumerable<MedicationAdministration> f_ = context.Operators.Where<MedicationAdministration>(d_, e_);
            CqlValueSet g_ = this.Pharmacological_Contraindications_For_Antithrombotic_Therapy(context);
            IEnumerable<MedicationAdministration> h_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
            IEnumerable<MedicationAdministration> i_ = context.Operators.Union<MedicationAdministration>(f_, h_);

            bool? j_(MedicationAdministration PharmacologicalContraindications) {
                Code<MedicationAdministration.MedicationAdministrationStatusCodes> y_ = PharmacologicalContraindications?.StatusElement;
                MedicationAdministration.MedicationAdministrationStatusCodes? z_ = y_?.Value;
                string aa_ = context.Operators.Convert<string>(z_);
                string[] ab_ = [
                    "in-progress",
                    "completed",
                ];
                CqlBoolean ac_ = context.Operators.In<string>(aa_, (IEnumerable<string>)ab_);

                CqlBoolean ad_() {
                    DataType ae_ = PharmacologicalContraindications?.Effective;
                    object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                    CqlInterval<CqlDateTime> ag_ = QICoreCommon_4_0_000.Instance.toInterval(context, af_);
                    CqlDateTime ah_ = context.Operators.Start(ag_);
                    CqlInterval<CqlDateTime> ai_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, IschemicStrokeEncounter);
                    CqlDateTime aj_ = context.Operators.Start(ai_);
                    CqlInterval<CqlDate> ak_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, aj_);
                    CqlDate al_ = ak_?.low;
                    CqlDateTime am_ = context.Operators.ConvertDateToDateTime(al_);
                    CqlDate an_ = ak_?.high;
                    CqlDateTime ao_ = context.Operators.ConvertDateToDateTime(an_);
                    CqlBoolean ap_ = ak_?.lowClosed;
                    CqlBoolean aq_ = ak_?.highClosed;
                    CqlInterval<CqlDateTime> ar_ = context.Operators.Interval(am_, ao_, ap_, aq_);
                    CqlBoolean as_ = context.Operators.In<CqlDateTime>(ah_, ar_, "day");
                    return as_;
                }

                return ac_
                    /* CQL 'and' (153:17-154:190) */ && ad_();
            }

            CqlBoolean k_ = context.Operators.WhereAny<MedicationAdministration>(i_, j_);
            return k_;
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
                DataType h_ = INR?.Value;
                object i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);
                CqlQuantity j_ = context.Operators.ConvertDecimalToQuantity(3.5m);
                CqlBoolean k_ = context.Operators.Greater(i_ as CqlQuantity, j_);

                CqlBoolean l_() {
                    Code<ObservationStatus> n_ = INR?.StatusElement;
                    ObservationStatus? o_ = n_?.Value;
                    string p_ = context.Operators.Convert<string>(o_);
                    string[] q_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    CqlBoolean r_ = context.Operators.In<string>(p_, (IEnumerable<string>)q_);
                    return r_;
                }


                CqlBoolean m_() {
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
                    CqlBoolean ac_ = x_?.lowClosed;
                    CqlBoolean ad_ = x_?.highClosed;
                    CqlInterval<CqlDateTime> ae_ = context.Operators.Interval(z_, ab_, ac_, ad_);
                    CqlBoolean af_ = context.Operators.In<CqlDateTime>(u_, ae_, "day");
                    return af_;
                }

                return k_
                    /* CQL 'and' (159:17-160:61) */ && l_()
                    /* CQL 'and' (159:17-161:136) */ && m_();
            }

            CqlBoolean g_ = context.Operators.WhereAny<Observation>(e_, f_);
            return g_;
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
