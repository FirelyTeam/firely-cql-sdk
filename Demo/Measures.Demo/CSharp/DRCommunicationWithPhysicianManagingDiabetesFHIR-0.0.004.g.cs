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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.4.0")]
[CqlLibrary("DRCommunicationWithPhysicianManagingDiabetesFHIR", "0.0.004")]
public partial class DRCommunicationWithPhysicianManagingDiabetesFHIR_0_0_004
{
    private DRCommunicationWithPhysicianManagingDiabetesFHIR_0_0_004() {}

    public static DRCommunicationWithPhysicianManagingDiabetesFHIR_0_0_004 Instance { get; } = new();


    [CqlDeclaration("Care Services in Long-Term Residential Facility")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014")]
	public CqlValueSet Care_Services_in_Long_Term_Residential_Facility(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014", default);


    [CqlDeclaration("Diabetic Retinopathy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.327")]
	public CqlValueSet Diabetic_Retinopathy(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.327", default);


    [CqlDeclaration("Level of Severity of Retinopathy Findings")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1283")]
	public CqlValueSet Level_of_Severity_of_Retinopathy_Findings(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1283", default);


    [CqlDeclaration("Macular Edema Findings Present")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1320")]
	public CqlValueSet Macular_Edema_Findings_Present(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1320", default);


    [CqlDeclaration("Macular Exam")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1251")]
	public CqlValueSet Macular_Exam(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1251", default);


    [CqlDeclaration("Medical Reason")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007")]
	public CqlValueSet Medical_Reason(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007", default);


    [CqlDeclaration("Nursing Facility Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012")]
	public CqlValueSet Nursing_Facility_Visit(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012", default);


    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
	public CqlValueSet Office_Visit(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", default);


    [CqlDeclaration("Ophthalmological Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285")]
	public CqlValueSet Ophthalmological_Services(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285", default);


    [CqlDeclaration("Outpatient Consultation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008")]
	public CqlValueSet Outpatient_Consultation(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", default);


    [CqlDeclaration("Patient Reason")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1008")]
	public CqlValueSet Patient_Reason(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1008", default);


    [CqlDeclaration("Birth date")]
	public CqlCode Birth_date(CqlContext context) => 
		new CqlCode("21112-8", "http://loinc.org", default, default);


    [CqlDeclaration("Healthcare professional (occupation)")]
	public CqlCode Healthcare_professional__occupation_(CqlContext context) => 
		new CqlCode("223366009", "http://snomed.info/sct", default, default);


    [CqlDeclaration("Macular edema absent (situation)")]
	public CqlCode Macular_edema_absent__situation_(CqlContext context) => 
		new CqlCode("428341000124108", "http://snomed.info/sct", default, default);


    [CqlDeclaration("Medical practitioner (occupation)")]
	public CqlCode Medical_practitioner__occupation_(CqlContext context) => 
		new CqlCode("158965000", "http://snomed.info/sct", default, default);


    [CqlDeclaration("Ophthalmologist (occupation)")]
	public CqlCode Ophthalmologist__occupation_(CqlContext context) => 
		new CqlCode("422234006", "http://snomed.info/sct", default, default);


    [CqlDeclaration("Optometrist (occupation)")]
	public CqlCode Optometrist__occupation_(CqlContext context) => 
		new CqlCode("28229004", "http://snomed.info/sct", default, default);


    [CqlDeclaration("Physician (occupation)")]
	public CqlCode Physician__occupation_(CqlContext context) => 
		new CqlCode("309343006", "http://snomed.info/sct", default, default);


    [CqlDeclaration("LOINC")]
	public CqlCode[] LOINC(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("21112-8", "http://loinc.org", default, default),
		];

		return a_;
	}


    [CqlDeclaration("SNOMEDCT")]
	public CqlCode[] SNOMEDCT(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("223366009", "http://snomed.info/sct", default, default),
			new CqlCode("428341000124108", "http://snomed.info/sct", default, default),
			new CqlCode("158965000", "http://snomed.info/sct", default, default),
			new CqlCode("422234006", "http://snomed.info/sct", default, default),
			new CqlCode("28229004", "http://snomed.info/sct", default, default),
			new CqlCode("309343006", "http://snomed.info/sct", default, default),
		];

		return a_;
	}


    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
	{
		object a_ = context.ResolveParameter("DRCommunicationWithPhysicianManagingDiabetesFHIR-0.0.004", "Measurement Period", null);

		return (CqlInterval<CqlDateTime>)a_;
	}


    [CqlDeclaration("Patient")]
	public Patient Patient(CqlContext context)
	{
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(default, default);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}


    [CqlDeclaration("SDE Ethnicity")]
	public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
	{
		IEnumerable<Coding> a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);

		return a_;
	}


    [CqlDeclaration("SDE Payer")]
	public IEnumerable<(CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
	{
		IEnumerable<(CodeableConcept code, Period period)?> a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);

		return a_;
	}


    [CqlDeclaration("SDE Race")]
	public IEnumerable<Coding> SDE_Race(CqlContext context)
	{
		IEnumerable<Coding> a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);

		return a_;
	}


    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex(CqlContext context)
	{
		CqlCode a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);

		return a_;
	}


    [CqlDeclaration("Qualifying Encounter During Measurement Period")]
	public IEnumerable<Encounter> Qualifying_Encounter_During_Measurement_Period(CqlContext context)
	{
		CqlValueSet a_ = this.Office_Visit(context);
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, default);
		CqlValueSet c_ = this.Ophthalmological_Services(context);
		IEnumerable<Encounter> d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, default);
		IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
		CqlValueSet f_ = this.Outpatient_Consultation(context);
		IEnumerable<Encounter> g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, default);
		CqlValueSet h_ = this.Care_Services_in_Long_Term_Residential_Facility(context);
		IEnumerable<Encounter> i_ = context.Operators.RetrieveByValueSet<Encounter>(h_, default);
		IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
		IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
		CqlValueSet l_ = this.Nursing_Facility_Visit(context);
		IEnumerable<Encounter> m_ = context.Operators.RetrieveByValueSet<Encounter>(l_, default);
		IEnumerable<Encounter> n_ = context.Operators.Union<Encounter>(k_, m_);
		bool? o_(Encounter QualifyingEncounter)
		{
			CqlInterval<CqlDateTime> q_ = this.Measurement_Period(context);
			Period r_ = QualifyingEncounter?.Period;
			CqlInterval<CqlDateTime> s_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, r_);
			bool? t_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(q_, s_, default);
			Code<Encounter.EncounterStatus> u_ = QualifyingEncounter?.StatusElement;
			string v_ = FHIRHelpers_4_0_001.Instance.ToString(context, u_);
			bool? w_ = context.Operators.Equal(v_, "finished");
			bool? x_ = context.Operators.And(t_, w_);

			return x_;
		};
		IEnumerable<Encounter> p_ = context.Operators.Where<Encounter>(n_, o_);

		return p_;
	}


    [CqlDeclaration("Diabetic Retinopathy Encounter")]
	public IEnumerable<Encounter> Diabetic_Retinopathy_Encounter(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounter_During_Measurement_Period(context);
		IEnumerable<Encounter> b_(Encounter ValidQualifyingEncounter)
		{
			CqlValueSet d_ = this.Diabetic_Retinopathy(context);
			IEnumerable<Condition> e_ = context.Operators.RetrieveByValueSet<Condition>(d_, default);
			bool? f_(Condition DiabeticRetinopathy)
			{
				CodeableConcept j_ = DiabeticRetinopathy?.ClinicalStatus;
				CqlConcept k_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, j_);
				CqlCode l_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.active(context);
				CqlConcept m_ = context.Operators.ConvertCodeToConcept(l_);
				bool? n_ = context.Operators.Equivalent(k_, m_);
				CqlInterval<CqlDateTime> o_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, DiabeticRetinopathy);
				Period p_ = ValidQualifyingEncounter?.Period;
				CqlInterval<CqlDateTime> q_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, p_);
				bool? r_ = context.Operators.Overlaps(o_, q_, default);
				bool? s_ = context.Operators.And(n_, r_);

				return s_;
			};
			IEnumerable<Condition> g_ = context.Operators.Where<Condition>(e_, f_);
			Encounter h_(Condition DiabeticRetinopathy) => 
				ValidQualifyingEncounter;
			IEnumerable<Encounter> i_ = context.Operators.Select<Condition, Encounter>(g_, h_);

			return i_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

	public IEnumerable<Extension> GetModifierExtensions(CqlContext context, DomainResource domainResource, string url)
	{
		List<Extension> a_ = domainResource?.ModifierExtension;
		bool? b_(Extension E)
		{
			string f_ = E?.Url;
			FhirUri g_ = context.Operators.Convert<FhirUri>(f_);
			string h_ = FHIRHelpers_4_0_001.Instance.ToString(context, g_);
			string i_ = context.Operators.Concatenate("http://hl7.org/fhir/us/qicore/StructureDefinition/", url);
			bool? j_ = context.Operators.Equal(h_, i_);

			return j_;
		};
		IEnumerable<Extension> c_ = context.Operators.Where<Extension>((IEnumerable<Extension>)a_, b_);
		Extension d_(Extension E) => 
			E;
		IEnumerable<Extension> e_ = context.Operators.Select<Extension, Extension>(c_, d_);

		return e_;
	}

	public Extension GetModifierExtension(CqlContext context, DomainResource domainResource, string url)
	{
		IEnumerable<Extension> a_ = this.GetModifierExtensions(context, domainResource, url);
		Extension b_ = context.Operators.SingletonFrom<Extension>(a_);

		return b_;
	}


    [CqlDeclaration("Medical or Patient Reason for Not Communicating Level of Severity of Retinopathy")]
	public IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy(CqlContext context)
	{
		CqlValueSet a_ = this.Level_of_Severity_of_Retinopathy_Findings(context);
		PropertyInfo b_ = typeof(Communication).GetProperty("ReasonCode");
		IEnumerable<Communication> c_ = context.Operators.RetrieveByValueSet<Communication>(a_, b_);
		IEnumerable<Communication> d_(Communication LevelOfSeverityNotCommunicated)
		{
			IEnumerable<Encounter> h_ = this.Diabetic_Retinopathy_Encounter(context);
			bool? i_(Encounter EncounterDiabeticRetinopathy)
			{
				Period m_ = EncounterDiabeticRetinopathy?.Period;
				CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, m_);
				Extension o_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.GetExtension(context, LevelOfSeverityNotCommunicated, "qicore-recorded");
				DataType p_ = o_?.Value;
				CqlInterval<CqlDateTime> q_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, p_ as Period);
				bool? r_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(n_, q_, default);

				return r_;
			};
			IEnumerable<Encounter> j_ = context.Operators.Where<Encounter>(h_, i_);
			Communication k_(Encounter EncounterDiabeticRetinopathy) => 
				LevelOfSeverityNotCommunicated;
			IEnumerable<Communication> l_ = context.Operators.Select<Encounter, Communication>(j_, k_);

			return l_;
		};
		IEnumerable<Communication> e_ = context.Operators.SelectMany<Communication, Communication>(c_, d_);
		bool? f_(Communication LevelOfSeverityNotCommunicated)
		{
			Code<EventStatus> s_ = LevelOfSeverityNotCommunicated?.StatusElement;
			string t_ = FHIRHelpers_4_0_001.Instance.ToString(context, s_);
			bool? u_ = context.Operators.Equal(t_, "not-done");
			Extension v_ = this.GetModifierExtension(context, LevelOfSeverityNotCommunicated, "qicore-notDone");
			DataType w_ = v_?.Value;
			bool? x_ = FHIRHelpers_4_0_001.Instance.ToBoolean(context, w_ as FhirBoolean);
			bool? y_ = context.Operators.IsTrue(x_);
			bool? z_ = context.Operators.And(u_, y_);
			CodeableConcept aa_ = LevelOfSeverityNotCommunicated?.StatusReason;
			CqlConcept ab_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, aa_);
			CqlValueSet ac_ = this.Medical_Reason(context);
			bool? ad_ = context.Operators.ConceptInValueSet(ab_, ac_);
			CqlConcept af_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, aa_);
			CqlValueSet ag_ = this.Patient_Reason(context);
			bool? ah_ = context.Operators.ConceptInValueSet(af_, ag_);
			bool? ai_ = context.Operators.Or(ad_, ah_);
			bool? aj_ = context.Operators.And(z_, ai_);

			return aj_;
		};
		IEnumerable<Communication> g_ = context.Operators.Where<Communication>(e_, f_);

		return g_;
	}


    [CqlDeclaration("Medical or Patient Reason for Not Communicating Absence of Macular Edema")]
	public IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema(CqlContext context)
	{
		CqlCode a_ = this.Macular_edema_absent__situation_(context);
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		PropertyInfo c_ = typeof(Communication).GetProperty("ReasonCode");
		IEnumerable<Communication> d_ = context.Operators.RetrieveByCodes<Communication>(b_, c_);
		IEnumerable<Communication> e_(Communication MacularEdemaAbsentNotCommunicated)
		{
			IEnumerable<Encounter> i_ = this.Diabetic_Retinopathy_Encounter(context);
			bool? j_(Encounter EncounterDiabeticRetinopathy)
			{
				Period n_ = EncounterDiabeticRetinopathy?.Period;
				CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, n_);
				Extension p_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.GetExtension(context, MacularEdemaAbsentNotCommunicated, "qicore-recorded");
				DataType q_ = p_?.Value;
				CqlInterval<CqlDateTime> r_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, q_ as Period);
				bool? s_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(o_, r_, default);

				return s_;
			};
			IEnumerable<Encounter> k_ = context.Operators.Where<Encounter>(i_, j_);
			Communication l_(Encounter EncounterDiabeticRetinopathy) => 
				MacularEdemaAbsentNotCommunicated;
			IEnumerable<Communication> m_ = context.Operators.Select<Encounter, Communication>(k_, l_);

			return m_;
		};
		IEnumerable<Communication> f_ = context.Operators.SelectMany<Communication, Communication>(d_, e_);
		bool? g_(Communication MacularEdemaAbsentNotCommunicated)
		{
			Code<EventStatus> t_ = MacularEdemaAbsentNotCommunicated?.StatusElement;
			string u_ = FHIRHelpers_4_0_001.Instance.ToString(context, t_);
			bool? v_ = context.Operators.Equal(u_, "not-done");
			Extension w_ = this.GetModifierExtension(context, MacularEdemaAbsentNotCommunicated, "qicore-notDone");
			DataType x_ = w_?.Value;
			bool? y_ = FHIRHelpers_4_0_001.Instance.ToBoolean(context, x_ as FhirBoolean);
			bool? z_ = context.Operators.IsTrue(y_);
			bool? aa_ = context.Operators.And(v_, z_);
			CodeableConcept ab_ = MacularEdemaAbsentNotCommunicated?.StatusReason;
			CqlConcept ac_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, ab_);
			CqlValueSet ad_ = this.Medical_Reason(context);
			bool? ae_ = context.Operators.ConceptInValueSet(ac_, ad_);
			CqlConcept ag_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, ab_);
			CqlValueSet ah_ = this.Patient_Reason(context);
			bool? ai_ = context.Operators.ConceptInValueSet(ag_, ah_);
			bool? aj_ = context.Operators.Or(ae_, ai_);
			bool? ak_ = context.Operators.And(aa_, aj_);

			return ak_;
		};
		IEnumerable<Communication> h_ = context.Operators.Where<Communication>(f_, g_);

		return h_;
	}


    [CqlDeclaration("Medical or Patient Reason for Not Communicating Presence of Macular Edema")]
	public IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Presence_of_Macular_Edema(CqlContext context)
	{
		CqlValueSet a_ = this.Macular_Edema_Findings_Present(context);
		PropertyInfo b_ = typeof(Communication).GetProperty("ReasonCode");
		IEnumerable<Communication> c_ = context.Operators.RetrieveByValueSet<Communication>(a_, b_);
		IEnumerable<Communication> d_(Communication MacularEdemaPresentNotCommunicated)
		{
			IEnumerable<Encounter> h_ = this.Diabetic_Retinopathy_Encounter(context);
			bool? i_(Encounter EncounterDiabeticRetinopathy)
			{
				Period m_ = EncounterDiabeticRetinopathy?.Period;
				CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, m_);
				Extension o_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.GetExtension(context, MacularEdemaPresentNotCommunicated, "qicore-recorded");
				DataType p_ = o_?.Value;
				CqlInterval<CqlDateTime> q_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, p_ as Period);
				bool? r_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(n_, q_, default);

				return r_;
			};
			IEnumerable<Encounter> j_ = context.Operators.Where<Encounter>(h_, i_);
			Communication k_(Encounter EncounterDiabeticRetinopathy) => 
				MacularEdemaPresentNotCommunicated;
			IEnumerable<Communication> l_ = context.Operators.Select<Encounter, Communication>(j_, k_);

			return l_;
		};
		IEnumerable<Communication> e_ = context.Operators.SelectMany<Communication, Communication>(c_, d_);
		bool? f_(Communication MacularEdemaPresentNotCommunicated)
		{
			Code<EventStatus> s_ = MacularEdemaPresentNotCommunicated?.StatusElement;
			string t_ = FHIRHelpers_4_0_001.Instance.ToString(context, s_);
			bool? u_ = context.Operators.Equal(t_, "not-done");
			Extension v_ = this.GetModifierExtension(context, MacularEdemaPresentNotCommunicated, "qicore-notDone");
			DataType w_ = v_?.Value;
			bool? x_ = FHIRHelpers_4_0_001.Instance.ToBoolean(context, w_ as FhirBoolean);
			bool? y_ = context.Operators.IsTrue(x_);
			bool? z_ = context.Operators.And(u_, y_);
			CodeableConcept aa_ = MacularEdemaPresentNotCommunicated?.StatusReason;
			CqlConcept ab_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, aa_);
			CqlValueSet ac_ = this.Medical_Reason(context);
			bool? ad_ = context.Operators.ConceptInValueSet(ab_, ac_);
			CqlConcept af_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, aa_);
			CqlValueSet ag_ = this.Patient_Reason(context);
			bool? ah_ = context.Operators.ConceptInValueSet(af_, ag_);
			bool? ai_ = context.Operators.Or(ad_, ah_);
			bool? aj_ = context.Operators.And(z_, ai_);

			return aj_;
		};
		IEnumerable<Communication> g_ = context.Operators.Where<Communication>(e_, f_);

		return g_;
	}


    [CqlDeclaration("Denominator Exceptions")]
	public bool? Denominator_Exceptions(CqlContext context)
	{
		IEnumerable<Communication> a_ = this.Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy(context);
		bool? b_ = context.Operators.Exists<Communication>(a_);
		IEnumerable<Communication> c_ = this.Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema(context);
		bool? d_ = context.Operators.Exists<Communication>(c_);
		bool? e_ = context.Operators.Or(b_, d_);
		IEnumerable<Communication> f_ = this.Medical_or_Patient_Reason_for_Not_Communicating_Presence_of_Macular_Edema(context);
		bool? g_ = context.Operators.Exists<Communication>(f_);
		bool? h_ = context.Operators.Or(e_, g_);

		return h_;
	}


    [CqlDeclaration("Initial Population")]
	public bool? Initial_Population(CqlContext context)
	{
		Patient a_ = this.Patient(context);
		Date b_ = a_?.BirthDateElement;
		string c_ = b_?.Value;
		CqlDateTime d_ = context.Operators.ConvertStringToDateTime(c_);
		CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
		CqlDateTime f_ = context.Operators.Start(e_);
		int? g_ = context.Operators.CalculateAgeAt(d_, f_, "year");
		bool? h_ = context.Operators.GreaterOrEqual(g_, 18);
		IEnumerable<Encounter> i_ = this.Diabetic_Retinopathy_Encounter(context);
		bool? j_ = context.Operators.Exists<Encounter>(i_);
		bool? k_ = context.Operators.And(h_, j_);

		return k_;
	}


    [CqlDeclaration("Macular Exam Performed")]
	public IEnumerable<Observation> Macular_Exam_Performed(CqlContext context)
	{
		CqlValueSet a_ = this.Macular_Exam(context);
		IEnumerable<Observation> b_ = context.Operators.RetrieveByValueSet<Observation>(a_, default);
		IEnumerable<Observation> c_(Observation MacularExam)
		{
			IEnumerable<Encounter> g_ = this.Diabetic_Retinopathy_Encounter(context);
			bool? h_(Encounter EncounterDiabeticRetinopathy)
			{
				Period l_ = EncounterDiabeticRetinopathy?.Period;
				CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, l_);
				DataType n_ = MacularExam?.Effective;
				CqlInterval<CqlDateTime> o_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, n_);
				bool? p_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(m_, o_, default);

				return p_;
			};
			IEnumerable<Encounter> i_ = context.Operators.Where<Encounter>(g_, h_);
			Observation j_(Encounter EncounterDiabeticRetinopathy) => 
				MacularExam;
			IEnumerable<Observation> k_ = context.Operators.Select<Encounter, Observation>(i_, j_);

			return k_;
		};
		IEnumerable<Observation> d_ = context.Operators.SelectMany<Observation, Observation>(b_, c_);
		bool? e_(Observation MacularExam)
		{
			Code<ObservationStatus> q_ = MacularExam?.StatusElement;
			string r_ = FHIRHelpers_4_0_001.Instance.ToString(context, q_);
			string[] s_ = [
				"final",
				"amended",
				"corrected",
			];
			bool? t_ = context.Operators.In<string>(r_, s_ as IEnumerable<string>);
			DataType u_ = MacularExam?.Value;
			bool? v_ = context.Operators.Not((bool?)(u_ is null));
			bool? w_ = context.Operators.And(t_, v_);

			return w_;
		};
		IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);

		return f_;
	}


    [CqlDeclaration("Denominator")]
	public bool? Denominator(CqlContext context)
	{
		bool? a_ = this.Initial_Population(context);
		IEnumerable<Observation> b_ = this.Macular_Exam_Performed(context);
		bool? c_ = context.Operators.Exists<Observation>(b_);
		bool? d_ = context.Operators.And(a_, c_);

		return d_;
	}


    [CqlDeclaration("Level of Severity of Retinopathy Findings Communicated")]
	public IEnumerable<Communication> Level_of_Severity_of_Retinopathy_Findings_Communicated(CqlContext context)
	{
		CqlValueSet a_ = this.Level_of_Severity_of_Retinopathy_Findings(context);
		PropertyInfo b_ = typeof(Communication).GetProperty("ReasonCode");
		IEnumerable<Communication> c_ = context.Operators.RetrieveByValueSet<Communication>(a_, b_);
		IEnumerable<Communication> d_(Communication LevelOfSeverityCommunicated)
		{
			IEnumerable<Encounter> h_ = this.Diabetic_Retinopathy_Encounter(context);
			bool? i_(Encounter EncounterDiabeticRetinopathy)
			{
				FhirDateTime m_ = LevelOfSeverityCommunicated?.SentElement;
				CqlDateTime n_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, m_);
				Period o_ = EncounterDiabeticRetinopathy?.Period;
				CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, o_);
				CqlDateTime q_ = context.Operators.Start(p_);
				bool? r_ = context.Operators.After(n_, q_, default);

				return r_;
			};
			IEnumerable<Encounter> j_ = context.Operators.Where<Encounter>(h_, i_);
			Communication k_(Encounter EncounterDiabeticRetinopathy) => 
				LevelOfSeverityCommunicated;
			IEnumerable<Communication> l_ = context.Operators.Select<Encounter, Communication>(j_, k_);

			return l_;
		};
		IEnumerable<Communication> e_ = context.Operators.SelectMany<Communication, Communication>(c_, d_);
		bool? f_(Communication LevelOfSeverityCommunicated)
		{
			Code<EventStatus> s_ = LevelOfSeverityCommunicated?.StatusElement;
			string t_ = FHIRHelpers_4_0_001.Instance.ToString(context, s_);
			bool? u_ = context.Operators.Equal(t_, "completed");

			return u_;
		};
		IEnumerable<Communication> g_ = context.Operators.Where<Communication>(e_, f_);

		return g_;
	}


    [CqlDeclaration("Macular Edema Absence Communicated")]
	public IEnumerable<Communication> Macular_Edema_Absence_Communicated(CqlContext context)
	{
		CqlCode a_ = this.Macular_edema_absent__situation_(context);
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		PropertyInfo c_ = typeof(Communication).GetProperty("ReasonCode");
		IEnumerable<Communication> d_ = context.Operators.RetrieveByCodes<Communication>(b_, c_);
		IEnumerable<Communication> e_(Communication MacularEdemaAbsentCommunicated)
		{
			IEnumerable<Encounter> i_ = this.Diabetic_Retinopathy_Encounter(context);
			bool? j_(Encounter EncounterDiabeticRetinopathy)
			{
				FhirDateTime n_ = MacularEdemaAbsentCommunicated?.SentElement;
				CqlDateTime o_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, n_);
				Period p_ = EncounterDiabeticRetinopathy?.Period;
				CqlInterval<CqlDateTime> q_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, p_);
				CqlDateTime r_ = context.Operators.Start(q_);
				bool? s_ = context.Operators.After(o_, r_, default);

				return s_;
			};
			IEnumerable<Encounter> k_ = context.Operators.Where<Encounter>(i_, j_);
			Communication l_(Encounter EncounterDiabeticRetinopathy) => 
				MacularEdemaAbsentCommunicated;
			IEnumerable<Communication> m_ = context.Operators.Select<Encounter, Communication>(k_, l_);

			return m_;
		};
		IEnumerable<Communication> f_ = context.Operators.SelectMany<Communication, Communication>(d_, e_);
		bool? g_(Communication MacularEdemaAbsentCommunicated)
		{
			Code<EventStatus> t_ = MacularEdemaAbsentCommunicated?.StatusElement;
			string u_ = FHIRHelpers_4_0_001.Instance.ToString(context, t_);
			bool? v_ = context.Operators.Equal(u_, "completed");

			return v_;
		};
		IEnumerable<Communication> h_ = context.Operators.Where<Communication>(f_, g_);

		return h_;
	}


    [CqlDeclaration("Macular Edema Presence Communicated")]
	public IEnumerable<Communication> Macular_Edema_Presence_Communicated(CqlContext context)
	{
		CqlValueSet a_ = this.Macular_Edema_Findings_Present(context);
		PropertyInfo b_ = typeof(Communication).GetProperty("ReasonCode");
		IEnumerable<Communication> c_ = context.Operators.RetrieveByValueSet<Communication>(a_, b_);
		IEnumerable<Communication> d_(Communication MacularEdemaPresentCommunicated)
		{
			IEnumerable<Encounter> h_ = this.Diabetic_Retinopathy_Encounter(context);
			bool? i_(Encounter EncounterDiabeticRetinopathy)
			{
				FhirDateTime m_ = MacularEdemaPresentCommunicated?.SentElement;
				CqlDateTime n_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, m_);
				Period o_ = EncounterDiabeticRetinopathy?.Period;
				CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, o_);
				CqlDateTime q_ = context.Operators.Start(p_);
				bool? r_ = context.Operators.After(n_, q_, default);

				return r_;
			};
			IEnumerable<Encounter> j_ = context.Operators.Where<Encounter>(h_, i_);
			Communication k_(Encounter EncounterDiabeticRetinopathy) => 
				MacularEdemaPresentCommunicated;
			IEnumerable<Communication> l_ = context.Operators.Select<Encounter, Communication>(j_, k_);

			return l_;
		};
		IEnumerable<Communication> e_ = context.Operators.SelectMany<Communication, Communication>(c_, d_);
		bool? f_(Communication MacularEdemaPresentCommunicated)
		{
			Code<EventStatus> s_ = MacularEdemaPresentCommunicated?.StatusElement;
			string t_ = FHIRHelpers_4_0_001.Instance.ToString(context, s_);
			bool? u_ = context.Operators.Equal(t_, "completed");

			return u_;
		};
		IEnumerable<Communication> g_ = context.Operators.Where<Communication>(e_, f_);

		return g_;
	}


    [CqlDeclaration("Results of Dilated Macular or Fundus Exam Communicated")]
	public bool? Results_of_Dilated_Macular_or_Fundus_Exam_Communicated(CqlContext context)
	{
		IEnumerable<Communication> a_ = this.Level_of_Severity_of_Retinopathy_Findings_Communicated(context);
		bool? b_ = context.Operators.Exists<Communication>(a_);
		IEnumerable<Communication> c_ = this.Macular_Edema_Absence_Communicated(context);
		bool? d_ = context.Operators.Exists<Communication>(c_);
		IEnumerable<Communication> e_ = this.Macular_Edema_Presence_Communicated(context);
		bool? f_ = context.Operators.Exists<Communication>(e_);
		bool? g_ = context.Operators.Or(d_, f_);
		bool? h_ = context.Operators.And(b_, g_);

		return h_;
	}


    [CqlDeclaration("Numerator")]
	public bool? Numerator(CqlContext context)
	{
		IEnumerable<Communication> a_ = this.Level_of_Severity_of_Retinopathy_Findings_Communicated(context);
		bool? b_ = context.Operators.Exists<Communication>(a_);
		IEnumerable<Communication> c_ = this.Macular_Edema_Absence_Communicated(context);
		bool? d_ = context.Operators.Exists<Communication>(c_);
		IEnumerable<Communication> e_ = this.Macular_Edema_Presence_Communicated(context);
		bool? f_ = context.Operators.Exists<Communication>(e_);
		bool? g_ = context.Operators.Or(d_, f_);
		bool? h_ = context.Operators.And(b_, g_);

		return h_;
	}

}
