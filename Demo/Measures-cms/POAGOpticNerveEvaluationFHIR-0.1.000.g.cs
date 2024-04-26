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
[CqlLibrary("POAGOpticNerveEvaluationFHIR", "0.1.000")]
public class POAGOpticNerveEvaluationFHIR_0_1_000
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Care_Services_in_Long_Term_Residential_Facility;
    internal Lazy<CqlValueSet> __Cup_to_Disc_Ratio;
    internal Lazy<CqlValueSet> __Face_to_Face_Interaction;
    internal Lazy<CqlValueSet> __Medical_Reason;
    internal Lazy<CqlValueSet> __Nursing_Facility_Visit;
    internal Lazy<CqlValueSet> __Office_Visit;
    internal Lazy<CqlValueSet> __Ophthalmological_Services;
    internal Lazy<CqlValueSet> __Optic_Disc_Exam_for_Structural_Abnormalities;
    internal Lazy<CqlValueSet> __Outpatient_Consultation;
    internal Lazy<CqlValueSet> __Primary_Open_Angle_Glaucoma;
    internal Lazy<CqlCode> __virtual;
    internal Lazy<CqlCode> __AMB;
    internal Lazy<CqlCode[]> __ActCode;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>> __SDE_Payer;
    internal Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;
    internal Lazy<IEnumerable<Encounter>> __Qualifying_Encounter_During_Measurement_Period;
    internal Lazy<IEnumerable<Encounter>> __Primary_Open_Angle_Glaucoma_Encounter;
    internal Lazy<bool?> __Initial_Population;
    internal Lazy<bool?> __Denominator;
    internal Lazy<IEnumerable<Observation>> __Medical_Reason_for_Not_Performing_Cup_to_Disc_Ratio;
    internal Lazy<IEnumerable<Observation>> __Medical_Reason_for_Not_Performing_Optic_Disc_Exam;
    internal Lazy<bool?> __Denominator_Exceptions;
    internal Lazy<IEnumerable<Observation>> __Cup_to_Disc_Ratio_Performed_with_Result;
    internal Lazy<IEnumerable<Observation>> __Optic_Disc_Exam_Performed_with_Result;
    internal Lazy<bool?> __Numerator;

    #endregion
    public POAGOpticNerveEvaluationFHIR_0_1_000(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_3_000 = new FHIRHelpers_4_3_000(context);
        SupplementalDataElements_3_4_000 = new SupplementalDataElements_3_4_000(context);
        QICoreCommon_2_0_000 = new QICoreCommon_2_0_000(context);

        __Care_Services_in_Long_Term_Residential_Facility = new Lazy<CqlValueSet>(this.Care_Services_in_Long_Term_Residential_Facility_Value);
        __Cup_to_Disc_Ratio = new Lazy<CqlValueSet>(this.Cup_to_Disc_Ratio_Value);
        __Face_to_Face_Interaction = new Lazy<CqlValueSet>(this.Face_to_Face_Interaction_Value);
        __Medical_Reason = new Lazy<CqlValueSet>(this.Medical_Reason_Value);
        __Nursing_Facility_Visit = new Lazy<CqlValueSet>(this.Nursing_Facility_Visit_Value);
        __Office_Visit = new Lazy<CqlValueSet>(this.Office_Visit_Value);
        __Ophthalmological_Services = new Lazy<CqlValueSet>(this.Ophthalmological_Services_Value);
        __Optic_Disc_Exam_for_Structural_Abnormalities = new Lazy<CqlValueSet>(this.Optic_Disc_Exam_for_Structural_Abnormalities_Value);
        __Outpatient_Consultation = new Lazy<CqlValueSet>(this.Outpatient_Consultation_Value);
        __Primary_Open_Angle_Glaucoma = new Lazy<CqlValueSet>(this.Primary_Open_Angle_Glaucoma_Value);
        __virtual = new Lazy<CqlCode>(this.@virtual_Value);
        __AMB = new Lazy<CqlCode>(this.AMB_Value);
        __ActCode = new Lazy<CqlCode[]>(this.ActCode_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __SDE_Ethnicity = new Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
        __Qualifying_Encounter_During_Measurement_Period = new Lazy<IEnumerable<Encounter>>(this.Qualifying_Encounter_During_Measurement_Period_Value);
        __Primary_Open_Angle_Glaucoma_Encounter = new Lazy<IEnumerable<Encounter>>(this.Primary_Open_Angle_Glaucoma_Encounter_Value);
        __Initial_Population = new Lazy<bool?>(this.Initial_Population_Value);
        __Denominator = new Lazy<bool?>(this.Denominator_Value);
        __Medical_Reason_for_Not_Performing_Cup_to_Disc_Ratio = new Lazy<IEnumerable<Observation>>(this.Medical_Reason_for_Not_Performing_Cup_to_Disc_Ratio_Value);
        __Medical_Reason_for_Not_Performing_Optic_Disc_Exam = new Lazy<IEnumerable<Observation>>(this.Medical_Reason_for_Not_Performing_Optic_Disc_Exam_Value);
        __Denominator_Exceptions = new Lazy<bool?>(this.Denominator_Exceptions_Value);
        __Cup_to_Disc_Ratio_Performed_with_Result = new Lazy<IEnumerable<Observation>>(this.Cup_to_Disc_Ratio_Performed_with_Result_Value);
        __Optic_Disc_Exam_Performed_with_Result = new Lazy<IEnumerable<Observation>>(this.Optic_Disc_Exam_Performed_with_Result_Value);
        __Numerator = new Lazy<bool?>(this.Numerator_Value);
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

	private CqlValueSet Cup_to_Disc_Ratio_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1333", null);

    [CqlDeclaration("Cup to Disc Ratio")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1333")]
	public CqlValueSet Cup_to_Disc_Ratio() => 
		__Cup_to_Disc_Ratio.Value;

	private CqlValueSet Face_to_Face_Interaction_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1048", null);

    [CqlDeclaration("Face-to-Face Interaction")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1048")]
	public CqlValueSet Face_to_Face_Interaction() => 
		__Face_to_Face_Interaction.Value;

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

	private CqlValueSet Optic_Disc_Exam_for_Structural_Abnormalities_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1334", null);

    [CqlDeclaration("Optic Disc Exam for Structural Abnormalities")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1334")]
	public CqlValueSet Optic_Disc_Exam_for_Structural_Abnormalities() => 
		__Optic_Disc_Exam_for_Structural_Abnormalities.Value;

	private CqlValueSet Outpatient_Consultation_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", null);

    [CqlDeclaration("Outpatient Consultation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008")]
	public CqlValueSet Outpatient_Consultation() => 
		__Outpatient_Consultation.Value;

	private CqlValueSet Primary_Open_Angle_Glaucoma_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.326", null);

    [CqlDeclaration("Primary Open-Angle Glaucoma")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.326")]
	public CqlValueSet Primary_Open_Angle_Glaucoma() => 
		__Primary_Open_Angle_Glaucoma.Value;

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

	private CqlCode[] ActCode_Value()
	{
		CqlCode[] a_ = new CqlCode[]
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
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("POAGOpticNerveEvaluationFHIR-0.1.000", "Measurement Period", c_);

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

	private IEnumerable<Encounter> Qualifying_Encounter_During_Measurement_Period_Value()
	{
		CqlValueSet a_ = this.Office_Visit();
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		CqlValueSet c_ = this.Ophthalmological_Services();
		IEnumerable<Encounter> d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, null);
		IEnumerable<Encounter> e_ = context.Operators.ListUnion<Encounter>(b_, d_);
		CqlValueSet f_ = this.Outpatient_Consultation();
		IEnumerable<Encounter> g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, null);
		CqlValueSet h_ = this.Nursing_Facility_Visit();
		IEnumerable<Encounter> i_ = context.Operators.RetrieveByValueSet<Encounter>(h_, null);
		IEnumerable<Encounter> j_ = context.Operators.ListUnion<Encounter>(g_, i_);
		IEnumerable<Encounter> k_ = context.Operators.ListUnion<Encounter>(e_, j_);
		CqlValueSet l_ = this.Care_Services_in_Long_Term_Residential_Facility();
		IEnumerable<Encounter> m_ = context.Operators.RetrieveByValueSet<Encounter>(l_, null);
		IEnumerable<Encounter> n_ = context.Operators.ListUnion<Encounter>(k_, m_);
		bool? o_(Encounter QualifyingEncounter)
		{
			CqlInterval<CqlDateTime> q_ = this.Measurement_Period();
			CqlInterval<CqlDateTime> r_ = FHIRHelpers_4_3_000.ToInterval(QualifyingEncounter?.Period);
			bool? s_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(q_, r_, null);
			Code<Encounter.EncounterStatus> t_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(QualifyingEncounter?.StatusElement?.Value);
			bool? u_ = context.Operators.Equal(t_, "finished");
			bool? v_ = context.Operators.And(s_, u_);
			CqlCode w_ = FHIRHelpers_4_3_000.ToCode(QualifyingEncounter?.Class);
			CqlCode x_ = this.@virtual();
			bool? y_ = context.Operators.Equivalent(w_, x_);
			bool? z_ = context.Operators.Not(y_);
			bool? aa_ = context.Operators.And(v_, z_);

			return aa_;
		};
		IEnumerable<Encounter> p_ = context.Operators.Where<Encounter>(n_, o_);

		return p_;
	}

    [CqlDeclaration("Qualifying Encounter During Measurement Period")]
	public IEnumerable<Encounter> Qualifying_Encounter_During_Measurement_Period() => 
		__Qualifying_Encounter_During_Measurement_Period.Value;

	private IEnumerable<Encounter> Primary_Open_Angle_Glaucoma_Encounter_Value()
	{
		IEnumerable<Encounter> a_ = this.Qualifying_Encounter_During_Measurement_Period();
		IEnumerable<Encounter> b_(Encounter ValidQualifyingEncounter)
		{
			CqlValueSet d_ = this.Primary_Open_Angle_Glaucoma();
			IEnumerable<Condition> e_ = context.Operators.RetrieveByValueSet<Condition>(d_, null);
			bool? f_(Condition PrimaryOpenAngleGlaucoma)
			{
				CqlInterval<CqlDateTime> j_ = QICoreCommon_2_0_000.prevalenceInterval(PrimaryOpenAngleGlaucoma);
				CqlInterval<CqlDateTime> k_ = FHIRHelpers_4_3_000.ToInterval(ValidQualifyingEncounter?.Period);
				bool? l_ = context.Operators.Overlaps(j_, k_, null);
				bool? m_ = QICoreCommon_2_0_000.isActive(PrimaryOpenAngleGlaucoma);
				bool? n_ = context.Operators.And(l_, m_);
				CqlConcept o_ = FHIRHelpers_4_3_000.ToConcept(PrimaryOpenAngleGlaucoma?.VerificationStatus);
				CqlCode p_ = QICoreCommon_2_0_000.unconfirmed();
				CqlConcept q_ = context.Operators.ConvertCodeToConcept(p_);
				bool? r_ = context.Operators.Equivalent(o_, q_);
				CqlCode t_ = QICoreCommon_2_0_000.refuted();
				CqlConcept u_ = context.Operators.ConvertCodeToConcept(t_);
				bool? v_ = context.Operators.Equivalent(o_, u_);
				bool? w_ = context.Operators.Or(r_, v_);
				CqlCode y_ = QICoreCommon_2_0_000.entered_in_error();
				CqlConcept z_ = context.Operators.ConvertCodeToConcept(y_);
				bool? aa_ = context.Operators.Equivalent(o_, z_);
				bool? ab_ = context.Operators.Or(w_, aa_);
				bool? ac_ = context.Operators.Not(ab_);
				bool? ad_ = context.Operators.And(n_, ac_);

				return ad_;
			};
			IEnumerable<Condition> g_ = context.Operators.Where<Condition>(e_, f_);
			Encounter h_(Condition PrimaryOpenAngleGlaucoma) => 
				ValidQualifyingEncounter;
			IEnumerable<Encounter> i_ = context.Operators.Select<Condition, Encounter>(g_, h_);

			return i_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Primary Open Angle Glaucoma Encounter")]
	public IEnumerable<Encounter> Primary_Open_Angle_Glaucoma_Encounter() => 
		__Primary_Open_Angle_Glaucoma_Encounter.Value;

	private bool? Initial_Population_Value()
	{
		Patient a_ = this.Patient();
		CqlDate b_ = context.Operators.Convert<CqlDate>(a_?.BirthDateElement?.Value);
		CqlInterval<CqlDateTime> c_ = this.Measurement_Period();
		CqlDateTime d_ = context.Operators.Start(c_);
		CqlDate e_ = context.Operators.DateFrom(d_);
		int? f_ = context.Operators.CalculateAgeAt(b_, e_, "year");
		bool? g_ = context.Operators.GreaterOrEqual(f_, 18);
		IEnumerable<Encounter> h_ = this.Primary_Open_Angle_Glaucoma_Encounter();
		bool? i_ = context.Operators.Exists<Encounter>(h_);
		bool? j_ = context.Operators.And(g_, i_);

		return j_;
	}

    [CqlDeclaration("Initial Population")]
	public bool? Initial_Population() => 
		__Initial_Population.Value;

	private bool? Denominator_Value()
	{
		bool? a_ = this.Initial_Population();

		return a_;
	}

    [CqlDeclaration("Denominator")]
	public bool? Denominator() => 
		__Denominator.Value;

	private IEnumerable<Observation> Medical_Reason_for_Not_Performing_Cup_to_Disc_Ratio_Value()
	{
		CqlValueSet a_ = this.Cup_to_Disc_Ratio();
		IEnumerable<Observation> b_ = context.Operators.RetrieveByValueSet<Observation>(a_, null);
		IEnumerable<Observation> d_ = context.Operators.RetrieveByValueSet<Observation>(a_, null);
		IEnumerable<Observation> e_ = context.Operators.ListUnion<Observation>(b_, d_);
		IEnumerable<Observation> f_(Observation CupToDiscExamNotPerformed)
		{
			IEnumerable<Encounter> j_ = this.Primary_Open_Angle_Glaucoma_Encounter();
			bool? k_(Encounter EncounterWithPOAG)
			{
				CqlDateTime o_ = context.Operators.Convert<CqlDateTime>(CupToDiscExamNotPerformed?.IssuedElement?.Value);
				CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_3_000.ToInterval(EncounterWithPOAG?.Period);
				bool? q_ = context.Operators.In<CqlDateTime>(o_, p_, null);

				return q_;
			};
			IEnumerable<Encounter> l_ = context.Operators.Where<Encounter>(j_, k_);
			Observation m_(Encounter EncounterWithPOAG) => 
				CupToDiscExamNotPerformed;
			IEnumerable<Observation> n_ = context.Operators.Select<Encounter, Observation>(l_, m_);

			return n_;
		};
		IEnumerable<Observation> g_ = context.Operators.SelectMany<Observation, Observation>(e_, f_);
		bool? h_(Observation CupToDiscExamNotPerformed)
		{
			bool? r_(Extension @this)
			{
				bool? aa_ = context.Operators.Equal(@this?.Url, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");

				return aa_;
			};
			IEnumerable<Extension> s_ = context.Operators.Where<Extension>(((CupToDiscExamNotPerformed is DomainResource)
					? ((CupToDiscExamNotPerformed as DomainResource).Extension)
					: null), r_);
			DataType t_(Extension @this) => 
				@this?.Value;
			IEnumerable<DataType> u_ = context.Operators.Select<Extension, DataType>(s_, t_);
			DataType v_ = context.Operators.SingletonFrom<DataType>(u_);
			CodeableConcept w_ = context.Operators.Convert<CodeableConcept>(v_);
			CqlConcept x_ = FHIRHelpers_4_3_000.ToConcept(w_);
			CqlValueSet y_ = this.Medical_Reason();
			bool? z_ = context.Operators.ConceptInValueSet(x_, y_);

			return z_;
		};
		IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);

		return i_;
	}

    [CqlDeclaration("Medical Reason for Not Performing Cup to Disc Ratio")]
	public IEnumerable<Observation> Medical_Reason_for_Not_Performing_Cup_to_Disc_Ratio() => 
		__Medical_Reason_for_Not_Performing_Cup_to_Disc_Ratio.Value;

	private IEnumerable<Observation> Medical_Reason_for_Not_Performing_Optic_Disc_Exam_Value()
	{
		CqlValueSet a_ = this.Optic_Disc_Exam_for_Structural_Abnormalities();
		IEnumerable<Observation> b_ = context.Operators.RetrieveByValueSet<Observation>(a_, null);
		IEnumerable<Observation> d_ = context.Operators.RetrieveByValueSet<Observation>(a_, null);
		IEnumerable<Observation> e_ = context.Operators.ListUnion<Observation>(b_, d_);
		IEnumerable<Observation> f_(Observation OpticDiscExamNotPerformed)
		{
			IEnumerable<Encounter> j_ = this.Primary_Open_Angle_Glaucoma_Encounter();
			bool? k_(Encounter EncounterWithPOAG)
			{
				CqlDateTime o_ = context.Operators.Convert<CqlDateTime>(OpticDiscExamNotPerformed?.IssuedElement?.Value);
				CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_3_000.ToInterval(EncounterWithPOAG?.Period);
				bool? q_ = context.Operators.In<CqlDateTime>(o_, p_, null);

				return q_;
			};
			IEnumerable<Encounter> l_ = context.Operators.Where<Encounter>(j_, k_);
			Observation m_(Encounter EncounterWithPOAG) => 
				OpticDiscExamNotPerformed;
			IEnumerable<Observation> n_ = context.Operators.Select<Encounter, Observation>(l_, m_);

			return n_;
		};
		IEnumerable<Observation> g_ = context.Operators.SelectMany<Observation, Observation>(e_, f_);
		bool? h_(Observation OpticDiscExamNotPerformed)
		{
			bool? r_(Extension @this)
			{
				bool? aa_ = context.Operators.Equal(@this?.Url, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");

				return aa_;
			};
			IEnumerable<Extension> s_ = context.Operators.Where<Extension>(((OpticDiscExamNotPerformed is DomainResource)
					? ((OpticDiscExamNotPerformed as DomainResource).Extension)
					: null), r_);
			DataType t_(Extension @this) => 
				@this?.Value;
			IEnumerable<DataType> u_ = context.Operators.Select<Extension, DataType>(s_, t_);
			DataType v_ = context.Operators.SingletonFrom<DataType>(u_);
			CodeableConcept w_ = context.Operators.Convert<CodeableConcept>(v_);
			CqlConcept x_ = FHIRHelpers_4_3_000.ToConcept(w_);
			CqlValueSet y_ = this.Medical_Reason();
			bool? z_ = context.Operators.ConceptInValueSet(x_, y_);

			return z_;
		};
		IEnumerable<Observation> i_ = context.Operators.Where<Observation>(g_, h_);

		return i_;
	}

    [CqlDeclaration("Medical Reason for Not Performing Optic Disc Exam")]
	public IEnumerable<Observation> Medical_Reason_for_Not_Performing_Optic_Disc_Exam() => 
		__Medical_Reason_for_Not_Performing_Optic_Disc_Exam.Value;

	private bool? Denominator_Exceptions_Value()
	{
		IEnumerable<Observation> a_ = this.Medical_Reason_for_Not_Performing_Cup_to_Disc_Ratio();
		bool? b_ = context.Operators.Exists<Observation>(a_);
		IEnumerable<Observation> c_ = this.Medical_Reason_for_Not_Performing_Optic_Disc_Exam();
		bool? d_ = context.Operators.Exists<Observation>(c_);
		bool? e_ = context.Operators.Or(b_, d_);

		return e_;
	}

    [CqlDeclaration("Denominator Exceptions")]
	public bool? Denominator_Exceptions() => 
		__Denominator_Exceptions.Value;

	private IEnumerable<Observation> Cup_to_Disc_Ratio_Performed_with_Result_Value()
	{
		CqlValueSet a_ = this.Cup_to_Disc_Ratio();
		IEnumerable<Observation> b_ = context.Operators.RetrieveByValueSet<Observation>(a_, null);
		IEnumerable<Observation> c_(Observation CupToDiscExamPerformed)
		{
			IEnumerable<Encounter> g_ = this.Primary_Open_Angle_Glaucoma_Encounter();
			bool? h_(Encounter EncounterWithPOAG)
			{
				CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_3_000.ToInterval(EncounterWithPOAG?.Period);
				object m_ = FHIRHelpers_4_3_000.ToValue(CupToDiscExamPerformed?.Effective);
				CqlInterval<CqlDateTime> n_ = QICoreCommon_2_0_000.toInterval(m_);
				bool? o_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(l_, n_, null);

				return o_;
			};
			IEnumerable<Encounter> i_ = context.Operators.Where<Encounter>(g_, h_);
			Observation j_(Encounter EncounterWithPOAG) => 
				CupToDiscExamPerformed;
			IEnumerable<Observation> k_ = context.Operators.Select<Encounter, Observation>(i_, j_);

			return k_;
		};
		IEnumerable<Observation> d_ = context.Operators.SelectMany<Observation, Observation>(b_, c_);
		bool? e_(Observation CupToDiscExamPerformed)
		{
			object p_ = FHIRHelpers_4_3_000.ToValue(CupToDiscExamPerformed?.Value);
			bool? q_ = context.Operators.Not((bool?)(p_ is null));
			Code<ObservationStatus> r_ = context.Operators.Convert<Code<ObservationStatus>>(CupToDiscExamPerformed?.StatusElement?.Value);
			string s_ = context.Operators.Convert<string>(r_);
			string[] t_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			bool? u_ = context.Operators.In<string>(s_, (t_ as IEnumerable<string>));
			bool? v_ = context.Operators.And(q_, u_);

			return v_;
		};
		IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Cup to Disc Ratio Performed with Result")]
	public IEnumerable<Observation> Cup_to_Disc_Ratio_Performed_with_Result() => 
		__Cup_to_Disc_Ratio_Performed_with_Result.Value;

	private IEnumerable<Observation> Optic_Disc_Exam_Performed_with_Result_Value()
	{
		CqlValueSet a_ = this.Optic_Disc_Exam_for_Structural_Abnormalities();
		IEnumerable<Observation> b_ = context.Operators.RetrieveByValueSet<Observation>(a_, null);
		IEnumerable<Observation> c_(Observation OpticDiscExamPerformed)
		{
			IEnumerable<Encounter> g_ = this.Primary_Open_Angle_Glaucoma_Encounter();
			bool? h_(Encounter EncounterWithPOAG)
			{
				CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_3_000.ToInterval(EncounterWithPOAG?.Period);
				object m_ = FHIRHelpers_4_3_000.ToValue(OpticDiscExamPerformed?.Effective);
				CqlInterval<CqlDateTime> n_ = QICoreCommon_2_0_000.toInterval(m_);
				bool? o_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(l_, n_, null);

				return o_;
			};
			IEnumerable<Encounter> i_ = context.Operators.Where<Encounter>(g_, h_);
			Observation j_(Encounter EncounterWithPOAG) => 
				OpticDiscExamPerformed;
			IEnumerable<Observation> k_ = context.Operators.Select<Encounter, Observation>(i_, j_);

			return k_;
		};
		IEnumerable<Observation> d_ = context.Operators.SelectMany<Observation, Observation>(b_, c_);
		bool? e_(Observation OpticDiscExamPerformed)
		{
			object p_ = FHIRHelpers_4_3_000.ToValue(OpticDiscExamPerformed?.Value);
			bool? q_ = context.Operators.Not((bool?)(p_ is null));
			Code<ObservationStatus> r_ = context.Operators.Convert<Code<ObservationStatus>>(OpticDiscExamPerformed?.StatusElement?.Value);
			string s_ = context.Operators.Convert<string>(r_);
			string[] t_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			bool? u_ = context.Operators.In<string>(s_, (t_ as IEnumerable<string>));
			bool? v_ = context.Operators.And(q_, u_);

			return v_;
		};
		IEnumerable<Observation> f_ = context.Operators.Where<Observation>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Optic Disc Exam Performed with Result")]
	public IEnumerable<Observation> Optic_Disc_Exam_Performed_with_Result() => 
		__Optic_Disc_Exam_Performed_with_Result.Value;

	private bool? Numerator_Value()
	{
		IEnumerable<Observation> a_ = this.Cup_to_Disc_Ratio_Performed_with_Result();
		bool? b_ = context.Operators.Exists<Observation>(a_);
		IEnumerable<Observation> c_ = this.Optic_Disc_Exam_Performed_with_Result();
		bool? d_ = context.Operators.Exists<Observation>(c_);
		bool? e_ = context.Operators.And(b_, d_);

		return e_;
	}

    [CqlDeclaration("Numerator")]
	public bool? Numerator() => 
		__Numerator.Value;

}
