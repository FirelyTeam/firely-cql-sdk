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
		object a_ = context.ResolveParameter("VTE-8.6.000", "Measurement Period", null);

		return (CqlInterval<CqlDateTime>)a_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period.Value;

	private Patient Patient_Value()
	{
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private IEnumerable<Encounter> Admission_without_VTE_or_Obstetrical_Conditions_Value()
	{
		IEnumerable<Encounter> a_ = CQMCommon_2_0_000.Inpatient_Encounter();
		bool? b_(Encounter InpatientEncounter)
		{
			IEnumerable<Condition> d_ = CQMCommon_2_0_000.encounterDiagnosis(InpatientEncounter);
			bool? e_(Condition EncDx)
			{
				CqlConcept i_ = FHIRHelpers_4_3_000.ToConcept(EncDx?.Code);
				CqlValueSet j_ = this.Obstetrical_or_Pregnancy_Related_Conditions();
				bool? k_ = context.Operators.ConceptInValueSet(i_, j_);
				CqlValueSet m_ = this.Venous_Thromboembolism();
				bool? n_ = context.Operators.ConceptInValueSet(i_, m_);
				bool? o_ = context.Operators.Or(k_, n_);
				CqlValueSet q_ = this.Obstetrics_VTE();
				bool? r_ = context.Operators.ConceptInValueSet(i_, q_);
				bool? s_ = context.Operators.Or(o_, r_);

				return s_;
			};
			IEnumerable<Condition> f_ = context.Operators.Where<Condition>(d_, e_);
			bool? g_ = context.Operators.Exists<Condition>(f_);
			bool? h_ = context.Operators.Not(g_);

			return h_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Admission without VTE or Obstetrical Conditions")]
	public IEnumerable<Encounter> Admission_without_VTE_or_Obstetrical_Conditions() => 
		__Admission_without_VTE_or_Obstetrical_Conditions.Value;

	private IEnumerable<Encounter> Encounter_with_Age_Range_and_without_VTE_Diagnosis_or_Obstetrical_Conditions_Value()
	{
		IEnumerable<Encounter> a_ = CQMCommon_2_0_000.Inpatient_Encounter();
		bool? b_(Encounter InpatientEncounter)
		{
			Patient f_ = this.Patient();
			CqlDate g_ = context.Operators.Convert<CqlDate>(f_?.BirthDateElement?.Value);
			CqlInterval<CqlDateTime> h_ = FHIRHelpers_4_3_000.ToInterval(InpatientEncounter?.Period);
			CqlDateTime i_ = context.Operators.Start(h_);
			CqlDate j_ = context.Operators.DateFrom(i_);
			int? k_ = context.Operators.CalculateAgeAt(g_, j_, "year");
			bool? l_ = context.Operators.GreaterOrEqual(k_, 18);

			return l_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
		IEnumerable<Encounter> d_ = this.Admission_without_VTE_or_Obstetrical_Conditions();
		IEnumerable<Encounter> e_ = context.Operators.ListIntersect<Encounter>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Encounter with Age Range and without VTE Diagnosis or Obstetrical Conditions")]
	public IEnumerable<Encounter> Encounter_with_Age_Range_and_without_VTE_Diagnosis_or_Obstetrical_Conditions() => 
		__Encounter_with_Age_Range_and_without_VTE_Diagnosis_or_Obstetrical_Conditions.Value;

	private IEnumerable<Encounter> Initial_Population_Value()
	{
		IEnumerable<Encounter> a_ = this.Encounter_with_Age_Range_and_without_VTE_Diagnosis_or_Obstetrical_Conditions();

		return a_;
	}

    [CqlDeclaration("Initial Population")]
	public IEnumerable<Encounter> Initial_Population() => 
		__Initial_Population.Value;

    [CqlDeclaration("FromDayOfStartOfHospitalizationToDayAfterAdmission")]
	public CqlInterval<CqlDate> FromDayOfStartOfHospitalizationToDayAfterAdmission(Encounter Encounter)
	{
		CqlInterval<CqlDateTime> a_ = CQMCommon_2_0_000.hospitalizationWithObservation(Encounter);
		CqlDateTime b_ = context.Operators.Start(a_);
		CqlDate c_ = context.Operators.DateFrom(b_);
		CqlInterval<CqlDateTime> d_ = FHIRHelpers_4_3_000.ToInterval(Encounter?.Period);
		CqlDateTime e_ = context.Operators.Start(d_);
		CqlDate f_ = context.Operators.DateFrom(e_);
		CqlQuantity g_ = context.Operators.Quantity(1m, "days");
		CqlDate h_ = context.Operators.Add(f_, g_);
		CqlInterval<CqlDate> i_ = context.Operators.Interval(c_, h_, true, true);

		return i_;
	}

    [CqlDeclaration("StartOfFirstICU")]
	public CqlDateTime StartOfFirstICU(Encounter Encounter)
	{
		Encounter.LocationComponent a_ = CQMCommon_2_0_000.firstInpatientIntensiveCareUnit(Encounter);
		CqlInterval<CqlDateTime> b_ = FHIRHelpers_4_3_000.ToInterval(a_?.Period);
		CqlDateTime c_ = context.Operators.Start(b_);

		return c_;
	}

    [CqlDeclaration("FromDayOfStartOfHospitalizationToDayAfterFirstICU")]
	public CqlInterval<CqlDate> FromDayOfStartOfHospitalizationToDayAfterFirstICU(Encounter Encounter)
	{
		CqlInterval<CqlDateTime> a_ = CQMCommon_2_0_000.hospitalizationWithObservation(Encounter);
		CqlDateTime b_ = context.Operators.Start(a_);
		CqlDate c_ = context.Operators.DateFrom(b_);
		CqlDateTime d_ = this.StartOfFirstICU(Encounter);
		CqlDate e_ = context.Operators.DateFrom(d_);
		CqlQuantity f_ = context.Operators.Quantity(1m, "day");
		CqlDate g_ = context.Operators.Add(e_, f_);
		CqlInterval<CqlDate> h_ = context.Operators.Interval(c_, g_, true, true);

		return h_;
	}

}
