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
[CqlLibrary("DiabetesHemoglobinA1cHbA1cPoorControl9FHIR", "0.0.015")]
public class DiabetesHemoglobinA1cHbA1cPoorControl9FHIR_0_0_015
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Annual_Wellness_Visit;
    internal Lazy<CqlValueSet> __Diabetes;
    internal Lazy<CqlValueSet> __Discharged_to_Health_Care_Facility_for_Hospice_Care;
    internal Lazy<CqlValueSet> __Discharged_to_Home_for_Hospice_Care;
    internal Lazy<CqlValueSet> __Encounter_Inpatient;
    internal Lazy<CqlValueSet> __HbA1c_Laboratory_Test;
    internal Lazy<CqlValueSet> __Home_Healthcare_Services;
    internal Lazy<CqlValueSet> __Hospice_care_ambulatory;
    internal Lazy<CqlValueSet> __Office_Visit;
    internal Lazy<CqlValueSet> __Preventive_Care_Services___Established_Office_Visit__18_and_Up;
    internal Lazy<CqlValueSet> __Preventive_Care_Services_Initial_Office_Visit__18_and_Up;
    internal Lazy<CqlValueSet> __Telephone_Visits;
    internal Lazy<CqlCode> __Birth_date;
    internal Lazy<CqlCode[]> __LOINC;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<IEnumerable<Coding>> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG>> __SDE_Payer;
    internal Lazy<IEnumerable<Coding>> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;
    internal Lazy<IEnumerable<Encounter>> __Telehealth_Services;
    internal Lazy<bool?> __Initial_Population;
    internal Lazy<bool?> __Denominator;
    internal Lazy<Observation> __Most_Recent_HbA1c;
    internal Lazy<bool?> __Has_Most_Recent_HbA1c_Without_Result;
    internal Lazy<bool?> __Has_Most_Recent_Elevated_HbA1c;
    internal Lazy<bool?> __Has_No_Record_Of_HbA1c;
    internal Lazy<bool?> __Numerator;
    internal Lazy<bool?> __Denominator_Exclusions;

    #endregion
    public DiabetesHemoglobinA1cHbA1cPoorControl9FHIR_0_0_015(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_0_001 = new FHIRHelpers_4_0_001(context);
        SupplementalDataElementsFHIR4_2_0_000 = new SupplementalDataElementsFHIR4_2_0_000(context);
        MATGlobalCommonFunctionsFHIR4_6_1_000 = new MATGlobalCommonFunctionsFHIR4_6_1_000(context);
        PalliativeCareFHIR_0_6_000 = new PalliativeCareFHIR_0_6_000(context);
        AdultOutpatientEncountersFHIR4_2_2_000 = new AdultOutpatientEncountersFHIR4_2_2_000(context);
        HospiceFHIR4_2_3_000 = new HospiceFHIR4_2_3_000(context);
        AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000 = new AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000(context);
        CumulativeMedicationDurationFHIR4_1_0_000 = new CumulativeMedicationDurationFHIR4_1_0_000(context);

        __Annual_Wellness_Visit = new Lazy<CqlValueSet>(this.Annual_Wellness_Visit_Value);
        __Diabetes = new Lazy<CqlValueSet>(this.Diabetes_Value);
        __Discharged_to_Health_Care_Facility_for_Hospice_Care = new Lazy<CqlValueSet>(this.Discharged_to_Health_Care_Facility_for_Hospice_Care_Value);
        __Discharged_to_Home_for_Hospice_Care = new Lazy<CqlValueSet>(this.Discharged_to_Home_for_Hospice_Care_Value);
        __Encounter_Inpatient = new Lazy<CqlValueSet>(this.Encounter_Inpatient_Value);
        __HbA1c_Laboratory_Test = new Lazy<CqlValueSet>(this.HbA1c_Laboratory_Test_Value);
        __Home_Healthcare_Services = new Lazy<CqlValueSet>(this.Home_Healthcare_Services_Value);
        __Hospice_care_ambulatory = new Lazy<CqlValueSet>(this.Hospice_care_ambulatory_Value);
        __Office_Visit = new Lazy<CqlValueSet>(this.Office_Visit_Value);
        __Preventive_Care_Services___Established_Office_Visit__18_and_Up = new Lazy<CqlValueSet>(this.Preventive_Care_Services___Established_Office_Visit__18_and_Up_Value);
        __Preventive_Care_Services_Initial_Office_Visit__18_and_Up = new Lazy<CqlValueSet>(this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up_Value);
        __Telephone_Visits = new Lazy<CqlValueSet>(this.Telephone_Visits_Value);
        __Birth_date = new Lazy<CqlCode>(this.Birth_date_Value);
        __LOINC = new Lazy<CqlCode[]>(this.LOINC_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __SDE_Ethnicity = new Lazy<IEnumerable<Coding>>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<IEnumerable<Coding>>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
        __Telehealth_Services = new Lazy<IEnumerable<Encounter>>(this.Telehealth_Services_Value);
        __Initial_Population = new Lazy<bool?>(this.Initial_Population_Value);
        __Denominator = new Lazy<bool?>(this.Denominator_Value);
        __Most_Recent_HbA1c = new Lazy<Observation>(this.Most_Recent_HbA1c_Value);
        __Has_Most_Recent_HbA1c_Without_Result = new Lazy<bool?>(this.Has_Most_Recent_HbA1c_Without_Result_Value);
        __Has_Most_Recent_Elevated_HbA1c = new Lazy<bool?>(this.Has_Most_Recent_Elevated_HbA1c_Value);
        __Has_No_Record_Of_HbA1c = new Lazy<bool?>(this.Has_No_Record_Of_HbA1c_Value);
        __Numerator = new Lazy<bool?>(this.Numerator_Value);
        __Denominator_Exclusions = new Lazy<bool?>(this.Denominator_Exclusions_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_0_001 FHIRHelpers_4_0_001 { get; }
    public SupplementalDataElementsFHIR4_2_0_000 SupplementalDataElementsFHIR4_2_0_000 { get; }
    public MATGlobalCommonFunctionsFHIR4_6_1_000 MATGlobalCommonFunctionsFHIR4_6_1_000 { get; }
    public PalliativeCareFHIR_0_6_000 PalliativeCareFHIR_0_6_000 { get; }
    public AdultOutpatientEncountersFHIR4_2_2_000 AdultOutpatientEncountersFHIR4_2_2_000 { get; }
    public HospiceFHIR4_2_3_000 HospiceFHIR4_2_3_000 { get; }
    public AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000 AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000 { get; }
    public CumulativeMedicationDurationFHIR4_1_0_000 CumulativeMedicationDurationFHIR4_1_0_000 { get; }

    #endregion

    private CqlValueSet Annual_Wellness_Visit_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", null);

    [CqlDeclaration("Annual Wellness Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240")]
    public CqlValueSet Annual_Wellness_Visit() => __Annual_Wellness_Visit.Value;

    private CqlValueSet Diabetes_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001", null);

    [CqlDeclaration("Diabetes")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001")]
    public CqlValueSet Diabetes() => __Diabetes.Value;

    private CqlValueSet Discharged_to_Health_Care_Facility_for_Hospice_Care_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207", null);

    [CqlDeclaration("Discharged to Health Care Facility for Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207")]
    public CqlValueSet Discharged_to_Health_Care_Facility_for_Hospice_Care() => __Discharged_to_Health_Care_Facility_for_Hospice_Care.Value;

    private CqlValueSet Discharged_to_Home_for_Hospice_Care_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209", null);

    [CqlDeclaration("Discharged to Home for Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209")]
    public CqlValueSet Discharged_to_Home_for_Hospice_Care() => __Discharged_to_Home_for_Hospice_Care.Value;

    private CqlValueSet Encounter_Inpatient_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
    public CqlValueSet Encounter_Inpatient() => __Encounter_Inpatient.Value;

    private CqlValueSet HbA1c_Laboratory_Test_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1013", null);

    [CqlDeclaration("HbA1c Laboratory Test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1013")]
    public CqlValueSet HbA1c_Laboratory_Test() => __HbA1c_Laboratory_Test.Value;

    private CqlValueSet Home_Healthcare_Services_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);

    [CqlDeclaration("Home Healthcare Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016")]
    public CqlValueSet Home_Healthcare_Services() => __Home_Healthcare_Services.Value;

    private CqlValueSet Hospice_care_ambulatory_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15", null);

    [CqlDeclaration("Hospice care ambulatory")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15")]
    public CqlValueSet Hospice_care_ambulatory() => __Hospice_care_ambulatory.Value;

    private CqlValueSet Office_Visit_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
    public CqlValueSet Office_Visit() => __Office_Visit.Value;

    private CqlValueSet Preventive_Care_Services___Established_Office_Visit__18_and_Up_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);

    [CqlDeclaration("Preventive Care Services - Established Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025")]
    public CqlValueSet Preventive_Care_Services___Established_Office_Visit__18_and_Up() => __Preventive_Care_Services___Established_Office_Visit__18_and_Up.Value;

    private CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);

    [CqlDeclaration("Preventive Care Services-Initial Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023")]
    public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up() => __Preventive_Care_Services_Initial_Office_Visit__18_and_Up.Value;

    private CqlValueSet Telephone_Visits_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
    public CqlValueSet Telephone_Visits() => __Telephone_Visits.Value;

    private CqlCode Birth_date_Value() =>
		new CqlCode("21112-8", "http://loinc.org", null, null);

    [CqlDeclaration("Birth date")]
    public CqlCode Birth_date() => __Birth_date.Value;

    private CqlCode[] LOINC_Value()
	{
		var a_ = new CqlCode("21112-8", "http://loinc.org", null, null);

		return new CqlCode[]
		{
			a_,
		};
	}

    [CqlDeclaration("LOINC")]
    public CqlCode[] LOINC() => __LOINC.Value;

    private CqlInterval<CqlDateTime> Measurement_Period_Value() =>
		(CqlInterval<CqlDateTime>)context.ResolveParameter("DiabetesHemoglobinA1cHbA1cPoorControl9FHIR-0.0.015", "Measurement Period", null);

    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period() => __Measurement_Period.Value;

    private Patient Patient_Value()
	{
		var a_ = context?.DataRetriever.RetrieveByValueSet<Patient>(null, null);

		return context?.Operators.SingleOrNull<Patient>(a_);
	}

    [CqlDeclaration("Patient")]
    public Patient Patient() => __Patient.Value;

    private IEnumerable<Coding> SDE_Ethnicity_Value() =>
		SupplementalDataElementsFHIR4_2_0_000.SDE_Ethnicity();

    [CqlDeclaration("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity() => __SDE_Ethnicity.Value;

    private IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer_Value() =>
		SupplementalDataElementsFHIR4_2_0_000.SDE_Payer();

    [CqlDeclaration("SDE Payer")]
    public IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer() => __SDE_Payer.Value;

    private IEnumerable<Coding> SDE_Race_Value() =>
		SupplementalDataElementsFHIR4_2_0_000.SDE_Race();

    [CqlDeclaration("SDE Race")]
    public IEnumerable<Coding> SDE_Race() => __SDE_Race.Value;

    private CqlCode SDE_Sex_Value() =>
		SupplementalDataElementsFHIR4_2_0_000.SDE_Sex();

    [CqlDeclaration("SDE Sex")]
    public CqlCode SDE_Sex() => __SDE_Sex.Value;

    private IEnumerable<Encounter> Telehealth_Services_Value()
	{
		var i_ = this.Telephone_Visits();
		var j_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(i_, null);
		var k_ = (Encounter TelehealthEncounter) =>
		{
			var a_ = (TelehealthEncounter?.StatusElement as object);
			var b_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(a_);
			var c_ = (b_ as object);
			var d_ = context?.Operators.Equal(c_, ("finished" as object));
			var e_ = this.Measurement_Period();
			var f_ = (TelehealthEncounter?.Period as object);
			var g_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(f_);
			var h_ = context?.Operators.IntervalIncludesInterval<CqlDateTime>(e_, g_, null);

			return context?.Operators.And(d_, h_);
		};

		return context?.Operators.WhereOrNull<Encounter>(j_, k_);
	}

    [CqlDeclaration("Telehealth Services")]
    public IEnumerable<Encounter> Telehealth_Services() => __Telehealth_Services.Value;

    private bool? Initial_Population_Value()
	{
		var c_ = (this.Patient()?.BirthDateElement?.Value as object);
		var d_ = context?.Operators?.TypeConverter.Convert<CqlDate>(c_);
		var e_ = this.Measurement_Period();
		var f_ = context?.Operators.Start(e_);
		var g_ = context?.Operators.DateFrom(f_);
		var h_ = context?.Operators.CalculateAgeAt(d_, g_, "year");
		var i_ = context?.Operators.Interval((int?)18, (int?)75, true, false);
		var j_ = context?.Operators.ElementInInterval<int?>(h_, i_, null);
		var k_ = AdultOutpatientEncountersFHIR4_2_2_000.Qualifying_Encounters();
		var l_ = this.Telehealth_Services();
		var m_ = context?.Operators.ListUnion<Encounter>(k_, l_);
		var n_ = context?.Operators.ExistsInList<Encounter>(m_);
		var o_ = context?.Operators.And(j_, n_);
		var p_ = this.Diabetes();
		var q_ = context?.DataRetriever.RetrieveByValueSet<Condition>(p_, null);
		var r_ = (Condition Diabetes) =>
		{
			var a_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(Diabetes);
			var b_ = this.Measurement_Period();

			return context?.Operators.Overlaps(a_, b_, null);
		};
		var s_ = context?.Operators.WhereOrNull<Condition>(q_, r_);
		var t_ = context?.Operators.ExistsInList<Condition>(s_);

		return context?.Operators.And(o_, t_);
	}

    [CqlDeclaration("Initial Population")]
    public bool? Initial_Population() => __Initial_Population.Value;

    private bool? Denominator_Value() =>
		this.Initial_Population();

    [CqlDeclaration("Denominator")]
    public bool? Denominator() => __Denominator.Value;

    private Observation Most_Recent_HbA1c_Value()
	{
		var o_ = this.HbA1c_Laboratory_Test();
		var p_ = context?.DataRetriever.RetrieveByValueSet<Observation>(o_, null);
		var q_ = (Observation RecentHbA1c) =>
		{
			var a_ = (RecentHbA1c?.StatusElement as object);
			var b_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(a_);
			var c_ = "final";
			var d_ = "amended";
			var e_ = "corrected";
			var f_ = new string[]
			{
				c_,
				d_,
				e_,
			};
			var g_ = (f_ as IEnumerable<string>);
			var h_ = context?.Operators.InList<string>(b_, g_);
			var i_ = (RecentHbA1c?.Effective as object);
			var j_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(i_);
			var k_ = this.Measurement_Period();
			var l_ = context?.Operators.ElementInInterval<CqlDateTime>(j_, k_, null);

			return context?.Operators.And(h_, l_);
		};
		var r_ = context?.Operators.WhereOrNull<Observation>(p_, q_);
		var s_ = (Observation @this) =>
		{
			var m_ = (@this?.Effective as object);
			var n_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(m_);

			return context?.Operators.Start(n_);
		};
		var t_ = context?.Operators.ListSortBy<Observation>(r_, s_, System.ComponentModel.ListSortDirection.Ascending);

		return context?.Operators.LastOfList<Observation>(t_);
	}

    [CqlDeclaration("Most Recent HbA1c")]
    public Observation Most_Recent_HbA1c() => __Most_Recent_HbA1c.Value;

    private bool? Has_Most_Recent_HbA1c_Without_Result_Value()
	{
		var a_ = (bool?)(this.Most_Recent_HbA1c() == null);
		var b_ = context?.Operators.Not(a_);
		var c_ = (bool?)((this.Most_Recent_HbA1c()?.Value as object) == null);

		return context?.Operators.And(b_, c_);
	}

    [CqlDeclaration("Has Most Recent HbA1c Without Result")]
    public bool? Has_Most_Recent_HbA1c_Without_Result() => __Has_Most_Recent_HbA1c_Without_Result.Value;

    private bool? Has_Most_Recent_Elevated_HbA1c_Value()
	{
		var a_ = ((this.Most_Recent_HbA1c()?.Value as object) as Quantity);
		var b_ = FHIRHelpers_4_0_001.ToQuantity(a_);
		var c_ = (b_ as object);
		var d_ = (context?.Operators.Quantity(9m, "%") as object);

		return context?.Operators.Greater(c_, d_);
	}

    [CqlDeclaration("Has Most Recent Elevated HbA1c")]
    public bool? Has_Most_Recent_Elevated_HbA1c() => __Has_Most_Recent_Elevated_HbA1c.Value;

    private bool? Has_No_Record_Of_HbA1c_Value()
	{
		var m_ = this.HbA1c_Laboratory_Test();
		var n_ = context?.DataRetriever.RetrieveByValueSet<Observation>(m_, null);
		var o_ = (Observation NoHbA1c) =>
		{
			var a_ = (NoHbA1c?.StatusElement as object);
			var b_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(a_);
			var c_ = "final";
			var d_ = "amended";
			var e_ = "corrected";
			var f_ = new string[]
			{
				c_,
				d_,
				e_,
			};
			var g_ = (f_ as IEnumerable<string>);
			var h_ = context?.Operators.InList<string>(b_, g_);
			var i_ = (NoHbA1c?.Effective as object);
			var j_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(i_);
			var k_ = this.Measurement_Period();
			var l_ = context?.Operators.ElementInInterval<CqlDateTime>(j_, k_, null);

			return context?.Operators.And(h_, l_);
		};
		var p_ = context?.Operators.WhereOrNull<Observation>(n_, o_);
		var q_ = context?.Operators.ExistsInList<Observation>(p_);

		return context?.Operators.Not(q_);
	}

    [CqlDeclaration("Has No Record Of HbA1c")]
    public bool? Has_No_Record_Of_HbA1c() => __Has_No_Record_Of_HbA1c.Value;

    private bool? Numerator_Value()
	{
		var a_ = this.Has_Most_Recent_HbA1c_Without_Result();
		var b_ = this.Has_Most_Recent_Elevated_HbA1c();
		var c_ = context?.Operators.Or(a_, b_);
		var d_ = this.Has_No_Record_Of_HbA1c();

		return context?.Operators.Or(c_, d_);
	}

    [CqlDeclaration("Numerator")]
    public bool? Numerator() => __Numerator.Value;

    private bool? Denominator_Exclusions_Value()
	{
		var a_ = HospiceFHIR4_2_3_000.Has_Hospice();
		var b_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80();
		var c_ = context?.Operators.Or(a_, b_);
		var d_ = (this.Patient()?.BirthDateElement?.Value as object);
		var e_ = context?.Operators?.TypeConverter.Convert<CqlDate>(d_);
		var f_ = this.Measurement_Period();
		var g_ = context?.Operators.Start(f_);
		var h_ = context?.Operators.DateFrom(g_);
		var i_ = context?.Operators.CalculateAgeAt(e_, h_, "year");
		var j_ = (i_ as object);
		var k_ = ((int?)65 as object);
		var l_ = context?.Operators.GreaterOrEqual(j_, k_);
		var m_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days();
		var n_ = context?.Operators.And(l_, m_);
		var o_ = context?.Operators.Or(c_, n_);
		var p_ = PalliativeCareFHIR_0_6_000.Palliative_Care_in_the_Measurement_Period();

		return context?.Operators.Or(o_, p_);
	}

    [CqlDeclaration("Denominator Exclusions")]
    public bool? Denominator_Exclusions() => __Denominator_Exclusions.Value;

}