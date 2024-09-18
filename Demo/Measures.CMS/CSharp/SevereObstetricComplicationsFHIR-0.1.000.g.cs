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
public static partial class SevereObstetricComplicationsFHIR_0_1_000ServiceCollectionExtensions
{
    public static IServiceCollection AddSevereObstetricComplicationsFHIR_0_1_000(this IServiceCollection services)
    {
        services.TryAddSingleton<SevereObstetricComplicationsFHIR_0_1_000>();
        services.AddCQMCommon_2_0_000();
        services.AddFHIRHelpers_4_3_000();
        services.AddSupplementalDataElements_3_4_000();
        services.AddPCMaternal_5_16_000();
        services.AddQICoreCommon_2_0_000();
        return services;
    }
}

partial class SevereObstetricComplicationsFHIR_0_1_000 : ILibraryService
{
    static void ILibraryService.AddLibraryService(IServiceCollection services) =>
        services.AddSevereObstetricComplicationsFHIR_0_1_000();
}

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.3.0")]
[CqlLibrary("SevereObstetricComplicationsFHIR", "0.1.000")]
public partial class SevereObstetricComplicationsFHIR_0_1_000(
    CQMCommon_2_0_000 cqmCommon_2_0_000,
    FHIRHelpers_4_3_000 fhirHelpers_4_3_000,
    SupplementalDataElements_3_4_000 supplementalDataElements_3_4_000,
    PCMaternal_5_16_000 pcMaternal_5_16_000,
    QICoreCommon_2_0_000 qiCoreCommon_2_0_000)
{

    [CqlDeclaration("20 to 42 Plus Weeks Gestation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.67")]
	public  CqlValueSet _20_to_42_Plus_Weeks_Gestation(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.67", default);

    [CqlDeclaration("Acute or Persistent Asthma")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.271")]
	public  CqlValueSet Acute_or_Persistent_Asthma(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.271", default);

    [CqlDeclaration("Anemia")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.323")]
	public  CqlValueSet Anemia(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.323", default);

    [CqlDeclaration("Autoimmune Disease")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.311")]
	public  CqlValueSet Autoimmune_Disease(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.311", default);

    [CqlDeclaration("Bariatric Surgery")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.317")]
	public  CqlValueSet Bariatric_Surgery(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.317", default);

    [CqlDeclaration("Bleeding Disorder")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.287")]
	public  CqlValueSet Bleeding_Disorder(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.287", default);

    [CqlDeclaration("Blood Transfusion")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.213")]
	public  CqlValueSet Blood_Transfusion(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.213", default);

    [CqlDeclaration("Cardiac Disease")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.341")]
	public  CqlValueSet Cardiac_Disease(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.341", default);

    [CqlDeclaration("COVID 19 Confirmed")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.373")]
	public  CqlValueSet COVID_19_Confirmed(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.373", default);

    [CqlDeclaration("Delivery Procedures")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.59")]
	public  CqlValueSet Delivery_Procedures(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.59", default);

    [CqlDeclaration("Economic Housing Instability")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.292")]
	public  CqlValueSet Economic_Housing_Instability(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.292", default);

    [CqlDeclaration("ED Visit and OB Triage")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.369")]
	public  CqlValueSet ED_Visit_and_OB_Triage(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.369", default);

    [CqlDeclaration("Emergency Department Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292")]
	public  CqlValueSet Emergency_Department_Visit(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", default);

    [CqlDeclaration("Gastrointestinal Disease")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.338")]
	public  CqlValueSet Gastrointestinal_Disease(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.338", default);

    [CqlDeclaration("Gestational Diabetes")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.269")]
	public  CqlValueSet Gestational_Diabetes(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.269", default);

    [CqlDeclaration("Hematocrit lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.114")]
	public  CqlValueSet Hematocrit_lab_test(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.114", default);

    [CqlDeclaration("HIV in Pregnancy Childbirth and Puerperium")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.272")]
	public  CqlValueSet HIV_in_Pregnancy_Childbirth_and_Puerperium(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.272", default);

    [CqlDeclaration("Hypertension")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.332")]
	public  CqlValueSet Hypertension(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.332", default);

    [CqlDeclaration("Long Term Anticoagulant Use")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.366")]
	public  CqlValueSet Long_Term_Anticoagulant_Use(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.366", default);

    [CqlDeclaration("Mental Health Disorder")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.314")]
	public  CqlValueSet Mental_Health_Disorder(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.314", default);

    [CqlDeclaration("Mild or Moderate Preeclampsia")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.329")]
	public  CqlValueSet Mild_or_Moderate_Preeclampsia(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.329", default);

    [CqlDeclaration("Morbid or Severe Obesity")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.290")]
	public  CqlValueSet Morbid_or_Severe_Obesity(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.290", default);

    [CqlDeclaration("Multiple Pregnancy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.284")]
	public  CqlValueSet Multiple_Pregnancy(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.284", default);

    [CqlDeclaration("Neuromuscular Disease")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.308")]
	public  CqlValueSet Neuromuscular_Disease(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.308", default);

    [CqlDeclaration("Observation Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143")]
	public  CqlValueSet Observation_Services(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", default);

    [CqlDeclaration("Patient Expired")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309")]
	public  CqlValueSet Patient_Expired(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309", default);

    [CqlDeclaration("Placenta Previa")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.35")]
	public  CqlValueSet Placenta_Previa(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.35", default);

    [CqlDeclaration("Placental Abruption")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.305")]
	public  CqlValueSet Placental_Abruption(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.305", default);

    [CqlDeclaration("Placental Accreta Spectrum")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.302")]
	public  CqlValueSet Placental_Accreta_Spectrum(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.302", default);

    [CqlDeclaration("Preexisting Diabetes")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.275")]
	public  CqlValueSet Preexisting_Diabetes(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.275", default);

    [CqlDeclaration("Present on Admission is No or Unable To Determine")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.370")]
	public  CqlValueSet Present_on_Admission_is_No_or_Unable_To_Determine(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.370", default);

    [CqlDeclaration("Present On Admission is Yes or Exempt")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.63")]
	public  CqlValueSet Present_On_Admission_is_Yes_or_Exempt(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.63", default);

    [CqlDeclaration("Preterm Birth")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.299")]
	public  CqlValueSet Preterm_Birth(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.299", default);

    [CqlDeclaration("Previous Cesarean")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.278")]
	public  CqlValueSet Previous_Cesarean(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.278", default);

    [CqlDeclaration("Pulmonary Hypertension")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.281")]
	public  CqlValueSet Pulmonary_Hypertension(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.281", default);

    [CqlDeclaration("Renal Disease")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.335")]
	public  CqlValueSet Renal_Disease(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.335", default);

    [CqlDeclaration("Respiratory Conditions Related to COVID 19")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.376")]
	public  CqlValueSet Respiratory_Conditions_Related_to_COVID_19(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.376", default);

    [CqlDeclaration("Respiratory Support Procedures Related to COVID 19")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.379")]
	public  CqlValueSet Respiratory_Support_Procedures_Related_to_COVID_19(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.379", default);

    [CqlDeclaration("Severe Maternal Morbidity Diagnoses")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.255")]
	public  CqlValueSet Severe_Maternal_Morbidity_Diagnoses(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.255", default);

    [CqlDeclaration("Severe Maternal Morbidity Procedures")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.256")]
	public  CqlValueSet Severe_Maternal_Morbidity_Procedures(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.256", default);

    [CqlDeclaration("Severe Preeclampsia")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.327")]
	public  CqlValueSet Severe_Preeclampsia(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.327", default);

    [CqlDeclaration("Substance Abuse")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.320")]
	public  CqlValueSet Substance_Abuse(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.320", default);

    [CqlDeclaration("Thyrotoxicosis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.296")]
	public  CqlValueSet Thyrotoxicosis(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.296", default);

    [CqlDeclaration("Venous Thromboembolism in Pregnancy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.363")]
	public  CqlValueSet Venous_Thromboembolism_in_Pregnancy(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.363", default);

    [CqlDeclaration("White blood cells count lab test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.129")]
	public  CqlValueSet White_blood_cells_count_lab_test(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.129", default);

    [CqlDeclaration("Heart rate")]
	public  CqlCode Heart_rate(CqlContext context) => 
		new CqlCode("8867-4", "http://loinc.org", default, default);

    [CqlDeclaration("Systolic blood pressure")]
	public  CqlCode Systolic_blood_pressure(CqlContext context) => 
		new CqlCode("8480-6", "http://loinc.org", default, default);

    [CqlDeclaration("LOINC")]
	public  CqlCode[] LOINC(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("8867-4", "http://loinc.org", default, default),
			new CqlCode("8480-6", "http://loinc.org", default, default),
		];

		return a_;
	}

    [CqlDeclaration("SNOMEDCT")]
	public  CqlCode[] SNOMEDCT(CqlContext context)
	{
		CqlCode[] a_ = []
;

		return a_;
	}

    [CqlDeclaration("Measurement Period")]
	public  CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
	{
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("SevereObstetricComplicationsFHIR-0.1.000", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
	}

    [CqlDeclaration("Patient")]
	public  Patient Patient(CqlContext context)
	{
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(default, default);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Initial Population")]
	public  IEnumerable<Encounter> Initial_Population(CqlContext context)
	{
		IEnumerable<Encounter> a_ = pcMaternal_5_16_000.Delivery_Encounter_with_Age_Range(context);

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public  (IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
	{
		(IEnumerable<CqlCode> codes, string display)? a_ = supplementalDataElements_3_4_000.SDE_Ethnicity(context);

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public  IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
	{
		IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = supplementalDataElements_3_4_000.SDE_Payer(context);

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public  (IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
	{
		(IEnumerable<CqlCode> codes, string display)? a_ = supplementalDataElements_3_4_000.SDE_Race(context);

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
	public  CqlCode SDE_Sex(CqlContext context)
	{
		CqlCode a_ = supplementalDataElements_3_4_000.SDE_Sex(context);

		return a_;
	}

    [CqlDeclaration("Delivery Encounters with Calculated Gestational Age Greater than or Equal to 20 Weeks")]
	public  IEnumerable<Encounter> Delivery_Encounters_with_Calculated_Gestational_Age_Greater_than_or_Equal_to_20_Weeks(CqlContext context)
	{
		IEnumerable<Encounter> a_ = pcMaternal_5_16_000.Delivery_Encounter_with_Age_Range(context);
		bool? b_(Encounter DeliveryEncounter)
		{
			int? d_ = pcMaternal_5_16_000.calculatedGestationalAge(context, DeliveryEncounter);
			bool? e_ = context.Operators.GreaterOrEqual(d_, 20);

			return e_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Delivery Encounters with Estimated Gestational Age Assessment Greater than or Equal to 20 Weeks")]
	public  IEnumerable<Encounter> Delivery_Encounters_with_Estimated_Gestational_Age_Assessment_Greater_than_or_Equal_to_20_Weeks(CqlContext context)
	{
		IEnumerable<Encounter> a_ = pcMaternal_5_16_000.Delivery_Encounter_with_Age_Range(context);
		bool? b_(Encounter DeliveryEncounter)
		{
			int? d_ = pcMaternal_5_16_000.calculatedGestationalAge(context, DeliveryEncounter);
			CqlQuantity e_ = pcMaternal_5_16_000.lastEstimatedGestationalAge(context, DeliveryEncounter);
			CqlQuantity f_ = context.Operators.Quantity(20m, "weeks");
			bool? g_ = context.Operators.GreaterOrEqual(e_, f_);
			bool? h_ = context.Operators.And((bool?)(d_ is null), g_);

			return h_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Delivery Encounters with Gestational Age Greater than or Equal to 20 Weeks Based on Coding")]
	public  IEnumerable<Encounter> Delivery_Encounters_with_Gestational_Age_Greater_than_or_Equal_to_20_Weeks_Based_on_Coding(CqlContext context)
	{
		IEnumerable<Encounter> a_ = pcMaternal_5_16_000.Delivery_Encounter_with_Age_Range(context);
		bool? b_(Encounter DeliveryEncounter)
		{
			int? d_ = pcMaternal_5_16_000.calculatedGestationalAge(context, DeliveryEncounter);
			CqlQuantity e_ = pcMaternal_5_16_000.lastEstimatedGestationalAge(context, DeliveryEncounter);
			bool? f_ = context.Operators.And((bool?)(d_ is null), (bool?)(e_ is null));
			IEnumerable<Condition> g_ = cqmCommon_2_0_000.encounterDiagnosis(context, DeliveryEncounter);
			bool? h_(Condition EncounterDiagnosis)
			{
				CodeableConcept l_ = EncounterDiagnosis?.Code;
				CqlConcept m_ = fhirHelpers_4_3_000.ToConcept(context, l_);
				CqlValueSet n_ = this._20_to_42_Plus_Weeks_Gestation(context);
				bool? o_ = context.Operators.ConceptInValueSet(m_, n_);

				return o_;
			};
			IEnumerable<Condition> i_ = context.Operators.Where<Condition>(g_, h_);
			bool? j_ = context.Operators.Exists<Condition>(i_);
			bool? k_ = context.Operators.And(f_, j_);

			return k_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Delivery Encounters At Greater than or Equal to 20 Weeks Gestation")]
	public  IEnumerable<Encounter> Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_with_Calculated_Gestational_Age_Greater_than_or_Equal_to_20_Weeks(context);
		IEnumerable<Encounter> b_ = this.Delivery_Encounters_with_Estimated_Gestational_Age_Assessment_Greater_than_or_Equal_to_20_Weeks(context);
		IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
		IEnumerable<Encounter> d_ = this.Delivery_Encounters_with_Gestational_Age_Greater_than_or_Equal_to_20_Weeks_Based_on_Coding(context);
		IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Delivery Encounters with Severe Obstetric Complications Diagnosis or Procedure Excluding Blood Transfusion")]
	public  IEnumerable<Encounter> Delivery_Encounters_with_Severe_Obstetric_Complications_Diagnosis_or_Procedure_Excluding_Blood_Transfusion(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
		bool? b_(Encounter TwentyWeeksPlusEncounter)
		{
			List<Encounter.DiagnosisComponent> d_ = TwentyWeeksPlusEncounter?.Diagnosis;
			bool? e_(Encounter.DiagnosisComponent EncounterDiagnoses)
			{
				ResourceReference n_ = EncounterDiagnoses?.Condition;
				Condition o_ = cqmCommon_2_0_000.getCondition(context, n_);
				CodeableConcept p_ = o_?.Code;
				CqlConcept q_ = fhirHelpers_4_3_000.ToConcept(context, p_);
				CqlValueSet r_ = this.Severe_Maternal_Morbidity_Diagnoses(context);
				bool? s_ = context.Operators.ConceptInValueSet(q_, r_);
				bool? t_(Extension @this)
				{
					string ac_ = @this?.Url;
					FhirString ad_ = context.Operators.Convert<FhirString>(ac_);
					string ae_ = fhirHelpers_4_3_000.ToString(context, ad_);
					bool? af_ = context.Operators.Equal(ae_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

					return af_;
				};
				IEnumerable<Extension> u_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(EncounterDiagnoses is Element
						? (EncounterDiagnoses as Element).Extension
						: default), t_);
				object v_(Extension @this)
				{
					DataType ag_ = @this?.Value;

					return ag_;
				};
				IEnumerable<object> w_ = context.Operators.Select<Extension, object>(u_, v_);
				object x_ = context.Operators.SingletonFrom<object>(w_);
				CqlConcept y_ = fhirHelpers_4_3_000.ToConcept(context, x_ as CodeableConcept);
				CqlValueSet z_ = this.Present_on_Admission_is_No_or_Unable_To_Determine(context);
				bool? aa_ = context.Operators.ConceptInValueSet(y_, z_);
				bool? ab_ = context.Operators.And(s_, aa_);

				return ab_;
			};
			IEnumerable<Encounter.DiagnosisComponent> f_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)d_, e_);
			bool? g_ = context.Operators.Exists<Encounter.DiagnosisComponent>(f_);
			CqlValueSet h_ = this.Severe_Maternal_Morbidity_Procedures(context);
			IEnumerable<Procedure> i_ = context.Operators.RetrieveByValueSet<Procedure>(h_, default);
			bool? j_(Procedure EncounterSMMProcedures)
			{
				Code<EventStatus> ah_ = EncounterSMMProcedures?.StatusElement;
				EventStatus? ai_ = ah_?.Value;
				string aj_ = context.Operators.Convert<string>(ai_);
				bool? ak_ = context.Operators.Equal(aj_, "completed");
				DataType al_ = EncounterSMMProcedures?.Performed;
				object am_ = fhirHelpers_4_3_000.ToValue(context, al_);
				CqlInterval<CqlDateTime> an_ = qiCoreCommon_2_0_000.toInterval(context, am_);
				CqlDateTime ao_ = context.Operators.Start(an_);
				CqlInterval<CqlDateTime> ap_ = pcMaternal_5_16_000.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
				bool? aq_ = context.Operators.In<CqlDateTime>(ao_, ap_, "day");
				bool? ar_ = context.Operators.And(ak_, aq_);

				return ar_;
			};
			IEnumerable<Procedure> k_ = context.Operators.Where<Procedure>(i_, j_);
			bool? l_ = context.Operators.Exists<Procedure>(k_);
			bool? m_ = context.Operators.Or(g_, l_);

			return m_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Delivery Encounters with Expiration")]
	public  IEnumerable<Encounter> Delivery_Encounters_with_Expiration(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
		bool? b_(Encounter TwentyWeeksPlusEncounter)
		{
			Encounter.HospitalizationComponent d_ = TwentyWeeksPlusEncounter?.Hospitalization;
			CodeableConcept e_ = d_?.DischargeDisposition;
			CqlConcept f_ = fhirHelpers_4_3_000.ToConcept(context, e_);
			CqlValueSet g_ = this.Patient_Expired(context);
			bool? h_ = context.Operators.ConceptInValueSet(f_, g_);

			return h_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Delivery Encounters with Blood Transfusion")]
	public  IEnumerable<Encounter> Delivery_Encounters_with_Blood_Transfusion(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
		IEnumerable<Encounter> b_(Encounter TwentyWeeksPlusEncounter)
		{
			CqlValueSet d_ = this.Blood_Transfusion(context);
			IEnumerable<Procedure> e_ = context.Operators.RetrieveByValueSet<Procedure>(d_, default);
			bool? f_(Procedure BloodTransfusion)
			{
				Code<EventStatus> j_ = BloodTransfusion?.StatusElement;
				EventStatus? k_ = j_?.Value;
				string l_ = context.Operators.Convert<string>(k_);
				bool? m_ = context.Operators.Equal(l_, "completed");
				DataType n_ = BloodTransfusion?.Performed;
				object o_ = fhirHelpers_4_3_000.ToValue(context, n_);
				CqlInterval<CqlDateTime> p_ = qiCoreCommon_2_0_000.toInterval(context, o_);
				CqlDateTime q_ = context.Operators.Start(p_);
				CqlInterval<CqlDateTime> r_ = pcMaternal_5_16_000.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
				bool? s_ = context.Operators.In<CqlDateTime>(q_, r_, "day");
				bool? t_ = context.Operators.And(m_, s_);

				return t_;
			};
			IEnumerable<Procedure> g_ = context.Operators.Where<Procedure>(e_, f_);
			Encounter h_(Procedure BloodTransfusion) => 
				TwentyWeeksPlusEncounter;
			IEnumerable<Encounter> i_ = context.Operators.Select<Procedure, Encounter>(g_, h_);

			return i_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Delivery Encounters with Severe Obstetric Complications")]
	public  IEnumerable<Encounter> Delivery_Encounters_with_Severe_Obstetric_Complications(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_with_Severe_Obstetric_Complications_Diagnosis_or_Procedure_Excluding_Blood_Transfusion(context);
		IEnumerable<Encounter> b_ = this.Delivery_Encounters_with_Expiration(context);
		IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
		IEnumerable<Encounter> d_ = this.Delivery_Encounters_with_Blood_Transfusion(context);
		IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Numerator")]
	public  IEnumerable<Encounter> Numerator(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_with_Severe_Obstetric_Complications(context);

		return a_;
	}

    [CqlDeclaration("Delivery Encounters with COVID and Respiratory Condition or Procedure")]
	public  IEnumerable<Encounter> Delivery_Encounters_with_COVID_and_Respiratory_Condition_or_Procedure(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
		bool? b_(Encounter TwentyWeeksPlusEncounter)
		{
			IEnumerable<Condition> d_ = cqmCommon_2_0_000.encounterDiagnosis(context, TwentyWeeksPlusEncounter);
			bool? e_(Condition EncounterDiagnosis)
			{
				CodeableConcept s_ = EncounterDiagnosis?.Code;
				CqlConcept t_ = fhirHelpers_4_3_000.ToConcept(context, s_);
				CqlValueSet u_ = this.COVID_19_Confirmed(context);
				bool? v_ = context.Operators.ConceptInValueSet(t_, u_);

				return v_;
			};
			IEnumerable<Condition> f_ = context.Operators.Where<Condition>(d_, e_);
			bool? g_ = context.Operators.Exists<Condition>(f_);
			bool? i_(Condition EncounterDiagnosis)
			{
				CodeableConcept w_ = EncounterDiagnosis?.Code;
				CqlConcept x_ = fhirHelpers_4_3_000.ToConcept(context, w_);
				CqlValueSet y_ = this.Respiratory_Conditions_Related_to_COVID_19(context);
				bool? z_ = context.Operators.ConceptInValueSet(x_, y_);

				return z_;
			};
			IEnumerable<Condition> j_ = context.Operators.Where<Condition>(d_, i_);
			bool? k_ = context.Operators.Exists<Condition>(j_);
			CqlValueSet l_ = this.Respiratory_Support_Procedures_Related_to_COVID_19(context);
			IEnumerable<Procedure> m_ = context.Operators.RetrieveByValueSet<Procedure>(l_, default);
			bool? n_(Procedure COVIDRespiratoryProcedure)
			{
				Code<EventStatus> aa_ = COVIDRespiratoryProcedure?.StatusElement;
				EventStatus? ab_ = aa_?.Value;
				string ac_ = context.Operators.Convert<string>(ab_);
				bool? ad_ = context.Operators.Equal(ac_, "completed");
				DataType ae_ = COVIDRespiratoryProcedure?.Performed;
				object af_ = fhirHelpers_4_3_000.ToValue(context, ae_);
				CqlInterval<CqlDateTime> ag_ = qiCoreCommon_2_0_000.toInterval(context, af_);
				CqlDateTime ah_ = context.Operators.Start(ag_);
				CqlInterval<CqlDateTime> ai_ = pcMaternal_5_16_000.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
				bool? aj_ = context.Operators.In<CqlDateTime>(ah_, ai_, "day");
				bool? ak_ = context.Operators.And(ad_, aj_);

				return ak_;
			};
			IEnumerable<Procedure> o_ = context.Operators.Where<Procedure>(m_, n_);
			bool? p_ = context.Operators.Exists<Procedure>(o_);
			bool? q_ = context.Operators.Or(k_, p_);
			bool? r_ = context.Operators.And(g_, q_);

			return r_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Denominator Exclusion")]
	public  IEnumerable<Encounter> Denominator_Exclusion(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_with_COVID_and_Respiratory_Condition_or_Procedure(context);

		return a_;
	}

    [CqlDeclaration("Stratification Encounter")]
	public  IEnumerable<Encounter> Stratification_Encounter(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Numerator(context);
		IEnumerable<Encounter> b_ = this.Denominator_Exclusion(context);
		IEnumerable<Encounter> c_ = context.Operators.Except<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Delivery Encounters with Severe Obstetric Complications Excluding Blood Transfusions")]
	public  IEnumerable<Encounter> Delivery_Encounters_with_Severe_Obstetric_Complications_Excluding_Blood_Transfusions(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_with_Severe_Obstetric_Complications_Diagnosis_or_Procedure_Excluding_Blood_Transfusion(context);
		IEnumerable<Encounter> b_ = this.Delivery_Encounters_with_Expiration(context);
		IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Stratum 1")]
	public  IEnumerable<Encounter> Stratum_1(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Stratification_Encounter(context);
		IEnumerable<Encounter> b_ = this.Delivery_Encounters_with_Severe_Obstetric_Complications_Excluding_Blood_Transfusions(context);
		IEnumerable<Encounter> c_ = context.Operators.Intersect<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Variable Calculated Gestational Age")]
	public  IEnumerable<(string EncounterID, int? CalculatedCGA)?> Variable_Calculated_Gestational_Age(CqlContext context)
	{
		IEnumerable<(string EncounterID, int? CalculatedCGA)?> a_ = pcMaternal_5_16_000.Variable_Calculated_Gestational_Age(context);

		return a_;
	}

    [CqlDeclaration("Denominator")]
	public  IEnumerable<Encounter> Denominator(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);

		return a_;
	}

    [CqlDeclaration("pOAIsYesOrExempt")]
	public  IEnumerable<CqlConcept> pOAIsYesOrExempt(CqlContext context, Encounter TheEncounter)
	{
		List<Encounter.DiagnosisComponent> a_ = TheEncounter?.Diagnosis;
		bool? b_(Encounter.DiagnosisComponent EncounterDiagnoses)
		{
			bool? f_(Extension @this)
			{
				string n_ = @this?.Url;
				FhirString o_ = context.Operators.Convert<FhirString>(n_);
				string p_ = fhirHelpers_4_3_000.ToString(context, o_);
				bool? q_ = context.Operators.Equal(p_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

				return q_;
			};
			IEnumerable<Extension> g_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(EncounterDiagnoses is Element
					? (EncounterDiagnoses as Element).Extension
					: default), f_);
			object h_(Extension @this)
			{
				DataType r_ = @this?.Value;

				return r_;
			};
			IEnumerable<object> i_ = context.Operators.Select<Extension, object>(g_, h_);
			object j_ = context.Operators.SingletonFrom<object>(i_);
			CqlConcept k_ = fhirHelpers_4_3_000.ToConcept(context, j_ as CodeableConcept);
			CqlValueSet l_ = this.Present_On_Admission_is_Yes_or_Exempt(context);
			bool? m_ = context.Operators.ConceptInValueSet(k_, l_);

			return m_;
		};
		IEnumerable<Encounter.DiagnosisComponent> c_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)a_, b_);
		CqlConcept d_(Encounter.DiagnosisComponent EncounterDiagnoses)
		{
			ResourceReference s_ = EncounterDiagnoses?.Condition;
			Condition t_ = cqmCommon_2_0_000.getCondition(context, s_);
			CodeableConcept u_ = t_?.Code;
			CqlConcept v_ = fhirHelpers_4_3_000.ToConcept(context, u_);

			return v_;
		};
		IEnumerable<CqlConcept> e_ = context.Operators.Select<Encounter.DiagnosisComponent, CqlConcept>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Risk Variable Anemia")]
	public  IEnumerable<Encounter> Risk_Variable_Anemia(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
		bool? b_(Encounter TwentyWeeksPlusEncounter)
		{
			IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
			CqlValueSet e_ = this.Anemia(context);
			bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

			return f_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Risk Variable Asthma")]
	public  IEnumerable<Encounter> Risk_Variable_Asthma(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
		bool? b_(Encounter TwentyWeeksPlusEncounter)
		{
			IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
			CqlValueSet e_ = this.Acute_or_Persistent_Asthma(context);
			bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

			return f_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Risk Variable Autoimmune Disease")]
	public  IEnumerable<Encounter> Risk_Variable_Autoimmune_Disease(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
		bool? b_(Encounter TwentyWeeksPlusEncounter)
		{
			IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
			CqlValueSet e_ = this.Autoimmune_Disease(context);
			bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

			return f_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Risk Variable Bariatric Surgery")]
	public  IEnumerable<Encounter> Risk_Variable_Bariatric_Surgery(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
		bool? b_(Encounter TwentyWeeksPlusEncounter)
		{
			IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
			CqlValueSet e_ = this.Bariatric_Surgery(context);
			bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

			return f_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Risk Variable Bleeding Disorder")]
	public  IEnumerable<Encounter> Risk_Variable_Bleeding_Disorder(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
		bool? b_(Encounter TwentyWeeksPlusEncounter)
		{
			IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
			CqlValueSet e_ = this.Bleeding_Disorder(context);
			bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

			return f_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Risk Variable Morbid Obesity")]
	public  IEnumerable<Encounter> Risk_Variable_Morbid_Obesity(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
		bool? b_(Encounter TwentyWeeksPlusEncounter)
		{
			IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
			CqlValueSet e_ = this.Morbid_or_Severe_Obesity(context);
			bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

			return f_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Risk Variable Cardiac Disease")]
	public  IEnumerable<Encounter> Risk_Variable_Cardiac_Disease(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
		bool? b_(Encounter TwentyWeeksPlusEncounter)
		{
			IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
			CqlValueSet e_ = this.Cardiac_Disease(context);
			bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

			return f_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Risk Variable Economic Housing Instability")]
	public  IEnumerable<Encounter> Risk_Variable_Economic_Housing_Instability(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
		bool? b_(Encounter TwentyWeeksPlusEncounter)
		{
			IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
			CqlValueSet e_ = this.Economic_Housing_Instability(context);
			bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

			return f_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Risk Variable Gastrointestinal Disease")]
	public  IEnumerable<Encounter> Risk_Variable_Gastrointestinal_Disease(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
		bool? b_(Encounter TwentyWeeksPlusEncounter)
		{
			IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
			CqlValueSet e_ = this.Gastrointestinal_Disease(context);
			bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

			return f_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Risk Variable Gestational Diabetes")]
	public  IEnumerable<Encounter> Risk_Variable_Gestational_Diabetes(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
		bool? b_(Encounter TwentyWeeksPlusEncounter)
		{
			IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
			CqlValueSet e_ = this.Gestational_Diabetes(context);
			bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

			return f_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Risk Variable HIV")]
	public  IEnumerable<Encounter> Risk_Variable_HIV(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
		bool? b_(Encounter TwentyWeeksPlusEncounter)
		{
			IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
			CqlValueSet e_ = this.HIV_in_Pregnancy_Childbirth_and_Puerperium(context);
			bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

			return f_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Risk Variable Hypertension")]
	public  IEnumerable<Encounter> Risk_Variable_Hypertension(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
		bool? b_(Encounter TwentyWeeksPlusEncounter)
		{
			IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
			CqlValueSet e_ = this.Hypertension(context);
			bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

			return f_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Risk Variable Long Term Anticoagulant Use")]
	public  IEnumerable<Encounter> Risk_Variable_Long_Term_Anticoagulant_Use(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
		bool? b_(Encounter TwentyWeeksPlusEncounter)
		{
			IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
			CqlValueSet e_ = this.Long_Term_Anticoagulant_Use(context);
			bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

			return f_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Risk Variable Mental Health Disorder")]
	public  IEnumerable<Encounter> Risk_Variable_Mental_Health_Disorder(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
		bool? b_(Encounter TwentyWeeksPlusEncounter)
		{
			IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
			CqlValueSet e_ = this.Mental_Health_Disorder(context);
			bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

			return f_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Risk Variable Multiple Pregnancy")]
	public  IEnumerable<Encounter> Risk_Variable_Multiple_Pregnancy(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
		bool? b_(Encounter TwentyWeeksPlusEncounter)
		{
			IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
			CqlValueSet e_ = this.Multiple_Pregnancy(context);
			bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

			return f_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Risk Variable Neuromuscular")]
	public  IEnumerable<Encounter> Risk_Variable_Neuromuscular(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
		bool? b_(Encounter TwentyWeeksPlusEncounter)
		{
			IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
			CqlValueSet e_ = this.Neuromuscular_Disease(context);
			bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

			return f_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Risk Variable Obstetrical VTE")]
	public  IEnumerable<Encounter> Risk_Variable_Obstetrical_VTE(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
		bool? b_(Encounter TwentyWeeksPlusEncounter)
		{
			IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
			CqlValueSet e_ = this.Venous_Thromboembolism_in_Pregnancy(context);
			bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

			return f_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Risk Variable Placenta Previa")]
	public  IEnumerable<Encounter> Risk_Variable_Placenta_Previa(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
		bool? b_(Encounter TwentyWeeksPlusEncounter)
		{
			IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
			CqlValueSet e_ = this.Placenta_Previa(context);
			bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

			return f_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Risk Variable Placental Abruption")]
	public  IEnumerable<Encounter> Risk_Variable_Placental_Abruption(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
		bool? b_(Encounter TwentyWeeksPlusEncounter)
		{
			IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
			CqlValueSet e_ = this.Placental_Abruption(context);
			bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

			return f_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Risk Variable Placental Accreta Spectrum")]
	public  IEnumerable<Encounter> Risk_Variable_Placental_Accreta_Spectrum(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
		bool? b_(Encounter TwentyWeeksPlusEncounter)
		{
			IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
			CqlValueSet e_ = this.Placental_Accreta_Spectrum(context);
			bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

			return f_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Risk Variable Preexisting Diabetes")]
	public  IEnumerable<Encounter> Risk_Variable_Preexisting_Diabetes(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
		bool? b_(Encounter TwentyWeeksPlusEncounter)
		{
			IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
			CqlValueSet e_ = this.Preexisting_Diabetes(context);
			bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

			return f_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Risk Variable Previous Cesarean")]
	public  IEnumerable<Encounter> Risk_Variable_Previous_Cesarean(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
		bool? b_(Encounter TwentyWeeksPlusEncounter)
		{
			IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
			CqlValueSet e_ = this.Previous_Cesarean(context);
			bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

			return f_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Risk Variable Pulmonary Hypertension")]
	public  IEnumerable<Encounter> Risk_Variable_Pulmonary_Hypertension(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
		bool? b_(Encounter TwentyWeeksPlusEncounter)
		{
			IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
			CqlValueSet e_ = this.Pulmonary_Hypertension(context);
			bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

			return f_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Risk Variable Renal Disease")]
	public  IEnumerable<Encounter> Risk_Variable_Renal_Disease(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
		bool? b_(Encounter TwentyWeeksPlusEncounter)
		{
			IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
			CqlValueSet e_ = this.Renal_Disease(context);
			bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

			return f_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Risk Variable Severe Preeclampsia")]
	public  IEnumerable<Encounter> Risk_Variable_Severe_Preeclampsia(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
		bool? b_(Encounter TwentyWeeksPlusEncounter)
		{
			IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
			CqlValueSet e_ = this.Severe_Preeclampsia(context);
			bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

			return f_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Risk Variable Substance Abuse")]
	public  IEnumerable<Encounter> Risk_Variable_Substance_Abuse(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
		bool? b_(Encounter TwentyWeeksPlusEncounter)
		{
			IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
			CqlValueSet e_ = this.Substance_Abuse(context);
			bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

			return f_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Risk Variable Thyrotoxicosis")]
	public  IEnumerable<Encounter> Risk_Variable_Thyrotoxicosis(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
		bool? b_(Encounter TwentyWeeksPlusEncounter)
		{
			IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
			CqlValueSet e_ = this.Thyrotoxicosis(context);
			bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

			return f_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Risk Variable Other Preeclampsia")]
	public  IEnumerable<Encounter> Risk_Variable_Other_Preeclampsia(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
		bool? b_(Encounter TwentyWeeksPlusEncounter)
		{
			IEnumerable<CqlConcept> d_ = this.pOAIsYesOrExempt(context, TwentyWeeksPlusEncounter);
			CqlValueSet e_ = this.Mild_or_Moderate_Preeclampsia(context);
			bool? f_ = context.Operators.ConceptsInValueSet(d_, e_);

			return f_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Risk Variable Preterm Birth")]
	public  IEnumerable<Encounter> Risk_Variable_Preterm_Birth(CqlContext context)
	{
		IEnumerable<Encounter> a_ = pcMaternal_5_16_000.Delivery_Encounter_with_Age_Range(context);
		bool? b_(Encounter DeliveryEncounter)
		{
			int? h_ = pcMaternal_5_16_000.calculatedGestationalAge(context, DeliveryEncounter);
			CqlInterval<int?> i_ = context.Operators.Interval(20, 36, true, true);
			bool? j_ = context.Operators.In<int?>(h_, i_, default);
			CqlQuantity l_ = pcMaternal_5_16_000.lastEstimatedGestationalAge(context, DeliveryEncounter);
			CqlQuantity m_ = context.Operators.Quantity(20m, "weeks");
			bool? n_ = context.Operators.GreaterOrEqual(l_, m_);
			CqlQuantity p_ = context.Operators.Quantity(36m, "weeks");
			bool? q_ = context.Operators.LessOrEqual(l_, p_);
			bool? r_ = context.Operators.And(n_, q_);
			bool? s_ = context.Operators.And((bool?)(h_ is null), r_);
			bool? t_ = context.Operators.Or(j_, s_);

			return t_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
		bool? e_(Encounter DeliveryEncounter)
		{
			int? u_ = pcMaternal_5_16_000.calculatedGestationalAge(context, DeliveryEncounter);
			CqlQuantity v_ = pcMaternal_5_16_000.lastEstimatedGestationalAge(context, DeliveryEncounter);
			bool? w_ = context.Operators.And((bool?)(u_ is null), (bool?)(v_ is null));
			IEnumerable<CqlConcept> x_ = this.pOAIsYesOrExempt(context, DeliveryEncounter);
			CqlValueSet y_ = this.Preterm_Birth(context);
			bool? z_ = context.Operators.ConceptsInValueSet(x_, y_);
			bool? aa_ = context.Operators.And(w_, z_);

			return aa_;
		};
		IEnumerable<Encounter> f_ = context.Operators.Where<Encounter>(a_, e_);
		IEnumerable<Encounter> g_ = context.Operators.Union<Encounter>(c_, f_);

		return g_;
	}

    [CqlDeclaration("Risk Variable First Hematocrit Lab Test")]
	public  IEnumerable<(string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?> Risk_Variable_First_Hematocrit_Lab_Test(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
		(string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)? b_(Encounter TwentyWeeksPlusEncounter)
		{
			Id d_ = TwentyWeeksPlusEncounter?.IdElement;
			string e_ = d_?.Value;
			CqlValueSet f_ = this.Hematocrit_lab_test(context);
			IEnumerable<Observation> g_ = context.Operators.RetrieveByValueSet<Observation>(f_, default);
			bool? h_(Observation Hematocrit)
			{
				Instant z_ = Hematocrit?.IssuedElement;
				DateTimeOffset? aa_ = z_?.Value;
				CqlDateTime ab_ = context.Operators.Convert<CqlDateTime>(aa_);
				CqlInterval<CqlDateTime> ac_ = pcMaternal_5_16_000.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
				CqlDateTime ad_ = context.Operators.Start(ac_);
				CqlQuantity ae_ = context.Operators.Quantity(1440m, "minutes");
				CqlDateTime af_ = context.Operators.Subtract(ad_, ae_);
				CqlDateTime ag_ = pcMaternal_5_16_000.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
				CqlInterval<CqlDateTime> ah_ = context.Operators.Interval(af_, ag_, true, false);
				bool? ai_ = context.Operators.In<CqlDateTime>(ab_, ah_, default);
				Code<ObservationStatus> aj_ = Hematocrit?.StatusElement;
				ObservationStatus? ak_ = aj_?.Value;
				string al_ = context.Operators.Convert<string>(ak_);
				string[] am_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? an_ = context.Operators.In<string>(al_, am_ as IEnumerable<string>);
				bool? ao_ = context.Operators.And(ai_, an_);
				DataType ap_ = Hematocrit?.Value;
				object aq_ = fhirHelpers_4_3_000.ToValue(context, ap_);
				bool? ar_ = context.Operators.Not((bool?)(aq_ is null));
				bool? as_ = context.Operators.And(ao_, ar_);

				return as_;
			};
			IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);
			object j_(Observation @this)
			{
				Instant at_ = @this?.IssuedElement;
				DateTimeOffset? au_ = at_?.Value;
				CqlDateTime av_ = context.Operators.Convert<CqlDateTime>(au_);
				CqlDateTime aw_ = qiCoreCommon_2_0_000.earliest(context, av_ as object);

				return aw_;
			};
			IEnumerable<Observation> k_ = context.Operators.SortBy<Observation>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
			Observation l_ = context.Operators.First<Observation>(k_);
			DataType m_ = l_?.Value;
			object n_ = fhirHelpers_4_3_000.ToValue(context, m_);
			IEnumerable<Observation> p_ = context.Operators.RetrieveByValueSet<Observation>(f_, default);
			bool? q_(Observation Hematocrit)
			{
				Instant ax_ = Hematocrit?.IssuedElement;
				DateTimeOffset? ay_ = ax_?.Value;
				CqlDateTime az_ = context.Operators.Convert<CqlDateTime>(ay_);
				CqlInterval<CqlDateTime> ba_ = pcMaternal_5_16_000.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
				CqlDateTime bb_ = context.Operators.Start(ba_);
				CqlQuantity bc_ = context.Operators.Quantity(1440m, "minutes");
				CqlDateTime bd_ = context.Operators.Subtract(bb_, bc_);
				CqlDateTime be_ = pcMaternal_5_16_000.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
				CqlInterval<CqlDateTime> bf_ = context.Operators.Interval(bd_, be_, true, false);
				bool? bg_ = context.Operators.In<CqlDateTime>(az_, bf_, default);
				Code<ObservationStatus> bh_ = Hematocrit?.StatusElement;
				ObservationStatus? bi_ = bh_?.Value;
				string bj_ = context.Operators.Convert<string>(bi_);
				string[] bk_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? bl_ = context.Operators.In<string>(bj_, bk_ as IEnumerable<string>);
				bool? bm_ = context.Operators.And(bg_, bl_);
				DataType bn_ = Hematocrit?.Value;
				object bo_ = fhirHelpers_4_3_000.ToValue(context, bn_);
				bool? bp_ = context.Operators.Not((bool?)(bo_ is null));
				bool? bq_ = context.Operators.And(bm_, bp_);

				return bq_;
			};
			IEnumerable<Observation> r_ = context.Operators.Where<Observation>(p_, q_);
			object s_(Observation @this)
			{
				Instant br_ = @this?.IssuedElement;
				DateTimeOffset? bs_ = br_?.Value;
				CqlDateTime bt_ = context.Operators.Convert<CqlDateTime>(bs_);
				CqlDateTime bu_ = qiCoreCommon_2_0_000.earliest(context, bt_ as object);

				return bu_;
			};
			IEnumerable<Observation> t_ = context.Operators.SortBy<Observation>(r_, s_, System.ComponentModel.ListSortDirection.Ascending);
			Observation u_ = context.Operators.First<Observation>(t_);
			Instant v_ = u_?.IssuedElement;
			DateTimeOffset? w_ = v_?.Value;
			CqlDateTime x_ = context.Operators.Convert<CqlDateTime>(w_);
			(string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)? y_ = (e_, n_ as CqlQuantity, x_);

			return y_;
		};
		IEnumerable<(string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?> c_ = context.Operators.Select<Encounter, (string EncounterId, CqlQuantity FirstHematocritResult, CqlDateTime Timing)?>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Risk Variable First White Blood Cell Count Lab Test")]
	public  IEnumerable<(string EncounterId, CqlQuantity FirstWBCResult, CqlDateTime Timing)?> Risk_Variable_First_White_Blood_Cell_Count_Lab_Test(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
		(string EncounterId, CqlQuantity FirstWBCResult, CqlDateTime Timing)? b_(Encounter TwentyWeeksPlusEncounter)
		{
			Id d_ = TwentyWeeksPlusEncounter?.IdElement;
			string e_ = d_?.Value;
			CqlValueSet f_ = this.White_blood_cells_count_lab_test(context);
			IEnumerable<Observation> g_ = context.Operators.RetrieveByValueSet<Observation>(f_, default);
			bool? h_(Observation WBC)
			{
				Instant z_ = WBC?.IssuedElement;
				DateTimeOffset? aa_ = z_?.Value;
				CqlDateTime ab_ = context.Operators.Convert<CqlDateTime>(aa_);
				CqlInterval<CqlDateTime> ac_ = pcMaternal_5_16_000.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
				CqlDateTime ad_ = context.Operators.Start(ac_);
				CqlQuantity ae_ = context.Operators.Quantity(1440m, "minutes");
				CqlDateTime af_ = context.Operators.Subtract(ad_, ae_);
				CqlDateTime ag_ = pcMaternal_5_16_000.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
				CqlInterval<CqlDateTime> ah_ = context.Operators.Interval(af_, ag_, true, false);
				bool? ai_ = context.Operators.In<CqlDateTime>(ab_, ah_, default);
				Code<ObservationStatus> aj_ = WBC?.StatusElement;
				ObservationStatus? ak_ = aj_?.Value;
				string al_ = context.Operators.Convert<string>(ak_);
				string[] am_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? an_ = context.Operators.In<string>(al_, am_ as IEnumerable<string>);
				bool? ao_ = context.Operators.And(ai_, an_);
				DataType ap_ = WBC?.Value;
				object aq_ = fhirHelpers_4_3_000.ToValue(context, ap_);
				bool? ar_ = context.Operators.Not((bool?)(aq_ is null));
				bool? as_ = context.Operators.And(ao_, ar_);

				return as_;
			};
			IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);
			object j_(Observation @this)
			{
				Instant at_ = @this?.IssuedElement;
				DateTimeOffset? au_ = at_?.Value;
				CqlDateTime av_ = context.Operators.Convert<CqlDateTime>(au_);
				CqlDateTime aw_ = qiCoreCommon_2_0_000.earliest(context, av_ as object);

				return aw_;
			};
			IEnumerable<Observation> k_ = context.Operators.SortBy<Observation>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
			Observation l_ = context.Operators.First<Observation>(k_);
			DataType m_ = l_?.Value;
			object n_ = fhirHelpers_4_3_000.ToValue(context, m_);
			IEnumerable<Observation> p_ = context.Operators.RetrieveByValueSet<Observation>(f_, default);
			bool? q_(Observation WBC)
			{
				Instant ax_ = WBC?.IssuedElement;
				DateTimeOffset? ay_ = ax_?.Value;
				CqlDateTime az_ = context.Operators.Convert<CqlDateTime>(ay_);
				CqlInterval<CqlDateTime> ba_ = pcMaternal_5_16_000.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
				CqlDateTime bb_ = context.Operators.Start(ba_);
				CqlQuantity bc_ = context.Operators.Quantity(1440m, "minutes");
				CqlDateTime bd_ = context.Operators.Subtract(bb_, bc_);
				CqlDateTime be_ = pcMaternal_5_16_000.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
				CqlInterval<CqlDateTime> bf_ = context.Operators.Interval(bd_, be_, true, false);
				bool? bg_ = context.Operators.In<CqlDateTime>(az_, bf_, default);
				Code<ObservationStatus> bh_ = WBC?.StatusElement;
				ObservationStatus? bi_ = bh_?.Value;
				string bj_ = context.Operators.Convert<string>(bi_);
				string[] bk_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? bl_ = context.Operators.In<string>(bj_, bk_ as IEnumerable<string>);
				bool? bm_ = context.Operators.And(bg_, bl_);
				DataType bn_ = WBC?.Value;
				object bo_ = fhirHelpers_4_3_000.ToValue(context, bn_);
				bool? bp_ = context.Operators.Not((bool?)(bo_ is null));
				bool? bq_ = context.Operators.And(bm_, bp_);

				return bq_;
			};
			IEnumerable<Observation> r_ = context.Operators.Where<Observation>(p_, q_);
			object s_(Observation @this)
			{
				Instant br_ = @this?.IssuedElement;
				DateTimeOffset? bs_ = br_?.Value;
				CqlDateTime bt_ = context.Operators.Convert<CqlDateTime>(bs_);
				CqlDateTime bu_ = qiCoreCommon_2_0_000.earliest(context, bt_ as object);

				return bu_;
			};
			IEnumerable<Observation> t_ = context.Operators.SortBy<Observation>(r_, s_, System.ComponentModel.ListSortDirection.Ascending);
			Observation u_ = context.Operators.First<Observation>(t_);
			Instant v_ = u_?.IssuedElement;
			DateTimeOffset? w_ = v_?.Value;
			CqlDateTime x_ = context.Operators.Convert<CqlDateTime>(w_);
			(string EncounterId, CqlQuantity FirstWBCResult, CqlDateTime Timing)? y_ = (e_, n_ as CqlQuantity, x_);

			return y_;
		};
		IEnumerable<(string EncounterId, CqlQuantity FirstWBCResult, CqlDateTime Timing)?> c_ = context.Operators.Select<Encounter, (string EncounterId, CqlQuantity FirstWBCResult, CqlDateTime Timing)?>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Risk Variable Heart Rate")]
	public  IEnumerable<(string EncounterId, CqlQuantity FirstHRResult, CqlDateTime Timing)?> Risk_Variable_Heart_Rate(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
		(string EncounterId, CqlQuantity FirstHRResult, CqlDateTime Timing)? b_(Encounter TwentyWeeksPlusEncounter)
		{
			Id d_ = TwentyWeeksPlusEncounter?.IdElement;
			string e_ = d_?.Value;
			IEnumerable<Observation> f_ = context.Operators.RetrieveByValueSet<Observation>(default, default);
			bool? g_(Observation HeartRate)
			{
				DataType x_ = HeartRate?.Effective;
				object y_ = fhirHelpers_4_3_000.ToValue(context, x_);
				CqlDateTime z_ = qiCoreCommon_2_0_000.earliest(context, y_);
				CqlInterval<CqlDateTime> aa_ = pcMaternal_5_16_000.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
				CqlDateTime ab_ = context.Operators.Start(aa_);
				CqlQuantity ac_ = context.Operators.Quantity(1440m, "minutes");
				CqlDateTime ad_ = context.Operators.Subtract(ab_, ac_);
				CqlDateTime ae_ = pcMaternal_5_16_000.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
				CqlInterval<CqlDateTime> af_ = context.Operators.Interval(ad_, ae_, true, false);
				bool? ag_ = context.Operators.In<CqlDateTime>(z_, af_, default);
				Code<ObservationStatus> ah_ = HeartRate?.StatusElement;
				ObservationStatus? ai_ = ah_?.Value;
				string aj_ = context.Operators.Convert<string>(ai_);
				string[] ak_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? al_ = context.Operators.In<string>(aj_, ak_ as IEnumerable<string>);
				bool? am_ = context.Operators.And(ag_, al_);

				return am_;
			};
			IEnumerable<Observation> h_ = context.Operators.Where<Observation>(f_, g_);
			object i_(Observation @this)
			{
				DataType an_ = @this?.Effective;
				object ao_ = fhirHelpers_4_3_000.ToValue(context, an_);
				CqlDateTime ap_ = qiCoreCommon_2_0_000.earliest(context, ao_);

				return ap_;
			};
			IEnumerable<Observation> j_ = context.Operators.SortBy<Observation>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
			Observation k_ = context.Operators.First<Observation>(j_);
			DataType l_ = k_?.Value;
			CqlQuantity m_ = fhirHelpers_4_3_000.ToQuantity(context, l_ as Quantity);
			bool? o_(Observation HeartRate)
			{
				DataType aq_ = HeartRate?.Effective;
				object ar_ = fhirHelpers_4_3_000.ToValue(context, aq_);
				CqlDateTime as_ = qiCoreCommon_2_0_000.earliest(context, ar_);
				CqlInterval<CqlDateTime> at_ = pcMaternal_5_16_000.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
				CqlDateTime au_ = context.Operators.Start(at_);
				CqlQuantity av_ = context.Operators.Quantity(1440m, "minutes");
				CqlDateTime aw_ = context.Operators.Subtract(au_, av_);
				CqlDateTime ax_ = pcMaternal_5_16_000.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
				CqlInterval<CqlDateTime> ay_ = context.Operators.Interval(aw_, ax_, true, false);
				bool? az_ = context.Operators.In<CqlDateTime>(as_, ay_, default);
				Code<ObservationStatus> ba_ = HeartRate?.StatusElement;
				ObservationStatus? bb_ = ba_?.Value;
				string bc_ = context.Operators.Convert<string>(bb_);
				string[] bd_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? be_ = context.Operators.In<string>(bc_, bd_ as IEnumerable<string>);
				bool? bf_ = context.Operators.And(az_, be_);

				return bf_;
			};
			IEnumerable<Observation> p_ = context.Operators.Where<Observation>(f_, o_);
			object q_(Observation @this)
			{
				DataType bg_ = @this?.Effective;
				object bh_ = fhirHelpers_4_3_000.ToValue(context, bg_);
				CqlDateTime bi_ = qiCoreCommon_2_0_000.earliest(context, bh_);

				return bi_;
			};
			IEnumerable<Observation> r_ = context.Operators.SortBy<Observation>(p_, q_, System.ComponentModel.ListSortDirection.Ascending);
			Observation s_ = context.Operators.First<Observation>(r_);
			DataType t_ = s_?.Effective;
			object u_ = fhirHelpers_4_3_000.ToValue(context, t_);
			CqlDateTime v_ = qiCoreCommon_2_0_000.earliest(context, u_);
			(string EncounterId, CqlQuantity FirstHRResult, CqlDateTime Timing)? w_ = (e_, m_ as CqlQuantity, v_);

			return w_;
		};
		IEnumerable<(string EncounterId, CqlQuantity FirstHRResult, CqlDateTime Timing)?> c_ = context.Operators.Select<Encounter, (string EncounterId, CqlQuantity FirstHRResult, CqlDateTime Timing)?>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Risk Variable Systolic Blood Pressure")]
	public  IEnumerable<(string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)?> Risk_Variable_Systolic_Blood_Pressure(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounters_At_Greater_than_or_Equal_to_20_Weeks_Gestation(context);
		(string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)? b_(Encounter TwentyWeeksPlusEncounter)
		{
			Id d_ = TwentyWeeksPlusEncounter?.IdElement;
			string e_ = d_?.Value;
			IEnumerable<Observation> f_ = context.Operators.RetrieveByValueSet<Observation>(default, default);
			bool? g_(Observation BP)
			{
				DataType aa_ = BP?.Effective;
				object ab_ = fhirHelpers_4_3_000.ToValue(context, aa_);
				CqlDateTime ac_ = qiCoreCommon_2_0_000.earliest(context, ab_);
				CqlInterval<CqlDateTime> ad_ = pcMaternal_5_16_000.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
				CqlDateTime ae_ = context.Operators.Start(ad_);
				CqlQuantity af_ = context.Operators.Quantity(1440m, "minutes");
				CqlDateTime ag_ = context.Operators.Subtract(ae_, af_);
				CqlDateTime ah_ = pcMaternal_5_16_000.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
				CqlInterval<CqlDateTime> ai_ = context.Operators.Interval(ag_, ah_, true, false);
				bool? aj_ = context.Operators.In<CqlDateTime>(ac_, ai_, default);
				Code<ObservationStatus> ak_ = BP?.StatusElement;
				ObservationStatus? al_ = ak_?.Value;
				string am_ = context.Operators.Convert<string>(al_);
				string[] an_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? ao_ = context.Operators.In<string>(am_, an_ as IEnumerable<string>);
				bool? ap_ = context.Operators.And(aj_, ao_);

				return ap_;
			};
			IEnumerable<Observation> h_ = context.Operators.Where<Observation>(f_, g_);
			object i_(Observation @this)
			{
				DataType aq_ = @this?.Effective;
				object ar_ = fhirHelpers_4_3_000.ToValue(context, aq_);
				CqlDateTime as_ = qiCoreCommon_2_0_000.earliest(context, ar_);

				return as_;
			};
			IEnumerable<Observation> j_ = context.Operators.SortBy<Observation>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
			Observation k_ = context.Operators.First<Observation>(j_);
			List<Observation.ComponentComponent> l_ = k_?.Component;
			bool? m_(Observation.ComponentComponent C)
			{
				CodeableConcept at_ = C?.Code;
				CqlConcept au_ = fhirHelpers_4_3_000.ToConcept(context, at_);
				CqlCode av_ = this.Systolic_blood_pressure(context);
				CqlConcept aw_ = context.Operators.ConvertCodeToConcept(av_);
				bool? ax_ = context.Operators.Equivalent(au_, aw_);

				return ax_;
			};
			IEnumerable<Observation.ComponentComponent> n_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)l_, m_);
			CqlQuantity o_(Observation.ComponentComponent C)
			{
				DataType ay_ = C?.Value;
				object az_ = fhirHelpers_4_3_000.ToValue(context, ay_);

				return az_ as CqlQuantity;
			};
			IEnumerable<CqlQuantity> p_ = context.Operators.Select<Observation.ComponentComponent, CqlQuantity>(n_, o_);
			bool? r_(Observation BP)
			{
				DataType ba_ = BP?.Effective;
				object bb_ = fhirHelpers_4_3_000.ToValue(context, ba_);
				CqlDateTime bc_ = qiCoreCommon_2_0_000.earliest(context, bb_);
				CqlInterval<CqlDateTime> bd_ = pcMaternal_5_16_000.hospitalizationWithEDOBTriageObservation(context, TwentyWeeksPlusEncounter);
				CqlDateTime be_ = context.Operators.Start(bd_);
				CqlQuantity bf_ = context.Operators.Quantity(1440m, "minutes");
				CqlDateTime bg_ = context.Operators.Subtract(be_, bf_);
				CqlDateTime bh_ = pcMaternal_5_16_000.lastTimeOfDelivery(context, TwentyWeeksPlusEncounter);
				CqlInterval<CqlDateTime> bi_ = context.Operators.Interval(bg_, bh_, true, false);
				bool? bj_ = context.Operators.In<CqlDateTime>(bc_, bi_, default);
				Code<ObservationStatus> bk_ = BP?.StatusElement;
				ObservationStatus? bl_ = bk_?.Value;
				string bm_ = context.Operators.Convert<string>(bl_);
				string[] bn_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? bo_ = context.Operators.In<string>(bm_, bn_ as IEnumerable<string>);
				bool? bp_ = context.Operators.And(bj_, bo_);

				return bp_;
			};
			IEnumerable<Observation> s_ = context.Operators.Where<Observation>(f_, r_);
			object t_(Observation @this)
			{
				DataType bq_ = @this?.Effective;
				object br_ = fhirHelpers_4_3_000.ToValue(context, bq_);
				CqlDateTime bs_ = qiCoreCommon_2_0_000.earliest(context, br_);

				return bs_;
			};
			IEnumerable<Observation> u_ = context.Operators.SortBy<Observation>(s_, t_, System.ComponentModel.ListSortDirection.Ascending);
			Observation v_ = context.Operators.First<Observation>(u_);
			DataType w_ = v_?.Effective;
			object x_ = fhirHelpers_4_3_000.ToValue(context, w_);
			CqlDateTime y_ = qiCoreCommon_2_0_000.earliest(context, x_);
			(string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)? z_ = (e_, p_, y_);

			return z_;
		};
		IEnumerable<(string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)?> c_ = context.Operators.Select<Encounter, (string EncounterId, IEnumerable<CqlQuantity> FirstSBPResult, CqlDateTime Timing)?>(a_, b_);

		return c_;
	}

    [CqlDeclaration("pOAIsNoOrUTD")]
	public  IEnumerable<CqlConcept> pOAIsNoOrUTD(CqlContext context, Encounter TheEncounter)
	{
		List<Encounter.DiagnosisComponent> a_ = TheEncounter?.Diagnosis;
		bool? b_(Encounter.DiagnosisComponent EncounterDiagnoses)
		{
			bool? f_(Extension @this)
			{
				string n_ = @this?.Url;
				FhirString o_ = context.Operators.Convert<FhirString>(n_);
				string p_ = fhirHelpers_4_3_000.ToString(context, o_);
				bool? q_ = context.Operators.Equal(p_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

				return q_;
			};
			IEnumerable<Extension> g_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(EncounterDiagnoses is Element
					? (EncounterDiagnoses as Element).Extension
					: default), f_);
			object h_(Extension @this)
			{
				DataType r_ = @this?.Value;

				return r_;
			};
			IEnumerable<object> i_ = context.Operators.Select<Extension, object>(g_, h_);
			object j_ = context.Operators.SingletonFrom<object>(i_);
			CqlConcept k_ = fhirHelpers_4_3_000.ToConcept(context, j_ as CodeableConcept);
			CqlValueSet l_ = this.Present_on_Admission_is_No_or_Unable_To_Determine(context);
			bool? m_ = context.Operators.ConceptInValueSet(k_, l_);

			return m_;
		};
		IEnumerable<Encounter.DiagnosisComponent> c_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)a_, b_);
		CqlConcept d_(Encounter.DiagnosisComponent EncounterDiagnoses)
		{
			ResourceReference s_ = EncounterDiagnoses?.Condition;
			Condition t_ = cqmCommon_2_0_000.getCondition(context, s_);
			CodeableConcept u_ = t_?.Code;
			CqlConcept v_ = fhirHelpers_4_3_000.ToConcept(context, u_);

			return v_;
		};
		IEnumerable<CqlConcept> e_ = context.Operators.Select<Encounter.DiagnosisComponent, CqlConcept>(c_, d_);

		return e_;
	}

}
