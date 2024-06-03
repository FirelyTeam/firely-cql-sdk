﻿using System;
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
[CqlLibrary("HospitalHarmPressureInjuryFHIR", "0.1.000")]
public class HospitalHarmPressureInjuryFHIR_0_1_000
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __COVID_19;
    internal Lazy<CqlValueSet> __Emergency_Department_Visit;
    internal Lazy<CqlValueSet> __Encounter_Inpatient;
    internal Lazy<CqlValueSet> __Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine;
    internal Lazy<CqlValueSet> __Observation_Services;
    internal Lazy<CqlValueSet> __Present_on_Admission_or_Clinically_Undetermined;
    internal Lazy<CqlValueSet> __Pressure_Injury_Deep_Tissue;
    internal Lazy<CqlValueSet> __Pressure_Injury_Deep_Tissue_Diagnoses;
    internal Lazy<CqlValueSet> __Pressure_Injury_Stage_2__3__4_or_Unstageable;
    internal Lazy<CqlValueSet> __Pressure_Injury_Stage_2__3__4__or_Unstageable_Diagnoses;
    internal Lazy<CqlCode> __Physical_findings_of_Skin;
    internal Lazy<CqlCode[]> __LOINC;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_Age_18_and_Older;
    internal Lazy<IEnumerable<Encounter>> __Initial_Population;
    internal Lazy<IEnumerable<Encounter>> __Denominator;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_Deep_Tissue_Pressure_Injury_POA_by_Indicator;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_Deep_Tissue_Pressure_Injury_POA_by_Skin_Exam_within_First_72_Hours;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_Deep_Tissue_Pressure_Injury_POA;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_Stage_2__3__4__or_Unstageable_Pressure_Injury_Present_on_Admission_by_POA_Indicator;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_Stage_2__3__4_or_Unstageable_Pressure_Injury_POA_by_Skin_Exam_within_24_Hours;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_Stage_2__3__4_or_Unstageable_Pressure_Injury_POA;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_Diagnosis_of_COVID19_Infection;
    internal Lazy<IEnumerable<Encounter>> __Denominator_Exclusions;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_New_Deep_Tissue_Pressure_Injury_Not_POA_by_Indicator;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_New_Deep_Tissue_Pressure_Injury_by_Skin_Exam_after_First_72_Hours;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_New_Deep_Tissue_Pressure_Injury_Not_POA;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_Not_POA_by_Indicator;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_by_Skin_Exam_after_First_24_Hours;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_Not_POA;
    internal Lazy<IEnumerable<Encounter>> __Numerator;
    internal Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ>> __SDE_Payer;
    internal Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;

    #endregion
    public HospitalHarmPressureInjuryFHIR_0_1_000(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_3_000 = new FHIRHelpers_4_3_000(context);
        SupplementalDataElements_3_4_000 = new SupplementalDataElements_3_4_000(context);
        CQMCommon_2_0_000 = new CQMCommon_2_0_000(context);
        QICoreCommon_2_0_000 = new QICoreCommon_2_0_000(context);

        __COVID_19 = new Lazy<CqlValueSet>(this.COVID_19_Value);
        __Emergency_Department_Visit = new Lazy<CqlValueSet>(this.Emergency_Department_Visit_Value);
        __Encounter_Inpatient = new Lazy<CqlValueSet>(this.Encounter_Inpatient_Value);
        __Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine = new Lazy<CqlValueSet>(this.Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine_Value);
        __Observation_Services = new Lazy<CqlValueSet>(this.Observation_Services_Value);
        __Present_on_Admission_or_Clinically_Undetermined = new Lazy<CqlValueSet>(this.Present_on_Admission_or_Clinically_Undetermined_Value);
        __Pressure_Injury_Deep_Tissue = new Lazy<CqlValueSet>(this.Pressure_Injury_Deep_Tissue_Value);
        __Pressure_Injury_Deep_Tissue_Diagnoses = new Lazy<CqlValueSet>(this.Pressure_Injury_Deep_Tissue_Diagnoses_Value);
        __Pressure_Injury_Stage_2__3__4_or_Unstageable = new Lazy<CqlValueSet>(this.Pressure_Injury_Stage_2__3__4_or_Unstageable_Value);
        __Pressure_Injury_Stage_2__3__4__or_Unstageable_Diagnoses = new Lazy<CqlValueSet>(this.Pressure_Injury_Stage_2__3__4__or_Unstageable_Diagnoses_Value);
        __Physical_findings_of_Skin = new Lazy<CqlCode>(this.Physical_findings_of_Skin_Value);
        __LOINC = new Lazy<CqlCode[]>(this.LOINC_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __Encounter_with_Age_18_and_Older = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_Age_18_and_Older_Value);
        __Initial_Population = new Lazy<IEnumerable<Encounter>>(this.Initial_Population_Value);
        __Denominator = new Lazy<IEnumerable<Encounter>>(this.Denominator_Value);
        __Encounter_with_Deep_Tissue_Pressure_Injury_POA_by_Indicator = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_Deep_Tissue_Pressure_Injury_POA_by_Indicator_Value);
        __Encounter_with_Deep_Tissue_Pressure_Injury_POA_by_Skin_Exam_within_First_72_Hours = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_Deep_Tissue_Pressure_Injury_POA_by_Skin_Exam_within_First_72_Hours_Value);
        __Encounter_with_Deep_Tissue_Pressure_Injury_POA = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_Deep_Tissue_Pressure_Injury_POA_Value);
        __Encounter_with_Stage_2__3__4__or_Unstageable_Pressure_Injury_Present_on_Admission_by_POA_Indicator = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_Stage_2__3__4__or_Unstageable_Pressure_Injury_Present_on_Admission_by_POA_Indicator_Value);
        __Encounter_with_Stage_2__3__4_or_Unstageable_Pressure_Injury_POA_by_Skin_Exam_within_24_Hours = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_Stage_2__3__4_or_Unstageable_Pressure_Injury_POA_by_Skin_Exam_within_24_Hours_Value);
        __Encounter_with_Stage_2__3__4_or_Unstageable_Pressure_Injury_POA = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_Stage_2__3__4_or_Unstageable_Pressure_Injury_POA_Value);
        __Encounter_with_Diagnosis_of_COVID19_Infection = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_Diagnosis_of_COVID19_Infection_Value);
        __Denominator_Exclusions = new Lazy<IEnumerable<Encounter>>(this.Denominator_Exclusions_Value);
        __Encounter_with_New_Deep_Tissue_Pressure_Injury_Not_POA_by_Indicator = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_New_Deep_Tissue_Pressure_Injury_Not_POA_by_Indicator_Value);
        __Encounter_with_New_Deep_Tissue_Pressure_Injury_by_Skin_Exam_after_First_72_Hours = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_New_Deep_Tissue_Pressure_Injury_by_Skin_Exam_after_First_72_Hours_Value);
        __Encounter_with_New_Deep_Tissue_Pressure_Injury_Not_POA = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_New_Deep_Tissue_Pressure_Injury_Not_POA_Value);
        __Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_Not_POA_by_Indicator = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_Not_POA_by_Indicator_Value);
        __Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_by_Skin_Exam_after_First_24_Hours = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_by_Skin_Exam_after_First_24_Hours_Value);
        __Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_Not_POA = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_Not_POA_Value);
        __Numerator = new Lazy<IEnumerable<Encounter>>(this.Numerator_Value);
        __SDE_Ethnicity = new Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_3_000 FHIRHelpers_4_3_000 { get; }
    public SupplementalDataElements_3_4_000 SupplementalDataElements_3_4_000 { get; }
    public CQMCommon_2_0_000 CQMCommon_2_0_000 { get; }
    public QICoreCommon_2_0_000 QICoreCommon_2_0_000 { get; }

    #endregion

    /// <seealso cref="COVID_19"/>
	private CqlValueSet COVID_19_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.140", null);

    /// <seealso cref="COVID_19_Value"/>
    [CqlDeclaration("COVID 19")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.140")]
	public CqlValueSet COVID_19() => 
		__COVID_19.Value;

    /// <seealso cref="Emergency_Department_Visit"/>
	private CqlValueSet Emergency_Department_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", null);

    /// <seealso cref="Emergency_Department_Visit_Value"/>
    [CqlDeclaration("Emergency Department Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292")]
	public CqlValueSet Emergency_Department_Visit() => 
		__Emergency_Department_Visit.Value;

    /// <seealso cref="Encounter_Inpatient"/>
	private CqlValueSet Encounter_Inpatient_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    /// <seealso cref="Encounter_Inpatient_Value"/>
    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
	public CqlValueSet Encounter_Inpatient() => 
		__Encounter_Inpatient.Value;

    /// <seealso cref="Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine"/>
	private CqlValueSet Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.198", null);

    /// <seealso cref="Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine_Value"/>
    [CqlDeclaration("Not Present On Admission or Documentation Insufficient to Determine")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.198")]
	public CqlValueSet Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine() => 
		__Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine.Value;

    /// <seealso cref="Observation_Services"/>
	private CqlValueSet Observation_Services_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", null);

    /// <seealso cref="Observation_Services_Value"/>
    [CqlDeclaration("Observation Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143")]
	public CqlValueSet Observation_Services() => 
		__Observation_Services.Value;

    /// <seealso cref="Present_on_Admission_or_Clinically_Undetermined"/>
	private CqlValueSet Present_on_Admission_or_Clinically_Undetermined_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.197", null);

    /// <seealso cref="Present_on_Admission_or_Clinically_Undetermined_Value"/>
    [CqlDeclaration("Present on Admission or Clinically Undetermined")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.197")]
	public CqlValueSet Present_on_Admission_or_Clinically_Undetermined() => 
		__Present_on_Admission_or_Clinically_Undetermined.Value;

    /// <seealso cref="Pressure_Injury_Deep_Tissue"/>
	private CqlValueSet Pressure_Injury_Deep_Tissue_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.112", null);

    /// <seealso cref="Pressure_Injury_Deep_Tissue_Value"/>
    [CqlDeclaration("Pressure Injury Deep Tissue")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.112")]
	public CqlValueSet Pressure_Injury_Deep_Tissue() => 
		__Pressure_Injury_Deep_Tissue.Value;

    /// <seealso cref="Pressure_Injury_Deep_Tissue_Diagnoses"/>
	private CqlValueSet Pressure_Injury_Deep_Tissue_Diagnoses_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.194", null);

    /// <seealso cref="Pressure_Injury_Deep_Tissue_Diagnoses_Value"/>
    [CqlDeclaration("Pressure Injury Deep Tissue Diagnoses")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.194")]
	public CqlValueSet Pressure_Injury_Deep_Tissue_Diagnoses() => 
		__Pressure_Injury_Deep_Tissue_Diagnoses.Value;

    /// <seealso cref="Pressure_Injury_Stage_2__3__4_or_Unstageable"/>
	private CqlValueSet Pressure_Injury_Stage_2__3__4_or_Unstageable_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.113", null);

    /// <seealso cref="Pressure_Injury_Stage_2__3__4_or_Unstageable_Value"/>
    [CqlDeclaration("Pressure Injury Stage 2, 3, 4 or Unstageable")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.113")]
	public CqlValueSet Pressure_Injury_Stage_2__3__4_or_Unstageable() => 
		__Pressure_Injury_Stage_2__3__4_or_Unstageable.Value;

    /// <seealso cref="Pressure_Injury_Stage_2__3__4__or_Unstageable_Diagnoses"/>
	private CqlValueSet Pressure_Injury_Stage_2__3__4__or_Unstageable_Diagnoses_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.196", null);

    /// <seealso cref="Pressure_Injury_Stage_2__3__4__or_Unstageable_Diagnoses_Value"/>
    [CqlDeclaration("Pressure Injury Stage 2, 3, 4, or Unstageable Diagnoses")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.196")]
	public CqlValueSet Pressure_Injury_Stage_2__3__4__or_Unstageable_Diagnoses() => 
		__Pressure_Injury_Stage_2__3__4__or_Unstageable_Diagnoses.Value;

    /// <seealso cref="Physical_findings_of_Skin"/>
	private CqlCode Physical_findings_of_Skin_Value() => 
		new CqlCode("8709-8", "http://loinc.org", null, null);

    /// <seealso cref="Physical_findings_of_Skin_Value"/>
    [CqlDeclaration("Physical findings of Skin")]
	public CqlCode Physical_findings_of_Skin() => 
		__Physical_findings_of_Skin.Value;

    /// <seealso cref="LOINC"/>
	private CqlCode[] LOINC_Value()
	{
		CqlCode[] a_ = new CqlCode[]
		{
			new CqlCode("8709-8", "http://loinc.org", null, null),
		};

		return a_;
	}

    /// <seealso cref="LOINC_Value"/>
    [CqlDeclaration("LOINC")]
	public CqlCode[] LOINC() => 
		__LOINC.Value;

    /// <seealso cref="Measurement_Period"/>
	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("HospitalHarmPressureInjuryFHIR-0.1.000", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
	}

    /// <seealso cref="Measurement_Period_Value"/>
    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period.Value;

    /// <seealso cref="Patient"/>
	private Patient Patient_Value()
	{
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    /// <seealso cref="Patient_Value"/>
    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

    /// <seealso cref="Encounter_with_Age_18_and_Older"/>
	private IEnumerable<Encounter> Encounter_with_Age_18_and_Older_Value()
	{
		CqlValueSet a_ = this.Encounter_Inpatient();
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		bool? c_(Encounter InpatientEncounter)
		{
			Patient e_ = this.Patient();
			Date f_ = e_?.BirthDateElement;
			string g_ = f_?.Value;
			CqlDate h_ = context.Operators.Convert<CqlDate>(g_);
			Period i_ = InpatientEncounter?.Period;
			CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_3_000.ToInterval(i_);
			CqlDateTime k_ = context.Operators.Start(j_);
			CqlDate l_ = context.Operators.DateFrom(k_);
			int? m_ = context.Operators.CalculateAgeAt(h_, l_, "year");
			bool? n_ = context.Operators.GreaterOrEqual(m_, 18);
			CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_3_000.ToInterval(i_);
			CqlDateTime q_ = context.Operators.End(p_);
			CqlInterval<CqlDateTime> r_ = this.Measurement_Period();
			bool? s_ = context.Operators.In<CqlDateTime>(q_, r_, "day");
			bool? t_ = context.Operators.And(n_, s_);
			Code<Encounter.EncounterStatus> u_ = InpatientEncounter?.StatusElement;
			Encounter.EncounterStatus? v_ = u_?.Value;
			Code<Encounter.EncounterStatus> w_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(v_);
			bool? x_ = context.Operators.Equal(w_, "finished");
			bool? y_ = context.Operators.And(t_, x_);

			return y_;
		};
		IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);

		return d_;
	}

    /// <seealso cref="Encounter_with_Age_18_and_Older_Value"/>
    [CqlDeclaration("Encounter with Age 18 and Older")]
	public IEnumerable<Encounter> Encounter_with_Age_18_and_Older() => 
		__Encounter_with_Age_18_and_Older.Value;

    /// <seealso cref="Initial_Population"/>
	private IEnumerable<Encounter> Initial_Population_Value()
	{
		IEnumerable<Encounter> a_ = this.Encounter_with_Age_18_and_Older();

		return a_;
	}

    /// <seealso cref="Initial_Population_Value"/>
    [CqlDeclaration("Initial Population")]
	public IEnumerable<Encounter> Initial_Population() => 
		__Initial_Population.Value;

    /// <seealso cref="Denominator"/>
	private IEnumerable<Encounter> Denominator_Value()
	{
		IEnumerable<Encounter> a_ = this.Initial_Population();

		return a_;
	}

    /// <seealso cref="Denominator_Value"/>
    [CqlDeclaration("Denominator")]
	public IEnumerable<Encounter> Denominator() => 
		__Denominator.Value;

    /// <seealso cref="Encounter_with_Deep_Tissue_Pressure_Injury_POA_by_Indicator"/>
	private IEnumerable<Encounter> Encounter_with_Deep_Tissue_Pressure_Injury_POA_by_Indicator_Value()
	{
		IEnumerable<Encounter> a_ = this.Encounter_with_Age_18_and_Older();
		bool? b_(Encounter InpatientHospitalization)
		{
			List<Encounter.DiagnosisComponent> d_ = InpatientHospitalization?.Diagnosis;
			bool? e_(Encounter.DiagnosisComponent EncounterDiag)
			{
				ResourceReference h_ = EncounterDiag?.Condition;
				Condition i_ = CQMCommon_2_0_000.getCondition(h_);
				CodeableConcept j_ = i_?.Code;
				CqlConcept k_ = FHIRHelpers_4_3_000.ToConcept(j_);
				CqlValueSet l_ = this.Pressure_Injury_Deep_Tissue_Diagnoses();
				bool? m_ = context.Operators.ConceptInValueSet(k_, l_);
				bool? n_(Extension @this)
				{
					string x_ = @this?.Url;
					FhirUri y_ = context.Operators.Convert<FhirUri>(x_);
					string z_ = FHIRHelpers_4_3_000.ToString(y_);
					bool? aa_ = context.Operators.Equal(z_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

					return aa_;
				};
				IEnumerable<Extension> o_ = context.Operators.Where<Extension>((IEnumerable<Extension>)((EncounterDiag is Element)
						? ((EncounterDiag as Element).Extension)
						: null), n_);
				DataType p_(Extension @this)
				{
					DataType ab_ = @this?.Value;

					return ab_;
				};
				IEnumerable<DataType> q_ = context.Operators.Select<Extension, DataType>(o_, p_);
				DataType r_ = context.Operators.SingletonFrom<DataType>(q_);
				CodeableConcept s_ = context.Operators.Convert<CodeableConcept>(r_);
				CqlConcept t_ = FHIRHelpers_4_3_000.ToConcept(s_);
				CqlValueSet u_ = this.Present_on_Admission_or_Clinically_Undetermined();
				bool? v_ = context.Operators.ConceptInValueSet(t_, u_);
				bool? w_ = context.Operators.And(m_, v_);

				return w_;
			};
			IEnumerable<Encounter.DiagnosisComponent> f_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)d_, e_);
			bool? g_ = context.Operators.Exists<Encounter.DiagnosisComponent>(f_);

			return g_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    /// <seealso cref="Encounter_with_Deep_Tissue_Pressure_Injury_POA_by_Indicator_Value"/>
    [CqlDeclaration("Encounter with Deep Tissue Pressure Injury POA by Indicator")]
	public IEnumerable<Encounter> Encounter_with_Deep_Tissue_Pressure_Injury_POA_by_Indicator() => 
		__Encounter_with_Deep_Tissue_Pressure_Injury_POA_by_Indicator.Value;

    /// <seealso cref="Encounter_with_Deep_Tissue_Pressure_Injury_POA_by_Skin_Exam_within_First_72_Hours"/>
	private IEnumerable<Encounter> Encounter_with_Deep_Tissue_Pressure_Injury_POA_by_Skin_Exam_within_First_72_Hours_Value()
	{
		IEnumerable<Encounter> a_ = this.Encounter_with_Age_18_and_Older();
		IEnumerable<Encounter> b_(Encounter InpatientHospitalization)
		{
			CqlCode d_ = this.Physical_findings_of_Skin();
			IEnumerable<CqlCode> e_ = context.Operators.ToList<CqlCode>(d_);
			IEnumerable<Observation> f_ = context.Operators.RetrieveByCodes<Observation>(e_, null);
			bool? g_(Observation SkinExam)
			{
				DataType k_ = SkinExam?.Effective;
				object l_ = FHIRHelpers_4_3_000.ToValue(k_);
				CqlInterval<CqlDateTime> m_ = QICoreCommon_2_0_000.ToInterval(l_);
				CqlDateTime n_ = context.Operators.Start(m_);
				CqlInterval<CqlDateTime> o_ = CQMCommon_2_0_000.HospitalizationWithObservation(InpatientHospitalization);
				CqlDateTime p_ = context.Operators.Start(o_);
				CqlDateTime r_ = context.Operators.Start(o_);
				CqlQuantity s_ = context.Operators.Quantity(72m, "hours");
				CqlDateTime t_ = context.Operators.Add(r_, s_);
				CqlInterval<CqlDateTime> u_ = context.Operators.Interval(p_, t_, true, true);
				bool? v_ = context.Operators.In<CqlDateTime>(n_, u_, null);
				Code<ObservationStatus> w_ = SkinExam?.StatusElement;
				ObservationStatus? x_ = w_?.Value;
				Code<ObservationStatus> y_ = context.Operators.Convert<Code<ObservationStatus>>(x_);
				string z_ = context.Operators.Convert<string>(y_);
				string[] aa_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				bool? ab_ = context.Operators.In<string>(z_, (aa_ as IEnumerable<string>));
				bool? ac_ = context.Operators.And(v_, ab_);
				CodeableConcept ad_ = SkinExam?.Code;
				CqlConcept ae_ = FHIRHelpers_4_3_000.ToConcept(ad_);
				CqlValueSet af_ = this.Pressure_Injury_Deep_Tissue();
				bool? ag_ = context.Operators.ConceptInValueSet(ae_, af_);
				bool? ah_ = context.Operators.And(ac_, ag_);

				return ah_;
			};
			IEnumerable<Observation> h_ = context.Operators.Where<Observation>(f_, g_);
			Encounter i_(Observation SkinExam) => 
				InpatientHospitalization;
			IEnumerable<Encounter> j_ = context.Operators.Select<Observation, Encounter>(h_, i_);

			return j_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    /// <seealso cref="Encounter_with_Deep_Tissue_Pressure_Injury_POA_by_Skin_Exam_within_First_72_Hours_Value"/>
    [CqlDeclaration("Encounter with Deep Tissue Pressure Injury POA by Skin Exam within First 72 Hours")]
	public IEnumerable<Encounter> Encounter_with_Deep_Tissue_Pressure_Injury_POA_by_Skin_Exam_within_First_72_Hours() => 
		__Encounter_with_Deep_Tissue_Pressure_Injury_POA_by_Skin_Exam_within_First_72_Hours.Value;

    /// <seealso cref="Encounter_with_Deep_Tissue_Pressure_Injury_POA"/>
	private IEnumerable<Encounter> Encounter_with_Deep_Tissue_Pressure_Injury_POA_Value()
	{
		IEnumerable<Encounter> a_ = this.Encounter_with_Deep_Tissue_Pressure_Injury_POA_by_Indicator();
		IEnumerable<Encounter> b_ = this.Encounter_with_Deep_Tissue_Pressure_Injury_POA_by_Skin_Exam_within_First_72_Hours();
		IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);

		return c_;
	}

    /// <seealso cref="Encounter_with_Deep_Tissue_Pressure_Injury_POA_Value"/>
    [CqlDeclaration("Encounter with Deep Tissue Pressure Injury POA")]
	public IEnumerable<Encounter> Encounter_with_Deep_Tissue_Pressure_Injury_POA() => 
		__Encounter_with_Deep_Tissue_Pressure_Injury_POA.Value;

    /// <seealso cref="Encounter_with_Stage_2__3__4__or_Unstageable_Pressure_Injury_Present_on_Admission_by_POA_Indicator"/>
	private IEnumerable<Encounter> Encounter_with_Stage_2__3__4__or_Unstageable_Pressure_Injury_Present_on_Admission_by_POA_Indicator_Value()
	{
		IEnumerable<Encounter> a_ = this.Encounter_with_Age_18_and_Older();
		bool? b_(Encounter InpatientHospitalization)
		{
			List<Encounter.DiagnosisComponent> d_ = InpatientHospitalization?.Diagnosis;
			bool? e_(Encounter.DiagnosisComponent Stage234UnstageablePressureInjury)
			{
				ResourceReference h_ = Stage234UnstageablePressureInjury?.Condition;
				Condition i_ = CQMCommon_2_0_000.getCondition(h_);
				CodeableConcept j_ = i_?.Code;
				CqlConcept k_ = FHIRHelpers_4_3_000.ToConcept(j_);
				CqlValueSet l_ = this.Pressure_Injury_Stage_2__3__4__or_Unstageable_Diagnoses();
				bool? m_ = context.Operators.ConceptInValueSet(k_, l_);
				bool? n_(Extension @this)
				{
					string x_ = @this?.Url;
					FhirUri y_ = context.Operators.Convert<FhirUri>(x_);
					string z_ = FHIRHelpers_4_3_000.ToString(y_);
					bool? aa_ = context.Operators.Equal(z_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

					return aa_;
				};
				IEnumerable<Extension> o_ = context.Operators.Where<Extension>((IEnumerable<Extension>)((Stage234UnstageablePressureInjury is Element)
						? ((Stage234UnstageablePressureInjury as Element).Extension)
						: null), n_);
				DataType p_(Extension @this)
				{
					DataType ab_ = @this?.Value;

					return ab_;
				};
				IEnumerable<DataType> q_ = context.Operators.Select<Extension, DataType>(o_, p_);
				DataType r_ = context.Operators.SingletonFrom<DataType>(q_);
				CodeableConcept s_ = context.Operators.Convert<CodeableConcept>(r_);
				CqlConcept t_ = FHIRHelpers_4_3_000.ToConcept(s_);
				CqlValueSet u_ = this.Present_on_Admission_or_Clinically_Undetermined();
				bool? v_ = context.Operators.ConceptInValueSet(t_, u_);
				bool? w_ = context.Operators.And(m_, v_);

				return w_;
			};
			IEnumerable<Encounter.DiagnosisComponent> f_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)d_, e_);
			bool? g_ = context.Operators.Exists<Encounter.DiagnosisComponent>(f_);

			return g_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    /// <seealso cref="Encounter_with_Stage_2__3__4__or_Unstageable_Pressure_Injury_Present_on_Admission_by_POA_Indicator_Value"/>
    [CqlDeclaration("Encounter with Stage 2, 3, 4, or Unstageable Pressure Injury Present on Admission by POA Indicator")]
	public IEnumerable<Encounter> Encounter_with_Stage_2__3__4__or_Unstageable_Pressure_Injury_Present_on_Admission_by_POA_Indicator() => 
		__Encounter_with_Stage_2__3__4__or_Unstageable_Pressure_Injury_Present_on_Admission_by_POA_Indicator.Value;

    /// <seealso cref="Encounter_with_Stage_2__3__4_or_Unstageable_Pressure_Injury_POA_by_Skin_Exam_within_24_Hours"/>
	private IEnumerable<Encounter> Encounter_with_Stage_2__3__4_or_Unstageable_Pressure_Injury_POA_by_Skin_Exam_within_24_Hours_Value()
	{
		IEnumerable<Encounter> a_ = this.Encounter_with_Age_18_and_Older();
		IEnumerable<Encounter> b_(Encounter InpatientHospitalization)
		{
			CqlCode d_ = this.Physical_findings_of_Skin();
			IEnumerable<CqlCode> e_ = context.Operators.ToList<CqlCode>(d_);
			IEnumerable<Observation> f_ = context.Operators.RetrieveByCodes<Observation>(e_, null);
			bool? g_(Observation SkinExam)
			{
				DataType k_ = SkinExam?.Effective;
				object l_ = FHIRHelpers_4_3_000.ToValue(k_);
				CqlInterval<CqlDateTime> m_ = QICoreCommon_2_0_000.ToInterval(l_);
				CqlDateTime n_ = context.Operators.Start(m_);
				CqlInterval<CqlDateTime> o_ = CQMCommon_2_0_000.HospitalizationWithObservation(InpatientHospitalization);
				CqlDateTime p_ = context.Operators.Start(o_);
				CqlDateTime r_ = context.Operators.Start(o_);
				CqlQuantity s_ = context.Operators.Quantity(24m, "hours");
				CqlDateTime t_ = context.Operators.Add(r_, s_);
				CqlInterval<CqlDateTime> u_ = context.Operators.Interval(p_, t_, true, true);
				bool? v_ = context.Operators.In<CqlDateTime>(n_, u_, null);
				Code<ObservationStatus> w_ = SkinExam?.StatusElement;
				ObservationStatus? x_ = w_?.Value;
				Code<ObservationStatus> y_ = context.Operators.Convert<Code<ObservationStatus>>(x_);
				string z_ = context.Operators.Convert<string>(y_);
				string[] aa_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				bool? ab_ = context.Operators.In<string>(z_, (aa_ as IEnumerable<string>));
				bool? ac_ = context.Operators.And(v_, ab_);
				CodeableConcept ad_ = SkinExam?.Code;
				CqlConcept ae_ = FHIRHelpers_4_3_000.ToConcept(ad_);
				CqlValueSet af_ = this.Pressure_Injury_Stage_2__3__4_or_Unstageable();
				bool? ag_ = context.Operators.ConceptInValueSet(ae_, af_);
				bool? ah_ = context.Operators.And(ac_, ag_);

				return ah_;
			};
			IEnumerable<Observation> h_ = context.Operators.Where<Observation>(f_, g_);
			Encounter i_(Observation SkinExam) => 
				InpatientHospitalization;
			IEnumerable<Encounter> j_ = context.Operators.Select<Observation, Encounter>(h_, i_);

			return j_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    /// <seealso cref="Encounter_with_Stage_2__3__4_or_Unstageable_Pressure_Injury_POA_by_Skin_Exam_within_24_Hours_Value"/>
    [CqlDeclaration("Encounter with Stage 2, 3, 4 or Unstageable Pressure Injury POA by Skin Exam within 24 Hours")]
	public IEnumerable<Encounter> Encounter_with_Stage_2__3__4_or_Unstageable_Pressure_Injury_POA_by_Skin_Exam_within_24_Hours() => 
		__Encounter_with_Stage_2__3__4_or_Unstageable_Pressure_Injury_POA_by_Skin_Exam_within_24_Hours.Value;

    /// <seealso cref="Encounter_with_Stage_2__3__4_or_Unstageable_Pressure_Injury_POA"/>
	private IEnumerable<Encounter> Encounter_with_Stage_2__3__4_or_Unstageable_Pressure_Injury_POA_Value()
	{
		IEnumerable<Encounter> a_ = this.Encounter_with_Stage_2__3__4__or_Unstageable_Pressure_Injury_Present_on_Admission_by_POA_Indicator();
		IEnumerable<Encounter> b_ = this.Encounter_with_Stage_2__3__4_or_Unstageable_Pressure_Injury_POA_by_Skin_Exam_within_24_Hours();
		IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);

		return c_;
	}

    /// <seealso cref="Encounter_with_Stage_2__3__4_or_Unstageable_Pressure_Injury_POA_Value"/>
    [CqlDeclaration("Encounter with Stage 2, 3, 4 or Unstageable Pressure Injury POA")]
	public IEnumerable<Encounter> Encounter_with_Stage_2__3__4_or_Unstageable_Pressure_Injury_POA() => 
		__Encounter_with_Stage_2__3__4_or_Unstageable_Pressure_Injury_POA.Value;

    /// <seealso cref="Encounter_with_Diagnosis_of_COVID19_Infection"/>
	private IEnumerable<Encounter> Encounter_with_Diagnosis_of_COVID19_Infection_Value()
	{
		IEnumerable<Encounter> a_ = this.Encounter_with_Age_18_and_Older();
		bool? b_(Encounter InpatientHospitalization)
		{
			IEnumerable<Condition> d_ = CQMCommon_2_0_000.EncounterDiagnosis(InpatientHospitalization);
			bool? e_(Condition EncounterDiag)
			{
				CodeableConcept h_ = EncounterDiag?.Code;
				CqlConcept i_ = FHIRHelpers_4_3_000.ToConcept(h_);
				CqlValueSet j_ = this.COVID_19();
				bool? k_ = context.Operators.ConceptInValueSet(i_, j_);

				return k_;
			};
			IEnumerable<Condition> f_ = context.Operators.Where<Condition>(d_, e_);
			bool? g_ = context.Operators.Exists<Condition>(f_);

			return g_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    /// <seealso cref="Encounter_with_Diagnosis_of_COVID19_Infection_Value"/>
    [CqlDeclaration("Encounter with Diagnosis of COVID19 Infection")]
	public IEnumerable<Encounter> Encounter_with_Diagnosis_of_COVID19_Infection() => 
		__Encounter_with_Diagnosis_of_COVID19_Infection.Value;

    /// <seealso cref="Denominator_Exclusions"/>
	private IEnumerable<Encounter> Denominator_Exclusions_Value()
	{
		IEnumerable<Encounter> a_ = this.Encounter_with_Deep_Tissue_Pressure_Injury_POA();
		IEnumerable<Encounter> b_ = this.Encounter_with_Stage_2__3__4_or_Unstageable_Pressure_Injury_POA();
		IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
		IEnumerable<Encounter> d_ = this.Encounter_with_Diagnosis_of_COVID19_Infection();
		IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(c_, d_);

		return e_;
	}

    /// <seealso cref="Denominator_Exclusions_Value"/>
    [CqlDeclaration("Denominator Exclusions")]
	public IEnumerable<Encounter> Denominator_Exclusions() => 
		__Denominator_Exclusions.Value;

    /// <seealso cref="Encounter_with_New_Deep_Tissue_Pressure_Injury_Not_POA_by_Indicator"/>
	private IEnumerable<Encounter> Encounter_with_New_Deep_Tissue_Pressure_Injury_Not_POA_by_Indicator_Value()
	{
		IEnumerable<Encounter> a_ = this.Encounter_with_Age_18_and_Older();
		bool? b_(Encounter InpatientHospitalization)
		{
			List<Encounter.DiagnosisComponent> d_ = InpatientHospitalization?.Diagnosis;
			bool? e_(Encounter.DiagnosisComponent EncounterDiag)
			{
				ResourceReference h_ = EncounterDiag?.Condition;
				Condition i_ = CQMCommon_2_0_000.getCondition(h_);
				CodeableConcept j_ = i_?.Code;
				CqlConcept k_ = FHIRHelpers_4_3_000.ToConcept(j_);
				CqlValueSet l_ = this.Pressure_Injury_Deep_Tissue_Diagnoses();
				bool? m_ = context.Operators.ConceptInValueSet(k_, l_);
				bool? n_(Extension @this)
				{
					string x_ = @this?.Url;
					FhirUri y_ = context.Operators.Convert<FhirUri>(x_);
					string z_ = FHIRHelpers_4_3_000.ToString(y_);
					bool? aa_ = context.Operators.Equal(z_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

					return aa_;
				};
				IEnumerable<Extension> o_ = context.Operators.Where<Extension>((IEnumerable<Extension>)((EncounterDiag is Element)
						? ((EncounterDiag as Element).Extension)
						: null), n_);
				DataType p_(Extension @this)
				{
					DataType ab_ = @this?.Value;

					return ab_;
				};
				IEnumerable<DataType> q_ = context.Operators.Select<Extension, DataType>(o_, p_);
				DataType r_ = context.Operators.SingletonFrom<DataType>(q_);
				CodeableConcept s_ = context.Operators.Convert<CodeableConcept>(r_);
				CqlConcept t_ = FHIRHelpers_4_3_000.ToConcept(s_);
				CqlValueSet u_ = this.Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine();
				bool? v_ = context.Operators.ConceptInValueSet(t_, u_);
				bool? w_ = context.Operators.And(m_, v_);

				return w_;
			};
			IEnumerable<Encounter.DiagnosisComponent> f_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)d_, e_);
			bool? g_ = context.Operators.Exists<Encounter.DiagnosisComponent>(f_);

			return g_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    /// <seealso cref="Encounter_with_New_Deep_Tissue_Pressure_Injury_Not_POA_by_Indicator_Value"/>
    [CqlDeclaration("Encounter with New Deep Tissue Pressure Injury Not POA by Indicator")]
	public IEnumerable<Encounter> Encounter_with_New_Deep_Tissue_Pressure_Injury_Not_POA_by_Indicator() => 
		__Encounter_with_New_Deep_Tissue_Pressure_Injury_Not_POA_by_Indicator.Value;

    /// <seealso cref="Encounter_with_New_Deep_Tissue_Pressure_Injury_by_Skin_Exam_after_First_72_Hours"/>
	private IEnumerable<Encounter> Encounter_with_New_Deep_Tissue_Pressure_Injury_by_Skin_Exam_after_First_72_Hours_Value()
	{
		IEnumerable<Encounter> a_ = this.Encounter_with_Age_18_and_Older();
		IEnumerable<Encounter> b_(Encounter InpatientHospitalization)
		{
			CqlCode d_ = this.Physical_findings_of_Skin();
			IEnumerable<CqlCode> e_ = context.Operators.ToList<CqlCode>(d_);
			IEnumerable<Observation> f_ = context.Operators.RetrieveByCodes<Observation>(e_, null);
			bool? g_(Observation SkinExam)
			{
				DataType k_ = SkinExam?.Effective;
				object l_ = FHIRHelpers_4_3_000.ToValue(k_);
				CqlInterval<CqlDateTime> m_ = QICoreCommon_2_0_000.ToInterval(l_);
				CqlDateTime n_ = context.Operators.Start(m_);
				CqlInterval<CqlDateTime> o_ = CQMCommon_2_0_000.HospitalizationWithObservation(InpatientHospitalization);
				CqlDateTime p_ = context.Operators.Start(o_);
				CqlQuantity q_ = context.Operators.Quantity(72m, "hours");
				CqlDateTime r_ = context.Operators.Add(p_, q_);
				CqlDateTime t_ = context.Operators.End(o_);
				CqlInterval<CqlDateTime> u_ = context.Operators.Interval(r_, t_, true, true);
				bool? v_ = context.Operators.In<CqlDateTime>(n_, u_, null);
				Code<ObservationStatus> w_ = SkinExam?.StatusElement;
				ObservationStatus? x_ = w_?.Value;
				Code<ObservationStatus> y_ = context.Operators.Convert<Code<ObservationStatus>>(x_);
				string z_ = context.Operators.Convert<string>(y_);
				string[] aa_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				bool? ab_ = context.Operators.In<string>(z_, (aa_ as IEnumerable<string>));
				bool? ac_ = context.Operators.And(v_, ab_);
				DataType ad_ = SkinExam?.Value;
				object ae_ = FHIRHelpers_4_3_000.ToValue(ad_);
				CqlValueSet af_ = this.Pressure_Injury_Deep_Tissue();
				bool? ag_ = context.Operators.ConceptInValueSet((ae_ as CqlConcept), af_);
				List<Observation.ComponentComponent> ah_ = SkinExam?.Component;
				bool? ai_(Observation.ComponentComponent @this)
				{
					CodeableConcept aq_ = @this?.Code;
					CqlConcept ar_ = FHIRHelpers_4_3_000.ToConcept(aq_);
					bool? as_ = context.Operators.Not((bool?)(ar_ is null));

					return as_;
				};
				IEnumerable<Observation.ComponentComponent> aj_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)ah_, ai_);
				CqlConcept ak_(Observation.ComponentComponent @this)
				{
					CodeableConcept at_ = @this?.Code;
					CqlConcept au_ = FHIRHelpers_4_3_000.ToConcept(at_);

					return au_;
				};
				IEnumerable<CqlConcept> al_ = context.Operators.Select<Observation.ComponentComponent, CqlConcept>(aj_, ak_);
				bool? an_ = context.Operators.ConceptsInValueSet(al_, af_);
				bool? ao_ = context.Operators.Or(ag_, an_);
				bool? ap_ = context.Operators.And(ac_, ao_);

				return ap_;
			};
			IEnumerable<Observation> h_ = context.Operators.Where<Observation>(f_, g_);
			Encounter i_(Observation SkinExam) => 
				InpatientHospitalization;
			IEnumerable<Encounter> j_ = context.Operators.Select<Observation, Encounter>(h_, i_);

			return j_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    /// <seealso cref="Encounter_with_New_Deep_Tissue_Pressure_Injury_by_Skin_Exam_after_First_72_Hours_Value"/>
    [CqlDeclaration("Encounter with New Deep Tissue Pressure Injury by Skin Exam after First 72 Hours")]
	public IEnumerable<Encounter> Encounter_with_New_Deep_Tissue_Pressure_Injury_by_Skin_Exam_after_First_72_Hours() => 
		__Encounter_with_New_Deep_Tissue_Pressure_Injury_by_Skin_Exam_after_First_72_Hours.Value;

    /// <seealso cref="Encounter_with_New_Deep_Tissue_Pressure_Injury_Not_POA"/>
	private IEnumerable<Encounter> Encounter_with_New_Deep_Tissue_Pressure_Injury_Not_POA_Value()
	{
		IEnumerable<Encounter> a_ = this.Encounter_with_New_Deep_Tissue_Pressure_Injury_Not_POA_by_Indicator();
		IEnumerable<Encounter> b_ = this.Encounter_with_New_Deep_Tissue_Pressure_Injury_by_Skin_Exam_after_First_72_Hours();
		IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);

		return c_;
	}

    /// <seealso cref="Encounter_with_New_Deep_Tissue_Pressure_Injury_Not_POA_Value"/>
    [CqlDeclaration("Encounter with New Deep Tissue Pressure Injury Not POA")]
	public IEnumerable<Encounter> Encounter_with_New_Deep_Tissue_Pressure_Injury_Not_POA() => 
		__Encounter_with_New_Deep_Tissue_Pressure_Injury_Not_POA.Value;

    /// <seealso cref="Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_Not_POA_by_Indicator"/>
	private IEnumerable<Encounter> Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_Not_POA_by_Indicator_Value()
	{
		IEnumerable<Encounter> a_ = this.Encounter_with_Age_18_and_Older();
		bool? b_(Encounter InpatientHospitalization)
		{
			List<Encounter.DiagnosisComponent> d_ = InpatientHospitalization?.Diagnosis;
			bool? e_(Encounter.DiagnosisComponent Stage234UnstageablePressureInjury)
			{
				ResourceReference h_ = Stage234UnstageablePressureInjury?.Condition;
				Condition i_ = CQMCommon_2_0_000.getCondition(h_);
				CodeableConcept j_ = i_?.Code;
				CqlConcept k_ = FHIRHelpers_4_3_000.ToConcept(j_);
				CqlValueSet l_ = this.Pressure_Injury_Stage_2__3__4__or_Unstageable_Diagnoses();
				bool? m_ = context.Operators.ConceptInValueSet(k_, l_);
				bool? n_(Extension @this)
				{
					string x_ = @this?.Url;
					FhirUri y_ = context.Operators.Convert<FhirUri>(x_);
					string z_ = FHIRHelpers_4_3_000.ToString(y_);
					bool? aa_ = context.Operators.Equal(z_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

					return aa_;
				};
				IEnumerable<Extension> o_ = context.Operators.Where<Extension>((IEnumerable<Extension>)((Stage234UnstageablePressureInjury is Element)
						? ((Stage234UnstageablePressureInjury as Element).Extension)
						: null), n_);
				DataType p_(Extension @this)
				{
					DataType ab_ = @this?.Value;

					return ab_;
				};
				IEnumerable<DataType> q_ = context.Operators.Select<Extension, DataType>(o_, p_);
				DataType r_ = context.Operators.SingletonFrom<DataType>(q_);
				CodeableConcept s_ = context.Operators.Convert<CodeableConcept>(r_);
				CqlConcept t_ = FHIRHelpers_4_3_000.ToConcept(s_);
				CqlValueSet u_ = this.Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine();
				bool? v_ = context.Operators.ConceptInValueSet(t_, u_);
				bool? w_ = context.Operators.And(m_, v_);

				return w_;
			};
			IEnumerable<Encounter.DiagnosisComponent> f_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)d_, e_);
			bool? g_ = context.Operators.Exists<Encounter.DiagnosisComponent>(f_);

			return g_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    /// <seealso cref="Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_Not_POA_by_Indicator_Value"/>
    [CqlDeclaration("Encounter with New Stage 2, 3, 4 or Unstageable Pressure Injury Not POA by Indicator")]
	public IEnumerable<Encounter> Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_Not_POA_by_Indicator() => 
		__Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_Not_POA_by_Indicator.Value;

    /// <seealso cref="Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_by_Skin_Exam_after_First_24_Hours"/>
	private IEnumerable<Encounter> Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_by_Skin_Exam_after_First_24_Hours_Value()
	{
		IEnumerable<Encounter> a_ = this.Encounter_with_Age_18_and_Older();
		IEnumerable<Encounter> b_(Encounter InpatientHospitalization)
		{
			CqlCode d_ = this.Physical_findings_of_Skin();
			IEnumerable<CqlCode> e_ = context.Operators.ToList<CqlCode>(d_);
			IEnumerable<Observation> f_ = context.Operators.RetrieveByCodes<Observation>(e_, null);
			bool? g_(Observation SkinExam)
			{
				DataType k_ = SkinExam?.Effective;
				object l_ = FHIRHelpers_4_3_000.ToValue(k_);
				CqlInterval<CqlDateTime> m_ = QICoreCommon_2_0_000.ToInterval(l_);
				CqlDateTime n_ = context.Operators.Start(m_);
				CqlInterval<CqlDateTime> o_ = CQMCommon_2_0_000.HospitalizationWithObservation(InpatientHospitalization);
				CqlDateTime p_ = context.Operators.Start(o_);
				CqlQuantity q_ = context.Operators.Quantity(24m, "hours");
				CqlDateTime r_ = context.Operators.Add(p_, q_);
				CqlDateTime t_ = context.Operators.End(o_);
				CqlInterval<CqlDateTime> u_ = context.Operators.Interval(r_, t_, true, true);
				bool? v_ = context.Operators.In<CqlDateTime>(n_, u_, null);
				Code<ObservationStatus> w_ = SkinExam?.StatusElement;
				ObservationStatus? x_ = w_?.Value;
				Code<ObservationStatus> y_ = context.Operators.Convert<Code<ObservationStatus>>(x_);
				string z_ = context.Operators.Convert<string>(y_);
				string[] aa_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				bool? ab_ = context.Operators.In<string>(z_, (aa_ as IEnumerable<string>));
				bool? ac_ = context.Operators.And(v_, ab_);
				DataType ad_ = SkinExam?.Value;
				object ae_ = FHIRHelpers_4_3_000.ToValue(ad_);
				CqlValueSet af_ = this.Pressure_Injury_Stage_2__3__4_or_Unstageable();
				bool? ag_ = context.Operators.ConceptInValueSet((ae_ as CqlConcept), af_);
				List<Observation.ComponentComponent> ah_ = SkinExam?.Component;
				bool? ai_(Observation.ComponentComponent @this)
				{
					CodeableConcept aq_ = @this?.Code;
					CqlConcept ar_ = FHIRHelpers_4_3_000.ToConcept(aq_);
					bool? as_ = context.Operators.Not((bool?)(ar_ is null));

					return as_;
				};
				IEnumerable<Observation.ComponentComponent> aj_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)ah_, ai_);
				CqlConcept ak_(Observation.ComponentComponent @this)
				{
					CodeableConcept at_ = @this?.Code;
					CqlConcept au_ = FHIRHelpers_4_3_000.ToConcept(at_);

					return au_;
				};
				IEnumerable<CqlConcept> al_ = context.Operators.Select<Observation.ComponentComponent, CqlConcept>(aj_, ak_);
				bool? an_ = context.Operators.ConceptsInValueSet(al_, af_);
				bool? ao_ = context.Operators.Or(ag_, an_);
				bool? ap_ = context.Operators.And(ac_, ao_);

				return ap_;
			};
			IEnumerable<Observation> h_ = context.Operators.Where<Observation>(f_, g_);
			Encounter i_(Observation SkinExam) => 
				InpatientHospitalization;
			IEnumerable<Encounter> j_ = context.Operators.Select<Observation, Encounter>(h_, i_);

			return j_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    /// <seealso cref="Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_by_Skin_Exam_after_First_24_Hours_Value"/>
    [CqlDeclaration("Encounter with New Stage 2, 3, 4 or Unstageable Pressure Injury by Skin Exam after First 24 Hours")]
	public IEnumerable<Encounter> Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_by_Skin_Exam_after_First_24_Hours() => 
		__Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_by_Skin_Exam_after_First_24_Hours.Value;

    /// <seealso cref="Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_Not_POA"/>
	private IEnumerable<Encounter> Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_Not_POA_Value()
	{
		IEnumerable<Encounter> a_ = this.Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_Not_POA_by_Indicator();
		IEnumerable<Encounter> b_ = this.Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_by_Skin_Exam_after_First_24_Hours();
		IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);

		return c_;
	}

    /// <seealso cref="Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_Not_POA_Value"/>
    [CqlDeclaration("Encounter with New Stage 2, 3, 4 or Unstageable Pressure Injury Not POA")]
	public IEnumerable<Encounter> Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_Not_POA() => 
		__Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_Not_POA.Value;

    /// <seealso cref="Numerator"/>
	private IEnumerable<Encounter> Numerator_Value()
	{
		IEnumerable<Encounter> a_ = this.Encounter_with_New_Deep_Tissue_Pressure_Injury_Not_POA();
		IEnumerable<Encounter> b_ = this.Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_Not_POA();
		IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);

		return c_;
	}

    /// <seealso cref="Numerator_Value"/>
    [CqlDeclaration("Numerator")]
	public IEnumerable<Encounter> Numerator() => 
		__Numerator.Value;

    /// <seealso cref="SDE_Ethnicity"/>
	private Tuple_HPcCiDPXQfZTXIORThMLfTQDR SDE_Ethnicity_Value()
	{
		Tuple_HPcCiDPXQfZTXIORThMLfTQDR a_ = SupplementalDataElements_3_4_000.SDE_Ethnicity();

		return a_;
	}

    /// <seealso cref="SDE_Ethnicity_Value"/>
    [CqlDeclaration("SDE Ethnicity")]
	public Tuple_HPcCiDPXQfZTXIORThMLfTQDR SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

    /// <seealso cref="SDE_Payer"/>
	private IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ> SDE_Payer_Value()
	{
		IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ> a_ = SupplementalDataElements_3_4_000.SDE_Payer();

		return a_;
	}

    /// <seealso cref="SDE_Payer_Value"/>
    [CqlDeclaration("SDE Payer")]
	public IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ> SDE_Payer() => 
		__SDE_Payer.Value;

    /// <seealso cref="SDE_Race"/>
	private Tuple_HPcCiDPXQfZTXIORThMLfTQDR SDE_Race_Value()
	{
		Tuple_HPcCiDPXQfZTXIORThMLfTQDR a_ = SupplementalDataElements_3_4_000.SDE_Race();

		return a_;
	}

    /// <seealso cref="SDE_Race_Value"/>
    [CqlDeclaration("SDE Race")]
	public Tuple_HPcCiDPXQfZTXIORThMLfTQDR SDE_Race() => 
		__SDE_Race.Value;

    /// <seealso cref="SDE_Sex"/>
	private CqlCode SDE_Sex_Value()
	{
		CqlCode a_ = SupplementalDataElements_3_4_000.SDE_Sex();

		return a_;
	}

    /// <seealso cref="SDE_Sex_Value"/>
    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex() => 
		__SDE_Sex.Value;

}
