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
    internal Lazy<IEnumerable<(CodeableConcept code, Period period)?>> __SDE_Payer;
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
        __SDE_Payer = new Lazy<IEnumerable<(CodeableConcept code, Period period)?>>(this.SDE_Payer_Value);
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
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014", default);

    [CqlDeclaration("Care Services in Long-Term Residential Facility")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014")]
	public CqlValueSet Care_Services_in_Long_Term_Residential_Facility() => 
		__Care_Services_in_Long_Term_Residential_Facility.Value;

	private CqlValueSet Diabetic_Retinopathy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.327", default);

    [CqlDeclaration("Diabetic Retinopathy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.327")]
	public CqlValueSet Diabetic_Retinopathy() => 
		__Diabetic_Retinopathy.Value;

	private CqlValueSet Level_of_Severity_of_Retinopathy_Findings_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1283", default);

    [CqlDeclaration("Level of Severity of Retinopathy Findings")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1283")]
	public CqlValueSet Level_of_Severity_of_Retinopathy_Findings() => 
		__Level_of_Severity_of_Retinopathy_Findings.Value;

	private CqlValueSet Macular_Edema_Findings_Present_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1320", default);

    [CqlDeclaration("Macular Edema Findings Present")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1320")]
	public CqlValueSet Macular_Edema_Findings_Present() => 
		__Macular_Edema_Findings_Present.Value;

	private CqlValueSet Macular_Exam_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1251", default);

    [CqlDeclaration("Macular Exam")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1251")]
	public CqlValueSet Macular_Exam() => 
		__Macular_Exam.Value;

	private CqlValueSet Medical_Reason_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007", default);

    [CqlDeclaration("Medical Reason")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007")]
	public CqlValueSet Medical_Reason() => 
		__Medical_Reason.Value;

	private CqlValueSet Nursing_Facility_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012", default);

    [CqlDeclaration("Nursing Facility Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012")]
	public CqlValueSet Nursing_Facility_Visit() => 
		__Nursing_Facility_Visit.Value;

	private CqlValueSet Office_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", default);

    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
	public CqlValueSet Office_Visit() => 
		__Office_Visit.Value;

	private CqlValueSet Ophthalmological_Services_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285", default);

    [CqlDeclaration("Ophthalmological Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285")]
	public CqlValueSet Ophthalmological_Services() => 
		__Ophthalmological_Services.Value;

	private CqlValueSet Outpatient_Consultation_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", default);

    [CqlDeclaration("Outpatient Consultation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008")]
	public CqlValueSet Outpatient_Consultation() => 
		__Outpatient_Consultation.Value;

	private CqlValueSet Patient_Reason_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1008", default);

    [CqlDeclaration("Patient Reason")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1008")]
	public CqlValueSet Patient_Reason() => 
		__Patient_Reason.Value;

	private CqlCode Birth_date_Value() => 
		new CqlCode("21112-8", "http://loinc.org", default, default);

    [CqlDeclaration("Birth date")]
	public CqlCode Birth_date() => 
		__Birth_date.Value;

	private CqlCode Healthcare_professional__occupation__Value() => 
		new CqlCode("223366009", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Healthcare professional (occupation)")]
	public CqlCode Healthcare_professional__occupation_() => 
		__Healthcare_professional__occupation_.Value;

	private CqlCode Macular_edema_absent__situation__Value() => 
		new CqlCode("428341000124108", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Macular edema absent (situation)")]
	public CqlCode Macular_edema_absent__situation_() => 
		__Macular_edema_absent__situation_.Value;

	private CqlCode Medical_practitioner__occupation__Value() => 
		new CqlCode("158965000", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Medical practitioner (occupation)")]
	public CqlCode Medical_practitioner__occupation_() => 
		__Medical_practitioner__occupation_.Value;

	private CqlCode Ophthalmologist__occupation__Value() => 
		new CqlCode("422234006", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Ophthalmologist (occupation)")]
	public CqlCode Ophthalmologist__occupation_() => 
		__Ophthalmologist__occupation_.Value;

	private CqlCode Optometrist__occupation__Value() => 
		new CqlCode("28229004", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Optometrist (occupation)")]
	public CqlCode Optometrist__occupation_() => 
		__Optometrist__occupation_.Value;

	private CqlCode Physician__occupation__Value() => 
		new CqlCode("309343006", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Physician (occupation)")]
	public CqlCode Physician__occupation_() => 
		__Physician__occupation_.Value;

	private CqlCode[] LOINC_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("21112-8", "http://loinc.org", default, default),
		];

		return a_;
	}

    [CqlDeclaration("LOINC")]
	public CqlCode[] LOINC() => 
		__LOINC.Value;

	private CqlCode[] SNOMEDCT_Value()
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

    [CqlDeclaration("SNOMEDCT")]
	public CqlCode[] SNOMEDCT() => 
		__SNOMEDCT.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		object a_ = context.ResolveParameter("DRCommunicationWithPhysicianManagingDiabetesFHIR-0.0.004", "Measurement Period", null);

		return (CqlInterval<CqlDateTime>)a_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period.Value;

	private Patient Patient_Value()
	{
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(default, default);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private IEnumerable<Coding> SDE_Ethnicity_Value()
	{
		IEnumerable<Coding> a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public IEnumerable<Coding> SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private IEnumerable<(CodeableConcept code, Period period)?> SDE_Payer_Value()
	{
		IEnumerable<(CodeableConcept code, Period period)?> a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<(CodeableConcept code, Period period)?> SDE_Payer() => 
		__SDE_Payer.Value;

	private IEnumerable<Coding> SDE_Race_Value()
	{
		IEnumerable<Coding> a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public IEnumerable<Coding> SDE_Race() => 
		__SDE_Race.Value;

	private CqlCode SDE_Sex_Value()
	{
		CqlCode a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Sex();

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex() => 
		__SDE_Sex.Value;

	private IEnumerable<Encounter> Qualifying_Encounter_During_Measurement_Period_Value()
	{
		CqlValueSet a_ = this.Office_Visit();
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, default);
		CqlValueSet c_ = this.Ophthalmological_Services();
		IEnumerable<Encounter> d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, default);
		IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
		CqlValueSet f_ = this.Outpatient_Consultation();
		IEnumerable<Encounter> g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, default);
		CqlValueSet h_ = this.Care_Services_in_Long_Term_Residential_Facility();
		IEnumerable<Encounter> i_ = context.Operators.RetrieveByValueSet<Encounter>(h_, default);
		IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
		IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
		CqlValueSet l_ = this.Nursing_Facility_Visit();
		IEnumerable<Encounter> m_ = context.Operators.RetrieveByValueSet<Encounter>(l_, default);
		IEnumerable<Encounter> n_ = context.Operators.Union<Encounter>(k_, m_);
		bool? o_(Encounter QualifyingEncounter)
		{
			CqlInterval<CqlDateTime> q_ = this.Measurement_Period();
			Period r_ = QualifyingEncounter?.Period;
			CqlInterval<CqlDateTime> s_ = FHIRHelpers_4_0_001.ToInterval(r_);
			bool? t_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(q_, s_, default);
			Code<Encounter.EncounterStatus> u_ = QualifyingEncounter?.StatusElement;
			string v_ = FHIRHelpers_4_0_001.ToString(u_);
			bool? w_ = context.Operators.Equal(v_, "finished");
			bool? x_ = context.Operators.And(t_, w_);

			return x_;
		};
		IEnumerable<Encounter> p_ = context.Operators.Where<Encounter>(n_, o_);

		return p_;
	}

    [CqlDeclaration("Qualifying Encounter During Measurement Period")]
	public IEnumerable<Encounter> Qualifying_Encounter_During_Measurement_Period() => 
		__Qualifying_Encounter_During_Measurement_Period.Value;

	private IEnumerable<Encounter> Diabetic_Retinopathy_Encounter_Value()
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounter_During_Measurement_Period();
		IEnumerable<Encounter> b_(Encounter ValidQualifyingEncounter)
		{
			CqlValueSet d_ = this.Diabetic_Retinopathy();
			IEnumerable<Condition> e_ = context.Operators.RetrieveByValueSet<Condition>(d_, default);
			bool? f_(Condition DiabeticRetinopathy)
			{
				CodeableConcept j_ = DiabeticRetinopathy?.ClinicalStatus;
				CqlConcept k_ = FHIRHelpers_4_0_001.ToConcept(j_);
				CqlCode l_ = MATGlobalCommonFunctionsFHIR4_6_1_000.active();
				CqlConcept m_ = context.Operators.ConvertCodeToConcept(l_);
				bool? n_ = context.Operators.Equivalent(k_, m_);
				CqlInterval<CqlDateTime> o_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(DiabeticRetinopathy);
				Period p_ = ValidQualifyingEncounter?.Period;
				CqlInterval<CqlDateTime> q_ = FHIRHelpers_4_0_001.ToInterval(p_);
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

    [CqlDeclaration("Diabetic Retinopathy Encounter")]
	public IEnumerable<Encounter> Diabetic_Retinopathy_Encounter() => 
		__Diabetic_Retinopathy_Encounter.Value;

    [CqlDeclaration("GetModifierExtensions")]
	public IEnumerable<Extension> GetModifierExtensions(DomainResource domainResource, string url)
	{
		List<Extension> a_ = domainResource?.ModifierExtension;
		bool? b_(Extension E)
		{
			string f_ = E?.Url;
			FhirUri g_ = context.Operators.Convert<FhirUri>(f_);
			string h_ = FHIRHelpers_4_0_001.ToString(g_);
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

    [CqlDeclaration("GetModifierExtension")]
	public Extension GetModifierExtension(DomainResource domainResource, string url)
	{
		IEnumerable<Extension> a_ = this.GetModifierExtensions(domainResource, url);
		Extension b_ = context.Operators.SingletonFrom<Extension>(a_);

		return b_;
	}

	private IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy_Value()
	{
		CqlValueSet a_ = this.Level_of_Severity_of_Retinopathy_Findings();
		PropertyInfo b_ = typeof(Communication).GetProperty("ReasonCode");
		IEnumerable<Communication> c_ = context.Operators.RetrieveByValueSet<Communication>(a_, b_);
		IEnumerable<Communication> d_(Communication LevelOfSeverityNotCommunicated)
		{
			IEnumerable<Encounter> h_ = this.Diabetic_Retinopathy_Encounter();
			bool? i_(Encounter EncounterDiabeticRetinopathy)
			{
				Period m_ = EncounterDiabeticRetinopathy?.Period;
				CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_0_001.ToInterval(m_);
				Extension o_ = MATGlobalCommonFunctionsFHIR4_6_1_000.GetExtension(LevelOfSeverityNotCommunicated, "qicore-recorded");
				DataType p_ = o_?.Value;
				Period q_ = p_ switch { null => null , Period a => a/* , Base64Binary => ???, FhirBoolean => ???, Canonical => ???, Code => ???, Date => ???, FhirDateTime => ???, FhirDecimal => ???, Id => ???, Instant => ???, Integer => ???, Markdown => ???, Oid => ???, Integer => ???, FhirString => ???, Time => ???, Integer => ???, FhirUri => ???, FhirUrl => ???, Uuid => ???, Address => ???, Age => ???, Annotation => ???, Attachment => ???, CodeableConcept => ???, Coding => ???, ContactPoint => ???, Count => ???, Distance => ???, Duration => ???, HumanName => ???, Identifier => ???, Money => ???, Quantity => ???, Range => ???, Ratio => ???, ResourceReference => ???, SampledData => ???, Signature => ???, Timing => ???, ContactDetail => ???, Contributor => ???, DataRequirement => ???, Expression => ???, ParameterDefinition => ???, RelatedArtifact => ???, TriggerDefinition => ???, UsageContext => ???, Dosage => ???, Meta => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
				CqlInterval<CqlDateTime> r_ = FHIRHelpers_4_0_001.ToInterval(q_);
				bool? s_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(n_, r_, default);

				return s_;
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
			Code<EventStatus> t_ = LevelOfSeverityNotCommunicated?.StatusElement;
			string u_ = FHIRHelpers_4_0_001.ToString(t_);
			bool? v_ = context.Operators.Equal(u_, "not-done");
			Extension w_ = this.GetModifierExtension(LevelOfSeverityNotCommunicated, "qicore-notDone");
			DataType x_ = w_?.Value;
			FhirBoolean y_ = x_ switch { null => null , FhirBoolean b => b/* , Base64Binary => ???, Canonical => ???, Code => ???, Date => ???, FhirDateTime => ???, FhirDecimal => ???, Id => ???, Instant => ???, Integer => ???, Markdown => ???, Oid => ???, Integer => ???, FhirString => ???, Time => ???, Integer => ???, FhirUri => ???, FhirUrl => ???, Uuid => ???, Address => ???, Age => ???, Annotation => ???, Attachment => ???, CodeableConcept => ???, Coding => ???, ContactPoint => ???, Count => ???, Distance => ???, Duration => ???, HumanName => ???, Identifier => ???, Money => ???, Period => ???, Quantity => ???, Range => ???, Ratio => ???, ResourceReference => ???, SampledData => ???, Signature => ???, Timing => ???, ContactDetail => ???, Contributor => ???, DataRequirement => ???, Expression => ???, ParameterDefinition => ???, RelatedArtifact => ???, TriggerDefinition => ???, UsageContext => ???, Dosage => ???, Meta => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
			bool? z_ = FHIRHelpers_4_0_001.ToBoolean(y_);
			bool? aa_ = context.Operators.IsTrue(z_);
			bool? ab_ = context.Operators.And(v_, aa_);
			CodeableConcept ac_ = LevelOfSeverityNotCommunicated?.StatusReason;
			CqlConcept ad_ = FHIRHelpers_4_0_001.ToConcept(ac_);
			CqlValueSet ae_ = this.Medical_Reason();
			bool? af_ = context.Operators.ConceptInValueSet(ad_, ae_);
			CqlConcept ah_ = FHIRHelpers_4_0_001.ToConcept(ac_);
			CqlValueSet ai_ = this.Patient_Reason();
			bool? aj_ = context.Operators.ConceptInValueSet(ah_, ai_);
			bool? ak_ = context.Operators.Or(af_, aj_);
			bool? al_ = context.Operators.And(ab_, ak_);

			return al_;
		};
		IEnumerable<Communication> g_ = context.Operators.Where<Communication>(e_, f_);

		return g_;
	}

    [CqlDeclaration("Medical or Patient Reason for Not Communicating Level of Severity of Retinopathy")]
	public IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy() => 
		__Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy.Value;

	private IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema_Value()
	{
		CqlCode a_ = this.Macular_edema_absent__situation_();
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		PropertyInfo c_ = typeof(Communication).GetProperty("ReasonCode");
		IEnumerable<Communication> d_ = context.Operators.RetrieveByCodes<Communication>(b_, c_);
		IEnumerable<Communication> e_(Communication MacularEdemaAbsentNotCommunicated)
		{
			IEnumerable<Encounter> i_ = this.Diabetic_Retinopathy_Encounter();
			bool? j_(Encounter EncounterDiabeticRetinopathy)
			{
				Period n_ = EncounterDiabeticRetinopathy?.Period;
				CqlInterval<CqlDateTime> o_ = FHIRHelpers_4_0_001.ToInterval(n_);
				Extension p_ = MATGlobalCommonFunctionsFHIR4_6_1_000.GetExtension(MacularEdemaAbsentNotCommunicated, "qicore-recorded");
				DataType q_ = p_?.Value;
				Period r_ = q_ switch { null => null , Period a => a/* , Base64Binary => ???, FhirBoolean => ???, Canonical => ???, Code => ???, Date => ???, FhirDateTime => ???, FhirDecimal => ???, Id => ???, Instant => ???, Integer => ???, Markdown => ???, Oid => ???, Integer => ???, FhirString => ???, Time => ???, Integer => ???, FhirUri => ???, FhirUrl => ???, Uuid => ???, Address => ???, Age => ???, Annotation => ???, Attachment => ???, CodeableConcept => ???, Coding => ???, ContactPoint => ???, Count => ???, Distance => ???, Duration => ???, HumanName => ???, Identifier => ???, Money => ???, Quantity => ???, Range => ???, Ratio => ???, ResourceReference => ???, SampledData => ???, Signature => ???, Timing => ???, ContactDetail => ???, Contributor => ???, DataRequirement => ???, Expression => ???, ParameterDefinition => ???, RelatedArtifact => ???, TriggerDefinition => ???, UsageContext => ???, Dosage => ???, Meta => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
				CqlInterval<CqlDateTime> s_ = FHIRHelpers_4_0_001.ToInterval(r_);
				bool? t_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(o_, s_, default);

				return t_;
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
			Code<EventStatus> u_ = MacularEdemaAbsentNotCommunicated?.StatusElement;
			string v_ = FHIRHelpers_4_0_001.ToString(u_);
			bool? w_ = context.Operators.Equal(v_, "not-done");
			Extension x_ = this.GetModifierExtension(MacularEdemaAbsentNotCommunicated, "qicore-notDone");
			DataType y_ = x_?.Value;
			FhirBoolean z_ = y_ switch { null => null , FhirBoolean b => b/* , Base64Binary => ???, Canonical => ???, Code => ???, Date => ???, FhirDateTime => ???, FhirDecimal => ???, Id => ???, Instant => ???, Integer => ???, Markdown => ???, Oid => ???, Integer => ???, FhirString => ???, Time => ???, Integer => ???, FhirUri => ???, FhirUrl => ???, Uuid => ???, Address => ???, Age => ???, Annotation => ???, Attachment => ???, CodeableConcept => ???, Coding => ???, ContactPoint => ???, Count => ???, Distance => ???, Duration => ???, HumanName => ???, Identifier => ???, Money => ???, Period => ???, Quantity => ???, Range => ???, Ratio => ???, ResourceReference => ???, SampledData => ???, Signature => ???, Timing => ???, ContactDetail => ???, Contributor => ???, DataRequirement => ???, Expression => ???, ParameterDefinition => ???, RelatedArtifact => ???, TriggerDefinition => ???, UsageContext => ???, Dosage => ???, Meta => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
			bool? aa_ = FHIRHelpers_4_0_001.ToBoolean(z_);
			bool? ab_ = context.Operators.IsTrue(aa_);
			bool? ac_ = context.Operators.And(w_, ab_);
			CodeableConcept ad_ = MacularEdemaAbsentNotCommunicated?.StatusReason;
			CqlConcept ae_ = FHIRHelpers_4_0_001.ToConcept(ad_);
			CqlValueSet af_ = this.Medical_Reason();
			bool? ag_ = context.Operators.ConceptInValueSet(ae_, af_);
			CqlConcept ai_ = FHIRHelpers_4_0_001.ToConcept(ad_);
			CqlValueSet aj_ = this.Patient_Reason();
			bool? ak_ = context.Operators.ConceptInValueSet(ai_, aj_);
			bool? al_ = context.Operators.Or(ag_, ak_);
			bool? am_ = context.Operators.And(ac_, al_);

			return am_;
		};
		IEnumerable<Communication> h_ = context.Operators.Where<Communication>(f_, g_);

		return h_;
	}

    [CqlDeclaration("Medical or Patient Reason for Not Communicating Absence of Macular Edema")]
	public IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema() => 
		__Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema.Value;

	private IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Presence_of_Macular_Edema_Value()
	{
		CqlValueSet a_ = this.Macular_Edema_Findings_Present();
		PropertyInfo b_ = typeof(Communication).GetProperty("ReasonCode");
		IEnumerable<Communication> c_ = context.Operators.RetrieveByValueSet<Communication>(a_, b_);
		IEnumerable<Communication> d_(Communication MacularEdemaPresentNotCommunicated)
		{
			IEnumerable<Encounter> h_ = this.Diabetic_Retinopathy_Encounter();
			bool? i_(Encounter EncounterDiabeticRetinopathy)
			{
				Period m_ = EncounterDiabeticRetinopathy?.Period;
				CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_0_001.ToInterval(m_);
				Extension o_ = MATGlobalCommonFunctionsFHIR4_6_1_000.GetExtension(MacularEdemaPresentNotCommunicated, "qicore-recorded");
				DataType p_ = o_?.Value;
				Period q_ = p_ switch { null => null , Period a => a/* , Base64Binary => ???, FhirBoolean => ???, Canonical => ???, Code => ???, Date => ???, FhirDateTime => ???, FhirDecimal => ???, Id => ???, Instant => ???, Integer => ???, Markdown => ???, Oid => ???, Integer => ???, FhirString => ???, Time => ???, Integer => ???, FhirUri => ???, FhirUrl => ???, Uuid => ???, Address => ???, Age => ???, Annotation => ???, Attachment => ???, CodeableConcept => ???, Coding => ???, ContactPoint => ???, Count => ???, Distance => ???, Duration => ???, HumanName => ???, Identifier => ???, Money => ???, Quantity => ???, Range => ???, Ratio => ???, ResourceReference => ???, SampledData => ???, Signature => ???, Timing => ???, ContactDetail => ???, Contributor => ???, DataRequirement => ???, Expression => ???, ParameterDefinition => ???, RelatedArtifact => ???, TriggerDefinition => ???, UsageContext => ???, Dosage => ???, Meta => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
				CqlInterval<CqlDateTime> r_ = FHIRHelpers_4_0_001.ToInterval(q_);
				bool? s_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(n_, r_, default);

				return s_;
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
			Code<EventStatus> t_ = MacularEdemaPresentNotCommunicated?.StatusElement;
			string u_ = FHIRHelpers_4_0_001.ToString(t_);
			bool? v_ = context.Operators.Equal(u_, "not-done");
			Extension w_ = this.GetModifierExtension(MacularEdemaPresentNotCommunicated, "qicore-notDone");
			DataType x_ = w_?.Value;
			FhirBoolean y_ = x_ switch { null => null , FhirBoolean b => b/* , Base64Binary => ???, Canonical => ???, Code => ???, Date => ???, FhirDateTime => ???, FhirDecimal => ???, Id => ???, Instant => ???, Integer => ???, Markdown => ???, Oid => ???, Integer => ???, FhirString => ???, Time => ???, Integer => ???, FhirUri => ???, FhirUrl => ???, Uuid => ???, Address => ???, Age => ???, Annotation => ???, Attachment => ???, CodeableConcept => ???, Coding => ???, ContactPoint => ???, Count => ???, Distance => ???, Duration => ???, HumanName => ???, Identifier => ???, Money => ???, Period => ???, Quantity => ???, Range => ???, Ratio => ???, ResourceReference => ???, SampledData => ???, Signature => ???, Timing => ???, ContactDetail => ???, Contributor => ???, DataRequirement => ???, Expression => ???, ParameterDefinition => ???, RelatedArtifact => ???, TriggerDefinition => ???, UsageContext => ???, Dosage => ???, Meta => ??? */, _ => throw new System.Diagnostics.UnreachableException() };
			bool? z_ = FHIRHelpers_4_0_001.ToBoolean(y_);
			bool? aa_ = context.Operators.IsTrue(z_);
			bool? ab_ = context.Operators.And(v_, aa_);
			CodeableConcept ac_ = MacularEdemaPresentNotCommunicated?.StatusReason;
			CqlConcept ad_ = FHIRHelpers_4_0_001.ToConcept(ac_);
			CqlValueSet ae_ = this.Medical_Reason();
			bool? af_ = context.Operators.ConceptInValueSet(ad_, ae_);
			CqlConcept ah_ = FHIRHelpers_4_0_001.ToConcept(ac_);
			CqlValueSet ai_ = this.Patient_Reason();
			bool? aj_ = context.Operators.ConceptInValueSet(ah_, ai_);
			bool? ak_ = context.Operators.Or(af_, aj_);
			bool? al_ = context.Operators.And(ab_, ak_);

			return al_;
		};
		IEnumerable<Communication> g_ = context.Operators.Where<Communication>(e_, f_);

		return g_;
	}

    [CqlDeclaration("Medical or Patient Reason for Not Communicating Presence of Macular Edema")]
	public IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Presence_of_Macular_Edema() => 
		__Medical_or_Patient_Reason_for_Not_Communicating_Presence_of_Macular_Edema.Value;

	private bool? Denominator_Exceptions_Value()
	{
		IEnumerable<Communication> a_ = this.Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy();
		bool? b_ = context.Operators.Exists<Communication>(a_);
		IEnumerable<Communication> c_ = this.Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema();
		bool? d_ = context.Operators.Exists<Communication>(c_);
		bool? e_ = context.Operators.Or(b_, d_);
		IEnumerable<Communication> f_ = this.Medical_or_Patient_Reason_for_Not_Communicating_Presence_of_Macular_Edema();
		bool? g_ = context.Operators.Exists<Communication>(f_);
		bool? h_ = context.Operators.Or(e_, g_);

		return h_;
	}

    [CqlDeclaration("Denominator Exceptions")]
	public bool? Denominator_Exceptions() => 
		__Denominator_Exceptions.Value;

	private bool? Initial_Population_Value()
	{
		Patient a_ = this.Patient();
		Date b_ = a_?.BirthDateElement;
		string c_ = b_?.Value;
		CqlDateTime d_ = context.Operators.ConvertStringToDateTime(c_);
		CqlInterval<CqlDateTime> e_ = this.Measurement_Period();
		CqlDateTime f_ = context.Operators.Start(e_);
		int? g_ = context.Operators.CalculateAgeAt(d_, f_, "year");
		bool? h_ = context.Operators.GreaterOrEqual(g_, 18);
		IEnumerable<Encounter> i_ = this.Diabetic_Retinopathy_Encounter();
		bool? j_ = context.Operators.Exists<Encounter>(i_);
		bool? k_ = context.Operators.And(h_, j_);

		return k_;
	}

    [CqlDeclaration("Initial Population")]
	public bool? Initial_Population() => 
		__Initial_Population.Value;

	private IEnumerable<Observation> Macular_Exam_Performed_Value()
	{
		CqlValueSet a_ = this.Macular_Exam();
		IEnumerable<Observation> b_ = context.Operators.RetrieveByValueSet<Observation>(a_, default);
		IEnumerable<Observation> c_(Observation MacularExam)
		{
			IEnumerable<Encounter> g_ = this.Diabetic_Retinopathy_Encounter();
			bool? h_(Encounter EncounterDiabeticRetinopathy)
			{
				Period l_ = EncounterDiabeticRetinopathy?.Period;
				CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_0_001.ToInterval(l_);
				DataType n_ = MacularExam?.Effective;
				CqlInterval<CqlDateTime> o_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(n_);
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
			string r_ = FHIRHelpers_4_0_001.ToString(q_);
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

    [CqlDeclaration("Macular Exam Performed")]
	public IEnumerable<Observation> Macular_Exam_Performed() => 
		__Macular_Exam_Performed.Value;

	private bool? Denominator_Value()
	{
		bool? a_ = this.Initial_Population();
		IEnumerable<Observation> b_ = this.Macular_Exam_Performed();
		bool? c_ = context.Operators.Exists<Observation>(b_);
		bool? d_ = context.Operators.And(a_, c_);

		return d_;
	}

    [CqlDeclaration("Denominator")]
	public bool? Denominator() => 
		__Denominator.Value;

	private IEnumerable<Communication> Level_of_Severity_of_Retinopathy_Findings_Communicated_Value()
	{
		CqlValueSet a_ = this.Level_of_Severity_of_Retinopathy_Findings();
		PropertyInfo b_ = typeof(Communication).GetProperty("ReasonCode");
		IEnumerable<Communication> c_ = context.Operators.RetrieveByValueSet<Communication>(a_, b_);
		IEnumerable<Communication> d_(Communication LevelOfSeverityCommunicated)
		{
			IEnumerable<Encounter> h_ = this.Diabetic_Retinopathy_Encounter();
			bool? i_(Encounter EncounterDiabeticRetinopathy)
			{
				FhirDateTime m_ = LevelOfSeverityCommunicated?.SentElement;
				CqlDateTime n_ = FHIRHelpers_4_0_001.ToDateTime(m_);
				Period o_ = EncounterDiabeticRetinopathy?.Period;
				CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_0_001.ToInterval(o_);
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
			string t_ = FHIRHelpers_4_0_001.ToString(s_);
			bool? u_ = context.Operators.Equal(t_, "completed");

			return u_;
		};
		IEnumerable<Communication> g_ = context.Operators.Where<Communication>(e_, f_);

		return g_;
	}

    [CqlDeclaration("Level of Severity of Retinopathy Findings Communicated")]
	public IEnumerable<Communication> Level_of_Severity_of_Retinopathy_Findings_Communicated() => 
		__Level_of_Severity_of_Retinopathy_Findings_Communicated.Value;

	private IEnumerable<Communication> Macular_Edema_Absence_Communicated_Value()
	{
		CqlCode a_ = this.Macular_edema_absent__situation_();
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		PropertyInfo c_ = typeof(Communication).GetProperty("ReasonCode");
		IEnumerable<Communication> d_ = context.Operators.RetrieveByCodes<Communication>(b_, c_);
		IEnumerable<Communication> e_(Communication MacularEdemaAbsentCommunicated)
		{
			IEnumerable<Encounter> i_ = this.Diabetic_Retinopathy_Encounter();
			bool? j_(Encounter EncounterDiabeticRetinopathy)
			{
				FhirDateTime n_ = MacularEdemaAbsentCommunicated?.SentElement;
				CqlDateTime o_ = FHIRHelpers_4_0_001.ToDateTime(n_);
				Period p_ = EncounterDiabeticRetinopathy?.Period;
				CqlInterval<CqlDateTime> q_ = FHIRHelpers_4_0_001.ToInterval(p_);
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
			string u_ = FHIRHelpers_4_0_001.ToString(t_);
			bool? v_ = context.Operators.Equal(u_, "completed");

			return v_;
		};
		IEnumerable<Communication> h_ = context.Operators.Where<Communication>(f_, g_);

		return h_;
	}

    [CqlDeclaration("Macular Edema Absence Communicated")]
	public IEnumerable<Communication> Macular_Edema_Absence_Communicated() => 
		__Macular_Edema_Absence_Communicated.Value;

	private IEnumerable<Communication> Macular_Edema_Presence_Communicated_Value()
	{
		CqlValueSet a_ = this.Macular_Edema_Findings_Present();
		PropertyInfo b_ = typeof(Communication).GetProperty("ReasonCode");
		IEnumerable<Communication> c_ = context.Operators.RetrieveByValueSet<Communication>(a_, b_);
		IEnumerable<Communication> d_(Communication MacularEdemaPresentCommunicated)
		{
			IEnumerable<Encounter> h_ = this.Diabetic_Retinopathy_Encounter();
			bool? i_(Encounter EncounterDiabeticRetinopathy)
			{
				FhirDateTime m_ = MacularEdemaPresentCommunicated?.SentElement;
				CqlDateTime n_ = FHIRHelpers_4_0_001.ToDateTime(m_);
				Period o_ = EncounterDiabeticRetinopathy?.Period;
				CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_0_001.ToInterval(o_);
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
			string t_ = FHIRHelpers_4_0_001.ToString(s_);
			bool? u_ = context.Operators.Equal(t_, "completed");

			return u_;
		};
		IEnumerable<Communication> g_ = context.Operators.Where<Communication>(e_, f_);

		return g_;
	}

    [CqlDeclaration("Macular Edema Presence Communicated")]
	public IEnumerable<Communication> Macular_Edema_Presence_Communicated() => 
		__Macular_Edema_Presence_Communicated.Value;

	private bool? Results_of_Dilated_Macular_or_Fundus_Exam_Communicated_Value()
	{
		IEnumerable<Communication> a_ = this.Level_of_Severity_of_Retinopathy_Findings_Communicated();
		bool? b_ = context.Operators.Exists<Communication>(a_);
		IEnumerable<Communication> c_ = this.Macular_Edema_Absence_Communicated();
		bool? d_ = context.Operators.Exists<Communication>(c_);
		IEnumerable<Communication> e_ = this.Macular_Edema_Presence_Communicated();
		bool? f_ = context.Operators.Exists<Communication>(e_);
		bool? g_ = context.Operators.Or(d_, f_);
		bool? h_ = context.Operators.And(b_, g_);

		return h_;
	}

    [CqlDeclaration("Results of Dilated Macular or Fundus Exam Communicated")]
	public bool? Results_of_Dilated_Macular_or_Fundus_Exam_Communicated() => 
		__Results_of_Dilated_Macular_or_Fundus_Exam_Communicated.Value;

	private bool? Numerator_Value()
	{
		IEnumerable<Communication> a_ = this.Level_of_Severity_of_Retinopathy_Findings_Communicated();
		bool? b_ = context.Operators.Exists<Communication>(a_);
		IEnumerable<Communication> c_ = this.Macular_Edema_Absence_Communicated();
		bool? d_ = context.Operators.Exists<Communication>(c_);
		IEnumerable<Communication> e_ = this.Macular_Edema_Presence_Communicated();
		bool? f_ = context.Operators.Exists<Communication>(e_);
		bool? g_ = context.Operators.Or(d_, f_);
		bool? h_ = context.Operators.And(b_, g_);

		return h_;
	}

    [CqlDeclaration("Numerator")]
	public bool? Numerator() => 
		__Numerator.Value;

}
