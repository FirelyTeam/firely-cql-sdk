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
    public CqlValueSet Emergency_Department_Visit() => __Emergency_Department_Visit.Value;

    private CqlValueSet Encounter_Inpatient_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
    public CqlValueSet Encounter_Inpatient() => __Encounter_Inpatient.Value;

    private CqlValueSet Observation_Services_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", null);

    [CqlDeclaration("Observation Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143")]
    public CqlValueSet Observation_Services() => __Observation_Services.Value;

    private CqlValueSet Present_on_Admission_or_Clinically_Undetermined_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.197", null);

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
		var a_ = context.Operators;
		var b_ = a_.ConvertIntegerToDecimal(default);
		var d_ = a_.DateTime((int?)2019, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, b_);
		var f_ = a_.ConvertIntegerToDecimal(default);
		var h_ = a_.DateTime((int?)2020, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, f_);
		var j_ = a_.Interval(d_, h_, true, false);
		var k_ = context.ResolveParameter("MATGlobalCommonFunctionsFHIR4-6.1.000", "Measurement Period", j_);

		return (CqlInterval<CqlDateTime>)k_;
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
		bool? d_(Encounter EncounterInpatient)
		{
			var g_ = EncounterInpatient?.StatusElement;
			var h_ = new CallStackEntry("ToString", null, null);
			var i_ = context.Deeper(h_);
			var j_ = i_.Operators;
			var k_ = j_.TypeConverter;
			var l_ = k_.Convert<string>(g_);
			var m_ = context.Operators;
			var n_ = m_.Equal(l_, "finished");
			var o_ = EncounterInpatient?.Period;
			var p_ = FHIRHelpers_4_0_001.ToInterval(o_);
			var q_ = this.LengthInDays(p_);
			var s_ = m_.LessOrEqual(q_, (int?)120);
			var u_ = m_.And(n_, s_);
			var w_ = FHIRHelpers_4_0_001.ToInterval(o_);
			var y_ = m_.End(w_);
			var z_ = this.Measurement_Period();
			var ab_ = m_.ElementInInterval<CqlDateTime>(y_, z_, null);
			var ad_ = m_.And(u_, ab_);

			return ad_;
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
		bool? d_(Encounter EDVisit)
		{
			var l_ = EDVisit?.StatusElement;
			var m_ = new CallStackEntry("ToString", null, null);
			var n_ = context.Deeper(m_);
			var o_ = n_.Operators;
			var p_ = o_.TypeConverter;
			var q_ = p_.Convert<string>(l_);
			var r_ = context.Operators;
			var s_ = r_.Equal(q_, "finished");
			var t_ = EDVisit?.Period;
			var u_ = FHIRHelpers_4_0_001.ToInterval(t_);
			var w_ = r_.End(u_);
			var x_ = TheEncounter?.Period;
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
			var as_ = r_.Not((bool?)(aq_ is null));
			var au_ = r_.And(am_, as_);
			var aw_ = r_.And(s_, au_);

			return aw_;
		};
		var e_ = context.Operators;
		var f_ = e_.WhereOrNull<Encounter>(c_, d_);
		object g_(Encounter @this)
		{
			var ax_ = @this?.Period;
			var ay_ = FHIRHelpers_4_0_001.ToInterval(ax_);
			var az_ = context.Operators;
			var ba_ = az_.End(ay_);

			return ba_;
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
		CqlInterval<CqlDateTime> c_(Encounter X) => (((X is null))
			? (FHIRHelpers_4_0_001.ToInterval(TheEncounter?.Period))
			: (context.Operators.Interval(context.Operators.Start(FHIRHelpers_4_0_001.ToInterval(X?.Period)), context.Operators.End(FHIRHelpers_4_0_001.ToInterval(TheEncounter?.Period)), true, true)));
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
		IEnumerable<Encounter.LocationComponent> c_(Encounter EDEncounter) => (((EDEncounter is null))
			? ((TheEncounter?.Location as IEnumerable<Encounter.LocationComponent>))
			: (context.Operators.FlattenList<Encounter.LocationComponent>((new IEnumerable<Encounter.LocationComponent>[]
					{
						(EDEncounter?.Location as IEnumerable<Encounter.LocationComponent>),
						(TheEncounter?.Location as IEnumerable<Encounter.LocationComponent>),
					} as IEnumerable<IEnumerable<Encounter.LocationComponent>>))));
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
		var a_ = TheEncounter?.Period;
		var b_ = FHIRHelpers_4_0_001.ToInterval(a_);
		var c_ = context.Operators;
		var d_ = c_.End(b_);

		return d_;
	}


    [CqlDeclaration("Hospital Arrival Time")]
    public CqlDateTime Hospital_Arrival_Time(Encounter TheEncounter)
	{
		var a_ = this.Hospitalization_Locations(TheEncounter);
		object b_(Encounter.LocationComponent @this)
		{
			var k_ = @this?.Period;
			var l_ = FHIRHelpers_4_0_001.ToInterval(k_);
			var m_ = context.Operators;
			var n_ = m_.Start(l_);

			return n_;
		};
		var c_ = context.Operators;
		var d_ = c_.ListSortBy<Encounter.LocationComponent>(a_, b_, System.ComponentModel.ListSortDirection.Ascending);
		var f_ = c_.FirstOfList<Encounter.LocationComponent>(d_);
		var g_ = f_?.Period;
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
		CqlInterval<CqlDateTime> b_(Encounter Visit)
		{
			var g_ = this.Emergency_Department_Visit();
			var h_ = context.DataRetriever;
			var i_ = h_.RetrieveByValueSet<Encounter>(g_, null);
			bool? j_(Encounter LastED)
			{
				var aw_ = LastED?.Period;
				var ax_ = FHIRHelpers_4_0_001.ToInterval(aw_);
				var ay_ = context.Operators;
				var az_ = ay_.End(ax_);
				var ba_ = this.Observation_Services();
				var bb_ = context.DataRetriever;
				var bc_ = bb_.RetrieveByValueSet<Encounter>(ba_, null);
				bool? bd_(Encounter LastObs)
				{
					var du_ = LastObs?.Period;
					var dv_ = FHIRHelpers_4_0_001.ToInterval(du_);
					var dw_ = context.Operators;
					var dx_ = dw_.End(dv_);
					var dy_ = Visit?.Period;
					var dz_ = FHIRHelpers_4_0_001.ToInterval(dy_);
					var eb_ = dw_.Start(dz_);
					var ed_ = dw_.Quantity(1m, "hour");
					var ef_ = dw_.Subtract(eb_, ed_);
					var eh_ = FHIRHelpers_4_0_001.ToInterval(dy_);
					var ej_ = dw_.Start(eh_);
					var el_ = dw_.Interval(ef_, ej_, true, true);
					var en_ = dw_.ElementInInterval<CqlDateTime>(dx_, el_, null);
					var ep_ = FHIRHelpers_4_0_001.ToInterval(dy_);
					var er_ = dw_.Start(ep_);
					var et_ = dw_.Not((bool?)(er_ is null));
					var ev_ = dw_.And(en_, et_);

					return ev_;
				};
				var bf_ = ay_.WhereOrNull<Encounter>(bc_, bd_);
				object bg_(Encounter @this)
				{
					var ew_ = @this?.Period;
					var ex_ = FHIRHelpers_4_0_001.ToInterval(ew_);
					var ey_ = context.Operators;
					var ez_ = ey_.End(ex_);

					return ez_;
				};
				var bi_ = ay_.ListSortBy<Encounter>(bf_, bg_, System.ComponentModel.ListSortDirection.Ascending);
				var bk_ = ay_.LastOfList<Encounter>(bi_);
				var bl_ = bk_?.Period;
				var bm_ = FHIRHelpers_4_0_001.ToInterval(bl_);
				var bo_ = ay_.Start(bm_);
				var bp_ = Visit?.Period;
				var bq_ = FHIRHelpers_4_0_001.ToInterval(bp_);
				var bs_ = ay_.Start(bq_);
				var bt_ = (bo_ ?? bs_);
				var bv_ = ay_.Quantity(1m, "hour");
				var bx_ = ay_.Subtract(bt_, bv_);
				var ca_ = bb_.RetrieveByValueSet<Encounter>(ba_, null);
				bool? cb_(Encounter LastObs)
				{
					var fa_ = LastObs?.Period;
					var fb_ = FHIRHelpers_4_0_001.ToInterval(fa_);
					var fc_ = context.Operators;
					var fd_ = fc_.End(fb_);
					var fe_ = Visit?.Period;
					var ff_ = FHIRHelpers_4_0_001.ToInterval(fe_);
					var fh_ = fc_.Start(ff_);
					var fj_ = fc_.Quantity(1m, "hour");
					var fl_ = fc_.Subtract(fh_, fj_);
					var fn_ = FHIRHelpers_4_0_001.ToInterval(fe_);
					var fp_ = fc_.Start(fn_);
					var fr_ = fc_.Interval(fl_, fp_, true, true);
					var ft_ = fc_.ElementInInterval<CqlDateTime>(fd_, fr_, null);
					var fv_ = FHIRHelpers_4_0_001.ToInterval(fe_);
					var fx_ = fc_.Start(fv_);
					var fz_ = fc_.Not((bool?)(fx_ is null));
					var gb_ = fc_.And(ft_, fz_);

					return gb_;
				};
				var cd_ = ay_.WhereOrNull<Encounter>(ca_, cb_);
				object ce_(Encounter @this)
				{
					var gc_ = @this?.Period;
					var gd_ = FHIRHelpers_4_0_001.ToInterval(gc_);
					var ge_ = context.Operators;
					var gf_ = ge_.End(gd_);

					return gf_;
				};
				var cg_ = ay_.ListSortBy<Encounter>(cd_, ce_, System.ComponentModel.ListSortDirection.Ascending);
				var ci_ = ay_.LastOfList<Encounter>(cg_);
				var cj_ = ci_?.Period;
				var ck_ = FHIRHelpers_4_0_001.ToInterval(cj_);
				var cm_ = ay_.Start(ck_);
				var co_ = FHIRHelpers_4_0_001.ToInterval(bp_);
				var cq_ = ay_.Start(co_);
				var cr_ = (cm_ ?? cq_);
				var ct_ = ay_.Interval(bx_, cr_, true, true);
				var cv_ = ay_.ElementInInterval<CqlDateTime>(az_, ct_, null);
				var cy_ = bb_.RetrieveByValueSet<Encounter>(ba_, null);
				bool? cz_(Encounter LastObs)
				{
					var gg_ = LastObs?.Period;
					var gh_ = FHIRHelpers_4_0_001.ToInterval(gg_);
					var gi_ = context.Operators;
					var gj_ = gi_.End(gh_);
					var gk_ = Visit?.Period;
					var gl_ = FHIRHelpers_4_0_001.ToInterval(gk_);
					var gn_ = gi_.Start(gl_);
					var gp_ = gi_.Quantity(1m, "hour");
					var gr_ = gi_.Subtract(gn_, gp_);
					var gt_ = FHIRHelpers_4_0_001.ToInterval(gk_);
					var gv_ = gi_.Start(gt_);
					var gx_ = gi_.Interval(gr_, gv_, true, true);
					var gz_ = gi_.ElementInInterval<CqlDateTime>(gj_, gx_, null);
					var hb_ = FHIRHelpers_4_0_001.ToInterval(gk_);
					var hd_ = gi_.Start(hb_);
					var hf_ = gi_.Not((bool?)(hd_ is null));
					var hh_ = gi_.And(gz_, hf_);

					return hh_;
				};
				var db_ = ay_.WhereOrNull<Encounter>(cy_, cz_);
				object dc_(Encounter @this)
				{
					var hi_ = @this?.Period;
					var hj_ = FHIRHelpers_4_0_001.ToInterval(hi_);
					var hk_ = context.Operators;
					var hl_ = hk_.End(hj_);

					return hl_;
				};
				var de_ = ay_.ListSortBy<Encounter>(db_, dc_, System.ComponentModel.ListSortDirection.Ascending);
				var dg_ = ay_.LastOfList<Encounter>(de_);
				var dh_ = dg_?.Period;
				var di_ = FHIRHelpers_4_0_001.ToInterval(dh_);
				var dk_ = ay_.Start(di_);
				var dm_ = FHIRHelpers_4_0_001.ToInterval(bp_);
				var do_ = ay_.Start(dm_);
				var dp_ = (dk_ ?? do_);
				var dr_ = ay_.Not((bool?)(dp_ is null));
				var dt_ = ay_.And(cv_, dr_);

				return dt_;
			};
			var k_ = context.Operators;
			var l_ = k_.WhereOrNull<Encounter>(i_, j_);
			object m_(Encounter @this)
			{
				var hm_ = @this?.Period;
				var hn_ = FHIRHelpers_4_0_001.ToInterval(hm_);
				var ho_ = context.Operators;
				var hp_ = ho_.End(hn_);

				return hp_;
			};
			var o_ = k_.ListSortBy<Encounter>(l_, m_, System.ComponentModel.ListSortDirection.Ascending);
			var q_ = k_.LastOfList<Encounter>(o_);
			var r_ = q_?.Period;
			var s_ = FHIRHelpers_4_0_001.ToInterval(r_);
			var u_ = k_.Start(s_);
			var v_ = this.Observation_Services();
			var x_ = h_.RetrieveByValueSet<Encounter>(v_, null);
			bool? y_(Encounter LastObs)
			{
				var hq_ = LastObs?.Period;
				var hr_ = FHIRHelpers_4_0_001.ToInterval(hq_);
				var hs_ = context.Operators;
				var ht_ = hs_.End(hr_);
				var hu_ = Visit?.Period;
				var hv_ = FHIRHelpers_4_0_001.ToInterval(hu_);
				var hx_ = hs_.Start(hv_);
				var hz_ = hs_.Quantity(1m, "hour");
				var ib_ = hs_.Subtract(hx_, hz_);
				var id_ = FHIRHelpers_4_0_001.ToInterval(hu_);
				var if_ = hs_.Start(id_);
				var ih_ = hs_.Interval(ib_, if_, true, true);
				var ij_ = hs_.ElementInInterval<CqlDateTime>(ht_, ih_, null);
				var il_ = FHIRHelpers_4_0_001.ToInterval(hu_);
				var in_ = hs_.Start(il_);
				var ip_ = hs_.Not((bool?)(in_ is null));
				var ir_ = hs_.And(ij_, ip_);

				return ir_;
			};
			var aa_ = k_.WhereOrNull<Encounter>(x_, y_);
			object ab_(Encounter @this)
			{
				var is_ = @this?.Period;
				var it_ = FHIRHelpers_4_0_001.ToInterval(is_);
				var iu_ = context.Operators;
				var iv_ = iu_.End(it_);

				return iv_;
			};
			var ad_ = k_.ListSortBy<Encounter>(aa_, ab_, System.ComponentModel.ListSortDirection.Ascending);
			var af_ = k_.LastOfList<Encounter>(ad_);
			var ag_ = af_?.Period;
			var ah_ = FHIRHelpers_4_0_001.ToInterval(ag_);
			var aj_ = k_.Start(ah_);
			var ak_ = Visit?.Period;
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
		CqlInterval<CqlDateTime> a_()
		{
			if (((choice is FhirDateTime as bool?) ?? false))
			{
				var b_ = FHIRHelpers_4_0_001.ToDateTime((choice as FhirDateTime));
				var d_ = context.Operators;
				var e_ = d_.Interval(b_, b_, true, true);

				return e_;
			}
			else if (((choice is Period as bool?) ?? false))
			{
				var f_ = FHIRHelpers_4_0_001.ToInterval((choice as Period));

				return f_;
			}
			else if (((choice is Instant as bool?) ?? false))
			{
				var g_ = FHIRHelpers_4_0_001.ToDateTime((choice as Instant));
				var i_ = context.Operators;
				var j_ = i_.Interval(g_, g_, true, true);

				return j_;
			}
			else if (((choice is Age as bool?) ?? false))
			{
				var k_ = this.Patient();
				var l_ = k_?.BirthDateElement;
				var m_ = FHIRHelpers_4_0_001.ToDate(l_);
				var n_ = FHIRHelpers_4_0_001.ToQuantity((Quantity)(choice as Age));
				var o_ = context.Operators;
				var p_ = o_.Add(m_, n_);
				var r_ = k_?.BirthDateElement;
				var s_ = FHIRHelpers_4_0_001.ToDate(r_);
				var v_ = o_.Add(s_, n_);
				var x_ = o_.Quantity(1m, "year");
				var z_ = o_.Add(v_, x_);
				var ab_ = o_.Interval(p_, z_, true, false);
				var ac_ = ab_?.low;
				var ae_ = o_.ConvertDateToDateTime(ac_);
				var ag_ = k_?.BirthDateElement;
				var ah_ = FHIRHelpers_4_0_001.ToDate(ag_);
				var ak_ = o_.Add(ah_, n_);
				var am_ = k_?.BirthDateElement;
				var an_ = FHIRHelpers_4_0_001.ToDate(am_);
				var aq_ = o_.Add(an_, n_);
				var as_ = o_.Quantity(1m, "year");
				var au_ = o_.Add(aq_, as_);
				var aw_ = o_.Interval(ak_, au_, true, false);
				var ax_ = aw_?.high;
				var az_ = o_.ConvertDateToDateTime(ax_);
				var bb_ = k_?.BirthDateElement;
				var bc_ = FHIRHelpers_4_0_001.ToDate(bb_);
				var bf_ = o_.Add(bc_, n_);
				var bh_ = k_?.BirthDateElement;
				var bi_ = FHIRHelpers_4_0_001.ToDate(bh_);
				var bl_ = o_.Add(bi_, n_);
				var bn_ = o_.Quantity(1m, "year");
				var bp_ = o_.Add(bl_, bn_);
				var br_ = o_.Interval(bf_, bp_, true, false);
				var bs_ = br_?.lowClosed;
				var bu_ = k_?.BirthDateElement;
				var bv_ = FHIRHelpers_4_0_001.ToDate(bu_);
				var by_ = o_.Add(bv_, n_);
				var ca_ = k_?.BirthDateElement;
				var cb_ = FHIRHelpers_4_0_001.ToDate(ca_);
				var ce_ = o_.Add(cb_, n_);
				var cg_ = o_.Quantity(1m, "year");
				var ci_ = o_.Add(ce_, cg_);
				var ck_ = o_.Interval(by_, ci_, true, false);
				var cl_ = ck_?.highClosed;
				var cn_ = o_.Interval(ae_, az_, bs_, cl_);

				return cn_;
			}
			else if (((choice is Range as bool?) ?? false))
			{
				var co_ = this.Patient();
				var cp_ = co_?.BirthDateElement;
				var cq_ = FHIRHelpers_4_0_001.ToDate(cp_);
				var cr_ = (choice as Range)?.Low;
				var cs_ = FHIRHelpers_4_0_001.ToQuantity(cr_);
				var ct_ = context.Operators;
				var cu_ = ct_.Add(cq_, cs_);
				var cw_ = co_?.BirthDateElement;
				var cx_ = FHIRHelpers_4_0_001.ToDate(cw_);
				var cy_ = (choice as Range)?.High;
				var cz_ = FHIRHelpers_4_0_001.ToQuantity(cy_);
				var db_ = ct_.Add(cx_, cz_);
				var dd_ = ct_.Quantity(1m, "year");
				var df_ = ct_.Add(db_, dd_);
				var dh_ = ct_.Interval(cu_, df_, true, false);
				var di_ = dh_?.low;
				var dk_ = ct_.ConvertDateToDateTime(di_);
				var dm_ = co_?.BirthDateElement;
				var dn_ = FHIRHelpers_4_0_001.ToDate(dm_);
				var dp_ = FHIRHelpers_4_0_001.ToQuantity(cr_);
				var dr_ = ct_.Add(dn_, dp_);
				var dt_ = co_?.BirthDateElement;
				var du_ = FHIRHelpers_4_0_001.ToDate(dt_);
				var dw_ = FHIRHelpers_4_0_001.ToQuantity(cy_);
				var dy_ = ct_.Add(du_, dw_);
				var ea_ = ct_.Quantity(1m, "year");
				var ec_ = ct_.Add(dy_, ea_);
				var ee_ = ct_.Interval(dr_, ec_, true, false);
				var ef_ = ee_?.high;
				var eh_ = ct_.ConvertDateToDateTime(ef_);
				var ej_ = co_?.BirthDateElement;
				var ek_ = FHIRHelpers_4_0_001.ToDate(ej_);
				var em_ = FHIRHelpers_4_0_001.ToQuantity(cr_);
				var eo_ = ct_.Add(ek_, em_);
				var eq_ = co_?.BirthDateElement;
				var er_ = FHIRHelpers_4_0_001.ToDate(eq_);
				var et_ = FHIRHelpers_4_0_001.ToQuantity(cy_);
				var ev_ = ct_.Add(er_, et_);
				var ex_ = ct_.Quantity(1m, "year");
				var ez_ = ct_.Add(ev_, ex_);
				var fb_ = ct_.Interval(eo_, ez_, true, false);
				var fc_ = fb_?.lowClosed;
				var fe_ = co_?.BirthDateElement;
				var ff_ = FHIRHelpers_4_0_001.ToDate(fe_);
				var fh_ = FHIRHelpers_4_0_001.ToQuantity(cr_);
				var fj_ = ct_.Add(ff_, fh_);
				var fl_ = co_?.BirthDateElement;
				var fm_ = FHIRHelpers_4_0_001.ToDate(fl_);
				var fo_ = FHIRHelpers_4_0_001.ToQuantity(cy_);
				var fq_ = ct_.Add(fm_, fo_);
				var fs_ = ct_.Quantity(1m, "year");
				var fu_ = ct_.Add(fq_, fs_);
				var fw_ = ct_.Interval(fj_, fu_, true, false);
				var fx_ = fw_?.highClosed;
				var fz_ = ct_.Interval(dk_, eh_, fc_, fx_);

				return fz_;
			}
			else if (((choice is Timing as bool?) ?? false))
			{
				CqlInterval<CqlDateTime> ga_ = null;
				var gb_ = context.Operators;
				var gc_ = gb_.Message<CqlInterval<CqlDateTime>>((ga_ as CqlInterval<CqlDateTime>), "1", "Error", "Cannot compute a single interval from a Timing type");

				return gc_;
			}
			else if (((choice is FhirString as bool?) ?? false))
			{
				CqlInterval<CqlDateTime> gd_ = null;
				var ge_ = context.Operators;
				var gf_ = ge_.Message<CqlInterval<CqlDateTime>>((gd_ as CqlInterval<CqlDateTime>), "1", "Error", "Cannot compute an interval from a String value");

				return gf_;
			}
			else
			{
				CqlInterval<CqlDateTime> gg_ = null;

				return (gg_ as CqlInterval<CqlDateTime>);
			}
;
		};

		return a_();
	}


    [CqlDeclaration("Normalize Abatement")]
    public CqlInterval<CqlDateTime> Normalize_Abatement(Condition condition) =>
((((condition?.Abatement is FhirDateTime as bool?) ?? false))
			? (context.Operators.Interval(FHIRHelpers_4_0_001.ToDateTime((condition?.Abatement as FhirDateTime)), FHIRHelpers_4_0_001.ToDateTime((condition?.Abatement as FhirDateTime)), true, true))
			: (((((condition?.Abatement is Period as bool?) ?? false))
					? (FHIRHelpers_4_0_001.ToInterval((condition?.Abatement as Period)))
					: (((((condition?.Abatement is FhirString as bool?) ?? false))
							? (context.Operators.Message<CqlInterval<CqlDateTime>>((null as CqlInterval<CqlDateTime>), "1", "Error", "Cannot compute an interval from a String value"))
							: (((((condition?.Abatement is Age as bool?) ?? false))
									? (context.Operators.Interval(context.Operators.ConvertDateToDateTime((context.Operators.Interval(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((Quantity)(condition?.Abatement as Age))), context.Operators.Add(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((Quantity)(condition?.Abatement as Age))), context.Operators.Quantity(1m, "year")), true, false))?.low), context.Operators.ConvertDateToDateTime((context.Operators.Interval(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((Quantity)(condition?.Abatement as Age))), context.Operators.Add(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((Quantity)(condition?.Abatement as Age))), context.Operators.Quantity(1m, "year")), true, false))?.high), (context.Operators.Interval(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((Quantity)(condition?.Abatement as Age))), context.Operators.Add(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((Quantity)(condition?.Abatement as Age))), context.Operators.Quantity(1m, "year")), true, false))?.lowClosed, (context.Operators.Interval(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((Quantity)(condition?.Abatement as Age))), context.Operators.Add(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((Quantity)(condition?.Abatement as Age))), context.Operators.Quantity(1m, "year")), true, false))?.highClosed))
									: (((((condition?.Abatement is Range as bool?) ?? false))
											? (context.Operators.Interval(context.Operators.ConvertDateToDateTime((context.Operators.Interval(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((condition?.Abatement as Range)?.Low)), context.Operators.Add(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((condition?.Abatement as Range)?.High)), context.Operators.Quantity(1m, "year")), true, false))?.low), context.Operators.ConvertDateToDateTime((context.Operators.Interval(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((condition?.Abatement as Range)?.Low)), context.Operators.Add(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((condition?.Abatement as Range)?.High)), context.Operators.Quantity(1m, "year")), true, false))?.high), (context.Operators.Interval(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((condition?.Abatement as Range)?.Low)), context.Operators.Add(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((condition?.Abatement as Range)?.High)), context.Operators.Quantity(1m, "year")), true, false))?.lowClosed, (context.Operators.Interval(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((condition?.Abatement as Range)?.Low)), context.Operators.Add(context.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), FHIRHelpers_4_0_001.ToQuantity((condition?.Abatement as Range)?.High)), context.Operators.Quantity(1m, "year")), true, false))?.highClosed))
											: (((((condition?.Abatement is FhirBoolean as bool?) ?? false))
													? (context.Operators.Interval(context.Operators.End(this.Normalize_Interval(condition?.Onset)), FHIRHelpers_4_0_001.ToDateTime(condition?.RecordedDateElement), true, false))
													: ((null as CqlInterval<CqlDateTime>)))))))))))));


    [CqlDeclaration("Prevalence Period")]
    public CqlInterval<CqlDateTime> Prevalence_Period(Condition condition) =>
(((context.Operators.Or(context.Operators.Or(context.Operators.Equivalent(FHIRHelpers_4_0_001.ToConcept(condition?.ClinicalStatus), context.Operators.ConvertCodeToConcept(this.active())), context.Operators.Equivalent(FHIRHelpers_4_0_001.ToConcept(condition?.ClinicalStatus), context.Operators.ConvertCodeToConcept(this.recurrence()))), context.Operators.Equivalent(FHIRHelpers_4_0_001.ToConcept(condition?.ClinicalStatus), context.Operators.ConvertCodeToConcept(this.relapse()))) ?? false))
			? (context.Operators.Interval(context.Operators.Start(this.Normalize_Interval(condition?.Onset)), context.Operators.End(this.Normalize_Abatement(condition)), true, true))
			: (context.Operators.Interval(context.Operators.Start(this.Normalize_Interval(condition?.Onset)), context.Operators.End(this.Normalize_Abatement(condition)), true, false)));


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
		var a_ = Encounter?.Diagnosis;
		Condition b_(Encounter.DiagnosisComponent D)
		{
			var e_ = context.DataRetriever;
			var f_ = e_.RetrieveByValueSet<Condition>(null, null);
			bool? g_(Condition C)
			{
				var l_ = C?.IdElement;
				var m_ = new CallStackEntry("ToString", null, null);
				var n_ = context.Deeper(m_);
				var o_ = n_.Operators;
				var p_ = o_.TypeConverter;
				var q_ = p_.Convert<string>(l_);
				var r_ = D?.Condition;
				var s_ = r_?.ReferenceElement;
				var u_ = context.Deeper(m_);
				var v_ = u_.Operators;
				var w_ = v_.TypeConverter;
				var x_ = w_.Convert<string>(s_);
				var y_ = this.GetId(x_);
				var z_ = context.Operators;
				var aa_ = z_.Equal(q_, y_);

				return aa_;
			};
			var h_ = context.Operators;
			var i_ = h_.WhereOrNull<Condition>(f_, g_);
			var k_ = h_.SingleOrNull<Condition>(i_);

			return k_;
		};
		var c_ = context.Operators;
		var d_ = c_.SelectOrNull<Encounter.DiagnosisComponent, Condition>((a_ as IEnumerable<Encounter.DiagnosisComponent>), b_);

		return d_;
	}


    [CqlDeclaration("GetCondition")]
    public Condition GetCondition(ResourceReference reference)
	{
		var a_ = context.DataRetriever;
		var b_ = a_.RetrieveByValueSet<Condition>(null, null);
		bool? c_(Condition C)
		{
			var h_ = C?.IdElement;
			var i_ = new CallStackEntry("ToString", null, null);
			var j_ = context.Deeper(i_);
			var k_ = j_.Operators;
			var l_ = k_.TypeConverter;
			var m_ = l_.Convert<string>(h_);
			var n_ = reference?.ReferenceElement;
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
		var a_ = domainResource?.Extension;
		bool? b_(Extension E)
		{
			var h_ = E?.Url;
			var i_ = context.Operators;
			var j_ = i_.TypeConverter;
			var k_ = j_.Convert<FhirUri>(h_);
			var l_ = new CallStackEntry("ToString", null, null);
			var m_ = context.Deeper(l_);
			var n_ = m_.Operators;
			var o_ = n_.TypeConverter;
			var p_ = o_.Convert<string>(k_);
			var r_ = i_.Concatenate("http://hl7.org/fhir/us/qicore/StructureDefinition/", url);
			var t_ = i_.Equal(p_, r_);

			return t_;
		};
		var c_ = context.Operators;
		var d_ = c_.WhereOrNull<Extension>((a_ as IEnumerable<Extension>), b_);
		Extension e_(Extension E) => E;
		var g_ = c_.SelectOrNull<Extension, Extension>(d_, e_);

		return g_;
	}


    [CqlDeclaration("GetExtensions")]
    public IEnumerable<Extension> GetExtensions(Element element, string url)
	{
		var a_ = element?.Extension;
		bool? b_(Extension E)
		{
			var h_ = E?.Url;
			var i_ = context.Operators;
			var j_ = i_.TypeConverter;
			var k_ = j_.Convert<FhirUri>(h_);
			var l_ = new CallStackEntry("ToString", null, null);
			var m_ = context.Deeper(l_);
			var n_ = m_.Operators;
			var o_ = n_.TypeConverter;
			var p_ = o_.Convert<string>(k_);
			var r_ = i_.Equal(p_, url);

			return r_;
		};
		var c_ = context.Operators;
		var d_ = c_.WhereOrNull<Extension>((a_ as IEnumerable<Extension>), b_);
		Extension e_(Extension E) => E;
		var g_ = c_.SelectOrNull<Extension, Extension>(d_, e_);

		return g_;
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
		var b_ = a_?.Value;

		return (b_ as CodeableConcept);
	}


    [CqlDeclaration("PrincipalDiagnosis")]
    public Condition PrincipalDiagnosis(Encounter Encounter)
	{
		var a_ = Encounter?.Diagnosis;
		bool? b_(Encounter.DiagnosisComponent D)
		{
			var m_ = D?.RankElement;
			var n_ = context.Operators;
			var o_ = n_.TypeConverter;
			var p_ = o_.Convert<Integer>(m_);
			var q_ = FHIRHelpers_4_0_001.ToInteger(p_);
			var s_ = n_.Equal(q_, (int?)1);

			return s_;
		};
		var c_ = context.Operators;
		var d_ = c_.WhereOrNull<Encounter.DiagnosisComponent>((a_ as IEnumerable<Encounter.DiagnosisComponent>), b_);
		var f_ = c_.SingleOrNull<Encounter.DiagnosisComponent>(d_);
		var g_ = new Encounter.DiagnosisComponent[]
		{
			f_,
		};
		Condition h_(Encounter.DiagnosisComponent PD)
		{
			var t_ = context.DataRetriever;
			var u_ = t_.RetrieveByValueSet<Condition>(null, null);
			bool? v_(Condition C)
			{
				var aa_ = C?.IdElement;
				var ab_ = new CallStackEntry("ToString", null, null);
				var ac_ = context.Deeper(ab_);
				var ad_ = ac_.Operators;
				var ae_ = ad_.TypeConverter;
				var af_ = ae_.Convert<string>(aa_);
				var ag_ = PD?.Condition;
				var ah_ = ag_?.ReferenceElement;
				var aj_ = context.Deeper(ab_);
				var ak_ = aj_.Operators;
				var al_ = ak_.TypeConverter;
				var am_ = al_.Convert<string>(ah_);
				var an_ = this.GetId(am_);
				var ao_ = context.Operators;
				var ap_ = ao_.Equal(af_, an_);

				return ap_;
			};
			var w_ = context.Operators;
			var x_ = w_.WhereOrNull<Condition>(u_, v_);
			var z_ = w_.SingleOrNull<Condition>(x_);

			return z_;
		};
		var j_ = c_.SelectOrNull<Encounter.DiagnosisComponent, Condition>(g_, h_);
		var l_ = c_.SingleOrNull<Condition>(j_);

		return l_;
	}


    [CqlDeclaration("GetLocation")]
    public Location GetLocation(ResourceReference reference)
	{
		var a_ = context.DataRetriever;
		var b_ = a_.RetrieveByValueSet<Location>(null, null);
		bool? c_(Location L)
		{
			var h_ = L?.IdElement;
			var i_ = new CallStackEntry("ToString", null, null);
			var j_ = context.Deeper(i_);
			var k_ = j_.Operators;
			var l_ = k_.TypeConverter;
			var m_ = l_.Convert<string>(h_);
			var n_ = reference?.ReferenceElement;
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
		var a_ = domainResource?.Extension;
		bool? b_(Extension E)
		{
			var h_ = E?.Url;
			var i_ = context.Operators;
			var j_ = i_.TypeConverter;
			var k_ = j_.Convert<FhirUri>(h_);
			var l_ = new CallStackEntry("ToString", null, null);
			var m_ = context.Deeper(l_);
			var n_ = m_.Operators;
			var o_ = n_.TypeConverter;
			var p_ = o_.Convert<string>(k_);
			var r_ = i_.Concatenate("http://hl7.org/fhir/StructureDefinition/", url);
			var t_ = i_.Equal(p_, r_);

			return t_;
		};
		var c_ = context.Operators;
		var d_ = c_.WhereOrNull<Extension>((a_ as IEnumerable<Extension>), b_);
		Extension e_(Extension E) => E;
		var g_ = c_.SelectOrNull<Extension, Extension>(d_, e_);

		return g_;
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
		var a_ = element?.Extension;
		bool? b_(Extension E)
		{
			var h_ = E?.Url;
			var i_ = context.Operators;
			var j_ = i_.TypeConverter;
			var k_ = j_.Convert<FhirUri>(h_);
			var l_ = new CallStackEntry("ToString", null, null);
			var m_ = context.Deeper(l_);
			var n_ = m_.Operators;
			var o_ = n_.TypeConverter;
			var p_ = o_.Convert<string>(k_);
			var r_ = i_.Concatenate("http://hl7.org/fhir/StructureDefinition/", id);
			var t_ = i_.Equal(p_, r_);

			return t_;
		};
		var c_ = context.Operators;
		var d_ = c_.WhereOrNull<Extension>((a_ as IEnumerable<Extension>), b_);
		Extension e_(Extension E) => E;
		var g_ = c_.SelectOrNull<Extension, Extension>(d_, e_);

		return g_;
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
    public CodeableConcept GetMedicationCode(MedicationRequest request) =>
((((request?.Medication is CodeableConcept as bool?) ?? false))
			? ((request?.Medication as CodeableConcept))
			: ((context.Operators.SingleOrNull<Medication>(context.Operators.WhereOrNull<Medication>(context.DataRetriever.RetrieveByValueSet<Medication>(null, null), (Medication M) => context.Operators.Equal((context.Deeper(new CallStackEntry("ToString", null, null)).Operators.TypeConverter).Convert<string>(M?.IdElement), this.GetId((context.Deeper(new CallStackEntry("ToString", null, null)).Operators.TypeConverter).Convert<string>((request?.Medication as ResourceReference)?.ReferenceElement))))))?.Code));


    [CqlDeclaration("HasStart")]
    public bool? HasStart(CqlInterval<CqlDateTime> period)
	{
		var a_ = context.Operators;
		var b_ = a_.Start(period);
		var d_ = a_.Start(period);
		var f_ = a_.Minimum<CqlDateTime>();
		var h_ = a_.Equal(d_, f_);
		var j_ = a_.Or((bool?)(b_ is null), h_);
		var l_ = a_.Not(j_);

		return l_;
	}


    [CqlDeclaration("HasEnd")]
    public bool? HasEnd(CqlInterval<CqlDateTime> period)
	{
		var a_ = context.Operators;
		var b_ = a_.End(period);
		var d_ = a_.End(period);
		var f_ = a_.Maximum<CqlDateTime>();
		var h_ = a_.Equal(d_, f_);
		var j_ = a_.Or((bool?)(b_ is null), h_);
		var l_ = a_.Not(j_);

		return l_;
	}


    [CqlDeclaration("Latest")]
    public CqlDateTime Latest(object choice)
	{
		var a_ = this.Normalize_Interval(choice);
		var b_ = new CqlInterval<CqlDateTime>[]
		{
			a_,
		};
		CqlDateTime c_(CqlInterval<CqlDateTime> period) => (((this.HasEnd(period) ?? false))
			? (context.Operators.End(period))
			: (context.Operators.Start(period)));
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
		CqlDateTime c_(CqlInterval<CqlDateTime> period) => (((this.HasStart(period) ?? false))
			? (context.Operators.Start(period))
			: (context.Operators.End(period)));
		var d_ = context.Operators;
		var e_ = d_.SelectOrNull<CqlInterval<CqlDateTime>, CqlDateTime>(b_, c_);
		var g_ = d_.SingleOrNull<CqlDateTime>(e_);

		return g_;
	}


}