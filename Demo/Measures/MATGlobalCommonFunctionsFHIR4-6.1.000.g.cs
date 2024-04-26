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
[CqlLibrary("MATGlobalCommonFunctionsFHIR4", "6.1.000")]
public class MATGlobalCommonFunctionsFHIR4_6_1_000
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Emergency_Department_Visit;
    internal Lazy<CqlValueSet> __Encounter_Inpatient;
    internal Lazy<CqlValueSet> __Observation_Services;
    internal Lazy<CqlValueSet> __Present_on_Admission_or_Clinically_Undetermined;
    internal Lazy<CqlCode> __active;
    internal Lazy<CqlCode> __allergy_active;
    internal Lazy<CqlCode> __allergy_confirmed;
    internal Lazy<CqlCode> __allergy_inactive;
    internal Lazy<CqlCode> __allergy_refuted;
    internal Lazy<CqlCode> __allergy_resolved;
    internal Lazy<CqlCode> __allergy_unconfirmed;
    internal Lazy<CqlCode> __Billing;
    internal Lazy<CqlCode> __Birthdate;
    internal Lazy<CqlCode> __Community;
    internal Lazy<CqlCode> __confirmed;
    internal Lazy<CqlCode> __Dead;
    internal Lazy<CqlCode> __differential;
    internal Lazy<CqlCode> __Discharge;
    internal Lazy<CqlCode> __entered_in_error;
    internal Lazy<CqlCode> __ER;
    internal Lazy<CqlCode> __ICU;
    internal Lazy<CqlCode> __inactive;
    internal Lazy<CqlCode> __provisional;
    internal Lazy<CqlCode> __recurrence;
    internal Lazy<CqlCode> __refuted;
    internal Lazy<CqlCode> __relapse;
    internal Lazy<CqlCode> __remission;
    internal Lazy<CqlCode> __resolved;
    internal Lazy<CqlCode> __unconfirmed;
    internal Lazy<CqlCode[]> __ConditionClinicalStatusCodes;
    internal Lazy<CqlCode[]> __AllergyIntoleranceClinicalStatusCodes;
    internal Lazy<CqlCode[]> __AllergyIntoleranceVerificationStatusCodes;
    internal Lazy<CqlCode[]> __Diagnosis_Role;
    internal Lazy<CqlCode[]> __LOINC;
    internal Lazy<CqlCode[]> __MedicationRequestCategory;
    internal Lazy<CqlCode[]> __ConditionVerificationStatusCodes;
    internal Lazy<CqlCode[]> __SNOMEDCT;
    internal Lazy<CqlCode[]> __RoleCode;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<IEnumerable<Encounter>> __Inpatient_Encounter;

    #endregion
    public MATGlobalCommonFunctionsFHIR4_6_1_000(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_0_001 = new FHIRHelpers_4_0_001(context);

        __Emergency_Department_Visit = new Lazy<CqlValueSet>(this.Emergency_Department_Visit_Value);
        __Encounter_Inpatient = new Lazy<CqlValueSet>(this.Encounter_Inpatient_Value);
        __Observation_Services = new Lazy<CqlValueSet>(this.Observation_Services_Value);
        __Present_on_Admission_or_Clinically_Undetermined = new Lazy<CqlValueSet>(this.Present_on_Admission_or_Clinically_Undetermined_Value);
        __active = new Lazy<CqlCode>(this.active_Value);
        __allergy_active = new Lazy<CqlCode>(this.allergy_active_Value);
        __allergy_confirmed = new Lazy<CqlCode>(this.allergy_confirmed_Value);
        __allergy_inactive = new Lazy<CqlCode>(this.allergy_inactive_Value);
        __allergy_refuted = new Lazy<CqlCode>(this.allergy_refuted_Value);
        __allergy_resolved = new Lazy<CqlCode>(this.allergy_resolved_Value);
        __allergy_unconfirmed = new Lazy<CqlCode>(this.allergy_unconfirmed_Value);
        __Billing = new Lazy<CqlCode>(this.Billing_Value);
        __Birthdate = new Lazy<CqlCode>(this.Birthdate_Value);
        __Community = new Lazy<CqlCode>(this.Community_Value);
        __confirmed = new Lazy<CqlCode>(this.confirmed_Value);
        __Dead = new Lazy<CqlCode>(this.Dead_Value);
        __differential = new Lazy<CqlCode>(this.differential_Value);
        __Discharge = new Lazy<CqlCode>(this.Discharge_Value);
        __entered_in_error = new Lazy<CqlCode>(this.entered_in_error_Value);
        __ER = new Lazy<CqlCode>(this.ER_Value);
        __ICU = new Lazy<CqlCode>(this.ICU_Value);
        __inactive = new Lazy<CqlCode>(this.inactive_Value);
        __provisional = new Lazy<CqlCode>(this.provisional_Value);
        __recurrence = new Lazy<CqlCode>(this.recurrence_Value);
        __refuted = new Lazy<CqlCode>(this.refuted_Value);
        __relapse = new Lazy<CqlCode>(this.relapse_Value);
        __remission = new Lazy<CqlCode>(this.remission_Value);
        __resolved = new Lazy<CqlCode>(this.resolved_Value);
        __unconfirmed = new Lazy<CqlCode>(this.unconfirmed_Value);
        __ConditionClinicalStatusCodes = new Lazy<CqlCode[]>(this.ConditionClinicalStatusCodes_Value);
        __AllergyIntoleranceClinicalStatusCodes = new Lazy<CqlCode[]>(this.AllergyIntoleranceClinicalStatusCodes_Value);
        __AllergyIntoleranceVerificationStatusCodes = new Lazy<CqlCode[]>(this.AllergyIntoleranceVerificationStatusCodes_Value);
        __Diagnosis_Role = new Lazy<CqlCode[]>(this.Diagnosis_Role_Value);
        __LOINC = new Lazy<CqlCode[]>(this.LOINC_Value);
        __MedicationRequestCategory = new Lazy<CqlCode[]>(this.MedicationRequestCategory_Value);
        __ConditionVerificationStatusCodes = new Lazy<CqlCode[]>(this.ConditionVerificationStatusCodes_Value);
        __SNOMEDCT = new Lazy<CqlCode[]>(this.SNOMEDCT_Value);
        __RoleCode = new Lazy<CqlCode[]>(this.RoleCode_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __Inpatient_Encounter = new Lazy<IEnumerable<Encounter>>(this.Inpatient_Encounter_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_0_001 FHIRHelpers_4_0_001 { get; }

    #endregion

	private CqlValueSet Emergency_Department_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", null);

    [CqlDeclaration("Emergency Department Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292")]
	public CqlValueSet Emergency_Department_Visit() => 
		__Emergency_Department_Visit.Value;

	private CqlValueSet Encounter_Inpatient_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
	public CqlValueSet Encounter_Inpatient() => 
		__Encounter_Inpatient.Value;

	private CqlValueSet Observation_Services_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", null);

    [CqlDeclaration("Observation Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143")]
	public CqlValueSet Observation_Services() => 
		__Observation_Services.Value;

	private CqlValueSet Present_on_Admission_or_Clinically_Undetermined_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.197", null);

    [CqlDeclaration("Present on Admission or Clinically Undetermined")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.197")]
	public CqlValueSet Present_on_Admission_or_Clinically_Undetermined() => 
		__Present_on_Admission_or_Clinically_Undetermined.Value;

	private CqlCode active_Value() => 
		new CqlCode("active", "http://terminology.hl7.org/CodeSystem/condition-clinical", null, null);

    [CqlDeclaration("active")]
	public CqlCode active() => 
		__active.Value;

	private CqlCode allergy_active_Value() => 
		new CqlCode("active", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", null, null);

    [CqlDeclaration("allergy-active")]
	public CqlCode allergy_active() => 
		__allergy_active.Value;

	private CqlCode allergy_confirmed_Value() => 
		new CqlCode("confirmed", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", null, null);

    [CqlDeclaration("allergy-confirmed")]
	public CqlCode allergy_confirmed() => 
		__allergy_confirmed.Value;

	private CqlCode allergy_inactive_Value() => 
		new CqlCode("inactive", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", null, null);

    [CqlDeclaration("allergy-inactive")]
	public CqlCode allergy_inactive() => 
		__allergy_inactive.Value;

	private CqlCode allergy_refuted_Value() => 
		new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", null, null);

    [CqlDeclaration("allergy-refuted")]
	public CqlCode allergy_refuted() => 
		__allergy_refuted.Value;

	private CqlCode allergy_resolved_Value() => 
		new CqlCode("resolved", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", null, null);

    [CqlDeclaration("allergy-resolved")]
	public CqlCode allergy_resolved() => 
		__allergy_resolved.Value;

	private CqlCode allergy_unconfirmed_Value() => 
		new CqlCode("unconfirmed", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", null, null);

    [CqlDeclaration("allergy-unconfirmed")]
	public CqlCode allergy_unconfirmed() => 
		__allergy_unconfirmed.Value;

	private CqlCode Billing_Value() => 
		new CqlCode("billing", "http://terminology.hl7.org/CodeSystem/diagnosis-role", null, null);

    [CqlDeclaration("Billing")]
	public CqlCode Billing() => 
		__Billing.Value;

	private CqlCode Birthdate_Value() => 
		new CqlCode("21112-8", "http://loinc.org", null, null);

    [CqlDeclaration("Birthdate")]
	public CqlCode Birthdate() => 
		__Birthdate.Value;

	private CqlCode Community_Value() => 
		new CqlCode("community", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", null, null);

    [CqlDeclaration("Community")]
	public CqlCode Community() => 
		__Community.Value;

	private CqlCode confirmed_Value() => 
		new CqlCode("confirmed", "http://terminology.hl7.org/CodeSystem/condition-ver-status", null, null);

    [CqlDeclaration("confirmed")]
	public CqlCode confirmed() => 
		__confirmed.Value;

	private CqlCode Dead_Value() => 
		new CqlCode("419099009", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Dead")]
	public CqlCode Dead() => 
		__Dead.Value;

	private CqlCode differential_Value() => 
		new CqlCode("differential", "http://terminology.hl7.org/CodeSystem/condition-ver-status", null, null);

    [CqlDeclaration("differential")]
	public CqlCode differential() => 
		__differential.Value;

	private CqlCode Discharge_Value() => 
		new CqlCode("discharge", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", null, null);

    [CqlDeclaration("Discharge")]
	public CqlCode Discharge() => 
		__Discharge.Value;

	private CqlCode entered_in_error_Value() => 
		new CqlCode("entered-in-error", "http://terminology.hl7.org/CodeSystem/condition-ver-status", null, null);

    [CqlDeclaration("entered-in-error")]
	public CqlCode entered_in_error() => 
		__entered_in_error.Value;

	private CqlCode ER_Value() => 
		new CqlCode("ER", "http://terminology.hl7.org/CodeSystem/v3-RoleCode", null, null);

    [CqlDeclaration("ER")]
	public CqlCode ER() => 
		__ER.Value;

	private CqlCode ICU_Value() => 
		new CqlCode("ICU", "http://terminology.hl7.org/CodeSystem/v3-RoleCode", null, null);

    [CqlDeclaration("ICU")]
	public CqlCode ICU() => 
		__ICU.Value;

	private CqlCode inactive_Value() => 
		new CqlCode("inactive", "http://terminology.hl7.org/CodeSystem/condition-clinical", null, null);

    [CqlDeclaration("inactive")]
	public CqlCode inactive() => 
		__inactive.Value;

	private CqlCode provisional_Value() => 
		new CqlCode("provisional", "http://terminology.hl7.org/CodeSystem/condition-ver-status", null, null);

    [CqlDeclaration("provisional")]
	public CqlCode provisional() => 
		__provisional.Value;

	private CqlCode recurrence_Value() => 
		new CqlCode("recurrence", "http://terminology.hl7.org/CodeSystem/condition-clinical", null, null);

    [CqlDeclaration("recurrence")]
	public CqlCode recurrence() => 
		__recurrence.Value;

	private CqlCode refuted_Value() => 
		new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/condition-ver-status", null, null);

    [CqlDeclaration("refuted")]
	public CqlCode refuted() => 
		__refuted.Value;

	private CqlCode relapse_Value() => 
		new CqlCode("relapse", "http://terminology.hl7.org/CodeSystem/condition-clinical", null, null);

    [CqlDeclaration("relapse")]
	public CqlCode relapse() => 
		__relapse.Value;

	private CqlCode remission_Value() => 
		new CqlCode("remission", "http://terminology.hl7.org/CodeSystem/condition-clinical", null, null);

    [CqlDeclaration("remission")]
	public CqlCode remission() => 
		__remission.Value;

	private CqlCode resolved_Value() => 
		new CqlCode("resolved", "http://terminology.hl7.org/CodeSystem/condition-clinical", null, null);

    [CqlDeclaration("resolved")]
	public CqlCode resolved() => 
		__resolved.Value;

	private CqlCode unconfirmed_Value() => 
		new CqlCode("unconfirmed", "http://terminology.hl7.org/CodeSystem/condition-ver-status", null, null);

    [CqlDeclaration("unconfirmed")]
	public CqlCode unconfirmed() => 
		__unconfirmed.Value;

	private CqlCode[] ConditionClinicalStatusCodes_Value()
	{
		CqlCode[] a_ = new CqlCode[]
		{
			new CqlCode("active", "http://terminology.hl7.org/CodeSystem/condition-clinical", null, null),
			new CqlCode("inactive", "http://terminology.hl7.org/CodeSystem/condition-clinical", null, null),
			new CqlCode("recurrence", "http://terminology.hl7.org/CodeSystem/condition-clinical", null, null),
			new CqlCode("relapse", "http://terminology.hl7.org/CodeSystem/condition-clinical", null, null),
			new CqlCode("remission", "http://terminology.hl7.org/CodeSystem/condition-clinical", null, null),
			new CqlCode("resolved", "http://terminology.hl7.org/CodeSystem/condition-clinical", null, null),
		};

		return a_;
	}

    [CqlDeclaration("ConditionClinicalStatusCodes")]
	public CqlCode[] ConditionClinicalStatusCodes() => 
		__ConditionClinicalStatusCodes.Value;

	private CqlCode[] AllergyIntoleranceClinicalStatusCodes_Value()
	{
		CqlCode[] a_ = new CqlCode[]
		{
			new CqlCode("active", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", null, null),
			new CqlCode("inactive", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", null, null),
			new CqlCode("resolved", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", null, null),
		};

		return a_;
	}

    [CqlDeclaration("AllergyIntoleranceClinicalStatusCodes")]
	public CqlCode[] AllergyIntoleranceClinicalStatusCodes() => 
		__AllergyIntoleranceClinicalStatusCodes.Value;

	private CqlCode[] AllergyIntoleranceVerificationStatusCodes_Value()
	{
		CqlCode[] a_ = new CqlCode[]
		{
			new CqlCode("confirmed", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", null, null),
			new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", null, null),
			new CqlCode("unconfirmed", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", null, null),
		};

		return a_;
	}

    [CqlDeclaration("AllergyIntoleranceVerificationStatusCodes")]
	public CqlCode[] AllergyIntoleranceVerificationStatusCodes() => 
		__AllergyIntoleranceVerificationStatusCodes.Value;

	private CqlCode[] Diagnosis_Role_Value()
	{
		CqlCode[] a_ = new CqlCode[]
		{
			new CqlCode("billing", "http://terminology.hl7.org/CodeSystem/diagnosis-role", null, null),
		};

		return a_;
	}

    [CqlDeclaration("Diagnosis Role")]
	public CqlCode[] Diagnosis_Role() => 
		__Diagnosis_Role.Value;

	private CqlCode[] LOINC_Value()
	{
		CqlCode[] a_ = new CqlCode[]
		{
			new CqlCode("21112-8", "http://loinc.org", null, null),
		};

		return a_;
	}

    [CqlDeclaration("LOINC")]
	public CqlCode[] LOINC() => 
		__LOINC.Value;

	private CqlCode[] MedicationRequestCategory_Value()
	{
		CqlCode[] a_ = new CqlCode[]
		{
			new CqlCode("community", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", null, null),
			new CqlCode("discharge", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", null, null),
		};

		return a_;
	}

    [CqlDeclaration("MedicationRequestCategory")]
	public CqlCode[] MedicationRequestCategory() => 
		__MedicationRequestCategory.Value;

	private CqlCode[] ConditionVerificationStatusCodes_Value()
	{
		CqlCode[] a_ = new CqlCode[]
		{
			new CqlCode("confirmed", "http://terminology.hl7.org/CodeSystem/condition-ver-status", null, null),
			new CqlCode("differential", "http://terminology.hl7.org/CodeSystem/condition-ver-status", null, null),
			new CqlCode("entered-in-error", "http://terminology.hl7.org/CodeSystem/condition-ver-status", null, null),
			new CqlCode("provisional", "http://terminology.hl7.org/CodeSystem/condition-ver-status", null, null),
			new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/condition-ver-status", null, null),
			new CqlCode("unconfirmed", "http://terminology.hl7.org/CodeSystem/condition-ver-status", null, null),
		};

		return a_;
	}

    [CqlDeclaration("ConditionVerificationStatusCodes")]
	public CqlCode[] ConditionVerificationStatusCodes() => 
		__ConditionVerificationStatusCodes.Value;

	private CqlCode[] SNOMEDCT_Value()
	{
		CqlCode[] a_ = new CqlCode[]
		{
			new CqlCode("419099009", "http://snomed.info/sct", null, null),
		};

		return a_;
	}

    [CqlDeclaration("SNOMEDCT")]
	public CqlCode[] SNOMEDCT() => 
		__SNOMEDCT.Value;

	private CqlCode[] RoleCode_Value()
	{
		CqlCode[] a_ = new CqlCode[]
		{
			new CqlCode("ER", "http://terminology.hl7.org/CodeSystem/v3-RoleCode", null, null),
			new CqlCode("ICU", "http://terminology.hl7.org/CodeSystem/v3-RoleCode", null, null),
		};

		return a_;
	}

    [CqlDeclaration("RoleCode")]
	public CqlCode[] RoleCode() => 
		__RoleCode.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		CqlDateTime a_ = context.Operators.DateTime(2019, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2020, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("MATGlobalCommonFunctionsFHIR4-6.1.000", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period.Value;

	private Patient Patient_Value()
	{
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

    [CqlDeclaration("LengthInDays")]
	public int? LengthInDays(CqlInterval<CqlDateTime> Value)
	{
		CqlDateTime a_ = context.Operators.Start(Value);
		CqlDateTime b_ = context.Operators.End(Value);
		int? c_ = context.Operators.DifferenceBetween(a_, b_, "day");

		return c_;
	}

	private IEnumerable<Encounter> Inpatient_Encounter_Value()
	{
		CqlValueSet a_ = this.Encounter_Inpatient();
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		bool? c_(Encounter EncounterInpatient)
		{
			string e_ = context.Operators.Convert<string>(EncounterInpatient?.StatusElement);
			bool? f_ = context.Operators.Equal(e_, "finished");
			CqlInterval<CqlDateTime> g_ = FHIRHelpers_4_0_001.ToInterval(EncounterInpatient?.Period);
			int? h_ = this.LengthInDays(g_);
			bool? i_ = context.Operators.LessOrEqual(h_, 120);
			bool? j_ = context.Operators.And(f_, i_);
			CqlDateTime l_ = context.Operators.End(g_);
			CqlInterval<CqlDateTime> m_ = this.Measurement_Period();
			bool? n_ = context.Operators.In<CqlDateTime>(l_, m_, null);
			bool? o_ = context.Operators.And(j_, n_);

			return o_;
		};
		IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Inpatient Encounter")]
	public IEnumerable<Encounter> Inpatient_Encounter() => 
		__Inpatient_Encounter.Value;

    [CqlDeclaration("ED Visit")]
	public Encounter ED_Visit(Encounter TheEncounter)
	{
		CqlValueSet a_ = this.Emergency_Department_Visit();
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		bool? c_(Encounter EDVisit)
		{
			string h_ = context.Operators.Convert<string>(EDVisit?.StatusElement);
			bool? i_ = context.Operators.Equal(h_, "finished");
			CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_0_001.ToInterval(EDVisit?.Period);
			CqlDateTime k_ = context.Operators.End(j_);
			CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_0_001.ToInterval(TheEncounter?.Period);
			CqlDateTime m_ = context.Operators.Start(l_);
			CqlQuantity n_ = context.Operators.Quantity(1m, "hour");
			CqlDateTime o_ = context.Operators.Subtract(m_, n_);
			CqlDateTime q_ = context.Operators.Start(l_);
			CqlInterval<CqlDateTime> r_ = context.Operators.Interval(o_, q_, true, true);
			bool? s_ = context.Operators.In<CqlDateTime>(k_, r_, null);
			CqlDateTime u_ = context.Operators.Start(l_);
			bool? v_ = context.Operators.Not((bool?)(u_ is null));
			bool? w_ = context.Operators.And(s_, v_);
			bool? x_ = context.Operators.And(i_, w_);

			return x_;
		};
		IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);
		object e_(Encounter @this)
		{
			CqlInterval<CqlDateTime> y_ = FHIRHelpers_4_0_001.ToInterval(@this?.Period);
			CqlDateTime z_ = context.Operators.End(y_);

			return z_;
		};
		IEnumerable<Encounter> f_ = context.Operators.SortBy<Encounter>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
		Encounter g_ = context.Operators.Last<Encounter>(f_);

		return g_;
	}

    [CqlDeclaration("Hospitalization")]
	public CqlInterval<CqlDateTime> Hospitalization(Encounter TheEncounter)
	{
		Encounter a_ = this.ED_Visit(TheEncounter);
		Encounter[] b_ = new Encounter[]
		{
			a_,
		};
		CqlInterval<CqlDateTime> c_(Encounter X)
		{
			CqlInterval<CqlDateTime> f_()
			{
				if ((X is null))
				{
					CqlInterval<CqlDateTime> g_ = FHIRHelpers_4_0_001.ToInterval(TheEncounter?.Period);

					return g_;
				}
				else
				{
					CqlInterval<CqlDateTime> h_ = FHIRHelpers_4_0_001.ToInterval(X?.Period);
					CqlDateTime i_ = context.Operators.Start(h_);
					CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_0_001.ToInterval(TheEncounter?.Period);
					CqlDateTime k_ = context.Operators.End(j_);
					CqlInterval<CqlDateTime> l_ = context.Operators.Interval(i_, k_, true, true);

					return l_;
				};
			};

			return f_();
		};
		IEnumerable<CqlInterval<CqlDateTime>> d_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>(b_, c_);
		CqlInterval<CqlDateTime> e_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(d_);

		return e_;
	}

    [CqlDeclaration("Hospitalization Locations")]
	public IEnumerable<Encounter.LocationComponent> Hospitalization_Locations(Encounter TheEncounter)
	{
		Encounter a_ = this.ED_Visit(TheEncounter);
		Encounter[] b_ = new Encounter[]
		{
			a_,
		};
		IEnumerable<Encounter.LocationComponent> c_(Encounter EDEncounter)
		{
			IEnumerable<Encounter.LocationComponent> f_()
			{
				if ((EDEncounter is null))
				{
					return (TheEncounter?.Location as IEnumerable<Encounter.LocationComponent>);
				}
				else
				{
					IEnumerable<Encounter.LocationComponent>[] g_ = new IEnumerable<Encounter.LocationComponent>[]
					{
						(EDEncounter?.Location as IEnumerable<Encounter.LocationComponent>),
						(TheEncounter?.Location as IEnumerable<Encounter.LocationComponent>),
					};
					IEnumerable<Encounter.LocationComponent> h_ = context.Operators.Flatten<Encounter.LocationComponent>((g_ as IEnumerable<IEnumerable<Encounter.LocationComponent>>));

					return h_;
				};
			};

			return f_();
		};
		IEnumerable<IEnumerable<Encounter.LocationComponent>> d_ = context.Operators.Select<Encounter, IEnumerable<Encounter.LocationComponent>>(b_, c_);
		IEnumerable<Encounter.LocationComponent> e_ = context.Operators.SingletonFrom<IEnumerable<Encounter.LocationComponent>>(d_);

		return e_;
	}

    [CqlDeclaration("Hospitalization Length of Stay")]
	public int? Hospitalization_Length_of_Stay(Encounter TheEncounter)
	{
		CqlInterval<CqlDateTime> a_ = this.Hospitalization(TheEncounter);
		int? b_ = this.LengthInDays(a_);

		return b_;
	}

    [CqlDeclaration("Hospital Admission Time")]
	public CqlDateTime Hospital_Admission_Time(Encounter TheEncounter)
	{
		CqlInterval<CqlDateTime> a_ = this.Hospitalization(TheEncounter);
		CqlDateTime b_ = context.Operators.Start(a_);

		return b_;
	}

    [CqlDeclaration("Hospital Discharge Time")]
	public CqlDateTime Hospital_Discharge_Time(Encounter TheEncounter)
	{
		CqlInterval<CqlDateTime> a_ = FHIRHelpers_4_0_001.ToInterval(TheEncounter?.Period);
		CqlDateTime b_ = context.Operators.End(a_);

		return b_;
	}

    [CqlDeclaration("Hospital Arrival Time")]
	public CqlDateTime Hospital_Arrival_Time(Encounter TheEncounter)
	{
		IEnumerable<Encounter.LocationComponent> a_ = this.Hospitalization_Locations(TheEncounter);
		object b_(Encounter.LocationComponent @this)
		{
			CqlInterval<CqlDateTime> g_ = FHIRHelpers_4_0_001.ToInterval(@this?.Period);
			CqlDateTime h_ = context.Operators.Start(g_);

			return h_;
		};
		IEnumerable<Encounter.LocationComponent> c_ = context.Operators.SortBy<Encounter.LocationComponent>(a_, b_, System.ComponentModel.ListSortDirection.Ascending);
		Encounter.LocationComponent d_ = context.Operators.First<Encounter.LocationComponent>(c_);
		CqlInterval<CqlDateTime> e_ = FHIRHelpers_4_0_001.ToInterval(d_?.Period);
		CqlDateTime f_ = context.Operators.Start(e_);

		return f_;
	}

    [CqlDeclaration("HospitalizationWithObservation")]
	public CqlInterval<CqlDateTime> HospitalizationWithObservation(Encounter TheEncounter)
	{
		Encounter[] a_ = new Encounter[]
		{
			TheEncounter,
		};
		CqlInterval<CqlDateTime> b_(Encounter Visit)
		{
			CqlValueSet e_ = this.Emergency_Department_Visit();
			IEnumerable<Encounter> f_ = context.Operators.RetrieveByValueSet<Encounter>(e_, null);
			bool? g_(Encounter LastED)
			{
				CqlInterval<CqlDateTime> ab_ = FHIRHelpers_4_0_001.ToInterval(LastED?.Period);
				CqlDateTime ac_ = context.Operators.End(ab_);
				CqlValueSet ad_ = this.Observation_Services();
				IEnumerable<Encounter> ae_ = context.Operators.RetrieveByValueSet<Encounter>(ad_, null);
				bool? af_(Encounter LastObs)
				{
					CqlInterval<CqlDateTime> bq_ = FHIRHelpers_4_0_001.ToInterval(LastObs?.Period);
					CqlDateTime br_ = context.Operators.End(bq_);
					CqlInterval<CqlDateTime> bs_ = FHIRHelpers_4_0_001.ToInterval(Visit?.Period);
					CqlDateTime bt_ = context.Operators.Start(bs_);
					CqlQuantity bu_ = context.Operators.Quantity(1m, "hour");
					CqlDateTime bv_ = context.Operators.Subtract(bt_, bu_);
					CqlDateTime bx_ = context.Operators.Start(bs_);
					CqlInterval<CqlDateTime> by_ = context.Operators.Interval(bv_, bx_, true, true);
					bool? bz_ = context.Operators.In<CqlDateTime>(br_, by_, null);
					CqlDateTime cb_ = context.Operators.Start(bs_);
					bool? cc_ = context.Operators.Not((bool?)(cb_ is null));
					bool? cd_ = context.Operators.And(bz_, cc_);

					return cd_;
				};
				IEnumerable<Encounter> ag_ = context.Operators.Where<Encounter>(ae_, af_);
				object ah_(Encounter @this)
				{
					CqlInterval<CqlDateTime> ce_ = FHIRHelpers_4_0_001.ToInterval(@this?.Period);
					CqlDateTime cf_ = context.Operators.End(ce_);

					return cf_;
				};
				IEnumerable<Encounter> ai_ = context.Operators.SortBy<Encounter>(ag_, ah_, System.ComponentModel.ListSortDirection.Ascending);
				Encounter aj_ = context.Operators.Last<Encounter>(ai_);
				CqlInterval<CqlDateTime> ak_ = FHIRHelpers_4_0_001.ToInterval(aj_?.Period);
				CqlDateTime al_ = context.Operators.Start(ak_);
				CqlInterval<CqlDateTime> am_ = FHIRHelpers_4_0_001.ToInterval(Visit?.Period);
				CqlDateTime an_ = context.Operators.Start(am_);
				CqlQuantity ao_ = context.Operators.Quantity(1m, "hour");
				CqlDateTime ap_ = context.Operators.Subtract((al_ ?? an_), ao_);
				IEnumerable<Encounter> ar_ = context.Operators.RetrieveByValueSet<Encounter>(ad_, null);
				bool? as_(Encounter LastObs)
				{
					CqlInterval<CqlDateTime> cg_ = FHIRHelpers_4_0_001.ToInterval(LastObs?.Period);
					CqlDateTime ch_ = context.Operators.End(cg_);
					CqlInterval<CqlDateTime> ci_ = FHIRHelpers_4_0_001.ToInterval(Visit?.Period);
					CqlDateTime cj_ = context.Operators.Start(ci_);
					CqlQuantity ck_ = context.Operators.Quantity(1m, "hour");
					CqlDateTime cl_ = context.Operators.Subtract(cj_, ck_);
					CqlDateTime cn_ = context.Operators.Start(ci_);
					CqlInterval<CqlDateTime> co_ = context.Operators.Interval(cl_, cn_, true, true);
					bool? cp_ = context.Operators.In<CqlDateTime>(ch_, co_, null);
					CqlDateTime cr_ = context.Operators.Start(ci_);
					bool? cs_ = context.Operators.Not((bool?)(cr_ is null));
					bool? ct_ = context.Operators.And(cp_, cs_);

					return ct_;
				};
				IEnumerable<Encounter> at_ = context.Operators.Where<Encounter>(ar_, as_);
				object au_(Encounter @this)
				{
					CqlInterval<CqlDateTime> cu_ = FHIRHelpers_4_0_001.ToInterval(@this?.Period);
					CqlDateTime cv_ = context.Operators.End(cu_);

					return cv_;
				};
				IEnumerable<Encounter> av_ = context.Operators.SortBy<Encounter>(at_, au_, System.ComponentModel.ListSortDirection.Ascending);
				Encounter aw_ = context.Operators.Last<Encounter>(av_);
				CqlInterval<CqlDateTime> ax_ = FHIRHelpers_4_0_001.ToInterval(aw_?.Period);
				CqlDateTime ay_ = context.Operators.Start(ax_);
				CqlDateTime ba_ = context.Operators.Start(am_);
				CqlInterval<CqlDateTime> bb_ = context.Operators.Interval(ap_, (ay_ ?? ba_), true, true);
				bool? bc_ = context.Operators.In<CqlDateTime>(ac_, bb_, null);
				IEnumerable<Encounter> be_ = context.Operators.RetrieveByValueSet<Encounter>(ad_, null);
				bool? bf_(Encounter LastObs)
				{
					CqlInterval<CqlDateTime> cw_ = FHIRHelpers_4_0_001.ToInterval(LastObs?.Period);
					CqlDateTime cx_ = context.Operators.End(cw_);
					CqlInterval<CqlDateTime> cy_ = FHIRHelpers_4_0_001.ToInterval(Visit?.Period);
					CqlDateTime cz_ = context.Operators.Start(cy_);
					CqlQuantity da_ = context.Operators.Quantity(1m, "hour");
					CqlDateTime db_ = context.Operators.Subtract(cz_, da_);
					CqlDateTime dd_ = context.Operators.Start(cy_);
					CqlInterval<CqlDateTime> de_ = context.Operators.Interval(db_, dd_, true, true);
					bool? df_ = context.Operators.In<CqlDateTime>(cx_, de_, null);
					CqlDateTime dh_ = context.Operators.Start(cy_);
					bool? di_ = context.Operators.Not((bool?)(dh_ is null));
					bool? dj_ = context.Operators.And(df_, di_);

					return dj_;
				};
				IEnumerable<Encounter> bg_ = context.Operators.Where<Encounter>(be_, bf_);
				object bh_(Encounter @this)
				{
					CqlInterval<CqlDateTime> dk_ = FHIRHelpers_4_0_001.ToInterval(@this?.Period);
					CqlDateTime dl_ = context.Operators.End(dk_);

					return dl_;
				};
				IEnumerable<Encounter> bi_ = context.Operators.SortBy<Encounter>(bg_, bh_, System.ComponentModel.ListSortDirection.Ascending);
				Encounter bj_ = context.Operators.Last<Encounter>(bi_);
				CqlInterval<CqlDateTime> bk_ = FHIRHelpers_4_0_001.ToInterval(bj_?.Period);
				CqlDateTime bl_ = context.Operators.Start(bk_);
				CqlDateTime bn_ = context.Operators.Start(am_);
				bool? bo_ = context.Operators.Not((bool?)((bl_ ?? bn_) is null));
				bool? bp_ = context.Operators.And(bc_, bo_);

				return bp_;
			};
			IEnumerable<Encounter> h_ = context.Operators.Where<Encounter>(f_, g_);
			object i_(Encounter @this)
			{
				CqlInterval<CqlDateTime> dm_ = FHIRHelpers_4_0_001.ToInterval(@this?.Period);
				CqlDateTime dn_ = context.Operators.End(dm_);

				return dn_;
			};
			IEnumerable<Encounter> j_ = context.Operators.SortBy<Encounter>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
			Encounter k_ = context.Operators.Last<Encounter>(j_);
			CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_0_001.ToInterval(k_?.Period);
			CqlDateTime m_ = context.Operators.Start(l_);
			CqlValueSet n_ = this.Observation_Services();
			IEnumerable<Encounter> o_ = context.Operators.RetrieveByValueSet<Encounter>(n_, null);
			bool? p_(Encounter LastObs)
			{
				CqlInterval<CqlDateTime> do_ = FHIRHelpers_4_0_001.ToInterval(LastObs?.Period);
				CqlDateTime dp_ = context.Operators.End(do_);
				CqlInterval<CqlDateTime> dq_ = FHIRHelpers_4_0_001.ToInterval(Visit?.Period);
				CqlDateTime dr_ = context.Operators.Start(dq_);
				CqlQuantity ds_ = context.Operators.Quantity(1m, "hour");
				CqlDateTime dt_ = context.Operators.Subtract(dr_, ds_);
				CqlDateTime dv_ = context.Operators.Start(dq_);
				CqlInterval<CqlDateTime> dw_ = context.Operators.Interval(dt_, dv_, true, true);
				bool? dx_ = context.Operators.In<CqlDateTime>(dp_, dw_, null);
				CqlDateTime dz_ = context.Operators.Start(dq_);
				bool? ea_ = context.Operators.Not((bool?)(dz_ is null));
				bool? eb_ = context.Operators.And(dx_, ea_);

				return eb_;
			};
			IEnumerable<Encounter> q_ = context.Operators.Where<Encounter>(o_, p_);
			object r_(Encounter @this)
			{
				CqlInterval<CqlDateTime> ec_ = FHIRHelpers_4_0_001.ToInterval(@this?.Period);
				CqlDateTime ed_ = context.Operators.End(ec_);

				return ed_;
			};
			IEnumerable<Encounter> s_ = context.Operators.SortBy<Encounter>(q_, r_, System.ComponentModel.ListSortDirection.Ascending);
			Encounter t_ = context.Operators.Last<Encounter>(s_);
			CqlInterval<CqlDateTime> u_ = FHIRHelpers_4_0_001.ToInterval(t_?.Period);
			CqlDateTime v_ = context.Operators.Start(u_);
			CqlInterval<CqlDateTime> w_ = FHIRHelpers_4_0_001.ToInterval(Visit?.Period);
			CqlDateTime x_ = context.Operators.Start(w_);
			CqlDateTime z_ = context.Operators.End(w_);
			CqlInterval<CqlDateTime> aa_ = context.Operators.Interval((m_ ?? (v_ ?? x_)), z_, true, true);

			return aa_;
		};
		IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>(a_, b_);
		CqlInterval<CqlDateTime> d_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(c_);

		return d_;
	}

    [CqlDeclaration("Normalize Interval")]
	public CqlInterval<CqlDateTime> Normalize_Interval(object choice)
	{
		CqlInterval<CqlDateTime> a_()
		{
			if (choice is FhirDateTime)
			{
				CqlDateTime b_ = FHIRHelpers_4_0_001.ToDateTime((choice as FhirDateTime));
				CqlInterval<CqlDateTime> d_ = context.Operators.Interval(b_, b_, true, true);

				return d_;
			}
			else if (choice is Period)
			{
				CqlInterval<CqlDateTime> e_ = FHIRHelpers_4_0_001.ToInterval((choice as Period));

				return e_;
			}
			else if (choice is Instant)
			{
				CqlDateTime f_ = FHIRHelpers_4_0_001.ToDateTime((choice as Instant));
				CqlInterval<CqlDateTime> h_ = context.Operators.Interval(f_, f_, true, true);

				return h_;
			}
			else if (choice is Age)
			{
				Patient i_ = this.Patient();
				CqlDate j_ = FHIRHelpers_4_0_001.ToDate(i_?.BirthDateElement);
				CqlQuantity k_ = FHIRHelpers_4_0_001.ToQuantity(((choice as Age) as Quantity));
				CqlDate l_ = context.Operators.Add(j_, k_);
				CqlDate n_ = FHIRHelpers_4_0_001.ToDate(i_?.BirthDateElement);
				CqlDate p_ = context.Operators.Add(n_, k_);
				CqlQuantity q_ = context.Operators.Quantity(1m, "year");
				CqlDate r_ = context.Operators.Add(p_, q_);
				CqlInterval<CqlDate> s_ = context.Operators.Interval(l_, r_, true, false);
				CqlDateTime t_ = context.Operators.ConvertDateToDateTime(s_?.low);
				CqlDate v_ = FHIRHelpers_4_0_001.ToDate(i_?.BirthDateElement);
				CqlDate x_ = context.Operators.Add(v_, k_);
				CqlDate z_ = FHIRHelpers_4_0_001.ToDate(i_?.BirthDateElement);
				CqlDate ab_ = context.Operators.Add(z_, k_);
				CqlDate ad_ = context.Operators.Add(ab_, q_);
				CqlInterval<CqlDate> ae_ = context.Operators.Interval(x_, ad_, true, false);
				CqlDateTime af_ = context.Operators.ConvertDateToDateTime(ae_?.high);
				CqlDate ah_ = FHIRHelpers_4_0_001.ToDate(i_?.BirthDateElement);
				CqlDate aj_ = context.Operators.Add(ah_, k_);
				CqlDate al_ = FHIRHelpers_4_0_001.ToDate(i_?.BirthDateElement);
				CqlDate an_ = context.Operators.Add(al_, k_);
				CqlDate ap_ = context.Operators.Add(an_, q_);
				CqlInterval<CqlDate> aq_ = context.Operators.Interval(aj_, ap_, true, false);
				CqlDate as_ = FHIRHelpers_4_0_001.ToDate(i_?.BirthDateElement);
				CqlDate au_ = context.Operators.Add(as_, k_);
				CqlDate aw_ = FHIRHelpers_4_0_001.ToDate(i_?.BirthDateElement);
				CqlDate ay_ = context.Operators.Add(aw_, k_);
				CqlDate ba_ = context.Operators.Add(ay_, q_);
				CqlInterval<CqlDate> bb_ = context.Operators.Interval(au_, ba_, true, false);
				CqlInterval<CqlDateTime> bc_ = context.Operators.Interval(t_, af_, aq_?.lowClosed, bb_?.highClosed);

				return bc_;
			}
			else if (choice is Range)
			{
				Patient bd_ = this.Patient();
				CqlDate be_ = FHIRHelpers_4_0_001.ToDate(bd_?.BirthDateElement);
				CqlQuantity bf_ = FHIRHelpers_4_0_001.ToQuantity((choice as Range)?.Low);
				CqlDate bg_ = context.Operators.Add(be_, bf_);
				CqlDate bi_ = FHIRHelpers_4_0_001.ToDate(bd_?.BirthDateElement);
				CqlQuantity bj_ = FHIRHelpers_4_0_001.ToQuantity((choice as Range)?.High);
				CqlDate bk_ = context.Operators.Add(bi_, bj_);
				CqlQuantity bl_ = context.Operators.Quantity(1m, "year");
				CqlDate bm_ = context.Operators.Add(bk_, bl_);
				CqlInterval<CqlDate> bn_ = context.Operators.Interval(bg_, bm_, true, false);
				CqlDateTime bo_ = context.Operators.ConvertDateToDateTime(bn_?.low);
				CqlDate bq_ = FHIRHelpers_4_0_001.ToDate(bd_?.BirthDateElement);
				CqlDate bs_ = context.Operators.Add(bq_, bf_);
				CqlDate bu_ = FHIRHelpers_4_0_001.ToDate(bd_?.BirthDateElement);
				CqlDate bw_ = context.Operators.Add(bu_, bj_);
				CqlDate by_ = context.Operators.Add(bw_, bl_);
				CqlInterval<CqlDate> bz_ = context.Operators.Interval(bs_, by_, true, false);
				CqlDateTime ca_ = context.Operators.ConvertDateToDateTime(bz_?.high);
				CqlDate cc_ = FHIRHelpers_4_0_001.ToDate(bd_?.BirthDateElement);
				CqlDate ce_ = context.Operators.Add(cc_, bf_);
				CqlDate cg_ = FHIRHelpers_4_0_001.ToDate(bd_?.BirthDateElement);
				CqlDate ci_ = context.Operators.Add(cg_, bj_);
				CqlDate ck_ = context.Operators.Add(ci_, bl_);
				CqlInterval<CqlDate> cl_ = context.Operators.Interval(ce_, ck_, true, false);
				CqlDate cn_ = FHIRHelpers_4_0_001.ToDate(bd_?.BirthDateElement);
				CqlDate cp_ = context.Operators.Add(cn_, bf_);
				CqlDate cr_ = FHIRHelpers_4_0_001.ToDate(bd_?.BirthDateElement);
				CqlDate ct_ = context.Operators.Add(cr_, bj_);
				CqlDate cv_ = context.Operators.Add(ct_, bl_);
				CqlInterval<CqlDate> cw_ = context.Operators.Interval(cp_, cv_, true, false);
				CqlInterval<CqlDateTime> cx_ = context.Operators.Interval(bo_, ca_, cl_?.lowClosed, cw_?.highClosed);

				return cx_;
			}
			else if (choice is Timing)
			{
				CqlInterval<CqlDateTime> cy_ = null;
				CqlInterval<CqlDateTime> cz_ = context.Operators.Message<CqlInterval<CqlDateTime>>(cy_, "1", "Error", "Cannot compute a single interval from a Timing type");

				return cz_;
			}
			else if (choice is FhirString)
			{
				CqlInterval<CqlDateTime> da_ = null;
				CqlInterval<CqlDateTime> db_ = context.Operators.Message<CqlInterval<CqlDateTime>>(da_, "1", "Error", "Cannot compute an interval from a String value");

				return db_;
			}
			else
			{
				CqlInterval<CqlDateTime> dc_ = null;

				return dc_;
			};
		};

		return a_();
	}

    [CqlDeclaration("Normalize Abatement")]
	public CqlInterval<CqlDateTime> Normalize_Abatement(Condition condition)
	{
		CqlInterval<CqlDateTime> a_()
		{
			if (condition?.Abatement is FhirDateTime)
			{
				CqlDateTime b_ = FHIRHelpers_4_0_001.ToDateTime((condition?.Abatement as FhirDateTime));
				CqlInterval<CqlDateTime> d_ = context.Operators.Interval(b_, b_, true, true);

				return d_;
			}
			else if (condition?.Abatement is Period)
			{
				CqlInterval<CqlDateTime> e_ = FHIRHelpers_4_0_001.ToInterval((condition?.Abatement as Period));

				return e_;
			}
			else if (condition?.Abatement is FhirString)
			{
				CqlInterval<CqlDateTime> f_ = null;
				CqlInterval<CqlDateTime> g_ = context.Operators.Message<CqlInterval<CqlDateTime>>(f_, "1", "Error", "Cannot compute an interval from a String value");

				return g_;
			}
			else if (condition?.Abatement is Age)
			{
				Patient h_ = this.Patient();
				CqlDate i_ = FHIRHelpers_4_0_001.ToDate(h_?.BirthDateElement);
				CqlQuantity j_ = FHIRHelpers_4_0_001.ToQuantity(((condition?.Abatement as Age) as Quantity));
				CqlDate k_ = context.Operators.Add(i_, j_);
				CqlDate m_ = FHIRHelpers_4_0_001.ToDate(h_?.BirthDateElement);
				CqlDate o_ = context.Operators.Add(m_, j_);
				CqlQuantity p_ = context.Operators.Quantity(1m, "year");
				CqlDate q_ = context.Operators.Add(o_, p_);
				CqlInterval<CqlDate> r_ = context.Operators.Interval(k_, q_, true, false);
				CqlDateTime s_ = context.Operators.ConvertDateToDateTime(r_?.low);
				CqlDate u_ = FHIRHelpers_4_0_001.ToDate(h_?.BirthDateElement);
				CqlDate w_ = context.Operators.Add(u_, j_);
				CqlDate y_ = FHIRHelpers_4_0_001.ToDate(h_?.BirthDateElement);
				CqlDate aa_ = context.Operators.Add(y_, j_);
				CqlDate ac_ = context.Operators.Add(aa_, p_);
				CqlInterval<CqlDate> ad_ = context.Operators.Interval(w_, ac_, true, false);
				CqlDateTime ae_ = context.Operators.ConvertDateToDateTime(ad_?.high);
				CqlDate ag_ = FHIRHelpers_4_0_001.ToDate(h_?.BirthDateElement);
				CqlDate ai_ = context.Operators.Add(ag_, j_);
				CqlDate ak_ = FHIRHelpers_4_0_001.ToDate(h_?.BirthDateElement);
				CqlDate am_ = context.Operators.Add(ak_, j_);
				CqlDate ao_ = context.Operators.Add(am_, p_);
				CqlInterval<CqlDate> ap_ = context.Operators.Interval(ai_, ao_, true, false);
				CqlDate ar_ = FHIRHelpers_4_0_001.ToDate(h_?.BirthDateElement);
				CqlDate at_ = context.Operators.Add(ar_, j_);
				CqlDate av_ = FHIRHelpers_4_0_001.ToDate(h_?.BirthDateElement);
				CqlDate ax_ = context.Operators.Add(av_, j_);
				CqlDate az_ = context.Operators.Add(ax_, p_);
				CqlInterval<CqlDate> ba_ = context.Operators.Interval(at_, az_, true, false);
				CqlInterval<CqlDateTime> bb_ = context.Operators.Interval(s_, ae_, ap_?.lowClosed, ba_?.highClosed);

				return bb_;
			}
			else if (condition?.Abatement is Range)
			{
				Patient bc_ = this.Patient();
				CqlDate bd_ = FHIRHelpers_4_0_001.ToDate(bc_?.BirthDateElement);
				CqlQuantity be_ = FHIRHelpers_4_0_001.ToQuantity((condition?.Abatement as Range)?.Low);
				CqlDate bf_ = context.Operators.Add(bd_, be_);
				CqlDate bh_ = FHIRHelpers_4_0_001.ToDate(bc_?.BirthDateElement);
				CqlQuantity bi_ = FHIRHelpers_4_0_001.ToQuantity((condition?.Abatement as Range)?.High);
				CqlDate bj_ = context.Operators.Add(bh_, bi_);
				CqlQuantity bk_ = context.Operators.Quantity(1m, "year");
				CqlDate bl_ = context.Operators.Add(bj_, bk_);
				CqlInterval<CqlDate> bm_ = context.Operators.Interval(bf_, bl_, true, false);
				CqlDateTime bn_ = context.Operators.ConvertDateToDateTime(bm_?.low);
				CqlDate bp_ = FHIRHelpers_4_0_001.ToDate(bc_?.BirthDateElement);
				CqlDate br_ = context.Operators.Add(bp_, be_);
				CqlDate bt_ = FHIRHelpers_4_0_001.ToDate(bc_?.BirthDateElement);
				CqlDate bv_ = context.Operators.Add(bt_, bi_);
				CqlDate bx_ = context.Operators.Add(bv_, bk_);
				CqlInterval<CqlDate> by_ = context.Operators.Interval(br_, bx_, true, false);
				CqlDateTime bz_ = context.Operators.ConvertDateToDateTime(by_?.high);
				CqlDate cb_ = FHIRHelpers_4_0_001.ToDate(bc_?.BirthDateElement);
				CqlDate cd_ = context.Operators.Add(cb_, be_);
				CqlDate cf_ = FHIRHelpers_4_0_001.ToDate(bc_?.BirthDateElement);
				CqlDate ch_ = context.Operators.Add(cf_, bi_);
				CqlDate cj_ = context.Operators.Add(ch_, bk_);
				CqlInterval<CqlDate> ck_ = context.Operators.Interval(cd_, cj_, true, false);
				CqlDate cm_ = FHIRHelpers_4_0_001.ToDate(bc_?.BirthDateElement);
				CqlDate co_ = context.Operators.Add(cm_, be_);
				CqlDate cq_ = FHIRHelpers_4_0_001.ToDate(bc_?.BirthDateElement);
				CqlDate cs_ = context.Operators.Add(cq_, bi_);
				CqlDate cu_ = context.Operators.Add(cs_, bk_);
				CqlInterval<CqlDate> cv_ = context.Operators.Interval(co_, cu_, true, false);
				CqlInterval<CqlDateTime> cw_ = context.Operators.Interval(bn_, bz_, ck_?.lowClosed, cv_?.highClosed);

				return cw_;
			}
			else if (condition?.Abatement is FhirBoolean)
			{
				CqlInterval<CqlDateTime> cx_ = this.Normalize_Interval(condition?.Onset);
				CqlDateTime cy_ = context.Operators.End(cx_);
				CqlDateTime cz_ = FHIRHelpers_4_0_001.ToDateTime(condition?.RecordedDateElement);
				CqlInterval<CqlDateTime> da_ = context.Operators.Interval(cy_, cz_, true, false);

				return da_;
			}
			else
			{
				CqlInterval<CqlDateTime> db_ = null;

				return db_;
			};
		};

		return a_();
	}

    [CqlDeclaration("Prevalence Period")]
	public CqlInterval<CqlDateTime> Prevalence_Period(Condition condition)
	{
		CqlInterval<CqlDateTime> a_()
		{
			bool b_()
			{
				CqlConcept c_ = FHIRHelpers_4_0_001.ToConcept(condition?.ClinicalStatus);
				CqlCode d_ = this.active();
				CqlConcept e_ = context.Operators.ConvertCodeToConcept(d_);
				bool? f_ = context.Operators.Equivalent(c_, e_);
				CqlCode h_ = this.recurrence();
				CqlConcept i_ = context.Operators.ConvertCodeToConcept(h_);
				bool? j_ = context.Operators.Equivalent(c_, i_);
				bool? k_ = context.Operators.Or(f_, j_);
				CqlCode m_ = this.relapse();
				CqlConcept n_ = context.Operators.ConvertCodeToConcept(m_);
				bool? o_ = context.Operators.Equivalent(c_, n_);
				bool? p_ = context.Operators.Or(k_, o_);

				return (p_ ?? false);
			};
			if (b_())
			{
				CqlInterval<CqlDateTime> q_ = this.Normalize_Interval(condition?.Onset);
				CqlDateTime r_ = context.Operators.Start(q_);
				CqlInterval<CqlDateTime> s_ = this.Normalize_Abatement(condition);
				CqlDateTime t_ = context.Operators.End(s_);
				CqlInterval<CqlDateTime> u_ = context.Operators.Interval(r_, t_, true, true);

				return u_;
			}
			else
			{
				CqlInterval<CqlDateTime> v_ = this.Normalize_Interval(condition?.Onset);
				CqlDateTime w_ = context.Operators.Start(v_);
				CqlInterval<CqlDateTime> x_ = this.Normalize_Abatement(condition);
				CqlDateTime y_ = context.Operators.End(x_);
				CqlInterval<CqlDateTime> z_ = context.Operators.Interval(w_, y_, true, false);

				return z_;
			};
		};

		return a_();
	}

    [CqlDeclaration("GetId")]
	public string GetId(string uri)
	{
		IEnumerable<string> a_ = context.Operators.Split(uri, "/");
		string b_ = context.Operators.Last<string>(a_);

		return b_;
	}

    [CqlDeclaration("EncounterDiagnosis")]
	public IEnumerable<Condition> EncounterDiagnosis(Encounter Encounter)
	{
		Condition a_(Encounter.DiagnosisComponent D)
		{
			IEnumerable<Condition> c_ = context.Operators.RetrieveByValueSet<Condition>(null, null);
			bool? d_(Condition C)
			{
				string g_ = context.Operators.Convert<string>(C?.IdElement);
				string h_ = context.Operators.Convert<string>(D?.Condition?.ReferenceElement);
				string i_ = this.GetId(h_);
				bool? j_ = context.Operators.Equal(g_, i_);

				return j_;
			};
			IEnumerable<Condition> e_ = context.Operators.Where<Condition>(c_, d_);
			Condition f_ = context.Operators.SingletonFrom<Condition>(e_);

			return f_;
		};
		IEnumerable<Condition> b_ = context.Operators.Select<Encounter.DiagnosisComponent, Condition>((Encounter?.Diagnosis as IEnumerable<Encounter.DiagnosisComponent>), a_);

		return b_;
	}

    [CqlDeclaration("GetCondition")]
	public Condition GetCondition(ResourceReference reference)
	{
		IEnumerable<Condition> a_ = context.Operators.RetrieveByValueSet<Condition>(null, null);
		bool? b_(Condition C)
		{
			string e_ = context.Operators.Convert<string>(C?.IdElement);
			string f_ = context.Operators.Convert<string>(reference?.ReferenceElement);
			string g_ = this.GetId(f_);
			bool? h_ = context.Operators.Equal(e_, g_);

			return h_;
		};
		IEnumerable<Condition> c_ = context.Operators.Where<Condition>(a_, b_);
		Condition d_ = context.Operators.SingletonFrom<Condition>(c_);

		return d_;
	}

    [CqlDeclaration("GetExtensions")]
	public IEnumerable<Extension> GetExtensions(DomainResource domainResource, string url)
	{
		bool? a_(Extension E)
		{
			FhirUri e_ = context.Operators.Convert<FhirUri>(E?.Url);
			string f_ = context.Operators.Convert<string>(e_);
			string g_ = context.Operators.Concatenate("http://hl7.org/fhir/us/qicore/StructureDefinition/", url);
			bool? h_ = context.Operators.Equal(f_, g_);

			return h_;
		};
		IEnumerable<Extension> b_ = context.Operators.Where<Extension>((domainResource?.Extension as IEnumerable<Extension>), a_);
		Extension c_(Extension E) => 
			E;
		IEnumerable<Extension> d_ = context.Operators.Select<Extension, Extension>(b_, c_);

		return d_;
	}

    [CqlDeclaration("GetExtensions")]
	public IEnumerable<Extension> GetExtensions(Element element, string url)
	{
		bool? a_(Extension E)
		{
			FhirUri e_ = context.Operators.Convert<FhirUri>(E?.Url);
			string f_ = context.Operators.Convert<string>(e_);
			bool? g_ = context.Operators.Equal(f_, url);

			return g_;
		};
		IEnumerable<Extension> b_ = context.Operators.Where<Extension>((element?.Extension as IEnumerable<Extension>), a_);
		Extension c_(Extension E) => 
			E;
		IEnumerable<Extension> d_ = context.Operators.Select<Extension, Extension>(b_, c_);

		return d_;
	}

    [CqlDeclaration("GetExtension")]
	public Extension GetExtension(DomainResource domainResource, string url)
	{
		IEnumerable<Extension> a_ = this.GetExtensions(domainResource, url);
		Extension b_ = context.Operators.SingletonFrom<Extension>(a_);

		return b_;
	}

    [CqlDeclaration("GetExtension")]
	public Extension GetExtension(Element element, string url)
	{
		IEnumerable<Extension> a_ = this.GetExtensions(element, url);
		Extension b_ = context.Operators.SingletonFrom<Extension>(a_);

		return b_;
	}

    [CqlDeclaration("PresentOnAdmissionIndicator")]
	public CodeableConcept PresentOnAdmissionIndicator(Element element)
	{
		Extension a_ = this.GetExtension(element, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

		return (a_?.Value as CodeableConcept);
	}

    [CqlDeclaration("PrincipalDiagnosis")]
	public Condition PrincipalDiagnosis(Encounter Encounter)
	{
		bool? a_(Encounter.DiagnosisComponent D)
		{
			Integer h_ = context.Operators.Convert<Integer>(D?.RankElement);
			int? i_ = FHIRHelpers_4_0_001.ToInteger(h_);
			bool? j_ = context.Operators.Equal(i_, 1);

			return j_;
		};
		IEnumerable<Encounter.DiagnosisComponent> b_ = context.Operators.Where<Encounter.DiagnosisComponent>((Encounter?.Diagnosis as IEnumerable<Encounter.DiagnosisComponent>), a_);
		Encounter.DiagnosisComponent c_ = context.Operators.SingletonFrom<Encounter.DiagnosisComponent>(b_);
		Encounter.DiagnosisComponent[] d_ = new Encounter.DiagnosisComponent[]
		{
			c_,
		};
		Condition e_(Encounter.DiagnosisComponent PD)
		{
			IEnumerable<Condition> k_ = context.Operators.RetrieveByValueSet<Condition>(null, null);
			bool? l_(Condition C)
			{
				string o_ = context.Operators.Convert<string>(C?.IdElement);
				string p_ = context.Operators.Convert<string>(PD?.Condition?.ReferenceElement);
				string q_ = this.GetId(p_);
				bool? r_ = context.Operators.Equal(o_, q_);

				return r_;
			};
			IEnumerable<Condition> m_ = context.Operators.Where<Condition>(k_, l_);
			Condition n_ = context.Operators.SingletonFrom<Condition>(m_);

			return n_;
		};
		IEnumerable<Condition> f_ = context.Operators.Select<Encounter.DiagnosisComponent, Condition>(d_, e_);
		Condition g_ = context.Operators.SingletonFrom<Condition>(f_);

		return g_;
	}

    [CqlDeclaration("GetLocation")]
	public Location GetLocation(ResourceReference reference)
	{
		IEnumerable<Location> a_ = context.Operators.RetrieveByValueSet<Location>(null, null);
		bool? b_(Location L)
		{
			string e_ = context.Operators.Convert<string>(L?.IdElement);
			string f_ = context.Operators.Convert<string>(reference?.ReferenceElement);
			string g_ = this.GetId(f_);
			bool? h_ = context.Operators.Equal(e_, g_);

			return h_;
		};
		IEnumerable<Location> c_ = context.Operators.Where<Location>(a_, b_);
		Location d_ = context.Operators.SingletonFrom<Location>(c_);

		return d_;
	}

    [CqlDeclaration("GetBaseExtensions")]
	public IEnumerable<Extension> GetBaseExtensions(DomainResource domainResource, string url)
	{
		bool? a_(Extension E)
		{
			FhirUri e_ = context.Operators.Convert<FhirUri>(E?.Url);
			string f_ = context.Operators.Convert<string>(e_);
			string g_ = context.Operators.Concatenate("http://hl7.org/fhir/StructureDefinition/", url);
			bool? h_ = context.Operators.Equal(f_, g_);

			return h_;
		};
		IEnumerable<Extension> b_ = context.Operators.Where<Extension>((domainResource?.Extension as IEnumerable<Extension>), a_);
		Extension c_(Extension E) => 
			E;
		IEnumerable<Extension> d_ = context.Operators.Select<Extension, Extension>(b_, c_);

		return d_;
	}

    [CqlDeclaration("GetBaseExtension")]
	public Extension GetBaseExtension(DomainResource domainResource, string url)
	{
		IEnumerable<Extension> a_ = this.GetBaseExtensions(domainResource, url);
		Extension b_ = context.Operators.SingletonFrom<Extension>(a_);

		return b_;
	}

    [CqlDeclaration("BaseExtensions")]
    [CqlTag("description", "Returns any base-FHIR extensions defined on the given element with the specified id.")]
    [CqlTag("comment", "NOTE: Extensions are not the preferred approach, but are used as a way to access content that is defined by extensions but not yet surfaced in the CQL model info.")]
	public IEnumerable<Extension> BaseExtensions(Element element, string id)
	{
		bool? a_(Extension E)
		{
			FhirUri e_ = context.Operators.Convert<FhirUri>(E?.Url);
			string f_ = context.Operators.Convert<string>(e_);
			string g_ = context.Operators.Concatenate("http://hl7.org/fhir/StructureDefinition/", id);
			bool? h_ = context.Operators.Equal(f_, g_);

			return h_;
		};
		IEnumerable<Extension> b_ = context.Operators.Where<Extension>((element?.Extension as IEnumerable<Extension>), a_);
		Extension c_(Extension E) => 
			E;
		IEnumerable<Extension> d_ = context.Operators.Select<Extension, Extension>(b_, c_);

		return d_;
	}

    [CqlDeclaration("BaseExtension")]
    [CqlTag("description", "Returns the single base-FHIR extension (if present) on the given element with the specified id.")]
    [CqlTag("comment", "This function uses singleton from to ensure that a run-time exception is thrown if there is more than one extension on the given resource with the specified url.")]
	public Extension BaseExtension(Element element, string id)
	{
		IEnumerable<Extension> a_ = this.BaseExtensions(element, id);
		Extension b_ = context.Operators.SingletonFrom<Extension>(a_);

		return b_;
	}

    [CqlDeclaration("GetMedicationCode")]
	public CodeableConcept GetMedicationCode(MedicationRequest request)
	{
		CodeableConcept a_()
		{
			if (request?.Medication is CodeableConcept)
			{
				return (request?.Medication as CodeableConcept);
			}
			else
			{
				IEnumerable<Medication> b_ = context.Operators.RetrieveByValueSet<Medication>(null, null);
				bool? c_(Medication M)
				{
					string f_ = context.Operators.Convert<string>(M?.IdElement);
					string g_ = context.Operators.Convert<string>((request?.Medication as ResourceReference)?.ReferenceElement);
					string h_ = this.GetId(g_);
					bool? i_ = context.Operators.Equal(f_, h_);

					return i_;
				};
				IEnumerable<Medication> d_ = context.Operators.Where<Medication>(b_, c_);
				Medication e_ = context.Operators.SingletonFrom<Medication>(d_);

				return e_?.Code;
			};
		};

		return a_();
	}

    [CqlDeclaration("HasStart")]
	public bool? HasStart(CqlInterval<CqlDateTime> period)
	{
		CqlDateTime a_ = context.Operators.Start(period);
		CqlDateTime c_ = context.Operators.Minimum<CqlDateTime>();
		bool? d_ = context.Operators.Equal(a_, c_);
		bool? e_ = context.Operators.Or((bool?)(a_ is null), d_);
		bool? f_ = context.Operators.Not(e_);

		return f_;
	}

    [CqlDeclaration("HasEnd")]
	public bool? HasEnd(CqlInterval<CqlDateTime> period)
	{
		CqlDateTime a_ = context.Operators.End(period);
		CqlDateTime c_ = context.Operators.Maximum<CqlDateTime>();
		bool? d_ = context.Operators.Equal(a_, c_);
		bool? e_ = context.Operators.Or((bool?)(a_ is null), d_);
		bool? f_ = context.Operators.Not(e_);

		return f_;
	}

    [CqlDeclaration("Latest")]
	public CqlDateTime Latest(object choice)
	{
		CqlInterval<CqlDateTime> a_ = this.Normalize_Interval(choice);
		CqlInterval<CqlDateTime>[] b_ = new CqlInterval<CqlDateTime>[]
		{
			a_,
		};
		CqlDateTime c_(CqlInterval<CqlDateTime> period)
		{
			CqlDateTime f_()
			{
				if ((this.HasEnd(period) ?? false))
				{
					CqlDateTime g_ = context.Operators.End(period);

					return g_;
				}
				else
				{
					CqlDateTime h_ = context.Operators.Start(period);

					return h_;
				};
			};

			return f_();
		};
		IEnumerable<CqlDateTime> d_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDateTime>(b_, c_);
		CqlDateTime e_ = context.Operators.SingletonFrom<CqlDateTime>(d_);

		return e_;
	}

    [CqlDeclaration("Earliest")]
	public CqlDateTime Earliest(object choice)
	{
		CqlInterval<CqlDateTime> a_ = this.Normalize_Interval(choice);
		CqlInterval<CqlDateTime>[] b_ = new CqlInterval<CqlDateTime>[]
		{
			a_,
		};
		CqlDateTime c_(CqlInterval<CqlDateTime> period)
		{
			CqlDateTime f_()
			{
				if ((this.HasStart(period) ?? false))
				{
					CqlDateTime g_ = context.Operators.Start(period);

					return g_;
				}
				else
				{
					CqlDateTime h_ = context.Operators.End(period);

					return h_;
				};
			};

			return f_();
		};
		IEnumerable<CqlDateTime> d_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDateTime>(b_, c_);
		CqlDateTime e_ = context.Operators.SingletonFrom<CqlDateTime>(d_);

		return e_;
	}

}
