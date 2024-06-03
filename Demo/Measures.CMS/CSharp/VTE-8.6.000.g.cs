using System;
using Tuples;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using System.Reflection;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.0.0")]
[CqlLibrary("VTE", "8.6.000")]
public class VTE_8_6_000
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Obstetrical_or_Pregnancy_Related_Conditions;
    internal Lazy<CqlValueSet> __Obstetrics_VTE;
    internal Lazy<CqlValueSet> __Venous_Thromboembolism;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<IEnumerable<Encounter>> __Admission_without_VTE_or_Obstetrical_Conditions;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_Age_Range_and_without_VTE_Diagnosis_or_Obstetrical_Conditions;
    internal Lazy<IEnumerable<Encounter>> __Initial_Population;

    #endregion
    public VTE_8_6_000(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_3_000 = new FHIRHelpers_4_3_000(context);
        CQMCommon_2_0_000 = new CQMCommon_2_0_000(context);

        __Obstetrical_or_Pregnancy_Related_Conditions = new Lazy<CqlValueSet>(this.Obstetrical_or_Pregnancy_Related_Conditions_Value);
        __Obstetrics_VTE = new Lazy<CqlValueSet>(this.Obstetrics_VTE_Value);
        __Venous_Thromboembolism = new Lazy<CqlValueSet>(this.Venous_Thromboembolism_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __Admission_without_VTE_or_Obstetrical_Conditions = new Lazy<IEnumerable<Encounter>>(this.Admission_without_VTE_or_Obstetrical_Conditions_Value);
        __Encounter_with_Age_Range_and_without_VTE_Diagnosis_or_Obstetrical_Conditions = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_Age_Range_and_without_VTE_Diagnosis_or_Obstetrical_Conditions_Value);
        __Initial_Population = new Lazy<IEnumerable<Encounter>>(this.Initial_Population_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_3_000 FHIRHelpers_4_3_000 { get; }
    public CQMCommon_2_0_000 CQMCommon_2_0_000 { get; }

    #endregion

	private CqlValueSet Obstetrical_or_Pregnancy_Related_Conditions_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.263", null);

    [CqlDeclaration("Obstetrical or Pregnancy Related Conditions")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.263")]
	public CqlValueSet Obstetrical_or_Pregnancy_Related_Conditions() => 
		__Obstetrical_or_Pregnancy_Related_Conditions.Value;

	private CqlValueSet Obstetrics_VTE_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.264", null);

    [CqlDeclaration("Obstetrics VTE")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.264")]
	public CqlValueSet Obstetrics_VTE() => 
		__Obstetrics_VTE.Value;

	private CqlValueSet Venous_Thromboembolism_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.279", null);

    [CqlDeclaration("Venous Thromboembolism")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.279")]
	public CqlValueSet Venous_Thromboembolism() => 
		__Venous_Thromboembolism.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.ResolveParameter("VTE-8.6.000", "Measurement Period", null);

		return (CqlInterval<CqlDateTime>)a_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period.Value;

	private Patient Patient_Value()
	{
		var a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		var b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private IEnumerable<Encounter> Admission_without_VTE_or_Obstetrical_Conditions_Value()
	{
		var a_ = CQMCommon_2_0_000.Inpatient_Encounter();
		bool? b_(Encounter InpatientEncounter)
		{
			var d_ = CQMCommon_2_0_000.encounterDiagnosis(InpatientEncounter);
			bool? e_(Condition EncDx)
			{
				var i_ = EncDx?.Code;
				var j_ = FHIRHelpers_4_3_000.ToConcept(i_);
				var k_ = this.Obstetrical_or_Pregnancy_Related_Conditions();
				var l_ = context.Operators.ConceptInValueSet(j_, k_);
				var n_ = FHIRHelpers_4_3_000.ToConcept(i_);
				var o_ = this.Venous_Thromboembolism();
				var p_ = context.Operators.ConceptInValueSet(n_, o_);
				var q_ = context.Operators.Or(l_, p_);
				var s_ = FHIRHelpers_4_3_000.ToConcept(i_);
				var t_ = this.Obstetrics_VTE();
				var u_ = context.Operators.ConceptInValueSet(s_, t_);
				var v_ = context.Operators.Or(q_, u_);

				return v_;
			};
			var f_ = context.Operators.Where<Condition>(d_, e_);
			var g_ = context.Operators.Exists<Condition>(f_);
			var h_ = context.Operators.Not(g_);

			return h_;
		};
		var c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Admission without VTE or Obstetrical Conditions")]
	public IEnumerable<Encounter> Admission_without_VTE_or_Obstetrical_Conditions() => 
		__Admission_without_VTE_or_Obstetrical_Conditions.Value;

	private IEnumerable<Encounter> Encounter_with_Age_Range_and_without_VTE_Diagnosis_or_Obstetrical_Conditions_Value()
	{
		var a_ = CQMCommon_2_0_000.Inpatient_Encounter();
		bool? b_(Encounter InpatientEncounter)
		{
			var f_ = this.Patient();
			var g_ = f_?.BirthDateElement;
			var h_ = g_?.Value;
			var i_ = context.Operators.Convert<CqlDate>(h_);
			var j_ = InpatientEncounter?.Period;
			var k_ = FHIRHelpers_4_3_000.ToInterval(j_);
			var l_ = context.Operators.Start(k_);
			var m_ = context.Operators.DateFrom(l_);
			var n_ = context.Operators.CalculateAgeAt(i_, m_, "year");
			var o_ = context.Operators.GreaterOrEqual(n_, 18);

			return o_;
		};
		var c_ = context.Operators.Where<Encounter>(a_, b_);
		var d_ = this.Admission_without_VTE_or_Obstetrical_Conditions();
		var e_ = context.Operators.Intersect<Encounter>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Encounter with Age Range and without VTE Diagnosis or Obstetrical Conditions")]
	public IEnumerable<Encounter> Encounter_with_Age_Range_and_without_VTE_Diagnosis_or_Obstetrical_Conditions() => 
		__Encounter_with_Age_Range_and_without_VTE_Diagnosis_or_Obstetrical_Conditions.Value;

	private IEnumerable<Encounter> Initial_Population_Value()
	{
		var a_ = this.Encounter_with_Age_Range_and_without_VTE_Diagnosis_or_Obstetrical_Conditions();

		return a_;
	}

    [CqlDeclaration("Initial Population")]
	public IEnumerable<Encounter> Initial_Population() => 
		__Initial_Population.Value;

    [CqlDeclaration("FromDayOfStartOfHospitalizationToDayAfterAdmission")]
	public CqlInterval<CqlDate> FromDayOfStartOfHospitalizationToDayAfterAdmission(Encounter Encounter)
	{
		var a_ = CQMCommon_2_0_000.hospitalizationWithObservation(Encounter);
		var b_ = context.Operators.Start(a_);
		var c_ = context.Operators.DateFrom(b_);
		var d_ = FHIRHelpers_4_3_000.ToInterval(Encounter?.Period);
		var e_ = context.Operators.Start(d_);
		var f_ = context.Operators.DateFrom(e_);
		var g_ = context.Operators.Quantity(1m, "days");
		var h_ = context.Operators.Add(f_, g_);
		var i_ = context.Operators.Interval(c_, h_, true, true);

		return i_;
	}

    [CqlDeclaration("StartOfFirstICU")]
	public CqlDateTime StartOfFirstICU(Encounter Encounter)
	{
		var a_ = CQMCommon_2_0_000.firstInpatientIntensiveCareUnit(Encounter);
		var b_ = FHIRHelpers_4_3_000.ToInterval(a_?.Period);
		var c_ = context.Operators.Start(b_);

		return c_;
	}

    [CqlDeclaration("FromDayOfStartOfHospitalizationToDayAfterFirstICU")]
	public CqlInterval<CqlDate> FromDayOfStartOfHospitalizationToDayAfterFirstICU(Encounter Encounter)
	{
		var a_ = CQMCommon_2_0_000.hospitalizationWithObservation(Encounter);
		var b_ = context.Operators.Start(a_);
		var c_ = context.Operators.DateFrom(b_);
		var d_ = this.StartOfFirstICU(Encounter);
		var e_ = context.Operators.DateFrom(d_);
		var f_ = context.Operators.Quantity(1m, "day");
		var g_ = context.Operators.Add(e_, f_);
		var h_ = context.Operators.Interval(c_, g_, true, true);

		return h_;
	}

}
