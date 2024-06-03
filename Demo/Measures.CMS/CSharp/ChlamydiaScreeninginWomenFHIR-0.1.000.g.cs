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
    internal Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ>> __SDE_Payer;
    internal Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR> __SDE_Race;
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
        __SDE_Ethnicity = new Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR>(this.SDE_Race_Value);
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
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1052", null);

    [CqlDeclaration("Chlamydia Screening")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1052")]
	public CqlValueSet Chlamydia_Screening() => 
		__Chlamydia_Screening.Value;

	private CqlValueSet Complications_of_Pregnancy__Childbirth_and_the_Puerperium_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1012", null);

    [CqlDeclaration("Complications of Pregnancy, Childbirth and the Puerperium")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1012")]
	public CqlValueSet Complications_of_Pregnancy__Childbirth_and_the_Puerperium() => 
		__Complications_of_Pregnancy__Childbirth_and_the_Puerperium.Value;

	private CqlValueSet Contraceptive_Medications_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1080", null);

    [CqlDeclaration("Contraceptive Medications")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1080")]
	public CqlValueSet Contraceptive_Medications() => 
		__Contraceptive_Medications.Value;

	private CqlValueSet Diagnoses_Used_to_Indicate_Sexual_Activity_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1018", null);

    [CqlDeclaration("Diagnoses Used to Indicate Sexual Activity")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1018")]
	public CqlValueSet Diagnoses_Used_to_Indicate_Sexual_Activity() => 
		__Diagnoses_Used_to_Indicate_Sexual_Activity.Value;

	private CqlValueSet Diagnostic_Studies_During_Pregnancy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1008", null);

    [CqlDeclaration("Diagnostic Studies During Pregnancy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1008")]
	public CqlValueSet Diagnostic_Studies_During_Pregnancy() => 
		__Diagnostic_Studies_During_Pregnancy.Value;

	private CqlValueSet HIV_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003", null);

    [CqlDeclaration("HIV")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003")]
	public CqlValueSet HIV() => 
		__HIV.Value;

	private CqlValueSet Home_Healthcare_Services_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);

    [CqlDeclaration("Home Healthcare Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016")]
	public CqlValueSet Home_Healthcare_Services() => 
		__Home_Healthcare_Services.Value;

	private CqlValueSet Isotretinoin_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1143", null);

    [CqlDeclaration("Isotretinoin")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1143")]
	public CqlValueSet Isotretinoin() => 
		__Isotretinoin.Value;

	private CqlValueSet Lab_Tests_During_Pregnancy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1007", null);

    [CqlDeclaration("Lab Tests During Pregnancy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1007")]
	public CqlValueSet Lab_Tests_During_Pregnancy() => 
		__Lab_Tests_During_Pregnancy.Value;

	private CqlValueSet Lab_Tests_for_Sexually_Transmitted_Infections_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1051", null);

    [CqlDeclaration("Lab Tests for Sexually Transmitted Infections")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1051")]
	public CqlValueSet Lab_Tests_for_Sexually_Transmitted_Infections() => 
		__Lab_Tests_for_Sexually_Transmitted_Infections.Value;

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

	private CqlValueSet Pap_Test_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1017", null);

    [CqlDeclaration("Pap Test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1017")]
	public CqlValueSet Pap_Test() => 
		__Pap_Test.Value;

	private CqlValueSet Pregnancy_Test_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1011", null);

    [CqlDeclaration("Pregnancy Test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1011")]
	public CqlValueSet Pregnancy_Test() => 
		__Pregnancy_Test.Value;

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

	private CqlValueSet Preventive_Care_Services__Initial_Office_Visit__0_to_17_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", null);

    [CqlDeclaration("Preventive Care Services, Initial Office Visit, 0 to 17")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022")]
	public CqlValueSet Preventive_Care_Services__Initial_Office_Visit__0_to_17() => 
		__Preventive_Care_Services__Initial_Office_Visit__0_to_17.Value;

	private CqlValueSet Preventive_Care__Established_Office_Visit__0_to_17_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", null);

    [CqlDeclaration("Preventive Care, Established Office Visit, 0 to 17")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024")]
	public CqlValueSet Preventive_Care__Established_Office_Visit__0_to_17() => 
		__Preventive_Care__Established_Office_Visit__0_to_17.Value;

	private CqlValueSet Procedures_Used_to_Indicate_Sexual_Activity_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1017", null);

    [CqlDeclaration("Procedures Used to Indicate Sexual Activity")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1017")]
	public CqlValueSet Procedures_Used_to_Indicate_Sexual_Activity() => 
		__Procedures_Used_to_Indicate_Sexual_Activity.Value;

	private CqlValueSet Telephone_Visits_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
	public CqlValueSet Telephone_Visits() => 
		__Telephone_Visits.Value;

	private CqlValueSet XRay_Study_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1034", null);

    [CqlDeclaration("XRay Study")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1034")]
	public CqlValueSet XRay_Study() => 
		__XRay_Study.Value;

	private CqlCode Female_Value() => 
		new CqlCode("F", "http://terminology.hl7.org/CodeSystem/v3-AdministrativeGender", null, null);

    [CqlDeclaration("Female")]
	public CqlCode Female() => 
		__Female.Value;

	private CqlCode Have_you_ever_had_vaginal_intercourse__PhenX__Value() => 
		new CqlCode("64728-9", "http://loinc.org", null, null);

    [CqlDeclaration("Have you ever had vaginal intercourse [PhenX]")]
	public CqlCode Have_you_ever_had_vaginal_intercourse__PhenX_() => 
		__Have_you_ever_had_vaginal_intercourse__PhenX_.Value;

	private CqlCode Yes__qualifier_value__Value() => 
		new CqlCode("373066001", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Yes (qualifier value)")]
	public CqlCode Yes__qualifier_value_() => 
		__Yes__qualifier_value_.Value;

	private CqlCode[] AdministrativeGender_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("F", "http://terminology.hl7.org/CodeSystem/v3-AdministrativeGender", null, null),
		};

		return a_;
	}

    [CqlDeclaration("AdministrativeGender")]
	public CqlCode[] AdministrativeGender() => 
		__AdministrativeGender.Value;

	private CqlCode[] LOINC_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("64728-9", "http://loinc.org", null, null),
		};

		return a_;
	}

    [CqlDeclaration("LOINC")]
	public CqlCode[] LOINC() => 
		__LOINC.Value;

	private CqlCode[] SNOMEDCT_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("373066001", "http://snomed.info/sct", null, null),
		};

		return a_;
	}

    [CqlDeclaration("SNOMEDCT")]
	public CqlCode[] SNOMEDCT() => 
		__SNOMEDCT.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		var b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		var c_ = context.Operators.Interval(a_, b_, true, false);
		var d_ = context.ResolveParameter("ChlamydiaScreeninginWomenFHIR-0.1.000", "Measurement Period", c_);

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

	private IEnumerable<Encounter> Qualifying_Encounters_Value()
	{
		var a_ = this.Office_Visit();
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		var c_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up();
		var d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, null);
		var e_ = context.Operators.Union<Encounter>(b_, d_);
		var f_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up();
		var g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, null);
		var h_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17();
		var i_ = context.Operators.RetrieveByValueSet<Encounter>(h_, null);
		var j_ = context.Operators.Union<Encounter>(g_, i_);
		var k_ = context.Operators.Union<Encounter>(e_, j_);
		var l_ = this.Preventive_Care__Established_Office_Visit__0_to_17();
		var m_ = context.Operators.RetrieveByValueSet<Encounter>(l_, null);
		var n_ = this.Home_Healthcare_Services();
		var o_ = context.Operators.RetrieveByValueSet<Encounter>(n_, null);
		var p_ = context.Operators.Union<Encounter>(m_, o_);
		var q_ = context.Operators.Union<Encounter>(k_, p_);
		var r_ = this.Telephone_Visits();
		var s_ = context.Operators.RetrieveByValueSet<Encounter>(r_, null);
		var t_ = this.Online_Assessments();
		var u_ = context.Operators.RetrieveByValueSet<Encounter>(t_, null);
		var v_ = context.Operators.Union<Encounter>(s_, u_);
		var w_ = context.Operators.Union<Encounter>(q_, v_);
		var x_ = Status_1_6_000.Finished_Encounter(w_);
		bool? y_(Encounter ValidEncounters)
		{
			var aa_ = this.Measurement_Period();
			var ab_ = ValidEncounters?.Period;
			var ac_ = FHIRHelpers_4_3_000.ToInterval(ab_);
			var ad_ = QICoreCommon_2_0_000.ToInterval((ac_ as object));
			var ae_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(aa_, ad_, "day");

			return ae_;
		};
		var z_ = context.Operators.Where<Encounter>(x_, y_);

		return z_;
	}

    [CqlDeclaration("Qualifying Encounters")]
	public IEnumerable<Encounter> Qualifying_Encounters() => 
		__Qualifying_Encounters.Value;

	private bool? Has_Assessments_Identifying_Sexual_Activity_Value()
	{
		var a_ = this.Have_you_ever_had_vaginal_intercourse__PhenX_();
		var b_ = context.Operators.ToList<CqlCode>(a_);
		var c_ = context.Operators.RetrieveByCodes<Observation>(b_, null);
		var d_ = Status_1_6_000.Final_Survey_Observation(c_);
		bool? e_(Observation SexualActivityAssessment)
		{
			var h_ = SexualActivityAssessment?.Value;
			var i_ = FHIRHelpers_4_3_000.ToValue(h_);
			var j_ = this.Yes__qualifier_value_();
			var k_ = context.Operators.ConvertCodeToConcept(j_);
			var l_ = context.Operators.Equivalent((i_ as CqlConcept), k_);
			var m_ = SexualActivityAssessment?.Effective;
			var n_ = FHIRHelpers_4_3_000.ToValue(m_);
			var o_ = QICoreCommon_2_0_000.ToInterval(n_);
			CqlInterval<CqlDateTime> p_()
			{
				bool s_()
				{
					var t_ = this.Measurement_Period();
					var u_ = context.Operators.End(t_);

					return (u_ is null);
				};
				if (s_())
				{
					return null;
				}
				else
				{
					var v_ = this.Measurement_Period();
					var w_ = context.Operators.End(v_);
					var y_ = context.Operators.End(v_);
					var z_ = context.Operators.Interval(w_, y_, true, true);

					return z_;
				}
			};
			var q_ = context.Operators.SameOrBefore(o_, p_(), null);
			var r_ = context.Operators.And(l_, q_);

			return r_;
		};
		var f_ = context.Operators.Where<Observation>(d_, e_);
		var g_ = context.Operators.Exists<Observation>(f_);

		return g_;
	}

    [CqlDeclaration("Has Assessments Identifying Sexual Activity")]
	public bool? Has_Assessments_Identifying_Sexual_Activity() => 
		__Has_Assessments_Identifying_Sexual_Activity.Value;

	private bool? Has_Diagnoses_Identifying_Sexual_Activity_Value()
	{
		var a_ = this.Diagnoses_Used_to_Indicate_Sexual_Activity();
		var b_ = context.Operators.RetrieveByValueSet<Condition>(a_, null);
		var c_ = this.HIV();
		var d_ = context.Operators.RetrieveByValueSet<Condition>(c_, null);
		var e_ = context.Operators.Union<Condition>(b_, d_);
		var f_ = this.Complications_of_Pregnancy__Childbirth_and_the_Puerperium();
		var g_ = context.Operators.RetrieveByValueSet<Condition>(f_, null);
		var h_ = context.Operators.Union<Condition>(e_, g_);
		bool? i_(Condition SexualActivityDiagnosis)
		{
			var l_ = QICoreCommon_2_0_000.ToPrevalenceInterval(SexualActivityDiagnosis);
			var m_ = this.Measurement_Period();
			var n_ = context.Operators.Overlaps(l_, m_, null);

			return n_;
		};
		var j_ = context.Operators.Where<Condition>(h_, i_);
		var k_ = context.Operators.Exists<Condition>(j_);

		return k_;
	}

    [CqlDeclaration("Has Diagnoses Identifying Sexual Activity")]
	public bool? Has_Diagnoses_Identifying_Sexual_Activity() => 
		__Has_Diagnoses_Identifying_Sexual_Activity.Value;

	private bool? Has_Active_Contraceptive_Medications_Value()
	{
		var a_ = this.Contraceptive_Medications();
		var b_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		var d_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		var e_ = context.Operators.Union<MedicationRequest>(b_, d_);
		var f_ = Status_1_6_000.Active_Medication(e_);
		bool? g_(MedicationRequest ActiveContraceptives)
		{
			var j_ = CumulativeMedicationDuration_4_0_000.MedicationRequestPeriod(ActiveContraceptives);
			var k_ = j_?.low;
			var l_ = context.Operators.ConvertDateToDateTime(k_);
			var n_ = j_?.high;
			var o_ = context.Operators.ConvertDateToDateTime(n_);
			var q_ = j_?.lowClosed;
			var s_ = j_?.highClosed;
			var t_ = context.Operators.Interval(l_, o_, q_, s_);
			var u_ = this.Measurement_Period();
			var v_ = context.Operators.Overlaps(t_, u_, null);

			return v_;
		};
		var h_ = context.Operators.Where<MedicationRequest>(f_, g_);
		var i_ = context.Operators.Exists<MedicationRequest>(h_);

		return i_;
	}

    [CqlDeclaration("Has Active Contraceptive Medications")]
	public bool? Has_Active_Contraceptive_Medications() => 
		__Has_Active_Contraceptive_Medications.Value;

	private bool? Has_Ordered_Contraceptive_Medications_Value()
	{
		var a_ = this.Contraceptive_Medications();
		var b_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		var d_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		var e_ = context.Operators.Union<MedicationRequest>(b_, d_);
		var f_ = Status_1_6_000.Active_or_Completed_Medication_Request(e_);
		bool? g_(MedicationRequest OrderedContraceptives)
		{
			var j_ = this.Measurement_Period();
			var k_ = OrderedContraceptives?.AuthoredOnElement;
			var l_ = context.Operators.Convert<CqlDateTime>(k_);
			var m_ = QICoreCommon_2_0_000.ToInterval((l_ as object));
			var n_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(j_, m_, "day");

			return n_;
		};
		var h_ = context.Operators.Where<MedicationRequest>(f_, g_);
		var i_ = context.Operators.Exists<MedicationRequest>(h_);

		return i_;
	}

    [CqlDeclaration("Has Ordered Contraceptive Medications")]
	public bool? Has_Ordered_Contraceptive_Medications() => 
		__Has_Ordered_Contraceptive_Medications.Value;

	private bool? Has_Laboratory_Tests_Identifying_Sexual_Activity_But_Not_Pregnancy_Value()
	{
		var a_ = this.Pap_Test();
		var b_ = context.Operators.RetrieveByValueSet<ServiceRequest>(a_, null);
		var c_ = this.Lab_Tests_During_Pregnancy();
		var d_ = context.Operators.RetrieveByValueSet<ServiceRequest>(c_, null);
		var e_ = context.Operators.Union<ServiceRequest>(b_, d_);
		var f_ = this.Lab_Tests_for_Sexually_Transmitted_Infections();
		var g_ = context.Operators.RetrieveByValueSet<ServiceRequest>(f_, null);
		var h_ = context.Operators.Union<ServiceRequest>(e_, g_);
		var i_ = Status_1_6_000.Completed_or_Ongoing_Service_Request(h_);
		bool? j_(ServiceRequest LabOrders)
		{
			var m_ = this.Measurement_Period();
			var n_ = LabOrders?.AuthoredOnElement;
			var o_ = context.Operators.Convert<CqlDateTime>(n_);
			var p_ = QICoreCommon_2_0_000.ToInterval((o_ as object));
			var q_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(m_, p_, "day");

			return q_;
		};
		var k_ = context.Operators.Where<ServiceRequest>(i_, j_);
		var l_ = context.Operators.Exists<ServiceRequest>(k_);

		return l_;
	}

    [CqlDeclaration("Has Laboratory Tests Identifying Sexual Activity But Not Pregnancy")]
	public bool? Has_Laboratory_Tests_Identifying_Sexual_Activity_But_Not_Pregnancy() => 
		__Has_Laboratory_Tests_Identifying_Sexual_Activity_But_Not_Pregnancy.Value;

	private bool? Has_Laboratory_Tests_Identifying_Sexual_Activity_Value()
	{
		var a_ = this.Pregnancy_Test();
		var b_ = context.Operators.RetrieveByValueSet<ServiceRequest>(a_, null);
		var c_ = Status_1_6_000.Completed_or_Ongoing_Service_Request(b_);
		bool? d_(ServiceRequest PregnancyTest)
		{
			var i_ = this.Measurement_Period();
			var j_ = PregnancyTest?.AuthoredOnElement;
			var k_ = context.Operators.Convert<CqlDateTime>(j_);
			var l_ = QICoreCommon_2_0_000.ToInterval((k_ as object));
			var m_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(i_, l_, "day");

			return m_;
		};
		var e_ = context.Operators.Where<ServiceRequest>(c_, d_);
		var f_ = context.Operators.Exists<ServiceRequest>(e_);
		var g_ = this.Has_Laboratory_Tests_Identifying_Sexual_Activity_But_Not_Pregnancy();
		var h_ = context.Operators.Or(f_, g_);

		return h_;
	}

    [CqlDeclaration("Has Laboratory Tests Identifying Sexual Activity")]
	public bool? Has_Laboratory_Tests_Identifying_Sexual_Activity() => 
		__Has_Laboratory_Tests_Identifying_Sexual_Activity.Value;

	private bool? Has_Diagnostic_Studies_Identifying_Sexual_Activity_Value()
	{
		var a_ = this.Diagnostic_Studies_During_Pregnancy();
		var b_ = context.Operators.RetrieveByValueSet<ServiceRequest>(a_, null);
		var c_ = Status_1_6_000.Completed_or_Ongoing_Service_Request(b_);
		bool? d_(ServiceRequest SexualActivityDiagnostics)
		{
			var g_ = this.Measurement_Period();
			var h_ = SexualActivityDiagnostics?.AuthoredOnElement;
			var i_ = context.Operators.Convert<CqlDateTime>(h_);
			var j_ = QICoreCommon_2_0_000.ToInterval((i_ as object));
			var k_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(g_, j_, "day");

			return k_;
		};
		var e_ = context.Operators.Where<ServiceRequest>(c_, d_);
		var f_ = context.Operators.Exists<ServiceRequest>(e_);

		return f_;
	}

    [CqlDeclaration("Has Diagnostic Studies Identifying Sexual Activity")]
	public bool? Has_Diagnostic_Studies_Identifying_Sexual_Activity() => 
		__Has_Diagnostic_Studies_Identifying_Sexual_Activity.Value;

	private bool? Has_Procedures_Identifying_Sexual_Activity_Value()
	{
		var a_ = this.Procedures_Used_to_Indicate_Sexual_Activity();
		var b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, null);
		var c_ = Status_1_6_000.Completed_Procedure(b_);
		bool? d_(Procedure ProceduresForSexualActivity)
		{
			var g_ = this.Measurement_Period();
			var h_ = ProceduresForSexualActivity?.Performed;
			var i_ = FHIRHelpers_4_3_000.ToValue(h_);
			var j_ = QICoreCommon_2_0_000.ToInterval(i_);
			var k_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(g_, j_, "day");

			return k_;
		};
		var e_ = context.Operators.Where<Procedure>(c_, d_);
		var f_ = context.Operators.Exists<Procedure>(e_);

		return f_;
	}

    [CqlDeclaration("Has Procedures Identifying Sexual Activity")]
	public bool? Has_Procedures_Identifying_Sexual_Activity() => 
		__Has_Procedures_Identifying_Sexual_Activity.Value;

	private bool? Initial_Population_Value()
	{
		var a_ = this.Patient();
		var b_ = context.Operators.Convert<CqlDate>(a_?.BirthDateElement?.Value);
		var c_ = this.Measurement_Period();
		var d_ = context.Operators.End(c_);
		var e_ = context.Operators.DateFrom(d_);
		var f_ = context.Operators.CalculateAgeAt(b_, e_, "year");
		var g_ = context.Operators.Interval(16, 24, true, true);
		var h_ = context.Operators.In<int?>(f_, g_, null);
		var j_ = context.Operators.Convert<string>(a_?.GenderElement?.Value);
		var k_ = context.Operators.Equal(j_, "female");
		var l_ = context.Operators.And(h_, k_);
		var m_ = this.Qualifying_Encounters();
		var n_ = context.Operators.Exists<Encounter>(m_);
		var o_ = context.Operators.And(l_, n_);
		var p_ = this.Has_Assessments_Identifying_Sexual_Activity();
		var q_ = this.Has_Diagnoses_Identifying_Sexual_Activity();
		var r_ = context.Operators.Or(p_, q_);
		var s_ = this.Has_Active_Contraceptive_Medications();
		var t_ = context.Operators.Or(r_, s_);
		var u_ = this.Has_Ordered_Contraceptive_Medications();
		var v_ = context.Operators.Or(t_, u_);
		var w_ = this.Has_Laboratory_Tests_Identifying_Sexual_Activity();
		var x_ = context.Operators.Or(v_, w_);
		var y_ = this.Has_Diagnostic_Studies_Identifying_Sexual_Activity();
		var z_ = context.Operators.Or(x_, y_);
		var aa_ = this.Has_Procedures_Identifying_Sexual_Activity();
		var ab_ = context.Operators.Or(z_, aa_);
		var ac_ = context.Operators.And(o_, ab_);

		return ac_;
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

	private bool? Has_Pregnancy_Test_Exclusion_Value()
	{
		var a_ = this.Pregnancy_Test();
		var b_ = context.Operators.RetrieveByValueSet<ServiceRequest>(a_, null);
		var c_ = Status_1_6_000.Completed_or_Ongoing_Service_Request(b_);
		IEnumerable<ServiceRequest> d_(ServiceRequest PregnancyTest)
		{
			var m_ = this.XRay_Study();
			var n_ = context.Operators.RetrieveByValueSet<ServiceRequest>(m_, null);
			var o_ = Status_1_6_000.Completed_or_Ongoing_Service_Request(n_);
			bool? p_(ServiceRequest XrayOrder)
			{
				var t_ = XrayOrder?.AuthoredOnElement;
				var u_ = context.Operators.Convert<CqlDateTime>(t_);
				var v_ = QICoreCommon_2_0_000.ToInterval((u_ as object));
				var w_ = context.Operators.Start(v_);
				var x_ = PregnancyTest?.AuthoredOnElement;
				var y_ = context.Operators.Convert<CqlDateTime>(x_);
				var z_ = QICoreCommon_2_0_000.ToInterval((y_ as object));
				var aa_ = context.Operators.End(z_);
				var ac_ = context.Operators.Convert<CqlDateTime>(x_);
				var ad_ = QICoreCommon_2_0_000.ToInterval((ac_ as object));
				var ae_ = context.Operators.End(ad_);
				var af_ = context.Operators.Quantity(6m, "days");
				var ag_ = context.Operators.Add(ae_, af_);
				var ah_ = context.Operators.Interval(aa_, ag_, true, true);
				var ai_ = context.Operators.In<CqlDateTime>(w_, ah_, "day");
				var ak_ = context.Operators.Convert<CqlDateTime>(x_);
				var al_ = QICoreCommon_2_0_000.ToInterval((ak_ as object));
				var am_ = context.Operators.End(al_);
				var an_ = context.Operators.Not((bool?)(am_ is null));
				var ao_ = context.Operators.And(ai_, an_);
				var ap_ = this.Measurement_Period();
				var ar_ = context.Operators.Convert<CqlDateTime>(x_);
				var as_ = QICoreCommon_2_0_000.ToInterval((ar_ as object));
				var at_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ap_, as_, null);
				var au_ = context.Operators.And(ao_, at_);

				return au_;
			};
			var q_ = context.Operators.Where<ServiceRequest>(o_, p_);
			ServiceRequest r_(ServiceRequest XrayOrder) => 
				PregnancyTest;
			var s_ = context.Operators.Select<ServiceRequest, ServiceRequest>(q_, r_);

			return s_;
		};
		var e_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(c_, d_);
		var g_ = context.Operators.RetrieveByValueSet<ServiceRequest>(a_, null);
		var h_ = Status_1_6_000.Completed_or_Ongoing_Service_Request(g_);
		IEnumerable<ServiceRequest> i_(ServiceRequest PregnancyTestOrder)
		{
			var av_ = this.Isotretinoin();
			var aw_ = context.Operators.RetrieveByValueSet<MedicationRequest>(av_, null);
			var ay_ = context.Operators.RetrieveByValueSet<MedicationRequest>(av_, null);
			var az_ = context.Operators.Union<MedicationRequest>(aw_, ay_);
			var ba_ = Status_1_6_000.Active_or_Completed_Medication_Request(az_);
			bool? bb_(MedicationRequest AccutaneOrder)
			{
				var bf_ = AccutaneOrder?.AuthoredOnElement;
				var bg_ = context.Operators.Convert<CqlDateTime>(bf_);
				var bh_ = QICoreCommon_2_0_000.ToInterval((bg_ as object));
				var bi_ = context.Operators.Start(bh_);
				var bj_ = PregnancyTestOrder?.AuthoredOnElement;
				var bk_ = context.Operators.Convert<CqlDateTime>(bj_);
				var bl_ = QICoreCommon_2_0_000.ToInterval((bk_ as object));
				var bm_ = context.Operators.End(bl_);
				var bo_ = context.Operators.Convert<CqlDateTime>(bj_);
				var bp_ = QICoreCommon_2_0_000.ToInterval((bo_ as object));
				var bq_ = context.Operators.End(bp_);
				var br_ = context.Operators.Quantity(6m, "days");
				var bs_ = context.Operators.Add(bq_, br_);
				var bt_ = context.Operators.Interval(bm_, bs_, true, true);
				var bu_ = context.Operators.In<CqlDateTime>(bi_, bt_, "day");
				var bw_ = context.Operators.Convert<CqlDateTime>(bj_);
				var bx_ = QICoreCommon_2_0_000.ToInterval((bw_ as object));
				var by_ = context.Operators.End(bx_);
				var bz_ = context.Operators.Not((bool?)(by_ is null));
				var ca_ = context.Operators.And(bu_, bz_);
				var cb_ = this.Measurement_Period();
				var cd_ = context.Operators.Convert<CqlDateTime>(bj_);
				var ce_ = QICoreCommon_2_0_000.ToInterval((cd_ as object));
				var cf_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(cb_, ce_, null);
				var cg_ = context.Operators.And(ca_, cf_);

				return cg_;
			};
			var bc_ = context.Operators.Where<MedicationRequest>(ba_, bb_);
			ServiceRequest bd_(MedicationRequest AccutaneOrder) => 
				PregnancyTestOrder;
			var be_ = context.Operators.Select<MedicationRequest, ServiceRequest>(bc_, bd_);

			return be_;
		};
		var j_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(h_, i_);
		var k_ = context.Operators.Union<ServiceRequest>(e_, j_);
		var l_ = context.Operators.Exists<ServiceRequest>(k_);

		return l_;
	}

    [CqlDeclaration("Has Pregnancy Test Exclusion")]
	public bool? Has_Pregnancy_Test_Exclusion() => 
		__Has_Pregnancy_Test_Exclusion.Value;

	private bool? Denominator_Exclusions_Value()
	{
		var a_ = Hospice_6_9_000.Has_Hospice_Services();
		var b_ = this.Has_Pregnancy_Test_Exclusion();
		var c_ = this.Has_Assessments_Identifying_Sexual_Activity();
		var d_ = context.Operators.Not(c_);
		var e_ = context.Operators.And(b_, d_);
		var f_ = this.Has_Diagnoses_Identifying_Sexual_Activity();
		var g_ = context.Operators.Not(f_);
		var h_ = context.Operators.And(e_, g_);
		var i_ = this.Has_Active_Contraceptive_Medications();
		var j_ = context.Operators.Not(i_);
		var k_ = context.Operators.And(h_, j_);
		var l_ = this.Has_Ordered_Contraceptive_Medications();
		var m_ = context.Operators.Not(l_);
		var n_ = context.Operators.And(k_, m_);
		var o_ = this.Has_Laboratory_Tests_Identifying_Sexual_Activity_But_Not_Pregnancy();
		var p_ = context.Operators.Not(o_);
		var q_ = context.Operators.And(n_, p_);
		var r_ = this.Has_Diagnostic_Studies_Identifying_Sexual_Activity();
		var s_ = context.Operators.Not(r_);
		var t_ = context.Operators.And(q_, s_);
		var u_ = this.Has_Procedures_Identifying_Sexual_Activity();
		var v_ = context.Operators.Not(u_);
		var w_ = context.Operators.And(t_, v_);
		var x_ = context.Operators.Or(a_, w_);

		return x_;
	}

    [CqlDeclaration("Denominator Exclusions")]
	public bool? Denominator_Exclusions() => 
		__Denominator_Exclusions.Value;

	private bool? Numerator_Value()
	{
		var a_ = this.Chlamydia_Screening();
		var b_ = context.Operators.RetrieveByValueSet<Observation>(a_, null);
		var c_ = Status_1_6_000.Final_Lab_Observation(b_);
		bool? d_(Observation ChlamydiaTest)
		{
			object g_()
			{
				bool o_()
				{
					var r_ = ChlamydiaTest?.Effective;
					var s_ = FHIRHelpers_4_3_000.ToValue(r_);
					var t_ = s_ is CqlDateTime;

					return t_;
				};
				bool p_()
				{
					var u_ = ChlamydiaTest?.Effective;
					var v_ = FHIRHelpers_4_3_000.ToValue(u_);
					var w_ = v_ is CqlInterval<CqlDateTime>;

					return w_;
				};
				bool q_()
				{
					var x_ = ChlamydiaTest?.Effective;
					var y_ = FHIRHelpers_4_3_000.ToValue(x_);
					var z_ = y_ is CqlDateTime;

					return z_;
				};
				if (o_())
				{
					var aa_ = ChlamydiaTest?.Effective;
					var ab_ = FHIRHelpers_4_3_000.ToValue(aa_);

					return ((ab_ as CqlDateTime) as object);
				}
				else if (p_())
				{
					var ac_ = ChlamydiaTest?.Effective;
					var ad_ = FHIRHelpers_4_3_000.ToValue(ac_);

					return ((ad_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (q_())
				{
					var ae_ = ChlamydiaTest?.Effective;
					var af_ = FHIRHelpers_4_3_000.ToValue(ae_);

					return ((af_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				}
			};
			var h_ = QICoreCommon_2_0_000.Latest(g_());
			var i_ = this.Measurement_Period();
			var j_ = context.Operators.In<CqlDateTime>(h_, i_, "day");
			var k_ = ChlamydiaTest?.Value;
			var l_ = FHIRHelpers_4_3_000.ToValue(k_);
			var m_ = context.Operators.Not((bool?)(l_ is null));
			var n_ = context.Operators.And(j_, m_);

			return n_;
		};
		var e_ = context.Operators.Where<Observation>(c_, d_);
		var f_ = context.Operators.Exists<Observation>(e_);

		return f_;
	}

    [CqlDeclaration("Numerator")]
	public bool? Numerator() => 
		__Numerator.Value;

	private bool? Stratification_1_Value()
	{
		var a_ = this.Patient();
		var b_ = context.Operators.Convert<CqlDate>(a_?.BirthDateElement?.Value);
		var c_ = this.Measurement_Period();
		var d_ = context.Operators.End(c_);
		var e_ = context.Operators.DateFrom(d_);
		var f_ = context.Operators.CalculateAgeAt(b_, e_, "year");
		var g_ = context.Operators.Interval(16, 20, true, true);
		var h_ = context.Operators.In<int?>(f_, g_, null);

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
		var d_ = context.Operators.End(c_);
		var e_ = context.Operators.DateFrom(d_);
		var f_ = context.Operators.CalculateAgeAt(b_, e_, "year");
		var g_ = context.Operators.Interval(21, 24, true, true);
		var h_ = context.Operators.In<int?>(f_, g_, null);

		return h_;
	}

    [CqlDeclaration("Stratification 2")]
	public bool? Stratification_2() => 
		__Stratification_2.Value;

}
