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
[CqlLibrary("DRCommunicationWithPhysicianManagingDiabetesFHIR", "0.0.004")]
public class DRCommunicationWithPhysicianManagingDiabetesFHIR_0_0_004
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Care_Services_in_Long_Term_Residential_Facility;
    internal Lazy<CqlValueSet> __Diabetic_Retinopathy;
    internal Lazy<CqlValueSet> __Level_of_Severity_of_Retinopathy_Findings;
    internal Lazy<CqlValueSet> __Macular_Edema_Findings_Present;
    internal Lazy<CqlValueSet> __Macular_Exam;
    internal Lazy<CqlValueSet> __Medical_Reason;
    internal Lazy<CqlValueSet> __Nursing_Facility_Visit;
    internal Lazy<CqlValueSet> __Office_Visit;
    internal Lazy<CqlValueSet> __Ophthalmological_Services;
    internal Lazy<CqlValueSet> __Outpatient_Consultation;
    internal Lazy<CqlValueSet> __Patient_Reason;
    internal Lazy<CqlCode> __Birth_date;
    internal Lazy<CqlCode> __Healthcare_professional__occupation_;
    internal Lazy<CqlCode> __Macular_edema_absent__situation_;
    internal Lazy<CqlCode> __Medical_practitioner__occupation_;
    internal Lazy<CqlCode> __Ophthalmologist__occupation_;
    internal Lazy<CqlCode> __Optometrist__occupation_;
    internal Lazy<CqlCode> __Physician__occupation_;
    internal Lazy<CqlCode[]> __LOINC;
    internal Lazy<CqlCode[]> __SNOMEDCT;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<IEnumerable<Coding>> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG>> __SDE_Payer;
    internal Lazy<IEnumerable<Coding>> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;
    internal Lazy<IEnumerable<Encounter>> __Qualifying_Encounter_During_Measurement_Period;
    internal Lazy<IEnumerable<Encounter>> __Diabetic_Retinopathy_Encounter;
    internal Lazy<IEnumerable<Communication>> __Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy;
    internal Lazy<IEnumerable<Communication>> __Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema;
    internal Lazy<IEnumerable<Communication>> __Medical_or_Patient_Reason_for_Not_Communicating_Presence_of_Macular_Edema;
    internal Lazy<bool?> __Denominator_Exceptions;
    internal Lazy<bool?> __Initial_Population;
    internal Lazy<IEnumerable<Observation>> __Macular_Exam_Performed;
    internal Lazy<bool?> __Denominator;
    internal Lazy<IEnumerable<Communication>> __Level_of_Severity_of_Retinopathy_Findings_Communicated;
    internal Lazy<IEnumerable<Communication>> __Macular_Edema_Absence_Communicated;
    internal Lazy<IEnumerable<Communication>> __Macular_Edema_Presence_Communicated;
    internal Lazy<bool?> __Results_of_Dilated_Macular_or_Fundus_Exam_Communicated;
    internal Lazy<bool?> __Numerator;

    #endregion
    public DRCommunicationWithPhysicianManagingDiabetesFHIR_0_0_004(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_0_001 = new FHIRHelpers_4_0_001(context);
        SupplementalDataElementsFHIR4_2_0_000 = new SupplementalDataElementsFHIR4_2_0_000(context);
        MATGlobalCommonFunctionsFHIR4_6_1_000 = new MATGlobalCommonFunctionsFHIR4_6_1_000(context);

        __Care_Services_in_Long_Term_Residential_Facility = new Lazy<CqlValueSet>(this.Care_Services_in_Long_Term_Residential_Facility_Value);
        __Diabetic_Retinopathy = new Lazy<CqlValueSet>(this.Diabetic_Retinopathy_Value);
        __Level_of_Severity_of_Retinopathy_Findings = new Lazy<CqlValueSet>(this.Level_of_Severity_of_Retinopathy_Findings_Value);
        __Macular_Edema_Findings_Present = new Lazy<CqlValueSet>(this.Macular_Edema_Findings_Present_Value);
        __Macular_Exam = new Lazy<CqlValueSet>(this.Macular_Exam_Value);
        __Medical_Reason = new Lazy<CqlValueSet>(this.Medical_Reason_Value);
        __Nursing_Facility_Visit = new Lazy<CqlValueSet>(this.Nursing_Facility_Visit_Value);
        __Office_Visit = new Lazy<CqlValueSet>(this.Office_Visit_Value);
        __Ophthalmological_Services = new Lazy<CqlValueSet>(this.Ophthalmological_Services_Value);
        __Outpatient_Consultation = new Lazy<CqlValueSet>(this.Outpatient_Consultation_Value);
        __Patient_Reason = new Lazy<CqlValueSet>(this.Patient_Reason_Value);
        __Birth_date = new Lazy<CqlCode>(this.Birth_date_Value);
        __Healthcare_professional__occupation_ = new Lazy<CqlCode>(this.Healthcare_professional__occupation__Value);
        __Macular_edema_absent__situation_ = new Lazy<CqlCode>(this.Macular_edema_absent__situation__Value);
        __Medical_practitioner__occupation_ = new Lazy<CqlCode>(this.Medical_practitioner__occupation__Value);
        __Ophthalmologist__occupation_ = new Lazy<CqlCode>(this.Ophthalmologist__occupation__Value);
        __Optometrist__occupation_ = new Lazy<CqlCode>(this.Optometrist__occupation__Value);
        __Physician__occupation_ = new Lazy<CqlCode>(this.Physician__occupation__Value);
        __LOINC = new Lazy<CqlCode[]>(this.LOINC_Value);
        __SNOMEDCT = new Lazy<CqlCode[]>(this.SNOMEDCT_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __SDE_Ethnicity = new Lazy<IEnumerable<Coding>>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<IEnumerable<Coding>>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
        __Qualifying_Encounter_During_Measurement_Period = new Lazy<IEnumerable<Encounter>>(this.Qualifying_Encounter_During_Measurement_Period_Value);
        __Diabetic_Retinopathy_Encounter = new Lazy<IEnumerable<Encounter>>(this.Diabetic_Retinopathy_Encounter_Value);
        __Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy = new Lazy<IEnumerable<Communication>>(this.Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy_Value);
        __Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema = new Lazy<IEnumerable<Communication>>(this.Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema_Value);
        __Medical_or_Patient_Reason_for_Not_Communicating_Presence_of_Macular_Edema = new Lazy<IEnumerable<Communication>>(this.Medical_or_Patient_Reason_for_Not_Communicating_Presence_of_Macular_Edema_Value);
        __Denominator_Exceptions = new Lazy<bool?>(this.Denominator_Exceptions_Value);
        __Initial_Population = new Lazy<bool?>(this.Initial_Population_Value);
        __Macular_Exam_Performed = new Lazy<IEnumerable<Observation>>(this.Macular_Exam_Performed_Value);
        __Denominator = new Lazy<bool?>(this.Denominator_Value);
        __Level_of_Severity_of_Retinopathy_Findings_Communicated = new Lazy<IEnumerable<Communication>>(this.Level_of_Severity_of_Retinopathy_Findings_Communicated_Value);
        __Macular_Edema_Absence_Communicated = new Lazy<IEnumerable<Communication>>(this.Macular_Edema_Absence_Communicated_Value);
        __Macular_Edema_Presence_Communicated = new Lazy<IEnumerable<Communication>>(this.Macular_Edema_Presence_Communicated_Value);
        __Results_of_Dilated_Macular_or_Fundus_Exam_Communicated = new Lazy<bool?>(this.Results_of_Dilated_Macular_or_Fundus_Exam_Communicated_Value);
        __Numerator = new Lazy<bool?>(this.Numerator_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_0_001 FHIRHelpers_4_0_001 { get; }
    public SupplementalDataElementsFHIR4_2_0_000 SupplementalDataElementsFHIR4_2_0_000 { get; }
    public MATGlobalCommonFunctionsFHIR4_6_1_000 MATGlobalCommonFunctionsFHIR4_6_1_000 { get; }

    #endregion

	private CqlValueSet Care_Services_in_Long_Term_Residential_Facility_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014", null);

    [CqlDeclaration("Care Services in Long-Term Residential Facility")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014")]
	public CqlValueSet Care_Services_in_Long_Term_Residential_Facility() => 
		__Care_Services_in_Long_Term_Residential_Facility.Value;

	private CqlValueSet Diabetic_Retinopathy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.327", null);

    [CqlDeclaration("Diabetic Retinopathy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.327")]
	public CqlValueSet Diabetic_Retinopathy() => 
		__Diabetic_Retinopathy.Value;

	private CqlValueSet Level_of_Severity_of_Retinopathy_Findings_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1283", null);

    [CqlDeclaration("Level of Severity of Retinopathy Findings")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1283")]
	public CqlValueSet Level_of_Severity_of_Retinopathy_Findings() => 
		__Level_of_Severity_of_Retinopathy_Findings.Value;

	private CqlValueSet Macular_Edema_Findings_Present_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1320", null);

    [CqlDeclaration("Macular Edema Findings Present")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1320")]
	public CqlValueSet Macular_Edema_Findings_Present() => 
		__Macular_Edema_Findings_Present.Value;

	private CqlValueSet Macular_Exam_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1251", null);

    [CqlDeclaration("Macular Exam")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1251")]
	public CqlValueSet Macular_Exam() => 
		__Macular_Exam.Value;

	private CqlValueSet Medical_Reason_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007", null);

    [CqlDeclaration("Medical Reason")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007")]
	public CqlValueSet Medical_Reason() => 
		__Medical_Reason.Value;

	private CqlValueSet Nursing_Facility_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012", null);

    [CqlDeclaration("Nursing Facility Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012")]
	public CqlValueSet Nursing_Facility_Visit() => 
		__Nursing_Facility_Visit.Value;

	private CqlValueSet Office_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
	public CqlValueSet Office_Visit() => 
		__Office_Visit.Value;

	private CqlValueSet Ophthalmological_Services_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285", null);

    [CqlDeclaration("Ophthalmological Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285")]
	public CqlValueSet Ophthalmological_Services() => 
		__Ophthalmological_Services.Value;

	private CqlValueSet Outpatient_Consultation_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", null);

    [CqlDeclaration("Outpatient Consultation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008")]
	public CqlValueSet Outpatient_Consultation() => 
		__Outpatient_Consultation.Value;

	private CqlValueSet Patient_Reason_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1008", null);

    [CqlDeclaration("Patient Reason")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1008")]
	public CqlValueSet Patient_Reason() => 
		__Patient_Reason.Value;

	private CqlCode Birth_date_Value() => 
		new CqlCode("21112-8", "http://loinc.org", null, null);

    [CqlDeclaration("Birth date")]
	public CqlCode Birth_date() => 
		__Birth_date.Value;

	private CqlCode Healthcare_professional__occupation__Value() => 
		new CqlCode("223366009", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Healthcare professional (occupation)")]
	public CqlCode Healthcare_professional__occupation_() => 
		__Healthcare_professional__occupation_.Value;

	private CqlCode Macular_edema_absent__situation__Value() => 
		new CqlCode("428341000124108", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Macular edema absent (situation)")]
	public CqlCode Macular_edema_absent__situation_() => 
		__Macular_edema_absent__situation_.Value;

	private CqlCode Medical_practitioner__occupation__Value() => 
		new CqlCode("158965000", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Medical practitioner (occupation)")]
	public CqlCode Medical_practitioner__occupation_() => 
		__Medical_practitioner__occupation_.Value;

	private CqlCode Ophthalmologist__occupation__Value() => 
		new CqlCode("422234006", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Ophthalmologist (occupation)")]
	public CqlCode Ophthalmologist__occupation_() => 
		__Ophthalmologist__occupation_.Value;

	private CqlCode Optometrist__occupation__Value() => 
		new CqlCode("28229004", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Optometrist (occupation)")]
	public CqlCode Optometrist__occupation_() => 
		__Optometrist__occupation_.Value;

	private CqlCode Physician__occupation__Value() => 
		new CqlCode("309343006", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Physician (occupation)")]
	public CqlCode Physician__occupation_() => 
		__Physician__occupation_.Value;

	private CqlCode[] LOINC_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("21112-8", "http://loinc.org", null, null),
		};

		return a_;
	}

    [CqlDeclaration("LOINC")]
	public CqlCode[] LOINC() => 
		__LOINC.Value;

	private CqlCode[] SNOMEDCT_Value()
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

    [CqlDeclaration("SNOMEDCT")]
	public CqlCode[] SNOMEDCT() => 
		__SNOMEDCT.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.ResolveParameter("DRCommunicationWithPhysicianManagingDiabetesFHIR-0.0.004", "Measurement Period", null);

		return (CqlInterval<CqlDateTime>)a_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period.Value;

	private Patient Patient_Value()
	{
		var a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		var b_ = context.Operators.SingleOrNull<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private IEnumerable<Coding> SDE_Ethnicity_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public IEnumerable<Coding> SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer() => 
		__SDE_Payer.Value;

	private IEnumerable<Coding> SDE_Race_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public IEnumerable<Coding> SDE_Race() => 
		__SDE_Race.Value;

	private CqlCode SDE_Sex_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Sex();

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex() => 
		__SDE_Sex.Value;

	private IEnumerable<Encounter> Qualifying_Encounter_During_Measurement_Period_Value()
	{
		var a_ = this.Office_Visit();
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		var c_ = this.Ophthalmological_Services();
		var d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, null);
		var e_ = context.Operators.ListUnion<Encounter>(b_, d_);
		var f_ = this.Outpatient_Consultation();
		var g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, null);
		var h_ = this.Care_Services_in_Long_Term_Residential_Facility();
		var i_ = context.Operators.RetrieveByValueSet<Encounter>(h_, null);
		var j_ = context.Operators.ListUnion<Encounter>(g_, i_);
		var k_ = context.Operators.ListUnion<Encounter>(e_, j_);
		var l_ = this.Nursing_Facility_Visit();
		var m_ = context.Operators.RetrieveByValueSet<Encounter>(l_, null);
		var n_ = context.Operators.ListUnion<Encounter>(k_, m_);
		bool? o_(Encounter QualifyingEncounter)
		{
			var q_ = this.Measurement_Period();
			var r_ = QualifyingEncounter?.Period;
			var s_ = FHIRHelpers_4_0_001.ToInterval(r_);
			var t_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(q_, s_, null);
			var u_ = QualifyingEncounter?.StatusElement;
			var v_ = context.Operators.Convert<string>(u_);
			var w_ = context.Operators.Equal(v_, "finished");
			var x_ = context.Operators.And(t_, w_);

			return x_;
		};
		var p_ = context.Operators.WhereOrNull<Encounter>(n_, o_);

		return p_;
	}

    [CqlDeclaration("Qualifying Encounter During Measurement Period")]
	public IEnumerable<Encounter> Qualifying_Encounter_During_Measurement_Period() => 
		__Qualifying_Encounter_During_Measurement_Period.Value;

	private IEnumerable<Encounter> Diabetic_Retinopathy_Encounter_Value()
	{
		var a_ = this.Qualifying_Encounter_During_Measurement_Period();
		IEnumerable<Encounter> b_(Encounter ValidQualifyingEncounter)
		{
			var d_ = this.Diabetic_Retinopathy();
			var e_ = context.Operators.RetrieveByValueSet<Condition>(d_, null);
			bool? f_(Condition DiabeticRetinopathy)
			{
				var j_ = DiabeticRetinopathy?.ClinicalStatus;
				var k_ = FHIRHelpers_4_0_001.ToConcept(j_);
				var l_ = MATGlobalCommonFunctionsFHIR4_6_1_000.active();
				var m_ = context.Operators.ConvertCodeToConcept(l_);
				var n_ = context.Operators.Equivalent(k_, m_);
				var o_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(DiabeticRetinopathy);
				var p_ = ValidQualifyingEncounter?.Period;
				var q_ = FHIRHelpers_4_0_001.ToInterval(p_);
				var r_ = context.Operators.Overlaps(o_, q_, null);
				var s_ = context.Operators.And(n_, r_);

				return s_;
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

    [CqlDeclaration("Diabetic Retinopathy Encounter")]
	public IEnumerable<Encounter> Diabetic_Retinopathy_Encounter() => 
		__Diabetic_Retinopathy_Encounter.Value;

    [CqlDeclaration("GetModifierExtensions")]
	public IEnumerable<Extension> GetModifierExtensions(DomainResource domainResource, string url)
	{
		var a_ = domainResource?.ModifierExtension;
		bool? b_(Extension E)
		{
			var f_ = E?.Url;
			var g_ = context.Operators.Convert<FhirUri>(f_);
			var h_ = context.Operators.Convert<string>(g_);
			var i_ = context.Operators.Concatenate("http://hl7.org/fhir/us/qicore/StructureDefinition/", url);
			var j_ = context.Operators.Equal(h_, i_);

			return j_;
		};
		var c_ = context.Operators.WhereOrNull<Extension>((a_ as IEnumerable<Extension>), b_);
		Extension d_(Extension E) => 
			E;
		var e_ = context.Operators.SelectOrNull<Extension, Extension>(c_, d_);

		return e_;
	}

    [CqlDeclaration("GetModifierExtension")]
	public Extension GetModifierExtension(DomainResource domainResource, string url)
	{
		var a_ = this.GetModifierExtensions(domainResource, url);
		var b_ = context.Operators.SingleOrNull<Extension>(a_);

		return b_;
	}

	private IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy_Value()
	{
		var a_ = this.Level_of_Severity_of_Retinopathy_Findings();
		var b_ = typeof(Communication).GetProperty("ReasonCode");
		var c_ = context.Operators.RetrieveByValueSet<Communication>(a_, b_);
		IEnumerable<Communication> d_(Communication LevelOfSeverityNotCommunicated)
		{
			var h_ = this.Diabetic_Retinopathy_Encounter();
			bool? i_(Encounter EncounterDiabeticRetinopathy)
			{
				var m_ = EncounterDiabeticRetinopathy?.Period;
				var n_ = FHIRHelpers_4_0_001.ToInterval(m_);
				var o_ = MATGlobalCommonFunctionsFHIR4_6_1_000.GetExtension((DomainResource)LevelOfSeverityNotCommunicated, "qicore-recorded");
				var p_ = o_?.Value;
				var q_ = FHIRHelpers_4_0_001.ToInterval((p_ as Period));
				var r_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(n_, q_, null);

				return r_;
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
			var s_ = LevelOfSeverityNotCommunicated?.StatusElement;
			var t_ = context.Operators.Convert<string>(s_);
			var u_ = context.Operators.Equal(t_, "not-done");
			var v_ = this.GetModifierExtension(LevelOfSeverityNotCommunicated, "qicore-notDone");
			var w_ = v_?.Value;
			var x_ = FHIRHelpers_4_0_001.ToBoolean((w_ as FhirBoolean));
			var y_ = context.Operators.IsTrue(x_);
			var z_ = context.Operators.And(u_, y_);
			var aa_ = LevelOfSeverityNotCommunicated?.StatusReason;
			var ab_ = FHIRHelpers_4_0_001.ToConcept(aa_);
			var ac_ = this.Medical_Reason();
			var ad_ = context.Operators.ConceptInValueSet(ab_, ac_);
			var af_ = FHIRHelpers_4_0_001.ToConcept(aa_);
			var ag_ = this.Patient_Reason();
			var ah_ = context.Operators.ConceptInValueSet(af_, ag_);
			var ai_ = context.Operators.Or(ad_, ah_);
			var aj_ = context.Operators.And(z_, ai_);

			return aj_;
		};
		var g_ = context.Operators.WhereOrNull<Communication>(e_, f_);

		return g_;
	}

    [CqlDeclaration("Medical or Patient Reason for Not Communicating Level of Severity of Retinopathy")]
	public IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy() => 
		__Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy.Value;

	private IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema_Value()
	{
		var a_ = this.Macular_edema_absent__situation_();
		var b_ = context.Operators.ToList<CqlCode>(a_);
		var c_ = typeof(Communication).GetProperty("ReasonCode");
		var d_ = context.Operators.RetrieveByCodes<Communication>(b_, c_);
		IEnumerable<Communication> e_(Communication MacularEdemaAbsentNotCommunicated)
		{
			var i_ = this.Diabetic_Retinopathy_Encounter();
			bool? j_(Encounter EncounterDiabeticRetinopathy)
			{
				var n_ = EncounterDiabeticRetinopathy?.Period;
				var o_ = FHIRHelpers_4_0_001.ToInterval(n_);
				var p_ = MATGlobalCommonFunctionsFHIR4_6_1_000.GetExtension((DomainResource)MacularEdemaAbsentNotCommunicated, "qicore-recorded");
				var q_ = p_?.Value;
				var r_ = FHIRHelpers_4_0_001.ToInterval((q_ as Period));
				var s_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(o_, r_, null);

				return s_;
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
			var t_ = MacularEdemaAbsentNotCommunicated?.StatusElement;
			var u_ = context.Operators.Convert<string>(t_);
			var v_ = context.Operators.Equal(u_, "not-done");
			var w_ = this.GetModifierExtension(MacularEdemaAbsentNotCommunicated, "qicore-notDone");
			var x_ = w_?.Value;
			var y_ = FHIRHelpers_4_0_001.ToBoolean((x_ as FhirBoolean));
			var z_ = context.Operators.IsTrue(y_);
			var aa_ = context.Operators.And(v_, z_);
			var ab_ = MacularEdemaAbsentNotCommunicated?.StatusReason;
			var ac_ = FHIRHelpers_4_0_001.ToConcept(ab_);
			var ad_ = this.Medical_Reason();
			var ae_ = context.Operators.ConceptInValueSet(ac_, ad_);
			var ag_ = FHIRHelpers_4_0_001.ToConcept(ab_);
			var ah_ = this.Patient_Reason();
			var ai_ = context.Operators.ConceptInValueSet(ag_, ah_);
			var aj_ = context.Operators.Or(ae_, ai_);
			var ak_ = context.Operators.And(aa_, aj_);

			return ak_;
		};
		var h_ = context.Operators.WhereOrNull<Communication>(f_, g_);

		return h_;
	}

    [CqlDeclaration("Medical or Patient Reason for Not Communicating Absence of Macular Edema")]
	public IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema() => 
		__Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema.Value;

	private IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Presence_of_Macular_Edema_Value()
	{
		var a_ = this.Macular_Edema_Findings_Present();
		var b_ = typeof(Communication).GetProperty("ReasonCode");
		var c_ = context.Operators.RetrieveByValueSet<Communication>(a_, b_);
		IEnumerable<Communication> d_(Communication MacularEdemaPresentNotCommunicated)
		{
			var h_ = this.Diabetic_Retinopathy_Encounter();
			bool? i_(Encounter EncounterDiabeticRetinopathy)
			{
				var m_ = EncounterDiabeticRetinopathy?.Period;
				var n_ = FHIRHelpers_4_0_001.ToInterval(m_);
				var o_ = MATGlobalCommonFunctionsFHIR4_6_1_000.GetExtension((DomainResource)MacularEdemaPresentNotCommunicated, "qicore-recorded");
				var p_ = o_?.Value;
				var q_ = FHIRHelpers_4_0_001.ToInterval((p_ as Period));
				var r_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(n_, q_, null);

				return r_;
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
			var s_ = MacularEdemaPresentNotCommunicated?.StatusElement;
			var t_ = context.Operators.Convert<string>(s_);
			var u_ = context.Operators.Equal(t_, "not-done");
			var v_ = this.GetModifierExtension(MacularEdemaPresentNotCommunicated, "qicore-notDone");
			var w_ = v_?.Value;
			var x_ = FHIRHelpers_4_0_001.ToBoolean((w_ as FhirBoolean));
			var y_ = context.Operators.IsTrue(x_);
			var z_ = context.Operators.And(u_, y_);
			var aa_ = MacularEdemaPresentNotCommunicated?.StatusReason;
			var ab_ = FHIRHelpers_4_0_001.ToConcept(aa_);
			var ac_ = this.Medical_Reason();
			var ad_ = context.Operators.ConceptInValueSet(ab_, ac_);
			var af_ = FHIRHelpers_4_0_001.ToConcept(aa_);
			var ag_ = this.Patient_Reason();
			var ah_ = context.Operators.ConceptInValueSet(af_, ag_);
			var ai_ = context.Operators.Or(ad_, ah_);
			var aj_ = context.Operators.And(z_, ai_);

			return aj_;
		};
		var g_ = context.Operators.WhereOrNull<Communication>(e_, f_);

		return g_;
	}

    [CqlDeclaration("Medical or Patient Reason for Not Communicating Presence of Macular Edema")]
	public IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Presence_of_Macular_Edema() => 
		__Medical_or_Patient_Reason_for_Not_Communicating_Presence_of_Macular_Edema.Value;

	private bool? Denominator_Exceptions_Value()
	{
		var a_ = this.Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy();
		var b_ = context.Operators.ExistsInList<Communication>(a_);
		var c_ = this.Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema();
		var d_ = context.Operators.ExistsInList<Communication>(c_);
		var e_ = context.Operators.Or(b_, d_);
		var f_ = this.Medical_or_Patient_Reason_for_Not_Communicating_Presence_of_Macular_Edema();
		var g_ = context.Operators.ExistsInList<Communication>(f_);
		var h_ = context.Operators.Or(e_, g_);

		return h_;
	}

    [CqlDeclaration("Denominator Exceptions")]
	public bool? Denominator_Exceptions() => 
		__Denominator_Exceptions.Value;

	private bool? Initial_Population_Value()
	{
		var a_ = this.Patient();
		var b_ = a_?.BirthDateElement;
		var c_ = b_?.Value;
		var d_ = context.Operators.ConvertStringToDateTime(c_);
		var e_ = this.Measurement_Period();
		var f_ = context.Operators.Start(e_);
		var g_ = context.Operators.CalculateAgeAt(d_, f_, "year");
		var h_ = context.Operators.GreaterOrEqual(g_, (int?)18);
		var i_ = this.Diabetic_Retinopathy_Encounter();
		var j_ = context.Operators.ExistsInList<Encounter>(i_);
		var k_ = context.Operators.And(h_, j_);

		return k_;
	}

    [CqlDeclaration("Initial Population")]
	public bool? Initial_Population() => 
		__Initial_Population.Value;

	private IEnumerable<Observation> Macular_Exam_Performed_Value()
	{
		var a_ = this.Macular_Exam();
		var b_ = context.Operators.RetrieveByValueSet<Observation>(a_, null);
		IEnumerable<Observation> c_(Observation MacularExam)
		{
			var g_ = this.Diabetic_Retinopathy_Encounter();
			bool? h_(Encounter EncounterDiabeticRetinopathy)
			{
				var l_ = EncounterDiabeticRetinopathy?.Period;
				var m_ = FHIRHelpers_4_0_001.ToInterval(l_);
				var n_ = MacularExam?.Effective;
				var o_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(n_);
				var p_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(m_, o_, null);

				return p_;
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
			var q_ = MacularExam?.StatusElement;
			var r_ = context.Operators.Convert<string>(q_);
			var s_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var t_ = context.Operators.InList<string>(r_, (s_ as IEnumerable<string>));
			var u_ = MacularExam?.Value;
			var v_ = context.Operators.Not((bool?)(u_ is null));
			var w_ = context.Operators.And(t_, v_);

			return w_;
		};
		var f_ = context.Operators.WhereOrNull<Observation>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Macular Exam Performed")]
	public IEnumerable<Observation> Macular_Exam_Performed() => 
		__Macular_Exam_Performed.Value;

	private bool? Denominator_Value()
	{
		var a_ = this.Initial_Population();
		var b_ = this.Macular_Exam_Performed();
		var c_ = context.Operators.ExistsInList<Observation>(b_);
		var d_ = context.Operators.And(a_, c_);

		return d_;
	}

    [CqlDeclaration("Denominator")]
	public bool? Denominator() => 
		__Denominator.Value;

	private IEnumerable<Communication> Level_of_Severity_of_Retinopathy_Findings_Communicated_Value()
	{
		var a_ = this.Level_of_Severity_of_Retinopathy_Findings();
		var b_ = typeof(Communication).GetProperty("ReasonCode");
		var c_ = context.Operators.RetrieveByValueSet<Communication>(a_, b_);
		IEnumerable<Communication> d_(Communication LevelOfSeverityCommunicated)
		{
			var h_ = this.Diabetic_Retinopathy_Encounter();
			bool? i_(Encounter EncounterDiabeticRetinopathy)
			{
				var m_ = LevelOfSeverityCommunicated?.SentElement;
				var n_ = FHIRHelpers_4_0_001.ToDateTime(m_);
				var o_ = EncounterDiabeticRetinopathy?.Period;
				var p_ = FHIRHelpers_4_0_001.ToInterval(o_);
				var q_ = context.Operators.Start(p_);
				var r_ = context.Operators.After(n_, q_, null);

				return r_;
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
			var s_ = LevelOfSeverityCommunicated?.StatusElement;
			var t_ = context.Operators.Convert<string>(s_);
			var u_ = context.Operators.Equal(t_, "completed");

			return u_;
		};
		var g_ = context.Operators.WhereOrNull<Communication>(e_, f_);

		return g_;
	}

    [CqlDeclaration("Level of Severity of Retinopathy Findings Communicated")]
	public IEnumerable<Communication> Level_of_Severity_of_Retinopathy_Findings_Communicated() => 
		__Level_of_Severity_of_Retinopathy_Findings_Communicated.Value;

	private IEnumerable<Communication> Macular_Edema_Absence_Communicated_Value()
	{
		var a_ = this.Macular_edema_absent__situation_();
		var b_ = context.Operators.ToList<CqlCode>(a_);
		var c_ = typeof(Communication).GetProperty("ReasonCode");
		var d_ = context.Operators.RetrieveByCodes<Communication>(b_, c_);
		IEnumerable<Communication> e_(Communication MacularEdemaAbsentCommunicated)
		{
			var i_ = this.Diabetic_Retinopathy_Encounter();
			bool? j_(Encounter EncounterDiabeticRetinopathy)
			{
				var n_ = MacularEdemaAbsentCommunicated?.SentElement;
				var o_ = FHIRHelpers_4_0_001.ToDateTime(n_);
				var p_ = EncounterDiabeticRetinopathy?.Period;
				var q_ = FHIRHelpers_4_0_001.ToInterval(p_);
				var r_ = context.Operators.Start(q_);
				var s_ = context.Operators.After(o_, r_, null);

				return s_;
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
			var t_ = MacularEdemaAbsentCommunicated?.StatusElement;
			var u_ = context.Operators.Convert<string>(t_);
			var v_ = context.Operators.Equal(u_, "completed");

			return v_;
		};
		var h_ = context.Operators.WhereOrNull<Communication>(f_, g_);

		return h_;
	}

    [CqlDeclaration("Macular Edema Absence Communicated")]
	public IEnumerable<Communication> Macular_Edema_Absence_Communicated() => 
		__Macular_Edema_Absence_Communicated.Value;

	private IEnumerable<Communication> Macular_Edema_Presence_Communicated_Value()
	{
		var a_ = this.Macular_Edema_Findings_Present();
		var b_ = typeof(Communication).GetProperty("ReasonCode");
		var c_ = context.Operators.RetrieveByValueSet<Communication>(a_, b_);
		IEnumerable<Communication> d_(Communication MacularEdemaPresentCommunicated)
		{
			var h_ = this.Diabetic_Retinopathy_Encounter();
			bool? i_(Encounter EncounterDiabeticRetinopathy)
			{
				var m_ = MacularEdemaPresentCommunicated?.SentElement;
				var n_ = FHIRHelpers_4_0_001.ToDateTime(m_);
				var o_ = EncounterDiabeticRetinopathy?.Period;
				var p_ = FHIRHelpers_4_0_001.ToInterval(o_);
				var q_ = context.Operators.Start(p_);
				var r_ = context.Operators.After(n_, q_, null);

				return r_;
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
			var s_ = MacularEdemaPresentCommunicated?.StatusElement;
			var t_ = context.Operators.Convert<string>(s_);
			var u_ = context.Operators.Equal(t_, "completed");

			return u_;
		};
		var g_ = context.Operators.WhereOrNull<Communication>(e_, f_);

		return g_;
	}

    [CqlDeclaration("Macular Edema Presence Communicated")]
	public IEnumerable<Communication> Macular_Edema_Presence_Communicated() => 
		__Macular_Edema_Presence_Communicated.Value;

	private bool? Results_of_Dilated_Macular_or_Fundus_Exam_Communicated_Value()
	{
		var a_ = this.Level_of_Severity_of_Retinopathy_Findings_Communicated();
		var b_ = context.Operators.ExistsInList<Communication>(a_);
		var c_ = this.Macular_Edema_Absence_Communicated();
		var d_ = context.Operators.ExistsInList<Communication>(c_);
		var e_ = this.Macular_Edema_Presence_Communicated();
		var f_ = context.Operators.ExistsInList<Communication>(e_);
		var g_ = context.Operators.Or(d_, f_);
		var h_ = context.Operators.And(b_, g_);

		return h_;
	}

    [CqlDeclaration("Results of Dilated Macular or Fundus Exam Communicated")]
	public bool? Results_of_Dilated_Macular_or_Fundus_Exam_Communicated() => 
		__Results_of_Dilated_Macular_or_Fundus_Exam_Communicated.Value;

	private bool? Numerator_Value()
	{
		var a_ = this.Level_of_Severity_of_Retinopathy_Findings_Communicated();
		var b_ = context.Operators.ExistsInList<Communication>(a_);
		var c_ = this.Macular_Edema_Absence_Communicated();
		var d_ = context.Operators.ExistsInList<Communication>(c_);
		var e_ = this.Macular_Edema_Presence_Communicated();
		var f_ = context.Operators.ExistsInList<Communication>(e_);
		var g_ = context.Operators.Or(d_, f_);
		var h_ = context.Operators.And(b_, g_);

		return h_;
	}

    [CqlDeclaration("Numerator")]
	public bool? Numerator() => 
		__Numerator.Value;

}