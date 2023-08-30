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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "0.0.1.0")]
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
		var a_ = context.Operators;
		var d_ = a_.ConvertIntegerToDecimal(default);
		var e_ = a_.DateTime((int?)2019, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, d_);
		var h_ = a_.ConvertIntegerToDecimal(default);
		var i_ = a_.DateTime((int?)2020, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, h_);
		var j_ = a_.Interval(e_, i_, true, false);
		var k_ = context.ResolveParameter("MATGlobalCommonFunctionsFHIR4-6.1.000", "Measurement Period", j_);

		return (CqlInterval<CqlDateTime>)k_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period.Value;

	private Patient Patient_Value()
	{
		var a_ = context.Operators;
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Patient>(null, null);
		var d_ = a_.SingleOrNull<Patient>(c_);

		return d_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

    [CqlDeclaration("LengthInDays")]
	public int? LengthInDays(CqlInterval<CqlDateTime> Value)
	{
		var a_ = context.Operators;
		var c_ = a_.Start(Value);
		var e_ = a_.End(Value);
		var f_ = a_.DifferenceBetween(c_, e_, "day");

		return f_;
	}

	private IEnumerable<Encounter> Inpatient_Encounter_Value()
	{
		var a_ = context.Operators;
		var b_ = context.DataRetriever;
		var c_ = this.Encounter_Inpatient();
		var d_ = b_.RetrieveByValueSet<Encounter>(c_, null);
		bool? e_(Encounter EncounterInpatient)
		{
			var g_ = context.Operators;
			var j_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var k_ = j_.Operators;
			var l_ = k_.TypeConverter;
			var m_ = EncounterInpatient?.StatusElement;
			var n_ = l_.Convert<string>(m_);
			var o_ = g_.Equal(n_, "finished");
			var q_ = EncounterInpatient?.Period;
			var r_ = FHIRHelpers_4_0_001.ToInterval(q_);
			var s_ = this.LengthInDays(r_);
			var t_ = g_.LessOrEqual(s_, (int?)120);
			var u_ = g_.And(o_, t_);
			var y_ = FHIRHelpers_4_0_001.ToInterval(q_);
			var z_ = g_.End(y_);
			var aa_ = this.Measurement_Period();
			var ab_ = g_.ElementInInterval<CqlDateTime>(z_, aa_, null);
			var ac_ = g_.And(u_, ab_);

			return ac_;
		};
		var f_ = a_.WhereOrNull<Encounter>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Inpatient Encounter")]
	public IEnumerable<Encounter> Inpatient_Encounter() => 
		__Inpatient_Encounter.Value;

    [CqlDeclaration("ED Visit")]
	public Encounter ED_Visit(Encounter TheEncounter)
	{
		var a_ = context.Operators;
		var d_ = context.DataRetriever;
		var e_ = this.Emergency_Department_Visit();
		var f_ = d_.RetrieveByValueSet<Encounter>(e_, null);
		bool? g_(Encounter EDVisit)
		{
			var l_ = context.Operators;
			var n_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var o_ = n_.Operators;
			var p_ = o_.TypeConverter;
			var q_ = EDVisit?.StatusElement;
			var r_ = p_.Convert<string>(q_);
			var s_ = l_.Equal(r_, "finished");
			var w_ = EDVisit?.Period;
			var x_ = FHIRHelpers_4_0_001.ToInterval(w_);
			var y_ = l_.End(x_);
			var ac_ = TheEncounter?.Period;
			var ad_ = FHIRHelpers_4_0_001.ToInterval(ac_);
			var ae_ = l_.Start(ad_);
			var ag_ = l_.Quantity(1m, "hour");
			var ah_ = l_.Subtract(ae_, ag_);
			var ak_ = FHIRHelpers_4_0_001.ToInterval(ac_);
			var al_ = l_.Start(ak_);
			var am_ = l_.Interval(ah_, al_, true, true);
			var an_ = l_.ElementInInterval<CqlDateTime>(y_, am_, null);
			var ar_ = FHIRHelpers_4_0_001.ToInterval(ac_);
			var as_ = l_.Start(ar_);
			var at_ = l_.Not((bool?)(as_ is null));
			var au_ = l_.And(an_, at_);
			var av_ = l_.And(s_, au_);

			return av_;
		};
		var h_ = a_.WhereOrNull<Encounter>(f_, g_);
		object i_(Encounter @this)
		{
			var aw_ = context.Operators;
			var ax_ = @this?.Period;
			var ay_ = FHIRHelpers_4_0_001.ToInterval(ax_);
			var az_ = aw_.End(ay_);

			return az_;
		};
		var j_ = a_.ListSortBy<Encounter>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
		var k_ = a_.LastOfList<Encounter>(j_);

		return k_;
	}

    [CqlDeclaration("Hospitalization")]
	public CqlInterval<CqlDateTime> Hospitalization(Encounter TheEncounter)
	{
		var a_ = context.Operators;
		var c_ = this.ED_Visit(TheEncounter);
		var d_ = new Encounter[]
		{
			c_,
		};
		CqlInterval<CqlDateTime> e_(Encounter X)
		{
			CqlInterval<CqlDateTime> h_()
			{
				if ((X is null))
				{
					var i_ = TheEncounter?.Period;
					var j_ = FHIRHelpers_4_0_001.ToInterval(i_);

					return j_;
				}
				else
				{
					var k_ = context.Operators;
					var m_ = X?.Period;
					var n_ = FHIRHelpers_4_0_001.ToInterval(m_);
					var o_ = k_.Start(n_);
					var q_ = TheEncounter?.Period;
					var r_ = FHIRHelpers_4_0_001.ToInterval(q_);
					var s_ = k_.End(r_);
					var t_ = k_.Interval(o_, s_, true, true);

					return t_;
				};
			};

			return h_();
		};
		var f_ = a_.SelectOrNull<Encounter, CqlInterval<CqlDateTime>>(d_, e_);
		var g_ = a_.SingleOrNull<CqlInterval<CqlDateTime>>(f_);

		return g_;
	}

    [CqlDeclaration("Hospitalization Locations")]
	public IEnumerable<Encounter.LocationComponent> Hospitalization_Locations(Encounter TheEncounter)
	{
		var a_ = context.Operators;
		var c_ = this.ED_Visit(TheEncounter);
		var d_ = new Encounter[]
		{
			c_,
		};
		IEnumerable<Encounter.LocationComponent> e_(Encounter EDEncounter)
		{
			IEnumerable<Encounter.LocationComponent> h_()
			{
				if ((EDEncounter is null))
				{
					var i_ = TheEncounter?.Location;

					return (i_ as IEnumerable<Encounter.LocationComponent>);
				}
				else
				{
					var j_ = context.Operators;
					var k_ = EDEncounter?.Location;
					var l_ = TheEncounter?.Location;
					var m_ = new IEnumerable<Encounter.LocationComponent>[]
					{
						(k_ as IEnumerable<Encounter.LocationComponent>),
						(l_ as IEnumerable<Encounter.LocationComponent>),
					};
					var n_ = j_.FlattenList<Encounter.LocationComponent>((m_ as IEnumerable<IEnumerable<Encounter.LocationComponent>>));

					return n_;
				};
			};

			return h_();
		};
		var f_ = a_.SelectOrNull<Encounter, IEnumerable<Encounter.LocationComponent>>(d_, e_);
		var g_ = a_.SingleOrNull<IEnumerable<Encounter.LocationComponent>>(f_);

		return g_;
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
		var a_ = context.Operators;
		var b_ = this.Hospitalization(TheEncounter);
		var c_ = a_.Start(b_);

		return c_;
	}

    [CqlDeclaration("Hospital Discharge Time")]
	public CqlDateTime Hospital_Discharge_Time(Encounter TheEncounter)
	{
		var a_ = context.Operators;
		var b_ = TheEncounter?.Period;
		var c_ = FHIRHelpers_4_0_001.ToInterval(b_);
		var d_ = a_.End(c_);

		return d_;
	}

    [CqlDeclaration("Hospital Arrival Time")]
	public CqlDateTime Hospital_Arrival_Time(Encounter TheEncounter)
	{
		var a_ = context.Operators;
		var d_ = this.Hospitalization_Locations(TheEncounter);
		object e_(Encounter.LocationComponent @this)
		{
			var k_ = context.Operators;
			var l_ = @this?.Period;
			var m_ = FHIRHelpers_4_0_001.ToInterval(l_);
			var n_ = k_.Start(m_);

			return n_;
		};
		var f_ = a_.ListSortBy<Encounter.LocationComponent>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
		var g_ = a_.FirstOfList<Encounter.LocationComponent>(f_);
		var h_ = g_?.Period;
		var i_ = FHIRHelpers_4_0_001.ToInterval(h_);
		var j_ = a_.Start(i_);

		return j_;
	}

    [CqlDeclaration("HospitalizationWithObservation")]
	public CqlInterval<CqlDateTime> HospitalizationWithObservation(Encounter TheEncounter)
	{
		var a_ = context.Operators;
		var c_ = new Encounter[]
		{
			TheEncounter,
		};
		CqlInterval<CqlDateTime> d_(Encounter Visit)
		{
			var g_ = context.Operators;
			var l_ = context.DataRetriever;
			var m_ = this.Emergency_Department_Visit();
			var n_ = l_.RetrieveByValueSet<Encounter>(m_, null);
			bool? o_(Encounter LastED)
			{
				var aw_ = context.Operators;
				var az_ = LastED?.Period;
				var ba_ = FHIRHelpers_4_0_001.ToInterval(az_);
				var bb_ = aw_.End(ba_);
				var bi_ = context.DataRetriever;
				var bj_ = this.Observation_Services();
				var bk_ = bi_.RetrieveByValueSet<Encounter>(bj_, null);
				bool? bl_(Encounter LastObs)
				{
					var du_ = context.Operators;
					var dx_ = LastObs?.Period;
					var dy_ = FHIRHelpers_4_0_001.ToInterval(dx_);
					var dz_ = du_.End(dy_);
					var ed_ = Visit?.Period;
					var ee_ = FHIRHelpers_4_0_001.ToInterval(ed_);
					var ef_ = du_.Start(ee_);
					var eh_ = du_.Quantity(1m, "hour");
					var ei_ = du_.Subtract(ef_, eh_);
					var el_ = FHIRHelpers_4_0_001.ToInterval(ed_);
					var em_ = du_.Start(el_);
					var en_ = du_.Interval(ei_, em_, true, true);
					var eo_ = du_.ElementInInterval<CqlDateTime>(dz_, en_, null);
					var es_ = FHIRHelpers_4_0_001.ToInterval(ed_);
					var et_ = du_.Start(es_);
					var eu_ = du_.Not((bool?)(et_ is null));
					var ev_ = du_.And(eo_, eu_);

					return ev_;
				};
				var bm_ = aw_.WhereOrNull<Encounter>(bk_, bl_);
				object bn_(Encounter @this)
				{
					var ew_ = context.Operators;
					var ex_ = @this?.Period;
					var ey_ = FHIRHelpers_4_0_001.ToInterval(ex_);
					var ez_ = ew_.End(ey_);

					return ez_;
				};
				var bo_ = aw_.ListSortBy<Encounter>(bm_, bn_, System.ComponentModel.ListSortDirection.Ascending);
				var bp_ = aw_.LastOfList<Encounter>(bo_);
				var bq_ = bp_?.Period;
				var br_ = FHIRHelpers_4_0_001.ToInterval(bq_);
				var bs_ = aw_.Start(br_);
				var bu_ = Visit?.Period;
				var bv_ = FHIRHelpers_4_0_001.ToInterval(bu_);
				var bw_ = aw_.Start(bv_);
				var bx_ = (bs_ ?? bw_);
				var bz_ = aw_.Quantity(1m, "hour");
				var ca_ = aw_.Subtract(bx_, bz_);
				var ch_ = bi_.RetrieveByValueSet<Encounter>(bj_, null);
				bool? ci_(Encounter LastObs)
				{
					var fa_ = context.Operators;
					var fd_ = LastObs?.Period;
					var fe_ = FHIRHelpers_4_0_001.ToInterval(fd_);
					var ff_ = fa_.End(fe_);
					var fj_ = Visit?.Period;
					var fk_ = FHIRHelpers_4_0_001.ToInterval(fj_);
					var fl_ = fa_.Start(fk_);
					var fn_ = fa_.Quantity(1m, "hour");
					var fo_ = fa_.Subtract(fl_, fn_);
					var fr_ = FHIRHelpers_4_0_001.ToInterval(fj_);
					var fs_ = fa_.Start(fr_);
					var ft_ = fa_.Interval(fo_, fs_, true, true);
					var fu_ = fa_.ElementInInterval<CqlDateTime>(ff_, ft_, null);
					var fy_ = FHIRHelpers_4_0_001.ToInterval(fj_);
					var fz_ = fa_.Start(fy_);
					var ga_ = fa_.Not((bool?)(fz_ is null));
					var gb_ = fa_.And(fu_, ga_);

					return gb_;
				};
				var cj_ = aw_.WhereOrNull<Encounter>(ch_, ci_);
				object ck_(Encounter @this)
				{
					var gc_ = context.Operators;
					var gd_ = @this?.Period;
					var ge_ = FHIRHelpers_4_0_001.ToInterval(gd_);
					var gf_ = gc_.End(ge_);

					return gf_;
				};
				var cl_ = aw_.ListSortBy<Encounter>(cj_, ck_, System.ComponentModel.ListSortDirection.Ascending);
				var cm_ = aw_.LastOfList<Encounter>(cl_);
				var cn_ = cm_?.Period;
				var co_ = FHIRHelpers_4_0_001.ToInterval(cn_);
				var cp_ = aw_.Start(co_);
				var cs_ = FHIRHelpers_4_0_001.ToInterval(bu_);
				var ct_ = aw_.Start(cs_);
				var cu_ = (cp_ ?? ct_);
				var cv_ = aw_.Interval(ca_, cu_, true, true);
				var cw_ = aw_.ElementInInterval<CqlDateTime>(bb_, cv_, null);
				var de_ = bi_.RetrieveByValueSet<Encounter>(bj_, null);
				bool? df_(Encounter LastObs)
				{
					var gg_ = context.Operators;
					var gj_ = LastObs?.Period;
					var gk_ = FHIRHelpers_4_0_001.ToInterval(gj_);
					var gl_ = gg_.End(gk_);
					var gp_ = Visit?.Period;
					var gq_ = FHIRHelpers_4_0_001.ToInterval(gp_);
					var gr_ = gg_.Start(gq_);
					var gt_ = gg_.Quantity(1m, "hour");
					var gu_ = gg_.Subtract(gr_, gt_);
					var gx_ = FHIRHelpers_4_0_001.ToInterval(gp_);
					var gy_ = gg_.Start(gx_);
					var gz_ = gg_.Interval(gu_, gy_, true, true);
					var ha_ = gg_.ElementInInterval<CqlDateTime>(gl_, gz_, null);
					var he_ = FHIRHelpers_4_0_001.ToInterval(gp_);
					var hf_ = gg_.Start(he_);
					var hg_ = gg_.Not((bool?)(hf_ is null));
					var hh_ = gg_.And(ha_, hg_);

					return hh_;
				};
				var dg_ = aw_.WhereOrNull<Encounter>(de_, df_);
				object dh_(Encounter @this)
				{
					var hi_ = context.Operators;
					var hj_ = @this?.Period;
					var hk_ = FHIRHelpers_4_0_001.ToInterval(hj_);
					var hl_ = hi_.End(hk_);

					return hl_;
				};
				var di_ = aw_.ListSortBy<Encounter>(dg_, dh_, System.ComponentModel.ListSortDirection.Ascending);
				var dj_ = aw_.LastOfList<Encounter>(di_);
				var dk_ = dj_?.Period;
				var dl_ = FHIRHelpers_4_0_001.ToInterval(dk_);
				var dm_ = aw_.Start(dl_);
				var dp_ = FHIRHelpers_4_0_001.ToInterval(bu_);
				var dq_ = aw_.Start(dp_);
				var dr_ = (dm_ ?? dq_);
				var ds_ = aw_.Not((bool?)(dr_ is null));
				var dt_ = aw_.And(cw_, ds_);

				return dt_;
			};
			var p_ = g_.WhereOrNull<Encounter>(n_, o_);
			object q_(Encounter @this)
			{
				var hm_ = context.Operators;
				var hn_ = @this?.Period;
				var ho_ = FHIRHelpers_4_0_001.ToInterval(hn_);
				var hp_ = hm_.End(ho_);

				return hp_;
			};
			var r_ = g_.ListSortBy<Encounter>(p_, q_, System.ComponentModel.ListSortDirection.Ascending);
			var s_ = g_.LastOfList<Encounter>(r_);
			var t_ = s_?.Period;
			var u_ = FHIRHelpers_4_0_001.ToInterval(t_);
			var v_ = g_.Start(u_);
			var ab_ = this.Observation_Services();
			var ac_ = l_.RetrieveByValueSet<Encounter>(ab_, null);
			bool? ad_(Encounter LastObs)
			{
				var hq_ = context.Operators;
				var ht_ = LastObs?.Period;
				var hu_ = FHIRHelpers_4_0_001.ToInterval(ht_);
				var hv_ = hq_.End(hu_);
				var hz_ = Visit?.Period;
				var ia_ = FHIRHelpers_4_0_001.ToInterval(hz_);
				var ib_ = hq_.Start(ia_);
				var id_ = hq_.Quantity(1m, "hour");
				var ie_ = hq_.Subtract(ib_, id_);
				var ih_ = FHIRHelpers_4_0_001.ToInterval(hz_);
				var ii_ = hq_.Start(ih_);
				var ij_ = hq_.Interval(ie_, ii_, true, true);
				var ik_ = hq_.ElementInInterval<CqlDateTime>(hv_, ij_, null);
				var io_ = FHIRHelpers_4_0_001.ToInterval(hz_);
				var ip_ = hq_.Start(io_);
				var iq_ = hq_.Not((bool?)(ip_ is null));
				var ir_ = hq_.And(ik_, iq_);

				return ir_;
			};
			var ae_ = g_.WhereOrNull<Encounter>(ac_, ad_);
			object af_(Encounter @this)
			{
				var is_ = context.Operators;
				var it_ = @this?.Period;
				var iu_ = FHIRHelpers_4_0_001.ToInterval(it_);
				var iv_ = is_.End(iu_);

				return iv_;
			};
			var ag_ = g_.ListSortBy<Encounter>(ae_, af_, System.ComponentModel.ListSortDirection.Ascending);
			var ah_ = g_.LastOfList<Encounter>(ag_);
			var ai_ = ah_?.Period;
			var aj_ = FHIRHelpers_4_0_001.ToInterval(ai_);
			var ak_ = g_.Start(aj_);
			var am_ = Visit?.Period;
			var an_ = FHIRHelpers_4_0_001.ToInterval(am_);
			var ao_ = g_.Start(an_);
			var ap_ = (ak_ ?? ao_);
			var aq_ = (v_ ?? ap_);
			var at_ = FHIRHelpers_4_0_001.ToInterval(am_);
			var au_ = g_.End(at_);
			var av_ = g_.Interval(aq_, au_, true, true);

			return av_;
		};
		var e_ = a_.SelectOrNull<Encounter, CqlInterval<CqlDateTime>>(c_, d_);
		var f_ = a_.SingleOrNull<CqlInterval<CqlDateTime>>(e_);

		return f_;
	}

    [CqlDeclaration("Normalize Interval")]
	public CqlInterval<CqlDateTime> Normalize_Interval(object choice)
	{
		CqlInterval<CqlDateTime> a_()
		{
			if (choice is FhirDateTime)
			{
				var b_ = context.Operators;
				var c_ = FHIRHelpers_4_0_001.ToDateTime((choice as FhirDateTime));
				var e_ = b_.Interval(c_, c_, true, true);

				return e_;
			}
			else if (choice is Period)
			{
				var f_ = FHIRHelpers_4_0_001.ToInterval((choice as Period));

				return f_;
			}
			else if (choice is Instant)
			{
				var g_ = context.Operators;
				var h_ = FHIRHelpers_4_0_001.ToDateTime((choice as Instant));
				var j_ = g_.Interval(h_, h_, true, true);

				return j_;
			}
			else if (choice is Age)
			{
				var k_ = context.Operators;
				var o_ = this.Patient();
				var p_ = o_?.BirthDateElement;
				var q_ = FHIRHelpers_4_0_001.ToDate(p_);
				var r_ = FHIRHelpers_4_0_001.ToQuantity((Quantity)(choice as Age));
				var s_ = k_.Add(q_, r_);
				var w_ = o_?.BirthDateElement;
				var x_ = FHIRHelpers_4_0_001.ToDate(w_);
				var z_ = k_.Add(x_, r_);
				var ab_ = k_.Quantity(1m, "year");
				var ac_ = k_.Add(z_, ab_);
				var ad_ = k_.Interval(s_, ac_, true, false);
				var ae_ = ad_?.low;
				var af_ = k_.ConvertDateToDateTime(ae_);
				var ak_ = o_?.BirthDateElement;
				var al_ = FHIRHelpers_4_0_001.ToDate(ak_);
				var an_ = k_.Add(al_, r_);
				var ar_ = o_?.BirthDateElement;
				var as_ = FHIRHelpers_4_0_001.ToDate(ar_);
				var au_ = k_.Add(as_, r_);
				var aw_ = k_.Quantity(1m, "year");
				var ax_ = k_.Add(au_, aw_);
				var ay_ = k_.Interval(an_, ax_, true, false);
				var az_ = ay_?.high;
				var ba_ = k_.ConvertDateToDateTime(az_);
				var be_ = o_?.BirthDateElement;
				var bf_ = FHIRHelpers_4_0_001.ToDate(be_);
				var bh_ = k_.Add(bf_, r_);
				var bl_ = o_?.BirthDateElement;
				var bm_ = FHIRHelpers_4_0_001.ToDate(bl_);
				var bo_ = k_.Add(bm_, r_);
				var bq_ = k_.Quantity(1m, "year");
				var br_ = k_.Add(bo_, bq_);
				var bs_ = k_.Interval(bh_, br_, true, false);
				var bt_ = bs_?.lowClosed;
				var bx_ = o_?.BirthDateElement;
				var by_ = FHIRHelpers_4_0_001.ToDate(bx_);
				var ca_ = k_.Add(by_, r_);
				var ce_ = o_?.BirthDateElement;
				var cf_ = FHIRHelpers_4_0_001.ToDate(ce_);
				var ch_ = k_.Add(cf_, r_);
				var cj_ = k_.Quantity(1m, "year");
				var ck_ = k_.Add(ch_, cj_);
				var cl_ = k_.Interval(ca_, ck_, true, false);
				var cm_ = cl_?.highClosed;
				var cn_ = k_.Interval(af_, ba_, bt_, cm_);

				return cn_;
			}
			else if (choice is Range)
			{
				var co_ = context.Operators;
				var cs_ = this.Patient();
				var ct_ = cs_?.BirthDateElement;
				var cu_ = FHIRHelpers_4_0_001.ToDate(ct_);
				var cv_ = (choice as Range)?.Low;
				var cw_ = FHIRHelpers_4_0_001.ToQuantity(cv_);
				var cx_ = co_.Add(cu_, cw_);
				var db_ = cs_?.BirthDateElement;
				var dc_ = FHIRHelpers_4_0_001.ToDate(db_);
				var dd_ = (choice as Range)?.High;
				var de_ = FHIRHelpers_4_0_001.ToQuantity(dd_);
				var df_ = co_.Add(dc_, de_);
				var dh_ = co_.Quantity(1m, "year");
				var di_ = co_.Add(df_, dh_);
				var dj_ = co_.Interval(cx_, di_, true, false);
				var dk_ = dj_?.low;
				var dl_ = co_.ConvertDateToDateTime(dk_);
				var dq_ = cs_?.BirthDateElement;
				var dr_ = FHIRHelpers_4_0_001.ToDate(dq_);
				var dt_ = FHIRHelpers_4_0_001.ToQuantity(cv_);
				var du_ = co_.Add(dr_, dt_);
				var dy_ = cs_?.BirthDateElement;
				var dz_ = FHIRHelpers_4_0_001.ToDate(dy_);
				var eb_ = FHIRHelpers_4_0_001.ToQuantity(dd_);
				var ec_ = co_.Add(dz_, eb_);
				var ee_ = co_.Quantity(1m, "year");
				var ef_ = co_.Add(ec_, ee_);
				var eg_ = co_.Interval(du_, ef_, true, false);
				var eh_ = eg_?.high;
				var ei_ = co_.ConvertDateToDateTime(eh_);
				var em_ = cs_?.BirthDateElement;
				var en_ = FHIRHelpers_4_0_001.ToDate(em_);
				var ep_ = FHIRHelpers_4_0_001.ToQuantity(cv_);
				var eq_ = co_.Add(en_, ep_);
				var eu_ = cs_?.BirthDateElement;
				var ev_ = FHIRHelpers_4_0_001.ToDate(eu_);
				var ex_ = FHIRHelpers_4_0_001.ToQuantity(dd_);
				var ey_ = co_.Add(ev_, ex_);
				var fa_ = co_.Quantity(1m, "year");
				var fb_ = co_.Add(ey_, fa_);
				var fc_ = co_.Interval(eq_, fb_, true, false);
				var fd_ = fc_?.lowClosed;
				var fh_ = cs_?.BirthDateElement;
				var fi_ = FHIRHelpers_4_0_001.ToDate(fh_);
				var fk_ = FHIRHelpers_4_0_001.ToQuantity(cv_);
				var fl_ = co_.Add(fi_, fk_);
				var fp_ = cs_?.BirthDateElement;
				var fq_ = FHIRHelpers_4_0_001.ToDate(fp_);
				var fs_ = FHIRHelpers_4_0_001.ToQuantity(dd_);
				var ft_ = co_.Add(fq_, fs_);
				var fv_ = co_.Quantity(1m, "year");
				var fw_ = co_.Add(ft_, fv_);
				var fx_ = co_.Interval(fl_, fw_, true, false);
				var fy_ = fx_?.highClosed;
				var fz_ = co_.Interval(dl_, ei_, fd_, fy_);

				return fz_;
			}
			else if (choice is Timing)
			{
				var ga_ = context.Operators;
				CqlInterval<CqlDateTime> gb_ = null;
				var gc_ = ga_.Message<CqlInterval<CqlDateTime>>((gb_ as CqlInterval<CqlDateTime>), "1", "Error", "Cannot compute a single interval from a Timing type");

				return gc_;
			}
			else if (choice is FhirString)
			{
				var gd_ = context.Operators;
				CqlInterval<CqlDateTime> ge_ = null;
				var gf_ = gd_.Message<CqlInterval<CqlDateTime>>((ge_ as CqlInterval<CqlDateTime>), "1", "Error", "Cannot compute an interval from a String value");

				return gf_;
			}
			else
			{
				CqlInterval<CqlDateTime> gg_ = null;

				return (gg_ as CqlInterval<CqlDateTime>);
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
				var b_ = context.Operators;
				var c_ = condition?.Abatement;
				var d_ = FHIRHelpers_4_0_001.ToDateTime((c_ as FhirDateTime));
				var f_ = FHIRHelpers_4_0_001.ToDateTime((c_ as FhirDateTime));
				var g_ = b_.Interval(d_, f_, true, true);

				return g_;
			}
			else if (condition?.Abatement is Period)
			{
				var h_ = condition?.Abatement;
				var i_ = FHIRHelpers_4_0_001.ToInterval((h_ as Period));

				return i_;
			}
			else if (condition?.Abatement is FhirString)
			{
				var j_ = context.Operators;
				CqlInterval<CqlDateTime> k_ = null;
				var l_ = j_.Message<CqlInterval<CqlDateTime>>((k_ as CqlInterval<CqlDateTime>), "1", "Error", "Cannot compute an interval from a String value");

				return l_;
			}
			else if (condition?.Abatement is Age)
			{
				var m_ = context.Operators;
				var q_ = this.Patient();
				var r_ = q_?.BirthDateElement;
				var s_ = FHIRHelpers_4_0_001.ToDate(r_);
				var t_ = condition?.Abatement;
				var u_ = FHIRHelpers_4_0_001.ToQuantity((Quantity)(t_ as Age));
				var v_ = m_.Add(s_, u_);
				var z_ = q_?.BirthDateElement;
				var aa_ = FHIRHelpers_4_0_001.ToDate(z_);
				var ac_ = FHIRHelpers_4_0_001.ToQuantity((Quantity)(t_ as Age));
				var ad_ = m_.Add(aa_, ac_);
				var af_ = m_.Quantity(1m, "year");
				var ag_ = m_.Add(ad_, af_);
				var ah_ = m_.Interval(v_, ag_, true, false);
				var ai_ = ah_?.low;
				var aj_ = m_.ConvertDateToDateTime(ai_);
				var ao_ = q_?.BirthDateElement;
				var ap_ = FHIRHelpers_4_0_001.ToDate(ao_);
				var ar_ = FHIRHelpers_4_0_001.ToQuantity((Quantity)(t_ as Age));
				var as_ = m_.Add(ap_, ar_);
				var aw_ = q_?.BirthDateElement;
				var ax_ = FHIRHelpers_4_0_001.ToDate(aw_);
				var az_ = FHIRHelpers_4_0_001.ToQuantity((Quantity)(t_ as Age));
				var ba_ = m_.Add(ax_, az_);
				var bc_ = m_.Quantity(1m, "year");
				var bd_ = m_.Add(ba_, bc_);
				var be_ = m_.Interval(as_, bd_, true, false);
				var bf_ = be_?.high;
				var bg_ = m_.ConvertDateToDateTime(bf_);
				var bk_ = q_?.BirthDateElement;
				var bl_ = FHIRHelpers_4_0_001.ToDate(bk_);
				var bn_ = FHIRHelpers_4_0_001.ToQuantity((Quantity)(t_ as Age));
				var bo_ = m_.Add(bl_, bn_);
				var bs_ = q_?.BirthDateElement;
				var bt_ = FHIRHelpers_4_0_001.ToDate(bs_);
				var bv_ = FHIRHelpers_4_0_001.ToQuantity((Quantity)(t_ as Age));
				var bw_ = m_.Add(bt_, bv_);
				var by_ = m_.Quantity(1m, "year");
				var bz_ = m_.Add(bw_, by_);
				var ca_ = m_.Interval(bo_, bz_, true, false);
				var cb_ = ca_?.lowClosed;
				var cf_ = q_?.BirthDateElement;
				var cg_ = FHIRHelpers_4_0_001.ToDate(cf_);
				var ci_ = FHIRHelpers_4_0_001.ToQuantity((Quantity)(t_ as Age));
				var cj_ = m_.Add(cg_, ci_);
				var cn_ = q_?.BirthDateElement;
				var co_ = FHIRHelpers_4_0_001.ToDate(cn_);
				var cq_ = FHIRHelpers_4_0_001.ToQuantity((Quantity)(t_ as Age));
				var cr_ = m_.Add(co_, cq_);
				var ct_ = m_.Quantity(1m, "year");
				var cu_ = m_.Add(cr_, ct_);
				var cv_ = m_.Interval(cj_, cu_, true, false);
				var cw_ = cv_?.highClosed;
				var cx_ = m_.Interval(aj_, bg_, cb_, cw_);

				return cx_;
			}
			else if (condition?.Abatement is Range)
			{
				var cy_ = context.Operators;
				var dc_ = this.Patient();
				var dd_ = dc_?.BirthDateElement;
				var de_ = FHIRHelpers_4_0_001.ToDate(dd_);
				var df_ = condition?.Abatement;
				var dg_ = (df_ as Range)?.Low;
				var dh_ = FHIRHelpers_4_0_001.ToQuantity(dg_);
				var di_ = cy_.Add(de_, dh_);
				var dm_ = dc_?.BirthDateElement;
				var dn_ = FHIRHelpers_4_0_001.ToDate(dm_);
				var dp_ = (df_ as Range)?.High;
				var dq_ = FHIRHelpers_4_0_001.ToQuantity(dp_);
				var dr_ = cy_.Add(dn_, dq_);
				var dt_ = cy_.Quantity(1m, "year");
				var du_ = cy_.Add(dr_, dt_);
				var dv_ = cy_.Interval(di_, du_, true, false);
				var dw_ = dv_?.low;
				var dx_ = cy_.ConvertDateToDateTime(dw_);
				var ec_ = dc_?.BirthDateElement;
				var ed_ = FHIRHelpers_4_0_001.ToDate(ec_);
				var ef_ = (df_ as Range)?.Low;
				var eg_ = FHIRHelpers_4_0_001.ToQuantity(ef_);
				var eh_ = cy_.Add(ed_, eg_);
				var el_ = dc_?.BirthDateElement;
				var em_ = FHIRHelpers_4_0_001.ToDate(el_);
				var eo_ = (df_ as Range)?.High;
				var ep_ = FHIRHelpers_4_0_001.ToQuantity(eo_);
				var eq_ = cy_.Add(em_, ep_);
				var es_ = cy_.Quantity(1m, "year");
				var et_ = cy_.Add(eq_, es_);
				var eu_ = cy_.Interval(eh_, et_, true, false);
				var ev_ = eu_?.high;
				var ew_ = cy_.ConvertDateToDateTime(ev_);
				var fa_ = dc_?.BirthDateElement;
				var fb_ = FHIRHelpers_4_0_001.ToDate(fa_);
				var fd_ = (df_ as Range)?.Low;
				var fe_ = FHIRHelpers_4_0_001.ToQuantity(fd_);
				var ff_ = cy_.Add(fb_, fe_);
				var fj_ = dc_?.BirthDateElement;
				var fk_ = FHIRHelpers_4_0_001.ToDate(fj_);
				var fm_ = (df_ as Range)?.High;
				var fn_ = FHIRHelpers_4_0_001.ToQuantity(fm_);
				var fo_ = cy_.Add(fk_, fn_);
				var fq_ = cy_.Quantity(1m, "year");
				var fr_ = cy_.Add(fo_, fq_);
				var fs_ = cy_.Interval(ff_, fr_, true, false);
				var ft_ = fs_?.lowClosed;
				var fx_ = dc_?.BirthDateElement;
				var fy_ = FHIRHelpers_4_0_001.ToDate(fx_);
				var ga_ = (df_ as Range)?.Low;
				var gb_ = FHIRHelpers_4_0_001.ToQuantity(ga_);
				var gc_ = cy_.Add(fy_, gb_);
				var gg_ = dc_?.BirthDateElement;
				var gh_ = FHIRHelpers_4_0_001.ToDate(gg_);
				var gj_ = (df_ as Range)?.High;
				var gk_ = FHIRHelpers_4_0_001.ToQuantity(gj_);
				var gl_ = cy_.Add(gh_, gk_);
				var gn_ = cy_.Quantity(1m, "year");
				var go_ = cy_.Add(gl_, gn_);
				var gp_ = cy_.Interval(gc_, go_, true, false);
				var gq_ = gp_?.highClosed;
				var gr_ = cy_.Interval(dx_, ew_, ft_, gq_);

				return gr_;
			}
			else if (condition?.Abatement is FhirBoolean)
			{
				var gs_ = context.Operators;
				var gu_ = condition?.Onset;
				var gv_ = this.Normalize_Interval(gu_);
				var gw_ = gs_.End(gv_);
				var gx_ = condition?.RecordedDateElement;
				var gy_ = FHIRHelpers_4_0_001.ToDateTime(gx_);
				var gz_ = gs_.Interval(gw_, gy_, true, false);

				return gz_;
			}
			else
			{
				CqlInterval<CqlDateTime> ha_ = null;

				return (ha_ as CqlInterval<CqlDateTime>);
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
				var b_ = context.Operators;
				var d_ = condition?.Onset;
				var e_ = this.Normalize_Interval(d_);
				var f_ = b_.Start(e_);
				var h_ = this.Normalize_Abatement(condition);
				var i_ = b_.End(h_);
				var j_ = b_.Interval(f_, i_, true, true);

				return j_;
			}
			else
			{
				var k_ = context.Operators;
				var m_ = condition?.Onset;
				var n_ = this.Normalize_Interval(m_);
				var o_ = k_.Start(n_);
				var q_ = this.Normalize_Abatement(condition);
				var r_ = k_.End(q_);
				var s_ = k_.Interval(o_, r_, true, false);

				return s_;
			};
		};

		return a_();
	}

    [CqlDeclaration("GetId")]
	public string GetId(string uri)
	{
		var a_ = context.Operators;
		var c_ = a_.Split(uri, "/");
		var d_ = a_.LastOfList<string>(c_);

		return d_;
	}

    [CqlDeclaration("EncounterDiagnosis")]
	public IEnumerable<Condition> EncounterDiagnosis(Encounter Encounter)
	{
		var a_ = context.Operators;
		var b_ = Encounter?.Diagnosis;
		Condition c_(Encounter.DiagnosisComponent D)
		{
			var e_ = context.Operators;
			var g_ = context.DataRetriever;
			var h_ = g_.RetrieveByValueSet<Condition>(null, null);
			bool? i_(Condition C)
			{
				var l_ = context.Operators;
				var m_ = context.Deeper(new CallStackEntry("ToString", null, null));
				var n_ = m_.Operators;
				var o_ = n_.TypeConverter;
				var p_ = C?.IdElement;
				var q_ = o_.Convert<string>(p_);
				var s_ = m_.Operators;
				var t_ = s_.TypeConverter;
				var u_ = D?.Condition;
				var v_ = u_?.ReferenceElement;
				var w_ = t_.Convert<string>(v_);
				var x_ = this.GetId(w_);
				var y_ = l_.Equal(q_, x_);

				return y_;
			};
			var j_ = e_.WhereOrNull<Condition>(h_, i_);
			var k_ = e_.SingleOrNull<Condition>(j_);

			return k_;
		};
		var d_ = a_.SelectOrNull<Encounter.DiagnosisComponent, Condition>((b_ as IEnumerable<Encounter.DiagnosisComponent>), c_);

		return d_;
	}

    [CqlDeclaration("GetCondition")]
	public Condition GetCondition(ResourceReference reference)
	{
		var a_ = context.Operators;
		var c_ = context.DataRetriever;
		var d_ = c_.RetrieveByValueSet<Condition>(null, null);
		bool? e_(Condition C)
		{
			var h_ = context.Operators;
			var i_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var j_ = i_.Operators;
			var k_ = j_.TypeConverter;
			var l_ = C?.IdElement;
			var m_ = k_.Convert<string>(l_);
			var o_ = i_.Operators;
			var p_ = o_.TypeConverter;
			var q_ = reference?.ReferenceElement;
			var r_ = p_.Convert<string>(q_);
			var s_ = this.GetId(r_);
			var t_ = h_.Equal(m_, s_);

			return t_;
		};
		var f_ = a_.WhereOrNull<Condition>(d_, e_);
		var g_ = a_.SingleOrNull<Condition>(f_);

		return g_;
	}

    [CqlDeclaration("GetExtensions")]
	public IEnumerable<Extension> GetExtensions(DomainResource domainResource, string url)
	{
		var a_ = context.Operators;
		var c_ = domainResource?.Extension;
		bool? d_(Extension E)
		{
			var h_ = context.Operators;
			var i_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var j_ = i_.Operators;
			var k_ = j_.TypeConverter;
			var m_ = h_.TypeConverter;
			var n_ = E?.Url;
			var o_ = m_.Convert<FhirUri>(n_);
			var p_ = k_.Convert<string>(o_);
			var r_ = h_.Concatenate("http://hl7.org/fhir/us/qicore/StructureDefinition/", url);
			var s_ = h_.Equal(p_, r_);

			return s_;
		};
		var e_ = a_.WhereOrNull<Extension>((c_ as IEnumerable<Extension>), d_);
		Extension f_(Extension E) => 
			E;
		var g_ = a_.SelectOrNull<Extension, Extension>(e_, f_);

		return g_;
	}

    [CqlDeclaration("GetExtensions")]
	public IEnumerable<Extension> GetExtensions(Element element, string url)
	{
		var a_ = context.Operators;
		var c_ = element?.Extension;
		bool? d_(Extension E)
		{
			var h_ = context.Operators;
			var i_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var j_ = i_.Operators;
			var k_ = j_.TypeConverter;
			var m_ = h_.TypeConverter;
			var n_ = E?.Url;
			var o_ = m_.Convert<FhirUri>(n_);
			var p_ = k_.Convert<string>(o_);
			var q_ = h_.Equal(p_, url);

			return q_;
		};
		var e_ = a_.WhereOrNull<Extension>((c_ as IEnumerable<Extension>), d_);
		Extension f_(Extension E) => 
			E;
		var g_ = a_.SelectOrNull<Extension, Extension>(e_, f_);

		return g_;
	}

    [CqlDeclaration("GetExtension")]
	public Extension GetExtension(DomainResource domainResource, string url)
	{
		var a_ = context.Operators;
		var b_ = this.GetExtensions(domainResource, url);
		var c_ = a_.SingleOrNull<Extension>(b_);

		return c_;
	}

    [CqlDeclaration("GetExtension")]
	public Extension GetExtension(Element element, string url)
	{
		var a_ = context.Operators;
		var b_ = this.GetExtensions(element, url);
		var c_ = a_.SingleOrNull<Extension>(b_);

		return c_;
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
		var a_ = context.Operators;
		var e_ = Encounter?.Diagnosis;
		bool? f_(Encounter.DiagnosisComponent D)
		{
			var m_ = context.Operators;
			var o_ = m_.TypeConverter;
			var p_ = D?.RankElement;
			var q_ = o_.Convert<Integer>(p_);
			var r_ = FHIRHelpers_4_0_001.ToInteger(q_);
			var s_ = m_.Equal(r_, (int?)1);

			return s_;
		};
		var g_ = a_.WhereOrNull<Encounter.DiagnosisComponent>((e_ as IEnumerable<Encounter.DiagnosisComponent>), f_);
		var h_ = a_.SingleOrNull<Encounter.DiagnosisComponent>(g_);
		var i_ = new Encounter.DiagnosisComponent[]
		{
			h_,
		};
		Condition j_(Encounter.DiagnosisComponent PD)
		{
			var t_ = context.Operators;
			var v_ = context.DataRetriever;
			var w_ = v_.RetrieveByValueSet<Condition>(null, null);
			bool? x_(Condition C)
			{
				var aa_ = context.Operators;
				var ab_ = context.Deeper(new CallStackEntry("ToString", null, null));
				var ac_ = ab_.Operators;
				var ad_ = ac_.TypeConverter;
				var ae_ = C?.IdElement;
				var af_ = ad_.Convert<string>(ae_);
				var ah_ = ab_.Operators;
				var ai_ = ah_.TypeConverter;
				var aj_ = PD?.Condition;
				var ak_ = aj_?.ReferenceElement;
				var al_ = ai_.Convert<string>(ak_);
				var am_ = this.GetId(al_);
				var an_ = aa_.Equal(af_, am_);

				return an_;
			};
			var y_ = t_.WhereOrNull<Condition>(w_, x_);
			var z_ = t_.SingleOrNull<Condition>(y_);

			return z_;
		};
		var k_ = a_.SelectOrNull<Encounter.DiagnosisComponent, Condition>(i_, j_);
		var l_ = a_.SingleOrNull<Condition>(k_);

		return l_;
	}

    [CqlDeclaration("GetLocation")]
	public Location GetLocation(ResourceReference reference)
	{
		var a_ = context.Operators;
		var c_ = context.DataRetriever;
		var d_ = c_.RetrieveByValueSet<Location>(null, null);
		bool? e_(Location L)
		{
			var h_ = context.Operators;
			var i_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var j_ = i_.Operators;
			var k_ = j_.TypeConverter;
			var l_ = L?.IdElement;
			var m_ = k_.Convert<string>(l_);
			var o_ = i_.Operators;
			var p_ = o_.TypeConverter;
			var q_ = reference?.ReferenceElement;
			var r_ = p_.Convert<string>(q_);
			var s_ = this.GetId(r_);
			var t_ = h_.Equal(m_, s_);

			return t_;
		};
		var f_ = a_.WhereOrNull<Location>(d_, e_);
		var g_ = a_.SingleOrNull<Location>(f_);

		return g_;
	}

    [CqlDeclaration("GetBaseExtensions")]
	public IEnumerable<Extension> GetBaseExtensions(DomainResource domainResource, string url)
	{
		var a_ = context.Operators;
		var c_ = domainResource?.Extension;
		bool? d_(Extension E)
		{
			var h_ = context.Operators;
			var i_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var j_ = i_.Operators;
			var k_ = j_.TypeConverter;
			var m_ = h_.TypeConverter;
			var n_ = E?.Url;
			var o_ = m_.Convert<FhirUri>(n_);
			var p_ = k_.Convert<string>(o_);
			var r_ = h_.Concatenate("http://hl7.org/fhir/StructureDefinition/", url);
			var s_ = h_.Equal(p_, r_);

			return s_;
		};
		var e_ = a_.WhereOrNull<Extension>((c_ as IEnumerable<Extension>), d_);
		Extension f_(Extension E) => 
			E;
		var g_ = a_.SelectOrNull<Extension, Extension>(e_, f_);

		return g_;
	}

    [CqlDeclaration("GetBaseExtension")]
	public Extension GetBaseExtension(DomainResource domainResource, string url)
	{
		var a_ = context.Operators;
		var b_ = this.GetBaseExtensions(domainResource, url);
		var c_ = a_.SingleOrNull<Extension>(b_);

		return c_;
	}

    [CqlDeclaration("BaseExtensions")]
	public IEnumerable<Extension> BaseExtensions(Element element, string id)
	{
		var a_ = context.Operators;
		var c_ = element?.Extension;
		bool? d_(Extension E)
		{
			var h_ = context.Operators;
			var i_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var j_ = i_.Operators;
			var k_ = j_.TypeConverter;
			var m_ = h_.TypeConverter;
			var n_ = E?.Url;
			var o_ = m_.Convert<FhirUri>(n_);
			var p_ = k_.Convert<string>(o_);
			var r_ = h_.Concatenate("http://hl7.org/fhir/StructureDefinition/", id);
			var s_ = h_.Equal(p_, r_);

			return s_;
		};
		var e_ = a_.WhereOrNull<Extension>((c_ as IEnumerable<Extension>), d_);
		Extension f_(Extension E) => 
			E;
		var g_ = a_.SelectOrNull<Extension, Extension>(e_, f_);

		return g_;
	}

    [CqlDeclaration("BaseExtension")]
	public Extension BaseExtension(Element element, string id)
	{
		var a_ = context.Operators;
		var b_ = this.BaseExtensions(element, id);
		var c_ = a_.SingleOrNull<Extension>(b_);

		return c_;
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
				var c_ = context.Operators;
				var e_ = context.DataRetriever;
				var f_ = e_.RetrieveByValueSet<Medication>(null, null);
				bool? g_(Medication M)
				{
					var k_ = context.Operators;
					var l_ = context.Deeper(new CallStackEntry("ToString", null, null));
					var m_ = l_.Operators;
					var n_ = m_.TypeConverter;
					var o_ = M?.IdElement;
					var p_ = n_.Convert<string>(o_);
					var r_ = l_.Operators;
					var s_ = r_.TypeConverter;
					var t_ = request?.Medication;
					var u_ = (t_ as ResourceReference)?.ReferenceElement;
					var v_ = s_.Convert<string>(u_);
					var w_ = this.GetId(v_);
					var x_ = k_.Equal(p_, w_);

					return x_;
				};
				var h_ = c_.WhereOrNull<Medication>(f_, g_);
				var i_ = c_.SingleOrNull<Medication>(h_);
				var j_ = i_?.Code;

				return j_;
			};
		};

		return a_();
	}

    [CqlDeclaration("HasStart")]
	public bool? HasStart(CqlInterval<CqlDateTime> period)
	{
		var a_ = context.Operators;
		var d_ = a_.Start(period);
		var g_ = a_.Start(period);
		var i_ = a_.Minimum<CqlDateTime>();
		var j_ = a_.Equal(g_, i_);
		var k_ = a_.Or((bool?)(d_ is null), j_);
		var l_ = a_.Not(k_);

		return l_;
	}

    [CqlDeclaration("HasEnd")]
	public bool? HasEnd(CqlInterval<CqlDateTime> period)
	{
		var a_ = context.Operators;
		var d_ = a_.End(period);
		var g_ = a_.End(period);
		var i_ = a_.Maximum<CqlDateTime>();
		var j_ = a_.Equal(g_, i_);
		var k_ = a_.Or((bool?)(d_ is null), j_);
		var l_ = a_.Not(k_);

		return l_;
	}

    [CqlDeclaration("Latest")]
	public CqlDateTime Latest(object choice)
	{
		var a_ = context.Operators;
		var c_ = this.Normalize_Interval(choice);
		var d_ = new CqlInterval<CqlDateTime>[]
		{
			c_,
		};
		CqlDateTime e_(CqlInterval<CqlDateTime> period)
		{
			CqlDateTime h_()
			{
				if ((this.HasEnd(period) ?? false))
				{
					var i_ = context.Operators;
					var j_ = i_.End(period);

					return j_;
				}
				else
				{
					var k_ = context.Operators;
					var l_ = k_.Start(period);

					return l_;
				};
			};

			return h_();
		};
		var f_ = a_.SelectOrNull<CqlInterval<CqlDateTime>, CqlDateTime>(d_, e_);
		var g_ = a_.SingleOrNull<CqlDateTime>(f_);

		return g_;
	}

    [CqlDeclaration("Earliest")]
	public CqlDateTime Earliest(object choice)
	{
		var a_ = context.Operators;
		var c_ = this.Normalize_Interval(choice);
		var d_ = new CqlInterval<CqlDateTime>[]
		{
			c_,
		};
		CqlDateTime e_(CqlInterval<CqlDateTime> period)
		{
			CqlDateTime h_()
			{
				if ((this.HasStart(period) ?? false))
				{
					var i_ = context.Operators;
					var j_ = i_.Start(period);

					return j_;
				}
				else
				{
					var k_ = context.Operators;
					var l_ = k_.End(period);

					return l_;
				};
			};

			return h_();
		};
		var f_ = a_.SelectOrNull<CqlInterval<CqlDateTime>, CqlDateTime>(d_, e_);
		var g_ = a_.SingleOrNull<CqlDateTime>(f_);

		return g_;
	}

}