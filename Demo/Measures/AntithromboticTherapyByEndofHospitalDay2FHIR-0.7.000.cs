using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "1.0.0.0")]
[CqlLibrary("AntithromboticTherapyByEndofHospitalDay2FHIR", "0.7.000")]
public class AntithromboticTherapyByEndofHospitalDay2FHIR_0_7_000
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Antithrombotic_Therapy_for_Ischemic_Stroke;
    internal Lazy<CqlValueSet> __Comfort_Measures;
    internal Lazy<CqlValueSet> __INR;
    internal Lazy<CqlValueSet> __Intravenous_or_Intraarterial_Thrombolytic_tPA_Therapy_Prior_to_Arrival;
    internal Lazy<CqlValueSet> __Intravenous_or_Intraarterial_Thrombolytic_tPA_Therapy;
    internal Lazy<CqlValueSet> __Medical_Reason_for_Not_Providing_Treatment;
    internal Lazy<CqlValueSet> __Patient_Refusal;
    internal Lazy<CqlValueSet> __Pharmacological_Contraindications_For_Antithrombotic_Therapy;
    internal Lazy<CqlValueSet> __Thrombolytic_tPA_Therapy;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<IEnumerable<Encounter>> __Initial_Population;
    internal Lazy<IEnumerable<Encounter>> __Denominator;
    internal Lazy<IEnumerable<Encounter>> __Encounter_Less_Than_Two_Days;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_Comfort_Measures_during_Day_of_or_Day_After_Arrival;
    internal Lazy<IEnumerable<Tuples.Tuple_FAePeOfTgGTJWWNOBKTGZXCLB>> __Thrombolytic_Therapy_Medication_or_Procedures;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_Thrombolytic_Therapy_Medication_or_Procedures;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_Thrombolytic_Therapy_Prior_to_Arrival;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_Thrombolytic_Therapy_Documented_As_Already_Given;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_Thrombolytic_Therapy_Given_Prior_To_Arrival_Or_During_Hospitalization;
    internal Lazy<IEnumerable<Encounter>> __Denominator_Exclusions;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_Antithrombotic_Therapy;
    internal Lazy<IEnumerable<Encounter>> __Numerator;
    internal Lazy<IEnumerable<Tuples.Tuple_BbhTaZZjBaiJcUjLFAUQXXc>> __Reason_for_Not_Ordering_Antithrombotic;
    internal Lazy<IEnumerable<Tuples.Tuple_BbhTaZZjBaiJcUjLFAUQXXc>> __Reason_for_Not_Administering_Antithrombotic;
    internal Lazy<IEnumerable<Tuples.Tuple_BbhTaZZjBaiJcUjLFAUQXXc>> __Documented_Reason_for_No_Antithrombotic_Ordered_or_Administered;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_Documented_Reason_for_No_Antithrombotic_Ordered_or_Administered_Day_Of_or_Day_After_Hospital_Arrival;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_Pharmacological_Contraindications_for_Antithrombotic_Therapy_Given_Day_Of_or_Day_After_Hospital_Arrival;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_An_INR_Greater_Than_3_5;
    internal Lazy<IEnumerable<Encounter>> __Denominator_Exceptions;
    internal Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuples.Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>> __SDE_Payer;
    internal Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;

    #endregion
    public AntithromboticTherapyByEndofHospitalDay2FHIR_0_7_000(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_3_000 = new FHIRHelpers_4_3_000(context);
        CQMCommon_2_0_000 = new CQMCommon_2_0_000(context);
        QICoreCommon_2_0_000 = new QICoreCommon_2_0_000(context);
        SupplementalDataElements_3_4_000 = new SupplementalDataElements_3_4_000(context);
        TJCOverall_8_11_000 = new TJCOverall_8_11_000(context);

        __Antithrombotic_Therapy_for_Ischemic_Stroke = new Lazy<CqlValueSet>(this.Antithrombotic_Therapy_for_Ischemic_Stroke_Value);
        __Comfort_Measures = new Lazy<CqlValueSet>(this.Comfort_Measures_Value);
        __INR = new Lazy<CqlValueSet>(this.INR_Value);
        __Intravenous_or_Intraarterial_Thrombolytic_tPA_Therapy_Prior_to_Arrival = new Lazy<CqlValueSet>(this.Intravenous_or_Intraarterial_Thrombolytic_tPA_Therapy_Prior_to_Arrival_Value);
        __Intravenous_or_Intraarterial_Thrombolytic_tPA_Therapy = new Lazy<CqlValueSet>(this.Intravenous_or_Intraarterial_Thrombolytic_tPA_Therapy_Value);
        __Medical_Reason_for_Not_Providing_Treatment = new Lazy<CqlValueSet>(this.Medical_Reason_for_Not_Providing_Treatment_Value);
        __Patient_Refusal = new Lazy<CqlValueSet>(this.Patient_Refusal_Value);
        __Pharmacological_Contraindications_For_Antithrombotic_Therapy = new Lazy<CqlValueSet>(this.Pharmacological_Contraindications_For_Antithrombotic_Therapy_Value);
        __Thrombolytic_tPA_Therapy = new Lazy<CqlValueSet>(this.Thrombolytic_tPA_Therapy_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __Initial_Population = new Lazy<IEnumerable<Encounter>>(this.Initial_Population_Value);
        __Denominator = new Lazy<IEnumerable<Encounter>>(this.Denominator_Value);
        __Encounter_Less_Than_Two_Days = new Lazy<IEnumerable<Encounter>>(this.Encounter_Less_Than_Two_Days_Value);
        __Encounter_with_Comfort_Measures_during_Day_of_or_Day_After_Arrival = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_Comfort_Measures_during_Day_of_or_Day_After_Arrival_Value);
        __Thrombolytic_Therapy_Medication_or_Procedures = new Lazy<IEnumerable<Tuples.Tuple_FAePeOfTgGTJWWNOBKTGZXCLB>>(this.Thrombolytic_Therapy_Medication_or_Procedures_Value);
        __Encounter_with_Thrombolytic_Therapy_Medication_or_Procedures = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_Thrombolytic_Therapy_Medication_or_Procedures_Value);
        __Encounter_with_Thrombolytic_Therapy_Prior_to_Arrival = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_Thrombolytic_Therapy_Prior_to_Arrival_Value);
        __Encounter_with_Thrombolytic_Therapy_Documented_As_Already_Given = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_Thrombolytic_Therapy_Documented_As_Already_Given_Value);
        __Encounter_with_Thrombolytic_Therapy_Given_Prior_To_Arrival_Or_During_Hospitalization = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_Thrombolytic_Therapy_Given_Prior_To_Arrival_Or_During_Hospitalization_Value);
        __Denominator_Exclusions = new Lazy<IEnumerable<Encounter>>(this.Denominator_Exclusions_Value);
        __Encounter_with_Antithrombotic_Therapy = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_Antithrombotic_Therapy_Value);
        __Numerator = new Lazy<IEnumerable<Encounter>>(this.Numerator_Value);
        __Reason_for_Not_Ordering_Antithrombotic = new Lazy<IEnumerable<Tuples.Tuple_BbhTaZZjBaiJcUjLFAUQXXc>>(this.Reason_for_Not_Ordering_Antithrombotic_Value);
        __Reason_for_Not_Administering_Antithrombotic = new Lazy<IEnumerable<Tuples.Tuple_BbhTaZZjBaiJcUjLFAUQXXc>>(this.Reason_for_Not_Administering_Antithrombotic_Value);
        __Documented_Reason_for_No_Antithrombotic_Ordered_or_Administered = new Lazy<IEnumerable<Tuples.Tuple_BbhTaZZjBaiJcUjLFAUQXXc>>(this.Documented_Reason_for_No_Antithrombotic_Ordered_or_Administered_Value);
        __Encounter_with_Documented_Reason_for_No_Antithrombotic_Ordered_or_Administered_Day_Of_or_Day_After_Hospital_Arrival = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_Documented_Reason_for_No_Antithrombotic_Ordered_or_Administered_Day_Of_or_Day_After_Hospital_Arrival_Value);
        __Encounter_with_Pharmacological_Contraindications_for_Antithrombotic_Therapy_Given_Day_Of_or_Day_After_Hospital_Arrival = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_Pharmacological_Contraindications_for_Antithrombotic_Therapy_Given_Day_Of_or_Day_After_Hospital_Arrival_Value);
        __Encounter_with_An_INR_Greater_Than_3_5 = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_An_INR_Greater_Than_3_5_Value);
        __Denominator_Exceptions = new Lazy<IEnumerable<Encounter>>(this.Denominator_Exceptions_Value);
        __SDE_Ethnicity = new Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuples.Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Race_Value);
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
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.62", null);

    [CqlDeclaration("Antithrombotic Therapy for Ischemic Stroke")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.62")]
	public CqlValueSet Antithrombotic_Therapy_for_Ischemic_Stroke() => 
		__Antithrombotic_Therapy_for_Ischemic_Stroke.Value;

	private CqlValueSet Comfort_Measures_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/1.3.6.1.4.1.33895.1.3.0.45", null);

    [CqlDeclaration("Comfort Measures")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/1.3.6.1.4.1.33895.1.3.0.45")]
	public CqlValueSet Comfort_Measures() => 
		__Comfort_Measures.Value;

	private CqlValueSet INR_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.213", null);

    [CqlDeclaration("INR")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.213")]
	public CqlValueSet INR() => 
		__INR.Value;

	private CqlValueSet Intravenous_or_Intraarterial_Thrombolytic_tPA_Therapy_Prior_to_Arrival_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.21", null);

    [CqlDeclaration("Intravenous or Intraarterial Thrombolytic tPA Therapy Prior to Arrival")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.21")]
	public CqlValueSet Intravenous_or_Intraarterial_Thrombolytic_tPA_Therapy_Prior_to_Arrival() => 
		__Intravenous_or_Intraarterial_Thrombolytic_tPA_Therapy_Prior_to_Arrival.Value;

	private CqlValueSet Intravenous_or_Intraarterial_Thrombolytic_tPA_Therapy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.21", null);

    [CqlDeclaration("Intravenous or Intraarterial Thrombolytic tPA Therapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.21")]
	public CqlValueSet Intravenous_or_Intraarterial_Thrombolytic_tPA_Therapy() => 
		__Intravenous_or_Intraarterial_Thrombolytic_tPA_Therapy.Value;

	private CqlValueSet Medical_Reason_for_Not_Providing_Treatment_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.473", null);

    [CqlDeclaration("Medical Reason for Not Providing Treatment")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.473")]
	public CqlValueSet Medical_Reason_for_Not_Providing_Treatment() => 
		__Medical_Reason_for_Not_Providing_Treatment.Value;

	private CqlValueSet Patient_Refusal_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.93", null);

    [CqlDeclaration("Patient Refusal")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.93")]
	public CqlValueSet Patient_Refusal() => 
		__Patient_Refusal.Value;

	private CqlValueSet Pharmacological_Contraindications_For_Antithrombotic_Therapy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.52", null);

    [CqlDeclaration("Pharmacological Contraindications For Antithrombotic Therapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.52")]
	public CqlValueSet Pharmacological_Contraindications_For_Antithrombotic_Therapy() => 
		__Pharmacological_Contraindications_For_Antithrombotic_Therapy.Value;

	private CqlValueSet Thrombolytic_tPA_Therapy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.226", null);

    [CqlDeclaration("Thrombolytic tPA Therapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.226")]
	public CqlValueSet Thrombolytic_tPA_Therapy() => 
		__Thrombolytic_tPA_Therapy.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.Operators.ConvertIntegerToDecimal(default);
		var b_ = context.Operators.DateTime((int?)2025, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, a_);
		var d_ = context.Operators.DateTime((int?)2026, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, a_);
		var e_ = context.Operators.Interval(b_, d_, true, false);
		var f_ = context.ResolveParameter("AntithromboticTherapyByEndofHospitalDay2FHIR-0.7.000", "Measurement Period", e_);

		return (CqlInterval<CqlDateTime>)f_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period.Value;

	private Patient Patient_Value()
	{
		var a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		var b_ = context.Operators.SingleOrNull<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private IEnumerable<Encounter> Initial_Population_Value()
	{
		var a_ = TJCOverall_8_11_000.Encounter_with_Principal_Diagnosis_and_Age();

		return a_;
	}

    [CqlDeclaration("Initial Population")]
	public IEnumerable<Encounter> Initial_Population() => 
		__Initial_Population.Value;

	private IEnumerable<Encounter> Denominator_Value()
	{
		var a_ = TJCOverall_8_11_000.Ischemic_Stroke_Encounter();

		return a_;
	}

    [CqlDeclaration("Denominator")]
	public IEnumerable<Encounter> Denominator() => 
		__Denominator.Value;

	private IEnumerable<Encounter> Encounter_Less_Than_Two_Days_Value()
	{
		var a_ = TJCOverall_8_11_000.Ischemic_Stroke_Encounter();
		bool? b_(Encounter IschemicStrokeEncounter)
		{
			var d_ = CQMCommon_2_0_000.hospitalizationWithObservation(IschemicStrokeEncounter);
			var e_ = CQMCommon_2_0_000.lengthInDays(d_);
			var f_ = context.Operators.Less(e_, (int?)2);

			return f_;
		};
		var c_ = context.Operators.WhereOrNull<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter Less Than Two Days")]
	public IEnumerable<Encounter> Encounter_Less_Than_Two_Days() => 
		__Encounter_Less_Than_Two_Days.Value;

	private IEnumerable<Encounter> Encounter_with_Comfort_Measures_during_Day_of_or_Day_After_Arrival_Value()
	{
		var a_ = TJCOverall_8_11_000.Ischemic_Stroke_Encounter();
		IEnumerable<Encounter> b_(Encounter IschemicStrokeEncounter)
		{
			var d_ = TJCOverall_8_11_000.Intervention_Comfort_Measures();
			bool? e_(object ComfortMeasure)
			{
				var i_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "performed");
				var j_ = FHIRHelpers_4_3_000.ToValue(i_);
				var k_ = QICoreCommon_2_0_000.toInterval(j_);
				var l_ = context.Operators.Start(k_);
				var m_ = context.Operators.LateBoundProperty<object>(ComfortMeasure, "authoredOn");
				var n_ = context.Operators.LateBoundProperty<CqlDateTime>(m_, "value");
				var o_ = CQMCommon_2_0_000.hospitalizationWithObservation(IschemicStrokeEncounter);
				var p_ = context.Operators.Start(o_);
				var q_ = TJCOverall_8_11_000.CalendarDayOfOrDayAfter(p_);
				var r_ = context.Operators.ConvertDateToDateTime(q_?.low);
				var t_ = context.Operators.Start(o_);
				var u_ = TJCOverall_8_11_000.CalendarDayOfOrDayAfter(t_);
				var v_ = context.Operators.ConvertDateToDateTime(u_?.high);
				var x_ = context.Operators.Start(o_);
				var y_ = TJCOverall_8_11_000.CalendarDayOfOrDayAfter(x_);
				var aa_ = context.Operators.Start(o_);
				var ab_ = TJCOverall_8_11_000.CalendarDayOfOrDayAfter(aa_);
				var ac_ = context.Operators.Interval(r_, v_, y_?.lowClosed, ab_?.highClosed);
				var ad_ = context.Operators.ElementInInterval<CqlDateTime>((l_ ?? n_), ac_, "day");

				return ad_;
			};
			var f_ = context.Operators.WhereOrNull<object>(d_, e_);
			Encounter g_(object ComfortMeasure) => 
				IschemicStrokeEncounter;
			var h_ = context.Operators.SelectOrNull<object, Encounter>(f_, g_);

			return h_;
		};
		var c_ = context.Operators.SelectManyOrNull<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with Comfort Measures during Day of or Day After Arrival")]
	public IEnumerable<Encounter> Encounter_with_Comfort_Measures_during_Day_of_or_Day_After_Arrival() => 
		__Encounter_with_Comfort_Measures_during_Day_of_or_Day_After_Arrival.Value;

	private IEnumerable<Tuples.Tuple_FAePeOfTgGTJWWNOBKTGZXCLB> Thrombolytic_Therapy_Medication_or_Procedures_Value()
	{
		var a_ = this.Thrombolytic_tPA_Therapy();
		var b_ = context.Operators.RetrieveByValueSet<MedicationAdministration>(a_, null);
		var d_ = context.Operators.RetrieveByValueSet<MedicationAdministration>(a_, null);
		var e_ = context.Operators.ListUnion<MedicationAdministration>(b_, d_);
		bool? f_(MedicationAdministration ThrombolyticMedication)
		{
			var q_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(ThrombolyticMedication?.StatusElement?.Value);
			var r_ = context.Operators.Convert<string>(q_);
			var s_ = new string[]
			{
				"in-progress",
				"completed",
			};
			var t_ = context.Operators.InList<string>(r_, (s_ as IEnumerable<string>));

			return t_;
		};
		var g_ = context.Operators.WhereOrNull<MedicationAdministration>(e_, f_);
		Tuples.Tuple_FAePeOfTgGTJWWNOBKTGZXCLB h_(MedicationAdministration ThrombolyticMedication)
		{
			var u_ = FHIRHelpers_4_3_000.ToValue(ThrombolyticMedication?.Effective);
			var v_ = new Tuples.Tuple_FAePeOfTgGTJWWNOBKTGZXCLB
			{
				id = ThrombolyticMedication?.IdElement?.Value,
				effective = u_,
			};

			return v_;
		};
		var i_ = context.Operators.SelectOrNull<MedicationAdministration, Tuples.Tuple_FAePeOfTgGTJWWNOBKTGZXCLB>(g_, h_);
		var j_ = this.Intravenous_or_Intraarterial_Thrombolytic_tPA_Therapy();
		var k_ = context.Operators.RetrieveByValueSet<Procedure>(j_, null);
		bool? l_(Procedure ThrombolyticProcedure)
		{
			var w_ = context.Operators.EnumEqualsString(ThrombolyticProcedure?.StatusElement?.Value, "completed");

			return w_;
		};
		var m_ = context.Operators.WhereOrNull<Procedure>(k_, l_);
		Tuples.Tuple_FAePeOfTgGTJWWNOBKTGZXCLB n_(Procedure ThrombolyticProcedure)
		{
			var x_ = FHIRHelpers_4_3_000.ToValue(ThrombolyticProcedure?.Performed);
			var y_ = new Tuples.Tuple_FAePeOfTgGTJWWNOBKTGZXCLB
			{
				id = ThrombolyticProcedure?.IdElement?.Value,
				effective = x_,
			};

			return y_;
		};
		var o_ = context.Operators.SelectOrNull<Procedure, Tuples.Tuple_FAePeOfTgGTJWWNOBKTGZXCLB>(m_, n_);
		var p_ = context.Operators.ListUnion<Tuples.Tuple_FAePeOfTgGTJWWNOBKTGZXCLB>(i_, o_);

		return p_;
	}

    [CqlDeclaration("Thrombolytic Therapy Medication or Procedures")]
	public IEnumerable<Tuples.Tuple_FAePeOfTgGTJWWNOBKTGZXCLB> Thrombolytic_Therapy_Medication_or_Procedures() => 
		__Thrombolytic_Therapy_Medication_or_Procedures.Value;

	private IEnumerable<Encounter> Encounter_with_Thrombolytic_Therapy_Medication_or_Procedures_Value()
	{
		var a_ = TJCOverall_8_11_000.Ischemic_Stroke_Encounter();
		IEnumerable<Encounter> b_(Encounter IschemicStrokeEncounter)
		{
			var d_ = this.Thrombolytic_Therapy_Medication_or_Procedures();
			bool? e_(Tuples.Tuple_FAePeOfTgGTJWWNOBKTGZXCLB ThrombolyticTherapy)
			{
				var i_ = QICoreCommon_2_0_000.toInterval(ThrombolyticTherapy?.effective);
				var j_ = context.Operators.Start(i_);
				var k_ = CQMCommon_2_0_000.hospitalizationWithObservation(IschemicStrokeEncounter);
				var l_ = context.Operators.Start(k_);
				var m_ = context.Operators.Quantity(24m, "hours");
				var n_ = context.Operators.Subtract(l_, m_);
				var p_ = context.Operators.End(k_);
				var q_ = context.Operators.Interval(n_, p_, true, false);
				var r_ = context.Operators.ElementInInterval<CqlDateTime>(j_, q_, null);

				return r_;
			};
			var f_ = context.Operators.WhereOrNull<Tuples.Tuple_FAePeOfTgGTJWWNOBKTGZXCLB>(d_, e_);
			Encounter g_(Tuples.Tuple_FAePeOfTgGTJWWNOBKTGZXCLB ThrombolyticTherapy) => 
				IschemicStrokeEncounter;
			var h_ = context.Operators.SelectOrNull<Tuples.Tuple_FAePeOfTgGTJWWNOBKTGZXCLB, Encounter>(f_, g_);

			return h_;
		};
		var c_ = context.Operators.SelectManyOrNull<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with Thrombolytic Therapy Medication or Procedures")]
	public IEnumerable<Encounter> Encounter_with_Thrombolytic_Therapy_Medication_or_Procedures() => 
		__Encounter_with_Thrombolytic_Therapy_Medication_or_Procedures.Value;

	private IEnumerable<Encounter> Encounter_with_Thrombolytic_Therapy_Prior_to_Arrival_Value()
	{
		var a_ = TJCOverall_8_11_000.Ischemic_Stroke_Encounter();
		bool? b_(Encounter IschemicStrokeEncounter)
		{
			var d_ = CQMCommon_2_0_000.encounterDiagnosis(IschemicStrokeEncounter);
			bool? e_(Condition EncounterDiagnosis)
			{
				var h_ = FHIRHelpers_4_3_000.ToConcept(EncounterDiagnosis?.Code);
				var i_ = this.Intravenous_or_Intraarterial_Thrombolytic_tPA_Therapy_Prior_to_Arrival();
				var j_ = context.Operators.ConceptInValueSet(h_, i_);

				return j_;
			};
			var f_ = context.Operators.WhereOrNull<Condition>(d_, e_);
			var g_ = context.Operators.ExistsInList<Condition>(f_);

			return g_;
		};
		var c_ = context.Operators.WhereOrNull<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with Thrombolytic Therapy Prior to Arrival")]
	public IEnumerable<Encounter> Encounter_with_Thrombolytic_Therapy_Prior_to_Arrival() => 
		__Encounter_with_Thrombolytic_Therapy_Prior_to_Arrival.Value;

	private IEnumerable<Encounter> Encounter_with_Thrombolytic_Therapy_Documented_As_Already_Given_Value()
	{
		var a_ = TJCOverall_8_11_000.Ischemic_Stroke_Encounter();
		IEnumerable<Encounter> b_(Encounter IschemicStrokeEncounter)
		{
			var d_ = this.Intravenous_or_Intraarterial_Thrombolytic_tPA_Therapy_Prior_to_Arrival();
			var e_ = context.Operators.RetrieveByValueSet<Condition>(d_, null);
			bool? f_(Condition PriorTPA)
			{
				var j_ = context.Operators.Convert<CqlDateTime>(PriorTPA?.RecordedDateElement);
				var k_ = CQMCommon_2_0_000.HospitalizationWithObservation(IschemicStrokeEncounter);
				var l_ = context.Operators.ElementInInterval<CqlDateTime>(j_, k_, null);
				var m_ = QICoreCommon_2_0_000.isActive(PriorTPA);
				var n_ = context.Operators.And(l_, m_);
				var o_ = FHIRHelpers_4_3_000.ToConcept(PriorTPA?.VerificationStatus);
				var p_ = context.Operators.Not((bool?)(o_ is null));
				var q_ = context.Operators.And(n_, p_);
				var s_ = QICoreCommon_2_0_000.confirmed();
				var t_ = context.Operators.ConvertCodeToConcept(s_);
				var u_ = context.Operators.Equivalent(o_, t_);
				var v_ = context.Operators.And(q_, u_);

				return v_;
			};
			var g_ = context.Operators.WhereOrNull<Condition>(e_, f_);
			Encounter h_(Condition PriorTPA) => 
				IschemicStrokeEncounter;
			var i_ = context.Operators.SelectOrNull<Condition, Encounter>(g_, h_);

			return i_;
		};
		var c_ = context.Operators.SelectManyOrNull<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with Thrombolytic Therapy Documented As Already Given")]
	public IEnumerable<Encounter> Encounter_with_Thrombolytic_Therapy_Documented_As_Already_Given() => 
		__Encounter_with_Thrombolytic_Therapy_Documented_As_Already_Given.Value;

	private IEnumerable<Encounter> Encounter_with_Thrombolytic_Therapy_Given_Prior_To_Arrival_Or_During_Hospitalization_Value()
	{
		var a_ = this.Encounter_with_Thrombolytic_Therapy_Medication_or_Procedures();
		var b_ = this.Encounter_with_Thrombolytic_Therapy_Prior_to_Arrival();
		var c_ = context.Operators.ListUnion<Encounter>(a_, b_);
		var d_ = this.Encounter_with_Thrombolytic_Therapy_Documented_As_Already_Given();
		var e_ = context.Operators.ListUnion<Encounter>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Encounter with Thrombolytic Therapy Given Prior To Arrival Or During Hospitalization")]
	public IEnumerable<Encounter> Encounter_with_Thrombolytic_Therapy_Given_Prior_To_Arrival_Or_During_Hospitalization() => 
		__Encounter_with_Thrombolytic_Therapy_Given_Prior_To_Arrival_Or_During_Hospitalization.Value;

	private IEnumerable<Encounter> Denominator_Exclusions_Value()
	{
		var a_ = this.Encounter_Less_Than_Two_Days();
		var b_ = this.Encounter_with_Comfort_Measures_during_Day_of_or_Day_After_Arrival();
		var c_ = context.Operators.ListUnion<Encounter>(a_, b_);
		var d_ = this.Encounter_with_Thrombolytic_Therapy_Given_Prior_To_Arrival_Or_During_Hospitalization();
		var e_ = context.Operators.ListUnion<Encounter>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Denominator Exclusions")]
	public IEnumerable<Encounter> Denominator_Exclusions() => 
		__Denominator_Exclusions.Value;

	private IEnumerable<Encounter> Encounter_with_Antithrombotic_Therapy_Value()
	{
		var a_ = TJCOverall_8_11_000.Ischemic_Stroke_Encounter();
		IEnumerable<Encounter> b_(Encounter IschemicStrokeEncounter)
		{
			var d_ = this.Antithrombotic_Therapy_for_Ischemic_Stroke();
			var e_ = context.Operators.RetrieveByValueSet<MedicationAdministration>(d_, null);
			var g_ = context.Operators.RetrieveByValueSet<MedicationAdministration>(d_, null);
			var h_ = context.Operators.ListUnion<MedicationAdministration>(e_, g_);
			bool? i_(MedicationAdministration Antithrombotic)
			{
				var m_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(Antithrombotic?.StatusElement?.Value);
				var n_ = context.Operators.Convert<string>(m_);
				var o_ = new string[]
				{
					"in-progress",
					"completed",
				};
				var p_ = context.Operators.InList<string>(n_, (o_ as IEnumerable<string>));
				var q_ = FHIRHelpers_4_3_000.ToValue(Antithrombotic?.Effective);
				var r_ = QICoreCommon_2_0_000.toInterval(q_);
				var s_ = context.Operators.Start(r_);
				var t_ = CQMCommon_2_0_000.hospitalizationWithObservation(IschemicStrokeEncounter);
				var u_ = context.Operators.Start(t_);
				var v_ = TJCOverall_8_11_000.CalendarDayOfOrDayAfter(u_);
				var w_ = context.Operators.ConvertDateToDateTime(v_?.low);
				var y_ = context.Operators.Start(t_);
				var z_ = TJCOverall_8_11_000.CalendarDayOfOrDayAfter(y_);
				var aa_ = context.Operators.ConvertDateToDateTime(z_?.high);
				var ac_ = context.Operators.Start(t_);
				var ad_ = TJCOverall_8_11_000.CalendarDayOfOrDayAfter(ac_);
				var af_ = context.Operators.Start(t_);
				var ag_ = TJCOverall_8_11_000.CalendarDayOfOrDayAfter(af_);
				var ah_ = context.Operators.Interval(w_, aa_, ad_?.lowClosed, ag_?.highClosed);
				var ai_ = context.Operators.ElementInInterval<CqlDateTime>(s_, ah_, "day");
				var aj_ = context.Operators.And(p_, ai_);

				return aj_;
			};
			var j_ = context.Operators.WhereOrNull<MedicationAdministration>(h_, i_);
			Encounter k_(MedicationAdministration Antithrombotic) => 
				IschemicStrokeEncounter;
			var l_ = context.Operators.SelectOrNull<MedicationAdministration, Encounter>(j_, k_);

			return l_;
		};
		var c_ = context.Operators.SelectManyOrNull<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with Antithrombotic Therapy")]
	public IEnumerable<Encounter> Encounter_with_Antithrombotic_Therapy() => 
		__Encounter_with_Antithrombotic_Therapy.Value;

	private IEnumerable<Encounter> Numerator_Value()
	{
		var a_ = this.Encounter_with_Antithrombotic_Therapy();

		return a_;
	}

    [CqlDeclaration("Numerator")]
	public IEnumerable<Encounter> Numerator() => 
		__Numerator.Value;

	private IEnumerable<Tuples.Tuple_BbhTaZZjBaiJcUjLFAUQXXc> Reason_for_Not_Ordering_Antithrombotic_Value()
	{
		var a_ = this.Antithrombotic_Therapy_for_Ischemic_Stroke();
		var b_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		bool? c_(MedicationRequest NoAntithromboticOrder)
		{
			var g_ = context.Operators.EnumEqualsString(NoAntithromboticOrder?.StatusElement?.Value, "completed");
			var h_ = context.Operators.EnumEqualsString(NoAntithromboticOrder?.IntentElement?.Value, "order");
			var i_ = context.Operators.And(g_, h_);
			CqlConcept j_(CodeableConcept @this)
			{
				var t_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return t_;
			};
			var k_ = context.Operators.SelectOrNull<CodeableConcept, CqlConcept>(NoAntithromboticOrder?.ReasonCode, j_);
			var l_ = this.Medical_Reason_for_Not_Providing_Treatment();
			var m_ = context.Operators.ConceptsInValueSet(k_, l_);
			CqlConcept n_(CodeableConcept @this)
			{
				var u_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return u_;
			};
			var o_ = context.Operators.SelectOrNull<CodeableConcept, CqlConcept>(NoAntithromboticOrder?.ReasonCode, n_);
			var p_ = this.Patient_Refusal();
			var q_ = context.Operators.ConceptsInValueSet(o_, p_);
			var r_ = context.Operators.Or(m_, q_);
			var s_ = context.Operators.And(i_, r_);

			return s_;
		};
		var d_ = context.Operators.WhereOrNull<MedicationRequest>(b_, c_);
		Tuples.Tuple_BbhTaZZjBaiJcUjLFAUQXXc e_(MedicationRequest NoAntithromboticOrder)
		{
			var v_ = context.Operators.Convert<CqlDateTime>(NoAntithromboticOrder?.AuthoredOnElement);
			var w_ = new Tuples.Tuple_BbhTaZZjBaiJcUjLFAUQXXc
			{
				id = NoAntithromboticOrder?.IdElement?.Value,
				authoredOn = v_,
			};

			return w_;
		};
		var f_ = context.Operators.SelectOrNull<MedicationRequest, Tuples.Tuple_BbhTaZZjBaiJcUjLFAUQXXc>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Reason for Not Ordering Antithrombotic")]
	public IEnumerable<Tuples.Tuple_BbhTaZZjBaiJcUjLFAUQXXc> Reason_for_Not_Ordering_Antithrombotic() => 
		__Reason_for_Not_Ordering_Antithrombotic.Value;

	private IEnumerable<Tuples.Tuple_BbhTaZZjBaiJcUjLFAUQXXc> Reason_for_Not_Administering_Antithrombotic_Value()
	{
		var a_ = this.Antithrombotic_Therapy_for_Ischemic_Stroke();
		var b_ = context.Operators.RetrieveByValueSet<MedicationAdministration>(a_, null);
		bool? c_(MedicationAdministration MedicationAdm)
		{
			CqlConcept g_(CodeableConcept @this)
			{
				var p_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return p_;
			};
			var h_ = context.Operators.SelectOrNull<CodeableConcept, CqlConcept>(MedicationAdm?.StatusReason, g_);
			var i_ = this.Medical_Reason_for_Not_Providing_Treatment();
			var j_ = context.Operators.ConceptsInValueSet(h_, i_);
			CqlConcept k_(CodeableConcept @this)
			{
				var q_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return q_;
			};
			var l_ = context.Operators.SelectOrNull<CodeableConcept, CqlConcept>(MedicationAdm?.StatusReason, k_);
			var m_ = this.Patient_Refusal();
			var n_ = context.Operators.ConceptsInValueSet(l_, m_);
			var o_ = context.Operators.Or(j_, n_);

			return o_;
		};
		var d_ = context.Operators.WhereOrNull<MedicationAdministration>(b_, c_);
		Tuples.Tuple_BbhTaZZjBaiJcUjLFAUQXXc e_(MedicationAdministration MedicationAdm)
		{
			var r_ = context.Operators.Now();
			var s_ = new Tuples.Tuple_BbhTaZZjBaiJcUjLFAUQXXc
			{
				id = MedicationAdm?.IdElement?.Value,
				authoredOn = r_,
			};

			return s_;
		};
		var f_ = context.Operators.SelectOrNull<MedicationAdministration, Tuples.Tuple_BbhTaZZjBaiJcUjLFAUQXXc>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Reason for Not Administering Antithrombotic")]
	public IEnumerable<Tuples.Tuple_BbhTaZZjBaiJcUjLFAUQXXc> Reason_for_Not_Administering_Antithrombotic() => 
		__Reason_for_Not_Administering_Antithrombotic.Value;

	private IEnumerable<Tuples.Tuple_BbhTaZZjBaiJcUjLFAUQXXc> Documented_Reason_for_No_Antithrombotic_Ordered_or_Administered_Value()
	{
		var a_ = this.Reason_for_Not_Ordering_Antithrombotic();
		var b_ = this.Reason_for_Not_Administering_Antithrombotic();
		var c_ = context.Operators.ListUnion<Tuples.Tuple_BbhTaZZjBaiJcUjLFAUQXXc>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Documented Reason for No Antithrombotic Ordered or Administered")]
	public IEnumerable<Tuples.Tuple_BbhTaZZjBaiJcUjLFAUQXXc> Documented_Reason_for_No_Antithrombotic_Ordered_or_Administered() => 
		__Documented_Reason_for_No_Antithrombotic_Ordered_or_Administered.Value;

	private IEnumerable<Encounter> Encounter_with_Documented_Reason_for_No_Antithrombotic_Ordered_or_Administered_Day_Of_or_Day_After_Hospital_Arrival_Value()
	{
		var a_ = TJCOverall_8_11_000.Ischemic_Stroke_Encounter();
		IEnumerable<Encounter> b_(Encounter IschemicStrokeEncounter)
		{
			var d_ = this.Documented_Reason_for_No_Antithrombotic_Ordered_or_Administered();
			bool? e_(Tuples.Tuple_BbhTaZZjBaiJcUjLFAUQXXc NoAntithrombotic)
			{
				var i_ = CQMCommon_2_0_000.hospitalizationWithObservation(IschemicStrokeEncounter);
				var j_ = context.Operators.Start(i_);
				var k_ = TJCOverall_8_11_000.CalendarDayOfOrDayAfter(j_);
				var l_ = context.Operators.ConvertDateToDateTime(k_?.low);
				var n_ = context.Operators.Start(i_);
				var o_ = TJCOverall_8_11_000.CalendarDayOfOrDayAfter(n_);
				var p_ = context.Operators.ConvertDateToDateTime(o_?.high);
				var r_ = context.Operators.Start(i_);
				var s_ = TJCOverall_8_11_000.CalendarDayOfOrDayAfter(r_);
				var u_ = context.Operators.Start(i_);
				var v_ = TJCOverall_8_11_000.CalendarDayOfOrDayAfter(u_);
				var w_ = context.Operators.Interval(l_, p_, s_?.lowClosed, v_?.highClosed);
				var x_ = context.Operators.ElementInInterval<CqlDateTime>(NoAntithrombotic?.authoredOn, w_, "day");

				return x_;
			};
			var f_ = context.Operators.WhereOrNull<Tuples.Tuple_BbhTaZZjBaiJcUjLFAUQXXc>(d_, e_);
			Encounter g_(Tuples.Tuple_BbhTaZZjBaiJcUjLFAUQXXc NoAntithrombotic) => 
				IschemicStrokeEncounter;
			var h_ = context.Operators.SelectOrNull<Tuples.Tuple_BbhTaZZjBaiJcUjLFAUQXXc, Encounter>(f_, g_);

			return h_;
		};
		var c_ = context.Operators.SelectManyOrNull<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with Documented Reason for No Antithrombotic Ordered or Administered Day Of or Day After Hospital Arrival")]
	public IEnumerable<Encounter> Encounter_with_Documented_Reason_for_No_Antithrombotic_Ordered_or_Administered_Day_Of_or_Day_After_Hospital_Arrival() => 
		__Encounter_with_Documented_Reason_for_No_Antithrombotic_Ordered_or_Administered_Day_Of_or_Day_After_Hospital_Arrival.Value;

	private IEnumerable<Encounter> Encounter_with_Pharmacological_Contraindications_for_Antithrombotic_Therapy_Given_Day_Of_or_Day_After_Hospital_Arrival_Value()
	{
		var a_ = TJCOverall_8_11_000.Ischemic_Stroke_Encounter();
		IEnumerable<Encounter> b_(Encounter IschemicStrokeEncounter)
		{
			var d_ = this.Pharmacological_Contraindications_For_Antithrombotic_Therapy();
			var e_ = context.Operators.RetrieveByValueSet<MedicationAdministration>(d_, null);
			var g_ = context.Operators.RetrieveByValueSet<MedicationAdministration>(d_, null);
			var h_ = context.Operators.ListUnion<MedicationAdministration>(e_, g_);
			bool? i_(MedicationAdministration PharmacologicalContraindications)
			{
				var m_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(PharmacologicalContraindications?.StatusElement?.Value);
				var n_ = context.Operators.Convert<string>(m_);
				var o_ = new string[]
				{
					"in-progress",
					"completed",
				};
				var p_ = context.Operators.InList<string>(n_, (o_ as IEnumerable<string>));
				var q_ = FHIRHelpers_4_3_000.ToValue(PharmacologicalContraindications?.Effective);
				var r_ = QICoreCommon_2_0_000.toInterval(q_);
				var s_ = context.Operators.Start(r_);
				var t_ = CQMCommon_2_0_000.hospitalizationWithObservation(IschemicStrokeEncounter);
				var u_ = context.Operators.Start(t_);
				var v_ = TJCOverall_8_11_000.CalendarDayOfOrDayAfter(u_);
				var w_ = context.Operators.ConvertDateToDateTime(v_?.low);
				var y_ = context.Operators.Start(t_);
				var z_ = TJCOverall_8_11_000.CalendarDayOfOrDayAfter(y_);
				var aa_ = context.Operators.ConvertDateToDateTime(z_?.high);
				var ac_ = context.Operators.Start(t_);
				var ad_ = TJCOverall_8_11_000.CalendarDayOfOrDayAfter(ac_);
				var af_ = context.Operators.Start(t_);
				var ag_ = TJCOverall_8_11_000.CalendarDayOfOrDayAfter(af_);
				var ah_ = context.Operators.Interval(w_, aa_, ad_?.lowClosed, ag_?.highClosed);
				var ai_ = context.Operators.ElementInInterval<CqlDateTime>(s_, ah_, "day");
				var aj_ = context.Operators.And(p_, ai_);

				return aj_;
			};
			var j_ = context.Operators.WhereOrNull<MedicationAdministration>(h_, i_);
			Encounter k_(MedicationAdministration PharmacologicalContraindications) => 
				IschemicStrokeEncounter;
			var l_ = context.Operators.SelectOrNull<MedicationAdministration, Encounter>(j_, k_);

			return l_;
		};
		var c_ = context.Operators.SelectManyOrNull<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with Pharmacological Contraindications for Antithrombotic Therapy Given Day Of or Day After Hospital Arrival")]
	public IEnumerable<Encounter> Encounter_with_Pharmacological_Contraindications_for_Antithrombotic_Therapy_Given_Day_Of_or_Day_After_Hospital_Arrival() => 
		__Encounter_with_Pharmacological_Contraindications_for_Antithrombotic_Therapy_Given_Day_Of_or_Day_After_Hospital_Arrival.Value;

	private IEnumerable<Encounter> Encounter_with_An_INR_Greater_Than_3_5_Value()
	{
		var a_ = TJCOverall_8_11_000.Ischemic_Stroke_Encounter();
		IEnumerable<Encounter> b_(Encounter IschemicStrokeEncounter)
		{
			var d_ = this.INR();
			var e_ = context.Operators.RetrieveByValueSet<Observation>(d_, null);
			bool? f_(Observation INR)
			{
				var j_ = FHIRHelpers_4_3_000.ToValue(INR?.Value);
				var k_ = context.Operators.ConvertDecimalToQuantity((decimal?)3.5m);
				var l_ = context.Operators.Greater((j_ as CqlQuantity), k_);
				var m_ = context.Operators.Convert<Code<ObservationStatus>>(INR?.StatusElement?.Value);
				var n_ = context.Operators.Convert<string>(m_);
				var o_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var p_ = context.Operators.InList<string>(n_, (o_ as IEnumerable<string>));
				var q_ = context.Operators.And(l_, p_);
				var r_ = context.Operators.Convert<CqlDateTime>(INR?.IssuedElement?.Value);
				var s_ = CQMCommon_2_0_000.hospitalizationWithObservation(IschemicStrokeEncounter);
				var t_ = context.Operators.Start(s_);
				var u_ = TJCOverall_8_11_000.CalendarDayOfOrDayAfter(t_);
				var v_ = context.Operators.ConvertDateToDateTime(u_?.low);
				var x_ = context.Operators.Start(s_);
				var y_ = TJCOverall_8_11_000.CalendarDayOfOrDayAfter(x_);
				var z_ = context.Operators.ConvertDateToDateTime(y_?.high);
				var ab_ = context.Operators.Start(s_);
				var ac_ = TJCOverall_8_11_000.CalendarDayOfOrDayAfter(ab_);
				var ae_ = context.Operators.Start(s_);
				var af_ = TJCOverall_8_11_000.CalendarDayOfOrDayAfter(ae_);
				var ag_ = context.Operators.Interval(v_, z_, ac_?.lowClosed, af_?.highClosed);
				var ah_ = context.Operators.ElementInInterval<CqlDateTime>(r_, ag_, "day");
				var ai_ = context.Operators.And(q_, ah_);

				return ai_;
			};
			var g_ = context.Operators.WhereOrNull<Observation>(e_, f_);
			Encounter h_(Observation INR) => 
				IschemicStrokeEncounter;
			var i_ = context.Operators.SelectOrNull<Observation, Encounter>(g_, h_);

			return i_;
		};
		var c_ = context.Operators.SelectManyOrNull<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with An INR Greater Than 3.5")]
	public IEnumerable<Encounter> Encounter_with_An_INR_Greater_Than_3_5() => 
		__Encounter_with_An_INR_Greater_Than_3_5.Value;

	private IEnumerable<Encounter> Denominator_Exceptions_Value()
	{
		var a_ = this.Encounter_with_Documented_Reason_for_No_Antithrombotic_Ordered_or_Administered_Day_Of_or_Day_After_Hospital_Arrival();
		var b_ = this.Encounter_with_Pharmacological_Contraindications_for_Antithrombotic_Therapy_Given_Day_Of_or_Day_After_Hospital_Arrival();
		var c_ = context.Operators.ListUnion<Encounter>(a_, b_);
		var d_ = this.Encounter_with_An_INR_Greater_Than_3_5();
		var e_ = context.Operators.ListUnion<Encounter>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Denominator Exceptions")]
	public IEnumerable<Encounter> Denominator_Exceptions() => 
		__Denominator_Exceptions.Value;

	private Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Ethnicity_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private IEnumerable<Tuples.Tuple_GDKRbfOIHhLGieQSVDEMIaDPX> SDE_Payer_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<Tuples.Tuple_GDKRbfOIHhLGieQSVDEMIaDPX> SDE_Payer() => 
		__SDE_Payer.Value;

	private Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Race_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Race() => 
		__SDE_Race.Value;

	private CqlCode SDE_Sex_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Sex();

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex() => 
		__SDE_Sex.Value;

}