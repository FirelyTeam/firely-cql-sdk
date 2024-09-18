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
[CqlLibrary("DRCommunicationWithPhysicianManagingDiabetesFHIR", "0.0.004")]
public class DRCommunicationWithPhysicianManagingDiabetesFHIR_0_0_004
{

    public static DRCommunicationWithPhysicianManagingDiabetesFHIR_0_0_004 Instance { get; }  = new();

    [CqlDeclaration("Care Services in Long-Term Residential Facility")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014")]
	public CqlValueSet Care_Services_in_Long_Term_Residential_Facility(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014", null);

    [CqlDeclaration("Diabetic Retinopathy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.327")]
	public CqlValueSet Diabetic_Retinopathy(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.327", null);

    [CqlDeclaration("Level of Severity of Retinopathy Findings")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1283")]
	public CqlValueSet Level_of_Severity_of_Retinopathy_Findings(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1283", null);

    [CqlDeclaration("Macular Edema Findings Present")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1320")]
	public CqlValueSet Macular_Edema_Findings_Present(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1320", null);

    [CqlDeclaration("Macular Exam")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1251")]
	public CqlValueSet Macular_Exam(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1251", null);

    [CqlDeclaration("Medical Reason")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007")]
	public CqlValueSet Medical_Reason(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007", null);

    [CqlDeclaration("Nursing Facility Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012")]
	public CqlValueSet Nursing_Facility_Visit(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012", null);

    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
	public CqlValueSet Office_Visit(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlDeclaration("Ophthalmological Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285")]
	public CqlValueSet Ophthalmological_Services(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285", null);

    [CqlDeclaration("Outpatient Consultation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008")]
	public CqlValueSet Outpatient_Consultation(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", null);

    [CqlDeclaration("Patient Reason")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1008")]
	public CqlValueSet Patient_Reason(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1008", null);

    [CqlDeclaration("Birth date")]
	public CqlCode Birth_date(CqlContext context) => 
		new CqlCode("21112-8", "http://loinc.org", null, null);

    [CqlDeclaration("Healthcare professional (occupation)")]
	public CqlCode Healthcare_professional__occupation_(CqlContext context) => 
		new CqlCode("223366009", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Macular edema absent (situation)")]
	public CqlCode Macular_edema_absent__situation_(CqlContext context) => 
		new CqlCode("428341000124108", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Medical practitioner (occupation)")]
	public CqlCode Medical_practitioner__occupation_(CqlContext context) => 
		new CqlCode("158965000", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Ophthalmologist (occupation)")]
	public CqlCode Ophthalmologist__occupation_(CqlContext context) => 
		new CqlCode("422234006", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Optometrist (occupation)")]
	public CqlCode Optometrist__occupation_(CqlContext context) => 
		new CqlCode("28229004", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Physician (occupation)")]
	public CqlCode Physician__occupation_(CqlContext context) => 
		new CqlCode("309343006", "http://snomed.info/sct", null, null);

    [CqlDeclaration("LOINC")]
	public CqlCode[] LOINC(CqlContext context)
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("21112-8", "http://loinc.org", null, null),
		};

		return a_;
	}

    [CqlDeclaration("SNOMEDCT")]
	public CqlCode[] SNOMEDCT(CqlContext context)
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("223366009", "http://snomed.info/sct", null, null),
			new CqlCode("428341000124108", "http://snomed.info/sct", null, null),
			new CqlCode("158965000", "http://snomed.info/sct", null, null),
			new CqlCode("422234006", "http://snomed.info/sct", null, null),
			new CqlCode("28229004", "http://snomed.info/sct", null, null),
			new CqlCode("309343006", "http://snomed.info/sct", null, null),
		};

		return a_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
	{
		var a_ = context.ResolveParameter("DRCommunicationWithPhysicianManagingDiabetesFHIR-0.0.004", "Measurement Period", null);

		return (CqlInterval<CqlDateTime>)a_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient(CqlContext context)
	{
		var a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		var b_ = context.Operators.SingleOrNull<Patient>(a_);

		return b_;
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

    [CqlDeclaration("Qualifying Encounter During Measurement Period")]
	public IEnumerable<Encounter> Qualifying_Encounter_During_Measurement_Period(CqlContext context)
	{
		var a_ = this.Office_Visit(context);
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		var c_ = this.Ophthalmological_Services(context);
		var d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, null);
		var e_ = context.Operators.ListUnion<Encounter>(b_, d_);
		var f_ = this.Outpatient_Consultation(context);
		var g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, null);
		var h_ = this.Care_Services_in_Long_Term_Residential_Facility(context);
		var i_ = context.Operators.RetrieveByValueSet<Encounter>(h_, null);
		var j_ = context.Operators.ListUnion<Encounter>(g_, i_);
		var k_ = context.Operators.ListUnion<Encounter>(e_, j_);
		var l_ = this.Nursing_Facility_Visit(context);
		var m_ = context.Operators.RetrieveByValueSet<Encounter>(l_, null);
		var n_ = context.Operators.ListUnion<Encounter>(k_, m_);
		bool? o_(Encounter QualifyingEncounter)
		{
			var q_ = this.Measurement_Period(context);
			var r_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, QualifyingEncounter?.Period);
			var s_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(q_, r_, null);
			var t_ = context.Operators.Convert<string>(QualifyingEncounter?.StatusElement);
			var u_ = context.Operators.Equal(t_, "finished");
			var v_ = context.Operators.And(s_, u_);

			return v_;
		};
		var p_ = context.Operators.WhereOrNull<Encounter>(n_, o_);

		return p_;
	}

    [CqlDeclaration("Diabetic Retinopathy Encounter")]
	public IEnumerable<Encounter> Diabetic_Retinopathy_Encounter(CqlContext context)
	{
		var a_ = this.Qualifying_Encounter_During_Measurement_Period(context);
		IEnumerable<Encounter> b_(Encounter ValidQualifyingEncounter)
		{
			var d_ = this.Diabetic_Retinopathy(context);
			var e_ = context.Operators.RetrieveByValueSet<Condition>(d_, null);
			bool? f_(Condition DiabeticRetinopathy)
			{
				var j_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, DiabeticRetinopathy?.ClinicalStatus);
				var k_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.active(context);
				var l_ = context.Operators.ConvertCodeToConcept(k_);
				var m_ = context.Operators.Equivalent(j_, l_);
				var n_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Prevalence_Period(context, DiabeticRetinopathy);
				var o_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, ValidQualifyingEncounter?.Period);
				var p_ = context.Operators.Overlaps(n_, o_, null);
				var q_ = context.Operators.And(m_, p_);

				return q_;
			};
			var g_ = context.Operators.WhereOrNull<Condition>(e_, f_);
			Encounter h_(Condition DiabeticRetinopathy) => 
				ValidQualifyingEncounter;
			var i_ = context.Operators.SelectOrNull<Condition, Encounter>(g_, h_);

			return i_;
		};
		var c_ = context.Operators.SelectManyOrNull<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("GetModifierExtensions")]
	public IEnumerable<Extension> GetModifierExtensions(CqlContext context, DomainResource domainResource, string url)
	{
		bool? a_(Extension E)
		{
			var e_ = context.Operators.Convert<FhirUri>(E?.Url);
			var f_ = context.Operators.Convert<string>(e_);
			var g_ = context.Operators.Concatenate("http://hl7.org/fhir/us/qicore/StructureDefinition/", url);
			var h_ = context.Operators.Equal(f_, g_);

			return h_;
		};
		var b_ = context.Operators.WhereOrNull<Extension>((domainResource?.ModifierExtension as IEnumerable<Extension>), a_);
		Extension c_(Extension E) => 
			E;
		var d_ = context.Operators.SelectOrNull<Extension, Extension>(b_, c_);

		return d_;
	}

    [CqlDeclaration("GetModifierExtension")]
	public Extension GetModifierExtension(CqlContext context, DomainResource domainResource, string url)
	{
		var a_ = this.GetModifierExtensions(context, domainResource, url);
		var b_ = context.Operators.SingleOrNull<Extension>(a_);

		return b_;
	}

    [CqlDeclaration("Medical or Patient Reason for Not Communicating Level of Severity of Retinopathy")]
	public IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy(CqlContext context)
	{
		var a_ = this.Level_of_Severity_of_Retinopathy_Findings(context);
		var b_ = typeof(Communication).GetProperty("ReasonCode");
		var c_ = context.Operators.RetrieveByValueSet<Communication>(a_, b_);
		IEnumerable<Communication> d_(Communication LevelOfSeverityNotCommunicated)
		{
			var h_ = this.Diabetic_Retinopathy_Encounter(context);
			bool? i_(Encounter EncounterDiabeticRetinopathy)
			{
				var m_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, EncounterDiabeticRetinopathy?.Period);
				var n_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.GetExtension(context, LevelOfSeverityNotCommunicated, "qicore-recorded");
				var o_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, (n_?.Value as Period));
				var p_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(m_, o_, null);

				return p_;
			};
			var j_ = context.Operators.WhereOrNull<Encounter>(h_, i_);
			Communication k_(Encounter EncounterDiabeticRetinopathy) => 
				LevelOfSeverityNotCommunicated;
			var l_ = context.Operators.SelectOrNull<Encounter, Communication>(j_, k_);

			return l_;
		};
		var e_ = context.Operators.SelectManyOrNull<Communication, Communication>(c_, d_);
		bool? f_(Communication LevelOfSeverityNotCommunicated)
		{
			var q_ = context.Operators.Convert<string>(LevelOfSeverityNotCommunicated?.StatusElement);
			var r_ = context.Operators.Equal(q_, "not-done");
			var s_ = this.GetModifierExtension(context, LevelOfSeverityNotCommunicated, "qicore-notDone");
			var t_ = FHIRHelpers_4_0_001.Instance.ToBoolean(context, (s_?.Value as FhirBoolean));
			var u_ = context.Operators.IsTrue(t_);
			var v_ = context.Operators.And(r_, u_);
			var w_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, LevelOfSeverityNotCommunicated?.StatusReason);
			var x_ = this.Medical_Reason(context);
			var y_ = context.Operators.ConceptInValueSet(w_, x_);
			var aa_ = this.Patient_Reason(context);
			var ab_ = context.Operators.ConceptInValueSet(w_, aa_);
			var ac_ = context.Operators.Or(y_, ab_);
			var ad_ = context.Operators.And(v_, ac_);

			return ad_;
		};
		var g_ = context.Operators.WhereOrNull<Communication>(e_, f_);

		return g_;
	}

    [CqlDeclaration("Medical or Patient Reason for Not Communicating Absence of Macular Edema")]
	public IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema(CqlContext context)
	{
		var a_ = this.Macular_edema_absent__situation_(context);
		var b_ = context.Operators.ToList<CqlCode>(a_);
		var c_ = typeof(Communication).GetProperty("ReasonCode");
		var d_ = context.Operators.RetrieveByCodes<Communication>(b_, c_);
		IEnumerable<Communication> e_(Communication MacularEdemaAbsentNotCommunicated)
		{
			var i_ = this.Diabetic_Retinopathy_Encounter(context);
			bool? j_(Encounter EncounterDiabeticRetinopathy)
			{
				var n_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, EncounterDiabeticRetinopathy?.Period);
				var o_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.GetExtension(context, MacularEdemaAbsentNotCommunicated, "qicore-recorded");
				var p_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, (o_?.Value as Period));
				var q_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(n_, p_, null);

				return q_;
			};
			var k_ = context.Operators.WhereOrNull<Encounter>(i_, j_);
			Communication l_(Encounter EncounterDiabeticRetinopathy) => 
				MacularEdemaAbsentNotCommunicated;
			var m_ = context.Operators.SelectOrNull<Encounter, Communication>(k_, l_);

			return m_;
		};
		var f_ = context.Operators.SelectManyOrNull<Communication, Communication>(d_, e_);
		bool? g_(Communication MacularEdemaAbsentNotCommunicated)
		{
			var r_ = context.Operators.Convert<string>(MacularEdemaAbsentNotCommunicated?.StatusElement);
			var s_ = context.Operators.Equal(r_, "not-done");
			var t_ = this.GetModifierExtension(context, MacularEdemaAbsentNotCommunicated, "qicore-notDone");
			var u_ = FHIRHelpers_4_0_001.Instance.ToBoolean(context, (t_?.Value as FhirBoolean));
			var v_ = context.Operators.IsTrue(u_);
			var w_ = context.Operators.And(s_, v_);
			var x_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, MacularEdemaAbsentNotCommunicated?.StatusReason);
			var y_ = this.Medical_Reason(context);
			var z_ = context.Operators.ConceptInValueSet(x_, y_);
			var ab_ = this.Patient_Reason(context);
			var ac_ = context.Operators.ConceptInValueSet(x_, ab_);
			var ad_ = context.Operators.Or(z_, ac_);
			var ae_ = context.Operators.And(w_, ad_);

			return ae_;
		};
		var h_ = context.Operators.WhereOrNull<Communication>(f_, g_);

		return h_;
	}

    [CqlDeclaration("Medical or Patient Reason for Not Communicating Presence of Macular Edema")]
	public IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Presence_of_Macular_Edema(CqlContext context)
	{
		var a_ = this.Macular_Edema_Findings_Present(context);
		var b_ = typeof(Communication).GetProperty("ReasonCode");
		var c_ = context.Operators.RetrieveByValueSet<Communication>(a_, b_);
		IEnumerable<Communication> d_(Communication MacularEdemaPresentNotCommunicated)
		{
			var h_ = this.Diabetic_Retinopathy_Encounter(context);
			bool? i_(Encounter EncounterDiabeticRetinopathy)
			{
				var m_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, EncounterDiabeticRetinopathy?.Period);
				var n_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.GetExtension(context, MacularEdemaPresentNotCommunicated, "qicore-recorded");
				var o_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, (n_?.Value as Period));
				var p_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(m_, o_, null);

				return p_;
			};
			var j_ = context.Operators.WhereOrNull<Encounter>(h_, i_);
			Communication k_(Encounter EncounterDiabeticRetinopathy) => 
				MacularEdemaPresentNotCommunicated;
			var l_ = context.Operators.SelectOrNull<Encounter, Communication>(j_, k_);

			return l_;
		};
		var e_ = context.Operators.SelectManyOrNull<Communication, Communication>(c_, d_);
		bool? f_(Communication MacularEdemaPresentNotCommunicated)
		{
			var q_ = context.Operators.Convert<string>(MacularEdemaPresentNotCommunicated?.StatusElement);
			var r_ = context.Operators.Equal(q_, "not-done");
			var s_ = this.GetModifierExtension(context, MacularEdemaPresentNotCommunicated, "qicore-notDone");
			var t_ = FHIRHelpers_4_0_001.Instance.ToBoolean(context, (s_?.Value as FhirBoolean));
			var u_ = context.Operators.IsTrue(t_);
			var v_ = context.Operators.And(r_, u_);
			var w_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, MacularEdemaPresentNotCommunicated?.StatusReason);
			var x_ = this.Medical_Reason(context);
			var y_ = context.Operators.ConceptInValueSet(w_, x_);
			var aa_ = this.Patient_Reason(context);
			var ab_ = context.Operators.ConceptInValueSet(w_, aa_);
			var ac_ = context.Operators.Or(y_, ab_);
			var ad_ = context.Operators.And(v_, ac_);

			return ad_;
		};
		var g_ = context.Operators.WhereOrNull<Communication>(e_, f_);

		return g_;
	}

    [CqlDeclaration("Denominator Exceptions")]
	public bool? Denominator_Exceptions(CqlContext context)
	{
		var a_ = this.Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy(context);
		var b_ = context.Operators.ExistsInList<Communication>(a_);
		var c_ = this.Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema(context);
		var d_ = context.Operators.ExistsInList<Communication>(c_);
		var e_ = context.Operators.Or(b_, d_);
		var f_ = this.Medical_or_Patient_Reason_for_Not_Communicating_Presence_of_Macular_Edema(context);
		var g_ = context.Operators.ExistsInList<Communication>(f_);
		var h_ = context.Operators.Or(e_, g_);

		return h_;
	}

    [CqlDeclaration("Initial Population")]
	public bool? Initial_Population(CqlContext context)
	{
		var a_ = this.Patient(context);
		var b_ = context.Operators.ConvertStringToDateTime(a_?.BirthDateElement?.Value);
		var c_ = this.Measurement_Period(context);
		var d_ = context.Operators.Start(c_);
		var e_ = context.Operators.CalculateAgeAt(b_, d_, "year");
		var f_ = context.Operators.GreaterOrEqual(e_, (int?)18);
		var g_ = this.Diabetic_Retinopathy_Encounter(context);
		var h_ = context.Operators.ExistsInList<Encounter>(g_);
		var i_ = context.Operators.And(f_, h_);

		return i_;
	}

    [CqlDeclaration("Macular Exam Performed")]
	public IEnumerable<Observation> Macular_Exam_Performed(CqlContext context)
	{
		var a_ = this.Macular_Exam(context);
		var b_ = context.Operators.RetrieveByValueSet<Observation>(a_, null);
		IEnumerable<Observation> c_(Observation MacularExam)
		{
			var g_ = this.Diabetic_Retinopathy_Encounter(context);
			bool? h_(Encounter EncounterDiabeticRetinopathy)
			{
				var l_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, EncounterDiabeticRetinopathy?.Period);
				var m_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, MacularExam?.Effective);
				var n_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(l_, m_, null);

				return n_;
			};
			var i_ = context.Operators.WhereOrNull<Encounter>(g_, h_);
			Observation j_(Encounter EncounterDiabeticRetinopathy) => 
				MacularExam;
			var k_ = context.Operators.SelectOrNull<Encounter, Observation>(i_, j_);

			return k_;
		};
		var d_ = context.Operators.SelectManyOrNull<Observation, Observation>(b_, c_);
		bool? e_(Observation MacularExam)
		{
			var o_ = context.Operators.Convert<string>(MacularExam?.StatusElement);
			var p_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var q_ = context.Operators.InList<string>(o_, (p_ as IEnumerable<string>));
			var r_ = context.Operators.Not((bool?)(MacularExam?.Value is null));
			var s_ = context.Operators.And(q_, r_);

			return s_;
		};
		var f_ = context.Operators.WhereOrNull<Observation>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Denominator")]
	public bool? Denominator(CqlContext context)
	{
		var a_ = this.Initial_Population(context);
		var b_ = this.Macular_Exam_Performed(context);
		var c_ = context.Operators.ExistsInList<Observation>(b_);
		var d_ = context.Operators.And(a_, c_);

		return d_;
	}

    [CqlDeclaration("Level of Severity of Retinopathy Findings Communicated")]
	public IEnumerable<Communication> Level_of_Severity_of_Retinopathy_Findings_Communicated(CqlContext context)
	{
		var a_ = this.Level_of_Severity_of_Retinopathy_Findings(context);
		var b_ = typeof(Communication).GetProperty("ReasonCode");
		var c_ = context.Operators.RetrieveByValueSet<Communication>(a_, b_);
		IEnumerable<Communication> d_(Communication LevelOfSeverityCommunicated)
		{
			var h_ = this.Diabetic_Retinopathy_Encounter(context);
			bool? i_(Encounter EncounterDiabeticRetinopathy)
			{
				var m_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, LevelOfSeverityCommunicated?.SentElement);
				var n_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, EncounterDiabeticRetinopathy?.Period);
				var o_ = context.Operators.Start(n_);
				var p_ = context.Operators.After(m_, o_, null);

				return p_;
			};
			var j_ = context.Operators.WhereOrNull<Encounter>(h_, i_);
			Communication k_(Encounter EncounterDiabeticRetinopathy) => 
				LevelOfSeverityCommunicated;
			var l_ = context.Operators.SelectOrNull<Encounter, Communication>(j_, k_);

			return l_;
		};
		var e_ = context.Operators.SelectManyOrNull<Communication, Communication>(c_, d_);
		bool? f_(Communication LevelOfSeverityCommunicated)
		{
			var q_ = context.Operators.Convert<string>(LevelOfSeverityCommunicated?.StatusElement);
			var r_ = context.Operators.Equal(q_, "completed");

			return r_;
		};
		var g_ = context.Operators.WhereOrNull<Communication>(e_, f_);

		return g_;
	}

    [CqlDeclaration("Macular Edema Absence Communicated")]
	public IEnumerable<Communication> Macular_Edema_Absence_Communicated(CqlContext context)
	{
		var a_ = this.Macular_edema_absent__situation_(context);
		var b_ = context.Operators.ToList<CqlCode>(a_);
		var c_ = typeof(Communication).GetProperty("ReasonCode");
		var d_ = context.Operators.RetrieveByCodes<Communication>(b_, c_);
		IEnumerable<Communication> e_(Communication MacularEdemaAbsentCommunicated)
		{
			var i_ = this.Diabetic_Retinopathy_Encounter(context);
			bool? j_(Encounter EncounterDiabeticRetinopathy)
			{
				var n_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, MacularEdemaAbsentCommunicated?.SentElement);
				var o_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, EncounterDiabeticRetinopathy?.Period);
				var p_ = context.Operators.Start(o_);
				var q_ = context.Operators.After(n_, p_, null);

				return q_;
			};
			var k_ = context.Operators.WhereOrNull<Encounter>(i_, j_);
			Communication l_(Encounter EncounterDiabeticRetinopathy) => 
				MacularEdemaAbsentCommunicated;
			var m_ = context.Operators.SelectOrNull<Encounter, Communication>(k_, l_);

			return m_;
		};
		var f_ = context.Operators.SelectManyOrNull<Communication, Communication>(d_, e_);
		bool? g_(Communication MacularEdemaAbsentCommunicated)
		{
			var r_ = context.Operators.Convert<string>(MacularEdemaAbsentCommunicated?.StatusElement);
			var s_ = context.Operators.Equal(r_, "completed");

			return s_;
		};
		var h_ = context.Operators.WhereOrNull<Communication>(f_, g_);

		return h_;
	}

    [CqlDeclaration("Macular Edema Presence Communicated")]
	public IEnumerable<Communication> Macular_Edema_Presence_Communicated(CqlContext context)
	{
		var a_ = this.Macular_Edema_Findings_Present(context);
		var b_ = typeof(Communication).GetProperty("ReasonCode");
		var c_ = context.Operators.RetrieveByValueSet<Communication>(a_, b_);
		IEnumerable<Communication> d_(Communication MacularEdemaPresentCommunicated)
		{
			var h_ = this.Diabetic_Retinopathy_Encounter(context);
			bool? i_(Encounter EncounterDiabeticRetinopathy)
			{
				var m_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, MacularEdemaPresentCommunicated?.SentElement);
				var n_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, EncounterDiabeticRetinopathy?.Period);
				var o_ = context.Operators.Start(n_);
				var p_ = context.Operators.After(m_, o_, null);

				return p_;
			};
			var j_ = context.Operators.WhereOrNull<Encounter>(h_, i_);
			Communication k_(Encounter EncounterDiabeticRetinopathy) => 
				MacularEdemaPresentCommunicated;
			var l_ = context.Operators.SelectOrNull<Encounter, Communication>(j_, k_);

			return l_;
		};
		var e_ = context.Operators.SelectManyOrNull<Communication, Communication>(c_, d_);
		bool? f_(Communication MacularEdemaPresentCommunicated)
		{
			var q_ = context.Operators.Convert<string>(MacularEdemaPresentCommunicated?.StatusElement);
			var r_ = context.Operators.Equal(q_, "completed");

			return r_;
		};
		var g_ = context.Operators.WhereOrNull<Communication>(e_, f_);

		return g_;
	}

    [CqlDeclaration("Results of Dilated Macular or Fundus Exam Communicated")]
	public bool? Results_of_Dilated_Macular_or_Fundus_Exam_Communicated(CqlContext context)
	{
		var a_ = this.Level_of_Severity_of_Retinopathy_Findings_Communicated(context);
		var b_ = context.Operators.ExistsInList<Communication>(a_);
		var c_ = this.Macular_Edema_Absence_Communicated(context);
		var d_ = context.Operators.ExistsInList<Communication>(c_);
		var e_ = this.Macular_Edema_Presence_Communicated(context);
		var f_ = context.Operators.ExistsInList<Communication>(e_);
		var g_ = context.Operators.Or(d_, f_);
		var h_ = context.Operators.And(b_, g_);

		return h_;
	}

    [CqlDeclaration("Numerator")]
	public bool? Numerator(CqlContext context)
	{
		var a_ = this.Level_of_Severity_of_Retinopathy_Findings_Communicated(context);
		var b_ = context.Operators.ExistsInList<Communication>(a_);
		var c_ = this.Macular_Edema_Absence_Communicated(context);
		var d_ = context.Operators.ExistsInList<Communication>(c_);
		var e_ = this.Macular_Edema_Presence_Communicated(context);
		var f_ = context.Operators.ExistsInList<Communication>(e_);
		var g_ = context.Operators.Or(d_, f_);
		var h_ = context.Operators.And(b_, g_);

		return h_;
	}

}