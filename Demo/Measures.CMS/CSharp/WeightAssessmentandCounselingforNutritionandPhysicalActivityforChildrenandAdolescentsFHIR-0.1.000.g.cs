﻿using System;
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
[CqlLibrary("WeightAssessmentandCounselingforNutritionandPhysicalActivityforChildrenandAdolescentsFHIR", "0.1.000")]
public class WeightAssessmentandCounselingforNutritionandPhysicalActivityforChildrenandAdolescentsFHIR_0_1_000
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __BMI_percentile;
    internal Lazy<CqlValueSet> __Counseling_for_Nutrition;
    internal Lazy<CqlValueSet> __Counseling_for_Physical_Activity;
    internal Lazy<CqlValueSet> __Discharged_to_Health_Care_Facility_for_Hospice_Care;
    internal Lazy<CqlValueSet> __Discharged_to_Home_for_Hospice_Care;
    internal Lazy<CqlValueSet> __Encounter_Inpatient;
    internal Lazy<CqlValueSet> __Height;
    internal Lazy<CqlValueSet> __Home_Healthcare_Services;
    internal Lazy<CqlValueSet> __Hospice_care_ambulatory;
    internal Lazy<CqlValueSet> __Office_Visit;
    internal Lazy<CqlValueSet> __Pregnancy;
    internal Lazy<CqlValueSet> __Preventive_Care_Services___Group_Counseling;
    internal Lazy<CqlValueSet> __Preventive_Care_Services__Initial_Office_Visit__0_to_17;
    internal Lazy<CqlValueSet> __Preventive_Care_Services_Individual_Counseling;
    internal Lazy<CqlValueSet> __Preventive_Care__Established_Office_Visit__0_to_17;
    internal Lazy<CqlValueSet> __Telephone_Visits;
    internal Lazy<CqlValueSet> __Weight;
    internal Lazy<CqlCode> ___in_i_;
    internal Lazy<CqlCode> ___lb_av_;
    internal Lazy<CqlCode> __Birth_date;
    internal Lazy<CqlCode> __Body_height;
    internal Lazy<CqlCode> __Body_mass_index__BMI___Ratio_;
    internal Lazy<CqlCode> __Body_weight;
    internal Lazy<CqlCode> __cm;
    internal Lazy<CqlCode> __exam;
    internal Lazy<CqlCode> __g;
    internal Lazy<CqlCode> __kg;
    internal Lazy<CqlCode> __vital_signs;
    internal Lazy<CqlCode[]> __UCUM;
    internal Lazy<CqlCode[]> __LOINC;
    internal Lazy<CqlCode[]> __ObservationCategoryCodes;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ>> __SDE_Payer;
    internal Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;
    internal Lazy<IEnumerable<Encounter>> __Qualifying_Encounter;
    internal Lazy<bool?> __Initial_Population;
    internal Lazy<bool?> __Denominator;
    internal Lazy<IEnumerable<Condition>> __Pregnancy_Diagnosis_Which_Overlaps_Measurement_Period;
    internal Lazy<bool?> __Denominator_Exclusions;
    internal Lazy<IEnumerable<Observation>> __BMI_Percentile_in_Measurement_Period;
    internal Lazy<IEnumerable<Observation>> __Height_in_Measurement_Period;
    internal Lazy<IEnumerable<Observation>> __Weight_in_Measurement_Period;
    internal Lazy<bool?> __Numerator_1;
    internal Lazy<bool?> __Numerator_2;
    internal Lazy<bool?> __Numerator_3;
    internal Lazy<bool?> __Stratifaction_1;
    internal Lazy<bool?> __Stratifaction_2;

    #endregion
    public WeightAssessmentandCounselingforNutritionandPhysicalActivityforChildrenandAdolescentsFHIR_0_1_000(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_3_000 = new FHIRHelpers_4_3_000(context);
        QICoreCommon_2_0_000 = new QICoreCommon_2_0_000(context);
        SupplementalDataElements_3_4_000 = new SupplementalDataElements_3_4_000(context);
        Hospice_6_9_000 = new Hospice_6_9_000(context);
        Status_1_6_000 = new Status_1_6_000(context);

        __BMI_percentile = new Lazy<CqlValueSet>(this.BMI_percentile_Value);
        __Counseling_for_Nutrition = new Lazy<CqlValueSet>(this.Counseling_for_Nutrition_Value);
        __Counseling_for_Physical_Activity = new Lazy<CqlValueSet>(this.Counseling_for_Physical_Activity_Value);
        __Discharged_to_Health_Care_Facility_for_Hospice_Care = new Lazy<CqlValueSet>(this.Discharged_to_Health_Care_Facility_for_Hospice_Care_Value);
        __Discharged_to_Home_for_Hospice_Care = new Lazy<CqlValueSet>(this.Discharged_to_Home_for_Hospice_Care_Value);
        __Encounter_Inpatient = new Lazy<CqlValueSet>(this.Encounter_Inpatient_Value);
        __Height = new Lazy<CqlValueSet>(this.Height_Value);
        __Home_Healthcare_Services = new Lazy<CqlValueSet>(this.Home_Healthcare_Services_Value);
        __Hospice_care_ambulatory = new Lazy<CqlValueSet>(this.Hospice_care_ambulatory_Value);
        __Office_Visit = new Lazy<CqlValueSet>(this.Office_Visit_Value);
        __Pregnancy = new Lazy<CqlValueSet>(this.Pregnancy_Value);
        __Preventive_Care_Services___Group_Counseling = new Lazy<CqlValueSet>(this.Preventive_Care_Services___Group_Counseling_Value);
        __Preventive_Care_Services__Initial_Office_Visit__0_to_17 = new Lazy<CqlValueSet>(this.Preventive_Care_Services__Initial_Office_Visit__0_to_17_Value);
        __Preventive_Care_Services_Individual_Counseling = new Lazy<CqlValueSet>(this.Preventive_Care_Services_Individual_Counseling_Value);
        __Preventive_Care__Established_Office_Visit__0_to_17 = new Lazy<CqlValueSet>(this.Preventive_Care__Established_Office_Visit__0_to_17_Value);
        __Telephone_Visits = new Lazy<CqlValueSet>(this.Telephone_Visits_Value);
        __Weight = new Lazy<CqlValueSet>(this.Weight_Value);
        ___in_i_ = new Lazy<CqlCode>(this._in_i__Value);
        ___lb_av_ = new Lazy<CqlCode>(this._lb_av__Value);
        __Birth_date = new Lazy<CqlCode>(this.Birth_date_Value);
        __Body_height = new Lazy<CqlCode>(this.Body_height_Value);
        __Body_mass_index__BMI___Ratio_ = new Lazy<CqlCode>(this.Body_mass_index__BMI___Ratio__Value);
        __Body_weight = new Lazy<CqlCode>(this.Body_weight_Value);
        __cm = new Lazy<CqlCode>(this.cm_Value);
        __exam = new Lazy<CqlCode>(this.exam_Value);
        __g = new Lazy<CqlCode>(this.g_Value);
        __kg = new Lazy<CqlCode>(this.kg_Value);
        __vital_signs = new Lazy<CqlCode>(this.vital_signs_Value);
        __UCUM = new Lazy<CqlCode[]>(this.UCUM_Value);
        __LOINC = new Lazy<CqlCode[]>(this.LOINC_Value);
        __ObservationCategoryCodes = new Lazy<CqlCode[]>(this.ObservationCategoryCodes_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __SDE_Ethnicity = new Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
        __Qualifying_Encounter = new Lazy<IEnumerable<Encounter>>(this.Qualifying_Encounter_Value);
        __Initial_Population = new Lazy<bool?>(this.Initial_Population_Value);
        __Denominator = new Lazy<bool?>(this.Denominator_Value);
        __Pregnancy_Diagnosis_Which_Overlaps_Measurement_Period = new Lazy<IEnumerable<Condition>>(this.Pregnancy_Diagnosis_Which_Overlaps_Measurement_Period_Value);
        __Denominator_Exclusions = new Lazy<bool?>(this.Denominator_Exclusions_Value);
        __BMI_Percentile_in_Measurement_Period = new Lazy<IEnumerable<Observation>>(this.BMI_Percentile_in_Measurement_Period_Value);
        __Height_in_Measurement_Period = new Lazy<IEnumerable<Observation>>(this.Height_in_Measurement_Period_Value);
        __Weight_in_Measurement_Period = new Lazy<IEnumerable<Observation>>(this.Weight_in_Measurement_Period_Value);
        __Numerator_1 = new Lazy<bool?>(this.Numerator_1_Value);
        __Numerator_2 = new Lazy<bool?>(this.Numerator_2_Value);
        __Numerator_3 = new Lazy<bool?>(this.Numerator_3_Value);
        __Stratifaction_1 = new Lazy<bool?>(this.Stratifaction_1_Value);
        __Stratifaction_2 = new Lazy<bool?>(this.Stratifaction_2_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_3_000 FHIRHelpers_4_3_000 { get; }
    public QICoreCommon_2_0_000 QICoreCommon_2_0_000 { get; }
    public SupplementalDataElements_3_4_000 SupplementalDataElements_3_4_000 { get; }
    public Hospice_6_9_000 Hospice_6_9_000 { get; }
    public Status_1_6_000 Status_1_6_000 { get; }

    #endregion

	private CqlValueSet BMI_percentile_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.121.12.1012", null);

    [CqlDeclaration("BMI percentile")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.121.12.1012")]
	public CqlValueSet BMI_percentile() => 
		__BMI_percentile.Value;

	private CqlValueSet Counseling_for_Nutrition_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.195.12.1003", null);

    [CqlDeclaration("Counseling for Nutrition")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.195.12.1003")]
	public CqlValueSet Counseling_for_Nutrition() => 
		__Counseling_for_Nutrition.Value;

	private CqlValueSet Counseling_for_Physical_Activity_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.118.12.1035", null);

    [CqlDeclaration("Counseling for Physical Activity")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.118.12.1035")]
	public CqlValueSet Counseling_for_Physical_Activity() => 
		__Counseling_for_Physical_Activity.Value;

	private CqlValueSet Discharged_to_Health_Care_Facility_for_Hospice_Care_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207", null);

    [CqlDeclaration("Discharged to Health Care Facility for Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207")]
	public CqlValueSet Discharged_to_Health_Care_Facility_for_Hospice_Care() => 
		__Discharged_to_Health_Care_Facility_for_Hospice_Care.Value;

	private CqlValueSet Discharged_to_Home_for_Hospice_Care_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209", null);

    [CqlDeclaration("Discharged to Home for Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209")]
	public CqlValueSet Discharged_to_Home_for_Hospice_Care() => 
		__Discharged_to_Home_for_Hospice_Care.Value;

	private CqlValueSet Encounter_Inpatient_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
	public CqlValueSet Encounter_Inpatient() => 
		__Encounter_Inpatient.Value;

	private CqlValueSet Height_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.121.12.1014", null);

    [CqlDeclaration("Height")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.121.12.1014")]
	public CqlValueSet Height() => 
		__Height.Value;

	private CqlValueSet Home_Healthcare_Services_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);

    [CqlDeclaration("Home Healthcare Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016")]
	public CqlValueSet Home_Healthcare_Services() => 
		__Home_Healthcare_Services.Value;

	private CqlValueSet Hospice_care_ambulatory_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15", null);

    [CqlDeclaration("Hospice care ambulatory")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15")]
	public CqlValueSet Hospice_care_ambulatory() => 
		__Hospice_care_ambulatory.Value;

	private CqlValueSet Office_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
	public CqlValueSet Office_Visit() => 
		__Office_Visit.Value;

	private CqlValueSet Pregnancy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.378", null);

    [CqlDeclaration("Pregnancy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.378")]
	public CqlValueSet Pregnancy() => 
		__Pregnancy.Value;

	private CqlValueSet Preventive_Care_Services___Group_Counseling_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1027", null);

    [CqlDeclaration("Preventive Care Services - Group Counseling")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1027")]
	public CqlValueSet Preventive_Care_Services___Group_Counseling() => 
		__Preventive_Care_Services___Group_Counseling.Value;

	private CqlValueSet Preventive_Care_Services__Initial_Office_Visit__0_to_17_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", null);

    [CqlDeclaration("Preventive Care Services, Initial Office Visit, 0 to 17")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022")]
	public CqlValueSet Preventive_Care_Services__Initial_Office_Visit__0_to_17() => 
		__Preventive_Care_Services__Initial_Office_Visit__0_to_17.Value;

	private CqlValueSet Preventive_Care_Services_Individual_Counseling_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026", null);

    [CqlDeclaration("Preventive Care Services-Individual Counseling")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026")]
	public CqlValueSet Preventive_Care_Services_Individual_Counseling() => 
		__Preventive_Care_Services_Individual_Counseling.Value;

	private CqlValueSet Preventive_Care__Established_Office_Visit__0_to_17_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", null);

    [CqlDeclaration("Preventive Care, Established Office Visit, 0 to 17")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024")]
	public CqlValueSet Preventive_Care__Established_Office_Visit__0_to_17() => 
		__Preventive_Care__Established_Office_Visit__0_to_17.Value;

	private CqlValueSet Telephone_Visits_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
	public CqlValueSet Telephone_Visits() => 
		__Telephone_Visits.Value;

	private CqlValueSet Weight_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.121.12.1015", null);

    [CqlDeclaration("Weight")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.121.12.1015")]
	public CqlValueSet Weight() => 
		__Weight.Value;

	private CqlCode _in_i__Value() => 
		new CqlCode("[in_i]", "http://unitsofmeasure.org", null, null);

    [CqlDeclaration("[in_i]")]
	public CqlCode _in_i_() => 
		___in_i_.Value;

	private CqlCode _lb_av__Value() => 
		new CqlCode("[lb_av]", "http://unitsofmeasure.org", null, null);

    [CqlDeclaration("[lb_av]")]
	public CqlCode _lb_av_() => 
		___lb_av_.Value;

	private CqlCode Birth_date_Value() => 
		new CqlCode("21112-8", "http://loinc.org", null, null);

    [CqlDeclaration("Birth date")]
	public CqlCode Birth_date() => 
		__Birth_date.Value;

	private CqlCode Body_height_Value() => 
		new CqlCode("8302-2", "http://loinc.org", null, null);

    [CqlDeclaration("Body height")]
	public CqlCode Body_height() => 
		__Body_height.Value;

	private CqlCode Body_mass_index__BMI___Ratio__Value() => 
		new CqlCode("39156-5", "http://loinc.org", null, null);

    [CqlDeclaration("Body mass index (BMI) [Ratio]")]
	public CqlCode Body_mass_index__BMI___Ratio_() => 
		__Body_mass_index__BMI___Ratio_.Value;

	private CqlCode Body_weight_Value() => 
		new CqlCode("29463-7", "http://loinc.org", null, null);

    [CqlDeclaration("Body weight")]
	public CqlCode Body_weight() => 
		__Body_weight.Value;

	private CqlCode cm_Value() => 
		new CqlCode("cm", "http://unitsofmeasure.org", null, null);

    [CqlDeclaration("cm")]
	public CqlCode cm() => 
		__cm.Value;

	private CqlCode exam_Value() => 
		new CqlCode("exam", "http://terminology.hl7.org/CodeSystem/observation-category", null, null);

    [CqlDeclaration("exam")]
	public CqlCode exam() => 
		__exam.Value;

	private CqlCode g_Value() => 
		new CqlCode("g", "http://unitsofmeasure.org", null, null);

    [CqlDeclaration("g")]
	public CqlCode g() => 
		__g.Value;

	private CqlCode kg_Value() => 
		new CqlCode("kg", "http://unitsofmeasure.org", null, null);

    [CqlDeclaration("kg")]
	public CqlCode kg() => 
		__kg.Value;

	private CqlCode vital_signs_Value() => 
		new CqlCode("vital-signs", "http://terminology.hl7.org/CodeSystem/observation-category", null, null);

    [CqlDeclaration("vital-signs")]
	public CqlCode vital_signs() => 
		__vital_signs.Value;

	private CqlCode[] UCUM_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("[in_i]", "http://unitsofmeasure.org", null, null),
			new CqlCode("[lb_av]", "http://unitsofmeasure.org", null, null),
			new CqlCode("cm", "http://unitsofmeasure.org", null, null),
			new CqlCode("g", "http://unitsofmeasure.org", null, null),
			new CqlCode("kg", "http://unitsofmeasure.org", null, null),
		};

		return a_;
	}

    [CqlDeclaration("UCUM")]
	public CqlCode[] UCUM() => 
		__UCUM.Value;

	private CqlCode[] LOINC_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("21112-8", "http://loinc.org", null, null),
			new CqlCode("8302-2", "http://loinc.org", null, null),
			new CqlCode("39156-5", "http://loinc.org", null, null),
			new CqlCode("29463-7", "http://loinc.org", null, null),
		};

		return a_;
	}

    [CqlDeclaration("LOINC")]
	public CqlCode[] LOINC() => 
		__LOINC.Value;

	private CqlCode[] ObservationCategoryCodes_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("exam", "http://terminology.hl7.org/CodeSystem/observation-category", null, null),
			new CqlCode("vital-signs", "http://terminology.hl7.org/CodeSystem/observation-category", null, null),
		};

		return a_;
	}

    [CqlDeclaration("ObservationCategoryCodes")]
	public CqlCode[] ObservationCategoryCodes() => 
		__ObservationCategoryCodes.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		var b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		var c_ = context.Operators.Interval(a_, b_, true, false);
		var d_ = context.ResolveParameter("WeightAssessmentandCounselingforNutritionandPhysicalActivityforChildrenandAdolescentsFHIR-0.1.000", "Measurement Period", c_);

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

	private IEnumerable<Encounter> Qualifying_Encounter_Value()
	{
		var a_ = this.Office_Visit();
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		var c_ = this.Preventive_Care_Services_Individual_Counseling();
		var d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, null);
		var e_ = context.Operators.Union<Encounter>(b_, d_);
		var f_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17();
		var g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, null);
		var h_ = this.Preventive_Care__Established_Office_Visit__0_to_17();
		var i_ = context.Operators.RetrieveByValueSet<Encounter>(h_, null);
		var j_ = context.Operators.Union<Encounter>(g_, i_);
		var k_ = context.Operators.Union<Encounter>(e_, j_);
		var l_ = this.Preventive_Care_Services___Group_Counseling();
		var m_ = context.Operators.RetrieveByValueSet<Encounter>(l_, null);
		var n_ = this.Home_Healthcare_Services();
		var o_ = context.Operators.RetrieveByValueSet<Encounter>(n_, null);
		var p_ = context.Operators.Union<Encounter>(m_, o_);
		var q_ = context.Operators.Union<Encounter>(k_, p_);
		var r_ = this.Telephone_Visits();
		var s_ = context.Operators.RetrieveByValueSet<Encounter>(r_, null);
		var t_ = context.Operators.Union<Encounter>(q_, s_);
		var u_ = Status_1_6_000.Finished_Encounter(t_);
		bool? v_(Encounter ValidEncounters)
		{
			var x_ = this.Measurement_Period();
			var y_ = ValidEncounters?.Period;
			var z_ = FHIRHelpers_4_3_000.ToInterval(y_);
			var aa_ = QICoreCommon_2_0_000.ToInterval((z_ as object));
			var ab_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(x_, aa_, null);

			return ab_;
		};
		var w_ = context.Operators.Where<Encounter>(u_, v_);

		return w_;
	}

    [CqlDeclaration("Qualifying Encounter")]
	public IEnumerable<Encounter> Qualifying_Encounter() => 
		__Qualifying_Encounter.Value;

	private bool? Initial_Population_Value()
	{
		var a_ = this.Patient();
		var b_ = context.Operators.Convert<CqlDate>(a_?.BirthDateElement?.Value);
		var c_ = this.Measurement_Period();
		var d_ = context.Operators.End(c_);
		var e_ = context.Operators.DateFrom(d_);
		var f_ = context.Operators.CalculateAgeAt(b_, e_, "year");
		var g_ = context.Operators.Interval(3, 17, true, true);
		var h_ = context.Operators.In<int?>(f_, g_, null);
		var i_ = this.Qualifying_Encounter();
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

	private IEnumerable<Condition> Pregnancy_Diagnosis_Which_Overlaps_Measurement_Period_Value()
	{
		var a_ = this.Pregnancy();
		var b_ = context.Operators.RetrieveByValueSet<Condition>(a_, null);
		var c_ = Status_1_6_000.Active_Condition(b_);
		bool? d_(Condition Pregnancy)
		{
			var f_ = QICoreCommon_2_0_000.ToPrevalenceInterval(Pregnancy);
			var g_ = this.Measurement_Period();
			var h_ = context.Operators.Overlaps(f_, g_, null);

			return h_;
		};
		var e_ = context.Operators.Where<Condition>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Pregnancy Diagnosis Which Overlaps Measurement Period")]
	public IEnumerable<Condition> Pregnancy_Diagnosis_Which_Overlaps_Measurement_Period() => 
		__Pregnancy_Diagnosis_Which_Overlaps_Measurement_Period.Value;

	private bool? Denominator_Exclusions_Value()
	{
		var a_ = Hospice_6_9_000.Has_Hospice_Services();
		var b_ = this.Pregnancy_Diagnosis_Which_Overlaps_Measurement_Period();
		var c_ = context.Operators.Exists<Condition>(b_);
		var d_ = context.Operators.Or(a_, c_);

		return d_;
	}

    [CqlDeclaration("Denominator Exclusions")]
	public bool? Denominator_Exclusions() => 
		__Denominator_Exclusions.Value;

	private IEnumerable<Observation> BMI_Percentile_in_Measurement_Period_Value()
	{
		var a_ = context.Operators.RetrieveByValueSet<Observation>(null, null);
		var b_ = Status_1_6_000.BMI(a_);
		bool? c_(Observation BMIPercentile)
		{
			var e_ = this.Measurement_Period();
			var f_ = BMIPercentile?.Effective;
			var g_ = FHIRHelpers_4_3_000.ToValue(f_);
			var h_ = QICoreCommon_2_0_000.ToInterval(g_);
			var i_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(e_, h_, "day");
			var j_ = BMIPercentile?.Value;
			var k_ = context.Operators.Convert<Quantity>(j_);
			var l_ = FHIRHelpers_4_3_000.ToQuantity(k_);
			var m_ = context.Operators.Not((bool?)(l_ is null));
			var n_ = context.Operators.And(i_, m_);

			return n_;
		};
		var d_ = context.Operators.Where<Observation>(b_, c_);

		return d_;
	}

    [CqlDeclaration("BMI Percentile in Measurement Period")]
	public IEnumerable<Observation> BMI_Percentile_in_Measurement_Period() => 
		__BMI_Percentile_in_Measurement_Period.Value;

	private IEnumerable<Observation> Height_in_Measurement_Period_Value()
	{
		var a_ = context.Operators.RetrieveByValueSet<Observation>(null, null);
		var b_ = Status_1_6_000.BodyHeight(a_);
		bool? c_(Observation Height)
		{
			var e_ = this.Measurement_Period();
			var f_ = Height?.Effective;
			var g_ = FHIRHelpers_4_3_000.ToValue(f_);
			var h_ = QICoreCommon_2_0_000.ToInterval(g_);
			var i_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(e_, h_, "day");
			var j_ = Height?.Value;
			var k_ = context.Operators.Convert<Quantity>(j_);
			var l_ = FHIRHelpers_4_3_000.ToQuantity(k_);
			var m_ = context.Operators.Not((bool?)(l_ is null));
			var n_ = context.Operators.And(i_, m_);

			return n_;
		};
		var d_ = context.Operators.Where<Observation>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Height in Measurement Period")]
	public IEnumerable<Observation> Height_in_Measurement_Period() => 
		__Height_in_Measurement_Period.Value;

	private IEnumerable<Observation> Weight_in_Measurement_Period_Value()
	{
		var a_ = context.Operators.RetrieveByValueSet<Observation>(null, null);
		var b_ = Status_1_6_000.BodyWeight(a_);
		bool? c_(Observation Weight)
		{
			var e_ = this.Measurement_Period();
			var f_ = Weight?.Effective;
			var g_ = FHIRHelpers_4_3_000.ToValue(f_);
			var h_ = QICoreCommon_2_0_000.ToInterval(g_);
			var i_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(e_, h_, "day");
			var j_ = Weight?.Value;
			var k_ = context.Operators.Convert<Quantity>(j_);
			var l_ = FHIRHelpers_4_3_000.ToQuantity(k_);
			var m_ = context.Operators.Not((bool?)(l_ is null));
			var n_ = context.Operators.And(i_, m_);

			return n_;
		};
		var d_ = context.Operators.Where<Observation>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Weight in Measurement Period")]
	public IEnumerable<Observation> Weight_in_Measurement_Period() => 
		__Weight_in_Measurement_Period.Value;

	private bool? Numerator_1_Value()
	{
		var a_ = this.BMI_Percentile_in_Measurement_Period();
		var b_ = context.Operators.Exists<Observation>(a_);
		var c_ = this.Height_in_Measurement_Period();
		var d_ = context.Operators.Exists<Observation>(c_);
		var e_ = context.Operators.And(b_, d_);
		var f_ = this.Weight_in_Measurement_Period();
		var g_ = context.Operators.Exists<Observation>(f_);
		var h_ = context.Operators.And(e_, g_);

		return h_;
	}

    [CqlDeclaration("Numerator 1")]
	public bool? Numerator_1() => 
		__Numerator_1.Value;

	private bool? Numerator_2_Value()
	{
		var a_ = this.Counseling_for_Nutrition();
		var b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, null);
		var c_ = Status_1_6_000.Completed_Procedure(b_);
		bool? d_(Procedure NutritionCounseling)
		{
			var g_ = this.Measurement_Period();
			var h_ = NutritionCounseling?.Performed;
			var i_ = FHIRHelpers_4_3_000.ToValue(h_);
			var j_ = QICoreCommon_2_0_000.ToInterval(i_);
			var k_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(g_, j_, "day");

			return k_;
		};
		var e_ = context.Operators.Where<Procedure>(c_, d_);
		var f_ = context.Operators.Exists<Procedure>(e_);

		return f_;
	}

    [CqlDeclaration("Numerator 2")]
	public bool? Numerator_2() => 
		__Numerator_2.Value;

	private bool? Numerator_3_Value()
	{
		var a_ = this.Counseling_for_Physical_Activity();
		var b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, null);
		var c_ = Status_1_6_000.Completed_Procedure(b_);
		bool? d_(Procedure ActivityCounseling)
		{
			var g_ = this.Measurement_Period();
			var h_ = ActivityCounseling?.Performed;
			var i_ = FHIRHelpers_4_3_000.ToValue(h_);
			var j_ = QICoreCommon_2_0_000.ToInterval(i_);
			var k_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(g_, j_, "day");

			return k_;
		};
		var e_ = context.Operators.Where<Procedure>(c_, d_);
		var f_ = context.Operators.Exists<Procedure>(e_);

		return f_;
	}

    [CqlDeclaration("Numerator 3")]
	public bool? Numerator_3() => 
		__Numerator_3.Value;

	private bool? Stratifaction_1_Value()
	{
		var a_ = this.Patient();
		var b_ = context.Operators.Convert<CqlDate>(a_?.BirthDateElement?.Value);
		var c_ = this.Measurement_Period();
		var d_ = context.Operators.End(c_);
		var e_ = context.Operators.DateFrom(d_);
		var f_ = context.Operators.CalculateAgeAt(b_, e_, "year");
		var g_ = context.Operators.Interval(3, 11, true, true);
		var h_ = context.Operators.In<int?>(f_, g_, null);

		return h_;
	}

    [CqlDeclaration("Stratifaction 1")]
	public bool? Stratifaction_1() => 
		__Stratifaction_1.Value;

	private bool? Stratifaction_2_Value()
	{
		var a_ = this.Patient();
		var b_ = context.Operators.Convert<CqlDate>(a_?.BirthDateElement?.Value);
		var c_ = this.Measurement_Period();
		var d_ = context.Operators.End(c_);
		var e_ = context.Operators.DateFrom(d_);
		var f_ = context.Operators.CalculateAgeAt(b_, e_, "year");
		var g_ = context.Operators.Interval(12, 17, true, true);
		var h_ = context.Operators.In<int?>(f_, g_, null);

		return h_;
	}

    [CqlDeclaration("Stratifaction 2")]
	public bool? Stratifaction_2() => 
		__Stratifaction_2.Value;

}