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
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", default);

    [CqlDeclaration("Emergency Department Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292")]
	public CqlValueSet Emergency_Department_Visit() => 
		__Emergency_Department_Visit.Value;

	private CqlValueSet Encounter_Inpatient_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", default);

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
	public CqlValueSet Encounter_Inpatient() => 
		__Encounter_Inpatient.Value;

	private CqlValueSet Observation_Services_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", default);

    [CqlDeclaration("Observation Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143")]
	public CqlValueSet Observation_Services() => 
		__Observation_Services.Value;

	private CqlValueSet Present_on_Admission_or_Clinically_Undetermined_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.197", default);

    [CqlDeclaration("Present on Admission or Clinically Undetermined")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.197")]
	public CqlValueSet Present_on_Admission_or_Clinically_Undetermined() => 
		__Present_on_Admission_or_Clinically_Undetermined.Value;

	private CqlCode active_Value() => 
		new CqlCode("active", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);

    [CqlDeclaration("active")]
	public CqlCode active() => 
		__active.Value;

	private CqlCode allergy_active_Value() => 
		new CqlCode("active", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", default, default);

    [CqlDeclaration("allergy-active")]
	public CqlCode allergy_active() => 
		__allergy_active.Value;

	private CqlCode allergy_confirmed_Value() => 
		new CqlCode("confirmed", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", default, default);

    [CqlDeclaration("allergy-confirmed")]
	public CqlCode allergy_confirmed() => 
		__allergy_confirmed.Value;

	private CqlCode allergy_inactive_Value() => 
		new CqlCode("inactive", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", default, default);

    [CqlDeclaration("allergy-inactive")]
	public CqlCode allergy_inactive() => 
		__allergy_inactive.Value;

	private CqlCode allergy_refuted_Value() => 
		new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", default, default);

    [CqlDeclaration("allergy-refuted")]
	public CqlCode allergy_refuted() => 
		__allergy_refuted.Value;

	private CqlCode allergy_resolved_Value() => 
		new CqlCode("resolved", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", default, default);

    [CqlDeclaration("allergy-resolved")]
	public CqlCode allergy_resolved() => 
		__allergy_resolved.Value;

	private CqlCode allergy_unconfirmed_Value() => 
		new CqlCode("unconfirmed", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", default, default);

    [CqlDeclaration("allergy-unconfirmed")]
	public CqlCode allergy_unconfirmed() => 
		__allergy_unconfirmed.Value;

	private CqlCode Billing_Value() => 
		new CqlCode("billing", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default);

    [CqlDeclaration("Billing")]
	public CqlCode Billing() => 
		__Billing.Value;

	private CqlCode Birthdate_Value() => 
		new CqlCode("21112-8", "http://loinc.org", default, default);

    [CqlDeclaration("Birthdate")]
	public CqlCode Birthdate() => 
		__Birthdate.Value;

	private CqlCode Community_Value() => 
		new CqlCode("community", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", default, default);

    [CqlDeclaration("Community")]
	public CqlCode Community() => 
		__Community.Value;

	private CqlCode confirmed_Value() => 
		new CqlCode("confirmed", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default);

    [CqlDeclaration("confirmed")]
	public CqlCode confirmed() => 
		__confirmed.Value;

	private CqlCode Dead_Value() => 
		new CqlCode("419099009", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Dead")]
	public CqlCode Dead() => 
		__Dead.Value;

	private CqlCode differential_Value() => 
		new CqlCode("differential", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default);

    [CqlDeclaration("differential")]
	public CqlCode differential() => 
		__differential.Value;

	private CqlCode Discharge_Value() => 
		new CqlCode("discharge", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", default, default);

    [CqlDeclaration("Discharge")]
	public CqlCode Discharge() => 
		__Discharge.Value;

	private CqlCode entered_in_error_Value() => 
		new CqlCode("entered-in-error", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default);

    [CqlDeclaration("entered-in-error")]
	public CqlCode entered_in_error() => 
		__entered_in_error.Value;

	private CqlCode ER_Value() => 
		new CqlCode("ER", "http://terminology.hl7.org/CodeSystem/v3-RoleCode", default, default);

    [CqlDeclaration("ER")]
	public CqlCode ER() => 
		__ER.Value;

	private CqlCode ICU_Value() => 
		new CqlCode("ICU", "http://terminology.hl7.org/CodeSystem/v3-RoleCode", default, default);

    [CqlDeclaration("ICU")]
	public CqlCode ICU() => 
		__ICU.Value;

	private CqlCode inactive_Value() => 
		new CqlCode("inactive", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);

    [CqlDeclaration("inactive")]
	public CqlCode inactive() => 
		__inactive.Value;

	private CqlCode provisional_Value() => 
		new CqlCode("provisional", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default);

    [CqlDeclaration("provisional")]
	public CqlCode provisional() => 
		__provisional.Value;

	private CqlCode recurrence_Value() => 
		new CqlCode("recurrence", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);

    [CqlDeclaration("recurrence")]
	public CqlCode recurrence() => 
		__recurrence.Value;

	private CqlCode refuted_Value() => 
		new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default);

    [CqlDeclaration("refuted")]
	public CqlCode refuted() => 
		__refuted.Value;

	private CqlCode relapse_Value() => 
		new CqlCode("relapse", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);

    [CqlDeclaration("relapse")]
	public CqlCode relapse() => 
		__relapse.Value;

	private CqlCode remission_Value() => 
		new CqlCode("remission", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);

    [CqlDeclaration("remission")]
	public CqlCode remission() => 
		__remission.Value;

	private CqlCode resolved_Value() => 
		new CqlCode("resolved", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default);

    [CqlDeclaration("resolved")]
	public CqlCode resolved() => 
		__resolved.Value;

	private CqlCode unconfirmed_Value() => 
		new CqlCode("unconfirmed", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default);

    [CqlDeclaration("unconfirmed")]
	public CqlCode unconfirmed() => 
		__unconfirmed.Value;

	private CqlCode[] ConditionClinicalStatusCodes_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("active", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default),
			new CqlCode("inactive", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default),
			new CqlCode("recurrence", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default),
			new CqlCode("relapse", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default),
			new CqlCode("remission", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default),
			new CqlCode("resolved", "http://terminology.hl7.org/CodeSystem/condition-clinical", default, default),
		];

		return a_;
	}

    [CqlDeclaration("ConditionClinicalStatusCodes")]
	public CqlCode[] ConditionClinicalStatusCodes() => 
		__ConditionClinicalStatusCodes.Value;

	private CqlCode[] AllergyIntoleranceClinicalStatusCodes_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("active", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", default, default),
			new CqlCode("inactive", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", default, default),
			new CqlCode("resolved", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", default, default),
		];

		return a_;
	}

    [CqlDeclaration("AllergyIntoleranceClinicalStatusCodes")]
	public CqlCode[] AllergyIntoleranceClinicalStatusCodes() => 
		__AllergyIntoleranceClinicalStatusCodes.Value;

	private CqlCode[] AllergyIntoleranceVerificationStatusCodes_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("confirmed", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", default, default),
			new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", default, default),
			new CqlCode("unconfirmed", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", default, default),
		];

		return a_;
	}

    [CqlDeclaration("AllergyIntoleranceVerificationStatusCodes")]
	public CqlCode[] AllergyIntoleranceVerificationStatusCodes() => 
		__AllergyIntoleranceVerificationStatusCodes.Value;

	private CqlCode[] Diagnosis_Role_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("billing", "http://terminology.hl7.org/CodeSystem/diagnosis-role", default, default),
		];

		return a_;
	}

    [CqlDeclaration("Diagnosis Role")]
	public CqlCode[] Diagnosis_Role() => 
		__Diagnosis_Role.Value;

	private CqlCode[] LOINC_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("21112-8", "http://loinc.org", default, default),
		];

		return a_;
	}

    [CqlDeclaration("LOINC")]
	public CqlCode[] LOINC() => 
		__LOINC.Value;

	private CqlCode[] MedicationRequestCategory_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("community", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", default, default),
			new CqlCode("discharge", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", default, default),
		];

		return a_;
	}

    [CqlDeclaration("MedicationRequestCategory")]
	public CqlCode[] MedicationRequestCategory() => 
		__MedicationRequestCategory.Value;

	private CqlCode[] ConditionVerificationStatusCodes_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("confirmed", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default),
			new CqlCode("differential", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default),
			new CqlCode("entered-in-error", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default),
			new CqlCode("provisional", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default),
			new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default),
			new CqlCode("unconfirmed", "http://terminology.hl7.org/CodeSystem/condition-ver-status", default, default),
		];

		return a_;
	}

    [CqlDeclaration("ConditionVerificationStatusCodes")]
	public CqlCode[] ConditionVerificationStatusCodes() => 
		__ConditionVerificationStatusCodes.Value;

	private CqlCode[] SNOMEDCT_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("419099009", "http://snomed.info/sct", default, default),
		];

		return a_;
	}

    [CqlDeclaration("SNOMEDCT")]
	public CqlCode[] SNOMEDCT() => 
		__SNOMEDCT.Value;

	private CqlCode[] RoleCode_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("ER", "http://terminology.hl7.org/CodeSystem/v3-RoleCode", default, default),
			new CqlCode("ICU", "http://terminology.hl7.org/CodeSystem/v3-RoleCode", default, default),
		];

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
		IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
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
		IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
		bool? c_(Encounter EncounterInpatient)
		{
			Code<Encounter.EncounterStatus> e_ = EncounterInpatient?.StatusElement;
			string f_ = FHIRHelpers_4_0_001.ToString(e_);
			bool? g_ = context.Operators.Equal(f_, "finished");
			Period h_ = EncounterInpatient?.Period;
			CqlInterval<CqlDateTime> i_ = FHIRHelpers_4_0_001.ToInterval(h_);
			int? j_ = this.LengthInDays(i_);
			bool? k_ = context.Operators.LessOrEqual(j_, 120);
			bool? l_ = context.Operators.And(g_, k_);
			CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_0_001.ToInterval(h_);
			CqlDateTime o_ = context.Operators.End(n_);
			CqlInterval<CqlDateTime> p_ = this.Measurement_Period();
			bool? q_ = context.Operators.In<CqlDateTime>(o_, p_, default);
			bool? r_ = context.Operators.And(l_, q_);

			return r_;
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
		IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
		bool? c_(Encounter EDVisit)
		{
			Code<Encounter.EncounterStatus> h_ = EDVisit?.StatusElement;
			string i_ = FHIRHelpers_4_0_001.ToString(h_);
			bool? j_ = context.Operators.Equal(i_, "finished");
			Period k_ = EDVisit?.Period;
			CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_0_001.ToInterval(k_);
			CqlDateTime m_ = context.Operators.End(l_);
			Period n_ = TheEncounter?.Period;
			CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_0_001.ToInterval(n_);
			CqlDateTime p_ = context.Operators.Start(o_);
			CqlQuantity q_ = context.Operators.Quantity(1m, "hour");
			CqlDateTime r_ = context.Operators.Subtract(p_, q_);
			CqlInterval<CqlDateTime> t_ = FHIRHelpers_4_0_001.ToInterval(n_);
			CqlDateTime u_ = context.Operators.Start(t_);
			CqlInterval<CqlDateTime> v_ = context.Operators.Interval(r_, u_, true, true);
			bool? w_ = context.Operators.In<CqlDateTime>(m_, v_, default);
			CqlInterval<CqlDateTime> y_ = FHIRHelpers_4_0_001.ToInterval(n_);
			CqlDateTime z_ = context.Operators.Start(y_);
			bool? aa_ = context.Operators.Not((bool?)(z_ is null));
			bool? ab_ = context.Operators.And(w_, aa_);
			bool? ac_ = context.Operators.And(j_, ab_);

			return ac_;
		};
		IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);
		object e_(Encounter @this)
		{
			Period ad_ = @this?.Period;
			CqlInterval<CqlDateTime> ae_ = FHIRHelpers_4_0_001.ToInterval(ad_);
			CqlDateTime af_ = context.Operators.End(ae_);

			return af_;
		};
		IEnumerable<Encounter> f_ = context.Operators.SortBy<Encounter>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
		Encounter g_ = context.Operators.Last<Encounter>(f_);

		return g_;
	}

    [CqlDeclaration("Hospitalization")]
	public CqlInterval<CqlDateTime> Hospitalization(Encounter TheEncounter)
	{
		Encounter a_ = this.ED_Visit(TheEncounter);
		Encounter[] b_ = [
			a_,
		];
		CqlInterval<CqlDateTime> c_(Encounter X)
		{
			CqlInterval<CqlDateTime> f_()
			{
				if (X is null)
				{
					Period g_ = TheEncounter?.Period;
					CqlInterval<CqlDateTime> h_ = FHIRHelpers_4_0_001.ToInterval(g_);

					return h_;
				}
				else
				{
					Period i_ = X?.Period;
					CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_0_001.ToInterval(i_);
					CqlDateTime k_ = context.Operators.Start(j_);
					Period l_ = TheEncounter?.Period;
					CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_0_001.ToInterval(l_);
					CqlDateTime n_ = context.Operators.End(m_);
					CqlInterval<CqlDateTime> o_ = context.Operators.Interval(k_, n_, true, true);

					return o_;
				}
			};

			return f_();
		};
		IEnumerable<CqlInterval<CqlDateTime>> d_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)b_, c_);
		CqlInterval<CqlDateTime> e_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(d_);

		return e_;
	}

    [CqlDeclaration("Hospitalization Locations")]
	public IEnumerable<Encounter.LocationComponent> Hospitalization_Locations(Encounter TheEncounter)
	{
		Encounter a_ = this.ED_Visit(TheEncounter);
		Encounter[] b_ = [
			a_,
		];
		IEnumerable<Encounter.LocationComponent> c_(Encounter EDEncounter)
		{
			IEnumerable<Encounter.LocationComponent> f_()
			{
				if (EDEncounter is null)
				{
					List<Encounter.LocationComponent> g_ = TheEncounter?.Location;

					return (IEnumerable<Encounter.LocationComponent>)g_;
				}
				else
				{
					List<Encounter.LocationComponent> h_ = EDEncounter?.Location;
					List<Encounter.LocationComponent> i_ = TheEncounter?.Location;
					IEnumerable<Encounter.LocationComponent>[] j_ = [
						(IEnumerable<Encounter.LocationComponent>)h_,
						(IEnumerable<Encounter.LocationComponent>)i_,
					];
					IEnumerable<Encounter.LocationComponent> k_ = context.Operators.Flatten<Encounter.LocationComponent>(j_ as IEnumerable<IEnumerable<Encounter.LocationComponent>>);

					return k_;
				}
			};

			return f_();
		};
		IEnumerable<IEnumerable<Encounter.LocationComponent>> d_ = context.Operators.Select<Encounter, IEnumerable<Encounter.LocationComponent>>((IEnumerable<Encounter>)b_, c_);
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
		Period a_ = TheEncounter?.Period;
		CqlInterval<CqlDateTime> b_ = FHIRHelpers_4_0_001.ToInterval(a_);
		CqlDateTime c_ = context.Operators.End(b_);

		return c_;
	}

    [CqlDeclaration("Hospital Arrival Time")]
	public CqlDateTime Hospital_Arrival_Time(Encounter TheEncounter)
	{
		IEnumerable<Encounter.LocationComponent> a_ = this.Hospitalization_Locations(TheEncounter);
		object b_(Encounter.LocationComponent @this)
		{
			Period h_ = @this?.Period;
			CqlInterval<CqlDateTime> i_ = FHIRHelpers_4_0_001.ToInterval(h_);
			CqlDateTime j_ = context.Operators.Start(i_);

			return j_;
		};
		IEnumerable<Encounter.LocationComponent> c_ = context.Operators.SortBy<Encounter.LocationComponent>(a_, b_, System.ComponentModel.ListSortDirection.Ascending);
		Encounter.LocationComponent d_ = context.Operators.First<Encounter.LocationComponent>(c_);
		Period e_ = d_?.Period;
		CqlInterval<CqlDateTime> f_ = FHIRHelpers_4_0_001.ToInterval(e_);
		CqlDateTime g_ = context.Operators.Start(f_);

		return g_;
	}

    [CqlDeclaration("HospitalizationWithObservation")]
	public CqlInterval<CqlDateTime> HospitalizationWithObservation(Encounter TheEncounter)
	{
		Encounter[] a_ = [
			TheEncounter,
		];
		CqlInterval<CqlDateTime> b_(Encounter Visit)
		{
			CqlValueSet e_ = this.Emergency_Department_Visit();
			IEnumerable<Encounter> f_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
			bool? g_(Encounter LastED)
			{
				Period af_ = LastED?.Period;
				CqlInterval<CqlDateTime> ag_ = FHIRHelpers_4_0_001.ToInterval(af_);
				CqlDateTime ah_ = context.Operators.End(ag_);
				CqlValueSet ai_ = this.Observation_Services();
				IEnumerable<Encounter> aj_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ai_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
				bool? ak_(Encounter LastObs)
				{
					Period cb_ = LastObs?.Period;
					CqlInterval<CqlDateTime> cc_ = FHIRHelpers_4_0_001.ToInterval(cb_);
					CqlDateTime cd_ = context.Operators.End(cc_);
					Period ce_ = Visit?.Period;
					CqlInterval<CqlDateTime> cf_ = FHIRHelpers_4_0_001.ToInterval(ce_);
					CqlDateTime cg_ = context.Operators.Start(cf_);
					CqlQuantity ch_ = context.Operators.Quantity(1m, "hour");
					CqlDateTime ci_ = context.Operators.Subtract(cg_, ch_);
					CqlInterval<CqlDateTime> ck_ = FHIRHelpers_4_0_001.ToInterval(ce_);
					CqlDateTime cl_ = context.Operators.Start(ck_);
					CqlInterval<CqlDateTime> cm_ = context.Operators.Interval(ci_, cl_, true, true);
					bool? cn_ = context.Operators.In<CqlDateTime>(cd_, cm_, default);
					CqlInterval<CqlDateTime> cp_ = FHIRHelpers_4_0_001.ToInterval(ce_);
					CqlDateTime cq_ = context.Operators.Start(cp_);
					bool? cr_ = context.Operators.Not((bool?)(cq_ is null));
					bool? cs_ = context.Operators.And(cn_, cr_);

					return cs_;
				};
				IEnumerable<Encounter> al_ = context.Operators.Where<Encounter>(aj_, ak_);
				object am_(Encounter @this)
				{
					Period ct_ = @this?.Period;
					CqlInterval<CqlDateTime> cu_ = FHIRHelpers_4_0_001.ToInterval(ct_);
					CqlDateTime cv_ = context.Operators.End(cu_);

					return cv_;
				};
				IEnumerable<Encounter> an_ = context.Operators.SortBy<Encounter>(al_, am_, System.ComponentModel.ListSortDirection.Ascending);
				Encounter ao_ = context.Operators.Last<Encounter>(an_);
				Period ap_ = ao_?.Period;
				CqlInterval<CqlDateTime> aq_ = FHIRHelpers_4_0_001.ToInterval(ap_);
				CqlDateTime ar_ = context.Operators.Start(aq_);
				Period as_ = Visit?.Period;
				CqlInterval<CqlDateTime> at_ = FHIRHelpers_4_0_001.ToInterval(as_);
				CqlDateTime au_ = context.Operators.Start(at_);
				CqlQuantity av_ = context.Operators.Quantity(1m, "hour");
				CqlDateTime aw_ = context.Operators.Subtract(ar_ ?? au_, av_);
				IEnumerable<Encounter> ay_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ai_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
				bool? az_(Encounter LastObs)
				{
					Period cw_ = LastObs?.Period;
					CqlInterval<CqlDateTime> cx_ = FHIRHelpers_4_0_001.ToInterval(cw_);
					CqlDateTime cy_ = context.Operators.End(cx_);
					Period cz_ = Visit?.Period;
					CqlInterval<CqlDateTime> da_ = FHIRHelpers_4_0_001.ToInterval(cz_);
					CqlDateTime db_ = context.Operators.Start(da_);
					CqlQuantity dc_ = context.Operators.Quantity(1m, "hour");
					CqlDateTime dd_ = context.Operators.Subtract(db_, dc_);
					CqlInterval<CqlDateTime> df_ = FHIRHelpers_4_0_001.ToInterval(cz_);
					CqlDateTime dg_ = context.Operators.Start(df_);
					CqlInterval<CqlDateTime> dh_ = context.Operators.Interval(dd_, dg_, true, true);
					bool? di_ = context.Operators.In<CqlDateTime>(cy_, dh_, default);
					CqlInterval<CqlDateTime> dk_ = FHIRHelpers_4_0_001.ToInterval(cz_);
					CqlDateTime dl_ = context.Operators.Start(dk_);
					bool? dm_ = context.Operators.Not((bool?)(dl_ is null));
					bool? dn_ = context.Operators.And(di_, dm_);

					return dn_;
				};
				IEnumerable<Encounter> ba_ = context.Operators.Where<Encounter>(ay_, az_);
				object bb_(Encounter @this)
				{
					Period do_ = @this?.Period;
					CqlInterval<CqlDateTime> dp_ = FHIRHelpers_4_0_001.ToInterval(do_);
					CqlDateTime dq_ = context.Operators.End(dp_);

					return dq_;
				};
				IEnumerable<Encounter> bc_ = context.Operators.SortBy<Encounter>(ba_, bb_, System.ComponentModel.ListSortDirection.Ascending);
				Encounter bd_ = context.Operators.Last<Encounter>(bc_);
				Period be_ = bd_?.Period;
				CqlInterval<CqlDateTime> bf_ = FHIRHelpers_4_0_001.ToInterval(be_);
				CqlDateTime bg_ = context.Operators.Start(bf_);
				CqlInterval<CqlDateTime> bi_ = FHIRHelpers_4_0_001.ToInterval(as_);
				CqlDateTime bj_ = context.Operators.Start(bi_);
				CqlInterval<CqlDateTime> bk_ = context.Operators.Interval(aw_, bg_ ?? bj_, true, true);
				bool? bl_ = context.Operators.In<CqlDateTime>(ah_, bk_, default);
				IEnumerable<Encounter> bn_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ai_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
				bool? bo_(Encounter LastObs)
				{
					Period dr_ = LastObs?.Period;
					CqlInterval<CqlDateTime> ds_ = FHIRHelpers_4_0_001.ToInterval(dr_);
					CqlDateTime dt_ = context.Operators.End(ds_);
					Period du_ = Visit?.Period;
					CqlInterval<CqlDateTime> dv_ = FHIRHelpers_4_0_001.ToInterval(du_);
					CqlDateTime dw_ = context.Operators.Start(dv_);
					CqlQuantity dx_ = context.Operators.Quantity(1m, "hour");
					CqlDateTime dy_ = context.Operators.Subtract(dw_, dx_);
					CqlInterval<CqlDateTime> ea_ = FHIRHelpers_4_0_001.ToInterval(du_);
					CqlDateTime eb_ = context.Operators.Start(ea_);
					CqlInterval<CqlDateTime> ec_ = context.Operators.Interval(dy_, eb_, true, true);
					bool? ed_ = context.Operators.In<CqlDateTime>(dt_, ec_, default);
					CqlInterval<CqlDateTime> ef_ = FHIRHelpers_4_0_001.ToInterval(du_);
					CqlDateTime eg_ = context.Operators.Start(ef_);
					bool? eh_ = context.Operators.Not((bool?)(eg_ is null));
					bool? ei_ = context.Operators.And(ed_, eh_);

					return ei_;
				};
				IEnumerable<Encounter> bp_ = context.Operators.Where<Encounter>(bn_, bo_);
				object bq_(Encounter @this)
				{
					Period ej_ = @this?.Period;
					CqlInterval<CqlDateTime> ek_ = FHIRHelpers_4_0_001.ToInterval(ej_);
					CqlDateTime el_ = context.Operators.End(ek_);

					return el_;
				};
				IEnumerable<Encounter> br_ = context.Operators.SortBy<Encounter>(bp_, bq_, System.ComponentModel.ListSortDirection.Ascending);
				Encounter bs_ = context.Operators.Last<Encounter>(br_);
				Period bt_ = bs_?.Period;
				CqlInterval<CqlDateTime> bu_ = FHIRHelpers_4_0_001.ToInterval(bt_);
				CqlDateTime bv_ = context.Operators.Start(bu_);
				CqlInterval<CqlDateTime> bx_ = FHIRHelpers_4_0_001.ToInterval(as_);
				CqlDateTime by_ = context.Operators.Start(bx_);
				bool? bz_ = context.Operators.Not((bool?)((bv_ ?? by_) is null));
				bool? ca_ = context.Operators.And(bl_, bz_);

				return ca_;
			};
			IEnumerable<Encounter> h_ = context.Operators.Where<Encounter>(f_, g_);
			object i_(Encounter @this)
			{
				Period em_ = @this?.Period;
				CqlInterval<CqlDateTime> en_ = FHIRHelpers_4_0_001.ToInterval(em_);
				CqlDateTime eo_ = context.Operators.End(en_);

				return eo_;
			};
			IEnumerable<Encounter> j_ = context.Operators.SortBy<Encounter>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
			Encounter k_ = context.Operators.Last<Encounter>(j_);
			Period l_ = k_?.Period;
			CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_0_001.ToInterval(l_);
			CqlDateTime n_ = context.Operators.Start(m_);
			CqlValueSet o_ = this.Observation_Services();
			IEnumerable<Encounter> p_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));
			bool? q_(Encounter LastObs)
			{
				Period ep_ = LastObs?.Period;
				CqlInterval<CqlDateTime> eq_ = FHIRHelpers_4_0_001.ToInterval(ep_);
				CqlDateTime er_ = context.Operators.End(eq_);
				Period es_ = Visit?.Period;
				CqlInterval<CqlDateTime> et_ = FHIRHelpers_4_0_001.ToInterval(es_);
				CqlDateTime eu_ = context.Operators.Start(et_);
				CqlQuantity ev_ = context.Operators.Quantity(1m, "hour");
				CqlDateTime ew_ = context.Operators.Subtract(eu_, ev_);
				CqlInterval<CqlDateTime> ey_ = FHIRHelpers_4_0_001.ToInterval(es_);
				CqlDateTime ez_ = context.Operators.Start(ey_);
				CqlInterval<CqlDateTime> fa_ = context.Operators.Interval(ew_, ez_, true, true);
				bool? fb_ = context.Operators.In<CqlDateTime>(er_, fa_, default);
				CqlInterval<CqlDateTime> fd_ = FHIRHelpers_4_0_001.ToInterval(es_);
				CqlDateTime fe_ = context.Operators.Start(fd_);
				bool? ff_ = context.Operators.Not((bool?)(fe_ is null));
				bool? fg_ = context.Operators.And(fb_, ff_);

				return fg_;
			};
			IEnumerable<Encounter> r_ = context.Operators.Where<Encounter>(p_, q_);
			object s_(Encounter @this)
			{
				Period fh_ = @this?.Period;
				CqlInterval<CqlDateTime> fi_ = FHIRHelpers_4_0_001.ToInterval(fh_);
				CqlDateTime fj_ = context.Operators.End(fi_);

				return fj_;
			};
			IEnumerable<Encounter> t_ = context.Operators.SortBy<Encounter>(r_, s_, System.ComponentModel.ListSortDirection.Ascending);
			Encounter u_ = context.Operators.Last<Encounter>(t_);
			Period v_ = u_?.Period;
			CqlInterval<CqlDateTime> w_ = FHIRHelpers_4_0_001.ToInterval(v_);
			CqlDateTime x_ = context.Operators.Start(w_);
			Period y_ = Visit?.Period;
			CqlInterval<CqlDateTime> z_ = FHIRHelpers_4_0_001.ToInterval(y_);
			CqlDateTime aa_ = context.Operators.Start(z_);
			CqlInterval<CqlDateTime> ac_ = FHIRHelpers_4_0_001.ToInterval(y_);
			CqlDateTime ad_ = context.Operators.End(ac_);
			CqlInterval<CqlDateTime> ae_ = context.Operators.Interval(n_ ?? x_ ?? aa_, ad_, true, true);

			return ae_;
		};
		IEnumerable<CqlInterval<CqlDateTime>> c_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter>)a_, b_);
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
				CqlDateTime b_ = FHIRHelpers_4_0_001.ToDateTime(choice as FhirDateTime);
				CqlInterval<CqlDateTime> d_ = context.Operators.Interval(b_, b_, true, true);

				return d_;
			}
			else if (choice is Period)
			{
				CqlInterval<CqlDateTime> e_ = FHIRHelpers_4_0_001.ToInterval(choice as Period);

				return e_;
			}
			else if (choice is Instant)
			{
				CqlDateTime f_ = FHIRHelpers_4_0_001.ToDateTime(choice as Instant);
				CqlInterval<CqlDateTime> h_ = context.Operators.Interval(f_, f_, true, true);

				return h_;
			}
			else if (choice is Age)
			{
				Patient i_ = this.Patient();
				Date j_ = i_?.BirthDateElement;
				CqlDate k_ = FHIRHelpers_4_0_001.ToDate(j_);
				CqlQuantity l_ = FHIRHelpers_4_0_001.ToQuantity(choice as Age);
				CqlDate m_ = context.Operators.Add(k_, l_);
				Date o_ = i_?.BirthDateElement;
				CqlDate p_ = FHIRHelpers_4_0_001.ToDate(o_);
				CqlDate r_ = context.Operators.Add(p_, l_);
				CqlQuantity s_ = context.Operators.Quantity(1m, "year");
				CqlDate t_ = context.Operators.Add(r_, s_);
				CqlInterval<CqlDate> u_ = context.Operators.Interval(m_, t_, true, false);
				CqlDate v_ = u_?.low;
				CqlDateTime w_ = context.Operators.ConvertDateToDateTime(v_);
				Date y_ = i_?.BirthDateElement;
				CqlDate z_ = FHIRHelpers_4_0_001.ToDate(y_);
				CqlDate ab_ = context.Operators.Add(z_, l_);
				Date ad_ = i_?.BirthDateElement;
				CqlDate ae_ = FHIRHelpers_4_0_001.ToDate(ad_);
				CqlDate ag_ = context.Operators.Add(ae_, l_);
				CqlDate ai_ = context.Operators.Add(ag_, s_);
				CqlInterval<CqlDate> aj_ = context.Operators.Interval(ab_, ai_, true, false);
				CqlDate ak_ = aj_?.high;
				CqlDateTime al_ = context.Operators.ConvertDateToDateTime(ak_);
				Date an_ = i_?.BirthDateElement;
				CqlDate ao_ = FHIRHelpers_4_0_001.ToDate(an_);
				CqlDate aq_ = context.Operators.Add(ao_, l_);
				Date as_ = i_?.BirthDateElement;
				CqlDate at_ = FHIRHelpers_4_0_001.ToDate(as_);
				CqlDate av_ = context.Operators.Add(at_, l_);
				CqlDate ax_ = context.Operators.Add(av_, s_);
				CqlInterval<CqlDate> ay_ = context.Operators.Interval(aq_, ax_, true, false);
				bool? az_ = ay_?.lowClosed;
				Date bb_ = i_?.BirthDateElement;
				CqlDate bc_ = FHIRHelpers_4_0_001.ToDate(bb_);
				CqlDate be_ = context.Operators.Add(bc_, l_);
				Date bg_ = i_?.BirthDateElement;
				CqlDate bh_ = FHIRHelpers_4_0_001.ToDate(bg_);
				CqlDate bj_ = context.Operators.Add(bh_, l_);
				CqlDate bl_ = context.Operators.Add(bj_, s_);
				CqlInterval<CqlDate> bm_ = context.Operators.Interval(be_, bl_, true, false);
				bool? bn_ = bm_?.highClosed;
				CqlInterval<CqlDateTime> bo_ = context.Operators.Interval(w_, al_, az_, bn_);

				return bo_;
			}
			else if (choice is Range)
			{
				Patient bp_ = this.Patient();
				Date bq_ = bp_?.BirthDateElement;
				CqlDate br_ = FHIRHelpers_4_0_001.ToDate(bq_);
				Quantity bs_ = (choice as Range)?.Low;
				CqlQuantity bt_ = FHIRHelpers_4_0_001.ToQuantity(bs_);
				CqlDate bu_ = context.Operators.Add(br_, bt_);
				Date bw_ = bp_?.BirthDateElement;
				CqlDate bx_ = FHIRHelpers_4_0_001.ToDate(bw_);
				Quantity by_ = (choice as Range)?.High;
				CqlQuantity bz_ = FHIRHelpers_4_0_001.ToQuantity(by_);
				CqlDate ca_ = context.Operators.Add(bx_, bz_);
				CqlQuantity cb_ = context.Operators.Quantity(1m, "year");
				CqlDate cc_ = context.Operators.Add(ca_, cb_);
				CqlInterval<CqlDate> cd_ = context.Operators.Interval(bu_, cc_, true, false);
				CqlDate ce_ = cd_?.low;
				CqlDateTime cf_ = context.Operators.ConvertDateToDateTime(ce_);
				Date ch_ = bp_?.BirthDateElement;
				CqlDate ci_ = FHIRHelpers_4_0_001.ToDate(ch_);
				CqlQuantity ck_ = FHIRHelpers_4_0_001.ToQuantity(bs_);
				CqlDate cl_ = context.Operators.Add(ci_, ck_);
				Date cn_ = bp_?.BirthDateElement;
				CqlDate co_ = FHIRHelpers_4_0_001.ToDate(cn_);
				CqlQuantity cq_ = FHIRHelpers_4_0_001.ToQuantity(by_);
				CqlDate cr_ = context.Operators.Add(co_, cq_);
				CqlDate ct_ = context.Operators.Add(cr_, cb_);
				CqlInterval<CqlDate> cu_ = context.Operators.Interval(cl_, ct_, true, false);
				CqlDate cv_ = cu_?.high;
				CqlDateTime cw_ = context.Operators.ConvertDateToDateTime(cv_);
				Date cy_ = bp_?.BirthDateElement;
				CqlDate cz_ = FHIRHelpers_4_0_001.ToDate(cy_);
				CqlQuantity db_ = FHIRHelpers_4_0_001.ToQuantity(bs_);
				CqlDate dc_ = context.Operators.Add(cz_, db_);
				Date de_ = bp_?.BirthDateElement;
				CqlDate df_ = FHIRHelpers_4_0_001.ToDate(de_);
				CqlQuantity dh_ = FHIRHelpers_4_0_001.ToQuantity(by_);
				CqlDate di_ = context.Operators.Add(df_, dh_);
				CqlDate dk_ = context.Operators.Add(di_, cb_);
				CqlInterval<CqlDate> dl_ = context.Operators.Interval(dc_, dk_, true, false);
				bool? dm_ = dl_?.lowClosed;
				Date do_ = bp_?.BirthDateElement;
				CqlDate dp_ = FHIRHelpers_4_0_001.ToDate(do_);
				CqlQuantity dr_ = FHIRHelpers_4_0_001.ToQuantity(bs_);
				CqlDate ds_ = context.Operators.Add(dp_, dr_);
				Date du_ = bp_?.BirthDateElement;
				CqlDate dv_ = FHIRHelpers_4_0_001.ToDate(du_);
				CqlQuantity dx_ = FHIRHelpers_4_0_001.ToQuantity(by_);
				CqlDate dy_ = context.Operators.Add(dv_, dx_);
				CqlDate ea_ = context.Operators.Add(dy_, cb_);
				CqlInterval<CqlDate> eb_ = context.Operators.Interval(ds_, ea_, true, false);
				bool? ec_ = eb_?.highClosed;
				CqlInterval<CqlDateTime> ed_ = context.Operators.Interval(cf_, cw_, dm_, ec_);

				return ed_;
			}
			else if (choice is Timing)
			{
				CqlInterval<CqlDateTime> ee_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute a single interval from a Timing type");

				return ee_;
			}
			else if (choice is FhirString)
			{
				CqlInterval<CqlDateTime> ef_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute an interval from a String value");

				return ef_;
			}
			else
			{
				return null as CqlInterval<CqlDateTime>;
			}
		};

		return a_();
	}

    [CqlDeclaration("Normalize Abatement")]
	public CqlInterval<CqlDateTime> Normalize_Abatement(Condition condition)
	{
		CqlInterval<CqlDateTime> a_()
		{
			bool b_()
			{
				DataType h_ = condition?.Abatement;
				bool i_ = h_ is FhirDateTime;

				return i_;
			};
			bool c_()
			{
				DataType j_ = condition?.Abatement;
				bool k_ = j_ is Period;

				return k_;
			};
			bool d_()
			{
				DataType l_ = condition?.Abatement;
				bool m_ = l_ is FhirString;

				return m_;
			};
			bool e_()
			{
				DataType n_ = condition?.Abatement;
				bool o_ = n_ is Age;

				return o_;
			};
			bool f_()
			{
				DataType p_ = condition?.Abatement;
				bool q_ = p_ is Range;

				return q_;
			};
			bool g_()
			{
				DataType r_ = condition?.Abatement;
				bool s_ = r_ is FhirBoolean;

				return s_;
			};
			if (b_())
			{
				DataType t_ = condition?.Abatement;
				CqlDateTime u_ = FHIRHelpers_4_0_001.ToDateTime(t_ as FhirDateTime);
				CqlDateTime w_ = FHIRHelpers_4_0_001.ToDateTime(t_ as FhirDateTime);
				CqlInterval<CqlDateTime> x_ = context.Operators.Interval(u_, w_, true, true);

				return x_;
			}
			else if (c_())
			{
				DataType y_ = condition?.Abatement;
				CqlInterval<CqlDateTime> z_ = FHIRHelpers_4_0_001.ToInterval(y_ as Period);

				return z_;
			}
			else if (d_())
			{
				CqlInterval<CqlDateTime> aa_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute an interval from a String value");

				return aa_;
			}
			else if (e_())
			{
				Patient ab_ = this.Patient();
				Date ac_ = ab_?.BirthDateElement;
				CqlDate ad_ = FHIRHelpers_4_0_001.ToDate(ac_);
				DataType ae_ = condition?.Abatement;
				CqlQuantity af_ = FHIRHelpers_4_0_001.ToQuantity(ae_ as Age);
				CqlDate ag_ = context.Operators.Add(ad_, af_);
				Date ai_ = ab_?.BirthDateElement;
				CqlDate aj_ = FHIRHelpers_4_0_001.ToDate(ai_);
				CqlQuantity al_ = FHIRHelpers_4_0_001.ToQuantity(ae_ as Age);
				CqlDate am_ = context.Operators.Add(aj_, al_);
				CqlQuantity an_ = context.Operators.Quantity(1m, "year");
				CqlDate ao_ = context.Operators.Add(am_, an_);
				CqlInterval<CqlDate> ap_ = context.Operators.Interval(ag_, ao_, true, false);
				CqlDate aq_ = ap_?.low;
				CqlDateTime ar_ = context.Operators.ConvertDateToDateTime(aq_);
				Date at_ = ab_?.BirthDateElement;
				CqlDate au_ = FHIRHelpers_4_0_001.ToDate(at_);
				CqlQuantity aw_ = FHIRHelpers_4_0_001.ToQuantity(ae_ as Age);
				CqlDate ax_ = context.Operators.Add(au_, aw_);
				Date az_ = ab_?.BirthDateElement;
				CqlDate ba_ = FHIRHelpers_4_0_001.ToDate(az_);
				CqlQuantity bc_ = FHIRHelpers_4_0_001.ToQuantity(ae_ as Age);
				CqlDate bd_ = context.Operators.Add(ba_, bc_);
				CqlDate bf_ = context.Operators.Add(bd_, an_);
				CqlInterval<CqlDate> bg_ = context.Operators.Interval(ax_, bf_, true, false);
				CqlDate bh_ = bg_?.high;
				CqlDateTime bi_ = context.Operators.ConvertDateToDateTime(bh_);
				Date bk_ = ab_?.BirthDateElement;
				CqlDate bl_ = FHIRHelpers_4_0_001.ToDate(bk_);
				CqlQuantity bn_ = FHIRHelpers_4_0_001.ToQuantity(ae_ as Age);
				CqlDate bo_ = context.Operators.Add(bl_, bn_);
				Date bq_ = ab_?.BirthDateElement;
				CqlDate br_ = FHIRHelpers_4_0_001.ToDate(bq_);
				CqlQuantity bt_ = FHIRHelpers_4_0_001.ToQuantity(ae_ as Age);
				CqlDate bu_ = context.Operators.Add(br_, bt_);
				CqlDate bw_ = context.Operators.Add(bu_, an_);
				CqlInterval<CqlDate> bx_ = context.Operators.Interval(bo_, bw_, true, false);
				bool? by_ = bx_?.lowClosed;
				Date ca_ = ab_?.BirthDateElement;
				CqlDate cb_ = FHIRHelpers_4_0_001.ToDate(ca_);
				CqlQuantity cd_ = FHIRHelpers_4_0_001.ToQuantity(ae_ as Age);
				CqlDate ce_ = context.Operators.Add(cb_, cd_);
				Date cg_ = ab_?.BirthDateElement;
				CqlDate ch_ = FHIRHelpers_4_0_001.ToDate(cg_);
				CqlQuantity cj_ = FHIRHelpers_4_0_001.ToQuantity(ae_ as Age);
				CqlDate ck_ = context.Operators.Add(ch_, cj_);
				CqlDate cm_ = context.Operators.Add(ck_, an_);
				CqlInterval<CqlDate> cn_ = context.Operators.Interval(ce_, cm_, true, false);
				bool? co_ = cn_?.highClosed;
				CqlInterval<CqlDateTime> cp_ = context.Operators.Interval(ar_, bi_, by_, co_);

				return cp_;
			}
			else if (f_())
			{
				Patient cq_ = this.Patient();
				Date cr_ = cq_?.BirthDateElement;
				CqlDate cs_ = FHIRHelpers_4_0_001.ToDate(cr_);
				DataType ct_ = condition?.Abatement;
				Quantity cu_ = (ct_ as Range)?.Low;
				CqlQuantity cv_ = FHIRHelpers_4_0_001.ToQuantity(cu_);
				CqlDate cw_ = context.Operators.Add(cs_, cv_);
				Date cy_ = cq_?.BirthDateElement;
				CqlDate cz_ = FHIRHelpers_4_0_001.ToDate(cy_);
				Quantity db_ = (ct_ as Range)?.High;
				CqlQuantity dc_ = FHIRHelpers_4_0_001.ToQuantity(db_);
				CqlDate dd_ = context.Operators.Add(cz_, dc_);
				CqlQuantity de_ = context.Operators.Quantity(1m, "year");
				CqlDate df_ = context.Operators.Add(dd_, de_);
				CqlInterval<CqlDate> dg_ = context.Operators.Interval(cw_, df_, true, false);
				CqlDate dh_ = dg_?.low;
				CqlDateTime di_ = context.Operators.ConvertDateToDateTime(dh_);
				Date dk_ = cq_?.BirthDateElement;
				CqlDate dl_ = FHIRHelpers_4_0_001.ToDate(dk_);
				Quantity dn_ = (ct_ as Range)?.Low;
				CqlQuantity do_ = FHIRHelpers_4_0_001.ToQuantity(dn_);
				CqlDate dp_ = context.Operators.Add(dl_, do_);
				Date dr_ = cq_?.BirthDateElement;
				CqlDate ds_ = FHIRHelpers_4_0_001.ToDate(dr_);
				Quantity du_ = (ct_ as Range)?.High;
				CqlQuantity dv_ = FHIRHelpers_4_0_001.ToQuantity(du_);
				CqlDate dw_ = context.Operators.Add(ds_, dv_);
				CqlDate dy_ = context.Operators.Add(dw_, de_);
				CqlInterval<CqlDate> dz_ = context.Operators.Interval(dp_, dy_, true, false);
				CqlDate ea_ = dz_?.high;
				CqlDateTime eb_ = context.Operators.ConvertDateToDateTime(ea_);
				Date ed_ = cq_?.BirthDateElement;
				CqlDate ee_ = FHIRHelpers_4_0_001.ToDate(ed_);
				Quantity eg_ = (ct_ as Range)?.Low;
				CqlQuantity eh_ = FHIRHelpers_4_0_001.ToQuantity(eg_);
				CqlDate ei_ = context.Operators.Add(ee_, eh_);
				Date ek_ = cq_?.BirthDateElement;
				CqlDate el_ = FHIRHelpers_4_0_001.ToDate(ek_);
				Quantity en_ = (ct_ as Range)?.High;
				CqlQuantity eo_ = FHIRHelpers_4_0_001.ToQuantity(en_);
				CqlDate ep_ = context.Operators.Add(el_, eo_);
				CqlDate er_ = context.Operators.Add(ep_, de_);
				CqlInterval<CqlDate> es_ = context.Operators.Interval(ei_, er_, true, false);
				bool? et_ = es_?.lowClosed;
				Date ev_ = cq_?.BirthDateElement;
				CqlDate ew_ = FHIRHelpers_4_0_001.ToDate(ev_);
				Quantity ey_ = (ct_ as Range)?.Low;
				CqlQuantity ez_ = FHIRHelpers_4_0_001.ToQuantity(ey_);
				CqlDate fa_ = context.Operators.Add(ew_, ez_);
				Date fc_ = cq_?.BirthDateElement;
				CqlDate fd_ = FHIRHelpers_4_0_001.ToDate(fc_);
				Quantity ff_ = (ct_ as Range)?.High;
				CqlQuantity fg_ = FHIRHelpers_4_0_001.ToQuantity(ff_);
				CqlDate fh_ = context.Operators.Add(fd_, fg_);
				CqlDate fj_ = context.Operators.Add(fh_, de_);
				CqlInterval<CqlDate> fk_ = context.Operators.Interval(fa_, fj_, true, false);
				bool? fl_ = fk_?.highClosed;
				CqlInterval<CqlDateTime> fm_ = context.Operators.Interval(di_, eb_, et_, fl_);

				return fm_;
			}
			else if (g_())
			{
				DataType fn_ = condition?.Onset;
				CqlInterval<CqlDateTime> fo_ = this.Normalize_Interval(fn_);
				CqlDateTime fp_ = context.Operators.End(fo_);
				FhirDateTime fq_ = condition?.RecordedDateElement;
				CqlDateTime fr_ = FHIRHelpers_4_0_001.ToDateTime(fq_);
				CqlInterval<CqlDateTime> fs_ = context.Operators.Interval(fp_, fr_, true, false);

				return fs_;
			}
			else
			{
				return null as CqlInterval<CqlDateTime>;
			}
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
				CodeableConcept c_ = condition?.ClinicalStatus;
				CqlConcept d_ = FHIRHelpers_4_0_001.ToConcept(c_);
				CqlCode e_ = this.active();
				CqlConcept f_ = context.Operators.ConvertCodeToConcept(e_);
				bool? g_ = context.Operators.Equivalent(d_, f_);
				CqlConcept i_ = FHIRHelpers_4_0_001.ToConcept(c_);
				CqlCode j_ = this.recurrence();
				CqlConcept k_ = context.Operators.ConvertCodeToConcept(j_);
				bool? l_ = context.Operators.Equivalent(i_, k_);
				bool? m_ = context.Operators.Or(g_, l_);
				CqlConcept o_ = FHIRHelpers_4_0_001.ToConcept(c_);
				CqlCode p_ = this.relapse();
				CqlConcept q_ = context.Operators.ConvertCodeToConcept(p_);
				bool? r_ = context.Operators.Equivalent(o_, q_);
				bool? s_ = context.Operators.Or(m_, r_);

				return s_ ?? false;
			};
			if (b_())
			{
				DataType t_ = condition?.Onset;
				CqlInterval<CqlDateTime> u_ = this.Normalize_Interval(t_);
				CqlDateTime v_ = context.Operators.Start(u_);
				CqlInterval<CqlDateTime> w_ = this.Normalize_Abatement(condition);
				CqlDateTime x_ = context.Operators.End(w_);
				CqlInterval<CqlDateTime> y_ = context.Operators.Interval(v_, x_, true, true);

				return y_;
			}
			else
			{
				DataType z_ = condition?.Onset;
				CqlInterval<CqlDateTime> aa_ = this.Normalize_Interval(z_);
				CqlDateTime ab_ = context.Operators.Start(aa_);
				CqlInterval<CqlDateTime> ac_ = this.Normalize_Abatement(condition);
				CqlDateTime ad_ = context.Operators.End(ac_);
				CqlInterval<CqlDateTime> ae_ = context.Operators.Interval(ab_, ad_, true, false);

				return ae_;
			}
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
		List<Encounter.DiagnosisComponent> a_ = Encounter?.Diagnosis;
		Condition b_(Encounter.DiagnosisComponent D)
		{
			IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
			bool? e_(Condition C)
			{
				Id h_ = C?.IdElement;
				string i_ = FHIRHelpers_4_0_001.ToString(h_);
				ResourceReference j_ = D?.Condition;
				FhirString k_ = j_?.ReferenceElement;
				string l_ = FHIRHelpers_4_0_001.ToString(k_);
				string m_ = this.GetId(l_);
				bool? n_ = context.Operators.Equal(i_, m_);

				return n_;
			};
			IEnumerable<Condition> f_ = context.Operators.Where<Condition>(d_, e_);
			Condition g_ = context.Operators.SingletonFrom<Condition>(f_);

			return g_;
		};
		IEnumerable<Condition> c_ = context.Operators.Select<Encounter.DiagnosisComponent, Condition>((IEnumerable<Encounter.DiagnosisComponent>)a_, b_);

		return c_;
	}

    [CqlDeclaration("GetCondition")]
	public Condition GetCondition(ResourceReference reference)
	{
		IEnumerable<Condition> a_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
		bool? b_(Condition C)
		{
			Id e_ = C?.IdElement;
			string f_ = FHIRHelpers_4_0_001.ToString(e_);
			FhirString g_ = reference?.ReferenceElement;
			string h_ = FHIRHelpers_4_0_001.ToString(g_);
			string i_ = this.GetId(h_);
			bool? j_ = context.Operators.Equal(f_, i_);

			return j_;
		};
		IEnumerable<Condition> c_ = context.Operators.Where<Condition>(a_, b_);
		Condition d_ = context.Operators.SingletonFrom<Condition>(c_);

		return d_;
	}

    [CqlDeclaration("GetExtensions")]
	public IEnumerable<Extension> GetExtensions(DomainResource domainResource, string url)
	{
		List<Extension> a_ = domainResource?.Extension;
		bool? b_(Extension E)
		{
			string f_ = E?.Url;
			FhirUri g_ = context.Operators.Convert<FhirUri>(f_);
			string h_ = FHIRHelpers_4_0_001.ToString(g_);
			string i_ = context.Operators.Concatenate("http://hl7.org/fhir/us/qicore/StructureDefinition/", url);
			bool? j_ = context.Operators.Equal(h_, i_);

			return j_;
		};
		IEnumerable<Extension> c_ = context.Operators.Where<Extension>((IEnumerable<Extension>)a_, b_);
		Extension d_(Extension E) => 
			E;
		IEnumerable<Extension> e_ = context.Operators.Select<Extension, Extension>(c_, d_);

		return e_;
	}

    [CqlDeclaration("GetExtensions")]
	public IEnumerable<Extension> GetExtensions(Element element, string url)
	{
		List<Extension> a_ = element?.Extension;
		bool? b_(Extension E)
		{
			string f_ = E?.Url;
			FhirUri g_ = context.Operators.Convert<FhirUri>(f_);
			string h_ = FHIRHelpers_4_0_001.ToString(g_);
			bool? i_ = context.Operators.Equal(h_, url);

			return i_;
		};
		IEnumerable<Extension> c_ = context.Operators.Where<Extension>((IEnumerable<Extension>)a_, b_);
		Extension d_(Extension E) => 
			E;
		IEnumerable<Extension> e_ = context.Operators.Select<Extension, Extension>(c_, d_);

		return e_;
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
		DataType b_ = a_?.Value;

		return b_ as CodeableConcept;
	}

    [CqlDeclaration("PrincipalDiagnosis")]
	public Condition PrincipalDiagnosis(Encounter Encounter)
	{
		List<Encounter.DiagnosisComponent> a_ = Encounter?.Diagnosis;
		bool? b_(Encounter.DiagnosisComponent D)
		{
			PositiveInt i_ = D?.RankElement;
			Integer j_ = context.Operators.Convert<Integer>(i_);
			int? k_ = FHIRHelpers_4_0_001.ToInteger(j_);
			bool? l_ = context.Operators.Equal(k_, 1);

			return l_;
		};
		IEnumerable<Encounter.DiagnosisComponent> c_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)a_, b_);
		Encounter.DiagnosisComponent d_ = context.Operators.SingletonFrom<Encounter.DiagnosisComponent>(c_);
		Encounter.DiagnosisComponent[] e_ = [
			d_,
		];
		Condition f_(Encounter.DiagnosisComponent PD)
		{
			IEnumerable<Condition> m_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
			bool? n_(Condition C)
			{
				Id q_ = C?.IdElement;
				string r_ = FHIRHelpers_4_0_001.ToString(q_);
				ResourceReference s_ = PD?.Condition;
				FhirString t_ = s_?.ReferenceElement;
				string u_ = FHIRHelpers_4_0_001.ToString(t_);
				string v_ = this.GetId(u_);
				bool? w_ = context.Operators.Equal(r_, v_);

				return w_;
			};
			IEnumerable<Condition> o_ = context.Operators.Where<Condition>(m_, n_);
			Condition p_ = context.Operators.SingletonFrom<Condition>(o_);

			return p_;
		};
		IEnumerable<Condition> g_ = context.Operators.Select<Encounter.DiagnosisComponent, Condition>((IEnumerable<Encounter.DiagnosisComponent>)e_, f_);
		Condition h_ = context.Operators.SingletonFrom<Condition>(g_);

		return h_;
	}

    [CqlDeclaration("GetLocation")]
	public Location GetLocation(ResourceReference reference)
	{
		IEnumerable<Location> a_ = context.Operators.Retrieve<Location>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Location"));
		bool? b_(Location L)
		{
			Id e_ = L?.IdElement;
			string f_ = FHIRHelpers_4_0_001.ToString(e_);
			FhirString g_ = reference?.ReferenceElement;
			string h_ = FHIRHelpers_4_0_001.ToString(g_);
			string i_ = this.GetId(h_);
			bool? j_ = context.Operators.Equal(f_, i_);

			return j_;
		};
		IEnumerable<Location> c_ = context.Operators.Where<Location>(a_, b_);
		Location d_ = context.Operators.SingletonFrom<Location>(c_);

		return d_;
	}

    [CqlDeclaration("GetBaseExtensions")]
	public IEnumerable<Extension> GetBaseExtensions(DomainResource domainResource, string url)
	{
		List<Extension> a_ = domainResource?.Extension;
		bool? b_(Extension E)
		{
			string f_ = E?.Url;
			FhirUri g_ = context.Operators.Convert<FhirUri>(f_);
			string h_ = FHIRHelpers_4_0_001.ToString(g_);
			string i_ = context.Operators.Concatenate("http://hl7.org/fhir/StructureDefinition/", url);
			bool? j_ = context.Operators.Equal(h_, i_);

			return j_;
		};
		IEnumerable<Extension> c_ = context.Operators.Where<Extension>((IEnumerable<Extension>)a_, b_);
		Extension d_(Extension E) => 
			E;
		IEnumerable<Extension> e_ = context.Operators.Select<Extension, Extension>(c_, d_);

		return e_;
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
		List<Extension> a_ = element?.Extension;
		bool? b_(Extension E)
		{
			string f_ = E?.Url;
			FhirUri g_ = context.Operators.Convert<FhirUri>(f_);
			string h_ = FHIRHelpers_4_0_001.ToString(g_);
			string i_ = context.Operators.Concatenate("http://hl7.org/fhir/StructureDefinition/", id);
			bool? j_ = context.Operators.Equal(h_, i_);

			return j_;
		};
		IEnumerable<Extension> c_ = context.Operators.Where<Extension>((IEnumerable<Extension>)a_, b_);
		Extension d_(Extension E) => 
			E;
		IEnumerable<Extension> e_ = context.Operators.Select<Extension, Extension>(c_, d_);

		return e_;
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
			bool b_()
			{
				DataType c_ = request?.Medication;
				bool d_ = c_ is CodeableConcept;

				return d_;
			};
			if (b_())
			{
				DataType e_ = request?.Medication;

				return e_ as CodeableConcept;
			}
			else
			{
				IEnumerable<Medication> f_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Medication"));
				bool? g_(Medication M)
				{
					Id k_ = M?.IdElement;
					string l_ = FHIRHelpers_4_0_001.ToString(k_);
					DataType m_ = request?.Medication;
					FhirString n_ = (m_ as ResourceReference)?.ReferenceElement;
					string o_ = FHIRHelpers_4_0_001.ToString(n_);
					string p_ = this.GetId(o_);
					bool? q_ = context.Operators.Equal(l_, p_);

					return q_;
				};
				IEnumerable<Medication> h_ = context.Operators.Where<Medication>(f_, g_);
				Medication i_ = context.Operators.SingletonFrom<Medication>(h_);
				CodeableConcept j_ = i_?.Code;

				return j_;
			}
		};

		return a_();
	}

    [CqlDeclaration("HasStart")]
	public bool? HasStart(CqlInterval<CqlDateTime> period)
	{
		CqlDateTime a_ = context.Operators.Start(period);
		CqlDateTime c_ = context.Operators.MinValue<CqlDateTime>();
		bool? d_ = context.Operators.Equal(a_, c_);
		bool? e_ = context.Operators.Or((bool?)(a_ is null), d_);
		bool? f_ = context.Operators.Not(e_);

		return f_;
	}

    [CqlDeclaration("HasEnd")]
	public bool? HasEnd(CqlInterval<CqlDateTime> period)
	{
		CqlDateTime a_ = context.Operators.End(period);
		CqlDateTime c_ = context.Operators.MaxValue<CqlDateTime>();
		bool? d_ = context.Operators.Equal(a_, c_);
		bool? e_ = context.Operators.Or((bool?)(a_ is null), d_);
		bool? f_ = context.Operators.Not(e_);

		return f_;
	}

    [CqlDeclaration("Latest")]
	public CqlDateTime Latest(object choice)
	{
		CqlInterval<CqlDateTime> a_ = this.Normalize_Interval(choice);
		CqlInterval<CqlDateTime>[] b_ = [
			a_,
		];
		CqlDateTime c_(CqlInterval<CqlDateTime> period)
		{
			CqlDateTime f_()
			{
				if ((this.HasEnd(period)) ?? false)
				{
					CqlDateTime g_ = context.Operators.End(period);

					return g_;
				}
				else
				{
					CqlDateTime h_ = context.Operators.Start(period);

					return h_;
				}
			};

			return f_();
		};
		IEnumerable<CqlDateTime> d_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDateTime>((IEnumerable<CqlInterval<CqlDateTime>>)b_, c_);
		CqlDateTime e_ = context.Operators.SingletonFrom<CqlDateTime>(d_);

		return e_;
	}

    [CqlDeclaration("Earliest")]
	public CqlDateTime Earliest(object choice)
	{
		CqlInterval<CqlDateTime> a_ = this.Normalize_Interval(choice);
		CqlInterval<CqlDateTime>[] b_ = [
			a_,
		];
		CqlDateTime c_(CqlInterval<CqlDateTime> period)
		{
			CqlDateTime f_()
			{
				if ((this.HasStart(period)) ?? false)
				{
					CqlDateTime g_ = context.Operators.Start(period);

					return g_;
				}
				else
				{
					CqlDateTime h_ = context.Operators.End(period);

					return h_;
				}
			};

			return f_();
		};
		IEnumerable<CqlDateTime> d_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDateTime>((IEnumerable<CqlInterval<CqlDateTime>>)b_, c_);
		CqlDateTime e_ = context.Operators.SingletonFrom<CqlDateTime>(d_);

		return e_;
	}

}
