using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "0.9.0.0")]
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
		var a_ = new CqlCode[]
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
		var a_ = new CqlCode[]
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
		var a_ = new CqlCode[]
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
		var a_ = new CqlCode[]
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
		var a_ = new CqlCode[]
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
		var a_ = new CqlCode[]
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
		var a_ = new CqlCode[]
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
		var a_ = new CqlCode[]
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
		var a_ = new CqlCode[]
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
		var a_ = context.Operators.ConvertIntegerToDecimal(default);
		var b_ = context.Operators.DateTime((int?)2019, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, a_);
		var d_ = context.Operators.DateTime((int?)2020, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, a_);
		var e_ = context.Operators.Interval(b_, d_, true, false);
		var f_ = context.ResolveParameter("MATGlobalCommonFunctionsFHIR4-6.1.000", "Measurement Period", e_);

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

    [CqlDeclaration("LengthInDays")]
	public int? LengthInDays(CqlInterval<CqlDateTime> Value)
	{
		var a_ = context.Operators.Start(Value);
		var b_ = context.Operators.End(Value);
		var c_ = context.Operators.DifferenceBetween(a_, b_, "day");

		return c_;
	}

	private IEnumerable<Encounter> Inpatient_Encounter_Value()
	{
		var a_ = this.Encounter_Inpatient();
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		bool? c_(Encounter EncounterInpatient)
		{
			var e_ = EncounterInpatient?.StatusElement;
			var f_ = context.Operators.Convert<string>(e_);
			var g_ = context.Operators.Equal(f_, "finished");
			var h_ = EncounterInpatient?.Period;
			var i_ = FHIRHelpers_4_0_001.ToInterval(h_);
			var j_ = this.LengthInDays(i_);
			var k_ = context.Operators.LessOrEqual(j_, (int?)120);
			var l_ = context.Operators.And(g_, k_);
			var n_ = FHIRHelpers_4_0_001.ToInterval(h_);
			var o_ = context.Operators.End(n_);
			var p_ = this.Measurement_Period();
			var q_ = context.Operators.ElementInInterval<CqlDateTime>(o_, p_, null);
			var r_ = context.Operators.And(l_, q_);

			return r_;
		};
		var d_ = context.Operators.WhereOrNull<Encounter>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Inpatient Encounter")]
	public IEnumerable<Encounter> Inpatient_Encounter() => 
		__Inpatient_Encounter.Value;

    [CqlDeclaration("ED Visit")]
	public Encounter ED_Visit(Encounter TheEncounter)
	{
		var a_ = this.Emergency_Department_Visit();
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		bool? c_(Encounter EDVisit)
		{
			var h_ = EDVisit?.StatusElement;
			var i_ = context.Operators.Convert<string>(h_);
			var j_ = context.Operators.Equal(i_, "finished");
			var k_ = EDVisit?.Period;
			var l_ = FHIRHelpers_4_0_001.ToInterval(k_);
			var m_ = context.Operators.End(l_);
			var n_ = TheEncounter?.Period;
			var o_ = FHIRHelpers_4_0_001.ToInterval(n_);
			var p_ = context.Operators.Start(o_);
			var q_ = context.Operators.Quantity(1m, "hour");
			var r_ = context.Operators.Subtract(p_, q_);
			var t_ = FHIRHelpers_4_0_001.ToInterval(n_);
			var u_ = context.Operators.Start(t_);
			var v_ = context.Operators.Interval(r_, u_, true, true);
			var w_ = context.Operators.ElementInInterval<CqlDateTime>(m_, v_, null);
			var y_ = FHIRHelpers_4_0_001.ToInterval(n_);
			var z_ = context.Operators.Start(y_);
			var aa_ = context.Operators.Not((bool?)(z_ is null));
			var ab_ = context.Operators.And(w_, aa_);
			var ac_ = context.Operators.And(j_, ab_);

			return ac_;
		};
		var d_ = context.Operators.WhereOrNull<Encounter>(b_, c_);
		object e_(Encounter @this)
		{
			var ad_ = @this?.Period;
			var ae_ = FHIRHelpers_4_0_001.ToInterval(ad_);
			var af_ = context.Operators.End(ae_);

			return af_;
		};
		var f_ = context.Operators.ListSortBy<Encounter>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
		var g_ = context.Operators.LastOfList<Encounter>(f_);

		return g_;
	}

    [CqlDeclaration("Hospitalization")]
	public CqlInterval<CqlDateTime> Hospitalization(Encounter TheEncounter)
	{
		var a_ = this.ED_Visit(TheEncounter);
		var b_ = new Encounter[]
		{
			a_,
		};
		CqlInterval<CqlDateTime> c_(Encounter X)
		{
			CqlInterval<CqlDateTime> f_()
			{
				if ((X is null))
				{
					var g_ = TheEncounter?.Period;
					var h_ = FHIRHelpers_4_0_001.ToInterval(g_);

					return h_;
				}
				else
				{
					var i_ = X?.Period;
					var j_ = FHIRHelpers_4_0_001.ToInterval(i_);
					var k_ = context.Operators.Start(j_);
					var l_ = TheEncounter?.Period;
					var m_ = FHIRHelpers_4_0_001.ToInterval(l_);
					var n_ = context.Operators.End(m_);
					var o_ = context.Operators.Interval(k_, n_, true, true);

					return o_;
				};
			};

			return f_();
		};
		var d_ = context.Operators.SelectOrNull<Encounter, CqlInterval<CqlDateTime>>(b_, c_);
		var e_ = context.Operators.SingleOrNull<CqlInterval<CqlDateTime>>(d_);

		return e_;
	}

    [CqlDeclaration("Hospitalization Locations")]
	public IEnumerable<Encounter.LocationComponent> Hospitalization_Locations(Encounter TheEncounter)
	{
		var a_ = this.ED_Visit(TheEncounter);
		var b_ = new Encounter[]
		{
			a_,
		};
		IEnumerable<Encounter.LocationComponent> c_(Encounter EDEncounter)
		{
			IEnumerable<Encounter.LocationComponent> f_()
			{
				if ((EDEncounter is null))
				{
					var g_ = TheEncounter?.Location;

					return (g_ as IEnumerable<Encounter.LocationComponent>);
				}
				else
				{
					var h_ = EDEncounter?.Location;
					var i_ = TheEncounter?.Location;
					var j_ = new IEnumerable<Encounter.LocationComponent>[]
					{
						(h_ as IEnumerable<Encounter.LocationComponent>),
						(i_ as IEnumerable<Encounter.LocationComponent>),
					};
					var k_ = context.Operators.FlattenList<Encounter.LocationComponent>((j_ as IEnumerable<IEnumerable<Encounter.LocationComponent>>));

					return k_;
				};
			};

			return f_();
		};
		var d_ = context.Operators.SelectOrNull<Encounter, IEnumerable<Encounter.LocationComponent>>(b_, c_);
		var e_ = context.Operators.SingleOrNull<IEnumerable<Encounter.LocationComponent>>(d_);

		return e_;
	}

    [CqlDeclaration("Hospitalization Length of Stay")]
	public int? Hospitalization_Length_of_Stay(Encounter TheEncounter)
	{
		var a_ = this.Hospitalization(TheEncounter);
		var b_ = this.LengthInDays(a_);

		return b_;
	}

    [CqlDeclaration("Hospital Admission Time")]
	public CqlDateTime Hospital_Admission_Time(Encounter TheEncounter)
	{
		var a_ = this.Hospitalization(TheEncounter);
		var b_ = context.Operators.Start(a_);

		return b_;
	}

    [CqlDeclaration("Hospital Discharge Time")]
	public CqlDateTime Hospital_Discharge_Time(Encounter TheEncounter)
	{
		var a_ = TheEncounter?.Period;
		var b_ = FHIRHelpers_4_0_001.ToInterval(a_);
		var c_ = context.Operators.End(b_);

		return c_;
	}

    [CqlDeclaration("Hospital Arrival Time")]
	public CqlDateTime Hospital_Arrival_Time(Encounter TheEncounter)
	{
		var a_ = this.Hospitalization_Locations(TheEncounter);
		object b_(Encounter.LocationComponent @this)
		{
			var h_ = @this?.Period;
			var i_ = FHIRHelpers_4_0_001.ToInterval(h_);
			var j_ = context.Operators.Start(i_);

			return j_;
		};
		var c_ = context.Operators.ListSortBy<Encounter.LocationComponent>(a_, b_, System.ComponentModel.ListSortDirection.Ascending);
		var d_ = context.Operators.FirstOfList<Encounter.LocationComponent>(c_);
		var e_ = d_?.Period;
		var f_ = FHIRHelpers_4_0_001.ToInterval(e_);
		var g_ = context.Operators.Start(f_);

		return g_;
	}

    [CqlDeclaration("HospitalizationWithObservation")]
	public CqlInterval<CqlDateTime> HospitalizationWithObservation(Encounter TheEncounter)
	{
		var a_ = new Encounter[]
		{
			TheEncounter,
		};
		CqlInterval<CqlDateTime> b_(Encounter Visit)
		{
			var e_ = this.Emergency_Department_Visit();
			var f_ = context.Operators.RetrieveByValueSet<Encounter>(e_, null);
			bool? g_(Encounter LastED)
			{
				var af_ = LastED?.Period;
				var ag_ = FHIRHelpers_4_0_001.ToInterval(af_);
				var ah_ = context.Operators.End(ag_);
				var ai_ = this.Observation_Services();
				var aj_ = context.Operators.RetrieveByValueSet<Encounter>(ai_, null);
				bool? ak_(Encounter LastObs)
				{
					var cb_ = LastObs?.Period;
					var cc_ = FHIRHelpers_4_0_001.ToInterval(cb_);
					var cd_ = context.Operators.End(cc_);
					var ce_ = Visit?.Period;
					var cf_ = FHIRHelpers_4_0_001.ToInterval(ce_);
					var cg_ = context.Operators.Start(cf_);
					var ch_ = context.Operators.Quantity(1m, "hour");
					var ci_ = context.Operators.Subtract(cg_, ch_);
					var ck_ = FHIRHelpers_4_0_001.ToInterval(ce_);
					var cl_ = context.Operators.Start(ck_);
					var cm_ = context.Operators.Interval(ci_, cl_, true, true);
					var cn_ = context.Operators.ElementInInterval<CqlDateTime>(cd_, cm_, null);
					var cp_ = FHIRHelpers_4_0_001.ToInterval(ce_);
					var cq_ = context.Operators.Start(cp_);
					var cr_ = context.Operators.Not((bool?)(cq_ is null));
					var cs_ = context.Operators.And(cn_, cr_);

					return cs_;
				};
				var al_ = context.Operators.WhereOrNull<Encounter>(aj_, ak_);
				object am_(Encounter @this)
				{
					var ct_ = @this?.Period;
					var cu_ = FHIRHelpers_4_0_001.ToInterval(ct_);
					var cv_ = context.Operators.End(cu_);

					return cv_;
				};
				var an_ = context.Operators.ListSortBy<Encounter>(al_, am_, System.ComponentModel.ListSortDirection.Ascending);
				var ao_ = context.Operators.LastOfList<Encounter>(an_);
				var ap_ = ao_?.Period;
				var aq_ = FHIRHelpers_4_0_001.ToInterval(ap_);
				var ar_ = context.Operators.Start(aq_);
				var as_ = Visit?.Period;
				var at_ = FHIRHelpers_4_0_001.ToInterval(as_);
				var au_ = context.Operators.Start(at_);
				var av_ = context.Operators.Quantity(1m, "hour");
				var aw_ = context.Operators.Subtract((ar_ ?? au_), av_);
				var ay_ = context.Operators.RetrieveByValueSet<Encounter>(ai_, null);
				bool? az_(Encounter LastObs)
				{
					var cw_ = LastObs?.Period;
					var cx_ = FHIRHelpers_4_0_001.ToInterval(cw_);
					var cy_ = context.Operators.End(cx_);
					var cz_ = Visit?.Period;
					var da_ = FHIRHelpers_4_0_001.ToInterval(cz_);
					var db_ = context.Operators.Start(da_);
					var dc_ = context.Operators.Quantity(1m, "hour");
					var dd_ = context.Operators.Subtract(db_, dc_);
					var df_ = FHIRHelpers_4_0_001.ToInterval(cz_);
					var dg_ = context.Operators.Start(df_);
					var dh_ = context.Operators.Interval(dd_, dg_, true, true);
					var di_ = context.Operators.ElementInInterval<CqlDateTime>(cy_, dh_, null);
					var dk_ = FHIRHelpers_4_0_001.ToInterval(cz_);
					var dl_ = context.Operators.Start(dk_);
					var dm_ = context.Operators.Not((bool?)(dl_ is null));
					var dn_ = context.Operators.And(di_, dm_);

					return dn_;
				};
				var ba_ = context.Operators.WhereOrNull<Encounter>(ay_, az_);
				object bb_(Encounter @this)
				{
					var do_ = @this?.Period;
					var dp_ = FHIRHelpers_4_0_001.ToInterval(do_);
					var dq_ = context.Operators.End(dp_);

					return dq_;
				};
				var bc_ = context.Operators.ListSortBy<Encounter>(ba_, bb_, System.ComponentModel.ListSortDirection.Ascending);
				var bd_ = context.Operators.LastOfList<Encounter>(bc_);
				var be_ = bd_?.Period;
				var bf_ = FHIRHelpers_4_0_001.ToInterval(be_);
				var bg_ = context.Operators.Start(bf_);
				var bi_ = FHIRHelpers_4_0_001.ToInterval(as_);
				var bj_ = context.Operators.Start(bi_);
				var bk_ = context.Operators.Interval(aw_, (bg_ ?? bj_), true, true);
				var bl_ = context.Operators.ElementInInterval<CqlDateTime>(ah_, bk_, null);
				var bn_ = context.Operators.RetrieveByValueSet<Encounter>(ai_, null);
				bool? bo_(Encounter LastObs)
				{
					var dr_ = LastObs?.Period;
					var ds_ = FHIRHelpers_4_0_001.ToInterval(dr_);
					var dt_ = context.Operators.End(ds_);
					var du_ = Visit?.Period;
					var dv_ = FHIRHelpers_4_0_001.ToInterval(du_);
					var dw_ = context.Operators.Start(dv_);
					var dx_ = context.Operators.Quantity(1m, "hour");
					var dy_ = context.Operators.Subtract(dw_, dx_);
					var ea_ = FHIRHelpers_4_0_001.ToInterval(du_);
					var eb_ = context.Operators.Start(ea_);
					var ec_ = context.Operators.Interval(dy_, eb_, true, true);
					var ed_ = context.Operators.ElementInInterval<CqlDateTime>(dt_, ec_, null);
					var ef_ = FHIRHelpers_4_0_001.ToInterval(du_);
					var eg_ = context.Operators.Start(ef_);
					var eh_ = context.Operators.Not((bool?)(eg_ is null));
					var ei_ = context.Operators.And(ed_, eh_);

					return ei_;
				};
				var bp_ = context.Operators.WhereOrNull<Encounter>(bn_, bo_);
				object bq_(Encounter @this)
				{
					var ej_ = @this?.Period;
					var ek_ = FHIRHelpers_4_0_001.ToInterval(ej_);
					var el_ = context.Operators.End(ek_);

					return el_;
				};
				var br_ = context.Operators.ListSortBy<Encounter>(bp_, bq_, System.ComponentModel.ListSortDirection.Ascending);
				var bs_ = context.Operators.LastOfList<Encounter>(br_);
				var bt_ = bs_?.Period;
				var bu_ = FHIRHelpers_4_0_001.ToInterval(bt_);
				var bv_ = context.Operators.Start(bu_);
				var bx_ = FHIRHelpers_4_0_001.ToInterval(as_);
				var by_ = context.Operators.Start(bx_);
				var bz_ = context.Operators.Not((bool?)((bv_ ?? by_) is null));
				var ca_ = context.Operators.And(bl_, bz_);

				return ca_;
			};
			var h_ = context.Operators.WhereOrNull<Encounter>(f_, g_);
			object i_(Encounter @this)
			{
				var em_ = @this?.Period;
				var en_ = FHIRHelpers_4_0_001.ToInterval(em_);
				var eo_ = context.Operators.End(en_);

				return eo_;
			};
			var j_ = context.Operators.ListSortBy<Encounter>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
			var k_ = context.Operators.LastOfList<Encounter>(j_);
			var l_ = k_?.Period;
			var m_ = FHIRHelpers_4_0_001.ToInterval(l_);
			var n_ = context.Operators.Start(m_);
			var o_ = this.Observation_Services();
			var p_ = context.Operators.RetrieveByValueSet<Encounter>(o_, null);
			bool? q_(Encounter LastObs)
			{
				var ep_ = LastObs?.Period;
				var eq_ = FHIRHelpers_4_0_001.ToInterval(ep_);
				var er_ = context.Operators.End(eq_);
				var es_ = Visit?.Period;
				var et_ = FHIRHelpers_4_0_001.ToInterval(es_);
				var eu_ = context.Operators.Start(et_);
				var ev_ = context.Operators.Quantity(1m, "hour");
				var ew_ = context.Operators.Subtract(eu_, ev_);
				var ey_ = FHIRHelpers_4_0_001.ToInterval(es_);
				var ez_ = context.Operators.Start(ey_);
				var fa_ = context.Operators.Interval(ew_, ez_, true, true);
				var fb_ = context.Operators.ElementInInterval<CqlDateTime>(er_, fa_, null);
				var fd_ = FHIRHelpers_4_0_001.ToInterval(es_);
				var fe_ = context.Operators.Start(fd_);
				var ff_ = context.Operators.Not((bool?)(fe_ is null));
				var fg_ = context.Operators.And(fb_, ff_);

				return fg_;
			};
			var r_ = context.Operators.WhereOrNull<Encounter>(p_, q_);
			object s_(Encounter @this)
			{
				var fh_ = @this?.Period;
				var fi_ = FHIRHelpers_4_0_001.ToInterval(fh_);
				var fj_ = context.Operators.End(fi_);

				return fj_;
			};
			var t_ = context.Operators.ListSortBy<Encounter>(r_, s_, System.ComponentModel.ListSortDirection.Ascending);
			var u_ = context.Operators.LastOfList<Encounter>(t_);
			var v_ = u_?.Period;
			var w_ = FHIRHelpers_4_0_001.ToInterval(v_);
			var x_ = context.Operators.Start(w_);
			var y_ = Visit?.Period;
			var z_ = FHIRHelpers_4_0_001.ToInterval(y_);
			var aa_ = context.Operators.Start(z_);
			var ac_ = FHIRHelpers_4_0_001.ToInterval(y_);
			var ad_ = context.Operators.End(ac_);
			var ae_ = context.Operators.Interval((n_ ?? (x_ ?? aa_)), ad_, true, true);

			return ae_;
		};
		var c_ = context.Operators.SelectOrNull<Encounter, CqlInterval<CqlDateTime>>(a_, b_);
		var d_ = context.Operators.SingleOrNull<CqlInterval<CqlDateTime>>(c_);

		return d_;
	}

    [CqlDeclaration("Normalize Interval")]
	public CqlInterval<CqlDateTime> Normalize_Interval(object choice)
	{
		CqlInterval<CqlDateTime> a_()
		{
			if (choice is FhirDateTime)
			{
				var b_ = FHIRHelpers_4_0_001.ToDateTime((choice as FhirDateTime));
				var d_ = context.Operators.Interval(b_, b_, true, true);

				return d_;
			}
			else if (choice is Period)
			{
				var e_ = FHIRHelpers_4_0_001.ToInterval((choice as Period));

				return e_;
			}
			else if (choice is Instant)
			{
				var f_ = FHIRHelpers_4_0_001.ToDateTime((choice as Instant));
				var h_ = context.Operators.Interval(f_, f_, true, true);

				return h_;
			}
			else if (choice is Age)
			{
				var i_ = this.Patient();
				var j_ = i_?.BirthDateElement;
				var k_ = FHIRHelpers_4_0_001.ToDate(j_);
				var l_ = FHIRHelpers_4_0_001.ToQuantity((Quantity)(choice as Age));
				var m_ = context.Operators.Add(k_, l_);
				var o_ = i_?.BirthDateElement;
				var p_ = FHIRHelpers_4_0_001.ToDate(o_);
				var r_ = context.Operators.Add(p_, l_);
				var s_ = context.Operators.Quantity(1m, "year");
				var t_ = context.Operators.Add(r_, s_);
				var u_ = context.Operators.Interval(m_, t_, true, false);
				var v_ = u_?.low;
				var w_ = context.Operators.ConvertDateToDateTime(v_);
				var y_ = i_?.BirthDateElement;
				var z_ = FHIRHelpers_4_0_001.ToDate(y_);
				var ab_ = context.Operators.Add(z_, l_);
				var ad_ = i_?.BirthDateElement;
				var ae_ = FHIRHelpers_4_0_001.ToDate(ad_);
				var ag_ = context.Operators.Add(ae_, l_);
				var ai_ = context.Operators.Add(ag_, s_);
				var aj_ = context.Operators.Interval(ab_, ai_, true, false);
				var ak_ = aj_?.high;
				var al_ = context.Operators.ConvertDateToDateTime(ak_);
				var an_ = i_?.BirthDateElement;
				var ao_ = FHIRHelpers_4_0_001.ToDate(an_);
				var aq_ = context.Operators.Add(ao_, l_);
				var as_ = i_?.BirthDateElement;
				var at_ = FHIRHelpers_4_0_001.ToDate(as_);
				var av_ = context.Operators.Add(at_, l_);
				var ax_ = context.Operators.Add(av_, s_);
				var ay_ = context.Operators.Interval(aq_, ax_, true, false);
				var az_ = ay_?.lowClosed;
				var bb_ = i_?.BirthDateElement;
				var bc_ = FHIRHelpers_4_0_001.ToDate(bb_);
				var be_ = context.Operators.Add(bc_, l_);
				var bg_ = i_?.BirthDateElement;
				var bh_ = FHIRHelpers_4_0_001.ToDate(bg_);
				var bj_ = context.Operators.Add(bh_, l_);
				var bl_ = context.Operators.Add(bj_, s_);
				var bm_ = context.Operators.Interval(be_, bl_, true, false);
				var bn_ = bm_?.highClosed;
				var bo_ = context.Operators.Interval(w_, al_, az_, bn_);

				return bo_;
			}
			else if (choice is Range)
			{
				var bp_ = this.Patient();
				var bq_ = bp_?.BirthDateElement;
				var br_ = FHIRHelpers_4_0_001.ToDate(bq_);
				var bs_ = (choice as Range)?.Low;
				var bt_ = FHIRHelpers_4_0_001.ToQuantity(bs_);
				var bu_ = context.Operators.Add(br_, bt_);
				var bw_ = bp_?.BirthDateElement;
				var bx_ = FHIRHelpers_4_0_001.ToDate(bw_);
				var by_ = (choice as Range)?.High;
				var bz_ = FHIRHelpers_4_0_001.ToQuantity(by_);
				var ca_ = context.Operators.Add(bx_, bz_);
				var cb_ = context.Operators.Quantity(1m, "year");
				var cc_ = context.Operators.Add(ca_, cb_);
				var cd_ = context.Operators.Interval(bu_, cc_, true, false);
				var ce_ = cd_?.low;
				var cf_ = context.Operators.ConvertDateToDateTime(ce_);
				var ch_ = bp_?.BirthDateElement;
				var ci_ = FHIRHelpers_4_0_001.ToDate(ch_);
				var ck_ = FHIRHelpers_4_0_001.ToQuantity(bs_);
				var cl_ = context.Operators.Add(ci_, ck_);
				var cn_ = bp_?.BirthDateElement;
				var co_ = FHIRHelpers_4_0_001.ToDate(cn_);
				var cq_ = FHIRHelpers_4_0_001.ToQuantity(by_);
				var cr_ = context.Operators.Add(co_, cq_);
				var ct_ = context.Operators.Add(cr_, cb_);
				var cu_ = context.Operators.Interval(cl_, ct_, true, false);
				var cv_ = cu_?.high;
				var cw_ = context.Operators.ConvertDateToDateTime(cv_);
				var cy_ = bp_?.BirthDateElement;
				var cz_ = FHIRHelpers_4_0_001.ToDate(cy_);
				var db_ = FHIRHelpers_4_0_001.ToQuantity(bs_);
				var dc_ = context.Operators.Add(cz_, db_);
				var de_ = bp_?.BirthDateElement;
				var df_ = FHIRHelpers_4_0_001.ToDate(de_);
				var dh_ = FHIRHelpers_4_0_001.ToQuantity(by_);
				var di_ = context.Operators.Add(df_, dh_);
				var dk_ = context.Operators.Add(di_, cb_);
				var dl_ = context.Operators.Interval(dc_, dk_, true, false);
				var dm_ = dl_?.lowClosed;
				var do_ = bp_?.BirthDateElement;
				var dp_ = FHIRHelpers_4_0_001.ToDate(do_);
				var dr_ = FHIRHelpers_4_0_001.ToQuantity(bs_);
				var ds_ = context.Operators.Add(dp_, dr_);
				var du_ = bp_?.BirthDateElement;
				var dv_ = FHIRHelpers_4_0_001.ToDate(du_);
				var dx_ = FHIRHelpers_4_0_001.ToQuantity(by_);
				var dy_ = context.Operators.Add(dv_, dx_);
				var ea_ = context.Operators.Add(dy_, cb_);
				var eb_ = context.Operators.Interval(ds_, ea_, true, false);
				var ec_ = eb_?.highClosed;
				var ed_ = context.Operators.Interval(cf_, cw_, dm_, ec_);

				return ed_;
			}
			else if (choice is Timing)
			{
				CqlInterval<CqlDateTime> ee_ = null;
				var ef_ = context.Operators.Message<CqlInterval<CqlDateTime>>((ee_ as CqlInterval<CqlDateTime>), "1", "Error", "Cannot compute a single interval from a Timing type");

				return ef_;
			}
			else if (choice is FhirString)
			{
				CqlInterval<CqlDateTime> eg_ = null;
				var eh_ = context.Operators.Message<CqlInterval<CqlDateTime>>((eg_ as CqlInterval<CqlDateTime>), "1", "Error", "Cannot compute an interval from a String value");

				return eh_;
			}
			else
			{
				CqlInterval<CqlDateTime> ei_ = null;

				return (ei_ as CqlInterval<CqlDateTime>);
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
				var b_ = condition?.Abatement;
				var c_ = FHIRHelpers_4_0_001.ToDateTime((b_ as FhirDateTime));
				var e_ = FHIRHelpers_4_0_001.ToDateTime((b_ as FhirDateTime));
				var f_ = context.Operators.Interval(c_, e_, true, true);

				return f_;
			}
			else if (condition?.Abatement is Period)
			{
				var g_ = condition?.Abatement;
				var h_ = FHIRHelpers_4_0_001.ToInterval((g_ as Period));

				return h_;
			}
			else if (condition?.Abatement is FhirString)
			{
				CqlInterval<CqlDateTime> i_ = null;
				var j_ = context.Operators.Message<CqlInterval<CqlDateTime>>((i_ as CqlInterval<CqlDateTime>), "1", "Error", "Cannot compute an interval from a String value");

				return j_;
			}
			else if (condition?.Abatement is Age)
			{
				var k_ = this.Patient();
				var l_ = k_?.BirthDateElement;
				var m_ = FHIRHelpers_4_0_001.ToDate(l_);
				var n_ = condition?.Abatement;
				var o_ = FHIRHelpers_4_0_001.ToQuantity((Quantity)(n_ as Age));
				var p_ = context.Operators.Add(m_, o_);
				var r_ = k_?.BirthDateElement;
				var s_ = FHIRHelpers_4_0_001.ToDate(r_);
				var u_ = FHIRHelpers_4_0_001.ToQuantity((Quantity)(n_ as Age));
				var v_ = context.Operators.Add(s_, u_);
				var w_ = context.Operators.Quantity(1m, "year");
				var x_ = context.Operators.Add(v_, w_);
				var y_ = context.Operators.Interval(p_, x_, true, false);
				var z_ = y_?.low;
				var aa_ = context.Operators.ConvertDateToDateTime(z_);
				var ac_ = k_?.BirthDateElement;
				var ad_ = FHIRHelpers_4_0_001.ToDate(ac_);
				var af_ = FHIRHelpers_4_0_001.ToQuantity((Quantity)(n_ as Age));
				var ag_ = context.Operators.Add(ad_, af_);
				var ai_ = k_?.BirthDateElement;
				var aj_ = FHIRHelpers_4_0_001.ToDate(ai_);
				var al_ = FHIRHelpers_4_0_001.ToQuantity((Quantity)(n_ as Age));
				var am_ = context.Operators.Add(aj_, al_);
				var ao_ = context.Operators.Add(am_, w_);
				var ap_ = context.Operators.Interval(ag_, ao_, true, false);
				var aq_ = ap_?.high;
				var ar_ = context.Operators.ConvertDateToDateTime(aq_);
				var at_ = k_?.BirthDateElement;
				var au_ = FHIRHelpers_4_0_001.ToDate(at_);
				var aw_ = FHIRHelpers_4_0_001.ToQuantity((Quantity)(n_ as Age));
				var ax_ = context.Operators.Add(au_, aw_);
				var az_ = k_?.BirthDateElement;
				var ba_ = FHIRHelpers_4_0_001.ToDate(az_);
				var bc_ = FHIRHelpers_4_0_001.ToQuantity((Quantity)(n_ as Age));
				var bd_ = context.Operators.Add(ba_, bc_);
				var bf_ = context.Operators.Add(bd_, w_);
				var bg_ = context.Operators.Interval(ax_, bf_, true, false);
				var bh_ = bg_?.lowClosed;
				var bj_ = k_?.BirthDateElement;
				var bk_ = FHIRHelpers_4_0_001.ToDate(bj_);
				var bm_ = FHIRHelpers_4_0_001.ToQuantity((Quantity)(n_ as Age));
				var bn_ = context.Operators.Add(bk_, bm_);
				var bp_ = k_?.BirthDateElement;
				var bq_ = FHIRHelpers_4_0_001.ToDate(bp_);
				var bs_ = FHIRHelpers_4_0_001.ToQuantity((Quantity)(n_ as Age));
				var bt_ = context.Operators.Add(bq_, bs_);
				var bv_ = context.Operators.Add(bt_, w_);
				var bw_ = context.Operators.Interval(bn_, bv_, true, false);
				var bx_ = bw_?.highClosed;
				var by_ = context.Operators.Interval(aa_, ar_, bh_, bx_);

				return by_;
			}
			else if (condition?.Abatement is Range)
			{
				var bz_ = this.Patient();
				var ca_ = bz_?.BirthDateElement;
				var cb_ = FHIRHelpers_4_0_001.ToDate(ca_);
				var cc_ = condition?.Abatement;
				var cd_ = (cc_ as Range)?.Low;
				var ce_ = FHIRHelpers_4_0_001.ToQuantity(cd_);
				var cf_ = context.Operators.Add(cb_, ce_);
				var ch_ = bz_?.BirthDateElement;
				var ci_ = FHIRHelpers_4_0_001.ToDate(ch_);
				var ck_ = (cc_ as Range)?.High;
				var cl_ = FHIRHelpers_4_0_001.ToQuantity(ck_);
				var cm_ = context.Operators.Add(ci_, cl_);
				var cn_ = context.Operators.Quantity(1m, "year");
				var co_ = context.Operators.Add(cm_, cn_);
				var cp_ = context.Operators.Interval(cf_, co_, true, false);
				var cq_ = cp_?.low;
				var cr_ = context.Operators.ConvertDateToDateTime(cq_);
				var ct_ = bz_?.BirthDateElement;
				var cu_ = FHIRHelpers_4_0_001.ToDate(ct_);
				var cw_ = (cc_ as Range)?.Low;
				var cx_ = FHIRHelpers_4_0_001.ToQuantity(cw_);
				var cy_ = context.Operators.Add(cu_, cx_);
				var da_ = bz_?.BirthDateElement;
				var db_ = FHIRHelpers_4_0_001.ToDate(da_);
				var dd_ = (cc_ as Range)?.High;
				var de_ = FHIRHelpers_4_0_001.ToQuantity(dd_);
				var df_ = context.Operators.Add(db_, de_);
				var dh_ = context.Operators.Add(df_, cn_);
				var di_ = context.Operators.Interval(cy_, dh_, true, false);
				var dj_ = di_?.high;
				var dk_ = context.Operators.ConvertDateToDateTime(dj_);
				var dm_ = bz_?.BirthDateElement;
				var dn_ = FHIRHelpers_4_0_001.ToDate(dm_);
				var dp_ = (cc_ as Range)?.Low;
				var dq_ = FHIRHelpers_4_0_001.ToQuantity(dp_);
				var dr_ = context.Operators.Add(dn_, dq_);
				var dt_ = bz_?.BirthDateElement;
				var du_ = FHIRHelpers_4_0_001.ToDate(dt_);
				var dw_ = (cc_ as Range)?.High;
				var dx_ = FHIRHelpers_4_0_001.ToQuantity(dw_);
				var dy_ = context.Operators.Add(du_, dx_);
				var ea_ = context.Operators.Add(dy_, cn_);
				var eb_ = context.Operators.Interval(dr_, ea_, true, false);
				var ec_ = eb_?.lowClosed;
				var ee_ = bz_?.BirthDateElement;
				var ef_ = FHIRHelpers_4_0_001.ToDate(ee_);
				var eh_ = (cc_ as Range)?.Low;
				var ei_ = FHIRHelpers_4_0_001.ToQuantity(eh_);
				var ej_ = context.Operators.Add(ef_, ei_);
				var el_ = bz_?.BirthDateElement;
				var em_ = FHIRHelpers_4_0_001.ToDate(el_);
				var eo_ = (cc_ as Range)?.High;
				var ep_ = FHIRHelpers_4_0_001.ToQuantity(eo_);
				var eq_ = context.Operators.Add(em_, ep_);
				var es_ = context.Operators.Add(eq_, cn_);
				var et_ = context.Operators.Interval(ej_, es_, true, false);
				var eu_ = et_?.highClosed;
				var ev_ = context.Operators.Interval(cr_, dk_, ec_, eu_);

				return ev_;
			}
			else if (condition?.Abatement is FhirBoolean)
			{
				var ew_ = condition?.Onset;
				var ex_ = this.Normalize_Interval(ew_);
				var ey_ = context.Operators.End(ex_);
				var ez_ = condition?.RecordedDateElement;
				var fa_ = FHIRHelpers_4_0_001.ToDateTime(ez_);
				var fb_ = context.Operators.Interval(ey_, fa_, true, false);

				return fb_;
			}
			else
			{
				CqlInterval<CqlDateTime> fc_ = null;

				return (fc_ as CqlInterval<CqlDateTime>);
			};
		};

		return a_();
	}

    [CqlDeclaration("Prevalence Period")]
	public CqlInterval<CqlDateTime> Prevalence_Period(Condition condition)
	{
		CqlInterval<CqlDateTime> a_()
		{
			if ((context.Operators.Or(context.Operators.Or(context.Operators.Equivalent(FHIRHelpers_4_0_001.ToConcept(condition?.ClinicalStatus), context.Operators.ConvertCodeToConcept(this.active())), context.Operators.Equivalent(FHIRHelpers_4_0_001.ToConcept(condition?.ClinicalStatus), context.Operators.ConvertCodeToConcept(this.recurrence()))), context.Operators.Equivalent(FHIRHelpers_4_0_001.ToConcept(condition?.ClinicalStatus), context.Operators.ConvertCodeToConcept(this.relapse()))) ?? false))
			{
				var b_ = condition?.Onset;
				var c_ = this.Normalize_Interval(b_);
				var d_ = context.Operators.Start(c_);
				var e_ = this.Normalize_Abatement(condition);
				var f_ = context.Operators.End(e_);
				var g_ = context.Operators.Interval(d_, f_, true, true);

				return g_;
			}
			else
			{
				var h_ = condition?.Onset;
				var i_ = this.Normalize_Interval(h_);
				var j_ = context.Operators.Start(i_);
				var k_ = this.Normalize_Abatement(condition);
				var l_ = context.Operators.End(k_);
				var m_ = context.Operators.Interval(j_, l_, true, false);

				return m_;
			};
		};

		return a_();
	}

    [CqlDeclaration("GetId")]
	public string GetId(string uri)
	{
		var a_ = context.Operators.Split(uri, "/");
		var b_ = context.Operators.LastOfList<string>(a_);

		return b_;
	}

    [CqlDeclaration("EncounterDiagnosis")]
	public IEnumerable<Condition> EncounterDiagnosis(Encounter Encounter)
	{
		var a_ = Encounter?.Diagnosis;
		Condition b_(Encounter.DiagnosisComponent D)
		{
			var d_ = context.Operators.RetrieveByValueSet<Condition>(null, null);
			bool? e_(Condition C)
			{
				var h_ = C?.IdElement;
				var i_ = context.Operators.Convert<string>(h_);
				var j_ = D?.Condition;
				var k_ = j_?.ReferenceElement;
				var l_ = context.Operators.Convert<string>(k_);
				var m_ = this.GetId(l_);
				var n_ = context.Operators.Equal(i_, m_);

				return n_;
			};
			var f_ = context.Operators.WhereOrNull<Condition>(d_, e_);
			var g_ = context.Operators.SingleOrNull<Condition>(f_);

			return g_;
		};
		var c_ = context.Operators.SelectOrNull<Encounter.DiagnosisComponent, Condition>((a_ as IEnumerable<Encounter.DiagnosisComponent>), b_);

		return c_;
	}

    [CqlDeclaration("GetCondition")]
	public Condition GetCondition(ResourceReference reference)
	{
		var a_ = context.Operators.RetrieveByValueSet<Condition>(null, null);
		bool? b_(Condition C)
		{
			var e_ = C?.IdElement;
			var f_ = context.Operators.Convert<string>(e_);
			var g_ = reference?.ReferenceElement;
			var h_ = context.Operators.Convert<string>(g_);
			var i_ = this.GetId(h_);
			var j_ = context.Operators.Equal(f_, i_);

			return j_;
		};
		var c_ = context.Operators.WhereOrNull<Condition>(a_, b_);
		var d_ = context.Operators.SingleOrNull<Condition>(c_);

		return d_;
	}

    [CqlDeclaration("GetExtensions")]
	public IEnumerable<Extension> GetExtensions(DomainResource domainResource, string url)
	{
		var a_ = domainResource?.Extension;
		bool? b_(Extension E)
		{
			var f_ = E?.Url;
			var g_ = context.Operators.Convert<FhirUri>(f_);
			var h_ = context.Operators.Convert<string>(g_);
			var i_ = context.Operators.Concatenate("http://hl7.org/fhir/us/qicore/StructureDefinition/", url);
			var j_ = context.Operators.Equal(h_, i_);

			return j_;
		};
		var c_ = context.Operators.WhereOrNull<Extension>((a_ as IEnumerable<Extension>), b_);
		Extension d_(Extension E) => 
			E;
		var e_ = context.Operators.SelectOrNull<Extension, Extension>(c_, d_);

		return e_;
	}

    [CqlDeclaration("GetExtensions")]
	public IEnumerable<Extension> GetExtensions(Element element, string url)
	{
		var a_ = element?.Extension;
		bool? b_(Extension E)
		{
			var f_ = E?.Url;
			var g_ = context.Operators.Convert<FhirUri>(f_);
			var h_ = context.Operators.Convert<string>(g_);
			var i_ = context.Operators.Equal(h_, url);

			return i_;
		};
		var c_ = context.Operators.WhereOrNull<Extension>((a_ as IEnumerable<Extension>), b_);
		Extension d_(Extension E) => 
			E;
		var e_ = context.Operators.SelectOrNull<Extension, Extension>(c_, d_);

		return e_;
	}

    [CqlDeclaration("GetExtension")]
	public Extension GetExtension(DomainResource domainResource, string url)
	{
		var a_ = this.GetExtensions(domainResource, url);
		var b_ = context.Operators.SingleOrNull<Extension>(a_);

		return b_;
	}

    [CqlDeclaration("GetExtension")]
	public Extension GetExtension(Element element, string url)
	{
		var a_ = this.GetExtensions(element, url);
		var b_ = context.Operators.SingleOrNull<Extension>(a_);

		return b_;
	}

    [CqlDeclaration("PresentOnAdmissionIndicator")]
	public CodeableConcept PresentOnAdmissionIndicator(Element element)
	{
		var a_ = this.GetExtension(element, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");
		var b_ = a_?.Value;

		return (b_ as CodeableConcept);
	}

    [CqlDeclaration("PrincipalDiagnosis")]
	public Condition PrincipalDiagnosis(Encounter Encounter)
	{
		var a_ = Encounter?.Diagnosis;
		bool? b_(Encounter.DiagnosisComponent D)
		{
			var i_ = D?.RankElement;
			var j_ = context.Operators.Convert<Integer>(i_);
			var k_ = FHIRHelpers_4_0_001.ToInteger(j_);
			var l_ = context.Operators.Equal(k_, (int?)1);

			return l_;
		};
		var c_ = context.Operators.WhereOrNull<Encounter.DiagnosisComponent>((a_ as IEnumerable<Encounter.DiagnosisComponent>), b_);
		var d_ = context.Operators.SingleOrNull<Encounter.DiagnosisComponent>(c_);
		var e_ = new Encounter.DiagnosisComponent[]
		{
			d_,
		};
		Condition f_(Encounter.DiagnosisComponent PD)
		{
			var m_ = context.Operators.RetrieveByValueSet<Condition>(null, null);
			bool? n_(Condition C)
			{
				var q_ = C?.IdElement;
				var r_ = context.Operators.Convert<string>(q_);
				var s_ = PD?.Condition;
				var t_ = s_?.ReferenceElement;
				var u_ = context.Operators.Convert<string>(t_);
				var v_ = this.GetId(u_);
				var w_ = context.Operators.Equal(r_, v_);

				return w_;
			};
			var o_ = context.Operators.WhereOrNull<Condition>(m_, n_);
			var p_ = context.Operators.SingleOrNull<Condition>(o_);

			return p_;
		};
		var g_ = context.Operators.SelectOrNull<Encounter.DiagnosisComponent, Condition>(e_, f_);
		var h_ = context.Operators.SingleOrNull<Condition>(g_);

		return h_;
	}

    [CqlDeclaration("GetLocation")]
	public Location GetLocation(ResourceReference reference)
	{
		var a_ = context.Operators.RetrieveByValueSet<Location>(null, null);
		bool? b_(Location L)
		{
			var e_ = L?.IdElement;
			var f_ = context.Operators.Convert<string>(e_);
			var g_ = reference?.ReferenceElement;
			var h_ = context.Operators.Convert<string>(g_);
			var i_ = this.GetId(h_);
			var j_ = context.Operators.Equal(f_, i_);

			return j_;
		};
		var c_ = context.Operators.WhereOrNull<Location>(a_, b_);
		var d_ = context.Operators.SingleOrNull<Location>(c_);

		return d_;
	}

    [CqlDeclaration("GetBaseExtensions")]
	public IEnumerable<Extension> GetBaseExtensions(DomainResource domainResource, string url)
	{
		var a_ = domainResource?.Extension;
		bool? b_(Extension E)
		{
			var f_ = E?.Url;
			var g_ = context.Operators.Convert<FhirUri>(f_);
			var h_ = context.Operators.Convert<string>(g_);
			var i_ = context.Operators.Concatenate("http://hl7.org/fhir/StructureDefinition/", url);
			var j_ = context.Operators.Equal(h_, i_);

			return j_;
		};
		var c_ = context.Operators.WhereOrNull<Extension>((a_ as IEnumerable<Extension>), b_);
		Extension d_(Extension E) => 
			E;
		var e_ = context.Operators.SelectOrNull<Extension, Extension>(c_, d_);

		return e_;
	}

    [CqlDeclaration("GetBaseExtension")]
	public Extension GetBaseExtension(DomainResource domainResource, string url)
	{
		var a_ = this.GetBaseExtensions(domainResource, url);
		var b_ = context.Operators.SingleOrNull<Extension>(a_);

		return b_;
	}

    [CqlDeclaration("BaseExtensions")]
	public IEnumerable<Extension> BaseExtensions(Element element, string id)
	{
		var a_ = element?.Extension;
		bool? b_(Extension E)
		{
			var f_ = E?.Url;
			var g_ = context.Operators.Convert<FhirUri>(f_);
			var h_ = context.Operators.Convert<string>(g_);
			var i_ = context.Operators.Concatenate("http://hl7.org/fhir/StructureDefinition/", id);
			var j_ = context.Operators.Equal(h_, i_);

			return j_;
		};
		var c_ = context.Operators.WhereOrNull<Extension>((a_ as IEnumerable<Extension>), b_);
		Extension d_(Extension E) => 
			E;
		var e_ = context.Operators.SelectOrNull<Extension, Extension>(c_, d_);

		return e_;
	}

    [CqlDeclaration("BaseExtension")]
	public Extension BaseExtension(Element element, string id)
	{
		var a_ = this.BaseExtensions(element, id);
		var b_ = context.Operators.SingleOrNull<Extension>(a_);

		return b_;
	}

    [CqlDeclaration("GetMedicationCode")]
	public CodeableConcept GetMedicationCode(MedicationRequest request)
	{
		CodeableConcept a_()
		{
			if (request?.Medication is CodeableConcept)
			{
				var b_ = request?.Medication;

				return (b_ as CodeableConcept);
			}
			else
			{
				var c_ = context.Operators.RetrieveByValueSet<Medication>(null, null);
				bool? d_(Medication M)
				{
					var h_ = M?.IdElement;
					var i_ = context.Operators.Convert<string>(h_);
					var j_ = request?.Medication;
					var k_ = (j_ as ResourceReference)?.ReferenceElement;
					var l_ = context.Operators.Convert<string>(k_);
					var m_ = this.GetId(l_);
					var n_ = context.Operators.Equal(i_, m_);

					return n_;
				};
				var e_ = context.Operators.WhereOrNull<Medication>(c_, d_);
				var f_ = context.Operators.SingleOrNull<Medication>(e_);
				var g_ = f_?.Code;

				return g_;
			};
		};

		return a_();
	}

    [CqlDeclaration("HasStart")]
	public bool? HasStart(CqlInterval<CqlDateTime> period)
	{
		var a_ = context.Operators.Start(period);
		var c_ = context.Operators.Minimum<CqlDateTime>();
		var d_ = context.Operators.Equal(a_, c_);
		var e_ = context.Operators.Or((bool?)(a_ is null), d_);
		var f_ = context.Operators.Not(e_);

		return f_;
	}

    [CqlDeclaration("HasEnd")]
	public bool? HasEnd(CqlInterval<CqlDateTime> period)
	{
		var a_ = context.Operators.End(period);
		var c_ = context.Operators.Maximum<CqlDateTime>();
		var d_ = context.Operators.Equal(a_, c_);
		var e_ = context.Operators.Or((bool?)(a_ is null), d_);
		var f_ = context.Operators.Not(e_);

		return f_;
	}

    [CqlDeclaration("Latest")]
	public CqlDateTime Latest(object choice)
	{
		var a_ = this.Normalize_Interval(choice);
		var b_ = new CqlInterval<CqlDateTime>[]
		{
			a_,
		};
		CqlDateTime c_(CqlInterval<CqlDateTime> period)
		{
			CqlDateTime f_()
			{
				if ((this.HasEnd(period) ?? false))
				{
					var g_ = context.Operators.End(period);

					return g_;
				}
				else
				{
					var h_ = context.Operators.Start(period);

					return h_;
				};
			};

			return f_();
		};
		var d_ = context.Operators.SelectOrNull<CqlInterval<CqlDateTime>, CqlDateTime>(b_, c_);
		var e_ = context.Operators.SingleOrNull<CqlDateTime>(d_);

		return e_;
	}

    [CqlDeclaration("Earliest")]
	public CqlDateTime Earliest(object choice)
	{
		var a_ = this.Normalize_Interval(choice);
		var b_ = new CqlInterval<CqlDateTime>[]
		{
			a_,
		};
		CqlDateTime c_(CqlInterval<CqlDateTime> period)
		{
			CqlDateTime f_()
			{
				if ((this.HasStart(period) ?? false))
				{
					var g_ = context.Operators.Start(period);

					return g_;
				}
				else
				{
					var h_ = context.Operators.End(period);

					return h_;
				};
			};

			return f_();
		};
		var d_ = context.Operators.SelectOrNull<CqlInterval<CqlDateTime>, CqlDateTime>(b_, c_);
		var e_ = context.Operators.SingleOrNull<CqlDateTime>(d_);

		return e_;
	}

}