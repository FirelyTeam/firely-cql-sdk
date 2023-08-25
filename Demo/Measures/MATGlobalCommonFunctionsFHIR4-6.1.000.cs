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

    private CqlValueSet Emergency_Department_Visit_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", null);

		return a_;
	}

    [CqlDeclaration("Emergency Department Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292")]
    public CqlValueSet Emergency_Department_Visit() => __Emergency_Department_Visit.Value;

    private CqlValueSet Encounter_Inpatient_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

		return a_;
	}

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
    public CqlValueSet Encounter_Inpatient() => __Encounter_Inpatient.Value;

    private CqlValueSet Observation_Services_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", null);

		return a_;
	}

    [CqlDeclaration("Observation Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143")]
    public CqlValueSet Observation_Services() => __Observation_Services.Value;

    private CqlValueSet Present_on_Admission_or_Clinically_Undetermined_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.197", null);

		return a_;
	}

    [CqlDeclaration("Present on Admission or Clinically Undetermined")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.197")]
    public CqlValueSet Present_on_Admission_or_Clinically_Undetermined() => __Present_on_Admission_or_Clinically_Undetermined.Value;

    private CqlCode active_Value()
	{
		var a_ = new CqlCode("active", "http://terminology.hl7.org/CodeSystem/condition-clinical", null, null);

		return a_;
	}

    [CqlDeclaration("active")]
    public CqlCode active() => __active.Value;

    private CqlCode allergy_active_Value()
	{
		var a_ = new CqlCode("active", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", null, null);

		return a_;
	}

    [CqlDeclaration("allergy-active")]
    public CqlCode allergy_active() => __allergy_active.Value;

    private CqlCode allergy_confirmed_Value()
	{
		var a_ = new CqlCode("confirmed", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", null, null);

		return a_;
	}

    [CqlDeclaration("allergy-confirmed")]
    public CqlCode allergy_confirmed() => __allergy_confirmed.Value;

    private CqlCode allergy_inactive_Value()
	{
		var a_ = new CqlCode("inactive", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", null, null);

		return a_;
	}

    [CqlDeclaration("allergy-inactive")]
    public CqlCode allergy_inactive() => __allergy_inactive.Value;

    private CqlCode allergy_refuted_Value()
	{
		var a_ = new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", null, null);

		return a_;
	}

    [CqlDeclaration("allergy-refuted")]
    public CqlCode allergy_refuted() => __allergy_refuted.Value;

    private CqlCode allergy_resolved_Value()
	{
		var a_ = new CqlCode("resolved", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", null, null);

		return a_;
	}

    [CqlDeclaration("allergy-resolved")]
    public CqlCode allergy_resolved() => __allergy_resolved.Value;

    private CqlCode allergy_unconfirmed_Value()
	{
		var a_ = new CqlCode("unconfirmed", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", null, null);

		return a_;
	}

    [CqlDeclaration("allergy-unconfirmed")]
    public CqlCode allergy_unconfirmed() => __allergy_unconfirmed.Value;

    private CqlCode Billing_Value()
	{
		var a_ = new CqlCode("billing", "http://terminology.hl7.org/CodeSystem/diagnosis-role", null, null);

		return a_;
	}

    [CqlDeclaration("Billing")]
    public CqlCode Billing() => __Billing.Value;

    private CqlCode Birthdate_Value()
	{
		var a_ = new CqlCode("21112-8", "http://loinc.org", null, null);

		return a_;
	}

    [CqlDeclaration("Birthdate")]
    public CqlCode Birthdate() => __Birthdate.Value;

    private CqlCode Community_Value()
	{
		var a_ = new CqlCode("community", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", null, null);

		return a_;
	}

    [CqlDeclaration("Community")]
    public CqlCode Community() => __Community.Value;

    private CqlCode confirmed_Value()
	{
		var a_ = new CqlCode("confirmed", "http://terminology.hl7.org/CodeSystem/condition-ver-status", null, null);

		return a_;
	}

    [CqlDeclaration("confirmed")]
    public CqlCode confirmed() => __confirmed.Value;

    private CqlCode Dead_Value()
	{
		var a_ = new CqlCode("419099009", "http://snomed.info/sct", null, null);

		return a_;
	}

    [CqlDeclaration("Dead")]
    public CqlCode Dead() => __Dead.Value;

    private CqlCode differential_Value()
	{
		var a_ = new CqlCode("differential", "http://terminology.hl7.org/CodeSystem/condition-ver-status", null, null);

		return a_;
	}

    [CqlDeclaration("differential")]
    public CqlCode differential() => __differential.Value;

    private CqlCode Discharge_Value()
	{
		var a_ = new CqlCode("discharge", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", null, null);

		return a_;
	}

    [CqlDeclaration("Discharge")]
    public CqlCode Discharge() => __Discharge.Value;

    private CqlCode entered_in_error_Value()
	{
		var a_ = new CqlCode("entered-in-error", "http://terminology.hl7.org/CodeSystem/condition-ver-status", null, null);

		return a_;
	}

    [CqlDeclaration("entered-in-error")]
    public CqlCode entered_in_error() => __entered_in_error.Value;

    private CqlCode ER_Value()
	{
		var a_ = new CqlCode("ER", "http://terminology.hl7.org/CodeSystem/v3-RoleCode", null, null);

		return a_;
	}

    [CqlDeclaration("ER")]
    public CqlCode ER() => __ER.Value;

    private CqlCode ICU_Value()
	{
		var a_ = new CqlCode("ICU", "http://terminology.hl7.org/CodeSystem/v3-RoleCode", null, null);

		return a_;
	}

    [CqlDeclaration("ICU")]
    public CqlCode ICU() => __ICU.Value;

    private CqlCode inactive_Value()
	{
		var a_ = new CqlCode("inactive", "http://terminology.hl7.org/CodeSystem/condition-clinical", null, null);

		return a_;
	}

    [CqlDeclaration("inactive")]
    public CqlCode inactive() => __inactive.Value;

    private CqlCode provisional_Value()
	{
		var a_ = new CqlCode("provisional", "http://terminology.hl7.org/CodeSystem/condition-ver-status", null, null);

		return a_;
	}

    [CqlDeclaration("provisional")]
    public CqlCode provisional() => __provisional.Value;

    private CqlCode recurrence_Value()
	{
		var a_ = new CqlCode("recurrence", "http://terminology.hl7.org/CodeSystem/condition-clinical", null, null);

		return a_;
	}

    [CqlDeclaration("recurrence")]
    public CqlCode recurrence() => __recurrence.Value;

    private CqlCode refuted_Value()
	{
		var a_ = new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/condition-ver-status", null, null);

		return a_;
	}

    [CqlDeclaration("refuted")]
    public CqlCode refuted() => __refuted.Value;

    private CqlCode relapse_Value()
	{
		var a_ = new CqlCode("relapse", "http://terminology.hl7.org/CodeSystem/condition-clinical", null, null);

		return a_;
	}

    [CqlDeclaration("relapse")]
    public CqlCode relapse() => __relapse.Value;

    private CqlCode remission_Value()
	{
		var a_ = new CqlCode("remission", "http://terminology.hl7.org/CodeSystem/condition-clinical", null, null);

		return a_;
	}

    [CqlDeclaration("remission")]
    public CqlCode remission() => __remission.Value;

    private CqlCode resolved_Value()
	{
		var a_ = new CqlCode("resolved", "http://terminology.hl7.org/CodeSystem/condition-clinical", null, null);

		return a_;
	}

    [CqlDeclaration("resolved")]
    public CqlCode resolved() => __resolved.Value;

    private CqlCode unconfirmed_Value()
	{
		var a_ = new CqlCode("unconfirmed", "http://terminology.hl7.org/CodeSystem/condition-ver-status", null, null);

		return a_;
	}

    [CqlDeclaration("unconfirmed")]
    public CqlCode unconfirmed() => __unconfirmed.Value;

    private CqlCode[] ConditionClinicalStatusCodes_Value()
	{
		var a_ = new CqlCode("active", "http://terminology.hl7.org/CodeSystem/condition-clinical", null, null);
		var b_ = new CqlCode("inactive", "http://terminology.hl7.org/CodeSystem/condition-clinical", null, null);
		var c_ = new CqlCode("recurrence", "http://terminology.hl7.org/CodeSystem/condition-clinical", null, null);
		var d_ = new CqlCode("relapse", "http://terminology.hl7.org/CodeSystem/condition-clinical", null, null);
		var e_ = new CqlCode("remission", "http://terminology.hl7.org/CodeSystem/condition-clinical", null, null);
		var f_ = new CqlCode("resolved", "http://terminology.hl7.org/CodeSystem/condition-clinical", null, null);
		var g_ = new CqlCode[]
		{
			a_,
			b_,
			c_,
			d_,
			e_,
			f_,
		};

		return g_;
	}

    [CqlDeclaration("ConditionClinicalStatusCodes")]
    public CqlCode[] ConditionClinicalStatusCodes() => __ConditionClinicalStatusCodes.Value;

    private CqlCode[] AllergyIntoleranceClinicalStatusCodes_Value()
	{
		var a_ = new CqlCode("active", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", null, null);
		var b_ = new CqlCode("inactive", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", null, null);
		var c_ = new CqlCode("resolved", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", null, null);
		var d_ = new CqlCode[]
		{
			a_,
			b_,
			c_,
		};

		return d_;
	}

    [CqlDeclaration("AllergyIntoleranceClinicalStatusCodes")]
    public CqlCode[] AllergyIntoleranceClinicalStatusCodes() => __AllergyIntoleranceClinicalStatusCodes.Value;

    private CqlCode[] AllergyIntoleranceVerificationStatusCodes_Value()
	{
		var a_ = new CqlCode("confirmed", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", null, null);
		var b_ = new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", null, null);
		var c_ = new CqlCode("unconfirmed", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", null, null);
		var d_ = new CqlCode[]
		{
			a_,
			b_,
			c_,
		};

		return d_;
	}

    [CqlDeclaration("AllergyIntoleranceVerificationStatusCodes")]
    public CqlCode[] AllergyIntoleranceVerificationStatusCodes() => __AllergyIntoleranceVerificationStatusCodes.Value;

    private CqlCode[] Diagnosis_Role_Value()
	{
		var a_ = new CqlCode("billing", "http://terminology.hl7.org/CodeSystem/diagnosis-role", null, null);
		var b_ = new CqlCode[]
		{
			a_,
		};

		return b_;
	}

    [CqlDeclaration("Diagnosis Role")]
    public CqlCode[] Diagnosis_Role() => __Diagnosis_Role.Value;

    private CqlCode[] LOINC_Value()
	{
		var a_ = new CqlCode("21112-8", "http://loinc.org", null, null);
		var b_ = new CqlCode[]
		{
			a_,
		};

		return b_;
	}

    [CqlDeclaration("LOINC")]
    public CqlCode[] LOINC() => __LOINC.Value;

    private CqlCode[] MedicationRequestCategory_Value()
	{
		var a_ = new CqlCode("community", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", null, null);
		var b_ = new CqlCode("discharge", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", null, null);
		var c_ = new CqlCode[]
		{
			a_,
			b_,
		};

		return c_;
	}

    [CqlDeclaration("MedicationRequestCategory")]
    public CqlCode[] MedicationRequestCategory() => __MedicationRequestCategory.Value;

    private CqlCode[] ConditionVerificationStatusCodes_Value()
	{
		var a_ = new CqlCode("confirmed", "http://terminology.hl7.org/CodeSystem/condition-ver-status", null, null);
		var b_ = new CqlCode("differential", "http://terminology.hl7.org/CodeSystem/condition-ver-status", null, null);
		var c_ = new CqlCode("entered-in-error", "http://terminology.hl7.org/CodeSystem/condition-ver-status", null, null);
		var d_ = new CqlCode("provisional", "http://terminology.hl7.org/CodeSystem/condition-ver-status", null, null);
		var e_ = new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/condition-ver-status", null, null);
		var f_ = new CqlCode("unconfirmed", "http://terminology.hl7.org/CodeSystem/condition-ver-status", null, null);
		var g_ = new CqlCode[]
		{
			a_,
			b_,
			c_,
			d_,
			e_,
			f_,
		};

		return g_;
	}

    [CqlDeclaration("ConditionVerificationStatusCodes")]
    public CqlCode[] ConditionVerificationStatusCodes() => __ConditionVerificationStatusCodes.Value;

    private CqlCode[] SNOMEDCT_Value()
	{
		var a_ = new CqlCode("419099009", "http://snomed.info/sct", null, null);
		var b_ = new CqlCode[]
		{
			a_,
		};

		return b_;
	}

    [CqlDeclaration("SNOMEDCT")]
    public CqlCode[] SNOMEDCT() => __SNOMEDCT.Value;

    private CqlCode[] RoleCode_Value()
	{
		var a_ = new CqlCode("ER", "http://terminology.hl7.org/CodeSystem/v3-RoleCode", null, null);
		var b_ = new CqlCode("ICU", "http://terminology.hl7.org/CodeSystem/v3-RoleCode", null, null);
		var c_ = new CqlCode[]
		{
			a_,
			b_,
		};

		return c_;
	}

    [CqlDeclaration("RoleCode")]
    public CqlCode[] RoleCode() => __RoleCode.Value;

    private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = (int?)2019;
		var b_ = (int?)1;
		var d_ = (int?)0;
		var h_ = context.Operators;
		var i_ = h_.ConvertIntegerToDecimal(default);
		var k_ = h_.DateTime(a_, b_, b_, d_, d_, d_, d_, i_);
		var l_ = (int?)2020;
		var t_ = h_.ConvertIntegerToDecimal(default);
		var v_ = h_.DateTime(l_, b_, b_, d_, d_, d_, d_, t_);
		var x_ = h_.Interval(k_, v_, true, false);
		var y_ = context.ResolveParameter("MATGlobalCommonFunctionsFHIR4-6.1.000", "Measurement Period", x_);
		var z_ = (CqlInterval<CqlDateTime>)y_;

		return z_;
	}

    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period() => __Measurement_Period.Value;

    private Patient Patient_Value()
	{
		var a_ = context.DataRetriever;
		var b_ = a_.RetrieveByValueSet<Patient>(null, null);
		var c_ = context.Operators;
		var d_ = c_.SingleOrNull<Patient>(b_);

		return d_;
	}

    [CqlDeclaration("Patient")]
    public Patient Patient() => __Patient.Value;

    [CqlDeclaration("LengthInDays")]
    public int? LengthInDays(CqlInterval<CqlDateTime> Value)
	{
		var a_ = context.Operators;
		var b_ = a_.Start(Value);
		var d_ = a_.End(Value);
		var f_ = a_.DifferenceBetween(b_, d_, "day");

		return f_;
	}


    private IEnumerable<Encounter> Inpatient_Encounter_Value()
	{
		var a_ = this.Encounter_Inpatient();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Encounter>(a_, null);
		var d_ = (Encounter EncounterInpatient) =>
		{
			var g_ = EncounterInpatient.StatusElement;
			var h_ = new CallStackEntry("ToString", null, null);
			var i_ = context.Deeper(h_);
			var j_ = i_.Operators;
			var k_ = j_.TypeConverter;
			var l_ = k_.Convert<string>(g_);
			var m_ = context.Operators;
			var n_ = m_.Equal(l_, "finished");
			var o_ = EncounterInpatient.Period;
			var p_ = FHIRHelpers_4_0_001.ToInterval(o_);
			var q_ = this.LengthInDays(p_);
			var r_ = q_;
			var s_ = (int?)120;
			var t_ = s_;
			var v_ = m_.LessOrEqual(r_, t_);
			var x_ = m_.And(n_, v_);
			var z_ = FHIRHelpers_4_0_001.ToInterval(o_);
			var ab_ = m_.End(z_);
			var ac_ = this.Measurement_Period();
			var ae_ = m_.ElementInInterval<CqlDateTime>(ab_, ac_, null);
			var ag_ = m_.And(x_, ae_);

			return ag_;
		};
		var e_ = context.Operators;
		var f_ = e_.WhereOrNull<Encounter>(c_, d_);

		return f_;
	}

    [CqlDeclaration("Inpatient Encounter")]
    public IEnumerable<Encounter> Inpatient_Encounter() => __Inpatient_Encounter.Value;

    [CqlDeclaration("ED Visit")]
    public Encounter ED_Visit(Encounter TheEncounter)
	{
		var a_ = this.Emergency_Department_Visit();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Encounter>(a_, null);
		var d_ = (Encounter EDVisit) =>
		{
			var l_ = EDVisit.StatusElement;
			var m_ = new CallStackEntry("ToString", null, null);
			var n_ = context.Deeper(m_);
			var o_ = n_.Operators;
			var p_ = o_.TypeConverter;
			var q_ = p_.Convert<string>(l_);
			var r_ = context.Operators;
			var s_ = r_.Equal(q_, "finished");
			var t_ = EDVisit.Period;
			var u_ = FHIRHelpers_4_0_001.ToInterval(t_);
			var w_ = r_.End(u_);
			var x_ = TheEncounter.Period;
			var y_ = FHIRHelpers_4_0_001.ToInterval(x_);
			var aa_ = r_.Start(y_);
			var ac_ = r_.Quantity(1m, "hour");
			var ae_ = r_.Subtract(aa_, ac_);
			var ag_ = FHIRHelpers_4_0_001.ToInterval(x_);
			var ai_ = r_.Start(ag_);
			var ak_ = r_.Interval(ae_, ai_, true, true);
			var am_ = r_.ElementInInterval<CqlDateTime>(w_, ak_, null);
			var ao_ = FHIRHelpers_4_0_001.ToInterval(x_);
			var aq_ = r_.Start(ao_);
			var ar_ = (aq_ == null);
			var as_ = (bool?)ar_;
			var au_ = r_.Not(as_);
			var aw_ = r_.And(am_, au_);
			var ay_ = r_.And(s_, aw_);

			return ay_;
		};
		var e_ = context.Operators;
		var f_ = e_.WhereOrNull<Encounter>(c_, d_);
		var g_ = (Encounter @this) =>
		{
			var az_ = @this.Period;
			var ba_ = FHIRHelpers_4_0_001.ToInterval(az_);
			var bb_ = context.Operators;
			var bc_ = bb_.End(ba_);

			return bc_;
		};
		var i_ = e_.ListSortBy<Encounter>(f_, g_, System.ComponentModel.ListSortDirection.Ascending);
		var k_ = e_.LastOfList<Encounter>(i_);

		return k_;
	}


    [CqlDeclaration("Hospitalization")]
    public CqlInterval<CqlDateTime> Hospitalization(Encounter TheEncounter)
	{
		var a_ = this.ED_Visit(TheEncounter);
		var b_ = new Encounter[]
		{
			a_,
		};
		var c_ = (Encounter X) => (((X == null))
			? (FHIRHelpers_4_0_001.ToInterval(TheEncounter.Period))
			: (context.Operators.Interval(context.Operators.Start(FHIRHelpers_4_0_001.ToInterval(X.Period)), context.Operators.End(FHIRHelpers_4_0_001.ToInterval(TheEncounter.Period)), true, true)))
;
		var d_ = context.Operators;
		var e_ = d_.SelectOrNull<Encounter, CqlInterval<CqlDateTime>>(b_, c_);
		var g_ = d_.SingleOrNull<CqlInterval<CqlDateTime>>(e_);

		return g_;
	}


    [CqlDeclaration("Hospitalization Locations")]
    public IEnumerable<Encounter.LocationComponent> Hospitalization_Locations(Encounter TheEncounter)
	{
		var a_ = this.ED_Visit(TheEncounter);
		var b_ = new Encounter[]
		{
			a_,
		};
		var c_ = (Encounter EDEncounter) => (((EDEncounter == null))
			? ((TheEncounter.Location as IEnumerable<Encounter.LocationComponent>))
			: (context.Operators.FlattenList<Encounter.LocationComponent>((new IEnumerable<Encounter.LocationComponent>[]
					{
						(EDEncounter.Location as IEnumerable<Encounter.LocationComponent>),
						(TheEncounter.Location as IEnumerable<Encounter.LocationComponent>),
					} as IEnumerable<IEnumerable<Encounter.LocationComponent>>))))
;
		var d_ = context.Operators;
		var e_ = d_.SelectOrNull<Encounter, IEnumerable<Encounter.LocationComponent>>(b_, c_);
		var g_ = d_.SingleOrNull<IEnumerable<Encounter.LocationComponent>>(e_);

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
		var a_ = this.Hospitalization(TheEncounter);
		var b_ = context.Operators;
		var c_ = b_.Start(a_);

		return c_;
	}


    [CqlDeclaration("Hospital Discharge Time")]
    public CqlDateTime Hospital_Discharge_Time(Encounter TheEncounter)
	{
		var a_ = TheEncounter.Period;
		var b_ = FHIRHelpers_4_0_001.ToInterval(a_);
		var c_ = context.Operators;
		var d_ = c_.End(b_);

		return d_;
	}


    [CqlDeclaration("Hospital Arrival Time")]
    public CqlDateTime Hospital_Arrival_Time(Encounter TheEncounter)
	{
		var a_ = this.Hospitalization_Locations(TheEncounter);
		var b_ = (Encounter.LocationComponent @this) =>
		{
			var k_ = @this.Period;
			var l_ = FHIRHelpers_4_0_001.ToInterval(k_);
			var m_ = context.Operators;
			var n_ = m_.Start(l_);

			return n_;
		};
		var c_ = context.Operators;
		var d_ = c_.ListSortBy<Encounter.LocationComponent>(a_, b_, System.ComponentModel.ListSortDirection.Ascending);
		var f_ = c_.FirstOfList<Encounter.LocationComponent>(d_);
		var g_ = f_.Period;
		var h_ = FHIRHelpers_4_0_001.ToInterval(g_);
		var j_ = c_.Start(h_);

		return j_;
	}


    [CqlDeclaration("HospitalizationWithObservation")]
    public CqlInterval<CqlDateTime> HospitalizationWithObservation(Encounter TheEncounter)
	{
		var a_ = new Encounter[]
		{
			TheEncounter,
		};
		var b_ = (Encounter Visit) =>
		{
			var g_ = this.Emergency_Department_Visit();
			var h_ = context.DataRetriever;
			var i_ = h_.RetrieveByValueSet<Encounter>(g_, null);
			var j_ = (Encounter LastED) =>
			{
				var aw_ = LastED.Period;
				var ax_ = FHIRHelpers_4_0_001.ToInterval(aw_);
				var ay_ = context.Operators;
				var az_ = ay_.End(ax_);
				var ba_ = this.Observation_Services();
				var bb_ = context.DataRetriever;
				var bc_ = bb_.RetrieveByValueSet<Encounter>(ba_, null);
				var bd_ = (Encounter LastObs) =>
				{
					var dw_ = LastObs.Period;
					var dx_ = FHIRHelpers_4_0_001.ToInterval(dw_);
					var dy_ = context.Operators;
					var dz_ = dy_.End(dx_);
					var ea_ = Visit.Period;
					var eb_ = FHIRHelpers_4_0_001.ToInterval(ea_);
					var ed_ = dy_.Start(eb_);
					var ef_ = dy_.Quantity(1m, "hour");
					var eh_ = dy_.Subtract(ed_, ef_);
					var ej_ = FHIRHelpers_4_0_001.ToInterval(ea_);
					var el_ = dy_.Start(ej_);
					var en_ = dy_.Interval(eh_, el_, true, true);
					var ep_ = dy_.ElementInInterval<CqlDateTime>(dz_, en_, null);
					var er_ = FHIRHelpers_4_0_001.ToInterval(ea_);
					var et_ = dy_.Start(er_);
					var eu_ = (et_ == null);
					var ev_ = (bool?)eu_;
					var ex_ = dy_.Not(ev_);
					var ez_ = dy_.And(ep_, ex_);

					return ez_;
				};
				var bf_ = ay_.WhereOrNull<Encounter>(bc_, bd_);
				var bg_ = (Encounter @this) =>
				{
					var fa_ = @this.Period;
					var fb_ = FHIRHelpers_4_0_001.ToInterval(fa_);
					var fc_ = context.Operators;
					var fd_ = fc_.End(fb_);

					return fd_;
				};
				var bi_ = ay_.ListSortBy<Encounter>(bf_, bg_, System.ComponentModel.ListSortDirection.Ascending);
				var bk_ = ay_.LastOfList<Encounter>(bi_);
				var bl_ = bk_.Period;
				var bm_ = FHIRHelpers_4_0_001.ToInterval(bl_);
				var bo_ = ay_.Start(bm_);
				var bp_ = Visit.Period;
				var bq_ = FHIRHelpers_4_0_001.ToInterval(bp_);
				var bs_ = ay_.Start(bq_);
				var bt_ = (bo_ ?? bs_);
				var bv_ = ay_.Quantity(1m, "hour");
				var bx_ = ay_.Subtract(bt_, bv_);
				var ca_ = bb_.RetrieveByValueSet<Encounter>(ba_, null);
				var cb_ = (Encounter LastObs) =>
				{
					var fe_ = LastObs.Period;
					var ff_ = FHIRHelpers_4_0_001.ToInterval(fe_);
					var fg_ = context.Operators;
					var fh_ = fg_.End(ff_);
					var fi_ = Visit.Period;
					var fj_ = FHIRHelpers_4_0_001.ToInterval(fi_);
					var fl_ = fg_.Start(fj_);
					var fn_ = fg_.Quantity(1m, "hour");
					var fp_ = fg_.Subtract(fl_, fn_);
					var fr_ = FHIRHelpers_4_0_001.ToInterval(fi_);
					var ft_ = fg_.Start(fr_);
					var fv_ = fg_.Interval(fp_, ft_, true, true);
					var fx_ = fg_.ElementInInterval<CqlDateTime>(fh_, fv_, null);
					var fz_ = FHIRHelpers_4_0_001.ToInterval(fi_);
					var gb_ = fg_.Start(fz_);
					var gc_ = (gb_ == null);
					var gd_ = (bool?)gc_;
					var gf_ = fg_.Not(gd_);
					var gh_ = fg_.And(fx_, gf_);

					return gh_;
				};
				var cd_ = ay_.WhereOrNull<Encounter>(ca_, cb_);
				var ce_ = (Encounter @this) =>
				{
					var gi_ = @this.Period;
					var gj_ = FHIRHelpers_4_0_001.ToInterval(gi_);
					var gk_ = context.Operators;
					var gl_ = gk_.End(gj_);

					return gl_;
				};
				var cg_ = ay_.ListSortBy<Encounter>(cd_, ce_, System.ComponentModel.ListSortDirection.Ascending);
				var ci_ = ay_.LastOfList<Encounter>(cg_);
				var cj_ = ci_.Period;
				var ck_ = FHIRHelpers_4_0_001.ToInterval(cj_);
				var cm_ = ay_.Start(ck_);
				var co_ = FHIRHelpers_4_0_001.ToInterval(bp_);
				var cq_ = ay_.Start(co_);
				var cr_ = (cm_ ?? cq_);
				var ct_ = ay_.Interval(bx_, cr_, true, true);
				var cv_ = ay_.ElementInInterval<CqlDateTime>(az_, ct_, null);
				var cy_ = bb_.RetrieveByValueSet<Encounter>(ba_, null);
				var cz_ = (Encounter LastObs) =>
				{
					var gm_ = LastObs.Period;
					var gn_ = FHIRHelpers_4_0_001.ToInterval(gm_);
					var go_ = context.Operators;
					var gp_ = go_.End(gn_);
					var gq_ = Visit.Period;
					var gr_ = FHIRHelpers_4_0_001.ToInterval(gq_);
					var gt_ = go_.Start(gr_);
					var gv_ = go_.Quantity(1m, "hour");
					var gx_ = go_.Subtract(gt_, gv_);
					var gz_ = FHIRHelpers_4_0_001.ToInterval(gq_);
					var hb_ = go_.Start(gz_);
					var hd_ = go_.Interval(gx_, hb_, true, true);
					var hf_ = go_.ElementInInterval<CqlDateTime>(gp_, hd_, null);
					var hh_ = FHIRHelpers_4_0_001.ToInterval(gq_);
					var hj_ = go_.Start(hh_);
					var hk_ = (hj_ == null);
					var hl_ = (bool?)hk_;
					var hn_ = go_.Not(hl_);
					var hp_ = go_.And(hf_, hn_);

					return hp_;
				};
				var db_ = ay_.WhereOrNull<Encounter>(cy_, cz_);
				var dc_ = (Encounter @this) =>
				{
					var hq_ = @this.Period;
					var hr_ = FHIRHelpers_4_0_001.ToInterval(hq_);
					var hs_ = context.Operators;
					var ht_ = hs_.End(hr_);

					return ht_;
				};
				var de_ = ay_.ListSortBy<Encounter>(db_, dc_, System.ComponentModel.ListSortDirection.Ascending);
				var dg_ = ay_.LastOfList<Encounter>(de_);
				var dh_ = dg_.Period;
				var di_ = FHIRHelpers_4_0_001.ToInterval(dh_);
				var dk_ = ay_.Start(di_);
				var dm_ = FHIRHelpers_4_0_001.ToInterval(bp_);
				var do_ = ay_.Start(dm_);
				var dp_ = (dk_ ?? do_);
				var dq_ = (dp_ == null);
				var dr_ = (bool?)dq_;
				var dt_ = ay_.Not(dr_);
				var dv_ = ay_.And(cv_, dt_);

				return dv_;
			};
			var k_ = context.Operators;
			var l_ = k_.WhereOrNull<Encounter>(i_, j_);
			var m_ = (Encounter @this) =>
			{
				var hu_ = @this.Period;
				var hv_ = FHIRHelpers_4_0_001.ToInterval(hu_);
				var hw_ = context.Operators;
				var hx_ = hw_.End(hv_);

				return hx_;
			};
			var o_ = k_.ListSortBy<Encounter>(l_, m_, System.ComponentModel.ListSortDirection.Ascending);
			var q_ = k_.LastOfList<Encounter>(o_);
			var r_ = q_.Period;
			var s_ = FHIRHelpers_4_0_001.ToInterval(r_);
			var u_ = k_.Start(s_);
			var v_ = this.Observation_Services();
			var x_ = h_.RetrieveByValueSet<Encounter>(v_, null);
			var y_ = (Encounter LastObs) =>
			{
				var hy_ = LastObs.Period;
				var hz_ = FHIRHelpers_4_0_001.ToInterval(hy_);
				var ia_ = context.Operators;
				var ib_ = ia_.End(hz_);
				var ic_ = Visit.Period;
				var id_ = FHIRHelpers_4_0_001.ToInterval(ic_);
				var if_ = ia_.Start(id_);
				var ih_ = ia_.Quantity(1m, "hour");
				var ij_ = ia_.Subtract(if_, ih_);
				var il_ = FHIRHelpers_4_0_001.ToInterval(ic_);
				var in_ = ia_.Start(il_);
				var ip_ = ia_.Interval(ij_, in_, true, true);
				var ir_ = ia_.ElementInInterval<CqlDateTime>(ib_, ip_, null);
				var it_ = FHIRHelpers_4_0_001.ToInterval(ic_);
				var iv_ = ia_.Start(it_);
				var iw_ = (iv_ == null);
				var ix_ = (bool?)iw_;
				var iz_ = ia_.Not(ix_);
				var jb_ = ia_.And(ir_, iz_);

				return jb_;
			};
			var aa_ = k_.WhereOrNull<Encounter>(x_, y_);
			var ab_ = (Encounter @this) =>
			{
				var jc_ = @this.Period;
				var jd_ = FHIRHelpers_4_0_001.ToInterval(jc_);
				var je_ = context.Operators;
				var jf_ = je_.End(jd_);

				return jf_;
			};
			var ad_ = k_.ListSortBy<Encounter>(aa_, ab_, System.ComponentModel.ListSortDirection.Ascending);
			var af_ = k_.LastOfList<Encounter>(ad_);
			var ag_ = af_.Period;
			var ah_ = FHIRHelpers_4_0_001.ToInterval(ag_);
			var aj_ = k_.Start(ah_);
			var ak_ = Visit.Period;
			var al_ = FHIRHelpers_4_0_001.ToInterval(ak_);
			var an_ = k_.Start(al_);
			var ao_ = (aj_ ?? an_);
			var ap_ = (u_ ?? ao_);
			var ar_ = FHIRHelpers_4_0_001.ToInterval(ak_);
			var at_ = k_.End(ar_);
			var av_ = k_.Interval(ap_, at_, true, true);

			return av_;
		};
		var c_ = context.Operators;
		var d_ = c_.SelectOrNull<Encounter, CqlInterval<CqlDateTime>>(a_, b_);
		var f_ = c_.SingleOrNull<CqlInterval<CqlDateTime>>(d_);

		return f_;
	}


    [CqlDeclaration("Normalize Interval")]
    public CqlInterval<CqlDateTime> Normalize_Interval(object choice)
    {
        if (((choice is FhirDateTime as bool?) ?? false))
		{
			var a__ = (choice as FhirDateTime);
			var b__ = FHIRHelpers_4_0_001.ToDateTime(a__);
			var d__ = FHIRHelpers_4_0_001.ToDateTime(a__);
			var e__ = context.Operators;
			var f__ = e__.Interval(b__, d__, true, true);

			return f__;
		}
        else if (((choice is Period as bool?) ?? false))
		{
			var a__ = (choice as Period);
			var b__ = FHIRHelpers_4_0_001.ToInterval(a__);

			return b__;
		}
        else if (((choice is Instant as bool?) ?? false))
		{
			var a__ = (choice as Instant);
			var b__ = FHIRHelpers_4_0_001.ToDateTime(a__);
			var d__ = FHIRHelpers_4_0_001.ToDateTime(a__);
			var e__ = context.Operators;
			var f__ = e__.Interval(b__, d__, true, true);

			return f__;
		}
        else if (((choice is Age as bool?) ?? false))
		{
			var a__ = this.Patient();
			var b__ = a__.BirthDateElement;
			var c__ = FHIRHelpers_4_0_001.ToDate(b__);
			var d__ = (choice as Age);
			var e__ = (Quantity)d__;
			var f__ = FHIRHelpers_4_0_001.ToQuantity(e__);
			var g__ = context.Operators;
			var h__ = g__.Add(c__, f__);
			var j__ = a__.BirthDateElement;
			var k__ = FHIRHelpers_4_0_001.ToDate(j__);
			var m__ = (Quantity)d__;
			var n__ = FHIRHelpers_4_0_001.ToQuantity(m__);
			var p__ = g__.Add(k__, n__);
			var r__ = g__.Quantity(1m, "year");
			var t__ = g__.Add(p__, r__);
			var v__ = g__.Interval(h__, t__, true, false);
			var w__ = v__.low;
			var y__ = g__.ConvertDateToDateTime(w__);
			var aa__ = a__.BirthDateElement;
			var ab__ = FHIRHelpers_4_0_001.ToDate(aa__);
			var ad__ = (Quantity)d__;
			var ae__ = FHIRHelpers_4_0_001.ToQuantity(ad__);
			var ag__ = g__.Add(ab__, ae__);
			var ai__ = a__.BirthDateElement;
			var aj__ = FHIRHelpers_4_0_001.ToDate(ai__);
			var al__ = (Quantity)d__;
			var am__ = FHIRHelpers_4_0_001.ToQuantity(al__);
			var ao__ = g__.Add(aj__, am__);
			var aq__ = g__.Quantity(1m, "year");
			var as__ = g__.Add(ao__, aq__);
			var au__ = g__.Interval(ag__, as__, true, false);
			var av__ = au__.high;
			var ax__ = g__.ConvertDateToDateTime(av__);
			var az__ = a__.BirthDateElement;
			var ba__ = FHIRHelpers_4_0_001.ToDate(az__);
			var bc__ = (Quantity)d__;
			var bd__ = FHIRHelpers_4_0_001.ToQuantity(bc__);
			var bf__ = g__.Add(ba__, bd__);
			var bh__ = a__.BirthDateElement;
			var bi__ = FHIRHelpers_4_0_001.ToDate(bh__);
			var bk__ = (Quantity)d__;
			var bl__ = FHIRHelpers_4_0_001.ToQuantity(bk__);
			var bn__ = g__.Add(bi__, bl__);
			var bp__ = g__.Quantity(1m, "year");
			var br__ = g__.Add(bn__, bp__);
			var bt__ = g__.Interval(bf__, br__, true, false);
			var bu__ = bt__.lowClosed;
			var bw__ = a__.BirthDateElement;
			var bx__ = FHIRHelpers_4_0_001.ToDate(bw__);
			var bz__ = (Quantity)d__;
			var ca__ = FHIRHelpers_4_0_001.ToQuantity(bz__);
			var cc__ = g__.Add(bx__, ca__);
			var ce__ = a__.BirthDateElement;
			var cf__ = FHIRHelpers_4_0_001.ToDate(ce__);
			var ch__ = (Quantity)d__;
			var ci__ = FHIRHelpers_4_0_001.ToQuantity(ch__);
			var ck__ = g__.Add(cf__, ci__);
			var cm__ = g__.Quantity(1m, "year");
			var co__ = g__.Add(ck__, cm__);
			var cq__ = g__.Interval(cc__, co__, true, false);
			var cr__ = cq__.highClosed;
			var ct__ = g__.Interval(y__, ax__, bu__, cr__);

			return ct__;
		}
        else if (((choice is Range as bool?) ?? false))
		{
			var a__ = this.Patient();
			var b__ = a__.BirthDateElement;
			var c__ = FHIRHelpers_4_0_001.ToDate(b__);
			var d__ = (choice as Range);
			var e__ = d__.Low;
			var f__ = FHIRHelpers_4_0_001.ToQuantity(e__);
			var g__ = context.Operators;
			var h__ = g__.Add(c__, f__);
			var j__ = a__.BirthDateElement;
			var k__ = FHIRHelpers_4_0_001.ToDate(j__);
			var m__ = d__.High;
			var n__ = FHIRHelpers_4_0_001.ToQuantity(m__);
			var p__ = g__.Add(k__, n__);
			var r__ = g__.Quantity(1m, "year");
			var t__ = g__.Add(p__, r__);
			var v__ = g__.Interval(h__, t__, true, false);
			var w__ = v__.low;
			var y__ = g__.ConvertDateToDateTime(w__);
			var aa__ = a__.BirthDateElement;
			var ab__ = FHIRHelpers_4_0_001.ToDate(aa__);
			var ad__ = d__.Low;
			var ae__ = FHIRHelpers_4_0_001.ToQuantity(ad__);
			var ag__ = g__.Add(ab__, ae__);
			var ai__ = a__.BirthDateElement;
			var aj__ = FHIRHelpers_4_0_001.ToDate(ai__);
			var al__ = d__.High;
			var am__ = FHIRHelpers_4_0_001.ToQuantity(al__);
			var ao__ = g__.Add(aj__, am__);
			var aq__ = g__.Quantity(1m, "year");
			var as__ = g__.Add(ao__, aq__);
			var au__ = g__.Interval(ag__, as__, true, false);
			var av__ = au__.high;
			var ax__ = g__.ConvertDateToDateTime(av__);
			var az__ = a__.BirthDateElement;
			var ba__ = FHIRHelpers_4_0_001.ToDate(az__);
			var bc__ = d__.Low;
			var bd__ = FHIRHelpers_4_0_001.ToQuantity(bc__);
			var bf__ = g__.Add(ba__, bd__);
			var bh__ = a__.BirthDateElement;
			var bi__ = FHIRHelpers_4_0_001.ToDate(bh__);
			var bk__ = d__.High;
			var bl__ = FHIRHelpers_4_0_001.ToQuantity(bk__);
			var bn__ = g__.Add(bi__, bl__);
			var bp__ = g__.Quantity(1m, "year");
			var br__ = g__.Add(bn__, bp__);
			var bt__ = g__.Interval(bf__, br__, true, false);
			var bu__ = bt__.lowClosed;
			var bw__ = a__.BirthDateElement;
			var bx__ = FHIRHelpers_4_0_001.ToDate(bw__);
			var bz__ = d__.Low;
			var ca__ = FHIRHelpers_4_0_001.ToQuantity(bz__);
			var cc__ = g__.Add(bx__, ca__);
			var ce__ = a__.BirthDateElement;
			var cf__ = FHIRHelpers_4_0_001.ToDate(ce__);
			var ch__ = d__.High;
			var ci__ = FHIRHelpers_4_0_001.ToQuantity(ch__);
			var ck__ = g__.Add(cf__, ci__);
			var cm__ = g__.Quantity(1m, "year");
			var co__ = g__.Add(ck__, cm__);
			var cq__ = g__.Interval(cc__, co__, true, false);
			var cr__ = cq__.highClosed;
			var ct__ = g__.Interval(y__, ax__, bu__, cr__);

			return ct__;
		}
        else if (((choice is Timing as bool?) ?? false))
		{
			CqlInterval<CqlDateTime> a__ = null;
			var b__ = (a__ as CqlInterval<CqlDateTime>);
			var c__ = context.Operators;
			var d__ = c__.Message<CqlInterval<CqlDateTime>>(b__, "1", "Error", "Cannot compute a single interval from a Timing type");

			return d__;
		}
        else if (((choice is FhirString as bool?) ?? false))
		{
			CqlInterval<CqlDateTime> a__ = null;
			var b__ = (a__ as CqlInterval<CqlDateTime>);
			var c__ = context.Operators;
			var d__ = c__.Message<CqlInterval<CqlDateTime>>(b__, "1", "Error", "Cannot compute an interval from a String value");

			return d__;
		}
        else
		{
			CqlInterval<CqlDateTime> a__ = null;
			var b__ = (a__ as CqlInterval<CqlDateTime>);

			return b__;
		}
    }


    [CqlDeclaration("Normalize Abatement")]
    public CqlInterval<CqlDateTime> Normalize_Abatement(Condition condition)
    {
        if (((condition.Abatement is FhirDateTime as bool?) ?? false))
		{
			var a__ = condition.Abatement;
			var b__ = (a__ as FhirDateTime);
			var c__ = FHIRHelpers_4_0_001.ToDateTime(b__);
			var e__ = (a__ as FhirDateTime);
			var f__ = FHIRHelpers_4_0_001.ToDateTime(e__);
			var g__ = context.Operators;
			var h__ = g__.Interval(c__, f__, true, true);

			return h__;
		}
        else if (((condition.Abatement is Period as bool?) ?? false))
		{
			var a__ = condition.Abatement;
			var b__ = (a__ as Period);
			var c__ = FHIRHelpers_4_0_001.ToInterval(b__);

			return c__;
		}
        else if (((condition.Abatement is FhirString as bool?) ?? false))
		{
			CqlInterval<CqlDateTime> a__ = null;
			var b__ = (a__ as CqlInterval<CqlDateTime>);
			var c__ = context.Operators;
			var d__ = c__.Message<CqlInterval<CqlDateTime>>(b__, "1", "Error", "Cannot compute an interval from a String value");

			return d__;
		}
        else if (((condition.Abatement is Age as bool?) ?? false))
		{
			var a__ = this.Patient();
			var b__ = a__.BirthDateElement;
			var c__ = FHIRHelpers_4_0_001.ToDate(b__);
			var d__ = condition.Abatement;
			var e__ = (d__ as Age);
			var f__ = (Quantity)e__;
			var g__ = FHIRHelpers_4_0_001.ToQuantity(f__);
			var h__ = context.Operators;
			var i__ = h__.Add(c__, g__);
			var k__ = a__.BirthDateElement;
			var l__ = FHIRHelpers_4_0_001.ToDate(k__);
			var n__ = (d__ as Age);
			var o__ = (Quantity)n__;
			var p__ = FHIRHelpers_4_0_001.ToQuantity(o__);
			var r__ = h__.Add(l__, p__);
			var t__ = h__.Quantity(1m, "year");
			var v__ = h__.Add(r__, t__);
			var x__ = h__.Interval(i__, v__, true, false);
			var y__ = x__.low;
			var aa__ = h__.ConvertDateToDateTime(y__);
			var ac__ = a__.BirthDateElement;
			var ad__ = FHIRHelpers_4_0_001.ToDate(ac__);
			var af__ = (d__ as Age);
			var ag__ = (Quantity)af__;
			var ah__ = FHIRHelpers_4_0_001.ToQuantity(ag__);
			var aj__ = h__.Add(ad__, ah__);
			var al__ = a__.BirthDateElement;
			var am__ = FHIRHelpers_4_0_001.ToDate(al__);
			var ao__ = (d__ as Age);
			var ap__ = (Quantity)ao__;
			var aq__ = FHIRHelpers_4_0_001.ToQuantity(ap__);
			var as__ = h__.Add(am__, aq__);
			var au__ = h__.Quantity(1m, "year");
			var aw__ = h__.Add(as__, au__);
			var ay__ = h__.Interval(aj__, aw__, true, false);
			var az__ = ay__.high;
			var bb__ = h__.ConvertDateToDateTime(az__);
			var bd__ = a__.BirthDateElement;
			var be__ = FHIRHelpers_4_0_001.ToDate(bd__);
			var bg__ = (d__ as Age);
			var bh__ = (Quantity)bg__;
			var bi__ = FHIRHelpers_4_0_001.ToQuantity(bh__);
			var bk__ = h__.Add(be__, bi__);
			var bm__ = a__.BirthDateElement;
			var bn__ = FHIRHelpers_4_0_001.ToDate(bm__);
			var bp__ = (d__ as Age);
			var bq__ = (Quantity)bp__;
			var br__ = FHIRHelpers_4_0_001.ToQuantity(bq__);
			var bt__ = h__.Add(bn__, br__);
			var bv__ = h__.Quantity(1m, "year");
			var bx__ = h__.Add(bt__, bv__);
			var bz__ = h__.Interval(bk__, bx__, true, false);
			var ca__ = bz__.lowClosed;
			var cc__ = a__.BirthDateElement;
			var cd__ = FHIRHelpers_4_0_001.ToDate(cc__);
			var cf__ = (d__ as Age);
			var cg__ = (Quantity)cf__;
			var ch__ = FHIRHelpers_4_0_001.ToQuantity(cg__);
			var cj__ = h__.Add(cd__, ch__);
			var cl__ = a__.BirthDateElement;
			var cm__ = FHIRHelpers_4_0_001.ToDate(cl__);
			var co__ = (d__ as Age);
			var cp__ = (Quantity)co__;
			var cq__ = FHIRHelpers_4_0_001.ToQuantity(cp__);
			var cs__ = h__.Add(cm__, cq__);
			var cu__ = h__.Quantity(1m, "year");
			var cw__ = h__.Add(cs__, cu__);
			var cy__ = h__.Interval(cj__, cw__, true, false);
			var cz__ = cy__.highClosed;
			var db__ = h__.Interval(aa__, bb__, ca__, cz__);

			return db__;
		}
        else if (((condition.Abatement is Range as bool?) ?? false))
		{
			var a__ = this.Patient();
			var b__ = a__.BirthDateElement;
			var c__ = FHIRHelpers_4_0_001.ToDate(b__);
			var d__ = condition.Abatement;
			var e__ = (d__ as Range);
			var f__ = e__.Low;
			var g__ = FHIRHelpers_4_0_001.ToQuantity(f__);
			var h__ = context.Operators;
			var i__ = h__.Add(c__, g__);
			var k__ = a__.BirthDateElement;
			var l__ = FHIRHelpers_4_0_001.ToDate(k__);
			var n__ = (d__ as Range);
			var o__ = n__.High;
			var p__ = FHIRHelpers_4_0_001.ToQuantity(o__);
			var r__ = h__.Add(l__, p__);
			var t__ = h__.Quantity(1m, "year");
			var v__ = h__.Add(r__, t__);
			var x__ = h__.Interval(i__, v__, true, false);
			var y__ = x__.low;
			var aa__ = h__.ConvertDateToDateTime(y__);
			var ac__ = a__.BirthDateElement;
			var ad__ = FHIRHelpers_4_0_001.ToDate(ac__);
			var af__ = (d__ as Range);
			var ag__ = af__.Low;
			var ah__ = FHIRHelpers_4_0_001.ToQuantity(ag__);
			var aj__ = h__.Add(ad__, ah__);
			var al__ = a__.BirthDateElement;
			var am__ = FHIRHelpers_4_0_001.ToDate(al__);
			var ao__ = (d__ as Range);
			var ap__ = ao__.High;
			var aq__ = FHIRHelpers_4_0_001.ToQuantity(ap__);
			var as__ = h__.Add(am__, aq__);
			var au__ = h__.Quantity(1m, "year");
			var aw__ = h__.Add(as__, au__);
			var ay__ = h__.Interval(aj__, aw__, true, false);
			var az__ = ay__.high;
			var bb__ = h__.ConvertDateToDateTime(az__);
			var bd__ = a__.BirthDateElement;
			var be__ = FHIRHelpers_4_0_001.ToDate(bd__);
			var bg__ = (d__ as Range);
			var bh__ = bg__.Low;
			var bi__ = FHIRHelpers_4_0_001.ToQuantity(bh__);
			var bk__ = h__.Add(be__, bi__);
			var bm__ = a__.BirthDateElement;
			var bn__ = FHIRHelpers_4_0_001.ToDate(bm__);
			var bp__ = (d__ as Range);
			var bq__ = bp__.High;
			var br__ = FHIRHelpers_4_0_001.ToQuantity(bq__);
			var bt__ = h__.Add(bn__, br__);
			var bv__ = h__.Quantity(1m, "year");
			var bx__ = h__.Add(bt__, bv__);
			var bz__ = h__.Interval(bk__, bx__, true, false);
			var ca__ = bz__.lowClosed;
			var cc__ = a__.BirthDateElement;
			var cd__ = FHIRHelpers_4_0_001.ToDate(cc__);
			var cf__ = (d__ as Range);
			var cg__ = cf__.Low;
			var ch__ = FHIRHelpers_4_0_001.ToQuantity(cg__);
			var cj__ = h__.Add(cd__, ch__);
			var cl__ = a__.BirthDateElement;
			var cm__ = FHIRHelpers_4_0_001.ToDate(cl__);
			var co__ = (d__ as Range);
			var cp__ = co__.High;
			var cq__ = FHIRHelpers_4_0_001.ToQuantity(cp__);
			var cs__ = h__.Add(cm__, cq__);
			var cu__ = h__.Quantity(1m, "year");
			var cw__ = h__.Add(cs__, cu__);
			var cy__ = h__.Interval(cj__, cw__, true, false);
			var cz__ = cy__.highClosed;
			var db__ = h__.Interval(aa__, bb__, ca__, cz__);

			return db__;
		}
        else if (((condition.Abatement is FhirBoolean as bool?) ?? false))
		{
			var a__ = condition.Onset;
			var b__ = this.Normalize_Interval(a__);
			var c__ = context.Operators;
			var d__ = c__.End(b__);
			var e__ = condition.RecordedDateElement;
			var f__ = FHIRHelpers_4_0_001.ToDateTime(e__);
			var h__ = c__.Interval(d__, f__, true, false);

			return h__;
		}
        else
		{
			CqlInterval<CqlDateTime> a__ = null;
			var b__ = (a__ as CqlInterval<CqlDateTime>);

			return b__;
		}
    }


    [CqlDeclaration("Prevalence Period")]
    public CqlInterval<CqlDateTime> Prevalence_Period(Condition condition)
    {
        if ((context.Operators.Or(context.Operators.Or(context.Operators.Equivalent(FHIRHelpers_4_0_001.ToConcept(condition.ClinicalStatus), context.Operators.ConvertCodeToConcept(this.active())), context.Operators.Equivalent(FHIRHelpers_4_0_001.ToConcept(condition.ClinicalStatus), context.Operators.ConvertCodeToConcept(this.recurrence()))), context.Operators.Equivalent(FHIRHelpers_4_0_001.ToConcept(condition.ClinicalStatus), context.Operators.ConvertCodeToConcept(this.relapse()))) ?? false))
		{
			var a__ = condition.Onset;
			var b__ = this.Normalize_Interval(a__);
			var c__ = context.Operators;
			var d__ = c__.Start(b__);
			var e__ = this.Normalize_Abatement(condition);
			var g__ = c__.End(e__);
			var i__ = c__.Interval(d__, g__, true, true);

			return i__;
		}
        else
		{
			var a__ = condition.Onset;
			var b__ = this.Normalize_Interval(a__);
			var c__ = context.Operators;
			var d__ = c__.Start(b__);
			var e__ = this.Normalize_Abatement(condition);
			var g__ = c__.End(e__);
			var i__ = c__.Interval(d__, g__, true, false);

			return i__;
		}
    }


    [CqlDeclaration("GetId")]
    public string GetId(string uri)
	{
		var a_ = context.Operators;
		var b_ = a_.Split(uri, "/");
		var d_ = a_.LastOfList<string>(b_);

		return d_;
	}


    [CqlDeclaration("EncounterDiagnosis")]
    public IEnumerable<Condition> EncounterDiagnosis(Encounter Encounter)
	{
		var a_ = Encounter.Diagnosis;
		var b_ = (a_ as IEnumerable<Encounter.DiagnosisComponent>);
		var c_ = (Encounter.DiagnosisComponent D) =>
		{
			var f_ = context.DataRetriever;
			var g_ = f_.RetrieveByValueSet<Condition>(null, null);
			var h_ = (Condition C) =>
			{
				var m_ = C.IdElement;
				var n_ = new CallStackEntry("ToString", null, null);
				var o_ = context.Deeper(n_);
				var p_ = o_.Operators;
				var q_ = p_.TypeConverter;
				var r_ = q_.Convert<string>(m_);
				var s_ = D.Condition;
				var t_ = s_.ReferenceElement;
				var v_ = context.Deeper(n_);
				var w_ = v_.Operators;
				var x_ = w_.TypeConverter;
				var y_ = x_.Convert<string>(t_);
				var z_ = this.GetId(y_);
				var aa_ = context.Operators;
				var ab_ = aa_.Equal(r_, z_);

				return ab_;
			};
			var i_ = context.Operators;
			var j_ = i_.WhereOrNull<Condition>(g_, h_);
			var l_ = i_.SingleOrNull<Condition>(j_);

			return l_;
		};
		var d_ = context.Operators;
		var e_ = d_.SelectOrNull<Encounter.DiagnosisComponent, Condition>(b_, c_);

		return e_;
	}


    [CqlDeclaration("GetCondition")]
    public Condition GetCondition(ResourceReference reference)
	{
		var a_ = context.DataRetriever;
		var b_ = a_.RetrieveByValueSet<Condition>(null, null);
		var c_ = (Condition C) =>
		{
			var h_ = C.IdElement;
			var i_ = new CallStackEntry("ToString", null, null);
			var j_ = context.Deeper(i_);
			var k_ = j_.Operators;
			var l_ = k_.TypeConverter;
			var m_ = l_.Convert<string>(h_);
			var n_ = reference.ReferenceElement;
			var p_ = context.Deeper(i_);
			var q_ = p_.Operators;
			var r_ = q_.TypeConverter;
			var s_ = r_.Convert<string>(n_);
			var t_ = this.GetId(s_);
			var u_ = context.Operators;
			var v_ = u_.Equal(m_, t_);

			return v_;
		};
		var d_ = context.Operators;
		var e_ = d_.WhereOrNull<Condition>(b_, c_);
		var g_ = d_.SingleOrNull<Condition>(e_);

		return g_;
	}


    [CqlDeclaration("GetExtensions")]
    public IEnumerable<Extension> GetExtensions(DomainResource domainResource, string url)
	{
		var a_ = domainResource.Extension;
		var b_ = (a_ as IEnumerable<Extension>);
		var c_ = (Extension E) =>
		{
			var i_ = E.Url;
			var j_ = context.Operators;
			var k_ = j_.TypeConverter;
			var l_ = k_.Convert<FhirUri>(i_);
			var m_ = new CallStackEntry("ToString", null, null);
			var n_ = context.Deeper(m_);
			var o_ = n_.Operators;
			var p_ = o_.TypeConverter;
			var q_ = p_.Convert<string>(l_);
			var s_ = j_.Concatenate("http://hl7.org/fhir/us/qicore/StructureDefinition/", url);
			var u_ = j_.Equal(q_, s_);

			return u_;
		};
		var d_ = context.Operators;
		var e_ = d_.WhereOrNull<Extension>(b_, c_);
		var f_ = (Extension E) => E;
		var h_ = d_.SelectOrNull<Extension, Extension>(e_, f_);

		return h_;
	}


    [CqlDeclaration("GetExtensions")]
    public IEnumerable<Extension> GetExtensions(Element element, string url)
	{
		var a_ = element.Extension;
		var b_ = (a_ as IEnumerable<Extension>);
		var c_ = (Extension E) =>
		{
			var i_ = E.Url;
			var j_ = context.Operators;
			var k_ = j_.TypeConverter;
			var l_ = k_.Convert<FhirUri>(i_);
			var m_ = new CallStackEntry("ToString", null, null);
			var n_ = context.Deeper(m_);
			var o_ = n_.Operators;
			var p_ = o_.TypeConverter;
			var q_ = p_.Convert<string>(l_);
			var s_ = j_.Equal(q_, url);

			return s_;
		};
		var d_ = context.Operators;
		var e_ = d_.WhereOrNull<Extension>(b_, c_);
		var f_ = (Extension E) => E;
		var h_ = d_.SelectOrNull<Extension, Extension>(e_, f_);

		return h_;
	}


    [CqlDeclaration("GetExtension")]
    public Extension GetExtension(DomainResource domainResource, string url)
	{
		var a_ = this.GetExtensions(domainResource, url);
		var b_ = context.Operators;
		var c_ = b_.SingleOrNull<Extension>(a_);

		return c_;
	}


    [CqlDeclaration("GetExtension")]
    public Extension GetExtension(Element element, string url)
	{
		var a_ = this.GetExtensions(element, url);
		var b_ = context.Operators;
		var c_ = b_.SingleOrNull<Extension>(a_);

		return c_;
	}


    [CqlDeclaration("PresentOnAdmissionIndicator")]
    public CodeableConcept PresentOnAdmissionIndicator(Element element)
	{
		var a_ = this.GetExtension(element, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");
		var b_ = a_.Value;
		var c_ = (b_ as CodeableConcept);

		return c_;
	}


    [CqlDeclaration("PrincipalDiagnosis")]
    public Condition PrincipalDiagnosis(Encounter Encounter)
	{
		var a_ = Encounter.Diagnosis;
		var b_ = (a_ as IEnumerable<Encounter.DiagnosisComponent>);
		var c_ = (Encounter.DiagnosisComponent D) =>
		{
			var n_ = D.RankElement;
			var o_ = context.Operators;
			var p_ = o_.TypeConverter;
			var q_ = p_.Convert<Integer>(n_);
			var r_ = FHIRHelpers_4_0_001.ToInteger(q_);
			var s_ = r_;
			var t_ = (int?)1;
			var u_ = t_;
			var w_ = o_.Equal(s_, u_);

			return w_;
		};
		var d_ = context.Operators;
		var e_ = d_.WhereOrNull<Encounter.DiagnosisComponent>(b_, c_);
		var g_ = d_.SingleOrNull<Encounter.DiagnosisComponent>(e_);
		var h_ = new Encounter.DiagnosisComponent[]
		{
			g_,
		};
		var i_ = (Encounter.DiagnosisComponent PD) =>
		{
			var x_ = context.DataRetriever;
			var y_ = x_.RetrieveByValueSet<Condition>(null, null);
			var z_ = (Condition C) =>
			{
				var ae_ = C.IdElement;
				var af_ = new CallStackEntry("ToString", null, null);
				var ag_ = context.Deeper(af_);
				var ah_ = ag_.Operators;
				var ai_ = ah_.TypeConverter;
				var aj_ = ai_.Convert<string>(ae_);
				var ak_ = PD.Condition;
				var al_ = ak_.ReferenceElement;
				var an_ = context.Deeper(af_);
				var ao_ = an_.Operators;
				var ap_ = ao_.TypeConverter;
				var aq_ = ap_.Convert<string>(al_);
				var ar_ = this.GetId(aq_);
				var as_ = context.Operators;
				var at_ = as_.Equal(aj_, ar_);

				return at_;
			};
			var aa_ = context.Operators;
			var ab_ = aa_.WhereOrNull<Condition>(y_, z_);
			var ad_ = aa_.SingleOrNull<Condition>(ab_);

			return ad_;
		};
		var k_ = d_.SelectOrNull<Encounter.DiagnosisComponent, Condition>(h_, i_);
		var m_ = d_.SingleOrNull<Condition>(k_);

		return m_;
	}


    [CqlDeclaration("GetLocation")]
    public Location GetLocation(ResourceReference reference)
	{
		var a_ = context.DataRetriever;
		var b_ = a_.RetrieveByValueSet<Location>(null, null);
		var c_ = (Location L) =>
		{
			var h_ = L.IdElement;
			var i_ = new CallStackEntry("ToString", null, null);
			var j_ = context.Deeper(i_);
			var k_ = j_.Operators;
			var l_ = k_.TypeConverter;
			var m_ = l_.Convert<string>(h_);
			var n_ = reference.ReferenceElement;
			var p_ = context.Deeper(i_);
			var q_ = p_.Operators;
			var r_ = q_.TypeConverter;
			var s_ = r_.Convert<string>(n_);
			var t_ = this.GetId(s_);
			var u_ = context.Operators;
			var v_ = u_.Equal(m_, t_);

			return v_;
		};
		var d_ = context.Operators;
		var e_ = d_.WhereOrNull<Location>(b_, c_);
		var g_ = d_.SingleOrNull<Location>(e_);

		return g_;
	}


    [CqlDeclaration("GetBaseExtensions")]
    public IEnumerable<Extension> GetBaseExtensions(DomainResource domainResource, string url)
	{
		var a_ = domainResource.Extension;
		var b_ = (a_ as IEnumerable<Extension>);
		var c_ = (Extension E) =>
		{
			var i_ = E.Url;
			var j_ = context.Operators;
			var k_ = j_.TypeConverter;
			var l_ = k_.Convert<FhirUri>(i_);
			var m_ = new CallStackEntry("ToString", null, null);
			var n_ = context.Deeper(m_);
			var o_ = n_.Operators;
			var p_ = o_.TypeConverter;
			var q_ = p_.Convert<string>(l_);
			var s_ = j_.Concatenate("http://hl7.org/fhir/StructureDefinition/", url);
			var u_ = j_.Equal(q_, s_);

			return u_;
		};
		var d_ = context.Operators;
		var e_ = d_.WhereOrNull<Extension>(b_, c_);
		var f_ = (Extension E) => E;
		var h_ = d_.SelectOrNull<Extension, Extension>(e_, f_);

		return h_;
	}


    [CqlDeclaration("GetBaseExtension")]
    public Extension GetBaseExtension(DomainResource domainResource, string url)
	{
		var a_ = this.GetBaseExtensions(domainResource, url);
		var b_ = context.Operators;
		var c_ = b_.SingleOrNull<Extension>(a_);

		return c_;
	}


    [CqlDeclaration("BaseExtensions")]
    public IEnumerable<Extension> BaseExtensions(Element element, string id)
	{
		var a_ = element.Extension;
		var b_ = (a_ as IEnumerable<Extension>);
		var c_ = (Extension E) =>
		{
			var i_ = E.Url;
			var j_ = context.Operators;
			var k_ = j_.TypeConverter;
			var l_ = k_.Convert<FhirUri>(i_);
			var m_ = new CallStackEntry("ToString", null, null);
			var n_ = context.Deeper(m_);
			var o_ = n_.Operators;
			var p_ = o_.TypeConverter;
			var q_ = p_.Convert<string>(l_);
			var s_ = j_.Concatenate("http://hl7.org/fhir/StructureDefinition/", id);
			var u_ = j_.Equal(q_, s_);

			return u_;
		};
		var d_ = context.Operators;
		var e_ = d_.WhereOrNull<Extension>(b_, c_);
		var f_ = (Extension E) => E;
		var h_ = d_.SelectOrNull<Extension, Extension>(e_, f_);

		return h_;
	}


    [CqlDeclaration("BaseExtension")]
    public Extension BaseExtension(Element element, string id)
	{
		var a_ = this.BaseExtensions(element, id);
		var b_ = context.Operators;
		var c_ = b_.SingleOrNull<Extension>(a_);

		return c_;
	}


    [CqlDeclaration("GetMedicationCode")]
    public CodeableConcept GetMedicationCode(MedicationRequest request)
    {
        if (((request.Medication is CodeableConcept as bool?) ?? false))
		{
			var a__ = request.Medication;
			var b__ = (a__ as CodeableConcept);

			return b__;
		}
        else
		{
			var a__ = context.DataRetriever;
			var b__ = a__.RetrieveByValueSet<Medication>(null, null);
			var c__ = (Medication M) =>
			{
				var i__ = M.IdElement;
				var j__ = new CallStackEntry("ToString", null, null);
				var k__ = context.Deeper(j__);
				var l__ = k__.Operators;
				var m__ = l__.TypeConverter;
				var n__ = m__.Convert<string>(i__);
				var o__ = request.Medication;
				var p__ = (o__ as ResourceReference);
				var q__ = p__.ReferenceElement;
				var s__ = context.Deeper(j__);
				var t__ = s__.Operators;
				var u__ = t__.TypeConverter;
				var v__ = u__.Convert<string>(q__);
				var w__ = this.GetId(v__);
				var x__ = context.Operators;
				var y__ = x__.Equal(n__, w__);

				return y__;
			};
			var d__ = context.Operators;
			var e__ = d__.WhereOrNull<Medication>(b__, c__);
			var g__ = d__.SingleOrNull<Medication>(e__);
			var h__ = g__.Code;

			return h__;
		}
    }


    [CqlDeclaration("HasStart")]
    public bool? HasStart(CqlInterval<CqlDateTime> period)
	{
		var a_ = context.Operators;
		var b_ = a_.Start(period);
		var c_ = (b_ == null);
		var d_ = (bool?)c_;
		var f_ = a_.Start(period);
		var h_ = a_.Minimum<CqlDateTime>();
		var j_ = a_.Equal(f_, h_);
		var l_ = a_.Or(d_, j_);
		var n_ = a_.Not(l_);

		return n_;
	}


    [CqlDeclaration("HasEnd")]
    public bool? HasEnd(CqlInterval<CqlDateTime> period)
	{
		var a_ = context.Operators;
		var b_ = a_.End(period);
		var c_ = (b_ == null);
		var d_ = (bool?)c_;
		var f_ = a_.End(period);
		var h_ = a_.Maximum<CqlDateTime>();
		var j_ = a_.Equal(f_, h_);
		var l_ = a_.Or(d_, j_);
		var n_ = a_.Not(l_);

		return n_;
	}


    [CqlDeclaration("Latest")]
    public CqlDateTime Latest(object choice)
	{
		var a_ = this.Normalize_Interval(choice);
		var b_ = new CqlInterval<CqlDateTime>[]
		{
			a_,
		};
		var c_ = (CqlInterval<CqlDateTime> period) => (((this.HasEnd(period) ?? false))
			? (context.Operators.End(period))
			: (context.Operators.Start(period)))
;
		var d_ = context.Operators;
		var e_ = d_.SelectOrNull<CqlInterval<CqlDateTime>, CqlDateTime>(b_, c_);
		var g_ = d_.SingleOrNull<CqlDateTime>(e_);

		return g_;
	}


    [CqlDeclaration("Earliest")]
    public CqlDateTime Earliest(object choice)
	{
		var a_ = this.Normalize_Interval(choice);
		var b_ = new CqlInterval<CqlDateTime>[]
		{
			a_,
		};
		var c_ = (CqlInterval<CqlDateTime> period) => (((this.HasStart(period) ?? false))
			? (context.Operators.Start(period))
			: (context.Operators.End(period)))
;
		var d_ = context.Operators;
		var e_ = d_.SelectOrNull<CqlInterval<CqlDateTime>, CqlDateTime>(b_, c_);
		var g_ = d_.SingleOrNull<CqlDateTime>(e_);

		return g_;
	}


}