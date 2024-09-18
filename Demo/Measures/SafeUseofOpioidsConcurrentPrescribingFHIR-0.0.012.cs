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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "1.0.0.0")]
[CqlLibrary("SafeUseofOpioidsConcurrentPrescribingFHIR", "0.0.012")]
public class SafeUseofOpioidsConcurrentPrescribingFHIR_0_0_012
{

    public static SafeUseofOpioidsConcurrentPrescribingFHIR_0_0_012 Instance { get; }  = new();

    [CqlDeclaration("All Primary and Secondary Cancer")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.161")]
	public CqlValueSet All_Primary_and_Secondary_Cancer(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.161", null);

    [CqlDeclaration("Discharge To Acute Care Facility")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87")]
	public CqlValueSet Discharge_To_Acute_Care_Facility(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87", null);

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
	public CqlValueSet Encounter_Inpatient(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlDeclaration("Hospice Care Referral or Admission")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1116.365")]
	public CqlValueSet Hospice_Care_Referral_or_Admission(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1116.365", null);

    [CqlDeclaration("Palliative or Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1579")]
	public CqlValueSet Palliative_or_Hospice_Care(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1579", null);

    [CqlDeclaration("Patient Expired")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309")]
	public CqlValueSet Patient_Expired(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309", null);

    [CqlDeclaration("Schedule II & III Opioid Medications")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.165")]
	public CqlValueSet Schedule_II_and_III_Opioid_Medications(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.165", null);

    [CqlDeclaration("Schedule IV Benzodiazepines")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1125.1")]
	public CqlValueSet Schedule_IV_Benzodiazepines(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1125.1", null);

    [CqlDeclaration("Birth date")]
	public CqlCode Birth_date(CqlContext context) => 
		new CqlCode("21112-8", "http://loinc.org", null, null);

    [CqlDeclaration("LOINC")]
	public CqlCode[] LOINC(CqlContext context)
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("21112-8", "http://loinc.org", null, null),
		};

		return a_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
	{
		var a_ = context.ResolveParameter("SafeUseofOpioidsConcurrentPrescribingFHIR-0.0.012", "Measurement Period", null);

		return (CqlInterval<CqlDateTime>)a_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient(CqlContext context)
	{
		var a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		var b_ = context.Operators.SingleOrNull<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Inpatient Encounter with Age Greater than or Equal to 18")]
	public IEnumerable<Encounter> Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18(CqlContext context)
	{
		var a_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Inpatient_Encounter(context);
		bool? b_(Encounter EncounterInpatient)
		{
			var d_ = this.Patient(context);
			var e_ = context.Operators.Convert<CqlDate>(d_?.BirthDateElement?.Value);
			var f_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, EncounterInpatient?.Period);
			var g_ = context.Operators.Start(f_);
			var h_ = context.Operators.DateFrom(g_);
			var i_ = context.Operators.CalculateAgeAt(e_, h_, "year");
			var j_ = context.Operators.GreaterOrEqual(i_, (int?)18);
			var k_ = context.Operators.Convert<string>(EncounterInpatient?.StatusElement);
			var l_ = context.Operators.Equal(k_, "finished");
			var m_ = context.Operators.And(j_, l_);

			return m_;
		};
		var c_ = context.Operators.WhereOrNull<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Initial Population")]
	public IEnumerable<Encounter> Initial_Population(CqlContext context)
	{
		var a_ = this.Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18(context);
		IEnumerable<Encounter> b_(Encounter InpatientEncounter)
		{
			var d_ = this.Schedule_II_and_III_Opioid_Medications(context);
			var e_ = context.Operators.RetrieveByValueSet<MedicationRequest>(d_, null);
			var g_ = context.Operators.RetrieveByValueSet<MedicationRequest>(d_, null);
			var h_ = context.Operators.ListUnion<MedicationRequest>(e_, g_);
			var i_ = this.Schedule_IV_Benzodiazepines(context);
			var j_ = context.Operators.RetrieveByValueSet<MedicationRequest>(i_, null);
			var l_ = context.Operators.RetrieveByValueSet<MedicationRequest>(i_, null);
			var m_ = context.Operators.ListUnion<MedicationRequest>(j_, l_);
			bool? n_(MedicationRequest Medications)
			{
				bool? u_(CodeableConcept C)
				{
					var x_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, C);
					var y_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Discharge(context);
					var z_ = context.Operators.ConvertCodeToConcept(y_);
					var aa_ = context.Operators.Equivalent(x_, z_);

					return aa_;
				};
				var v_ = context.Operators.WhereOrNull<CodeableConcept>((Medications?.Category as IEnumerable<CodeableConcept>), u_);
				var w_ = context.Operators.ExistsInList<CodeableConcept>(v_);

				return w_;
			};
			var o_ = context.Operators.WhereOrNull<MedicationRequest>(m_, n_);
			var p_ = context.Operators.ListUnion<MedicationRequest>(h_, o_);
			bool? q_(MedicationRequest OpioidOrBenzodiazepineDischargeMedication)
			{
				var ab_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, OpioidOrBenzodiazepineDischargeMedication?.AuthoredOnElement);
				var ac_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, InpatientEncounter?.Period);
				var ad_ = context.Operators.ElementInInterval<CqlDateTime>(ab_, ac_, null);
				var ae_ = context.Operators.Convert<string>(OpioidOrBenzodiazepineDischargeMedication?.StatusElement);
				var af_ = context.Operators.Equal(ae_, "active");
				var ag_ = context.Operators.And(ad_, af_);
				var ah_ = context.Operators.Convert<string>(OpioidOrBenzodiazepineDischargeMedication?.IntentElement);
				var ai_ = context.Operators.Equal(ah_, "plan");
				var aj_ = context.Operators.And(ag_, ai_);

				return aj_;
			};
			var r_ = context.Operators.WhereOrNull<MedicationRequest>(p_, q_);
			Encounter s_(MedicationRequest OpioidOrBenzodiazepineDischargeMedication) => 
				InpatientEncounter;
			var t_ = context.Operators.SelectOrNull<MedicationRequest, Encounter>(r_, s_);

			return t_;
		};
		var c_ = context.Operators.SelectManyOrNull<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Denominator")]
	public IEnumerable<Encounter> Denominator(CqlContext context)
	{
		var a_ = this.Initial_Population(context);

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer(CqlContext context)
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public IEnumerable<Coding> SDE_Race(CqlContext context)
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex(CqlContext context)
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

		return a_;
	}

    [CqlDeclaration("Numerator")]
	public IEnumerable<Encounter> Numerator(CqlContext context)
	{
		var a_ = this.Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18(context);
		bool? b_(Encounter InpatientEncounter)
		{
			var j_ = this.Schedule_II_and_III_Opioid_Medications(context);
			var k_ = context.Operators.RetrieveByValueSet<MedicationRequest>(j_, null);
			bool? l_(MedicationRequest Opioids)
			{
				var r_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, Opioids?.AuthoredOnElement);
				var s_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, InpatientEncounter?.Period);
				var t_ = context.Operators.ElementInInterval<CqlDateTime>(r_, s_, null);

				return t_;
			};
			var m_ = context.Operators.WhereOrNull<MedicationRequest>(k_, l_);
			object n_(MedicationRequest Opioids) => 
				Opioids?.Medication;
			var o_ = context.Operators.SelectOrNull<MedicationRequest, object>(m_, n_);
			var p_ = context.Operators.CountOrNull<object>(o_);
			var q_ = context.Operators.GreaterOrEqual(p_, (int?)2);

			return q_;
		};
		var c_ = context.Operators.WhereOrNull<Encounter>(a_, b_);
		IEnumerable<Encounter> e_(Encounter InpatientEncounter)
		{
			var u_ = this.Schedule_II_and_III_Opioid_Medications(context);
			var v_ = context.Operators.RetrieveByValueSet<MedicationRequest>(u_, null);
			bool? w_(MedicationRequest OpioidsDischarge)
			{
				var aa_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, OpioidsDischarge?.AuthoredOnElement);
				var ab_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, InpatientEncounter?.Period);
				var ac_ = context.Operators.ElementInInterval<CqlDateTime>(aa_, ab_, null);

				return ac_;
			};
			var x_ = context.Operators.WhereOrNull<MedicationRequest>(v_, w_);
			Encounter y_(MedicationRequest OpioidsDischarge) => 
				InpatientEncounter;
			var z_ = context.Operators.SelectOrNull<MedicationRequest, Encounter>(x_, y_);

			return z_;
		};
		var f_ = context.Operators.SelectManyOrNull<Encounter, Encounter>(a_, e_);
		IEnumerable<Encounter> g_(Encounter InpatientEncounter)
		{
			var ad_ = this.Schedule_IV_Benzodiazepines(context);
			var ae_ = context.Operators.RetrieveByValueSet<MedicationRequest>(ad_, null);
			bool? af_(MedicationRequest BenzodiazepinesDischarge)
			{
				var aj_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, BenzodiazepinesDischarge?.AuthoredOnElement);
				var ak_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, InpatientEncounter?.Period);
				var al_ = context.Operators.ElementInInterval<CqlDateTime>(aj_, ak_, null);

				return al_;
			};
			var ag_ = context.Operators.WhereOrNull<MedicationRequest>(ae_, af_);
			Encounter ah_(MedicationRequest BenzodiazepinesDischarge) => 
				InpatientEncounter;
			var ai_ = context.Operators.SelectOrNull<MedicationRequest, Encounter>(ag_, ah_);

			return ai_;
		};
		var h_ = context.Operators.SelectManyOrNull<Encounter, Encounter>(f_, g_);
		var i_ = context.Operators.ListUnion<Encounter>(c_, h_);

		return i_;
	}

    [CqlDeclaration("Denominator Exclusion")]
	public IEnumerable<Encounter> Denominator_Exclusion(CqlContext context)
	{
		var a_ = this.Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18(context);
		bool? b_(Encounter InpatientEncounter)
		{
			var f_ = this.All_Primary_and_Secondary_Cancer(context);
			var g_ = context.Operators.RetrieveByValueSet<Condition>(f_, null);
			bool? h_(Condition Cancer)
			{
				var ab_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, Cancer);
				var ac_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, InpatientEncounter?.Period);
				var ad_ = context.Operators.Overlaps(ab_, ac_, null);

				return ad_;
			};
			var i_ = context.Operators.WhereOrNull<Condition>(g_, h_);
			var j_ = context.Operators.ExistsInList<Condition>(i_);
			var k_ = this.Palliative_or_Hospice_Care(context);
			var l_ = context.Operators.RetrieveByValueSet<ServiceRequest>(k_, null);
			bool? m_(ServiceRequest PalliativeOrHospiceCareOrder)
			{
				var ae_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, PalliativeOrHospiceCareOrder?.AuthoredOnElement);
				var af_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, InpatientEncounter?.Period);
				var ag_ = context.Operators.ElementInInterval<CqlDateTime>(ae_, af_, null);
				var ah_ = context.Operators.Convert<string>(PalliativeOrHospiceCareOrder?.IntentElement);
				var ai_ = context.Operators.Equal(ah_, "order");
				var aj_ = context.Operators.And(ag_, ai_);

				return aj_;
			};
			var n_ = context.Operators.WhereOrNull<ServiceRequest>(l_, m_);
			var o_ = context.Operators.ExistsInList<ServiceRequest>(n_);
			var p_ = context.Operators.Or(j_, o_);
			var r_ = context.Operators.RetrieveByValueSet<Procedure>(k_, null);
			bool? s_(Procedure PalliativeOrHospiceCarePerformed)
			{
				var ak_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, PalliativeOrHospiceCarePerformed?.Performed);
				var al_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, InpatientEncounter?.Period);
				var am_ = context.Operators.Overlaps(ak_, al_, null);

				return am_;
			};
			var t_ = context.Operators.WhereOrNull<Procedure>(r_, s_);
			var u_ = context.Operators.ExistsInList<Procedure>(t_);
			var v_ = context.Operators.Or(p_, u_);
			var w_ = this.Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18(context);
			bool? x_(Encounter InpatientEncounter)
			{
				var an_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, InpatientEncounter?.Hospitalization?.DischargeDisposition);
				var ao_ = this.Discharge_To_Acute_Care_Facility(context);
				var ap_ = context.Operators.ConceptInValueSet(an_, ao_);
				var ar_ = this.Hospice_Care_Referral_or_Admission(context);
				var as_ = context.Operators.ConceptInValueSet(an_, ar_);
				var at_ = context.Operators.Or(ap_, as_);
				var av_ = this.Patient_Expired(context);
				var aw_ = context.Operators.ConceptInValueSet(an_, av_);
				var ax_ = context.Operators.Or(at_, aw_);

				return ax_;
			};
			var y_ = context.Operators.WhereOrNull<Encounter>(w_, x_);
			var z_ = context.Operators.ExistsInList<Encounter>(y_);
			var aa_ = context.Operators.Or(v_, z_);

			return aa_;
		};
		var c_ = context.Operators.WhereOrNull<Encounter>(a_, b_);
		Encounter d_(Encounter InpatientEncounter) => 
			InpatientEncounter;
		var e_ = context.Operators.SelectOrNull<Encounter, Encounter>(c_, d_);

		return e_;
	}

}