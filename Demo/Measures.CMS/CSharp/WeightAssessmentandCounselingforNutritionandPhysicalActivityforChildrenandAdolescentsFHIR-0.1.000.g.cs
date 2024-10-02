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
    internal Lazy<(IEnumerable<CqlCode> codes, string display)?> __SDE_Ethnicity;
    internal Lazy<IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?>> __SDE_Payer;
    internal Lazy<(IEnumerable<CqlCode> codes, string display)?> __SDE_Race;
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
        __SDE_Ethnicity = new Lazy<(IEnumerable<CqlCode> codes, string display)?>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<(IEnumerable<CqlCode> codes, string display)?>(this.SDE_Race_Value);
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
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.121.12.1012", default);

    [CqlDeclaration("BMI percentile")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.121.12.1012")]
	public CqlValueSet BMI_percentile() => 
		__BMI_percentile.Value;

	private CqlValueSet Counseling_for_Nutrition_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.195.12.1003", default);

    [CqlDeclaration("Counseling for Nutrition")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.195.12.1003")]
	public CqlValueSet Counseling_for_Nutrition() => 
		__Counseling_for_Nutrition.Value;

	private CqlValueSet Counseling_for_Physical_Activity_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.118.12.1035", default);

    [CqlDeclaration("Counseling for Physical Activity")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.118.12.1035")]
	public CqlValueSet Counseling_for_Physical_Activity() => 
		__Counseling_for_Physical_Activity.Value;

	private CqlValueSet Discharged_to_Health_Care_Facility_for_Hospice_Care_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207", default);

    [CqlDeclaration("Discharged to Health Care Facility for Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207")]
	public CqlValueSet Discharged_to_Health_Care_Facility_for_Hospice_Care() => 
		__Discharged_to_Health_Care_Facility_for_Hospice_Care.Value;

	private CqlValueSet Discharged_to_Home_for_Hospice_Care_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209", default);

    [CqlDeclaration("Discharged to Home for Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209")]
	public CqlValueSet Discharged_to_Home_for_Hospice_Care() => 
		__Discharged_to_Home_for_Hospice_Care.Value;

	private CqlValueSet Encounter_Inpatient_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", default);

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
	public CqlValueSet Encounter_Inpatient() => 
		__Encounter_Inpatient.Value;

	private CqlValueSet Height_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.121.12.1014", default);

    [CqlDeclaration("Height")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.121.12.1014")]
	public CqlValueSet Height() => 
		__Height.Value;

	private CqlValueSet Home_Healthcare_Services_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", default);

    [CqlDeclaration("Home Healthcare Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016")]
	public CqlValueSet Home_Healthcare_Services() => 
		__Home_Healthcare_Services.Value;

	private CqlValueSet Hospice_care_ambulatory_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15", default);

    [CqlDeclaration("Hospice care ambulatory")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15")]
	public CqlValueSet Hospice_care_ambulatory() => 
		__Hospice_care_ambulatory.Value;

	private CqlValueSet Office_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", default);

    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
	public CqlValueSet Office_Visit() => 
		__Office_Visit.Value;

	private CqlValueSet Pregnancy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.378", default);

    [CqlDeclaration("Pregnancy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.378")]
	public CqlValueSet Pregnancy() => 
		__Pregnancy.Value;

	private CqlValueSet Preventive_Care_Services___Group_Counseling_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1027", default);

    [CqlDeclaration("Preventive Care Services - Group Counseling")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1027")]
	public CqlValueSet Preventive_Care_Services___Group_Counseling() => 
		__Preventive_Care_Services___Group_Counseling.Value;

	private CqlValueSet Preventive_Care_Services__Initial_Office_Visit__0_to_17_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", default);

    [CqlDeclaration("Preventive Care Services, Initial Office Visit, 0 to 17")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022")]
	public CqlValueSet Preventive_Care_Services__Initial_Office_Visit__0_to_17() => 
		__Preventive_Care_Services__Initial_Office_Visit__0_to_17.Value;

	private CqlValueSet Preventive_Care_Services_Individual_Counseling_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026", default);

    [CqlDeclaration("Preventive Care Services-Individual Counseling")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026")]
	public CqlValueSet Preventive_Care_Services_Individual_Counseling() => 
		__Preventive_Care_Services_Individual_Counseling.Value;

	private CqlValueSet Preventive_Care__Established_Office_Visit__0_to_17_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", default);

    [CqlDeclaration("Preventive Care, Established Office Visit, 0 to 17")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024")]
	public CqlValueSet Preventive_Care__Established_Office_Visit__0_to_17() => 
		__Preventive_Care__Established_Office_Visit__0_to_17.Value;

	private CqlValueSet Telephone_Visits_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", default);

    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
	public CqlValueSet Telephone_Visits() => 
		__Telephone_Visits.Value;

	private CqlValueSet Weight_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.121.12.1015", default);

    [CqlDeclaration("Weight")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.121.12.1015")]
	public CqlValueSet Weight() => 
		__Weight.Value;

	private CqlCode _in_i__Value() => 
		new CqlCode("[in_i]", "http://unitsofmeasure.org", default, default);

    [CqlDeclaration("[in_i]")]
	public CqlCode _in_i_() => 
		___in_i_.Value;

	private CqlCode _lb_av__Value() => 
		new CqlCode("[lb_av]", "http://unitsofmeasure.org", default, default);

    [CqlDeclaration("[lb_av]")]
	public CqlCode _lb_av_() => 
		___lb_av_.Value;

	private CqlCode Birth_date_Value() => 
		new CqlCode("21112-8", "http://loinc.org", default, default);

    [CqlDeclaration("Birth date")]
	public CqlCode Birth_date() => 
		__Birth_date.Value;

	private CqlCode Body_height_Value() => 
		new CqlCode("8302-2", "http://loinc.org", default, default);

    [CqlDeclaration("Body height")]
	public CqlCode Body_height() => 
		__Body_height.Value;

	private CqlCode Body_mass_index__BMI___Ratio__Value() => 
		new CqlCode("39156-5", "http://loinc.org", default, default);

    [CqlDeclaration("Body mass index (BMI) [Ratio]")]
	public CqlCode Body_mass_index__BMI___Ratio_() => 
		__Body_mass_index__BMI___Ratio_.Value;

	private CqlCode Body_weight_Value() => 
		new CqlCode("29463-7", "http://loinc.org", default, default);

    [CqlDeclaration("Body weight")]
	public CqlCode Body_weight() => 
		__Body_weight.Value;

	private CqlCode cm_Value() => 
		new CqlCode("cm", "http://unitsofmeasure.org", default, default);

    [CqlDeclaration("cm")]
	public CqlCode cm() => 
		__cm.Value;

	private CqlCode exam_Value() => 
		new CqlCode("exam", "http://terminology.hl7.org/CodeSystem/observation-category", default, default);

    [CqlDeclaration("exam")]
	public CqlCode exam() => 
		__exam.Value;

	private CqlCode g_Value() => 
		new CqlCode("g", "http://unitsofmeasure.org", default, default);

    [CqlDeclaration("g")]
	public CqlCode g() => 
		__g.Value;

	private CqlCode kg_Value() => 
		new CqlCode("kg", "http://unitsofmeasure.org", default, default);

    [CqlDeclaration("kg")]
	public CqlCode kg() => 
		__kg.Value;

	private CqlCode vital_signs_Value() => 
		new CqlCode("vital-signs", "http://terminology.hl7.org/CodeSystem/observation-category", default, default);

    [CqlDeclaration("vital-signs")]
	public CqlCode vital_signs() => 
		__vital_signs.Value;

	private CqlCode[] UCUM_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("[in_i]", "http://unitsofmeasure.org", default, default),
			new CqlCode("[lb_av]", "http://unitsofmeasure.org", default, default),
			new CqlCode("cm", "http://unitsofmeasure.org", default, default),
			new CqlCode("g", "http://unitsofmeasure.org", default, default),
			new CqlCode("kg", "http://unitsofmeasure.org", default, default),
		];

		return a_;
	}

    [CqlDeclaration("UCUM")]
	public CqlCode[] UCUM() => 
		__UCUM.Value;

	private CqlCode[] LOINC_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("21112-8", "http://loinc.org", default, default),
			new CqlCode("8302-2", "http://loinc.org", default, default),
			new CqlCode("39156-5", "http://loinc.org", default, default),
			new CqlCode("29463-7", "http://loinc.org", default, default),
		];

		return a_;
	}

    [CqlDeclaration("LOINC")]
	public CqlCode[] LOINC() => 
		__LOINC.Value;

	private CqlCode[] ObservationCategoryCodes_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("exam", "http://terminology.hl7.org/CodeSystem/observation-category", default, default),
			new CqlCode("vital-signs", "http://terminology.hl7.org/CodeSystem/observation-category", default, default),
		];

		return a_;
	}

    [CqlDeclaration("ObservationCategoryCodes")]
	public CqlCode[] ObservationCategoryCodes() => 
		__ObservationCategoryCodes.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("WeightAssessmentandCounselingforNutritionandPhysicalActivityforChildrenandAdolescentsFHIR-0.1.000", "Measurement Period", c_);

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

	private IEnumerable<Encounter> Qualifying_Encounter_Value()
	{
		CqlValueSet a_ = this.Office_Visit();
		IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		CqlValueSet c_ = this.Preventive_Care_Services_Individual_Counseling();
		IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
		CqlValueSet f_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17();
		IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		CqlValueSet h_ = this.Preventive_Care__Established_Office_Visit__0_to_17();
		IEnumerable<Encounter> i_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
		IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
		CqlValueSet l_ = this.Preventive_Care_Services___Group_Counseling();
		IEnumerable<Encounter> m_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		CqlValueSet n_ = this.Home_Healthcare_Services();
		IEnumerable<Encounter> o_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> p_ = context.Operators.Union<Encounter>(m_, o_);
		IEnumerable<Encounter> q_ = context.Operators.Union<Encounter>(k_, p_);
		CqlValueSet r_ = this.Telephone_Visits();
		IEnumerable<Encounter> s_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> t_ = context.Operators.Union<Encounter>(q_, s_);
		IEnumerable<Encounter> u_ = Status_1_6_000.Finished_Encounter(t_);
		bool? v_(Encounter ValidEncounters)
		{
			CqlInterval<CqlDateTime> x_ = this.Measurement_Period();
			Period y_ = ValidEncounters?.Period;
			CqlInterval<CqlDateTime> z_ = FHIRHelpers_4_3_000.ToInterval(y_);
			CqlInterval<CqlDateTime> aa_ = QICoreCommon_2_0_000.ToInterval(z_ as object);
			bool? ab_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(x_, aa_, default);

			return ab_;
		};
		IEnumerable<Encounter> w_ = context.Operators.Where<Encounter>(u_, v_);

		return w_;
	}

    [CqlDeclaration("Qualifying Encounter")]
	public IEnumerable<Encounter> Qualifying_Encounter() => 
		__Qualifying_Encounter.Value;

	private bool? Initial_Population_Value()
	{
		Patient a_ = this.Patient();
		Date b_ = a_?.BirthDateElement;
		string c_ = b_?.Value;
		CqlDate d_ = context.Operators.ConvertStringToDate(c_);
		CqlInterval<CqlDateTime> e_ = this.Measurement_Period();
		CqlDateTime f_ = context.Operators.End(e_);
		CqlDate g_ = context.Operators.DateFrom(f_);
		int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
		CqlInterval<int?> i_ = context.Operators.Interval(3, 17, true, true);
		bool? j_ = context.Operators.In<int?>(h_, i_, default);
		IEnumerable<Encounter> k_ = this.Qualifying_Encounter();
		bool? l_ = context.Operators.Exists<Encounter>(k_);
		bool? m_ = context.Operators.And(j_, l_);

		return m_;
	}

    [CqlDeclaration("Initial Population")]
	public bool? Initial_Population() => 
		__Initial_Population.Value;

	private bool? Denominator_Value()
	{
		bool? a_ = this.Initial_Population();

		return a_;
	}

    [CqlDeclaration("Denominator")]
	public bool? Denominator() => 
		__Denominator.Value;

	private IEnumerable<Condition> Pregnancy_Diagnosis_Which_Overlaps_Measurement_Period_Value()
	{
		CqlValueSet a_ = this.Pregnancy();
		IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		IEnumerable<Condition> c_ = Status_1_6_000.Active_Condition(b_);
		bool? d_(Condition Pregnancy)
		{
			CqlInterval<CqlDateTime> f_ = QICoreCommon_2_0_000.ToPrevalenceInterval(Pregnancy);
			CqlInterval<CqlDateTime> g_ = this.Measurement_Period();
			bool? h_ = context.Operators.Overlaps(f_, g_, default);

			return h_;
		};
		IEnumerable<Condition> e_ = context.Operators.Where<Condition>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Pregnancy Diagnosis Which Overlaps Measurement Period")]
	public IEnumerable<Condition> Pregnancy_Diagnosis_Which_Overlaps_Measurement_Period() => 
		__Pregnancy_Diagnosis_Which_Overlaps_Measurement_Period.Value;

	private bool? Denominator_Exclusions_Value()
	{
		bool? a_ = Hospice_6_9_000.Has_Hospice_Services();
		IEnumerable<Condition> b_ = this.Pregnancy_Diagnosis_Which_Overlaps_Measurement_Period();
		bool? c_ = context.Operators.Exists<Condition>(b_);
		bool? d_ = context.Operators.Or(a_, c_);

		return d_;
	}

    [CqlDeclaration("Denominator Exclusions")]
	public bool? Denominator_Exclusions() => 
		__Denominator_Exclusions.Value;

	private IEnumerable<Observation> BMI_Percentile_in_Measurement_Period_Value()
	{
		IEnumerable<Observation> a_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bmi"));
		IEnumerable<Observation> b_ = Status_1_6_000.BMI(a_);
		bool? c_(Observation BMIPercentile)
		{
			CqlInterval<CqlDateTime> e_ = this.Measurement_Period();
			DataType f_ = BMIPercentile?.Effective;
			object g_ = FHIRHelpers_4_3_000.ToValue(f_);
			CqlInterval<CqlDateTime> h_ = QICoreCommon_2_0_000.ToInterval(g_);
			bool? i_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(e_, h_, "day");
			DataType j_ = BMIPercentile?.Value;
			CqlQuantity k_ = FHIRHelpers_4_3_000.ToQuantity(j_ as Quantity);
			bool? l_ = context.Operators.Not((bool?)(k_ is null));
			bool? m_ = context.Operators.And(i_, l_);

			return m_;
		};
		IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

		return d_;
	}

    [CqlDeclaration("BMI Percentile in Measurement Period")]
	public IEnumerable<Observation> BMI_Percentile_in_Measurement_Period() => 
		__BMI_Percentile_in_Measurement_Period.Value;

	private IEnumerable<Observation> Height_in_Measurement_Period_Value()
	{
		IEnumerable<Observation> a_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bodyheight"));
		IEnumerable<Observation> b_ = Status_1_6_000.BodyHeight(a_);
		bool? c_(Observation Height)
		{
			CqlInterval<CqlDateTime> e_ = this.Measurement_Period();
			DataType f_ = Height?.Effective;
			object g_ = FHIRHelpers_4_3_000.ToValue(f_);
			CqlInterval<CqlDateTime> h_ = QICoreCommon_2_0_000.ToInterval(g_);
			bool? i_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(e_, h_, "day");
			DataType j_ = Height?.Value;
			CqlQuantity k_ = FHIRHelpers_4_3_000.ToQuantity(j_ as Quantity);
			bool? l_ = context.Operators.Not((bool?)(k_ is null));
			bool? m_ = context.Operators.And(i_, l_);

			return m_;
		};
		IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Height in Measurement Period")]
	public IEnumerable<Observation> Height_in_Measurement_Period() => 
		__Height_in_Measurement_Period.Value;

	private IEnumerable<Observation> Weight_in_Measurement_Period_Value()
	{
		IEnumerable<Observation> a_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/bodyweight"));
		IEnumerable<Observation> b_ = Status_1_6_000.BodyWeight(a_);
		bool? c_(Observation Weight)
		{
			CqlInterval<CqlDateTime> e_ = this.Measurement_Period();
			DataType f_ = Weight?.Effective;
			object g_ = FHIRHelpers_4_3_000.ToValue(f_);
			CqlInterval<CqlDateTime> h_ = QICoreCommon_2_0_000.ToInterval(g_);
			bool? i_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(e_, h_, "day");
			DataType j_ = Weight?.Value;
			CqlQuantity k_ = FHIRHelpers_4_3_000.ToQuantity(j_ as Quantity);
			bool? l_ = context.Operators.Not((bool?)(k_ is null));
			bool? m_ = context.Operators.And(i_, l_);

			return m_;
		};
		IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Weight in Measurement Period")]
	public IEnumerable<Observation> Weight_in_Measurement_Period() => 
		__Weight_in_Measurement_Period.Value;

	private bool? Numerator_1_Value()
	{
		IEnumerable<Observation> a_ = this.BMI_Percentile_in_Measurement_Period();
		bool? b_ = context.Operators.Exists<Observation>(a_);
		IEnumerable<Observation> c_ = this.Height_in_Measurement_Period();
		bool? d_ = context.Operators.Exists<Observation>(c_);
		bool? e_ = context.Operators.And(b_, d_);
		IEnumerable<Observation> f_ = this.Weight_in_Measurement_Period();
		bool? g_ = context.Operators.Exists<Observation>(f_);
		bool? h_ = context.Operators.And(e_, g_);

		return h_;
	}

    [CqlDeclaration("Numerator 1")]
	public bool? Numerator_1() => 
		__Numerator_1.Value;

	private bool? Numerator_2_Value()
	{
		CqlValueSet a_ = this.Counseling_for_Nutrition();
		IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
		IEnumerable<Procedure> c_ = Status_1_6_000.Completed_Procedure(b_);
		bool? d_(Procedure NutritionCounseling)
		{
			CqlInterval<CqlDateTime> g_ = this.Measurement_Period();
			DataType h_ = NutritionCounseling?.Performed;
			object i_ = FHIRHelpers_4_3_000.ToValue(h_);
			CqlInterval<CqlDateTime> j_ = QICoreCommon_2_0_000.ToInterval(i_);
			bool? k_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(g_, j_, "day");

			return k_;
		};
		IEnumerable<Procedure> e_ = context.Operators.Where<Procedure>(c_, d_);
		bool? f_ = context.Operators.Exists<Procedure>(e_);

		return f_;
	}

    [CqlDeclaration("Numerator 2")]
	public bool? Numerator_2() => 
		__Numerator_2.Value;

	private bool? Numerator_3_Value()
	{
		CqlValueSet a_ = this.Counseling_for_Physical_Activity();
		IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
		IEnumerable<Procedure> c_ = Status_1_6_000.Completed_Procedure(b_);
		bool? d_(Procedure ActivityCounseling)
		{
			CqlInterval<CqlDateTime> g_ = this.Measurement_Period();
			DataType h_ = ActivityCounseling?.Performed;
			object i_ = FHIRHelpers_4_3_000.ToValue(h_);
			CqlInterval<CqlDateTime> j_ = QICoreCommon_2_0_000.ToInterval(i_);
			bool? k_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(g_, j_, "day");

			return k_;
		};
		IEnumerable<Procedure> e_ = context.Operators.Where<Procedure>(c_, d_);
		bool? f_ = context.Operators.Exists<Procedure>(e_);

		return f_;
	}

    [CqlDeclaration("Numerator 3")]
	public bool? Numerator_3() => 
		__Numerator_3.Value;

	private bool? Stratifaction_1_Value()
	{
		Patient a_ = this.Patient();
		Date b_ = a_?.BirthDateElement;
		string c_ = b_?.Value;
		CqlDate d_ = context.Operators.ConvertStringToDate(c_);
		CqlInterval<CqlDateTime> e_ = this.Measurement_Period();
		CqlDateTime f_ = context.Operators.End(e_);
		CqlDate g_ = context.Operators.DateFrom(f_);
		int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
		CqlInterval<int?> i_ = context.Operators.Interval(3, 11, true, true);
		bool? j_ = context.Operators.In<int?>(h_, i_, default);

		return j_;
	}

    [CqlDeclaration("Stratifaction 1")]
	public bool? Stratifaction_1() => 
		__Stratifaction_1.Value;

	private bool? Stratifaction_2_Value()
	{
		Patient a_ = this.Patient();
		Date b_ = a_?.BirthDateElement;
		string c_ = b_?.Value;
		CqlDate d_ = context.Operators.ConvertStringToDate(c_);
		CqlInterval<CqlDateTime> e_ = this.Measurement_Period();
		CqlDateTime f_ = context.Operators.End(e_);
		CqlDate g_ = context.Operators.DateFrom(f_);
		int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
		CqlInterval<int?> i_ = context.Operators.Interval(12, 17, true, true);
		bool? j_ = context.Operators.In<int?>(h_, i_, default);

		return j_;
	}

    [CqlDeclaration("Stratifaction 2")]
	public bool? Stratifaction_2() => 
		__Stratifaction_2.Value;

}
