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
		var q_ = this.Encounter_Inpatient();
		var r_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(q_, null);
		var s_ = (Encounter EncounterInpatient) =>
		{
			var a_ = (EncounterInpatient?.StatusElement as object);
			var b_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(a_);
			var c_ = (b_ as object);
			var d_ = context?.Operators.Equal(c_, ("finished" as object));
			var e_ = EncounterInpatient?.Period;
			var f_ = FHIRHelpers_4_0_001.ToInterval(e_);
			var g_ = this.LengthInDays(f_);
			var h_ = (g_ as object);
			var i_ = ((int?)120 as object);
			var j_ = context?.Operators.LessOrEqual(h_, i_);
			var k_ = context?.Operators.And(d_, j_);
			var l_ = EncounterInpatient?.Period;
			var m_ = FHIRHelpers_4_0_001.ToInterval(l_);
			var n_ = context?.Operators.End(m_);
			var o_ = this.Measurement_Period();
			var p_ = context?.Operators.ElementInInterval<CqlDateTime>(n_, o_, null);

			return context?.Operators.And(k_, p_);
		};

		return context?.Operators.WhereOrNull<Encounter>(r_, s_);
	}

    [CqlDeclaration("Inpatient Encounter")]
    public IEnumerable<Encounter> Inpatient_Encounter() => __Inpatient_Encounter.Value;

    [CqlDeclaration("ED Visit")]
    public Encounter ED_Visit(Encounter TheEncounter)
	{
		var z_ = this.Emergency_Department_Visit();
		var aa_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(z_, null);
		var ab_ = (Encounter EDVisit) =>
		{
			var a_ = (EDVisit?.StatusElement as object);
			var b_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(a_);
			var c_ = (b_ as object);
			var d_ = context?.Operators.Equal(c_, ("finished" as object));
			var e_ = EDVisit?.Period;
			var f_ = FHIRHelpers_4_0_001.ToInterval(e_);
			var g_ = context?.Operators.End(f_);
			var h_ = TheEncounter?.Period;
			var i_ = FHIRHelpers_4_0_001.ToInterval(h_);
			var j_ = context?.Operators.Start(i_);
			var k_ = context?.Operators.Quantity(1m, "hour");
			var l_ = context?.Operators.Subtract(j_, k_);
			var m_ = TheEncounter?.Period;
			var n_ = FHIRHelpers_4_0_001.ToInterval(m_);
			var o_ = context?.Operators.Start(n_);
			var p_ = context?.Operators.Interval(l_, o_, true, true);
			var q_ = context?.Operators.ElementInInterval<CqlDateTime>(g_, p_, null);
			var r_ = TheEncounter?.Period;
			var s_ = FHIRHelpers_4_0_001.ToInterval(r_);
			var t_ = context?.Operators.Start(s_);
			var u_ = (bool?)(t_ == null);
			var v_ = context?.Operators.Not(u_);
			var w_ = context?.Operators.And(q_, v_);

			return context?.Operators.And(d_, w_);
		};
		var ac_ = context?.Operators.WhereOrNull<Encounter>(aa_, ab_);
		var ad_ = (Encounter @this) =>
		{
			var x_ = @this?.Period;
			var y_ = FHIRHelpers_4_0_001.ToInterval(x_);

			return context?.Operators.End(y_);
		};
		var ae_ = context?.Operators.ListSortBy<Encounter>(ac_, ad_, System.ComponentModel.ListSortDirection.Ascending);

		return context?.Operators.LastOfList<Encounter>(ae_);
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
		var c_ = this.Hospitalization_Locations(TheEncounter);
		var d_ = (Encounter.LocationComponent @this) =>
		{
			var a_ = @this?.Period;
			var b_ = FHIRHelpers_4_0_001.ToInterval(a_);

			return context?.Operators.Start(b_);
		};
		var e_ = context?.Operators.ListSortBy<Encounter.LocationComponent>(c_, d_, System.ComponentModel.ListSortDirection.Ascending);
		var f_ = context?.Operators.FirstOfList<Encounter.LocationComponent>(e_);
		var g_ = f_?.Period;
		var h_ = FHIRHelpers_4_0_001.ToInterval(g_);

		return context?.Operators.Start(h_);
	}


    [CqlDeclaration("HospitalizationWithObservation")]
    public CqlInterval<CqlDateTime> HospitalizationWithObservation(Encounter TheEncounter)
	{
		var fd_ = TheEncounter;
		var fe_ = new Encounter[]
		{
			fd_,
		};
		var ff_ = (Encounter Visit) =>
		{
			var ec_ = this.Emergency_Department_Visit();
			var ed_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(ec_, null);
			var ee_ = (Encounter LastED) =>
			{
				var bi_ = LastED?.Period;
				var bj_ = FHIRHelpers_4_0_001.ToInterval(bi_);
				var bk_ = context?.Operators.End(bj_);
				var bl_ = this.Observation_Services();
				var bm_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(bl_, null);
				var bn_ = (Encounter LastObs) =>
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
					var q_ = (bool?)(p_ == null);
					var r_ = context?.Operators.Not(q_);

					return context?.Operators.And(m_, r_);
				};
				var bo_ = context?.Operators.WhereOrNull<Encounter>(bm_, bn_);
				var bp_ = (Encounter @this) =>
				{
					var s_ = @this?.Period;
					var t_ = FHIRHelpers_4_0_001.ToInterval(s_);

					return context?.Operators.End(t_);
				};
				var bq_ = context?.Operators.ListSortBy<Encounter>(bo_, bp_, System.ComponentModel.ListSortDirection.Ascending);
				var br_ = context?.Operators.LastOfList<Encounter>(bq_);
				var bs_ = br_?.Period;
				var bt_ = FHIRHelpers_4_0_001.ToInterval(bs_);
				var bu_ = context?.Operators.Start(bt_);
				var bv_ = Visit?.Period;
				var bw_ = FHIRHelpers_4_0_001.ToInterval(bv_);
				var bx_ = context?.Operators.Start(bw_);
				var by_ = (bu_ ?? bx_);
				var bz_ = context?.Operators.Quantity(1m, "hour");
				var ca_ = context?.Operators.Subtract(by_, bz_);
				var cb_ = this.Observation_Services();
				var cc_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(cb_, null);
				var cd_ = (Encounter LastObs) =>
				{
					var u_ = LastObs?.Period;
					var v_ = FHIRHelpers_4_0_001.ToInterval(u_);
					var w_ = context?.Operators.End(v_);
					var x_ = Visit?.Period;
					var y_ = FHIRHelpers_4_0_001.ToInterval(x_);
					var z_ = context?.Operators.Start(y_);
					var aa_ = context?.Operators.Quantity(1m, "hour");
					var ab_ = context?.Operators.Subtract(z_, aa_);
					var ac_ = Visit?.Period;
					var ad_ = FHIRHelpers_4_0_001.ToInterval(ac_);
					var ae_ = context?.Operators.Start(ad_);
					var af_ = context?.Operators.Interval(ab_, ae_, true, true);
					var ag_ = context?.Operators.ElementInInterval<CqlDateTime>(w_, af_, null);
					var ah_ = Visit?.Period;
					var ai_ = FHIRHelpers_4_0_001.ToInterval(ah_);
					var aj_ = context?.Operators.Start(ai_);
					var ak_ = (bool?)(aj_ == null);
					var al_ = context?.Operators.Not(ak_);

					return context?.Operators.And(ag_, al_);
				};
				var ce_ = context?.Operators.WhereOrNull<Encounter>(cc_, cd_);
				var cf_ = (Encounter @this) =>
				{
					var am_ = @this?.Period;
					var an_ = FHIRHelpers_4_0_001.ToInterval(am_);

					return context?.Operators.End(an_);
				};
				var cg_ = context?.Operators.ListSortBy<Encounter>(ce_, cf_, System.ComponentModel.ListSortDirection.Ascending);
				var ch_ = context?.Operators.LastOfList<Encounter>(cg_);
				var ci_ = ch_?.Period;
				var cj_ = FHIRHelpers_4_0_001.ToInterval(ci_);
				var ck_ = context?.Operators.Start(cj_);
				var cl_ = Visit?.Period;
				var cm_ = FHIRHelpers_4_0_001.ToInterval(cl_);
				var cn_ = context?.Operators.Start(cm_);
				var co_ = (ck_ ?? cn_);
				var cp_ = context?.Operators.Interval(ca_, co_, true, true);
				var cq_ = context?.Operators.ElementInInterval<CqlDateTime>(bk_, cp_, null);
				var cr_ = this.Observation_Services();
				var cs_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(cr_, null);
				var ct_ = (Encounter LastObs) =>
				{
					var ao_ = LastObs?.Period;
					var ap_ = FHIRHelpers_4_0_001.ToInterval(ao_);
					var aq_ = context?.Operators.End(ap_);
					var ar_ = Visit?.Period;
					var as_ = FHIRHelpers_4_0_001.ToInterval(ar_);
					var at_ = context?.Operators.Start(as_);
					var au_ = context?.Operators.Quantity(1m, "hour");
					var av_ = context?.Operators.Subtract(at_, au_);
					var aw_ = Visit?.Period;
					var ax_ = FHIRHelpers_4_0_001.ToInterval(aw_);
					var ay_ = context?.Operators.Start(ax_);
					var az_ = context?.Operators.Interval(av_, ay_, true, true);
					var ba_ = context?.Operators.ElementInInterval<CqlDateTime>(aq_, az_, null);
					var bb_ = Visit?.Period;
					var bc_ = FHIRHelpers_4_0_001.ToInterval(bb_);
					var bd_ = context?.Operators.Start(bc_);
					var be_ = (bool?)(bd_ == null);
					var bf_ = context?.Operators.Not(be_);

					return context?.Operators.And(ba_, bf_);
				};
				var cu_ = context?.Operators.WhereOrNull<Encounter>(cs_, ct_);
				var cv_ = (Encounter @this) =>
				{
					var bg_ = @this?.Period;
					var bh_ = FHIRHelpers_4_0_001.ToInterval(bg_);

					return context?.Operators.End(bh_);
				};
				var cw_ = context?.Operators.ListSortBy<Encounter>(cu_, cv_, System.ComponentModel.ListSortDirection.Ascending);
				var cx_ = context?.Operators.LastOfList<Encounter>(cw_);
				var cy_ = cx_?.Period;
				var cz_ = FHIRHelpers_4_0_001.ToInterval(cy_);
				var da_ = context?.Operators.Start(cz_);
				var db_ = Visit?.Period;
				var dc_ = FHIRHelpers_4_0_001.ToInterval(db_);
				var dd_ = context?.Operators.Start(dc_);
				var de_ = (bool?)((da_ ?? dd_) == null);
				var df_ = context?.Operators.Not(de_);

				return context?.Operators.And(cq_, df_);
			};
			var ef_ = context?.Operators.WhereOrNull<Encounter>(ed_, ee_);
			var eg_ = (Encounter @this) =>
			{
				var dg_ = @this?.Period;
				var dh_ = FHIRHelpers_4_0_001.ToInterval(dg_);

				return context?.Operators.End(dh_);
			};
			var eh_ = context?.Operators.ListSortBy<Encounter>(ef_, eg_, System.ComponentModel.ListSortDirection.Ascending);
			var ei_ = context?.Operators.LastOfList<Encounter>(eh_);
			var ej_ = ei_?.Period;
			var ek_ = FHIRHelpers_4_0_001.ToInterval(ej_);
			var el_ = context?.Operators.Start(ek_);
			var em_ = this.Observation_Services();
			var en_ = context?.DataRetriever.RetrieveByValueSet<Encounter>(em_, null);
			var eo_ = (Encounter LastObs) =>
			{
				var di_ = LastObs?.Period;
				var dj_ = FHIRHelpers_4_0_001.ToInterval(di_);
				var dk_ = context?.Operators.End(dj_);
				var dl_ = Visit?.Period;
				var dm_ = FHIRHelpers_4_0_001.ToInterval(dl_);
				var dn_ = context?.Operators.Start(dm_);
				var do_ = context?.Operators.Quantity(1m, "hour");
				var dp_ = context?.Operators.Subtract(dn_, do_);
				var dq_ = Visit?.Period;
				var dr_ = FHIRHelpers_4_0_001.ToInterval(dq_);
				var ds_ = context?.Operators.Start(dr_);
				var dt_ = context?.Operators.Interval(dp_, ds_, true, true);
				var du_ = context?.Operators.ElementInInterval<CqlDateTime>(dk_, dt_, null);
				var dv_ = Visit?.Period;
				var dw_ = FHIRHelpers_4_0_001.ToInterval(dv_);
				var dx_ = context?.Operators.Start(dw_);
				var dy_ = (bool?)(dx_ == null);
				var dz_ = context?.Operators.Not(dy_);

				return context?.Operators.And(du_, dz_);
			};
			var ep_ = context?.Operators.WhereOrNull<Encounter>(en_, eo_);
			var eq_ = (Encounter @this) =>
			{
				var ea_ = @this?.Period;
				var eb_ = FHIRHelpers_4_0_001.ToInterval(ea_);

				return context?.Operators.End(eb_);
			};
			var er_ = context?.Operators.ListSortBy<Encounter>(ep_, eq_, System.ComponentModel.ListSortDirection.Ascending);
			var es_ = context?.Operators.LastOfList<Encounter>(er_);
			var et_ = es_?.Period;
			var eu_ = FHIRHelpers_4_0_001.ToInterval(et_);
			var ev_ = context?.Operators.Start(eu_);
			var ew_ = Visit?.Period;
			var ex_ = FHIRHelpers_4_0_001.ToInterval(ew_);
			var ey_ = context?.Operators.Start(ex_);
			var ez_ = (el_ ?? (ev_ ?? ey_));
			var fa_ = Visit?.Period;
			var fb_ = FHIRHelpers_4_0_001.ToInterval(fa_);
			var fc_ = context?.Operators.End(fb_);

			return context?.Operators.Interval(ez_, fc_, true, true);
		};
		var fg_ = context?.Operators.SelectOrNull<Encounter, CqlInterval<CqlDateTime>>(fe_, ff_);

		return context?.Operators.SingleOrNull<CqlInterval<CqlDateTime>>(fg_);
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
			var a__ = this.Patient()?.BirthDateElement;
			var b__ = FHIRHelpers_4_0_001.ToDate(a__);
			var c__ = (Quantity)(choice as Age);
			var d__ = FHIRHelpers_4_0_001.ToQuantity(c__);
			var e__ = context?.Operators.Add(b__, d__);
			var f__ = this.Patient()?.BirthDateElement;
			var g__ = FHIRHelpers_4_0_001.ToDate(f__);
			var h__ = (Quantity)(choice as Age);
			var i__ = FHIRHelpers_4_0_001.ToQuantity(h__);
			var j__ = context?.Operators.Add(g__, i__);
			var k__ = context?.Operators.Quantity(1m, "year");
			var l__ = context?.Operators.Add(j__, k__);
			var m__ = context?.Operators.Interval(e__, l__, true, false);
			var n__ = m__?.low;
			var o__ = context?.Operators.ConvertDateToDateTime(n__);
			var p__ = this.Patient()?.BirthDateElement;
			var q__ = FHIRHelpers_4_0_001.ToDate(p__);
			var r__ = (Quantity)(choice as Age);
			var s__ = FHIRHelpers_4_0_001.ToQuantity(r__);
			var t__ = context?.Operators.Add(q__, s__);
			var u__ = this.Patient()?.BirthDateElement;
			var v__ = FHIRHelpers_4_0_001.ToDate(u__);
			var w__ = (Quantity)(choice as Age);
			var x__ = FHIRHelpers_4_0_001.ToQuantity(w__);
			var y__ = context?.Operators.Add(v__, x__);
			var z__ = context?.Operators.Quantity(1m, "year");
			var aa__ = context?.Operators.Add(y__, z__);
			var ab__ = context?.Operators.Interval(t__, aa__, true, false);
			var ac__ = ab__?.high;
			var ad__ = context?.Operators.ConvertDateToDateTime(ac__);
			var ae__ = this.Patient()?.BirthDateElement;
			var af__ = FHIRHelpers_4_0_001.ToDate(ae__);
			var ag__ = (Quantity)(choice as Age);
			var ah__ = FHIRHelpers_4_0_001.ToQuantity(ag__);
			var ai__ = context?.Operators.Add(af__, ah__);
			var aj__ = this.Patient()?.BirthDateElement;
			var ak__ = FHIRHelpers_4_0_001.ToDate(aj__);
			var al__ = (Quantity)(choice as Age);
			var am__ = FHIRHelpers_4_0_001.ToQuantity(al__);
			var an__ = context?.Operators.Add(ak__, am__);
			var ao__ = context?.Operators.Quantity(1m, "year");
			var ap__ = context?.Operators.Add(an__, ao__);
			var aq__ = context?.Operators.Interval(ai__, ap__, true, false);
			var ar__ = aq__?.lowClosed;
			var as__ = this.Patient()?.BirthDateElement;
			var at__ = FHIRHelpers_4_0_001.ToDate(as__);
			var au__ = (Quantity)(choice as Age);
			var av__ = FHIRHelpers_4_0_001.ToQuantity(au__);
			var aw__ = context?.Operators.Add(at__, av__);
			var ax__ = this.Patient()?.BirthDateElement;
			var ay__ = FHIRHelpers_4_0_001.ToDate(ax__);
			var az__ = (Quantity)(choice as Age);
			var ba__ = FHIRHelpers_4_0_001.ToQuantity(az__);
			var bb__ = context?.Operators.Add(ay__, ba__);
			var bc__ = context?.Operators.Quantity(1m, "year");
			var bd__ = context?.Operators.Add(bb__, bc__);
			var be__ = context?.Operators.Interval(aw__, bd__, true, false);
			var bf__ = be__?.highClosed;

			return context?.Operators.Interval(o__, ad__, ar__, bf__);
		}
        else if (((choice is Range as bool?) ?? false))
		{
			var a__ = this.Patient()?.BirthDateElement;
			var b__ = FHIRHelpers_4_0_001.ToDate(a__);
			var c__ = (choice as Range)?.Low;
			var d__ = FHIRHelpers_4_0_001.ToQuantity(c__);
			var e__ = context?.Operators.Add(b__, d__);
			var f__ = this.Patient()?.BirthDateElement;
			var g__ = FHIRHelpers_4_0_001.ToDate(f__);
			var h__ = (choice as Range)?.High;
			var i__ = FHIRHelpers_4_0_001.ToQuantity(h__);
			var j__ = context?.Operators.Add(g__, i__);
			var k__ = context?.Operators.Quantity(1m, "year");
			var l__ = context?.Operators.Add(j__, k__);
			var m__ = context?.Operators.Interval(e__, l__, true, false);
			var n__ = m__?.low;
			var o__ = context?.Operators.ConvertDateToDateTime(n__);
			var p__ = this.Patient()?.BirthDateElement;
			var q__ = FHIRHelpers_4_0_001.ToDate(p__);
			var r__ = (choice as Range)?.Low;
			var s__ = FHIRHelpers_4_0_001.ToQuantity(r__);
			var t__ = context?.Operators.Add(q__, s__);
			var u__ = this.Patient()?.BirthDateElement;
			var v__ = FHIRHelpers_4_0_001.ToDate(u__);
			var w__ = (choice as Range)?.High;
			var x__ = FHIRHelpers_4_0_001.ToQuantity(w__);
			var y__ = context?.Operators.Add(v__, x__);
			var z__ = context?.Operators.Quantity(1m, "year");
			var aa__ = context?.Operators.Add(y__, z__);
			var ab__ = context?.Operators.Interval(t__, aa__, true, false);
			var ac__ = ab__?.high;
			var ad__ = context?.Operators.ConvertDateToDateTime(ac__);
			var ae__ = this.Patient()?.BirthDateElement;
			var af__ = FHIRHelpers_4_0_001.ToDate(ae__);
			var ag__ = (choice as Range)?.Low;
			var ah__ = FHIRHelpers_4_0_001.ToQuantity(ag__);
			var ai__ = context?.Operators.Add(af__, ah__);
			var aj__ = this.Patient()?.BirthDateElement;
			var ak__ = FHIRHelpers_4_0_001.ToDate(aj__);
			var al__ = (choice as Range)?.High;
			var am__ = FHIRHelpers_4_0_001.ToQuantity(al__);
			var an__ = context?.Operators.Add(ak__, am__);
			var ao__ = context?.Operators.Quantity(1m, "year");
			var ap__ = context?.Operators.Add(an__, ao__);
			var aq__ = context?.Operators.Interval(ai__, ap__, true, false);
			var ar__ = aq__?.lowClosed;
			var as__ = this.Patient()?.BirthDateElement;
			var at__ = FHIRHelpers_4_0_001.ToDate(as__);
			var au__ = (choice as Range)?.Low;
			var av__ = FHIRHelpers_4_0_001.ToQuantity(au__);
			var aw__ = context?.Operators.Add(at__, av__);
			var ax__ = this.Patient()?.BirthDateElement;
			var ay__ = FHIRHelpers_4_0_001.ToDate(ax__);
			var az__ = (choice as Range)?.High;
			var ba__ = FHIRHelpers_4_0_001.ToQuantity(az__);
			var bb__ = context?.Operators.Add(ay__, ba__);
			var bc__ = context?.Operators.Quantity(1m, "year");
			var bd__ = context?.Operators.Add(bb__, bc__);
			var be__ = context?.Operators.Interval(aw__, bd__, true, false);
			var bf__ = be__?.highClosed;

			return context?.Operators.Interval(o__, ad__, ar__, bf__);
		}
        else if (((choice is Timing as bool?) ?? false))
		{
			var a__ = (null as CqlInterval<CqlDateTime>);

			return context?.Operators.Message<CqlInterval<CqlDateTime>>(a__, "1", "Error", "Cannot compute a single interval from a Timing type");
		}
        else if (((choice is FhirString as bool?) ?? false))
		{
			var a__ = (null as CqlInterval<CqlDateTime>);

			return context?.Operators.Message<CqlInterval<CqlDateTime>>(a__, "1", "Error", "Cannot compute an interval from a String value");
		}
        else
            return (null as CqlInterval<CqlDateTime>);
    }


    [CqlDeclaration("Normalize Abatement")]
    public CqlInterval<CqlDateTime> Normalize_Abatement(Condition condition)
    {
        if ((((condition?.Abatement as object) is FhirDateTime as bool?) ?? false))
		{
			var a__ = ((condition?.Abatement as object) as FhirDateTime);
			var b__ = FHIRHelpers_4_0_001.ToDateTime(a__);
			var c__ = ((condition?.Abatement as object) as FhirDateTime);
			var d__ = FHIRHelpers_4_0_001.ToDateTime(c__);

			return context?.Operators.Interval(b__, d__, true, true);
		}
        else if ((((condition?.Abatement as object) is Period as bool?) ?? false))
		{
			var a__ = ((condition?.Abatement as object) as Period);

			return FHIRHelpers_4_0_001.ToInterval(a__);
		}
        else if ((((condition?.Abatement as object) is FhirString as bool?) ?? false))
		{
			var a__ = (null as CqlInterval<CqlDateTime>);

			return context?.Operators.Message<CqlInterval<CqlDateTime>>(a__, "1", "Error", "Cannot compute an interval from a String value");
		}
        else if ((((condition?.Abatement as object) is Age as bool?) ?? false))
		{
			var a__ = this.Patient()?.BirthDateElement;
			var b__ = FHIRHelpers_4_0_001.ToDate(a__);
			var c__ = (Quantity)((condition?.Abatement as object) as Age);
			var d__ = FHIRHelpers_4_0_001.ToQuantity(c__);
			var e__ = context?.Operators.Add(b__, d__);
			var f__ = this.Patient()?.BirthDateElement;
			var g__ = FHIRHelpers_4_0_001.ToDate(f__);
			var h__ = (Quantity)((condition?.Abatement as object) as Age);
			var i__ = FHIRHelpers_4_0_001.ToQuantity(h__);
			var j__ = context?.Operators.Add(g__, i__);
			var k__ = context?.Operators.Quantity(1m, "year");
			var l__ = context?.Operators.Add(j__, k__);
			var m__ = context?.Operators.Interval(e__, l__, true, false);
			var n__ = m__?.low;
			var o__ = context?.Operators.ConvertDateToDateTime(n__);
			var p__ = this.Patient()?.BirthDateElement;
			var q__ = FHIRHelpers_4_0_001.ToDate(p__);
			var r__ = (Quantity)((condition?.Abatement as object) as Age);
			var s__ = FHIRHelpers_4_0_001.ToQuantity(r__);
			var t__ = context?.Operators.Add(q__, s__);
			var u__ = this.Patient()?.BirthDateElement;
			var v__ = FHIRHelpers_4_0_001.ToDate(u__);
			var w__ = (Quantity)((condition?.Abatement as object) as Age);
			var x__ = FHIRHelpers_4_0_001.ToQuantity(w__);
			var y__ = context?.Operators.Add(v__, x__);
			var z__ = context?.Operators.Quantity(1m, "year");
			var aa__ = context?.Operators.Add(y__, z__);
			var ab__ = context?.Operators.Interval(t__, aa__, true, false);
			var ac__ = ab__?.high;
			var ad__ = context?.Operators.ConvertDateToDateTime(ac__);
			var ae__ = this.Patient()?.BirthDateElement;
			var af__ = FHIRHelpers_4_0_001.ToDate(ae__);
			var ag__ = (Quantity)((condition?.Abatement as object) as Age);
			var ah__ = FHIRHelpers_4_0_001.ToQuantity(ag__);
			var ai__ = context?.Operators.Add(af__, ah__);
			var aj__ = this.Patient()?.BirthDateElement;
			var ak__ = FHIRHelpers_4_0_001.ToDate(aj__);
			var al__ = (Quantity)((condition?.Abatement as object) as Age);
			var am__ = FHIRHelpers_4_0_001.ToQuantity(al__);
			var an__ = context?.Operators.Add(ak__, am__);
			var ao__ = context?.Operators.Quantity(1m, "year");
			var ap__ = context?.Operators.Add(an__, ao__);
			var aq__ = context?.Operators.Interval(ai__, ap__, true, false);
			var ar__ = aq__?.lowClosed;
			var as__ = this.Patient()?.BirthDateElement;
			var at__ = FHIRHelpers_4_0_001.ToDate(as__);
			var au__ = (Quantity)((condition?.Abatement as object) as Age);
			var av__ = FHIRHelpers_4_0_001.ToQuantity(au__);
			var aw__ = context?.Operators.Add(at__, av__);
			var ax__ = this.Patient()?.BirthDateElement;
			var ay__ = FHIRHelpers_4_0_001.ToDate(ax__);
			var az__ = (Quantity)((condition?.Abatement as object) as Age);
			var ba__ = FHIRHelpers_4_0_001.ToQuantity(az__);
			var bb__ = context?.Operators.Add(ay__, ba__);
			var bc__ = context?.Operators.Quantity(1m, "year");
			var bd__ = context?.Operators.Add(bb__, bc__);
			var be__ = context?.Operators.Interval(aw__, bd__, true, false);
			var bf__ = be__?.highClosed;

			return context?.Operators.Interval(o__, ad__, ar__, bf__);
		}
        else if ((((condition?.Abatement as object) is Range as bool?) ?? false))
		{
			var a__ = this.Patient()?.BirthDateElement;
			var b__ = FHIRHelpers_4_0_001.ToDate(a__);
			var c__ = ((condition?.Abatement as object) as Range)?.Low;
			var d__ = FHIRHelpers_4_0_001.ToQuantity(c__);
			var e__ = context?.Operators.Add(b__, d__);
			var f__ = this.Patient()?.BirthDateElement;
			var g__ = FHIRHelpers_4_0_001.ToDate(f__);
			var h__ = ((condition?.Abatement as object) as Range)?.High;
			var i__ = FHIRHelpers_4_0_001.ToQuantity(h__);
			var j__ = context?.Operators.Add(g__, i__);
			var k__ = context?.Operators.Quantity(1m, "year");
			var l__ = context?.Operators.Add(j__, k__);
			var m__ = context?.Operators.Interval(e__, l__, true, false);
			var n__ = m__?.low;
			var o__ = context?.Operators.ConvertDateToDateTime(n__);
			var p__ = this.Patient()?.BirthDateElement;
			var q__ = FHIRHelpers_4_0_001.ToDate(p__);
			var r__ = ((condition?.Abatement as object) as Range)?.Low;
			var s__ = FHIRHelpers_4_0_001.ToQuantity(r__);
			var t__ = context?.Operators.Add(q__, s__);
			var u__ = this.Patient()?.BirthDateElement;
			var v__ = FHIRHelpers_4_0_001.ToDate(u__);
			var w__ = ((condition?.Abatement as object) as Range)?.High;
			var x__ = FHIRHelpers_4_0_001.ToQuantity(w__);
			var y__ = context?.Operators.Add(v__, x__);
			var z__ = context?.Operators.Quantity(1m, "year");
			var aa__ = context?.Operators.Add(y__, z__);
			var ab__ = context?.Operators.Interval(t__, aa__, true, false);
			var ac__ = ab__?.high;
			var ad__ = context?.Operators.ConvertDateToDateTime(ac__);
			var ae__ = this.Patient()?.BirthDateElement;
			var af__ = FHIRHelpers_4_0_001.ToDate(ae__);
			var ag__ = ((condition?.Abatement as object) as Range)?.Low;
			var ah__ = FHIRHelpers_4_0_001.ToQuantity(ag__);
			var ai__ = context?.Operators.Add(af__, ah__);
			var aj__ = this.Patient()?.BirthDateElement;
			var ak__ = FHIRHelpers_4_0_001.ToDate(aj__);
			var al__ = ((condition?.Abatement as object) as Range)?.High;
			var am__ = FHIRHelpers_4_0_001.ToQuantity(al__);
			var an__ = context?.Operators.Add(ak__, am__);
			var ao__ = context?.Operators.Quantity(1m, "year");
			var ap__ = context?.Operators.Add(an__, ao__);
			var aq__ = context?.Operators.Interval(ai__, ap__, true, false);
			var ar__ = aq__?.lowClosed;
			var as__ = this.Patient()?.BirthDateElement;
			var at__ = FHIRHelpers_4_0_001.ToDate(as__);
			var au__ = ((condition?.Abatement as object) as Range)?.Low;
			var av__ = FHIRHelpers_4_0_001.ToQuantity(au__);
			var aw__ = context?.Operators.Add(at__, av__);
			var ax__ = this.Patient()?.BirthDateElement;
			var ay__ = FHIRHelpers_4_0_001.ToDate(ax__);
			var az__ = ((condition?.Abatement as object) as Range)?.High;
			var ba__ = FHIRHelpers_4_0_001.ToQuantity(az__);
			var bb__ = context?.Operators.Add(ay__, ba__);
			var bc__ = context?.Operators.Quantity(1m, "year");
			var bd__ = context?.Operators.Add(bb__, bc__);
			var be__ = context?.Operators.Interval(aw__, bd__, true, false);
			var bf__ = be__?.highClosed;

			return context?.Operators.Interval(o__, ad__, ar__, bf__);
		}
        else if ((((condition?.Abatement as object) is FhirBoolean as bool?) ?? false))
		{
			var a__ = (condition?.Onset as object);
			var b__ = this.Normalize_Interval(a__);
			var c__ = context?.Operators.End(b__);
			var d__ = condition?.RecordedDateElement;
			var e__ = FHIRHelpers_4_0_001.ToDateTime(d__);

			return context?.Operators.Interval(c__, e__, true, false);
		}
        else
            return (null as CqlInterval<CqlDateTime>);
    }


    [CqlDeclaration("Prevalence Period")]
    public CqlInterval<CqlDateTime> Prevalence_Period(Condition condition)
    {
        if ((context?.Operators.Or(context?.Operators.Or(context?.Operators.Equivalent((FHIRHelpers_4_0_001.ToConcept(condition?.ClinicalStatus) as object), (context?.Operators.ConvertCodeToConcept(this.active()) as object)), context?.Operators.Equivalent((FHIRHelpers_4_0_001.ToConcept(condition?.ClinicalStatus) as object), (context?.Operators.ConvertCodeToConcept(this.recurrence()) as object))), context?.Operators.Equivalent((FHIRHelpers_4_0_001.ToConcept(condition?.ClinicalStatus) as object), (context?.Operators.ConvertCodeToConcept(this.relapse()) as object))) ?? false))
		{
			var a__ = (condition?.Onset as object);
			var b__ = this.Normalize_Interval(a__);
			var c__ = context?.Operators.Start(b__);
			var d__ = this.Normalize_Abatement(condition);
			var e__ = context?.Operators.End(d__);

			return context?.Operators.Interval(c__, e__, true, true);
		}
        else
		{
			var a__ = (condition?.Onset as object);
			var b__ = this.Normalize_Interval(a__);
			var c__ = context?.Operators.Start(b__);
			var d__ = this.Normalize_Abatement(condition);
			var e__ = context?.Operators.End(d__);

			return context?.Operators.Interval(c__, e__, true, false);
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
		var k_ = (Encounter?.Diagnosis as IEnumerable<Encounter.DiagnosisComponent>);
		var l_ = (Encounter.DiagnosisComponent D) =>
		{
			var h_ = context?.DataRetriever.RetrieveByValueSet<Condition>(null, null);
			var i_ = (Condition C) =>
			{
				var a_ = (C?.IdElement as object);
				var b_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(a_);
				var c_ = (b_ as object);
				var d_ = (D?.Condition?.ReferenceElement as object);
				var e_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(d_);
				var f_ = this.GetId(e_);
				var g_ = (f_ as object);

				return context?.Operators.Equal(c_, g_);
			};
			var j_ = context?.Operators.WhereOrNull<Condition>(h_, i_);

			return context?.Operators.SingleOrNull<Condition>(j_);
		};

		return context?.Operators.SelectOrNull<Encounter.DiagnosisComponent, Condition>(k_, l_);
	}


    [CqlDeclaration("GetCondition")]
    public Condition GetCondition(ResourceReference reference)
	{
		var h_ = context?.DataRetriever.RetrieveByValueSet<Condition>(null, null);
		var i_ = (Condition C) =>
		{
			var a_ = (C?.IdElement as object);
			var b_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(a_);
			var c_ = (b_ as object);
			var d_ = (reference?.ReferenceElement as object);
			var e_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(d_);
			var f_ = this.GetId(e_);
			var g_ = (f_ as object);

			return context?.Operators.Equal(c_, g_);
		};
		var j_ = context?.Operators.WhereOrNull<Condition>(h_, i_);

		return context?.Operators.SingleOrNull<Condition>(j_);
	}


    [CqlDeclaration("GetExtensions")]
    public IEnumerable<Extension> GetExtensions(DomainResource domainResource, string url)
	{
		var g_ = (domainResource?.Extension as IEnumerable<Extension>);
		var h_ = (Extension E) =>
		{
			var a_ = (E?.Url as object);
			var b_ = context?.Operators?.TypeConverter.Convert<FhirUri>(a_);
			var c_ = (b_ as object);
			var d_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(c_);
			var e_ = (d_ as object);
			var f_ = (context?.Operators.Concatenate("http://hl7.org/fhir/us/qicore/StructureDefinition/", url) as object);

			return context?.Operators.Equal(e_, f_);
		};
		var i_ = context?.Operators.WhereOrNull<Extension>(g_, h_);
		var j_ = (Extension E) => E;

		return context?.Operators.SelectOrNull<Extension, Extension>(i_, j_);
	}


    [CqlDeclaration("GetExtensions")]
    public IEnumerable<Extension> GetExtensions(Element element, string url)
	{
		var f_ = (element?.Extension as IEnumerable<Extension>);
		var g_ = (Extension E) =>
		{
			var a_ = (E?.Url as object);
			var b_ = context?.Operators?.TypeConverter.Convert<FhirUri>(a_);
			var c_ = (b_ as object);
			var d_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(c_);
			var e_ = (d_ as object);

			return context?.Operators.Equal(e_, (url as object));
		};
		var h_ = context?.Operators.WhereOrNull<Extension>(f_, g_);
		var i_ = (Extension E) => E;

		return context?.Operators.SelectOrNull<Extension, Extension>(h_, i_);
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
    public CodeableConcept PresentOnAdmissionIndicator(Element element) =>
		((this.GetExtension(element, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission")?.Value as object) as CodeableConcept);


    [CqlDeclaration("PrincipalDiagnosis")]
    public Condition PrincipalDiagnosis(Encounter Encounter)
	{
		var p_ = (Encounter?.Diagnosis as IEnumerable<Encounter.DiagnosisComponent>);
		var q_ = (Encounter.DiagnosisComponent D) =>
		{
			var a_ = (D?.RankElement as object);
			var b_ = context?.Operators?.TypeConverter.Convert<Integer>(a_);
			var c_ = FHIRHelpers_4_0_001.ToInteger(b_);
			var d_ = (c_ as object);
			var e_ = ((int?)1 as object);

			return context?.Operators.Equal(d_, e_);
		};
		var r_ = context?.Operators.WhereOrNull<Encounter.DiagnosisComponent>(p_, q_);
		var s_ = context?.Operators.SingleOrNull<Encounter.DiagnosisComponent>(r_);
		var t_ = new Encounter.DiagnosisComponent[]
		{
			s_,
		};
		var u_ = (Encounter.DiagnosisComponent PD) =>
		{
			var m_ = context?.DataRetriever.RetrieveByValueSet<Condition>(null, null);
			var n_ = (Condition C) =>
			{
				var f_ = (C?.IdElement as object);
				var g_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(f_);
				var h_ = (g_ as object);
				var i_ = (PD?.Condition?.ReferenceElement as object);
				var j_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(i_);
				var k_ = this.GetId(j_);
				var l_ = (k_ as object);

				return context?.Operators.Equal(h_, l_);
			};
			var o_ = context?.Operators.WhereOrNull<Condition>(m_, n_);

			return context?.Operators.SingleOrNull<Condition>(o_);
		};
		var v_ = context?.Operators.SelectOrNull<Encounter.DiagnosisComponent, Condition>(t_, u_);

		return context?.Operators.SingleOrNull<Condition>(v_);
	}


    [CqlDeclaration("GetLocation")]
    public Location GetLocation(ResourceReference reference)
	{
		var h_ = context?.DataRetriever.RetrieveByValueSet<Location>(null, null);
		var i_ = (Location L) =>
		{
			var a_ = (L?.IdElement as object);
			var b_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(a_);
			var c_ = (b_ as object);
			var d_ = (reference?.ReferenceElement as object);
			var e_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(d_);
			var f_ = this.GetId(e_);
			var g_ = (f_ as object);

			return context?.Operators.Equal(c_, g_);
		};
		var j_ = context?.Operators.WhereOrNull<Location>(h_, i_);

		return context?.Operators.SingleOrNull<Location>(j_);
	}


    [CqlDeclaration("GetBaseExtensions")]
    public IEnumerable<Extension> GetBaseExtensions(DomainResource domainResource, string url)
	{
		var g_ = (domainResource?.Extension as IEnumerable<Extension>);
		var h_ = (Extension E) =>
		{
			var a_ = (E?.Url as object);
			var b_ = context?.Operators?.TypeConverter.Convert<FhirUri>(a_);
			var c_ = (b_ as object);
			var d_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(c_);
			var e_ = (d_ as object);
			var f_ = (context?.Operators.Concatenate("http://hl7.org/fhir/StructureDefinition/", url) as object);

			return context?.Operators.Equal(e_, f_);
		};
		var i_ = context?.Operators.WhereOrNull<Extension>(g_, h_);
		var j_ = (Extension E) => E;

		return context?.Operators.SelectOrNull<Extension, Extension>(i_, j_);
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
		var g_ = (element?.Extension as IEnumerable<Extension>);
		var h_ = (Extension E) =>
		{
			var a_ = (E?.Url as object);
			var b_ = context?.Operators?.TypeConverter.Convert<FhirUri>(a_);
			var c_ = (b_ as object);
			var d_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(c_);
			var e_ = (d_ as object);
			var f_ = (context?.Operators.Concatenate("http://hl7.org/fhir/StructureDefinition/", id) as object);

			return context?.Operators.Equal(e_, f_);
		};
		var i_ = context?.Operators.WhereOrNull<Extension>(g_, h_);
		var j_ = (Extension E) => E;

		return context?.Operators.SelectOrNull<Extension, Extension>(i_, j_);
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
            return ((request?.Medication as object) as CodeableConcept);
        else
		{
			var h__ = context?.DataRetriever.RetrieveByValueSet<Medication>(null, null);
			var i__ = (Medication M) =>
			{
				var a__ = (M?.IdElement as object);
				var b__ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(a__);
				var c__ = (b__ as object);
				var d__ = (((request?.Medication as object) as ResourceReference)?.ReferenceElement as object);
				var e__ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(d__);
				var f__ = this.GetId(e__);
				var g__ = (f__ as object);

				return context?.Operators.Equal(c__, g__);
			};
			var j__ = context?.Operators.WhereOrNull<Medication>(h__, i__);
			var k__ = context?.Operators.SingleOrNull<Medication>(j__);

			return k__?.Code;
		}
    }


    [CqlDeclaration("HasStart")]
    public bool? HasStart(CqlInterval<CqlDateTime> period)
	{
		var a_ = (bool?)(context?.Operators.Start(period) == null);
		var b_ = (context?.Operators.Start(period) as object);
		var c_ = (context?.Operators.Minimum<CqlDateTime>() as object);
		var d_ = context?.Operators.Equal(b_, c_);
		var e_ = context?.Operators.Or(a_, d_);

		return context?.Operators.Not(e_);
	}


    [CqlDeclaration("HasEnd")]
    public bool? HasEnd(CqlInterval<CqlDateTime> period)
	{
		var a_ = (bool?)(context?.Operators.End(period) == null);
		var b_ = (context?.Operators.End(period) as object);
		var c_ = (context?.Operators.Maximum<CqlDateTime>() as object);
		var d_ = context?.Operators.Equal(b_, c_);
		var e_ = context?.Operators.Or(a_, d_);

		return context?.Operators.Not(e_);
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