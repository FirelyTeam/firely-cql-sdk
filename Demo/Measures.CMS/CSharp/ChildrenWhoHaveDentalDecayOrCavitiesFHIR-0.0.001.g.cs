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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.5.0")]
[CqlLibrary("ChildrenWhoHaveDentalDecayOrCavitiesFHIR", "0.0.001")]
public partial class ChildrenWhoHaveDentalDecayOrCavitiesFHIR_0_0_001 : ILibrary, ISingleton<ChildrenWhoHaveDentalDecayOrCavitiesFHIR_0_0_001>
{
    private ChildrenWhoHaveDentalDecayOrCavitiesFHIR_0_0_001() {}

    public static ChildrenWhoHaveDentalDecayOrCavitiesFHIR_0_0_001 Instance { get; } = new();

    #region Library Members
    public string Name => "ChildrenWhoHaveDentalDecayOrCavitiesFHIR";
    public string Version => "0.0.001";
    public ILibrary[] Dependencies => [QICoreCommon_2_0_000.Instance, FHIRHelpers_4_3_000.Instance, SupplementalDataElements_3_4_000.Instance, Hospice_6_9_000.Instance, Status_1_6_000.Instance];
    #endregion Library Members

    [CqlDeclaration("Clinical Oral Evaluation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.125.12.1003")]
	public CqlValueSet Clinical_Oral_Evaluation(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.125.12.1003", default);


    [CqlDeclaration("Dental Caries")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.125.12.1004")]
	public CqlValueSet Dental_Caries(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.125.12.1004", default);


    [CqlDeclaration("Discharged to Health Care Facility for Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207")]
	public CqlValueSet Discharged_to_Health_Care_Facility_for_Hospice_Care(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207", default);


    [CqlDeclaration("Discharged to Home for Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209")]
	public CqlValueSet Discharged_to_Home_for_Hospice_Care(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209", default);


    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
	public CqlValueSet Encounter_Inpatient(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", default);


    [CqlDeclaration("Hospice care ambulatory")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15")]
	public CqlValueSet Hospice_care_ambulatory(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15", default);


    [CqlDeclaration("Discharge to healthcare facility for hospice care (procedure)")]
	public CqlCode Discharge_to_healthcare_facility_for_hospice_care__procedure_(CqlContext context) => 
		new CqlCode("428371000124100", "http://snomed.info/sct", default, default);


    [CqlDeclaration("Discharge to home for hospice care (procedure)")]
	public CqlCode Discharge_to_home_for_hospice_care__procedure_(CqlContext context) => 
		new CqlCode("428361000124107", "http://snomed.info/sct", default, default);


    [CqlDeclaration("Hospice care [Minimum Data Set]")]
	public CqlCode Hospice_care__Minimum_Data_Set_(CqlContext context) => 
		new CqlCode("45755-6", "http://loinc.org", default, default);


    [CqlDeclaration("Yes (qualifier value)")]
	public CqlCode Yes__qualifier_value_(CqlContext context) => 
		new CqlCode("373066001", "http://snomed.info/sct", default, default);


    [CqlDeclaration("LOINC")]
	public CqlCode[] LOINC(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("45755-6", "http://loinc.org", default, default),
		];

		return a_;
	}


    [CqlDeclaration("SNOMEDCT")]
	public CqlCode[] SNOMEDCT(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("428371000124100", "http://snomed.info/sct", default, default),
			new CqlCode("428361000124107", "http://snomed.info/sct", default, default),
			new CqlCode("373066001", "http://snomed.info/sct", default, default),
		];

		return a_;
	}


    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
	{
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("ChildrenWhoHaveDentalDecayOrCavitiesFHIR-0.0.001", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
	}


    [CqlDeclaration("Patient")]
	public Patient Patient(CqlContext context)
	{
		IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}


    [CqlDeclaration("Qualifying Encounters")]
	public IEnumerable<Encounter> Qualifying_Encounters(CqlContext context)
	{
		CqlValueSet a_ = this.Clinical_Oral_Evaluation(context);
		IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> c_ = Status_1_6_000.Instance.isEncounterPerformed(context, b_);
		bool? d_(Encounter ValidEncounter)
		{
			CqlInterval<CqlDateTime> f_ = this.Measurement_Period(context);
			Period g_ = ValidEncounter?.Period;
			CqlInterval<CqlDateTime> h_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, g_);
			bool? i_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(f_, h_, "day");

			return i_;
		};
		IEnumerable<Encounter> e_ = context.Operators.Where<Encounter>(c_, d_);

		return e_;
	}


    [CqlDeclaration("Initial Population")]
	public bool? Initial_Population(CqlContext context)
	{
		Patient a_ = this.Patient(context);
		Date b_ = a_?.BirthDateElement;
		string c_ = b_?.Value;
		CqlDate d_ = context.Operators.ConvertStringToDate(c_);
		CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
		CqlDateTime f_ = context.Operators.Start(e_);
		CqlDate g_ = context.Operators.DateFrom(f_);
		int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
		CqlInterval<int?> i_ = context.Operators.Interval(1, 20, true, true);
		bool? j_ = context.Operators.In<int?>(h_, i_, default);
		IEnumerable<Encounter> k_ = this.Qualifying_Encounters(context);
		bool? l_ = context.Operators.Exists<Encounter>(k_);
		bool? m_ = context.Operators.And(j_, l_);

		return m_;
	}


    [CqlDeclaration("Denominator")]
	public bool? Denominator(CqlContext context)
	{
		bool? a_ = this.Initial_Population(context);

		return a_;
	}


    [CqlDeclaration("Denominator Exclusions")]
	public bool? Denominator_Exclusions(CqlContext context)
	{
		bool? a_ = Hospice_6_9_000.Instance.Has_Hospice_Services(context);

		return a_;
	}


    [CqlDeclaration("Numerator")]
	public bool? Numerator(CqlContext context)
	{
		CqlValueSet a_ = this.Dental_Caries(context);
		IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		bool? c_(Condition DentalCaries)
		{
			CqlInterval<CqlDateTime> f_ = QICoreCommon_2_0_000.Instance.prevalenceInterval(context, DentalCaries);
			CqlInterval<CqlDateTime> g_ = this.Measurement_Period(context);
			bool? h_ = context.Operators.Overlaps(f_, g_, default);

			return h_;
		};
		IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
		bool? e_ = context.Operators.Exists<Condition>(d_);

		return e_;
	}


    [CqlDeclaration("SDE Ethnicity")]
	public (IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
	{
		(IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_4_000.Instance.SDE_Ethnicity(context);

		return a_;
	}


    [CqlDeclaration("SDE Payer")]
	public IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
	{
		IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_3_4_000.Instance.SDE_Payer(context);

		return a_;
	}


    [CqlDeclaration("SDE Race")]
	public (IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
	{
		(IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_4_000.Instance.SDE_Race(context);

		return a_;
	}


    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex(CqlContext context)
	{
		CqlCode a_ = SupplementalDataElements_3_4_000.Instance.SDE_Sex(context);

		return a_;
	}

}
