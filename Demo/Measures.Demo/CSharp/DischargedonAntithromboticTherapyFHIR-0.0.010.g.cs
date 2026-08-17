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
[CqlLibrary("DischargedonAntithromboticTherapyFHIR", "0.0.010")]
public partial class DischargedonAntithromboticTherapyFHIR_0_0_010 : ILibrary, ISingleton<DischargedonAntithromboticTherapyFHIR_0_0_010>
{
    #region ValueSets (14)

    [CqlValueSetDefinition("Antithrombotic Therapy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.201", valueSetVersion: null)]
    public CqlValueSet Antithrombotic_Therapy(CqlContext _) => _Antithrombotic_Therapy;
    private static readonly CqlValueSet _Antithrombotic_Therapy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.201", null);

    [CqlValueSetDefinition("Comfort Measures", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/1.3.6.1.4.1.33895.1.3.0.45", valueSetVersion: null)]
    public CqlValueSet Comfort_Measures(CqlContext _) => _Comfort_Measures;
    private static readonly CqlValueSet _Comfort_Measures = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/1.3.6.1.4.1.33895.1.3.0.45", null);

    [CqlValueSetDefinition("Discharge To Acute Care Facility", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87", valueSetVersion: null)]
    public CqlValueSet Discharge_To_Acute_Care_Facility(CqlContext _) => _Discharge_To_Acute_Care_Facility;
    private static readonly CqlValueSet _Discharge_To_Acute_Care_Facility = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87", null);

    [CqlValueSetDefinition("Discharged to Health Care Facility for Hospice Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207", valueSetVersion: null)]
    public CqlValueSet Discharged_to_Health_Care_Facility_for_Hospice_Care(CqlContext _) => _Discharged_to_Health_Care_Facility_for_Hospice_Care;
    private static readonly CqlValueSet _Discharged_to_Health_Care_Facility_for_Hospice_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207", null);

    [CqlValueSetDefinition("Discharged to Home for Hospice Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209", valueSetVersion: null)]
    public CqlValueSet Discharged_to_Home_for_Hospice_Care(CqlContext _) => _Discharged_to_Home_for_Hospice_Care;
    private static readonly CqlValueSet _Discharged_to_Home_for_Hospice_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209", null);

    [CqlValueSetDefinition("Emergency Department Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", valueSetVersion: null)]
    public CqlValueSet Emergency_Department_Visit(CqlContext _) => _Emergency_Department_Visit;
    private static readonly CqlValueSet _Emergency_Department_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", null);

    [CqlValueSetDefinition("Hemorrhagic Stroke", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.212", valueSetVersion: null)]
    public CqlValueSet Hemorrhagic_Stroke(CqlContext _) => _Hemorrhagic_Stroke;
    private static readonly CqlValueSet _Hemorrhagic_Stroke = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.212", null);

    [CqlValueSetDefinition("Ischemic Stroke", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.247", valueSetVersion: null)]
    public CqlValueSet Ischemic_Stroke(CqlContext _) => _Ischemic_Stroke;
    private static readonly CqlValueSet _Ischemic_Stroke = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.247", null);

    [CqlValueSetDefinition("Left Against Medical Advice", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.308", valueSetVersion: null)]
    public CqlValueSet Left_Against_Medical_Advice(CqlContext _) => _Left_Against_Medical_Advice;
    private static readonly CqlValueSet _Left_Against_Medical_Advice = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.308", null);

    [CqlValueSetDefinition("Medical Reason", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.473", valueSetVersion: null)]
    public CqlValueSet Medical_Reason(CqlContext _) => _Medical_Reason;
    private static readonly CqlValueSet _Medical_Reason = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.473", null);

    [CqlValueSetDefinition("Non-Elective Inpatient Encounter", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.424", valueSetVersion: null)]
    public CqlValueSet Non_Elective_Inpatient_Encounter(CqlContext _) => _Non_Elective_Inpatient_Encounter;
    private static readonly CqlValueSet _Non_Elective_Inpatient_Encounter = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.424", null);

    [CqlValueSetDefinition("Patient Expired", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309", valueSetVersion: null)]
    public CqlValueSet Patient_Expired(CqlContext _) => _Patient_Expired;
    private static readonly CqlValueSet _Patient_Expired = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309", null);

    [CqlValueSetDefinition("Patient Refusal", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.93", valueSetVersion: null)]
    public CqlValueSet Patient_Refusal(CqlContext _) => _Patient_Refusal;
    private static readonly CqlValueSet _Patient_Refusal = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.93", null);

    [CqlValueSetDefinition("Pharmacological Contraindications For Antithrombotic Therapy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.52", valueSetVersion: null)]
    public CqlValueSet Pharmacological_Contraindications_For_Antithrombotic_Therapy(CqlContext _) => _Pharmacological_Contraindications_For_Antithrombotic_Therapy;
    private static readonly CqlValueSet _Pharmacological_Contraindications_For_Antithrombotic_Therapy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.52", null);

    #endregion ValueSets

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = -1910573221940503362L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        object a_ = context.ResolveParameter("DischargedonAntithromboticTherapyFHIR-0.0.010", "Measurement Period", (object)null);
        return (CqlInterval<CqlDateTime>)a_;
    }


    #endregion Parameters

    #region Functions and Expressions (15)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = -4089929577116492787L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = -6108063201567256093L;

    private IEnumerable<Encounter> Denominator_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = TJCOverallFHIR_1_8_000.Instance.Ischemic_Stroke_Encounter(context);
        return a_;
    }


    [CqlExpressionDefinition("Antithrombotic Not Given at Discharge")]
    public IEnumerable<MedicationRequest> Antithrombotic_Not_Given_at_Discharge(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Antithrombotic_Not_Given_at_Discharge, Antithrombotic_Not_Given_at_Discharge_Compute);

    private const long _cacheIndex_Antithrombotic_Not_Given_at_Discharge = -7841829350546192526L;

    private IEnumerable<MedicationRequest> Antithrombotic_Not_Given_at_Discharge_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Antithrombotic_Therapy(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));

        bool? c_(MedicationRequest NoAntithromboticDischarge) {
            FhirBoolean e_ = NoAntithromboticDischarge?.DoNotPerformElement;
            bool? f_ = FHIRHelpers_4_0_001.Instance.ToBoolean(context, e_);

            CqlBoolean g_() {
                List<CodeableConcept> k_ = NoAntithromboticDischarge?.ReasonCode;

                CqlConcept l_(CodeableConcept X) {
                    CqlConcept q_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);
                    return q_;
                }

                IEnumerable<CqlConcept> m_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)k_, l_);
                CqlValueSet n_ = this.Medical_Reason(context);
                bool? o_ = context.Operators.ConceptsInValueSet(m_, n_);

                CqlBoolean p_() {
                    List<CodeableConcept> r_ = NoAntithromboticDischarge?.ReasonCode;

                    CqlConcept s_(CodeableConcept X) {
                        CqlConcept w_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, X);
                        return w_;
                    }

                    IEnumerable<CqlConcept> t_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)r_, s_);
                    CqlValueSet u_ = this.Patient_Refusal(context);
                    bool? v_ = context.Operators.ConceptsInValueSet(t_, u_);
                    return v_;
                }

                return /* CQL 'or' (83:11-85:7) */ ((CqlBoolean)o_
                    || p_());
            }


            CqlBoolean h_() {
                List<CodeableConcept> x_ = NoAntithromboticDischarge?.Category;

                bool? y_(CodeableConcept C) {
                    CqlConcept aa_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, C);
                    CqlCode ab_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Community(context);
                    CqlConcept ac_ = context.Operators.ConvertCodeToConcept(ab_);
                    bool? ad_ = context.Operators.Equivalent(aa_, ac_);

                    CqlBoolean ae_() {
                        CqlConcept af_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, C);
                        CqlCode ag_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Discharge(context);
                        CqlConcept ah_ = context.Operators.ConvertCodeToConcept(ag_);
                        bool? ai_ = context.Operators.Equivalent(af_, ah_);
                        return ai_;
                    }

                    return (bool?)(/* CQL 'or' (87:11-88:63) */ ((CqlBoolean)ad_
                        || ae_()));
                }

                bool? z_ = context.Operators.WhereAny<CodeableConcept>((IEnumerable<CodeableConcept>)x_, y_);
                return z_;
            }


            CqlBoolean i_() {
                Code<MedicationRequest.MedicationrequestStatus> aj_ = NoAntithromboticDischarge?.StatusElement;
                string ak_ = FHIRHelpers_4_0_001.Instance.ToString(context, aj_);
                string[] al_ = [
                    "completed",
                    "cancelled",
                ];
                bool? am_ = context.Operators.In<string>(ak_, (IEnumerable<string>)al_);
                return am_;
            }


            CqlBoolean j_() {
                Code<MedicationRequest.MedicationRequestIntent> an_ = NoAntithromboticDischarge?.IntentElement;
                string ao_ = FHIRHelpers_4_0_001.Instance.ToString(context, an_);
                bool? ap_ = context.Operators.Equal(ao_, "order");
                return ap_;
            }

            return (bool?)(/* CQL 'and' (82:5-91:52) */ (/* CQL 'and' (82:11-90:74) */ (/* CQL 'and' (82:11-89:7) */ (/* CQL 'and' (82:11-85:7) */ ((CqlBoolean)((bool?)(/* CQL 'is true' (82:11-82:56) */ f_ is true))
                && g_())
                && h_())
                && i_())
                && j_()));
        }

        IEnumerable<MedicationRequest> d_ = context.Operators.Where<MedicationRequest>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Encounter With No Antithrombotic At Discharge")]
    public IEnumerable<Encounter> Encounter_With_No_Antithrombotic_At_Discharge(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_No_Antithrombotic_At_Discharge, Encounter_With_No_Antithrombotic_At_Discharge_Compute);

    private const long _cacheIndex_Encounter_With_No_Antithrombotic_At_Discharge = 3872100787539645286L;

    private IEnumerable<Encounter> Encounter_With_No_Antithrombotic_At_Discharge_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = TJCOverallFHIR_1_8_000.Instance.Ischemic_Stroke_Encounter(context);

        bool? b_(Encounter IschemicStrokeEncounter) {
            IEnumerable<MedicationRequest> d_ = this.Antithrombotic_Not_Given_at_Discharge(context);

            bool? e_(MedicationRequest NoDischargeAntithrombotic) {
                FhirDateTime g_ = NoDischargeAntithrombotic?.AuthoredOnElement;
                CqlDateTime h_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, g_);
                Period i_ = IschemicStrokeEncounter?.Period;
                CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, i_);
                bool? k_ = context.Operators.In<CqlDateTime>(h_, j_, (string)default);
                return k_;
            }

            bool? f_ = context.Operators.WhereAny<MedicationRequest>(d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Pharmacological Contraindications for Antithrombotic Therapy at Discharge")]
    public IEnumerable<MedicationRequest> Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge, Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge_Compute);

    private const long _cacheIndex_Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge = -1129270284953313235L;

    private IEnumerable<MedicationRequest> Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Pharmacological_Contraindications_For_Antithrombotic_Therapy(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));

        bool? c_(MedicationRequest Pharmacological) {
            FhirBoolean e_ = Pharmacological?.DoNotPerformElement;
            bool? f_ = FHIRHelpers_4_0_001.Instance.ToBoolean(context, e_);

            CqlBoolean g_() {
                List<CodeableConcept> j_ = Pharmacological?.Category;

                bool? k_(CodeableConcept C) {
                    CqlConcept m_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, C);
                    CqlCode n_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Community(context);
                    CqlConcept o_ = context.Operators.ConvertCodeToConcept(n_);
                    bool? p_ = context.Operators.Equivalent(m_, o_);

                    CqlBoolean q_() {
                        CqlConcept r_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, C);
                        CqlCode s_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Discharge(context);
                        CqlConcept t_ = context.Operators.ConvertCodeToConcept(s_);
                        bool? u_ = context.Operators.Equivalent(r_, t_);
                        return u_;
                    }

                    return (bool?)(/* CQL 'or' (97:11-98:63) */ ((CqlBoolean)p_
                        || q_()));
                }

                bool? l_ = context.Operators.WhereAny<CodeableConcept>((IEnumerable<CodeableConcept>)j_, k_);
                return l_;
            }


            CqlBoolean h_() {
                Code<MedicationRequest.MedicationrequestStatus> v_ = Pharmacological?.StatusElement;
                string w_ = FHIRHelpers_4_0_001.Instance.ToString(context, v_);
                string[] x_ = [
                    "active",
                    "completed",
                ];
                bool? y_ = context.Operators.In<string>(w_, (IEnumerable<string>)x_);
                return y_;
            }


            CqlBoolean i_() {
                Code<MedicationRequest.MedicationRequestIntent> z_ = Pharmacological?.IntentElement;
                string aa_ = FHIRHelpers_4_0_001.Instance.ToString(context, z_);
                bool? ab_ = context.Operators.Equal(aa_, "order");
                return ab_;
            }

            return (bool?)(/* CQL 'and' (95:5-101:42) */ (/* CQL 'and' (95:11-100:61) */ (/* CQL 'and' (95:11-99:7) */ ((CqlBoolean)(!((bool?)(/* CQL 'is true' (95:11-95:50) */ f_ is true)))
                && g_())
                && h_())
                && i_()));
        }

        IEnumerable<MedicationRequest> d_ = context.Operators.Where<MedicationRequest>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Encounter With Pharmacological Contraindications for Antithrombotic Therapy at Discharge")]
    public IEnumerable<Encounter> Encounter_With_Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge, Encounter_With_Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge_Compute);

    private const long _cacheIndex_Encounter_With_Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge = -1426572148313240824L;

    private IEnumerable<Encounter> Encounter_With_Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = TJCOverallFHIR_1_8_000.Instance.Ischemic_Stroke_Encounter(context);

        bool? b_(Encounter IschemicStrokeEncounter) {
            IEnumerable<MedicationRequest> d_ = this.Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge(context);

            bool? e_(MedicationRequest DischargePharmacological) {
                FhirDateTime g_ = DischargePharmacological?.AuthoredOnElement;
                CqlDateTime h_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, g_);
                Period i_ = IschemicStrokeEncounter?.Period;
                CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, i_);
                bool? k_ = context.Operators.In<CqlDateTime>(h_, j_, (string)default);
                return k_;
            }

            bool? f_ = context.Operators.WhereAny<MedicationRequest>(d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Denominator Exceptions")]
    public IEnumerable<Encounter> Denominator_Exceptions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exceptions, Denominator_Exceptions_Compute);

    private const long _cacheIndex_Denominator_Exceptions = 6673240317773714005L;

    private IEnumerable<Encounter> Denominator_Exceptions_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_No_Antithrombotic_At_Discharge(context);
        IEnumerable<Encounter> b_ = this.Encounter_With_Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exclusions, Denominator_Exclusions_Compute);

    private const long _cacheIndex_Denominator_Exclusions = 8298600534596146791L;

    private IEnumerable<Encounter> Denominator_Exclusions_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = TJCOverallFHIR_1_8_000.Instance.Ischemic_Stroke_Encounters_with_Discharge_Disposition(context);
        IEnumerable<Encounter> b_ = TJCOverallFHIR_1_8_000.Instance.Encounter_with_Comfort_Measures_during_Hospitalization(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = -1154461465892404559L;

    private IEnumerable<Encounter> Initial_Population_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = TJCOverallFHIR_1_8_000.Instance.Encounter_with_Principal_Diagnosis_and_Age(context);
        return a_;
    }


    [CqlExpressionDefinition("Antithrombotic Therapy at Discharge")]
    public IEnumerable<MedicationRequest> Antithrombotic_Therapy_at_Discharge(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Antithrombotic_Therapy_at_Discharge, Antithrombotic_Therapy_at_Discharge_Compute);

    private const long _cacheIndex_Antithrombotic_Therapy_at_Discharge = -8311745687764367551L;

    private IEnumerable<MedicationRequest> Antithrombotic_Therapy_at_Discharge_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Antithrombotic_Therapy(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));

        bool? c_(MedicationRequest Antithrombotic) {
            FhirBoolean e_ = Antithrombotic?.DoNotPerformElement;
            bool? f_ = FHIRHelpers_4_0_001.Instance.ToBoolean(context, e_);

            CqlBoolean g_() {
                List<CodeableConcept> j_ = Antithrombotic?.Category;

                bool? k_(CodeableConcept C) {
                    CqlConcept m_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, C);
                    CqlCode n_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Community(context);
                    CqlConcept o_ = context.Operators.ConvertCodeToConcept(n_);
                    bool? p_ = context.Operators.Equivalent(m_, o_);

                    CqlBoolean q_() {
                        CqlConcept r_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, C);
                        CqlCode s_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Discharge(context);
                        CqlConcept t_ = context.Operators.ConvertCodeToConcept(s_);
                        bool? u_ = context.Operators.Equivalent(r_, t_);
                        return u_;
                    }

                    return (bool?)(/* CQL 'or' (74:11-75:63) */ ((CqlBoolean)p_
                        || q_()));
                }

                bool? l_ = context.Operators.WhereAny<CodeableConcept>((IEnumerable<CodeableConcept>)j_, k_);
                return l_;
            }


            CqlBoolean h_() {
                Code<MedicationRequest.MedicationrequestStatus> v_ = Antithrombotic?.StatusElement;
                string w_ = FHIRHelpers_4_0_001.Instance.ToString(context, v_);
                string[] x_ = [
                    "active",
                    "completed",
                ];
                bool? y_ = context.Operators.In<string>(w_, (IEnumerable<string>)x_);
                return y_;
            }


            CqlBoolean i_() {
                Code<MedicationRequest.MedicationRequestIntent> z_ = Antithrombotic?.IntentElement;
                string aa_ = FHIRHelpers_4_0_001.Instance.ToString(context, z_);
                bool? ab_ = context.Operators.Equal(aa_, "order");
                return ab_;
            }

            return (bool?)(/* CQL 'and' (72:5-78:41) */ (/* CQL 'and' (72:11-77:60) */ (/* CQL 'and' (72:11-76:7) */ ((CqlBoolean)(!((bool?)(/* CQL 'is true' (72:11-72:49) */ f_ is true)))
                && g_())
                && h_())
                && i_()));
        }

        IEnumerable<MedicationRequest> d_ = context.Operators.Where<MedicationRequest>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = 899507397485408094L;

    private IEnumerable<Encounter> Numerator_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = TJCOverallFHIR_1_8_000.Instance.Ischemic_Stroke_Encounter(context);

        bool? b_(Encounter IschemicStrokeEncounter) {
            IEnumerable<MedicationRequest> d_ = this.Antithrombotic_Therapy_at_Discharge(context);

            bool? e_(MedicationRequest DischargeAntithrombotic) {
                FhirDateTime g_ = DischargeAntithrombotic?.AuthoredOnElement;
                CqlDateTime h_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, g_);
                Period i_ = IschemicStrokeEncounter?.Period;
                CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, i_);
                bool? k_ = context.Operators.In<CqlDateTime>(h_, j_, (string)default);
                return k_;
            }

            bool? f_ = context.Operators.WhereAny<MedicationRequest>(d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = 2387045540434942064L;

    private IEnumerable<Coding> SDE_Ethnicity_Compute(CqlContext context)
    {
        IEnumerable<Coding> a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = -8335395049973550212L;

    private IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = -8392710765314873892L;

    private IEnumerable<Coding> SDE_Race_Compute(CqlContext context)
    {
        IEnumerable<Coding> a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = 418011448807512549L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);
        return a_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private DischargedonAntithromboticTherapyFHIR_0_0_010() {}

    public static DischargedonAntithromboticTherapyFHIR_0_0_010 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "DischargedonAntithromboticTherapyFHIR";
    public string Version => "0.0.010";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_001.Instance, SupplementalDataElementsFHIR4_2_0_000.Instance, MATGlobalCommonFunctionsFHIR4_6_1_000.Instance, TJCOverallFHIR_1_8_000.Instance];

    #endregion ILibrary Implementation

}
