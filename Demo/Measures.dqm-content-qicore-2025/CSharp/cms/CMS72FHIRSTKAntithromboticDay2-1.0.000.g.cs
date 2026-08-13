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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.2.2.0")]
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
                object g_;
                object w_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                bool y_ = x_ is CqlDateTime;
                if (y_)
                {
                    object z_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                    object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                    g_ = aa_ as CqlDateTime;
                }
                else
                {
                    object ab_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    bool ad_ = ac_ is CqlQuantity;
                    if (ad_)
                    {
                        object ae_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                        object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                        g_ = af_ as CqlQuantity;
                    }
                    else
                    {
                        object ag_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                        object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                        bool ai_ = ah_ is CqlInterval<CqlDateTime>;
                        if (ai_)
                        {
                            object aj_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                            object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                            g_ = ak_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            object al_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                            object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                            bool an_ = am_ is CqlInterval<CqlQuantity>;
                            if (an_)
                            {
                                object ao_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
                                object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                                g_ = ap_ as CqlInterval<CqlQuantity>;
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
                bool? s_ = n_?.lowClosed;
                bool? t_ = n_?.highClosed;
                CqlInterval<CqlDateTime> u_ = context.Operators.Interval(p_, r_, s_, t_);
                bool? v_ = context.Operators.In<CqlDateTime>(i_ ?? k_, u_, "day");
                return v_;
            }

            bool? f_ = context.Operators.WhereAny<object>(d_, e_);
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
                bool? y_ = context.Operators.Equal(u_, x_);
                // CQL 'and': right operand skipped when left is false
                if (y_ is false)
                {
                    return false;
                }
                else
                {
                    CodeableConcept z_ = M?.Code;
                    CqlConcept aa_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, z_);
                    CqlValueSet ab_ = this.Thrombolytic_tPA_Therapy(context);
                    bool? ac_ = context.Operators.ConceptInValueSet(aa_, ab_);
                    return y_ & ac_;
                }
            }

            bool? t_ = context.Operators.WhereAny<Medication>(r_, s_);
            return t_;
        }

        IEnumerable<MedicationAdministration> c_ = context.Operators.Where<MedicationAdministration>(a_, b_);
        CqlValueSet d_ = this.Thrombolytic_tPA_Therapy(context);
        IEnumerable<MedicationAdministration> e_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> f_ = context.Operators.Union<MedicationAdministration>(c_, e_);

        bool? g_(MedicationAdministration ThrombolyticMedication) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> ad_ = ThrombolyticMedication?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? ae_ = ad_?.Value;
            string af_ = context.Operators.Convert<string>(ae_);
            string[] ag_ = [
                "in-progress",
                "completed",
            ];
            bool? ah_ = context.Operators.In<string>(af_, (IEnumerable<string>)ag_);
            return ah_;
        }


        (CqlTupleMetadata, string id, object effective)? h_(MedicationAdministration ThrombolyticMedication) {
            Id ai_ = ThrombolyticMedication?.IdElement;
            string aj_ = ai_?.Value;
            DataType ak_ = ThrombolyticMedication?.Effective;
            object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
            (CqlTupleMetadata, string id, object effective)? am_ = (CqlTupleMetadata_DbNFZJaRJHECUfPGBeWSUEUQi, aj_, al_);
            return am_;
        }

        IEnumerable<(CqlTupleMetadata, string id, object effective)?> i_ = context.Operators.WhereSelect<MedicationAdministration, (CqlTupleMetadata, string id, object effective)?>(f_, g_, h_);
        IEnumerable<(CqlTupleMetadata, string id, object effective)?> j_ = context.Operators.Distinct<(CqlTupleMetadata, string id, object effective)?>(i_);
        CqlValueSet k_ = this.Intravenous_or_Intraarterial_Thrombolytic_tPA_Therapy(context);
        IEnumerable<Procedure> l_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, k_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

        bool? m_(Procedure ThrombolyticProcedure) {
            Code<EventStatus> an_ = ThrombolyticProcedure?.StatusElement;
            EventStatus? ao_ = an_?.Value;
            string ap_ = context.Operators.Convert<string>(ao_);
            bool? aq_ = context.Operators.Equal(ap_, "completed");
            return aq_;
        }


        (CqlTupleMetadata, string id, object effective)? n_(Procedure ThrombolyticProcedure) {
            Id ar_ = ThrombolyticProcedure?.IdElement;
            string as_ = ar_?.Value;
            DataType at_ = ThrombolyticProcedure?.Performed;
            object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
            (CqlTupleMetadata, string id, object effective)? av_ = (CqlTupleMetadata_DbNFZJaRJHECUfPGBeWSUEUQi, as_, au_);
            return av_;
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
                    object s_ = ThrombolyticTherapy?.effective;
                    g_ = s_ as CqlDateTime;
                }
                else
                {
                    object t_ = ThrombolyticTherapy?.effective;
                    bool u_ = t_ is CqlDateTime;
                    if (u_)
                    {
                        object v_ = ThrombolyticTherapy?.effective;
                        g_ = v_ as CqlDateTime;
                    }
                    else
                    {
                        object w_ = ThrombolyticTherapy?.effective;
                        bool x_ = w_ is CqlQuantity;
                        if (x_)
                        {
                            object y_ = ThrombolyticTherapy?.effective;
                            g_ = y_ as CqlQuantity;
                        }
                        else
                        {
                            object z_ = ThrombolyticTherapy?.effective;
                            bool aa_ = z_ is CqlInterval<CqlDateTime>;
                            if (aa_)
                            {
                                object ab_ = ThrombolyticTherapy?.effective;
                                g_ = ab_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                object ac_ = ThrombolyticTherapy?.effective;
                                bool ad_ = ac_ is CqlInterval<CqlDateTime>;
                                if (ad_)
                                {
                                    object ae_ = ThrombolyticTherapy?.effective;
                                    g_ = ae_ as CqlInterval<CqlDateTime>;
                                }
                                else
                                {
                                    object af_ = ThrombolyticTherapy?.effective;
                                    bool ag_ = af_ is CqlInterval<CqlQuantity>;
                                    if (ag_)
                                    {
                                        object ah_ = ThrombolyticTherapy?.effective;
                                        g_ = ah_ as CqlInterval<CqlQuantity>;
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
                bool? p_ = context.Operators.In<CqlDateTime>(i_, o_, (string)default);
                return p_;
            }

            bool? f_ = context.Operators.WhereAny<(CqlTupleMetadata, string id, object effective)?>(d_, e_);
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
                bool? j_ = context.Operators.ConceptInValueSet(h_, i_);
                return j_;
            }

            bool? f_ = context.Operators.WhereAny<Condition>(d_, e_);
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
                bool? n_ = context.Operators.In<CqlDateTime>(l_, m_, (string)default);
                bool? o_;
                // CQL 'and' (80:15-81:53): right operand skipped when left is false
                if (n_ is false)
                {
                    o_ = false;
                }
                else
                {
                    CodeableConcept x_ = PriorTPA?.VerificationStatus;
                    CqlConcept y_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, x_);
                    o_ = n_ & (!((bool?)(y_ is null)));
                }
                CodeableConcept p_ = PriorTPA?.VerificationStatus;
                CqlConcept q_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, p_);
                CqlCode r_ = QICoreCommon_4_0_000.Instance.refuted(context);
                CqlConcept s_ = context.Operators.ConvertCodeToConcept(r_);
                bool? t_ = context.Operators.Equivalent(q_, s_);
                bool? u_ = !t_;
                bool? v_;
                // CQL 'and' (81:63-83:9): right operand skipped when left is false
                if (u_ is false)
                {
                    v_ = false;
                }
                else
                {
                    CodeableConcept z_ = PriorTPA?.VerificationStatus;
                    CqlConcept aa_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, z_);
                    CqlCode ab_ = QICoreCommon_4_0_000.Instance.entered_in_error(context);
                    CqlConcept ac_ = context.Operators.ConvertCodeToConcept(ab_);
                    bool? ad_ = context.Operators.Equivalent(aa_, ac_);
                    v_ = u_ & !ad_;
                }
                bool? w_ = context.Operators.Implies(o_, v_);
                return w_;
            }

            bool? j_ = context.Operators.WhereAny<Condition>(h_, i_);
            return j_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        bool? d_(Encounter IschemicStrokeEncounter) {
            IEnumerable<Condition> ae_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, IschemicStrokeEncounter);

            bool? af_(Condition EncounterDiagnosis) {
                CodeableConcept ah_ = EncounterDiagnosis?.Code;
                CqlConcept ai_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ah_);
                CqlValueSet aj_ = this.Intravenous_or_Intraarterial_Thrombolytic_tPA_Therapy_Prior_to_Arrival(context);
                bool? ak_ = context.Operators.ConceptInValueSet(ai_, aj_);
                return ak_;
            }

            bool? ag_ = context.Operators.WhereAny<Condition>(ae_, af_);
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
                IEnumerable<Medication> l_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? m_(Medication M) {
                    object o_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object p_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> q_ = context.Operators.Split((string)p_, "/");
                    string r_ = context.Operators.Last<string>(q_);
                    bool? s_ = context.Operators.Equal(o_, r_);
                    // CQL 'and': right operand skipped when left is false
                    if (s_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        CodeableConcept t_ = M?.Code;
                        CqlConcept u_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, t_);
                        CqlValueSet v_ = this.Antithrombotic_Therapy_for_Ischemic_Stroke(context);
                        bool? w_ = context.Operators.ConceptInValueSet(u_, v_);
                        return s_ & w_;
                    }
                }

                bool? n_ = context.Operators.WhereAny<Medication>(l_, m_);
                return n_;
            }

            IEnumerable<MedicationAdministration> f_ = context.Operators.Where<MedicationAdministration>(d_, e_);
            CqlValueSet g_ = this.Antithrombotic_Therapy_for_Ischemic_Stroke(context);
            IEnumerable<MedicationAdministration> h_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
            IEnumerable<MedicationAdministration> i_ = context.Operators.Union<MedicationAdministration>(f_, h_);

            bool? j_(MedicationAdministration Antithrombotic) {
                Code<MedicationAdministration.MedicationAdministrationStatusCodes> x_ = Antithrombotic?.StatusElement;
                MedicationAdministration.MedicationAdministrationStatusCodes? y_ = x_?.Value;
                string z_ = context.Operators.Convert<string>(y_);
                string[] aa_ = [
                    "in-progress",
                    "completed",
                ];
                bool? ab_ = context.Operators.In<string>(z_, (IEnumerable<string>)aa_);
                // CQL 'and' (96:17-97:172): right operand skipped when left is false
                if (ab_ is false)
                {
                    return false;
                }
                else
                {
                    DataType ac_ = Antithrombotic?.Effective;
                    object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                    CqlInterval<CqlDateTime> ae_ = QICoreCommon_4_0_000.Instance.toInterval(context, ad_);
                    CqlDateTime af_ = context.Operators.Start(ae_);
                    CqlInterval<CqlDateTime> ag_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, IschemicStrokeEncounter);
                    CqlDateTime ah_ = context.Operators.Start(ag_);
                    CqlInterval<CqlDate> ai_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ah_);
                    CqlDate aj_ = ai_?.low;
                    CqlDateTime ak_ = context.Operators.ConvertDateToDateTime(aj_);
                    CqlDate al_ = ai_?.high;
                    CqlDateTime am_ = context.Operators.ConvertDateToDateTime(al_);
                    bool? an_ = ai_?.lowClosed;
                    bool? ao_ = ai_?.highClosed;
                    CqlInterval<CqlDateTime> ap_ = context.Operators.Interval(ak_, am_, an_, ao_);
                    bool? aq_ = context.Operators.In<CqlDateTime>(af_, ap_, "day");
                    return ab_ & aq_;
                }
            }

            bool? k_ = context.Operators.WhereAny<MedicationAdministration>(i_, j_);
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
                CqlConcept y_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return y_;
            }

            IEnumerable<CqlConcept> t_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)r_, s_);
            CqlValueSet u_ = this.Medical_Reason_for_Not_Providing_Treatment(context);
            bool? v_ = context.Operators.ConceptsInValueSet(t_, u_);
            bool? w_;
            // CQL 'or' (125:13-127:7): right operand skipped when left is true
            if (v_ is true)
            {
                w_ = true;
            }
            else
            {
                List<CodeableConcept> z_ = NoAntithromboticOrder?.ReasonCode;

                CqlConcept aa_(CodeableConcept @this) {
                    CqlConcept ae_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                    return ae_;
                }

                IEnumerable<CqlConcept> ab_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)z_, aa_);
                CqlValueSet ac_ = this.Patient_Refusal(context);
                bool? ad_ = context.Operators.ConceptsInValueSet(ab_, ac_);
                w_ = v_ | ad_;
            }
            bool? x_;
            // CQL 'and' (125:13-128:69): right operand skipped when left is false
            if (w_ is false)
            {
                x_ = false;
            }
            else
            {
                Code<MedicationRequest.MedicationrequestStatus> af_ = NoAntithromboticOrder?.StatusElement;
                MedicationRequest.MedicationrequestStatus? ag_ = af_?.Value;
                string ah_ = context.Operators.Convert<string>(ag_);
                string[] ai_ = [
                    "active",
                    "completed",
                ];
                bool? aj_ = context.Operators.In<string>(ah_, (IEnumerable<string>)ai_);
                x_ = w_ & aj_;
            }
            // CQL 'and' (125:7-129:123): right operand skipped when left is false
            if (x_ is false)
            {
                return false;
            }
            else
            {
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
                return x_ & ao_;
            }
        }


        (CqlTupleMetadata, string id, CqlDateTime authoredOn)? e_(MedicationRequest NoAntithromboticOrder) {
            Id ap_ = NoAntithromboticOrder?.IdElement;
            string aq_ = ap_?.Value;
            FhirDateTime ar_ = NoAntithromboticOrder?.AuthoredOnElement;
            CqlDateTime as_ = context.Operators.Convert<CqlDateTime>(ar_);
            (CqlTupleMetadata, string id, CqlDateTime authoredOn)? at_ = (CqlTupleMetadata_DeYYCcJRPXYVddOGVBSgSSNfR, aq_, as_);
            return at_;
        }

        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?> f_ = context.Operators.WhereSelect<MedicationRequest, (CqlTupleMetadata, string id, CqlDateTime authoredOn)?>(c_, d_, e_);
        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?> g_ = context.Operators.Distinct<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?>(f_);
        IEnumerable<MedicationRequest> h_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? i_(MedicationRequest MR) {
            IEnumerable<Medication> au_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? av_(Medication M) {
                object ax_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object ay_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> az_ = context.Operators.Split((string)ay_, "/");
                string ba_ = context.Operators.Last<string>(az_);
                bool? bb_ = context.Operators.Equal(ax_, ba_);
                // CQL 'and': right operand skipped when left is false
                if (bb_ is false)
                {
                    return false;
                }
                else
                {
                    CodeableConcept bc_ = M?.Code;
                    CqlConcept bd_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bc_);
                    CqlValueSet be_ = this.Antithrombotic_Therapy_for_Ischemic_Stroke(context);
                    bool? bf_ = context.Operators.ConceptInValueSet(bd_, be_);
                    return bb_ & bf_;
                }
            }

            bool? aw_ = context.Operators.WhereAny<Medication>(au_, av_);
            return aw_;
        }

        IEnumerable<MedicationRequest> j_ = context.Operators.Where<MedicationRequest>(h_, i_);
        IEnumerable<MedicationRequest> k_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> l_ = context.Operators.Union<MedicationRequest>(j_, k_);

        bool? m_(MedicationRequest MedReqAntithrombotic) {
            IEnumerable<Task> bg_ = context.Operators.Retrieve<Task>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-taskrejected"));

            bool? bh_(Task TaskReject) {
                ResourceReference bj_ = TaskReject?.Focus;
                bool? bk_ = QICoreCommon_4_0_000.Instance.references(context, bj_, MedReqAntithrombotic);
                bool? bl_;
                // CQL 'and' (137:21-140:13): right operand skipped when left is false
                if (bk_ is false)
                {
                    bl_ = false;
                }
                else
                {
                    CodeableConcept bm_ = TaskReject?.StatusReason;
                    CqlConcept bn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bm_);
                    CqlValueSet bo_ = this.Medical_Reason_for_Not_Providing_Treatment(context);
                    bool? bp_ = context.Operators.ConceptInValueSet(bn_, bo_);
                    bool? bq_;
                    // CQL 'or' (138:17-140:13): right operand skipped when left is true
                    if (bp_ is true)
                    {
                        bq_ = true;
                    }
                    else
                    {
                        CodeableConcept br_ = TaskReject?.StatusReason;
                        CqlConcept bs_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, br_);
                        CqlValueSet bt_ = this.Patient_Refusal(context);
                        bool? bu_ = context.Operators.ConceptInValueSet(bs_, bt_);
                        bq_ = bp_ | bu_;
                    }
                    bl_ = bk_ & bq_;
                }
                // CQL 'and' (137:21-143:13): right operand skipped when left is false
                if (bl_ is false)
                {
                    return false;
                }
                else
                {
                    Code<MedicationRequest.MedicationrequestStatus> bv_ = MedReqAntithrombotic?.StatusElement;
                    MedicationRequest.MedicationrequestStatus? bw_ = bv_?.Value;
                    string bx_ = context.Operators.Convert<string>(bw_);
                    string[] by_ = [
                        "active",
                        "completed",
                    ];
                    bool? bz_ = context.Operators.In<string>(bx_, (IEnumerable<string>)by_);
                    bool? ca_;
                    // CQL 'and' (141:17-143:13): right operand skipped when left is false
                    if (bz_ is false)
                    {
                        ca_ = false;
                    }
                    else
                    {
                        CodeableConcept cb_ = TaskReject?.Code;
                        CqlConcept cc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cb_);
                        CqlCode cd_ = QICoreCommon_4_0_000.Instance.Fulfill(context);
                        CqlConcept ce_ = context.Operators.ConvertCodeToConcept(cd_);
                        bool? cf_ = context.Operators.Equivalent(cc_, ce_);
                        ca_ = bz_ & cf_;
                    }
                    return bl_ & ca_;
                }
            }

            bool? bi_ = context.Operators.WhereAny<Task>(bg_, bh_);
            return bi_;
        }


        (CqlTupleMetadata, string id, CqlDateTime authoredOn)? n_(MedicationRequest MedReqAntithrombotic) {
            Id cg_ = MedReqAntithrombotic?.IdElement;
            string ch_ = cg_?.Value;
            FhirDateTime ci_ = MedReqAntithrombotic?.AuthoredOnElement;
            CqlDateTime cj_ = context.Operators.Convert<CqlDateTime>(ci_);
            (CqlTupleMetadata, string id, CqlDateTime authoredOn)? ck_ = (CqlTupleMetadata_DeYYCcJRPXYVddOGVBSgSSNfR, ch_, cj_);
            return ck_;
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
                CqlConcept m_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return m_;
            }

            IEnumerable<CqlConcept> j_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)h_, i_);
            CqlValueSet k_ = this.Medical_Reason_for_Not_Providing_Treatment(context);
            bool? l_ = context.Operators.ConceptsInValueSet(j_, k_);
            // CQL 'or' (115:5-117:5): right operand skipped when left is true
            if (l_ is true)
            {
                return true;
            }
            else
            {
                List<CodeableConcept> n_ = MedicationAdm?.StatusReason;

                CqlConcept o_(CodeableConcept @this) {
                    CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                    return s_;
                }

                IEnumerable<CqlConcept> p_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)n_, o_);
                CqlValueSet q_ = this.Patient_Refusal(context);
                bool? r_ = context.Operators.ConceptsInValueSet(p_, q_);
                return l_ | r_;
            }
        }


        (CqlTupleMetadata, string id, FhirDateTime authoredOn)? e_(MedicationAdministration MedicationAdm) {
            Id t_ = MedicationAdm?.IdElement;
            string u_ = t_?.Value;

            bool? v_(Extension @this) {
                FhirUri ab_ = @this?.UrlElement;
                string ac_ = FHIRHelpers_4_4_000.Instance.ToString(context, ab_);
                bool? ad_ = context.Operators.Equal(ac_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");
                return ad_;
            }


            DataType w_(Extension @this) {
                DataType ae_ = @this?.Value;
                return ae_;
            }

            IEnumerable<DataType> x_ = context.Operators.WhereSelect<Extension, DataType>((IEnumerable<Extension>)(MedicationAdm is DomainResource
                ? (MedicationAdm as DomainResource).Extension
                : default), v_, w_);
            DataType y_ = context.Operators.SingletonFrom<DataType>(x_);
            FhirDateTime z_ = context.Operators.Convert<FhirDateTime>(y_);
            (CqlTupleMetadata, string id, FhirDateTime authoredOn)? aa_ = (CqlTupleMetadata_EOIGQCcgaQBFZACEUUODRVWXI, u_, z_);
            return aa_;
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
                bool? o_ = j_?.lowClosed;
                bool? p_ = j_?.highClosed;
                CqlInterval<CqlDateTime> q_ = context.Operators.Interval(l_, n_, o_, p_);
                bool? r_ = context.Operators.In<CqlDateTime>(g_, q_, "day");
                return r_;
            }

            bool? f_ = context.Operators.WhereAny<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?>(d_, e_);
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
                    bool? s_ = context.Operators.Equal(o_, r_);
                    // CQL 'and': right operand skipped when left is false
                    if (s_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        CodeableConcept t_ = M?.Code;
                        CqlConcept u_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, t_);
                        CqlValueSet v_ = this.Pharmacological_Contraindications_For_Antithrombotic_Therapy(context);
                        bool? w_ = context.Operators.ConceptInValueSet(u_, v_);
                        return s_ & w_;
                    }
                }

                bool? n_ = context.Operators.WhereAny<Medication>(l_, m_);
                return n_;
            }

            IEnumerable<MedicationAdministration> f_ = context.Operators.Where<MedicationAdministration>(d_, e_);
            CqlValueSet g_ = this.Pharmacological_Contraindications_For_Antithrombotic_Therapy(context);
            IEnumerable<MedicationAdministration> h_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
            IEnumerable<MedicationAdministration> i_ = context.Operators.Union<MedicationAdministration>(f_, h_);

            bool? j_(MedicationAdministration PharmacologicalContraindications) {
                Code<MedicationAdministration.MedicationAdministrationStatusCodes> x_ = PharmacologicalContraindications?.StatusElement;
                MedicationAdministration.MedicationAdministrationStatusCodes? y_ = x_?.Value;
                string z_ = context.Operators.Convert<string>(y_);
                string[] aa_ = [
                    "in-progress",
                    "completed",
                ];
                bool? ab_ = context.Operators.In<string>(z_, (IEnumerable<string>)aa_);
                // CQL 'and' (153:17-154:190): right operand skipped when left is false
                if (ab_ is false)
                {
                    return false;
                }
                else
                {
                    DataType ac_ = PharmacologicalContraindications?.Effective;
                    object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                    CqlInterval<CqlDateTime> ae_ = QICoreCommon_4_0_000.Instance.toInterval(context, ad_);
                    CqlDateTime af_ = context.Operators.Start(ae_);
                    CqlInterval<CqlDateTime> ag_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, IschemicStrokeEncounter);
                    CqlDateTime ah_ = context.Operators.Start(ag_);
                    CqlInterval<CqlDate> ai_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, ah_);
                    CqlDate aj_ = ai_?.low;
                    CqlDateTime ak_ = context.Operators.ConvertDateToDateTime(aj_);
                    CqlDate al_ = ai_?.high;
                    CqlDateTime am_ = context.Operators.ConvertDateToDateTime(al_);
                    bool? an_ = ai_?.lowClosed;
                    bool? ao_ = ai_?.highClosed;
                    CqlInterval<CqlDateTime> ap_ = context.Operators.Interval(ak_, am_, an_, ao_);
                    bool? aq_ = context.Operators.In<CqlDateTime>(af_, ap_, "day");
                    return ab_ & aq_;
                }
            }

            bool? k_ = context.Operators.WhereAny<MedicationAdministration>(i_, j_);
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
                bool? k_ = context.Operators.Greater(i_ as CqlQuantity, j_);
                bool? l_;
                // CQL 'and' (159:17-160:61): right operand skipped when left is false
                if (k_ is false)
                {
                    l_ = false;
                }
                else
                {
                    Code<ObservationStatus> m_ = INR?.StatusElement;
                    ObservationStatus? n_ = m_?.Value;
                    string o_ = context.Operators.Convert<string>(n_);
                    string[] p_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? q_ = context.Operators.In<string>(o_, (IEnumerable<string>)p_);
                    l_ = k_ & q_;
                }
                // CQL 'and' (159:17-161:136): right operand skipped when left is false
                if (l_ is false)
                {
                    return false;
                }
                else
                {
                    Instant r_ = INR?.IssuedElement;
                    DateTimeOffset? s_ = r_?.Value;
                    CqlDateTime t_ = context.Operators.Convert<CqlDateTime>(s_);
                    CqlInterval<CqlDateTime> u_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, IschemicStrokeEncounter);
                    CqlDateTime v_ = context.Operators.Start(u_);
                    CqlInterval<CqlDate> w_ = TJCOverall_8_25_000.Instance.calendarDayOfOrDayAfter(context, v_);
                    CqlDate x_ = w_?.low;
                    CqlDateTime y_ = context.Operators.ConvertDateToDateTime(x_);
                    CqlDate z_ = w_?.high;
                    CqlDateTime aa_ = context.Operators.ConvertDateToDateTime(z_);
                    bool? ab_ = w_?.lowClosed;
                    bool? ac_ = w_?.highClosed;
                    CqlInterval<CqlDateTime> ad_ = context.Operators.Interval(y_, aa_, ab_, ac_);
                    bool? ae_ = context.Operators.In<CqlDateTime>(t_, ad_, "day");
                    return l_ & ae_;
                }
            }

            bool? g_ = context.Operators.WhereAny<Observation>(e_, f_);
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
