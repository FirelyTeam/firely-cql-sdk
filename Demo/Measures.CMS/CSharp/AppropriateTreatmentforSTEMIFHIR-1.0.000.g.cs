using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using System.Reflection;
using Hl7.Cql.Operators;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.5.0")]
[CqlLibrary("AppropriateTreatmentforSTEMIFHIR", "1.0.000")]
public partial class AppropriateTreatmentforSTEMIFHIR_1_0_000 : ILibrary, ISingleton<AppropriateTreatmentforSTEMIFHIR_1_0_000>
{
    private AppropriateTreatmentforSTEMIFHIR_1_0_000() {}

    public static AppropriateTreatmentforSTEMIFHIR_1_0_000 Instance { get; } = new();

    #region Library Members
    public string Name => "AppropriateTreatmentforSTEMIFHIR";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [SupplementalDataElements_3_4_000.Instance, QICoreCommon_2_0_000.Instance, FHIRHelpers_4_3_000.Instance, CQMCommon_2_0_000.Instance];
    #endregion Library Members

    [CqlDeclaration("Active Bleeding Excluding Menses or Bleeding Diathesis")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4036")]
	public CqlValueSet Active_Bleeding_Excluding_Menses_or_Bleeding_Diathesis(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4036", default);


    [CqlDeclaration("Active Peptic Ulcer")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4031")]
	public CqlValueSet Active_Peptic_Ulcer(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4031", default);


    [CqlDeclaration("Adverse reaction to thrombolytics")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.6")]
	public CqlValueSet Adverse_reaction_to_thrombolytics(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.6", default);


    [CqlDeclaration("Allergy to thrombolytics")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.5")]
	public CqlValueSet Allergy_to_thrombolytics(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.5", default);


    [CqlDeclaration("Oral Anticoagulant Medications")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4045")]
	public CqlValueSet Oral_Anticoagulant_Medications(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4045", default);


    [CqlDeclaration("Aortic Dissection and Rupture")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4028")]
	public CqlValueSet Aortic_Dissection_and_Rupture(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4028", default);


    [CqlDeclaration("birth date")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.560.100.4")]
	public CqlValueSet birth_date(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.560.100.4", default);


    [CqlDeclaration("Cardiopulmonary Arrest")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4048")]
	public CqlValueSet Cardiopulmonary_Arrest(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4048", default);


    [CqlDeclaration("Cerebral Vascular Lesion")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4025")]
	public CqlValueSet Cerebral_Vascular_Lesion(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4025", default);


    [CqlDeclaration("Closed Head and Facial Trauma")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4026")]
	public CqlValueSet Closed_Head_and_Facial_Trauma(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4026", default);


    [CqlDeclaration("Dementia")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4043")]
	public CqlValueSet Dementia(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4043", default);


    [CqlDeclaration("Discharge To Acute Care Facility")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87")]
	public CqlValueSet Discharge_To_Acute_Care_Facility(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87", default);


    [CqlDeclaration("ED")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1085")]
	public CqlValueSet ED(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1085", default);


    [CqlDeclaration("Emergency Department Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292")]
	public CqlValueSet Emergency_Department_Visit(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", default);


    [CqlDeclaration("Endotracheal Intubation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.69")]
	public CqlValueSet Endotracheal_Intubation(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.69", default);


    [CqlDeclaration("Fibrinolytic Therapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4020")]
	public CqlValueSet Fibrinolytic_Therapy(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4020", default);


    [CqlDeclaration("Intracranial or Intraspinal surgery")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.2")]
	public CqlValueSet Intracranial_or_Intraspinal_surgery(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.2", default);


    [CqlDeclaration("Ischemic Stroke")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.104.12.1024")]
	public CqlValueSet Ischemic_Stroke(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.104.12.1024", default);


    [CqlDeclaration("Major Surgical Procedure")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4056")]
	public CqlValueSet Major_Surgical_Procedure(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4056", default);


    [CqlDeclaration("Malignant Intracranial Neoplasm Group")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.3")]
	public CqlValueSet Malignant_Intracranial_Neoplasm_Group(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.3", default);


    [CqlDeclaration("Insertion or Replacement of Mechanical Circulatory Assist Device")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4052")]
	public CqlValueSet Insertion_or_Replacement_of_Mechanical_Circulatory_Assist_Device(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4052", default);


    [CqlDeclaration("Neurologic impairment")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.114.12.1012")]
	public CqlValueSet Neurologic_impairment(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.114.12.1012", default);


    [CqlDeclaration("Patient Expired")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309")]
	public CqlValueSet Patient_Expired(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309", default);


    [CqlDeclaration("Percutaneous Coronary Intervention")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.2000.5")]
	public CqlValueSet Percutaneous_Coronary_Intervention(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.2000.5", default);


    [CqlDeclaration("Pregnancy ICD10 SNOMEDCT")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4055")]
	public CqlValueSet Pregnancy_ICD10_SNOMEDCT(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4055", default);


    [CqlDeclaration("STEMI")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4017")]
	public CqlValueSet STEMI(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4017", default);


    [CqlDeclaration("Thrombolytic medications")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.4")]
	public CqlValueSet Thrombolytic_medications(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.4", default);


    [CqlDeclaration("Birthdate")]
	public CqlCode Birthdate(CqlContext context) => 
		new CqlCode("21112-8", "http://loinc.org", default, default);


    [CqlDeclaration("Emergency Department")]
	public CqlCode Emergency_Department(CqlContext context) => 
		new CqlCode("1108-0", "https://www.cdc.gov/nhsn/cdaportal/terminology/codesystem/hsloc.html", default, default);


    [CqlDeclaration("Patient transfer (procedure)")]
	public CqlCode Patient_transfer__procedure_(CqlContext context) => 
		new CqlCode("107724000", "http://snomed.info/sct", default, default);


    [CqlDeclaration("Streptokinase adverse reaction (disorder)")]
	public CqlCode Streptokinase_adverse_reaction__disorder_(CqlContext context) => 
		new CqlCode("293571007", "http://snomed.info/sct", default, default);


    [CqlDeclaration("EMER")]
	public CqlCode EMER(CqlContext context) => 
		new CqlCode("EMER", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);


    [CqlDeclaration("LOINC")]
	public CqlCode[] LOINC(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("21112-8", "http://loinc.org", default, default),
		];

		return a_;
	}


    [CqlDeclaration("HSLOC")]
	public CqlCode[] HSLOC(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("1108-0", "https://www.cdc.gov/nhsn/cdaportal/terminology/codesystem/hsloc.html", default, default),
		];

		return a_;
	}


    [CqlDeclaration("SNOMEDCT")]
	public CqlCode[] SNOMEDCT(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("107724000", "http://snomed.info/sct", default, default),
			new CqlCode("293571007", "http://snomed.info/sct", default, default),
		];

		return a_;
	}


    [CqlDeclaration("ActCode")]
	public CqlCode[] ActCode(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("EMER", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default),
		];

		return a_;
	}


    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
	{
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("AppropriateTreatmentforSTEMIFHIR-1.0.000", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
	}


    [CqlDeclaration("Patient")]
	public Patient Patient(CqlContext context)
	{
		IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}


    [CqlDeclaration("ED Encounter with Encounter Diagnosis of STEMI")]
	public IEnumerable<Encounter> ED_Encounter_with_Encounter_Diagnosis_of_STEMI(CqlContext context)
	{
		CqlValueSet a_ = this.ED(context);
		IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		bool? c_(Encounter EDEncounter)
		{
			Code<Encounter.EncounterStatus> e_ = EDEncounter?.StatusElement;
			Encounter.EncounterStatus? f_ = e_?.Value;
			Code<Encounter.EncounterStatus> g_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(f_);
			bool? h_ = context.Operators.Equal(g_, "finished");
			Coding i_ = EDEncounter?.Class;
			CqlCode j_ = FHIRHelpers_4_3_000.Instance.ToCode(context, i_);
			CqlCode k_ = this.EMER(context);
			bool? l_ = context.Operators.Equivalent(j_, k_);
			bool? m_ = context.Operators.And(h_, l_);
			List<CodeableConcept> n_ = EDEncounter?.ReasonCode;
			CqlConcept o_(CodeableConcept @this)
			{
				CqlConcept ad_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

				return ad_;
			};
			IEnumerable<CqlConcept> p_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)n_, o_);
			CqlValueSet q_ = this.STEMI(context);
			bool? r_ = context.Operators.ConceptsInValueSet(p_, q_);
			IEnumerable<Condition> s_ = CQMCommon_2_0_000.Instance.encounterDiagnosis(context, EDEncounter);
			bool? t_(Condition EncDiagnosis)
			{
				CodeableConcept ae_ = EncDiagnosis?.Code;
				CqlConcept af_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, ae_);
				CqlValueSet ag_ = this.STEMI(context);
				bool? ah_ = context.Operators.ConceptInValueSet(af_, ag_);

				return ah_;
			};
			IEnumerable<Condition> u_ = context.Operators.Where<Condition>(s_, t_);
			bool? v_ = context.Operators.Exists<Condition>(u_);
			bool? w_ = context.Operators.Or(r_, v_);
			bool? x_ = context.Operators.And(m_, w_);
			CqlInterval<CqlDateTime> y_ = this.Measurement_Period(context);
			Period z_ = EDEncounter?.Period;
			CqlInterval<CqlDateTime> aa_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, z_);
			bool? ab_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(y_, aa_, default);
			bool? ac_ = context.Operators.And(x_, ab_);

			return ac_;
		};
		IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);

		return d_;
	}


    [CqlDeclaration("ED Encounter with Diagnosis of STEMI")]
	public IEnumerable<Encounter> ED_Encounter_with_Diagnosis_of_STEMI(CqlContext context)
	{
		CqlValueSet a_ = this.ED(context);
		IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> c_(Encounter EDEncounter)
		{
			CqlValueSet e_ = this.STEMI(context);
			IEnumerable<Condition> f_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
			bool? g_(Condition DxSTEMI)
			{
				CodeableConcept k_ = DxSTEMI?.ClinicalStatus;
				CqlConcept l_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, k_);
				CqlCode m_ = QICoreCommon_2_0_000.Instance.active(context);
				CqlConcept n_ = context.Operators.ConvertCodeToConcept(m_);
				bool? o_ = context.Operators.Equivalent(l_, n_);
				Code<Encounter.EncounterStatus> p_ = EDEncounter?.StatusElement;
				Encounter.EncounterStatus? q_ = p_?.Value;
				Code<Encounter.EncounterStatus> r_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(q_);
				bool? s_ = context.Operators.Equal(r_, "finished");
				bool? t_ = context.Operators.And(o_, s_);
				Coding u_ = EDEncounter?.Class;
				CqlCode v_ = FHIRHelpers_4_3_000.Instance.ToCode(context, u_);
				CqlCode w_ = this.EMER(context);
				bool? x_ = context.Operators.Equivalent(v_, w_);
				bool? y_ = context.Operators.And(t_, x_);
				CqlInterval<CqlDateTime> z_ = QICoreCommon_2_0_000.Instance.prevalenceInterval(context, DxSTEMI);
				CqlDateTime aa_ = context.Operators.Start(z_);
				Period ab_ = EDEncounter?.Period;
				CqlInterval<CqlDateTime> ac_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, ab_);
				bool? ad_ = context.Operators.In<CqlDateTime>(aa_, ac_, default);
				bool? ae_ = context.Operators.And(y_, ad_);
				CqlInterval<CqlDateTime> af_ = this.Measurement_Period(context);
				CqlInterval<CqlDateTime> ah_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, ab_);
				bool? ai_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(af_, ah_, "day");
				bool? aj_ = context.Operators.And(ae_, ai_);

				return aj_;
			};
			IEnumerable<Condition> h_ = context.Operators.Where<Condition>(f_, g_);
			Encounter i_(Condition DxSTEMI) => 
				EDEncounter;
			IEnumerable<Encounter> j_ = context.Operators.Select<Condition, Encounter>(h_, i_);

			return j_;
		};
		IEnumerable<Encounter> d_ = context.Operators.SelectMany<Encounter, Encounter>(b_, c_);

		return d_;
	}


    [CqlDeclaration("ED Encounter with STEMI Diagnosis")]
	public IEnumerable<Encounter> ED_Encounter_with_STEMI_Diagnosis(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.ED_Encounter_with_Encounter_Diagnosis_of_STEMI(context);
		IEnumerable<Encounter> b_ = this.ED_Encounter_with_Diagnosis_of_STEMI(context);
		IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);

		return c_;
	}


    [CqlDeclaration("Initial Population")]
	public IEnumerable<Encounter> Initial_Population(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
		bool? b_(Encounter EDwithSTEMI)
		{
			Patient d_ = this.Patient(context);
			Date e_ = d_?.BirthDateElement;
			string f_ = e_?.Value;
			CqlDate g_ = context.Operators.ConvertStringToDate(f_);
			Period h_ = EDwithSTEMI?.Period;
			CqlInterval<CqlDateTime> i_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, h_);
			CqlDateTime j_ = context.Operators.Start(i_);
			CqlDate k_ = context.Operators.DateFrom(j_);
			int? l_ = context.Operators.CalculateAgeAt(g_, k_, "year");
			bool? m_ = context.Operators.GreaterOrEqual(l_, 18);

			return m_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}


    [CqlDeclaration("Denominator")]
	public IEnumerable<Encounter> Denominator(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Initial_Population(context);

		return a_;
	}


    [CqlDeclaration("Allergy or Intolerance to Thrombolytic Medications Overlaps ED Encounter")]
	public IEnumerable<Encounter> Allergy_or_Intolerance_to_Thrombolytic_Medications_Overlaps_ED_Encounter(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
		IEnumerable<Encounter> b_(Encounter EDwSTEMI)
		{
			CqlValueSet d_ = this.Thrombolytic_medications(context);
			IEnumerable<AllergyIntolerance> e_ = context.Operators.Retrieve<AllergyIntolerance>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-allergyintolerance"));
			bool? f_(AllergyIntolerance ThrombolyticAllergy)
			{
				CodeableConcept j_ = ThrombolyticAllergy?.ClinicalStatus;
				CqlConcept k_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, j_);
				CqlCode l_ = QICoreCommon_2_0_000.Instance.allergy_active(context);
				CqlConcept m_ = context.Operators.ConvertCodeToConcept(l_);
				bool? n_ = context.Operators.Equivalent(k_, m_);
				DataType o_ = ThrombolyticAllergy?.Onset;
				object p_ = FHIRHelpers_4_3_000.Instance.ToValue(context, o_);
				CqlInterval<CqlDateTime> q_ = QICoreCommon_2_0_000.Instance.toInterval(context, p_);
				Period r_ = EDwSTEMI?.Period;
				CqlInterval<CqlDateTime> s_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, r_);
				bool? t_ = context.Operators.Overlaps(q_, s_, default);
				bool? u_ = context.Operators.And(n_, t_);

				return u_;
			};
			IEnumerable<AllergyIntolerance> g_ = context.Operators.Where<AllergyIntolerance>(e_, f_);
			Encounter h_(AllergyIntolerance ThrombolyticAllergy) => 
				EDwSTEMI;
			IEnumerable<Encounter> i_ = context.Operators.Select<AllergyIntolerance, Encounter>(g_, h_);

			return i_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}


    [CqlDeclaration("Adverse Effect to Thrombolytic Medications Before End of ED Encounter")]
	public IEnumerable<Encounter> Adverse_Effect_to_Thrombolytic_Medications_Before_End_of_ED_Encounter(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
		IEnumerable<Encounter> b_(Encounter EDwSTEMI)
		{
			CqlValueSet d_ = this.Adverse_reaction_to_thrombolytics(context);
			IEnumerable<AdverseEvent> e_ = context.Operators.Retrieve<AdverseEvent>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-adverseevent"));
			bool? f_(AdverseEvent ThrombolyticAdverseEvent)
			{
				FhirDateTime j_ = ThrombolyticAdverseEvent?.RecordedDateElement;
				CqlDateTime k_ = context.Operators.Convert<CqlDateTime>(j_);
				Period l_ = EDwSTEMI?.Period;
				CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, l_);
				CqlDateTime n_ = context.Operators.End(m_);
				bool? o_ = context.Operators.Before(k_, n_, default);
				Code<AdverseEvent.AdverseEventActuality> p_ = ThrombolyticAdverseEvent?.ActualityElement;
				AdverseEvent.AdverseEventActuality? q_ = p_?.Value;
				Code<AdverseEvent.AdverseEventActuality> r_ = context.Operators.Convert<Code<AdverseEvent.AdverseEventActuality>>(q_);
				bool? s_ = context.Operators.Equal(r_, "actual");
				bool? t_ = context.Operators.And(o_, s_);

				return t_;
			};
			IEnumerable<AdverseEvent> g_ = context.Operators.Where<AdverseEvent>(e_, f_);
			Encounter h_(AdverseEvent ThrombolyticAdverseEvent) => 
				EDwSTEMI;
			IEnumerable<Encounter> i_ = context.Operators.Select<AdverseEvent, Encounter>(g_, h_);

			return i_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}


    [CqlDeclaration("Active Exclusion Diagnosis at Start of ED Encounter")]
	public IEnumerable<Encounter> Active_Exclusion_Diagnosis_at_Start_of_ED_Encounter(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
		IEnumerable<Encounter> b_(Encounter EDwithSTEMI)
		{
			CqlValueSet d_ = this.Active_Bleeding_Excluding_Menses_or_Bleeding_Diathesis(context);
			IEnumerable<Condition> e_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
			CqlValueSet f_ = this.Malignant_Intracranial_Neoplasm_Group(context);
			IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
			IEnumerable<Condition> h_ = context.Operators.Union<Condition>(e_, g_);
			CqlValueSet i_ = this.Cerebral_Vascular_Lesion(context);
			IEnumerable<Condition> j_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
			CqlValueSet k_ = this.Dementia(context);
			IEnumerable<Condition> l_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, k_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
			IEnumerable<Condition> m_ = context.Operators.Union<Condition>(j_, l_);
			IEnumerable<Condition> n_ = context.Operators.Union<Condition>(h_, m_);
			CqlValueSet o_ = this.Pregnancy_ICD10_SNOMEDCT(context);
			IEnumerable<Condition> p_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
			CqlValueSet q_ = this.Allergy_to_thrombolytics(context);
			IEnumerable<Condition> r_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, q_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
			IEnumerable<Condition> s_ = context.Operators.Union<Condition>(p_, r_);
			IEnumerable<Condition> t_ = context.Operators.Union<Condition>(n_, s_);
			bool? u_(Condition ActiveExclusionDx)
			{
				CqlInterval<CqlDateTime> y_ = QICoreCommon_2_0_000.Instance.prevalenceInterval(context, ActiveExclusionDx);
				Period z_ = EDwithSTEMI?.Period;
				CqlInterval<CqlDateTime> aa_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, z_);
				bool? ab_ = context.Operators.OverlapsBefore(y_, aa_, default);

				return ab_;
			};
			IEnumerable<Condition> v_ = context.Operators.Where<Condition>(t_, u_);
			Encounter w_(Condition ActiveExclusionDx) => 
				EDwithSTEMI;
			IEnumerable<Encounter> x_ = context.Operators.Select<Condition, Encounter>(v_, w_);

			return x_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}


    [CqlDeclaration("Active Oral Anticoagulant Medication at the Start of ED Encounter")]
	public IEnumerable<Encounter> Active_Oral_Anticoagulant_Medication_at_the_Start_of_ED_Encounter(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
		IEnumerable<Encounter> b_(Encounter EDwithSTEMI)
		{
			CqlValueSet d_ = this.Oral_Anticoagulant_Medications(context);
			IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
			IEnumerable<MedicationRequest> g_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
			IEnumerable<MedicationRequest> h_ = context.Operators.Union<MedicationRequest>(e_, g_);
			bool? i_(MedicationRequest OralAnticoagulant)
			{
				Code<MedicationRequest.MedicationrequestStatus> m_ = OralAnticoagulant?.StatusElement;
				MedicationRequest.MedicationrequestStatus? n_ = m_?.Value;
				string o_ = context.Operators.Convert<string>(n_);
				bool? p_ = context.Operators.Equal(o_, "active");
				Code<MedicationRequest.MedicationRequestIntent> q_ = OralAnticoagulant?.IntentElement;
				MedicationRequest.MedicationRequestIntent? r_ = q_?.Value;
				string s_ = context.Operators.Convert<string>(r_);
				bool? t_ = context.Operators.Equal(s_, "order");
				bool? u_ = context.Operators.And(p_, t_);
				FhirDateTime v_ = OralAnticoagulant?.AuthoredOnElement;
				CqlDateTime w_ = context.Operators.Convert<CqlDateTime>(v_);
				Period x_ = EDwithSTEMI?.Period;
				CqlInterval<CqlDateTime> y_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, x_);
				CqlDateTime z_ = context.Operators.Start(y_);
				bool? aa_ = context.Operators.SameOrBefore(w_, z_, default);
				bool? ab_ = context.Operators.And(u_, aa_);

				return ab_;
			};
			IEnumerable<MedicationRequest> j_ = context.Operators.Where<MedicationRequest>(h_, i_);
			Encounter k_(MedicationRequest OralAnticoagulant) => 
				EDwithSTEMI;
			IEnumerable<Encounter> l_ = context.Operators.Select<MedicationRequest, Encounter>(j_, k_);

			return l_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}


    [CqlDeclaration("Exclusion Diagnosis During ED Encounter or Within 24 Hours of ED Encounter Start")]
	public IEnumerable<Encounter> Exclusion_Diagnosis_During_ED_Encounter_or_Within_24_Hours_of_ED_Encounter_Start(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
		IEnumerable<Encounter> b_(Encounter EDwithSTEMI)
		{
			CqlValueSet d_ = this.Aortic_Dissection_and_Rupture(context);
			IEnumerable<Condition> e_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
			CqlValueSet f_ = this.Neurologic_impairment(context);
			IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
			IEnumerable<Condition> h_ = context.Operators.Union<Condition>(e_, g_);
			CqlValueSet i_ = this.Cardiopulmonary_Arrest(context);
			IEnumerable<Condition> j_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
			IEnumerable<Condition> k_ = context.Operators.Union<Condition>(h_, j_);
			bool? l_(Condition ExclusionDiagnosis)
			{
				CqlInterval<CqlDateTime> p_ = QICoreCommon_2_0_000.Instance.prevalenceInterval(context, ExclusionDiagnosis);
				CqlDateTime q_ = context.Operators.Start(p_);
				Period r_ = EDwithSTEMI?.Period;
				CqlInterval<CqlDateTime> s_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, r_);
				bool? t_ = context.Operators.In<CqlDateTime>(q_, s_, default);
				CqlDateTime v_ = context.Operators.Start(p_);
				CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, r_);
				CqlDateTime y_ = context.Operators.Start(x_);
				CqlQuantity z_ = context.Operators.Quantity(24m, "hours");
				CqlDateTime aa_ = context.Operators.Subtract(y_, z_);
				CqlInterval<CqlDateTime> ac_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, r_);
				CqlDateTime ad_ = context.Operators.Start(ac_);
				CqlInterval<CqlDateTime> ae_ = context.Operators.Interval(aa_, ad_, true, false);
				bool? af_ = context.Operators.In<CqlDateTime>(v_, ae_, default);
				CqlInterval<CqlDateTime> ah_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, r_);
				CqlDateTime ai_ = context.Operators.Start(ah_);
				bool? aj_ = context.Operators.Not((bool?)(ai_ is null));
				bool? ak_ = context.Operators.And(af_, aj_);
				bool? al_ = context.Operators.Or(t_, ak_);

				return al_;
			};
			IEnumerable<Condition> m_ = context.Operators.Where<Condition>(k_, l_);
			Encounter n_(Condition ExclusionDiagnosis) => 
				EDwithSTEMI;
			IEnumerable<Encounter> o_ = context.Operators.Select<Condition, Encounter>(m_, n_);

			return o_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}


    [CqlDeclaration("Major Surgical Procedure 21 Days or Less Before Start of or Starts During ED Encounter")]
	public IEnumerable<Encounter> Major_Surgical_Procedure_21_Days_or_Less_Before_Start_of_or_Starts_During_ED_Encounter(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
		IEnumerable<Encounter> b_(Encounter EDwithSTEMI)
		{
			CqlValueSet d_ = this.Major_Surgical_Procedure(context);
			IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
			bool? f_(Procedure MajorSurgery)
			{
				DataType j_ = MajorSurgery?.Performed;
				object k_ = FHIRHelpers_4_3_000.Instance.ToValue(context, j_);
				CqlInterval<CqlDateTime> l_ = QICoreCommon_2_0_000.Instance.toInterval(context, k_);
				CqlDateTime m_ = context.Operators.Start(l_);
				Period n_ = EDwithSTEMI?.Period;
				CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, n_);
				CqlDateTime p_ = context.Operators.Start(o_);
				CqlQuantity q_ = context.Operators.Quantity(21m, "days");
				CqlDateTime r_ = context.Operators.Subtract(p_, q_);
				CqlInterval<CqlDateTime> t_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, n_);
				CqlDateTime u_ = context.Operators.Start(t_);
				CqlInterval<CqlDateTime> v_ = context.Operators.Interval(r_, u_, true, false);
				bool? w_ = context.Operators.In<CqlDateTime>(m_, v_, default);
				CqlInterval<CqlDateTime> y_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, n_);
				CqlDateTime z_ = context.Operators.Start(y_);
				bool? aa_ = context.Operators.Not((bool?)(z_ is null));
				bool? ab_ = context.Operators.And(w_, aa_);
				Code<EventStatus> ac_ = MajorSurgery?.StatusElement;
				EventStatus? ad_ = ac_?.Value;
				string ae_ = context.Operators.Convert<string>(ad_);
				bool? af_ = context.Operators.Equal(ae_, "completed");
				bool? ag_ = context.Operators.And(ab_, af_);

				return ag_;
			};
			IEnumerable<Procedure> g_ = context.Operators.Where<Procedure>(e_, f_);
			Encounter h_(Procedure MajorSurgery) => 
				EDwithSTEMI;
			IEnumerable<Encounter> i_ = context.Operators.Select<Procedure, Encounter>(g_, h_);

			return i_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}


    [CqlDeclaration("Intubation or Mechanical Circulatory Assist Procedure During ED Encounter or Within 24 Hours of ED Encounter Start")]
	public IEnumerable<Encounter> Intubation_or_Mechanical_Circulatory_Assist_Procedure_During_ED_Encounter_or_Within_24_Hours_of_ED_Encounter_Start(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
		IEnumerable<Encounter> b_(Encounter EDwithSTEMI)
		{
			CqlValueSet d_ = this.Endotracheal_Intubation(context);
			IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
			CqlValueSet f_ = this.Insertion_or_Replacement_of_Mechanical_Circulatory_Assist_Device(context);
			IEnumerable<Procedure> g_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
			IEnumerable<Procedure> h_ = context.Operators.Union<Procedure>(e_, g_);
			bool? i_(Procedure AirwayProcedure)
			{
				DataType m_ = AirwayProcedure?.Performed;
				object n_ = FHIRHelpers_4_3_000.Instance.ToValue(context, m_);
				CqlInterval<CqlDateTime> o_ = QICoreCommon_2_0_000.Instance.toInterval(context, n_);
				CqlDateTime p_ = context.Operators.Start(o_);
				Period q_ = EDwithSTEMI?.Period;
				CqlInterval<CqlDateTime> r_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, q_);
				bool? s_ = context.Operators.In<CqlDateTime>(p_, r_, default);
				object u_ = FHIRHelpers_4_3_000.Instance.ToValue(context, m_);
				CqlInterval<CqlDateTime> v_ = QICoreCommon_2_0_000.Instance.toInterval(context, u_);
				CqlDateTime w_ = context.Operators.Start(v_);
				CqlInterval<CqlDateTime> y_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, q_);
				CqlDateTime z_ = context.Operators.Start(y_);
				CqlQuantity aa_ = context.Operators.Quantity(24m, "hours");
				CqlDateTime ab_ = context.Operators.Subtract(z_, aa_);
				CqlInterval<CqlDateTime> ad_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, q_);
				CqlDateTime ae_ = context.Operators.Start(ad_);
				CqlInterval<CqlDateTime> af_ = context.Operators.Interval(ab_, ae_, true, false);
				bool? ag_ = context.Operators.In<CqlDateTime>(w_, af_, default);
				CqlInterval<CqlDateTime> ai_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, q_);
				CqlDateTime aj_ = context.Operators.Start(ai_);
				bool? ak_ = context.Operators.Not((bool?)(aj_ is null));
				bool? al_ = context.Operators.And(ag_, ak_);
				bool? am_ = context.Operators.Or(s_, al_);
				Code<EventStatus> an_ = AirwayProcedure?.StatusElement;
				EventStatus? ao_ = an_?.Value;
				string ap_ = context.Operators.Convert<string>(ao_);
				bool? aq_ = context.Operators.Equal(ap_, "completed");
				bool? ar_ = context.Operators.And(am_, aq_);

				return ar_;
			};
			IEnumerable<Procedure> j_ = context.Operators.Where<Procedure>(h_, i_);
			Encounter k_(Procedure AirwayProcedure) => 
				EDwithSTEMI;
			IEnumerable<Encounter> l_ = context.Operators.Select<Procedure, Encounter>(j_, k_);

			return l_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}


    [CqlDeclaration("Active Exclusion Diagnosis Within 90 Days Before or At the Start of ED Encounter")]
	public IEnumerable<Encounter> Active_Exclusion_Diagnosis_Within_90_Days_Before_or_At_the_Start_of_ED_Encounter(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
		IEnumerable<Encounter> b_(Encounter EDwSTEMI)
		{
			CqlValueSet d_ = this.Ischemic_Stroke(context);
			IEnumerable<Condition> e_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
			CqlValueSet f_ = this.Closed_Head_and_Facial_Trauma(context);
			IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
			IEnumerable<Condition> h_ = context.Operators.Union<Condition>(e_, g_);
			CqlValueSet i_ = this.Active_Peptic_Ulcer(context);
			IEnumerable<Condition> j_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
			CqlValueSet k_ = this.Cardiopulmonary_Arrest(context);
			IEnumerable<Condition> l_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, k_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
			IEnumerable<Condition> m_ = context.Operators.Union<Condition>(j_, l_);
			IEnumerable<Condition> n_ = context.Operators.Union<Condition>(h_, m_);
			bool? o_(Condition ExclusionCondition)
			{
				CqlInterval<CqlDateTime> s_ = QICoreCommon_2_0_000.Instance.prevalenceInterval(context, ExclusionCondition);
				CqlDateTime t_ = context.Operators.Start(s_);
				Period u_ = EDwSTEMI?.Period;
				CqlInterval<CqlDateTime> v_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, u_);
				CqlDateTime w_ = context.Operators.Start(v_);
				CqlQuantity x_ = context.Operators.Quantity(90m, "days");
				CqlDateTime y_ = context.Operators.Subtract(w_, x_);
				CqlInterval<CqlDateTime> aa_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, u_);
				CqlDateTime ab_ = context.Operators.Start(aa_);
				CqlInterval<CqlDateTime> ac_ = context.Operators.Interval(y_, ab_, true, true);
				bool? ad_ = context.Operators.In<CqlDateTime>(t_, ac_, default);

				return ad_;
			};
			IEnumerable<Condition> p_ = context.Operators.Where<Condition>(n_, o_);
			Encounter q_(Condition ExclusionCondition) => 
				EDwSTEMI;
			IEnumerable<Encounter> r_ = context.Operators.Select<Condition, Encounter>(p_, q_);

			return r_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}


    [CqlDeclaration("Intracranial or Intraspinal Procedure 90 Days or Less Before Start of ED Encounter")]
	public IEnumerable<Encounter> Intracranial_or_Intraspinal_Procedure_90_Days_or_Less_Before_Start_of_ED_Encounter(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
		IEnumerable<Encounter> b_(Encounter EDwithSTEMI)
		{
			CqlValueSet d_ = this.Intracranial_or_Intraspinal_surgery(context);
			IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
			bool? f_(Procedure CranialorSpinalSurgery)
			{
				DataType j_ = CranialorSpinalSurgery?.Performed;
				object k_ = FHIRHelpers_4_3_000.Instance.ToValue(context, j_);
				CqlInterval<CqlDateTime> l_ = QICoreCommon_2_0_000.Instance.toInterval(context, k_);
				CqlDateTime m_ = context.Operators.Start(l_);
				Period n_ = EDwithSTEMI?.Period;
				CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, n_);
				CqlDateTime p_ = context.Operators.Start(o_);
				CqlQuantity q_ = context.Operators.Quantity(90m, "days");
				CqlDateTime r_ = context.Operators.Subtract(p_, q_);
				CqlInterval<CqlDateTime> t_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, n_);
				CqlDateTime u_ = context.Operators.Start(t_);
				CqlInterval<CqlDateTime> v_ = context.Operators.Interval(r_, u_, true, false);
				bool? w_ = context.Operators.In<CqlDateTime>(m_, v_, default);
				CqlInterval<CqlDateTime> y_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, n_);
				CqlDateTime z_ = context.Operators.Start(y_);
				bool? aa_ = context.Operators.Not((bool?)(z_ is null));
				bool? ab_ = context.Operators.And(w_, aa_);
				Code<EventStatus> ac_ = CranialorSpinalSurgery?.StatusElement;
				EventStatus? ad_ = ac_?.Value;
				string ae_ = context.Operators.Convert<string>(ad_);
				bool? af_ = context.Operators.Equal(ae_, "completed");
				bool? ag_ = context.Operators.And(ab_, af_);

				return ag_;
			};
			IEnumerable<Procedure> g_ = context.Operators.Where<Procedure>(e_, f_);
			Encounter h_(Procedure CranialorSpinalSurgery) => 
				EDwithSTEMI;
			IEnumerable<Encounter> i_ = context.Operators.Select<Procedure, Encounter>(g_, h_);

			return i_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}


    [CqlDeclaration("ED Encounter with Discharge Disposition as Patient Expired")]
	public IEnumerable<Encounter> ED_Encounter_with_Discharge_Disposition_as_Patient_Expired(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
		bool? b_(Encounter EDwithSTEMI)
		{
			Encounter.HospitalizationComponent d_ = EDwithSTEMI?.Hospitalization;
			CodeableConcept e_ = d_?.DischargeDisposition;
			CqlConcept f_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, e_);
			CqlValueSet g_ = this.Patient_Expired(context);
			bool? h_ = context.Operators.ConceptInValueSet(f_, g_);

			return h_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}


    [CqlDeclaration("Denominator Exclusions")]
	public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Allergy_or_Intolerance_to_Thrombolytic_Medications_Overlaps_ED_Encounter(context);
		IEnumerable<Encounter> b_ = this.Adverse_Effect_to_Thrombolytic_Medications_Before_End_of_ED_Encounter(context);
		IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
		IEnumerable<Encounter> d_ = this.Active_Exclusion_Diagnosis_at_Start_of_ED_Encounter(context);
		IEnumerable<Encounter> e_ = this.Active_Oral_Anticoagulant_Medication_at_the_Start_of_ED_Encounter(context);
		IEnumerable<Encounter> f_ = context.Operators.Union<Encounter>(d_, e_);
		IEnumerable<Encounter> g_ = context.Operators.Union<Encounter>(c_, f_);
		IEnumerable<Encounter> h_ = this.Exclusion_Diagnosis_During_ED_Encounter_or_Within_24_Hours_of_ED_Encounter_Start(context);
		IEnumerable<Encounter> i_ = this.Major_Surgical_Procedure_21_Days_or_Less_Before_Start_of_or_Starts_During_ED_Encounter(context);
		IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(h_, i_);
		IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(g_, j_);
		IEnumerable<Encounter> l_ = this.Intubation_or_Mechanical_Circulatory_Assist_Procedure_During_ED_Encounter_or_Within_24_Hours_of_ED_Encounter_Start(context);
		IEnumerable<Encounter> m_ = this.Active_Exclusion_Diagnosis_Within_90_Days_Before_or_At_the_Start_of_ED_Encounter(context);
		IEnumerable<Encounter> n_ = context.Operators.Union<Encounter>(l_, m_);
		IEnumerable<Encounter> o_ = context.Operators.Union<Encounter>(k_, n_);
		IEnumerable<Encounter> p_ = this.Intracranial_or_Intraspinal_Procedure_90_Days_or_Less_Before_Start_of_ED_Encounter(context);
		IEnumerable<Encounter> q_ = this.ED_Encounter_with_Discharge_Disposition_as_Patient_Expired(context);
		IEnumerable<Encounter> r_ = context.Operators.Union<Encounter>(p_, q_);
		IEnumerable<Encounter> s_ = context.Operators.Union<Encounter>(o_, r_);

		return s_;
	}

	public CqlDateTime currentemergencyDepartmentArrivalTime(CqlContext context, Encounter EDEncounter)
	{
		List<Encounter.LocationComponent> a_ = EDEncounter?.Location;
		bool? b_(Encounter.LocationComponent EDLocation)
		{
			ResourceReference h_ = EDLocation?.Location;
			Location i_ = CQMCommon_2_0_000.Instance.GetLocation(context, h_);
			List<CodeableConcept> j_ = i_?.Type;
			CqlConcept k_(CodeableConcept @this)
			{
				CqlConcept o_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, @this);

				return o_;
			};
			IEnumerable<CqlConcept> l_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)j_, k_);
			CqlValueSet m_ = this.Emergency_Department_Visit(context);
			bool? n_ = context.Operators.ConceptsInValueSet(l_, m_);

			return n_;
		};
		IEnumerable<Encounter.LocationComponent> c_ = context.Operators.Where<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)a_, b_);
		Encounter.LocationComponent d_ = context.Operators.SingletonFrom<Encounter.LocationComponent>(c_);
		Period e_ = d_?.Period;
		CqlInterval<CqlDateTime> f_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, e_);
		CqlDateTime g_ = context.Operators.Start(f_);

		return g_;
	}


    [CqlDeclaration("Fibrinolytic Therapy within 30 Minutes of Arrival")]
	public IEnumerable<Encounter> Fibrinolytic_Therapy_within_30_Minutes_of_Arrival(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
		IEnumerable<Encounter> b_(Encounter EDwithSTEMI)
		{
			CqlValueSet d_ = this.Fibrinolytic_Therapy(context);
			IEnumerable<MedicationAdministration> e_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
			IEnumerable<MedicationAdministration> g_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
			IEnumerable<MedicationAdministration> h_ = context.Operators.Union<MedicationAdministration>(e_, g_);
			bool? i_(MedicationAdministration Fibrinolytic)
			{
				Code<MedicationAdministration.MedicationAdministrationStatusCodes> m_ = Fibrinolytic?.StatusElement;
				MedicationAdministration.MedicationAdministrationStatusCodes? n_ = m_?.Value;
				Code<MedicationAdministration.MedicationAdministrationStatusCodes> o_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(n_);
				bool? p_ = context.Operators.Equal(o_, "completed");
				DataType q_ = Fibrinolytic?.Effective;
				object r_ = FHIRHelpers_4_3_000.Instance.ToValue(context, q_);
				CqlInterval<CqlDateTime> s_ = QICoreCommon_2_0_000.Instance.toInterval(context, r_);
				CqlDateTime t_ = context.Operators.Start(s_);
				CqlDateTime u_ = this.currentemergencyDepartmentArrivalTime(context, EDwithSTEMI);
				CqlQuantity w_ = context.Operators.Quantity(30m, "minutes");
				CqlDateTime x_ = context.Operators.Add(u_, w_);
				CqlInterval<CqlDateTime> y_ = context.Operators.Interval(u_, x_, false, true);
				bool? z_ = context.Operators.In<CqlDateTime>(t_, y_, default);
				bool? ab_ = context.Operators.Not((bool?)(u_ is null));
				bool? ac_ = context.Operators.And(z_, ab_);
				bool? ad_ = context.Operators.And(p_, ac_);

				return ad_;
			};
			IEnumerable<MedicationAdministration> j_ = context.Operators.Where<MedicationAdministration>(h_, i_);
			Encounter k_(MedicationAdministration Fibrinolytic) => 
				EDwithSTEMI;
			IEnumerable<Encounter> l_ = context.Operators.Select<MedicationAdministration, Encounter>(j_, k_);

			return l_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}


    [CqlDeclaration("PCI within 90 Minutes of Arrival")]
	public IEnumerable<Encounter> PCI_within_90_Minutes_of_Arrival(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
		IEnumerable<Encounter> b_(Encounter EDwithSTEMI)
		{
			CqlValueSet d_ = this.Percutaneous_Coronary_Intervention(context);
			IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
			bool? f_(Procedure PCI)
			{
				DataType j_ = PCI?.Performed;
				object k_ = FHIRHelpers_4_3_000.Instance.ToValue(context, j_);
				CqlInterval<CqlDateTime> l_ = QICoreCommon_2_0_000.Instance.toInterval(context, k_);
				CqlDateTime m_ = context.Operators.Start(l_);
				CqlDateTime n_ = this.currentemergencyDepartmentArrivalTime(context, EDwithSTEMI);
				CqlQuantity p_ = context.Operators.Quantity(90m, "minutes");
				CqlDateTime q_ = context.Operators.Add(n_, p_);
				CqlInterval<CqlDateTime> r_ = context.Operators.Interval(n_, q_, false, true);
				bool? s_ = context.Operators.In<CqlDateTime>(m_, r_, default);
				bool? u_ = context.Operators.Not((bool?)(n_ is null));
				bool? v_ = context.Operators.And(s_, u_);
				Code<EventStatus> w_ = PCI?.StatusElement;
				EventStatus? x_ = w_?.Value;
				string y_ = context.Operators.Convert<string>(x_);
				bool? z_ = context.Operators.Equal(y_, "completed");
				bool? aa_ = context.Operators.And(v_, z_);

				return aa_;
			};
			IEnumerable<Procedure> g_ = context.Operators.Where<Procedure>(e_, f_);
			Encounter h_(Procedure PCI) => 
				EDwithSTEMI;
			IEnumerable<Encounter> i_ = context.Operators.Select<Procedure, Encounter>(g_, h_);

			return i_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}


    [CqlDeclaration("ED Departure with Transfer to Acute Care Facility Within 45 Minutes of Arrival")]
	public IEnumerable<Encounter> ED_Departure_with_Transfer_to_Acute_Care_Facility_Within_45_Minutes_of_Arrival(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.ED_Encounter_with_STEMI_Diagnosis(context);
		bool? b_(Encounter EDwithSTEMI)
		{
			Period d_ = EDwithSTEMI?.Period;
			CqlInterval<CqlDateTime> e_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, d_);
			CqlDateTime f_ = context.Operators.End(e_);
			CqlInterval<CqlDateTime> h_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, d_);
			CqlDateTime i_ = context.Operators.Start(h_);
			CqlInterval<CqlDateTime> k_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, d_);
			CqlDateTime l_ = context.Operators.Start(k_);
			CqlQuantity m_ = context.Operators.Quantity(45m, "minutes");
			CqlDateTime n_ = context.Operators.Add(l_, m_);
			CqlInterval<CqlDateTime> o_ = context.Operators.Interval(i_, n_, false, true);
			bool? p_ = context.Operators.In<CqlDateTime>(f_, o_, default);
			CqlInterval<CqlDateTime> r_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, d_);
			CqlDateTime s_ = context.Operators.Start(r_);
			bool? t_ = context.Operators.Not((bool?)(s_ is null));
			bool? u_ = context.Operators.And(p_, t_);
			Encounter.HospitalizationComponent v_ = EDwithSTEMI?.Hospitalization;
			CodeableConcept w_ = v_?.DischargeDisposition;
			CqlConcept x_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, w_);
			CqlValueSet y_ = this.Discharge_To_Acute_Care_Facility(context);
			bool? z_ = context.Operators.ConceptInValueSet(x_, y_);
			bool? aa_ = context.Operators.And(u_, z_);

			return aa_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}


    [CqlDeclaration("Numerator")]
	public IEnumerable<Encounter> Numerator(CqlContext context)
	{
		IEnumerable<Encounter> a_ = this.Fibrinolytic_Therapy_within_30_Minutes_of_Arrival(context);
		IEnumerable<Encounter> b_ = this.PCI_within_90_Minutes_of_Arrival(context);
		IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
		IEnumerable<Encounter> d_ = this.ED_Departure_with_Transfer_to_Acute_Care_Facility_Within_45_Minutes_of_Arrival(context);
		IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(c_, d_);

		return e_;
	}


    [CqlDeclaration("SDE Ethnicity")]
	public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
	{
		(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_4_000.Instance.SDE_Ethnicity(context);

		return a_;
	}


    [CqlDeclaration("SDE Payer")]
	public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
	{
		IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_3_4_000.Instance.SDE_Payer(context);

		return a_;
	}


    [CqlDeclaration("SDE Race")]
	public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
	{
		(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_4_000.Instance.SDE_Race(context);

		return a_;
	}


    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex(CqlContext context)
	{
		CqlCode a_ = SupplementalDataElements_3_4_000.Instance.SDE_Sex(context);

		return a_;
	}

}
