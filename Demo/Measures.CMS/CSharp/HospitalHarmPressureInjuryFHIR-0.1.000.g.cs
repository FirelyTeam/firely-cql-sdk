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

	private CqlValueSet COVID_19_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.140", null);

    [CqlDeclaration("COVID 19")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.140")]
	public CqlValueSet COVID_19() => 
		__COVID_19.Value;

	private CqlValueSet Emergency_Department_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", null);

    [CqlDeclaration("Emergency Department Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292")]
	public CqlValueSet Emergency_Department_Visit() => 
		__Emergency_Department_Visit.Value;

	private CqlValueSet Encounter_Inpatient_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
	public CqlValueSet Encounter_Inpatient() => 
		__Encounter_Inpatient.Value;

	private CqlValueSet Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.198", null);

    [CqlDeclaration("Not Present On Admission or Documentation Insufficient to Determine")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.198")]
	public CqlValueSet Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine() => 
		__Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine.Value;

	private CqlValueSet Observation_Services_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", null);

    [CqlDeclaration("Observation Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143")]
	public CqlValueSet Observation_Services() => 
		__Observation_Services.Value;

	private CqlValueSet Present_on_Admission_or_Clinically_Undetermined_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.197", null);

    [CqlDeclaration("Present on Admission or Clinically Undetermined")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.197")]
	public CqlValueSet Present_on_Admission_or_Clinically_Undetermined() => 
		__Present_on_Admission_or_Clinically_Undetermined.Value;

	private CqlValueSet Pressure_Injury_Deep_Tissue_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.112", null);

    [CqlDeclaration("Pressure Injury Deep Tissue")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.112")]
	public CqlValueSet Pressure_Injury_Deep_Tissue() => 
		__Pressure_Injury_Deep_Tissue.Value;

	private CqlValueSet Pressure_Injury_Deep_Tissue_Diagnoses_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.194", null);

    [CqlDeclaration("Pressure Injury Deep Tissue Diagnoses")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.194")]
	public CqlValueSet Pressure_Injury_Deep_Tissue_Diagnoses() => 
		__Pressure_Injury_Deep_Tissue_Diagnoses.Value;

	private CqlValueSet Pressure_Injury_Stage_2__3__4_or_Unstageable_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.113", null);

    [CqlDeclaration("Pressure Injury Stage 2, 3, 4 or Unstageable")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.113")]
	public CqlValueSet Pressure_Injury_Stage_2__3__4_or_Unstageable() => 
		__Pressure_Injury_Stage_2__3__4_or_Unstageable.Value;

	private CqlValueSet Pressure_Injury_Stage_2__3__4__or_Unstageable_Diagnoses_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.196", null);

    [CqlDeclaration("Pressure Injury Stage 2, 3, 4, or Unstageable Diagnoses")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.196")]
	public CqlValueSet Pressure_Injury_Stage_2__3__4__or_Unstageable_Diagnoses() => 
		__Pressure_Injury_Stage_2__3__4__or_Unstageable_Diagnoses.Value;

	private CqlCode Physical_findings_of_Skin_Value() => 
		new CqlCode("8709-8", "http://loinc.org", null, null);

    [CqlDeclaration("Physical findings of Skin")]
	public CqlCode Physical_findings_of_Skin() => 
		__Physical_findings_of_Skin.Value;

	private CqlCode[] LOINC_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("8709-8", "http://loinc.org", null, null),
		};

		return a_;
	}

    [CqlDeclaration("LOINC")]
	public CqlCode[] LOINC() => 
		__LOINC.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		var b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		var c_ = context.Operators.Interval(a_, b_, true, false);
		var d_ = context.ResolveParameter("HospitalHarmPressureInjuryFHIR-0.1.000", "Measurement Period", c_);

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

	private IEnumerable<Encounter> Encounter_with_Age_18_and_Older_Value()
	{
		var a_ = this.Encounter_Inpatient();
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		bool? c_(Encounter InpatientEncounter)
		{
			var e_ = this.Patient();
			var f_ = e_?.BirthDateElement;
			var g_ = f_?.Value;
			var h_ = context.Operators.Convert<CqlDate>(g_);
			var i_ = InpatientEncounter?.Period;
			var j_ = FHIRHelpers_4_3_000.ToInterval(i_);
			var k_ = context.Operators.Start(j_);
			var l_ = context.Operators.DateFrom(k_);
			var m_ = context.Operators.CalculateAgeAt(h_, l_, "year");
			var n_ = context.Operators.GreaterOrEqual(m_, 18);
			var p_ = FHIRHelpers_4_3_000.ToInterval(i_);
			var q_ = context.Operators.End(p_);
			var r_ = this.Measurement_Period();
			var s_ = context.Operators.In<CqlDateTime>(q_, r_, "day");
			var t_ = context.Operators.And(n_, s_);
			var u_ = InpatientEncounter?.StatusElement;
			var v_ = u_?.Value;
			var w_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(v_);
			var x_ = context.Operators.Equal(w_, "finished");
			var y_ = context.Operators.And(t_, x_);

			return y_;
		};
		var d_ = context.Operators.Where<Encounter>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Encounter with Age 18 and Older")]
	public IEnumerable<Encounter> Encounter_with_Age_18_and_Older() => 
		__Encounter_with_Age_18_and_Older.Value;

	private IEnumerable<Encounter> Initial_Population_Value()
	{
		var a_ = this.Encounter_with_Age_18_and_Older();

		return a_;
	}

    [CqlDeclaration("Initial Population")]
	public IEnumerable<Encounter> Initial_Population() => 
		__Initial_Population.Value;

	private IEnumerable<Encounter> Denominator_Value()
	{
		var a_ = this.Initial_Population();

		return a_;
	}

    [CqlDeclaration("Denominator")]
	public IEnumerable<Encounter> Denominator() => 
		__Denominator.Value;

	private IEnumerable<Encounter> Encounter_with_Deep_Tissue_Pressure_Injury_POA_by_Indicator_Value()
	{
		var a_ = this.Encounter_with_Age_18_and_Older();
		bool? b_(Encounter InpatientHospitalization)
		{
			var d_ = InpatientHospitalization?.Diagnosis;
			bool? e_(Encounter.DiagnosisComponent EncounterDiag)
			{
				var h_ = EncounterDiag?.Condition;
				var i_ = CQMCommon_2_0_000.getCondition(h_);
				var j_ = i_?.Code;
				var k_ = FHIRHelpers_4_3_000.ToConcept(j_);
				var l_ = this.Pressure_Injury_Deep_Tissue_Diagnoses();
				var m_ = context.Operators.ConceptInValueSet(k_, l_);
				bool? n_(Extension @this)
				{
					var x_ = @this?.Url;
					var y_ = context.Operators.Convert<FhirUri>(x_);
					var z_ = FHIRHelpers_4_3_000.ToString(y_);
					var aa_ = context.Operators.Equal(z_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

					return aa_;
				};
				var o_ = context.Operators.Where<Extension>((IEnumerable<Extension>)((EncounterDiag is Element)
						? ((EncounterDiag as Element).Extension)
						: null), n_);
				DataType p_(Extension @this)
				{
					var ab_ = @this?.Value;

					return ab_;
				};
				var q_ = context.Operators.Select<Extension, DataType>(o_, p_);
				var r_ = context.Operators.SingletonFrom<DataType>(q_);
				var s_ = context.Operators.Convert<CodeableConcept>(r_);
				var t_ = FHIRHelpers_4_3_000.ToConcept(s_);
				var u_ = this.Present_on_Admission_or_Clinically_Undetermined();
				var v_ = context.Operators.ConceptInValueSet(t_, u_);
				var w_ = context.Operators.And(m_, v_);

				return w_;
			};
			var f_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)d_, e_);
			var g_ = context.Operators.Exists<Encounter.DiagnosisComponent>(f_);

			return g_;
		};
		var c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with Deep Tissue Pressure Injury POA by Indicator")]
	public IEnumerable<Encounter> Encounter_with_Deep_Tissue_Pressure_Injury_POA_by_Indicator() => 
		__Encounter_with_Deep_Tissue_Pressure_Injury_POA_by_Indicator.Value;

	private IEnumerable<Encounter> Encounter_with_Deep_Tissue_Pressure_Injury_POA_by_Skin_Exam_within_First_72_Hours_Value()
	{
		var a_ = this.Encounter_with_Age_18_and_Older();
		IEnumerable<Encounter> b_(Encounter InpatientHospitalization)
		{
			var d_ = this.Physical_findings_of_Skin();
			var e_ = context.Operators.ToList<CqlCode>(d_);
			var f_ = context.Operators.RetrieveByCodes<Observation>(e_, null);
			bool? g_(Observation SkinExam)
			{
				var k_ = SkinExam?.Effective;
				var l_ = FHIRHelpers_4_3_000.ToValue(k_);
				var m_ = QICoreCommon_2_0_000.ToInterval(l_);
				var n_ = context.Operators.Start(m_);
				var o_ = CQMCommon_2_0_000.HospitalizationWithObservation(InpatientHospitalization);
				var p_ = context.Operators.Start(o_);
				var r_ = context.Operators.Start(o_);
				var s_ = context.Operators.Quantity(72m, "hours");
				var t_ = context.Operators.Add(r_, s_);
				var u_ = context.Operators.Interval(p_, t_, true, true);
				var v_ = context.Operators.In<CqlDateTime>(n_, u_, null);
				var w_ = SkinExam?.StatusElement;
				var x_ = w_?.Value;
				var y_ = context.Operators.Convert<Code<ObservationStatus>>(x_);
				var z_ = context.Operators.Convert<string>(y_);
				var aa_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var ab_ = context.Operators.In<string>(z_, (aa_ as IEnumerable<string>));
				var ac_ = context.Operators.And(v_, ab_);
				var ad_ = SkinExam?.Code;
				var ae_ = FHIRHelpers_4_3_000.ToConcept(ad_);
				var af_ = this.Pressure_Injury_Deep_Tissue();
				var ag_ = context.Operators.ConceptInValueSet(ae_, af_);
				var ah_ = context.Operators.And(ac_, ag_);

				return ah_;
			};
			var h_ = context.Operators.Where<Observation>(f_, g_);
			Encounter i_(Observation SkinExam) => 
				InpatientHospitalization;
			var j_ = context.Operators.Select<Observation, Encounter>(h_, i_);

			return j_;
		};
		var c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with Deep Tissue Pressure Injury POA by Skin Exam within First 72 Hours")]
	public IEnumerable<Encounter> Encounter_with_Deep_Tissue_Pressure_Injury_POA_by_Skin_Exam_within_First_72_Hours() => 
		__Encounter_with_Deep_Tissue_Pressure_Injury_POA_by_Skin_Exam_within_First_72_Hours.Value;

	private IEnumerable<Encounter> Encounter_with_Deep_Tissue_Pressure_Injury_POA_Value()
	{
		var a_ = this.Encounter_with_Deep_Tissue_Pressure_Injury_POA_by_Indicator();
		var b_ = this.Encounter_with_Deep_Tissue_Pressure_Injury_POA_by_Skin_Exam_within_First_72_Hours();
		var c_ = context.Operators.Union<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with Deep Tissue Pressure Injury POA")]
	public IEnumerable<Encounter> Encounter_with_Deep_Tissue_Pressure_Injury_POA() => 
		__Encounter_with_Deep_Tissue_Pressure_Injury_POA.Value;

	private IEnumerable<Encounter> Encounter_with_Stage_2__3__4__or_Unstageable_Pressure_Injury_Present_on_Admission_by_POA_Indicator_Value()
	{
		var a_ = this.Encounter_with_Age_18_and_Older();
		bool? b_(Encounter InpatientHospitalization)
		{
			var d_ = InpatientHospitalization?.Diagnosis;
			bool? e_(Encounter.DiagnosisComponent Stage234UnstageablePressureInjury)
			{
				var h_ = Stage234UnstageablePressureInjury?.Condition;
				var i_ = CQMCommon_2_0_000.getCondition(h_);
				var j_ = i_?.Code;
				var k_ = FHIRHelpers_4_3_000.ToConcept(j_);
				var l_ = this.Pressure_Injury_Stage_2__3__4__or_Unstageable_Diagnoses();
				var m_ = context.Operators.ConceptInValueSet(k_, l_);
				bool? n_(Extension @this)
				{
					var x_ = @this?.Url;
					var y_ = context.Operators.Convert<FhirUri>(x_);
					var z_ = FHIRHelpers_4_3_000.ToString(y_);
					var aa_ = context.Operators.Equal(z_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

					return aa_;
				};
				var o_ = context.Operators.Where<Extension>((IEnumerable<Extension>)((Stage234UnstageablePressureInjury is Element)
						? ((Stage234UnstageablePressureInjury as Element).Extension)
						: null), n_);
				DataType p_(Extension @this)
				{
					var ab_ = @this?.Value;

					return ab_;
				};
				var q_ = context.Operators.Select<Extension, DataType>(o_, p_);
				var r_ = context.Operators.SingletonFrom<DataType>(q_);
				var s_ = context.Operators.Convert<CodeableConcept>(r_);
				var t_ = FHIRHelpers_4_3_000.ToConcept(s_);
				var u_ = this.Present_on_Admission_or_Clinically_Undetermined();
				var v_ = context.Operators.ConceptInValueSet(t_, u_);
				var w_ = context.Operators.And(m_, v_);

				return w_;
			};
			var f_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)d_, e_);
			var g_ = context.Operators.Exists<Encounter.DiagnosisComponent>(f_);

			return g_;
		};
		var c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with Stage 2, 3, 4, or Unstageable Pressure Injury Present on Admission by POA Indicator")]
	public IEnumerable<Encounter> Encounter_with_Stage_2__3__4__or_Unstageable_Pressure_Injury_Present_on_Admission_by_POA_Indicator() => 
		__Encounter_with_Stage_2__3__4__or_Unstageable_Pressure_Injury_Present_on_Admission_by_POA_Indicator.Value;

	private IEnumerable<Encounter> Encounter_with_Stage_2__3__4_or_Unstageable_Pressure_Injury_POA_by_Skin_Exam_within_24_Hours_Value()
	{
		var a_ = this.Encounter_with_Age_18_and_Older();
		IEnumerable<Encounter> b_(Encounter InpatientHospitalization)
		{
			var d_ = this.Physical_findings_of_Skin();
			var e_ = context.Operators.ToList<CqlCode>(d_);
			var f_ = context.Operators.RetrieveByCodes<Observation>(e_, null);
			bool? g_(Observation SkinExam)
			{
				var k_ = SkinExam?.Effective;
				var l_ = FHIRHelpers_4_3_000.ToValue(k_);
				var m_ = QICoreCommon_2_0_000.ToInterval(l_);
				var n_ = context.Operators.Start(m_);
				var o_ = CQMCommon_2_0_000.HospitalizationWithObservation(InpatientHospitalization);
				var p_ = context.Operators.Start(o_);
				var r_ = context.Operators.Start(o_);
				var s_ = context.Operators.Quantity(24m, "hours");
				var t_ = context.Operators.Add(r_, s_);
				var u_ = context.Operators.Interval(p_, t_, true, true);
				var v_ = context.Operators.In<CqlDateTime>(n_, u_, null);
				var w_ = SkinExam?.StatusElement;
				var x_ = w_?.Value;
				var y_ = context.Operators.Convert<Code<ObservationStatus>>(x_);
				var z_ = context.Operators.Convert<string>(y_);
				var aa_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var ab_ = context.Operators.In<string>(z_, (aa_ as IEnumerable<string>));
				var ac_ = context.Operators.And(v_, ab_);
				var ad_ = SkinExam?.Code;
				var ae_ = FHIRHelpers_4_3_000.ToConcept(ad_);
				var af_ = this.Pressure_Injury_Stage_2__3__4_or_Unstageable();
				var ag_ = context.Operators.ConceptInValueSet(ae_, af_);
				var ah_ = context.Operators.And(ac_, ag_);

				return ah_;
			};
			var h_ = context.Operators.Where<Observation>(f_, g_);
			Encounter i_(Observation SkinExam) => 
				InpatientHospitalization;
			var j_ = context.Operators.Select<Observation, Encounter>(h_, i_);

			return j_;
		};
		var c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with Stage 2, 3, 4 or Unstageable Pressure Injury POA by Skin Exam within 24 Hours")]
	public IEnumerable<Encounter> Encounter_with_Stage_2__3__4_or_Unstageable_Pressure_Injury_POA_by_Skin_Exam_within_24_Hours() => 
		__Encounter_with_Stage_2__3__4_or_Unstageable_Pressure_Injury_POA_by_Skin_Exam_within_24_Hours.Value;

	private IEnumerable<Encounter> Encounter_with_Stage_2__3__4_or_Unstageable_Pressure_Injury_POA_Value()
	{
		var a_ = this.Encounter_with_Stage_2__3__4__or_Unstageable_Pressure_Injury_Present_on_Admission_by_POA_Indicator();
		var b_ = this.Encounter_with_Stage_2__3__4_or_Unstageable_Pressure_Injury_POA_by_Skin_Exam_within_24_Hours();
		var c_ = context.Operators.Union<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with Stage 2, 3, 4 or Unstageable Pressure Injury POA")]
	public IEnumerable<Encounter> Encounter_with_Stage_2__3__4_or_Unstageable_Pressure_Injury_POA() => 
		__Encounter_with_Stage_2__3__4_or_Unstageable_Pressure_Injury_POA.Value;

	private IEnumerable<Encounter> Encounter_with_Diagnosis_of_COVID19_Infection_Value()
	{
		var a_ = this.Encounter_with_Age_18_and_Older();
		bool? b_(Encounter InpatientHospitalization)
		{
			var d_ = CQMCommon_2_0_000.EncounterDiagnosis(InpatientHospitalization);
			bool? e_(Condition EncounterDiag)
			{
				var h_ = EncounterDiag?.Code;
				var i_ = FHIRHelpers_4_3_000.ToConcept(h_);
				var j_ = this.COVID_19();
				var k_ = context.Operators.ConceptInValueSet(i_, j_);

				return k_;
			};
			var f_ = context.Operators.Where<Condition>(d_, e_);
			var g_ = context.Operators.Exists<Condition>(f_);

			return g_;
		};
		var c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with Diagnosis of COVID19 Infection")]
	public IEnumerable<Encounter> Encounter_with_Diagnosis_of_COVID19_Infection() => 
		__Encounter_with_Diagnosis_of_COVID19_Infection.Value;

	private IEnumerable<Encounter> Denominator_Exclusions_Value()
	{
		var a_ = this.Encounter_with_Deep_Tissue_Pressure_Injury_POA();
		var b_ = this.Encounter_with_Stage_2__3__4_or_Unstageable_Pressure_Injury_POA();
		var c_ = context.Operators.Union<Encounter>(a_, b_);
		var d_ = this.Encounter_with_Diagnosis_of_COVID19_Infection();
		var e_ = context.Operators.Union<Encounter>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Denominator Exclusions")]
	public IEnumerable<Encounter> Denominator_Exclusions() => 
		__Denominator_Exclusions.Value;

	private IEnumerable<Encounter> Encounter_with_New_Deep_Tissue_Pressure_Injury_Not_POA_by_Indicator_Value()
	{
		var a_ = this.Encounter_with_Age_18_and_Older();
		bool? b_(Encounter InpatientHospitalization)
		{
			var d_ = InpatientHospitalization?.Diagnosis;
			bool? e_(Encounter.DiagnosisComponent EncounterDiag)
			{
				var h_ = EncounterDiag?.Condition;
				var i_ = CQMCommon_2_0_000.getCondition(h_);
				var j_ = i_?.Code;
				var k_ = FHIRHelpers_4_3_000.ToConcept(j_);
				var l_ = this.Pressure_Injury_Deep_Tissue_Diagnoses();
				var m_ = context.Operators.ConceptInValueSet(k_, l_);
				bool? n_(Extension @this)
				{
					var x_ = @this?.Url;
					var y_ = context.Operators.Convert<FhirUri>(x_);
					var z_ = FHIRHelpers_4_3_000.ToString(y_);
					var aa_ = context.Operators.Equal(z_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

					return aa_;
				};
				var o_ = context.Operators.Where<Extension>((IEnumerable<Extension>)((EncounterDiag is Element)
						? ((EncounterDiag as Element).Extension)
						: null), n_);
				DataType p_(Extension @this)
				{
					var ab_ = @this?.Value;

					return ab_;
				};
				var q_ = context.Operators.Select<Extension, DataType>(o_, p_);
				var r_ = context.Operators.SingletonFrom<DataType>(q_);
				var s_ = context.Operators.Convert<CodeableConcept>(r_);
				var t_ = FHIRHelpers_4_3_000.ToConcept(s_);
				var u_ = this.Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine();
				var v_ = context.Operators.ConceptInValueSet(t_, u_);
				var w_ = context.Operators.And(m_, v_);

				return w_;
			};
			var f_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)d_, e_);
			var g_ = context.Operators.Exists<Encounter.DiagnosisComponent>(f_);

			return g_;
		};
		var c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with New Deep Tissue Pressure Injury Not POA by Indicator")]
	public IEnumerable<Encounter> Encounter_with_New_Deep_Tissue_Pressure_Injury_Not_POA_by_Indicator() => 
		__Encounter_with_New_Deep_Tissue_Pressure_Injury_Not_POA_by_Indicator.Value;

	private IEnumerable<Encounter> Encounter_with_New_Deep_Tissue_Pressure_Injury_by_Skin_Exam_after_First_72_Hours_Value()
	{
		var a_ = this.Encounter_with_Age_18_and_Older();
		IEnumerable<Encounter> b_(Encounter InpatientHospitalization)
		{
			var d_ = this.Physical_findings_of_Skin();
			var e_ = context.Operators.ToList<CqlCode>(d_);
			var f_ = context.Operators.RetrieveByCodes<Observation>(e_, null);
			bool? g_(Observation SkinExam)
			{
				var k_ = SkinExam?.Effective;
				var l_ = FHIRHelpers_4_3_000.ToValue(k_);
				var m_ = QICoreCommon_2_0_000.ToInterval(l_);
				var n_ = context.Operators.Start(m_);
				var o_ = CQMCommon_2_0_000.HospitalizationWithObservation(InpatientHospitalization);
				var p_ = context.Operators.Start(o_);
				var q_ = context.Operators.Quantity(72m, "hours");
				var r_ = context.Operators.Add(p_, q_);
				var t_ = context.Operators.End(o_);
				var u_ = context.Operators.Interval(r_, t_, true, true);
				var v_ = context.Operators.In<CqlDateTime>(n_, u_, null);
				var w_ = SkinExam?.StatusElement;
				var x_ = w_?.Value;
				var y_ = context.Operators.Convert<Code<ObservationStatus>>(x_);
				var z_ = context.Operators.Convert<string>(y_);
				var aa_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var ab_ = context.Operators.In<string>(z_, (aa_ as IEnumerable<string>));
				var ac_ = context.Operators.And(v_, ab_);
				var ad_ = SkinExam?.Value;
				var ae_ = FHIRHelpers_4_3_000.ToValue(ad_);
				var af_ = this.Pressure_Injury_Deep_Tissue();
				var ag_ = context.Operators.ConceptInValueSet((ae_ as CqlConcept), af_);
				var ah_ = SkinExam?.Component;
				bool? ai_(Observation.ComponentComponent @this)
				{
					var aq_ = @this?.Code;
					var ar_ = FHIRHelpers_4_3_000.ToConcept(aq_);
					var as_ = context.Operators.Not((bool?)(ar_ is null));

					return as_;
				};
				var aj_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)ah_, ai_);
				CqlConcept ak_(Observation.ComponentComponent @this)
				{
					var at_ = @this?.Code;
					var au_ = FHIRHelpers_4_3_000.ToConcept(at_);

					return au_;
				};
				var al_ = context.Operators.Select<Observation.ComponentComponent, CqlConcept>(aj_, ak_);
				var an_ = context.Operators.ConceptsInValueSet(al_, af_);
				var ao_ = context.Operators.Or(ag_, an_);
				var ap_ = context.Operators.And(ac_, ao_);

				return ap_;
			};
			var h_ = context.Operators.Where<Observation>(f_, g_);
			Encounter i_(Observation SkinExam) => 
				InpatientHospitalization;
			var j_ = context.Operators.Select<Observation, Encounter>(h_, i_);

			return j_;
		};
		var c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with New Deep Tissue Pressure Injury by Skin Exam after First 72 Hours")]
	public IEnumerable<Encounter> Encounter_with_New_Deep_Tissue_Pressure_Injury_by_Skin_Exam_after_First_72_Hours() => 
		__Encounter_with_New_Deep_Tissue_Pressure_Injury_by_Skin_Exam_after_First_72_Hours.Value;

	private IEnumerable<Encounter> Encounter_with_New_Deep_Tissue_Pressure_Injury_Not_POA_Value()
	{
		var a_ = this.Encounter_with_New_Deep_Tissue_Pressure_Injury_Not_POA_by_Indicator();
		var b_ = this.Encounter_with_New_Deep_Tissue_Pressure_Injury_by_Skin_Exam_after_First_72_Hours();
		var c_ = context.Operators.Union<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with New Deep Tissue Pressure Injury Not POA")]
	public IEnumerable<Encounter> Encounter_with_New_Deep_Tissue_Pressure_Injury_Not_POA() => 
		__Encounter_with_New_Deep_Tissue_Pressure_Injury_Not_POA.Value;

	private IEnumerable<Encounter> Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_Not_POA_by_Indicator_Value()
	{
		var a_ = this.Encounter_with_Age_18_and_Older();
		bool? b_(Encounter InpatientHospitalization)
		{
			var d_ = InpatientHospitalization?.Diagnosis;
			bool? e_(Encounter.DiagnosisComponent Stage234UnstageablePressureInjury)
			{
				var h_ = Stage234UnstageablePressureInjury?.Condition;
				var i_ = CQMCommon_2_0_000.getCondition(h_);
				var j_ = i_?.Code;
				var k_ = FHIRHelpers_4_3_000.ToConcept(j_);
				var l_ = this.Pressure_Injury_Stage_2__3__4__or_Unstageable_Diagnoses();
				var m_ = context.Operators.ConceptInValueSet(k_, l_);
				bool? n_(Extension @this)
				{
					var x_ = @this?.Url;
					var y_ = context.Operators.Convert<FhirUri>(x_);
					var z_ = FHIRHelpers_4_3_000.ToString(y_);
					var aa_ = context.Operators.Equal(z_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

					return aa_;
				};
				var o_ = context.Operators.Where<Extension>((IEnumerable<Extension>)((Stage234UnstageablePressureInjury is Element)
						? ((Stage234UnstageablePressureInjury as Element).Extension)
						: null), n_);
				DataType p_(Extension @this)
				{
					var ab_ = @this?.Value;

					return ab_;
				};
				var q_ = context.Operators.Select<Extension, DataType>(o_, p_);
				var r_ = context.Operators.SingletonFrom<DataType>(q_);
				var s_ = context.Operators.Convert<CodeableConcept>(r_);
				var t_ = FHIRHelpers_4_3_000.ToConcept(s_);
				var u_ = this.Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine();
				var v_ = context.Operators.ConceptInValueSet(t_, u_);
				var w_ = context.Operators.And(m_, v_);

				return w_;
			};
			var f_ = context.Operators.Where<Encounter.DiagnosisComponent>((IEnumerable<Encounter.DiagnosisComponent>)d_, e_);
			var g_ = context.Operators.Exists<Encounter.DiagnosisComponent>(f_);

			return g_;
		};
		var c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with New Stage 2, 3, 4 or Unstageable Pressure Injury Not POA by Indicator")]
	public IEnumerable<Encounter> Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_Not_POA_by_Indicator() => 
		__Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_Not_POA_by_Indicator.Value;

	private IEnumerable<Encounter> Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_by_Skin_Exam_after_First_24_Hours_Value()
	{
		var a_ = this.Encounter_with_Age_18_and_Older();
		IEnumerable<Encounter> b_(Encounter InpatientHospitalization)
		{
			var d_ = this.Physical_findings_of_Skin();
			var e_ = context.Operators.ToList<CqlCode>(d_);
			var f_ = context.Operators.RetrieveByCodes<Observation>(e_, null);
			bool? g_(Observation SkinExam)
			{
				var k_ = SkinExam?.Effective;
				var l_ = FHIRHelpers_4_3_000.ToValue(k_);
				var m_ = QICoreCommon_2_0_000.ToInterval(l_);
				var n_ = context.Operators.Start(m_);
				var o_ = CQMCommon_2_0_000.HospitalizationWithObservation(InpatientHospitalization);
				var p_ = context.Operators.Start(o_);
				var q_ = context.Operators.Quantity(24m, "hours");
				var r_ = context.Operators.Add(p_, q_);
				var t_ = context.Operators.End(o_);
				var u_ = context.Operators.Interval(r_, t_, true, true);
				var v_ = context.Operators.In<CqlDateTime>(n_, u_, null);
				var w_ = SkinExam?.StatusElement;
				var x_ = w_?.Value;
				var y_ = context.Operators.Convert<Code<ObservationStatus>>(x_);
				var z_ = context.Operators.Convert<string>(y_);
				var aa_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var ab_ = context.Operators.In<string>(z_, (aa_ as IEnumerable<string>));
				var ac_ = context.Operators.And(v_, ab_);
				var ad_ = SkinExam?.Value;
				var ae_ = FHIRHelpers_4_3_000.ToValue(ad_);
				var af_ = this.Pressure_Injury_Stage_2__3__4_or_Unstageable();
				var ag_ = context.Operators.ConceptInValueSet((ae_ as CqlConcept), af_);
				var ah_ = SkinExam?.Component;
				bool? ai_(Observation.ComponentComponent @this)
				{
					var aq_ = @this?.Code;
					var ar_ = FHIRHelpers_4_3_000.ToConcept(aq_);
					var as_ = context.Operators.Not((bool?)(ar_ is null));

					return as_;
				};
				var aj_ = context.Operators.Where<Observation.ComponentComponent>((IEnumerable<Observation.ComponentComponent>)ah_, ai_);
				CqlConcept ak_(Observation.ComponentComponent @this)
				{
					var at_ = @this?.Code;
					var au_ = FHIRHelpers_4_3_000.ToConcept(at_);

					return au_;
				};
				var al_ = context.Operators.Select<Observation.ComponentComponent, CqlConcept>(aj_, ak_);
				var an_ = context.Operators.ConceptsInValueSet(al_, af_);
				var ao_ = context.Operators.Or(ag_, an_);
				var ap_ = context.Operators.And(ac_, ao_);

				return ap_;
			};
			var h_ = context.Operators.Where<Observation>(f_, g_);
			Encounter i_(Observation SkinExam) => 
				InpatientHospitalization;
			var j_ = context.Operators.Select<Observation, Encounter>(h_, i_);

			return j_;
		};
		var c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with New Stage 2, 3, 4 or Unstageable Pressure Injury by Skin Exam after First 24 Hours")]
	public IEnumerable<Encounter> Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_by_Skin_Exam_after_First_24_Hours() => 
		__Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_by_Skin_Exam_after_First_24_Hours.Value;

	private IEnumerable<Encounter> Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_Not_POA_Value()
	{
		var a_ = this.Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_Not_POA_by_Indicator();
		var b_ = this.Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_by_Skin_Exam_after_First_24_Hours();
		var c_ = context.Operators.Union<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with New Stage 2, 3, 4 or Unstageable Pressure Injury Not POA")]
	public IEnumerable<Encounter> Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_Not_POA() => 
		__Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_Not_POA.Value;

	private IEnumerable<Encounter> Numerator_Value()
	{
		var a_ = this.Encounter_with_New_Deep_Tissue_Pressure_Injury_Not_POA();
		var b_ = this.Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_Not_POA();
		var c_ = context.Operators.Union<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Numerator")]
	public IEnumerable<Encounter> Numerator() => 
		__Numerator.Value;

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

}
