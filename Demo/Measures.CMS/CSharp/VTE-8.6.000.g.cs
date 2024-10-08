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
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.263", default);

    [CqlDeclaration("Obstetrical or Pregnancy Related Conditions")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.263")]
	public CqlValueSet Obstetrical_or_Pregnancy_Related_Conditions() => 
		__Obstetrical_or_Pregnancy_Related_Conditions.Value;

	private CqlValueSet Obstetrics_VTE_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.264", default);

    [CqlDeclaration("Obstetrics VTE")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.264")]
	public CqlValueSet Obstetrics_VTE() => 
		__Obstetrics_VTE.Value;

	private CqlValueSet Venous_Thromboembolism_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.279", default);

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
		IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
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
				CodeableConcept i_ = EncDx?.Code;
				CqlConcept j_ = FHIRHelpers_4_3_000.ToConcept(i_);
				CqlValueSet k_ = this.Obstetrical_or_Pregnancy_Related_Conditions();
				bool? l_ = context.Operators.ConceptInValueSet(j_, k_);
				CqlConcept n_ = FHIRHelpers_4_3_000.ToConcept(i_);
				CqlValueSet o_ = this.Venous_Thromboembolism();
				bool? p_ = context.Operators.ConceptInValueSet(n_, o_);
				bool? q_ = context.Operators.Or(l_, p_);
				CqlConcept s_ = FHIRHelpers_4_3_000.ToConcept(i_);
				CqlValueSet t_ = this.Obstetrics_VTE();
				bool? u_ = context.Operators.ConceptInValueSet(s_, t_);
				bool? v_ = context.Operators.Or(q_, u_);

				return v_;
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
			Date g_ = f_?.BirthDateElement;
			string h_ = g_?.Value;
			CqlDate i_ = context.Operators.ConvertStringToDate(h_);
			Period j_ = InpatientEncounter?.Period;
			CqlInterval<CqlDateTime> k_ = FHIRHelpers_4_3_000.ToInterval(j_);
			CqlDateTime l_ = context.Operators.Start(k_);
			CqlDate m_ = context.Operators.DateFrom(l_);
			int? n_ = context.Operators.CalculateAgeAt(i_, m_, "year");
			bool? o_ = context.Operators.GreaterOrEqual(n_, 18);

			return o_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
		IEnumerable<Encounter> d_ = this.Admission_without_VTE_or_Obstetrical_Conditions();
		IEnumerable<Encounter> e_ = context.Operators.Intersect<Encounter>(c_, d_);

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
		Period d_ = Encounter?.Period;
		CqlInterval<CqlDateTime> e_ = FHIRHelpers_4_3_000.ToInterval(d_);
		CqlDateTime f_ = context.Operators.Start(e_);
		CqlDate g_ = context.Operators.DateFrom(f_);
		CqlQuantity h_ = context.Operators.Quantity(1m, "days");
		CqlDate i_ = context.Operators.Add(g_, h_);
		CqlInterval<CqlDate> j_ = context.Operators.Interval(c_, i_, true, true);

		return j_;
	}

    [CqlDeclaration("StartOfFirstICU")]
	public CqlDateTime StartOfFirstICU(Encounter Encounter)
	{
		Encounter.LocationComponent a_ = CQMCommon_2_0_000.firstInpatientIntensiveCareUnit(Encounter);
		Period b_ = a_?.Period;
		CqlInterval<CqlDateTime> c_ = FHIRHelpers_4_3_000.ToInterval(b_);
		CqlDateTime d_ = context.Operators.Start(c_);

		return d_;
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
