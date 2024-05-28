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
[CqlLibrary("AntidepressantMedicationManagementFHIR", "0.1.000")]
public class AntidepressantMedicationManagementFHIR_0_1_000
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Annual_Wellness_Visit;
    internal Lazy<CqlValueSet> __Antidepressant_Medication;
    internal Lazy<CqlValueSet> __Home_Healthcare_Services;
    internal Lazy<CqlValueSet> __Major_Depression;
    internal Lazy<CqlValueSet> __Nursing_Facility_Visit;
    internal Lazy<CqlValueSet> __Office_Visit;
    internal Lazy<CqlValueSet> __Online_Assessments;
    internal Lazy<CqlValueSet> __Preventive_Care_Services_Established_Office_Visit__18_and_Up;
    internal Lazy<CqlValueSet> __Preventive_Care_Services_Initial_Office_Visit__18_and_Up;
    internal Lazy<CqlValueSet> __Psych_Visit_Diagnostic_Evaluation;
    internal Lazy<CqlValueSet> __Psych_Visit_Psychotherapy;
    internal Lazy<CqlValueSet> __Telephone_Visits;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<CqlDateTime> __April_30_of_the_Measurement_Period;
    internal Lazy<CqlDateTime> __May_1_of_the_Year_Prior_to_the_Measurement_Period;
    internal Lazy<CqlInterval<CqlDateTime>> __Intake_Period;
    internal Lazy<CqlDate> __Earliest_Antidepressant_Dispensed_During_Intake_Period;
    internal Lazy<bool?> __Has_Initial_Major_Depression_Diagnosis;
    internal Lazy<IEnumerable<Encounter>> __Qualifying_Encounters;
    internal Lazy<bool?> __Initial_Population;
    internal Lazy<bool?> __Denominator;
    internal Lazy<bool?> __Denominator_Exclusions;
    internal Lazy<IEnumerable<CqlInterval<CqlDate>>> __Antidepressant_Medication_Period_Between_IPSD_and_114_Days_After_IPSD;
    internal Lazy<bool?> __Cumulative_Medication_Duration_Greater_Than_or_Equal_to_84_Days;
    internal Lazy<bool?> __Numerator_1;
    internal Lazy<IEnumerable<CqlInterval<CqlDate>>> __Antidepressant_Medication_Period_Between_IPSD_and_231_Days_After_IPSD;
    internal Lazy<bool?> __Cumulative_Medication_Duration_Greater_Than_or_Equal_to_180_Days;
    internal Lazy<bool?> __Numerator_2;
    internal Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ>> __SDE_Payer;
    internal Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;

    #endregion
    public AntidepressantMedicationManagementFHIR_0_1_000(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_3_000 = new FHIRHelpers_4_3_000(context);
        SupplementalDataElements_3_4_000 = new SupplementalDataElements_3_4_000(context);
        Hospice_6_9_000 = new Hospice_6_9_000(context);
        CumulativeMedicationDuration_4_0_000 = new CumulativeMedicationDuration_4_0_000(context);
        Status_1_6_000 = new Status_1_6_000(context);
        QICoreCommon_2_0_000 = new QICoreCommon_2_0_000(context);
        CQMCommon_2_0_000 = new CQMCommon_2_0_000(context);

        __Annual_Wellness_Visit = new Lazy<CqlValueSet>(this.Annual_Wellness_Visit_Value);
        __Antidepressant_Medication = new Lazy<CqlValueSet>(this.Antidepressant_Medication_Value);
        __Home_Healthcare_Services = new Lazy<CqlValueSet>(this.Home_Healthcare_Services_Value);
        __Major_Depression = new Lazy<CqlValueSet>(this.Major_Depression_Value);
        __Nursing_Facility_Visit = new Lazy<CqlValueSet>(this.Nursing_Facility_Visit_Value);
        __Office_Visit = new Lazy<CqlValueSet>(this.Office_Visit_Value);
        __Online_Assessments = new Lazy<CqlValueSet>(this.Online_Assessments_Value);
        __Preventive_Care_Services_Established_Office_Visit__18_and_Up = new Lazy<CqlValueSet>(this.Preventive_Care_Services_Established_Office_Visit__18_and_Up_Value);
        __Preventive_Care_Services_Initial_Office_Visit__18_and_Up = new Lazy<CqlValueSet>(this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up_Value);
        __Psych_Visit_Diagnostic_Evaluation = new Lazy<CqlValueSet>(this.Psych_Visit_Diagnostic_Evaluation_Value);
        __Psych_Visit_Psychotherapy = new Lazy<CqlValueSet>(this.Psych_Visit_Psychotherapy_Value);
        __Telephone_Visits = new Lazy<CqlValueSet>(this.Telephone_Visits_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __April_30_of_the_Measurement_Period = new Lazy<CqlDateTime>(this.April_30_of_the_Measurement_Period_Value);
        __May_1_of_the_Year_Prior_to_the_Measurement_Period = new Lazy<CqlDateTime>(this.May_1_of_the_Year_Prior_to_the_Measurement_Period_Value);
        __Intake_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Intake_Period_Value);
        __Earliest_Antidepressant_Dispensed_During_Intake_Period = new Lazy<CqlDate>(this.Earliest_Antidepressant_Dispensed_During_Intake_Period_Value);
        __Has_Initial_Major_Depression_Diagnosis = new Lazy<bool?>(this.Has_Initial_Major_Depression_Diagnosis_Value);
        __Qualifying_Encounters = new Lazy<IEnumerable<Encounter>>(this.Qualifying_Encounters_Value);
        __Initial_Population = new Lazy<bool?>(this.Initial_Population_Value);
        __Denominator = new Lazy<bool?>(this.Denominator_Value);
        __Denominator_Exclusions = new Lazy<bool?>(this.Denominator_Exclusions_Value);
        __Antidepressant_Medication_Period_Between_IPSD_and_114_Days_After_IPSD = new Lazy<IEnumerable<CqlInterval<CqlDate>>>(this.Antidepressant_Medication_Period_Between_IPSD_and_114_Days_After_IPSD_Value);
        __Cumulative_Medication_Duration_Greater_Than_or_Equal_to_84_Days = new Lazy<bool?>(this.Cumulative_Medication_Duration_Greater_Than_or_Equal_to_84_Days_Value);
        __Numerator_1 = new Lazy<bool?>(this.Numerator_1_Value);
        __Antidepressant_Medication_Period_Between_IPSD_and_231_Days_After_IPSD = new Lazy<IEnumerable<CqlInterval<CqlDate>>>(this.Antidepressant_Medication_Period_Between_IPSD_and_231_Days_After_IPSD_Value);
        __Cumulative_Medication_Duration_Greater_Than_or_Equal_to_180_Days = new Lazy<bool?>(this.Cumulative_Medication_Duration_Greater_Than_or_Equal_to_180_Days_Value);
        __Numerator_2 = new Lazy<bool?>(this.Numerator_2_Value);
        __SDE_Ethnicity = new Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_3_000 FHIRHelpers_4_3_000 { get; }
    public SupplementalDataElements_3_4_000 SupplementalDataElements_3_4_000 { get; }
    public Hospice_6_9_000 Hospice_6_9_000 { get; }
    public CumulativeMedicationDuration_4_0_000 CumulativeMedicationDuration_4_0_000 { get; }
    public Status_1_6_000 Status_1_6_000 { get; }
    public QICoreCommon_2_0_000 QICoreCommon_2_0_000 { get; }
    public CQMCommon_2_0_000 CQMCommon_2_0_000 { get; }

    #endregion

	private CqlValueSet Annual_Wellness_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", null);

    [CqlDeclaration("Annual Wellness Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240")]
	public CqlValueSet Annual_Wellness_Visit() => 
		__Annual_Wellness_Visit.Value;

	private CqlValueSet Antidepressant_Medication_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1213", null);

    [CqlDeclaration("Antidepressant Medication")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1213")]
	public CqlValueSet Antidepressant_Medication() => 
		__Antidepressant_Medication.Value;

	private CqlValueSet Home_Healthcare_Services_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);

    [CqlDeclaration("Home Healthcare Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016")]
	public CqlValueSet Home_Healthcare_Services() => 
		__Home_Healthcare_Services.Value;

	private CqlValueSet Major_Depression_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1007", null);

    [CqlDeclaration("Major Depression")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1007")]
	public CqlValueSet Major_Depression() => 
		__Major_Depression.Value;

	private CqlValueSet Nursing_Facility_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012", null);

    [CqlDeclaration("Nursing Facility Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012")]
	public CqlValueSet Nursing_Facility_Visit() => 
		__Nursing_Facility_Visit.Value;

	private CqlValueSet Office_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
	public CqlValueSet Office_Visit() => 
		__Office_Visit.Value;

	private CqlValueSet Online_Assessments_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", null);

    [CqlDeclaration("Online Assessments")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089")]
	public CqlValueSet Online_Assessments() => 
		__Online_Assessments.Value;

	private CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);

    [CqlDeclaration("Preventive Care Services Established Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025")]
	public CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up() => 
		__Preventive_Care_Services_Established_Office_Visit__18_and_Up.Value;

	private CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);

    [CqlDeclaration("Preventive Care Services Initial Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023")]
	public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up() => 
		__Preventive_Care_Services_Initial_Office_Visit__18_and_Up.Value;

	private CqlValueSet Psych_Visit_Diagnostic_Evaluation_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1492", null);

    [CqlDeclaration("Psych Visit Diagnostic Evaluation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1492")]
	public CqlValueSet Psych_Visit_Diagnostic_Evaluation() => 
		__Psych_Visit_Diagnostic_Evaluation.Value;

	private CqlValueSet Psych_Visit_Psychotherapy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1496", null);

    [CqlDeclaration("Psych Visit Psychotherapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1496")]
	public CqlValueSet Psych_Visit_Psychotherapy() => 
		__Psych_Visit_Psychotherapy.Value;

	private CqlValueSet Telephone_Visits_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
	public CqlValueSet Telephone_Visits() => 
		__Telephone_Visits.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		var b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		var c_ = context.Operators.Interval(a_, b_, true, false);
		var d_ = context.ResolveParameter("AntidepressantMedicationManagementFHIR-0.1.000", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
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

	private CqlDateTime April_30_of_the_Measurement_Period_Value()
	{
		var a_ = this.Measurement_Period();
		var b_ = context.Operators.Start(a_);
		var c_ = context.Operators.DateTimeComponentFrom(b_, "year");
		var d_ = context.Operators.ConvertIntegerToDecimal(0);
		var e_ = context.Operators.DateTime(c_, 4, 30, 23, 59, 59, 0, d_);

		return e_;
	}

    [CqlDeclaration("April 30 of the Measurement Period")]
	public CqlDateTime April_30_of_the_Measurement_Period() => 
		__April_30_of_the_Measurement_Period.Value;

	private CqlDateTime May_1_of_the_Year_Prior_to_the_Measurement_Period_Value()
	{
		var a_ = this.Measurement_Period();
		var b_ = context.Operators.Start(a_);
		var c_ = context.Operators.DateTimeComponentFrom(b_, "year");
		var d_ = context.Operators.Subtract(c_, 1);
		var e_ = context.Operators.ConvertIntegerToDecimal(0);
		var f_ = context.Operators.DateTime(d_, 5, 1, 0, 0, 0, 0, e_);

		return f_;
	}

    [CqlDeclaration("May 1 of the Year Prior to the Measurement Period")]
	public CqlDateTime May_1_of_the_Year_Prior_to_the_Measurement_Period() => 
		__May_1_of_the_Year_Prior_to_the_Measurement_Period.Value;

	private CqlInterval<CqlDateTime> Intake_Period_Value()
	{
		var a_ = this.May_1_of_the_Year_Prior_to_the_Measurement_Period();
		var b_ = this.April_30_of_the_Measurement_Period();
		var c_ = context.Operators.Interval(a_, b_, true, true);

		return c_;
	}

    [CqlDeclaration("Intake Period")]
	public CqlInterval<CqlDateTime> Intake_Period() => 
		__Intake_Period.Value;

	private CqlDate Earliest_Antidepressant_Dispensed_During_Intake_Period_Value()
	{
		var a_ = this.Antidepressant_Medication();
		var b_ = context.Operators.RetrieveByValueSet<MedicationDispense>(a_, null);
		var d_ = context.Operators.RetrieveByValueSet<MedicationDispense>(a_, null);
		var e_ = context.Operators.Union<MedicationDispense>(b_, d_);
		var f_ = Status_1_6_000.Dispensed_Medication(e_);
		bool? g_(MedicationDispense Antidepressant)
		{
			var n_ = CumulativeMedicationDuration_4_0_000.MedicationDispensePeriod(Antidepressant);
			var o_ = context.Operators.Start(n_);
			var p_ = context.Operators.ConvertDateToDateTime(o_);
			var q_ = this.Intake_Period();
			var r_ = context.Operators.In<CqlDateTime>(p_, q_, "day");

			return r_;
		};
		var h_ = context.Operators.Where<MedicationDispense>(f_, g_);
		Tuple_BZDEAYEYEiNadHNdHhSIPXaDL i_(MedicationDispense Antidepressant)
		{
			var s_ = CumulativeMedicationDuration_4_0_000.MedicationDispensePeriod(Antidepressant);
			var t_ = context.Operators.Start(s_);
			var u_ = context.Operators.ConvertDateToDateTime(t_);
			var v_ = context.Operators.DateFrom(u_);
			var w_ = new Tuple_BZDEAYEYEiNadHNdHhSIPXaDL
			{
				AntidepressantDate = v_,
			};

			return w_;
		};
		var j_ = context.Operators.Select<MedicationDispense, Tuple_BZDEAYEYEiNadHNdHhSIPXaDL>(h_, i_);
		object k_(Tuple_BZDEAYEYEiNadHNdHhSIPXaDL @this)
		{
			var x_ = @this?.AntidepressantDate;

			return x_;
		};
		var l_ = context.Operators.SortBy<Tuple_BZDEAYEYEiNadHNdHhSIPXaDL>(j_, k_, System.ComponentModel.ListSortDirection.Ascending);
		var m_ = context.Operators.First<Tuple_BZDEAYEYEiNadHNdHhSIPXaDL>(l_);

		return m_?.AntidepressantDate;
	}

    [CqlDeclaration("Earliest Antidepressant Dispensed During Intake Period")]
	public CqlDate Earliest_Antidepressant_Dispensed_During_Intake_Period() => 
		__Earliest_Antidepressant_Dispensed_During_Intake_Period.Value;

	private bool? Has_Initial_Major_Depression_Diagnosis_Value()
	{
		var a_ = this.Major_Depression();
		var b_ = context.Operators.RetrieveByValueSet<Condition>(a_, null);
		bool? c_(Condition MajorDepression)
		{
			var f_ = this.Earliest_Antidepressant_Dispensed_During_Intake_Period();
			var g_ = context.Operators.Not((bool?)(f_ is null));
			var h_ = QICoreCommon_2_0_000.ToPrevalenceInterval(MajorDepression);
			var i_ = context.Operators.Start(h_);
			var j_ = context.Operators.DateFrom(i_);
			var l_ = context.Operators.Quantity(60m, "days");
			var m_ = context.Operators.Subtract(f_, l_);
			var p_ = context.Operators.Add(f_, l_);
			var q_ = context.Operators.Interval(m_, p_, true, true);
			var r_ = context.Operators.In<CqlDate>(j_, q_, null);
			var t_ = context.Operators.Not((bool?)(f_ is null));
			var u_ = context.Operators.And(r_, t_);
			var v_ = context.Operators.And(g_, u_);

			return v_;
		};
		var d_ = context.Operators.Where<Condition>(b_, c_);
		var e_ = context.Operators.Exists<Condition>(d_);

		return e_;
	}

    [CqlDeclaration("Has Initial Major Depression Diagnosis")]
	public bool? Has_Initial_Major_Depression_Diagnosis() => 
		__Has_Initial_Major_Depression_Diagnosis.Value;

	private IEnumerable<Encounter> Qualifying_Encounters_Value()
	{
		var a_ = this.Office_Visit();
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		var c_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up();
		var d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, null);
		var e_ = context.Operators.Union<Encounter>(b_, d_);
		var f_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up();
		var g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, null);
		var h_ = this.Home_Healthcare_Services();
		var i_ = context.Operators.RetrieveByValueSet<Encounter>(h_, null);
		var j_ = context.Operators.Union<Encounter>(g_, i_);
		var k_ = context.Operators.Union<Encounter>(e_, j_);
		var l_ = this.Annual_Wellness_Visit();
		var m_ = context.Operators.RetrieveByValueSet<Encounter>(l_, null);
		var n_ = this.Nursing_Facility_Visit();
		var o_ = context.Operators.RetrieveByValueSet<Encounter>(n_, null);
		var p_ = context.Operators.Union<Encounter>(m_, o_);
		var q_ = context.Operators.Union<Encounter>(k_, p_);
		var r_ = this.Psych_Visit_Diagnostic_Evaluation();
		var s_ = context.Operators.RetrieveByValueSet<Encounter>(r_, null);
		var t_ = this.Psych_Visit_Psychotherapy();
		var u_ = context.Operators.RetrieveByValueSet<Encounter>(t_, null);
		var v_ = context.Operators.Union<Encounter>(s_, u_);
		var w_ = context.Operators.Union<Encounter>(q_, v_);
		var x_ = this.Telephone_Visits();
		var y_ = context.Operators.RetrieveByValueSet<Encounter>(x_, null);
		var z_ = this.Online_Assessments();
		var aa_ = context.Operators.RetrieveByValueSet<Encounter>(z_, null);
		var ab_ = context.Operators.Union<Encounter>(y_, aa_);
		var ac_ = context.Operators.Union<Encounter>(w_, ab_);
		bool? ad_(Encounter ValidEncounter)
		{
			var af_ = ValidEncounter?.Period;
			var ag_ = FHIRHelpers_4_3_000.ToInterval(af_);
			var ah_ = QICoreCommon_2_0_000.ToInterval((ag_ as object));
			var ai_ = context.Operators.Start(ah_);
			var aj_ = context.Operators.DateFrom(ai_);
			var ak_ = this.Earliest_Antidepressant_Dispensed_During_Intake_Period();
			var al_ = context.Operators.Quantity(60m, "days");
			var am_ = context.Operators.Subtract(ak_, al_);
			var ap_ = context.Operators.Add(ak_, al_);
			var aq_ = context.Operators.Interval(am_, ap_, true, true);
			var ar_ = context.Operators.In<CqlDate>(aj_, aq_, null);
			var at_ = context.Operators.Not((bool?)(ak_ is null));
			var au_ = context.Operators.And(ar_, at_);

			return au_;
		};
		var ae_ = context.Operators.Where<Encounter>(ac_, ad_);

		return ae_;
	}

    [CqlDeclaration("Qualifying Encounters")]
	public IEnumerable<Encounter> Qualifying_Encounters() => 
		__Qualifying_Encounters.Value;

	private bool? Initial_Population_Value()
	{
		var a_ = this.Patient();
		var b_ = context.Operators.Convert<CqlDate>(a_?.BirthDateElement?.Value);
		var c_ = this.April_30_of_the_Measurement_Period();
		var d_ = context.Operators.DateFrom(c_);
		var e_ = context.Operators.CalculateAgeAt(b_, d_, "year");
		var f_ = context.Operators.GreaterOrEqual(e_, 18);
		var g_ = this.Has_Initial_Major_Depression_Diagnosis();
		var h_ = context.Operators.And(f_, g_);
		var i_ = this.Qualifying_Encounters();
		var j_ = context.Operators.Exists<Encounter>(i_);
		var k_ = context.Operators.And(h_, j_);

		return k_;
	}

    [CqlDeclaration("Initial Population")]
	public bool? Initial_Population() => 
		__Initial_Population.Value;

	private bool? Denominator_Value()
	{
		var a_ = this.Initial_Population();

		return a_;
	}

    [CqlDeclaration("Denominator")]
	public bool? Denominator() => 
		__Denominator.Value;

	private bool? Denominator_Exclusions_Value()
	{
		var a_ = Hospice_6_9_000.Has_Hospice_Services();
		var b_ = this.Antidepressant_Medication();
		var c_ = context.Operators.RetrieveByValueSet<MedicationRequest>(b_, null);
		var e_ = context.Operators.RetrieveByValueSet<MedicationRequest>(b_, null);
		var f_ = context.Operators.Union<MedicationRequest>(c_, e_);
		var g_ = Status_1_6_000.Active_Medication(f_);
		bool? h_(MedicationRequest ActiveAntidepressant)
		{
			var l_ = this.Earliest_Antidepressant_Dispensed_During_Intake_Period();
			var m_ = context.Operators.Not((bool?)(l_ is null));
			var n_ = ActiveAntidepressant?.DosageInstruction;
			var o_ = context.Operators.SingletonFrom<Dosage>((IEnumerable<Dosage>)n_);
			var p_ = o_?.Timing;
			var q_ = p_?.Repeat;
			var r_ = q_?.Bounds;
			var s_ = FHIRHelpers_4_3_000.ToValue(r_);
			var t_ = new object[]
			{
				s_,
			};
			CqlInterval<CqlDateTime> u_(object Meds)
			{
				var af_ = this.Intake_Period();
				var ag_ = context.Operators.Start(af_);
				var ah_ = this.Measurement_Period();
				var ai_ = context.Operators.End(ah_);
				var aj_ = context.Operators.Interval(ag_, ai_, true, true);
				var ak_ = context.Operators.Intersect<CqlDateTime>((Meds as CqlInterval<CqlDateTime>), aj_);

				return ak_;
			};
			var v_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>((IEnumerable<object>)t_, u_);
			var w_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(v_);
			var x_ = CQMCommon_2_0_000.ToDateInterval(w_);
			var z_ = context.Operators.Quantity(105m, "days");
			var aa_ = context.Operators.Subtract(l_, z_);
			var ac_ = context.Operators.Interval(aa_, l_, true, false);
			var ad_ = context.Operators.Overlaps(x_, ac_, null);
			var ae_ = context.Operators.And(m_, ad_);

			return ae_;
		};
		var i_ = context.Operators.Where<MedicationRequest>(g_, h_);
		var j_ = context.Operators.Exists<MedicationRequest>(i_);
		var k_ = context.Operators.Or(a_, j_);

		return k_;
	}

    [CqlDeclaration("Denominator Exclusions")]
	public bool? Denominator_Exclusions() => 
		__Denominator_Exclusions.Value;

	private IEnumerable<CqlInterval<CqlDate>> Antidepressant_Medication_Period_Between_IPSD_and_114_Days_After_IPSD_Value()
	{
		var a_ = this.Antidepressant_Medication();
		var b_ = context.Operators.RetrieveByValueSet<MedicationDispense>(a_, null);
		var d_ = context.Operators.RetrieveByValueSet<MedicationDispense>(a_, null);
		var e_ = context.Operators.Union<MedicationDispense>(b_, d_);
		var f_ = Status_1_6_000.Dispensed_Medication(e_);
		CqlInterval<CqlDate> g_(MedicationDispense Antidepressant)
		{
			var i_ = CumulativeMedicationDuration_4_0_000.MedicationDispensePeriod(Antidepressant);
			var j_ = this.Earliest_Antidepressant_Dispensed_During_Intake_Period();
			var l_ = context.Operators.Quantity(114m, "days");
			var m_ = context.Operators.Add(j_, l_);
			var n_ = context.Operators.Interval(j_, m_, true, true);
			var o_ = context.Operators.Intersect<CqlDate>(i_, n_);

			return o_;
		};
		var h_ = context.Operators.Select<MedicationDispense, CqlInterval<CqlDate>>(f_, g_);

		return h_;
	}

    [CqlDeclaration("Antidepressant Medication Period Between IPSD and 114 Days After IPSD")]
	public IEnumerable<CqlInterval<CqlDate>> Antidepressant_Medication_Period_Between_IPSD_and_114_Days_After_IPSD() => 
		__Antidepressant_Medication_Period_Between_IPSD_and_114_Days_After_IPSD.Value;

	private bool? Cumulative_Medication_Duration_Greater_Than_or_Equal_to_84_Days_Value()
	{
		var a_ = this.Antidepressant_Medication_Period_Between_IPSD_and_114_Days_After_IPSD();
		var b_ = CumulativeMedicationDuration_4_0_000.CumulativeDuration(a_);
		var c_ = context.Operators.GreaterOrEqual(b_, 84);

		return c_;
	}

    [CqlDeclaration("Cumulative Medication Duration Greater Than or Equal to 84 Days")]
	public bool? Cumulative_Medication_Duration_Greater_Than_or_Equal_to_84_Days() => 
		__Cumulative_Medication_Duration_Greater_Than_or_Equal_to_84_Days.Value;

	private bool? Numerator_1_Value()
	{
		var a_ = this.Cumulative_Medication_Duration_Greater_Than_or_Equal_to_84_Days();

		return a_;
	}

    [CqlDeclaration("Numerator 1")]
	public bool? Numerator_1() => 
		__Numerator_1.Value;

	private IEnumerable<CqlInterval<CqlDate>> Antidepressant_Medication_Period_Between_IPSD_and_231_Days_After_IPSD_Value()
	{
		var a_ = this.Antidepressant_Medication();
		var b_ = context.Operators.RetrieveByValueSet<MedicationDispense>(a_, null);
		var d_ = context.Operators.RetrieveByValueSet<MedicationDispense>(a_, null);
		var e_ = context.Operators.Union<MedicationDispense>(b_, d_);
		var f_ = Status_1_6_000.Dispensed_Medication(e_);
		CqlInterval<CqlDate> g_(MedicationDispense Antidepressant)
		{
			var i_ = CumulativeMedicationDuration_4_0_000.MedicationDispensePeriod(Antidepressant);
			var j_ = this.Earliest_Antidepressant_Dispensed_During_Intake_Period();
			var l_ = context.Operators.Quantity(231m, "days");
			var m_ = context.Operators.Add(j_, l_);
			var n_ = context.Operators.Interval(j_, m_, true, true);
			var o_ = context.Operators.Intersect<CqlDate>(i_, n_);

			return o_;
		};
		var h_ = context.Operators.Select<MedicationDispense, CqlInterval<CqlDate>>(f_, g_);

		return h_;
	}

    [CqlDeclaration("Antidepressant Medication Period Between IPSD and 231 Days After IPSD")]
	public IEnumerable<CqlInterval<CqlDate>> Antidepressant_Medication_Period_Between_IPSD_and_231_Days_After_IPSD() => 
		__Antidepressant_Medication_Period_Between_IPSD_and_231_Days_After_IPSD.Value;

	private bool? Cumulative_Medication_Duration_Greater_Than_or_Equal_to_180_Days_Value()
	{
		var a_ = this.Antidepressant_Medication_Period_Between_IPSD_and_231_Days_After_IPSD();
		var b_ = CumulativeMedicationDuration_4_0_000.CumulativeDuration(a_);
		var c_ = context.Operators.GreaterOrEqual(b_, 180);

		return c_;
	}

    [CqlDeclaration("Cumulative Medication Duration Greater Than or Equal to 180 Days")]
	public bool? Cumulative_Medication_Duration_Greater_Than_or_Equal_to_180_Days() => 
		__Cumulative_Medication_Duration_Greater_Than_or_Equal_to_180_Days.Value;

	private bool? Numerator_2_Value()
	{
		var a_ = this.Cumulative_Medication_Duration_Greater_Than_or_Equal_to_180_Days();

		return a_;
	}

    [CqlDeclaration("Numerator 2")]
	public bool? Numerator_2() => 
		__Numerator_2.Value;

	private Tuple_HPcCiDPXQfZTXIORThMLfTQDR SDE_Ethnicity_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public Tuple_HPcCiDPXQfZTXIORThMLfTQDR SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ> SDE_Payer_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ> SDE_Payer() => 
		__SDE_Payer.Value;

	private Tuple_HPcCiDPXQfZTXIORThMLfTQDR SDE_Race_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public Tuple_HPcCiDPXQfZTXIORThMLfTQDR SDE_Race() => 
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
