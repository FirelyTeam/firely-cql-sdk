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
		var a_ = context.Operators;
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Patient>(null, null);
		var d_ = a_.SingleOrNull<Patient>(c_);

		return d_;
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
		var a_ = context.Operators;
		var e_ = context.DataRetriever;
		var f_ = this.Office_Visit();
		var g_ = e_.RetrieveByValueSet<Encounter>(f_, null);
		var i_ = this.Ophthalmological_Services();
		var j_ = e_.RetrieveByValueSet<Encounter>(i_, null);
		var k_ = a_.ListUnion<Encounter>(g_, j_);
		var n_ = this.Outpatient_Consultation();
		var o_ = e_.RetrieveByValueSet<Encounter>(n_, null);
		var q_ = this.Care_Services_in_Long_Term_Residential_Facility();
		var r_ = e_.RetrieveByValueSet<Encounter>(q_, null);
		var s_ = a_.ListUnion<Encounter>(o_, r_);
		var t_ = a_.ListUnion<Encounter>(k_, s_);
		var v_ = this.Nursing_Facility_Visit();
		var w_ = e_.RetrieveByValueSet<Encounter>(v_, null);
		var x_ = a_.ListUnion<Encounter>(t_, w_);
		bool? y_(Encounter QualifyingEncounter)
		{
			var aa_ = context.Operators;
			var ac_ = this.Measurement_Period();
			var ad_ = QualifyingEncounter?.Period;
			var ae_ = FHIRHelpers_4_0_001.ToInterval(ad_);
			var af_ = aa_.IntervalIncludesInterval<CqlDateTime>(ac_, ae_, null);
			var ah_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var ai_ = ah_.Operators;
			var aj_ = ai_.TypeConverter;
			var ak_ = QualifyingEncounter?.StatusElement;
			var al_ = aj_.Convert<string>(ak_);
			var am_ = aa_.Equal(al_, "finished");
			var an_ = aa_.And(af_, am_);

			return an_;
		};
		var z_ = a_.WhereOrNull<Encounter>(x_, y_);

		return z_;
	}

    [CqlDeclaration("Qualifying Encounter During Measurement Period")]
	public IEnumerable<Encounter> Qualifying_Encounter_During_Measurement_Period() => 
		__Qualifying_Encounter_During_Measurement_Period.Value;

	private IEnumerable<Encounter> Diabetic_Retinopathy_Encounter_Value()
	{
		var a_ = context.Operators;
		var b_ = this.Qualifying_Encounter_During_Measurement_Period();
		IEnumerable<Encounter> c_(Encounter ValidQualifyingEncounter)
		{
			var e_ = context.Operators;
			var g_ = context.DataRetriever;
			var h_ = this.Diabetic_Retinopathy();
			var i_ = g_.RetrieveByValueSet<Condition>(h_, null);
			bool? j_(Condition DiabeticRetinopathy)
			{
				var n_ = context.Operators;
				var p_ = DiabeticRetinopathy?.ClinicalStatus;
				var q_ = FHIRHelpers_4_0_001.ToConcept(p_);
				var s_ = MATGlobalCommonFunctionsFHIR4_6_1_000.active();
				var t_ = n_.ConvertCodeToConcept(s_);
				var u_ = n_.Equivalent(q_, t_);
				var w_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(DiabeticRetinopathy);
				var x_ = ValidQualifyingEncounter?.Period;
				var y_ = FHIRHelpers_4_0_001.ToInterval(x_);
				var z_ = n_.Overlaps(w_, y_, null);
				var aa_ = n_.And(u_, z_);

				return aa_;
			};
			var k_ = e_.WhereOrNull<Condition>(i_, j_);
			Encounter l_(Condition DiabeticRetinopathy) => 
				ValidQualifyingEncounter;
			var m_ = e_.SelectOrNull<Condition, Encounter>(k_, l_);

			return m_;
		};
		var d_ = a_.SelectManyOrNull<Encounter, Encounter>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Diabetic Retinopathy Encounter")]
	public IEnumerable<Encounter> Diabetic_Retinopathy_Encounter() => 
		__Diabetic_Retinopathy_Encounter.Value;

    [CqlDeclaration("GetModifierExtensions")]
	public IEnumerable<Extension> GetModifierExtensions(DomainResource domainResource, string url)
	{
		var a_ = context.Operators;
		var c_ = domainResource?.ModifierExtension;
		bool? d_(Extension E)
		{
			var h_ = context.Operators;
			var i_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var j_ = i_.Operators;
			var k_ = j_.TypeConverter;
			var m_ = h_.TypeConverter;
			var n_ = E?.Url;
			var o_ = m_.Convert<FhirUri>(n_);
			var p_ = k_.Convert<string>(o_);
			var r_ = h_.Concatenate("http://hl7.org/fhir/us/qicore/StructureDefinition/", url);
			var s_ = h_.Equal(p_, r_);

			return s_;
		};
		var e_ = a_.WhereOrNull<Extension>((c_ as IEnumerable<Extension>), d_);
		Extension f_(Extension E) => 
			E;
		var g_ = a_.SelectOrNull<Extension, Extension>(e_, f_);

		return g_;
	}

    [CqlDeclaration("GetModifierExtension")]
	public Extension GetModifierExtension(DomainResource domainResource, string url)
	{
		var a_ = context.Operators;
		var b_ = this.GetModifierExtensions(domainResource, url);
		var c_ = a_.SingleOrNull<Extension>(b_);

		return c_;
	}

	private IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy_Value()
	{
		var a_ = context.Operators;
		var c_ = context.DataRetriever;
		var d_ = this.Level_of_Severity_of_Retinopathy_Findings();
		var e_ = typeof(Communication).GetProperty("ReasonCode");
		var f_ = c_.RetrieveByValueSet<Communication>(d_, e_);
		IEnumerable<Communication> g_(Communication LevelOfSeverityNotCommunicated)
		{
			var k_ = context.Operators;
			var m_ = this.Diabetic_Retinopathy_Encounter();
			bool? n_(Encounter EncounterDiabeticRetinopathy)
			{
				var r_ = context.Operators;
				var s_ = EncounterDiabeticRetinopathy?.Period;
				var t_ = FHIRHelpers_4_0_001.ToInterval(s_);
				var u_ = MATGlobalCommonFunctionsFHIR4_6_1_000.GetExtension((DomainResource)LevelOfSeverityNotCommunicated, "qicore-recorded");
				var v_ = u_?.Value;
				var w_ = FHIRHelpers_4_0_001.ToInterval((v_ as Period));
				var x_ = r_.IntervalIncludesInterval<CqlDateTime>(t_, w_, null);

				return x_;
			};
			var o_ = k_.WhereOrNull<Encounter>(m_, n_);
			Communication p_(Encounter EncounterDiabeticRetinopathy) => 
				LevelOfSeverityNotCommunicated;
			var q_ = k_.SelectOrNull<Encounter, Communication>(o_, p_);

			return q_;
		};
		var h_ = a_.SelectManyOrNull<Communication, Communication>(f_, g_);
		bool? i_(Communication LevelOfSeverityNotCommunicated)
		{
			var y_ = context.Operators;
			var ab_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var ac_ = ab_.Operators;
			var ad_ = ac_.TypeConverter;
			var ae_ = LevelOfSeverityNotCommunicated?.StatusElement;
			var af_ = ad_.Convert<string>(ae_);
			var ag_ = y_.Equal(af_, "not-done");
			var ai_ = this.GetModifierExtension(LevelOfSeverityNotCommunicated, "qicore-notDone");
			var aj_ = ai_?.Value;
			var ak_ = FHIRHelpers_4_0_001.ToBoolean((aj_ as FhirBoolean));
			var al_ = y_.IsTrue(ak_);
			var am_ = y_.And(ag_, al_);
			var ap_ = LevelOfSeverityNotCommunicated?.StatusReason;
			var aq_ = FHIRHelpers_4_0_001.ToConcept(ap_);
			var ar_ = this.Medical_Reason();
			var as_ = y_.ConceptInValueSet(aq_, ar_);
			var av_ = FHIRHelpers_4_0_001.ToConcept(ap_);
			var aw_ = this.Patient_Reason();
			var ax_ = y_.ConceptInValueSet(av_, aw_);
			var ay_ = y_.Or(as_, ax_);
			var az_ = y_.And(am_, ay_);

			return az_;
		};
		var j_ = a_.WhereOrNull<Communication>(h_, i_);

		return j_;
	}

    [CqlDeclaration("Medical or Patient Reason for Not Communicating Level of Severity of Retinopathy")]
	public IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy() => 
		__Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy.Value;

	private IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema_Value()
	{
		var a_ = context.Operators;
		var c_ = context.DataRetriever;
		var e_ = this.Macular_edema_absent__situation_();
		var f_ = a_.ToList<CqlCode>(e_);
		var g_ = typeof(Communication).GetProperty("ReasonCode");
		var h_ = c_.RetrieveByCodes<Communication>(f_, g_);
		IEnumerable<Communication> i_(Communication MacularEdemaAbsentNotCommunicated)
		{
			var m_ = context.Operators;
			var o_ = this.Diabetic_Retinopathy_Encounter();
			bool? p_(Encounter EncounterDiabeticRetinopathy)
			{
				var t_ = context.Operators;
				var u_ = EncounterDiabeticRetinopathy?.Period;
				var v_ = FHIRHelpers_4_0_001.ToInterval(u_);
				var w_ = MATGlobalCommonFunctionsFHIR4_6_1_000.GetExtension((DomainResource)MacularEdemaAbsentNotCommunicated, "qicore-recorded");
				var x_ = w_?.Value;
				var y_ = FHIRHelpers_4_0_001.ToInterval((x_ as Period));
				var z_ = t_.IntervalIncludesInterval<CqlDateTime>(v_, y_, null);

				return z_;
			};
			var q_ = m_.WhereOrNull<Encounter>(o_, p_);
			Communication r_(Encounter EncounterDiabeticRetinopathy) => 
				MacularEdemaAbsentNotCommunicated;
			var s_ = m_.SelectOrNull<Encounter, Communication>(q_, r_);

			return s_;
		};
		var j_ = a_.SelectManyOrNull<Communication, Communication>(h_, i_);
		bool? k_(Communication MacularEdemaAbsentNotCommunicated)
		{
			var aa_ = context.Operators;
			var ad_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var ae_ = ad_.Operators;
			var af_ = ae_.TypeConverter;
			var ag_ = MacularEdemaAbsentNotCommunicated?.StatusElement;
			var ah_ = af_.Convert<string>(ag_);
			var ai_ = aa_.Equal(ah_, "not-done");
			var ak_ = this.GetModifierExtension(MacularEdemaAbsentNotCommunicated, "qicore-notDone");
			var al_ = ak_?.Value;
			var am_ = FHIRHelpers_4_0_001.ToBoolean((al_ as FhirBoolean));
			var an_ = aa_.IsTrue(am_);
			var ao_ = aa_.And(ai_, an_);
			var ar_ = MacularEdemaAbsentNotCommunicated?.StatusReason;
			var as_ = FHIRHelpers_4_0_001.ToConcept(ar_);
			var at_ = this.Medical_Reason();
			var au_ = aa_.ConceptInValueSet(as_, at_);
			var ax_ = FHIRHelpers_4_0_001.ToConcept(ar_);
			var ay_ = this.Patient_Reason();
			var az_ = aa_.ConceptInValueSet(ax_, ay_);
			var ba_ = aa_.Or(au_, az_);
			var bb_ = aa_.And(ao_, ba_);

			return bb_;
		};
		var l_ = a_.WhereOrNull<Communication>(j_, k_);

		return l_;
	}

    [CqlDeclaration("Medical or Patient Reason for Not Communicating Absence of Macular Edema")]
	public IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema() => 
		__Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema.Value;

	private IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Presence_of_Macular_Edema_Value()
	{
		var a_ = context.Operators;
		var c_ = context.DataRetriever;
		var d_ = this.Macular_Edema_Findings_Present();
		var e_ = typeof(Communication).GetProperty("ReasonCode");
		var f_ = c_.RetrieveByValueSet<Communication>(d_, e_);
		IEnumerable<Communication> g_(Communication MacularEdemaPresentNotCommunicated)
		{
			var k_ = context.Operators;
			var m_ = this.Diabetic_Retinopathy_Encounter();
			bool? n_(Encounter EncounterDiabeticRetinopathy)
			{
				var r_ = context.Operators;
				var s_ = EncounterDiabeticRetinopathy?.Period;
				var t_ = FHIRHelpers_4_0_001.ToInterval(s_);
				var u_ = MATGlobalCommonFunctionsFHIR4_6_1_000.GetExtension((DomainResource)MacularEdemaPresentNotCommunicated, "qicore-recorded");
				var v_ = u_?.Value;
				var w_ = FHIRHelpers_4_0_001.ToInterval((v_ as Period));
				var x_ = r_.IntervalIncludesInterval<CqlDateTime>(t_, w_, null);

				return x_;
			};
			var o_ = k_.WhereOrNull<Encounter>(m_, n_);
			Communication p_(Encounter EncounterDiabeticRetinopathy) => 
				MacularEdemaPresentNotCommunicated;
			var q_ = k_.SelectOrNull<Encounter, Communication>(o_, p_);

			return q_;
		};
		var h_ = a_.SelectManyOrNull<Communication, Communication>(f_, g_);
		bool? i_(Communication MacularEdemaPresentNotCommunicated)
		{
			var y_ = context.Operators;
			var ab_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var ac_ = ab_.Operators;
			var ad_ = ac_.TypeConverter;
			var ae_ = MacularEdemaPresentNotCommunicated?.StatusElement;
			var af_ = ad_.Convert<string>(ae_);
			var ag_ = y_.Equal(af_, "not-done");
			var ai_ = this.GetModifierExtension(MacularEdemaPresentNotCommunicated, "qicore-notDone");
			var aj_ = ai_?.Value;
			var ak_ = FHIRHelpers_4_0_001.ToBoolean((aj_ as FhirBoolean));
			var al_ = y_.IsTrue(ak_);
			var am_ = y_.And(ag_, al_);
			var ap_ = MacularEdemaPresentNotCommunicated?.StatusReason;
			var aq_ = FHIRHelpers_4_0_001.ToConcept(ap_);
			var ar_ = this.Medical_Reason();
			var as_ = y_.ConceptInValueSet(aq_, ar_);
			var av_ = FHIRHelpers_4_0_001.ToConcept(ap_);
			var aw_ = this.Patient_Reason();
			var ax_ = y_.ConceptInValueSet(av_, aw_);
			var ay_ = y_.Or(as_, ax_);
			var az_ = y_.And(am_, ay_);

			return az_;
		};
		var j_ = a_.WhereOrNull<Communication>(h_, i_);

		return j_;
	}

    [CqlDeclaration("Medical or Patient Reason for Not Communicating Presence of Macular Edema")]
	public IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Presence_of_Macular_Edema() => 
		__Medical_or_Patient_Reason_for_Not_Communicating_Presence_of_Macular_Edema.Value;

	private bool? Denominator_Exceptions_Value()
	{
		var a_ = context.Operators;
		var d_ = this.Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy();
		var e_ = a_.ExistsInList<Communication>(d_);
		var g_ = this.Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema();
		var h_ = a_.ExistsInList<Communication>(g_);
		var i_ = a_.Or(e_, h_);
		var k_ = this.Medical_or_Patient_Reason_for_Not_Communicating_Presence_of_Macular_Edema();
		var l_ = a_.ExistsInList<Communication>(k_);
		var m_ = a_.Or(i_, l_);

		return m_;
	}

    [CqlDeclaration("Denominator Exceptions")]
	public bool? Denominator_Exceptions() => 
		__Denominator_Exceptions.Value;

	private bool? Initial_Population_Value()
	{
		var a_ = context.Operators;
		var e_ = this.Patient();
		var f_ = e_?.BirthDateElement;
		var g_ = f_?.Value;
		var h_ = a_.ConvertStringToDateTime(g_);
		var j_ = this.Measurement_Period();
		var k_ = a_.Start(j_);
		var l_ = a_.CalculateAgeAt(h_, k_, "year");
		var m_ = a_.GreaterOrEqual(l_, (int?)18);
		var o_ = this.Diabetic_Retinopathy_Encounter();
		var p_ = a_.ExistsInList<Encounter>(o_);
		var q_ = a_.And(m_, p_);

		return q_;
	}

    [CqlDeclaration("Initial Population")]
	public bool? Initial_Population() => 
		__Initial_Population.Value;

	private IEnumerable<Observation> Macular_Exam_Performed_Value()
	{
		var a_ = context.Operators;
		var c_ = context.DataRetriever;
		var d_ = this.Macular_Exam();
		var e_ = c_.RetrieveByValueSet<Observation>(d_, null);
		IEnumerable<Observation> f_(Observation MacularExam)
		{
			var j_ = context.Operators;
			var l_ = this.Diabetic_Retinopathy_Encounter();
			bool? m_(Encounter EncounterDiabeticRetinopathy)
			{
				var q_ = context.Operators;
				var r_ = EncounterDiabeticRetinopathy?.Period;
				var s_ = FHIRHelpers_4_0_001.ToInterval(r_);
				var t_ = MacularExam?.Effective;
				var u_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(t_);
				var v_ = q_.IntervalIncludesInterval<CqlDateTime>(s_, u_, null);

				return v_;
			};
			var n_ = j_.WhereOrNull<Encounter>(l_, m_);
			Observation o_(Encounter EncounterDiabeticRetinopathy) => 
				MacularExam;
			var p_ = j_.SelectOrNull<Encounter, Observation>(n_, o_);

			return p_;
		};
		var g_ = a_.SelectManyOrNull<Observation, Observation>(e_, f_);
		bool? h_(Observation MacularExam)
		{
			var w_ = context.Operators;
			var y_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var z_ = y_.Operators;
			var aa_ = z_.TypeConverter;
			var ab_ = MacularExam?.StatusElement;
			var ac_ = aa_.Convert<string>(ab_);
			var ad_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var ae_ = w_.InList<string>(ac_, (ad_ as IEnumerable<string>));
			var ag_ = MacularExam?.Value;
			var ah_ = w_.Not((bool?)(ag_ is null));
			var ai_ = w_.And(ae_, ah_);

			return ai_;
		};
		var i_ = a_.WhereOrNull<Observation>(g_, h_);

		return i_;
	}

    [CqlDeclaration("Macular Exam Performed")]
	public IEnumerable<Observation> Macular_Exam_Performed() => 
		__Macular_Exam_Performed.Value;

	private bool? Denominator_Value()
	{
		var a_ = context.Operators;
		var b_ = this.Initial_Population();
		var d_ = this.Macular_Exam_Performed();
		var e_ = a_.ExistsInList<Observation>(d_);
		var f_ = a_.And(b_, e_);

		return f_;
	}

    [CqlDeclaration("Denominator")]
	public bool? Denominator() => 
		__Denominator.Value;

	private IEnumerable<Communication> Level_of_Severity_of_Retinopathy_Findings_Communicated_Value()
	{
		var a_ = context.Operators;
		var c_ = context.DataRetriever;
		var d_ = this.Level_of_Severity_of_Retinopathy_Findings();
		var e_ = typeof(Communication).GetProperty("ReasonCode");
		var f_ = c_.RetrieveByValueSet<Communication>(d_, e_);
		IEnumerable<Communication> g_(Communication LevelOfSeverityCommunicated)
		{
			var k_ = context.Operators;
			var m_ = this.Diabetic_Retinopathy_Encounter();
			bool? n_(Encounter EncounterDiabeticRetinopathy)
			{
				var r_ = context.Operators;
				var s_ = LevelOfSeverityCommunicated?.SentElement;
				var t_ = FHIRHelpers_4_0_001.ToDateTime(s_);
				var v_ = EncounterDiabeticRetinopathy?.Period;
				var w_ = FHIRHelpers_4_0_001.ToInterval(v_);
				var x_ = r_.Start(w_);
				var y_ = r_.After(t_, x_, null);

				return y_;
			};
			var o_ = k_.WhereOrNull<Encounter>(m_, n_);
			Communication p_(Encounter EncounterDiabeticRetinopathy) => 
				LevelOfSeverityCommunicated;
			var q_ = k_.SelectOrNull<Encounter, Communication>(o_, p_);

			return q_;
		};
		var h_ = a_.SelectManyOrNull<Communication, Communication>(f_, g_);
		bool? i_(Communication LevelOfSeverityCommunicated)
		{
			var z_ = context.Operators;
			var aa_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var ab_ = aa_.Operators;
			var ac_ = ab_.TypeConverter;
			var ad_ = LevelOfSeverityCommunicated?.StatusElement;
			var ae_ = ac_.Convert<string>(ad_);
			var af_ = z_.Equal(ae_, "completed");

			return af_;
		};
		var j_ = a_.WhereOrNull<Communication>(h_, i_);

		return j_;
	}

    [CqlDeclaration("Level of Severity of Retinopathy Findings Communicated")]
	public IEnumerable<Communication> Level_of_Severity_of_Retinopathy_Findings_Communicated() => 
		__Level_of_Severity_of_Retinopathy_Findings_Communicated.Value;

	private IEnumerable<Communication> Macular_Edema_Absence_Communicated_Value()
	{
		var a_ = context.Operators;
		var c_ = context.DataRetriever;
		var e_ = this.Macular_edema_absent__situation_();
		var f_ = a_.ToList<CqlCode>(e_);
		var g_ = typeof(Communication).GetProperty("ReasonCode");
		var h_ = c_.RetrieveByCodes<Communication>(f_, g_);
		IEnumerable<Communication> i_(Communication MacularEdemaAbsentCommunicated)
		{
			var m_ = context.Operators;
			var o_ = this.Diabetic_Retinopathy_Encounter();
			bool? p_(Encounter EncounterDiabeticRetinopathy)
			{
				var t_ = context.Operators;
				var u_ = MacularEdemaAbsentCommunicated?.SentElement;
				var v_ = FHIRHelpers_4_0_001.ToDateTime(u_);
				var x_ = EncounterDiabeticRetinopathy?.Period;
				var y_ = FHIRHelpers_4_0_001.ToInterval(x_);
				var z_ = t_.Start(y_);
				var aa_ = t_.After(v_, z_, null);

				return aa_;
			};
			var q_ = m_.WhereOrNull<Encounter>(o_, p_);
			Communication r_(Encounter EncounterDiabeticRetinopathy) => 
				MacularEdemaAbsentCommunicated;
			var s_ = m_.SelectOrNull<Encounter, Communication>(q_, r_);

			return s_;
		};
		var j_ = a_.SelectManyOrNull<Communication, Communication>(h_, i_);
		bool? k_(Communication MacularEdemaAbsentCommunicated)
		{
			var ab_ = context.Operators;
			var ac_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var ad_ = ac_.Operators;
			var ae_ = ad_.TypeConverter;
			var af_ = MacularEdemaAbsentCommunicated?.StatusElement;
			var ag_ = ae_.Convert<string>(af_);
			var ah_ = ab_.Equal(ag_, "completed");

			return ah_;
		};
		var l_ = a_.WhereOrNull<Communication>(j_, k_);

		return l_;
	}

    [CqlDeclaration("Macular Edema Absence Communicated")]
	public IEnumerable<Communication> Macular_Edema_Absence_Communicated() => 
		__Macular_Edema_Absence_Communicated.Value;

	private IEnumerable<Communication> Macular_Edema_Presence_Communicated_Value()
	{
		var a_ = context.Operators;
		var c_ = context.DataRetriever;
		var d_ = this.Macular_Edema_Findings_Present();
		var e_ = typeof(Communication).GetProperty("ReasonCode");
		var f_ = c_.RetrieveByValueSet<Communication>(d_, e_);
		IEnumerable<Communication> g_(Communication MacularEdemaPresentCommunicated)
		{
			var k_ = context.Operators;
			var m_ = this.Diabetic_Retinopathy_Encounter();
			bool? n_(Encounter EncounterDiabeticRetinopathy)
			{
				var r_ = context.Operators;
				var s_ = MacularEdemaPresentCommunicated?.SentElement;
				var t_ = FHIRHelpers_4_0_001.ToDateTime(s_);
				var v_ = EncounterDiabeticRetinopathy?.Period;
				var w_ = FHIRHelpers_4_0_001.ToInterval(v_);
				var x_ = r_.Start(w_);
				var y_ = r_.After(t_, x_, null);

				return y_;
			};
			var o_ = k_.WhereOrNull<Encounter>(m_, n_);
			Communication p_(Encounter EncounterDiabeticRetinopathy) => 
				MacularEdemaPresentCommunicated;
			var q_ = k_.SelectOrNull<Encounter, Communication>(o_, p_);

			return q_;
		};
		var h_ = a_.SelectManyOrNull<Communication, Communication>(f_, g_);
		bool? i_(Communication MacularEdemaPresentCommunicated)
		{
			var z_ = context.Operators;
			var aa_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var ab_ = aa_.Operators;
			var ac_ = ab_.TypeConverter;
			var ad_ = MacularEdemaPresentCommunicated?.StatusElement;
			var ae_ = ac_.Convert<string>(ad_);
			var af_ = z_.Equal(ae_, "completed");

			return af_;
		};
		var j_ = a_.WhereOrNull<Communication>(h_, i_);

		return j_;
	}

    [CqlDeclaration("Macular Edema Presence Communicated")]
	public IEnumerable<Communication> Macular_Edema_Presence_Communicated() => 
		__Macular_Edema_Presence_Communicated.Value;

	private bool? Results_of_Dilated_Macular_or_Fundus_Exam_Communicated_Value()
	{
		var a_ = context.Operators;
		var c_ = this.Level_of_Severity_of_Retinopathy_Findings_Communicated();
		var d_ = a_.ExistsInList<Communication>(c_);
		var g_ = this.Macular_Edema_Absence_Communicated();
		var h_ = a_.ExistsInList<Communication>(g_);
		var j_ = this.Macular_Edema_Presence_Communicated();
		var k_ = a_.ExistsInList<Communication>(j_);
		var l_ = a_.Or(h_, k_);
		var m_ = a_.And(d_, l_);

		return m_;
	}

    [CqlDeclaration("Results of Dilated Macular or Fundus Exam Communicated")]
	public bool? Results_of_Dilated_Macular_or_Fundus_Exam_Communicated() => 
		__Results_of_Dilated_Macular_or_Fundus_Exam_Communicated.Value;

	private bool? Numerator_Value()
	{
		var a_ = context.Operators;
		var c_ = this.Level_of_Severity_of_Retinopathy_Findings_Communicated();
		var d_ = a_.ExistsInList<Communication>(c_);
		var g_ = this.Macular_Edema_Absence_Communicated();
		var h_ = a_.ExistsInList<Communication>(g_);
		var j_ = this.Macular_Edema_Presence_Communicated();
		var k_ = a_.ExistsInList<Communication>(j_);
		var l_ = a_.Or(h_, k_);
		var m_ = a_.And(d_, l_);

		return m_;
	}

    [CqlDeclaration("Numerator")]
	public bool? Numerator() => 
		__Numerator.Value;

}