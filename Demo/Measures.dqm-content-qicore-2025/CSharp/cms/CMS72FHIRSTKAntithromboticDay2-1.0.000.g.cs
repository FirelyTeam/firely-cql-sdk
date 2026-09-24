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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.2.4.0")]
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
                object y_ = ComfortMeasure is Procedure x_ ? x_.Performed : null;
                object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                bool aa_ = z_ is CqlDateTime;
                if (aa_)
                {
                    object ac_ = ComfortMeasure is Procedure ab_ ? ab_.Performed : null;
                    object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                    g_ = ad_ as CqlDateTime;
                }
                else
                {
                    object af_ = ComfortMeasure is Procedure ae_ ? ae_.Performed : null;
                    object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                    bool ah_ = ag_ is CqlQuantity;
                    if (ah_)
                    {
                        object aj_ = ComfortMeasure is Procedure ai_ ? ai_.Performed : null;
                        object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                        g_ = ak_ as CqlQuantity;
                    }
                    else
                    {
                        object am_ = ComfortMeasure is Procedure al_ ? al_.Performed : null;
                        object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                        bool ao_ = an_ is CqlInterval<CqlDateTime>;
                        if (ao_)
                        {
                            object aq_ = ComfortMeasure is Procedure ap_ ? ap_.Performed : null;
                            object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                            g_ = ar_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            object at_ = ComfortMeasure is Procedure as_ ? as_.Performed : null;
                            object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                            bool av_ = au_ is CqlInterval<CqlQuantity>;
                            if (av_)
                            {
                                object ax_ = ComfortMeasure is Procedure aw_ ? aw_.Performed : null;
                                object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                                g_ = ay_ as CqlInterval<CqlQuantity>;
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
                FhirDateTime k_ = ComfortMeasure is ServiceRequest j_ ? j_.AuthoredOnElement : null;
                CqlDateTime l_ = context.Operators.Convert<CqlDateTime>(k_);
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
                bool? w_ = context.Operators.In<CqlDateTime>(i_ ?? l_, v_, "day");
                return w_;
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
                Id u_ = M?.IdElement;
                string v_ = u_?.Value;
                DataType w_ = MR?.Medication;
                FhirString y_ = w_ is ResourceReference x_ ? x_.ReferenceElement : null;
                string z_ = y_?.Value;
                IEnumerable<string> aa_ = context.Operators.Split(z_, "/");
                string ab_ = context.Operators.Last<string>(aa_);
                bool? ac_ = context.Operators.Equal(v_, ab_);
                CodeableConcept ad_ = M?.Code;
                CqlConcept ae_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ad_);
                CqlValueSet af_ = this.Thrombolytic_tPA_Therapy(context);
                bool? ag_ = context.Operators.ConceptInValueSet(ae_, af_);
                bool? ah_ = context.Operators.And(ac_, ag_);
                return ah_;
            }

            bool? t_ = context.Operators.WhereAny<Medication>(r_, s_);
            return t_;
        }

        IEnumerable<MedicationAdministration> c_ = context.Operators.Where<MedicationAdministration>(a_, b_);
        CqlValueSet d_ = this.Thrombolytic_tPA_Therapy(context);
        IEnumerable<MedicationAdministration> e_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> f_ = context.Operators.Union<MedicationAdministration>(c_, e_);

        bool? g_(MedicationAdministration ThrombolyticMedication) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> ai_ = ThrombolyticMedication?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? aj_ = ai_?.Value;
            string ak_ = context.Operators.Convert<string>(aj_);
            string[] al_ = [
                "in-progress",
                "completed",
            ];
            bool? am_ = context.Operators.In<string>(ak_, (IEnumerable<string>)al_);
            return am_;
        }


        (CqlTupleMetadata, string id, object effective)? h_(MedicationAdministration ThrombolyticMedication) {
            Id an_ = ThrombolyticMedication?.IdElement;
            string ao_ = an_?.Value;
            DataType ap_ = ThrombolyticMedication?.Effective;
            object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
            (CqlTupleMetadata, string id, object effective)? ar_ = (CqlTupleMetadata_DbNFZJaRJHECUfPGBeWSUEUQi, ao_, aq_);
            return ar_;
        }

        IEnumerable<(CqlTupleMetadata, string id, object effective)?> i_ = context.Operators.WhereSelect<MedicationAdministration, (CqlTupleMetadata, string id, object effective)?>(f_, g_, h_);
        IEnumerable<(CqlTupleMetadata, string id, object effective)?> j_ = context.Operators.Distinct<(CqlTupleMetadata, string id, object effective)?>(i_);
        CqlValueSet k_ = this.Intravenous_or_Intraarterial_Thrombolytic_tPA_Therapy(context);
        IEnumerable<Procedure> l_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, k_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

        bool? m_(Procedure ThrombolyticProcedure) {
            Code<EventStatus> as_ = ThrombolyticProcedure?.StatusElement;
            EventStatus? at_ = as_?.Value;
            string au_ = context.Operators.Convert<string>(at_);
            bool? av_ = context.Operators.Equal(au_, "completed");
            return av_;
        }


        (CqlTupleMetadata, string id, object effective)? n_(Procedure ThrombolyticProcedure) {
            Id aw_ = ThrombolyticProcedure?.IdElement;
            string ax_ = aw_?.Value;
            DataType ay_ = ThrombolyticProcedure?.Performed;
            object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
            (CqlTupleMetadata, string id, object effective)? ba_ = (CqlTupleMetadata_DbNFZJaRJHECUfPGBeWSUEUQi, ax_, az_);
            return ba_;
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
                CodeableConcept o_ = PriorTPA?.VerificationStatus;
                CqlConcept p_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, o_);
                bool? q_ = context.Operators.Not((bool?)(p_ is null));
                bool? r_ = context.Operators.And(n_, q_);
                CqlCode s_ = QICoreCommon_4_0_000.Instance.refuted(context);
                CqlConcept t_ = context.Operators.ConvertCodeToConcept(s_);
                bool? u_ = context.Operators.Equivalent(p_, t_);
                bool? v_ = context.Operators.Not(u_);
                CqlCode w_ = QICoreCommon_4_0_000.Instance.entered_in_error(context);
                CqlConcept x_ = context.Operators.ConvertCodeToConcept(w_);
                bool? y_ = context.Operators.Equivalent(p_, x_);
                bool? z_ = context.Operators.Not(y_);
                bool? aa_ = context.Operators.And(v_, z_);
                bool? ab_ = context.Operators.Implies(r_, aa_);
                return ab_;
            }

            bool? j_ = context.Operators.WhereAny<Condition>(h_, i_);
            return j_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

        bool? d_(Encounter IschemicStrokeEncounter) {
            IEnumerable<Condition> ac_ = CQMCommon_4_1_000.Instance.encounterDiagnosis(context, IschemicStrokeEncounter);

            bool? ad_(Condition EncounterDiagnosis) {
                CodeableConcept af_ = EncounterDiagnosis?.Code;
                CqlConcept ag_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, af_);
                CqlValueSet ah_ = this.Intravenous_or_Intraarterial_Thrombolytic_tPA_Therapy_Prior_to_Arrival(context);
                bool? ai_ = context.Operators.ConceptInValueSet(ag_, ah_);
                return ai_;
            }

            bool? ae_ = context.Operators.WhereAny<Condition>(ac_, ad_);
            return ae_;
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
                    Id o_ = M?.IdElement;
                    string p_ = o_?.Value;
                    DataType q_ = MR?.Medication;
                    FhirString s_ = q_ is ResourceReference r_ ? r_.ReferenceElement : null;
                    string t_ = s_?.Value;
                    IEnumerable<string> u_ = context.Operators.Split(t_, "/");
                    string v_ = context.Operators.Last<string>(u_);
                    bool? w_ = context.Operators.Equal(p_, v_);
                    CodeableConcept x_ = M?.Code;
                    CqlConcept y_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, x_);
                    CqlValueSet z_ = this.Antithrombotic_Therapy_for_Ischemic_Stroke(context);
                    bool? aa_ = context.Operators.ConceptInValueSet(y_, z_);
                    bool? ab_ = context.Operators.And(w_, aa_);
                    return ab_;
                }

                bool? n_ = context.Operators.WhereAny<Medication>(l_, m_);
                return n_;
            }

            IEnumerable<MedicationAdministration> f_ = context.Operators.Where<MedicationAdministration>(d_, e_);
            CqlValueSet g_ = this.Antithrombotic_Therapy_for_Ischemic_Stroke(context);
            IEnumerable<MedicationAdministration> h_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
            IEnumerable<MedicationAdministration> i_ = context.Operators.Union<MedicationAdministration>(f_, h_);

            bool? j_(MedicationAdministration Antithrombotic) {
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
                CqlDate aq_ = an_?.high;
                CqlDateTime ar_ = context.Operators.ConvertDateToDateTime(aq_);
                bool? as_ = an_?.lowClosed;
                bool? at_ = an_?.highClosed;
                CqlInterval<CqlDateTime> au_ = context.Operators.Interval(ap_, ar_, as_, at_);
                bool? av_ = context.Operators.In<CqlDateTime>(ak_, au_, "day");
                bool? aw_ = context.Operators.And(ag_, av_);
                return aw_;
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
                CqlConcept an_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return an_;
            }

            IEnumerable<CqlConcept> t_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)r_, s_);
            CqlValueSet u_ = this.Medical_Reason_for_Not_Providing_Treatment(context);
            bool? v_ = context.Operators.ConceptsInValueSet(t_, u_);

            CqlConcept w_(CodeableConcept @this) {
                CqlConcept ao_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return ao_;
            }

            IEnumerable<CqlConcept> x_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)r_, w_);
            CqlValueSet y_ = this.Patient_Refusal(context);
            bool? z_ = context.Operators.ConceptsInValueSet(x_, y_);
            bool? aa_ = context.Operators.Or(v_, z_);
            Code<MedicationRequest.MedicationrequestStatus> ab_ = NoAntithromboticOrder?.StatusElement;
            MedicationRequest.MedicationrequestStatus? ac_ = ab_?.Value;
            string ad_ = context.Operators.Convert<string>(ac_);
            string[] ae_ = [
                "active",
                "completed",
            ];
            bool? af_ = context.Operators.In<string>(ad_, (IEnumerable<string>)ae_);
            bool? ag_ = context.Operators.And(aa_, af_);
            Code<MedicationRequest.MedicationRequestIntent> ah_ = NoAntithromboticOrder?.IntentElement;
            MedicationRequest.MedicationRequestIntent? ai_ = ah_?.Value;
            string aj_ = context.Operators.Convert<string>(ai_);
            string[] ak_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? al_ = context.Operators.In<string>(aj_, (IEnumerable<string>)ak_);
            bool? am_ = context.Operators.And(ag_, al_);
            return am_;
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
                Id ax_ = M?.IdElement;
                string ay_ = ax_?.Value;
                DataType az_ = MR?.Medication;
                FhirString bb_ = az_ is ResourceReference ba_ ? ba_.ReferenceElement : null;
                string bc_ = bb_?.Value;
                IEnumerable<string> bd_ = context.Operators.Split(bc_, "/");
                string be_ = context.Operators.Last<string>(bd_);
                bool? bf_ = context.Operators.Equal(ay_, be_);
                CodeableConcept bg_ = M?.Code;
                CqlConcept bh_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bg_);
                CqlValueSet bi_ = this.Antithrombotic_Therapy_for_Ischemic_Stroke(context);
                bool? bj_ = context.Operators.ConceptInValueSet(bh_, bi_);
                bool? bk_ = context.Operators.And(bf_, bj_);
                return bk_;
            }

            bool? aw_ = context.Operators.WhereAny<Medication>(au_, av_);
            return aw_;
        }

        IEnumerable<MedicationRequest> j_ = context.Operators.Where<MedicationRequest>(h_, i_);
        IEnumerable<MedicationRequest> k_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> l_ = context.Operators.Union<MedicationRequest>(j_, k_);

        bool? m_(MedicationRequest MedReqAntithrombotic) {
            IEnumerable<Task> bl_ = context.Operators.Retrieve<Task>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-taskrejected"));

            bool? bm_(Task TaskReject) {
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

            bool? bn_ = context.Operators.WhereAny<Task>(bl_, bm_);
            return bn_;
        }


        (CqlTupleMetadata, string id, CqlDateTime authoredOn)? n_(MedicationRequest MedReqAntithrombotic) {
            Id ck_ = MedReqAntithrombotic?.IdElement;
            string cl_ = ck_?.Value;
            FhirDateTime cm_ = MedReqAntithrombotic?.AuthoredOnElement;
            CqlDateTime cn_ = context.Operators.Convert<CqlDateTime>(cm_);
            (CqlTupleMetadata, string id, CqlDateTime authoredOn)? co_ = (CqlTupleMetadata_DeYYCcJRPXYVddOGVBSgSSNfR, cl_, cn_);
            return co_;
        }

        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?> o_ = context.Operators.WhereSelect<MedicationRequest, (CqlTupleMetadata, string id, CqlDateTime authoredOn)?>(l_, m_, n_);
        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?> p_ = context.Operators.Distinct<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?>(o_);
        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?> q_ = context.Operators.Union<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?>(g_, p_);
        return q_;
    }


    [CqlExpressionDefinition("Reason For Not Administering Antithrombotic")]
    public IEnumerable<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?> Reason_For_Not_Administering_Antithrombotic(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Reason_For_Not_Administering_Antithrombotic, Reason_For_Not_Administering_Antithrombotic_Compute);

    private const long _cacheIndex_Reason_For_Not_Administering_Antithrombotic = 4621061554767489361L;

    private IEnumerable<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?> Reason_For_Not_Administering_Antithrombotic_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Antithrombotic_Therapy_for_Ischemic_Stroke(context);
        IEnumerable<MedicationAdministration> b_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministrationnotdone"));
        IEnumerable<MedicationAdministration> c_ = context.Operators.Union<MedicationAdministration>(b_, b_);

        bool? d_(MedicationAdministration MedicationAdm) {
            List<CodeableConcept> h_ = MedicationAdm?.StatusReason;

            CqlConcept i_(CodeableConcept @this) {
                CqlConcept r_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return r_;
            }

            IEnumerable<CqlConcept> j_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)h_, i_);
            CqlValueSet k_ = this.Medical_Reason_for_Not_Providing_Treatment(context);
            bool? l_ = context.Operators.ConceptsInValueSet(j_, k_);

            CqlConcept m_(CodeableConcept @this) {
                CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return s_;
            }

            IEnumerable<CqlConcept> n_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)h_, m_);
            CqlValueSet o_ = this.Patient_Refusal(context);
            bool? p_ = context.Operators.ConceptsInValueSet(n_, o_);
            bool? q_ = context.Operators.Or(l_, p_);
            return q_;
        }


        (CqlTupleMetadata, string id, CqlDateTime authoredOn)? e_(MedicationAdministration MedicationAdm) {
            Id t_ = MedicationAdm?.IdElement;
            string u_ = t_?.Value;
            List<Extension> v_ = MedicationAdm?.Extension;

            bool? w_(Extension @this) {
                FhirUri ab_ = @this?.UrlElement;
                string ac_ = FHIRHelpers_4_4_000.Instance.ToString(context, ab_);
                bool? ad_ = context.Operators.Equal(ac_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");
                return ad_;
            }


            object x_(Extension @this) {
                DataType ae_ = @this?.Value;
                return ae_ switch
                {
                    Instant af_ => context.Operators.Convert<CqlDateTime>(af_.Value),
                    FhirDecimal ag_ => ag_.Value,
                    Date ah_ => context.Operators.ConvertStringToDate(ah_.Value),
                    FhirDateTime ai_ => context.Operators.Convert<CqlDateTime>(ai_),
                    Time aj_ => context.Operators.ConvertStringToTime(aj_.Value),
                    Base64Binary ak_ => context.Operators.Convert<string>(ak_.Value),
                    FhirBoolean al_ => al_.Value,
                    IValue<int?> am_ => am_.Value,
                    IValue<string> an_ => an_.Value,
                    Quantity ao_ => ao_.ValueElement,
                    Identifier ap_ => ap_.ValueElement,
                    Money aq_ => aq_.ValueElement,
                    UsageContext ar_ => ar_.Value,
                    ContactPoint as_ => as_.ValueElement,
                    _ => null,
                };
            }

            IEnumerable<object> y_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)v_, w_, x_);
            object z_ = context.Operators.SingletonFrom<object>(y_);
            (CqlTupleMetadata, string id, CqlDateTime authoredOn)? aa_ = (CqlTupleMetadata_DeYYCcJRPXYVddOGVBSgSSNfR, u_, (CqlDateTime)z_);
            return aa_;
        }

        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?> f_ = context.Operators.WhereSelect<MedicationAdministration, (CqlTupleMetadata, string id, CqlDateTime authoredOn)?>(c_, d_, e_);
        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?> g_ = context.Operators.Distinct<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?>(f_);
        return g_;
    }


    [CqlExpressionDefinition("Documented Reason For No Antithrombotic Ordered Or Administered")]
    public IEnumerable<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?> Documented_Reason_For_No_Antithrombotic_Ordered_Or_Administered(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Documented_Reason_For_No_Antithrombotic_Ordered_Or_Administered, Documented_Reason_For_No_Antithrombotic_Ordered_Or_Administered_Compute);

    private const long _cacheIndex_Documented_Reason_For_No_Antithrombotic_Ordered_Or_Administered = 3645062562921740862L;

    private IEnumerable<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?> Documented_Reason_For_No_Antithrombotic_Ordered_Or_Administered_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?> a_ = this.Reason_For_Not_Ordering_Antithrombotic(context);
        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?> b_ = this.Reason_For_Not_Administering_Antithrombotic(context);
        IEnumerable<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?> c_ = context.Operators.Union<(CqlTupleMetadata, string id, CqlDateTime authoredOn)?>(a_, b_);
        return c_;
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
                    Id o_ = M?.IdElement;
                    string p_ = o_?.Value;
                    DataType q_ = MR?.Medication;
                    FhirString s_ = q_ is ResourceReference r_ ? r_.ReferenceElement : null;
                    string t_ = s_?.Value;
                    IEnumerable<string> u_ = context.Operators.Split(t_, "/");
                    string v_ = context.Operators.Last<string>(u_);
                    bool? w_ = context.Operators.Equal(p_, v_);
                    CodeableConcept x_ = M?.Code;
                    CqlConcept y_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, x_);
                    CqlValueSet z_ = this.Pharmacological_Contraindications_For_Antithrombotic_Therapy(context);
                    bool? aa_ = context.Operators.ConceptInValueSet(y_, z_);
                    bool? ab_ = context.Operators.And(w_, aa_);
                    return ab_;
                }

                bool? n_ = context.Operators.WhereAny<Medication>(l_, m_);
                return n_;
            }

            IEnumerable<MedicationAdministration> f_ = context.Operators.Where<MedicationAdministration>(d_, e_);
            CqlValueSet g_ = this.Pharmacological_Contraindications_For_Antithrombotic_Therapy(context);
            IEnumerable<MedicationAdministration> h_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
            IEnumerable<MedicationAdministration> i_ = context.Operators.Union<MedicationAdministration>(f_, h_);

            bool? j_(MedicationAdministration PharmacologicalContraindications) {
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
                CqlDate aq_ = an_?.high;
                CqlDateTime ar_ = context.Operators.ConvertDateToDateTime(aq_);
                bool? as_ = an_?.lowClosed;
                bool? at_ = an_?.highClosed;
                CqlInterval<CqlDateTime> au_ = context.Operators.Interval(ap_, ar_, as_, at_);
                bool? av_ = context.Operators.In<CqlDateTime>(ak_, au_, "day");
                bool? aw_ = context.Operators.And(ag_, av_);
                return aw_;
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
                Code<ObservationStatus> l_ = INR?.StatusElement;
                ObservationStatus? m_ = l_?.Value;
                string n_ = context.Operators.Convert<string>(m_);
                string[] o_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? p_ = context.Operators.In<string>(n_, (IEnumerable<string>)o_);
                bool? q_ = context.Operators.And(k_, p_);
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
                bool? af_ = context.Operators.And(q_, ae_);
                return af_;
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

    #endregion CqlTupleMetadata Properties

}
