using System;
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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.5.0")]
[CqlLibrary("AntidepressantMedicationManagementFHIR", "0.1.000")]
public partial class AntidepressantMedicationManagementFHIR_0_1_000 : ILibrary, ISingleton<AntidepressantMedicationManagementFHIR_0_1_000>
{
    private AntidepressantMedicationManagementFHIR_0_1_000() {}

    public static AntidepressantMedicationManagementFHIR_0_1_000 Instance { get; } = new();

    #region Library Members
    public string Name => "AntidepressantMedicationManagementFHIR";
    public string Version => "0.1.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_3_000.Instance, SupplementalDataElements_3_4_000.Instance, Hospice_6_9_000.Instance, CumulativeMedicationDuration_4_0_000.Instance, Status_1_6_000.Instance, QICoreCommon_2_0_000.Instance, CQMCommon_2_0_000.Instance];
    #endregion Library Members

    [CqlDeclaration("Annual Wellness Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240")]
	public CqlValueSet Annual_Wellness_Visit(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", default);


    [CqlDeclaration("Antidepressant Medication")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1213")]
	public CqlValueSet Antidepressant_Medication(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1213", default);


    [CqlDeclaration("Home Healthcare Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016")]
	public CqlValueSet Home_Healthcare_Services(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", default);


    [CqlDeclaration("Major Depression")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1007")]
	public CqlValueSet Major_Depression(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1007", default);


    [CqlDeclaration("Nursing Facility Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012")]
	public CqlValueSet Nursing_Facility_Visit(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012", default);


    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
	public CqlValueSet Office_Visit(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", default);


    [CqlDeclaration("Online Assessments")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089")]
	public CqlValueSet Online_Assessments(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", default);


    [CqlDeclaration("Preventive Care Services Established Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025")]
	public CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", default);


    [CqlDeclaration("Preventive Care Services Initial Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023")]
	public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", default);


    [CqlDeclaration("Psych Visit Diagnostic Evaluation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1492")]
	public CqlValueSet Psych_Visit_Diagnostic_Evaluation(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1492", default);


    [CqlDeclaration("Psych Visit Psychotherapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1496")]
	public CqlValueSet Psych_Visit_Psychotherapy(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1496", default);


    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
	public CqlValueSet Telephone_Visits(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", default);


    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
	{
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("AntidepressantMedicationManagementFHIR-0.1.000", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
	}


    [CqlDeclaration("Patient")]
	public Patient Patient(CqlContext context)
	{
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(default, default);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}


    [CqlDeclaration("April 30 of the Measurement Period")]
	public CqlDateTime April_30_of_the_Measurement_Period(CqlContext context)
	{
		CqlInterval<CqlDateTime> a_ = this.Measurement_Period(context);
		CqlDateTime b_ = context.Operators.Start(a_);
		int? c_ = context.Operators.DateTimeComponentFrom(b_, "year");
		decimal? d_ = context.Operators.ConvertIntegerToDecimal(0);
		CqlDateTime e_ = context.Operators.DateTime(c_, 4, 30, 23, 59, 59, 0, d_);

		return e_;
	}


    [CqlDeclaration("May 1 of the Year Prior to the Measurement Period")]
	public CqlDateTime May_1_of_the_Year_Prior_to_the_Measurement_Period(CqlContext context)
	{
		CqlInterval<CqlDateTime> a_ = this.Measurement_Period(context);
		CqlDateTime b_ = context.Operators.Start(a_);
		int? c_ = context.Operators.DateTimeComponentFrom(b_, "year");
		int? d_ = context.Operators.Subtract(c_, 1);
		decimal? e_ = context.Operators.ConvertIntegerToDecimal(0);
		CqlDateTime f_ = context.Operators.DateTime(d_, 5, 1, 0, 0, 0, 0, e_);

		return f_;
	}


    [CqlDeclaration("Intake Period")]
	public CqlInterval<CqlDateTime> Intake_Period(CqlContext context)
	{
		CqlDateTime a_ = this.May_1_of_the_Year_Prior_to_the_Measurement_Period(context);
		CqlDateTime b_ = this.April_30_of_the_Measurement_Period(context);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, true);

		return c_;
	}


    [CqlDeclaration("Earliest Antidepressant Dispensed During Intake Period")]
	public CqlDate Earliest_Antidepressant_Dispensed_During_Intake_Period(CqlContext context)
	{
		CqlValueSet a_ = this.Antidepressant_Medication(context);
		IEnumerable<MedicationDispense> b_ = context.Operators.RetrieveByValueSet<MedicationDispense>(a_, default);
		IEnumerable<MedicationDispense> d_ = context.Operators.RetrieveByValueSet<MedicationDispense>(a_, default);
		IEnumerable<MedicationDispense> e_ = context.Operators.Union<MedicationDispense>(b_, d_);
		IEnumerable<MedicationDispense> f_ = Status_1_6_000.Instance.Dispensed_Medication(context, e_);
		bool? g_(MedicationDispense Antidepressant)
		{
			CqlInterval<CqlDate> o_ = CumulativeMedicationDuration_4_0_000.Instance.MedicationDispensePeriod(context, Antidepressant);
			CqlDate p_ = context.Operators.Start(o_);
			CqlDateTime q_ = context.Operators.ConvertDateToDateTime(p_);
			CqlInterval<CqlDateTime> r_ = this.Intake_Period(context);
			bool? s_ = context.Operators.In<CqlDateTime>(q_, r_, "day");

			return s_;
		};
		IEnumerable<MedicationDispense> h_ = context.Operators.Where<MedicationDispense>(f_, g_);
		(CqlDate AntidepressantDate, nint _)? i_(MedicationDispense Antidepressant)
		{
			CqlInterval<CqlDate> t_ = CumulativeMedicationDuration_4_0_000.Instance.MedicationDispensePeriod(context, Antidepressant);
			CqlDate u_ = context.Operators.Start(t_);
			CqlDateTime v_ = context.Operators.ConvertDateToDateTime(u_);
			CqlDate w_ = context.Operators.DateFrom(v_);
			(CqlDate AntidepressantDate, nint _)? x_ = (w_, default);

			return x_;
		};
		IEnumerable<(CqlDate AntidepressantDate, nint _)?> j_ = context.Operators.Select<MedicationDispense, (CqlDate AntidepressantDate, nint _)?>(h_, i_);
		object k_((CqlDate AntidepressantDate, nint _)? @this)
		{
			CqlDate y_ = @this?.AntidepressantDate;

			return y_;
		};
		IEnumerable<(CqlDate AntidepressantDate, nint _)?> l_ = context.Operators.SortBy<(CqlDate AntidepressantDate, nint _)?>(j_, k_, System.ComponentModel.ListSortDirection.Ascending);
		(CqlDate AntidepressantDate, nint _)? m_ = context.Operators.First<(CqlDate AntidepressantDate, nint _)?>(l_);
		CqlDate n_ = m_?.AntidepressantDate;

		return n_;
	}


    [CqlDeclaration("Has Initial Major Depression Diagnosis")]
	public bool? Has_Initial_Major_Depression_Diagnosis(CqlContext context)
	{
		CqlValueSet a_ = this.Major_Depression(context);
		IEnumerable<Condition> b_ = context.Operators.RetrieveByValueSet<Condition>(a_, default);
		bool? c_(Condition MajorDepression)
		{
			CqlDate f_ = this.Earliest_Antidepressant_Dispensed_During_Intake_Period(context);
			bool? g_ = context.Operators.Not((bool?)(f_ is null));
			CqlInterval<CqlDateTime> h_ = QICoreCommon_2_0_000.Instance.ToPrevalenceInterval(context, MajorDepression);
			CqlDateTime i_ = context.Operators.Start(h_);
			CqlDate j_ = context.Operators.DateFrom(i_);
			CqlQuantity l_ = context.Operators.Quantity(60m, "days");
			CqlDate m_ = context.Operators.Subtract(f_, l_);
			CqlDate p_ = context.Operators.Add(f_, l_);
			CqlInterval<CqlDate> q_ = context.Operators.Interval(m_, p_, true, true);
			bool? r_ = context.Operators.In<CqlDate>(j_, q_, default);
			bool? t_ = context.Operators.Not((bool?)(f_ is null));
			bool? u_ = context.Operators.And(r_, t_);
			bool? v_ = context.Operators.And(g_, u_);

			return v_;
		};
		IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
		bool? e_ = context.Operators.Exists<Condition>(d_);

		return e_;
	}


    [CqlDeclaration("Qualifying Encounters")]
	public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
	{
		CqlValueSet a_ = this.Office_Visit(context);
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, default);
		CqlValueSet c_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
		IEnumerable<Encounter> d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, default);
		IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
		CqlValueSet f_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
		IEnumerable<Encounter> g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, default);
		CqlValueSet h_ = this.Home_Healthcare_Services(context);
		IEnumerable<Encounter> i_ = context.Operators.RetrieveByValueSet<Encounter>(h_, default);
		IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
		IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
		CqlValueSet l_ = this.Annual_Wellness_Visit(context);
		IEnumerable<Encounter> m_ = context.Operators.RetrieveByValueSet<Encounter>(l_, default);
		CqlValueSet n_ = this.Nursing_Facility_Visit(context);
		IEnumerable<Encounter> o_ = context.Operators.RetrieveByValueSet<Encounter>(n_, default);
		IEnumerable<Encounter> p_ = context.Operators.Union<Encounter>(m_, o_);
		IEnumerable<Encounter> q_ = context.Operators.Union<Encounter>(k_, p_);
		CqlValueSet r_ = this.Psych_Visit_Diagnostic_Evaluation(context);
		IEnumerable<Encounter> s_ = context.Operators.RetrieveByValueSet<Encounter>(r_, default);
		CqlValueSet t_ = this.Psych_Visit_Psychotherapy(context);
		IEnumerable<Encounter> u_ = context.Operators.RetrieveByValueSet<Encounter>(t_, default);
		IEnumerable<Encounter> v_ = context.Operators.Union<Encounter>(s_, u_);
		IEnumerable<Encounter> w_ = context.Operators.Union<Encounter>(q_, v_);
		CqlValueSet x_ = this.Telephone_Visits(context);
		IEnumerable<Encounter> y_ = context.Operators.RetrieveByValueSet<Encounter>(x_, default);
		CqlValueSet z_ = this.Online_Assessments(context);
		IEnumerable<Encounter> aa_ = context.Operators.RetrieveByValueSet<Encounter>(z_, default);
		IEnumerable<Encounter> ab_ = context.Operators.Union<Encounter>(y_, aa_);
		IEnumerable<Encounter> ac_ = context.Operators.Union<Encounter>(w_, ab_);
		bool? ad_(Encounter ValidEncounter)
		{
			Period af_ = ValidEncounter?.Period;
			CqlInterval<CqlDateTime> ag_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, af_);
			CqlInterval<CqlDateTime> ah_ = QICoreCommon_2_0_000.Instance.ToInterval(context, ag_ as object);
			CqlDateTime ai_ = context.Operators.Start(ah_);
			CqlDate aj_ = context.Operators.DateFrom(ai_);
			CqlDate ak_ = this.Earliest_Antidepressant_Dispensed_During_Intake_Period(context);
			CqlQuantity al_ = context.Operators.Quantity(60m, "days");
			CqlDate am_ = context.Operators.Subtract(ak_, al_);
			CqlDate ap_ = context.Operators.Add(ak_, al_);
			CqlInterval<CqlDate> aq_ = context.Operators.Interval(am_, ap_, true, true);
			bool? ar_ = context.Operators.In<CqlDate>(aj_, aq_, default);
			bool? at_ = context.Operators.Not((bool?)(ak_ is null));
			bool? au_ = context.Operators.And(ar_, at_);

			return au_;
		};
		IEnumerable<Encounter> ae_ = context.Operators.Where<Encounter>(ac_, ad_);

		return ae_;
	}


    [CqlDeclaration("Initial Population")]
	public bool? Initial_Population(CqlContext context)
	{
		Patient a_ = this.Patient(context);
		Date b_ = a_?.BirthDateElement;
		string c_ = b_?.Value;
		CqlDate d_ = context.Operators.ConvertStringToDate(c_);
		CqlDateTime e_ = this.April_30_of_the_Measurement_Period(context);
		CqlDate f_ = context.Operators.DateFrom(e_);
		int? g_ = context.Operators.CalculateAgeAt(d_, f_, "year");
		bool? h_ = context.Operators.GreaterOrEqual(g_, 18);
		bool? i_ = this.Has_Initial_Major_Depression_Diagnosis(context);
		bool? j_ = context.Operators.And(h_, i_);
		IEnumerable<Encounter> k_ = this.Qualifying_Encounters(context);
		bool? l_ = context.Operators.Exists<Encounter>(k_);
		bool? m_ = context.Operators.And(j_, l_);

		return m_;
	}


    [CqlDeclaration("Denominator")]
	public bool? Denominator(CqlContext context)
	{
		bool? a_ = this.Initial_Population(context);

		return a_;
	}


    [CqlDeclaration("Denominator Exclusions")]
	public bool? Denominator_Exclusions(CqlContext context)
	{
		bool? a_ = Hospice_6_9_000.Instance.Has_Hospice_Services(context);
		CqlValueSet b_ = this.Antidepressant_Medication(context);
		IEnumerable<MedicationRequest> c_ = context.Operators.RetrieveByValueSet<MedicationRequest>(b_, default);
		IEnumerable<MedicationRequest> e_ = context.Operators.RetrieveByValueSet<MedicationRequest>(b_, default);
		IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(c_, e_);
		IEnumerable<MedicationRequest> g_ = Status_1_6_000.Instance.Active_Medication(context, f_);
		bool? h_(MedicationRequest ActiveAntidepressant)
		{
			CqlDate l_ = this.Earliest_Antidepressant_Dispensed_During_Intake_Period(context);
			bool? m_ = context.Operators.Not((bool?)(l_ is null));
			List<Dosage> n_ = ActiveAntidepressant?.DosageInstruction;
			Dosage o_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)n_);
			Timing p_ = o_?.Timing;
			Timing.RepeatComponent q_ = p_?.Repeat;
			DataType r_ = q_?.Bounds;
			object s_ = FHIRHelpers_4_3_000.Instance.ToValue(context, r_);
			object[] t_ = [
				s_,
			];
			CqlInterval<CqlDateTime> u_(object Meds)
			{
				CqlInterval<CqlDateTime> af_ = this.Intake_Period(context);
				CqlDateTime ag_ = context.Operators.Start(af_);
				CqlInterval<CqlDateTime> ah_ = this.Measurement_Period(context);
				CqlDateTime ai_ = context.Operators.End(ah_);
				CqlInterval<CqlDateTime> aj_ = context.Operators.Interval(ag_, ai_, true, true);
				CqlInterval<CqlDateTime> ak_ = context.Operators.Intersect<CqlDateTime>(Meds as CqlInterval<CqlDateTime>, aj_);

				return ak_;
			};
			IEnumerable<CqlInterval<CqlDateTime>> v_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>((IEnumerable<object>)t_, u_);
			CqlInterval<CqlDateTime> w_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(v_);
			CqlInterval<CqlDate> x_ = CQMCommon_2_0_000.Instance.ToDateInterval(context, w_);
			CqlQuantity z_ = context.Operators.Quantity(105m, "days");
			CqlDate aa_ = context.Operators.Subtract(l_, z_);
			CqlInterval<CqlDate> ac_ = context.Operators.Interval(aa_, l_, true, false);
			bool? ad_ = context.Operators.Overlaps(x_, ac_, default);
			bool? ae_ = context.Operators.And(m_, ad_);

			return ae_;
		};
		IEnumerable<MedicationRequest> i_ = context.Operators.Where<MedicationRequest>(g_, h_);
		bool? j_ = context.Operators.Exists<MedicationRequest>(i_);
		bool? k_ = context.Operators.Or(a_, j_);

		return k_;
	}


    [CqlDeclaration("Antidepressant Medication Period Between IPSD and 114 Days After IPSD")]
	public IEnumerable<CqlInterval<CqlDate>> Antidepressant_Medication_Period_Between_IPSD_and_114_Days_After_IPSD(CqlContext context)
	{
		CqlValueSet a_ = this.Antidepressant_Medication(context);
		IEnumerable<MedicationDispense> b_ = context.Operators.RetrieveByValueSet<MedicationDispense>(a_, default);
		IEnumerable<MedicationDispense> d_ = context.Operators.RetrieveByValueSet<MedicationDispense>(a_, default);
		IEnumerable<MedicationDispense> e_ = context.Operators.Union<MedicationDispense>(b_, d_);
		IEnumerable<MedicationDispense> f_ = Status_1_6_000.Instance.Dispensed_Medication(context, e_);
		CqlInterval<CqlDate> g_(MedicationDispense Antidepressant)
		{
			CqlInterval<CqlDate> i_ = CumulativeMedicationDuration_4_0_000.Instance.MedicationDispensePeriod(context, Antidepressant);
			CqlDate j_ = this.Earliest_Antidepressant_Dispensed_During_Intake_Period(context);
			CqlQuantity l_ = context.Operators.Quantity(114m, "days");
			CqlDate m_ = context.Operators.Add(j_, l_);
			CqlInterval<CqlDate> n_ = context.Operators.Interval(j_, m_, true, true);
			CqlInterval<CqlDate> o_ = context.Operators.Intersect<CqlDate>(i_, n_);

			return o_;
		};
		IEnumerable<CqlInterval<CqlDate>> h_ = context.Operators.Select<MedicationDispense, CqlInterval<CqlDate>>(f_, g_);

		return h_;
	}


    [CqlDeclaration("Cumulative Medication Duration Greater Than or Equal to 84 Days")]
	public bool? Cumulative_Medication_Duration_Greater_Than_or_Equal_to_84_Days(CqlContext context)
	{
		IEnumerable<CqlInterval<CqlDate>> a_ = this.Antidepressant_Medication_Period_Between_IPSD_and_114_Days_After_IPSD(context);
		int? b_ = CumulativeMedicationDuration_4_0_000.Instance.CumulativeDuration(context, a_);
		bool? c_ = context.Operators.GreaterOrEqual(b_, 84);

		return c_;
	}


    [CqlDeclaration("Numerator 1")]
	public bool? Numerator_1(CqlContext context)
	{
		bool? a_ = this.Cumulative_Medication_Duration_Greater_Than_or_Equal_to_84_Days(context);

		return a_;
	}


    [CqlDeclaration("Antidepressant Medication Period Between IPSD and 231 Days After IPSD")]
	public IEnumerable<CqlInterval<CqlDate>> Antidepressant_Medication_Period_Between_IPSD_and_231_Days_After_IPSD(CqlContext context)
	{
		CqlValueSet a_ = this.Antidepressant_Medication(context);
		IEnumerable<MedicationDispense> b_ = context.Operators.RetrieveByValueSet<MedicationDispense>(a_, default);
		IEnumerable<MedicationDispense> d_ = context.Operators.RetrieveByValueSet<MedicationDispense>(a_, default);
		IEnumerable<MedicationDispense> e_ = context.Operators.Union<MedicationDispense>(b_, d_);
		IEnumerable<MedicationDispense> f_ = Status_1_6_000.Instance.Dispensed_Medication(context, e_);
		CqlInterval<CqlDate> g_(MedicationDispense Antidepressant)
		{
			CqlInterval<CqlDate> i_ = CumulativeMedicationDuration_4_0_000.Instance.MedicationDispensePeriod(context, Antidepressant);
			CqlDate j_ = this.Earliest_Antidepressant_Dispensed_During_Intake_Period(context);
			CqlQuantity l_ = context.Operators.Quantity(231m, "days");
			CqlDate m_ = context.Operators.Add(j_, l_);
			CqlInterval<CqlDate> n_ = context.Operators.Interval(j_, m_, true, true);
			CqlInterval<CqlDate> o_ = context.Operators.Intersect<CqlDate>(i_, n_);

			return o_;
		};
		IEnumerable<CqlInterval<CqlDate>> h_ = context.Operators.Select<MedicationDispense, CqlInterval<CqlDate>>(f_, g_);

		return h_;
	}


    [CqlDeclaration("Cumulative Medication Duration Greater Than or Equal to 180 Days")]
	public bool? Cumulative_Medication_Duration_Greater_Than_or_Equal_to_180_Days(CqlContext context)
	{
		IEnumerable<CqlInterval<CqlDate>> a_ = this.Antidepressant_Medication_Period_Between_IPSD_and_231_Days_After_IPSD(context);
		int? b_ = CumulativeMedicationDuration_4_0_000.Instance.CumulativeDuration(context, a_);
		bool? c_ = context.Operators.GreaterOrEqual(b_, 180);

		return c_;
	}


    [CqlDeclaration("Numerator 2")]
	public bool? Numerator_2(CqlContext context)
	{
		bool? a_ = this.Cumulative_Medication_Duration_Greater_Than_or_Equal_to_180_Days(context);

		return a_;
	}


    [CqlDeclaration("SDE Ethnicity")]
	public (IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
	{
		(IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_4_000.Instance.SDE_Ethnicity(context);

		return a_;
	}


    [CqlDeclaration("SDE Payer")]
	public IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
	{
		IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_3_4_000.Instance.SDE_Payer(context);

		return a_;
	}


    [CqlDeclaration("SDE Race")]
	public (IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
	{
		(IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_4_000.Instance.SDE_Race(context);

		return a_;
	}


    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex(CqlContext context)
	{
		CqlCode a_ = SupplementalDataElements_3_4_000.Instance.SDE_Sex(context);

		return a_;
	}

}
