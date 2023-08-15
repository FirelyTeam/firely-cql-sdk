using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "0.0.1.0")]
[CqlLibrary("DischargedonAntithromboticTherapyFHIR", "0.0.010")]
public class DischargedonAntithromboticTherapyFHIR_0_0_010
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Antithrombotic_Therapy;
    internal Lazy<CqlValueSet> __Comfort_Measures;
    internal Lazy<CqlValueSet> __Discharge_To_Acute_Care_Facility;
    internal Lazy<CqlValueSet> __Discharged_to_Health_Care_Facility_for_Hospice_Care;
    internal Lazy<CqlValueSet> __Discharged_to_Home_for_Hospice_Care;
    internal Lazy<CqlValueSet> __Emergency_Department_Visit;
    internal Lazy<CqlValueSet> __Hemorrhagic_Stroke;
    internal Lazy<CqlValueSet> __Ischemic_Stroke;
    internal Lazy<CqlValueSet> __Left_Against_Medical_Advice;
    internal Lazy<CqlValueSet> __Medical_Reason;
    internal Lazy<CqlValueSet> __Non_Elective_Inpatient_Encounter;
    internal Lazy<CqlValueSet> __Patient_Expired;
    internal Lazy<CqlValueSet> __Patient_Refusal;
    internal Lazy<CqlValueSet> __Pharmacological_Contraindications_For_Antithrombotic_Therapy;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<IEnumerable<Encounter>> __Denominator;
    internal Lazy<IEnumerable<MedicationRequest>> __Antithrombotic_Not_Given_at_Discharge;
    internal Lazy<IEnumerable<Encounter>> __Encounter_With_No_Antithrombotic_At_Discharge;
    internal Lazy<IEnumerable<MedicationRequest>> __Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge;
    internal Lazy<IEnumerable<Encounter>> __Encounter_With_Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge;
    internal Lazy<IEnumerable<Encounter>> __Denominator_Exceptions;
    internal Lazy<IEnumerable<Encounter>> __Denominator_Exclusions;
    internal Lazy<IEnumerable<Encounter>> __Initial_Population;
    internal Lazy<IEnumerable<MedicationRequest>> __Antithrombotic_Therapy_at_Discharge;
    internal Lazy<IEnumerable<Encounter>> __Numerator;
    internal Lazy<IEnumerable<Coding>> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG>> __SDE_Payer;
    internal Lazy<IEnumerable<Coding>> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;

    #endregion
    public DischargedonAntithromboticTherapyFHIR_0_0_010(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_0_001 = new FHIRHelpers_4_0_001(context);
        SupplementalDataElementsFHIR4_2_0_000 = new SupplementalDataElementsFHIR4_2_0_000(context);
        MATGlobalCommonFunctionsFHIR4_6_1_000 = new MATGlobalCommonFunctionsFHIR4_6_1_000(context);
        TJCOverallFHIR_1_8_000 = new TJCOverallFHIR_1_8_000(context);

        __Antithrombotic_Therapy = new Lazy<CqlValueSet>(this.Antithrombotic_Therapy_Value);
        __Comfort_Measures = new Lazy<CqlValueSet>(this.Comfort_Measures_Value);
        __Discharge_To_Acute_Care_Facility = new Lazy<CqlValueSet>(this.Discharge_To_Acute_Care_Facility_Value);
        __Discharged_to_Health_Care_Facility_for_Hospice_Care = new Lazy<CqlValueSet>(this.Discharged_to_Health_Care_Facility_for_Hospice_Care_Value);
        __Discharged_to_Home_for_Hospice_Care = new Lazy<CqlValueSet>(this.Discharged_to_Home_for_Hospice_Care_Value);
        __Emergency_Department_Visit = new Lazy<CqlValueSet>(this.Emergency_Department_Visit_Value);
        __Hemorrhagic_Stroke = new Lazy<CqlValueSet>(this.Hemorrhagic_Stroke_Value);
        __Ischemic_Stroke = new Lazy<CqlValueSet>(this.Ischemic_Stroke_Value);
        __Left_Against_Medical_Advice = new Lazy<CqlValueSet>(this.Left_Against_Medical_Advice_Value);
        __Medical_Reason = new Lazy<CqlValueSet>(this.Medical_Reason_Value);
        __Non_Elective_Inpatient_Encounter = new Lazy<CqlValueSet>(this.Non_Elective_Inpatient_Encounter_Value);
        __Patient_Expired = new Lazy<CqlValueSet>(this.Patient_Expired_Value);
        __Patient_Refusal = new Lazy<CqlValueSet>(this.Patient_Refusal_Value);
        __Pharmacological_Contraindications_For_Antithrombotic_Therapy = new Lazy<CqlValueSet>(this.Pharmacological_Contraindications_For_Antithrombotic_Therapy_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __Denominator = new Lazy<IEnumerable<Encounter>>(this.Denominator_Value);
        __Antithrombotic_Not_Given_at_Discharge = new Lazy<IEnumerable<MedicationRequest>>(this.Antithrombotic_Not_Given_at_Discharge_Value);
        __Encounter_With_No_Antithrombotic_At_Discharge = new Lazy<IEnumerable<Encounter>>(this.Encounter_With_No_Antithrombotic_At_Discharge_Value);
        __Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge = new Lazy<IEnumerable<MedicationRequest>>(this.Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge_Value);
        __Encounter_With_Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge = new Lazy<IEnumerable<Encounter>>(this.Encounter_With_Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge_Value);
        __Denominator_Exceptions = new Lazy<IEnumerable<Encounter>>(this.Denominator_Exceptions_Value);
        __Denominator_Exclusions = new Lazy<IEnumerable<Encounter>>(this.Denominator_Exclusions_Value);
        __Initial_Population = new Lazy<IEnumerable<Encounter>>(this.Initial_Population_Value);
        __Antithrombotic_Therapy_at_Discharge = new Lazy<IEnumerable<MedicationRequest>>(this.Antithrombotic_Therapy_at_Discharge_Value);
        __Numerator = new Lazy<IEnumerable<Encounter>>(this.Numerator_Value);
        __SDE_Ethnicity = new Lazy<IEnumerable<Coding>>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<IEnumerable<Coding>>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_0_001 FHIRHelpers_4_0_001 { get; }
    public SupplementalDataElementsFHIR4_2_0_000 SupplementalDataElementsFHIR4_2_0_000 { get; }
    public MATGlobalCommonFunctionsFHIR4_6_1_000 MATGlobalCommonFunctionsFHIR4_6_1_000 { get; }
    public TJCOverallFHIR_1_8_000 TJCOverallFHIR_1_8_000 { get; }

    #endregion

    private CqlValueSet Antithrombotic_Therapy_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.201", 
			null);
    }

    [CqlDeclaration("Antithrombotic Therapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.201")]
    public CqlValueSet Antithrombotic_Therapy() => __Antithrombotic_Therapy.Value;

    private CqlValueSet Comfort_Measures_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/1.3.6.1.4.1.33895.1.3.0.45", 
			null);
    }

    [CqlDeclaration("Comfort Measures")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/1.3.6.1.4.1.33895.1.3.0.45")]
    public CqlValueSet Comfort_Measures() => __Comfort_Measures.Value;

    private CqlValueSet Discharge_To_Acute_Care_Facility_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87", 
			null);
    }

    [CqlDeclaration("Discharge To Acute Care Facility")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87")]
    public CqlValueSet Discharge_To_Acute_Care_Facility() => __Discharge_To_Acute_Care_Facility.Value;

    private CqlValueSet Discharged_to_Health_Care_Facility_for_Hospice_Care_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207", 
			null);
    }

    [CqlDeclaration("Discharged to Health Care Facility for Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207")]
    public CqlValueSet Discharged_to_Health_Care_Facility_for_Hospice_Care() => __Discharged_to_Health_Care_Facility_for_Hospice_Care.Value;

    private CqlValueSet Discharged_to_Home_for_Hospice_Care_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209", 
			null);
    }

    [CqlDeclaration("Discharged to Home for Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209")]
    public CqlValueSet Discharged_to_Home_for_Hospice_Care() => __Discharged_to_Home_for_Hospice_Care.Value;

    private CqlValueSet Emergency_Department_Visit_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", 
			null);
    }

    [CqlDeclaration("Emergency Department Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292")]
    public CqlValueSet Emergency_Department_Visit() => __Emergency_Department_Visit.Value;

    private CqlValueSet Hemorrhagic_Stroke_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.212", 
			null);
    }

    [CqlDeclaration("Hemorrhagic Stroke")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.212")]
    public CqlValueSet Hemorrhagic_Stroke() => __Hemorrhagic_Stroke.Value;

    private CqlValueSet Ischemic_Stroke_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.247", 
			null);
    }

    [CqlDeclaration("Ischemic Stroke")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.247")]
    public CqlValueSet Ischemic_Stroke() => __Ischemic_Stroke.Value;

    private CqlValueSet Left_Against_Medical_Advice_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.308", 
			null);
    }

    [CqlDeclaration("Left Against Medical Advice")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.308")]
    public CqlValueSet Left_Against_Medical_Advice() => __Left_Against_Medical_Advice.Value;

    private CqlValueSet Medical_Reason_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.473", 
			null);
    }

    [CqlDeclaration("Medical Reason")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.473")]
    public CqlValueSet Medical_Reason() => __Medical_Reason.Value;

    private CqlValueSet Non_Elective_Inpatient_Encounter_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.424", 
			null);
    }

    [CqlDeclaration("Non-Elective Inpatient Encounter")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.424")]
    public CqlValueSet Non_Elective_Inpatient_Encounter() => __Non_Elective_Inpatient_Encounter.Value;

    private CqlValueSet Patient_Expired_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309", 
			null);
    }

    [CqlDeclaration("Patient Expired")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309")]
    public CqlValueSet Patient_Expired() => __Patient_Expired.Value;

    private CqlValueSet Patient_Refusal_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.93", 
			null);
    }

    [CqlDeclaration("Patient Refusal")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.93")]
    public CqlValueSet Patient_Refusal() => __Patient_Refusal.Value;

    private CqlValueSet Pharmacological_Contraindications_For_Antithrombotic_Therapy_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.52", 
			null);
    }

    [CqlDeclaration("Pharmacological Contraindications For Antithrombotic Therapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.52")]
    public CqlValueSet Pharmacological_Contraindications_For_Antithrombotic_Therapy() => __Pharmacological_Contraindications_For_Antithrombotic_Therapy.Value;

    private CqlInterval<CqlDateTime> Measurement_Period_Value()
    {
        return ((CqlInterval<CqlDateTime>)context.ResolveParameter("DischargedonAntithromboticTherapyFHIR-0.0.010", 
			"Measurement Period", 
			null));
    }

    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period() => __Measurement_Period.Value;

    private Patient Patient_Value()
    {
        var a_ = context?.DataRetriever.RetrieveByValueSet<Patient>(null, 
			null);
        return context?.Operators.SingleOrNull<Patient>(a_);
    }
    [CqlDeclaration("Patient")]
    public Patient Patient() => __Patient.Value;

    private IEnumerable<Encounter> Denominator_Value()
    {
        return TJCOverallFHIR_1_8_000.Ischemic_Stroke_Encounter();
    }
    [CqlDeclaration("Denominator")]
    public IEnumerable<Encounter> Denominator() => __Denominator.Value;

    private IEnumerable<MedicationRequest> Antithrombotic_Not_Given_at_Discharge_Value()
    {
        var a_ = this.Antithrombotic_Therapy();
        var b_ = typeof(MedicationRequest).GetProperty("Medication");
        var c_ = context?.DataRetriever.RetrieveByValueSet<MedicationRequest>(a_, 
			b_);
        Func<MedicationRequest,bool?> aq_ = (NoAntithromboticDischarge) => 
        {
            var d_ = NoAntithromboticDischarge?.DoNotPerformElement;
            var e_ = FHIRHelpers_4_0_001.ToBoolean(d_);
            var f_ = context?.Operators.IsTrue(e_);
            var g_ = (NoAntithromboticDischarge?.ReasonCode as IEnumerable<CodeableConcept>);
            Func<CodeableConcept,CqlConcept> h_ = (X) => 
            {
                return FHIRHelpers_4_0_001.ToConcept(X);
            };
            var i_ = context?.Operators.SelectOrNull<CodeableConcept, CqlConcept>(g_, 
				h_);
            var j_ = this.Medical_Reason();
            var k_ = context?.Operators.ConceptsInValueSet(i_, 
				j_);
            var o_ = this.Patient_Refusal();
            var p_ = context?.Operators.ConceptsInValueSet(i_, 
				o_);
            var q_ = context?.Operators.Or(k_, 
				p_);
            var r_ = context?.Operators.And(f_, 
				q_);
            var s_ = (NoAntithromboticDischarge?.Category as IEnumerable<CodeableConcept>);
            Func<CodeableConcept,bool?> ab_ = (C) => 
            {
                var t_ = (FHIRHelpers_4_0_001.ToConcept(C) as object);
                var v_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Community();
                var u_ = (context?.Operators.ConvertCodeToConcept(v_) as object);
                var w_ = context?.Operators.Equivalent(t_, 
					u_);
                var z_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Discharge();
                var y_ = (context?.Operators.ConvertCodeToConcept(z_) as object);
                var aa_ = context?.Operators.Equivalent(t_, 
					y_);
                return context?.Operators.Or(w_, 
					aa_);
            };
            var ac_ = context?.Operators.WhereOrNull<CodeableConcept>(s_, 
				ab_);
            var ad_ = context?.Operators.ExistsInList<CodeableConcept>(ac_);
            var ae_ = context?.Operators.And(r_, 
				ad_);
            var af_ = (NoAntithromboticDischarge?.StatusElement as object);
            var ag_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(af_);
            var ai_ = "completed";
            var aj_ = "cancelled";
            var ah_ = (new string[]
			{
				ai_,
				aj_,
			} as IEnumerable<string>);
            var ak_ = context?.Operators.InList<string>(ag_, 
				ah_);
            var al_ = context?.Operators.And(ae_, 
				ak_);
            var an_ = (NoAntithromboticDischarge?.IntentElement as object);
            var am_ = ((context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(an_) as object);
            var ao_ = ("order" as object);
            var ap_ = context?.Operators.Equal(am_, 
				ao_);
            return context?.Operators.And(al_, 
				ap_);
        };
        return context?.Operators.WhereOrNull<MedicationRequest>(c_, 
			aq_);
    }
    [CqlDeclaration("Antithrombotic Not Given at Discharge")]
    public IEnumerable<MedicationRequest> Antithrombotic_Not_Given_at_Discharge() => __Antithrombotic_Not_Given_at_Discharge.Value;

    private IEnumerable<Encounter> Encounter_With_No_Antithrombotic_At_Discharge_Value()
    {
        var a_ = TJCOverallFHIR_1_8_000.Ischemic_Stroke_Encounter();
        Func<Encounter,IEnumerable<Encounter>> j_ = (IschemicStrokeEncounter) => 
        {
            var b_ = this.Antithrombotic_Not_Given_at_Discharge();
            Func<MedicationRequest,bool?> g_ = (NoDischargeAntithrombotic) => 
            {
                var c_ = NoDischargeAntithrombotic?.AuthoredOnElement;
                var d_ = FHIRHelpers_4_0_001.ToDateTime(c_);
                var e_ = IschemicStrokeEncounter?.Period;
                var f_ = FHIRHelpers_4_0_001.ToInterval(e_);
                return context?.Operators.ElementInInterval<CqlDateTime>(d_, 
					f_, 
					null);
            };
            var h_ = context?.Operators.WhereOrNull<MedicationRequest>(b_, 
				g_);
            Func<MedicationRequest,Encounter> i_ = (NoDischargeAntithrombotic) => IschemicStrokeEncounter;
            return context?.Operators.SelectOrNull<MedicationRequest, Encounter>(h_, 
				i_);
        };
        return context?.Operators.SelectManyOrNull<Encounter, Encounter>(a_, 
			j_);
    }
    [CqlDeclaration("Encounter With No Antithrombotic At Discharge")]
    public IEnumerable<Encounter> Encounter_With_No_Antithrombotic_At_Discharge() => __Encounter_With_No_Antithrombotic_At_Discharge.Value;

    private IEnumerable<MedicationRequest> Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge_Value()
    {
        var a_ = this.Pharmacological_Contraindications_For_Antithrombotic_Therapy();
        var b_ = typeof(MedicationRequest).GetProperty("Medication");
        var c_ = context?.DataRetriever.RetrieveByValueSet<MedicationRequest>(a_, 
			b_);
        Func<MedicationRequest,bool?> af_ = (Pharmacological) => 
        {
            var d_ = Pharmacological?.DoNotPerformElement;
            var e_ = FHIRHelpers_4_0_001.ToBoolean(d_);
            var f_ = context?.Operators.IsTrue(e_);
            var g_ = context?.Operators.Not(f_);
            var h_ = (Pharmacological?.Category as IEnumerable<CodeableConcept>);
            Func<CodeableConcept,bool?> q_ = (C) => 
            {
                var i_ = (FHIRHelpers_4_0_001.ToConcept(C) as object);
                var k_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Community();
                var j_ = (context?.Operators.ConvertCodeToConcept(k_) as object);
                var l_ = context?.Operators.Equivalent(i_, 
					j_);
                var o_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Discharge();
                var n_ = (context?.Operators.ConvertCodeToConcept(o_) as object);
                var p_ = context?.Operators.Equivalent(i_, 
					n_);
                return context?.Operators.Or(l_, 
					p_);
            };
            var r_ = context?.Operators.WhereOrNull<CodeableConcept>(h_, 
				q_);
            var s_ = context?.Operators.ExistsInList<CodeableConcept>(r_);
            var t_ = context?.Operators.And(g_, 
				s_);
            var u_ = (Pharmacological?.StatusElement as object);
            var v_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(u_);
            var x_ = "active";
            var y_ = "completed";
            var w_ = (new string[]
			{
				x_,
				y_,
			} as IEnumerable<string>);
            var z_ = context?.Operators.InList<string>(v_, 
				w_);
            var aa_ = context?.Operators.And(t_, 
				z_);
            var ac_ = (Pharmacological?.IntentElement as object);
            var ab_ = ((context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(ac_) as object);
            var ad_ = ("order" as object);
            var ae_ = context?.Operators.Equal(ab_, 
				ad_);
            return context?.Operators.And(aa_, 
				ae_);
        };
        return context?.Operators.WhereOrNull<MedicationRequest>(c_, 
			af_);
    }
    [CqlDeclaration("Pharmacological Contraindications for Antithrombotic Therapy at Discharge")]
    public IEnumerable<MedicationRequest> Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge() => __Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge.Value;

    private IEnumerable<Encounter> Encounter_With_Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge_Value()
    {
        var a_ = TJCOverallFHIR_1_8_000.Ischemic_Stroke_Encounter();
        Func<Encounter,IEnumerable<Encounter>> j_ = (IschemicStrokeEncounter) => 
        {
            var b_ = this.Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge();
            Func<MedicationRequest,bool?> g_ = (DischargePharmacological) => 
            {
                var c_ = DischargePharmacological?.AuthoredOnElement;
                var d_ = FHIRHelpers_4_0_001.ToDateTime(c_);
                var e_ = IschemicStrokeEncounter?.Period;
                var f_ = FHIRHelpers_4_0_001.ToInterval(e_);
                return context?.Operators.ElementInInterval<CqlDateTime>(d_, 
					f_, 
					null);
            };
            var h_ = context?.Operators.WhereOrNull<MedicationRequest>(b_, 
				g_);
            Func<MedicationRequest,Encounter> i_ = (DischargePharmacological) => IschemicStrokeEncounter;
            return context?.Operators.SelectOrNull<MedicationRequest, Encounter>(h_, 
				i_);
        };
        return context?.Operators.SelectManyOrNull<Encounter, Encounter>(a_, 
			j_);
    }
    [CqlDeclaration("Encounter With Pharmacological Contraindications for Antithrombotic Therapy at Discharge")]
    public IEnumerable<Encounter> Encounter_With_Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge() => __Encounter_With_Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge.Value;

    private IEnumerable<Encounter> Denominator_Exceptions_Value()
    {
        var a_ = this.Encounter_With_No_Antithrombotic_At_Discharge();
        var b_ = this.Encounter_With_Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge();
        return context?.Operators.ListUnion<Encounter>(a_, 
			b_);
    }
    [CqlDeclaration("Denominator Exceptions")]
    public IEnumerable<Encounter> Denominator_Exceptions() => __Denominator_Exceptions.Value;

    private IEnumerable<Encounter> Denominator_Exclusions_Value()
    {
        var a_ = TJCOverallFHIR_1_8_000.Ischemic_Stroke_Encounters_with_Discharge_Disposition();
        var b_ = TJCOverallFHIR_1_8_000.Encounter_with_Comfort_Measures_during_Hospitalization();
        return context?.Operators.ListUnion<Encounter>(a_, 
			b_);
    }
    [CqlDeclaration("Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions() => __Denominator_Exclusions.Value;

    private IEnumerable<Encounter> Initial_Population_Value()
    {
        return TJCOverallFHIR_1_8_000.Encounter_with_Principal_Diagnosis_and_Age();
    }
    [CqlDeclaration("Initial Population")]
    public IEnumerable<Encounter> Initial_Population() => __Initial_Population.Value;

    private IEnumerable<MedicationRequest> Antithrombotic_Therapy_at_Discharge_Value()
    {
        var a_ = this.Antithrombotic_Therapy();
        var b_ = typeof(MedicationRequest).GetProperty("Medication");
        var c_ = context?.DataRetriever.RetrieveByValueSet<MedicationRequest>(a_, 
			b_);
        Func<MedicationRequest,bool?> af_ = (Antithrombotic) => 
        {
            var d_ = Antithrombotic?.DoNotPerformElement;
            var e_ = FHIRHelpers_4_0_001.ToBoolean(d_);
            var f_ = context?.Operators.IsTrue(e_);
            var g_ = context?.Operators.Not(f_);
            var h_ = (Antithrombotic?.Category as IEnumerable<CodeableConcept>);
            Func<CodeableConcept,bool?> q_ = (C) => 
            {
                var i_ = (FHIRHelpers_4_0_001.ToConcept(C) as object);
                var k_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Community();
                var j_ = (context?.Operators.ConvertCodeToConcept(k_) as object);
                var l_ = context?.Operators.Equivalent(i_, 
					j_);
                var o_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Discharge();
                var n_ = (context?.Operators.ConvertCodeToConcept(o_) as object);
                var p_ = context?.Operators.Equivalent(i_, 
					n_);
                return context?.Operators.Or(l_, 
					p_);
            };
            var r_ = context?.Operators.WhereOrNull<CodeableConcept>(h_, 
				q_);
            var s_ = context?.Operators.ExistsInList<CodeableConcept>(r_);
            var t_ = context?.Operators.And(g_, 
				s_);
            var u_ = (Antithrombotic?.StatusElement as object);
            var v_ = (context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(u_);
            var x_ = "active";
            var y_ = "completed";
            var w_ = (new string[]
			{
				x_,
				y_,
			} as IEnumerable<string>);
            var z_ = context?.Operators.InList<string>(v_, 
				w_);
            var aa_ = context?.Operators.And(t_, 
				z_);
            var ac_ = (Antithrombotic?.IntentElement as object);
            var ab_ = ((context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(ac_) as object);
            var ad_ = ("order" as object);
            var ae_ = context?.Operators.Equal(ab_, 
				ad_);
            return context?.Operators.And(aa_, 
				ae_);
        };
        return context?.Operators.WhereOrNull<MedicationRequest>(c_, 
			af_);
    }
    [CqlDeclaration("Antithrombotic Therapy at Discharge")]
    public IEnumerable<MedicationRequest> Antithrombotic_Therapy_at_Discharge() => __Antithrombotic_Therapy_at_Discharge.Value;

    private IEnumerable<Encounter> Numerator_Value()
    {
        var a_ = TJCOverallFHIR_1_8_000.Ischemic_Stroke_Encounter();
        Func<Encounter,IEnumerable<Encounter>> j_ = (IschemicStrokeEncounter) => 
        {
            var b_ = this.Antithrombotic_Therapy_at_Discharge();
            Func<MedicationRequest,bool?> g_ = (DischargeAntithrombotic) => 
            {
                var c_ = DischargeAntithrombotic?.AuthoredOnElement;
                var d_ = FHIRHelpers_4_0_001.ToDateTime(c_);
                var e_ = IschemicStrokeEncounter?.Period;
                var f_ = FHIRHelpers_4_0_001.ToInterval(e_);
                return context?.Operators.ElementInInterval<CqlDateTime>(d_, 
					f_, 
					null);
            };
            var h_ = context?.Operators.WhereOrNull<MedicationRequest>(b_, 
				g_);
            Func<MedicationRequest,Encounter> i_ = (DischargeAntithrombotic) => IschemicStrokeEncounter;
            return context?.Operators.SelectOrNull<MedicationRequest, Encounter>(h_, 
				i_);
        };
        return context?.Operators.SelectManyOrNull<Encounter, Encounter>(a_, 
			j_);
    }
    [CqlDeclaration("Numerator")]
    public IEnumerable<Encounter> Numerator() => __Numerator.Value;

    private IEnumerable<Coding> SDE_Ethnicity_Value()
    {
        return SupplementalDataElementsFHIR4_2_0_000.SDE_Ethnicity();
    }
    [CqlDeclaration("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity() => __SDE_Ethnicity.Value;

    private IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer_Value()
    {
        return SupplementalDataElementsFHIR4_2_0_000.SDE_Payer();
    }
    [CqlDeclaration("SDE Payer")]
    public IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer() => __SDE_Payer.Value;

    private IEnumerable<Coding> SDE_Race_Value()
    {
        return SupplementalDataElementsFHIR4_2_0_000.SDE_Race();
    }
    [CqlDeclaration("SDE Race")]
    public IEnumerable<Coding> SDE_Race() => __SDE_Race.Value;

    private CqlCode SDE_Sex_Value()
    {
        return SupplementalDataElementsFHIR4_2_0_000.SDE_Sex();
    }
    [CqlDeclaration("SDE Sex")]
    public CqlCode SDE_Sex() => __SDE_Sex.Value;

}