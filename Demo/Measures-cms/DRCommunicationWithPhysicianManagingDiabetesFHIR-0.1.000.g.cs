﻿using System;
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
    internal Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuples.Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>> __SDE_Payer;
    internal Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Race;
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
        __SDE_Ethnicity = new Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuples.Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Race_Value);
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
		var a_ = context.Operators.ConvertIntegerToDecimal(default);
		var b_ = context.Operators.DateTime((int?)2025, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, a_);
		var d_ = context.Operators.DateTime((int?)2026, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, a_);
		var e_ = context.Operators.Interval(b_, d_, true, false);
		var f_ = context.ResolveParameter("DRCommunicationWithPhysicianManagingDiabetesFHIR-0.1.000", "Measurement Period", e_);

		return (CqlInterval<CqlDateTime>)f_;
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

	private Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Ethnicity_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private IEnumerable<Tuples.Tuple_GDKRbfOIHhLGieQSVDEMIaDPX> SDE_Payer_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<Tuples.Tuple_GDKRbfOIHhLGieQSVDEMIaDPX> SDE_Payer() => 
		__SDE_Payer.Value;

	private Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Race_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Race() => 
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
			var r_ = FHIRHelpers_4_3_000.ToInterval(QualifyingEncounter?.Period);
			var s_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(q_, r_, null);
			var t_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(QualifyingEncounter?.StatusElement?.Value);
			var u_ = context.Operators.Equal(t_, "finished");
			var v_ = context.Operators.And(s_, u_);
			var w_ = FHIRHelpers_4_3_000.ToCode(QualifyingEncounter?.Class);
			var x_ = this.@virtual();
			var y_ = context.Operators.Equivalent(w_, x_);
			var z_ = context.Operators.Not(y_);
			var aa_ = context.Operators.And(v_, z_);

			return aa_;
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
				var j_ = QICoreCommon_2_0_000.prevalenceInterval(DiabeticRetinopathy);
				var k_ = FHIRHelpers_4_3_000.ToInterval(ValidQualifyingEncounter?.Period);
				var l_ = context.Operators.Overlaps(j_, k_, null);
				var m_ = QICoreCommon_2_0_000.isActive(DiabeticRetinopathy);
				var n_ = context.Operators.And(l_, m_);
				var o_ = FHIRHelpers_4_3_000.ToConcept(DiabeticRetinopathy?.VerificationStatus);
				var p_ = QICoreCommon_2_0_000.unconfirmed();
				var q_ = context.Operators.ConvertCodeToConcept(p_);
				var r_ = context.Operators.Equivalent(o_, q_);
				var t_ = QICoreCommon_2_0_000.refuted();
				var u_ = context.Operators.ConvertCodeToConcept(t_);
				var v_ = context.Operators.Equivalent(o_, u_);
				var w_ = context.Operators.Or(r_, v_);
				var y_ = QICoreCommon_2_0_000.entered_in_error();
				var z_ = context.Operators.ConvertCodeToConcept(y_);
				var aa_ = context.Operators.Equivalent(o_, z_);
				var ab_ = context.Operators.Or(w_, aa_);
				var ac_ = context.Operators.Not(ab_);
				var ad_ = context.Operators.And(n_, ac_);

				return ad_;
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

	private bool? Initial_Population_Value()
	{
		var a_ = this.Patient();
		var b_ = context.Operators.Convert<CqlDate>(a_?.BirthDateElement?.Value);
		var c_ = this.Measurement_Period();
		var d_ = context.Operators.Start(c_);
		var e_ = context.Operators.DateFrom(d_);
		var f_ = context.Operators.CalculateAgeAt(b_, e_, "year");
		var g_ = context.Operators.GreaterOrEqual(f_, (int?)18);
		var h_ = this.Diabetic_Retinopathy_Encounter();
		var i_ = context.Operators.ExistsInList<Encounter>(h_);
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
				var l_ = FHIRHelpers_4_3_000.ToInterval(EncounterDiabeticRetinopathy?.Period);
				var m_ = FHIRHelpers_4_3_000.ToValue(MacularExam?.Effective);
				var n_ = QICoreCommon_2_0_000.toInterval(m_);
				var o_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(l_, n_, null);

				return o_;
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
			var p_ = FHIRHelpers_4_3_000.ToValue(MacularExam?.Value);
			var q_ = context.Operators.Not((bool?)(p_ is null));
			var r_ = context.Operators.Convert<Code<ObservationStatus>>(MacularExam?.StatusElement?.Value);
			var s_ = context.Operators.Convert<string>(r_);
			var t_ = new string[]
			{
				"final",
				"amended",
				"corrected",
				"preliminary",
			};
			var u_ = context.Operators.InList<string>(s_, (t_ as IEnumerable<string>));
			var v_ = context.Operators.And(q_, u_);

			return v_;
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
				var m_ = context.Operators.Convert<CqlDateTime>(LevelOfSeverityCommunicated?.SentElement);
				var n_ = FHIRHelpers_4_3_000.ToInterval(EncounterDiabeticRetinopathy?.Period);
				var o_ = context.Operators.Start(n_);
				var p_ = context.Operators.After(m_, o_, null);
				var r_ = this.Measurement_Period();
				var s_ = context.Operators.ElementInInterval<CqlDateTime>(m_, r_, "day");
				var t_ = context.Operators.And(p_, s_);

				return t_;
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
			var u_ = context.Operators.Convert<Code<EventStatus>>(LevelOfSeverityCommunicated?.StatusElement?.Value);
			var v_ = context.Operators.Equal(u_, "completed");

			return v_;
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
		var b_ = typeof(Communication).GetProperty("ReasonCode");
		var c_ = context.Operators.RetrieveByValueSet<Communication>(a_, b_);
		IEnumerable<Communication> d_(Communication MacularEdemaAbsentCommunicated)
		{
			var h_ = this.Diabetic_Retinopathy_Encounter();
			bool? i_(Encounter EncounterDiabeticRetinopathy)
			{
				var m_ = context.Operators.Convert<CqlDateTime>(MacularEdemaAbsentCommunicated?.SentElement);
				var n_ = FHIRHelpers_4_3_000.ToInterval(EncounterDiabeticRetinopathy?.Period);
				var o_ = context.Operators.Start(n_);
				var p_ = context.Operators.After(m_, o_, null);
				var r_ = this.Measurement_Period();
				var s_ = context.Operators.ElementInInterval<CqlDateTime>(m_, r_, "day");
				var t_ = context.Operators.And(p_, s_);

				return t_;
			};
			var j_ = context.Operators.WhereOrNull<Encounter>(h_, i_);
			Communication k_(Encounter EncounterDiabeticRetinopathy) => 
				MacularEdemaAbsentCommunicated;
			var l_ = context.Operators.SelectOrNull<Encounter, Communication>(j_, k_);

			return l_;
		};
		var e_ = context.Operators.SelectManyOrNull<Communication, Communication>(c_, d_);
		bool? f_(Communication MacularEdemaAbsentCommunicated)
		{
			var u_ = context.Operators.Convert<Code<EventStatus>>(MacularEdemaAbsentCommunicated?.StatusElement?.Value);
			var v_ = context.Operators.Equal(u_, "completed");

			return v_;
		};
		var g_ = context.Operators.WhereOrNull<Communication>(e_, f_);

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
				var m_ = context.Operators.Convert<CqlDateTime>(MacularEdemaPresentCommunicated?.SentElement);
				var n_ = FHIRHelpers_4_3_000.ToInterval(EncounterDiabeticRetinopathy?.Period);
				var o_ = context.Operators.Start(n_);
				var p_ = context.Operators.After(m_, o_, null);
				var r_ = this.Measurement_Period();
				var s_ = context.Operators.ElementInInterval<CqlDateTime>(m_, r_, "day");
				var t_ = context.Operators.And(p_, s_);

				return t_;
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
			var u_ = context.Operators.Convert<Code<EventStatus>>(MacularEdemaPresentCommunicated?.StatusElement?.Value);
			var v_ = context.Operators.Equal(u_, "completed");

			return v_;
		};
		var g_ = context.Operators.WhereOrNull<Communication>(e_, f_);

		return g_;
	}

    [CqlDeclaration("Macular Edema Presence Communicated")]
	public IEnumerable<Communication> Macular_Edema_Presence_Communicated() => 
		__Macular_Edema_Presence_Communicated.Value;

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

	private IEnumerable<Communication> Medical_or_Patient_Reason_for_Not_Communicating_Level_of_Severity_of_Retinopathy_Value()
	{
		var a_ = this.Level_of_Severity_of_Retinopathy_Findings();
		var b_ = typeof(Communication).GetProperty("ReasonCode");
		var c_ = context.Operators.RetrieveByValueSet<Communication>(a_, b_);
		var f_ = context.Operators.RetrieveByValueSet<Communication>(a_, b_);
		var g_ = context.Operators.ListUnion<Communication>(c_, f_);
		IEnumerable<Communication> h_(Communication LevelOfSeverityNotCommunicated)
		{
			var l_ = this.Diabetic_Retinopathy_Encounter();
			bool? m_(Encounter EncounterDiabeticRetinopathy)
			{
				bool? q_(Extension @this)
				{
					var y_ = context.Operators.Equal(@this?.Url, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");

					return y_;
				};
				var r_ = context.Operators.WhereOrNull<Extension>(((LevelOfSeverityNotCommunicated is DomainResource)
						? ((LevelOfSeverityNotCommunicated as DomainResource).Extension)
						: null), q_);
				DataType s_(Extension @this) => 
					@this?.Value;
				var t_ = context.Operators.SelectOrNull<Extension, DataType>(r_, s_);
				var u_ = context.Operators.SingleOrNull<DataType>(t_);
				var v_ = context.Operators.Convert<CqlDateTime>(u_);
				var w_ = FHIRHelpers_4_3_000.ToInterval(EncounterDiabeticRetinopathy?.Period);
				var x_ = context.Operators.ElementInInterval<CqlDateTime>(v_, w_, null);

				return x_;
			};
			var n_ = context.Operators.WhereOrNull<Encounter>(l_, m_);
			Communication o_(Encounter EncounterDiabeticRetinopathy) => 
				LevelOfSeverityNotCommunicated;
			var p_ = context.Operators.SelectOrNull<Encounter, Communication>(n_, o_);

			return p_;
		};
		var i_ = context.Operators.SelectManyOrNull<Communication, Communication>(g_, h_);
		bool? j_(Communication LevelOfSeverityNotCommunicated)
		{
			var z_ = FHIRHelpers_4_3_000.ToConcept(LevelOfSeverityNotCommunicated?.StatusReason);
			var aa_ = this.Medical_Reason();
			var ab_ = context.Operators.ConceptInValueSet(z_, aa_);
			var ad_ = this.Patient_Reason();
			var ae_ = context.Operators.ConceptInValueSet(z_, ad_);
			var af_ = context.Operators.Or(ab_, ae_);

			return af_;
		};
		var k_ = context.Operators.WhereOrNull<Communication>(i_, j_);

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
		var g_ = context.Operators.ListUnion<Communication>(c_, f_);
		IEnumerable<Communication> h_(Communication MacularEdemaAbsentNotCommunicated)
		{
			var l_ = this.Diabetic_Retinopathy_Encounter();
			bool? m_(Encounter EncounterDiabeticRetinopathy)
			{
				bool? q_(Extension @this)
				{
					var y_ = context.Operators.Equal(@this?.Url, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");

					return y_;
				};
				var r_ = context.Operators.WhereOrNull<Extension>(((MacularEdemaAbsentNotCommunicated is DomainResource)
						? ((MacularEdemaAbsentNotCommunicated as DomainResource).Extension)
						: null), q_);
				DataType s_(Extension @this) => 
					@this?.Value;
				var t_ = context.Operators.SelectOrNull<Extension, DataType>(r_, s_);
				var u_ = context.Operators.SingleOrNull<DataType>(t_);
				var v_ = context.Operators.Convert<CqlDateTime>(u_);
				var w_ = FHIRHelpers_4_3_000.ToInterval(EncounterDiabeticRetinopathy?.Period);
				var x_ = context.Operators.ElementInInterval<CqlDateTime>(v_, w_, null);

				return x_;
			};
			var n_ = context.Operators.WhereOrNull<Encounter>(l_, m_);
			Communication o_(Encounter EncounterDiabeticRetinopathy) => 
				MacularEdemaAbsentNotCommunicated;
			var p_ = context.Operators.SelectOrNull<Encounter, Communication>(n_, o_);

			return p_;
		};
		var i_ = context.Operators.SelectManyOrNull<Communication, Communication>(g_, h_);
		bool? j_(Communication MacularEdemaAbsentNotCommunicated)
		{
			var z_ = FHIRHelpers_4_3_000.ToConcept(MacularEdemaAbsentNotCommunicated?.StatusReason);
			var aa_ = this.Medical_Reason();
			var ab_ = context.Operators.ConceptInValueSet(z_, aa_);
			var ad_ = this.Patient_Reason();
			var ae_ = context.Operators.ConceptInValueSet(z_, ad_);
			var af_ = context.Operators.Or(ab_, ae_);

			return af_;
		};
		var k_ = context.Operators.WhereOrNull<Communication>(i_, j_);

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
		var g_ = context.Operators.ListUnion<Communication>(c_, f_);
		IEnumerable<Communication> h_(Communication MacularEdemaPresentNotCommunicated)
		{
			var l_ = this.Diabetic_Retinopathy_Encounter();
			bool? m_(Encounter EncounterDiabeticRetinopathy)
			{
				bool? q_(Extension @this)
				{
					var y_ = context.Operators.Equal(@this?.Url, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");

					return y_;
				};
				var r_ = context.Operators.WhereOrNull<Extension>(((MacularEdemaPresentNotCommunicated is DomainResource)
						? ((MacularEdemaPresentNotCommunicated as DomainResource).Extension)
						: null), q_);
				DataType s_(Extension @this) => 
					@this?.Value;
				var t_ = context.Operators.SelectOrNull<Extension, DataType>(r_, s_);
				var u_ = context.Operators.SingleOrNull<DataType>(t_);
				var v_ = context.Operators.Convert<CqlDateTime>(u_);
				var w_ = FHIRHelpers_4_3_000.ToInterval(EncounterDiabeticRetinopathy?.Period);
				var x_ = context.Operators.ElementInInterval<CqlDateTime>(v_, w_, null);

				return x_;
			};
			var n_ = context.Operators.WhereOrNull<Encounter>(l_, m_);
			Communication o_(Encounter EncounterDiabeticRetinopathy) => 
				MacularEdemaPresentNotCommunicated;
			var p_ = context.Operators.SelectOrNull<Encounter, Communication>(n_, o_);

			return p_;
		};
		var i_ = context.Operators.SelectManyOrNull<Communication, Communication>(g_, h_);
		bool? j_(Communication MacularEdemaPresentNotCommunicated)
		{
			var z_ = FHIRHelpers_4_3_000.ToConcept(MacularEdemaPresentNotCommunicated?.StatusReason);
			var aa_ = this.Medical_Reason();
			var ab_ = context.Operators.ConceptInValueSet(z_, aa_);
			var ad_ = this.Patient_Reason();
			var ae_ = context.Operators.ConceptInValueSet(z_, ad_);
			var af_ = context.Operators.Or(ab_, ae_);

			return af_;
		};
		var k_ = context.Operators.WhereOrNull<Communication>(i_, j_);

		return k_;
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

}