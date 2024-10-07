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
[CqlLibrary("DRCommunicationWithPhysicianManagingDiabetesFHIR", "0.1.000")]
public partial class DRCommunicationWithPhysicianManagingDiabetesFHIR_0_1_000 : ISingleton<DRCommunicationWithPhysicianManagingDiabetesFHIR_0_1_000>
{
    private DRCommunicationWithPhysicianManagingDiabetesFHIR_0_1_000() {}

    public static DRCommunicationWithPhysicianManagingDiabetesFHIR_0_1_000 Instance { get; } = new();


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


    [CqlDeclaration("Macular edema absent (situation)")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.2.1391")]
	public CqlValueSet Macular_edema_absent__situation_(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.2.1391", default);


    [CqlDeclaration("Healthcare professional (occupation)")]
	public CqlCode Healthcare_professional__occupation_(CqlContext context) => 
		new CqlCode("223366009", "http://snomed.info/sct", default, default);


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


    [CqlDeclaration("virtual")]
	public CqlCode @virtual(CqlContext context) => 
		new CqlCode("VR", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);


    [CqlDeclaration("AMB")]
	public CqlCode AMB(CqlContext context) => 
		new CqlCode("AMB", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);


    [CqlDeclaration("SNOMEDCT")]
	public CqlCode[] SNOMEDCT(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("223366009", "http://snomed.info/sct", default, default),
			new CqlCode("158965000", "http://snomed.info/sct", default, default),
			new CqlCode("422234006", "http://snomed.info/sct", default, default),
			new CqlCode("28229004", "http://snomed.info/sct", default, default),
			new CqlCode("309343006", "http://snomed.info/sct", default, default),
		];

		return a_;
	}


    [CqlDeclaration("ActCode")]
	public CqlCode[] ActCode(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("VR", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default),
			new CqlCode("AMB", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default),
		];

		return a_;
	}


    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
	{
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("DRCommunicationWithPhysicianManagingDiabetesFHIR-0.1.000", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
	}


    [CqlDeclaration("Patient")]
	public Patient Patient(CqlContext context)
	{
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(default, default);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}


    [CqlDeclaration("SDE Ethnicity")]
	public (IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
	{
		(IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_4_000.Instance.SDE_Ethnicity(context);

		return a_;
	}


    [CqlDeclaration("SDE Payer")]
	public IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
	{
		IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_3_4_000.Instance.SDE_Payer(context);

		return a_;
	}


    [CqlDeclaration("SDE Race")]
	public (IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
	{
		(IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_4_000.Instance.SDE_Race(context);

		return a_;
	}


    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex(CqlContext context)
	{
		CqlCode a_ = SupplementalDataElements_3_4_000.Instance.SDE_Sex(context);

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
			CqlInterval<CqlDateTime> s_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, r_);
			bool? t_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(q_, s_, default);
			Code<Encounter.EncounterStatus> u_ = QualifyingEncounter?.StatusElement;
			Encounter.EncounterStatus? v_ = u_?.Value;
			Code<Encounter.EncounterStatus> w_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(v_);
			bool? x_ = context.Operators.Equal(w_, "finished");
			bool? y_ = context.Operators.And(t_, x_);
			Coding z_ = QualifyingEncounter?.Class;
			CqlCode aa_ = FHIRHelpers_4_3_000.Instance.ToCode(context, z_);
			CqlCode ab_ = this.@virtual(context);
			bool? ac_ = context.Operators.Equivalent(aa_, ab_);
			bool? ad_ = context.Operators.Not(ac_);
			bool? ae_ = context.Operators.And(y_, ad_);

			return ae_;
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
				CqlInterval<CqlDateTime> j_ = QICoreCommon_2_0_000.Instance.prevalenceInterval(context, DiabeticRetinopathy);
				Period k_ = ValidQualifyingEncounter?.Period;
				CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, k_);
				bool? m_ = context.Operators.Overlaps(j_, l_, default);
				bool? n_ = QICoreCommon_2_0_000.Instance.isActive(context, DiabeticRetinopathy);
				bool? o_ = context.Operators.And(m_, n_);
				CodeableConcept p_ = DiabeticRetinopathy?.VerificationStatus;
				CqlConcept q_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, p_);
				CqlCode r_ = QICoreCommon_2_0_000.Instance.unconfirmed(context);
				CqlConcept s_ = context.Operators.ConvertCodeToConcept(r_);
				bool? t_ = context.Operators.Equivalent(q_, s_);
				CqlConcept v_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, p_);
				CqlCode w_ = QICoreCommon_2_0_000.Instance.refuted(context);
				CqlConcept x_ = context.Operators.ConvertCodeToConcept(w_);
				bool? y_ = context.Operators.Equivalent(v_, x_);
				bool? z_ = context.Operators.Or(t_, y_);
				CqlConcept ab_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, p_);
				CqlCode ac_ = QICoreCommon_2_0_000.Instance.entered_in_error(context);
				CqlConcept ad_ = context.Operators.ConvertCodeToConcept(ac_);
				bool? ae_ = context.Operators.Equivalent(ab_, ad_);
				bool? af_ = context.Operators.Or(z_, ae_);
				bool? ag_ = context.Operators.Not(af_);
				bool? ah_ = context.Operators.And(o_, ag_);

				return ah_;
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


    [CqlDeclaration("Initial Population")]
	public bool? Initial_Population(CqlContext context)
	{
		Patient a_ = this.Patient(context);
		Date b_ = a_?.BirthDateElement;
		string c_ = b_?.Value;
		CqlDate d_ = context.Operators.ConvertStringToDate(c_);
		CqlInterval<CqlDateTime> e_ = this.Measurement_Period(context);
		CqlDateTime f_ = context.Operators.Start(e_);
		CqlDate g_ = context.Operators.DateFrom(f_);
		int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
		bool? i_ = context.Operators.GreaterOrEqual(h_, 18);
		IEnumerable<Encounter> j_ = this.Diabetic_Retinopathy_Encounter(context);
		bool? k_ = context.Operators.Exists<Encounter>(j_);
		bool? l_ = context.Operators.And(i_, k_);

		return l_;
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
				CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, l_);
				DataType n_ = MacularExam?.Effective;
				object o_ = FHIRHelpers_4_3_000.Instance.ToValue(context, n_);
				CqlInterval<CqlDateTime> p_ = QICoreCommon_2_0_000.Instance.toInterval(context, o_);
				bool? q_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(m_, p_, default);

				return q_;
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
			DataType r_ = MacularExam?.Value;
			object s_ = FHIRHelpers_4_3_000.Instance.ToValue(context, r_);
			bool? t_ = context.Operators.Not((bool?)(s_ is null));
			Code<ObservationStatus> u_ = MacularExam?.StatusElement;
			ObservationStatus? v_ = u_?.Value;
			Code<ObservationStatus> w_ = context.Operators.Convert<Code<ObservationStatus>>(v_);
			string x_ = context.Operators.Convert<string>(w_);
			string[] y_ = [
				"final",
				"amended",
				"corrected",
				"preliminary",
			];
			bool? z_ = context.Operators.In<string>(x_, y_ as IEnumerable<string>);
			bool? aa_ = context.Operators.And(t_, z_);

			return aa_;
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
				CqlDateTime n_ = context.Operators.Convert<CqlDateTime>(m_);
				Period o_ = EncounterDiabeticRetinopathy?.Period;
				CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, o_);
				CqlDateTime q_ = context.Operators.Start(p_);
				bool? r_ = context.Operators.After(n_, q_, default);
				CqlDateTime t_ = context.Operators.Convert<CqlDateTime>(m_);
				CqlInterval<CqlDateTime> u_ = this.Measurement_Period(context);
				bool? v_ = context.Operators.In<CqlDateTime>(t_, u_, "day");
				bool? w_ = context.Operators.And(r_, v_);

				return w_;
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
			Code<EventStatus> x_ = LevelOfSeverityCommunicated?.StatusElement;
			EventStatus? y_ = x_?.Value;
			Code<EventStatus> z_ = context.Operators.Convert<Code<EventStatus>>(y_);
			bool? aa_ = context.Operators.Equal(z_, "completed");

			return aa_;
		};
		IEnumerable<Communication> g_ = context.Operators.Where<Communication>(e_, f_);

		return g_;
	}


    [CqlDeclaration("Macular Edema Absence Communicated")]
	public IEnumerable<Communication> Macular_Edema_Absence_Communicated(CqlContext context)
	{
		CqlValueSet a_ = this.Macular_edema_absent__situation_(context);
		PropertyInfo b_ = typeof(Communication).GetProperty("ReasonCode");
		IEnumerable<Communication> c_ = context.Operators.RetrieveByValueSet<Communication>(a_, b_);
		IEnumerable<Communication> d_(Communication MacularEdemaAbsentCommunicated)
		{
			IEnumerable<Encounter> h_ = this.Diabetic_Retinopathy_Encounter(context);
			bool? i_(Encounter EncounterDiabeticRetinopathy)
			{
				FhirDateTime m_ = MacularEdemaAbsentCommunicated?.SentElement;
				CqlDateTime n_ = context.Operators.Convert<CqlDateTime>(m_);
				Period o_ = EncounterDiabeticRetinopathy?.Period;
				CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, o_);
				CqlDateTime q_ = context.Operators.Start(p_);
				bool? r_ = context.Operators.After(n_, q_, default);
				CqlDateTime t_ = context.Operators.Convert<CqlDateTime>(m_);
				CqlInterval<CqlDateTime> u_ = this.Measurement_Period(context);
				bool? v_ = context.Operators.In<CqlDateTime>(t_, u_, "day");
				bool? w_ = context.Operators.And(r_, v_);

				return w_;
			};
			IEnumerable<Encounter> j_ = context.Operators.Where<Encounter>(h_, i_);
			Communication k_(Encounter EncounterDiabeticRetinopathy) => 
				MacularEdemaAbsentCommunicated;
			IEnumerable<Communication> l_ = context.Operators.Select<Encounter, Communication>(j_, k_);

			return l_;
		};
		IEnumerable<Communication> e_ = context.Operators.SelectMany<Communication, Communication>(c_, d_);
		bool? f_(Communication MacularEdemaAbsentCommunicated)
		{
			Code<EventStatus> x_ = MacularEdemaAbsentCommunicated?.StatusElement;
			EventStatus? y_ = x_?.Value;
			Code<EventStatus> z_ = context.Operators.Convert<Code<EventStatus>>(y_);
			bool? aa_ = context.Operators.Equal(z_, "completed");

			return aa_;
		};
		IEnumerable<Communication> g_ = context.Operators.Where<Communication>(e_, f_);

		return g_;
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
				CqlDateTime n_ = context.Operators.Convert<CqlDateTime>(m_);
				Period o_ = EncounterDiabeticRetinopathy?.Period;
				CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, o_);
				CqlDateTime q_ = context.Operators.Start(p_);
				bool? r_ = context.Operators.After(n_, q_, default);
				CqlDateTime t_ = context.Operators.Convert<CqlDateTime>(m_);
				CqlInterval<CqlDateTime> u_ = this.Measurement_Period(context);
				bool? v_ = context.Operators.In<CqlDateTime>(t_, u_, "day");
				bool? w_ = context.Operators.And(r_, v_);

				return w_;
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
			Code<EventStatus> x_ = MacularEdemaPresentCommunicated?.StatusElement;
			EventStatus? y_ = x_?.Value;
			Code<EventStatus> z_ = context.Operators.Convert<Code<EventStatus>>(y_);
			bool? aa_ = context.Operators.Equal(z_, "completed");

			return aa_;
		};
		IEnumerable<Communication> g_ = context.Operators.Where<Communication>(e_, f_);

		return g_;
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


    [CqlDeclaration("Medical or Patient Reason for Not Communicating Level of Severity of Retinopathy")]
	public IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy(CqlContext context)
	{
		CqlValueSet a_ = this.Level_of_Severity_of_Retinopathy_Findings(context);
		PropertyInfo b_ = typeof(Communication).GetProperty("ReasonCode");
		IEnumerable<Communication> c_ = context.Operators.RetrieveByValueSet<Communication>(a_, b_);
		IEnumerable<Communication> f_ = context.Operators.RetrieveByValueSet<Communication>(a_, b_);
		IEnumerable<Communication> g_ = context.Operators.Union<Communication>(c_, f_);
		IEnumerable<Communication> h_(Communication LevelOfSeverityNotCommunicated)
		{
			IEnumerable<Encounter> l_ = this.Diabetic_Retinopathy_Encounter(context);
			bool? m_(Encounter EncounterDiabeticRetinopathy)
			{
				bool? q_(Extension @this)
				{
					string z_ = @this?.Url;
					FhirString aa_ = context.Operators.Convert<FhirString>(z_);
					string ab_ = FHIRHelpers_4_3_000.Instance.ToString(context, aa_);
					bool? ac_ = context.Operators.Equal(ab_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");

					return ac_;
				};
				IEnumerable<Extension> r_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(LevelOfSeverityNotCommunicated is DomainResource
						? (LevelOfSeverityNotCommunicated as DomainResource).Extension
						: default), q_);
				DataType s_(Extension @this)
				{
					DataType ad_ = @this?.Value;

					return ad_;
				};
				IEnumerable<DataType> t_ = context.Operators.Select<Extension, DataType>(r_, s_);
				DataType u_ = context.Operators.SingletonFrom<DataType>(t_);
				CqlDateTime v_ = context.Operators.Convert<CqlDateTime>(u_);
				Period w_ = EncounterDiabeticRetinopathy?.Period;
				CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, w_);
				bool? y_ = context.Operators.In<CqlDateTime>(v_, x_, default);

				return y_;
			};
			IEnumerable<Encounter> n_ = context.Operators.Where<Encounter>(l_, m_);
			Communication o_(Encounter EncounterDiabeticRetinopathy) => 
				LevelOfSeverityNotCommunicated;
			IEnumerable<Communication> p_ = context.Operators.Select<Encounter, Communication>(n_, o_);

			return p_;
		};
		IEnumerable<Communication> i_ = context.Operators.SelectMany<Communication, Communication>(g_, h_);
		bool? j_(Communication LevelOfSeverityNotCommunicated)
		{
			CodeableConcept ae_ = LevelOfSeverityNotCommunicated?.StatusReason;
			CqlConcept af_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, ae_);
			CqlValueSet ag_ = this.Medical_Reason(context);
			bool? ah_ = context.Operators.ConceptInValueSet(af_, ag_);
			CqlConcept aj_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, ae_);
			CqlValueSet ak_ = this.Patient_Reason(context);
			bool? al_ = context.Operators.ConceptInValueSet(aj_, ak_);
			bool? am_ = context.Operators.Or(ah_, al_);

			return am_;
		};
		IEnumerable<Communication> k_ = context.Operators.Where<Communication>(i_, j_);

		return k_;
	}


    [CqlDeclaration("Medical or Patient Reason for Not Communicating Absence of Macular Edema")]
	public IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema(CqlContext context)
	{
		CqlValueSet a_ = this.Macular_edema_absent__situation_(context);
		PropertyInfo b_ = typeof(Communication).GetProperty("ReasonCode");
		IEnumerable<Communication> c_ = context.Operators.RetrieveByValueSet<Communication>(a_, b_);
		IEnumerable<Communication> f_ = context.Operators.RetrieveByValueSet<Communication>(a_, b_);
		IEnumerable<Communication> g_ = context.Operators.Union<Communication>(c_, f_);
		IEnumerable<Communication> h_(Communication MacularEdemaAbsentNotCommunicated)
		{
			IEnumerable<Encounter> l_ = this.Diabetic_Retinopathy_Encounter(context);
			bool? m_(Encounter EncounterDiabeticRetinopathy)
			{
				bool? q_(Extension @this)
				{
					string z_ = @this?.Url;
					FhirString aa_ = context.Operators.Convert<FhirString>(z_);
					string ab_ = FHIRHelpers_4_3_000.Instance.ToString(context, aa_);
					bool? ac_ = context.Operators.Equal(ab_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");

					return ac_;
				};
				IEnumerable<Extension> r_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(MacularEdemaAbsentNotCommunicated is DomainResource
						? (MacularEdemaAbsentNotCommunicated as DomainResource).Extension
						: default), q_);
				DataType s_(Extension @this)
				{
					DataType ad_ = @this?.Value;

					return ad_;
				};
				IEnumerable<DataType> t_ = context.Operators.Select<Extension, DataType>(r_, s_);
				DataType u_ = context.Operators.SingletonFrom<DataType>(t_);
				CqlDateTime v_ = context.Operators.Convert<CqlDateTime>(u_);
				Period w_ = EncounterDiabeticRetinopathy?.Period;
				CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, w_);
				bool? y_ = context.Operators.In<CqlDateTime>(v_, x_, default);

				return y_;
			};
			IEnumerable<Encounter> n_ = context.Operators.Where<Encounter>(l_, m_);
			Communication o_(Encounter EncounterDiabeticRetinopathy) => 
				MacularEdemaAbsentNotCommunicated;
			IEnumerable<Communication> p_ = context.Operators.Select<Encounter, Communication>(n_, o_);

			return p_;
		};
		IEnumerable<Communication> i_ = context.Operators.SelectMany<Communication, Communication>(g_, h_);
		bool? j_(Communication MacularEdemaAbsentNotCommunicated)
		{
			CodeableConcept ae_ = MacularEdemaAbsentNotCommunicated?.StatusReason;
			CqlConcept af_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, ae_);
			CqlValueSet ag_ = this.Medical_Reason(context);
			bool? ah_ = context.Operators.ConceptInValueSet(af_, ag_);
			CqlConcept aj_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, ae_);
			CqlValueSet ak_ = this.Patient_Reason(context);
			bool? al_ = context.Operators.ConceptInValueSet(aj_, ak_);
			bool? am_ = context.Operators.Or(ah_, al_);

			return am_;
		};
		IEnumerable<Communication> k_ = context.Operators.Where<Communication>(i_, j_);

		return k_;
	}


    [CqlDeclaration("Medical or Patient Reason for Not Communicating Presence of Macular Edema")]
	public IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Presence_of_Macular_Edema(CqlContext context)
	{
		CqlValueSet a_ = this.Macular_Edema_Findings_Present(context);
		PropertyInfo b_ = typeof(Communication).GetProperty("ReasonCode");
		IEnumerable<Communication> c_ = context.Operators.RetrieveByValueSet<Communication>(a_, b_);
		IEnumerable<Communication> f_ = context.Operators.RetrieveByValueSet<Communication>(a_, b_);
		IEnumerable<Communication> g_ = context.Operators.Union<Communication>(c_, f_);
		IEnumerable<Communication> h_(Communication MacularEdemaPresentNotCommunicated)
		{
			IEnumerable<Encounter> l_ = this.Diabetic_Retinopathy_Encounter(context);
			bool? m_(Encounter EncounterDiabeticRetinopathy)
			{
				bool? q_(Extension @this)
				{
					string z_ = @this?.Url;
					FhirString aa_ = context.Operators.Convert<FhirString>(z_);
					string ab_ = FHIRHelpers_4_3_000.Instance.ToString(context, aa_);
					bool? ac_ = context.Operators.Equal(ab_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");

					return ac_;
				};
				IEnumerable<Extension> r_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(MacularEdemaPresentNotCommunicated is DomainResource
						? (MacularEdemaPresentNotCommunicated as DomainResource).Extension
						: default), q_);
				DataType s_(Extension @this)
				{
					DataType ad_ = @this?.Value;

					return ad_;
				};
				IEnumerable<DataType> t_ = context.Operators.Select<Extension, DataType>(r_, s_);
				DataType u_ = context.Operators.SingletonFrom<DataType>(t_);
				CqlDateTime v_ = context.Operators.Convert<CqlDateTime>(u_);
				Period w_ = EncounterDiabeticRetinopathy?.Period;
				CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, w_);
				bool? y_ = context.Operators.In<CqlDateTime>(v_, x_, default);

				return y_;
			};
			IEnumerable<Encounter> n_ = context.Operators.Where<Encounter>(l_, m_);
			Communication o_(Encounter EncounterDiabeticRetinopathy) => 
				MacularEdemaPresentNotCommunicated;
			IEnumerable<Communication> p_ = context.Operators.Select<Encounter, Communication>(n_, o_);

			return p_;
		};
		IEnumerable<Communication> i_ = context.Operators.SelectMany<Communication, Communication>(g_, h_);
		bool? j_(Communication MacularEdemaPresentNotCommunicated)
		{
			CodeableConcept ae_ = MacularEdemaPresentNotCommunicated?.StatusReason;
			CqlConcept af_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, ae_);
			CqlValueSet ag_ = this.Medical_Reason(context);
			bool? ah_ = context.Operators.ConceptInValueSet(af_, ag_);
			CqlConcept aj_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, ae_);
			CqlValueSet ak_ = this.Patient_Reason(context);
			bool? al_ = context.Operators.ConceptInValueSet(aj_, ak_);
			bool? am_ = context.Operators.Or(ah_, al_);

			return am_;
		};
		IEnumerable<Communication> k_ = context.Operators.Where<Communication>(i_, j_);

		return k_;
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

}
