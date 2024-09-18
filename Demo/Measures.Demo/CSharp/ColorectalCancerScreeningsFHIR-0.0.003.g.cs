using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;

#pragma warning disable CS9113 // Parameter is unread.

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.3.0")]
public static partial class ColorectalCancerScreeningsFHIR_0_0_003ServiceCollectionExtensions
{
    public static IServiceCollection AddColorectalCancerScreeningsFHIR_0_0_003(this IServiceCollection services)
    {
        services.TryAddSingleton<ColorectalCancerScreeningsFHIR_0_0_003>();
        services.AddFHIRHelpers_4_0_001();
        services.AddSupplementalDataElementsFHIR4_2_0_000();
        services.AddMATGlobalCommonFunctionsFHIR4_6_1_000();
        services.AddAdultOutpatientEncountersFHIR4_2_2_000();
        services.AddHospiceFHIR4_2_3_000();
        services.AddAdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000();
        services.AddPalliativeCareFHIR_0_6_000();
        services.AddCumulativeMedicationDurationFHIR4_1_0_000();
        return services;
    }
}

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.3.0")]
[CqlLibrary("ColorectalCancerScreeningsFHIR", "0.0.003")]
public partial class ColorectalCancerScreeningsFHIR_0_0_003(
    FHIRHelpers_4_0_001 fhirHelpers_4_0_001,
    SupplementalDataElementsFHIR4_2_0_000 supplementalDataElementsFHIR4_2_0_000,
    MATGlobalCommonFunctionsFHIR4_6_1_000 matGlobalCommonFunctionsFHIR4_6_1_000,
    AdultOutpatientEncountersFHIR4_2_2_000 adultOutpatientEncountersFHIR4_2_2_000,
    HospiceFHIR4_2_3_000 hospiceFHIR4_2_3_000,
    AdvancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000 advancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000,
    PalliativeCareFHIR_0_6_000 palliativeCareFHIR_0_6_000,
    CumulativeMedicationDurationFHIR4_1_0_000 cumulativeMedicationDurationFHIR4_1_0_000)
{

    [CqlDeclaration("Acute Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1083")]
	public  CqlValueSet Acute_Inpatient(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1083", default);

    [CqlDeclaration("Advanced Illness")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1082")]
	public  CqlValueSet Advanced_Illness(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1082", default);

    [CqlDeclaration("Annual Wellness Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240")]
	public  CqlValueSet Annual_Wellness_Visit(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", default);

    [CqlDeclaration("Care Services in Long-Term Residential Facility")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014")]
	public  CqlValueSet Care_Services_in_Long_Term_Residential_Facility(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014", default);

    [CqlDeclaration("Colonoscopy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1020")]
	public  CqlValueSet Colonoscopy(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1020", default);

    [CqlDeclaration("CT Colonography")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1038")]
	public  CqlValueSet CT_Colonography(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1038", default);

    [CqlDeclaration("Dementia Medications")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1510")]
	public  CqlValueSet Dementia_Medications(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1510", default);

    [CqlDeclaration("Discharged to Health Care Facility for Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207")]
	public  CqlValueSet Discharged_to_Health_Care_Facility_for_Hospice_Care(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207", default);

    [CqlDeclaration("Discharged to Home for Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209")]
	public  CqlValueSet Discharged_to_Home_for_Hospice_Care(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209", default);

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
	public  CqlValueSet Encounter_Inpatient(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", default);

    [CqlDeclaration("Fecal Occult Blood Test (FOBT)")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1011")]
	public  CqlValueSet Fecal_Occult_Blood_Test__FOBT_(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1011", default);

    [CqlDeclaration("FIT DNA")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1039")]
	public  CqlValueSet FIT_DNA(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1039", default);

    [CqlDeclaration("Flexible Sigmoidoscopy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1010")]
	public  CqlValueSet Flexible_Sigmoidoscopy(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1010", default);

    [CqlDeclaration("Frailty Device")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.118.12.1300")]
	public  CqlValueSet Frailty_Device(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.118.12.1300", default);

    [CqlDeclaration("Frailty Diagnosis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1074")]
	public  CqlValueSet Frailty_Diagnosis(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1074", default);

    [CqlDeclaration("Frailty Encounter")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1088")]
	public  CqlValueSet Frailty_Encounter(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1088", default);

    [CqlDeclaration("Frailty Symptom")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1075")]
	public  CqlValueSet Frailty_Symptom(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1075", default);

    [CqlDeclaration("Home Healthcare Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016")]
	public  CqlValueSet Home_Healthcare_Services(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", default);

    [CqlDeclaration("Hospice care ambulatory")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15")]
	public  CqlValueSet Hospice_care_ambulatory(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15", default);

    [CqlDeclaration("Malignant Neoplasm of Colon")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1001")]
	public  CqlValueSet Malignant_Neoplasm_of_Colon(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1001", default);

    [CqlDeclaration("Nonacute Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1084")]
	public  CqlValueSet Nonacute_Inpatient(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1084", default);

    [CqlDeclaration("Nursing Facility Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012")]
	public  CqlValueSet Nursing_Facility_Visit(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012", default);

    [CqlDeclaration("Observation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1086")]
	public  CqlValueSet Observation(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1086", default);

    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
	public  CqlValueSet Office_Visit(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", default);

    [CqlDeclaration("Online Assessments")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089")]
	public  CqlValueSet Online_Assessments(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089", default);

    [CqlDeclaration("Outpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1087")]
	public  CqlValueSet Outpatient(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1087", default);

    [CqlDeclaration("Preventive Care Services - Established Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025")]
	public  CqlValueSet Preventive_Care_Services___Established_Office_Visit__18_and_Up(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", default);

    [CqlDeclaration("Preventive Care Services-Initial Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023")]
	public  CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", default);

    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
	public  CqlValueSet Telephone_Visits(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", default);

    [CqlDeclaration("Total Colectomy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1019")]
	public  CqlValueSet Total_Colectomy(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1019", default);

    [CqlDeclaration("Total Colectomy ICD9")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.11.1136")]
	public  CqlValueSet Total_Colectomy_ICD9(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.11.1136", default);

    [CqlDeclaration("laboratory")]
	public  CqlCode laboratory(CqlContext context) => 
		new CqlCode("laboratory", "http://terminology.hl7.org/CodeSystem/observation-category", default, default);

    [CqlDeclaration("ObservationCategoryCodes")]
	public  CqlCode[] ObservationCategoryCodes(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("laboratory", "http://terminology.hl7.org/CodeSystem/observation-category", default, default),
		];

		return a_;
	}

    [CqlDeclaration("Measurement Period")]
	public  CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
	{
		CqlDateTime a_ = context.Operators.DateTime(2021, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2022, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("ColorectalCancerScreeningsFHIR-0.0.003", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
	}

    [CqlDeclaration("Patient")]
	public  Patient Patient(CqlContext context)
	{
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(default, default);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public  IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
	{
		IEnumerable<Coding> a_ = supplementalDataElementsFHIR4_2_0_000.SDE_Ethnicity(context);

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public  IEnumerable<(CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
	{
		IEnumerable<(CodeableConcept code, Period period)?> a_ = supplementalDataElementsFHIR4_2_0_000.SDE_Payer(context);

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public  IEnumerable<Coding> SDE_Race(CqlContext context)
	{
		IEnumerable<Coding> a_ = supplementalDataElementsFHIR4_2_0_000.SDE_Race(context);

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
	public  CqlCode SDE_Sex(CqlContext context)
	{
		CqlCode a_ = supplementalDataElementsFHIR4_2_0_000.SDE_Sex(context);

		return a_;
	}

    [CqlDeclaration("Telehealth Services")]
	public  IEnumerable<Encounter> Telehealth_Services(CqlContext context)
	{
		CqlValueSet a_ = this.Online_Assessments(context);
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, default);
		CqlValueSet c_ = this.Telephone_Visits(context);
		IEnumerable<Encounter> d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, default);
		IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
		bool? f_(Encounter TelehealthEncounter)
		{
			Code<Encounter.EncounterStatus> h_ = TelehealthEncounter?.StatusElement;
			string i_ = fhirHelpers_4_0_001.ToString(context, h_);
			bool? j_ = context.Operators.Equal(i_, "finished");
			CqlInterval<CqlDateTime> k_ = this.Measurement_Period(context);
			Period l_ = TelehealthEncounter?.Period;
			CqlInterval<CqlDateTime> m_ = matGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(context, l_ as object);
			bool? n_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(k_, m_, default);
			bool? o_ = context.Operators.And(j_, n_);

			return o_;
		};
		IEnumerable<Encounter> g_ = context.Operators.Where<Encounter>(e_, f_);

		return g_;
	}

    [CqlDeclaration("Age at start of Measurement Period")]
	public  int? Age_at_start_of_Measurement_Period(CqlContext context)
	{
		Patient a_ = this.Patient(context);
		Date b_ = a_?.BirthDateElement;
		string c_ = b_?.Value;
		CqlDate d_ = context.Operators.ConvertStringToDate(c_);
		CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
		CqlDateTime f_ = context.Operators.Start(e_);
		CqlDate g_ = context.Operators.DateFrom(f_);
		int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");

		return h_;
	}

    [CqlDeclaration("Initial Population")]
	public  bool? Initial_Population(CqlContext context)
	{
		Patient a_ = this.Patient(context);
		Date b_ = a_?.BirthDateElement;
		string c_ = b_?.Value;
		CqlDate d_ = context.Operators.ConvertStringToDate(c_);
		CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
		CqlDateTime f_ = context.Operators.Start(e_);
		CqlDate g_ = context.Operators.DateFrom(f_);
		int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
		CqlInterval<int?> i_ = context.Operators.Interval(51, 75, true, false);
		bool? j_ = context.Operators.In<int?>(h_, i_, default);
		IEnumerable<Encounter> k_ = adultOutpatientEncountersFHIR4_2_2_000.Qualifying_Encounters(context);
		IEnumerable<Encounter> l_ = this.Telehealth_Services(context);
		IEnumerable<Encounter> m_ = context.Operators.Union<Encounter>(k_, l_);
		bool? n_ = context.Operators.Exists<Encounter>(m_);
		bool? o_ = context.Operators.And(j_, n_);

		return o_;
	}

    [CqlDeclaration("Denominator")]
	public  bool? Denominator(CqlContext context)
	{
		bool? a_ = this.Initial_Population(context);

		return a_;
	}

    [CqlDeclaration("Malignant Neoplasm")]
	public  IEnumerable<Condition> Malignant_Neoplasm(CqlContext context)
	{
		CqlValueSet a_ = this.Malignant_Neoplasm_of_Colon(context);
		IEnumerable<Condition> b_ = context.Operators.RetrieveByValueSet<Condition>(a_, default);
		bool? c_(Condition ColorectalCancer)
		{
			CqlInterval<CqlDateTime> e_ = matGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(context, ColorectalCancer);
			CqlDateTime f_ = context.Operators.Start(e_);
			CqlInterval<CqlDateTime> g_ = this.Measurement_Period(context);
			CqlDateTime h_ = context.Operators.End(g_);
			bool? i_ = context.Operators.SameOrBefore(f_, h_, default);

			return i_;
		};
		IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Total Colectomy Performed")]
	public  IEnumerable<Procedure> Total_Colectomy_Performed(CqlContext context)
	{
		CqlValueSet a_ = this.Total_Colectomy(context);
		IEnumerable<Procedure> b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, default);
		bool? c_(Procedure Colectomy)
		{
			Code<EventStatus> e_ = Colectomy?.StatusElement;
			string f_ = fhirHelpers_4_0_001.ToString(context, e_);
			bool? g_ = context.Operators.Equal(f_, "completed");
			DataType h_ = Colectomy?.Performed;
			CqlInterval<CqlDateTime> i_ = matGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(context, h_);
			CqlDateTime j_ = context.Operators.End(i_);
			CqlInterval<CqlDateTime> k_ = this.Measurement_Period(context);
			CqlDateTime l_ = context.Operators.End(k_);
			bool? m_ = context.Operators.SameOrBefore(j_, l_, default);
			bool? n_ = context.Operators.And(g_, m_);

			return n_;
		};
		IEnumerable<Procedure> d_ = context.Operators.Where<Procedure>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Total Colectomy Condition")]
	public  IEnumerable<Condition> Total_Colectomy_Condition(CqlContext context)
	{
		CqlValueSet a_ = this.Total_Colectomy_ICD9(context);
		IEnumerable<Condition> b_ = context.Operators.RetrieveByValueSet<Condition>(a_, default);
		bool? c_(Condition ColectomyDx)
		{
			CqlInterval<CqlDateTime> e_ = matGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(context, ColectomyDx);
			CqlDateTime f_ = context.Operators.Start(e_);
			CqlInterval<CqlDateTime> g_ = this.Measurement_Period(context);
			CqlDateTime h_ = context.Operators.End(g_);
			bool? i_ = context.Operators.SameOrBefore(f_, h_, default);

			return i_;
		};
		IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Denominator Exclusions")]
	public  bool? Denominator_Exclusions(CqlContext context)
	{
		bool? a_ = hospiceFHIR4_2_3_000.Has_Hospice(context);
		IEnumerable<Condition> b_ = this.Malignant_Neoplasm(context);
		bool? c_ = context.Operators.Exists<Condition>(b_);
		bool? d_ = context.Operators.Or(a_, c_);
		IEnumerable<Procedure> e_ = this.Total_Colectomy_Performed(context);
		bool? f_ = context.Operators.Exists<Procedure>(e_);
		bool? g_ = context.Operators.Or(d_, f_);
		IEnumerable<Condition> h_ = this.Total_Colectomy_Condition(context);
		bool? i_ = context.Operators.Exists<Condition>(h_);
		bool? j_ = context.Operators.Or(g_, i_);
		bool? k_ = advancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Advanced_Illness_and_Frailty_Exclusion_Not_Including_Over_Age_80(context);
		bool? l_ = context.Operators.Or(j_, k_);
		Patient m_ = this.Patient(context);
		Date n_ = m_?.BirthDateElement;
		string o_ = n_?.Value;
		CqlDate p_ = context.Operators.ConvertStringToDate(o_);
		CqlInterval<CqlDateTime> q_ = this.Measurement_Period(context);
		CqlDateTime r_ = context.Operators.Start(q_);
		CqlDate s_ = context.Operators.DateFrom(r_);
		int? t_ = context.Operators.CalculateAgeAt(p_, s_, "year");
		bool? u_ = context.Operators.GreaterOrEqual(t_, 65);
		bool? v_ = advancedIllnessandFrailtyExclusionECQMFHIR4_5_17_000.Has_Long_Term_Care_Periods_Longer_Than_90_Consecutive_Days(context);
		bool? w_ = context.Operators.And(u_, v_);
		bool? x_ = context.Operators.Or(l_, w_);
		bool? y_ = palliativeCareFHIR_0_6_000.Palliative_Care_in_the_Measurement_Period(context);
		bool? z_ = context.Operators.Or(x_, y_);

		return z_;
	}

    [CqlDeclaration("Fecal Occult Blood Test Display Date, Result, Category, Status")]
	public  IEnumerable<(CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> Fecal_Occult_Blood_Test_Display_Date__Result__Category__Status(CqlContext context)
	{
		CqlValueSet a_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
		IEnumerable<Observation> b_ = context.Operators.RetrieveByValueSet<Observation>(a_, default);
		bool? c_(Observation FecalOccult)
		{
			DataType g_ = FecalOccult?.Effective;
			CqlDateTime h_ = matGlobalCommonFunctionsFHIR4_6_1_000.Latest(context, g_);
			CqlInterval<CqlDateTime> i_ = this.Measurement_Period(context);
			CqlDateTime j_ = context.Operators.Start(i_);
			CqlQuantity k_ = context.Operators.Quantity(1m, "year");
			CqlDateTime l_ = context.Operators.Subtract(j_, k_);
			CqlDateTime n_ = context.Operators.End(i_);
			CqlInterval<CqlDateTime> o_ = context.Operators.Interval(l_, n_, false, false);
			bool? p_ = context.Operators.In<CqlDateTime>(h_, o_, default);

			return p_;
		};
		IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
		(CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)? e_(Observation FecalOccult)
		{
			DataType q_ = FecalOccult?.Effective;
			CqlDateTime r_ = matGlobalCommonFunctionsFHIR4_6_1_000.Latest(context, q_);
			DataType s_ = FecalOccult?.Value;
			IEnumerable<Coding> t_ = context.Operators.LateBoundProperty<IEnumerable<Coding>>(s_, "coding");
			bool? u_(Coding @this)
			{
				FhirString ao_ = @this?.DisplayElement;
				bool? ap_ = context.Operators.Not((bool?)(ao_ is null));

				return ap_;
			};
			IEnumerable<Coding> v_ = context.Operators.Where<Coding>(t_, u_);
			FhirString w_(Coding @this)
			{
				FhirString aq_ = @this?.DisplayElement;

				return aq_;
			};
			IEnumerable<FhirString> x_ = context.Operators.Select<Coding, FhirString>(v_, w_);
			List<CodeableConcept> y_ = FecalOccult?.Category;
			bool? z_(CodeableConcept @this)
			{
				List<Coding> ar_ = @this?.Coding;
				bool? as_ = context.Operators.Not((bool?)(ar_ is null));

				return as_;
			};
			IEnumerable<CodeableConcept> aa_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)y_, z_);
			List<Coding> ab_(CodeableConcept @this)
			{
				List<Coding> at_ = @this?.Coding;

				return at_;
			};
			IEnumerable<List<Coding>> ac_ = context.Operators.Select<CodeableConcept, List<Coding>>(aa_, ab_);
			IEnumerable<Coding> ad_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)ac_);
			bool? ae_(Coding @this)
			{
				Code au_ = @this?.CodeElement;
				bool? av_ = context.Operators.Not((bool?)(au_ is null));

				return av_;
			};
			IEnumerable<Coding> af_ = context.Operators.Where<Coding>(ad_, ae_);
			Code ag_(Coding @this)
			{
				Code aw_ = @this?.CodeElement;

				return aw_;
			};
			IEnumerable<Code> ah_ = context.Operators.Select<Coding, Code>(af_, ag_);
			bool? ai_(Code @this)
			{
				string ax_ = @this?.Value;
				bool? ay_ = context.Operators.Not((bool?)(ax_ is null));

				return ay_;
			};
			IEnumerable<Code> aj_ = context.Operators.Where<Code>(ah_, ai_);
			string ak_(Code @this)
			{
				string az_ = @this?.Value;

				return az_;
			};
			IEnumerable<string> al_ = context.Operators.Select<Code, string>(aj_, ak_);
			Code<ObservationStatus> am_ = FecalOccult?.StatusElement;
			(CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)? an_ = (r_, x_, al_, am_);

			return an_;
		};
		IEnumerable<(CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> f_ = context.Operators.Select<Observation, (CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Fecal Occult Blood Test Performed")]
	public  IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed(CqlContext context)
	{
		CqlValueSet a_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
		IEnumerable<Observation> b_ = context.Operators.RetrieveByValueSet<Observation>(a_, default);
		bool? c_(Observation FecalOccult)
		{
			Code<ObservationStatus> e_ = FecalOccult?.StatusElement;
			string f_ = fhirHelpers_4_0_001.ToString(context, e_);
			string[] g_ = [
				"final",
				"amended",
				"corrected",
			];
			bool? h_ = context.Operators.In<string>(f_, g_ as IEnumerable<string>);
			List<CodeableConcept> i_ = FecalOccult?.Category;
			bool? j_(CodeableConcept FecalOccultCategory)
			{
				List<Coding> v_ = FecalOccultCategory?.Coding;
				bool? w_(Coding @this)
				{
					Code ag_ = @this?.CodeElement;
					bool? ah_ = context.Operators.Not((bool?)(ag_ is null));

					return ah_;
				};
				IEnumerable<Coding> x_ = context.Operators.Where<Coding>((IEnumerable<Coding>)v_, w_);
				Code y_(Coding @this)
				{
					Code ai_ = @this?.CodeElement;

					return ai_;
				};
				IEnumerable<Code> z_ = context.Operators.Select<Coding, Code>(x_, y_);
				bool? aa_(Code @this)
				{
					string aj_ = @this?.Value;
					bool? ak_ = context.Operators.Not((bool?)(aj_ is null));

					return ak_;
				};
				IEnumerable<Code> ab_ = context.Operators.Where<Code>(z_, aa_);
				string ac_(Code @this)
				{
					string al_ = @this?.Value;

					return al_;
				};
				IEnumerable<string> ad_ = context.Operators.Select<Code, string>(ab_, ac_);
				string[] ae_ = [
					"laboratory",
				];
				bool? af_ = context.Operators.Equivalent<string>(ad_, ae_ as IEnumerable<string>);

				return af_;
			};
			IEnumerable<CodeableConcept> k_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)i_, j_);
			bool? l_ = context.Operators.Exists<CodeableConcept>(k_);
			bool? m_ = context.Operators.And(h_, l_);
			DataType n_ = FecalOccult?.Value;
			bool? o_ = context.Operators.Not((bool?)(n_ is null));
			bool? p_ = context.Operators.And(m_, o_);
			DataType q_ = FecalOccult?.Effective;
			CqlDateTime r_ = matGlobalCommonFunctionsFHIR4_6_1_000.Latest(context, q_);
			CqlInterval<CqlDateTime> s_ = this.Measurement_Period(context);
			bool? t_ = context.Operators.In<CqlDateTime>(r_, s_, default);
			bool? u_ = context.Operators.And(p_, t_);

			return u_;
		};
		IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Fecal Occult Blood Test Performed, day of TZoffset")]
	public  IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed__day_of_TZoffset(CqlContext context)
	{
		CqlValueSet a_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
		IEnumerable<Observation> b_ = context.Operators.RetrieveByValueSet<Observation>(a_, default);
		bool? c_(Observation FecalOccult)
		{
			Code<ObservationStatus> e_ = FecalOccult?.StatusElement;
			string f_ = fhirHelpers_4_0_001.ToString(context, e_);
			string[] g_ = [
				"final",
				"amended",
				"corrected",
			];
			bool? h_ = context.Operators.In<string>(f_, g_ as IEnumerable<string>);
			List<CodeableConcept> i_ = FecalOccult?.Category;
			bool? j_(CodeableConcept FecalOccultCategory)
			{
				List<Coding> v_ = FecalOccultCategory?.Coding;
				bool? w_(Coding @this)
				{
					Code ag_ = @this?.CodeElement;
					bool? ah_ = context.Operators.Not((bool?)(ag_ is null));

					return ah_;
				};
				IEnumerable<Coding> x_ = context.Operators.Where<Coding>((IEnumerable<Coding>)v_, w_);
				Code y_(Coding @this)
				{
					Code ai_ = @this?.CodeElement;

					return ai_;
				};
				IEnumerable<Code> z_ = context.Operators.Select<Coding, Code>(x_, y_);
				bool? aa_(Code @this)
				{
					string aj_ = @this?.Value;
					bool? ak_ = context.Operators.Not((bool?)(aj_ is null));

					return ak_;
				};
				IEnumerable<Code> ab_ = context.Operators.Where<Code>(z_, aa_);
				string ac_(Code @this)
				{
					string al_ = @this?.Value;

					return al_;
				};
				IEnumerable<string> ad_ = context.Operators.Select<Code, string>(ab_, ac_);
				string[] ae_ = [
					"laboratory",
				];
				bool? af_ = context.Operators.Equivalent<string>(ad_, ae_ as IEnumerable<string>);

				return af_;
			};
			IEnumerable<CodeableConcept> k_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)i_, j_);
			bool? l_ = context.Operators.Exists<CodeableConcept>(k_);
			bool? m_ = context.Operators.And(h_, l_);
			DataType n_ = FecalOccult?.Value;
			bool? o_ = context.Operators.Not((bool?)(n_ is null));
			bool? p_ = context.Operators.And(m_, o_);
			DataType q_ = FecalOccult?.Effective;
			CqlDateTime r_ = matGlobalCommonFunctionsFHIR4_6_1_000.Latest(context, q_);
			CqlInterval<CqlDateTime> s_ = this.Measurement_Period(context);
			bool? t_ = context.Operators.In<CqlDateTime>(r_, s_, "day");
			bool? u_ = context.Operators.And(p_, t_);

			return u_;
		};
		IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Fecal Occult Blood Test Performed without appropriate category, ignore status, day of TZoffset")]
	public  IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed_without_appropriate_category__ignore_status__day_of_TZoffset(CqlContext context)
	{
		CqlValueSet a_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
		IEnumerable<Observation> b_ = context.Operators.RetrieveByValueSet<Observation>(a_, default);
		bool? c_(Observation FecalOccult)
		{
			List<CodeableConcept> e_ = FecalOccult?.Category;
			bool? f_(CodeableConcept FecalOccultCategory)
			{
				List<Coding> q_ = FecalOccultCategory?.Coding;
				bool? r_(Coding @this)
				{
					Code ac_ = @this?.CodeElement;
					bool? ad_ = context.Operators.Not((bool?)(ac_ is null));

					return ad_;
				};
				IEnumerable<Coding> s_ = context.Operators.Where<Coding>((IEnumerable<Coding>)q_, r_);
				Code t_(Coding @this)
				{
					Code ae_ = @this?.CodeElement;

					return ae_;
				};
				IEnumerable<Code> u_ = context.Operators.Select<Coding, Code>(s_, t_);
				bool? v_(Code @this)
				{
					string af_ = @this?.Value;
					bool? ag_ = context.Operators.Not((bool?)(af_ is null));

					return ag_;
				};
				IEnumerable<Code> w_ = context.Operators.Where<Code>(u_, v_);
				string x_(Code @this)
				{
					string ah_ = @this?.Value;

					return ah_;
				};
				IEnumerable<string> y_ = context.Operators.Select<Code, string>(w_, x_);
				string[] z_ = [
					"laboratory",
				];
				bool? aa_ = context.Operators.Equivalent<string>(y_, z_ as IEnumerable<string>);
				bool? ab_ = context.Operators.Not(aa_);

				return ab_;
			};
			IEnumerable<CodeableConcept> g_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)e_, f_);
			bool? h_ = context.Operators.Exists<CodeableConcept>(g_);
			DataType i_ = FecalOccult?.Value;
			bool? j_ = context.Operators.Not((bool?)(i_ is null));
			bool? k_ = context.Operators.And(h_, j_);
			DataType l_ = FecalOccult?.Effective;
			CqlDateTime m_ = matGlobalCommonFunctionsFHIR4_6_1_000.Latest(context, l_);
			CqlInterval<CqlDateTime> n_ = this.Measurement_Period(context);
			bool? o_ = context.Operators.In<CqlDateTime>(m_, n_, "day");
			bool? p_ = context.Operators.And(k_, o_);

			return p_;
		};
		IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Fecal Occult Blood Test Performed without appropriate status, ignore category, day of TZoffset")]
	public  IEnumerable<Observation> Fecal_Occult_Blood_Test_Performed_without_appropriate_status__ignore_category__day_of_TZoffset(CqlContext context)
	{
		CqlValueSet a_ = this.Fecal_Occult_Blood_Test__FOBT_(context);
		IEnumerable<Observation> b_ = context.Operators.RetrieveByValueSet<Observation>(a_, default);
		bool? c_(Observation FecalOccult)
		{
			Code<ObservationStatus> e_ = FecalOccult?.StatusElement;
			string f_ = fhirHelpers_4_0_001.ToString(context, e_);
			string[] g_ = [
				"final",
				"amended",
				"corrected",
			];
			bool? h_ = context.Operators.In<string>(f_, g_ as IEnumerable<string>);
			bool? i_ = context.Operators.Not(h_);
			DataType j_ = FecalOccult?.Value;
			bool? k_ = context.Operators.Not((bool?)(j_ is null));
			bool? l_ = context.Operators.And(i_, k_);
			DataType m_ = FecalOccult?.Effective;
			CqlDateTime n_ = matGlobalCommonFunctionsFHIR4_6_1_000.Latest(context, m_);
			CqlInterval<CqlDateTime> o_ = this.Measurement_Period(context);
			bool? p_ = context.Operators.In<CqlDateTime>(n_, o_, "day");
			bool? q_ = context.Operators.And(l_, p_);

			return q_;
		};
		IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Fecal Immunochemical Test DNA Display Date, Result, Category, Status")]
	public  IEnumerable<(CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> Fecal_Immunochemical_Test_DNA_Display_Date__Result__Category__Status(CqlContext context)
	{
		CqlValueSet a_ = this.FIT_DNA(context);
		IEnumerable<Observation> b_ = context.Operators.RetrieveByValueSet<Observation>(a_, default);
		bool? c_(Observation FitDNA)
		{
			DataType g_ = FitDNA?.Effective;
			CqlDateTime h_ = matGlobalCommonFunctionsFHIR4_6_1_000.Latest(context, g_);
			CqlInterval<CqlDateTime> i_ = this.Measurement_Period(context);
			CqlDateTime j_ = context.Operators.End(i_);
			CqlQuantity k_ = context.Operators.Quantity(4m, "years");
			CqlDateTime l_ = context.Operators.Subtract(j_, k_);
			CqlDateTime n_ = context.Operators.End(i_);
			CqlInterval<CqlDateTime> o_ = context.Operators.Interval(l_, n_, true, true);
			bool? p_ = context.Operators.In<CqlDateTime>(h_, o_, default);
			CqlDateTime r_ = context.Operators.End(i_);
			bool? s_ = context.Operators.Not((bool?)(r_ is null));
			bool? t_ = context.Operators.And(p_, s_);

			return t_;
		};
		IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
		(CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)? e_(Observation FitDNA)
		{
			DataType u_ = FitDNA?.Effective;
			CqlDateTime v_ = matGlobalCommonFunctionsFHIR4_6_1_000.Latest(context, u_);
			DataType w_ = FitDNA?.Value;
			IEnumerable<Coding> x_ = context.Operators.LateBoundProperty<IEnumerable<Coding>>(w_, "coding");
			bool? y_(Coding @this)
			{
				FhirString as_ = @this?.DisplayElement;
				bool? at_ = context.Operators.Not((bool?)(as_ is null));

				return at_;
			};
			IEnumerable<Coding> z_ = context.Operators.Where<Coding>(x_, y_);
			FhirString aa_(Coding @this)
			{
				FhirString au_ = @this?.DisplayElement;

				return au_;
			};
			IEnumerable<FhirString> ab_ = context.Operators.Select<Coding, FhirString>(z_, aa_);
			List<CodeableConcept> ac_ = FitDNA?.Category;
			bool? ad_(CodeableConcept @this)
			{
				List<Coding> av_ = @this?.Coding;
				bool? aw_ = context.Operators.Not((bool?)(av_ is null));

				return aw_;
			};
			IEnumerable<CodeableConcept> ae_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)ac_, ad_);
			List<Coding> af_(CodeableConcept @this)
			{
				List<Coding> ax_ = @this?.Coding;

				return ax_;
			};
			IEnumerable<List<Coding>> ag_ = context.Operators.Select<CodeableConcept, List<Coding>>(ae_, af_);
			IEnumerable<Coding> ah_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)ag_);
			bool? ai_(Coding @this)
			{
				Code ay_ = @this?.CodeElement;
				bool? az_ = context.Operators.Not((bool?)(ay_ is null));

				return az_;
			};
			IEnumerable<Coding> aj_ = context.Operators.Where<Coding>(ah_, ai_);
			Code ak_(Coding @this)
			{
				Code ba_ = @this?.CodeElement;

				return ba_;
			};
			IEnumerable<Code> al_ = context.Operators.Select<Coding, Code>(aj_, ak_);
			bool? am_(Code @this)
			{
				string bb_ = @this?.Value;
				bool? bc_ = context.Operators.Not((bool?)(bb_ is null));

				return bc_;
			};
			IEnumerable<Code> an_ = context.Operators.Where<Code>(al_, am_);
			string ao_(Code @this)
			{
				string bd_ = @this?.Value;

				return bd_;
			};
			IEnumerable<string> ap_ = context.Operators.Select<Code, string>(an_, ao_);
			Code<ObservationStatus> aq_ = FitDNA?.StatusElement;
			(CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)? ar_ = (v_, ab_, ap_, aq_);

			return ar_;
		};
		IEnumerable<(CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?> f_ = context.Operators.Select<Observation, (CqlDateTime occultDate, IEnumerable<FhirString> occultResult, IEnumerable<string> occultCategoryCode, Code<ObservationStatus> occultStatus)?>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Fecal Immunochemical Test DNA Performed")]
	public  IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed(CqlContext context)
	{
		CqlValueSet a_ = this.FIT_DNA(context);
		IEnumerable<Observation> b_ = context.Operators.RetrieveByValueSet<Observation>(a_, default);
		bool? c_(Observation FitDNA)
		{
			Code<ObservationStatus> e_ = FitDNA?.StatusElement;
			string f_ = fhirHelpers_4_0_001.ToString(context, e_);
			string[] g_ = [
				"final",
				"amended",
				"corrected",
			];
			bool? h_ = context.Operators.In<string>(f_, g_ as IEnumerable<string>);
			List<CodeableConcept> i_ = FitDNA?.Category;
			bool? j_(CodeableConcept FitDNACategory)
			{
				List<Coding> af_ = FitDNACategory?.Coding;
				bool? ag_(Coding @this)
				{
					Code aq_ = @this?.CodeElement;
					bool? ar_ = context.Operators.Not((bool?)(aq_ is null));

					return ar_;
				};
				IEnumerable<Coding> ah_ = context.Operators.Where<Coding>((IEnumerable<Coding>)af_, ag_);
				Code ai_(Coding @this)
				{
					Code as_ = @this?.CodeElement;

					return as_;
				};
				IEnumerable<Code> aj_ = context.Operators.Select<Coding, Code>(ah_, ai_);
				bool? ak_(Code @this)
				{
					string at_ = @this?.Value;
					bool? au_ = context.Operators.Not((bool?)(at_ is null));

					return au_;
				};
				IEnumerable<Code> al_ = context.Operators.Where<Code>(aj_, ak_);
				string am_(Code @this)
				{
					string av_ = @this?.Value;

					return av_;
				};
				IEnumerable<string> an_ = context.Operators.Select<Code, string>(al_, am_);
				string[] ao_ = [
					"laboratory",
				];
				bool? ap_ = context.Operators.Equivalent<string>(an_, ao_ as IEnumerable<string>);

				return ap_;
			};
			IEnumerable<CodeableConcept> k_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)i_, j_);
			bool? l_ = context.Operators.Exists<CodeableConcept>(k_);
			bool? m_ = context.Operators.And(h_, l_);
			DataType n_ = FitDNA?.Value;
			bool? o_ = context.Operators.Not((bool?)(n_ is null));
			bool? p_ = context.Operators.And(m_, o_);
			DataType q_ = FitDNA?.Effective;
			CqlDateTime r_ = matGlobalCommonFunctionsFHIR4_6_1_000.Latest(context, q_);
			CqlInterval<CqlDateTime> s_ = this.Measurement_Period(context);
			CqlDateTime t_ = context.Operators.End(s_);
			CqlQuantity u_ = context.Operators.Quantity(3m, "years");
			CqlDateTime v_ = context.Operators.Subtract(t_, u_);
			CqlDateTime x_ = context.Operators.End(s_);
			CqlInterval<CqlDateTime> y_ = context.Operators.Interval(v_, x_, true, true);
			bool? z_ = context.Operators.In<CqlDateTime>(r_, y_, default);
			CqlDateTime ab_ = context.Operators.End(s_);
			bool? ac_ = context.Operators.Not((bool?)(ab_ is null));
			bool? ad_ = context.Operators.And(z_, ac_);
			bool? ae_ = context.Operators.And(p_, ad_);

			return ae_;
		};
		IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Fecal Immunochemical Test DNA Performed, day of TZoffset")]
	public  IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed__day_of_TZoffset(CqlContext context)
	{
		CqlValueSet a_ = this.FIT_DNA(context);
		IEnumerable<Observation> b_ = context.Operators.RetrieveByValueSet<Observation>(a_, default);
		bool? c_(Observation FitDNA)
		{
			Code<ObservationStatus> e_ = FitDNA?.StatusElement;
			string f_ = fhirHelpers_4_0_001.ToString(context, e_);
			string[] g_ = [
				"final",
				"amended",
				"corrected",
			];
			bool? h_ = context.Operators.In<string>(f_, g_ as IEnumerable<string>);
			List<CodeableConcept> i_ = FitDNA?.Category;
			bool? j_(CodeableConcept FitDNACategory)
			{
				List<Coding> af_ = FitDNACategory?.Coding;
				bool? ag_(Coding @this)
				{
					Code aq_ = @this?.CodeElement;
					bool? ar_ = context.Operators.Not((bool?)(aq_ is null));

					return ar_;
				};
				IEnumerable<Coding> ah_ = context.Operators.Where<Coding>((IEnumerable<Coding>)af_, ag_);
				Code ai_(Coding @this)
				{
					Code as_ = @this?.CodeElement;

					return as_;
				};
				IEnumerable<Code> aj_ = context.Operators.Select<Coding, Code>(ah_, ai_);
				bool? ak_(Code @this)
				{
					string at_ = @this?.Value;
					bool? au_ = context.Operators.Not((bool?)(at_ is null));

					return au_;
				};
				IEnumerable<Code> al_ = context.Operators.Where<Code>(aj_, ak_);
				string am_(Code @this)
				{
					string av_ = @this?.Value;

					return av_;
				};
				IEnumerable<string> an_ = context.Operators.Select<Code, string>(al_, am_);
				string[] ao_ = [
					"laboratory",
				];
				bool? ap_ = context.Operators.Equivalent<string>(an_, ao_ as IEnumerable<string>);

				return ap_;
			};
			IEnumerable<CodeableConcept> k_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)i_, j_);
			bool? l_ = context.Operators.Exists<CodeableConcept>(k_);
			bool? m_ = context.Operators.And(h_, l_);
			DataType n_ = FitDNA?.Value;
			bool? o_ = context.Operators.Not((bool?)(n_ is null));
			bool? p_ = context.Operators.And(m_, o_);
			DataType q_ = FitDNA?.Effective;
			CqlDateTime r_ = matGlobalCommonFunctionsFHIR4_6_1_000.Latest(context, q_);
			CqlInterval<CqlDateTime> s_ = this.Measurement_Period(context);
			CqlDateTime t_ = context.Operators.End(s_);
			CqlQuantity u_ = context.Operators.Quantity(3m, "years");
			CqlDateTime v_ = context.Operators.Subtract(t_, u_);
			CqlDateTime x_ = context.Operators.End(s_);
			CqlInterval<CqlDateTime> y_ = context.Operators.Interval(v_, x_, true, true);
			bool? z_ = context.Operators.In<CqlDateTime>(r_, y_, "day");
			CqlDateTime ab_ = context.Operators.End(s_);
			bool? ac_ = context.Operators.Not((bool?)(ab_ is null));
			bool? ad_ = context.Operators.And(z_, ac_);
			bool? ae_ = context.Operators.And(p_, ad_);

			return ae_;
		};
		IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Fecal Immunochemical Test DNA Performed without appropriate category, ignore status, day of TZoffset")]
	public  IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_category__ignore_status__day_of_TZoffset(CqlContext context)
	{
		CqlValueSet a_ = this.FIT_DNA(context);
		IEnumerable<Observation> b_ = context.Operators.RetrieveByValueSet<Observation>(a_, default);
		bool? c_(Observation FitDNA)
		{
			List<CodeableConcept> e_ = FitDNA?.Category;
			bool? f_(CodeableConcept FitDNACategory)
			{
				List<Coding> aa_ = FitDNACategory?.Coding;
				bool? ab_(Coding @this)
				{
					Code am_ = @this?.CodeElement;
					bool? an_ = context.Operators.Not((bool?)(am_ is null));

					return an_;
				};
				IEnumerable<Coding> ac_ = context.Operators.Where<Coding>((IEnumerable<Coding>)aa_, ab_);
				Code ad_(Coding @this)
				{
					Code ao_ = @this?.CodeElement;

					return ao_;
				};
				IEnumerable<Code> ae_ = context.Operators.Select<Coding, Code>(ac_, ad_);
				bool? af_(Code @this)
				{
					string ap_ = @this?.Value;
					bool? aq_ = context.Operators.Not((bool?)(ap_ is null));

					return aq_;
				};
				IEnumerable<Code> ag_ = context.Operators.Where<Code>(ae_, af_);
				string ah_(Code @this)
				{
					string ar_ = @this?.Value;

					return ar_;
				};
				IEnumerable<string> ai_ = context.Operators.Select<Code, string>(ag_, ah_);
				string[] aj_ = [
					"laboratory",
				];
				bool? ak_ = context.Operators.Equivalent<string>(ai_, aj_ as IEnumerable<string>);
				bool? al_ = context.Operators.Not(ak_);

				return al_;
			};
			IEnumerable<CodeableConcept> g_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)e_, f_);
			bool? h_ = context.Operators.Exists<CodeableConcept>(g_);
			DataType i_ = FitDNA?.Value;
			bool? j_ = context.Operators.Not((bool?)(i_ is null));
			bool? k_ = context.Operators.And(h_, j_);
			DataType l_ = FitDNA?.Effective;
			CqlDateTime m_ = matGlobalCommonFunctionsFHIR4_6_1_000.Latest(context, l_);
			CqlInterval<CqlDateTime> n_ = this.Measurement_Period(context);
			CqlDateTime o_ = context.Operators.End(n_);
			CqlQuantity p_ = context.Operators.Quantity(3m, "years");
			CqlDateTime q_ = context.Operators.Subtract(o_, p_);
			CqlDateTime s_ = context.Operators.End(n_);
			CqlInterval<CqlDateTime> t_ = context.Operators.Interval(q_, s_, true, true);
			bool? u_ = context.Operators.In<CqlDateTime>(m_, t_, "day");
			CqlDateTime w_ = context.Operators.End(n_);
			bool? x_ = context.Operators.Not((bool?)(w_ is null));
			bool? y_ = context.Operators.And(u_, x_);
			bool? z_ = context.Operators.And(k_, y_);

			return z_;
		};
		IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Fecal Immunochemical Test DNA Performed without appropriate status, ignore category, day of TZoffset")]
	public  IEnumerable<Observation> Fecal_Immunochemical_Test_DNA_Performed_without_appropriate_status__ignore_category__day_of_TZoffset(CqlContext context)
	{
		CqlValueSet a_ = this.FIT_DNA(context);
		IEnumerable<Observation> b_ = context.Operators.RetrieveByValueSet<Observation>(a_, default);
		bool? c_(Observation FitDNA)
		{
			Code<ObservationStatus> e_ = FitDNA?.StatusElement;
			string f_ = fhirHelpers_4_0_001.ToString(context, e_);
			string[] g_ = [
				"final",
				"amended",
				"corrected",
			];
			bool? h_ = context.Operators.In<string>(f_, g_ as IEnumerable<string>);
			bool? i_ = context.Operators.Not(h_);
			DataType j_ = FitDNA?.Value;
			bool? k_ = context.Operators.Not((bool?)(j_ is null));
			bool? l_ = context.Operators.And(i_, k_);
			DataType m_ = FitDNA?.Effective;
			CqlDateTime n_ = matGlobalCommonFunctionsFHIR4_6_1_000.Latest(context, m_);
			CqlInterval<CqlDateTime> o_ = this.Measurement_Period(context);
			CqlDateTime p_ = context.Operators.End(o_);
			CqlQuantity q_ = context.Operators.Quantity(3m, "years");
			CqlDateTime r_ = context.Operators.Subtract(p_, q_);
			CqlDateTime t_ = context.Operators.End(o_);
			CqlInterval<CqlDateTime> u_ = context.Operators.Interval(r_, t_, true, true);
			bool? v_ = context.Operators.In<CqlDateTime>(n_, u_, "day");
			CqlDateTime x_ = context.Operators.End(o_);
			bool? y_ = context.Operators.Not((bool?)(x_ is null));
			bool? z_ = context.Operators.And(v_, y_);
			bool? aa_ = context.Operators.And(l_, z_);

			return aa_;
		};
		IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

		return d_;
	}

    [CqlDeclaration("CT Colonography Display Date")]
	public  IEnumerable<CqlDateTime> CT_Colonography_Display_Date(CqlContext context)
	{
		CqlValueSet a_ = this.CT_Colonography(context);
		IEnumerable<Observation> b_ = context.Operators.RetrieveByValueSet<Observation>(a_, default);
		bool? c_(Observation Colonography)
		{
			DataType g_ = Colonography?.Effective;
			CqlInterval<CqlDateTime> h_ = matGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(context, g_);
			CqlDateTime i_ = context.Operators.End(h_);
			CqlInterval<CqlDateTime> j_ = this.Measurement_Period(context);
			CqlDateTime k_ = context.Operators.End(j_);
			CqlQuantity l_ = context.Operators.Quantity(6m, "years");
			CqlDateTime m_ = context.Operators.Subtract(k_, l_);
			CqlDateTime o_ = context.Operators.End(j_);
			CqlInterval<CqlDateTime> p_ = context.Operators.Interval(m_, o_, true, true);
			bool? q_ = context.Operators.In<CqlDateTime>(i_, p_, default);
			CqlDateTime s_ = context.Operators.End(j_);
			bool? t_ = context.Operators.Not((bool?)(s_ is null));
			bool? u_ = context.Operators.And(q_, t_);

			return u_;
		};
		IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
		CqlDateTime e_(Observation Colonography)
		{
			DataType v_ = Colonography?.Effective;
			CqlDateTime w_ = matGlobalCommonFunctionsFHIR4_6_1_000.Latest(context, v_);

			return w_;
		};
		IEnumerable<CqlDateTime> f_ = context.Operators.Select<Observation, CqlDateTime>(d_, e_);

		return f_;
	}

    [CqlDeclaration("CT Colonography Performed")]
	public  IEnumerable<Observation> CT_Colonography_Performed(CqlContext context)
	{
		CqlValueSet a_ = this.CT_Colonography(context);
		IEnumerable<Observation> b_ = context.Operators.RetrieveByValueSet<Observation>(a_, default);
		bool? c_(Observation Colonography)
		{
			Code<ObservationStatus> e_ = Colonography?.StatusElement;
			string f_ = fhirHelpers_4_0_001.ToString(context, e_);
			string[] g_ = [
				"final",
				"amended",
				"corrected",
				"appended",
			];
			bool? h_ = context.Operators.In<string>(f_, g_ as IEnumerable<string>);
			DataType i_ = Colonography?.Effective;
			CqlInterval<CqlDateTime> j_ = matGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(context, i_);
			CqlDateTime k_ = context.Operators.End(j_);
			CqlInterval<CqlDateTime> l_ = this.Measurement_Period(context);
			CqlDateTime m_ = context.Operators.End(l_);
			CqlQuantity n_ = context.Operators.Quantity(5m, "years");
			CqlDateTime o_ = context.Operators.Subtract(m_, n_);
			CqlDateTime q_ = context.Operators.End(l_);
			CqlInterval<CqlDateTime> r_ = context.Operators.Interval(o_, q_, true, true);
			bool? s_ = context.Operators.In<CqlDateTime>(k_, r_, default);
			CqlDateTime u_ = context.Operators.End(l_);
			bool? v_ = context.Operators.Not((bool?)(u_ is null));
			bool? w_ = context.Operators.And(s_, v_);
			bool? x_ = context.Operators.And(h_, w_);

			return x_;
		};
		IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

		return d_;
	}

    [CqlDeclaration("CT Colonography Performed without appropriate status")]
	public  IEnumerable<Observation> CT_Colonography_Performed_without_appropriate_status(CqlContext context)
	{
		CqlValueSet a_ = this.CT_Colonography(context);
		IEnumerable<Observation> b_ = context.Operators.RetrieveByValueSet<Observation>(a_, default);
		bool? c_(Observation Colonography)
		{
			Code<ObservationStatus> e_ = Colonography?.StatusElement;
			string f_ = fhirHelpers_4_0_001.ToString(context, e_);
			string[] g_ = [
				"final",
				"amended",
				"corrected",
				"appended",
			];
			bool? h_ = context.Operators.In<string>(f_, g_ as IEnumerable<string>);
			bool? i_ = context.Operators.Not(h_);
			DataType j_ = Colonography?.Effective;
			CqlInterval<CqlDateTime> k_ = matGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(context, j_);
			CqlDateTime l_ = context.Operators.End(k_);
			CqlInterval<CqlDateTime> m_ = this.Measurement_Period(context);
			CqlDateTime n_ = context.Operators.End(m_);
			CqlQuantity o_ = context.Operators.Quantity(5m, "years");
			CqlDateTime p_ = context.Operators.Subtract(n_, o_);
			CqlDateTime r_ = context.Operators.End(m_);
			CqlInterval<CqlDateTime> s_ = context.Operators.Interval(p_, r_, true, true);
			bool? t_ = context.Operators.In<CqlDateTime>(l_, s_, default);
			CqlDateTime v_ = context.Operators.End(m_);
			bool? w_ = context.Operators.Not((bool?)(v_ is null));
			bool? x_ = context.Operators.And(t_, w_);
			bool? y_ = context.Operators.And(i_, x_);

			return y_;
		};
		IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Flexible Sigmoidoscopy Display Date")]
	public  IEnumerable<CqlDateTime> Flexible_Sigmoidoscopy_Display_Date(CqlContext context)
	{
		CqlValueSet a_ = this.Flexible_Sigmoidoscopy(context);
		IEnumerable<Procedure> b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, default);
		bool? c_(Procedure FlexibleSigmoidoscopy)
		{
			DataType g_ = FlexibleSigmoidoscopy?.Performed;
			CqlInterval<CqlDateTime> h_ = matGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(context, g_);
			CqlDateTime i_ = context.Operators.End(h_);
			CqlInterval<CqlDateTime> j_ = this.Measurement_Period(context);
			CqlDateTime k_ = context.Operators.End(j_);
			CqlQuantity l_ = context.Operators.Quantity(6m, "years");
			CqlDateTime m_ = context.Operators.Subtract(k_, l_);
			CqlDateTime o_ = context.Operators.End(j_);
			CqlInterval<CqlDateTime> p_ = context.Operators.Interval(m_, o_, true, true);
			bool? q_ = context.Operators.In<CqlDateTime>(i_, p_, default);
			CqlDateTime s_ = context.Operators.End(j_);
			bool? t_ = context.Operators.Not((bool?)(s_ is null));
			bool? u_ = context.Operators.And(q_, t_);

			return u_;
		};
		IEnumerable<Procedure> d_ = context.Operators.Where<Procedure>(b_, c_);
		CqlDateTime e_(Procedure FlexibleSigmoidoscopy)
		{
			DataType v_ = FlexibleSigmoidoscopy?.Performed;
			CqlDateTime w_ = matGlobalCommonFunctionsFHIR4_6_1_000.Latest(context, v_);

			return w_;
		};
		IEnumerable<CqlDateTime> f_ = context.Operators.Select<Procedure, CqlDateTime>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Flexible Sigmoidoscopy Performed")]
	public  IEnumerable<Procedure> Flexible_Sigmoidoscopy_Performed(CqlContext context)
	{
		CqlValueSet a_ = this.Flexible_Sigmoidoscopy(context);
		IEnumerable<Procedure> b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, default);
		bool? c_(Procedure FlexibleSigmoidoscopy)
		{
			Code<EventStatus> e_ = FlexibleSigmoidoscopy?.StatusElement;
			string f_ = fhirHelpers_4_0_001.ToString(context, e_);
			bool? g_ = context.Operators.Equal(f_, "completed");
			DataType h_ = FlexibleSigmoidoscopy?.Performed;
			CqlInterval<CqlDateTime> i_ = matGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(context, h_);
			CqlDateTime j_ = context.Operators.End(i_);
			CqlInterval<CqlDateTime> k_ = this.Measurement_Period(context);
			CqlDateTime l_ = context.Operators.End(k_);
			CqlQuantity m_ = context.Operators.Quantity(5m, "years");
			CqlDateTime n_ = context.Operators.Subtract(l_, m_);
			CqlDateTime p_ = context.Operators.End(k_);
			CqlInterval<CqlDateTime> q_ = context.Operators.Interval(n_, p_, true, true);
			bool? r_ = context.Operators.In<CqlDateTime>(j_, q_, default);
			CqlDateTime t_ = context.Operators.End(k_);
			bool? u_ = context.Operators.Not((bool?)(t_ is null));
			bool? v_ = context.Operators.And(r_, u_);
			bool? w_ = context.Operators.And(g_, v_);

			return w_;
		};
		IEnumerable<Procedure> d_ = context.Operators.Where<Procedure>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Flexible Sigmoidoscopy Performed without appropriate status")]
	public  IEnumerable<Procedure> Flexible_Sigmoidoscopy_Performed_without_appropriate_status(CqlContext context)
	{
		CqlValueSet a_ = this.Flexible_Sigmoidoscopy(context);
		IEnumerable<Procedure> b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, default);
		bool? c_(Procedure FlexibleSigmoidoscopy)
		{
			Code<EventStatus> e_ = FlexibleSigmoidoscopy?.StatusElement;
			string f_ = fhirHelpers_4_0_001.ToString(context, e_);
			bool? g_ = context.Operators.Equal(f_, "completed");
			bool? h_ = context.Operators.Not(g_);
			DataType i_ = FlexibleSigmoidoscopy?.Performed;
			CqlInterval<CqlDateTime> j_ = matGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(context, i_);
			CqlDateTime k_ = context.Operators.End(j_);
			CqlInterval<CqlDateTime> l_ = this.Measurement_Period(context);
			CqlDateTime m_ = context.Operators.End(l_);
			CqlQuantity n_ = context.Operators.Quantity(5m, "years");
			CqlDateTime o_ = context.Operators.Subtract(m_, n_);
			CqlDateTime q_ = context.Operators.End(l_);
			CqlInterval<CqlDateTime> r_ = context.Operators.Interval(o_, q_, true, true);
			bool? s_ = context.Operators.In<CqlDateTime>(k_, r_, default);
			CqlDateTime u_ = context.Operators.End(l_);
			bool? v_ = context.Operators.Not((bool?)(u_ is null));
			bool? w_ = context.Operators.And(s_, v_);
			bool? x_ = context.Operators.And(h_, w_);

			return x_;
		};
		IEnumerable<Procedure> d_ = context.Operators.Where<Procedure>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Colonoscopy Display Date")]
	public  IEnumerable<CqlDateTime> Colonoscopy_Display_Date(CqlContext context)
	{
		CqlValueSet a_ = this.Colonoscopy(context);
		IEnumerable<Procedure> b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, default);
		bool? c_(Procedure Colonoscopy)
		{
			DataType g_ = Colonoscopy?.Performed;
			CqlInterval<CqlDateTime> h_ = matGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(context, g_);
			CqlDateTime i_ = context.Operators.End(h_);
			CqlInterval<CqlDateTime> j_ = this.Measurement_Period(context);
			CqlDateTime k_ = context.Operators.End(j_);
			CqlQuantity l_ = context.Operators.Quantity(11m, "years");
			CqlDateTime m_ = context.Operators.Subtract(k_, l_);
			CqlDateTime o_ = context.Operators.End(j_);
			CqlInterval<CqlDateTime> p_ = context.Operators.Interval(m_, o_, true, true);
			bool? q_ = context.Operators.In<CqlDateTime>(i_, p_, default);
			CqlDateTime s_ = context.Operators.End(j_);
			bool? t_ = context.Operators.Not((bool?)(s_ is null));
			bool? u_ = context.Operators.And(q_, t_);

			return u_;
		};
		IEnumerable<Procedure> d_ = context.Operators.Where<Procedure>(b_, c_);
		CqlDateTime e_(Procedure Colonoscopy)
		{
			DataType v_ = Colonoscopy?.Performed;
			CqlDateTime w_ = matGlobalCommonFunctionsFHIR4_6_1_000.Latest(context, v_);

			return w_;
		};
		IEnumerable<CqlDateTime> f_ = context.Operators.Select<Procedure, CqlDateTime>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Colonoscopy Performed")]
	public  IEnumerable<Procedure> Colonoscopy_Performed(CqlContext context)
	{
		CqlValueSet a_ = this.Colonoscopy(context);
		IEnumerable<Procedure> b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, default);
		bool? c_(Procedure Colonoscopy)
		{
			Code<EventStatus> e_ = Colonoscopy?.StatusElement;
			string f_ = fhirHelpers_4_0_001.ToString(context, e_);
			bool? g_ = context.Operators.Equal(f_, "completed");
			DataType h_ = Colonoscopy?.Performed;
			CqlInterval<CqlDateTime> i_ = matGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(context, h_);
			CqlDateTime j_ = context.Operators.End(i_);
			CqlInterval<CqlDateTime> k_ = this.Measurement_Period(context);
			CqlDateTime l_ = context.Operators.End(k_);
			CqlQuantity m_ = context.Operators.Quantity(10m, "years");
			CqlDateTime n_ = context.Operators.Subtract(l_, m_);
			CqlDateTime p_ = context.Operators.End(k_);
			CqlInterval<CqlDateTime> q_ = context.Operators.Interval(n_, p_, true, true);
			bool? r_ = context.Operators.In<CqlDateTime>(j_, q_, default);
			CqlDateTime t_ = context.Operators.End(k_);
			bool? u_ = context.Operators.Not((bool?)(t_ is null));
			bool? v_ = context.Operators.And(r_, u_);
			bool? w_ = context.Operators.And(g_, v_);

			return w_;
		};
		IEnumerable<Procedure> d_ = context.Operators.Where<Procedure>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Colonoscopy Performed without appropriate status")]
	public  IEnumerable<Procedure> Colonoscopy_Performed_without_appropriate_status(CqlContext context)
	{
		CqlValueSet a_ = this.Colonoscopy(context);
		IEnumerable<Procedure> b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, default);
		bool? c_(Procedure Colonoscopy)
		{
			Code<EventStatus> e_ = Colonoscopy?.StatusElement;
			string f_ = fhirHelpers_4_0_001.ToString(context, e_);
			bool? g_ = context.Operators.Equal(f_, "completed");
			bool? h_ = context.Operators.Not(g_);
			DataType i_ = Colonoscopy?.Performed;
			CqlInterval<CqlDateTime> j_ = matGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(context, i_);
			CqlDateTime k_ = context.Operators.End(j_);
			CqlInterval<CqlDateTime> l_ = this.Measurement_Period(context);
			CqlDateTime m_ = context.Operators.End(l_);
			CqlQuantity n_ = context.Operators.Quantity(10m, "years");
			CqlDateTime o_ = context.Operators.Subtract(m_, n_);
			CqlDateTime q_ = context.Operators.End(l_);
			CqlInterval<CqlDateTime> r_ = context.Operators.Interval(o_, q_, true, true);
			bool? s_ = context.Operators.In<CqlDateTime>(k_, r_, default);
			CqlDateTime u_ = context.Operators.End(l_);
			bool? v_ = context.Operators.Not((bool?)(u_ is null));
			bool? w_ = context.Operators.And(s_, v_);
			bool? x_ = context.Operators.And(h_, w_);

			return x_;
		};
		IEnumerable<Procedure> d_ = context.Operators.Where<Procedure>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Numerator")]
	public  bool? Numerator(CqlContext context)
	{
		IEnumerable<Procedure> a_ = this.Colonoscopy_Performed(context);
		bool? b_ = context.Operators.Exists<Procedure>(a_);
		IEnumerable<Observation> c_ = this.Fecal_Occult_Blood_Test_Performed(context);
		bool? d_ = context.Operators.Exists<Observation>(c_);
		bool? e_ = context.Operators.Or(b_, d_);
		IEnumerable<Procedure> f_ = this.Flexible_Sigmoidoscopy_Performed(context);
		bool? g_ = context.Operators.Exists<Procedure>(f_);
		bool? h_ = context.Operators.Or(e_, g_);
		IEnumerable<Observation> i_ = this.Fecal_Immunochemical_Test_DNA_Performed(context);
		bool? j_ = context.Operators.Exists<Observation>(i_);
		bool? k_ = context.Operators.Or(h_, j_);
		IEnumerable<Observation> l_ = this.CT_Colonography_Performed(context);
		bool? m_ = context.Operators.Exists<Observation>(l_);
		bool? n_ = context.Operators.Or(k_, m_);

		return n_;
	}

    [CqlDeclaration("Final Numerator Population")]
	public  bool? Final_Numerator_Population(CqlContext context)
	{
		bool? a_ = this.Numerator(context);
		bool? b_ = this.Initial_Population(context);
		bool? c_ = context.Operators.And(a_, b_);
		bool? d_ = this.Denominator(context);
		bool? e_ = context.Operators.And(c_, d_);
		bool? f_ = this.Denominator_Exclusions(context);
		bool? g_ = context.Operators.Not(f_);
		bool? h_ = context.Operators.And(e_, g_);

		return h_;
	}

}
