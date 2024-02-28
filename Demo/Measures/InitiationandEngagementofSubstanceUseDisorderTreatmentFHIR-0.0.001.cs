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
[CqlLibrary("InitiationandEngagementofSubstanceUseDisorderTreatmentFHIR", "0.0.001")]
public class InitiationandEngagementofSubstanceUseDisorderTreatmentFHIR_0_0_001
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Detoxification_Visit;
    internal Lazy<CqlValueSet> __Discharge_Services_Hospital_Inpatient;
    internal Lazy<CqlValueSet> __Discharge_Services_Hospital_Inpatient_Same_Day_Discharge;
    internal Lazy<CqlValueSet> __Emergency_Department_Visit;
    internal Lazy<CqlValueSet> __Encounter_Inpatient;
    internal Lazy<CqlValueSet> __Initial_Hospital_Inpatient_Visit;
    internal Lazy<CqlValueSet> __Initial_Hospital_Observation_Care;
    internal Lazy<CqlValueSet> __Office_Visit;
    internal Lazy<CqlValueSet> __Online_Assessments;
    internal Lazy<CqlValueSet> __Psych_Visit_Psychotherapy;
    internal Lazy<CqlValueSet> __Substance_Use_Disorder;
    internal Lazy<CqlValueSet> __Substance_Use_Disorder_Long_Acting_Medication;
    internal Lazy<CqlValueSet> __Substance_Use_Disorder_Long_Acting_Medication_Administration;
    internal Lazy<CqlValueSet> __Substance_Use_Disorder_Short_Acting_Medication;
    internal Lazy<CqlValueSet> __Substance_Use_Disorder_Short_Acting_Medication_Administration;
    internal Lazy<CqlValueSet> __Substance_Use_Disorder_Treatment;
    internal Lazy<CqlValueSet> __Telephone_Visits;
    internal Lazy<CqlCode> __Discharge_to_healthcare_facility_for_hospice_care__procedure_;
    internal Lazy<CqlCode> __Discharge_to_home_for_hospice_care__procedure_;
    internal Lazy<CqlCode> __Hospice_care__Minimum_Data_Set_;
    internal Lazy<CqlCode> __Yes__qualifier_value_;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<IEnumerable<Encounter>> __Qualifying_Encounters;
    internal Lazy<Encounter> __First_SUD_Episode_During_Measurement_Period;
    internal Lazy<IEnumerable<Encounter>> __Emergency_Department_or_Detoxification_Visit;
    internal Lazy<IEnumerable<object>> __History_of_SUD_Diagnosis_or_Treatment;
    internal Lazy<bool?> __Initial_Population;
    internal Lazy<bool?> __Denominator;
    internal Lazy<bool?> __Denominator_Exclusions;
    internal Lazy<IEnumerable<object>> __Psychosocial_Visit;
    internal Lazy<IEnumerable<CqlDate>> __Treatment_Initiation_With_Non_Medication_Intervention_Dates;
    internal Lazy<IEnumerable<CqlDate>> __Treatment_Initiation_With_Medication_Order_Dates;
    internal Lazy<bool?> __Numerator_1;
    internal Lazy<bool?> __Has_Two_or_More_Treatment_Engagements_With_Short_Acting_Medication_or_Non_Medication_Intervention;
    internal Lazy<bool?> __Has_Treatment_Engagement_With_Long_Acting_Medication;
    internal Lazy<bool?> __Numerator_2;
    internal Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuples.Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>> __SDE_Payer;
    internal Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;
    internal Lazy<bool?> __Stratification_1;
    internal Lazy<bool?> __Stratification_2;
    internal Lazy<bool?> __Stratification_3;

    #endregion
    public InitiationandEngagementofSubstanceUseDisorderTreatmentFHIR_0_0_001(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_3_000 = new FHIRHelpers_4_3_000(context);
        QICoreCommon_2_0_000 = new QICoreCommon_2_0_000(context);
        SupplementalDataElements_3_4_000 = new SupplementalDataElements_3_4_000(context);
        CQMCommon_2_0_000 = new CQMCommon_2_0_000(context);
        Hospice_6_9_000 = new Hospice_6_9_000(context);
        Status_1_6_000 = new Status_1_6_000(context);

        __Detoxification_Visit = new Lazy<CqlValueSet>(this.Detoxification_Visit_Value);
        __Discharge_Services_Hospital_Inpatient = new Lazy<CqlValueSet>(this.Discharge_Services_Hospital_Inpatient_Value);
        __Discharge_Services_Hospital_Inpatient_Same_Day_Discharge = new Lazy<CqlValueSet>(this.Discharge_Services_Hospital_Inpatient_Same_Day_Discharge_Value);
        __Emergency_Department_Visit = new Lazy<CqlValueSet>(this.Emergency_Department_Visit_Value);
        __Encounter_Inpatient = new Lazy<CqlValueSet>(this.Encounter_Inpatient_Value);
        __Initial_Hospital_Inpatient_Visit = new Lazy<CqlValueSet>(this.Initial_Hospital_Inpatient_Visit_Value);
        __Initial_Hospital_Observation_Care = new Lazy<CqlValueSet>(this.Initial_Hospital_Observation_Care_Value);
        __Office_Visit = new Lazy<CqlValueSet>(this.Office_Visit_Value);
        __Online_Assessments = new Lazy<CqlValueSet>(this.Online_Assessments_Value);
        __Psych_Visit_Psychotherapy = new Lazy<CqlValueSet>(this.Psych_Visit_Psychotherapy_Value);
        __Substance_Use_Disorder = new Lazy<CqlValueSet>(this.Substance_Use_Disorder_Value);
        __Substance_Use_Disorder_Long_Acting_Medication = new Lazy<CqlValueSet>(this.Substance_Use_Disorder_Long_Acting_Medication_Value);
        __Substance_Use_Disorder_Long_Acting_Medication_Administration = new Lazy<CqlValueSet>(this.Substance_Use_Disorder_Long_Acting_Medication_Administration_Value);
        __Substance_Use_Disorder_Short_Acting_Medication = new Lazy<CqlValueSet>(this.Substance_Use_Disorder_Short_Acting_Medication_Value);
        __Substance_Use_Disorder_Short_Acting_Medication_Administration = new Lazy<CqlValueSet>(this.Substance_Use_Disorder_Short_Acting_Medication_Administration_Value);
        __Substance_Use_Disorder_Treatment = new Lazy<CqlValueSet>(this.Substance_Use_Disorder_Treatment_Value);
        __Telephone_Visits = new Lazy<CqlValueSet>(this.Telephone_Visits_Value);
        __Discharge_to_healthcare_facility_for_hospice_care__procedure_ = new Lazy<CqlCode>(this.Discharge_to_healthcare_facility_for_hospice_care__procedure__Value);
        __Discharge_to_home_for_hospice_care__procedure_ = new Lazy<CqlCode>(this.Discharge_to_home_for_hospice_care__procedure__Value);
        __Hospice_care__Minimum_Data_Set_ = new Lazy<CqlCode>(this.Hospice_care__Minimum_Data_Set__Value);
        __Yes__qualifier_value_ = new Lazy<CqlCode>(this.Yes__qualifier_value__Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __Qualifying_Encounters = new Lazy<IEnumerable<Encounter>>(this.Qualifying_Encounters_Value);
        __First_SUD_Episode_During_Measurement_Period = new Lazy<Encounter>(this.First_SUD_Episode_During_Measurement_Period_Value);
        __Emergency_Department_or_Detoxification_Visit = new Lazy<IEnumerable<Encounter>>(this.Emergency_Department_or_Detoxification_Visit_Value);
        __History_of_SUD_Diagnosis_or_Treatment = new Lazy<IEnumerable<object>>(this.History_of_SUD_Diagnosis_or_Treatment_Value);
        __Initial_Population = new Lazy<bool?>(this.Initial_Population_Value);
        __Denominator = new Lazy<bool?>(this.Denominator_Value);
        __Denominator_Exclusions = new Lazy<bool?>(this.Denominator_Exclusions_Value);
        __Psychosocial_Visit = new Lazy<IEnumerable<object>>(this.Psychosocial_Visit_Value);
        __Treatment_Initiation_With_Non_Medication_Intervention_Dates = new Lazy<IEnumerable<CqlDate>>(this.Treatment_Initiation_With_Non_Medication_Intervention_Dates_Value);
        __Treatment_Initiation_With_Medication_Order_Dates = new Lazy<IEnumerable<CqlDate>>(this.Treatment_Initiation_With_Medication_Order_Dates_Value);
        __Numerator_1 = new Lazy<bool?>(this.Numerator_1_Value);
        __Has_Two_or_More_Treatment_Engagements_With_Short_Acting_Medication_or_Non_Medication_Intervention = new Lazy<bool?>(this.Has_Two_or_More_Treatment_Engagements_With_Short_Acting_Medication_or_Non_Medication_Intervention_Value);
        __Has_Treatment_Engagement_With_Long_Acting_Medication = new Lazy<bool?>(this.Has_Treatment_Engagement_With_Long_Acting_Medication_Value);
        __Numerator_2 = new Lazy<bool?>(this.Numerator_2_Value);
        __SDE_Ethnicity = new Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuples.Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
        __Stratification_1 = new Lazy<bool?>(this.Stratification_1_Value);
        __Stratification_2 = new Lazy<bool?>(this.Stratification_2_Value);
        __Stratification_3 = new Lazy<bool?>(this.Stratification_3_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_3_000 FHIRHelpers_4_3_000 { get; }
    public QICoreCommon_2_0_000 QICoreCommon_2_0_000 { get; }
    public SupplementalDataElements_3_4_000 SupplementalDataElements_3_4_000 { get; }
    public CQMCommon_2_0_000 CQMCommon_2_0_000 { get; }
    public Hospice_6_9_000 Hospice_6_9_000 { get; }
    public Status_1_6_000 Status_1_6_000 { get; }

    #endregion

	private CqlValueSet Detoxification_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1059", null);

    [CqlDeclaration("Detoxification Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1059")]
	public CqlValueSet Detoxification_Visit() => 
		__Detoxification_Visit.Value;

	private CqlValueSet Discharge_Services_Hospital_Inpatient_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1007", null);

    [CqlDeclaration("Discharge Services Hospital Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1007")]
	public CqlValueSet Discharge_Services_Hospital_Inpatient() => 
		__Discharge_Services_Hospital_Inpatient.Value;

	private CqlValueSet Discharge_Services_Hospital_Inpatient_Same_Day_Discharge_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1006", null);

    [CqlDeclaration("Discharge Services Hospital Inpatient Same Day Discharge")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1006")]
	public CqlValueSet Discharge_Services_Hospital_Inpatient_Same_Day_Discharge() => 
		__Discharge_Services_Hospital_Inpatient_Same_Day_Discharge.Value;

	private CqlValueSet Emergency_Department_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010", null);

    [CqlDeclaration("Emergency Department Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010")]
	public CqlValueSet Emergency_Department_Visit() => 
		__Emergency_Department_Visit.Value;

	private CqlValueSet Encounter_Inpatient_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
	public CqlValueSet Encounter_Inpatient() => 
		__Encounter_Inpatient.Value;

	private CqlValueSet Initial_Hospital_Inpatient_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1004", null);

    [CqlDeclaration("Initial Hospital Inpatient Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1004")]
	public CqlValueSet Initial_Hospital_Inpatient_Visit() => 
		__Initial_Hospital_Inpatient_Visit.Value;

	private CqlValueSet Initial_Hospital_Observation_Care_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1002", null);

    [CqlDeclaration("Initial Hospital Observation Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1002")]
	public CqlValueSet Initial_Hospital_Observation_Care() => 
		__Initial_Hospital_Observation_Care.Value;

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

	private CqlValueSet Psych_Visit_Psychotherapy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1496", null);

    [CqlDeclaration("Psych Visit Psychotherapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1496")]
	public CqlValueSet Psych_Visit_Psychotherapy() => 
		__Psych_Visit_Psychotherapy.Value;

	private CqlValueSet Substance_Use_Disorder_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.106.12.1001", null);

    [CqlDeclaration("Substance Use Disorder")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.106.12.1001")]
	public CqlValueSet Substance_Use_Disorder() => 
		__Substance_Use_Disorder.Value;

	private CqlValueSet Substance_Use_Disorder_Long_Acting_Medication_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1149", null);

    [CqlDeclaration("Substance Use Disorder Long Acting Medication")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1149")]
	public CqlValueSet Substance_Use_Disorder_Long_Acting_Medication() => 
		__Substance_Use_Disorder_Long_Acting_Medication.Value;

	private CqlValueSet Substance_Use_Disorder_Long_Acting_Medication_Administration_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1156", null);

    [CqlDeclaration("Substance Use Disorder Long Acting Medication Administration")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1156")]
	public CqlValueSet Substance_Use_Disorder_Long_Acting_Medication_Administration() => 
		__Substance_Use_Disorder_Long_Acting_Medication_Administration.Value;

	private CqlValueSet Substance_Use_Disorder_Short_Acting_Medication_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1150", null);

    [CqlDeclaration("Substance Use Disorder Short Acting Medication")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1150")]
	public CqlValueSet Substance_Use_Disorder_Short_Acting_Medication() => 
		__Substance_Use_Disorder_Short_Acting_Medication.Value;

	private CqlValueSet Substance_Use_Disorder_Short_Acting_Medication_Administration_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1157", null);

    [CqlDeclaration("Substance Use Disorder Short Acting Medication Administration")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1157")]
	public CqlValueSet Substance_Use_Disorder_Short_Acting_Medication_Administration() => 
		__Substance_Use_Disorder_Short_Acting_Medication_Administration.Value;

	private CqlValueSet Substance_Use_Disorder_Treatment_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.106.12.1005", null);

    [CqlDeclaration("Substance Use Disorder Treatment")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.106.12.1005")]
	public CqlValueSet Substance_Use_Disorder_Treatment() => 
		__Substance_Use_Disorder_Treatment.Value;

	private CqlValueSet Telephone_Visits_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
	public CqlValueSet Telephone_Visits() => 
		__Telephone_Visits.Value;

	private CqlCode Discharge_to_healthcare_facility_for_hospice_care__procedure__Value() => 
		new CqlCode("428371000124100", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Discharge to healthcare facility for hospice care (procedure)")]
	public CqlCode Discharge_to_healthcare_facility_for_hospice_care__procedure_() => 
		__Discharge_to_healthcare_facility_for_hospice_care__procedure_.Value;

	private CqlCode Discharge_to_home_for_hospice_care__procedure__Value() => 
		new CqlCode("428361000124107", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Discharge to home for hospice care (procedure)")]
	public CqlCode Discharge_to_home_for_hospice_care__procedure_() => 
		__Discharge_to_home_for_hospice_care__procedure_.Value;

	private CqlCode Hospice_care__Minimum_Data_Set__Value() => 
		new CqlCode("45755-6", "http://loinc.org", null, null);

    [CqlDeclaration("Hospice care [Minimum Data Set]")]
	public CqlCode Hospice_care__Minimum_Data_Set_() => 
		__Hospice_care__Minimum_Data_Set_.Value;

	private CqlCode Yes__qualifier_value__Value() => 
		new CqlCode("373066001", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Yes (qualifier value)")]
	public CqlCode Yes__qualifier_value_() => 
		__Yes__qualifier_value_.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.Operators.ConvertIntegerToDecimal(default);
		var b_ = context.Operators.DateTime((int?)2025, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, a_);
		var d_ = context.Operators.DateTime((int?)2026, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, a_);
		var e_ = context.Operators.Interval(b_, d_, true, false);
		var f_ = context.ResolveParameter("InitiationandEngagementofSubstanceUseDisorderTreatmentFHIR-0.0.001", "Measurement Period", e_);

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

	private IEnumerable<Encounter> Qualifying_Encounters_Value()
	{
		var a_ = this.Office_Visit();
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		var c_ = this.Emergency_Department_Visit();
		var d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, null);
		var e_ = context.Operators.ListUnion<Encounter>(b_, d_);
		var f_ = this.Detoxification_Visit();
		var g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, null);
		var h_ = this.Initial_Hospital_Observation_Care();
		var i_ = context.Operators.RetrieveByValueSet<Encounter>(h_, null);
		var j_ = context.Operators.ListUnion<Encounter>(g_, i_);
		var k_ = context.Operators.ListUnion<Encounter>(e_, j_);
		var l_ = this.Initial_Hospital_Inpatient_Visit();
		var m_ = context.Operators.RetrieveByValueSet<Encounter>(l_, null);
		var n_ = this.Discharge_Services_Hospital_Inpatient_Same_Day_Discharge();
		var o_ = context.Operators.RetrieveByValueSet<Encounter>(n_, null);
		var p_ = context.Operators.ListUnion<Encounter>(m_, o_);
		var q_ = context.Operators.ListUnion<Encounter>(k_, p_);
		var r_ = this.Discharge_Services_Hospital_Inpatient();
		var s_ = context.Operators.RetrieveByValueSet<Encounter>(r_, null);
		var t_ = this.Telephone_Visits();
		var u_ = context.Operators.RetrieveByValueSet<Encounter>(t_, null);
		var v_ = context.Operators.ListUnion<Encounter>(s_, u_);
		var w_ = context.Operators.ListUnion<Encounter>(q_, v_);
		var x_ = this.Online_Assessments();
		var y_ = context.Operators.RetrieveByValueSet<Encounter>(x_, null);
		var z_ = context.Operators.ListUnion<Encounter>(w_, y_);
		var aa_ = Status_1_6_000.isEncounterPerformed(z_);

		return aa_;
	}

    [CqlDeclaration("Qualifying Encounters")]
	public IEnumerable<Encounter> Qualifying_Encounters() => 
		__Qualifying_Encounters.Value;

	private Encounter First_SUD_Episode_During_Measurement_Period_Value()
	{
		var a_ = this.Qualifying_Encounters();
		IEnumerable<Encounter> b_(Encounter ValidEncounters)
		{
			var i_ = this.Substance_Use_Disorder();
			var j_ = context.Operators.RetrieveByValueSet<Condition>(i_, null);
			bool? k_(Condition SUDDiagnosis)
			{
				var o_ = this.Measurement_Period();
				var p_ = FHIRHelpers_4_3_000.ToInterval(ValidEncounters?.Period);
				var q_ = QICoreCommon_2_0_000.toInterval((p_ as object));
				var r_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(o_, q_, null);
				var s_ = QICoreCommon_2_0_000.prevalenceInterval(SUDDiagnosis);
				var t_ = context.Operators.Start(s_);
				var v_ = QICoreCommon_2_0_000.toInterval((p_ as object));
				var w_ = context.Operators.ElementInInterval<CqlDateTime>(t_, v_, null);
				var x_ = context.Operators.And(r_, w_);
				var z_ = context.Operators.Start(s_);
				var ab_ = context.Operators.End(o_);
				var ac_ = context.Operators.Quantity(47m, "days");
				var ad_ = context.Operators.Subtract(ab_, ac_);
				var ae_ = context.Operators.SameOrBefore(z_, ad_, "day");
				var af_ = context.Operators.And(x_, ae_);

				return af_;
			};
			var l_ = context.Operators.WhereOrNull<Condition>(j_, k_);
			Encounter m_(Condition SUDDiagnosis) => 
				ValidEncounters;
			var n_ = context.Operators.SelectOrNull<Condition, Encounter>(l_, m_);

			return n_;
		};
		var c_ = context.Operators.SelectManyOrNull<Encounter, Encounter>(a_, b_);
		Tuples.Tuple_QZEWjjOLcJfhDOILfOFXcJdN d_(Encounter ValidEncounters)
		{
			var ag_ = FHIRHelpers_4_3_000.ToInterval(ValidEncounters?.Period);
			var ah_ = QICoreCommon_2_0_000.toInterval((ag_ as object));
			var ai_ = context.Operators.Start(ah_);
			var aj_ = context.Operators.DateFrom(ai_);
			var ak_ = new Tuples.Tuple_QZEWjjOLcJfhDOILfOFXcJdN
			{
				ValidEncounterDate = aj_,
				ValidEncounter = ValidEncounters,
			};

			return ak_;
		};
		var e_ = context.Operators.SelectOrNull<Encounter, Tuples.Tuple_QZEWjjOLcJfhDOILfOFXcJdN>(c_, d_);
		object f_(Tuples.Tuple_QZEWjjOLcJfhDOILfOFXcJdN @this) => 
			@this?.ValidEncounterDate;
		var g_ = context.Operators.ListSortBy<Tuples.Tuple_QZEWjjOLcJfhDOILfOFXcJdN>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
		var h_ = context.Operators.FirstOfList<Tuples.Tuple_QZEWjjOLcJfhDOILfOFXcJdN>(g_);

		return h_?.ValidEncounter;
	}

    [CqlDeclaration("First SUD Episode During Measurement Period")]
	public Encounter First_SUD_Episode_During_Measurement_Period() => 
		__First_SUD_Episode_During_Measurement_Period.Value;

	private IEnumerable<Encounter> Emergency_Department_or_Detoxification_Visit_Value()
	{
		var a_ = this.Emergency_Department_Visit();
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		var c_ = this.Detoxification_Visit();
		var d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, null);
		var e_ = context.Operators.ListUnion<Encounter>(b_, d_);
		var f_ = Status_1_6_000.isEncounterPerformed(e_);

		return f_;
	}

    [CqlDeclaration("Emergency Department or Detoxification Visit")]
	public IEnumerable<Encounter> Emergency_Department_or_Detoxification_Visit() => 
		__Emergency_Department_or_Detoxification_Visit.Value;

	private IEnumerable<object> History_of_SUD_Diagnosis_or_Treatment_Value()
	{
		var a_ = this.Substance_Use_Disorder_Treatment();
		var b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, null);
		var c_ = this.Psych_Visit_Psychotherapy();
		var d_ = context.Operators.RetrieveByValueSet<Procedure>(c_, null);
		var e_ = context.Operators.ListUnion<Procedure>(b_, d_);
		var f_ = this.Substance_Use_Disorder_Long_Acting_Medication_Administration();
		var g_ = context.Operators.RetrieveByValueSet<Procedure>(f_, null);
		var h_ = this.Substance_Use_Disorder_Short_Acting_Medication_Administration();
		var i_ = context.Operators.RetrieveByValueSet<Procedure>(h_, null);
		var j_ = context.Operators.ListUnion<Procedure>(g_, i_);
		var k_ = context.Operators.ListUnion<Procedure>(e_, j_);
		var l_ = Status_1_6_000.isProcedurePerformed(k_);
		IEnumerable<Procedure> m_(Procedure Interventions)
		{
			var al_ = this.First_SUD_Episode_During_Measurement_Period();
			var am_ = new Encounter[]
			{
				al_,
			};
			bool? an_(Encounter FirstSUDEpisode)
			{
				var ar_ = FHIRHelpers_4_3_000.ToValue(Interventions?.Performed);
				var as_ = QICoreCommon_2_0_000.toInterval(ar_);
				var at_ = context.Operators.Start(as_);
				var au_ = FHIRHelpers_4_3_000.ToInterval(FirstSUDEpisode?.Period);
				var av_ = QICoreCommon_2_0_000.toInterval((au_ as object));
				var aw_ = context.Operators.Start(av_);
				var ax_ = context.Operators.DateFrom(aw_);
				var ay_ = context.Operators.Quantity(60m, "days");
				var az_ = context.Operators.Subtract(ax_, ay_);
				var bb_ = QICoreCommon_2_0_000.toInterval((au_ as object));
				var bc_ = context.Operators.Start(bb_);
				var bd_ = context.Operators.DateFrom(bc_);
				var be_ = context.Operators.Interval(az_, bd_, true, false);
				var bf_ = context.Operators.ConvertDateToDateTime(be_?.low);
				var bh_ = QICoreCommon_2_0_000.toInterval((au_ as object));
				var bi_ = context.Operators.Start(bh_);
				var bj_ = context.Operators.DateFrom(bi_);
				var bl_ = context.Operators.Subtract(bj_, ay_);
				var bn_ = QICoreCommon_2_0_000.toInterval((au_ as object));
				var bo_ = context.Operators.Start(bn_);
				var bp_ = context.Operators.DateFrom(bo_);
				var bq_ = context.Operators.Interval(bl_, bp_, true, false);
				var br_ = context.Operators.ConvertDateToDateTime(bq_?.high);
				var bt_ = QICoreCommon_2_0_000.toInterval((au_ as object));
				var bu_ = context.Operators.Start(bt_);
				var bv_ = context.Operators.DateFrom(bu_);
				var bx_ = context.Operators.Subtract(bv_, ay_);
				var bz_ = QICoreCommon_2_0_000.toInterval((au_ as object));
				var ca_ = context.Operators.Start(bz_);
				var cb_ = context.Operators.DateFrom(ca_);
				var cc_ = context.Operators.Interval(bx_, cb_, true, false);
				var ce_ = QICoreCommon_2_0_000.toInterval((au_ as object));
				var cf_ = context.Operators.Start(ce_);
				var cg_ = context.Operators.DateFrom(cf_);
				var ci_ = context.Operators.Subtract(cg_, ay_);
				var ck_ = QICoreCommon_2_0_000.toInterval((au_ as object));
				var cl_ = context.Operators.Start(ck_);
				var cm_ = context.Operators.DateFrom(cl_);
				var cn_ = context.Operators.Interval(ci_, cm_, true, false);
				var co_ = context.Operators.Interval(bf_, br_, cc_?.lowClosed, cn_?.highClosed);
				var cp_ = context.Operators.ElementInInterval<CqlDateTime>(at_, co_, "day");
				var cr_ = QICoreCommon_2_0_000.toInterval((au_ as object));
				var cs_ = context.Operators.Start(cr_);
				var ct_ = context.Operators.DateFrom(cs_);
				var cu_ = context.Operators.Not((bool?)(ct_ is null));
				var cv_ = context.Operators.And(cp_, cu_);

				return cv_;
			};
			var ao_ = context.Operators.WhereOrNull<Encounter>(am_, an_);
			Procedure ap_(Encounter FirstSUDEpisode) => 
				Interventions;
			var aq_ = context.Operators.SelectOrNull<Encounter, Procedure>(ao_, ap_);

			return aq_;
		};
		var n_ = context.Operators.SelectManyOrNull<Procedure, Procedure>(l_, m_);
		var o_ = this.Qualifying_Encounters();
		var p_ = this.Emergency_Department_or_Detoxification_Visit();
		var q_ = context.Operators.ListExcept<Encounter>(o_, p_);
		bool? r_(Encounter QualifyingEncounter)
		{
			var cw_ = CQMCommon_2_0_000.encounterDiagnosis(QualifyingEncounter);
			bool? cx_(Condition SUDDiagnosis)
			{
				var da_ = FHIRHelpers_4_3_000.ToConcept(SUDDiagnosis?.Code);
				var db_ = this.Substance_Use_Disorder();
				var dc_ = context.Operators.ConceptInValueSet(da_, db_);

				return dc_;
			};
			var cy_ = context.Operators.WhereOrNull<Condition>(cw_, cx_);
			var cz_ = context.Operators.ExistsInList<Condition>(cy_);

			return cz_;
		};
		var s_ = context.Operators.WhereOrNull<Encounter>(q_, r_);
		IEnumerable<Encounter> t_(Encounter SUDEncounterDx)
		{
			var dd_ = this.First_SUD_Episode_During_Measurement_Period();
			var de_ = new Encounter[]
			{
				dd_,
			};
			bool? df_(Encounter FirstSUDEpisode)
			{
				var dj_ = FHIRHelpers_4_3_000.ToInterval(SUDEncounterDx?.Period);
				var dk_ = QICoreCommon_2_0_000.toInterval((dj_ as object));
				var dl_ = context.Operators.Start(dk_);
				var dm_ = FHIRHelpers_4_3_000.ToInterval(FirstSUDEpisode?.Period);
				var dn_ = QICoreCommon_2_0_000.toInterval((dm_ as object));
				var do_ = context.Operators.Start(dn_);
				var dp_ = context.Operators.DateFrom(do_);
				var dq_ = context.Operators.Quantity(60m, "days");
				var dr_ = context.Operators.Subtract(dp_, dq_);
				var dt_ = QICoreCommon_2_0_000.toInterval((dm_ as object));
				var du_ = context.Operators.Start(dt_);
				var dv_ = context.Operators.DateFrom(du_);
				var dw_ = context.Operators.Interval(dr_, dv_, true, false);
				var dx_ = context.Operators.ConvertDateToDateTime(dw_?.low);
				var dz_ = QICoreCommon_2_0_000.toInterval((dm_ as object));
				var ea_ = context.Operators.Start(dz_);
				var eb_ = context.Operators.DateFrom(ea_);
				var ed_ = context.Operators.Subtract(eb_, dq_);
				var ef_ = QICoreCommon_2_0_000.toInterval((dm_ as object));
				var eg_ = context.Operators.Start(ef_);
				var eh_ = context.Operators.DateFrom(eg_);
				var ei_ = context.Operators.Interval(ed_, eh_, true, false);
				var ej_ = context.Operators.ConvertDateToDateTime(ei_?.high);
				var el_ = QICoreCommon_2_0_000.toInterval((dm_ as object));
				var em_ = context.Operators.Start(el_);
				var en_ = context.Operators.DateFrom(em_);
				var ep_ = context.Operators.Subtract(en_, dq_);
				var er_ = QICoreCommon_2_0_000.toInterval((dm_ as object));
				var es_ = context.Operators.Start(er_);
				var et_ = context.Operators.DateFrom(es_);
				var eu_ = context.Operators.Interval(ep_, et_, true, false);
				var ew_ = QICoreCommon_2_0_000.toInterval((dm_ as object));
				var ex_ = context.Operators.Start(ew_);
				var ey_ = context.Operators.DateFrom(ex_);
				var fa_ = context.Operators.Subtract(ey_, dq_);
				var fc_ = QICoreCommon_2_0_000.toInterval((dm_ as object));
				var fd_ = context.Operators.Start(fc_);
				var fe_ = context.Operators.DateFrom(fd_);
				var ff_ = context.Operators.Interval(fa_, fe_, true, false);
				var fg_ = context.Operators.Interval(dx_, ej_, eu_?.lowClosed, ff_?.highClosed);
				var fh_ = context.Operators.ElementInInterval<CqlDateTime>(dl_, fg_, "day");
				var fj_ = QICoreCommon_2_0_000.toInterval((dm_ as object));
				var fk_ = context.Operators.Start(fj_);
				var fl_ = context.Operators.DateFrom(fk_);
				var fm_ = context.Operators.Not((bool?)(fl_ is null));
				var fn_ = context.Operators.And(fh_, fm_);

				return fn_;
			};
			var dg_ = context.Operators.WhereOrNull<Encounter>(de_, df_);
			Encounter dh_(Encounter FirstSUDEpisode) => 
				SUDEncounterDx;
			var di_ = context.Operators.SelectOrNull<Encounter, Encounter>(dg_, dh_);

			return di_;
		};
		var u_ = context.Operators.SelectManyOrNull<Encounter, Encounter>(s_, t_);
		var v_ = context.Operators.ListUnion<object>((n_ as IEnumerable<object>), (u_ as IEnumerable<object>));
		var w_ = this.Substance_Use_Disorder_Long_Acting_Medication();
		var x_ = context.Operators.RetrieveByValueSet<MedicationRequest>(w_, null);
		var z_ = context.Operators.RetrieveByValueSet<MedicationRequest>(w_, null);
		var aa_ = context.Operators.ListUnion<MedicationRequest>(x_, z_);
		var ab_ = this.Substance_Use_Disorder_Short_Acting_Medication();
		var ac_ = context.Operators.RetrieveByValueSet<MedicationRequest>(ab_, null);
		var ae_ = context.Operators.RetrieveByValueSet<MedicationRequest>(ab_, null);
		var af_ = context.Operators.ListUnion<MedicationRequest>(ac_, ae_);
		var ag_ = context.Operators.ListUnion<MedicationRequest>(aa_, af_);
		var ah_ = Status_1_6_000.Active_or_Completed_Medication_Request(ag_);
		IEnumerable<MedicationRequest> ai_(MedicationRequest SUDMedication)
		{
			var fo_ = this.First_SUD_Episode_During_Measurement_Period();
			var fp_ = new Encounter[]
			{
				fo_,
			};
			bool? fq_(Encounter FirstSUDEpisode)
			{
				var fu_ = context.Operators.Convert<CqlDateTime>(SUDMedication?.AuthoredOnElement);
				var fv_ = QICoreCommon_2_0_000.toInterval((fu_ as object));
				var fw_ = context.Operators.End(fv_);
				var fx_ = FHIRHelpers_4_3_000.ToInterval(FirstSUDEpisode?.Period);
				var fy_ = QICoreCommon_2_0_000.toInterval((fx_ as object));
				var fz_ = context.Operators.Start(fy_);
				var ga_ = context.Operators.DateFrom(fz_);
				var gb_ = context.Operators.Quantity(60m, "days");
				var gc_ = context.Operators.Subtract(ga_, gb_);
				var ge_ = QICoreCommon_2_0_000.toInterval((fx_ as object));
				var gf_ = context.Operators.Start(ge_);
				var gg_ = context.Operators.DateFrom(gf_);
				var gh_ = context.Operators.Interval(gc_, gg_, true, false);
				var gi_ = context.Operators.ConvertDateToDateTime(gh_?.low);
				var gk_ = QICoreCommon_2_0_000.toInterval((fx_ as object));
				var gl_ = context.Operators.Start(gk_);
				var gm_ = context.Operators.DateFrom(gl_);
				var go_ = context.Operators.Subtract(gm_, gb_);
				var gq_ = QICoreCommon_2_0_000.toInterval((fx_ as object));
				var gr_ = context.Operators.Start(gq_);
				var gs_ = context.Operators.DateFrom(gr_);
				var gt_ = context.Operators.Interval(go_, gs_, true, false);
				var gu_ = context.Operators.ConvertDateToDateTime(gt_?.high);
				var gw_ = QICoreCommon_2_0_000.toInterval((fx_ as object));
				var gx_ = context.Operators.Start(gw_);
				var gy_ = context.Operators.DateFrom(gx_);
				var ha_ = context.Operators.Subtract(gy_, gb_);
				var hc_ = QICoreCommon_2_0_000.toInterval((fx_ as object));
				var hd_ = context.Operators.Start(hc_);
				var he_ = context.Operators.DateFrom(hd_);
				var hf_ = context.Operators.Interval(ha_, he_, true, false);
				var hh_ = QICoreCommon_2_0_000.toInterval((fx_ as object));
				var hi_ = context.Operators.Start(hh_);
				var hj_ = context.Operators.DateFrom(hi_);
				var hl_ = context.Operators.Subtract(hj_, gb_);
				var hn_ = QICoreCommon_2_0_000.toInterval((fx_ as object));
				var ho_ = context.Operators.Start(hn_);
				var hp_ = context.Operators.DateFrom(ho_);
				var hq_ = context.Operators.Interval(hl_, hp_, true, false);
				var hr_ = context.Operators.Interval(gi_, gu_, hf_?.lowClosed, hq_?.highClosed);
				var hs_ = context.Operators.ElementInInterval<CqlDateTime>(fw_, hr_, "day");
				var hu_ = QICoreCommon_2_0_000.toInterval((fx_ as object));
				var hv_ = context.Operators.Start(hu_);
				var hw_ = context.Operators.DateFrom(hv_);
				var hx_ = context.Operators.Not((bool?)(hw_ is null));
				var hy_ = context.Operators.And(hs_, hx_);

				return hy_;
			};
			var fr_ = context.Operators.WhereOrNull<Encounter>(fp_, fq_);
			MedicationRequest fs_(Encounter FirstSUDEpisode) => 
				SUDMedication;
			var ft_ = context.Operators.SelectOrNull<Encounter, MedicationRequest>(fr_, fs_);

			return ft_;
		};
		var aj_ = context.Operators.SelectManyOrNull<MedicationRequest, MedicationRequest>(ah_, ai_);
		var ak_ = context.Operators.ListUnion<object>((v_ as IEnumerable<object>), (aj_ as IEnumerable<object>));

		return ak_;
	}

    [CqlDeclaration("History of SUD Diagnosis or Treatment")]
	public IEnumerable<object> History_of_SUD_Diagnosis_or_Treatment() => 
		__History_of_SUD_Diagnosis_or_Treatment.Value;

	private bool? Initial_Population_Value()
	{
		var a_ = this.Patient();
		var b_ = context.Operators.Convert<CqlDate>(a_?.BirthDateElement?.Value);
		var c_ = this.Measurement_Period();
		var d_ = context.Operators.Start(c_);
		var e_ = context.Operators.DateFrom(d_);
		var f_ = context.Operators.CalculateAgeAt(b_, e_, "year");
		var g_ = context.Operators.GreaterOrEqual(f_, (int?)13);
		var h_ = this.First_SUD_Episode_During_Measurement_Period();
		var i_ = context.Operators.Not((bool?)(h_ is null));
		var j_ = context.Operators.And(g_, i_);
		var k_ = this.History_of_SUD_Diagnosis_or_Treatment();
		var l_ = context.Operators.ExistsInList<object>(k_);
		var m_ = context.Operators.Not(l_);
		var n_ = context.Operators.And(j_, m_);

		return n_;
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

		return a_;
	}

    [CqlDeclaration("Denominator Exclusions")]
	public bool? Denominator_Exclusions() => 
		__Denominator_Exclusions.Value;

	private IEnumerable<object> Psychosocial_Visit_Value()
	{
		var a_ = this.Substance_Use_Disorder_Treatment();
		var b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, null);
		var c_ = this.Psych_Visit_Psychotherapy();
		var d_ = context.Operators.RetrieveByValueSet<Procedure>(c_, null);
		var e_ = context.Operators.ListUnion<Procedure>(b_, d_);
		var f_ = Status_1_6_000.isProcedurePerformed(e_);
		var g_ = this.Telephone_Visits();
		var h_ = context.Operators.RetrieveByValueSet<Encounter>(g_, null);
		var i_ = this.Online_Assessments();
		var j_ = context.Operators.RetrieveByValueSet<Encounter>(i_, null);
		var k_ = context.Operators.ListUnion<Encounter>(h_, j_);
		var l_ = Status_1_6_000.isEncounterPerformed(k_);
		bool? m_(Encounter TelehealthEncounter)
		{
			var p_ = CQMCommon_2_0_000.encounterDiagnosis(TelehealthEncounter);
			bool? q_(Condition SUDDiagnosis)
			{
				var t_ = FHIRHelpers_4_3_000.ToConcept(SUDDiagnosis?.Code);
				var u_ = this.Substance_Use_Disorder();
				var v_ = context.Operators.ConceptInValueSet(t_, u_);

				return v_;
			};
			var r_ = context.Operators.WhereOrNull<Condition>(p_, q_);
			var s_ = context.Operators.ExistsInList<Condition>(r_);

			return s_;
		};
		var n_ = context.Operators.WhereOrNull<Encounter>(l_, m_);
		var o_ = context.Operators.ListUnion<object>((f_ as IEnumerable<object>), (n_ as IEnumerable<object>));

		return o_;
	}

    [CqlDeclaration("Psychosocial Visit")]
	public IEnumerable<object> Psychosocial_Visit() => 
		__Psychosocial_Visit.Value;

	private IEnumerable<CqlDate> Treatment_Initiation_With_Non_Medication_Intervention_Dates_Value()
	{
		var a_ = this.Psychosocial_Visit();
		IEnumerable<object> b_(object PsychosocialVisit)
		{
			var f_ = this.First_SUD_Episode_During_Measurement_Period();
			var g_ = new Encounter[]
			{
				f_,
			};
			bool? h_(Encounter FirstSUDEpisode)
			{
				var l_ = context.Operators.LateBoundProperty<object>(PsychosocialVisit, "period");
				var m_ = FHIRHelpers_4_3_000.ToInterval(l_);
				var n_ = QICoreCommon_2_0_000.toInterval((m_ as object));
				var o_ = context.Operators.Start(n_);
				var p_ = context.Operators.DateFrom(o_);
				var q_ = FHIRHelpers_4_3_000.ToInterval(FirstSUDEpisode?.Period);
				var r_ = QICoreCommon_2_0_000.toInterval((q_ as object));
				var s_ = context.Operators.Start(r_);
				var t_ = context.Operators.DateFrom(s_);
				var v_ = QICoreCommon_2_0_000.toInterval((q_ as object));
				var w_ = context.Operators.Start(v_);
				var x_ = context.Operators.DateFrom(w_);
				var y_ = context.Operators.Quantity(14m, "days");
				var z_ = context.Operators.Add(x_, y_);
				var aa_ = context.Operators.Interval(t_, z_, true, false);
				var ab_ = context.Operators.ElementInInterval<CqlDate>(p_, aa_, null);
				var ac_ = context.Operators.LateBoundProperty<object>(PsychosocialVisit, "id");
				var ad_ = context.Operators.LateBoundProperty<string>(ac_, "value");
				var ae_ = context.Operators.Equivalent(ad_, FirstSUDEpisode?.IdElement?.Value);
				var af_ = context.Operators.Not(ae_);
				var ag_ = context.Operators.And(ab_, af_);

				return ag_;
			};
			var i_ = context.Operators.WhereOrNull<Encounter>(g_, h_);
			object j_(Encounter FirstSUDEpisode) => 
				PsychosocialVisit;
			var k_ = context.Operators.SelectOrNull<Encounter, object>(i_, j_);

			return k_;
		};
		var c_ = context.Operators.SelectManyOrNull<object, object>(a_, b_);
		CqlDate d_(object PsychosocialVisit)
		{
			var ah_ = context.Operators.LateBoundProperty<object>(PsychosocialVisit, "period");
			var ai_ = FHIRHelpers_4_3_000.ToInterval(ah_);
			var aj_ = QICoreCommon_2_0_000.toInterval((ai_ as object));
			var ak_ = context.Operators.Start(aj_);
			var al_ = context.Operators.DateFrom(ak_);

			return al_;
		};
		var e_ = context.Operators.SelectOrNull<object, CqlDate>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Treatment Initiation With Non Medication Intervention Dates")]
	public IEnumerable<CqlDate> Treatment_Initiation_With_Non_Medication_Intervention_Dates() => 
		__Treatment_Initiation_With_Non_Medication_Intervention_Dates.Value;

	private IEnumerable<CqlDate> Treatment_Initiation_With_Medication_Order_Dates_Value()
	{
		var a_ = this.Substance_Use_Disorder_Short_Acting_Medication();
		var b_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		var d_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		var e_ = context.Operators.ListUnion<MedicationRequest>(b_, d_);
		var f_ = this.Substance_Use_Disorder_Long_Acting_Medication();
		var g_ = context.Operators.RetrieveByValueSet<MedicationRequest>(f_, null);
		var i_ = context.Operators.RetrieveByValueSet<MedicationRequest>(f_, null);
		var j_ = context.Operators.ListUnion<MedicationRequest>(g_, i_);
		var k_ = context.Operators.ListUnion<MedicationRequest>(e_, j_);
		IEnumerable<MedicationRequest> l_(MedicationRequest SUDMedication)
		{
			var aa_ = this.First_SUD_Episode_During_Measurement_Period();
			var ab_ = new Encounter[]
			{
				aa_,
			};
			bool? ac_(Encounter FirstSUDEpisode)
			{
				var ag_ = context.Operators.Convert<CqlDateTime>(SUDMedication?.AuthoredOnElement);
				var ah_ = QICoreCommon_2_0_000.toInterval((ag_ as object));
				var ai_ = context.Operators.Start(ah_);
				var aj_ = context.Operators.DateFrom(ai_);
				var ak_ = FHIRHelpers_4_3_000.ToInterval(FirstSUDEpisode?.Period);
				var al_ = QICoreCommon_2_0_000.toInterval((ak_ as object));
				var am_ = context.Operators.Start(al_);
				var an_ = context.Operators.DateFrom(am_);
				var ap_ = QICoreCommon_2_0_000.toInterval((ak_ as object));
				var aq_ = context.Operators.Start(ap_);
				var ar_ = context.Operators.DateFrom(aq_);
				var as_ = context.Operators.Quantity(14m, "days");
				var at_ = context.Operators.Add(ar_, as_);
				var au_ = context.Operators.Interval(an_, at_, true, false);
				var av_ = context.Operators.ElementInInterval<CqlDate>(aj_, au_, null);

				return av_;
			};
			var ad_ = context.Operators.WhereOrNull<Encounter>(ab_, ac_);
			MedicationRequest ae_(Encounter FirstSUDEpisode) => 
				SUDMedication;
			var af_ = context.Operators.SelectOrNull<Encounter, MedicationRequest>(ad_, ae_);

			return af_;
		};
		var m_ = context.Operators.SelectManyOrNull<MedicationRequest, MedicationRequest>(k_, l_);
		CqlDate n_(MedicationRequest SUDMedication)
		{
			var aw_ = context.Operators.Convert<CqlDateTime>(SUDMedication?.AuthoredOnElement);
			var ax_ = QICoreCommon_2_0_000.toInterval((aw_ as object));
			var ay_ = context.Operators.Start(ax_);
			var az_ = context.Operators.DateFrom(ay_);

			return az_;
		};
		var o_ = context.Operators.SelectOrNull<MedicationRequest, CqlDate>(m_, n_);
		var p_ = this.Substance_Use_Disorder_Short_Acting_Medication_Administration();
		var q_ = context.Operators.RetrieveByValueSet<Procedure>(p_, null);
		var r_ = this.Substance_Use_Disorder_Long_Acting_Medication_Administration();
		var s_ = context.Operators.RetrieveByValueSet<Procedure>(r_, null);
		var t_ = context.Operators.ListUnion<Procedure>(q_, s_);
		var u_ = Status_1_6_000.isProcedurePerformed(t_);
		IEnumerable<Procedure> v_(Procedure SUDMedAdministration)
		{
			var ba_ = this.First_SUD_Episode_During_Measurement_Period();
			var bb_ = new Encounter[]
			{
				ba_,
			};
			bool? bc_(Encounter FirstSUDEpisode)
			{
				var bg_ = FHIRHelpers_4_3_000.ToValue(SUDMedAdministration?.Performed);
				var bh_ = QICoreCommon_2_0_000.toInterval(bg_);
				var bi_ = context.Operators.Start(bh_);
				var bj_ = context.Operators.DateFrom(bi_);
				var bk_ = FHIRHelpers_4_3_000.ToInterval(FirstSUDEpisode?.Period);
				var bl_ = QICoreCommon_2_0_000.toInterval((bk_ as object));
				var bm_ = context.Operators.Start(bl_);
				var bn_ = context.Operators.DateFrom(bm_);
				var bp_ = QICoreCommon_2_0_000.toInterval((bk_ as object));
				var bq_ = context.Operators.Start(bp_);
				var br_ = context.Operators.DateFrom(bq_);
				var bs_ = context.Operators.Quantity(14m, "days");
				var bt_ = context.Operators.Add(br_, bs_);
				var bu_ = context.Operators.Interval(bn_, bt_, true, false);
				var bv_ = context.Operators.ElementInInterval<CqlDate>(bj_, bu_, null);

				return bv_;
			};
			var bd_ = context.Operators.WhereOrNull<Encounter>(bb_, bc_);
			Procedure be_(Encounter FirstSUDEpisode) => 
				SUDMedAdministration;
			var bf_ = context.Operators.SelectOrNull<Encounter, Procedure>(bd_, be_);

			return bf_;
		};
		var w_ = context.Operators.SelectManyOrNull<Procedure, Procedure>(u_, v_);
		CqlDate x_(Procedure SUDMedAdministration)
		{
			var bw_ = FHIRHelpers_4_3_000.ToValue(SUDMedAdministration?.Performed);
			var bx_ = QICoreCommon_2_0_000.toInterval(bw_);
			var by_ = context.Operators.Start(bx_);
			var bz_ = context.Operators.DateFrom(by_);

			return bz_;
		};
		var y_ = context.Operators.SelectOrNull<Procedure, CqlDate>(w_, x_);
		var z_ = context.Operators.ListUnion<CqlDate>(o_, y_);

		return z_;
	}

    [CqlDeclaration("Treatment Initiation With Medication Order Dates")]
	public IEnumerable<CqlDate> Treatment_Initiation_With_Medication_Order_Dates() => 
		__Treatment_Initiation_With_Medication_Order_Dates.Value;

	private bool? Numerator_1_Value()
	{
		var a_ = this.Treatment_Initiation_With_Non_Medication_Intervention_Dates();
		var b_ = context.Operators.ExistsInList<CqlDate>(a_);
		var c_ = this.Treatment_Initiation_With_Medication_Order_Dates();
		var d_ = context.Operators.ExistsInList<CqlDate>(c_);
		var e_ = context.Operators.Or(b_, d_);

		return e_;
	}

    [CqlDeclaration("Numerator 1")]
	public bool? Numerator_1() => 
		__Numerator_1.Value;

	private bool? Has_Two_or_More_Treatment_Engagements_With_Short_Acting_Medication_or_Non_Medication_Intervention_Value()
	{
		var a_ = this.Psychosocial_Visit();
		var b_ = this.Substance_Use_Disorder_Short_Acting_Medication_Administration();
		var c_ = context.Operators.RetrieveByValueSet<Procedure>(b_, null);
		var d_ = Status_1_6_000.isProcedurePerformed(c_);
		var e_ = context.Operators.ListUnion<object>((a_ as IEnumerable<object>), (d_ as IEnumerable<object>));
		IEnumerable<object> f_(object ShortActingTreatment)
		{
			var v_ = this.Treatment_Initiation_With_Non_Medication_Intervention_Dates();
			var w_ = this.Treatment_Initiation_With_Medication_Order_Dates();
			var x_ = context.Operators.ListUnion<CqlDate>(v_, w_);
			var y_ = context.Operators.MinOrNull<CqlDate>(x_);
			var z_ = new CqlDate[]
			{
				y_,
			};
			bool? aa_(CqlDate InitiationTreatmentDate)
			{
				var ae_ = context.Operators.LateBoundProperty<object>(ShortActingTreatment, "performed");
				var af_ = FHIRHelpers_4_3_000.ToValue(ae_);
				var ag_ = QICoreCommon_2_0_000.toInterval(af_);
				var ah_ = context.Operators.Start(ag_);
				var ai_ = context.Operators.DateFrom(ah_);
				var aj_ = context.Operators.Quantity(34m, "days");
				var ak_ = context.Operators.Add(InitiationTreatmentDate, aj_);
				var al_ = context.Operators.Interval(InitiationTreatmentDate, ak_, false, true);
				var am_ = context.Operators.ElementInInterval<CqlDate>(ai_, al_, null);
				var an_ = context.Operators.Not((bool?)(InitiationTreatmentDate is null));
				var ao_ = context.Operators.And(am_, an_);
				var ap_ = context.Operators.LateBoundProperty<object>(ShortActingTreatment, "period");
				var aq_ = FHIRHelpers_4_3_000.ToInterval(ap_);
				var ar_ = QICoreCommon_2_0_000.toInterval((aq_ as object));
				var as_ = context.Operators.Start(ar_);
				var at_ = context.Operators.DateFrom(as_);
				var av_ = context.Operators.Add(InitiationTreatmentDate, aj_);
				var aw_ = context.Operators.Interval(InitiationTreatmentDate, av_, false, true);
				var ax_ = context.Operators.ElementInInterval<CqlDate>(at_, aw_, null);
				var az_ = context.Operators.And(ax_, an_);
				var ba_ = context.Operators.Or(ao_, az_);

				return ba_;
			};
			var ab_ = context.Operators.WhereOrNull<CqlDate>(z_, aa_);
			object ac_(CqlDate InitiationTreatmentDate) => 
				ShortActingTreatment;
			var ad_ = context.Operators.SelectOrNull<CqlDate, object>(ab_, ac_);

			return ad_;
		};
		var g_ = context.Operators.SelectManyOrNull<object, object>(e_, f_);
		object h_(object ShortActingTreatment) => 
			ShortActingTreatment;
		var i_ = context.Operators.SelectOrNull<object, object>(g_, h_);
		var j_ = this.Substance_Use_Disorder_Short_Acting_Medication();
		var k_ = context.Operators.RetrieveByValueSet<MedicationRequest>(j_, null);
		var m_ = context.Operators.RetrieveByValueSet<MedicationRequest>(j_, null);
		var n_ = context.Operators.ListUnion<MedicationRequest>(k_, m_);
		IEnumerable<MedicationRequest> o_(MedicationRequest ShortActingMedOrder)
		{
			var bb_ = this.Treatment_Initiation_With_Non_Medication_Intervention_Dates();
			var bc_ = this.Treatment_Initiation_With_Medication_Order_Dates();
			var bd_ = context.Operators.ListUnion<CqlDate>(bb_, bc_);
			var be_ = context.Operators.MinOrNull<CqlDate>(bd_);
			var bf_ = new CqlDate[]
			{
				be_,
			};
			bool? bg_(CqlDate InitiationTreatmentDate)
			{
				var bk_ = context.Operators.Convert<CqlDateTime>(ShortActingMedOrder?.AuthoredOnElement);
				var bl_ = QICoreCommon_2_0_000.toInterval((bk_ as object));
				var bm_ = context.Operators.Start(bl_);
				var bn_ = context.Operators.DateFrom(bm_);
				var bo_ = context.Operators.Quantity(34m, "days");
				var bp_ = context.Operators.Add(InitiationTreatmentDate, bo_);
				var bq_ = context.Operators.Interval(InitiationTreatmentDate, bp_, false, true);
				var br_ = context.Operators.ElementInInterval<CqlDate>(bn_, bq_, null);
				var bs_ = context.Operators.Not((bool?)(InitiationTreatmentDate is null));
				var bt_ = context.Operators.And(br_, bs_);

				return bt_;
			};
			var bh_ = context.Operators.WhereOrNull<CqlDate>(bf_, bg_);
			MedicationRequest bi_(CqlDate InitiationTreatmentDate) => 
				ShortActingMedOrder;
			var bj_ = context.Operators.SelectOrNull<CqlDate, MedicationRequest>(bh_, bi_);

			return bj_;
		};
		var p_ = context.Operators.SelectManyOrNull<MedicationRequest, MedicationRequest>(n_, o_);
		MedicationRequest q_(MedicationRequest ShortActingMedOrder) => 
			ShortActingMedOrder;
		var r_ = context.Operators.SelectOrNull<MedicationRequest, MedicationRequest>(p_, q_);
		var s_ = context.Operators.ListUnion<object>((i_ as IEnumerable<object>), (r_ as IEnumerable<object>));
		var t_ = context.Operators.CountOrNull<object>(s_);
		var u_ = context.Operators.GreaterOrEqual(t_, (int?)2);

		return u_;
	}

    [CqlDeclaration("Has Two or More Treatment Engagements With Short Acting Medication or Non Medication Intervention")]
	public bool? Has_Two_or_More_Treatment_Engagements_With_Short_Acting_Medication_or_Non_Medication_Intervention() => 
		__Has_Two_or_More_Treatment_Engagements_With_Short_Acting_Medication_or_Non_Medication_Intervention.Value;

	private bool? Has_Treatment_Engagement_With_Long_Acting_Medication_Value()
	{
		var a_ = this.Substance_Use_Disorder_Long_Acting_Medication();
		var b_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		var d_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		var e_ = context.Operators.ListUnion<MedicationRequest>(b_, d_);
		IEnumerable<MedicationRequest> f_(MedicationRequest LongActingMedOrder)
		{
			var o_ = this.Treatment_Initiation_With_Non_Medication_Intervention_Dates();
			var p_ = this.Treatment_Initiation_With_Medication_Order_Dates();
			var q_ = context.Operators.ListUnion<CqlDate>(o_, p_);
			var r_ = context.Operators.MinOrNull<CqlDate>(q_);
			var s_ = new CqlDate[]
			{
				r_,
			};
			bool? t_(CqlDate InitiationTreatmentDate)
			{
				var x_ = context.Operators.Convert<CqlDateTime>(LongActingMedOrder?.AuthoredOnElement);
				var y_ = QICoreCommon_2_0_000.toInterval((x_ as object));
				var z_ = context.Operators.Start(y_);
				var aa_ = context.Operators.DateFrom(z_);
				var ab_ = context.Operators.Quantity(34m, "days");
				var ac_ = context.Operators.Add(InitiationTreatmentDate, ab_);
				var ad_ = context.Operators.Interval(InitiationTreatmentDate, ac_, false, true);
				var ae_ = context.Operators.ElementInInterval<CqlDate>(aa_, ad_, null);
				var af_ = context.Operators.Not((bool?)(InitiationTreatmentDate is null));
				var ag_ = context.Operators.And(ae_, af_);

				return ag_;
			};
			var u_ = context.Operators.WhereOrNull<CqlDate>(s_, t_);
			MedicationRequest v_(CqlDate InitiationTreatmentDate) => 
				LongActingMedOrder;
			var w_ = context.Operators.SelectOrNull<CqlDate, MedicationRequest>(u_, v_);

			return w_;
		};
		var g_ = context.Operators.SelectManyOrNull<MedicationRequest, MedicationRequest>(e_, f_);
		var h_ = this.Substance_Use_Disorder_Long_Acting_Medication_Administration();
		var i_ = context.Operators.RetrieveByValueSet<Procedure>(h_, null);
		var j_ = Status_1_6_000.isProcedurePerformed(i_);
		IEnumerable<Procedure> k_(Procedure LongActingTreatment)
		{
			var ah_ = this.Treatment_Initiation_With_Non_Medication_Intervention_Dates();
			var ai_ = this.Treatment_Initiation_With_Medication_Order_Dates();
			var aj_ = context.Operators.ListUnion<CqlDate>(ah_, ai_);
			var ak_ = context.Operators.MinOrNull<CqlDate>(aj_);
			var al_ = new CqlDate[]
			{
				ak_,
			};
			bool? am_(CqlDate InitiationTreatmentDate)
			{
				var aq_ = FHIRHelpers_4_3_000.ToValue(LongActingTreatment?.Performed);
				var ar_ = QICoreCommon_2_0_000.toInterval(aq_);
				var as_ = context.Operators.Start(ar_);
				var at_ = context.Operators.DateFrom(as_);
				var au_ = context.Operators.Quantity(34m, "days");
				var av_ = context.Operators.Add(InitiationTreatmentDate, au_);
				var aw_ = context.Operators.Interval(InitiationTreatmentDate, av_, false, true);
				var ax_ = context.Operators.ElementInInterval<CqlDate>(at_, aw_, null);
				var ay_ = context.Operators.Not((bool?)(InitiationTreatmentDate is null));
				var az_ = context.Operators.And(ax_, ay_);

				return az_;
			};
			var an_ = context.Operators.WhereOrNull<CqlDate>(al_, am_);
			Procedure ao_(CqlDate InitiationTreatmentDate) => 
				LongActingTreatment;
			var ap_ = context.Operators.SelectOrNull<CqlDate, Procedure>(an_, ao_);

			return ap_;
		};
		var l_ = context.Operators.SelectManyOrNull<Procedure, Procedure>(j_, k_);
		var m_ = context.Operators.ListUnion<object>((g_ as IEnumerable<object>), (l_ as IEnumerable<object>));
		var n_ = context.Operators.ExistsInList<object>(m_);

		return n_;
	}

    [CqlDeclaration("Has Treatment Engagement With Long Acting Medication")]
	public bool? Has_Treatment_Engagement_With_Long_Acting_Medication() => 
		__Has_Treatment_Engagement_With_Long_Acting_Medication.Value;

	private bool? Numerator_2_Value()
	{
		var a_ = this.Has_Treatment_Engagement_With_Long_Acting_Medication();
		var b_ = this.Has_Two_or_More_Treatment_Engagements_With_Short_Acting_Medication_or_Non_Medication_Intervention();
		var c_ = context.Operators.Or(a_, b_);

		return c_;
	}

    [CqlDeclaration("Numerator 2")]
	public bool? Numerator_2() => 
		__Numerator_2.Value;

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

	private bool? Stratification_1_Value()
	{
		var a_ = this.Patient();
		var b_ = context.Operators.Convert<CqlDate>(a_?.BirthDateElement?.Value);
		var c_ = this.Measurement_Period();
		var d_ = context.Operators.Start(c_);
		var e_ = context.Operators.DateFrom(d_);
		var f_ = context.Operators.CalculateAgeAt(b_, e_, "year");
		var g_ = context.Operators.Interval((int?)13, (int?)17, true, true);
		var h_ = context.Operators.ElementInInterval<int?>(f_, g_, null);

		return h_;
	}

    [CqlDeclaration("Stratification 1")]
	public bool? Stratification_1() => 
		__Stratification_1.Value;

	private bool? Stratification_2_Value()
	{
		var a_ = this.Patient();
		var b_ = context.Operators.Convert<CqlDate>(a_?.BirthDateElement?.Value);
		var c_ = this.Measurement_Period();
		var d_ = context.Operators.Start(c_);
		var e_ = context.Operators.DateFrom(d_);
		var f_ = context.Operators.CalculateAgeAt(b_, e_, "year");
		var g_ = context.Operators.Interval((int?)18, (int?)64, true, true);
		var h_ = context.Operators.ElementInInterval<int?>(f_, g_, null);

		return h_;
	}

    [CqlDeclaration("Stratification 2")]
	public bool? Stratification_2() => 
		__Stratification_2.Value;

	private bool? Stratification_3_Value()
	{
		var a_ = this.Patient();
		var b_ = context.Operators.Convert<CqlDate>(a_?.BirthDateElement?.Value);
		var c_ = this.Measurement_Period();
		var d_ = context.Operators.Start(c_);
		var e_ = context.Operators.DateFrom(d_);
		var f_ = context.Operators.CalculateAgeAt(b_, e_, "year");
		var g_ = context.Operators.GreaterOrEqual(f_, (int?)65);

		return g_;
	}

    [CqlDeclaration("Stratification 3")]
	public bool? Stratification_3() => 
		__Stratification_3.Value;

}