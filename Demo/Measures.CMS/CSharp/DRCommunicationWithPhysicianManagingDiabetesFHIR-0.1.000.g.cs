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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.4.0")]
[CqlLibrary("DRCommunicationWithPhysicianManagingDiabetesFHIR", "0.1.000")]
public class DRCommunicationWithPhysicianManagingDiabetesFHIR_0_1_000
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
    internal Lazy<CqlValueSet> __Macular_edema_absent__situation_;
    internal Lazy<CqlCode> __Healthcare_professional__occupation_;
    internal Lazy<CqlCode> __Medical_practitioner__occupation_;
    internal Lazy<CqlCode> __Ophthalmologist__occupation_;
    internal Lazy<CqlCode> __Optometrist__occupation_;
    internal Lazy<CqlCode> __Physician__occupation_;
    internal Lazy<CqlCode> __virtual;
    internal Lazy<CqlCode> __AMB;
    internal Lazy<CqlCode[]> __SNOMEDCT;
    internal Lazy<CqlCode[]> __ActCode;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<(IEnumerable<CqlCode> codes, string display)?> __SDE_Ethnicity;
    internal Lazy<IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?>> __SDE_Payer;
    internal Lazy<(IEnumerable<CqlCode> codes, string display)?> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;
    internal Lazy<IEnumerable<Encounter>> __Qualifying_Encounter_During_Measurement_Period;
    internal Lazy<IEnumerable<Encounter>> __Diabetic_Retinopathy_Encounter;
    internal Lazy<bool?> __Initial_Population;
    internal Lazy<IEnumerable<Observation>> __Macular_Exam_Performed;
    internal Lazy<bool?> __Denominator;
    internal Lazy<IEnumerable<Communication>> __Level_of_Severity_of_Retinopathy_Findings_Communicated;
    internal Lazy<IEnumerable<Communication>> __Macular_Edema_Absence_Communicated;
    internal Lazy<IEnumerable<Communication>> __Macular_Edema_Presence_Communicated;
    internal Lazy<bool?> __Numerator;
    internal Lazy<IEnumerable<Communication>> __Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy;
    internal Lazy<IEnumerable<Communication>> __Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema;
    internal Lazy<IEnumerable<Communication>> __Medical_or_Patient_Reason_for_Not_Communicating_Presence_of_Macular_Edema;
    internal Lazy<bool?> __Denominator_Exceptions;
    internal Lazy<bool?> __Results_of_Dilated_Macular_or_Fundus_Exam_Communicated;

    #endregion
    public DRCommunicationWithPhysicianManagingDiabetesFHIR_0_1_000(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_3_000 = new FHIRHelpers_4_3_000(context);
        SupplementalDataElements_3_4_000 = new SupplementalDataElements_3_4_000(context);
        QICoreCommon_2_0_000 = new QICoreCommon_2_0_000(context);

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
        __Macular_edema_absent__situation_ = new Lazy<CqlValueSet>(this.Macular_edema_absent__situation__Value);
        __Healthcare_professional__occupation_ = new Lazy<CqlCode>(this.Healthcare_professional__occupation__Value);
        __Medical_practitioner__occupation_ = new Lazy<CqlCode>(this.Medical_practitioner__occupation__Value);
        __Ophthalmologist__occupation_ = new Lazy<CqlCode>(this.Ophthalmologist__occupation__Value);
        __Optometrist__occupation_ = new Lazy<CqlCode>(this.Optometrist__occupation__Value);
        __Physician__occupation_ = new Lazy<CqlCode>(this.Physician__occupation__Value);
        __virtual = new Lazy<CqlCode>(this.@virtual_Value);
        __AMB = new Lazy<CqlCode>(this.AMB_Value);
        __SNOMEDCT = new Lazy<CqlCode[]>(this.SNOMEDCT_Value);
        __ActCode = new Lazy<CqlCode[]>(this.ActCode_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __SDE_Ethnicity = new Lazy<(IEnumerable<CqlCode> codes, string display)?>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<(IEnumerable<CqlCode> codes, string display)?>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
        __Qualifying_Encounter_During_Measurement_Period = new Lazy<IEnumerable<Encounter>>(this.Qualifying_Encounter_During_Measurement_Period_Value);
        __Diabetic_Retinopathy_Encounter = new Lazy<IEnumerable<Encounter>>(this.Diabetic_Retinopathy_Encounter_Value);
        __Initial_Population = new Lazy<bool?>(this.Initial_Population_Value);
        __Macular_Exam_Performed = new Lazy<IEnumerable<Observation>>(this.Macular_Exam_Performed_Value);
        __Denominator = new Lazy<bool?>(this.Denominator_Value);
        __Level_of_Severity_of_Retinopathy_Findings_Communicated = new Lazy<IEnumerable<Communication>>(this.Level_of_Severity_of_Retinopathy_Findings_Communicated_Value);
        __Macular_Edema_Absence_Communicated = new Lazy<IEnumerable<Communication>>(this.Macular_Edema_Absence_Communicated_Value);
        __Macular_Edema_Presence_Communicated = new Lazy<IEnumerable<Communication>>(this.Macular_Edema_Presence_Communicated_Value);
        __Numerator = new Lazy<bool?>(this.Numerator_Value);
        __Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy = new Lazy<IEnumerable<Communication>>(this.Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy_Value);
        __Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema = new Lazy<IEnumerable<Communication>>(this.Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema_Value);
        __Medical_or_Patient_Reason_for_Not_Communicating_Presence_of_Macular_Edema = new Lazy<IEnumerable<Communication>>(this.Medical_or_Patient_Reason_for_Not_Communicating_Presence_of_Macular_Edema_Value);
        __Denominator_Exceptions = new Lazy<bool?>(this.Denominator_Exceptions_Value);
        __Results_of_Dilated_Macular_or_Fundus_Exam_Communicated = new Lazy<bool?>(this.Results_of_Dilated_Macular_or_Fundus_Exam_Communicated_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_3_000 FHIRHelpers_4_3_000 { get; }
    public SupplementalDataElements_3_4_000 SupplementalDataElements_3_4_000 { get; }
    public QICoreCommon_2_0_000 QICoreCommon_2_0_000 { get; }

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

	private CqlValueSet Macular_edema_absent__situation__Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.2.1391", default);

    [CqlDeclaration("Macular edema absent (situation)")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.2.1391")]
	public CqlValueSet Macular_edema_absent__situation_() => 
		__Macular_edema_absent__situation_.Value;

	private CqlCode Healthcare_professional__occupation__Value() => 
		new CqlCode("223366009", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Healthcare professional (occupation)")]
	public CqlCode Healthcare_professional__occupation_() => 
		__Healthcare_professional__occupation_.Value;

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

	private CqlCode @virtual_Value() => 
		new CqlCode("VR", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);

    [CqlDeclaration("virtual")]
	public CqlCode @virtual() => 
		__virtual.Value;

	private CqlCode AMB_Value() => 
		new CqlCode("AMB", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default);

    [CqlDeclaration("AMB")]
	public CqlCode AMB() => 
		__AMB.Value;

	private CqlCode[] SNOMEDCT_Value()
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

    [CqlDeclaration("SNOMEDCT")]
	public CqlCode[] SNOMEDCT() => 
		__SNOMEDCT.Value;

	private CqlCode[] ActCode_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("VR", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default),
			new CqlCode("AMB", "http://terminology.hl7.org/CodeSystem/v3-ActCode", default, default),
		];

		return a_;
	}

    [CqlDeclaration("ActCode")]
	public CqlCode[] ActCode() => 
		__ActCode.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("DRCommunicationWithPhysicianManagingDiabetesFHIR-0.1.000", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period.Value;

	private Patient Patient_Value()
	{
		IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private (IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Value()
	{
		(IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_4_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public (IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Value()
	{
		IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_3_4_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer() => 
		__SDE_Payer.Value;

	private (IEnumerable<CqlCode> codes, string display)? SDE_Race_Value()
	{
		(IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_4_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public (IEnumerable<CqlCode> codes, string display)? SDE_Race() => 
		__SDE_Race.Value;

	private CqlCode SDE_Sex_Value()
	{
		CqlCode a_ = SupplementalDataElements_3_4_000.SDE_Sex();

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex() => 
		__SDE_Sex.Value;

	private IEnumerable<Encounter> Qualifying_Encounter_During_Measurement_Period_Value()
	{
		CqlValueSet a_ = this.Office_Visit();
		IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		CqlValueSet c_ = this.Ophthalmological_Services();
		IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
		CqlValueSet f_ = this.Outpatient_Consultation();
		IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		CqlValueSet h_ = this.Care_Services_in_Long_Term_Residential_Facility();
		IEnumerable<Encounter> i_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
		IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
		CqlValueSet l_ = this.Nursing_Facility_Visit();
		IEnumerable<Encounter> m_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> n_ = context.Operators.Union<Encounter>(k_, m_);
		bool? o_(Encounter QualifyingEncounter)
		{
			CqlInterval<CqlDateTime> q_ = this.Measurement_Period();
			Period r_ = QualifyingEncounter?.Period;
			CqlInterval<CqlDateTime> s_ = FHIRHelpers_4_3_000.ToInterval(r_);
			bool? t_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(q_, s_, default);
			Code<Encounter.EncounterStatus> u_ = QualifyingEncounter?.StatusElement;
			Encounter.EncounterStatus? v_ = u_?.Value;
			Code<Encounter.EncounterStatus> w_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(v_);
			bool? x_ = context.Operators.Equal(w_, "finished");
			bool? y_ = context.Operators.And(t_, x_);
			Coding z_ = QualifyingEncounter?.Class;
			CqlCode aa_ = FHIRHelpers_4_3_000.ToCode(z_);
			CqlCode ab_ = this.@virtual();
			bool? ac_ = context.Operators.Equivalent(aa_, ab_);
			bool? ad_ = context.Operators.Not(ac_);
			bool? ae_ = context.Operators.And(y_, ad_);

			return ae_;
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
			IEnumerable<Condition> e_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
			bool? f_(Condition DiabeticRetinopathy)
			{
				CqlInterval<CqlDateTime> j_ = QICoreCommon_2_0_000.prevalenceInterval(DiabeticRetinopathy);
				Period k_ = ValidQualifyingEncounter?.Period;
				CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_3_000.ToInterval(k_);
				bool? m_ = context.Operators.Overlaps(j_, l_, default);
				bool? n_ = QICoreCommon_2_0_000.isActive(DiabeticRetinopathy);
				bool? o_ = context.Operators.And(m_, n_);
				CodeableConcept p_ = DiabeticRetinopathy?.VerificationStatus;
				CqlConcept q_ = FHIRHelpers_4_3_000.ToConcept(p_);
				CqlCode r_ = QICoreCommon_2_0_000.unconfirmed();
				CqlConcept s_ = context.Operators.ConvertCodeToConcept(r_);
				bool? t_ = context.Operators.Equivalent(q_, s_);
				CqlConcept v_ = FHIRHelpers_4_3_000.ToConcept(p_);
				CqlCode w_ = QICoreCommon_2_0_000.refuted();
				CqlConcept x_ = context.Operators.ConvertCodeToConcept(w_);
				bool? y_ = context.Operators.Equivalent(v_, x_);
				bool? z_ = context.Operators.Or(t_, y_);
				CqlConcept ab_ = FHIRHelpers_4_3_000.ToConcept(p_);
				CqlCode ac_ = QICoreCommon_2_0_000.entered_in_error();
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

    [CqlDeclaration("Diabetic Retinopathy Encounter")]
	public IEnumerable<Encounter> Diabetic_Retinopathy_Encounter() => 
		__Diabetic_Retinopathy_Encounter.Value;

	private bool? Initial_Population_Value()
	{
		Patient a_ = this.Patient();
		Date b_ = a_?.BirthDateElement;
		string c_ = b_?.Value;
		CqlDate d_ = context.Operators.ConvertStringToDate(c_);
		CqlInterval<CqlDateTime> e_ = this.Measurement_Period();
		CqlDateTime f_ = context.Operators.Start(e_);
		CqlDate g_ = context.Operators.DateFrom(f_);
		int? h_ = context.Operators.CalculateAgeAt(d_, g_, "year");
		bool? i_ = context.Operators.GreaterOrEqual(h_, 18);
		IEnumerable<Encounter> j_ = this.Diabetic_Retinopathy_Encounter();
		bool? k_ = context.Operators.Exists<Encounter>(j_);
		bool? l_ = context.Operators.And(i_, k_);

		return l_;
	}

    [CqlDeclaration("Initial Population")]
	public bool? Initial_Population() => 
		__Initial_Population.Value;

	private IEnumerable<Observation> Macular_Exam_Performed_Value()
	{
		CqlValueSet a_ = this.Macular_Exam();
		IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
		IEnumerable<Observation> c_(Observation MacularExam)
		{
			IEnumerable<Encounter> g_ = this.Diabetic_Retinopathy_Encounter();
			bool? h_(Encounter EncounterDiabeticRetinopathy)
			{
				Period l_ = EncounterDiabeticRetinopathy?.Period;
				CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_3_000.ToInterval(l_);
				DataType n_ = MacularExam?.Effective;
				object o_ = FHIRHelpers_4_3_000.ToValue(n_);
				CqlInterval<CqlDateTime> p_ = QICoreCommon_2_0_000.toInterval(o_);
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
			object s_ = FHIRHelpers_4_3_000.ToValue(r_);
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
		PropertyInfo a_ = typeof(Communication).GetProperty("ReasonCode");
		CqlValueSet b_ = this.Level_of_Severity_of_Retinopathy_Findings();
		IEnumerable<Communication> c_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(a_, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-communication"));
		IEnumerable<Communication> d_(Communication LevelOfSeverityCommunicated)
		{
			IEnumerable<Encounter> h_ = this.Diabetic_Retinopathy_Encounter();
			bool? i_(Encounter EncounterDiabeticRetinopathy)
			{
				FhirDateTime m_ = LevelOfSeverityCommunicated?.SentElement;
				CqlDateTime n_ = context.Operators.Convert<CqlDateTime>(m_);
				Period o_ = EncounterDiabeticRetinopathy?.Period;
				CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_3_000.ToInterval(o_);
				CqlDateTime q_ = context.Operators.Start(p_);
				bool? r_ = context.Operators.After(n_, q_, default);
				CqlDateTime t_ = context.Operators.Convert<CqlDateTime>(m_);
				CqlInterval<CqlDateTime> u_ = this.Measurement_Period();
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

    [CqlDeclaration("Level of Severity of Retinopathy Findings Communicated")]
	public IEnumerable<Communication> Level_of_Severity_of_Retinopathy_Findings_Communicated() => 
		__Level_of_Severity_of_Retinopathy_Findings_Communicated.Value;

	private IEnumerable<Communication> Macular_Edema_Absence_Communicated_Value()
	{
		PropertyInfo a_ = typeof(Communication).GetProperty("ReasonCode");
		CqlValueSet b_ = this.Macular_edema_absent__situation_();
		IEnumerable<Communication> c_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(a_, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-communication"));
		IEnumerable<Communication> d_(Communication MacularEdemaAbsentCommunicated)
		{
			IEnumerable<Encounter> h_ = this.Diabetic_Retinopathy_Encounter();
			bool? i_(Encounter EncounterDiabeticRetinopathy)
			{
				FhirDateTime m_ = MacularEdemaAbsentCommunicated?.SentElement;
				CqlDateTime n_ = context.Operators.Convert<CqlDateTime>(m_);
				Period o_ = EncounterDiabeticRetinopathy?.Period;
				CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_3_000.ToInterval(o_);
				CqlDateTime q_ = context.Operators.Start(p_);
				bool? r_ = context.Operators.After(n_, q_, default);
				CqlDateTime t_ = context.Operators.Convert<CqlDateTime>(m_);
				CqlInterval<CqlDateTime> u_ = this.Measurement_Period();
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

    [CqlDeclaration("Macular Edema Absence Communicated")]
	public IEnumerable<Communication> Macular_Edema_Absence_Communicated() => 
		__Macular_Edema_Absence_Communicated.Value;

	private IEnumerable<Communication> Macular_Edema_Presence_Communicated_Value()
	{
		PropertyInfo a_ = typeof(Communication).GetProperty("ReasonCode");
		CqlValueSet b_ = this.Macular_Edema_Findings_Present();
		IEnumerable<Communication> c_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(a_, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-communication"));
		IEnumerable<Communication> d_(Communication MacularEdemaPresentCommunicated)
		{
			IEnumerable<Encounter> h_ = this.Diabetic_Retinopathy_Encounter();
			bool? i_(Encounter EncounterDiabeticRetinopathy)
			{
				FhirDateTime m_ = MacularEdemaPresentCommunicated?.SentElement;
				CqlDateTime n_ = context.Operators.Convert<CqlDateTime>(m_);
				Period o_ = EncounterDiabeticRetinopathy?.Period;
				CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_3_000.ToInterval(o_);
				CqlDateTime q_ = context.Operators.Start(p_);
				bool? r_ = context.Operators.After(n_, q_, default);
				CqlDateTime t_ = context.Operators.Convert<CqlDateTime>(m_);
				CqlInterval<CqlDateTime> u_ = this.Measurement_Period();
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

    [CqlDeclaration("Macular Edema Presence Communicated")]
	public IEnumerable<Communication> Macular_Edema_Presence_Communicated() => 
		__Macular_Edema_Presence_Communicated.Value;

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

	private IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy_Value()
	{
		PropertyInfo a_ = typeof(Communication).GetProperty("ReasonCode");
		CqlValueSet b_ = this.Level_of_Severity_of_Retinopathy_Findings();
		IEnumerable<Communication> c_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(a_, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-communicationnotdone"));
		IEnumerable<Communication> f_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(a_, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-communicationnotdone"));
		IEnumerable<Communication> g_ = context.Operators.Union<Communication>(c_, f_);
		IEnumerable<Communication> h_(Communication LevelOfSeverityNotCommunicated)
		{
			IEnumerable<Encounter> l_ = this.Diabetic_Retinopathy_Encounter();
			bool? m_(Encounter EncounterDiabeticRetinopathy)
			{
				bool? q_(Extension @this)
				{
					string z_ = @this?.Url;
					FhirString aa_ = context.Operators.Convert<FhirString>(z_);
					string ab_ = FHIRHelpers_4_3_000.ToString(aa_);
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
				CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_3_000.ToInterval(w_);
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
			CqlConcept af_ = FHIRHelpers_4_3_000.ToConcept(ae_);
			CqlValueSet ag_ = this.Medical_Reason();
			bool? ah_ = context.Operators.ConceptInValueSet(af_, ag_);
			CqlConcept aj_ = FHIRHelpers_4_3_000.ToConcept(ae_);
			CqlValueSet ak_ = this.Patient_Reason();
			bool? al_ = context.Operators.ConceptInValueSet(aj_, ak_);
			bool? am_ = context.Operators.Or(ah_, al_);

			return am_;
		};
		IEnumerable<Communication> k_ = context.Operators.Where<Communication>(i_, j_);

		return k_;
	}

    [CqlDeclaration("Medical or Patient Reason for Not Communicating Level of Severity of Retinopathy")]
	public IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy() => 
		__Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy.Value;

	private IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema_Value()
	{
		PropertyInfo a_ = typeof(Communication).GetProperty("ReasonCode");
		CqlValueSet b_ = this.Macular_edema_absent__situation_();
		IEnumerable<Communication> c_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(a_, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-communicationnotdone"));
		IEnumerable<Communication> f_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(a_, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-communicationnotdone"));
		IEnumerable<Communication> g_ = context.Operators.Union<Communication>(c_, f_);
		IEnumerable<Communication> h_(Communication MacularEdemaAbsentNotCommunicated)
		{
			IEnumerable<Encounter> l_ = this.Diabetic_Retinopathy_Encounter();
			bool? m_(Encounter EncounterDiabeticRetinopathy)
			{
				bool? q_(Extension @this)
				{
					string z_ = @this?.Url;
					FhirString aa_ = context.Operators.Convert<FhirString>(z_);
					string ab_ = FHIRHelpers_4_3_000.ToString(aa_);
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
				CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_3_000.ToInterval(w_);
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
			CqlConcept af_ = FHIRHelpers_4_3_000.ToConcept(ae_);
			CqlValueSet ag_ = this.Medical_Reason();
			bool? ah_ = context.Operators.ConceptInValueSet(af_, ag_);
			CqlConcept aj_ = FHIRHelpers_4_3_000.ToConcept(ae_);
			CqlValueSet ak_ = this.Patient_Reason();
			bool? al_ = context.Operators.ConceptInValueSet(aj_, ak_);
			bool? am_ = context.Operators.Or(ah_, al_);

			return am_;
		};
		IEnumerable<Communication> k_ = context.Operators.Where<Communication>(i_, j_);

		return k_;
	}

    [CqlDeclaration("Medical or Patient Reason for Not Communicating Absence of Macular Edema")]
	public IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema() => 
		__Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema.Value;

	private IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Presence_of_Macular_Edema_Value()
	{
		PropertyInfo a_ = typeof(Communication).GetProperty("ReasonCode");
		CqlValueSet b_ = this.Macular_Edema_Findings_Present();
		IEnumerable<Communication> c_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(a_, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-communicationnotdone"));
		IEnumerable<Communication> f_ = context.Operators.Retrieve<Communication>(new RetrieveParameters(a_, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-communicationnotdone"));
		IEnumerable<Communication> g_ = context.Operators.Union<Communication>(c_, f_);
		IEnumerable<Communication> h_(Communication MacularEdemaPresentNotCommunicated)
		{
			IEnumerable<Encounter> l_ = this.Diabetic_Retinopathy_Encounter();
			bool? m_(Encounter EncounterDiabeticRetinopathy)
			{
				bool? q_(Extension @this)
				{
					string z_ = @this?.Url;
					FhirString aa_ = context.Operators.Convert<FhirString>(z_);
					string ab_ = FHIRHelpers_4_3_000.ToString(aa_);
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
				CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_3_000.ToInterval(w_);
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
			CqlConcept af_ = FHIRHelpers_4_3_000.ToConcept(ae_);
			CqlValueSet ag_ = this.Medical_Reason();
			bool? ah_ = context.Operators.ConceptInValueSet(af_, ag_);
			CqlConcept aj_ = FHIRHelpers_4_3_000.ToConcept(ae_);
			CqlValueSet ak_ = this.Patient_Reason();
			bool? al_ = context.Operators.ConceptInValueSet(aj_, ak_);
			bool? am_ = context.Operators.Or(ah_, al_);

			return am_;
		};
		IEnumerable<Communication> k_ = context.Operators.Where<Communication>(i_, j_);

		return k_;
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

}
