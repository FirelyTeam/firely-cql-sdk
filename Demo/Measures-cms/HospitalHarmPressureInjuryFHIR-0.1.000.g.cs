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
    internal Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>> __SDE_Payer;
    internal Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Race;
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
        __SDE_Ethnicity = new Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Race_Value);
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
		CqlCode[] a_ = new CqlCode[]
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
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("HospitalHarmPressureInjuryFHIR-0.1.000", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period.Value;

	private Patient Patient_Value()
	{
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private IEnumerable<Encounter> Encounter_with_Age_18_and_Older_Value()
	{
		CqlValueSet a_ = this.Encounter_Inpatient();
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		bool? c_(Encounter InpatientEncounter)
		{
			Patient e_ = this.Patient();
			CqlDate f_ = context.Operators.Convert<CqlDate>(e_?.BirthDateElement?.Value);
			CqlInterval<CqlDateTime> g_ = FHIRHelpers_4_3_000.ToInterval(InpatientEncounter?.Period);
			CqlDateTime h_ = context.Operators.Start(g_);
			CqlDate i_ = context.Operators.DateFrom(h_);
			int? j_ = context.Operators.CalculateAgeAt(f_, i_, "year");
			bool? k_ = context.Operators.GreaterOrEqual(j_, 18);
			CqlDateTime m_ = context.Operators.End(g_);
			CqlInterval<CqlDateTime> n_ = this.Measurement_Period();
			bool? o_ = context.Operators.In<CqlDateTime>(m_, n_, "day");
			bool? p_ = context.Operators.And(k_, o_);
			Code<Encounter.EncounterStatus> q_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(InpatientEncounter?.StatusElement?.Value);
			bool? r_ = context.Operators.Equal(q_, "finished");
			bool? s_ = context.Operators.And(p_, r_);

			return s_;
		};
		IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Encounter with Age 18 and Older")]
	public IEnumerable<Encounter> Encounter_with_Age_18_and_Older() => 
		__Encounter_with_Age_18_and_Older.Value;

	private IEnumerable<Encounter> Initial_Population_Value()
	{
		IEnumerable<Encounter> a_ = this.Encounter_with_Age_18_and_Older();

		return a_;
	}

    [CqlDeclaration("Initial Population")]
	public IEnumerable<Encounter> Initial_Population() => 
		__Initial_Population.Value;

	private IEnumerable<Encounter> Denominator_Value()
	{
		IEnumerable<Encounter> a_ = this.Initial_Population();

		return a_;
	}

    [CqlDeclaration("Denominator")]
	public IEnumerable<Encounter> Denominator() => 
		__Denominator.Value;

	private IEnumerable<Encounter> Encounter_with_Deep_Tissue_Pressure_Injury_POA_by_Indicator_Value()
	{
		IEnumerable<Encounter> a_ = this.Encounter_with_Age_18_and_Older();
		bool? b_(Encounter InpatientHospitalization)
		{
			bool? d_(Encounter.DiagnosisComponent EncounterDiag)
			{
				Condition g_ = CQMCommon_2_0_000.getCondition(EncounterDiag?.Condition);
				CqlConcept h_ = FHIRHelpers_4_3_000.ToConcept(g_?.Code);
				CqlValueSet i_ = this.Pressure_Injury_Deep_Tissue_Diagnoses();
				bool? j_ = context.Operators.ConceptInValueSet(h_, i_);
				bool? k_(Extension @this)
				{
					FhirUri u_ = context.Operators.Convert<FhirUri>(@this?.Url);
					string v_ = FHIRHelpers_4_3_000.ToString(u_);
					bool? w_ = context.Operators.Equal(v_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

					return w_;
				};
				IEnumerable<Extension> l_ = context.Operators.Where<Extension>(((EncounterDiag is Element)
						? ((EncounterDiag as Element).Extension)
						: null), k_);
				DataType m_(Extension @this) => 
					@this?.Value;
				IEnumerable<DataType> n_ = context.Operators.Select<Extension, DataType>(l_, m_);
				DataType o_ = context.Operators.SingletonFrom<DataType>(n_);
				CodeableConcept p_ = context.Operators.Convert<CodeableConcept>(o_);
				CqlConcept q_ = FHIRHelpers_4_3_000.ToConcept(p_);
				CqlValueSet r_ = this.Present_on_Admission_or_Clinically_Undetermined();
				bool? s_ = context.Operators.ConceptInValueSet(q_, r_);
				bool? t_ = context.Operators.And(j_, s_);

				return t_;
			};
			IEnumerable<Encounter.DiagnosisComponent> e_ = context.Operators.Where<Encounter.DiagnosisComponent>((InpatientHospitalization?.Diagnosis as IEnumerable<Encounter.DiagnosisComponent>), d_);
			bool? f_ = context.Operators.Exists<Encounter.DiagnosisComponent>(e_);

			return f_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with Deep Tissue Pressure Injury POA by Indicator")]
	public IEnumerable<Encounter> Encounter_with_Deep_Tissue_Pressure_Injury_POA_by_Indicator() => 
		__Encounter_with_Deep_Tissue_Pressure_Injury_POA_by_Indicator.Value;

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
				object k_ = FHIRHelpers_4_3_000.ToValue(SkinExam?.Effective);
				CqlInterval<CqlDateTime> l_ = QICoreCommon_2_0_000.ToInterval(k_);
				CqlDateTime m_ = context.Operators.Start(l_);
				CqlInterval<CqlDateTime> n_ = CQMCommon_2_0_000.HospitalizationWithObservation(InpatientHospitalization);
				CqlDateTime o_ = context.Operators.Start(n_);
				CqlDateTime q_ = context.Operators.Start(n_);
				CqlQuantity r_ = context.Operators.Quantity(72m, "hours");
				CqlDateTime s_ = context.Operators.Add(q_, r_);
				CqlInterval<CqlDateTime> t_ = context.Operators.Interval(o_, s_, true, true);
				bool? u_ = context.Operators.In<CqlDateTime>(m_, t_, null);
				Code<ObservationStatus> v_ = context.Operators.Convert<Code<ObservationStatus>>(SkinExam?.StatusElement?.Value);
				string w_ = context.Operators.Convert<string>(v_);
				string[] x_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				bool? y_ = context.Operators.In<string>(w_, (x_ as IEnumerable<string>));
				bool? z_ = context.Operators.And(u_, y_);
				CqlConcept aa_ = FHIRHelpers_4_3_000.ToConcept(SkinExam?.Code);
				CqlValueSet ab_ = this.Pressure_Injury_Deep_Tissue();
				bool? ac_ = context.Operators.ConceptInValueSet(aa_, ab_);
				bool? ad_ = context.Operators.And(z_, ac_);

				return ad_;
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

    [CqlDeclaration("Encounter with Deep Tissue Pressure Injury POA by Skin Exam within First 72 Hours")]
	public IEnumerable<Encounter> Encounter_with_Deep_Tissue_Pressure_Injury_POA_by_Skin_Exam_within_First_72_Hours() => 
		__Encounter_with_Deep_Tissue_Pressure_Injury_POA_by_Skin_Exam_within_First_72_Hours.Value;

	private IEnumerable<Encounter> Encounter_with_Deep_Tissue_Pressure_Injury_POA_Value()
	{
		IEnumerable<Encounter> a_ = this.Encounter_with_Deep_Tissue_Pressure_Injury_POA_by_Indicator();
		IEnumerable<Encounter> b_ = this.Encounter_with_Deep_Tissue_Pressure_Injury_POA_by_Skin_Exam_within_First_72_Hours();
		IEnumerable<Encounter> c_ = context.Operators.ListUnion<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with Deep Tissue Pressure Injury POA")]
	public IEnumerable<Encounter> Encounter_with_Deep_Tissue_Pressure_Injury_POA() => 
		__Encounter_with_Deep_Tissue_Pressure_Injury_POA.Value;

	private IEnumerable<Encounter> Encounter_with_Stage_2__3__4__or_Unstageable_Pressure_Injury_Present_on_Admission_by_POA_Indicator_Value()
	{
		IEnumerable<Encounter> a_ = this.Encounter_with_Age_18_and_Older();
		bool? b_(Encounter InpatientHospitalization)
		{
			bool? d_(Encounter.DiagnosisComponent Stage234UnstageablePressureInjury)
			{
				Condition g_ = CQMCommon_2_0_000.getCondition(Stage234UnstageablePressureInjury?.Condition);
				CqlConcept h_ = FHIRHelpers_4_3_000.ToConcept(g_?.Code);
				CqlValueSet i_ = this.Pressure_Injury_Stage_2__3__4__or_Unstageable_Diagnoses();
				bool? j_ = context.Operators.ConceptInValueSet(h_, i_);
				bool? k_(Extension @this)
				{
					FhirUri u_ = context.Operators.Convert<FhirUri>(@this?.Url);
					string v_ = FHIRHelpers_4_3_000.ToString(u_);
					bool? w_ = context.Operators.Equal(v_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

					return w_;
				};
				IEnumerable<Extension> l_ = context.Operators.Where<Extension>(((Stage234UnstageablePressureInjury is Element)
						? ((Stage234UnstageablePressureInjury as Element).Extension)
						: null), k_);
				DataType m_(Extension @this) => 
					@this?.Value;
				IEnumerable<DataType> n_ = context.Operators.Select<Extension, DataType>(l_, m_);
				DataType o_ = context.Operators.SingletonFrom<DataType>(n_);
				CodeableConcept p_ = context.Operators.Convert<CodeableConcept>(o_);
				CqlConcept q_ = FHIRHelpers_4_3_000.ToConcept(p_);
				CqlValueSet r_ = this.Present_on_Admission_or_Clinically_Undetermined();
				bool? s_ = context.Operators.ConceptInValueSet(q_, r_);
				bool? t_ = context.Operators.And(j_, s_);

				return t_;
			};
			IEnumerable<Encounter.DiagnosisComponent> e_ = context.Operators.Where<Encounter.DiagnosisComponent>((InpatientHospitalization?.Diagnosis as IEnumerable<Encounter.DiagnosisComponent>), d_);
			bool? f_ = context.Operators.Exists<Encounter.DiagnosisComponent>(e_);

			return f_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with Stage 2, 3, 4, or Unstageable Pressure Injury Present on Admission by POA Indicator")]
	public IEnumerable<Encounter> Encounter_with_Stage_2__3__4__or_Unstageable_Pressure_Injury_Present_on_Admission_by_POA_Indicator() => 
		__Encounter_with_Stage_2__3__4__or_Unstageable_Pressure_Injury_Present_on_Admission_by_POA_Indicator.Value;

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
				object k_ = FHIRHelpers_4_3_000.ToValue(SkinExam?.Effective);
				CqlInterval<CqlDateTime> l_ = QICoreCommon_2_0_000.ToInterval(k_);
				CqlDateTime m_ = context.Operators.Start(l_);
				CqlInterval<CqlDateTime> n_ = CQMCommon_2_0_000.HospitalizationWithObservation(InpatientHospitalization);
				CqlDateTime o_ = context.Operators.Start(n_);
				CqlDateTime q_ = context.Operators.Start(n_);
				CqlQuantity r_ = context.Operators.Quantity(24m, "hours");
				CqlDateTime s_ = context.Operators.Add(q_, r_);
				CqlInterval<CqlDateTime> t_ = context.Operators.Interval(o_, s_, true, true);
				bool? u_ = context.Operators.In<CqlDateTime>(m_, t_, null);
				Code<ObservationStatus> v_ = context.Operators.Convert<Code<ObservationStatus>>(SkinExam?.StatusElement?.Value);
				string w_ = context.Operators.Convert<string>(v_);
				string[] x_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				bool? y_ = context.Operators.In<string>(w_, (x_ as IEnumerable<string>));
				bool? z_ = context.Operators.And(u_, y_);
				CqlConcept aa_ = FHIRHelpers_4_3_000.ToConcept(SkinExam?.Code);
				CqlValueSet ab_ = this.Pressure_Injury_Stage_2__3__4_or_Unstageable();
				bool? ac_ = context.Operators.ConceptInValueSet(aa_, ab_);
				bool? ad_ = context.Operators.And(z_, ac_);

				return ad_;
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

    [CqlDeclaration("Encounter with Stage 2, 3, 4 or Unstageable Pressure Injury POA by Skin Exam within 24 Hours")]
	public IEnumerable<Encounter> Encounter_with_Stage_2__3__4_or_Unstageable_Pressure_Injury_POA_by_Skin_Exam_within_24_Hours() => 
		__Encounter_with_Stage_2__3__4_or_Unstageable_Pressure_Injury_POA_by_Skin_Exam_within_24_Hours.Value;

	private IEnumerable<Encounter> Encounter_with_Stage_2__3__4_or_Unstageable_Pressure_Injury_POA_Value()
	{
		IEnumerable<Encounter> a_ = this.Encounter_with_Stage_2__3__4__or_Unstageable_Pressure_Injury_Present_on_Admission_by_POA_Indicator();
		IEnumerable<Encounter> b_ = this.Encounter_with_Stage_2__3__4_or_Unstageable_Pressure_Injury_POA_by_Skin_Exam_within_24_Hours();
		IEnumerable<Encounter> c_ = context.Operators.ListUnion<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with Stage 2, 3, 4 or Unstageable Pressure Injury POA")]
	public IEnumerable<Encounter> Encounter_with_Stage_2__3__4_or_Unstageable_Pressure_Injury_POA() => 
		__Encounter_with_Stage_2__3__4_or_Unstageable_Pressure_Injury_POA.Value;

	private IEnumerable<Encounter> Encounter_with_Diagnosis_of_COVID19_Infection_Value()
	{
		IEnumerable<Encounter> a_ = this.Encounter_with_Age_18_and_Older();
		bool? b_(Encounter InpatientHospitalization)
		{
			IEnumerable<Condition> d_ = CQMCommon_2_0_000.EncounterDiagnosis(InpatientHospitalization);
			bool? e_(Condition EncounterDiag)
			{
				CqlConcept h_ = FHIRHelpers_4_3_000.ToConcept(EncounterDiag?.Code);
				CqlValueSet i_ = this.COVID_19();
				bool? j_ = context.Operators.ConceptInValueSet(h_, i_);

				return j_;
			};
			IEnumerable<Condition> f_ = context.Operators.Where<Condition>(d_, e_);
			bool? g_ = context.Operators.Exists<Condition>(f_);

			return g_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with Diagnosis of COVID19 Infection")]
	public IEnumerable<Encounter> Encounter_with_Diagnosis_of_COVID19_Infection() => 
		__Encounter_with_Diagnosis_of_COVID19_Infection.Value;

	private IEnumerable<Encounter> Denominator_Exclusions_Value()
	{
		IEnumerable<Encounter> a_ = this.Encounter_with_Deep_Tissue_Pressure_Injury_POA();
		IEnumerable<Encounter> b_ = this.Encounter_with_Stage_2__3__4_or_Unstageable_Pressure_Injury_POA();
		IEnumerable<Encounter> c_ = context.Operators.ListUnion<Encounter>(a_, b_);
		IEnumerable<Encounter> d_ = this.Encounter_with_Diagnosis_of_COVID19_Infection();
		IEnumerable<Encounter> e_ = context.Operators.ListUnion<Encounter>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Denominator Exclusions")]
	public IEnumerable<Encounter> Denominator_Exclusions() => 
		__Denominator_Exclusions.Value;

	private IEnumerable<Encounter> Encounter_with_New_Deep_Tissue_Pressure_Injury_Not_POA_by_Indicator_Value()
	{
		IEnumerable<Encounter> a_ = this.Encounter_with_Age_18_and_Older();
		bool? b_(Encounter InpatientHospitalization)
		{
			bool? d_(Encounter.DiagnosisComponent EncounterDiag)
			{
				Condition g_ = CQMCommon_2_0_000.getCondition(EncounterDiag?.Condition);
				CqlConcept h_ = FHIRHelpers_4_3_000.ToConcept(g_?.Code);
				CqlValueSet i_ = this.Pressure_Injury_Deep_Tissue_Diagnoses();
				bool? j_ = context.Operators.ConceptInValueSet(h_, i_);
				bool? k_(Extension @this)
				{
					FhirUri u_ = context.Operators.Convert<FhirUri>(@this?.Url);
					string v_ = FHIRHelpers_4_3_000.ToString(u_);
					bool? w_ = context.Operators.Equal(v_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

					return w_;
				};
				IEnumerable<Extension> l_ = context.Operators.Where<Extension>(((EncounterDiag is Element)
						? ((EncounterDiag as Element).Extension)
						: null), k_);
				DataType m_(Extension @this) => 
					@this?.Value;
				IEnumerable<DataType> n_ = context.Operators.Select<Extension, DataType>(l_, m_);
				DataType o_ = context.Operators.SingletonFrom<DataType>(n_);
				CodeableConcept p_ = context.Operators.Convert<CodeableConcept>(o_);
				CqlConcept q_ = FHIRHelpers_4_3_000.ToConcept(p_);
				CqlValueSet r_ = this.Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine();
				bool? s_ = context.Operators.ConceptInValueSet(q_, r_);
				bool? t_ = context.Operators.And(j_, s_);

				return t_;
			};
			IEnumerable<Encounter.DiagnosisComponent> e_ = context.Operators.Where<Encounter.DiagnosisComponent>((InpatientHospitalization?.Diagnosis as IEnumerable<Encounter.DiagnosisComponent>), d_);
			bool? f_ = context.Operators.Exists<Encounter.DiagnosisComponent>(e_);

			return f_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with New Deep Tissue Pressure Injury Not POA by Indicator")]
	public IEnumerable<Encounter> Encounter_with_New_Deep_Tissue_Pressure_Injury_Not_POA_by_Indicator() => 
		__Encounter_with_New_Deep_Tissue_Pressure_Injury_Not_POA_by_Indicator.Value;

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
				object k_ = FHIRHelpers_4_3_000.ToValue(SkinExam?.Effective);
				CqlInterval<CqlDateTime> l_ = QICoreCommon_2_0_000.ToInterval(k_);
				CqlDateTime m_ = context.Operators.Start(l_);
				CqlInterval<CqlDateTime> n_ = CQMCommon_2_0_000.HospitalizationWithObservation(InpatientHospitalization);
				CqlDateTime o_ = context.Operators.Start(n_);
				CqlQuantity p_ = context.Operators.Quantity(72m, "hours");
				CqlDateTime q_ = context.Operators.Add(o_, p_);
				CqlDateTime s_ = context.Operators.End(n_);
				CqlInterval<CqlDateTime> t_ = context.Operators.Interval(q_, s_, true, true);
				bool? u_ = context.Operators.In<CqlDateTime>(m_, t_, null);
				Code<ObservationStatus> v_ = context.Operators.Convert<Code<ObservationStatus>>(SkinExam?.StatusElement?.Value);
				string w_ = context.Operators.Convert<string>(v_);
				string[] x_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				bool? y_ = context.Operators.In<string>(w_, (x_ as IEnumerable<string>));
				bool? z_ = context.Operators.And(u_, y_);
				object aa_ = FHIRHelpers_4_3_000.ToValue(SkinExam?.Value);
				CqlValueSet ab_ = this.Pressure_Injury_Deep_Tissue();
				bool? ac_ = context.Operators.ConceptInValueSet((aa_ as CqlConcept), ab_);
				bool? ad_(Observation.ComponentComponent @this)
				{
					CqlConcept al_ = FHIRHelpers_4_3_000.ToConcept(@this?.Code);
					bool? am_ = context.Operators.Not((bool?)(al_ is null));

					return am_;
				};
				IEnumerable<Observation.ComponentComponent> ae_ = context.Operators.Where<Observation.ComponentComponent>((SkinExam?.Component as IEnumerable<Observation.ComponentComponent>), ad_);
				CqlConcept af_(Observation.ComponentComponent @this)
				{
					CqlConcept an_ = FHIRHelpers_4_3_000.ToConcept(@this?.Code);

					return an_;
				};
				IEnumerable<CqlConcept> ag_ = context.Operators.Select<Observation.ComponentComponent, CqlConcept>(ae_, af_);
				bool? ai_ = context.Operators.ConceptsInValueSet(ag_, ab_);
				bool? aj_ = context.Operators.Or(ac_, ai_);
				bool? ak_ = context.Operators.And(z_, aj_);

				return ak_;
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

    [CqlDeclaration("Encounter with New Deep Tissue Pressure Injury by Skin Exam after First 72 Hours")]
	public IEnumerable<Encounter> Encounter_with_New_Deep_Tissue_Pressure_Injury_by_Skin_Exam_after_First_72_Hours() => 
		__Encounter_with_New_Deep_Tissue_Pressure_Injury_by_Skin_Exam_after_First_72_Hours.Value;

	private IEnumerable<Encounter> Encounter_with_New_Deep_Tissue_Pressure_Injury_Not_POA_Value()
	{
		IEnumerable<Encounter> a_ = this.Encounter_with_New_Deep_Tissue_Pressure_Injury_Not_POA_by_Indicator();
		IEnumerable<Encounter> b_ = this.Encounter_with_New_Deep_Tissue_Pressure_Injury_by_Skin_Exam_after_First_72_Hours();
		IEnumerable<Encounter> c_ = context.Operators.ListUnion<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with New Deep Tissue Pressure Injury Not POA")]
	public IEnumerable<Encounter> Encounter_with_New_Deep_Tissue_Pressure_Injury_Not_POA() => 
		__Encounter_with_New_Deep_Tissue_Pressure_Injury_Not_POA.Value;

	private IEnumerable<Encounter> Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_Not_POA_by_Indicator_Value()
	{
		IEnumerable<Encounter> a_ = this.Encounter_with_Age_18_and_Older();
		bool? b_(Encounter InpatientHospitalization)
		{
			bool? d_(Encounter.DiagnosisComponent Stage234UnstageablePressureInjury)
			{
				Condition g_ = CQMCommon_2_0_000.getCondition(Stage234UnstageablePressureInjury?.Condition);
				CqlConcept h_ = FHIRHelpers_4_3_000.ToConcept(g_?.Code);
				CqlValueSet i_ = this.Pressure_Injury_Stage_2__3__4__or_Unstageable_Diagnoses();
				bool? j_ = context.Operators.ConceptInValueSet(h_, i_);
				bool? k_(Extension @this)
				{
					FhirUri u_ = context.Operators.Convert<FhirUri>(@this?.Url);
					string v_ = FHIRHelpers_4_3_000.ToString(u_);
					bool? w_ = context.Operators.Equal(v_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter-diagnosisPresentOnAdmission");

					return w_;
				};
				IEnumerable<Extension> l_ = context.Operators.Where<Extension>(((Stage234UnstageablePressureInjury is Element)
						? ((Stage234UnstageablePressureInjury as Element).Extension)
						: null), k_);
				DataType m_(Extension @this) => 
					@this?.Value;
				IEnumerable<DataType> n_ = context.Operators.Select<Extension, DataType>(l_, m_);
				DataType o_ = context.Operators.SingletonFrom<DataType>(n_);
				CodeableConcept p_ = context.Operators.Convert<CodeableConcept>(o_);
				CqlConcept q_ = FHIRHelpers_4_3_000.ToConcept(p_);
				CqlValueSet r_ = this.Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine();
				bool? s_ = context.Operators.ConceptInValueSet(q_, r_);
				bool? t_ = context.Operators.And(j_, s_);

				return t_;
			};
			IEnumerable<Encounter.DiagnosisComponent> e_ = context.Operators.Where<Encounter.DiagnosisComponent>((InpatientHospitalization?.Diagnosis as IEnumerable<Encounter.DiagnosisComponent>), d_);
			bool? f_ = context.Operators.Exists<Encounter.DiagnosisComponent>(e_);

			return f_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with New Stage 2, 3, 4 or Unstageable Pressure Injury Not POA by Indicator")]
	public IEnumerable<Encounter> Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_Not_POA_by_Indicator() => 
		__Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_Not_POA_by_Indicator.Value;

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
				object k_ = FHIRHelpers_4_3_000.ToValue(SkinExam?.Effective);
				CqlInterval<CqlDateTime> l_ = QICoreCommon_2_0_000.ToInterval(k_);
				CqlDateTime m_ = context.Operators.Start(l_);
				CqlInterval<CqlDateTime> n_ = CQMCommon_2_0_000.HospitalizationWithObservation(InpatientHospitalization);
				CqlDateTime o_ = context.Operators.Start(n_);
				CqlQuantity p_ = context.Operators.Quantity(24m, "hours");
				CqlDateTime q_ = context.Operators.Add(o_, p_);
				CqlDateTime s_ = context.Operators.End(n_);
				CqlInterval<CqlDateTime> t_ = context.Operators.Interval(q_, s_, true, true);
				bool? u_ = context.Operators.In<CqlDateTime>(m_, t_, null);
				Code<ObservationStatus> v_ = context.Operators.Convert<Code<ObservationStatus>>(SkinExam?.StatusElement?.Value);
				string w_ = context.Operators.Convert<string>(v_);
				string[] x_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				bool? y_ = context.Operators.In<string>(w_, (x_ as IEnumerable<string>));
				bool? z_ = context.Operators.And(u_, y_);
				object aa_ = FHIRHelpers_4_3_000.ToValue(SkinExam?.Value);
				CqlValueSet ab_ = this.Pressure_Injury_Stage_2__3__4_or_Unstageable();
				bool? ac_ = context.Operators.ConceptInValueSet((aa_ as CqlConcept), ab_);
				bool? ad_(Observation.ComponentComponent @this)
				{
					CqlConcept al_ = FHIRHelpers_4_3_000.ToConcept(@this?.Code);
					bool? am_ = context.Operators.Not((bool?)(al_ is null));

					return am_;
				};
				IEnumerable<Observation.ComponentComponent> ae_ = context.Operators.Where<Observation.ComponentComponent>((SkinExam?.Component as IEnumerable<Observation.ComponentComponent>), ad_);
				CqlConcept af_(Observation.ComponentComponent @this)
				{
					CqlConcept an_ = FHIRHelpers_4_3_000.ToConcept(@this?.Code);

					return an_;
				};
				IEnumerable<CqlConcept> ag_ = context.Operators.Select<Observation.ComponentComponent, CqlConcept>(ae_, af_);
				bool? ai_ = context.Operators.ConceptsInValueSet(ag_, ab_);
				bool? aj_ = context.Operators.Or(ac_, ai_);
				bool? ak_ = context.Operators.And(z_, aj_);

				return ak_;
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

    [CqlDeclaration("Encounter with New Stage 2, 3, 4 or Unstageable Pressure Injury by Skin Exam after First 24 Hours")]
	public IEnumerable<Encounter> Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_by_Skin_Exam_after_First_24_Hours() => 
		__Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_by_Skin_Exam_after_First_24_Hours.Value;

	private IEnumerable<Encounter> Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_Not_POA_Value()
	{
		IEnumerable<Encounter> a_ = this.Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_Not_POA_by_Indicator();
		IEnumerable<Encounter> b_ = this.Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_by_Skin_Exam_after_First_24_Hours();
		IEnumerable<Encounter> c_ = context.Operators.ListUnion<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with New Stage 2, 3, 4 or Unstageable Pressure Injury Not POA")]
	public IEnumerable<Encounter> Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_Not_POA() => 
		__Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_Not_POA.Value;

	private IEnumerable<Encounter> Numerator_Value()
	{
		IEnumerable<Encounter> a_ = this.Encounter_with_New_Deep_Tissue_Pressure_Injury_Not_POA();
		IEnumerable<Encounter> b_ = this.Encounter_with_New_Stage_2__3__4_or_Unstageable_Pressure_Injury_Not_POA();
		IEnumerable<Encounter> c_ = context.Operators.ListUnion<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Numerator")]
	public IEnumerable<Encounter> Numerator() => 
		__Numerator.Value;

	private Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Ethnicity_Value()
	{
		Tuple_DMgHTLENEHBHWJISQgKZGZVMB a_ = SupplementalDataElements_3_4_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX> SDE_Payer_Value()
	{
		IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX> a_ = SupplementalDataElements_3_4_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX> SDE_Payer() => 
		__SDE_Payer.Value;

	private Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Race_Value()
	{
		Tuple_DMgHTLENEHBHWJISQgKZGZVMB a_ = SupplementalDataElements_3_4_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Race() => 
		__SDE_Race.Value;

	private CqlCode SDE_Sex_Value()
	{
		CqlCode a_ = SupplementalDataElements_3_4_000.SDE_Sex();

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex() => 
		__SDE_Sex.Value;

}
