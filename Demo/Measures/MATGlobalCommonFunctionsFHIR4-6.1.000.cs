using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
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

    private CqlValueSet Emergency_Department_Visit_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", 
			null);
    }

    [CqlDeclaration("Emergency Department Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292")]
    public CqlValueSet Emergency_Department_Visit() => __Emergency_Department_Visit.Value;

    private CqlValueSet Encounter_Inpatient_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", 
			null);
    }

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
    public CqlValueSet Encounter_Inpatient() => __Encounter_Inpatient.Value;

    private CqlValueSet Observation_Services_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", 
			null);
    }

    [CqlDeclaration("Observation Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143")]
    public CqlValueSet Observation_Services() => __Observation_Services.Value;

    private CqlValueSet Present_on_Admission_or_Clinically_Undetermined_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.197", 
			null);
    }

    [CqlDeclaration("Present on Admission or Clinically Undetermined")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.197")]
    public CqlValueSet Present_on_Admission_or_Clinically_Undetermined() => __Present_on_Admission_or_Clinically_Undetermined.Value;

    private CqlCode active_Value()
    {
        return new CqlCode("active", 
			"http://terminology.hl7.org/CodeSystem/condition-clinical", 
			null, 
			null);
    }

    [CqlDeclaration("active")]
    public CqlCode active() => __active.Value;

    private CqlCode allergy_active_Value()
    {
        return new CqlCode("active", 
			"http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", 
			null, 
			null);
    }

    [CqlDeclaration("allergy-active")]
    public CqlCode allergy_active() => __allergy_active.Value;

    private CqlCode allergy_confirmed_Value()
    {
        return new CqlCode("confirmed", 
			"http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", 
			null, 
			null);
    }

    [CqlDeclaration("allergy-confirmed")]
    public CqlCode allergy_confirmed() => __allergy_confirmed.Value;

    private CqlCode allergy_inactive_Value()
    {
        return new CqlCode("inactive", 
			"http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", 
			null, 
			null);
    }

    [CqlDeclaration("allergy-inactive")]
    public CqlCode allergy_inactive() => __allergy_inactive.Value;

    private CqlCode allergy_refuted_Value()
    {
        return new CqlCode("refuted", 
			"http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", 
			null, 
			null);
    }

    [CqlDeclaration("allergy-refuted")]
    public CqlCode allergy_refuted() => __allergy_refuted.Value;

    private CqlCode allergy_resolved_Value()
    {
        return new CqlCode("resolved", 
			"http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", 
			null, 
			null);
    }

    [CqlDeclaration("allergy-resolved")]
    public CqlCode allergy_resolved() => __allergy_resolved.Value;

    private CqlCode allergy_unconfirmed_Value()
    {
        return new CqlCode("unconfirmed", 
			"http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", 
			null, 
			null);
    }

    [CqlDeclaration("allergy-unconfirmed")]
    public CqlCode allergy_unconfirmed() => __allergy_unconfirmed.Value;

    private CqlCode Billing_Value()
    {
        return new CqlCode("billing", 
			"http://terminology.hl7.org/CodeSystem/diagnosis-role", 
			null, 
			null);
    }

    [CqlDeclaration("Billing")]
    public CqlCode Billing() => __Billing.Value;

    private CqlCode Birthdate_Value()
    {
        return new CqlCode("21112-8", 
			"http://loinc.org", 
			null, 
			null);
    }

    [CqlDeclaration("Birthdate")]
    public CqlCode Birthdate() => __Birthdate.Value;

    private CqlCode Community_Value()
    {
        return new CqlCode("community", 
			"http://terminology.hl7.org/CodeSystem/medicationrequest-category", 
			null, 
			null);
    }

    [CqlDeclaration("Community")]
    public CqlCode Community() => __Community.Value;

    private CqlCode confirmed_Value()
    {
        return new CqlCode("confirmed", 
			"http://terminology.hl7.org/CodeSystem/condition-ver-status", 
			null, 
			null);
    }

    [CqlDeclaration("confirmed")]
    public CqlCode confirmed() => __confirmed.Value;

    private CqlCode Dead_Value()
    {
        return new CqlCode("419099009", 
			"http://snomed.info/sct", 
			null, 
			null);
    }

    [CqlDeclaration("Dead")]
    public CqlCode Dead() => __Dead.Value;

    private CqlCode differential_Value()
    {
        return new CqlCode("differential", 
			"http://terminology.hl7.org/CodeSystem/condition-ver-status", 
			null, 
			null);
    }

    [CqlDeclaration("differential")]
    public CqlCode differential() => __differential.Value;

    private CqlCode Discharge_Value()
    {
        return new CqlCode("discharge", 
			"http://terminology.hl7.org/CodeSystem/medicationrequest-category", 
			null, 
			null);
    }

    [CqlDeclaration("Discharge")]
    public CqlCode Discharge() => __Discharge.Value;

    private CqlCode entered_in_error_Value()
    {
        return new CqlCode("entered-in-error", 
			"http://terminology.hl7.org/CodeSystem/condition-ver-status", 
			null, 
			null);
    }

    [CqlDeclaration("entered-in-error")]
    public CqlCode entered_in_error() => __entered_in_error.Value;

    private CqlCode ER_Value()
    {
        return new CqlCode("ER", 
			"http://terminology.hl7.org/CodeSystem/v3-RoleCode", 
			null, 
			null);
    }

    [CqlDeclaration("ER")]
    public CqlCode ER() => __ER.Value;

    private CqlCode ICU_Value()
    {
        return new CqlCode("ICU", 
			"http://terminology.hl7.org/CodeSystem/v3-RoleCode", 
			null, 
			null);
    }

    [CqlDeclaration("ICU")]
    public CqlCode ICU() => __ICU.Value;

    private CqlCode inactive_Value()
    {
        return new CqlCode("inactive", 
			"http://terminology.hl7.org/CodeSystem/condition-clinical", 
			null, 
			null);
    }

    [CqlDeclaration("inactive")]
    public CqlCode inactive() => __inactive.Value;

    private CqlCode provisional_Value()
    {
        return new CqlCode("provisional", 
			"http://terminology.hl7.org/CodeSystem/condition-ver-status", 
			null, 
			null);
    }

    [CqlDeclaration("provisional")]
    public CqlCode provisional() => __provisional.Value;

    private CqlCode recurrence_Value()
    {
        return new CqlCode("recurrence", 
			"http://terminology.hl7.org/CodeSystem/condition-clinical", 
			null, 
			null);
    }

    [CqlDeclaration("recurrence")]
    public CqlCode recurrence() => __recurrence.Value;

    private CqlCode refuted_Value()
    {
        return new CqlCode("refuted", 
			"http://terminology.hl7.org/CodeSystem/condition-ver-status", 
			null, 
			null);
    }

    [CqlDeclaration("refuted")]
    public CqlCode refuted() => __refuted.Value;

    private CqlCode relapse_Value()
    {
        return new CqlCode("relapse", 
			"http://terminology.hl7.org/CodeSystem/condition-clinical", 
			null, 
			null);
    }

    [CqlDeclaration("relapse")]
    public CqlCode relapse() => __relapse.Value;

    private CqlCode remission_Value()
    {
        return new CqlCode("remission", 
			"http://terminology.hl7.org/CodeSystem/condition-clinical", 
			null, 
			null);
    }

    [CqlDeclaration("remission")]
    public CqlCode remission() => __remission.Value;

    private CqlCode resolved_Value()
    {
        return new CqlCode("resolved", 
			"http://terminology.hl7.org/CodeSystem/condition-clinical", 
			null, 
			null);
    }

    [CqlDeclaration("resolved")]
    public CqlCode resolved() => __resolved.Value;

    private CqlCode unconfirmed_Value()
    {
        return new CqlCode("unconfirmed", 
			"http://terminology.hl7.org/CodeSystem/condition-ver-status", 
			null, 
			null);
    }

    [CqlDeclaration("unconfirmed")]
    public CqlCode unconfirmed() => __unconfirmed.Value;

    private CqlCode[] ConditionClinicalStatusCodes_Value()
    {
        var a_ = new CqlCode("active", 
			"http://terminology.hl7.org/CodeSystem/condition-clinical", 
			null, 
			null);
        var b_ = new CqlCode("inactive", 
			"http://terminology.hl7.org/CodeSystem/condition-clinical", 
			null, 
			null);
        var c_ = new CqlCode("recurrence", 
			"http://terminology.hl7.org/CodeSystem/condition-clinical", 
			null, 
			null);
        var d_ = new CqlCode("relapse", 
			"http://terminology.hl7.org/CodeSystem/condition-clinical", 
			null, 
			null);
        var e_ = new CqlCode("remission", 
			"http://terminology.hl7.org/CodeSystem/condition-clinical", 
			null, 
			null);
        var f_ = new CqlCode("resolved", 
			"http://terminology.hl7.org/CodeSystem/condition-clinical", 
			null, 
			null);
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
        var a_ = new CqlCode("active", 
			"http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", 
			null, 
			null);
        var b_ = new CqlCode("inactive", 
			"http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", 
			null, 
			null);
        var c_ = new CqlCode("resolved", 
			"http://terminology.hl7.org/CodeSystem/allergyintolerance-clinical", 
			null, 
			null);
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
        var a_ = new CqlCode("confirmed", 
			"http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", 
			null, 
			null);
        var b_ = new CqlCode("refuted", 
			"http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", 
			null, 
			null);
        var c_ = new CqlCode("unconfirmed", 
			"http://terminology.hl7.org/CodeSystem/allergyintolerance-verification", 
			null, 
			null);
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
        var a_ = new CqlCode("billing", 
			"http://terminology.hl7.org/CodeSystem/diagnosis-role", 
			null, 
			null);
        return new CqlCode[]
		{
			a_,
		};
    }
    [CqlDeclaration("Diagnosis Role")]
    public CqlCode[] Diagnosis_Role() => __Diagnosis_Role.Value;

    private CqlCode[] LOINC_Value()
    {
        var a_ = new CqlCode("21112-8", 
			"http://loinc.org", 
			null, 
			null);
        return new CqlCode[]
		{
			a_,
		};
    }
    [CqlDeclaration("LOINC")]
    public CqlCode[] LOINC() => __LOINC.Value;

    private CqlCode[] MedicationRequestCategory_Value()
    {
        var a_ = new CqlCode("community", 
			"http://terminology.hl7.org/CodeSystem/medicationrequest-category", 
			null, 
			null);
        var b_ = new CqlCode("discharge", 
			"http://terminology.hl7.org/CodeSystem/medicationrequest-category", 
			null, 
			null);
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
        var a_ = new CqlCode("confirmed", 
			"http://terminology.hl7.org/CodeSystem/condition-ver-status", 
			null, 
			null);
        var b_ = new CqlCode("differential", 
			"http://terminology.hl7.org/CodeSystem/condition-ver-status", 
			null, 
			null);
        var c_ = new CqlCode("entered-in-error", 
			"http://terminology.hl7.org/CodeSystem/condition-ver-status", 
			null, 
			null);
        var d_ = new CqlCode("provisional", 
			"http://terminology.hl7.org/CodeSystem/condition-ver-status", 
			null, 
			null);
        var e_ = new CqlCode("refuted", 
			"http://terminology.hl7.org/CodeSystem/condition-ver-status", 
			null, 
			null);
        var f_ = new CqlCode("unconfirmed", 
			"http://terminology.hl7.org/CodeSystem/condition-ver-status", 
			null, 
			null);
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
        var a_ = new CqlCode("419099009", 
			"http://snomed.info/sct", 
			null, 
			null);
        return new CqlCode[]
		{
			a_,
		};
    }
    [CqlDeclaration("SNOMEDCT")]
    public CqlCode[] SNOMEDCT() => __SNOMEDCT.Value;

    private CqlCode[] RoleCode_Value()
    {
        var a_ = new CqlCode("ER", 
			"http://terminology.hl7.org/CodeSystem/v3-RoleCode", 
			null, 
			null);
        var b_ = new CqlCode("ICU", 
			"http://terminology.hl7.org/CodeSystem/v3-RoleCode", 
			null, 
			null);
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
        return ((CqlInterval<CqlDateTime>)context.ResolveParameter("MATGlobalCommonFunctionsFHIR4-6.1.000", 
			"Measurement Period", 
			(context?.Operators.Interval(context?.Operators.DateTime(((int?)2019), 
					((int?)1), 
					((int?)1), 
					((int?)0), 
					((int?)0), 
					((int?)0), 
					((int?)0), 
					context?.Operators.ConvertIntegerToDecimal(default)), 
				context?.Operators.DateTime(((int?)2020), 
					((int?)1), 
					((int?)1), 
					((int?)0), 
					((int?)0), 
					((int?)0), 
					((int?)0), 
					context?.Operators.ConvertIntegerToDecimal(default)), 
				true, 
				false) as object)));
    }

    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period() => __Measurement_Period.Value;

    private Patient Patient_Value()
    {
        var a_ = context?.Operators.RetrieveByValueSet<Patient>(null, 
			null);
        return context?.Operators.SingleOrNull<Patient>(a_);
    }
    [CqlDeclaration("Patient")]
    public Patient Patient() => __Patient.Value;

    [CqlDeclaration("LengthInDays")]
    public int? LengthInDays(CqlInterval<CqlDateTime> Value)
    {
        var a_ = context?.Operators.Start(Value);
        var b_ = context?.Operators.End(Value);
        return context?.Operators.DifferenceBetween(a_, 
			b_, 
			"day");
    }

    private IEnumerable<Encounter> Inpatient_Encounter_Value()
    {
        var a_ = this.Encounter_Inpatient();
        var b_ = context?.Operators.RetrieveByValueSet<Encounter>(a_, 
			null);
        Func<Encounter,bool?> r_ = (EncounterInpatient) => 
        {
            var d_ = (EncounterInpatient?.StatusElement as object);
            var c_ = (context?.Operators.Convert<string>(d_) as object);
            var e_ = ("finished" as object);
            var f_ = context?.Operators.Equal(c_, 
				e_);
            var h_ = EncounterInpatient?.Period;
            var i_ = FHIRHelpers_4_0_001.ToInterval(h_);
            var g_ = (this.LengthInDays(i_) as object);
            var j_ = (((int?)120) as object);
            var k_ = context?.Operators.LessOrEqual(g_, 
				j_);
            var l_ = context?.Operators.And(f_, 
				k_);
            var o_ = context?.Operators.End(i_);
            var p_ = this.Measurement_Period();
            var q_ = context?.Operators.ElementInInterval<CqlDateTime>(o_, 
				p_, 
				null);
            return context?.Operators.And(l_, 
				q_);
        };
        return context?.Operators.WhereOrNull<Encounter>(b_, 
			r_);
    }
    [CqlDeclaration("Inpatient Encounter")]
    public IEnumerable<Encounter> Inpatient_Encounter() => __Inpatient_Encounter.Value;

    [CqlDeclaration("ED Visit")]
    public Encounter ED_Visit(Encounter TheEncounter)
    {
        var a_ = this.Emergency_Department_Visit();
        var b_ = context?.Operators.RetrieveByValueSet<Encounter>(a_, 
			null);
        Func<Encounter,bool?> y_ = (EDVisit) => 
        {
            var d_ = (EDVisit?.StatusElement as object);
            var c_ = (context?.Operators.Convert<string>(d_) as object);
            var e_ = ("finished" as object);
            var f_ = context?.Operators.Equal(c_, 
				e_);
            var g_ = EDVisit?.Period;
            var h_ = FHIRHelpers_4_0_001.ToInterval(g_);
            var i_ = context?.Operators.End(h_);
            var j_ = TheEncounter?.Period;
            var k_ = FHIRHelpers_4_0_001.ToInterval(j_);
            var l_ = context?.Operators.Start(k_);
            var m_ = context?.Operators.Quantity(1m, 
				"hour");
            var n_ = context?.Operators.Subtract(l_, 
				m_);
            var r_ = context?.Operators.Interval(n_, 
				l_, 
				true, 
				true);
            var s_ = context?.Operators.ElementInInterval<CqlDateTime>(i_, 
				r_, 
				null);
            bool? t_ = ((bool?)(context?.Operators.Start(k_) == null));
            var w_ = context?.Operators.Not(t_);
            var x_ = context?.Operators.And(s_, 
				w_);
            return context?.Operators.And(f_, 
				x_);
        };
        var z_ = context?.Operators.WhereOrNull<Encounter>(b_, 
			y_);
        Func<Encounter,object> aa_ = (@this) => context?.Operators.End(FHIRHelpers_4_0_001.ToInterval(@this?.Period));
        var ab_ = context?.Operators.ListSortBy<Encounter>(z_, 
			aa_, 
			System.ComponentModel.ListSortDirection.Ascending);
        return context?.Operators.LastOfList<Encounter>(ab_);
    }

    [CqlDeclaration("Hospitalization")]
    public CqlInterval<CqlDateTime> Hospitalization(Encounter TheEncounter)
    {
        var b_ = this.ED_Visit(TheEncounter);
        var a_ = new Encounter[]
		{
			b_,
		};
        Func<Encounter,CqlInterval<CqlDateTime>> c_ = (X) => (((X == null))
				? (FHIRHelpers_4_0_001.ToInterval(TheEncounter?.Period))
				: (context?.Operators.Interval(context?.Operators.Start(FHIRHelpers_4_0_001.ToInterval(X?.Period)), 
						context?.Operators.End(FHIRHelpers_4_0_001.ToInterval(TheEncounter?.Period)), 
						true, 
						true)))
;
        var d_ = context?.Operators.SelectOrNull<Encounter, CqlInterval<CqlDateTime>>(a_, 
			c_);
        return context?.Operators.SingleOrNull<CqlInterval<CqlDateTime>>(d_);
    }

    [CqlDeclaration("Hospitalization Locations")]
    public IEnumerable<Encounter.LocationComponent> Hospitalization_Locations(Encounter TheEncounter)
    {
        var b_ = this.ED_Visit(TheEncounter);
        var a_ = new Encounter[]
		{
			b_,
		};
        Func<Encounter,IEnumerable<Encounter.LocationComponent>> c_ = (EDEncounter) => (((EDEncounter == null))
				? ((TheEncounter?.Location as IEnumerable<Encounter.LocationComponent>))
				: (context?.Operators.FlattenList<Encounter.LocationComponent>((new IEnumerable<Encounter.LocationComponent>[]
						{
							(EDEncounter?.Location as IEnumerable<Encounter.LocationComponent>),
							(TheEncounter?.Location as IEnumerable<Encounter.LocationComponent>),
						} as IEnumerable<IEnumerable<Encounter.LocationComponent>>))))
;
        var d_ = context?.Operators.SelectOrNull<Encounter, IEnumerable<Encounter.LocationComponent>>(a_, 
			c_);
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
        var a_ = (context?.Operators.FirstOfList<Encounter.LocationComponent>(context?.Operators.ListSortBy<Encounter.LocationComponent>(this.Hospitalization_Locations(TheEncounter), 
					(@this) => context?.Operators.Start(FHIRHelpers_4_0_001.ToInterval(@this?.Period)), 
					System.ComponentModel.ListSortDirection.Ascending)))?.Period;
        var b_ = FHIRHelpers_4_0_001.ToInterval(a_);
        return context?.Operators.Start(b_);
    }

    [CqlDeclaration("HospitalizationWithObservation")]
    public CqlInterval<CqlDateTime> HospitalizationWithObservation(Encounter TheEncounter)
    {
        var b_ = TheEncounter;
        var a_ = new Encounter[]
		{
			b_,
		};
        Func<Encounter,CqlInterval<CqlDateTime>> m_ = (Visit) => 
        {
            var d_ = (context?.Operators.LastOfList<Encounter>(context?.Operators.ListSortBy<Encounter>(context?.Operators.WhereOrNull<Encounter>(context?.Operators.RetrieveByValueSet<Encounter>(this.Emergency_Department_Visit(), 
								null), 
							(LastED) => context?.Operators.And(context?.Operators.ElementInInterval<CqlDateTime>(context?.Operators.End(FHIRHelpers_4_0_001.ToInterval(LastED?.Period)), 
										context?.Operators.Interval(context?.Operators.Subtract((context?.Operators.Start(FHIRHelpers_4_0_001.ToInterval((context?.Operators.LastOfList<Encounter>(context?.Operators.ListSortBy<Encounter>(context?.Operators.WhereOrNull<Encounter>(context?.Operators.RetrieveByValueSet<Encounter>(this.Observation_Services(), 
																			null), 
																		(LastObs) => context?.Operators.And(context?.Operators.ElementInInterval<CqlDateTime>(context?.Operators.End(FHIRHelpers_4_0_001.ToInterval(LastObs?.Period)), 
																					context?.Operators.Interval(context?.Operators.Subtract(context?.Operators.Start(FHIRHelpers_4_0_001.ToInterval(Visit?.Period)), 
																							context?.Operators.Quantity(1m, 
																								"hour")), 
																						context?.Operators.Start(FHIRHelpers_4_0_001.ToInterval(Visit?.Period)), 
																						true, 
																						true), 
																					null), 
																				context?.Operators.Not(((bool?)(context?.Operators.Start(FHIRHelpers_4_0_001.ToInterval(Visit?.Period)) == null))))), 
																	(@this) => context?.Operators.End(FHIRHelpers_4_0_001.ToInterval(@this?.Period)), 
																	System.ComponentModel.ListSortDirection.Ascending)))?.Period)) ?? context?.Operators.Start(FHIRHelpers_4_0_001.ToInterval(Visit?.Period))), 
												context?.Operators.Quantity(1m, 
													"hour")), 
											(context?.Operators.Start(FHIRHelpers_4_0_001.ToInterval((context?.Operators.LastOfList<Encounter>(context?.Operators.ListSortBy<Encounter>(context?.Operators.WhereOrNull<Encounter>(context?.Operators.RetrieveByValueSet<Encounter>(this.Observation_Services(), 
																		null), 
																	(LastObs) => context?.Operators.And(context?.Operators.ElementInInterval<CqlDateTime>(context?.Operators.End(FHIRHelpers_4_0_001.ToInterval(LastObs?.Period)), 
																				context?.Operators.Interval(context?.Operators.Subtract(context?.Operators.Start(FHIRHelpers_4_0_001.ToInterval(Visit?.Period)), 
																						context?.Operators.Quantity(1m, 
																							"hour")), 
																					context?.Operators.Start(FHIRHelpers_4_0_001.ToInterval(Visit?.Period)), 
																					true, 
																					true), 
																				null), 
																			context?.Operators.Not(((bool?)(context?.Operators.Start(FHIRHelpers_4_0_001.ToInterval(Visit?.Period)) == null))))), 
																(@this) => context?.Operators.End(FHIRHelpers_4_0_001.ToInterval(@this?.Period)), 
																System.ComponentModel.ListSortDirection.Ascending)))?.Period)) ?? context?.Operators.Start(FHIRHelpers_4_0_001.ToInterval(Visit?.Period))), 
											true, 
											true), 
										null), 
									context?.Operators.Not(((bool?)((context?.Operators.Start(FHIRHelpers_4_0_001.ToInterval((context?.Operators.LastOfList<Encounter>(context?.Operators.ListSortBy<Encounter>(context?.Operators.WhereOrNull<Encounter>(context?.Operators.RetrieveByValueSet<Encounter>(this.Observation_Services(), 
																	null), 
																(LastObs) => context?.Operators.And(context?.Operators.ElementInInterval<CqlDateTime>(context?.Operators.End(FHIRHelpers_4_0_001.ToInterval(LastObs?.Period)), 
																			context?.Operators.Interval(context?.Operators.Subtract(context?.Operators.Start(FHIRHelpers_4_0_001.ToInterval(Visit?.Period)), 
																					context?.Operators.Quantity(1m, 
																						"hour")), 
																				context?.Operators.Start(FHIRHelpers_4_0_001.ToInterval(Visit?.Period)), 
																				true, 
																				true), 
																			null), 
																		context?.Operators.Not(((bool?)(context?.Operators.Start(FHIRHelpers_4_0_001.ToInterval(Visit?.Period)) == null))))), 
															(@this) => context?.Operators.End(FHIRHelpers_4_0_001.ToInterval(@this?.Period)), 
															System.ComponentModel.ListSortDirection.Ascending)))?.Period)) ?? context?.Operators.Start(FHIRHelpers_4_0_001.ToInterval(Visit?.Period))) == null))))), 
						(@this) => context?.Operators.End(FHIRHelpers_4_0_001.ToInterval(@this?.Period)), 
						System.ComponentModel.ListSortDirection.Ascending)))?.Period;
            var e_ = FHIRHelpers_4_0_001.ToInterval(d_);
            var f_ = (context?.Operators.LastOfList<Encounter>(context?.Operators.ListSortBy<Encounter>(context?.Operators.WhereOrNull<Encounter>(context?.Operators.RetrieveByValueSet<Encounter>(this.Observation_Services(), 
								null), 
							(LastObs) => context?.Operators.And(context?.Operators.ElementInInterval<CqlDateTime>(context?.Operators.End(FHIRHelpers_4_0_001.ToInterval(LastObs?.Period)), 
										context?.Operators.Interval(context?.Operators.Subtract(context?.Operators.Start(FHIRHelpers_4_0_001.ToInterval(Visit?.Period)), 
												context?.Operators.Quantity(1m, 
													"hour")), 
											context?.Operators.Start(FHIRHelpers_4_0_001.ToInterval(Visit?.Period)), 
											true, 
											true), 
										null), 
									context?.Operators.Not(((bool?)(context?.Operators.Start(FHIRHelpers_4_0_001.ToInterval(Visit?.Period)) == null))))), 
						(@this) => context?.Operators.End(FHIRHelpers_4_0_001.ToInterval(@this?.Period)), 
						System.ComponentModel.ListSortDirection.Ascending)))?.Period;
            var g_ = FHIRHelpers_4_0_001.ToInterval(f_);
            var h_ = Visit?.Period;
            var i_ = FHIRHelpers_4_0_001.ToInterval(h_);
            var c_ = (context?.Operators.Start(e_) ?? (context?.Operators.Start(g_) ?? context?.Operators.Start(i_)));
            var l_ = context?.Operators.End(i_);
            return context?.Operators.Interval(c_, 
				l_, 
				true, 
				true);
        };
        var n_ = context?.Operators.SelectOrNull<Encounter, CqlInterval<CqlDateTime>>(a_, 
			m_);
        return context?.Operators.SingleOrNull<CqlInterval<CqlDateTime>>(n_);
    }

    [CqlDeclaration("Normalize Interval")]
    public CqlInterval<CqlDateTime> Normalize_Interval(object choice)
    {
        if (((choice is FhirDateTime as bool?) ?? false))
            {
                var a__ = (choice as FhirDateTime);
                var b__ = FHIRHelpers_4_0_001.ToDateTime(a__);
                return context?.Operators.Interval(b__, 
					b__, 
					true, 
					true);
            }
        else if (((choice is Period as bool?) ?? false))
            {
                var a__ = (choice as Period);
                return FHIRHelpers_4_0_001.ToInterval(a__);
            }
        else if (((choice is Instant as bool?) ?? false))
            {
                var a__ = (choice as Instant);
                var b__ = FHIRHelpers_4_0_001.ToDateTime(a__);
                return context?.Operators.Interval(b__, 
					b__, 
					true, 
					true);
            }
        else if (((choice is Age as bool?) ?? false))
            {
                var a__ = (context?.Operators.Interval(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
							FHIRHelpers_4_0_001.ToQuantity(((Quantity)(choice as Age)))), 
						context?.Operators.Add(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
								FHIRHelpers_4_0_001.ToQuantity(((Quantity)(choice as Age)))), 
							context?.Operators.Quantity(1m, 
								"year")), 
						true, 
						false))?.low;
                var b__ = context?.Operators.ConvertDateToDateTime(a__);
                var c__ = (context?.Operators.Interval(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
							FHIRHelpers_4_0_001.ToQuantity(((Quantity)(choice as Age)))), 
						context?.Operators.Add(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
								FHIRHelpers_4_0_001.ToQuantity(((Quantity)(choice as Age)))), 
							context?.Operators.Quantity(1m, 
								"year")), 
						true, 
						false))?.high;
                var d__ = context?.Operators.ConvertDateToDateTime(c__);
                var e__ = (context?.Operators.Interval(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
							FHIRHelpers_4_0_001.ToQuantity(((Quantity)(choice as Age)))), 
						context?.Operators.Add(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
								FHIRHelpers_4_0_001.ToQuantity(((Quantity)(choice as Age)))), 
							context?.Operators.Quantity(1m, 
								"year")), 
						true, 
						false))?.lowClosed;
                var f__ = (context?.Operators.Interval(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
							FHIRHelpers_4_0_001.ToQuantity(((Quantity)(choice as Age)))), 
						context?.Operators.Add(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
								FHIRHelpers_4_0_001.ToQuantity(((Quantity)(choice as Age)))), 
							context?.Operators.Quantity(1m, 
								"year")), 
						true, 
						false))?.highClosed;
                return context?.Operators.Interval(b__, 
					d__, 
					e__, 
					f__);
            }
        else if (((choice is Range as bool?) ?? false))
            {
                var a__ = (context?.Operators.Interval(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
							FHIRHelpers_4_0_001.ToQuantity(((choice as Range))?.Low)), 
						context?.Operators.Add(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
								FHIRHelpers_4_0_001.ToQuantity(((choice as Range))?.High)), 
							context?.Operators.Quantity(1m, 
								"year")), 
						true, 
						false))?.low;
                var b__ = context?.Operators.ConvertDateToDateTime(a__);
                var c__ = (context?.Operators.Interval(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
							FHIRHelpers_4_0_001.ToQuantity(((choice as Range))?.Low)), 
						context?.Operators.Add(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
								FHIRHelpers_4_0_001.ToQuantity(((choice as Range))?.High)), 
							context?.Operators.Quantity(1m, 
								"year")), 
						true, 
						false))?.high;
                var d__ = context?.Operators.ConvertDateToDateTime(c__);
                var e__ = (context?.Operators.Interval(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
							FHIRHelpers_4_0_001.ToQuantity(((choice as Range))?.Low)), 
						context?.Operators.Add(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
								FHIRHelpers_4_0_001.ToQuantity(((choice as Range))?.High)), 
							context?.Operators.Quantity(1m, 
								"year")), 
						true, 
						false))?.lowClosed;
                var f__ = (context?.Operators.Interval(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
							FHIRHelpers_4_0_001.ToQuantity(((choice as Range))?.Low)), 
						context?.Operators.Add(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
								FHIRHelpers_4_0_001.ToQuantity(((choice as Range))?.High)), 
							context?.Operators.Quantity(1m, 
								"year")), 
						true, 
						false))?.highClosed;
                return context?.Operators.Interval(b__, 
					d__, 
					e__, 
					f__);
            }
        else if (((choice is Timing as bool?) ?? false))
            return context?.Operators.Message<CqlInterval<CqlDateTime>>((null as CqlInterval<CqlDateTime>), 
				"1", 
				"Error", 
				"Cannot compute a single interval from a Timing type");

        else if (((choice is FhirString as bool?) ?? false))
            return context?.Operators.Message<CqlInterval<CqlDateTime>>((null as CqlInterval<CqlDateTime>), 
				"1", 
				"Error", 
				"Cannot compute an interval from a String value");

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
                return context?.Operators.Interval(b__, 
					b__, 
					true, 
					true);
            }
        else if ((((condition?.Abatement as object) is Period as bool?) ?? false))
            {
                var a__ = ((condition?.Abatement as object) as Period);
                return FHIRHelpers_4_0_001.ToInterval(a__);
            }
        else if ((((condition?.Abatement as object) is FhirString as bool?) ?? false))
            return context?.Operators.Message<CqlInterval<CqlDateTime>>((null as CqlInterval<CqlDateTime>), 
				"1", 
				"Error", 
				"Cannot compute an interval from a String value");

        else if ((((condition?.Abatement as object) is Age as bool?) ?? false))
            {
                var a__ = (context?.Operators.Interval(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
							FHIRHelpers_4_0_001.ToQuantity(((Quantity)((condition?.Abatement as object) as Age)))), 
						context?.Operators.Add(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
								FHIRHelpers_4_0_001.ToQuantity(((Quantity)((condition?.Abatement as object) as Age)))), 
							context?.Operators.Quantity(1m, 
								"year")), 
						true, 
						false))?.low;
                var b__ = context?.Operators.ConvertDateToDateTime(a__);
                var c__ = (context?.Operators.Interval(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
							FHIRHelpers_4_0_001.ToQuantity(((Quantity)((condition?.Abatement as object) as Age)))), 
						context?.Operators.Add(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
								FHIRHelpers_4_0_001.ToQuantity(((Quantity)((condition?.Abatement as object) as Age)))), 
							context?.Operators.Quantity(1m, 
								"year")), 
						true, 
						false))?.high;
                var d__ = context?.Operators.ConvertDateToDateTime(c__);
                var e__ = (context?.Operators.Interval(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
							FHIRHelpers_4_0_001.ToQuantity(((Quantity)((condition?.Abatement as object) as Age)))), 
						context?.Operators.Add(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
								FHIRHelpers_4_0_001.ToQuantity(((Quantity)((condition?.Abatement as object) as Age)))), 
							context?.Operators.Quantity(1m, 
								"year")), 
						true, 
						false))?.lowClosed;
                var f__ = (context?.Operators.Interval(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
							FHIRHelpers_4_0_001.ToQuantity(((Quantity)((condition?.Abatement as object) as Age)))), 
						context?.Operators.Add(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
								FHIRHelpers_4_0_001.ToQuantity(((Quantity)((condition?.Abatement as object) as Age)))), 
							context?.Operators.Quantity(1m, 
								"year")), 
						true, 
						false))?.highClosed;
                return context?.Operators.Interval(b__, 
					d__, 
					e__, 
					f__);
            }
        else if ((((condition?.Abatement as object) is Range as bool?) ?? false))
            {
                var a__ = (context?.Operators.Interval(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
							FHIRHelpers_4_0_001.ToQuantity((((condition?.Abatement as object) as Range))?.Low)), 
						context?.Operators.Add(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
								FHIRHelpers_4_0_001.ToQuantity((((condition?.Abatement as object) as Range))?.High)), 
							context?.Operators.Quantity(1m, 
								"year")), 
						true, 
						false))?.low;
                var b__ = context?.Operators.ConvertDateToDateTime(a__);
                var c__ = (context?.Operators.Interval(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
							FHIRHelpers_4_0_001.ToQuantity((((condition?.Abatement as object) as Range))?.Low)), 
						context?.Operators.Add(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
								FHIRHelpers_4_0_001.ToQuantity((((condition?.Abatement as object) as Range))?.High)), 
							context?.Operators.Quantity(1m, 
								"year")), 
						true, 
						false))?.high;
                var d__ = context?.Operators.ConvertDateToDateTime(c__);
                var e__ = (context?.Operators.Interval(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
							FHIRHelpers_4_0_001.ToQuantity((((condition?.Abatement as object) as Range))?.Low)), 
						context?.Operators.Add(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
								FHIRHelpers_4_0_001.ToQuantity((((condition?.Abatement as object) as Range))?.High)), 
							context?.Operators.Quantity(1m, 
								"year")), 
						true, 
						false))?.lowClosed;
                var f__ = (context?.Operators.Interval(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
							FHIRHelpers_4_0_001.ToQuantity((((condition?.Abatement as object) as Range))?.Low)), 
						context?.Operators.Add(context?.Operators.Add(FHIRHelpers_4_0_001.ToDate(this.Patient()?.BirthDateElement), 
								FHIRHelpers_4_0_001.ToQuantity((((condition?.Abatement as object) as Range))?.High)), 
							context?.Operators.Quantity(1m, 
								"year")), 
						true, 
						false))?.highClosed;
                return context?.Operators.Interval(b__, 
					d__, 
					e__, 
					f__);
            }
        else if ((((condition?.Abatement as object) is FhirBoolean as bool?) ?? false))
            {
                var a__ = (condition?.Onset as object);
                var b__ = this.Normalize_Interval(a__);
                var c__ = context?.Operators.End(b__);
                var d__ = condition?.RecordedDateElement;
                var e__ = FHIRHelpers_4_0_001.ToDateTime(d__);
                return context?.Operators.Interval(c__, 
					e__, 
					true, 
					false);
            }
        else 
            return (null as CqlInterval<CqlDateTime>);

    }


    [CqlDeclaration("Prevalence Period")]
    public CqlInterval<CqlDateTime> Prevalence_Period(Condition condition)
    {
        if ((context?.Operators.Or(context?.Operators.Or(context?.Operators.Equivalent((FHIRHelpers_4_0_001.ToConcept(condition?.ClinicalStatus) as object), 
						(context?.Operators.ConvertCodeToConcept(this.active()) as object)), 
					context?.Operators.Equivalent((FHIRHelpers_4_0_001.ToConcept(condition?.ClinicalStatus) as object), 
						(context?.Operators.ConvertCodeToConcept(this.recurrence()) as object))), 
				context?.Operators.Equivalent((FHIRHelpers_4_0_001.ToConcept(condition?.ClinicalStatus) as object), 
					(context?.Operators.ConvertCodeToConcept(this.relapse()) as object))) ?? false))
            {
                var a__ = (condition?.Onset as object);
                var b__ = this.Normalize_Interval(a__);
                var c__ = context?.Operators.Start(b__);
                var d__ = this.Normalize_Abatement(condition);
                var e__ = context?.Operators.End(d__);
                return context?.Operators.Interval(c__, 
					e__, 
					true, 
					true);
            }
        else 
            {
                var a__ = (condition?.Onset as object);
                var b__ = this.Normalize_Interval(a__);
                var c__ = context?.Operators.Start(b__);
                var d__ = this.Normalize_Abatement(condition);
                var e__ = context?.Operators.End(d__);
                return context?.Operators.Interval(c__, 
					e__, 
					true, 
					false);
            }
    }


    [CqlDeclaration("GetId")]
    public string GetId(string uri)
    {
        var a_ = context?.Operators.Split(uri, 
			"/");
        return context?.Operators.LastOfList<string>(a_);
    }

    [CqlDeclaration("EncounterDiagnosis")]
    public IEnumerable<Condition> EncounterDiagnosis(Encounter Encounter)
    {
        var a_ = (Encounter?.Diagnosis as IEnumerable<Encounter.DiagnosisComponent>);
        Func<Encounter.DiagnosisComponent,Condition> j_ = (D) => 
        {
            var b_ = context?.Operators.RetrieveByValueSet<Condition>(null, 
				null);
            Func<Condition,bool?> h_ = (C) => 
            {
                var d_ = (C?.IdElement as object);
                var c_ = (context?.Operators.Convert<string>(d_) as object);
                var f_ = (D?.Condition?.ReferenceElement as object);
                var g_ = context?.Operators.Convert<string>(f_);
                var e_ = (this.GetId(g_) as object);
                return context?.Operators.Equal(c_, 
					e_);
            };
            var i_ = context?.Operators.WhereOrNull<Condition>(b_, 
				h_);
            return context?.Operators.SingleOrNull<Condition>(i_);
        };
        return context?.Operators.SelectOrNull<Encounter.DiagnosisComponent, Condition>(a_, 
			j_);
    }

    [CqlDeclaration("GetCondition")]
    public Condition GetCondition(ResourceReference reference)
    {
        var a_ = context?.Operators.RetrieveByValueSet<Condition>(null, 
			null);
        Func<Condition,bool?> g_ = (C) => 
        {
            var c_ = (C?.IdElement as object);
            var b_ = (context?.Operators.Convert<string>(c_) as object);
            var e_ = (reference?.ReferenceElement as object);
            var f_ = context?.Operators.Convert<string>(e_);
            var d_ = (this.GetId(f_) as object);
            return context?.Operators.Equal(b_, 
				d_);
        };
        var h_ = context?.Operators.WhereOrNull<Condition>(a_, 
			g_);
        return context?.Operators.SingleOrNull<Condition>(h_);
    }

    [CqlDeclaration("GetExtensions")]
    public IEnumerable<Extension> GetExtensions(DomainResource domainResource, string url)
    {
        var a_ = (domainResource?.Extension as IEnumerable<Extension>);
        Func<Extension,bool?> f_ = (E) => 
        {
            var d_ = (E?.Url as object);
            var c_ = (context?.Operators.Convert<FhirUri>(d_) as object);
            var b_ = (context?.Operators.Convert<string>(c_) as object);
            var e_ = (context?.Operators.Concatenate("http://hl7.org/fhir/us/qicore/StructureDefinition/", 
				url) as object);
            return context?.Operators.Equal(b_, 
				e_);
        };
        var g_ = context?.Operators.WhereOrNull<Extension>(a_, 
			f_);
        Func<Extension,Extension> h_ = (E) => E;
        return context?.Operators.SelectOrNull<Extension, Extension>(g_, 
			h_);
    }

    [CqlDeclaration("GetExtensions")]
    public IEnumerable<Extension> GetExtensions(Element element, string url)
    {
        var a_ = (element?.Extension as IEnumerable<Extension>);
        Func<Extension,bool?> f_ = (E) => 
        {
            var d_ = (E?.Url as object);
            var c_ = (context?.Operators.Convert<FhirUri>(d_) as object);
            var b_ = (context?.Operators.Convert<string>(c_) as object);
            var e_ = (url as object);
            return context?.Operators.Equal(b_, 
				e_);
        };
        var g_ = context?.Operators.WhereOrNull<Extension>(a_, 
			f_);
        Func<Extension,Extension> h_ = (E) => E;
        return context?.Operators.SelectOrNull<Extension, Extension>(g_, 
			h_);
    }

    [CqlDeclaration("GetExtension")]
    public Extension GetExtension(DomainResource domainResource, string url)
    {
        var a_ = this.GetExtensions(domainResource, 
			url);
        return context?.Operators.SingleOrNull<Extension>(a_);
    }

    [CqlDeclaration("GetExtension")]
    public Extension GetExtension(Element element, string url)
    {
        var a_ = this.GetExtensions(element, 
			url);
        return context?.Operators.SingleOrNull<Extension>(a_);
    }

    [CqlDeclaration("PresentOnAdmissionIndicator")]
    public CodeableConcept PresentOnAdmissionIndicator(Element element)
    {
        return (((this.GetExtension(element, 
				"http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission"))?.Value as object) as CodeableConcept);
    }


    [CqlDeclaration("PrincipalDiagnosis")]
    public Condition PrincipalDiagnosis(Encounter Encounter)
    {
        var c_ = (Encounter?.Diagnosis as IEnumerable<Encounter.DiagnosisComponent>);
        Func<Encounter.DiagnosisComponent,bool?> h_ = (D) => 
        {
            var e_ = (D?.RankElement as object);
            var f_ = context?.Operators.Convert<Integer>(e_);
            var d_ = (FHIRHelpers_4_0_001.ToInteger(f_) as object);
            var g_ = (((int?)1) as object);
            return context?.Operators.Equal(d_, 
				g_);
        };
        var i_ = context?.Operators.WhereOrNull<Encounter.DiagnosisComponent>(c_, 
			h_);
        var b_ = context?.Operators.SingleOrNull<Encounter.DiagnosisComponent>(i_);
        var a_ = new Encounter.DiagnosisComponent[]
		{
			b_,
		};
        Func<Encounter.DiagnosisComponent,Condition> r_ = (PD) => 
        {
            var j_ = context?.Operators.RetrieveByValueSet<Condition>(null, 
				null);
            Func<Condition,bool?> p_ = (C) => 
            {
                var l_ = (C?.IdElement as object);
                var k_ = (context?.Operators.Convert<string>(l_) as object);
                var n_ = (PD?.Condition?.ReferenceElement as object);
                var o_ = context?.Operators.Convert<string>(n_);
                var m_ = (this.GetId(o_) as object);
                return context?.Operators.Equal(k_, 
					m_);
            };
            var q_ = context?.Operators.WhereOrNull<Condition>(j_, 
				p_);
            return context?.Operators.SingleOrNull<Condition>(q_);
        };
        var s_ = context?.Operators.SelectOrNull<Encounter.DiagnosisComponent, Condition>(a_, 
			r_);
        return context?.Operators.SingleOrNull<Condition>(s_);
    }

    [CqlDeclaration("GetLocation")]
    public Location GetLocation(ResourceReference reference)
    {
        var a_ = context?.Operators.RetrieveByValueSet<Location>(null, 
			null);
        Func<Location,bool?> g_ = (L) => 
        {
            var c_ = (L?.IdElement as object);
            var b_ = (context?.Operators.Convert<string>(c_) as object);
            var e_ = (reference?.ReferenceElement as object);
            var f_ = context?.Operators.Convert<string>(e_);
            var d_ = (this.GetId(f_) as object);
            return context?.Operators.Equal(b_, 
				d_);
        };
        var h_ = context?.Operators.WhereOrNull<Location>(a_, 
			g_);
        return context?.Operators.SingleOrNull<Location>(h_);
    }

    [CqlDeclaration("GetBaseExtensions")]
    public IEnumerable<Extension> GetBaseExtensions(DomainResource domainResource, string url)
    {
        var a_ = (domainResource?.Extension as IEnumerable<Extension>);
        Func<Extension,bool?> f_ = (E) => 
        {
            var d_ = (E?.Url as object);
            var c_ = (context?.Operators.Convert<FhirUri>(d_) as object);
            var b_ = (context?.Operators.Convert<string>(c_) as object);
            var e_ = (context?.Operators.Concatenate("http://hl7.org/fhir/StructureDefinition/", 
				url) as object);
            return context?.Operators.Equal(b_, 
				e_);
        };
        var g_ = context?.Operators.WhereOrNull<Extension>(a_, 
			f_);
        Func<Extension,Extension> h_ = (E) => E;
        return context?.Operators.SelectOrNull<Extension, Extension>(g_, 
			h_);
    }

    [CqlDeclaration("GetBaseExtension")]
    public Extension GetBaseExtension(DomainResource domainResource, string url)
    {
        var a_ = this.GetBaseExtensions(domainResource, 
			url);
        return context?.Operators.SingleOrNull<Extension>(a_);
    }

    [CqlDeclaration("BaseExtensions")]
    public IEnumerable<Extension> BaseExtensions(Element element, string id)
    {
        var a_ = (element?.Extension as IEnumerable<Extension>);
        Func<Extension,bool?> f_ = (E) => 
        {
            var d_ = (E?.Url as object);
            var c_ = (context?.Operators.Convert<FhirUri>(d_) as object);
            var b_ = (context?.Operators.Convert<string>(c_) as object);
            var e_ = (context?.Operators.Concatenate("http://hl7.org/fhir/StructureDefinition/", 
				id) as object);
            return context?.Operators.Equal(b_, 
				e_);
        };
        var g_ = context?.Operators.WhereOrNull<Extension>(a_, 
			f_);
        Func<Extension,Extension> h_ = (E) => E;
        return context?.Operators.SelectOrNull<Extension, Extension>(g_, 
			h_);
    }

    [CqlDeclaration("BaseExtension")]
    public Extension BaseExtension(Element element, string id)
    {
        var a_ = this.BaseExtensions(element, 
			id);
        return context?.Operators.SingleOrNull<Extension>(a_);
    }

    [CqlDeclaration("GetMedicationCode")]
    public CodeableConcept GetMedicationCode(MedicationRequest request)
    {
        if ((((request?.Medication as object) is CodeableConcept as bool?) ?? false))
            return ((request?.Medication as object) as CodeableConcept);

        else 
            {
                return (context?.Operators.SingleOrNull<Medication>(context?.Operators.WhereOrNull<Medication>(context?.Operators.RetrieveByValueSet<Medication>(null, 
								null), 
							(M) => context?.Operators.Equal((context?.Operators.Convert<string>((M?.IdElement as object)) as object), 
									(this.GetId(context?.Operators.Convert<string>(((((request?.Medication as object) as ResourceReference))?.ReferenceElement as object))) as object)))))?.Code;
            }
    }


    [CqlDeclaration("HasStart")]
    public bool? HasStart(CqlInterval<CqlDateTime> period)
    {
        bool? a_ = ((bool?)(context?.Operators.Start(period) == null));
        var b_ = (context?.Operators.Start(period) as object);
        var c_ = (context?.Operators.Minimum<CqlDateTime>() as object);
        var d_ = context?.Operators.Equal(b_, 
			c_);
        var e_ = context?.Operators.Or(a_, 
			d_);
        return context?.Operators.Not(e_);
    }

    [CqlDeclaration("HasEnd")]
    public bool? HasEnd(CqlInterval<CqlDateTime> period)
    {
        bool? a_ = ((bool?)(context?.Operators.End(period) == null));
        var b_ = (context?.Operators.End(period) as object);
        var c_ = (context?.Operators.Maximum<CqlDateTime>() as object);
        var d_ = context?.Operators.Equal(b_, 
			c_);
        var e_ = context?.Operators.Or(a_, 
			d_);
        return context?.Operators.Not(e_);
    }

    [CqlDeclaration("Latest")]
    public CqlDateTime Latest(object choice)
    {
        var b_ = this.Normalize_Interval(choice);
        var a_ = new CqlInterval<CqlDateTime>[]
		{
			b_,
		};
        Func<CqlInterval<CqlDateTime>,CqlDateTime> c_ = (period) => (((this.HasEnd(period) ?? false))
				? (context?.Operators.End(period))
				: (context?.Operators.Start(period)))
;
        var d_ = context?.Operators.SelectOrNull<CqlInterval<CqlDateTime>, CqlDateTime>(a_, 
			c_);
        return context?.Operators.SingleOrNull<CqlDateTime>(d_);
    }

    [CqlDeclaration("Earliest")]
    public CqlDateTime Earliest(object choice)
    {
        var b_ = this.Normalize_Interval(choice);
        var a_ = new CqlInterval<CqlDateTime>[]
		{
			b_,
		};
        Func<CqlInterval<CqlDateTime>,CqlDateTime> c_ = (period) => (((this.HasStart(period) ?? false))
				? (context?.Operators.Start(period))
				: (context?.Operators.End(period)))
;
        var d_ = context?.Operators.SelectOrNull<CqlInterval<CqlDateTime>, CqlDateTime>(a_, 
			c_);
        return context?.Operators.SingleOrNull<CqlDateTime>(d_);
    }

}