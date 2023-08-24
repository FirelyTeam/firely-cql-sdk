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

    private CqlCode active_Value() =>
		new CqlCode("active", "http://terminology.hl7.org/CodeSystem/condition-clinical", null, null);

    [CqlDeclaration("active")]
    public CqlCode active() => __active.Value;

    private CqlCode allergy_active_Value() =>
		new CqlCode("active", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", null, null);

    [CqlDeclaration("allergy-active")]
    public CqlCode allergy_active() => __allergy_active.Value;

    private CqlCode allergy_confirmed_Value() =>
		new CqlCode("confirmed", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", null, null);

    [CqlDeclaration("allergy-confirmed")]
    public CqlCode allergy_confirmed() => __allergy_confirmed.Value;

    private CqlCode allergy_inactive_Value() =>
		new CqlCode("inactive", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", null, null);

    [CqlDeclaration("allergy-inactive")]
    public CqlCode allergy_inactive() => __allergy_inactive.Value;

    private CqlCode allergy_refuted_Value() =>
		new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", null, null);

    [CqlDeclaration("allergy-refuted")]
    public CqlCode allergy_refuted() => __allergy_refuted.Value;

    private CqlCode allergy_resolved_Value() =>
		new CqlCode("resolved", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", null, null);

    [CqlDeclaration("allergy-resolved")]
    public CqlCode allergy_resolved() => __allergy_resolved.Value;

    private CqlCode allergy_unconfirmed_Value() =>
		new CqlCode("unconfirmed", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", null, null);

    [CqlDeclaration("allergy-unconfirmed")]
    public CqlCode allergy_unconfirmed() => __allergy_unconfirmed.Value;

    private CqlCode Billing_Value() =>
		new CqlCode("billing", "http://terminology.hl7.org/CodeSystem/diagnosis-role", null, null);

    [CqlDeclaration("Billing")]
    public CqlCode Billing() => __Billing.Value;

    private CqlCode Birthdate_Value() =>
		new CqlCode("21112-8", "http://loinc.org", null, null);

    [CqlDeclaration("Birthdate")]
    public CqlCode Birthdate() => __Birthdate.Value;

    private CqlCode Community_Value() =>
		new CqlCode("community", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", null, null);

    [CqlDeclaration("Community")]
    public CqlCode Community() => __Community.Value;

    private CqlCode confirmed_Value() =>
		new CqlCode("confirmed", "http://terminology.hl7.org/CodeSystem/condition-ver-status", null, null);

    [CqlDeclaration("confirmed")]
    public CqlCode confirmed() => __confirmed.Value;

    private CqlCode Dead_Value() =>
		new CqlCode("419099009", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Dead")]
    public CqlCode Dead() => __Dead.Value;

    private CqlCode differential_Value() =>
		new CqlCode("differential", "http://terminology.hl7.org/CodeSystem/condition-ver-status", null, null);

    [CqlDeclaration("differential")]
    public CqlCode differential() => __differential.Value;

    private CqlCode Discharge_Value() =>
		new CqlCode("discharge", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", null, null);

    [CqlDeclaration("Discharge")]
    public CqlCode Discharge() => __Discharge.Value;

    private CqlCode entered_in_error_Value() =>
		new CqlCode("entered-in-error", "http://terminology.hl7.org/CodeSystem/condition-ver-status", null, null);

    [CqlDeclaration("entered-in-error")]
    public CqlCode entered_in_error() => __entered_in_error.Value;

    private CqlCode ER_Value() =>
		new CqlCode("ER", "http://terminology.hl7.org/CodeSystem/v3-RoleCode", null, null);

    [CqlDeclaration("ER")]
    public CqlCode ER() => __ER.Value;

    private CqlCode ICU_Value() =>
		new CqlCode("ICU", "http://terminology.hl7.org/CodeSystem/v3-RoleCode", null, null);

    [CqlDeclaration("ICU")]
    public CqlCode ICU() => __ICU.Value;

    private CqlCode inactive_Value() =>
		new CqlCode("inactive", "http://terminology.hl7.org/CodeSystem/condition-clinical", null, null);

    [CqlDeclaration("inactive")]
    public CqlCode inactive() => __inactive.Value;

    private CqlCode provisional_Value() =>
		new CqlCode("provisional", "http://terminology.hl7.org/CodeSystem/condition-ver-status", null, null);

    [CqlDeclaration("provisional")]
    public CqlCode provisional() => __provisional.Value;

    private CqlCode recurrence_Value() =>
		new CqlCode("recurrence", "http://terminology.hl7.org/CodeSystem/condition-clinical", null, null);

    [CqlDeclaration("recurrence")]
    public CqlCode recurrence() => __recurrence.Value;

    private CqlCode refuted_Value() =>
		new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/condition-ver-status", null, null);

    [CqlDeclaration("refuted")]
    public CqlCode refuted() => __refuted.Value;

    private CqlCode relapse_Value() =>
		new CqlCode("relapse", "http://terminology.hl7.org/CodeSystem/condition-clinical", null, null);

    [CqlDeclaration("relapse")]
    public CqlCode relapse() => __relapse.Value;

    private CqlCode remission_Value() =>
		new CqlCode("remission", "http://terminology.hl7.org/CodeSystem/condition-clinical", null, null);

    [CqlDeclaration("remission")]
    public CqlCode remission() => __remission.Value;

    private CqlCode resolved_Value() =>
		new CqlCode("resolved", "http://terminology.hl7.org/CodeSystem/condition-clinical", null, null);

    [CqlDeclaration("resolved")]
    public CqlCode resolved() => __resolved.Value;

    private CqlCode unconfirmed_Value() =>
		new CqlCode("unconfirmed", "http://terminology.hl7.org/CodeSystem/condition-ver-status", null, null);

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

		return new CqlCode[]
		{
			a_,
			b_,
			c_,
			d_,
			e_,
			f_,
		};
	}

    [CqlDeclaration("ConditionClinicalStatusCodes")]
    public CqlCode[] ConditionClinicalStatusCodes() => __ConditionClinicalStatusCodes.Value;

    private CqlCode[] AllergyIntoleranceClinicalStatusCodes_Value()
	{
		var a_ = new CqlCode("active", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", null, null);
		var b_ = new CqlCode("inactive", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", null, null);
		var c_ = new CqlCode("resolved", "http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", null, null);

		return new CqlCode[]
		{
			a_,
			b_,
			c_,
		};
	}

    [CqlDeclaration("AllergyIntoleranceClinicalStatusCodes")]
    public CqlCode[] AllergyIntoleranceClinicalStatusCodes() => __AllergyIntoleranceClinicalStatusCodes.Value;

    private CqlCode[] AllergyIntoleranceVerificationStatusCodes_Value()
	{
		var a_ = new CqlCode("confirmed", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", null, null);
		var b_ = new CqlCode("refuted", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", null, null);
		var c_ = new CqlCode("unconfirmed", "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", null, null);

		return new CqlCode[]
		{
			a_,
			b_,
			c_,
		};
	}

    [CqlDeclaration("AllergyIntoleranceVerificationStatusCodes")]
    public CqlCode[] AllergyIntoleranceVerificationStatusCodes() => __AllergyIntoleranceVerificationStatusCodes.Value;

    private CqlCode[] Diagnosis_Role_Value()
	{
		var a_ = new CqlCode("billing", "http://terminology.hl7.org/CodeSystem/diagnosis-role", null, null);

		return new CqlCode[]
		{
			a_,
		};
	}

    [CqlDeclaration("Diagnosis Role")]
    public CqlCode[] Diagnosis_Role() => __Diagnosis_Role.Value;

    private CqlCode[] LOINC_Value()
	{
		var a_ = new CqlCode("21112-8", "http://loinc.org", null, null);

		return new CqlCode[]
		{
			a_,
		};
	}

    [CqlDeclaration("LOINC")]
    public CqlCode[] LOINC() => __LOINC.Value;

    private CqlCode[] MedicationRequestCategory_Value()
	{
		var a_ = new CqlCode("community", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", null, null);
		var b_ = new CqlCode("discharge", "http://terminology.hl7.org/CodeSystem/medicationrequest-category", null, null);

		return new CqlCode[]
		{
			a_,
			b_,
		};
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

		return new CqlCode[]
		{
			a_,
			b_,
			c_,
			d_,
			e_,
			f_,
		};
	}

    [CqlDeclaration("ConditionVerificationStatusCodes")]
    public CqlCode[] ConditionVerificationStatusCodes() => __ConditionVerificationStatusCodes.Value;

    private CqlCode[] SNOMEDCT_Value()
	{
		var a_ = new CqlCode("419099009", "http://snomed.info/sct", null, null);

		return new CqlCode[]
		{
			a_,
		};
	}

    [CqlDeclaration("SNOMEDCT")]
    public CqlCode[] SNOMEDCT() => __SNOMEDCT.Value;

    private CqlCode[] RoleCode_Value()
	{
		var a_ = new CqlCode("ER", "http://terminology.hl7.org/CodeSystem/v3-RoleCode", null, null);
		var b_ = new CqlCode("ICU", "http://terminology.hl7.org/CodeSystem/v3-RoleCode", null, null);

		return new CqlCode[]
		{
			a_,
			b_,
		};
	}

    [CqlDeclaration("RoleCode")]
    public CqlCode[] RoleCode() => __RoleCode.Value;

    private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context?.Operators.ConvertIntegerToDecimal(default);
		var b_ = context?.Operators.DateTime((int?)2019, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, a_);
		var c_ = context?.Operators.ConvertIntegerToDecimal(default);
		var d_ = context?.Operators.DateTime((int?)2020, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, c_);
		var e_ = context?.Operators.Interval(b_, d_, true, false);
		var f_ = (e_ as object);
		var g_ = context.ResolveParameter("MATGlobalCommonFunctionsFHIR4-6.1.000", "Measurement Period", f_);

		return (CqlInterval<CqlDateTime>)g_;
	}

    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period() => __Measurement_Period.Value;

    private Patient Patient_Value()
	{
		var a_ = context?.DataRetriever.RetrieveByValueSet<Patient>(null, null);

		return context?.Operators.SingleOrNull<Patient>(a_);
	}

    [CqlDeclaration("Patient")]
    public Patient Patient() => __Patient.Value;

    [CqlDeclaration("LengthInDays")]
    public int? LengthInDays(CqlInterval<CqlDateTime> Value)
	{
		var a_ = context?.Operators.Start(Value);
		var b_ = context?.Operators.End(Value);

		return context?.Operators.DifferenceBetween(a_, b_, "day");
	}


    private IEnumerable<Encounter> Inpatient_Encounter_Value()
	{
		var s_ = this.Encounter_Inpatient();
		var t_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(s_, null);
		var u_ = (Encounter EncounterInpatient) =>
		{
			var a_ = EncounterInpatient?.StatusElement;
			var b_ = (a_ as object);
			var c_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(b_);
			var d_ = (c_ as object);
			var e_ = context?.Operators.Equal(d_, ("finished" as object));
			var f_ = EncounterInpatient?.Period;
			var g_ = FHIRHelpers_4_0_001.ToInterval(f_);
			var h_ = this.LengthInDays(g_);
			var i_ = h_;
			var j_ = (int?)120;
			var k_ = j_;
			var l_ = context?.Operators.LessOrEqual(i_, k_);
			var m_ = context?.Operators.And(e_, l_);
			var n_ = EncounterInpatient?.Period;
			var o_ = FHIRHelpers_4_0_001.ToInterval(n_);
			var p_ = context?.Operators.End(o_);
			var q_ = this.Measurement_Period();
			var r_ = context?.Operators.ElementInInterval<CqlDateTime>(p_, q_, null);

			return context?.Operators.And(m_, r_);
		};

		return context?.Operators.WhereOrNull<Encounter>(t_, u_);
	}

    [CqlDeclaration("Inpatient Encounter")]
    public IEnumerable<Encounter> Inpatient_Encounter() => __Inpatient_Encounter.Value;

    [CqlDeclaration("ED Visit")]
    public Encounter ED_Visit(Encounter TheEncounter)
	{
		var ac_ = this.Emergency_Department_Visit();
		var ad_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(ac_, null);
		var ae_ = (Encounter EDVisit) =>
		{
			var a_ = EDVisit?.StatusElement;
			var b_ = (a_ as object);
			var c_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(b_);
			var d_ = (c_ as object);
			var e_ = context?.Operators.Equal(d_, ("finished" as object));
			var f_ = EDVisit?.Period;
			var g_ = FHIRHelpers_4_0_001.ToInterval(f_);
			var h_ = context?.Operators.End(g_);
			var i_ = TheEncounter?.Period;
			var j_ = FHIRHelpers_4_0_001.ToInterval(i_);
			var k_ = context?.Operators.Start(j_);
			var l_ = context?.Operators.Quantity(1m, "hour");
			var m_ = context?.Operators.Subtract(k_, l_);
			var n_ = TheEncounter?.Period;
			var o_ = FHIRHelpers_4_0_001.ToInterval(n_);
			var p_ = context?.Operators.Start(o_);
			var q_ = context?.Operators.Interval(m_, p_, true, true);
			var r_ = context?.Operators.ElementInInterval<CqlDateTime>(h_, q_, null);
			var s_ = TheEncounter?.Period;
			var t_ = FHIRHelpers_4_0_001.ToInterval(s_);
			var u_ = context?.Operators.Start(t_);
			var v_ = (u_ == null);
			var w_ = (bool?)v_;
			var x_ = context?.Operators.Not(w_);
			var y_ = context?.Operators.And(r_, x_);

			return context?.Operators.And(e_, y_);
		};
		var af_ = context?.Operators.WhereOrNull<Encounter>(ad_, ae_);
		var ag_ = (Encounter @this) =>
		{
			var z_ = @this?.Period;
			var aa_ = FHIRHelpers_4_0_001.ToInterval(z_);
			var ab_ = context?.Operators.End(aa_);

			return ab_;
		};
		var ah_ = context?.Operators.ListSortBy<Encounter>(af_, ag_, System.ComponentModel.ListSortDirection.Ascending);

		return context?.Operators.LastOfList<Encounter>(ah_);
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
			? (FHIRHelpers_4_0_001.ToInterval(TheEncounter?.Period))
			: (context?.Operators.Interval(context?.Operators.Start(FHIRHelpers_4_0_001.ToInterval(X?.Period)), context?.Operators.End(FHIRHelpers_4_0_001.ToInterval(TheEncounter?.Period)), true, true)))
;
		var d_ = context?.Operators.SelectOrNull<Encounter, CqlInterval<CqlDateTime>>(b_, c_);

		return context?.Operators.SingleOrNull<CqlInterval<CqlDateTime>>(d_);
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
			? ((TheEncounter?.Location as IEnumerable<Encounter.LocationComponent>))
			: (context?.Operators.FlattenList<Encounter.LocationComponent>((new IEnumerable<Encounter.LocationComponent>[]
					{
						(EDEncounter?.Location as IEnumerable<Encounter.LocationComponent>),
						(TheEncounter?.Location as IEnumerable<Encounter.LocationComponent>),
					} as IEnumerable<IEnumerable<Encounter.LocationComponent>>))))
;
		var d_ = context?.Operators.SelectOrNull<Encounter, IEnumerable<Encounter.LocationComponent>>(b_, c_);

		return context?.Operators.SingleOrNull<IEnumerable<Encounter.LocationComponent>>(d_);
	}


    [CqlDeclaration("Hospitalization Length of Stay")]
    public int? Hospitalization_Length_of_Stay(Encounter TheEncounter)
	{
		var a_ = this.Hospitalization(TheEncounter);

		return this.LengthInDays(a_);
	}


    [CqlDeclaration("Hospital Admission Time")]
    public CqlDateTime Hospital_Admission_Time(Encounter TheEncounter)
	{
		var a_ = this.Hospitalization(TheEncounter);

		return context?.Operators.Start(a_);
	}


    [CqlDeclaration("Hospital Discharge Time")]
    public CqlDateTime Hospital_Discharge_Time(Encounter TheEncounter)
	{
		var a_ = TheEncounter?.Period;
		var b_ = FHIRHelpers_4_0_001.ToInterval(a_);

		return context?.Operators.End(b_);
	}


    [CqlDeclaration("Hospital Arrival Time")]
    public CqlDateTime Hospital_Arrival_Time(Encounter TheEncounter)
	{
		var d_ = this.Hospitalization_Locations(TheEncounter);
		var e_ = (Encounter.LocationComponent @this) =>
		{
			var a_ = @this?.Period;
			var b_ = FHIRHelpers_4_0_001.ToInterval(a_);
			var c_ = context?.Operators.Start(b_);

			return c_;
		};
		var f_ = context?.Operators.ListSortBy<Encounter.LocationComponent>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
		var g_ = context?.Operators.FirstOfList<Encounter.LocationComponent>(f_);
		var h_ = g_?.Period;
		var i_ = FHIRHelpers_4_0_001.ToInterval(h_);

		return context?.Operators.Start(i_);
	}


    [CqlDeclaration("HospitalizationWithObservation")]
    public CqlInterval<CqlDateTime> HospitalizationWithObservation(Encounter TheEncounter)
	{
		var fp_ = TheEncounter;
		var fq_ = new Encounter[]
		{
			fp_,
		};
		var fr_ = (Encounter Visit) =>
		{
			var en_ = this.Emergency_Department_Visit();
			var eo_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(en_, null);
			var ep_ = (Encounter LastED) =>
			{
				var bo_ = LastED?.Period;
				var bp_ = FHIRHelpers_4_0_001.ToInterval(bo_);
				var bq_ = context?.Operators.End(bp_);
				var br_ = this.Observation_Services();
				var bs_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(br_, null);
				var bt_ = (Encounter LastObs) =>
				{
					var a_ = LastObs?.Period;
					var b_ = FHIRHelpers_4_0_001.ToInterval(a_);
					var c_ = context?.Operators.End(b_);
					var d_ = Visit?.Period;
					var e_ = FHIRHelpers_4_0_001.ToInterval(d_);
					var f_ = context?.Operators.Start(e_);
					var g_ = context?.Operators.Quantity(1m, "hour");
					var h_ = context?.Operators.Subtract(f_, g_);
					var i_ = Visit?.Period;
					var j_ = FHIRHelpers_4_0_001.ToInterval(i_);
					var k_ = context?.Operators.Start(j_);
					var l_ = context?.Operators.Interval(h_, k_, true, true);
					var m_ = context?.Operators.ElementInInterval<CqlDateTime>(c_, l_, null);
					var n_ = Visit?.Period;
					var o_ = FHIRHelpers_4_0_001.ToInterval(n_);
					var p_ = context?.Operators.Start(o_);
					var q_ = (p_ == null);
					var r_ = (bool?)q_;
					var s_ = context?.Operators.Not(r_);

					return context?.Operators.And(m_, s_);
				};
				var bu_ = context?.Operators.WhereOrNull<Encounter>(bs_, bt_);
				var bv_ = (Encounter @this) =>
				{
					var t_ = @this?.Period;
					var u_ = FHIRHelpers_4_0_001.ToInterval(t_);
					var v_ = context?.Operators.End(u_);

					return v_;
				};
				var bw_ = context?.Operators.ListSortBy<Encounter>(bu_, bv_, System.ComponentModel.ListSortDirection.Ascending);
				var bx_ = context?.Operators.LastOfList<Encounter>(bw_);
				var by_ = bx_?.Period;
				var bz_ = FHIRHelpers_4_0_001.ToInterval(by_);
				var ca_ = context?.Operators.Start(bz_);
				var cb_ = Visit?.Period;
				var cc_ = FHIRHelpers_4_0_001.ToInterval(cb_);
				var cd_ = context?.Operators.Start(cc_);
				var ce_ = (ca_ ?? cd_);
				var cf_ = context?.Operators.Quantity(1m, "hour");
				var cg_ = context?.Operators.Subtract(ce_, cf_);
				var ch_ = this.Observation_Services();
				var ci_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(ch_, null);
				var cj_ = (Encounter LastObs) =>
				{
					var w_ = LastObs?.Period;
					var x_ = FHIRHelpers_4_0_001.ToInterval(w_);
					var y_ = context?.Operators.End(x_);
					var z_ = Visit?.Period;
					var aa_ = FHIRHelpers_4_0_001.ToInterval(z_);
					var ab_ = context?.Operators.Start(aa_);
					var ac_ = context?.Operators.Quantity(1m, "hour");
					var ad_ = context?.Operators.Subtract(ab_, ac_);
					var ae_ = Visit?.Period;
					var af_ = FHIRHelpers_4_0_001.ToInterval(ae_);
					var ag_ = context?.Operators.Start(af_);
					var ah_ = context?.Operators.Interval(ad_, ag_, true, true);
					var ai_ = context?.Operators.ElementInInterval<CqlDateTime>(y_, ah_, null);
					var aj_ = Visit?.Period;
					var ak_ = FHIRHelpers_4_0_001.ToInterval(aj_);
					var al_ = context?.Operators.Start(ak_);
					var am_ = (al_ == null);
					var an_ = (bool?)am_;
					var ao_ = context?.Operators.Not(an_);

					return context?.Operators.And(ai_, ao_);
				};
				var ck_ = context?.Operators.WhereOrNull<Encounter>(ci_, cj_);
				var cl_ = (Encounter @this) =>
				{
					var ap_ = @this?.Period;
					var aq_ = FHIRHelpers_4_0_001.ToInterval(ap_);
					var ar_ = context?.Operators.End(aq_);

					return ar_;
				};
				var cm_ = context?.Operators.ListSortBy<Encounter>(ck_, cl_, System.ComponentModel.ListSortDirection.Ascending);
				var cn_ = context?.Operators.LastOfList<Encounter>(cm_);
				var co_ = cn_?.Period;
				var cp_ = FHIRHelpers_4_0_001.ToInterval(co_);
				var cq_ = context?.Operators.Start(cp_);
				var cr_ = Visit?.Period;
				var cs_ = FHIRHelpers_4_0_001.ToInterval(cr_);
				var ct_ = context?.Operators.Start(cs_);
				var cu_ = (cq_ ?? ct_);
				var cv_ = context?.Operators.Interval(cg_, cu_, true, true);
				var cw_ = context?.Operators.ElementInInterval<CqlDateTime>(bq_, cv_, null);
				var cx_ = this.Observation_Services();
				var cy_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(cx_, null);
				var cz_ = (Encounter LastObs) =>
				{
					var as_ = LastObs?.Period;
					var at_ = FHIRHelpers_4_0_001.ToInterval(as_);
					var au_ = context?.Operators.End(at_);
					var av_ = Visit?.Period;
					var aw_ = FHIRHelpers_4_0_001.ToInterval(av_);
					var ax_ = context?.Operators.Start(aw_);
					var ay_ = context?.Operators.Quantity(1m, "hour");
					var az_ = context?.Operators.Subtract(ax_, ay_);
					var ba_ = Visit?.Period;
					var bb_ = FHIRHelpers_4_0_001.ToInterval(ba_);
					var bc_ = context?.Operators.Start(bb_);
					var bd_ = context?.Operators.Interval(az_, bc_, true, true);
					var be_ = context?.Operators.ElementInInterval<CqlDateTime>(au_, bd_, null);
					var bf_ = Visit?.Period;
					var bg_ = FHIRHelpers_4_0_001.ToInterval(bf_);
					var bh_ = context?.Operators.Start(bg_);
					var bi_ = (bh_ == null);
					var bj_ = (bool?)bi_;
					var bk_ = context?.Operators.Not(bj_);

					return context?.Operators.And(be_, bk_);
				};
				var da_ = context?.Operators.WhereOrNull<Encounter>(cy_, cz_);
				var db_ = (Encounter @this) =>
				{
					var bl_ = @this?.Period;
					var bm_ = FHIRHelpers_4_0_001.ToInterval(bl_);
					var bn_ = context?.Operators.End(bm_);

					return bn_;
				};
				var dc_ = context?.Operators.ListSortBy<Encounter>(da_, db_, System.ComponentModel.ListSortDirection.Ascending);
				var dd_ = context?.Operators.LastOfList<Encounter>(dc_);
				var de_ = dd_?.Period;
				var df_ = FHIRHelpers_4_0_001.ToInterval(de_);
				var dg_ = context?.Operators.Start(df_);
				var dh_ = Visit?.Period;
				var di_ = FHIRHelpers_4_0_001.ToInterval(dh_);
				var dj_ = context?.Operators.Start(di_);
				var dk_ = (dg_ ?? dj_);
				var dl_ = (dk_ == null);
				var dm_ = (bool?)dl_;
				var dn_ = context?.Operators.Not(dm_);

				return context?.Operators.And(cw_, dn_);
			};
			var eq_ = context?.Operators.WhereOrNull<Encounter>(eo_, ep_);
			var er_ = (Encounter @this) =>
			{
				var do_ = @this?.Period;
				var dp_ = FHIRHelpers_4_0_001.ToInterval(do_);
				var dq_ = context?.Operators.End(dp_);

				return dq_;
			};
			var es_ = context?.Operators.ListSortBy<Encounter>(eq_, er_, System.ComponentModel.ListSortDirection.Ascending);
			var et_ = context?.Operators.LastOfList<Encounter>(es_);
			var eu_ = et_?.Period;
			var ev_ = FHIRHelpers_4_0_001.ToInterval(eu_);
			var ew_ = context?.Operators.Start(ev_);
			var ex_ = this.Observation_Services();
			var ey_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(ex_, null);
			var ez_ = (Encounter LastObs) =>
			{
				var dr_ = LastObs?.Period;
				var ds_ = FHIRHelpers_4_0_001.ToInterval(dr_);
				var dt_ = context?.Operators.End(ds_);
				var du_ = Visit?.Period;
				var dv_ = FHIRHelpers_4_0_001.ToInterval(du_);
				var dw_ = context?.Operators.Start(dv_);
				var dx_ = context?.Operators.Quantity(1m, "hour");
				var dy_ = context?.Operators.Subtract(dw_, dx_);
				var dz_ = Visit?.Period;
				var ea_ = FHIRHelpers_4_0_001.ToInterval(dz_);
				var eb_ = context?.Operators.Start(ea_);
				var ec_ = context?.Operators.Interval(dy_, eb_, true, true);
				var ed_ = context?.Operators.ElementInInterval<CqlDateTime>(dt_, ec_, null);
				var ee_ = Visit?.Period;
				var ef_ = FHIRHelpers_4_0_001.ToInterval(ee_);
				var eg_ = context?.Operators.Start(ef_);
				var eh_ = (eg_ == null);
				var ei_ = (bool?)eh_;
				var ej_ = context?.Operators.Not(ei_);

				return context?.Operators.And(ed_, ej_);
			};
			var fa_ = context?.Operators.WhereOrNull<Encounter>(ey_, ez_);
			var fb_ = (Encounter @this) =>
			{
				var ek_ = @this?.Period;
				var el_ = FHIRHelpers_4_0_001.ToInterval(ek_);
				var em_ = context?.Operators.End(el_);

				return em_;
			};
			var fc_ = context?.Operators.ListSortBy<Encounter>(fa_, fb_, System.ComponentModel.ListSortDirection.Ascending);
			var fd_ = context?.Operators.LastOfList<Encounter>(fc_);
			var fe_ = fd_?.Period;
			var ff_ = FHIRHelpers_4_0_001.ToInterval(fe_);
			var fg_ = context?.Operators.Start(ff_);
			var fh_ = Visit?.Period;
			var fi_ = FHIRHelpers_4_0_001.ToInterval(fh_);
			var fj_ = context?.Operators.Start(fi_);
			var fk_ = (fg_ ?? fj_);
			var fl_ = (ew_ ?? fk_);
			var fm_ = Visit?.Period;
			var fn_ = FHIRHelpers_4_0_001.ToInterval(fm_);
			var fo_ = context?.Operators.End(fn_);

			return context?.Operators.Interval(fl_, fo_, true, true);
		};
		var fs_ = context?.Operators.SelectOrNull<Encounter, CqlInterval<CqlDateTime>>(fq_, fr_);

		return context?.Operators.SingleOrNull<CqlInterval<CqlDateTime>>(fs_);
	}


    [CqlDeclaration("Normalize Interval")]
    public CqlInterval<CqlDateTime> Normalize_Interval(object choice)
    {
        if (((choice is FhirDateTime as bool?) ?? false))
		{
			var a__ = FHIRHelpers_4_0_001.ToDateTime((choice as FhirDateTime));
			var b__ = FHIRHelpers_4_0_001.ToDateTime((choice as FhirDateTime));

			return context?.Operators.Interval(a__, b__, true, true);
		}
        else if (((choice is Period as bool?) ?? false))
            return FHIRHelpers_4_0_001.ToInterval((choice as Period));
        else if (((choice is Instant as bool?) ?? false))
		{
			var a__ = FHIRHelpers_4_0_001.ToDateTime((choice as Instant));
			var b__ = FHIRHelpers_4_0_001.ToDateTime((choice as Instant));

			return context?.Operators.Interval(a__, b__, true, true);
		}
        else if (((choice is Age as bool?) ?? false))
		{
			var a__ = this.Patient();
			var b__ = a__?.BirthDateElement;
			var c__ = FHIRHelpers_4_0_001.ToDate(b__);
			var d__ = (choice as Age);
			var e__ = (Quantity)d__;
			var f__ = FHIRHelpers_4_0_001.ToQuantity(e__);
			var g__ = context?.Operators.Add(c__, f__);
			var h__ = this.Patient();
			var i__ = h__?.BirthDateElement;
			var j__ = FHIRHelpers_4_0_001.ToDate(i__);
			var k__ = (choice as Age);
			var l__ = (Quantity)k__;
			var m__ = FHIRHelpers_4_0_001.ToQuantity(l__);
			var n__ = context?.Operators.Add(j__, m__);
			var o__ = context?.Operators.Quantity(1m, "year");
			var p__ = context?.Operators.Add(n__, o__);
			var q__ = context?.Operators.Interval(g__, p__, true, false);
			var r__ = q__?.low;
			var s__ = context?.Operators.ConvertDateToDateTime(r__);
			var t__ = this.Patient();
			var u__ = t__?.BirthDateElement;
			var v__ = FHIRHelpers_4_0_001.ToDate(u__);
			var w__ = (choice as Age);
			var x__ = (Quantity)w__;
			var y__ = FHIRHelpers_4_0_001.ToQuantity(x__);
			var z__ = context?.Operators.Add(v__, y__);
			var aa__ = this.Patient();
			var ab__ = aa__?.BirthDateElement;
			var ac__ = FHIRHelpers_4_0_001.ToDate(ab__);
			var ad__ = (choice as Age);
			var ae__ = (Quantity)ad__;
			var af__ = FHIRHelpers_4_0_001.ToQuantity(ae__);
			var ag__ = context?.Operators.Add(ac__, af__);
			var ah__ = context?.Operators.Quantity(1m, "year");
			var ai__ = context?.Operators.Add(ag__, ah__);
			var aj__ = context?.Operators.Interval(z__, ai__, true, false);
			var ak__ = aj__?.high;
			var al__ = context?.Operators.ConvertDateToDateTime(ak__);
			var am__ = this.Patient();
			var an__ = am__?.BirthDateElement;
			var ao__ = FHIRHelpers_4_0_001.ToDate(an__);
			var ap__ = (choice as Age);
			var aq__ = (Quantity)ap__;
			var ar__ = FHIRHelpers_4_0_001.ToQuantity(aq__);
			var as__ = context?.Operators.Add(ao__, ar__);
			var at__ = this.Patient();
			var au__ = at__?.BirthDateElement;
			var av__ = FHIRHelpers_4_0_001.ToDate(au__);
			var aw__ = (choice as Age);
			var ax__ = (Quantity)aw__;
			var ay__ = FHIRHelpers_4_0_001.ToQuantity(ax__);
			var az__ = context?.Operators.Add(av__, ay__);
			var ba__ = context?.Operators.Quantity(1m, "year");
			var bb__ = context?.Operators.Add(az__, ba__);
			var bc__ = context?.Operators.Interval(as__, bb__, true, false);
			var bd__ = bc__?.lowClosed;
			var be__ = this.Patient();
			var bf__ = be__?.BirthDateElement;
			var bg__ = FHIRHelpers_4_0_001.ToDate(bf__);
			var bh__ = (choice as Age);
			var bi__ = (Quantity)bh__;
			var bj__ = FHIRHelpers_4_0_001.ToQuantity(bi__);
			var bk__ = context?.Operators.Add(bg__, bj__);
			var bl__ = this.Patient();
			var bm__ = bl__?.BirthDateElement;
			var bn__ = FHIRHelpers_4_0_001.ToDate(bm__);
			var bo__ = (choice as Age);
			var bp__ = (Quantity)bo__;
			var bq__ = FHIRHelpers_4_0_001.ToQuantity(bp__);
			var br__ = context?.Operators.Add(bn__, bq__);
			var bs__ = context?.Operators.Quantity(1m, "year");
			var bt__ = context?.Operators.Add(br__, bs__);
			var bu__ = context?.Operators.Interval(bk__, bt__, true, false);
			var bv__ = bu__?.highClosed;

			return context?.Operators.Interval(s__, al__, bd__, bv__);
		}
        else if (((choice is Range as bool?) ?? false))
		{
			var a__ = this.Patient();
			var b__ = a__?.BirthDateElement;
			var c__ = FHIRHelpers_4_0_001.ToDate(b__);
			var d__ = (choice as Range)?.Low;
			var e__ = FHIRHelpers_4_0_001.ToQuantity(d__);
			var f__ = context?.Operators.Add(c__, e__);
			var g__ = this.Patient();
			var h__ = g__?.BirthDateElement;
			var i__ = FHIRHelpers_4_0_001.ToDate(h__);
			var j__ = (choice as Range)?.High;
			var k__ = FHIRHelpers_4_0_001.ToQuantity(j__);
			var l__ = context?.Operators.Add(i__, k__);
			var m__ = context?.Operators.Quantity(1m, "year");
			var n__ = context?.Operators.Add(l__, m__);
			var o__ = context?.Operators.Interval(f__, n__, true, false);
			var p__ = o__?.low;
			var q__ = context?.Operators.ConvertDateToDateTime(p__);
			var r__ = this.Patient();
			var s__ = r__?.BirthDateElement;
			var t__ = FHIRHelpers_4_0_001.ToDate(s__);
			var u__ = (choice as Range)?.Low;
			var v__ = FHIRHelpers_4_0_001.ToQuantity(u__);
			var w__ = context?.Operators.Add(t__, v__);
			var x__ = this.Patient();
			var y__ = x__?.BirthDateElement;
			var z__ = FHIRHelpers_4_0_001.ToDate(y__);
			var aa__ = (choice as Range)?.High;
			var ab__ = FHIRHelpers_4_0_001.ToQuantity(aa__);
			var ac__ = context?.Operators.Add(z__, ab__);
			var ad__ = context?.Operators.Quantity(1m, "year");
			var ae__ = context?.Operators.Add(ac__, ad__);
			var af__ = context?.Operators.Interval(w__, ae__, true, false);
			var ag__ = af__?.high;
			var ah__ = context?.Operators.ConvertDateToDateTime(ag__);
			var ai__ = this.Patient();
			var aj__ = ai__?.BirthDateElement;
			var ak__ = FHIRHelpers_4_0_001.ToDate(aj__);
			var al__ = (choice as Range)?.Low;
			var am__ = FHIRHelpers_4_0_001.ToQuantity(al__);
			var an__ = context?.Operators.Add(ak__, am__);
			var ao__ = this.Patient();
			var ap__ = ao__?.BirthDateElement;
			var aq__ = FHIRHelpers_4_0_001.ToDate(ap__);
			var ar__ = (choice as Range)?.High;
			var as__ = FHIRHelpers_4_0_001.ToQuantity(ar__);
			var at__ = context?.Operators.Add(aq__, as__);
			var au__ = context?.Operators.Quantity(1m, "year");
			var av__ = context?.Operators.Add(at__, au__);
			var aw__ = context?.Operators.Interval(an__, av__, true, false);
			var ax__ = aw__?.lowClosed;
			var ay__ = this.Patient();
			var az__ = ay__?.BirthDateElement;
			var ba__ = FHIRHelpers_4_0_001.ToDate(az__);
			var bb__ = (choice as Range)?.Low;
			var bc__ = FHIRHelpers_4_0_001.ToQuantity(bb__);
			var bd__ = context?.Operators.Add(ba__, bc__);
			var be__ = this.Patient();
			var bf__ = be__?.BirthDateElement;
			var bg__ = FHIRHelpers_4_0_001.ToDate(bf__);
			var bh__ = (choice as Range)?.High;
			var bi__ = FHIRHelpers_4_0_001.ToQuantity(bh__);
			var bj__ = context?.Operators.Add(bg__, bi__);
			var bk__ = context?.Operators.Quantity(1m, "year");
			var bl__ = context?.Operators.Add(bj__, bk__);
			var bm__ = context?.Operators.Interval(bd__, bl__, true, false);
			var bn__ = bm__?.highClosed;

			return context?.Operators.Interval(q__, ah__, ax__, bn__);
		}
        else if (((choice is Timing as bool?) ?? false))
		{
			CqlInterval<CqlDateTime> a__ = null;
			var b__ = (a__ as CqlInterval<CqlDateTime>);

			return context?.Operators.Message<CqlInterval<CqlDateTime>>(b__, "1", "Error", "Cannot compute a single interval from a Timing type");
		}
        else if (((choice is FhirString as bool?) ?? false))
		{
			CqlInterval<CqlDateTime> a__ = null;
			var b__ = (a__ as CqlInterval<CqlDateTime>);

			return context?.Operators.Message<CqlInterval<CqlDateTime>>(b__, "1", "Error", "Cannot compute an interval from a String value");
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
        if ((((condition?.Abatement as object) is FhirDateTime as bool?) ?? false))
		{
			var a__ = condition?.Abatement;
			var b__ = (a__ as object);
			var c__ = (b__ as FhirDateTime);
			var d__ = FHIRHelpers_4_0_001.ToDateTime(c__);
			var e__ = condition?.Abatement;
			var f__ = (e__ as object);
			var g__ = (f__ as FhirDateTime);
			var h__ = FHIRHelpers_4_0_001.ToDateTime(g__);

			return context?.Operators.Interval(d__, h__, true, true);
		}
        else if ((((condition?.Abatement as object) is Period as bool?) ?? false))
		{
			var a__ = condition?.Abatement;
			var b__ = (a__ as object);
			var c__ = (b__ as Period);

			return FHIRHelpers_4_0_001.ToInterval(c__);
		}
        else if ((((condition?.Abatement as object) is FhirString as bool?) ?? false))
		{
			CqlInterval<CqlDateTime> a__ = null;
			var b__ = (a__ as CqlInterval<CqlDateTime>);

			return context?.Operators.Message<CqlInterval<CqlDateTime>>(b__, "1", "Error", "Cannot compute an interval from a String value");
		}
        else if ((((condition?.Abatement as object) is Age as bool?) ?? false))
		{
			var a__ = this.Patient();
			var b__ = a__?.BirthDateElement;
			var c__ = FHIRHelpers_4_0_001.ToDate(b__);
			var d__ = condition?.Abatement;
			var e__ = (d__ as object);
			var f__ = (e__ as Age);
			var g__ = (Quantity)f__;
			var h__ = FHIRHelpers_4_0_001.ToQuantity(g__);
			var i__ = context?.Operators.Add(c__, h__);
			var j__ = this.Patient();
			var k__ = j__?.BirthDateElement;
			var l__ = FHIRHelpers_4_0_001.ToDate(k__);
			var m__ = condition?.Abatement;
			var n__ = (m__ as object);
			var o__ = (n__ as Age);
			var p__ = (Quantity)o__;
			var q__ = FHIRHelpers_4_0_001.ToQuantity(p__);
			var r__ = context?.Operators.Add(l__, q__);
			var s__ = context?.Operators.Quantity(1m, "year");
			var t__ = context?.Operators.Add(r__, s__);
			var u__ = context?.Operators.Interval(i__, t__, true, false);
			var v__ = u__?.low;
			var w__ = context?.Operators.ConvertDateToDateTime(v__);
			var x__ = this.Patient();
			var y__ = x__?.BirthDateElement;
			var z__ = FHIRHelpers_4_0_001.ToDate(y__);
			var aa__ = condition?.Abatement;
			var ab__ = (aa__ as object);
			var ac__ = (ab__ as Age);
			var ad__ = (Quantity)ac__;
			var ae__ = FHIRHelpers_4_0_001.ToQuantity(ad__);
			var af__ = context?.Operators.Add(z__, ae__);
			var ag__ = this.Patient();
			var ah__ = ag__?.BirthDateElement;
			var ai__ = FHIRHelpers_4_0_001.ToDate(ah__);
			var aj__ = condition?.Abatement;
			var ak__ = (aj__ as object);
			var al__ = (ak__ as Age);
			var am__ = (Quantity)al__;
			var an__ = FHIRHelpers_4_0_001.ToQuantity(am__);
			var ao__ = context?.Operators.Add(ai__, an__);
			var ap__ = context?.Operators.Quantity(1m, "year");
			var aq__ = context?.Operators.Add(ao__, ap__);
			var ar__ = context?.Operators.Interval(af__, aq__, true, false);
			var as__ = ar__?.high;
			var at__ = context?.Operators.ConvertDateToDateTime(as__);
			var au__ = this.Patient();
			var av__ = au__?.BirthDateElement;
			var aw__ = FHIRHelpers_4_0_001.ToDate(av__);
			var ax__ = condition?.Abatement;
			var ay__ = (ax__ as object);
			var az__ = (ay__ as Age);
			var ba__ = (Quantity)az__;
			var bb__ = FHIRHelpers_4_0_001.ToQuantity(ba__);
			var bc__ = context?.Operators.Add(aw__, bb__);
			var bd__ = this.Patient();
			var be__ = bd__?.BirthDateElement;
			var bf__ = FHIRHelpers_4_0_001.ToDate(be__);
			var bg__ = condition?.Abatement;
			var bh__ = (bg__ as object);
			var bi__ = (bh__ as Age);
			var bj__ = (Quantity)bi__;
			var bk__ = FHIRHelpers_4_0_001.ToQuantity(bj__);
			var bl__ = context?.Operators.Add(bf__, bk__);
			var bm__ = context?.Operators.Quantity(1m, "year");
			var bn__ = context?.Operators.Add(bl__, bm__);
			var bo__ = context?.Operators.Interval(bc__, bn__, true, false);
			var bp__ = bo__?.lowClosed;
			var bq__ = this.Patient();
			var br__ = bq__?.BirthDateElement;
			var bs__ = FHIRHelpers_4_0_001.ToDate(br__);
			var bt__ = condition?.Abatement;
			var bu__ = (bt__ as object);
			var bv__ = (bu__ as Age);
			var bw__ = (Quantity)bv__;
			var bx__ = FHIRHelpers_4_0_001.ToQuantity(bw__);
			var by__ = context?.Operators.Add(bs__, bx__);
			var bz__ = this.Patient();
			var ca__ = bz__?.BirthDateElement;
			var cb__ = FHIRHelpers_4_0_001.ToDate(ca__);
			var cc__ = condition?.Abatement;
			var cd__ = (cc__ as object);
			var ce__ = (cd__ as Age);
			var cf__ = (Quantity)ce__;
			var cg__ = FHIRHelpers_4_0_001.ToQuantity(cf__);
			var ch__ = context?.Operators.Add(cb__, cg__);
			var ci__ = context?.Operators.Quantity(1m, "year");
			var cj__ = context?.Operators.Add(ch__, ci__);
			var ck__ = context?.Operators.Interval(by__, cj__, true, false);
			var cl__ = ck__?.highClosed;

			return context?.Operators.Interval(w__, at__, bp__, cl__);
		}
        else if ((((condition?.Abatement as object) is Range as bool?) ?? false))
		{
			var a__ = this.Patient();
			var b__ = a__?.BirthDateElement;
			var c__ = FHIRHelpers_4_0_001.ToDate(b__);
			var d__ = condition?.Abatement;
			var e__ = (d__ as object);
			var f__ = (e__ as Range);
			var g__ = f__?.Low;
			var h__ = FHIRHelpers_4_0_001.ToQuantity(g__);
			var i__ = context?.Operators.Add(c__, h__);
			var j__ = this.Patient();
			var k__ = j__?.BirthDateElement;
			var l__ = FHIRHelpers_4_0_001.ToDate(k__);
			var m__ = condition?.Abatement;
			var n__ = (m__ as object);
			var o__ = (n__ as Range);
			var p__ = o__?.High;
			var q__ = FHIRHelpers_4_0_001.ToQuantity(p__);
			var r__ = context?.Operators.Add(l__, q__);
			var s__ = context?.Operators.Quantity(1m, "year");
			var t__ = context?.Operators.Add(r__, s__);
			var u__ = context?.Operators.Interval(i__, t__, true, false);
			var v__ = u__?.low;
			var w__ = context?.Operators.ConvertDateToDateTime(v__);
			var x__ = this.Patient();
			var y__ = x__?.BirthDateElement;
			var z__ = FHIRHelpers_4_0_001.ToDate(y__);
			var aa__ = condition?.Abatement;
			var ab__ = (aa__ as object);
			var ac__ = (ab__ as Range);
			var ad__ = ac__?.Low;
			var ae__ = FHIRHelpers_4_0_001.ToQuantity(ad__);
			var af__ = context?.Operators.Add(z__, ae__);
			var ag__ = this.Patient();
			var ah__ = ag__?.BirthDateElement;
			var ai__ = FHIRHelpers_4_0_001.ToDate(ah__);
			var aj__ = condition?.Abatement;
			var ak__ = (aj__ as object);
			var al__ = (ak__ as Range);
			var am__ = al__?.High;
			var an__ = FHIRHelpers_4_0_001.ToQuantity(am__);
			var ao__ = context?.Operators.Add(ai__, an__);
			var ap__ = context?.Operators.Quantity(1m, "year");
			var aq__ = context?.Operators.Add(ao__, ap__);
			var ar__ = context?.Operators.Interval(af__, aq__, true, false);
			var as__ = ar__?.high;
			var at__ = context?.Operators.ConvertDateToDateTime(as__);
			var au__ = this.Patient();
			var av__ = au__?.BirthDateElement;
			var aw__ = FHIRHelpers_4_0_001.ToDate(av__);
			var ax__ = condition?.Abatement;
			var ay__ = (ax__ as object);
			var az__ = (ay__ as Range);
			var ba__ = az__?.Low;
			var bb__ = FHIRHelpers_4_0_001.ToQuantity(ba__);
			var bc__ = context?.Operators.Add(aw__, bb__);
			var bd__ = this.Patient();
			var be__ = bd__?.BirthDateElement;
			var bf__ = FHIRHelpers_4_0_001.ToDate(be__);
			var bg__ = condition?.Abatement;
			var bh__ = (bg__ as object);
			var bi__ = (bh__ as Range);
			var bj__ = bi__?.High;
			var bk__ = FHIRHelpers_4_0_001.ToQuantity(bj__);
			var bl__ = context?.Operators.Add(bf__, bk__);
			var bm__ = context?.Operators.Quantity(1m, "year");
			var bn__ = context?.Operators.Add(bl__, bm__);
			var bo__ = context?.Operators.Interval(bc__, bn__, true, false);
			var bp__ = bo__?.lowClosed;
			var bq__ = this.Patient();
			var br__ = bq__?.BirthDateElement;
			var bs__ = FHIRHelpers_4_0_001.ToDate(br__);
			var bt__ = condition?.Abatement;
			var bu__ = (bt__ as object);
			var bv__ = (bu__ as Range);
			var bw__ = bv__?.Low;
			var bx__ = FHIRHelpers_4_0_001.ToQuantity(bw__);
			var by__ = context?.Operators.Add(bs__, bx__);
			var bz__ = this.Patient();
			var ca__ = bz__?.BirthDateElement;
			var cb__ = FHIRHelpers_4_0_001.ToDate(ca__);
			var cc__ = condition?.Abatement;
			var cd__ = (cc__ as object);
			var ce__ = (cd__ as Range);
			var cf__ = ce__?.High;
			var cg__ = FHIRHelpers_4_0_001.ToQuantity(cf__);
			var ch__ = context?.Operators.Add(cb__, cg__);
			var ci__ = context?.Operators.Quantity(1m, "year");
			var cj__ = context?.Operators.Add(ch__, ci__);
			var ck__ = context?.Operators.Interval(by__, cj__, true, false);
			var cl__ = ck__?.highClosed;

			return context?.Operators.Interval(w__, at__, bp__, cl__);
		}
        else if ((((condition?.Abatement as object) is FhirBoolean as bool?) ?? false))
		{
			var a__ = condition?.Onset;
			var b__ = (a__ as object);
			var c__ = this.Normalize_Interval(b__);
			var d__ = context?.Operators.End(c__);
			var e__ = condition?.RecordedDateElement;
			var f__ = FHIRHelpers_4_0_001.ToDateTime(e__);

			return context?.Operators.Interval(d__, f__, true, false);
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
        if ((context?.Operators.Or(context?.Operators.Or(context?.Operators.Equivalent((FHIRHelpers_4_0_001.ToConcept(condition?.ClinicalStatus) as object), (context?.Operators.ConvertCodeToConcept(this.active()) as object)), context?.Operators.Equivalent((FHIRHelpers_4_0_001.ToConcept(condition?.ClinicalStatus) as object), (context?.Operators.ConvertCodeToConcept(this.recurrence()) as object))), context?.Operators.Equivalent((FHIRHelpers_4_0_001.ToConcept(condition?.ClinicalStatus) as object), (context?.Operators.ConvertCodeToConcept(this.relapse()) as object))) ?? false))
		{
			var a__ = condition?.Onset;
			var b__ = (a__ as object);
			var c__ = this.Normalize_Interval(b__);
			var d__ = context?.Operators.Start(c__);
			var e__ = this.Normalize_Abatement(condition);
			var f__ = context?.Operators.End(e__);

			return context?.Operators.Interval(d__, f__, true, true);
		}
        else
		{
			var a__ = condition?.Onset;
			var b__ = (a__ as object);
			var c__ = this.Normalize_Interval(b__);
			var d__ = context?.Operators.Start(c__);
			var e__ = this.Normalize_Abatement(condition);
			var f__ = context?.Operators.End(e__);

			return context?.Operators.Interval(d__, f__, true, false);
		}
    }


    [CqlDeclaration("GetId")]
    public string GetId(string uri)
	{
		var a_ = context?.Operators.Split(uri, "/");

		return context?.Operators.LastOfList<string>(a_);
	}


    [CqlDeclaration("EncounterDiagnosis")]
    public IEnumerable<Condition> EncounterDiagnosis(Encounter Encounter)
	{
		var n_ = Encounter?.Diagnosis;
		var o_ = (n_ as IEnumerable<Encounter.DiagnosisComponent>);
		var p_ = (Encounter.DiagnosisComponent D) =>
		{
			var k_ = context?.DataRetriever.RetrieveByValueSet<Condition>(null, null);
			var l_ = (Condition C) =>
			{
				var a_ = C?.IdElement;
				var b_ = (a_ as object);
				var c_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(b_);
				var d_ = (c_ as object);
				var e_ = D?.Condition;
				var f_ = e_?.ReferenceElement;
				var g_ = (f_ as object);
				var h_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(g_);
				var i_ = this.GetId(h_);
				var j_ = (i_ as object);

				return context?.Operators.Equal(d_, j_);
			};
			var m_ = context?.Operators.WhereOrNull<Condition>(k_, l_);

			return context?.Operators.SingleOrNull<Condition>(m_);
		};

		return context?.Operators.SelectOrNull<Encounter.DiagnosisComponent, Condition>(o_, p_);
	}


    [CqlDeclaration("GetCondition")]
    public Condition GetCondition(ResourceReference reference)
	{
		var j_ = context?.DataRetriever.RetrieveByValueSet<Condition>(null, null);
		var k_ = (Condition C) =>
		{
			var a_ = C?.IdElement;
			var b_ = (a_ as object);
			var c_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(b_);
			var d_ = (c_ as object);
			var e_ = reference?.ReferenceElement;
			var f_ = (e_ as object);
			var g_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(f_);
			var h_ = this.GetId(g_);
			var i_ = (h_ as object);

			return context?.Operators.Equal(d_, i_);
		};
		var l_ = context?.Operators.WhereOrNull<Condition>(j_, k_);

		return context?.Operators.SingleOrNull<Condition>(l_);
	}


    [CqlDeclaration("GetExtensions")]
    public IEnumerable<Extension> GetExtensions(DomainResource domainResource, string url)
	{
		var i_ = domainResource?.Extension;
		var j_ = (i_ as IEnumerable<Extension>);
		var k_ = (Extension E) =>
		{
			var a_ = E?.Url;
			var b_ = (a_ as object);
			var c_ = context?.Operators?.TypeConverter.Convert<FhirUri>(b_);
			var d_ = (c_ as object);
			var e_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(d_);
			var f_ = (e_ as object);
			var g_ = context?.Operators.Concatenate("http://hl7.org/fhir/us/qicore/StructureDefinition/", url);
			var h_ = (g_ as object);

			return context?.Operators.Equal(f_, h_);
		};
		var l_ = context?.Operators.WhereOrNull<Extension>(j_, k_);
		var m_ = (Extension E) => E;

		return context?.Operators.SelectOrNull<Extension, Extension>(l_, m_);
	}


    [CqlDeclaration("GetExtensions")]
    public IEnumerable<Extension> GetExtensions(Element element, string url)
	{
		var g_ = element?.Extension;
		var h_ = (g_ as IEnumerable<Extension>);
		var i_ = (Extension E) =>
		{
			var a_ = E?.Url;
			var b_ = (a_ as object);
			var c_ = context?.Operators?.TypeConverter.Convert<FhirUri>(b_);
			var d_ = (c_ as object);
			var e_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(d_);
			var f_ = (e_ as object);

			return context?.Operators.Equal(f_, (url as object));
		};
		var j_ = context?.Operators.WhereOrNull<Extension>(h_, i_);
		var k_ = (Extension E) => E;

		return context?.Operators.SelectOrNull<Extension, Extension>(j_, k_);
	}


    [CqlDeclaration("GetExtension")]
    public Extension GetExtension(DomainResource domainResource, string url)
	{
		var a_ = this.GetExtensions(domainResource, url);

		return context?.Operators.SingleOrNull<Extension>(a_);
	}


    [CqlDeclaration("GetExtension")]
    public Extension GetExtension(Element element, string url)
	{
		var a_ = this.GetExtensions(element, url);

		return context?.Operators.SingleOrNull<Extension>(a_);
	}


    [CqlDeclaration("PresentOnAdmissionIndicator")]
    public CodeableConcept PresentOnAdmissionIndicator(Element element)
	{
		var a_ = this.GetExtension(element, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");
		var b_ = a_?.Value;
		var c_ = (b_ as object);

		return (c_ as CodeableConcept);
	}


    [CqlDeclaration("PrincipalDiagnosis")]
    public Condition PrincipalDiagnosis(Encounter Encounter)
	{
		var u_ = Encounter?.Diagnosis;
		var v_ = (u_ as IEnumerable<Encounter.DiagnosisComponent>);
		var w_ = (Encounter.DiagnosisComponent D) =>
		{
			var a_ = D?.RankElement;
			var b_ = (a_ as object);
			var c_ = context?.Operators?.TypeConverter.Convert<Integer>(b_);
			var d_ = FHIRHelpers_4_0_001.ToInteger(c_);
			var e_ = d_;
			var f_ = (int?)1;
			var g_ = f_;

			return context?.Operators.Equal(e_, g_);
		};
		var x_ = context?.Operators.WhereOrNull<Encounter.DiagnosisComponent>(v_, w_);
		var y_ = context?.Operators.SingleOrNull<Encounter.DiagnosisComponent>(x_);
		var z_ = new Encounter.DiagnosisComponent[]
		{
			y_,
		};
		var aa_ = (Encounter.DiagnosisComponent PD) =>
		{
			var r_ = context?.DataRetriever.RetrieveByValueSet<Condition>(null, null);
			var s_ = (Condition C) =>
			{
				var h_ = C?.IdElement;
				var i_ = (h_ as object);
				var j_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(i_);
				var k_ = (j_ as object);
				var l_ = PD?.Condition;
				var m_ = l_?.ReferenceElement;
				var n_ = (m_ as object);
				var o_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(n_);
				var p_ = this.GetId(o_);
				var q_ = (p_ as object);

				return context?.Operators.Equal(k_, q_);
			};
			var t_ = context?.Operators.WhereOrNull<Condition>(r_, s_);

			return context?.Operators.SingleOrNull<Condition>(t_);
		};
		var ab_ = context?.Operators.SelectOrNull<Encounter.DiagnosisComponent, Condition>(z_, aa_);

		return context?.Operators.SingleOrNull<Condition>(ab_);
	}


    [CqlDeclaration("GetLocation")]
    public Location GetLocation(ResourceReference reference)
	{
		var j_ = context?.DataRetriever.RetrieveByValueSet<Location>(null, null);
		var k_ = (Location L) =>
		{
			var a_ = L?.IdElement;
			var b_ = (a_ as object);
			var c_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(b_);
			var d_ = (c_ as object);
			var e_ = reference?.ReferenceElement;
			var f_ = (e_ as object);
			var g_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(f_);
			var h_ = this.GetId(g_);
			var i_ = (h_ as object);

			return context?.Operators.Equal(d_, i_);
		};
		var l_ = context?.Operators.WhereOrNull<Location>(j_, k_);

		return context?.Operators.SingleOrNull<Location>(l_);
	}


    [CqlDeclaration("GetBaseExtensions")]
    public IEnumerable<Extension> GetBaseExtensions(DomainResource domainResource, string url)
	{
		var i_ = domainResource?.Extension;
		var j_ = (i_ as IEnumerable<Extension>);
		var k_ = (Extension E) =>
		{
			var a_ = E?.Url;
			var b_ = (a_ as object);
			var c_ = context?.Operators?.TypeConverter.Convert<FhirUri>(b_);
			var d_ = (c_ as object);
			var e_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(d_);
			var f_ = (e_ as object);
			var g_ = context?.Operators.Concatenate("http://hl7.org/fhir/StructureDefinition/", url);
			var h_ = (g_ as object);

			return context?.Operators.Equal(f_, h_);
		};
		var l_ = context?.Operators.WhereOrNull<Extension>(j_, k_);
		var m_ = (Extension E) => E;

		return context?.Operators.SelectOrNull<Extension, Extension>(l_, m_);
	}


    [CqlDeclaration("GetBaseExtension")]
    public Extension GetBaseExtension(DomainResource domainResource, string url)
	{
		var a_ = this.GetBaseExtensions(domainResource, url);

		return context?.Operators.SingleOrNull<Extension>(a_);
	}


    [CqlDeclaration("BaseExtensions")]
    public IEnumerable<Extension> BaseExtensions(Element element, string id)
	{
		var i_ = element?.Extension;
		var j_ = (i_ as IEnumerable<Extension>);
		var k_ = (Extension E) =>
		{
			var a_ = E?.Url;
			var b_ = (a_ as object);
			var c_ = context?.Operators?.TypeConverter.Convert<FhirUri>(b_);
			var d_ = (c_ as object);
			var e_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(d_);
			var f_ = (e_ as object);
			var g_ = context?.Operators.Concatenate("http://hl7.org/fhir/StructureDefinition/", id);
			var h_ = (g_ as object);

			return context?.Operators.Equal(f_, h_);
		};
		var l_ = context?.Operators.WhereOrNull<Extension>(j_, k_);
		var m_ = (Extension E) => E;

		return context?.Operators.SelectOrNull<Extension, Extension>(l_, m_);
	}


    [CqlDeclaration("BaseExtension")]
    public Extension BaseExtension(Element element, string id)
	{
		var a_ = this.BaseExtensions(element, id);

		return context?.Operators.SingleOrNull<Extension>(a_);
	}


    [CqlDeclaration("GetMedicationCode")]
    public CodeableConcept GetMedicationCode(MedicationRequest request)
    {
        if ((((request?.Medication as object) is CodeableConcept as bool?) ?? false))
		{
			var a__ = request?.Medication;
			var b__ = (a__ as object);

			return (b__ as CodeableConcept);
		}
        else
		{
			var m__ = context?.DataRetriever.RetrieveByValueSet<Medication>(null, null);
			var n__ = (Medication M) =>
			{
				var a__ = M?.IdElement;
				var b__ = (a__ as object);
				var c__ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(b__);
				var d__ = (c__ as object);
				var e__ = request?.Medication;
				var f__ = (e__ as object);
				var g__ = (f__ as ResourceReference);
				var h__ = g__?.ReferenceElement;
				var i__ = (h__ as object);
				var j__ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(i__);
				var k__ = this.GetId(j__);
				var l__ = (k__ as object);

				return context?.Operators.Equal(d__, l__);
			};
			var o__ = context?.Operators.WhereOrNull<Medication>(m__, n__);
			var p__ = context?.Operators.SingleOrNull<Medication>(o__);

			return p__?.Code;
		}
    }


    [CqlDeclaration("HasStart")]
    public bool? HasStart(CqlInterval<CqlDateTime> period)
	{
		var a_ = context?.Operators.Start(period);
		var b_ = (a_ == null);
		var c_ = (bool?)b_;
		var d_ = context?.Operators.Start(period);
		var e_ = (d_ as object);
		var f_ = context?.Operators.Minimum<CqlDateTime>();
		var g_ = (f_ as object);
		var h_ = context?.Operators.Equal(e_, g_);
		var i_ = context?.Operators.Or(c_, h_);

		return context?.Operators.Not(i_);
	}


    [CqlDeclaration("HasEnd")]
    public bool? HasEnd(CqlInterval<CqlDateTime> period)
	{
		var a_ = context?.Operators.End(period);
		var b_ = (a_ == null);
		var c_ = (bool?)b_;
		var d_ = context?.Operators.End(period);
		var e_ = (d_ as object);
		var f_ = context?.Operators.Maximum<CqlDateTime>();
		var g_ = (f_ as object);
		var h_ = context?.Operators.Equal(e_, g_);
		var i_ = context?.Operators.Or(c_, h_);

		return context?.Operators.Not(i_);
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
			? (context?.Operators.End(period))
			: (context?.Operators.Start(period)))
;
		var d_ = context?.Operators.SelectOrNull<CqlInterval<CqlDateTime>, CqlDateTime>(b_, c_);

		return context?.Operators.SingleOrNull<CqlDateTime>(d_);
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
			? (context?.Operators.Start(period))
			: (context?.Operators.End(period)))
;
		var d_ = context?.Operators.SelectOrNull<CqlInterval<CqlDateTime>, CqlDateTime>(b_, c_);

		return context?.Operators.SingleOrNull<CqlDateTime>(d_);
	}


}