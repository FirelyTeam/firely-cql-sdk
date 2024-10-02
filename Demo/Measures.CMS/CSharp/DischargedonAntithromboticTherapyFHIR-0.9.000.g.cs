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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.4.0")]
[CqlLibrary("DischargedonAntithromboticTherapyFHIR", "0.9.000")]
public class DischargedonAntithromboticTherapyFHIR_0_9_000
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Antithrombotic_Therapy_for_Ischemic_Stroke;
    internal Lazy<CqlValueSet> __Medical_Reason_For_Not_Providing_Treatment;
    internal Lazy<CqlValueSet> __Patient_Refusal;
    internal Lazy<CqlValueSet> __Pharmacological_Contraindications_For_Antithrombotic_Therapy;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<IEnumerable<Encounter>> __Initial_Population;
    internal Lazy<IEnumerable<Encounter>> __Denominator;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_Comfort_Measures_during_Hospitalization_for_Patients_with_Documented_Ischemic_Stroke;
    internal Lazy<IEnumerable<Encounter>> __Denominator_Exclusions;
    internal Lazy<IEnumerable<Encounter>> __Numerator;
    internal Lazy<IEnumerable<MedicationRequest>> __Antithrombotic_Therapy_at_Discharge;
    internal Lazy<IEnumerable<MedicationRequest>> __Reason_for_Not_Giving_Antithrombotic_at_Discharge;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_Documented_Reason_for_No_Antithrombotic_At_Discharge;
    internal Lazy<IEnumerable<MedicationRequest>> __Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge;
    internal Lazy<IEnumerable<Encounter>> __Denominator_Exceptions;
    internal Lazy<(IEnumerable<CqlCode> codes, string display)?> __SDE_Ethnicity;
    internal Lazy<IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?>> __SDE_Payer;
    internal Lazy<(IEnumerable<CqlCode> codes, string display)?> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;

    #endregion
    public DischargedonAntithromboticTherapyFHIR_0_9_000(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_3_000 = new FHIRHelpers_4_3_000(context);
        CQMCommon_2_0_000 = new CQMCommon_2_0_000(context);
        QICoreCommon_2_0_000 = new QICoreCommon_2_0_000(context);
        SupplementalDataElements_3_4_000 = new SupplementalDataElements_3_4_000(context);
        TJCOverall_8_11_000 = new TJCOverall_8_11_000(context);

        __Antithrombotic_Therapy_for_Ischemic_Stroke = new Lazy<CqlValueSet>(this.Antithrombotic_Therapy_for_Ischemic_Stroke_Value);
        __Medical_Reason_For_Not_Providing_Treatment = new Lazy<CqlValueSet>(this.Medical_Reason_For_Not_Providing_Treatment_Value);
        __Patient_Refusal = new Lazy<CqlValueSet>(this.Patient_Refusal_Value);
        __Pharmacological_Contraindications_For_Antithrombotic_Therapy = new Lazy<CqlValueSet>(this.Pharmacological_Contraindications_For_Antithrombotic_Therapy_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __Initial_Population = new Lazy<IEnumerable<Encounter>>(this.Initial_Population_Value);
        __Denominator = new Lazy<IEnumerable<Encounter>>(this.Denominator_Value);
        __Encounter_with_Comfort_Measures_during_Hospitalization_for_Patients_with_Documented_Ischemic_Stroke = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_Comfort_Measures_during_Hospitalization_for_Patients_with_Documented_Ischemic_Stroke_Value);
        __Denominator_Exclusions = new Lazy<IEnumerable<Encounter>>(this.Denominator_Exclusions_Value);
        __Numerator = new Lazy<IEnumerable<Encounter>>(this.Numerator_Value);
        __Antithrombotic_Therapy_at_Discharge = new Lazy<IEnumerable<MedicationRequest>>(this.Antithrombotic_Therapy_at_Discharge_Value);
        __Reason_for_Not_Giving_Antithrombotic_at_Discharge = new Lazy<IEnumerable<MedicationRequest>>(this.Reason_for_Not_Giving_Antithrombotic_at_Discharge_Value);
        __Encounter_with_Documented_Reason_for_No_Antithrombotic_At_Discharge = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_Documented_Reason_for_No_Antithrombotic_At_Discharge_Value);
        __Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge = new Lazy<IEnumerable<MedicationRequest>>(this.Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge_Value);
        __Encounter_with_Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge_Value);
        __Denominator_Exceptions = new Lazy<IEnumerable<Encounter>>(this.Denominator_Exceptions_Value);
        __SDE_Ethnicity = new Lazy<(IEnumerable<CqlCode> codes, string display)?>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<(IEnumerable<CqlCode> codes, string display)?>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_3_000 FHIRHelpers_4_3_000 { get; }
    public CQMCommon_2_0_000 CQMCommon_2_0_000 { get; }
    public QICoreCommon_2_0_000 QICoreCommon_2_0_000 { get; }
    public SupplementalDataElements_3_4_000 SupplementalDataElements_3_4_000 { get; }
    public TJCOverall_8_11_000 TJCOverall_8_11_000 { get; }

    #endregion

	private CqlValueSet Antithrombotic_Therapy_for_Ischemic_Stroke_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.62", default);

    [CqlDeclaration("Antithrombotic Therapy for Ischemic Stroke")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.62")]
	public CqlValueSet Antithrombotic_Therapy_for_Ischemic_Stroke() => 
		__Antithrombotic_Therapy_for_Ischemic_Stroke.Value;

	private CqlValueSet Medical_Reason_For_Not_Providing_Treatment_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.473", default);

    [CqlDeclaration("Medical Reason For Not Providing Treatment")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.473")]
	public CqlValueSet Medical_Reason_For_Not_Providing_Treatment() => 
		__Medical_Reason_For_Not_Providing_Treatment.Value;

	private CqlValueSet Patient_Refusal_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.93", default);

    [CqlDeclaration("Patient Refusal")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.93")]
	public CqlValueSet Patient_Refusal() => 
		__Patient_Refusal.Value;

	private CqlValueSet Pharmacological_Contraindications_For_Antithrombotic_Therapy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.52", default);

    [CqlDeclaration("Pharmacological Contraindications For Antithrombotic Therapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.52")]
	public CqlValueSet Pharmacological_Contraindications_For_Antithrombotic_Therapy() => 
		__Pharmacological_Contraindications_For_Antithrombotic_Therapy.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("DischargedonAntithromboticTherapyFHIR-0.9.000", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period.Value;

	private Patient Patient_Value()
	{
		IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private IEnumerable<Encounter> Initial_Population_Value()
	{
		IEnumerable<Encounter> a_ = TJCOverall_8_11_000.Encounter_with_Principal_Diagnosis_and_Age();

		return a_;
	}

    [CqlDeclaration("Initial Population")]
	public IEnumerable<Encounter> Initial_Population() => 
		__Initial_Population.Value;

	private IEnumerable<Encounter> Denominator_Value()
	{
		IEnumerable<Encounter> a_ = TJCOverall_8_11_000.Ischemic_Stroke_Encounter();

		return a_;
	}

    [CqlDeclaration("Denominator")]
	public IEnumerable<Encounter> Denominator() => 
		__Denominator.Value;

	private IEnumerable<Encounter> Encounter_with_Comfort_Measures_during_Hospitalization_for_Patients_with_Documented_Ischemic_Stroke_Value()
	{
		IEnumerable<Encounter> a_ = this.Denominator();
		IEnumerable<Encounter> b_(Encounter Encounter)
		{
			IEnumerable<object> d_ = TJCOverall_8_11_000.Intervention_Comfort_Measures();
			bool? e_(object ComfortMeasure)
			{
				object i_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
				object j_ = FHIRHelpers_4_3_000.ToValue(i_);
				CqlInterval<CqlDateTime> k_ = QICoreCommon_2_0_000.toInterval(j_);
				CqlDateTime l_ = context.Operators.Start(k_);
				object m_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "authoredOn");
				CqlDateTime n_ = context.Operators.LateBoundProperty<CqlDateTime>(m_, "value");
				CqlInterval<CqlDateTime> o_ = CQMCommon_2_0_000.hospitalizationWithObservation(Encounter);
				bool? p_ = context.Operators.In<CqlDateTime>(l_ ?? n_, o_, default);

				return p_;
			};
			IEnumerable<object> f_ = context.Operators.Where<object>(d_, e_);
			Encounter g_(object ComfortMeasure) => 
				Encounter;
			IEnumerable<Encounter> h_ = context.Operators.Select<object, Encounter>(f_, g_);

			return h_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with Comfort Measures during Hospitalization for Patients with Documented Ischemic Stroke")]
	public IEnumerable<Encounter> Encounter_with_Comfort_Measures_during_Hospitalization_for_Patients_with_Documented_Ischemic_Stroke() => 
		__Encounter_with_Comfort_Measures_during_Hospitalization_for_Patients_with_Documented_Ischemic_Stroke.Value;

	private IEnumerable<Encounter> Denominator_Exclusions_Value()
	{
		IEnumerable<Encounter> a_ = TJCOverall_8_11_000.Ischemic_Stroke_Encounters_with_Discharge_Disposition();
		IEnumerable<Encounter> b_ = this.Encounter_with_Comfort_Measures_during_Hospitalization_for_Patients_with_Documented_Ischemic_Stroke();
		IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Denominator Exclusions")]
	public IEnumerable<Encounter> Denominator_Exclusions() => 
		__Denominator_Exclusions.Value;

	private IEnumerable<Encounter> Numerator_Value()
	{
		IEnumerable<Encounter> a_ = TJCOverall_8_11_000.Ischemic_Stroke_Encounter();
		IEnumerable<Encounter> b_(Encounter IschemicStrokeEncounter)
		{
			CqlValueSet d_ = this.Antithrombotic_Therapy_for_Ischemic_Stroke();
			IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
			IEnumerable<MedicationRequest> g_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
			IEnumerable<MedicationRequest> h_ = context.Operators.Union<MedicationRequest>(e_, g_);
			bool? i_(MedicationRequest DischargeAntithrombotic)
			{
				FhirDateTime m_ = DischargeAntithrombotic?.AuthoredOnElement;
				CqlDateTime n_ = context.Operators.Convert<CqlDateTime>(m_);
				Period o_ = IschemicStrokeEncounter?.Period;
				CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_3_000.ToInterval(o_);
				bool? q_ = context.Operators.In<CqlDateTime>(n_, p_, default);

				return q_;
			};
			IEnumerable<MedicationRequest> j_ = context.Operators.Where<MedicationRequest>(h_, i_);
			Encounter k_(MedicationRequest DischargeAntithrombotic) => 
				IschemicStrokeEncounter;
			IEnumerable<Encounter> l_ = context.Operators.Select<MedicationRequest, Encounter>(j_, k_);

			return l_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Numerator")]
	public IEnumerable<Encounter> Numerator() => 
		__Numerator.Value;

	private IEnumerable<MedicationRequest> Antithrombotic_Therapy_at_Discharge_Value()
	{
		CqlValueSet a_ = this.Antithrombotic_Therapy_for_Ischemic_Stroke();
		IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> d_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> e_ = context.Operators.Union<MedicationRequest>(b_, d_);
		bool? f_(MedicationRequest Antithrombotic)
		{
			bool? h_ = QICoreCommon_2_0_000.isCommunity(Antithrombotic);
			bool? i_ = QICoreCommon_2_0_000.isDischarge(Antithrombotic);
			bool? j_ = context.Operators.Or(h_, i_);
			Code<MedicationRequest.MedicationrequestStatus> k_ = Antithrombotic?.StatusElement;
			MedicationRequest.MedicationrequestStatus? l_ = k_?.Value;
			string m_ = context.Operators.Convert<string>(l_);
			string[] n_ = [
				"active",
				"completed",
			];
			bool? o_ = context.Operators.In<string>(m_, n_ as IEnumerable<string>);
			bool? p_ = context.Operators.And(j_, o_);
			Code<MedicationRequest.MedicationRequestIntent> q_ = Antithrombotic?.IntentElement;
			MedicationRequest.MedicationRequestIntent? r_ = q_?.Value;
			string s_ = context.Operators.Convert<string>(r_);
			string[] t_ = [
				"order",
				"original-order",
				"reflex-order",
				"filler-order",
				"instance-order",
			];
			bool? u_ = context.Operators.In<string>(s_, t_ as IEnumerable<string>);
			bool? v_ = context.Operators.And(p_, u_);
			FhirBoolean w_ = Antithrombotic?.DoNotPerformElement;
			bool? x_ = w_?.Value;
			bool? y_ = context.Operators.IsTrue(x_);
			bool? z_ = context.Operators.Not(y_);
			bool? aa_ = context.Operators.And(v_, z_);

			return aa_;
		};
		IEnumerable<MedicationRequest> g_ = context.Operators.Where<MedicationRequest>(e_, f_);

		return g_;
	}

    [CqlDeclaration("Antithrombotic Therapy at Discharge")]
	public IEnumerable<MedicationRequest> Antithrombotic_Therapy_at_Discharge() => 
		__Antithrombotic_Therapy_at_Discharge.Value;

	private IEnumerable<MedicationRequest> Reason_for_Not_Giving_Antithrombotic_at_Discharge_Value()
	{
		CqlValueSet a_ = this.Antithrombotic_Therapy_for_Ischemic_Stroke();
		IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
		IEnumerable<MedicationRequest> d_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-mednotrequested"));
		IEnumerable<MedicationRequest> e_ = context.Operators.Union<MedicationRequest>(b_, d_);
		bool? f_(MedicationRequest NoAntithromboticDischarge)
		{
			List<CodeableConcept> h_ = NoAntithromboticDischarge?.ReasonCode;
			CqlConcept i_(CodeableConcept @this)
			{
				CqlConcept ac_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return ac_;
			};
			IEnumerable<CqlConcept> j_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)h_, i_);
			CqlValueSet k_ = this.Medical_Reason_For_Not_Providing_Treatment();
			bool? l_ = context.Operators.ConceptsInValueSet(j_, k_);
			CqlConcept n_(CodeableConcept @this)
			{
				CqlConcept ad_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return ad_;
			};
			IEnumerable<CqlConcept> o_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)h_, n_);
			CqlValueSet p_ = this.Patient_Refusal();
			bool? q_ = context.Operators.ConceptsInValueSet(o_, p_);
			bool? r_ = context.Operators.Or(l_, q_);
			bool? s_ = QICoreCommon_2_0_000.isCommunity(NoAntithromboticDischarge);
			bool? t_ = QICoreCommon_2_0_000.isDischarge(NoAntithromboticDischarge);
			bool? u_ = context.Operators.Or(s_, t_);
			bool? v_ = context.Operators.And(r_, u_);
			Code<MedicationRequest.MedicationRequestIntent> w_ = NoAntithromboticDischarge?.IntentElement;
			MedicationRequest.MedicationRequestIntent? x_ = w_?.Value;
			string y_ = context.Operators.Convert<string>(x_);
			string[] z_ = [
				"order",
				"original-order",
				"reflex-order",
				"filler-order",
				"instance-order",
			];
			bool? aa_ = context.Operators.In<string>(y_, z_ as IEnumerable<string>);
			bool? ab_ = context.Operators.And(v_, aa_);

			return ab_;
		};
		IEnumerable<MedicationRequest> g_ = context.Operators.Where<MedicationRequest>(e_, f_);

		return g_;
	}

    [CqlDeclaration("Reason for Not Giving Antithrombotic at Discharge")]
	public IEnumerable<MedicationRequest> Reason_for_Not_Giving_Antithrombotic_at_Discharge() => 
		__Reason_for_Not_Giving_Antithrombotic_at_Discharge.Value;

	private IEnumerable<Encounter> Encounter_with_Documented_Reason_for_No_Antithrombotic_At_Discharge_Value()
	{
		IEnumerable<Encounter> a_ = TJCOverall_8_11_000.Ischemic_Stroke_Encounter();
		IEnumerable<Encounter> b_(Encounter IschemicStrokeEncounter)
		{
			IEnumerable<MedicationRequest> d_ = this.Reason_for_Not_Giving_Antithrombotic_at_Discharge();
			bool? e_(MedicationRequest NoDischargeAntithrombotic)
			{
				FhirDateTime i_ = NoDischargeAntithrombotic?.AuthoredOnElement;
				CqlDateTime j_ = context.Operators.Convert<CqlDateTime>(i_);
				Period k_ = IschemicStrokeEncounter?.Period;
				CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_3_000.ToInterval(k_);
				bool? m_ = context.Operators.In<CqlDateTime>(j_, l_, default);

				return m_;
			};
			IEnumerable<MedicationRequest> f_ = context.Operators.Where<MedicationRequest>(d_, e_);
			Encounter g_(MedicationRequest NoDischargeAntithrombotic) => 
				IschemicStrokeEncounter;
			IEnumerable<Encounter> h_ = context.Operators.Select<MedicationRequest, Encounter>(f_, g_);

			return h_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with Documented Reason for No Antithrombotic At Discharge")]
	public IEnumerable<Encounter> Encounter_with_Documented_Reason_for_No_Antithrombotic_At_Discharge() => 
		__Encounter_with_Documented_Reason_for_No_Antithrombotic_At_Discharge.Value;

	private IEnumerable<MedicationRequest> Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge_Value()
	{
		CqlValueSet a_ = this.Pharmacological_Contraindications_For_Antithrombotic_Therapy();
		IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> d_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> e_ = context.Operators.Union<MedicationRequest>(b_, d_);
		bool? f_(MedicationRequest Pharmacological)
		{
			bool? h_ = QICoreCommon_2_0_000.isCommunity(Pharmacological);
			bool? i_ = QICoreCommon_2_0_000.isDischarge(Pharmacological);
			bool? j_ = context.Operators.Or(h_, i_);
			Code<MedicationRequest.MedicationrequestStatus> k_ = Pharmacological?.StatusElement;
			MedicationRequest.MedicationrequestStatus? l_ = k_?.Value;
			string m_ = context.Operators.Convert<string>(l_);
			string[] n_ = [
				"active",
				"completed",
			];
			bool? o_ = context.Operators.In<string>(m_, n_ as IEnumerable<string>);
			bool? p_ = context.Operators.And(j_, o_);
			Code<MedicationRequest.MedicationRequestIntent> q_ = Pharmacological?.IntentElement;
			MedicationRequest.MedicationRequestIntent? r_ = q_?.Value;
			string s_ = context.Operators.Convert<string>(r_);
			string[] t_ = [
				"order",
				"original-order",
				"reflex-order",
				"filler-order",
				"instance-order",
			];
			bool? u_ = context.Operators.In<string>(s_, t_ as IEnumerable<string>);
			bool? v_ = context.Operators.And(p_, u_);
			FhirBoolean w_ = Pharmacological?.DoNotPerformElement;
			bool? x_ = w_?.Value;
			bool? y_ = context.Operators.IsTrue(x_);
			bool? z_ = context.Operators.Not(y_);
			bool? aa_ = context.Operators.And(v_, z_);

			return aa_;
		};
		IEnumerable<MedicationRequest> g_ = context.Operators.Where<MedicationRequest>(e_, f_);

		return g_;
	}

    [CqlDeclaration("Pharmacological Contraindications for Antithrombotic Therapy at Discharge")]
	public IEnumerable<MedicationRequest> Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge() => 
		__Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge.Value;

	private IEnumerable<Encounter> Encounter_with_Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge_Value()
	{
		IEnumerable<Encounter> a_ = TJCOverall_8_11_000.Ischemic_Stroke_Encounter();
		IEnumerable<Encounter> b_(Encounter IschemicStrokeEncounter)
		{
			IEnumerable<MedicationRequest> d_ = this.Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge();
			bool? e_(MedicationRequest DischargePharmacological)
			{
				FhirDateTime i_ = DischargePharmacological?.AuthoredOnElement;
				CqlDateTime j_ = context.Operators.Convert<CqlDateTime>(i_);
				Period k_ = IschemicStrokeEncounter?.Period;
				CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_3_000.ToInterval(k_);
				bool? m_ = context.Operators.In<CqlDateTime>(j_, l_, default);

				return m_;
			};
			IEnumerable<MedicationRequest> f_ = context.Operators.Where<MedicationRequest>(d_, e_);
			Encounter g_(MedicationRequest DischargePharmacological) => 
				IschemicStrokeEncounter;
			IEnumerable<Encounter> h_ = context.Operators.Select<MedicationRequest, Encounter>(f_, g_);

			return h_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with Pharmacological Contraindications for Antithrombotic Therapy at Discharge")]
	public IEnumerable<Encounter> Encounter_with_Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge() => 
		__Encounter_with_Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge.Value;

	private IEnumerable<Encounter> Denominator_Exceptions_Value()
	{
		IEnumerable<Encounter> a_ = this.Encounter_with_Documented_Reason_for_No_Antithrombotic_At_Discharge();
		IEnumerable<Encounter> b_ = this.Encounter_with_Pharmacological_Contraindications_for_Antithrombotic_Therapy_at_Discharge();
		IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Denominator Exceptions")]
	public IEnumerable<Encounter> Denominator_Exceptions() => 
		__Denominator_Exceptions.Value;

	private (IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Value()
	{
		(IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_4_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public (IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Value()
	{
		IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_3_4_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer() => 
		__SDE_Payer.Value;

	private (IEnumerable<CqlCode> codes, string display)? SDE_Race_Value()
	{
		(IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_4_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public (IEnumerable<CqlCode> codes, string display)? SDE_Race() => 
		__SDE_Race.Value;

	private CqlCode SDE_Sex_Value()
	{
		CqlCode a_ = SupplementalDataElements_3_4_000.SDE_Sex();

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex() => 
		__SDE_Sex.Value;

}
