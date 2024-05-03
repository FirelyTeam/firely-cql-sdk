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
		var a_ = context.Operators.DateTime(2019, 1, 1, 0, 0, 0, 0, default);
		var b_ = context.Operators.DateTime(2020, 1, 1, 0, 0, 0, 0, default);
		var c_ = context.Operators.Interval(a_, b_, true, false);
		var d_ = context.ResolveParameter("MATGlobalCommonFunctionsFHIR4-6.1.000", "Measurement Period", c_);

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
			var e_ = FHIRHelpers_4_0_001.ToString(EncounterInpatient?.StatusElement);
			var f_ = context.Operators.Equal(e_, "finished");
			var g_ = FHIRHelpers_4_0_001.ToInterval(EncounterInpatient?.Period);
			var h_ = this.LengthInDays(g_);
			var i_ = context.Operators.LessOrEqual(h_, 120);
			var j_ = context.Operators.And(f_, i_);
			var l_ = context.Operators.End(g_);
			var m_ = this.Measurement_Period();
			var n_ = context.Operators.In<CqlDateTime>(l_, m_, null);
			var o_ = context.Operators.And(j_, n_);

			return o_;
		};
		var d_ = context.Operators.Where<Encounter>(b_, c_);

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
			var h_ = FHIRHelpers_4_0_001.ToString(EDVisit?.StatusElement);
			var i_ = context.Operators.Equal(h_, "finished");
			var j_ = FHIRHelpers_4_0_001.ToInterval(EDVisit?.Period);
			var k_ = context.Operators.End(j_);
			var l_ = FHIRHelpers_4_0_001.ToInterval(TheEncounter?.Period);
			var m_ = context.Operators.Start(l_);
			var n_ = context.Operators.Quantity(1m, "hour");
			var o_ = context.Operators.Subtract(m_, n_);
			var q_ = context.Operators.Start(l_);
			var r_ = context.Operators.Interval(o_, q_, true, true);
			var s_ = context.Operators.In<CqlDateTime>(k_, r_, null);
			var u_ = context.Operators.Start(l_);
			var v_ = context.Operators.Not((bool?)(u_ is null));
			var w_ = context.Operators.And(s_, v_);
			var x_ = context.Operators.And(i_, w_);

			return x_;
		};
		var d_ = context.Operators.Where<Encounter>(b_, c_);
		object e_(Encounter @this)
		{
			var y_ = FHIRHelpers_4_0_001.ToInterval(@this?.Period);
			var z_ = context.Operators.End(y_);

			return z_;
		};
		var f_ = context.Operators.SortBy<Encounter>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
		var g_ = context.Operators.Last<Encounter>(f_);

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
					var g_ = FHIRHelpers_4_0_001.ToInterval(TheEncounter?.Period);

					return g_;
				}
				else
				{
					var h_ = FHIRHelpers_4_0_001.ToInterval(X?.Period);
					var i_ = context.Operators.Start(h_);
					var j_ = FHIRHelpers_4_0_001.ToInterval(TheEncounter?.Period);
					var k_ = context.Operators.End(j_);
					var l_ = context.Operators.Interval(i_, k_, true, true);

					return l_;
				};
			};

			return f_();
		};
		var d_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>(b_, c_);
		var e_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(d_);

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
					return (IEnumerable<Encounter.LocationComponent>)TheEncounter?.Location;
				}
				else
				{
					var g_ = new IEnumerable<Encounter.LocationComponent>[]
					{
						(IEnumerable<Encounter.LocationComponent>)EDEncounter?.Location,
						(IEnumerable<Encounter.LocationComponent>)TheEncounter?.Location,
					};
					var h_ = context.Operators.Flatten<Encounter.LocationComponent>((g_ as IEnumerable<IEnumerable<Encounter.LocationComponent>>));

					return h_;
				};
			};

			return f_();
		};
		var d_ = context.Operators.Select<Encounter, IEnumerable<Encounter.LocationComponent>>(b_, c_);
		var e_ = context.Operators.SingletonFrom<IEnumerable<Encounter.LocationComponent>>(d_);

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
		var a_ = FHIRHelpers_4_0_001.ToInterval(TheEncounter?.Period);
		var b_ = context.Operators.End(a_);

		return b_;
	}

    [CqlDeclaration("Hospital Arrival Time")]
	public CqlDateTime Hospital_Arrival_Time(Encounter TheEncounter)
	{
		var a_ = this.Hospitalization_Locations(TheEncounter);
		object b_(Encounter.LocationComponent @this)
		{
			var g_ = FHIRHelpers_4_0_001.ToInterval(@this?.Period);
			var h_ = context.Operators.Start(g_);

			return h_;
		};
		var c_ = context.Operators.SortBy<Encounter.LocationComponent>(a_, b_, System.ComponentModel.ListSortDirection.Ascending);
		var d_ = context.Operators.First<Encounter.LocationComponent>(c_);
		var e_ = FHIRHelpers_4_0_001.ToInterval(d_?.Period);
		var f_ = context.Operators.Start(e_);

		return f_;
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
				var ab_ = FHIRHelpers_4_0_001.ToInterval(LastED?.Period);
				var ac_ = context.Operators.End(ab_);
				var ad_ = this.Observation_Services();
				var ae_ = context.Operators.RetrieveByValueSet<Encounter>(ad_, null);
				bool? af_(Encounter LastObs)
				{
					var bq_ = FHIRHelpers_4_0_001.ToInterval(LastObs?.Period);
					var br_ = context.Operators.End(bq_);
					var bs_ = FHIRHelpers_4_0_001.ToInterval(Visit?.Period);
					var bt_ = context.Operators.Start(bs_);
					var bu_ = context.Operators.Quantity(1m, "hour");
					var bv_ = context.Operators.Subtract(bt_, bu_);
					var bx_ = context.Operators.Start(bs_);
					var by_ = context.Operators.Interval(bv_, bx_, true, true);
					var bz_ = context.Operators.In<CqlDateTime>(br_, by_, null);
					var cb_ = context.Operators.Start(bs_);
					var cc_ = context.Operators.Not((bool?)(cb_ is null));
					var cd_ = context.Operators.And(bz_, cc_);

					return cd_;
				};
				var ag_ = context.Operators.Where<Encounter>(ae_, af_);
				object ah_(Encounter @this)
				{
					var ce_ = FHIRHelpers_4_0_001.ToInterval(@this?.Period);
					var cf_ = context.Operators.End(ce_);

					return cf_;
				};
				var ai_ = context.Operators.SortBy<Encounter>(ag_, ah_, System.ComponentModel.ListSortDirection.Ascending);
				var aj_ = context.Operators.Last<Encounter>(ai_);
				var ak_ = FHIRHelpers_4_0_001.ToInterval(aj_?.Period);
				var al_ = context.Operators.Start(ak_);
				var am_ = FHIRHelpers_4_0_001.ToInterval(Visit?.Period);
				var an_ = context.Operators.Start(am_);
				var ao_ = context.Operators.Quantity(1m, "hour");
				var ap_ = context.Operators.Subtract((al_ ?? an_), ao_);
				var ar_ = context.Operators.RetrieveByValueSet<Encounter>(ad_, null);
				bool? as_(Encounter LastObs)
				{
					var cg_ = FHIRHelpers_4_0_001.ToInterval(LastObs?.Period);
					var ch_ = context.Operators.End(cg_);
					var ci_ = FHIRHelpers_4_0_001.ToInterval(Visit?.Period);
					var cj_ = context.Operators.Start(ci_);
					var ck_ = context.Operators.Quantity(1m, "hour");
					var cl_ = context.Operators.Subtract(cj_, ck_);
					var cn_ = context.Operators.Start(ci_);
					var co_ = context.Operators.Interval(cl_, cn_, true, true);
					var cp_ = context.Operators.In<CqlDateTime>(ch_, co_, null);
					var cr_ = context.Operators.Start(ci_);
					var cs_ = context.Operators.Not((bool?)(cr_ is null));
					var ct_ = context.Operators.And(cp_, cs_);

					return ct_;
				};
				var at_ = context.Operators.Where<Encounter>(ar_, as_);
				object au_(Encounter @this)
				{
					var cu_ = FHIRHelpers_4_0_001.ToInterval(@this?.Period);
					var cv_ = context.Operators.End(cu_);

					return cv_;
				};
				var av_ = context.Operators.SortBy<Encounter>(at_, au_, System.ComponentModel.ListSortDirection.Ascending);
				var aw_ = context.Operators.Last<Encounter>(av_);
				var ax_ = FHIRHelpers_4_0_001.ToInterval(aw_?.Period);
				var ay_ = context.Operators.Start(ax_);
				var ba_ = context.Operators.Start(am_);
				var bb_ = context.Operators.Interval(ap_, (ay_ ?? ba_), true, true);
				var bc_ = context.Operators.In<CqlDateTime>(ac_, bb_, null);
				var be_ = context.Operators.RetrieveByValueSet<Encounter>(ad_, null);
				bool? bf_(Encounter LastObs)
				{
					var cw_ = FHIRHelpers_4_0_001.ToInterval(LastObs?.Period);
					var cx_ = context.Operators.End(cw_);
					var cy_ = FHIRHelpers_4_0_001.ToInterval(Visit?.Period);
					var cz_ = context.Operators.Start(cy_);
					var da_ = context.Operators.Quantity(1m, "hour");
					var db_ = context.Operators.Subtract(cz_, da_);
					var dd_ = context.Operators.Start(cy_);
					var de_ = context.Operators.Interval(db_, dd_, true, true);
					var df_ = context.Operators.In<CqlDateTime>(cx_, de_, null);
					var dh_ = context.Operators.Start(cy_);
					var di_ = context.Operators.Not((bool?)(dh_ is null));
					var dj_ = context.Operators.And(df_, di_);

					return dj_;
				};
				var bg_ = context.Operators.Where<Encounter>(be_, bf_);
				object bh_(Encounter @this)
				{
					var dk_ = FHIRHelpers_4_0_001.ToInterval(@this?.Period);
					var dl_ = context.Operators.End(dk_);

					return dl_;
				};
				var bi_ = context.Operators.SortBy<Encounter>(bg_, bh_, System.ComponentModel.ListSortDirection.Ascending);
				var bj_ = context.Operators.Last<Encounter>(bi_);
				var bk_ = FHIRHelpers_4_0_001.ToInterval(bj_?.Period);
				var bl_ = context.Operators.Start(bk_);
				var bn_ = context.Operators.Start(am_);
				var bo_ = context.Operators.Not((bool?)((bl_ ?? bn_) is null));
				var bp_ = context.Operators.And(bc_, bo_);

				return bp_;
			};
			var h_ = context.Operators.Where<Encounter>(f_, g_);
			object i_(Encounter @this)
			{
				var dm_ = FHIRHelpers_4_0_001.ToInterval(@this?.Period);
				var dn_ = context.Operators.End(dm_);

				return dn_;
			};
			var j_ = context.Operators.SortBy<Encounter>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
			var k_ = context.Operators.Last<Encounter>(j_);
			var l_ = FHIRHelpers_4_0_001.ToInterval(k_?.Period);
			var m_ = context.Operators.Start(l_);
			var n_ = this.Observation_Services();
			var o_ = context.Operators.RetrieveByValueSet<Encounter>(n_, null);
			bool? p_(Encounter LastObs)
			{
				var do_ = FHIRHelpers_4_0_001.ToInterval(LastObs?.Period);
				var dp_ = context.Operators.End(do_);
				var dq_ = FHIRHelpers_4_0_001.ToInterval(Visit?.Period);
				var dr_ = context.Operators.Start(dq_);
				var ds_ = context.Operators.Quantity(1m, "hour");
				var dt_ = context.Operators.Subtract(dr_, ds_);
				var dv_ = context.Operators.Start(dq_);
				var dw_ = context.Operators.Interval(dt_, dv_, true, true);
				var dx_ = context.Operators.In<CqlDateTime>(dp_, dw_, null);
				var dz_ = context.Operators.Start(dq_);
				var ea_ = context.Operators.Not((bool?)(dz_ is null));
				var eb_ = context.Operators.And(dx_, ea_);

				return eb_;
			};
			var q_ = context.Operators.Where<Encounter>(o_, p_);
			object r_(Encounter @this)
			{
				var ec_ = FHIRHelpers_4_0_001.ToInterval(@this?.Period);
				var ed_ = context.Operators.End(ec_);

				return ed_;
			};
			var s_ = context.Operators.SortBy<Encounter>(q_, r_, System.ComponentModel.ListSortDirection.Ascending);
			var t_ = context.Operators.Last<Encounter>(s_);
			var u_ = FHIRHelpers_4_0_001.ToInterval(t_?.Period);
			var v_ = context.Operators.Start(u_);
			var w_ = FHIRHelpers_4_0_001.ToInterval(Visit?.Period);
			var x_ = context.Operators.Start(w_);
			var z_ = context.Operators.End(w_);
			var aa_ = context.Operators.Interval((m_ ?? (v_ ?? x_)), z_, true, true);

			return aa_;
		};
		var c_ = context.Operators.Select<Encounter, CqlInterval<CqlDateTime>>(a_, b_);
		var d_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(c_);

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
				var j_ = FHIRHelpers_4_0_001.ToDate(i_?.BirthDateElement);
				var k_ = FHIRHelpers_4_0_001.ToQuantity((Quantity)(choice as Age));
				var l_ = context.Operators.Add(j_, k_);
				var n_ = FHIRHelpers_4_0_001.ToDate(i_?.BirthDateElement);
				var p_ = context.Operators.Add(n_, k_);
				var q_ = context.Operators.Quantity(1m, "year");
				var r_ = context.Operators.Add(p_, q_);
				var s_ = context.Operators.Interval(l_, r_, true, false);
				var t_ = context.Operators.ConvertDateToDateTime(s_?.low);
				var v_ = FHIRHelpers_4_0_001.ToDate(i_?.BirthDateElement);
				var x_ = context.Operators.Add(v_, k_);
				var z_ = FHIRHelpers_4_0_001.ToDate(i_?.BirthDateElement);
				var ab_ = context.Operators.Add(z_, k_);
				var ad_ = context.Operators.Add(ab_, q_);
				var ae_ = context.Operators.Interval(x_, ad_, true, false);
				var af_ = context.Operators.ConvertDateToDateTime(ae_?.high);
				var ah_ = FHIRHelpers_4_0_001.ToDate(i_?.BirthDateElement);
				var aj_ = context.Operators.Add(ah_, k_);
				var al_ = FHIRHelpers_4_0_001.ToDate(i_?.BirthDateElement);
				var an_ = context.Operators.Add(al_, k_);
				var ap_ = context.Operators.Add(an_, q_);
				var aq_ = context.Operators.Interval(aj_, ap_, true, false);
				var as_ = FHIRHelpers_4_0_001.ToDate(i_?.BirthDateElement);
				var au_ = context.Operators.Add(as_, k_);
				var aw_ = FHIRHelpers_4_0_001.ToDate(i_?.BirthDateElement);
				var ay_ = context.Operators.Add(aw_, k_);
				var ba_ = context.Operators.Add(ay_, q_);
				var bb_ = context.Operators.Interval(au_, ba_, true, false);
				var bc_ = context.Operators.Interval(t_, af_, aq_?.lowClosed, bb_?.highClosed);

				return bc_;
			}
			else if (choice is Range)
			{
				var bd_ = this.Patient();
				var be_ = FHIRHelpers_4_0_001.ToDate(bd_?.BirthDateElement);
				var bf_ = FHIRHelpers_4_0_001.ToQuantity((choice as Range)?.Low);
				var bg_ = context.Operators.Add(be_, bf_);
				var bi_ = FHIRHelpers_4_0_001.ToDate(bd_?.BirthDateElement);
				var bj_ = FHIRHelpers_4_0_001.ToQuantity((choice as Range)?.High);
				var bk_ = context.Operators.Add(bi_, bj_);
				var bl_ = context.Operators.Quantity(1m, "year");
				var bm_ = context.Operators.Add(bk_, bl_);
				var bn_ = context.Operators.Interval(bg_, bm_, true, false);
				var bo_ = context.Operators.ConvertDateToDateTime(bn_?.low);
				var bq_ = FHIRHelpers_4_0_001.ToDate(bd_?.BirthDateElement);
				var bs_ = context.Operators.Add(bq_, bf_);
				var bu_ = FHIRHelpers_4_0_001.ToDate(bd_?.BirthDateElement);
				var bw_ = context.Operators.Add(bu_, bj_);
				var by_ = context.Operators.Add(bw_, bl_);
				var bz_ = context.Operators.Interval(bs_, by_, true, false);
				var ca_ = context.Operators.ConvertDateToDateTime(bz_?.high);
				var cc_ = FHIRHelpers_4_0_001.ToDate(bd_?.BirthDateElement);
				var ce_ = context.Operators.Add(cc_, bf_);
				var cg_ = FHIRHelpers_4_0_001.ToDate(bd_?.BirthDateElement);
				var ci_ = context.Operators.Add(cg_, bj_);
				var ck_ = context.Operators.Add(ci_, bl_);
				var cl_ = context.Operators.Interval(ce_, ck_, true, false);
				var cn_ = FHIRHelpers_4_0_001.ToDate(bd_?.BirthDateElement);
				var cp_ = context.Operators.Add(cn_, bf_);
				var cr_ = FHIRHelpers_4_0_001.ToDate(bd_?.BirthDateElement);
				var ct_ = context.Operators.Add(cr_, bj_);
				var cv_ = context.Operators.Add(ct_, bl_);
				var cw_ = context.Operators.Interval(cp_, cv_, true, false);
				var cx_ = context.Operators.Interval(bo_, ca_, cl_?.lowClosed, cw_?.highClosed);

				return cx_;
			}
			else if (choice is Timing)
			{
				var cy_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null, "1", "Error", "Cannot compute a single interval from a Timing type");

				return cy_;
			}
			else if (choice is FhirString)
			{
				var cz_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null, "1", "Error", "Cannot compute an interval from a String value");

				return cz_;
			}
			else
			{
				return null;
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
				var b_ = FHIRHelpers_4_0_001.ToDateTime((condition?.Abatement as FhirDateTime));
				var d_ = context.Operators.Interval(b_, b_, true, true);

				return d_;
			}
			else if (condition?.Abatement is Period)
			{
				var e_ = FHIRHelpers_4_0_001.ToInterval((condition?.Abatement as Period));

				return e_;
			}
			else if (condition?.Abatement is FhirString)
			{
				var f_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null, "1", "Error", "Cannot compute an interval from a String value");

				return f_;
			}
			else if (condition?.Abatement is Age)
			{
				var g_ = this.Patient();
				var h_ = FHIRHelpers_4_0_001.ToDate(g_?.BirthDateElement);
				var i_ = FHIRHelpers_4_0_001.ToQuantity((Quantity)(condition?.Abatement as Age));
				var j_ = context.Operators.Add(h_, i_);
				var l_ = FHIRHelpers_4_0_001.ToDate(g_?.BirthDateElement);
				var n_ = context.Operators.Add(l_, i_);
				var o_ = context.Operators.Quantity(1m, "year");
				var p_ = context.Operators.Add(n_, o_);
				var q_ = context.Operators.Interval(j_, p_, true, false);
				var r_ = context.Operators.ConvertDateToDateTime(q_?.low);
				var t_ = FHIRHelpers_4_0_001.ToDate(g_?.BirthDateElement);
				var v_ = context.Operators.Add(t_, i_);
				var x_ = FHIRHelpers_4_0_001.ToDate(g_?.BirthDateElement);
				var z_ = context.Operators.Add(x_, i_);
				var ab_ = context.Operators.Add(z_, o_);
				var ac_ = context.Operators.Interval(v_, ab_, true, false);
				var ad_ = context.Operators.ConvertDateToDateTime(ac_?.high);
				var af_ = FHIRHelpers_4_0_001.ToDate(g_?.BirthDateElement);
				var ah_ = context.Operators.Add(af_, i_);
				var aj_ = FHIRHelpers_4_0_001.ToDate(g_?.BirthDateElement);
				var al_ = context.Operators.Add(aj_, i_);
				var an_ = context.Operators.Add(al_, o_);
				var ao_ = context.Operators.Interval(ah_, an_, true, false);
				var aq_ = FHIRHelpers_4_0_001.ToDate(g_?.BirthDateElement);
				var as_ = context.Operators.Add(aq_, i_);
				var au_ = FHIRHelpers_4_0_001.ToDate(g_?.BirthDateElement);
				var aw_ = context.Operators.Add(au_, i_);
				var ay_ = context.Operators.Add(aw_, o_);
				var az_ = context.Operators.Interval(as_, ay_, true, false);
				var ba_ = context.Operators.Interval(r_, ad_, ao_?.lowClosed, az_?.highClosed);

				return ba_;
			}
			else if (condition?.Abatement is Range)
			{
				var bb_ = this.Patient();
				var bc_ = FHIRHelpers_4_0_001.ToDate(bb_?.BirthDateElement);
				var bd_ = FHIRHelpers_4_0_001.ToQuantity((condition?.Abatement as Range)?.Low);
				var be_ = context.Operators.Add(bc_, bd_);
				var bg_ = FHIRHelpers_4_0_001.ToDate(bb_?.BirthDateElement);
				var bh_ = FHIRHelpers_4_0_001.ToQuantity((condition?.Abatement as Range)?.High);
				var bi_ = context.Operators.Add(bg_, bh_);
				var bj_ = context.Operators.Quantity(1m, "year");
				var bk_ = context.Operators.Add(bi_, bj_);
				var bl_ = context.Operators.Interval(be_, bk_, true, false);
				var bm_ = context.Operators.ConvertDateToDateTime(bl_?.low);
				var bo_ = FHIRHelpers_4_0_001.ToDate(bb_?.BirthDateElement);
				var bq_ = context.Operators.Add(bo_, bd_);
				var bs_ = FHIRHelpers_4_0_001.ToDate(bb_?.BirthDateElement);
				var bu_ = context.Operators.Add(bs_, bh_);
				var bw_ = context.Operators.Add(bu_, bj_);
				var bx_ = context.Operators.Interval(bq_, bw_, true, false);
				var by_ = context.Operators.ConvertDateToDateTime(bx_?.high);
				var ca_ = FHIRHelpers_4_0_001.ToDate(bb_?.BirthDateElement);
				var cc_ = context.Operators.Add(ca_, bd_);
				var ce_ = FHIRHelpers_4_0_001.ToDate(bb_?.BirthDateElement);
				var cg_ = context.Operators.Add(ce_, bh_);
				var ci_ = context.Operators.Add(cg_, bj_);
				var cj_ = context.Operators.Interval(cc_, ci_, true, false);
				var cl_ = FHIRHelpers_4_0_001.ToDate(bb_?.BirthDateElement);
				var cn_ = context.Operators.Add(cl_, bd_);
				var cp_ = FHIRHelpers_4_0_001.ToDate(bb_?.BirthDateElement);
				var cr_ = context.Operators.Add(cp_, bh_);
				var ct_ = context.Operators.Add(cr_, bj_);
				var cu_ = context.Operators.Interval(cn_, ct_, true, false);
				var cv_ = context.Operators.Interval(bm_, by_, cj_?.lowClosed, cu_?.highClosed);

				return cv_;
			}
			else if (condition?.Abatement is FhirBoolean)
			{
				var cw_ = this.Normalize_Interval(condition?.Onset);
				var cx_ = context.Operators.End(cw_);
				var cy_ = FHIRHelpers_4_0_001.ToDateTime(condition?.RecordedDateElement);
				var cz_ = context.Operators.Interval(cx_, cy_, true, false);

				return cz_;
			}
			else
			{
				return null;
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
				var c_ = FHIRHelpers_4_0_001.ToConcept(condition?.ClinicalStatus);
				var d_ = this.active();
				var e_ = context.Operators.ConvertCodeToConcept(d_);
				var f_ = context.Operators.Equivalent(c_, e_);
				var h_ = this.recurrence();
				var i_ = context.Operators.ConvertCodeToConcept(h_);
				var j_ = context.Operators.Equivalent(c_, i_);
				var k_ = context.Operators.Or(f_, j_);
				var m_ = this.relapse();
				var n_ = context.Operators.ConvertCodeToConcept(m_);
				var o_ = context.Operators.Equivalent(c_, n_);
				var p_ = context.Operators.Or(k_, o_);

				return (p_ ?? false);
			};
			if (b_())
			{
				var q_ = this.Normalize_Interval(condition?.Onset);
				var r_ = context.Operators.Start(q_);
				var s_ = this.Normalize_Abatement(condition);
				var t_ = context.Operators.End(s_);
				var u_ = context.Operators.Interval(r_, t_, true, true);

				return u_;
			}
			else
			{
				var v_ = this.Normalize_Interval(condition?.Onset);
				var w_ = context.Operators.Start(v_);
				var x_ = this.Normalize_Abatement(condition);
				var y_ = context.Operators.End(x_);
				var z_ = context.Operators.Interval(w_, y_, true, false);

				return z_;
			};
		};

		return a_();
	}

    [CqlDeclaration("GetId")]
	public string GetId(string uri)
	{
		var a_ = context.Operators.Split(uri, "/");
		var b_ = context.Operators.Last<string>(a_);

		return b_;
	}

    [CqlDeclaration("EncounterDiagnosis")]
	public IEnumerable<Condition> EncounterDiagnosis(Encounter Encounter)
	{
		Condition a_(Encounter.DiagnosisComponent D)
		{
			var c_ = context.Operators.RetrieveByValueSet<Condition>(null, null);
			bool? d_(Condition C)
			{
				var g_ = FHIRHelpers_4_0_001.ToString(C?.IdElement);
				var h_ = FHIRHelpers_4_0_001.ToString(D?.Condition?.ReferenceElement);
				var i_ = this.GetId(h_);
				var j_ = context.Operators.Equal(g_, i_);

				return j_;
			};
			var e_ = context.Operators.Where<Condition>(c_, d_);
			var f_ = context.Operators.SingletonFrom<Condition>(e_);

			return f_;
		};
		var b_ = context.Operators.Select<Encounter.DiagnosisComponent, Condition>((IEnumerable<Encounter.DiagnosisComponent>)Encounter?.Diagnosis, a_);

		return b_;
	}

    [CqlDeclaration("GetCondition")]
	public Condition GetCondition(ResourceReference reference)
	{
		var a_ = context.Operators.RetrieveByValueSet<Condition>(null, null);
		bool? b_(Condition C)
		{
			var e_ = FHIRHelpers_4_0_001.ToString(C?.IdElement);
			var f_ = FHIRHelpers_4_0_001.ToString(reference?.ReferenceElement);
			var g_ = this.GetId(f_);
			var h_ = context.Operators.Equal(e_, g_);

			return h_;
		};
		var c_ = context.Operators.Where<Condition>(a_, b_);
		var d_ = context.Operators.SingletonFrom<Condition>(c_);

		return d_;
	}

    [CqlDeclaration("GetExtensions")]
	public IEnumerable<Extension> GetExtensions(DomainResource domainResource, string url)
	{
		bool? a_(Extension E)
		{
			var e_ = context.Operators.Convert<FhirUri>(E?.Url);
			var f_ = FHIRHelpers_4_0_001.ToString(e_);
			var g_ = context.Operators.Concatenate("http://hl7.org/fhir/us/qicore/StructureDefinition/", url);
			var h_ = context.Operators.Equal(f_, g_);

			return h_;
		};
		var b_ = context.Operators.Where<Extension>((IEnumerable<Extension>)domainResource?.Extension, a_);
		Extension c_(Extension E) => 
			E;
		var d_ = context.Operators.Select<Extension, Extension>(b_, c_);

		return d_;
	}

    [CqlDeclaration("GetExtensions")]
	public IEnumerable<Extension> GetExtensions(Element element, string url)
	{
		bool? a_(Extension E)
		{
			var e_ = context.Operators.Convert<FhirUri>(E?.Url);
			var f_ = FHIRHelpers_4_0_001.ToString(e_);
			var g_ = context.Operators.Equal(f_, url);

			return g_;
		};
		var b_ = context.Operators.Where<Extension>((IEnumerable<Extension>)element?.Extension, a_);
		Extension c_(Extension E) => 
			E;
		var d_ = context.Operators.Select<Extension, Extension>(b_, c_);

		return d_;
	}

    [CqlDeclaration("GetExtension")]
	public Extension GetExtension(DomainResource domainResource, string url)
	{
		var a_ = this.GetExtensions(domainResource, url);
		var b_ = context.Operators.SingletonFrom<Extension>(a_);

		return b_;
	}

    [CqlDeclaration("GetExtension")]
	public Extension GetExtension(Element element, string url)
	{
		var a_ = this.GetExtensions(element, url);
		var b_ = context.Operators.SingletonFrom<Extension>(a_);

		return b_;
	}

    [CqlDeclaration("PresentOnAdmissionIndicator")]
	public CodeableConcept PresentOnAdmissionIndicator(Element element)
	{
		var a_ = this.GetExtension(element, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

		return (a_?.Value as CodeableConcept);
	}

    [CqlDeclaration("PrincipalDiagnosis")]
	public Condition PrincipalDiagnosis(Encounter Encounter)
	{
		bool? a_(Encounter.DiagnosisComponent D)
		{
			var h_ = context.Operators.Convert<Integer>(D?.RankElement);
			var i_ = FHIRHelpers_4_0_001.ToInteger(h_);
			var j_ = context.Operators.Equal(i_, 1);

			return j_;
		};
		var b_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)Encounter?.Diagnosis, a_);
		var c_ = context.Operators.SingletonFrom<Encounter.DiagnosisComponent>(b_);
		var d_ = new Encounter.DiagnosisComponent[]
		{
			c_,
		};
		Condition e_(Encounter.DiagnosisComponent PD)
		{
			var k_ = context.Operators.RetrieveByValueSet<Condition>(null, null);
			bool? l_(Condition C)
			{
				var o_ = FHIRHelpers_4_0_001.ToString(C?.IdElement);
				var p_ = FHIRHelpers_4_0_001.ToString(PD?.Condition?.ReferenceElement);
				var q_ = this.GetId(p_);
				var r_ = context.Operators.Equal(o_, q_);

				return r_;
			};
			var m_ = context.Operators.Where<Condition>(k_, l_);
			var n_ = context.Operators.SingletonFrom<Condition>(m_);

			return n_;
		};
		var f_ = context.Operators.Select<Encounter.DiagnosisComponent, Condition>(d_, e_);
		var g_ = context.Operators.SingletonFrom<Condition>(f_);

		return g_;
	}

    [CqlDeclaration("GetLocation")]
	public Location GetLocation(ResourceReference reference)
	{
		var a_ = context.Operators.RetrieveByValueSet<Location>(null, null);
		bool? b_(Location L)
		{
			var e_ = FHIRHelpers_4_0_001.ToString(L?.IdElement);
			var f_ = FHIRHelpers_4_0_001.ToString(reference?.ReferenceElement);
			var g_ = this.GetId(f_);
			var h_ = context.Operators.Equal(e_, g_);

			return h_;
		};
		var c_ = context.Operators.Where<Location>(a_, b_);
		var d_ = context.Operators.SingletonFrom<Location>(c_);

		return d_;
	}

    [CqlDeclaration("GetBaseExtensions")]
	public IEnumerable<Extension> GetBaseExtensions(DomainResource domainResource, string url)
	{
		bool? a_(Extension E)
		{
			var e_ = context.Operators.Convert<FhirUri>(E?.Url);
			var f_ = FHIRHelpers_4_0_001.ToString(e_);
			var g_ = context.Operators.Concatenate("http://hl7.org/fhir/StructureDefinition/", url);
			var h_ = context.Operators.Equal(f_, g_);

			return h_;
		};
		var b_ = context.Operators.Where<Extension>((IEnumerable<Extension>)domainResource?.Extension, a_);
		Extension c_(Extension E) => 
			E;
		var d_ = context.Operators.Select<Extension, Extension>(b_, c_);

		return d_;
	}

    [CqlDeclaration("GetBaseExtension")]
	public Extension GetBaseExtension(DomainResource domainResource, string url)
	{
		var a_ = this.GetBaseExtensions(domainResource, url);
		var b_ = context.Operators.SingletonFrom<Extension>(a_);

		return b_;
	}

    [CqlDeclaration("BaseExtensions")]
    [CqlTag("description", "Returns any base-FHIR extensions defined on the given element with the specified id.")]
    [CqlTag("comment", "NOTE: Extensions are not the preferred approach, but are used as a way to access content that is defined by extensions but not yet surfaced in the CQL model info.")]
	public IEnumerable<Extension> BaseExtensions(Element element, string id)
	{
		bool? a_(Extension E)
		{
			var e_ = context.Operators.Convert<FhirUri>(E?.Url);
			var f_ = FHIRHelpers_4_0_001.ToString(e_);
			var g_ = context.Operators.Concatenate("http://hl7.org/fhir/StructureDefinition/", id);
			var h_ = context.Operators.Equal(f_, g_);

			return h_;
		};
		var b_ = context.Operators.Where<Extension>((IEnumerable<Extension>)element?.Extension, a_);
		Extension c_(Extension E) => 
			E;
		var d_ = context.Operators.Select<Extension, Extension>(b_, c_);

		return d_;
	}

    [CqlDeclaration("BaseExtension")]
    [CqlTag("description", "Returns the single base-FHIR extension (if present) on the given element with the specified id.")]
    [CqlTag("comment", "This function uses singleton from to ensure that a run-time exception is thrown if there is more than one extension on the given resource with the specified url.")]
	public Extension BaseExtension(Element element, string id)
	{
		var a_ = this.BaseExtensions(element, id);
		var b_ = context.Operators.SingletonFrom<Extension>(a_);

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
				var b_ = context.Operators.RetrieveByValueSet<Medication>(null, null);
				bool? c_(Medication M)
				{
					var f_ = FHIRHelpers_4_0_001.ToString(M?.IdElement);
					var g_ = FHIRHelpers_4_0_001.ToString((request?.Medication as ResourceReference)?.ReferenceElement);
					var h_ = this.GetId(g_);
					var i_ = context.Operators.Equal(f_, h_);

					return i_;
				};
				var d_ = context.Operators.Where<Medication>(b_, c_);
				var e_ = context.Operators.SingletonFrom<Medication>(d_);

				return e_?.Code;
			};
		};

		return a_();
	}

    [CqlDeclaration("HasStart")]
	public bool? HasStart(CqlInterval<CqlDateTime> period)
	{
		var a_ = context.Operators.Start(period);
		var c_ = context.Operators.MinValue<CqlDateTime>();
		var d_ = context.Operators.Equal(a_, c_);
		var e_ = context.Operators.Or((bool?)(a_ is null), d_);
		var f_ = context.Operators.Not(e_);

		return f_;
	}

    [CqlDeclaration("HasEnd")]
	public bool? HasEnd(CqlInterval<CqlDateTime> period)
	{
		var a_ = context.Operators.End(period);
		var c_ = context.Operators.MaxValue<CqlDateTime>();
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
		var d_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDateTime>(b_, c_);
		var e_ = context.Operators.SingletonFrom<CqlDateTime>(d_);

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
		var d_ = context.Operators.Select<CqlInterval<CqlDateTime>, CqlDateTime>(b_, c_);
		var e_ = context.Operators.SingletonFrom<CqlDateTime>(d_);

		return e_;
	}

}
