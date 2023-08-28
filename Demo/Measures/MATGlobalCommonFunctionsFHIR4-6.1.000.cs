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
			var at_ = r_.Not((bool?)ar_);
			var av_ = r_.And(am_, at_);
			var ax_ = r_.And(s_, av_);

			return ax_;
		};
		var e_ = context.Operators;
		var f_ = e_.WhereOrNull<Encounter>(c_, d_);
		object g_(Encounter @this)
		{
			var ay_ = @this.Period;
			var az_ = FHIRHelpers_4_0_001.ToInterval(ay_);
			var ba_ = context.Operators;
			var bb_ = ba_.End(az_);

			return bb_;
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
		CqlInterval<CqlDateTime> c_(Encounter X) => (((X == null))
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
		IEnumerable<Encounter.LocationComponent> c_(Encounter EDEncounter) => (((EDEncounter == null))
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
		object b_(Encounter.LocationComponent @this)
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
		CqlInterval<CqlDateTime> b_(Encounter Visit)
		{
			var g_ = this.Emergency_Department_Visit();
			var h_ = context.DataRetriever;
			var i_ = h_.RetrieveByValueSet<Encounter>(g_, null);
			bool? j_(Encounter LastED)
			{
				var aw_ = LastED.Period;
				var ax_ = FHIRHelpers_4_0_001.ToInterval(aw_);
				var ay_ = context.Operators;
				var az_ = ay_.End(ax_);
				var ba_ = this.Observation_Services();
				var bb_ = context.DataRetriever;
				var bc_ = bb_.RetrieveByValueSet<Encounter>(ba_, null);
				bool? bd_(Encounter LastObs)
				{
					var dv_ = LastObs.Period;
					var dw_ = FHIRHelpers_4_0_001.ToInterval(dv_);
					var dx_ = context.Operators;
					var dy_ = dx_.End(dw_);
					var dz_ = Visit.Period;
					var ea_ = FHIRHelpers_4_0_001.ToInterval(dz_);
					var ec_ = dx_.Start(ea_);
					var ee_ = dx_.Quantity(1m, "hour");
					var eg_ = dx_.Subtract(ec_, ee_);
					var ei_ = FHIRHelpers_4_0_001.ToInterval(dz_);
					var ek_ = dx_.Start(ei_);
					var em_ = dx_.Interval(eg_, ek_, true, true);
					var eo_ = dx_.ElementInInterval<CqlDateTime>(dy_, em_, null);
					var eq_ = FHIRHelpers_4_0_001.ToInterval(dz_);
					var es_ = dx_.Start(eq_);
					var et_ = (es_ == null);
					var ev_ = dx_.Not((bool?)et_);
					var ex_ = dx_.And(eo_, ev_);

					return ex_;
				};
				var bf_ = ay_.WhereOrNull<Encounter>(bc_, bd_);
				object bg_(Encounter @this)
				{
					var ey_ = @this.Period;
					var ez_ = FHIRHelpers_4_0_001.ToInterval(ey_);
					var fa_ = context.Operators;
					var fb_ = fa_.End(ez_);

					return fb_;
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
				bool? cb_(Encounter LastObs)
				{
					var fc_ = LastObs.Period;
					var fd_ = FHIRHelpers_4_0_001.ToInterval(fc_);
					var fe_ = context.Operators;
					var ff_ = fe_.End(fd_);
					var fg_ = Visit.Period;
					var fh_ = FHIRHelpers_4_0_001.ToInterval(fg_);
					var fj_ = fe_.Start(fh_);
					var fl_ = fe_.Quantity(1m, "hour");
					var fn_ = fe_.Subtract(fj_, fl_);
					var fp_ = FHIRHelpers_4_0_001.ToInterval(fg_);
					var fr_ = fe_.Start(fp_);
					var ft_ = fe_.Interval(fn_, fr_, true, true);
					var fv_ = fe_.ElementInInterval<CqlDateTime>(ff_, ft_, null);
					var fx_ = FHIRHelpers_4_0_001.ToInterval(fg_);
					var fz_ = fe_.Start(fx_);
					var ga_ = (fz_ == null);
					var gc_ = fe_.Not((bool?)ga_);
					var ge_ = fe_.And(fv_, gc_);

					return ge_;
				};
				var cd_ = ay_.WhereOrNull<Encounter>(ca_, cb_);
				object ce_(Encounter @this)
				{
					var gf_ = @this.Period;
					var gg_ = FHIRHelpers_4_0_001.ToInterval(gf_);
					var gh_ = context.Operators;
					var gi_ = gh_.End(gg_);

					return gi_;
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
				bool? cz_(Encounter LastObs)
				{
					var gj_ = LastObs.Period;
					var gk_ = FHIRHelpers_4_0_001.ToInterval(gj_);
					var gl_ = context.Operators;
					var gm_ = gl_.End(gk_);
					var gn_ = Visit.Period;
					var go_ = FHIRHelpers_4_0_001.ToInterval(gn_);
					var gq_ = gl_.Start(go_);
					var gs_ = gl_.Quantity(1m, "hour");
					var gu_ = gl_.Subtract(gq_, gs_);
					var gw_ = FHIRHelpers_4_0_001.ToInterval(gn_);
					var gy_ = gl_.Start(gw_);
					var ha_ = gl_.Interval(gu_, gy_, true, true);
					var hc_ = gl_.ElementInInterval<CqlDateTime>(gm_, ha_, null);
					var he_ = FHIRHelpers_4_0_001.ToInterval(gn_);
					var hg_ = gl_.Start(he_);
					var hh_ = (hg_ == null);
					var hj_ = gl_.Not((bool?)hh_);
					var hl_ = gl_.And(hc_, hj_);

					return hl_;
				};
				var db_ = ay_.WhereOrNull<Encounter>(cy_, cz_);
				object dc_(Encounter @this)
				{
					var hm_ = @this.Period;
					var hn_ = FHIRHelpers_4_0_001.ToInterval(hm_);
					var ho_ = context.Operators;
					var hp_ = ho_.End(hn_);

					return hp_;
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
				var ds_ = ay_.Not((bool?)dq_);
				var du_ = ay_.And(cv_, ds_);

				return du_;
			};
			var k_ = context.Operators;
			var l_ = k_.WhereOrNull<Encounter>(i_, j_);
			object m_(Encounter @this)
			{
				var hq_ = @this.Period;
				var hr_ = FHIRHelpers_4_0_001.ToInterval(hq_);
				var hs_ = context.Operators;
				var ht_ = hs_.End(hr_);

				return ht_;
			};
			var o_ = k_.ListSortBy<Encounter>(l_, m_, System.ComponentModel.ListSortDirection.Ascending);
			var q_ = k_.LastOfList<Encounter>(o_);
			var r_ = q_.Period;
			var s_ = FHIRHelpers_4_0_001.ToInterval(r_);
			var u_ = k_.Start(s_);
			var v_ = this.Observation_Services();
			var x_ = h_.RetrieveByValueSet<Encounter>(v_, null);
			bool? y_(Encounter LastObs)
			{
				var hu_ = LastObs.Period;
				var hv_ = FHIRHelpers_4_0_001.ToInterval(hu_);
				var hw_ = context.Operators;
				var hx_ = hw_.End(hv_);
				var hy_ = Visit.Period;
				var hz_ = FHIRHelpers_4_0_001.ToInterval(hy_);
				var ib_ = hw_.Start(hz_);
				var id_ = hw_.Quantity(1m, "hour");
				var if_ = hw_.Subtract(ib_, id_);
				var ih_ = FHIRHelpers_4_0_001.ToInterval(hy_);
				var ij_ = hw_.Start(ih_);
				var il_ = hw_.Interval(if_, ij_, true, true);
				var in_ = hw_.ElementInInterval<CqlDateTime>(hx_, il_, null);
				var ip_ = FHIRHelpers_4_0_001.ToInterval(hy_);
				var ir_ = hw_.Start(ip_);
				var is_ = (ir_ == null);
				var iu_ = hw_.Not((bool?)is_);
				var iw_ = hw_.And(in_, iu_);

				return iw_;
			};
			var aa_ = k_.WhereOrNull<Encounter>(x_, y_);
			object ab_(Encounter @this)
			{
				var ix_ = @this.Period;
				var iy_ = FHIRHelpers_4_0_001.ToInterval(ix_);
				var iz_ = context.Operators;
				var ja_ = iz_.End(iy_);

				return ja_;
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
			var a__ = FHIRHelpers_4_0_001.ToDateTime((choice as FhirDateTime));
			var c__ = context.Operators;
			var d__ = c__.Interval(a__, a__, true, true);

			return d__;
		}
        else if (((choice is Period as bool?) ?? false))
		{
			var a__ = FHIRHelpers_4_0_001.ToInterval((choice as Period));

			return a__;
		}
        else if (((choice is Instant as bool?) ?? false))
		{
			var a__ = FHIRHelpers_4_0_001.ToDateTime((choice as Instant));
			var c__ = context.Operators;
			var d__ = c__.Interval(a__, a__, true, true);

			return d__;
		}
        else if (((choice is Age as bool?) ?? false))
		{
			var a__ = this.Patient();
			var b__ = a__.BirthDateElement;
			var c__ = FHIRHelpers_4_0_001.ToDate(b__);
			var d__ = FHIRHelpers_4_0_001.ToQuantity((Quantity)(choice as Age));
			var e__ = context.Operators;
			var f__ = e__.Add(c__, d__);
			var h__ = a__.BirthDateElement;
			var i__ = FHIRHelpers_4_0_001.ToDate(h__);
			var l__ = e__.Add(i__, d__);
			var n__ = e__.Quantity(1m, "year");
			var p__ = e__.Add(l__, n__);
			var r__ = e__.Interval(f__, p__, true, false);
			var s__ = r__.low;
			var u__ = e__.ConvertDateToDateTime(s__);
			var w__ = a__.BirthDateElement;
			var x__ = FHIRHelpers_4_0_001.ToDate(w__);
			var aa__ = e__.Add(x__, d__);
			var ac__ = a__.BirthDateElement;
			var ad__ = FHIRHelpers_4_0_001.ToDate(ac__);
			var ag__ = e__.Add(ad__, d__);
			var ai__ = e__.Quantity(1m, "year");
			var ak__ = e__.Add(ag__, ai__);
			var am__ = e__.Interval(aa__, ak__, true, false);
			var an__ = am__.high;
			var ap__ = e__.ConvertDateToDateTime(an__);
			var ar__ = a__.BirthDateElement;
			var as__ = FHIRHelpers_4_0_001.ToDate(ar__);
			var av__ = e__.Add(as__, d__);
			var ax__ = a__.BirthDateElement;
			var ay__ = FHIRHelpers_4_0_001.ToDate(ax__);
			var bb__ = e__.Add(ay__, d__);
			var bd__ = e__.Quantity(1m, "year");
			var bf__ = e__.Add(bb__, bd__);
			var bh__ = e__.Interval(av__, bf__, true, false);
			var bi__ = bh__.lowClosed;
			var bk__ = a__.BirthDateElement;
			var bl__ = FHIRHelpers_4_0_001.ToDate(bk__);
			var bo__ = e__.Add(bl__, d__);
			var bq__ = a__.BirthDateElement;
			var br__ = FHIRHelpers_4_0_001.ToDate(bq__);
			var bu__ = e__.Add(br__, d__);
			var bw__ = e__.Quantity(1m, "year");
			var by__ = e__.Add(bu__, bw__);
			var ca__ = e__.Interval(bo__, by__, true, false);
			var cb__ = ca__.highClosed;
			var cd__ = e__.Interval(u__, ap__, bi__, cb__);

			return cd__;
		}
        else if (((choice is Range as bool?) ?? false))
		{
			var a__ = this.Patient();
			var b__ = a__.BirthDateElement;
			var c__ = FHIRHelpers_4_0_001.ToDate(b__);
			var d__ = (choice as Range).Low;
			var e__ = FHIRHelpers_4_0_001.ToQuantity(d__);
			var f__ = context.Operators;
			var g__ = f__.Add(c__, e__);
			var i__ = a__.BirthDateElement;
			var j__ = FHIRHelpers_4_0_001.ToDate(i__);
			var k__ = (choice as Range).High;
			var l__ = FHIRHelpers_4_0_001.ToQuantity(k__);
			var n__ = f__.Add(j__, l__);
			var p__ = f__.Quantity(1m, "year");
			var r__ = f__.Add(n__, p__);
			var t__ = f__.Interval(g__, r__, true, false);
			var u__ = t__.low;
			var w__ = f__.ConvertDateToDateTime(u__);
			var y__ = a__.BirthDateElement;
			var z__ = FHIRHelpers_4_0_001.ToDate(y__);
			var ab__ = FHIRHelpers_4_0_001.ToQuantity(d__);
			var ad__ = f__.Add(z__, ab__);
			var af__ = a__.BirthDateElement;
			var ag__ = FHIRHelpers_4_0_001.ToDate(af__);
			var ai__ = FHIRHelpers_4_0_001.ToQuantity(k__);
			var ak__ = f__.Add(ag__, ai__);
			var am__ = f__.Quantity(1m, "year");
			var ao__ = f__.Add(ak__, am__);
			var aq__ = f__.Interval(ad__, ao__, true, false);
			var ar__ = aq__.high;
			var at__ = f__.ConvertDateToDateTime(ar__);
			var av__ = a__.BirthDateElement;
			var aw__ = FHIRHelpers_4_0_001.ToDate(av__);
			var ay__ = FHIRHelpers_4_0_001.ToQuantity(d__);
			var ba__ = f__.Add(aw__, ay__);
			var bc__ = a__.BirthDateElement;
			var bd__ = FHIRHelpers_4_0_001.ToDate(bc__);
			var bf__ = FHIRHelpers_4_0_001.ToQuantity(k__);
			var bh__ = f__.Add(bd__, bf__);
			var bj__ = f__.Quantity(1m, "year");
			var bl__ = f__.Add(bh__, bj__);
			var bn__ = f__.Interval(ba__, bl__, true, false);
			var bo__ = bn__.lowClosed;
			var bq__ = a__.BirthDateElement;
			var br__ = FHIRHelpers_4_0_001.ToDate(bq__);
			var bt__ = FHIRHelpers_4_0_001.ToQuantity(d__);
			var bv__ = f__.Add(br__, bt__);
			var bx__ = a__.BirthDateElement;
			var by__ = FHIRHelpers_4_0_001.ToDate(bx__);
			var ca__ = FHIRHelpers_4_0_001.ToQuantity(k__);
			var cc__ = f__.Add(by__, ca__);
			var ce__ = f__.Quantity(1m, "year");
			var cg__ = f__.Add(cc__, ce__);
			var ci__ = f__.Interval(bv__, cg__, true, false);
			var cj__ = ci__.highClosed;
			var cl__ = f__.Interval(w__, at__, bo__, cj__);

			return cl__;
		}
        else if (((choice is Timing as bool?) ?? false))
		{
			CqlInterval<CqlDateTime> a__ = null;
			var b__ = context.Operators;
			var c__ = b__.Message<CqlInterval<CqlDateTime>>((a__ as CqlInterval<CqlDateTime>), "1", "Error", "Cannot compute a single interval from a Timing type");

			return c__;
		}
        else if (((choice is FhirString as bool?) ?? false))
		{
			CqlInterval<CqlDateTime> a__ = null;
			var b__ = context.Operators;
			var c__ = b__.Message<CqlInterval<CqlDateTime>>((a__ as CqlInterval<CqlDateTime>), "1", "Error", "Cannot compute an interval from a String value");

			return c__;
		}
        else
		{
			CqlInterval<CqlDateTime> a__ = null;

			return (a__ as CqlInterval<CqlDateTime>);
		}
    }


    [CqlDeclaration("Normalize Abatement")]
    public CqlInterval<CqlDateTime> Normalize_Abatement(Condition condition)
    {
        if (((condition.Abatement is FhirDateTime as bool?) ?? false))
		{
			var a__ = condition.Abatement;
			var b__ = FHIRHelpers_4_0_001.ToDateTime((a__ as FhirDateTime));
			var d__ = FHIRHelpers_4_0_001.ToDateTime((a__ as FhirDateTime));
			var e__ = context.Operators;
			var f__ = e__.Interval(b__, d__, true, true);

			return f__;
		}
        else if (((condition.Abatement is Period as bool?) ?? false))
		{
			var a__ = condition.Abatement;
			var b__ = FHIRHelpers_4_0_001.ToInterval((a__ as Period));

			return b__;
		}
        else if (((condition.Abatement is FhirString as bool?) ?? false))
		{
			CqlInterval<CqlDateTime> a__ = null;
			var b__ = context.Operators;
			var c__ = b__.Message<CqlInterval<CqlDateTime>>((a__ as CqlInterval<CqlDateTime>), "1", "Error", "Cannot compute an interval from a String value");

			return c__;
		}
        else if (((condition.Abatement is Age as bool?) ?? false))
		{
			var a__ = this.Patient();
			var b__ = a__.BirthDateElement;
			var c__ = FHIRHelpers_4_0_001.ToDate(b__);
			var d__ = condition.Abatement;
			var e__ = FHIRHelpers_4_0_001.ToQuantity((Quantity)(d__ as Age));
			var f__ = context.Operators;
			var g__ = f__.Add(c__, e__);
			var i__ = a__.BirthDateElement;
			var j__ = FHIRHelpers_4_0_001.ToDate(i__);
			var l__ = FHIRHelpers_4_0_001.ToQuantity((Quantity)(d__ as Age));
			var n__ = f__.Add(j__, l__);
			var p__ = f__.Quantity(1m, "year");
			var r__ = f__.Add(n__, p__);
			var t__ = f__.Interval(g__, r__, true, false);
			var u__ = t__.low;
			var w__ = f__.ConvertDateToDateTime(u__);
			var y__ = a__.BirthDateElement;
			var z__ = FHIRHelpers_4_0_001.ToDate(y__);
			var ab__ = FHIRHelpers_4_0_001.ToQuantity((Quantity)(d__ as Age));
			var ad__ = f__.Add(z__, ab__);
			var af__ = a__.BirthDateElement;
			var ag__ = FHIRHelpers_4_0_001.ToDate(af__);
			var ai__ = FHIRHelpers_4_0_001.ToQuantity((Quantity)(d__ as Age));
			var ak__ = f__.Add(ag__, ai__);
			var am__ = f__.Quantity(1m, "year");
			var ao__ = f__.Add(ak__, am__);
			var aq__ = f__.Interval(ad__, ao__, true, false);
			var ar__ = aq__.high;
			var at__ = f__.ConvertDateToDateTime(ar__);
			var av__ = a__.BirthDateElement;
			var aw__ = FHIRHelpers_4_0_001.ToDate(av__);
			var ay__ = FHIRHelpers_4_0_001.ToQuantity((Quantity)(d__ as Age));
			var ba__ = f__.Add(aw__, ay__);
			var bc__ = a__.BirthDateElement;
			var bd__ = FHIRHelpers_4_0_001.ToDate(bc__);
			var bf__ = FHIRHelpers_4_0_001.ToQuantity((Quantity)(d__ as Age));
			var bh__ = f__.Add(bd__, bf__);
			var bj__ = f__.Quantity(1m, "year");
			var bl__ = f__.Add(bh__, bj__);
			var bn__ = f__.Interval(ba__, bl__, true, false);
			var bo__ = bn__.lowClosed;
			var bq__ = a__.BirthDateElement;
			var br__ = FHIRHelpers_4_0_001.ToDate(bq__);
			var bt__ = FHIRHelpers_4_0_001.ToQuantity((Quantity)(d__ as Age));
			var bv__ = f__.Add(br__, bt__);
			var bx__ = a__.BirthDateElement;
			var by__ = FHIRHelpers_4_0_001.ToDate(bx__);
			var ca__ = FHIRHelpers_4_0_001.ToQuantity((Quantity)(d__ as Age));
			var cc__ = f__.Add(by__, ca__);
			var ce__ = f__.Quantity(1m, "year");
			var cg__ = f__.Add(cc__, ce__);
			var ci__ = f__.Interval(bv__, cg__, true, false);
			var cj__ = ci__.highClosed;
			var cl__ = f__.Interval(w__, at__, bo__, cj__);

			return cl__;
		}
        else if (((condition.Abatement is Range as bool?) ?? false))
		{
			var a__ = this.Patient();
			var b__ = a__.BirthDateElement;
			var c__ = FHIRHelpers_4_0_001.ToDate(b__);
			var d__ = condition.Abatement;
			var e__ = (d__ as Range).Low;
			var f__ = FHIRHelpers_4_0_001.ToQuantity(e__);
			var g__ = context.Operators;
			var h__ = g__.Add(c__, f__);
			var j__ = a__.BirthDateElement;
			var k__ = FHIRHelpers_4_0_001.ToDate(j__);
			var m__ = (d__ as Range).High;
			var n__ = FHIRHelpers_4_0_001.ToQuantity(m__);
			var p__ = g__.Add(k__, n__);
			var r__ = g__.Quantity(1m, "year");
			var t__ = g__.Add(p__, r__);
			var v__ = g__.Interval(h__, t__, true, false);
			var w__ = v__.low;
			var y__ = g__.ConvertDateToDateTime(w__);
			var aa__ = a__.BirthDateElement;
			var ab__ = FHIRHelpers_4_0_001.ToDate(aa__);
			var ad__ = (d__ as Range).Low;
			var ae__ = FHIRHelpers_4_0_001.ToQuantity(ad__);
			var ag__ = g__.Add(ab__, ae__);
			var ai__ = a__.BirthDateElement;
			var aj__ = FHIRHelpers_4_0_001.ToDate(ai__);
			var al__ = (d__ as Range).High;
			var am__ = FHIRHelpers_4_0_001.ToQuantity(al__);
			var ao__ = g__.Add(aj__, am__);
			var aq__ = g__.Quantity(1m, "year");
			var as__ = g__.Add(ao__, aq__);
			var au__ = g__.Interval(ag__, as__, true, false);
			var av__ = au__.high;
			var ax__ = g__.ConvertDateToDateTime(av__);
			var az__ = a__.BirthDateElement;
			var ba__ = FHIRHelpers_4_0_001.ToDate(az__);
			var bc__ = (d__ as Range).Low;
			var bd__ = FHIRHelpers_4_0_001.ToQuantity(bc__);
			var bf__ = g__.Add(ba__, bd__);
			var bh__ = a__.BirthDateElement;
			var bi__ = FHIRHelpers_4_0_001.ToDate(bh__);
			var bk__ = (d__ as Range).High;
			var bl__ = FHIRHelpers_4_0_001.ToQuantity(bk__);
			var bn__ = g__.Add(bi__, bl__);
			var bp__ = g__.Quantity(1m, "year");
			var br__ = g__.Add(bn__, bp__);
			var bt__ = g__.Interval(bf__, br__, true, false);
			var bu__ = bt__.lowClosed;
			var bw__ = a__.BirthDateElement;
			var bx__ = FHIRHelpers_4_0_001.ToDate(bw__);
			var bz__ = (d__ as Range).Low;
			var ca__ = FHIRHelpers_4_0_001.ToQuantity(bz__);
			var cc__ = g__.Add(bx__, ca__);
			var ce__ = a__.BirthDateElement;
			var cf__ = FHIRHelpers_4_0_001.ToDate(ce__);
			var ch__ = (d__ as Range).High;
			var ci__ = FHIRHelpers_4_0_001.ToQuantity(ch__);
			var ck__ = g__.Add(cf__, ci__);
			var cm__ = g__.Quantity(1m, "year");
			var co__ = g__.Add(ck__, cm__);
			var cq__ = g__.Interval(cc__, co__, true, false);
			var cr__ = cq__.highClosed;
			var ct__ = g__.Interval(y__, ax__, bu__, cr__);

			return ct__;
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

			return (a__ as CqlInterval<CqlDateTime>);
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
		Condition b_(Encounter.DiagnosisComponent D)
		{
			var e_ = context.DataRetriever;
			var f_ = e_.RetrieveByValueSet<Condition>(null, null);
			bool? g_(Condition C)
			{
				var l_ = C.IdElement;
				var m_ = new CallStackEntry("ToString", null, null);
				var n_ = context.Deeper(m_);
				var o_ = n_.Operators;
				var p_ = o_.TypeConverter;
				var q_ = p_.Convert<string>(l_);
				var r_ = D.Condition;
				var s_ = r_.ReferenceElement;
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
		bool? b_(Extension E)
		{
			var h_ = E.Url;
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
		var a_ = element.Extension;
		bool? b_(Extension E)
		{
			var h_ = E.Url;
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
		var b_ = a_.Value;

		return (b_ as CodeableConcept);
	}


    [CqlDeclaration("PrincipalDiagnosis")]
    public Condition PrincipalDiagnosis(Encounter Encounter)
	{
		var a_ = Encounter.Diagnosis;
		bool? b_(Encounter.DiagnosisComponent D)
		{
			var m_ = D.RankElement;
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
				var aa_ = C.IdElement;
				var ab_ = new CallStackEntry("ToString", null, null);
				var ac_ = context.Deeper(ab_);
				var ad_ = ac_.Operators;
				var ae_ = ad_.TypeConverter;
				var af_ = ae_.Convert<string>(aa_);
				var ag_ = PD.Condition;
				var ah_ = ag_.ReferenceElement;
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
		bool? b_(Extension E)
		{
			var h_ = E.Url;
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
		var a_ = element.Extension;
		bool? b_(Extension E)
		{
			var h_ = E.Url;
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
    public CodeableConcept GetMedicationCode(MedicationRequest request)
    {
        if (((request.Medication is CodeableConcept as bool?) ?? false))
		{
			var a__ = request.Medication;

			return (a__ as CodeableConcept);
		}
        else
		{
			var a__ = context.DataRetriever;
			var b__ = a__.RetrieveByValueSet<Medication>(null, null);
			bool? c__(Medication M)
			{
				var i__ = M.IdElement;
				var j__ = new CallStackEntry("ToString", null, null);
				var k__ = context.Deeper(j__);
				var l__ = k__.Operators;
				var m__ = l__.TypeConverter;
				var n__ = m__.Convert<string>(i__);
				var o__ = request.Medication;
				var p__ = (o__ as ResourceReference).ReferenceElement;
				var r__ = context.Deeper(j__);
				var s__ = r__.Operators;
				var t__ = s__.TypeConverter;
				var u__ = t__.Convert<string>(p__);
				var v__ = this.GetId(u__);
				var w__ = context.Operators;
				var x__ = w__.Equal(n__, v__);

				return x__;
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
		var e_ = a_.Start(period);
		var g_ = a_.Minimum<CqlDateTime>();
		var i_ = a_.Equal(e_, g_);
		var k_ = a_.Or((bool?)c_, i_);
		var m_ = a_.Not(k_);

		return m_;
	}


    [CqlDeclaration("HasEnd")]
    public bool? HasEnd(CqlInterval<CqlDateTime> period)
	{
		var a_ = context.Operators;
		var b_ = a_.End(period);
		var c_ = (b_ == null);
		var e_ = a_.End(period);
		var g_ = a_.Maximum<CqlDateTime>();
		var i_ = a_.Equal(e_, g_);
		var k_ = a_.Or((bool?)c_, i_);
		var m_ = a_.Not(k_);

		return m_;
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
		CqlDateTime c_(CqlInterval<CqlDateTime> period) => (((this.HasStart(period) ?? false))
			? (context.Operators.Start(period))
			: (context.Operators.End(period)))
;
		var d_ = context.Operators;
		var e_ = d_.SelectOrNull<CqlInterval<CqlDateTime>, CqlDateTime>(b_, c_);
		var g_ = d_.SingleOrNull<CqlDateTime>(e_);

		return g_;
	}


}