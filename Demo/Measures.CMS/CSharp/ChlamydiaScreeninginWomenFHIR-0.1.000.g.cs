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
[CqlLibrary("ChlamydiaScreeninginWomenFHIR", "0.1.000")]
public class ChlamydiaScreeninginWomenFHIR_0_1_000
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Chlamydia_Screening;
    internal Lazy<CqlValueSet> __Complications_of_Pregnancy__Childbirth_and_the_Puerperium;
    internal Lazy<CqlValueSet> __Contraceptive_Medications;
    internal Lazy<CqlValueSet> __Diagnoses_Used_to_Indicate_Sexual_Activity;
    internal Lazy<CqlValueSet> __Diagnostic_Studies_During_Pregnancy;
    internal Lazy<CqlValueSet> __HIV;
    internal Lazy<CqlValueSet> __Home_Healthcare_Services;
    internal Lazy<CqlValueSet> __Isotretinoin;
    internal Lazy<CqlValueSet> __Lab_Tests_During_Pregnancy;
    internal Lazy<CqlValueSet> __Lab_Tests_for_Sexually_Transmitted_Infections;
    internal Lazy<CqlValueSet> __Office_Visit;
    internal Lazy<CqlValueSet> __Online_Assessments;
    internal Lazy<CqlValueSet> __Pap_Test;
    internal Lazy<CqlValueSet> __Pregnancy_Test;
    internal Lazy<CqlValueSet> __Preventive_Care_Services_Established_Office_Visit__18_and_Up;
    internal Lazy<CqlValueSet> __Preventive_Care_Services_Initial_Office_Visit__18_and_Up;
    internal Lazy<CqlValueSet> __Preventive_Care_Services__Initial_Office_Visit__0_to_17;
    internal Lazy<CqlValueSet> __Preventive_Care__Established_Office_Visit__0_to_17;
    internal Lazy<CqlValueSet> __Procedures_Used_to_Indicate_Sexual_Activity;
    internal Lazy<CqlValueSet> __Telephone_Visits;
    internal Lazy<CqlValueSet> __XRay_Study;
    internal Lazy<CqlCode> __Female;
    internal Lazy<CqlCode> __Have_you_ever_had_vaginal_intercourse__PhenX_;
    internal Lazy<CqlCode> __Yes__qualifier_value_;
    internal Lazy<CqlCode[]> __AdministrativeGender;
    internal Lazy<CqlCode[]> __LOINC;
    internal Lazy<CqlCode[]> __SNOMEDCT;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<(IEnumerable<CqlCode> codes, string display)?> __SDE_Ethnicity;
    internal Lazy<IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?>> __SDE_Payer;
    internal Lazy<(IEnumerable<CqlCode> codes, string display)?> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;
    internal Lazy<IEnumerable<Encounter>> __Qualifying_Encounters;
    internal Lazy<bool?> __Has_Assessments_Identifying_Sexual_Activity;
    internal Lazy<bool?> __Has_Diagnoses_Identifying_Sexual_Activity;
    internal Lazy<bool?> __Has_Active_Contraceptive_Medications;
    internal Lazy<bool?> __Has_Ordered_Contraceptive_Medications;
    internal Lazy<bool?> __Has_Laboratory_Tests_Identifying_Sexual_Activity_But_Not_Pregnancy;
    internal Lazy<bool?> __Has_Laboratory_Tests_Identifying_Sexual_Activity;
    internal Lazy<bool?> __Has_Diagnostic_Studies_Identifying_Sexual_Activity;
    internal Lazy<bool?> __Has_Procedures_Identifying_Sexual_Activity;
    internal Lazy<bool?> __Initial_Population;
    internal Lazy<bool?> __Denominator;
    internal Lazy<bool?> __Has_Pregnancy_Test_Exclusion;
    internal Lazy<bool?> __Denominator_Exclusions;
    internal Lazy<bool?> __Numerator;
    internal Lazy<bool?> __Stratification_1;
    internal Lazy<bool?> __Stratification_2;

    #endregion
    public ChlamydiaScreeninginWomenFHIR_0_1_000(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_3_000 = new FHIRHelpers_4_3_000(context);
        QICoreCommon_2_0_000 = new QICoreCommon_2_0_000(context);
        CQMCommon_2_0_000 = new CQMCommon_2_0_000(context);
        SupplementalDataElements_3_4_000 = new SupplementalDataElements_3_4_000(context);
        Hospice_6_9_000 = new Hospice_6_9_000(context);
        CumulativeMedicationDuration_4_0_000 = new CumulativeMedicationDuration_4_0_000(context);
        Status_1_6_000 = new Status_1_6_000(context);

        __Chlamydia_Screening = new Lazy<CqlValueSet>(this.Chlamydia_Screening_Value);
        __Complications_of_Pregnancy__Childbirth_and_the_Puerperium = new Lazy<CqlValueSet>(this.Complications_of_Pregnancy__Childbirth_and_the_Puerperium_Value);
        __Contraceptive_Medications = new Lazy<CqlValueSet>(this.Contraceptive_Medications_Value);
        __Diagnoses_Used_to_Indicate_Sexual_Activity = new Lazy<CqlValueSet>(this.Diagnoses_Used_to_Indicate_Sexual_Activity_Value);
        __Diagnostic_Studies_During_Pregnancy = new Lazy<CqlValueSet>(this.Diagnostic_Studies_During_Pregnancy_Value);
        __HIV = new Lazy<CqlValueSet>(this.HIV_Value);
        __Home_Healthcare_Services = new Lazy<CqlValueSet>(this.Home_Healthcare_Services_Value);
        __Isotretinoin = new Lazy<CqlValueSet>(this.Isotretinoin_Value);
        __Lab_Tests_During_Pregnancy = new Lazy<CqlValueSet>(this.Lab_Tests_During_Pregnancy_Value);
        __Lab_Tests_for_Sexually_Transmitted_Infections = new Lazy<CqlValueSet>(this.Lab_Tests_for_Sexually_Transmitted_Infections_Value);
        __Office_Visit = new Lazy<CqlValueSet>(this.Office_Visit_Value);
        __Online_Assessments = new Lazy<CqlValueSet>(this.Online_Assessments_Value);
        __Pap_Test = new Lazy<CqlValueSet>(this.Pap_Test_Value);
        __Pregnancy_Test = new Lazy<CqlValueSet>(this.Pregnancy_Test_Value);
        __Preventive_Care_Services_Established_Office_Visit__18_and_Up = new Lazy<CqlValueSet>(this.Preventive_Care_Services_Established_Office_Visit__18_and_Up_Value);
        __Preventive_Care_Services_Initial_Office_Visit__18_and_Up = new Lazy<CqlValueSet>(this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up_Value);
        __Preventive_Care_Services__Initial_Office_Visit__0_to_17 = new Lazy<CqlValueSet>(this.Preventive_Care_Services__Initial_Office_Visit__0_to_17_Value);
        __Preventive_Care__Established_Office_Visit__0_to_17 = new Lazy<CqlValueSet>(this.Preventive_Care__Established_Office_Visit__0_to_17_Value);
        __Procedures_Used_to_Indicate_Sexual_Activity = new Lazy<CqlValueSet>(this.Procedures_Used_to_Indicate_Sexual_Activity_Value);
        __Telephone_Visits = new Lazy<CqlValueSet>(this.Telephone_Visits_Value);
        __XRay_Study = new Lazy<CqlValueSet>(this.XRay_Study_Value);
        __Female = new Lazy<CqlCode>(this.Female_Value);
        __Have_you_ever_had_vaginal_intercourse__PhenX_ = new Lazy<CqlCode>(this.Have_you_ever_had_vaginal_intercourse__PhenX__Value);
        __Yes__qualifier_value_ = new Lazy<CqlCode>(this.Yes__qualifier_value__Value);
        __AdministrativeGender = new Lazy<CqlCode[]>(this.AdministrativeGender_Value);
        __LOINC = new Lazy<CqlCode[]>(this.LOINC_Value);
        __SNOMEDCT = new Lazy<CqlCode[]>(this.SNOMEDCT_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __SDE_Ethnicity = new Lazy<(IEnumerable<CqlCode> codes, string display)?>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<(IEnumerable<CqlCode> codes, string display)?>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
        __Qualifying_Encounters = new Lazy<IEnumerable<Encounter>>(this.Qualifying_Encounters_Value);
        __Has_Assessments_Identifying_Sexual_Activity = new Lazy<bool?>(this.Has_Assessments_Identifying_Sexual_Activity_Value);
        __Has_Diagnoses_Identifying_Sexual_Activity = new Lazy<bool?>(this.Has_Diagnoses_Identifying_Sexual_Activity_Value);
        __Has_Active_Contraceptive_Medications = new Lazy<bool?>(this.Has_Active_Contraceptive_Medications_Value);
        __Has_Ordered_Contraceptive_Medications = new Lazy<bool?>(this.Has_Ordered_Contraceptive_Medications_Value);
        __Has_Laboratory_Tests_Identifying_Sexual_Activity_But_Not_Pregnancy = new Lazy<bool?>(this.Has_Laboratory_Tests_Identifying_Sexual_Activity_But_Not_Pregnancy_Value);
        __Has_Laboratory_Tests_Identifying_Sexual_Activity = new Lazy<bool?>(this.Has_Laboratory_Tests_Identifying_Sexual_Activity_Value);
        __Has_Diagnostic_Studies_Identifying_Sexual_Activity = new Lazy<bool?>(this.Has_Diagnostic_Studies_Identifying_Sexual_Activity_Value);
        __Has_Procedures_Identifying_Sexual_Activity = new Lazy<bool?>(this.Has_Procedures_Identifying_Sexual_Activity_Value);
        __Initial_Population = new Lazy<bool?>(this.Initial_Population_Value);
        __Denominator = new Lazy<bool?>(this.Denominator_Value);
        __Has_Pregnancy_Test_Exclusion = new Lazy<bool?>(this.Has_Pregnancy_Test_Exclusion_Value);
        __Denominator_Exclusions = new Lazy<bool?>(this.Denominator_Exclusions_Value);
        __Numerator = new Lazy<bool?>(this.Numerator_Value);
        __Stratification_1 = new Lazy<bool?>(this.Stratification_1_Value);
        __Stratification_2 = new Lazy<bool?>(this.Stratification_2_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_3_000 FHIRHelpers_4_3_000 { get; }
    public QICoreCommon_2_0_000 QICoreCommon_2_0_000 { get; }
    public CQMCommon_2_0_000 CQMCommon_2_0_000 { get; }
    public SupplementalDataElements_3_4_000 SupplementalDataElements_3_4_000 { get; }
    public Hospice_6_9_000 Hospice_6_9_000 { get; }
    public CumulativeMedicationDuration_4_0_000 CumulativeMedicationDuration_4_0_000 { get; }
    public Status_1_6_000 Status_1_6_000 { get; }

    #endregion

	private CqlValueSet Chlamydia_Screening_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1052", default);

    [CqlDeclaration("Chlamydia Screening")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1052")]
	public CqlValueSet Chlamydia_Screening() => 
		__Chlamydia_Screening.Value;

	private CqlValueSet Complications_of_Pregnancy__Childbirth_and_the_Puerperium_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1012", default);

    [CqlDeclaration("Complications of Pregnancy, Childbirth and the Puerperium")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1012")]
	public CqlValueSet Complications_of_Pregnancy__Childbirth_and_the_Puerperium() => 
		__Complications_of_Pregnancy__Childbirth_and_the_Puerperium.Value;

	private CqlValueSet Contraceptive_Medications_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1080", default);

    [CqlDeclaration("Contraceptive Medications")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1080")]
	public CqlValueSet Contraceptive_Medications() => 
		__Contraceptive_Medications.Value;

	private CqlValueSet Diagnoses_Used_to_Indicate_Sexual_Activity_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1018", default);

    [CqlDeclaration("Diagnoses Used to Indicate Sexual Activity")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1018")]
	public CqlValueSet Diagnoses_Used_to_Indicate_Sexual_Activity() => 
		__Diagnoses_Used_to_Indicate_Sexual_Activity.Value;

	private CqlValueSet Diagnostic_Studies_During_Pregnancy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1008", default);

    [CqlDeclaration("Diagnostic Studies During Pregnancy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1008")]
	public CqlValueSet Diagnostic_Studies_During_Pregnancy() => 
		__Diagnostic_Studies_During_Pregnancy.Value;

	private CqlValueSet HIV_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003", default);

    [CqlDeclaration("HIV")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003")]
	public CqlValueSet HIV() => 
		__HIV.Value;

	private CqlValueSet Home_Healthcare_Services_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", default);

    [CqlDeclaration("Home Healthcare Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016")]
	public CqlValueSet Home_Healthcare_Services() => 
		__Home_Healthcare_Services.Value;

	private CqlValueSet Isotretinoin_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1143", default);

    [CqlDeclaration("Isotretinoin")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1143")]
	public CqlValueSet Isotretinoin() => 
		__Isotretinoin.Value;

	private CqlValueSet Lab_Tests_During_Pregnancy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1007", default);

    [CqlDeclaration("Lab Tests During Pregnancy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1007")]
	public CqlValueSet Lab_Tests_During_Pregnancy() => 
		__Lab_Tests_During_Pregnancy.Value;

	private CqlValueSet Lab_Tests_for_Sexually_Transmitted_Infections_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1051", default);

    [CqlDeclaration("Lab Tests for Sexually Transmitted Infections")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1051")]
	public CqlValueSet Lab_Tests_for_Sexually_Transmitted_Infections() => 
		__Lab_Tests_for_Sexually_Transmitted_Infections.Value;

	private CqlValueSet Office_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", default);

    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
	public CqlValueSet Office_Visit() => 
		__Office_Visit.Value;

	private CqlValueSet Online_Assessments_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", default);

    [CqlDeclaration("Online Assessments")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089")]
	public CqlValueSet Online_Assessments() => 
		__Online_Assessments.Value;

	private CqlValueSet Pap_Test_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1017", default);

    [CqlDeclaration("Pap Test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1017")]
	public CqlValueSet Pap_Test() => 
		__Pap_Test.Value;

	private CqlValueSet Pregnancy_Test_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1011", default);

    [CqlDeclaration("Pregnancy Test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1011")]
	public CqlValueSet Pregnancy_Test() => 
		__Pregnancy_Test.Value;

	private CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", default);

    [CqlDeclaration("Preventive Care Services Established Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025")]
	public CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up() => 
		__Preventive_Care_Services_Established_Office_Visit__18_and_Up.Value;

	private CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", default);

    [CqlDeclaration("Preventive Care Services Initial Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023")]
	public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up() => 
		__Preventive_Care_Services_Initial_Office_Visit__18_and_Up.Value;

	private CqlValueSet Preventive_Care_Services__Initial_Office_Visit__0_to_17_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", default);

    [CqlDeclaration("Preventive Care Services, Initial Office Visit, 0 to 17")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022")]
	public CqlValueSet Preventive_Care_Services__Initial_Office_Visit__0_to_17() => 
		__Preventive_Care_Services__Initial_Office_Visit__0_to_17.Value;

	private CqlValueSet Preventive_Care__Established_Office_Visit__0_to_17_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", default);

    [CqlDeclaration("Preventive Care, Established Office Visit, 0 to 17")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024")]
	public CqlValueSet Preventive_Care__Established_Office_Visit__0_to_17() => 
		__Preventive_Care__Established_Office_Visit__0_to_17.Value;

	private CqlValueSet Procedures_Used_to_Indicate_Sexual_Activity_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1017", default);

    [CqlDeclaration("Procedures Used to Indicate Sexual Activity")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1017")]
	public CqlValueSet Procedures_Used_to_Indicate_Sexual_Activity() => 
		__Procedures_Used_to_Indicate_Sexual_Activity.Value;

	private CqlValueSet Telephone_Visits_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", default);

    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
	public CqlValueSet Telephone_Visits() => 
		__Telephone_Visits.Value;

	private CqlValueSet XRay_Study_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1034", default);

    [CqlDeclaration("XRay Study")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1034")]
	public CqlValueSet XRay_Study() => 
		__XRay_Study.Value;

	private CqlCode Female_Value() => 
		new CqlCode("F", "http://terminology.hl7.org/CodeSystem/v3-AdministrativeGender", default, default);

    [CqlDeclaration("Female")]
	public CqlCode Female() => 
		__Female.Value;

	private CqlCode Have_you_ever_had_vaginal_intercourse__PhenX__Value() => 
		new CqlCode("64728-9", "http://loinc.org", default, default);

    [CqlDeclaration("Have you ever had vaginal intercourse [PhenX]")]
	public CqlCode Have_you_ever_had_vaginal_intercourse__PhenX_() => 
		__Have_you_ever_had_vaginal_intercourse__PhenX_.Value;

	private CqlCode Yes__qualifier_value__Value() => 
		new CqlCode("373066001", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Yes (qualifier value)")]
	public CqlCode Yes__qualifier_value_() => 
		__Yes__qualifier_value_.Value;

	private CqlCode[] AdministrativeGender_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("F", "http://terminology.hl7.org/CodeSystem/v3-AdministrativeGender", default, default),
		];

		return a_;
	}

    [CqlDeclaration("AdministrativeGender")]
	public CqlCode[] AdministrativeGender() => 
		__AdministrativeGender.Value;

	private CqlCode[] LOINC_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("64728-9", "http://loinc.org", default, default),
		];

		return a_;
	}

    [CqlDeclaration("LOINC")]
	public CqlCode[] LOINC() => 
		__LOINC.Value;

	private CqlCode[] SNOMEDCT_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("373066001", "http://snomed.info/sct", default, default),
		];

		return a_;
	}

    [CqlDeclaration("SNOMEDCT")]
	public CqlCode[] SNOMEDCT() => 
		__SNOMEDCT.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("ChlamydiaScreeninginWomenFHIR-0.1.000", "Measurement Period", c_);

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

	private IEnumerable<Encounter> Qualifying_Encounters_Value()
	{
		CqlValueSet a_ = this.Office_Visit();
		IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		CqlValueSet c_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up();
		IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
		CqlValueSet f_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up();
		IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		CqlValueSet h_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17();
		IEnumerable<Encounter> i_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
		IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
		CqlValueSet l_ = this.Preventive_Care__Established_Office_Visit__0_to_17();
		IEnumerable<Encounter> m_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		CqlValueSet n_ = this.Home_Healthcare_Services();
		IEnumerable<Encounter> o_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> p_ = context.Operators.Union<Encounter>(m_, o_);
		IEnumerable<Encounter> q_ = context.Operators.Union<Encounter>(k_, p_);
		CqlValueSet r_ = this.Telephone_Visits();
		IEnumerable<Encounter> s_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		CqlValueSet t_ = this.Online_Assessments();
		IEnumerable<Encounter> u_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, t_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> v_ = context.Operators.Union<Encounter>(s_, u_);
		IEnumerable<Encounter> w_ = context.Operators.Union<Encounter>(q_, v_);
		IEnumerable<Encounter> x_ = Status_1_6_000.Finished_Encounter(w_);
		bool? y_(Encounter ValidEncounters)
		{
			CqlInterval<CqlDateTime> aa_ = this.Measurement_Period();
			Period ab_ = ValidEncounters?.Period;
			CqlInterval<CqlDateTime> ac_ = FHIRHelpers_4_3_000.ToInterval(ab_);
			CqlInterval<CqlDateTime> ad_ = QICoreCommon_2_0_000.ToInterval(ac_ as object);
			bool? ae_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(aa_, ad_, "day");

			return ae_;
		};
		IEnumerable<Encounter> z_ = context.Operators.Where<Encounter>(x_, y_);

		return z_;
	}

    [CqlDeclaration("Qualifying Encounters")]
	public IEnumerable<Encounter> Qualifying_Encounters() => 
		__Qualifying_Encounters.Value;

	private bool? Has_Assessments_Identifying_Sexual_Activity_Value()
	{
		CqlCode a_ = this.Have_you_ever_had_vaginal_intercourse__PhenX_();
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
		IEnumerable<Observation> d_ = Status_1_6_000.Final_Survey_Observation(c_);
		bool? e_(Observation SexualActivityAssessment)
		{
			DataType h_ = SexualActivityAssessment?.Value;
			object i_ = FHIRHelpers_4_3_000.ToValue(h_);
			CqlCode j_ = this.Yes__qualifier_value_();
			CqlConcept k_ = context.Operators.ConvertCodeToConcept(j_);
			bool? l_ = context.Operators.Equivalent(i_ as CqlConcept, k_);
			DataType m_ = SexualActivityAssessment?.Effective;
			object n_ = FHIRHelpers_4_3_000.ToValue(m_);
			CqlInterval<CqlDateTime> o_ = QICoreCommon_2_0_000.ToInterval(n_);
			CqlInterval<CqlDateTime> p_()
			{
				bool s_()
				{
					CqlInterval<CqlDateTime> t_ = this.Measurement_Period();
					CqlDateTime u_ = context.Operators.End(t_);

					return u_ is null;
				};
				if (s_())
				{
					return default;
				}
				else
				{
					CqlInterval<CqlDateTime> v_ = this.Measurement_Period();
					CqlDateTime w_ = context.Operators.End(v_);
					CqlDateTime y_ = context.Operators.End(v_);
					CqlInterval<CqlDateTime> z_ = context.Operators.Interval(w_, y_, true, true);

					return z_;
				}
			};
			bool? q_ = context.Operators.SameOrBefore(o_, p_(), default);
			bool? r_ = context.Operators.And(l_, q_);

			return r_;
		};
		IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);
		bool? g_ = context.Operators.Exists<Observation>(f_);

		return g_;
	}

    [CqlDeclaration("Has Assessments Identifying Sexual Activity")]
	public bool? Has_Assessments_Identifying_Sexual_Activity() => 
		__Has_Assessments_Identifying_Sexual_Activity.Value;

	private bool? Has_Diagnoses_Identifying_Sexual_Activity_Value()
	{
		CqlValueSet a_ = this.Diagnoses_Used_to_Indicate_Sexual_Activity();
		IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		CqlValueSet c_ = this.HIV();
		IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		IEnumerable<Condition> e_ = context.Operators.Union<Condition>(b_, d_);
		CqlValueSet f_ = this.Complications_of_Pregnancy__Childbirth_and_the_Puerperium();
		IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		IEnumerable<Condition> h_ = context.Operators.Union<Condition>(e_, g_);
		bool? i_(Condition SexualActivityDiagnosis)
		{
			CqlInterval<CqlDateTime> l_ = QICoreCommon_2_0_000.ToPrevalenceInterval(SexualActivityDiagnosis);
			CqlInterval<CqlDateTime> m_ = this.Measurement_Period();
			bool? n_ = context.Operators.Overlaps(l_, m_, default);

			return n_;
		};
		IEnumerable<Condition> j_ = context.Operators.Where<Condition>(h_, i_);
		bool? k_ = context.Operators.Exists<Condition>(j_);

		return k_;
	}

    [CqlDeclaration("Has Diagnoses Identifying Sexual Activity")]
	public bool? Has_Diagnoses_Identifying_Sexual_Activity() => 
		__Has_Diagnoses_Identifying_Sexual_Activity.Value;

	private bool? Has_Active_Contraceptive_Medications_Value()
	{
		CqlValueSet a_ = this.Contraceptive_Medications();
		IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> d_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> e_ = context.Operators.Union<MedicationRequest>(b_, d_);
		IEnumerable<MedicationRequest> f_ = Status_1_6_000.Active_Medication(e_);
		bool? g_(MedicationRequest ActiveContraceptives)
		{
			CqlInterval<CqlDate> j_ = CumulativeMedicationDuration_4_0_000.MedicationRequestPeriod(ActiveContraceptives);
			CqlDate k_ = j_?.low;
			CqlDateTime l_ = context.Operators.ConvertDateToDateTime(k_);
			CqlDate n_ = j_?.high;
			CqlDateTime o_ = context.Operators.ConvertDateToDateTime(n_);
			bool? q_ = j_?.lowClosed;
			bool? s_ = j_?.highClosed;
			CqlInterval<CqlDateTime> t_ = context.Operators.Interval(l_, o_, q_, s_);
			CqlInterval<CqlDateTime> u_ = this.Measurement_Period();
			bool? v_ = context.Operators.Overlaps(t_, u_, default);

			return v_;
		};
		IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);
		bool? i_ = context.Operators.Exists<MedicationRequest>(h_);

		return i_;
	}

    [CqlDeclaration("Has Active Contraceptive Medications")]
	public bool? Has_Active_Contraceptive_Medications() => 
		__Has_Active_Contraceptive_Medications.Value;

	private bool? Has_Ordered_Contraceptive_Medications_Value()
	{
		CqlValueSet a_ = this.Contraceptive_Medications();
		IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> d_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
		IEnumerable<MedicationRequest> e_ = context.Operators.Union<MedicationRequest>(b_, d_);
		IEnumerable<MedicationRequest> f_ = Status_1_6_000.Active_or_Completed_Medication_Request(e_);
		bool? g_(MedicationRequest OrderedContraceptives)
		{
			CqlInterval<CqlDateTime> j_ = this.Measurement_Period();
			FhirDateTime k_ = OrderedContraceptives?.AuthoredOnElement;
			CqlDateTime l_ = context.Operators.Convert<CqlDateTime>(k_);
			CqlInterval<CqlDateTime> m_ = QICoreCommon_2_0_000.ToInterval(l_ as object);
			bool? n_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(j_, m_, "day");

			return n_;
		};
		IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);
		bool? i_ = context.Operators.Exists<MedicationRequest>(h_);

		return i_;
	}

    [CqlDeclaration("Has Ordered Contraceptive Medications")]
	public bool? Has_Ordered_Contraceptive_Medications() => 
		__Has_Ordered_Contraceptive_Medications.Value;

	private bool? Has_Laboratory_Tests_Identifying_Sexual_Activity_But_Not_Pregnancy_Value()
	{
		CqlValueSet a_ = this.Pap_Test();
		IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
		CqlValueSet c_ = this.Lab_Tests_During_Pregnancy();
		IEnumerable<ServiceRequest> d_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
		IEnumerable<ServiceRequest> e_ = context.Operators.Union<ServiceRequest>(b_, d_);
		CqlValueSet f_ = this.Lab_Tests_for_Sexually_Transmitted_Infections();
		IEnumerable<ServiceRequest> g_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
		IEnumerable<ServiceRequest> h_ = context.Operators.Union<ServiceRequest>(e_, g_);
		IEnumerable<ServiceRequest> i_ = Status_1_6_000.Completed_or_Ongoing_Service_Request(h_);
		bool? j_(ServiceRequest LabOrders)
		{
			CqlInterval<CqlDateTime> m_ = this.Measurement_Period();
			FhirDateTime n_ = LabOrders?.AuthoredOnElement;
			CqlDateTime o_ = context.Operators.Convert<CqlDateTime>(n_);
			CqlInterval<CqlDateTime> p_ = QICoreCommon_2_0_000.ToInterval(o_ as object);
			bool? q_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(m_, p_, "day");

			return q_;
		};
		IEnumerable<ServiceRequest> k_ = context.Operators.Where<ServiceRequest>(i_, j_);
		bool? l_ = context.Operators.Exists<ServiceRequest>(k_);

		return l_;
	}

    [CqlDeclaration("Has Laboratory Tests Identifying Sexual Activity But Not Pregnancy")]
	public bool? Has_Laboratory_Tests_Identifying_Sexual_Activity_But_Not_Pregnancy() => 
		__Has_Laboratory_Tests_Identifying_Sexual_Activity_But_Not_Pregnancy.Value;

	private bool? Has_Laboratory_Tests_Identifying_Sexual_Activity_Value()
	{
		CqlValueSet a_ = this.Pregnancy_Test();
		IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
		IEnumerable<ServiceRequest> c_ = Status_1_6_000.Completed_or_Ongoing_Service_Request(b_);
		bool? d_(ServiceRequest PregnancyTest)
		{
			CqlInterval<CqlDateTime> i_ = this.Measurement_Period();
			FhirDateTime j_ = PregnancyTest?.AuthoredOnElement;
			CqlDateTime k_ = context.Operators.Convert<CqlDateTime>(j_);
			CqlInterval<CqlDateTime> l_ = QICoreCommon_2_0_000.ToInterval(k_ as object);
			bool? m_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(i_, l_, "day");

			return m_;
		};
		IEnumerable<ServiceRequest> e_ = context.Operators.Where<ServiceRequest>(c_, d_);
		bool? f_ = context.Operators.Exists<ServiceRequest>(e_);
		bool? g_ = this.Has_Laboratory_Tests_Identifying_Sexual_Activity_But_Not_Pregnancy();
		bool? h_ = context.Operators.Or(f_, g_);

		return h_;
	}

    [CqlDeclaration("Has Laboratory Tests Identifying Sexual Activity")]
	public bool? Has_Laboratory_Tests_Identifying_Sexual_Activity() => 
		__Has_Laboratory_Tests_Identifying_Sexual_Activity.Value;

	private bool? Has_Diagnostic_Studies_Identifying_Sexual_Activity_Value()
	{
		CqlValueSet a_ = this.Diagnostic_Studies_During_Pregnancy();
		IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
		IEnumerable<ServiceRequest> c_ = Status_1_6_000.Completed_or_Ongoing_Service_Request(b_);
		bool? d_(ServiceRequest SexualActivityDiagnostics)
		{
			CqlInterval<CqlDateTime> g_ = this.Measurement_Period();
			FhirDateTime h_ = SexualActivityDiagnostics?.AuthoredOnElement;
			CqlDateTime i_ = context.Operators.Convert<CqlDateTime>(h_);
			CqlInterval<CqlDateTime> j_ = QICoreCommon_2_0_000.ToInterval(i_ as object);
			bool? k_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(g_, j_, "day");

			return k_;
		};
		IEnumerable<ServiceRequest> e_ = context.Operators.Where<ServiceRequest>(c_, d_);
		bool? f_ = context.Operators.Exists<ServiceRequest>(e_);

		return f_;
	}

    [CqlDeclaration("Has Diagnostic Studies Identifying Sexual Activity")]
	public bool? Has_Diagnostic_Studies_Identifying_Sexual_Activity() => 
		__Has_Diagnostic_Studies_Identifying_Sexual_Activity.Value;

	private bool? Has_Procedures_Identifying_Sexual_Activity_Value()
	{
		CqlValueSet a_ = this.Procedures_Used_to_Indicate_Sexual_Activity();
		IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
		IEnumerable<Procedure> c_ = Status_1_6_000.Completed_Procedure(b_);
		bool? d_(Procedure ProceduresForSexualActivity)
		{
			CqlInterval<CqlDateTime> g_ = this.Measurement_Period();
			DataType h_ = ProceduresForSexualActivity?.Performed;
			object i_ = FHIRHelpers_4_3_000.ToValue(h_);
			CqlInterval<CqlDateTime> j_ = QICoreCommon_2_0_000.ToInterval(i_);
			bool? k_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(g_, j_, "day");

			return k_;
		};
		IEnumerable<Procedure> e_ = context.Operators.Where<Procedure>(c_, d_);
		bool? f_ = context.Operators.Exists<Procedure>(e_);

		return f_;
	}

    [CqlDeclaration("Has Procedures Identifying Sexual Activity")]
	public bool? Has_Procedures_Identifying_Sexual_Activity() => 
		__Has_Procedures_Identifying_Sexual_Activity.Value;

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
		CqlInterval<int?> i_ = context.Operators.Interval(16, 24, true, true);
		bool? j_ = context.Operators.In<int?>(h_, i_, default);
		Code<AdministrativeGender> l_ = a_?.GenderElement;
		AdministrativeGender? m_ = l_?.Value;
		string n_ = context.Operators.Convert<string>(m_);
		bool? o_ = context.Operators.Equal(n_, "female");
		bool? p_ = context.Operators.And(j_, o_);
		IEnumerable<Encounter> q_ = this.Qualifying_Encounters();
		bool? r_ = context.Operators.Exists<Encounter>(q_);
		bool? s_ = context.Operators.And(p_, r_);
		bool? t_ = this.Has_Assessments_Identifying_Sexual_Activity();
		bool? u_ = this.Has_Diagnoses_Identifying_Sexual_Activity();
		bool? v_ = context.Operators.Or(t_, u_);
		bool? w_ = this.Has_Active_Contraceptive_Medications();
		bool? x_ = context.Operators.Or(v_, w_);
		bool? y_ = this.Has_Ordered_Contraceptive_Medications();
		bool? z_ = context.Operators.Or(x_, y_);
		bool? aa_ = this.Has_Laboratory_Tests_Identifying_Sexual_Activity();
		bool? ab_ = context.Operators.Or(z_, aa_);
		bool? ac_ = this.Has_Diagnostic_Studies_Identifying_Sexual_Activity();
		bool? ad_ = context.Operators.Or(ab_, ac_);
		bool? ae_ = this.Has_Procedures_Identifying_Sexual_Activity();
		bool? af_ = context.Operators.Or(ad_, ae_);
		bool? ag_ = context.Operators.And(s_, af_);

		return ag_;
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

	private bool? Has_Pregnancy_Test_Exclusion_Value()
	{
		CqlValueSet a_ = this.Pregnancy_Test();
		IEnumerable<ServiceRequest> b_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
		IEnumerable<ServiceRequest> c_ = Status_1_6_000.Completed_or_Ongoing_Service_Request(b_);
		IEnumerable<ServiceRequest> d_(ServiceRequest PregnancyTest)
		{
			CqlValueSet m_ = this.XRay_Study();
			IEnumerable<ServiceRequest> n_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, m_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
			IEnumerable<ServiceRequest> o_ = Status_1_6_000.Completed_or_Ongoing_Service_Request(n_);
			bool? p_(ServiceRequest XrayOrder)
			{
				FhirDateTime t_ = XrayOrder?.AuthoredOnElement;
				CqlDateTime u_ = context.Operators.Convert<CqlDateTime>(t_);
				CqlInterval<CqlDateTime> v_ = QICoreCommon_2_0_000.ToInterval(u_ as object);
				CqlDateTime w_ = context.Operators.Start(v_);
				FhirDateTime x_ = PregnancyTest?.AuthoredOnElement;
				CqlDateTime y_ = context.Operators.Convert<CqlDateTime>(x_);
				CqlInterval<CqlDateTime> z_ = QICoreCommon_2_0_000.ToInterval(y_ as object);
				CqlDateTime aa_ = context.Operators.End(z_);
				CqlDateTime ac_ = context.Operators.Convert<CqlDateTime>(x_);
				CqlInterval<CqlDateTime> ad_ = QICoreCommon_2_0_000.ToInterval(ac_ as object);
				CqlDateTime ae_ = context.Operators.End(ad_);
				CqlQuantity af_ = context.Operators.Quantity(6m, "days");
				CqlDateTime ag_ = context.Operators.Add(ae_, af_);
				CqlInterval<CqlDateTime> ah_ = context.Operators.Interval(aa_, ag_, true, true);
				bool? ai_ = context.Operators.In<CqlDateTime>(w_, ah_, "day");
				CqlDateTime ak_ = context.Operators.Convert<CqlDateTime>(x_);
				CqlInterval<CqlDateTime> al_ = QICoreCommon_2_0_000.ToInterval(ak_ as object);
				CqlDateTime am_ = context.Operators.End(al_);
				bool? an_ = context.Operators.Not((bool?)(am_ is null));
				bool? ao_ = context.Operators.And(ai_, an_);
				CqlInterval<CqlDateTime> ap_ = this.Measurement_Period();
				CqlDateTime ar_ = context.Operators.Convert<CqlDateTime>(x_);
				CqlInterval<CqlDateTime> as_ = QICoreCommon_2_0_000.ToInterval(ar_ as object);
				bool? at_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ap_, as_, default);
				bool? au_ = context.Operators.And(ao_, at_);

				return au_;
			};
			IEnumerable<ServiceRequest> q_ = context.Operators.Where<ServiceRequest>(o_, p_);
			ServiceRequest r_(ServiceRequest XrayOrder) => 
				PregnancyTest;
			IEnumerable<ServiceRequest> s_ = context.Operators.Select<ServiceRequest, ServiceRequest>(q_, r_);

			return s_;
		};
		IEnumerable<ServiceRequest> e_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(c_, d_);
		IEnumerable<ServiceRequest> g_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
		IEnumerable<ServiceRequest> h_ = Status_1_6_000.Completed_or_Ongoing_Service_Request(g_);
		IEnumerable<ServiceRequest> i_(ServiceRequest PregnancyTestOrder)
		{
			CqlValueSet av_ = this.Isotretinoin();
			IEnumerable<MedicationRequest> aw_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, av_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
			IEnumerable<MedicationRequest> ay_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, av_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
			IEnumerable<MedicationRequest> az_ = context.Operators.Union<MedicationRequest>(aw_, ay_);
			IEnumerable<MedicationRequest> ba_ = Status_1_6_000.Active_or_Completed_Medication_Request(az_);
			bool? bb_(MedicationRequest AccutaneOrder)
			{
				FhirDateTime bf_ = AccutaneOrder?.AuthoredOnElement;
				CqlDateTime bg_ = context.Operators.Convert<CqlDateTime>(bf_);
				CqlInterval<CqlDateTime> bh_ = QICoreCommon_2_0_000.ToInterval(bg_ as object);
				CqlDateTime bi_ = context.Operators.Start(bh_);
				FhirDateTime bj_ = PregnancyTestOrder?.AuthoredOnElement;
				CqlDateTime bk_ = context.Operators.Convert<CqlDateTime>(bj_);
				CqlInterval<CqlDateTime> bl_ = QICoreCommon_2_0_000.ToInterval(bk_ as object);
				CqlDateTime bm_ = context.Operators.End(bl_);
				CqlDateTime bo_ = context.Operators.Convert<CqlDateTime>(bj_);
				CqlInterval<CqlDateTime> bp_ = QICoreCommon_2_0_000.ToInterval(bo_ as object);
				CqlDateTime bq_ = context.Operators.End(bp_);
				CqlQuantity br_ = context.Operators.Quantity(6m, "days");
				CqlDateTime bs_ = context.Operators.Add(bq_, br_);
				CqlInterval<CqlDateTime> bt_ = context.Operators.Interval(bm_, bs_, true, true);
				bool? bu_ = context.Operators.In<CqlDateTime>(bi_, bt_, "day");
				CqlDateTime bw_ = context.Operators.Convert<CqlDateTime>(bj_);
				CqlInterval<CqlDateTime> bx_ = QICoreCommon_2_0_000.ToInterval(bw_ as object);
				CqlDateTime by_ = context.Operators.End(bx_);
				bool? bz_ = context.Operators.Not((bool?)(by_ is null));
				bool? ca_ = context.Operators.And(bu_, bz_);
				CqlInterval<CqlDateTime> cb_ = this.Measurement_Period();
				CqlDateTime cd_ = context.Operators.Convert<CqlDateTime>(bj_);
				CqlInterval<CqlDateTime> ce_ = QICoreCommon_2_0_000.ToInterval(cd_ as object);
				bool? cf_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(cb_, ce_, default);
				bool? cg_ = context.Operators.And(ca_, cf_);

				return cg_;
			};
			IEnumerable<MedicationRequest> bc_ = context.Operators.Where<MedicationRequest>(ba_, bb_);
			ServiceRequest bd_(MedicationRequest AccutaneOrder) => 
				PregnancyTestOrder;
			IEnumerable<ServiceRequest> be_ = context.Operators.Select<MedicationRequest, ServiceRequest>(bc_, bd_);

			return be_;
		};
		IEnumerable<ServiceRequest> j_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(h_, i_);
		IEnumerable<ServiceRequest> k_ = context.Operators.Union<ServiceRequest>(e_, j_);
		bool? l_ = context.Operators.Exists<ServiceRequest>(k_);

		return l_;
	}

    [CqlDeclaration("Has Pregnancy Test Exclusion")]
	public bool? Has_Pregnancy_Test_Exclusion() => 
		__Has_Pregnancy_Test_Exclusion.Value;

	private bool? Denominator_Exclusions_Value()
	{
		bool? a_ = Hospice_6_9_000.Has_Hospice_Services();
		bool? b_ = this.Has_Pregnancy_Test_Exclusion();
		bool? c_ = this.Has_Assessments_Identifying_Sexual_Activity();
		bool? d_ = context.Operators.Not(c_);
		bool? e_ = context.Operators.And(b_, d_);
		bool? f_ = this.Has_Diagnoses_Identifying_Sexual_Activity();
		bool? g_ = context.Operators.Not(f_);
		bool? h_ = context.Operators.And(e_, g_);
		bool? i_ = this.Has_Active_Contraceptive_Medications();
		bool? j_ = context.Operators.Not(i_);
		bool? k_ = context.Operators.And(h_, j_);
		bool? l_ = this.Has_Ordered_Contraceptive_Medications();
		bool? m_ = context.Operators.Not(l_);
		bool? n_ = context.Operators.And(k_, m_);
		bool? o_ = this.Has_Laboratory_Tests_Identifying_Sexual_Activity_But_Not_Pregnancy();
		bool? p_ = context.Operators.Not(o_);
		bool? q_ = context.Operators.And(n_, p_);
		bool? r_ = this.Has_Diagnostic_Studies_Identifying_Sexual_Activity();
		bool? s_ = context.Operators.Not(r_);
		bool? t_ = context.Operators.And(q_, s_);
		bool? u_ = this.Has_Procedures_Identifying_Sexual_Activity();
		bool? v_ = context.Operators.Not(u_);
		bool? w_ = context.Operators.And(t_, v_);
		bool? x_ = context.Operators.Or(a_, w_);

		return x_;
	}

    [CqlDeclaration("Denominator Exclusions")]
	public bool? Denominator_Exclusions() => 
		__Denominator_Exclusions.Value;

	private bool? Numerator_Value()
	{
		CqlValueSet a_ = this.Chlamydia_Screening();
		IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
		IEnumerable<Observation> c_ = Status_1_6_000.Final_Lab_Observation(b_);
		bool? d_(Observation ChlamydiaTest)
		{
			object g_()
			{
				bool o_()
				{
					DataType r_ = ChlamydiaTest?.Effective;
					object s_ = FHIRHelpers_4_3_000.ToValue(r_);
					bool t_ = s_ is CqlDateTime;

					return t_;
				};
				bool p_()
				{
					DataType u_ = ChlamydiaTest?.Effective;
					object v_ = FHIRHelpers_4_3_000.ToValue(u_);
					bool w_ = v_ is CqlInterval<CqlDateTime>;

					return w_;
				};
				bool q_()
				{
					DataType x_ = ChlamydiaTest?.Effective;
					object y_ = FHIRHelpers_4_3_000.ToValue(x_);
					bool z_ = y_ is CqlDateTime;

					return z_;
				};
				if (o_())
				{
					DataType aa_ = ChlamydiaTest?.Effective;
					object ab_ = FHIRHelpers_4_3_000.ToValue(aa_);

					return (ab_ as CqlDateTime) as object;
				}
				else if (p_())
				{
					DataType ac_ = ChlamydiaTest?.Effective;
					object ad_ = FHIRHelpers_4_3_000.ToValue(ac_);

					return (ad_ as CqlInterval<CqlDateTime>) as object;
				}
				else if (q_())
				{
					DataType ae_ = ChlamydiaTest?.Effective;
					object af_ = FHIRHelpers_4_3_000.ToValue(ae_);

					return (af_ as CqlDateTime) as object;
				}
				else
				{
					return null;
				}
			};
			CqlDateTime h_ = QICoreCommon_2_0_000.Latest(g_());
			CqlInterval<CqlDateTime> i_ = this.Measurement_Period();
			bool? j_ = context.Operators.In<CqlDateTime>(h_, i_, "day");
			DataType k_ = ChlamydiaTest?.Value;
			object l_ = FHIRHelpers_4_3_000.ToValue(k_);
			bool? m_ = context.Operators.Not((bool?)(l_ is null));
			bool? n_ = context.Operators.And(j_, m_);

			return n_;
		};
		IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
		bool? f_ = context.Operators.Exists<Observation>(e_);

		return f_;
	}

    [CqlDeclaration("Numerator")]
	public bool? Numerator() => 
		__Numerator.Value;

	private bool? Stratification_1_Value()
	{
		Patient a_ = this.Patient();
		Date b_ = a_?.BirthDateElement;
		string c_ = b_?.Value;
		CqlDate d_ = context.Operators.ConvertStringToDate(c_);
		CqlInterval<CqlDateTime> e_ = this.Measurement_Period();
		CqlDateTime f_ = context.Operators.End(e_);
		CqlDate g_ = context.Operators.DateFrom(f_);
		int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
		CqlInterval<int?> i_ = context.Operators.Interval(16, 20, true, true);
		bool? j_ = context.Operators.In<int?>(h_, i_, default);

		return j_;
	}

    [CqlDeclaration("Stratification 1")]
	public bool? Stratification_1() => 
		__Stratification_1.Value;

	private bool? Stratification_2_Value()
	{
		Patient a_ = this.Patient();
		Date b_ = a_?.BirthDateElement;
		string c_ = b_?.Value;
		CqlDate d_ = context.Operators.ConvertStringToDate(c_);
		CqlInterval<CqlDateTime> e_ = this.Measurement_Period();
		CqlDateTime f_ = context.Operators.End(e_);
		CqlDate g_ = context.Operators.DateFrom(f_);
		int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
		CqlInterval<int?> i_ = context.Operators.Interval(21, 24, true, true);
		bool? j_ = context.Operators.In<int?>(h_, i_, default);

		return j_;
	}

    [CqlDeclaration("Stratification 2")]
	public bool? Stratification_2() => 
		__Stratification_2.Value;

}
