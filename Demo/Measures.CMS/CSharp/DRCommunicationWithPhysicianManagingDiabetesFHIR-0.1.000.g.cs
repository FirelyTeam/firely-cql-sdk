using System;
using Tuples;
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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.0.0")]
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
    internal Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ>> __SDE_Payer;
    internal Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR> __SDE_Race;
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
        __SDE_Ethnicity = new Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR>(this.SDE_Race_Value);
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

	private CqlValueSet Macular_edema_absent__situation__Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.2.1391", null);

    [CqlDeclaration("Macular edema absent (situation)")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.2.1391")]
	public CqlValueSet Macular_edema_absent__situation_() => 
		__Macular_edema_absent__situation_.Value;

	private CqlCode Healthcare_professional__occupation__Value() => 
		new CqlCode("223366009", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Healthcare professional (occupation)")]
	public CqlCode Healthcare_professional__occupation_() => 
		__Healthcare_professional__occupation_.Value;

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

	private CqlCode @virtual_Value() => 
		new CqlCode("VR", "http://terminology.hl7.org/CodeSystem/v3-ActCode", null, null);

    [CqlDeclaration("virtual")]
	public CqlCode @virtual() => 
		__virtual.Value;

	private CqlCode AMB_Value() => 
		new CqlCode("AMB", "http://terminology.hl7.org/CodeSystem/v3-ActCode", null, null);

    [CqlDeclaration("AMB")]
	public CqlCode AMB() => 
		__AMB.Value;

	private CqlCode[] SNOMEDCT_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("223366009", "http://snomed.info/sct", null, null),
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

	private CqlCode[] ActCode_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("VR", "http://terminology.hl7.org/CodeSystem/v3-ActCode", null, null),
			new CqlCode("AMB", "http://terminology.hl7.org/CodeSystem/v3-ActCode", null, null),
		};

		return a_;
	}

    [CqlDeclaration("ActCode")]
	public CqlCode[] ActCode() => 
		__ActCode.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		var b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		var c_ = context.Operators.Interval(a_, b_, true, false);
		var d_ = context.ResolveParameter("DRCommunicationWithPhysicianManagingDiabetesFHIR-0.1.000", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period.Value;

	private Patient Patient_Value()
	{
		var a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		var b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private Tuple_HPcCiDPXQfZTXIORThMLfTQDR SDE_Ethnicity_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public Tuple_HPcCiDPXQfZTXIORThMLfTQDR SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ> SDE_Payer_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ> SDE_Payer() => 
		__SDE_Payer.Value;

	private Tuple_HPcCiDPXQfZTXIORThMLfTQDR SDE_Race_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public Tuple_HPcCiDPXQfZTXIORThMLfTQDR SDE_Race() => 
		__SDE_Race.Value;

	private CqlCode SDE_Sex_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Sex();

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
		var e_ = context.Operators.Union<Encounter>(b_, d_);
		var f_ = this.Outpatient_Consultation();
		var g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, null);
		var h_ = this.Care_Services_in_Long_Term_Residential_Facility();
		var i_ = context.Operators.RetrieveByValueSet<Encounter>(h_, null);
		var j_ = context.Operators.Union<Encounter>(g_, i_);
		var k_ = context.Operators.Union<Encounter>(e_, j_);
		var l_ = this.Nursing_Facility_Visit();
		var m_ = context.Operators.RetrieveByValueSet<Encounter>(l_, null);
		var n_ = context.Operators.Union<Encounter>(k_, m_);
		bool? o_(Encounter QualifyingEncounter)
		{
			var q_ = this.Measurement_Period();
			var r_ = QualifyingEncounter?.Period;
			var s_ = FHIRHelpers_4_3_000.ToInterval(r_);
			var t_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(q_, s_, null);
			var u_ = QualifyingEncounter?.StatusElement;
			var v_ = u_?.Value;
			var w_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(v_);
			var x_ = context.Operators.Equal(w_, "finished");
			var y_ = context.Operators.And(t_, x_);
			var z_ = QualifyingEncounter?.Class;
			var aa_ = FHIRHelpers_4_3_000.ToCode(z_);
			var ab_ = this.@virtual();
			var ac_ = context.Operators.Equivalent(aa_, ab_);
			var ad_ = context.Operators.Not(ac_);
			var ae_ = context.Operators.And(y_, ad_);

			return ae_;
		};
		var p_ = context.Operators.Where<Encounter>(n_, o_);

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
				var j_ = QICoreCommon_2_0_000.prevalenceInterval(DiabeticRetinopathy);
				var k_ = ValidQualifyingEncounter?.Period;
				var l_ = FHIRHelpers_4_3_000.ToInterval(k_);
				var m_ = context.Operators.Overlaps(j_, l_, null);
				var n_ = QICoreCommon_2_0_000.isActive(DiabeticRetinopathy);
				var o_ = context.Operators.And(m_, n_);
				var p_ = DiabeticRetinopathy?.VerificationStatus;
				var q_ = FHIRHelpers_4_3_000.ToConcept(p_);
				var r_ = QICoreCommon_2_0_000.unconfirmed();
				var s_ = context.Operators.ConvertCodeToConcept(r_);
				var t_ = context.Operators.Equivalent(q_, s_);
				var v_ = FHIRHelpers_4_3_000.ToConcept(p_);
				var w_ = QICoreCommon_2_0_000.refuted();
				var x_ = context.Operators.ConvertCodeToConcept(w_);
				var y_ = context.Operators.Equivalent(v_, x_);
				var z_ = context.Operators.Or(t_, y_);
				var ab_ = FHIRHelpers_4_3_000.ToConcept(p_);
				var ac_ = QICoreCommon_2_0_000.entered_in_error();
				var ad_ = context.Operators.ConvertCodeToConcept(ac_);
				var ae_ = context.Operators.Equivalent(ab_, ad_);
				var af_ = context.Operators.Or(z_, ae_);
				var ag_ = context.Operators.Not(af_);
				var ah_ = context.Operators.And(o_, ag_);

				return ah_;
			};
			var g_ = context.Operators.Where<Condition>(e_, f_);
			Encounter h_(Condition DiabeticRetinopathy) => 
				ValidQualifyingEncounter;
			var i_ = context.Operators.Select<Condition, Encounter>(g_, h_);

			return i_;
		};
		var c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Diabetic Retinopathy Encounter")]
	public IEnumerable<Encounter> Diabetic_Retinopathy_Encounter() => 
		__Diabetic_Retinopathy_Encounter.Value;

	private bool? Initial_Population_Value()
	{
		var a_ = this.Patient();
		var b_ = context.Operators.Convert<CqlDate>(a_?.BirthDateElement?.Value);
		var c_ = this.Measurement_Period();
		var d_ = context.Operators.Start(c_);
		var e_ = context.Operators.DateFrom(d_);
		var f_ = context.Operators.CalculateAgeAt(b_, e_, "year");
		var g_ = context.Operators.GreaterOrEqual(f_, 18);
		var h_ = this.Diabetic_Retinopathy_Encounter();
		var i_ = context.Operators.Exists<Encounter>(h_);
		var j_ = context.Operators.And(g_, i_);

		return j_;
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
				var m_ = FHIRHelpers_4_3_000.ToInterval(l_);
				var n_ = MacularExam?.Effective;
				var o_ = FHIRHelpers_4_3_000.ToValue(n_);
				var p_ = QICoreCommon_2_0_000.toInterval(o_);
				var q_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(m_, p_, null);

				return q_;
			};
			var i_ = context.Operators.Where<Encounter>(g_, h_);
			Observation j_(Encounter EncounterDiabeticRetinopathy) => 
				MacularExam;
			var k_ = context.Operators.Select<Encounter, Observation>(i_, j_);

			return k_;
		};
		var d_ = context.Operators.SelectMany<Observation, Observation>(b_, c_);
		bool? e_(Observation MacularExam)
		{
			var r_ = MacularExam?.Value;
			var s_ = FHIRHelpers_4_3_000.ToValue(r_);
			var t_ = context.Operators.Not((bool?)(s_ is null));
			var u_ = MacularExam?.StatusElement;
			var v_ = u_?.Value;
			var w_ = context.Operators.Convert<Code<ObservationStatus>>(v_);
			var x_ = context.Operators.Convert<string>(w_);
			var y_ = new string[]
			{
				"final",
				"amended",
				"corrected",
				"preliminary",
			};
			var z_ = context.Operators.In<string>(x_, (y_ as IEnumerable<string>));
			var aa_ = context.Operators.And(t_, z_);

			return aa_;
		};
		var f_ = context.Operators.Where<Observation>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Macular Exam Performed")]
	public IEnumerable<Observation> Macular_Exam_Performed() => 
		__Macular_Exam_Performed.Value;

	private bool? Denominator_Value()
	{
		var a_ = this.Initial_Population();
		var b_ = this.Macular_Exam_Performed();
		var c_ = context.Operators.Exists<Observation>(b_);
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
				var n_ = context.Operators.Convert<CqlDateTime>(m_);
				var o_ = EncounterDiabeticRetinopathy?.Period;
				var p_ = FHIRHelpers_4_3_000.ToInterval(o_);
				var q_ = context.Operators.Start(p_);
				var r_ = context.Operators.After(n_, q_, null);
				var t_ = context.Operators.Convert<CqlDateTime>(m_);
				var u_ = this.Measurement_Period();
				var v_ = context.Operators.In<CqlDateTime>(t_, u_, "day");
				var w_ = context.Operators.And(r_, v_);

				return w_;
			};
			var j_ = context.Operators.Where<Encounter>(h_, i_);
			Communication k_(Encounter EncounterDiabeticRetinopathy) => 
				LevelOfSeverityCommunicated;
			var l_ = context.Operators.Select<Encounter, Communication>(j_, k_);

			return l_;
		};
		var e_ = context.Operators.SelectMany<Communication, Communication>(c_, d_);
		bool? f_(Communication LevelOfSeverityCommunicated)
		{
			var x_ = LevelOfSeverityCommunicated?.StatusElement;
			var y_ = x_?.Value;
			var z_ = context.Operators.Convert<Code<EventStatus>>(y_);
			var aa_ = context.Operators.Equal(z_, "completed");

			return aa_;
		};
		var g_ = context.Operators.Where<Communication>(e_, f_);

		return g_;
	}

    [CqlDeclaration("Level of Severity of Retinopathy Findings Communicated")]
	public IEnumerable<Communication> Level_of_Severity_of_Retinopathy_Findings_Communicated() => 
		__Level_of_Severity_of_Retinopathy_Findings_Communicated.Value;

	private IEnumerable<Communication> Macular_Edema_Absence_Communicated_Value()
	{
		var a_ = this.Macular_edema_absent__situation_();
		var b_ = typeof(Communication).GetProperty("ReasonCode");
		var c_ = context.Operators.RetrieveByValueSet<Communication>(a_, b_);
		IEnumerable<Communication> d_(Communication MacularEdemaAbsentCommunicated)
		{
			var h_ = this.Diabetic_Retinopathy_Encounter();
			bool? i_(Encounter EncounterDiabeticRetinopathy)
			{
				var m_ = MacularEdemaAbsentCommunicated?.SentElement;
				var n_ = context.Operators.Convert<CqlDateTime>(m_);
				var o_ = EncounterDiabeticRetinopathy?.Period;
				var p_ = FHIRHelpers_4_3_000.ToInterval(o_);
				var q_ = context.Operators.Start(p_);
				var r_ = context.Operators.After(n_, q_, null);
				var t_ = context.Operators.Convert<CqlDateTime>(m_);
				var u_ = this.Measurement_Period();
				var v_ = context.Operators.In<CqlDateTime>(t_, u_, "day");
				var w_ = context.Operators.And(r_, v_);

				return w_;
			};
			var j_ = context.Operators.Where<Encounter>(h_, i_);
			Communication k_(Encounter EncounterDiabeticRetinopathy) => 
				MacularEdemaAbsentCommunicated;
			var l_ = context.Operators.Select<Encounter, Communication>(j_, k_);

			return l_;
		};
		var e_ = context.Operators.SelectMany<Communication, Communication>(c_, d_);
		bool? f_(Communication MacularEdemaAbsentCommunicated)
		{
			var x_ = MacularEdemaAbsentCommunicated?.StatusElement;
			var y_ = x_?.Value;
			var z_ = context.Operators.Convert<Code<EventStatus>>(y_);
			var aa_ = context.Operators.Equal(z_, "completed");

			return aa_;
		};
		var g_ = context.Operators.Where<Communication>(e_, f_);

		return g_;
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
				var n_ = context.Operators.Convert<CqlDateTime>(m_);
				var o_ = EncounterDiabeticRetinopathy?.Period;
				var p_ = FHIRHelpers_4_3_000.ToInterval(o_);
				var q_ = context.Operators.Start(p_);
				var r_ = context.Operators.After(n_, q_, null);
				var t_ = context.Operators.Convert<CqlDateTime>(m_);
				var u_ = this.Measurement_Period();
				var v_ = context.Operators.In<CqlDateTime>(t_, u_, "day");
				var w_ = context.Operators.And(r_, v_);

				return w_;
			};
			var j_ = context.Operators.Where<Encounter>(h_, i_);
			Communication k_(Encounter EncounterDiabeticRetinopathy) => 
				MacularEdemaPresentCommunicated;
			var l_ = context.Operators.Select<Encounter, Communication>(j_, k_);

			return l_;
		};
		var e_ = context.Operators.SelectMany<Communication, Communication>(c_, d_);
		bool? f_(Communication MacularEdemaPresentCommunicated)
		{
			var x_ = MacularEdemaPresentCommunicated?.StatusElement;
			var y_ = x_?.Value;
			var z_ = context.Operators.Convert<Code<EventStatus>>(y_);
			var aa_ = context.Operators.Equal(z_, "completed");

			return aa_;
		};
		var g_ = context.Operators.Where<Communication>(e_, f_);

		return g_;
	}

    [CqlDeclaration("Macular Edema Presence Communicated")]
	public IEnumerable<Communication> Macular_Edema_Presence_Communicated() => 
		__Macular_Edema_Presence_Communicated.Value;

	private bool? Numerator_Value()
	{
		var a_ = this.Level_of_Severity_of_Retinopathy_Findings_Communicated();
		var b_ = context.Operators.Exists<Communication>(a_);
		var c_ = this.Macular_Edema_Absence_Communicated();
		var d_ = context.Operators.Exists<Communication>(c_);
		var e_ = this.Macular_Edema_Presence_Communicated();
		var f_ = context.Operators.Exists<Communication>(e_);
		var g_ = context.Operators.Or(d_, f_);
		var h_ = context.Operators.And(b_, g_);

		return h_;
	}

    [CqlDeclaration("Numerator")]
	public bool? Numerator() => 
		__Numerator.Value;

	private IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy_Value()
	{
		var a_ = this.Level_of_Severity_of_Retinopathy_Findings();
		var b_ = typeof(Communication).GetProperty("ReasonCode");
		var c_ = context.Operators.RetrieveByValueSet<Communication>(a_, b_);
		var f_ = context.Operators.RetrieveByValueSet<Communication>(a_, b_);
		var g_ = context.Operators.Union<Communication>(c_, f_);
		IEnumerable<Communication> h_(Communication LevelOfSeverityNotCommunicated)
		{
			var l_ = this.Diabetic_Retinopathy_Encounter();
			bool? m_(Encounter EncounterDiabeticRetinopathy)
			{
				bool? q_(Extension @this)
				{
					var z_ = @this?.Url;
					var aa_ = context.Operators.Convert<FhirUri>(z_);
					var ab_ = FHIRHelpers_4_3_000.ToString(aa_);
					var ac_ = context.Operators.Equal(ab_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");

					return ac_;
				};
				var r_ = context.Operators.Where<Extension>((IEnumerable<Extension>)((LevelOfSeverityNotCommunicated is DomainResource)
						? ((LevelOfSeverityNotCommunicated as DomainResource).Extension)
						: null), q_);
				DataType s_(Extension @this)
				{
					var ad_ = @this?.Value;

					return ad_;
				};
				var t_ = context.Operators.Select<Extension, DataType>(r_, s_);
				var u_ = context.Operators.SingletonFrom<DataType>(t_);
				var v_ = context.Operators.Convert<CqlDateTime>(u_);
				var w_ = EncounterDiabeticRetinopathy?.Period;
				var x_ = FHIRHelpers_4_3_000.ToInterval(w_);
				var y_ = context.Operators.In<CqlDateTime>(v_, x_, null);

				return y_;
			};
			var n_ = context.Operators.Where<Encounter>(l_, m_);
			Communication o_(Encounter EncounterDiabeticRetinopathy) => 
				LevelOfSeverityNotCommunicated;
			var p_ = context.Operators.Select<Encounter, Communication>(n_, o_);

			return p_;
		};
		var i_ = context.Operators.SelectMany<Communication, Communication>(g_, h_);
		bool? j_(Communication LevelOfSeverityNotCommunicated)
		{
			var ae_ = LevelOfSeverityNotCommunicated?.StatusReason;
			var af_ = FHIRHelpers_4_3_000.ToConcept(ae_);
			var ag_ = this.Medical_Reason();
			var ah_ = context.Operators.ConceptInValueSet(af_, ag_);
			var aj_ = FHIRHelpers_4_3_000.ToConcept(ae_);
			var ak_ = this.Patient_Reason();
			var al_ = context.Operators.ConceptInValueSet(aj_, ak_);
			var am_ = context.Operators.Or(ah_, al_);

			return am_;
		};
		var k_ = context.Operators.Where<Communication>(i_, j_);

		return k_;
	}

    [CqlDeclaration("Medical or Patient Reason for Not Communicating Level of Severity of Retinopathy")]
	public IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy() => 
		__Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy.Value;

	private IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema_Value()
	{
		var a_ = this.Macular_edema_absent__situation_();
		var b_ = typeof(Communication).GetProperty("ReasonCode");
		var c_ = context.Operators.RetrieveByValueSet<Communication>(a_, b_);
		var f_ = context.Operators.RetrieveByValueSet<Communication>(a_, b_);
		var g_ = context.Operators.Union<Communication>(c_, f_);
		IEnumerable<Communication> h_(Communication MacularEdemaAbsentNotCommunicated)
		{
			var l_ = this.Diabetic_Retinopathy_Encounter();
			bool? m_(Encounter EncounterDiabeticRetinopathy)
			{
				bool? q_(Extension @this)
				{
					var z_ = @this?.Url;
					var aa_ = context.Operators.Convert<FhirUri>(z_);
					var ab_ = FHIRHelpers_4_3_000.ToString(aa_);
					var ac_ = context.Operators.Equal(ab_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");

					return ac_;
				};
				var r_ = context.Operators.Where<Extension>((IEnumerable<Extension>)((MacularEdemaAbsentNotCommunicated is DomainResource)
						? ((MacularEdemaAbsentNotCommunicated as DomainResource).Extension)
						: null), q_);
				DataType s_(Extension @this)
				{
					var ad_ = @this?.Value;

					return ad_;
				};
				var t_ = context.Operators.Select<Extension, DataType>(r_, s_);
				var u_ = context.Operators.SingletonFrom<DataType>(t_);
				var v_ = context.Operators.Convert<CqlDateTime>(u_);
				var w_ = EncounterDiabeticRetinopathy?.Period;
				var x_ = FHIRHelpers_4_3_000.ToInterval(w_);
				var y_ = context.Operators.In<CqlDateTime>(v_, x_, null);

				return y_;
			};
			var n_ = context.Operators.Where<Encounter>(l_, m_);
			Communication o_(Encounter EncounterDiabeticRetinopathy) => 
				MacularEdemaAbsentNotCommunicated;
			var p_ = context.Operators.Select<Encounter, Communication>(n_, o_);

			return p_;
		};
		var i_ = context.Operators.SelectMany<Communication, Communication>(g_, h_);
		bool? j_(Communication MacularEdemaAbsentNotCommunicated)
		{
			var ae_ = MacularEdemaAbsentNotCommunicated?.StatusReason;
			var af_ = FHIRHelpers_4_3_000.ToConcept(ae_);
			var ag_ = this.Medical_Reason();
			var ah_ = context.Operators.ConceptInValueSet(af_, ag_);
			var aj_ = FHIRHelpers_4_3_000.ToConcept(ae_);
			var ak_ = this.Patient_Reason();
			var al_ = context.Operators.ConceptInValueSet(aj_, ak_);
			var am_ = context.Operators.Or(ah_, al_);

			return am_;
		};
		var k_ = context.Operators.Where<Communication>(i_, j_);

		return k_;
	}

    [CqlDeclaration("Medical or Patient Reason for Not Communicating Absence of Macular Edema")]
	public IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema() => 
		__Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema.Value;

	private IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Presence_of_Macular_Edema_Value()
	{
		var a_ = this.Macular_Edema_Findings_Present();
		var b_ = typeof(Communication).GetProperty("ReasonCode");
		var c_ = context.Operators.RetrieveByValueSet<Communication>(a_, b_);
		var f_ = context.Operators.RetrieveByValueSet<Communication>(a_, b_);
		var g_ = context.Operators.Union<Communication>(c_, f_);
		IEnumerable<Communication> h_(Communication MacularEdemaPresentNotCommunicated)
		{
			var l_ = this.Diabetic_Retinopathy_Encounter();
			bool? m_(Encounter EncounterDiabeticRetinopathy)
			{
				bool? q_(Extension @this)
				{
					var z_ = @this?.Url;
					var aa_ = context.Operators.Convert<FhirUri>(z_);
					var ab_ = FHIRHelpers_4_3_000.ToString(aa_);
					var ac_ = context.Operators.Equal(ab_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");

					return ac_;
				};
				var r_ = context.Operators.Where<Extension>((IEnumerable<Extension>)((MacularEdemaPresentNotCommunicated is DomainResource)
						? ((MacularEdemaPresentNotCommunicated as DomainResource).Extension)
						: null), q_);
				DataType s_(Extension @this)
				{
					var ad_ = @this?.Value;

					return ad_;
				};
				var t_ = context.Operators.Select<Extension, DataType>(r_, s_);
				var u_ = context.Operators.SingletonFrom<DataType>(t_);
				var v_ = context.Operators.Convert<CqlDateTime>(u_);
				var w_ = EncounterDiabeticRetinopathy?.Period;
				var x_ = FHIRHelpers_4_3_000.ToInterval(w_);
				var y_ = context.Operators.In<CqlDateTime>(v_, x_, null);

				return y_;
			};
			var n_ = context.Operators.Where<Encounter>(l_, m_);
			Communication o_(Encounter EncounterDiabeticRetinopathy) => 
				MacularEdemaPresentNotCommunicated;
			var p_ = context.Operators.Select<Encounter, Communication>(n_, o_);

			return p_;
		};
		var i_ = context.Operators.SelectMany<Communication, Communication>(g_, h_);
		bool? j_(Communication MacularEdemaPresentNotCommunicated)
		{
			var ae_ = MacularEdemaPresentNotCommunicated?.StatusReason;
			var af_ = FHIRHelpers_4_3_000.ToConcept(ae_);
			var ag_ = this.Medical_Reason();
			var ah_ = context.Operators.ConceptInValueSet(af_, ag_);
			var aj_ = FHIRHelpers_4_3_000.ToConcept(ae_);
			var ak_ = this.Patient_Reason();
			var al_ = context.Operators.ConceptInValueSet(aj_, ak_);
			var am_ = context.Operators.Or(ah_, al_);

			return am_;
		};
		var k_ = context.Operators.Where<Communication>(i_, j_);

		return k_;
	}

    [CqlDeclaration("Medical or Patient Reason for Not Communicating Presence of Macular Edema")]
	public IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Presence_of_Macular_Edema() => 
		__Medical_or_Patient_Reason_for_Not_Communicating_Presence_of_Macular_Edema.Value;

	private bool? Denominator_Exceptions_Value()
	{
		var a_ = this.Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy();
		var b_ = context.Operators.Exists<Communication>(a_);
		var c_ = this.Medical_or_Patient_Reason_for_Not_Communicating_Absence_of_Macular_Edema();
		var d_ = context.Operators.Exists<Communication>(c_);
		var e_ = context.Operators.Or(b_, d_);
		var f_ = this.Medical_or_Patient_Reason_for_Not_Communicating_Presence_of_Macular_Edema();
		var g_ = context.Operators.Exists<Communication>(f_);
		var h_ = context.Operators.Or(e_, g_);

		return h_;
	}

    [CqlDeclaration("Denominator Exceptions")]
	public bool? Denominator_Exceptions() => 
		__Denominator_Exceptions.Value;

	private bool? Results_of_Dilated_Macular_or_Fundus_Exam_Communicated_Value()
	{
		var a_ = this.Level_of_Severity_of_Retinopathy_Findings_Communicated();
		var b_ = context.Operators.Exists<Communication>(a_);
		var c_ = this.Macular_Edema_Absence_Communicated();
		var d_ = context.Operators.Exists<Communication>(c_);
		var e_ = this.Macular_Edema_Presence_Communicated();
		var f_ = context.Operators.Exists<Communication>(e_);
		var g_ = context.Operators.Or(d_, f_);
		var h_ = context.Operators.And(b_, g_);

		return h_;
	}

    [CqlDeclaration("Results of Dilated Macular or Fundus Exam Communicated")]
	public bool? Results_of_Dilated_Macular_or_Fundus_Exam_Communicated() => 
		__Results_of_Dilated_Macular_or_Fundus_Exam_Communicated.Value;

}
