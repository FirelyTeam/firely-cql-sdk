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
    public CqlValueSet Care_Services_in_Long_Term_Residential_Facility() => __Care_Services_in_Long_Term_Residential_Facility.Value;

    private CqlValueSet Diabetic_Retinopathy_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.327", null);

    [CqlDeclaration("Diabetic Retinopathy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.327")]
    public CqlValueSet Diabetic_Retinopathy() => __Diabetic_Retinopathy.Value;

    private CqlValueSet Level_of_Severity_of_Retinopathy_Findings_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1283", null);

    [CqlDeclaration("Level of Severity of Retinopathy Findings")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1283")]
    public CqlValueSet Level_of_Severity_of_Retinopathy_Findings() => __Level_of_Severity_of_Retinopathy_Findings.Value;

    private CqlValueSet Macular_Edema_Findings_Present_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1320", null);

    [CqlDeclaration("Macular Edema Findings Present")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1320")]
    public CqlValueSet Macular_Edema_Findings_Present() => __Macular_Edema_Findings_Present.Value;

    private CqlValueSet Macular_Exam_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1251", null);

    [CqlDeclaration("Macular Exam")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1251")]
    public CqlValueSet Macular_Exam() => __Macular_Exam.Value;

    private CqlValueSet Medical_Reason_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007", null);

    [CqlDeclaration("Medical Reason")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007")]
    public CqlValueSet Medical_Reason() => __Medical_Reason.Value;

    private CqlValueSet Nursing_Facility_Visit_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012", null);

    [CqlDeclaration("Nursing Facility Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012")]
    public CqlValueSet Nursing_Facility_Visit() => __Nursing_Facility_Visit.Value;

    private CqlValueSet Office_Visit_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
    public CqlValueSet Office_Visit() => __Office_Visit.Value;

    private CqlValueSet Ophthalmological_Services_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285", null);

    [CqlDeclaration("Ophthalmological Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285")]
    public CqlValueSet Ophthalmological_Services() => __Ophthalmological_Services.Value;

    private CqlValueSet Outpatient_Consultation_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", null);

    [CqlDeclaration("Outpatient Consultation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008")]
    public CqlValueSet Outpatient_Consultation() => __Outpatient_Consultation.Value;

    private CqlValueSet Patient_Reason_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1008", null);

    [CqlDeclaration("Patient Reason")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1008")]
    public CqlValueSet Patient_Reason() => __Patient_Reason.Value;

    private CqlCode Birth_date_Value()
	{
		var a_ = new CqlCode("21112-8", "http://loinc.org", null, null);

		return a_;
	}

    [CqlDeclaration("Birth date")]
    public CqlCode Birth_date() => __Birth_date.Value;

    private CqlCode Healthcare_professional__occupation__Value()
	{
		var a_ = new CqlCode("223366009", "http://snomed.info/sct", null, null);

		return a_;
	}

    [CqlDeclaration("Healthcare professional (occupation)")]
    public CqlCode Healthcare_professional__occupation_() => __Healthcare_professional__occupation_.Value;

    private CqlCode Macular_edema_absent__situation__Value()
	{
		var a_ = new CqlCode("428341000124108", "http://snomed.info/sct", null, null);

		return a_;
	}

    [CqlDeclaration("Macular edema absent (situation)")]
    public CqlCode Macular_edema_absent__situation_() => __Macular_edema_absent__situation_.Value;

    private CqlCode Medical_practitioner__occupation__Value()
	{
		var a_ = new CqlCode("158965000", "http://snomed.info/sct", null, null);

		return a_;
	}

    [CqlDeclaration("Medical practitioner (occupation)")]
    public CqlCode Medical_practitioner__occupation_() => __Medical_practitioner__occupation_.Value;

    private CqlCode Ophthalmologist__occupation__Value()
	{
		var a_ = new CqlCode("422234006", "http://snomed.info/sct", null, null);

		return a_;
	}

    [CqlDeclaration("Ophthalmologist (occupation)")]
    public CqlCode Ophthalmologist__occupation_() => __Ophthalmologist__occupation_.Value;

    private CqlCode Optometrist__occupation__Value()
	{
		var a_ = new CqlCode("28229004", "http://snomed.info/sct", null, null);

		return a_;
	}

    [CqlDeclaration("Optometrist (occupation)")]
    public CqlCode Optometrist__occupation_() => __Optometrist__occupation_.Value;

    private CqlCode Physician__occupation__Value()
	{
		var a_ = new CqlCode("309343006", "http://snomed.info/sct", null, null);

		return a_;
	}

    [CqlDeclaration("Physician (occupation)")]
    public CqlCode Physician__occupation_() => __Physician__occupation_.Value;

    private CqlCode[] LOINC_Value()
	{
		var a_ = new CqlCode("21112-8", "http://loinc.org", null, null);
		var b_ = new CqlCode[]
		{
			a_,
		};

		return b_;
	}

    [CqlDeclaration("LOINC")]
    public CqlCode[] LOINC() => __LOINC.Value;

    private CqlCode[] SNOMEDCT_Value()
	{
		var a_ = new CqlCode("223366009", "http://snomed.info/sct", null, null);
		var b_ = new CqlCode("428341000124108", "http://snomed.info/sct", null, null);
		var c_ = new CqlCode("158965000", "http://snomed.info/sct", null, null);
		var d_ = new CqlCode("422234006", "http://snomed.info/sct", null, null);
		var e_ = new CqlCode("28229004", "http://snomed.info/sct", null, null);
		var f_ = new CqlCode("309343006", "http://snomed.info/sct", null, null);
		var g_ = new CqlCode[]
		{
			a_,
			b_,
			c_,
			d_,
			e_,
			f_,
		};

		return g_;
	}

    [CqlDeclaration("SNOMEDCT")]
    public CqlCode[] SNOMEDCT() => __SNOMEDCT.Value;

    private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.ResolveParameter("DRCommunicationWithPhysicianManagingDiabetesFHIR-0.0.004", "Measurement Period", null);

		return (CqlInterval<CqlDateTime>)a_;
	}

    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period() => __Measurement_Period.Value;

    private Patient Patient_Value()
	{
		var a_ = context.DataRetriever;
		var b_ = a_.RetrieveByValueSet<Patient>(null, null);
		var c_ = context.Operators;
		var d_ = c_.SingleOrNull<Patient>(b_);

		return d_;
	}

    [CqlDeclaration("Patient")]
    public Patient Patient() => __Patient.Value;

    private IEnumerable<Coding> SDE_Ethnicity_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity() => __SDE_Ethnicity.Value;

    private IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
    public IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer() => __SDE_Payer.Value;

    private IEnumerable<Coding> SDE_Race_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
    public IEnumerable<Coding> SDE_Race() => __SDE_Race.Value;

    private CqlCode SDE_Sex_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Sex();

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
    public CqlCode SDE_Sex() => __SDE_Sex.Value;

    private IEnumerable<Encounter> Qualifying_Encounter_During_Measurement_Period_Value()
	{
		var a_ = this.Office_Visit();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Encounter>(a_, null);
		var d_ = this.Ophthalmological_Services();
		var f_ = b_.RetrieveByValueSet<Encounter>(d_, null);
		var g_ = context.Operators;
		var h_ = g_.ListUnion<Encounter>(c_, f_);
		var i_ = this.Outpatient_Consultation();
		var k_ = b_.RetrieveByValueSet<Encounter>(i_, null);
		var l_ = this.Care_Services_in_Long_Term_Residential_Facility();
		var n_ = b_.RetrieveByValueSet<Encounter>(l_, null);
		var p_ = g_.ListUnion<Encounter>(k_, n_);
		var r_ = g_.ListUnion<Encounter>(h_, p_);
		var s_ = this.Nursing_Facility_Visit();
		var u_ = b_.RetrieveByValueSet<Encounter>(s_, null);
		var w_ = g_.ListUnion<Encounter>(r_, u_);
		bool? x_(Encounter QualifyingEncounter)
		{
			var aa_ = this.Measurement_Period();
			var ab_ = QualifyingEncounter?.Period;
			var ac_ = FHIRHelpers_4_0_001.ToInterval(ab_);
			var ad_ = context.Operators;
			var ae_ = ad_.IntervalIncludesInterval<CqlDateTime>(aa_, ac_, null);
			var af_ = QualifyingEncounter?.StatusElement;
			var ag_ = new CallStackEntry("ToString", null, null);
			var ah_ = context.Deeper(ag_);
			var ai_ = ah_.Operators;
			var aj_ = ai_.TypeConverter;
			var ak_ = aj_.Convert<string>(af_);
			var am_ = ad_.Equal(ak_, "finished");
			var ao_ = ad_.And(ae_, am_);

			return ao_;
		};
		var z_ = g_.WhereOrNull<Encounter>(w_, x_);

		return z_;
	}

    [CqlDeclaration("Qualifying Encounter During Measurement Period")]
    public IEnumerable<Encounter> Qualifying_Encounter_During_Measurement_Period() => __Qualifying_Encounter_During_Measurement_Period.Value;

    private IEnumerable<Encounter> Diabetic_Retinopathy_Encounter_Value()
	{
		var a_ = this.Qualifying_Encounter_During_Measurement_Period();
		IEnumerable<Encounter> b_(Encounter ValidQualifyingEncounter)
		{
			var e_ = this.Diabetic_Retinopathy();
			var f_ = context.DataRetriever;
			var g_ = f_.RetrieveByValueSet<Condition>(e_, null);
			bool? h_(Condition DiabeticRetinopathy)
			{
				var n_ = DiabeticRetinopathy?.ClinicalStatus;
				var o_ = FHIRHelpers_4_0_001.ToConcept(n_);
				var p_ = MATGlobalCommonFunctionsFHIR4_6_1_000.active();
				var q_ = context.Operators;
				var r_ = q_.ConvertCodeToConcept(p_);
				var t_ = q_.Equivalent(o_, r_);
				var u_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(DiabeticRetinopathy);
				var v_ = ValidQualifyingEncounter?.Period;
				var w_ = FHIRHelpers_4_0_001.ToInterval(v_);
				var y_ = q_.Overlaps(u_, w_, null);
				var aa_ = q_.And(t_, y_);

				return aa_;
			};
			var i_ = context.Operators;
			var j_ = i_.WhereOrNull<Condition>(g_, h_);
			Encounter k_(Condition DiabeticRetinopathy) => ValidQualifyingEncounter;
			var m_ = i_.SelectOrNull<Condition, Encounter>(j_, k_);

			return m_;
		};
		var c_ = context.Operators;
		var d_ = c_.SelectManyOrNull<Encounter, Encounter>(a_, b_);

		return d_;
	}

    [CqlDeclaration("Diabetic Retinopathy Encounter")]
    public IEnumerable<Encounter> Diabetic_Retinopathy_Encounter() => __Diabetic_Retinopathy_Encounter.Value;

    [CqlDeclaration("GetModifierExtensions")]
    public IEnumerable<Extension> GetModifierExtensions(DomainResource domainResource, string url)
	{
		var a_ = domainResource?.ModifierExtension;
		bool? b_(Extension E)
		{
			var h_ = E?.Url;
			var i_ = context.Operators;
			var j_ = i_.TypeConverter;
			var k_ = j_.Convert<FhirUri>(h_);
			var l_ = new CallStackEntry("ToString", null, null);
			var m_ = context.Deeper(l_);
			var n_ = m_.Operators;
			var o_ = n_.TypeConverter;
			var p_ = o_.Convert<string>(k_);
			var r_ = i_.Concatenate("http://hl7.org/fhir/us/qicore/StructureDefinition/", url);
			var t_ = i_.Equal(p_, r_);

			return t_;
		};
		var c_ = context.Operators;
		var d_ = c_.WhereOrNull<Extension>((a_ as IEnumerable<Extension>), b_);
		Extension e_(Extension E) => E;
		var g_ = c_.SelectOrNull<Extension, Extension>(d_, e_);

		return g_;
	}


    [CqlDeclaration("GetModifierExtension")]
    public Extension GetModifierExtension(DomainResource domainResource, string url)
	{
		var a_ = this.GetModifierExtensions(domainResource, url);
		var b_ = context.Operators;
		var c_ = b_.SingleOrNull<Extension>(a_);

		return c_;
	}


    private IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy_Value()
	{
		var a_ = this.Level_of_Severity_of_Retinopathy_Findings();
		var b_ = typeof(Communication).GetProperty("ReasonCode");
		var c_ = context.DataRetriever;
		var d_ = c_.RetrieveByValueSet<Communication>(a_, b_);
		IEnumerable<Communication> e_(Communication LevelOfSeverityNotCommunicated)
		{
			var k_ = this.Diabetic_Retinopathy_Encounter();
			bool? l_(Encounter EncounterDiabeticRetinopathy)
			{
				var r_ = EncounterDiabeticRetinopathy?.Period;
				var s_ = FHIRHelpers_4_0_001.ToInterval(r_);
				var t_ = MATGlobalCommonFunctionsFHIR4_6_1_000.GetExtension((DomainResource)LevelOfSeverityNotCommunicated, "qicore-recorded");
				var u_ = t_?.Value;
				var v_ = FHIRHelpers_4_0_001.ToInterval((u_ as Period));
				var w_ = context.Operators;
				var x_ = w_.IntervalIncludesInterval<CqlDateTime>(s_, v_, null);

				return x_;
			};
			var m_ = context.Operators;
			var n_ = m_.WhereOrNull<Encounter>(k_, l_);
			Communication o_(Encounter EncounterDiabeticRetinopathy) => LevelOfSeverityNotCommunicated;
			var q_ = m_.SelectOrNull<Encounter, Communication>(n_, o_);

			return q_;
		};
		var f_ = context.Operators;
		var g_ = f_.SelectManyOrNull<Communication, Communication>(d_, e_);
		bool? h_(Communication LevelOfSeverityNotCommunicated)
		{
			var y_ = LevelOfSeverityNotCommunicated?.StatusElement;
			var z_ = new CallStackEntry("ToString", null, null);
			var aa_ = context.Deeper(z_);
			var ab_ = aa_.Operators;
			var ac_ = ab_.TypeConverter;
			var ad_ = ac_.Convert<string>(y_);
			var ae_ = context.Operators;
			var af_ = ae_.Equal(ad_, "not-done");
			var ag_ = this.GetModifierExtension(LevelOfSeverityNotCommunicated, "qicore-notDone");
			var ah_ = ag_?.Value;
			var ai_ = FHIRHelpers_4_0_001.ToBoolean((ah_ as FhirBoolean));
			var ak_ = ae_.IsTrue(ai_);
			var am_ = ae_.And(af_, ak_);
			var an_ = LevelOfSeverityNotCommunicated?.StatusReason;
			var ao_ = FHIRHelpers_4_0_001.ToConcept(an_);
			var ap_ = this.Medical_Reason();
			var ar_ = ae_.ConceptInValueSet(ao_, ap_);
			var at_ = FHIRHelpers_4_0_001.ToConcept(an_);
			var au_ = this.Patient_Reason();
			var aw_ = ae_.ConceptInValueSet(at_, au_);
			var ay_ = ae_.Or(ar_, aw_);
			var ba_ = ae_.And(am_, ay_);

			return ba_;
		};
		var j_ = f_.WhereOrNull<Communication>(g_, h_);

		return j_;
	}

    [CqlDeclaration("Medical or Patient Reason for Not Communicating Level of Severity of Retinopathy")]
    public IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy() => __Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy.Value;

    private IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema_Value()
	{
		var a_ = this.Macular_edema_absent__situation_();
		var b_ = context.Operators;
		var c_ = b_.ToList<CqlCode>(a_);
		var d_ = typeof(Communication).GetProperty("ReasonCode");
		var e_ = context.DataRetriever;
		var f_ = e_.RetrieveByCodes<Communication>(c_, d_);
		IEnumerable<Communication> g_(Communication MacularEdemaAbsentNotCommunicated)
		{
			var m_ = this.Diabetic_Retinopathy_Encounter();
			bool? n_(Encounter EncounterDiabeticRetinopathy)
			{
				var t_ = EncounterDiabeticRetinopathy?.Period;
				var u_ = FHIRHelpers_4_0_001.ToInterval(t_);
				var v_ = MATGlobalCommonFunctionsFHIR4_6_1_000.GetExtension((DomainResource)MacularEdemaAbsentNotCommunicated, "qicore-recorded");
				var w_ = v_?.Value;
				var x_ = FHIRHelpers_4_0_001.ToInterval((w_ as Period));
				var y_ = context.Operators;
				var z_ = y_.IntervalIncludesInterval<CqlDateTime>(u_, x_, null);

				return z_;
			};
			var o_ = context.Operators;
			var p_ = o_.WhereOrNull<Encounter>(m_, n_);
			Communication q_(Encounter EncounterDiabeticRetinopathy) => MacularEdemaAbsentNotCommunicated;
			var s_ = o_.SelectOrNull<Encounter, Communication>(p_, q_);

			return s_;
		};
		var i_ = b_.SelectManyOrNull<Communication, Communication>(f_, g_);
		bool? j_(Communication MacularEdemaAbsentNotCommunicated)
		{
			var aa_ = MacularEdemaAbsentNotCommunicated?.StatusElement;
			var ab_ = new CallStackEntry("ToString", null, null);
			var ac_ = context.Deeper(ab_);
			var ad_ = ac_.Operators;
			var ae_ = ad_.TypeConverter;
			var af_ = ae_.Convert<string>(aa_);
			var ag_ = context.Operators;
			var ah_ = ag_.Equal(af_, "not-done");
			var ai_ = this.GetModifierExtension(MacularEdemaAbsentNotCommunicated, "qicore-notDone");
			var aj_ = ai_?.Value;
			var ak_ = FHIRHelpers_4_0_001.ToBoolean((aj_ as FhirBoolean));
			var am_ = ag_.IsTrue(ak_);
			var ao_ = ag_.And(ah_, am_);
			var ap_ = MacularEdemaAbsentNotCommunicated?.StatusReason;
			var aq_ = FHIRHelpers_4_0_001.ToConcept(ap_);
			var ar_ = this.Medical_Reason();
			var at_ = ag_.ConceptInValueSet(aq_, ar_);
			var av_ = FHIRHelpers_4_0_001.ToConcept(ap_);
			var aw_ = this.Patient_Reason();
			var ay_ = ag_.ConceptInValueSet(av_, aw_);
			var ba_ = ag_.Or(at_, ay_);
			var bc_ = ag_.And(ao_, ba_);

			return bc_;
		};
		var l_ = b_.WhereOrNull<Communication>(i_, j_);

		return l_;
	}

    [CqlDeclaration("Medical or Patient Reason for Not Communicating Absence of Macular Edema")]
    public IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema() => __Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema.Value;

    private IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Presence_of_Macular_Edema_Value()
	{
		var a_ = this.Macular_Edema_Findings_Present();
		var b_ = typeof(Communication).GetProperty("ReasonCode");
		var c_ = context.DataRetriever;
		var d_ = c_.RetrieveByValueSet<Communication>(a_, b_);
		IEnumerable<Communication> e_(Communication MacularEdemaPresentNotCommunicated)
		{
			var k_ = this.Diabetic_Retinopathy_Encounter();
			bool? l_(Encounter EncounterDiabeticRetinopathy)
			{
				var r_ = EncounterDiabeticRetinopathy?.Period;
				var s_ = FHIRHelpers_4_0_001.ToInterval(r_);
				var t_ = MATGlobalCommonFunctionsFHIR4_6_1_000.GetExtension((DomainResource)MacularEdemaPresentNotCommunicated, "qicore-recorded");
				var u_ = t_?.Value;
				var v_ = FHIRHelpers_4_0_001.ToInterval((u_ as Period));
				var w_ = context.Operators;
				var x_ = w_.IntervalIncludesInterval<CqlDateTime>(s_, v_, null);

				return x_;
			};
			var m_ = context.Operators;
			var n_ = m_.WhereOrNull<Encounter>(k_, l_);
			Communication o_(Encounter EncounterDiabeticRetinopathy) => MacularEdemaPresentNotCommunicated;
			var q_ = m_.SelectOrNull<Encounter, Communication>(n_, o_);

			return q_;
		};
		var f_ = context.Operators;
		var g_ = f_.SelectManyOrNull<Communication, Communication>(d_, e_);
		bool? h_(Communication MacularEdemaPresentNotCommunicated)
		{
			var y_ = MacularEdemaPresentNotCommunicated?.StatusElement;
			var z_ = new CallStackEntry("ToString", null, null);
			var aa_ = context.Deeper(z_);
			var ab_ = aa_.Operators;
			var ac_ = ab_.TypeConverter;
			var ad_ = ac_.Convert<string>(y_);
			var ae_ = context.Operators;
			var af_ = ae_.Equal(ad_, "not-done");
			var ag_ = this.GetModifierExtension(MacularEdemaPresentNotCommunicated, "qicore-notDone");
			var ah_ = ag_?.Value;
			var ai_ = FHIRHelpers_4_0_001.ToBoolean((ah_ as FhirBoolean));
			var ak_ = ae_.IsTrue(ai_);
			var am_ = ae_.And(af_, ak_);
			var an_ = MacularEdemaPresentNotCommunicated?.StatusReason;
			var ao_ = FHIRHelpers_4_0_001.ToConcept(an_);
			var ap_ = this.Medical_Reason();
			var ar_ = ae_.ConceptInValueSet(ao_, ap_);
			var at_ = FHIRHelpers_4_0_001.ToConcept(an_);
			var au_ = this.Patient_Reason();
			var aw_ = ae_.ConceptInValueSet(at_, au_);
			var ay_ = ae_.Or(ar_, aw_);
			var ba_ = ae_.And(am_, ay_);

			return ba_;
		};
		var j_ = f_.WhereOrNull<Communication>(g_, h_);

		return j_;
	}

    [CqlDeclaration("Medical or Patient Reason for Not Communicating Presence of Macular Edema")]
    public IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Presence_of_Macular_Edema() => __Medical_or_Patient_Reason_for_Not_Communicating_Presence_of_Macular_Edema.Value;

    private bool? Denominator_Exceptions_Value()
	{
		var a_ = this.Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy();
		var b_ = context.Operators;
		var c_ = b_.ExistsInList<Communication>(a_);
		var d_ = this.Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema();
		var f_ = b_.ExistsInList<Communication>(d_);
		var h_ = b_.Or(c_, f_);
		var i_ = this.Medical_or_Patient_Reason_for_Not_Communicating_Presence_of_Macular_Edema();
		var k_ = b_.ExistsInList<Communication>(i_);
		var m_ = b_.Or(h_, k_);

		return m_;
	}

    [CqlDeclaration("Denominator Exceptions")]
    public bool? Denominator_Exceptions() => __Denominator_Exceptions.Value;

    private bool? Initial_Population_Value()
	{
		var a_ = this.Patient();
		var b_ = a_?.BirthDateElement;
		var c_ = b_?.Value;
		var d_ = context.Operators;
		var e_ = d_.ConvertStringToDateTime(c_);
		var f_ = this.Measurement_Period();
		var h_ = d_.Start(f_);
		var j_ = d_.CalculateAgeAt(e_, h_, "year");
		var l_ = d_.GreaterOrEqual(j_, (int?)18);
		var m_ = this.Diabetic_Retinopathy_Encounter();
		var o_ = d_.ExistsInList<Encounter>(m_);
		var q_ = d_.And(l_, o_);

		return q_;
	}

    [CqlDeclaration("Initial Population")]
    public bool? Initial_Population() => __Initial_Population.Value;

    private IEnumerable<Observation> Macular_Exam_Performed_Value()
	{
		var a_ = this.Macular_Exam();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Observation>(a_, null);
		IEnumerable<Observation> d_(Observation MacularExam)
		{
			var j_ = this.Diabetic_Retinopathy_Encounter();
			bool? k_(Encounter EncounterDiabeticRetinopathy)
			{
				var q_ = EncounterDiabeticRetinopathy?.Period;
				var r_ = FHIRHelpers_4_0_001.ToInterval(q_);
				var s_ = MacularExam?.Effective;
				var t_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(s_);
				var u_ = context.Operators;
				var v_ = u_.IntervalIncludesInterval<CqlDateTime>(r_, t_, null);

				return v_;
			};
			var l_ = context.Operators;
			var m_ = l_.WhereOrNull<Encounter>(j_, k_);
			Observation n_(Encounter EncounterDiabeticRetinopathy) => MacularExam;
			var p_ = l_.SelectOrNull<Encounter, Observation>(m_, n_);

			return p_;
		};
		var e_ = context.Operators;
		var f_ = e_.SelectManyOrNull<Observation, Observation>(c_, d_);
		bool? g_(Observation MacularExam)
		{
			var w_ = MacularExam?.StatusElement;
			var x_ = new CallStackEntry("ToString", null, null);
			var y_ = context.Deeper(x_);
			var z_ = y_.Operators;
			var aa_ = z_.TypeConverter;
			var ab_ = aa_.Convert<string>(w_);
			var ac_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var ad_ = context.Operators;
			var ae_ = ad_.InList<string>(ab_, (ac_ as IEnumerable<string>));
			var af_ = MacularExam?.Value;
			var ah_ = ad_.Not((bool?)(af_ is null));
			var aj_ = ad_.And(ae_, ah_);

			return aj_;
		};
		var i_ = e_.WhereOrNull<Observation>(f_, g_);

		return i_;
	}

    [CqlDeclaration("Macular Exam Performed")]
    public IEnumerable<Observation> Macular_Exam_Performed() => __Macular_Exam_Performed.Value;

    private bool? Denominator_Value()
	{
		var a_ = this.Initial_Population();
		var b_ = this.Macular_Exam_Performed();
		var c_ = context.Operators;
		var d_ = c_.ExistsInList<Observation>(b_);
		var f_ = c_.And(a_, d_);

		return f_;
	}

    [CqlDeclaration("Denominator")]
    public bool? Denominator() => __Denominator.Value;

    private IEnumerable<Communication> Level_of_Severity_of_Retinopathy_Findings_Communicated_Value()
	{
		var a_ = this.Level_of_Severity_of_Retinopathy_Findings();
		var b_ = typeof(Communication).GetProperty("ReasonCode");
		var c_ = context.DataRetriever;
		var d_ = c_.RetrieveByValueSet<Communication>(a_, b_);
		IEnumerable<Communication> e_(Communication LevelOfSeverityCommunicated)
		{
			var k_ = this.Diabetic_Retinopathy_Encounter();
			bool? l_(Encounter EncounterDiabeticRetinopathy)
			{
				var r_ = LevelOfSeverityCommunicated?.SentElement;
				var s_ = FHIRHelpers_4_0_001.ToDateTime(r_);
				var t_ = EncounterDiabeticRetinopathy?.Period;
				var u_ = FHIRHelpers_4_0_001.ToInterval(t_);
				var v_ = context.Operators;
				var w_ = v_.Start(u_);
				var y_ = v_.After(s_, w_, null);

				return y_;
			};
			var m_ = context.Operators;
			var n_ = m_.WhereOrNull<Encounter>(k_, l_);
			Communication o_(Encounter EncounterDiabeticRetinopathy) => LevelOfSeverityCommunicated;
			var q_ = m_.SelectOrNull<Encounter, Communication>(n_, o_);

			return q_;
		};
		var f_ = context.Operators;
		var g_ = f_.SelectManyOrNull<Communication, Communication>(d_, e_);
		bool? h_(Communication LevelOfSeverityCommunicated)
		{
			var z_ = LevelOfSeverityCommunicated?.StatusElement;
			var aa_ = new CallStackEntry("ToString", null, null);
			var ab_ = context.Deeper(aa_);
			var ac_ = ab_.Operators;
			var ad_ = ac_.TypeConverter;
			var ae_ = ad_.Convert<string>(z_);
			var af_ = context.Operators;
			var ag_ = af_.Equal(ae_, "completed");

			return ag_;
		};
		var j_ = f_.WhereOrNull<Communication>(g_, h_);

		return j_;
	}

    [CqlDeclaration("Level of Severity of Retinopathy Findings Communicated")]
    public IEnumerable<Communication> Level_of_Severity_of_Retinopathy_Findings_Communicated() => __Level_of_Severity_of_Retinopathy_Findings_Communicated.Value;

    private IEnumerable<Communication> Macular_Edema_Absence_Communicated_Value()
	{
		var a_ = this.Macular_edema_absent__situation_();
		var b_ = context.Operators;
		var c_ = b_.ToList<CqlCode>(a_);
		var d_ = typeof(Communication).GetProperty("ReasonCode");
		var e_ = context.DataRetriever;
		var f_ = e_.RetrieveByCodes<Communication>(c_, d_);
		IEnumerable<Communication> g_(Communication MacularEdemaAbsentCommunicated)
		{
			var m_ = this.Diabetic_Retinopathy_Encounter();
			bool? n_(Encounter EncounterDiabeticRetinopathy)
			{
				var t_ = MacularEdemaAbsentCommunicated?.SentElement;
				var u_ = FHIRHelpers_4_0_001.ToDateTime(t_);
				var v_ = EncounterDiabeticRetinopathy?.Period;
				var w_ = FHIRHelpers_4_0_001.ToInterval(v_);
				var x_ = context.Operators;
				var y_ = x_.Start(w_);
				var aa_ = x_.After(u_, y_, null);

				return aa_;
			};
			var o_ = context.Operators;
			var p_ = o_.WhereOrNull<Encounter>(m_, n_);
			Communication q_(Encounter EncounterDiabeticRetinopathy) => MacularEdemaAbsentCommunicated;
			var s_ = o_.SelectOrNull<Encounter, Communication>(p_, q_);

			return s_;
		};
		var i_ = b_.SelectManyOrNull<Communication, Communication>(f_, g_);
		bool? j_(Communication MacularEdemaAbsentCommunicated)
		{
			var ab_ = MacularEdemaAbsentCommunicated?.StatusElement;
			var ac_ = new CallStackEntry("ToString", null, null);
			var ad_ = context.Deeper(ac_);
			var ae_ = ad_.Operators;
			var af_ = ae_.TypeConverter;
			var ag_ = af_.Convert<string>(ab_);
			var ah_ = context.Operators;
			var ai_ = ah_.Equal(ag_, "completed");

			return ai_;
		};
		var l_ = b_.WhereOrNull<Communication>(i_, j_);

		return l_;
	}

    [CqlDeclaration("Macular Edema Absence Communicated")]
    public IEnumerable<Communication> Macular_Edema_Absence_Communicated() => __Macular_Edema_Absence_Communicated.Value;

    private IEnumerable<Communication> Macular_Edema_Presence_Communicated_Value()
	{
		var a_ = this.Macular_Edema_Findings_Present();
		var b_ = typeof(Communication).GetProperty("ReasonCode");
		var c_ = context.DataRetriever;
		var d_ = c_.RetrieveByValueSet<Communication>(a_, b_);
		IEnumerable<Communication> e_(Communication MacularEdemaPresentCommunicated)
		{
			var k_ = this.Diabetic_Retinopathy_Encounter();
			bool? l_(Encounter EncounterDiabeticRetinopathy)
			{
				var r_ = MacularEdemaPresentCommunicated?.SentElement;
				var s_ = FHIRHelpers_4_0_001.ToDateTime(r_);
				var t_ = EncounterDiabeticRetinopathy?.Period;
				var u_ = FHIRHelpers_4_0_001.ToInterval(t_);
				var v_ = context.Operators;
				var w_ = v_.Start(u_);
				var y_ = v_.After(s_, w_, null);

				return y_;
			};
			var m_ = context.Operators;
			var n_ = m_.WhereOrNull<Encounter>(k_, l_);
			Communication o_(Encounter EncounterDiabeticRetinopathy) => MacularEdemaPresentCommunicated;
			var q_ = m_.SelectOrNull<Encounter, Communication>(n_, o_);

			return q_;
		};
		var f_ = context.Operators;
		var g_ = f_.SelectManyOrNull<Communication, Communication>(d_, e_);
		bool? h_(Communication MacularEdemaPresentCommunicated)
		{
			var z_ = MacularEdemaPresentCommunicated?.StatusElement;
			var aa_ = new CallStackEntry("ToString", null, null);
			var ab_ = context.Deeper(aa_);
			var ac_ = ab_.Operators;
			var ad_ = ac_.TypeConverter;
			var ae_ = ad_.Convert<string>(z_);
			var af_ = context.Operators;
			var ag_ = af_.Equal(ae_, "completed");

			return ag_;
		};
		var j_ = f_.WhereOrNull<Communication>(g_, h_);

		return j_;
	}

    [CqlDeclaration("Macular Edema Presence Communicated")]
    public IEnumerable<Communication> Macular_Edema_Presence_Communicated() => __Macular_Edema_Presence_Communicated.Value;

    private bool? Results_of_Dilated_Macular_or_Fundus_Exam_Communicated_Value()
	{
		var a_ = this.Level_of_Severity_of_Retinopathy_Findings_Communicated();
		var b_ = context.Operators;
		var c_ = b_.ExistsInList<Communication>(a_);
		var d_ = this.Macular_Edema_Absence_Communicated();
		var f_ = b_.ExistsInList<Communication>(d_);
		var g_ = this.Macular_Edema_Presence_Communicated();
		var i_ = b_.ExistsInList<Communication>(g_);
		var k_ = b_.Or(f_, i_);
		var m_ = b_.And(c_, k_);

		return m_;
	}

    [CqlDeclaration("Results of Dilated Macular or Fundus Exam Communicated")]
    public bool? Results_of_Dilated_Macular_or_Fundus_Exam_Communicated() => __Results_of_Dilated_Macular_or_Fundus_Exam_Communicated.Value;

    private bool? Numerator_Value()
	{
		var a_ = this.Level_of_Severity_of_Retinopathy_Findings_Communicated();
		var b_ = context.Operators;
		var c_ = b_.ExistsInList<Communication>(a_);
		var d_ = this.Macular_Edema_Absence_Communicated();
		var f_ = b_.ExistsInList<Communication>(d_);
		var g_ = this.Macular_Edema_Presence_Communicated();
		var i_ = b_.ExistsInList<Communication>(g_);
		var k_ = b_.Or(f_, i_);
		var m_ = b_.And(c_, k_);

		return m_;
	}

    [CqlDeclaration("Numerator")]
    public bool? Numerator() => __Numerator.Value;

}