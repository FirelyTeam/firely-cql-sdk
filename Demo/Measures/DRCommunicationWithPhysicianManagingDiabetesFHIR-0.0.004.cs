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


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlCode[]> __LOINC;
    internal Lazy<CqlCode[]> __SNOMEDCT;
    internal Lazy<CqlCode> __Birth_date;
    internal Lazy<CqlCode> __Healthcare_professional__occupation_;
    internal Lazy<CqlCode> __Macular_edema_absent__situation_;
    internal Lazy<CqlCode> __Medical_practitioner__occupation_;
    internal Lazy<CqlCode> __Ophthalmologist__occupation_;
    internal Lazy<CqlCode> __Optometrist__occupation_;
    internal Lazy<CqlCode> __Physician__occupation_;
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

        __LOINC = new Lazy<CqlCode[]>(this.LOINC_Value);
        __SNOMEDCT = new Lazy<CqlCode[]>(this.SNOMEDCT_Value);
        __Birth_date = new Lazy<CqlCode>(this.Birth_date_Value);
        __Healthcare_professional__occupation_ = new Lazy<CqlCode>(this.Healthcare_professional__occupation__Value);
        __Macular_edema_absent__situation_ = new Lazy<CqlCode>(this.Macular_edema_absent__situation__Value);
        __Medical_practitioner__occupation_ = new Lazy<CqlCode>(this.Medical_practitioner__occupation__Value);
        __Ophthalmologist__occupation_ = new Lazy<CqlCode>(this.Ophthalmologist__occupation__Value);
        __Optometrist__occupation_ = new Lazy<CqlCode>(this.Optometrist__occupation__Value);
        __Physician__occupation_ = new Lazy<CqlCode>(this.Physician__occupation__Value);
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

	private CqlCode[] LOINC_Value()
	{
		var a_ = new CqlCode[0]
;

		return a_;
	}

    [CqlDeclaration("LOINC")]
	public CqlCode[] LOINC() => 
		__LOINC.Value;

	private CqlCode[] SNOMEDCT_Value()
	{
		var a_ = new CqlCode[0]
;

		return a_;
	}

    [CqlDeclaration("SNOMEDCT")]
	public CqlCode[] SNOMEDCT() => 
		__SNOMEDCT.Value;

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
			var r_ = FHIRHelpers_4_0_001.ToInterval(QualifyingEncounter?.Period);
			var s_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(q_, r_, null);
			var t_ = context.Operators.Convert<string>(QualifyingEncounter?.StatusElement);
			var u_ = context.Operators.Equal(t_, "finished");
			var v_ = context.Operators.And(s_, u_);

			return v_;
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
				var j_ = FHIRHelpers_4_0_001.ToConcept(DiabeticRetinopathy?.ClinicalStatus);
				var k_ = MATGlobalCommonFunctionsFHIR4_6_1_000.active();
				var l_ = context.Operators.ConvertCodeToConcept(k_);
				var m_ = context.Operators.Equivalent(j_, l_);
				var n_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(DiabeticRetinopathy);
				var o_ = FHIRHelpers_4_0_001.ToInterval(ValidQualifyingEncounter?.Period);
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

    [CqlDeclaration("Diabetic Retinopathy Encounter")]
	public IEnumerable<Encounter> Diabetic_Retinopathy_Encounter() => 
		__Diabetic_Retinopathy_Encounter.Value;

    [CqlDeclaration("GetModifierExtensions")]
	public IEnumerable<Extension> GetModifierExtensions(DomainResource domainResource, string url)
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
				var m_ = FHIRHelpers_4_0_001.ToInterval(EncounterDiabeticRetinopathy?.Period);
				var n_ = MATGlobalCommonFunctionsFHIR4_6_1_000.GetExtension(LevelOfSeverityNotCommunicated, "qicore-recorded");
				var o_ = FHIRHelpers_4_0_001.ToInterval((n_?.Value as Period));
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
			var s_ = this.GetModifierExtension(LevelOfSeverityNotCommunicated, "qicore-notDone");
			var t_ = FHIRHelpers_4_0_001.ToBoolean((s_?.Value as FhirBoolean));
			var u_ = context.Operators.IsTrue(t_);
			var v_ = context.Operators.And(r_, u_);
			var w_ = FHIRHelpers_4_0_001.ToConcept(LevelOfSeverityNotCommunicated?.StatusReason);
			var x_ = this.Medical_Reason();
			var y_ = context.Operators.ConceptInValueSet(w_, x_);
			var aa_ = this.Patient_Reason();
			var ab_ = context.Operators.ConceptInValueSet(w_, aa_);
			var ac_ = context.Operators.Or(y_, ab_);
			var ad_ = context.Operators.And(v_, ac_);

			return ad_;
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
				var n_ = FHIRHelpers_4_0_001.ToInterval(EncounterDiabeticRetinopathy?.Period);
				var o_ = MATGlobalCommonFunctionsFHIR4_6_1_000.GetExtension(MacularEdemaAbsentNotCommunicated, "qicore-recorded");
				var p_ = FHIRHelpers_4_0_001.ToInterval((o_?.Value as Period));
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
			var t_ = this.GetModifierExtension(MacularEdemaAbsentNotCommunicated, "qicore-notDone");
			var u_ = FHIRHelpers_4_0_001.ToBoolean((t_?.Value as FhirBoolean));
			var v_ = context.Operators.IsTrue(u_);
			var w_ = context.Operators.And(s_, v_);
			var x_ = FHIRHelpers_4_0_001.ToConcept(MacularEdemaAbsentNotCommunicated?.StatusReason);
			var y_ = this.Medical_Reason();
			var z_ = context.Operators.ConceptInValueSet(x_, y_);
			var ab_ = this.Patient_Reason();
			var ac_ = context.Operators.ConceptInValueSet(x_, ab_);
			var ad_ = context.Operators.Or(z_, ac_);
			var ae_ = context.Operators.And(w_, ad_);

			return ae_;
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
				var m_ = FHIRHelpers_4_0_001.ToInterval(EncounterDiabeticRetinopathy?.Period);
				var n_ = MATGlobalCommonFunctionsFHIR4_6_1_000.GetExtension(MacularEdemaPresentNotCommunicated, "qicore-recorded");
				var o_ = FHIRHelpers_4_0_001.ToInterval((n_?.Value as Period));
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
			var s_ = this.GetModifierExtension(MacularEdemaPresentNotCommunicated, "qicore-notDone");
			var t_ = FHIRHelpers_4_0_001.ToBoolean((s_?.Value as FhirBoolean));
			var u_ = context.Operators.IsTrue(t_);
			var v_ = context.Operators.And(r_, u_);
			var w_ = FHIRHelpers_4_0_001.ToConcept(MacularEdemaPresentNotCommunicated?.StatusReason);
			var x_ = this.Medical_Reason();
			var y_ = context.Operators.ConceptInValueSet(w_, x_);
			var aa_ = this.Patient_Reason();
			var ab_ = context.Operators.ConceptInValueSet(w_, aa_);
			var ac_ = context.Operators.Or(y_, ab_);
			var ad_ = context.Operators.And(v_, ac_);

			return ad_;
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
		var b_ = context.Operators.ConvertStringToDateTime(a_?.BirthDateElement?.Value);
		var c_ = this.Measurement_Period();
		var d_ = context.Operators.Start(c_);
		var e_ = context.Operators.CalculateAgeAt(b_, d_, "year");
		var f_ = context.Operators.GreaterOrEqual(e_, (int?)18);
		var g_ = this.Diabetic_Retinopathy_Encounter();
		var h_ = context.Operators.ExistsInList<Encounter>(g_);
		var i_ = context.Operators.And(f_, h_);

		return i_;
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
				var l_ = FHIRHelpers_4_0_001.ToInterval(EncounterDiabeticRetinopathy?.Period);
				var m_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(MacularExam?.Effective);
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
				var m_ = FHIRHelpers_4_0_001.ToDateTime(LevelOfSeverityCommunicated?.SentElement);
				var n_ = FHIRHelpers_4_0_001.ToInterval(EncounterDiabeticRetinopathy?.Period);
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
				var n_ = FHIRHelpers_4_0_001.ToDateTime(MacularEdemaAbsentCommunicated?.SentElement);
				var o_ = FHIRHelpers_4_0_001.ToInterval(EncounterDiabeticRetinopathy?.Period);
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
				var m_ = FHIRHelpers_4_0_001.ToDateTime(MacularEdemaPresentCommunicated?.SentElement);
				var n_ = FHIRHelpers_4_0_001.ToInterval(EncounterDiabeticRetinopathy?.Period);
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
