using System;
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

#pragma warning disable CS9113 // Parameter is unread.

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.3.0")]
[CqlLibrary("SafeUseofOpioidsConcurrentPrescribingFHIR", "0.0.012")]
public class SafeUseofOpioidsConcurrentPrescribingFHIR_0_0_012(
    FHIRHelpers_4_0_001 fhirHelpers_4_0_001,
    SupplementalDataElementsFHIR4_2_0_000 supplementalDataElementsFHIR4_2_0_000,
    MATGlobalCommonFunctionsFHIR4_6_1_000 matGlobalCommonFunctionsFHIR4_6_1_000)
{

    [CqlDeclaration("All Primary and Secondary Cancer")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.161")]
	public  CqlValueSet All_Primary_and_Secondary_Cancer(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.161", default);

    [CqlDeclaration("Discharge To Acute Care Facility")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87")]
	public  CqlValueSet Discharge_To_Acute_Care_Facility(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87", default);

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
	public  CqlValueSet Encounter_Inpatient(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", default);

    [CqlDeclaration("Hospice Care Referral or Admission")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1116.365")]
	public  CqlValueSet Hospice_Care_Referral_or_Admission(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1116.365", default);

    [CqlDeclaration("Palliative or Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1579")]
	public  CqlValueSet Palliative_or_Hospice_Care(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1579", default);

    [CqlDeclaration("Patient Expired")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309")]
	public  CqlValueSet Patient_Expired(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309", default);

    [CqlDeclaration("Schedule II & III Opioid Medications")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.165")]
	public  CqlValueSet Schedule_II_and_III_Opioid_Medications(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.165", default);

    [CqlDeclaration("Schedule IV Benzodiazepines")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1125.1")]
	public  CqlValueSet Schedule_IV_Benzodiazepines(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1125.1", default);

    [CqlDeclaration("Birth date")]
	public  CqlCode Birth_date(CqlContext context) => 
		new CqlCode("21112-8", "http://loinc.org", default, default);

    [CqlDeclaration("LOINC")]
	public  CqlCode[] LOINC(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("21112-8", "http://loinc.org", default, default),
		];

		return a_;
	}

    [CqlDeclaration("Measurement Period")]
	public  CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
	{
		object a_ = context.ResolveParameter("SafeUseofOpioidsConcurrentPrescribingFHIR-0.0.012", "Measurement Period", null);

		return (CqlInterval<CqlDateTime>)a_;
	}

    [CqlDeclaration("Patient")]
	public  Patient Patient(CqlContext context)
	{
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(default, default);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Inpatient Encounter with Age Greater than or Equal to 18")]
	public  IEnumerable<Encounter> Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18(CqlContext context)
	{
		IEnumerable<Encounter> a_ = matGlobalCommonFunctionsFHIR4_6_1_000.Inpatient_Encounter(context);
		bool? b_(Encounter EncounterInpatient)
		{
			Patient d_ = this.Patient(context);
			Date e_ = d_?.BirthDateElement;
			string f_ = e_?.Value;
			CqlDate g_ = context.Operators.ConvertStringToDate(f_);
			Period h_ = EncounterInpatient?.Period;
			CqlInterval<CqlDateTime> i_ = fhirHelpers_4_0_001.ToInterval(context, h_);
			CqlDateTime j_ = context.Operators.Start(i_);
			CqlDate k_ = context.Operators.DateFrom(j_);
			int? l_ = context.Operators.CalculateAgeAt(g_, k_, "year");
			bool? m_ = context.Operators.GreaterOrEqual(l_, 18);
			Code<Encounter.EncounterStatus> n_ = EncounterInpatient?.StatusElement;
			string o_ = fhirHelpers_4_0_001.ToString(context, n_);
			bool? p_ = context.Operators.Equal(o_, "finished");
			bool? q_ = context.Operators.And(m_, p_);

			return q_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Initial Population")]
	public  IEnumerable<Encounter> Initial_Population(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18(context);
		IEnumerable<Encounter> b_(Encounter InpatientEncounter)
		{
			CqlValueSet d_ = this.Schedule_II_and_III_Opioid_Medications(context);
			IEnumerable<MedicationRequest> e_ = context.Operators.RetrieveByValueSet<MedicationRequest>(d_, default);
			IEnumerable<MedicationRequest> g_ = context.Operators.RetrieveByValueSet<MedicationRequest>(d_, default);
			IEnumerable<MedicationRequest> h_ = context.Operators.Union<MedicationRequest>(e_, g_);
			CqlValueSet i_ = this.Schedule_IV_Benzodiazepines(context);
			IEnumerable<MedicationRequest> j_ = context.Operators.RetrieveByValueSet<MedicationRequest>(i_, default);
			IEnumerable<MedicationRequest> l_ = context.Operators.RetrieveByValueSet<MedicationRequest>(i_, default);
			IEnumerable<MedicationRequest> m_ = context.Operators.Union<MedicationRequest>(j_, l_);
			bool? n_(MedicationRequest Medications)
			{
				List<CodeableConcept> u_ = Medications?.Category;
				bool? v_(CodeableConcept C)
				{
					CqlConcept y_ = fhirHelpers_4_0_001.ToConcept(context, C);
					CqlCode z_ = matGlobalCommonFunctionsFHIR4_6_1_000.Discharge(context);
					CqlConcept aa_ = context.Operators.ConvertCodeToConcept(z_);
					bool? ab_ = context.Operators.Equivalent(y_, aa_);

					return ab_;
				};
				IEnumerable<CodeableConcept> w_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)u_, v_);
				bool? x_ = context.Operators.Exists<CodeableConcept>(w_);

				return x_;
			};
			IEnumerable<MedicationRequest> o_ = context.Operators.Where<MedicationRequest>(m_, n_);
			IEnumerable<MedicationRequest> p_ = context.Operators.Union<MedicationRequest>(h_, o_);
			bool? q_(MedicationRequest OpioidOrBenzodiazepineDischargeMedication)
			{
				FhirDateTime ac_ = OpioidOrBenzodiazepineDischargeMedication?.AuthoredOnElement;
				CqlDateTime ad_ = fhirHelpers_4_0_001.ToDateTime(context, ac_);
				Period ae_ = InpatientEncounter?.Period;
				CqlInterval<CqlDateTime> af_ = fhirHelpers_4_0_001.ToInterval(context, ae_);
				bool? ag_ = context.Operators.In<CqlDateTime>(ad_, af_, default);
				Code<MedicationRequest.MedicationrequestStatus> ah_ = OpioidOrBenzodiazepineDischargeMedication?.StatusElement;
				string ai_ = fhirHelpers_4_0_001.ToString(context, ah_);
				bool? aj_ = context.Operators.Equal(ai_, "active");
				bool? ak_ = context.Operators.And(ag_, aj_);
				Code<MedicationRequest.MedicationRequestIntent> al_ = OpioidOrBenzodiazepineDischargeMedication?.IntentElement;
				string am_ = fhirHelpers_4_0_001.ToString(context, al_);
				bool? an_ = context.Operators.Equal(am_, "plan");
				bool? ao_ = context.Operators.And(ak_, an_);

				return ao_;
			};
			IEnumerable<MedicationRequest> r_ = context.Operators.Where<MedicationRequest>(p_, q_);
			Encounter s_(MedicationRequest OpioidOrBenzodiazepineDischargeMedication) => 
				InpatientEncounter;
			IEnumerable<Encounter> t_ = context.Operators.Select<MedicationRequest, Encounter>(r_, s_);

			return t_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Denominator")]
	public  IEnumerable<Encounter> Denominator(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Initial_Population(context);

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public  IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
	{
		IEnumerable<Coding> a_ = supplementalDataElementsFHIR4_2_0_000.SDE_Ethnicity(context);

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public  IEnumerable<(CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
	{
		IEnumerable<(CodeableConcept code, Period period)?> a_ = supplementalDataElementsFHIR4_2_0_000.SDE_Payer(context);

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public  IEnumerable<Coding> SDE_Race(CqlContext context)
	{
		IEnumerable<Coding> a_ = supplementalDataElementsFHIR4_2_0_000.SDE_Race(context);

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
	public  CqlCode SDE_Sex(CqlContext context)
	{
		CqlCode a_ = supplementalDataElementsFHIR4_2_0_000.SDE_Sex(context);

		return a_;
	}

    [CqlDeclaration("Numerator")]
	public  IEnumerable<Encounter> Numerator(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18(context);
		bool? b_(Encounter InpatientEncounter)
		{
			CqlValueSet j_ = this.Schedule_II_and_III_Opioid_Medications(context);
			IEnumerable<MedicationRequest> k_ = context.Operators.RetrieveByValueSet<MedicationRequest>(j_, default);
			bool? l_(MedicationRequest Opioids)
			{
				FhirDateTime r_ = Opioids?.AuthoredOnElement;
				CqlDateTime s_ = fhirHelpers_4_0_001.ToDateTime(context, r_);
				Period t_ = InpatientEncounter?.Period;
				CqlInterval<CqlDateTime> u_ = fhirHelpers_4_0_001.ToInterval(context, t_);
				bool? v_ = context.Operators.In<CqlDateTime>(s_, u_, default);

				return v_;
			};
			IEnumerable<MedicationRequest> m_ = context.Operators.Where<MedicationRequest>(k_, l_);
			object n_(MedicationRequest Opioids)
			{
				DataType w_ = Opioids?.Medication;

				return w_;
			};
			IEnumerable<object> o_ = context.Operators.Select<MedicationRequest, object>(m_, n_);
			int? p_ = context.Operators.Count<object>(o_);
			bool? q_ = context.Operators.GreaterOrEqual(p_, 2);

			return q_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
		IEnumerable<Encounter> e_(Encounter InpatientEncounter)
		{
			CqlValueSet x_ = this.Schedule_II_and_III_Opioid_Medications(context);
			IEnumerable<MedicationRequest> y_ = context.Operators.RetrieveByValueSet<MedicationRequest>(x_, default);
			bool? z_(MedicationRequest OpioidsDischarge)
			{
				FhirDateTime ad_ = OpioidsDischarge?.AuthoredOnElement;
				CqlDateTime ae_ = fhirHelpers_4_0_001.ToDateTime(context, ad_);
				Period af_ = InpatientEncounter?.Period;
				CqlInterval<CqlDateTime> ag_ = fhirHelpers_4_0_001.ToInterval(context, af_);
				bool? ah_ = context.Operators.In<CqlDateTime>(ae_, ag_, default);

				return ah_;
			};
			IEnumerable<MedicationRequest> aa_ = context.Operators.Where<MedicationRequest>(y_, z_);
			Encounter ab_(MedicationRequest OpioidsDischarge) => 
				InpatientEncounter;
			IEnumerable<Encounter> ac_ = context.Operators.Select<MedicationRequest, Encounter>(aa_, ab_);

			return ac_;
		};
		IEnumerable<Encounter> f_ = context.Operators.SelectMany<Encounter, Encounter>(a_, e_);
		IEnumerable<Encounter> g_(Encounter InpatientEncounter)
		{
			CqlValueSet ai_ = this.Schedule_IV_Benzodiazepines(context);
			IEnumerable<MedicationRequest> aj_ = context.Operators.RetrieveByValueSet<MedicationRequest>(ai_, default);
			bool? ak_(MedicationRequest BenzodiazepinesDischarge)
			{
				FhirDateTime ao_ = BenzodiazepinesDischarge?.AuthoredOnElement;
				CqlDateTime ap_ = fhirHelpers_4_0_001.ToDateTime(context, ao_);
				Period aq_ = InpatientEncounter?.Period;
				CqlInterval<CqlDateTime> ar_ = fhirHelpers_4_0_001.ToInterval(context, aq_);
				bool? as_ = context.Operators.In<CqlDateTime>(ap_, ar_, default);

				return as_;
			};
			IEnumerable<MedicationRequest> al_ = context.Operators.Where<MedicationRequest>(aj_, ak_);
			Encounter am_(MedicationRequest BenzodiazepinesDischarge) => 
				InpatientEncounter;
			IEnumerable<Encounter> an_ = context.Operators.Select<MedicationRequest, Encounter>(al_, am_);

			return an_;
		};
		IEnumerable<Encounter> h_ = context.Operators.SelectMany<Encounter, Encounter>(f_, g_);
		IEnumerable<Encounter> i_ = context.Operators.Union<Encounter>(c_, h_);

		return i_;
	}

    [CqlDeclaration("Denominator Exclusion")]
	public  IEnumerable<Encounter> Denominator_Exclusion(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18(context);
		bool? b_(Encounter InpatientEncounter)
		{
			CqlValueSet f_ = this.All_Primary_and_Secondary_Cancer(context);
			IEnumerable<Condition> g_ = context.Operators.RetrieveByValueSet<Condition>(f_, default);
			bool? h_(Condition Cancer)
			{
				CqlInterval<CqlDateTime> ab_ = matGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(context, Cancer);
				Period ac_ = InpatientEncounter?.Period;
				CqlInterval<CqlDateTime> ad_ = fhirHelpers_4_0_001.ToInterval(context, ac_);
				bool? ae_ = context.Operators.Overlaps(ab_, ad_, default);

				return ae_;
			};
			IEnumerable<Condition> i_ = context.Operators.Where<Condition>(g_, h_);
			bool? j_ = context.Operators.Exists<Condition>(i_);
			CqlValueSet k_ = this.Palliative_or_Hospice_Care(context);
			IEnumerable<ServiceRequest> l_ = context.Operators.RetrieveByValueSet<ServiceRequest>(k_, default);
			bool? m_(ServiceRequest PalliativeOrHospiceCareOrder)
			{
				FhirDateTime af_ = PalliativeOrHospiceCareOrder?.AuthoredOnElement;
				CqlDateTime ag_ = fhirHelpers_4_0_001.ToDateTime(context, af_);
				Period ah_ = InpatientEncounter?.Period;
				CqlInterval<CqlDateTime> ai_ = fhirHelpers_4_0_001.ToInterval(context, ah_);
				bool? aj_ = context.Operators.In<CqlDateTime>(ag_, ai_, default);
				Code<RequestIntent> ak_ = PalliativeOrHospiceCareOrder?.IntentElement;
				string al_ = fhirHelpers_4_0_001.ToString(context, ak_);
				bool? am_ = context.Operators.Equal(al_, "order");
				bool? an_ = context.Operators.And(aj_, am_);

				return an_;
			};
			IEnumerable<ServiceRequest> n_ = context.Operators.Where<ServiceRequest>(l_, m_);
			bool? o_ = context.Operators.Exists<ServiceRequest>(n_);
			bool? p_ = context.Operators.Or(j_, o_);
			IEnumerable<Procedure> r_ = context.Operators.RetrieveByValueSet<Procedure>(k_, default);
			bool? s_(Procedure PalliativeOrHospiceCarePerformed)
			{
				DataType ao_ = PalliativeOrHospiceCarePerformed?.Performed;
				CqlInterval<CqlDateTime> ap_ = matGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(context, ao_);
				Period aq_ = InpatientEncounter?.Period;
				CqlInterval<CqlDateTime> ar_ = fhirHelpers_4_0_001.ToInterval(context, aq_);
				bool? as_ = context.Operators.Overlaps(ap_, ar_, default);

				return as_;
			};
			IEnumerable<Procedure> t_ = context.Operators.Where<Procedure>(r_, s_);
			bool? u_ = context.Operators.Exists<Procedure>(t_);
			bool? v_ = context.Operators.Or(p_, u_);
			IEnumerable<Encounter> w_ = this.Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18(context);
			bool? x_(Encounter InpatientEncounter)
			{
				Encounter.HospitalizationComponent at_ = InpatientEncounter?.Hospitalization;
				CodeableConcept au_ = at_?.DischargeDisposition;
				CqlConcept av_ = fhirHelpers_4_0_001.ToConcept(context, au_);
				CqlValueSet aw_ = this.Discharge_To_Acute_Care_Facility(context);
				bool? ax_ = context.Operators.ConceptInValueSet(av_, aw_);
				CodeableConcept az_ = at_?.DischargeDisposition;
				CqlConcept ba_ = fhirHelpers_4_0_001.ToConcept(context, az_);
				CqlValueSet bb_ = this.Hospice_Care_Referral_or_Admission(context);
				bool? bc_ = context.Operators.ConceptInValueSet(ba_, bb_);
				bool? bd_ = context.Operators.Or(ax_, bc_);
				CodeableConcept bf_ = at_?.DischargeDisposition;
				CqlConcept bg_ = fhirHelpers_4_0_001.ToConcept(context, bf_);
				CqlValueSet bh_ = this.Patient_Expired(context);
				bool? bi_ = context.Operators.ConceptInValueSet(bg_, bh_);
				bool? bj_ = context.Operators.Or(bd_, bi_);

				return bj_;
			};
			IEnumerable<Encounter> y_ = context.Operators.Where<Encounter>(w_, x_);
			bool? z_ = context.Operators.Exists<Encounter>(y_);
			bool? aa_ = context.Operators.Or(v_, z_);

			return aa_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
		Encounter d_(Encounter InpatientEncounter) => 
			InpatientEncounter;
		IEnumerable<Encounter> e_ = context.Operators.Select<Encounter, Encounter>(c_, d_);

		return e_;
	}

}
