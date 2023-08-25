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

    private CqlValueSet Annual_Wellness_Visit_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", null);

		return a_;
	}

    [CqlDeclaration("Annual Wellness Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240")]
    public CqlValueSet Annual_Wellness_Visit() => __Annual_Wellness_Visit.Value;

    private CqlValueSet Diabetes_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001", null);

		return a_;
	}

    [CqlDeclaration("Diabetes")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001")]
    public CqlValueSet Diabetes() => __Diabetes.Value;

    private CqlValueSet Discharged_to_Health_Care_Facility_for_Hospice_Care_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207", null);

		return a_;
	}

    [CqlDeclaration("Discharged to Health Care Facility for Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207")]
    public CqlValueSet Discharged_to_Health_Care_Facility_for_Hospice_Care() => __Discharged_to_Health_Care_Facility_for_Hospice_Care.Value;

    private CqlValueSet Discharged_to_Home_for_Hospice_Care_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209", null);

		return a_;
	}

    [CqlDeclaration("Discharged to Home for Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209")]
    public CqlValueSet Discharged_to_Home_for_Hospice_Care() => __Discharged_to_Home_for_Hospice_Care.Value;

    private CqlValueSet Encounter_Inpatient_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

		return a_;
	}

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
    public CqlValueSet Encounter_Inpatient() => __Encounter_Inpatient.Value;

    private CqlValueSet HbA1c_Laboratory_Test_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1013", null);

		return a_;
	}

    [CqlDeclaration("HbA1c Laboratory Test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1013")]
    public CqlValueSet HbA1c_Laboratory_Test() => __HbA1c_Laboratory_Test.Value;

    private CqlValueSet Home_Healthcare_Services_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);

		return a_;
	}

    [CqlDeclaration("Home Healthcare Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016")]
    public CqlValueSet Home_Healthcare_Services() => __Home_Healthcare_Services.Value;

    private CqlValueSet Hospice_care_ambulatory_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15", null);

		return a_;
	}

    [CqlDeclaration("Hospice care ambulatory")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15")]
    public CqlValueSet Hospice_care_ambulatory() => __Hospice_care_ambulatory.Value;

    private CqlValueSet Office_Visit_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

		return a_;
	}

    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
    public CqlValueSet Office_Visit() => __Office_Visit.Value;

    private CqlValueSet Preventive_Care_Services___Established_Office_Visit__18_and_Up_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);

		return a_;
	}

    [CqlDeclaration("Preventive Care Services - Established Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025")]
    public CqlValueSet Preventive_Care_Services___Established_Office_Visit__18_and_Up() => __Preventive_Care_Services___Established_Office_Visit__18_and_Up.Value;

    private CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);

		return a_;
	}

    [CqlDeclaration("Preventive Care Services-Initial Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023")]
    public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up() => __Preventive_Care_Services_Initial_Office_Visit__18_and_Up.Value;

    private CqlValueSet Telephone_Visits_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

		return a_;
	}

    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
    public CqlValueSet Telephone_Visits() => __Telephone_Visits.Value;

    private CqlCode Birth_date_Value()
	{
		var a_ = new CqlCode("21112-8", "http://loinc.org", null, null);

		return a_;
	}

    [CqlDeclaration("Birth date")]
    public CqlCode Birth_date() => __Birth_date.Value;

    private CqlCode[] LOINC_Value()
	{
		var a_ = new CqlCode("21112-8", "http://loinc.org", null, null);
		var b_ = new CqlCode[]
		{
			a_,
		};

		return b_;
	}

    [CqlDeclaration("LOINC")]
    public CqlCode[] LOINC() => __LOINC.Value;

    private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.ResolveParameter("DiabetesHemoglobinA1cHbA1cPoorControl9FHIR-0.0.015", "Measurement Period", null);
		var b_ = (CqlInterval<CqlDateTime>)a_;

		return b_;
	}

    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period() => __Measurement_Period.Value;

    private Patient Patient_Value()
	{
		var a_ = context.DataRetriever;
		var b_ = a_.RetrieveByValueSet<Patient>(null, null);
		var c_ = context.Operators;
		var d_ = c_.SingleOrNull<Patient>(b_);

		return d_;
	}

    [CqlDeclaration("Patient")]
    public Patient Patient() => __Patient.Value;

    private IEnumerable<Coding> SDE_Ethnicity_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity() => __SDE_Ethnicity.Value;

    private IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
    public IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer() => __SDE_Payer.Value;

    private IEnumerable<Coding> SDE_Race_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
    public IEnumerable<Coding> SDE_Race() => __SDE_Race.Value;

    private CqlCode SDE_Sex_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Sex();

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
    public CqlCode SDE_Sex() => __SDE_Sex.Value;

    private IEnumerable<Encounter> Telehealth_Services_Value()
	{
		var a_ = this.Telephone_Visits();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Encounter>(a_, null);
		var d_ = (Encounter TelehealthEncounter) =>
		{
			var g_ = TelehealthEncounter.StatusElement;
			var h_ = new CallStackEntry("ToString", null, null);
			var i_ = context.Deeper(h_);
			var j_ = i_.Operators;
			var k_ = j_.TypeConverter;
			var l_ = k_.Convert<string>(g_);
			var m_ = context.Operators;
			var n_ = m_.Equal(l_, "finished");
			var o_ = this.Measurement_Period();
			var p_ = TelehealthEncounter.Period;
			var q_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(p_);
			var s_ = m_.IntervalIncludesInterval<CqlDateTime>(o_, q_, null);
			var u_ = m_.And(n_, s_);

			return u_;
		};
		var e_ = context.Operators;
		var f_ = e_.WhereOrNull<Encounter>(c_, d_);

		return f_;
	}

    [CqlDeclaration("Telehealth Services")]
    public IEnumerable<Encounter> Telehealth_Services() => __Telehealth_Services.Value;

    private bool? Initial_Population_Value()
	{
		var a_ = this.Patient();
		var b_ = a_.BirthDateElement;
		var c_ = b_.Value;
		var d_ = context.Operators;
		var e_ = d_.TypeConverter;
		var f_ = e_.Convert<CqlDate>(c_);
		var g_ = this.Measurement_Period();
		var i_ = d_.Start(g_);
		var k_ = d_.DateFrom(i_);
		var m_ = d_.CalculateAgeAt(f_, k_, "year");
		var n_ = (int?)18;
		var o_ = (int?)75;
		var q_ = d_.Interval(n_, o_, true, false);
		var s_ = d_.ElementInInterval<int?>(m_, q_, null);
		var t_ = AdultOutpatientEncountersFHIR4_2_2_000.Qualifying_Encounters();
		var u_ = this.Telehealth_Services();
		var w_ = d_.ListUnion<Encounter>(t_, u_);
		var y_ = d_.ExistsInList<Encounter>(w_);
		var aa_ = d_.And(s_, y_);
		var ab_ = this.Diabetes();
		var ac_ = context.DataRetriever;
		var ad_ = ac_.RetrieveByValueSet<Condition>(ab_, null);
		var ae_ = (Condition Diabetes) =>
		{
			var al_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(Diabetes);
			var am_ = this.Measurement_Period();
			var an_ = context.Operators;
			var ao_ = an_.Overlaps(al_, am_, null);

			return ao_;
		};
		var ag_ = d_.WhereOrNull<Condition>(ad_, ae_);
		var ai_ = d_.ExistsInList<Condition>(ag_);
		var ak_ = d_.And(aa_, ai_);

		return ak_;
	}

    [CqlDeclaration("Initial Population")]
    public bool? Initial_Population() => __Initial_Population.Value;

    private bool? Denominator_Value()
	{
		var a_ = this.Initial_Population();

		return a_;
	}

    [CqlDeclaration("Denominator")]
    public bool? Denominator() => __Denominator.Value;

    private Observation Most_Recent_HbA1c_Value()
	{
		var a_ = this.HbA1c_Laboratory_Test();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Observation>(a_, null);
		var d_ = (Observation RecentHbA1c) =>
		{
			var l_ = RecentHbA1c.StatusElement;
			var m_ = new CallStackEntry("ToString", null, null);
			var n_ = context.Deeper(m_);
			var o_ = n_.Operators;
			var p_ = o_.TypeConverter;
			var q_ = p_.Convert<string>(l_);
			var r_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var s_ = (r_ as IEnumerable<string>);
			var t_ = context.Operators;
			var u_ = t_.InList<string>(q_, s_);
			var v_ = RecentHbA1c.Effective;
			var w_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(v_);
			var x_ = this.Measurement_Period();
			var z_ = t_.ElementInInterval<CqlDateTime>(w_, x_, null);
			var ab_ = t_.And(u_, z_);

			return ab_;
		};
		var e_ = context.Operators;
		var f_ = e_.WhereOrNull<Observation>(c_, d_);
		var g_ = (Observation @this) =>
		{
			var ac_ = @this.Effective;
			var ad_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(ac_);
			var ae_ = context.Operators;
			var af_ = ae_.Start(ad_);

			return af_;
		};
		var i_ = e_.ListSortBy<Observation>(f_, g_, System.ComponentModel.ListSortDirection.Ascending);
		var k_ = e_.LastOfList<Observation>(i_);

		return k_;
	}

    [CqlDeclaration("Most Recent HbA1c")]
    public Observation Most_Recent_HbA1c() => __Most_Recent_HbA1c.Value;

    private bool? Has_Most_Recent_HbA1c_Without_Result_Value()
	{
		var a_ = this.Most_Recent_HbA1c();
		var b_ = (a_ == null);
		var c_ = (bool?)b_;
		var d_ = context.Operators;
		var e_ = d_.Not(c_);
		var g_ = a_.Value;
		var h_ = (g_ == null);
		var i_ = (bool?)h_;
		var k_ = d_.And(e_, i_);

		return k_;
	}

    [CqlDeclaration("Has Most Recent HbA1c Without Result")]
    public bool? Has_Most_Recent_HbA1c_Without_Result() => __Has_Most_Recent_HbA1c_Without_Result.Value;

    private bool? Has_Most_Recent_Elevated_HbA1c_Value()
	{
		var a_ = this.Most_Recent_HbA1c();
		var b_ = a_.Value;
		var c_ = (b_ as Quantity);
		var d_ = FHIRHelpers_4_0_001.ToQuantity(c_);
		var e_ = context.Operators;
		var f_ = e_.Quantity(9m, "%");
		var h_ = e_.Greater(d_, f_);

		return h_;
	}

    [CqlDeclaration("Has Most Recent Elevated HbA1c")]
    public bool? Has_Most_Recent_Elevated_HbA1c() => __Has_Most_Recent_Elevated_HbA1c.Value;

    private bool? Has_No_Record_Of_HbA1c_Value()
	{
		var a_ = this.HbA1c_Laboratory_Test();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Observation>(a_, null);
		var d_ = (Observation NoHbA1c) =>
		{
			var k_ = NoHbA1c.StatusElement;
			var l_ = new CallStackEntry("ToString", null, null);
			var m_ = context.Deeper(l_);
			var n_ = m_.Operators;
			var o_ = n_.TypeConverter;
			var p_ = o_.Convert<string>(k_);
			var q_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var r_ = (q_ as IEnumerable<string>);
			var s_ = context.Operators;
			var t_ = s_.InList<string>(p_, r_);
			var u_ = NoHbA1c.Effective;
			var v_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Latest(u_);
			var w_ = this.Measurement_Period();
			var y_ = s_.ElementInInterval<CqlDateTime>(v_, w_, null);
			var aa_ = s_.And(t_, y_);

			return aa_;
		};
		var e_ = context.Operators;
		var f_ = e_.WhereOrNull<Observation>(c_, d_);
		var h_ = e_.ExistsInList<Observation>(f_);
		var j_ = e_.Not(h_);

		return j_;
	}

    [CqlDeclaration("Has No Record Of HbA1c")]
    public bool? Has_No_Record_Of_HbA1c() => __Has_No_Record_Of_HbA1c.Value;

    private bool? Numerator_Value()
	{
		var a_ = this.Has_Most_Recent_HbA1c_Without_Result();
		var b_ = this.Has_Most_Recent_Elevated_HbA1c();
		var c_ = context.Operators;
		var d_ = c_.Or(a_, b_);
		var e_ = this.Has_No_Record_Of_HbA1c();
		var g_ = c_.Or(d_, e_);

		return g_;
	}

    [CqlDeclaration("Numerator")]
    public bool? Numerator() => __Numerator.Value;

    private bool? Denominator_Exclusions_Value()
	{
		var a_ = HospiceFHIR4_2_3_000.Has_Hospice();
		var b_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80();
		var c_ = context.Operators;
		var d_ = c_.Or(a_, b_);
		var e_ = this.Patient();
		var f_ = e_.BirthDateElement;
		var g_ = f_.Value;
		var i_ = c_.TypeConverter;
		var j_ = i_.Convert<CqlDate>(g_);
		var k_ = this.Measurement_Period();
		var m_ = c_.Start(k_);
		var o_ = c_.DateFrom(m_);
		var q_ = c_.CalculateAgeAt(j_, o_, "year");
		var r_ = q_;
		var s_ = (int?)65;
		var t_ = s_;
		var v_ = c_.GreaterOrEqual(r_, t_);
		var w_ = AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days();
		var y_ = c_.And(v_, w_);
		var aa_ = c_.Or(d_, y_);
		var ab_ = PalliativeCareFHIR_0_6_000.Palliative_Care_in_the_Measurement_Period();
		var ad_ = c_.Or(aa_, ab_);

		return ad_;
	}

    [CqlDeclaration("Denominator Exclusions")]
    public bool? Denominator_Exclusions() => __Denominator_Exclusions.Value;

}